//������������������������������ѡ���ء�����������������������������������
//������������������������װ�����顿��ء�����������������������������������
//���������������������������������ء�����������������������������������
//������������������������������Ϣ����ء�����������������������������������
//��������������������������ѷ��С���ء�����������������������������������
//�������������������������ٻ����ѡ���ء�����������������������������������

//��������������������������ת�̡���ء�������������������������������������
//���������������������������ִ�ת�̡���ء���������������������������������
//������������������������ʱװ�ϳɡ���ء�����������������������������������

//������������������������ʮ����껪����ء���������������������������������
//���������������������������ս��������ء���������������������������������
//�������������������������۱��衿��ء�������������������������������������

//��������������������������������ء���������������������������������������
//����������������������������ǿ������ء�����������������������������������

//��������������������������ʯ����ء���������������������������������������

//��������������������������ɫ������ʧ����ء�������������������������������

//������������������������װ������ء���������������������������������������
//������������������������װ������������ء���������������������������������
//��������������������������������ء���������������������������������������
//�������������������������컯��ʯ�ϳɡ���ء�������������������������������
//��������������������������ֵ�������ء�����������������������������������
//���������������������������߽�������ء�����������������������������������
//����������������������������ս����ء�������������������������������������

//��������������������������ֵ��������ء�����������������������������������
//�������������������������齱�������桿��ء�������������������������������
//������������������������ȫ��ᱦ��ء���������������������������������
//�����������ڿ󡿡����������ӿ���㺯������������������
//�����������ᱦ�������������������ĵ��ߡ���������������
//�����������������������������úͻ�ȡ������������������
//������������Ե��ǩ���������������ػ���ء�����������
//������������Ը���񡿡������������ػ���ء�����������
//����������ȫ��ᱦ�������������н���������������������

//��������������������������Ȩ��������񡿡���������������������������������
//������������������������������ֵ�ͺ��񡿡���������������������������������
//�������������������������ҵ�����������������������������������������������
//������������������������������𡿡���������������������������������������
//�������������������������޹��̵꡿����������������������������������������

//mfloor(%num) ��Сȡ�� mceil(%num);���ȡ�� mround(%num)4��5��ȡ��





//������������������������������ѡ���ء�����������������������������������
function getDeityWaaponMaterial(%getDeityWaaponMaterial)
{
	return 105090421;

}
//������������������������������ѡ���ء�����������������������������������

//������������������������װ�����顿��ء�����������������������������������
//�����������
//�����������
//ϴ���������


//��װ�����顿�ɹ������
function SetFreeLockChangeTimes(%times, %Player)
{

}

//��װ��ϴ�顿��Ѵ�������
function getFreeLockClearTimes(%Player)
{
	//������ڻʱ����
	if (GetStartTime("KaiFuHuoDong") > 0)
		return 0;

	//����Ѿ���ȡ
	if (GetWord(%Player.GetActivity(2254), 1) == 0)
		return 1;

	return 0;
}

//��װ��ϴ�顿�ɹ������
function SetFreeLockClearTimes(%times, %Player)
{

}
//������������������������װ�����顿��ء�����������������������������������

//���������������������������������ء�����������������������������������
//����ʣ����Ѵ�������
function inspectVipTimer_ShenQiXiuLi(%Player)
{
	if (HasBit($ShenJiangTeQuan_Particular_bActive, 0) > 0)
	{
		//�Ƿ�ӵ�С�ξ�ٹ���VIP
		if (%Player.isVip(0) > 0)
			return 1;
	}

	return 0;
}

//�����������󴥷�
function processVipTimer_ShenQiXiuLi(%player)
{
}
//���������������������������������ء�����������������������������������


//������������������������������Ϣ����ء�����������������������������������

//������Ϣʣ����Ѵ�������
function InspectVipTimer_FreeSuperWorld(%Player)
{
	if (HasBit($ShenJiangTeQuan_Particular_bActive, 1) > 0)
	{
		//�Ƿ�ӵ�С�ξ�ٹ���VIP
		if (%Player.isVip(0) > 0)
		{
			%Surplus = 5 - GetWord(%Player.GetActivity(3002), 0);
			if (%Surplus > 0)
				return %Surplus;
		}
	}

	return 0;
}

//������Ϣ���ͺ󴥷�
function ProcessVipTimer_FreeSuperWorld(%Player)
{
	//if(HasBit($ShenJiangTeQuan_Particular_bActive, 1) > 0)
	//	{
	//	}
}
//��������������������������ѷ��С���ء�����������������������������������

//��������������������������ѷ��С���ء�����������������������������������
//VIP���ͷ��е�����������
function inspectVipTimer_FreeFlayCount(%Player)
{
	//if ( HasBit( $ShenJiangTeQuan_Particular_bActive, 2 ) > 0 )
	//{
	//	//�Ƿ�ӵ�С�ξ�ٹ���VIP
	//	if ( %Player.isVip( 0 ) > 0 )
	//		return 5;
	//}

	return 0;
}

//����VIP���͵ķ���ʱ����
function processVipTimer_FreeFlayCount(%Player)
{
	//if(HasBit($ShenJiangTeQuan_Particular_bActive, 2) > 0)
	//	{
	//	}
}
//��������������������������ѷ��С���ء�����������������������������������


//�������������������������ٻ����ѡ���ء�����������������������������������
//�����ٻ�������Ѵ���
function inspectVipTimer_ZhaoHuanDuiYou(%Player)
{
	if (HasBit($ShenJiangTeQuan_Particular_bActive, 3) > 0)
	{
		//�Ƿ�ӵ�С�ξ�ٹ���VIP
		if (%Player.isVip(0) > 0)
		{
			%Surplus = 1 - GetWord(%Player.GetActivity(3004), 0);
			if (%Surplus > 0)
				return %Surplus;
		}
	}

	return 0;
}
//�������������������������ٻ����ѡ���ء�����������������������������������

//��������������������������ת�̡���ء�������������������������������������
//ÿ��ˢ�´�ת�̴���
function setRaffleCount(%Player, %raffleCount, %afreshCount)
{
}


//�ж��Ƿ��ִ����ѳ齱(��ת��) ����:vip���������͵���Ѵ���(��ǰʣ�����) (�ͻ��� ������)
function inspectVipTimer_FreeRaffle(%Player)
{
	//�Ƿ�ӵ�С�����VIP
	if (%Player.isVip(1) > 0)
	{
		%Surplus = 1 - GetWord(%Player.GetActivity(3006), 0);
		if (%Surplus > 0)
			return %Surplus;
	}

	return 0;
}

//����vip���������͵���Ѵ���(������)
function processVipTimer_FreeRaffle(%Player)
{
}

//��ת�̻�õ���ȫ������
function SendCrazyDialMessage(%Player, %ItemID)
{
	%PlayerName = GetPlayerZiTiName(%Player, 1);
	%ItemName = GetItemName(%ItemID, 1);
	%ItemName1 = GetItemName(%ItemID, 2);
	%Txt = %PlayerName @ $Get_Dialog_GeShi[31419] @ "���Ǹ��գ��ڡ�����תתת���л��</t>" @ %ItemName @ $Get_Dialog_GeShi[31419] @ "��������ɷ���ˣ�</t>";
	SendOneLineMessage(%Txt);

	if ((%ItemID == 113050030) || (%ItemID == 113050036) || (%ItemID == 113050042) || (%ItemID == 105103116) || (%ItemID == 105103117) ||
		(%ItemID == 105103118) || (%ItemID == 105101764) || (%ItemID == 105101763) || (%ItemID == 105101765))
	{
		%Txt = $Get_Dialog_GeShi[60001] @ "��" @ %Player.GetPlayerName() @ "��</t>" @ $Get_Dialog_GeShi[60000] @ "���Ǹ��գ��ڡ�����תתת���л��</t>" @
			%ItemName1 @ $Get_Dialog_GeShi[60000] @ "��������ɷ���ˣ�</t>";
		SendOneLineMessage(%Txt, $chatMsg_Type_Normal2);
	}
}
//��������������������������ת�̡���ء�������������������������������������


//������������������������ʱװ�ϳɡ���ء�����������������������������������
//�ϳ�ʱװ���Ļ��֣�������

//�ϳ�ʱװ���ĵ��߱��
//�ϳ�ʱװ���ĵ�������

//�ϳɽ������


//�ϳ�ʱװ���Ļ��֣�������
function getComposeFashionCostMoney(%colorLevel)
{
	if (%colorLevel == 2)return 100;
	else if (%colorLevel == 3)return 300;
	else if (%colorLevel == 4)return 800;
	else if (%colorLevel == 5)return 1200;

	return 2000;
}

//�ϳ�ʱװ���ĵ��߱��
function getComposeFashionMaterialID(%colorLevel)
{
	return 105103148;
}

//�ϳ�ʱװ���ĵ�������
function getComposeFashionMaterialCount(%colorLevel)
{
	if (%colorLevel == 3)return 1;	//��ɫ
	else if (%colorLevel == 4)return 3;	//��ɫ
	else if (%colorLevel == 5)return 10;	//��ɫ
	else if (%colorLevel == 6)return 15;	//��ɫ
	return 20;
}

//�ϳɽ������
function getComposeFashionResultID(%colorLevel)
{
	%Random = GetRandom(1, 10000);
	for (%i = 0; %i <= 100; %i++)
	{
		/*��ȡװ����ɫ	*/	%ItemID[%i] = GetWord($ShiZhuangHeChengItemJiLv[%colorLevel, %i], 0);  //$ShiZhuangHeChengItemJiLv[6, 0 ] = "102106016 3000"; 
		/*��ȡװ������	*/	%ItemJL[%i] = GetWord($ShiZhuangHeChengItemJiLv[%colorLevel, %i], 1);  //$ShiZhuangHeChengItemJiLv[6, 1 ] = "102106020 3000"; 
		//$ShiZhuangHeChengItemJiLv[6, 2 ] = "102106021 1500"; 
		if (%ItemID[%i] $= "")                                                                      //$ShiZhuangHeChengItemJiLv[6, 3 ] = "102106022 1500"; 
			break;                                                                                   //$ShiZhuangHeChengItemJiLv[6, 4 ] = "102106024 340 "; 
		//$ShiZhuangHeChengItemJiLv[6, 5 ] = "102106025 330 "; 
		%ItemJL = %ItemJL + %ItemJL[%i];                                                           //$ShiZhuangHeChengItemJiLv[6, 6 ] = "102106026 330 "; 
		if (%Random >= (10000 -  %ItemJL))
			return %ItemID[%i];
	}
	return 0;
}


//������������������������ʱװ�ϳɡ���ء�����������������������������������


//����������������
function getDeityWeaponEmbedMatNum(%level)
{
	if (%level == 60) return 1;
	else if (%level == 70) return 2;
	else if (%level == 80) return 3;
	else if (%level == 90) return 10;
	else if (%level == 100) return 15;

	return 15;
}



//װ��ת�������������
function GetEquipChansSoulItemNumber()
{
	return 1;
}

function GetEquipGemUnmountConfig(%GemLevel, %valueType)
{
	%obj = $EquipGemUnmountObject[%GemLevel];
	switch (%valueType)
	{
		case 0: return %obj.MaterialId;
		case 1: return %obj.MaterialNum;
	}

	return 0;
}




//////////// ����ϵͳ ///////////////////////////////////////////
function GetIncreaseInsightSuccessRate(%nInsight)
{
	switch (%nInsight)
	{
		case 0:		return 10000;
		case 1:		return 6000;
		case 2: 	return 5000;
		case 3: 	return 4000;
		case 4: 	return 4000;
		case 5: 	return 3000;
		case 6: 	return 2000;
		case 7: 	return 2000;
		case 8: 	return 1000;
		case 9: 	return 1000;
		default:	return 0;
	}
}

function GetGenGuLevelByInsight(%nInsight)
{
	if (%nInsight >= 0 && %nInsight <= 2)
		return 1;
	if (%nInsight >= 3 && %nInsight <= 6)
		return 2;
	if (%nInsight >= 7 && %nInsight <= 10)
		return 3;
	//	if (%nInsight >= 8 && %nInsight <= 10)
	//		return 4;

	return 0;
}

function IsInsightMatchGenGuDan(%nInsight, %nGenGuLevel)
{
	%nLevel = GetGenGuLevelByInsight(%nInsight);
	if (%nLevel == 0)
		return 0;

	return %nLevel == %nGenGuLevel;
}

//���ޱ��������趨
function GetPetVariationLevelCost(%level)
{
	if (%level <= 3) return 105103154;
	else if (%level <= 6) return 105103155;
	else if (%level <= 9) return 105103156;
}

//��Ʒ������Ҫ��Я���ȼ�
function GetAddvariationNeedlev(%item)
{
	return 0;
}

//�����������ӵı���ֵ�����뱻�������޵ĳɳ��ʺͱ���ֵ
function GetPetAddvariation(%chengZhangLv, %variation)
{
	%exp = mfloor(%variation * 0.7) + 10;
	return %exp;
}

//getAddvariationNeedMoney_pet(%level,%spawnLevel,%variationLevel,%exp);�ȼ� Я���ȼ� ����ȼ� ����

function getAddvariationNeedMoney_pet(%level, %spawnLevel, %variationLevel, %exp)
{
	return 100;
}

//���������
function getMaxvariation()
{
	return 9;
}

//���ޱ���ȼ����ɶ�Ӧ������ ����1 ���ɳ���ı���ȼ�, ����2 �����ɳ����Я���ȼ�
function GetCanEvolve(%curlevel, %destlevel)
{

	if (%curlevel<=3 && %destlevel < 65)
		return 1;
	else
	if (%curlevel<=6 && %destlevel >= 65 && %destlevel < 80)
		return 1;
	else
	if (%curlevel<=9 && %destlevel >= 80)
		return 1;
	else
	if (%curlevel<=12 && %destlevel >= 80)
		return 1;
	else
	if (%curlevel<=15 && %destlevel >= 80)
		return 1;
	else
		return 0;

}

//����ƷID��������ȥ ���ÿ��1��������Ҫ�۳����ֵ�����
function getAddvariationNeedMoney(%Gid, %Num)
{
	return  0;
}

//����ÿ����������ľ�������
function getAddvariationNeeditemcount(%curexe, %levelexe)
{
	return 1;
}

//���ޱ��죬�������ӵľ��飬������Ʒ������ ������ӵľ���
function getItemAddvariation(%Gid, %Num)
{
	return 2 * %Num;
}

//***********������طָ���******************************

function GetDecreasedInsightLevel(%nInsight)
{
	%nLevel = GetGenGuLevelByInsight(%nInsight);

	if ((%nLevel == 1 && %nInsight == 0) ||
		(%nLevel == 1 && %nInsight == 2) ||
		(%nLevel == 2 && %nInsight == 5) ||
		(%nLevel == 3 && %nInsight == 8))

	{
		return %nInsight;
	}

	return %nInsight - 1;
}

function PetLianHua_GetGenGuDanId(%nGenGu)
{
	/*	if (%nGenGu <= 2)
	return 116070001;
	else if (%nGenGu > 2 && %nGenGu <= 5)
	return 116070002;
	else if (%nGenGu > 5 && %nGenGu <= 8)
	return 116070003;
	else if (%nGenGu > 8)
	return 116070004;
	else
	return 0;
	*/
	if (%nGenGu <= 3)
	{
		%a = getrandom(1, 100);
		if (%a <=85)
			return 116070001;
		else return 116070002;
	}
	else if (%nGenGu >= 4 && %nGenGu <= 8)
	{
		%a = getrandom(1, 100);
		if (%a<=15) return 116070001;
		else if (%a<=80) return 116070002;
		else return 116070003;
	}
	else if (%nGenGu >= 9 && %nGenGu <= 10)
	{
		%a = getrandom(1, 100);
		if (%a<=5) return 116070001;
		else if (%a<=20) return 116070002;
		else return 116070003;
	}
	else
		return 0;
}


//��ÿۼ�װ���Ĳ�λ
function getRepairEquipPos(%type, %num)
{
	if (%type == 1)//����
	{
		if (%num > 0 && %num < 61)
			return 11; //����
		else if (%num > 60 && %num < 86)
			return 1; //ͷ��
		else if (%num > 85 && %num <= 100)
			return 4; //�粿
	}
	else if (%type == 2) //װ��
	{
		if (%num > 0 && %num < 13)
			return 3; //��
		else if (%num > 12 && %num < 43)
			return 5; //����
		else if (%num > 42 && %num < 61)
			return 6; //��
		else if (%num > 60 && %num < 86)
			return 8; //��
		else if (%num > 85 && %num <= 100)
			return 7; //��
	}
}

//����۸�
function getRepairPrice(%colorLevel, %currmaxWear, %currWear, %level)
{
	%base = 38;
	%color = 1;
	switch (%colorLevel)
	{
		case 2:
			%color = 0.5;
		case 3:
			%color = 0.6;
		case 4:
			%color = 0.8;
		case 5:
			%color = 1;
		case 6:
			%color = 2;
		case 7:
			%color = 3;
	}
	/*	if ( %level <45 )		%level =12;
	else if ( %level <60 )		%level =15;
	else if ( %level <75 )		%level =24;
	else if ( %level <90 )		%level =34;
	else if ( %level <150 )	%level =48;*/
	%NeedMoney =mceil(30+%base * %color * (%currmaxWear-%currWear)/(150-%level));
	return %NeedMoney;
}
//��������۸�
function getMaxRepairPrice(%colorLevel, %maxWear, %currmaxWear, %currWear, %level)
{
	%base = 38;
	%base1= 62;
	%color = 1;
	switch (%colorLevel)
	{
		case 2:
			%color = 0.5;
		case 3:
			%color = 0.6;
		case 4:
			%color = 0.8;
		case 5:
			%color = 1.0;
		case 6:
			%color = 2.0;
		case 7:
			%color = 3.0;
	}
	/*	if ( %level <45 )		%level =12;
	else if ( %level <60 )		%level =15;
	else if ( %level <75 )		%level =24;
	else if ( %level <90 )		%level =34;
	else if ( %level <150 )	%level =48;*/
	return mceil(120+%color*%base*(%maxWear-%currmaxWear)/(150-%level) +%color*%base1*(%maxWear-%currWear)/(150-%level)+%maxWear/10);
}
//������Ҫ�ĵ���
function getRepairItem()
{
	return 105109054;
}

//�õ��¼���ˮʯ��ID
function getNextShenShuiStone(%itemID)
{
	if (%itemID == 116010001)
		return 116010002;
	else if (%itemID == 116010002)
		return 116010003;
	//	else if(%itemID == 116010003)
	//		return 116010004;
	//	else if(%itemID == 116010004)
	//		return 116010005;
	else
		return -1;
}
//�õ��ϳ���ˮʯ�Ĳ���ID
function getComposeShenShuiMaterial(%itemID)
{
	if (%itemID == 116010001)
		return 105060041;
	else if (%itemID == 116010002)
		return 105060042;
	else if (%itemID == 116010003)
		return 105060043;
	else if (%itemID == 116010004)
		return 105060044;
	else
		return -1;
}


//����
$ShenQiLevelUp_Kills[0] = 0;
$ShenQiLevelUp_Kills[1] = 1600;
$ShenQiLevelUp_Kills[2] = 1700;
$ShenQiLevelUp_Kills[3] = 1800;
$ShenQiLevelUp_Kills[4] = 2000;
$ShenQiLevelUp_Kills[5] = 2100;
$ShenQiLevelUp_Kills[6] = 2300;
$ShenQiLevelUp_Kills[7] = 2500;
$ShenQiLevelUp_Kills[8] = 2700;
$ShenQiLevelUp_Kills[9] = 2900;
$ShenQiLevelUp_Kills[10] = 0;
//$ShenQiLevelUp_Kills[0] = 0;
//$ShenQiLevelUp_Kills[1] = 1;
//$ShenQiLevelUp_Kills[2] = 2;
//$ShenQiLevelUp_Kills[3] = 3;
//$ShenQiLevelUp_Kills[4] = 4;
//$ShenQiLevelUp_Kills[5] = 5;
//$ShenQiLevelUp_Kills[6] = 5;
//$ShenQiLevelUp_Kills[7] = 5;
//$ShenQiLevelUp_Kills[8] = 5;
//$ShenQiLevelUp_Kills[9] = 5;
//$ShenQiLevelUp_Kills[10] = 0;
$ShenQiLevelUp_Kills[11] = 3400;
$ShenQiLevelUp_Kills[12] = 3700;
$ShenQiLevelUp_Kills[13] = 4000;
$ShenQiLevelUp_Kills[14] = 4300;
$ShenQiLevelUp_Kills[15] = 4600;
$ShenQiLevelUp_Kills[16] = 5000;
$ShenQiLevelUp_Kills[17] = 5400;
$ShenQiLevelUp_Kills[18] = 5800;
$ShenQiLevelUp_Kills[19] = 6300;
$ShenQiLevelUp_Kills[20] = 0;
$ShenQiLevelUp_Kills[21] = 7200;
$ShenQiLevelUp_Kills[22] = 7700;
$ShenQiLevelUp_Kills[23] = 8300;
$ShenQiLevelUp_Kills[24] = 8900;
$ShenQiLevelUp_Kills[25] = 9500;
$ShenQiLevelUp_Kills[26] = 10200;
$ShenQiLevelUp_Kills[27] = 10900;
$ShenQiLevelUp_Kills[28] = 11700;
$ShenQiLevelUp_Kills[29] = 12600;
$ShenQiLevelUp_Kills[30] = 0;
$ShenQiLevelUp_Kills[31] = 14500;
$ShenQiLevelUp_Kills[32] = 15600;
$ShenQiLevelUp_Kills[33] = 16800;
$ShenQiLevelUp_Kills[34] = 18000;
$ShenQiLevelUp_Kills[35] = 19400;
$ShenQiLevelUp_Kills[36] = 20900;
$ShenQiLevelUp_Kills[37] = 22400;
$ShenQiLevelUp_Kills[38] = 24100;
$ShenQiLevelUp_Kills[39] = 26000;
$ShenQiLevelUp_Kills[40] = 0;
$ShenQiLevelUp_Kills[41] = 30100;
$ShenQiLevelUp_Kills[42] = 32300;
$ShenQiLevelUp_Kills[43] = 34800;
$ShenQiLevelUp_Kills[44] = 37400;
$ShenQiLevelUp_Kills[45] = 40200;
$ShenQiLevelUp_Kills[46] = 43300;
$ShenQiLevelUp_Kills[47] = 46600;
$ShenQiLevelUp_Kills[48] = 50100;
$ShenQiLevelUp_Kills[49] = 53900;
$ShenQiLevelUp_Kills[50] = 0;
$ShenQiLevelUp_Kills[51] = 62300;
$ShenQiLevelUp_Kills[52] = 67000;
$ShenQiLevelUp_Kills[53] = 72100;
$ShenQiLevelUp_Kills[54] = 77500;
$ShenQiLevelUp_Kills[55] = 83400;
$ShenQiLevelUp_Kills[56] = 89700;
$ShenQiLevelUp_Kills[57] = 96400;
$ShenQiLevelUp_Kills[58] = 103700;
$ShenQiLevelUp_Kills[59] = 111500;
$ShenQiLevelUp_Kills[60] = 0;

function getUpShenQiNeedNum(%level, %quatity)
{
	%index = %level - 60 + %quatity + 1;
	return $ShenQiLevelUp_Kills[%index];
}

function rePairShenQiNeedMaterial(%level)
{
	switch (%level)
	{
		case 60: return 5;
		case 70: return 10;
		case 80: return 15;
		case 90: return 20;
		case 100: return 25;
		case 110: return 30;
		case 120: return 35;
		default: return 0;
	}
}

function getShenHunID(%level, %sub)
{
	//%newLevel = (%level - 60)/10 + 1;
	//%id = (10000 + %sub) *10000 + 8900 + %newLevel;
	//return %id;
	switch (%level)
	{
		case 60: return 105090021;
		case 70: return 105090022;
		case 80: return 105090023;
		case 90: return 105090024;
		case 100: return 105090025;
		case 110: return 105090026;
		case 120: return 105090027;
	}
}

function getLianShenCast(%Jingjie)
{
	return %Jingjie * 100000;

}

function getXiDianCast(%level)
{
	%Cast = 10000 + %level * %level * 100;

	if (%Cast > 500000)
		return 500000;
	else
		return %Cast;
}

function PetIdentify_GetCostMoney(%NeedLevel)
{
	if (%NeedLevel < 10)
		return 20;
	else if (%NeedLevel < 20)
		return 120;
	else if (%NeedLevel < 30)
		return 360;
	else if (%NeedLevel < 40)
		return 1300;
	else if (%NeedLevel < 50)
		return 4600;
	else if (%NeedLevel < 60)
		return 6800;
	else if (%NeedLevel < 70)
		return 8900;
	else if (%NeedLevel < 80)
		return 15000;
	else if (%NeedLevel < 90)
		return 22000;
	else if (%NeedLevel < 100)
		return 31000;
	else if (%NeedLevel < 110)
		return 39000;
	else if (%NeedLevel < 120)
		return 42000;
	else if (%NeedLevel < 130)
		return 55000;
	else if (%NeedLevel < 140)
		return 67000;
	else
		return 88000;
}

function PetInsight_GetCostMoney(%nInsight)//���뵱ǰ���
{
	switch (%nInsight)
	{
		case 0:		return 2000;
		case 1:		return 4000;
		case 2: 	return 8000;
		case 3: 	return 10000;
		case 4: 	return 20000;
		case 5: 	return 30000;
		case 6: 	return 40000;
		case 7: 	return 60000;
		case 8: 	return 80000;
		case 9: 	return 100000;
		default:	return 0;
	}
}

//����������Ϸ��Ҫ��
function PetLianHua_GetCostMoney(%nGenGu)
{
	switch (%nGenGu)
	{
		case 1:
			return 5000;
		case 2:
			return 5000;
		case 3:
			return 5000;
		case 4:
			return 10000;
		case 5:
			return 10000;
		case 6:
			return 10000;
		case 7:
			return 10000;
		case 8:
			return 10000;
		case 9:
			return 20000;
		case 10:
			return 20000;
		default:
			return 0;
	}
}



//���޻�ͯ��Ϸ��Ҫ��
function PetHuanTong_GetCostMoney(%nPetLevel)
{
	return 0;
}

//	Con::getIntArg(srcPet->insight)   //���
//  Con::getIntArg(srcPet->level)    //�ȼ�
//	Con::getIntArg(srcPet->chengZhangLv) //�ɳ���
//	Con::getIntArg(getPetSkillCount(slot)) //���ܸ���
//	Con::getIntArg(srcData->variationLevel)//����ȼ�
//	Con::getIntArg(maxGift)));             //����
//  mfloor(%num) ��Сȡ�� mceil(%num);���ȡ�� mround(%num)4��5��ȡ��
//  %AnimalEquip ����װ���ȼ���
//���޺������
function getPetComboBuff(%insight, %level, %chengZhangLv, %SkillCount, %variationLevel, %maxGift, %AnimalEquip)
{
	if (%insight==1) %insight=1;  //���ǿ��
	else if (%insight==2) %insight=3;
	else if (%insight==3) %insight=5;
	else if (%insight==4) %insight=8;
	else if (%insight==5) %insight=11;
	else if (%insight==6) %insight=15;
	else if (%insight==7) %insight=20;
	else if (%insight==8) %insight=26;
	else if (%insight==9) %insight=34;
	else if (%insight==10) %insight=45;
	else %insight=0;

	if (%chengZhangLv==1)	%chengZhangLv=1;   //����ɳ���
	else if (%chengZhangLv==2)	%chengZhangLv=3;
	else if (%chengZhangLv==3)	%chengZhangLv=6;
	else if (%chengZhangLv==4)	%chengZhangLv=10;
	else if (%chengZhangLv==5)	%chengZhangLv=15;
	else if (%chengZhangLv==6)	%chengZhangLv=21;
	else %chengZhangLv=0;

	%a = %level/10/2 + %insight/2/2 + %chengZhangLv/2/2 + %SkillCount*1.5/2; //��ֵת�Ӳ���level�����ή��Ϊԭ����1/2
	%b = 350020101 + mround(%a);
	return %b;
}



//-----------------------------------------------------------------------------------------------
//                ���Ѽ��͹���
//-----------------------------------------------------------------------------------------------
//���ͽ���
function serverCheerResponse(%playerId, %destPlayerId)
{
	addPlayerHot(%playerId, 1);
	addFriendValue(%playerId, %destPlayerId, 1);
}
//��Ϸ״̬���	��Ϸbuff�ȼ�	״̬˵��

//�ַ�����ʽ˵��:buff���,buff����,buff�ȼ�
$cheerCaheBuff[0] = "39999 1 1";         //39999	1  	��������100��
$cheerCaheBuff[1] = "39999 1 2";         //39999	2  	��������100��
$cheerCaheBuff[2] = "39999 1 3";         //39999	3  	��������100��
$cheerCaheBuff[3] = "39999 1 4";         //39999	4  	��������100��
$cheerCaheBuff[4] = "39999 1 5";         //39999	5  	��������100��
$cheerCaheBuff[5] = "39999 1 6";         //39999	6  	Ԫ������100��
$cheerCaheBuff[6] = "39999 1 7";         //39999	7  	����������100��
$cheerCaheBuff[7] = "39999 1 8";         //39999	8  	ľ�鹥����������100��
$cheerCaheBuff[8] = "39999 1 9";         //39999	9  	���鹥����������100��
$cheerCaheBuff[9] = "39999 1 10";        //39999	10	���鹥����������100��
$cheerCaheBuff[10] = "39999 1 11";       //39999	11	���鹥����������100��
$cheerCaheBuff[11] = "39999 1 12";       //39999	12	ˮ�鹥����������100��
$cheerCaheBuff[12] = "39999 1 13";       //39999	13	Ԫ��������������100��
$cheerCaheBuff[13] = "39999 1 14";       //39999	14	�����������1000��
$cheerCaheBuff[14] = "39999 1 15";       //39999	15	ľ�������������1000��
$cheerCaheBuff[15] = "39999 1 16";       //39999	16	���������������1000��
$cheerCaheBuff[16] = "39999 1 17";       //39999	17	���������������1000��
$cheerCaheBuff[17] = "39999 1 18";       //39999	18	���������������1000��
$cheerCaheBuff[18] = "39999 1 19";       //39999	19	ˮ�������������1000��
$cheerCaheBuff[19] = "39999 1 20";       //39999	20	Ԫ��������������1000��
$cheerCaheBuff[20] = "39999 1 21";       //39999	21	������������10%
$cheerCaheBuff[21] = "39999 1 22";       //39999	22	������������10%
$cheerCaheBuff[22] = "39999 1 23";       //39999	23	Ԫ����������10%
$cheerCaheBuff[23] = "39999 1 24";       //39999	24	������������100��
$cheerCaheBuff[24] = "39999 1 25";       //39999	25	������������100��
$cheerCaheBuff[25] = "39999 1 26";       //39999	26	������������100��
$cheerCaheBuff[26] = "39999 1 27";       //39999	27	������������100��
$cheerCaheBuff[27] = "39999 1 28";       //39999	28	������������100��
$cheerCaheBuff[28] = "39999 1 29";       //39999	29	����������������100%
$cheerCaheBuff[29] = "39999 1 30";       //39999	30	�ƶ��ٶ�����5%
$cheerCaheBuff[30] = "39999 1 31";       //39999	31	�ƶ��ٶ�����10%
$cheerCaheBuff[31] = "39999 1 32";       //39999	32	�ƶ��ٶ�����15%
//schedulebuff
$cheerCaheBuff[32] = "1016 0 0";       	 //1016	      ɱ��˫�����ﾭ�飨60���ӣ�
$cheerCaheBuff[33] = "1017 0 0";         //1017	      ɱ��˫�����޾��飨60���ӣ�
$cheerCaheBuff[34] = "1018 0 0";         //1018	      ɱ��˫��Ԫ���飨60���ӣ�
$cheerCaheBuff[35] = "1019 0 0";         //1019	      �������������60���ӣ�����Ч��
$cheerCaheBuff[36] = "1020 0 0";         //1020	      ˫��ʦ�������飨60���ӣ�
$cheerCaheBuff[37] = "1021 0 0";         //1021	      ˫�����������飨60���ӣ�
$cheerCaheBuff[38] = "1022 0 0";         //1022	      ˫����ƿ�����Ԫ������60���ӣ�
$cheerCaheBuff[39] = "1023 0 0";         //1023	      ˫��ǧ������Ԫ������60���ӣ�
$cheerCaheBuff[40] = "1024 0 0";         //1024	      ˫�������ᱦ��Ǯ������60���ӣ�
$cheerCaheBuff[41] = "1025 0 0";         //1025	      1.5�����缩�׾��齱����60���ӣ�

function sptCanEncourage(%player)
{
	if (%player == 0)
		return false;

	//������ȴbuff
	if (%player.isschbuff(1015))
		return false;

	//ս����buff
	if (%player.getBuffCount(39999, 0) > 0)
		return false;

	//ScheduleBuff��buff
	if (%player.isschbuff(1016))
		return false;

	if (%player.isschbuff(1017))
		return false;

	if (%player.isschbuff(1018))
		return false;

	if (%player.isschbuff(1019))
		return false;

	if (%player.isschbuff(1020))
		return false;

	if (%player.isschbuff(1021))
		return false;

	if (%player.isschbuff(1022))
		return false;

	if (%player.isschbuff(1023))
		return false;

	if (%player.isschbuff(1024))
		return false;

	if (%player.isschbuff(1025))
		return false;

	return true;
}

//----------------------------------------------------
//zoneServer ����
//���һ��buff
function randomCheerCaheBuff()
{
	%index = getRandom(41);
	return  $cheerCaheBuff[%index];
}


function getUpTrumpLevelExp(%level)
{
	return $TrumpLevelUp_Exp[%level+1];
}



//�������ƴ���
function GetTrumpSmeltTimes(%itemID)
{
	switch (%itemID)
	{
		case 117010011:return 2;
		case 117010021:return 2;
		case 117010031:return 2;
		case 117010041:return 2;
		case 117010051:return 2;
		case 117010061:return 2;
	}

	return 0;
}


//���޾�����ʽ
function PetLianHun_GetCostMoney(%PetLv)
{
	return 5000 * %PetLv + 10000 + (mFloor(%PetLv / 10) - 5) * 150000;
}



//װ������ϴ��ؽű����£�


//�õ�����̶�����Ԫ��
function getLockSoulFixedGold(%level)
{
	if (%Level < 70)
		return 100;
	else if (%Level < 80)
		return 100;
	else
		return 100;
}


//�������鲻ͬ�ȼ�װ����Ҫ���ĵ�Ԫ���������������ģ�����������ˣ�
function GetLockSoulMoney(%Level)
{
	if (%Level < 70)
		return 100;
	else if (%Level < 80)
		return 100;
	else
		return 100;
}




//�õ����������Ǯ
function getAddProNumMoney(%num, %level)
{
	switch (%level)
	{
		case 60: return 20000;
		case 70: return 50000;
		case 80: return 80000;
		case 90: return 150000;
		case 100: return 300000;
		case 110: return 600000;
		case 120: return 900000;
	}
}


//�õ���������Ԫ��
function YBToAddProNum(%level, %inum)
{
	if (%Level < 70)
		switch (%inum)
	{
			case 5: return 100;
			case 6: return 250;
			case 7: return 500;
			case 8: return 1000;
			case 9: return 1500;
			case 10: return 3000;
			case 11: return 4500;
	}
	else if (%Level < 80)
		switch (%inum)
	{
			case 5: return 200;
			case 6: return 500;
			case 7: return 1000;
			case 8: return 2000;
			case 9: return 3000;
			case 10: return 6000;
			case 11: return 9000;
	}

	else if (%Level < 90)
		switch (%inum)
	{
			case 5: return 300;
			case 6: return 750;
			case 7: return 1500;
			case 8: return 3000;
			case 9: return 4500;
			case 10: return 9000;
			case 11: return 13500;
	}
	return 10000;

}





//�õ�ϴ�������Ǯ
function getChangeEveryProMoney(%num, %level)
{

	return %level*%level+%num*1000;

}



//������������������������ȡװ���ķ���Ʒ����ɫֵ��������������������������������������
// ��ȡ�������⣬%typeΪ�����ȼ�������RGB��ɫֵ,�磺return "60 255 255";
function GetWeaponGlow(%type)
{
	//echo("%type2222   ===   "@%type);
	if (%type == 1)	return "0 36 255";
	else if (%type == 2)	return "0 36 255";
	else if (%type == 3)	return "0 36 255";
	else if (%type == 4)	return "0 36 255";
	else if (%type == 5)	return "0 36 255";
	else if (%type == 6)	return "0 110 255";
	else if (%type == 7)	return "52 1 200";
	else if (%type == 8)	return "67 1 71";
	else if (%type == 9)	return "92 0 0";
	else if (%type == 10) return "255 84 0";
	else if (%type == 11) return "255 144 0";
	else if (%type == 12) return "255 240 0";
	else if (%type == 13) return "252 0 0";
	else if (%type == 14) return "250 41 243";
	else if (%type == 15) return "255 255 255";
	else return "0 0 0";

}

// ��ȡװ��Ʒ�ʷ��⣬%valΪװ��Ʒ�ʣ�����RGB��ɫֵ,�磺return "60 255 255";
function GetTotalQualityGlow(%val)
{
	//echo("%val1111   ===   "@%val);

	if (%val < 7000) return "0 0 0";
	else if (%val < 9000) return "64 181 49";
	else if (%val < 12000) return "0 0 255";
	else if (%val < 16000) return "255 0 255";
	else if (%val < 30000) return "255 156 0";
	else if (%val < 80000) return "250 60 60";
	else if (%val < 120000) return "0 255 255";
	else if (%val < 160000) return "255 85 0";
	else if (%val < 200000) return "174 0 255";

	return "174 0 255";
}

//ת������
function getMetempsychosisGlow(%val)
{
	return "0 0 0";

	switch (%val)
	{
		case 1: return "255 255 255";
		case 2: return "250 170 65";
		case 3: return "250 240 70";
		case 4: return "220 80 40";
		case 5: return "70 140 230";
		case 6: return "90 220 60";
		default: return "0 0 0";
	}
}
// �������
// %LevelLimit Ҫ���Ƶķ����ĵȼ�
// %StarLevel  Ҫ���Ƶķ������Ǽ�
// �������Ʒ�����Ҫ�Ľ������
function GetStrengthenTrumpNeedBindMoney(%LevelLimit, %StarLevel)
{
	return 0;
	switch (%LevelLimit)
	{
		case 18:	return 5000*%StarLevel;					//20������
		case 60:	return 8000*%StarLevel*1.5;			//60������
		case 80:	return 15000*%StarLevel*3; 			//80������
	}

}

//����������������Ϸ������
function GetUpgradeTrumpNeedBindMoney(%LevelLimit, %StarLevel)
{
	switch (%LevelLimit)
	{
		case 18:	return 200000;		//20������
		case 60:	return 500000;		//60������
		case 80:	return 2000000; 	//80������
	}
	return 200000;
}


//�õ����ƺϳɽ�Ǯ�ĺ���
function getComposeImpressKardMoney()
{
	return 100000;
}



//�õ�ʱװ��Ƕ��Ǯ�ĺ���

function getImpressFashionMoney()
{
	return 50000;
}


//��ȡת����Ϸ������
function getTransferSoulMoney(%level, %color)
{
	return 0;
}





//������������������������ǿ����������������������ϳɡ�������������������������



//���������������������������졿������������װ�����顿��������������������������
//���������������������������졿������������װ�����顿��������������������������

//�����������������������������������������������ϳɡ���������������������������
//������������������������������������������������������������������������������


//������������������������ǿ����������������������ϳɡ�������������������������
// �ϳɴ�������ʯ����Ԫ������
// %ItemID Ҫ�ϳɵ�����ʯ�ĵ���ID
function MoneyToComposeTianLingStone(%ItemID)
{
	switch (%ItemID)
	{
		case 116010003: return 300;
	}

	return 0;
}

// �ϳɴ�������ʯ����������
// %ItemID Ҫ�ϳɵ�����ʯ�ĵ���ID
function BindMoneyToComposeTianLingStone(%ItemID)
{
	switch (%ItemID)
	{
		case 116010002: return 6000;
	}

	return 0;
}
//������������������������ǿ����������������������ϳɡ�������������������������






//�����������������������������������������������ϳɡ���������������������������
//�����ϳ���Ҫ��Ԫ������
function YBToComposeShenTie()
{
	return 100;
}
//�����������������������������������������������ϳɡ���������������������������

//������������������������������������������������������������������������������
//����������Ҫ��Ԫ������
function YBToSplitShenTie()
{
	return 100;
}
//������������������������������������������������������������������������������

//���������������������������ӵ㷵��ֵ��������������������������������������
//����
function MaxHP_MercenaryAdd(%ID)
{
	return (%ID.Stamina + %ID.strengthPoint) * 20;
}
//������
function PhyDamage_MercenaryAdd(%ID)
{
	return (%ID.Strength + %ID.phyAtkPoint) * 3;
}
//��������
function MagicDamage_MercenaryAdd(%ID)
{
	return (%ID.Intellect + %ID.magicAtkPoint) * 3;
}
//�������
function PhyDefence_MercenaryAdd(%ID)
{
	return (%ID.Mana + %ID.phyDefPoint) * 21.2;
}
//��������
function MagicDefence_MercenaryAdd(%ID)
{
	return (%ID.Mana + %ID.phyDefPoint) * 21.2;
}
//��
function CriticalRating_MercenaryAdd(%ID)
{
	return (%ID.Agility + %ID.agilityPoint) * 21.2;
}
//���������������������������ӵ㷵��ֵ��������������������������������������

// ���ضһ�������Ҫ�ĵȼ�����
function GetDuiHuanXXLevelLimit(%ItemID)
{
	return $XXDuiHuanConfigs[%ItemID].LevelLimit;
}

// ��ȡ�һ���������Ҫ����Ƭ����
function GetDuiHuanXXPieceNum(%ItemID)
{

	return $XXDuiHuanConfigs[%ItemID].NeedPieceNum;

}

function AddXXDuiHuanConfig(%ItemID, %NeedPieceNum, %LevelLimit)
{
	%XXDuiHuanConf = "XXDuiHuanConf_" @ %ItemID;
	new ScriptObject(%XXDuiHuanConf)
	{
		ItemID			= %ItemID;
		NeedPieceNum	= %NeedPieceNum;
		LevelLimit		= %LevelLimit;
	};
	$XXDuiHuanConfigs[%ItemID] = %XXDuiHuanConf;
}


// ��Ӷһ����������
AddXXDuiHuanConfig(120010441, 10, 60);
AddXXDuiHuanConfig(120010401, 20, 60);
AddXXDuiHuanConfig(120010391, 20, 60);
AddXXDuiHuanConfig(120010421, 20, 60);
AddXXDuiHuanConfig(120010411, 20, 60);
AddXXDuiHuanConfig(120010381, 20, 60);
AddXXDuiHuanConfig(120010371, 20, 60);
AddXXDuiHuanConfig(120010341, 20, 60);
AddXXDuiHuanConfig(120010321, 20, 60);
AddXXDuiHuanConfig(120010361, 20, 60);
AddXXDuiHuanConfig(120010351, 20, 60);
AddXXDuiHuanConfig(120010301, 20, 60);
AddXXDuiHuanConfig(120010311, 20, 60);
AddXXDuiHuanConfig(120010291, 20, 60);

AddXXDuiHuanConfig(120010251, 5, 30);
AddXXDuiHuanConfig(120010261, 5, 30);
AddXXDuiHuanConfig(120010231, 5, 30);
AddXXDuiHuanConfig(120010221, 5, 30);
AddXXDuiHuanConfig(120010211, 5, 30);
AddXXDuiHuanConfig(120010201, 5, 30);
AddXXDuiHuanConfig(120010191, 5, 30);
AddXXDuiHuanConfig(120010181, 5, 30);
AddXXDuiHuanConfig(120010171, 5, 30);
AddXXDuiHuanConfig(120010161, 5, 30);
AddXXDuiHuanConfig(120010141, 5, 30);
AddXXDuiHuanConfig(120010151, 5, 30);
AddXXDuiHuanConfig(120010131, 5, 30);

//�������ϵͳ���ŵĵȼ�
function LevelToOpenStarFunc()
{
	return 65;
}

//�������ϵͳ���ŵ�ת���ȼ�
function MetempsychosisToOpenStarFunc()
{
	return 0;
}


//��������Ҫ���ĵ�Ԫ������
function PriceToActiveXXPack()
{
	return 1;
}

//��ȡ���󱦴��ĵ������ID
function XXPackDropPackageID()
{
	return 56002120;
}

//���󱦴������ܴ���
function XXPackMaxAddPowerNum()
{
	return 36;
}

//���󱦴�����Timer��ID
function XXPackTimeSetID()
{
	return 3014;
}

// ���󱦴����ܼ۸�(����Ԫ��)
// %PackSNCurrDay �����N��,��1��ʼ����
// %AddPowerSNCurrDay �����M�θ���N������,��1��ʼ����
function PriceToXXPackAddPower(%PackSNCurrDay, %AddPowerSNCurrDay)
{
	if (%PackSNCurrDay >= 2)
	{
		%PackSNCurrDay = 2;
	}
	return $XXPackConfigs[%PackSNCurrDay, %AddPowerSNCurrDay];
}

// %PackSNCurrDay �����N��,��1��ʼ����
// %AddPowerSNCurrDay �����M�θ���N������,��1��ʼ����
function AddXXPackConfig(%PackSNCurrDay, %AddPowerSNCurrDay, %Price)
{
	$XXPackConfigs[%PackSNCurrDay, %AddPowerSNCurrDay] = %Price;
}

// ���ñ����۸�ʾ��
AddXXPackConfig(1, 1, 0); // �����һ��Ϊ��һ�������������ĵ�Ԫ������
AddXXPackConfig(1, 2, 10); // ����ڶ���Ϊ��һ�������������ĵ�Ԫ������
AddXXPackConfig(1, 3, 50);
AddXXPackConfig(1, 4, 80);
AddXXPackConfig(1, 5, 100);
AddXXPackConfig(1, 6, 500);
AddXXPackConfig(1, 7, 1000);
AddXXPackConfig(1, 8, 1500);
AddXXPackConfig(1, 9, 1500);
AddXXPackConfig(1, 10, 1500);
AddXXPackConfig(1, 11, 1500);
AddXXPackConfig(1, 12, 1500);
AddXXPackConfig(1, 13, 1500);
AddXXPackConfig(1, 14, 1500);
AddXXPackConfig(1, 15, 1500);
AddXXPackConfig(1, 16, 1500);
AddXXPackConfig(1, 17, 1500);
AddXXPackConfig(1, 18, 1500);
AddXXPackConfig(1, 19, 1500);
AddXXPackConfig(1, 20, 1500);
AddXXPackConfig(1, 21, 1500);
AddXXPackConfig(1, 22, 1500);
AddXXPackConfig(1, 23, 1500);
AddXXPackConfig(1, 24, 1500);
AddXXPackConfig(1, 25, 1500);
AddXXPackConfig(1, 26, 1500);
AddXXPackConfig(1, 27, 1500);
AddXXPackConfig(1, 28, 1500);
AddXXPackConfig(1, 29, 1500);
AddXXPackConfig(1, 30, 1500);
AddXXPackConfig(1, 31, 1500);
AddXXPackConfig(1, 32, 1500);
AddXXPackConfig(1, 33, 1500);
AddXXPackConfig(1, 34, 1500);
AddXXPackConfig(1, 35, 1500);
AddXXPackConfig(1, 36, 1500);

AddXXPackConfig(2, 1, 500); // �����һ��Ϊ�ڶ��������������ĵ�Ԫ������
AddXXPackConfig(2, 2, 1000);
AddXXPackConfig(2, 3, 1500);
AddXXPackConfig(2, 4, 1500);
AddXXPackConfig(2, 5, 1500);
AddXXPackConfig(2, 6, 1500);
AddXXPackConfig(2, 7, 1500);
AddXXPackConfig(2, 8, 1500);
AddXXPackConfig(2, 9, 1500);
AddXXPackConfig(2, 10, 1500);
AddXXPackConfig(2, 11, 1500);
AddXXPackConfig(2, 12, 1500);
AddXXPackConfig(2, 13, 1500);
AddXXPackConfig(2, 14, 1500);
AddXXPackConfig(2, 15, 1500);
AddXXPackConfig(2, 16, 1500);
AddXXPackConfig(2, 17, 1500);
AddXXPackConfig(2, 18, 1500);
AddXXPackConfig(2, 19, 1500);
AddXXPackConfig(2, 20, 1500);
AddXXPackConfig(2, 21, 1500);
AddXXPackConfig(2, 22, 1500);
AddXXPackConfig(2, 23, 1500);
AddXXPackConfig(2, 24, 1500);
AddXXPackConfig(2, 25, 1500);
AddXXPackConfig(2, 26, 1500);
AddXXPackConfig(2, 27, 1500);
AddXXPackConfig(2, 28, 1500);
AddXXPackConfig(2, 29, 1500);
AddXXPackConfig(2, 30, 1500);
AddXXPackConfig(2, 31, 1500);
AddXXPackConfig(2, 32, 1500);
AddXXPackConfig(2, 33, 1500);
AddXXPackConfig(2, 34, 1500);
AddXXPackConfig(2, 35, 1500);
AddXXPackConfig(2, 36, 1500);




//װ������ʱ������ʯ����
function getGatherNeedItemNum(%lv)
{
	switch (%lv)
	{
		case 1:return 2;
		case 2:return 4;
		case 3:return 6;
		case 4:return 2;
		case 5:return 4;
		case 6:return 6;
		case 7:return 2;
		case 8:return 4;
		case 9:return 6;
		case 10:return 2;
		case 11:return 4;
		case 12:return 6;
		case 13:return 2;
		case 14:return 4;
		case 15:return 6;
	}
}


//ʱװ�ϳ�����
function getComposeImpressKardGold()
{
	return 1000;
}


//���������Ƕ
function SptGetPointsForGWskill(%level)
{
	if (%level < 70)
	{
		return 1000;
	}
	else if (%level < 80)
	{
		return 2000;
	}
	else
	{
		return 3000;
	}

}


//1.getEatEquipValue(%equipPos,%equipLv,%pro)��ɫװ���ȼ���Ӧ���ӵĻ��׻򹥻�ֵ����Ҫ���Ĳ�����װ����λ��װ���ȼ��������������ݣ�
//2.getEatBuffID(%part,%value,%pro)ĳ��װ�����ӵ�״̬��ţ���Ҫ���Ĳ��������ӵ���ֵ����158��,װ����λ�������������ݣ�
//3.getValueLimit(%lv,%metempsychosis,%equipPos,%pro)��ͬ�ȼ���ת�����������ÿ�����ǿ�������ޣ���Ҫ���Ĳ�������ҵȼ���ת��������
//4.getNeedMoney��%level��������ģ��������ĵ���װ���ȼ���
//���ȼ�װ�����ӵĻ��׻򹥻�ֵ
//302420010�����ף�302420110�������� ��302420210���������������� 302420410��������
function getEatEquipValue(%equipPos, %equipLv, %pro)
{
	if (%equipLv >= 60  && %equipLv < 70)
		switch (%equipPos)
	{
			case 1: return 60;
			case 2: return 6;
			case 3: return 60;
			case 4: return 60;
			case 5: return 60;
			case 6: return 60;
			case 7: return 60;
			case 8: return 60;
			case 9: return 6;
			case 10: return 6;
			case 11: return 6;
	}
	else
	if (%equipLv >= 70  && %equipLv < 80)
		switch (%equipPos)
	{
			case 1: return 70;
			case 2: return 7;
			case 3: return 70;
			case 4: return 70;
			case 5: return 70;
			case 6: return 70;
			case 7: return 70;
			case 8: return 70;
			case 9: return 7;
			case 10: return 7;
			case 11: return 7;
	}
	else
	if (%equipLv >= 80  && %equipLv < 100)
		switch (%equipPos)
	{
			case 1: return 80;
			case 2: return 8;
			case 3: return 80;
			case 4: return 80;
			case 5: return 80;
			case 6: return 80;
			case 7: return 80;
			case 8: return 80;
			case 9: return 8;
			case 10: return 8;
			case 11: return 8;
	}
}

//����״̬���
function getEatBuffID(%part, %value, %pro)
{
	if ((%pro == 1 && %part==1) || (%pro == 1 && %part==3) || (%pro == 1 && %part==4) || (%pro == 1 && %part==5) || (%pro == 1 && %part==6) || (%pro == 1 && %part==7) || (%pro == 1 && %part==1)|| (%pro == 1 && %part==8))
	{
		if (%value>=10000)
		{
			%a=302420050 + GetSubStr(%value, 0, 1);
			%b=302420040 + GetSubStr(%value, 1, 1);
			%c=302420030 + GetSubStr(%value, 2, 1);
			%d=302420020 + GetSubStr(%value, 3, 1);
			%e=302420010 + GetSubStr(%value, 4, 1);
			return %a @ " " @ %b @ " " @ %c @ " " @ %d @ " " @ %e;
		}
		else if (%value>=1000)
		{
			%b=302420040 + GetSubStr(%value, 0, 1);
			%c=302420030 + GetSubStr(%value, 1, 1);
			%d=302420020 + GetSubStr(%value, 2, 1);
			%e=302420010 + GetSubStr(%value, 3, 1);
			return  %b @ " " @ %c @ " " @ %d @ " " @ %e;
		}
		else if (%value>=100)
		{
			%c=302420030 + GetSubStr(%value, 0, 1);
			%d=302420020 + GetSubStr(%value, 1, 1);
			%e=302420010 + GetSubStr(%value, 2, 1);
			return  %c @ " " @ %d @ " " @ %e;
		}
		else if (%value>=10)
		{
			%d=302420020 + GetSubStr(%value, 0, 1);
			%e=302420010 + GetSubStr(%value, 1, 1);
			return  %d @ " " @ %e;
		}
		else if (%value>=1)
		{
			%e=302420010 + GetSubStr(%value, 0, 1);
			return  %e;
		}
	}
	else
	if ((%pro == 2 && %part==1) || (%pro == 2 && %part==3) || (%pro == 2 && %part==4) || (%pro == 2 && %part==5) || (%pro == 2 && %part==6) || (%pro == 2 && %part==7) || (%pro == 2 && %part==1)|| (%pro == 2 && %part==8))

	{
		if (%value>=10000)
		{
			%a=302420150 + GetSubStr(%value, 0, 1);
			%b=302420140 + GetSubStr(%value, 1, 1);
			%c=302420130 + GetSubStr(%value, 2, 1);
			%d=302420120 + GetSubStr(%value, 3, 1);
			%e=302420110 + GetSubStr(%value, 4, 1);
			return %a @ " " @ %b @ " " @ %c @ " " @ %d @ " " @ %e;
		}
		else if (%value>=1000)
		{
			%b=302420140 + GetSubStr(%value, 0, 1);
			%c=302420130 + GetSubStr(%value, 1, 1);
			%d=302420120 + GetSubStr(%value, 2, 1);
			%e=302420110 + GetSubStr(%value, 3, 1);
			return  %b @ " " @ %c @ " " @ %d @ " " @ %e;
		}
		else if (%value>=100)
		{
			%c=302420130 + GetSubStr(%value, 0, 1);
			%d=302420120 + GetSubStr(%value, 1, 1);
			%e=302420110 + GetSubStr(%value, 2, 1);
			return  %c @ " " @ %d @ " " @ %e;
		}
		else if (%value>=10)
		{
			%d=302420120 + GetSubStr(%value, 0, 1);
			%e=302420110 + GetSubStr(%value, 1, 1);
			return  %d @ " " @ %e;
		}
		else if (%value>=1)
		{
			%e=302420110 + GetSubStr(%value, 0, 1);
			return  %e;
		}
	}

	else
	if ((%pro == 1 && %part==2) || (%pro == 1 && %part==9) || (%pro == 1 && %part==10) || (%pro == 1 && %part==11))
	{
		if (%value>=10000)
		{
			%a=302420250 + GetSubStr(%value, 0, 1);
			%b=302420240 + GetSubStr(%value, 1, 1);
			%c=302420230 + GetSubStr(%value, 2, 1);
			%d=302420220 + GetSubStr(%value, 3, 1);
			%e=302420210 + GetSubStr(%value, 4, 1);
			return %a @ " " @ %b @ " " @ %c @ " " @ %d @ " " @ %e;
		}
		else if (%value>=1000)
		{
			%b=302420240 + GetSubStr(%value, 0, 1);
			%c=302420230 + GetSubStr(%value, 1, 1);
			%d=302420220 + GetSubStr(%value, 2, 1);
			%e=302420210 + GetSubStr(%value, 3, 1);
			return  %b @ " " @ %c @ " " @ %d @ " " @ %e;
		}
		else if (%value>=100)
		{
			%c=302420230 + GetSubStr(%value, 0, 1);
			%d=302420220 + GetSubStr(%value, 1, 1);
			%e=302420210 + GetSubStr(%value, 2, 1);
			return  %c @ " " @ %d @ " " @ %e;
		}
		else if (%value>=10)
		{
			%d=302420220 + GetSubStr(%value, 0, 1);
			%e=302420210 + GetSubStr(%value, 1, 1);
			return  %d @ " " @ %e;
		}
		else if (%value>=1)
		{
			%e=302420210 + GetSubStr(%value, 0, 1);
			return  %e;
		}
	}
	else
	if ((%pro == 2 && %part==2) || (%pro == 2 && %part==9) || (%pro == 2 && %part==10) || (%pro == 2 && %part==11))
	{
		if (%value>=10000)
		{
			%a=302420450 + GetSubStr(%value, 0, 1);
			%b=302420440 + GetSubStr(%value, 1, 1);
			%c=302420430 + GetSubStr(%value, 2, 1);
			%d=302420420 + GetSubStr(%value, 3, 1);
			%e=302420410 + GetSubStr(%value, 4, 1);
			return %a @ " " @ %b @ " " @ %c @ " " @ %d @ " " @ %e;
		}
		else if (%value>=1000)
		{
			%b=302420440 + GetSubStr(%value, 0, 1);
			%c=302420430 + GetSubStr(%value, 1, 1);
			%d=302420420 + GetSubStr(%value, 2, 1);
			%e=302420410 + GetSubStr(%value, 3, 1);
			return  %b @ " " @ %c @ " " @ %d @ " " @ %e;
		}
		else if (%value>=100)
		{
			%c=302420430 + GetSubStr(%value, 0, 1);
			%d=302420420 + GetSubStr(%value, 1, 1);
			%e=302420410 + GetSubStr(%value, 2, 1);
			return  %c @ " " @ %d @ " " @ %e;
		}
		else if (%value>=10)
		{
			%d=302420420 + GetSubStr(%value, 0, 1);
			%e=302420410 + GetSubStr(%value, 1, 1);
			return  %d @ " " @ %e;
		}
		else if (%value>=1)
		{
			%e=302420410 + GetSubStr(%value, 0, 1);
			return  %e;
		}

	}

	return 0;
}

//��ͬת���ȼ�����ҿ������ɵ�ֵ���ޣ�%gatherSoulLV����ȼ���
function getValueLimit(%equipLv, %metempsychosis, %equipPos, %pro, %gatherSoulLV)
{
	return 0;
}

//������Ϸ������
function getNeedMoney(%level)
{
	return 0;
}

//********������ع���******
//����������

function getGatherSoulMoney(%lv)
{
	switch (%lv)
	{
		case 1: return 100000;
		case 2: return 200000;
		case 3: return 300000;
		case 4: return 400000;
		case 5: return 500000;
		case 6: return 600000;
		case 7: return 700000;
		case 8: return 800000;
		case 9: return 900000;
		case 10: return 1000000;
		case 11: return 1100000;
		case 12: return 1200000;
		case 13: return 1300000;
		case 14: return 1400000;
		case 15: return 1500000;
	}

}

//������װ����ʯ��Ƕ�Ĺ�ϵ(װ���ȼ�,��ʯ�ȼ�,����ȼ�)
function canMountGem(%equipLv, %gemLv, %gatherLv)
{
	if (%gatherLv<=0 && %equipLv<=69 && %gemLv<=3)
	{
		return 1;
	}
	else
	if (%gatherLv<=0 && %equipLv<=79 && %gemLv<=4)
	{
		return 1;
	}
	else
	if (%gatherLv<=0 && %equipLv<=90 && %gemLv<=6)
	{
		return 1;
	}
	else
	if (%gatherLv<=0 && %equipLv<=120 && %gemLv<=7)
	{
		return 1;
	}
	if (%gatherLv>=1)
	{
		return 1;
	}
	else
		return 0;
}


function getGatherPlayerLv(%gatherlv)
{
	//switch(%gatherlv)
	//{
	//	case 1 : return 101;
	//	case 2 : return 170;
	//	case 3 : return 180;
	//	case 4 : return 201;
	//	case 5 : return 270;
	//	case 6 : return 280;
	//	case 7 : return 301;
	//	case 8 : return 370;
	//	case 9 : return 380;
	//	case 10: return 401;
	//	case 11: return 470;
	//	case 12: return 480;
	//	case 13: return 501;
	//	case 14: return 570;
	//	case 15: return 580;
	//}

	return 0;
}

//�������޼����������Ļ���
function getPetSkillLevelUp_money(%skillid)
{
	%Val[5] = GetSubStr(%skillid, 4, 1);
	%Val[4] = GetSubStr(%skillid, 3, 1);
	%Val[3] = GetSubStr(%skillid, 2, 1);

	if (%Val[5] == 1)
	if ((%Val[3] == 0  && (%Val[4] >= 1 && %Val[4] <= 7)) || (%Val[3] == 1 && %Val[4] == 6)  || (%Val[3] == 1 && %Val[4] == 9) || (%Val[3] == 2 && %Val[4] == 3) || (%Val[3] == 2 && %Val[4] == 4))
		return 1800;
	else
		return 1200;

	if (%Val[5] == 2)
	if ((%Val[3] == 0  && (%Val[4] >= 1 && %Val[4] <= 7)) || (%Val[3] == 1 && %Val[4] == 6)  || (%Val[3] == 1 && %Val[4] == 9) || (%Val[3] == 2 && %Val[4] == 3) || (%Val[3] == 2 && %Val[4] == 4))
		return 3000;
	else
		return 2000;

	return 0;
}


//������������������������ʮ����껪����ء���������������������������������
//����Ұ�������������
function KillBossValue(%Player)
{
	%ItemCount = %Player.GetItemCount(105101770, 1);
	return %ItemCount;
}
//������������������������ʮ����껪����ء���������������������������������



//���������������������������ս��������ء���������������������������������
//��û���ս���� ת���ȼ� ��ɫ�ȼ�
function GetBaseEffectiveness(%ZsLevel, %Level)
{
	if (%Level <= 30)%DianS = mFloor(%Level / 15)*3;
	else if (%Level <= 60)%DianS = 6  + mFloor((%Level - 30)/10) * 4;
	else if (%Level >= 80)%DianS = 18 + mFloor((%Level - 60)/10) * 5;
	else if (%Level >= 100)%DianS = 28 + mFloor((%Level - 80)/5) * 5;
	else %DianS = 48 + mFloor((%Level - 100)/5) * 10;
	return %DianS+%Level;
}

//��ü���ս����
function GetSkillEffectiveness(%SkillId, %SkillLevel)
{
	%DianS = %SkillLevel;
	return %DianS;
}

//��ñ�ʯս����
function GetGemEffectiveness(%GemID)
{
	%GemLevel = GetItemData(%GemID, $Item_Data_Lv);//��õ��ߵȼ�
	//echo("%GemLevel  ==  "@%GemLevel);
	%Streng = getItemBaseStats(%GemLevel+2)/10000;
	//echo("%Streng  ==  "@%Streng);
	%ability = (15 + %GemLevel*25)*%Streng;
	//echo("%ability  ==  "@%ability);
	return %ability;
}

//���װ��ս���� װ��ID װ����9λ������BUffID ǿ���ȼ� ��������ID ��������ID ��װID
function GetEquipEffectiveness(%EquipID, %ZhuShuxingID, %QiangHuaLv, %ZhuDongSkillID, %BeiDongSkillID, %SuitID)
{
	//echo("%EquipID  ====  "@%EquipID);
	//echo("%ZhuShuxingID  ====  "@%ZhuShuxingID);
	//echo("%QiangHuaLv  ====  "@%QiangHuaLv);
	//echo("%ZhuDongSkillID  ====  "@%ZhuDongSkillID);
	//echo("%BeiDongSkillID  ====  "@%BeiDongSkillID);
	//echo("%SuitID  ====  "@%SuitID);
	%EquipLevel = GetItemData(%EquipID, $Item_Data_Lv);//��õ��ߵȼ�
	//echo("%EquipLevel  ====  "@%EquipLevel);
	%itemQuality = GetItemData(%EquipID, $Item_Data_Color);//��õ�����ɫƷ��
	//echo("%itemQuality  ====  "@%itemQuality);
	%Streng = getItemBaseStats(%QiangHuaLv)/10000;//ǿ���ȼ���Ӧϵ��
	//echo("%Streng  ====  "@%Streng);
	%AttributeLV = %ZhuShuxingID % 100;//װ�������Եȼ�
	//echo("%AttributeLV  ====  "@%AttributeLV);
	%Shenqi = 0;
	%zhudongSkill = 0;
	%BeiDongSkill = 0;
	%SuitID=0;
	if (CheckBit(GetItemData(%itemid, $Item_Data_Type), 15) == 1)	%Shenqi = 50;//�ж��Ƿ�Ϊ����
	if (%ZhuDongSkillID>0) %zhudongSkill=1;
	if (%BeiDongSkillID>0) %BeiDongSkill=1;
	if (%SuitID>0) %SuitID=1;
	%JiChuZhanli =11.25 *mpow(1.01777073, %AttributeLV)*3;
	if (%EquipLevel < 15) %XiShu1 = 1;
	else if (%EquipLevel <30) %XiShu1 = 1.584;
	else if (%EquipLevel >=30)
	{
		switch (mfloor(%EquipLevel/10) *10)
		{
			case 30:%XiShu1 		= 2.09088;
			case 40:%XiShu1 		= 2.7599616;
			case 50:%XiShu1 		= 3.643149312;
			case 60:%XiShu1 		= 4.808957092;
			case 70:%XiShu1 		= 6.347823361;
			case 80:%XiShu1 		= 8.379126837;
			case 90:%XiShu1 		= 11.06044742;
			case 100:%XiShu1		= 14.5997906;
			case 110:%XiShu1		= 15.41737887;
			case 120:%XiShu1		= 16.28075209;
			case 130:%XiShu1		= 18.26700385;
			case 140:%XiShu1		= 21.70120057;
			case 150:%XiShu1		= 28.64558475;
			default:%XiShu1 = 2.09088;
		}
	}
	//echo("aaaaaaaaaaaaa ======  "@11.25 *mpow(1.01777073, %AttributeLV));
	//echo("%JiChuZhanli  ====  "@%JiChuZhanli);
	%JiChuZhanDouLi = %JiChuZhanli * %XiShu1 * %Streng;
	//echo("%JiChuZhanDouLi  ====  "@%JiChuZhanDouLi);
	%itemQuality[1] = 1;
	%itemQuality[2] = 1;
	%itemQuality[3] = 1.356417402;
	%itemQuality[4] = 1.379901127;
	%itemQuality[5] = 1.477972777;
	%itemQuality[6] = 1.556074135;
	%itemQuality[7] = 1.666666667;
	%QiTaZhanLi = (%Shenqi+(%zhudongSkill+%BeiDongSkill)*15+%SuitID*5)*(%EquipLevel/10)*%itemQuality[%itemQuality];
	%ability = %JiChuZhanDouLi + %QiTaZhanLi;
	//echo("%ability  ====  "@%ability);
	return %ability;
}




//��ü������Ե�ս���� װ���ȼ� �ü�������buffid �Ƿ�Ϊר����1Ϊר 0Ϊ��ͨ��
function GetIdentifyEffectiveness(%EquipLv, %Buffid, %isExclusiveBuff)
{
	//echo("%EquipLv  ====  "@%EquipLv);
	//echo("%Buffid  ====  "@%Buffid);
	//echo("%isExclusiveBuff  ====  "@%isExclusiveBuff);
	%isExclusive = 0.5;
	%ManZhi =0;
	%MaxNum = %EquipLv *1.5;//������ֵ
	%BuffLv = %Buffid % 1000;//��ȡ���������Ե�Buff�ȼ�
	if (%MaxNum == %BuffLv) %ManZhi =1;//��ֵ
	if (%isExclusiveBuff==1)//ר��
		%isExclusive = 1;
	%ZhanLi = %BuffLv * %isExclusive + %ManZhi *(%EquipLv/10)*(1+%isExclusiveBuff);
	//echo("%ZhanLi  ====  "@%ZhanLi);
	return %ZhanLi;
}

//��ø������Ե�ս���� װ���ȼ� ��X����������
function GetStrengAwardBuff(%EquipLv, %times)
{
	switch (%times)
	{
		case 1: %num = 0.56;
		case 2: %num = 0.70;
		case 3: %num = 0.91;
		default:%num = 0.56;
	}
	%ZhanLi = (%EquipLv * 1.5 * %num);
	return %ZhanLi;
}

//���ʱװս����
function GetFashionEffectiveness(%ItemID, %ZhuShuxingID)
{
	%ItemLevel = GetItemData(%ItemID, $Item_Data_Lv);//��õ��ߵȼ�
	%itemQuality = GetItemData(%ItemId, $Item_Data_Color);//��õ�����ɫƷ��
	%AttributeLV = %ZhuShuxingID % 100-17;
	if (%AttributeLV<0)%AttributeLV=0;//������ĩ��λ-17��Сȡ0
	%Streng = getItemBaseStats(%QiangHuaLv)/10000;//ǿ���ȼ�����ϵ��
	%ability = (%ItemLevel+%AttributeLV+%itemQuality);
	return %ability;
}

//�������ս����
function GetStarEffectiveness(%YanSeLevel, %XinJiLevel)
{
	//��ɫ�ȼ�
	if (%YanSeLevel == 4)%DianS = 15 * 1;
	else if (%YanSeLevel == 5)%DianS = 15 * 2;
	else %DianS = 0;

	//�Ǽ�
	%DianS = %DianS + %XinJiLevel;

	return 0;
}

//���ʱװ��λս����
function GetFashionListEffectiveness(%LanWei)
{
	if (%LanWei <= 5)
		%DianS = 0;
	else
		%DianS = %LanWei - 5;

	return 0;
}


//��þ���ս����
function GetVenationEffectiveness(%Num)
{
	%DianS = %Num;
	return 0;
}

//��������λս����
function GetFetchListEffectiveness(%LanWeiNum)
{
	if (%LanWeiNum <= 1)
		%DianS = 0;
	else
		%DianS = %LanWeiNum - 1;

	return 0;
}

//������ȼ�ս����
function GetFetchLevelEffectiveness(%WuHunLevel)
{
	%DianS = %WuHunLevel;

	return 0;
}

//��������ɫս����
function GetFetchEffectiveness(%YanSeLevel)
{
	//��ɫ�ȼ�
	if (%YanSeLevel == 3)%DianS = 1;
	else if (%YanSeLevel == 4)%DianS = 2;
	else if (%YanSeLevel == 5)%DianS = 3;
	else if (%YanSeLevel == 6)%DianS = 4;
	else %DianS = 0;

	return 0;
}

//��ó���ս����
function GetPetEffectiveness(%ChengZhang, %Level, %Pingjie, %BianYi, %ZiZhi, %JiNeng)
{
	//����ɳ���
	if ((%ChengZhang >= 18) && (%ChengZhang < 840))%DianS = 1;
	else if ((%ChengZhang >= 840) && (%ChengZhang < 1560))%DianS = 2;
	else if ((%ChengZhang >= 1560) && (%ChengZhang < 2220))%DianS = 3;
	else if ((%ChengZhang >= 2220) && (%ChengZhang < 2860))%DianS = 5;
	else if ((%ChengZhang >= 2860) && (%ChengZhang < 3300))%DianS = 8;
	else if (%ChengZhang >= 3300)%DianS = 12;

	//����ȼ�
	%DianS = %DianS + mfloor(%Level / 10);

	//����Ʒ��
	%DianS = %DianS + %Pingjie;

	//�������
	%DianS = %DianS + %BianYi - 1;

	//��������
	%DianS = %DianS + %ZiZhi;

	//���＼��
	%DianS = %DianS + %JiNeng;

	return 0;
}

//�������ս����
function GetMountEffectiveness(%ShuDu)
{
	if (%ShuDu <= 4000) %DianS = 1;
	else if (%ShuDu <= 6000) %DianS = 2;
	else if (%ShuDu <= 7000) %DianS = 3;
	else if (%ShuDu <= 8000) %DianS = 4;
	else %DianS = 4;

	return 0;
}

//��û���ս����
function GetGodEffectiveness(%DataID, %Jingjie, %Level)
{
	//����dataid
	if (%DataID <= 4) %DianS = 1;
	else if (%DataID <= 9) %DianS = 2;
	else if (%DataID <= 14) %DianS = 3;
	else if (%DataID <= 19) %DianS = 4;
	else if (%DataID <= 24) %DianS = 5;
	else if (%DataID <= 29) %DianS = 6;

	//���񾳽�
	%DianS = %DianS + %Jingjie;

	return 0;
}

//��ù�ְս���������ã�
function GetOfficialTitleEffectiveness(%WuGuan, %WenGuan)
{
	return 0;
}

//���VIP�ȼ�ս����
function GetVipLevelEffectiveness(%VipLeve)
{
	for (%i = 1; %i <= 34; %i++)
	{
		if (%VipLeve < $VIPLiBaoDaPaiSong_Gotgold[%i])
		{
			%DianS = %i - 1;
			break;
		}
		else
			%DianS = 34;
	}

	return 0;
}

//�������Ȩս����
function GetIsVipEffectiveness(%Vip1, %vip2)
{
	%DianS = (%Vip1 * 2) + (%Vip2 * 5);

	return 0;
}


//���������������������������ս��������ء���������������������������������


//�������������������������۱��衿��ء�������������������������������������
function GetGodNumForJingYuan(%Player, %Num)
{
	if (%Num == 0) return "0 500000";
	else if (%Num == 1) return "80 1000000";
	else if (%Num == 2) return "90 1000000";
	else if (%Num == 3) return "110 1000000";
	else if (%Num == 4) return "130 1000000";
	else if (%Num == 5) return "150 1000000";
	else if (%Num == 6) return "170 1000000";
	else if (%Num == 7) return "200 1000000";
	else if (%Num == 8) return "240 1000000";
	else if (%Num == 9) return "270 1000000";
	else if (%Num == 10) return "320 1000000";
	else if (%Num == 11) return "370 1000000";
	else if (%Num == 12) return "440 1000000";
	else if (%Num == 13) return "510 1000000";
	else if (%Num == 14) return "590 1000000";
	else if (%Num == 15) return "690 1000000";
	else if (%Num == 16) return "810 1000000";
	else if (%Num == 17) return "940 1000000";
	else if (%Num == 18) return "1100 1000000";
	else if (%Num == 19) return "1290 1000000";
	else if (%Num == 20) return "1500 1000000";

	return -1;
}

