//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//��ħ�ǹ���ս
//
//SptOrg_AttackCitySuccess��%orgID��	//���ǳɹ�
//SptOrg_AttackCityFail��%orgID��	//����ʧ��
//==================================================================================

//������������������ħ�ǡ�������������ս��Ϣˢ�¡�����������������
//������������������ħ�ǡ�������������ս��Ϣˢ�¡�����������������
//������������������ħ�ǡ���������������ս�����жϡ���������������
//������������������ħ�ǡ�������������ս���̹��̡�����������������
//������������������ħ�ǡ�������������Ҹ����������������������
//������������������ħ�ǡ������������������򴥷�������������������
//������������������ħ�ǡ��������������ǹ��ﱻ���ܡ���������������
//������������������ħ�ǡ������������ƺ�������������������������
//������������������ħ�ǡ������������������񡿡�������������������


//������������������ħ�ǡ�������������ս��Ϣˢ�¡�����������������
function Refresh_CitityWar(%YY, %MM, %DD, %H, %M, %S)
{
	if ($SL_CityAttack_bActive != 1)
		return;
	SptOrg_RequestAttackCityOrgIdinfo();//��ȡ������Ϣ
	$AttackCityRecordDefend = SptOrg_GetAttackCityOrgIdinfo(1);//��ȡ�سǷ�
	$AttackCityRecorAdttackToday = SptOrg_GetAttackCityOrgIdinfo(2);//��ý��칥�Ƿ�
	$AttackCityRecorAdttackTomorrow = SptOrg_GetAttackCityOrgIdinfo(3);//������칥�Ƿ�

	echo("��������ħ�ǡ�������������ս��Ϣˢ�¡�����");
	Putout("�سǷ�======" @ SptOrg_GetAttackCityOrgIdinfo(1) @ "   " @ SptOrg_GetName(SptOrg_GetAttackCityOrgIdinfo(1)));
	Putout("���칥�Ƿ�==" @ SptOrg_GetAttackCityOrgIdinfo(2) @ "   " @ SptOrg_GetName(SptOrg_GetAttackCityOrgIdinfo(2)));
	Putout("���칥�Ƿ�==" @ SptOrg_GetAttackCityOrgIdinfo(3) @ "   " @ SptOrg_GetName(SptOrg_GetAttackCityOrgIdinfo(3)));
	//--���¾������ݲ��֣���1119��ͼִ��
	if (GetZoneID() != 1119)
		return;
	if (%M == 50 && %H == 19)
	{
		%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//��ȡ�سǷ�
		%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//��ý��칥�Ƿ�
		%OrgIDC = SptOrg_GetAttackCityOrgIdinfo(3);//������칥�Ƿ�
		if (%OrgIDB > 0)
		{
			%HuoDongMingCheng1 = GetHuoDongName("��ħ�ǹ���ս", 1);
			%HuoDongMingCheng2 = GetHuoDongName("��ħ�ǹ���ս", 2);
			%OrgName = SptOrg_GetName(%OrgIDB);		//��������
			%OrgName1 = $Get_Dialog_GeShi[31421] @ "��" @ %OrgName @ "��</t>";
			%OrgName2 = $Get_Dialog_GeShi[60003] @ "��" @ %OrgName @ "��</t>";
			echo("%OrgIDB ==" @ %OrgIDB);
			echo("%OrgName ==" @ %OrgName);
			echo("%OrgName1 ==" @ %OrgName1);
			%Txt1 = %HuoDongMingCheng1 @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ "10</t>" @ "<t>���Ӻ�ʼ��ս��һ���������ҿ�������������˭��!</t>";
			%Txt2 = %HuoDongMingCheng2 @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ "10</t>" @ "<t>���Ӻ�ʼ</t>";
			SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Txt1 @ "</t>");
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Txt2 @ "</t>", $chatMsg_Type_Normal2);
		}
	}
	if (%H == 20 && %M == 0)
	{
		%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//��ȡ�سǷ�
		%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//��ý��칥�Ƿ�
		%OrgIDC = SptOrg_GetAttackCityOrgIdinfo(3);//������칥�Ƿ�
		if (%OrgIDB > 0)
		{
			%HuoDongMingCheng1 = GetHuoDongName("��ħ�ǹ���ս", 1);
			%HuoDongMingCheng2 = GetHuoDongName("��ħ�ǹ���ս", 2);
			%Txt1 = %HuoDongMingCheng1 @ "<t>��ʼ��</t>";
			%Txt2 = %HuoDongMingCheng2 @ "<t>��ʼ��</t>";
			SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Txt1 @ "</t>");
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Txt2 @ "</t>", $chatMsg_Type_Normal2);
			
			AttackCityWarStates(0);//ִ�й��ǿ�ʼ����
		}
	}
	if (%M == 35 && %H == 21)
	{
		
		%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//��ȡ�سǷ�
		%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//��ý��칥�Ƿ�
		%OrgIDC = SptOrg_GetAttackCityOrgIdinfo(3);//������칥�Ƿ�

		if (%OrgIDA == 0 && %OrgIDC == 0)
		{
			%HuoDongMingCheng1 = GetHuoDongName("��ħ��", 1);
			%NpcName1 = GetNpcZiTiName(410010001, 1);
			%Path = "<l i='810010100 -31.6664 23.816 200.047' t='path'/>";
			%Txt1 = %HuoDongMingCheng1 @ "<t>Ŀǰ�ް���ռ�죬����2�����ϰ��ɾ���ǰ��</t>" @ %Path @ "<t>Ѱ��</t>" @ %NpcName1 @ "<t>����������룬���ٷ�ħ���������£�������ʱ��</t>";
			SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Txt1 @ "</t>");
		}
		//else if (%OrgIDC > 0)
		//{
		//	%HuoDongMingCheng1 = GetHuoDongName("��ħ��", 1);
		//	%OrgName = SptOrg_GetName(%OrgIDC);		//��������
		//	%OrgName = $Get_Dialog_GeShi[31421] @ "��" @ %OrgName @ "��</t>";
		//	%Txt1 = "<t>����</t>" @ %OrgName @ "<t>�����</t>" @ %HuoDongMingCheng1 @ "<t>�Ĺ���Ȩ��һʱ�佭��������ӿ���ҿ����ճ�����������˭�ҡ�</t>";
		//	SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Txt1 @ "</t>");
		//}
	}
}
//������������������ħ�ǡ�������������ս��Ϣˢ�¡�����������������

//������������������ħ�ǡ�������������ս���̹��̡�����������������
function AttackCityWarStates(%Step)
{
	CanCel($AttackCityWarStates);
	switch (%Step)
	{
		case 0:
			$IsAttackCityWar_State_bActive = 1;//��ǿ�ʼ
			//ɾ���������ǳ���NPC
			$NpcRecord[1].SafeDeleteObject();
			$NpcRecord[2].SafeDeleteObject();
			$NpcRecord[3].SafeDeleteObject();
			$NpcRecord[4].SafeDeleteObject();
			$NpcRecord[5].SafeDeleteObject();
			$NpcRecord[6].SafeDeleteObject();
			$NpcRecord[7].SafeDeleteObject();
			
			$GuardRecord[1].SafeDeleteObject(); $GuardRecord[1] = SpNewNpc2(0, 411192001, "-74.390 149.824 100", 0, 270); SetNpcInfluence($GuardRecord[1],8);//����A
			$GuardRecord[2].SafeDeleteObject(); $GuardRecord[2] = SpNewNpc2(0, 411192001, "-74.027 140.621 100", 0, 270); SetNpcInfluence($GuardRecord[2],8);//����B
			$GuardRecord[3].SafeDeleteObject(); $GuardRecord[3] = SpNewNpc2(0, 411192001, "-6.7458 62.7418 101", 0, 180); SetNpcInfluence($GuardRecord[3],8);//����A
			$GuardRecord[4].SafeDeleteObject(); $GuardRecord[4] = SpNewNpc2(0, 411192001, "6.87547 62.7418 101", 0, 180); SetNpcInfluence($GuardRecord[4],8);//����B
			$GuardRecord[5].SafeDeleteObject(); $GuardRecord[5] = SpNewNpc2(0, 411192001, "72.9715 140.391 100", 0, 090); SetNpcInfluence($GuardRecord[5],8);//����A
			$GuardRecord[6].SafeDeleteObject(); $GuardRecord[6] = SpNewNpc2(0, 411192001, "72.9566 149.813 100", 0, 090); SetNpcInfluence($GuardRecord[6],8);//����B
			$GuardRecord[7].SafeDeleteObject(); $GuardRecord[7] = SpNewNpc2(0, 411192001, "28.088 152.222 100.176", 0, 180); SetNpcInfluence($GuardRecord[7],8);//���Ž�������
			$GuardRecord[8].SafeDeleteObject(); $GuardRecord[8] = SpNewNpc2(0, 411192001, "-28.0139 152.241 100.176", 0, 180); SetNpcInfluence($GuardRecord[8], 8);//���Ž�������
			$GuardRecord[9].SafeDeleteObject(); $GuardRecord[9] = SpNewNpc2(0, 411192001, "-5.58255 153.813 100.176", 0, 90); SetNpcInfluence($GuardRecord[9], 8);//�ʹ�̨��������1
			$GuardRecord[10].SafeDeleteObject(); $GuardRecord[10] = SpNewNpc2(0, 411192001, "5.53448 153.986 100.176", 0, 270); SetNpcInfluence($GuardRecord[10], 8);//�ʹ�̨��������2
			$GuardRecord[11].SafeDeleteObject(); $GuardRecord[11] = SpNewNpc2(0, 411192001, "-9.56103 105.187 100.215", 0, 90); SetNpcInfluence($GuardRecord[11], 8);//���Ž�������1
			$GuardRecord[12].SafeDeleteObject(); $GuardRecord[12] = SpNewNpc2(0, 411192001, "9.60087 105.141 100.215", 0, 270); SetNpcInfluence($GuardRecord[12], 8);//���Ž�������2
			$GuardRecord[13].SafeDeleteObject(); $GuardRecord[13] = SpNewNpc2(0, 411192001, "-9.0827 125.362 100.215", 0, 90); SetNpcInfluence($GuardRecord[13], 8);//��������������1
			$GuardRecord[14].SafeDeleteObject(); $GuardRecord[14] = SpNewNpc2(0, 411192001, "8.82353 125.362 100.215", 0, 270); SetNpcInfluence($GuardRecord[14], 8);//��������������2

			$GuardRecord[811190111, 2].SafeDeleteObject(); $GuardRecord[811190111, 2] = SpNewNpc2(0, 411190022, "-0.0547 177.037 102.691", 0, 180);//�ʹ����Ŵ�����
			$GuardRecord[811190112, 2].SafeDeleteObject(); $GuardRecord[811190112, 2] = SpNewNpc2(0, 411190022, "11.0838 186.349 102.688", 0, 270);//�ʹ����Ŵ�����
			$GuardRecord[811190113, 2].SafeDeleteObject(); $GuardRecord[811190113, 2] = SpNewNpc2(0, 411190022, "-11.615 186.444 102.688", 0, 90);//�ʹ����Ŵ�����
			$GuardRecord[811190111, 1].SafeDeleteObject(); $GuardRecord[811190111, 1] = SpNewNpc2(0, 411193026, "0.0891171 171.63 102.299", 0, 180); SetNpcInfluence($GuardRecord[811190111, 1], 8);// �ʹ����ŵ�����
			$GuardRecord[811190112, 1].SafeDeleteObject(); $GuardRecord[811190112, 1] = SpNewNpc2(0, 411193027, "14.761 186.525 102.299", 0, 090); SetNpcInfluence($GuardRecord[811190112, 1], 8);// �ʹ����ŵ�����
			$GuardRecord[811190113, 1].SafeDeleteObject(); $GuardRecord[811190113, 1] = SpNewNpc2(0, 411193028, "-15.1327 186.641 102.299", 0, 270); SetNpcInfluence($GuardRecord[811190113, 1], 8);// �ʹ����ŵ�����
				

			%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//��ȡ�سǷ�
			$NowGuardOrgID = %OrgIDA;//����Ĭ�ϵĻʹ�ռ�췽
			if (%OrgIDA <= 0)//û���سǷ���ϵͳ�س�
			{
				$MonsterRecord[1119, 0].SafeDeleteObject(); $MonsterRecord[1119, 0] = SpNewNpc2(0, 411193000, "-224.028 -207.323 80.4479", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[0], 8);//�ʹ��ڵĹ���
				$MonsterRecord[1119, 1].SafeDeleteObject(); $MonsterRecord[1119, 1] = SpNewNpc2(0, 411193001, "-211.861 -193.892 80.4479", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[1], 8);//�ʹ��ڵĹ���
				$MonsterRecord[1119, 2].SafeDeleteObject(); $MonsterRecord[1119, 2] = SpNewNpc2(0, 411193002, "-197.351 -206.463 80.4479", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[2], 8);//�ʹ��ڵĹ���
				$MonsterRecord[1119, 3].SafeDeleteObject(); $MonsterRecord[1119, 3] = SpNewNpc2(0, 411193003, "-188.981 -186.868 80.4479", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[3], 8);//�ʹ��ڵĹ���
				$MonsterRecord[1119, 4].SafeDeleteObject(); $MonsterRecord[1119, 4] = SpNewNpc2(0, 411193004, "-227.573 -184.843 80.4479", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[4], 8);//�ʹ��ڵĹ���
				$MonsterRecord[1119, 5].SafeDeleteObject(); $MonsterRecord[1119, 5] = SpNewNpc2(0, 411193005, "-232.540 -229.140 80.4479", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[5], 8);//�ʹ��ڵĹ���
				$MonsterRecord[1119, 6].SafeDeleteObject(); $MonsterRecord[1119, 6] = SpNewNpc2(0, 411193006, "-190.693 -226.349 80.4479", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[6], 8);//�ʹ��ڵĹ���
				$MonsterRecord[1119, 7].SafeDeleteObject(); $MonsterRecord[1119, 7] = SpNewNpc2(0, 411193007, "-210.748 -231.197 80.4479", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[7], 8);//�ʹ��ڵĹ���
				$MonsterRecord[1119, 8].SafeDeleteObject(); $MonsterRecord[1119, 8] = SpNewNpc2(0, 411193008, "-210.730 -181.239 80.4479", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[8], 8);//�ʹ��ڵĹ���
				$MonsterRecord[1119, 9].SafeDeleteObject(); $MonsterRecord[1119, 9] = SpNewNpc2(0, 411193009, "-211.266 -207.838 82.9667", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[9], 8);//�ʹ��ڵĹ���
				$MonsterRecord[1119, 10].SafeDeleteObject(); $MonsterRecord[1119, 10] = SpNewNpc2(0, 411193010, "-0.13025 48.3029 98.642", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[10], 8);//�ʹ���Ĺ��� ���Ŵ��ſ�
				$MonsterRecord[1119, 11].SafeDeleteObject(); $MonsterRecord[1119, 11] = SpNewNpc2(0, 411193011, "2.40701 98.6541 100.187", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[11], 8);//�ʹ���Ĺ��� ���Ž�ȥ
				$MonsterRecord[1119, 12].SafeDeleteObject(); $MonsterRecord[1119, 12] = SpNewNpc2(0, 411193012, "-32.2409 91.854 100.187", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[12], 8);//�ʹ���Ĺ���
				$MonsterRecord[1119, 13].SafeDeleteObject(); $MonsterRecord[1119, 13] = SpNewNpc2(0, 411193013, "34.4879 90.5260 100.187", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[13], 8);//�ʹ���Ĺ���
				$MonsterRecord[1119, 14].SafeDeleteObject(); $MonsterRecord[1119, 14] = SpNewNpc2(0, 411193014, "46.0869 108.767 100.152", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[14], 8);//�ʹ���Ĺ���
				$MonsterRecord[1119, 15].SafeDeleteObject(); $MonsterRecord[1119, 15] = SpNewNpc2(0, 411193015, "37.3157 181.582 100.209", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[15], 8);//�ʹ���Ĺ���
				$MonsterRecord[1119, 16].SafeDeleteObject(); $MonsterRecord[1119, 16] = SpNewNpc2(0, 411193016, "37.6171 150.025 100.223", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[16], 8);//�ʹ���Ĺ���
				$MonsterRecord[1119, 17].SafeDeleteObject(); $MonsterRecord[1119, 17] = SpNewNpc2(0, 411193017, "0.23341 145.325 100.225", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[17], 8);//�ʹ���Ĺ���  ��������
				$MonsterRecord[1119, 18].SafeDeleteObject(); $MonsterRecord[1119, 18] = SpNewNpc2(0, 411193018, "-42.125 144.052 100.225", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[18], 8);//�ʹ���Ĺ���
				$MonsterRecord[1119, 19].SafeDeleteObject(); $MonsterRecord[1119, 19] = SpNewNpc2(0, 411193019, "-37.1622 173.473 100.20", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[19], 8);//�ʹ���Ĺ���
				$MonsterRecord[1119, 20].SafeDeleteObject(); $MonsterRecord[1119, 20] = SpNewNpc2(0, 411193020, "-45.080 111.037 100.131", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[20], 8);//�ʹ���Ĺ���
				$MonsterRecord[1119, 21].SafeDeleteObject(); $MonsterRecord[1119, 21] = SpNewNpc2(0, 411193021, "-24.292 114.785 100.042", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[21], 8);//�ʹ���Ĺ���
				$MonsterRecord[1119, 22].SafeDeleteObject(); $MonsterRecord[1119, 22] = SpNewNpc2(0, 411193022, "26.6830 113.038 100.163", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[22], 8);//�ʹ���Ĺ���
				$MonsterRecord[1119, 23].SafeDeleteObject(); $MonsterRecord[1119, 23] = SpNewNpc2(0, 411193023, "-4.5945 120.883 100.215", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[23], 8);//�ʹ���Ĺ���
				$MonsterRecord[1119, 24].SafeDeleteObject(); $MonsterRecord[1119, 24] = SpNewNpc2(0, 411193024, "16.3514 201.885 102.299", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[24], 8);//�ʹ���Ĺ���
				$MonsterRecord[1119, 25].SafeDeleteObject(); $MonsterRecord[1119, 25] = SpNewNpc2(0, 411193025, "-18.643 202.280 102.299", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[25], 8);//�ʹ���Ĺ���
					
				

				%HuoDongMingCheng1 = GetHuoDongName("���﹥��", 1);
				%Txt1 = "<t>����û���سǷ������η�ħ�ǹ���ս����</t>" @ %HuoDongMingCheng1 @ "<t>ģʽ��</t>";
				SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Txt1 @ "</t>");
			}

			%PlayerCount = GetPlayerCount();
			for (%i = 0; %i < %PlayerCount; %i++)
			{
				%Player = GetPlayerByIndex(%i);
				if (isobject(%Player))
					InfluenceDispose(%Player);
			}

			%NextStep = 1;
			%Time = 60;
		case 1:

			%PlayerCount = GetPlayerCount();
			%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//��ȡ�سǷ�
			%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//��ý��칥�Ƿ�
			$NowPalaceManNumber = 0;
			$NowOrgMemberNum[%OrgIDA] = 0;
			$NowOrgMemberNum[%OrgIDB] = 0;
			for (%i = 0; %i < %PlayerCount; %i++)
			{
				%Player = GetPlayerByIndex(%i);
				if (isobject(%Player))
				{
					if (%Player.GetTriggerID() $= "811190200" && %Player.GetDamageState() $= "Enabled")
					{
						%OrgID = SptOrg_GetOrgID(%Player.GetPlayerID());		//����ID
						if ((%OrgID == %OrgIDA || %OrgID == %OrgIDB) && %OrgID > 0)
							$NowOrgMemberNum[%OrgID]++;
						$NowPalaceManNumber++;
					}
				}
			}


			%IsCanZhanLinh = 0;
			if ($NowPalaceManNumber == $NowOrgMemberNum[%OrgIDB] && $NowGuardOrgID != %OrgIDB && $NowGuardOrgID > 0)
			{
				%IsCanZhanLinh = 1;
				for (%i = 0; %i <= 9; %i++)
				{
					if ($MonsterRecord[1119, %i].GetDamageState() $= "Enabled")
					{
						%IsCanZhanLinh = 0;
						break;
					}
				}
				if (%IsCanZhanLinh == 1)
				{
					$NowGuardOrgID = %OrgIDB;//���ûʹ�ռ�췽
					%HuoDongMingCheng1 = GetHuoDongName("��ħ�ǻʹ�", 1);
					%HuoDongMingCheng2 = GetHuoDongName("��ħ�ǻʹ�", 2);
					%OrgName = SptOrg_GetName(%OrgIDB);		//��������
					if (%OrgName !$= "")
					{
						%OrgName1 = $Get_Dialog_GeShi[31421] @ "��" @ %OrgName @ "��</t>";
						%OrgName2 = $Get_Dialog_GeShi[60003] @ "��" @ %OrgName @ "��</t>";
						%Txt1 = "<t>����</t>" @ %OrgName1 @ "<t>ռ����</t>" @ %HuoDongMingCheng1 @ "<t>��ʤ��������</t>";
						%Txt2 = "<t>����</t>" @ %OrgName2 @ "<t>ռ����</t>" @ %HuoDongMingCheng2 @ "<t>��ʤ��������</t>";
						SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Txt1 @ "</t>");
						SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Txt2 @ "</t>", $chatMsg_Type_Normal2);
					}
				}
			}
			else if ($NowPalaceManNumber == $NowOrgMemberNum[%OrgIDA] && $NowGuardOrgID != %OrgIDA && $NowGuardOrgID > 0)
			{
				%IsCanZhanLinh = 1;
				for (%i = 0; %i <= 9; %i++)
				{
					if ($MonsterRecord[1119, %i].GetDamageState() $= "Enabled")
					{
						%IsCanZhanLinh = 0;
						break;
					}
				}
				if (%IsCanZhanLinh == 1)
				{
					$NowGuardOrgID = %OrgIDA;//���ûʹ�ռ�췽
					%HuoDongMingCheng1 = GetHuoDongName("��ħ�ǻʹ�", 1);
					%HuoDongMingCheng2 = GetHuoDongName("��ħ�ǻʹ�", 2);
					%OrgName = SptOrg_GetName(%OrgIDA);		//��������
					if (%OrgName !$= "")
					{
						%OrgName1 = $Get_Dialog_GeShi[31421] @ "��" @ %OrgName @ "��</t>";
						%OrgName2 = $Get_Dialog_GeShi[60003] @ "��" @ %OrgName @ "��</t>";
						%Txt1 = "<t>����</t>" @ %OrgName1 @ "<t>ռ����</t>" @ %HuoDongMingCheng1 @ "<t>��ʤ��������</t>";
						%Txt2 = "<t>����</t>" @ %OrgName2 @ "<t>ռ����</t>" @ %HuoDongMingCheng2 @ "<t>��ʤ��������</t>";
						SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Txt1 @ "</t>");
						SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Txt2 @ "</t>", $chatMsg_Type_Normal2);
					}
				}
				
			}
			
			echo("����������������ħ�ǡ�����������ÿ����ͳ�ơ���������");
			echo("$NowPalaceManNumber===" @ $NowPalaceManNumber);
			echo("$NowGuardOrgID===" @ $NowGuardOrgID);
			echo("$NowOrgMemberNum[" @ %OrgIDA @ "]===" @ $NowOrgMemberNum[%OrgIDA]);
			echo("$NowOrgMemberNum[" @ %OrgIDB @ "]===" @ $NowOrgMemberNum[%OrgIDB]);

			%NextStep = 1;
			%Time = 60;

			%H = GetWord(GetLocalTime(), 3);	//Сʱ
			%M = GetWord(GetLocalTime(), 4);	//Сʱ
			if (%H == 21 && %M == 20)
			{
				%HuoDongMingCheng1 = GetHuoDongName("��ħ�ǹ���ս", 1);
				%HuoDongMingCheng2 = GetHuoDongName("��ħ�ǹ���ս", 2);
				%Text1 = %HuoDongMingCheng1 @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ "10</t><t>���Ӻ������</t>";
				%Text2 = %HuoDongMingCheng2 @ "<t>����</t>" @ $Get_Dialog_GeShi[60002] @ "10</t><t>���Ӻ������</t>";
				SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
				SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
			}
			if (%H == 21 && %M == 29)
			{
				%HuoDongMingCheng1 = GetHuoDongName("��ħ�ǹ���ս", 1);
				%HuoDongMingCheng2 = GetHuoDongName("��ħ�ǹ���ս", 2);
				%Text1 = %HuoDongMingCheng1 @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ "1</t><t>���Ӻ������</t>";
				%Text2 = %HuoDongMingCheng2 @ "<t>����</t>" @ $Get_Dialog_GeShi[60002] @ "1</t><t>���Ӻ������</t>";
				SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
				SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
				%NextStep = 2;
			}
		case 2://����
			$IsAttackCityWar_State_bActive = 0;//��ǽ���
			%NextStep = 1;
			%Time = 0;
			//ˢ������NPC
			$NpcRecord[1].SafeDeleteObject(); $NpcRecord[1] = SpNewNpc2(0, 411190002, "26.479 121.168 100.905", 0, 180);//����ͷ
			$NpcRecord[2].SafeDeleteObject(); $NpcRecord[2] = SpNewNpc2(0, 411190017, "30.266 109.866 100.163", 0, 270);//��ǧ��
			$NpcRecord[3].SafeDeleteObject(); $NpcRecord[3] = SpNewNpc2(0, 411190021, "26.009 106.013 100.167", 0, 0);//���
			$NpcRecord[4].SafeDeleteObject(); $NpcRecord[4] = SpNewNpc2(0, 411190019, "-24.58 110.175 100.045", 0, 0);//����
			$NpcRecord[5].SafeDeleteObject(); $NpcRecord[5] = SpNewNpc2(0, 411190018, "-29.65 114.936 100.043", 0, 90);//³��ʦ
			$NpcRecord[6].SafeDeleteObject(); $NpcRecord[6] = SpNewNpc2(0, 411190020, "-24.92 120.603 100.048", 0, 180);//����
			$NpcRecord[7].SafeDeleteObject(); $NpcRecord[7] = SpNewNpc2(0, 411190023, "-213.1 -209.62 82.9667", 0, 180);//��ħ�ǹ���Ա
			

			$GuardRecord[1].SafeDeleteObject(); $GuardRecord[1] = SpNewNpc2(0, 411192001, "-74.390 149.824 100", 0, 270); SetNpcInfluence($GuardRecord[1], 6);//����A
			$GuardRecord[2].SafeDeleteObject(); $GuardRecord[2] = SpNewNpc2(0, 411192001, "-74.027 140.621 100", 0, 270); SetNpcInfluence($GuardRecord[2], 6);//����B
			$GuardRecord[3].SafeDeleteObject(); $GuardRecord[3] = SpNewNpc2(0, 411192001, "-6.7458 62.7418 101", 0, 180); SetNpcInfluence($GuardRecord[3], 6);//����A
			$GuardRecord[4].SafeDeleteObject(); $GuardRecord[4] = SpNewNpc2(0, 411192001, "6.87547 62.7418 101", 0, 180); SetNpcInfluence($GuardRecord[4], 6);//����B
			$GuardRecord[5].SafeDeleteObject(); $GuardRecord[5] = SpNewNpc2(0, 411192001, "72.9715 140.391 100", 0, 090); SetNpcInfluence($GuardRecord[5], 6);//����A
			$GuardRecord[6].SafeDeleteObject(); $GuardRecord[6] = SpNewNpc2(0, 411192001, "72.9566 149.813 100", 0, 090); SetNpcInfluence($GuardRecord[6], 6);//����B
			$GuardRecord[7].SafeDeleteObject(); $GuardRecord[7] = SpNewNpc2(0, 411192001, "28.088 152.222 100.176", 0, 180); SetNpcInfluence($GuardRecord[7], 6);//���Ž�������
			$GuardRecord[8].SafeDeleteObject(); $GuardRecord[8] = SpNewNpc2(0, 411192001, "-28.0139 152.241 100.176", 0, 180); SetNpcInfluence($GuardRecord[8], 6);//���Ž�������
			$GuardRecord[9].SafeDeleteObject(); $GuardRecord[9] = SpNewNpc2(0, 411192001, "-5.58255 153.813 100.176", 0, 90); SetNpcInfluence($GuardRecord[9], 6);//�ʹ�̨��������1
			$GuardRecord[10].SafeDeleteObject(); $GuardRecord[10] = SpNewNpc2(0, 411192001, "5.53448 153.986 100.176", 0, 270); SetNpcInfluence($GuardRecord[10], 6);//�ʹ�̨��������2
			$GuardRecord[11].SafeDeleteObject(); $GuardRecord[11] = SpNewNpc2(0, 411192001, "-9.0827 101.712 100.187", 0, 90); SetNpcInfluence($GuardRecord[11], 6);//���Ž�������1
			$GuardRecord[12].SafeDeleteObject(); $GuardRecord[12] = SpNewNpc2(0, 411192001, "8.82353 101.712 100.187", 0, 270); SetNpcInfluence($GuardRecord[12], 6);//���Ž�������2
			$GuardRecord[13].SafeDeleteObject(); $GuardRecord[13] = SpNewNpc2(0, 411192001, "-9.0827 125.362 100.215", 0, 90); SetNpcInfluence($GuardRecord[13], 6);//��������������1
			$GuardRecord[14].SafeDeleteObject(); $GuardRecord[14] = SpNewNpc2(0, 411192001, "8.82353 125.362 100.215", 0, 270); SetNpcInfluence($GuardRecord[14], 6);//��������������2

			$GuardRecord[811190111, 1].SafeDeleteObject(); //�ʹ����ŵ�����
			$GuardRecord[811190112, 1].SafeDeleteObject(); //�ʹ����ŵ�����
			$GuardRecord[811190113, 1].SafeDeleteObject(); //�ʹ����ŵ�����
			$GuardRecord[811190111, 2].SafeDeleteObject(); $GuardRecord[811190111, 2] = SpNewNpc2(0, 411190022, "-0.0547 177.037 102.691", 0, 180);//�ʹ����Ŵ�����
			$GuardRecord[811190112, 2].SafeDeleteObject(); $GuardRecord[811190112, 2] = SpNewNpc2(0, 411190022, "11.0838 186.349 102.688", 0, 270);//�ʹ����Ŵ�����
			$GuardRecord[811190113, 2].SafeDeleteObject(); $GuardRecord[811190113, 2] = SpNewNpc2(0, 411190022, "-11.615 186.444 102.688", 0, 90);//�ʹ����Ŵ�����

			for (%i = 0; %i <=25; %i++)
			{
				if (isobject($MonsterRecord[1119,%i]))
					$MonsterRecord[1119,%i].SafeDeleteObject();
			}
			//ս����������
			%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//��ȡ�سǷ�
			%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//��ý��칥�Ƿ�
			if ($NowGuardOrgID == %OrgIDA && $NowGuardOrgID > 0)//�سǳɹ�
			{
				SptOrg_AttackCityFail(%OrgIDB);//����ʧ��
				$AttackCityRecordDefend = %OrgIDA;
				%HuoDongMingCheng1 = GetHuoDongName("��ħ��", 1);
				%HuoDongMingCheng2 = GetHuoDongName("��ħ��", 2);
				%OrgName = SptOrg_GetName(%OrgIDA);		//��������
				%OrgName1 = $Get_Dialog_GeShi[31421] @ "��" @ %OrgName @ "��</t>";
				%OrgName2 = $Get_Dialog_GeShi[60003] @ "��" @ %OrgName @ "��</t>";
				%Txt1 = "<t>����</t>" @ %OrgName1 @ "<t>����ԡѪ��ս���ɹ���ס��</t>" @ %HuoDongMingCheng1 @ "<t>���������»��к�������ս���ǣ�</t>";
				%Txt2 = "<t>����</t>" @ %OrgName2 @ "<t>����ԡѪ��ս���ɹ���ס��</t>" @ %HuoDongMingCheng2 @ "<t>���������»��к�������ս���ǣ�</t>";
				SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Txt1 @ "</t>");
				SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Txt2 @ "</t>", $chatMsg_Type_Normal2);
			}
			else if ($NowGuardOrgID == %OrgIDB && $NowGuardOrgID > 0)//���ǳɹ�
			{
				SptOrg_AttackCitySuccess(%OrgIDB);//���ǳɹ�
				$AttackCityRecordDefend = %OrgIDB;
				%HuoDongMingCheng1 = GetHuoDongName("��ħ��", 1);
				%HuoDongMingCheng2 = GetHuoDongName("��ħ��", 2);
				%OrgName = SptOrg_GetName(%OrgIDB);		//��������
				%OrgName1 = $Get_Dialog_GeShi[31421] @ "��" @ %OrgName @ "��</t>";
				%OrgName2 = $Get_Dialog_GeShi[60003] @ "��" @ %OrgName @ "��</t>";
				%Txt1 = "<t>����</t>" @ %OrgName1 @ "<t>����ԡѪ��ս���ɹ�ռ����</t>" @ %HuoDongMingCheng1 @ "<t>���������������¡�</t>";
				%Txt2 = "<t>����</t>" @ %OrgName2 @ "<t>����ԡѪ��ս���ɹ�ռ����</t>" @ %HuoDongMingCheng2 @ "<t>���������������¡�</t>";
				SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Txt1 @ "</t>");
				SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Txt2 @ "</t>", $chatMsg_Type_Normal2);
			}
			else if (%OrgIDA > 0)//Ĭ�Ϲ��Ǿ���ʧ�ܵ�
			{
				SptOrg_AttackCityFail(%OrgIDB);//����ʧ��
				$AttackCityRecordDefend = %OrgIDA;
				%HuoDongMingCheng1 = GetHuoDongName("��ħ��", 1);
				%HuoDongMingCheng2 = GetHuoDongName("��ħ��", 2);
				%OrgName = SptOrg_GetName(%OrgIDA);		//��������
				%OrgName1 = $Get_Dialog_GeShi[31421] @ "��" @ %OrgName @ "��</t>";
				%OrgName2 = $Get_Dialog_GeShi[60003] @ "��" @ %OrgName @ "��</t>";
				%Txt1 = "<t>����</t>" @ %OrgName1 @ "<t>����ԡѪ��ս���ɹ���ס��</t>" @ %HuoDongMingCheng1 @ "<t>��˭���ܼ�����ս���ǣ�</t>";
				%Txt2 = "<t>����</t>" @ %OrgName2 @ "<t>����ԡѪ��ս���ɹ���ס��</t>" @ %HuoDongMingCheng2 @ "<t>��˭���ܼ�����ս���ǣ�</t>";
				SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Txt1 @ "</t>");
				SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Txt2 @ "</t>", $chatMsg_Type_Normal2);
			}
			%PlayerCount = GetPlayerCount();
			for (%i = 0; %i < %PlayerCount; %i++)
			{
				%Player = GetPlayerByIndex(%i);
				if (isobject(%Player))
					InfluenceDispose(%Player);
			}
	}
	if (%Time > 0)
		$AttackCityWarStates = schedule(%Time * 1000, 0, "AttackCityWarStates", %NextStep);
}
function SetNpcInfluence(%Caster, %Influence)
{
	CanCel(%Caster.SetInfluence);
	%Caster.SetInfluence =	Schedule(3000, 0, "eval", %Caster @ ".SetInfluence(" @ "\"" @ %Influence @ "\"" @ "); ");
}
//������������������ħ�ǡ�������������ս���̹��̡�����������������


//������������������ħ�ǡ�������������Ҹ����������������������

function PlayerSetEnabled_1119(%Player)
{
	//echo("��������ħ�ǡ�������������Ҹ����������");
	//�������
	if (%Player.GetDamageState() $= "Disabled")
	{
		//���͵������
		%Posx = GetRandom(-5, 5);
		%Posy = GetRandom(140, 150);
		%Player.TransportObject(0, 0, %Posx, %Posy, 100.225);
		//��������
		%Player.SetDamageState(Enabled);
		//��ӻ�Ѫ״̬
		%Player.AddBuff(399020200, %Player, 50);

	}
}
//������������������ħ�ǡ�������������Ҹ����������������������


//������������������ħ�ǡ������������������򴥷�������������������
function PlayerEnterTrigger_811190200(%Player, %TriggerId)//����ʹ�
{
	%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//��ȡ�سǷ�
	%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//��ý��칥�Ƿ�
	%OrgID = SptOrg_GetOrgID(%Player.GetPlayerID());		//����ID
	if ((%OrgID == %OrgIDA || %OrgID == %OrgIDB) && %OrgID > 0)
		$NowOrgMemberNum[%OrgID]++;
	$NowPalaceManNumber++;
	echo("����������������ħ�ǡ���������������ʹ���������������");
	echo("$NowPalaceManNumber===" @ $NowPalaceManNumber);
	echo("$NowOrgMemberNum[" @ %OrgID @ "]===" @ $NowOrgMemberNum[%OrgID]);
	if ($IsAttackCityWar_State_bActive == 1)
	{
		if (($NowPalaceManNumber == $NowOrgMemberNum[%OrgIDA] && $NowGuardOrgID != %OrgIDA) || ($NowPalaceManNumber == $NowOrgMemberNum[%OrgIDB] && $NowGuardOrgID != %OrgIDB))
		{
			for (%i = 0; %i <= 9; %i++)
			{
				if ($MonsterRecord[1119, %i].GetDamageState() $= "Enabled")
					return;
			}
			$AttackCityWarStates = schedule(1000, 0, "AttackCityWarStates", 1);
		}
	}
}
function PlayerOnExitTrigger_811190200(%Player)
{
	%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//��ȡ�سǷ�
	%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//��ý��칥�Ƿ�
	%OrgID = SptOrg_GetOrgID(%Player.GetPlayerID());		//����ID
	if ($NowOrgMemberNum[%OrgID] > 0)
		$NowOrgMemberNum[%OrgID]--;
	$NowPalaceManNumber--;

	echo("����������������ħ�ǡ������������뿪�ʹ���������������");
	echo("$NowPalaceManNumber===" @ $NowPalaceManNumber);
	echo("$NowOrgMemberNum[" @ %OrgID @ "]===" @ $NowOrgMemberNum[%OrgID]);

	if ($IsAttackCityWar_State_bActive == 1)
	{
		if (($NowPalaceManNumber == $NowOrgMemberNum[%OrgIDA] && $NowGuardOrgID != %OrgIDA) || ($NowPalaceManNumber == $NowOrgMemberNum[%OrgIDB] && $NowGuardOrgID != %OrgIDB))
		{
			for (%i = 0; %i <= 9; %i++)
			{
				if ($MonsterRecord[1119, %i].GetDamageState() $= "Enabled")
					return;
			}
			$AttackCityWarStates = schedule(1000, 0, "AttackCityWarStates", 1);
		}
	}
}
function PlayerEnterTrigger_811190111(%Player, %TriggerId){ PlayerEnterTrigger_811190111_811190113(%Player, %TriggerId); }//���� -0.0547 177.037 102.691
function PlayerEnterTrigger_811190112(%Player, %TriggerId){ PlayerEnterTrigger_811190111_811190113(%Player, %TriggerId); }//���� 11.0838 186.349 102.688
function PlayerEnterTrigger_811190113(%Player, %TriggerId){ PlayerEnterTrigger_811190111_811190113(%Player, %TriggerId); }//���� -11.615 186.444 102.688
function PlayerEnterTrigger_811190111_811190113(%Player, %TriggerId)
{
	if ($IsAttackCityWar_State_bActive == 1)//�����ڼ�
	{
		if ($GuardRecord[%TriggerId, 1].GetDamageState() !$= "Enabled")//û�����������ʹ�
			TransObjectToPalace(%Player, %TriggerId);
		else
		{
			if (%Player.GetInfluence() == 2 || %Player.GetInfluence() == 4 || %Player.GetInfluence() == 6 || %Player.GetInfluence() == 8)
				TransObjectToPalace(%Player, %TriggerId);
			else
			{
				SendOneScreenMessage(2, "��Ҫ�Ȼ��ܴ���������", %Player);
				SendOneChatMessage($chatMsg_System, "<t>��Ҫ�Ȼ��ܴ������������Ž���ʹ���</t>", %Player);
				return;
			}
		}
			
	}
	else//�ǹ���ʱ��
	{
		if (%Player.GetInfluence() == 2 || %Player.GetInfluence() == 4 || %Player.GetInfluence() == 6 || %Player.GetInfluence() == 8)
			TransObjectToPalace(%Player,0);
		else
		{
			SendOneScreenMessage(2, "�����Ƿ�ħ�ǰ��ɳ�Ա���޷�����ʹ�", %Player);
			SendOneChatMessage($chatMsg_System, "<t>�����Ƿ�ħ�ǰ��ɳ�Ա���޷�����ʹ���</t>", %Player);
			return;
		}
	}
}
function TransObjectToPalace(%Player,%Step)//���ͽ���ʹ�
{
	switch (%Step)
	{
		case 0:%Player.TransportObject(0, 0, -210.912, -219.086, 80.4479);
		case 811190111:%Player.TransportObject(0, 0, -210.734, -232.243, 80.4479);
		case 811190112:%Player.TransportObject(0, 0, -186.717, -206.633, 80.4479);
		case 811190113:%Player.TransportObject(0, 0, -234.048, -206.425, 80.4479);
	}
}
//������������������ħ�ǡ������������������򴥷�������������������



//������������������ħ�ǡ��������������ǹ��ﱻ���ܡ���������������
function NpcObjectonDeathcast_411193000(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193001(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193002(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193003(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193004(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193005(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193006(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193007(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193008(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193009(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193010(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193011(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193012(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193013(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193014(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193015(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193016(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193017(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193018(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193019(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193020(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193021(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193022(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193023(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193024(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193025(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer)
{
	for (%i = 0; %i <= 9; %i++)
	{
		if ($MonsterRecord[1119,%i].GetDamageState() $= "Enabled")
			return;
	}
	if ($IsAttackCityWar_State_bActive != 1)
		return;
	%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//��ý��칥�Ƿ�
	$NowGuardOrgID = %OrgIDB;
	AttackCityWarStates(2);
	
}

function NpcObjectonDeathcast_411193026(%Monster, %Killer)//�ʹ����ŵ�����
{
	$GuardRecord[811190111, 1].SafeDeleteObject();
	//$GuardRecord[811190111, 2].SafeDeleteObject(); $GuardRecord[811190111, 2] = SpNewNpc2(0, 411190022, "-0.0547 177.037 102.691", 0, 0);//�ʹ����Ŵ�����
}
function NpcObjectonDeathcast_411193027(%Monster, %Killer)//�ʹ����ŵ�����
{
	$GuardRecord[811190112, 2].SafeDeleteObject();
	//$GuardRecord[811190112, 2].SafeDeleteObject(); $GuardRecord[811190112, 2] = SpNewNpc2(0, 411190022, "11.0838 186.349 102.688", 0, 0);//�ʹ����Ŵ�����
}
function NpcObjectonDeathcast_411193028(%Monster, %Killer)//�ʹ����ŵ�����
{
	$GuardRecord[811190113, 2].SafeDeleteObject();
	//$GuardRecord[811190113, 2].SafeDeleteObject(); $GuardRecord[811190113, 2] = SpNewNpc2(0, 411190022, "-11.615 186.444 102.688", 0, 0);//�ʹ����Ŵ�����
}
//������������������ħ�ǡ��������������ǹ��ﱻ���ܡ���������������

//������������������ħ�ǡ���������������ԱNPC�Ի� ����������������
function NpcDiaLog_411190023(%Npc, %Player, %State, %Conv)
{
	switch (%State)
	{
		case 0:
			%Conv.AddOption(100086, 100086);//�ƺ���ȡ
		case 100086:
			%Conv.Settype(4);
			%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//��ȡ�سǷ�
			%OrgID = SptOrg_GetOrgID(%Player.GetPlayerID());		//����ID
			if (%OrgIDA != %OrgID && %OrgID > 0)
				return;
			%MemberLevel = %Player.GetOrgMemberLevel(1);
			switch (%MemberLevel)
			{
				//1664	��ħ�ɱ� 1665	��ħ���� 1666	��ħ�ɽ� 1667	��ħ����
				case 0:%Des = 1664;//�½�����
				case 1:%Des = 1664;//��ͨ��Ա
				case 2:%Des = 1665;//�߼���Ա
				case 3:%Des = 1665;//��Ӣ��Ա
				case 4:%Des = 1666;//Ԫ�ϳ�Ա
				case 5:%Des = 1666;//������
				case 6:%Des = 1667;//����
			}
			if (!%Player.sptIsDesignationExist(%Des))
			{
				%Player.AddDesignation(%Des);//��ӳƺ�
				%Player.SetCurDesignationIDZone(%Des);//���ô˳ƺ�Ϊ��ǰ����ʹ�õĳƺ�
				SendOneScreenMessage(1, "��ȡ�ɹ�", %Player);
			}
	}
}
//������������������ħ�ǡ���������������ԱNPC�Ի� ����������������


//������������������ħ�ǡ������������ƺ�������������������������
function Refresh_FengMoCityDesignation(%Player)
{


	%OrgID = SptOrg_GetOrgID(%Player.GetPlayerID());		//����ID
	for (%des = 1664; %des <= 1667; %des++)
	{
		if (%Player.sptIsDesignationExist(%Des) && %OrgID != $AttackCityRecordDefend)
			%Player.DelDesignation(%Des);
	}
}
//������������������ħ�ǡ������������ƺ�������������������������

//������������������ħ�ǡ������������������񡿡�������������������
function Refresh_CityOwner()
{
	%MapID = GetZoneID();
	if (%MapID != 1001)
		return;
	if (!isobject($CityOwner) && $AttackCityRecordDefend > 0)
	{

		%MasterID = SptOrg_GetMaster($AttackCityRecordDefend);//�峤ID

		%OrgName = SptOrg_GetName($AttackCityRecordDefend);
		%PlayerName = "";
		%PlayerSex = 1;
		switch (%PlayerSex)
		{
			case 1:%Npcid = 410010226;
			case 2:%Npcid = 410010227;
			default:%Npcid = 410010225;
		}

		$CityOwner = SpNewNpc2(0, %Npcid, "-8.88375 1.40263 194.489", 0, 90);
		$CityOwner.SetShapeName(%PlayerName);//��������Ϊ��ռ�췽��������
		$CityOwner.SetExclusivePlayerName(%OrgName);//���óƺ�Ϊ��ռ�췽�������ƣ����ã�
	}
}
