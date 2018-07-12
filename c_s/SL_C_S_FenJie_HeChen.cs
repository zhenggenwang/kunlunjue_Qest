//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//用于玩家分解道具时，服务端脚本调用
//==================================================================================


//==================================================================================
//服务端脚本调用(分解)
//serverItemSplit(%itemId)
//分解后传回材料参数格式如下
//"itemId quantity"@ "|" @ "itemId quantity"......最多8项
//不能分解返回0
//(合成脚本)
//serverItemCompose(%player,%itemInfolist);
//成功返回itemID,不成功返回0
//
//getServerComposeInfo();
//普通合成返回0,物殊合成返回%itemInfolist
//
//%itemInfolist 格式
//"mItemIdTag" @ "|" @ "itemID Quantity"......
//"itemID,Quantity"最多8项,最少一项
//
//serverItemCompose(%player,%itemInfolist);
//成功返回itemID ,Quantity,不成功返回0

//openItemSplitWnd(%playerId);//分解
//openItemComposeWnd(%playerId,%itemInfo);//合成
//%itemInfo = "106020101|106020102 5|106020103 100"


//$Fen[11110000] = "123456789 1 10"@ "|" @ "123456789 1 20"@ "|" @ "12345679 1 30";
//strcmpBySet(%str1,%str2,%set)比较两个字符串，返回布尔值。%str1=%itemInfolist
//==================================================================================

//==============================分解入口点==============================//
function ServerItemSplit(%Player,%ItemId,%ItemNum)
{
	//echo("%ItemId,%ItemNum===" @ %ItemId @ "   " @ %ItemNum);
	if (%player == 0 || %itemId == 0 || %itemNum == 0)
		return 0;
	SetStrategyRecord(%Player,$StrategySubBtnSrc[1,4]);//攻略触发记录
	HelpDirectByIndex(%Player.GetPlayerID(),15);//分解指引
	//2是道具大类
	%itemType = GetItemData(%ItemId,2);
	%itemSubType = GetItemData(%ItemId,3);
	%itemQuality = GetItemData(%ItemId,$Item_Data_Color);
	%itemLevel = GetItemData(%ItemId,$Item_Data_Lv);

	%result = 0;

	//武器、防具、饰品分解
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

//获取星象分解结果
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


//获取宝石分解结果
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

//获取装备分解结果
function getEquipmentResult(%player,%itemQuality,%itemLevel,%itemType)
{
	//若玩家超过分解装备等级10级，几率减半。
	%level = %player.getlevel();
	%factor = 1;

	//绿色
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
			return "116010001 1";
		}
	}

	//蓝色
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
			return "116010001 3";
		}
	}

	//紫色
	if (%itemQuality == 5)
	{
		//if(%level - %itemLevel >= 10){%factor = 2;}

		if (%itemLevel <= 10)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 40)		{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 60)		{ return "116010001 3"; }

			//如果没几率，返回1个1级材料
			return "116010001 2";
		}

		if (%itemLevel <= 20)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 30)		{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 70)		{ return "116010001 3"; }

			//如果没几率，返回1个1级材料
			return "116010001 2";
		}

		if (%itemLevel <= 30)
		{
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 10)		{ return "116010001 4"; }
			%rndResult = GetRandom(1,100 * %factor);
			if (%rndResult <= 90)		{ return "116010001 3"; }

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回1个1级材料
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

			//如果没几率，返回3个1级材料
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

			//如果没几率，返回1个2级材料
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

			//如果没几率，返回1个2级材料
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

			//如果没几率，返回1个2级材料
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

			//如果没几率，返回1个2级材料
			return "116010002 1";
		}
	}
	//橙色
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

