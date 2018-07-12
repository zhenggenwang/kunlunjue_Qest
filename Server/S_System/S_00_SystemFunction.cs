function UPCS_Systemfunction(%Num)
{
	if ((%Num == 0)||(%Num == 99)){ Exec("./S_01_NewCheckCode.cs"); }
	if ((%Num == 1)||(%Num == 99)){ Exec("./S_02_ActivityRecord.cs"); }
	if ((%Num == 2)||(%Num == 99)){ Exec("./S_03_DuoBeiExp.cs"); }
}
UPCS_Systemfunction(99);

//����������������������Ծ������¼������������������
//����������������ȡ�����ͼһ��������꡿����������
//�������������������Ľ���������������������������
//��������������֪ͨȫ������һЩ���顿��������������
//����������������������������л�������������������

//����������������������Ծ������¼������������������
function DelServerRenShuTongJi(%YY,%MM,%DD,%H,%M,%S)//��������Ծ�������
{
	if (!(%H == 23 && %M == 59))
		return;
	%MapID = GetZoneID();
	if (%MapID != 1001)
		return;
	%LineID = GetCurrentLineId();//�߳�ID
	%LocalWeek = GetLocalWeek();
	%LocalWeek++;
	if (%LocalWeek > 6)
		%LocalWeek = 0;
	%ShiJianID = (%LocalWeek + 1)* 100 + %LineID;
	SetServerSystemEvent(%ShiJianID,0,0);
}
function GetRenShuTongJiForEveryday(%Days)//����ȡ���������Ļ�Ծ���������һ���ǽ��� %Days����������Ҫȡ�����
{
	if (%Days > 7)
		%Days = 7;
	%LineID = GetCurrentLineId();//�߳�ID
	%LocalWeek = GetLocalWeek();
	%List = "";
	for (%i = 0; %i <= %Days - 1; %i++)
	{
		%NeedWeek = %LocalWeek - %i;
		if (%NeedWeek < 0)
			%NeedWeek = %NeedWeek + 7;
		%ShiJianID = (%NeedWeek + 1)* 100 + %LineID;
		%Number = GetWord(GetServerSystemEvent(%ShiJianID),0) * 1;
		//echo( "%NeedWeek===" @ %NeedWeek @ "     %ShiJianID===" @ %ShiJianID );
		%List = %Number @ " " @ %List;
	}
}
function GetRenShuTongJiFor7Day(%Days)//%Days == 6 ��ȡǰ6��Ļ�Ծ�û����� %Days == 7 ��ȡ���7�죨�������죩�Ļ�Ծ�û�����
{
	%LineID = GetCurrentLineId();//�߳�ID
	%AllNum = 0;
	for (%i=0; %i<=6; %i++)
	{
		%ShiJianID = (%i + 1)* 100 + %LineID;
		%Number = GetWord(GetServerSystemEvent(%ShiJianID),0);
		%AllNum = %AllNum + %Number;
	}
	if (%Days == 6)
	{
		%TodayNum = GetRenShuTongJiFortoday();
		%AllNum = %AllNum - %TodayNum;
	}
	return %AllNum;
}
function GetRenShuTongJiFor3Day()//��ȡǰ3��Ļ�Ծ�û�����
{
	%LineID = GetCurrentLineId();//�߳�ID
	%LocalWeek = GetLocalWeek();
	%AllNum = 0;
	%NeedWeek[1]= %LocalWeek - 1; %NeedWeek[2]= %LocalWeek - 2; %NeedWeek[3]= %LocalWeek - 3;
	for (%i = 1; %i<= 3; %i++)
	{
		%NeedWeek = %NeedWeek[%i];
		if (%NeedWeek < 0)
			%NeedWeek  = %NeedWeek + 7;
		%ShiJianID = (%NeedWeek + 1)*100 + %LineID;
		%Number = GetWord(GetServerSystemEvent(%ShiJianID),0);
		%AllNum = %AllNum + %Number;
	}
	return %AllNum;
}
function GetRenShuTongJiForYesterday()//��ȡ����Ļ�Ծ�û�����
{
	%LineID = GetCurrentLineId();//�߳�ID
	%LocalWeek = GetLocalWeek();
	%NeedWeek = %LocalWeek - 1;
	if (%LocalWeek < 0)
		%LocalWeek = %LocalWeek + 7;
	%ShiJianID = (%NeedWeek + 1)*100 + %LineID;
	%Number = GetWord(GetServerSystemEvent(%ShiJianID),0);
	return %Number;
}
function GetRenShuTongJiFortoday()//��ȡ����Ļ�Ծ�û�����
{
	%LineID = GetCurrentLineId();//�߳�ID
	%LocalWeek = GetLocalWeek();
	%ShiJianID = (%LocalWeek + 1)*100 + %LineID;
	%Number = GetWord(GetServerSystemEvent(%ShiJianID),0);
	return %Number;
}
function SendRenShuTongJito1001(%Player)//֪ͨ1001ˢ�µ�ǰ����
{
	%Functionname = "SetFuWuQiRenShuTongJi( );";
	SptInterMapExecute(1001,%Functionname);
}
function SetFuWuQiRenShuTongJi()//������ͳ������+1
{
	%LineID = GetCurrentLineId();//�߳�ID
	%LocalWeek = GetLocalWeek();
	%ShiJianID = (%LocalWeek + 1)*100 + %LineID;
	%Number0 = GetWord(GetServerSystemEvent(%ShiJianID),0);
	%Number1 = GetWord(GetServerSystemEvent(%ShiJianID),1);
	%Number0++;
	SetServerSystemEvent(%ShiJianID,%Number0,%Number1);
}
//����������������������Ծ������¼������������������


//����������������ȡ�����ͼһ��������꡿����������
function GetRandomPosForMap(%MapID)
{
	switch (%MapID)
	{
		case 0://�ر�ͼר��
			%MapList = "1101 1001 1102";
			%Count = GetWordCount(%MapList);
			%Ran = GetRanDom(0,%Count -1);
			%MapID = GetWord(%MapList,%Ran);
			return  GetRandomPosForMap(%MapID);
		case 1://�������ר��
			%MapID = GetZoneID();
			%PosID = getrandom(1,$strMapRanPosRecordMax[%MapID]);
			%RealPos = $strMapRanPosRecord[%MapID,%PosID];
			return %RealPos;
		default:
			%PosID = getrandom(1,$strMapRanPosRecordMax[%MapID]);
			%RealPos = $strMapRanPosRecord[%MapID,%PosID];
			return %MapID @ " " @ %PosID @ " " @ %RealPos;
	}
}
//����������������ȡ�����ͼһ��������꡿����������


//�������������������Ľ���������������������������
function ChangeLogicFloor(%Player,%Now,%Next)//���� ��%now�� ��%next��
{
	%Player.AddLogicFloor(%Next);//���õ�����
	%Player.delLogicFloor(%Now);
	%Player.LogicFloorRecord = %Next;
}
//�������������������Ľ���������������������������

//��������������֪ͨȫ������һЩ���顿��������������
function TeHuiTeXiaoShuaXin(%YY,%MM,%DD,%H,%M,%S)//0 6 12 18��ʱˢ���ػݰ�ť����Ч
{
	//echo( "%H ==" @ %H  @ "    %M===" @ %M );
	if (%H == 0 || %H == 6 || %H == 12 || %H == 18)
	{
		if (%M == 1)
		{
			%PlayerCount = GetPlayerCount();
			//echo( "%PlayerCount==="  @ %PlayerCount );
			for (%i = 0; %i < %PlayerCount; %i++)
			{
				%Player = GetPlayerByIndex(%i);
				//echo( "%Player==="  @ %Player );
				if (isobject(%Player))
				{
					%Act0 = GetAct(%Player,4000,0);
					if (%Act0 $= "" || %Act0 == 0)
						HelpDirectByIndex(%Player.GetPlayerID(),21);	//ͨѶ�ͻ���
				}
			}
		}
	}
}
//��������������֪ͨȫ������һЩ���顿��������������


//����������������������������л�������������������
function InfluenceDispose(%Player)
{
	//%obj.setInfluence(%influence);//��������
	//%Obj.GetInfluence();//	��ȡ����
	%MapID = GetZoneID();
	%PkValue = %Player.GetPkValue();

	%PlayerID = %Player.GetPlayerID();
	%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//��ȡ�سǷ�
	%orgID = SptOrg_GetOrgID(%PlayerID);
	if (%OrgIDA == %orgID)
		%IsFengMoCheng = 1;//�Ƿ��Ƿ�ħ��ռ�칫���Ա
	else
		%IsFengMoCheng = 0;//�Ƿ��Ƿ�ħ��ռ�칫���Ա

	if (%MapID >= 1300)
		%Influence = 0;
	else if (%MapID == 1119 && $IsAttackCityWar_State_bActive == 1)//����ս
	{
		if (%IsFengMoCheng == 1)
			%Influence = 8;//�س�����
		else
		{
			%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//��ý��칥�Ƿ�
			if (%OrgIDB == %orgID)
				%Influence = 7;//��������
			else
				%Influence = 0;//��������
		}
	}
	else
	{
		switch (%IsFengMoCheng)
		{
			case 1:	%Influence = 2;//��ħ��
			default:%Influence = 0;//Ĭ������
		}
	}

	if (%PkValue >= 1) //�������
	{
		switch (%IsFengMoCheng)
		{
			case 1:	%Influence = 4;//��ħ��
			default:%Influence = 3;//Ĭ������
		}
	}

	%Player.SetInfluence(%influence);//��������
}
/*
��ʱû��	0
���Ĭ������	1
��ħ��	2
�������	3
��ħ�Ǻ������	4
����	5
��ħ������	6
��������	7
�س�����	8
����1	9
����2	10
����3	11
����4	12
����5	13
NPC	14
��	15
����	16
����	17
����	18
Ұ��	19
����	20
����	21
����	22
��ۡ	23
����	24
ս��1	25
ս��2	26
*/



$LaJi[0]="��ʱû��";
$LaJi[1]="���Ĭ������";
$LaJi[2]="��ħ��";
$LaJi[3]="�������";
$LaJi[4]="��ħ�Ǻ������";
$LaJi[5]="����";
$LaJi[6]="��ħ������";
$LaJi[7]="��������";
$LaJi[8]="�س�����";
$LaJi[9]="����1";
$LaJi[10]="����2";
$LaJi[11]="����3";
$LaJi[12]="����4";
$LaJi[13]="����5";
$LaJi[14]="NPC";
$LaJi[15]="��";
$LaJi[16]="����";
$LaJi[17]="����";
$LaJi[18]="����";
$LaJi[19]="Ұ��";
$LaJi[20]="����";
$LaJi[21]="����";
$LaJi[22]="����";
$LaJi[23]="��ۡ";
$LaJi[24]="����";
$LaJi[25]="ս��1";
$LaJi[26]="ս��2";


function asdsadd()
{
	for (%i = 0;%i <= 26;%i++)
	{
		for (%j = 0;%j<=26;%j++)
		{
			echo($LaJi[%i] @ "  " @ $LaJi[%j]);
		}
	}
}

//����������������������������л�������������������