//��þ۱���ÿ��������
function GetGodNumForMaxCnt(%Player)
{
	return VIP_getNowTequanLvMaxCnt(%Player, 4)*1;
}
//�������������������������۱��衿��ء�������������������������������������


//��������������������������������ء���������������������������������������
//���ݱ�ʯ���ص�ǰս����
//���ݱ�ʯ���ص�ǰ����
//���ݴ����ȼ����ص�ǰս����
//���ݴ����ȼ����ص�ǰ����
//����Ѩλ���׵���ɫ
//���ݵ�ǰ�׶θ����ĵ���ƷID�������Ӵ����ľ���ֵ
//���ݵ�ǰ���鷵���Ҽ��ܵ��������ֵ����ǰ�����ɫ����Ӧ���ж��ټ��ܵ㣩
//���ص�ǰ�׶������ֵ

//���ݱ�ʯ���ص�ǰս����
function GetVenationEffectivenessByGem(%gemlevel, %iscolor)
{
	//%gemlevel ��ʯ�ȼ� %iscolor �Ƿ���3ɫʯ 1����    0������
	if (%iscolor == 1)
	{
		switch (%gemlevel)
		{
			case 1:return 3;
			case 2:return 6;
			case 3:return 9;
			case 4:return 12;
			case 5:return 15;
			case 5:return 18;
		}
	}
	else if (%iscolor == 0)
	{
		switch (%gemlevel)
		{
			case 1:return 1;
			case 2:return 2;
			case 3:return 3;
			case 4:return 4;
			case 5:return 5;
			case 5:return 6;
		}
	}
}
//���ݱ�ʯ���ص�ǰ����
function GetVenationTopActivityByGem(%gemlevel, %iscolor)
{
	//%gemlevel ��ʯ�ȼ� %iscolor �Ƿ���3ɫʯ 1����    0������
	if (%iscolor == 1)
	{
		switch (%gemlevel)
		{
			case 1:return 60;
			case 2:return 180;
			case 3:return 450;
			case 4:return 1128;
			case 5:return 2820;
			case 5:return 3666;
		}
	}
	else if (%iscolor == 0)
	{
		switch (%gemlevel)
		{
			case 1:return 20;
			case 2:return 60;
			case 3:return 150;
			case 4:return 376;
			case 5:return 940;
			case 5:return 1222;
		}
	}
}

//���ݴ����ȼ����ص�ǰս����
function GetVenationEffectivenessByLevel(%level)
{
	//%level�����ȼ�
	switch (%level)
	{
		case 1: return 1;
		case 2: return 2;
		case 3: return 3;
		case 4: return 4;
		case 5: return 5;
		case 6: return 7;
		case 7: return 9;
		case 8: return 11;
		case 9: return 13;
		case 10: return 15;
		case 11: return 18;
		case 12: return 21;
		case 13: return 24;
		case 14: return 27;
		case 15: return 30;
		case 16: return 34;
		case 17: return 38;
		case 18: return 42;
		case 19: return 46;
		case 20: return 50;
		case 21: return 55;
		case 22: return 60;
		case 23: return 65;
		case 24: return 70;
		case 25: return 75;
	}

	return 0;
}

//���ݴ����ȼ����ص�ǰ����
function GetVenationTopActivityByLevel(%level)
{
	//%level�����ȼ�
	switch (%level)
	{
		case 1: return 1;
		case 2: return 2;
		case 3: return 3;
		case 4: return 5;
		case 5: return 7;
		case 6: return 10;
		case 7: return 14;
		case 8: return 19;
		case 9: return 25;
		case 10: return 33;
		case 11: return 43;
		case 12: return 56;
		case 13: return 73;
		case 14: return 96;
		case 15: return 126;
		case 16: return 165;
		case 17: return 216;
		case 18: return 283;
		case 19: return 371;
		case 20: return 486;
		case 21: return 637;
		case 22: return 835;
		case 23: return 1095;
		case 24: return 1436;
		case 25: return 1883;
	}
}

//����Ѩλ���׵���ɫ
function GetRandomPrintTrough(%slot, %count)
{
	//%slot,Ѩλλ��		%count,ɢѨ����

	if (%slot == 0)
	{
		%CountNum = %Count * 1000;
		%RandomA = GetRandom(1, 10000);

		if (%RandomA <= (500 + %CountNum))
			return 4;

		%RandomB = GetRandom(1, 10000);
		if (%RandomB <= 750) return 3;
		if (%RandomB <= 6750) return 2;
		if (%RandomB <= 10000) return 1;
	}
	else if (%slot == 1)
	{
		%CountNum = %Count * 1000;
		%RandomA = GetRandom(1, 10000);

		if (%RandomA <= (1000 + %CountNum))
			return 4;

		%RandomB = GetRandom(1, 10000);
		if (%RandomB <= 1250) return 3;
		if (%RandomB <= 6750) return 2;
		if (%RandomB <= 10000) return 1;
	}
	else if (%slot == 2)
	{
		%CountNum = %Count * 1000;
		%RandomA = GetRandom(1, 10000);

		if (%RandomA <= (1500 + %CountNum))
			return 4;

		%RandomB = GetRandom(1, 10000);
		if (%RandomB <= 1750) return 3;
		if (%RandomB <= 6750) return 2;
		if (%RandomB <= 10000) return 1;
	}
	else if (%slot == 3)
	{
		%CountNum = %Count * 1000;
		%RandomA = GetRandom(1, 10000);

		if (%RandomA <= (2000 + %CountNum))
			return 4;

		%RandomB = GetRandom(1, 10000);
		if (%RandomB <= 2250) return 3;
		if (%RandomB <= 6750) return 2;
		if (%RandomB <= 10000) return 1;
	}
	else if (%slot == 4)
	{
		%CountNum = %Count * 1000;
		%RandomA = GetRandom(1, 10000);

		if (%RandomA <= (2500 + %CountNum))
			return 4;

		%RandomB = GetRandom(1, 10000);
		if (%RandomB <= 2750) return 3;
		if (%RandomB <= 6750) return 2;
		if (%RandomB <= 10000) return 1;
	}
	else if (%slot == 5)
	{
		%CountNum = %Count * 1000;
		%RandomA = GetRandom(1, 10000);

		if (%RandomA <= (500 + %CountNum))
			return 4;

		%RandomB = GetRandom(1, 10000);
		if (%RandomB <= 750) return 3;
		if (%RandomB <= 6750) return 2;
		if (%RandomB <= 10000) return 1;
	}
	else if (%slot == 6)
	{
		%CountNum = %Count * 1000;
		%RandomA = GetRandom(1, 10000);

		if (%RandomA <= (1000 + %CountNum))
			return 4;

		%RandomB = GetRandom(1, 10000);
		if (%RandomB <= 1250) return 3;
		if (%RandomB <= 6750) return 2;
		if (%RandomB <= 10000) return 1;
	}
	else if (%slot == 7)
	{
		%CountNum = %Count * 1000;
		%RandomA = GetRandom(1, 10000);

		if (%RandomA <= (1500 + %CountNum))
			return 4;

		%RandomB = GetRandom(1, 10000);
		if (%RandomB <= 1750) return 3;
		if (%RandomB <= 6750) return 2;
		if (%RandomB <= 10000) return 1;
	}
	else if (%slot == 8)
	{
		%CountNum = %Count * 1000;
		%RandomA = GetRandom(1, 10000);

		if (%RandomA <= (2000 + %CountNum))
			return 4;

		%RandomB = GetRandom(1, 10000);
		if (%RandomB <= 2250) return 3;
		if (%RandomB <= 6750) return 2;
		if (%RandomB <= 10000) return 1;
	}
	else if (%slot == 9)
	{
		%CountNum = %Count * 1000;
		%RandomA = GetRandom(1, 10000);

		if (%RandomA <= (2500 + %CountNum))
			return 4;

		%RandomB = GetRandom(1, 10000);
		if (%RandomB <= 2750) return 3;
		if (%RandomB <= 6750) return 2;
		if (%RandomB <= 10000) return 1;
	}

	return 1;
}

//���ݵ�ǰ�׶θ����ĵ���ƷID�������Ӵ����ľ���ֵ
function GetRefinePrintPhaseAddExp(%phase, %itemid)
{
	//%phase,�׶�		%itemid,��ƷID

	%Random = GetRandom(1, 5);
	return %Random;
}

//���ݵ�ǰ���鷵���Ҽ��ܵ��������ֵ����ǰ�����ɫ����Ӧ���ж��ټ��ܵ㣩
function getRefinePrintSkillPoint(%exp)
{
	//%exp,��ǰ�����ľ���

	if (%exp >= 71090) return 25;
	if (%exp >= 54185) return 24;
	if (%exp >= 41300) return 23;
	if (%exp >= 31480) return 22;
	if (%exp >= 23995) return 21;
	if (%exp >= 18290) return 20;
	if (%exp >= 13940) return 19;
	if (%exp >= 10625) return 18;
	if (%exp >= 8100) return 17;
	if (%exp >= 6175) return 16;
	if (%exp >= 4705) return 15;
	if (%exp >= 3585) return 14;
	if (%exp >= 2730) return 13;
	if (%exp >= 2080) return 12;
	if (%exp >= 1585) return 11;
	if (%exp >= 1205) return 10;
	if (%exp >= 915) return 9;
	if (%exp >= 680) return 8;
	if (%exp >= 490) return 7;
	if (%exp >= 340) return 6;
	if (%exp >= 225) return 5;
	if (%exp >= 140) return 4;
	if (%exp >= 80) return 3;
	if (%exp >= 40) return 2;
	if (%exp >= 15) return 1;

	return 0;
}

//���ص�ǰ�׶������ֵ
function getRefinePrintPhaseMaxExp(%phase)
{
	//%phase,��ǰ�׶�

	switch (%phase)
	{
		case 1: return 225;
		case 2: return 980;
		case 3: return 3500;
		case 4: return 66385;
	}

	return 71090;
}

//���ػ����һ���������辭��
function GetCanGetPointToTalExp(%exp)
{
	//%exp,��ǰ����

	if (%exp < 15) return %exp @ "/" @ 15;
	if (%exp < 40) return %exp @ "/" @ 40;
	if (%exp < 80) return %exp @ "/" @ 80;
	if (%exp < 140) return %exp @ "/" @ 140;
	if (%exp < 225) return %exp @ "/" @ 225;
	if (%exp < 340) return %exp @ "/" @ 340;
	if (%exp < 490) return %exp @ "/" @ 490;
	if (%exp < 680) return %exp @ "/" @ 680;
	if (%exp < 915) return %exp @ "/" @ 915;
	if (%exp < 1205) return %exp @ "/" @ 1205;
	if (%exp < 1585) return %exp @ "/" @ 1585;
	if (%exp < 2080) return %exp @ "/" @ 2080;
	if (%exp < 2730) return %exp @ "/" @ 2730;
	if (%exp < 3585) return %exp @ "/" @ 3585;
	if (%exp < 4705) return %exp @ "/" @ 4705;
	if (%exp < 6175) return %exp @ "/" @ 6175;
	if (%exp < 8100) return %exp @ "/" @ 8100;
	if (%exp < 10625) return %exp @ "/" @ 10625;
	if (%exp < 13940) return %exp @ "/" @ 13940;
	if (%exp < 18290) return %exp @ "/" @ 18290;
	if (%exp < 23995) return %exp @ "/" @ 23995;
	if (%exp < 31480) return %exp @ "/" @ 31480;
	if (%exp < 41300) return %exp @ "/" @ 41300;
	if (%exp < 54185) return %exp @ "/" @ 54185;
	if (%exp < 71090) return %exp @ "/" @ 71090;

	return "�����������";
}

function JinMaiPointHoleColor(%slot, %count)
{
	//%slot,Ѩλ		%count,ɢѨ����

	if (%slot == 1){ %JiLv = %Count * 10; }
	else if (%slot == 2){ %JiLv = %Count * 10; }
	else if (%slot == 3){ %JiLv = %Count * 10; }
	else if (%slot == 4){ %JiLv = %Count * 10; }
	else if (%slot == 5){ %JiLv = %Count * 10; }

	if (%JiLv > 100)
		return "100%";

	return %JiLv @ "%";
}

//����������������������������ǿ������ء�����������������������������������
//ǿ����õ�״̬
//ǿ����õ���Ч

//ǿ����õ�״̬
function AllEquipPerfectStrengthen_GetBuffID(%Level, %ItemNum)
{
	//%Level,ǿ���ȼ�		%ItemNum,װ������

	//if ( ( %Level >= 15 ) && ( %ItemNum >= 11 ) ) return 305920015;
	//else if ( ( %Level >= 15 ) && ( %ItemNum >= 8 ) ) return 305920014;
	//else if ( ( %Level >= 15 ) && ( %ItemNum >= 6 ) ) return 305920013;
	//
	//else if ( ( %Level >= 12 ) && ( %ItemNum >= 11 ) ) return 305920012;
	//else if ( ( %Level >= 12 ) && ( %ItemNum >= 8 ) ) return 305920011;
	//else if ( ( %Level >= 12 ) && ( %ItemNum >= 6 ) ) return 305920010;
	//
	//else if ( ( %Level >= 9 ) && ( %ItemNum >= 11 ) ) return 305920009;
	//else if ( ( %Level >= 9 ) && ( %ItemNum >= 8 ) ) return 305920008;
	//else if ( ( %Level >= 9 ) && ( %ItemNum >= 6 ) ) return 305920007;
	//
	//else if ( ( %Level >= 6 ) && ( %ItemNum >= 11 ) ) return 305920006;
	//else if ( ( %Level >= 6 ) && ( %ItemNum >= 8 ) ) return 305920005;
	//else if ( ( %Level >= 6 ) && ( %ItemNum >= 6 ) ) return 305920004;
	//
	//else if ( ( %Level >= 3 ) && ( %ItemNum >= 11 ) ) return 305920003;
	//else if ( ( %Level >= 3 ) && ( %ItemNum >= 8 ) ) return 305920002;
	//else if ( ( %Level >= 3 ) && ( %ItemNum >= 6 ) ) return 305920001;

	return 0;
}

//ǿ����õ���Ч
function AllEquipPerfectStrengthen_GetEffectID(%Level, %ItemNum)
{
	//%Level,ǿ���ȼ�		%ItemNum,װ������
	//echo("%ItemNum == " @ %ItemNum @ "  %Level==" @ %Level);
	if (%ItemNum < 9)return;
	switch (%Level)
	{
		case 3:%packet = 690794;//��ɫ�⻷ 
		case 4:%packet = 690795;//��ɫ�⻷ 
		case 5:%packet = 690801;//��ɫ�⻷ 
		case 6:%packet = 690797;//��ɫ�⻷ 
		case 7:%packet = 690798;//��ɫ�⻷ 
		case 8:%packet = 690796;//��ɫ�⻷ 
		case 9:%packet =  630201;//�����⻷ 
		case 10:%packet = 630202;//�����⻷ 
		case 11:%packet = 630203;//�����⻷ 
		case 12:%packet = 630179;//�����⻷ 
		case 13:%packet = 630204;//�����⻷
		case 14:%packet = 630204;//�����⻷
		case 15:%packet = 630204;//�����⻷
		default:%packet = 0;
	}
	return %packet;
}

//����������������������������ǿ������ء�����������������������������������

//��������������������������ɫʯ�ϳɡ���ء���������������������������������
//���ݱ�ʯ�ȼ���úϳɵ���ɫ��ʯid

//���ݱ�ʯ�ȼ���úϳɵ���ɫ��ʯid
function getThreeGemItemId(%level)
{
	%id[1] = 110040001;
	%id[2] = 110040002;
	%id[3] = 110040003;
	%id[4] = 110040004;
	%id[5] = 110040005;
	%id[6] = 110040006;
	%id[7] = 110040007;
	%id[8] = 110040008;
	%id[9] = 110040009;
	%id[10] = 110040010;

	return %id[%level];
}
//��������������������������ɫʯ�ϳɡ���ء���������������������������������




//��������������������������ʯ����ء���������������������������������������

//��������������������������ʯ��������������װ����ס�������
//��������������������������ʯ��������������ժȡ��ʯ��������
//��������������������������ʯ����������������ʯ�ϳɡ�������
//��������������������������ʯ����������������Ƭ�ϳɡ�������
//��������������������������ʯ����������������ʯ������������
//��������������������������ʯ����������������ʯ������������

//��������������������������ʯ��������������װ����ס�������
// װ����׽������
function GetEquipPunchHoleCostBindMoney(%level, %openHoleNum, %allowNum)
{

	if (%openHoleNum >= %allowNum)
		return 0;
	%money = 100 * Mpow(1.02, %level) * (1+%openHoleNum / 6) * (1 + %allowNum /3);
	return %money;
}

//װ����ײ��ϱ�ŷ���
function getPunchHoleSymbolID(%level)
{
	%Level = mfloor(%Level/10);
	switch (%Level)
	{
		case 5:	return 116030002;
		case 6:	return 116030002;
		case 7:	return 116030003;
		case 8:	return 116030004;
		case 9:return 116030005;
		default:
			if (%Level < 5)
				return 116030001;
			else
				return 116030005;
	}
}

//װ����������������
function GetEquipPunchHoleCostItemNum(%equipLevel)
{
	if (%equipLevel>90) return 2;
	return 1;
}

//��ȡװ�����Ԫ��������ߵ�Ԫ������
function GetEquipPunchHoleCostMoney(%level)
{
	%Level = mfloor(%Level/10);
	switch (%Level)
	{
		case 5:	return 100;
		case 6:	return 100;
		case 7:	return 1000;
		case 8:	return 2000;
		case 9: return 2800;
		default:
			if (%Level < 5)
				return 50;
			else
				return 5600;
	}
}

//װ����׳ɹ��ʣ���Ҵ�����ġ�������Ԫ�����100%�ɹ���
function GetEquipPunchHoleSuceessRate(%nHoles)
{
	switch (%nHoles)
	{
		case 0:		return 3000;	// 30%
		case 1:		return 2000;	// 20%
		case 2:		return 500;		// 5%
		case 3:		return 200;		// 2%
		case 4:		return 100;		// 1%
		case 5:		return 50;		// 0.05%
		case 6:		return 50;		// 0.05%
		case 7:		return 50;		// 0.05%
	}
	return 0;
}
//��������������������������ʯ��������������װ����ס�������

//��������������������������ʯ��������������ժȡ��ʯ��������
//��ȡװ��ժȡ��ʯ ��ʯ��Ƕ�����ĵĽ������ ��ʯ��Ƕ�����Ľ��
function YBToEquipGemUnmount(%level)
{
	switch (%level)
	{
		case 1:return 1250;
		case 2:return 2500;
		case 3:return 15800;
		case 4:return 56000;
		case 5:return 100000;
		case 6:return 200000;
	}
	return 200000;
}
//��������������������������ʯ��������������ժȡ��ʯ��������

//��������������������������ʯ����������������ʯ�ϳɡ�������
//��ʯ�ϳ��������ID
function GetGemComposeSymbolID(%level)
{
	if (%level == 1) return 105090411;
	else if (%level == 2) return 105090412;
	else if (%level == 3) return 105090413;
	else if (%level == 4) return 105090414;
	else if (%level == 5) return 105090415;
	return 105090416;
}

//��ȡ��ʯ�ϳɷ����� %level ���뱦ʯ�ȼ�
function getGemComposeSymbolNum(%level)
{
	switch (%level)
	{
		case 1: return 1;
		case 2: return 1;
		case 3: return 1;
		case 4: return 1;
		case 5: return 1;
		case 6: return 5;
		case 7: return 7;
		case 8: return 10;
		case 9: return 15;
	}
	return 15;
}

//��ʯ�ϳɱ�ʯԪ������ϳɾ����� // ������ĵȼ�
function YBToComposeGem(%DestGemLevel)
{
	switch (%DestGemLevel)
	{
		case 2: return 80;
		case 3: return 400;
		case 4: return 2000;
		case 5: return 2500;
		case 6: return 12500;
		case 7: return 62500;
		case 8: return 87500;
		case 9: return 125000;
		case 10: return 187500;
	}
}

//��ʯ�ϳɱ�ʯ�������
function getGemComposeBaseRate(%itemID)
{
	%itemLevel = GetItemData(%itemID, $Item_Data_Lv);//��õ��ߵȼ�
	switch (%itemLevel)
	{
		case 1: return 1580;
		case 2: return 20000;
		case 3: return 50000;
		case 4: return 100000;
		case 5: return 200000;
		case 6: return 300000;
		case 7: return 400000;
		case 8: return 500000;
		case 9: return 1000000;
		default:return 1000000;
	}
}

//��ȡ��ʯ�ϳɱ�ʯ������Ӧ����
function getGemComposeSucceed(%playerid, %itemid, %itemNum)
{
	//echo( " %playerid ===" @  %playerid @ "    %itemid==" @  %itemid @ "     %itemNum==" @  %itemNum );
	if ($Now_Script == 2)
		%Player = SptGetPlayer(%playerid);
	else if ($Now_Script == 1)
		%Player = GetPlayer();

	%itemLevel = GetItemData(%itemid, $Item_Data_Lv);//��õ��ߵȼ�
	%goodluck = %Player.getLuck();//��ȡ��Ҹ�Եֵ
	if (%goodluck <100)%goodluck = 0;
	switch (%itemNum)
	{
		case 2: %MaxSucceed = 4000; %MinSucceed = 3000; %ShowMaxSucceed = 5000;
		case 3: %MaxSucceed = 6000; %MinSucceed = 4500; %ShowMaxSucceed = 7000;
		case 4: %MaxSucceed = 8000; %MinSucceed = 6000; %ShowMaxSucceed = 9000;
		case 5: %MaxSucceed =10000; %MinSucceed =10000; %ShowMaxSucceed = 10000;
	}

	if ($Now_Script == 1)//�ͻ�����ʾ
	{
		%Result =mfloor(%MaxSucceed + (%goodluck / (500 * (1 + %itemLevel / 10))*(%ShowMaxSucceed - %MaxSucceed)));
		if (%Result > %ShowMaxSucceed) %Result = %ShowMaxSucceed;
	}
	else if ($Now_Script == 2)//�����ʵ�ʵ���
	{
		%Result = mfloor(%MinSucceed + (%goodluck / (500 * (1 + %itemLevel / 10))*(%MaxSucceed - %MinSucceed)));
		if (%Result > %MaxSucceed) %Result = %MaxSucceed;
	}
	//echo( "��ʯ�ϳ�%Result=====" @ %Result );
	return %Result;
}

//��������������������������ʯ����������������ʯ�ϳɡ�������

//��������������������������ʯ����������������Ƭ�ϳɡ�������
//��ȡ��Ƭ�ϳɱ�ʯ�����ĵ�Ԫ������ 
function YBToComposeGemChip(%DestGemItemID)
{
	%ItemLevel = GetItemData(%DestGemItemID, 25);
	switch (%ItemLevel)
	{
		case 2: return 80;
		case 3: return 800;
		case 4: return 6000;
		case 5: return 2500;
		case 6: return 25000;
		case 7: return 187500;
		case 8: return 87500;
		case 9: return 562500;
		case 10:return 3000000;
		default:return 3000000;

	}
}

//��ʯ��Ƭ�ϳ���Ϸ������
function getGemChipComposePrice(%level)
{
	switch (%level)
	{
		case 2: return 1580;
		case 3: return 27900;
		case 4: return 189500;
		case 5: return 100000;
		case 6: return 700000;
		case 7: return 3800000;
		case 8: return 400000;
		case 9: return 2500000;
		case 10: return 13500000;
	}
}

//��ʯ��Ƭ�ϳ��������-��ʯ�ϳɾ�
function getGemChipComposeMaterailID(%level)
{
	if (%level == 2) return 105090411;
	else if (%level == 3) return 105090412;
	else if (%level == 4) return 105090413;
	else if (%level == 5) return 105090414;
	return 105090416;
}

//����Ƭ�ϳɡ��ϳɱ�ʯ�������-��ʯ�ϳɾ������
function getGemChipMaterialNum(%level)
{
	if (%level == 2) return 1;
	else if (%level == 3) return 2;
	else if (%level == 4) return 3;
	else if (%level == 5) return 1;
	else if (%level == 6) return 2;
	else if (%level == 7) return 15;
	else if (%level == 8) return 7;
	else if (%level == 9) return 45;
	else if (%level ==10) return 240;
	return 250;
}

//��ñ�ʯ��Ƭid
function getGemChipId(%level)
{
	switch (%level)
	{
		case 2: return 110110001;
		case 3: return 110110001;
		case 4: return 110110001;
		case 5: return 110110002;
		case 6: return 110110002;
		case 7: return 110110002;
		case 8: return 110110003;
		case 9: return 110110003;
		case 10: return 110110003;
	}
}

//��ȡ�ϳ���Ҫ��ʯ��Ƭ�ĸ���
function getGemChipNum(%level)
{
	switch (%level)
	{
		case 2: return 5;
		case 3: return 25;
		case 4: return 125;
		case 5: return 5;
		case 6: return 25;
		case 7: return 125;
		case 8: return 5;
		case 9: return 25;
		case 10: return 125;
	}
}
//��������������������������ʯ����������������Ƭ�ϳɡ�������


//��������������������������ʯ����������������ʯ������������


//��ʯ������ʾ���飬1������ʯ��2�챦ʯ��3�̱�ʯ��4����ʯ

//����ʯ                         		�̱�ʯ                         		�챦ʯ                         		//������ʯ															
$GetGemTypeNum[4, 1] = 110030001; $GetGemTypeNum[3, 1] = 110020001; $GetGemTypeNum[2, 1] = 110010001; $GetGemTypeNum[1, 1] = 110010501;
$GetGemTypeNum[4, 2] = 110030011; $GetGemTypeNum[3, 2] = 110020011; $GetGemTypeNum[2, 2] = 110010011; $GetGemTypeNum[1, 2] = 110010511;
$GetGemTypeNum[4, 3] = 110030021; $GetGemTypeNum[3, 3] = 110020021; $GetGemTypeNum[2, 3] = 110010021; $GetGemTypeNum[1, 3] = 110010521;
$GetGemTypeNum[4, 4] = 110030031; $GetGemTypeNum[3, 4] = 110020031; $GetGemTypeNum[2, 4] = 110010031; $GetGemTypeNum[1, 4] = 110010531;
$GetGemTypeNum[4, 5] = 110030041; $GetGemTypeNum[3, 5] = 110020041; $GetGemTypeNum[2, 5] = 110010041; $GetGemTypeNum[1, 5] = 110010541;
$GetGemTypeNum[4, 6] = 110030051; $GetGemTypeNum[3, 6] = 110020051; $GetGemTypeNum[2, 6] = 110010051; $GetGemTypeNum[1, 6] = 110010551;
$GetGemTypeNum[4, 7] = 110030061; $GetGemTypeNum[3, 7] = 110020061; $GetGemTypeNum[2, 7] = 110010061; $GetGemTypeNum[1, 7] = 110010561;
$GetGemTypeNum[4, 8] = 110030071; $GetGemTypeNum[3, 8] = 110020071; $GetGemTypeNum[2, 8] = 110010071; $GetGemTypeNum[1, 8] = 110010571;
$GetGemTypeNum[4, 9] = 110030081; $GetGemTypeNum[3, 9] = 110020081;	$GetGemTypeNum[2, 9] = 110010081; $GetGemTypeNum[1, 9] = 110010611;
$GetGemTypeNum[4, 10] = 110030091; $GetGemTypeNum[3, 10] = 110020091;	$GetGemTypeNum[2, 10] = 110010091;
$GetGemTypeNum[4, 11] = 110030101; $GetGemTypeNum[3, 11] = 110020101;
$GetGemTypeNum[4, 12] = 110030111; $GetGemTypeNum[3, 12] = 110020111;
$GetGemTypeNum[4, 13] = 110030121;
$GetGemTypeNum[4, 14] = 110030131;
$GetGemTypeNum[4, 15] = 110030141;

//��ʯ������ʾ����
function getGemRecastStoneId(%gemstoneId, %color)
{
	//������ʯ 1 �챦ʯ 2 �̱�ʯ 3 ����ʯ 4
	%BaoShiLV = GetItemData(%gemstoneId, $Item_Data_Lv);
	for (%i = 1; %i<=15; %i++)
	{
		///echo( "$GetGemTypeNum[ %color, %i ]===" @ $GetGemTypeNum[ %color, %i ] );
		if ($GetGemTypeNum[%color, %i] $= "")
			break;
		//echo( "$GetGemTypeNum[ %color,%i ] + %BaoShiLV - 1====" @ $GetGemTypeNum[ %color, %i ] + %BaoShiLV - 1 );
		%ItemList = $GetGemTypeNum[%color, %i] + %BaoShiLV - 1 @ " " @ %ItemList;
	}
	//echo( "%ItemList===" @ %ItemList );
	return %ItemList;
}

//���ر�ʯ��������������ID gemstoneId ��ʯID 0 ������ID 1 �컯��ID �컯��û�õ�
function getGemRecastMaterialId(%gemstoneId, %type)
{
	%Gemlevel = GetItemData(%gemstoneId, $Item_Data_Lv);
	switch (%type)
	{
		case 0://����
			return 105105711 + (%Gemlevel - 1);
		case 1://�컯��
			return 105029001 + (%Gemlevel - 1);
	}
}

//��������ı�ʯ����������������ĵ������� �컯�� ������
function getGemRecastMaterialNum(%gemstoneId, %type)//��Ӧ����
{
	%BaoShiLV = GetItemData(%gemstoneId, $Item_Data_Lv);
	switch (%type)
	{
		case 0:
			return 1;
		case 1:
			return 1;
	}
}

//��ʯ����Ԫ������ %gemstoneId ��ʯID %color��ѡ�ų�ѡ�� %Isusegold�Ƿ�����Ԫ������������(0 ʹ�õ���  1ʹ��Ԫ��)
function getGemRecastGoldNum(%gemstoneId, %colorbit, %Isusegold)
{
	//echo( "%gemstoneId ==" @ %gemstoneId @ "   %colorbit==" @ %colorbit @ "   %Isusegold ==" @ %Isusegold );
	%BaoShiLV = GetItemData(%gemstoneId, $Item_Data_Lv);
	switch (%BaoShiLV)//���ݵȼ���ӻ�����������ʯ������
	{
		case 1: %Money = 100;
		case 2: %Money = 200;
		case 3: %Money = 350;
		case 4: %Money = 1500;
		case 5: %Money = 4500;
		case 6: %Money = 12500;
		case 7: %Money = 16800;
		case 8: %Money = 19800;
		case 9: %Money = 25600;
		case 10:%Money = 51200;
		default:%Money = 51200;
	}
	if (%Isusegold  == 1)//Ԫ����������ʯ����
	{
		%CzsMoney = %Money;
	}
	else
		%CzsMoney = 0;

	%lock1 = 0;
	%lock2 = 0;
	%lock3 = 0;
	%lock4 = 0;

	if (CheckBit(%colorbit, 1) == 1) //�ų�������ʯ
	{
		%lock1 = 1;
	}
	if (CheckBit(%colorbit, 2) == 1) //�ų��챦ʯ
	{
		%lock2 = 1;
	}
	if (CheckBit(%colorbit, 3) == 1) //�ų��̱�ʯ
	{
		%lock3 = 1;
	}
	if (CheckBit(%colorbit, 4) == 1) //�ų�����ʯ
	{
		%lock4 = 1;
	}
	%lock = %lock1+%lock2+%lock3+%lock4;
	switch (%lock)
	{
		case 0: %lockMoney = 1;
		case 1: %lockMoney = 4/3;
		case 2: %lockMoney = 2;
		case 3: %lockMoney = 4;
		default:%lockMoney = 5;
	}
	%allmoney =  mceil(%CzsMoney + %Money*(%lockMoney-1));
	return %allmoney;
}

//��ʯ�������ز�������getGemRecastStoneResultID(��ɫid,��ʯid,bitλ�ų���ʯ���ͣ��컯��id������Ϊ0);
function getGemRecastStoneResultID(%playerid, %gemstoneId, %colorbit, %MaterialsID)
{
	%Player = SptGetPlayer(%playerid);
	%addgailv = GetItemData(%MaterialsID, 17);//��ø������߱����ֶ���дֵ
	%BaoShiLV = GetItemData(%gemstoneId, $Item_Data_Lv);
	//echo( "%BaoShiLV==" @ %BaoShiLV );
	//echo( "%colorbit===" @ %colorbit );
	//echo("%gemstoneId===" @ %gemstoneId);
	//echo("%MaterialsID===" @ %MaterialsID);
	//-------------------�컯������----------------------
	%Random = GetRandom(1, 10000);
	//echo( "%Ran==" @ %Ran );
	//echo( "%Random==" @ %Random );
	if (%Random <= %addgailv && %BaoShiLV < 10)
	{
		%BaoShiLV++;
		%MsgType =4;
	}

	//-------------------��������------------------------
	//echo( "%colorbit==" @ %colorbit );
	%AllNumber = 0;
	for (%i = 1; %i <= 4; %i++)
	{
		if (CheckBit(%colorbit, %i) == 0)
		{
			%AllNumber = $RecordGemRecastStoneTypeAllNumber[%i] + %AllNumber;//���ֵ���������
			%ColorCheck[%i] = 1;//��Ǵ��౦ʯ�����������
		}
		else
			%ColorCheck[%i] = 0;//��Ǵ��౦ʯ�������������
		//echo("%ColorCheck[" @ %i @ "]==" @ %ColorCheck[%i]);
	}
	%RanDom = GetRandom(1, %AllNumber);
	%Ran = 0;
	for (%i = 1; %i <= 99; %i++)
	{
		//echo("$GemRecastStoneChongZhu[" @ %i @ "]===" @ $GemRecastStoneChongZhu[%i]);
		if ($GemRecastStoneChongZhu[%i] $= "")
			break;
		%BaoShiType = GetWord($GemRecastStoneChongZhu[%i], 0);
		//echo("%BaoShiType===" @ %BaoShiType);
		if (%ColorCheck[%BaoShiType] == 1)
		{
			%BaoShiID = GetWord($GemRecastStoneChongZhu[%i], 1);
			%BaoShiRan = GetWord($GemRecastStoneChongZhu[%i], 2);
			%MsgType = GetWord($GemRecastStoneChongZhu[%i], 3);
			%Ran = %Ran + %BaoShiRan;
			//echo("%Ran==" @ %Ran @ "   %BaoShiRan==" @ %BaoShiRan);
			if (%Ran >= %RanDom &&  %BaoShiRan > 0)
			{
				%ItemID = %BaoShiID + %BaoShiLV - 1;
				break;
			}
		}
	}
	if (%MsgType > 0)
	{
		switch (%MsgType)
		{
			case 1:
				if (%BaoShiLV >= 5)
				{
					%Playername2 = GetPlayerZiTiName(%Player, 2);
					%ItemName2 = GetItemName(%ItemID, 2);
					%Msg2 ="<t>���˱��</t>" @ %Playername2 @ "<t>�ڱ�ʯ����ʱ�������</t>" @ %ItemName2 @ "<t>����ɷ�����ˡ�</t>";
					SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg2 @ "</t>", $chatMsg_Type_Normal2);
				}
			case 3:
				%Playername1 = GetPlayerZiTiName(%Player, 1);
				%Playername2 = GetPlayerZiTiName(%Player, 2);
				%ItemName1 = GetItemName(%ItemID, 1);
				%ItemName2 = GetItemName(%ItemID, 2);
				%Msg1 ="<t>���˱��</t>" @ %Playername1 @ "<t>�ڱ�ʯ����ʱ�������</t>" @ %ItemName1 @ "<t>����ɷ�����ˡ�</t>";
				%Msg2 ="<t>���˱��</t>" @ %Playername2 @ "<t>���ڱ�ʯ����ʱ�������</t>" @ %ItemName2 @ "<t>����ɷ�����ˡ�</t>";
				SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Msg1 @ "</t>");
				SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg2 @ "</t>", $chatMsg_Type_Normal2);
			case 4:
				%ItemName = GetItemName(%ItemID, 1);
				%ItemName2 = GetItemName(%ItemID, 2);
				%ItemName3 = GetItemName(%MaterialsID, 1);
				%ItemName4 = GetItemName(%MaterialsID, 2);
				%Lv=GetItemData(%ItemID, $Item_Data_Lv);
				%Playername2 = GetPlayerZiTiName(%Player, 1);
				%Playername3= GetPlayerZiTiName(%Player, 2);
				%Msg2 ="<t>���Ǹ��գ�</t>" @ %Playername2 @ "<t>�ڱ�ʯ����ʱ������</t>" @ %ItemName3 @ "<t>�ɹ�����ʯ������</t>" @ %Lv @ "<t>���������</t>" @ %ItemName;
				%Msg3 ="<t>���˱��</t>" @ %Playername3 @ "<t>�ڱ�ʯ����ʱ������</t>" @ %ItemName4 @ "<t>�ɹ�����ʯ����һ���������</t>" @ %Lv @ "<t>��</t>" @ %ItemName2;
				SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Msg2 @ "</t>");
				SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg3 @ "</t>", $chatMsg_Type_Normal2);
		}
	}
	//echo( "%ItemID===" @ %ItemID @ "    " @ GetItemdata( %ItemID, 1 ) );
	if (GetItemData(%ItemID, 0) > 0)
		return %ItemID;
	else
		return %gemstoneId;
}

//��������������������������ʯ����������������ʯ������������


//��������������������������ʯ����������������ʯ������������
//��ʯ�����������ľ���ID ���ȷ��صͼ���
function getGemPromoteMaterialId(%Player, %gemstoneId)//����
{
	//echo("%Player=====" @ %Player @ "  %gemstoneId====" @ %gemstoneId);
	%Level = GetItemData(%gemstoneId, $Item_Data_Lv);
	%ItemIDMax = 105105500 + (%Level - 1) * 10 + 5;
	%ItemIDMin = 105105500 + (%Level - 1) * 10 + 1;
	%ItemCountNeed = getGemPromoteMaterialNum(%gemstoneId);
	//echo( "%ItemCountNeed====" @ %ItemCountNeed );
	for (%ItemID = %ItemIDMax; %ItemID >= %ItemIDMin; %ItemID--)
	{
		//echo( GetPlayer( ).GetItemCount( %ItemID ) );
		if (%Player.GetItemCount(%ItemID) >= %ItemCountNeed)
			return %ItemID;
	}
	return %ItemIDMin;
}

//��ʯ���� ������������
function getGemPromoteMaterialNum(%gemstoneId)
{
	%Level = GetItemData(%gemstoneId, $Item_Data_Lv);
	//echo( "%Level====" @ %Level );
	switch (%Level)
	{
		case 1: return 1;
		case 2: return 1;
		case 3: return 1;
		case 4: return 2;
		case 5: return 4;
		case 6: return 10;
		case 7: return 20;
		case 8: return 50;
		case 9: return 100;
		case 10: return 100;
		default:	return 100;
	}

}

//���ر�ʯ������� ��ʯID ��������ID
function getGemPromoteResultID(%playerid, %gemstoneId, %UseItemID)
{
	//echo( %gemstoneId @ "   " @ GetItemData( %gemstoneId, 1 ) );
	//echo( %UseItemID @ "   " @ GetItemData( %UseItemID, 1 ) );
	%GaiLv = GetItemData(%UseItemID, 17);//��ȡ�������ߵĸ���
	%SuiJi =  GetRandom(1, 10000);
	%Level = GetItemData(%gemstoneId, $Item_Data_Lv);
	%Player = SptGetPlayer(%playerid);
	//echo( "%GaiLv===" @ %GaiLv );
	if (%Level < 10)
	{
		if (%SuiJi < %GaiLv)
		{
			%Result = %gemstoneId + 1;
			if (%Level+1>=4)
			{
				%ItemName = GetItemName(%Result, 1);
				%ItemName2 = GetItemName(%Result, 2);
				%Playername2 = GetPlayerZiTiName(%Player, 1);
				%Playername3= GetPlayerZiTiName(%Player, 2);
				%Msg2 ="<t>�����콵</t>" @ %Playername2 @ "<t>��ʯ�����ɹ��������</t>" @ %ItemName;
				%Msg3 ="<t>�����콵</t>" @ %Playername3 @ "<t>��ʯ�����ɹ��������</t>" @ %ItemName2;
				SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Msg2 @ "</t>");
				SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg3 @ "</t>", $chatMsg_Type_Normal2);
			}
		}
		else
			%Result = %gemstoneId;
	}
	else
		%Result = %gemstoneId;
	//echo( "%Result = " @ %Result @ "   " @ GetItemData( %Result, 1 ) );
	return %Result;
}

//��ʯ�����������
function getGemPromoteGoldNum(%gemstoneId)
{
	%Level = GetItemData(%gemstoneId, $Item_Data_Lv);
	switch (%Level)
	{
		case 1: return 1580;
		case 2: return 25000;
		case 3: return 125000;
		case 4: return 150000;
		case 5: return 500000;
		case 6: return 1000000;
		case 7: return 2000000;
		case 8: return 3000000;
		case 9: return 5000000;
		default:	return 5000000;
	}
}
//��������������������������ʯ����������������ʯ������������


//////////// ժȡ��Ƕ��ʯ������غ��� ///////////////////////////////////////////
function AddEquipGemUnmountConfig(%GemLevel, %MaterialId, %MaterialNum)
{
	%EquipGemUnmountObjectID = "EquipGemUnmountObjectID_" @ %GemLevel;
	new ScriptObject(%EquipGemUnmountObjectID)
	{
		materialid 		= %MaterialId;		// ����ID
		materialnum 	= %MaterialNum;		// ��������
	};
	$EquipGemUnmountObject[%GemLevel] = %EquipGemUnmountObjectID;
}
AddEquipGemUnmountConfig(1, 116040001, 2);
AddEquipGemUnmountConfig(2, 116040002, 2);
AddEquipGemUnmountConfig(3, 116040003, 2);
AddEquipGemUnmountConfig(4, 116040004, 2);
AddEquipGemUnmountConfig(5, 116040005, 2);
AddEquipGemUnmountConfig(6, 116040006, 2);
AddEquipGemUnmountConfig(7, 116040007, 2);
AddEquipGemUnmountConfig(8, 116040008, 2);
AddEquipGemUnmountConfig(9, 116040009, 2);
AddEquipGemUnmountConfig(10, 116040010, 2);
////////////////////װ����Ƕ��ʯ��ɫ������ϵ��////////////////////////////////
function GemIsColorMatch(%type, %color)
{
	if (%type == 1)					//��ɫϵ:	��ɫ����ɫ����ɫ
	{
		switch (%color)
		{
			case 1001:	return 1;		//��ɫ
			case 1004:	return 1;		//��ɫ
			case 1006:	return 1; 	//��ɫ
		}
	}
	else if (%type == 2)		//��ɫϵ:	��ɫ����ɫ����ɫ
	{
		switch (%color)
		{
			case 1002:	return 1;		//��ɫ
			case 1005:	return 1;		//��ɫ
			case 1004:	return 1; 	//��ɫ
		}
	}
	else if (%type == 3)		//��ɫϵ: ��ɫ����ɫ����ɫ
	{
		switch (%color)
		{
			case 1003:	return 1;		//��ɫ
			case 1006:	return 1;		//��ɫ
			case 1005:	return 1; 	//��ɫ
		}
	}
	return 0;
}

//��ȡ���Ժϳ���߱�ʯ�ȼ�
function getOpenGemLevel()
{
	return 4;
}

//��ʯͨ���ID
function getGemAppendSymbolID(%level)
{
	switch (%level)
	{
		case 1: return 113040011;
		case 2: return 113040012;
		case 3: return 113040013;
		case 4: return 113040014;
		case 5: return 113040015;
		case 6: return 113040016;
		case 7: return 113040017;
		case 8: return 113040018;
		case 9: return 113040019;
	}
}


function getGemTongLingBaseRate()
{
	return 10000;
}

function getGemComposeSuccesRate(%count)
{
	if (%count < 3)
		return 0;
	else if (%count == 3)
		return 50;
	else if (%count == 4)
		return 70;
	else if (%count > 4)
		return 100;
}

//��ȡ�ϳɱ�ʯ����ı�ʯ����
function getNeedGemNum(%level)
{
	switch (%level)
	{
		case 2: return 5;
		case 3: return 5;
		case 4: return 5;
		case 5: return 5;
		case 6: return 5;
		case 7: return 5;
		case 8: return 5;
		case 9: return 5;
	}
}

//��ȡͨ��ɹ�����1000Ϊ�ף���ʱֻ���ŵ�3��ͨ��

function getGemTonglingSuccessRate(%level)
{

	switch (%level)
	{
		case 1: return 63;
		case 2: return 50;
		case 3: return 42;
		case 4: return 10;
		case 5: return 3;
		case 6: return 1;
		case 7: return 1;
		case 8: return 1;
		case 9: return 1;
	}

}
//��������������������������ʯ����ء���������������������������������������



$GetDeathDropArray[1, 0] = "20 1 1";//װ������ ��С���� ������
$GetDeathDropArray[1, 1] = "100 1 1";//װ������ ��С���� ������
$GetDeathDropArray[1, 2] = "143 1 1";//װ������ ��С���� ������
$GetDeathDropArray[1, 3] = "133 1 2";//װ������ ��С���� ������
$GetDeathDropArray[1, 4] = "167 1 2";//װ������ ��С���� ������
$GetDeathDropArray[1, 5] = "190 1 2";//װ������ ��С���� ������
$GetDeathDropArray[1, 6] = "400 2 3";//װ������ ��С���� ������
$GetDeathDropArray[1, 11] = "1111 2 4";//װ������ ��С���� ������
$GetDeathDropArray[1, 21] = "2857 3 4";//װ������ ��С���� ������
$GetDeathDropArray[1, 51] = "5000 3 5";//װ������ ��С���� ������
$GetDeathDropArray[1, 101] = "8500 4 5";//װ������ ��С���� ������
$GetDeathDropArray[1, 201] = "10000 4 6";//װ������ ��С���� ������
$GetDeathDropArray[1, 301] = "10000 5 6";//װ������ ��С���� ������
$GetDeathDropArray[1, 501] = "10000 5 7";//װ������ ��С���� ������

$GetDeathDropArray[2, 0] = "143 1 1";//�������ߵ��� ��С���� ������
$GetDeathDropArray[2, 1] = "148 1 2";//�������ߵ��� ��С���� ������
$GetDeathDropArray[2, 2] = "167 1 2";//�������ߵ��� ��С���� ������
$GetDeathDropArray[2, 3] = "143 1 3";//�������ߵ��� ��С���� ������
$GetDeathDropArray[2, 4] = "167 1 3";//�������ߵ��� ��С���� ������
$GetDeathDropArray[2, 5] = "250 1 3";//�������ߵ��� ��С���� ������
$GetDeathDropArray[2, 6] = "500 2 3";//�������ߵ��� ��С���� ������
$GetDeathDropArray[2, 11] = "1667 2 4";//�������ߵ��� ��С���� ������
$GetDeathDropArray[2, 21] = "3571 3 4";//�������ߵ��� ��С���� ������
$GetDeathDropArray[2, 51] = "8000 3 5";//�������ߵ��� ��С���� ������
$GetDeathDropArray[2, 101] = "10000 4 5";//�������ߵ��� ��С���� ������
$GetDeathDropArray[2, 201] = "10000 4 6";//�������ߵ��� ��С���� ������
$GetDeathDropArray[2, 301] = "10000 5 6";//�������ߵ��� ��С���� ������
$GetDeathDropArray[2, 501] = "10000 5 7";//�������ߵ��� ��С���� ������

$GetDeathDropArray[3, 0] = "333 1 2";//������Ǯ���� ��С���� ������
$GetDeathDropArray[3, 1] = "800 2 3";//������Ǯ���� ��С���� ������
$GetDeathDropArray[3, 2] = "1111 2 4";//������Ǯ���� ��С���� ������
$GetDeathDropArray[3, 3] = "1667 2 4";//������Ǯ���� ��С���� ������
$GetDeathDropArray[3, 4] = "3333 2 4";//������Ǯ���� ��С���� ������
$GetDeathDropArray[3, 5] = "4167 2 4";//������Ǯ���� ��С���� ������
$GetDeathDropArray[3, 6] = "5000 3 5";//������Ǯ���� ��С���� ������
$GetDeathDropArray[3, 11] = "7000 3 6";//������Ǯ���� ��С���� ������
$GetDeathDropArray[3, 21] = "9000 4 6";//������Ǯ���� ��С���� ������
$GetDeathDropArray[3, 51] = "10000 4 7";//������Ǯ���� ��С���� ������
$GetDeathDropArray[3, 101] = "10000 5 7";//������Ǯ���� ��С���� ������
$GetDeathDropArray[3, 201] = "10000 5 8";//������Ǯ���� ��С���� ������
$GetDeathDropArray[3, 301] = "10000 6 8";//������Ǯ���� ��С���� ������
$GetDeathDropArray[3, 501] = "10000 6 8";//������Ǯ���� ��С���� ������
//��������������������������ɫ������ʧ����ء�������������������������������
/*��ɫ������ʧ�ű� ��ɫ���� �ȼ� �ƶ�ֵ
type=1 ����װ���ĸ���10000�����+����99����
type=2 �������ߵĸ���10000�����+����99����
type=3 ������ҵĸ���10000�����+����99����
type=4 ������ʧ��ȡ�����ʧ��Сֵ
type=5 ������ʧ��ȡ�����ʧ���ֵ*/
function GetDeathDropRate(%Player, %level, %pkVal, %type)
{
	//echo("%Player  ======  "@%Player);
	//echo("%��ɫ�ȼ�  ======  "@%level);
	//echo("%�ƶ�ֵ  ======  "@%pkVal);
	//echo( "%����  ======  "@%type );
	%Curse = 0;
	%Curse = %Player.getCurseNumber();//��ȡ�����ߵ�����ֵ
	//echo("%����ֵ  ======  "@%Curse);
	if (%Curse > 20) %Curse = 20;
	if (%Curse < -20)%Curse = -20;
	//echo("%����ֵ  ======  "@%Curse);

	%ZuZouShuaiJian = 1;
	if (%pkVal == 0) %ZuZouShuaiJian = 3;//��������״̬��������Ч��
	switch (%type)
	{
		case 1: %CurseRate = 1/3; %JiChuGaiLv = 60; //������װ��3������=1���ƶ� ÿ���ƶ�ֵ���ӵĻ�������
		case 2: %CurseRate = 1/2; %JiChuGaiLv = 150;//�Ա�������2������=1���ƶ� ÿ���ƶ�ֵ���ӵĻ�������
		case 3: %CurseRate = 1/1; %JiChuGaiLv = 200;//�Ա������1������=1���ƶ� ÿ���ƶ�ֵ���ӵĻ�������
		default: %CurseRate = 1/1; %JiChuGaiLv = 200;//�Ա������1������=1���ƶ� ÿ���ƶ�ֵ���ӵĻ�������
	}
	%XiuZhengpkVal =  mceil(%pkVal + %Curse * %CurseRate / %ZuZouShuaiJian);//������Ч�ƶ�ֵӰ�� ��ǰ�ƶ�ֵ+����*Ч��*���������Ч��
	//echo( "%XiuZhengpkVal  ======  "@%XiuZhengpkVal );
	if (%XiuZhengpkVal <0)%XiuZhengpkVal =0;

	if (%XiuZhengpkVal < 6)        %Val = %XiuZhengpkVal;
	else if (%XiuZhengpkVal >= 6)  %Val = 6;
	else if (%XiuZhengpkVal >= 11) %Val = 11;
	else if (%XiuZhengpkVal >= 21) %Val = 21;
	else if (%XiuZhengpkVal >= 51) %Val = 51;
	else if (%XiuZhengpkVal >= 101) %Val = 101;
	else if (%XiuZhengpkVal >= 201) %Val = 201;
	else if (%XiuZhengpkVal >= 301) %Val = 301;
	else if (%XiuZhengpkVal >= 501) %Val = 501;
	//echo( "%Val  ======  "@%Val );
	if (%type >3) %type1 =3;
	else %type1 =%type;
	%NowGaiLv = $GetDeathDropArray[%type1, %Val];//�õ����׶ε��ƶ������ʧ���� �� ����������
	//echo("%��ʧ���� �� ����������  ======  "@%NowGaiLv);
	%GaiLv = GetWord(%NowGaiLv, 0);//��ʧ����
	//echo("%��ʧ����  ======  "@%GaiLv);
	%MinCount = GetWord(%NowGaiLv, 1);//��С��ʧ����
	%MaxCount = GetWord(%NowGaiLv, 2);//�����ʧ����
	//echo("%��С��ʧ����  ======  "@%MinCount);
	//echo("%�����ʧ����  ======  "@%MaxCount);
	%LastCount = GetRandom(%MinCount, %MaxCount);//�������ʧ����
	//echo("%�������ʧ����  ======  "@%LastCount);
	if (%type == 4) %LastCount =%MinCount;//���ڼ����ҵ���ʧ������
	else if (%type == 5) %LastCount =%MaxCount;//���ڼ����ҵ���ʧ������

	%LastRate = (%XiuZhengpkVal - %Val)* %JiChuGaiLv+ %GaiLv;
	if (%LastRate > 10000) %LastRate =10000;
	%result = %LastRate *100 + %LastCount;
	//echo( "%result  ==  "@%result );
	return %result;
}

//type = 1 = ��Ʒ����Ԫ���޸�ʱ��ƷID    type = 2 = ��Ʒ����Ԫ���޸���Ӧ��������Ʒ����   type = 3 = Ԫ���޸� �����ĵ�Ԫ������   type = 4 = �޸����������Ԫ������
//%itemid = �������Ʒ����ID   %quality �������Ʒװ������
function getRepairEquipCost(%type, %itemid, %quality)
{
	echo("%type  ==  "@%type);
	echo("%itemid  ==  "@%itemid);
	echo("%quality  ==  "@%quality);
	if(%type == 1) return 105109064;
	if(%quality < 2000)
		%ItemCountNum = Mfloor(%quality /1000)+1;
	else if(%quality >=2000) %ItemCountNum = Mfloor(%quality /1000)+1 + Mfloor((%quality-2000)/500 +1);//��2000ս��Ʒ��֮�µĵ����޸��۸�Ϊ��ÿ1000ս�� ����1����֭���衣����1000��1000�㣬����2000�ڶ���ÿ500����1���������ģ�����500��500���㣩
	if(%type == 2) return %ItemCountNum;
	if(%type == 3) return %ItemCountNum * 1000;
	else  return Mfloor(%ItemCountNum * 1000 *0.25);//�޸��������߿ɻ��25%Ԫ��
}
//������ʧ��ȡ�����ʧ��Сֵ
function GetDropMoneyMin(%Player, %level, %pkVal)//������ɫ�ȼ� - 28 ��*24*��ǰ�ƶ�ֵ��С��ʧ����/2)		
{
	//echo( "Player  ==  "@%Player );
	//echo( "level  ==  "@%level );
	//echo( "pkVal  ==  "@%pkVal );
	%DropMoney = GetDeathDropRate(%Player, %level, %pkVal, "4");
	%NowMinCount = %DropMoney %100;
	%MinMoney = mceil((%level - 28) * 24 * %NowMinCount /2);
	//echo("%��С��Ǯ��ʧ���������  ==  "@%DropMoney);
	//echo("%��С�������  ==  "@%NowMinCount);
	//echo("%��ʧ��С��Ǯ  ==  "@%MinMoney);
	return %MinMoney;
}

//������ʧ��ȡ�����ʧ���ֵ
function GetDropMoneyMax(%Player, %level, %pkVal)//������ɫ�ȼ� - 28 ��*72*��ǰ�ƶ�ֵ�����ʧ����/2)									
{
	//echo( "Player  ==  "@%Player );
	//echo( "level  ==  "@%level );
	//echo( "pkVal  ==  "@%pkVal );
	%DropMoney = GetDeathDropRate(%Player, %level, %pkVal, "5");
	%NowMaxCount = %DropMoney %100;
	%MaxMoney = mceil((%level - 28) * 72 * %NowMaxCount /2);
	//echo( "%����Ǯ��ʧ���������  ==  "@%DropMoney );
	//echo( "%���������  ==  "@%NowMaxCount );
	//echo( "%��ʧ����Ǯ  ==  "@%MaxMoney );
	return %MaxMoney;
}

//������ʧ��Ҳ���ʱ�۳���ǰװ���;�ֵ ����ֵ���㹫ʽΪ��
//S32 iCurrentMaxWear = pItem->getRes()->getMaxWear();
//S32 iDropWear = mCeil(iCurrentMaxWear*dropwearval*0.0001);
function GetTakeOffEquipNowWearValue(%Player, %level, %pkVal)
{
	putout("Player  ==  "@%Player);
	putout("level  ==  "@%level);
	putout("pkVal  ==  "@%pkVal);
	%MaxMoney = GetDropMoneyMax(%Player, %level, %pkVal);
	putout("111111  ==  "@%MaxMoney);
	%KouNaiJiu = mceil((1000+ %MaxMoney)  /  38);
	putout("�۵�ǰ�;�  ==  "@%KouNaiJiu);

	if (%KouNaiJiu < 33) %KouNaiJiu=33;
	putout("�۵�ǰ�;�  ==  "@%KouNaiJiu);
	return %KouNaiJiu;
}


//������ʧ��Ҳ���ʱ���۳�װ������;�ֵ
function GetDeductEquipWearValue(%Player, %level, %pkVal)
{
	//echo( "Player  ==  "@%Player );
	//echo( "level  ==  "@%level );
	//echo( "pkVal  ==  "@%pkVal );
	%MaxMoney = GetDropMoneyMax(%Player, %level, %pkVal);
	//echo( "22222  ==  "@%MaxMoney );
	%KouNaiJiu = mceil((%MaxMoney+1000) / 62);
	//echo( "������;�  ==  "@%KouNaiJiu );

	if (%KouNaiJiu < 11) %KouNaiJiu=11;
	//echo( "������;�  ==  "@%KouNaiJiu );
	return %KouNaiJiu;
}

//��������������������������ɫ������ʧ����ء�������������������������������

//������������������������װ������ء���������������������������������������

//��������������ȡ�����ԡ�������
//��������������ȡǿ�����ӡ�����

//װ��������
function getTransSoulMaterial()
{
	return 105090409;
}

//��������������ȡ�����ԡ�������
//CalcEquipAttributeID(getplayer(),102054008,1);
function CalcEquipAttributeID(%playerid, %itemid, %type)//װ�������Ի�ȡ���� ��ɫid����Ʒid���������ͣ�type=0ϵͳ���ɣ�type=1��Ҳ�����
{
	//echo("%type  ==  "@%type);
	%itemSubType = GetItemData(%ItemId, 3);//��õ�������
	//echo( "%itemSubType  ==  "@%itemSubType );

	%itemClass = GetItemData(%ItemId, 113);//��õ���ְҵ����
	%itemchengzhanglv = GetItemData(%ItemId, 22);//��õ��ߵĳɳ���
	//echo("%itemchengzhanglv  ==  "@%itemchengzhanglv);
	//if ( %itemSubType == 210 ) return 350010001;//��buffΪר������ʾ������buff�����Լ��

	%itemQuality = GetItemData(%ItemId, $Item_Data_Color);//��õ�����ɫƷ��
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//��õ��ߵȼ�
	%Player = SptGetPlayer(%playerid);
	%Shenqi = 0;
	%luckforitem = 0;//��ȡ��Ҹ�Եֵ
	if (CheckBit(GetItemData(%itemid, $Item_Data_Type), 15) == 1) %Shenqi = 5000;//�ж��Ƿ�Ϊ����

	%itemType = mfloor(%itemSubType/100)*10+ %itemSubType%10;//�������

	%equipLevel = mceil(%itemLevel/10);//װ���ȼ�
	switch (%itemQuality)
	{
		case 2: %ColorResult = 0;
		case 3: %ColorResult = 1;
		case 4: %ColorResult = 2;
		case 5: %ColorResult = 6;
		case 6: %ColorResult = 9;
		case 7: %ColorResult = 13;
		default:%ColorResult = 0;
	}
	switch (%itemClass)
	{
		case 1: %ClassResult = 1;
		case 2: %ClassResult = 2;
		case 4: %ClassResult = 3;
		case 8: %ClassResult = 4;
		case 16:%ClassResult = 5;
		default:%ClassResult = 0;
	}
	if (%itemchengzhanglv >0 && %type == 0)
	{
		%Bufflevel=mceil((%itemchengzhanglv - 32) / 4);
		//echo("%Bufflevel1111  ==  "@%Bufflevel);
		if (%Bufflevel <1) %Bufflevel=1;
		//echo("%Bufflevel2222  ==  "@%Bufflevel);
		if (%Bufflevel >17) %Bufflevel=17;
		//echo("%Bufflevel3333  ==  "@%Bufflevel);
	}
	else
	{
		if (%type != 2)
		{
			%MaxScope = 20 *(1 + %type *  %luckforitem /100);
			if (%MaxScope >=30) %MaxScope=30;

			%RandomScope = GetRandom(1, 100);

			if (%RandomScope <= %MaxScope)
				%Bufflevel = GetRandom(1, 17);
			else
				%Bufflevel =GetRandom(1, 15);
		}
		else if (%type == 2)//Ϊ�̵깺��
			%Bufflevel = 12;
	}
	%ShiZhuangBuffID = 350020000 + %ColorResult + %Bufflevel;
	//echo("ShiZhuangBuffID  ==  "@%ShiZhuangBuffID);
	if (%itemSubType == 210 || %itemSubType == 211)
		return %ShiZhuangBuffID;
	//return 356220250;
	%BuffID = 350000000 + %ClassResult*1000000 + %itemType*10000 + %equipLevel *100 + %Bufflevel + %ColorResult + %Shenqi;
	return %BuffID;
}

//��������������ȡǿ�����ӡ�����
function CalcEquipStrengAddBuff(%playerid, %itemid, %type)//%player = ��ɫid %itemid = װ��id,%type = {012345 ��ǿ���ȼ�1 buff1  ǿ���ȼ�2 buff2 ǿ���ȼ�3 buff3}
{
	%itemQuality = GetItemData(%ItemId, $Item_Data_Color);//��õ�����ɫƷ��
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//��õ��ߵȼ�
	%itemSubType = GetItemData(%ItemId, 3);//��õ�������
	//echo("%itemSubType  ==  "@%itemSubType);
	%Player = SptGetPlayer(%playerid);
	%luckforitem = 0;
	%luckforitem = %Player.getLuck();//��ȡ��Ҹ�Եֵ
	if (%itemSubType >=400 || %itemSubType ==210)
		return 0;

	if (%itemLevel < 30) return 0;//30������װ��������������
	if (%itemQuality <= 2) //��ɫƷ��ֱ�ӷ���0
		return 0;
	else if (%itemQuality <= 3 && %type >1)//��ɫƷ�� ֻ�������1��ǿ������
		return 0;
	else if (%itemQuality <= 4 && %type >3)//��ɫƷ��ֵ�����2��ǿ������
		return 0;
	else if (%itemQuality <= 5 && %type >3 && %itemLevel < 60)//��ɫ60���������2��ǿ������
		return 0;

	if (%type == 0 || %type == 2 || %type == 4)//���ص�N������ǿ���ȼ�����
	{
		//echo("%type  ==  "@%type);
		if (%luckforitem > 500) %luckforitem =500;
		%luckforitem = %luckforitem / 500 * 100;
		switch (%type)
		{
			case 0:
				%MinNeedLevel = 6;
				%typeprobability = 800 -  %itemLevel * 2 + %luckforitem;
			case 2:
				%MinNeedLevel = 8;
				%typeprobability = 700 - %itemLevel * 2 + %luckforitem;
			case 4:
				%MinNeedLevel = 10;
				%typeprobability = 600 - %itemLevel * 2 +%luckforitem;
		}

		if (GetRandom(1, 1000) > %typeprobability)//���ʾ����Ƿ����ǿ����������
			return 0;
		%LevelAdjust = 0;
		if (%itemLevel < 60) %LevelAdjust = 1;//60������װ�� ����һ������ȼ�
		%RandomScope = GetRandom(0, 400);//�������N�����Լ�������ǿ���ȼ�
		if (%RandomScope < 100 + %itemLevel)
			return %MinNeedLevel - %LevelAdjust + 2;
		else if (%RandomScope > 200 + %itemLevel)
			return %MinNeedLevel - %LevelAdjust + 1;
		else
			return %MinNeedLevel - %LevelAdjust;
	}
	else if (%type == 1 || %type == 3 || %type == 5)//���ص�N���������Ե�Buff
	{
		switch (%type)
		{
			case 1:
				%MaxScope = 35915;
				%typeNum = 1;//��N��buff��Ӧ�ĵȼ�
			case 3:
				%MaxScope = 35921;
				%typeNum = 2;//��N��buff��Ӧ�ĵȼ�
			case 5:
				%MaxScope = 35938;
				%typeNum = 3;//��N��buff��Ӧ�ĵȼ�
		}
		if (%itemSubType < 200) %MaxScope = 35938;//ֻ�������������������Ե�ǿ������
		%BuffId = GetRandom(35901, %MaxScope);
		%lastbuffLevel = mround((%itemLevel % 10)/3)*3;//�����buff�ȼ����һλ�ĵȼ�
		%buffLevel = %type * 1000 + mfloor(%itemLevel / 10)*10 +%lastbuffLevel;//�����������buff�ȼ�
		%ItemBuff = %BuffID * 10000 + %buffLevel;
		return %ItemBuff;
	}
	return 0;
}


//�õ�װ��ǿ�����棬����������ֵ*װ������ /10000
function getItemBaseStats(%Times)
{
	switch (%Times)
	{
		case 0: return 10000;
		case 1: return 11000;
		case 2: return 12000;
		case 3: return 13200;
		case 4: return 14500;
		case 5: return 16300;
		case 6: return 18300;
		case 7: return 22300;
		case 8: return 26300;
		case 9: return 31000;
		case 10: return 35700;
		case 11: return 40400;
		case 12: return 45100;
		case 13: return 49800;
		case 14: return 54500;
		case 15: return 59200;
		case 16: return 63900;
		case 17: return 68600;
		case 18: return 73300;
		case 19: return 78000;
		case 20: return 82700;
		default: return 0;
	}
}

//�õ�����װ��ǿ���ĸ���itemid װ��ID  level װ���ȼ� strengthlv��ǰǿ���ȼ� playerid��ɫid
function GetStrengThenRate(%itemid, %level, %strengthlv, %matrialid, %playerid)
{
	if (%matrialid == 0) %addgailv = 0;
	else
		%addgailv = GetItemData(%matrialid, 17);//��ø������߱����ֶ���дֵ
	%Player = SptGetPlayer(%playerid);
	%luckforitem = 0;
	%luckforitem = %Player.getLuck();//��ȡ��Ҹ�Եֵ
	%luckadd = %luckforitem / 1000 * 500;
	%misfortune = 0;
	%misfortune = %Player.getLuck();//��ȡ��Ҷ���ֵ
	if (%level < 60)//60������ǿ��������΢����60����
	{
		switch (%strengthlv)
		{
			case 0: %Scope =  10000;
			case 1: %Scope =  7500;
			case 2: %Scope =  6000;
			case 3: %Scope =  4000;
			case 4: %Scope =  3000;
			case 5: %Scope =  2000;
			case 6: %Scope =  1100;
			case 7: %Scope =  900;
			case 8: %Scope =  800;
			case 9: %Scope =  600;
			case 10: %Scope = 500;
			case 11: %Scope = 400;
			case 12: %Scope = 200;
			case 13: %Scope = 200;
			case 14: %Scope = 200;
			case 15: %Scope = 100;
			case 16: %Scope = 100;
			case 17: %Scope = 100;
			case 18: %Scope = 100;
			case 19: %Scope = 100;
			default: %Scope = 1;
		}

	}
	else
	{
		switch (%strengthlv)
		{
			case 0: %Scope = 10000;
			case 1: %Scope = 5250;
			case 2: %Scope = 4200;
			case 3: %Scope = 2800;
			case 4: %Scope = 2100;
			case 5: %Scope = 1400;
			case 6: %Scope = 770;
			case 7: %Scope = 630;
			case 8: %Scope = 560;
			case 9: %Scope = 500;
			case 10: %Scope =400;
			case 11: %Scope = 350;
			case 12: %Scope = 150;
			case 13: %Scope = 150;
			case 14: %Scope = 150;
			case 15: %Scope = 100;
			case 16: %Scope = 100;
			case 17: %Scope = 100;
			case 18: %Scope = 100;
			case 19: %Scope = 100;
			default: %Scope =  0;
		}
	}
	//echo("%Scope  ==  "@%Scope );

	return %Scope + %addgailv + %luckadd + %misfortune;

}

//װ����ǿ���������ȼ� 
function MaxStrengthensLevel(%itemid)
{
	return 15;
	//%itemLevel = GetItemData( %ItemId, $Item_Data_Lv );//��õ��ߵȼ�
	//if ( %itemLevel < 60 )
	//	return 10;
	//else if ( %itemLevel < 80 )
	//	return 13;
	//else if ( %itemLevel < 100 )
	//	return 15;
	//else
	//	return 20;
}

//�õ�װ��ǿ������״̬��ŵĺ��� װ������  ְҵ ǿ���ȼ�
function getItemAddtionStats(%ItemId, %times)
{
	%itemSubType = GetItemData(%ItemId, 3);//��õ�������
	%job =  GetItemData(%ItemId, 113);//��õ���ְҵ����
	if (%itemSubType < 200) %itemSubType=101;
	switch (%itemSubType)
	{
		case 101:	%buffid = 35801;
		case 201:	%buffid = 35802;
		case 202:	%buffid = 35803;
		case 203:	%buffid = 35804;
		case 204:	%buffid = 35805;
		case 205:	%buffid = 35806;
		case 206:	%buffid = 35807;
		case 207:	%buffid = 35808;
		case 301:	%buffid = 35809;
		case 302:	%buffid = 35810;
		case 303:	%buffid = 35811;
	}
	switch (%job)
	{
		case 1: %job = 1;
		case 2: %job = 2;
		case 4: %job = 3;
		case 8: %job = 4;
		case 16: %job = 5;
		default: %job = 0;
	}
	return (%buffid + %job * 11)*10000 + %times;
}


// ����װ��ǿ���������ļ۸�(type = 0 �������  1 Ԫ������)
function CalcEquipStrengthenPrice(%playerid, %itemid, %times, %type)
{
	%itemType = GetItemData(%itemid, 2);//��õ�������
	%itemQuality = GetItemData(%itemid, $Item_Data_Color);//��õ�����ɫƷ��
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//��õ��ߵȼ�
	switch (%itemType)
	{
		case 1: %part = 1.2;
		case 2: %part = 0.6;
		case 3: %part = 0.9;
		default: %part = 1;
	}
	//Gold=��ɫƷ�ʣ�ֵ��*װ����λ��ֵ��*2*1.06�ȼ�����*2ǿ������

	switch (%itemQuality)
	{
		case 2: %color =1.00;
		case 3: %color =1.10;
		case 4: %color =1.20;
		case 5: %color =1.50;
		case 6: %color =2.00;
		case 7: %color =2.50;
		default: %color =2.5;
	}

	if (%itemLevel < 40) %off = 0.1;//0.3
	else if (%itemLevel < 50) %off = 0.3;//0.6
	else if (%itemLevel < 60) %off = 0.6;//0.8
	else %off = 1;

	%NeedJinBi = mfloor(40 * (Mpow(1.02, %itemLevel)-0.66) * (1 + %times / 6) * %color * %part * %off);
	if (%times < 4)	%NeedYuanBao = 50;
	else if (%times < 7)	%NeedYuanBao = 70;
	else if (%times < 10)	%NeedYuanBao = 100;
	else %NeedYuanBao = 150;

	if (%type == 0)//�������
		return %NeedJinBi;
	else
		return %NeedYuanBao;
}

// ��ȡװ��ǿ�������� EquipitemID��������ǿ����װ��ID times = ��ǰǿ���ȼ�+1�� %valueType 0 = ǿ��������ƷID�� 1 = ǿ��������Ʒ����
function GetEquipSthrengthenConfig(%EquipitemID, %times, %valueType)
{
	%result = 0;
	%obj = $EquipStrengthenObject[%times];
	switch (%valueType)
	{
		case 0: %result = %obj.materialid;
		case 1: %result = %obj.materialnum;
		case 2: %result = %obj.ShowQuality;
	}
	return %result;
}

function AddEquipStrengthenConfig(%times, %materialid, %materialnum, %ShowQuality)
{
	%EquipStrengthenObjectID = "EquipSthengthenObject_" @ %times;
	new ScriptObject(%EquipStrengthenObjectID)
	{
		materialid 		= %materialid;		// ����ID
		materialnum 	= %materialnum;		// ��������
		ShowQuality   = %ShowQuality;   // ��ֵ*ǿ���ȼ� + ��ʯ �������Ե�����ϵ�� ����show��װ����Ʒ�ʵ�
	};
	$EquipStrengthenObject[%times] = %EquipStrengthenObjectID;
}

AddEquipStrengthenConfig(1, 116010001, 1, 50);
AddEquipStrengthenConfig(2, 116010001, 1, 55);
AddEquipStrengthenConfig(3, 116010001, 1, 60);
AddEquipStrengthenConfig(4, 116010002, 1, 65);
AddEquipStrengthenConfig(5, 116010002, 1, 70);
AddEquipStrengthenConfig(6, 116010002, 1, 75);
AddEquipStrengthenConfig(7, 116010003, 1, 80);
AddEquipStrengthenConfig(8, 116010003, 1, 85);
AddEquipStrengthenConfig(9, 116010003, 1, 90);
AddEquipStrengthenConfig(10, 116010004, 1, 95);
AddEquipStrengthenConfig(11, 116010004, 1, 100);
AddEquipStrengthenConfig(12, 116010004, 1, 105);
AddEquipStrengthenConfig(13, 116010004, 1, 110);
AddEquipStrengthenConfig(14, 116010004, 1, 115);
AddEquipStrengthenConfig(15, 116010004, 1, 120);
AddEquipStrengthenConfig(16, 116010004, 1, 125);
AddEquipStrengthenConfig(17, 116010004, 1, 130);
AddEquipStrengthenConfig(18, 116010004, 1, 135);
AddEquipStrengthenConfig(19, 116010004, 1, 140);
AddEquipStrengthenConfig(20, 116010004, 1, 145);


//��ȡװ��ǿ������������ת��Ԫ������ %consumeEquipID ���ĵ�װ��ID ��%retainEquipID ������װ��ID�� %Strengs ǿ���ȼ��� %IdentifyNum ����������Ŀ
function  YBToTransferSoul(%consumeEquipID, %retainEquip, %Strengs, %IdentifyNum)
{
	%consumeEquipLv = GetItemData(%consumeEquipID, $Item_Data_Lv);//��õ��ߵȼ�
	%retainEquipLv  = GetItemData(%retainEquip, $Item_Data_Lv);//��õ��ߵȼ�
	if (%retainEquipLv - %consumeEquipLv == 10) %D_value = 2;
	else if (%retainEquipLv - %consumeEquipLv == 0) %D_value = 1;
	else %D_value = 1.5;
	switch (%Strengs)
	{
		case 0: %StrengsYuanbao  = 25;
		case 1: %StrengsYuanbao  = 50;
		case 2: %StrengsYuanbao  = 116;
		case 3: %StrengsYuanbao  = 200;
		case 4: %StrengsYuanbao  = 375;
		case 5: %StrengsYuanbao  = 608;
		case 6: %StrengsYuanbao  = 958;
		case 7: %StrengsYuanbao  = 1867;
		case 8: %StrengsYuanbao  = 4645;
		case 9: %StrengsYuanbao  = 19145;
		case 10: %StrengsYuanbao = 48145;
		case 11: %StrengsYuanbao = 73145;
		case 12: %StrengsYuanbao = 223145;
		case 13: %StrengsYuanbao = 373145;
		case 14: %StrengsYuanbao = 523145;
		case 15: %StrengsYuanbao = 673145;
		case 16: %StrengsYuanbao = 823145;
		case 17: %StrengsYuanbao = 973145;
		case 18: %StrengsYuanbao = 1123145;
		case 19: %StrengsYuanbao = 1273145;
		case 20: %StrengsYuanbao = 1423145;
		default: %StrengsYuanbao = 1423145;
	}
	switch (%IdentifyNum)
	{
		case 0: %IdentifyYuanbao = 20;
		case 1: %IdentifyYuanbao = 40;
		case 2: %IdentifyYuanbao = 50;
		case 3: %IdentifyYuanbao = 60;
		case 4: %IdentifyYuanbao = 100;
		case 5: %IdentifyYuanbao = 200;
		case 6: %IdentifyYuanbao = 500;
		case 7: %IdentifyYuanbao = 1000;
		case 8: %IdentifyYuanbao = 2000;
		case 9: %IdentifyYuanbao = 5000;
		case 10: %IdentifyYuanbao =8000;
		default: %IdentifyYuanbao =8000;
	}
	%NeedYuanBao = mfloor((%StrengsYuanbao + %IdentifyYuanbao)*%D_value);
	return %NeedYuanBao;
}

//������������������������װ������������ء���������������������������������
//װ������������Ŀ ����װ��ID
function GetMaxAddIdentifyNumber(%itemid)
{
	%itemQuality = GetItemData(%itemid, $Item_Data_Color);//��õ�����ɫƷ��
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//��õ��ߵȼ�
	switch (%itemQuality)
	{
		case 1: %colour = 0;
		case 2: %colour = 0;
		case 3: %colour = 0;
		case 4: %colour = 0;
		case 5: %colour = 1;
		case 6: %colour = 2;
		case 7: %colour = 2;

	}
	if (%itemLevel < 30)
		%MaxScope = 0;
	else if (%itemQuality < 5)
		%MaxScope = mfloor(%itemLevel / 10) + %colour;
	if (%itemQuality >= 5 &&  %itemLevel <= 50)
		%MaxScope = mfloor(%itemLevel / 10) + %colour;
	if (%itemQuality >= 5 &&  %itemLevel > 50)
		%MaxScope = 5 + mfloor((%itemLevel-50) / 5) + %colour;
	if (%MaxScope > 10)
		%MaxScope = 10;
	return %MaxScope;
}

//��ȡװ������ĳɹ��ʣ��� ��ɫID װ��ID ��������ID  ��������Ϊ��N����  �縨������Ϊ����0�����ɹ���
function GetAddProNumSuceessRate(%playerid, %ItemId, %materialid, %Times)
{
	%itemQuality = GetItemData(%itemid, $Item_Data_Color);//��õ�����ɫƷ��
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//��õ��ߵȼ�
	if (%materialid != 0)
		%addSuceessrate = GetItemData(%materialid, 17);//��ȡ�����������ӵĳɹ���
	else %addSuceessrate =0;
	switch (%itemQuality)
	{
		case 5: %colour = 0.9;
		case 6: %colour = 0.7;
		case 7: %colour = 0.5;
		default: %colour = 1;
	}
	if (%itemLevel < 55)
	{
		switch (%Times)
		{
			case 1: %GaiLv = 5000;
			case 2: %GaiLv = 3800;
			case 3: %GaiLv = 2500;
			case 4: %GaiLv = 1800;
			case 5: %GaiLv = 1500;
			case 6: %GaiLv = 1000;
			case 7: %GaiLv = 700;
			case 8: %GaiLv = 400;
			case 9: %GaiLv = 300;
			case 10: %GaiLv = 100;
			default: %GaiLv = 1;
		}
	}
	else if (%itemLevel >= 55 && %itemLevel <= 80)
	{
		switch (%Times)
		{
			case 1: %GaiLv = 3800;
			case 2: %GaiLv = 2500;
			case 3: %GaiLv = 1800;
			case 4: %GaiLv = 1500;
			case 5: %GaiLv = 800;
			case 6: %GaiLv = 500;
			case 7: %GaiLv = 400;
			case 8: %GaiLv = 300;
			case 9: %GaiLv = 200;
			case 10: %GaiLv = 100;
			default: %GaiLv = 1;
		}
	}
	else
	{
		switch (%Times)
		{
			case 1: %GaiLv = 2500;
			case 2: %GaiLv = 1800;
			case 3: %GaiLv = 1500;
			case 4: %GaiLv = 800;
			case 5: %GaiLv = 500;
			case 6: %GaiLv = 400;
			case 7: %GaiLv = 300;
			case 8: %GaiLv = 200;
			case 9: %GaiLv = 100;
			case 10: %GaiLv = 80;
			default: %GaiLv = 1;
		}
	}
	%AddProGaiLv = mfloor(%GaiLV * %colour)+ %addSuceessrate;
	if (%AddProGaiLv > 10000) %AddProGaiLv=10000;
	return %AddProGaiLv;
	//return 10000;
}


//�������������ģ�%playerid, ��װ��ID  ��������Ϊ��N����
function GetAddProNumMoney(%playerid, %ItemId, %Times)
{
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//��õ��ߵȼ�
	%Maxtiaomu = GetMaxAddIdentifyNumber(%ItemId);//��ñ���װ���ɼ�����������Ŀ
	switch (%Maxtiaomu)
	{
		case 3: %Maxtiaomu = 1.0;
		case 4: %Maxtiaomu = 1.1;
		case 5: %Maxtiaomu = 1.2;
		case 6: %Maxtiaomu = 1.4;
		case 7: %Maxtiaomu = 1.7;
		case 8: %Maxtiaomu = 2.0;
		case 9: %Maxtiaomu = 2.4;
		case 10: %Maxtiaomu = 3.0;
		default: %Maxtiaomu = 3.0;
	}
	if (%itemLevel < 40) %off = 0.05;//0.3
	else if (%itemLevel < 50) %off = 0.25;//0.6
	else if (%itemLevel < 60) %off = 0.55;//0.8
	else if (%itemLevel < 70) %off = 0.85;//0.8
	else %off = 1;

	%NeedMoney = mceil(55 * (1 + %Times/4)*%Maxtiaomu * Mpow(1.021, %itemLevel)*%off);
	return %NeedMoney;
}

//(%levelװ���ȼ�)��ȡ��������״̬��4λֵ��С���ص���һ�����ݵȼ��������ֵ ��ɫID װ��ID ��ǰ�����ĵ�N�� type =1 Ϊ���� �뻻��  type=2Ϊϴ�� 
function GetIdentifyQuality(%Playerid, %itemid, %Num, %type)
{
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//��õ��ߵȼ�
	%MinResult = mfloor(%itemLevel / 2);
	%MaxResult = mfloor(%itemLevel * 1.5);
	%MediumResult = mfloor(%itemLevel * 1.3);

	%Shuiji = GetRandom(1, 1000);
	if (%Shuiji < 70 * %type)
		%result = GetRandom(%MediumResult, %MaxResult);
	else if (%Shuiji < 350 * %type)
		%result = GetRandom(15, %MaxResult);
	else %result = GetRandom(%MinResult, %MaxResult);

	return %result;
}

//�����������ID����װ��ID���ܹ����м���������Ŀ��������ס��Ŀ��
function getChangeIdentifyProItem(%playerid, %ItemId, %MaxTiaoMu, %LockTiaoMu)
{
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//��õ��ߵȼ�
	if (%itemLevel <50) %CaiLiaoID = 105090501;
	else if (%itemLevel <70) %CaiLiaoID = 105090511;
	else if (%itemLevel <90) %CaiLiaoID = 105090521;
	else if (%itemLevel <100) %CaiLiaoID = 105090531;
	else  %CaiLiaoID = 105090541;

	if (%LockTiaoMu < 4) %ChangeItemID = 0;
	else if (%LockTiaoMu < 8) %ChangeItemID = 1;
	else  %ChangeItemID = 2;

	%NeedItenID = %CaiLiaoID + %ChangeItemID;
	return %NeedItenID;
}


//��������������� Ԫ�������������ʱԪ��������������%playerid,��װ��ID���ܹ����м���������Ŀ��������ס��Ŀ ���β���Ԫ���������ĵ���1  Ԫ���������2��
function getChangeIdentifyProNum(%playerid, %ItemId, %Maxtiaomu, %LockTiaoMu, %type)
{
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//��õ��ߵȼ�
	switch (%LockTiaoMu)
	{
		case 0: %ItemNum = 1; %Lock = 1;
		case 1: %ItemNum = 2; %Lock = 1;
		case 2: %ItemNum = 3; %Lock = 1;
		case 3: %ItemNum = 5; %Lock = 1;
		case 4: %ItemNum = 2; %Lock = 3;
		case 5: %ItemNum = 3; %Lock = 3;
		case 6: %ItemNum = 4; %Lock = 3;
		case 7: %ItemNum = 6; %Lock = 3;
		case 8: %ItemNum = 4; %Lock = 6;
		case 9: %ItemNum = 5; %Lock = 6;
		case 10: %ItemNum = 6; %Lock = 6;
		default: %ItemNum = 10; %Lock = 6;
	}
	if (%type == 1)
		return %ItemNum;
	if (%itemLevel < 50) %JiChu = 50;
	else if (%itemLevel < 70) %JiChu = 65;
	else if (%itemLevel < 90) %JiChu = 80;
	else if (%itemLevel < 100) %JiChu = 100;
	else  %JiChu = 120;
	%NeedYuanBao = %JiChu * %Lock * %ItemNum;
	return %NeedYuanBao;
}

//���������Ǯ��%playerid,װ��ID���ܹ����м���������Ŀ��������ס��Ŀ ���β���Ԫ���������ĵ���1  Ԫ���������2��
function getChangeIdentifyProMoney(%playerid, %ItemId, %Maxtiaomu, %LockTiaoMu, %type)
{
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//��õ��ߵȼ�
	switch (%Maxtiaomu)
	{
		case 1: %Maxtiaomu = 1.0;
		case 2: %Maxtiaomu = 1.03;
		case 3: %Maxtiaomu = 1.05;
		case 4: %Maxtiaomu = 1.1;
		case 5: %Maxtiaomu = 1.2;
		case 6: %Maxtiaomu = 1.4;
		case 7: %Maxtiaomu = 1.7;
		case 8: %Maxtiaomu = 2.0;
		case 9: %Maxtiaomu = 2.4;
		case 10: %Maxtiaomu = 3.0;
		default: %Maxtiaomu = 3.0;
	}
	%NeedJinBi = mceil(55 * (1 + %Maxtiaomu/4)*%Maxtiaomu * Mpow(1.021, %itemLevel)*(1+%type/2));
	return %NeedJinBi;
}

//ϴ���������ID����װ��ID���ܹ����м���������Ŀ��ϴ����ס��Ŀ��
function getLockSoulFixedMaterialNeedItem(%playerid, %ItemId, %Maxtiaomu, %LockTiaoMu)
{
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//��õ��ߵȼ�
	if (%itemLevel <50) %CaiLiaoID = 105090601;
	else if (%itemLevel <70) %CaiLiaoID = 105090611;
	else if (%itemLevel <90) %CaiLiaoID = 105090621;
	else if (%itemLevel <100) %CaiLiaoID = 105090631;
	else  %CaiLiaoID = 105090641;

	if (%LockTiaoMu < 4) %ChangeItemID = 0;
	else if (%LockTiaoMu < 8) %ChangeItemID = 1;
	else  %ChangeItemID = 2;

	%NeedItenID = %CaiLiaoID + %ChangeItemID;
	return %NeedItenID;
}

//ϴ����������������� �� Ԫ�������������ʱԪ��������������%playerid,��װ��ID���ܹ����м���������Ŀ��������ס��Ŀ ���β���Ԫ���������ĵ���1  Ԫ���������2��
function getLockSoulFixedMaterialNeedNum(%playerid, %ItemId, %Maxtiaomu, %LockTiaoMu, %type)
{
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//��õ��ߵȼ�
	switch (%LockTiaoMu)
	{
		case 0: %ItemNum = 1; %Lock = 1;
		case 1: %ItemNum = 2; %Lock = 1;
		case 2: %ItemNum = 3; %Lock = 1;
		case 3: %ItemNum = 5; %Lock = 1;
		case 4: %ItemNum = 2; %Lock = 3;
		case 5: %ItemNum = 3; %Lock = 3;
		case 6: %ItemNum = 4; %Lock = 3;
		case 7: %ItemNum = 6; %Lock = 3;
		case 8: %ItemNum = 4; %Lock = 6;
		case 9: %ItemNum = 5; %Lock = 6;
		case 10: %ItemNum = 6; %Lock = 6;
		default: %ItemNum = 10; %Lock = 6;
	}
	if (%type == 1)
		return %ItemNum;
	if (%itemLevel < 50) %JiChu = 50;
	else if (%itemLevel < 70) %JiChu = 65;
	else if (%itemLevel < 90) %JiChu = 80;
	else if (%itemLevel < 100) %JiChu = 100;
	else  %JiChu = 120;
	%NeedYuanBao = %JiChu * %Lock * %ItemNum;
	return %NeedYuanBao;
}

//ϴ�����������ģ�%playerid,��װ��ID���ܹ����м���������Ŀ��������ס��Ŀ ���β���Ԫ���������ĵ���1  Ԫ���������2��
function getLockSoulFixedMaterialMoney(%playerid, %ItemId, %Maxtiaomu, %LockTiaoMu, %type)
{
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//��õ��ߵȼ�
	switch (%Maxtiaomu)
	{
		case 1: %Maxtiaomu = 1.0;
		case 2: %Maxtiaomu = 1.03;
		case 3: %Maxtiaomu = 1.05;
		case 4: %Maxtiaomu = 1.1;
		case 5: %Maxtiaomu = 1.2;
		case 6: %Maxtiaomu = 1.4;
		case 7: %Maxtiaomu = 1.7;
		case 8: %Maxtiaomu = 2.0;
		case 9: %Maxtiaomu = 2.4;
		case 10: %Maxtiaomu = 3.0;
		default: %Maxtiaomu = 3.0;
	}
	%NeedJinBi = mceil(55 * (1 + %Maxtiaomu/4)*%Maxtiaomu * Mpow(1.021, %itemLevel)*(1+%type/3));
	return %NeedJinBi;
}

//�����������ר���ĸ���  ��ɫid ����ǰ��X��0��9
function GetIdentifyExclusive(%playerid, %times)
{
	if (%times < 5)
		return 0;
	//echo("%��ɫid  ===  "@%playerid);
	//echo("%��ǰ�ǵ�X��  ===  "@%times);
	%Exclusive = 0;
	%Player = SptGetPlayer(%playerid);
	%goodluck = %Player.getLuck();//��ȡ��Ҹ�Եֵ
	//echo("%����ֵ  ===  "@%goodluck);
	%val = 0;
	if (%goodluck <300)
		%val = 300;//300�����¸�Ե����Ч
	//echo("%val  ===  "@%val);
	else %val = 300 - (%goodluck - 100) /2;
	//echo("%val1  ===  "@%val);
	%val = Getmin(200, %val);
	//echo("%val2  ===  "@%val);

	%val = Getmin(300, %val);
	//echo("%va3  ===  "@%val);
	%GaiLV = (5000 - %times * %val);
	//echo("%����  ===  "@%GaiLV);
	%SuijiShu = GetRandom(1, 10000);
	//echo("%�����  ===  "@%SuijiShu);

	if (%GaiLV > %SuijiShu)
		%Exclusive =1;
	//echo("%�Ƿ��ר��  ===  "@%Exclusive);

	return %Exclusive;
}

//��װ�����顿��Ѵ�������
function getFreeLockChangeTimes(%Player)
{
	//������ڻʱ����
	if (GetStartTime("KaiFuHuoDong") > 0)
		return 0;

	//����Ѿ���ȡ
	if (GetWord(%Player.GetActivity(2254), 0) == 0)
		return 1;

	return 0;
}

//װ���������� ���� %playerid, װ��id  type = 1 Ϊ��ȡ���ĵ���id  2=��ȡ�������� 3=��ȡ������� 4=Ԫ������ʱ���ĵ�Ԫ��
function getEquipNiePanNeed(%playerid, %itemid, %type)
{
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//��õ��ߵȼ�
	%itemQuality = GetItemData(%itemid, $Item_Data_Color);//��õ�����ɫƷ��

	switch (%itemQuality)
	{
		case 1: %QualityNum = 1; %QualityItem = 0; %QualityYuanBao = 1;
		case 2: %QualityNum = 1; %QualityItem = 0; %QualityYuanBao = 1;
		case 3: %QualityNum = 1; %QualityItem = 0; %QualityYuanBao = 1;
		case 4: %QualityNum = 1; %QualityItem = 0; %QualityYuanBao = 1;
		case 5: %QualityNum = 1; %QualityItem = 0; %QualityYuanBao = 1;
		case 6: %QualityNum = 5; %QualityItem = 1; %QualityYuanBao = 2;
		case 7: %QualityNum = 10; %QualityItem = 2; %QualityYuanBao = 4;
		default: %QualityNum = 10; %QualityItem = 2; %QualityYuanBao = 4;
	}

	if (%type==1 || %type ==4)//1��������ʯ����ID   4��������ʱ��Ԫ���������ʱԪ������
	{
		if (%itemLevel < 50)
		{
			%JichuItemID = 105090701;
			%YuanBao = 50;
		}
		else if (%itemLevel < 70)
		{
			%JichuItemID = 105090711;
			%YuanBao = 65;
		}
		else if (%itemLevel < 90)
		{
			%JichuItemID = 105090721;
			%YuanBao = 80;
		}
		else if (%itemLevel < 100)
		{
			%JichuItemID = 105090731;
			%YuanBao = 100;
		}
		else
		{
			%JichuItemID = 105090741;
			%YuanBao = 120;
		}
		%needItemID = %JichuItemID + %QualityItem;
		%needYuanBao = %YuanBao * %QualityYuanBao;
		if (%type ==1)
			return %needItemID;
		else if (%type ==4)
			return %needYuanBao;
	}
	else if (%type == 2)//��������ʯ��������
	{
		return 1;
	}
	else if (%type == 3)//�����������Ľ��
	{

		%NeedJinBi = mfloor(100 * %QualityNum * Mpow(1.035, %itemLevel));
		return %NeedJinBi;
	}
	return 0;
}

//��������������������������������ء���������������������������������������
//��ȡ�������������� ���ID
function GetAntiquesNeedJinBi(%itemID)
{
	%itemLv = GetItemData(%itemid, $Item_Data_Lv);//��õ��ߵȼ�
	switch (%itemLv)
	{
		case 50: return 100000;
		case 60: return 500000;
		case 70: return 1000000;
		default: return 1000000;
	}
}

//��ȡ��������ļ�����ID
function GetAntiquesNeedItemID(%itemID)
{
	%itemLv = GetItemData(%itemid, $Item_Data_Lv);//��õ��ߵȼ�
	switch (%itemLv)
	{
		case 50: return 105109071;
		case 60: return 105109072;
		case 70: return 105109073;
		default: return 105109073;
	}
}

//��ȡ��������ļ����������� ��Ԫ�����������ʱԪ���������� type1 = ��������  type=2 Ԫ������
function GetAntiquesNeedItem(%itemID, %type)
{
	if (%type == 1) return 1;
	%itemLv = GetItemData(%itemid, $Item_Data_Lv);//��õ�����ɫƷ��
	switch (%itemLv)
	{
		case 50: return 100;
		case 60: return 500;
		case 70: return 1000;
		default: return 1000;
	}
}

//Show�Ĳ�������ID GetShowAntiquesItem[ ������ɫƷ�ʣ���N��]
$GetShowAntiquesItem[50, 1] = 105180152;//	3����ʯ������	   	  
$GetShowAntiquesItem[50, 2] = 105100302;//	�߼��챦ʯ        
$GetShowAntiquesItem[50, 3] = 105100312;//	�߼�����ʯ        
$GetShowAntiquesItem[50, 4] = 105100322;//	�߼��̱�ʯ  
$GetShowAntiquesItem[50, 5] = 110020083;//	�﹥�ܻ�����      
$GetShowAntiquesItem[50, 6] = 110020093;//	�����ܻ�����      
$GetShowAntiquesItem[50, 7] = 110020113;//	���˱�ʯ          
$GetShowAntiquesItem[50, 8] = 110030023;//	�������ܱ�ʯ      
$GetShowAntiquesItem[50, 9] = 110030033;//	�������ܱ�ʯ      
$GetShowAntiquesItem[50, 10]= 110030043;//	������ʯ          
$GetShowAntiquesItem[50, 11]= 110030053;//	�����˺���ʯ      
$GetShowAntiquesItem[50, 12]= 110030063;//	�������ⱦʯ      
$GetShowAntiquesItem[50, 13]= 110030073;//	�����˺����ⱦʯ  
$GetShowAntiquesItem[50, 14]= 110030113;//	����һ��          
$GetShowAntiquesItem[50, 15]= 110030123;//	����һ������      
$GetShowAntiquesItem[50, 16]= 110030133;//	����һ���˺�      
$GetShowAntiquesItem[50, 17]= 110030143;//	�����˺�����      
$GetShowAntiquesItem[50, 18]= 105105304;//	��ש        
$GetShowAntiquesItem[50, 19]= 105105303;//	����        
$GetShowAntiquesItem[50, 20]= 105105302;//	��        
$GetShowAntiquesItem[50, 21]= 105105301;//	��Ҷ��   

$GetShowAntiquesItem[60, 1] = 105180153;
$GetShowAntiquesItem[60, 2] = 105100303;
$GetShowAntiquesItem[60, 3] = 105100313;
$GetShowAntiquesItem[60, 4] = 105100323;
$GetShowAntiquesItem[60, 5] = 110020084;
$GetShowAntiquesItem[60, 6] = 110020094;
$GetShowAntiquesItem[60, 7] = 110020114;
$GetShowAntiquesItem[60, 8] = 110030024;
$GetShowAntiquesItem[60, 9] = 110030034;
$GetShowAntiquesItem[60, 10]= 110030044;
$GetShowAntiquesItem[60, 11]= 110030054;
$GetShowAntiquesItem[60, 12]= 110030064;
$GetShowAntiquesItem[60, 13]= 110030074;
$GetShowAntiquesItem[60, 14]= 110030114;
$GetShowAntiquesItem[60, 15]= 110030124;
$GetShowAntiquesItem[60, 16]= 110030134;
$GetShowAntiquesItem[60, 17]= 110030144;
$GetShowAntiquesItem[60, 18]= 105105304;
$GetShowAntiquesItem[60, 19]= 105105303;
$GetShowAntiquesItem[60, 20]= 105105302;
$GetShowAntiquesItem[60, 21]= 105105301;

$GetShowAntiquesItem[70, 1] = 105180154;
$GetShowAntiquesItem[70, 2] = 105100304;
$GetShowAntiquesItem[70, 3] = 105100314;
$GetShowAntiquesItem[70, 4] = 105100324;
$GetShowAntiquesItem[70, 5] = 110020085;
$GetShowAntiquesItem[70, 6] = 110020095;
$GetShowAntiquesItem[70, 7] = 110020115;
$GetShowAntiquesItem[70, 8] = 110030025;
$GetShowAntiquesItem[70, 9] = 110030035;
$GetShowAntiquesItem[70, 10]= 110030045;
$GetShowAntiquesItem[70, 11]= 110030055;
$GetShowAntiquesItem[70, 12]= 110030065;
$GetShowAntiquesItem[70, 13]= 110030075;
$GetShowAntiquesItem[70, 14]= 110030115;
$GetShowAntiquesItem[70, 15]= 110030125;
$GetShowAntiquesItem[70, 16]= 110030135;
$GetShowAntiquesItem[70, 17]= 110030145;
$GetShowAntiquesItem[70, 18]= 105105305;
$GetShowAntiquesItem[70, 19]= 105105304;
$GetShowAntiquesItem[70, 20]= 105105303;
$GetShowAntiquesItem[70, 21]= 105105302;
$GetShowAntiquesItem[70, 22]= 105105301;

//��ȡ����������չʾ����
function GetShowAntiquesItemID(%itemID)
{
	%itemQuality = GetItemData(%itemid, $Item_Data_Color);//��õ�����ɫƷ��
	%itemLv = GetItemData(%itemid, $Item_Data_Lv);//��õ��ߵȼ�
	%List = $GetShowAntiquesItem[%itemLv, 1];
	for (%i = 2; %i <= 99; %i++)
	{
		if ($GetShowAntiquesItem[%itemLv, %i] $= "")
			break;
		%List = %List @ " " @ $GetShowAntiquesItem[%itemLv, %i];
	}
	return %List;
}

//�����ɹ������ ȫ������ ����� ���ID  ������ƷID
function ShowAntiquesAysAtring(%playerid, %PuYuID, %itemid)
{
}
//��ȡ������� ��ɫID ���ID �������˷�ID
//GetAntiquesItem(50000324,105300030,0);
function GetAntiquesItem(%playerid, %itemID, %materialid)
{
	%Player = SptGetPlayer(%playerid);
	if (%Player <= 0)
		return;
	%SourceA = GetItemdata(%itemID, 17);
	%SourceB = GetItemdata(%materialid, 17);
	%Type = %itemID%100;
	if (%Type <= 10)
		%Type = 1;
	else if (%Type <= 20)
		%Type = 2;
	else
		%Type = 3;
	%ItemSubType  = GetItemForAntiques(%player, %Type, %SourceA, %SourceB);
	switch (%Type)
	{
		case 1:
			switch (%ItemSubType)
			{
				case 1:%ItemID = 105180152; %MsgType = 1;
				case 2:%ItemID = GetStoreForAntiques(%player, 3); %MsgType = 1;
				case 3:%ItemID = 105105304; %MsgType = 1;
				case 4:%ItemID = 105105303;
				case 5:%ItemID = 105105302;
				case 6:%ItemID = 105105301;
				case 7:%ItemID = 105105301;
				case 8:%ItemID = 105105301;
				case 9:%ItemID = 0; %Money = GetRanDom(100000, 500000); %Player.Addmoney(%Money, 2, 1, 307);
				case 10:%ItemID = 0; %Money = GetRanDom(10000, 100000); %Player.Addmoney(%Money, 2, 1, 307);
			}
		case 2:
			switch (%ItemSubType)
			{
				case 1:%ItemID = 105180153; %MsgType = 1;
				case 2:%ItemID = GetStoreForAntiques(%player, 4); %MsgType = 1;
				case 3:%ItemID = 105105305; %MsgType = 1;
				case 4:%ItemID = 105105304; %MsgType = 1;
				case 5:%ItemID = 105105303;
				case 6:%ItemID = 105105302;
				case 7:%ItemID = 0; %Money = GetRanDom(500000, 2000000); %Player.Addmoney(%Money, 2, 1, 307);
				case 8:%ItemID = 0; %Money = GetRanDom(50000, 500000); %Player.Addmoney(%Money, 2, 1, 307);
			}
		case 3:
			switch (%ItemSubType)
			{
				case 1:%ItemID = 105180154; %MsgType = 1;
				case 2:%ItemID = GetStoreForAntiques(%player, 5); %MsgType = 1;
				case 3:%ItemID = 105105305; %MsgType = 1;
				case 4:%ItemID = 105105304; %MsgType = 1;
				case 5:%ItemID = 105105303;
				case 6:%ItemID = 0; %Money = GetRanDom(1000000, 2000000); %Player.Addmoney(%Money, 2, 1, 307);
				case 7:%ItemID = 0; %Money = GetRanDom(500000, 1000000); %Player.Addmoney(%Money, 2, 1, 307);
			}
	}
	if (%ItemID > 0)
	{
		%Player.PutItem(%ItemID, 1);
		if (%Player.Additem(1, 307))
		{
			if (%MsgType == 1)
			{
				%ItemName1 = GetItemName(%ItemID, 2);
				%PlayerName = "<t>��" @ %Player.GetPlayerName() @ "��</t>";
				%Msg = "<t>���Ǹ���</t>" @ %Playername @ "<t>�ڼ���ʱ���</t>" @ %ItemName1;
				SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg @ "</t>", $chatMsg_Type_Normal2);
			}
		}
	}
	if (%Money >= 200000)
	{
		//echo( "%Money ===" @ %Money );

		%PlayerName = GetPlayerZiTiName(%Player, 1);
		%Msg = "<t>���Ǹ���</t>" @ %Playername @ "<t>�ڼ���ʱ���</t>" @  $Get_Dialog_GeShi[31416] @ mfloor(%Money/10000) @ "</t><t>ö���</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg @ "</t>", $chatMsg_Type_Normal2);
	}
}

function GetItemForAntiques(%player, %Type, %SourceA, %SourceB)//�����������ĵ���ID
{
	%Ran = GetRanDom(1, 10000);
	%Lucky = %Player.GetLuck();
	switch (%Type)
	{
		case 1:
			%OneRan[1] = (((%Lucky / 10)+ %SourceA + %SourceB)/20+1)* 40;//3����ʯ������
			%OneRan[2] = (((%Lucky / 10)+ %SourceA + %SourceB)/20+1)* 80;//�߼��챦ʯ �߼�����ʯ �߼��̱�ʯ
			%OneRan[3] = (((%Lucky / 10)+ %SourceA + %SourceB)/20+1)* 30;// ��ש 
			%OneRan[4] = (((%Lucky / 10)+ %SourceA + %SourceB)/80+1)* 1550;// ����
			%OneRan  = %OneRan[1] + %OneRan[2] + %OneRan[3] + %OneRan[4];
			%OneRan[5] = (10000 - %OneRan) * 0.2174;//105105302	��	
			%OneRan[6] = (10000 - %OneRan) * 0.870;//105105301	��Ҷ��	
			%OneRan[7] = (10000 - %OneRan) * 0.1217;//105105301	��Ҷ��	
			%OneRan[8] = (10000 - %OneRan) * 0.1391;//105105301	��Ҷ��	
			%OneRan[9] = (10000 - %OneRan) * 0.0870;//105270001	���	
			%OneRan[10] = 10000 - (%OneRan + %OneRan[5] + %OneRan[6] + %OneRan[7] + %OneRan[8] + %OneRan[9]);//105270001	���
			%NowRan = 0;
			for (%i = 1; %i <= 10; %i++)
			{
				%NowRan = %NowRan + %OneRan[%i];
				if (%NowRan >=  %Ran && %OneRan[%i]  > 0)
					return %i;
			}
		case 2:
			%OneRan[1] = (((%Lucky / 10)+ %SourceA + %SourceB)/20+1)* 40;
			%OneRan[2] = (((%Lucky / 10)+ %SourceA + %SourceB)/20+1)* 80;
			%OneRan[3] = (((%Lucky / 10)+ %SourceA + %SourceB)/20+1)* 4;
			%OneRan[4] = (((%Lucky / 10)+ %SourceA + %SourceB)/20+1)* 160;
			%OneRan[5] = (((%Lucky / 10)+ %SourceA + %SourceB)/80+1)* 1550;
			%OneRan  = %OneRan[1] + %OneRan[2] + %OneRan[3] + %OneRan[4] + %OneRan[5];
			%OneRan[6] = (10000 - %OneRan) * 0.4488;
			%OneRan[7] = (10000 - %OneRan) * 0.3937;
			%OneRan[8] = 10000 - (%OneRan + %OneRan[6] + %OneRan[7]);
			%NowRan = 0;
			for (%i = 1; %i <= 8; %i++)
			{
				%NowRan = %NowRan + %OneRan[%i];
				if (%NowRan >=  %Ran && %OneRan[%i]  > 0)
					return %i;
			}
		case 3:
			%OneRan[1] = (((%Lucky / 10)+ %SourceA + %SourceB)/20+1)* 30;
			%OneRan[2] = (((%Lucky / 10)+ %SourceA + %SourceB)/20+1)* 32;
			%OneRan[3] = (((%Lucky / 10)+ %SourceA + %SourceB)/20+1)* 30;
			%OneRan[4] = (((%Lucky / 10)+ %SourceA + %SourceB)/20+1)* 200;
			%OneRan  = %OneRan[1] + %OneRan[2] + %OneRan[3] + %OneRan[4];
			%OneRan[5] = (10000 - %OneRan) * 0.2342;
			%OneRan[6] = (10000 - %OneRan) * 0.2342;
			%OneRan[7] = 10000 - (%OneRan + %OneRan[5] + %OneRan[6]);
			%NowRan = 0;
			for (%i = 1; %i <= 7; %i++)
			{
				%NowRan = %NowRan + %OneRan[%i];
				if (%NowRan >=  %Ran && %OneRan[%i]  > 0)
					return %i;
			}
	}
}
function GetStoreForAntiques(%player, %level)//��������ı�ʯ���
{
	%Ran = GetRanDom(1, 10000);
	if (%Ran <= 335) %ItemID = 110010083;//�﹥�˺�����    
	else if (%Ran <= 670) %ItemID = 110010093;//�����˺�����    
	else if (%Ran <= 1153) %ItemID = 110010503;//����������ʯ    
	else if (%Ran <= 1636) %ItemID = 110010513;//����������ʯ    
	else if (%Ran <= 2119) %ItemID = 110010523;//�����﹥��ʯ    
	else if (%Ran <= 2602) %ItemID = 110010533;//������С�﹥��ʯ
	else if (%Ran <= 3085) %ItemID = 110010543;//��������﹥��ʯ
	else if (%Ran <= 3568) %ItemID = 110010553;//����������ʯ    
	else if (%Ran <= 4051) %ItemID = 110010563;//������С������ʯ
	else if (%Ran <= 4534) %ItemID = 110010573;//������󷨹���ʯ
	else if (%Ran <= 4984) %ItemID = 110020063;//�������������ʯ
	else if (%Ran <= 5434) %ItemID = 110020073;//���ӷ���������ʯ
	else if (%Ran <= 5759) %ItemID = 110020083;//�﹥�ܻ�����    
	else if (%Ran <= 6084) %ItemID = 110020093;//�����ܻ�����    
	else if (%Ran <= 6360) %ItemID = 110020113;//���˱�ʯ        
	else if (%Ran <= 6810) %ItemID = 110030023;//�������ܱ�ʯ    
	else if (%Ran <= 7260) %ItemID = 110030033;//�������ܱ�ʯ    
	else if (%Ran <= 7540) %ItemID = 110030043;//������ʯ        
	else if (%Ran <= 7820) %ItemID = 110030053;//�����˺���ʯ    
	else if (%Ran <= 8100) %ItemID = 110030063;//�������ⱦʯ    
	else if (%Ran <= 8380) %ItemID = 110030073;//�����˺����ⱦʯ
	else if (%Ran <= 8660) %ItemID = 110030113;//����һ��        
	else if (%Ran <= 8940) %ItemID = 110030123;//����һ������    
	else if (%Ran <= 9220) %ItemID = 110030133;//����һ���˺�    
	else if (%Ran <= 9500) %ItemID = 110030143;//�����˺�����    
	else if (%Ran <= 10000) %ItemID = 110010613;//�������Ʊ�ʯ    

	if (%level == 4)
		%ItemID = %ItemID + 1;
	else if (%Level == 5)
		%ItemID = %ItemID + 2;

	//echo( %ItemID @ "   " @ GetItemData( %ItemID, 1 ) );
	return %ItemID;
}