//获取装备分解额外结果
function getEquipmentExtra(%player,%itemType,%itemSubType,%itemLevel)
{
	//	%rndResult = GetRandom(1 , 100);
	//	
	//	%ItemId = 0;
	//	
	//	if(%itemLevel <= 39)
	//	{
	//		if((%itemSubType == 101 || %itemSubType == 104 || %itemSubType == 105) 												&& %rndResult <= 10){return "106020401 1";}//远程武器
	//		if((%itemSubType == 102 || %itemSubType == 103 || %itemSubType == 106 || %itemSubType == 107) && %rndResult <= 10){return "106020501 1";}//近程武器
	//		if((%itemSubType == 301 || %itemSubType == 302 || %itemSubType == 303) 												&& %rndResult <= 10){return "106050401 1";}//首饰合成材料
	//		if((%itemSubType == 204 || %itemSubType == 205 || %itemSubType == 206 || %itemSubType == 207) && %rndResult <= 10){return "106080501 1";}//加工兽皮
	//		if((%itemSubType == 201 || %itemSubType == 202 || %itemSubType == 203) 												&& %rndResult <= 10){return "106080401 1";}//合成兽皮
	//	}
	//	
	//	if(%itemLevel <= 59)
	//	{
	//		if((%itemSubType == 101 || %itemSubType == 104 || %itemSubType == 105) 												&& %rndResult <= 10){return "106020402 1";}//远程武器
	//		if((%itemSubType == 102 || %itemSubType == 103 || %itemSubType == 106 || %itemSubType == 107) && %rndResult <= 10){return "106020502 1";}//近程武器
	//		if((%itemSubType == 301 || %itemSubType == 302 || %itemSubType == 303) 												&& %rndResult <= 10){return "106050402 1";}//首饰合成材料
	//		if((%itemSubType == 204 || %itemSubType == 205 || %itemSubType == 206 || %itemSubType == 207) && %rndResult <= 10){return "106080502 1";}//加工兽皮
	//		if((%itemSubType == 201 || %itemSubType == 202 || %itemSubType == 203) 												&& %rndResult <= 10){return "106080402 1";}//合成兽皮
	//	}
	//	
	//	if(%itemLevel <= 79)
	//	{
	//		if((%itemSubType == 101 || %itemSubType == 104 || %itemSubType == 105) 												&& %rndResult <= 10){return "106020403 1";}//远程武器
	//		if((%itemSubType == 102 || %itemSubType == 103 || %itemSubType == 106 || %itemSubType == 107) && %rndResult <= 10){return "106020503 1";}//近程武器
	//		if((%itemSubType == 301 || %itemSubType == 302 || %itemSubType == 303) 												&& %rndResult <= 10){return "106050403 1";}//首饰合成材料
	//		if((%itemSubType == 204 || %itemSubType == 205 || %itemSubType == 206 || %itemSubType == 207) && %rndResult <= 10){return "106080503 1";}//加工兽皮
	//		if((%itemSubType == 201 || %itemSubType == 202 || %itemSubType == 203) 												&& %rndResult <= 10){return "106080403 1";}//合成兽皮
	//	}
	//	
	//	if(%itemLevel <= 99)
	//	{
	//		if((%itemSubType == 101 || %itemSubType == 104 || %itemSubType == 105) 												&& %rndResult <= 10){return "106020404 1";}//远程武器
	//		if((%itemSubType == 102 || %itemSubType == 103 || %itemSubType == 106 || %itemSubType == 107) && %rndResult <= 10){return "106020504 1";}//近程武器
	//		if((%itemSubType == 301 || %itemSubType == 302 || %itemSubType == 303) 												&& %rndResult <= 10){return "106050404 1";}//首饰合成材料
	//		if((%itemSubType == 204 || %itemSubType == 205 || %itemSubType == 206 || %itemSubType == 207) && %rndResult <= 10){return "106080504 1";}//加工兽皮
	//		if((%itemSubType == 201 || %itemSubType == 202 || %itemSubType == 203) 												&& %rndResult <= 10){return "106080404 1";}//合成兽皮
	//	}
	//	
	//	if(%itemLevel <= 119)
	//	{
	//		if((%itemSubType == 101 || %itemSubType == 104 || %itemSubType == 105) 												&& %rndResult <= 10){return "106020405 1";}//远程武器
	//		if((%itemSubType == 102 || %itemSubType == 103 || %itemSubType == 106 || %itemSubType == 107) && %rndResult <= 10){return "106020505 1";}//近程武器
	//		if((%itemSubType == 301 || %itemSubType == 302 || %itemSubType == 303) 												&& %rndResult <= 10){return "106050405 1";}//首饰合成材料
	//		if((%itemSubType == 204 || %itemSubType == 205 || %itemSubType == 206 || %itemSubType == 207) && %rndResult <= 10){return "106080505 1";}//加工兽皮
	//		if((%itemSubType == 201 || %itemSubType == 202 || %itemSubType == 203) 												&& %rndResult <= 10){return "106080405 1";}//合成兽皮
	//	}
	//	
	//	return 0;
}

