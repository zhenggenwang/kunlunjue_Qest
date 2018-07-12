//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//�����ؾ�
//==================================================================================
//���������������ؾ�������������ȫ�ֱ�������������������
//���������������ؾ�������������������������������������
//���������������ؾ���������������ҽ��븱��������������
//���������������ؾ������������� NPC�Ի�����������������
//���������������ؾ�������������������������������������





//���������������ؾ�������������ȫ�ֱ�������������������
//413180001	��ʦ
//413181001	�������
//413181002	�����콫
//413181003	������ʦ
$CopyMapNpcRecord1318[0] = "413181002;-89.6646 -37.2118 105.699;90;1.2 1.2 1.2;";
$CopyMapNpcRecord1318[1] = "413181002;-102.476 -21.799 105.6891;90;1.2 1.2 1.2;";
$CopyMapNpcRecord1318[2] = "413181002;-28.1617 11.1242 105.4311;90;1.2 1.2 1.2;";
$CopyMapNpcRecord1318[3] = "413181002;74.5651 25.23871 107.5261;90;1.2 1.2 1.2;";
$CopyMapNpcRecord1318[4] = "413181002;32.2998 -19.0191 107.5261;90;1.2 1.2 1.2;";
$CopyMapNpcRecord1318[5] = "413181002;-96.5401 38.7848 107.4211;90;1.2 1.2 1.2;";
$CopyMapNpcRecord1318[6] = "413181002;-72.0499 10.1172 107.4211;90;1.2 1.2 1.2;";
$CopyMapNpcRecord1318[7] = "413181002;64.5888 -27.0508 105.3911;90;1.2 1.2 1.2;";
$CopyMapNpcRecord1318[8] = "413181003;62.1557 -58.2622 109.8211;90;1.5 1.5 1.5;";//BOSSS


//���������������ؾ�������������ȫ�ֱ�������������������


//���������������ؾ�������������������������������������
function SvrCopymapOpen_1318_Trigger(%CopyMapID, %CopymapDataID)
{
	if(!isobject($CopyMapNpcRecord1318[%CopyMapID]))
		$CopyMapNpcRecord1318[%CopyMapID] = SpNewNpc2(0, 413180001, "-42.5182 -28.4415 107.995", %CopyMapID, 180);
}
//���������������ؾ�������������������������������������

//���������������ؾ���������������ҽ��븱��������������
function SptCopymap_OnEnter_1318_Trigger(%CopyMapID, %Player)
{

}
//���������������ؾ���������������ҽ��븱��������������

//���������������ؾ������������� NPC�Ի�����������������
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
			%Txt1 = "������δ���ţ������ڴ�";
			SendOneScreenMessage(2, %Txt1, %Player);
			SendOneChatMessage($chatMsg_System, "<t>" @ %Txt1 @ "</t>", %Player);
			return FengShenMiJing_TransPortObject(%Npc, %Player, 0, %Conv);
		}
		if (%Player.GetLevel() < $SL_FengShenMiJing_Level)
		{
			%Txt1 = "���ؾ�������֣���ﵽ" @ $SL_FengShenMiJing_Level @ "����";
			SendOneScreenMessage(2, %Txt1, %Player);
			SendOneChatMessage($chatMsg_System, "<t>" @ %Txt1 @ "</t>", %Player);
			return FengShenMiJing_TransPortObject(%Npc, %Player, 0, %Conv);
		}
		if (GetOrgActivityRecordServer(%Player, 5) > 0)
		{
			%Txt1 = "�������Ѿ��ι��ø�����������������";
			SendOneScreenMessage(2, %Txt1, %Player);
			SendOneChatMessage($chatMsg_System, "<t>" @ %Txt1 @ "</t>", %Player);
			return FengShenMiJing_TransPortObject(%Npc, %Player, 0, %Conv);
		}

		if (SvrIsMyselfHasTeam(%PlayerID) == 0)
		{
			%Txt1 = "�ؾ���������֣������������";
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
		if (!SvrIsMyselfCaption(%PlayerID))//�жϵ�ǰ����Ƿ�Ϊ�ӳ�
		{
			%Txt1 = "��Ҫ�ӳ��ſ��Կ�������";
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
	if (!SvrIsMyselfCaption(%PlayerID))//�жϵ�ǰ����Ƿ�Ϊ�ӳ�
	{
		%Txt1 = "��Ҫ�ӳ��ſ��Կ�������";
		SendOneScreenMessage(2, %Txt1, %Player);
		SendOneChatMessage($chatMsg_System, "<t>" @ %Txt1 @ "</t>", %Player);
		return;
	}

	//��ȡ���ID
	%T = SptCopyMap_GetAllPlayer(%CopyMapID);
	%T_Num = SptCopyMap_GetPlayerCount(%CopyMapID);

	//if (%T_Num < 3)
	//{
	//	%text = "�����������õ���3�ˣ����ټ�Щ����������";
	//	SendAllChatMessageLayer(0, $Get_Dialog_GeShi[31406]  @ %text @ "</t>", %CopyMapID);	//���͸�������Ϣ( ��Ļ���� )
	//	SendAllScreenMessageLayer(0, %text, %CopyMapID);	//���͸�������Ϣ( ��Ļ�м� )
	//	return;
	//}

	//echo("CreateMonsterForFengShenMiJing ====" @ %t);
	for (%i = 0; %i < %T_Num; %i++)
	{
		%Player = GetWord(%T, %i);
		if (GetOrgActivityRecordServer(%Player, 5) > 0)
		{
			%text = "���ѡ�" @ %Player.GetObjectName() @ "�������Ѿ���ս�����������޷��ٴ���ս��";
			SendAllChatMessageLayer(0, $Get_Dialog_GeShi[31406]  @ %text @ "</t>", %CopyMapID);	//���͸�������Ϣ( ��Ļ���� )
			SendAllScreenMessageLayer(0, %text, %CopyMapID);	//���͸�������Ϣ( ��Ļ�м� )
			return;
		}
	}

	$CopyMapRecord1318[%CopyMapID] = 1;
	SptCopymap_Close(%CopyMapID);//�رո�����

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
//���������������ؾ������������� NPC�Ի�����������������


//���������������ؾ�������������������������������������
function KilledMonster_413181001(%Player, %Monster, %SharePlayerNum, %MaxConnection)//�������
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
function KilledMonster_413181002(%Player, %Monster, %SharePlayerNum, %MaxConnection)//�����콫
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
function NpcObjectonDeathcast_413181003(%Monster, %Player)//������ʦ
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
	for (%i = 0; %i < %T_Num; %i++)	//��ȡ��ҵȼ�
	{
		//��ȡPlayer
		%Player = GetWord(%T, %i);
		%orgID = SptOrg_GetOrgID(%Player.GetPlayerID());		//����ID
		if (%orgID > 0)
			GetOrgActivityWages(%Player, 5);
	}
}
//���������������ؾ�������������������������������������