//�������������������������컯��ʯ�ϳɡ���ء�������������������������������
function getShenShiSucceed(%playerid, %itemid, %itemNum)  //��ȡ��ʯ�ϳɵĸ��� ʵ�ʸ���
{
	//echo( " %playerid ===" @  %playerid @ "    %itemid==" @  %itemid @ "     %itemNum==" @  %itemNum );
	if ($Now_Script == 2)
		%Player = SptGetPlayer(%playerid);
	else if ($Now_Script == 1)
		%Player = GetPlayer();

	%itemLevel = GetItemData(%itemid, $Item_Data_Lv);//��õ��ߵȼ�
	%goodluck = %Player.getLuck();//��ȡ��Ҹ�Եֵ
	if (%goodluck <100)%goodluck = 0;
	switch (%itemNum)
	{
		case 2: %MaxSucceed = 4000; %MinSucceed = 3000; %ShowMaxSucceed = 5000;
		case 3: %MaxSucceed = 6000; %MinSucceed = 4500; %ShowMaxSucceed = 7000;
		case 4: %MaxSucceed = 8000; %MinSucceed = 6000; %ShowMaxSucceed = 9000;
		case 5: %MaxSucceed =10000; %MinSucceed =10000; %ShowMaxSucceed = 10000;
	}

	if ($Now_Script == 1)//�ͻ�����ʾ
	{
		%Result =mfloor(%MaxSucceed + (%goodluck / (500 * (1 + %itemLevel / 10))*(%ShowMaxSucceed - %MaxSucceed)));
		if (%Result > %ShowMaxSucceed) %Result = %ShowMaxSucceed;
	}
	else if ($Now_Script == 2)//�����ʵ�ʵ���
	{
		%Result = mfloor(%MinSucceed + (%goodluck / (500 * (1 + %itemLevel / 10))*(%MaxSucceed - %MinSucceed)));
		if (%Result > %MaxSucceed) %Result = %MaxSucceed;
	}
	//echo( "�컯��ʯ�ϳ�%Result=====" @ %Result );
	return %Result;
}


function getShenShiResultID(%itemid) //��ȡ��ʯ�ϳɺ�Ľ��
{
	return %itemid+1;
}

//��ȡ�컯��ʯ�ϳɵĽ�����ģ� �컯��ʯID������
function getShenShiNeedMoney(%itemid, %ItemCount)
{
	%itemLevel = GetItemData(%itemid, $Item_Data_Lv);//��õ��ߵȼ�
	%NeedJinBi = mfloor((%itemLevel - 4) * 50000 / %ItemCount);
	return %NeedJinBi;
}


//��������������������������ֵ�������ء�����������������������������������
function GetFirstRechargeGitf(%type)//�׳�������ص���
{
	switch (%type)
	{
		case 0:return 116080005;//�칤����( �� )		
		case 1:return 105021051;//������( ��Ʒ )		
		case 2:return 112010058;//8��Ǭ����( ��Ʒ )	
		case 3:return 105109371;//һ����Ѫ����Ʒ( 4 )
		case 4:return 105109381;//һ������ɢ��Ʒ( 4 )
	}
}

function GetFisrtRechargeForDays(%type)//ÿ�ճ�ֵ���ص���
{
	switch (%type)
	{
		case 0:return "105109331 5"; //����ˢ����	
		case 1:return "105021051 1"; //������( ��Ʒ )	
		case 2:return "105109032 2"; //����̵�ˢ����	
		case 3:return "105109032 5"; //����̵�ˢ����	
		case 4:return "105028022 5"; //�������鵤( ��Ʒ )
	}
}
function GetRechargeHaoLiItem(%type)//��ȡ���񷵻ص���
{
	switch (%type)
	{
		case 0:  return "116080005 1 105021061 1 112010056 1 105109371 1 105109381 1";
		case 1:  return "116080005 1 105021051 1 105028012 1 105109371 1 105109381 1";
		case 2:  return "105105301 1 105090911 2 105028012 1 113050004 5 116060001 1";
		case 3:	 return "105090911 2 105105302 1 105028012 1 113050004 5 116060001 2";
		case 4:	 return "105105302 1 105090911 2 105028012 1 116060001 5 105090501 5";
		case 5:	 return "105105303 1 105090911 2 105028022 1 105090501 30 105090601 30";
		case 6:	 return "105105303 1 105090911 2 105180152 1 105090501 30 105090601 30";
		case 7:	 return "105105303 1 105090911 5 105180072 1 105090511 30 105090611 30";
		case 8:	 return "113010051 10 105090911 5 105180092 1 105090511 40 105090611 40";
		case 9:	 return "113010051 10 105090911 10 105180102 1 105090511 50 105090611 50";
		case 10: return "113010051 10 105090911 10 105180082 1 105090511 50 105090611 50";
		case 11: return "113010051 10 105090911 10 105180153 1 105090511 50 105090611 50";
		case 12: return "113010051 10 105090911 20 105180073 1 105090511 50 105090611 50";
		case 13: return "113010051 10 105090911 20 105180093 1 105100181 10 105100182 5";
		case 14: return "113010051 10 105090911 20 105180103 1 105100181 10 105100182 5";
		case 15: return "113010051 10 105090911 20 105180083 1 105100181 10 105100182 5";
		case 16: return "113010051 10 105090911 30 105180154 1 105100181 10 105100182 5";
		case 17: return "113010051 10 105090911 30 105180074 1 105100181 10 105100182 5";
		case 18: return "113010051 10 105090911 30 105180094 1 105100181 10 105100182 5";
		case 19: return "113010051 10 105090911 40 105180104 1 105100181 10 105100182 5";
		case 20: return "113010051 10 105090911 40 105180084 1 105100181 10 105100182 5";
		case 21: return "113010051 10 105090911 50 105180154 1 105100181 10 105100182 5";
		case 22: return "113010051 10 105090911 50 105180074 1 105100181 10 105100182 5";
		case 23: return "113010051 10 105090911 50 105180094 1 105100181 10 105100182 5";
		case 24: return "113010051 10 105090911 50 105180104 1 105100181 10 105100182 5";
		case 25: return "113010051 10 105090911 50 105180084 1 105100181 10 105100182 5";
		case 26: return "113010051 10 105090911 50 105180154 1 105100181 10 105100182 5";
		case 27: return "113010051 10 105090911 50 105180074 1 105100181 10 105100182 5";
		case 28: return "113010051 10 105090911 50 105180094 1 105100181 10 105100182 5";
		case 29: return "113010051 10 105090911 50 105180104 1 105100181 10 105100182 5";
		case 30: return "113010051 10 105090911 50 105180084 1 105100181 10 105100182 5";
		case 31: return "113010051 10 105090911 100 105180154 1 105100181 10 105100182 5";
		case 32: return "113010051 10 105090911 100 105180074 1 105100181 10 105100182 5";
		case 33: return "113010051 10 105090911 100 105180094 1 105100181 10 105100182 5";
		case 34: return "113010051 10 105090911 100 105180104 1 105100181 10 105100182 5";
	}
}

function GetRechargeHaoLiQuota(%type)//��ȡ������׶���Ҫ�Ķ��
{
	switch (%type)
	{
		case 0: %Money = 18;
		case 1: %Money = 50;
		case 2: %Money = 100;
		case 3: %Money = 200;
		case 4: %Money = 500;
		case 5: %Money = 1000;
		case 6: %Money = 2000;
		case 7: %Money = 5000;
		case 8: %Money = 10000;
		case 9: %Money = 15000;
		case 10: %Money = 20000;
		case 11: %Money = 30000;
		case 12: %Money = 40000;
		case 13: %Money = 50000;
		case 14: %Money = 60000;
		case 15: %Money = 70000;
		case 16: %Money = 80000;
		case 17: %Money = 90000;
		case 18: %Money = 100000;
		case 19: %Money = 150000;
		case 20: %Money = 200000;
		case 21: %Money = 250000;
		case 22: %Money = 300000;
		case 23: %Money = 350000;
		case 24: %Money = 400000;
		case 25: %Money = 450000;
		case 26: %Money = 500000;
		case 27: %Money = 600000;
		case 28: %Money = 700000;
		case 29: %Money = 800000;
		case 30: %Money = 900000;
		case 31: %Money = 1000000;
		case 32: %Money = 1200000;
		case 33: %Money = 1500000;
		case 34: %Money = 2000000;
	}
	return %Money * 100;
}

//$PlayGameReturnTime[ 4095 ] = $XZL_ClearTime_Tomorrow[ 1 ];//��¼ÿ�ճ�ֵ 0λ bit������ȡ��Щ��� 1λ �����ֵ����
//$PlayGameReturnTime[ 4097 ] = $XZL_ClearTime_Never[ 1 ];//��¼�׳���� 0λ 1��ȡ0û����ȡ 1λ ��ǰ��ֵ���
function SetIsCanReceiveFirstRecharge(%Player)//��¼�׳������ȡ��¼ 
{
	%Act1 = GetAct(%Player, 4097, 1) * 1;
	SetAct(%Player, 4097, 1, %Act1);
}
function GetIsCanReceiveFirstRecharge(%Player)//�����׳�����Ƿ������ȡ  ����ֵ��-1�Ѿ���ȡ 0������ȡ >0 ������ȡ��������ô��Ԫ��
{
	%Act0 = GetAct(%Player, 4097, 0) * 1;
	%Act1 = GetAct(%Player, 4097, 1) * 1;
	if (%Act0 == 1)
		return -1;
	else
	{
		if (%Act1 >= 1000)
			return 0;
		else
			return 1000 - %Act1;
	}
}
function SetIsCanReceiveRechargeDays(%Player, %Index)//����ÿ�ճ�ֵ��¼ %Index 0 - 4 �ڼ������
{
	%Act0 = GetAct(%Player, 4095, 0);
	%Act1 = GetAct(%Player, 4095, 1);
	%Act0 = SetBit(%Act0, %Index);
	SetAct(%Player, 4095, %Act0, %Act1);
}
function GetIsCanReceiveRechargeDays(%Player, %Index)//����ÿ�ճ�ֵ����Ƿ������ȡ %Index 0 - 4 �ڼ������  ����ֵ��-1�Ѿ���ȡ 0������ȡ >0 ������ȡ��������ô��Ԫ��
{
	//-1�Ѿ���ȡ 1������ȡ 0��ֵ������������
	%Act0 = GetAct(%Player, 4095, 0);
	%Act1 = GetAct(%Player, 4095, 1);
	switch (%Index)
	{
		case 0: %Money = 900;
		case 1: %Money = 6800;
		case 2: %Money = 18800;
		case 3: %Money = 69800;
		case 4: %Money = 188800;
	}
	if (CheckBit(%Act0, %Index) == 1)
		return -1;
	else
	{
		if (%Act1 * 100 < %Money)
			return %Money - %Act1 * 100;
		else
			return 0;
	}

}
function SetIsCanReceiveRechargeHaoLi(%Player, %Index)//���ó�ֵ������ȡ��¼ %Index 0 - 34 �ڼ������ 
{
	%Src = 144 + %Index;
	SetSrc(%Player, %Src);
}
function GetIsCanReceiveRechargeHaoLi(%Player, %Index)//���س�ֵ�����Ƿ������ȡ %Index 0 - 34 �ڼ������ ����ֵ��-1�Ѿ���ȡ 0������ȡ >0 ������ȡ��������ô��Ԫ��
{
	%Gold = %Player.GetTotalDrawGold();// �ܵ���ȡԪ������
	%Src = 144 + %Index;
	if (GetSrc(%Player, %Src) == 1)
		return -1;
	%NeedMoney = GetRechargeHaoLiQuota(%Index);//��ȡ������׶���Ҫ�Ķ��
	if (%NeedMoney <= %Gold)
		return 0;
	else
		return %NeedMoney - %Gold;
}


function ReceiveRechargeClear(%Player)//������г�ֵ�����ȡ��¼
{
	for (%Src = 144; %Src <= 178; %Src++)
	{
		DelSrc(%Player, %Src);
	}
	SetAct(%Player, 4095, 0, 0);
}
//��������������������������ֵ�������ء�����������������������������������


//���������������������������߽�������ء�����������������������������������
function GetStateOnlineReward(%Type)
{
	switch (%Type)
	{
		case 0:return "105028002 1"; //˫�����鵤( ��Ʒ )
		case 1:return "112010055 1"; //5��Ǭ����( ��Ʒ )
		case 2:return "112010056 1"; //6��Ǭ����( ��Ʒ )
		case 3:return "105090911 2"; //����ͨ��( ��Ʒ )
		case 4:return "105028012 1"; //2.5�����鵤( ��Ʒ )
		case 5:return "105021051 1"; //������( ��Ʒ )
		case 6:return "105028022 1"; //�������鵤( ��Ʒ )
		case 7:return "105180201 1"; //�������
	}
}
function CanGetStateOnlineReward(%Player, %Type)
{
	%Src = 179 + %type;
	if (GetSrc(%Player, %Src) == 0)
		return 1;
	else
		return 0;
}
//���������������������������߽�������ء�����������������������������������


//����������������������������̵꡿��ء�����������������������������������
function GetFreeTimesForRanShop(%Player)//ÿ�������Ѵ���
{
	VIP_getNowTequanLvMaxCnt(%Player, 3);
}

// %Optype ��λ �Ա� ְҵ���ص���ID ԭ�� ���ʣ����֮)
function GetSpecialRanShopItem(%Optype, %Sex, %Class)//������߽��� 
{
	if (%Optype == 2) return "119013017 193600 143";
	switch (%Sex)
	{
		case 1:return "102105024 73600 151";
		case 2:return "102105524 73600 151";
		default:return "119013017 193600 143";
	}
}

function GetPrayShopItem(%Optype)//�������������ʾ��3������չʾ
{
	if (%Optype == 2)
		return 119013032;
	if (%Optype == 3)
		return 119013033;
	%Sex = getplayer().getsex();
	if (%Optype == 1 && %Sex==1) return 102105015;
	else return 102105515;
}
//����������������������������̵꡿��ء�����������������������������������

//����������������������������ս����ء�����������������������������������
//OpenAttackCityApplyWnd

//����������������������������ս����ء�����������������������������������


//��������������������������ֵ��������ء�����������������������������������
function GetChargeBackGiftSorce(%index)
{
	if ($SL_ChongZhiFanKui_State_bActive == 1)
	{
		switch (%index)
		{
			case 1:return 98;
			case 2:return 980;
			case 3:return 1980;
			case 4:return 3680;
			default:return 10000;
		}
	}
	else
	{
		switch (%index)
		{
			case 1:return 98;
			case 2:return 980;
			case 3:return 1980;
			case 4:return 3680;
			default:return 10000;
		}
	}
}
function GetChargeBackGiftItemID(%index)
{
	switch ($SL_ChongZhiFanKui_State_bActive)
	{
		case 1:
			switch (%index)
			{
				case 1:return 105180241;//׳־���Ĵ����(�·�ר��)
				case 2:return 105180242;//����Ӣ�۴����(�·�ר��)
				case 3:return 105180243;//������ʥ�����(�·�ר��)
				case 4:return 105180244;//������ʦ�����(�·�ר��)
				default:return 0;
			}
		default:
			switch (%index)
			{
				case 1:return 105180251;//׳־���Ĵ����
				case 2:return 105180252;//����Ӣ�۴����
				case 3:return 105180253;//������ʥ�����
				case 4:return 105180254;//������ʦ�����
				default:return 0;
			}
	}
}
//��������������������������ֵ��������ء�����������������������������������


//�������������������������齱�������桿��ء�������������������������������
/*
ShowPrizeNotice(sptgetplayer(50000002), 105109021, 1, 0, 1, 3);
ShowPrizeNotice(sptgetplayer(50000002), 105109021, 5, 0, 1, 3);
ShowPrizeNotice(sptgetplayer(50000002), 105109021, 10, 0, 1, 3);

ShowPrizeNotice(sptgetplayer(50000002), 105270002, 1, 0, 500, 3);
ShowPrizeNotice(sptgetplayer(50000002), 105270002, 5, 0, 500, 3);
ShowPrizeNotice(sptgetplayer(50000002), 105270002, 10, 0, 500, 3);

ShowPrizeNotice(sptgetplayer(50000002), 105270002, 1, 1, 1000, 3);
ShowPrizeNotice(sptgetplayer(50000002), 105270002, 5, 1, 1000, 3);
ShowPrizeNotice(sptgetplayer(50000002), 105270002, 10, 1, 1000, 3);
*/
function ShowPrizeNotice(%Player, %Itemid, %Continuity, %isbool, %Count, %Istrue)//��Ҷ��� ���߱�� �������  Ԫ����ʾ��ʽ   ���߳��� �Ƿ񹫸�
{
	if (%Istrue <= 0)
		return;
	if (%Itemid > 0 && %Itemid != 105270002)
	{
		%ItemName1 =  $Get_Dialog_GeShi[31420] @ %Count @ "</t><t>��</t>" @ GetItemName(%ItemID, 1);
		%ItemName2 =  $Get_Dialog_GeShi[60002] @ %Count @ "</t><t>��</t>" @ GetItemName(%ItemID, 2);
	}
	else if (%Count > 0 && %Itemid == 105270002)
	{
		switch (%isbool)
		{
			case 0:
				%ItemName1 = GetHuoDongName(%Count @ "Ԫ��", 1);
				%ItemName2 = GetHuoDongName(%Count @ "Ԫ��", 2);
			case 1:
				%ItemName1 = "<t>������</t>" @ GetHuoDongName(mceil(%Count/100) @ "%Ԫ��", 1);
				%ItemName2 = "<t>������</t>" @ GetHuoDongName(mceil(%Count/100) @ "%Ԫ��", 2);
		}
	}

	%Playername1 = GetPlayerZiTiName(%Player, 1);
	%Playername2= GetPlayerZiTiName(%Player, 2);

	%HuoDongMingCheng1 = GetHuoDongName("��Ե��ǩ", 1);
	%HuoDongMingCheng2 = GetHuoDongName("��Ե��ǩ", 2);

	switch (%Continuity)
	{
		case 1:%TakeText = "<t>�齱�����</t>";
		case 5:%TakeText = "<t>��������ǩ�������</t>";
		case 10:%TakeText = "<t>������ʮǩ�������</t>";
	}
	%Msg1 = "<t>���Ǹ��գ�</t>" @ %Playername1 @ "<t>��</t>" @ %HuoDongMingCheng1 @ "<t>��У�</t>" @ %TakeText @ %ItemName1 @ "<t>��������ɷ���ˡ�</t>";
	%Msg2 = "<t>���Ǹ��գ�</t>" @ %Playername2 @ "<t>��</t>" @ %HuoDongMingCheng2 @ "<t>��У�</t>" @ %TakeText @ %ItemName2;
	//echo(" %Msg1===" @ %Msg1);
	//echo(" %Msg2===" @ %Msg2);
	switch (%Istrue)
	{
		case 1:
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg2 @ "</t>", $chatMsg_Type_Normal2);

		case 2:
			SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Msg1 @ "</t>");
		case 3:
			SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Msg1 @ "</t>");
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg2 @ "</t>", $chatMsg_Type_Normal2);
	}
}
//ShowPrayGiftNotice(263145,105109495,4,3,1);
function ShowPrayGiftNotice(%Player, %ItemID, %ItemNum, %type, %msg)
{
	if (%msg < 1)
		return;
	switch (%type)
	{
		case 1:%HuoDongMingCheng1 = GetHuoDongName("��ͭ��", 1); %HuoDongMingCheng2 = GetHuoDongName("��ͭ��", 2);
		case 2:%HuoDongMingCheng1 = GetHuoDongName("������", 1); %HuoDongMingCheng2 = GetHuoDongName("������", 2);
		case 3:%HuoDongMingCheng1 = GetHuoDongName("�ƽ���", 1); %HuoDongMingCheng2 = GetHuoDongName("�ƽ���", 2);
		default:return;
	}
	%PlayerName1 = GetPlayerZiTiName(%Player, 1);
	%PlayerName2 = GetPlayerZiTiName(%Player, 2);
	%ItemName1 = GetItemName(%ItemID, 1);
	%ItemName2 = GetItemName(%ItemID, 2);
	%Icount1 = $Get_Dialog_GeShi[31420] @ %ItemNum @ "</t>";
	%Icount2 = $Get_Dialog_GeShi[60002] @ %ItemNum @ "</t>";
	%Text1 = "<t>�콵��Ե��</t>" @ %PlayerName1 @ "<t>������Ը����</t>" @ %HuoDongMingCheng1 @ "<t>��������</t>" @ %Icount1 @ "<t>��</t>" @ %ItemName1 @ "<t>������</t>";
	%Text2 = "<t>�콵��Ե��</t>" @ %PlayerName2 @ "<t>������Ը����</t>" @ %HuoDongMingCheng2 @ "<t>��������</t>" @ %Icount2 @ "<t>��</t>" @ %ItemName2 @ "<t>������</t>";
	switch (%msg)
	{
		case 1:
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
		case 2:
			SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Text1 @ "</t>");
		case 3:
			SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Text1 @ "</t>");
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
}

//�������������������������齱�������桿��ء�������������������������������

//������������������������ȫ��ᱦ��ء���������������������������������
//ȫ��ᱦ�ű�ȫ�ֱ���																	
$QuanMingDuoBao_ItemList[1, 0] = "105180073 125 105290023 10";        //1�ŵ�1��   ��Ʒ1:�챦ʯ������(4��)_�۸�:125�ᱦ����  ��Ʒ2:3����ʯ�컯��_�۸�:10�ᱦ����																	
$QuanMingDuoBao_ItemList[1, 1] = "116060106 35 105101701 10";         //1�ŵ�2��   ��Ʒ1:6���컯��ʯ_�۸�:35�ᱦ����  ��Ʒ2:˫������(С)_�۸�:10�ᱦ����																	
$QuanMingDuoBao_ItemList[1, 2] = "102105515 555 110030134 375";       //1�ŵ�3��   ��Ʒ1:��������(Ů)_�۸�:555�ᱦ����  ��Ʒ2:����һ���˺�_�۸�:375�ᱦ����																	
$QuanMingDuoBao_ItemList[1, 3] = "102105015 555 119013077 1136";      //1�ŵ�4��   ��Ʒ1:��������(��)_�۸�:555�ᱦ����  ��Ʒ2:����_�۸�:1136�ᱦ����																	
$QuanMingDuoBao_ItemList[1, 4] = "105105128 100 105101747 16";        //1�ŵ�5��   ��Ʒ1:100��Ҷһ�ȯ_�۸�:100�ᱦ����  ��Ʒ2:����ˢ�����(��)_�۸�:16�ᱦ����																	

$QuanMingDuoBao_ItemList[2, 0] = "105180093 125 105290032 15";        //2�ŵ�1��   ��Ʒ1:�̱�ʯ������(4��)_�۸�:125�ᱦ����  ��Ʒ2:4����ʯ�컯��_�۸�:15�ᱦ����																	
$QuanMingDuoBao_ItemList[2, 1] = "105101704 100 105105128 100";       //2�ŵ�2��   ��Ʒ1:2.5������(С)_�۸�:100�ᱦ����  ��Ʒ2:100��Ҷһ�ȯ_�۸�:100�ᱦ����																	
$QuanMingDuoBao_ItemList[2, 2] = "119013028 1936 102105518 300";      //2�ŵ�3��   ��Ʒ1:����_�۸�:1936�ᱦ����  ��Ʒ2:����(Ů)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[2, 3] = "116060108 875 102105018 300";       //2�ŵ�4��   ��Ʒ1:8���컯��ʯ_�۸�:875�ᱦ����  ��Ʒ2:����(��)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[2, 4] = "105101783 30 105101747 16";         //2�ŵ�5��   ��Ʒ1:һ���ǻ���(��)_�۸�:30�ᱦ����  ��Ʒ2:����ˢ�����(��)_�۸�:16�ᱦ����																	

$QuanMingDuoBao_ItemList[3, 0] = "105180103 125 105101701 10";        //3�ŵ�1��   ��Ʒ1:����ʯ������(4��)_�۸�:125�ᱦ����  ��Ʒ2:˫������(С)_�۸�:10�ᱦ����																	
$QuanMingDuoBao_ItemList[3, 1] = "105101738 50 116060107 175";        //3�ŵ�2��   ��Ʒ1:��Ԫ������(��)_�۸�:50�ᱦ����  ��Ʒ2:7���컯��ʯ_�۸�:175�ᱦ����																	
$QuanMingDuoBao_ItemList[3, 2] = "102105019 300 105101707 300";       //3�ŵ�3��   ��Ʒ1:�������(��)_�۸�:300�ᱦ����  ��Ʒ2:3������(С)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[3, 3] = "102105519 300 116080007 200";       //3�ŵ�4��   ��Ʒ1:�������(Ů)_�۸�:300�ᱦ����  ��Ʒ2:�칤����(��)_�۸�:200�ᱦ����																	
$QuanMingDuoBao_ItemList[3, 4] = "105101785 10 105101783 30";         //3�ŵ�5��   ��Ʒ1:�����ǻ���(С)_�۸�:10�ᱦ����  ��Ʒ2:һ���ǻ���(��)_�۸�:30�ᱦ����																	

$QuanMingDuoBao_ItemList[4, 0] = "116060106 35 105290024 15";         //4�ŵ�1��   ��Ʒ1:6���컯��ʯ_�۸�:35�ᱦ����  ��Ʒ2:3����ʯ�컯��_�۸�:15�ᱦ����																	
$QuanMingDuoBao_ItemList[4, 1] = "105180113 250 116060107 175";       //4�ŵ�2��   ��Ʒ1:�챦ʯ��ѡ���(4��)_�۸�:250�ᱦ����  ��Ʒ2:7���컯��ʯ_�۸�:175�ᱦ����																	
$QuanMingDuoBao_ItemList[4, 2] = "116070002 250 102105029 300";       //4�ŵ�3��   ��Ʒ1:��起�_�۸�:250�ᱦ����  ��Ʒ2:��֮����(��)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[4, 3] = "110030054 375 102105529 300";       //4�ŵ�4��   ��Ʒ1:�����˺���ʯ_�۸�:375�ᱦ����  ��Ʒ2:��֮����(Ů)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[4, 4] = "105101785 10 105101789 100";        //4�ŵ�5��   ��Ʒ1:�����ǻ���(С)_�۸�:10�ᱦ����  ��Ʒ2:�����ǻ���(��)_�۸�:100�ᱦ����																	

$QuanMingDuoBao_ItemList[5, 0] = "105101701 10 105090413 20";         //5�ŵ�1��   ��Ʒ1:˫������(С)_�۸�:10�ᱦ����  ��Ʒ2:�ļ���ʯ�ϳɾ�_�۸�:20�ᱦ����																	
$QuanMingDuoBao_ItemList[5, 1] = "105180153 125 116070002 250";       //5�ŵ�2��   ��Ʒ1:��ʯ������(4��)_�۸�:125�ᱦ����  ��Ʒ2:��起�_�۸�:250�ᱦ����																	
$QuanMingDuoBao_ItemList[5, 2] = "102105530 300 116080009 5000";      //5�ŵ�3��   ��Ʒ1:�������(Ů��_�۸�:300�ᱦ����  ��Ʒ2:�칤����(��)_�۸�:5000�ᱦ����																	
$QuanMingDuoBao_ItemList[5, 3] = "102105030 300 119013034 1136";      //5�ŵ�4��   ��Ʒ1:�������(��)_�۸�:300�ᱦ����  ��Ʒ2:���׽���_�۸�:1136�ᱦ����																	
$QuanMingDuoBao_ItemList[5, 4] = "112020006 50 105101789 100";        //5�ŵ�5��   ��Ʒ1:�ֿ���չ��24��_�۸�:50�ᱦ����  ��Ʒ2:�����ǻ���(��)_�۸�:100�ᱦ����																	

$QuanMingDuoBao_ItemList[6, 0] = "105101779 6 105101657 25";          //6�ŵ�1��   ��Ʒ1:�ǽ�ʯ����(С)_�۸�:6�ᱦ����  ��Ʒ2:һ�سǾ�_�۸�:25�ᱦ����																	
$QuanMingDuoBao_ItemList[6, 1] = "116080008 1000 116060003 50";       //6�ŵ�2��   ��Ʒ1:�칤����(��)_�۸�:1000�ᱦ����  ��Ʒ2:����ʯ_�۸�:50�ᱦ����																	
$QuanMingDuoBao_ItemList[6, 2] = "105180133 250 102105532 300";       //6�ŵ�3��   ��Ʒ1:�̱�ʯ��ѡ���(4��)_�۸�:250�ᱦ����  ��Ʒ2:����ʱ��(Ů)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[6, 3] = "105101707 300 102105032 300";       //6�ŵ�4��   ��Ʒ1:3������(С)_�۸�:300�ᱦ����  ��Ʒ2:����ʱ��(��)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[6, 4] = "105101701 10 105101737 10";         //6�ŵ�5��   ��Ʒ1:˫������(С)_�۸�:10�ᱦ����  ��Ʒ2:��Ԫ������(С)_�۸�:10�ᱦ����																	

$QuanMingDuoBao_ItemList[7, 0] = "105101743 6 105180143 250";         //7�ŵ�1��   ��Ʒ1:����˫���÷ֿ�����(С)_�۸�:6�ᱦ����  ��Ʒ2:����ʯ��ѡ���(4��)_�۸�:250�ᱦ����																	
$QuanMingDuoBao_ItemList[7, 1] = "105101749 100 105101012 20";        //7�ŵ�2��   ��Ʒ1:����̵�ˢ�����(С)_�۸�:100�ᱦ����  ��Ʒ2:��������ʯ���_�۸�:20�ᱦ����																	
$QuanMingDuoBao_ItemList[7, 2] = "102105034 300 110020114 500";       //7�ŵ�3��   ��Ʒ1:DJ(��)_�۸�:300�ᱦ����  ��Ʒ2:���˱�ʯ_�۸�:500�ᱦ����																	
$QuanMingDuoBao_ItemList[7, 3] = "102105534 300 116080007 200";       //7�ŵ�4��   ��Ʒ1:DJ(Ů)_�۸�:300�ᱦ����  ��Ʒ2:�칤����(��)_�۸�:200�ᱦ����																	
$QuanMingDuoBao_ItemList[7, 4] = "105101779 6 105101656 25";          //7�ŵ�5��   ��Ʒ1:�ǽ�ʯ����(С)_�۸�:6�ᱦ����  ��Ʒ2:һ��������_�۸�:25�ᱦ����																	

$QuanMingDuoBao_ItemList[8, 0] = "116060106 35 105101022 25";         //8�ŵ�1��   ��Ʒ1:6���컯��ʯ_�۸�:35�ᱦ����  ��Ʒ2:��������ʯ���_�۸�:25�ᱦ����																	
$QuanMingDuoBao_ItemList[8, 1] = "105105129 200 105180154 660";       //8�ŵ�2��   ��Ʒ1:200��Ҷһ�ȯ_�۸�:200�ᱦ����  ��Ʒ2:��ʯ������(5��)_�۸�:660�ᱦ����																	
$QuanMingDuoBao_ItemList[8, 2] = "119013074 1936 102105036 500";      //8�ŵ�3��   ��Ʒ1:���������_�۸�:1936�ᱦ����  ��Ʒ2:�ػ�ʱװ(��)_�۸�:500�ᱦ����																	
$QuanMingDuoBao_ItemList[8, 3] = "116060108 875 102105536 500";       //8�ŵ�4��   ��Ʒ1:8���컯��ʯ_�۸�:875�ᱦ����  ��Ʒ2:�ػ�ʱװ(Ů)_�۸�:500�ᱦ����																	
$QuanMingDuoBao_ItemList[8, 4] = "105101022 25 105101221 10";         //8�ŵ�5��   ��Ʒ1:��������ʯ���_�۸�:25�ᱦ����  ��Ʒ2:��������ʯ����_�۸�:10�ᱦ����																	

$QuanMingDuoBao_ItemList[9, 0] = "110010004 150 110010014 150";       //9�ŵ�1��   ��Ʒ1:������ʯ_�۸�:150�ᱦ����  ��Ʒ2:������ʯ_�۸�:150�ᱦ����																	
$QuanMingDuoBao_ItemList[9, 1] = "116060003 50 105101707 300";        //9�ŵ�2��   ��Ʒ1:����ʯ_�۸�:50�ᱦ����  ��Ʒ2:3������(С)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[9, 2] = "110030114 375 102105515 555";       //9�ŵ�3��   ��Ʒ1:����һ��_�۸�:375�ᱦ����  ��Ʒ2:��������(Ů)_�۸�:555�ᱦ����																	
$QuanMingDuoBao_ItemList[9, 3] = "119013016 1136 102105015 555";      //9�ŵ�4��   ��Ʒ1:��ˮ����_�۸�:1136�ᱦ����  ��Ʒ2:��������(��)_�۸�:555�ᱦ����																	
$QuanMingDuoBao_ItemList[9, 4] = "105105129 200 116060107 175";       //9�ŵ�5��   ��Ʒ1:200��Ҷһ�ȯ_�۸�:200�ᱦ����  ��Ʒ2:7���컯��ʯ_�۸�:175�ᱦ����																	

$QuanMingDuoBao_ItemList[10, 0] = "112010014 100 105101737 10";       //10�ŵ�1��   ��Ʒ1:28��Ǭ����_�۸�:100�ᱦ����  ��Ʒ2:��Ԫ������(С)_�۸�:10�ᱦ����																	
$QuanMingDuoBao_ItemList[10, 1] = "110020044 150 110020054 150";      //10�ŵ�2��   ��Ʒ1:���������ʯ_�۸�:150�ᱦ����  ��Ʒ2:����������ʯ_�۸�:150�ᱦ����																	
$QuanMingDuoBao_ItemList[10, 2] = "102105518 300 119013019 1136";     //10�ŵ�3��   ��Ʒ1:����(Ů)_�۸�:300�ᱦ����  ��Ʒ2:����ӫ��_�۸�:1136�ᱦ����																	
$QuanMingDuoBao_ItemList[10, 3] = "102105018 300 110030144 375";      //10�ŵ�4��   ��Ʒ1:����(��)_�۸�:300�ᱦ����  ��Ʒ2:�����˺�����_�۸�:375�ᱦ����																	
$QuanMingDuoBao_ItemList[10, 4] = "116060108 875 105101657 25";       //10�ŵ�5��   ��Ʒ1:8���컯��ʯ_�۸�:875�ᱦ����  ��Ʒ2:һ�سǾ�_�۸�:25�ᱦ����																	

$QuanMingDuoBao_ItemList[11, 0] = "105101776 88 105101743 6";         //11�ŵ�1��   ��Ʒ1:��Ӣ�����(С)_�۸�:88�ᱦ����  ��Ʒ2:����˫���÷ֿ�����(С)_�۸�:6�ᱦ����																	
$QuanMingDuoBao_ItemList[11, 1] = "105101707 300 105101749 100";      //11�ŵ�2��   ��Ʒ1:3������(С)_�۸�:300�ᱦ����  ��Ʒ2:����̵�ˢ�����(С)_�۸�:100�ᱦ����																	
$QuanMingDuoBao_ItemList[11, 2] = "116080008 1000 102105019 300";     //11�ŵ�3��   ��Ʒ1:�칤����(��)_�۸�:1000�ᱦ����  ��Ʒ2:�������(��)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[11, 3] = "116080009 5000 102105519 300";     //11�ŵ�4��   ��Ʒ1:�칤����(��)_�۸�:5000�ᱦ����  ��Ʒ2:�������(Ů)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[11, 4] = "110030104 150 105101112 20";       //11�ŵ�5��   ��Ʒ1:���Ʊ�ʯ_�۸�:150�ᱦ����  ��Ʒ2:���׾���ʯ���_�۸�:20�ᱦ����																	

$QuanMingDuoBao_ItemList[12, 0] = "116060106 35 105101743 6";         //12�ŵ�1��   ��Ʒ1:6���컯��ʯ_�۸�:35�ᱦ����  ��Ʒ2:����˫���÷ֿ�����(С)_�۸�:6�ᱦ����																	
$QuanMingDuoBao_ItemList[12, 1] = "105101776 88 105101749 100";       //12�ŵ�2��   ��Ʒ1:��Ӣ�����(С)_�۸�:88�ᱦ����  ��Ʒ2:����̵�ˢ�����(С)_�۸�:100�ᱦ����																	
$QuanMingDuoBao_ItemList[12, 2] = "102105029 300 105101707 300";      //12�ŵ�3��   ��Ʒ1:��֮����(��)_�۸�:300�ᱦ����  ��Ʒ2:3������(С)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[12, 3] = "102105529 300 116060107 175";      //12�ŵ�4��   ��Ʒ1:��֮����(Ů)_�۸�:300�ᱦ����  ��Ʒ2:7���컯��ʯ_�۸�:175�ᱦ����																	
$QuanMingDuoBao_ItemList[12, 4] = "105101022 25 105290031 10";        //12�ŵ�5��   ��Ʒ1:��������ʯ���_�۸�:25�ᱦ����  ��Ʒ2:4����ʯ�컯��_�۸�:10�ᱦ����																	

$QuanMingDuoBao_ItemList[13, 0] = "105101738 50 105101122 25";        //13�ŵ�1��   ��Ʒ1:��Ԫ������(��)_�۸�:50�ᱦ����  ��Ʒ2:���׾���ʯ���_�۸�:25�ᱦ����																	
$QuanMingDuoBao_ItemList[13, 1] = "105105132 500 116080007 200";      //13�ŵ�2��   ��Ʒ1:500��Ҷһ�ȯ_�۸�:500�ᱦ����  ��Ʒ2:�칤����(��)_�۸�:200�ᱦ����																	
$QuanMingDuoBao_ItemList[13, 2] = "116060108 875 102105530 300";      //13�ŵ�3��   ��Ʒ1:8���컯��ʯ_�۸�:875�ᱦ����  ��Ʒ2:�������(Ů��_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[13, 3] = "119013036 1936 102105030 300";     //13�ŵ�4��   ��Ʒ1:Ы��_�۸�:1936�ᱦ����  ��Ʒ2:�������(��)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[13, 4] = "105101788 20 105101022 25";        //13�ŵ�5��   ��Ʒ1:�����ǻ���(С)_�۸�:20�ᱦ����  ��Ʒ2:��������ʯ���_�۸�:25�ᱦ����																	

