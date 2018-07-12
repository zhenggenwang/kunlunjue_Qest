//■■■■■■■■■■■所有触发对话界面脚本入口■■■■■■■■■■■■■■■■
//■■■■■■■■■■■删除任务触发脚本集合■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■技能书触发脚步■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■道具使用触发脚本■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■道具装备触发脚本■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■道具卸载触发脚本■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■区域触发脚本■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■使用神兽蛋以及坐骑蛋成功后调用■■■■■■■■■■■

//■■■■■■■■■■■整合的道具触发脚本■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■循环任务道具触发脚本■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■昆仑决道具触发■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■错误提示封装脚本■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■警示提示封装脚本■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■道具统一触发公告■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■所有触发对话界面脚本入口■■■■■■■■■■■■■■■■
//■■■■■■■■■■■使用道具触发界面■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■回城和传送相关道具■■■■■■■■■■■■
//105300001	日活跃礼包( 初级 )
//105300002	日活跃礼包( 中级 )
//105300003	日活跃礼包( 高级 )
//105300004	日活跃礼包( 豪华 )

function OnTriggerMission(%Player,%X_ID,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	//echo( "道具主类===" @ GetItemData( %X_ID, 2 ) );
	//echo( "道具子类===" @ GetItemData( %X_ID, 3 ) );
	%Conv = %Player.GetConversation();
	if (%State == -1)
	{
		%Conv.SetType(4);
		%Conv.Send(%Player);
		return;
	}

	//删除任务触发
	if (%State == -2)
		return OnTriggerDelMission(%Player,%X_ID);


	//如果属于技能书类
	if ((GetItemData(%X_ID,2) == 5) && (GetItemData(%X_ID,3) >= 522) && (GetItemData(%X_ID,3) <= 526))
		Trigger_Item_skillbook(%Player,%X_ID);

	//如果属于套装材料
	if ((GetItemData(%X_ID,2) == 16) && (GetItemData(%X_ID,3) == 1612))
		Trigger_Item_TaoZhuang_CaiLiao(%Player,%X_ID);

	//如果属于宝石
	if ((GetItemData(%X_ID,2) == 10) && (GetItemData(%X_ID,3) >= 1001) && (GetItemData(%X_ID,3) <= 1003))
		Trigger_Item_BaoShi(%Player,%X_ID);

	//如果属于宠物技能书类
	if ((GetItemData(%X_ID,2) == 5) && (GetItemData(%X_ID,3) == 516))
		Trigger_ChongWu_skillbook(%Player,%X_ID);

	//如果铭牌类
	if ((GetItemData(%X_ID,2) == 16) && (GetItemData(%X_ID,3) == 1611))
		Trigger_ShiZhuang_MingPai(%Player,%X_ID);

	//如果称号类
	if ((GetItemData(%X_ID,2) == 5) && (GetItemData(%X_ID,3) == 528))
		Trigger_Item_ChengHao(%Player,%X_ID);

	//如果X_ID是9位
	if (strlen(%X_ID) == 9)
	{
		switch (GetSubStr(%X_ID,0,1))
		{
			case 1:
				//判断此道具是否属于礼包类型道具
				if ((GetItemData(%X_ID,2) == 5) && (GetItemData(%X_ID,3) == 518))
					return Trigger_Bao(%Conv,%Player,%X_ID,%State,%Param);	//礼包
				if (%X_ID >= 105101000  && %X_ID <= 105103999)
					return Trigger_BaoSpecial(%Conv,%Player,%X_ID,%State,%Param);	//特殊礼包
				//判断此道具是否属于配方学习道具
				if (GetItemData(%X_ID,2) == 9)
				{
					%WhyNot = "";																		//默认的返回信息
					%PresID = GetItemData(%X_ID,$Item_Data_PresID);		//配方编号
					%livingSkillId = GetPrescriptionData(%PresID,$PrescriptionData_LiveSkill);		//需要的生活技能编号
					%livingSkillId_Exp = GetPrescriptionData(%PresID,$PrescriptionData_Exp);	//需求的生活技能熟练度

					if (isLearnLivingSkill(%Player.GetPlayerID(),%livingSkillId) == 1)						//判断该生活技能是否已经学会,0没有学过,1学会
					{
						if (%Player.GetLivingSkillRipe(%livingSkillId) >= %livingSkillId_Exp)		//判断生活技能熟练度超过所要求的值
						{
							if (AddPrescription(%Player,%PresID))		//学习配方
							{
								DelItemFromInventoryByIndex(%Player.GetPlayerID(),%XYZ,%X_ID,1,16,%X_ID);		//删除道具
								SendOneChatMessage($chatMsg_Person,"<t>您学会了【</t><l i='" @ %X_ID @ "' t='itemid'/><t>】</t>",%Player);
								SendOneScreenMessage(1,"您学会了【" @ GetItemData(%X_ID,1) @ "】",%Player);
							}
							else
							{
								%Txt = "您已经学会了此配方";
								SendOneChatMessage($chatMsg_Person,"<t>" @ %Txt @ "</t>",%Player);
								SendOneScreenMessage(2,%Txt,%Player);
							}
						}
						else
							%WhyNot = "你相应的生活技能熟练度不足【"@%livingSkillId_Exp@"】，无法学习此配方";
					}
					else
						%WhyNot = "你没有学会相应的生活技能，无法学习此配方";

					if (%WhyNot !$= "")
					{
						SendOneChatMessage($chatMsg_System,"<t>" @ %WhyNot @ "</t>",%Player);
						SendOneScreenMessage(2,%WhyNot,%Player);
					}

					return;
				}

				//执行相应单独的道具触发脚本
				%FuncName_A = "Trigger_" @ %X_ID;
				if (isFunction(%FuncName_A))
					eval(%FuncName_A @ "(%Conv, %Player, %X_ID, %State, %TriggerType, %TriggerID, %Param, %XYZ);");

				//判断某物品是否要使用后消失
				if (CheckBit(GetItemData(%X_ID,$Item_Data_Type),10) == 1)
				{
					//判断某物品是否限制了使用次数
					if (%Player.IsItemUsedTimes(%X_ID,%XYZ) > 0)
						if (%Player.GetItemUsedTimes(%X_ID,%XYZ) > 0)
							%Player.SetItemUsedTimes(%X_ID,%XYZ,%Player.GetItemUsedTimes(%X_ID,%XYZ) - 1);

					if (%Player.GetItemUsedTimes(%X_ID,%XYZ) <= 0)
						DelItemFromInventoryByIndex(%Player.GetPlayerID(),%XYZ,%X_ID,1,16,%X_ID);
				}

				//首位是8，则是区域触发脚本
			case 8:
				%FuncName_B = "Trigger_" @ %X_ID;
				if (isFunction(%FuncName_B))
					eval(%FuncName_B @ "(%Conv, %Player, %X_ID, %State, %TriggerType, %TriggerID, %Param, %XYZ);");

				//首位是5，则是采集事件
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
			SendOneScreenMessage(1,"称号添加成功",%Player);
			%Player.AddDesignation(%DescID);//      	添加一个新的称号
		}
	}
}
//■■■■■■■■■■■所有触发对话界面脚本入口■■■■■■■■■■■■■■■■


