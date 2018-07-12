//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//������ҷֽ����ʱ������˽ű�����
//==================================================================================


//==================================================================================
//����˽ű�����(�ֽ�)
//serverItemSplit(%itemId)
//�ֽ�󴫻ز��ϲ�����ʽ����
//"itemId quantity"@ "|" @ "itemId quantity"......���8��
//���ֽܷⷵ��0
//(�ϳɽű�)
//serverItemCompose(%player,%itemInfolist);
//�ɹ�����itemID,���ɹ�����0
//
//getServerComposeInfo();
//��ͨ�ϳɷ���0,����ϳɷ���%itemInfolist
//
//%itemInfolist ��ʽ
//"mItemIdTag" @ "|" @ "itemID Quantity"......
//"itemID,Quantity"���8��,����һ��
//
//serverItemCompose(%player,%itemInfolist);
//�ɹ�����itemID ,Quantity,���ɹ�����0

//openItemSplitWnd(%playerId);//�ֽ�
//openItemComposeWnd(%playerId,%itemInfo);//�ϳ�
//%itemInfo = "106020101|106020102 5|106020103 100"


//$Fen[11110000] = "123456789 1 10"@ "|" @ "123456789 1 20"@ "|" @ "12345679 1 30";
//strcmpBySet(%str1,%str2,%set)�Ƚ������ַ��������ز���ֵ��%str1=%itemInfolist
//==================================================================================

//==============================�ֽ���ڵ�==============================//
function ServerItemSplit(%Player,%ItemId,%ItemNum)
{
	//echo("%ItemId,%ItemNum===" @ %ItemId @ "   " @ %ItemNum);
	if (%player == 0 || %itemId == 0 || %itemNum == 0)
		return 0;
	SetStrategyRecord(%Player,$StrategySubBtnSrc[1,4]);//���Դ�����¼
	HelpDirectByIndex(%Player.GetPlayerID(),15);//�ֽ�ָ��
	//2�ǵ��ߴ���
	%itemType = GetItemData(%ItemId,2);
	%itemSubType = GetItemData(%ItemId,3);
	%itemQuality = GetItemData(%ItemId,$Item_Data_Color);
	%itemLevel = GetItemData(%ItemId,$Item_Data_Lv);

	%result = 0;

	//���������ߡ���Ʒ�ֽ�
	if (%itemType == 1 || (%itemType == 2 && %itemSubType < 208) || %itemType == 3)
	{
		%result = getEquipmentResult(%player,%itemQuality,%itemLevel,%itemType);
		//		echo(%itemType @ "---------" @ %itemSubType @ "--------" @ %itemQuality @ "-----------" @%itemLevel);
		return %result;
	}
	else if (%itemType == 10)
	{
		if ((%itemSubType == 1001)||(%itemSubType == 1002)||(%itemSubType == 1003))
		{
			if ((%itemLevel == 1)||(%itemLevel == 2)||(%itemLevel == 3))
			{
				%result = getGemDecomposition(%player, %ItemId, %itemLevel, %ItemNum);
				return %result;
			}
		}
	}
	else if (%itemType == 20)
	{
		if (%itemQuality == 6)
		{
			%result = getAstrology(%Player,%ItemId,%itemQuality);
			return %result;
		}
	}
	return 0;
}

//��ȡ����ֽ���
function getAstrology(%Player,%ItemId,%itemQuality)
{
	if (%itemQuality == 6)
	{
		%Astrology = GetRandom(1,100);
		if ((%Astrology >= 1)&&(%Astrology <= 20)){ return "120010901 1"; }
		else if ((%Astrology >= 21)&&(%Astrology <= 55)){ return "120010901 2"; }
		else if ((%Astrology >= 56)&&(%Astrology <= 85)){ return "120010901 3"; }
		else if ((%Astrology >= 86)&&(%Astrology <= 95)){ return "120010901 4"; }
		else if ((%Astrology >= 96)&&(%Astrology <= 100)){ return "120010901 5"; }
		else { return "120010901 1"; }
	}
}


//��ȡ��ʯ�ֽ���
function getGemDecomposition(%Player, %ItemId, %itemLevel, %ItemNum)
{
	if (%itemLevel == 1){ return "110110001 " @ 1 * %ItemNum; }
	else if (%itemLevel == 2)
	{
		%GemResult = GetRandom(1,100);
		if ((%GemResult >= 1)&&(%GemResult <= 85)){ return "110110001 " @ 3 * %ItemNum; }
		else if ((%GemResult >= 86)&&(%GemResult <= 95)){ return "110110001 " @ 4 * %ItemNum; }
		else if ((%GemResult >= 96)&&(%GemResult <= 100)){ return "110110001 " @ 5 * %ItemNum; }
		else { return "110110001 " @ 3 * %ItemNum; }
	}
	else if (%itemLevel == 3)
	{
		%GemResult = GetRandom(1,100);
		if ((%GemResult >= 1)&&(%GemResult <= 40)){ return "110110001 " @ 10 * %ItemNum; }
		else if ((%GemResult >= 41)&&(%GemResult <= 70)){ return "110110001 " @ 15 * %ItemNum; }
		else if ((%GemResult >= 71)&&(%GemResult <= 90)){ return "110110001 " @ 20 * %ItemNum; }
		else if ((%GemResult >= 91)&&(%GemResult <= 100)){ return "110110001 " @ 25 * %ItemNum; }
		else { return "110110001 " @ 10 * %ItemNum; }
	}

	//	if(%itemLevel == 4){return "110110002 1";}	
	//		
	//	if(%itemLevel == 5)
	//		{
	//			%GemResult = GetRandom(1,100);
	//			if( (%GemResult >= 1)&&(%GemResult <= 85 ) ){return "110110002 3";}			
	//			else if( (%GemResult >= 86)&&(%GemResult <= 95) ){return "110110002 4";}
	//	  	else if( (%GemResult >= 96)&&(%GemResult <= 100) ){return "110110002 5";}
	//			else {return "110110002 3";}	
	//		}
	//		
	//	if(%itemLevel == 6)
	//		{
	//			%GemResult = GetRandom(1,100);
	//			
	//			if( (%GemResult >= 1)&&(%GemResult <= 40 ) ){return "110110002 10";}				
	//			else if( (%GemResult >= 41)&&(%GemResult <= 70) ){return "110110002 15";}				
	//			else if( (%GemResult >= 71)&&(%GemResult <= 90) ){return "110110002 20";}				
	//			else if( (%GemResult >= 91)&&(%GemResult <= 100) ){return "110110002 25";}				
	//			else {return "110110002 10";}				
	//		}			
}

//��ȡװ���ֽ���
function getEquipmentResult(%player,%itemQuality,%itemLevel,%itemType)
{
	//����ҳ����ֽ�װ���ȼ�10�������ʼ��롣
	%level = %player.getlevel();
	%factor = 1;

	//��ɫ
	if (%itemQuality == 3)
	{
		//if(%level - %itemLevel >= 10){%factor = 2;}

		if (%itemLevel <= 10)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 5)		{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 5)		{ return "116010001 3"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)	{ return "116010001 2"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 80)	{ return "116010001 1"; }

			//���û���ʣ�����1��1������
			return "116010001 1";
		}

		if (%itemLevel <= 20)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)	{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)	{ return "116010001 3"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 20)	{ return "116010001 2"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 60)	{ return "116010001 1"; }

			//���û���ʣ�����1��1������
			return "116010001 1";
		}

		if (%itemLevel <= 30)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 15)	{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 15)	{ return "116010001 3"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 30)	{ return "116010001 2"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 40)	{ return "116010001 1"; }

			//���û���ʣ�����1��1������
			return "116010001 1";
		}

		if (%itemLevel <= 40)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 5)		{ return "116010002 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 20)	{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 20)	{ return "116010001 3"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 40)	{ return "116010001 2"; }

			//���û���ʣ�����1��1������
			return "116010001 1";
		}

		if (%itemLevel <= 50)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)	{ return "116010002 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 25)	{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 25)	{ return "116010001 3"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 30)	{ return "116010001 2"; }

			//���û���ʣ�����1��1������
			return "116010001 1";
		}

		if (%itemLevel <= 60)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 15)	{ return "116010002 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 30)	{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 30)	{ return "116010001 3"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 20)	{ return "116010001 2"; }

			//���û���ʣ�����1��1������
			return "116010001 1";
		}

		if (%itemLevel <= 70)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 5)		{ return "116010002 2"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 15)	{ return "116010002 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 20)	{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 30)	{ return "116010001 3"; }

			//���û���ʣ�����1��1������
			return "116010001 1";
		}

		if (%itemLevel <= 80)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)	{ return "116010002 2"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)	{ return "116010002 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 25)	{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 20)	{ return "116010001 3"; }

			//���û���ʣ�����1��1������
			return "116010001 1";
		}

		if (%itemLevel <= 90)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 15)	{ return "116010002 2"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)	{ return "116010002 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 20)	{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 20)	{ return "116010001 3"; }

			//���û���ʣ�����1��1������
			return "116010001 1";
		}

		if (%itemLevel <= 100)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 20)	{ return "116010002 2"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)	{ return "116010002 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 20)		{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 15)	{ return "116010001 3"; }

			//���û���ʣ�����1��1������
			return "116010001 1";
		}
	}

	//��ɫ
	if (%itemQuality == 4)
	{
		//if(%level - %itemLevel >= 10){%factor = 2;}

		if (%itemLevel <= 10)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)		{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 40)		{ return "116010001 3"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 50)		{ return "116010001 2"; }

			//���û���ʣ�����1��1������
			return "116010001 1";
		}

		if (%itemLevel <= 20)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 30)		{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 30)		{ return "116010001 3"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 40)		{ return "116010001 2"; }

			//���û���ʣ�����1��1������
			return "116010001 1";
		}

		if (%itemLevel <= 30)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 50)		{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 20)		{ return "116010001 3"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 30)		{ return "116010001 2"; }

			//���û���ʣ�����1��1������
			return "116010001 1";
		}

		if (%itemLevel <= 40)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 5)			{ return "116010002 2"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)		{ return "116010002 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 30)		{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 45)		{ return "116010001 3"; }

			//���û���ʣ�����1��1������
			return "116010001 2";
		}

		if (%itemLevel <= 50)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 5)		{ return "116010002 2"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)		{ return "116010002 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 60)		{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 20)		{ return "116010001 3"; }

			//���û���ʣ�����1��1������
			return "116010001 2";
		}

		if (%itemLevel <= 60)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 5)		{ return "116010002 2"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 15)		{ return "116010002 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 60)		{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)		{ return "116010001 3"; }

			//���û���ʣ�����1��1������
			return "116010001 2";
		}

		if (%itemLevel <= 70)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 0)			{ return "116010003 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 5)			{ return "116010002 3"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)		{ return "116010002 2"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)		{ return "116010001 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 60)		{ return "116010001 4"; }

			//���û���ʣ�����1��1������
			return "116010001 3";
		}

		if (%itemLevel <= 80)
		{
			%rndResult = GetRandom(1,200 * %factor);
			if (%rndResult <= 0)			{ return "116010003 1"; }
			%rndResult = GetRandom(1,200 * %factor);
			if (%rndResult <= 5)		{ return "116010002 3"; }
			%rndResult = GetRandom(1,200 * %factor);
			if (%rndResult <= 10)		{ return "116010002 2"; }
			%rndResult = GetRandom(1,200 * %factor);
			if (%rndResult <= 20)		{ return "116010001 1"; }
			%rndResult = GetRandom(1,200 * %factor);
			if (%rndResult <= 50)		{ return "116010001 4"; }

			//���û���ʣ�����1��1������
			return "116010001 3";
		}

		if (%itemLevel <= 90)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 0)			{ return "116010003 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 5)		{ return "116010002 3"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)		{ return "116010002 2"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 30)		{ return "116010001 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 40)		{ return "116010001 4"; }

			//���û���ʣ�����1��1������
			return "116010001 3";
		}


		if (%itemLevel <= 100)
		{
			%rndResult = GetRandom(1,200 * %factor);
			if (%rndResult <= 0)			{ return "116010003 1"; }
			%rndResult = GetRandom(1,200 * %factor);
			if (%rndResult <= 10)		{ return "116010002 3"; }
			%rndResult = GetRandom(1,200 * %factor);
			if (%rndResult <= 10)		{ return "116010002 2"; }
			%rndResult = GetRandom(1,200 * %factor);
			if (%rndResult <= 40)		{ return "116010001 1"; }
			%rndResult = GetRandom(1,200 * %factor);
			if (%rndResult <= 30)		{ return "116010001 4"; }

			//���û���ʣ�����1��1������
			return "116010001 3";
		}
	}

	//��ɫ
	if (%itemQuality == 5)
	{
		//if(%level - %itemLevel >= 10){%factor = 2;}

		if (%itemLevel <= 10)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 40)		{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 60)		{ return "116010001 3"; }

			//���û���ʣ�����1��1������
			return "116010001 2";
		}

		if (%itemLevel <= 20)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 30)		{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 70)		{ return "116010001 3"; }

			//���û���ʣ�����1��1������
			return "116010001 2";
		}

		if (%itemLevel <= 30)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)		{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 90)		{ return "116010001 3"; }

			//���û���ʣ�����1��1������
			return "116010001 2";
		}

		if (%itemLevel <= 40)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 5)			{ return "116010002 3"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 30)		{ return "116010002 2"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 30)		{ return "116010002 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 30)		{ return "116010001 4"; }

			//���û���ʣ�����1��1������
			return "116010001 2";
		}

		if (%itemLevel <= 50)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)		{ return "116010002 3"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 35)		{ return "116010002 2"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 25)		{ return "116010002 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 20)		{ return "116010001 4"; }

			//���û���ʣ�����1��1������
			return "116010001 3";
		}

		if (%itemLevel <= 60)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 15)		{ return "116010002 3"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 40)		{ return "116010002 2"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 20)		{ return "116010002 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)		{ return "116010001 4"; }

			//���û���ʣ�����3��1������
			return "116010001 3";
		}

		if (%itemLevel <= 70)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 1)			{ return "116010003 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 5)			{ return "116010002 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 15)		{ return "116010002 3"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 25)		{ return "116010002 2"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 30)		{ return "116010002 1"; }

			//���û���ʣ�����1��2������
			return "116010002 1";
		}

		if (%itemLevel <= 80)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 1)			{ return "116010003 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)		{ return "116010002 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 20)		{ return "116010002 3"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 20)		{ return "116010002 2"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 25)		{ return "116010002 1"; }

			//���û���ʣ�����1��2������
			return "116010002 1";
		}

		if (%itemLevel <= 90)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 1)			{ return "116010003 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 15)		{ return "116010002 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 25)		{ return "116010002 3"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 15)		{ return "116010002 2"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 20)		{ return "116010002 1"; }

			//���û���ʣ�����1��2������
			return "116010002 1";
		}

		if (%itemLevel <= 100)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 1)			{ return "116010003 1"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 20)		{ return "116010002 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 30)		{ return "116010002 3"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)		{ return "116010002 2"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 15)		{ return "116010002 1"; }

			//���û���ʣ�����1��2������
			return "116010002 1";
		}
	}
	//��ɫ
	if (%itemQuality == 6)
	{
		if ((%itemType == 2) && (%itemSubType < 208))
		{
			return "106070404 1";
		}
		else if (%itemType == 3)
		{
			return "106070405 1";
		}
	}
	return 0;
}

