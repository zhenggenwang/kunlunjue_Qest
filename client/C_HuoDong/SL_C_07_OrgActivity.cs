//=============================================================================
// �ĵ�˵��:���ɻ����
// ����ʱ��:2018-03-19
// ������: Irelia

// �޸���: 
// �޸�ʱ��: 
//=============================================================================

//�������������ɻ���桿���������������ȡ����������������
//�������������ɻ���桿������������ݻ�ȡ����������������

//�������������ɻ���桿������������ƻ�ȡ����������������
function GetOrgActivityNumber()//�����
{
	return 9;
}
function GetOrgActivityName(%index)//�����
{
	//echo("����ƻ�ȡ====" @ %index);
	switch (%index)
	{
		case 0: return  $Get_Dialog_GeShi[31429] @ "ÿ�չ���</t>";
		case 1: return  $Get_Dialog_GeShi[31429] @ "���ɾ���</t>";
		case 2: return  $Get_Dialog_GeShi[31429] @ "�����ħ</t>";
		case 3: return  $Get_Dialog_GeShi[31429] @ "�ռ�����</t>";
		case 4: return  $Get_Dialog_GeShi[31429] @ "�����칬</t>";
		case 5: return  $Get_Dialog_GeShi[31429] @ "�����ؾ�</t>";
		case 6: return  $Get_Dialog_GeShi[31429] @ "ȺӢ���</t>";
		case 7: return  $Get_Dialog_GeShi[31429] @ "���޾�</t>";
		case 8: return  $Get_Dialog_GeShi[31429] @ "���������</t>";
		case 9: return  $Get_Dialog_GeShi[31429] @ "��ħ�ǹ���ս</t>";
		case 10:return  $Get_Dialog_GeShi[31429] @ "���ս</t>";
	}
}

function GetOrgActivitysituation(%index)//������
{
	%TitleA = $Get_Dialog_GeShi[31416];//�����
	%TitleB = $Get_Dialog_GeShi[31429];//û���
	%Player = GetPlayer();
	switch (%index)
	{
		case 0: %MaxVal = 1; %Val = GetSrc(%Player, 195);//"ÿ�չ���";
		case 1: %MaxVal = 1; %Val = GetSrc(%Player, 196);//"���ɾ���";
		case 2: %MaxVal = 1; %Val = GetSrc(%Player, 59);//"�����ħ";
		case 3: %MaxVal = 1; %Val = GetSrc(%Player, 197);//"�ռ�����";
		case 4: %MaxVal = 2; %Val = GetAct(%Player, 4102, 0) * 1;//"�����칬";
		case 5: %MaxVal = 1; %Val = GetAct(%Player, 4103, 0) * 1;//"�����ؾ�";
		case 6: %MaxVal = 1; %Val = GetSrc(%Player, 3);//"ȺӢ���";
		case 7: %MaxVal = 4; %Val = GetSrc(%Player, 191) + GetSrc(%Player, 192) + GetSrc(%Player, 193) + GetSrc(%Player, 194);//"���޾�";
		case 8: //"���������";
			%MaxVal = 7;
			%Act0 = GetAct(%Player, 4104, 0) * 1;
			if (%Act0 == 0)
				%Val = 0;
			for (%i = 1; %i<= 9; %i++)
			{
				if (!CheckBit(%num, %bit))
				{
					%Record = %i - 1;
					break;
				}
			}
			%Val = %Record;
		case 9: //"��ħ�ǹ���ս";
		case 10://"���ս";
	}
	//echo("%Val ===" @ %Val @ "     %MaxVal===" @ %MaxVal);
	if (%index <= 7)
	{
		if (%MaxVal == %Val)
			%Txt = %TitleA @ "�����</t>";
		else
			%Txt = %TitleB @ "����ɣ�" @ %Val @ "/" @ %MaxVal @ "</t>";
	}
	else if (%index == 8)
	{
		%LocalWeek = GetLocalWeek();	//�жϿ�������
		if (%LocalWeek == 0 || %LocalWeek == 6)
		{
			if (%MaxVal == %Val)
				%Txt = %TitleA @ "�����</t>";
			else
				%Txt = %TitleB @ "����ɣ�" @ %Val @ "/" @ %MaxVal @ "</t>";
		}
		else
			%Txt = %TitleB @ "��ĩ����</t>";
	}
	else
	{
		if (%MaxVal == %Val)
			%Txt = %TitleA @ "�����</t>";
		else
			%Txt = %TitleB @ "����ɣ�" @ %Val @ "/" @ %MaxVal @ "</t>";
	}
	//echo("����Ȼ�ȡ====" @ %index @ "   " @ %Txt);
	return %Txt;
}
//�������������ɻ���桿������������ƻ�ȡ����������������



//�������������ɻ���桿������������ݻ�ȡ����������������
function KLJFactionActivityTiTleButtonCommand(%index)
{
	%Player = GetPlayer();
	$NowFactionActivityButtonRecord = %index;
	%GeShi = 31403;

	KLJFactionActivityJoinBtn.Setvisible(0);
	switch (%index)
	{
		case 0: //"ÿ�չ���";
			%Text[0] =
				"<t>ÿ����ڴ���ȡһ�ΰ��ɹ��ʡ�</t><b/><b/>" @
				"<t>���ɹ��ʵ���������������Ӱ�죺</t><b/>" @
				"<t>  1�������ڵİ��ɵȼ�</t><b/>" @
				"<t>  2���ڰ������ְλ</t><b/>" @
				"<t>  3����ɫ�ȼ�</t><b/>" @
				"<t>  4�����ܵİ��ɹ���ֵ</t><b/><b/>";

			%Exp = $Get_Dialog_GeShi[%GeShi] @ "���齱����</t>" @ "<t>50000</t><b/>";
			%Money = $Get_Dialog_GeShi[%GeShi] @ "��Ǯ������</t>" @ ChangeMoneyText(10000) @ "<b/>";
			%HueYue = $Get_Dialog_GeShi[%GeShi] @ "���ɻ�Ծ��</t>" @ "<t>20</t><b/>";

			%Player.ClearMissionItem(%index);

			%Player.AddItemToMission(%index, 1, 105100262, 1);
			%Player.AddItemToMission(%index, 1, 105105303, 1);
			%Player.AddItemToMission(%index, 1, 105105304, 1);
			%Player.AddItemToMission(%index, 1, 105180070, 1);
			%Player.AddItemToMission(%index, 1, 105180071, 1);
			%Player.AddItemToMission(%index, 1, 105180072, 1);
			%Player.AddItemToMission(%index, 1, 105180090, 1);
			%Player.AddItemToMission(%index, 1, 105180091, 1);
			%Player.AddItemToMission(%index, 1, 105180092, 1);
			%Text = $Get_Dialog_GeShi[%GeShi] @ "�м��ʻ��������Ʒ��</t><b/>" @ GetFixedMissionItemText(%index) @ "<b/><b/>";
			%Text[1] = %Exp @ %Money @ %HueYue @ %Text;

			%Text[2] = "";
			if (GetSrc(%Player, 195) == 0)
			{
				KLJFactionActivityJoinBtn.Setvisible(1);
				KLJFactionActivityJoinBtn.settext("��ȡ����");
				KLJFactionActivityJoinBtn.Command = "JoinKLJFactionActivity(" @ %index @ ");";
			}
			else
				KLJFactionActivityJoinBtn.Setvisible(0);
		case 1: //"���ɾ���";
			%Text[0] =
				"<t>ÿ��ĵ�һ�ΰ��ɾ��׿ɻ�ô˽�����</t><b/><b/>" @
				"<t>�ý�������������Ӱ�죺</t><b/>" @
				"<t>  1�������ڵİ��ɵȼ�</t><b/>" @
				"<t>  2���ڰ������ְλ</t><b/>" @
				"<t>  3����ɫ�ȼ�</t><b/><b/>";

			%Exp = $Get_Dialog_GeShi[%GeShi] @ "���齱����</t>" @ "<t>50000</t><b/>";
			%HueYue = $Get_Dialog_GeShi[%GeShi] @ "���ɻ�Ծ��</t>" @ "<t>20</t><b/>";
			%ItemText = "";

			%Text[1] = %Exp @ %Money @ %HueYue @ %ItemText;

			%Text[2] = "<t>ǰ�� </t>"  @ Getfindpath(410010107, 0, 0, 31214) @ "<t> ������ɾ���</t><b/>";
		case 2: //"�����ħ";
			%Text[0] = 
				"<t>��ħ��Ű���ݣ����ƶ񻯣�ʱ�����ң����������ذ��·���������ħͷ���ߣ��ɻ����ĵر�������Ϊ��</t><b/><b/>" @
				"<t>������ħ�������죬����ս֮�����ݾ�ս֮�࣬����Ѱ�ϼ������ѣ����ֳ�ħ��</t><b/>";

			%Level = %Player.GetLevel();
			if (%Level <= 45) %Exp= 60000;
			else if (%Level <= 60) %Exp= 99200;
			else if (%Level <= 75) %Exp= 154400;
			else if (%Level <= 90) %Exp= 230400;
			else if (%Level <= 100)%Exp= 331200;
			%Exp = $Get_Dialog_GeShi[%GeShi] @ "���齱����</t>" @ %Exp @ "<b/>";
			%Money = $Get_Dialog_GeShi[%GeShi] @ "��Ǯ������</t>" @ ChangeMoneyText(10000) @ "<b/>";
			%HueYue = $Get_Dialog_GeShi[%GeShi] @ "���ɻ�Ծ��</t>" @ "<t>30</t><b/>";
			%ItemText = "";

			%Text[1] = %Exp @ %Money @ %HueYue @ %ItemText;

			%Text[2] = "<t>ǰ�� </t>"  @ Getfindpath(410010107, 0, 0, 31214) @ "<t> ��ȡ����</t><b/>";
		case 3: //"�ռ�����";
			%Text[0] =
				"<t>��ħ��Ű��������ʿ�����˽�Ҫ�Գ�ħΪ���Σ�</t><b/><b/>" @
				"<t>ն����ħ���ռ���ħ����Ϊ֤��</t><b/>";

			%Level = %Player.GetLevel();
			if (%Level <= 45) %Exp= 60000;
			else if (%Level <= 60) %Exp= 99200;
			else if (%Level <= 75) %Exp= 154400;
			else if (%Level <= 90) %Exp= 230400;
			else if (%Level <= 100)%Exp= 331200;
			%Exp = $Get_Dialog_GeShi[%GeShi] @ "���齱����</t>" @ %Exp @ "<b/>";
			%Money = $Get_Dialog_GeShi[%GeShi] @ "��Ǯ������</t>" @ ChangeMoneyText(10000) @ "<b/>";
			%HueYue = $Get_Dialog_GeShi[%GeShi] @ "���ɻ�Ծ��</t>" @ "<t>30</t><b/>";
			%ItemText = "";

			%Text[1] = %Exp @ %Money @ %HueYue @ %ItemText;

			%Text[2] = "<t> ǰ�� </t>"  @ Getfindpath(410010107, 0, 0, 31214) @ "<t> ��ȡ����</t><b/>";
		case 4: //"�����칬";
			%Text[0] =
				"<t>��δ����</t><b/>";
		case 5: //"�����ؾ�";
			%Level = %Player.GetLevel();
			%Level = mfloor(%Level / 10);
			if (%Level < 40)
				%level = 40;
			switch (%level)
			{
			case 40:%itemid = 105100273;//��ɫװ��(40 - 49��)
			case 40:%itemid = 105100275;//��ɫװ��(50 - 59��)
			case 40:%itemid = 105100277;//��ɫװ��(60 - 69��)
			case 40:%itemid = 105100279;//��ɫװ��(70 - 79��)
			case 40:%itemid = 105100281;//��ɫװ��(80 - 89��)
			case 40:%itemid = 105100283;//��ɫװ��(90 - 99��)
			default:%itemid = 1051002831;//
			}
			%Text[0] =
				"<t>�����������̨���������ŵ�˭�ҡ�35��������ʿ�齨3�����϶��飬�����سǵ���ʦ�Ի����ɽ�������ؾ�����ɱ�����ڹ����м��ʻ����ɫװ����</t><b/>" @	
				"<t>ȫ������71ֻ��ͨ���8ֻ��Ӣ�֣�1������֡�</t><b/>" @ 
				"<t>��Ӣ����ĵ�������ͨ������屶������ض������൱�ڶ�����������װ��</t><b/>";

			%HueYue = $Get_Dialog_GeShi[%GeShi] @ "���ɻ�Ծ��</t>" @ "<t>100</t><b/>";
			%ItemText = "";
			%Player.ClearMissionItem(%index);
			%Player.AddItemToMission(%index, 1, %itemid, 1);
			%ItemText = GetFixedMissionItemText(%index) @ "<b/><b/>";
			%Text[1] = %HueYue @ %ItemText;

			%Text[2] =
				"<t>�����</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"closestrategywndgui();OpenOrCloseActivityWnd();CreateActivityByType(2);\",\"" @ $Get_Dialog_GeShi[31214] @ "���ȫ" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>�ɲ鿴��ϸ��Ϣ</t><b/>" @
				"<t>ǰ�� </t>"  @ Getfindpath(413180001, 0, 0, 31214) @ "<t> �μӻ</t><b/>";
		case 6: //"ȺӢ���";
			%Text[0] =
				"<t>Ϧ������ʱ���������������ٻ����ܵ�ͼ�ڣ�����ʿ����ͼ�ڶ�������������ջ����������ڣ���Ϊ����������</t><b/>" @
				"<t>�����������Я������ǰȥ��ս���޽�����սʤ������ɻ�ý������ء�</t><b/>";
			
			%HueYue = $Get_Dialog_GeShi[%GeShi] @ "���ɻ�Ծ��</t>" @ "<t>20</t><b/>";
			%ItemText = "";
			%Player.ClearMissionItem(%index);

			%Player.AddItemToMission(%index, 1, 105100262, 1);
			%ItemText = GetFixedMissionItemText(%index) @ "<b/><b/>";

			%Text[1] = %HueYue @ %ItemText;

			%Text[2] =
				"<t>�����</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"closestrategywndgui();OpenOrCloseActivityWnd();CreateActivityByType(2);\",\"" @ $Get_Dialog_GeShi[31214] @ "���ȫ" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>�ɲ鿴��ϸ����</t><b/>" @
				"<t>ǰ�� </t>"  @ Getfindpath(810010107, 0, 0, 31214) @ "<t> �μӻ</t><b/>";

		case 7: //"���޾�";
			%Text[0] =
				"<t>������һ����ռ䣬��Ϊ���޾����������ؼ�̳�����ٻ�����ǿ�߽��١�</t><b/>" @
				"<t>Ѱ�Ұ����ٻ�����ͼ�ڣ���ȡһ��ůů��ͼ��֮���ɡ�</t><b/>";

			%Level = %Player.GetLevel();
			%Text[1] =
				$Get_Dialog_GeShi[31421] @ "�� �� ����</t>"  @ $Get_Dialog_GeShi[%GeShi] @ "  ���ɻ�Ծ��</t>" @ 20 @ $Get_Dialog_GeShi[%GeShi] @ "  ���齱����</t>" @ $Monster_Exp[%Level, 1] * 500 @ "<b/>" @
				$Get_Dialog_GeShi[31421] @ "�󻤷�����</t>"  @ $Get_Dialog_GeShi[%GeShi] @ "  ���ɻ�Ծ��</t>" @ 10 @ $Get_Dialog_GeShi[%GeShi] @ "  ���齱����</t>" @ $Monster_Exp[%Level, 1] * 100 @ "<b/>" @
				$Get_Dialog_GeShi[31421] @ "�һ�������</t>"  @ $Get_Dialog_GeShi[%GeShi] @ "  ���ɻ�Ծ��</t>" @ 10 @ $Get_Dialog_GeShi[%GeShi] @ "  ���齱����</t>" @ $Monster_Exp[%Level, 1] * 100 @ "<b/>" @
				$Get_Dialog_GeShi[31421] @ "�� �� ����</t>"  @ $Get_Dialog_GeShi[%GeShi] @ "  ���ɻ�Ծ��</t>" @ 10 @ $Get_Dialog_GeShi[%GeShi] @ "  ���齱����</t>" @ $Monster_Exp[%Level, 1] * 200 @ "<b/>";

			%Text[2] = 
				"<t>�����</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"closestrategywndgui();OpenOrCloseActivityWnd();CreateActivityByType(1);\",\"" @ $Get_Dialog_GeShi[31214] @ "���ȫ" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>�ɲ鿴��ϸ����</t><b/>" @
				"<t>ǰ�� </t>"  @ Getfindpath(410010107, 0, 0, 31214) @ "<t> ���븱��</t><b/>";

		case 8: //"���������";
			%Text[0] =
				"<t>��δ����</t><b/>";
		case 9: //"��ħ�ǹ���ս";
		case 10://"���ս";
	}


	if (%Text[0] !$= "")
	{
		//echo("%Text[0]===" @ %Text[0]);
		FactionActivity_Bg_bmp.setvisible(1);
		FactionActivity_Purpose_text.setvisible(1);
		FactionActivity_Purpose_text.SetContent($Get_Dialog_GeShi[31401] @ %Text[0] @ "</t>");
	}
	else
	{
		FactionActivity_Bg_bmp.setvisible(0);
		FactionActivity_Purpose_text.setvisible(0);
	}
	if (%Text[1] !$= "")
	{
		//echo("%Text[1]===" @ %Text[1]);
		FactionActivity_Reward_bmp.setvisible(1);
		FactionActivity_Reward_text.setvisible(1);
		FactionActivity_Reward_text.SetContent($Get_Dialog_GeShi[31401] @ %Text[1] @ "</t>");
	}
	else
	{
		FactionActivity_Reward_bmp.setvisible(0);
		FactionActivity_Reward_text.setvisible(0);
	}
	if (%Text[2] !$= "")
	{
		//echo("%Text[2]===" @ %Text[2]);
		FactionActivity_Join_bmp.setvisible(1);
		FactionActivity_Join_text.setvisible(1);
		FactionActivity_Join_text.SetContent($Get_Dialog_GeShi[31401] @ %Text[2] @ "</t>");
	}
	else
	{
		FactionActivity_Join_bmp.setvisible(0);
		FactionActivity_Join_text.setvisible(0);
	}
}
//�������������ɻ���桿������������ݻ�ȡ����������������

//�������������ɻ���桿�������������ť��������������������
function JoinKLJFactionActivity(%index)
{
	putout("���ɻ���� �����ť���� %index===" @ %index);
	switch (%index)
	{
		case 0: //"ÿ�չ���";
			if (GetSrc(GetPlayer(), 195) == 0)
				ClientOnSptAction(39, 0);//ͨѶ�����
			else
				SetScreenMessage("���Ѿ���ȡ�����յİ��ɹ���", $Color[2]);
		case 1: //"���ɾ���";
		case 2: //"�����ħ";
		case 3: //"�ռ�����";
		case 4: //"�����칬";
		case 5: //"�����ؾ�";
		case 6: //"ȺӢ���";
		case 7: //"���޾�";
		case 8: //"���������";
		case 9: //"��ħ�ǹ���ս";
		case 10://"���ս";
	}
}
//�������������ɻ���桿�������������ť��������������������
