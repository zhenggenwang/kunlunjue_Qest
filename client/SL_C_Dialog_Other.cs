//�����������������������Ի��ı����ű�����ڡ���������������������������������
//����������������������ͨ����Ի�����ϡ�������������������������������������
//����������������������������Ի�����ϡ�������������������������������������

//������������������������������������ϡ�������������������������������������
//����������������������������Ի�����ϡ�������������������������������������
//����������������������������Ի�����ϡ�������������������������������������
//����������������������״̬��Ի�����ϡ�������������������������������������
//����������������������NPC��Ի�����ϡ�������������������������������������
//������������������������������ضԻ�����������������������������������������
//������������������������������ضԻ�����������������������������������������
//������������������������������ضԻ�����������������������������������������

//�����������������������Ͻɽ�������˵����������������������������������������
//������������������������Ϸ�ҵĸ�ʽ������������������������������������������
//������������������������������ǰ��ͼ���������������������������������������


//�����������������������Ի��ı����ű�����ڡ���������������������������������
function GetDialogText(%Npc,%Player,%DialogID,%Param)
{
	//echo( "-=======================" );
	//echo( "%DialogID====" @ %DialogID );
	//echo( "%Npc====" @ %Npc );
	//echo( "%Player====" @ %Player );
	//echo( "%Param====" @ %Param );
	$Recordconversationnpc =  %Npc;
	//С��7λ�Ľ����̵���Ի�
	if (strlen(%DialogID) <= 7)return Get_Shop_Dialog(%Npc,%Player,%DialogID,%Param);
	else if (strlen(%DialogID) == 8)return Get_Mission_Dialog(%Npc,%Player,%DialogID,%Param);	//������Ի�
	//9λ��ŵ���ضԻ�
	else if (strlen(%DialogID) == 9)
	{
		//��������ID�����ֱ�����ͣ�Ҳ�����ݱ����λ�������жϱ������
		//�����λ��������ʶ��ȡֵ��ΧΪ1-9��Ŀǰ��ȷ����
		%Dialog_SubStr = GetSubStr(%DialogID,0,1);

		if (%Dialog_SubStr $= "1"){ return Get_Item_Dialog(%Npc,%Player,%DialogID,%Param); }	//1������
		else if (%Dialog_SubStr $= "2"){ return Get_Skill_Dialog(%Npc,%Player,%DialogID,%Param); }	//2������
		else if (%Dialog_SubStr $= "3"){ return Get_Buff_Dialog(%Npc,%Player,%DialogID,%Param); }	//3��״̬
		else if (%Dialog_SubStr $= "4"){ return Get_Npc_Dialog(%Npc,%Player,%DialogID,%Param); }	//4��NPC
		else if (%Dialog_SubStr $= "5"){ return Get_Transport_Dialog(%Npc,%Player,%DialogID,%Param); }	//5������
		else if (%Dialog_SubStr $= "6"){ return Get_TY_Dialog(%Npc,%Player,%DialogID,%Param); }	//6�����ؾ������ű�
		else if (%Dialog_SubStr $= "7"){ return Get_HuoDong_Dialog(%Npc,%Player,%DialogID,%Param); }
		else if (%Dialog_SubStr $= "8"){ return Get_Area_Dialog(%Npc,%Player,%DialogID,%Param); }	//8������
		else if (%Dialog_SubStr $= "9"){ return Get_Fly_Dialog(%Npc,%Player,%DialogID,%Param); }	//9����δȷ��
	}
	if (strlen(%DialogID) == 10)
		return Get_YGBH_Dialog(%Npc,%Player,%DialogID,%Param);	//�¹ⱦ�����

	return "GetDialogText == ���� Npc��"@%Npc@"��Player��"@%Player@"��DialogID��"@%DialogID@"��Id��"@%Param@"��";
}

//����������������������ͨ����Ի�����ϡ�������������������������������������
function Get_TY_Dialog(%Npc,%Player,%DialogID,%Param)
{
	return Get_TY_Dialog_TY(%Npc,%Player,%DialogID,%Param);
}

//����������������������������Ի�����ϡ�������������������������������������
function Get_Mission_Dialog(%Npc,%Player,%DialogID,%Param)
{
	%Tid = GetSubStr(%DialogID,0,3);
	%Mid = GetSubStr(%DialogID,3,5);
	%kind       	= GetMissionKind(%Mid);
	%Mid_LeiXin 	= $MissionKind[%kind,2];
	//echo( "%tid===" @ %tid );
	//����ָ�� - ������Ի���ʱ����
	if (%Npc > 0)
		Get_Mission_Dialog_ZhiYinWed(%Player,%DialogID);

	//echo( "%Tid====" @ %Tid );
	//��������Ի�
	if (%Tid == 100)
	{

		//echo("�����ȡ����ѡ����ʾ===" @ GetMissionKind(%Mid));
		if (GetMissionKind(%Mid) == 1)
			return GetMissionIcon(%Mid) @ $Get_Dialog_GeShi[31492] @ %Mid_LeiXin @ "��" @ GetMission_Name(%Player,%Mid,1) @ "</t>";	//��ȡ
		else
		{
			if (%Mid == 20036 || %Mid == 20043 || %Mid == 20050 || %Mid == 20057 || %Mid == 20064)
			{
				%class0 = %player.GetClasses(0);
				switch (%class0)
				{
					case 1:%HvaeShengWang = GetPrestige(%Player, 1, 1);
					case 2:%HvaeShengWang = GetPrestige(%Player, 1, 4);
					case 3:%HvaeShengWang = GetPrestige(%Player, 1, 2);
					case 4:%HvaeShengWang = GetPrestige(%Player, 1, 3);
					case 5:%HvaeShengWang = GetPrestige(%Player, 1, 5);
				}
				if (%HvaeShengWang < 10000)
					return GetMissionIcon(%Mid) @ $Get_Dialog_GeShi[31494] @ %Mid_LeiXin @ "��" @ GetMission_Name(%Player, %Mid, 1) @ "</t>";	//��ȡ
				else
					return GetMissionIcon(%Mid) @ $Get_Dialog_GeShi[31496] @ %Mid_LeiXin @ "��" @ GetMission_Name(%Player, %Mid, 1) @ "</t>";	//��ȡ
			}
			else
				return GetMissionIcon(%Mid) @ $Get_Dialog_GeShi[31496] @ %Mid_LeiXin @ "��" @ GetMission_Name(%Player, %Mid, 1) @ "</t>";	//��ȡ
		}
	}
	else if (%Tid == 900)
	{
		if (CanDoThisMission(%Player,%Mid,2,0,0) $= "")
			%Mid_Over = "����ɣ�";
		else
			%Mid_Over = "";

		return $Icon[2] @ $Get_Dialog_GeShi[31493] @ %Mid_LeiXin @ "��" @ GetMission_Name(%Player,%Mid,1) @ %Mid_Over @ "</t>";	//����
	}
	else if (%Tid == 999)
	{
		%Step = $Get_Dialog_GeShi[31492] @ %Mid_LeiXin @ %Mid @ " - " @ GetMission_Name(%Player,%Mid,1) @ "  [δ���]</t>";

		if (%Player.IsAcceptedMission(%Mid)){ %Step = $Get_Dialog_GeShi[31402] @ %Mid_LeiXin @ %Mid  @ " - " @ GetMission_Name(%Player,%Mid,1) @ "  [�ѽ���]</t>"; }
		if (%Player.IsFinishedMission(%Mid)){ %Step = $Get_Dialog_GeShi[31493] @ %Mid_LeiXin @ %Mid  @ " - " @ GetMission_Name(%Player,%Mid,1) @ "  [�Ѿ����]</t>"; }

		return %Step;
	}
	//��������ʾ�������ʱ�Ի�
	else if (%Tid == 110) return "<b/>" @ Get_Mis_Dialog(%Npc,%Player,%Mid,2,0) @ $Icon[97] @ "<b/>" @ GetMissionHortation(%Mid,1,10050);
	//��ʾ���񽻸�����������ʱ�ĶԻ�
	else if (%Tid == 199) return Get_Mis_Dialog(%Npc,%Player,%Mid,2,0) @ $Icon[97] @ "<b/>" @ GetMissionHortation(%Mid,0,10050);
	//��ʾ������;NPC�ĶԻ���ѡ��
	else if (%Tid == 200) return $Icon[4] @ $Get_Dialog_GeShi[31492] @  "�Ի� �� " @ GetMission_Name(%Player,%Mid,1) @ "</t>"; //��;
	//��ʾ������ѡ��
	else if (%Tid == 201) return $Icon[4] @ $Get_Dialog_GeShi[31492] @  "���� �� " @ GetMission_Name(%Player,%Mid,1) @ "</t>"; //����
	//������Ի�����ʾ������;NPC�ĶԻ���ѡ��
	else if (%Tid == 202) return $Icon[4] @ $Get_Dialog_GeShi[50012] @  "�Ի� �� " @ GetMission_Name(%Player,%Mid,1) @ "</t>"; //��;
	//������Ի�����ʾ������ѡ��
	else if (%Tid == 203) return $Icon[4] @ $Get_Dialog_GeShi[50015] @  "���� �� " @ GetMission_Name(%Player,%Mid,1) @ "</t>"; //����

	//�������+������,��ʾ���񽻸�ʱ�Ի�
	else if (%Tid == 910) return "<b/>" @ Get_Mis_Dialog(%Npc,%Player,%Mid,5,0) @ "<b/>" @ $Icon[97] @ "<b/>" @ GetMissionHortation(%Mid,2,10050);

	//20003,,����׷�ٴ����ȸ����֣�����Ŀ��+������
	else if (%Tid == 800)
	{
		//���û����û�������Ǿ���ʾ�ɽ��������
		if (!%Player.IsAcceptedMission(%Mid))
			return $Get_Dialog_GeShi[31401] @ Get_Mis_Dialog(%Npc,%Player,%Mid,1,0) @ GetMission_Flag(%Player,%Mid,"Npc",100,3) @ "</t><b/>" @ $Icon[97] @ "<b/>" @ GetMissionHortation(%Mid,0,10010) @ "</t>";
		else
			return $Get_Dialog_GeShi[31401] @ Get_Mis_Dialog(%Npc,%Player,%Mid,1,0) @ GetMissionNeedText(%Player,%Mid,9999) @ $Icon[97] @ "<b/>" @ GetMissionHortation(%Mid,0,10010) @ "</t>";
	}

	//20010,3+1+6+2+4,�����Ѷ�+Ŀ��+����+����+����,���������ʹ��
	else if (%Tid == 888)
	{
		//���û����û�������Ǿ���ʾ�ɽ��������
		if (!%Player.IsAcceptedMission(%Mid))
			return $Get_Dialog_GeShi[31401] @ Get_Mis_Dialog(%Npc,%Player,%Mid,1,0) @ GetMission_Flag(%Player,%Mid,"Npc",100,3) @ "</t>";
		else
			return $Get_Dialog_GeShi[31401] @ Get_Mis_Dialog(%Npc,%Player,%Mid,1,0) @ GetMissionNeedText(%Player,%Mid,9999) @ Get_Mis_Dialog(%Npc,%Player,%Mid,2,0) @ "</t>";
	}

	//�������ڵĲ鿴ʹ��
	else if (%Tid == 889)
	{
		//��ʾ������� + �Ƿ��ȡ�ж�

		//�Ѿ����ܣ���ʾ�ѽ���
		if (%Player.IsAcceptedMission(%Mid))
			%MidTxt = $Get_Dialog_GeShi[31403] @ " �������ڽ��д�����</t>";	//��ɫ����
		else
		{
			//δ��ȡ���

			//��������
			if (%Player.IsFinishedMission(%Mid))
				%MidTxt = $Get_Dialog_GeShi[31404] @ " �����Ѿ���ɴ�����</t>";	//��ɫ����
			else
			{
				//δ������

				//�����ȡ����
				if (CanDoThisMission(%Player,%Mid,1,0,0) !$= "")
					%MidTxt = $Get_Dialog_GeShi[31401] @ " ��</t>" @ $Get_Dialog_GeShi[31406] @ "����δ��ȡ������</t><b/>" @	//��ɫ����
					$Get_Dialog_GeShi[31401] @ " ��</t>" @ $Get_Dialog_GeShi[31406] @ "�������������Ľ�ȡ����</t>";	//��ɫ����
				else
					%MidTxt = $Get_Dialog_GeShi[31401] @ " ��</t>" @ $Get_Dialog_GeShi[31406] @ "����δ��ȡ������</t><b/>" @	//��ɫ����
					$Get_Dialog_GeShi[31404] @ " �������������Ľ�ȡ����</t><b/>" @	//��ɫ����
					GetMission_Flag(%Player,%Mid,"Npc",100,3) @ "</t>";	//������NPC
			}
		}

		return $Get_Dialog_GeShi[31401] @ Get_Mis_Dialog(%Npc,%Player,%Mid,1,0) @ %MidTxt;
	}
	else if (%Tid == 820)
	{
		return Get_Mis_Dialog(%Npc,%Player,%Mid,1,0) @ Get_Mis_Dialog(%Npc,%Player,%Mid,2,0);
	}

	//�Զ��������ż���������������ȥ����ִ����Ӧ�ĺ�����Ѱ��ʣ��Ի�
	%MDFunction = "Mission" @ %Mid @ "Dialog" @ "(%Npc, %Player, %Mid, %Tid);";
	return eval(%MDFunction);
}


//������������������������������������ϡ�������������������������������������
function Get_Mis_Dialog(%Npc,%Player,%Mid,%Tid,%State)
{
	//echo( " %Tid===" @  %Tid );
	//����ͨ������
	switch (%Tid)
	{
		case 1:
			%T10001 = eval("Mission" @ %Mid @ "Dialog" @ "(%Npc, %Player, %Mid, 10001);");	//"����Ŀ��";
			%Txt = $Icon[98] @ "<b/>" @ %T10001 @ "<b/>";

		case 2:
			%TxtID = %Player.GetMissionFlag(%Mid,4000);

			if (%TxtID < 1)
				%TxtID = 10002;

			%T10002 = eval("Mission" @ %Mid @ "Dialog" @ "(%Npc, %Player, %Mid, %TxtID);");	//"��������";
			%Txt = $Icon[99] @ "<b/>" @ %T10002 @ "<b/>";

		case 3:
			%Txt = $Icon[95] @ GetMission_NanDu(%Mid);	//"�����Ѷ�";

		case 4://�����Ƴ�

		case 5:
			%T10005 = eval("Mission" @ %Mid @ "Dialog" @ "(%Npc, %Player, %Mid, 10005);");	//"������ɶԻ�";
			%Txt = $Icon[96] @ "<b/>" @ %T10005;
	}

	if (%Txt !$= "")
		return  $Get_Dialog_GeShi[31401]  @ %Txt @ "</t>";

	return "Get_Mis_Dialog == ���� Tid��"@%Tid@"��";
}


//����������������������������Ի�����ϡ�������������������������������������
function Get_Item_Dialog(%Npc,%Player,%DialogID,%Param)
{
	if (%DialogID > 0)
	{
		switch$(%DialogID)
		{
		case "105089001":
		case "108020208":
			return "<t>SendMuBan( %Player )���Ի�ģ�塢����ģ������������</t>";
		default:
			//����������϶Ի�
			if ((GetItemData(%DialogID,2) == 5) && (GetItemData(%DialogID,3) == 518))
			{
				//���֮ǰ����Ʒ��ʾ
				%Player.ClearMissionItem(10057);
				%Player.ClearMissionItem(10058);
				%Player.ClearMissionItem(10059);

				%Item_Num_All = $Item_Bao[%DialogID];

				%NumAll = GetWord(%Item_Num_All,0);//����ڵ�������
				%Type   = GetWord(%Item_Num_All,1);//�������
				%TeShu = GetWord(%Item_Num_All,2);//�󶨱�ʶ�Լ����⴦��

				//echo( "%Item_Num_All=====" @ %Item_Num_All );
				//echo( "%NumAll====="  @ %NumAll );
				//echo( "%Type=====" @  %Type );
				//echo( "%TeShu====="  @ %TeShu );
				switch (%Type)
				{
					case 1:
						for (%i = 0; %i < %NumAll; %i++)
						{
							//echo( "$Item_Bao[ " @ %DialogID @ "," @  %i + 1 @ "]=="  @ $Item_Bao[ %DialogID, %i + 1 ] );
							%Item = GetWord($Item_Bao[%DialogID,%i + 1],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 1],1);
							//echo( "%Item====="  @ %Item  @ "   %Num====" @ %Num );
							%Player.AddItemToMission(10057,1,%Item,%Num);
						}
						%Txt1 = "<t>�򿪴�������㽫���������Ʒ��</t><b/>" @ GetFixedMissionItemText(10057);
						//echo( "%Txt1 ===" @ %Txt1 );
					case 2:
						for (%i = 0; %i < %NumAll; %i++)
						{
							//echo( "$Item_Bao[ " @ %DialogID @ "," @  %i + 1 @ "]=="  @ $Item_Bao[ %DialogID, %i + 1 ] );
							%Item = GetWord($Item_Bao[%DialogID,%i + 1],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 1],1);
							//echo( "%Item====="  @ %Item  @ "   %Num====" @ %Num );
							%Player.AddItemToMission(10057,0,%Item,%Num);
						}
						%Txt1 = "<t>�򿪴�������㽫��������Ʒ������ѡ�л��ĳ����Ʒ��</t><b/>" @ GetOptionalMissionItemText(10057);
					case 3:
						for (%i = 0; %i < %NumAll; %i++)
						{
							//echo( "$Item_Bao[ " @ %DialogID @ "," @  %i + 1 @ "]=="  @ $Item_Bao[ %DialogID, %i + 1 ] );
							%Item = GetWord($Item_Bao[%DialogID,%i + 1],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 1],1);
							//%Ran  = GetWord( $Item_Bao[ %DialogID, %i + 1 ], 2 );
							//echo( "%Item====="  @ %Item  @ "   %Num====" @ %Num );
							if (%Item > 0)
								%Player.AddItemToMission(10057,1,%Item,%Num);
						}
						%Txt1 = "<t>�򿪴�������㽫��������Ʒ�������ȡһ����</t><b/>" @ GetFixedMissionItemText(10057);
					case 4:
						for (%i = 0; %i < %NumAll; %i++)
						{
							%Item = GetWord($Item_Bao[%DialogID,%i + 1],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 1],1);
							if (%Item > 0)
							{
								%record1 = 1;
								%Player.AddItemToMission(10057,1,%Item,%Num);
							}
							%Item = GetWord($Item_Bao[%DialogID,%i + 101],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 101],1);
							if (%Item > 0)
							{
								%record2 = 1;
								%Player.AddItemToMission(10058,1,%Item,%Num);
							}
						}
						if (%record1 == 1 && %record2 == 1)
							%Txt1 = "<t>�򿪴�������㽫���������Ʒ��</t><b/>" @ GetFixedMissionItemText(10057)  @ "<b/><b/><t>ͬʱ,��һ�����ʻ��������Ʒ��</t><b/>" @ GetFixedMissionItemText(10058);
						else if (%record1 == 1 && %record2 == 0)
							%Txt1 = "<t>�򿪴�������㽫���������Ʒ��</t><b/>" @ GetFixedMissionItemText(10057);
						else if (%record1 == 0 && %record2 == 1)
							%Txt1 = "<t>�򿪴��������һ�����ʻ��������Ʒ��</t><b/>" @ GetFixedMissionItemText(10058);
					case 5:
						for (%i = 0; %i < %NumAll; %i++)
						{
							%Item = GetWord($Item_Bao[%DialogID,%i + 1],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 1],1);
							if (%Item > 0)
							{
								%record1 = 1;
								%Player.AddItemToMission(10057,1,%Item,%Num);
							}
							%Item = GetWord($Item_Bao[%DialogID,%i + 101],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 101],1);
							if (%Item > 0)
							{
								%record2 = 1;
								%Player.AddItemToMission(10058,1,%Item,%Num);
							}
						}
						if (%record1 == 1 && %record2 == 1)
							%Txt1 = "<t>�򿪴�������㽫���������Ʒ��</t><b/>" @ GetFixedMissionItemText(10057)  @ "<b/><b/><t>ͬʱ,��һ�����ʻ��������Ʒ��</t><b/>" @ GetFixedMissionItemText(10058);
						else if (%record1 == 1 && %record2 == 0)
							%Txt1 = "<t>�򿪴�������㽫���������Ʒ��</t><b/>" @ GetFixedMissionItemText(10057);
						else if (%record1 == 0 && %record2 == 1)
							%Txt1 = "<t>�򿪴��������һ�����ʻ��������Ʒ��</t><b/>" @ GetFixedMissionItemText(10058);
					case 6:
						for (%i = 0; %i < %NumAll; %i++)
						{
							%Item = GetWord($Item_Bao[%DialogID,%i + 1],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 1],1);
							%LvSpc = GetWord($Item_Bao[%DialogID,%i + 1],3);
							//echo( "%LvSpc=============" @ %LvSpc );
							if (%LvSpc $= "LvSp1")
								%Item = GetNewItemIDForLevel(%Player,%Item);
							if (%Item > 0)
							{
								%record1 = 1;
								%Player.AddItemToMission(10057,1,%Item,%Num);
							}
							%Item = GetWord($Item_Bao[%DialogID,%i + 101],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 101],1);
							%LvSpc = GetWord($Item_Bao[%DialogID,%i + 101],3);
							if (%LvSpc $= "LvSp1")
								%Item = GetNewItemIDForLevel(%Player,%Item);
							if (%Item > 0)
							{
								%record2 = 1;
								%Player.AddItemToMission(10058,1,%Item,%Num);
							}

							%Item = GetWord($Item_Bao[%DialogID,%i + 1001],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 1001],1);
							%LvSpc = GetWord($Item_Bao[%DialogID,%i + 1001],3);
							if (%LvSpc $= "LvSp1")
								%Item = GetNewItemIDForLevel(%Player,%Item);
							if (%Item > 0)
							{
								%record3 = 1;
								%Player.AddItemToMission(10059,1,%Item,%Num);
							}
						}
						%Txt1 = "<t>�򿪴������</t>";
						%Txt2 = "";
						%Txt3 = "";
						%Txt4 = "";
						if (%record1 == 1)
							%Txt2 = "<t>�㽫���������Ʒ��</t><b/>" @ GetFixedMissionItemText(10057) @ "<b/>";
						if (%record2 == 1)
							%Txt3 = "<t>��������������һ����Ʒ��</t><b/>" @ GetFixedMissionItemText(10058) @ "<b/>";
						if (%record3 == 1)
							%Txt4 = "<t>��һ�����ʻ��������Ʒ��</t><b/>" @ GetFixedMissionItemText(10059) @ "<b/>";

						%Txt1 = %Txt1 @ %Txt2 @ %Txt3 @ %Txt4;
				}
				//0=��ѡ����	GetOptionalMissionItemText( %missionid )
				//	1=�ظ�����	GetFixedMissionItemText( %missionid )

				return $Get_Dialog_GeShi[31401] @ %Txt1 @ "</t>";
			}
		}
	}

	return "Get_Item_Dialog == ���� Npc��"@%Npc@"��Player��"@%Player@"��DialogID��"@%DialogID@"��Id��"@%Param@"��";
}

//����������������������������Ի�����ϡ�������������������������������������
function Get_Skill_Dialog(%Npc,%Player,%DialogID,%Param)
{
	return "Get_Skill_Dialog == ���� Npc��"@%Npc@"��Player��"@%Player@"��DialogID��"@%DialogID@"��Id��"@%Param@"��";
}

//����������������������״̬��Ի�����ϡ�������������������������������������
function Get_Buff_Dialog(%Npc,%Player,%DialogID,%Param)
{
	return "Get_Buff_Dialog == ���� Npc��"@%Npc@"��Player��"@%Player@"��DialogID��"@%DialogID@"��Id��"@%Param@"��";
}

//����������������������NPC��Ի�����ϡ�������������������������������������
function Get_Npc_Dialog(%Npc,%Player,%DialogID,%Param)
{
	if (%Npc.GetDataID() $= %DialogID)
	{
		if ($NpcRandomDialog[%Npc.GetDataID(),1] !$= "")
		{
			%D = 1;
			if ($NpcRandomDialog[%Npc.GetDataID(),2] !$= ""){ %D = 2; }
			if ($NpcRandomDialog[%Npc.GetDataID(),3] !$= ""){ %D = 3; }

			return "<t>" @ $NpcRandomDialog[%Npc.GetDataID(),GetRandom(1,%D)] @ "</t>";
		}
		else
			return $Get_Dialog_GeShi[31401] @ "��ӭ���������ؾ���������</t><b/><b/>";
	}
	else
		return "Get_Npc_Dialog == ��Ų��� NpcID��"@%Npc.GetDataID()@"��Player��"@%Player@"��DialogID��"@%DialogID@"��Id��"@%Param@"��";

	return "Get_Npc_Dialog == ���� Npc��"@%Npc@"��Player��"@%Player@"��DialogID��"@%DialogID@"��Id��"@%Param@"��";
}

//������������������������������ضԻ�����������������������������������������
function Get_Transport_Dialog(%Npc,%Player,%DialogID,%Param)
{

	%objID = "8" @ GetSubStr(%DialogID,1,8);
	%objName = GetTriggerData(%objID,3);

	%NpcID = %Npc.GetDataid();
	//echo( "==============================" );
	//echo( "%DialogID===" @ %DialogID );
	//echo( "%NpcID ==" @ %NpcID );
	//echo( "%objID ==" @ %objID );
	if ($CalculationNpcTransport[%NpcID,%objID,1] $= "")
	{
		%Number = GetWordCount($Transport_Npc[%NpcID],";");
		//echo( "$Transport_Npc[ %NpcID ]==" @ $Transport_Npc[ %NpcID ] );
		for (%i = 0; %i < %Number; %i++)
		{
			%MsgList =  GetWord($Transport_Npc[%NpcID],%i,";");
			%WanttoMapID = GetWord(%MsgList,0);
			%NeedMoney = GetWord(%MsgList,1);
			%LevelMin = GetWord(%MsgList,2);
			%LevelMax = GetWord(%MsgList,3);

			if (strlen(%WanttoMapID) == 4)
				%WanttoMapID = "8" @ %WanttoMapID @ "0100";
			else if (strlen(%WanttoMapID) == 9)
				%WanttoMapID = "8" @ GetSubStr(%WanttoMapID,1,8);

			if (%WanttoMapID $= %objID)
			{
				$CalculationNpcTransport[%NpcID,%objID,1] = %NeedMoney;
				$CalculationNpcTransport[%NpcID,%objID,2] = %LevelMin;
				$CalculationNpcTransport[%NpcID,%objID,3] = %LevelMax;
				break;
			}
		}
	}
	//echo("1====" @ $CalculationNpcTransport[ %NpcID, %objID, 1 ] );
	//echo("2====" @ $CalculationNpcTransport[ %NpcID, %objID, 2 ] );
	//echo("3====" @ $CalculationNpcTransport[ %NpcID, %objID, 3 ] );
	%Level = %Player.GetLevel();
	if (%Level < $CalculationNpcTransport[%NpcID,%objID,2])
		%Text = $Icon[10] @ $Get_Dialog_GeShi[31407] @ "<t>���� - ��</t>" @ %objName @ "<t>��</t></t>";
	else if (%Level > $CalculationNpcTransport[%NpcID,%objID,3])
		%Text = $Icon[10] @ $Get_Dialog_GeShi[31407] @ "<t>���� - ��</t>" @ %objName @ "<t>��</t></t>";
	else if (%Player.getmoney(2) < $CalculationNpcTransport[%NpcID,%objID,1])
		%Text = $Icon[10] @ $Get_Dialog_GeShi[31407] @ "<t>���� - ��</t>" @ %objName @ "<t>��</t></t>";
	else
	{
		%showmoney = ChangeMoneyText($CalculationNpcTransport[%NpcID,%objID,1]);
		if (%showmoney $= "")
			%Text = $Icon[10] @ $Get_Dialog_GeShi[31401] @ "<t>���� - ��</t>" @ %objName @ "<t>��</t>";
		else
			%Text = $Icon[10] @ $Get_Dialog_GeShi[31401] @ "<t>���� - ��</t>" @ %objName @ "<t>��[</t>" @ %showmoney @ "<t>]</t></t>";
	}
	//echo( "%Text===" @ %Text );
	return %Text;
}
//������������������������������ضԻ�����������������������������������������
function Get_Area_Dialog(%Npc,%Player,%DialogID,%Param)
{
	return "Get_Area_Dialog == ���� Npc��"@%Npc@"��Player��"@%Player@"��DialogID��"@%DialogID@"��Id��"@%Param@"��";
}

//������������������������������ضԻ�����������������������������������������
function Get_Fly_Dialog(%Npc,%Player,%DialogID,%Param)
{
	%FlyID = GetSubStr(%DialogID,1,8);

	switch$(%FlyID)
	{
		case "10010101":
	}

	return "Get_Fly_Dialog == ���� Npc��"@%Npc@"��Player��"@%Player@"��DialogID��"@%DialogID@"��Id��"@%Param@"��";
}

//��ȡͨ����Ի�
function Get_Shop_Dialog(%Npc,%Player,%DialogID,%Param)
{
	%DialogLog = strlen(%DialogID);

	//��DialogID�ĳ��������֣�С��2λ�Ķ�����ʾ
	if (%DialogLog < 3)
	{
		switch (%DialogID)
		{
			case 0: return $Get_Dialog_GeShi[31401] @ "��ӭ���������ؾ������磡</t><b/><b/>";
			case 1:	return $Icon[4] @ $Get_Dialog_GeShi[31493] @ "�����Ի�</t>";
			case 2:	return "<t>��������</t>";
			case 3:	return $Icon[1] @ $Get_Dialog_GeShi[31493] @ "�������</t>";
			case 4:	return $Icon[14] @ "<t>����</t>";
			case 5:	return $Icon[5] @ "<t>��</t>";
			case 6:	return "<t>��ı����������Ų����ˣ�������һ�°�</t>";
			case 7:	return "<t>��Ʒ���ݴ���</t>";
			case 8:	return  $Icon[4] @"<t>֪����</t>";
			case 9:	return "<t>�鿴��Ʒ</t>";
			case 10:return $Icon[4] @ $Get_Dialog_GeShi[31493] @ "�ر�</t>";
			case 11:return $Icon[4] @ "<t>�뿪����</t>";
			case 12:return "<t>���ʦ�ųͷ�</t>";
			case 13:return "<t>��������̨</t>";
			case 14:return "<t>���Ҹı�ĳ�������״̬</t>";
			case 15:return "ֱ�ӽ���";
			case 16:return "<t>ֱ�����</t>";
			case 17:return "<t>ǿ�Ʒ���</t>";
			case 18:return "<t>���ó�δ���״̬</t>";
			case 19:return "<t>��ʥ������</t>";
			case 20:return "<t>���»�����</t>";
			case 21:return "<t>��֧�߾��顿</t>";
			case 22:return "<t>��ÿ��ѭ����</t>";
			case 23:return "<t>����������</t>";
			case 24:return "<t>��ָ������</t>";
			case 25:return "<t>����������</t>";
			case 26:return "<t>Ŀǰ���޴�������</t>";
			case 27:return "<t>����Դ������ʲô��</t>";
			case 28:return "<t>���ø����ף��</t>";
			case 29:return "<t>����ţ�ưɣ�</t>";
			case 30:return "<t>�����ɣ�С���棡���ı����ʥ��ֵ��</t>";
			case 31:return "<t>����Ŷ����û���㹻�Ļ��ҡ���</t>";
			case 32:return "<t>��δ���ţ������ڴ���</t>";
			case 33:return $Icon[5] @ "<t>�������</t>";
			case 34:return "<t>��������������������㣬�޷������׶�</t>";
			case 35:return $Icon[6] @ "<t>����ָ��</t>";
			case 36:return $Icon[5] @ "<t>����������</t>";
			case 37:return $Icon[5] @ "<t>����������</t>";
			case 38:return $Icon[5] @ "<t>�������</t>";
			case 39:return $Icon[5] @ "<t>��һ������</t>";
			case 40:return $Icon[5] @ "<t>��������ȼ�</t>";
			case 41:return $Icon[5] @ "<t>���ӻ�����</t>";
			case 42:return "<t>��10001��ʥ</t>";
			case 43:return "<t>��10002����</t>";
			case 44:return "<t>��10003����</t>";
			case 45:return "<t>��10004����</t>";
			case 46:return "<t>��10005����</t>";
			case 47:return "<t>��10006����</t>";
			case 48:return "<t>��10007����</t>";
			case 49:return "<t>��10008��ħ</t>";
			case 50:return "<t>��10011��ʥ</t>";
			case 51:return "<t>��10012����</t>";
			case 52:return "<t>��10013����</t>";
			case 53:return "<t>��10014����</t>";
			case 54:return "<t>��10015����</t>";
			case 55:return "<t>��10016����</t>";
			case 56:return "<t>��10017����</t>";
			case 57:return "<t>��10018��ħ</t>";

		}
		switch (%DialogID)
		{
			case 58:return $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�ٻ�����˧����</t>";
			case 59:return $Icon[5] @ $Get_Dialog_GeShi[31407] @ "<t>�ٻ��������</t>";
			case 60:return "<t>����Ŷ���㲻�Ƕӳ����޷�ʹ�á���</t>";
			case 61:return "<t>����Ŷ����Ķ�Աû��ȫ�����ϡ���</t>";
			case 62:return "<t>������Ѿ�ʹ�ù��˹��ܣ������������ɡ���</t>";
			case 63:return "<t>ʦͽ���</t>";
			case 64:return "<t>�����ʸ�(ʦ���ȼ�)</t>";
			case 65:return "<t>����ʦ��</t>";
			case 66:return "<t>������Ѿ��μӹ��˻�ˣ������������ɡ���</t>";
			case 67:return $Icon[5] @ $Get_Dialog_GeShi[31491] @ "����ѡ�����ָ�ʽ</t>";
			case 68:return $Icon[5] @ $Get_Dialog_GeShi[31492] @ "����ѡ�����ָ�ʽ</t>";
			case 69:return $Icon[5] @ $Get_Dialog_GeShi[31493] @ "����ѡ�����ָ�ʽ</t>";
			case 70:return $Icon[5] @ $Get_Dialog_GeShi[31494] @ "����ѡ�����ָ�ʽ</t>";
			case 71:return $Icon[5] @ $Get_Dialog_GeShi[31495] @ "����ѡ�����ָ�ʽ</t>";
			case 72:return "<t>������ǰ���޾���</t>";
			case 73:return "<t>������������</t>";
			case 74:return "<t>׼������������ǰ����壡</t>";
			case 75:return $Icon[10] @ $Get_Dialog_GeShi[31493] @ "��׼������</t>";
			case 76:return "<t>�����ȫʱ��</t>";
			case 77:return "<t>�ı������Ը�</t>";
			case 78:return "<t>��Ӻøж�(9999��)</t>";
			case 79:return "<t>��.�������</t>";
			case 80:return "<t>������û��</t>";
			case 81:return "<t>�������״̬</t>";
			case 82:return "<t>����ƶ�ֵ</t>";
			case 83:return "<t>������޾���</t>";
			case 84:return "<t>һ�����״��</t>";
			case 85:return "<t>���Ҫ��׽��׵�װ�����ڰ�����һ�е�һ�У�����ע�������������ᴵһ�������ٵ�ѡ��...</t>";
			case 86:return "<t>���Ѿ����벻����״̬���޷��ӽ�����</t>";
			case 87:return "<t>������޾��飨ÿ��100�㣩</t>";
			case 88:return "<t>������޾��飨ÿ��1000�㣩</t>";
			case 89:return "<t>������޾��飨ÿ��10000�㣩</t>";
			case 90:return "<t>һ��ѧϰ���ɼ���</t>";
			case 91:return "<t>��δѡ�����ɣ�����ѡ������</t>";
			case 92:return "<t>ѡ���������Լ���</t>";
			case 93:return "<t>ѧϰ������ϵ����</t>";
			case 94:return "<t>ѧϰ���и�ϵ����</t>";
			case 95:return "<t>����ѡ�����ɣ�����δѧϰ�κ�����ϵ���ܵ������ʹ�ã��������Ը���</t>";
			case 96:return "<t>���η�����</t>";
			case 97:return "<t>��10101��ͨ������</t>";
			case 98:return "<t>�򿪹̶�̯λ����</t>";
			case 99:return "<t>����10000�����</t>";
		}
	}
	else
	{
		//��DialogID�ĳ���������
		switch (%DialogLog)
		{
			case 3:
			case 4:
			case 5:
				switch (%DialogID)
				{
					case 400001: return $Icon[8] @ "<t>���е��߲���</t>";
					case 400002: return $Icon[8] @ "<t>��Ƕ�����̵�</t>";
					case 400003: return $Icon[8] @ "<t>1--80����������</t>";
					case 400004: return $Icon[8] @ "<t>1--80�����߲���</t>";
					case 400005: return $Icon[8] @ "<t>1--80����Ʒ����</t>";
					case 400006: return $Icon[8] @ "<t>���ײ����̵�</t>";
					case 400007: return $Icon[8] @ "<t>���������̵�</t>";
					case 400008: return $Icon[8] @ "<t>ģ�Ͳ����̵�</t>";
					case 400009: return $Icon[8] @ "<t>��������̵�</t>";
					case 400010: return $Icon[8] @ "<t>�����̵�</t>";
					case 400011: return $Icon[8] @ "<t>�������̵�</t>";
					case 400012: return $Icon[8] @ "<t>�̵깦�ܲ���</t>";
					case 400013: return $Icon[8] @ "<t>��Ƶר���̵�</t>";
				}
			case 6:
				if (GetSubStr(%DialogID,0,1) == 4)		   //�����6λ����ID�ĵڶ�λ��1������410005
				{
					switch (%DialogID)
					{
						//-----�����̵�------------
						case 400001: return $Icon[8] @ "<t>���ò����̵�</t>";
						case 400002: return $Icon[8] @ "<t>�����̵�</t>";
							//---------ͨ���̵�-------	
						case 410000: return $Icon[8] @ "<t>�����̵�</t>";
						case 410001: return $Icon[8] @ "<t>�����̵�</t>";
						case 410002: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410003: return $Icon[8] @ "<t>ҩƷ�̵�</t>";
						case 410004: return $Icon[8] @ "<t>�����̵�</t>";
						case 410005: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410006: return $Icon[8] @ "<t>ս���̵�</t>";
						case 410007: return $Icon[8] @ "<t>�Ʒ��̵�</t>";
						case 410008: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410009: return $Icon[8] @ "<t>װ���̵�</t>";
						case 410010: return $Icon[8] @ "<t>�÷��̵�</t>";
						case 410011: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410012: return $Icon[8] @ "<t>��Ʒ�̵�</t>";
						case 410013: return $Icon[8] @ "<t>�����̵�</t>";
						case 410014: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410015: return $Icon[8] @ "<t>ʳ���̵�</t>";
						case 410016: return $Icon[8] @ "<t>����̵�</t>";
						case 410017: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410018: return $Icon[8] @ "<t>�ӻ���</t>";
						case 410019: return $Icon[8] @ "<t>���عű��̵�</t>";

						case 410021: return $Icon[7] @ "<t>�龧�̵�</t>";
						case 410022: return $Icon[7] @ "<t>�龧�̵�</t>";
						case 410023: return $Icon[7] @ "<t>�龧�̵�</t>";
						case 410024: return $Icon[7] @ "<t>�龧�̵�</t>";
						case 410031: return $Icon[7] @ "<t>��ʯ�̵�</t>";
						case 410032: return $Icon[7] @ "<t>��ʯ�̵�</t>";
						case 410033: return $Icon[7] @ "<t>��ʯ�̵�</t>";
						case 410034: return $Icon[7] @ "<t>��ʯ�̵�</t>";

						case 410100: return $Icon[8] @ "<t>�����̵�</t>";
						case 410101: return $Icon[8] @ "<t>�����̵�</t>";
						case 410102: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410103: return $Icon[8] @ "<t>ҩƷ�̵�</t>";
						case 410104: return $Icon[8] @ "<t>�����̵�</t>";
						case 410105: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410106: return $Icon[8] @ "<t>ս���̵�</t>";
						case 410107: return $Icon[8] @ "<t>�Ʒ��̵�</t>";
						case 410108: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410109: return $Icon[8] @ "<t>װ���̵�</t>";
						case 410110: return $Icon[8] @ "<t>�÷��̵�</t>";
						case 410111: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410112: return $Icon[8] @ "<t>��Ʒ�̵�</t>";
						case 410113: return $Icon[8] @ "<t>�����̵�</t>";
						case 410114: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410115: return $Icon[8] @ "<t>ʳ���̵�</t>";
						case 410116: return $Icon[8] @ "<t>����̵�</t>";
						case 410117: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410118: return $Icon[8] @ "<t>�ӻ���</t>";
						case 410119: return $Icon[8] @ "<t>�����̵�</t>";
						case 410120: return $Icon[8] @ "<t>����̵�</t>";

						case 410200: return $Icon[8] @ "<t>�����̵�</t>";
						case 410201: return $Icon[8] @ "<t>�����̵�</t>";
						case 410202: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410203: return $Icon[8] @ "<t>ҩƷ�̵�</t>";
						case 410204: return $Icon[8] @ "<t>�����̵�</t>";
						case 410205: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410206: return $Icon[8] @ "<t>ս���̵�</t>";
						case 410207: return $Icon[8] @ "<t>�Ʒ��̵�</t>";
						case 410208: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410209: return $Icon[8] @ "<t>װ���̵�</t>";
						case 410210: return $Icon[8] @ "<t>�÷��̵�</t>";
						case 410211: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410212: return $Icon[8] @ "<t>��Ʒ�̵�</t>";
						case 410213: return $Icon[8] @ "<t>�����̵�</t>";
						case 410214: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410215: return $Icon[8] @ "<t>ʳ���̵�</t>";
						case 410216: return $Icon[8] @ "<t>����̵�</t>";
						case 410217: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410218: return $Icon[8] @ "<t>�ӻ���</t>";

						case 410300: return $Icon[8] @ "<t>�����̵�</t>";
						case 410301: return $Icon[8] @ "<t>�����̵�</t>";
						case 410302: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410303: return $Icon[8] @ "<t>ҩƷ�̵�</t>";
						case 410304: return $Icon[8] @ "<t>�����̵�</t>";
						case 410305: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410306: return $Icon[8] @ "<t>ս���̵�</t>";
						case 410307: return $Icon[8] @ "<t>�Ʒ��̵�</t>";
						case 410308: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410309: return $Icon[8] @ "<t>װ���̵�</t>";
						case 410310: return $Icon[8] @ "<t>�÷��̵�</t>";
						case 410311: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410312: return $Icon[8] @ "<t>��Ʒ�̵�</t>";
						case 410313: return $Icon[8] @ "<t>�����̵�</t>";
						case 410314: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410315: return $Icon[8] @ "<t>ʳ���̵�</t>";
						case 410316: return $Icon[8] @ "<t>����̵�</t>";
						case 410317: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410318: return $Icon[8] @ "<t>�ӻ���</t>";

						case 410400: return $Icon[8] @ "<t>�����̵�</t>";
						case 410401: return $Icon[8] @ "<t>�����̵�</t>";
						case 410402: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410403: return $Icon[8] @ "<t>ҩƷ�̵�</t>";
						case 410404: return $Icon[8] @ "<t>�����̵�</t>";
						case 410405: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410406: return $Icon[8] @ "<t>ս���̵�</t>";
						case 410407: return $Icon[8] @ "<t>�Ʒ��̵�</t>";
						case 410408: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410409: return $Icon[8] @ "<t>װ���̵�</t>";
						case 410410: return $Icon[8] @ "<t>�÷��̵�</t>";
						case 410411: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410412: return $Icon[8] @ "<t>��Ʒ�̵�</t>";
						case 410413: return $Icon[8] @ "<t>�����̵�</t>";
						case 410414: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410415: return $Icon[8] @ "<t>ʳ���̵�</t>";
						case 410416: return $Icon[8] @ "<t>����̵�</t>";
						case 410417: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410418: return $Icon[8] @ "<t>�ӻ���</t>";

						case 410500: return $Icon[8] @ "<t>�����̵�</t>";
						case 410501: return $Icon[8] @ "<t>�����̵�</t>";
						case 410502: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410503: return $Icon[8] @ "<t>ҩƷ�̵�</t>";
						case 410504: return $Icon[8] @ "<t>�����̵�</t>";
						case 410505: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410506: return $Icon[8] @ "<t>ս���̵�</t>";
						case 410507: return $Icon[8] @ "<t>�Ʒ��̵�</t>";
						case 410508: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410509: return $Icon[8] @ "<t>װ���̵�</t>";
						case 410510: return $Icon[8] @ "<t>�÷��̵�</t>";
						case 410511: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410512: return $Icon[8] @ "<t>��Ʒ�̵�</t>";
						case 410513: return $Icon[8] @ "<t>�����̵�</t>";
						case 410514: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410515: return $Icon[8] @ "<t>ʳ���̵�</t>";
						case 410516: return $Icon[8] @ "<t>����̵�</t>";
						case 410517: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410518: return $Icon[8] @ "<t>�ӻ���</t>";

						case 410600: return $Icon[8] @ "<t>�����̵�</t>";
						case 410601: return $Icon[8] @ "<t>�����̵�</t>";
						case 410602: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410603: return $Icon[8] @ "<t>ҩƷ�̵�</t>";
						case 410604: return $Icon[8] @ "<t>�����̵�</t>";
						case 410605: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410606: return $Icon[8] @ "<t>ս���̵�</t>";
						case 410607: return $Icon[8] @ "<t>�Ʒ��̵�</t>";
						case 410608: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410609: return $Icon[8] @ "<t>װ���̵�</t>";
						case 410610: return $Icon[8] @ "<t>�÷��̵�</t>";
						case 410611: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410612: return $Icon[8] @ "<t>��Ʒ�̵�</t>";
						case 410613: return $Icon[8] @ "<t>�����̵�</t>";
						case 410614: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410615: return $Icon[8] @ "<t>ʳ���̵�</t>";
						case 410616: return $Icon[8] @ "<t>����̵�</t>";
						case 410617: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410618: return $Icon[8] @ "<t>�ӻ���</t>";

						case 410700: return $Icon[8] @ "<t>�����̵�</t>";
						case 410701: return $Icon[8] @ "<t>�����̵�</t>";
						case 410702: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410703: return $Icon[8] @ "<t>ҩƷ�̵�</t>";
						case 410704: return $Icon[8] @ "<t>�����̵�</t>";
						case 410705: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410706: return $Icon[8] @ "<t>ս���̵�</t>";
						case 410707: return $Icon[8] @ "<t>�Ʒ��̵�</t>";
						case 410708: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410709: return $Icon[8] @ "<t>װ���̵�</t>";
						case 410710: return $Icon[8] @ "<t>�÷��̵�</t>";
						case 410711: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410712: return $Icon[8] @ "<t>��Ʒ�̵�</t>";
						case 410713: return $Icon[8] @ "<t>�����̵�</t>";
						case 410714: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410715: return $Icon[8] @ "<t>ʳ���̵�</t>";
						case 410716: return $Icon[8] @ "<t>����̵�</t>";
						case 410717: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410718: return $Icon[8] @ "<t>�ӻ���</t>";

						case 410800: return $Icon[8] @ "<t>�����̵�</t>";
						case 410801: return $Icon[8] @ "<t>�����̵�</t>";
						case 410802: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410803: return $Icon[8] @ "<t>ҩƷ�̵�</t>";
						case 410804: return $Icon[8] @ "<t>�����̵�</t>";
						case 410805: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410806: return $Icon[8] @ "<t>ս���̵�</t>";
						case 410807: return $Icon[8] @ "<t>�Ʒ��̵�</t>";
						case 410808: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410809: return $Icon[8] @ "<t>װ���̵�</t>";
						case 410810: return $Icon[8] @ "<t>�÷��̵�</t>";
						case 410811: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410812: return $Icon[8] @ "<t>��Ʒ�̵�</t>";
						case 410813: return $Icon[8] @ "<t>�����̵�</t>";
						case 410814: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410815: return $Icon[8] @ "<t>ʳ���̵�</t>";
						case 410816: return $Icon[8] @ "<t>����̵�</t>";
						case 410817: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 410818: return $Icon[8] @ "<t>�ӻ���</t>";

							//--------��ħ�� �̵�  ��ͨ���̵��� + 10000------
						case 420000: return $Icon[8] @ "<t>�����̵�</t>";
						case 420001: return $Icon[8] @ "<t>�����̵�</t>";
						case 420002: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 420003: return $Icon[8] @ "<t>ҩƷ�̵�</t>";
						case 420004: return $Icon[8] @ "<t>�����̵�</t>";
						case 420005: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 420006: return $Icon[8] @ "<t>�����̵�</t>";
						case 420007: return $Icon[8] @ "<t>װ���̵�</t>";
						case 420008: return $Icon[8] @ "<t>�÷��̵�</t>";
						case 420009: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 420010: return $Icon[8] @ "<t>��Ʒ�̵�</t>";
						case 420011: return $Icon[8] @ "<t>�����̵�</t>";
						case 420012: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 420013: return $Icon[8] @ "<t>ʳ���̵�</t>";
						case 420014: return $Icon[8] @ "<t>����̵�</t>";
						case 420015: return $Icon[8] @ "<t>�䷽�̵�</t>";
						case 420016: return $Icon[8] @ "<t>�ӻ���</t>";
							//----�����̵�----------------------
						case 430000: return $Icon[8] @ "<t>ʦ���̵�</t>";
						case 430001: return $Icon[8] @ "<t>�����̵�</t>";
						case 430002: return $Icon[8] @ "<t>����̵�</t>";
						case 430003: return $Icon[8] @ "<t>����̵�</t>";

						case 410035: if (GetPrestige(%Player, 1, 1) >= 50000)return $Icon[8] @ "<t>ս�������̵�(һ)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "ս�������̵�(һ)[����50000��]</t>";
						case 410036: if (GetPrestige(%Player, 1, 1) >= 580000)return $Icon[8] @ "<t>ս�������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "ս�������̵�(��)[����580000��]</t>";
						case 410037: if (GetPrestige(%Player, 1, 1) >= 2000000)return $Icon[8] @ "<t>ս�������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "ս�������̵�(��)[����2000000��]</t>";
						case 410038: if (GetPrestige(%Player, 1, 1) >= 6000000)return $Icon[8] @ "<t>ս�������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "ս�������̵�(��)[����6000000��]</t>";
						case 410039: if (GetPrestige(%Player, 1, 1) >= 15000000)return $Icon[8] @ "<t>ս�������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "ս�������̵�(��)[����15000000��]</t>";

						case 410040: if (GetPrestige(%Player, 1, 4) >= 50000)return $Icon[8] @ "<t>�̡������̵�(һ)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "�̡������̵�(һ)[����50000��]</t>";
						case 410041: if (GetPrestige(%Player, 1, 4) >= 580000)return $Icon[8] @ "<t>�̡������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "�̡������̵�(��)[����580000��]</t>";
						case 410042: if (GetPrestige(%Player, 1, 4) >= 2000000)return $Icon[8] @ "<t>�̡������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "�̡������̵�(��)[����2000000��]</t>";
						case 410043: if (GetPrestige(%Player, 1, 4) >= 6000000)return $Icon[8] @ "<t>�̡������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "�̡������̵�(��)[����6000000��]</t>";
						case 410044: if (GetPrestige(%Player, 1, 4) >= 15000000)return $Icon[8] @ "<t>�̡������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "�̡������̵�(��)[����15000000��]</t>";

						case 410045: if (GetPrestige(%Player, 1, 2) >= 50000)return $Icon[8] @ "<t>���������̵�(һ)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���������̵�(һ)[����50000��]</t>";
						case 410046: if (GetPrestige(%Player, 1, 2) >= 580000)return $Icon[8] @ "<t>���������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���������̵�(��)[����580000��]</t>";
						case 410047: if (GetPrestige(%Player, 1, 2) >= 2000000)return $Icon[8] @ "<t>���������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���������̵�(��)[����2000000��]</t>";
						case 410048: if (GetPrestige(%Player, 1, 2) >= 6000000)return $Icon[8] @ "<t>���������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���������̵�(��)[����6000000��]</t>";
						case 410049: if (GetPrestige(%Player, 1, 2) >= 15000000)return $Icon[8] @ "<t>���������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���������̵�(��)[����15000000��]</t>";

						case 410050: if (GetPrestige(%Player, 1, 3) >= 50000)return $Icon[8] @ "<t>���������̵�(һ)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���������̵�(һ)[����50000��]</t>";
						case 410051: if (GetPrestige(%Player, 1, 3) >= 580000)return $Icon[8] @ "<t>���������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���������̵�(��)[����580000��]</t>";
						case 410052: if (GetPrestige(%Player, 1, 3) >= 2000000)return $Icon[8] @ "<t>���������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���������̵�(��)[����2000000��]</t>";
						case 410053: if (GetPrestige(%Player, 1, 3) >= 6000000)return $Icon[8] @ "<t>���������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���������̵�(��)[����6000000��]</t>";
						case 410054: if (GetPrestige(%Player, 1, 3) >= 15000000)return $Icon[8] @ "<t>���������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���������̵�(��)[����15000000��]</t>";

						case 410055: if (GetPrestige(%Player, 1, 5) >= 50000)return $Icon[8] @ "<t>���������̵�(һ)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���������̵�(һ)[����50000��]</t>";
						case 410056: if (GetPrestige(%Player, 1, 5) >= 580000)return $Icon[8] @ "<t>���������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���������̵�(��)[����580000��]</t>";
						case 410057: if (GetPrestige(%Player, 1, 5) >= 2000000)return $Icon[8] @ "<t>���������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���������̵�(��)[����2000000��]</t>";
						case 410058: if (GetPrestige(%Player, 1, 5) >= 6000000)return $Icon[8] @ "<t>���������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���������̵�(��)[����6000000��]</t>";
						case 410059: if (GetPrestige(%Player, 1, 5) >= 15000000)return $Icon[8] @ "<t>���������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���������̵�(��)[����15000000��]</t>";

						case 410220: if (GetPrestige(%Player, 2, 1) >= 50000)return $Icon[8] @ "<t>�����������̵�(һ)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "�����������̵�(һ)[����50000��]</t>";
						case 410221: if (GetPrestige(%Player, 2, 1) >= 580000)return $Icon[8] @ "<t>�����������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "�����������̵�(��)[����580000��]</t>";
						case 410222: if (GetPrestige(%Player, 2, 1) >= 2000000)return $Icon[8] @ "<t>�����������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "�����������̵�(��)[����2000000��]</t>";
						case 410223: if (GetPrestige(%Player, 2, 1) >= 6000000)return $Icon[8] @ "<t>�����������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "�����������̵�(��)[����6000000��]</t>";
						case 410224: if (GetPrestige(%Player, 2, 1) >= 15000000)return $Icon[8] @ "<t>�����������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "�����������̵�(��)[����15000000��]</t>";

						case 410320: if (GetPrestige(%Player, 2, 2) >= 50000)return $Icon[8] @ "<t>�׻�կ�����̵�(һ)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "�׻�կ�����̵�(һ)[����50000��]</t>";
						case 410321: if (GetPrestige(%Player, 2, 2) >= 580000)return $Icon[8] @ "<t>�׻�կ�����̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "�׻�կ�����̵�(��)[����580000��]</t>";
						case 410322: if (GetPrestige(%Player, 2, 2) >= 2000000)return $Icon[8] @ "<t>�׻�կ�����̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "�׻�կ�����̵�(��)[����2000000��]</t>";
						case 410323: if (GetPrestige(%Player, 2, 2) >= 6000000)return $Icon[8] @ "<t>�׻�կ�����̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "�׻�կ�����̵�(��)[����6000000��]</t>";
						case 410324: if (GetPrestige(%Player, 2, 2) >= 15000000)return $Icon[8] @ "<t>�׻�կ�����̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "�׻�կ�����̵�(��)[����15000000��]</t>";

						case 410420: if (GetPrestige(%Player, 2, 3) >= 50000)return $Icon[8] @ "<t>���ƶ������̵�(һ)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���ƶ������̵�(һ)[����50000��]</t>";
						case 410421: if (GetPrestige(%Player, 2, 3) >= 580000)return $Icon[8] @ "<t>���ƶ������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���ƶ������̵�(��)[����580000��]</t>";
						case 410422: if (GetPrestige(%Player, 2, 3) >= 2000000)return $Icon[8] @ "<t>���ƶ������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���ƶ������̵�(��)[����2000000��]</t>";
						case 410423: if (GetPrestige(%Player, 2, 3) >= 6000000)return $Icon[8] @ "<t>���ƶ������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���ƶ������̵�(��)[����6000000��]</t>";
						case 410424: if (GetPrestige(%Player, 2, 3) >= 15000000)return $Icon[8] @ "<t>���ƶ������̵�(��)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "���ƶ������̵�(��)[����15000000��]</t>";
					}
				}
				else
				{
					switch (%DialogID)
					{
						case 100000: return $Icon[5] @ "<t>��ȡ�������˫��</t>";
						case 100001: return $Icon[5] @ "<t>�洢˫������ʱ��</t>";
						case 100002: return $Icon[5] @ "<t>ȡ��˫������ʱ��</t>";
						case 100004: return $Icon[5] @ "<t>�洢һСʱ</t>";
						case 100005: return $Icon[5] @ "<t>�洢ȫ��</t>";
						case 100006: return $Icon[5] @ "<t>ȡ��һСʱ</t>";
						case 100007: return $Icon[5] @ "<t>ȡ��ȫ��</t>";
						case 100008:
							%Act_A = GetAct(GetPlayer(),3031,0);
							%Act_B = GetAct(GetPlayer(),3031,1);
							%Time = mfloor(%Act_A * 60 + %Act_B/60);
							//echo( "%Act_A ==" @ %Act_A );
							//echo( "%Act_B ==" @ %Act_B );
							//echo( "%Time ==" @ %Time );
							return
								"<t>������ʿ��</t><b/>" @
								"<t>����ǰ�洢��˫��ʱ�䣺</t>" @ $Get_Dialog_GeShi[31403] @ %Time @ "</t><t> ����</t>";

						case 100009: return $Icon[5] @ "<t>ɾ����ɫ</t>";
						case 100010: return "<t>  Ϊ�˱�����ҵĽ�ɫ��ȫ����ɫ�޷�ֱ��ɾ����������������ѡ������ڵ��ɾ�����ݽ�ɾ����ɫ����</t><b/>" @
							$Get_Dialog_GeShi[31403] @ "  ����������3������봦��ʱ�䣬3������ſ���ʹ��׼��ɾ���Ľ�ɫ��������ȷ��ɾ��������14����Զ�ȡ��ɾ����ɫ����</t><b/>" @
							"<t>  �ڽ�ɫ����ɾ���������ʱ���ڣ�����������ʱȡ��ɾ��������ȷ��ɾ��ʱ���������������������ſ���ɾ����ɫ��</t><b/>" @
							$Get_Dialog_GeShi[31406] @ "  1.���ܴ��ڰ��ɡ���Ե����ݡ�ʦͽ��ϵ��</t><b/>" @
							$Get_Dialog_GeShi[31406] @ "  2.��ӵ�е���Ʒ����費��������״̬</t><b/>";
						case 100011:return $Icon[5] @ "<t>ȡ��ɾ����ɫ</t>";
						case 100012:return "<t>��ȷ��Ҫɾ����ǰ��ɫ��</t>";
						case 100013:return "<t>����ǰ�Ľ�ɫ�Ѿ��ݽ�ɾ������</t>";
						case 100014:return $Icon[10] @ "<t>�������</t>";
						case 100015:return $Icon[10] @ "<t>���롺��ħ�þ���</t>";
						case 100016:return $Icon[5] @ "<t>�һ�ý�����</t>";
						case 100017:return $Icon[6] @ "<t>�˽⡾���������</t>";
						case 100018:return $Icon[6] @ "<t>�˽⡾�ر�ͼ�����</t>";
						case 100019:
							return "<t>�Ϲ�ʱ������ħ�ݺᡣ�Ϲ���������󣬰���ħ��������ӡ��Ȼ����ħ�����˼�֮�Ĳ�����������ʿ����Ϊ����֮����ն����ħ�������������˻�����ħ���л�����</t>" @ "<l i='113090002' t='itemid'/>" @ "<t>��</t>";
						case 100020:
							return "<t>�Ϲ���ħ������ĵر�����󷨱������ڸ�������֮�����Դ��������ع�֮�ա����ϣ�ǰ��������������̣�ת��ʮ�������ţ������ս�ǿʢ����ħ�������ճɿա��������������µ�</t>" @ "<l i='113090002' t='itemid'/>" @
								"<t>ȴ�������䣬�������غ��л����ø��������߽�����</t>";
						case 100021:return $Icon[5] @ "<t>�򿪲ֿ�</t>";
						case 100022:return $Icon[5] @ "<t>�򿪱�ʯ����</t>";
						case 100023:return $Icon[5] @ "<t>��װ����������</t>";
						case 100024:return $Icon[5] @ "<t>��װ��ǿ������</t>";
						case 100025:return $Icon[5] @ "<t>������</t>";
						case 100026:
							%Level = getplayer().getlevel();
							if (%Level < 35)
								%Level = 35;
							return $Icon[19] @ $Get_Dialog_GeShi[31496] @ "ѭ��-[" @ %Level @ "] ���ͼ��ף����ܣ�</t>";
						case 100027:return $Icon[5] @ "<t>������̨</t>";
						case 100028:return $Icon[5] @ "<t>������¯</t>";
						case 100029:return $Icon[5] @ "<t>�򿪷���̨</t>";
						case 100030:return $Icon[5] @ "<t>����⿶�</t>";
						case 100031:return $Icon[5] @ "<t>���Ʒ���</t>";
						case 100032:return $Icon[5] @ "<t>������̨</t>";
						case 100033:
							if (GetPlayer().GetLevel() < 30)
								return	$Icon[5] @ $Get_Dialog_GeShi[31407] @ "�������ɣ���30����</t>";
							else
								return $Icon[5] @ "<t>��������</t>";
						case 100034:return $Icon[5] @ "<t>��ѯ����</t>";
						case 100035:
							if (getplayer().GetOrgMemberLevel(1) < 6)
								return	$Icon[5] @ $Get_Dialog_GeShi[31407] @ "���������������Ȩ�ޣ�</t>";
							else
								return $Icon[5] @ "<t>��������</t>";
						case 100036:
							if (getplayer().GetOrgMemberLevel(1) < 6)
								return	$Icon[5] @ $Get_Dialog_GeShi[31407] @ "������ս�������Ȩ�ޣ�</t>";
							else
								return $Icon[5] @ "<t>������ս</t>";
						case 100037:
							if (getplayer().GetOrgID() > 0)
								return $Icon[5] @ "<t>���ɾ���</t>";
							else
								return	$Icon[5] @ $Get_Dialog_GeShi[31407] @ "���ɾ��ף��������ɣ�</t>";

						case 100038:return $Icon[5] @ "<t>���׽���</t>";
						case 100039:return $Icon[5] @ "<t>���׽�ש</t>";
						case 100040:return $Icon[5] @ "<t>����һ������</t>";
						case 100041:return $Icon[5] @ "<t>���׶�������</t>";
						case 100042:return $Icon[5] @ "<t>������������</t>";
						case 100043:return $Icon[5] @ "<t>�����ļ�����</t>";
						case 100044:return $Icon[5] @ "<t>�����弶����</t>";
						case 100045:return $Icon[5] @ "<t>������������</t>";
						case 100046:return $Icon[5] @ "<t>�����߼�����</t>";
						case 100047:return $Icon[5] @ "<t>���װ˼�����</t>";
						case 100048:return $Icon[5] @ "<t>���׾ż�����</t>";
						case 100049:return $Icon[5] @ "<t>����ʮ������</t>";
								
						case 100050:
							%ItemID[1] = 105105303; 
							%ItemName1 = "<l i='" @ %ItemID[1] @ "' t='itemid'/>";
							return
								"<t>������Ҫ��</t><b/>" @
								"<t>    </t>" @ %ItemName1 @ "<t>* 1</t><b/>" @
								"<t>ÿ����һ�ݿ����ӣ�</t><b/>" @
								"<t>  ���� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%ItemID[1]] @ " </t><t>��</t><b/>";
						case 100051:
							%ItemID[1] = 105105304;
							%ItemName1 = "<l i='" @ %ItemID[1] @ "' t='itemid'/>";
							return
								"<t>������Ҫ��</t><b/>" @
								"<t>    </t>" @ %ItemName1 @ "<t>* 1</t><b/>" @
								"<t>ÿ����һ�ݿ����ӣ�</t><b/>" @
								"<t>  ���� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%ItemID[1]] @ " </t><t>��</t><b/>";
						case 100052:
							%ItemID[1] = 105109401; %ItemID[2] = 105109402; %ItemID[3] = 105109403; %ItemID[4] = 105109404;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName[1] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[2] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[3] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[4] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";
						case 100053:
							%ItemID[1] = 105109411; %ItemID[2] = 105109412; %ItemID[3] = 105109413; %ItemID[4] = 105109414;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName[1] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[2] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[3] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[4] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";
						case 100054:
							%ItemID[1] = 105109421; %ItemID[2] = 105109422; %ItemID[3] = 105109423; %ItemID[4] = 105109424;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName[1] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[2] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[3] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[4] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";
						case 100055:
							%ItemID[1] = 105109431; %ItemID[2] = 105109432; %ItemID[3] = 105109433; %ItemID[4] = 105109434;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName[1] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[2] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[3] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[4] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";
						case 100056:
							%ItemID[1] = 105109441; %ItemID[2] = 105109442; %ItemID[3] = 105109443; %ItemID[4] = 105109444;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName[1] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[2] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[3] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[4] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";
						case 100057:
							%ItemID[1] = 105109451; %ItemID[2] = 105109452; %ItemID[3] = 105109453; %ItemID[4] = 105109454;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName[1] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[2] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[3] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[4] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";
						case 100058:
							%ItemID[1] = 105109461; %ItemID[2] = 105109462; %ItemID[3] = 105109463; %ItemID[4] = 105109464;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName[1] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[2] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[3] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[4] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";
						case 100059:
							%ItemID[1] = 105109471; %ItemID[2] = 105109472; %ItemID[3] = 105109473; %ItemID[4] = 105109474;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName[1] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[2] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[3] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[4] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";
						case 100060:
							%ItemID[1] = 105109481; %ItemID[2] = 105109482; %ItemID[3] = 105109483; %ItemID[4] = 105109484;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName[1] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[2] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[3] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[4] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";
						case 100061:
							%ItemID[1] = 105109491; %ItemID[2] = 105109492; %ItemID[3] = 105109493; %ItemID[4] = 105109494;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName[1] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[2] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[3] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName[4] @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";
						case 100062:return $Icon[5] @ "<t>ȷ������</t>"; //����
						case 100063:return $Icon[5] @ "<t>ȷ������</t>"; //����
						case 100064:return $Icon[5] @ "<t>ȷ������</t>";
						case 100065:return $Icon[5] @ "<t>ȷ������</t>";
						case 100066:return $Icon[5] @ "<t>ȷ������</t>";
						case 100067:return $Icon[5] @ "<t>ȷ������</t>";
						case 100068:return $Icon[5] @ "<t>ȷ������</t>";
						case 100069:return $Icon[5] @ "<t>ȷ������</t>";
						case 100070:return $Icon[5] @ "<t>ȷ������</t>";
						case 100071:return $Icon[5] @ "<t>ȷ������</t>";
						case 100072:return $Icon[5] @ "<t>ȷ������</t>";
						case 100073:return $Icon[5] @ "<t>ȷ������</t>";

						case 100074:
								return "<t>��ͨ�����׽�������ש����������������������</t><b/>" @ %Text;

						case 100075:return $Icon[5] @ "<t>��ʼ����</t>";
						case 100076:return $Icon[5] @ "<t>��ʯ�ϳ�</t>";
						case 100077:return $Icon[5] @ "<t>װ������</t>";
						case 100078:return $Icon[5] @ "<t>Ԫ������</t>";
						case 100079:return $Icon[5] @ "<t>��ȡȤζ���⽱��</t>";
						case 100080:
							%RanKing = %Player.getAnswerRank();//����
							%Sorce = %Player.getAnswerPoint();//��ȡ����
							%Player.ClearMissionItem(10050);

							switch (%RanKing)
							{
								case 1: %ItemID[1] = 105090901; %ItemCount[1]= 6; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 301;
								case 2: %ItemID[1] = 105090901; %ItemCount[1]= 5; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 302;
								case 3: %ItemID[1] = 105090901; %ItemCount[1]= 4; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 303;
								case 4: %ItemID[1] = 105090901; %ItemCount[1]= 3; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
								case 5: %ItemID[1] = 105090901; %ItemCount[1]= 3; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
								case 6: %ItemID[1] = 105090901; %ItemCount[1]= 2; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
								case 7: %ItemID[1] = 105090901; %ItemCount[1]= 2; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
								case 8: %ItemID[1] = 105090901; %ItemCount[1]= 2; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
								case 9: %ItemID[1] = 105090901; %ItemCount[1]= 2; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
								case 10:%ItemID[1] = 105090901; %ItemCount[1]= 2; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
								default:
							}
							//EXP = �ȼ����� * ���� * �ȼ�ϵ�� + �ȼ��β��侭��
							%Level = %Player.Getlevel();
							%OneExp = $Monster_Exp[%Level,1];

							if (%Level < 30) %Coefficient = 0.5;
							else if (%Level < 40) %Coefficient = 1;
							else if (%Level < 50) %Coefficient = 1.2;
							else if (%Level < 60) %Coefficient = 1.6;
							else if (%Level < 70) %Coefficient = 2.0;
							else %Coefficient = 2.2;

							if (%Level < 25) %LevelExp = 0;
							else if (%Level < 40) %LevelExp = 20000;
							else if (%Level < 50) %LevelExp = 30000;
							else if (%Level < 60) %LevelExp = 50000;
							else if (%Level < 70) %LevelExp = 80000;
							else if (%Level < 80) %LevelExp = 100000;
							else if (%Level < 90) %LevelExp = 120000;
							else if (%Level < 100) %LevelExp = 120000;
							else if (%Level < 110) %LevelExp = 120000;
							else if (%Level < 120) %LevelExp = 120000;
							else if (%Level < 130) %LevelExp = 120000;
							else if (%Level < 140) %LevelExp = 120000;
							else if (%Level < 150) %LevelExp = 120000;

							%Exp = %OneExp * %Sorce * %Coefficient + %LevelExp;
							%Exp = mfloor(%Exp);
							if (%Sorce  == 0)
								%Exp = 0;


							if (%RanKing  == 0)
								%Rank = "<t>�ҵ�������20������</t><b/>";
							else
								%Rank = "<t>�ҵ�������" @ %RanKing @ "</t><b/>";
							%Sorce = "<t>�ҵĻ��֣�" @ %Sorce @ "</t><b/>";
							%exp = "<t>�ҵľ��飺" @ %Exp @ "</t><b/>";
							%Item ="";
							for (%i = 1; %i <=9; %i++)
							{
								if (%ItemID[%i] > 0 && %ItemCount[%i] > 0)
								{
									%Item = "<t>���߽�����</t><b/>";
									%Player.AddItemToMission(10050,1,%ItemID[%i],%ItemCount[%i]);
								}
								else
									break;
							}
							%Text = %Rank @ %Sorce @ %exp;
							return $Get_Dialog_GeShi[80002] @ %Text @ %Item @ "</t>" @ GetFixedMissionItemText(10050);
						case 100081:
							return $Icon[5] @ "<t>��ȡ����</t>";
						case 100082:
							return $Icon[5] @ "<t>�����ѧϰ</t>";
						case 100083://������������
							return
								$Get_Dialog_GeShi[80001] @ "1������������Ҫ��</t><b/>" @
								GetItemName(105105303,1) @ "<t>* 10</t><b/>" @
								"<t> ���ɻ�Ծ�ﵽ </t>" @ $Get_Dialog_GeShi[31409] @ "10000 </t><t>��</t><b/>" @
								"<t> ���������ﵽ </t>" @ $Get_Dialog_GeShi[31409] @ "10000 </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80001] @ "2������������Ҫ��</t><b/>" @
								GetItemName(105105304,1) @ "<t>* 10</t><b/>" @
								"<t> ���ɻ�Ծ�ﵽ </t>" @ $Get_Dialog_GeShi[31409] @ "20000 </t><t>��</t><b/>" @
								"<t> ���������ﵽ </t>" @ $Get_Dialog_GeShi[31409] @ "100000 </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80001] @ "3������������Ҫ��</t><b/>" @
								GetItemName(105105304,1) @ "<t>* 50</t><b/>" @
								GetItemName(105105305,1) @ "<t>* 1</t><b/>" @
								"<t> ���ɻ�Ծ�ﵽ </t>" @ $Get_Dialog_GeShi[31409] @ "30000 </t><t>��</t><b/>" @
								"<t> ���������ﵽ </t>" @ $Get_Dialog_GeShi[31409] @ "250000 </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80001] @ "4������������Ҫ��</t><b/>" @
								GetItemName(105105304,1) @ "<t>* 100</t><b/>" @
								GetItemName(105105305,1) @ "<t>* 10</t><b/>" @
								"<t> ���ɻ�Ծ�ﵽ </t>" @ $Get_Dialog_GeShi[31409] @ "40000 </t><t>��</t><b/>" @
								"<t> ���������ﵽ </t>" @ $Get_Dialog_GeShi[31409] @ "1000000 </t><t>��</t>";

						case 100084:
							return $Icon[5] @ "<t>��Ҫ����</t>";
						case 100085:
							return $Icon[5] @ "<t>������ս������</t>";
						case 100086:
							return $Icon[5] @ "<t>�ƺ���ȡ</t>";
						case 100087:return $Icon[5] @ "<t>��������</t>";
						case 100088:
							//echo("%Player.gettarget()==="@ %Player.gettarget());
							switch (%Player.gettarget().getdataid())
							{
								case 410010134:%Text = $Get_Dialog_GeShi[80001] @ "��ǰӵ��ս��������" @ GetPrestige(%Player, 1, 1) * 1 @ " ��</t>";//ս
								case 410010136:%Text = $Get_Dialog_GeShi[80001] @ "��ǰӵ�з���������" @ GetPrestige(%Player, 1, 2) * 1 @ " ��</t>";//��
								case 410010137:%Text = $Get_Dialog_GeShi[80001] @ "��ǰӵ�е���������" @ GetPrestige(%Player, 1, 3) * 1 @ " ��</t>";//��
								case 410010135:%Text = $Get_Dialog_GeShi[80001] @ "��ǰӵ������������" @ GetPrestige(%Player, 1, 4) * 1 @ " ��</t>";//��

								case 411010004:%Text = $Get_Dialog_GeShi[80001] @ "��ǰӵ��������������" @ GetPrestige(%Player, 2, 1) * 1 @ " ��</t>";
								case 411020010:%Text = $Get_Dialog_GeShi[80001] @ "��ǰӵ�а׻�կ������" @ GetPrestige(%Player, 2, 2) * 1 @ " ��</t>";
								case 411030015:%Text = $Get_Dialog_GeShi[80001] @ "��ǰӵ�����ƶ�������" @ GetPrestige(%Player, 2, 3) * 1 @ " ��</t>";
							}
							return
								"<t>�����;�������������֮�����������������������Ȼ�����ͨ�����׽�������ש����������������������</t><b/>" @ %Text;

						case 100089:return $Icon[5] @ "<t>����1��</t>";
						case 100090:return $Icon[5] @ "<t>���׽���</t>";
						case 100091:return $Icon[5] @ "<t>���׽�ש</t>";
						case 100092:
							return
								"<t>������Ҫ��</t><b/>" @
								"<t>    ÿ��1���</t><b/>" @
								"<t>ÿ����һ�ݿ����ӣ�</t><b/>" @
								"<t>  ���� </t>" @ $Get_Dialog_GeShi[31409] @ "300 </t><t>��</t><b/>";
						case 100093:return $Icon[5] @ "<t>ȷ������</t>";

						case 100094:
							%Itemid = 105105303;
							%ItemName1 = "<l i='" @ %Itemid @ "' t='itemid'/>";
							return
								"<t>������Ҫ��</t><b/>" @
								"<t>    </t>" @ %ItemName1 @ "<t>* 1</t><b/>" @
								"<t>ÿ����һ�ݿ����ӣ�</t><b/>" @
								"<t>  ���� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid] @ " </t><t>��</t><b/>";
						case 100095:return $Icon[5] @ "<t>����һ��</t>";
						case 100096:return $Icon[5] @ "<t>��������</t>";

						case 100097:
							%Itemid = 105105304;
							%ItemName1 = "<l i='" @ %Itemid @ "' t='itemid'/>";
							return
								"<t>������Ҫ��</t><b/>" @
								"<t>    </t>" @ %ItemName1 @ "<t>* 1</t><b/>" @
								"<t>ÿ����һ�ݿ����ӣ�</t><b/>" @
								"<t>  ���� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid] @ " </t><t>��</t><b/>";
						case 100098:return $Icon[5] @ "<t>����һ��</t>";
						case 100099:return $Icon[5] @ "<t>��������</t>";

						case 100100:return $Icon[5] @ "<t>����һ������</t>";
						case 100101:return $Icon[5] @ "<t>���׶�������</t>";
						case 100102:return $Icon[5] @ "<t>������������</t>";
						case 100103:return $Icon[5] @ "<t>�����ļ�����</t>";
						case 100104:return $Icon[5] @ "<t>�����弶����</t>";
						case 100105:return $Icon[5] @ "<t>������������</t>";
						case 100106:return $Icon[5] @ "<t>�����߼�����</t>";
						case 100107:return $Icon[5] @ "<t>���װ˼�����</t>";
						case 100108:return $Icon[5] @ "<t>���׾ż�����</t>";
						case 100109:return $Icon[5] @ "<t>����ʮ������</t>";

						case 100110:
							%Itemid1 = 105109401;
							%Itemid2 = 105109402;
							%Itemid3 = 105109403;
							%Itemid4 = 105109404;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName1 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName2 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName3 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName4 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";
						case 100111:
							%Itemid1 = 105109411;
							%Itemid2 = 105109412;
							%Itemid3 = 105109413;
							%Itemid4 = 105109414;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName1 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName2 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName3 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName4 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";
						case 100112:
							%Itemid1 = 105109421;
							%Itemid2 = 105109422;
							%Itemid3 = 105109423;
							%Itemid4 = 105109424;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName1 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName2 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName3 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName4 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";
						case 100113:
							%Itemid1 = 105109431;
							%Itemid2 = 105109432;
							%Itemid3 = 105109433;
							%Itemid4 = 105109434;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName1 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName2 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName3 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName4 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";
						case 100114:
							%Itemid1 = 105109441;
							%Itemid2 = 105109442;
							%Itemid3 = 105109443;
							%Itemid4 = 105109444;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName1 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName2 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName3 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName4 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";
						case 100115:
							%Itemid1 = 105109451;
							%Itemid2 = 105109452;
							%Itemid3 = 105109453;
							%Itemid4 = 105109454;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName1 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName2 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName3 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName4 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";
						case 100116:
							%Itemid1 = 105109461;
							%Itemid2 = 105109462;
							%Itemid3 = 105109463;
							%Itemid4 = 105109464;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName1 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName2 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName3 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName4 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";
						case 100117:
							%Itemid1 = 105109471;
							%Itemid2 = 105109472;
							%Itemid3 = 105109473;
							%Itemid4 = 105109474;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName1 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName2 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName3 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName4 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";
						case 100118:
							%Itemid1 = 105109481;
							%Itemid2 = 105109482;
							%Itemid3 = 105109483;
							%Itemid4 = 105109484;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName1 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName2 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName3 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName4 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";
						case 100119:
							%Itemid1 = 105109491;
							%Itemid2 = 105109492;
							%Itemid3 = 105109493;
							%Itemid4 = 105109494;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>����</t>" @ %ItemName1 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName2 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName3 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>��</t><b/>" @
								"<t>����</t>" @ %ItemName4 @ "<t>* 1���������� </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>��</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "���ȷ�����Ͻɰ��������д˵ȼ����䡣</t>";

						case 100120:return $Icon[5] @ "<t>ȷ������</t>";
						case 100121:return $Icon[5] @ "<t>ȷ������</t>";
						case 100122:return $Icon[5] @ "<t>ȷ������</t>";
						case 100123:return $Icon[5] @ "<t>ȷ������</t>";
						case 100124:return $Icon[5] @ "<t>ȷ������</t>";
						case 100125:return $Icon[5] @ "<t>ȷ������</t>";
						case 100126:return $Icon[5] @ "<t>ȷ������</t>";
						case 100127:return $Icon[5] @ "<t>ȷ������</t>";
						case 100128:return $Icon[5] @ "<t>ȷ������</t>";
						case 100129:return $Icon[5] @ "<t>ȷ������</t>";


						//-------------------���ɾ��׵Ľ������׺ͽ�ש����----------------
						case 100130:return $Icon[5] @ "<t>����һ��</t>";
						case 100131:return $Icon[5] @ "<t>����ȫ��</t>";
						case 100132:return $Icon[5] @ "<t>����һ��</t>";
						case 100133:return $Icon[5] @ "<t>����ȫ��</t>";
					}
					//%ItemName1 = "<l i='" @ 105109491 @ "' t='itemid'/>";
					//%ItemName2 = "<l i='" @ 105109492 @ "' t='itemid'/>";
					//%ItemName3 = "<l i='" @ 105109494 @ "' t='itemid'/>";
					//return
					//	"<t>������Ҫ��</t><b/>" @
					//	"<t>    </t>" @ %ItemName1 @ "<t>* 10</t><b/>" @
					//	"<t>    </t>" @ %ItemName2 @ "<t>* 10</t><b/>" @
					//	"<t>    </t>" @ %ItemName3 @ "<t>* 10</t><b/>" @
					//	"<t>ÿ����һ�ݿ����ӣ�</t><b/>" @
					//	"<t>  �������� </t>" @ $Get_Dialog_GeShi[31409] @ "18 </t><t>��</t><b/>";
				}
			case 7:
				//�׷������ƴ�� 800 @ %PlayGameID(4λ)
				if (GetSubStr(%DialogID,0,3) == 800)
				{
					//�׷������ƴ�� 800 @ %PlayGameID(4λ)
					%PlayGameID = %DialogID%100;
					return $Icon[94] @ "<b/><t>  </t>" @ $PlayGameHelpEx[%PlayGameID,2];
				}
			case 8:
		}
	}
	return "Get_TY_Dialog == ���� Npc��"@%Npc@"��Player��"@%Player@"��DialogID��"@%DialogID@"��Id��"@%Param@"��";
}


