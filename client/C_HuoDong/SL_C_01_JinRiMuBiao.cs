

//���������������������������;�ϲ�����������������������������������������
//�������򿪽������
//��������������
//�����������������ʾ
//����������״̬+������
//��������������Ч��ʾ
//����������������ʾ
//��������ȡ����
//��������ȡ����
//����������Ŀ�꣭������
//������ÿ�ո�����������
//��������С������ʾ
//��������ӭ���涹������ʾ
//�������Ƿ��н�������ȡ

//�������򿪽������
function OpenOrCloseTargetWnd()
{
	if (!TodayGoalWnd.isvisible())
		UpdateSurprisePartyWnd(4);
	else
		TodayGoalWnd.SetVisible(0);
}
function UpdateSurprisePartyWnd(%State)
{
	//��ȡ���player
	%Player = GetPlayer();

	//����2����ҳ�����ҵ���λ��
	TodayGoalWndGui_Tab1.setVisible(1);
	TodayGoalWndGui_Tab2.setVisible(0);
	TodayGoalWndGui_Tab1.setposition(7,38);
	TodayGoalWndGui_Tab2.setposition(110,38);

	if (%State != 3)
	{
		//��������
		if (TodayGoalWnd.isVisible() == 0)
		{
			GameMainWndGui_Layer3.pushtoback(TodayGoalWnd);			//���ý����ö�
			TodayGoalWnd.SetVisible(1);													//������ʾ�����;�ϲ�
		}
	}

	if (GetWord(%Player.GetActivity(1122),0) == 1)
	{
		TodayGoalWndGui_Tab1.setVisible(0);
		TodayGoalWndGui_Tab2.setposition(7,38);
		%State = $TodayGoalWnd_Pagination[%Player] = 2;
	}
	//����㿪��ҳ
	else if (%State <= 2)
		$TodayGoalWnd_Pagination[%Player] = %State;
	//�������ܿ���
	else if ((%State == 4) && ($TodayGoalWnd_Pagination[%Player] == 0))
	{
		for (%In = 0; %In < 7; %In++)
		{
			%MidResult = DailyGoalWnd_fettle(%Mid,%In);
			if ((%MidResult == 5) || (%MidResult == 6))
				%MidAA++;
		}

		$TodayGoalWnd_Pagination[%Player] = (%MidAA < 7) ? 1 : 2;
		%State = $TodayGoalWnd_Pagination[%Player];


	}
	else
		%State = $TodayGoalWnd_Pagination[%Player];

	%State = $TodayGoalWnd_Pagination[%Player] = 1;

	//�������Խ���
	SurprisePartyWnd_TodayGoalWnd_unite(%State);

	//���ý���������
	if (%State == 1)
	{
		TodayGoalWnd_7_Days_Goal_Process.setVisible(true);
		DailyGoalWnd_Days_Goal_Process.setVisible(false);
		TodayGoalWndGui_Tab1.setStateOn(1);


		Getrewordbutton.setProfile("UPDownLineWndProfile_51");
		TodayGoalWnd_1_map.setBitmap("gameres/gui/images/calendar_seven_main");
	}
	else
	{
		TodayGoalWnd_7_Days_Goal_Process.setVisible(false);
		DailyGoalWnd_Days_Goal_Process.setVisible(true);
		TodayGoalWndGui_Tab2.setStateOn(1);

		Getrewordbutton.setProfile("UPDownLineWndProfile_5");
		TodayGoalWnd_1_map.setBitmap("gameres/gui/images/calendar_four_main");
	}
}
//��������������
function SurprisePartyWnd_TodayGoalWnd_unite(%State)
{
	//��ȡ���player
	%Player = GetPlayer();

	//���ʱ��
	%Time = GetLocalTime();
	%Time = GetWord(%Time,1) @ GetWord(%Time,2);

	//�뵱ǰʱ�䲻��ʱ���������ͨѶ
	if (GetWord(%Player.GetActivity(2002),0) < 8)
		if (GetWord(%Player.GetActivity(2002),1) !$= %Time)
			ClientOnSptAction(4,0);//���ÿɽ�

	//���������涹����
	//CloseHelpDirectWnd(2);
	$OpenOrCloseUpLinePartyWnd_Trigger = 1;

	//���ý�������
	OpenTodayGoalWnd_ListBox("",%State);

	//��Чˢ��
	DailyGoalWnd_GetSuperPrize_Effect();

	//����״̬
	TodayGoalWnd_Goal_Picture();	//����״̬+������
	DailyGoalWnd_Goal_Picture();	//����״̬+������

	//������
	if (%State == 1)
	{
		Getrewordbutton.command = "ClientOnSptAction(13, 1);";
		Getrewordbutton.SetActive((GetWord(%Player.GetActivity(1122),0)) ? 0 : 1);
	}
	else
	{
		Getrewordbutton.command = "ClientOnSptAction(13, 2);";
		Getrewordbutton.SetActive((GetWord(%Player.GetActivity(1123),0)) ? 0 : 1);
	}

	//������
	if (DailyGoalWnd_fettle($JRMB_Mission[0],0) == 4){ ShowHelpDirectByIndex(25); }
	if (DailyGoalWnd_fettle($JRMB_Mission[0],1) == 2){ ShowHelpDirectByIndex(26); }

	//��С��ˢ��
	Schedule(3000,0,"UpLine_PartyTurnOnBntWnd",%State);//������С����ť
}

//��ȡ�����״̬
function DailyGoalWnd_fettle(%Mid,%In)
{
	%Player = GetPlayer();
	%Mid = $JRMB_Mission[%In];
	%KKK = GetWord(%Player.GetActivity(2002),0);

	//Ŀ���Ƿ���
	if (%Mid >= 32520)
	{
		//�ж��Ƿ񵽴�ȼ�
		%Level = %Player.GetLevel();
		if (GetMissionData(%Mid,$Mission_Data_LvA) > %Level)
			return 7;

		//�Ƿ��Ѿ����
		if (GetWord(%Player.GetActivity($JRMB_Achieve[1110 + %In]),0) == 1)
			return 5;
	}

	//�Ƿ��������
	if (%Player.IsFinishedMission(%Mid))
		return 5;

	//�ѽ�����ʱ
	if (%Player.IsAcceptedMission(%Mid))
	{
		if (%Player.GetMissionFlag(%Mid,1300) >= %Player.GetMissionFlag(%Mid,1200))
			return 4;//����-��ȡ����
		else
			return 3;//����-������
	}
	else if (%Mid < 32520)
	{
		if (%KKK < (%In+1))return 1;//����-δ����
		else if (%KKK >(%In+1))return 6;//����-����
		else return 2;	//����-����ȡ
	}
	else return 2;	//����-����ȡ
}

