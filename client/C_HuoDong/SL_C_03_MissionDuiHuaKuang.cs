//����������������������Ի��򡿡������������ܴ���Ү����������������������������
//����������������������Ի��򡿡����������Ķ԰����֡���������������������������
//����������������������Ի��򡿡�����������ѡ���������������������������
//����������������������Ի��򡿡��������رնԻ��򡿡���������������������������

//����������������������Ի��򡿡�����������ѡ����ء���������������������������

//����������������������Ի��򡿡������������������֡���������������������������
//����������������������Ի��򡿡�����������ѡ�����֡���������������������������
//����������������������Ի��򡿡����������÷������֡���������������������������

//����������������������Ի��򡿡����������òμӻѡ�����������������������
//����������������������Ի��򡿡�������������һ��ѡ�������������������������
//����������������������Ի��򡿡����������û����ѡ�����������������������

//����������������������Ի��򡿡�����������ѡ�������������������������������
//����������������������Ի��򡿡�������ʥ��ʥ����������������������������������
//����������������������Ի��򡿡�����������ޡ���������������������������������
//����������������������Ի��򡿡��������������������������������������������
//����������������������Ի��򡿡���������Ԫ�ԡ���������������������������������
//����������������������Ի��򡿡�����������ȡ����������������������������������
//����������������������Ի��򡿡�����������ʦͽ��������������������������������
//����������������������Ի��򡿡�������ˮ��ʯ����������������������������������
//����������������������Ի��򡿡����������ƻ��񡿡�����������������������������
//����������������������Ի��򡿡������������ְ����ȡٺ»����������������������

//�����������������������������桿����������˺�Ǳ�����������ߡ���������������


//����������������������Ի��򡿡������������ܴ���Ү����������������������������
function OpenNPC_MissionTS(%NpcID,%State)
{
	%Player = GetPlayer();

	//���ѡ��
	clearButton();
	ClearMissionbutton();

	//�ر�������
	SpecialMissionDialog2WndGui.setvisible(0);
	SpecialMissionDialog3WndGui.setvisible(0);

	//���Ķ԰�
	SpecialGUIDialogText.setcontent(Get_Npc_DialogTS(%NpcID));

	//ͷ������
	%NPC_MoXing = GetNpcData(%NpcID,5);
	SpecialGUIDialogNpcIcon.setBitmap("gameres/Data/icon/newhead/new_" @ %NPC_MoXing);

	//����ѡ��
	OpenNPC_Mission_Normal(%NpcID,%State);

	//�Ի�ѡ��
	OpenNPC_Mission_Special(%NpcID,%State);

	//���������
	if (SpecialMissionDialogWndGui.isvisible() == 0)
		OpenOrCloseSpecialMissionDialogWnd();
}
//����������������������Ի��򡿡������������ܴ���Ү����������������������������

//����������������������Ի��򡿡����������Ķ԰����֡���������������������������
function Get_Npc_DialogTS(%NpcID)
{
	if ($NpcRandomDialog[%NpcID,1] !$= "")
	{
		%D = 1;
		if ($NpcRandomDialog[%NpcID,2] !$= ""){ %D = 2; }
		if ($NpcRandomDialog[%NpcID,3] !$= ""){ %D = 3; }

		return $Get_Dialog_GeShi[50010] @ $NpcRandomDialog[%NpcID,GetRandom(1,%D)] @ "</t>";
	}
	else
		return $Get_Dialog_GeShi[50010] @ "��ӭ���������ؾ���������</t><b/><b/>";
}
//����������������������Ի��򡿡����������Ķ԰����֡���������������������������

//����������������������Ի��򡿡�����������ѡ���������������������������
function ClearMissionbutton()
{
	SpecialMissionDialog4_button.setvisible(0);
	SpecialGUIDialog4AccpetBtn.setvisible(0);
	SpecialGUIDialog4CancelBtn.setvisible(0);
}
//����������������������Ի��򡿡�����������ѡ���������������������������

//����������������������Ի��򡿡��������رնԻ��򡿡���������������������������
function closeNPC_MissionTS(%Type)
{
	switch (%Type)
	{
		case 1://�ر����н���
			CloseSpecialMissionDialogWndGui();//�ر���������Ի���
			CloseSpecialMissionDialog2WndGuiSchedule();	//�رս����񴰿�-��ϸ����
			CloseSpecialMissionDialog3WndGuiSchedule();	//�ر�������񴰿�-�������

		case 2://�ر����н���
			SpecialMissionDialogWndGui.setvisible(0); 	//�ر���������Ի���
			SpecialMissionDialog3WndGui.setvisible(0);	//�ر�������񴰿�-�������
			SpecialMissionDialog2WndGui.setvisible(0);	//�ر�������񴰿�-�������
	}
}
//����������������������Ի��򡿡��������رնԻ��򡿡���������������������������

//����������������������Ի��򡿡�����������ѡ����ء���������������������������
function OpenNPC_Mission_Normal(%NpcID,%State)
{
	if (%State != 0)
		return;

	%Player = GetPlayer();
	%NpcA_Mid = GetStartNpcMission(%NpcID);		//������ȡ������
	%NpcX_Mid = GetMidTalkNpcMission(%NpcID);	//���ڽ���������
	%NpcZ_Mid = GetEndNpcMission(%NpcID);			//������ɵ�����

	%NpcA_Mid_MaxNum = GetWordCount(%NpcA_Mid);	//������ȡ����������
	%NpcX_Mid_MaxNum = GetWordCount(%NpcX_Mid);	//���ڽ�������������
	%NpcZ_Mid_MaxNum = GetWordCount(%NpcZ_Mid);	//������ɵ���������

	//������ǰNPC���пɽ������񣬲�������Ӧѡ��
	for (%z = 0; %z < %NpcZ_Mid_MaxNum; %z++)
	{
		%Mid = GetWord(%NpcZ_Mid,%z);												//��ȡ����ID
		if (!Mission_End_SeeOption(%Player,%Mid))							//�Ƿ���ʾ(�����ж�)
			if (CanDoThisMission(%Player,%Mid,2,0,0) $= "")	//�Ƿ���ʾ(�����ж�)
				SetMission(%NpcID,%Mid,910);
	}

	//������ǰNPC������;�Ի������񣬲�������Ӧѡ��
	for (%z = 0; %z < %NpcX_Mid_MaxNum; %z++)
	{
		%Mid = GetWord(%NpcX_Mid,%z);															//��ȡ����ID
		if (CanDoMidwayMission(%NpcID,%Player,%Mid,0,0,0) > 0)	//�Ƿ���ʾ(�����ж�)
			SetMission(%NpcID,%Mid,210);
	}

	//������ǰNPC���пɽӵ����񣬲�������Ӧѡ��
	for (%a = 0; %a < %NpcA_Mid_MaxNum; %a++)
	{
		%Mid = GetWord(%NpcA_Mid,%a);											//��ȡ����ID
		if (!Mission_Begin_SeeOption(%Player,%Mid))							//�Ƿ���ʾ(�����ж�)
			if (CanDoThisMission(%Player,%Mid,1,0,0) $= "")	//�Ƿ���ʾ(�����ж�)
			{
				SetMission(%NpcID,%Mid,110);
			}
	}
}

//����������������������Ի��򡿡�����������ѡ����ء���������������������������


//����������������������Ի��򡿡��������ӽ�������ء���������������������������
function SetMission(%NpcID,%Mid,%Dialog)
{
	if ($SetMission == 5)
		return;

	%Player = GetPlayer();

	OpenNPC_Mission_AN();

	%kind       	= GetMissionKind(%Mid);
	%Mid_LeiXin 	= $MissionKind[%kind,2];

	if (%kind == 10)
		%GeShi[110] = $Get_Dialog_GeShi[50021];
	else
		%GeShi[110] = $Get_Dialog_GeShi[50011];

	//��ȡ����ѡ������
	if (%Dialog == 110)%Txt = GetMissionIcon(%Mid) @ %GeShi[110] @ %Mid_LeiXin @ "��" @ GetMission_Name(%Player,%Mid,3) @ "</t>";		//��ȡ
	else if (%Dialog == 210)%Txt = $Icon[4] @ $Get_Dialog_GeShi[50012] @ "�Ի� ��" @ GetMission_Name(%Player,%Mid,3) @ "</t>";												//��;
	else if (%Dialog == 910)%Txt = $Icon[2] @ $Get_Dialog_GeShi[50012] @ %Mid_LeiXin @ "��" @ GetMission_Name(%Player,%Mid,3) @ "����ɣ�</t>";				//���
	("ReciveMissionBtn" @ $SetMission).settext(%Txt);

	//��ȡ����ѡ���
	if (%Dialog == 110)("ReciveMissionBtn" @ $SetMission).command = "SetMission110(" @ %NpcID @ ","@ %Mid @ ");ZhiYin_Mission(2," @  %Mid @ ","@ %Dialog @ ");";
	else if (%Dialog == 210)("ReciveMissionBtn" @ $SetMission).command = "SetMission210(" @ %NpcID @ ","@ %Mid @ ");ZhiYin_Mission(3," @  %Mid @ ","@ %Dialog @ ");";
	else if (%Dialog == 910)("ReciveMissionBtn" @ $SetMission).command = "SetMission910(" @ %NpcID @ ","@ %Mid @ ");ZhiYin_Mission(4," @  %Mid @ ","@ %Dialog @ ");";

	//ָ��
	ZhiYin_Mission(1,%Mid,%Dialog);
}

function ZhiYin_Mission(%tey,%Mid,%Dialog)
{
	return;
}
function SetMission110(%NpcID,%Mid)
{
	%Player = GetPlayer();

	//�ر�������
	SpecialMissionDialogWndGui.setvisible(0);	//�ر���������Ի���
	SpecialMissionDialog3WndGui.setvisible(0);	//�ر�������񴰿�-�������

	//����ȡ�������
	OpenSpecialMissionDialog2WndGui();

	//SpecialGUIDialog2NpcIcon //��������ͷ��

	//������������
	%TxtA = eval("Mission" @ %Mid @ "Dialog" @ "(%Npc, %Player, %Mid, 10002);");

	//������
	%TxtB = GetMissionHortation(%Mid,3,10050);

	SpecialGUIDialog2Text.setcontent($Get_Dialog_GeShi[50013] @ %TxtA @ "<b/>" @ $Icon[100] @ "<b/>" @ %TxtB @ "</t>");

	SpecialGUIDialog2Awards.setcontent(%TxtB);

	//���ܰ�ť
	SpecialGUIDialog2AccpetBtn.command = "ClientOnSptAction(29, "@%Mid@");closeNPC_MissionTS(2);Closeupgrade_modelchoiceGui();";

	//ȡ����ť
	SpecialGUIDialog2CancelBtn.command = "OpenNPC_MissionTS("@%NpcID@", 0);";

	//ͷ������
	%NPC_MoXing = GetNpcData(%NpcID,5);
	SpecialGUIDialog2NpcIcon.setBitmap("gameres/Data/icon/newhead/new_" @ %NPC_MoXing);
}

function SetMission210(%NpcID,%Mid)
{
	%Player = GetPlayer();
	clearButton();
	%FlagID = CanDoMidwayMission(%NpcID,%Player,%Mid,%Type,%Other,%Msg);
	ClientOnSptAction(34,%Mid @ %FlagID - 1150);
	OpenNPC_Mission_ZT(300 + (%FlagID - 1150) @ %Mid);
	OpenNPC_Mission_HH(%NpcID,0);
}

function SetMission910(%NpcID,%Mid)
{
	%Player = GetPlayer();

	//�ر�������
	SpecialMissionDialogWndGui.setvisible(0);	//�ر���������Ի���
	SpecialMissionDialog2WndGui.setvisible(0);	//�ر�������񴰿�-�������

	OpenSpecialMissionDialog3WndGui();

	//�����������
	%TxtA = eval("Mission" @ %Mid @ "Dialog" @ "(%Npc, %Player, %Mid, 10005);");

	//������
	%TxtB = GetMissionHortation(%Mid,4,10050);

	SpecialGUIDialog3Text.setcontent($Get_Dialog_GeShi[50013] @ %TxtA @ "<b/>" @ $Icon[100] @ "<b/>" @ %TxtB @ "</t>");

	//��ɰ�ť
	SpecialGUIDialog3CompleteBtn.command = "ClientOnSptAction(30, "@%Mid@");";

	//ȡ����ť
	SpecialGUIDialog3ReturnBtn.command = "OpenNPC_MissionTS("@%NpcID@", 0);";

	//ͷ������
	%NPC_MoXing = GetNpcData(%NpcID,5);
	SpecialGUIDialog3NpcIcon.setBitmap("gameres/Data/icon/newhead/new_" @ %NPC_MoXing);
}
//����������������������Ի��򡿡��������ӽ�������ء���������������������������

//����������������������Ի��򡿡������������������֡���������������������������
function OpenNPC_Mission_XL(%DialogID)
{
	%Player = GetPlayer();
	%Txt = GetDialogText(0,%Player,%DialogID,0);
	SpecialGUIDialogText.setcontent($Get_Dialog_GeShi[50016] @ %Txt @ "</t>");
}
//����������������������Ի��򡿡�������������;���֡���������������������������
function OpenNPC_Mission_ZT(%DialogID)
{
	%Player = GetPlayer();
	%Txt = GetDialogText(0,%Player,%DialogID,0);
	SpecialGUIDialogText.setcontent($Get_Dialog_GeShi[50016] @ %Txt @ "</t>");
}

//����������������������Ի��򡿡�����������ѡ�����֡���������������������������
function OpenNPC_Mission_XX(%NpcID,%DialogID,%command)
{
	%Player = GetPlayer();

	//������ť
	OpenNPC_Mission_AN();

	%Txt = GetDialogText(0,%Player,%DialogID,0);
	("ReciveMissionBtn" @ $SetMission).settext(%Txt);
	("ReciveMissionBtn" @ $SetMission).command = "OpenNPC_MissionTS("@%NpcID@", "@%command@");";
	("ReciveMissionBtn" @ $SetMission).Visible = "1";
}

function OpenNPC_Mission_AN()
{
	$SetMission++;
	CreateNpcDialogBtn();
}
//����������������������Ի��򡿡����������÷������֡���������������������������
function OpenNPC_Mission_HH(%NpcID,%command)
{
	OpenNPC_Mission_AN();

	%Txt =  $Icon[14] @ $Get_Dialog_GeShi[50016] @ "������һ��";
	("ReciveMissionBtn" @ $SetMission).settext(%Txt);
	("ReciveMissionBtn" @ $SetMission).command = "OpenNPC_MissionTS("@%NpcID@", "@%command@");";
}

//����������������������Ի��򡿡����������òμӻѡ�����������������������
function OpenNPC_Mission_CJHD(%NpcID,%Command)
{
	SpecialMissionDialog4_button.setposition(746,165 + 30);
	SpecialMissionDialog4_button.setvisible(1);
	SpecialGUIDialog4AccpetBtn.setvisible(1);
	SpecialGUIDialog4AccpetBtn.command = "OpenNPC_MissionTS("@%NpcID@", "@%command@");";
	SpecialGUIDialog4AccpetBtn.setProfile("DTMissionDialogWnd4GuiBtn_Profile");
}

//����������������������Ի��򡿡�������������һ��ѡ�������������������������
function OpenNPC_Mission_XYB(%NpcID,%Command)
{
	SpecialMissionDialog4_button.setposition(746,165 + 30);
	SpecialMissionDialog4_button.setvisible(1);
	SpecialGUIDialog4AccpetBtn.setvisible(1);
	SpecialGUIDialog4AccpetBtn.command = "OpenNPC_MissionTS("@%NpcID@", "@%command@");";
	SpecialGUIDialog4AccpetBtn.setProfile("DTMissionDialogWnd4GuiBtn_Profile1");
}

//����������������������Ի��򡿡����������û����ѡ�����������������������
function OpenNPC_Mission_HDHH(%NpcID,%Command)
{
	SpecialMissionDialog4_button.setposition(746,165 + 30);
	SpecialMissionDialog4_button.setvisible(1);
	SpecialGUIDialog4CancelBtn.setvisible(1);
	SpecialGUIDialog4CancelBtn.command = "OpenNPC_MissionTS("@%NpcID@", "@%command@");";
}