$QuanMingDuoBao_ItemList[14, 0] = "105101788 20 105101211 7";         //14�ŵ�1��   ��Ʒ1:�����ǻ���(С)_�۸�:20�ᱦ����  ��Ʒ2:��������ʯ����_�۸�:7�ᱦ����																	
$QuanMingDuoBao_ItemList[14, 1] = "116080007 200 105180083 250";      //14�ŵ�2��   ��Ʒ1:�칤����(��)_�۸�:200�ᱦ����  ��Ʒ2:������ʯ������(4��)_�۸�:250�ᱦ����																	
$QuanMingDuoBao_ItemList[14, 2] = "102105532 300 116060108 875";      //14�ŵ�3��   ��Ʒ1:����ʱ��(Ů)_�۸�:300�ᱦ����  ��Ʒ2:8���컯��ʯ_�۸�:875�ᱦ����																	
$QuanMingDuoBao_ItemList[14, 3] = "102105032 300 110020115 2640";     //14�ŵ�4��   ��Ʒ1:����ʱ��(��)_�۸�:300�ᱦ����  ��Ʒ2:���˱�ʯ_�۸�:2640�ᱦ����																	
$QuanMingDuoBao_ItemList[14, 4] = "105101785 10 105101656 25";        //14�ŵ�5��   ��Ʒ1:�����ǻ���(С)_�۸�:10�ᱦ����  ��Ʒ2:һ��������_�۸�:25�ᱦ����																	

$QuanMingDuoBao_ItemList[15, 0] = "105101707 300 105101743 6";        //15�ŵ�1��   ��Ʒ1:3������(С)_�۸�:300�ᱦ����  ��Ʒ2:����˫���÷ֿ�����(С)_�۸�:6�ᱦ����																	
$QuanMingDuoBao_ItemList[15, 1] = "112010014 100 105101749 100";      //15�ŵ�2��   ��Ʒ1:28��Ǭ����_�۸�:100�ᱦ����  ��Ʒ2:����̵�ˢ�����(С)_�۸�:100�ᱦ����																	
$QuanMingDuoBao_ItemList[15, 2] = "110030124 375 102105034 300";      //15�ŵ�3��   ��Ʒ1:����һ������_�۸�:375�ᱦ����  ��Ʒ2:DJ(��)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[15, 3] = "116060109 4375 102105534 300";     //15�ŵ�4��   ��Ʒ1:9���컯��ʯ_�۸�:4375�ᱦ����  ��Ʒ2:DJ(Ů)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[15, 4] = "105101785 10 105101779 6";         //15�ŵ�5��   ��Ʒ1:�����ǻ���(С)_�۸�:10�ᱦ����  ��Ʒ2:�ǽ�ʯ����(С)_�۸�:6�ᱦ����																	

$QuanMingDuoBao_ItemList[16, 0] = "105101779 6 105101702 50";         //16�ŵ�1��   ��Ʒ1:�ǽ�ʯ����(С)_�۸�:6�ᱦ����  ��Ʒ2:˫������(��)_�۸�:50�ᱦ����																	
$QuanMingDuoBao_ItemList[16, 1] = "105105036 90 105105032 50";        //16�ŵ�2��   ��Ʒ1:9000Ԫ���һ�ȯ_�۸�:90�ᱦ����  ��Ʒ2:5000Ԫ���һ�ȯ_�۸�:50�ᱦ����																	
$QuanMingDuoBao_ItemList[16, 2] = "102105036 500 119013070 1936";     //16�ŵ�3��   ��Ʒ1:�ػ�ʱװ(��)_�۸�:500�ᱦ����  ��Ʒ2:����_�۸�:1936�ᱦ����																	
$QuanMingDuoBao_ItemList[16, 3] = "102105536 500 116080009 5000";     //16�ŵ�4��   ��Ʒ1:�ػ�ʱװ(Ů)_�۸�:500�ᱦ����  ��Ʒ2:�칤����(��)_�۸�:5000�ᱦ����																	
$QuanMingDuoBao_ItemList[16, 4] = "105101122 25 105101221 10";        //16�ŵ�5��   ��Ʒ1:���׾���ʯ���_�۸�:25�ᱦ����  ��Ʒ2:��������ʯ����_�۸�:10�ᱦ����																	

$QuanMingDuoBao_ItemList[17, 0] = "105090414 25 105101221 10";        //17�ŵ�1��   ��Ʒ1:�弶��ʯ�ϳɾ�_�۸�:25�ᱦ����  ��Ʒ2:��������ʯ����_�۸�:10�ᱦ����																	
$QuanMingDuoBao_ItemList[17, 1] = "105101780 30 110020005 792";       //17�ŵ�2��   ��Ʒ1:�ǽ�ʯ����(��)_�۸�:30�ᱦ����  ��Ʒ2:������ʯ_�۸�:792�ᱦ����																	
$QuanMingDuoBao_ItemList[17, 2] = "105180154 660 102105515 555";      //17�ŵ�3��   ��Ʒ1:��ʯ������(5��)_�۸�:660�ᱦ����  ��Ʒ2:��������(Ů)_�۸�:555�ᱦ����																	
$QuanMingDuoBao_ItemList[17, 3] = "119013023 1136 102105015 555";     //17�ŵ�4��   ��Ʒ1:����_�۸�:1136�ᱦ����  ��Ʒ2:��������(��)_�۸�:555�ᱦ����																	
$QuanMingDuoBao_ItemList[17, 4] = "105101221 10 105101786 50";        //17�ŵ�5��   ��Ʒ1:��������ʯ����_�۸�:10�ᱦ����  ��Ʒ2:�����ǻ���(��)_�۸�:50�ᱦ����																	

$QuanMingDuoBao_ItemList[18, 0] = "105090414 25 105101704 100";       //18�ŵ�1��   ��Ʒ1:�弶��ʯ�ϳɾ�_�۸�:25�ᱦ����  ��Ʒ2:2.5������(С)_�۸�:100�ᱦ����																	
$QuanMingDuoBao_ItemList[18, 1] = "112010014 100 105101780 30";       //18�ŵ�2��   ��Ʒ1:28��Ǭ����_�۸�:100�ᱦ����  ��Ʒ2:�ǽ�ʯ����(��)_�۸�:30�ᱦ����																	
$QuanMingDuoBao_ItemList[18, 2] = "102105518 300 119013032 1136";     //18�ŵ�3��   ��Ʒ1:����(Ů)_�۸�:300�ᱦ����  ��Ʒ2:����_�۸�:1136�ᱦ����																	
$QuanMingDuoBao_ItemList[18, 3] = "102105018 300 105180153 125";      //18�ŵ�4��   ��Ʒ1:����(��)_�۸�:300�ᱦ����  ��Ʒ2:��ʯ������(4��)_�۸�:125�ᱦ����																	
$QuanMingDuoBao_ItemList[18, 4] = "105101785 10 105101122 25";        //18�ŵ�5��   ��Ʒ1:�����ǻ���(С)_�۸�:10�ᱦ����  ��Ʒ2:���׾���ʯ���_�۸�:25�ᱦ����																	

$QuanMingDuoBao_ItemList[19, 0] = "105101738 50 105101743 6";         //19�ŵ�1��   ��Ʒ1:��Ԫ������(��)_�۸�:50�ᱦ����  ��Ʒ2:����˫���÷ֿ�����(С)_�۸�:6�ᱦ����																	
$QuanMingDuoBao_ItemList[19, 1] = "110030104 150 105101749 100";      //19�ŵ�2��   ��Ʒ1:���Ʊ�ʯ_�۸�:150�ᱦ����  ��Ʒ2:����̵�ˢ�����(С)_�۸�:100�ᱦ����																	
$QuanMingDuoBao_ItemList[19, 2] = "110030044 375 102105019 300";      //19�ŵ�3��   ��Ʒ1:������ʯ_�۸�:375�ᱦ����  ��Ʒ2:�������(��)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[19, 3] = "116060108 875 102105519 300";      //19�ŵ�4��   ��Ʒ1:8���컯��ʯ_�۸�:875�ᱦ����  ��Ʒ2:�������(Ů)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[19, 4] = "105101758 10 105101122 25";        //19�ŵ�5��   ��Ʒ1:�������ȸ���(С)_�۸�:10�ᱦ����  ��Ʒ2:���׾���ʯ���_�۸�:25�ᱦ����																	

$QuanMingDuoBao_ItemList[20, 0] = "105101738 50 105101704 100";       //20�ŵ�1��   ��Ʒ1:��Ԫ������(��)_�۸�:50�ᱦ����  ��Ʒ2:2.5������(С)_�۸�:100�ᱦ����																	
$QuanMingDuoBao_ItemList[20, 1] = "112010014 100 110030104 150";      //20�ŵ�2��   ��Ʒ1:28��Ǭ����_�۸�:100�ᱦ����  ��Ʒ2:���Ʊ�ʯ_�۸�:150�ᱦ����																	
$QuanMingDuoBao_ItemList[20, 2] = "102105029 300 116060108 875";      //20�ŵ�3��   ��Ʒ1:��֮����(��)_�۸�:300�ᱦ����  ��Ʒ2:8���컯��ʯ_�۸�:875�ᱦ����																	
$QuanMingDuoBao_ItemList[20, 3] = "102105529 300 105180083 250";      //20�ŵ�4��   ��Ʒ1:��֮����(Ů)_�۸�:300�ᱦ����  ��Ʒ2:������ʯ������(4��)_�۸�:250�ᱦ����																	
$QuanMingDuoBao_ItemList[20, 4] = "105101758 10 105101747 16";        //20�ŵ�5��   ��Ʒ1:�������ȸ���(С)_�۸�:10�ᱦ����  ��Ʒ2:����ˢ�����(��)_�۸�:16�ᱦ����																	

$QuanMingDuoBao_ItemList[21, 0] = "116060003 50 105101737 10";        //21�ŵ�1��   ��Ʒ1:����ʯ_�۸�:50�ᱦ����  ��Ʒ2:��Ԫ������(С)_�۸�:10�ᱦ����																	
$QuanMingDuoBao_ItemList[21, 1] = "105101750 500 105105037 100";      //21�ŵ�2��   ��Ʒ1:����̵�ˢ�����(��)_�۸�:500�ᱦ����  ��Ʒ2:10000Ԫ���һ�ȯ_�۸�:100�ᱦ����																	
$QuanMingDuoBao_ItemList[21, 2] = "105105305 1000 102105530 300";     //21�ŵ�3��   ��Ʒ1:��ʯ_�۸�:1000�ᱦ����  ��Ʒ2:�������(Ů��_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[21, 3] = "119013033 1136 102105030 300";     //21�ŵ�4��   ��Ʒ1:������_�۸�:1136�ᱦ����  ��Ʒ2:�������(��)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[21, 4] = "105101657 25 105101747 16";        //21�ŵ�5��   ��Ʒ1:һ�سǾ�_�۸�:25�ᱦ����  ��Ʒ2:����ˢ�����(��)_�۸�:16�ᱦ����																	

$QuanMingDuoBao_ItemList[22, 0] = "105180093 125 116060003 50";       //22�ŵ�1��   ��Ʒ1:�̱�ʯ������(4��)_�۸�:125�ᱦ����  ��Ʒ2:����ʯ_�۸�:50�ᱦ����																	
$QuanMingDuoBao_ItemList[22, 1] = "105101749 100 105101656 25";       //22�ŵ�2��   ��Ʒ1:����̵�ˢ�����(С)_�۸�:100�ᱦ����  ��Ʒ2:һ��������_�۸�:25�ᱦ����																	
$QuanMingDuoBao_ItemList[22, 2] = "102105532 300 105105305 1000";     //22�ŵ�3��   ��Ʒ1:����ʱ��(Ů)_�۸�:300�ᱦ����  ��Ʒ2:��ʯ_�۸�:1000�ᱦ����																	
$QuanMingDuoBao_ItemList[22, 3] = "102105032 300 116080009 5000";     //22�ŵ�4��   ��Ʒ1:����ʱ��(��)_�۸�:300�ᱦ����  ��Ʒ2:�칤����(��)_�۸�:5000�ᱦ����																	
$QuanMingDuoBao_ItemList[22, 4] = "105105130 300 112020006 50";       //22�ŵ�5��   ��Ʒ1:300��Ҷһ�ȯ_�۸�:300�ᱦ����  ��Ʒ2:�ֿ���չ��24��_�۸�:50�ᱦ����																	

$QuanMingDuoBao_ItemList[23, 0] = "105105130 300 105101656 25";       //23�ŵ�1��   ��Ʒ1:300��Ҷһ�ȯ_�۸�:300�ᱦ����  ��Ʒ2:һ��������_�۸�:25�ᱦ����																	
$QuanMingDuoBao_ItemList[23, 1] = "105101704 100 110020005 792";      //23�ŵ�2��   ��Ʒ1:2.5������(С)_�۸�:100�ᱦ����  ��Ʒ2:������ʯ_�۸�:792�ᱦ����																	
$QuanMingDuoBao_ItemList[23, 2] = "110030045 1980 102105034 300";     //23�ŵ�3��   ��Ʒ1:������ʯ_�۸�:1980�ᱦ����  ��Ʒ2:DJ(��)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[23, 3] = "110030134 375 102105534 300";      //23�ŵ�4��   ��Ʒ1:����һ���˺�_�۸�:375�ᱦ����  ��Ʒ2:DJ(Ů)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[23, 4] = "112010014 100 116060107 175";      //23�ŵ�5��   ��Ʒ1:28��Ǭ����_�۸�:100�ᱦ����  ��Ʒ2:7���컯��ʯ_�۸�:175�ᱦ����																	

$QuanMingDuoBao_ItemList[24, 0] = "105105032 50 116060106 35";        //24�ŵ�1��   ��Ʒ1:5000Ԫ���һ�ȯ_�۸�:50�ᱦ����  ��Ʒ2:6���컯��ʯ_�۸�:35�ᱦ����																	
$QuanMingDuoBao_ItemList[24, 1] = "105180153 125 116060107 175";      //24�ŵ�2��   ��Ʒ1:��ʯ������(4��)_�۸�:125�ᱦ����  ��Ʒ2:7���컯��ʯ_�۸�:175�ᱦ����																	
$QuanMingDuoBao_ItemList[24, 2] = "102105036 500 119013069 1936";     //24�ŵ�3��   ��Ʒ1:�ػ�ʱװ(��)_�۸�:500�ᱦ����  ��Ʒ2:����_�۸�:1936�ᱦ����																	
$QuanMingDuoBao_ItemList[24, 3] = "102105536 500 116080008 1000";     //24�ŵ�4��   ��Ʒ1:�ػ�ʱװ(Ů)_�۸�:500�ᱦ����  ��Ʒ2:�칤����(��)_�۸�:1000�ᱦ����																	
$QuanMingDuoBao_ItemList[24, 4] = "105101657 25 105180073 125";       //24�ŵ�5��   ��Ʒ1:һ�سǾ�_�۸�:25�ᱦ����  ��Ʒ2:�챦ʯ������(4��)_�۸�:125�ᱦ����																	

$QuanMingDuoBao_ItemList[25, 0] = "105101122 25 105105033 60";        //25�ŵ�1��   ��Ʒ1:���׾���ʯ���_�۸�:25�ᱦ����  ��Ʒ2:6000Ԫ���һ�ȯ_�۸�:60�ᱦ����																	
$QuanMingDuoBao_ItemList[25, 1] = "116060108 875 116060106 35";       //25�ŵ�2��   ��Ʒ1:8���컯��ʯ_�۸�:875�ᱦ����  ��Ʒ2:6���컯��ʯ_�۸�:35�ᱦ����																	
$QuanMingDuoBao_ItemList[25, 2] = "102105515 555 110030044 375";      //25�ŵ�3��   ��Ʒ1:��������(Ů)_�۸�:555�ᱦ����  ��Ʒ2:������ʯ_�۸�:375�ᱦ����																	
$QuanMingDuoBao_ItemList[25, 3] = "102105015 555 119013074 1936";     //25�ŵ�4��   ��Ʒ1:��������(��)_�۸�:555�ᱦ����  ��Ʒ2:���������_�۸�:1936�ᱦ����																	
$QuanMingDuoBao_ItemList[25, 4] = "116070002 250 105101022 25";       //25�ŵ�5��   ��Ʒ1:��起�_�۸�:250�ᱦ����  ��Ʒ2:��������ʯ���_�۸�:25�ᱦ����																	

$QuanMingDuoBao_ItemList[26, 0] = "105101022 25 105101743 6";         //26�ŵ�1��   ��Ʒ1:��������ʯ���_�۸�:25�ᱦ����  ��Ʒ2:����˫���÷ֿ�����(С)_�۸�:6�ᱦ����																	
$QuanMingDuoBao_ItemList[26, 1] = "105180083 250 105101749 100";      //26�ŵ�2��   ��Ʒ1:������ʯ������(4��)_�۸�:250�ᱦ����  ��Ʒ2:����̵�ˢ�����(С)_�۸�:100�ᱦ����																	
$QuanMingDuoBao_ItemList[26, 2] = "119013028 1936 102105518 300";     //26�ŵ�3��   ��Ʒ1:����_�۸�:1936�ᱦ����  ��Ʒ2:����(Ů)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[26, 3] = "116060108 875 102105018 300";      //26�ŵ�4��   ��Ʒ1:8���컯��ʯ_�۸�:875�ᱦ����  ��Ʒ2:����(��)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[26, 4] = "105105131 400 116070002 250";      //26�ŵ�5��   ��Ʒ1:400��Ҷһ�ȯ_�۸�:400�ᱦ����  ��Ʒ2:��起�_�۸�:250�ᱦ����																	

$QuanMingDuoBao_ItemList[27, 0] = "105101788 20 116080007 200";       //27�ŵ�1��   ��Ʒ1:�����ǻ���(С)_�۸�:20�ᱦ����  ��Ʒ2:�칤����(��)_�۸�:200�ᱦ����																	
$QuanMingDuoBao_ItemList[27, 1] = "105101657 25 105101704 100";       //27�ŵ�2��   ��Ʒ1:һ�سǾ�_�۸�:25�ᱦ����  ��Ʒ2:2.5������(С)_�۸�:100�ᱦ����																	
$QuanMingDuoBao_ItemList[27, 2] = "102105019 300 116080008 1000";     //27�ŵ�3��   ��Ʒ1:�������(��)_�۸�:300�ᱦ����  ��Ʒ2:�칤����(��)_�۸�:1000�ᱦ����																	
$QuanMingDuoBao_ItemList[27, 3] = "102105519 300 110030054 375";      //27�ŵ�4��   ��Ʒ1:�������(Ů)_�۸�:300�ᱦ����  ��Ʒ2:�����˺���ʯ_�۸�:375�ᱦ����																	
$QuanMingDuoBao_ItemList[27, 4] = "105101737 10 105105131 400";       //27�ŵ�5��   ��Ʒ1:��Ԫ������(С)_�۸�:10�ᱦ����  ��Ʒ2:400��Ҷһ�ȯ_�۸�:400�ᱦ����																	

$QuanMingDuoBao_ItemList[28, 0] = "105090414 25 105101737 10";        //28�ŵ�1��   ��Ʒ1:�弶��ʯ�ϳɾ�_�۸�:25�ᱦ����  ��Ʒ2:��Ԫ������(С)_�۸�:10�ᱦ����																	
$QuanMingDuoBao_ItemList[28, 1] = "116080007 200 105101780 30";       //28�ŵ�2��   ��Ʒ1:�칤����(��)_�۸�:200�ᱦ����  ��Ʒ2:�ǽ�ʯ����(��)_�۸�:30�ᱦ����																	
$QuanMingDuoBao_ItemList[28, 2] = "110030124 375 102105029 300";      //28�ŵ�3��   ��Ʒ1:����һ������_�۸�:375�ᱦ����  ��Ʒ2:��֮����(��)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[28, 3] = "116060109 4375 102105529 300";     //28�ŵ�4��   ��Ʒ1:9���컯��ʯ_�۸�:4375�ᱦ����  ��Ʒ2:��֮����(Ů)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[28, 4] = "105101788 20 105101737 10";        //28�ŵ�5��   ��Ʒ1:�����ǻ���(С)_�۸�:20�ᱦ����  ��Ʒ2:��Ԫ������(С)_�۸�:10�ᱦ����																	

$QuanMingDuoBao_ItemList[29, 0] = "105101743 6 105105034 70";         //29�ŵ�1��   ��Ʒ1:����˫���÷ֿ�����(С)_�۸�:6�ᱦ����  ��Ʒ2:7000Ԫ���һ�ȯ_�۸�:70�ᱦ����																	
$QuanMingDuoBao_ItemList[29, 1] = "105101749 100 116060106 35";       //29�ŵ�2��   ��Ʒ1:����̵�ˢ�����(С)_�۸�:100�ᱦ����  ��Ʒ2:6���컯��ʯ_�۸�:35�ᱦ����																	
$QuanMingDuoBao_ItemList[29, 2] = "102105530 300 110020114 500";      //29�ŵ�3��   ��Ʒ1:�������(Ů��_�۸�:300�ᱦ����  ��Ʒ2:���˱�ʯ_�۸�:500�ᱦ����																	
$QuanMingDuoBao_ItemList[29, 3] = "102105030 300 119013034 1136";     //29�ŵ�4��   ��Ʒ1:�������(��)_�۸�:300�ᱦ����  ��Ʒ2:���׽���_�۸�:1136�ᱦ����																	
$QuanMingDuoBao_ItemList[29, 4] = "110030114 375 105101780 30";       //29�ŵ�5��   ��Ʒ1:����һ��_�۸�:375�ᱦ����  ��Ʒ2:�ǽ�ʯ����(��)_�۸�:30�ᱦ����																	

$QuanMingDuoBao_ItemList[30, 0] = "105101779 6 105101704 100";        //30�ŵ�1��   ��Ʒ1:�ǽ�ʯ����(С)_�۸�:6�ᱦ����  ��Ʒ2:2.5������(С)_�۸�:100�ᱦ����																	
$QuanMingDuoBao_ItemList[30, 1] = "105180083 250 112010014 100";      //30�ŵ�2��   ��Ʒ1:������ʯ������(4��)_�۸�:250�ᱦ����  ��Ʒ2:28��Ǭ����_�۸�:100�ᱦ����																	
$QuanMingDuoBao_ItemList[30, 2] = "110030144 375 102105532 300";      //30�ŵ�3��   ��Ʒ1:�����˺�����_�۸�:375�ᱦ����  ��Ʒ2:����ʱ��(Ů)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[30, 3] = "116070002 250 102105032 300";      //30�ŵ�4��   ��Ʒ1:��起�_�۸�:250�ᱦ����  ��Ʒ2:����ʱ��(��)_�۸�:300�ᱦ����																	
$QuanMingDuoBao_ItemList[30, 4] = "116060106 35 105090414 25";        //30�ŵ�5��   ��Ʒ1:6���컯��ʯ_�۸�:35�ᱦ����  ��Ʒ2:�弶��ʯ�ϳɾ�_�۸�:25�ᱦ����																	

$QuanMingDuoBao_ItemList[31, 0] = "112010014 100 105101737 10";       //31�ŵ�1��   ��Ʒ1:28��Ǭ����_�۸�:100�ᱦ����  ��Ʒ2:��Ԫ������(С)_�۸�:10�ᱦ����																	
$QuanMingDuoBao_ItemList[31, 1] = "110020005 792 105105032 50";       //31�ŵ�2��   ��Ʒ1:������ʯ_�۸�:792�ᱦ����  ��Ʒ2:5000Ԫ���һ�ȯ_�۸�:50�ᱦ����																	
$QuanMingDuoBao_ItemList[31, 2] = "102105034 300 110030064 375";      //31�ŵ�3��   ��Ʒ1:DJ(��)_�۸�:300�ᱦ����  ��Ʒ2:�������ⱦʯ_�۸�:375�ᱦ����																	
$QuanMingDuoBao_ItemList[31, 3] = "102105534 300 116060108 875";      //31�ŵ�4��   ��Ʒ1:DJ(Ů)_�۸�:300�ᱦ����  ��Ʒ2:8���컯��ʯ_�۸�:875�ᱦ����																	
$QuanMingDuoBao_ItemList[31, 4] = "105101779 6 105105131 400";        //31�ŵ�5��   ��Ʒ1:�ǽ�ʯ����(С)_�۸�:6�ᱦ����  ��Ʒ2:400��Ҷһ�ȯ_�۸�:400�ᱦ����																	

$QuanMingDuoBao_ItemList[32, 0] = "105105128 100 105105128 100";      //32�ŵ�1��   ��Ʒ1:100��Ҷһ�ȯ_�۸�:100�ᱦ����  ��Ʒ2:100��Ҷһ�ȯ_�۸�:100�ᱦ����																	
$QuanMingDuoBao_ItemList[32, 1] = "105105128 100 105105128 100";      //32�ŵ�2��   ��Ʒ1:100��Ҷһ�ȯ_�۸�:100�ᱦ����  ��Ʒ2:100��Ҷһ�ȯ_�۸�:100�ᱦ����																	
$QuanMingDuoBao_ItemList[32, 2] = "105105128 100 105105128 100";      //32�ŵ�3��   ��Ʒ1:100��Ҷһ�ȯ_�۸�:100�ᱦ����  ��Ʒ2:100��Ҷһ�ȯ_�۸�:100�ᱦ����																	
$QuanMingDuoBao_ItemList[32, 3] = "105105128 100 105105128 100";      //32�ŵ�4��   ��Ʒ1:100��Ҷһ�ȯ_�۸�:100�ᱦ����  ��Ʒ2:100��Ҷһ�ȯ_�۸�:100�ᱦ����																	
$QuanMingDuoBao_ItemList[32, 4] = "105105128 100 105105128 100";      //32�ŵ�5��   ��Ʒ1:100��Ҷһ�ȯ_�۸�:100�ᱦ����  ��Ʒ2:100��Ҷһ�ȯ_�۸�:100�ᱦ����																	


for (%i = 1; %i <=31; %i++)
{
	for (%j = 0; %j <= 4; %j++)
	{
		if ($QuanMingDuoBao_ItemList[%i, %j] $= "")
			$QuanMingDuoBao_ItemList[%i, %j] = $QuanMingDuoBao_ItemList[32, %j];
	}
}
function GetPreciousIcon(%nPage, %index)
{
	%Time = GetLocalTime();
	%Day = Getword(%Time, 2);
	return getword($QuanMingDuoBao_ItemList[%Day, %nPage], %index);
}
function GetPreciousbActive()
{
	return $SL_QuanMinDuoBao_State_bActive;
}
//������������������������ȫ��ᱦ��ء���������������������������������



//�����������ڿ󡿡����������ӿ���㺯������������������
function GetOne_HeZuiChu_ZaKuang(%Player, %Optype)
{
	%Level = %Player.GetLevel();
	%Level = %Level - %Level%10;
	//echo( "�ӿ���㺯��%Level===" @ %Level );
	switch (%Optype)
	{
		case 1:
			switch (%Level)
			{
				case 40:  %ItemID =106020001;//ͭ��	
				case 50:  %ItemID =106020002;//����	
				case 60:  %ItemID =106020003;//����	
				case 70:  %ItemID =106020004;//���	
				case 80:  %ItemID =106020005;//������	
				case 90:  %ItemID =106020006;//������	
				case 100: %ItemID =106020007;//ħ���	
				case 110: %ItemID =106020008;//�����	
				case 120: %ItemID =106020009;//�Ͻ��	
				case 130: %ItemID =106020010;//ҫ���	
				default:  %ItemID =106020001;//ҫ���	
			}
		case 2:
			switch (%Level)
			{
				case 40:  %ItemID =106020501;//��ʯ	
				case 50:  %ItemID =106020502;//Ǧʯ	
				case 60:  %ItemID =106020503;//пʯ	
				case 70:  %ItemID =106020504;//��ʯ	
				case 80:  %ItemID =106020505;//����ʯ	
				case 90:  %ItemID =106020506;//����ʯ	
				case 100: %ItemID =106020507;//ϼ��ʯ	
				case 110: %ItemID =106020508;//���ʯ	
				case 120: %ItemID =106020509;//���ʯ	
				case 130: %ItemID =106020510;//���ʯ	
				default:  %ItemID =106020001;//���ʯ	
			}
	}
	return %ItemID;
}

function GetOne_HeZuiChu_KuangDing(%Player, %Optype)
{
	%Level = %Player.GetLevel();
	%Level = %Level - %Level%10;
	//echo( "�ӿ���㺯��%Level===" @ %Level );
	switch (%Optype)
	{
		case 1:
			switch (%Level)
			{
				case 40:  %ItemID =106020101;//ͭ��
				case 50:  %ItemID =106020102;//����
				case 60:  %ItemID =106020103;//����
				case 70:  %ItemID =106020104;//���
				case 80:  %ItemID =106020105;//������
				case 90:  %ItemID =106020106;//������
				case 100:  %ItemID =106020107;//ħ���
				case 110: %ItemID =106020108;//�����
				case 120: %ItemID =106020109;//�Ͻ��
				case 130: %ItemID =106020110;//ҫ���
				default:  %ItemID =106020101;//ͭ��
			}
		case 2:
			switch (%Level)
			{
				case 40:  %ItemID =106020201;//������ͭ��
				case 50:  %ItemID =106020202;//����������
				case 60:  %ItemID =106020203;//����������
				case 70:  %ItemID =106020204;//���������
				case 80:  %ItemID =106020205;//������������
				case 90:  %ItemID =106020206;//������������
				case 100:  %ItemID =106020207;//������ħ���
				case 110: %ItemID =106020208;//�����������
				case 120: %ItemID =106020209;//�������Ͻ��
				case 130: %ItemID =106020210;//������ҫ���
				default:  %ItemID =106020201;//������ͭ��	
			}
	}
	return %ItemID;
}

//�����������ڿ󡿡����������ӿ���㺯������������������



//�����������ᱦ�������������������ĵ��ߡ���������������
function GetIndianaItem()
{
	return 105106004;
}
//�����������ᱦ�������������������ĵ��ߡ���������������


//�����������������������������úͻ�ȡ������������������
//AddPrestige(%Player, $PrestigeStageActID[1, 1], 123);
$PrestigeStageActID[1, 1] = 4105; $PrestigeStageActName[4105] = "ս������";
$PrestigeStageActID[1, 2] = 4106; $PrestigeStageActName[4106] = "��������";
$PrestigeStageActID[1, 3] = 4107; $PrestigeStageActName[4107] = "��������";
$PrestigeStageActID[1, 4] = 4108; $PrestigeStageActName[4108] = "��������";
$PrestigeStageActID[1, 5] = 4109; $PrestigeStageActName[4109] = "��������";

$PrestigeStageActID[2, 1] = 4110; $PrestigeStageActName[4110] = "����������";
$PrestigeStageActID[2, 2] = 4111; $PrestigeStageActName[4111] = "�׻�կ����";
$PrestigeStageActID[2, 3] = 4112; $PrestigeStageActName[4112] = "���ƶ�����";
$PrestigeStageActID[2, 4] = 4113; $PrestigeStageActName[4113] = "�����������";
$PrestigeStageActID[2, 5] = 4114; $PrestigeStageActName[4114] = "�㺣��������";
$PrestigeStageActID[2, 6] = 4115; $PrestigeStageActName[4115] = "���ط�������";

$PrestigeStageActID[3, 1] = 4116; $PrestigeStageActName[4116] = "�Ĳ�ֵ";
$PrestigeStageActID[3, 2] = 4117; $PrestigeStageActName[4117] = "����ֵ";
$PrestigeStageActID[3, 3] = 4118; $PrestigeStageActName[4118] = "ʦͽֵ";
$PrestigeStageActID[3, 4] = 4119; $PrestigeStageActName[4119] = "�ʻ�ֵ";
$PrestigeStageActID[3, 5] = 4120; $PrestigeStageActName[4120] = "��Ҷֵ";
$PrestigeStageActID[3, 6] = 4121; $PrestigeStageActName[4121] = "����ֵ";
$PrestigeStageActID[3, 7] = 4122; $PrestigeStageActName[4122] = "��ս����";


$PrestigeStage[1, 1] ="µµ���� 10000 ��Ȼ���� 50000 �����䷶ 300000 ��ӱ���� 580000 �Ϳ๦�� 1500000 �������� 2000000 ��â��¶ 3000000 Ⱥ����� 6000000 ��įӢ�� 7500000 ����ʥ�� 15000000";//ս��
$PrestigeStage[1, 2] ="µµ���� 10000 ��Ȼ���� 50000 �����䷶ 300000 ��ӱ���� 580000 �Ϳ๦�� 1500000 �������� 2000000 ��â��¶ 3000000 Ⱥ����� 6000000 ��įӢ�� 7500000 ����ʥ�� 15000000";//����
$PrestigeStage[1, 3] ="µµ���� 10000 ��Ȼ���� 50000 �����䷶ 300000 ��ӱ���� 580000 �Ϳ๦�� 1500000 �������� 2000000 ��â��¶ 3000000 Ⱥ����� 6000000 ��įӢ�� 7500000 ����ʥ�� 15000000";//����
$PrestigeStage[1, 4] ="µµ���� 10000 ��Ȼ���� 50000 �����䷶ 300000 ��ӱ���� 580000 �Ϳ๦�� 1500000 �������� 2000000 ��â��¶ 3000000 Ⱥ����� 6000000 ��įӢ�� 7500000 ����ʥ�� 15000000";//����
$PrestigeStage[1, 5] ="µµ���� 10000 ��Ȼ���� 50000 �����䷶ 300000 ��ӱ���� 580000 �Ϳ๦�� 1500000 �������� 2000000 ��â��¶ 3000000 Ⱥ����� 6000000 ��įӢ�� 7500000 ����ʥ�� 15000000";//����

$PrestigeStage[2, 1] ="µµ���� 10000 ��Ȼ���� 50000 �����䷶ 300000 ��ӱ���� 580000 �Ϳ๦�� 1500000 �������� 2000000 ��â��¶ 3000000 Ⱥ����� 6000000 ��įӢ�� 7500000 ����ʥ�� 15000000";//������
$PrestigeStage[2, 2] ="µµ���� 10000 ��Ȼ���� 50000 �����䷶ 300000 ��ӱ���� 580000 �Ϳ๦�� 1500000 �������� 2000000 ��â��¶ 3000000 Ⱥ����� 6000000 ��įӢ�� 7500000 ����ʥ�� 15000000";//�׻�կ
$PrestigeStage[2, 3] ="µµ���� 10000 ��Ȼ���� 50000 �����䷶ 300000 ��ӱ���� 580000 �Ϳ๦�� 1500000 �������� 2000000 ��â��¶ 3000000 Ⱥ����� 6000000 ��įӢ�� 7500000 ����ʥ�� 15000000";//���ƶ�
$PrestigeStage[2, 4] ="µµ���� 10000 ��Ȼ���� 50000 �����䷶ 300000 ��ӱ���� 580000 �Ϳ๦�� 1500000 �������� 2000000 ��â��¶ 3000000 Ⱥ����� 6000000 ��įӢ�� 7500000 ����ʥ�� 15000000";//�������
$PrestigeStage[2, 5] ="µµ���� 10000 ��Ȼ���� 50000 �����䷶ 300000 ��ӱ���� 580000 �Ϳ๦�� 1500000 �������� 2000000 ��â��¶ 3000000 Ⱥ����� 6000000 ��įӢ�� 7500000 ����ʥ�� 15000000";//�㺣����
$PrestigeStage[2, 6] ="µµ���� 10000 ��Ȼ���� 50000 �����䷶ 300000 ��ӱ���� 580000 �Ϳ๦�� 1500000 �������� 2000000 ��â��¶ 3000000 Ⱥ����� 6000000 ��įӢ�� 7500000 ����ʥ�� 15000000";//���ط���

$PrestigeStage[3, 1] ="Ŀ��ʶ�� 10000 ���޵�ī 50000 ����ѧǳ 300000 ��ʶ���� 580000 ��ѧ֮ʿ 1500000 �ž����� 2000000 �����Ž� 3000000 �������� 6000000 �������� 7500000 ����˶ѧ 15000000";//�Ĳ�
$PrestigeStage[3, 2] ="ɽҰ���� 10000 ȭȭ���� 50000 ������� 300000 ���ܸ��� 580000 һ�絤�� 1500000 �������� 2000000 ʸ�Ҳ��� 3000000 ��Ѫ���� 6000000 �屡���� 7500000 ��ʿ��˫ 15000000";//����
$PrestigeStage[3, 3] ="һ��֮ʦ 10000 Ϊ��ʦ�� 50000 �н����� 300000 ���޳�ʦ 580000 �������� 1500000 �¸����� 2000000 ����ҷ� 3000000 ���绯�� 6000000 ���������� 7500000 ��ʥ��ʦ 15000000";//ʦͽ
$PrestigeStage[3, 4] ="ü��Ŀ�� 10000 С�ұ��� 50000 ͤͤ���� 300000 ���Ķ��� 580000 ������ò 1500000 ǧ������ 2000000 ������Ӱ 3000000 ��Ǽ��� 6000000 ��ɫ���� 7500000 ������ 15000000";//�ʻ�
$PrestigeStage[3, 5] ="ò�ƶ�ׯ 10000 ��̬�� 50000 ��Ⱥ֮�� 300000 �����ٷ� 580000 ���¿��� 1500000 �������� 2000000 �������� 3000000 �������� 6000000 �������� 7500000 ҫ������ 15000000";//��Ҷ
$PrestigeStage[3, 6] ="�ε����� 10000 ȭȭ���� 50000 ������� 300000 ���ܸ��� 580000 һ�絤�� 1500000 �������� 2000000 ʸ�Ҳ��� 3000000 ��Ѫ���� 6000000 �屡���� 7500000 ��ʿ��˫ 15000000";//����
$PrestigeStage[3, 7] ="�������� 10000 �ڷ絲�� 50000 �������� 300000 ���龲�� 580000 ��Ӱ���� 1500000 ��ħ���� 2000000 ����֮�� 3000000 ���廤�� 6000000 ��֮���� 7500000 ���������� 15000000";//��ս����


function GetPrestige(%Player, %Maintype, %Subtype)//��ȡ��ǰ����
{
	%Act = $PrestigeStageActID[%Maintype, %Subtype];
	%Act0 = GetAct(%Player, %Act, 0) * 10000;
	%Act1 = GetAct(%Player, %Act, 1) * 1;

	//echo("%aAct  ===  " @ %Act);
	//echo("%aAct0 ===  " @ %Act0);
	//echo("%aAct1 ===  " @ %Act1);
	return %Act0 + %Act1;
}

function GetPrestigeStageNumber(%Player, %Maintype, %Subtype)//��ǰ�׶�������ֵ
{
	%NowVal = GetPrestige(%Player, %Maintype, %Subtype);
	%Count = GetWordCount($PrestigeStage[%Maintype, %Subtype]);
	%Number = 0;
	for (%i = 0; %i < %Count; %i = %i + 2)
	{
		//%PrestigeName = GetWord($PrestigeStage[%Maintype, %Subtype], %i);
		%PrestigeNumber = GetWord($PrestigeStage[%Maintype, %Subtype], %i+1);
		if (%NowVal < %PrestigeNumber)
		{
			%Number = %PrestigeNumber;
			break;
		}
	}
	if (%Number == 0)
		%Number = GetWord($PrestigeStage[%Maintype, %Subtype], %Count - 1);
	return %Number;
}

function GetPrestigeStageName(%Player, %Maintype, %Subtype)//��ǰ�׶���������
{
	%NowVal = GetPrestige(%Player, %Maintype, %Subtype);
	//echo("%NowVal===" @ %NowVal);
	%Count = GetWordCount($PrestigeStage[%Maintype, %Subtype]);
	%Name = "";
	for (%i = 0; %i < %Count; %i = %i + 2)
	{
		%PrestigeName = GetWord($PrestigeStage[%Maintype, %Subtype], %i);
		%PrestigeNumber = GetWord($PrestigeStage[%Maintype, %Subtype], %i+1);
		if (%NowVal < %PrestigeNumber)
		{
			%Name = %PrestigeName;
			break;
		}
	}
	if (%Name $= "")
		%Name = GetWord($PrestigeStage[%Maintype, %Subtype], %Count - 2);
	return %Name;
}

function AddPrestige(%Player, %ActivityID, %Val)//��������ֵ
{
	%Act0 = GetAct(%Player, %ActivityID, 0) * 1;
	%Act1 = GetAct(%Player, %ActivityID, 1) * 1;

	%Act1 = %Act1 + %Val;
	if (%Act1 >= 10000)
	{
		%Act0 = %Act0 + mfloor(%Act1/10000);
		%Act1 = %Act1%10000;
	}
	SetAct(%Player, %ActivityID, %Act0, %Act1);
	%PlayerID = %Player.GetPlayerID();
	switch (%ActivityID)
	{
		case 4119:
			%Sex = %Player.GetSex();
			switch (%Sex)
			{
				case 1://��
					SptRankUpLoadValue($eTopType_MaleFlower, %PlayerID, %Val, 0);//�ϴ����а�
				case 2://Ů
					SptRankUpLoadValue($eTopType_Flower, %PlayerID, %Val, 0);//�ϴ����а�
			}
		case 4120:
			SptRankUpLoadValue($eTopType_DonateFlower, %PlayerID, %Val, 0);//��Ҷֵ�ϴ����а�
		case 4116: 
			SptRankUpLoadValue($eTopType_LiteraryGrace, %PlayerID, %Val, 0);//�Ĳ�ֵ�ϴ����а�
		case 4105:SptRankUpLoadValue($eTopType_WarriorPrestige, %PlayerID, %Val, 0);//ս�������ϴ����а�
		case 4106:SptRankUpLoadValue($eTopType_MagePrestige, %PlayerID, %Val, 0);//���������ϴ����а�
		case 4107:SptRankUpLoadValue($eTopType_TaoistPrestige, %PlayerID, %Val, 0);//���������ϴ����а�
		case 4108:SptRankUpLoadValue($eTopType_AssassinPrestige, %PlayerID, %Val, 0);//���������ϴ����а�
		case 4109:SptRankUpLoadValue($eTopType_ArrowPrestige, %PlayerID, %Val, 0);//���������ϴ����а�
		case 4110:SptRankUpLoadValue($eTopType_MapPrestige_1101, %PlayerID, %Val, 0);//�����������ϴ����а�
		case 4111:SptRankUpLoadValue($eTopType_MapPrestige_1102, %PlayerID, %Val, 0);//�׻�կ�����ϴ����а�
		case 4112:SptRankUpLoadValue($eTopType_MapPrestige_1103, %PlayerID, %Val, 0);//���ƶ������ϴ����а�
		case 4113:SptRankUpLoadValue($eTopType_MapPrestige_1104, %PlayerID, %Val, 0);//������������ϴ����а�
		case 4114:SptRankUpLoadValue($eTopType_MapPrestige_1105, %PlayerID, %Val, 0);//�㺣���������ϴ����а�
		case 4115:SptRankUpLoadValue($eTopType_MapPrestige_1106, %PlayerID, %Val, 0);//���ط��������ϴ����а�
	}

	%Text = "<t>����</t>" @ $PrestigeStageActName[%ActivityID] @ "<t>�����ˣ�</t>" @ %Val @ "<t>�㣬��ǰӵ�У�</t>" @ %Act0 * 10000 + %Act1 @ "<t>�㡣</t>";
	SendOneChatMessage($chatMsg_Person, %Text, %Player);
	
	//putout("��ǰ����ֵ===" @ %Player.GetActivity(%ActivityID));
}

//�����������������������������úͻ�ȡ������������������

//������������Ե��ǩ���������������ػ���ء�����������
function GetLiShangWangLaibActive()
{
	return $SL_LiShangWangLai_State_bActive;
}
//������������Ե��ǩ���������������ػ���ء�����������

//������������Ը���񡿡������������ػ���ء�����������
function GetQiYuanHaoLibActive()
{
	return $SL_QiYuanHaoLi_State_bActive;
}
//������������Ը���񡿡������������ػ���ء�����������


//����������ȫ��ᱦ�������������н���������������������
//ShowWorldChatMsg(50000002   , trg   ,116080010);
function ShowWorldChatMsg(%PlayerID, %PlayerName, %ItemID)
{
	if (GetZoneid() != 1001)
		return;
	//echo("������ȫ��ᱦ�������������н�������������������==" @ %PlayerID @ "    "@ %PlayerName @ "   " @ %ItemID);
	%Player = SptGetPlayer(%PlayerID);

	%PlayerName1 = "<l i='"@ %PlayerName @ " "@ %PlayerID @ "' t='name' />";
	%PlayerName2 = $Get_Dialog_GeShi[60006] @ "��" @ %PlayerName @ "��</t>";
	%ItemName1 = GetItemName(%ItemID, 1);
	%ItemName2 = GetItemName(%ItemID, 2);
	%HuoDongMingCheng1 = GetHuoDongName("ȫ��ᱦ", 1);
	%HuoDongMingCheng2 = GetHuoDongName("ȫ��ᱦ", 2);

	%Text1 = "<t>�����콵��</t>" @ %PlayerName1 @ "<t>����</t>" @ %HuoDongMingCheng1 @ "<t>��������</t>" @ %ItemName1 @ "<t>������������ɷ����ʿ��</t>";
	%Text2 = "<t>�����콵��</t>" @ %PlayerName2 @ "<t>����</t>" @ %HuoDongMingCheng2 @ "<t>��������</t>" @ %ItemName2 @ "<t>������������ɷ����ʿ��</t>";
	SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
	SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
}
//����������ȫ��ᱦ�������������н���������������������



//��������������������������Ȩ��������񡿡���������������������������������
//���ĳ����Ȩ�ĵȼ�
function VIP_getTequanLv(%Player, %type)
{
	if (%Player.GetVipTimer(%type)*1 < 1)
		return 0;
	%activeID = 4123 + %type;
	return GetWord(%Player.GetActivity(%activeID), 0)*1;
}

//���ĳ����Ȩ��ʣ��ʱ��
function VIP_getTequanTime(%Player, %type)
{
	return %Player.GetVipTimer(%type);
}

//���ĳ����Ȩ����Ŀ����
function VIP_getTequanListCnt(%Player, %type)
{
	if (%type*1 == 0) return 8;
	else if (%type*1 == 1) return 14;
	else return 0;
}

//��ˬ��Ȩ�����ĳ����Ȩ�������ֵ
function VIP_getNowTequanLvMaxCnt(%Player, %Index)
{
	if (%Player.isVip(0) <= 0)
		return getEnjoyPrerogativeText(0, %Index);

	%Lv = VIP_getTequanLv(%Player, 0);
	if (%Lv < 1)
		return 0;

	switch (%Index)
	{
		case 1: return getEnjoyPrerogativeText(%Lv+1, %Index);	//�ǽ紫�͵����ɼ�¼
		case 2: return getEnjoyPrerogativeText(%Lv+1, %Index);	//�ǽ紫�ͣ����ŵ�ͼ�ɼ�¼��������
		case 3: return getEnjoyPrerogativeText(%Lv+1, %Index);	//����̵�ˢ�´���
		case 4: return getEnjoyPrerogativeText(%Lv+1, %Index);	//�۱���ɲ������
		case 6: return getEnjoyPrerogativeText(%Lv+1, %Index);	//�������ˢ�´���
		case 7: return getEnjoyPrerogativeText(%Lv+1, %Index);	//ÿ��Ѻ�ڴ���
		case 8: return getEnjoyPrerogativeText(%Lv+1, %Index);	//
	}

	return 0;
}

//���ĳ����Ȩ�Ĺ���/����/���ѵķ���
//%type��Ȩ����
//%operate��1����2������3����
//%Days:����
//%Lv:�ȼ���1������2�ƽ�3�׽�
function VIP_getTequanCost(%Player, %type, %Lv, %Days, %operate)
{
	//7�죺��Ȩ���ͣ��ȼ�������
	%cost7days[0, 1] = 700; %cost7days[0, 2] = 1400; %cost7days[0, 3] = 2800;
	%cost7days[1, 1] = 1400; %cost7days[1, 2] = 2800; %cost7days[1, 3] = 5600;

	//30�죺��Ȩ���ͣ��ȼ�������
	%cost30days[0, 1] = 2700; %cost30days[0, 2] = 5400; %cost30days[0, 3] = 10800;
	%cost30days[1, 1] = 5400; %cost30days[1, 2] = 10800; %cost30days[1, 3] = 21600;

	switch (%operate)
	{
		case 1:
			if (%Days == 7) return %cost7days[%type, %Lv];
			else return %cost30days[%type, %Lv];

		case 2:
			%activeID = 4123 + %type;
			%aveCost1 = Mceil(%cost7days[%type, GetWord(%Player.GetActivity(%activeID), 0)*1] / 7);	//����ǰ��ÿ�յ���
			%aveCost2 = Mceil(%cost7days[%type, %Lv] / 7);	//��Ҫ������ÿ�յ���
			%leftDays = Mceil(%Player.GetVipTimer(%type) / 86400);
			return %leftDays * (%aveCost2 - %aveCost1);

		case 3:
			if (%Days == 7) return %cost7days[%type, %Lv];
			else return %cost30days[%type, %Lv];

		default: echo("VIP_getTequanCost����"); return 999999;
	}

}

//������Ȩ����Ŀ��ʾ
function getEnjoyPrerogativeText(%type, %index)
{
	%textList[1] = "6 ;�ǽ紫�͵����ɼ�¼��      ;10;15;20";
	%textList[2] = "2 ;�ǽ紫�͵��ŵ�ͼ�ɼ�¼���꣺;3 ;4 ;5 ";
	%textList[3] = "1 ;����̵�ÿ�����ˢ�´�����  ;3 ;4 ;5 ";
	%textList[4] = "3 ;�۱���ɲ��������          ;5 ;7 ;10";
	%textList[5] = "0 ;����������������ʣ�        ;2%;4%;6%";
	%textList[6] = "3 ;�������ˢ�´�����          ;5 ;7 ;10";
	%textList[7] = "5 ;ÿ��Ѻ�ڴ�����              ;6 ;7 ;8 ";
	%textList[8] = "10;ÿ�ղر�ͼ���������        ;15;20;30";


	%button4 = "<c cid='" @ Get_TraceButton() @ "'cmd='\"OpenOrCloseCornucopiaWnd();\",\"" @ $Get_Dialog_GeShi[31414] @ "�۱���" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />";

	%shuoming[1] = $Get_Dialog_GeShi[31399]@"�ǽ紫��:</t><b/><b/>"@
		$Get_Dialog_GeShi[31401]@"<t>������Ȩ������ǽ紫�ͼ�¼�����������Ȩ�ȼ�Խ�ߣ��ɼ�¼������Խ�࣡</t><b/><b/>"@
		$Get_Dialog_GeShi[31406]@"û����Ȩֻ�ܼ�¼ "@GetWord(GetWord(%textList[1], 0, ";"), 0, " ")@" ���㣡</t><b/><b/>"@
		"<t>�� </t>"@$Get_Dialog_GeShi[31403]@"M</t><t> ���������ͼ��������½ǵ� </t>"@$Get_Dialog_GeShi[31403]@"��¼��ǰ����</t><t> ��ť����������¼��ǰ���꣬����˴��͵���������͵��˴���</t><b/>";

	%shuoming[2] = $Get_Dialog_GeShi[31399]@"�ǽ紫��:</t><b/><b/>"@
		$Get_Dialog_GeShi[31401]@"<t>������Ȩ����� </t>"@$Get_Dialog_GeShi[31403]@"���ŵ�ͼ</t><t> �ǽ紫�ͼ�¼�����������Ȩ�ȼ�Խ�ߣ��ɼ�¼������Խ�࣡</t><b/><b/>"@
		$Get_Dialog_GeShi[31406]@"û����Ȩֻ�ܼ�¼ "@GetWord(GetWord(%textList[2], 0, ";"), 0, " ")@" ���㣡</t><b/><b/>"@
		"<t>�� </t>"@$Get_Dialog_GeShi[31403]@"M</t><t> ���������ͼ��������½ǵ� </t>"@$Get_Dialog_GeShi[31403]@"��¼��ǰ����</t><t> ��ť����������¼��ǰ���꣬����˴��͵���������͵��˴���</t><b/>";

	%shuoming[3] = $Get_Dialog_GeShi[31399]@"����̵�:</t><b/><b/>"@
		$Get_Dialog_GeShi[31401]@"<t>������Ȩ����� </t>"@$Get_Dialog_GeShi[31403]@"����̵�</t><t> ÿ�����ˢ�µĴ�������Ȩ�ȼ�Խ�ߣ�ÿ�����ˢ�µĴ���Խ�࣡</t><b/><b/>"@
		$Get_Dialog_GeShi[31406]@"û����Ȩֻ�����ˢ�� "@GetWord(GetWord(%textList[3], 0, ";"), 0, " ")@" �Σ�</t><b/><b/>"@
		"<t>�� </t>"@$Get_Dialog_GeShi[31403]@"V</t><t> �����̳ǽ��棬ѡ�� </t>"@$Get_Dialog_GeShi[31403]@"����̵�</t><t> ��ҳ����� </t>"@$Get_Dialog_GeShi[31403]@"ˢ����Ʒ</t><t> ��ť����ˢ���̵��ڵ���Ʒ��</t><b/>";

	%shuoming[4] = $Get_Dialog_GeShi[31399]@"�۱���:</t><b/><b/>"@
		$Get_Dialog_GeShi[31401]@"<t>������Ȩ����� </t>"@$Get_Dialog_GeShi[31403]@"�۱���</t><t> ��ÿ��ʹ�ô�������Ȩ�ȼ�Խ�ߣ�ÿ��ʹ�ô���Խ�࣡</t><b/><b/>"@
		$Get_Dialog_GeShi[31406]@"û����Ȩֻ��ʹ�� "@GetWord(GetWord(%textList[4], 0, ";"), 0, " ")@" �Σ�</t><b/><b/>"@
		"<t>��ɫ�ȼ��ﵽ40������  </t>"@$Get_Dialog_GeShi[31403]@"С��ͼ�·�</t><t> �����</t>"@%button4@"<t>�İ�ť������˰�ť�ɴ򿪾۱�����棬ÿ��ˣһ�¾Ϳ������ɻ�ô�����ң�</t><b/>";

	%shuoming[5] = $Get_Dialog_GeShi[31399]@"��������:</t><b/><b/>"@
		$Get_Dialog_GeShi[31401]@"<t>������Ȩ�ɽ��� </t>"@$Get_Dialog_GeShi[31403]@"����������</t><t>�ĸ��ʣ���Ȩ�ȼ�Խ�ߣ�����ʱ������ĸ���Խ�ͣ�</t><b/><b/>"@
		$Get_Dialog_GeShi[31406]@"û����Ȩ��������ױ�������</t><b/><b/>";

	%shuoming[6] = $Get_Dialog_GeShi[31399]@"���ͼ���:</t><b/><b/>"@
		$Get_Dialog_GeShi[31401]@"<t>������Ȩ������ </t>"@$Get_Dialog_GeShi[31403]@"���ͼ��� </t><t>���ˢ������Ĵ�������Ȩ�ȼ�Խ�ߣ����ˢ������Ĵ���Խ�࣡</t><b/><b/>"@
		$Get_Dialog_GeShi[31406]@"û����Ȩֻ�����ˢ�� "@GetWord(GetWord(%textList[6], 0, ";"), 0, " ")@" �Σ�</t><b/><b/>"@
		"<t>�� </t>"@$Get_Dialog_GeShi[31403]@"Y</t><t> ���򿪻�б���棬ѡ�� </t>"@$Get_Dialog_GeShi[31403]@"���û</t><t> ��ҳ���ڴ˷�ҳ�¿��ҵ� </t>"@$Get_Dialog_GeShi[31403]@"���ͼ���</t><t> �����ϸ��Ϣ��</t><b/>";

	%shuoming[7] = $Get_Dialog_GeShi[31399]@"ÿ��Ѻ��:</t><b/><b/>"@
		$Get_Dialog_GeShi[31401]@"<t>������Ȩ������ </t>"@$Get_Dialog_GeShi[31403]@"ÿ��Ѻ��</t><t> ���ÿ�����Ѻ�ڴ�������Ȩ�ȼ�Խ�ߣ�ÿ��Ѻ�ڵĴ���Խ�࣡</t><b/><b/>"@
		$Get_Dialog_GeShi[31406]@"û����Ȩֻ��Ѻ�� "@GetWord(GetWord(%textList[7], 0, ";"), 0, " ")@" �Σ�</t><b/><b/>"@
		"<t>�� </t>"@$Get_Dialog_GeShi[31403]@"Y</t><t> ���򿪻�б���棬ѡ�� </t>"@$Get_Dialog_GeShi[31403]@"ʱ�λ</t><t> ��ҳ���ڴ˷�ҳ�¿��ҵ� </t>"@$Get_Dialog_GeShi[31403]@"ÿ��Ѻ��</t><t> �����ϸ��Ϣ��</t><b/>";

	%shuoming[8] = $Get_Dialog_GeShi[31399]@"�ر�ͼ:</t><b/><b/>"@
		$Get_Dialog_GeShi[31401]@"<t>������Ȩ������ </t>"@$Get_Dialog_GeShi[31403]@"�ر�ͼ</t><t> ��ÿ��ʹ�������������Ȩ�ȼ�Խ�ߣ�ÿ�տ���ʹ�òر�ͼ�Ĵ���Խ�࣡</t><b/><b/>"@
		$Get_Dialog_GeShi[31406]@"û����Ȩÿ��ֻ��ʹ�� "@GetWord(GetWord(%textList[8], 0, ";"), 0, " ")@" ���ر�ͼ��</t><b/><b/>";


	if (%type < 5)
		return GetWord(GetWord(%textList[%index], %type, ";"), 0, " ");
	else
		return %shuoming[%index];
}

//������Ȩ����Ŀ��ʾ
function getAcerPrerogativeText(%Player, %type, %index)
{
	%textList[1] = "105270002;ÿ��1��;20-200    ;80-300    ;100-500   ";
	%textList[2] = "105028002;ÿ��1��;1         ;2         ;3         ";
	%textList[3] = "113010152;ÿ��1��;2         ;4         ;5         ";
	%textList[4] = "113010151;ÿ��1��;2         ;4         ;5         ";
	%textList[5] = "105109525;ÿ��1��;3         ;4         ;5         ";
	%textList[6] = "105100203;ÿ��1��;3000-10000;5000-15000;8000-25000";
	%textList[7] = "105100201;ÿ��1��;1         ;1         ;1         ";
	%textList[8] = "105100202;ÿ��1��;1         ;1         ;1         ";
	%textList[9] = "105020303;ÿ��1��;50        ;100       ;200       ";
	%textList[10] = "105020353;ÿ��1��;50        ;100       ;200       ";
	%textList[11] = "105021201;ÿ��1��;0         ;1         ;1         ";
	%textList[12] = "105021211;ÿ��1��;0         ;1         ;1         ";
	%textList[13] = "105090902;ÿ��1��;0         ;1         ;2         ";
	%textList[14] = "102103029;ÿ��1��;0         ;0         ;1         ";

	if (%type < 3)
		return GetWord(%textList[%index], %type-1, ";");
	else
	{
		%str1 = GetWord(%textList[%index], %type-1, ";");
		%str2 = GetWord(%str1, 0, " ");
		return %str2;
	}
}

//���������Ȩ��ǰ�Ƿ�����������ڣ�����ֵ>0ʱ��������ȡ
//%index��������һ����ȡʱ��-1
function VIP_getZhunxiangReward(%Player, %index)
{
	if (%Player.isVip(1) < 1)
		return 1;

	%Lv = VIP_getTequanLv(%Player, 1);
	%activeAA = GetWord(%Player.GetActivity(4129), 0);
	%activeBB = GetWord(%Player.GetActivity(4128), 0);

	if (getAcerPrerogativeText(%Player, %Lv+2, %index) < 1)
		return 1;	//����Ϊ0����ʾ������ȡ

	if (%index == 14)
		return HasBit(%activeBB, %index-1);
	else if (%index > 0)
		return HasBit(%activeAA, %index-1);
	else
	{
		%idCnt = VIP_getTequanListCnt(%Player, 1);	//��Ŀ����
		for (%i=1; %i<=%idCnt; %i++)
		if (!HasBit(%activeAA, %index-1))
			return 0;
	}

	return 1;
}


//������������������������������ֵ�ͺ��񡿡���������������������������������
//$Recharge7Days_Date[1] = "6/1";	//���ʼʱ��
//$Recharge7Days_Date[2] = "6/7";	//�����ʱ��
//���ص����ǻ�����ĵڼ���(0-6)
function getRecharge7DaysNowWhichDay()
{
	%startDays = GetWord($Recharge7Days_Date[1], 0, "/") * 30 + GetWord($Recharge7Days_Date[1], 1, "/");

	%Time = GetLocalTime();
	%DQ_MM = GetWord(%Time, 1);	//��
	%DQ_DD = GetWord(%Time, 2);	//��
	%nowDays = %DQ_MM * 30 + %DQ_DD;

	return %nowDays - %startDays;
}

//���ص��߽����б�
function getRecharge7DaysRewardInfo(%Player, %index)
{
	%RewardInfo[1] = "116010001;20|116080006;1|112010058;1";
	%RewardInfo[2] = "105090501;5 |105105701;3|113050012;5";
	%RewardInfo[3] = "105090601;5 |105090701;5|116030001;2|113090001;2";
	%RewardInfo[4] = "113090001;2 |105028012;1|113020002;5|105109321;8";
	%RewardInfo[5] = "113090001;2 |105028022;1|113020012;5|105109321;8";
	%RewardInfo[6] = "113090001;2 |105028022;1|105090911;3|105021051;1|116080006;1|105109321;8";
	%RewardInfo[7] = "113090001;2 |105028022;1|105090902;1|105109534;1|116080006;1|105109321;8";
	%RewardInfo[8] = "105180232;1";	//���ܴ����
	%RewardInfo[9] = "105105713;2 |105090511;5 |105090611;5 |113050023;5 |116030002;2 |105090711;5 |105109323;28|105021051;1 |105021061;1 |119015001;1";	//���ܴ����������

	return %RewardInfo[%index];
}

//����ĳ����Ҫ������ȡ����Ԫ��������ȡ����
function getRecharge7DaysNeedYuanbaoNum(%Player, %index)
{
	%NeedYuanbaoNum[1] = 3000;
	%NeedYuanbaoNum[2] = 3000;
	%NeedYuanbaoNum[3] = 5000;
	%NeedYuanbaoNum[4] = 6000;
	%NeedYuanbaoNum[5] = 6800;
	%NeedYuanbaoNum[6] = 8800;
	%NeedYuanbaoNum[7] = 9800;

	return %NeedYuanbaoNum[%index];
}

//����ĳ�콱���Ƿ������ȡ,0������ȡ��1����ȡ��2����ȡ
//%Index((1-8)
function getRecharge7DaysRewardState(%Player, %index)
{
	%ActSt0 = GetAct(%Player, 4131, 0);	//�Ƿ����ȡ
	%ActSt1 = GetAct(%Player, 4131, 1);	//�Ƿ�����ȡ

	if (HasBit(%ActSt1, %index-1))
		return 2;
	else if (HasBit(%ActSt0, %index-1))
		return 1;

	return 0;
}

//��ȡԪ��ʱ���������ý����Ƿ����ȡ
function getRecharge7DaysSetState(%Player, %gold)
{
	%whichDay = getRecharge7DaysNowWhichDay();
	if (%whichDay >= 0 && %whichDay < 7)
	{
		%ActYB  = GetAct(%Player, 4130, 0);	//ÿ����ȡԪ����
		%ActSt0 = GetAct(%Player, 4131, 0);	//�Ƿ����ȡ
		%ActSt1 = GetAct(%Player, 4131, 1);	//�Ƿ�����ȡ

		if (%whichDay >= 4 && !HasBit(%ActSt1, 7))	//������һ���Գ�ֵ�ﵽ680Ԫʱ��ֱ�ӵ����
		{
			if (%gold >= 68000)
			{
				AddItem_BaoGuoNo_Mail(%Player, 105180232, 1, 0, "3 4131");
				%ActSt0 = SetBit(%ActSt0, 7);
				%ActSt1 = SetBit(%ActSt1, 7);
			}
		}

		//����ÿ�ս�������ȡ
		if (!HasBit(%ActSt0, %whichDay))
		{
			%ActYB = GetAct(%Player, 4130, 0) + %gold;
			if (%ActYB > 60000)
				%ActYB = 60000;
			SetAct(%Player, 4130, %ActYB, 0);
			if (%ActYB >= getRecharge7DaysNeedYuanbaoNum(%Player, %whichDay+1))
				%ActSt0 = SetBit(%ActSt0, %whichDay);

			if (%whichDay >= 4)
			{
				%num = 0;
				for (%i=0; %i<=%whichDay; %i++)
				{
					if (HasBit(%ActSt0, %i))
						%num++;
				}
				if (%num >= 5)
					%ActSt0 = SetBit(%ActSt0, 7);	//������5�����ϣ������ȡ����
			}
		}
		SetAct(%Player, 4131, %ActSt0, %ActSt1);
	}
}



//�������������������������ҵ�����������������������������������������������
//����ֵ�����߱��|�۸�
function getMyAppearanceItemInfo(%Player, %Index, %Type)
{
	//ʱװ																	//����                             
	%itemList[111] = "105180215|10800";			%itemList[211] = "105180205|9800 ";
	%itemList[112] = "105180216|11800";	    %itemList[212] = "105180206|10800";
	%itemList[113] = "105180217|9900 ";	    %itemList[213] = "105180207|10800";
	%itemList[114] = "105180218|8800 ";	    %itemList[214] = "105180208|9800 ";
	%itemList[115] = "102105031";				    %itemList[215] = "119013002";
	%itemList[116] = "102104036";				    %itemList[216] = "119013003";
	%itemList[117] = "102105025";			 	    %itemList[217] = "119013030";
	%itemList[118] = "102105021";						%itemList[218] = "119013059";

	%itemList[121] = "102105014|6600";			%itemList[221] = "119013004|4350";
	%itemList[122] = "102105020|6600";      %itemList[222] = "119013013|6600";
	%itemList[123] = "102105022|6600";      %itemList[223] = "119013031|6600";
	%itemList[124] = "102105009|7350";      %itemList[224] = "119013035|6600";
	%itemList[125] = "102105013|7350";      %itemList[225] = "119013066|5100";
	%itemList[126] = "102105028|8100";      %itemList[226] = "119013005|4350";


	%price  = GetWord(%itemList[%Index], 1, "|");
	%itemid = GetWord(%itemList[%Index], 0, "|");
	%itemid = getItemTrueIDOrCnt(%Player, %itemid, 0, 0);

	if (%Type == 1)
		return %price;
	else return %itemid;
}

//����ֵ���Ƿ�ɹ���0�ɹ���1�ѹ���
//����������λ����һλ��ѡ�������/ʱװ�����ڶ�λ�Ǳ�ʾ��������ǵ�����Ʒ������λ��ʾ���������Ʒ���±�
function getMyAppearanceButtenState(%Player, %Index)
{
	%activeID = 4132 + (Mfloor(%Index/100) - 1);
	%activeValue[0] = GetAct(%Player, %activeID, 0);
	%activeValue[1] = GetAct(%Player, %activeID, 1);
	%activeTy = Mfloor(%Index/10) % 10 - 1;

	return %activeValue[%activeTy]*1;
}



//������������������������������𡿡���������������������������������������
//���ؽ�����Ϣ��1����������2�̶�������3�������
function getYouXiangJiJinItemList(%Index)
{
	%ItemList[1] = "105105032;1|105028022;3|112010061;1|105109061;1";
	%ItemList[2] = "105270002;300|105109032;1";
	%ItemList[3] = "105270002;50 - 800|105109032;1 - 3";

	return %ItemList[%Index];
}

//%Type=1�������Ƿ�ɹ���0�ɹ���1�ѹ���|%Type=2�������Ƿ����ȡ��0����ȡ��1����ȡ��
function getYouXiangJiJinButtenState(%Player, %Type)
{
	%activeID = 4134;
	%active0 = GetAct(%Player, %activeID, 0)*1;

	%active2 = GetAct(%Player, 4136, 0)*1;	//�Ƿ��ѹ����

	if (%Type == 1)
	{
		if (%Player.isVip(2) < 1 && %active2 < 1)
			return 0;
		else return 1;
	}
	else if (%Type == 2)
	{
		if (%Player.isVip(2) > 0 && %active0 < 1)
			return 0;
		else return 1;
	}

	return 1;
}

//�������������������������޹��̵꡿����������������������������������������
//��ͻ��˷����µ���Ʒ��Ϣ��ʾ�����£�
//$XianShiQiangGou_ItemInfo[17, 1,  4] = "444444444|762|11|527|2";
//$XianShiQiangGou_ItemInfo[17, 1,  5] = "555555555|762|11|527|2";
//$XianShiQiangGou_ItemInfo[17, 1, 12] = "121212121|762|11|527|2";
//$SL_XianShiQiangGou_NewInfo = "17;1;4 5 12";	��·;�̵�ID;��Ҫ�޸ĵ���Ʒ���±�
function sendNewXianShiQiangGouItemInfo(%Player, %ItemInfo)
{
	if($Now_Script != 2)
		return;
		
	if(%ItemInfo $= "")
		return;
	
	%line = GetWord(%ItemInfo,0,";");
	%shop = GetWord(%ItemInfo,1,";");
	%replace = GetWord(%ItemInfo,2,";");
	%itemNum = $XianShiQiangGou_ItemNum[%line, %shop];
	
	%newItemInfo = %ItemInfo;
	for(%i=0;%i<GetWordCount(%replace);%i++)
	{
		%ID = GetWord(%replace,%i)*1;
		%newItemInfo = %newItemInfo @";"@ $XianShiQiangGou_ItemInfo[%line, %shop, %ID];
		if(%itemNum < %ID)
			%itemNum = %ID;
	}
	$XianShiQiangGou_ItemNum[%line, %shop] = %itemNum;	//���µ�������

	if(strlen(%newItemInfo) <= 255)
		%Player.SendPlayerString(13,%newItemInfo,0);	//��ʱ�������߸���
}

//�ͻ��˽������յ����µ���Ʒ��Ϣ
function analysisXianShiQiangGouReceiveInfo(%ReceiveInfo)
{
	if($Now_Script != 1)
		return;

	%line = GetWord(%ReceiveInfo,0,";");
	%shop = GetWord(%ReceiveInfo,1,";");
	%replace = GetWord(%ReceiveInfo,2,";");
	%itemNum = $XianShiQiangGou_ItemNum[%line, %shop];
	
	for(%i=0;%i<GetWordCount(%replace);%i++)
	{
		%ID = GetWord(%replace,%i)*1;
		$XianShiQiangGou_ItemInfo[%line, %shop, %ID] = GetWord(%ReceiveInfo,%i+3,";");	//���µ�����Ϣ
		if(%itemNum < %ID)
			%itemNum = %ID;
	}
	$XianShiQiangGou_ItemNum[%line, %shop] = %itemNum;	//���µ�������
}

//����ʱ������ʱ�̵���
function XianShiQiangGou_SetKuCunNum()
{
	if($XianShiQiangGou_SetKuCunNum !$= "")
		return;
	$XianShiQiangGou_SetKuCunNum = 1;
	
	if($Now_Script != 2)
		return;
	
	%LineID = GetCurrentLineId();//�߳�ID
	for(%i=1;%i<=6;%i++)
	{
		%ItemNum = $XianShiQiangGou_ItemNum[%LineID,%i];
		if(%ItemNum > 0)
		{
			for(%j=1;%j<=%ItemNum;%j++)
			{
				$XianShiQiangGou_ItemKuCun[%LineID,%i, %j] = GetWord($XianShiQiangGou_ItemInfo[%LineID,%i, %j],1,"|");	//Ԥ���趨�õĿ��
			}
		}
	}
}

//��ͻ��˷�����ʱ��������Ʒ���
function XianShiQiangGou_SendClientKuCunNum(%Player)
{
	if($Now_Script != 2)
		return;
	
	%LineID = GetCurrentLineId();//�߳�ID
	%KuCunInfo = "";
	for(%i=1;%i<=6;%i++)
	{
		%ItemNum = $XianShiQiangGou_ItemNum[%LineID,%i];
		if(%ItemNum > 0)
		{
			for(%j=1;%j<=%ItemNum;%j++)
			{
				if(%j == %ItemNum)
					%KuCunInfo[%i] = %KuCunInfo[%i] @ $XianShiQiangGou_ItemKuCun[%LineID,%i, %j];
				else
					%KuCunInfo[%i] = %KuCunInfo[%i] @ $XianShiQiangGou_ItemKuCun[%LineID,%i, %j] @ " ";
			}
			if(%i == 1)
				%KuCunInfo = %KuCunInfo[%i];
			else
				%KuCunInfo = %KuCunInfo @ "|" @ %KuCunInfo[%i];
		}
	}
	
	if(%KuCunInfo !$= "")
		%Player.SendPlayerString(14,%KuCunInfo,0);
}


//�ͻ��˽������յ�����ʱ��������Ʒ���
function XianShiQiangGou_ReceiveClientKuCunNum(%text)
{
	if($Now_Script != 1)
		return;
	
	%CurrentLineId = getact(getplayer(),4019,1);
	%shopCnt = GetWordCount(%text,"|");
	for(%i=0;%i<%shopCnt;%i++)
	{
		%KuCunList[%i] = GetWord(%text,%i,"|");
		for(%j=0;%j<GetWordCount(%KuCunList[%i]);%j++)
		{
			$XianShiQiangGou_ItemKuCun[%CurrentLineId,%i+1, %j+1] = GetWord(%KuCunList[%i],%j);
		}
	}
}


//��ʱ�������������activityֵ
function XianShiQiangGou_UpdateActivity(%Player)
{
	if($Now_Script != 2)
		return;
	
	%LineID = GetCurrentLineId();	//�߳�ID
	%itemTotal = $XianShiQiangGou_ItemNum[%LineID,1];
	
	%newDate = GetWord($SL_XianShiQiangGou_EndTime[1],0);
	%newDays = (GetWord(%newDate,0,".")-2018)*365 + GetWord(%newDate,1,".")*30 + GetWord(%newDate,2,".");

	for(%i=1;%i<=%itemTotal;%i++)
	{
		%activeID = 4200 + %i; 	//��ȡ��֤��ֵ
		%oldDays = GetAct(%Player,%activeID,0);	//��һ�ι���ʱ�Ļ��ʼʱ��
		%buyCnts = GetAct(%Player,%activeID,1);	//�Ѿ����������
		
		if(%oldDays < %newDate)
			SetAct(%Player,%activeID,0,0);	//�����ϴλʱ����ѹ������
	}
}


