//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//云罗镜
//==================================================================================
//■■■■【云罗镜】■■■■【全局变量】■■■■■■■
//■■■■【云罗镜】■■■■【副本创建触发】■■■■■
//■■■■【云罗镜】■■■■【玩家进入副本】■■■■■
//■■■■【云罗镜】■■■■【 NPC对话触发】■■■■■
//■■■■【云罗镜】■■■■【怪物死亡触发】■■■■■
//■■■■【云罗镜】■■■■【采集宝箱触发】■■■■■
//■■■■【云罗镜】■■■■【进出战斗触发】■■■■■

//■■■■【云罗镜】■■■■【全局变量】■■■■■■■
$CopyMapPosRecord1316[0]="0.127668 0.137097 105.071";//教主
$CopyMapPosRecord1316[1]="-61.6246 0.59848 102.84";//左护法
$CopyMapPosRecord1316[2]="61.6226 -0.594851 102.84";//右护法
$CopyMapPosRecord1316[3]="0.49874 66.8154 106.56";//长老


$EventPosRecord[1303,1] = "8.9567 14.0409 105.071";//云罗结界的节点
$EventPosRecord[1303,2] = "14.4285 3.88098 105.071";//云罗结界的节点
$EventPosRecord[1303,3] = "-0.708245 18.6175 105.171";//云罗结界的节点
$EventPosRecord[1303,4] = "-14.3488 -3.34424 105.071";//云罗结界的节点
$EventPosRecord[1303,5] = "-11.489 -13.8675 105.071";//云罗结界的节点
$EventPosRecord[1303,6] = "-0.307822 -18.5197 105.171";//云罗结界的节点
//413033001	云罗教主
//413033002	云罗左护法
//413033003	云罗右护法
//413033004	云罗长老
//SptMail_Send(  50000159, 105105303, 1, 0, 0, "道具奖励", "一二三四" );
//SptMail_Send(  50000159, 0, 0, 123456, 654321, "道具奖励", "一二三四" );
//■■■■【云罗镜】■■■■【全局变量】■■■■■■■



//■■■■【云罗镜】■■■■【副本创建触发】■■■■■
function SvrCopymapOpen_1316_Trigger(%CopyMapID,%CopymapDataID)
{
	if (!isobject($CopyMapNpcRecord1316[%CopyMapID,1]))
		$CopyMapNpcRecord1316[%CopyMapID,1] = SpNewNpc2(0,413032001,"-2.74134 -81.1813 110.113",%CopyMapID,90);

	//if (!isobject($CopyMapNpcRecord1316[%CopyMapID,2]))
	//	$CopyMapNpcRecord1316[%CopyMapID,2] = SpNewNpc2(0,413032002,"2.93102 -81.3177 110.113",%CopyMapID,270);

	$CopyMapBattleStateReocrd[%CopyMapID] = 0;
	$CopyMapGiftStateReocrd[%CopyMapID] = 1;
}
//■■■■【云罗镜】■■■■【副本创建触发】■■■■■

//■■■■【云罗镜】■■■■【玩家进入副本】■■■■■
function SptCopymap_OnEnter_1316_Trigger(%CopyMapID,%Player)
{

}
//■■■■【云罗镜】■■■■【玩家进入副本】■■■■■