//����������״̬+������
function TodayGoalWnd_Goal_Picture()
{
	%Player = GetPlayer();

	for (%i = 0; %i < 7; %i++)
	{
		//��ȡ����Id
		%Mid = $JRMB_Mission[%i];
		//��ȡ����״̬
		%AAA = DailyGoalWnd_fettle(%Mid,%i);

		//���ý�������ʾ
		("TodayGoalWnd_Goal_"@%i+1).setVisible((%AAA > 1) ? 1 : 0);

		//����ͼƬ���
		if (%AAA == 3){ %Us = "397,462"; %Vs = "122,142"; }	//������
		else if (%AAA == 4){ %Us = "397,462"; %Vs = "122,142"; }	//������
		else if (%AAA == 5){ %Us = "397,462"; %Vs = "162,182"; }	//���
		else if (%AAA == 6){ %Us = "397,462"; %Vs = "102,122"; } //�ѹ���
		else { %Picture_Name = 0; } //��ʼ��

		//����״̬��ʾ
		if (%Picture_Name $= 0)
			("TodayGoalWnd_Goal_"@%i+1@"_State").setVisible(0);	//���ؿؼ�
		else
		{
			//��ʾ�ؼ�
			("TodayGoalWnd_Goal_"@%i+1@"_State").setVisible(1);
			("TodayGoalWnd_Goal_"@%i+1@"_State").setCtrlImageUVs(%Us,%Vs);
		}
	}
}

//����������״̬+������
function DailyGoalWnd_Goal_Picture()
{
	%Player = GetPlayer();

	for (%i = 7; %i < 16; %i++)
	{
		//��ȡ����Id
		%Mid = $JRMB_Mission[%i];

		//��ȡ����״̬
		if (DailyGoalWnd_fettle(%Mid,%i) == 5)
			%FFF++;
	}

	for (%i = 1; %i < 5; %i++)
	{
		if (%i <= %FFF)
		{
			("DailyGoalWnd_Goal_"@%i@"").setVisible(1);
			("DailyGoalWnd_Goal_"@%i@"_State").setVisible(1);
			("DailyGoalWnd_Goal_"@%i@"_State").setBitmap("Gameres/gui/images/GUIWindow75_1_008");
		}
		else
		{
			("DailyGoalWnd_Goal_"@%i@"_State").setVisible(0);
			("DailyGoalWnd_Goal_"@%i@"").setVisible(0);
		}
	}
}

//��������������Ч��ʾ
function DailyGoalWnd_GetSuperPrize_Effect()
{
	%Player = GetPlayer();
	if (GetWord(%Player.GetActivity(1122),0) == 0)
	{
		for (%i = 0; %i < 7; %i++)
		{
			//��ȡ����Id
			%Mid = $JRMB_Mission[%i];
			//��ȡ����״̬
			%AAA = DailyGoalWnd_fettle(%Mid,%i);

			//��ȡ�Ƿ��н���������
			if ((%AAA == 3) || (%AAA == 4))
			{
				%Atelic++;
				break;
			}

			//��ȡ�Ƿ����
			if (%AAA == 5)
				%KKK++;
		}

		//��ɴ���1����û�н�������������ʾ��Ч
		%ine = ((%KKK > 1) && (%Atelic == 0)) ? 1 : 0;
		TodayGoalWnd_GetSuperPrize_Effect.SetVisible(%ine);
	}
	else
		TodayGoalWnd_GetSuperPrize_Effect.SetVisible(0);

	//��Ч-����
	if (GetWord(%Player.GetActivity(1123),0) == 0)
	{
		for (%i = 7; %i < 16; %i++)
		{
			//��ȡ����Id
			%Mid = $JRMB_Mission[%i];
			//��ȡ����״̬
			%AAA = DailyGoalWnd_fettle(%Mid,%i);
			//��������������5
			if (%AAA == 5)
				%MMM++;
		}

		//��ʾ��Ч
		%ine = (%MMM >= 4) ? 1 : 0;
		DailyGoalWnd_GetSuperPrize_Effect.SetVisible(%ine);
	}
	else
		DailyGoalWnd_GetSuperPrize_Effect.SetVisible(0);
}

//����������������ʾ
function SurprisePartyWnd_ListBox_Choose(%State)
{
	%Player = GetPlayer();
	%list = TodayGoalWnd_ListBox.GetSelectedId();

	%Mid = $JRMB_Mission[%list];	//��ȡ������
	ClientOnSptAction(9,%list);
	if (%list < 7)
		%Open[1] = $Icon[92] @ "<b/><t>��ɫ���롶���ؾ�����</t>" @ $Get_Dialog_GeShi[31412] @"��" @ %list + 1 @ "��</t><t>�Զ�����</t><b/><b/>";		//"������";

	%Open[2] = $Icon[98] @ "<b/>" @ eval("Mission" @ %Mid @ "Dialog" @ "(%Npc, %Player, %Mid, 10001);") @ "<b/>";		//"����Ŀ��";
	%Open[3] = $Icon[97] @ "<b/>" @ GetMissionHortation(%Mid,0);	//������

	TodayGoalWnd_Tips.SetContent(%Open[1] @ %Open[2] @ %Open[3]);
}

function SurprisePartyWnd_ListBox_Choose_ultimate(%Mid)
{
	//��ȡPlayer
	%Player = GetPlayer();

	//Ԫ������
	if (%Mid >= $JRMB_Mission[7]){ %MissionData_Gold = 20; }
	if (%MissionData_Gold != 0){ %Gold  = $Get_Dialog_GeShi[31412] @ " ��Ԫ���� </t><t>[ " @ %MissionData_Gold  @ " ]</t><b/>"; }
	else{ %Gold  = ""; }

	//���⽱��
	if (%Mid == 32527)
		%Open[4] = SurprisePartyWnd_ListBox_ChooseA(%Player);
	else if (%Mid == 32520)
		%Open[4] = SurprisePartyWnd_ListBox_ChooseB(%Player);
	else if (%Mid == 32522)
		%Open[4] = SurprisePartyWnd_ListBox_ChooseC(%Player);
	else if (%Mid == 32525)
		%Open[4] = SurprisePartyWnd_ListBox_ChooseD(%Player);
	else if (%Mid == 32528)
		%Open[4] = SurprisePartyWnd_ListBox_ChooseE(%Player);

	return %Open[4];
}

