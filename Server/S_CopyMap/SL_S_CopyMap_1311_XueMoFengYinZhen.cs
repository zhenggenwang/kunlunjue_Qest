//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//Ѫħ��ӡ��
//==================================================================================
//����������Ѫħ��ӡ�󡿡���������ȫ�ֱ�������������������
//����������Ѫħ��ӡ�󡿡���������������������������������
//����������Ѫħ��ӡ�󡿡������������븱������������������
//����������Ѫħ��ӡ�󡿡���������NPC�Ի��ű�������������
//����������Ѫħ��ӡ�󡿡���������ս�����̡���������������
//����������Ѫħ��ӡ�󡿡���������ˢ�ֺ�������������������
//����������Ѫħ��ӡ�󡿡���������������������������������
//����������Ѫħ��ӡ�󡿡�����������ӡ�������������������


//����������Ѫħ��ӡ�󡿡���������ȫ�ֱ�������������������
//-13.2119,-10.9067,75.1467 ���ӡNPC����
//-3.96725,-31.7436,75.1469 ��������NPC
//-3.59273,-34.6879,75.1469 ˫��

$XueMoFengYinMonsterPos[1] = "413071001;10.0743 -0.238921 75.3427";
$XueMoFengYinMonsterPos[2] = "413071001;-2.80321 -0.0283022 75.3427";
$XueMoFengYinMonsterPos[3] = "413071001;-15.8377 0.188395 75.3427";
$XueMoFengYinMonsterPos[4] = "413071001;-29.775 0.0817939 75.3427";
$XueMoFengYinMonsterPos[5] = "413071001;-29.7926 9.85465 75.3427";
$XueMoFengYinMonsterPos[6] = "413071001;-16.0025 9.72533 75.3427";
$XueMoFengYinMonsterPos[7] = "413071001;-3.16365 9.78805 75.3427";
$XueMoFengYinMonsterPos[8] = "413071001;10.2502 10.0105 75.3427";
$XueMoFengYinMonsterPos[9] = "413071001;10.1194 20.021 75.3427";
$XueMoFengYinMonsterPos[10] = "413071002;10.2644 29.9017 75.3427";
$XueMoFengYinMonsterPos[11] = "413071002;10.2003 40.0136 75.3427";
$XueMoFengYinMonsterPos[12] = "413071002;10.3865 50.0834 75.3427";
$XueMoFengYinMonsterPos[13] = "413071002;-2.98516 50.3162 75.3427";
$XueMoFengYinMonsterPos[14] = "413071002;-2.8705 39.9746 75.3427";
$XueMoFengYinMonsterPos[15] = "413071002;-15.8597 39.7811 75.3427";
$XueMoFengYinMonsterPos[16] = "413071002;-16.0513 50.3217 75.3427";
$XueMoFengYinMonsterPos[17] = "413071003;-30.0997 50.3917 75.3427";
$XueMoFengYinMonsterPos[18] = "413071003;-30.1607 40.5347 75.3189";
$XueMoFengYinMonsterPos[19] = "413071003;-30.0947 29.9858 75.3427";
$XueMoFengYinMonsterPos[20] = "413071003;-30.0271 20.0725 75.3427";

$XueMoFengYinBossPos[1] = "-9.89526 25.2811 75.5289";// �����ĵ�
$XueMoFengYinBossPos[2] = "-15.1783 23.3683 75.529";
$XueMoFengYinBossPos[3] = "-14.3323 28.9248 75.5287";
$XueMoFengYinBossPos[4] = "-5.59522 28.9997 75.5286";
$XueMoFengYinBossPos[5] = "-4.79466 22.9349 75.5291";

//413070001	��������
//413070002	�����ӡ

//����������Ѫħ��ӡ�󡿡���������ȫ�ֱ�������������������


//����������Ѫħ��ӡ�󡿡���������������������������������
function SvrCopymapOpen_1311_Trigger(%CopyMapID,%CopymapDataID)
{
	SpNewNpc2(0,413070002,"-12.7034 -11.3481 75.1467",%CopyMapID,90);//���ӡNPC����
	SpNewNpc2(0,413070001,"-5.67327 -29.532 75.1468",%CopyMapID,270);//��������NPC
	SpNewNpc2(0,410010113,"-6.35354 -33.1873 75.1469",%CopyMapID,270);//˫��
}
//����������Ѫħ��ӡ�󡿡���������������������������������

//����������Ѫħ��ӡ�󡿡������������븱������������������
function SptCopymap_OnEnter_1311_Trigger(%CopyMapID,%Player)
{
	schedule(5000,0,"SptCopymap_OnEnter_1311_Trigger_A",%CopyMapID,%Player);
}
function SptCopymap_OnEnter_1311_Trigger_A(%CopyMapID,%Player)
{
	%Player.SendPlayerString(5,"7200 0 0",0);
}
//����������Ѫħ��ӡ�󡿡������������븱������������������


//����������Ѫħ��ӡ�󡿡���������NPC�Ի��ű�������������
function XueMoFengYinZhenDiaLogA(%Npc,%Player,%State,%Conv)//��ڴ��ͶԻ�
{
	if ($SL_XueMoFenYinZhen_State_bActive != 1)
		return;
	%PlayerID = %Player.GetPlayerID();
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000091);
			%Conv.AddOption(600000092,600000092);
		case 600000092:
			if (!SvrIsMyselfHasTeam(%PlayerID))//û����
			{
				%text = "�����齨һֻ��������";
				SendOneScreenMessage(2,%text,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
				return XueMoFengYinZhenDiaLogA(%Npc,%Player,0,%Conv);
			}
			if (GetSrc(%Player,57) >= 1)
			{
				%text = "�������ս��Ѫħ��ӡ���ˣ�����������";
				SendOneScreenMessage(2,%text,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
				return XueMoFengYinZhenDiaLogA(%Npc,%Player,0,%Conv);
			}
			if (%Player.GetLevel() < $SL_XueMoFenYinZhen_MinLv)
			{
				%text = $SL_XueMoFenYinZhen_MinLv @ "�����ϲſ�����ս�˸���";
				SendOneScreenMessage(2,%text,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
				return XueMoFengYinZhenDiaLogA(%Npc,%Player,0,%Conv);
			}
			%Conv.SetType(4);
			GoToNextMap(%Player,1311,"");
	}
}
function XueMoFengYinZhenDiaLogB(%Npc,%Player,%State,%Conv)//��������ս���Ի�
{
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000091);
			%Conv.AddOption(600000093,600000093);
		case 600000093:
			%Conv.SetType(4);
			if (SvrIsMyselfCaption(%Player.getPlayerID()) == 0)
			{
				%text = "�����ɶӳ���������";
				SendOneScreenMessage(2,%text,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
				return;
			}
			%Player.NpcRecord = %Npc;
			%Player.ShowDialogOk(2000000016,16,1);
	}
}
function XueMoFengYinZhenKaiQi(%Player)
{
	%PlayerID = %Player.GetPlayerID();
	%CopyMapID = %Player.GetLayerID();

	$TeammateList[%CopyMapID] = SptCopyMap_GetAllPlayer(%CopyMapID);//��ȡ���������Ϣ
	$TeammateNum[%CopyMapID] = SptCopyMap_GetPlayerCount(%CopyMapID);//��ȡ�����������

	%TeammateList = SvrGetTeammate(%PlayerID,256); 		//��ȡ������Ϣ
	%TeammateNum = GetWordCount(%TeammateList);				//��ȡ��������

	if ($TeammateNum[%CopyMapID] != %TeammateNum)
	{
		%text = "��Ķ�Ա����̫Զ�ˣ��޷���������";
		SendOneScreenMessage(2,%text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
		return;
	}

	if (!SvrIsMyselfCaption(%PlayerID))
		return;
	if (!isobject(%Player.NpcRecord))
		return;

	//��¼�����Ѳ���
	for (%i = 0; %i < $TeammateNum[%CopyMapID]; %i++)
	{
		%Player = GetWord($TeammateList[%CopyMapID],%i);
		SetSrc(%Player,57);
	}

	%Player.NpcRecord.SafeDeleteobject();
	XueMoFengYinZhen_ZhanDouLiuCheng(%CopyMapID,1815);
}
function XueMoFengYinZhenDiaLogC(%Npc,%Player,%State,%Conv)//�����ӡ�Ի�
{
	%CopyMapID = %Player.GetLayerID();
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000094);
			%Conv.AddOption(600000095,600000095);
		case 600000095:
			%AllNumBer = 0;
			for (%i = 1; %i<= 20; %i++)
			{
				%Obj = $SptCopymap_1311_MonSterRecord[%CopyMapID,%i];
				if (isobject(%Obj) && %Obj.GetBuffCount(39008,1) >= 1)
					%AllNumBer++;
			}
			if (%AllNumBer == 0)
			{
				%Conv.SetText(600000094);
				%Conv.AddOption(600000095,600000095);
				%text = "û�п��Խ��Ĺ���";
				SendOneScreenMessage(2,%text,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
				return;
			}
			%Conv.SetText(600000096);
			%Conv.AddOption(600000097,600000097);
		case 600000097:
			%Conv.Settype(4);
			if (%Player.GetMoney(1) < 200)
			{
				%text = "���Ԫ������";
				SendOneScreenMessage(2,%text,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
			}
			else
			{
				%Player.ReduceMoney(200,1,1,57);
				DelXueMoFengYinAll(%CopyMapID);
			}

	}
}
//����������Ѫħ��ӡ�󡿡���������NPC�Ի��ű�������������


//����������Ѫħ��ӡ�󡿡���������ս�����̡���������������
function XueMoFengYinZhen_ZhanDouLiuCheng(%CopyMapID,%Step)
{
	CanCel($SptCopymap_1311_Combat[%CopyMapID]);
	$SptCopymap_1311_TimeRecord[%CopyMapID] = %Step;
	//echo( "ʱ�� ============"  @ $SptCopymap_1311_TimeRecord[ %CopyMapID ] );
	%Time = 1;
	switch (%Step)
	{
		case 1815:
			%text = "��������15�������������׼��";
			SendAllChatMessageLayer(0,$Get_Dialog_GeShi[31406]  @ %text @ "</t>",%CopyMapID);	//���͸�������Ϣ( ��Ļ���� )
			SendAllScreenMessageLayer(0,%text,%CopyMapID);	//���͸�������Ϣ( ��Ļ�м� )
			$SptCopymap_1311_LevelRecord[%CopyMapID] = SptCopyMap_GetPlayerCorpsLvA(%CopyMapID);
			%Time = 15;
		case 1800://��һ����
			$SptCopymap_1311_BoShuRecord[%CopyMapID] = 1;
			SptCreateMonSter1311(%CopyMapID,$SptCopymap_1311_BoShuRecord[%CopyMapID],0);//��������
		case 300://����ʱ����
			RemoveCopyMapOnLeaveTeam(%CopyMapID,3);
		default:
			if ($SptCopymap_1311_TimeRecord[%CopyMapID]%60 == 0)
			{
				$TeammateList[%CopyMapID] = SptCopyMap_GetAllPlayer(%CopyMapID);//��ȡ���������Ϣ
				$TeammateNum[%CopyMapID] = SptCopyMap_GetPlayerCount(%CopyMapID);//��ȡ�����������
			}
	}
	if (%Time > 0)
		$SptCopymap_1311_Combat[%CopyMapID] = schedule(%Time * 1000,0,"XueMoFengYinZhen_ZhanDouLiuCheng",%CopyMapID,%Step - %Time);//��ʼִ��ս������
}
//����������Ѫħ��ӡ�󡿡���������ս�����̡���������������

//����������Ѫħ��ӡ�󡿡���������ˢ�ֺ�������������������
function SptCreateMonSter1311(%CopyMapID,%BoShu,%IsBoss)
{
	CanCel($DelXueMoFengYin[%CopyMapID]);
	if (%IsBoss == 1)
	{
		if (isobject($SptCopymap_1311_LastBoss[%CopyMapID,1]))
			$SptCopymap_1311_LastBoss[%CopyMapID,1].Safedeleteobject();
		switch (%BoShu)
		{
			case 1:
				$SptCopymap_1311_BossRecord[%CopyMapID] = "413071004.1";
				$SptCopymap_1311_LastBoss[%CopyMapID,1] = SpNewNpc2(0,413071004,$XueMoFengYinBossPos[1],%CopyMapID,180);
				$SptCopymap_1311_LastBoss[%CopyMapID,1].SetLevel($SptCopymap_1311_LevelRecord[%CopyMapID]);
			case 2:
				$SptCopymap_1311_BossRecord[%CopyMapID] = "413071005.1";
				$SptCopymap_1311_LastBoss[%CopyMapID,1] = SpNewNpc2(0,413071005,$XueMoFengYinBossPos[1],%CopyMapID,180);
				$SptCopymap_1311_LastBoss[%CopyMapID,1].SetLevel($SptCopymap_1311_LevelRecord[%CopyMapID]);
			case 3:
				$SptCopymap_1311_BossRecord[%CopyMapID] = "413071006.1";
				$SptCopymap_1311_LastBoss[%CopyMapID,1] = SpNewNpc2(0,413071006,$XueMoFengYinBossPos[1],%CopyMapID,180);
				$SptCopymap_1311_LastBoss[%CopyMapID,1].SetLevel($SptCopymap_1311_LevelRecord[%CopyMapID]);
			case 4:
				$SptCopymap_1311_BossRecord[%CopyMapID] = "413071007.1";
				$SptCopymap_1311_LastBoss[%CopyMapID,1] = SpNewNpc2(0,413071007,$XueMoFengYinBossPos[1],%CopyMapID,180);
				$SptCopymap_1311_LastBoss[%CopyMapID,1].SetLevel($SptCopymap_1311_LevelRecord[%CopyMapID]);
			case 5:
				$SptCopymap_1311_BossRecord[%CopyMapID] = "413071008.1";
				$SptCopymap_1311_LastBoss[%CopyMapID,1] = SpNewNpc2(0,413071008,$XueMoFengYinBossPos[1],%CopyMapID,180);
				$SptCopymap_1311_LastBoss[%CopyMapID,1].SetLevel($SptCopymap_1311_LevelRecord[%CopyMapID]);
			case 6:
				$SptCopymap_1311_BossRecord[%CopyMapID] = "413071009.1.413071010.1.413071011.1.413071012.1.413071013.1";
				$SptCopymap_1311_BossRecord[%CopyMapID,1] = "413071009.1.";
				$SptCopymap_1311_BossRecord[%CopyMapID,2] = "413071010.1.";
				$SptCopymap_1311_BossRecord[%CopyMapID,3] = "413071011.1.";
				$SptCopymap_1311_BossRecord[%CopyMapID,4] = "413071012.1.";
				$SptCopymap_1311_BossRecord[%CopyMapID,5] = "413071013.1.";
				$SptCopymap_1311_LastBoss[%CopyMapID,1] = SpNewNpc2(0,413071009,$XueMoFengYinBossPos[2],%CopyMapID,180);
				$SptCopymap_1311_LastBoss[%CopyMapID,1].SetLevel($SptCopymap_1311_LevelRecord[%CopyMapID]);
				$SptCopymap_1311_LastBoss[%CopyMapID,2] = SpNewNpc2(0,413071010,$XueMoFengYinBossPos[3],%CopyMapID,180);
				$SptCopymap_1311_LastBoss[%CopyMapID,2].SetLevel($SptCopymap_1311_LevelRecord[%CopyMapID]);
				$SptCopymap_1311_LastBoss[%CopyMapID,3] = SpNewNpc2(0,413071011,$XueMoFengYinBossPos[4],%CopyMapID,180);
				$SptCopymap_1311_LastBoss[%CopyMapID,3].SetLevel($SptCopymap_1311_LevelRecord[%CopyMapID]);
				$SptCopymap_1311_LastBoss[%CopyMapID,4] = SpNewNpc2(0,413071012,$XueMoFengYinBossPos[5],%CopyMapID,180);
				$SptCopymap_1311_LastBoss[%CopyMapID,4].SetLevel($SptCopymap_1311_LevelRecord[%CopyMapID]);
				$SptCopymap_1311_LastBoss[%CopyMapID,5] = SpNewNpc2(0,413071013,$XueMoFengYinBossPos[1],%CopyMapID,180);
				$SptCopymap_1311_LastBoss[%CopyMapID,5].SetLevel($SptCopymap_1311_LevelRecord[%CopyMapID]);
		}
		//���һ�������ڹ���
		if (%BoShu < 6)
			%text = $SptCopymap_1311_LastBoss[%CopyMapID,1].GetObjectname() @ "��Ϯ";
		else
			%text = $SptCopymap_1311_LastBoss[%CopyMapID,5].GetObjectname() @ "��Ϯ";
		SendAllChatMessageLayer(0,$Get_Dialog_GeShi[31406]  @ %text @ "</t>",%CopyMapID);	//���͸�������Ϣ( ��Ļ���� )
		SendAllScreenMessageLayer(0,%text,%CopyMapID);	//���͸�������Ϣ( ��Ļ�м� )
	}
	else
	{
		$SptCopymap_1311_MonSterRecord[%CopyMapID] = 20;//����С�ֵ�����
		for (%i = 1; %i <= 20; %i++)
		{
			%NpcID = GetWord($XueMoFengYinMonsterPos[%i],0,";");
			%Pos = GetWord($XueMoFengYinMonsterPos[%i],1,";");
			$SptCopymap_1311_MonSterRecord[%CopyMapID,%i] = SpNewNpc2(0,%NpcID,%Pos,%CopyMapID,180);

			//����Ҫ���ݲ�������BUFF�ˡ���
			$SptCopymap_1311_MonSterRecord[%CopyMapID,%i].Addbuff(390050001,$SptCopymap_1311_MonSterRecord[%CopyMapID,%i],%BoShu * 2);//�����������100%
			$SptCopymap_1311_MonSterRecord[%CopyMapID,%i].Addbuff(390060001,$SptCopymap_1311_MonSterRecord[%CopyMapID,%i],%BoShu * 5);//����������100%
			$SptCopymap_1311_MonSterRecord[%CopyMapID,%i].Addbuff(390080001,$SptCopymap_1311_MonSterRecord[%CopyMapID,%i],1);//��ӡ״̬
			$SptCopymap_1311_MonSterRecord[%CopyMapID,%i].SetLevel($SptCopymap_1311_LevelRecord[%CopyMapID]);
			$SptCopymap_1311_MonSterRecord[%CopyMapID,%i].SetScale("2 2 2");
		}
		switch (%BoShu)
		{
			case 1:$SptCopymap_1311_BossRecord[%CopyMapID] = "413071004.0";
			case 2:$SptCopymap_1311_BossRecord[%CopyMapID] = "413071005.0";
			case 3:$SptCopymap_1311_BossRecord[%CopyMapID] = "413071006.0";
			case 4:$SptCopymap_1311_BossRecord[%CopyMapID] = "413071007.0";
			case 5:$SptCopymap_1311_BossRecord[%CopyMapID] = "413071008.0";
			case 6:$SptCopymap_1311_BossRecord[%CopyMapID] = "413071009.0.413071010.0.413071011.0.413071012.0.413071013.0";
		}
		DelXueMoFengYin(%CopyMapID,0);//������
	}

	//ˢ����� ������Ϣ
	for (%i = 0; %i < $TeammateNum[%CopyMapID]; %i++)
	{
		%Player = GetWord($TeammateList[%CopyMapID],%i);
		%Msg = $SptCopymap_1311_TimeRecord[%CopyMapID] @ " " @ $SptCopymap_1311_BoShuRecord[%CopyMapID] @ " " @ $SptCopymap_1311_MonSterRecord[%CopyMapID] @ " " @ $SptCopymap_1311_BossRecord[%CopyMapID];
		%Player.SendPlayerString(5,%Msg,0);
	}
}
//����������Ѫħ��ӡ�󡿡���������ˢ�ֺ�������������������

//����������Ѫħ��ӡ�󡿡���������������������������������
function NpcObjectonDeathcast_413071001(%Monster,%Killer){ NpcObjectonDeathcast_413071001_413071003(%Monster,%Killer); }//С��1
function NpcObjectonDeathcast_413071002(%Monster,%Killer){ NpcObjectonDeathcast_413071001_413071003(%Monster,%Killer); }//С��2
function NpcObjectonDeathcast_413071003(%Monster,%Killer){ NpcObjectonDeathcast_413071001_413071003(%Monster,%Killer); }//С��3
function NpcObjectonDeathcast_413071001_413071003(%Monster,%Killer)//С�������ļ�¼
{
	%CopyMapID = %Monster.GetLayerId();
	$SptCopymap_1311_MonSterRecord[%CopyMapID]--;
	//echo( "��������=========" @ $SptCopymap_1311_MonSterRecord[ %CopyMapID ] );
	if ($SptCopymap_1311_MonSterRecord[%CopyMapID] >= 1)
	{
		//ˢ����� ������Ϣ
		for (%i = 0; %i < $TeammateNum[%CopyMapID]; %i++)
		{
			%Player = GetWord($TeammateList[%CopyMapID],%i);
			%Msg = $SptCopymap_1311_TimeRecord[%CopyMapID] @ " " @ $SptCopymap_1311_BoShuRecord[%CopyMapID] @ " " @ $SptCopymap_1311_MonSterRecord[%CopyMapID] @ " " @ $SptCopymap_1311_BossRecord[%CopyMapID];
			%Player.SendPlayerString(5,%Msg,0);
		}
	}
	else
	{
		for (%i = 1; %i <= 20; %i++)
		{
			if ($SptCopymap_1311_MonSterRecord[%CopyMapID,%i].GetDamageState() $= "Enabled")
				return;
		}
		CanCel($DelXueMoFengYin[%CopyMapID]);
		SptCreateMonSter1311(%CopyMapID,$SptCopymap_1311_BoShuRecord[%CopyMapID],1);
	}
}
function NpcObjectonDeathcast_413071004(%Monster,%Killer){ NpcObjectonDeathcast_413071004_413071008(%Monster,%Killer,2); }//ͳ��
function NpcObjectonDeathcast_413071005(%Monster,%Killer){ NpcObjectonDeathcast_413071004_413071008(%Monster,%Killer,3); }//ͳ��
function NpcObjectonDeathcast_413071006(%Monster,%Killer){ NpcObjectonDeathcast_413071004_413071008(%Monster,%Killer,4); }//ͳ��
function NpcObjectonDeathcast_413071007(%Monster,%Killer){ NpcObjectonDeathcast_413071004_413071008(%Monster,%Killer,5); }//ͳ��
function NpcObjectonDeathcast_413071008(%Monster,%Killer){ NpcObjectonDeathcast_413071004_413071008(%Monster,%Killer,6); }//ͳ��
function NpcObjectonDeathcast_413071004_413071008(%Monster,%Killer,%NextBo)//ͳ������� ������һ��
{
	%CopyMapID = %Monster.GetLayerId();
	$SptCopymap_1311_BossRecord[%CopyMapID] = %Monster.GetDataID() @ ".2.";
	//ˢ����� ������Ϣ
	for (%i = 0; %i < $TeammateNum[%CopyMapID]; %i++)
	{
		%Player = GetWord($TeammateList[%CopyMapID],%i);
		%Msg = $SptCopymap_1311_TimeRecord[%CopyMapID] @ " " @ $SptCopymap_1311_BoShuRecord[%CopyMapID] @ " " @ $SptCopymap_1311_MonSterRecord[%CopyMapID] @ " " @ $SptCopymap_1311_BossRecord[%CopyMapID];
		%Player.SendPlayerString(5,%Msg,0);


		if (%Monster.GetDataid() == 413071004)
			AddAchievementWatch(%Player,0,37,1);//��¼�ɾ�
	}

	$SptCopymap_1311_BoShuRecord[%CopyMapID] = %NextBo;//׼����һ��
	%text = "��һ�����ｫ��10�����֣�������׼��";
	SendAllChatMessageLayer(0,$Get_Dialog_GeShi[31406]  @ %text @ "</t>",%CopyMapID);	//���͸�������Ϣ( ��Ļ���� )
	SendAllScreenMessageLayer(0,%text,%CopyMapID);	//���͸�������Ϣ( ��Ļ�м� )

	CalCel($SptCreateMonSter1311[%CopyMapID]);
	if (%NextBo < 6)
		$SptCreateMonSter1311[%CopyMapID] = schedule(10 * 1000,0,"SptCreateMonSter1311",%CopyMapID,$SptCopymap_1311_BoShuRecord[%CopyMapID],0);
	else
		$SptCreateMonSter1311[%CopyMapID] = schedule(10 * 1000,0,"SptCreateMonSter1311",%CopyMapID,$SptCopymap_1311_BoShuRecord[%CopyMapID],1);
}

function NpcObjectonDeathcast_413071009(%Monster,%Killer){ NpcObjectonDeathcast_413071009_413071013(%Monster,%Killer,1); }//BOSS����
function NpcObjectonDeathcast_413071010(%Monster,%Killer){ NpcObjectonDeathcast_413071009_413071013(%Monster,%Killer,2); }//BOSS����
function NpcObjectonDeathcast_413071011(%Monster,%Killer){ NpcObjectonDeathcast_413071009_413071013(%Monster,%Killer,3); }//BOSS����
function NpcObjectonDeathcast_413071012(%Monster,%Killer){ NpcObjectonDeathcast_413071009_413071013(%Monster,%Killer,4); }//BOSS����
function NpcObjectonDeathcast_413071013(%Monster,%Killer){ NpcObjectonDeathcast_413071009_413071013(%Monster,%Killer,5); }//�ռ�BOSS���� 
function NpcObjectonDeathcast_413071009_413071013(%Monster,%Killer,%BossBianHao)
{
	%CopyMapID = %Monster.GetLayerId();
	$SptCopymap_1311_BossRecord[%CopyMapID] = "";
	$SptCopymap_1311_BossRecord[%CopyMapID,%BossBianHao] = %Monster.GetDataID() @ ".2.";
	for (%i = 5; %i >= 1; %i--)
	{
		$SptCopymap_1311_BossRecord[%CopyMapID] = $SptCopymap_1311_BossRecord[%CopyMapID,%i] @ $SptCopymap_1311_BossRecord[%CopyMapID];
	}
	//ˢ����� ������Ϣ
	for (%i = 0; %i < $TeammateNum[%CopyMapID]; %i++)
	{
		%Player = GetWord($TeammateList[%CopyMapID],%i);
		%Msg = $SptCopymap_1311_TimeRecord[%CopyMapID] @ " " @ $SptCopymap_1311_BoShuRecord[%CopyMapID] @ " " @ $SptCopymap_1311_MonSterRecord[%CopyMapID] @ " " @ $SptCopymap_1311_BossRecord[%CopyMapID];
		%Player.SendPlayerString(5,%Msg,0);
	}

	//����� �ж��Ƿ���Խ�����
	for (%i = 1; %i <= 5; %i++)
	{
		if ($SptCopymap_1311_LastBoss[%CopyMapID,%i].GetDamageState() $= "Enabled")
			return;
	}
	%Player = GetTeamMaster(%Killer);
	%B0ssName = GetNpcZiTiName(%Monster,1);
	%B0ssName2 = GetNpcZiTiName(%Monster,2);
	%HuoDongMingCheng1 = GetHuoDongName("Ѫħ��ӡ��",1);
	%PlayerName1 = GetPlayerZiTiName(%Player,1);

	%HuoDongMingCheng2 = GetHuoDongName("Ѫħ��ӡ��",2);
	%PlayerName2 = GetPlayerZiTiName(%Player,2);

	%Text1 =  %PlayerName1 @ "<t>�����Ŷ�����</t>" @ %HuoDongMingCheng1 @ "<t>սʤ��</t>"  @ %B0ssName @ "<t>��������ʿһƬ��̾����</t>";
	%Text2 =  %PlayerName2 @ "<t>���������</t>" @ %HuoDongMingCheng2 @ "<t>սʤ��</t>"  @ %B0ssName2;

	SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
	SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);

	CanCel($SptCopymap_1311_Combat[%CopyMapID]);
	if ($SptCopymap_1311_TimeRecord[%CopyMapID] > 300)
		RemoveCopyMapOnLeaveTeam(%CopyMapID,3);
}
//����������Ѫħ��ӡ�󡿡���������������������������������


//����������Ѫħ��ӡ�󡿡�����������ӡ�������������������
//390050001	�����������100%
//390060001	����������100%
//390070001	�ظ�Ѫ��1%
//390080001	
function DelXueMoFengYin(%CopyMapID,%NumBer)
{
	//echo( "%CopyMapID ===" @ %CopyMapID @  "   %NumBer ====" @ %NumBer );
	CanCel($DelXueMoFengYin[%CopyMapID]);
	switch (%Number)
	{
		case 0:
			%Time = 20;
			$SptCopymap_1311_MonSterRecord[%CopyMapID,1].PacketRecord = $SptCopymap_1311_MonSterRecord[%CopyMapID,1].Addpacket(112113); //��Ҫһ��15�����ʱ�����Ч
		default:
			%Time = 15;
			%Obj = $SptCopymap_1311_MonSterRecord[%CopyMapID,%NumBer];
			//echo( %Obj.GetObjectname() @ "    " @ %Obj.GetDamageState( ) );
			if (%Obj.GetDamageState() $= "Enabled" && %Obj.GetBuffCount(39008,1) >= 1)
				%Obj.RemoveBuff(390080001);
			RemovePacket(%Obj.PacketRecord);
			%Obj.SetScale("1 1 1");
			if ($SptCopymap_1311_MonSterRecord[%CopyMapID,%NumBer + 1].GetDamageState() $= "Enabled")
			{
				$SptCopymap_1311_MonSterRecord[%CopyMapID,%NumBer + 1].PacketRecord = $SptCopymap_1311_MonSterRecord[%CopyMapID,%NumBer + 1].Addpacket(112113); //��Ҫһ��15�����ʱ�����Ч
			}
	}
	if (%NumBer < 20 && %Time > 0)
		$DelXueMoFengYin[%CopyMapID] = schedule(%Time * 1000,0,"DelXueMoFengYin",%CopyMapID,%NumBer++);
}
function DelXueMoFengYinAll(%CopyMapID)
{
	CanCel($DelXueMoFengYin[%CopyMapID]);
	for (%i = 1; %i <= 20; %i++)
	{
		%Obj = $SptCopymap_1311_MonSterRecord[%CopyMapID,%i];
		//echo( "%Obj====" @ %Obj @ "    %Obj.GetDamageState( )===" @ %Obj.GetDamageState( ) @ "     BUccount ===" @ %Obj.GetBuffCount( 39008, 1 ) );
		if (%Obj.GetDamageState() $= "Enabled" && %Obj.GetBuffCount(39008,1) >= 1)
			%Obj.RemoveBuff(390080001);
		RemovePacket(%Obj.PacketRecord);
		%obj.SetScale("1 1 1");
	}
}

//����������Ѫħ��ӡ�󡿡�����������ӡ�������������������

