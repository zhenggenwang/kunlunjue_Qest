//�������������������������д����Ի�����ű���ڡ�������������������������������
//����������������������ɾ�����񴥷��ű����ϡ�����������������������������������
//���������������������������鴥���Ų�������������������������������������������

//��������������������������ʹ�ô����ű�����������������������������������������
//��������������������������װ�������ű�����������������������������������������
//��������������������������ж�ش����ű�����������������������������������������
//�������������������������򴥷��ű���������������������������������������������
//����������������������ʹ�����޵��Լ����ﵰ�ɹ�����á���������������������

//�������������������������ϵĵ��ߴ����ű���������������������������������������
//����������������������ѭ��������ߴ����ű�������������������������������������

//�������������������������ؾ����ߴ�����������������������������������������������
//����������������������������ʾ��װ�ű�����������������������������������������
//������������������������ʾ��ʾ��װ�ű�����������������������������������������
//��������������������������ͳһ�����������������������������������������������
//�������������������������д����Ի�����ű���ڡ�������������������������������
//����������������������ʹ�õ��ߴ��������������������������������������
//�������������������������سǺʹ�����ص��ߡ�����������������������
//105300001	�ջ�Ծ���( ���� )
//105300002	�ջ�Ծ���( �м� )
//105300003	�ջ�Ծ���( �߼� )
//105300004	�ջ�Ծ���( ���� )

function OnTriggerMission(%Player,%X_ID,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	//echo( "��������===" @ GetItemData( %X_ID, 2 ) );
	//echo( "��������===" @ GetItemData( %X_ID, 3 ) );
	%Conv = %Player.GetConversation();
	if (%State == -1)
	{
		%Conv.SetType(4);
		%Conv.Send(%Player);
		return;
	}

	//ɾ�����񴥷�
	if (%State == -2)
		return OnTriggerDelMission(%Player,%X_ID);


	//������ڼ�������
	if ((GetItemData(%X_ID,2) == 5) && (GetItemData(%X_ID,3) >= 522) && (GetItemData(%X_ID,3) <= 526))
		Trigger_Item_skillbook(%Player,%X_ID);

	//���������װ����
	if ((GetItemData(%X_ID,2) == 16) && (GetItemData(%X_ID,3) == 1612))
		Trigger_Item_TaoZhuang_CaiLiao(%Player,%X_ID);

	//������ڱ�ʯ
	if ((GetItemData(%X_ID,2) == 10) && (GetItemData(%X_ID,3) >= 1001) && (GetItemData(%X_ID,3) <= 1003))
		Trigger_Item_BaoShi(%Player,%X_ID);

	//������ڳ��＼������
	if ((GetItemData(%X_ID,2) == 5) && (GetItemData(%X_ID,3) == 516))
		Trigger_ChongWu_skillbook(%Player,%X_ID);

	//���������
	if ((GetItemData(%X_ID,2) == 16) && (GetItemData(%X_ID,3) == 1611))
		Trigger_ShiZhuang_MingPai(%Player,%X_ID);

	//����ƺ���
	if ((GetItemData(%X_ID,2) == 5) && (GetItemData(%X_ID,3) == 528))
		Trigger_Item_ChengHao(%Player,%X_ID);

	//���X_ID��9λ
	if (strlen(%X_ID) == 9)
	{
		switch (GetSubStr(%X_ID,0,1))
		{
			case 1:
				//�жϴ˵����Ƿ�����������͵���
				if ((GetItemData(%X_ID,2) == 5) && (GetItemData(%X_ID,3) == 518))
					return Trigger_Bao(%Conv,%Player,%X_ID,%State,%Param);	//���
				if (%X_ID >= 105101000  && %X_ID <= 105103999)
					return Trigger_BaoSpecial(%Conv,%Player,%X_ID,%State,%Param);	//�������
				//�жϴ˵����Ƿ������䷽ѧϰ����
				if (GetItemData(%X_ID,2) == 9)
				{
					%WhyNot = "";																		//Ĭ�ϵķ�����Ϣ
					%PresID = GetItemData(%X_ID,$Item_Data_PresID);		//�䷽���
					%livingSkillId = GetPrescriptionData(%PresID,$PrescriptionData_LiveSkill);		//��Ҫ������ܱ��
					%livingSkillId_Exp = GetPrescriptionData(%PresID,$PrescriptionData_Exp);	//����������������

					if (isLearnLivingSkill(%Player.GetPlayerID(),%livingSkillId) == 1)						//�жϸ�������Ƿ��Ѿ�ѧ��,0û��ѧ��,1ѧ��
					{
						if (%Player.GetLivingSkillRipe(%livingSkillId) >= %livingSkillId_Exp)		//�ж�����������ȳ�����Ҫ���ֵ
						{
							if (AddPrescription(%Player,%PresID))		//ѧϰ�䷽
							{
								DelItemFromInventoryByIndex(%Player.GetPlayerID(),%XYZ,%X_ID,1,16,%X_ID);		//ɾ������
								SendOneChatMessage($chatMsg_Person,"<t>��ѧ���ˡ�</t><l i='" @ %X_ID @ "' t='itemid'/><t>��</t>",%Player);
								SendOneScreenMessage(1,"��ѧ���ˡ�" @ GetItemData(%X_ID,1) @ "��",%Player);
							}
							else
							{
								%Txt = "���Ѿ�ѧ���˴��䷽";
								SendOneChatMessage($chatMsg_Person,"<t>" @ %Txt @ "</t>",%Player);
								SendOneScreenMessage(2,%Txt,%Player);
							}
						}
						else
							%WhyNot = "����Ӧ������������Ȳ��㡾"@%livingSkillId_Exp@"�����޷�ѧϰ���䷽";
					}
					else
						%WhyNot = "��û��ѧ����Ӧ������ܣ��޷�ѧϰ���䷽";

					if (%WhyNot !$= "")
					{
						SendOneChatMessage($chatMsg_System,"<t>" @ %WhyNot @ "</t>",%Player);
						SendOneScreenMessage(2,%WhyNot,%Player);
					}

					return;
				}

				//ִ����Ӧ�����ĵ��ߴ����ű�
				%FuncName_A = "Trigger_" @ %X_ID;
				if (isFunction(%FuncName_A))
					eval(%FuncName_A @ "(%Conv, %Player, %X_ID, %State, %TriggerType, %TriggerID, %Param, %XYZ);");

				//�ж�ĳ��Ʒ�Ƿ�Ҫʹ�ú���ʧ
				if (CheckBit(GetItemData(%X_ID,$Item_Data_Type),10) == 1)
				{
					//�ж�ĳ��Ʒ�Ƿ�������ʹ�ô���
					if (%Player.IsItemUsedTimes(%X_ID,%XYZ) > 0)
						if (%Player.GetItemUsedTimes(%X_ID,%XYZ) > 0)
							%Player.SetItemUsedTimes(%X_ID,%XYZ,%Player.GetItemUsedTimes(%X_ID,%XYZ) - 1);

					if (%Player.GetItemUsedTimes(%X_ID,%XYZ) <= 0)
						DelItemFromInventoryByIndex(%Player.GetPlayerID(),%XYZ,%X_ID,1,16,%X_ID);
				}

				//��λ��8���������򴥷��ű�
			case 8:
				%FuncName_B = "Trigger_" @ %X_ID;
				if (isFunction(%FuncName_B))
					eval(%FuncName_B @ "(%Conv, %Player, %X_ID, %State, %TriggerType, %TriggerID, %Param, %XYZ);");

				//��λ��5�����ǲɼ��¼�
			case 5:
				%FuncName_B = "Trigger_" @ %X_ID;
				if (isFunction(%FuncName_B))
					eval(%FuncName_B @ "(%Conv, %Player, %X_ID, %State, %TriggerType, %TriggerID, %Param, %XYZ);");
		}
	}
	else if (strlen(%X_ID) == 5)
	{
		%FuncName_C = "TriggerMission_" @ %X_ID;
		if (isFunction(%FuncName_C))
			eval(%FuncName_C @ "(%Conv, %Player, %X_ID, %State);");
	}
	else
	{
		%FuncName_C = "Trigger_" @ %X_ID;
		if (isFunction(%FuncName_C))
			eval(%FuncName @ "(%Conv, %Player, %X_ID, %State, %TriggerType, %TriggerID, %Param, %XYZ);");
	}
}


function Trigger_Item_ChengHao(%Player,%ItemID)
{
	//echo(%ItemID @ "   " @ GetItemData(%ItemID,1) @ "   " @ GetItemData(%ItemID,17));
	%DescID = GetItemData(%ItemID,17);
	if (%DescID <= 0)
		return;
	%Player.PutItem(%ItemID,-1);
	if (%Player.Additem(1,%itemid))
	{
		if (!%Player.sptIsDesignationExist(%DescID))
		{
			SendOneScreenMessage(1,"�ƺ���ӳɹ�",%Player);
			%Player.AddDesignation(%DescID);//      	���һ���µĳƺ�
		}
	}
}
//�������������������������д����Ի�����ű���ڡ�������������������������������


//����������������������ɾ�����񴥷��ű����ϡ�����������������������������������
function OnTriggerDelMission(%Player,%Mid)
{
	//��Ҫɾ�������¼
	%Player.DelMission = %Mid;

	%FuncName = "DelMission_" @ %Mid;

	if (isFunction(%FuncName))
		Call(%FuncName,%Player,%Mid);

	//��������
	if (GetMissionKind(%Mid) == 1)
	{
		if ((%Player.GetLevel() - 20) < GetMissionData(%Mid,$Mission_Data_LvA))
		{
			SendOneChatMessage($chatMsg_System,"<t>��������20���ġ��������񡿲ſɷ���</t>",%Player);
			SendOneScreenMessage(2,"��������20���ġ��������񡿲ſɷ���",%Player);
			return;
		}

		//�����ǽ����������ߵ����񣬷������޷�����ȡ
		if (GetMissionData(%Mid,$Mission_Data_ItemAdd) !$= 0)
			%Player.SetMission(%Mid,1);
	}
	//���������
	if (%Mid >= 30100 && %Mid < 30712)
	{
		SendOneScreenMessage(2,"����ܲ��ɷ���",%Player);
		return;
	}
	//----------------------��������������Ĵ���-------------------------
	%Player.DelMission(%Mid);
	if (%mid == 20147)
	{
		%Player.BiaoCheSuiCong.Safedeleteobject();
		SetAct(%Player,4018,GetAct(%Player,4018,0),0);
	}
	if (%mid == 20148)
	{
		%count = %Player.getitemcount(108030001);
		if (%count > 0)
		{
			%Player.putitem(108030001,-%count);
			%player.additem(1,20148);
		}
	}
	if (%mid == 20149)
	{
		%Player.SetSchbuff(2003);
		%Act4015[0] = GetAct(%player,4015,0);
		%Act4015[1] = GetAct(%player,4015,1);
		%Act4015[1]++;
		Setact(%player,4015,%Act4015[0],%Act4015[1]);
	}

	if (%mid >= 29000 && %mid <= 30000)//���ͼ��������������
	{
		%Player.SetSchbuff(2015);
		for (%i = 4025; %i <= 4029; %i++)
		{
			%MidID = GetAct(%Player,%i,0) + 29000;
			if (%MidID == %Mid)
			{
				%CoLor =  GetAct(%Player,%i,1);//Ʒ����ɫ
				%Act = %i;//��¼���
				break;
			}
		}
		if (%Act > 0)
			SetAct(%Player,%Act,0,0);
	}

	if(%mid == 29999)
		AddMissionAccepted(%Player,%Conv,%Mid);

	SendOneChatMessage($chatMsg_Person,"<t>��������[" @ GetMissionData(%Mid,$Mission_Data_Name) @ "]����</t>",%Player);
	SendOneScreenMessage(1,"��������[" @ GetMissionData(%Mid,$Mission_Data_Name) @ "]����",%Player);
	ServerOnSptAction(%Player.GetPlayerID(),%Mid,4);//ͨѶ�ͻ���
	return;
}
//����������������������ɾ�����񴥷��ű����ϡ�����������������������������������


//����������������������������ʾ��װ�ű�����������������������������������������
function Message_Error_Hint(%Player,%Txt)
{
	SendOneScreenMessage(2,%Txt,%Player);	//��ɫ��Ϣ
	SendOneChatMessage($chatMsg_System,"<t>"@ %Txt @"</t>",%Player);
}
//������������������������ʾ��ʾ��װ�ű�����������������������������������������
//������������������������ʾ��ʾ��װ�ű�����������������������������������������
function Message_Caution_Hint(%Player,%Txt)
{
	SendOneScreenMessage(1,%Txt,%Player);	//��ɫ��Ϣ
	SendOneChatMessage($chatMsg_System,$Get_Dialog_GeShi[31204] @ %Txt @"</t>",%Player);
}
//������������������������ʾ��ʾ��װ�ű�����������������������������������������

//���������������������������鴥���Ų�������������������������������������������
function Trigger_Item_skillbook(%Player,%X_ID)
{
	%SkillBookID = GetItemData(%X_ID,17);
	%SkillNeedID = GetItemData(%X_ID,54);
	%ClassesID = GetItemData(%X_ID,113);
	%ItemLevel = GetItemData(%X_ID, $Item_Data_Lv);

	%SkillID = GetSubStr(%SkillBookID,0,5);
	%SkillNeed = GetSubStr(%SkillNeedID,0,5);
	
	//putout("�����鴥���Ų�==" @ %X_ID);
	if (HasBit(%ClassesID,%Player.GetClasses(0) - 1) == 0)
	{
		%Txt = "����ְҵ�������޷�ʹ�ô˼����飡";
		Message_Error_Hint(%Player,%Txt);
		return;
	}

	if (%SkillNeedID > 0)
	{
		if (%Player.GetSkillLevel(%SkillNeed) == 0)
		{
			%Txt = "����δѧϰ�˼��ܵ�ǰ�ü��ܣ�";
			Message_Error_Hint(%Player,%Txt);
			return;
		}
	}

	if (%Player.GetSkillLevel(%SkillID) == 0)
	{
		%ItemAdd = %Player.PutItem(%X_ID,-1);
		%ItemAdd = %Player.AddItem(4,%X_ID);
		if (%ItemAdd)
		{
			%Txt = "��ϲ��ɹ�ϰ�á�"@GetItemData(%X_ID,1)@"�����ܡ�";
			SendOneScreenMessage(1,%Txt,%Player);	//��ɫ��Ϣ
			SendOneChatMessage($chatMsg_System,$Get_Dialog_GeShi[31404] @ %Txt @ "</t>",%Player);
			%Player.AddSkill(%SkillBookID);
			if (%ItemLevel >= 40)
				SetStrategyRecord(%Player, 82);
		}
	}
	else
	{
		%Txt = "���Ѿ�ѧ�᡾"@GetItemData(%X_ID,1)@"�����ܣ��޷��ٴ�ʹ�á�";
		SendOneScreenMessage(2,%Txt,%Player);	//��ɫ��Ϣ
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
	}
	//------------��������----ѧϰ�����鴥��---------
	if (%X_ID == 105220003 || %X_ID ==105250003 || %X_ID ==105240003)
	{
		if (%Player.IsAcceptedMission(10121))
		{
			%Player.SetMissionFlag(10121,1350,1);
			SendOneScreenMessage(1,"ѧϰ������  1/1",%Player);
			%Player.UpdateMission(10121);
		}
	}
	if (%X_ID == 105220004 || %X_ID ==105250005 || %X_ID ==105240004)
	{
		if (%Player.IsAcceptedMission(10231))
		{
			%Player.SetMissionFlag(10231,1350,1);
			SendOneScreenMessage(1,"ѧϰ������  1/1",%Player);
			%Player.UpdateMission(10231);
		}
	}
}
//���������������������������鴥���Ų�������������������������������������������
//105180171	�ƿմ�
//105180172	������

//��������������������������ʹ�ô����ű�����������������������������������������
//���п�ʹ�õĵ��ߣ�ʹ��ʱ�����Ľű�
function Item_Use(%Player,%ItemID,%TriggerType,%TriggerID,%XYZ)
{
	//echo( "����ʹ�ô����ű�" @  %TriggerType  @ "   " @  %TriggerID  @ "  " @ %XYZ );

	$Item_Use_Return = 1;

	//0��ʹ��ʧ�ܣ���ִ�к�������
	//1��ʹ�óɹ�
	//echo( "ʹ��ʱ�����Ľű�%ItemID===" @ %ItemID );
	//���е��ߣ�ͳһִ��OnTriggerMission����
	OnTriggerMission(%Player,%ItemID,0,%TriggerType,%TriggerID,0,%XYZ);

	%ItemLx = GetItemData(%ItemID,$Item_Data_Big_Index);
	%ItemZx = GetItemData(%ItemID,3);

	if (%ItemLx == 12)
	{
		if (%ItemZx == 1209)
		{
			sptUseBonusItem(%Player.GetPlayerID(),%ItemID);//�̳����
		}
	}

	return $Item_Use_Return;
}
//��������������������������ʹ�ô����ű�����������������������������������������

//����������������������ʹ�����޵��Լ����ﵰ�ɹ�����á���������������������
function onGeneratePetInfo(%Player,%ItemId,%MountId)//����
{
	//���޹ȵ���
	if ((%itemid == 118011001) || (%itemid == 118011002))
	{
		//ͨѶ�ͻ���
		ServerOnSptAction(%Player.GetPlayerID(),0,135);

		%Player.AddObjectToPanel(4,0,18);
	}

	//֪��ͼ��
	if ((%itemid == 118011003) || (%itemid == 118011004))
	{
		ServerOnSptAction(%Player.GetPlayerID(),0,148);//ͨѶ�ͻ���
	}
}

function onGenerateMountInfo(%Player,%ItemId,%MountId)//����
{
	//	//��ְҵʹ����走֮�󴥷� - ����ʾ����ʾ��ҵ�һ��������Ѱ������
	if (%ItemId == 119014025)
	{
		%Player.AddObjectToPanel(5,0,9);//����һ�������������
		HelpDirectByIndex(%Player.GetPlayerID(),20);	//ͨѶ�ͻ���
	}
	else
	{
		if (GetSrc(%Player,188) == 0)
		{
			SetSrc(%Player,188);
			HelpDirectByIndex(%Player.GetPlayerID(),22);	//ͨѶ�ͻ���
		}
	}
}
//����������������������ʹ�����޵��Լ����ﵰ�ɹ�����á���������������������

//�������������������������߶Ե���ʹ�ýű���������������������������������������������

function ItemClickUse(%Player,%ItemID,%Index,%Tagitemid,%TagIndex)
{
	switch (%ItemID)
	{
		case 113070052://����������
			if (%Tagitemid == 113070051)//��λ��
			{
				if (%Player.GetItemUsedTimes(%Tagitemid,%TagIndex) >= 10)
				{
					SendOneScreenMessage(2,"���Ķ�λ���Ѿ�������������",%Player);
				}
				else
				{
					%Player.PutItem(%ItemID,-1);
					%Player.AddItem(4,%ItemID);
					%Player.SetItemUsedTimes(%Tagitemid,%TagIndex,10);
					SendOneScreenMessage(2,"��λ�������ɹ�",%Player);
				}
			}
			else
			{
				SendOneScreenMessage(2,"����Ʒֻ�ܶԶ�λ��ʹ��",%Player);
			}

		case 113070054://���綨λ������
			if (%Tagitemid == 113070053)	//���綨λ��
			{
				if (%Player.GetItemUsedTimes(%Tagitemid,%TagIndex) >= 10)
				{
					SendOneScreenMessage(2,"�������綨λ���Ѿ�������������",%Player);
				}
				else
				{
					%Player.PutItem(%ItemID,-1);
					%Player.AddItem(4,%ItemID);
					%Player.SetItemUsedTimes(%Tagitemid,%TagIndex,10);
					SendOneScreenMessage(2,"���綨λ�������ɹ�",%Player);
				}
			}
			else if (%Tagitemid == 113070055) //���綨λ�������飩
			{
				%DCs = %Player.GetItemUsedTimes(%Tagitemid,%TagIndex);

				if (%Player.GetItemUsedTimes(%Tagitemid,%TagIndex) >= 10)
				{
					SendOneScreenMessage(2,"�������綨λ���Ѿ�������������",%Player);
				}
				else
				{
					%Player.PutItem(%ItemID,-1);
					%Player.AddItem(4,%ItemID);
					%Player.SetItemUsedTimes(%Tagitemid,%TagIndex,%DCs + 2);
					SendOneScreenMessage(2,"���綨λ�������飩�����ɹ�",%Player);
				}
			}
			else
			{
				SendOneScreenMessage(2,"����Ʒֻ�ܶ����綨λ��ʹ��",%Player);
			}
	}

}
//�������������������������߶Ե���ʹ�ýű���������������������������������������������

//��������������������������װ�������ű�����������������������������������������
function Item_On(%Player,%ItemID)
{
	switch (%ItemID)
	{
		//---����װ��--
		case 102022000: Mission_ChuanDaiZhuangBei_10151(%Player,10151);
		case 102022050: Mission_ChuanDaiZhuangBei_10151(%Player,10151);
		case 102022200: Mission_ChuanDaiZhuangBei_10151(%Player,10151);
		case 102022250: Mission_ChuanDaiZhuangBei_10151(%Player,10151);
		case 102022300: Mission_ChuanDaiZhuangBei_10151(%Player,10151);
		case 102022350: Mission_ChuanDaiZhuangBei_10151(%Player,10151);
			//----�����ѧϰ---
		case 107020001: Mission_ChuanDaiShengHuoDaoJu(%Player,30101);
		case 107020002: Mission_ChuanDaiShengHuoDaoJu(%Player,30101);
		case 107020003: Mission_ChuanDaiShengHuoDaoJu(%Player,30101);
		case 107040001: Mission_ChuanDaiShengHuoDaoJu(%Player,30111);
		case 107040002: Mission_ChuanDaiShengHuoDaoJu(%Player,30111);
		case 107040003: Mission_ChuanDaiShengHuoDaoJu(%Player,30111);
		case 107010001: Mission_ChuanDaiShengHuoDaoJu(%Player,30121);
		case 107010002: Mission_ChuanDaiShengHuoDaoJu(%Player,30121);
		case 107010003: Mission_ChuanDaiShengHuoDaoJu(%Player,30121);
		case 107050001: Mission_ChuanDaiShengHuoDaoJu(%Player,30131);
		case 107050002: Mission_ChuanDaiShengHuoDaoJu(%Player,30131);
		case 107050003: Mission_ChuanDaiShengHuoDaoJu(%Player,30131);
	}
}
//��������������������������װ�������ű�����������������������������������������

//��������������������������ж�ش����ű�����������������������������������������
function Item_Off(%Player,%ItemID)
{

}
//��������������������������ж�ش����ű�����������������������������������������


//�������������������������ϵĵ��ߴ����ű���������������������������������������
//�ظ����ߵĴ������
//if ( %Type == 1 )
//{
//	for ( %i = 0; %i < %NumAll; %i++ )
//	{
//		%Item_Num_Add = $Item_Bao[ %ItemID, %i + 1 ];
//
//		%Item = GetWord( %Item_Num_Add, 0 );
//		%Num  = GetWord( %Item_Num_Add, 1 );
//
//		if ( ( %Item !$= "" )&&( %Num !$= "" ) )
//		{
//			//�����������Ϊ���
//			if ( GetItemData( %Item, 2 ) == 20 )
//			{
//				%WuHunID[ %i ] = %Item;
//				%WuHunNum[ %i ] = %Num;
//			}
//			else
//			{
//				%index = %Player.PutItem( %Item, %Num );
//				%Player.SetPutItemProperty( %index, 1, %Player.GetPlayerID( ) );
//			}
//		}
//	}
//}
////��������ߵĴ������
//if ( %Type == 2 )
//{
//	%RandID = GetRandom( 1, %NumAll );
//	%Item_Num_Add = $Item_Bao[ %ItemID, %RandID ];
//	%Item = GetWord( %Item_Num_Add, 0 );
//	%Num  = GetWord( %Item_Num_Add, 1 );
//
//	if ( ( %Item !$= "" )&&( %Num !$= "" ) )
//	{
//		//�����������Ϊ���
//		if ( GetItemData( %Item, 2 ) == 20 )
//		{
//			%WuHunID[ 0 ] = %Item;
//			%WuHunNum[ 0 ] = %Num;
//		}
//		else
//		{
//			%index = %Player.PutItem( %Item, %Num );
//			%Player.SetPutItemProperty( %index, 1, %Player.GetPlayerID( ) );
//		}
//	}
//}
////ѡ������ߵĴ������
//if ( %Type == 3 )
//{
//	%Item_Num_Add = $Item_Bao[ %ItemID, %Param + 1 ];
//
//	%Item = GetWord( %Item_Num_Add, 0 );
//	%Num  = GetWord( %Item_Num_Add, 1 );
//
//	if ( ( %Item !$= "" )&&( %Num !$= "" ) )
//	{
//		%index = %Player.PutItem( %Item, %Num );
//		%Player.SetPutItemProperty( %index, 1, %Player.GetPlayerID( ) );
//	}
//	else
//	{
//		%index = %Player.PutItem( %Item, %Num );
//		%Player.SetPutItemProperty( %index, 1, %Player.GetPlayerID( ) );
//	}
//}
////�������������ߵĴ������
//if ( %Type == 4 )
//{
//	%Why = GetWord( %Item_Num_All, 2 );		//�������
//
//	//ʥ�ء��Ա������ж�
//	if ( %Why == 1 )
//	{
//		%ListNum = %Player.GetFamily( );
//		%ListSex = %Player.GetSex( );
//		%Item_Num_Add = $Item_Bao[ %ItemID, %ListNum, %ListSex ];
//	}
//
//	//�ȼ������ж�
//	if ( %Why == 2 )
//	{
//		%ListNum = %Player.GetLevel( );
//		%Item_Num_Add = $Item_Bao[ %ItemID, %ListNum ];
//	}
//
//	//�ŷ������ж�
//	if ( %Why == 3 )
//	{
//		%ListNum = %Player.GetFamily( );
//		%Item_Num_Add = $Item_Bao[ %ItemID, %ListNum ];
//	}
//
//	//ʥ�������ж�
//	if ( %Why == 4 )
//	{
//		%ListNum = %Player.GetClasses( 0 );
//		%Item_Num_Add = $Item_Bao[ %ItemID, %ListNum ];
//	}
//
//	for ( %ii = 0; %ii < 20; %ii++ )
//	{
//		%Item = GetWord( %Item_Num_Add, %ii * 2 );
//		%Num  = GetWord( %Item_Num_Add, %ii * 2 + 1 );
//
//		if ( ( %Item $= "" )&&( %Num $= "" ) )
//			break;
//		else
//		{
//			%index = %Player.PutItem( %Item, %Num );
//			%Player.SetPutItemProperty( %index, 1, %Player.GetPlayerID( ) );
//		}
//	}
//}
////���󶨱ظ�����
//if ( %Type == 6 )
//{
//	for ( %i = 0; %i < %NumAll; %i++ )
//	{
//		%Item_Num_Add = $Item_Bao[ %ItemID, %i + 1 ];
//
//		%Item = GetWord( %Item_Num_Add, 0 );
//		%Num  = GetWord( %Item_Num_Add, 1 );
//
//		if ( ( %Item $= "" )&&( %Num $= "" ) )
//			break;
//		else
//		{
//			%index = %Player.PutItem( %Item, %Num );
//		}
//	}
//}
////����ѡ�������
//if ( %Type == 7 )
//{
//	%Item_Num_Add = $Item_Bao[ %ItemID, %Param + 1 ];
//
//	%Item = GetWord( %Item_Num_Add, 0 );
//	%Num  = GetWord( %Item_Num_Add, 1 );
//
//	if ( ( %Item !$= "" )&&( %Num !$= "" ) )
//	{
//		%index = %Player.PutItem( %Item, %Num );
//	}
//	else
//	{
//		%index = %Player.PutItem( %Item, %Num );
//	}
//}
////������õ��ߴ���
//if ( %Type == 5 )
//{
//	Trigger_Bao_Fringe_Benefit( %Conv, %Player, %ItemID, %State, %Param );
//}
//else
//{
//	//�۳��������
//	%index = %Player.PutItem( %ItemID, -1 );
//	echo( "�۳��������"@%ItemID );
//	if ( %Player.AddItem( 4, %ItemID ) )
//	{
//		//�����������ʼ�
//		if ( ( %Type == 1 ) || ( %Type == 2 ) )
//		{
//			%NumAll = ( %Type == 2 )  ? 1:%NumAll;
//			for ( %i = 0; %i < %NumAll; %i++ )
//			{
//				if ( %WuHunID[ %i ] > 0 )
//				{
//					//�ʼ�����
//					%MailText = "ע���������ʼ���";
//					SptMail_Send( %Player.GetPlayerID( ), %WuHunID[ %i ], %WuHunNum[ %i ], 0, 0, "��꽱��", %MailText );
//				}
//
//			}
//		}
//	}
//}
//%Conv.SetType( 4 );	//�رնԻ�
//		}
function Trigger_Bao(%Conv,%Player,%ItemID,%State,%Param)
{
	%Conv.Reset();	//��������ѡ��
	%Conv.SetTriggerType(1);
	%Conv.SetTriggerMission(%ItemID);
	%Conv.SetType(2);
	if (%Player.GetBagEmptyCount() < 8)
	{
		SendOneScreenMessage(2,"������������ȷ��������������һ�ſ�λ��",%Player);
		%Conv.SetType(4);
		return;
	}
	if (%Player.GetCaptivateState() >= 1)
	{
		SendOneScreenMessage(2,"���ѽ��������ƣ��״̬����ʱ�޷��򿪴���� ��������Ϣ��������",%Player);
		%Conv.SetType(4);
		return;
	}
	if (%Player.GetItemCount(%ItemID) > 0)
	{
		%Item_Num_All = $Item_Bao[%ItemID];

		%NumAll = GetWord(%Item_Num_All,0);		//����ڵ�������
		%Type   = GetWord(%Item_Num_All,1);		//�������
		%TeShu = GetWord(%Item_Num_All,2) * 1;//�󶨱�ʶ�Լ����⴦��
		%Property = (%TeShu > 1) ? 0 : 1;//1 �� 0 ����
		//echo( "===========================================" );
		//echo( "%NumAll ===" @ %NumAll );
		//echo( "%Type ===" @ %Type );
		//echo( "%TeShu ===" @ %TeShu );
		//echo( "%Property ===" @ %Property );
		switch (%State)
		{
			case 0:
				%Conv.SetText(%ItemID,%ItemID);					//��ͻ��˷����������ֱ��

			default:
				switch (%type)
				{
					case 1:	//�ظ����ߵĴ������
						for (%i = 0; %i < %NumAll; %i++)
						{
							%Item = GetWord($Item_Bao[%ItemID,%i + 1],0);
							%Num  = GetWord($Item_Bao[%ItemID,%i + 1],1);

							if ((%Item !$= "")&&(%Num !$= ""))
							{
								%index[%i] = %Player.PutItem(%Item,%Num);
								if (%Property > 0)
									%Player.SetPutItemProperty(%index[%i],1,%Player.GetPlayerID());
							}
						}
					case 2://��ѡ����
						%Item_Num_Add = $Item_Bao[%ItemID,%Param + 1];

						%Item = GetWord(%Item_Num_Add,0);
						%Num  = GetWord(%Item_Num_Add,1);

						if ((%Item !$= "")&&(%Num !$= ""))
						{
							%index = %Player.PutItem(%Item,%Num);
							if (%Property > 0)
								%Player.SetPutItemProperty(%index,1,%Player.GetPlayerID());
						}
					case 3://�����һ������
						%AllRan = 0;
						for (%i = 0; %i < %NumAll; %i++)
						{
							%OneRan  = GetWord($Item_Bao[%ItemID,%i + 1],2);
							%AllRan = %AllRan + %OneRan;
						}
						%Ran = GetRandom(1,%AllRan);
						%AllRan = 0;
						for (%i = 0; %i < %NumAll; %i++)
						{
							%OneRan  = GetWord($Item_Bao[%ItemID,%i + 1],2);
							%AllRan = %AllRan + %OneRan;
							if (%AllRan >= %Ran &&  %OneRan > 0)
							{
								%Item = GetWord($Item_Bao[%ItemID,%i + 1],0);
								%Num  = GetWord($Item_Bao[%ItemID,%i + 1],1);
								break;
							}
						}
						if ((%Item !$= "")&&(%Num !$= ""))
						{
							%index = %Player.PutItem(%Item,%Num);
							if (%Property > 0)
								%Player.SetPutItemProperty(%index,1,%Player.GetPlayerID());
						}
					case 4://������ʾ�������֣���һ���ֵĵ���ȫ������ ��Ŵ�1��ʼ ,�ڶ����ֵĵ���ʹ������ķ�ʽ���裨ֻ��1���� ��Ŵ�101��ʼ
						%AllRan = 0;
						for (%i = 0; %i < %NumAll; %i++)
						{
							%Item = GetWord($Item_Bao[%ItemID,%i + 1],0);
							%Num  = GetWord($Item_Bao[%ItemID,%i + 1],1);

							if ((%Item !$= "")&&(%Num !$= ""))
							{
								%index[%i] = %Player.PutItem(%Item,%Num);
								if (%Property > 0)
									%Player.SetPutItemProperty(%index[%i],1,%Player.GetPlayerID());
							}

							%OneRan  = GetWord($Item_Bao[%ItemID,%i + 101],2);
							%AllRan = %AllRan + %OneRan;
						}

						%Ran = GetRandom(1,%AllRan);
						%AllRan = 0;
						%Item = "";
						%Num = "";
						for (%i = 0; %i < %NumAll; %i++)
						{
							if ($Item_Bao[%ItemID,%i + 101] $= "")
								break;
							%OneRan  = GetWord($Item_Bao[%ItemID,%i + 101],2);
							%AllRan = %AllRan + %OneRan;
							if (%AllRan >= %Ran &&  %OneRan > 0)
							{
								%Item = GetWord($Item_Bao[%ItemID,%i + 101],0);
								%Num  = GetWord($Item_Bao[%ItemID,%i + 101],1);
								break;
							}
						}
						if ((%Item !$= "")&&(%Num !$= ""))
						{
							%index = %Player.PutItem(%Item,%Num);
							if (%Property > 0)
								%Player.SetPutItemProperty(%index,1,%Player.GetPlayerID());
						}

					case 5://������ʾ�������֣���һ���ֵĵ���ȫ������ ��Ŵ�1��ʼ ,�ڶ����ֵĵ���ʹ������ķ�ʽ���裨ÿ����Ʒ������� 0 ֻ��ʾ����� 10000�ظ��� ��Ŵ�101��ʼ
						for (%i = 0; %i < %NumAll; %i++)
						{
							%Item = GetWord($Item_Bao[%ItemID,%i + 1],0);
							%Num  = GetWord($Item_Bao[%ItemID,%i + 1],1);

							if ((%Item !$= "")&&(%Num !$= ""))
							{
								%index[%i] = %Player.PutItem(%Item,%Num);
								//echo( "%Item==AAA=" @ %Item @ "     %Num====" @ %Num );
								if (%Property > 0)
									%Player.SetPutItemProperty(%index[%i],1,%Player.GetPlayerID());
							}

							%OneRan  = GetWord($Item_Bao[%ItemID,%i + 101],2);
							%Ran = GetRandom(1,10000);
							if (%Ran <= %OneRan && %OneRan > 0)
							{
								%Item = GetWord($Item_Bao[%ItemID,%i + 101],0);
								%Num  = GetWord($Item_Bao[%ItemID,%i + 101],1);
								//echo( "%Item==VVV=" @ %Item @ "     %Num====" @ %Num );
								if ((%Item !$= "")&&(%Num !$= ""))
								{
									%index = %Player.PutItem(%Item,%Num);
									if (%Property > 0)
										%Player.SetPutItemProperty(%index,1,%Player.GetPlayerID());
								}
							}
						}
					case 6://���⴦���������������桢�Ƿ���ݵȼ��������ʵ�
						%AllRan = 0;
						for (%i = 0; %i < %NumAll; %i++)
						{
							%Item = GetWord($Item_Bao[%ItemID,%i + 1],0);
							%Num  = GetWord($Item_Bao[%ItemID,%i + 1],1);
							%Msg = GetWord($Item_Bao[%ItemID,%i + 1],2);
							%LvSpc = GetWord($Item_Bao[%ItemID,%i + 1],3);
							if (%LvSpc $= "LvSp1")
								%Item = GetNewItemIDForLevel(%Player,%Item);

							if ((%Item !$= "")&&(%Num !$= ""))
							{
								%index[%i] = %Player.PutItem(%Item,%Num);
								if (%Msg !$= "M0")
									SendGiftServerMsg(%Player,%ItemID,%Item,%Num,%Msg);
								if (%Property > 0)
									%Player.SetPutItemProperty(%index[%i],1,%Player.GetPlayerID());
							}
							//echo( "�ظ�����=========" @ %Item );
							%OneRan  = GetWord($Item_Bao[%ItemID,%i + 101],4);
							%AllRan = %AllRan + %OneRan;
						}

						%Ran = GetRandom(1,%AllRan);
						%AllRan = 0;
						%Item = "";
						%Num = "";
						for (%i = 0; %i < %NumAll; %i++)
						{
							if ($Item_Bao[%ItemID,%i + 101] $= "")
								break;
							%OneRan  = GetWord($Item_Bao[%ItemID,%i + 101],4);
							%AllRan = %AllRan + %OneRan;
							if (%AllRan >= %Ran &&  %OneRan > 0)
							{
								%Item = GetWord($Item_Bao[%ItemID,%i + 101],0);
								%Num  = GetWord($Item_Bao[%ItemID,%i + 101],1);
								%Msg = GetWord($Item_Bao[%ItemID,%i + 101],2);
								%LvSpc = GetWord($Item_Bao[%ItemID,%i + 101],3);
								//echo( "�������==A=======" @ %Item );
								if (%LvSpc $= "LvSp1")
									%Item = GetNewItemIDForLevel(%Player,%Item);
								break;
							}
						}
						//echo( "�������==B=======" @ %Item );
						if ((%Item !$= "")&&(%Num !$= ""))
						{
							if (%Msg !$= "M0")
								SendGiftServerMsg(%Player,%ItemID,%Item,%Num,%Msg);
							%index = %Player.PutItem(%Item,%Num);
							if (%Property > 0)
								%Player.SetPutItemProperty(%index,1,%Player.GetPlayerID());
						}

						%OneRan = 0;
						for (%i = 0; %i < %NumAll; %i++)
						{
							%OneRan  = GetWord($Item_Bao[%ItemID,%i + 1001],4);
							%Ran = GetRandom(1,10000);
							if (%Ran <= %OneRan && %OneRan > 0)
							{
								%Item = GetWord($Item_Bao[%ItemID,%i + 1001],0);
								//echo( "ȫ���==A=======" @ %Item );
								%Num  = GetWord($Item_Bao[%ItemID,%i + 1001],1);
								%Msg = GetWord($Item_Bao[%ItemID,%i + 1001],2);
								%LvSpc = GetWord($Item_Bao[%ItemID,%i + 1001],3);
								if (%LvSpc $= "LvSp1")
									%Item = GetNewItemIDForLevel(%Player,%Item);
								//echo( "ȫ���==B=======" @ %Item );
								if ((%Item !$= "")&&(%Num !$= ""))
								{
									if (%Msg !$= "M0")
										SendGiftServerMsg(%Player,%ItemID,%Item,%Num,%Msg);
									%index = %Player.PutItem(%Item,%Num);
									if (%Property > 0)
										%Player.SetPutItemProperty(%index,1,%Player.GetPlayerID());
								}
							}
						}
				}
				%Player.putitem(%ItemID,-1);
				if (%Player.additem(1,%ItemID))
				{
					if (%TeShu == 1 || %TeShu == 3)//���������⴦��
						Trigger_Bao_Fringe_Benefit(%Conv,%Player,%ItemID,%State,%Param);
					%Conv.SetType(4);	//�رնԻ�
				}
		}
	}
	else
		%Conv.SetText(7);		//��Ʒ���ݴ���

	%Conv.Send(%Player);
}

