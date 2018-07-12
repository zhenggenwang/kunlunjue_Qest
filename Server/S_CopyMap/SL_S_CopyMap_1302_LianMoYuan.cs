//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//炼魔渊
//==================================================================================

//■■■■【炼魔渊】■■■■【全局变量存放】■■■■■■■
//■■■■【炼魔渊】■■■■【NPC传送对话 】■■■■■■■
//■■■■【炼魔渊】■■■■【开启挑战对话】■■■■■■■
//■■■■【炼魔渊】■■■■【副本创建触发】■■■■■■■
//■■■■【炼魔渊】■■■■【玩家进入副本】■■■■■■■
//■■■■【炼魔渊】■■■■【倒计时触发】■■■■■■■■
//■■■■【炼魔渊】■■■■【Boss刷新函数】■■■■■■■
//■■■■【炼魔渊】■■■■【Boss死亡函数】■■■■■■■
//■■■■【炼魔渊】■■■■【奖励道具使用】■■■■■■■


//■■■■【炼魔渊】■■■■【全局变量存放】■■■■■■■
$SL_LianMoYuan_Boss_Pos = "141.173 -126.84 174.431";
//■■■■【炼魔渊】■■■■【全局变量存放】■■■■■■■


//■■■■【炼魔渊】■■■■【NPC传送对话 】■■■■■■■
function NpcOnTrigger_Dialog_410010204(%Npc,%Player,%State,%Conv,%Param)
{
	//echo( "%State===" @ %State );
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000008);
			if ($SL_LianMoYuan_State_bActive == 1)
				%Conv.AddOption(600000009,600000009);
		case 600000009:
			%Conv.SetType(4);
			if (!SvrIsMyselfHasTeam(%Player.getplayerid()))
			{
				SendOneScreenMessage(2,"请先组织一只队伍再来挑战",%Player);
				SendOneChatMessage($chatMsg_System,"<t>此副本甚是凶险，请先组织一只队伍再来挑战。</t>",%Player);
				return;
			}
			if (%Player.GetLevel() < $SL_LianMoYuan_MinLevel)
			{
				SendOneScreenMessage(2,"您的等级不足，无法进入",%Player);
				SendOneChatMessage($chatMsg_System,"<t>此副本甚是凶险，至少需要" @ $SL_LianMoYuan_MinLevel @ "级才可进入。</t>",%Player);
				return;
			}
			%Activity3030A = GetWord(%Player.GetActivity(3030),0) * 1;
			%Activity3030B = GetWord(%Player.GetActivity(3030),1) * 1;
			if (%Activity3030A <= 0)
			{
				SetAct(%Player,3030,1,%Activity3030B);
				GoToNextMap(%Player,1302,"");
			}
			else
			{
				if (%Activity3030B <= 1)
				{
					%ItemID = 105109201;
					if (%Player.GetItemCount(%ItemID) >= 1)
					{
						%Player.Putitem(%ItemID,-1);
						if (%Player.Additem(1,3030))
						{
							SetAct(%Player,3030,%Activity3030A,%Activity3030B++);
							GoToNextMap(%Player,1302,"");
						}
					}
					else
					{
						%ItemName = GetItemData(%ItemID,1);
						%text = "您缺少【" @ %ItemName @ "】，无法进入";
						SendOneScreenMessage(2,%text,%Player);
						SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
						return;
					}
				}
				else
				{
					%text = "今日挑战次数已达上限!";
					SendOneScreenMessage(2,%text,%Player);
					SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
					return;
				}
			}

	}
}
//■■■■【炼魔渊】■■■■【NPC传送对话 】■■■■■■■



