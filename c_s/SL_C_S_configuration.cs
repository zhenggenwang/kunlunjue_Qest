//■■■■■■■■■■■【神兵觉醒】相关■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【装备附灵】相关■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【神兵修理】相关■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【跑马消息】相关■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【免费飞行】相关■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【召唤队友】相关■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【大转盘】相关■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【欢乐大转盘】相关■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【时装合成】相关■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【十天嘉年华】相关■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【玩家战斗力】相关■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【聚宝盆】相关■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【经脉】相关■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【星套强化】相关■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【宝石】相关■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【角色死亡损失】相关■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【装备】相关■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【装备—鉴定】相关■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【鉴宝】相关■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【造化神石合成】相关■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【充值礼包】相关■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【在线奖励】相关■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【攻城战】相关■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【充值反馈】相关■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【抽奖触发公告】相关■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【全民夺宝相关】■■■■■■■■■■■■■■■■
//■■■■【挖矿】■■■■【杂矿计算函数】■■■■■■■
//■■■■【夺宝】■■■■【返回消耗道具】■■■■■■■
//■■■■【声望】■■■■【设置和获取声望】■■■■■■
//■■■■【仙缘解签】■■■■【返回活动开关】■■■■■
//■■■■【祈愿豪礼】■■■■【返回活动开关】■■■■■
//■■■■【全民夺宝】■■■■【中奖触发】■■■■■■■

//■■■■■■■■■■■【特权和尊享服务】■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【连续充值送豪礼】■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【我的形象我做主】■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【悠享基金】■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【限购商店】■■■■■■■■■■■■■■■■■■■■

//mfloor(%num) 最小取整 mceil(%num);最大取整 mround(%num)4舍5入取整





//■■■■■■■■■■■【神兵觉醒】相关■■■■■■■■■■■■■■■■■■
function getDeityWaaponMaterial(%getDeityWaaponMaterial)
{
	return 105090421;

}
//■■■■■■■■■■■【神兵觉醒】相关■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【装备附灵】相关■■■■■■■■■■■■■■■■■■
//增灵所需道具
//换灵所需道具
//洗灵所需道具


//【装备换灵】成功后调用
function SetFreeLockChangeTimes(%times, %Player)
{

}

//【装备洗灵】免费次数返回
function getFreeLockClearTimes(%Player)
{
	//如果不在活动时间内
	if (GetStartTime("KaiFuHuoDong") > 0)
		return 0;

	//如果已经领取
	if (GetWord(%Player.GetActivity(2254), 1) == 0)
		return 1;

	return 0;
}

//【装备洗灵】成功后调用
function SetFreeLockClearTimes(%times, %Player)
{

}
//■■■■■■■■■■■【装备附灵】相关■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【神兵修理】相关■■■■■■■■■■■■■■■■■■
//神器剩余免费次数返回
function inspectVipTimer_ShenQiXiuLi(%Player)
{
	if (HasBit($ShenJiangTeQuan_Particular_bActive, 0) > 0)
	{
		//是否拥有【尉迟恭】VIP
		if (%Player.isVip(0) > 0)
			return 1;
	}

	return 0;
}

//神器免费修理后触发
function processVipTimer_ShenQiXiuLi(%player)
{
}
//■■■■■■■■■■■【神兵修理】相关■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【跑马消息】相关■■■■■■■■■■■■■■■■■■

//跑马消息剩余免费次数返回
function InspectVipTimer_FreeSuperWorld(%Player)
{
	if (HasBit($ShenJiangTeQuan_Particular_bActive, 1) > 0)
	{
		//是否拥有【尉迟恭】VIP
		if (%Player.isVip(0) > 0)
		{
			%Surplus = 5 - GetWord(%Player.GetActivity(3002), 0);
			if (%Surplus > 0)
				return %Surplus;
		}
	}

	return 0;
}

//跑马消息发送后触发
function ProcessVipTimer_FreeSuperWorld(%Player)
{
	//if(HasBit($ShenJiangTeQuan_Particular_bActive, 1) > 0)
	//	{
	//	}
}
//■■■■■■■■■■■【免费飞行】相关■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【免费飞行】相关■■■■■■■■■■■■■■■■■■
//VIP赠送飞行的最大次数返回
function inspectVipTimer_FreeFlayCount(%Player)
{
	//if ( HasBit( $ShenJiangTeQuan_Particular_bActive, 2 ) > 0 )
	//{
	//	//是否拥有【尉迟恭】VIP
	//	if ( %Player.isVip( 0 ) > 0 )
	//		return 5;
	//}

	return 0;
}

//消耗VIP赠送的飞行时调用
function processVipTimer_FreeFlayCount(%Player)
{
	//if(HasBit($ShenJiangTeQuan_Particular_bActive, 2) > 0)
	//	{
	//	}
}
//■■■■■■■■■■■【免费飞行】相关■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【召唤队友】相关■■■■■■■■■■■■■■■■■■
//返回召唤队友免费次数
function inspectVipTimer_ZhaoHuanDuiYou(%Player)
{
	if (HasBit($ShenJiangTeQuan_Particular_bActive, 3) > 0)
	{
		//是否拥有【尉迟恭】VIP
		if (%Player.isVip(0) > 0)
		{
			%Surplus = 1 - GetWord(%Player.GetActivity(3004), 0);
			if (%Surplus > 0)
				return %Surplus;
		}
	}

	return 0;
}
//■■■■■■■■■■■【召唤队友】相关■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【大转盘】相关■■■■■■■■■■■■■■■■■■■
//每日刷新大转盘次数
function setRaffleCount(%Player, %raffleCount, %afreshCount)
{
}


//判断是否可执行免费抽奖(大转盘) 返回:vip包月中赠送的免费次数(当前剩余次数) (客户端 服务器)
function inspectVipTimer_FreeRaffle(%Player)
{
	//是否拥有【秦琼】VIP
	if (%Player.isVip(1) > 0)
	{
		%Surplus = 1 - GetWord(%Player.GetActivity(3006), 0);
		if (%Surplus > 0)
			return %Surplus;
	}

	return 0;
}

//减少vip包月中赠送的免费次数(服务器)
function processVipTimer_FreeRaffle(%Player)
{
}

//大转盘获得道具全服公告
function SendCrazyDialMessage(%Player, %ItemID)
{
	%PlayerName = GetPlayerZiTiName(%Player, 1);
	%ItemName = GetItemName(%ItemID, 1);
	%ItemName1 = GetItemName(%ItemID, 2);
	%Txt = %PlayerName @ $Get_Dialog_GeShi[31419] @ "福星高照，在『财神转转转』中获得</t>" @ %ItemName @ $Get_Dialog_GeShi[31419] @ "，真是羡煞旁人！</t>";
	SendOneLineMessage(%Txt);

	if ((%ItemID == 113050030) || (%ItemID == 113050036) || (%ItemID == 113050042) || (%ItemID == 105103116) || (%ItemID == 105103117) ||
		(%ItemID == 105103118) || (%ItemID == 105101764) || (%ItemID == 105101763) || (%ItemID == 105101765))
	{
		%Txt = $Get_Dialog_GeShi[60001] @ "『" @ %Player.GetPlayerName() @ "』</t>" @ $Get_Dialog_GeShi[60000] @ "福星高照，在『财神转转转』中获得</t>" @
			%ItemName1 @ $Get_Dialog_GeShi[60000] @ "，真是羡煞旁人！</t>";
		SendOneLineMessage(%Txt, $chatMsg_Type_Normal2);
	}
}
//■■■■■■■■■■■【大转盘】相关■■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【时装合成】相关■■■■■■■■■■■■■■■■■■
//合成时装消耗积分（废弃）

//合成时装消耗道具编号
//合成时装消耗道具数量

//合成结果返回


//合成时装消耗积分（废弃）
function getComposeFashionCostMoney(%colorLevel)
{
	if (%colorLevel == 2)return 100;
	else if (%colorLevel == 3)return 300;
	else if (%colorLevel == 4)return 800;
	else if (%colorLevel == 5)return 1200;

	return 2000;
}

//合成时装消耗道具编号
function getComposeFashionMaterialID(%colorLevel)
{
	return 105103148;
}

//合成时装消耗道具数量
function getComposeFashionMaterialCount(%colorLevel)
{
	if (%colorLevel == 3)return 1;	//绿色
	else if (%colorLevel == 4)return 3;	//蓝色
	else if (%colorLevel == 5)return 10;	//紫色
	else if (%colorLevel == 6)return 15;	//橙色
	return 20;
}

