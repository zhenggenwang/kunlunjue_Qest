//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//Ѻ��
//==================================================================================
//����������Ѻ�ڡ�����������ȫ�ֱ���������������������
//����������Ѻ�ڡ���������������桿����������������
//����������Ѻ�ڡ�����������NPC�Ի� ������������������
//����������Ѻ�ڡ�����������������񴥷���������������
//����������Ѻ�ڡ������������뿪��ǰ��ͼ��������������
//����������Ѻ�ڡ�������������ұ���һ��ܡ�����������
//����������Ѻ�ڡ������������ڳ�ˢ�¡�����������������
//����������Ѻ�ڡ������������ڳ����䡿����������������


//����������Ѻ�ڡ�����������ȫ�ֱ���������������������
//411190001	��ʦ
//411190002	����ͷ
//411190003	��ɫ�ڳ�
//411190004	��ɫ�ڳ�
//411190005	��ɫ�ڳ�
//411190006	��ɫ�ڳ�
//411190007	��ɫ�ڳ�
//----�ڳ�ˢ����Ϣ-----------�ڳ�ID--------ˢ������---------����--��С--CD--------
$BiaoChe_Information[1] = "411190007;126.652 -156.479 119.981;180;1 1 1;720;";//��ɫ�ڳ�λ 
$BiaoChe_Information[2] = "411190006;118.652 -156.479 119.981;180;1 1 1;30;";//��ɫ�ڳ�λ
$BiaoChe_Information[3] = "411190006;114.652 -156.479 119.981;180;1 1 1;30;";//��ɫ�ڳ�λ
$BiaoChe_Information[4] = "411190005;115.884 -189.022 119.981;270;1 1 1;15;";//��ɫ�ڳ�λ
$BiaoChe_Information[5] = "411190005;115.884 -184.911 119.981;270;1 1 1;15;";//��ɫ�ڳ�λ
$BiaoChe_Information[6] = "411190005;115.884 -180.911 119.981;270;1 1 1;15;";//��ɫ�ڳ�λ
$BiaoChe_Information[7] = "411190004;101.842 -188.735 119.981;90;1 1 1;8;";//��ɫ�ڳ�λ
$BiaoChe_Information[8] = "411190004;101.893 -184.625 119.981;90;1 1 1;8;";//��ɫ�ڳ�λ
$BiaoChe_Information[9] = "411190004;101.893 -180.625 119.981;90;1 1 1;8;";//��ɫ�ڳ�λ
$BiaoChe_Information[10] ="411190003;108.652 -156.479 119.981;180;1 1 1;5;";//��ɫ�ڳ�λ
$BiaoChe_Information[11] ="411190003;104.652 -156.479 119.981;180;1 1 1;5;";//��ɫ�ڳ�λ
$BiaoChe_Information[12] ="411190003;100.652 -156.479 119.981;180;1 1 1;5;";//��ɫ�ڳ�λ
$BiaoChe_Information[13] ="411190003;96.6520 -156.479 119.981;180;1 1 1;5;";//��ɫ�ڳ�λ

$YaBiaoHuoDong_DiaLogID[411190001,0] ="";//��ʦ
$YaBiaoHuoDong_DiaLogID[411190002,0] ="";//����ͷ
$YaBiaoHuoDong_DiaLogID[411190003,0] ="600000041 600000042 600000043";//��ɫ�ڳ�
$YaBiaoHuoDong_DiaLogID[411190004,0] ="600000044 600000045 600000046";//��ɫ�ڳ�
$YaBiaoHuoDong_DiaLogID[411190005,0] ="600000047 600000048 600000049";//��ɫ�ڳ�
$YaBiaoHuoDong_DiaLogID[411190006,0] ="600000050 600000051 600000052";//��ɫ�ڳ�
$YaBiaoHuoDong_DiaLogID[411190007,0] ="600000053 600000054 600000055";//��ɫ�ڳ�

//����������Ѻ�ڡ�����������ȫ�ֱ���������������������

//����������Ѻ�ڡ���������������桿����������������
function YaBiaoHuoDong_Information(%YY,%MM,%DD,%H,%M,%S)
{
	if (GetZoneid() != 1119)
		return;
	if ($SL_YaBiao_bActive != 1)
		return;
	%Nowtime = %H * 60 + %M;
	%Starttime = getword($SL_YaBiao_StartTime,0,":") * 60 + getword($SL_YaBiao_StartTime,1,":");
	%Endtime = getword($SL_YaBiao_EndTime,0,":") * 60 + getword($SL_YaBiao_EndTime,1,":");
	//%Path = GetTraceButton( "findpath(410010302);", GetNpcData( 410010302, 1 ) );//NPCѰ��
	%Path = "<l i='811190100 108.789 -187.785 120' t='path'/>";

	%HuoDongMingCheng =  GetHuoDongName("Ѻ�ڻ",1);

	%Text = "";
	%Text2 = "";
	if (%Starttime -  %Nowtime  == 10)
	{
		%Text = %HuoDongMingCheng @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ "10</t><t>���Ӻ�����" @ $SL_YaBiao_Level @ "��������ʿ��ǰ��</t>" @ %Path @ "<t>�鿴����顣</t>";
		%Text2 = GetHuoDongName("Ѻ�ڻ",2) @ "<t>����</t>" @ $Get_Dialog_GeShi[60002]  @ "10</t><t>���Ӻ���</t>";
	}
	if (%Starttime -  %Nowtime  == 5)
	{
		%Text = %HuoDongMingCheng @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ "5</t><t>���Ӻ�����" @ $SL_YaBiao_Level @ "��������ʿ��ǰ��</t>" @ %Path @ "<t>�鿴����顣</t>";
		%Text2 = GetHuoDongName("Ѻ�ڻ",2) @ "<t>����</t>" @ $Get_Dialog_GeShi[60002]  @ "5</t><t>���Ӻ���</t>";
	}
	if (%Starttime -  %Nowtime  == 0)
	{

		%Text = %HuoDongMingCheng @ "<t>�Ѿ�������" @ $SL_YaBiao_Level @ "��������ʿ��ǰ��</t>" @ %Path @ "<t>�鿴����顣</t>";
		%Text2 = GetHuoDongName("Ѻ�ڻ",2) @ "<t>�Ѿ�����</t>";
	}
	if (%Endtime - %Nowtime == 10)
	{
		%Text = %HuoDongMingCheng @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ "10</t><t>���ӽ�������ʿ��ץ��ʱ��Ŷ��</t>";
		%Text2 = GetHuoDongName("Ѻ�ڻ",2) @ "<t>����</t>" @ $Get_Dialog_GeShi[60002]  @ "10</t><t>���ӽ���</t>";
	}

	if (%Text !$= "")
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");
	if (%Text2 !$= "")
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);

	YaBiaoHuoDong_BiaoCheShuaXin(%YY,%MM,%DD,%H,%M,%S);
}
//����������Ѻ�ڡ���������������桿����������������


//����������Ѻ�ڡ�����������NPC�Ի� ������������������
function YaBiaoHuoDong_DiaLog(%Npc,%Player,%State,%Conv)
{
	if ($SL_YaBiao_bActive != 1)
	{
		%Conv.SetText(600000039);
		return;
	}
	%NpcID = %Npc.GetDataID();
	%Conv.SetText(600000040);
	if ($SL_YaBiao_State_bActive == 1 && $IsAttackCityWar_State_bActive != 1)
	{
		if ($YaBiaoHuoDong_DiaLogID[%NpcID,%State] !$= "")
		{
			%Count = GetWordCount($YaBiaoHuoDong_DiaLogID[%NpcID,%State]);
			for (%i = 0; %i < %Count; %i++)
			{
				%DiaLogID = GetWord($YaBiaoHuoDong_DiaLogID[%NpcID,%State],%i);
				%Conv.AddOption(%DiaLogID,%DiaLogID);
			}
		}
	}
	if ($YaBiaoHuoDong_Gold[%State] !$= "")
	{
		if (%Player.GetLevel() < $SL_YaBiao_Level)
		{
			SendOneScreenMessage(2,$SL_YaBiao_Level @ "�����ϲſ��Խ�ȡѺ������",%Player);
			SendOneChatMessage($chatMsg_System,"<t>" @ $SL_YaBiao_Level @ "�����ϲſ��Խ�ȡѺ������" @ "</t>",%Player);
			return YaBiaoHuoDong_DiaLog(%Npc,%Player,0,%Conv);
		}
		if (%Player.GetLevel() < $SL_YaBiao_Level)
		{
			SendOneScreenMessage(2, $SL_YaBiao_Level @ "�����ϲſ��Խ�ȡѺ������", %Player);
			SendOneChatMessage($chatMsg_System, "<t>" @ $SL_YaBiao_Level @ "�����ϲſ��Խ�ȡѺ������" @ "</t>", %Player);
			return YaBiaoHuoDong_DiaLog(%Npc, %Player, 0, %Conv);
		}
		%Time = GetLocalTime();
		%H = GetWord(%Time, 3);	//ʱ
		%M = GetWord(%Time, 4);	//��
		if (%H == 19 && %M >= 30)
		{
			%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//��ý��칥�Ƿ�
			if (%OrgIDB > 0)
			{
				SendOneScreenMessage(2, "����ս׼���׶Σ��޷�����", %Player);
				SendOneChatMessage($chatMsg_System, "<t>���ڽ����й���ս����ǰ����׼���׶Σ��޷���ȡѺ�������������ڹ���ս����������Ѻ�ڡ�</t>", %Player);
				return YaBiaoHuoDong_DiaLog(%Npc, %Player, 0, %Conv);
			}
		}
		if (%Player.IsAcceptedMission(20147))
		{
			SendOneScreenMessage(2,"���Ѿ�����һ������",%Player);
			SendOneChatMessage($chatMsg_System,"<t>���Ѿ�����һ������</t>",%Player);
			return YaBiaoHuoDong_DiaLog(%Npc,%Player,0,%Conv);
		}
		else
		{
			if (%Act4018A = GetAct(%Player,4018,0) < VIP_getNowTequanLvMaxCnt(%Player, 7))
			{
				if (%Player.getmoney(2) >= GetWord($YaBiaoHuoDong_Gold[%State],2))
				{
					%Player.YaBiaoRecord = %State - 600000000;
					%Player.YaBiaoBiaoChe = %Npc;
					%Player.YaBiaoPosRecord = %player.getposition();
					ServerOnSptAction(%Player.GetPlayerID(),%Player.YaBiaoRecord,7);//ͨѶ�ͻ��� ����Ѻ�ڵ�ȷ�Ͽ�
					%Conv.Settype(4);
				}
				else
				{
					SendOneScreenMessage(2,"���Ľ�Ҳ���",%Player);
					return YaBiaoHuoDong_DiaLog(%Npc,%Player,0,%Conv);
				}
			}
			else
			{
				SendOneScreenMessage(2,"����Ѻ�ڴ����Ѿ����꣬������������",%Player);
				return YaBiaoHuoDong_DiaLog(%Npc,%Player,0,%Conv);
			}
		}
	}

}
function YaBiaoHuoDong_QueReng(%Player,%Optype)
{
	//echo( "Ѻ������%Optype===" @ %Optype );
	%RecordPos = %Player.YaBiaoPosRecord;
	%NowPos = %player.getposition();
	%Posxa = getword(%RecordPos,0);
	%Posya = getword(%RecordPos,1);
	%Posxb = getword(%NowPos,0);
	%Posyb = getword(%NowPos,1);
	if (msqrt(mpow(%Posxa - %Posxb,2) + mpow(%Posya - %Posyb,2)) >= 10)
	{
		SendOneScreenMessage(2,"�ڳ������ڻ����̫Զ����ȡʧ��",%Player);
		return;
	}
	%State = "6000000" @ %Optype;
	%Money = GetWord($YaBiaoHuoDong_Gold[%State],2);
	if (%Player.getmoney(2) >= %Money && isobject(%Player.YaBiaoBiaoChe))
	{
		%Player.Reducemoney(%Money,2,1,4018);
		%i = %Player.YaBiaoBiaoChe.NumberRecord;
		$YaBiaoHuoDong_TimeRecord[%i] =  GetWord(GetLocalTime(),3) @ ":" @ GetWord(GetLocalTime(),4);//��¼����ʱ��

		%Player.YaBiaoBiaoChe.SafeDeleteobject();//ɾ���ڳ�

		%NpcID = Getword($BiaoChe_Information[%i],0,";") + 5;
		%Pos = Getword($BiaoChe_Information[%i],1,";");
		%Rot = Getword($BiaoChe_Information[%i],2,";");
		%Scale = Getword($BiaoChe_Information[%i],3,";");
		%Obj  = SpNewNpc3(0,%NpcID,%Pos,0,%Rot,%Scale);
		%Obj.SetInteractionEnabled(0);	//���ò��ɽ���
		%Obj.SetMaster(%Player);
		%Player.BiaoCheSuiCong = %Obj;

		AddMissionAccepted(%Player,0,20147);
		%Act4018A = GetAct(%Player,4018,0);
		%Act4018B = GetAct(%Player,4018,1);
		%BiaoChePinZhi = GetWord($YaBiaoHuoDong_Gold[%State],0);
		%BiaoCheDangCi = GetWord($YaBiaoHuoDong_Gold[%State],1);
		%Act4018A++;
		%Act4018B = %BiaoChePinZhi * 100 + %BiaoCheDangCi * 10 + 1;
		SetAct(%Player,4018,%Act4018A,%Act4018B);

		if (%NpcID ==  411190012)//��ɫ�ڳ�
		{
			%PlayerName = GetPlayerZiTiName(%Player,1);
			%HuoDongMingCheng = GetHuoDongName("��ɫ�ڳ�",1);

			%Text = %PlayerName @ "<t>����</t>" @ %HuoDongMingCheng @ "<t>�����ˣ����ף�����˰ɡ�</t>";
			SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

			%PlayerName2 = GetPlayerZiTiName(%Player,2);
			%HuoDongMingCheng2 = GetHuoDongName("��ɫ�ڳ�",2);
			%Text2 = %PlayerName2 @ "<t>����</t>" @ %HuoDongMingCheng2 @ "<t>�����ˣ����ף�����˰ɡ�</t>";
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
		}
		YaBiaoHuoDong_BiaoCheChengSe();//�����ɫ�ڳ��Ƿ��˳��ֵ�ʱ����
	}
	else
	{
		SendOneScreenMessage(2,"��ѡ�е��ڳ��Ѿ���Ѻ��",%Player);
	}
}