//==============================合成入口点==============================//
function serverItemCompose(%player,%itemInfo)
{
	if (%player == 0 || %itemInfo $= "")
		return 0;

	%stringCount = getWordCount(%itemInfo,"|\n");

	if (%stringCount <= 1)
		return 0;

	%itemTag = getWord(%itemInfo,0,"|\n");

	//%itemTag == 0 普通合成，否则为特殊合成
	if (%itemTag == 0)
	{
		%materialCount = %stringCount -1;

		if (%materialCount ==1)
		{
			%tempInfo = getWord(%itemInfo,1,"|\n");
			%itemId   = getWord(%tempInfo,0);
			%quantity = getWord(%tempInfo,1);

			//神兽补血药
			if (%itemId == 105110001 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105110002 " @ %quantity / 3; } }
			if (%itemId == 105110002 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105110003 " @ %quantity / 3; } }
			if (%itemId == 105110003 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105110004 " @ %quantity / 3; } }
			if (%itemId == 105110004 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105110005 " @ %quantity / 3; } }

			//神兽补篮药
			if (%itemId == 105120001 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105120002 " @ %quantity / 3; } }
			if (%itemId == 105120002 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105120003 " @ %quantity / 3; } }
			if (%itemId == 105120003 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105120004 " @ %quantity / 3; } }
			if (%itemId == 105120004 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105120005 " @ %quantity / 3; } }

			//角色补血食物
			if (%itemId == 105010101 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010102 " @ %quantity / 3; } }
			if (%itemId == 105010102 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010103 " @ %quantity / 3; } }
			if (%itemId == 105010103 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010104 " @ %quantity / 3; } }
			if (%itemId == 105010104 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010105 " @ %quantity / 3; } }
			if (%itemId == 105010105 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010106 " @ %quantity / 3; } }
			if (%itemId == 105010106 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010107 " @ %quantity / 3; } }
			if (%itemId == 105010107 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010108 " @ %quantity / 3; } }
			if (%itemId == 105010108 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010109 " @ %quantity / 3; } }
			if (%itemId == 105010109 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010110 " @ %quantity / 3; } }

			//角色补篮食物
			if (%itemId == 105010121 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010122 " @ %quantity / 3; } }
			if (%itemId == 105010122 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010123 " @ %quantity / 3; } }
			if (%itemId == 105010123 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010124 " @ %quantity / 3; } }
			if (%itemId == 105010124 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010125 " @ %quantity / 3; } }
			if (%itemId == 105010125 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010126 " @ %quantity / 3; } }
			if (%itemId == 105010126 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010127 " @ %quantity / 3; } }
			if (%itemId == 105010127 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010128 " @ %quantity / 3; } }
			if (%itemId == 105010128 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010129 " @ %quantity / 3; } }
			if (%itemId == 105010129 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105010130 " @ %quantity / 3; } }

			//角色补血药品
			if (%itemId == 105020101 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105020102 " @ %quantity / 3; } }
			if (%itemId == 105020102 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105020103 " @ %quantity / 3; } }
			if (%itemId == 105020103 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105020104 " @ %quantity / 3; } }
			if (%itemId == 105020104 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105020105 " @ %quantity / 3; } }
			if (%itemId == 105020105 && %quantity >= 3){ if ((%quantity % 3) == 0){ return "105020106 " @ %quantity / 3; } }

			//角色补蓝药品
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
		%materialCount = %stringCount -1;//有几种材料

		%bResult = 0;
		for (%i = 0;%i<99;%i++)
		{
			if ($PeiFang[%itemTag,%i] $= "")//合成配方为空
				break;

			//产出数量目前都为1 要改？			
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

$PeiFang[106020101,0] = "106020101|105020141 2|105020161 1";// "产物|材料1 材料1数量|材料2 材料2数量..."