//合成结果返回
function getComposeFashionResultID(%colorLevel)
{
	%Random = GetRandom(1, 10000);
	for (%i = 0; %i <= 100; %i++)
	{
		/*获取装备颜色	*/	%ItemID[%i] = GetWord($ShiZhuangHeChengItemJiLv[%colorLevel, %i], 0);  //$ShiZhuangHeChengItemJiLv[6, 0 ] = "102106016 3000"; 
		/*获取装备几率	*/	%ItemJL[%i] = GetWord($ShiZhuangHeChengItemJiLv[%colorLevel, %i], 1);  //$ShiZhuangHeChengItemJiLv[6, 1 ] = "102106020 3000"; 
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


//■■■■■■■■■■■【时装合成】相关■■■■■■■■■■■■■■■■■■


//神器觉醒所需数量
function getDeityWeaponEmbedMatNum(%level)
{
	if (%level == 60) return 1;
	else if (%level == 70) return 2;
	else if (%level == 80) return 3;
	else if (%level == 90) return 10;
	else if (%level == 100) return 15;

	return 15;
}



//装备转魂所需材料数量
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




//////////// 宠物系统 ///////////////////////////////////////////
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

//神兽变异消耗设定
function GetPetVariationLevelCost(%level)
{
	if (%level <= 3) return 105103154;
	else if (%level <= 6) return 105103155;
	else if (%level <= 9) return 105103156;
}

//物品吞噬需要的携带等级
function GetAddvariationNeedlev(%item)
{
	return 0;
}

//神兽吞噬增加的变异值，传入被吞噬神兽的成长率和变异值
function GetPetAddvariation(%chengZhangLv, %variation)
{
	%exp = mfloor(%variation * 0.7) + 10;
	return %exp;
}

//getAddvariationNeedMoney_pet(%level,%spawnLevel,%variationLevel,%exp);等级 携带等级 变异等级 经验

function getAddvariationNeedMoney_pet(%level, %spawnLevel, %variationLevel, %exp)
{
	return 100;
}

//最大变异次数
function getMaxvariation()
{
	return 9;
}

//神兽变异等级吞噬对应的神兽 参数1 吞噬宠物的变异等级, 参数2 被吞噬宠物的携带等级
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

//传物品ID跟数量进去 获得每次1个精魄需要扣除积分的数量
function getAddvariationNeedMoney(%Gid, %Num)
{
	return  0;
}

//返回每级变异需求的精魄数量
function getAddvariationNeeditemcount(%curexe, %levelexe)
{
	return 1;
}

//神兽变异，精魄增加的经验，传进物品跟数量 获得增加的经验
function getItemAddvariation(%Gid, %Num)
{
	return 2 * %Num;
}

//***********神兽相关分割线******************************

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


//获得扣减装备的部位
function getRepairEquipPos(%type, %num)
{
	if (%type == 1)//武器
	{
		if (%num > 0 && %num < 61)
			return 11; //武器
		else if (%num > 60 && %num < 86)
			return 1; //头部
		else if (%num > 85 && %num <= 100)
			return 4; //肩部
	}
	else if (%type == 2) //装备
	{
		if (%num > 0 && %num < 13)
			return 3; //背
		else if (%num > 12 && %num < 43)
			return 5; //身体
		else if (%num > 42 && %num < 61)
			return 6; //手
		else if (%num > 60 && %num < 86)
			return 8; //脚
		else if (%num > 85 && %num <= 100)
			return 7; //腰
	}
}

//修理价格
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
//完美修理价格
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
//修理需要的道具
function getRepairItem()
{
	return 105109054;
}

//得到下级神水石的ID
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
//得到合成神水石的材料ID
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


//神器
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

function PetInsight_GetCostMoney(%nInsight)//传入当前灵慧
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

//灵兽炼化游戏币要求
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



//灵兽还童游戏币要求
function PetHuanTong_GetCostMoney(%nPetLevel)
{
	return 0;
}

//	Con::getIntArg(srcPet->insight)   //灵慧
//  Con::getIntArg(srcPet->level)    //等级
//	Con::getIntArg(srcPet->chengZhangLv) //成长率
//	Con::getIntArg(getPetSkillCount(slot)) //技能个数
//	Con::getIntArg(srcData->variationLevel)//变异等级
//	Con::getIntArg(maxGift)));             //资质
//  mfloor(%num) 最小取整 mceil(%num);最大取整 mround(%num)4舍5入取整
//  %AnimalEquip 神兽装备等级和
//灵兽合体计算
function getPetComboBuff(%insight, %level, %chengZhangLv, %SkillCount, %variationLevel, %maxGift, %AnimalEquip)
{
	if (%insight==1) %insight=1;  //灵慧强化
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

	if (%chengZhangLv==1)	%chengZhangLv=1;   //计算成长率
	else if (%chengZhangLv==2)	%chengZhangLv=3;
	else if (%chengZhangLv==3)	%chengZhangLv=6;
	else if (%chengZhangLv==4)	%chengZhangLv=10;
	else if (%chengZhangLv==5)	%chengZhangLv=15;
	else if (%chengZhangLv==6)	%chengZhangLv=21;
	else %chengZhangLv=0;

	%a = %level/10/2 + %insight/2/2 + %chengZhangLv/2/2 + %SkillCount*1.5/2; //赋值转接参数level，增提降低为原来的1/2
	%b = 350020101 + mround(%a);
	return %b;
}



//-----------------------------------------------------------------------------------------------
//                好友加油管理
//-----------------------------------------------------------------------------------------------
//加油奖励
function serverCheerResponse(%playerId, %destPlayerId)
{
	addPlayerHot(%playerId, 1);
	addFriendValue(%playerId, %destPlayerId, 1);
}
//游戏状态编号	游戏buff等级	状态说明

//字符串格式说明:buff编号,buff类型,buff等级
$cheerCaheBuff[0] = "39999 1 1";         //39999	1  	体魄提升100点
$cheerCaheBuff[1] = "39999 1 2";         //39999	2  	精气提升100点
$cheerCaheBuff[2] = "39999 1 3";         //39999	3  	力道提升100点
$cheerCaheBuff[3] = "39999 1 4";         //39999	4  	灵力提升100点
$cheerCaheBuff[4] = "39999 1 5";         //39999	5  	敏捷提升100点
$cheerCaheBuff[5] = "39999 1 6";         //39999	6  	元力提升100点
$cheerCaheBuff[6] = "39999 1 7";         //39999	7  	物理攻击提升100点
$cheerCaheBuff[7] = "39999 1 8";         //39999	8  	木灵攻击提升提升100点
$cheerCaheBuff[8] = "39999 1 9";         //39999	9  	火灵攻击提升提升100点
$cheerCaheBuff[9] = "39999 1 10";        //39999	10	土灵攻击提升提升100点
$cheerCaheBuff[10] = "39999 1 11";       //39999	11	金灵攻击提升提升100点
$cheerCaheBuff[11] = "39999 1 12";       //39999	12	水灵攻击提升提升100点
$cheerCaheBuff[12] = "39999 1 13";       //39999	13	元力攻击提升提升100点
$cheerCaheBuff[13] = "39999 1 14";       //39999	14	物理防御提升1000点
$cheerCaheBuff[14] = "39999 1 15";       //39999	15	木灵防御提升提升1000点
$cheerCaheBuff[15] = "39999 1 16";       //39999	16	火灵防御提升提升1000点
$cheerCaheBuff[16] = "39999 1 17";       //39999	17	土灵防御提升提升1000点
$cheerCaheBuff[17] = "39999 1 18";       //39999	18	金灵防御提升提升1000点
$cheerCaheBuff[18] = "39999 1 19";       //39999	19	水灵防御提升提升1000点
$cheerCaheBuff[19] = "39999 1 20";       //39999	20	元力防御提升提升1000点
$cheerCaheBuff[20] = "39999 1 21";       //39999	21	生命上限提升10%
$cheerCaheBuff[21] = "39999 1 22";       //39999	22	精气上限提升10%
$cheerCaheBuff[22] = "39999 1 23";       //39999	23	元气上限提升10%
$cheerCaheBuff[23] = "39999 1 24";       //39999	24	悟性上限提升100点
$cheerCaheBuff[24] = "39999 1 25";       //39999	25	坚韧上限提升100点
$cheerCaheBuff[25] = "39999 1 26";       //39999	26	治疗上限提升100点
$cheerCaheBuff[26] = "39999 1 27";       //39999	27	闪避上限提升100点
$cheerCaheBuff[27] = "39999 1 28";       //39999	28	暴击上限提升100点
$cheerCaheBuff[28] = "39999 1 29";       //39999	29	暴击倍数上限提升100%
$cheerCaheBuff[29] = "39999 1 30";       //39999	30	移动速度增加5%
$cheerCaheBuff[30] = "39999 1 31";       //39999	31	移动速度增加10%
$cheerCaheBuff[31] = "39999 1 32";       //39999	32	移动速度增加15%
//schedulebuff
$cheerCaheBuff[32] = "1016 0 0";       	 //1016	      杀怪双倍人物经验（60分钟）
$cheerCaheBuff[33] = "1017 0 0";         //1017	      杀怪双倍灵兽经验（60分钟）
$cheerCaheBuff[34] = "1018 0 0";         //1018	      杀怪双倍元神经验（60分钟）
$cheerCaheBuff[35] = "1019 0 0";         //1019	      怪物掉率提升（60分钟）【无效】
$cheerCaheBuff[36] = "1020 0 0";         //1020	      双倍师门任务经验（60分钟）
$cheerCaheBuff[37] = "1021 0 0";         //1021	      双倍云游任务经验（60分钟）
$cheerCaheBuff[38] = "1022 0 0";         //1022	      双倍伙计开跑灵元奖励（60分钟）
$cheerCaheBuff[39] = "1023 0 0";         //1023	      双倍千金兽灵元奖励（60分钟）
$cheerCaheBuff[40] = "1024 0 0";         //1024	      双倍降妖夺宝金钱奖励（60分钟）
$cheerCaheBuff[41] = "1025 0 0";         //1025	      1.5倍三界缉凶经验奖励（60分钟）

function sptCanEncourage(%player)
{
	if (%player == 0)
		return false;

	//卜卦冷却buff
	if (%player.isschbuff(1015))
		return false;

	//战斗类buff
	if (%player.getBuffCount(39999, 0) > 0)
		return false;

	//ScheduleBuff类buff
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
//zoneServer 代码
//随机一个buff
function randomCheerCaheBuff()
{
	%index = getRandom(41);
	return  $cheerCaheBuff[%index];
}


function getUpTrumpLevelExp(%level)
{
	return $TrumpLevelUp_Exp[%level+1];
}



//法宝炼制次数
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


//灵兽精炼公式
function PetLianHun_GetCostMoney(%PetLv)
{
	return 5000 * %PetLv + 10000 + (mFloor(%PetLv / 10) - 5) * 150000;
}



//装备增换洗相关脚本（新）


//得到换灵固定消耗元宝
function getLockSoulFixedGold(%level)
{
	if (%Level < 70)
		return 100;
	else if (%Level < 80)
		return 100;
	else
		return 100;
}


//返回锁灵不同等级装备需要消耗的元宝数量（单条消耗，多条消耗相乘）
function GetLockSoulMoney(%Level)
{
	if (%Level < 70)
		return 100;
	else if (%Level < 80)
		return 100;
	else
		return 100;
}




//得到增魂所需金钱
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


//得到增魂所需元宝
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





//得到洗魂所需金钱
function getChangeEveryProMoney(%num, %level)
{

	return %level*%level+%num*1000;

}



//■■■■■■■■■■■获取装备的发光品质颜色值■■■■■■■■■■■■■■■■■■■
// 获取武器发光，%type为武器等级，返回RGB颜色值,如：return "60 255 255";
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

// 获取装备品质发光，%val为装备品质，返回RGB颜色值,如：return "60 255 255";
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

//转生发光
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
// 法宝相关
// %LevelLimit 要炼制的法宝的等级
// %StarLevel  要炼制的法宝的星级
// 返回炼制法宝需要的金币数量
function GetStrengthenTrumpNeedBindMoney(%LevelLimit, %StarLevel)
{
	return 0;
	switch (%LevelLimit)
	{
		case 18:	return 5000*%StarLevel;					//20级法宝
		case 60:	return 8000*%StarLevel*1.5;			//60级法宝
		case 80:	return 15000*%StarLevel*3; 			//80级法宝
	}

}

//返回升级法宝的游戏币数量
function GetUpgradeTrumpNeedBindMoney(%LevelLimit, %StarLevel)
{
	switch (%LevelLimit)
	{
		case 18:	return 200000;		//20级法宝
		case 60:	return 500000;		//60级法宝
		case 80:	return 2000000; 	//80级法宝
	}
	return 200000;
}


//得到铭牌合成金钱的函数
function getComposeImpressKardMoney()
{
	return 100000;
}



//得到时装镶嵌金钱的函数

function getImpressFashionMoney()
{
	return 50000;
}


//获取转移游戏币消耗
function getTransferSoulMoney(%level, %color)
{
	return 0;
}





//■■■■■■■■■■■【强化】■■■■■【天灵玉合成】■■■■■■■■■■■■



//■■■■■■■■■■■【打造】■■■■■【装备增灵】■■■■■■■■■■■■■
//■■■■■■■■■■■【打造】■■■■■【装备增灵】■■■■■■■■■■■■■

//■■■■■■■■■■■【神器】■■■■■【神铁合成】■■■■■■■■■■■■■
//■■■■■■■■■■■【神器】■■■■■【神铁熔炼】■■■■■■■■■■■■■


//■■■■■■■■■■■【强化】■■■■■【天灵玉合成】■■■■■■■■■■■■
// 合成此种天灵石所需元宝数量
// %ItemID 要合成的天灵石的道具ID
function MoneyToComposeTianLingStone(%ItemID)
{
	switch (%ItemID)
	{
		case 116010003: return 300;
	}

	return 0;
}

// 合成此种天灵石所需金币数量
// %ItemID 要合成的天灵石的道具ID
function BindMoneyToComposeTianLingStone(%ItemID)
{
	switch (%ItemID)
	{
		case 116010002: return 6000;
	}

	return 0;
}
//■■■■■■■■■■■【强化】■■■■■【天灵玉合成】■■■■■■■■■■■■






//■■■■■■■■■■■【神器】■■■■■【神铁合成】■■■■■■■■■■■■■
//神铁合成需要的元宝数量
function YBToComposeShenTie()
{
	return 100;
}
//■■■■■■■■■■■【神器】■■■■■【神铁合成】■■■■■■■■■■■■■

//■■■■■■■■■■■【神器】■■■■■【神铁熔炼】■■■■■■■■■■■■■
//神铁熔炼需要的元宝数量
function YBToSplitShenTie()
{
	return 100;
}
//■■■■■■■■■■■【神器】■■■■■【神铁熔炼】■■■■■■■■■■■■■

//■■■■■■■■■■■侍卫加点返回值■■■■■■■■■■■■■■■■■■■
//生命
function MaxHP_MercenaryAdd(%ID)
{
	return (%ID.Stamina + %ID.strengthPoint) * 20;
}
//物理攻击
function PhyDamage_MercenaryAdd(%ID)
{
	return (%ID.Strength + %ID.phyAtkPoint) * 3;
}
//法术攻击
function MagicDamage_MercenaryAdd(%ID)
{
	return (%ID.Intellect + %ID.magicAtkPoint) * 3;
}
//物理防御
function PhyDefence_MercenaryAdd(%ID)
{
	return (%ID.Mana + %ID.phyDefPoint) * 21.2;
}
//法术防御
function MagicDefence_MercenaryAdd(%ID)
{
	return (%ID.Mana + %ID.phyDefPoint) * 21.2;
}
//身法
function CriticalRating_MercenaryAdd(%ID)
{
	return (%ID.Agility + %ID.agilityPoint) * 21.2;
}
//■■■■■■■■■■■侍卫加点返回值■■■■■■■■■■■■■■■■■■■

// 返回兑换星象需要的等级限制
function GetDuiHuanXXLevelLimit(%ItemID)
{
	return $XXDuiHuanConfigs[%ItemID].LevelLimit;
}

// 获取兑换此星象需要的碎片数量
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


// 添加兑换星象的配置
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

//设置武魂系统开放的等级
function LevelToOpenStarFunc()
{
	return 65;
}

//设置武魂系统开放的转生等级
function MetempsychosisToOpenStarFunc()
{
	return 0;
}


//激活星象要消耗的元宝数量
function PriceToActiveXXPack()
{
	return 1;
}

//获取星象宝袋的掉落包裹ID
function XXPackDropPackageID()
{
	return 56002120;
}

//星象宝袋最大充能次数
function XXPackMaxAddPowerNum()
{
	return 36;
}

//星象宝袋重置Timer的ID
function XXPackTimeSetID()
{
	return 3014;
}

// 星象宝袋充能价格(消耗元宝)
// %PackSNCurrDay 当天第N袋,从1开始计数
// %AddPowerSNCurrDay 当天第M次给第N袋充能,从1开始计数
function PriceToXXPackAddPower(%PackSNCurrDay, %AddPowerSNCurrDay)
{
	if (%PackSNCurrDay >= 2)
	{
		%PackSNCurrDay = 2;
	}
	return $XXPackConfigs[%PackSNCurrDay, %AddPowerSNCurrDay];
}

// %PackSNCurrDay 当天第N袋,从1开始计数
// %AddPowerSNCurrDay 当天第M次给第N袋充能,从1开始计数
function AddXXPackConfig(%PackSNCurrDay, %AddPowerSNCurrDay, %Price)
{
	$XXPackConfigs[%PackSNCurrDay, %AddPowerSNCurrDay] = %Price;
}

// 配置宝袋价格示范
AddXXPackConfig(1, 1, 0); // 当天第一次为第一个宝袋充能消耗的元宝数量
AddXXPackConfig(1, 2, 10); // 当天第二次为第一个宝袋充能消耗的元宝数量
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

AddXXPackConfig(2, 1, 500); // 当天第一次为第二个宝袋充能消耗的元宝数量
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




//装备封神时，封神石消耗
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


//时装合成消耗
function getComposeImpressKardGold()
{
	return 1000;
}


//神兵技能镶嵌
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


//1.getEatEquipValue(%equipPos,%equipLv,%pro)紫色装备等级对应增加的护甲或攻击值（需要传的参数：装备部位，装备等级，所属属性内容）
//2.getEatBuffID(%part,%value,%pro)某件装备增加的状态编号（需要传的参数：增加的数值【如158】,装备部位，所属属性内容）
//3.getValueLimit(%lv,%metempsychosis,%equipPos,%pro)不同等级、转生次数的玩家每天可以强化的上限（需要传的参数：玩家等级、转生次数）
//4.getNeedMoney（%level）金币消耗（根据消耗掉的装备等级）
//各等级装备增加的护甲或攻击值
//302420010物理护甲；302420110法术护甲 ；302420210物理攻击法术攻击； 302420410内力攻击
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

//返回状态编号
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

//不同转生等级的玩家可以吞噬的值上限（%gatherSoulLV封神等级）
function getValueLimit(%equipLv, %metempsychosis, %equipPos, %pro, %gatherSoulLV)
{
	return 0;
}

//吞噬游戏币消耗
function getNeedMoney(%level)
{
	return 0;
}

//********凝魂相关功能******
//凝魂金币消耗

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

//封神与装备宝石镶嵌的关系(装备等级,宝石等级,封神等级)
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

//返回神兽技能升级消耗积分
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


//■■■■■■■■■■■【十天嘉年华】相关■■■■■■■■■■■■■■■■■
//击败野外首领次数返回
function KillBossValue(%Player)
{
	%ItemCount = %Player.GetItemCount(105101770, 1);
	return %ItemCount;
}
//■■■■■■■■■■■【十天嘉年华】相关■■■■■■■■■■■■■■■■■



//■■■■■■■■■■■【玩家战斗力】相关■■■■■■■■■■■■■■■■■
//获得基础战斗力 转生等级 角色等级
function GetBaseEffectiveness(%ZsLevel, %Level)
{
	if (%Level <= 30)%DianS = mFloor(%Level / 15)*3;
	else if (%Level <= 60)%DianS = 6  + mFloor((%Level - 30)/10) * 4;
	else if (%Level >= 80)%DianS = 18 + mFloor((%Level - 60)/10) * 5;
	else if (%Level >= 100)%DianS = 28 + mFloor((%Level - 80)/5) * 5;
	else %DianS = 48 + mFloor((%Level - 100)/5) * 10;
	return %DianS+%Level;
}

//获得技能战斗力
function GetSkillEffectiveness(%SkillId, %SkillLevel)
{
	%DianS = %SkillLevel;
	return %DianS;
}

//获得宝石战斗力
function GetGemEffectiveness(%GemID)
{
	%GemLevel = GetItemData(%GemID, $Item_Data_Lv);//获得道具等级
	//echo("%GemLevel  ==  "@%GemLevel);
	%Streng = getItemBaseStats(%GemLevel+2)/10000;
	//echo("%Streng  ==  "@%Streng);
	%ability = (15 + %GemLevel*25)*%Streng;
	//echo("%ability  ==  "@%ability);
	return %ability;
}

//获得装备战斗力 装备ID 装备的9位主属性BUffID 强化等级 主动技能ID 被动技能ID 套装ID
function GetEquipEffectiveness(%EquipID, %ZhuShuxingID, %QiangHuaLv, %ZhuDongSkillID, %BeiDongSkillID, %SuitID)
{
	//echo("%EquipID  ====  "@%EquipID);
	//echo("%ZhuShuxingID  ====  "@%ZhuShuxingID);
	//echo("%QiangHuaLv  ====  "@%QiangHuaLv);
	//echo("%ZhuDongSkillID  ====  "@%ZhuDongSkillID);
	//echo("%BeiDongSkillID  ====  "@%BeiDongSkillID);
	//echo("%SuitID  ====  "@%SuitID);
	%EquipLevel = GetItemData(%EquipID, $Item_Data_Lv);//获得道具等级
	//echo("%EquipLevel  ====  "@%EquipLevel);
	%itemQuality = GetItemData(%EquipID, $Item_Data_Color);//获得道具颜色品质
	//echo("%itemQuality  ====  "@%itemQuality);
	%Streng = getItemBaseStats(%QiangHuaLv)/10000;//强化等级对应系数
	//echo("%Streng  ====  "@%Streng);
	%AttributeLV = %ZhuShuxingID % 100;//装备主属性等级
	//echo("%AttributeLV  ====  "@%AttributeLV);
	%Shenqi = 0;
	%zhudongSkill = 0;
	%BeiDongSkill = 0;
	%SuitID=0;
	if (CheckBit(GetItemData(%itemid, $Item_Data_Type), 15) == 1)	%Shenqi = 50;//判断是否为神器
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




//获得鉴定属性的战斗力 装备等级 该鉴定属性buffid 是否为专属（1为专 0为普通）
function GetIdentifyEffectiveness(%EquipLv, %Buffid, %isExclusiveBuff)
{
	//echo("%EquipLv  ====  "@%EquipLv);
	//echo("%Buffid  ====  "@%Buffid);
	//echo("%isExclusiveBuff  ====  "@%isExclusiveBuff);
	%isExclusive = 0.5;
	%ManZhi =0;
	%MaxNum = %EquipLv *1.5;//极限数值
	%BuffLv = %Buffid % 1000;//获取本鉴定属性的Buff等级
	if (%MaxNum == %BuffLv) %ManZhi =1;//满值
	if (%isExclusiveBuff==1)//专属
		%isExclusive = 1;
	%ZhanLi = %BuffLv * %isExclusive + %ManZhi *(%EquipLv/10)*(1+%isExclusiveBuff);
	//echo("%ZhanLi  ====  "@%ZhanLi);
	return %ZhanLi;
}

//获得附加属性的战斗力 装备等级 第X条附加属性
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

//获得时装战斗力
function GetFashionEffectiveness(%ItemID, %ZhuShuxingID)
{
	%ItemLevel = GetItemData(%ItemID, $Item_Data_Lv);//获得道具等级
	%itemQuality = GetItemData(%ItemId, $Item_Data_Color);//获得道具颜色品质
	%AttributeLV = %ZhuShuxingID % 100-17;
	if (%AttributeLV<0)%AttributeLV=0;//主属性末两位-17最小取0
	%Streng = getItemBaseStats(%QiangHuaLv)/10000;//强化等级对于系数
	%ability = (%ItemLevel+%AttributeLV+%itemQuality);
	return %ability;
}

//获得星宿战斗力
function GetStarEffectiveness(%YanSeLevel, %XinJiLevel)
{
	//颜色等级
	if (%YanSeLevel == 4)%DianS = 15 * 1;
	else if (%YanSeLevel == 5)%DianS = 15 * 2;
	else %DianS = 0;

	//星级
	%DianS = %DianS + %XinJiLevel;

	return 0;
}

//获得时装栏位战斗力
function GetFashionListEffectiveness(%LanWei)
{
	if (%LanWei <= 5)
		%DianS = 0;
	else
		%DianS = %LanWei - 5;

	return 0;
}


//获得经脉战斗力
function GetVenationEffectiveness(%Num)
{
	%DianS = %Num;
	return 0;
}

//获得武魂栏位战斗力
function GetFetchListEffectiveness(%LanWeiNum)
{
	if (%LanWeiNum <= 1)
		%DianS = 0;
	else
		%DianS = %LanWeiNum - 1;

	return 0;
}

//获得武魂等级战斗力
function GetFetchLevelEffectiveness(%WuHunLevel)
{
	%DianS = %WuHunLevel;

	return 0;
}

//获得武魂颜色战斗力
function GetFetchEffectiveness(%YanSeLevel)
{
	//颜色等级
	if (%YanSeLevel == 3)%DianS = 1;
	else if (%YanSeLevel == 4)%DianS = 2;
	else if (%YanSeLevel == 5)%DianS = 3;
	else if (%YanSeLevel == 6)%DianS = 4;
	else %DianS = 0;

	return 0;
}

//获得宠物战斗力
function GetPetEffectiveness(%ChengZhang, %Level, %Pingjie, %BianYi, %ZiZhi, %JiNeng)
{
	//宠物成长率
	if ((%ChengZhang >= 18) && (%ChengZhang < 840))%DianS = 1;
	else if ((%ChengZhang >= 840) && (%ChengZhang < 1560))%DianS = 2;
	else if ((%ChengZhang >= 1560) && (%ChengZhang < 2220))%DianS = 3;
	else if ((%ChengZhang >= 2220) && (%ChengZhang < 2860))%DianS = 5;
	else if ((%ChengZhang >= 2860) && (%ChengZhang < 3300))%DianS = 8;
	else if (%ChengZhang >= 3300)%DianS = 12;

	//宠物等级
	%DianS = %DianS + mfloor(%Level / 10);

	//宠物品阶
	%DianS = %DianS + %Pingjie;

	//宠物变异
	%DianS = %DianS + %BianYi - 1;

	//宠物资质
	%DianS = %DianS + %ZiZhi;

	//宠物技能
	%DianS = %DianS + %JiNeng;

	return 0;
}

//获得坐骑战斗力
function GetMountEffectiveness(%ShuDu)
{
	if (%ShuDu <= 4000) %DianS = 1;
	else if (%ShuDu <= 6000) %DianS = 2;
	else if (%ShuDu <= 7000) %DianS = 3;
	else if (%ShuDu <= 8000) %DianS = 4;
	else %DianS = 4;

	return 0;
}

//获得化神战斗力
function GetGodEffectiveness(%DataID, %Jingjie, %Level)
{
	//化神dataid
	if (%DataID <= 4) %DianS = 1;
	else if (%DataID <= 9) %DianS = 2;
	else if (%DataID <= 14) %DianS = 3;
	else if (%DataID <= 19) %DianS = 4;
	else if (%DataID <= 24) %DianS = 5;
	else if (%DataID <= 29) %DianS = 6;

	//化神境界
	%DianS = %DianS + %Jingjie;

	return 0;
}

//获得官职战斗力（搁置）
function GetOfficialTitleEffectiveness(%WuGuan, %WenGuan)
{
	return 0;
}

//获得VIP等级战斗力
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

//获得神将特权战斗力
function GetIsVipEffectiveness(%Vip1, %vip2)
{
	%DianS = (%Vip1 * 2) + (%Vip2 * 5);

	return 0;
}


//■■■■■■■■■■■【玩家战斗力】相关■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【聚宝盆】相关■■■■■■■■■■■■■■■■■■■
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

//获得聚宝盆每日最大次数
function GetGodNumForMaxCnt(%Player)
{
	return VIP_getNowTequanLvMaxCnt(%Player, 4)*1;
}
//■■■■■■■■■■■【聚宝盆】相关■■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【经脉】相关■■■■■■■■■■■■■■■■■■■■
//根据宝石返回当前战斗力
//根据宝石返回当前评分
//根据淬炼等级返回当前战斗力
//根据淬炼等级返回当前评分
//返回穴位开孔的颜色
//根据当前阶段跟消耗的物品ID返回增加淬炼的经验值
//根据当前经验返回我技能点数的最大值（当前经验角色本身应该有多少技能点）
//返回当前阶段最大经验值

//根据宝石返回当前战斗力
function GetVenationEffectivenessByGem(%gemlevel, %iscolor)
{
	//%gemlevel 宝石等级 %iscolor 是否是3色石 1：是    0：不是
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
//根据宝石返回当前评分
function GetVenationTopActivityByGem(%gemlevel, %iscolor)
{
	//%gemlevel 宝石等级 %iscolor 是否是3色石 1：是    0：不是
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

//根据淬炼等级返回当前战斗力
function GetVenationEffectivenessByLevel(%level)
{
	//%level淬炼等级
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

//根据淬炼等级返回当前评分
function GetVenationTopActivityByLevel(%level)
{
	//%level淬炼等级
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

//返回穴位开孔的颜色
function GetRandomPrintTrough(%slot, %count)
{
	//%slot,穴位位置		%count,散穴次数

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

//根据当前阶段跟消耗的物品ID返回增加淬炼的经验值
function GetRefinePrintPhaseAddExp(%phase, %itemid)
{
	//%phase,阶段		%itemid,物品ID

	%Random = GetRandom(1, 5);
	return %Random;
}

//根据当前经验返回我技能点数的最大值（当前经验角色本身应该有多少技能点）
function getRefinePrintSkillPoint(%exp)
{
	//%exp,当前经脉的经验

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

//返回当前阶段最大经验值
function getRefinePrintPhaseMaxExp(%phase)
{
	//%phase,当前阶段

	switch (%phase)
	{
		case 1: return 225;
		case 2: return 980;
		case 3: return 3500;
		case 4: return 66385;
	}

	return 71090;
}

//返回获得下一淬炼点所需经验
function GetCanGetPointToTalExp(%exp)
{
	//%exp,当前经验

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

	return "已升级至最高";
}

function JinMaiPointHoleColor(%slot, %count)
{
	//%slot,穴位		%count,散穴次数

	if (%slot == 1){ %JiLv = %Count * 10; }
	else if (%slot == 2){ %JiLv = %Count * 10; }
	else if (%slot == 3){ %JiLv = %Count * 10; }
	else if (%slot == 4){ %JiLv = %Count * 10; }
	else if (%slot == 5){ %JiLv = %Count * 10; }

	if (%JiLv > 100)
		return "100%";

	return %JiLv @ "%";
}

//■■■■■■■■■■■【星套强化】相关■■■■■■■■■■■■■■■■■■
//强化获得的状态
//强化获得的特效

//强化获得的状态
function AllEquipPerfectStrengthen_GetBuffID(%Level, %ItemNum)
{
	//%Level,强化等级		%ItemNum,装备数量

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

//强化获得的特效
function AllEquipPerfectStrengthen_GetEffectID(%Level, %ItemNum)
{
	//%Level,强化等级		%ItemNum,装备数量
	//echo("%ItemNum == " @ %ItemNum @ "  %Level==" @ %Level);
	if (%ItemNum < 9)return;
	switch (%Level)
	{
		case 3:%packet = 690794;//绿色光环 
		case 4:%packet = 690795;//蓝色光环 
		case 5:%packet = 690801;//紫色光环 
		case 6:%packet = 690797;//橙色光环 
		case 7:%packet = 690798;//红色光环 
		case 8:%packet = 690796;//粉色光环 
		case 9:%packet =  630201;//绿龙光环 
		case 10:%packet = 630202;//蓝龙光环 
		case 11:%packet = 630203;//紫龙光环 
		case 12:%packet = 630179;//橙龙光环 
		case 13:%packet = 630204;//红龙光环
		case 14:%packet = 630204;//红龙光环
		case 15:%packet = 630204;//红龙光环
		default:%packet = 0;
	}
	return %packet;
}

//■■■■■■■■■■■【星套强化】相关■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【三色石合成】相关■■■■■■■■■■■■■■■■■
//根据宝石等级获得合成的三色宝石id

//根据宝石等级获得合成的三色宝石id
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
//■■■■■■■■■■■【三色石合成】相关■■■■■■■■■■■■■■■■■




//■■■■■■■■■■■【宝石】相关■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【宝石】■■■■■【装备打孔】■■■
//■■■■■■■■■■■【宝石】■■■■■【摘取宝石】■■■
//■■■■■■■■■■■【宝石】■■■■■【宝石合成】■■■
//■■■■■■■■■■■【宝石】■■■■■【碎片合成】■■■
//■■■■■■■■■■■【宝石】■■■■■【宝石重铸】■■■
//■■■■■■■■■■■【宝石】■■■■■【宝石升级】■■■

//■■■■■■■■■■■【宝石】■■■■■【装备打孔】■■■
// 装备打孔金币消耗
function GetEquipPunchHoleCostBindMoney(%level, %openHoleNum, %allowNum)
{

	if (%openHoleNum >= %allowNum)
		return 0;
	%money = 100 * Mpow(1.02, %level) * (1+%openHoleNum / 6) * (1 + %allowNum /3);
	return %money;
}

//装备打孔材料编号返回
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

//装备打孔所需材料数量
function GetEquipPunchHoleCostItemNum(%equipLevel)
{
	if (%equipLevel>90) return 2;
	return 1;
}

//获取装备打孔元宝代替道具的元宝消耗
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

//装备打孔成功率（金币打孔消耗、道具与元宝打孔100%成功）
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
//■■■■■■■■■■■【宝石】■■■■■【装备打孔】■■■

//■■■■■■■■■■■【宝石】■■■■■【摘取宝石】■■■
//获取装备摘取宝石 宝石镶嵌需消耗的金币数量 宝石镶嵌不消耗金币
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
//■■■■■■■■■■■【宝石】■■■■■【摘取宝石】■■■

//■■■■■■■■■■■【宝石】■■■■■【宝石合成】■■■
//宝石合成所需材料ID
function GetGemComposeSymbolID(%level)
{
	if (%level == 1) return 105090411;
	else if (%level == 2) return 105090412;
	else if (%level == 3) return 105090413;
	else if (%level == 4) return 105090414;
	else if (%level == 5) return 105090415;
	return 105090416;
}

//获取宝石合成符数量 %level 放入宝石等级
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

//宝石合成宝石元宝代替合成卷消耗 // 升级后的等级
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

//宝石合成宝石金币消耗
function getGemComposeBaseRate(%itemID)
{
	%itemLevel = GetItemData(%itemID, $Item_Data_Lv);//获得道具等级
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

//获取宝石合成宝石数量对应概率
function getGemComposeSucceed(%playerid, %itemid, %itemNum)
{
	//echo( " %playerid ===" @  %playerid @ "    %itemid==" @  %itemid @ "     %itemNum==" @  %itemNum );
	if ($Now_Script == 2)
		%Player = SptGetPlayer(%playerid);
	else if ($Now_Script == 1)
		%Player = GetPlayer();

	%itemLevel = GetItemData(%itemid, $Item_Data_Lv);//获得道具等级
	%goodluck = %Player.getLuck();//获取玩家福缘值
	if (%goodluck <100)%goodluck = 0;
	switch (%itemNum)
	{
		case 2: %MaxSucceed = 4000; %MinSucceed = 3000; %ShowMaxSucceed = 5000;
		case 3: %MaxSucceed = 6000; %MinSucceed = 4500; %ShowMaxSucceed = 7000;
		case 4: %MaxSucceed = 8000; %MinSucceed = 6000; %ShowMaxSucceed = 9000;
		case 5: %MaxSucceed =10000; %MinSucceed =10000; %ShowMaxSucceed = 10000;
	}

	if ($Now_Script == 1)//客户端显示
	{
		%Result =mfloor(%MaxSucceed + (%goodluck / (500 * (1 + %itemLevel / 10))*(%ShowMaxSucceed - %MaxSucceed)));
		if (%Result > %ShowMaxSucceed) %Result = %ShowMaxSucceed;
	}
	else if ($Now_Script == 2)//服务端实际调用
	{
		%Result = mfloor(%MinSucceed + (%goodluck / (500 * (1 + %itemLevel / 10))*(%MaxSucceed - %MinSucceed)));
		if (%Result > %MaxSucceed) %Result = %MaxSucceed;
	}
	//echo( "宝石合成%Result=====" @ %Result );
	return %Result;
}

//■■■■■■■■■■■【宝石】■■■■■【宝石合成】■■■

//■■■■■■■■■■■【宝石】■■■■■【碎片合成】■■■
//获取碎片合成宝石需消耗的元宝数量 
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

//宝石碎片合成游戏币消耗
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

//宝石碎片合成所需道具-宝石合成卷
function getGemChipComposeMaterailID(%level)
{
	if (%level == 2) return 105090411;
	else if (%level == 3) return 105090412;
	else if (%level == 4) return 105090413;
	else if (%level == 5) return 105090414;
	return 105090416;
}

//【碎片合成】合成宝石所需材料-宝石合成卷的数量
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

//获得宝石碎片id
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

//获取合成需要宝石碎片的个数
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
//■■■■■■■■■■■【宝石】■■■■■【碎片合成】■■■


//■■■■■■■■■■■【宝石】■■■■■【宝石重铸】■■■


//宝石重铸显示数组，1玄兵宝石，2红宝石，3绿宝石，4蓝宝石

//蓝宝石                         		绿宝石                         		红宝石                         		//玄兵宝石															
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

//宝石重铸显示类型
function getGemRecastStoneId(%gemstoneId, %color)
{
	//玄冰宝石 1 红宝石 2 绿宝石 3 蓝宝石 4
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

//返回宝石重铸的重铸道具ID gemstoneId 宝石ID 0 重铸符ID 1 造化符ID 造化符没用到
function getGemRecastMaterialId(%gemstoneId, %type)
{
	%Gemlevel = GetItemData(%gemstoneId, $Item_Data_Lv);
	switch (%type)
	{
		case 0://重铸
			return 105105711 + (%Gemlevel - 1);
		case 1://造化符
			return 105029001 + (%Gemlevel - 1);
	}
}

//返回上面的宝石重铸道具消耗所需的道具数量 造化符 重铸符
function getGemRecastMaterialNum(%gemstoneId, %type)//对应数量
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

//宝石重铸元宝消耗 %gemstoneId 宝石ID %color勾选排除选项 %Isusegold是否消耗元宝代替重铸符(0 使用道具  1使用元宝)
function getGemRecastGoldNum(%gemstoneId, %colorbit, %Isusegold)
{
	//echo( "%gemstoneId ==" @ %gemstoneId @ "   %colorbit==" @ %colorbit @ "   %Isusegold ==" @ %Isusegold );
	%BaoShiLV = GetItemData(%gemstoneId, $Item_Data_Lv);
	switch (%BaoShiLV)//根据等级添加基础代替重铸石的消耗
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
	if (%Isusegold  == 1)//元宝代替重铸石消耗
	{
		%CzsMoney = %Money;
	}
	else
		%CzsMoney = 0;

	%lock1 = 0;
	%lock2 = 0;
	%lock3 = 0;
	%lock4 = 0;

	if (CheckBit(%colorbit, 1) == 1) //排除玄兵宝石
	{
		%lock1 = 1;
	}
	if (CheckBit(%colorbit, 2) == 1) //排除红宝石
	{
		%lock2 = 1;
	}
	if (CheckBit(%colorbit, 3) == 1) //排除绿宝石
	{
		%lock3 = 1;
	}
	if (CheckBit(%colorbit, 4) == 1) //排除蓝宝石
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

//宝石重铸返回产物结果，getGemRecastStoneResultID(角色id,宝石id,bit位排除宝石类型，造化符id若无则为0);
function getGemRecastStoneResultID(%playerid, %gemstoneId, %colorbit, %MaterialsID)
{
	%Player = SptGetPlayer(%playerid);
	%addgailv = GetItemData(%MaterialsID, 17);//获得辅助道具备用字段填写值
	%BaoShiLV = GetItemData(%gemstoneId, $Item_Data_Lv);
	//echo( "%BaoShiLV==" @ %BaoShiLV );
	//echo( "%colorbit===" @ %colorbit );
	//echo("%gemstoneId===" @ %gemstoneId);
	//echo("%MaterialsID===" @ %MaterialsID);
	//-------------------造化符流程----------------------
	%Random = GetRandom(1, 10000);
	//echo( "%Ran==" @ %Ran );
	//echo( "%Random==" @ %Random );
	if (%Random <= %addgailv && %BaoShiLV < 10)
	{
		%BaoShiLV++;
		%MsgType =4;
	}

	//-------------------重铸流程------------------------
	//echo( "%colorbit==" @ %colorbit );
	%AllNumber = 0;
	for (%i = 1; %i <= 4; %i++)
	{
		if (CheckBit(%colorbit, %i) == 0)
		{
			%AllNumber = $RecordGemRecastStoneTypeAllNumber[%i] + %AllNumber;//随机值的区间计算
			%ColorCheck[%i] = 1;//标记此类宝石加入随机序列
		}
		else
			%ColorCheck[%i] = 0;//标记此类宝石不加入随机序列
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
					%Msg2 ="<t>好运爆棚，</t>" @ %Playername2 @ "<t>在宝石重铸时，获得了</t>" @ %ItemName2 @ "<t>，羡煞了众人。</t>";
					SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg2 @ "</t>", $chatMsg_Type_Normal2);
				}
			case 3:
				%Playername1 = GetPlayerZiTiName(%Player, 1);
				%Playername2 = GetPlayerZiTiName(%Player, 2);
				%ItemName1 = GetItemName(%ItemID, 1);
				%ItemName2 = GetItemName(%ItemID, 2);
				%Msg1 ="<t>好运爆棚，</t>" @ %Playername1 @ "<t>在宝石重铸时，获得了</t>" @ %ItemName1 @ "<t>，羡煞了众人。</t>";
				%Msg2 ="<t>好运爆棚，</t>" @ %Playername2 @ "<t>在在宝石重铸时，获得了</t>" @ %ItemName2 @ "<t>，羡煞了众人。</t>";
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
				%Msg2 ="<t>福星高照，</t>" @ %Playername2 @ "<t>在宝石重铸时，加入</t>" @ %ItemName3 @ "<t>成功将宝石提升至</t>" @ %Lv @ "<t>级，获得了</t>" @ %ItemName;
				%Msg3 ="<t>好运爆棚，</t>" @ %Playername3 @ "<t>在宝石重铸时，加入</t>" @ %ItemName4 @ "<t>成功将宝石提升一级，获得了</t>" @ %Lv @ "<t>级</t>" @ %ItemName2;
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

//■■■■■■■■■■■【宝石】■■■■■【宝石重铸】■■■


//■■■■■■■■■■■【宝石】■■■■■【宝石升级】■■■
//宝石升级返回消耗卷轴ID 优先返回低级的
function getGemPromoteMaterialId(%Player, %gemstoneId)//废弃
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

//宝石升级 卷轴所需数量
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

//返回宝石升级结果 宝石ID 辅助道具ID
function getGemPromoteResultID(%playerid, %gemstoneId, %UseItemID)
{
	//echo( %gemstoneId @ "   " @ GetItemData( %gemstoneId, 1 ) );
	//echo( %UseItemID @ "   " @ GetItemData( %UseItemID, 1 ) );
	%GaiLv = GetItemData(%UseItemID, 17);//获取辅助道具的概率
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
				%Msg2 ="<t>好运天降</t>" @ %Playername2 @ "<t>宝石升级成功，获得了</t>" @ %ItemName;
				%Msg3 ="<t>好运天降</t>" @ %Playername3 @ "<t>宝石升级成功，获得了</t>" @ %ItemName2;
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

//宝石升级金币消耗
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
//■■■■■■■■■■■【宝石】■■■■■【宝石升级】■■■


//////////// 摘取镶嵌宝石材料相关函数 ///////////////////////////////////////////
function AddEquipGemUnmountConfig(%GemLevel, %MaterialId, %MaterialNum)
{
	%EquipGemUnmountObjectID = "EquipGemUnmountObjectID_" @ %GemLevel;
	new ScriptObject(%EquipGemUnmountObjectID)
	{
		materialid 		= %MaterialId;		// 材料ID
		materialnum 	= %MaterialNum;		// 格料数量
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
////////////////////装备镶嵌宝石颜色及所属系别////////////////////////////////
function GemIsColorMatch(%type, %color)
{
	if (%type == 1)					//红色系:	红色、黄色、紫色
	{
		switch (%color)
		{
			case 1001:	return 1;		//红色
			case 1004:	return 1;		//黄色
			case 1006:	return 1; 	//紫色
		}
	}
	else if (%type == 2)		//绿色系:	绿色、青色、黄色
	{
		switch (%color)
		{
			case 1002:	return 1;		//绿色
			case 1005:	return 1;		//青色
			case 1004:	return 1; 	//黄色
		}
	}
	else if (%type == 3)		//蓝色系: 蓝色、紫色、青色
	{
		switch (%color)
		{
			case 1003:	return 1;		//蓝色
			case 1006:	return 1;		//紫色
			case 1005:	return 1; 	//青色
		}
	}
	return 0;
}

//获取可以合成最高宝石等级
function getOpenGemLevel()
{
	return 4;
}

//宝石通灵符ID
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

//获取合成宝石需求的宝石数量
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

//获取通灵成功几率1000为底，暂时只开放到3级通灵

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
//■■■■■■■■■■■【宝石】相关■■■■■■■■■■■■■■■■■■■■



$GetDeathDropArray[1, 0] = "20 1 1";//装备掉率 最小件数 最大件数
$GetDeathDropArray[1, 1] = "100 1 1";//装备掉率 最小件数 最大件数
$GetDeathDropArray[1, 2] = "143 1 1";//装备掉率 最小件数 最大件数
$GetDeathDropArray[1, 3] = "133 1 2";//装备掉率 最小件数 最大件数
$GetDeathDropArray[1, 4] = "167 1 2";//装备掉率 最小件数 最大件数
$GetDeathDropArray[1, 5] = "190 1 2";//装备掉率 最小件数 最大件数
$GetDeathDropArray[1, 6] = "400 2 3";//装备掉率 最小件数 最大件数
$GetDeathDropArray[1, 11] = "1111 2 4";//装备掉率 最小件数 最大件数
$GetDeathDropArray[1, 21] = "2857 3 4";//装备掉率 最小件数 最大件数
$GetDeathDropArray[1, 51] = "5000 3 5";//装备掉率 最小件数 最大件数
$GetDeathDropArray[1, 101] = "8500 4 5";//装备掉率 最小件数 最大件数
$GetDeathDropArray[1, 201] = "10000 4 6";//装备掉率 最小件数 最大件数
$GetDeathDropArray[1, 301] = "10000 5 6";//装备掉率 最小件数 最大件数
$GetDeathDropArray[1, 501] = "10000 5 7";//装备掉率 最小件数 最大件数

$GetDeathDropArray[2, 0] = "143 1 1";//背包道具掉率 最小件数 最大件数
$GetDeathDropArray[2, 1] = "148 1 2";//背包道具掉率 最小件数 最大件数
$GetDeathDropArray[2, 2] = "167 1 2";//背包道具掉率 最小件数 最大件数
$GetDeathDropArray[2, 3] = "143 1 3";//背包道具掉率 最小件数 最大件数
$GetDeathDropArray[2, 4] = "167 1 3";//背包道具掉率 最小件数 最大件数
$GetDeathDropArray[2, 5] = "250 1 3";//背包道具掉率 最小件数 最大件数
$GetDeathDropArray[2, 6] = "500 2 3";//背包道具掉率 最小件数 最大件数
$GetDeathDropArray[2, 11] = "1667 2 4";//背包道具掉率 最小件数 最大件数
$GetDeathDropArray[2, 21] = "3571 3 4";//背包道具掉率 最小件数 最大件数
$GetDeathDropArray[2, 51] = "8000 3 5";//背包道具掉率 最小件数 最大件数
$GetDeathDropArray[2, 101] = "10000 4 5";//背包道具掉率 最小件数 最大件数
$GetDeathDropArray[2, 201] = "10000 4 6";//背包道具掉率 最小件数 最大件数
$GetDeathDropArray[2, 301] = "10000 5 6";//背包道具掉率 最小件数 最大件数
$GetDeathDropArray[2, 501] = "10000 5 7";//背包道具掉率 最小件数 最大件数

$GetDeathDropArray[3, 0] = "333 1 2";//背包金钱掉率 最小件数 最大件数
$GetDeathDropArray[3, 1] = "800 2 3";//背包金钱掉率 最小件数 最大件数
$GetDeathDropArray[3, 2] = "1111 2 4";//背包金钱掉率 最小件数 最大件数
$GetDeathDropArray[3, 3] = "1667 2 4";//背包金钱掉率 最小件数 最大件数
$GetDeathDropArray[3, 4] = "3333 2 4";//背包金钱掉率 最小件数 最大件数
$GetDeathDropArray[3, 5] = "4167 2 4";//背包金钱掉率 最小件数 最大件数
$GetDeathDropArray[3, 6] = "5000 3 5";//背包金钱掉率 最小件数 最大件数
$GetDeathDropArray[3, 11] = "7000 3 6";//背包金钱掉率 最小件数 最大件数
$GetDeathDropArray[3, 21] = "9000 4 6";//背包金钱掉率 最小件数 最大件数
$GetDeathDropArray[3, 51] = "10000 4 7";//背包金钱掉率 最小件数 最大件数
$GetDeathDropArray[3, 101] = "10000 5 7";//背包金钱掉率 最小件数 最大件数
$GetDeathDropArray[3, 201] = "10000 5 8";//背包金钱掉率 最小件数 最大件数
$GetDeathDropArray[3, 301] = "10000 6 8";//背包金钱掉率 最小件数 最大件数
$GetDeathDropArray[3, 501] = "10000 6 8";//背包金钱掉率 最小件数 最大件数
//■■■■■■■■■■■【角色死亡损失】相关■■■■■■■■■■■■■■■■
/*角色死亡损失脚本 角色对象 等级 善恶值
type=1 身上装备的概率10000万分制+件数99上限
type=2 背包道具的概率10000万分制+件数99上限
type=3 背包金币的概率10000万分制+件数99上限
type=4 死亡损失获取金币损失最小值
type=5 死亡损失获取金币损失最大值*/
function GetDeathDropRate(%Player, %level, %pkVal, %type)
{
	//echo("%Player  ======  "@%Player);
	//echo("%角色等级  ======  "@%level);
	//echo("%善恶值  ======  "@%pkVal);
	//echo( "%类型  ======  "@%type );
	%Curse = 0;
	%Curse = %Player.getCurseNumber();//获取死亡者的诅咒值
	//echo("%诅咒值  ======  "@%Curse);
	if (%Curse > 20) %Curse = 20;
	if (%Curse < -20)%Curse = -20;
	//echo("%诅咒值  ======  "@%Curse);

	%ZuZouShuaiJian = 1;
	if (%pkVal == 0) %ZuZouShuaiJian = 3;//自身红白名状态缩放诅咒效果
	switch (%type)
	{
		case 1: %CurseRate = 1/3; %JiChuGaiLv = 60; //对身上装备3点诅咒=1点善恶 每点善恶值增加的基础概率
		case 2: %CurseRate = 1/2; %JiChuGaiLv = 150;//对背包道具2点诅咒=1点善恶 每点善恶值增加的基础概率
		case 3: %CurseRate = 1/1; %JiChuGaiLv = 200;//对背包金币1点诅咒=1点善恶 每点善恶值增加的基础概率
		default: %CurseRate = 1/1; %JiChuGaiLv = 200;//对背包金币1点诅咒=1点善恶 每点善恶值增加的基础概率
	}
	%XiuZhengpkVal =  mceil(%pkVal + %Curse * %CurseRate / %ZuZouShuaiJian);//修正生效善恶值影响 当前善恶值+诅咒*效果*红白名缩放效果
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
	%NowGaiLv = $GetDeathDropArray[%type1, %Val];//得到本阶段的善恶基础损失概率 与 件数的数组
	//echo("%损失概率 与 件数的数组  ======  "@%NowGaiLv);
	%GaiLv = GetWord(%NowGaiLv, 0);//损失概率
	//echo("%损失概率  ======  "@%GaiLv);
	%MinCount = GetWord(%NowGaiLv, 1);//最小损失件数
	%MaxCount = GetWord(%NowGaiLv, 2);//最大损失件数
	//echo("%最小损失件数  ======  "@%MinCount);
	//echo("%最大损失件数  ======  "@%MaxCount);
	%LastCount = GetRandom(%MinCount, %MaxCount);//随机出损失件数
	//echo("%随机出损失件数  ======  "@%LastCount);
	if (%type == 4) %LastCount =%MinCount;//用于计算金币的损失数量的
	else if (%type == 5) %LastCount =%MaxCount;//用于计算金币的损失数量的

	%LastRate = (%XiuZhengpkVal - %Val)* %JiChuGaiLv+ %GaiLv;
	if (%LastRate > 10000) %LastRate =10000;
	%result = %LastRate *100 + %LastCount;
	//echo( "%result  ==  "@%result );
	return %result;
}

//type = 1 = 物品代替元宝修复时物品ID    type = 2 = 物品代替元宝修复对应的消耗物品数量   type = 3 = 元宝修复 所消耗的元宝数量   type = 4 = 修复后给至损着元宝数量
//%itemid = 破损的物品道具ID   %quality 破损的物品装备评分
function getRepairEquipCost(%type, %itemid, %quality)
{
	echo("%type  ==  "@%type);
	echo("%itemid  ==  "@%itemid);
	echo("%quality  ==  "@%quality);
	if(%type == 1) return 105109064;
	if(%quality < 2000)
		%ItemCountNum = Mfloor(%quality /1000)+1;
	else if(%quality >=2000) %ItemCountNum = Mfloor(%quality /1000)+1 + Mfloor((%quality-2000)/500 +1);//（2000战力品质之下的道具修复价格为：每1000战力 消耗1个金汁玉髓。不足1000按1000算，超过2000在额外每500增加1个道具消耗，不足500按500计算）
	if(%type == 2) return %ItemCountNum;
	if(%type == 3) return %ItemCountNum * 1000;
	else  return Mfloor(%ItemCountNum * 1000 *0.25);//修复后至损者可获得25%元宝
}
//死亡损失获取金币损失最小值
function GetDropMoneyMin(%Player, %level, %pkVal)//（（角色等级 - 28 ）*24*当前善恶值最小损失数量/2)		
{
	//echo( "Player  ==  "@%Player );
	//echo( "level  ==  "@%level );
	//echo( "pkVal  ==  "@%pkVal );
	%DropMoney = GetDeathDropRate(%Player, %level, %pkVal, "4");
	%NowMinCount = %DropMoney %100;
	%MinMoney = mceil((%level - 28) * 24 * %NowMinCount /2);
	//echo("%最小金钱损失概率与次数  ==  "@%DropMoney);
	//echo("%最小掉落次数  ==  "@%NowMinCount);
	//echo("%损失最小金钱  ==  "@%MinMoney);
	return %MinMoney;
}

//死亡损失获取金币损失最大值
function GetDropMoneyMax(%Player, %level, %pkVal)//（（角色等级 - 28 ）*72*当前善恶值最大损失数量/2)									
{
	//echo( "Player  ==  "@%Player );
	//echo( "level  ==  "@%level );
	//echo( "pkVal  ==  "@%pkVal );
	%DropMoney = GetDeathDropRate(%Player, %level, %pkVal, "5");
	%NowMaxCount = %DropMoney %100;
	%MaxMoney = mceil((%level - 28) * 72 * %NowMaxCount /2);
	//echo( "%最大金钱损失概率与次数  ==  "@%DropMoney );
	//echo( "%最大掉落次数  ==  "@%NowMaxCount );
	//echo( "%损失最大金钱  ==  "@%MaxMoney );
	return %MaxMoney;
}

//死亡损失金币不足时扣除当前装备耐久值 返回值计算公式为下
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
	putout("扣当前耐久  ==  "@%KouNaiJiu);

	if (%KouNaiJiu < 33) %KouNaiJiu=33;
	putout("扣当前耐久  ==  "@%KouNaiJiu);
	return %KouNaiJiu;
}


//死亡损失金币不足时，扣除装备最大耐久值
function GetDeductEquipWearValue(%Player, %level, %pkVal)
{
	//echo( "Player  ==  "@%Player );
	//echo( "level  ==  "@%level );
	//echo( "pkVal  ==  "@%pkVal );
	%MaxMoney = GetDropMoneyMax(%Player, %level, %pkVal);
	//echo( "22222  ==  "@%MaxMoney );
	%KouNaiJiu = mceil((%MaxMoney+1000) / 62);
	//echo( "扣最大耐久  ==  "@%KouNaiJiu );

	if (%KouNaiJiu < 11) %KouNaiJiu=11;
	//echo( "扣最大耐久  ==  "@%KouNaiJiu );
	return %KouNaiJiu;
}

//■■■■■■■■■■■【角色死亡损失】相关■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【装备】相关■■■■■■■■■■■■■■■■■■■■

//■■■■■【获取主属性】■■■
//■■■■■【获取强化附加】■■

//装备升级符
function getTransSoulMaterial()
{
	return 105090409;
}

//■■■■■【获取主属性】■■■
//CalcEquipAttributeID(getplayer(),102054008,1);
function CalcEquipAttributeID(%playerid, %itemid, %type)//装备主属性获取函数 角色id，物品id，操作类型（type=0系统生成，type=1玩家操作）
{
	//echo("%type  ==  "@%type);
	%itemSubType = GetItemData(%ItemId, 3);//获得道具子类
	//echo( "%itemSubType  ==  "@%itemSubType );

	%itemClass = GetItemData(%ItemId, 113);//获得道具职业限制
	%itemchengzhanglv = GetItemData(%ItemId, 22);//获得道具的成长率
	//echo("%itemchengzhanglv  ==  "@%itemchengzhanglv);
	//if ( %itemSubType == 210 ) return 350010001;//本buff为专属不显示的特殊buff与程序约定

	%itemQuality = GetItemData(%ItemId, $Item_Data_Color);//获得道具颜色品质
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//获得道具等级
	%Player = SptGetPlayer(%playerid);
	%Shenqi = 0;
	%luckforitem = 0;//获取玩家福缘值
	if (CheckBit(GetItemData(%itemid, $Item_Data_Type), 15) == 1) %Shenqi = 5000;//判断是否为神器

	%itemType = mfloor(%itemSubType/100)*10+ %itemSubType%10;//道具类别

	%equipLevel = mceil(%itemLevel/10);//装备等级
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
		else if (%type == 2)//为商店购买
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

//■■■■■【获取强化附加】■■
function CalcEquipStrengAddBuff(%playerid, %itemid, %type)//%player = 角色id %itemid = 装备id,%type = {012345 ；强化等级1 buff1  强化等级2 buff2 强化等级3 buff3}
{
	%itemQuality = GetItemData(%ItemId, $Item_Data_Color);//获得道具颜色品质
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//获得道具等级
	%itemSubType = GetItemData(%ItemId, 3);//获得道具子类
	//echo("%itemSubType  ==  "@%itemSubType);
	%Player = SptGetPlayer(%playerid);
	%luckforitem = 0;
	%luckforitem = %Player.getLuck();//获取玩家福缘值
	if (%itemSubType >=400 || %itemSubType ==210)
		return 0;

	if (%itemLevel < 30) return 0;//30级以下装备不出附加属性
	if (%itemQuality <= 2) //白色品质直接返回0
		return 0;
	else if (%itemQuality <= 3 && %type >1)//绿色品质 只允许出现1条强化附加
		return 0;
	else if (%itemQuality <= 4 && %type >3)//蓝色品质值允许出2条强化附加
		return 0;
	else if (%itemQuality <= 5 && %type >3 && %itemLevel < 60)//紫色60以下允许出2条强化附加
		return 0;

	if (%type == 0 || %type == 2 || %type == 4)//返回第N条所需强化等级条件
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

		if (GetRandom(1, 1000) > %typeprobability)//概率决定是否会有强化附加属性
			return 0;
		%LevelAdjust = 0;
		if (%itemLevel < 60) %LevelAdjust = 1;//60级以下装备 降低一级需求等级
		%RandomScope = GetRandom(0, 400);//随机出第N条属性激活所需强化等级
		if (%RandomScope < 100 + %itemLevel)
			return %MinNeedLevel - %LevelAdjust + 2;
		else if (%RandomScope > 200 + %itemLevel)
			return %MinNeedLevel - %LevelAdjust + 1;
		else
			return %MinNeedLevel - %LevelAdjust;
	}
	else if (%type == 1 || %type == 3 || %type == 5)//返回第N条附加属性的Buff
	{
		switch (%type)
		{
			case 1:
				%MaxScope = 35915;
				%typeNum = 1;//第N条buff对应的等级
			case 3:
				%MaxScope = 35921;
				%typeNum = 2;//第N条buff对应的等级
			case 5:
				%MaxScope = 35938;
				%typeNum = 3;//第N条buff对应的等级
		}
		if (%itemSubType < 200) %MaxScope = 35938;//只允许武器出现幸运属性的强化附加
		%BuffId = GetRandom(35901, %MaxScope);
		%lastbuffLevel = mround((%itemLevel % 10)/3)*3;//计算出buff等级最后一位的等级
		%buffLevel = %type * 1000 + mfloor(%itemLevel / 10)*10 +%lastbuffLevel;//计算出完整的buff等级
		%ItemBuff = %BuffID * 10000 + %buffLevel;
		return %ItemBuff;
	}
	return 0;
}


//得到装备强化收益，程序根据这个值*装备属性 /10000
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

//得到本次装备强化的概率itemid 装备ID  level 装备等级 strengthlv当前强化等级 playerid角色id
function GetStrengThenRate(%itemid, %level, %strengthlv, %matrialid, %playerid)
{
	if (%matrialid == 0) %addgailv = 0;
	else
		%addgailv = GetItemData(%matrialid, 17);//获得辅助道具备用字段填写值
	%Player = SptGetPlayer(%playerid);
	%luckforitem = 0;
	%luckforitem = %Player.getLuck();//获取玩家福缘值
	%luckadd = %luckforitem / 1000 * 500;
	%misfortune = 0;
	%misfortune = %Player.getLuck();//获取玩家厄运值
	if (%level < 60)//60级以下强化概率略微高于60以上
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

//装备可强化到的最大等级 
function MaxStrengthensLevel(%itemid)
{
	return 15;
	//%itemLevel = GetItemData( %ItemId, $Item_Data_Lv );//获得道具等级
	//if ( %itemLevel < 60 )
	//	return 10;
	//else if ( %itemLevel < 80 )
	//	return 13;
	//else if ( %itemLevel < 100 )
	//	return 15;
	//else
	//	return 20;
}

//得到装备强化附加状态编号的函数 装备类型  职业 强化等级
function getItemAddtionStats(%ItemId, %times)
{
	%itemSubType = GetItemData(%ItemId, 3);//获得道具子类
	%job =  GetItemData(%ItemId, 113);//获得道具职业限制
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


// 计算装备强化所需消耗价格(type = 0 金币消耗  1 元宝消耗)
function CalcEquipStrengthenPrice(%playerid, %itemid, %times, %type)
{
	%itemType = GetItemData(%itemid, 2);//获得道具类型
	%itemQuality = GetItemData(%itemid, $Item_Data_Color);//获得道具颜色品质
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//获得道具等级
	switch (%itemType)
	{
		case 1: %part = 1.2;
		case 2: %part = 0.6;
		case 3: %part = 0.9;
		default: %part = 1;
	}
	//Gold=颜色品质（值）*装备部位（值）*2*1.06等级限制*2强化次数

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

	if (%type == 0)//金币消耗
		return %NeedJinBi;
	else
		return %NeedYuanBao;
}

// 获取装备强化配置项 EquipitemID本次所需强化的装备ID times = 当前强化等级+1； %valueType 0 = 强化消耗物品ID， 1 = 强化消耗物品数量
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
		materialid 		= %materialid;		// 材料ID
		materialnum 	= %materialnum;		// 材料数量
		ShowQuality   = %ShowQuality;   // 本值*强化等级 + 宝石 鉴定属性等其他系数 决定show出装备的品质等
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


//获取装备强化、鉴定属性转移元宝消耗 %consumeEquipID 消耗的装备ID ，%retainEquipID 保留的装备ID， %Strengs 强化等级， %IdentifyNum 鉴定属性条目
function  YBToTransferSoul(%consumeEquipID, %retainEquip, %Strengs, %IdentifyNum)
{
	%consumeEquipLv = GetItemData(%consumeEquipID, $Item_Data_Lv);//获得道具等级
	%retainEquipLv  = GetItemData(%retainEquip, $Item_Data_Lv);//获得道具等级
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

//■■■■■■■■■■■【装备—鉴定】相关■■■■■■■■■■■■■■■■■
//装备增灵上限条目 传入装备ID
function GetMaxAddIdentifyNumber(%itemid)
{
	%itemQuality = GetItemData(%itemid, $Item_Data_Color);//获得道具颜色品质
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//获得道具等级
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

//获取装备增灵的成功率（传 角色ID 装备ID 辅助材料ID  本次曾灵为第N条）  如辅助材料为空则传0鉴定成功率
function GetAddProNumSuceessRate(%playerid, %ItemId, %materialid, %Times)
{
	%itemQuality = GetItemData(%itemid, $Item_Data_Color);//获得道具颜色品质
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//获得道具等级
	if (%materialid != 0)
		%addSuceessrate = GetItemData(%materialid, 17);//获取辅助道具增加的成功率
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


//增灵所需金币消耗（%playerid, 传装备ID  本次曾灵为第N条）
function GetAddProNumMoney(%playerid, %ItemId, %Times)
{
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//获得道具等级
	%Maxtiaomu = GetMaxAddIdentifyNumber(%ItemId);//获得本件装备可鉴定的上限条目
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

//(%level装备等级)获取鉴定属性状态后4位值大小返回的是一个根据等级区间随机值 角色ID 装备ID 当前鉴定的第N条 type =1 为增灵 与换灵  type=2为洗灵 
function GetIdentifyQuality(%Playerid, %itemid, %Num, %type)
{
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//获得道具等级
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

//换灵所需道具ID（传装备ID，总共已有鉴定属性条目，换灵锁住条目）
function getChangeIdentifyProItem(%playerid, %ItemId, %MaxTiaoMu, %LockTiaoMu)
{
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//获得道具等级
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


//换灵所需道具数量 元宝代替道具消耗时元宝的需求数量（%playerid,传装备ID，总共已有鉴定属性条目，换灵锁住条目 本次操作元宝还是消耗道具1  元宝代替道具2）
function getChangeIdentifyProNum(%playerid, %ItemId, %Maxtiaomu, %LockTiaoMu, %type)
{
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//获得道具等级
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

//重铸所需金钱（%playerid,装备ID，总共已有鉴定属性条目，换灵锁住条目 本次操作元宝还是消耗道具1  元宝代替道具2）
function getChangeIdentifyProMoney(%playerid, %ItemId, %Maxtiaomu, %LockTiaoMu, %type)
{
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//获得道具等级
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

//洗灵所需道具ID（传装备ID，总共已有鉴定属性条目，洗灵锁住条目）
function getLockSoulFixedMaterialNeedItem(%playerid, %ItemId, %Maxtiaomu, %LockTiaoMu)
{
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//获得道具等级
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

//洗灵所需道具消耗数量 与 元宝代替道具消耗时元宝的需求数量（%playerid,传装备ID，总共已有鉴定属性条目，换灵锁住条目 本次操作元宝还是消耗道具1  元宝代替道具2）
function getLockSoulFixedMaterialNeedNum(%playerid, %ItemId, %Maxtiaomu, %LockTiaoMu, %type)
{
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//获得道具等级
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

//洗灵所需金币消耗（%playerid,传装备ID，总共已有鉴定属性条目，换灵锁住条目 本次操作元宝还是消耗道具1  元宝代替道具2）
function getLockSoulFixedMaterialMoney(%playerid, %ItemId, %Maxtiaomu, %LockTiaoMu, %type)
{
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//获得道具等级
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

//重铸换灵出现专属的概率  角色id ，当前第X条0—9
function GetIdentifyExclusive(%playerid, %times)
{
	if (%times < 5)
		return 0;
	//echo("%角色id  ===  "@%playerid);
	//echo("%当前是第X条  ===  "@%times);
	%Exclusive = 0;
	%Player = SptGetPlayer(%playerid);
	%goodluck = %Player.getLuck();//获取玩家福缘值
	//echo("%幸运值  ===  "@%goodluck);
	%val = 0;
	if (%goodluck <300)
		%val = 300;//300点以下福缘不起效
	//echo("%val  ===  "@%val);
	else %val = 300 - (%goodluck - 100) /2;
	//echo("%val1  ===  "@%val);
	%val = Getmin(200, %val);
	//echo("%val2  ===  "@%val);

	%val = Getmin(300, %val);
	//echo("%va3  ===  "@%val);
	%GaiLV = (5000 - %times * %val);
	//echo("%概率  ===  "@%GaiLV);
	%SuijiShu = GetRandom(1, 10000);
	//echo("%随机数  ===  "@%SuijiShu);

	if (%GaiLV > %SuijiShu)
		%Exclusive =1;
	//echo("%是否出专？  ===  "@%Exclusive);

	return %Exclusive;
}

//【装备换灵】免费次数返回
function getFreeLockChangeTimes(%Player)
{
	//如果不在活动时间内
	if (GetStartTime("KaiFuHuoDong") > 0)
		return 0;

	//如果已经领取
	if (GetWord(%Player.GetActivity(2254), 0) == 0)
		return 1;

	return 0;
}

//装备涅槃消耗 传入 %playerid, 装备id  type = 1 为获取消耗道具id  2=获取消耗数量 3=获取金币消耗 4=元宝代替时消耗的元宝
function getEquipNiePanNeed(%playerid, %itemid, %type)
{
	%itemLevel = GetItemData(%ItemId, $Item_Data_Lv);//获得道具等级
	%itemQuality = GetItemData(%itemid, $Item_Data_Color);//获得道具颜色品质

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

	if (%type==1 || %type ==4)//1返回涅槃石道具ID   4返回涅槃时用元宝代替道具时元宝数量
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
	else if (%type == 2)//返回涅槃石消耗数量
	{
		return 1;
	}
	else if (%type == 3)//返回涅槃消耗金币
	{

		%NeedJinBi = mfloor(100 * %QualityNum * Mpow(1.035, %itemLevel));
		return %NeedJinBi;
	}
	return 0;
}

//■■■■■■■■■■■【鉴宝】相关■■■■■■■■■■■■■■■■■■■■
//获取鉴宝所需金币消耗 璞玉ID
function GetAntiquesNeedJinBi(%itemID)
{
	%itemLv = GetItemData(%itemid, $Item_Data_Lv);//获得道具等级
	switch (%itemLv)
	{
		case 50: return 100000;
		case 60: return 500000;
		case 70: return 1000000;
		default: return 1000000;
	}
}

//获取鉴宝所需的鉴宝符ID
function GetAntiquesNeedItemID(%itemID)
{
	%itemLv = GetItemData(%itemid, $Item_Data_Lv);//获得道具等级
	switch (%itemLv)
	{
		case 50: return 105109071;
		case 60: return 105109072;
		case 70: return 105109073;
		default: return 105109073;
	}
}

//获取鉴宝所需的鉴宝符的数量 与元宝代替鉴宝符时元宝消耗数量 type1 = 道具数量  type=2 元宝数量
function GetAntiquesNeedItem(%itemID, %type)
{
	if (%type == 1) return 1;
	%itemLv = GetItemData(%itemid, $Item_Data_Lv);//获得道具颜色品质
	switch (%itemLv)
	{
		case 50: return 100;
		case 60: return 500;
		case 70: return 1000;
		default: return 1000;
	}
}

//Show的产出道具ID GetShowAntiquesItem[ 璞玉的颜色品质，第N个]
$GetShowAntiquesItem[50, 1] = 105180152;//	3级宝石随机礼包	   	  
$GetShowAntiquesItem[50, 2] = 105100302;//	高级红宝石        
$GetShowAntiquesItem[50, 3] = 105100312;//	高级蓝宝石        
$GetShowAntiquesItem[50, 4] = 105100322;//	高级绿宝石  
$GetShowAntiquesItem[50, 5] = 110020083;//	物攻受击减免      
$GetShowAntiquesItem[50, 6] = 110020093;//	法攻受击减免      
$GetShowAntiquesItem[50, 7] = 110020113;//	幸运宝石          
$GetShowAntiquesItem[50, 8] = 110030023;//	物理闪避宝石      
$GetShowAntiquesItem[50, 9] = 110030033;//	法术闪避宝石      
$GetShowAntiquesItem[50, 10]= 110030043;//	暴击宝石          
$GetShowAntiquesItem[50, 11]= 110030053;//	暴击伤害宝石      
$GetShowAntiquesItem[50, 12]= 110030063;//	暴击减免宝石      
$GetShowAntiquesItem[50, 13]= 110030073;//	暴击伤害减免宝石  
$GetShowAntiquesItem[50, 14]= 110030113;//	会心一击          
$GetShowAntiquesItem[50, 15]= 110030123;//	会心一击防御      
$GetShowAntiquesItem[50, 16]= 110030133;//	会心一击伤害      
$GetShowAntiquesItem[50, 17]= 110030143;//	会心伤害减免      
$GetShowAntiquesItem[50, 18]= 105105304;//	金砖        
$GetShowAntiquesItem[50, 19]= 105105303;//	金条        
$GetShowAntiquesItem[50, 20]= 105105302;//	金锭        
$GetShowAntiquesItem[50, 21]= 105105301;//	金叶子   

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

//获取鉴宝产出的展示道具
function GetShowAntiquesItemID(%itemID)
{
	%itemQuality = GetItemData(%itemid, $Item_Data_Color);//获得道具颜色品质
	%itemLv = GetItemData(%itemid, $Item_Data_Lv);//获得道具等级
	%List = $GetShowAntiquesItem[%itemLv, 1];
	for (%i = 2; %i <= 99; %i++)
	{
		if ($GetShowAntiquesItem[%itemLv, %i] $= "")
			break;
		%List = %List @ " " @ $GetShowAntiquesItem[%itemLv, %i];
	}
	return %List;
}

//鉴宝成功后调用 全服公告 玩家名 璞玉ID  奖励物品ID
function ShowAntiquesAysAtring(%playerid, %PuYuID, %itemid)
{
}
//获取鉴宝结果 角色ID 璞玉ID 鉴宝幸运符ID
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
				%PlayerName = "<t>『" @ %Player.GetPlayerName() @ "』</t>";
				%Msg = "<t>福星高照</t>" @ %Playername @ "<t>在鉴宝时获得</t>" @ %ItemName1;
				SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg @ "</t>", $chatMsg_Type_Normal2);
			}
		}
	}
	if (%Money >= 200000)
	{
		//echo( "%Money ===" @ %Money );

		%PlayerName = GetPlayerZiTiName(%Player, 1);
		%Msg = "<t>福星高照</t>" @ %Playername @ "<t>在鉴宝时获得</t>" @  $Get_Dialog_GeShi[31416] @ mfloor(%Money/10000) @ "</t><t>枚金币</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg @ "</t>", $chatMsg_Type_Normal2);
	}
}

function GetItemForAntiques(%player, %Type, %SourceA, %SourceB)//鉴宝计算给予的道具ID
{
	%Ran = GetRanDom(1, 10000);
	%Lucky = %Player.GetLuck();
	switch (%Type)
	{
		case 1:
			%OneRan[1] = (((%Lucky / 10)+ %SourceA + %SourceB)/20+1)* 40;//3级宝石随机礼包
			%OneRan[2] = (((%Lucky / 10)+ %SourceA + %SourceB)/20+1)* 80;//高级红宝石 高级蓝宝石 高级绿宝石
			%OneRan[3] = (((%Lucky / 10)+ %SourceA + %SourceB)/20+1)* 30;// 金砖 
			%OneRan[4] = (((%Lucky / 10)+ %SourceA + %SourceB)/80+1)* 1550;// 金条
			%OneRan  = %OneRan[1] + %OneRan[2] + %OneRan[3] + %OneRan[4];
			%OneRan[5] = (10000 - %OneRan) * 0.2174;//105105302	金锭	
			%OneRan[6] = (10000 - %OneRan) * 0.870;//105105301	金叶子	
			%OneRan[7] = (10000 - %OneRan) * 0.1217;//105105301	金叶子	
			%OneRan[8] = (10000 - %OneRan) * 0.1391;//105105301	金叶子	
			%OneRan[9] = (10000 - %OneRan) * 0.0870;//105270001	金币	
			%OneRan[10] = 10000 - (%OneRan + %OneRan[5] + %OneRan[6] + %OneRan[7] + %OneRan[8] + %OneRan[9]);//105270001	金币
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
function GetStoreForAntiques(%player, %level)//鉴宝给予的宝石随机
{
	%Ran = GetRanDom(1, 10000);
	if (%Ran <= 335) %ItemID = 110010083;//物攻伤害加深    
	else if (%Ran <= 670) %ItemID = 110010093;//法攻伤害加深    
	else if (%Ran <= 1153) %ItemID = 110010503;//玄兵力量宝石    
	else if (%Ran <= 1636) %ItemID = 110010513;//玄兵智力宝石    
	else if (%Ran <= 2119) %ItemID = 110010523;//玄兵物攻宝石    
	else if (%Ran <= 2602) %ItemID = 110010533;//玄兵最小物攻宝石
	else if (%Ran <= 3085) %ItemID = 110010543;//玄兵最大物攻宝石
	else if (%Ran <= 3568) %ItemID = 110010553;//玄兵法攻宝石    
	else if (%Ran <= 4051) %ItemID = 110010563;//玄兵最小法攻宝石
	else if (%Ran <= 4534) %ItemID = 110010573;//玄兵最大法攻宝石
	else if (%Ran <= 4984) %ItemID = 110020063;//无视物理防御宝石
	else if (%Ran <= 5434) %ItemID = 110020073;//无视法术防御宝石
	else if (%Ran <= 5759) %ItemID = 110020083;//物攻受击减免    
	else if (%Ran <= 6084) %ItemID = 110020093;//法攻受击减免    
	else if (%Ran <= 6360) %ItemID = 110020113;//幸运宝石        
	else if (%Ran <= 6810) %ItemID = 110030023;//物理闪避宝石    
	else if (%Ran <= 7260) %ItemID = 110030033;//法术闪避宝石    
	else if (%Ran <= 7540) %ItemID = 110030043;//暴击宝石        
	else if (%Ran <= 7820) %ItemID = 110030053;//暴击伤害宝石    
	else if (%Ran <= 8100) %ItemID = 110030063;//暴击减免宝石    
	else if (%Ran <= 8380) %ItemID = 110030073;//暴击伤害减免宝石
	else if (%Ran <= 8660) %ItemID = 110030113;//会心一击        
	else if (%Ran <= 8940) %ItemID = 110030123;//会心一击防御    
	else if (%Ran <= 9220) %ItemID = 110030133;//会心一击伤害    
	else if (%Ran <= 9500) %ItemID = 110030143;//会心伤害减免    
	else if (%Ran <= 10000) %ItemID = 110010613;//玄兵治疗宝石    

	if (%level == 4)
		%ItemID = %ItemID + 1;
	else if (%Level == 5)
		%ItemID = %ItemID + 2;

	//echo( %ItemID @ "   " @ GetItemData( %ItemID, 1 ) );
	return %ItemID;
}


//■■■■■■■■■■■【造化神石合成】相关■■■■■■■■■■■■■■■■
function getShenShiSucceed(%playerid, %itemid, %itemNum)  //获取神石合成的概率 实际概率
{
	//echo( " %playerid ===" @  %playerid @ "    %itemid==" @  %itemid @ "     %itemNum==" @  %itemNum );
	if ($Now_Script == 2)
		%Player = SptGetPlayer(%playerid);
	else if ($Now_Script == 1)
		%Player = GetPlayer();

	%itemLevel = GetItemData(%itemid, $Item_Data_Lv);//获得道具等级
	%goodluck = %Player.getLuck();//获取玩家福缘值
	if (%goodluck <100)%goodluck = 0;
	switch (%itemNum)
	{
		case 2: %MaxSucceed = 4000; %MinSucceed = 3000; %ShowMaxSucceed = 5000;
		case 3: %MaxSucceed = 6000; %MinSucceed = 4500; %ShowMaxSucceed = 7000;
		case 4: %MaxSucceed = 8000; %MinSucceed = 6000; %ShowMaxSucceed = 9000;
		case 5: %MaxSucceed =10000; %MinSucceed =10000; %ShowMaxSucceed = 10000;
	}

	if ($Now_Script == 1)//客户端显示
	{
		%Result =mfloor(%MaxSucceed + (%goodluck / (500 * (1 + %itemLevel / 10))*(%ShowMaxSucceed - %MaxSucceed)));
		if (%Result > %ShowMaxSucceed) %Result = %ShowMaxSucceed;
	}
	else if ($Now_Script == 2)//服务端实际调用
	{
		%Result = mfloor(%MinSucceed + (%goodluck / (500 * (1 + %itemLevel / 10))*(%MaxSucceed - %MinSucceed)));
		if (%Result > %MaxSucceed) %Result = %MaxSucceed;
	}
	//echo( "造化神石合成%Result=====" @ %Result );
	return %Result;
}


function getShenShiResultID(%itemid) //获取神石合成后的结果
{
	return %itemid+1;
}

//获取造化神石合成的金币消耗， 造化神石ID，数量
function getShenShiNeedMoney(%itemid, %ItemCount)
{
	%itemLevel = GetItemData(%itemid, $Item_Data_Lv);//获得道具等级
	%NeedJinBi = mfloor((%itemLevel - 4) * 50000 / %ItemCount);
	return %NeedJinBi;
}


//■■■■■■■■■■■【充值礼包】相关■■■■■■■■■■■■■■■■■■
function GetFirstRechargeGitf(%type)//首充礼包返回道具
{
	switch (%type)
	{
		case 0:return 116080005;//天工开物( 五 )		
		case 1:return 105021051;//不死丹( 赠品 )		
		case 2:return 112010058;//8格乾坤袋( 赠品 )	
		case 3:return 105109371;//一包凝血丹赠品( 4 )
		case 4:return 105109381;//一包聚神散赠品( 4 )
	}
}

function GetFisrtRechargeForDays(%type)//每日充值返回道具
{
	switch (%type)
	{
		case 0:return "105109331 5"; //悬赏刷新令	
		case 1:return "105021051 1"; //不死丹( 赠品 )	
		case 2:return "105109032 2"; //随机商店刷新令	
		case 3:return "105109032 5"; //随机商店刷新令	
		case 4:return "105028022 5"; //三倍经验丹( 赠品 )
	}
}
function GetRechargeHaoLiItem(%type)//提取豪礼返回道具
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

function GetRechargeHaoLiQuota(%type)//提取豪礼个阶段需要的额度
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

//$PlayGameReturnTime[ 4095 ] = $XZL_ClearTime_Tomorrow[ 1 ];//记录每日充值 0位 bit计算领取哪些礼包 1位 今天充值数量
//$PlayGameReturnTime[ 4097 ] = $XZL_ClearTime_Never[ 1 ];//记录首充礼包 0位 1领取0没有领取 1位 当前充值额度
function SetIsCanReceiveFirstRecharge(%Player)//记录首充礼包领取记录 
{
	%Act1 = GetAct(%Player, 4097, 1) * 1;
	SetAct(%Player, 4097, 1, %Act1);
}
function GetIsCanReceiveFirstRecharge(%Player)//返回首充礼包是否可以领取  返回值：-1已经领取 0可以领取 >0 不可领取，还差这么多元宝
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
function SetIsCanReceiveRechargeDays(%Player, %Index)//设置每日充值记录 %Index 0 - 4 第几个礼包
{
	%Act0 = GetAct(%Player, 4095, 0);
	%Act1 = GetAct(%Player, 4095, 1);
	%Act0 = SetBit(%Act0, %Index);
	SetAct(%Player, 4095, %Act0, %Act1);
}
function GetIsCanReceiveRechargeDays(%Player, %Index)//返回每日充值礼包是否可以领取 %Index 0 - 4 第几个礼包  返回值：-1已经领取 0可以领取 >0 不可领取，还差这么多元宝
{
	//-1已经领取 1可以领取 0充值不够，不能领
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
function SetIsCanReceiveRechargeHaoLi(%Player, %Index)//设置充值豪礼领取记录 %Index 0 - 34 第几个礼包 
{
	%Src = 144 + %Index;
	SetSrc(%Player, %Src);
}
function GetIsCanReceiveRechargeHaoLi(%Player, %Index)//返回充值豪礼是否可以领取 %Index 0 - 34 第几个礼包 返回值：-1已经领取 0可以领取 >0 不可领取，还差这么多元宝
{
	%Gold = %Player.GetTotalDrawGold();// 总的提取元宝数量
	%Src = 144 + %Index;
	if (GetSrc(%Player, %Src) == 1)
		return -1;
	%NeedMoney = GetRechargeHaoLiQuota(%Index);//提取豪礼个阶段需要的额度
	if (%NeedMoney <= %Gold)
		return 0;
	else
		return %NeedMoney - %Gold;
}


function ReceiveRechargeClear(%Player)//清除所有充值礼包领取记录
{
	for (%Src = 144; %Src <= 178; %Src++)
	{
		DelSrc(%Player, %Src);
	}
	SetAct(%Player, 4095, 0, 0);
}
//■■■■■■■■■■■【充值礼包】相关■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【在线奖励】相关■■■■■■■■■■■■■■■■■■
function GetStateOnlineReward(%Type)
{
	switch (%Type)
	{
		case 0:return "105028002 1"; //双倍经验丹( 赠品 )
		case 1:return "112010055 1"; //5格乾坤袋( 赠品 )
		case 2:return "112010056 1"; //6格乾坤袋( 赠品 )
		case 3:return "105090911 2"; //昆仑通宝( 赠品 )
		case 4:return "105028012 1"; //2.5倍经验丹( 赠品 )
		case 5:return "105021051 1"; //不死丹( 赠品 )
		case 6:return "105028022 1"; //三倍经验丹( 赠品 )
		case 7:return "105180201 1"; //坐骑礼包
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
//■■■■■■■■■■■【在线奖励】相关■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【随机商店】相关■■■■■■■■■■■■■■■■■■
function GetFreeTimesForRanShop(%Player)//每日最大免费次数
{
	VIP_getNowTequanLvMaxCnt(%Player, 3);
}

// %Optype 孔位 性别 职业返回道具ID 原价 概率（万分之)
function GetSpecialRanShopItem(%Optype, %Sex, %Class)//特殊道具介绍 
{
	if (%Optype == 2) return "119013017 193600 143";
	switch (%Sex)
	{
		case 1:return "102105024 73600 151";
		case 2:return "102105524 73600 151";
		default:return "119013017 193600 143";
	}
}

function GetPrayShopItem(%Optype)//祈福豪礼的特殊显示的3个道具展示
{
	if (%Optype == 2)
		return 119013032;
	if (%Optype == 3)
		return 119013033;
	%Sex = getplayer().getsex();
	if (%Optype == 1 && %Sex==1) return 102105015;
	else return 102105515;
}
//■■■■■■■■■■■【随机商店】相关■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【攻城战】相关■■■■■■■■■■■■■■■■■■
//OpenAttackCityApplyWnd

//■■■■■■■■■■■【攻城战】相关■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【充值反馈】相关■■■■■■■■■■■■■■■■■■
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
				case 1:return 105180241;//壮志雄心大礼包(新服专属)
				case 2:return 105180242;//盖世英雄大礼包(新服专属)
				case 3:return 105180243;//超凡入圣大礼包(新服专属)
				case 4:return 105180244;//至上仙师大礼包(新服专属)
				default:return 0;
			}
		default:
			switch (%index)
			{
				case 1:return 105180251;//壮志雄心大礼包
				case 2:return 105180252;//盖世英雄大礼包
				case 3:return 105180253;//超凡入圣大礼包
				case 4:return 105180254;//至上仙师大礼包
				default:return 0;
			}
	}
}
//■■■■■■■■■■■【充值反馈】相关■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【抽奖触发公告】相关■■■■■■■■■■■■■■■■
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
function ShowPrizeNotice(%Player, %Itemid, %Continuity, %isbool, %Count, %Istrue)//玩家对象 道具编号 连抽次数  元宝显示方式   道具出来 是否公告
{
	if (%Istrue <= 0)
		return;
	if (%Itemid > 0 && %Itemid != 105270002)
	{
		%ItemName1 =  $Get_Dialog_GeShi[31420] @ %Count @ "</t><t>个</t>" @ GetItemName(%ItemID, 1);
		%ItemName2 =  $Get_Dialog_GeShi[60002] @ %Count @ "</t><t>个</t>" @ GetItemName(%ItemID, 2);
	}
	else if (%Count > 0 && %Itemid == 105270002)
	{
		switch (%isbool)
		{
			case 0:
				%ItemName1 = GetHuoDongName(%Count @ "元宝", 1);
				%ItemName2 = GetHuoDongName(%Count @ "元宝", 2);
			case 1:
				%ItemName1 = "<t>奖池内</t>" @ GetHuoDongName(mceil(%Count/100) @ "%元宝", 1);
				%ItemName2 = "<t>奖池内</t>" @ GetHuoDongName(mceil(%Count/100) @ "%元宝", 2);
		}
	}

	%Playername1 = GetPlayerZiTiName(%Player, 1);
	%Playername2= GetPlayerZiTiName(%Player, 2);

	%HuoDongMingCheng1 = GetHuoDongName("仙缘解签", 1);
	%HuoDongMingCheng2 = GetHuoDongName("仙缘解签", 2);

	switch (%Continuity)
	{
		case 1:%TakeText = "<t>抽奖获得了</t>";
		case 5:%TakeText = "<t>连续解五签，获得了</t>";
		case 10:%TakeText = "<t>连续解十签，获得了</t>";
	}
	%Msg1 = "<t>福星高照，</t>" @ %Playername1 @ "<t>在</t>" @ %HuoDongMingCheng1 @ "<t>活动中，</t>" @ %TakeText @ %ItemName1 @ "<t>，真是羡煞众人。</t>";
	%Msg2 = "<t>福星高照，</t>" @ %Playername2 @ "<t>在</t>" @ %HuoDongMingCheng2 @ "<t>活动中，</t>" @ %TakeText @ %ItemName2;
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
		case 1:%HuoDongMingCheng1 = GetHuoDongName("青铜祈福", 1); %HuoDongMingCheng2 = GetHuoDongName("青铜祈福", 2);
		case 2:%HuoDongMingCheng1 = GetHuoDongName("白银祈福", 1); %HuoDongMingCheng2 = GetHuoDongName("白银祈福", 2);
		case 3:%HuoDongMingCheng1 = GetHuoDongName("黄金祈福", 1); %HuoDongMingCheng2 = GetHuoDongName("黄金祈福", 2);
		default:return;
	}
	%PlayerName1 = GetPlayerZiTiName(%Player, 1);
	%PlayerName2 = GetPlayerZiTiName(%Player, 2);
	%ItemName1 = GetItemName(%ItemID, 1);
	%ItemName2 = GetItemName(%ItemID, 2);
	%Icount1 = $Get_Dialog_GeShi[31420] @ %ItemNum @ "</t>";
	%Icount2 = $Get_Dialog_GeShi[60002] @ %ItemNum @ "</t>";
	%Text1 = "<t>天降奇缘，</t>" @ %PlayerName1 @ "<t>参与祈愿豪礼</t>" @ %HuoDongMingCheng1 @ "<t>活动，获得了</t>" @ %Icount1 @ "<t>个</t>" @ %ItemName1 @ "<t>奖励！</t>";
	%Text2 = "<t>天降奇缘，</t>" @ %PlayerName2 @ "<t>参与祈愿豪礼</t>" @ %HuoDongMingCheng2 @ "<t>活动，获得了</t>" @ %Icount2 @ "<t>个</t>" @ %ItemName2 @ "<t>奖励！</t>";
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

//■■■■■■■■■■■【抽奖触发公告】相关■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【全民夺宝相关】■■■■■■■■■■■■■■■■
//全民夺宝脚本全局变量																	
$QuanMingDuoBao_ItemList[1, 0] = "105180073 125 105290023 10";        //1号第1场   商品1:红宝石随机礼包(4级)_价格:125夺宝符。  商品2:3级宝石造化符_价格:10夺宝符。																	
$QuanMingDuoBao_ItemList[1, 1] = "116060106 35 105101701 10";         //1号第2场   商品1:6级造化神石_价格:35夺宝符。  商品2:双倍福袋(小)_价格:10夺宝符。																	
$QuanMingDuoBao_ItemList[1, 2] = "102105515 555 110030134 375";       //1号第3场   商品1:无忧仙袍(女)_价格:555夺宝符。  商品2:会心一击伤害_价格:375夺宝符。																	
$QuanMingDuoBao_ItemList[1, 3] = "102105015 555 119013077 1136";      //1号第4场   商品1:无忧仙袍(男)_价格:555夺宝符。  商品2:金鱼_价格:1136夺宝符。																	
$QuanMingDuoBao_ItemList[1, 4] = "105105128 100 105101747 16";        //1号第5场   商品1:100金币兑换券_价格:100夺宝符。  商品2:悬赏刷新令福袋(中)_价格:16夺宝符。																	

$QuanMingDuoBao_ItemList[2, 0] = "105180093 125 105290032 15";        //2号第1场   商品1:绿宝石随机礼包(4级)_价格:125夺宝符。  商品2:4级宝石造化符_价格:15夺宝符。																	
$QuanMingDuoBao_ItemList[2, 1] = "105101704 100 105105128 100";       //2号第2场   商品1:2.5倍福袋(小)_价格:100夺宝符。  商品2:100金币兑换券_价格:100夺宝符。																	
$QuanMingDuoBao_ItemList[2, 2] = "119013028 1936 102105518 300";      //2号第3场   商品1:火凤凰_价格:1936夺宝符。  商品2:祥龙(女)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[2, 3] = "116060108 875 102105018 300";       //2号第4场   商品1:8级造化神石_价格:875夺宝符。  商品2:祥龙(男)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[2, 4] = "105101783 30 105101747 16";         //2号第5场   商品1:一阶星魂珠(中)_价格:30夺宝符。  商品2:悬赏刷新令福袋(中)_价格:16夺宝符。																	

$QuanMingDuoBao_ItemList[3, 0] = "105180103 125 105101701 10";        //3号第1场   商品1:蓝宝石随机礼包(4级)_价格:125夺宝符。  商品2:双倍福袋(小)_价格:10夺宝符。																	
$QuanMingDuoBao_ItemList[3, 1] = "105101738 50 116060107 175";        //3号第2场   商品1:归元符福袋(中)_价格:50夺宝符。  商品2:7级造化神石_价格:175夺宝符。																	
$QuanMingDuoBao_ItemList[3, 2] = "102105019 300 105101707 300";       //3号第3场   商品1:名门礼服(男)_价格:300夺宝符。  商品2:3倍福袋(小)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[3, 3] = "102105519 300 116080007 200";       //3号第4场   商品1:名门礼服(女)_价格:300夺宝符。  商品2:天工开物(七)_价格:200夺宝符。																	
$QuanMingDuoBao_ItemList[3, 4] = "105101785 10 105101783 30";         //3号第5场   商品1:二阶星魂珠(小)_价格:10夺宝符。  商品2:一阶星魂珠(中)_价格:30夺宝符。																	

$QuanMingDuoBao_ItemList[4, 0] = "116060106 35 105290024 15";         //4号第1场   商品1:6级造化神石_价格:35夺宝符。  商品2:3级宝石造化符_价格:15夺宝符。																	
$QuanMingDuoBao_ItemList[4, 1] = "105180113 250 116060107 175";       //4号第2场   商品1:红宝石精选礼包(4级)_价格:250夺宝符。  商品2:7级造化神石_价格:175夺宝符。																	
$QuanMingDuoBao_ItemList[4, 2] = "116070002 250 102105029 300";       //4号第3场   商品1:完璧符_价格:250夺宝符。  商品2:侠之锦衣(男)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[4, 3] = "110030054 375 102105529 300";       //4号第4场   商品1:暴击伤害宝石_价格:375夺宝符。  商品2:侠之锦衣(女)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[4, 4] = "105101785 10 105101789 100";        //4号第5场   商品1:二阶星魂珠(小)_价格:10夺宝符。  商品2:三阶星魂珠(中)_价格:100夺宝符。																	

$QuanMingDuoBao_ItemList[5, 0] = "105101701 10 105090413 20";         //5号第1场   商品1:双倍福袋(小)_价格:10夺宝符。  商品2:四级宝石合成卷_价格:20夺宝符。																	
$QuanMingDuoBao_ItemList[5, 1] = "105180153 125 116070002 250";       //5号第2场   商品1:宝石随机礼包(4级)_价格:125夺宝符。  商品2:完璧符_价格:250夺宝符。																	
$QuanMingDuoBao_ItemList[5, 2] = "102105530 300 116080009 5000";      //5号第3场   商品1:部落达人(女）_价格:300夺宝符。  商品2:天工开物(九)_价格:5000夺宝符。																	
$QuanMingDuoBao_ItemList[5, 3] = "102105030 300 119013034 1136";      //5号第4场   商品1:部落达人(男)_价格:300夺宝符。  商品2:赤磷金鱼_价格:1136夺宝符。																	
$QuanMingDuoBao_ItemList[5, 4] = "112020006 50 105101789 100";        //5号第5场   商品1:仓库扩展包24格_价格:50夺宝符。  商品2:三阶星魂珠(中)_价格:100夺宝符。																	

$QuanMingDuoBao_ItemList[6, 0] = "105101779 6 105101657 25";          //6号第1场   商品1:星界石锦盒(小)_价格:6夺宝符。  商品2:一沓回城卷_价格:25夺宝符。																	
$QuanMingDuoBao_ItemList[6, 1] = "116080008 1000 116060003 50";       //6号第2场   商品1:天工开物(八)_价格:1000夺宝符。  商品2:鸿运石_价格:50夺宝符。																	
$QuanMingDuoBao_ItemList[6, 2] = "105180133 250 102105532 300";       //6号第3场   商品1:绿宝石精选礼包(4级)_价格:250夺宝符。  商品2:机车时尚(女)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[6, 3] = "105101707 300 102105032 300";       //6号第4场   商品1:3倍福袋(小)_价格:300夺宝符。  商品2:机车时尚(男)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[6, 4] = "105101701 10 105101737 10";         //6号第5场   商品1:双倍福袋(小)_价格:10夺宝符。  商品2:归元符福袋(小)_价格:10夺宝符。																	

$QuanMingDuoBao_ItemList[7, 0] = "105101743 6 105180143 250";         //7号第1场   商品1:答题双倍得分卡福袋(小)_价格:6夺宝符。  商品2:蓝宝石精选礼包(4级)_价格:250夺宝符。																	
$QuanMingDuoBao_ItemList[7, 1] = "105101749 100 105101012 20";        //7号第2场   商品1:随机商店刷新令福袋(小)_价格:100夺宝符。  商品2:二阶重铸石礼包_价格:20夺宝符。																	
$QuanMingDuoBao_ItemList[7, 2] = "102105034 300 110020114 500";       //7号第3场   商品1:DJ(男)_价格:300夺宝符。  商品2:幸运宝石_价格:500夺宝符。																	
$QuanMingDuoBao_ItemList[7, 3] = "102105534 300 116080007 200";       //7号第4场   商品1:DJ(女)_价格:300夺宝符。  商品2:天工开物(七)_价格:200夺宝符。																	
$QuanMingDuoBao_ItemList[7, 4] = "105101779 6 105101656 25";          //7号第5场   商品1:星界石锦盒(小)_价格:6夺宝符。  商品2:一沓随机卷轴_价格:25夺宝符。																	

$QuanMingDuoBao_ItemList[8, 0] = "116060106 35 105101022 25";         //8号第1场   商品1:6级造化神石_价格:35夺宝符。  商品2:三阶重铸石礼包_价格:25夺宝符。																	
$QuanMingDuoBao_ItemList[8, 1] = "105105129 200 105180154 660";       //8号第2场   商品1:200金币兑换券_价格:200夺宝符。  商品2:宝石随机礼包(5级)_价格:660夺宝符。																	
$QuanMingDuoBao_ItemList[8, 2] = "119013074 1936 102105036 500";      //8号第3场   商品1:烈焰独角兽_价格:1936夺宝符。  商品2:秦皇时装(男)_价格:500夺宝符。																	
$QuanMingDuoBao_ItemList[8, 3] = "116060108 875 102105536 500";       //8号第4场   商品1:8级造化神石_价格:875夺宝符。  商品2:秦皇时装(女)_价格:500夺宝符。																	
$QuanMingDuoBao_ItemList[8, 4] = "105101022 25 105101221 10";         //8号第5场   商品1:三阶重铸石礼包_价格:25夺宝符。  商品2:三阶涅槃石锦盒_价格:10夺宝符。																	

$QuanMingDuoBao_ItemList[9, 0] = "110010004 150 110010014 150";       //9号第1场   商品1:力量宝石_价格:150夺宝符。  商品2:智力宝石_价格:150夺宝符。																	
$QuanMingDuoBao_ItemList[9, 1] = "116060003 50 105101707 300";        //9号第2场   商品1:鸿运石_价格:50夺宝符。  商品2:3倍福袋(小)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[9, 2] = "110030114 375 102105515 555";       //9号第3场   商品1:会心一击_价格:375夺宝符。  商品2:无忧仙袍(女)_价格:555夺宝符。																	
$QuanMingDuoBao_ItemList[9, 3] = "119013016 1136 102105015 555";      //9号第4场   商品1:碧水金晶兽_价格:1136夺宝符。  商品2:无忧仙袍(男)_价格:555夺宝符。																	
$QuanMingDuoBao_ItemList[9, 4] = "105105129 200 116060107 175";       //9号第5场   商品1:200金币兑换券_价格:200夺宝符。  商品2:7级造化神石_价格:175夺宝符。																	

$QuanMingDuoBao_ItemList[10, 0] = "112010014 100 105101737 10";       //10号第1场   商品1:28格乾坤袋_价格:100夺宝符。  商品2:归元符福袋(小)_价格:10夺宝符。																	
$QuanMingDuoBao_ItemList[10, 1] = "110020044 150 110020054 150";      //10号第2场   商品1:物理防御宝石_价格:150夺宝符。  商品2:法术防御宝石_价格:150夺宝符。																	
$QuanMingDuoBao_ItemList[10, 2] = "102105518 300 119013019 1136";     //10号第3场   商品1:祥龙(女)_价格:300夺宝符。  商品2:幻舞荧蝶_价格:1136夺宝符。																	
$QuanMingDuoBao_ItemList[10, 3] = "102105018 300 110030144 375";      //10号第4场   商品1:祥龙(男)_价格:300夺宝符。  商品2:会心伤害减免_价格:375夺宝符。																	
$QuanMingDuoBao_ItemList[10, 4] = "116060108 875 105101657 25";       //10号第5场   商品1:8级造化神石_价格:875夺宝符。  商品2:一沓回城卷_价格:25夺宝符。																	

$QuanMingDuoBao_ItemList[11, 0] = "105101776 88 105101743 6";         //11号第1场   商品1:聚英令锦盒(小)_价格:88夺宝符。  商品2:答题双倍得分卡福袋(小)_价格:6夺宝符。																	
$QuanMingDuoBao_ItemList[11, 1] = "105101707 300 105101749 100";      //11号第2场   商品1:3倍福袋(小)_价格:300夺宝符。  商品2:随机商店刷新令福袋(小)_价格:100夺宝符。																	
$QuanMingDuoBao_ItemList[11, 2] = "116080008 1000 102105019 300";     //11号第3场   商品1:天工开物(八)_价格:1000夺宝符。  商品2:名门礼服(男)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[11, 3] = "116080009 5000 102105519 300";     //11号第4场   商品1:天工开物(九)_价格:5000夺宝符。  商品2:名门礼服(女)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[11, 4] = "110030104 150 105101112 20";       //11号第5场   商品1:治疗宝石_价格:150夺宝符。  商品2:二阶精炼石礼盒_价格:20夺宝符。																	

$QuanMingDuoBao_ItemList[12, 0] = "116060106 35 105101743 6";         //12号第1场   商品1:6级造化神石_价格:35夺宝符。  商品2:答题双倍得分卡福袋(小)_价格:6夺宝符。																	
$QuanMingDuoBao_ItemList[12, 1] = "105101776 88 105101749 100";       //12号第2场   商品1:聚英令锦盒(小)_价格:88夺宝符。  商品2:随机商店刷新令福袋(小)_价格:100夺宝符。																	
$QuanMingDuoBao_ItemList[12, 2] = "102105029 300 105101707 300";      //12号第3场   商品1:侠之锦衣(男)_价格:300夺宝符。  商品2:3倍福袋(小)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[12, 3] = "102105529 300 116060107 175";      //12号第4场   商品1:侠之锦衣(女)_价格:300夺宝符。  商品2:7级造化神石_价格:175夺宝符。																	
$QuanMingDuoBao_ItemList[12, 4] = "105101022 25 105290031 10";        //12号第5场   商品1:三阶重铸石礼包_价格:25夺宝符。  商品2:4级宝石造化符_价格:10夺宝符。																	

$QuanMingDuoBao_ItemList[13, 0] = "105101738 50 105101122 25";        //13号第1场   商品1:归元符福袋(中)_价格:50夺宝符。  商品2:三阶精炼石礼盒_价格:25夺宝符。																	
$QuanMingDuoBao_ItemList[13, 1] = "105105132 500 116080007 200";      //13号第2场   商品1:500金币兑换券_价格:500夺宝符。  商品2:天工开物(七)_价格:200夺宝符。																	
$QuanMingDuoBao_ItemList[13, 2] = "116060108 875 102105530 300";      //13号第3场   商品1:8级造化神石_价格:875夺宝符。  商品2:部落达人(女）_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[13, 3] = "119013036 1936 102105030 300";     //13号第4场   商品1:蝎皇_价格:1936夺宝符。  商品2:部落达人(男)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[13, 4] = "105101788 20 105101022 25";        //13号第5场   商品1:三阶星魂珠(小)_价格:20夺宝符。  商品2:三阶重铸石礼包_价格:25夺宝符。																	

$QuanMingDuoBao_ItemList[14, 0] = "105101788 20 105101211 7";         //14号第1场   商品1:三阶星魂珠(小)_价格:20夺宝符。  商品2:二阶涅槃石锦盒_价格:7夺宝符。																	
$QuanMingDuoBao_ItemList[14, 1] = "116080007 200 105180083 250";      //14号第2场   商品1:天工开物(七)_价格:200夺宝符。  商品2:玄兵宝石随机礼包(4级)_价格:250夺宝符。																	
$QuanMingDuoBao_ItemList[14, 2] = "102105532 300 116060108 875";      //14号第3场   商品1:机车时尚(女)_价格:300夺宝符。  商品2:8级造化神石_价格:875夺宝符。																	
$QuanMingDuoBao_ItemList[14, 3] = "102105032 300 110020115 2640";     //14号第4场   商品1:机车时尚(男)_价格:300夺宝符。  商品2:幸运宝石_价格:2640夺宝符。																	
$QuanMingDuoBao_ItemList[14, 4] = "105101785 10 105101656 25";        //14号第5场   商品1:二阶星魂珠(小)_价格:10夺宝符。  商品2:一沓随机卷轴_价格:25夺宝符。																	

$QuanMingDuoBao_ItemList[15, 0] = "105101707 300 105101743 6";        //15号第1场   商品1:3倍福袋(小)_价格:300夺宝符。  商品2:答题双倍得分卡福袋(小)_价格:6夺宝符。																	
$QuanMingDuoBao_ItemList[15, 1] = "112010014 100 105101749 100";      //15号第2场   商品1:28格乾坤袋_价格:100夺宝符。  商品2:随机商店刷新令福袋(小)_价格:100夺宝符。																	
$QuanMingDuoBao_ItemList[15, 2] = "110030124 375 102105034 300";      //15号第3场   商品1:会心一击防御_价格:375夺宝符。  商品2:DJ(男)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[15, 3] = "116060109 4375 102105534 300";     //15号第4场   商品1:9级造化神石_价格:4375夺宝符。  商品2:DJ(女)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[15, 4] = "105101785 10 105101779 6";         //15号第5场   商品1:二阶星魂珠(小)_价格:10夺宝符。  商品2:星界石锦盒(小)_价格:6夺宝符。																	

$QuanMingDuoBao_ItemList[16, 0] = "105101779 6 105101702 50";         //16号第1场   商品1:星界石锦盒(小)_价格:6夺宝符。  商品2:双倍福袋(中)_价格:50夺宝符。																	
$QuanMingDuoBao_ItemList[16, 1] = "105105036 90 105105032 50";        //16号第2场   商品1:9000元宝兑换券_价格:90夺宝符。  商品2:5000元宝兑换券_价格:50夺宝符。																	
$QuanMingDuoBao_ItemList[16, 2] = "102105036 500 119013070 1936";     //16号第3场   商品1:秦皇时装(男)_价格:500夺宝符。  商品2:红龙_价格:1936夺宝符。																	
$QuanMingDuoBao_ItemList[16, 3] = "102105536 500 116080009 5000";     //16号第4场   商品1:秦皇时装(女)_价格:500夺宝符。  商品2:天工开物(九)_价格:5000夺宝符。																	
$QuanMingDuoBao_ItemList[16, 4] = "105101122 25 105101221 10";        //16号第5场   商品1:三阶精炼石礼盒_价格:25夺宝符。  商品2:三阶涅槃石锦盒_价格:10夺宝符。																	

$QuanMingDuoBao_ItemList[17, 0] = "105090414 25 105101221 10";        //17号第1场   商品1:五级宝石合成卷_价格:25夺宝符。  商品2:三阶涅槃石锦盒_价格:10夺宝符。																	
$QuanMingDuoBao_ItemList[17, 1] = "105101780 30 110020005 792";       //17号第2场   商品1:星界石锦盒(中)_价格:30夺宝符。  商品2:体力宝石_价格:792夺宝符。																	
$QuanMingDuoBao_ItemList[17, 2] = "105180154 660 102105515 555";      //17号第3场   商品1:宝石随机礼包(5级)_价格:660夺宝符。  商品2:无忧仙袍(女)_价格:555夺宝符。																	
$QuanMingDuoBao_ItemList[17, 3] = "119013023 1136 102105015 555";     //17号第4场   商品1:蝠王_价格:1136夺宝符。  商品2:无忧仙袍(男)_价格:555夺宝符。																	
$QuanMingDuoBao_ItemList[17, 4] = "105101221 10 105101786 50";        //17号第5场   商品1:三阶涅槃石锦盒_价格:10夺宝符。  商品2:二阶星魂珠(中)_价格:50夺宝符。																	

$QuanMingDuoBao_ItemList[18, 0] = "105090414 25 105101704 100";       //18号第1场   商品1:五级宝石合成卷_价格:25夺宝符。  商品2:2.5倍福袋(小)_价格:100夺宝符。																	
$QuanMingDuoBao_ItemList[18, 1] = "112010014 100 105101780 30";       //18号第2场   商品1:28格乾坤袋_价格:100夺宝符。  商品2:星界石锦盒(中)_价格:30夺宝符。																	
$QuanMingDuoBao_ItemList[18, 2] = "102105518 300 119013032 1136";     //18号第3场   商品1:祥龙(女)_价格:300夺宝符。  商品2:天马_价格:1136夺宝符。																	
$QuanMingDuoBao_ItemList[18, 3] = "102105018 300 105180153 125";      //18号第4场   商品1:祥龙(男)_价格:300夺宝符。  商品2:宝石随机礼包(4级)_价格:125夺宝符。																	
$QuanMingDuoBao_ItemList[18, 4] = "105101785 10 105101122 25";        //18号第5场   商品1:二阶星魂珠(小)_价格:10夺宝符。  商品2:三阶精炼石礼盒_价格:25夺宝符。																	

$QuanMingDuoBao_ItemList[19, 0] = "105101738 50 105101743 6";         //19号第1场   商品1:归元符福袋(中)_价格:50夺宝符。  商品2:答题双倍得分卡福袋(小)_价格:6夺宝符。																	
$QuanMingDuoBao_ItemList[19, 1] = "110030104 150 105101749 100";      //19号第2场   商品1:治疗宝石_价格:150夺宝符。  商品2:随机商店刷新令福袋(小)_价格:100夺宝符。																	
$QuanMingDuoBao_ItemList[19, 2] = "110030044 375 102105019 300";      //19号第3场   商品1:暴击宝石_价格:375夺宝符。  商品2:名门礼服(男)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[19, 3] = "116060108 875 102105519 300";      //19号第4场   商品1:8级造化神石_价格:875夺宝符。  商品2:名门礼服(女)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[19, 4] = "105101758 10 105101122 25";        //19号第5场   商品1:传音喇叭福袋(小)_价格:10夺宝符。  商品2:三阶精炼石礼盒_价格:25夺宝符。																	

$QuanMingDuoBao_ItemList[20, 0] = "105101738 50 105101704 100";       //20号第1场   商品1:归元符福袋(中)_价格:50夺宝符。  商品2:2.5倍福袋(小)_价格:100夺宝符。																	
$QuanMingDuoBao_ItemList[20, 1] = "112010014 100 110030104 150";      //20号第2场   商品1:28格乾坤袋_价格:100夺宝符。  商品2:治疗宝石_价格:150夺宝符。																	
$QuanMingDuoBao_ItemList[20, 2] = "102105029 300 116060108 875";      //20号第3场   商品1:侠之锦衣(男)_价格:300夺宝符。  商品2:8级造化神石_价格:875夺宝符。																	
$QuanMingDuoBao_ItemList[20, 3] = "102105529 300 105180083 250";      //20号第4场   商品1:侠之锦衣(女)_价格:300夺宝符。  商品2:玄兵宝石随机礼包(4级)_价格:250夺宝符。																	
$QuanMingDuoBao_ItemList[20, 4] = "105101758 10 105101747 16";        //20号第5场   商品1:传音喇叭福袋(小)_价格:10夺宝符。  商品2:悬赏刷新令福袋(中)_价格:16夺宝符。																	

$QuanMingDuoBao_ItemList[21, 0] = "116060003 50 105101737 10";        //21号第1场   商品1:鸿运石_价格:50夺宝符。  商品2:归元符福袋(小)_价格:10夺宝符。																	
$QuanMingDuoBao_ItemList[21, 1] = "105101750 500 105105037 100";      //21号第2场   商品1:随机商店刷新令福袋(中)_价格:500夺宝符。  商品2:10000元宝兑换券_价格:100夺宝符。																	
$QuanMingDuoBao_ItemList[21, 2] = "105105305 1000 102105530 300";     //21号第3场   商品1:钻石_价格:1000夺宝符。  商品2:部落达人(女）_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[21, 3] = "119013033 1136 102105030 300";     //21号第4场   商品1:冰蜻蜓_价格:1136夺宝符。  商品2:部落达人(男)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[21, 4] = "105101657 25 105101747 16";        //21号第5场   商品1:一沓回城卷_价格:25夺宝符。  商品2:悬赏刷新令福袋(中)_价格:16夺宝符。																	

$QuanMingDuoBao_ItemList[22, 0] = "105180093 125 116060003 50";       //22号第1场   商品1:绿宝石随机礼包(4级)_价格:125夺宝符。  商品2:鸿运石_价格:50夺宝符。																	
$QuanMingDuoBao_ItemList[22, 1] = "105101749 100 105101656 25";       //22号第2场   商品1:随机商店刷新令福袋(小)_价格:100夺宝符。  商品2:一沓随机卷轴_价格:25夺宝符。																	
$QuanMingDuoBao_ItemList[22, 2] = "102105532 300 105105305 1000";     //22号第3场   商品1:机车时尚(女)_价格:300夺宝符。  商品2:钻石_价格:1000夺宝符。																	
$QuanMingDuoBao_ItemList[22, 3] = "102105032 300 116080009 5000";     //22号第4场   商品1:机车时尚(男)_价格:300夺宝符。  商品2:天工开物(九)_价格:5000夺宝符。																	
$QuanMingDuoBao_ItemList[22, 4] = "105105130 300 112020006 50";       //22号第5场   商品1:300金币兑换券_价格:300夺宝符。  商品2:仓库扩展包24格_价格:50夺宝符。																	

$QuanMingDuoBao_ItemList[23, 0] = "105105130 300 105101656 25";       //23号第1场   商品1:300金币兑换券_价格:300夺宝符。  商品2:一沓随机卷轴_价格:25夺宝符。																	
$QuanMingDuoBao_ItemList[23, 1] = "105101704 100 110020005 792";      //23号第2场   商品1:2.5倍福袋(小)_价格:100夺宝符。  商品2:体力宝石_价格:792夺宝符。																	
$QuanMingDuoBao_ItemList[23, 2] = "110030045 1980 102105034 300";     //23号第3场   商品1:暴击宝石_价格:1980夺宝符。  商品2:DJ(男)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[23, 3] = "110030134 375 102105534 300";      //23号第4场   商品1:会心一击伤害_价格:375夺宝符。  商品2:DJ(女)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[23, 4] = "112010014 100 116060107 175";      //23号第5场   商品1:28格乾坤袋_价格:100夺宝符。  商品2:7级造化神石_价格:175夺宝符。																	

$QuanMingDuoBao_ItemList[24, 0] = "105105032 50 116060106 35";        //24号第1场   商品1:5000元宝兑换券_价格:50夺宝符。  商品2:6级造化神石_价格:35夺宝符。																	
$QuanMingDuoBao_ItemList[24, 1] = "105180153 125 116060107 175";      //24号第2场   商品1:宝石随机礼包(4级)_价格:125夺宝符。  商品2:7级造化神石_价格:175夺宝符。																	
$QuanMingDuoBao_ItemList[24, 2] = "102105036 500 119013069 1936";     //24号第3场   商品1:秦皇时装(男)_价格:500夺宝符。  商品2:冰龙_价格:1936夺宝符。																	
$QuanMingDuoBao_ItemList[24, 3] = "102105536 500 116080008 1000";     //24号第4场   商品1:秦皇时装(女)_价格:500夺宝符。  商品2:天工开物(八)_价格:1000夺宝符。																	
$QuanMingDuoBao_ItemList[24, 4] = "105101657 25 105180073 125";       //24号第5场   商品1:一沓回城卷_价格:25夺宝符。  商品2:红宝石随机礼包(4级)_价格:125夺宝符。																	

$QuanMingDuoBao_ItemList[25, 0] = "105101122 25 105105033 60";        //25号第1场   商品1:三阶精炼石礼盒_价格:25夺宝符。  商品2:6000元宝兑换券_价格:60夺宝符。																	
$QuanMingDuoBao_ItemList[25, 1] = "116060108 875 116060106 35";       //25号第2场   商品1:8级造化神石_价格:875夺宝符。  商品2:6级造化神石_价格:35夺宝符。																	
$QuanMingDuoBao_ItemList[25, 2] = "102105515 555 110030044 375";      //25号第3场   商品1:无忧仙袍(女)_价格:555夺宝符。  商品2:暴击宝石_价格:375夺宝符。																	
$QuanMingDuoBao_ItemList[25, 3] = "102105015 555 119013074 1936";     //25号第4场   商品1:无忧仙袍(男)_价格:555夺宝符。  商品2:烈焰独角兽_价格:1936夺宝符。																	
$QuanMingDuoBao_ItemList[25, 4] = "116070002 250 105101022 25";       //25号第5场   商品1:完璧符_价格:250夺宝符。  商品2:三阶重铸石礼包_价格:25夺宝符。																	

$QuanMingDuoBao_ItemList[26, 0] = "105101022 25 105101743 6";         //26号第1场   商品1:三阶重铸石礼包_价格:25夺宝符。  商品2:答题双倍得分卡福袋(小)_价格:6夺宝符。																	
$QuanMingDuoBao_ItemList[26, 1] = "105180083 250 105101749 100";      //26号第2场   商品1:玄兵宝石随机礼包(4级)_价格:250夺宝符。  商品2:随机商店刷新令福袋(小)_价格:100夺宝符。																	
$QuanMingDuoBao_ItemList[26, 2] = "119013028 1936 102105518 300";     //26号第3场   商品1:火凤凰_价格:1936夺宝符。  商品2:祥龙(女)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[26, 3] = "116060108 875 102105018 300";      //26号第4场   商品1:8级造化神石_价格:875夺宝符。  商品2:祥龙(男)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[26, 4] = "105105131 400 116070002 250";      //26号第5场   商品1:400金币兑换券_价格:400夺宝符。  商品2:完璧符_价格:250夺宝符。																	

$QuanMingDuoBao_ItemList[27, 0] = "105101788 20 116080007 200";       //27号第1场   商品1:三阶星魂珠(小)_价格:20夺宝符。  商品2:天工开物(七)_价格:200夺宝符。																	
$QuanMingDuoBao_ItemList[27, 1] = "105101657 25 105101704 100";       //27号第2场   商品1:一沓回城卷_价格:25夺宝符。  商品2:2.5倍福袋(小)_价格:100夺宝符。																	
$QuanMingDuoBao_ItemList[27, 2] = "102105019 300 116080008 1000";     //27号第3场   商品1:名门礼服(男)_价格:300夺宝符。  商品2:天工开物(八)_价格:1000夺宝符。																	
$QuanMingDuoBao_ItemList[27, 3] = "102105519 300 110030054 375";      //27号第4场   商品1:名门礼服(女)_价格:300夺宝符。  商品2:暴击伤害宝石_价格:375夺宝符。																	
$QuanMingDuoBao_ItemList[27, 4] = "105101737 10 105105131 400";       //27号第5场   商品1:归元符福袋(小)_价格:10夺宝符。  商品2:400金币兑换券_价格:400夺宝符。																	

$QuanMingDuoBao_ItemList[28, 0] = "105090414 25 105101737 10";        //28号第1场   商品1:五级宝石合成卷_价格:25夺宝符。  商品2:归元符福袋(小)_价格:10夺宝符。																	
$QuanMingDuoBao_ItemList[28, 1] = "116080007 200 105101780 30";       //28号第2场   商品1:天工开物(七)_价格:200夺宝符。  商品2:星界石锦盒(中)_价格:30夺宝符。																	
$QuanMingDuoBao_ItemList[28, 2] = "110030124 375 102105029 300";      //28号第3场   商品1:会心一击防御_价格:375夺宝符。  商品2:侠之锦衣(男)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[28, 3] = "116060109 4375 102105529 300";     //28号第4场   商品1:9级造化神石_价格:4375夺宝符。  商品2:侠之锦衣(女)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[28, 4] = "105101788 20 105101737 10";        //28号第5场   商品1:三阶星魂珠(小)_价格:20夺宝符。  商品2:归元符福袋(小)_价格:10夺宝符。																	

$QuanMingDuoBao_ItemList[29, 0] = "105101743 6 105105034 70";         //29号第1场   商品1:答题双倍得分卡福袋(小)_价格:6夺宝符。  商品2:7000元宝兑换券_价格:70夺宝符。																	
$QuanMingDuoBao_ItemList[29, 1] = "105101749 100 116060106 35";       //29号第2场   商品1:随机商店刷新令福袋(小)_价格:100夺宝符。  商品2:6级造化神石_价格:35夺宝符。																	
$QuanMingDuoBao_ItemList[29, 2] = "102105530 300 110020114 500";      //29号第3场   商品1:部落达人(女）_价格:300夺宝符。  商品2:幸运宝石_价格:500夺宝符。																	
$QuanMingDuoBao_ItemList[29, 3] = "102105030 300 119013034 1136";     //29号第4场   商品1:部落达人(男)_价格:300夺宝符。  商品2:赤磷金鱼_价格:1136夺宝符。																	
$QuanMingDuoBao_ItemList[29, 4] = "110030114 375 105101780 30";       //29号第5场   商品1:会心一击_价格:375夺宝符。  商品2:星界石锦盒(中)_价格:30夺宝符。																	

$QuanMingDuoBao_ItemList[30, 0] = "105101779 6 105101704 100";        //30号第1场   商品1:星界石锦盒(小)_价格:6夺宝符。  商品2:2.5倍福袋(小)_价格:100夺宝符。																	
$QuanMingDuoBao_ItemList[30, 1] = "105180083 250 112010014 100";      //30号第2场   商品1:玄兵宝石随机礼包(4级)_价格:250夺宝符。  商品2:28格乾坤袋_价格:100夺宝符。																	
$QuanMingDuoBao_ItemList[30, 2] = "110030144 375 102105532 300";      //30号第3场   商品1:会心伤害减免_价格:375夺宝符。  商品2:机车时尚(女)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[30, 3] = "116070002 250 102105032 300";      //30号第4场   商品1:完璧符_价格:250夺宝符。  商品2:机车时尚(男)_价格:300夺宝符。																	
$QuanMingDuoBao_ItemList[30, 4] = "116060106 35 105090414 25";        //30号第5场   商品1:6级造化神石_价格:35夺宝符。  商品2:五级宝石合成卷_价格:25夺宝符。																	

$QuanMingDuoBao_ItemList[31, 0] = "112010014 100 105101737 10";       //31号第1场   商品1:28格乾坤袋_价格:100夺宝符。  商品2:归元符福袋(小)_价格:10夺宝符。																	
$QuanMingDuoBao_ItemList[31, 1] = "110020005 792 105105032 50";       //31号第2场   商品1:体力宝石_价格:792夺宝符。  商品2:5000元宝兑换券_价格:50夺宝符。																	
$QuanMingDuoBao_ItemList[31, 2] = "102105034 300 110030064 375";      //31号第3场   商品1:DJ(男)_价格:300夺宝符。  商品2:暴击减免宝石_价格:375夺宝符。																	
$QuanMingDuoBao_ItemList[31, 3] = "102105534 300 116060108 875";      //31号第4场   商品1:DJ(女)_价格:300夺宝符。  商品2:8级造化神石_价格:875夺宝符。																	
$QuanMingDuoBao_ItemList[31, 4] = "105101779 6 105105131 400";        //31号第5场   商品1:星界石锦盒(小)_价格:6夺宝符。  商品2:400金币兑换券_价格:400夺宝符。																	

$QuanMingDuoBao_ItemList[32, 0] = "105105128 100 105105128 100";      //32号第1场   商品1:100金币兑换券_价格:100夺宝符。  商品2:100金币兑换券_价格:100夺宝符。																	
$QuanMingDuoBao_ItemList[32, 1] = "105105128 100 105105128 100";      //32号第2场   商品1:100金币兑换券_价格:100夺宝符。  商品2:100金币兑换券_价格:100夺宝符。																	
$QuanMingDuoBao_ItemList[32, 2] = "105105128 100 105105128 100";      //32号第3场   商品1:100金币兑换券_价格:100夺宝符。  商品2:100金币兑换券_价格:100夺宝符。																	
$QuanMingDuoBao_ItemList[32, 3] = "105105128 100 105105128 100";      //32号第4场   商品1:100金币兑换券_价格:100夺宝符。  商品2:100金币兑换券_价格:100夺宝符。																	
$QuanMingDuoBao_ItemList[32, 4] = "105105128 100 105105128 100";      //32号第5场   商品1:100金币兑换券_价格:100夺宝符。  商品2:100金币兑换券_价格:100夺宝符。																	


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
//■■■■■■■■■■■【全民夺宝相关】■■■■■■■■■■■■■■■■



//■■■■【挖矿】■■■■【杂矿计算函数】■■■■■■■
function GetOne_HeZuiChu_ZaKuang(%Player, %Optype)
{
	%Level = %Player.GetLevel();
	%Level = %Level - %Level%10;
	//echo( "杂矿计算函数%Level===" @ %Level );
	switch (%Optype)
	{
		case 1:
			switch (%Level)
			{
				case 40:  %ItemID =106020001;//铜矿	
				case 50:  %ItemID =106020002;//铁矿	
				case 60:  %ItemID =106020003;//银矿	
				case 70:  %ItemID =106020004;//金矿	
				case 80:  %ItemID =106020005;//黑铁矿	
				case 90:  %ItemID =106020006;//秘银矿	
				case 100: %ItemID =106020007;//魔金矿	
				case 110: %ItemID =106020008;//精金矿	
				case 120: %ItemID =106020009;//紫金矿	
				case 130: %ItemID =106020010;//耀金矿	
				default:  %ItemID =106020001;//耀金矿	
			}
		case 2:
			switch (%Level)
			{
				case 40:  %ItemID =106020501;//锡石	
				case 50:  %ItemID =106020502;//铅石	
				case 60:  %ItemID =106020503;//锌石	
				case 70:  %ItemID =106020504;//晶石	
				case 80:  %ItemID =106020505;//黑钨石	
				case 90:  %ItemID =106020506;//方玉石	
				case 100: %ItemID =106020507;//霞辉石	
				case 110: %ItemID =106020508;//翡翠石	
				case 120: %ItemID =106020509;//翡翠石	
				case 130: %ItemID =106020510;//翡翠石	
				default:  %ItemID =106020001;//翡翠石	
			}
	}
	return %ItemID;
}

function GetOne_HeZuiChu_KuangDing(%Player, %Optype)
{
	%Level = %Player.GetLevel();
	%Level = %Level - %Level%10;
	//echo( "杂矿计算函数%Level===" @ %Level );
	switch (%Optype)
	{
		case 1:
			switch (%Level)
			{
				case 40:  %ItemID =106020101;//铜矿锭
				case 50:  %ItemID =106020102;//铁矿锭
				case 60:  %ItemID =106020103;//银矿锭
				case 70:  %ItemID =106020104;//金矿锭
				case 80:  %ItemID =106020105;//黑铁矿锭
				case 90:  %ItemID =106020106;//秘银矿锭
				case 100:  %ItemID =106020107;//魔金矿锭
				case 110: %ItemID =106020108;//精金矿锭
				case 120: %ItemID =106020109;//紫金矿锭
				case 130: %ItemID =106020110;//耀金矿锭
				default:  %ItemID =106020101;//铜矿锭
			}
		case 2:
			switch (%Level)
			{
				case 40:  %ItemID =106020201;//精炼·铜矿锭
				case 50:  %ItemID =106020202;//精炼·铁矿锭
				case 60:  %ItemID =106020203;//精炼·银矿锭
				case 70:  %ItemID =106020204;//精炼·金矿锭
				case 80:  %ItemID =106020205;//精炼·黑铁矿锭
				case 90:  %ItemID =106020206;//精炼·秘银矿锭
				case 100:  %ItemID =106020207;//精炼·魔金矿锭
				case 110: %ItemID =106020208;//精炼·精金矿锭
				case 120: %ItemID =106020209;//精炼·紫金矿锭
				case 130: %ItemID =106020210;//精炼·耀金矿锭
				default:  %ItemID =106020201;//精炼·铜矿锭	
			}
	}
	return %ItemID;
}

//■■■■【挖矿】■■■■【杂矿计算函数】■■■■■■■



//■■■■【夺宝】■■■■【返回消耗道具】■■■■■■■
function GetIndianaItem()
{
	return 105106004;
}
//■■■■【夺宝】■■■■【返回消耗道具】■■■■■■■


//■■■■【声望】■■■■【设置和获取声望】■■■■■■
//AddPrestige(%Player, $PrestigeStageActID[1, 1], 123);
$PrestigeStageActID[1, 1] = 4105; $PrestigeStageActName[4105] = "战门声望";
$PrestigeStageActID[1, 2] = 4106; $PrestigeStageActName[4106] = "法门声望";
$PrestigeStageActID[1, 3] = 4107; $PrestigeStageActName[4107] = "道门声望";
$PrestigeStageActID[1, 4] = 4108; $PrestigeStageActName[4108] = "刺门声望";
$PrestigeStageActID[1, 5] = 4109; $PrestigeStageActName[4109] = "弓门声望";

$PrestigeStageActID[2, 1] = 4110; $PrestigeStageActName[4110] = "望仙镇声望";
$PrestigeStageActID[2, 2] = 4111; $PrestigeStageActName[4111] = "白虎寨声望";
$PrestigeStageActID[2, 3] = 4112; $PrestigeStageActName[4112] = "泽云度声望";
$PrestigeStageActID[2, 4] = 4113; $PrestigeStageActName[4113] = "蛮荒神殿声望";
$PrestigeStageActID[2, 5] = 4114; $PrestigeStageActName[4114] = "香海禅林声望";
$PrestigeStageActID[2, 6] = 4115; $PrestigeStageActName[4115] = "昆仑废墟声望";

$PrestigeStageActID[3, 1] = 4116; $PrestigeStageActName[4116] = "文采值";
$PrestigeStageActID[3, 2] = 4117; $PrestigeStageActName[4117] = "忠义值";
$PrestigeStageActID[3, 3] = 4118; $PrestigeStageActName[4118] = "师徒值";
$PrestigeStageActID[3, 4] = 4119; $PrestigeStageActName[4119] = "鲜花值";
$PrestigeStageActID[3, 5] = 4120; $PrestigeStageActName[4120] = "绿叶值";
$PrestigeStageActID[3, 6] = 4121; $PrestigeStageActName[4121] = "狭义值";
$PrestigeStageActID[3, 7] = 4122; $PrestigeStageActName[4122] = "挑战首领";


$PrestigeStage[1, 1] ="碌碌无名 10000 泯然众人 50000 后生典范 300000 脱颖而出 580000 劳苦功高 1500000 众望所归 2000000 锋芒毕露 3000000 群雄慑服 6000000 寂寞英雄 7500000 无量圣王 15000000";//战门
$PrestigeStage[1, 2] ="碌碌无名 10000 泯然众人 50000 后生典范 300000 脱颖而出 580000 劳苦功高 1500000 众望所归 2000000 锋芒毕露 3000000 群雄慑服 6000000 寂寞英雄 7500000 无量圣王 15000000";//法门
$PrestigeStage[1, 3] ="碌碌无名 10000 泯然众人 50000 后生典范 300000 脱颖而出 580000 劳苦功高 1500000 众望所归 2000000 锋芒毕露 3000000 群雄慑服 6000000 寂寞英雄 7500000 无量圣王 15000000";//道门
$PrestigeStage[1, 4] ="碌碌无名 10000 泯然众人 50000 后生典范 300000 脱颖而出 580000 劳苦功高 1500000 众望所归 2000000 锋芒毕露 3000000 群雄慑服 6000000 寂寞英雄 7500000 无量圣王 15000000";//刺门
$PrestigeStage[1, 5] ="碌碌无名 10000 泯然众人 50000 后生典范 300000 脱颖而出 580000 劳苦功高 1500000 众望所归 2000000 锋芒毕露 3000000 群雄慑服 6000000 寂寞英雄 7500000 无量圣王 15000000";//弓门

$PrestigeStage[2, 1] ="碌碌无名 10000 泯然众人 50000 后生典范 300000 脱颖而出 580000 劳苦功高 1500000 众望所归 2000000 锋芒毕露 3000000 群雄慑服 6000000 寂寞英雄 7500000 无量圣王 15000000";//望仙镇
$PrestigeStage[2, 2] ="碌碌无名 10000 泯然众人 50000 后生典范 300000 脱颖而出 580000 劳苦功高 1500000 众望所归 2000000 锋芒毕露 3000000 群雄慑服 6000000 寂寞英雄 7500000 无量圣王 15000000";//白虎寨
$PrestigeStage[2, 3] ="碌碌无名 10000 泯然众人 50000 后生典范 300000 脱颖而出 580000 劳苦功高 1500000 众望所归 2000000 锋芒毕露 3000000 群雄慑服 6000000 寂寞英雄 7500000 无量圣王 15000000";//泽云度
$PrestigeStage[2, 4] ="碌碌无名 10000 泯然众人 50000 后生典范 300000 脱颖而出 580000 劳苦功高 1500000 众望所归 2000000 锋芒毕露 3000000 群雄慑服 6000000 寂寞英雄 7500000 无量圣王 15000000";//蛮荒神殿
$PrestigeStage[2, 5] ="碌碌无名 10000 泯然众人 50000 后生典范 300000 脱颖而出 580000 劳苦功高 1500000 众望所归 2000000 锋芒毕露 3000000 群雄慑服 6000000 寂寞英雄 7500000 无量圣王 15000000";//香海禅林
$PrestigeStage[2, 6] ="碌碌无名 10000 泯然众人 50000 后生典范 300000 脱颖而出 580000 劳苦功高 1500000 众望所归 2000000 锋芒毕露 3000000 群雄慑服 6000000 寂寞英雄 7500000 无量圣王 15000000";//昆仑废墟

$PrestigeStage[3, 1] ="目不识丁 10000 胸无点墨 50000 才疏学浅 300000 才识过人 580000 饱学之士 1500000 才惊四座 2000000 博览古今 3000000 满腹经纶 6000000 风流儒雅 7500000 鸿儒硕学 15000000";//文采
$PrestigeStage[3, 2] ="山野草民 10000 拳拳赤子 50000 仗义疏财 300000 不避斧钺 580000 一寸丹心 1500000 柔情侠骨 2000000 矢忠不二 3000000 碧血丹心 6000000 义薄云天 7500000 国士无双 15000000";//忠义
$PrestigeStage[3, 3] ="一字之师 10000 为人师表 50000 有教无类 300000 教无常师 580000 百年树人 1500000 德高望重 2000000 桃李芬芳 3000000 春风化雨 6000000 桃李满天下 7500000 先圣先师 15000000";//师徒
$PrestigeStage[3, 4] ="眉清目秀 10000 小家碧玉 50000 亭亭玉立 300000 温文尔雅 580000 花容月貌 1500000 千娇百媚 2000000 惊鸿艳影 3000000 倾城佳人 6000000 国色天香 7500000 倾国倾城 15000000";//鲜花
$PrestigeStage[3, 5] ="貌似端庄 10000 仪态万方 50000 逸群之才 300000 玉树临风 580000 清新俊逸 1500000 风流人物 2000000 梦中情人 3000000 器宇轩昂 6000000 魅力无限 7500000 耀世巨星 15000000";//绿叶
$PrestigeStage[3, 6] ="肝胆相照 10000 拳拳赤子 50000 仗义疏财 300000 不避斧钺 580000 一寸丹心 1500000 柔情侠骨 2000000 矢忠不二 3000000 碧血丹心 6000000 义薄云天 7500000 国士无双 15000000";//狭义
$PrestigeStage[3, 7] ="猎妖游侠 10000 遮风挡雨 50000 护城佑民 300000 沉烽静柝 580000 魅影游侠 1500000 屠魔侠客 2000000 广厦之荫 3000000 人族护法 6000000 光之守卫 7500000 人族守望者 15000000";//挑战首领


function GetPrestige(%Player, %Maintype, %Subtype)//获取当前声望
{
	%Act = $PrestigeStageActID[%Maintype, %Subtype];
	%Act0 = GetAct(%Player, %Act, 0) * 10000;
	%Act1 = GetAct(%Player, %Act, 1) * 1;

	//echo("%aAct  ===  " @ %Act);
	//echo("%aAct0 ===  " @ %Act0);
	//echo("%aAct1 ===  " @ %Act1);
	return %Act0 + %Act1;
}

function GetPrestigeStageNumber(%Player, %Maintype, %Subtype)//当前阶段声望总值
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

function GetPrestigeStageName(%Player, %Maintype, %Subtype)//当前阶段声望名称
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

function AddPrestige(%Player, %ActivityID, %Val)//增加声望值
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
				case 1://男
					SptRankUpLoadValue($eTopType_MaleFlower, %PlayerID, %Val, 0);//上传排行榜
				case 2://女
					SptRankUpLoadValue($eTopType_Flower, %PlayerID, %Val, 0);//上传排行榜
			}
		case 4120:
			SptRankUpLoadValue($eTopType_DonateFlower, %PlayerID, %Val, 0);//绿叶值上传排行榜
		case 4116: 
			SptRankUpLoadValue($eTopType_LiteraryGrace, %PlayerID, %Val, 0);//文采值上传排行榜
		case 4105:SptRankUpLoadValue($eTopType_WarriorPrestige, %PlayerID, %Val, 0);//战门声望上传排行榜
		case 4106:SptRankUpLoadValue($eTopType_MagePrestige, %PlayerID, %Val, 0);//法门声望上传排行榜
		case 4107:SptRankUpLoadValue($eTopType_TaoistPrestige, %PlayerID, %Val, 0);//道门声望上传排行榜
		case 4108:SptRankUpLoadValue($eTopType_AssassinPrestige, %PlayerID, %Val, 0);//刺门声望上传排行榜
		case 4109:SptRankUpLoadValue($eTopType_ArrowPrestige, %PlayerID, %Val, 0);//弓门声望上传排行榜
		case 4110:SptRankUpLoadValue($eTopType_MapPrestige_1101, %PlayerID, %Val, 0);//望仙镇声望上传排行榜
		case 4111:SptRankUpLoadValue($eTopType_MapPrestige_1102, %PlayerID, %Val, 0);//白虎寨声望上传排行榜
		case 4112:SptRankUpLoadValue($eTopType_MapPrestige_1103, %PlayerID, %Val, 0);//泽云度声望上传排行榜
		case 4113:SptRankUpLoadValue($eTopType_MapPrestige_1104, %PlayerID, %Val, 0);//蛮荒神殿声望上传排行榜
		case 4114:SptRankUpLoadValue($eTopType_MapPrestige_1105, %PlayerID, %Val, 0);//香海禅林声望上传排行榜
		case 4115:SptRankUpLoadValue($eTopType_MapPrestige_1106, %PlayerID, %Val, 0);//昆仑废墟声望上传排行榜
	}

	%Text = "<t>您的</t>" @ $PrestigeStageActName[%ActivityID] @ "<t>增加了：</t>" @ %Val @ "<t>点，当前拥有：</t>" @ %Act0 * 10000 + %Act1 @ "<t>点。</t>";
	SendOneChatMessage($chatMsg_Person, %Text, %Player);
	
	//putout("当前声望值===" @ %Player.GetActivity(%ActivityID));
}

//■■■■【声望】■■■■【设置和获取声望】■■■■■■

//■■■■【仙缘解签】■■■■【返回活动开关】■■■■■
function GetLiShangWangLaibActive()
{
	return $SL_LiShangWangLai_State_bActive;
}
//■■■■【仙缘解签】■■■■【返回活动开关】■■■■■

//■■■■【祈愿豪礼】■■■■【返回活动开关】■■■■■
function GetQiYuanHaoLibActive()
{
	return $SL_QiYuanHaoLi_State_bActive;
}
//■■■■【祈愿豪礼】■■■■【返回活动开关】■■■■■


//■■■■【全民夺宝】■■■■【中奖触发】■■■■■■■
//ShowWorldChatMsg(50000002   , trg   ,116080010);
function ShowWorldChatMsg(%PlayerID, %PlayerName, %ItemID)
{
	if (GetZoneid() != 1001)
		return;
	//echo("■■【全民夺宝】■■■■【中奖触发】■■■■■■==" @ %PlayerID @ "    "@ %PlayerName @ "   " @ %ItemID);
	%Player = SptGetPlayer(%PlayerID);

	%PlayerName1 = "<l i='"@ %PlayerName @ " "@ %PlayerID @ "' t='name' />";
	%PlayerName2 = $Get_Dialog_GeShi[60006] @ "『" @ %PlayerName @ "』</t>";
	%ItemName1 = GetItemName(%ItemID, 1);
	%ItemName2 = GetItemName(%ItemID, 2);
	%HuoDongMingCheng1 = GetHuoDongName("全民夺宝", 1);
	%HuoDongMingCheng2 = GetHuoDongName("全民夺宝", 2);

	%Text1 = "<t>好运天降，</t>" @ %PlayerName1 @ "<t>参与</t>" @ %HuoDongMingCheng1 @ "<t>活动，获得了</t>" @ %ItemName1 @ "<t>奖励，真是羡煞众修士！</t>";
	%Text2 = "<t>好运天降，</t>" @ %PlayerName2 @ "<t>参与</t>" @ %HuoDongMingCheng2 @ "<t>活动，获得了</t>" @ %ItemName2 @ "<t>奖励，真是羡煞众修士！</t>";
	SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
	SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
}
//■■■■【全民夺宝】■■■■【中奖触发】■■■■■■■



//■■■■■■■■■■■【特权和尊享服务】■■■■■■■■■■■■■■■■■
//获得某个特权的等级
function VIP_getTequanLv(%Player, %type)
{
	if (%Player.GetVipTimer(%type)*1 < 1)
		return 0;
	%activeID = 4123 + %type;
	return GetWord(%Player.GetActivity(%activeID), 0)*1;
}

//获得某个特权的剩余时间
function VIP_getTequanTime(%Player, %type)
{
	return %Player.GetVipTimer(%type);
}

//获得某个特权的条目总数
function VIP_getTequanListCnt(%Player, %type)
{
	if (%type*1 == 0) return 8;
	else if (%type*1 == 1) return 14;
	else return 0;
}

//畅爽特权：获得某个特权具体的数值
function VIP_getNowTequanLvMaxCnt(%Player, %Index)
{
	if (%Player.isVip(0) <= 0)
		return getEnjoyPrerogativeText(0, %Index);

	%Lv = VIP_getTequanLv(%Player, 0);
	if (%Lv < 1)
		return 0;

	switch (%Index)
	{
		case 1: return getEnjoyPrerogativeText(%Lv+1, %Index);	//星界传送点额外可记录
		case 2: return getEnjoyPrerogativeText(%Lv+1, %Index);	//星界传送：单张地图可记录坐标总数
		case 3: return getEnjoyPrerogativeText(%Lv+1, %Index);	//随机商店刷新次数
		case 4: return getEnjoyPrerogativeText(%Lv+1, %Index);	//聚宝盆可参与次数
		case 6: return getEnjoyPrerogativeText(%Lv+1, %Index);	//悬赏免费刷新次数
		case 7: return getEnjoyPrerogativeText(%Lv+1, %Index);	//每日押镖次数
		case 8: return getEnjoyPrerogativeText(%Lv+1, %Index);	//
	}

	return 0;
}

//获得某个特权的购买/升级/续费的费用
//%type特权类型
//%operate：1购买、2升级、3续费
//%Days:天数
//%Lv:等级，1白银、2黄金、3白金
function VIP_getTequanCost(%Player, %type, %Lv, %Days, %operate)
{
	//7天：特权类型，等级，费用
	%cost7days[0, 1] = 700; %cost7days[0, 2] = 1400; %cost7days[0, 3] = 2800;
	%cost7days[1, 1] = 1400; %cost7days[1, 2] = 2800; %cost7days[1, 3] = 5600;

	//30天：特权类型，等级，费用
	%cost30days[0, 1] = 2700; %cost30days[0, 2] = 5400; %cost30days[0, 3] = 10800;
	%cost30days[1, 1] = 5400; %cost30days[1, 2] = 10800; %cost30days[1, 3] = 21600;

	switch (%operate)
	{
		case 1:
			if (%Days == 7) return %cost7days[%type, %Lv];
			else return %cost30days[%type, %Lv];

		case 2:
			%activeID = 4123 + %type;
			%aveCost1 = Mceil(%cost7days[%type, GetWord(%Player.GetActivity(%activeID), 0)*1] / 7);	//升级前的每日单价
			%aveCost2 = Mceil(%cost7days[%type, %Lv] / 7);	//将要升级的每日单价
			%leftDays = Mceil(%Player.GetVipTimer(%type) / 86400);
			return %leftDays * (%aveCost2 - %aveCost1);

		case 3:
			if (%Days == 7) return %cost7days[%type, %Lv];
			else return %cost30days[%type, %Lv];

		default: echo("VIP_getTequanCost出错！"); return 999999;
	}

}

//畅玩特权：条目显示
function getEnjoyPrerogativeText(%type, %index)
{
	%textList[1] = "6 ;星界传送点额外可记录：      ;10;15;20";
	%textList[2] = "2 ;星界传送单张地图可记录坐标：;3 ;4 ;5 ";
	%textList[3] = "1 ;随机商店每日免费刷新次数：  ;3 ;4 ;5 ";
	%textList[4] = "3 ;聚宝盆可参与次数：          ;5 ;7 ;10";
	%textList[5] = "0 ;降低受伤下坐骑概率：        ;2%;4%;6%";
	%textList[6] = "3 ;悬赏免费刷新次数：          ;5 ;7 ;10";
	%textList[7] = "5 ;每日押镖次数：              ;6 ;7 ;8 ";
	%textList[8] = "10;每日藏宝图参与次数：        ;15;20;30";


	%button4 = "<c cid='" @ Get_TraceButton() @ "'cmd='\"OpenOrCloseCornucopiaWnd();\",\"" @ $Get_Dialog_GeShi[31414] @ "聚宝盆" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />";

	%shuoming[1] = $Get_Dialog_GeShi[31399]@"星界传送:</t><b/><b/>"@
		$Get_Dialog_GeShi[31401]@"<t>此项特权可提高星界传送记录点的总数，特权等级越高，可记录点数量越多！</t><b/><b/>"@
		$Get_Dialog_GeShi[31406]@"没有特权只能记录 "@GetWord(GetWord(%textList[1], 0, ";"), 0, " ")@" 个点！</t><b/><b/>"@
		"<t>按 </t>"@$Get_Dialog_GeShi[31403]@"M</t><t> 键打开世界地图，点击右下角的 </t>"@$Get_Dialog_GeShi[31403]@"记录当前坐标</t><t> 按钮，可立即记录当前坐标，点击此传送点可立即传送到此处。</t><b/>";

	%shuoming[2] = $Get_Dialog_GeShi[31399]@"星界传送:</t><b/><b/>"@
		$Get_Dialog_GeShi[31401]@"<t>此项特权可提高 </t>"@$Get_Dialog_GeShi[31403]@"单张地图</t><t> 星界传送记录点的数量，特权等级越高，可记录点数量越多！</t><b/><b/>"@
		$Get_Dialog_GeShi[31406]@"没有特权只能记录 "@GetWord(GetWord(%textList[2], 0, ";"), 0, " ")@" 个点！</t><b/><b/>"@
		"<t>按 </t>"@$Get_Dialog_GeShi[31403]@"M</t><t> 键打开世界地图，点击右下角的 </t>"@$Get_Dialog_GeShi[31403]@"记录当前坐标</t><t> 按钮，可立即记录当前坐标，点击此传送点可立即传送到此处。</t><b/>";

	%shuoming[3] = $Get_Dialog_GeShi[31399]@"随机商店:</t><b/><b/>"@
		$Get_Dialog_GeShi[31401]@"<t>此项特权可提高 </t>"@$Get_Dialog_GeShi[31403]@"随机商店</t><t> 每日免费刷新的次数，特权等级越高，每日免费刷新的次数越多！</t><b/><b/>"@
		$Get_Dialog_GeShi[31406]@"没有特权只能免费刷新 "@GetWord(GetWord(%textList[3], 0, ";"), 0, " ")@" 次！</t><b/><b/>"@
		"<t>按 </t>"@$Get_Dialog_GeShi[31403]@"V</t><t> 键打开商城界面，选择 </t>"@$Get_Dialog_GeShi[31403]@"随机商店</t><t> 分页，点击 </t>"@$Get_Dialog_GeShi[31403]@"刷新物品</t><t> 按钮即可刷新商店内的物品。</t><b/>";

	%shuoming[4] = $Get_Dialog_GeShi[31399]@"聚宝盆:</t><b/><b/>"@
		$Get_Dialog_GeShi[31401]@"<t>此项特权可提高 </t>"@$Get_Dialog_GeShi[31403]@"聚宝盆</t><t> 的每日使用次数，特权等级越高，每日使用次数越多！</t><b/><b/>"@
		$Get_Dialog_GeShi[31406]@"没有特权只能使用 "@GetWord(GetWord(%textList[4], 0, ";"), 0, " ")@" 次！</t><b/><b/>"@
		"<t>角色等级达到40级后，在  </t>"@$Get_Dialog_GeShi[31403]@"小地图下方</t><t> 会出现</t>"@%button4@"<t>的按钮，点击此按钮可打开聚宝盆界面，每天耍一下就可以轻松获得大量金币！</t><b/>";

	%shuoming[5] = $Get_Dialog_GeShi[31399]@"永不下马:</t><b/><b/>"@
		$Get_Dialog_GeShi[31401]@"<t>此项特权可降低 </t>"@$Get_Dialog_GeShi[31403]@"受伤下坐骑</t><t>的概率，特权等级越高，受伤时下坐骑的概率越低！</t><b/><b/>"@
		$Get_Dialog_GeShi[31406]@"没有特权将会很容易被打下马！</t><b/><b/>";

	%shuoming[6] = $Get_Dialog_GeShi[31399]@"悬赏缉凶:</t><b/><b/>"@
		$Get_Dialog_GeShi[31401]@"<t>此项特权可增加 </t>"@$Get_Dialog_GeShi[31403]@"悬赏缉凶 </t><t>免费刷新任务的次数，特权等级越高，免费刷新任务的次数越多！</t><b/><b/>"@
		$Get_Dialog_GeShi[31406]@"没有特权只能免费刷新 "@GetWord(GetWord(%textList[6], 0, ";"), 0, " ")@" 次！</t><b/><b/>"@
		"<t>按 </t>"@$Get_Dialog_GeShi[31403]@"Y</t><t> 键打开活动列表界面，选择 </t>"@$Get_Dialog_GeShi[31403]@"常置活动</t><t> 分页，在此分页下可找到 </t>"@$Get_Dialog_GeShi[31403]@"悬赏缉凶</t><t> 活动的详细信息！</t><b/>";

	%shuoming[7] = $Get_Dialog_GeShi[31399]@"每日押镖:</t><b/><b/>"@
		$Get_Dialog_GeShi[31401]@"<t>此项特权可增加 </t>"@$Get_Dialog_GeShi[31403]@"每日押镖</t><t> 活动的每日最大押镖次数，特权等级越高，每日押镖的次数越多！</t><b/><b/>"@
		$Get_Dialog_GeShi[31406]@"没有特权只能押镖 "@GetWord(GetWord(%textList[7], 0, ";"), 0, " ")@" 次！</t><b/><b/>"@
		"<t>按 </t>"@$Get_Dialog_GeShi[31403]@"Y</t><t> 键打开活动列表界面，选择 </t>"@$Get_Dialog_GeShi[31403]@"时段活动</t><t> 分页，在此分页下可找到 </t>"@$Get_Dialog_GeShi[31403]@"每日押镖</t><t> 活动的详细信息！</t><b/>";

	%shuoming[8] = $Get_Dialog_GeShi[31399]@"藏宝图:</t><b/><b/>"@
		$Get_Dialog_GeShi[31401]@"<t>此项特权可增加 </t>"@$Get_Dialog_GeShi[31403]@"藏宝图</t><t> 的每日使用最大数量，特权等级越高，每日可以使用藏宝图的次数越多！</t><b/><b/>"@
		$Get_Dialog_GeShi[31406]@"没有特权每日只能使用 "@GetWord(GetWord(%textList[8], 0, ";"), 0, " ")@" 个藏宝图！</t><b/><b/>";


	if (%type < 5)
		return GetWord(GetWord(%textList[%index], %type, ";"), 0, " ");
	else
		return %shuoming[%index];
}

//尊享特权：条目显示
function getAcerPrerogativeText(%Player, %type, %index)
{
	%textList[1] = "105270002;每日1次;20-200    ;80-300    ;100-500   ";
	%textList[2] = "105028002;每日1次;1         ;2         ;3         ";
	%textList[3] = "113010152;每日1次;2         ;4         ;5         ";
	%textList[4] = "113010151;每日1次;2         ;4         ;5         ";
	%textList[5] = "105109525;每日1次;3         ;4         ;5         ";
	%textList[6] = "105100203;每日1次;3000-10000;5000-15000;8000-25000";
	%textList[7] = "105100201;每日1次;1         ;1         ;1         ";
	%textList[8] = "105100202;每日1次;1         ;1         ;1         ";
	%textList[9] = "105020303;每日1次;50        ;100       ;200       ";
	%textList[10] = "105020353;每日1次;50        ;100       ;200       ";
	%textList[11] = "105021201;每日1次;0         ;1         ;1         ";
	%textList[12] = "105021211;每日1次;0         ;1         ;1         ";
	%textList[13] = "105090902;每日1次;0         ;1         ;2         ";
	%textList[14] = "102103029;每周1次;0         ;0         ;1         ";

	if (%type < 3)
		return GetWord(%textList[%index], %type-1, ";");
	else
	{
		%str1 = GetWord(%textList[%index], %type-1, ";");
		%str2 = GetWord(%str1, 0, " ");
		return %str2;
	}
}

//获得尊享特权当前是否有礼包可以邻，返回值>0时，不可领取
//%index：行数，一键领取时传-1
function VIP_getZhunxiangReward(%Player, %index)
{
	if (%Player.isVip(1) < 1)
		return 1;

	%Lv = VIP_getTequanLv(%Player, 1);
	%activeAA = GetWord(%Player.GetActivity(4129), 0);
	%activeBB = GetWord(%Player.GetActivity(4128), 0);

	if (getAcerPrerogativeText(%Player, %Lv+2, %index) < 1)
		return 1;	//数量为0的显示不可领取

	if (%index == 14)
		return HasBit(%activeBB, %index-1);
	else if (%index > 0)
		return HasBit(%activeAA, %index-1);
	else
	{
		%idCnt = VIP_getTequanListCnt(%Player, 1);	//条目总数
		for (%i=1; %i<=%idCnt; %i++)
		if (!HasBit(%activeAA, %index-1))
			return 0;
	}

	return 1;
}


//■■■■■■■■■■■【连续充值送豪礼】■■■■■■■■■■■■■■■■■
//$Recharge7Days_Date[1] = "6/1";	//活动开始时间
//$Recharge7Days_Date[2] = "6/7";	//活动结束时间
//返回当天是活动开启的第几天(0-6)
function getRecharge7DaysNowWhichDay()
{
	%startDays = GetWord($Recharge7Days_Date[1], 0, "/") * 30 + GetWord($Recharge7Days_Date[1], 1, "/");

	%Time = GetLocalTime();
	%DQ_MM = GetWord(%Time, 1);	//月
	%DQ_DD = GetWord(%Time, 2);	//日
	%nowDays = %DQ_MM * 30 + %DQ_DD;

	return %nowDays - %startDays;
}

//返回道具奖励列表
function getRecharge7DaysRewardInfo(%Player, %index)
{
	%RewardInfo[1] = "116010001;20|116080006;1|112010058;1";
	%RewardInfo[2] = "105090501;5 |105105701;3|113050012;5";
	%RewardInfo[3] = "105090601;5 |105090701;5|116030001;2|113090001;2";
	%RewardInfo[4] = "113090001;2 |105028012;1|113020002;5|105109321;8";
	%RewardInfo[5] = "113090001;2 |105028022;1|113020012;5|105109321;8";
	%RewardInfo[6] = "113090001;2 |105028022;1|105090911;3|105021051;1|116080006;1|105109321;8";
	%RewardInfo[7] = "113090001;2 |105028022;1|105090902;1|105109534;1|116080006;1|105109321;8";
	%RewardInfo[8] = "105180232;1";	//豪杰大礼包
	%RewardInfo[9] = "105105713;2 |105090511;5 |105090611;5 |113050023;5 |116030002;2 |105090711;5 |105109323;28|105021051;1 |105021061;1 |119015001;1";	//豪杰大礼包的内容

	return %RewardInfo[%index];
}

//返回某天需要多少提取多少元宝才能领取奖励
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

//返回某天奖励是否可以领取,0不可领取、1可领取、2已领取
//%Index((1-8)
function getRecharge7DaysRewardState(%Player, %index)
{
	%ActSt0 = GetAct(%Player, 4131, 0);	//是否可领取
	%ActSt1 = GetAct(%Player, 4131, 1);	//是否已领取

	if (HasBit(%ActSt1, %index-1))
		return 2;
	else if (HasBit(%ActSt0, %index-1))
		return 1;

	return 0;
}

//提取元宝时触发：设置奖励是否可领取
function getRecharge7DaysSetState(%Player, %gold)
{
	%whichDay = getRecharge7DaysNowWhichDay();
	if (%whichDay >= 0 && %whichDay < 7)
	{
		%ActYB  = GetAct(%Player, 4130, 0);	//每日提取元宝数
		%ActSt0 = GetAct(%Player, 4131, 0);	//是否可领取
		%ActSt1 = GetAct(%Player, 4131, 1);	//是否已领取

		if (%whichDay >= 4 && !HasBit(%ActSt1, 7))	//后三天一次性充值达到680元时可直接得礼包
		{
			if (%gold >= 68000)
			{
				AddItem_BaoGuoNo_Mail(%Player, 105180232, 1, 0, "3 4131");
				%ActSt0 = SetBit(%ActSt0, 7);
				%ActSt1 = SetBit(%ActSt1, 7);
			}
		}

		//设置每日奖励可领取
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
					%ActSt0 = SetBit(%ActSt0, 7);	//若满了5次以上，则可领取豪礼
			}
		}
		SetAct(%Player, 4131, %ActSt0, %ActSt1);
	}
}



//■■■■■■■■■■■【我的形象我做主】■■■■■■■■■■■■■■■■■
//返回值：道具编号|价格
function getMyAppearanceItemInfo(%Player, %Index, %Type)
{
	//时装																	//坐骑                             
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

//返回值：是否可购买，0可购买、1已购买
//参数：有三位，第一位是选项卡（坐骑/时装）、第二位是表示是礼包还是单个物品、第三位表示礼包或者物品的下标
function getMyAppearanceButtenState(%Player, %Index)
{
	%activeID = 4132 + (Mfloor(%Index/100) - 1);
	%activeValue[0] = GetAct(%Player, %activeID, 0);
	%activeValue[1] = GetAct(%Player, %activeID, 1);
	%activeTy = Mfloor(%Index/10) % 10 - 1;

	return %activeValue[%activeTy]*1;
}



//■■■■■■■■■■■【悠享基金】■■■■■■■■■■■■■■■■■■■■
//返回奖励信息：1立即奖励、2固定奖励、3随机奖励
function getYouXiangJiJinItemList(%Index)
{
	%ItemList[1] = "105105032;1|105028022;3|112010061;1|105109061;1";
	%ItemList[2] = "105270002;300|105109032;1";
	%ItemList[3] = "105270002;50 - 800|105109032;1 - 3";

	return %ItemList[%Index];
}

//%Type=1：返回是否可购买（0可购买、1已购买）|%Type=2：返回是否可领取（0可领取、1已领取）
function getYouXiangJiJinButtenState(%Player, %Type)
{
	%activeID = 4134;
	%active0 = GetAct(%Player, %activeID, 0)*1;

	%active2 = GetAct(%Player, 4136, 0)*1;	//是否已购买过

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

//■■■■■■■■■■■【限购商店】■■■■■■■■■■■■■■■■■■■■
//向客户端发送新的物品信息，示例如下：
//$XianShiQiangGou_ItemInfo[17, 1,  4] = "444444444|762|11|527|2";
//$XianShiQiangGou_ItemInfo[17, 1,  5] = "555555555|762|11|527|2";
//$XianShiQiangGou_ItemInfo[17, 1, 12] = "121212121|762|11|527|2";
//$SL_XianShiQiangGou_NewInfo = "17;1;4 5 12";	线路;商店ID;需要修改的物品的下标
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
	$XianShiQiangGou_ItemNum[%line, %shop] = %itemNum;	//更新道具数量

	if(strlen(%newItemInfo) <= 255)
		%Player.SendPlayerString(13,%newItemInfo,0);	//限时抢购在线更新
}

//客户端解析接收到的新的物品信息
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
		$XianShiQiangGou_ItemInfo[%line, %shop, %ID] = GetWord(%ReceiveInfo,%i+3,";");	//更新道具信息
		if(%itemNum < %ID)
			%itemNum = %ID;
	}
	$XianShiQiangGou_ItemNum[%line, %shop] = %itemNum;	//更新道具数量
}

//开服时设置限时商店库存
function XianShiQiangGou_SetKuCunNum()
{
	if($XianShiQiangGou_SetKuCunNum !$= "")
		return;
	$XianShiQiangGou_SetKuCunNum = 1;
	
	if($Now_Script != 2)
		return;
	
	%LineID = GetCurrentLineId();//线程ID
	for(%i=1;%i<=6;%i++)
	{
		%ItemNum = $XianShiQiangGou_ItemNum[%LineID,%i];
		if(%ItemNum > 0)
		{
			for(%j=1;%j<=%ItemNum;%j++)
			{
				$XianShiQiangGou_ItemKuCun[%LineID,%i, %j] = GetWord($XianShiQiangGou_ItemInfo[%LineID,%i, %j],1,"|");	//预先设定好的库存
			}
		}
	}
}

//向客户端发送限时抢购的物品库存
function XianShiQiangGou_SendClientKuCunNum(%Player)
{
	if($Now_Script != 2)
		return;
	
	%LineID = GetCurrentLineId();//线程ID
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


//客户端解析接收到的限时抢购的物品库存
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


//限时抢购，更新玩家activity值
function XianShiQiangGou_UpdateActivity(%Player)
{
	if($Now_Script != 2)
		return;
	
	%LineID = GetCurrentLineId();	//线程ID
	%itemTotal = $XianShiQiangGou_ItemNum[%LineID,1];
	
	%newDate = GetWord($SL_XianShiQiangGou_EndTime[1],0);
	%newDays = (GetWord(%newDate,0,".")-2018)*365 + GetWord(%newDate,1,".")*30 + GetWord(%newDate,2,".");

	for(%i=1;%i<=%itemTotal;%i++)
	{
		%activeID = 4200 + %i; 	//读取验证码值
		%oldDays = GetAct(%Player,%activeID,0);	//上一次购买时的活动开始时间
		%buyCnts = GetAct(%Player,%activeID,1);	//已经购买的数量
		
		if(%oldDays < %newDate)
			SetAct(%Player,%activeID,0,0);	//重置上次活动时间和已购买次数
	}
}