function Trigger_BaoSpecial(%Conv,%Player,%ItemID,%State,%Param)
{
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"������������ȷ��������������1����λ��",%Player);
		%Conv.Settype(4);
		return;
	}
	if (%Player.GetCaptivateState() >= 1)
	{
		SendOneScreenMessage(2,"���ѽ��������ƣ��״̬����ʱ�޷��򿪴���� ��������Ϣ��������",%Player);
		%Conv.Settype(4);
		return;
	}
	%GetItemID = GetItemData(%ItemID,$Item_Data_PresID);
	%GetItemCount = GetItemData(%ItemID,22);
	//echo( "%ItemID====" @ %ItemID @ "  %GetItemID====" @ %GetItemID @ "   %GetItemCount==" @ %GetItemCount );
	if (%GetItemID > 0 && %GetItemCount > 0)
	{
		%Player.PutItem(%ItemID,-1);
		%Player.PutItem(%GetItemID,%GetItemCount);
		%Player.AddItem(1,%ItemID);
	}
}
//�������������������������ϵĵ��ߴ����ű���������������������������������������

//��������������������������������⽱������������������������������������������
function Trigger_Bao_Fringe_Benefit(%Conv,%Player,%ItemID,%State,%Param)
{
	//echo( " ����������⽱��===" @  %ItemID );
	%Item_Num_All = $Item_Bao[%ItemID];

	%NumAll = GetWord(%Item_Num_All,0);		//����ڵ�������
	%Type   = GetWord(%Item_Num_All,1);		//�������
	switch (%ItemID)
	{
		case 105180030:
			%Exp = $Monster_Exp[%Player.GetLevel(),1] * 500;
			AllAddExp(%Player,%Exp);
		case 105180031:
			%Exp = $Monster_Exp[%Player.GetLevel(),1] * 1000;
			AllAddExp(%Player,%Exp);
		case 105180032:
			%Exp = $Monster_Exp[%Player.GetLevel(),1] * 1000;
			AllAddExp(%Player,%Exp);
		case 105180033:
			%Exp = $Monster_Exp[%Player.GetLevel(),1] * 2000;
			AllAddExp(%Player,%Exp);
		case 105180035:
			%Exp = $Monster_Exp[%Player.GetLevel(),1] * 500;
			AllAddExp(%Player,%Exp);
		case 105180036:
			%Exp = $Monster_Exp[%Player.GetLevel(),1] * 1000;
			AllAddExp(%Player,%Exp);
		case 105180037:
			%Exp = $Monster_Exp[%Player.GetLevel(),1] * 1000;
			AllAddExp(%Player,%Exp);
		case 105180038:
			%Exp = $Monster_Exp[%Player.GetLevel(),1] * 2000;
			AllAddExp(%Player,%Exp);
	}
}
//��������������������������������⽱������������������������������������������


//�������������������������سǺʹ�����ص��ߡ�����������������������
function Trigger_113010052(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)//	�سǾ�
{
	%Result = CanTransportobject(%Player,6);
	if (!CanTransportobject(%Player,6))
		return;
	%Player.PutItem(%Type,-1);
	if (%Player.Additem(1,%type))
	{
		%Triggerid = %Player.GetTriggerid();
		%MapID = GetTriggerData(%Triggerid,6);
		%Pos = GetTriggerData(%Triggerid,7);

		%PkValue = %player.getPkValue();
		if (%PkValue >= 6)
		{
			%Triggerid = 811190109;
			%MapID = 1119;
			%Pos = "216.663 203.919 101.452";
		}

		%Player.TransportObject(0,%MapID,getword(%Pos,0),getword(%Pos,1),getword(%Pos,2));
	}
}
function Trigger_113010152(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)//	�سǾ�( ��Ʒ )
{
	if (!CanTransportobject(%Player,6))
		return;
	%Player.PutItem(%Type,-1);
	if (%Player.Additem(1,%type))
	{
		%Triggerid = %Player.GetTriggerid();
		%MapID = GetTriggerData(%Triggerid,6);
		%Pos = GetTriggerData(%Triggerid,7);

		%PkValue = %player.getPkValue();
		if (%PkValue >= 6)
		{
			%Triggerid = 811190109;
			%MapID = 1119;
			%Pos = "216.663 203.919 101.452";
		}

		%Player.TransportObject(0,%MapID,getword(%Pos,0),getword(%Pos,1),getword(%Pos,2));
	}
}
function Trigger_113010001(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1010); }//�����سǾ�
function Trigger_113010002(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1001); }//���ػسǾ�
function Trigger_113010003(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1101); }//���ɹȻسǾ�
function Trigger_113010004(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1102); }//��ɽѩ���سǾ�
function Trigger_113010005(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1103); }//������سǾ�
function Trigger_113010101(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1010); }//�����سǾ�( ��Ʒ )
function Trigger_113010102(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1001); }//���ػسǾ�( ��Ʒ )
function Trigger_113010103(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1101); }//���ɹȻسǾ�( ��Ʒ )
function Trigger_113010501(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1010); }//�����سǾ�
function Trigger_113010502(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1001); }//���ػسǾ�
function Trigger_113010503(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1101); }//���ɹȻسǾ�
function Trigger_113010504(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1102); }//��ɽѩ���سǾ�
function Trigger_113010505(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1103); }//������سǾ�

//�жϻسǾ����ʹ�������Ƿ�����
function ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%TarGetMapId)
{
	// %TypeΪ��Ʒid  %XyzΪ����
	//echo("�жϻسǾ����ʹ�������Ƿ�����  " @ %Type);
	if (%Player.GetItemCount(%Type)<1)
		return;

	if (!CanTransportobject(%Player,6))
		return;
	%MapID = GetZoneID();
	%Player.PutItem(%type,-1);
	if (%Player.Additem(1,%type))
	{
		if (%MapID <= 1300)
			ItemTransBackHome_TransPortObject(%Player,%TarGetMapId);
		else
			ServerOnSptAction(%Player.GetPlayerID(),%TarGetMapId,21);//ͨѶ�ͻ���
	}

}
function ItemTransBackHome_TransPortObject(%Player,%TarGetMapId)
{
	%Triggerid = "8" @ %TarGetMapId @ "0100";
	%Pos = $Transport_Xyz[%Triggerid];

	%PkValue = %player.getPkValue();
	if (%PkValue >= 6)
	{
		%Triggerid = 811190109;
		%TarGetMapId = 1119;
		%Pos = "216.663 203.919 101.452";
	}

	%Player.TransportObject(0,%TarGetMapId,getword(%Pos,0),getword(%Pos,1),getword(%Pos,2));
}
function Trigger_113010151(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ RandomItemTrans_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }	  //������ᣨ��Ʒ��
function Trigger_113010051(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ RandomItemTrans_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }	  //�������
function Trigger_113010551(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ RandomItemTrans_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }	  //�������
//�ж��漴���ʹ�������Ƿ�����
function RandomItemTrans_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	if (%Player.GetItemCount(%Type)<1)
		return;
	if (!CanTransportobject(%Player,7))
		return;
	%MapID = GetSubStr(GetZoneID(),0,4);
	%TriggerID = %Player.GetTriggerid();
	%Position = %Player.GetPosition();
	%Player.PutItem(%Type,-1);
	if (%Player.AddItem(1,%Type))
	{
		if ($strMapRanPosRecordMax[%MapID] $= "" || $strMapRanPosRecordMax[%MapID] == 0)
		{
			%Pos = GetNavPos(getword(%Position,0),getword(%Position,1),200);
			//echo( "%Pos====" @ %Pos );
			if (%Pos !$= "0 0 0" && %Pos !$= "")
				%Player.TransportObject(0,0,getword(%Pos,0),getword(%Pos,1),getword(%Pos,2));
			else
			{
				%Pos = $Transport_Xyz[%MapID];
				if (%Pos !$= "")
					%Player.TransportObject(0,0,getword(%Pos,0),getword(%Pos,1),getword(%Pos,2));
			}
		}
		else
		{
			%Ran =GetRanDom(1,$strMapRanPosRecordMax[%MapID]);
			%Pos = $strMapRanPosRecord[%MapID,%Ran];
			%Player.TransportObject(0,0,getword(%Pos,0),getword(%Pos,1),getword(%Pos,2));
		}
	}
}


function Trigger_113020001(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ GoToTeamMaster(%Player); }  //���Ϸ�
function Trigger_113020002(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ GoToTeamMaster(%Player); }  //���Ϸ�����Ʒ��
function Trigger_113020011(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ CallBackTeamPlayer(%Player); }	  //�ٻ���
function Trigger_113020012(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ CallBackTeamPlayer(%Player); }	  //�ٻ�������Ʒ��

//113070001	���ͷ�
//113070002	���ͷ�
//113070003	���ͷ�
//113070004	���ͷ�
//113070051	���ͷ�
//113070052	����������
//113070053	���ͷ�
//113070054	����������
//113070055	���ͷ�( ���� )

//113070055	���綨λ������ӣ�
function Trigger_113070055(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	//���û�м�¼������

	if (%Player.isHavePoint(%XYZ) == 0)
	{
		//����ڸ����ڣ����޷�ʹ�ö�λ��
		if (GetSubStr(GetZoneID(),0,2) $= "13")
			SendOneScreenMessage(2,"�������޷�ʹ�ö�λ��",%Player);

		else if ((GetZoneID() == 1401)||(GetZoneID() == 1127)||(GetZoneID() == 1136))
			SendOneScreenMessage(2,"�˵�ͼ�޷�ʹ�ö�λ����¼����",%Player);
		else
		{
			%Player.SetPositionPoint(%XYZ);
			SendOneScreenMessage(1,"����¼�˵�ǰ������",%Player);

			%MapID = %Player.GetPositionPoint(%XYZ,0);
			%X = %Player.GetPositionPoint(%XYZ,1);
			%Y = %Player.GetPositionPoint(%XYZ,2);
			%Z = %Player.GetPositionPoint(%XYZ,3);
		}
	}
	else
	{
		%PlayerID = %Player.GetPlayerID();
		if (SvrIsMyselfCaption(%PlayerID))//�Ƿ�Ϊ�ӳ�
		{
			if ((%Player.IsSchBuff(20023016) == 0)&&(%Player.IsSchBuff(20023017) == 0))
			{
				if (!%Player.IsAcceptedMission(20023))
				{
					//��ȡ������ָ��λ�õĵ�������
					%MapID = %Player.GetPositionPoint(%XYZ,0);
					%X = %Player.GetPositionPoint(%XYZ,1) / 100;
					%Y = %Player.GetPositionPoint(%XYZ,2) / 100;
					%Z = %Player.GetPositionPoint(%XYZ,3) / 100;

					//�ж�ĳ��Ʒ�Ƿ�������ʹ�ô���
					if (%Player.IsItemUsedTimes(113070055,%XYZ) > 0)
					{
						if (%Player.GetItemUsedTimes(113070055,%XYZ) > 0)
						{
							if (%Player.GetInteractionState() > 0)
							{
								SendWhyMsg(%Player,"H",0,1);
								return;
							}
							else if (%Player.isInMultiMount() != 0)
							{
								SendOneScreenMessage(2,"����������޷�ʹ�ö�λ��",%Player);
							}
							else
							{
								%Player.SetItemUsedTimes(113070055,%XYZ,%Player.GetItemUsedTimes(113070055,%XYZ) - 1);
								Schedule(1000,0,"ZuDuiDinWeiFuGoTo",%Player,%MapID,%X,%Y,%Z);
							}
						}
						else if (%Player.GetItemUsedTimes(113070055,%XYZ) == 0)
							SendOneScreenMessage(2,"��λ���Ĵ����Ѿ�Ϊ0���޷���ʹ��",%Player);
					}
				}
				else
				{
					SendOneScreenMessage(2,"ӵ��������������ʱ������ʹ�ö�λ��",%Player);
				}
			}
			else
			{
				SendOneScreenMessage(2,"�������޷�ʹ�ö�λ��",%Player);
			}
		}
		else
		{
			SendOneScreenMessage(2,"ֻ�жӳ��ſ�ʹ�ö�λ��",%Player);
		}
	}
}

//113070053	���綨λ��
function Trigger_113070053(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	//���û�м�¼������
	if (%Player.isHavePoint(%XYZ) == 0)
	{
		//����ڸ����ڣ����޷�ʹ�ö�λ��
		if (GetSubStr(GetZoneID(),0,2) $= "13")
			SendOneScreenMessage(2,"�������޷�ʹ�ö�λ��",%Player);

		else if ((GetZoneID() == 1401)||(GetZoneID() == 1127)||(GetZoneID() == 1136))
			SendOneScreenMessage(2,"�˵�ͼ�޷�ʹ�ö�λ����¼����",%Player);

		else
		{
			%Player.SetPositionPoint(%XYZ);
			SendOneScreenMessage(1,"����¼�˵�ǰ������",%Player);

			%MapID = %Player.GetPositionPoint(%XYZ,0);
			%X = %Player.GetPositionPoint(%XYZ,1);
			%Y = %Player.GetPositionPoint(%XYZ,2);
			%Z = %Player.GetPositionPoint(%XYZ,3);
		}
	}
	else
	{
		if ((%Player.IsSchBuff(20023016) == 0)&&(%Player.IsSchBuff(20023017) == 0))
		{
			if (!%Player.IsAcceptedMission(20023))
			{
				//��ȡ������ָ��λ�õĵ�������
				%MapID = %Player.GetPositionPoint(%XYZ,0);
				%X = %Player.GetPositionPoint(%XYZ,1) / 100;
				%Y = %Player.GetPositionPoint(%XYZ,2) / 100;
				%Z = %Player.GetPositionPoint(%XYZ,3) / 100;

				//�ж�ĳ��Ʒ�Ƿ�������ʹ�ô���
				if (%Player.IsItemUsedTimes(113070053,%XYZ) > 0)
				{
					if (%Player.GetItemUsedTimes(113070053,%XYZ) > 0)
					{
						if (%Player.GetInteractionState() > 0)
						{
							SendWhyMsg(%Player,"H",0,1);
							return;
						}
						else
						{
							%Player.SetItemUsedTimes(113070053,%XYZ,%Player.GetItemUsedTimes(113070053,%XYZ) - 1);
							Schedule(1000,0,"DinWeiFuGoTo",%Player,%MapID,%X,%Y,%Z);
						}
					}

					else if (%Player.GetItemUsedTimes(113070053,%XYZ) == 0)
						SendOneScreenMessage(2,"��λ���Ĵ����Ѿ�Ϊ0���޷���ʹ��",%Player);
				}
			}
			else
			{
				SendOneScreenMessage(2,"ӵ��������������ʱ������ʹ�ö�λ��",%Player);
			}
		}
		else
		{
			SendOneScreenMessage(2,"�������޷�ʹ�ö�λ��",%Player);
		}
	}
}

//113070051	��λ��
function Trigger_113070051(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	//���û�м�¼������
	if (%Player.isHavePoint(%XYZ) == 0)
	{
		//����ڸ����ڣ����޷�ʹ�ö�λ��
		if (GetSubStr(GetZoneID(),0,2) $= "13")//������ͼ�޷�ʹ��
			SendOneScreenMessage(2,"�������޷�ʹ�ö�λ��",%Player);

		else if (GetSubStr(GetZoneID(),0,2) !$= "10")//����10��ͷ�ĵ�ͼ����ʹ��
			SendOneScreenMessage(2,"�õ�ͼ�޷�ʹ�ö�λ����¼����",%Player);

		else
		{
			%Player.SetPositionPoint(%XYZ);
			SendOneScreenMessage(1,"����¼�˵�ǰ������",%Player);
			%MapID = %Player.GetPositionPoint(%XYZ,0);

			%X = %Player.GetPositionPoint(%XYZ,1);
			%Y = %Player.GetPositionPoint(%XYZ,2);
			%Z = %Player.GetPositionPoint(%XYZ,3);
		}
	}
	else
	{
		if ((%Player.IsSchBuff(20023016) == 0)&&(%Player.IsSchBuff(20023017) == 0))
		{
			if (!%Player.IsAcceptedMission(20023))
			{
				//��ȡ������ָ��λ�õĵ�������
				%MapID = %Player.GetPositionPoint(%XYZ,0);
				%X = %Player.GetPositionPoint(%XYZ,1) / 100;
				%Y = %Player.GetPositionPoint(%XYZ,2) / 100;
				%Z = %Player.GetPositionPoint(%XYZ,3) / 100;

				//��ȡ���ߴ���
				if (%Player.IsItemUsedTimes(113070051,%XYZ) > 0)
				{
					if (%Player.GetItemUsedTimes(113070051,%XYZ) > 0)
					{
						if (%Player.GetInteractionState() > 0)
						{
							SendWhyMsg(%Player,"H",0,1);
							return;
						}
						else
						{
							%Player.SetItemUsedTimes(113070051,%XYZ,%Player.GetItemUsedTimes(113070051,%XYZ) - 1);
							Schedule(1000,0,"DinWeiFuGoTo",%Player,%MapID,%X,%Y,%Z);
						}
					}

					else if (%Player.GetItemUsedTimes(113070051,%XYZ) == 0)
						SendOneScreenMessage(2,"��λ���Ĵ����Ѿ�Ϊ0���޷���ʹ��",%Player);
				}
			}
			else
			{
				SendOneScreenMessage(2,"ӵ��������������ʱ������ʹ�ö�λ��",%Player);
			}
		}
		else
		{
			SendOneScreenMessage(2,"�������޷�ʹ�ö�λ��",%Player);
		}
	}
}

function ZuDuiDinWeiFuGoTo(%Player,%Map,%X,%Y,%Z)
{
	%MapID = GetSubStr(%Map,1,4);//��õ�ͼID
	%PlayerID = %Player.GetPlayerID();//������ID

	if (!SvrIsMyselfHasTeam(%PlayerID))//û����
		%Player.TransportObject(0,%MapID,%X,%Y,%Z);
	else
	{
		%TeamList = SvrGetTeammate(%PlayerID,15);//�����б�

		for (%i = 0; %i < GetWordCount(%TeamList); %i++)
		{
			%Teammate = GetWord(%TeamList,%i);
			if (!IsPlayer(%Teammate))//���ڸ����Ļ����ټ���
				continue;

			if (%Teammate.GetInteractionState() > 0)
			{
				SendWhyMsg(%Teammate,"H",0,1);
				return;
			}
			else if (%Teammate.isInMultiMount() != 0)
			{
				SendOneScreenMessage(2,"����������޷�ʹ�ö�λ��",%Teammate);
			}
			else
			{
				%Teammate.TransportObject(0,%MapID,%X,%Y,%Z);
			}
		}
	}
}
//�������������������������سǺʹ�����ص��ߡ�����������������������





function Trigger_105109350(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020103,200); }//һ����Ѫ��( 3 )			3����Ѫ��
function Trigger_105109351(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020104,200); }//һ����Ѫ��( 4 )		   4����Ѫ��
function Trigger_105109352(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020105,200); }//һ����Ѫ��( 5 )		   5����Ѫ��
function Trigger_105109353(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020106,200); }//һ����Ѫ��( 6 )		   6����Ѫ��
function Trigger_105109354(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020107,200); }//һ����Ѫ��( 7 )		   7����Ѫ��
function Trigger_105109355(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020108,200); }//һ����Ѫ��( 8 )		   8����Ѫ��
function Trigger_105109356(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020109,200); }//һ����Ѫ��( 9 )		   9����Ѫ��
function Trigger_105109360(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020153,200); }//һ������ɢ( 3 )		   3������ɢ
function Trigger_105109361(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020154,200); }//һ������ɢ( 4 )		   4������ɢ
function Trigger_105109362(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020155,200); }//һ������ɢ( 5 )		   5������ɢ
function Trigger_105109363(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020156,200); }//һ������ɢ( 6 )		   6������ɢ
function Trigger_105109364(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020157,200); }//һ������ɢ( 7 )		   7������ɢ
function Trigger_105109365(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020158,200); }//һ������ɢ( 8 )		   8������ɢ
function Trigger_105109366(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020159,200); }//һ������ɢ( 9 )		   9������ɢ
function Trigger_105109370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020303,200); }//һ����Ѫ����Ʒ( 3 )		 3����Ѫ��( ��Ʒ )
function Trigger_105109371(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020304,200); }//һ����Ѫ����Ʒ( 4 )		 4����Ѫ��( ��Ʒ )
function Trigger_105109372(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020305,200); }//һ����Ѫ����Ʒ( 5 )		 5����Ѫ��( ��Ʒ )
function Trigger_105109373(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020306,200); }//һ����Ѫ����Ʒ( 6 )		 6����Ѫ��( ��Ʒ )
function Trigger_105109374(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020307,200); }//һ����Ѫ����Ʒ( 7 )		 7����Ѫ��( ��Ʒ )
function Trigger_105109375(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020308,200); }//һ����Ѫ����Ʒ( 8 )		 8����Ѫ��( ��Ʒ )
function Trigger_105109376(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020309,200); }//һ����Ѫ����Ʒ( 9 )		 9����Ѫ��( ��Ʒ )
function Trigger_105109380(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020353,200); }//һ������ɢ��Ʒ( 4 )		 3������ɢ( ��Ʒ )
function Trigger_105109381(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020354,200); }//һ������ɢ��Ʒ( 4 )		 4������ɢ( ��Ʒ )
function Trigger_105109382(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020355,200); }//һ������ɢ��Ʒ( 5 )		 5������ɢ( ��Ʒ )
function Trigger_105109383(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020356,200); }//һ������ɢ��Ʒ( 6 )		 6������ɢ( ��Ʒ )
function Trigger_105109384(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020357,200); }//һ������ɢ��Ʒ( 7 )		 7������ɢ( ��Ʒ )
function Trigger_105109385(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020358,200); }//һ������ɢ��Ʒ( 8 )		 8������ɢ( ��Ʒ )
function Trigger_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020359,200); }//һ������ɢ��Ʒ( 9 )		 9������ɢ( ��Ʒ )
function Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%itemid,%itemnum)
{
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"������������ȷ��������������1���λ��",%Player);
		return;
	}
	%player.putitem(%type,-1);
	%player.putitem(%itemid,%itemnum);
	%player.additem(1,%type);
}


function Trigger_105100101(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105090501,105090511,105090521,105090531,105090541); }	//����ʯ���	��ɫ
function Trigger_105100102(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105090502,105090512,105090522,105090532,105090542); }	//����ʯ���	��ɫ
function Trigger_105100103(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105090503,105090513,105090523,105090533,105090543); }	//����ʯ���	��ɫ
function Trigger_105100111(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105090601,105090611,105090621,105090631,105090641); }	//����ʯ���	��ɫ
function Trigger_105100112(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105090602,105090612,105090622,105090632,105090642); }	//����ʯ���	��ɫ
function Trigger_105100113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105090603,105090613,105090623,105090633,105090643); }	//����ʯ���	��ɫ
function Trigger_105100121(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105090701,105090711,105090721,105090731,105090741); }	//����ʯ���	��ɫ
function Trigger_105100122(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105090702,105090712,105090722,105090712,105090722); }	//����ʯ���	��ɫ
function Trigger_105100123(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105090703,105090713,105090723,105090713,105090723); }	//����ʯ���	��ɫ
function Trigger_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105109321,105109322,105109323,105109324,105109325); }	//����ʯ���
function Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%ItemA,%ItemB,%ItemC,%ItemD,%ItemF)
{
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"������������ȷ��������������1���λ��",%Player);
		return;
	}
	%Level = %Player.GetLevel();
	%Item[1] = %ItemA;
	%Item[2] = %ItemB;
	%Item[3] = %ItemC;
	%Item[4] = %ItemD;
	%Item[5] = %ItemF;
	for (%i = 5; %i >= 1; %i--)
	{
		%ItemLevel = GetItemData(%Item[%i],$Item_Data_Lv);//��õ��ߵȼ�
		if (%Level >= %ItemLevel)
		{
			%Itemid = %Item[%i];
			break;
		}
	}
	if (%Itemid == 0)
		%Itemid = %ItemA;

	%Player.PutItem(%Type,-1);
	%Player.PutItem(%Itemid,1);
	%Player.Additem(1,%Type);
}


function Trigger_105021501(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//������
function Trigger_105021502(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//������
function Trigger_105021503(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//������
function Trigger_105021504(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//������
function Trigger_105021505(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//������
function Trigger_105021506(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//������
function Trigger_105021507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//������
function Trigger_105021508(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//������
function Trigger_105021509(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//������
function Trigger_105021510(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//������
function Trigger_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//��Ч������
function Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	%curVigor = %player.getVigor();
	%maxVigor = %player.getMaxVigor();

	if (%curVigor ==  %maxVigor)
	{
		%Txt = "���Ļ�������������ʹ�û�����";
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		return;
	}
	%GiveVigor = GetItemData(%Type,17);
	%Player.PutItem(%Type,-1);
	if (%Player.Additem(1,%Type))
	{
		if (%GiveVigor > 500)
			%Player.AddVigor(%maxVigor - %curVigor);
		else
			%Player.AddVigor(%GiveVigor);
	}
}

function Trigger_105109500(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109500_105109507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105109508,105109516,105105146,105105046,105109501); }//���������LV��30��
function Trigger_105109501(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109500_105109507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105109509,105109517,105105146,105105046,105109502); }//���������LV��40��
function Trigger_105109502(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109500_105109507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105109510,105109518,105105146,105105046,105109503); }//���������LV��50��
function Trigger_105109503(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109500_105109507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105109511,105109519,105105146,105105046,105109504); }//���������LV��60��
function Trigger_105109504(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109500_105109507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105109512,105109520,105105146,105105046,105109505); }//���������LV��70��
function Trigger_105109505(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109500_105109507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105109513,105109521,105105146,105105046,105109506); }//���������LV��80��
function Trigger_105109506(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109500_105109507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105109514,105109522,105105146,105105046,105109507); }//���������LV��90��
function Trigger_105109507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109500_105109507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105109515,105109523,105105146,105105046,0); }//���������LV��100��
function Trigger_105109500_105109507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%ItemA,%ItemB,%ItemC,%ItemD,%ItemE)
{
	%Player.PutItem(%Type,-1);
	if (%ItemA > 0)%Player.PutItem(%ItemA,1);
	if (%ItemB > 0)%Player.PutItem(%ItemB,1);
	if (%ItemC > 0)%Player.PutItem(%ItemC,1);
	if (%ItemD > 0)%Player.PutItem(%ItemD,1);
	if (%ItemE > 0)%Player.PutItem(%ItemE,1);
	%Player.AddItem(1,%Type);
}
$EquipItemLv40[1,1,1] =101013004; $EquipItemLv40[1,2,1] =101013004; $EquipItemLv40[3,1,1] =101033004; $EquipItemLv40[3,2,1] =101033004; $EquipItemLv40[4,1,1] =101043004; $EquipItemLv40[4,2,1] =101043004;
$EquipItemLv40[1,1,2] =101023004; $EquipItemLv40[1,2,2] =101023004; $EquipItemLv40[3,1,2] =101023004; $EquipItemLv40[3,2,2] =101023004; $EquipItemLv40[4,1,2] =101023004; $EquipItemLv40[4,2,2] =101023004;
$EquipItemLv40[1,1,3] =102013004; $EquipItemLv40[1,2,3] =102013054; $EquipItemLv40[3,1,3] =102013204; $EquipItemLv40[3,2,3] =102013254; $EquipItemLv40[4,1,3] =102013304; $EquipItemLv40[4,2,3] =102013354;
$EquipItemLv40[1,1,4] =102023004; $EquipItemLv40[1,2,4] =102023054; $EquipItemLv40[3,1,4] =102023204; $EquipItemLv40[3,2,4] =102023254; $EquipItemLv40[4,1,4] =102023304; $EquipItemLv40[4,2,4] =102023354;
$EquipItemLv40[1,1,5] =102033004; $EquipItemLv40[1,2,5] =102033054; $EquipItemLv40[3,1,5] =102033204; $EquipItemLv40[3,2,5] =102033254; $EquipItemLv40[4,1,5] =102033304; $EquipItemLv40[4,2,5] =102033354;
$EquipItemLv40[1,1,6] =102043004; $EquipItemLv40[1,2,6] =102043054; $EquipItemLv40[3,1,6] =102043204; $EquipItemLv40[3,2,6] =102043254; $EquipItemLv40[4,1,6] =102043304; $EquipItemLv40[4,2,6] =102043354;
$EquipItemLv40[1,1,7] =102053004; $EquipItemLv40[1,2,7] =102053054; $EquipItemLv40[3,1,7] =102053204; $EquipItemLv40[3,2,7] =102053254; $EquipItemLv40[4,1,7] =102053304; $EquipItemLv40[4,2,7] =102053354;
$EquipItemLv40[1,1,8] =102063004; $EquipItemLv40[1,2,8] =102063054; $EquipItemLv40[3,1,8] =102063204; $EquipItemLv40[3,2,8] =102063254; $EquipItemLv40[4,1,8] =102063304; $EquipItemLv40[4,2,8] =102063354;
$EquipItemLv40[1,1,9] =102073004; $EquipItemLv40[1,2,9] =102073054; $EquipItemLv40[3,1,9] =102073204; $EquipItemLv40[3,2,9] =102073254; $EquipItemLv40[4,1,9] =102073304; $EquipItemLv40[4,2,9] =102073354;
$EquipItemLv40[1,1,10]=103013004; $EquipItemLv40[1,2,10]=103013004; $EquipItemLv40[3,1,10]=103013204; $EquipItemLv40[3,2,10]=103013204; $EquipItemLv40[4,1,10]=103013304; $EquipItemLv40[4,2,10]=103013304;
$EquipItemLv40[1,1,11]=103023004; $EquipItemLv40[1,2,11]=103023004; $EquipItemLv40[3,1,11]=103023204; $EquipItemLv40[3,2,11]=103023204; $EquipItemLv40[4,1,11]=103023304; $EquipItemLv40[4,2,11]=103023304;
$EquipItemLv40[1,1,12]=103033004; $EquipItemLv40[1,2,12]=103033004; $EquipItemLv40[3,1,12]=103033204; $EquipItemLv40[3,2,12]=103033204; $EquipItemLv40[4,1,12]=103033304; $EquipItemLv40[4,2,12]=103033304;

function Trigger_105109508(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109508_105109515(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,-1); }//����װ�������LV��30��
function Trigger_105109509(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109508_105109515(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,0); }//����װ�������LV��40��
function Trigger_105109510(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109508_105109515(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1); }//����װ�������LV��50��
function Trigger_105109511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109508_105109515(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2); }//����װ�������LV��60��
function Trigger_105109512(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109508_105109515(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,3); }//����װ�������LV��70��
function Trigger_105109513(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109508_105109515(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,4); }//����װ�������LV��80��
function Trigger_105109514(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109508_105109515(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,5); }//����װ�������LV��90��
function Trigger_105109515(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109508_105109515(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,6); }//����װ�������LV��100��
function Trigger_105109508_105109515(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%Num)
{
	%Classes =%Player.GetClasses(0);
	%Sex = %Player.GetSex();
	for (%i = 1; %i <=12; %i++)
	{
		%ItemId = $EquipItemLv40[%Classes,%Sex,%i] + %Num;
		%Player.PutItem(%ItemId,1);
	}
	%Player.PutItem(%Type,-1);
	%Player.AddItem(1,%Type);
}

