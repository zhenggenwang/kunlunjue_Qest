//■■■■■■■■■■■任务交接条件判断■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■中途任务条件判断■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■■领取任务前置条件判断■■■■■■■■■■■■■■
//■■■■■■■■■■■■完成任务前置条件判断■■■■■■■■■■■■■■

//■■■■■■■■■■■发送原因消息■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■任务交接条件判断■■■■■■■■■■■■■■■■■
//if(%Other == 1) 判断是否可以给予道具，并给予
//if(%Other == 2) 需要判断特殊条件


function CanDoThisMission(%Player,%Mid,%Type,%Other,%Msg)
{
	//接受任务的条件判断
	if (%Type == 1)
	{
		//是否已经完成当前任务
		if (%Player.IsFinishedMission(%Mid))
			return SendWhyMsg(%Player,"B",%Type,%Msg);

		//是否已经接受当前任务
		if (%Player.IsAcceptedMission(%Mid))
			return SendWhyMsg(%Player,"A",%Type,%Msg);

		//判断任务接受等级	//是否已经达到任务接受等级
		%Lv = (%Other < 2) ? $Mission_Data_LvA : $Mission_Data_SeeLvA;
		if (%Player.GetLevel() < GetMissionData(%Mid,%Lv))
			return SendWhyMsg(%Player,"L",%Type,%Msg);

		//职业判断
		%PreClasses  = GetMissionData(%Mid,$Mission_Data_Family);
		if (%PreClasses > 0)
		{
			//echo("%PreClasses===" @ %PreClasses);
			%Classes = %Player.GetClasses(0);
			for (%i = 0; %i < 5; %i++)
			{
				if (HasBit(%PreClasses,%i) > 0)
					if (%Classes == (%i+1))
					{
						%ClassesH = "Pass";
						break;
					}
			}
			if (%ClassesH !$= "Pass")
				return SendWhyMsg(%Player,"BI",%Type,%Msg);
		}

		//门阀判断
		%PreFamily  = GetMissionData(%Mid,$Mission_Data_Classes);
		if (%PreFamily > 0)
		{
			%Family = %Player.GetFamily();
			for (%i = 0; %i < 4; %i++)
			{
				if (HasBit(%PreFamily,%i) > 0)
					if (%Family == (%i + 1))
					{
						%FamilyH = "Pass";
						break;
					}
			}
			if (%FamilyH !$= "Pass")
				return SendWhyMsg(%Player,"BJ",%Type,%Msg);
		}

		//出身地判断
		%PreHomeplace  = GetMissionData(%Mid,$Mission_Data_Homeplace);
		if (%PreHomeplace > 0)
		{
			%Homeplace = GetHomeplace(%Player);
			for (%i = 0; %i < 5; %i++)
			{
				if (HasBit(%PreHomeplace,%i) > 0)
					if (%Homeplace == (%i + 1))
					{
						%HomeplaceH = "Pass";
						break;
					}
			}
			if (%HomeplaceH !$= "Pass")
				return SendWhyMsg(%Player,"F",%Type,%Msg);
		}

		//前置条件任务
		%PreMid = GetMissionData(%Mid,$Mission_Data_PreMid);

		//单项前置任务判断
		if (%PreMid > 1)
		{
			//如果任务未完成，则返回错误提示
			if (!%Player.IsFinishedMission(%PreMid))
				return SendWhyMsg(%Player,"C",%Type,%Msg);
		}

		//判断前置特殊判断是否满足
		//%Mission_EspeciallyTrigger = GetMissionData( %Mid, $Mission_Data_EspeciallyTrigger );
		/*
		if ( HasBit( %Mission_EspeciallyTrigger, 0 ) > 0 )
		{
		%MidName = "Mission_Begin_Front_"@ %Mid;
		%Mission_Begin = eval( %MidName @ "(%Npc, %Player, %Conv, %Param, %Mid);" );
		//echo( "判断前置特殊判断是否满足%Mission_Begin ====" @ %Mission_Begin );
		//如果是客户端 并且 值为-1则返回错误
		if ( ( $Now_Script == 1 ) && ( %Mission_Begin == -1 ) )
		return %Mission_Begin;
		else if ( %Other > 0 )
		{
		//如果不等于空则返回错误
		if ( %Mission_Begin !$= "" )
		return %Mission_Begin;
		}
		}
		*/
		//特殊任务特殊处理
		if (%Mid >= 20001 && %Mid <= 20024)
		{
			%MidName = "Mission_Begin_Front_"@ %Mid;
			%Mission_Begin = eval(%MidName @ "(%Npc, %Player, %Conv, %Param, %Mid);");
			if (%Mission_Begin !$= "")
				return %Mission_Begin;
		}
		//判断是否要再额外计算任务条件
		if (%Other == 1)
		{
			//是否处于不健康状态
			if (%Player.GetCaptivateState() >= 1)
				return SendWhyMsg(%Player,"V",0,1);

			//已经接受的任务数量是否已满
			if (%Player.GetAcceptedMission() >= 20)
				return SendWhyMsg(%Player,"Q",%Type,%Msg);

			%ItemAdd = GetMissionData(%Mid,$Mission_Data_ItemAdd);		//接任务给予的道具
			%ItemAddDel = GetMissionData(%Mid,$Mission_Data_ItemDelete);	//是否要扣除以上道具

			if (($Now_Script == 2)&&(%ItemAdd !$= "0"))
			{
				%F = GetWordCount(%ItemAdd,";") / 2;

				for (%i = 0; %i < %F; %i++)
				{
					%Item = GetWord(%ItemAdd,%i * 2,";");
					%Num  = GetWord(%ItemAdd,%i * 2 + 1,";");

					if ((%Item $= "")&&(%Num $= ""))
						break;
					else
					{
						%Classes = %Player.GetClasses(0) - 1;
						%DataClasses = GetItemData(%Item,113);

						if ((%Num > 0) && ((%DataClasses == 0) || (HasBit(%DataClasses,%Classes))))
						{
							//直接装备道具
							%ConvText = GetMissionData(%Mid,$Mission_Data_EspeciallyTrigger);

							%bItemAdd = %Player.PutItem(%Item,%Num);
							%ItemText = %Item;

							//获取是否设置物品绑定
							%Mission_EspeciallyTrigger = GetMissionData(%Mid,$Mission_Data_EspeciallyTrigger);
							if (HasBit(%Mission_EspeciallyTrigger,10) > 0)
								%Player.SetPutItemProperty(%bItemAdd,1,%Player.GetPlayerID());
						}
					}
				}

				if (%ItemText > 0)
					%bItemAdd = %Player.AddItem(1,%Mid);

				if (!%bItemAdd)
					return SendWhyMsg(%Player,"I",%Type,%Msg);
			}

			//判定是否需要打开包裹并提示
			%ConvText = GetMissionData(%Mid,$Mission_Data_Conv);
			if ((HasBit(%ConvText,2) > 0) && (%ItemText > 0))
				ServerOnSptAction(%Player.GetPlayerID(),%ItemText,1);
		}
	}

	//交付任务的条件判断
	if (%Type == 2)
	{
		if (%Player.IsFinishedMission(%Mid))		{ return SendWhyMsg(%Player,"B",%Type,%Msg); }		//是否已经完成当前任务
		if (!%Player.IsAcceptedMission(%Mid))	{ return SendWhyMsg(%Player,"A",%Type,%Msg); }		//是否已经接受当前任务

		//任务获取道具是否足够
		for (%i = 0; %i < 9; %i++)
		{
			%ItemGet = %Player.GetMissionFlag(%Mid,2100 + %i);
			%GetNum  = %Player.GetMissionFlag(%Mid,2200 + %i);

			if (%ItemGet == 0)
				break;

			if (%Player.GetMissionFlag(%Mid,2300 + %i) < %Player.GetMissionFlag(%Mid,2200 + %i))
				return SendWhyMsg(%Player,"G",%Type,%Msg);
		}

		//接任务时给的道具是否足够数量
		if (GetMissionData(%Mid,$Mission_Data_ItemDelete) > 0)//是否要扣除接任务给的道具道具
			for (%i = 0; %i < 9; %i++)
			{
				%ItemAdd    = %Player.GetMissionFlag(%Mid,2150 + %i);
				%AddNum     = %Player.GetMissionFlag(%Mid,2250 + %i);

				if (%ItemAdd == 0)
					break;

				if (%Player.GetMissionFlag(%Mid,2350 + %i) < %Player.GetMissionFlag(%Mid,2250 + %i))
					return SendWhyMsg(%Player,"S",%Type,%Msg);
			}

		//任务使用道具数量是否足够
		for (%i = 0; %i < 9; %i++)
		{
			%ItemUse = %Player.GetMissionFlag(%Mid,2400 + %i);
			%UseNum  = %Player.GetMissionFlag(%Mid,2500 + %i);

			if (%ItemUse == 0)
				break;

			if (%Player.GetMissionFlag(%Mid,2600 + %i) < %UseNum)
				return SendWhyMsg(%Player,"U",%Type,%Msg);
		}

		//任务使用道具触发目标数量是否足够
		for (%i = 0; %i < 9; %i++)
		{
			%Target = %Player.GetMissionFlag(%Mid,1100 + %i);
			%TarNum = %Player.GetMissionFlag(%Mid,1200 + %i);

			if (%Target == 0)
				break;

			if (%Player.GetMissionFlag(%Mid,1300 + %i) < %TarNum)
				return SendWhyMsg(%Player,"T",%Type,%Msg);
		}

		//任务中途的对话目标数量是否足够
		for (%i = 0; %i < 9; %i++)
		{
			%NpcX    = %Player.GetMissionFlag(%Mid,1150 + %i);
			%NpcXNum = %Player.GetMissionFlag(%Mid,1250 + %i);

			if (%NpcX == 0)
				break;

			if ((%NpcX > 0)&&(%Player.GetMissionFlag(%Mid,1350 + %i) < %NpcXNum)&&(%Other == 0))
				return SendWhyMsg(%Player,"N",%Type,%Msg);
		}

		//任务怪物击败数量是否足够
		for (%i = 0; %i < 9; %i++)
		{
			%Monster = %Player.GetMissionFlag(%Mid,3100 + %i);
			%KillNum = %Player.GetMissionFlag(%Mid,3200 + %i);

			if (%Monster == 0)
				break;

			if (%Player.GetMissionFlag(%Mid,3300 + %i) < %Player.GetMissionFlag(%Mid,3200 + %i))
				return SendWhyMsg(%Player,"M",%Type,%Msg);
		}

		//判断纯粹旗标计数
		for (%i = 0; %i < 9; %i++)
		{
			%Step8X_Min = %Player.GetMissionFlag(%Mid,8100 + %i);
			%Step8X_Max = %Player.GetMissionFlag(%Mid,8000 + %i);

			if (%Step8X_Min == 0)
				break;

			if (%Player.GetMissionFlag(%Mid,8100 + %i) < %Player.GetMissionFlag(%Mid,8000 + %i))
				return SendWhyMsg(%Player,"P",%Type,%Msg);
		}

		//任务采集触发目标数量是否足够
		for (%i = 0; %i < 9; %i++)
		{
			%CollectGet = %Player.GetMissionFlag(%Mid,2130 + %i);
			%CollectNum = %Player.GetMissionFlag(%Mid,2230 + %i);

			if (%CollectGet == 0)
				break;

			if (%Player.GetMissionFlag(%Mid,2330 + %i) < %CollectNum)
				return SendWhyMsg(%Player,"BK",%Type,%Msg);

		}

		//判断前置特殊判断是否满足
		%Mission_EspeciallyTrigger = GetMissionData(%Mid,$Mission_Data_EspeciallyTrigger);
		if (HasBit(%Mission_EspeciallyTrigger,1) > 0)
		{
			%MidName = "Mission_End_Front_"@ %Mid;
			if (isFunction(%MidName))
				%Mission_End = eval("%Mission_End = " @ %MidName @ "(%Npc, %Player, %Conv, %Param, %Mid);");
			if (($Now_Script == 1) && (%Mission_End == -1))
				return %Mission_End;
			else if (%Other > 0)
			{
				if (%Mission_End !$= "")
					return %Mission_End;
			}
		}

		//判断是否要再额外计算任务条件
		if (%Other == 1)
		{
			//是否已经达到任务交付等级
			echo("是否已经达到任务交付等级   " @ GetMetempsychosisLeve(%Player) @ "   " @ GetMissionData(%Mid,$Mission_Data_LvZ));
			if (GetMetempsychosisLeve(%Player) < GetMissionData(%Mid,$Mission_Data_LvZ))
				return SendWhyMsg(%Player,"Z",%Type,%Msg);
		}
	}

	return "";
}


//■■■■■■■■■■■中途任务条件判断■■■■■■■■■■■■■■■■■
function CanDoMidwayMission(%Npc,%Player,%Mid,%Type,%Other,%Msg)
{
	//是否已经完成当前任务
	if (%Player.IsFinishedMission(%Mid))
		return SendWhyMsg(%Player,"B",%Type,%Msg);

	//是否已经接受当前任务
	if (!%Player.IsAcceptedMission(%Mid))
		return SendWhyMsg(%Player,"A",%Type,%Msg);

	switch (%Mid)
	{
		case 10001:return 0;//主线任务
		case 20205:return 0;//云游隐士
		case 10191:return 0;
		case 10241:return 0;
		case 10291:return 0;
		case 30001:return 0;//生活技能
		case 30002:return 0;
	}
	//任务中途的对话目标数量是否足够
	for (%i = 0; %i < 9; %i++)
	{
		%NpcX    = %Player.GetMissionFlag(%Mid,1150 + %i);	//设置,目标编号
		%NpcXNum = %Player.GetMissionFlag(%Mid,1250 + %i);	//设置,目标触发总数

		if (%NpcX == 0)
			break;

		if ((%Npc == %NpcX) || (%Npc.GetDataID() == %NpcX))
			if (%Player.GetMissionFlag(%Mid,1350 + %i) != %NpcXNum)
				return 1150 + %i;
	}

	return "";
}

//■■■■■■■■■■■发送原因消息■■■■■■■■■■■■■■■■■■■
function SendWhyMsg(%Player,%TiaoJian,%Type,%Msg)
{
	%Txt1 = "";
	%Txt2 = "";

	//判断是否要发送消息
	if (%Msg == 1)
		for (%i = 0; %i < 99; %i++)
		{
			%Why = GetWord(%TiaoJian,%i);
			if (%Why $= "")
				break;
			else
			{
				switch$(%Why)
				{
		case "A":%Txt1 = "您已经接受了此任务";
		case "B":%Txt1 = "您已经完成了此任务";
		case "C":%Txt1 = "您尚未完成前置任务";
		case "D":%Txt1 = "您未能拥有所需的效果";
		case "E":%Txt1 = "时间已达上限，无法再增加了";
		case "F":%Txt1 = "您的圣地不符";
		case "G":%Txt1 = "用于交任务的物品条件不满足";

		case "H":%Txt1 = "请先完成当前的操作再试试吧";
		case "I":%Txt1 = "您背包已满，放不下物品了";
		case "J":%Txt1 = "角色等级低于10级，无法使用本功能";
		case "K":%Txt1 = "本功能只能在【线程1】使用";
		case "L":%Txt1 = "您的等级过低，无法领取任务";
		case "M":%Txt1 = "用于交任务的怪物条件不满足";
		case "N":%Txt1 = "您尚未找到所有需要对话的NPC";

		case "O":%Txt1 = "您的经验不足";
		case "P":%Txt1 = "您学会相应的生活技能";
		case "Q":%Txt1 = "您身上接受的任务数量已满";
		case "R":%Txt1 = "您正在副本内，无法切换地图";
		case "S":%Txt1 = "用于交任务的物品条件不满足";
		case "T":%Txt1 = "用于交任务的条件不满足";

		case "U":%Txt1 = "用于交任务的物品条件不满足";
		case "V":%Txt1 = "您已经进入不健康状态，无法接交任务";
		case "W":%Txt1 = "您的经验已满足升级值，40级后请手动升级";
		case "X":%Txt1 = "您的必需先完成【女娲的灵佑】任务";
		case "Y":%Txt1 = "您的经验已经达到上限，无法累积，请升级";
		case "Z":%Txt1 = "您的等级过低，无法完成任务";

		case "AA":%Txt1 = "您的角色已死亡，请先选择复活";
		case "AB":%Txt1 = "您的角色正在战斗中，请稍候再试";
		case "AC":%Txt1 = "您的队员不在附近，请先集合再试试吧";
		case "AD":%Txt1 = "该功能只能是队长才可执行";
		case "AE":%Txt1 = "队伍不满足该功能的开启条件";
		case "AF":%Txt1 = "您不满足该功能的开启条件";
		case "AG":%Txt1 = "当前场景内的天劫事件已经开启";
		case "AH":%Txt1 = "天劫事件正在重置，请稍候再试";
		case "AI":%Txt1 = "您需要将当前的升级经验累积满，才可进行渡劫";
		case "AJ":%Txt1 = "您今天无法再次使用该功能了，请明天再来吧";
		case "AK":%Txt1 = "您已经接取了帮派任务，请先完成该任务";
		case "AL":%Txt1 = "您放弃了该任务，需稍候一段时间才能重新接取";
		case "AM":%Txt1 = "圣地不符，该功能只能本圣地的玩家使用";
		case "AN":%Txt1 = "您的等级过低，需要30级才可执行本功能";
		case "AO":%Txt1 = "当前场景内禁止使用此物品";
		case "AP":%Txt1 = "您已经进入不健康状态，本次收益减半";
		case "AQ":%Txt1 = "您已经进入不健康状态，本次无收益";
		case "AR":%Txt1 = "目标在副本内，无法直接前往";
		case "AS":%Txt1 = "您不是帮主，无法使用本功能";
		case "AT":%Txt1 = "您帮派的声望不满足升级条件";
		case "AU":%Txt1 = "您的金币不足";
		case "AV":%Txt1 = "您没有帮派";
		case "AW":%Txt1 = "您今日杀怪上限已满，无法获得更多的收益";
		case "AX":%Txt1 = "您今日的[帮派历练]任务已做完，请明天再来吧";
		case "AY":%Txt1 = "当前地图无法使用本功能";
		case "AZ":%Txt1 = "您没有足够的物品";

		case "BA":%Txt1 = "您不是攻方，无法使用";
		case "BB":%Txt1 = "您不是守方，无法使用";
		case "BC":%Txt1 = "只能在攻城战地图内使用";
		case "BD":%Txt1 = "只能对普通的攻城车使用，当前目标无效";
		case "BE":%Txt1 = "目标攻城车已经改装成此效果，无法重复改装";
		case "BF":%Txt1 = "您没有队伍，无法使用";
		case "BG":%Txt1 = "该功能只能是队员才可执行";
		case "BH":%Txt1 = "您以完成此对话任务";
		case "BI":%Txt1 = "您的当前的职业无法领取该任务";
		case "BJ":%Txt1 = "您的当前的门阀无法领取该任务";
		case "BK":%Txt1 = "你尚未收集足够需要采集的物品";
		case "BL":%Txt1 = "您的等级不够，无法激活该化身。";
		case "BM":%Txt1 = "您没有相应道具，无法激活该化身。";
		case "BN":%Txt1 = "您上一次的渡劫奖励还未领取";
		case "BO":%Txt1 = "您的奖励已经直接装备";
		case "BP":%Txt1 = "神兽栏位已满，无法获得神兽";
		case "BQ":%Txt1 = "您今日的[帮派守护神]任务已做完，请明天再来吧";
		case "BR":%Txt1 = "您今日的[抢夺资源]任务已做完，请明天再来吧";
		case "BS":%Txt1 = "您今日的[驱逐敌兵]任务已做完，请明天再来吧";
		case "BT":%Txt1 = "您今日的[五一庆典]任务已做完，请明天再来吧";
				}

				//判断当前是否为客户端调用，发系统消息
				if ($Now_Script == 1)
				{
					SetScreenMessage(%Txt1,$Color[2]);
					SetChatMessage(%Txt1,$Color[2],$chatMsg_Person);
				}
				else
				{
					SendOneScreenMessage(2,%Txt1,%Player);
					SendOneChatMessage($chatMsg_System,"<t>" @ %Txt1 @ "</t>",%Player);
				}
			}
		}

	return %TiaoJian;
}


function SendWhyMsg_A(%Player,%Txt,%Msg)
{
	if (%Msg == 0)
		return;

	//判断当前是否为客户端调用，发系统消息
	if ($Now_Script == 1)
	{
		SetScreenMessage(%Txt,$Color[2]);
		SetChatMessage(%Txt,$Color[2],$chatMsg_Person);
	}
	else
	{
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
	}
}