//■■■■【炼魔渊】■■■■【开启挑战对话】■■■■■■■
function NpcOnTrigger_CopyMap_1302_413010021(%Npc,%Player,%State,%Conv,%Param)
{
	%PlayerID = %Player.GetPlayerid();
	%CopyMapID = %Player.GetLayerID();
	//echo( "%PlayerID===" @ %PlayerID @ "   %State==" @ %State );
	switch (%State)
	{
		case 0:
			//echo( "zry很帅===" @  %State @ "   开关==" @ $SL_LianMoYuan_Boss_State[ %CopyMapID ] @ "  %Conv==" @ %Conv @ "  %Player==" @ %Player );
			%Conv.SetText(600000010);
			if ($SL_LianMoYuan_Boss_State[%CopyMapID]   == 0)
			{
				//echo( "开副本选项" );
				%Conv.AddOption(600000011,600000011);
			}
			else
				%Conv.AddOption(600000012,600000012);
		case 600000011:
			%Conv.SetType(4);
			if (!SvrIsMyselfCaption(%PlayerID))
			{
				%text = "你不是队长，请让队长来开启";
				SendOneScreenMessage(2,%text,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
				return;
			}
			if ($SL_LianMoYuan_Boss_State[%CopyMapID] != 0)
				return;
			%Player.ShowDialogOk(2000000002,3,1);

		case 600000012:
			%Conv.SetType(4);
			SptCopymap_1302_CombatFlow(%CopyMapID,%Player);
	}
}
function CopyMap_Begin_1302(%Player)
{
	%PlayerID = %Player.GetPlayerid();
	%CopyMapID = %Player.GetLayerID();
	$SL_LianMoYuan_Boss_State[%CopyMapID] = 1;
	SptCopymap_Close(%CopyMapID);//关闭副本层
	SptCopymap_1302_CombatFlow(%CopyMapID,%Player);
	$SL_LianMoYuan_Schedule[%CopyMapID] = schedule(1000,0,"SL_LianMoYuan_ScheduleTime",%CopyMapID,0);

	%TeammateList = SptCopyMap_GetAllPlayer(%CopyMapID);//获取副本玩家信息
	%TeammateNum = SptCopyMap_GetPlayerCount(%CopyMapID);//获取副本玩家数量
	for (%i = 0; %i < %TeammateNum; %i++)
	{
		%Player = GetWord(%TeammateList,%i);
		%Player.SendPlayerString(3,"0 600",0);
	}
}
//■■■■【炼魔渊】■■■■【开启挑战对话】■■■■■■■



//■■■■【炼魔渊】■■■■【副本创建触发】■■■■■■■
function SvrCopymapOpen_1302_Trigger(%CopyMapID,%CopymapDataID)
{
	$SL_LianMoYuan_Boss_State[%CopyMapID] = 0;
	$SL_LianMoYuan_Boss_Record[%CopyMapID] = 0;
	//
	SpNewNpc3(0,413010021,"161.314 -125.82 173.872",%CopyMapID,270,"1 1 1");
}

//■■■■【炼魔渊】■■■■【副本创建触发】■■■■■■■

//■■■■【炼魔渊】■■■■【玩家进入副本】■■■■■■■
function SptCopymap_OnEnter_1302_Trigger(%CopyMapID,%Player)
{
	//echo( "玩家进入副本=======================================" @ %Player );
	schedule(5000,0,"SptCopymap_OnEnter_1302_Trigger_A",%Player);
}
function SptCopymap_OnEnter_1302_Trigger_A(%Player)
{
	%Player.SendPlayerString(3,"0 99999",0);
}
//■■■■【炼魔渊】■■■■【玩家进入副本】■■■■■■■

//■■■■【炼魔渊】■■■■【倒计时触发】■■■■■■■■
function SL_LianMoYuan_ScheduleTime(%CopyMapID,%Time)
{
	//echo( "倒计时触发===" @ $SL_LianMoYuan_Schedule[ %CopyMapID ] @ "   %CopyMapID===" @ %CopyMapID @ "   %time==" @ %time );
	CanCel($SL_LianMoYuan_Schedule[%CopyMapID]);
	if (%Time >= 600)
	{
		$SL_LianMoYuan_Boss_Record[%CopyMapID] = 26;
		$SL_LianMoYuan_Boss_ID[%CopyMapID].SafeDeleteobject();
		%text = "挑战时间到，本次挑战结束，请在5分钟内离开炼魔渊";
		SendAllChatMessageLayer(0,$Get_Dialog_GeShi[31406]  @ %text @ "</t>",%CopyMapID);	//发送副本层消息( 屏幕左下 )
		SendAllScreenMessageLayer(0,%text,%CopyMapID);	//发送副本层消息( 屏幕中间 )
		RemoveCopyMapOnLeaveTeam(%CopyMapID,3);
		return;
	}
	$LianMoYuanRecordLastTime[%CopyMapID] = 600 - %Time;
	if (%Time%30 == 0)
	{
		%text = "本次挑战还剩" @ 600 - %Time @ "秒";
		SendAllChatMessageLayer(0,$Get_Dialog_GeShi[31406]  @ %text @ "</t>",%CopyMapID);	//发送副本层消息( 屏幕左下 )
		SendAllScreenMessageLayer(0,%text,%CopyMapID);	//发送副本层消息( 屏幕中间 )
	}

	$SL_LianMoYuan_Schedule[%CopyMapID] = schedule(1000,0,"SL_LianMoYuan_ScheduleTime",%CopyMapID,%Time++);
}
//■■■■【炼魔渊】■■■■【倒计时触发】■■■■■■■■

//■■■■【炼魔渊】■■■■【Boss刷新函数】■■■■■■■
function  SptCopymap_1302_CombatFlow(%CopyMapID,%Player)
{
	//echo( "$SL_LianMoYuan_Boss_ID[ " @ %CopyMapID @ "].GetDamageState( ) ===" @ $SL_LianMoYuan_Boss_ID[ %CopyMapID ].GetDamageState( ) );
	if ($SL_LianMoYuan_Boss_ID[%CopyMapID].GetDamageState() $= "Enabled")
	{
		%text = "当前首领没有死亡，无法挑战下一关。";
		SendOneScreenMessage(2,%text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
		return;
	}
	//echo( "$SL_LianMoYuan_Boss_Record[ " @ %CopyMapID @ " ]========" @ $SL_LianMoYuan_Boss_Record[ %CopyMapID ] );
	%NpcId = 413011027 + $SL_LianMoYuan_Boss_Record[%CopyMapID];
	if (%NpcId >  413011051  || $SL_LianMoYuan_Boss_Record[%CopyMapID] >= 25)
	{
		%text = "本次挑战已经结束";
		SendOneScreenMessage(2,%text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
		return;
	}
	$SL_LianMoYuan_Boss_ID[%CopyMapID] = SpNewNpc3(0,%NpcId,$SL_LianMoYuan_Boss_Pos,%CopyMapID,0,"1 1 1");
}
//■■■■【炼魔渊】■■■■【Boss刷新函数】■■■■■■■


//■■■■【炼魔渊】■■■■【Boss死亡函数】■■■■■■■
function NpcObjectonDeathcast_413011027(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105401,105105451,1); }//413011027	炼魔渊BOSS1
function NpcObjectonDeathcast_413011028(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105402,105105452,2); }//413011028	炼魔渊BOSS2
function NpcObjectonDeathcast_413011029(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105403,105105453,3); }//413011029	炼魔渊BOSS3
function NpcObjectonDeathcast_413011030(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105404,105105454,4); }//413011030	炼魔渊BOSS4
function NpcObjectonDeathcast_413011031(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105405,105105455,5); }//413011031	炼魔渊BOSS5
function NpcObjectonDeathcast_413011032(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105406,105105456,6); }//413011032	炼魔渊BOSS6
function NpcObjectonDeathcast_413011033(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105407,105105457,7); }//413011033	炼魔渊BOSS7
function NpcObjectonDeathcast_413011034(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105408,105105458,8); }//413011034	炼魔渊BOSS8
function NpcObjectonDeathcast_413011035(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105409,105105459,9); }//413011035	炼魔渊BOSS9
function NpcObjectonDeathcast_413011036(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105410,105105460,10); }//413011036 炼魔渊BOSS10
function NpcObjectonDeathcast_413011037(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105411,105105461,11); }//413011037 炼魔渊BOSS11
function NpcObjectonDeathcast_413011038(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105412,105105462,12); }//413011038 炼魔渊BOSS12
function NpcObjectonDeathcast_413011039(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105413,105105463,13); }//413011039 炼魔渊BOSS13
function NpcObjectonDeathcast_413011040(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105414,105105464,14); }//413011040 炼魔渊BOSS14
function NpcObjectonDeathcast_413011041(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105415,105105465,15); }//413011041 炼魔渊BOSS15
function NpcObjectonDeathcast_413011042(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105416,105105466,16); }//413011042 炼魔渊BOSS16
function NpcObjectonDeathcast_413011043(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105417,105105467,17); }//413011043 炼魔渊BOSS17
function NpcObjectonDeathcast_413011044(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105418,105105468,18); }//413011044 炼魔渊BOSS18
function NpcObjectonDeathcast_413011045(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105419,105105469,19); }//413011045 炼魔渊BOSS19
function NpcObjectonDeathcast_413011046(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105420,105105470,20); }//413011046 炼魔渊BOSS20
function NpcObjectonDeathcast_413011047(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105421,105105471,21); }//413011047 炼魔渊BOSS21
function NpcObjectonDeathcast_413011048(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105422,105105472,22); }//413011048 炼魔渊BOSS22
function NpcObjectonDeathcast_413011049(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105423,105105473,23); }//413011049 炼魔渊BOSS23
function NpcObjectonDeathcast_413011050(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105424,105105474,24); }//413011050 炼魔渊BOSS24
function NpcObjectonDeathcast_413011051(%Monster,%Killer){ NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,105105425,105105475,25); }//413011051 炼魔渊BOSS25