function Trigger_105109516(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109516_105109523(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,"113050003 40","116080005 10"); }//���Ե��������LV��30��
function Trigger_105109517(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109516_105109523(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,"113050013 40","116080006 10"); }//���Ե��������LV��40��
function Trigger_105109518(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109516_105109523(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,"113050023 40","116080007 10"); }//���Ե��������LV��50��
function Trigger_105109519(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109516_105109523(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,"113050033 40","116080008 10"); }//���Ե��������LV��60��
function Trigger_105109520(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109516_105109523(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,"113050043 40","116080009 10"); }//���Ե��������LV��70��
function Trigger_105109521(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109516_105109523(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,"113050053 40","116080010 10"); }//���Ե��������LV��80��
function Trigger_105109522(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109516_105109523(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,"113050063 40","116080011 10"); }//���Ե��������LV��90��
function Trigger_105109523(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109516_105109523(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,"113050073 40","116080012 10"); }//���Ե��������LV��100��
function Trigger_105109516_105109523(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%ListA,%ListB)
{
	if (%Type == 105109516)
	{
		%Player.PutItem(116010001,100);
		%Player.PutItem(116010002,100);
		%Player.PutItem(116010003,100);
		%Player.PutItem(116010004,100);
		%Player.PutItem(113010002,100);
		%Player.PutItem(113010051,200);
		%Player.PutItem(112010058,8);
	}
	%Player.PutItem(GetWord(%ListA,0),GetWord(%ListA,1));
	%Player.PutItem(GetWord(%ListB,0),GetWord(%ListB,1));
	%Player.PutItem(%Type,-1);
	%Player.AddItem(1,%Type);
}
function Trigger_105109495(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	%Player.PutItem(%Type,-1);
	if (%Player.AddItem(1,%Type))
	{
		if ($YueGuangBaoHe_108020208 == 1)
		{
			if (GetBuildString() $= "Debug")
			{
				%Level = %Player.GetLevel();
				if (%Level < 90)
				{
					if (%Level > 85)
						%Player.Addlevel(90 - %Level);
					else
						%Player.Addlevel(5);
				}
			}
		}
	}

}
function Trigger_105105001(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ) { Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,1); }//1Ԫ���һ�ȯ
function Trigger_105105002(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,2); }//2Ԫ���һ�ȯ
function Trigger_105105003(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,3); }//3Ԫ���һ�ȯ
function Trigger_105105004(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,4); }//4Ԫ���һ�ȯ
function Trigger_105105005(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,5); }//5Ԫ���һ�ȯ
function Trigger_105105006(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,6); }//6Ԫ���һ�ȯ
function Trigger_105105007(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,7); }//7Ԫ���һ�ȯ
function Trigger_105105008(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,8); }//8Ԫ���һ�ȯ
function Trigger_105105009(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,9); }//9Ԫ���һ�ȯ
function Trigger_105105010(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,10); }//10Ԫ���һ�ȯ
function Trigger_105105011(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,20); }//20Ԫ���һ�ȯ
function Trigger_105105012(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,30); }//30Ԫ���һ�ȯ
function Trigger_105105013(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,40); }//40Ԫ���һ�ȯ
function Trigger_105105014(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,50); }//50Ԫ���һ�ȯ
function Trigger_105105015(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,60); }//60Ԫ���һ�ȯ
function Trigger_105105016(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,70); }//70Ԫ���һ�ȯ
function Trigger_105105017(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,80); }//80Ԫ���һ�ȯ
function Trigger_105105018(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,90); }//90Ԫ���һ�ȯ
function Trigger_105105019(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,100); }//100Ԫ���һ�ȯ
function Trigger_105105020(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,200); }//200Ԫ���һ�ȯ
function Trigger_105105021(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,300); }//300Ԫ���һ�ȯ
function Trigger_105105022(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,400); }//400Ԫ���һ�ȯ
function Trigger_105105023(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,500); }//500Ԫ���һ�ȯ
function Trigger_105105024(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,600); }//600Ԫ���һ�ȯ
function Trigger_105105025(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,700); }//700Ԫ���һ�ȯ
function Trigger_105105026(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,800); }//800Ԫ���һ�ȯ
function Trigger_105105027(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,900); }//900Ԫ���һ�ȯ
function Trigger_105105028(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,1000); }//1000Ԫ���һ�ȯ
function Trigger_105105029(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,2000); }//2000Ԫ���һ�ȯ
function Trigger_105105030(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,3000); }//3000Ԫ���һ�ȯ
function Trigger_105105031(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,4000); }//4000Ԫ���һ�ȯ
function Trigger_105105032(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,5000); }//5000Ԫ���һ�ȯ
function Trigger_105105033(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,6000); }//6000Ԫ���һ�ȯ
function Trigger_105105034(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,7000); }//7000Ԫ���һ�ȯ
function Trigger_105105035(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,8000); }//8000Ԫ���һ�ȯ
function Trigger_105105036(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,9000); }//9000Ԫ���һ�ȯ
function Trigger_105105037(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,10000); }//10000Ԫ���һ�ȯ
function Trigger_105105038(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,20000); }//20000Ԫ���һ�ȯ
function Trigger_105105039(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,30000); }//30000Ԫ���һ�ȯ
function Trigger_105105040(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,40000); }//40000Ԫ���һ�ȯ
function Trigger_105105041(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,50000); }//50000Ԫ���һ�ȯ
function Trigger_105105042(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,60000); }//60000Ԫ���һ�ȯ
function Trigger_105105043(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,70000); }//70000Ԫ���һ�ȯ
function Trigger_105105044(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,80000); }//80000Ԫ���һ�ȯ
function Trigger_105105045(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,90000); }//90000Ԫ���һ�ȯ
function Trigger_105105046(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,100000); }//100000Ԫ���һ�ȯ
function Trigger_105105101(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,1000); }//10���һ�ȯ
function Trigger_105105102(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,2000); }//20���һ�ȯ
function Trigger_105105103(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,3000); }//30���һ�ȯ
function Trigger_105105104(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,4000); }//40���һ�ȯ
function Trigger_105105105(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,5000); }//50���һ�ȯ
function Trigger_105105106(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,6000); }//60���һ�ȯ
function Trigger_105105107(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,7000); }//70���һ�ȯ
function Trigger_105105108(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,8000); }//80���һ�ȯ
function Trigger_105105109(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,9000); }//90���һ�ȯ
function Trigger_105105110(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,10000); }//1��Ҷһ�ȯ
function Trigger_105105111(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,20000); }//2��Ҷһ�ȯ
function Trigger_105105112(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,30000); }//3��Ҷһ�ȯ
function Trigger_105105113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,40000); }//4��Ҷһ�ȯ
function Trigger_105105114(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,50000); }//5��Ҷһ�ȯ
function Trigger_105105115(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,60000); }//6��Ҷһ�ȯ
function Trigger_105105116(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,70000); }//7��Ҷһ�ȯ
function Trigger_105105117(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,80000); }//8��Ҷһ�ȯ
function Trigger_105105118(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,90000); }//9��Ҷһ�ȯ
function Trigger_105105119(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,100000); }//10��Ҷһ�ȯ
function Trigger_105105120(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,200000); }//20��Ҷһ�ȯ
function Trigger_105105121(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,300000); }//30��Ҷһ�ȯ
function Trigger_105105122(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,400000); }//40��Ҷһ�ȯ
function Trigger_105105123(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,500000); }//50��Ҷһ�ȯ
function Trigger_105105124(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,600000); }//60��Ҷһ�ȯ
function Trigger_105105125(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,700000); }//70��Ҷһ�ȯ
function Trigger_105105126(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,800000); }//80��Ҷһ�ȯ
function Trigger_105105127(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,900000); }//90��Ҷһ�ȯ
function Trigger_105105128(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,1000000); }//100��Ҷһ�ȯ
function Trigger_105105129(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,2000000); }//200��Ҷһ�ȯ
function Trigger_105105130(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,3000000); }//300��Ҷһ�ȯ
function Trigger_105105131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,4000000); }//400��Ҷһ�ȯ
function Trigger_105105132(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,5000000); }//500��Ҷһ�ȯ
function Trigger_105105133(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,6000000); }//600��Ҷһ�ȯ
function Trigger_105105134(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,7000000); }//700��Ҷһ�ȯ
function Trigger_105105135(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,8000000); }//800��Ҷһ�ȯ
function Trigger_105105136(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,9000000); }//900��Ҷһ�ȯ
function Trigger_105105137(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,10000000); }//1000��Ҷһ�ȯ
function Trigger_105105138(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,20000000); }//2000��Ҷһ�ȯ
function Trigger_105105139(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,30000000); }//3000��Ҷһ�ȯ
function Trigger_105105140(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,40000000); }//4000��Ҷһ�ȯ
function Trigger_105105141(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,50000000); }//5000��Ҷһ�ȯ
function Trigger_105105142(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,60000000); }//6000��Ҷһ�ȯ
function Trigger_105105143(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,70000000); }//7000��Ҷһ�ȯ
function Trigger_105105144(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,80000000); }//8000��Ҷһ�ȯ
function Trigger_105105145(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,90000000); }//9000��Ҷһ�ȯ
function Trigger_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,100000000); }//10000��Ҷһ�ȯ
function Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%Moneytype,%Money)
{
	if (%Player.GetMoney(%Moneytype) + %Money >= 1900000000)
	{
		SendOneScreenMessage(2,"���Ŀ�Я����������Ѵ����ޣ��޷�ʹ�ô˶һ�ȯ",%Player);
		return;
	}
	%Player.PutItem(%Type,-1);
	if (%Player.Additem(1,%type))
		%Player.AddMoney(%Money,%Moneytype,1,%type);
}
//	ÿ��ǩ�����
function Trigger_105180020(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"��ȷ��������������һ����λ��",%Player);
		return;
	}
	%Player.PutItem(%type,-1);
	if (%Player.Additem(1,%type))
	{
		%Exp = $Monster_Exp[%Player.GetLevel(),1] * 200;
		AllAddExp(%Player,%Exp);
		if (%Player.GetItemCount(105090921) >= 1)
		{
			AllAddExp(%Player,%Exp);
			SendOneChatMessage($chatMsg_Person,"<t>��ӵ���������ƣ�������</t>" @ %Exp @ "<t>����</t>",%Player);
			%Player.PutItem(105090921,-1);
			%Player.Additem(1,%type);
		}
		%ItemID1 = GetNewItemIDForLevel(%Player,105020301);
		%ItemID2 = GetNewItemIDForLevel(%Player,105020351);
		//%ItemID3 = GetNewItemIDForLevel( %Player, 105060201 );
		%Classes = %Player.GetClasses(0);
		switch (%Classes)
		{
			case 1:%ItemID3 = 105060101;
			case 2:%ItemID3 = 105060201;
			case 3:%ItemID3 = 105060301;
			case 4:%ItemID3 = 105060401;
			case 5:%ItemID3 = 105060501;
		}
		%Player.PutItem(%ItemID1,20);
		%Player.PutItem(%ItemID2,20);
		%Player.PutItem(%ItemID3,5);
		%Player.PutItem(105090921,1);
		%Player.Additem(1,%type);
		%Player.SetSchBuff(2031);//�����Ӿ���	��������	10����			100%		����10����  ÿ10s��һ�� ����ȼ���Ӧ�ľ���*3
		%Player.SetSchBuff(2032);
	}
}
//	ÿ��ǩ�����
function Trigger_105180025(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"��ȷ��������������һ����λ��",%Player);
		return;
	}
	%Player.PutItem(%type,-1);
	if (%Player.Additem(1,%type))
	{
		%Exp = $Monster_Exp[%Player.GetLevel(),1] * 200;
		AllAddExp(%Player,%Exp);
		if (%Player.GetItemCount(105090921) >= 1)
		{
			AllAddExp(%Player,%Exp);
			SendOneChatMessage($chatMsg_Person,"<t>��ӵ���������ƣ�������</t>" @ %Exp @ "<t>����</t>",%Player);
			%Player.PutItem(105090921,-1);
			%Player.Additem(1,%type);
		}
		%ItemID1 = GetNewItemIDForLevel(%Player,105020301);
		%ItemID2 = GetNewItemIDForLevel(%Player,105020351);
		//%ItemID3 = GetNewItemIDForLevel( %Player, 105060201 );
		%Classes = %Player.GetClasses(0);
		switch (%Classes)
		{
			case 1:%ItemID3 = 105060101;
			case 2:%ItemID3 = 105060201;
			case 3:%ItemID3 = 105060301;
			case 4:%ItemID3 = 105060401;
			case 5:%ItemID3 = 105060501;
		}
		%Player.PutItem(%ItemID1,20);
		%Player.PutItem(%ItemID2,20);
		%Player.PutItem(%ItemID3,5);
		%Player.PutItem(105090921,1);
		%Player.PutItem(105106001,2);
		%Player.Additem(1,%type);
		%Player.SetSchBuff(2031);//�����Ӿ���	��������	10����			100%		����10����  ÿ10s��һ�� ����ȼ���Ӧ�ľ���*3
		%Player.SetSchBuff(2032);
	}
}

function Trigger_105105351(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,5); }//���ɹ���( 5 )	
function Trigger_105105352(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,10); }//���ɹ���( 10 )	
function Trigger_105105353(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,20); }//���ɹ���( 20 )	
function Trigger_105105354(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,30); }//���ɹ���( 30 )	
function Trigger_105105355(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,40); }//���ɹ���( 40 )	
function Trigger_105105356(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,50); }//���ɹ���( 50 )	
function Trigger_105105357(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,60); }//���ɹ���( 60 )	
function Trigger_105105358(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,70); }//���ɹ���( 70 )	
function Trigger_105105359(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,80); }//���ɹ���( 80 )	
function Trigger_105105360(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,90); }//���ɹ���( 90 )	
function Trigger_105105361(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,100); }//���ɹ���( 100 )	
function Trigger_105105362(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,200); }//���ɹ���( 200 )	
function Trigger_105105363(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,300); }//���ɹ���( 300 )	
function Trigger_105105364(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,400); }//���ɹ���( 400 )	
function Trigger_105105365(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,500); }//���ɹ���( 500 )	
function Trigger_105105366(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,600); }//���ɹ���( 600 )	
function Trigger_105105367(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,700); }//���ɹ���( 700 )	
function Trigger_105105368(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,800); }//���ɹ���( 800 )	
function Trigger_105105369(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,900); }//���ɹ���( 900 )	
function Trigger_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1000); }//���ɹ���( 1000 )
function Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%Sorce)
{
	%PlayerID = %Player.GetPlayerID();
	%orgID = SptOrg_GetOrgID(%PlayerID);
	if (%orgID <= 0)
	{
		SendOneChatMessage($chatMsg_Person,"<t>��Ҫ����һ�����ɺ�ſ�ʹ�á�</t>",%Player);
		SendOneScreenMessage(2,"��Ҫ����һ�����ɺ�ſ�ʹ��",%Player);
		return;
	}
	%Player.PutItem(%Type,-1);
	if (%Player.Additem(1,%Type))
		AddFamily_SW_GX(%Player,%Sorce,%Sorce);
}

function Trigger_105109391(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109391_105109395(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,0); }//һ��ʩ�����ϰ�
function Trigger_105109392(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109391_105109395(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1); }//����ʩ�����ϰ�
function Trigger_105109393(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109391_105109395(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2); }//����ʩ�����ϰ�
function Trigger_105109394(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109391_105109395(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,3); }//�Ľ�ʩ�����ϰ�
function Trigger_105109395(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109391_105109395(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,4); }//���ʩ�����ϰ�
function Trigger_105109391_105109395(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%AddLevel)
{
	%Classes = %Player.GetClasses(0);
	switch (%Classes)
	{
		case 1:%ItemID = 105060101;
		case 2:%ItemID = 105060201;
		case 3:%ItemID = 105060301;
		case 4:%ItemID = 105060401;
		case 5:%ItemID = 105060501;
		default:
			return;
	}
	%ItemID = %ItemID + %AddLevel;
	%Player.PutItem(%Type,-1);
	if (%Player.Additem(1,%Type))
	{
		%Player.PutItem(%ItemID,20);
		%Player.Additem(1,%Type);
	}
}
function Trigger_105090931(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105090931_105090935(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//ϴ��¼
function Trigger_105090932(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105090931_105090935(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//��������
function Trigger_105090933(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105090931_105090935(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//��������
function Trigger_105090934(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105090931_105090935(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//��������
function Trigger_105090935(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105090931_105090935(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//�������
function Trigger_105090931_105090935(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	%PkValue = %player.getPkValue();
	if (%PkValue <= 0)
	{
		SendOneScreenMessage(2,"����ǰû���ƶ�ֵ",%Player);
		return;
	}
	%Player.PutItem(%type,-1);
	if (%Player.AddItem(1,%Type))
	{
		%CanTakeNum = GetItemData(%Type,$Item_Data_PresID);
		%PkValue = %PkValue - %CanTakeNum;
		if (%PkValue < 0)
			%PkValue = 0;
		%Player.SetPkValue(%PkValue); //�����ƶ�ֵ

		%PlayerName1 = GetPlayerZiTiName(%Player,1);
		%PlayerName2 = GetPlayerZiTiName(%Player,2);
		%ItemName1 = GetItemName(%Type,1);
		%ItemName2 = GetItemName(%Type,2);
		%Number1 = $Get_Dialog_GeShi[31420] @ %CanTakeNum @ "</t>";
		%Number2 = $Get_Dialog_GeShi[60002] @ %CanTakeNum @ "</t>";
		%Text1 = "";
		%Text2 = "";//"<t></t>"
		switch (%Type)
		{
			case 105090932:
				%Text2 = %PlayerName2 @ "<t>ʹ����</t>" @ %ItemName2 @ "<t>���õ������������</t>" @ %Number2 @ "<t>���ƶ�ֵ</t>";
			case 105090933:
				%Text1 = %PlayerName1 @ "<t>ʹ����</t>" @ %ItemName1 @ "<t>���õ������������</t>" @ %Number1 @ "<t>���ƶ�ֵ��</t>";
				%Text2 = %PlayerName2 @ "<t>ʹ����</t>" @ %ItemName2 @ "<t>���õ������������</t>" @ %Number2 @ "<t>���ƶ�ֵ</t>";
			case 105090934:
				%Text1 = "<t>�����������سɷ�</t>" @ %PlayerName1 @ "<t>ʹ����</t>" @ %ItemName1 @ "<t>��������</t>" @ %Number1 @ "<t>���ƶ�ֵ��</t>";
				%Text2 = "<t>�����������سɷ�</t>" @ %PlayerName2 @ "<t>ʹ����</t>" @ %ItemName2 @ "<t>��������</t>" @ %Number2 @ "<t>���ƶ�ֵ</t>";
			case 105090935:
				%Text1 = %PlayerName1 @ "<t>ʹ����</t>" @ %ItemName1 @ "<t>������ƶ�ֵ������ϴ�ĸ��棬�������ˣ���</t>";
				%Text2 = %PlayerName2 @ "<t>ʹ����</t>" @ %ItemName2 @ "<t>������ƶ�ֵ������ϴ�ĸ��棬��������</t>";
		}
		if (%Text1 !$= "")
			SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
		if (%Text2 !$= "")
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
}
function Trigger_105104901(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1); }//1�����
function Trigger_105104902(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2); }//2�����
function Trigger_105104903(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,3); }//3�����
function Trigger_105104904(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,4); }//4�����
function Trigger_105104905(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,5); }//5�����
function Trigger_105104906(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,6); }//6�����
function Trigger_105104907(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,7); }//7�����
function Trigger_105104908(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,8); }//8�����
function Trigger_105104909(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,9); }//9�����
function Trigger_105104910(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,10); }//10�����
function Trigger_105104911(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,20); }//20�����
function Trigger_105104912(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,30); }//30�����
function Trigger_105104913(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,40); }//40�����
function Trigger_105104914(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,50); }//50�����
function Trigger_105104915(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,60); }//60�����
function Trigger_105104916(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,70); }//70�����
function Trigger_105104917(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,80); }//80�����
function Trigger_105104918(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,90); }//90�����
function Trigger_105104919(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,100); }//100�����
function Trigger_105104920(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,200); }//200�����
function Trigger_105104921(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,300); }//300�����
function Trigger_105104922(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,400); }//400�����
function Trigger_105104923(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,500); }//500�����
function Trigger_105104924(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,600); }//600�����
function Trigger_105104925(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,700); }//700�����
function Trigger_105104926(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,800); }//800�����
function Trigger_105104927(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,900); }//900�����
function Trigger_105104928(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1000); }//1000�����
function Trigger_105104929(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2000); }//2000�����
function Trigger_105104930(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,3000); }//3000�����
function Trigger_105104931(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,4000); }//4000�����
function Trigger_105104932(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,5000); }//5000�����
function Trigger_105104933(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,6000); }//6000�����
function Trigger_105104934(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,7000); }//7000�����
function Trigger_105104935(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,8000); }//8000�����
function Trigger_105104936(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,9000); }//9000�����
function Trigger_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,10000); }//10000�����
function Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%Exp)
{
	if (%Player.GetItemCount(%Type) < 1)
		return;
	%Player.PutItem(%Type,-1);
	if (%Player.Additem(%Type))
	{
		%Exp = %Exp * 10000;
		AllAddExp(%Player,%Exp);
	}
}

//������
function Trigger_105109063(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	%Player.ShowDialogOk(2000000033,33,1);
}

function Trigger_105109121(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109121_105109122(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1); }//	�۱�����ѿ�( 1�� )
function Trigger_105109122(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109121_105109122(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,5); }//	�۱�����ѿ�( 5�� )
function Trigger_105109121_105109122(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%Count)
{
	%Player.PutItem(%type,-1);
	if (%Player.AddItem(1,%type))
	{
		%Act0 = GetAct(%Player,3038,0);
		%Act1 = GetAct(%Player,3038,1);//�����Ѿ��һ�����
		%GoldUseTimes = mfloor(%Act0 /1000);//�Ѿ�ʹ��Ԫ������Ĵ��� 
		%HaveMianFeiTimes = %Act0%1000;//ʣ�������Ѵ���
		%HaveMianFeiTimes = %HaveMianFeiTimes + %Count;
		%Act0 = %GoldUseTimes * 1000 + %HaveMianFeiTimes;
		SetAct(%Player,3038,%Act0,%Act1);
		HelpDirectByIndex(%Player.GetPlayerID(),23);	//ͨѶ�ͻ���
	}
}

function Trigger_105109130(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	//�����ʻ�
{
	%Player.PutItem(%type,-1);
	if (%Player.AddItem(1,%type))
	{
		if (%Player.GetBuffCount(39023,1) >= 1)
			%Player.Removebuff(390230001);
		%Player.AddBuff(390250001,%Player,1);
		%Text = "����������ʻ���ף�����ڴ�ʱ���ڣ��������䡣";
		SendOneScreenMessage(2,%Text,%Player);
		SendOneChatMessage($chatMsg_System,%Text,%Player);
	}
}

function Trigger_106050305(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	if (%Player.IsAcceptedMission(20146))
	{
		%Text = "���ѽ�ȡ���ȱ�������������������ɲ����ٴν�ȡ��";
		SendOneScreenMessage(2,%Text,%Player);
		SendOneChatMessage($chatMsg_System,%Text,%Player);
		return;
	}
	%Player.Putitem(%type,-1);
	if (%Player.Additem(1,%type))
	{
		AddMissionAccepted(%Player,0,20146);
	}
}


function Trigger_105090911(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)//����ͨ����Ʒ
{
	%Count = %Player.GetItemCount(%Type);
	%Level =%Player.GetLevel();
	if (%Level < 75)
	{
		%Text = "����ﵽ75��֮�󣬲ſ���ʹ�ô���";
		SendOneScreenMessage(2,%Text,%Player);
		SendOneChatMessage($chatMsg_System,%Text,%Player);
		return;
	}
	%Player.Putitem(%Type,-%Count);
	if (%Player.Additem(1,%type))
	{
		%Player.Putitem(105090901,%Count);
		%Player.Additem(1,%type);
	}
}
function Trigger_105281001(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)//��ͯʹ��
{
	if (%Player.sptIsDesignationExist(1401))
	{
		%Text = "���Ѿ���ô˳ƺ�";
		SendOneScreenMessage(2,%Text,%Player);
		SendOneChatMessage($chatMsg_System,%Text,%Player);
		return;
	}
	%Player.PutItem(%type,-1);
	if (%Player.additem(1,%type))
		%Player.AddDesignation(1401);//��ӳƺ�
}

function Trigger_105109081(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)//���������ӡ
{
	%Player.PutItem(%Type,-1);
	%Player.PutItem(105109083,1);
	%PLayer.Additem(1,%type);
}
function Trigger_105109082(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)//���������ӡ
{
	%Player.PutItem(%Type,-1);
	%Player.PutItem(105109084,1);
	%PLayer.Additem(1,%type);
}



function Trigger_105109531(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ){ Trigger_105109531_105109536(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ, 690742, 11); }//11��õ��
function Trigger_105109532(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ){ Trigger_105109531_105109536(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ, 690743, 99); }//99��õ��
function Trigger_105109533(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ){ Trigger_105109531_105109536(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ, 690741, 999); }//999��õ��
function Trigger_105109534(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ){ Trigger_105109531_105109536(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ, 690742, 11); }//11��õ��(��Ʒ)
function Trigger_105109535(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ){ Trigger_105109531_105109536(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ, 690743, 99); }//99��õ��(��Ʒ)
function Trigger_105109536(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ){ Trigger_105109531_105109536(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ, 690741, 999); }//999��õ��(��Ʒ)
function Trigger_105109531_105109536(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ, %Packet, %Sorce)
{
	%PlayerID = %Player.GetPlayerID();
	%Target   = %Player.Gettarget();
	%TargetID = %Target.GetPlayerID();

	if (SptGetFirendValue(%PlayerID, %TargetID) < 1)	//���Ǻ���
	{
		SendOneScreenMessage(2, "��õ�廨��ֻ�ܶԺ���ʹ�ã�", %Player);
		return;
	}

	if (%Target.getclassname() !$= "Player")	//Ŀ�겻�����
	{
		SendOneScreenMessage(2, "��õ�廨��ֻ�ܶ��������ʹ�ã�", %Player);
		return;
	}

	%TargetSex = %Target.GetSex();
	%Player.PutItem(%Type, -1);
	if (!%Player.AddItem(1, %type))
		return;


	//%Target.AddFlowerStarVal(%Cnt); //�ͻ����������¼
	
	//sptUseItemAddFriendValue(%PlayerID, %TargetID, %Sorce);	//����˫���Ѻö�
	

	AddPrestige(%Target, 4119, %Sorce);//��¼�ʻ�ֵ
	AddPrestige(%Player, 4120, %Sorce);//��¼��Ҷֵ

	if (%Packet > 0)
		%Target.AddPacket(%Packet);
		
	if (%Sorce >= 999)
	{
		%PlayerName1 = GetPlayerZiTiName(%Player, 1);
		%PlayerName2 = GetPlayerZiTiName(%Player, 2);

		%TargetName1 = GetPlayerZiTiName(%Target, 1);
		%TargetName2 = GetPlayerZiTiName(%Target, 2);

		%Count1 = $Get_Dialog_GeShi[31420] @ %Sorce @ "</t>";
		%Count2 = $Get_Dialog_GeShi[60002] @ %Sorce @ "</t>";

		%Text1 = %PlayerName1 @ "<t>�͸�</t>" @ %TargetName1 @ %Count1 @ "<t>��õ�壬�ǵöԷ��������ѡ�</t>";
		%Text2 = %PlayerName2 @ "<t>�͸�</t>" @ %TargetName2 @ %Count2 @ "<t>��õ�壬�ǵöԷ��������ѡ�</t>";

		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
	
}

//һ������ɢ����Ѫ��
function Trigger_105109342(%Conv,%Player,%X_ID,%State,%TriggerType,%TriggerID,%Param,%XYZ){Trigger_GiveDrugsByLv(%Player, %X_ID, 105020103, 200);}
function Trigger_105109343(%Conv,%Player,%X_ID,%State,%TriggerType,%TriggerID,%Param,%XYZ){Trigger_GiveDrugsByLv(%Player, %X_ID, 105020153, 200);}
function Trigger_GiveDrugsByLv(%Player, %X_ID, %Lv0ItemID, %Num)
{
	%ItemID = getItemTrueIDOrCnt(%Player, %Lv0ItemID, 0, 0);
	
	%Player.PutItem(%X_ID,-1);
	%Player.PutItem(%ItemID,%Num);
	%Player.AddItem(5, %X_ID);
}



