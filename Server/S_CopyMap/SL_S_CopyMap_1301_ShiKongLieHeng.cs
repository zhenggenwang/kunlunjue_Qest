//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//副本 时空裂痕
//==================================================================================
//■■■■【时空裂痕】■■■■【全局变量】■■■■■■■■
//■■■■【时空裂痕】■■■■【系统公告】■■■■■■■■
//■■■■【时空裂痕】■■■■【传送对话】■■■■■■■■
//■■■■【时空裂痕】■■■■【副本开启对话】■■■■■■
//■■■■【时空裂痕】■■■■【副本创建】■■■■■■■■
//■■■■【时空裂痕】■■■■【玩家进入副本】■■■■■■
//■■■■【时空裂痕】■■■■【副本战斗流程】■■■■■■
//■■■■【时空裂痕】■■■■【BOSS死亡触发】■■■■■■
//■■■■【时空裂痕】■■■■【副本结束触发】■■■■■■
//■■■■【时空裂痕】■■■■【星魂对话】■■■■■■■■
//■■■■【时空裂痕】■■■■【采集物触发】■■■■■■■



//■■■■【时空裂痕】■■■■【全局变量】■■■■■■■■
//$SL_CopyMap_Sates[ %CopyMapID ] 副本状态记录 0 未开启 1已开启 
//$SptCopymap_1301_MonSter[ %CopyMapID, %Step, %Num ] 刷新的怪物对象记录 %step 波数 %num 当前波数的第几只
//-175.263 135.813 313.718 刷怪点
//-155.532 169.738 313.718 刷怪点 
//-134.963 134.964 313.718 刷怪点
$SptCopymap_1301_SptPos[0,1] = "-175.770"; $SptCopymap_1301_SptPos[0,2] = "135.511"; $SptCopymap_1301_SptPos[0,3] = "313.718"; $SptCopymap_1301_SptPos[0,4] = "0";
$SptCopymap_1301_SptPos[1,1] = "-155.239"; $SptCopymap_1301_SptPos[1,2] = "169.678"; $SptCopymap_1301_SptPos[1,3] = "313.718"; $SptCopymap_1301_SptPos[1,4] = "0";
$SptCopymap_1301_SptPos[2,1] = "-135.777"; $SptCopymap_1301_SptPos[2,2] = "135.091"; $SptCopymap_1301_SptPos[2,3] = "313.718"; $SptCopymap_1301_SptPos[2,4] = "0";
//
$SptCopymap_1301_SptCD[1]="30";
$SptCopymap_1301_SptCD[2]="30";
$SptCopymap_1301_SptCD[3]="30";
$SptCopymap_1301_SptCD[4]="30";
$SptCopymap_1301_SptCD[5]="30";
$SptCopymap_1301_SptCD[6]="30";
$SptCopymap_1301_SptCD[7]="30";
$SptCopymap_1301_SptCD[8]="30";
$SptCopymap_1301_SptCD[9]="30";
$SptCopymap_1301_SptCD[10]="30";
$SptCopymap_1301_SptCD[11]="25";
$SptCopymap_1301_SptCD[12]="25";
$SptCopymap_1301_SptCD[13]="25";
$SptCopymap_1301_SptCD[14]="25";
$SptCopymap_1301_SptCD[15]="25";
$SptCopymap_1301_SptCD[16]="25";
$SptCopymap_1301_SptCD[17]="25";
$SptCopymap_1301_SptCD[18]="25";
$SptCopymap_1301_SptCD[19]="25";
$SptCopymap_1301_SptCD[20]="25";
$SptCopymap_1301_SptCD[21]="25";
$SptCopymap_1301_SptCD[22]="25";
$SptCopymap_1301_SptCD[23]="25";
$SptCopymap_1301_SptCD[24]="25";
$SptCopymap_1301_SptCD[25]="25";
$SptCopymap_1301_SptCD[26]="20";
$SptCopymap_1301_SptCD[27]="20";
$SptCopymap_1301_SptCD[28]="20";
$SptCopymap_1301_SptCD[29]="20";
$SptCopymap_1301_SptCD[30]="20";
$SptCopymap_1301_SptCD[31]="20";
$SptCopymap_1301_SptCD[32]="20";
$SptCopymap_1301_SptCD[33]="20";
$SptCopymap_1301_SptCD[34]="20";
$SptCopymap_1301_SptCD[35]="20";
$SptCopymap_1301_SptCD[36]="20";
$SptCopymap_1301_SptCD[37]="20";
$SptCopymap_1301_SptCD[38]="20";
$SptCopymap_1301_SptCD[39]="20";
$SptCopymap_1301_SptCD[40]="20";