function NpcObjectonDeathcast_413011027_413011051(%Monster,%Killer,%ItemID1,%itemid2,%GuanKa)
{
	%CopyMapID = %Killer.GetLayerId();
	$SL_LianMoYuan_Boss_Record[%CopyMapID]++;
	if ($SL_LianMoYuan_Boss_Record[%CopyMapID] > 25)
		return;
	%TeammateList = SptCopyMap_GetAllPlayer(%CopyMapID);//获取副本玩家信息
	%TeammateNum = SptCopyMap_GetPlayerCount(%CopyMapID);//获取副本玩家数量
	//%Txt = "恭喜你挑战【炼魔渊】第 " @ %GuanKa @ " 关成功!";
	for (%i = 0; %i < %TeammateNum; %i++)
	{
		%Player = GetWord(%TeammateList,%i);
		%PlayerID = %Player.GetPlayerid();
		%SendText = $SL_LianMoYuan_Boss_Record[%CopyMapID] @ " " @ $LianMoYuanRecordLastTime[%CopyMapID];
		%Player.SendPlayerString(3,%SendText,0);
		//echo( "%PlayerID==炼魔渊======" @ %PlayerID );
		%Act3028A = getact(%player,3028,0);
		%Act3028B = getact(%player,3028,1);
		if (%GuanKa > %Act3028A)
		{
			%Act3028A++;
			setact(%player,3028,%Act3028A,%Act3028B);
			%ItemID = %ItemID1;
		}
		else
		{
			%ItemID = %ItemID2;
		}
		AddItem_BaoGuoNo_Mail(%Player,%ItemID,1,1,"3 3028");
		//SptMail_Send( %PlayerID, %ItemID, 1, 0, 0, "炼魔渊", %Txt );
		if (%GuanKa == 1)
			AddAchievementWatch(%Player, 0, 39, 1);//记录成就 挑战次数
		AddAchievementWatch(%Player, 1, 173, %GuanKa);//记录玩家成就 最高关卡记录
	}
	if ($SL_LianMoYuan_Boss_Record[%CopyMapID] >= 7)
	{
		%ItemName = GetItemName(%ItemID,1);
		%ItemName2 = GetItemName(%ItemID,2);
		%GuaQiaName = $Get_Dialog_GeShi[60008] @ $SL_LianMoYuan_Boss_Record[%CopyMapID] @ "</t>";
		%B0ssName = $Get_Dialog_GeShi[60008] @  %Monster.GetObjectname() @ "</t>";
		%Player = GetTeamMaster(%Killer);
		%PlayerName2 = GetPlayerZiTiName(%Killer,2);
		%HuoDongMingCheng2 = GetHuoDongName("炼魔渊",2);
		%text2 = %PlayerName2 @ "<t>带领队友成功挑战</t>" @ %HuoDongMingCheng2 @ "<t>第</t>" @ %GuaQiaName @ "<t>关</t>" @ %B0ssName @ "<t>，获得了</t>" @ %ItemName2;
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}

	if ($SL_LianMoYuan_Boss_Record[%CopyMapID] == 25)
	{
		RemoveCopyMapOnLeaveTeam(%CopyMapID,3);
		CanCel($SL_LianMoYuan_Schedule[%CopyMapID]);

		//%HuoDongMingCheng = $Get_Dialog_GeShi[ 31421 ] @ "『炼魔渊』</t>"; //活动名称 橙色
		//%PlayerName = "<l i='"@ %Killer.GetPlayerName( ) @ " "@ %Killer.GetPlayerID( ) @ "' t='name' />";
		//%Text = %PlayerName @ "<t>带领着队友挑战了</t>" @ %HuoDongMingCheng @ "<t>全部关卡，获得了海量宝藏！</t>";
		//SendOneLineMessage( $Get_Dialog_GeShi[ 31419 ] @  %Text @ "</t>" );


		%Player = GetTeamMaster(%Killer);
		%PlayerName2 = GetPlayerZiTiName(%Killer,2);
		%HuoDongMingCheng2 = GetHuoDongName("炼魔渊",2);
		%text2 = %PlayerName2 @ "<t>带领队友通关了</t>" @ %HuoDongMingCheng2;
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
	else
	{
		%text = "成功通过本关卡，赶紧开启下一关卡吧";
		SendAllChatMessageLayer(0,$Get_Dialog_GeShi[31406]  @ %text @ "</t>",%CopyMapID);	//发送副本层消息( 屏幕左下 )
		SendAllScreenMessageLayer(0,%text,%CopyMapID);	//发送副本层消息( 屏幕中间 )
	}
}
//■■■■【炼魔渊】■■■■【Boss死亡函数】■■■■■■■

//■■■■【炼魔渊】■■■■【奖励道具使用】■■■■■■■
$LianMoYuanItem[105105401,1] = "106071001;1;150;2;";//	妖兽之爪
$LianMoYuanItem[105105401,2] = "105105301;1;7110;2;";//金叶子
$LianMoYuanItem[105105401,3] = "105090501;1;1250;2;";//一阶重铸石
$LianMoYuanItem[105105401,4] = "105090601;1;1290;2;";//一阶精炼石
$LianMoYuanItem[105105401,5] = "109011001;1;50;2;";//	《飞烟枪》配方
$LianMoYuanItem[105105401,6] = "109012001;1;50;2;";//	《幽魂刀》配方
$LianMoYuanItem[105105401,7] = "109013001;1;50;2;";//	《螣蛇塔》配方
$LianMoYuanItem[105105401,8] = "109014001;1;50;2;";//	《蓝凌法杖》配方

$LianMoYuanItem[105105402,1] = "106071002;1;150;2;";	  //妖兽之骸
$LianMoYuanItem[105105402,2] = "105105301;1;7110;2;";  //金叶子
$LianMoYuanItem[105105402,3] = "105090511;1;1250;2;";  //二阶重铸石
$LianMoYuanItem[105105402,4] = "105090611;1;1290;2;";  //二阶精炼石
$LianMoYuanItem[105105402,5] = "109011002;1;50;2;";	  //《玄武戟》配方
$LianMoYuanItem[105105402,6] = "109012002;1;50;2;";	  //《碧落剑》配方
$LianMoYuanItem[105105402,7] = "109013002;1;50;2;";	  //《镇魔塔》配方
$LianMoYuanItem[105105402,8] = "109014002;1;50;2;";	  //《青芒权杖》配方


$LianMoYuanItem[105105403,1] = "106071002;1;150;2;";	  //妖兽之骸
$LianMoYuanItem[105105403,2] = "105105301;1;7110;2;";	  //金叶子
$LianMoYuanItem[105105403,3] = "105090511;1;1250;2;";	  //二阶重铸石
$LianMoYuanItem[105105403,4] = "105090611;1;1290;2;";	  //二阶精炼石
$LianMoYuanItem[105105403,5] = "109011002;1;50;2;";	  //《玄武戟》配方
$LianMoYuanItem[105105403,6] = "109012002;1;50;2;";	  //《碧落剑》配方
$LianMoYuanItem[105105403,7] = "109013002;1;50;2;";	  //《镇魔塔》配方
$LianMoYuanItem[105105403,8] = "109014002;1;50;2;";	  //《青芒权杖》配方

$LianMoYuanItem[105105404,1] = "106071003;1;150;2;";	 //妖兽之灰
$LianMoYuanItem[105105404,2] = "105105301;1;7110;2;";	 //金叶子
$LianMoYuanItem[105105404,3] = "105090511;1;1250;2;";	 //二阶重铸石
$LianMoYuanItem[105105404,4] = "105090611;1;1290;2;";	 //二阶精炼石
$LianMoYuanItem[105105404,5] = "109011003;1;50;2;";	 //《六合碎月戟》配方
$LianMoYuanItem[105105404,6] = "109012003;1;50;2;";	 //《墨麟刀》配方
$LianMoYuanItem[105105404,7] = "109013003;1;50;2;";	 //《六道轮回镜》配方
$LianMoYuanItem[105105404,8] = "109014003;1;50;2;";	 //《六爻驱凶杖》配方

$LianMoYuanItem[105105405,1] = "106071003;1;150;2;";	//妖兽之灰
$LianMoYuanItem[105105405,2] = "105105301;1;7110;2;";	//金叶子
$LianMoYuanItem[105105405,3] = "105090511;1;1250;2;";	//二阶重铸石
$LianMoYuanItem[105105405,4] = "105090611;1;1290;2;";	//二阶精炼石
$LianMoYuanItem[105105405,5] = "109011003;1;50;2;";	//《六合碎月戟》配方
$LianMoYuanItem[105105405,6] = "109012003;1;50;2;";	//《墨麟刀》配方
$LianMoYuanItem[105105405,7] = "109013003;1;50;2;";	//《六道轮回镜》配方
$LianMoYuanItem[105105405,8] = "109014003;1;50;2;";	//《六爻驱凶杖》配方

$LianMoYuanItem[105105406,1] = "106071003;1;150;2;";	   //妖兽之灰
$LianMoYuanItem[105105406,2] = "105105301;1;7110;2;";   //金叶子
$LianMoYuanItem[105105406,3] = "105090511;1;1250;2;";   //二阶重铸石
$LianMoYuanItem[105105406,4] = "105090611;1;1290;2;";   //二阶精炼石
$LianMoYuanItem[105105406,5] = "109011003;1;50;2;";	   //《六合碎月戟》配方
$LianMoYuanItem[105105406,6] = "109012003;1;50;2;";	   //《墨麟刀》配方
$LianMoYuanItem[105105406,7] = "109013003;1;50;2;";	   //《六道轮回镜》配方
$LianMoYuanItem[105105406,8] = "109014003;1;50;2;";	   //《六爻驱凶杖》配方

$LianMoYuanItem[105105407,1] = "106071004;1;150;2;";	 //妖兽之心
$LianMoYuanItem[105105407,2] = "105105301;1;7000;2;";	 //金叶子
$LianMoYuanItem[105105407,3] = "105105302;1;80;3;";	 //金锭
$LianMoYuanItem[105105407,4] = "105105303;1;30;3;";	 //金条
$LianMoYuanItem[105105407,5] = "105090521;1;1250;2;";	 //三阶重铸石
$LianMoYuanItem[105105407,6] = "105090621;1;1290;2;";	 //三阶精炼石
$LianMoYuanItem[105105407,7] = "109011004;1;50;2;";	 //《七杀追魂枪》配方
$LianMoYuanItem[105105407,8] = "109012004;1;50;2;";	 //《紫晶剑》配方
$LianMoYuanItem[105105407,9] = "109013004;1;50;2;";	 //《七曜诛邪塔》配方
$LianMoYuanItem[105105407,10]= "109014004;1;50;2;";	 //《七星锁妖杖》配方

$LianMoYuanItem[105105408,1] = "106071004;1;150;2;";	 //妖兽之心
$LianMoYuanItem[105105408,2] = "105105301;1;7000;2;";	 //金叶子
$LianMoYuanItem[105105408,3] = "105105302;1;80;3;";	 //金锭
$LianMoYuanItem[105105408,4] = "105105303;1;30;3;";	 //金条
$LianMoYuanItem[105105408,5] = "105090521;1;1250;2;";	 //三阶重铸石
$LianMoYuanItem[105105408,6] = "105090621;1;1290;2;";	 //三阶精炼石
$LianMoYuanItem[105105408,7] = "109011004;1;50;2;";	 //《七杀追魂枪》配方
$LianMoYuanItem[105105408,8] = "109012004;1;50;2;";	 //《紫晶剑》配方
$LianMoYuanItem[105105408,9] = "109013004;1;50;2;";	 //《七曜诛邪塔》配方
$LianMoYuanItem[105105408,10]= "109014004;1;50;2;";	 //《七星锁妖杖》配方

$LianMoYuanItem[105105409,1] = "106071004;1;150;2;";	  //妖兽之心
$LianMoYuanItem[105105409,2] = "105105301;1;7000;2;";	  //金叶子
$LianMoYuanItem[105105409,3] = "105105302;1;80;3;";	  //金锭
$LianMoYuanItem[105105409,4] = "105105303;1;30;3;";	  //金条
$LianMoYuanItem[105105409,5] = "105090521;1;1250;2;";	  //三阶重铸石
$LianMoYuanItem[105105409,6] = "105090621;1;1290;2;";	  //三阶精炼石
$LianMoYuanItem[105105409,7] = "109011004;1;50;2;";	  //《七杀追魂枪》配方
$LianMoYuanItem[105105409,8] = "109012004;1;50;2;";	  //《紫晶剑》配方
$LianMoYuanItem[105105409,9] = "109013004;1;50;2;";	  //《七曜诛邪塔》配方
$LianMoYuanItem[105105409,10]= "109014004;1;50;2;";	  //《七星锁妖杖》配方

$LianMoYuanItem[105105410,1] = "106071004;1;150;2;";	 //妖兽之心
$LianMoYuanItem[105105410,2] = "105105301;1;7000;2;";	 //金叶子
$LianMoYuanItem[105105410,3] = "105105302;1;80;3;";	 //金锭
$LianMoYuanItem[105105410,4] = "105105303;1;30;3;";	 //金条
$LianMoYuanItem[105105410,5] = "105090521;1;1250;2;";	 //三阶重铸石
$LianMoYuanItem[105105410,6] = "105090621;1;1290;2;";	 //三阶精炼石
$LianMoYuanItem[105105410,7] = "109011004;1;50;2;";	 //《七杀追魂枪》配方
$LianMoYuanItem[105105410,8] = "109012004;1;50;2;";	 //《紫晶剑》配方
$LianMoYuanItem[105105410,9] = "109013004;1;50;2;";	 //《七曜诛邪塔》配方
$LianMoYuanItem[105105410,10]= "109014004;1;50;2;";	 //《七星锁妖杖》配方

$LianMoYuanItem[105105411,1] = "106071004;1;150;2;";	 //妖兽之心
$LianMoYuanItem[105105411,2] = "105105301;1;7000;2;";	 //金叶子
$LianMoYuanItem[105105411,3] = "105105302;1;80;3;";	 //金锭
$LianMoYuanItem[105105411,4] = "105105303;1;30;3;";	 //金条
$LianMoYuanItem[105105411,5] = "105090521;1;1250;2;";	 //三阶重铸石
$LianMoYuanItem[105105411,6] = "105090621;1;1290;2;";	 //三阶精炼石
$LianMoYuanItem[105105411,7] = "109011004;1;50;2;";	 //《七杀追魂枪》配方
$LianMoYuanItem[105105411,8] = "109012004;1;50;2;";	 //《紫晶剑》配方
$LianMoYuanItem[105105411,9] = "109013004;1;50;2;";	 //《七曜诛邪塔》配方
$LianMoYuanItem[105105411,10]= "109014004;1;50;2;";	 //《七星锁妖杖》配方


$LianMoYuanItem[105105412,1] = "106071005;1;150;2;";	//妖兽之晶
$LianMoYuanItem[105105412,2] = "105105301;1;7000;2;";	//金叶子
$LianMoYuanItem[105105412,3] = "105105302;1;80;3;";	//金锭
$LianMoYuanItem[105105412,4] = "105105303;1;30;3;";	//金条
$LianMoYuanItem[105105412,5] = "105090521;1;1250;2;";	//三阶重铸石
$LianMoYuanItem[105105412,6] = "105090621;1;1290;2;";	//三阶精炼石
$LianMoYuanItem[105105412,7] = "109011005;1;50;2;";	//《八荒战龙枪》配方
$LianMoYuanItem[105105412,8] = "109012005;1;50;2;";	//《斩龙刀》配方
$LianMoYuanItem[105105412,9] = "109013005;1;50;2;";	//《八卦伏魔塔》配方
$LianMoYuanItem[105105412,10]= "109014005;1;50;2;";	//《八部天龙杖》配方

$LianMoYuanItem[105105413,1] = "106071005;1;150;2;";		//妖兽之晶
$LianMoYuanItem[105105413,2] = "105105301;1;7000;2;";		//金叶子
$LianMoYuanItem[105105413,3] = "105105302;1;80;3;";		//金锭
$LianMoYuanItem[105105413,4] = "105105303;1;30;3;";		//金条
$LianMoYuanItem[105105413,5] = "105090521;1;1250;2;";		//三阶重铸石
$LianMoYuanItem[105105413,6] = "105090621;1;1290;2;";		//三阶精炼石
$LianMoYuanItem[105105413,7] = "109011005;1;50;2;";		//《八荒战龙枪》配方
$LianMoYuanItem[105105413,8] = "109012005;1;50;2;";		//《斩龙刀》配方
$LianMoYuanItem[105105413,9] = "109013005;1;50;2;";		//《八卦伏魔塔》配方
$LianMoYuanItem[105105413,10]= "109014005;1;50;2;";		//《八部天龙杖》配方

$LianMoYuanItem[105105414,1] = "106071005;1;150;2;";	  //妖兽之晶
$LianMoYuanItem[105105414,2] = "105105301;1;7000;2;";	  //金叶子
$LianMoYuanItem[105105414,3] = "105105302;1;80;3;";	  //金锭
$LianMoYuanItem[105105414,4] = "105105303;1;30;3;";	  //金条
$LianMoYuanItem[105105414,5] = "105090521;1;1250;2;";	  //三阶重铸石
$LianMoYuanItem[105105414,6] = "105090621;1;1290;2;";	  //三阶精炼石
$LianMoYuanItem[105105414,7] = "109011005;1;50;2;";	  //《八荒战龙枪》配方
$LianMoYuanItem[105105414,8] = "109012005;1;50;2;";	  //《斩龙刀》配方
$LianMoYuanItem[105105414,9] = "109013005;1;50;2;";	  //《八卦伏魔塔》配方
$LianMoYuanItem[105105414,10]= "109014005;1;50;2;";	  //《八部天龙杖》配方

$LianMoYuanItem[105105415,1] = "106071005;1;150;2;";	 //妖兽之晶
$LianMoYuanItem[105105415,2] = "105105301;1;7000;2;";	 //金叶子
$LianMoYuanItem[105105415,3] = "105105302;1;80;3;";	 //金锭
$LianMoYuanItem[105105415,4] = "105105303;1;30;3;";	 //金条
$LianMoYuanItem[105105415,5] = "105090521;1;1250;2;";	 //三阶重铸石
$LianMoYuanItem[105105415,6] = "105090621;1;1290;2;";	 //三阶精炼石
$LianMoYuanItem[105105415,7] = "109011005;1;50;2;";	 //《八荒战龙枪》配方
$LianMoYuanItem[105105415,8] = "109012005;1;50;2;";	 //《斩龙刀》配方
$LianMoYuanItem[105105415,9] = "109013005;1;50;2;";	 //《八卦伏魔塔》配方
$LianMoYuanItem[105105415,10]= "109014005;1;50;2;";	 //《八部天龙杖》配方

$LianMoYuanItem[105105416,1] = "106071005;1;150;2;";	 //妖兽之晶
$LianMoYuanItem[105105416,2] = "105105301;1;7000;2;";	 //金叶子
$LianMoYuanItem[105105416,3] = "105105302;1;80;3;";	 //金锭
$LianMoYuanItem[105105416,4] = "105105303;1;30;3;";	 //金条
$LianMoYuanItem[105105416,5] = "105090521;1;1250;2;";	 //三阶重铸石
$LianMoYuanItem[105105416,6] = "105090621;1;1290;2;";	 //三阶精炼石
$LianMoYuanItem[105105416,7] = "109011005;1;50;2;";	 //《八荒战龙枪》配方
$LianMoYuanItem[105105416,8] = "109012005;1;50;2;";	 //《斩龙刀》配方
$LianMoYuanItem[105105416,9] = "109013005;1;50;2;";	 //《八卦伏魔塔》配方
$LianMoYuanItem[105105416,10]= "109014005;1;50;2;";	 //《八部天龙杖》配方

$LianMoYuanItem[105105417,1] = "106071006;1;150;2;"; //	妖兽之精
$LianMoYuanItem[105105417,2] = "105105301;1;7000;2;"; //	金叶子
$LianMoYuanItem[105105417,3] = "105105302;1;80;3;"; //		金锭
$LianMoYuanItem[105105417,4] = "105105303;1;30;3;"; //		金条
$LianMoYuanItem[105105417,5] = "105090531;1;1250;2;"; //	四阶重铸石
$LianMoYuanItem[105105417,6] = "105090631;1;1290;2;"; //	四阶精炼石
$LianMoYuanItem[105105417,7] = "109011006;1;50;2;"; //		《九霄斩魔戟》配方
$LianMoYuanItem[105105417,8] = "109012006;1;50;2;"; //		《赤霄剑》配方
$LianMoYuanItem[105105417,9] = "109013006;1;50;2;"; //		《九天玄穹塔》配方
$LianMoYuanItem[105105417,10]= "109014006;1;50;2;"; //		《九幽精炼杖》配方


$LianMoYuanItem[105105418,1] = "106071006;1;150;2;"; //	妖兽之精
$LianMoYuanItem[105105418,2] = "105105301;1;7000;2;"; //	金叶子
$LianMoYuanItem[105105418,3] = "105105302;1;80;3;"; //		金锭
$LianMoYuanItem[105105418,4] = "105105303;1;30;3;"; //		金条
$LianMoYuanItem[105105418,5] = "105090531;1;1250;2;"; //	四阶重铸石
$LianMoYuanItem[105105418,6] = "105090631;1;1290;2;"; //	四阶精炼石
$LianMoYuanItem[105105418,7] = "109011006;1;50;2;"; //		《九霄斩魔戟》配方
$LianMoYuanItem[105105418,8] = "109012006;1;50;2;"; //		《赤霄剑》配方
$LianMoYuanItem[105105418,9] = "109013006;1;50;2;"; //		《九天玄穹塔》配方
$LianMoYuanItem[105105418,10]= "109014006;1;50;2;"; //		《九幽精炼杖》配方

$LianMoYuanItem[105105419,1] = "106071006;1;150;2;"; //	妖兽之精
$LianMoYuanItem[105105419,2] = "105105301;1;7000;2;"; //	金叶子
$LianMoYuanItem[105105419,3] = "105105302;1;80;3;"; //		金锭
$LianMoYuanItem[105105419,4] = "105105303;1;30;3;"; //		金条
$LianMoYuanItem[105105419,5] = "105090531;1;1250;2;"; //	四阶重铸石
$LianMoYuanItem[105105419,6] = "105090631;1;1290;2;"; //	四阶精炼石
$LianMoYuanItem[105105419,7] = "109011006;1;50;2;"; //		《九霄斩魔戟》配方
$LianMoYuanItem[105105419,8] = "109012006;1;50;2;"; //		《赤霄剑》配方
$LianMoYuanItem[105105419,9] = "109013006;1;50;2;"; //		《九天玄穹塔》配方
$LianMoYuanItem[105105419,10]= "109014006;1;50;2;"; //		《九幽精炼杖》配方

$LianMoYuanItem[105105420,1] = "106071006;1;150;2;"; //	妖兽之精
$LianMoYuanItem[105105420,2] = "105105301;1;7000;2;"; //	金叶子
$LianMoYuanItem[105105420,3] = "105105302;1;80;3;"; //		金锭
$LianMoYuanItem[105105420,4] = "105105303;1;30;3;"; //		金条
$LianMoYuanItem[105105420,5] = "105090531;1;1250;2;"; //	四阶重铸石
$LianMoYuanItem[105105420,6] = "105090631;1;1290;2;"; //	四阶精炼石
$LianMoYuanItem[105105420,7] = "109011006;1;50;2;"; //		《九霄斩魔戟》配方
$LianMoYuanItem[105105420,8] = "109012006;1;50;2;"; //		《赤霄剑》配方
$LianMoYuanItem[105105420,9] = "109013006;1;50;2;"; //		《九天玄穹塔》配方
$LianMoYuanItem[105105420,10]= "109014006;1;50;2;"; //		《九幽精炼杖》配方

$LianMoYuanItem[105105421,1] = "106071006;1;150;2;"; //	妖兽之精
$LianMoYuanItem[105105421,2] = "105105301;1;7000;2;"; //	金叶子
$LianMoYuanItem[105105421,3] = "105105302;1;80;3;"; //		金锭
$LianMoYuanItem[105105421,4] = "105105303;1;30;3;"; //		金条
$LianMoYuanItem[105105421,5] = "105090531;1;1250;2;"; //	四阶重铸石
$LianMoYuanItem[105105421,6] = "105090631;1;1290;2;"; //	四阶精炼石
$LianMoYuanItem[105105421,7] = "109011006;1;50;2;"; //		《九霄斩魔戟》配方
$LianMoYuanItem[105105421,8] = "109012006;1;50;2;"; //		《赤霄剑》配方
$LianMoYuanItem[105105421,9] = "109013006;1;50;2;"; //		《九天玄穹塔》配方
$LianMoYuanItem[105105421,10]= "109014006;1;50;2;"; //		《九幽精炼杖》配方

$LianMoYuanItem[105105422,1] = "106071007;1;150;2;";	 //妖兽之魂
$LianMoYuanItem[105105422,2] = "105105301;1;7000;2;";	 //金叶子
$LianMoYuanItem[105105422,3] = "105105302;1;80;3;";	 //金锭
$LianMoYuanItem[105105422,4] = "105105303;1;30;3;";	 //金条
$LianMoYuanItem[105105422,5] = "105090531;1;1250;2;";	 //四阶重铸石
$LianMoYuanItem[105105422,6] = "105090631;1;1290;2;";	 //四阶精炼石
$LianMoYuanItem[105105422,7] = "109011007;1;50;2;";	 //《贪狼嗜血枪》配方
$LianMoYuanItem[105105422,8] = "109012007;1;50;2;";	 //《龙渊剑》配方
$LianMoYuanItem[105105422,9] = "109013007;1;50;2;";	 //《紫微炎魂塔》配方
$LianMoYuanItem[105105422,10]= "109014007;1;50;2;";	 //《太乙紫金杖》配方

$LianMoYuanItem[105105423,1] = "106071007;1;150;2;";	 //妖兽之魂
$LianMoYuanItem[105105423,2] = "105105301;1;7000;2;";	 //金叶子
$LianMoYuanItem[105105423,3] = "105105302;1;80;3;";	 //金锭
$LianMoYuanItem[105105423,4] = "105105303;1;30;3;";	 //金条
$LianMoYuanItem[105105423,5] = "105090531;1;1250;2;";	 //四阶重铸石
$LianMoYuanItem[105105423,6] = "105090631;1;1290;2;";	 //四阶精炼石
$LianMoYuanItem[105105423,7] = "109011007;1;50;2;";	 //《贪狼嗜血枪》配方
$LianMoYuanItem[105105423,8] = "109012007;1;50;2;";	 //《龙渊剑》配方
$LianMoYuanItem[105105423,9] = "109013007;1;50;2;";	 //《紫微炎魂塔》配方
$LianMoYuanItem[105105423,10]= "109014007;1;50;2;";	 //《太乙紫金杖》配方

$LianMoYuanItem[105105424,1] = "106071007;1;150;2;";	 //妖兽之魂
$LianMoYuanItem[105105424,2] = "105105301;1;7000;2;";	 //金叶子
$LianMoYuanItem[105105424,3] = "105105302;1;80;3;";	 //金锭
$LianMoYuanItem[105105424,4] = "105105303;1;30;3;";	 //金条
$LianMoYuanItem[105105424,5] = "105090531;1;1250;2;";	 //四阶重铸石
$LianMoYuanItem[105105424,6] = "105090631;1;1290;2;";	 //四阶精炼石
$LianMoYuanItem[105105424,7] = "109011007;1;50;2;";	 //《贪狼嗜血枪》配方
$LianMoYuanItem[105105424,8] = "109012007;1;50;2;";	 //《龙渊剑》配方
$LianMoYuanItem[105105424,9] = "109013007;1;50;2;";	 //《紫微炎魂塔》配方
$LianMoYuanItem[105105424,10]= "109014007;1;50;2;";	 //《太乙紫金杖》配方

$LianMoYuanItem[105105425,1] = "106071007;1;150;2;";	 //妖兽之魂
$LianMoYuanItem[105105425,2] = "105105301;1;7000;2;"; //金叶子
$LianMoYuanItem[105105425,3] = "105105302;1;80;3;";	 //金锭
$LianMoYuanItem[105105425,4] = "105105303;1;30;3;";	 //金条
$LianMoYuanItem[105105425,5] = "105090531;1;1250;2;"; //四阶重铸石
$LianMoYuanItem[105105425,6] = "105090631;1;1290;2;"; //四阶精炼石
$LianMoYuanItem[105105425,7] = "109011007;1;50;2;";	 //《贪狼嗜血枪》配方
$LianMoYuanItem[105105425,8] = "109012007;1;50;2;";	 //《龙渊剑》配方
$LianMoYuanItem[105105425,9] = "109013007;1;50;2;";	 //《紫微炎魂塔》配方
$LianMoYuanItem[105105425,10]= "109014007;1;50;2;";	 //《太乙紫金杖》配方


function Trigger_105105401(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105401,800); }//炼魔至宝( 45 )
function Trigger_105105402(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105402,850); }//炼魔至宝( 50 )
function Trigger_105105403(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105403,900); }//炼魔至宝( 55 )
function Trigger_105105404(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105404,950); }//炼魔至宝( 60 )
function Trigger_105105405(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105405,1000); }//炼魔至宝( 65 )
function Trigger_105105406(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105406,1050); }//炼魔至宝( 68 )
function Trigger_105105407(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105407,1100); }//炼魔至宝( 70 )
function Trigger_105105408(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105408,1200); }//炼魔至宝( 72 )
function Trigger_105105409(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105409,1200); }//炼魔至宝( 74 )
function Trigger_105105410(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105410,1200); }//炼魔至宝( 76 )
function Trigger_105105411(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105411,1200); }//炼魔至宝( 78 )
function Trigger_105105412(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105412,1200); }//炼魔至宝( 80 )
function Trigger_105105413(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105413,1200); }//炼魔至宝( 82 )
function Trigger_105105414(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105414,1200); }//炼魔至宝( 84 )
function Trigger_105105415(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105415,1200); }//炼魔至宝( 86 )
function Trigger_105105416(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105416,1200); }//炼魔至宝( 88 )
function Trigger_105105417(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105417,1200); }//炼魔至宝( 90 )
function Trigger_105105418(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105418,1200); }//炼魔至宝( 92 )
function Trigger_105105419(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105419,1200); }//炼魔至宝( 94 )
function Trigger_105105420(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105420,1200); }//炼魔至宝( 96 )
function Trigger_105105421(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105421,1200); }//炼魔至宝( 98 )
function Trigger_105105422(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105422,1200); }//炼魔至宝( 100 )
function Trigger_105105423(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105423,1200); }//炼魔至宝( 102 )
function Trigger_105105424(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105424,1200); }//炼魔至宝( 105 )
function Trigger_105105425(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105425,1200); }//炼魔至宝( 106 )
function Trigger_105105451(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105401,300); }//炼魔秘宝( 45 )
function Trigger_105105452(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105402,350); }//炼魔秘宝( 50 )
function Trigger_105105453(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105403,400); }//炼魔秘宝( 55 )
function Trigger_105105454(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105404,450); }//炼魔秘宝( 60 )
function Trigger_105105455(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105405,500); }//炼魔秘宝( 65 )
function Trigger_105105456(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105406,550); }//炼魔秘宝( 68 )
function Trigger_105105457(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105407,600); }//炼魔秘宝( 70 )
function Trigger_105105458(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105408,700); }//炼魔秘宝( 72 )
function Trigger_105105459(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105409,700); }//炼魔秘宝( 74 )
function Trigger_105105460(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105410,700); }//炼魔秘宝( 76 )
function Trigger_105105461(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105411,700); }//炼魔秘宝( 78 )
function Trigger_105105462(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105412,700); }//炼魔秘宝( 80 )
function Trigger_105105463(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105413,700); }//炼魔秘宝( 82 )
function Trigger_105105464(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105414,700); }//炼魔秘宝( 84 )
function Trigger_105105465(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105415,700); }//炼魔秘宝( 86 )
function Trigger_105105466(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105416,700); }//炼魔秘宝( 88 )
function Trigger_105105467(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105417,700); }//炼魔秘宝( 90 )
function Trigger_105105468(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105418,700); }//炼魔秘宝( 92 )
function Trigger_105105469(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105419,700); }//炼魔秘宝( 94 )
function Trigger_105105470(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105420,700); }//炼魔秘宝( 96 )
function Trigger_105105471(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105421,700); }//炼魔秘宝( 98 )
function Trigger_105105472(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105422,700); }//炼魔秘宝( 100 )
function Trigger_105105473(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105423,700); }//炼魔秘宝( 102 )
function Trigger_105105474(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105424,700); }//炼魔秘宝( 105 )
function Trigger_105105475(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105105425,700); }//炼魔秘宝( 106 )
function LianMoYuanJiangLiItemUse(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%ItemID,%ExpNumber)
{
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"包裹已满，请确保包裹中至少有1格空位！",%Player);
		return;
	}
	%Ran = GetRanDom(1,10000);
	%AllRan = 0;
	for (%i = 1; %i <= 20; %i++)
	{
		if ($LianMoYuanItem[%ItemID,%i] $= "")
			break;
		%OneRan = GetWord($LianMoYuanItem[%ItemID,%i],2,";");
		%AllRan = %AllRan + %OneRan;
		if (%AllRan >= %Ran)
		{
			%GiveItemID = GetWord($LianMoYuanItem[%ItemID,%i],0,";");
			%GiveItemNum = GetWord($LianMoYuanItem[%ItemID,%i],1,";");
			%GiveItemMsg = GetWord($LianMoYuanItem[%ItemID,%i],3,";");
			break;
		}
	}
	if (%GiveItemID > 0 && %GiveItemNum)
	{
		%Player.Putitem(%Type,-1);
		%Player.Putitem(%GiveItemID,%GiveItemNum);
		if (%Player.Additem(1,%Type))
		{
			if (%GiveItemMsg > 0)
			{
				%ItemNameA = GetItemName(%Type,1);
				%ItemNameA2 = GetItemName(%Type,2);

				%ItemNameB = GetItemName(%GiveItemID,1);
				%ItemNameB2 = GetItemName(%GiveItemID,2);

				%Playername = GetPlayerZiTiName(%Player,1);
				%Playername2 = GetPlayerZiTiName(%Player,2);
				%Text = %Playername @ "<t>打开</t>" @ %ItemNameA @ "<t>，从里面翻出</t>" @ %GiveItemNum @ "<t>个</t>" @ %ItemNameB @ "<t>，真是羡煞众人！</t>";
				%Text2 = %Playername2 @ "<t>打开</t>" @ %ItemNameA2 @ "<t>，从里面翻出</t>" @ %GiveItemNum @ "<t>个</t>" @ %ItemNameB2 @ "<t>，真是羡煞众人！</t>";

				switch (%GiveItemMsg)
				{
					case 1:
						SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Text @ "</t>");
					case 2:
						SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
					case 3:
						SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Text @ "</t>");
						SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
				}

			}

			%Level = %Player.GetLevel();
			if (%Level < 55) %levelxishu = 0.3;
			else if (%Level < 60) %levelxishu = 0.6;
			else if (%Level < 70) %levelxishu = 0.7;
			else if (%Level < 80) %levelxishu = 0.8;
			else if (%Level < 90) %levelxishu = 0.9;
			else %levelxishu = 1;
			%Exp = $Monster_Exp[%Level,1] * %ExpNumBer * %levelxishu;
			AllAddExp(%Player,%Exp);
		}
	}
}
//■■■■【炼魔渊】■■■■【奖励道具使用】■■■■■■■
$LianMoYuanItem[105105425,1] = "106071007;1;150;2;";	 //妖兽之魂
$LianMoYuanItem[105105425,2] = "105105301;1;7000;2;"; //金叶子
$LianMoYuanItem[105105425,3] = "105105302;1;80;3;";	 //金锭
$LianMoYuanItem[105105425,4] = "105105303;1;30;3;";	 //金条
$LianMoYuanItem[105105425,5] = "105090531;1;1250;2;"; //四阶重铸石
$LianMoYuanItem[105105425,6] = "105090631;1;1290;2;"; //四阶精炼石
$LianMoYuanItem[105105425,7] = "109011007;1;50;2;";	 //《贪狼嗜血枪》配方
$LianMoYuanItem[105105425,8] = "109012007;1;50;2;";	 //《龙渊剑》配方
$LianMoYuanItem[105105425,9] = "109013007;1;50;2;";	 //《紫微炎魂塔》配方
$LianMoYuanItem[105105425,10]= "109014007;1;50;2;";	 //《太乙紫金杖》配方



