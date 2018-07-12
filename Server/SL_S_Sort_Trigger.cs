//■■■■■■■■■■■采集物触发总接口■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■采集物事件分类脚本■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■怪物进出区域触发脚本■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■调度状态事件触发脚本■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■怪物路点事件触发脚本■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■怪物进出战斗触发■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■任务、活动、副本采集触发判断■■■■■■■■■■■■■
//■■■■■■■■■■■摆摊触发■■■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■采集物触发总接口■■■■■■■■■■■■■■■■■■■
//采集成功后调用脚本
function OnServerTriggerEvent(%Player,%Event)
{
	%EventID = %Event.GetDataID();
	%EventStr = GetSubStr(%EventID,0,3);
	//echo( "采集物触发总接口 ==" @ %EventID );
	//装备掉落
	//if ( %eventStr $= "550")
	//	return TriggerEvent_551000000( %Player, %Event, %EventID );
	//生活技能相关采集
	if (%eventStr $= "551")
		return OnServerTriggerEvent_551(%Player,%Event,%EventID);

	//任务、活动、副本相关采集
	else if (%eventStr >= 552)
		return OnServerTriggerEvent_552(%Player,%Event,%EventID);

	return true;
}

function OnServerTriggerEvent_551(%Player,%Event,%EventID)
{
	%FuncName = "TriggerEvent_" @ %EventID;
	if (isFunction(%FuncName))
		return eval(%FuncName @ "(%Player, %Event, %EventID);");
	return true;
}





//任务、活动、副本采集触发判断
function OnServerTriggerEvent_552(%Player,%Event,%EventID)
{
	//需要获取任务物品的采集物
	MissionCollectEventDispose(%Player,%Event,%EventID);
	//--------------任务采集处理-----------------------------
	if ($TriggerEvent_Mission[%EventID] !$= "")
	{
		%Count = GetWordCount($TriggerEvent_Mission[%EventID],";");
		if (%Count > 0)
		{
			for (%i =0; %i < %Count; %i++)
			{
				%MissionList = getWord($TriggerEvent_Mission[%EventID],%i,";");
				%MissionID = GetWord(%MissionList,0);
				%FlagID = GetWord(%MissionList,1);

				if (%Player.IsAcceptedMission(%MissionID))
				{
					%MissionFlag2230 = %Player.GetMissionFlag(%MissionID,%FlagID);
					%MissionFlag2330 = %Player.GetMissionFlag(%MissionID,%FlagID + 100);
					if (%MissionFlag2330 < %MissionFlag2230)
					{
						%Player.SetMissionFlag(%MissionID,%FlagID + 100,%MissionFlag2330++);

						%Target = %Player.GetMissionFlag(%MissionID,%FlagID-100);
						if (GetNpcData(%Target,0) >  0)
							%Txt = "击败";
						else if (GetItemData(%Target,0) >  0)
							%Txt = "获取";
						if (%Txt !$= "")
							SendOneScreenMessage(1,%Txt @ "【" @ %MonsterName @ "】 "@ %MissionFlag2330 @ "/" @ %MissionFlag2230,%Player);
						Schedule(500,0,"eval",%Player @ ".UpdateMission(" @ %MissionID @ "); ");
					}
				}
			}
		}
	}
	//-------------------------------------------------------
	%FuncName = "TriggerEvent_" @ %EventID;
	if (isFunction(%FuncName))
		return eval(%FuncName @ "(%Player, %Event, %EventID);");

	return true;
}
//■■■■■■■■■■■采集物事件分类脚本■■■■■■■■■■■■■■■■■■
//范例：TriggerEvent_552030067(%Player, %Event, %EventID);

//■■■■■■■■■■■调度状态事件触发脚本■■■■■■■■■■■■■■■■■
//调度状态总接口
//调度状态触发

//调度状态总接口
function OnScheduleBuffer(%Player,%BuffID,%IsAuto)
{
	//%IsAuto = 0; 手动触发
	//%IsAuto = 1; 自动触发
	//函数一定要返回一个值

	%BuffIni = 1;
	%FuncName = "ScheduleBuff_" @ %BuffID;
	if (isFunction(%FuncName))
		%BuffIni = eval(%FuncName @ "(%Player, %BuffID, %IsAuto);");

	if (%BuffIni == 0)
		%BuffIni = 0;

	//返回非0，表示%buffid需要处理完后移除掉
	return %BuffIni;
}

