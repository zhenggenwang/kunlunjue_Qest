//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//�����䷽������Ʒʱ�Ĵ����ű�
//��������ж�����Ƿ�ӵ���㹻�Ĳ��ϣ�Ȼ�󴥷���������������������Ŵ������ű�
//==================================================================================
//����ǰ���ж�
//�䷽ǰ�ýű��ж���������дΪ��1��ʱ����
function ProduceCheck(%Player,%SerialId)
{
	if (%SerialId <= 0)
		return 9999;

	return 0;
}

//%Player��������
//%LivingSkillId:����ܱ�ţ������ж����ĸ������
//%Var�����صĲ�������
function getCurrentLivingSkillLevel(%Player,%LivingSkillId,%Var)
{
	return 0;
}

function ProduceAll(%Player,%PresId)
{
	//Player	��Ҷ���
	//PresId	�䷽���
	//GetPrescriptionData(%PresId,%Num);��ȡ�䷽����
	//�ж��䷽���λ��������Ϊ9λ
	if (strlen(%PresId) != 9)
		return;
	//����
	%Materials[1] = GetPrescriptionData(%PresId,$PrescriptionData_ItemID_A);
	%Materials[2] = GetPrescriptionData(%PresId,$PrescriptionData_ItemID_B);
	%Materials[3] = GetPrescriptionData(%PresId,$PrescriptionData_ItemID_C);
	%Materials[4] = GetPrescriptionData(%PresId,$PrescriptionData_ItemID_D);
	%Materials[5] = GetPrescriptionData(%PresId,$PrescriptionData_ItemID_E);
	%Materials[6] = GetPrescriptionData(%PresId,$PrescriptionData_ItemID_F);
	//����
	%Number[1] = GetPrescriptionData(%PresId,$PrescriptionData_Num_A);
	%Number[2] = GetPrescriptionData(%PresId,$PrescriptionData_Num_B);
	%Number[3] = GetPrescriptionData(%PresId,$PrescriptionData_Num_C);
	%Number[4] = GetPrescriptionData(%PresId,$PrescriptionData_Num_D);
	%Number[5] = GetPrescriptionData(%PresId,$PrescriptionData_Num_E);
	%Number[6] = GetPrescriptionData(%PresId,$PrescriptionData_Num_F);

	//��������
	%Vigor = GetPrescriptionData(%PresId,$PrescriptionData_HuoLi);
	//Ǯ
	%Money = GetPrescriptionData(%PresId,$PrescriptionData_Money);
	//echo( "%ItemId==AAAAA===" @ %ItemId );
	//����������
	%tmpSetLevelIndex = GetPrescriptionData(%PresId,$PrescriptionData_JiangLiExp);
	//��ȡ��Ҹ�Ե
	%FuYuan = %Player.GetLuck();
	//��ȡ����ܱ��
	%tmpCurrentLevelIndex = GetPrescriptionData(%PresId,$PrescriptionData_LiveSkill);

	//�ж�����Ƿ�����Щ�����Ĳ���
	for (%i = 1; %i < 7; %i++)
	{
		if (%Materials[%i] > 0 && %Number[%i] > 0)
		{
			if (%Player.GetItemCount(%Materials[%i]) < %Number[%i])
			{
				//���������������ϳ�ʧ��
				return 4103;
			}
		}
	}
	//echo( "1" );
	//�ж�����Ƿ����㹻�Ļ���
	if (%Player.GetVigor() < %Vigor)
		return 511;	//���Ļ�������
	//echo( "2" );
	//�ж�����Ƿ����㹻�ĳ�Ʊ
	if (%Player.GetMoney(2) < %Money)
		return 4105;
	//echo( "3" );
	//���ڵĵ���
	%ItemID = GetPrescriptionData(%PresId,$PrescriptionData_OutItem);
	%ItemNum = GetPrescriptionData(%PresId,$PrescriptionData_OutNum);
	//�۳����߲���
	for (%i = 1; %i < 7; %i++)
	{
		if (%Materials[%i] !$= "0" && %Number[%i] !$= "0")
		{
			%Player.PutItem(%Materials[%i],-%Number[%i]);
		}
		//DelItemFromInventory( %Player.GetPlayerID( ), %Materials[ %i ], %Number[ %i ], 9, %PresId );
	}
	if (!%Player.additem(9,%PresId))
		return 4103;
	//�۳�����ֵ
	%Player.AddVigor(-%Vigor);
	//��Ǯ
	%Player.ReduceMoney(%Money,2,5,1009);

	%itemSubType = GetItemData(%ItemId,3);//��õ�������
	//echo( "%itemSubType===" @ %itemSubType );
	if (%itemSubType > 100 && %itemSubType < 400)//�����װ��
	{
		for (%i = 0; %i < %ItemNum; %i++)
		{
			if (%itemSubType > 200 && %itemSubType < 300)
			{
				%Sex = %Player.GetSex();
				//sexϵ�� = 1-10000��� С��5000*��1+��Եֵ/1000�� ��Ϊ��ұ��Ա�ķ��� �е�+0 Ů��+50
				%RanA = GetRandom(1,10000);
				%RanB = 5000 *(1 + %FuYuan/1000);
				if (%RanA < %RanB)
				{
					switch (%Sex)
					{
						case 1:%SexNumber = 0;
						case 2:%SexNumber = 50;
					}
				}
				else
				{
					switch (%Sex)
					{
						case 1:%SexNumber = 50;
						case 2:%SexNumber = 0;
					}
				}
				%ItemId = %ItemId + %SexNumber;
			}
			//echo( "%ItemId=====" @ %ItemId );
			%Index = %Player.Putitem(%ItemId,1);
			%player.SetPutItemProduceName(%index,"�����ߣ�" @ %player.GetPlayerName());
		}
	}
	else
		%Index = %Player.Putitem(%ItemId,%ItemNum);
	//echo( "%ItemId==BBBB=" @ %ItemId );
	if (%Player.Additem(9,%PresId))
	{
		//���������
		if (%tmpSetLevelIndex > 0)
			addLivingSkillGuerdon(%Player, %tmpCurrentLevelIndex, %tmpSetLevelIndex);

		%ItemLevel = GetItemData(%ItemId, $Item_Data_Lv);//��õ��ߵȼ�
		%SkillLevel = getsubstr(%tmpCurrentLevelIndex, 7, 2) * 1;
		//echo("%ItemLevel =====" @ %ItemLevel);
		//echo("%SkillLevel =====" @ %SkillLevel);
		//��ӳɾ�	
		switch (GetSubStr(%tmpCurrentLevelIndex,0,6))
		{
			case 502011://���켼��
				SetStrategyRecord(%Player,$StrategySubBtnSrc[3,4]);//���Դ�����¼
				if (%ItemLevel >= 70)
					AddAchievementWatch(%Player, 0, 53, 1);//��¼�ɾ�
			case 503011://�÷켼��
				SetStrategyRecord(%Player,$StrategySubBtnSrc[3,5]);//���Դ�����¼
				if (%ItemLevel >= 70)
					AddAchievementWatch(%Player, 0, 55, 1);//��¼�ɾ�
			case 504011://��������
				SetStrategyRecord(%Player,$StrategySubBtnSrc[3,6]);//���Դ�����¼
				if (%ItemLevel >= 70)
					AddAchievementWatch(%Player, 0, 54, 1);//��¼�ɾ�
			case 505011://���似��
				SetStrategyRecord(%Player,$StrategySubBtnSrc[3,7]);//���Դ�����¼
				if (%SkillLevel >= 4)
					AddAchievementWatch(%Player, 0, 51, 1);//��¼�ɾ�
			case 506011://��������
				SetStrategyRecord(%Player,$StrategySubBtnSrc[3,8]);//���Դ�����¼
				if (%SkillLevel >= 4)
					AddAchievementWatch(%Player, 0, 52, 1);//��¼�ɾ�
			case 507011://��⿼���
				SetStrategyRecord(%Player,$StrategySubBtnSrc[3,9]);//���Դ�����¼
				if (%SkillLevel >= 4)
					AddAchievementWatch(%Player, 0, 50, 1);//��¼�ɾ�
		}
		return 0;	//�����ɹ�
	}
	else
		return 4103;
}
//�䷽��� $PrescriptionData_ID = 0;						//0 �䷽���				0   ====660012002
//�䷽��� $PrescriptionData_Type_A = 1;					//1 �䷽���				1   ====6
//�䷽����� $PrescriptionData_Type_B = 2;					//2 �䷽�����				2   ====504
//�䷽�ȼ� $PrescriptionData_Lv = 3;						//3 �䷽�ȼ�				3   ====100
//������� $PrescriptionData_HuoLi = 4;						//4 �������				4   ====7
//����Ҫ�� $PrescriptionData_WuXin = 5;						//5 ����Ҫ��				5   ====0
//����ܱ�� $PrescriptionData_LiveSkill = 6;				//6 ����ܱ��			6   ====507011005
//�����Ǯ $PrescriptionData_Money = 7;						//7 �����Ǯ				7   ====0
//���ĵ�������� $PrescriptionData_Item_Type = 8;			//8 ���ĵ��������			8   ====0
//���� $PrescriptionData_Help = 9;							//9  ����					9   ====��⿿ɻ��һ��:���ðײ�
//���ϱ��1 $PrescriptionData_ItemID_A = 10;				//10 ���ϱ��				10   ====109062002
//��������1 $PrescriptionData_Num_A = 11;					//11 ��������				11   ====1
//���ϱ��2 $PrescriptionData_ItemID_B = 12;				//12 ���ϱ��				12   ====106030016
//��������2 $PrescriptionData_Num_B = 13;					//13 ��������				13   ====2
//���ϱ��3 $PrescriptionData_ItemID_C = 14;				//14 ���ϱ��				14   ====106030017
//��������3 $PrescriptionData_Num_C = 15;					//15 ��������				15   ====1
//���ϱ��4 $PrescriptionData_ItemID_D = 16;				//16 ���ϱ��				16   ====106030022
//��������4 $PrescriptionData_Num_D = 17;					//17 ��������				17   ====0
//���ϱ��5 $PrescriptionData_ItemID_E = 18;				//18 ���ϱ��				18   ====0
//��������5 $PrescriptionData_Num_E = 19;					//19 ��������				19   ====0
//���ϱ��6 $PrescriptionData_ItemID_F = 20;				//20 ���ϱ��				20   ====0
//��������6 $PrescriptionData_Num_F = 21;					//21 �Ƿ���ʾ				21   ====1
//����������Ʒ��� $PrescriptionData_OutItem = 22;			//22 ����������Ʒ���		22   ====105011002
//ǰ�ýű��ж� $PrescriptionData_CanDo = 23;				//23 ǰ�ýű��ж�			23   ====0
//һ�β������� $PrescriptionData_OutNum = 24;				//24 һ�β�������			24   ====1
//�䷽���� $PrescriptionData_PresIDName = 25;				//25 �䷽����				25   ====���ðײ�
//������ʾ�ı� $PrescriptionData_Say = 26;					//26 ������ʾ�ı�			26   ====���ðײˡ������
//ѧϰ�䷽���輼�������� $PrescriptionData_Exp = 27;		//27 ѧϰ�䷽���輼��������	27   ====0
//���������� $PrescriptionData_JiangLiExp = 28;				//28 ����������			    28   ====1