//■■■■【云罗镜】■■■■【 NPC对话触发】■■■■■
function YunLuoJing_TransPortObject(%Npc,%Player,%State,%Conv)
{
	switch (%State)
	{
		case 0:
			%Conv.AddOption(600000104,600000104);
		case 600000104:
			if (%Player.GetLevel() < $SL_YunLuoJing_Level)
			{
				%Txt1 = $SL_YunLuoJing_Level @ "级以上的帮派成员才可以参加此副本";
				SendOneScreenMessage(2,%Txt1,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %Txt1 @ "</t>",%Player);
				return NpcOnTrigger(%Conv,%Npc,%Player,0,-1);
			}
			if (%Player.GetOrgID() > 0)
			{
				gotonextmap(%Player,"1316","");
			}
			else
			{
				%Txt1 = "此副本为帮派挑战副本，需要先加入帮派才可以参加";
				SendOneScreenMessage(2,%Txt1,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %Txt1 @ "</t>",%Player);
				return NpcOnTrigger(%Conv,%Npc,%Player,0,-1);
			}
	}
}
function YunLuoJing_DiaLog(%Npc,%Player,%State,%Conv)
{
	%CopyMapID = %Player.GetLayerID();
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000105);
			if ($CopyMapBattleStateReocrd[%CopyMapID] != 1)
				%Conv.AddOption(600000106,600000106);
		case 600000106:
			if (%Player.GetOrgMemberLevel(1) < 6)//是否是帮主
			{
				%Txt1 = "需要帮主才可以开启副本";
				SendOneScreenMessage(2,%Txt1,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %Txt1 @ "</t>",%Player);
				return YunLuoJing_DiaLog(%Npc,%Player,0,%Conv);
			}
			%Player.ShowDialogOk(2000000035,41,1);
			%Conv.SetType(4);
	}
}
function CreateMonsterForYunLuoJing(%Player)
{
	%CopyMapID = %Player.GetLayerID();
	if ($CopyMapBattleStateReocrd[%CopyMapID] > 0)
		return;
	$CopyMapBattleStateReocrd[%CopyMapID] = 1;
	//SptCopymap_Close( %CopyMapID );//关闭副本层
	if (!isobject($CopyMapBattleStateReocrd[%CopyMapID,1]))
		$CopyMapBattleStateReocrd[%CopyMapID,1] = SpNewNpc2(0,413033001,$CopyMapPosRecord1316[0],%CopyMapID,180);
	if (!isobject($CopyMapBattleStateReocrd[%CopyMapID,2]))
		$CopyMapBattleStateReocrd[%CopyMapID,2] = SpNewNpc2(0,413033002,$CopyMapPosRecord1316[1],%CopyMapID,90);
	if (!isobject($CopyMapBattleStateReocrd[%CopyMapID,3]))
		$CopyMapBattleStateReocrd[%CopyMapID,3] = SpNewNpc2(0,413033003,$CopyMapPosRecord1316[2],%CopyMapID,270);
	if (!isobject($CopyMapBattleStateReocrd[%CopyMapID,4]))
		$CopyMapBattleStateReocrd[%CopyMapID,4] = SpNewNpc2(0,413033004,$CopyMapPosRecord1316[3],%CopyMapID,180);

	%Level = SptCopyMap_GetPlayerCorpsLvA(%CopyMapID);
	$CopyMapBattleStateReocrd[%CopyMapID,1].SetLevel(%Level);
	$CopyMapBattleStateReocrd[%CopyMapID,2].SetLevel(%Level);
	$CopyMapBattleStateReocrd[%CopyMapID,3].SetLevel(%Level);
	$CopyMapBattleStateReocrd[%CopyMapID,4].SetLevel(%Level);

	$CopyMapBattleStateReocrd[%CopyMapID,1].AddBuff(320800001,$CopyMapBattleStateReocrd[%CopyMapID,1],1);
	$CopyMapBattleStateReocrd[%CopyMapID,1].AddBuff(320810001,$CopyMapBattleStateReocrd[%CopyMapID,1],1);
	$CopyMapBattleStateReocrd[%CopyMapID,1].AddBuff(320820001,$CopyMapBattleStateReocrd[%CopyMapID,1],1);

	//echo("$CopyMapBattleStateReocrd[" @ %CopyMapID @ ", 1 ]====" @ $CopyMapBattleStateReocrd[%CopyMapID,1]);
	//echo("$CopyMapBattleStateReocrd[" @ %CopyMapID @ ", 2 ]====" @ $CopyMapBattleStateReocrd[%CopyMapID,2]);
	//echo("$CopyMapBattleStateReocrd[" @ %CopyMapID @ ", 3 ]====" @ $CopyMapBattleStateReocrd[%CopyMapID,3]);
	//echo("$CopyMapBattleStateReocrd[" @ %CopyMapID @ ", 4 ]====" @ $CopyMapBattleStateReocrd[%CopyMapID,4]);

	%text = "帮主【" @ %Player.GetObjectName() @ "】召唤出了【云罗教主】。";
	SendAllChatMessageLayer(0,$Get_Dialog_GeShi[31406]  @ %text @ "</t>",%CopyMapID);	//发送副本层消息( 屏幕左下 )
	SendAllScreenMessageLayer(0,%text,%CopyMapID);	//发送副本层消息( 屏幕中间 )
}