//调度状态触发
//范例：ScheduleBuff_1000(%Player, %BuffID, %IsAuto);

function ScheduleBuff_2032(%Player,%BuffID,%IsAuto)
{
	if (!%Player.IsSchbuff(2031))
		return true;
	%Exp = $Monster_Exp[%Player.GetLevel(),1] * 3;
	AllAddExp(%Player,%Exp);
	%Player.Setschbuff(2032);
	return 0;
}

function ScheduleBuff_1000(%Player,%BuffID,%IsAuto)
{
	//echo("每分钟进行一些状态检测" );
	if ($SL_HuoDong_Old !$= $SL_HuoDong)
		%Player.SendPlayerString(2,$SL_HuoDong,0);//发送活动配置开关
	if ($SL_YunYingHuoDong_Old !$= $SL_YunYingHuoDong)
		SendPlayerStringToClient(%Player, 10);//发送运营活动配置开关
	//echo("$SL_YunYingHuoDong_Old==" @ $SL_YunYingHuoDong_Old);
	//echo("$SL_YunYingHuoDong==" @ $SL_YunYingHuoDong);
	if ($SL_JieMianKaiGuan_Old !$= $SL_JieMianKaiGuan)
		%Player.SendPlayerString(11,$SL_JieMianKaiGuan,0);//发送界面配置开关
	
	//限时抢购在线更新
	if ($SL_XianShiQiangGou_OldInfo !$= $SL_XianShiQiangGou_NewInfo )
	{
		sendNewXianShiQiangGouItemInfo(%Player, $SL_XianShiQiangGou_NewInfo);
		$SL_XianShiQiangGou_OldInfo = $SL_XianShiQiangGou_NewInfo;
	}
	
	%Player.Setschbuff(1000);
	return 0;
}
//■■■■■■■■■■■怪物路点事件触发脚本■■■■■■■■■■■■■■■■■
//怪物路点总接口
//怪物路点触发

//怪物路点总接口
function onReachWayPoint(%Caster,%PathId,%index)
{
	//%PathId 路点编号
	//%index  路点位置
	//echo( "============================================" );
	//echo(%Caster.getobjectname() @ "  %PathId ==" @  %PathId @  "  %index==" @ %index);
	//echo( "============================================" );
	switch (%PathId)
	{
		case 11030001:schedule(1000,0,"gotocopymap",%Npc,1306);
		case 10100001:HelpDirectByIndex(%Caster.GetPlayerID(),7);
		case 10100007:Schedule(500,0,"eval",%Caster @ ".FlyPathID = 0; ");
		case 10100006:Schedule(500,0,"eval",%Caster @ ".FlyPathID = 0; ");
		case 10010001:Schedule(1000,0,"eval",%Caster @ ".FlyPathID = 0; ");
		case 10010002:Schedule(1000,0,"eval",%Caster @ ".FlyPathID = 0; ");
	}
}


//■■■■■■■■■■■怪物进出战斗触发■■■■■■■■■■■■■■■■■■■
//进入战斗总触发
//离开战斗总触发
//进出战斗触发

//进入战斗总触发
function onCombatBegin(%Npc)
{
	%NpcID = %Npc.GetDataID();

	AddSkill_TongYongAI(%obj,%NpcID);

	%FuncName = "MonsterCombatBegin_" @ %NpcID;

	if (isFunction(%FuncName))
		eval(%FuncName @ "(%Npc);");
}

//离开战斗总触发
function onCombatEnd(%Npc)
{
	%NpcID = %Npc.GetDataID();
	%FuncName = "MonsterCombatEnd_" @ %NpcID;

	if (isFunction(%FuncName))
		eval(%FuncName @ "(%Npc);");
}

//进入战斗触发
//MonsterCombatBegin_440440440(%Npc);
//离开战斗触发
//MonsterCombatEnd_440440440(%Npc);


//■■■■■■■■■■■任务、活动、副本采集触发判断■■■■■■■■■■■■■

//■■■■■■■■■■■任务、活动、副本采集触发判断■■■■■■■■■■■■■


//■■■■■■■■■■■摆摊触发■■■■■■■■■■■■■■■■■■■■■■■
//开始摆摊
function S_StartStallState(%Player)
{
	//%Player.AddBuff( 330640111 );
}

//结束摆摊
function S_EndStallState(%Player)
{
	//%Player.RemoveBuff( 330640111 );
}
//■■■■■■■■■■■摆摊触发■■■■■■■■■■■■■■■■■■■■■■■


