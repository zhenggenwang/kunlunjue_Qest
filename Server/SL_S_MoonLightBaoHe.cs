//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//�¹ⱦ�нű�
//==================================================================================

//������ת��ڣ�ѡ�к�ʹ��F3���ɣ�����㲻����UE���ǾͰﲻ������

//�����������������������¹ⱦ�С�����������������������������������������������


function MoonLightBaoHe(%Npc, %Player, %State, %Conv)
{
	%PlayerID = %Player.GetPlayerID();
	switch (%State)
	{
		case 0:
			switch (%Npc.GetDataID())
			{
				case 444444444://��˧��
					for (%i= 1; %i<20; %i++)
					{
						%DialogID = "1000000" @ %i * 100;		//������
						%Option = Get_YGBH_Dialog(0, %Player, %DialogID, %Param);
						//echo( "%DialogID==" @ %DialogID  @ "     %Option====" @ %Option );
						if (%Option !$= "")
							%Conv.AddOption(%DialogID, %DialogID);
						else
							break;
					}
			}
		case 1000000100://��ȡ�¹ⱦ��
			%Conv.SetType(4);
			if (%Player.GetItemCount(108020208) < 1)
			{
				%Player.Putitem(108020208, 1);
				%Player.Additem(1, 108020208);
			}
		case 1000000200://��ʦ���̵�
			%Conv.SetType(4);
			OpenNpcShop(%Player, 430000);
		case 1000000300://�򿪲����̵�
			%Conv.SetType(4);
			OpenNpcShop(%Player, 400002);

		case 1000000400://�򿪲ֿ�
			%Conv.SetType(4);
			%Player.OpenBank(0);
		case 1000000500://������
			%Conv.SetType(4);
			HelpDirectByIndex(%PlayerID, 5);	//ͨѶ�ͻ���
	}
}



//�����������������������¹ⱦ�С�����������������������������������������������

//1������ߣ����������¹ⱦ��
function Trigger_108020208(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Npc, %XYZ)
{
	// ��ס��������ָ�������Ʒ��������ǳ���Ҫ
	if (%Npc == 0)
	{
		%Conv.Reset();	//��������ѡ��
		%Conv.SetTriggerType(1);
		%Conv.SetTriggerMission(%Type);

		%Conv.SetType(1);
	}

	%PlayerID = %Player.GetPlayerID();
	%FamilyID = %Player.GetOrgID();

	//������1��ѡ�����
	//������2��ѡ�����
	//������3��ѡ�����
	//������4��ѡ�����

	//������1��ѡ�����
	%Conv.SetText(%Type);			//��ʾ�Ի�
	if (%State == 0)
	{
		%Player.OptionPlace = 1;		//��¼Ϊ1��
		%Player.StateR[1] = %State;	//��¼Ϊ1��
		for (%i=0; %i<=20; %i++)
		{
			%DialogID = 1000 + %i @"000000";		//������
			%Option = Get_YGBH_Dialog(0, %Player, %DialogID, %Param);
			if (%Option !$= "")
				%Conv.AddOption(%DialogID, %DialogID);	//ѭ����1��ѡ��
		}
	}
	//������2��ѡ�����
	else if ((100 - GetSubStr(%State, 4, 2)) == 100)
	{
		%Player.OptionPlace = 2;		//��¼Ϊ2��
		%DialogID_SubStr = GetSubStr(%State, 0, 4);
		%Player.StateR[2] = %State;	//��¼Ϊ1��

		for (%i=1; %i<100; %i++)
		{

			%DialogID = (%DialogID_SubStr * 100) + %i @"0000";		//������
			%Option = Get_YGBH_Dialog(0, %Player, %DialogID, %Param);

			if (%Option !$= "")
				%Conv.AddOption(%DialogID, %DialogID);	//ѭ����2��ѡ��
			else
				break;
		}
	}
	//������3��ѡ�����
	else if ((100 - GetSubStr(%State, 6, 2)) == 100)
	{
		%Player.OptionPlace = 3;		//��¼Ϊ1��
		%DialogID_SubStr = GetSubStr(%State, 0, 6);
		%Player.StateR[3] = %State;	//��¼Ϊ1��

		for (%i=1; %i<100; %i++)
		{
			%DialogID = (%DialogID_SubStr * 100) + %i @"00";		//������
			%Option = Get_YGBH_Dialog(0, %Player, %DialogID, %Param);

			if (%Option !$= "")
			{
				//echo( "%DialogID ===" @ %DialogID );
				%Conv.AddOption(%DialogID, %DialogID);	//ѭ����3��ѡ��
			}
		}
	}

	//������4��ѡ�����
	//echo("%State=====" @ %State);
	//----------------------��һ�๦��-----������������------------------------------------------
	switch (%State)
	{
		case 1000000000:
			%No = 1;
			%CopyMapID = %Player.GetLayerID();
			%Pos_X = GetWord(%Player.GetPosition(), 0);
			%Pos_Y = GetWord(%Player.GetPosition(), 1);
			%Pos_Z = GetWord(%Player.GetPosition(), 2);
			SpNewNpc3(0, 444444444, %Pos_X + 1 @ " " @ %Pos_Y + 1 @ " " @ %Pos_Z, %CopyMapID, 0, "2 2 2");
		case 1001010100:
			%State_return = 1001010000;
			%No = 0;
			%Player.AddLevel(85 - %Player.GetLevel());

		case 1001010200:%State_return = 1001010000;	%No = 0; %Player.AddLevel(10);
		case 1001010300:%State_return = 1001010000;	%No = 0; %Player.AddLevel(5);
		case 1001010400:%State_return = 1001010000;	%No = 0; %Player.AddLevel(1);
		case 1001010500:%State_return = 1001010000;	%No = 0; %Player.AddLevel(-1);
		case 1001010600:%State_return = 1001010000;	%No = 0; %Player.AddLevel(-5);
		case 1001010700:%State_return = 1001010000;	%No = 0; %Player.AddLevel(-10);
		case 1001010800:%State_return = 1001010000;	%No = 0; %Player.AddLevel(-%Player.GetLevel());
	}
	switch (%State)
	{
		case 1001020100:%State_return = 1001020000; %No = 0;  %Player.AddExp(%Player.GetLevelExp() * 0.45);//��ɫ����
		case 1001020200:%State_return = 1001020000; %No = 0;  %Player.AddPetExp(%Player.GetSpawnedPetSlot(), 100000000);
	}
	switch (%State)
	{
		case 1001030100:%State_return = 1001030000; %No = 0; %Player.AddMoney(99999999, 1, 1, %Type);	//Ԫ��
		case 1001030200:%State_return = 1001030000; %No = 0; %Player.AddMoney(99999999, 2, 1, %Type);	//���
		case 1001030300:%State_return = 1001030000; %No = 0; %Player.AddMoney(99999999, 4, 1, %Type);	//��Ԫ��
		case 1001030400:%State_return = 1001030000; %No = 0; %Player.AddMoney(99999999, 6, 1, %Type);	//�ֿ�Ԫ��
		case 1001030500:%State_return = 1001030000; %No = 0; %Player.AddMoney(5000, 7, 1, %Type);	//��Ծ����
		case 1001030600:%State_return = 1001030000; %No = 0; %Player.AddMoney(99999999, 8, 1, %Type);	//ս������
		case 1001030700:
			%State_return = 1001030000;
			%No = 1;
			%Player.ReduceMoney(%Player.GetMoney(1), 1,1,%type);
			%Player.ReduceMoney(%Player.GetMoney(2), 2,1,%type);
			/*SendOneScreenMessage( 1, "������һ���ʴȣ�", %Player );
			SendOneChatMessage( $chatMsg_System, "<t>������һ���ʴȣ�</t>", %Player );
			Schedule( 1 * 1000, 0, "eval", %Player@".SetDamageState(Disabled);" );
			Schedule( 1 * 1000, 0, "eval", %Player@".AddPacket(670081);" );*/
	}
	switch (%State)
	{
		case 1001040000://"<t>ѧϰְҵ����</t>";
			%State_return = 1001000000; %No = 0;
			//�佫
			%Skill[1, 1] = 210010001; %Skill[1, 11] = 210110001; %Skill[1, 21] = 210210001;
			%Skill[1, 2] = 210020001; %Skill[1, 12] = 210120001;
			%Skill[1, 3] = 210030001; %Skill[1, 13] = 210130001;
			%Skill[1, 4] = 210040001; %Skill[1, 14] = 210140001;
			%Skill[1, 5] = 210050001; %Skill[1, 15] = 210150001;
			%Skill[1, 6] = 210060001; %Skill[1, 16] = 210160001;
			%Skill[1, 7] = 210070001; %Skill[1, 17] = 210170001;
			%Skill[1, 8] = 210080001; %Skill[1, 18] = 210180001;
			%Skill[1, 9] = 210090001; %Skill[1, 19] = 210190001;
			%Skill[1, 10] = 210100001; %Skill[1, 20] = 210200001;
			//����
			%Skill[2, 1] = 220010001; %Skill[2, 11] = 220110001;
			%Skill[2, 2] = 220020001; %Skill[2, 12] = 220120001;
			%Skill[2, 3] = 220030001; %Skill[2, 13] = 220130001;
			%Skill[2, 4] = 220040001; %Skill[2, 14] = 220140001;
			%Skill[2, 5] = 220050001; %Skill[2, 15] = 220150001;
			%Skill[2, 6] = 220060001; %Skill[2, 16] = 220160001;
			%Skill[2, 7] = 220070001; %Skill[2, 17] = 220170001;
			%Skill[2, 8] = 220080001; %Skill[2, 18] = 220180001;
			%Skill[2, 9] = 220090001;
			%Skill[2, 10] = 220100001;
			//��ʿ
			%Skill[3, 1] = 230010001; %Skill[3, 11] = 230110001; %Skill[3, 21] = 230210001;
			%Skill[3, 2] = 230020001; %Skill[3, 12] = 230120001;
			%Skill[3, 3] = 230030001; %Skill[3, 13] = 230130001;
			%Skill[3, 4] = 230040001; %Skill[3, 14] = 230140001;
			%Skill[3, 5] = 230050001; %Skill[3, 15] = 230150001;
			%Skill[3, 6] = 230060001; %Skill[3, 16] = 230160001;
			%Skill[3, 7] = 230070001; %Skill[3, 17] = 230170001;
			%Skill[3, 8] = 230080001; %Skill[3, 18] = 230180001;
			%Skill[3, 9] = 230090001; %Skill[3, 19] = 230190001;
			%Skill[3, 10] = 230100001; %Skill[3, 20] = 230200001;
			//��ʿ
			%Skill[4, 1] = 240010001; %Skill[4, 11] = 240110001; %Skill[4, 21] = 240210001;
			%Skill[4, 2] = 240020001; %Skill[4, 12] = 240120001;
			%Skill[4, 3] = 240030001; %Skill[4, 13] = 240130001;
			%Skill[4, 4] = 240040001; %Skill[4, 14] = 240140001;
			%Skill[4, 5] = 240050001; %Skill[4, 15] = 240150001;
			%Skill[4, 6] = 240060001; %Skill[4, 16] = 240160001;
			%Skill[4, 7] = 240070001; %Skill[4, 17] = 240170001;
			%Skill[4, 8] = 240080001; %Skill[4, 18] = 240180001;
			%Skill[4, 9] = 240090001;	%Skill[4, 19] = 240190001;
			%Skill[4, 10] = 240100001;	%Skill[4, 20] = 240200001;
			//����
			%Skill[5, 1] = 250010001; %Skill[5, 11] = 250110001;
			%Skill[5, 2] = 250020001; %Skill[5, 12] = 250120001;
			%Skill[5, 3] = 250030001; %Skill[5, 13] = 250130001;
			%Skill[5, 4] = 250040001; %Skill[5, 14] = 250140001;
			%Skill[5, 5] = 250050001; %Skill[5, 15] = 250150001;
			%Skill[5, 6] = 250080001; %Skill[5, 16] = 250160001;
			%Skill[5, 7] = 250070001; %Skill[5, 17] = 250170001;
			%Skill[5, 8] = 250060001; %Skill[5, 18] = 250180001;
			%Skill[5, 9] = 250090001;
			%Skill[5, 10] = 250100001;

			%ZhiYe = %Player.GetClasses(0);
			%NeedLv = 85 - %Player.GetLevel();
			%Player.AddLevel(%NeedLv);
			for (%i=1; %i<=100; %i++)
			{
				if (%Skill[%ZhiYe, %i] > 0)
				{
					%Player.addskill(%Skill[%ZhiYe, %i]);
					if (%i <= 21)
						%Player.AddObjectToPanel(2, %Skill[%ZhiYe, %i], %i);
				}
				else
					break;
			}
			%Sex = %Player.GetSex();
			$EquipItemColor5Lv100[1, 1, 1] =101013010; $EquipItemColor5Lv100[1, 2, 1] =101013010; $EquipItemColor5Lv100[3, 1, 1] =101033010; $EquipItemColor5Lv100[3, 2, 1] =101033010; $EquipItemColor5Lv100[4, 1, 1] =101043010; $EquipItemColor5Lv100[4, 2, 1] =101043010;
			$EquipItemColor5Lv100[1, 1, 2] =101023010; $EquipItemColor5Lv100[1, 2, 2] =101023010; $EquipItemColor5Lv100[3, 1, 2] =101023010; $EquipItemColor5Lv100[3, 2, 2] =101023010; $EquipItemColor5Lv100[4, 1, 2] =101023010; $EquipItemColor5Lv100[4, 2, 2] =101023010;
			$EquipItemColor5Lv100[1, 1, 3] =102013010; $EquipItemColor5Lv100[1, 2, 3] =102013060; $EquipItemColor5Lv100[3, 1, 3] =102013210; $EquipItemColor5Lv100[3, 2, 3] =102013260; $EquipItemColor5Lv100[4, 1, 3] =102013310; $EquipItemColor5Lv100[4, 2, 3] =102013360;
			$EquipItemColor5Lv100[1, 1, 4] =102023010; $EquipItemColor5Lv100[1, 2, 4] =102023060; $EquipItemColor5Lv100[3, 1, 4] =102023210; $EquipItemColor5Lv100[3, 2, 4] =102023260; $EquipItemColor5Lv100[4, 1, 4] =102023310; $EquipItemColor5Lv100[4, 2, 4] =102023360;
			$EquipItemColor5Lv100[1, 1, 5] =102033010; $EquipItemColor5Lv100[1, 2, 5] =102033060; $EquipItemColor5Lv100[3, 1, 5] =102033210; $EquipItemColor5Lv100[3, 2, 5] =102033260; $EquipItemColor5Lv100[4, 1, 5] =102033310; $EquipItemColor5Lv100[4, 2, 5] =102033360;
			$EquipItemColor5Lv100[1, 1, 6] =102043010; $EquipItemColor5Lv100[1, 2, 6] =102043060; $EquipItemColor5Lv100[3, 1, 6] =102043210; $EquipItemColor5Lv100[3, 2, 6] =102043260; $EquipItemColor5Lv100[4, 1, 6] =102043310; $EquipItemColor5Lv100[4, 2, 6] =102043360;
			$EquipItemColor5Lv100[1, 1, 7] =102053010; $EquipItemColor5Lv100[1, 2, 7] =102053060; $EquipItemColor5Lv100[3, 1, 7] =102053210; $EquipItemColor5Lv100[3, 2, 7] =102053260; $EquipItemColor5Lv100[4, 1, 7] =102053310; $EquipItemColor5Lv100[4, 2, 7] =102053360;
			$EquipItemColor5Lv100[1, 1, 8] =102063010; $EquipItemColor5Lv100[1, 2, 8] =102063060; $EquipItemColor5Lv100[3, 1, 8] =102063210; $EquipItemColor5Lv100[3, 2, 8] =102063260; $EquipItemColor5Lv100[4, 1, 8] =102063310; $EquipItemColor5Lv100[4, 2, 8] =102063360;
			$EquipItemColor5Lv100[1, 1, 9] =102073010; $EquipItemColor5Lv100[1, 2, 9] =102073060; $EquipItemColor5Lv100[3, 1, 9] =102073210; $EquipItemColor5Lv100[3, 2, 9] =102073260; $EquipItemColor5Lv100[4, 1, 9] =102073310; $EquipItemColor5Lv100[4, 2, 9] =102073360;
			$EquipItemColor5Lv100[1, 1, 10]=103013010; $EquipItemColor5Lv100[1, 2, 10]=103013010; $EquipItemColor5Lv100[3, 1, 10]=103013210; $EquipItemColor5Lv100[3, 2, 10]=103013210; $EquipItemColor5Lv100[4, 1, 10]=103013310; $EquipItemColor5Lv100[4, 2, 10]=103013310;
			$EquipItemColor5Lv100[1, 1, 11]=103023010; $EquipItemColor5Lv100[1, 2, 11]=103023010; $EquipItemColor5Lv100[3, 1, 11]=103023210; $EquipItemColor5Lv100[3, 2, 11]=103023210; $EquipItemColor5Lv100[4, 1, 11]=103023310; $EquipItemColor5Lv100[4, 2, 11]=103023310;
			$EquipItemColor5Lv100[1, 1, 12]=103033010; $EquipItemColor5Lv100[1, 2, 12]=103033010; $EquipItemColor5Lv100[3, 1, 12]=103033210; $EquipItemColor5Lv100[3, 2, 12]=103033210; $EquipItemColor5Lv100[4, 1, 12]=103033310; $EquipItemColor5Lv100[4, 2, 12]=103033310;
			for (%i = 1; %i <= 12; %i++)
			{
				%Player.PutItem($EquipItemColor5Lv100[%ZhiYe, %Sex, %i]-2, 1);
				%Player.Additem(1, 108020208);
			}
	}
	//----------------------�ڶ��๦��-----���������ͼ------------------------------------------
	switch (%State)
	{
		case 1002010000:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1001, "");// "<t>���͡����ء�</t>";
		case 1002020000:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1010, "");// "<t>���͡�������[��ͨ]</t>";
		case 1002030000:%State_return = 1002000000; %No = 0; SendOneScreenMessage(1, "���ָ�����ʲô��", %Player);

		case 1002040100:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1101, ""); //"<t>���͡������롿</t>";
		case 1002040200:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1102, ""); //"<t>���͡���ɽѩ����</t>";
		case 1002040300:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1103, ""); //"<t>���͡���������</t>";
		case 1002040400:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1104, ""); //"<t>���͡�������ԭ��</t>";
		case 1002040500:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1105, ""); //"<t>���͡��㺣���֡�</t>";
		case 1002040600:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1106, ""); //"<t>���͡����ط��桿</t>";
		case 1002041800:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1118, ""); //"<t>���͡���ħ�</t>";
		case 1002041900:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1119, ""); //"<t>���͡���ħ�ǡ�</t>";
		case 1002049900:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1199, ""); //"<t>���͡����Ե�ͼ��</t>";

		case 1002050100:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 811200100, "");//"<t>���͡���������1�㡿	</t>";
		case 1002050200:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 811210100, "");//"<t>���͡���������2�㡿	</t>";
		case 1002050300:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 811220100, "");//"<t>���͡���������3�㡿	</t>";
		case 1002050400:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 811230100, "");//"<t>���͡���¹֮Ұ��	</t>";
		case 1002050500:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 811280100, "");//"<t>���͡����ɿ�1�㡿	</t>";
		case 1002050600:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 811280200, "");//"<t>���͡����ɿ�2�㡿	</t>";
		case 1002050700:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 811290100, "");//"<t>���͡���������1�㡿	</t>";
		case 1002050800:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 811290200, "");//"<t>���͡���������2�㡿	</t>";
		case 1002050900:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 811290300, "");//"<t>���͡���������3�㡿	</t>";
		case 1002051000:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 811290400, "");//"<t>���͡���������4�㡿	</t>";
		case 1002051100:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 811300100, "");//<t>���͡���Թ�1�㡿	</t>";
		case 1002051200:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 811300200, "");//<t>���͡���Թ�2�㡿	</t>";
		case 1002051300:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 811300300, "");//<t>���͡���Թ�3�㡿	</t>";
		case 1002051400:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 811300400, "");//<t>���͡���Թ�4�㡿	</t>";

		case 1002070000:%State_return = 1002000000; %No = 0; SendOneScreenMessage(1, "˵���㻹�㣬�в�ѽ��", %Player);

		case 1002080100:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1301, "");// "<t>���͡�ʱ���Ѻۡ�</t>";
		case 1002080200:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1302, "");// "<t>���͡���ħԨ��</t>";
		case 1002080300:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1303, "");// "<t>���͡��������ء�</t>";
		case 1002080400:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1305, "");// "<t>���͡���ħ�þ���</t>";
		case 1002080500:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1306, "");// "<t>���͡�����������</t>";
		case 1002080600:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1311, "");// "<t>���͡�Ѫħ��ӡ��</t>";
		case 1002080700:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1312, "");// "<t>���͡��ƽ𱦲ء�</t>";
		case 1002080800:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1316, "");//"<t>���͡����޾���</t>";
		case 1002080900:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1317, "");//"<t>���͡������Թ���</t>";
		case 1002081000:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1318, "");//"<t>���͡������ؾ���</t>";

		case 1002100100:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1304, "");// "<t>���͡��þ����ԡ�</t>";
		case 1002100200:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1307, "");// "<t>���͡������������ͼ���</t>";
		case 1002100300:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1308, "");// "<t>���͡������������м���</t>";
		case 1002100400:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1309, "");// "<t>���͡������������߼���</t>";
		case 1002100500:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1310, "");// "<t>���͡���ɽ��𢡿</t>";
		case 1002100600:%State_return = 1002000000; %No = 0; GoToNextMap(%Player, 1313, "");// "<t>���͡���������</t>";
	}
	//----------------------�����๦��-----��Ӹ���״̬------------------------------------------
	switch (%State)
	{
		case 1003010100:%State_return = 1003010000; %No = 0; wudi(%Player);//�޵�״̬
		case 1003010200:%State_return = 1003010000; %No = 0; Huifu(%Player);//��Ѫ����

		case 1003030100:%State_return = 1003030000; %No = 0; %Player.DisableCaptivate();//���������״̬
		case 1003030200:%State_return = 1003030000; %No = 0; ClearSafeTime(%Player);//�����ȫʱ��1003040100
		case 1003030300:%State_return = 1003030000; %No = 0; BackOutSecondPWD(%Player);//�����������
		case 1003030400:%State_return = 1003030000; %No = 0; ClearSafeTime(%Player); %Player.DisableCaptivate(); BackOutSecondPWD(%Player);//�����ȫʱ��������� ������

		case 1003040100:%State_return = 1003040000; %Player.addskill(259990001);//���ţB ����
	}
	//----------------------�����๦��-----��Ŵ�������------------------------------------------
	switch (%State)
	{
		case 1004010000:%State_return = 1004000000; %No = 0; ServerOnSptAction(%PlayerID, 1, 2);	//����ˢ�¹���
		case 1004020000:%State_return = 1004000000; %No = 0; ServerOnSptAction(%PlayerID, 2, 2);	//����ˢ�µ���
		case 1004030000:%State_return = 1004000000; %No = 0; ServerOnSptAction(%PlayerID, 3, 2);	//����ˢ�²ɼ�
		case 1004040000:%State_return = 1004000000; %No = 0; ServerOnSptAction(%PlayerID, 4, 2);	//�����������
		case 1004050000:%State_return = 1004000000; %No = 0; ServerOnSptAction(%PlayerID, 5, 2);	//�����������
		case 1004060000:%State_return = 1004000000; %No = 0; ServerOnSptAction(%PlayerID, 6, 2);	//��Ӽ���BUFF
	}

	//----------------------�����๦��-----��������------------------------------------------
	switch (%State)
	{
		//case 1005010000:%State_return = 1005000000; %No = 0; %Player.PutItem( 107020001, 1 ); %Player.PutItem( 107020002, 1 ); %Player.PutItem( 107020003, 1 ); %Player.Additem( );//"<t>��ȡ���</t>";
		//case 1005020000:%State_return = 1005000000; %No = 0; %Player.PutItem( 107020101, 1 ); %Player.PutItem( 105109101, 10 ); %Player.PutItem( 105109102, 10 ); %Player.PutItem( 105109103, 10 ); %Player.Additem( );//"<t>��ȡ�����</t>";
		//case 1005030000:%State_return = 1005000000; %No = 0; %Player.PutItem( 107020201, 1 ); %Player.PutItem( 105109111, 10 ); %Player.PutItem( 105109112, 10 ); %Player.PutItem( 105109113, 10 ); %Player.Additem( );//"<t>��ȡ������</t>";
		//case 1005040000:%State_return = 1005000000; %No = 0; SpNewCj2( %Player, 551010101, 0, 0, 180, "1 1 1" );//"<t>ˢ�¿���(RMB)</t>";
		//case 1005050000:%State_return = 1005000000; %No = 0; SpNewCj2( %Player, 551011001, 0, 0, 180, "1 1 1" );//"<t>ˢ��ͭ������1����</t>";
		//case 1005060000:%State_return = 1005000000; %No = 0; SpNewCj2( %Player, 551011002, 0, 0, 180, "1 1 1" );//"<t>ˢ����������2����</t>";
		//case 1005070000:%State_return = 1005000000; %No = 0; SpNewCj2( %Player, 551011003, 0, 0, 180, "1 1 1" );//"<t>ˢ����������3����</t>";
		//case 1005080000:%State_return = 1005000000; %No = 0; SpNewCj2( %Player, 551011004, 0, 0, 180, "1 1 1" );//"<t>ˢ�½������4����</t>";
		//case 1005090000:%State_return = 1005000000; %No = 0; SpNewCj2( %Player, 551011005, 0, 0, 180, "1 1 1" );//"<t>ˢ�º���������5����</t>";
		//case 1005100000:%State_return = 1005000000; %No = 0; SpNewCj2( %Player, 551011006, 0, 0, 180, "1 1 1" );//"<t>ˢ������������6����</t>";
		//case 1005110000:%State_return = 1005000000; %No = 0; SpNewCj2( %Player, 551011007, 0, 0, 180, "1 1 1" );//"<t>ˢ��ħ�������7����</t>";
		//case 1005120000:%State_return = 1005000000; %No = 0; SpNewCj2( %Player, 551011008, 0, 0, 180, "1 1 1" );//"<t>ˢ���Ͻ������8����</t>";
		//case 1005130000:%State_return = 1005000000; %No = 0; SpNewCj2( %Player, 551011009, 0, 0, 180, "1 1 1" );//"<t>ˢ��ҫ�������9����</t>";
		//case 1005140000:%State_return = 1005000000; %No = 0; SpNewCj2( %Player, 551011010, 0, 0, 180, "1 1 1" );//"<t>ˢ���߲�����������10����</t>";

		case 1005010000://<t>ѧϰһ������</t>";
			%State_return = 1005000000; %No = 0;
			LearnLivingSkill(%Player, 501011001);//�ڿ���
			LearnLivingSkill(%Player, 506011001);//��������
			LearnLivingSkill(%Player, 505011001);//���似��
			LearnLivingSkill(%Player, 504011001);//���ռ���
			LearnLivingSkill(%Player, 503011001);//�÷켼��
			LearnLivingSkill(%Player, 502011001);//���켼��
			LearnLivingSkill(%Player, 501051001);//��ҩ����
			LearnLivingSkill(%Player, 501031001);//���㼼��
			LearnLivingSkill(%Player, 501021001);//��ľ����
			LearnLivingSkill(%Player, 507011001);//��⿼���
		case 1005020000://<t>ѧϰ��������</t>";
			%State_return = 1005000000; %No = 0;
			LearnLivingSkill(%Player, 501011010);//�ڿ���
			LearnLivingSkill(%Player, 506011010);//��������
			LearnLivingSkill(%Player, 505011010);//���似��
			LearnLivingSkill(%Player, 504011010);//���ռ���
			LearnLivingSkill(%Player, 503011010);//�÷켼��
			LearnLivingSkill(%Player, 502011010);//���켼��
			LearnLivingSkill(%Player, 501051010);//��ҩ����
			LearnLivingSkill(%Player, 501031010);//���㼼��
			LearnLivingSkill(%Player, 501021010);//��ľ����
			LearnLivingSkill(%Player, 507011010);//��⿼���
		case 1005030000://<t>����������</t>";
			%State_return = 1005000000; %No = 0;
			for (%i = 501011010; %i>= 501011001; %i--)
			{
				if (isLearnLivingSkill(%Player.GetPlayerID(), %i)  == 1)
				{
					%Level = %i%10;
					if (%Level == 0)
						%Level = 10;
					break;
				}
			}
			addLivingSkillGuerdon(%Player, 501011000 + %Level, 100);
			addLivingSkillGuerdon(%Player, 506011000 + %Level, 100);
			addLivingSkillGuerdon(%Player, 505011000 + %Level, 100);
			addLivingSkillGuerdon(%Player, 504011000 + %Level, 100);
			addLivingSkillGuerdon(%Player, 503011000 + %Level, 100);
			addLivingSkillGuerdon(%Player, 502011000 + %Level, 100);
			addLivingSkillGuerdon(%Player, 501051000 + %Level, 100);
			addLivingSkillGuerdon(%Player, 501031000 + %Level, 100);
			addLivingSkillGuerdon(%Player, 501021000 + %Level, 100);
			addLivingSkillGuerdon(%Player, 507011000 + %Level, 100);
	}
	//----------------------�����๦��-----���ɹ���------------------------------------------
	switch (%State)
	{
		case 1006010000:
			%State_return = 1006000000; %No = 0; 
			if (SptOrg_GetLevel(%FamilyID) < 3)
				SptOrg_AddLevel(%FamilyID);// "<t>��Ӱ��ɵȼ�</t>";

		case 1006020000:%State_return = 0; %No = 0;//"<t>��Ӱ����������������ݣ�</t>";
		case 1006020100:%State_return = 1006020000; %No = 0; AddFamily_SW_GX(%Player, 1000, 0);//"<t>��Ӱ���������1000��</t>";
		case 1006020200:%State_return = 1006020000; %No = 0; AddFamily_SW_GX(%Player, 5000, 0);//"<t>��Ӱ���������5000��</t>";
		case 1006020300:%State_return = 1006020000; %No = 0; AddFamily_SW_GX(%Player, 10000, 0);//"<t>��Ӱ���������10000��</t>";
						
		case 1006030000:%State_return = 0; %No = 0;//"<t>��Ӱ��ɻ�Ծ���������ݣ�</t>";
		case 1006030100:%State_return = 1006030000; %No = 0; AddFamily_HuoYue(%Player,100);//"<t>��Ӱ��ɻ�Ծ��100��</t>";
		case 1006030200:%State_return = 1006030000; %No = 0; AddFamily_HuoYue(%Player,1000);//"<t>��Ӱ��ɻ�Ծ��1000��</t>";
		case 1006030300:%State_return = 1006030000; %No = 0; AddFamily_HuoYue(%Player,10000);//"<t>��Ӱ��ɻ�Ծ��10000��</t>";
						
		case 1006040000:%State_return = 0; %No = 0;//"<t>��Ӱ����ʽ𣨰������ݣ�</t>";
		case 1006040100:%State_return = 1006040000; %No = 0; AddFamily_ZiJin(%Player, 100);//"<t>��Ӱ����ʽ�100��</t>";
		case 1006040200:%State_return = 1006040000; %No = 0; AddFamily_ZiJin(%Player, 1000);//"<t>��Ӱ����ʽ�1000��</t>";
		case 1006040300:%State_return = 1006040000; %No = 0; AddFamily_ZiJin(%Player, 10000);//"<t>��Ӱ����ʽ�10000��</t>";
						
		case 1006050000:%State_return = 0; %No = 0;//"<t>��Ӱ��ɻ��ң�������ݣ�</t>";
		case 1006050100:%State_return = 1006050000; %No = 0; AddFamily_HuoBi(%Player, 100); //"<t>��Ӱ��ɻ��ң�100��</t>";
		case 1006050200:%State_return = 1006050000; %No = 0; AddFamily_HuoBi(%Player, 1000); //"<t>��Ӱ��ɻ��ң�1000��</t>";
		case 1006050300:%State_return = 1006050000; %No = 0; AddFamily_HuoBi(%Player, 10000); //"<t>��Ӱ��ɻ��ң�10000��</t>";
						
		case 1006060000:%State_return = 0; %No = 0;//"<t>��Ӱ��ɹ��ף�������ݣ�</t>";
		case 1006060100:%State_return = 1006060000; %No = 0; AddFamily_SW_GX(%Player, 0, 100);//"<t>��Ӱ��ɹ��ף�100��</t>";
		case 1006060200:%State_return = 1006060000; %No = 0; AddFamily_SW_GX(%Player, 0, 1000);//"<t>��Ӱ��ɹ��ף�1000��</t>";
		case 1006060300:%State_return = 1006060000; %No = 0; AddFamily_SW_GX(%Player, 0, 10000);//"<t>��Ӱ��ɹ��ף�10000��</t>";
			
	}
	//----------------------�ڶ�ʮ�๦��-----���ٲ��Թ���------------------------------------------
	switch (%State)
	{
		case 1020010000:%State_return = 1020000000; %No = 0; DelBackpack_HavingItem(%Player); //"<t>���������ߡ����</t>";
		case 1020020000:%State_return = 1020000000; %No = 0; %Target = %Player.GetTarget(); if (%Target.GetDamageState() $= "Enabled"){ %Target.addhate(%player, 1000); %Target.SetDamageState(Disabled); }//"<t>����Ŀ������</t>";
		case 1020030000:%State_return = 1020000000; %No = 0; %CopyMapID = %Player.GetLayerID(); SpNewNpc3(0, 499000001, %Player.GetPosition(), %CopyMapID, 0, "1 1 1");//"<t>�ٻ�ľ׮</t>";
		case 1020050000://"<t>ʮ��ľ����</t>";
			%State_return = 1020000000; %No = 0;
			%CopyMapID = %Player.GetLayerID();
			%Pos_X = GetWord(%Player.GetPosition(), 0);
			%Pos_Y = GetWord(%Player.GetPosition(), 1);
			%Pos_Z = GetWord(%Player.GetPosition(), 2);
			for (%i = -2; %i <= 2; %i++)
			{
				for (%j = -2; %j <= 2; %j++)
				{
					SpNewNpc3(0, 499000001, %Pos_X + %i @ " " @ %Pos_Y + %j @ " " @ %Pos_Z, %CopyMapID, 0, "1 1 1");
				}
			}
		case 1020060000://����ʹ�õ�һ�����
			%State_return = 1020000000; %No = 0;
			%ItemList = %Player.Getitemnum(0);
			if (%ItemList !$= "0,0")
			{
				%ItemId = GetWord(%ItemList, 0, ",");
				%ItemCount = GetWord(%ItemList, 1, ",");
				if (%ItemCount > 100)
					%ItemCount = 100;
				for (%i = 0; %i < %ItemCount; %i++)
				{
					Item_Use(%Player, %ItemID, 1, 0, 1);
				}
			}
		case 1020070000://ˢ��ModNpc;
			%State_return = 1020000000; %No = 0;
			%CountAll = 499100578 - 499100201;
			%NpcID = 499100200;
			%Row = 6;
			%Lie = mfloor(%CountAll/%Row);

			%StartPosX = GetWord(%Player.GetPosition(), 0);
			%StartPosY = GetWord(%Player.GetPosition(), 1);
			for (%i = 0; %i < %Row; %i++)
			{
				for (%j = 0; %j <= %Lie; %j++)
				{
					%NpcID++;
					if (GetNpcData(%NpcID, 0)<= 0)
						break;
					%PosX = %StartPosX + %i *5;
					%PosY = %StartPosY + %j *5;
					%Pos = %PosX @ " " @ %PosY @ " " @ GetWord(%Player.GetPosition(), 2);
					//echo( "%NpcID===" @ %NpcID @  "    %Pos===" @ %Pos );
					SpNewNpc2(0, %NpcID, %Pos, %Player.GetLayerid(), 0);
				}
			}
		case 1020040100:%State_return = 1020040000; %No = 0; %Player.AddBuff(320010001, %Player, 1);//"<t>ǿ������LV1</t>";
		case 1020040200:%State_return = 1020040000; %No = 0; %Player.AddBuff(320010002, %Player, 1);//"<t>ǿ������LV2</t>";
		case 1020040300:%State_return = 1020040000; %No = 0; %Player.AddBuff(320010003, %Player, 1);//"<t>ǿ������LV3</t>";
		case 1020040400:%State_return = 1020040000; %No = 0; %Player.AddBuff(320020001, %Player, 1);//"<t>����</t>";
		case 1020040500:%State_return = 1020040000; %No = 0; %Player.AddBuff(320030001, %Player, 1);//"<t>��Ӱ��</t>";
		case 1020040600:%State_return = 1020040000; %No = 0; %Player.AddBuff(320040001, %Player, 1);//"<t>ħ����</t>";
		case 1020040700:%State_return = 1020040000; %No = 0; %Player.AddBuff(320050001, %Player, 1);//"<t>��˫</t>";
		case 1020040800:%State_return = 1020040000; %No = 0; %Player.AddBuff(320060001, %Player, 1);//"<t>����LV1</t>";
		case 1020040900:%State_return = 1020040000; %No = 0; %Player.AddBuff(320060002, %Player, 1);//"<t>����LV2</t>";
		case 1020041000:%State_return = 1020040000; %No = 0; %Player.AddBuff(320060003, %Player, 1);//"<t>����LV3</t>";
		case 1020041100:%State_return = 1020040000; %No = 0; %Player.AddBuff(320070001, %Player, 1);//"<t>��������LV1</t>";
		case 1020041200:%State_return = 1020040000; %No = 0; %Player.AddBuff(320070002, %Player, 1);//"<t>��������LV2</t>";
		case 1020041300:%State_return = 1020040000; %No = 0; %Player.AddBuff(320070003, %Player, 1);//"<t>��������LV3</t>";
		case 1020041400:%State_return = 1020040000; %No = 0; %Player.AddBuff(320080001, %Player, 1);//"<t>ս��֮��</t>";
		case 1020041500:%State_return = 1020040000; %No = 0; %Player.AddBuff(320080002, %Player, 1);//"<t>��������</t>";
		case 1020041600:%State_return = 1020040000; %No = 0; %Player.AddBuff(320090001, %Player, 1);//"<t>�����⻷LV1</t>";
		case 1020041700:%State_return = 1020040000; %No = 0; %Player.AddBuff(320090002, %Player, 1);//"<t>�����⻷LV2</t>";
		case 1020041800:%State_return = 1020040000; %No = 0; %Player.AddBuff(320090003, %Player, 1);//"<t>�����⻷LV3</t>";
		case 1020041900:%State_return = 1020040000; %No = 0; %Player.AddBuff(320100001, %Player, 1);//"<t>��������LV1</t>";
		case 1020042000:%State_return = 1020040000; %No = 0; %Player.AddBuff(320100002, %Player, 1);//"<t>��������LV2</t>";
		case 1020042100:%State_return = 1020040000; %No = 0; %Player.AddBuff(320100003, %Player, 1);//"<t>��������LV3</t>";
		case 1020042200:%State_return = 1020040000; %No = 0; %Player.AddBuff(320110001, %Player, 1);//"<t>��Ѫ��LV1</t>";
		case 1020042300:%State_return = 1020040000; %No = 0; %Player.AddBuff(320110002, %Player, 1);//"<t>��Ѫ��LV2</t>";
		case 1020042400:%State_return = 1020040000; %No = 0; %Player.AddBuff(320110003, %Player, 1);//"<t>��Ѫ��LV3</t>";
		case 1020042500:%State_return = 1020040000; %No = 0; %Player.AddBuff(320120001, %Player, 1);//"<t>�����ӰLV1</t>";
		case 1020042600:%State_return = 1020040000; %No = 0; %Player.AddBuff(320120002, %Player, 1);//"<t>�����ӰLV2</t>";
		case 1020042700:%State_return = 1020040000; %No = 0; %Player.AddBuff(320120003, %Player, 1);//"<t>�����ӰLV3</t>";
		case 1020042800:%State_return = 1020040000; %No = 0; %Player.AddBuff(320130001, %Player, 1);//"<t>����֮��</t>";
		case 1020042900:%State_return = 1020040000; %No = 0; %Player.AddBuff(320140001, %Player, 1);//"<t>������</t>";
		case 1020043000:%State_return = 1020040000; %No = 0; %Player.AddBuff(320150001, %Player, 1);//"<t>���</t>";
		case 1020043100:%State_return = 1020040000; %No = 0; %Player.AddBuff(320160001, %Player, 1);//"<t>���ܻ�</t>";
		case 1020043200:%State_return = 1020040000; %No = 0; %Player.AddBuff(320170001, %Player, 1);//"<t>�ռ�ת��</t>";
		case 1020043300:%State_return = 1020040000; %No = 0; %Player.AddBuff(320180001, %Player, 1);//"<t>��־ŭ��</t>";
		case 1020043400:%State_return = 1020040000; %No = 0; %Player.AddBuff(320190001, %Player, 1);//"<t>��������LV1</t>";
		case 1020043500:%State_return = 1020040000; %No = 0; %Player.AddBuff(320190002, %Player, 1);//"<t>��������LV2</t>";
		case 1020043600:%State_return = 1020040000; %No = 0; %Player.AddBuff(320190003, %Player, 1);//"<t>��������LV3</t>";
		case 1020043700:%State_return = 1020040000; %No = 0; %Player.AddBuff(320200001, %Player, 1);//"<t>ħ������LV1</t>";
		case 1020043800:%State_return = 1020040000; %No = 0; %Player.AddBuff(320200002, %Player, 1);//"<t>ħ������LV2</t>";
		case 1020043900:%State_return = 1020040000; %No = 0; %Player.AddBuff(320200003, %Player, 1);//"<t>ħ������LV3</t>";
		case 1020044000:%State_return = 1020040000; %No = 0; %Player.AddBuff(320210001, %Player, 1);//"<t>�㶾��LV1</t>";
		case 1020044100:%State_return = 1020040000; %No = 0; %Player.AddBuff(320210002, %Player, 1);//"<t>�㶾��LV2</t>";
		case 1020044200:%State_return = 1020040000; %No = 0; %Player.AddBuff(320210003, %Player, 1);//"<t>�㶾��LV3</t>";
		case 1020044300:%State_return = 1020040000; %No = 0; %Player.AddBuff(320220001, %Player, 1);//"<t>����LV1</t>";
		case 1020044400:%State_return = 1020040000; %No = 0; %Player.AddBuff(320220002, %Player, 1);//"<t>����LV2</t>";
		case 1020044500:%State_return = 1020040000; %No = 0; %Player.AddBuff(320220003, %Player, 1);//"<t>����LV3</t>";
		case 1020044600:%State_return = 1020040000; %No = 0; %Player.AddBuff(320230001, %Player, 1);//"<t>����߱��</t>";
		case 1020044700:%State_return = 1020040000; %No = 0; %Player.AddBuff(320240001, %Player, 1);//"<t>Ⱥħ����</t>";
		case 1020044800:%State_return = 1020040000; %No = 0; %Player.AddBuff(320250001, %Player, 1);//"<t>������ת</t>";
		case 1020044900:%State_return = 1020040000; %No = 0; %Player.AddBuff(320260003, %Player, 1);//"<t>��ϵ������ʦLV3</t>";
		case 1020045000:%State_return = 1020040000; %No = 0; %Player.AddBuff(320270003, %Player, 1);//"<t>��ϵ������ʦLV3</t>";
		case 1020045100:%State_return = 1020040000; %No = 0; %Player.AddBuff(320280003, %Player, 1);//"<t>��ϵ������ʦLV3</t>";
		case 1020045200:%State_return = 1020040000; %No = 0; %Player.AddBuff(320290003, %Player, 1);//"<t>ľϵ������ʦLV3</t>";
		case 1020045300:%State_return = 1020040000; %No = 0; %Player.AddBuff(320300003, %Player, 1);//"<t>��ϵ������ʦLV3</t>";

		case 1020080100:%State_return = 1020080000; %No = 0; %Player.SetPkValue(0);// "<t>�ƶ�ֵ����</t>";
		case 1020080200:%State_return = 1020080000; %No = 0; %PkValue = %player.getPkValue() + 1; if (%PkValue > 255) %PkValue = 255; %Player.SetPkValue(%PkValue);// "<t>����1���ƶ�ֵ</t>";
		case 1020080300:%State_return = 1020080000; %No = 0; %PkValue = %player.getPkValue() + 10; if (%PkValue > 255) %PkValue = 255; %Player.SetPkValue(%PkValue);// "<t>����10���ƶ�ֵ</t>";
		case 1020080400:%State_return = 1020080000; %No = 0; %PkValue = %player.getPkValue() + 100; if (%PkValue > 255) %PkValue = 255; %Player.SetPkValue(%PkValue);// "<t>����100���ƶ�ֵ</t>";

		case 1020090000://"<t>���������ߡ�չʾ</t>";
			%State_return = 1020060000; %No = 0;
			GetBackpack_HavingItem(%Player);
	}


	//--------------------------------------------------------------------------------------------
	if (%No == 0) //0��Ҫ���ڱ������н��� ��÷�����һ��  1�رնԻ�����
	{
		if (%State_return > 0)
			Trigger_108020208(%Conv, %Player, %Type, %State_return, %TriggerType, %TriggerID, %Param, %XYZ);
		else if (%State > 0)
			%Conv.AddOption(4, %Player.StateR[%Player.OptionPlace - 1]);
	}
	else
		%Conv.SetType(4);	//�رնԻ�

	%Conv.Send(%Player);
}



//ʹ���¹ⱦ�н�������ʱ���Խ�����������Ʒ���д���
function MoonLightBaoHe_AccecpMis_GetItem(%Player, %Mid)
{
	%ItemAdd = GetMissionData(%Mid, $Mission_Data_ItemAdd);		//���������ĵ���
	if (%ItemAdd !$= "0")
	{
		%ItemCnt = GetWordCount(%ItemAdd, ";") / 2;
		for (%i = 0; %i < %ItemCnt; %i++)
		{
			%Item = GetWord(%ItemAdd, %i * 2, ";");
			%Num  = GetWord(%ItemAdd, %i * 2 + 1, ";");

			if ((%Item $= "") || (%Num $= ""))
				break;
			else
			{
				%Num = %Num - %Player.GetItemCount(%Item);
				%Classes = %Player.GetClasses(0) - 1;
				%DataClasses = GetItemData(%Item, 113);
				if ((%Num > 0) && ((%DataClasses == 0) || (HasBit(%DataClasses, %Classes))))
				{
					%bItemAdd = %Player.PutItem(%Item, %Num);
					%ItemText = %Item;
				}
			}
		}
		if (%ItemText > 0)
			%bItemAdd = %Player.AddItem(1, %Mid);

		if (!%bItemAdd)
			return SendWhyMsg(%Player, "I", %Type, %Msg);
	}
}


function WuDi(%Player)
{
	%Player.AddBuff(330130001, %Player, 1); // ��Ѫ����
	%Player.AddBuff(330140001, %Player, 1); // �������
	%Player.AddBuff(330150001, %Player, 1); // ��߹���
	%Player.AddBuff(330160001, %Player, 1); // �����޵�
	%Player.AddBuff(330170001, %Player, 1); // �����޵�
	%Player.AddBuff(390110001, %Player, 1); // 

}

function HuiFu(%Player)
{
	%Player.AddBuff(390190001, %Player, 1); // ��Ѫ����
}

function Shuaguai11(%Player)
{
	%NpcIDxx[1]=405100132;
	%NpcIDxx[2]=405100133;
	%NpcIDxx[3]=405100141;
	%NpcIDxx[4]=405100142;
	%NpcIDxx[5]=405100143;
	%NpcIDxx[6]=405100151;
	%NpcIDxx[7]=405100152;
	%NpcIDxx[8]=405100153;
	%NpcIDxx[9]=0;
	%NpcIDxx[10]=0;
	%NpcIDxx[11]=0;
	%NpcIDxx[12]=0;
	%NpcIDxx[13]=0;
	%NpcIDxx[14]=0;
	%NpcIDxx[15]=0;
	%NpcIDxx[16]=0;
	%NpcIDxx[17]=0;
	%NpcIDxx[18]=0;
	%NpcIDxx[19]=0;
	%NpcIDxx[20]=0;
	%NpcIDxx[21]=0;
	%NpcIDxx[22]=0;
	%NpcIDxx[23]=0;
	%NpcIDxx[24]=0;
	%NpcIDxx[25]=0;
	%NpcIDxx[26]=0;
	%NpcIDxx[27]=0;
	%NpcIDxx[28]=0;
	%NpcIDxx[29]=0;
	%NpcIDxx[30]=0;
	%NpcIDxx[31]=0;
	%NpcIDxx[32]=0;
	%NpcIDxx[33]=0;
	%NpcIDxx[34]=0;
	%NpcIDxx[35]=0;
	%NpcIDxx[36]=0;
	%NpcIDxx[37]=0;
	%NpcIDxx[38]=0;
	%NpcIDxx[39]=0;
	%NpcIDxx[40]=0;
	%NpcIDxx[41]=0;
	%NpcIDxx[42]=0;
	%NpcIDxx[43]=0;
	%NpcIDxx[44]=0;
	%NpcIDxx[45]=0;
	%NpcIDxx[46]=0;
	%NpcIDxx[47]=0;
	%NpcIDxx[48]=0;
	%NpcIDxx[49]=0;
	%NpcIDxx[50]=0;
	%NpcIDxx[51]=0;
	%NpcIDxx[52]=0;
	%NpcIDxx[53]=0;
	%NpcIDxx[54]=0;
	%NpcIDxx[55]=0;
	%NpcIDxx[56]=0;
	%NpcIDxx[57]=0;
	%NpcIDxx[58]=0;
	%NpcIDxx[59]=0;
	%NpcIDxx[60]=0;

	%StartPosX = GetWord(%Player.GetPosition(), 0);
	%StartPosY = GetWord(%Player.GetPosition(), 1);
	%Record = 0;
	for (%i = 0; %i < 5; %i++)
	{
		for (%j = 0; %j <= 11; %j++)
		{
			%Record++;
			%NpcID = %NpcIDxx[%Record];
			if (GetNpcData(%NpcID, 0)<= 0)
				break;
			%PosX = %StartPosX + %i *5;
			%PosY = %StartPosY + %j *5;
			%Pos = %PosX @ " " @ %PosY @ " " @ GetWord(%Player.GetPosition(), 2);
			//echo( "%NpcID===" @ %NpcID @  "    %Pos===" @ %Pos );
			SpNewNpc2(0, %NpcID, %Pos, %Player.GetLayerid(), 0);
		}
	}
}

