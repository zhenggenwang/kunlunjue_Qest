//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//��������
//==================================================================================
//�����������������򡿡���������ȫ�ֱ�������������������
//�����������������򡿡���������ϵͳ���桿��������������
//�����������������򡿡���������������������������������
//�����������������򡿡������������븱������������������
//�����������������򡿡���������NPC�Ի��ű�������������
//�����������������򡿡���������ս�����̡���������������
//�����������������򡿡����������������㡿��������������
//�����������������򡿡�����������ұ���һ��ܡ���������
//�����������������򡿡��������������������㡿����������
//�����������������򡿡����������ɼ����ʡ���������������
//�����������������򡿡����������ɼ����䡿��������������
//�����������������򡿡���������ˢ�±��䡿��������������


//�����������������򡿡���������ȫ�ֱ�������������������
$SvrCopyMapPosRecord[1,1] = "-24.1455 -139.167 118.108";//������Ӫ������
$SvrCopyMapPosRecord[1,2] = "24.8903 -138.474 118.347";//���������
$SvrCopyMapPosRecord[1,3] = "413050001;1 1 1;340;-1.64769 -125.129 114.849";//����NPC����
$SvrCopyMapPosRecord[1,4] = "413050001;1 1 1;90;13.7701 -110.093 115";//����
$SvrCopyMapPosRecord[1,5] = "413050001;1 1 1;330;18.7216 -118.02 114.936";//����
$SvrCopyMapPosRecord[1,6] = "413050001;1 1 1;330;10.1315 -122.85 115";//����
$SvrCopyMapPosRecord[1,7] = "413050001;1 1 1;330;-12.9067 -126.936 114.98";//����
$SvrCopyMapPosRecord[1,8] = "413050001;1 1 1;220;-14.0645 -110.384 114.225";//����
$SvrCopyMapPosRecord[1,9] = "413050001;1 1 1;330;-19.9272 -118.826 114.659";//����
$SvrCopyMapPosRecord[1,10]= "413050001;1 1 1;30;-6.10039 -104.796 114.334";//����
$SvrCopyMapPosRecord[1,11]= "413050001;1 1 1;330;7.13625 -104.333 114.715";//����

$SvrCopyMapPosRecord[2,1] = "22.9413 145.322 118.35";//������Ӫ������
$SvrCopyMapPosRecord[2,2] = "-22.4965 140.214 118.162";//���������
$SvrCopyMapPosRecord[2,3] = "413050003;1 1 1;130;2.27856 129.022 115";//����NPC����
$SvrCopyMapPosRecord[2,4] = "413050003;1 1 1;330;-15.7458 113.299 114.967";//����
$SvrCopyMapPosRecord[2,5] = "413050003;1 1 1;130;-18.3104 121.9 114.894";//����
$SvrCopyMapPosRecord[2,6] = "413050003;1 1 1;150;-10.9207 127.985 114.94";//����
$SvrCopyMapPosRecord[2,7] = "413050003;1 1 1;150;10.9841 130.878 115";//����
$SvrCopyMapPosRecord[2,8] = "413050003;1 1 1;120;22.7769 120.061 114.594";//����
$SvrCopyMapPosRecord[2,9] = "413050003;1 1 1;330;14.9281 113.077 115";//����
$SvrCopyMapPosRecord[2,10]= "413050003;1 1 1;220;7.18836 105.046 114.665";//����
$SvrCopyMapPosRecord[2,11]= "413050003;1 1 1;100;-8.96304 108.464 114.831";//����

$SvrCopyMapPosRecord[3,1] = "552000015;-65.0179 -5.5992 99.2198";//�ɼ��� 
$SvrCopyMapPosRecord[3,2] = "552000016;-64.9099 -0.100411 99.1266";//�ɼ��� 1
$SvrCopyMapPosRecord[3,3] = "552000015;-65.4554 7.40362 99.2505";//�ɼ���
$SvrCopyMapPosRecord[3,4] = "552000015;65.1545 9.26818 99.3085";//�ɼ���
$SvrCopyMapPosRecord[3,5] = "552000016;65.1476 2.03671 99.1595";//�ɼ��� 1
$SvrCopyMapPosRecord[3,6] = "552000015;65.9509 -5.05774 99.2106";//�ɼ���
$SvrCopyMapPosRecord[3,7] = "552000016;13.25 11.2495 107.77";//�ɼ��� 1
$SvrCopyMapPosRecord[3,8] = "552000015;13.25 18.0957 107.969";//�ɼ���
$SvrCopyMapPosRecord[3,9] = "552000015;13.25 1.2508 107.662";//�ɼ���
$SvrCopyMapPosRecord[3,10]= "552000015;-9.24777 -2.74997 107.89";//�ɼ���
$SvrCopyMapPosRecord[3,11]= "552000015;-9.41816 3.35729 108.019";//�ɼ���
$SvrCopyMapPosRecord[3,12]= "552000015;-9.44025 9.1493 108.162";//�ɼ���
$SvrCopyMapPosRecord[3,13]= "552000015;-11.0743 16.0579 108.382";//�ɼ���
//�����������������򡿡���������ȫ�ֱ�������������������

//�����������������򡿡���������ϵͳ���桿��������������
function DaoJianShenYu_StytemMsg(%YY,%MM,%DD,%H,%M,%S)
{
	if (GetZoneid() != 1001)
		return;
	if ($SL_DaoJianShenYu_bActive != 1)
		return;
	%TimebActive = GetWord($SL_DaoJianShenYu_StartTime,0,":") * 60  + GetWord($SL_DaoJianShenYu_StartTime,1,":");
	%TimeNow = %H * 60 + %M;
	%Time = %TimebActive - %TimeNow;
	if (%Time == 10)
	{
		%HuoDongMingCheng = GetHuoDongName("��������",1);
		%Path = "<l i='810010100 11.9943 -14.1968 191.677' t='path'/>";
		%Text = %HuoDongMingCheng @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ %Time @ "</t><t>���Ӻ�����" @ $SL_DaoJianShenYu_Level @ "��������ʿ��ǰ��</t>" @ %Path @ "<t>�鿴����顣</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

		%Text2 =  GetHuoDongName("��������",2) @ "<t>����</t>" @ $Get_Dialog_GeShi[60002] @ %Time @ "</t><t>���Ӻ�����</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
	if (%Time == 5)
	{
		%HuoDongMingCheng = GetHuoDongName("��������",1);
		%Path = "<l i='810010100 11.9943 -14.1968 191.677' t='path'/>";
		%Text = %HuoDongMingCheng @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ %Time @ "</t><t>���Ӻ�����" @ $SL_DaoJianShenYu_Level @ "��������ʿ��ǰ��</t>" @ %Path @ "<t>�鿴����顣</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

		%Text2 =  GetHuoDongName("��������",2) @ "<t>����</t>" @ $Get_Dialog_GeShi[60002] @ %Time @ "</t><t>���Ӻ�����</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);

	}
	if (%Time == 0)
	{
		%HuoDongMingCheng = GetHuoDongName("��������",1);
		%Path = "<l i='810010100 11.9943 -14.1968 191.677' t='path'/>";
		%Text = %HuoDongMingCheng @ "<t>�Ѿ�����," @ $SL_DaoJianShenYu_Level @ "��������ʿ��ǰ��</t>" @ %Path @ "<t>,������ս��</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

		%Text2 =  GetHuoDongName("��������",2) @ "<t>�Ѿ�������</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
}
//�����������������򡿡���������ϵͳ���桿��������������


//�����������������򡿡���������������������������������
function SvrCopymapOpen_1313_Trigger(%CopyMapID,%CopymapDataID){ SvrCopymapOpen_1313_1315_Trigger(%CopyMapID,%CopymapDataID); }
function SvrCopymapOpen_1314_Trigger(%CopyMapID,%CopymapDataID){ SvrCopymapOpen_1313_1315_Trigger(%CopyMapID,%CopymapDataID); }
function SvrCopymapOpen_1315_Trigger(%CopyMapID,%CopymapDataID){ SvrCopymapOpen_1313_1315_Trigger(%CopyMapID,%CopymapDataID); }
function SvrCopymapOpen_1313_1315_Trigger(%CopyMapID,%CopymapDataID)
{
	//��������NPC
	for (%F = 1; %F <= 2; %F++)
	{
		for (%i = 3; %i <= 11; %i++)
		{
			%NpcID = GetWord($SvrCopyMapPosRecord[%F,%i],0,";");
			%Scal = GetWord($SvrCopyMapPosRecord[%F,%i],1,";");
			%Rot = GetWord($SvrCopyMapPosRecord[%F,%i],2,";");
			%Pos = GetWord($SvrCopyMapPosRecord[%F,%i],3,";");
			%Opj = SpNewNpc3(0,%NpcID,%Pos,%CopyMapID,%Rot,%Scal);
			%Opj.setforce(%F);
		}
	}
	for (%i = 1; %i <= 13; %i++)
	{
		%Cj = GetWord($SvrCopyMapPosRecord[3,%i],0,";");
		%Pos = GetWord($SvrCopyMapPosRecord[3,%i],1,";");
		
		if (%Cj == 552000015)
			%Opj = SpNewCj2(0, %Cj, %Pos, %CopyMapID, 180, "1 1 1");
		else
			%Opj = SpNewCj2(0, %Cj, %Pos, %CopyMapID, 180, "2 2 2");
	}
	//��ʼ��������¼
	$SvrCopyMapZhanDouLi[%CopyMapID,1] = 0;//2����Ӫ��ս����
	$SvrCopyMapZhanDouLi[%CopyMapID,2] = 0;//2����Ӫ��ս����
	$SvrCopyMapRenShu[%CopyMapID,1] = 0;//2����Ӫ������
	$SvrCopyMapRenShu[%CopyMapID,2] = 0;//2����Ӫ������
	$SvrCopyMapKillNumBer[%CopyMapID,1] = 0;//2����Ӫ�Ļ�����
	$SvrCopyMapKillNumBer[%CopyMapID,2] = 0;//2����Ӫ�Ļ�����
	$SvrCopyMapZiYuanRecord[%CopyMapID,1] = 0;//2����Ӫ����Դ����
	$SvrCopyMapZiYuanRecord[%CopyMapID,2] = 0;//2����Ӫ����Դ����
	//---����ʣ��ʱ��
	%Time = GetLocalTime();
	%H = GetWord(%Time,3);//Сʱ
	%M = GetWord(%Time,4);//����
	$SvrCopyMapLastTime[%CopyMapID] = 21 * 60 * 60 + 40 * 60 - %H * 60 * 60  - %M * 60;
	//ս�����̿�ʼ
	Cancel($SvrCopymap1313States[%CopyMapID]);
	$SvrCopymap1313States[%CopyMapID] = schedule(1000,0,"SvrCopymapOpen_1313_1315_Trigger_A",%CopyMapID,%CopymapDataID,$SvrCopyMapLastTime[%CopyMapID]);
}
//�����������������򡿡���������������������������������


//�����������������򡿡������������븱������������������
function SptCopymap_OnEnter_1313_Trigger(%CopyMapID,%Player){ SptCopymap_OnEnter_1313_1315_Trigger(%CopyMapID,%Player); }
function SptCopymap_OnEnter_1314_Trigger(%CopyMapID,%Player){ SptCopymap_OnEnter_1313_1315_Trigger(%CopyMapID,%Player); }
function SptCopymap_OnEnter_1315_Trigger(%CopyMapID,%Player){ SptCopymap_OnEnter_1313_1315_Trigger(%CopyMapID,%Player); }

function SptCopymap_OnEnter_1313_1315_Trigger(%CopyMapID,%Player)
{
	schedule(10 * 1000,0,"SptCopymap_OnEnter_1313_Trigger_A",%CopyMapID,%Player);
}

function SptCopymap_OnEnter_1313_Trigger_A(%CopyMapID,%Player)
{
	%PlayerID = %Player.GetPlayerID();
	//��ȡ������Ϣ
	%Time = GetLocalTime();
	%H = GetWord(%Time,3);//Сʱ
	%M = GetWord(%Time,4);//����

	%Act4094B = GetAct(%Player,4094,1);
	if (%Act4094B <= 20)
	{
		if ($SvrCopyMapZhanDouLi[%CopyMapID,1] < $SvrCopyMapZhanDouLi[%CopyMapID,2])
		{
			if (mabs($SvrCopyMapRenShu[%CopyMapID,1] - $SvrCopyMapRenShu[%CopyMapID,2]) <= 3 && $SvrCopyMapRenShu[%CopyMapID,1] < 25)
				%Force = 1;
			else
				%Force = 2;
		}
		else
		{
			if (mabs($SvrCopyMapRenShu[%CopyMapID,1] - $SvrCopyMapRenShu[%CopyMapID,2]) <= 3 && $SvrCopyMapRenShu[%CopyMapID,2] < 25)
				%Force = 2;
			else
				%Force = 1;
		}
	}
	else
	{
		if ($SvrCopyMapRenShu[%CopyMapID,1] == $SvrCopyMapRenShu[%CopyMapID,2])
			%Force = GetRandom(1,2);
		else if ($SvrCopyMapRenShu[%CopyMapID,1] > $SvrCopyMapRenShu[%CopyMapID,2])
			%Force = 2;
		else
			%Force = 1;
	}
	//-----------�������������� ͳ����ر���------------
	%Player.SetForce(%Force);
	$SvrCopyMapRenShu[%CopyMapID,%Force]++;
	if (%Act4094B <= 20)
		$SvrCopyMapZhanDouLi[%CopyMapID,%Force] = $SvrCopyMapZhanDouLi[%CopyMapID,%Force] + (50 - %Act4094B);

	%Player.TransportObject(0,0,GetWord($SvrCopyMapPosRecord[%Force,1],0),GetWord($SvrCopyMapPosRecord[%Force,1],1),GetWord($SvrCopyMapPosRecord[%Force,1],2));

	//----------ս���μӼ�¼��ʼ��------------
	SetAct(%Player,4094,GetSubStr($NowServerTime1,4,4),0);//���������¼

	$PlayerPvpPaiMing[%CopyMapID,%PlayerID] = 0;//��������
	$PlayerMissionRecord[%CopyMapID,%PlayerID] = 0;//������ɴ���
	$PlayerZiYuanRecord[%CopyMapID,%PlayerID] = 0;//�ɼ�����
	$PlayerKillNumRecord[%CopyMapID,%PlayerID] = 0;//ɱ������
	$PlayerTimeRecord[%CopyMapID,%PlayerID] = %H * 60 + %M;//����ʱ��
	//-----------------�·�ս������-------------
	//����ʣ��ʱ�� ��Ӫ1���� ��Ӫ2���� �������� ���˻������� ����������
	%Text = $SvrCopyMapLastTime[%CopyMapID] @ " " @ $SvrCopyMapKillNumBer[%CopyMapID,1] @ " " @ $SvrCopyMapKillNumBer[%CopyMapID,2] @ " " @ $PlayerPvpPaiMing[%CopyMapID,%PlayerID] @ " " @ $PlayerKillNumRecord[%CopyMapID,%PlayerID] @ " " @ $PlayerMissionRecord[%CopyMapID,%PlayerID];
	%Player.SendPlayerString(8,%Text,0);
}
//�����������������򡿡������������븱������������������


//�����������������򡿡���������NPC�Ի��ű�������������
function DaoJianShenYuDiaLog(%Npc,%Player,%State,%Conv)
{
	if ($SL_DaoJianShenYu_bActive != 1)
		return;
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000100);
			%Conv.AddOption(600000101,600000101);
		case 600000101:
			%Conv.SetType(4);
			if (%Player.GetLevel() < $SL_DaoJianShenYu_Level)
			{
				%text = $SL_DaoJianShenYu_Level @ "�����ϲſ��Բμӵ�������";
				SendOneScreenMessage(2,%text,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
				return;
			}
			if ($SL_DaoJianShenYu_State_bActive != 1)
			{
				%text = "�û�п���!";
				SendOneScreenMessage(2,%text,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
				return;
			}
			//%Src = GetSrc( %Player, 57 );
			%Act = GetAct(%Player,4094,0);
			if (GetSubStr($NowServerTime1,4,4) $= %Act)
			{
				%text = "�������ս���ˣ�����������";
				SendOneScreenMessage(2,%text,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
				return;
			}
			if (SvrIsMyselfHasTeam(%Player.GetPlayerID()))//�ж���
			{
				%text = "�˸���ֻ������״̬���룬���뿪����";
				SendOneScreenMessage(2,%text,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
				return;
			}
			%Level = %Player.GetLevel();
			if (%Level < 70)
				gotonextmap(%Player,"1313","");
			else if (%Level< 90)
				gotonextmap(%Player,"1314","");
			else
				gotonextmap(%Player,"1315","");
	}
}
//�����������������򡿡���������NPC�Ի��ű�������������


//�����������������򡿡���������ս�����̡���������������
function SvrCopymapOpen_1313_1315_Trigger_A(%CopyMapID,%CopymapDataID,%LastTime)
{
	Cancel($SvrCopymap1313States[%CopyMapID]);
	//echo( "%LastTime===" @ %LastTime );
	%LastTime--;
	$SvrCopyMapLastTime[%CopyMapID] = %LastTime;
	if (%LastTime%30 >= 0)//ÿ30�룬ȫ����ͬ��һ������
	{
		RankingCalculationForKill(%CopyMapID);//��������

		%TeammateList = SptCopyMap_GetAllPlayer(%CopyMapID);//��ȡ���������Ϣ
		%TeammateNum = SptCopyMap_GetPlayerCount(%CopyMapID);//��ȡ�����������
		if (%TeammateNum <= 0)
			return;
		for (%i = 0; %i < %TeammateNum; %i++)
		{
			%Player = GetWord(%TeammateList,%i);
			%PlayerID = %Player.GetPlayerID();
			//����ʣ��ʱ�� ��Ӫ1���� ��Ӫ2���� �������� ���˻������� ����������
			%Text = $SvrCopyMapLastTime[%CopyMapID] @ " " @ $SvrCopyMapKillNumBer[%CopyMapID,1] @ " " @ $SvrCopyMapKillNumBer[%CopyMapID,2] @ " " @ $PlayerPvpPaiMing[%CopyMapID,%PlayerID] @ " " @ $PlayerKillNumRecord[%CopyMapID,%PlayerID] @ " " @ $PlayerMissionRecord[%CopyMapID,%PlayerID];
			//echo( "%Text===" @ %Text );
			%Player.SendPlayerString(8,%Text,0);
		}
	}

	if (%LastTime == 1500 || %LastTime == 1200 || %LastTime == 900 || %LastTime == 600 || %LastTime == 300)//��������
		CreateCJForDianJianShenYu(%CopyMapID);

	if (%LastTime > 0)
		$SvrCopymap1313States[%CopyMapID] = schedule(1 * 1000,0,"SvrCopymapOpen_1313_1315_Trigger_A",%CopyMapID,%CopymapDataID,%LastTime);
	else
		SvrCopymapOpen_1313_1315_Stop(%CopyMapID,%CopymapDataID);
}

//�����������������򡿡���������ս�����̡���������������


//�����������������򡿡����������������㡿��������������
function SvrCopymapOpen_1313_1315_Stop(%CopyMapID,%CopymapDataID)
{
	%Time = GetLocalTime();
	%H = GetWord(%Time,3);//Сʱ
	%M = GetWord(%Time,4);//����
	%NowTime = %H * 60 + %m;

	%TeammateList = SptCopyMap_GetAllPlayer(%CopyMapID);//��ȡ���������Ϣ
	%TeammateNum = SptCopyMap_GetPlayerCount(%CopyMapID);//��ȡ�����������

	//��ֹ���ֳ�0����������
	if ($SvrCopyMapZiYuanRecord[%CopyMapID, 1] < 1) $SvrCopyMapZiYuanRecord[%CopyMapID, 1] = 1;
	if ($SvrCopyMapZiYuanRecord[%CopyMapID, 2] < 1) $SvrCopyMapZiYuanRecord[%CopyMapID, 2] = 1;
	if ($SvrCopyMapKillNumBer[%CopyMapID, 1] < 1) $SvrCopyMapKillNumBer[%CopyMapID, 1] = 1;
	if ($SvrCopyMapKillNumBer[%CopyMapID, 2] < 1) $SvrCopyMapKillNumBer[%CopyMapID, 2] = 1;

	echo("�������� %TeammateNum===" @ %TeammateNum);
	echo("��ǰʱ��===" @ %NowTime);
	echo("����1��Դ��===" @ $SvrCopyMapZiYuanRecord[%CopyMapID, 1]);
	echo("����2��Դ��===" @ $SvrCopyMapZiYuanRecord[%CopyMapID, 2]);

	echo("����1��ɱ��===" @ $SvrCopyMapKillNumBer[%CopyMapID, 1]);
	echo("����2��ɱ��===" @ $SvrCopyMapKillNumBer[%CopyMapID, 2]);

	for (%i = 0; %i < %TeammateNum; %i++)
	{
		%Player = GetWord(%TeammateList,%i);
		%PlayerID = %Player.GetPlayerID();
		%Force = %Player.GetForce();

		%Exp[0] = 40 * 60/3 * %TeammateNum 
			* ($SvrCopyMapZiYuanRecord[%CopyMapID,%Force] /($SvrCopyMapZiYuanRecord[%CopyMapID,1] + $SvrCopyMapZiYuanRecord[%CopyMapID,2])) 
			* ($PlayerZiYuanRecord[%CopyMapID,%PlayerID] /$SvrCopyMapZiYuanRecord[%CopyMapID,%Force]) 
			* 0.45;
		//80 * 2 * (50/100) * ( 50/50) * 0.45 = 160 *0.5*1*0.45
		%Exp[1] = 40 * 60/3 * %TeammateNum 
			* ($SvrCopyMapKillNumBer[%CopyMapID,%Force] /($SvrCopyMapKillNumBer[%CopyMapID,1]  + $SvrCopyMapKillNumBer[%CopyMapID,2])) 
			* ($PlayerKillNumRecord[%CopyMapID,%PlayerID] / $SvrCopyMapKillNumBer[%CopyMapID,%Force]) 
			*0.55;

		%Exp[2] = (%NowTime - $PlayerTimeRecord[%CopyMapID,%PlayerID]) * 10;
		
		echo("���ս��ʱ�� = = " @ $PlayerTimeRecord[%CopyMapID, %PlayerID] @ "    " @ %Player.getobjectname());
		echo("�����Դ��===" @ $PlayerZiYuanRecord[%CopyMapID, %PlayerID] @ "    " @ %Player.getobjectname());
		echo("��һ�ɱ��===" @ $PlayerKillNumRecord[%CopyMapID, %PlayerID] @ "    " @ %Player.getobjectname());

		%Level = %Player.Getlevel();
		if (%Level < 60) %Exp_level = 1.6;
		else if (%Level < 70) %Exp_level = 2;
		else %Exp_level = 2.2;
		%Exp = (%Exp[0] + %Exp[1] + %Exp[2]) * %Exp_level;
		AllAddExp(%Player,%Exp);

		%Act4094A = GetAct(%Player,4094,0);
		SetAct(%Player,4094,%Act4094A,$PlayerPvpPaiMing[%CopyMapID,%PlayerID]);
		SetStrategyRecord(%Player,$StrategySubBtnSrc[2,5]);//���Դ�����¼
		AddAchievementWatch(%Player,0,45,1);//��¼�ɾ�

		%Player.TransportObject(0,0,GetWord($SvrCopyMapPosRecord[%Force,1],0),GetWord($SvrCopyMapPosRecord[%Force,1],1),GetWord($SvrCopyMapPosRecord[%Force,1],2));
	}

	if ($SvrCopyMapKillNumBer[%CopyMapID,1] > $SvrCopyMapKillNumBer[%CopyMapID,2])
		%text = "���������������쵶��Ӫ���ʤ����������ʿ������뿪ս����";
	else if ($SvrCopyMapKillNumBer[%CopyMapID,1] < $SvrCopyMapKillNumBer[%CopyMapID,2])
		%text = "������������������Ӫ���ʤ����������ʿ������뿪ս����";
	else
		%text = "���������������쵶�񽣲��ಮ�٣���ƽ���ճ���";
	SendAllChatMessageLayer(0,$Get_Dialog_GeShi[31406]  @ %text @ "</t>",%CopyMapID);	//���͸�������Ϣ( ��Ļ���� )
	SendAllScreenMessageLayer(0,%text,%CopyMapID);	//���͸�������Ϣ( ��Ļ�м� )
	RemoveCopyMapOnLeaveTeam(%CopyMapID,8);//�رո���

	//��������ʱ��þ��飺
	//EXP =  ����Դ���� +ɱ�˾��� + �ڸ���ʱ�佱����*�ȼ�����ӳ�
	//��Դ����	40 * 60 /3 * ����������� * �������Ӫ������/��������Դ��������*����������׻���/�����Ӫ����Դ�������� * 0.45
	//ɱ�˾���	40 * 60 /3 * ����������� * �������Ӫɱ����/������ɱ������*���������ɱ����/�����Ӫ��ɱ������ * 0.55
	//����ʱ��	����ڸ�����ʱ������� * 10
	//$PlayerPvpPaiMing[ %CopyMapID, %PlayerID ] = 0;//��������
	//$PlayerMissionRecord[ %CopyMapID, %PlayerID ] = 0;//������ɴ���
	//$PlayerZiYuanRecord[ %CopyMapID, %PlayerID ] = 0;//�ɼ�����
	//$PlayerKillNumRecord[ %CopyMapID, %PlayerID ] = 0;//ɱ������
	//$PlayerTimeRecord[ %CopyMapID, %PlayerID ] = %H * 60 + %M;//����ʱ��

	//$SvrCopyMapZhanDouLi[ %CopyMapID, 1 ] = 0;//2����Ӫ��ս����
	//$SvrCopyMapZhanDouLi[ %CopyMapID, 2 ] = 0;//2����Ӫ��ս����
	//$SvrCopyMapRenShu[ %CopyMapID, 1 ] = 0;//2����Ӫ������
	//$SvrCopyMapRenShu[ %CopyMapID, 2 ] = 0;//2����Ӫ������
	//$SvrCopyMapKillNumBer[ %CopyMapID, 1 ] = 0;//2����Ӫ�Ļ�����
	//$SvrCopyMapKillNumBer[ %CopyMapID, 2 ] = 0;//2����Ӫ�Ļ�����
	//$SvrCopyMapZiYuanRecord[ %CopyMapID, 1 ] = 0;//2����Ӫ����Դ����
	//$SvrCopyMapZiYuanRecord[ %CopyMapID, 2 ] = 0;//2����Ӫ����Դ����
}
//�����������������򡿡����������������㡿��������������

//�����������������򡿡�����������ұ���һ��ܡ���������
function PlayeronDeathCast_1313_1315(%Player,%Killer)
{
	%CopyMapID = %Killer.GetLayerID();
	%KillerID = %Killer.GetPlayerID();
	%Force = %Killer.GetForce();
	$PlayerKillNumRecord[%CopyMapID,%KillerID]++;
	$SvrCopyMapKillNumBer[%CopyMapID,%Force]++;
	//����ʣ��ʱ�� ��Ӫ1���� ��Ӫ2���� �������� ���˻������� ����������
	%Text = $SvrCopyMapLastTime[%CopyMapID] @ " " @ $SvrCopyMapKillNumBer[%CopyMapID,1] @ " " @ $SvrCopyMapKillNumBer[%CopyMapID,2] @ " " @ $PlayerPvpPaiMing[%CopyMapID,%KillerID] @ " " @ $PlayerKillNumRecord[%CopyMapID,%KillerID] @ " " @ $PlayerMissionRecord[%CopyMapID,%KillerID];
	%Killer.SendPlayerString(8,%Text,0);
}
function SvrEventOnDisabled_1313_1315(%Player)
{
	Cancel(%Player.DisabledRecord);//���������ʱ
	%Player.DisabledRecord = Schedule(5000,0,"SvrEventOnDisabled_1313_1315_A",%Player);
}
function SvrEventOnDisabled_1313_1315_A(%Player)
{
	%Force = %Player.GetForce();
	%CopyMapID = %Player.GetLayerID();

	if (%Player.GetDamageState() $= "Disabled")
	{
		%Player.TransportObject(0,0,GetWord($SvrCopyMapPosRecord[%Force,2],0),GetWord($SvrCopyMapPosRecord[%Force,2],1),GetWord($SvrCopyMapPosRecord[%Force,2],2));
		//��������
		%Player.SetDamageState(Enabled);
		//��ӻ�Ѫ״̬
		%Player.AddBuff(399020200, %Player, 100);
		//�����
		%Player.AddBuff(399010001,%Player,1);
	}
}

//�����������������򡿡�����������ұ���һ��ܡ���������


//�����������������򡿡��������������������㡿����������
function RankingCalculationForKill(%CopyMapID)
{
	%TeammateList = SptCopyMap_GetAllPlayer(%CopyMapID);//��ȡ���������Ϣ
	%TeammateNum = SptCopyMap_GetPlayerCount(%CopyMapID);//��ȡ�����������
	for (%i = 0; %i < %TeammateNum; %i++)
	{
		%Player = GetWord(%TeammateList,%i);
		%PlayerID = %Player.GetPlayerID();
		$PlayerPvpPaiMing[%CopyMapID,%PlayerID] = 0;
		%player_px[%i] = $PlayerKillNumRecord[%CopyMapID,%PlayerID];
		%player_id[%i] = %PlayerID;
	}
	%temp = 0;
	%tempid = 0;
	for (%i = 0; %i < %TeammateNum - 1; %i++)
	{
		for (%j = %i + 1; %j < %TeammateNum; %j++)
		{
			if (%player_px[%j] > %player_px[%i])
			{
				%temp = %player_px[%i];
				%player_px[%i] = %player_px[%j];
				%player_px[%j] = %temp;

				%tempid = %player_id[%i];
				%player_id[%i] = %player_id[%j];
				%player_id[%j] = %tempid;
			}
		}
	}
	for (%i = 0; %i < %TeammateNum; %i++)
	{
		$PlayerPvpPaiMing[%CopyMapID,%player_id[%i]] = %i + 1;
	}
}

//function xxxxa( )//ð���������
//{
//	%CopyMapID = 1;
//	%TeammateNum = 10;
//	for ( %i = 0; %i < %TeammateNum; %i++ )
//	{
//		%player_px[ %i ] = GetRandom( 1, 100 );
//		%player_id[ %i ] = 555000000 + %i;
//
//		echo( "���ID ==" @ %player_id[ %i ] @ "    ɱ����===" @ %player_px[ %i ] );
//	}
//	%temp = 0;
//	%tempid = 0;
//	for ( %i = 0; %i < %TeammateNum - 1; %i++ )
//	{
//		for ( %j = %i + 1; %j < %TeammateNum; %j++ )
//		{
//			if ( %player_px[ %j ] > %player_px[ %i ] )
//			{
//				%temp = %player_px[ %i ];
//				%player_px[ %i ] = %player_px[ %j ];
//				%player_px[ %j ] = %temp;
//
//				%tempid = %player_id[ %i ];
//				%player_id[ %i ] = %player_id[ %j ];
//				%player_id[ %j ] = %tempid;
//			}
//		}
//	}
//	for ( %i = 0; %i < %TeammateNum; %i++ )
//	{
//		$PlayerPvpPaiMing[ %CopyMapID, %player_id[ %i ] ] = %i + 1;
//		echo( "���ID ==" @ %player_id[ %i ] @ "    ɱ����===" @ %player_px[ %i ] @ "    ����===" @ $PlayerPvpPaiMing[ %CopyMapID, %player_id[ %i ] ] );
//	}
//}
//$PlayerPvpPaiMing[ %CopyMapID, %PlayerID ]
//�����������������򡿡��������������������㡿����������



//�����������������򡿡����������ɼ����ʡ���������������
function TriggerEvent_552000015(%Player,%Event,%EventID){ TriggerEvent_552000015_552000016(%Player,%Event,%EventID,10); }
function TriggerEvent_552000016(%Player,%Event,%EventID){ TriggerEvent_552000015_552000016(%Player,%Event,%EventID,20); }
function TriggerEvent_552000015_552000016(%Player,%Event,%EventID,%Sorce)
{
	%Force = %Player.GetForce();
	%CopyMapID = %player.GetLayerID();
	%PlayerID = %Player.GetPlayerID();
	%Level = %Player.Getlevel();
	//echo( "$PlayerMissionRecord[ %CopyMapID, %PlayerID ]===" @ $PlayerMissionRecord[ %CopyMapID, %PlayerID ] );
	if ($PlayerMissionRecord[%CopyMapID,%PlayerID] >= 5)
		return true;
	if (%Level < 60) %Exp_level = 1.6;
	else if (%Level < 70) %Exp_level = 2;
	else %Exp_level = 2.2;


	$PlayerMissionRecord[%CopyMapID,%PlayerID]++;
	$SvrCopyMapZiYuanRecord[%CopyMapID,%Force] = $SvrCopyMapZiYuanRecord[%CopyMapID,%Force] + %Sorce;//��Ӫ����Դ����
	$PlayerZiYuanRecord[%CopyMapID,%PlayerID] = $PlayerZiYuanRecord[%CopyMapID,%PlayerID] + %Sorce;//�ɼ�����

	//	EXP = 	��ҵȼ���Ӧ���ﾭ�� * �ɼ���Ʒ�� * �ȼ�����ӳ�
	%Exp = $Monster_Exp[%Level,1] * %Sorce * %Exp_level;
	AllAddExp(%Player,%Exp);
	return false;
}

//�����������������򡿡����������ɼ����ʡ���������������


//�����������������򡿡����������ɼ����䡿��������������
function TriggerEvent_553000044(%Player,%Event,%EventID)
{
	%ItemID[1] = 116070001; %ItemMsg[1] = 3; %itemRan[1] = 200;
	%ItemID[2] = 105100101; %ItemMsg[2] = 3; %itemRan[2] = 500;
	%ItemID[3] = 105100111; %ItemMsg[3] = 3; %itemRan[3] = 500;
	%ItemID[4] = 105100131; %ItemMsg[4] = 2; %itemRan[4] = 3150;
	%ItemID[5] = 105100132; %ItemMsg[5] = 3; %itemRan[5] = 200;
	%ItemID[6] = 116060001; %ItemMsg[6] = 3; %itemRan[6] = 250;
	%ItemID[7] = 116060002; %ItemMsg[7] = 3; %itemRan[7] = 50;
	%ItemID[8] = 105105301; %ItemMsg[8] = 2; %itemRan[8] = 2500;
	%ItemID[9] = 105105302; %ItemMsg[9] = 3; %itemRan[9] = 600;
	%ItemID[10]= 105105303; %ItemMsg[10]= 3; %itemRan[10]= 400;
	%ItemID[11]= 105105304; %ItemMsg[11]= 3; %itemRan[11]= 50;
	%ItemID[12]= 105180070; %ItemMsg[12]= 2; %itemRan[12]= 500;
	%ItemID[13]= 105180071; %ItemMsg[13]= 3; %itemRan[13]= 200;
	%ItemID[14]= 105180072; %ItemMsg[14]= 3; %itemRan[14]= 100;
	%ItemID[15]= 105180090; %ItemMsg[15]= 2; %itemRan[15]= 500;
	%ItemID[16]= 105180091; %ItemMsg[16]= 3; %itemRan[16]= 200;
	%ItemID[17]= 105180092; %ItemMsg[17]= 3; %itemRan[17]= 100;

	%Ran = GetRanDom(1,10000);
	%All = 0;
	for (%i = 1; %i <= 17; %i++)
	{
		%All = %All + %itemRan[%i];
		if (%All >= %Ran)
		{
			%ItemID = %ItemID[%i];
			%Msg = %ItemMsg[%i];
			break;
		}
	}
	if (%ItemID > 0)
	{
		%Player.PutItem(%ItemID,1);
		if (%Player.Additem(4,%EventID))
		{
			if (%Msg > 0)
			{
				%ItemName1 = GetItemName(%ItemID,1);
				%ItemName2 = GetItemName(%ItemID,2);
				%PlayerName1 = GetPlayerZiTiName(%Player,1);
				%PlayerName2 = GetPlayerZiTiName(%Player,2);
				%HuoDongMingCheng1 = GetHuoDongName("���򱦲�",1);
				%HuoDongMingCheng2 = GetHuoDongName("���򱦲�",2);
				%MapName = GetMapName(%Player,2);
				%Path = "<l i='" @ GetSubStr(%Player.Gettriggerid(),0,7) @ "00 " @ %Player.GetPosition() @ "' t='path'/>";
				%Text1 = "<t>��ħڿ��</t>" @ %PlayerName1 @ "<t>��</t>" @ %Path @ "<t>����</t>" @ %HuoDongMingCheng1 @ "<t>���</t>" @ %ItemName1 @ "<t>��ɷ���ˣ�</t>";
				%Text2 = "<t>��ħڿ��</t>" @ %PlayerName2 @ "<t>��</t>" @ %MapName @ "<t>����</t>" @ %HuoDongMingCheng2 @ "<t>���</t>" @ %ItemName2 @ "<t>��ɷ���ˣ�</t>";
				switch (%Msg)
				{
					case 1:
						SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Text1 @ "</t>");
					case 2:
						SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
					case 3:
						SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Text1 @ "</t>");
						SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
				}
			}
		}
	}
	return true;
}
//�����������������򡿡����������ɼ����䡿��������������
//�����������������򡿡���������ˢ�±��䡿��������������
function CreateCJForDianJianShenYu(%CopyMapID)
{
	%MapID = GetZoneID();
	for (%i = 1; %i <= 10;%i++)
	{
		%Ran =GetRanDom(1,$strMapRanPosRecordMax[%MapID]);
		%Pos = $strMapRanPosRecord[%MapID,%Ran];
		SpNewCj2(0,553000044,%Pos,%CopyMapID,GetRanDom(0,180),"3 3 3");
	}
	%Name = $Get_Dialog_GeShi[31422] @ "�����򱦲ء�</t>";
	%Path1 = "<l i='813050100 1.40627 8.43745 107.634' t='path'/>";
	%Text = %Name @ "<t>������</t>" @ %Path1 @ "<t>��</t>";
	SendAllChatMessageLayer(0,$Get_Dialog_GeShi[31406]  @ %text @ "</t>",%CopyMapID);	//���͸�������Ϣ( ��Ļ���� )
}

//�����������������򡿡���������ˢ�±��䡿��������������