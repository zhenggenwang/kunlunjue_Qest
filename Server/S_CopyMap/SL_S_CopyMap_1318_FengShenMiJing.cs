//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//封神秘境
//==================================================================================
//■■■■【封神秘境】■■■■【全局变量】■■■■■■■
//■■■■【封神秘境】■■■■【副本创建触发】■■■■■
//■■■■【封神秘境】■■■■【玩家进入副本】■■■■■
//■■■■【封神秘境】■■■■【 NPC对话触发】■■■■■
//■■■■【封神秘境】■■■■【怪物死亡触发】■■■■■





//■■■■【封神秘境】■■■■【全局变量】■■■■■■■
//413180001	天师
//413181001	封神天兵
//413181002	封神天将
//413181003	封神天师
$CopyMapNpcRecord1318[0] = "413181002;-89.6646 -37.2118 105.699;90;1.2 1.2 1.2;";
$CopyMapNpcRecord1318[1] = "413181002;-102.476 -21.799 105.6891;90;1.2 1.2 1.2;";
$CopyMapNpcRecord1318[2] = "413181002;-28.1617 11.1242 105.4311;90;1.2 1.2 1.2;";
$CopyMapNpcRecord1318[3] = "413181002;74.5651 25.23871 107.5261;90;1.2 1.2 1.2;";
$CopyMapNpcRecord1318[4] = "413181002;32.2998 -19.0191 107.5261;90;1.2 1.2 1.2;";
$CopyMapNpcRecord1318[5] = "413181002;-96.5401 38.7848 107.4211;90;1.2 1.2 1.2;";
$CopyMapNpcRecord1318[6] = "413181002;-72.0499 10.1172 107.4211;90;1.2 1.2 1.2;";
$CopyMapNpcRecord1318[7] = "413181002;64.5888 -27.0508 105.3911;90;1.2 1.2 1.2;";
$CopyMapNpcRecord1318[8] = "413181003;62.1557 -58.2622 109.8211;90;1.5 1.5 1.5;";//BOSSS


//■■■■【封神秘境】■■■■【全局变量】■■■■■■■


//■■■■【封神秘境】■■■■【副本创建触发】■■■■■
function SvrCopymapOpen_1318_Trigger(%CopyMapID, %CopymapDataID)
{
	if(!isobject($CopyMapNpcRecord1318[%CopyMapID]))
		$CopyMapNpcRecord1318[%CopyMapID] = SpNewNpc2(0, 413180001, "-42.5182 -28.4415 107.995", %CopyMapID, 180);
}
//■■■■【封神秘境】■■■■【副本创建触发】■■■■■

//■■■■【封神秘境】■■■■【玩家进入副本】■■■■■
function SptCopymap_OnEnter_1318_Trigger(%CopyMapID, %Player)
{

}
//■■■■【封神秘境】■■■■【玩家进入副本】■■■■■

//■■■■【封神秘境】■■■■【 NPC对话触发】■■■■■
function FengShenMiJing_TransPortObject(%Npc, %Player, %State, %Conv)
{
	switch (%State)
	{
	case 0:
		%Conv.SetText(600000118);
		%Conv.AddOption(600000120, 600000120);
	case 600000120:
		%PlayerID = %Player.GetPlayerID();
		if ($SL_FengShenMiJing_State_bActive != 1)
		{
			%Txt1 = "副本暂未开放，敬请期待";
			SendOneScreenMessage(2, %Txt1, %Player);
			SendOneChatMessage($chatMsg_System, "<t>" @ %Txt1 @ "</t>", %Player);
			return FengShenMiJing_TransPortObject(%Npc, %Player, 0, %Conv);
		}
		if (%Player.GetLevel() < $SL_FengShenMiJing_Level)
		{
			%Txt1 = "此秘境凶险万分，请达到" @ $SL_FengShenMiJing_Level @ "再来";
			SendOneScreenMessage(2, %Txt1, %Player);
			SendOneChatMessage($chatMsg_System, "<t>" @ %Txt1 @ "</t>", %Player);
			return FengShenMiJing_TransPortObject(%Npc, %Player, 0, %Conv);
		}
		if (GetOrgActivityRecordServer(%Player, 5) > 0)
		{
			%Txt1 = "您今日已经参过该副本，请明日再来吧";
			SendOneScreenMessage(2, %Txt1, %Player);
			SendOneChatMessage($chatMsg_System, "<t>" @ %Txt1 @ "</t>", %Player);
			return FengShenMiJing_TransPortObject(%Npc, %Player, 0, %Conv);
		}

		if (SvrIsMyselfHasTeam(%PlayerID) == 0)
		{
			%Txt1 = "秘境内凶险万分，请先组队再来";
			SendOneScreenMessage(2, %Txt1, %Player);
			SendOneChatMessage($chatMsg_System, "<t>" @ %Txt1 @ "</t>", %Player);
			return FengShenMiJing_TransPortObject(%Npc, %Player, 0, %Conv);
		}
		%Conv.Settype(4);
		GoToNextMap(%Player, 1318, "");
	}
}
function FengShenMiJing_DiaLog(%Npc, %Player, %State, %Conv)
{
	switch (%State)
	{
	case 0:
		%Conv.SetText(600000118);
		%Conv.AddOption(600000119, 600000119);
	case 600000119:
		%PlayerID = %Player.GetPlayerID();
		if (!SvrIsMyselfCaption(%PlayerID))//判断当前玩家是否为队长
		{
			%Txt1 = "需要队长才可以开启副本";
			SendOneScreenMessage(2, %Txt1, %Player);
			SendOneChatMessage($chatMsg_System, "<t>" @ %Txt1 @ "</t>", %Player);
			return FengShenMiJing_DiaLog(%Npc, %Player, 0, %Conv);
		}
		%Player.ShowDialogOk(2000000039, 45, 1);
		%Conv.SetType(4);
	}
}
function CreateMonsterForFengShenMiJing(%Player)
{
	%CopyMapID = %Player.GetLayerId();
	if ($CopyMapRecord1318[%CopyMapID] == 1)
		return;

	%PlayerID = %Player.GetPlayerID();
	if (!SvrIsMyselfCaption(%PlayerID))//判断当前玩家是否为队长
	{
		%Txt1 = "需要队长才可以开启副本";
		SendOneScreenMessage(2, %Txt1, %Player);
		SendOneChatMessage($chatMsg_System, "<t>" @ %Txt1 @ "</t>", %Player);
		return;
	}

	//获取玩家ID
	%T = SptCopyMap_GetAllPlayer(%CopyMapID);
	%T_Num = SptCopyMap_GetPlayerCount(%CopyMapID);

	//if (%T_Num < 3)
	//{
	//	%text = "队伍人数不得低于3人，多召集些人马再来吧";
	//	SendAllChatMessageLayer(0, $Get_Dialog_GeShi[31406]  @ %text @ "</t>", %CopyMapID);	//发送副本层消息( 屏幕左下 )
	//	SendAllScreenMessageLayer(0, %text, %CopyMapID);	//发送副本层消息( 屏幕中间 )
	//	return;
	//}

	//echo("CreateMonsterForFengShenMiJing ====" @ %t);
	for (%i = 0; %i < %T_Num; %i++)
	{
		%Player = GetWord(%T, %i);
		if (GetOrgActivityRecordServer(%Player, 5) > 0)
		{
			%text = "队友【" @ %Player.GetObjectName() @ "】今日已经挑战过本副本，无法再次挑战。";
			SendAllChatMessageLayer(0, $Get_Dialog_GeShi[31406]  @ %text @ "</t>", %CopyMapID);	//发送副本层消息( 屏幕左下 )
			SendAllScreenMessageLayer(0, %text, %CopyMapID);	//发送副本层消息( 屏幕中间 )
			return;
		}
	}

	$CopyMapRecord1318[%CopyMapID] = 1;
	SptCopymap_Close(%CopyMapID);//关闭副本层

	$CopyMapLevel1318[%CopyMapID] = SptCopyMap_GetPlayerCorpsLvA(%CopyMapID);


	for (%i = 0; %i <= 8; %i++)
	{
		if (!isobject($CopyMapNpcRecord1318[%CopyMapID, %i]))
		{
			%NpcID = GetWord($CopyMapNpcRecord1318[%i], 0, ";");
			%Pos = GetWord($CopyMapNpcRecord1318[%i], 1, ";");
			%Rot = GetWord($CopyMapNpcRecord1318[%i], 2, ";");
			%Scal = GetWord($CopyMapNpcRecord1318[%i], 3, ";");
			$CopyMapNpcRecord1318[%CopyMapID, %i] = SpNewNpc3(0, %NpcID, %Pos, %CopyMapID, %Rot, %Scal);
			$CopyMapNpcRecord1318[%CopyMapID, %i].setlevel($CopyMapLevel1318[%CopyMapID]);
		}
	}
	$CopyMapNpcRecord1318[%CopyMapID, 8].addbuff(320020001, $CopyMapNpcRecord1318[%CopyMapID, %i], 1);
	$CopyMapNpcRecord1318[%CopyMapID, 8].addbuff(320150001, $CopyMapNpcRecord1318[%CopyMapID, %i], 1);
	
	for (%i = 0; %i< 70; %i++)
	{
		%Pos = $strMapRanPosRecord[1318, GetRandom(1, $strMapRanPosRecordMax[1318])];
		$CopyMapMonsterRecord1318[%CopyMapID, %i] = SpNewNpc3(0, 413181001, %Pos, %CopyMapID, getrandom(0, 360), "1 1 1");
		$CopyMapMonsterRecord1318[%CopyMapID, %i].setlevel($CopyMapLevel1318[%CopyMapID]);
	}
	$CopyMapNpcRecord1318[%CopyMapID].SafedeleteObject();
}
//■■■■【封神秘境】■■■■【 NPC对话触发】■■■■■


//■■■■【封神秘境】■■■■【怪物死亡触发】■■■■■
function KilledMonster_413181001(%Player, %Monster, %SharePlayerNum, %MaxConnection)//封神天兵
{
	%CopyMapID = %Monster.GetLayerId();
	%Level = mfloor($CopyMapLevel1318[%CopyMapID] / 10) * 10;
	if (%Level < 40)
		%Level = 40;

	%Ran = GetRandom(1, 100 );
	//echo("%Ran====" @ %Ran);
	if (%Ran <= 2)
	{
		%ItemID = GetRanDomPurpleEquipment(%Level);
		SpNewDropItem(%Monster, %Player, %ItemID, 1, 3);
	}
}
function KilledMonster_413181002(%Player, %Monster, %SharePlayerNum, %MaxConnection)//封神天将
{
	%CopyMapID = %Monster.GetLayerId();
	%Level = mfloor($CopyMapLevel1318[%CopyMapID] / 10) * 10;
	if (%Level < 40)
		%Level = 40;

	%Ran = GetRandom(1, 100 );
	//echo("%Ran====" @ %Ran);
	if (%Ran <= 10)
	{
		%ItemID = GetRanDomPurpleEquipment(%Level);
		SpNewDropItem(%Monster, %Player, %ItemID, 1, 3);
	}

}
function NpcObjectonDeathcast_413181003(%Monster, %Player)//封神天师
{
	//echo("%Monster====" @ %Monster);
	%CopyMapID = %Monster.GetLayerId();
	%Number = SptCopyMap_GetPlayerCount(%CopyMapID);
	%Level = mfloor($CopyMapLevel1318[%CopyMapID] / 10) * 10;
	if (%Level < 40)
		%Level = 40;
	//echo("%Number====" @ %Number);
	for (%i = 0; %i < %Number; %i++)
	{
		%ItemID = GetRanDomPurpleEquipment(%Level);
		//echo("%ItemID====" @ %ItemID);
		SpNewDropItem(%Monster, %Player, %ItemID, 1, 3);
	}

	%T = SptCopyMap_GetAllPlayer(%CopyMapID);
	%T_Num = SptCopyMap_GetPlayerCount(%CopyMapID);
	for (%i = 0; %i < %T_Num; %i++)	//获取玩家等级
	{
		//获取Player
		%Player = GetWord(%T, %i);
		%orgID = SptOrg_GetOrgID(%Player.GetPlayerID());		//家族ID
		if (%orgID > 0)
			GetOrgActivityWages(%Player, 5);
	}
}
//■■■■【封神秘境】■■■■【怪物死亡触发】■■■■■