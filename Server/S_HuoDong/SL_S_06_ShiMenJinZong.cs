//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//ʦ�ž���
//=================================================================================

//����������ʦ�ž��ҡ����������� NPC�Ի�������������������
//����������ʦ�ž��ҡ����������������ȡ������������������
//����������ʦ�ž��ҡ�����������������������������������
//����������ʦ�ž��ҡ������������Ի���������������������



//����������ʦ�ž��ҡ����������� NPC�Ի�������������������
function ShiMenJinZong_Dialog(%Npc,%Player,%State,%Conv)
{
	//echo( "$SL_ShiMenJinZong_State_bActive==" @ $SL_ShiMenJinZong_State_bActive );
	if ($SL_ShiMenJinZong_State_bActive != 1)
		return;
	if (%player.getlevel() < 20)
		return;

	switch (%state)
	{
		case 0:
			//echo( "========" @ !%Player.IsAcceptedMission( 20149 ) );
			%Act4015[0] = GetAct(%player, 4015, 0);
			if (!%Player.IsAcceptedMission(20149) && %Player.GetLevel() >= $SL_ShiMenJinZong_Level && %Act4015[0] <= 9)
				%Conv.AddOption(600000025,600000025);
		case 600000025:
			%Conv.Settype(4);
			if (%player.isschbuff(2003))
			{
				SendOneScreenMessage(2,"�㻹���Ⱥú÷�ʡ�°ɣ�",%Player);
				SendOneChatMessage($chatMsg_System,"<t>�㻹���Ⱥú÷�ʡ�°ɣ�</t>",%Player);
				return;
			}
			if (%Player.GetBagEmptyCount() < 1)
			{
				SendOneScreenMessage(2,"��Ԥ��һ�����ϵİ����ո�",%Player);
				SendOneChatMessage($chatMsg_System,"<t>��Ԥ��һ�����ϵİ����ո�</t>",%Player);
				return;
			}
			if (%Player.Isschbuff(2021))
			{
				SendOneScreenMessage(2,"��ħ���壬�޷���ȡʦ������",%Player);
				SendOneChatMessage($chatMsg_System,"<t>��ħ���壬�޷���ȡʦ������</t>",%Player);
				return;
			}
			if (%Player.Getlevel() < $SL_ShiMenJinZong_Level)
			{
				SendOneScreenMessage(2,"�ȼ�����" @ $SL_ShiMenJinZong_Level @ "���޷���ȡʦ������",%Player);
				SendOneChatMessage($chatMsg_System,"<t>�ȼ�����" @ $SL_ShiMenJinZong_Level @ "���޷���ȡʦ������</t>",%Player);
				return;
			}
			%Act4015[0] = GetAct(%player,4015,0);
			if (%Act4015[0] > 9)
			{
				SendOneScreenMessage(2,"�����Ѿ����10�������ˣ������������ɣ�",%Player);
				SendOneChatMessage($chatMsg_System,"<t>�����Ѿ����10�������ˣ������������ɣ�</t>",%Player);
				return;
			}
			AddMissionAccepted(%Player,%Conv,20149);
	}
}
//����������ʦ�ž��ҡ����������� NPC�Ի�������������������

//����������ʦ�ž��ҡ����������������ȡ������������������
$shimenjinzong_missflag[1] ="410100003;1"; //�Ի�NPC 	��ҵ
$shimenjinzong_missflag[2] ="410100004;1"; //�Ի�NPC 	����
$shimenjinzong_missflag[3] ="410100005;1"; //�Ի�NPC 	����
$shimenjinzong_missflag[4] ="410100006;1"; //�Ի�NPC 	��ƽ��
$shimenjinzong_missflag[5] ="410100007;1"; //�Ի�NPC 	����ʯ
$shimenjinzong_missflag[6] ="410100008;1"; //�Ի�NPC 	�ŵ�ɽ
$shimenjinzong_missflag[7] ="410100009;1"; //�Ի�NPC 	����
$shimenjinzong_missflag[8]="410100011;1"; //�Ի�NPC 	��֪��
$shimenjinzong_missflag[9]="410100032;1"; //�Ի�NPC 	����
$shimenjinzong_missflag[10]="410100031;1"; //�Ի�NPC 	ɲ��
$shimenjinzong_missflag[11]="108020994;1"; //�����Ʒ	���ɲ�˿
$shimenjinzong_missflag[12]="108020995;1"; //�����Ʒ	������
$shimenjinzong_missflag[13]="108020996;1"; //�����Ʒ	������
$shimenjinzong_missflag[14]="108020997;1"; //�����Ʒ	ǧ������
$shimenjinzong_missflag[15]="108020998;1"; //�����Ʒ	��ľ
$shimenjinzong_missflag[16]="108020999;1"; //�����Ʒ	����ʯ
$shimenjinzong_missflag[17]="108021000;1"; //�����Ʒ	��������
$shimenjinzong_missflag[18]="108021002;1"; //�����Ʒ	����Ȫ 108021001	��ƿ��
$shimenjinzong_missflag[19]="552000010;4"; //�ɼ�	  	�����
$shimenjinzong_missflag[20]="552000011;1"; //�ɼ�	  	���ľ
$shimenjinzong_missflag[21]="552000012;4"; //�ɼ�	  	������
$shimenjinzong_missflag[22]="552000013;1"; //�ɼ�	  	����
$shimenjinzong_missflag[23]="552000014;1"; //�ɼ�	  	����¶
$shimenjinzong_missflag[24]="553000050;1"; //�ɼ�	  	��������
$shimenjinzong_missflag[25]="410101002 ;10"; //������
$shimenjinzong_missflag[26]="410101004 ;10"; //�з��
$shimenjinzong_missflag[27]="410101014 ;10"; //�鹽С��
$shimenjinzong_missflag[28]="410101015 ;10"; //����
$shimenjinzong_missflag[29]="410101020;1"; //��ս��ħ	��ħ


//	npcf04_003  �����
//	npcf02_006	���ľ
//	npcf04_010  ������
//	npce01_008	����
//	npcf05_003	����¶


function Mission_Begin_Process_20149(%Npc,%Player,%Conv,%Param,%Mid)
{

	%Act4015[0] = GetAct(%player,4015,0);
	%Act4015[1] = GetAct(%player,4015,1);

	if (%Act4015[0] < 5)
		%ran = getrandom(1,24);
	else if (%Act4015[0] < 9)
		%ran = getrandom(1,28);
	else if (%Act4015[0] == 9)
		%ran = getrandom(25,29);
	else
		%ran = getrandom(1,29);
	//echo("ʦ�������" @ %ran @ "��");
	if (%ran >= 29)
		%ran = 29;

	if (%Act4015[0] > 2 && %Act4015[0]  <= 8)
	{
		%Src = GetSrc(%Player,58);
		switch (%Src)
		{
			case 0:%Re = 3;
			case 1:%Re = 1;
		}
		%Rn = GetRandom(1,10);
		if (%Rn <= %Re)
		{
			%ran = 29;
			if (%Src  == 0)
				SetSrc(%Player,58);
		}

	}
	%missionflag = $shimenjinzong_missflag[%ran];
	%missiontar = getword(%missionflag,0,";");
	%missionnum = getword(%missionflag,1,";");
	switch$(getsubstr(%missiontar,0,1))
	{
		case "1"://��ȡ����
			%midtarflag = 2100;
		case "5"://�ɼ�
			%midtarflag = 2130;
		case "4"://NPC
			if (getnpcdata(%missiontar,16) == 14)//����NPC �Ի�
			{
				%midtarflag = 1150;
			}
			else//����
			{
				%midtarflag = 3100;
			}
	}
	if (%midtarflag > 0)
	{
		%Act4015[0]++;
		Setact(%player,4015,%Act4015[0],%Act4015[1]);
		%Player.SetMissionFlag(%Mid,%midtarflag,%missiontar);
		%Player.SetMissionFlag(%Mid,%midtarflag + 100,%missionnum);

		if (%midtarflag == 2130)//�ɼ���Ҫ���⴦��һ��
		{
			%Player.SetMissionFlag(%Mid,1400,%missiontar);
			%Player.SetMissionFlag(%Mid,1500,%midtarflag + 100);
		}
		if (%midtarflag == 2100)
		{
			%iNowHasCount = %Player.GetItemCount(%missiontar);
			if (%iNowHasCount >= %missionnum)
				%iNowHasCount = %missionnum;
			%Player.SetMissionFlag(%Mid,%midtarflag + 200,%iNowHasCount);
		}
		if (%missiontar ==  108021002)
		{
			%Player.Putitem(108021001,1);
			%Player.Additem(1, %Mid);
		}
		%Player.SetMissionFlag(%Mid,9100,1);
		%Player.SetMissionFlag(%Mid,9101,1);

		%Player.SetMissionFlag(%Mid,10300,%missiontar);         //���������������

		Schedule(500,0,"eval",%Player @ ".updatemission(" @ %Mid @ "); ");
	}
}
//����������ʦ�ž��ҡ����������������ȡ������������������




//����������ʦ�ž��ҡ�����������������������������������

function Mission_End_Process_20149(%Npc,%Player,%Conv,%Param,%Mid)
{
	%PlayerID = %Player.getPlayerID();
	%Act4015[0] = GetAct(%player,4015,0);
	%Act4015[1] = GetAct(%player,4015,1);
	%exp = 62;
	%Level = %Player.getlevel();
	if (%Level < 30) %levelxishu = 0.3;
	else if (%Level < 40) %levelxishu = 1;
	else if (%Level < 50) %levelxishu = 1.2;
	else if (%Level < 60) %levelxishu = 1.6;
	else if (%Level < 70) %levelxishu = 2;
	else %levelxishu = 2.2;
	//���辭��	EXP = ��62+����*8��*��ҵȼ���Ӧ���� * �ȼ�΢��ϵ��
	%exp = (%exp +  %Act4015[0] * 8) * $Monster_Exp[%Level,1] * %levelxishu;
	if (%exp > 0)
		AllAddExp(%Player,%exp);

	if (%Act4015[0] == 10 &&  %Act4015[1] == 0)
	{
		%player.putitem(105109341,1);
		if (%player.additem(1, %Mid))
		{
			%ItemName2 = GetItemName(105109341,2);

			%PlayerName2 = GetPlayerZiTiName(%Player,2);
			%HuoDongMingCheng2 =  GetHuoDongName("ʦ�ž���",2);
			%Text2 = %PlayerName2 @ "<t>���</t>" @ %HuoDongMingCheng2 @ "<t>�������</t>" @ %ItemName2;
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
		}
	}
	
	//----------��������ʦ���ܻ��������-------
	if (%Player.IsAcceptedMission(20207))
		ShiMenPaoHuan_20207(%Player,20207);

	AddAchievementWatch(%Player,0,34,1);//��¼�ɾ�
}

//����������ʦ�ž��ҡ�����������������������������������


//����������ʦ�ž��ҡ������������Ի���������������������
function Mission_Special_20149(%Npc,%Player,%State,%Conv,%mid)
{
	if (!%Player.IsAcceptedMission(%Mid))
		return;
	%Missiontarget = %Player.GetMissionFlag(%Mid,10300);
	//echo( "%Missiontarget==" @ %Missiontarget );
	if (%Missiontarget  != %Npc.getdataid())
		return;
	if (%Player.GetMissionFlag(%Mid,1350) >= 1)
		return;
	switch (%state)
	{
		case 0:
			%Conv.AddOption(400 @ %Mid,400 @ %Mid);
		case 400 @ %Mid:
			%Player.SetMissionFlag(%Mid,1350,1);
			SendOneScreenMessage(1,"�Ի���" @ %Npc.getobjectname() @ "��  1/1",%Player);
			%Conv.settext(500 @ %Mid);
			%Player.UpdateMission(%Mid);
	}
}
//����������ʦ�ž��ҡ������������Ի���������������������



function Trigger_108021001(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	%Posx = GetWord(%Player.GetPosition(),0);
	%Posy = GetWord(%Player.GetPosition(),1);
	%X = -26.2497;
	%Y = 65.519;
	if (msqrt(mpow(%Posx - %X,2) + mpow(%Posy - %Y,2)) < 10)
	{
		%Player.Putitem(%type,-1);
		%Player.Putitem(108021002,1);
		%Player.Additem(1,20149);
	}
}