$SptCopymap_1301_MonSter[1]="413011001 413011002 1;";
$SptCopymap_1301_MonSter[2]="413011001 413011002 2;";
$SptCopymap_1301_MonSter[3]="413011001 413011002 3;";
$SptCopymap_1301_MonSter[4]="413011001 413011002 4;";
$SptCopymap_1301_MonSter[5]="413011001 413011002 5;";
$SptCopymap_1301_MonSter[6]="413011001 413011002 6;";
$SptCopymap_1301_MonSter[7]="413011001 413011002 6;";
$SptCopymap_1301_MonSter[8]="413011001 413011002 6;";
$SptCopymap_1301_MonSter[9]="413011001 413011002 6;";
$SptCopymap_1301_MonSter[10]="413011001 413011002 6;413011003 1;";
$SptCopymap_1301_MonSter[11]="413011004 413011005 6;";
$SptCopymap_1301_MonSter[12]="413011004 413011005 6;413011009 413011010 1;";
$SptCopymap_1301_MonSter[13]="413011004 413011005 6;";
$SptCopymap_1301_MonSter[14]="413011004 413011005 6;413011009 413011010 1;";
$SptCopymap_1301_MonSter[15]="413011004 413011005 6;";
$SptCopymap_1301_MonSter[16]="413011004 413011005 6;413011009 413011010 1;";
$SptCopymap_1301_MonSter[17]="413011004 413011005 6;";
$SptCopymap_1301_MonSter[18]="413011004 413011005 6;413011009 413011010 1;";
$SptCopymap_1301_MonSter[19]="413011004 413011005 6;";
$SptCopymap_1301_MonSter[20]="413011012 18";
$SptCopymap_1301_MonSter[21]="413011004 413011005 6;";
$SptCopymap_1301_MonSter[22]="413011004 413011005 6;413011009 413011010 1;";
$SptCopymap_1301_MonSter[23]="413011004 413011005 6;";
$SptCopymap_1301_MonSter[24]="413011004 413011005 6;413011009 413011010 1;";
$SptCopymap_1301_MonSter[25]="413011004 413011005 6;413011006 1;";
$SptCopymap_1301_MonSter[26]="413011007 413011008 6;";
$SptCopymap_1301_MonSter[27]="413011007 413011008 6;413011009 413011010 1;413011011 1;";
$SptCopymap_1301_MonSter[28]="413011007 413011008 6;";
$SptCopymap_1301_MonSter[29]="413011007 413011008 6;413011009 413011010 1;413011011 1;";
$SptCopymap_1301_MonSter[30]="413011007 413011008 6;";
$SptCopymap_1301_MonSter[31]="413011007 413011008 6;413011009 413011010 1;413011011 1;";
$SptCopymap_1301_MonSter[32]="413011007 413011008 6;";
$SptCopymap_1301_MonSter[33]="413011007 413011008 6;";
$SptCopymap_1301_MonSter[34]="413011013 18";
$SptCopymap_1301_MonSter[35]="413011007 413011008 6;";
$SptCopymap_1301_MonSter[36]="413011007 413011008 6;";
$SptCopymap_1301_MonSter[37]="413011007 413011008 6;";
$SptCopymap_1301_MonSter[38]="413011007 413011008 6;";
$SptCopymap_1301_MonSter[39]="413011007 413011008 6;";
$SptCopymap_1301_MonSter[40]="413011007 413011008 6;413011014 1";


$SptCopymap_1301_MonSterMsg[10]=  "石精统领来袭";
$SptCopymap_1301_MonSterMsg[20]= "一大波猎魂妖正在接近";
$SptCopymap_1301_MonSterMsg[25]= "魔化砾石精统领来袭";
$SptCopymap_1301_MonSterMsg[34]= "一大波猎魂魔妖正在接近";
$SptCopymap_1301_MonSterMsg[40]= "冥将来袭";


$SptCopymap_1301_Pos_XingHun[1] = "-170.714 162.697 313.206;";
$SptCopymap_1301_Pos_XingHun[2] = "-166.186 165.665 313.206";
$SptCopymap_1301_Pos_XingHun[3] = "-159.75 168.25 313.206";
$SptCopymap_1301_Pos_XingHun[4] = "-176.25 154.75 313.206";
$SptCopymap_1301_Pos_XingHun[5] = "-177.749 147.75 313.206";
$SptCopymap_1301_Pos_XingHun[6] = "-177.25 140.75 313.206";

$XingHunPacket[1] = 900151;/*星魂白*/	$XingHunSchbuff[1] = 2016;
$XingHunPacket[2] = 900152;/*星魂绿*/	$XingHunSchbuff[2] = 2017;
$XingHunPacket[3] = 900153;/*星魂蓝*/	$XingHunSchbuff[3] = 2018;
$XingHunPacket[4] = 900154;/*星魂紫*/	$XingHunSchbuff[4] = 2019;
$XingHunPacket[5] = 900155;/*星魂橙*/	$XingHunSchbuff[5] = 2020;
$XingHunPacket[6] = 900156;/*星魂红*/

//addEffectPacket( 900151, 0, "6.50021 -6.64898 195.874", "1 0 0 0", 0, 0, -1, 0 );
//■■■■【时空裂痕】■■■■【全局变量】■■■■■■■■


//■■■■【时空裂痕】■■■■【系统公告】■■■■■■■■
function CopyMap_XuanWuMen_StytemMsg(%YY,%MM,%DD,%H,%M,%S)
{
	if (GetZoneid() != 1001)
		return;
	if ($SL_XuanWuMen_bActive != 1)
		return;
	%TimebActive = GetWord($SL_XuanWuMen_StartTime,0,":") * 60  + GetWord($SL_XuanWuMen_StartTime,1,":");
	%TimeNow = %H * 60 + %M;
	%Time = %TimebActive - %TimeNow;
	if (%Time == 10)
	{
		%HuoDongMingCheng = GetHuoDongName("时空裂痕",1);
		%Path = "<l i='810010100 -18.5407 -19.4654 191.679' t='path'/>";
		%Text = %HuoDongMingCheng @ "<t>将在</t>" @ $Get_Dialog_GeShi[31420] @ %Time @ "</t><t>分钟后开启，" @ $SL_XuanWuMen_Level @ "级以上修士可前往</t>" @ %Path @ "<t>查看活动详情。</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

		%Text2 = GetHuoDongName("时空裂痕",2) @ "<t>将于</t>" @ $Get_Dialog_GeShi[60002] @ %Time @ "</t><t>分钟后开启</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
	if (%Time == 5)
	{
		%HuoDongMingCheng = GetHuoDongName("时空裂痕",1);
		%Path = "<l i='810010100 -18.5407 -19.4654 191.679' t='path'/>";
		%Text = %HuoDongMingCheng @ "<t>将在</t>" @ $Get_Dialog_GeShi[31420] @ %Time @ "</t><t>分钟后开启，" @ $SL_XuanWuMen_Level @ "级以上修士可前往</t>" @ %Path @ "<t>查看活动详情。</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

		%Text2 = GetHuoDongName("时空裂痕",2) @ "<t>将于</t>" @ $Get_Dialog_GeShi[60002] @ %Time @ "</t><t>分钟后开启</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
	if (%Time == 0)
	{
		%HuoDongMingCheng = GetHuoDongName("时空裂痕",1);
		%Path = "<l i='810010100 -18.5407 -19.4654 191.679' t='path'/>";
		%Text = %HuoDongMingCheng @ "<t>已经开启," @ $SL_XuanWuMen_Level @ "级以上修士可前往</t>" @ %Path @ "<t>,参与挑战</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

		%Text2 = GetHuoDongName("时空裂痕",2) @ "<t>已经开启</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
}

//■■■■【时空裂痕】■■■■【系统公告】■■■■■■■■

//■■■■【时空裂痕】■■■■【传送对话】■■■■■■■■
function NpcOnTrigger_Dialog_410010209(%Npc,%Player,%State,%Conv,%Param)
{
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000004);
			%Conv.AddOption(600000005,600000005);
		case 600000005:
			%Conv.SetType(4);
			if (%Player.GetLevel() < $SL_XuanWuMen_Level)
			{
				%text = $SL_XuanWuMen_Level @ "级以上才可以参加时空裂痕";
				SendOneScreenMessage(2,%text,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
				return;
			}
			if ($SL_XuanWuMen_State_bActive != 1)
			{
				%text = "活动没有开启!";
				SendOneScreenMessage(2,%text,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
				return;
			}
			%Act = GetWord(%Player.GetActivity(3029),0);
			if (%Act >= 1)
			{
				%text = "你今天挑战过时空裂痕了，请明日再来";
				SendOneScreenMessage(2,%text,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
				return;
			}
			GoToNextMap(%Player,1301,"");
	}
}
//■■■■【时空裂痕】■■■■【传送对话】■■■■■■■■ 

//■■■■【时空裂痕】■■■■【副本开启对话】■■■■■■
function NpcOnTrigger_CopyMap_1301_413010002(%Npc,%Player,%State,%Conv,%Param)
{
	%CopyMapID = %Player.GetLayerID();
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000006);
			if ($SL_CopyMap_Sates[%CopyMapID] == 0)
				%Conv.AddOption(600000007,600000007);
		case 600000007:
			%Conv.SetType(4);
			%Player.ShowDialogOk(2000000002,2,1);
	}
}
function CopyMap_Begin_1301(%Player)
{
	%PlayerID = %Player.GetPlayerid();
	%CopyMapID = %Player.GetLayerID();
	if (!SvrIsMyselfCaption(%PlayerID))
	{
		%text = "你不是队长，请让队长来开启";
		SendOneScreenMessage(2,%text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
		return;
	}
	if ($SL_CopyMap_Sates[%CopyMapID]  != 0)
		return;

	$SL_CopyMap_Sates[%CopyMapID] = 1;
	SptCopymap_Close(%CopyMapID);//关闭副本层
	%text = "副本将在15秒后开启，请做好准备";
	SendAllChatMessageLayer(0,$Get_Dialog_GeShi[31406]  @ %text @ "</t>",%CopyMapID);	//发送副本层消息( 屏幕左下 )
	SendAllScreenMessageLayer(0,%text,%CopyMapID);	//发送副本层消息( 屏幕中间 )
	CanCel($SptCopymap_1301_Combat[%CopyMapID]);
	$SptCopymap_1301_Combat[%CopyMapID] = schedule(15000,0,"SptCopymap_1301_CombatFlow",%CopyMapID,1);//开始执行战斗流程

}
//■■■■【时空裂痕】■■■■【副本开启对话】■■■■■■

//■■■■【时空裂痕】■■■■【副本创建】■■■■■■■■
function SvrCopymapOpen_1301_Trigger(%CopyMapID,%CopymapDataID)
{
	$SL_CopyMap_Sates[%CopyMapID] = 0;
	$SL_CopyMap_Pos[%CopyMapID] = 0;
	SpNewNpc3(0,413010002,"-173.009 159.604 313.206",%CopyMapID,120,"1 1 1");
}
//■■■■【时空裂痕】■■■■【副本创建】■■■■■■■■


//■■■■【时空裂痕】■■■■【玩家进入副本】■■■■■■


function SptCopymap_OnEnter_1301_Trigger(%CopyMapID,%Player)
{
	%PlayerID = %Player.GetPlayerID();
	if (!isobject($SptCopymap_1301_MonSter_XingHun[%CopyMapID,%PlayerID]))
	{
		$SL_CopyMap_Pos[%CopyMapID] ++;
		%Pos = $SptCopymap_1301_Pos_XingHun[$SL_CopyMap_Pos[%CopyMapID]];
		$SptCopymap_1301_MonSter_XingHun[%CopyMapID,%PlayerID] = SpNewNpc3(0,413010001,%Pos,%CopyMapID,120,"1 1 1");
		//$SptCopymap_1301_MonSter_XingHun[ %CopyMapID, %PlayerID ].SetMaster( %Player );
		$SptCopymap_1301_MonSter_XingHun[%CopyMapID,%PlayerID].SetShapeName(GetNpcData(413010001,1) @ "『" @ %Player.GetObjectname() @ "』");
		$SptCopymap_1301_MonSter_XingHun[%CopyMapID,%PlayerID].MasterID = %PlayerID;
	}
	schedule(5000,0,"SptCopymap_OnEnter_1301_Trigger_A",%CopyMapID,%Player);
}
function SptCopymap_OnEnter_1301_Trigger_A(%CopyMapID,%Player)
{
	%Player.SendPlayerString(4,"0 0",0);

	%Act0 = GetAct(%Player,4091,0) * 1;

	%PlayerID = %Player.GetPlayerID();
	if (%Act0 == 0)
	{
		%Color = GetXingHunLevel(%Player);
		SetAct(%Player,4091,%Color,%Color);
		GiveXingHunSchbuff(%Player,%Color);
		%Packet = $XingHunPacket[%Color];
		%Npc = $SptCopymap_1301_MonSter_XingHun[%CopyMapID,%PlayerID];
		%Npc.XingHunPacket = %Npc.Addpacket(%Packet);
		if (%Color >= 4)//发公告了
		{
			%HuoDongMingCheng = GetHuoDongName("时空裂痕",1);
			%PlayerName = GetPlayerZiTiName(%Player,1);
			switch (%Color)
			{
				case 4: %ItemName =  $Get_Dialog_GeShi[31409] @ "紫色本命星</t>"; %ItemName2 = $Get_Dialog_GeShi[60002] @ "紫色本命星";
				case 5: %ItemName =  $Get_Dialog_GeShi[31421] @ "橙色本命星</t>"; %ItemName2 = $Get_Dialog_GeShi[60003] @ "橙色本命星";
			}
			%Text1 =  %PlayerName @ "<t>在</t>" @ %HuoDongMingCheng @ "<t>内免费获得了</t>" @ %ItemName @ "<t>，真是羡煞众人。</t>";
			SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Text1 @ "</t>");

			%PlayerName2 = GetPlayerZiTiName(%Player,2);
			%HuoDongMingCheng2 = GetHuoDongName("时空裂痕",2);
			%Text2 = %PlayerName2 @ "<t>在</t>" @ %HuoDongMingCheng2 @ "<t>内免费获得了</t>" @ %ItemName2;
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
		}
	}
	else
	{
		%Color = %Act0;
		GiveXingHunSchbuff(%Player,%Color);
		%Packet = $XingHunPacket[%Color];
		%Npc = $SptCopymap_1301_MonSter_XingHun[%CopyMapID,%PlayerID];
		%Npc.XingHunPacket = %Npc.Addpacket(%Packet);
	}
}


//263032.SetPosition( 263032.getposition(), mDegToRad( 270 ) );
//■■■■【时空裂痕】■■■■【玩家进入副本】■■■■■■


//■■■■【时空裂痕】■■■■【副本战斗流程】■■■■■■
function SptCopymap_1301_CombatFlow(%CopyMapID,%Step)
{
	//echo( "=============================副本战斗流程%CopyMapID === " @ %CopyMapID @ "   %Step===" @ %Step );
	CanCel($SptCopymap_1301_Combat[%CopyMapID]);
	if ($SptCopymap_1301_MonSter[%Step] $= "")
		return;
	if ($SL_CopyMap_Sates[%CopyMapID] == 2)
		return;
	if (%Step == 1)
	{
		$SptCopymap_1301_MonSter[%CopyMapID] = SpNewNpc3(0,413011000," -155.53 146.665 313.747",%CopyMapID,0,"1 1 1");//刷新中间守护NPC
		//$SptCopymap_1301_MonSter[ %CopyMapID ].Addpacket( 700004 );
		$SptCopymap_1301_MonSter[%CopyMapID].SetCombative(1);//设置可战斗
		$SptCopymap_1301_MonSter[%CopyMapID].SetForce(1);
		$SptCopyMap_CorpLevel[%CopyMapID] = SptCopyMap_GetPlayerCorpsLvA(%CopyMapID);
		//echo( "平均等级====" @  $SptCopyMap_CorpLevel[ %CopyMapID ] );
	}

	%AllNum = GetWordCount($SptCopymap_1301_MonSter[%Step],";");
	//echo( "%AllNum==="@ %AllNum );
	for (%j = 0; %j < %AllNum; %j++)
	{
		%MonsterList = GetWord($SptCopymap_1301_MonSter[%Step],%j,";");
		%Count = GetWordCount(%MonsterList);
		%MonsterNumber = GetWord(%MonsterList,%Count - 1);//刷新的数量
		//echo( "刷新的数量%MonsterNumber ===" @ %MonsterNumber );
		for (%i = 1; %i <= %MonsterNumber; %i++)
		{
			//echo( "%i===" @ %i @ "    %MonsterList===" @ %MonsterList );
			%MonsterID = GetWord(%MonsterList,GetRandom(0,%Count -2));
			%Pos = GetRanDom($SptCopymap_1301_SptPos[%i%3,1] - 1,$SptCopymap_1301_SptPos[%i%3,1] + 1) @ " " @ GetRandom($SptCopymap_1301_SptPos[%i%3,2] - 1,$SptCopymap_1301_SptPos[%i%3,2]  + 1) @ " " @ $SptCopymap_1301_SptPos[%i%3,3];
			%Rot = $SptCopymap_1301_SptPos[%i%3,4];
			//echo( "%MonsterID=====" @ %MonsterID );

			%Obj = SpNewNpc3(0,%MonSterID,%Pos,%CopyMapID,%Rot,"1 1 1");
			%Obj.SetLevel($SptCopyMap_CorpLevel[%CopyMapID]);
			%Obj.SetForce(2);
			%Obj.AddHate($SptCopymap_1301_MonSter[%CopyMapID],100);

			//echo( "%Obj====" @ %Obj @ "    " @ %Obj.GetObjectname( ) @ "   " @ isobject( %Obj ) );
		}
	}
	%Text = "第" @ %Step @ "波怪物开始进攻";
	if ($SptCopymap_1301_MonSterMsg[%Step] !$= "")
		%text = %Text @ "，" @ $SptCopymap_1301_MonSterMsg[%Step];
	SendAllChatMessageLayer(0,$Get_Dialog_GeShi[31406]  @ %text @ "</t>",%CopyMapID);	//发送副本层消息( 屏幕左下 )
	SendAllScreenMessageLayer(0,%text,%CopyMapID);	//发送副本层消息( 屏幕中间 )

	%Time = $SptCopymap_1301_SptCD[%Step];//获取CD时间

	%TeammateList = SptCopyMap_GetAllPlayer(%CopyMapID);//获取副本玩家信息
	%TeammateNum = SptCopyMap_GetPlayerCount(%CopyMapID);//获取副本玩家数量
	for (%i = 0; %i < %TeammateNum; %i++)
	{
		%Player = GetWord(%TeammateList,%i);
		if (%Step == 1)
		{
			%Player.SetForce(1);
			%Act_A = GetWord(%Player.GetActivity(3029),0);
			%Act_B = GetWord(%Player.GetActivity(3029),1);
			SetAct(%Player,3029,%Act_A++,%Act_B);
		}
		%Player.SendPlayerString(4,%Step @ " " @ %Time,0);
	}

	$SptCopymap_1301_Combat[%CopyMapID] = schedule(%Time * 1000,0,"SptCopymap_1301_CombatFlow",%CopyMapID,%Step++);
}
//■■■■【时空裂痕】■■■■【副本战斗流程】■■■■■■

//■■■■【时空裂痕】■■■■【BOSS死亡触发】■■■■■■
function NpcObjectonDeathcast_413011000(%Monster,%Killer)//日月金轮死了 副本失败
{
	//echo( "%Monster ===" @ %Monster );
	CanCel($SptCopymap_1301_Combat[%CopyMapID]);
	%CopyMapID = %Killer.GetLayerid();
	$SL_CopyMap_Sates[%CopyMapID] = 2;

	%TeammateList = SptCopyMap_GetAllPlayer(%CopyMapID);//获取副本玩家信息
	%TeammateNum = SptCopyMap_GetPlayerCount(%CopyMapID);//获取副本玩家数量
	for (%i = 0; %i < %TeammateNum; %i++)
	{
		%Player = GetWord(%TeammateList,%i);
		%Player.SendPlayerString(4,"-1 0",0);
	}

	%text = "挑战失败，封印被破，赶快逃命吧";
	SendAllChatMessageLayer(0,$Get_Dialog_GeShi[31406]  @ %text @ "</t>",%CopyMapID);	//发送副本层消息( 屏幕左下 )
	SendAllScreenMessageLayer(0,%text,%CopyMapID);	//发送副本层消息( 屏幕中间 )
	RemoveCopyMapOnLeaveTeam(%CopyMapID,3);
	return;

}
function NpcObjectonDeathcast_413011014(%Monster,%Killer)
{
	%CopyMapID = %Killer.GetLayerId();
	SptCopymap_1301_End(%CopyMapID);
	RemoveCopyMapOnLeaveTeam(%CopyMapID,3);
	$SL_CopyMap_Sates[%CopyMapID] = 2;
	%Pos = %Monster.GetPosition();
	%TeammateList = SptCopyMap_GetAllPlayer(%CopyMapID);//获取副本玩家信息
	%TeammateNum = SptCopyMap_GetPlayerCount(%CopyMapID);//获取副本玩家数量
	for (%i = 0; %i < %TeammateNum; %i++)
	{
		%Player = GetWord(%TeammateList,%i);
		%PlayerID = %Player.GetPlayerid();
		%Pos_Z = GetNavPos(GetWord(%Pos,0),GetWord(%Pos,1),10);
		//%Obj = SpNewCj2( 0, 553000001, %Pos, %CopyMapID, %Rot, %Scale );
		%Playername = %Player.GetObjectname();
		%ObjName = %Obj.GetObjectname();
		%Obj.Master = %PlayerID;
		%Obj.SetShapename(%ObjName @ "【" @ %Playername @ "】");

		%Player.SendPlayerString(4,"-1 0",0);
		AddAchievementWatch(%Player,0,41,1);//记录成就
	}

	%Player = GetTeamMaster(%Killer);

	%PlayerName1 = GetPlayerZiTiName(%Player,1);
	%PlayerName2 = GetPlayerZiTiName(%Player,2);

	%HuoDongMingCheng1 = GetHuoDongName("时空裂痕",1);
	%HuoDongMingCheng2 = GetHuoDongName("时空裂痕",2);

	%text1 = %PlayerName1 @ "<t>带领队友通关了</t>" @ %HuoDongMingCheng1;
	%text2 = %PlayerName2 @ "<t>带领队友通关了</t>" @ %HuoDongMingCheng2;

	//SendAllChatMessageLayer( 0, $Get_Dialog_GeShi[ 31406 ]  @ %text @ "</t>", %CopyMapID );	//发送副本层消息( 屏幕左下 )
	SendAllScreenMessageLayer(0,"挑战成功",%CopyMapID);	//发送副本层消息( 屏幕中间 )

	SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
	SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);

}

//■■■■【时空裂痕】■■■■【BOSS死亡触发】■■■■■■


//■■■■【时空裂痕】■■■■【副本结束触发】■■■■■■
function SptCopymap_1301_End(%CopyMapID)
{
	CanCel($SptCopymap_1301_Combat[%CopyMapID]);
	deleteVariables("$SptCopymap_1301_Combat" @ %CopyMapID);

	deleteVariables("$SL_CopyMap_Sates" @ %CopyMapID);
}
//■■■■【时空裂痕】■■■■【副本结束触发】■■■■■■



//■■■■【时空裂痕】■■■■【星魂对话】■■■■■■■■

function NpcOnTrigger_CopyMap_1301_413010001(%Npc,%Player,%State,%Conv,%Param)
{
	%CopyMapID = %Player.GetLayerId();
	%CopymapDataID = SptGetCopymapDataId(%CopyMapID);
	%PlayerID = %Player.GetPlayerID();
	if (%CopymapDataID != 1301)
		return;
	if (%Npc.MasterID != %PlayerID)
	{
		%Conv.Settype(4);
		SendOneScreenMessage(2,"请寻找自己的本命星！",%Player);
		return;
	}
	%Act0 = GetAct(%Player,4091,0);
	%Act1 = GetAct(%Player,4091,1);
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000088);
			if (%Act0 < 5)
				%Conv.AddOption(600000089,600000089);
			if (%Act0 < %Act1)
				%Conv.AddOption(600000090,600000090);
		case 600000089:
			%reusalt = DelItemForXingHun(%Player);
			if (%reusalt == 1)
			{
				%Color = GetXingHunLevel(%Player);
				if (%Color > %Act1)
					%Act1 = %Color;
				SetAct(%Player,4091,%Color,%Act1);
				GiveXingHunSchbuff(%Player,%Color);
				%Packet = $XingHunPacket[%Color];
				RemovePacket(%Npc.XingHunPacket);
				%Npc.XingHunPacket = %Npc.Addpacket(%Packet);
				//echo( %Player.GetActivity( 4091 ) );
				if (%Color >= 4)//发公告了
				{
					%HuoDongMingCheng = GetHuoDongName("时空裂痕",1);
					%PlayerName = GetPlayerZiTiName(%Player,1);
					switch (%Color)
					{
						case 4: %ItemName =  $Get_Dialog_GeShi[31409] @ "紫色本命星</t>"; %ItemName2 = $Get_Dialog_GeShi[60002] @ "紫色本命星";
						case 5: %ItemName =  $Get_Dialog_GeShi[31421] @ "橙色本命星</t>"; %ItemName2 = $Get_Dialog_GeShi[60003] @ "橙色本命星";
					}
					%Text =  %PlayerName @ "<t>在</t>" @ %HuoDongMingCheng @ "<t>内提升本命星时获得了</t>" @ %ItemName @ "<t>，真是羡煞众人。</t>";
					SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Text @ "</t>");

					%PlayerName2 = GetPlayerZiTiName(%Player,2);
					%HuoDongMingCheng2 = GetHuoDongName("时空裂痕",2);
					%Text2 = %PlayerName2 @ "<t>在</t>" @ %HuoDongMingCheng2 @ "<t>内获得了</t>" @ %ItemName2;
					SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
				}
			}
			return NpcOnTrigger_CopyMap_1301_413010001(%Npc,%Player,0,%Conv,%Param);
		case 600000090:
			%reusalt = DelItemForXingHun(%Player);
			if (%reusalt == 1)
			{
				SetAct(%Player,4091,%Act1,%Act1);
				GiveXingHunSchbuff(%Player,%Act1);
				%Packet = $XingHunPacket[%Act1];
				RemovePacket(%Npc.XingHunPacket);
				%Npc.XingHunPacket = %Npc.Addpacket(%Packet);
			}
			return NpcOnTrigger_CopyMap_1301_413010001(%Npc,%Player,0,%Conv,%Param);
	}
}
function GiveXingHunSchbuff(%Player,%SchbuffID)
{
	for (%i = 1; %i <= 5; %i++)
	{
		if (%Player.IsSchbuff($XingHunSchbuff[%i]))
			%Player.RemoveSchbuff($XingHunSchbuff[%i]);
	}
	%Player.SetSchbuff($XingHunSchbuff[%SchbuffID]);
}
function DelItemForXingHun(%Player)
{
	%Level = %Player.GetLevel();
	if (%Level <= 50) %ItemID = 105105701;
	else if (%Level <= 70) %ItemID = 105105702;
	else if (%Level <= 90) %ItemID = 105105703;
	else %ItemID = 105105704;
	if (%Player.GetItemCount(%ItemID) < 1)
	{
		SendOneScreenMessage(2,"您没有" @ GetItemData(%ItemID,1) @ "，升级失败",%Player);
		return 0;
	}
	%Player.Putitem(%ItemID,-1);
	if (%Player.Additem(1,4091))
		return 1;
}
function GetXingHunLevel(%Player)//星魂等级的概率
{
	%Ran = GetRandom(1,100);
	if (%Ran <= 49) %Relt = 1;
	else if (%Ran <= 79) %Relt = 2;
	else if (%Ran <= 94) %Relt = 3;
	else if (%Ran <= 97) %Relt = 4;
	else if (%Ran <= 100) %Relt = 5;
	return %Relt;
}
//■■■■【时空裂痕】■■■■【星魂对话】■■■■■■■■

//■■■■【时空裂痕】■■■■【采集物触发】■■■■■■■

function TriggerEvent_553000001(%Player,%Event,%EventID)
{
	if (%Event.Master != %Player.GetPlayerID())
	{
		%text = "这个宝箱不是你的!";
		SendOneScreenMessage(2,%text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
		return false;
	}
	%Act_A = GetWord(%Player.GetActivity(3029),0) * 1;
	%Act_B = GetWord(%Player.GetActivity(3029),1) * 1;
	if (!(%Act_A == 1 && %Act_B == 0))
	{
		%text = "无法开启此宝箱!";
		SendOneScreenMessage(2,%text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
		return false;
	}
	SetAct(%Player,3029,%Act_A,%Act_B++);
	return true;
}
//■■■■【时空裂痕】■■■■【采集物触发】■■■■■■■