//����������Ѻ�ڡ�����������NPC�Ի� ������������������


//����������Ѻ�ڡ�����������������񴥷���������������
function Mission_Begin_Process_20147(%Npc,%Player,%Conv,%Param,%Mid)
{
	//echo( "%Mid====" @ %Mid );
	%Player.Addbuff(390100001,%Player,1);//Ѻ���ڳ�
	%Player.SetMissionFlag(%Mid,9100,1);
	Schedule(1000,0,"eval",%Player @ ".UpdateMission(" @ %Mid @ "); ");
}
function Mission_End_Process_20147(%Npc,%Player,%Conv,%Param,%Mid)
{
	%Act1 = GetAct(%Player,4018,1) * 1;
	if (%Act1 == 0)
		return;
	if (!isobject(%Player.BiaoCheSuiCong))
		return;

	%PinZhi1 = mfloor(%Act1/100);
	%DangCi1 = mfloor((%Act1 - %PinZhi1 * 100)/10);
	%IsBrok1 = %Act1%10;
	%State1 = $YaBiaoHuoDong_StateRecord[%PinZhi1,%DangCi1];
	//-----��Ǯ����
	if (%IsBrok1 == 1)
		%PlayerMoney = GetWord($YaBiaoHuoDong_Gold[%State1],3);
	else
		%PlayerMoney = GetWord($YaBiaoHuoDong_Gold[%State1],5);
	%Player.Addmoney(%PlayerMoney,2,1,4018);
	//----------���߼���
	//$YaBiaoHuoDong_Item[ %PinZhi1, 1 ] = "105105301 2 1800";
	for (%i = 1; %i <= 99; %i++)
	{
		if ($YaBiaoHuoDong_Item[%PinZhi1,%i] $= "")
			break;
		%Ran = GetRanDom(1,10000);
		%ItemRan = GetWord($YaBiaoHuoDong_Item[%PinZhi1,%i],2);
		switch (%DangCi1)
		{
			case 1:%ItemRan = %ItemRan * 0.8;
			case 2:%ItemRan = %ItemRan * 0.9;
			case 3:%ItemRan = %ItemRan * 1.0;
		}
		%ItemRan = %ItemRan/%IsBrok1;
		//echo( "%Ran===" @ %Ran @ "%ItemRan===" @ %ItemRan );
		if (%Ran <= %ItemRan)
		{
			%ItemID = GetWord($YaBiaoHuoDong_Item[%PinZhi1,%i],0);
			%ItemMsg = GetWord($YaBiaoHuoDong_Item[%PinZhi1,%i],1);
			%Player.PutItem(%ItemID,1);
			if (%Player.AddItem(1,20147))
			{
				if (%ItemMsg > 0)
				{
					%ItemName1 = GetItemName(%ItemID,1);
					%ItemName2 = GetItemName(%ItemID,2);
					%PlayerName1 = GetPlayerZiTiName(%Player,1);
					%PlayerName2 = GetPlayerZiTiName(%Player,2);
					%HuoDongMingCheng1 = GetHuoDongName("Ѻ��",1);
					%HuoDongMingCheng2 = GetHuoDongName("Ѻ��",2);
					%Text1 = %PlayerName1 @ "<t>�����</t>" @ %HuoDongMingCheng1 @ "<t>ʱ����������</t>" @ %ItemName1 @ "<t>��������ɷ����</t>";
					%Text2 = %PlayerName2 @ "<t>�����</t>" @ %HuoDongMingCheng2 @ "<t>ʱ����������</t>" @ %ItemName2;
					switch (%ItemMsg)
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
	}
	//----------������¼�Ĵ���
	%Player.BiaoCheSuiCong.Safedeleteobject();
	%Act0 = GetAct(%Player,4018,0) * 1;
	SetAct(%Player,4018,%Act0,0);
	if (%Player.GetBuffCount(39010,1) >= 1)
		%Player.Addbuff(390100001,%Player,-1);

	AddAchievementWatch(%Player, 0, 44, 1);//��¼�ɾ� Ѻ�ڴ���
	if (%PinZhi1 >= 4)
		AddAchievementWatch(%Player, 0, 49, 1);//��¼�ɾ� ��ɫ�ڳ�
}
//����������Ѻ�ڡ�����������������񴥷���������������


//����������Ѻ�ڡ������������뿪��ǰ��ͼ��������������
function YaBiaoHuoDongChuLi(%Player)
{
	if (%Player.IsAcceptedMission(20147))
	{
		%Player.Delmission(20147);

		%Act0 = GetAct(%Player,4018,0) * 1;
		%Act1 = GetAct(%Player,4018,1) * 1;
		if (%Act1 > 0)
			SetAct(%Player,4018,%Act0,0);

		SendOneScreenMessage(2,"���ź�������ڳ��Ѿ���ʧ",%Player);
		SendOneChatMessage($chatMsg_System,"<t>���ź�������ڳ��Ѿ���ʧ</t>",%Player);
	}

}
//����������Ѻ�ڡ������������뿪��ǰ��ͼ��������������


//����������Ѻ�ڡ�������������ұ���һ��ܡ�����������
//------����Ϊ 0�ڳ�Ʒ�� 1�ڵ�Ѻ�𵵴�  2���������� 3�������ý� 4��һ�α��ٵ��� 5�����߽��ڽ����� 6�ٴα��ٵ���
//$YaBiaoHuoDong_Gold[ 600000041 ]= "1 1 5000 8000 1750 2800 1750";
function GetMoneyForThisBiaoChe(%Act)
{
	%PinZhi = mfloor(%Act/100);
	%DangCi = mfloor((%Act - %PinZhi * 100)/10);
	%IsBrok = %Act%10;
	%State = $YaBiaoHuoDong_StateRecord[%PinZhi,%DangCi];

	return %Money;
}
function PlayeronDeathCast_1119A(%Player,%Killer)
{
	if (!%Player.IsAcceptedMission(20147))
		return;
	%Player.Delmission(20147);
	%Act0 = GetAct(%Player,4018,0) * 1;
	%Act1 = GetAct(%Player,4018,1) * 1;

	%PinZhi1 = mfloor(%Act1/100);
	%DangCi1 = mfloor((%Act1 - %PinZhi1 * 100)/10);
	%IsBrok1 = %Act1%10;
	%State1 = $YaBiaoHuoDong_StateRecord[%PinZhi1,%DangCi1];
	if (%IsBrok1 == 1)
		%PlayerMoney = GetWord($YaBiaoHuoDong_Gold[%State1],3);
	else
		%PlayerMoney = GetWord($YaBiaoHuoDong_Gold[%State1],5);
	//echo( "%Act0===" @ %Act0 );
	//echo( "%Act1===" @ %Act1 );

	if (%Act1 > 0)
		SetAct(%Player,4018,%Act0,0);
	SendOneScreenMessage(2,"���ź�������ڳ��Ѿ���ʧ",%Player);
	SendOneChatMessage($chatMsg_System,"<t>���ź�������ڳ��Ѿ���ʧ</t>",%Player);
	%NpcID = %Player.BiaoCheSuiCong.GetDataID();
	%NpcName = %Player.BiaoCheSuiCong.GetObjectName();

	//echo( "%NpcID===" @ %NpcID );
	//echo( "%NpcName===" @ %NpcName );

	%Act4018A = GetAct(%Killer,4018,0) * 1;
	%Act4018B = GetAct(%Killer,4018,1) * 1;
	%PinZhi2 = mfloor(%Act/100);
	%DangCi2 = mfloor((%Act - %PinZhi2 * 100)/10);
	%IsBrok2 = %Act%10;
	%State2 = $YaBiaoHuoDong_StateRecord[%PinZhi2,%DangCi2];
	if (%IsBrok2 == 1)
		%killerMoney = GetWord($YaBiaoHuoDong_Gold[%State2],3);
	else
		%killerMoney = GetWord($YaBiaoHuoDong_Gold[%State2],5);

	if (%IsBrok1 == 1)
		%LsatMoney = GetWord($YaBiaoHuoDong_Gold[%State1],4);
	else
		%LsatMoney = GetWord($YaBiaoHuoDong_Gold[%State1],6);

	if (%killerMoney <  %PlayerMoney && strlen(%NpcName) <= 8)
	{
		%Act4018B = mfloor(%Act1/10) * 10 + 2;
		SetAct(%Killer,4018,%Act4018A,%Act4018B);

		if (isobject(%Killer.BiaoCheSuiCong))
			%Killer.BiaoCheSuiCong.SafeDeleteobject();
		%Killer.BiaoCheSuiCong = SpNewNpc3(0,%NpcID,%Player.GetPosition(),0,0,"1 1 1");
		%Killer.BiaoCheSuiCong.SetMaster(%Killer);
		%Killer.BiaoCheSuiCong.SetShapeName(%Killer.BiaoCheSuiCong.GetObjectname() @ "������");
		%Killer.BiaoCheSuiCong.SetInteractionEnabled(0);	//���ò��ɽ���
		if (!%Killer.IsAcceptedMission(20147))
			AddMissionAccepted(%Killer,0,20147);
	}
	for (%i = 0; %i< 10; %i++)
	{

		if (%i != 9)
		{
			%MoneyCount = GetRandom(1,%LsatMoney * 0.35);
			%LsatMoney = %LsatMoney - %MoneyCount;
		}
		else
			%MoneyCount = %LsatMoney;
		SpNewDropItem(%Player.BiaoCheSuiCong,%Killer,105270001,%MoneyCount,0);
	}
	%Player.BiaoCheSuiCong.Safedeleteobject();
}
//����������Ѻ�ڡ�������������ұ���һ��ܡ�����������


//����������Ѻ�ڡ������������ڳ�ˢ�¡�����������������
function YaBiaoHuoDong_BiaoCheShuaXin(%YY,%MM,%DD,%H,%M,%S)
{
	//echo( "$SL_YaBiao_State_bActive===" @ $SL_YaBiao_State_bActive );
	if ($SL_YaBiao_State_bActive != 1)//���ڻʱ����
	{
		//------------�ڳ���ʼ��ˢ��----------------
		for (%i = 2; %i<= 13; %i++)
		{
			if (!isobject($BiaoCheRecord[%i]))
			{
				%NpcID = Getword($BiaoChe_Information[%i],0,";");
				%Pos = Getword($BiaoChe_Information[%i],1,";");
				%Rot = Getword($BiaoChe_Information[%i],2,";");
				%Scale = Getword($BiaoChe_Information[%i],3,";");
				$BiaoCheRecord[%i] = SpNewNpc3(0,%NpcID,%Pos,0,%Rot,%Scale);
				$BiaoCheRecord[%i].NumberRecord = %i;//��¼����ڳ��ı��
				$YaBiaoHuoDong_TimeRecord[%i] = "00:00";//����ˢ��CD
			}
		}
		if (isobject($BiaoCheRecord[1]))
			$BiaoCheRecord[1].SafeDeleteobject();//��ɫ�ڳ�
		$YaBiaoHuoDong_TimeRecord[1] = "00:00";//����ˢ��CD
		$AllFaCheMaxNumber = 0;
		return;
	}
	//-----------�ʱ���ڣ������ڳ��Ƿ���Ҫ����ˢ��-------
	for (%i = 2; %i <= 13; %i++)
	{
		%CreateCD = GetWord($BiaoChe_Information[%i],4,";");
		%NowTime = %H * 60 + %M;
		%DieTime = GetWord($YaBiaoHuoDong_TimeRecord[%i],0,":") * 60 + GetWord($YaBiaoHuoDong_TimeRecord[%i],1,":");
		//echo( %i @ "  %NowTime=="  @ %NowTime  @ "  %DieTime==" @ %DieTime @ "  CD==" @  %CreateCD @ "   $YaBiaoHuoDong_TimeRecord[ %i ]==" @ $YaBiaoHuoDong_TimeRecord[ %i ] );
		if (%NowTime - %DieTime >= %CreateCD && !isobject($BiaoCheRecord[%i]))
		{
			%NpcID = Getword($BiaoChe_Information[%i],0,";");
			%Pos = Getword($BiaoChe_Information[%i],1,";");
			%Rot = Getword($BiaoChe_Information[%i],2,";");
			%Scale = Getword($BiaoChe_Information[%i],3,";");
			//echo( "%NpcID===" @ %NpcID @   "  " @ GetNpcData( %NpcID, 1 ) );
			$BiaoCheRecord[%i] = SpNewNpc3(0,%NpcID,%Pos,0,%Rot,%Scale);
			$BiaoCheRecord[%i].NumberRecord = %i;//��¼����ڳ��ı��
		}
	}
}
//-----------��ɫ�ڳ���������-------------------------------
function YaBiaoHuoDong_BiaoCheChengSe()
{
	//echo("��ɫ�ڳ���������==");
	$AllFaCheMaxNumber++;
	//echo("$AllFaCheMaxNumber == " @ $AllFaCheMaxNumber);
	if ($YaBiaoHuoDong_TimeRecord[1] !$= "00:00")
		return;
	if ($AllFaCheMaxNumber <= 50)
		return;
	%Ran = GetRandom(1,100);
	if (%Ran <= 5)
	{
		//echo("��ɫ�ڳ���ɫ�ڳ���ɫ�ڳ���ɫ�ڳ���ɫ�ڳ�");
		%Path = "<l i='811190100 108.789 -187.785 120' t='path'/>";
		%HuoDongMingCheng = GetHuoDongName("��ɫ�ڳ�",1);
		%Text = %HuoDongMingCheng @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ "5</t><t>���Ӻ���֣���ʿ�ǻ���ʲô���Ͻ�ǰ��</t>" @ %Path @ "<t>���ڰɡ�</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

		%HuoDongMingCheng2 = GetHuoDongName("��ɫ�ڳ�",2);
		%Text2 = %HuoDongMingCheng2 @ "<t>����</t>" @ $Get_Dialog_GeShi[60002] @ "5</t><t>���Ӻ����</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);

		$YaBiaoHuoDong_TimeRecord[1] =  GetWord(GetLocalTime(),3) @ ":" @ GetWord(GetLocalTime(),4);
		Cancel($ScheduleOrangeBiaoCar);
		$ScheduleOrangeBiaoCar = Schedule(5 * 60 *1000,0,"CreateChengSeBiaoChe");
	}
}
function CreateChengSeBiaoChe()
{
	Cancel($ScheduleOrangeBiaoCar);
	if (isobject($BiaoCheRecord[1]))
		return;
	%NpcID = Getword($BiaoChe_Information[1],0,";");
	%Pos = Getword($BiaoChe_Information[1],1,";");
	%Rot = Getword($BiaoChe_Information[1],2,";");
	%Scale = Getword($BiaoChe_Information[1],3,";");
	$BiaoCheRecord[1] = SpNewNpc3(0,%NpcID,%Pos,0,%Rot,%Scale);
	$BiaoCheRecord[1].NumberRecord = 1;//��¼����ڳ��ı��

	%Path = "<l i='811190100 108.789 -187.785 120' t='path'/>";
	%HuoDongMingCheng = GetHuoDongName("��ɫ�ڳ�",1);
	%Text = %HuoDongMingCheng @ "<t>������</t>" @ %Path @ "<t>����ʿ�ǸϽ�ȥ���ڰɡ�</t>";
	SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

	%HuoDongMingCheng2 = GetHuoDongName("��ɫ�ڳ�",2);
	%Text2 = %HuoDongMingCheng2 @ "<t>�Ѿ�����</t>";
	SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
}
//����������Ѻ�ڡ������������ڳ�ˢ�¡�����������������

//����������Ѻ�ڡ������������ڳ����䡿����������������
function TriggerEvent_553000016(%Player,%Event,%EventID)
{
	//echo( "%Event===" @ %Event.GetObjectname( ) @  "   " @ %Event.MoneyRecord );
	if (%Event.MoneyRecord > 0)
		%Player.Addmoney(%Event.MoneyRecord,2,1,553000016);
	%Event.SafeDeleteobject();
	return 1;
}
//����������Ѻ�ڡ������������ڳ����䡿����������������
