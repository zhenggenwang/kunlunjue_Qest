
//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//������ع��ܽű�
//==================================================================================

//������ת��ڣ�ѡ�к�ʹ��F3���ɣ�����㲻����UE���ǾͰﲻ������

function UPCS_FamilyFunction(%Num)
{
	if ((%Num == 1)||(%Num == 99)){ Exec("./S_01_SiegeWarfare.cs"); }
	if ((%Num == 2)||(%Num == 99)){ Exec("./S_02_OrgActvity.cs"); }
}

UPCS_FamilyFunction(99);


function FamilyDialog(%Npc, %Player, %State, %Conv)
{
	%PlayerID = %Player.GetPlayerID();
	%FamilyID = %Player.GetOrgID();
	%Family_Master = SptOrg_GetMaster(%FamilyID);
	%FamilyLv = SptOrg_GetLevel(%FamilyID);
	switch (%state)
	{
		case 0:
			%Conv.AddOption(100033, 100033);//��������
			%Conv.AddOption(100034, 100034);//��ѯ����
			%Conv.AddOption(100035, 100035);//��������
			%Conv.AddOption(100036, 100036);//������ս
			%Conv.AddOption(100037, 100037);//���ɾ���
		case 100033://��������
			if (%Player.GetLevel() < 30)
			{
				SendOneScreenMessage(2, "���ĵȼ�����", %Player);
				SendOneChatMessage($chatMsg_System, "<t>" @ "���ĵȼ�����" @ "</t>", %Player);
				return  NpcOnTrigger(%Conv, %Npc, %Player, 0, -1);
			}
			%orgID = SptOrg_GetOrgID(%PlayerID);		//����ID
			if (%orgID > 0)
			{
				SendOneScreenMessage(2, "���Ѽ������", %Player);
				SendOneChatMessage($chatMsg_System, "<t>" @ "���Ѽ������" @ "</t>", %Player);
				return  NpcOnTrigger(%Conv, %Npc, %Player, 0, -1);
			}
			else
			{
				%Conv.Settype(4);
				ServerOnSptAction(%PlayerID, 1, 19);//ͨѶ�ͻ���
			}
		case 100034://��ѯ����
			//echo( "%state =====" @ %state );
			%Conv.Settype(4);
			ServerOnSptAction(%PlayerID, 666, 19);//ͨѶ�ͻ���
		case 100035://��������
			%Conv.Settext(100083);
			%Conv.AddOption(100084, 100084);
		case 100084:
			switch (%FamilyLv)
			{
				case 1:
					%ShengWang = 288000;
					%HuoYue = 10000;
					%ItemID[1] = 105105303;
					%ItemNum[1] = 10;
				case 2:
					%ShengWang = 4320000;
					%HuoYue = 20000;
					%ItemID[1] = 105105304;
					%ItemNum[1] = 10;
				case 3:
					%Text = "���İ��ɵȼ��Ѵﵽ����";
					%ItemID[1] = 105105304;
					%ItemNum[1] = 50;
					%ItemID[2] = 105105305;
					%ItemNum[2] = 1;
					%ShengWang = 14400000;
					%HuoYue = 30000;
				case 4:
					%Text = "���İ��ɵȼ��Ѵﵽ����";
					%ItemID[1] = 105105304;
					%ItemNum[1] = 100;
					%ItemID[2] = 105105305;
					%ItemNum[2] = 10;
					%ShengWang = 36000000;
					%HuoYue = 40000;
				default:
					%Text = "��û�а��ɻ��߲��ǰ���";
			}
			for (%i = 1; %i <= 9; %i++)
			{
				if (%ItemID[%i] > 0)
				{
					if (%Player.GetItemCount(%ItemID[%i]) < %ItemNum[%i])
					{
						%Text = "��û���㹻��" @ GetItemData(%ItemID[%i], 1);
						break;
					}
				}
				else
					break;
			}
			if (SptOrg_GetHonor(%FamilyID)  < %ShengWang)
				%Text = "��������������Ҫ�ﵽ" @ %ShengWang @ "����";
			if (SptOrg_GetActivity(%FamilyID) < %HuoYue)
				%Text = "��������������Ҫ�ﵽ" @ %HuoYue @ "��Ծ";
			if (%PlayerID !$= %Family_Master)
				%Text = "�����ǰ��������ð�������������";
			if (%Text !$= "")
			{
				SendOneScreenMessage(2, %Text, %Player);
				SendOneChatMessage($chatMsg_System, "<t>" @ %Text @ "</t>", %Player);
				return NpcOnTrigger(%Conv, %Npc, %Player, 0, -1);
			}
			else
			{
				%Conv.Settype(4);
				ServerOnSptAction(%PlayerID, %FamilyLv + 1, 19);//ͨѶ�ͻ���
			}
		case 100036://������ս
			if (%PlayerID !$= %Family_Master)
				%Text = "�����ǰ��������ð�����������ս";
			if (%Text !$= "")
			{
				SendOneScreenMessage(2, %Text, %Player);
				SendOneChatMessage($chatMsg_System, "<t>" @ %Text @ "</t>", %Player);
				return NpcOnTrigger(%Conv, %Npc, %Player, 0, -1);
			}
			else
			{
				%Conv.Settype(4);
				ServerOnSptAction(%PlayerID, 666, 19);//ͨѶ�ͻ���
			}
		case 100037://���ɾ���
			%orgID = SptOrg_GetOrgID(%Player.GetPlayerID());		//����ID
			if (%orgID > 0)
			{
				%Conv.SetText(100074);
				%Conv.AddOption(100038, 100038);//���׽���</t>";
				%Conv.AddOption(100039, 100039);//���׽�ש</t>";
				%Conv.AddOption(100040, 100040);//����һ������</t>";
				%Conv.AddOption(100041, 100041);//���׶�������</t>";
				%Conv.AddOption(100042, 100042);//������������</t>";
				%Conv.AddOption(100043, 100043);//�����ļ�����</t>";
				%Conv.AddOption(100044, 100044);//�����弶����</t>";
				%Conv.AddOption(100045, 100045);//������������</t>";
				%Conv.AddOption(100046, 100046);//�����߼�����</t>";
				%Conv.AddOption(100047, 100047);//���װ˼�����</t>";
				//%Conv.AddOption(100048, 100048);//���׾ż�����</t>";
				//%Conv.AddOption(100049, 100049);//����ʮ������</t>";
			}
			else
			{
				%Text = "����ǰû�а��ɣ����ȼ������";
				SendOneScreenMessage(2, %Text, %Player);
				SendOneChatMessage($chatMsg_System, "<t>" @ %Text @ "</t>", %Player);
				return NpcOnTrigger(%Conv, %Npc, %Player, 0, -1);
			}
		case 100038://���׽���</t>";
			%Conv.SetText(%State + 12);
			%Conv.AddOption(100130, 100130);
			%Conv.AddOption(100131, 100131);
			%Conv.AddOption(4, 100037);
		case 100039://���׽�ש</t>";
			%Conv.SetText(%State + 12);
			%Conv.AddOption(100132, 100132);
			%Conv.AddOption(100133, 100133);
			%Conv.AddOption(4, 100037);
	}
	if (%State >=  100040  && %State <= 100049)
	{
		//echo( " %State===" @  %State );
		//echo( "=================" @ %State + 9 +( %State  - 100040 ) * 2 );
		%Conv.SetText(%State + 12);
		%Conv.AddOption(%State + 24, %State + 24);
		%Conv.AddOption(4, 100037);
	}
	switch (%State)
	{
		case 100130:
			%ItemID[1] = 105105303;
			%ItemCount = %Player.GetItemCount(%ItemID[1]);
			if (%ItemCount > 0)
			{
				%Player.putitem(%ItemID[1], -1);
				if (%Player.Additem(5, 1010))
				{
					AddFamily_SW_GX(%Player, $MenPaiShengWangJuanXian[%ItemID[1]] , $MenPaiShengWangJuanXian[%ItemID[1]] );
					GetOrgActivityWages(%Player, 1);
				}
			}
			return FamilyDialog(%Npc, %Player, 100038, %Conv);
		case 100132:
			%ItemID[1] = 105105304;
			%ItemCount = %Player.GetItemCount(%ItemID[1]);
			if (%ItemCount > 0)
			{
				%Player.putitem(%ItemID[1], -1);
				if (%Player.Additem(5, 1010))
				{
					AddFamily_SW_GX(%Player, $MenPaiShengWangJuanXian[%ItemID[1]] , $MenPaiShengWangJuanXian[%ItemID[1]] );
					GetOrgActivityWages(%Player, 1);
				}
			}
			return FamilyDialog(%Npc, %Player, 100039, %Conv);
		case 100131:%ReturState = 100037; %ItemID[1] = 105105303; %ItemID[2] = 0; %ItemID[3] = 0; %ItemID[4] = 0;
		case 100133:%ReturState = 100037; %ItemID[1] = 105105304; %ItemID[2] = 0; %ItemID[3] = 0; %ItemID[4] = 0;
		case 100064:%ReturState = 100037; %ItemID[1] = 105109401; %ItemID[2] = 105109402; %ItemID[3] = 105109403; %ItemID[4] = 105109404;
		case 100065:%ReturState = 100037; %ItemID[1] = 105109411; %ItemID[2] = 105109412; %ItemID[3] = 105109413; %ItemID[4] = 105109414;
		case 100066:%ReturState = 100037; %ItemID[1] = 105109421; %ItemID[2] = 105109422; %ItemID[3] = 105109423; %ItemID[4] = 105109424;
		case 100067:%ReturState = 100037; %ItemID[1] = 105109431; %ItemID[2] = 105109432; %ItemID[3] = 105109433; %ItemID[4] = 105109434;
		case 100068:%ReturState = 100037; %ItemID[1] = 105109441; %ItemID[2] = 105109442; %ItemID[3] = 105109443; %ItemID[4] = 105109444;
		case 100069:%ReturState = 100037; %ItemID[1] = 105109451; %ItemID[2] = 105109452; %ItemID[3] = 105109453; %ItemID[4] = 105109454;
		case 100070:%ReturState = 100037; %ItemID[1] = 105109461; %ItemID[2] = 105109462; %ItemID[3] = 105109463; %ItemID[4] = 105109464;
		case 100071:%ReturState = 100037; %ItemID[1] = 105109471; %ItemID[2] = 105109472; %ItemID[3] = 105109473; %ItemID[4] = 105109474;
		case 100072:%ReturState = 100037; %ItemID[1] = 105109481; %ItemID[2] = 105109482; %ItemID[3] = 105109483; %ItemID[4] = 105109484;
		case 100073:%ReturState = 100037; %ItemID[1] = 105109491; %ItemID[2] = 105109492; %ItemID[3] = 105109493; %ItemID[4] = 105109494;
	}
	if (%ReturState > 0)
	{
		for (%i = 1; %i <= 4; %i++)
		{
			if (%ItemID[%i] > 0 )
			{
				%ItemCount = %Player.GetItemCount(%ItemID[%i]);
				//echo("%ItemID[" @ %i @ "]===" @ %ItemID[%i] @ "  " @ %Player.GetItemCount(%ItemID[%i]));
				if (%ItemCount > 0)
				{
					%Player.putitem(%ItemID[%i], -%ItemCount);
					if (%Player.Additem(5, 1010))
					{
						AddFamily_SW_GX(%Player, $MenPaiShengWangJuanXian[%ItemID[%i]] * %ItemCount, $MenPaiShengWangJuanXian[%ItemID[%i]] * %ItemCount);
						GetOrgActivityWages(%Player, 1);
					}
				}
				
			}
		}
		return FamilyDialog(%Npc, %Player, %ReturState, %Conv);
	}
}

function AddOrgLevel(%PLayer, %SubType)
{
	//%orgID = SptOrg_GetOrgID( %PlayerID );		//����ID
	%FamilyID = %Player.GetOrgID();
	%Family_Master = SptOrg_GetMaster(%FamilyID);
	%FamilyLv = SptOrg_GetLevel(%FamilyID);
	%PlayerID = %Player.GetPlayerID();
	//echo( "%FamilyID===" @ %FamilyID );
	//echo( "%Family_Master===" @ %Family_Master );
	//echo( "%FamilyLv===" @ %FamilyLv );
	switch (%FamilyLv + 1)
	{
		case 2:
			%ShengWang = 288000;
			%HuoYue = 10000;
		case 3:
			%ShengWang = 4320000;
			%HuoYue = 20000;
		case 4:
			%ShengWang = 14400000;
			%HuoYue = 30000;
		case 5:
			%ShengWang = 36000000;
			%HuoYue = 40000;
		default:
			return;
	}

	//echo( "SptOrg_GetHonor( %FamilyID ) ===" @ SptOrg_GetHonor( %FamilyID ) );
	if (SptOrg_GetHonor(%FamilyID)  < %ShengWang)
		return;
	if (SptOrg_GetActivity(%FamilyID) < %HuoYue)
		return;
	if (%PlayerID !$= %Family_Master)
		return;
	switch (%SubType)
	{
		case 2:
			%Player.PutItem(105105303, -10);
			if (%Player.Additem(5, 1010))
				SptOrg_AddLevel(%FamilyID);
		case 3:
			%Player.PutItem(105105304, -10);
			if (%Player.Additem(5, 1010))
				SptOrg_AddLevel(%FamilyID);
		case 4:
			%Player.PutItem(105105304, -50);
			%Player.PutItem(105105305, -1);
			if (%Player.Additem(5, 1010))
				SptOrg_AddLevel(%FamilyID);
		case 5:
			%Player.PutItem(105105304, -100);
			%Player.PutItem(105105305, -10);
			if (%Player.Additem(5, 1010))
				SptOrg_AddLevel(%FamilyID);
	}
}

//------------�����ħ------------

function Mission_Begin_Process_20028(%Npc, %Player, %Conv, %Param, %Mid)
{
	%Level = %Player.GetLevel();
	if (%Level <= 45) %NpcID = 411011014;
	else if (%Level <= 60) %NpcID = 411021014;
	else if (%Level <= 75) %NpcID = 411031014;
	else if (%Level <= 90) %NpcID = 411041014;
	else %NpcID = 411051014;

	%Player.SetMissionFlag(%Mid, 3100, %NpcID);	//����,������
	%Player.SetMissionFlag(%Mid, 3200, 1);	//����,��������
	%Player.SetMissionFlag(%Mid, 3300, 0); 				//����,���ﵱǰ����
	%Player.UpdateMission(%Mid);//����������Ϣ
}

function Mission_End_Process_20028(%Npc, %Player, %Conv, %Param, %Mid)
{
	GetOrgActivityWages(%Player, 2);
}



//------------�ռ�����------------

function Mission_Begin_Process_20151(%Npc, %Player, %Conv, %Param, %Mid)
{
	%Player.SetMissionFlag(%Mid, 1100, 108030009);	//����,������
	%Player.SetMissionFlag(%Mid, 1200, 300);	//����,��������
	%Player.SetMissionFlag(%Mid, 1300, 0); 				//����,���ﵱǰ����
	%Player.UpdateMission(%Mid);//����������Ϣ
}

function Mission_End_Process_20151(%Npc, %Player, %Conv, %Param, %Mid)
{
	GetOrgActivityWages(%Player, 3);
}