//■■■■■■■■■■■删除任务触发脚本集合■■■■■■■■■■■■■■■■■■
function OnTriggerDelMission(%Player,%Mid)
{
	//需要删除任务记录
	%Player.DelMission = %Mid;

	%FuncName = "DelMission_" @ %Mid;

	if (isFunction(%FuncName))
		Call(%FuncName,%Player,%Mid);

	//主线任务
	if (GetMissionKind(%Mid) == 1)
	{
		if ((%Player.GetLevel() - 20) < GetMissionData(%Mid,$Mission_Data_LvA))
		{
			SendOneChatMessage($chatMsg_System,"<t>低于自身20级的【主线任务】才可放弃</t>",%Player);
			SendOneScreenMessage(2,"低于自身20级的【主线任务】才可放弃",%Player);
			return;
		}

		//若有是接任务奖励道具的任务，放弃则无法在领取
		if (GetMissionData(%Mid,$Mission_Data_ItemAdd) !$= 0)
			%Player.SetMission(%Mid,1);
	}
	//生活技能任务
	if (%Mid >= 30100 && %Mid < 30712)
	{
		SendOneScreenMessage(2,"生活技能不可放弃",%Player);
		return;
	}
	//----------------------下面做放弃任务的处理-------------------------
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

	if (%mid >= 29000 && %mid <= 30000)//悬赏缉凶任务放弃处理
	{
		%Player.SetSchbuff(2015);
		for (%i = 4025; %i <= 4029; %i++)
		{
			%MidID = GetAct(%Player,%i,0) + 29000;
			if (%MidID == %Mid)
			{
				%CoLor =  GetAct(%Player,%i,1);//品质颜色
				%Act = %i;//记录编号
				break;
			}
		}
		if (%Act > 0)
			SetAct(%Player,%Act,0,0);
	}

	if(%mid == 29999)
		AddMissionAccepted(%Player,%Conv,%Mid);

	SendOneChatMessage($chatMsg_Person,"<t>您放弃了[" @ GetMissionData(%Mid,$Mission_Data_Name) @ "]任务</t>",%Player);
	SendOneScreenMessage(1,"您放弃了[" @ GetMissionData(%Mid,$Mission_Data_Name) @ "]任务",%Player);
	ServerOnSptAction(%Player.GetPlayerID(),%Mid,4);//通讯客户端
	return;
}
//■■■■■■■■■■■删除任务触发脚本集合■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■错误提示封装脚本■■■■■■■■■■■■■■■■■■■■
function Message_Error_Hint(%Player,%Txt)
{
	SendOneScreenMessage(2,%Txt,%Player);	//红色消息
	SendOneChatMessage($chatMsg_System,"<t>"@ %Txt @"</t>",%Player);
}
//■■■■■■■■■■■警示提示封装脚本■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■警示提示封装脚本■■■■■■■■■■■■■■■■■■■■
function Message_Caution_Hint(%Player,%Txt)
{
	SendOneScreenMessage(1,%Txt,%Player);	//黄色消息
	SendOneChatMessage($chatMsg_System,$Get_Dialog_GeShi[31204] @ %Txt @"</t>",%Player);
}
//■■■■■■■■■■■警示提示封装脚本■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■技能书触发脚步■■■■■■■■■■■■■■■■■■■■■
function Trigger_Item_skillbook(%Player,%X_ID)
{
	%SkillBookID = GetItemData(%X_ID,17);
	%SkillNeedID = GetItemData(%X_ID,54);
	%ClassesID = GetItemData(%X_ID,113);
	%ItemLevel = GetItemData(%X_ID, $Item_Data_Lv);

	%SkillID = GetSubStr(%SkillBookID,0,5);
	%SkillNeed = GetSubStr(%SkillNeedID,0,5);
	
	//putout("技能书触发脚步==" @ %X_ID);
	if (HasBit(%ClassesID,%Player.GetClasses(0) - 1) == 0)
	{
		%Txt = "您的职业不符，无法使用此技能书！";
		Message_Error_Hint(%Player,%Txt);
		return;
	}

	if (%SkillNeedID > 0)
	{
		if (%Player.GetSkillLevel(%SkillNeed) == 0)
		{
			%Txt = "您还未学习此技能的前置技能！";
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
			%Txt = "恭喜你成功习得【"@GetItemData(%X_ID,1)@"】技能。";
			SendOneScreenMessage(1,%Txt,%Player);	//黄色消息
			SendOneChatMessage($chatMsg_System,$Get_Dialog_GeShi[31404] @ %Txt @ "</t>",%Player);
			%Player.AddSkill(%SkillBookID);
			if (%ItemLevel >= 40)
				SetStrategyRecord(%Player, 82);
		}
	}
	else
	{
		%Txt = "您已经学会【"@GetItemData(%X_ID,1)@"】技能，无法再次使用。";
		SendOneScreenMessage(2,%Txt,%Player);	//红色消息
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
	}
	//------------主线任务----学习技能书触发---------
	if (%X_ID == 105220003 || %X_ID ==105250003 || %X_ID ==105240003)
	{
		if (%Player.IsAcceptedMission(10121))
		{
			%Player.SetMissionFlag(10121,1350,1);
			SendOneScreenMessage(1,"学习技能书  1/1",%Player);
			%Player.UpdateMission(10121);
		}
	}
	if (%X_ID == 105220004 || %X_ID ==105250005 || %X_ID ==105240004)
	{
		if (%Player.IsAcceptedMission(10231))
		{
			%Player.SetMissionFlag(10231,1350,1);
			SendOneScreenMessage(1,"学习技能书  1/1",%Player);
			%Player.UpdateMission(10231);
		}
	}
}
//■■■■■■■■■■■技能书触发脚步■■■■■■■■■■■■■■■■■■■■■
//105180171	破空刺
//105180172	风卷残云

//■■■■■■■■■■■道具使用触发脚本■■■■■■■■■■■■■■■■■■■■
//所有可使用的道具，使用时触发的脚本
function Item_Use(%Player,%ItemID,%TriggerType,%TriggerID,%XYZ)
{
	//echo( "道具使用触发脚本" @  %TriggerType  @ "   " @  %TriggerID  @ "  " @ %XYZ );

	$Item_Use_Return = 1;

	//0，使用失败，不执行后续操作
	//1，使用成功
	//echo( "使用时触发的脚本%ItemID===" @ %ItemID );
	//所有道具，统一执行OnTriggerMission函数
	OnTriggerMission(%Player,%ItemID,0,%TriggerType,%TriggerID,0,%XYZ);

	%ItemLx = GetItemData(%ItemID,$Item_Data_Big_Index);
	%ItemZx = GetItemData(%ItemID,3);

	if (%ItemLx == 12)
	{
		if (%ItemZx == 1209)
		{
			sptUseBonusItem(%Player.GetPlayerID(),%ItemID);//商城礼包
		}
	}

	return $Item_Use_Return;
}
//■■■■■■■■■■■道具使用触发脚本■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■使用神兽蛋以及坐骑蛋成功后调用■■■■■■■■■■■
function onGeneratePetInfo(%Player,%ItemId,%MountId)//神兽
{
	//万兽谷弟子
	if ((%itemid == 118011001) || (%itemid == 118011002))
	{
		//通讯客户端
		ServerOnSptAction(%Player.GetPlayerID(),0,135);

		%Player.AddObjectToPanel(4,0,18);
	}

	//知恩图报
	if ((%itemid == 118011003) || (%itemid == 118011004))
	{
		ServerOnSptAction(%Player.GetPlayerID(),0,148);//通讯客户端
	}
}

function onGenerateMountInfo(%Player,%ItemId,%MountId)//坐骑
{
	//	//各职业使用骑宠蛋之后触发 - 打开提示框，提示玩家第一格坐骑是寻径坐骑
	if (%ItemId == 119014025)
	{
		%Player.AddObjectToPanel(5,0,9);//将第一格坐骑放入快捷栏
		HelpDirectByIndex(%Player.GetPlayerID(),20);	//通讯客户端
	}
	else
	{
		if (GetSrc(%Player,188) == 0)
		{
			SetSrc(%Player,188);
			HelpDirectByIndex(%Player.GetPlayerID(),22);	//通讯客户端
		}
	}
}
//■■■■■■■■■■■使用神兽蛋以及坐骑蛋成功后调用■■■■■■■■■■■

//■■■■■■■■■■■道具对道具使用脚本■■■■■■■■■■■■■■■■■■■■■■

function ItemClickUse(%Player,%ItemID,%Index,%Tagitemid,%TagIndex)
{
	switch (%ItemID)
	{
		case 113070052://传送增补符
			if (%Tagitemid == 113070051)//定位符
			{
				if (%Player.GetItemUsedTimes(%Tagitemid,%TagIndex) >= 10)
				{
					SendOneScreenMessage(2,"您的定位符已经不能在增补了",%Player);
				}
				else
				{
					%Player.PutItem(%ItemID,-1);
					%Player.AddItem(4,%ItemID);
					%Player.SetItemUsedTimes(%Tagitemid,%TagIndex,10);
					SendOneScreenMessage(2,"定位符增补成功",%Player);
				}
			}
			else
			{
				SendOneScreenMessage(2,"该物品只能对定位符使用",%Player);
			}

		case 113070054://三界定位增补符
			if (%Tagitemid == 113070053)	//三界定位符
			{
				if (%Player.GetItemUsedTimes(%Tagitemid,%TagIndex) >= 10)
				{
					SendOneScreenMessage(2,"您的三界定位符已经不能在增补了",%Player);
				}
				else
				{
					%Player.PutItem(%ItemID,-1);
					%Player.AddItem(4,%ItemID);
					%Player.SetItemUsedTimes(%Tagitemid,%TagIndex,10);
					SendOneScreenMessage(2,"三界定位符增补成功",%Player);
				}
			}
			else if (%Tagitemid == 113070055) //三界定位符（队伍）
			{
				%DCs = %Player.GetItemUsedTimes(%Tagitemid,%TagIndex);

				if (%Player.GetItemUsedTimes(%Tagitemid,%TagIndex) >= 10)
				{
					SendOneScreenMessage(2,"您的三界定位符已经不能在增补了",%Player);
				}
				else
				{
					%Player.PutItem(%ItemID,-1);
					%Player.AddItem(4,%ItemID);
					%Player.SetItemUsedTimes(%Tagitemid,%TagIndex,%DCs + 2);
					SendOneScreenMessage(2,"三界定位符（队伍）增补成功",%Player);
				}
			}
			else
			{
				SendOneScreenMessage(2,"该物品只能对三界定位符使用",%Player);
			}
	}

}
//■■■■■■■■■■■道具对道具使用脚本■■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■道具装备触发脚本■■■■■■■■■■■■■■■■■■■■
function Item_On(%Player,%ItemID)
{
	switch (%ItemID)
	{
		//---穿戴装备--
		case 102022000: Mission_ChuanDaiZhuangBei_10151(%Player,10151);
		case 102022050: Mission_ChuanDaiZhuangBei_10151(%Player,10151);
		case 102022200: Mission_ChuanDaiZhuangBei_10151(%Player,10151);
		case 102022250: Mission_ChuanDaiZhuangBei_10151(%Player,10151);
		case 102022300: Mission_ChuanDaiZhuangBei_10151(%Player,10151);
		case 102022350: Mission_ChuanDaiZhuangBei_10151(%Player,10151);
			//----生活技能学习---
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
//■■■■■■■■■■■道具装备触发脚本■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■道具卸载触发脚本■■■■■■■■■■■■■■■■■■■■
function Item_Off(%Player,%ItemID)
{

}
//■■■■■■■■■■■道具卸载触发脚本■■■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■整合的道具触发脚本■■■■■■■■■■■■■■■■■■■
//必给道具的打包道具
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
//			//如果奖励道具为武魂
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
////随机给道具的打包道具
//if ( %Type == 2 )
//{
//	%RandID = GetRandom( 1, %NumAll );
//	%Item_Num_Add = $Item_Bao[ %ItemID, %RandID ];
//	%Item = GetWord( %Item_Num_Add, 0 );
//	%Num  = GetWord( %Item_Num_Add, 1 );
//
//	if ( ( %Item !$= "" )&&( %Num !$= "" ) )
//	{
//		//如果奖励道具为武魂
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
////选择给道具的打包道具
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
////依据条件给道具的打包道具
//if ( %Type == 4 )
//{
//	%Why = GetWord( %Item_Num_All, 2 );		//礼包类型
//
//	//圣地、性别条件判断
//	if ( %Why == 1 )
//	{
//		%ListNum = %Player.GetFamily( );
//		%ListSex = %Player.GetSex( );
//		%Item_Num_Add = $Item_Bao[ %ItemID, %ListNum, %ListSex ];
//	}
//
//	//等级条件判断
//	if ( %Why == 2 )
//	{
//		%ListNum = %Player.GetLevel( );
//		%Item_Num_Add = $Item_Bao[ %ItemID, %ListNum ];
//	}
//
//	//门阀条件判断
//	if ( %Why == 3 )
//	{
//		%ListNum = %Player.GetFamily( );
//		%Item_Num_Add = $Item_Bao[ %ItemID, %ListNum ];
//	}
//
//	//圣地条件判断
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
////不绑定必给道具
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
////不绑定选择给道具
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
////特殊调用道具触发
//if ( %Type == 5 )
//{
//	Trigger_Bao_Fringe_Benefit( %Conv, %Player, %ItemID, %State, %Param );
//}
//else
//{
//	//扣除礼包本身
//	%index = %Player.PutItem( %ItemID, -1 );
//	echo( "扣除礼包本身"@%ItemID );
//	if ( %Player.AddItem( 4, %ItemID ) )
//	{
//		//如果是武魂则邮件
//		if ( ( %Type == 1 ) || ( %Type == 2 ) )
//		{
//			%NumAll = ( %Type == 2 )  ? 1:%NumAll;
//			for ( %i = 0; %i < %NumAll; %i++ )
//			{
//				if ( %WuHunID[ %i ] > 0 )
//				{
//					//邮件内容
//					%MailText = "注意查收你的邮件！";
//					SptMail_Send( %Player.GetPlayerID( ), %WuHunID[ %i ], %WuHunNum[ %i ], 0, 0, "武魂奖励", %MailText );
//				}
//
//			}
//		}
//	}
//}
//%Conv.SetType( 4 );	//关闭对话
//		}
function Trigger_Bao(%Conv,%Player,%ItemID,%State,%Param)
{
	%Conv.Reset();	//重置所有选项
	%Conv.SetTriggerType(1);
	%Conv.SetTriggerMission(%ItemID);
	%Conv.SetType(2);
	if (%Player.GetBagEmptyCount() < 8)
	{
		SendOneScreenMessage(2,"包裹已满，请确保包裹中至少有一排空位！",%Player);
		%Conv.SetType(4);
		return;
	}
	if (%Player.GetCaptivateState() >= 1)
	{
		SendOneScreenMessage(2,"您已进入防沉迷疲劳状态了暂时无法打开此礼包 请下线休息后再来！",%Player);
		%Conv.SetType(4);
		return;
	}
	if (%Player.GetItemCount(%ItemID) > 0)
	{
		%Item_Num_All = $Item_Bao[%ItemID];

		%NumAll = GetWord(%Item_Num_All,0);		//礼包内道具数量
		%Type   = GetWord(%Item_Num_All,1);		//礼包类型
		%TeShu = GetWord(%Item_Num_All,2) * 1;//绑定标识以及特殊处理
		%Property = (%TeShu > 1) ? 0 : 1;//1 绑定 0 不绑定
		//echo( "===========================================" );
		//echo( "%NumAll ===" @ %NumAll );
		//echo( "%Type ===" @ %Type );
		//echo( "%TeShu ===" @ %TeShu );
		//echo( "%Property ===" @ %Property );
		switch (%State)
		{
			case 0:
				%Conv.SetText(%ItemID,%ItemID);					//向客户端发送描述文字编号

			default:
				switch (%type)
				{
					case 1:	//必给道具的打包道具
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
					case 2://可选道具
						%Item_Num_Add = $Item_Bao[%ItemID,%Param + 1];

						%Item = GetWord(%Item_Num_Add,0);
						%Num  = GetWord(%Item_Num_Add,1);

						if ((%Item !$= "")&&(%Num !$= ""))
						{
							%index = %Player.PutItem(%Item,%Num);
							if (%Property > 0)
								%Player.SetPutItemProperty(%index,1,%Player.GetPlayerID());
						}
					case 3://随机给一个道具
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
					case 4://道具显示成两部分，第一部分的道具全部都给 编号从1开始 ,第二部分的道具使用随机的方式给予（只给1个） 编号从101开始
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

					case 5://道具显示成两部分，第一部分的道具全部都给 编号从1开始 ,第二部分的道具使用随机的方式给予（每个物品单独随机 0 只显示不会给 10000必给） 编号从101开始
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
					case 6://特殊处理的礼包，包含公告、是否根据等级处理、概率等
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
							//echo( "必给道具=========" @ %Item );
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
								//echo( "随机道具==A=======" @ %Item );
								if (%LvSpc $= "LvSp1")
									%Item = GetNewItemIDForLevel(%Player,%Item);
								break;
							}
						}
						//echo( "随机道具==B=======" @ %Item );
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
								//echo( "全随机==A=======" @ %Item );
								%Num  = GetWord($Item_Bao[%ItemID,%i + 1001],1);
								%Msg = GetWord($Item_Bao[%ItemID,%i + 1001],2);
								%LvSpc = GetWord($Item_Bao[%ItemID,%i + 1001],3);
								if (%LvSpc $= "LvSp1")
									%Item = GetNewItemIDForLevel(%Player,%Item);
								//echo( "全随机==B=======" @ %Item );
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
					if (%TeShu == 1 || %TeShu == 3)//后续的特殊处理
						Trigger_Bao_Fringe_Benefit(%Conv,%Player,%ItemID,%State,%Param);
					%Conv.SetType(4);	//关闭对话
				}
		}
	}
	else
		%Conv.SetText(7);		//物品数据错误

	%Conv.Send(%Player);
}

function Trigger_BaoSpecial(%Conv,%Player,%ItemID,%State,%Param)
{
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"包裹已满，请确保包裹中至少有1个空位！",%Player);
		%Conv.Settype(4);
		return;
	}
	if (%Player.GetCaptivateState() >= 1)
	{
		SendOneScreenMessage(2,"您已进入防沉迷疲劳状态了暂时无法打开此礼包 请下线休息后再来！",%Player);
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
//■■■■■■■■■■■整合的道具触发脚本■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■礼包触发特殊奖励■■■■■■■■■■■■■■■■■■■■
function Trigger_Bao_Fringe_Benefit(%Conv,%Player,%ItemID,%State,%Param)
{
	//echo( " 礼包触发特殊奖励===" @  %ItemID );
	%Item_Num_All = $Item_Bao[%ItemID];

	%NumAll = GetWord(%Item_Num_All,0);		//礼包内道具数量
	%Type   = GetWord(%Item_Num_All,1);		//礼包类型
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
//■■■■■■■■■■■礼包触发特殊奖励■■■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■■回城和传送相关道具■■■■■■■■■■■■
function Trigger_113010052(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)//	回城卷
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
function Trigger_113010152(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)//	回城卷( 赠品 )
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
function Trigger_113010001(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1010); }//蓬莱回城卷
function Trigger_113010002(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1001); }//昆仑回城卷
function Trigger_113010003(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1101); }//望仙谷回城卷
function Trigger_113010004(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1102); }//苍山雪海回城卷
function Trigger_113010005(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1103); }//云梦泽回城卷
function Trigger_113010101(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1010); }//蓬莱回城卷( 赠品 )
function Trigger_113010102(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1001); }//昆仑回城卷( 赠品 )
function Trigger_113010103(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1101); }//望仙谷回城卷( 赠品 )
function Trigger_113010501(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1010); }//蓬莱回城卷
function Trigger_113010502(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1001); }//昆仑回城卷
function Trigger_113010503(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1101); }//望仙谷回城卷
function Trigger_113010504(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1102); }//苍山雪海回城卷
function Trigger_113010505(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1103); }//云梦泽回城卷

//判断回城卷轴的使用条件是否满足
function ItemTransBackHome_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%TarGetMapId)
{
	// %Type为物品id  %Xyz为坐标
	//echo("判断回城卷轴的使用条件是否满足  " @ %Type);
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
			ServerOnSptAction(%Player.GetPlayerID(),%TarGetMapId,21);//通讯客户端
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
function Trigger_113010151(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ RandomItemTrans_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }	  //随机卷轴（赠品）
function Trigger_113010051(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ RandomItemTrans_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }	  //随机卷轴
function Trigger_113010551(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ RandomItemTrans_Before(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }	  //随机卷轴
//判断随即卷的使用条件是否满足
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


function Trigger_113020001(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ GoToTeamMaster(%Player); }  //集合符
function Trigger_113020002(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ GoToTeamMaster(%Player); }  //集合符（赠品）
function Trigger_113020011(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ CallBackTeamPlayer(%Player); }	  //召唤符
function Trigger_113020012(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ CallBackTeamPlayer(%Player); }	  //召唤符（赠品）

//113070001	传送符
//113070002	传送符
//113070003	传送符
//113070004	传送符
//113070051	传送符
//113070052	传送增补符
//113070053	传送符
//113070054	传送增补符
//113070055	传送符( 队伍 )

//113070055	三界定位符（组队）
function Trigger_113070055(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	//如果没有记录过坐标

	if (%Player.isHavePoint(%XYZ) == 0)
	{
		//如果在副本内，则无法使用定位符
		if (GetSubStr(GetZoneID(),0,2) $= "13")
			SendOneScreenMessage(2,"副本内无法使用定位符",%Player);

		else if ((GetZoneID() == 1401)||(GetZoneID() == 1127)||(GetZoneID() == 1136))
			SendOneScreenMessage(2,"此地图无法使用定位符记录坐标",%Player);
		else
		{
			%Player.SetPositionPoint(%XYZ);
			SendOneScreenMessage(1,"您记录了当前的坐标",%Player);

			%MapID = %Player.GetPositionPoint(%XYZ,0);
			%X = %Player.GetPositionPoint(%XYZ,1);
			%Y = %Player.GetPositionPoint(%XYZ,2);
			%Z = %Player.GetPositionPoint(%XYZ,3);
		}
	}
	else
	{
		%PlayerID = %Player.GetPlayerID();
		if (SvrIsMyselfCaption(%PlayerID))//是否为队长
		{
			if ((%Player.IsSchBuff(20023016) == 0)&&(%Player.IsSchBuff(20023017) == 0))
			{
				if (!%Player.IsAcceptedMission(20023))
				{
					//获取包裹内指定位置的道具坐标
					%MapID = %Player.GetPositionPoint(%XYZ,0);
					%X = %Player.GetPositionPoint(%XYZ,1) / 100;
					%Y = %Player.GetPositionPoint(%XYZ,2) / 100;
					%Z = %Player.GetPositionPoint(%XYZ,3) / 100;

					//判断某物品是否限制了使用次数
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
								SendOneScreenMessage(2,"多人骑乘下无法使用定位符",%Player);
							}
							else
							{
								%Player.SetItemUsedTimes(113070055,%XYZ,%Player.GetItemUsedTimes(113070055,%XYZ) - 1);
								Schedule(1000,0,"ZuDuiDinWeiFuGoTo",%Player,%MapID,%X,%Y,%Z);
							}
						}
						else if (%Player.GetItemUsedTimes(113070055,%XYZ) == 0)
							SendOneScreenMessage(2,"定位符的次数已经为0，无法再使用",%Player);
					}
				}
				else
				{
					SendOneScreenMessage(2,"拥有万灵逐日任务时，不可使用定位符",%Player);
				}
			}
			else
			{
				SendOneScreenMessage(2,"囚仙牢无法使用定位符",%Player);
			}
		}
		else
		{
			SendOneScreenMessage(2,"只有队长才可使用定位符",%Player);
		}
	}
}

//113070053	三界定位符
function Trigger_113070053(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	//如果没有记录过坐标
	if (%Player.isHavePoint(%XYZ) == 0)
	{
		//如果在副本内，则无法使用定位符
		if (GetSubStr(GetZoneID(),0,2) $= "13")
			SendOneScreenMessage(2,"副本内无法使用定位符",%Player);

		else if ((GetZoneID() == 1401)||(GetZoneID() == 1127)||(GetZoneID() == 1136))
			SendOneScreenMessage(2,"此地图无法使用定位符记录坐标",%Player);

		else
		{
			%Player.SetPositionPoint(%XYZ);
			SendOneScreenMessage(1,"您记录了当前的坐标",%Player);

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
				//获取包裹内指定位置的道具坐标
				%MapID = %Player.GetPositionPoint(%XYZ,0);
				%X = %Player.GetPositionPoint(%XYZ,1) / 100;
				%Y = %Player.GetPositionPoint(%XYZ,2) / 100;
				%Z = %Player.GetPositionPoint(%XYZ,3) / 100;

				//判断某物品是否限制了使用次数
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
						SendOneScreenMessage(2,"定位符的次数已经为0，无法再使用",%Player);
				}
			}
			else
			{
				SendOneScreenMessage(2,"拥有万灵逐日任务时，不可使用定位符",%Player);
			}
		}
		else
		{
			SendOneScreenMessage(2,"囚仙牢无法使用定位符",%Player);
		}
	}
}

//113070051	定位符
function Trigger_113070051(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	//如果没有记录过坐标
	if (%Player.isHavePoint(%XYZ) == 0)
	{
		//如果在副本内，则无法使用定位符
		if (GetSubStr(GetZoneID(),0,2) $= "13")//副本地图无法使用
			SendOneScreenMessage(2,"副本内无法使用定位符",%Player);

		else if (GetSubStr(GetZoneID(),0,2) !$= "10")//不是10开头的地图不可使用
			SendOneScreenMessage(2,"该地图无法使用定位符记录坐标",%Player);

		else
		{
			%Player.SetPositionPoint(%XYZ);
			SendOneScreenMessage(1,"您记录了当前的坐标",%Player);
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
				//获取包裹内指定位置的道具坐标
				%MapID = %Player.GetPositionPoint(%XYZ,0);
				%X = %Player.GetPositionPoint(%XYZ,1) / 100;
				%Y = %Player.GetPositionPoint(%XYZ,2) / 100;
				%Z = %Player.GetPositionPoint(%XYZ,3) / 100;

				//获取道具次数
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
						SendOneScreenMessage(2,"定位符的次数已经为0，无法再使用",%Player);
				}
			}
			else
			{
				SendOneScreenMessage(2,"拥有万灵逐日任务时，不可使用定位符",%Player);
			}
		}
		else
		{
			SendOneScreenMessage(2,"囚仙牢无法使用定位符",%Player);
		}
	}
}

function ZuDuiDinWeiFuGoTo(%Player,%Map,%X,%Y,%Z)
{
	%MapID = GetSubStr(%Map,1,4);//获得地图ID
	%PlayerID = %Player.GetPlayerID();//获得玩家ID

	if (!SvrIsMyselfHasTeam(%PlayerID))//没队伍
		%Player.TransportObject(0,%MapID,%X,%Y,%Z);
	else
	{
		%TeamList = SvrGetTeammate(%PlayerID,15);//队伍列表

		for (%i = 0; %i < GetWordCount(%TeamList); %i++)
		{
			%Teammate = GetWord(%TeamList,%i);
			if (!IsPlayer(%Teammate))//不在附近的话就再见了
				continue;

			if (%Teammate.GetInteractionState() > 0)
			{
				SendWhyMsg(%Teammate,"H",0,1);
				return;
			}
			else if (%Teammate.isInMultiMount() != 0)
			{
				SendOneScreenMessage(2,"多人骑乘下无法使用定位符",%Teammate);
			}
			else
			{
				%Teammate.TransportObject(0,%MapID,%X,%Y,%Z);
			}
		}
	}
}
//■■■■■■■■■■■■回城和传送相关道具■■■■■■■■■■■■





function Trigger_105109350(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020103,200); }//一包凝血丹( 3 )			3级凝血丹
function Trigger_105109351(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020104,200); }//一包凝血丹( 4 )		   4级凝血丹
function Trigger_105109352(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020105,200); }//一包凝血丹( 5 )		   5级凝血丹
function Trigger_105109353(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020106,200); }//一包凝血丹( 6 )		   6级凝血丹
function Trigger_105109354(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020107,200); }//一包凝血丹( 7 )		   7级凝血丹
function Trigger_105109355(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020108,200); }//一包凝血丹( 8 )		   8级凝血丹
function Trigger_105109356(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020109,200); }//一包凝血丹( 9 )		   9级凝血丹
function Trigger_105109360(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020153,200); }//一包聚神散( 3 )		   3级聚神散
function Trigger_105109361(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020154,200); }//一包聚神散( 4 )		   4级聚神散
function Trigger_105109362(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020155,200); }//一包聚神散( 5 )		   5级聚神散
function Trigger_105109363(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020156,200); }//一包聚神散( 6 )		   6级聚神散
function Trigger_105109364(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020157,200); }//一包聚神散( 7 )		   7级聚神散
function Trigger_105109365(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020158,200); }//一包聚神散( 8 )		   8级聚神散
function Trigger_105109366(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020159,200); }//一包聚神散( 9 )		   9级聚神散
function Trigger_105109370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020303,200); }//一包凝血丹赠品( 3 )		 3级凝血丹( 赠品 )
function Trigger_105109371(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020304,200); }//一包凝血丹赠品( 4 )		 4级凝血丹( 赠品 )
function Trigger_105109372(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020305,200); }//一包凝血丹赠品( 5 )		 5级凝血丹( 赠品 )
function Trigger_105109373(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020306,200); }//一包凝血丹赠品( 6 )		 6级凝血丹( 赠品 )
function Trigger_105109374(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020307,200); }//一包凝血丹赠品( 7 )		 7级凝血丹( 赠品 )
function Trigger_105109375(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020308,200); }//一包凝血丹赠品( 8 )		 8级凝血丹( 赠品 )
function Trigger_105109376(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020309,200); }//一包凝血丹赠品( 9 )		 9级凝血丹( 赠品 )
function Trigger_105109380(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020353,200); }//一包聚神散赠品( 4 )		 3级聚神散( 赠品 )
function Trigger_105109381(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020354,200); }//一包聚神散赠品( 4 )		 4级聚神散( 赠品 )
function Trigger_105109382(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020355,200); }//一包聚神散赠品( 5 )		 5级聚神散( 赠品 )
function Trigger_105109383(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020356,200); }//一包聚神散赠品( 6 )		 6级聚神散( 赠品 )
function Trigger_105109384(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020357,200); }//一包聚神散赠品( 7 )		 7级聚神散( 赠品 )
function Trigger_105109385(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020358,200); }//一包聚神散赠品( 8 )		 8级聚神散( 赠品 )
function Trigger_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105020359,200); }//一包聚神散赠品( 9 )		 9级聚神散( 赠品 )
function Trigger_105109350_105109386(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%itemid,%itemnum)
{
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"包裹已满，请确保包裹中至少有1格空位！",%Player);
		return;
	}
	%player.putitem(%type,-1);
	%player.putitem(%itemid,%itemnum);
	%player.additem(1,%type);
}


function Trigger_105100101(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105090501,105090511,105090521,105090531,105090541); }	//重铸石礼包	蓝色
function Trigger_105100102(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105090502,105090512,105090522,105090532,105090542); }	//重铸石礼包	紫色
function Trigger_105100103(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105090503,105090513,105090523,105090533,105090543); }	//重铸石礼包	橙色
function Trigger_105100111(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105090601,105090611,105090621,105090631,105090641); }	//精炼石礼包	蓝色
function Trigger_105100112(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105090602,105090612,105090622,105090632,105090642); }	//精炼石礼包	紫色
function Trigger_105100113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105090603,105090613,105090623,105090633,105090643); }	//精炼石礼包	橙色
function Trigger_105100121(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105090701,105090711,105090721,105090731,105090741); }	//涅槃石礼包	紫色
function Trigger_105100122(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105090702,105090712,105090722,105090712,105090722); }	//涅槃石礼包	橙色
function Trigger_105100123(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105090703,105090713,105090723,105090713,105090723); }	//涅槃石礼包	红色
function Trigger_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105109321,105109322,105109323,105109324,105109325); }	//紫星石礼包
function Trigger_105100101_105100131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%ItemA,%ItemB,%ItemC,%ItemD,%ItemF)
{
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"包裹已满，请确保包裹中至少有1格空位！",%Player);
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
		%ItemLevel = GetItemData(%Item[%i],$Item_Data_Lv);//获得道具等级
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