//��ȡװ���ֽ������
function getEquipmentExtra(%player,%itemType,%itemSubType,%itemLevel)
{
	//	%rndResult = GetRandom(1 , 100);
	//	
	//	%ItemId = 0;
	//	
	//	if(%itemLevel <= 39)
	//	{
	//		if((%itemSubType == 101 || %itemSubType == 104 || %itemSubType == 105) 												&& %rndResult <= 10){return "106020401 1";}//Զ������
	//		if((%itemSubType == 102 || %itemSubType == 103 || %itemSubType == 106 || %itemSubType == 107) && %rndResult <= 10){return "106020501 1";}//��������
	//		if((%itemSubType == 301 || %itemSubType == 302 || %itemSubType == 303) 												&& %rndResult <= 10){return "106050401 1";}//���κϳɲ���
	//		if((%itemSubType == 204 || %itemSubType == 205 || %itemSubType == 206 || %itemSubType == 207) && %rndResult <= 10){return "106080501 1";}//�ӹ���Ƥ
	//		if((%itemSubType == 201 || %itemSubType == 202 || %itemSubType == 203) 												&& %rndResult <= 10){return "106080401 1";}//�ϳ���Ƥ
	//	}
	//	
	//	if(%itemLevel <= 59)
	//	{
	//		if((%itemSubType == 101 || %itemSubType == 104 || %itemSubType == 105) 												&& %rndResult <= 10){return "106020402 1";}//Զ������
	//		if((%itemSubType == 102 || %itemSubType == 103 || %itemSubType == 106 || %itemSubType == 107) && %rndResult <= 10){return "106020502 1";}//��������
	//		if((%itemSubType == 301 || %itemSubType == 302 || %itemSubType == 303) 												&& %rndResult <= 10){return "106050402 1";}//���κϳɲ���
	//		if((%itemSubType == 204 || %itemSubType == 205 || %itemSubType == 206 || %itemSubType == 207) && %rndResult <= 10){return "106080502 1";}//�ӹ���Ƥ
	//		if((%itemSubType == 201 || %itemSubType == 202 || %itemSubType == 203) 												&& %rndResult <= 10){return "106080402 1";}//�ϳ���Ƥ
	//	}
	//	
	//	if(%itemLevel <= 79)
	//	{
	//		if((%itemSubType == 101 || %itemSubType == 104 || %itemSubType == 105) 												&& %rndResult <= 10){return "106020403 1";}//Զ������
	//		if((%itemSubType == 102 || %itemSubType == 103 || %itemSubType == 106 || %itemSubType == 107) && %rndResult <= 10){return "106020503 1";}//��������
	//		if((%itemSubType == 301 || %itemSubType == 302 || %itemSubType == 303) 												&& %rndResult <= 10){return "106050403 1";}//���κϳɲ���
	//		if((%itemSubType == 204 || %itemSubType == 205 || %itemSubType == 206 || %itemSubType == 207) && %rndResult <= 10){return "106080503 1";}//�ӹ���Ƥ
	//		if((%itemSubType == 201 || %itemSubType == 202 || %itemSubType == 203) 												&& %rndResult <= 10){return "106080403 1";}//�ϳ���Ƥ
	//	}
	//	
	//	if(%itemLevel <= 99)
	//	{
	//		if((%itemSubType == 101 || %itemSubType == 104 || %itemSubType == 105) 												&& %rndResult <= 10){return "106020404 1";}//Զ������
	//		if((%itemSubType == 102 || %itemSubType == 103 || %itemSubType == 106 || %itemSubType == 107) && %rndResult <= 10){return "106020504 1";}//��������
	//		if((%itemSubType == 301 || %itemSubType == 302 || %itemSubType == 303) 												&& %rndResult <= 10){return "106050404 1";}//���κϳɲ���
	//		if((%itemSubType == 204 || %itemSubType == 205 || %itemSubType == 206 || %itemSubType == 207) && %rndResult <= 10){return "106080504 1";}//�ӹ���Ƥ
	//		if((%itemSubType == 201 || %itemSubType == 202 || %itemSubType == 203) 												&& %rndResult <= 10){return "106080404 1";}//�ϳ���Ƥ
	//	}
	//	
	//	if(%itemLevel <= 119)
	//	{
	//		if((%itemSubType == 101 || %itemSubType == 104 || %itemSubType == 105) 												&& %rndResult <= 10){return "106020405 1";}//Զ������
	//		if((%itemSubType == 102 || %itemSubType == 103 || %itemSubType == 106 || %itemSubType == 107) && %rndResult <= 10){return "106020505 1";}//��������
	//		if((%itemSubType == 301 || %itemSubType == 302 || %itemSubType == 303) 												&& %rndResult <= 10){return "106050405 1";}//���κϳɲ���
	//		if((%itemSubType == 204 || %itemSubType == 205 || %itemSubType == 206 || %itemSubType == 207) && %rndResult <= 10){return "106080505 1";}//�ӹ���Ƥ
	//		if((%itemSubType == 201 || %itemSubType == 202 || %itemSubType == 203) 												&& %rndResult <= 10){return "106080405 1";}//�ϳ���Ƥ
	//	}
	//	
	//	return 0;
}

//==============================�ϳ���ڵ�==============================//
function serverItemCompose(%player,%itemInfo)
{
	if (%player == 0 || %itemInfo $= "")
		return 0;

	%stringCount = getWordCount(%itemInfo,"|\n");

	if (%stringCount <= 1)
		return 0;

	%itemTag = getWord(%itemInfo,0,"|\n");

	//%itemTag == 0 ��ͨ�ϳɣ�����Ϊ����ϳ�
	if (%itemTag == 0)
	{
		%materialCount = %stringCount -1;

		if (%materialCount ==1)
		{
			%tempInfo = getWord(%itemInfo,1,"|\n");
			%itemId   = getWord(%tempInfo,0);
			%quantity = getWord(%tempInfo,1);

			//���޲�Ѫҩ
			if (%itemId == 105110001 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105110002 " @ %quantity / 3; } }
			if (%itemId == 105110002 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105110003 " @ %quantity / 3; } }
			if (%itemId == 105110003 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105110004 " @ %quantity / 3; } }
			if (%itemId == 105110004 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105110005 " @ %quantity / 3; } }

			//���޲���ҩ
			if (%itemId == 105120001 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105120002 " @ %quantity / 3; } }
			if (%itemId == 105120002 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105120003 " @ %quantity / 3; } }
			if (%itemId == 105120003 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105120004 " @ %quantity / 3; } }
			if (%itemId == 105120004 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105120005 " @ %quantity / 3; } }

			//��ɫ��Ѫʳ��
			if (%itemId == 105010101 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010102 " @ %quantity / 3; } }
			if (%itemId == 105010102 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010103 " @ %quantity / 3; } }
			if (%itemId == 105010103 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010104 " @ %quantity / 3; } }
			if (%itemId == 105010104 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010105 " @ %quantity / 3; } }
			if (%itemId == 105010105 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010106 " @ %quantity / 3; } }
			if (%itemId == 105010106 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010107 " @ %quantity / 3; } }
			if (%itemId == 105010107 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010108 " @ %quantity / 3; } }
			if (%itemId == 105010108 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010109 " @ %quantity / 3; } }
			if (%itemId == 105010109 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010110 " @ %quantity / 3; } }

			//��ɫ����ʳ��
			if (%itemId == 105010121 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010122 " @ %quantity / 3; } }
			if (%itemId == 105010122 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010123 " @ %quantity / 3; } }
			if (%itemId == 105010123 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010124 " @ %quantity / 3; } }
			if (%itemId == 105010124 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010125 " @ %quantity / 3; } }
			if (%itemId == 105010125 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010126 " @ %quantity / 3; } }
			if (%itemId == 105010126 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010127 " @ %quantity / 3; } }
			if (%itemId == 105010127 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010128 " @ %quantity / 3; } }
			if (%itemId == 105010128 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010129 " @ %quantity / 3; } }
			if (%itemId == 105010129 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010130 " @ %quantity / 3; } }

			//��ɫ��ѪҩƷ
			if (%itemId == 105020101 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105020102 " @ %quantity / 3; } }
			if (%itemId == 105020102 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105020103 " @ %quantity / 3; } }
			if (%itemId == 105020103 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105020104 " @ %quantity / 3; } }
			if (%itemId == 105020104 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105020105 " @ %quantity / 3; } }
			if (%itemId == 105020105 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105020106 " @ %quantity / 3; } }

			//��ɫ����ҩƷ
			if (%itemId == 105020121 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105020122 " @ %quantity / 3; } }
			if (%itemId == 105020122 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105020123 " @ %quantity / 3; } }
			if (%itemId == 105020123 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105020124 " @ %quantity / 3; } }
			if (%itemId == 105020124 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105020125 " @ %quantity / 3; } }
			if (%itemId == 105020125 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105020126 " @ %quantity / 3; } }

			return 0;
		}
		else if (%materialCount == 2)
		{
		}
		else if (%materialCount == 3)
		{
		}
		else if (%materialCount == 4)
		{
		}
		else if (%materialCount == 5)
		{
		}
		else if (%materialCount == 6)
		{
		}
		else if (%materialCount == 7)
		{
		}
		else if (%materialCount == 8)
		{
		}
		else
		{
			return 0;
		}
	}
	else
	{
		%materialCount = %stringCount -1;//�м��ֲ���

		%bResult = 0;
		for (%i = 0;%i<99;%i++)
		{
			if ($PeiFang[%itemTag,%i] $= "")//�ϳ��䷽Ϊ��
				break;

			//��������Ŀǰ��Ϊ1 Ҫ�ģ�			
			if (strcmpBySet(%itemInfo,$PeiFang[%itemTag,%i],"|\n"))
			{
				return %itemTag @ " 1";
			}
			else
				continue;
		}
		return 0;
	}

	return 0;
}

$PeiFang[106020101,0] = "106020101|105020141 2|105020161 1";// "����|����1 ����1����|����2 ����2����..."


