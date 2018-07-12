//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//用于配方制造物品时的触发脚本
//程序会先判定玩家是否拥有足够的材料，然后触发进度条，当读条结束后才触发本脚本
//==================================================================================
//制造前置判断
//配方前置脚本判断属性中填写为“1”时调用
function ProduceCheck(%Player,%SerialId)
{
	if (%SerialId <= 0)
		return 9999;

	return 0;
}

//%Player：不解释
//%LivingSkillId:生活技能编号，用来判断是哪个生活技能
//%Var：返回的参数类型
function getCurrentLivingSkillLevel(%Player,%LivingSkillId,%Var)
{
	return 0;
}

function ProduceAll(%Player,%PresId)
{
	//Player	玩家对象
	//PresId	配方编号
	//GetPrescriptionData(%PresId,%Num);读取配方数据
	//判断配方编号位数，必需为9位
	if (strlen(%PresId) != 9)
		return;
	//材料
	%Materials[1] = GetPrescriptionData(%PresId,$PrescriptionData_ItemID_A);
	%Materials[2] = GetPrescriptionData(%PresId,$PrescriptionData_ItemID_B);
	%Materials[3] = GetPrescriptionData(%PresId,$PrescriptionData_ItemID_C);
	%Materials[4] = GetPrescriptionData(%PresId,$PrescriptionData_ItemID_D);
	%Materials[5] = GetPrescriptionData(%PresId,$PrescriptionData_ItemID_E);
	%Materials[6] = GetPrescriptionData(%PresId,$PrescriptionData_ItemID_F);
	//数量
	%Number[1] = GetPrescriptionData(%PresId,$PrescriptionData_Num_A);
	%Number[2] = GetPrescriptionData(%PresId,$PrescriptionData_Num_B);
	%Number[3] = GetPrescriptionData(%PresId,$PrescriptionData_Num_C);
	%Number[4] = GetPrescriptionData(%PresId,$PrescriptionData_Num_D);
	%Number[5] = GetPrescriptionData(%PresId,$PrescriptionData_Num_E);
	%Number[6] = GetPrescriptionData(%PresId,$PrescriptionData_Num_F);

	//活力需求
	%Vigor = GetPrescriptionData(%PresId,$PrescriptionData_HuoLi);
	//钱
	%Money = GetPrescriptionData(%PresId,$PrescriptionData_Money);
	//echo( "%ItemId==AAAAA===" @ %ItemId );
	//奖励熟练度
	%tmpSetLevelIndex = GetPrescriptionData(%PresId,$PrescriptionData_JiangLiExp);
	//获取玩家福缘
	%FuYuan = %Player.GetLuck();
	//获取生活技能编号
	%tmpCurrentLevelIndex = GetPrescriptionData(%PresId,$PrescriptionData_LiveSkill);

	//判断玩家是否有这些数量的材料
	for (%i = 1; %i < 7; %i++)
	{
		if (%Materials[%i] > 0 && %Number[%i] > 0)
		{
			if (%Player.GetItemCount(%Materials[%i]) < %Number[%i])
			{
				//材料数量不够，合成失败
				return 4103;
			}
		}
	}
	//echo( "1" );
	//判断玩家是否有足够的活力
	if (%Player.GetVigor() < %Vigor)
		return 511;	//您的活力不足
	//echo( "2" );
	//判断玩家是否有足够的钞票
	if (%Player.GetMoney(2) < %Money)
		return 4105;
	//echo( "3" );
	//给于的道具
	%ItemID = GetPrescriptionData(%PresId,$PrescriptionData_OutItem);
	%ItemNum = GetPrescriptionData(%PresId,$PrescriptionData_OutNum);
	//扣除道具材料
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
	//扣除活力值
	%Player.AddVigor(-%Vigor);
	//扣钱
	%Player.ReduceMoney(%Money,2,5,1009);

	%itemSubType = GetItemData(%ItemId,3);//获得道具子类
	//echo( "%itemSubType===" @ %itemSubType );
	if (%itemSubType > 100 && %itemSubType < 400)//如果是装备
	{
		for (%i = 0; %i < %ItemNum; %i++)
		{
			if (%itemSubType > 200 && %itemSubType < 300)
			{
				%Sex = %Player.GetSex();
				//sex系数 = 1-10000随机 小于5000*（1+福缘值/1000） 则为玩家本性别的防具 男的+0 女的+50
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
			%player.SetPutItemProduceName(%index,"铸造者：" @ %player.GetPlayerName());
		}
	}
	else
		%Index = %Player.Putitem(%ItemId,%ItemNum);
	//echo( "%ItemId==BBBB=" @ %ItemId );
	if (%Player.Additem(9,%PresId))
	{
		//添加熟练度
		if (%tmpSetLevelIndex > 0)
			addLivingSkillGuerdon(%Player, %tmpCurrentLevelIndex, %tmpSetLevelIndex);

		%ItemLevel = GetItemData(%ItemId, $Item_Data_Lv);//获得道具等级
		%SkillLevel = getsubstr(%tmpCurrentLevelIndex, 7, 2) * 1;
		//echo("%ItemLevel =====" @ %ItemLevel);
		//echo("%SkillLevel =====" @ %SkillLevel);
		//添加成就	
		switch (GetSubStr(%tmpCurrentLevelIndex,0,6))
		{
			case 502011://铸造技能
				SetStrategyRecord(%Player,$StrategySubBtnSrc[3,4]);//攻略触发记录
				if (%ItemLevel >= 70)
					AddAchievementWatch(%Player, 0, 53, 1);//记录成就
			case 503011://裁缝技能
				SetStrategyRecord(%Player,$StrategySubBtnSrc[3,5]);//攻略触发记录
				if (%ItemLevel >= 70)
					AddAchievementWatch(%Player, 0, 55, 1);//记录成就
			case 504011://制器技能
				SetStrategyRecord(%Player,$StrategySubBtnSrc[3,6]);//攻略触发记录
				if (%ItemLevel >= 70)
					AddAchievementWatch(%Player, 0, 54, 1);//记录成就
			case 505011://符咒技能
				SetStrategyRecord(%Player,$StrategySubBtnSrc[3,7]);//攻略触发记录
				if (%SkillLevel >= 4)
					AddAchievementWatch(%Player, 0, 51, 1);//记录成就
			case 506011://炼丹技能
				SetStrategyRecord(%Player,$StrategySubBtnSrc[3,8]);//攻略触发记录
				if (%SkillLevel >= 4)
					AddAchievementWatch(%Player, 0, 52, 1);//记录成就
			case 507011://烹饪技能
				SetStrategyRecord(%Player,$StrategySubBtnSrc[3,9]);//攻略触发记录
				if (%SkillLevel >= 4)
					AddAchievementWatch(%Player, 0, 50, 1);//记录成就
		}
		return 0;	//制作成功
	}
	else
		return 4103;
}
//配方编号 $PrescriptionData_ID = 0;						//0 配方编号				0   ====660012002
//配方类别 $PrescriptionData_Type_A = 1;					//1 配方类别				1   ====6
//配方子类别 $PrescriptionData_Type_B = 2;					//2 配方子类别				2   ====504
//配方等级 $PrescriptionData_Lv = 3;						//3 配方等级				3   ====100
//所需活力 $PrescriptionData_HuoLi = 4;						//4 所需活力				4   ====7
//悟性要求 $PrescriptionData_WuXin = 5;						//5 悟性要求				5   ====0
//生活技能编号 $PrescriptionData_LiveSkill = 6;				//6 生活技能编号			6   ====507011005
//所需金钱 $PrescriptionData_Money = 7;						//7 所需金钱				7   ====0
//消耗道具子类别 $PrescriptionData_Item_Type = 8;			//8 消耗道具子类别			8   ====0
//描述 $PrescriptionData_Help = 9;							//9  描述					9   ====烹饪可获得一份:玉兔白菜
//材料编号1 $PrescriptionData_ItemID_A = 10;				//10 材料编号				10   ====109062002
//材料数量1 $PrescriptionData_Num_A = 11;					//11 材料数量				11   ====1
//材料编号2 $PrescriptionData_ItemID_B = 12;				//12 材料编号				12   ====106030016
//材料数量2 $PrescriptionData_Num_B = 13;					//13 材料数量				13   ====2
//材料编号3 $PrescriptionData_ItemID_C = 14;				//14 材料编号				14   ====106030017
//材料数量3 $PrescriptionData_Num_C = 15;					//15 材料数量				15   ====1
//材料编号4 $PrescriptionData_ItemID_D = 16;				//16 材料编号				16   ====106030022
//材料数量4 $PrescriptionData_Num_D = 17;					//17 材料数量				17   ====0
//材料编号5 $PrescriptionData_ItemID_E = 18;				//18 材料编号				18   ====0
//材料数量5 $PrescriptionData_Num_E = 19;					//19 材料数量				19   ====0
//材料编号6 $PrescriptionData_ItemID_F = 20;				//20 材料编号				20   ====0
//材料数量6 $PrescriptionData_Num_F = 21;					//21 是否显示				21   ====1
//基础产出物品编号 $PrescriptionData_OutItem = 22;			//22 基础产出物品编号		22   ====105011002
//前置脚本判断 $PrescriptionData_CanDo = 23;				//23 前置脚本判断			23   ====0
//一次产出个数 $PrescriptionData_OutNum = 24;				//24 一次产出个数			24   ====1
//配方名称 $PrescriptionData_PresIDName = 25;				//25 配方名称				25   ====玉兔白菜
//吟唱提示文本 $PrescriptionData_Say = 26;					//26 吟唱提示文本			26   ====玉兔白菜·烹饪中
//学习配方所需技能熟练度 $PrescriptionData_Exp = 27;		//27 学习配方所需技能熟练度	27   ====0
//奖励熟练度 $PrescriptionData_JiangLiExp = 28;				//28 奖励熟练度			    28   ====1