function SurprisePartyWnd_ListBox_ChooseA(%Player)
{
	%leve = %Player.GetLevel();				//��ҵȼ�
	%ExpA = $Monster_Exp[%leve,1];		//��ǰ�ȼ����ﾭ��

	%Mid = 32527;
	%MF[1] = %Player.GetMissionFlag(%Mid,10000);
	%MF[2] = %Player.GetMissionFlag(%Mid,10001);
	%MF[3] = %Player.GetMissionFlag(%Mid,10002);

	%Status[1]  = "ƽ��";
	%Status[2]  = "ʧ��";
	%Status[3]  = "ʤ��";
	%Status[0] = "δ���";
	// %status -1,1,0, 0��ʾƽ�֣�2��ʾʤ����1��ʾʧ�ܣ�%type�Ǹ�������
	%ExpA = 100000;

	%OpenA = $Get_Dialog_GeShi[31406] @ " ����ʤ��������ͬ���飺</t><b/>";
	%OpenB = $Get_Dialog_GeShi[31412] @ " ʤ������1���飺</t><t> [ " @ 3*%ExpA@ " ]��" @ %Status[%MF[1]] @ "��</t><b/>";
	%OpenC = $Get_Dialog_GeShi[31412] @ " ʤ������2���飺</t><t> [ " @ 6*%ExpA @ " ]��" @ %Status[%MF[2]] @ "��</t><b/>";
	%OpenD = $Get_Dialog_GeShi[31412] @ " ʤ������3���飺</t><t> [ " @ 9*%ExpA @ " ]��" @ %Status[%MF[3]] @ "��</t>";

	%Open[4] = %OpenA @ %OpenB @ %OpenC @ %OpenD;			//"������";

	if (DailyGoalWnd_fettle(%Mid,14) == 5)
		%Open[4] = "";

	return %Open[4];
}

function SurprisePartyWnd_ListBox_ChooseB(%Player)
{
	%OpenC = $Get_Dialog_GeShi[31406] @ "��ע����100Ԫ���ɶһ�200���֣���ÿ��ֻ���Զһ�һ�Ρ�</t>";

	%Open[4] = "<b/>" @ %OpenA @ %OpenB @ %OpenC;			//"������";

	return %Open[4];
}

function SurprisePartyWnd_ListBox_ChooseC(%Player)
{
	%OpenB = $Get_Dialog_GeShi[31412] @ " ��ɴ������뿪������ģʽ�����ܲ�ͬ��������Ҳ��������ƶ�ֵ��</t><b/>";
	%OpenC = $Get_Dialog_GeShi[31406] @ "��ע��10�����ڻ���ͬһ���ж���Ҳ�������</t>";

	%Open[4] = "<b/>" @ %OpenA @ %OpenB @ %OpenC;			//"������";

	return %Open[4];
}

function SurprisePartyWnd_ListBox_ChooseD(%Player)
{
	if (%Player.GetFamily() < 3)
	{
		%level = %Player.GetLevel();
		if (%level < 30){ %NpcID1 = 401101042; %DiMing = "����"; }
		else if (%level < 40){ %NpcID1 = 401102034; %DiMing = "����"; }
		else if (%level < 50){ %NpcID1 = 401103051; %DiMing = "̫ԭ"; }
		else if (%level < 60){ %NpcID1 = 401104027; %DiMing = "�ػ�"; }
		else if (%level < 70){ %NpcID1 = 401105030; %DiMing = "�ɶ�"; }
		else{ %NpcID1 = 401106027; %DiMing = "ͻ��"; }
	}
	else
	{
		%level = %Player.GetLevel();
		if (%level < 30){ %NpcID1 = 401101043; %DiMing = "����"; }
		else if (%level < 40){ %NpcID1 = 401102035; %DiMing = "����"; }
		else if (%level < 50){ %NpcID1 = 401103052; %DiMing = "̫ԭ"; }
		else if (%level < 60){ %NpcID1 = 401104028; %DiMing = "�ػ�"; }
		else if (%level < 70){ %NpcID1 = 401105031; %DiMing = "�ɶ�"; }
		else{ %NpcID1 = 401106028; %DiMing = "ͻ��"; }
	}

	%OpenB = $Get_Dialog_GeShi[31412] @ "�����뷽ʽ��</t><b/>" @
		"<t>"@%DiMing@"</t>"@"<t><c cid='" @ Get_TraceButton() @ "' cmd='\"findpath("@%NpcID1@");\",\"" @ $Get_Dialog_GeShi[31414] @ GetNpcData(%NpcID1,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @"<t>�����NPCǰ����ȡ����</t><b/>";
	return "<b/>" @ %OpenA @ %OpenB @ %OpenC;			//"������";
}

function SurprisePartyWnd_ListBox_ChooseE(%Player)
{
	%Player.ClearMissionItem(10030);	//���֮ǰ����Ʒ��ʾ
	%Player.ClearMissionItem(10031);	//���֮ǰ����Ʒ��ʾ

	//ý�����
	%Player.AddItemToMission(10030,1,105103065,1);	//50����ֿ�
	%Player.AddItemToMission(10030,1,113010081,1);	//50�������
	%Player.AddItemToMission(10030,1,105028002,1);	//˫�����鵤
	%Player.AddItemToMission(10030,1,105100028,1);	//�齱����

	//���˴����
	%Player.AddItemToMission(10031,1,105103030,1);	//500000��Ҷһ�ȯ
	%Player.AddItemToMission(10031,1,105103070,1);	//200���Ծ���ֿ�
	%Player.AddItemToMission(10031,1,119011070,1);	//����ս��

	%Txt[1] = $Get_Dialog_GeShi[31412] @ "��ý�������������</t><b/>" @ GetFixedMissionItemText(10030) @ "<b/>";
	%Txt[2] = $Get_Dialog_GeShi[31412] @ "�����˴������������</t><b/>" @ GetFixedMissionItemText(10031);

	return %Txt[1] @ %Txt[2];
}
//��������ȡ����
function SurprisePartyWnd_AcceptTask_Accept(%FenLei)
{
	%Player = GetPlayer();
	//CloseHelpDirectWnd(4);

	%list = ("TodayGoalWnd_ListBox" @ %FenLei).GetSelectedId();
	%AAA = DailyGoalWnd_fettle($JRMB_Mission[%list],%list);
	if (%list !$= "")
	{
		if (%AAA == 1){ %txt = "������δ������"; }
		else if (%AAA == 2){ %txt = "�ɽ�"; }
		else if (%AAA == 3){ %txt = "���Ѿ���ȡ�˸�����"; }
		else if (%AAA == 4){ %txt = "���"; }
		else if (%AAA == 5){ %txt = "���Ѿ���ɸ�����"; }
		else if (%AAA == 6){ %txt = "�������ѹ��ڣ���ѡ������������ȡ�ɣ�"; }

		if (%txt $= "�ɽ�"){ ClientOnSptAction(5,%list); }
		else if (%txt $= "���"){ ClientOnSptAction(6,%list); }
		else { SetScreenMessage(%txt,$Color[2]); }

		//������
		if ((%AAA == 0) && (%list[1] < 0))
			ClientOnSptAction(7,%AAA @ %list);
	}
}

//��������С������ʾ
function UpLine_PartyTurnOnBntWnd(%State)
{
	if (UpLine_A_PartyTurnOnBntWnd(2) > 0)
		UpLinePartyTurnOnBntWnd.setvisible(1);
	else
		UpLinePartyTurnOnBntWnd.setvisible(0);

	OpenOrCloseFestivity_use();
}

//��ȡ�Ƿ���δ�ӻ�δ��ɵ�
function UpLine_A_PartyTurnOnBntWnd(%Activity)
{
	%Player = GetPlayer();
	for (%i = 0; %i < 6; %i++)
	{
		//��ȡ������
		%Mid = 32510 + %i;
		//��ȡ����״̬
		%AAA = DailyGoalWnd_fettle(%Mid,%i);
		if ((%AAA == 2) || (%AAA == %Activity) || (%AAA == 4))
			return 1;
	}
	return 0;
}



//��������ӭ�������ؾ�����
function OpenOrCloseUpLinePartyWnd_Trigger(%State)
{
	%Player = GetPlayer();

	//������������԰
	%AAA = GetWord(%Player.GetActivity(2002),0);
	OpenTodayGoalWnd_ListBox(1,2);

	%Tab1 = "<t f='΢���ź�' m='0' n='12' c='0xffffffff' o='0x010101ff'>";

	//��ǰ��Ծֵ
	%Activity2241[0] = GetWord(%Player.GetActivity(2241),0);
	%Activity2241[0] = (%Activity2241[0] == 0) ? 0 : %Activity2241[0];

	WelcomePartyWnd_Text_Activity.setcontent(%Tab1 @ %Activity2241[0] @ "��</t>");
	WelcomePartyWnd_Text_Activity.setposition(140,114);

	//�ѵ�½����
	WelcomePartyWnd_Text_day.setcontent(%Tab1 @ %Player.GetSignInMCount() @ "��</t>");
	WelcomePartyWnd_Text_day.setposition(166,241);

	for (%i = 0; %i < 4; %i++)
	{
		%Activity = 2246;

		//ÿ�ո���������ʾ1
		%Player.ClearMissionItem(10160 + %i); %Player.AddItemToMission(10160 + %i,1,$MeiYueFuLi_Item[1 + %i],1);
		("GetWelAwardBtn_" @ 1 + %i @ "_3").setcontent(GetFixedMissionItemText(10160 + %i));

		//ÿ�ո���������ʾ2
		%getWelAwardNeedGoal_Tab = "<t f='΢���ź�' m='0' n='11' c='0xafa35eff'>";
		("GetWelAwardNeedGoal_" @ 1 + %i).setcontent(%getWelAwardNeedGoal_Tab @ "��½" @ $MeiYueFuLi_HuoYueDu[1 + %i] @ "�����</t>");

		//������ȡ��ť����
		("GetWelAwardBtn_" @ %i + 1 @ "_1").command = "ClientOnSptAction(115, " @ %i @ ");";

		//����ȡ���
		if (GetWord(%Player.GetActivity(%Activity + %i),0) > 0)
		{
			("GetWelAwardBtn_" @ %i + 1 @ "_2").setVisible(1);	//����������ȡ��
			("GetWelAwardBtn_" @ %i + 1 @ "_1").setVisible(0);	//��������ȡ��
		}

		//������ȡ���
		else if (%Player.GetSignInMCount() < $MeiYueFuLi_HuoYueDu[%i + 1])
		{
			("GetWelAwardBtn_" @ %i + 1 @ "_2").setVisible(0);	//����������ȡ��
			("GetWelAwardBtn_" @ %i + 1 @ "_1").setVisible(1);	//�رա���ȡ��
			("GetWelAwardBtn_" @ %i + 1 @ "_1").SetActive(0);		//��ɫ����ȡ��
		}

		//������ȡ���
		else
		{
			("GetWelAwardBtn_" @ %i + 1 @ "_2").setVisible(0);	//����������ȡ��
			("GetWelAwardBtn_" @ %i + 1 @ "_1").setVisible(1);	//��������ȡ��
			("GetWelAwardBtn_" @ %i + 1 @ "_1").SetActive(1);		//��ɫ����ȡ��
		}
	}

	//���߾���
	%ActivityTab1 = "<t f='΢���ź�' b='0' m='0' n='18' c='0xffffffff' o='0x010101ff'>";
	%EncourageExp = %Player.GetEncourageExp();
	UpLinePartyWnd_Text_Experience.setcontent(%ActivityTab1 @ %EncourageExp @ "</t>");
	UpLinePartyMianFei3.command = "DrawEncourageExp();";

	//˫��ʱ��
	%ShuangBei_A = %Player.GetActivity(2000);	//��ȡ���͵�˫��ʱ��ֵ
	%ShiJian_A = GetWord(%ShuangBei_A,0) * 1;		//��ȡ���͵�˫��ʱ��ֵ

	if (%ShiJian_A <= 0)
		%ShiJian_A = 0;

	if (%ShiJian_A >= 300)
		%ShiJian_A = 300;

	//����ʣ��ʱ��
	UpLinePartyWnd_Text_Time.setcontent(%Tab1 @ 300 - %ShiJian_A @ "����" @ "</t>");
	UpLinePartyWnd_Text_Time.setposition(180,146);

	UpLinePartyMianFei4.command = "findpath(400001060);";
}

function LinePartyWndMessage(%State)
{
	if (%State == 11)%Txt = "���4����ÿ�ո��������񼴿���ȡ��ÿ�չ��ʡ���";
	else if (%State == 12)%Txt = "������ȡ�����ʽ�������";
	else if (%State == 21)%Txt = "��ɡ�ÿ�ո��������񼴿ɻ�û�Ծ���֡�";
	else if (%State == 22)%Txt = "������ȡ����Ծ���ֽ�������";
	SetScreenMessage(%Txt,$Color[5]);
}
//���������������������������;�ϲ�����������������������������������������

function OpenTodayGoalWnd_ListBox(%FenLei,%State)
{
	//��ȡ���Player
	%Player = GetPlayer();

	//���ʱ��
	%Time = GetLocalTime();
	%Time = GetWord(%Time,1) @ GetWord(%Time,2);

	//�뵱ǰʱ�䲻��ʱ���������ͨѶ
	if (GetWord(%Player.GetActivity(2002),0) < 8)
		if (GetWord(%Player.GetActivity(2002),1) !$= %Time)
			ClientOnSptAction(4,0);//���ÿɽ�

	//���ʱ��
	%Time = GetLocalTime();
	%Time = GetWord(%Time,1) @ GetWord(%Time,2);

	//��ʼ������
	("TodayGoalWnd_ListBox" @ %FenLei).clearitems();
	%A = 0; %II= 0;

	if (%FenLei $= "")
	{
		%KongGe = "   ";
		TodayGoalWnd_Tips.setcontent("");
		if (%State == 1)%Txt = "�������Խ�࣬�����󽱽������";
		else if (%State == 2)%Txt = "���4����ÿ�ո��������񼴿���ȡÿ�չ���";
		TodayGoalWndGuiTimeText.setcontent("<t f='����' m='0' v='0' n='14' c='0x00ff4eff'>" @ %Txt @ "</t>");
	}

	%Tab1 = "<t f='����_GB2312' m='0' n='16' c='0xffffffff'>";//��ɫ����-����
	%Tab2 = "<t f='����_GB2312' m='0' n='16' c='0xf3d300ff'>";//��ɫ����-�ɽ�
	%Tab3 = "<t f='����_GB2312' m='0' n='16' c='0x00ff4eff'>";//��ɫ����-�ɽ�

	%tinct[1] = $Get_Dialog_GeShi[31491];	%Icon[1] = $Icon[30];	//δ����
	%tinct[2]	= $Get_Dialog_GeShi[31491];	%Icon[2] = $Icon[31];	//��ȡ����
	%tinct[3]	= $Get_Dialog_GeShi[31491];	%Icon[3] = $Icon[32];	//������
	%tinct[4]	= $Get_Dialog_GeShi[31491];	%Icon[4] = $Icon[33];	//��ȡ����
	%tinct[5]	= $Get_Dialog_GeShi[31493];	%Icon[5] = $Icon[34];	//�������
	%tinct[6]	= $Get_Dialog_GeShi[31491];	%Icon[6] = $Icon[35];	//�������
	%tinct[7] = $Get_Dialog_GeShi[31491];	%Icon[7] = $Icon[30];	//δ����

	%txt[0] = "����1�ա�����é®";	%txt[7] = "ÿ�ա����Ǹ��ա�";
	%txt[1] = "����2�ա����㽭��";	%txt[8] = "ÿ�ա��ַ��";
	%txt[2] = "����3�ա��������";	%txt[9] = "ÿ�ա����ܵж�������";
	%txt[3] = "����4�ա�С������";	%txt[10] = "ÿ�ա�ѭ������";
	%txt[4] = "����5�ա����ҷ�Դ";	%txt[11] = "ÿ�ա������ף����";
	%txt[5] = "����6�ա�����ȵ��";	%txt[12] = "ÿ�ա��ɶ����ݡ�";
	%txt[6] = "����7�ա���������";	%txt[13] = "ÿ�ա���������";
	%txt[14] = "ÿ�ա���������";
	%txt[15] = "ÿ�ա�ý�������";
	if (%State == 1)
	{
		%A = 0; %II = 7;
	}
	else
	{
		%A = 7; %II = 16;
	}

	for (%i = %A; %i < %II; %i++)
	{
		//��ȡ����Id
		%Mid = $JRMB_Mission[%i];

		//��ȡ����״̬
		%AAA = DailyGoalWnd_fettle(%Mid,%i);

		//��������ɫ�趨
		if (%AAA == 2) %Tab = %Tab2;
		else if (%AAA == 4) %Tab = %Tab3;
		else %Tab = %Tab1;

		//��ɫ + ������
		%KKK[2] = %Tab @ %txt[%i];

		//������ť
		%button = "</t><c cid='" @ Get_TraceButton() @ "' cmd='\"SurprisePartyWnd_AcceptTask_Accept("@ %FenLei @");\",\""@%Icon[%AAA]@"</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' /><t>";

		("TodayGoalWnd_ListBox" @ %FenLei).AddItem(%KKK[2] @ "</t>"TAB"<t>" @ %KongGe @ %button @ "</t>",%i);
		if (%FenLei $= "")
			("TodayGoalWnd_ListBox" @ %FenLei).SetCommand("SurprisePartyWnd_ListBox_Choose("@%State@");",%i);
	}
}

function EveryDayGoalWnd()
{
	%Player = GetPlayer();

	%PositionX = EveryDayGoalWndListBox_Scroll.getScrollPositionX();
	%PositionY = EveryDayGoalWndListBox_Scroll.getScrollPositionY();

	//���ô򿪽���
	//	EveryDayGoalWnd.setVisible(1);

	//�����Ŀ
	EveryDayGoalWnd_ListBox.clearitems();

	%Tab2 = "<t f='΢���ź�' m='0' n='11' v='0' c='0xffffffff' u='0x352d13ff' >";
	%Tab3 = "<t f='΢���ź�' m='0' n='11' v='0' c='0xffffffff' >";
	%Tab4 = "<t f='΢���ź�' m='0' n='11' v='0' c='0x00ff4eff' u='0x423818ff' >";
	%Tab5 = "<t f='΢���ź�' m='0' n='11' v='0' c='0x00ff4eff' >";

	//��Ծ�ȶһ�

	EveryDayNeedGoal_2.setcontent(%EveryDayNeedGoal_Tab @ " �ﵽ" @ $MeiRiLiLian_HuoYueDu[2] @ "���Ծ��</t>");
	EveryDayNeedGoal_3.setcontent(%EveryDayNeedGoal_Tab @ " �ﵽ" @ $MeiRiLiLian_HuoYueDu[3] @ "���Ծ��</t>");
	EveryDayNeedGoal_4.setcontent(%EveryDayNeedGoal_Tab @ " �ﵽ" @ $MeiRiLiLian_HuoYueDu[4] @ "���Ծ��</t>");

	for (%i = 1; %i <= 25; %i++)
	{
		if ((%i == 7) && (%i[26] == 0))
		{
			%i = 26;
			%i[26] = 1;
		}

		if (($EveryDayGoal_Hide[GetWord($EveryDayGoal[0,%i],1)] == 1) && (GetWord($EveryDayGoal[0,%i],0) == 1))
			continue;

		%Tab1[1] = "<t f='΢���ź�' m='0' n='12' v='0' c='0x00b0f0ff' u='0x423818ff' >";
		%Tab1[2] = "<t f='΢���ź�' m='0' n='13' v='0' c='0xf3d300ff' u='0x423818ff' >";
		%Tab1[3] = "<t f='΢���ź�' m='0' n='12' v='0' c='0x00ff4eff' u='0x423818ff' >";

		%Activity[%i] = GetWord(%Player.GetActivity(GetWord($EveryDayGoal[0,%i],2)),0);
		%Activity[%i] = (%Activity[%i] == 0) ? 0 : %Activity[%i];

		//��Ŀ1�����ͼƬ��
		if (GetWord($EveryDayGoal[0,%i],0) == 1)
		{
			if (%Activity[%i] >= GetWord($EveryDayGoal[0,%i],3))
				%Txt[1,%i] = "<t>  </t><i s='gameres/gui/images/DTOnline_BiaoTi_1.png' pw='14' ph='14' /> ";
			else
				%Txt[1,%i] = "<t>  </t><i s='gameres/gui/images/DTOnline_BiaoTi_2.png' pw='14' ph='14' /> ";
		}
		else
		{
			if ($EveryDayGoal_Hide[GetWord($EveryDayGoal[0,%i],1)] == 0)
				%Icon = "<i s='gameres/gui/images/GUIbutton03_1_008.png' pw='18' ph='18' /> ";
			else
				%Icon = "<i s='gameres/gui/images/GUIbutton03_1_007.png' pw='18' ph='16' /> ";


			%Txt[1,%i] = "<c cid='" @ Get_TraceButton() @ "' cmd='\"FunctionEveryDayGoal_Hide(" @ %i @ ");\",\""@%Icon@"</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />";
		}

		//����2�����⣩
		switch (%i)
		{
			case 1: %png = "<i s='gameres/gui/images/DTOnline_zxjl.png'pw='130' ph='18' /> ";
			case 6: %png = "<i s='gameres/gui/images/DTOnline_bzhd.png'pw='130' ph='18' /> ";
			case 13: %png = "<i s='gameres/gui/images/DTOnline_sdhd.png'pw='130' ph='18' /> ";
			case 17: %png = "<i s='gameres/gui/images/DTOnline_tzhd.png'pw='130' ph='18' /> ";
			case 23: %png = "<i s='gameres/gui/images/DTOnline_qthd.png'pw='130' ph='18' /> ";
		}

		%Txt[2,%i] = $EveryDayGoal[1,%i];
		%TxtNum[2,%i] = 24 - strlen(%Txt[2,%i]);
		for (%ii = 0; %ii < %TxtNum[2,%i]; %ii++)
			%Txt[2,%i] = %Txt[2,%i] @ " ";

		if (GetWord($EveryDayGoal[0,%i],0) == 0)
			%Txt[2,%i] = %png;
		else if (%Activity[%i] >= GetWord($EveryDayGoal[0,%i],3))
			%Txt[2,%i] = %Tab1[3] @ %Txt[2,%i];
		else
			%Txt[2,%i] = %Tab1[1] @ %Txt[2,%i];

		if (GetWord($EveryDayGoal[0,%i],0) == 1)
		{
			//���⣨��������
			if (%Activity[%i] >= GetWord($EveryDayGoal[0,%i],3))
				%Txt[3,%i] = %Tab4 @ "�Ѵ��</t>";
			else
				%Txt[3,%i] = %Tab2 @ " " @ %Activity[%i] @ "/" @ GetWord($EveryDayGoal[0,%i],3) @ "</t>";

			//���⣨��Ծ�Ƚ�����
			if (%Activity[%i] >= GetWord($EveryDayGoal[0,%i],3))
				%Txt[4,%i] = %Tab5 @ "+" @ GetWord($EveryDayGoal[0,%i],4) @ "</t>";
			else
				%Txt[4,%i] = %Tab3 @ "+" @ GetWord($EveryDayGoal[0,%i],4) @ "</t>";
		}
		else if (%i == 1)
		{
			%Txt[3,%i] = "<t f='����' m='0' b='1' n='12' gct='0xffff00ff' gcb='0xd9680dff'>�����</t>";
			%Txt[4,%i] = "<t f='����' m='0' b='1' n='12' gct='0xffff00ff' gcb='0xd9680dff'>����</t>";
		}

		EveryDayGoalWnd_ListBox.AddItem(%Txt[1,%i] TAB %Txt[2,%i] @ "</t>" TAB %Txt[3,%i] TAB %Txt[4,%i],%i);
		EveryDayGoalWnd_ListBox.SetCommand("EveryDayGoalWnd_ListBox_Choose(" @ %i @ ");",%i);

		if ((%i == 26) && (%i[26] == 1))
			%i = 6;
	}

	//��ǰ��Ծ����ʾ
	%CurDynamicNUM_Tab1 = "<t f='����' m='0' b='1' n='14' gct='0xaaa68cff' gcb='0xe5c614ff'>";
	%CurDynamicNUM_Tab2 = "<t f='΢���ź�' m='0' b='0' n='12' c='0xffffffff' o='0x352d13ff'>";

	%Activity2241[0] = GetWord(%Player.GetActivity(2241),0);
	%Activity2241[0] = (%Activity2241[0] == 0) ? 0 : %Activity2241[0];

	CurDynamicNUM.setcontent(%CurDynamicNUM_Tab1 @ "����ǰ��Ծ�ȣ�</t>" @ %CurDynamicNUM_Tab2 @ %Activity2241[0] @ "</t>");

	//����ÿ����������������
	CurCompletedMissionNUM.setcontent("<t f='΢���ź�' m='0' n='12' c='0xffffffff' >" @ %Activity2241[0] @ "/145</t>");

	//����ÿ������������
	%MissionEXP = %Activity2241[0] / 145;
	TodayCompletedMissionEXP.setScriptValue(%MissionEXP);

	for (%i = 0; %i < 4; %i++)
	{
		%Activity = 2242;

		//ÿ������������ʾ1
		%Player.ClearMissionItem(10150 + %i); %Player.AddItemToMission(10150 + %i,1,GetMeiRiLiLianItem(1 + %i),1);
		("GetawardBtn_" @ 1 + %i @ "_3").setcontent(GetFixedMissionItemText(10150 + %i));

		//ÿ������������ʾ2
		%EveryDayNeedGoal_Tab = "<t f='΢���ź�' m='0' n='11' c='0xafa35eff'>";
		("EveryDayNeedGoal_" @ %i + 1).setcontent(%EveryDayNeedGoal_Tab @ " �ﵽ" @ $MeiRiLiLian_HuoYueDu[1 + %i] @ "���Ծ��</t>");

		//������ȡ��ť����
		("GetawardBtn_" @ %i + 1 @ "_1").command = "ClientOnSptAction(114, " @ %i @ ");";

		//����ȡ���
		if (GetWord(%Player.GetActivity(%Activity + %i),0) > 0)
		{
			("GetawardBtn_" @ %i + 1 @ "_2").setVisible(1);	//����������ȡ��
			("GetawardBtn_" @ %i + 1 @ "_1").setVisible(0);	//�رա���ȡ��
			("GetawardBtn_" @ %i + 1 @ "_1").SetActive(0);	//��ɫ����ȡ��
		}

		//������ȡ���
		else if (GetWord(%Player.GetActivity(2241),0) < $MeiRiLiLian_HuoYueDu[%i + 1])
		{
			("GetawardBtn_" @ %i + 1 @ "_2").setVisible(0);	//����������ȡ��
			("GetawardBtn_" @ %i + 1 @ "_1").setVisible(1);	//�رա���ȡ��
			("GetawardBtn_" @ %i + 1 @ "_1").SetActive(0);	//��ɫ����ȡ��
		}

		//������ȡ���
		else
		{
			("GetawardBtn_" @ %i + 1 @ "_2").setVisible(0);	//����������ȡ��
			("GetawardBtn_" @ %i + 1 @ "_1").setVisible(1);	//��������ȡ��
			("GetawardBtn_" @ %i + 1 @ "_1").SetActive(1);	//��ɫ����ȡ��
		}
	}

	//���ù�����λ��
	EveryDayGoalWndListBox_Scroll.setScrollPosition(%PositionX,%PositionY);
}

function FunctionEveryDayGoal_Hide(%i)
{
	%Hide = $EveryDayGoal_Hide[GetWord($EveryDayGoal[0,%i],1)];
	$EveryDayGoal_Hide[GetWord($EveryDayGoal[0,%i],1)] = (%Hide == 0) ? 1 : 0;

	EveryDayGoalWnd();
}


function EveryDayGoalWnd_ListBox_Choose(%i)
{
	%Txt = EveryDayGoalWnd_Txt2(%i);
	EveryDayGoalWnd_MSG.setcontent("<t>" @ %Txt @ "</t>");
}

function EveryDayGoalWnd_Txt2(%i)
{
	%Player = GetPlayer();

	%Tab1 = "<t f='����' m='0' n='16' b='1'gct='0xffff00ff' gcb='0xd9680dff'>";
	%Tab2 = "<t f='΢���ź�' m='0' n='13' c='0xffffffff'>";
	%Tab3 = "<t f='΢���ź�' m='0' n='12' v='1' c='0x00b0f0ff'>";

	%Tab4 = "<t f='΢���ź�' m='0' n='13' v='2' u='0xbfff00ff' c='0xbfff00ff'>";
	%Tab5 = "<t f='΢���ź�' m='0' n='12' v='2' u='0xbfff00ff' c='0xbfff00ff'>";

	switch (%i)
	{
		case 1:%Txt =
			%Tab2 @ "   �������߼�����ɵ��������򵥡����㡢��ݣ�</t>";

		case 2:%Txt =
			%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " ��¼һ����Ϸ</t><b/>" @
			%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 1���Ծ��</t>";

		case 3:
			%Time = 900 - %Player.GetSchbuff(1040);
			%TimeFen = mFloor(%Time / 60);
			%TimeMiao = %Time - %TimeFen * 60;

			%Txt =
				%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " �����ۼ�����15����</t><b/>" @
				%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 2���Ծ��</t><b/>" @
				%Tab3 @ "�����ۼ�����ʱ��: " @ %TimeFen @ "��" @ %TimeMiao @ "�룩</t>";

		case 4:
			%Time = 1800 - %Player.GetSchbuff(1041);
			%TimeFen = mFloor(%Time / 60);
			%TimeMiao = %Time - %TimeFen * 60;

			%Txt =
				%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " �����ۼ�����30����</t><b/>" @
				%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 3���Ծ��</t><b/>" @
				%Tab3 @ "�����ۼ�����ʱ��: " @ %TimeFen @ "��" @ %TimeMiao @ "�룩</t>";

		case 5:
			%Time = 3600 - %Player.GetSchbuff(1042);
			%TimeFen = mFloor(%Time / 60);
			%TimeMiao = %Time - %TimeFen * 60;

			%Txt =
				%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " �����ۼ�����60����</t><b/>" @
				%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 6���Ծ��</t><b/>" @
				%Tab3 @ "�����ۼ�����ʱ��: " @ %TimeFen @ "��" @ %TimeMiao @ "�룩</t>";

		case 6:%Txt =
			%Tab2 @ "   ÿ�ձ��������������顢���߽���ʮ�ֵķ���޷�������ջ�</t>";

		case 7:%Txt =
			%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " ���10��ʥ�ؾ�������</t><b/>" @
			%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 6���Ծ��</t><b/>" @
			%Tab1 @ "���뷽ʽ:</t>" @ %Tab2 @ " ʥ�� </t>" @ Getfindpath(401005002,0,%Tab4 @ GetNpcData(401005002,1),31214) @ %Tab2 @ " ������</t>";

		case 8:%Txt =
			%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " �μ�1����Ӷ�󸱱�</t><b/>" @
			%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 8���Ծ��</t><b/>" @
			%Tab1 @ "���뷽ʽ:</t>" @ " </t><b/>" @
			%Tab2 @ "  ����</t>" @ Getfindpath(400001601,0,%Tab4 @ GetNpcData(400001601,1),31214) @
			%Tab2 @ "  ����</t>" @ Getfindpath(401002268,0,%Tab4 @ GetNpcData(401002268,1),31214);

		case 9:%Txt =
			%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " �μ�1��ʱ���Ѻۻ</t><b/>" @
			%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 8���Ծ��</t><b/>" @
			%Tab1 @ "���뷽ʽ:</t>" @ %Tab2 @ " ���� </t>" @ Getfindpath(401302001,0,%Tab4 @ GetNpcData(401302001,1),31214) @ %Tab2 @ " ������</t><b/>" @
			%Tab3 @ "�������ʱ��: 11:00��13:00 19:30��20:30��</t>";

		case 10:
			%cmd[1] = "OpenOrCloseFamilyWnd();";
			%Button[1] = "<c cid='" @ Get_TraceButton() @ "' cmd='\"" @ %cmd[1] @ "\",\"" @ %Tab4 @ "���ɽ���" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />";

			%Txt =
				%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " ���3�ΰ�������</t><b/>" @
				%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 10���Ծ��</t><b/>" @
				%Tab1 @ "���뷽ʽ:</t>" @ %Button[1] @ %Tab2 @ " ������</t>";

		case 11:%Txt =
			%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " ���3�βر�ͼ����</t><b/>" @
			%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 6���Ծ��</t><b/>" @
			%Tab1 @ "���뷽ʽ:</t>" @ %Tab2 @ " ���� </t>" @ Getfindpath(401002143,0,%Tab4 @ "����",31214) @ %Tab2 @ " ������</t>";

		case 12:%Txt =
			%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " ���5������ȡ������</t><b/>" @
			%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 10���Ծ��</t><b/>" @
			%Tab1 @ "���뷽ʽ:</t>" @ %Tab2 @ " ���� </t>" @ Getfindpath(400001295,0,%Tab4 @ GetNpcData(400001295,1),31214) @ %Tab2 @ " ������</t>";

		case 13:%Txt =
			%Tab2 @ "   �̶�ʱ���ڲ��ܲμӵĻ��������������������</t>";

		case 14:%Txt =
			%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " ���1���������ֻ</t><b/>" @
			%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 5���Ծ��</t><b/>" @
			%Tab1 @ "���뷽ʽ:</t>" @ %Tab2 @ " ʥ�� </t>" @ Getfindpath(810050101,0,%Tab4 @ "�������",31214) @ %Tab2 @ " ������</t><b/>" @
			%Tab3 @ "�� [ ������� ] �ڻʱ���ڲŻ�ˢ�� ��</t>";

		case 15:%Txt =
			%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " ���1��Ӣ����������</t><b/>" @
			%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 5���Ծ��</t><b/>" @
			%Tab1 @ "���뷽ʽ:</t>" @ %Tab2 @ " ʥ�� </t>" @ Getfindpath(400001269,0,%Tab4 @ GetNpcData(400001269,1),31214) @ %Tab2 @ " ������</t><b/>" @
			%Tab3 @ "�� 18:00��19:00 ������������һͬ�μ� ��</t>";

		case 16:%Txt =
			%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " �μ�1�οƾٻ</t><b/>" @
			%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 10���Ծ��</t><b/>" @
			%Tab1 @ "���뷽ʽ:</t>" @ %Tab2 @ " ʥ�� </t>" @ Getfindpath(401303001,0,%Tab4 @ GetNpcData(401303001,1),31214) @ %Tab2 @ " ������</t><b/>" @
			%Tab3 @ "�� ÿ��һ�����������ϵ�21�㿪�� ��</t>";

		case 17:%Txt =
			%Tab2 @ "   ��Ҫ�൱��ʵ�����Ŷ���ϲ�����ɵĻ����������ĸ��������ȡ�</t>";

		case 18:%Txt =
			%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " �μ�1�ξ��鸱������ӣ�</t><b/>" @
			%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 10���Ծ��</t><b/>" @
			%Tab1 @ "���뷽ʽ:</t>" @ %Tab2 @ " ����������⸱���������Ŀ��</t><b/>" @
			%Tab3 @ " ���������߸�կ��60�� - ���� </t>" @ Getfindpath(400001603,0,%Tab5 @ "�߸�կ",31214) @ %Tab3 @ "������</t><b/>" @
			%Tab3 @ " �������ι�֮ս��70�� - ���� </t>" @ Getfindpath(400001604,0,%Tab5 @ "���ι�",31214) @ %Tab3 @ "������</t><b/>" @
			%Tab3 @ " �������յ�һս��80�� - ���� </t>" @ Getfindpath(400001605,0,%Tab5 @ "��һս",31214) @ %Tab3 @ "������</t><b/>" @
			%Tab3 @ " �����ʶ�����  ��90�� - ���� </t>" @ Getfindpath(400001606,0,%Tab5 @ "�ʶ�����",31214) @ %Tab3 @ "������</t>";

		case 19:%Txt =
			%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " �μ�1�ξ��鸱����Ӣ�ۣ�</t><b/>" @
			%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 5���Ծ��</t><b/>" @
			%Tab1 @ "���뷽ʽ:</t>" @ %Tab2 @ " ����������⸱���������Ŀ��</t><b/>" @
			%Tab3 @ " ���������߸�կ��60�� - ���� </t>" @ Getfindpath(400001603,0,%Tab5 @ "�߸�կ",31214) @ %Tab3 @ "������</t><b/>" @
			%Tab3 @ " �������ι�֮ս��70�� - ���� </t>" @ Getfindpath(400001604,0,%Tab5 @ "���ι�",31214) @ %Tab3 @ "������</t><b/>" @
			%Tab3 @ " �������յ�һս��80�� - ���� </t>" @ Getfindpath(400001605,0,%Tab5 @ "��һս",31214) @ %Tab3 @ "������</t><b/>" @
			%Tab3 @ " �����ʶ�����  ��90�� - ���� </t>" @ Getfindpath(400001606,0,%Tab5 @ "�ʶ�����",31214) @ %Tab3 @ "������</t>";

		case 20:%Txt =
			%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " �μ�1����ս��������</t><b/>" @
			%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 6���Ծ��</t><b/>" @
			%Tab1 @ "���뷽ʽ:</t>" @ %Tab2 @ " ���� </t>" @ Getfindpath(400001149,0,%Tab4 @ GetNpcData(400001149,1),31214) @ %Tab2 @ " ������</t>";

		case 21:%Txt =
			%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " �μ�1��а��Ĺ����</t><b/>" @
			%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 6���Ծ��</t><b/>" @
			%Tab1 @ "���뷽ʽ:</t>" @ %Tab2 @ " ���� </t>" @ Getfindpath(400001023,0,%Tab4 @ GetNpcData(400001023,1),31214) @ %Tab2 @ " ������</t>";

		case 22:%Txt =
			%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " �μ�1������⸱��</t><b/>" @
			%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 6���Ծ��</t><b/>" @
			%Tab1 @ "���뷽ʽ:</t>" @ " </t><b/>" @
			%Tab2 @ "  ����</t>" @ Getfindpath(401001015,0,%Tab4 @ GetNpcData(401001015,1),31214) @
			%Tab2 @ "  ����</t>" @ Getfindpath(401002176,0,%Tab4 @ GetNpcData(401002176,1),31214);

		case 23:%Txt =
			%Tab2 @ "   ������ɫ�Ļ���������ѡ����Ȥ�Ĳ��롣</t>";

		case 24:%Txt =
			%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " ��ɽ�������</t><b/>" @
			%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 6���Ծ��</t><b/>" @
			%Tab1 @ "���뷽ʽ:</t>" @ %Tab2 @ " 19��00 - 19��30 �������</t>";

		case 25:%Txt =
			%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " ��ȡ����֮��</t><b/>" @
			%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 8���Ծ��</t><b/>" @
			%Tab1 @ "���뷽ʽ:</t>" @ %Tab2 @ " ���� </t>" @ Getfindpath(401131006,0,%Tab4 @ GetNpcData(401131006,1),31214) @ %Tab2 @ " ������</t>";

		case 26:%Txt =
			%Tab1 @ "���Ŀ��:</t>" @ %Tab2 @ " �μ�1��ʮ��·��������</t><b/>" @
			%Tab1 @ "��ɽ���:</t>" @ %Tab2 @ " 8���Ծ��</t><b/>" @
			%Tab1 @ "���뷽ʽ:</t>" @ " </t><b/>" @
			%Tab2 @ "  ����</t>" @ Getfindpath(401305001,0,%Tab4 @ GetNpcData(401305001,1),31214) @
			%Tab2 @ "  ����</t>" @ Getfindpath(401305002,0,%Tab4 @ GetNpcData(401305002,1),31214);
	}

	return %Txt;
}


//�������Ƿ��н�������ȡ
function MeiYueFuLi_NoLingQu(%Player)
{
	for (%i = 0; %i < 4; %i++)
	{
		%Activity = 2246 + %i;

		//����ȡ���
		if (GetWord(%Player.GetActivity(%Activity),0) > 0)
			continue;

		//������ȡ���
		if (%Player.GetSignInMCount() < $MeiYueFuLi_HuoYueDu[%i + 1])
			continue;

		return 1;
	}

	return 0;
}