function Trigger_105021501(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//活力丹
function Trigger_105021502(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//活力丹
function Trigger_105021503(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//活力丹
function Trigger_105021504(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//活力丹
function Trigger_105021505(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//活力丹
function Trigger_105021506(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//活力丹
function Trigger_105021507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//活力丹
function Trigger_105021508(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//活力丹
function Trigger_105021509(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//活力丹
function Trigger_105021510(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//活力丹
function Trigger_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//极效活力丹
function Trigger_105021501_105021511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	%curVigor = %player.getVigor();
	%maxVigor = %player.getMaxVigor();

	if (%curVigor ==  %maxVigor)
	{
		%Txt = "您的活力已满，无需使用活力丹";
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

function Trigger_105109500(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109500_105109507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105109508,105109516,105105146,105105046,105109501); }//测试礼包（LV：30）
function Trigger_105109501(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109500_105109507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105109509,105109517,105105146,105105046,105109502); }//测试礼包（LV：40）
function Trigger_105109502(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109500_105109507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105109510,105109518,105105146,105105046,105109503); }//测试礼包（LV：50）
function Trigger_105109503(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109500_105109507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105109511,105109519,105105146,105105046,105109504); }//测试礼包（LV：60）
function Trigger_105109504(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109500_105109507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105109512,105109520,105105146,105105046,105109505); }//测试礼包（LV：70）
function Trigger_105109505(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109500_105109507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105109513,105109521,105105146,105105046,105109506); }//测试礼包（LV：80）
function Trigger_105109506(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109500_105109507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105109514,105109522,105105146,105105046,105109507); }//测试礼包（LV：90）
function Trigger_105109507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109500_105109507(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,105109515,105109523,105105146,105105046,0); }//测试礼包（LV：100）
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

function Trigger_105109508(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109508_105109515(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,-1); }//测试装备礼包（LV：30）
function Trigger_105109509(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109508_105109515(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,0); }//测试装备礼包（LV：40）
function Trigger_105109510(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109508_105109515(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1); }//测试装备礼包（LV：50）
function Trigger_105109511(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109508_105109515(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2); }//测试装备礼包（LV：60）
function Trigger_105109512(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109508_105109515(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,3); }//测试装备礼包（LV：70）
function Trigger_105109513(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109508_105109515(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,4); }//测试装备礼包（LV：80）
function Trigger_105109514(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109508_105109515(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,5); }//测试装备礼包（LV：90）
function Trigger_105109515(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109508_105109515(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,6); }//测试装备礼包（LV：100）
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

function Trigger_105109516(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109516_105109523(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,"113050003 40","116080005 10"); }//测试道具礼包（LV：30）
function Trigger_105109517(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109516_105109523(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,"113050013 40","116080006 10"); }//测试道具礼包（LV：40）
function Trigger_105109518(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109516_105109523(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,"113050023 40","116080007 10"); }//测试道具礼包（LV：50）
function Trigger_105109519(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109516_105109523(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,"113050033 40","116080008 10"); }//测试道具礼包（LV：60）
function Trigger_105109520(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109516_105109523(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,"113050043 40","116080009 10"); }//测试道具礼包（LV：70）
function Trigger_105109521(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109516_105109523(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,"113050053 40","116080010 10"); }//测试道具礼包（LV：80）
function Trigger_105109522(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109516_105109523(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,"113050063 40","116080011 10"); }//测试道具礼包（LV：90）
function Trigger_105109523(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109516_105109523(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,"113050073 40","116080012 10"); }//测试道具礼包（LV：100）
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
function Trigger_105105001(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ) { Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,1); }//1元宝兑换券
function Trigger_105105002(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,2); }//2元宝兑换券
function Trigger_105105003(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,3); }//3元宝兑换券
function Trigger_105105004(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,4); }//4元宝兑换券
function Trigger_105105005(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,5); }//5元宝兑换券
function Trigger_105105006(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,6); }//6元宝兑换券
function Trigger_105105007(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,7); }//7元宝兑换券
function Trigger_105105008(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,8); }//8元宝兑换券
function Trigger_105105009(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,9); }//9元宝兑换券
function Trigger_105105010(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,10); }//10元宝兑换券
function Trigger_105105011(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,20); }//20元宝兑换券
function Trigger_105105012(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,30); }//30元宝兑换券
function Trigger_105105013(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,40); }//40元宝兑换券
function Trigger_105105014(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,50); }//50元宝兑换券
function Trigger_105105015(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,60); }//60元宝兑换券
function Trigger_105105016(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,70); }//70元宝兑换券
function Trigger_105105017(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,80); }//80元宝兑换券
function Trigger_105105018(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,90); }//90元宝兑换券
function Trigger_105105019(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,100); }//100元宝兑换券
function Trigger_105105020(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,200); }//200元宝兑换券
function Trigger_105105021(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,300); }//300元宝兑换券
function Trigger_105105022(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,400); }//400元宝兑换券
function Trigger_105105023(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,500); }//500元宝兑换券
function Trigger_105105024(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,600); }//600元宝兑换券
function Trigger_105105025(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,700); }//700元宝兑换券
function Trigger_105105026(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,800); }//800元宝兑换券
function Trigger_105105027(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,900); }//900元宝兑换券
function Trigger_105105028(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,1000); }//1000元宝兑换券
function Trigger_105105029(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,2000); }//2000元宝兑换券
function Trigger_105105030(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,3000); }//3000元宝兑换券
function Trigger_105105031(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,4000); }//4000元宝兑换券
function Trigger_105105032(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,5000); }//5000元宝兑换券
function Trigger_105105033(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,6000); }//6000元宝兑换券
function Trigger_105105034(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,7000); }//7000元宝兑换券
function Trigger_105105035(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,8000); }//8000元宝兑换券
function Trigger_105105036(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,9000); }//9000元宝兑换券
function Trigger_105105037(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,10000); }//10000元宝兑换券
function Trigger_105105038(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,20000); }//20000元宝兑换券
function Trigger_105105039(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,30000); }//30000元宝兑换券
function Trigger_105105040(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,40000); }//40000元宝兑换券
function Trigger_105105041(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,50000); }//50000元宝兑换券
function Trigger_105105042(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,60000); }//60000元宝兑换券
function Trigger_105105043(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,70000); }//70000元宝兑换券
function Trigger_105105044(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,80000); }//80000元宝兑换券
function Trigger_105105045(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,90000); }//90000元宝兑换券
function Trigger_105105046(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1,100000); }//100000元宝兑换券
function Trigger_105105101(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,1000); }//10银兑换券
function Trigger_105105102(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,2000); }//20银兑换券
function Trigger_105105103(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,3000); }//30银兑换券
function Trigger_105105104(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,4000); }//40银兑换券
function Trigger_105105105(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,5000); }//50银兑换券
function Trigger_105105106(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,6000); }//60银兑换券
function Trigger_105105107(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,7000); }//70银兑换券
function Trigger_105105108(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,8000); }//80银兑换券
function Trigger_105105109(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,9000); }//90银兑换券
function Trigger_105105110(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,10000); }//1金币兑换券
function Trigger_105105111(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,20000); }//2金币兑换券
function Trigger_105105112(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,30000); }//3金币兑换券
function Trigger_105105113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,40000); }//4金币兑换券
function Trigger_105105114(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,50000); }//5金币兑换券
function Trigger_105105115(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,60000); }//6金币兑换券
function Trigger_105105116(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,70000); }//7金币兑换券
function Trigger_105105117(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,80000); }//8金币兑换券
function Trigger_105105118(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,90000); }//9金币兑换券
function Trigger_105105119(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,100000); }//10金币兑换券
function Trigger_105105120(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,200000); }//20金币兑换券
function Trigger_105105121(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,300000); }//30金币兑换券
function Trigger_105105122(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,400000); }//40金币兑换券
function Trigger_105105123(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,500000); }//50金币兑换券
function Trigger_105105124(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,600000); }//60金币兑换券
function Trigger_105105125(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,700000); }//70金币兑换券
function Trigger_105105126(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,800000); }//80金币兑换券
function Trigger_105105127(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,900000); }//90金币兑换券
function Trigger_105105128(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,1000000); }//100金币兑换券
function Trigger_105105129(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,2000000); }//200金币兑换券
function Trigger_105105130(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,3000000); }//300金币兑换券
function Trigger_105105131(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,4000000); }//400金币兑换券
function Trigger_105105132(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,5000000); }//500金币兑换券
function Trigger_105105133(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,6000000); }//600金币兑换券
function Trigger_105105134(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,7000000); }//700金币兑换券
function Trigger_105105135(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,8000000); }//800金币兑换券
function Trigger_105105136(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,9000000); }//900金币兑换券
function Trigger_105105137(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,10000000); }//1000金币兑换券
function Trigger_105105138(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,20000000); }//2000金币兑换券
function Trigger_105105139(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,30000000); }//3000金币兑换券
function Trigger_105105140(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,40000000); }//4000金币兑换券
function Trigger_105105141(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,50000000); }//5000金币兑换券
function Trigger_105105142(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,60000000); }//6000金币兑换券
function Trigger_105105143(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,70000000); }//7000金币兑换券
function Trigger_105105144(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,80000000); }//8000金币兑换券
function Trigger_105105145(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,90000000); }//9000金币兑换券
function Trigger_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	{ Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2,100000000); }//10000金币兑换券
function Trigger_105105001_105105146(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%Moneytype,%Money)
{
	if (%Player.GetMoney(%Moneytype) + %Money >= 1900000000)
	{
		SendOneScreenMessage(2,"您的可携带金币数量已达上限，无法使用此兑换券",%Player);
		return;
	}
	%Player.PutItem(%Type,-1);
	if (%Player.Additem(1,%type))
		%Player.AddMoney(%Money,%Moneytype,1,%type);
}
//	每日签到礼包
function Trigger_105180020(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"请确保包裹中至少有一个空位！",%Player);
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
			SendOneChatMessage($chatMsg_Person,"<t>您拥有昆仑仙牌，额外获得</t>" @ %Exp @ "<t>经验</t>",%Player);
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
		%Player.SetSchBuff(2031);//持续加经验	持续经验	10分钟			100%		持续10分钟  每10s给一次 人物等级对应的经验*3
		%Player.SetSchBuff(2032);
	}
}
//	每日签到礼包
function Trigger_105180025(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"请确保包裹中至少有一个空位！",%Player);
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
			SendOneChatMessage($chatMsg_Person,"<t>您拥有昆仑仙牌，额外获得</t>" @ %Exp @ "<t>经验</t>",%Player);
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
		%Player.SetSchBuff(2031);//持续加经验	持续经验	10分钟			100%		持续10分钟  每10s给一次 人物等级对应的经验*3
		%Player.SetSchBuff(2032);
	}
}

function Trigger_105105351(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,5); }//帮派贡献( 5 )	
function Trigger_105105352(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,10); }//帮派贡献( 10 )	
function Trigger_105105353(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,20); }//帮派贡献( 20 )	
function Trigger_105105354(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,30); }//帮派贡献( 30 )	
function Trigger_105105355(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,40); }//帮派贡献( 40 )	
function Trigger_105105356(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,50); }//帮派贡献( 50 )	
function Trigger_105105357(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,60); }//帮派贡献( 60 )	
function Trigger_105105358(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,70); }//帮派贡献( 70 )	
function Trigger_105105359(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,80); }//帮派贡献( 80 )	
function Trigger_105105360(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,90); }//帮派贡献( 90 )	
function Trigger_105105361(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,100); }//帮派贡献( 100 )	
function Trigger_105105362(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,200); }//帮派贡献( 200 )	
function Trigger_105105363(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,300); }//帮派贡献( 300 )	
function Trigger_105105364(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,400); }//帮派贡献( 400 )	
function Trigger_105105365(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,500); }//帮派贡献( 500 )	
function Trigger_105105366(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,600); }//帮派贡献( 600 )	
function Trigger_105105367(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,700); }//帮派贡献( 700 )	
function Trigger_105105368(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,800); }//帮派贡献( 800 )	
function Trigger_105105369(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,900); }//帮派贡献( 900 )	
function Trigger_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1000); }//帮派贡献( 1000 )
function Trigger_105105351_105105370(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%Sorce)
{
	%PlayerID = %Player.GetPlayerID();
	%orgID = SptOrg_GetOrgID(%PlayerID);
	if (%orgID <= 0)
	{
		SendOneChatMessage($chatMsg_Person,"<t>需要加入一个帮派后才可使用。</t>",%Player);
		SendOneScreenMessage(2,"需要加入一个帮派后才可使用",%Player);
		return;
	}
	%Player.PutItem(%Type,-1);
	if (%Player.Additem(1,%Type))
		AddFamily_SW_GX(%Player,%Sorce,%Sorce);
}

function Trigger_105109391(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109391_105109395(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,0); }//一阶施法材料包
function Trigger_105109392(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109391_105109395(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1); }//二阶施法材料包
function Trigger_105109393(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109391_105109395(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2); }//三阶施法材料包
function Trigger_105109394(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109391_105109395(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,3); }//四阶施法材料包
function Trigger_105109395(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109391_105109395(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,4); }//五阶施法材料包
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
function Trigger_105090931(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105090931_105090935(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//洗心录
function Trigger_105090932(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105090931_105090935(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//昆仑特赦
function Trigger_105090933(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105090931_105090935(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//丹书铁卷
function Trigger_105090934(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105090931_105090935(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//免罪文书
function Trigger_105090935(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105090931_105090935(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }//天帝御赦
function Trigger_105090931_105090935(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	%PkValue = %player.getPkValue();
	if (%PkValue <= 0)
	{
		SendOneScreenMessage(2,"您当前没有善恶值",%Player);
		return;
	}
	%Player.PutItem(%type,-1);
	if (%Player.AddItem(1,%Type))
	{
		%CanTakeNum = GetItemData(%Type,$Item_Data_PresID);
		%PkValue = %PkValue - %CanTakeNum;
		if (%PkValue < 0)
			%PkValue = 0;
		%Player.SetPkValue(%PkValue); //设置善恶值

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
				%Text2 = %PlayerName2 @ "<t>使用了</t>" @ %ItemName2 @ "<t>，得到城主特赦减免</t>" @ %Number2 @ "<t>点善恶值</t>";
			case 105090933:
				%Text1 = %PlayerName1 @ "<t>使用了</t>" @ %ItemName1 @ "<t>，得到城主特赦减免</t>" @ %Number1 @ "<t>点善恶值。</t>";
				%Text2 = %PlayerName2 @ "<t>使用了</t>" @ %ItemName2 @ "<t>，得到城主特赦减免</t>" @ %Number2 @ "<t>点善恶值</t>";
			case 105090934:
				%Text1 = "<t>放下屠刀立地成佛！</t>" @ %PlayerName1 @ "<t>使用了</t>" @ %ItemName1 @ "<t>，减免了</t>" @ %Number1 @ "<t>点善恶值。</t>";
				%Text2 = "<t>放下屠刀立地成佛！</t>" @ %PlayerName2 @ "<t>使用了</t>" @ %ItemName2 @ "<t>，减免了</t>" @ %Number2 @ "<t>点善恶值</t>";
			case 105090935:
				%Text1 = %PlayerName1 @ "<t>使用了</t>" @ %ItemName1 @ "<t>清空了善恶值，决定洗心革面，重新做人！！</t>";
				%Text2 = %PlayerName2 @ "<t>使用了</t>" @ %ItemName2 @ "<t>清空了善恶值，决定洗心革面，重新做人</t>";
		}
		if (%Text1 !$= "")
			SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
		if (%Text2 !$= "")
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
}
function Trigger_105104901(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1); }//1万经验卷
function Trigger_105104902(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2); }//2万经验卷
function Trigger_105104903(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,3); }//3万经验卷
function Trigger_105104904(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,4); }//4万经验卷
function Trigger_105104905(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,5); }//5万经验卷
function Trigger_105104906(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,6); }//6万经验卷
function Trigger_105104907(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,7); }//7万经验卷
function Trigger_105104908(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,8); }//8万经验卷
function Trigger_105104909(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,9); }//9万经验卷
function Trigger_105104910(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,10); }//10万经验卷
function Trigger_105104911(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,20); }//20万经验卷
function Trigger_105104912(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,30); }//30万经验卷
function Trigger_105104913(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,40); }//40万经验卷
function Trigger_105104914(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,50); }//50万经验卷
function Trigger_105104915(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,60); }//60万经验卷
function Trigger_105104916(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,70); }//70万经验卷
function Trigger_105104917(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,80); }//80万经验卷
function Trigger_105104918(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,90); }//90万经验卷
function Trigger_105104919(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,100); }//100万经验卷
function Trigger_105104920(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,200); }//200万经验卷
function Trigger_105104921(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,300); }//300万经验卷
function Trigger_105104922(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,400); }//400万经验卷
function Trigger_105104923(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,500); }//500万经验卷
function Trigger_105104924(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,600); }//600万经验卷
function Trigger_105104925(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,700); }//700万经验卷
function Trigger_105104926(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,800); }//800万经验卷
function Trigger_105104927(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,900); }//900万经验卷
function Trigger_105104928(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1000); }//1000万经验卷
function Trigger_105104929(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,2000); }//2000万经验卷
function Trigger_105104930(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,3000); }//3000万经验卷
function Trigger_105104931(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,4000); }//4000万经验卷
function Trigger_105104932(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,5000); }//5000万经验卷
function Trigger_105104933(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,6000); }//6000万经验卷
function Trigger_105104934(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,7000); }//7000万经验卷
function Trigger_105104935(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,8000); }//8000万经验卷
function Trigger_105104936(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,9000); }//9000万经验卷
function Trigger_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105104901_105104937(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,10000); }//10000万经验卷
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

//改名卡
function Trigger_105109063(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	%Player.ShowDialogOk(2000000033,33,1);
}

function Trigger_105109121(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109121_105109122(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1); }//	聚宝盆免费卡( 1次 )
function Trigger_105109122(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109121_105109122(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,5); }//	聚宝盆免费卡( 5次 )
function Trigger_105109121_105109122(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%Count)
{
	%Player.PutItem(%type,-1);
	if (%Player.AddItem(1,%type))
	{
		%Act0 = GetAct(%Player,3038,0);
		%Act1 = GetAct(%Player,3038,1);//今天已经兑换次数
		%GoldUseTimes = mfloor(%Act0 /1000);//已经使用元宝点击的次数 
		%HaveMianFeiTimes = %Act0%1000;//剩余可用免费次数
		%HaveMianFeiTimes = %HaveMianFeiTimes + %Count;
		%Act0 = %GoldUseTimes * 1000 + %HaveMianFeiTimes;
		SetAct(%Player,3038,%Act0,%Act1);
		HelpDirectByIndex(%Player.GetPlayerID(),23);	//通讯客户端
	}
}

function Trigger_105109130(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)	//幸运鲜花
{
	%Player.PutItem(%type,-1);
	if (%Player.AddItem(1,%type))
	{
		if (%Player.GetBuffCount(39023,1) >= 1)
			%Player.Removebuff(390230001);
		%Player.AddBuff(390250001,%Player,1);
		%Text = "您获得幸运鲜花的祝福，在此时间内，免疫诅咒。";
		SendOneScreenMessage(2,%Text,%Player);
		SendOneChatMessage($chatMsg_System,%Text,%Player);
	}
}

function Trigger_106050305(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	if (%Player.IsAcceptedMission(20146))
	{
		%Text = "您已接取【扇贝的线索】任务，请先完成才能再次接取。";
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


function Trigger_105090911(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)//昆仑通宝赠品
{
	%Count = %Player.GetItemCount(%Type);
	%Level =%Player.GetLevel();
	if (%Level < 75)
	{
		%Text = "当你达到75级之后，才可以使用此物";
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
function Trigger_105281001(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)//仙童使者
{
	if (%Player.sptIsDesignationExist(1401))
	{
		%Text = "您已经获得此称号";
		SendOneScreenMessage(2,%Text,%Player);
		SendOneChatMessage($chatMsg_System,%Text,%Player);
		return;
	}
	%Player.PutItem(%type,-1);
	if (%Player.additem(1,%type))
		%Player.AddDesignation(1401);//添加称号
}

function Trigger_105109081(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)//攻·琥珀封印
{
	%Player.PutItem(%Type,-1);
	%Player.PutItem(105109083,1);
	%PLayer.Additem(1,%type);
}
function Trigger_105109082(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)//防·琥珀封印
{
	%Player.PutItem(%Type,-1);
	%Player.PutItem(105109084,1);
	%PLayer.Additem(1,%type);
}



function Trigger_105109531(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ){ Trigger_105109531_105109536(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ, 690742, 11); }//11朵玫瑰
function Trigger_105109532(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ){ Trigger_105109531_105109536(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ, 690743, 99); }//99朵玫瑰
function Trigger_105109533(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ){ Trigger_105109531_105109536(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ, 690741, 999); }//999朵玫瑰
function Trigger_105109534(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ){ Trigger_105109531_105109536(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ, 690742, 11); }//11朵玫瑰(赠品)
function Trigger_105109535(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ){ Trigger_105109531_105109536(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ, 690743, 99); }//99朵玫瑰(赠品)
function Trigger_105109536(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ){ Trigger_105109531_105109536(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ, 690741, 999); }//999朵玫瑰(赠品)
function Trigger_105109531_105109536(%Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ, %Packet, %Sorce)
{
	%PlayerID = %Player.GetPlayerID();
	%Target   = %Player.Gettarget();
	%TargetID = %Target.GetPlayerID();

	if (SptGetFirendValue(%PlayerID, %TargetID) < 1)	//不是好友
	{
		SendOneScreenMessage(2, "【玫瑰花】只能对好友使用！", %Player);
		return;
	}

	if (%Target.getclassname() !$= "Player")	//目标不是玩家
	{
		SendOneScreenMessage(2, "【玫瑰花】只能对其他玩家使用！", %Player);
		return;
	}

	%TargetSex = %Target.GetSex();
	%Player.PutItem(%Type, -1);
	if (!%Player.AddItem(1, %type))
		return;


	//%Target.AddFlowerStarVal(%Cnt); //送花触发花榜记录
	
	//sptUseItemAddFriendValue(%PlayerID, %TargetID, %Sorce);	//增加双方友好度
	

	AddPrestige(%Target, 4119, %Sorce);//记录鲜花值
	AddPrestige(%Player, 4120, %Sorce);//记录绿叶值

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

		%Text1 = %PlayerName1 @ "<t>送给</t>" @ %TargetName1 @ %Count1 @ "<t>朵玫瑰，惹得对方心跳不已。</t>";
		%Text2 = %PlayerName2 @ "<t>送给</t>" @ %TargetName2 @ %Count2 @ "<t>朵玫瑰，惹得对方心跳不已。</t>";

		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
	
}

//一包聚神散、凝血丹
function Trigger_105109342(%Conv,%Player,%X_ID,%State,%TriggerType,%TriggerID,%Param,%XYZ){Trigger_GiveDrugsByLv(%Player, %X_ID, 105020103, 200);}
function Trigger_105109343(%Conv,%Player,%X_ID,%State,%TriggerType,%TriggerID,%Param,%XYZ){Trigger_GiveDrugsByLv(%Player, %X_ID, 105020153, 200);}
function Trigger_GiveDrugsByLv(%Player, %X_ID, %Lv0ItemID, %Num)
{
	%ItemID = getItemTrueIDOrCnt(%Player, %Lv0ItemID, 0, 0);
	
	%Player.PutItem(%X_ID,-1);
	%Player.PutItem(%ItemID,%Num);
	%Player.AddItem(5, %X_ID);
}



