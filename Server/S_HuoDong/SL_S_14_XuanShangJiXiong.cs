//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//���ͼ���
// �ͻ��˴򿪽������� OpenOrCloseXuanShangJiXiongWnd( )
//==================================================================================
//�������������ͼ��ס������������������������������������
//�������������ͼ��ס������������������Ʒ�ʡ�������������
//�������������ͼ��ס���������������ˢ�����񡿡�����������
//�������������ͼ��ס�����������������ɽ�����������������


//�������������ͼ��ס������������������������������������
function GetTodayXuanShangMission(%Player)
{
	%MapID = GetZoneID();
	//%MapID = 1103;
	if ($XuanShangJiXiong[%MapID,0] $= "")
		return;
	if ($XuanShangJiXiongMissionMaxNumber[%MapID] == 0)
		return;
	if ($SL_XuanShangJiXiong_State_bActive != 1)
		return;
	%MidList = "";
	for (%i = 4025; %i <= 4029; %i++)
	{
		%Mid = GetAct(%Player,%i,0)%100;//�Ѿ���¼������������%100
		%MidList = %Mid @ " " @ %MidList;
	}
	for (%i = 0; %i<=9; %i++)
	{
		%ActID = $XuanShangJiXiong[%MapID,%i];
		%Mid = GetAct(%Player,%ActID,0)%100;//�Ѿ�ˢ������������%100
		if (%Mid > 0)
			%MidList = %Mid @ " " @ %MidList;
	}

	//echo( "��Ҫ�ų�����%MidList====" @ %MidList );
	for (%i = 0; %i<=9; %i++)
	{
		%ActID = $XuanShangJiXiong[%MapID,%i];
		if (GetAct(%Player,%ActID,0) * 1<= 0)//��Ҫ���һ������
		{
			%RanNumber = GetRandomNum2(1,1,$XuanShangJiXiongMissionMaxNumber[%MapID],%MidList);
			%MidList = %RanNumber @ " " @ %MidList;
			%GetRanMid = (%MapID%100)*100 + %RanNumber;
			%Color = GetXuanShangJiXiongMissionColor(%Player,%GetRanMid,1);
			//echo( "����" @ %i @ "     " @ %GetRanMid @ "   " @ %Color );
			SetAct(%Player,%ActID,%GetRanMid,%Color);
		}
	}
}
//�������������ͼ��ס������������������������������������

//�������������ͼ��ס������������������Ʒ�ʡ�������������
function GetXuanShangJiXiongMissionColor(%Player,%Mid,%optype)//%optype 1�Զ���� 2���ˢ�� 3�շ�ˢ��
{
	%ZhanLi = %Player.ZhanLi;
	%NeedZhanLi = 3500;
	if (%ZhanLi <  %NeedZhanLi) %SubType = 1;
	else
	{
		switch (%optype)
		{
			case 1:%SubType = 1;
			case 2:%SubType = 2;
			case 3:%SubType = 3;
		}
	}
	switch (%SubType)
	{
		case 1:%RanDom[1] = 9357; %RanDom[2] = 9857; %RanDom[3] = 9957; %RanDom[4] = 9977; %RanDom[5] = 9990; %RanDom[6] = 10000;
		case 2:%RanDom[1] = 9274; %RanDom[2] = 9774; %RanDom[3] = 9941; %RanDom[4] = 9970; %RanDom[5] = 9987; %RanDom[6] = 10000;
		case 3:%RanDom[1] = 8582; %RanDom[2] = 9582; %RanDom[3] = 9915; %RanDom[4] = 9955; %RanDom[5] = 9980; %RanDom[6] = 10000;
	}

	%Ran = GetRandom(1,10000);
	//echo( "%Ran===" @ %Ran @  "    %SubType==" @ %SubType );
	for (%i = 1; %i <=6; %i++)
	{
		if (%Ran <= %RanDom[%i])
		{
			%Color = %i;
			break;
		}
	}
	if (%Color < 1)
		%Color = 1;
	return %Color;
}
//�������������ͼ��ס������������������Ʒ�ʡ�������������

//�������������ͼ��ס���������������ˢ�����񡿡�����������
function GetNewXuanShangMission(%Player,%optype)
{
	%MapID = GetZoneID();
	if ($XuanShangJiXiong[%MapID,0] $= "")
		return;
	if ($XuanShangJiXiongMissionMaxNumber[%MapID] == 0)
		return;
	if ($SL_XuanShangJiXiong_State_bActive != 1)
		return;
	%MidList = "";
	for (%i = 4025; %i <= 4029; %i++)
	{
		%Mid = GetAct(%Player,%i,0)%100;//�Ѿ���¼������������%100
		%MidList = %Mid @ " " @ %MidList;
	}
	//echo( "��Ҫ�ų�����%MidList====" @ %MidList );
	for (%i = 0; %i<=9; %i++)
	{
		%ActID = $XuanShangJiXiong[%MapID,%i];
		%RanNumber = GetRandomNum2(1,1,$XuanShangJiXiongMissionMaxNumber[%MapID],%MidList);
		%MidList = %RanNumber @ " " @ %MidList;
		%GetRanMid = (%MapID%100)*100 + %RanNumber;
		%Color = GetXuanShangJiXiongMissionColor(%Player,%GetRanMid,%optype);
		//echo( "����" @ %i @ "     " @ %GetRanMid @ "   " @ %Color );
		SetAct(%Player,%ActID,%GetRanMid,%Color);
	}
	SendOneScreenMessage(1,"ˢ�³ɹ�",%Player);
	SendOneChatMessage($chatMsg_System,"<t>��������ˢ�³ɹ�</t>",%Player);
}
//���ÿ�����ˢ�´���
function GetXuanShangMissionFreeFreshMaxCnt(%Player)
{
	VIP_getNowTequanLvMaxCnt(%Player, 6);
}
//�������������ͼ��ס���������������ˢ�����񡿡�����������

//�������������ͼ��ס����������������ȡ���񡿡�����������
function XuanShangJiXiongGetMissionToPlayer(%Player,%SubType)
{
	if (%Player.IsSchbuff(2015))
	{
		SendOneScreenMessage(1,"�޷���ȡ����",%Player);
		SendOneChatMessage($chatMsg_System,"<t>�����з����������Ϊ����ʱ�޷���ȡ���ͼ�������</t>",%Player);
		return;
	}
	for (%i = 4025; %i <= 4029; %i++)
	{
		%Mid = GetAct(%Player,%i,0)%100;//�Ѿ���¼������������%100
		if (%Mid == 0)
		{
			%Act = %i;
			break;
		}
	}
	//echo( "%Act ===="  @ %Act );
	if (%Act > 0)
	{
		%MapID = GetZoneID();
		%MissPosAct = $XuanShangJiXiong[%MapID,%SubType];
		if (%MissPosAct $= "")
			return;
		%RecordNumber =  GetAct(%Player,%MissPosAct,0) * 1;
		%Mid = 29000 + %RecordNumber;
		%Color = GetAct(%Player,%MissPosAct,1) * 1;
		if (GetMissionData(%Mid,0) <= 0)
			return;
		if (%Player.IsAcceptedMission(%Mid))
			return;
		if (GetMissionData(%Mid,$Mission_Data_LvA) > %Player.GetLevel())
		{
			SendOneScreenMessage(1,GetMissionData(%Mid,$Mission_Data_LvA) @ "�����ϲſ��Խ�ȡ������",%Player);
			SendOneChatMessage($chatMsg_System,"<t>" @ GetMissionData(%Mid,$Mission_Data_LvA) @ "�����ϲſ��Խ�ȡ������" @ "</t>",%Player);
			return;
		}
		AddMissionAccepted(%Player,0,%Mid);
		SetAct(%Player,%Act,%RecordNumber,%Color);
		SetAct(%Player,%MissPosAct,0,0);
		GetTodayXuanShangMission(%Player);
		ServerOnSptAction(%Player.GetPlayerID(),0,15);//ͨѶ�ͻ���
	}
	else
	{
		SendOneScreenMessage(1,"���ͬʱ��ȡ5����������",%Player);
		SendOneChatMessage($chatMsg_System,"<t>���ͬʱ��ȡ5����������</t>",%Player);
		return;
	}
}
//�������������ͼ��ס����������������ȡ���񡿡�����������

//�������������ͼ��ס�����������������ɽ�����������������
function MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid)//���ͼ���������ɴ���
{
	for (%i = 4025; %i <= 4029; %i++)
	{
		%MidID = GetAct(%Player,%i,0) + 29000;
		if (%MidID == %Mid)
		{
			%CoLor =  GetAct(%Player,%i,1);//Ʒ����ɫ
			%Act = %i;//��¼���
			break;
		}
	}
	//���ּ�¼
	if (%Act > 0)
	{
		%Act4092A = GetAct(%Player,4092,0);
		%Act4092B = GetAct(%Player,4092,1);
		%Act4092A++;
		if (%CoLor > %Act4092B)
			%Act4092B = %CoLor;
		SetAct(%Player,4092,%Act4092A,%Act4092B);
		SetAct(%Player,%Act,0,0);
	}
	//���齱��
	%MissionData_Exp = GetMissionData(%Mid,$Mission_Data_OtherRecordA);
	//echo( "MissionData_Exp===" @ %MissionData_Exp );
	switch (%CoLor)
	{
		case 1:%ExpBeiShu = 1;
		case 2:%ExpBeiShu = 1.3;
		case 3:%ExpBeiShu = 1.8;
		case 4:%ExpBeiShu = 2.8;
		case 5:%ExpBeiShu = 4;
		case 6:%ExpBeiShu = 5;
	}
	%Exp = %MissionData_Exp * %ExpBeiShu;

	//echo( "ExpBeiShu===" @ %ExpBeiShu );
	//echo( "Exp===" @ %Exp );

	if (%Exp > 0)
		AllAddExp(%Player,%Exp);
	//���߽���
	if (%CoLor >= 2)
	{
		switch (%CoLor)
		{
			case 2:%Ran = 5;
			case 3:%Ran = 10;
			case 4:%Ran = 50;
			case 5:%Ran = 100;
			case 6:%Ran = 100;
		}
		%RanDom = GetRanDom(1,100);
		if (%RanDom <= %Ran)
		{
			%MapID = GetZoneID();
			%NeedRan = GetRanDom(1,10000);
			%AllRan = 0;
			for (%i = 1; %i <=99; %i++)
			{
				//echo( "$XuanShangJiXiongItem[ " @ %MapID @ "," @ %CoLor @ "," @  %i @ " ]====" @ $XuanShangJiXiongItem[ %MapID, %CoLor, %i ] );
				if ($XuanShangJiXiongItem[%MapID,%CoLor,%i] $= "")
					break;
				%ItemRan = GetWord($XuanShangJiXiongItem[%MapID,%CoLor,%i],1);
				%AllRan = %AllRan + %ItemRan;
				if (%AllRan >= %NeedRan)
				{
					%ItemID = GetWord($XuanShangJiXiongItem[%MapID,%CoLor,%i],0);
					%ItemNum = GetWord($XuanShangJiXiongItem[%MapID,%CoLor,%i],2);
					break;
				}
			}
			if (%ItemID > 0 && %ItemNum > 0)
			{
				%Player.PutItem(%ItemID,%ItemNum);
				%Player.AddItem(1,4025);
			}
		}
	}
	AddAchievementWatch(%Player,0,32,1);//��¼�ɾ�
}
//�������������ͼ��ס�����������������ɽ�����������������