//�����������������������Ͻɽ�������˵����������������������������������������
function GetMissionSubmitDialogText(%missionid)
{
	%player = Getplayer();
	switch (%missionid)
	{
		case 1000:return
			$Get_Dialog_GeShi[11400] @ "����3������������ʹ�ã�</t><b/>" @
			"<t>  ������3����ʯ�������Ͻ���</t><b/>" @
			"<t>  ��ȷ�Ϻ��Զ��۳���3������������</t><b/>" @
			"<t>  ���ɹ��󽫻�ö�Ӧ�ġ�4����ʯ��</t><b/><b/>" @
			$Get_Dialog_GeShi[11400] @ "���ر�ע�⣺</t><b/>" @
			"<t>  ��������ġ�4����ʯ�����᡺���ɽ��ס�</t>";
	}
}

//������������������������Ϸ�ҵĸ�ʽ������������������������������������������
function Mission_Special_Money_HX(%MissionData_Money,%Genre)
{

	//%MissionData_Money ����
	//%Genre ��Ǯ���� 0��ң�1Ԫ��

	//Ԫ����������
	if (%MissionData_Money != 0)
	{
		%a = %MissionData_Money;
		%b = 9 - strlen(%a);
		%c = "1";
		for (%i = 0; %i < %b; %i++)
			%c = %c @ "0";

		%Money = %c @ %a;

		%Money_A = GetSubStr(%Money,1,5) + 0;	//���
		%Money_B = GetSubStr(%Money,6,2) + 0;	//����
		%Money_C = GetSubStr(%Money,8,2) + 0;	//ͭ��

		%Txt = $Get_Dialog_GeShi[31401];

		%Icon_G = (%Genre == 0) ? 85 : 81;

		if (%Money_A > 0)
			%Show_A = %Txt @ %Money_A @ "</t> "@ $Icon[%Icon_G];
		else
			%Show_A = "";

		if (%Money_B > 0)
			%Show_B = %Txt @ %Money_B @ "</t> " @ $Icon[%Icon_G+1];
		else
			%Show_B = "";

		if (%Money_C > 0)
			%Show_C = %Txt @ %Money_C @ "</t> " @ $Icon[%Icon_G+2];
		else
			%Show_C = "";

		return %Money = $Get_Dialog_GeShi[31412] @ "</t>" @ %Show_A @ %Show_B @ %Show_C @ "<t></t>";
	}
	else
		return %Money = "";
}

//��ȡ����ǰ��ͼ��
//������������������������������ǰ��ͼ���������������������������������������
function GetMissionIcon(%MID)
{
	switch (GetMissionData(%MID,$Mission_Data_Type))
	{
		case 0:	return $Icon[18];	//"��ʥ������"//֧���������ͼ��
		case 1:	return $Icon[17];	//"���»�����"//�����������ͼ��
		case 2:	return $Icon[18];	//"��֧�߾��顽"//֧���������ͼ��
		case 3:	return $Icon[19];	//"��ÿ��ѭ����"//ѭ���������ͼ��
		case 4:	return $Icon[18];	//"����������"//֧���������ͼ��
		case 5:	return $Icon[18];	//"��ָ������"//֧���������ͼ��
		case 6:	return $Icon[18];	//"�������"//֧���������ͼ��
		case 7:	return $Icon[18];	//"����������"//֧���������ͼ��
		default: return $Icon[18];	//֧���������ͼ��
	}
}

//���������
function Get_HuoDong_Dialog(%Npc,%Player,%DialogID,%Param)
{
	//�Ի�������������9λ��0����
	//������7��ͷ���磺7 001 000 01
	//���а���˳������
	%Dlg = GetSubStr(%DialogID,1,3);
	%MDFunction = "HuoDong_" @ %Dlg @ "_Dialog" @ "(%Npc, %Player, %DialogID);";
	return eval(%MDFunction);
}

function HuoDong_001_Dialog(%Npc,%Player,%DialogID)
{
	return %Txt;
}