function YunLuoJing_DiaLogB(%Npc,%Player,%State,%Conv)
{
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000107);
			%Conv.AddOption(600000108,600000108);
	}
}
//■■■■【云罗镜】■■■■【 NPC对话触发】■■■■■


//■■■■【云罗镜】■■■■【怪物死亡触发】■■■■■
function NpcObjectonDeathcast_413033001(%Monster,%Killer){ NpcObjectonDeathcast_413033001_413033004(%Monster,%Killer,553000057,0); } //云罗教主
function NpcObjectonDeathcast_413033002(%Monster,%Killer){ NpcObjectonDeathcast_413033001_413033004(%Monster,%Killer,553000058,32080); } //云罗左护法
function NpcObjectonDeathcast_413033003(%Monster,%Killer){ NpcObjectonDeathcast_413033001_413033004(%Monster,%Killer,553000059,32081); } //云罗右护法
function NpcObjectonDeathcast_413033004(%Monster,%Killer){ NpcObjectonDeathcast_413033001_413033004(%Monster,%Killer,553000060,32082); } //云罗长老

function NpcObjectonDeathcast_413033001_413033004(%Monster,%Killer,%EventId,%Buff)
{
	%NpcId = %Monster.GetDataID();
	%CopyMapID = %Monster.GetLayerID();
	//echo( "【云罗镜】■■■■【怪物死亡触发】■" @ %NpcId  @ "     " @ %CopyMapID );

	%Obj = SpNewCj2(0,%EventId,%Monster.GetPosition(),%CopyMapID,0,"1 1 1");

	if (%Buff > 0)
	{
		if ($CopyMapBattleStateReocrd[%CopyMapID,1].GetBuffCount(%Buff,1) >= 1)
			$CopyMapBattleStateReocrd[%CopyMapID,1].Removebuff(%Buff*10000+1);
	}
	switch (%NpcId)
	{
		case 413033001:
			%TeammateList = SptCopyMap_GetAllPlayer(%CopyMapID);//获取副本玩家信息
			%TeammateNum = SptCopyMap_GetPlayerCount(%CopyMapID);//获取副本玩家数量
			for (%i = 0; %i < %TeammateNum; %i++)
			{
				%Player = Getword(%TeammateList, %i);
				if (%Player.GetOrgMemberLevel(1) == 6)
				{
					%Master = %Player;
					break;
				}
			}
			if (!isobject(%Master))
				%Master = %Killer;
			%Playername1 = GetPlayerZiTiName(%Master, 1);
			%Playername2 = GetPlayerZiTiName(%Master, 2);
			%NpcName1 = GetHuoDongName(GetNpcData(%NpcId, 1), 1);
			%NpcName2 = GetHuoDongName(GetNpcData(%NpcId, 1), 2);
			%MapName1 = GetMapName(%Master, 1);
			%MapName2 = GetMapName(%Master, 2);
			%ItemName1 = GetHuoDongName("云罗宝藏", 1);
			%ItemName2 = GetHuoDongName("云罗宝藏", 2);

			%Txt1 = %Playername1 @ "<t>带领帮众在</t>" @ %MapName1 @ "<t>激战许久，战胜了</t>" @ %NpcName1 @ "<t>，</t>"@ %ItemName1 @ "<t>尽入囊中！</t>";
			%Txt2 = %Playername2 @ "<t>带领帮众在</t>" @ %MapName2 @ "<t>激战许久，战胜了</t>" @ %NpcName2 @ "<t>，</t>" @ %ItemName2 @ "<t>尽入囊中！</t>";
			SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Txt1 @ "</t>");
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Txt2 @ "</t>", $chatMsg_Type_Normal2);
		case 413033004:
			//echo("%Monster.SuiCongNumber====="@ %Monster.SuiCongNumber);
			for (%i = 0; %i <= %Monster.SuiCongNumber; %i++)
			{
				%Obj = %Monster.SuiCong[%i];
				//echo("%Obj====="@ %Obj);
				if (isobject(%Obj))
					%Obj.SafeDeleteObject();
			}
				
	}
}
//■■■■【云罗镜】■■■■【怪物死亡触发】■■■■■

//■■■■【云罗镜】■■■■【采集宝箱触发】■■■■■
function TriggerEvent_553000057(%Player,%Event,%EventID){ TriggerEvent_553000057_553000060(%Player,%Event,%EventID,191,500,20); }
function TriggerEvent_553000058(%Player,%Event,%EventID){ TriggerEvent_553000057_553000060(%Player,%Event,%EventID,192,100,10); }
function TriggerEvent_553000059(%Player,%Event,%EventID){ TriggerEvent_553000057_553000060(%Player,%Event,%EventID,193,100,10); }
function TriggerEvent_553000060(%Player,%Event,%EventID){ TriggerEvent_553000057_553000060(%Player,%Event,%EventID,194,200,10); }
function TriggerEvent_553000057_553000060(%Player,%Event,%EventID,%Src,%NumBer,%HuoYueSorce)
{
	SetSrc(%Player,%Src);
	AddFamily_HuoYue(%Player, %HuoYueSorce);
	HelpDirectByIndex(%Player.GetPlayerID(), 31);	//通讯客户端

	%Exp = $Monster_Exp[%Player.GetLevel(),1] * %NumBer;
	AllAddExp(%Player,%Exp);

	if (%EventID == 553000057)
		AddAchievementWatch(%Player,0,36,1);//记录成就
	return true;

}
function TriggerEvent_553000061(%Player,%Event,%EventID)//节点
{
	%Event.SafedeleteObject();
	%CopyMapID = %Player.GetLayerID();
	$IsReomoveJieDianRecord[%CopyMapID]++;
	if ($IsReomoveJieDianRecord[%CopyMapID] < 6)
		return true;
	%BuffCount = $CopyMapBattleStateReocrd[%CopyMapID,1].GetBuffCount(32075,1);
	if (%BuffCount > 0)
	{
		$CopyMapBattleStateReocrd[%CopyMapID,1].RemoveBuff(320750001);
	}
	return true;
}
//■■■■【云罗镜】■■■■【采集宝箱触发】■■■■■

//■■■■【云罗镜】■■■■【进出战斗触发】■■■■■
function MonsterCombatEnd_413033001(%Npc)
{
	%CopyMapID = %Npc.GetLayerID();

	for (%i = 1;%i <= 6;%i++)
	{
		if (isobject($EventIDRecord[%CopyMapID,%i]))
			$EventIDRecord[%CopyMapID,%i].SafedeleteObject();
	}
	%BuffCount = $CopyMapBattleStateReocrd[%CopyMapID,1].GetBuffCount(32075,1);
	if (%BuffCount > 0)
	{
		$CopyMapBattleStateReocrd[%CopyMapID,1].RemoveBuff(320750001);
	}
}
function MonsterCombatEnd_413033004(%Npc)
{
	for (%i = 0; %i <= %Npc.SuiCongNumber; %i++)
	{
		%Obj = %Npc.SuiCong[%i];
		//echo("%Obj====="@ %Obj);
		if (isobject(%Obj))
			%Obj.SafeDeleteObject();
	}
	%Npc.SuiCongNumber = 0;
}
//■■■■【云罗镜】■■■■【进出战斗触发】■■■■■
//320760001	飓风破	skill/320110002.png	持续伤害
//320770001	裂地震击	skill/320110003.png	伤害
//320780001	裂地震击	skill/3153.png	眩晕
//320790001	火墙术	skill/320120002.png	持续伤害