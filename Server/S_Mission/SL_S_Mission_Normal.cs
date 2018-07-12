//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//服务端任务脚本集，包含所有普通任务脚本
//普通任务流程统一，采用模板方式制作
//
//==================================================================================
//■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■任务脚本总接口■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■任务领取触发■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■中途对话触发■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■任务完成触发■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■■任务接受设置基础信息■■■■■■■■■■■■■■
//■■■■■■■■■■■■任务中途设置基础信息■■■■■■■■■■■■■■
//■■■■■■■■■■■■任务完成设置基础信息■■■■■■■■■■■■■■
//■■■■■■■■■■■■任务信息判断处理接口■■■■■■■■■■■■■■
//■■■■■■■■■■■■领取、完成任务处理保留对话框■■■■■■■■■■

//■■■■■■■■■■■■共享任务■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■设置旗标■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■答题任务■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■需要获得任务物品的采集物■■■■■■■■■■■■
//■■■■■■■■■■■■采集对应的任务编号■■■■■■■■■■■■■■■

//■■■■■■■■■■■■【特殊对话框】■■■■【发送客户端开关界面】■■

//■■■■■■■■■■■■任务脚本总接口■■■■■■■■■■■■■■■■■
function Mission_Normal(%Npc,%Player,%State,%Conv,%Param)
{
	%ConvText = 0;

	%NpcID = %Npc.GetDataid();//获取NPCID

	%NpcA_Mid = GetStartNpcMission(%NpcID);//可以领取的任务
	%NpcX_Mid = GetMidTalkNpcMission(%NpcID);	//正在进行中任务
	%NpcZ_Mid = GetEndNpcMission(%NpcID);//可以完成的任务

	%NpcA_Mid_MaxNum = GetWordCount(%NpcA_Mid);//可以领取的任务数量
	%NpcZ_Mid_MaxNum = GetWordCount(%NpcZ_Mid);//可以完成的任务数量
	%NpcX_Mid_MaxNum = GetWordCount(%NpcX_Mid);//正在进行中任务数量

	if (%State == 0)
	{
		//遍历当前NPC所有可交的任务，并给予相应选项
		for (%z = 0; %z < %NpcZ_Mid_MaxNum; %z++)
		{
			%Mid = GetWord(%NpcZ_Mid,%z);												//获取任务ID
			if (!Mission_End_SeeOption(%Player,%Mid))							//是否显示(特殊判断)
				if (CanDoThisMission(%Player,%Mid,2,0,0) $= "")	//是否显示(常规判断)
					if (%Mid == %Player.PostMid)
						%Conv.AddOption(900 @ %Mid,910 @ %Mid,5);			//显示交任务选择
					else
						%Conv.AddOption(900 @ %Mid,910 @ %Mid,2);			//显示交任务选择

		}

		//遍历当前NPC所有中途对话的任务，并给予相应选项
		for (%z = 0; %z < %NpcX_Mid_MaxNum; %z++)
		{
			%Mid = GetWord(%NpcX_Mid,%z);															//获取任务ID
			if (!Mission_midway_SeeOption(%Player,%Mid))								//是否显示(特殊判断)
				if (CanDoMidwayMission(%Npc,%Player,%Mid,0,0,0) > 0)	//是否显示(常规判断)
				{

					%Conv.AddOption(200 @ %Mid,210 @ %Mid);								//显示交任务选择
				}
		}
		switch ($Mission_ActRecord[%NpcID] * 1)
		{
			case 0:
				//遍历当前NPC所有可接的任务，并给予相应选项
				for (%a = 0; %a < %NpcA_Mid_MaxNum; %a++)
				{
					%Mid = GetWord(%NpcA_Mid,%a);												//获取任务ID
					//echo("Mission_Begin_SeeOption(" @ %Player @ "," @ %Mid @ ")=====" @ Mission_Begin_SeeOption(%Player, %Mid));
					//echo("CanDoThisMission("@ %Player @ "," @ %Mid @ ", 1, 0, 0)====" @ CanDoThisMission(%Player, %Mid, 1, 0, 0));
					if (!Mission_Begin_SeeOption(%Player,%Mid))						//是否显示(特殊判断)
						if (CanDoThisMission(%Player,%Mid,1,0,0) $= "")	//是否显示(常规判断)
						{
							if (%Mid == %Player.PostMid)
								%Conv.AddOption(100 @ %Mid,110 @ %Mid,4);//显示接任务选择(打开1级界面)
							else
								%Conv.AddOption(100 @ %Mid,110 @ %Mid,1);//显示接任务选择(打开2级界面)
						}
				}
			default://这部分NPC身上有特殊的循环任务需要单独处理
				%Act = $Mission_ActRecord[%NpcID];
				//%Activity1 = GetWord( %Player.Getactivity( %Act ), 1 );
				//------------获取这个NPC身上所有的类型==7的任务编号
				%NeedMission = "";
				for (%bbc = 0; %bbc < %NpcA_Mid_MaxNum; %bbc++)
				{
					%Midbbc = GetWord(%NpcA_Mid,%bbc);
					%Midtypebbc = GetMissionData(%Midbbc,$Mission_Data_Type);
					if (%Midtype  == 7)
						%NeedMission = %Midbbc @ " " @ %NeedMission;
				}
				%NeedMissionCount = GetWordcount(%NeedMission);
				for (%jj = 0; %jj < %NeedMissionCount; %jj++)
				{
					%Midjj = GetWord(%NeedMission,%jj);
					%Midtypejj = GetMissionData(%Midjj,$Mission_Data_Type);
					if (%Player.IsAcceptedMission(%Midjj) && %Midtypejj  == 7)//是否已接任务
					{
						%NoMoreMid = 1;
						break;
					}
				}
				for (%a = 0; %a < %NpcA_Mid_MaxNum; %a++)
				{
					%Mid = GetWord(%NpcA_Mid,%a);
					%Midtype = GetMissionData(%Mid,$Mission_Data_Type);
					%MidRecord = 0;//每次开始判断前初始化标记
					%Activity0 = GetWord(%Player.Getactivity(%Act),0)* 1;

					if (%Midtype == 7 && %NoMoreMid  != 1)//如果是日常任务 需要特殊处理
					{
						if (%Activity0 <= 0)
						{
							%Ran = GetRandom(0,%NeedMissionCount -1);
							%NeddMid = GetWord(%NeedMission,%Ran);
							if (GetMissionData(%NeddMid,$Mission_Data_Mid) > 0)
							{
								%MidRecord = %NeddMid;
								SetAct(%Player,%Act,%MidRecord,0);
							}
						}
						else
						{
							if (%Player.IsAcceptedMission(%Activity0))//是否已接任务
								%MidRecord = 0;
							else
								%MidRecord = %Activity0;
						}
					}
					else
						%MidRecord = %Mid;

					if (%MidRecord > 0)
					{
						if (!Mission_Begin_SeeOption(%Player,%MidRecord))						//是否显示(特殊判断)
							if (CanDoThisMission(%Player,%MidRecord,1,0,0) $= "")	//是否显示(常规判断)
							{
								if (%MidRecord == %Player.PostMid)
									%Conv.AddOption(100 @ %MidRecord,110 @ %MidRecord,4);//显示接任务选择(打开1级界面)
								else
									%Conv.AddOption(100 @ %MidRecord,110 @ %MidRecord,1);//显示接任务选择(打开2级界面)
							}
					}
				}
		}
	}

	if ((%State > 0)&&(strlen(%State) == 8))
	{
		//获取基础信息
		%MidState = GetSubStr(%State,0,3);						//获取任务类型（可接、可交）
		%Mid      = GetSubStr(%State,3,5);						//获取任务编号
		//代表需要判断的前置
		switch (%MidState)
		{
			case 110:	%Type = 0;
			case 210:	%Type = -1;
			case 910:	%Type = 1;
			default: return;
		}

		//任务前置判断（特殊）
		%Result = Mission_Estimate_Confluence(%Player,%Conv,%Mid,%Type);
		if (%Result == 0)
		{
			%MidName = "Mission_Normal_" @ %MidState;
			eval(%MidName @ "(%Npc, %Player, %State, %Conv, %Param, %Mid);");
		}
	}
}

//■■■■■■■■■■■■任务领取触发■■■■■■■■■■■■■■■■■■
function Mission_Normal_110(%Npc,%Player,%State,%Conv,%Param,%Mid)
{
	//任务接受部分
	if (CanDoThisMission(%Player,%Mid,1,1,1) $= "")
	{
		//设置任务相关信息
		%Txt = AddMissionAccepted(%Player,%Conv,%Mid);

		//获取该Npc是否有可接、可交或后续任务
		%Unpack = Mission_DialogBox_Unpack(%Npc,%Player,%State,%Conv,%Param,%Mid);
	}
	else
		%Conv.SetType(4);
}

//■■■■■■■■■■■■中途对话触发■■■■■■■■■■■■■■■■■■
function Mission_Normal_210(%Npc,%Player,%State,%Conv,%Param,%Mid)
{
	%FlagID = CanDoMidwayMission(%Npc,%Player,%Mid,0,0,0);
	if (%FlagID > 0)
		AddMissionMidway(%FlagID,%Player,%Mid,%Param,%Conv);
	else
		%Conv.SetType(4);
}

//■■■■■■■■■■■■任务完成触发■■■■■■■■■■■■■■■■■■
function Mission_Normal_910(%Npc,%Player,%State,%Conv,%Param,%Mid)
{
	if (CanDoThisMission(%Player,%Mid,2,1,1) $= "")
	{
		//设置任务奖励
		AddMissionReward(%Player,%Mid,%Param,%Conv);
		//获取该Npc是否有可接、可交或后续任务
		%Unpack = Mission_DialogBox_Unpack(%Npc,%Player,%State,%Conv,%Param,%Mid);
	}
	else
		%Conv.SetType(4);
}

//■■■■■■■■■■■■任务接受设置基础信息■■■■■■■■■■■■■■
function AddMissionAccepted(%Player,%Conv,%Mid)
{
	//防沉迷判断
	if (%Player.GetCaptivateState() >= 1)
	{
		%Conv.SetText(86);
		%Conv.AddOption(4,0);
		%Conv.Send(%Player);
		return SendWhyMsg(%Player,"V",0,1);
	}

	//设置任务接受
	%Player.SetMissionFlag(%Mid,1,1);

	//提示领取消息
	SendOneChatMessage($chatMsg_Person,"<t>您接受了[" @ GetMissionData(%Mid,$Mission_Data_Name) @ "]任务</t>",%Player);
	SendOneScreenMessage(1,"您接受了[" @ GetMissionData(%Mid,$Mission_Data_Name) @ "]任务",%Player);

	//设置是否需要杀怪
	%MissionData_MonsterKill = GetMissionData(%Mid,$Mission_Data_KillMonster);
	%MissionData_MonsterKill_Num = GetWordCount(%MissionData_MonsterKill,";");
	if (%MissionData_MonsterKill !$= "0")
		for (%i = 0; %i < %MissionData_MonsterKill_Num; %i++)
		{
			%Monster = GetWord(%MissionData_MonsterKill,%i * 2,";");
			%KillNum = GetWord(%MissionData_MonsterKill,%i * 2 + 1,";");

			if ((%Monster $= "")&&(%KillNum $= ""))
				break;
			else
			{
				%Player.SetMissionFlag(%Mid,3100 + %i,%Monster);	//设置,怪物编号
				%Player.SetMissionFlag(%Mid,3200 + %i,%KillNum);	//设置,怪物总数
				%Player.SetMissionFlag(%Mid,3300 + %i,0); 				//设置,怪物当前数量
			}
		}

	//设置中途是否需要寻找目标
	%MissionData_NpcX = GetMissionData(%Mid,$Mission_Data_NpcX);
	%MissionData_NpcX_Num = GetWordCount(%MissionData_NpcX,";");
	if (%MissionData_NpcX !$= "0")
		for (%i = 0; %i < %MissionData_NpcX_Num; %i++)
		{
			%NpcX    = GetWord(%MissionData_NpcX,%i * 2,";");
			%NpcXNum = GetWord(%MissionData_NpcX,%i * 2 + 1,";");

			if ((%NpcX $= "")&&(%NpcXNum $= ""))
				break;
			else
			{
				%Player.SetMissionFlag(%Mid,1150 + %i,%NpcX);			//设置,目标编号
				%Player.SetMissionFlag(%Mid,1250 + %i,%NpcXNum);	//设置,目标触发总数
				%Player.SetMissionFlag(%Mid,1350 + %i,0); 				//设置,目标触发当前数量
			}
		}

	//设置是否需要获取物品
	%MissionData_ItemGet = GetMissionData(%Mid,$Mission_Data_ItemGet);
	%MissionData_ItemGet_Num = GetWordCount(%MissionData_ItemGet,";");
	if (%MissionData_ItemGet !$= "0")
		for (%i = 0; %i < %MissionData_ItemGet_Num; %i++)
		{
			%ItemGet = GetWord(%MissionData_ItemGet,%i * 2,";");
			%GetNum  = GetWord(%MissionData_ItemGet,%i * 2 + 1,";");

			if ((%ItemGet $= "")&&(%GetNum $= ""))
				break;
			else
			{
				if (%Player.GetItemCount(%ItemGet) > %GetNum)
					%NowNum  = %GetNum;
				else
					%NowNum  = %Player.GetItemCount(%ItemGet);

				%Player.SetMissionFlag(%Mid,2100 + %i,%ItemGet);	//设置,ITEM编号
				%Player.SetMissionFlag(%Mid,2200 + %i,%GetNum);		//设置,ITEM获取总数
				%Player.SetMissionFlag(%Mid,2300 + %i,%NowNum); 	//设置,ITEM获取当前数量
			}
		}

	//设置是否需要运输物品
	%MissionData_ItemAdd = GetMissionData(%Mid,$Mission_Data_ItemAdd);
	%MissionData_ItemAdd_Num = GetWordCount(%MissionData_ItemAdd,";");

	if (GetMissionData(%Mid,$Mission_Data_ItemDelete) > 0)
		if (%MissionData_ItemAdd !$= "0")
			for (%i = 0; %i < %MissionData_ItemAdd_Num; %i++)
			{
				%ItemAdd = GetWord(%MissionData_ItemAdd,%i * 2,";");
				%AddNum  = GetWord(%MissionData_ItemAdd,%i * 2 + 1,";");

				if ((%ItemAdd $= "")&&(%AddNum $= ""))
					break;
				else
				{
					if (%Player.GetItemCount(%ItemAdd) > %AddNum)
						%NowNum  = %AddNum;
					else
						%NowNum  = %Player.GetItemCount(%ItemAdd);
					%Player.SetMissionFlag(%Mid,2150 + %i,%ItemAdd);	//设置,ITEM编号
					%Player.SetMissionFlag(%Mid,2250 + %i,%AddNum);		//设置,ITEM运输总数
					%Player.SetMissionFlag(%Mid,2350 + %i,%NowNum);		//设置,ITEM运输当前数量
				}
			}

	//设置是否需要使用特殊旗标
	%MissionData_Target = GetMissionData(%Mid,$Mission_Data_ItemUseTarget);
	%MissionData_Target_Num = GetWordCount(%MissionData_Target,";");

	if (%MissionData_Target !$= "0")
	{
		for (%i = 0; %i < %MissionData_Target_Num; %i++)
		{
			%Target = GetWord(%MissionData_Target,%i * 2,";");
			%TarNum = GetWord(%MissionData_Target,%i * 2 + 1,";");

			if ((%Target $= "")&&(%TarNum $= ""))
				break;
			else
			{
				//若未采集物，则特殊旗标
				if (GetSubStr(%Target,0,1) == 5)
					%Cj = 1030;	//2130 2230 2330
				//echo( 1100 + %Cj + %i @ "    %Target=" @ %Target  @ "   %TarNum===" @ %TarNum );
				%Player.SetMissionFlag(%Mid,1100 + %Cj + %i,%Target);		//设置,任意编号
				%Player.SetMissionFlag(%Mid,1200 + %Cj + %i,%TarNum);		//设置,任意触发总数
				%Player.SetMissionFlag(%Mid,1300 + %Cj + %i,0); 				//设置,任意触发当前数量
			}
		}
	}

	//设置是否需要触发的采集事件
	%Mission_Data_Cj = GetMissionData(%Mid,$Mission_Data_Cj);
	%Mission_Data_Cj_Num = GetWordCount(%Mission_Data_Cj,";");
	//echo( "%Mission_Data_Cj===" @ %Mission_Data_Cj );
	//echo( "%Mission_Data_Cj_Num===" @ %Mission_Data_Cj_Num );
	if (%Mission_Data_Cj !$= "0")
	{
		for (%i = 0; %i < %Mission_Data_Cj_Num; %i++)
		{
			%Cj_A = GetWord(%Mission_Data_Cj,%i * 2,";");
			%Cj_Z = GetWord(%Mission_Data_Cj,%i * 2 + 1,";");

			if ((%Cj_A $= "")&&(%Cj_Z $= ""))
				break;
			else
			{
				//echo( 1400 + %i @ "    %Mid===" @ %Mid @ "   " @ "%Cj_A===" @ %Cj_A  @ "   " @ "%Cj_Z===" @ %Cj_Z );
				//echo( );
				%Player.SetMissionFlag(%Mid,1400 + %i,%Cj_A);		//设置,采集物编号
				%Player.SetMissionFlag(%Mid,1500 + %i,%Cj_Z);		//设置,采集物交互旗标
			}
		}
	}
	//echo( %Player.GetMissionFlag( %Mid, 1400 ) );
	//echo( %Player.GetMissionFlag( %Mid, 1500 ) );
	//echo( %Player.GetMissionFlag( %Mid, 1600 ) );
	//设置状态
	%MissionData_X_Man = GetMissionData(%Mid,$Mission_Data_X_Man);
	if (%MissionData_X_Man !$= "0")
	{
		%Player.SetMissionFlag(%Mid,6000,%MissionData_X_Man); //设置,变身Buff状态编号
		%Player.AddBuff(%MissionData_X_Man,0);
	}

	//设置9000、9100旗标[文字描述]
	%Mission_EspeciallyTrigger = GetMissionData(%Mid,$Mission_Data_EspeciallyTrigger);
	for (%i = 0; %i < 3; %i++)
	{
		if (HasBit(%Mission_EspeciallyTrigger,4 + %i) > 0)
			%Player.SetMissionFlag(%Mid,9000 + %i,1);

		if (HasBit(%Mission_EspeciallyTrigger,7 + %i) > 0)
			%Player.SetMissionFlag(%Mid,9100 + %i,1);
	}

	%Player.UpdateMission(%Mid);//更新任务信息
	if (%Player.LogicFloorRecord <= 0)
		HelpDirectByIndex(%Player.GetPlayerID(),64);	//发送接任务特效
	ServerOnSptAction(%Player.GetPlayerID(),%Mid,3);//通讯客户端
	//领取任务时前置处理
	Mission_Estimate_Confluence(%Player,%Conv,%Mid,2);
}

//■■■■■■■■■■■■任务中途设置基础信息■■■■■■■■■■■■■■
function AddMissionMidway(%FlagID,%Player,%Mid,%Param,%Conv)
{
	%NpcX  = %Player.GetMissionFlag(%Mid,%FlagID);				//获取,目标编号
	%NpcXA = %Player.GetMissionFlag(%Mid,%FlagID + 100);	//获取,目标触发总数
	%NpcXB = %Player.GetMissionFlag(%Mid,%FlagID + 200);	//获取,目标触发当前数量

	SendOneScreenMessage(1,"对话 【"@ GetNpcData(%NpcX,1) @"】 "@%NpcXB + 1@"/"@%NpcXA,%Player);
	%Player.SetMissionFlag(%Mid,%FlagID + 200,%NpcXB + 1,true);	//设置,目标触发当前数量
	%Conv.SetText(300 + (%FlagID - 1150) @ %Mid);
	

}

//■■■■■■■■■■■■任务完成设置基础信息■■■■■■■■■■■■■■
function AddMissionReward(%Player,%Mid,%Param,%Conv)
{
	//获取基础信息
	%PlayerID	= %Player.GetPlayerID();

	//防沉迷判断
	if (%Player.GetCaptivateState() >= 1)
	{
		%Conv.SetText(86);
		%Conv.AddOption(4,0);
		%Conv.Send(%Player);
		return SendWhyMsg(%Player,"V",0,1);
	}

	//扣除任务获取道具
	switch (%Mid)
	{
		case 20025:
		case 20026:
		case 20027:
		default:
			for (%i = 0; %i < 9; %i++)
			{
				%ItemGet = %Player.GetMissionFlag(%Mid,2100 + %i);
				%GetNum  = %Player.GetMissionFlag(%Mid,2200 + %i);

				%ItemType = GetItemData(%ItemGet, 3);
				//echo("%ItemType===" @ %ItemType);
				//echo("%GetNum===" @ %GetNum);
				//echo("$Item_Monster[%ItemGet]===" @ $Item_Monster[%ItemGet]);
				//echo("%Player.GetItemCount(%ItemGet)===" @ %Player.GetItemCount(%ItemGet));
				if (%ItemType == 802  && %Player.GetItemCount(%ItemGet) > %GetNum)//如果扣除的是任务物品
					%GetNum = %Player.GetItemCount(%ItemGet);
				//echo("%ItemGet===" @ %ItemGet);
				//echo("%GetNum===" @ %GetNum);
				if ((%ItemGet > 0) && (%GetNum > 0))
				{
					%Player.PutItem(%ItemGet,-%GetNum);
				}
				else
					break;
			}
	}
	//扣除接任务时给的道具
	%MissionData_ItemAdd = GetMissionData(%Mid,$Mission_Data_ItemAdd);
	%MissionData_ItemAdd_Num = GetWordCount(%MissionData_ItemAdd,";")/2;
	if (GetMissionData(%Mid,$Mission_Data_ItemDelete) > 0)
		if (%MissionData_ItemAdd !$= "0")
			for (%i = 0; %i < %MissionData_ItemAdd_Num; %i++)
			{
				%ItemAdd    = GetWord(%MissionData_ItemAdd,%i * 2,";");
				%AddNum     = GetWord(%MissionData_ItemAdd,%i * 2 + 1,";");

				if ((%ItemAdd $= "")&&(%AddNum $= ""))
					break;

				%PutItem[%index++] = %Player.PutItem(%ItemAdd,-%AddNum);
			}

	//直接装备道具
	%ConvText = GetMissionData(%Mid,$Mission_Data_EspeciallyTrigger);

	%Sex = %Player.GetSex();
	%Classes = %Player.GetClasses(0);

	//给选择性道具
	if ($MissionData_ItemChose[%Mid] !$= "")
	{
		for (%i = 0; %i <= 99; %i++)
		{
			%Item = GetWord($MissionData_ItemChose[%Mid],%i * 2,";");
			%Num  = GetWord($MissionData_ItemChose[%Mid],%i * 2 + 1,";");
			if ((%Item $= "")&&(%Num $= ""))
				break;
			//echo( "%Item===" @ %Item @ "    %Num===" @ %Num );
			%ItemJob =  GetItemData(%Item,113);
			%ItemSex = GetItemData(%Item,24);
			//echo( " CheckBit( " @ %ItemJob @ ", " @ %Classes - 1 @ " ) ======" @  CheckBit( %ItemJob, %Classes ) );
			if (CheckBit(%ItemJob,%Classes - 1) == 1)
			{
				if (%ItemSex == 0 || %ItemSex == %Sex)
					%MissionData_ItemChose = %MissionData_ItemChose @ %Item @ ";" @ %Num @ ";";
			}
		}
		//echo( "%MissionData_ItemChose===" @ %MissionData_ItemChose );
	}
	else
		%MissionData_ItemChose = GetMissionData(%Mid,$Mission_Data_ItemChose);
	//echo( "%MissionData_ItemChose ==" @ %MissionData_ItemChose );
	if (%MissionData_ItemChose !$= "0")
	{
		%ItemChose = GetWord(%MissionData_ItemChose,(%Param) * 2,";");
		%ChoseNum  = GetWord(%MissionData_ItemChose,(%Param) * 2 + 1,";");

		if ((%ItemChose !$= "")&&(%ChoseNum !$= ""))
		{
			if (HasBit(%ConvText,11) > 0)
				%ItemZhuangBei = (%ItemZhuangBei $= "") ? %ItemChose : %ItemZhuangBei @ ";" @ %ItemChose;
			else
			{
				%ItemChoseH = %ItemChose;
				%PutItem[%index++] = %Player.PutItem(%ItemChose,%ChoseNum);
			}
		}
	}
	//必给的道具
	if ($MissionData_ItemSet[%Mid] !$= "")
		%MissionData_ItemChose = $MissionData_ItemSet[%Mid];
	else
		%MissionData_ItemSet = GetMissionData(%Mid,$Mission_Data_ItemSet);

	//echo( "%MissionData_ItemSet ==" @ %MissionData_ItemSet );
	if (%MissionData_ItemSet !$= "0")
		for (%i = 0; %i < 50; %i++)
		{
			%ItemSet = GetWord(%MissionData_ItemSet,%i * 2,";");
			%SetNum  = GetWord(%MissionData_ItemSet,%i * 2 + 1,";");

			if ((%ItemSet $= "")&&(%SetNum $= ""))
				break;
			else
			{
				if (HasBit(%ConvText,11) > 0)
					%ItemZhuangBei = (%ItemZhuangBei $= "") ? %ItemSet : %ItemZhuangBei @ ";" @ %ItemSet;
				else
				{
					%ItemSetH = %ItemSet;
					%PutItem[%index++] = %Player.PutItem(%ItemSet,%SetNum);
				}
			}
		}

	//根据职业给予道具
	if ($Mission_Data_ItemClasses[%Mid] !$= "")
		%MissionData_ItemClasses = $Mission_Data_ItemClasses[%Mid];
	else
		%MissionData_ItemClasses = GetMissionData(%Mid,$Mission_Data_ItemClasses);


	//echo( "%MissionData_ItemClasses ==" @ %MissionData_ItemClasses );
	if (%Mission_Data_Classes !$= "0")
		for (%i = 0; %i < 50; %i++)
		{
			%ItemClasses = GetWord(%MissionData_ItemClasses,%i * 2,";");
			%SetNum  = GetWord(%MissionData_ItemClasses,%i * 2 + 1,";");

			if ((%ItemClasses $= "")&&(%SetNum $= ""))
				break;
			else
			{
				if (HasBit(GetItemData(%ItemClasses,113),%Classes - 1) > 0)
				{
					if (GetItemData(%ItemClasses,24) == 0 || GetItemData(%ItemClasses,24) == %sex)
					{
						if (HasBit(%ConvText,11) > 0)
							%ItemZhuangBei = (%ItemZhuangBei $= "") ? %ItemClasses : %ItemZhuangBei @ ";" @ %ItemClasses;
						else
						{
							%ItemClassesH = %ItemClasses;
							%PutItem[%index++] = %Player.PutItem(%ItemClasses,%SetNum);
						}
					}

				}
			}
		}

	//获取是否设置物品绑定
	%Mission_EspeciallyTrigger = GetMissionData(%Mid,$Mission_Data_EspeciallyTrigger);
	if (HasBit(%Mission_EspeciallyTrigger,10) > 0)
	{
		for (%index = 1; %index < 100; %index++)
		{
			if (%PutItem[%index] $= "")
				break;

			//设置物品为绑定
			%Player.SetPutItemProperty(%PutItem[%index],1,%PlayerID);
		}
	}

	//增减道具，一次性操作
	if (!%Player.AddItem(1,%Mid))
		return SendWhyMsg(%Player,"T",0,1);

	//判定是否需要打开包裹并提示
	%ConvText = GetMissionData(%Mid,$Mission_Data_Conv);
	if (HasBit(%ConvText,3) > 0)
	{
		//选择性道具
		if (%ItemChoseH > 0)
			ServerOnSptAction(%Player.GetPlayerID(),%ItemChose,1);

		//必给道具
		if (%ItemSetH > 0)
			ServerOnSptAction(%Player.GetPlayerID(),%ItemSetH,1);

		//根据职业给予道具
		if (%ItemClassesH > 0)
			ServerOnSptAction(%Player.GetPlayerID(),%ItemClassesH,1);
	}

	//添加直接装备奖励
	if (%ItemZhuangBei !$= "")
	{
		for (%i = 0; %i < 9; %i++)
		{
			%ItemZhuangBeiID = GetWord(%ItemZhuangBei,%i,";");
			if (%ItemZhuangBeiID $= "")
				break;

			//若道具为宠物类型
			if (GetItemData(%ItemZhuangBeiID,2) == 18)
			{
				%PetID = GetItemData(%ItemZhuangBeiID,35);
				%bTemp = GeneratePetInfo(%PlayerID,%PetID,1,2,0,1);//给予玩家灵兽

				if (%bTemp != -1)
				{
					%Player.AddBuff(320210023); //召唤宠物定身状态
					%Player.SpawnPet(%bTemp);//自动召唤宠物
					%Player.ShowDialogOk(2000000012,23,0);
				}
				else
					return SendWhyMsg(%Player,"BP",0,1);
			}
			else
			{
				if (%Player.AddItemToEquip(%ItemZhuangBeiID,0) == 1)
					%Player.ShowDialogOk(2000000013,23,0);
			}
		}
	}

	//获取正常奖励经验
	%TempExp = GetMissionData(%Mid,$Mission_Data_Exp);
	if (%TempExp > 0)
	{
		if (GetMissionData(%Mid,$Mission_Data_Type) == 1)
		{
			//六道轮回后的经验加成
			%Metempsychosis = %Player.GetMetempsychosis();
			%TempExp = %TempExp + (%TempExp * 0.5 * %Metempsychosis);
		}

		//添加经验
		AllAddExp(%Player,%TempExp);
	}

	//给金钱
	%MissionData_Money = GetMissionData(%Mid,$Mission_Data_Money);
	if (%MissionData_Money > 0)
		%Player.AddMoney(%MissionData_Money,1,1,%Mid);

	//给元宝
	%MissionData_Yuan = GetMissionData(%Mid,$Mission_Data_Yuan);
	if (%MissionData_Yuan > 0)
		%Player.AddMoney(%MissionData_Yuan,2,1,%Mid);

	//给活跃积分
	%MissionData_JiFen = GetMissionData(%Mid,$Mission_Data_JiFen);
	if (%MissionData_JiFen > 0)
		%Player.AddMoney(%MissionData_JiFen,7,1,%Mid);

	//给官职系统的文官成就值
	//%Player.AddCivilianValue( 5 );  //每完成一个任务获得5点成就值

	//给声望奖励（现已经改为帮派相关奖励）
	%MissionData_ShengWang = GetMissionData(%Mid,$Mission_Data_ShengWang);
	if (%MissionData_ShengWang > 0)
	{
		%leve = %Player.GetLevel();			//玩家等级

		//额外活跃积分奖励
		%Player.AddMoney(2,7,1,%Mid);

		//switch ( %Player.GetOrgMemberLevel( 1 ) )
		//{
		//	case 0:%TooC = 1;		//1级帮众，奖励为1倍
		//	case 1:%TooC = 1.5; //2级帮众，奖励为1.5倍
		//	case 2:%TooC = 2;   //3级帮众，奖励为2倍
		//	case 3:%TooC = 2.5; //4级帮众，奖励为2.5倍
		//	case 4:%TooC = 3;   //5级帮众，奖励为3倍
		//	case 5:%TooC = 3;		//副帮主，奖励为3倍
		//	case 6:%TooC = 3;		//帮主，奖励为3倍
		//}

		////判断是否有帮派，无帮派则不给予任务奖励
		//if ( %FamilyID > 0 )
		//{
		//	//帮派周末翻倍提示
		//	if ( %TooB > 1 )
		//		SendOneChatMessage( $chatMsg_Person, "<t>当前为周末，以下帮派所有的收益翻倍</t>", %Player );
		//
		//	//帮派声望奖励  帮派贡献奖励
		//	AddFamily_SW_GX( %Player, %Family_ShengWang * %TooB * %TooC, %Family_OverItem * %TooB * %TooC );
		//
		//	//记录帮派任务完成次数
		//	SptOrg_AddMission( %PlayerID );
		//}
		//else
		//	SendOneChatMessage( $chatMsg_Person, "<t>您尚未加入帮派，该任务相关帮派奖励丢失</t>", %Player );

		//人物经验奖励
		AllAddExp(%Player,%EXP * %leve * %TooB * %TooC);	//增加人物经验
	}
	else
		%ShengWang = "";

	//根据职业给予技能
	%MissionData_Skill = GetMissionData(%Mid,$Mission_Data_Skill);
	%MissionData_Skill_Num = GetWordCount(%MissionData_Skill,";");
	if (%MissionData_Skill !$= "0")
	{
		for (%i = 0; %i < %MissionData_Skill_Num; %i++)
		{
			%Skill = GetWord(%MissionData_Skill,%i,";");

			if (%Skill $= "")
				break;
			else
			{
				%ClassesID = GetItemData(%Skill,113);
				if (HasBit(%ClassesID,%Player.GetClasses(0) - 1) > 0)
				{
					%SkillBookID = GetItemData(%Skill,17);
					if (%Player.GetSkillLevel(%SkillBookID) == 0)
						%Player.AddSkill(%SkillBookID);
				}
			}
		}
	}

	//给状态
	%MissionData_Buff = GetMissionData(%Mid,$Mission_Data_Buff);
	%MissionData_Buff_Num = GetWordCount(%MissionData_Buff,";");
	if (%MissionData_Buff !$= "0")
		for (%i = 0; %i < %MissionData_Buff_Num; %i++)
		{
			%Buff = GetWord(%MissionData_Buff,%i,";");

			if (%Buff $= "")
				break;
			else
				%Player.AddBuff(%Buff,0);
		}

	//移除Buff
	if (%Player.GetMissionFlag(%Mid,6000) > 0)
		%Player.RemoveBuff(%Player.GetMissionFlag(%Mid,6000));

	//完成任务时前置处理
	Mission_Estimate_Confluence(%Player,%Conv,%Mid,3);

	//设置任务完成
	//echo( "GetMissionData( %Mid, $Mission_Data_Type )===" @ GetMissionData( %Mid, $Mission_Data_Type ) );
	switch (GetMissionData(%Mid,$Mission_Data_Type))
	{
		case 3:%Player.SetMission(%Mid,0);//循环任务
		case 4:%Player.SetMission(%Mid,0);//帮派任务
			//设置【每日『帮会任务』】任务完成
			AddMissionFlag(%Player,32526,1300,0);
		case 6://每日任务
			%Player.SetMission(%Mid,0);//重置
		case 7://每日任务
			%Player.SetMission(%Mid,0);//重置
			%missiondata_mid=GetMissionData(%Mid,$Mission_Data_Mid);
		case 9://战场任务
			%Player.AddMoney(5,8,1,%Mid);
		default://其他类任务
			%Player.SetMission(%Mid,1);//完成
	}

	//设置基础信息
	%Player.RecordActivity(%Mid,1,0,0);						//记录到日志服务器中
	if (%Player.LogicFloorRecord <= 0)
		HelpDirectByIndex(%Player.GetPlayerID(),65);	//发送完成任务特效

	AddHappyFlyLv(%Player,5);										//增加活跃度
	%Player.AddFrienValue_byTeam(2,10,2);				//添加好感度

	return "";
}

//■■■■■■■■■■■■任务信息判断处理接口■■■■■■■■■■■■■■
function Mission_Estimate_Confluence(%Player,%Conv,%Mid,%Type)
{
	//%Mission_EspeciallyTrigger = GetMissionData( %Mid, $Mission_Data_EspeciallyTrigger );
	//if ( HasBit( %Mission_EspeciallyTrigger, %Type ) > 0 )
	//{
	//echo( "%Type=====" @ %Type );
	//分类各种类型
	switch (%Type)
	{
		case 0: %MidName = "Mission_Begin_Front_"@ %Mid;		//领取任务前置判断
		case 1: %MidName = "Mission_End_Front_"@ %Mid;			//完成任务前置判断

		case 2: %MidName = "Mission_Begin_Process_"@ %Mid;	//领取任务过程处理
		case 3: %MidName = "Mission_End_Process_"@ %Mid;		//完成任务过程处理
	}
	//echo( "%MidName=AAAA=" @ %MidName );
	//执行拼写并发送
	if (isFunction(%MidName))
	{
		//echo("%MidName==" @ %MidName);

		%Txt = eval(%MidName @ "(%Npc, %Player, %Conv, %Param, %Mid);");
	}

	//返回的值
	if (%Txt !$= "")
	{
		//%Conv.SetText( %Txt );
		%Conv.AddOption(4,0);
		return %Txt;
	}
	//	}
}

//■■■■■■■■■■■■领取、完成任务处理保留对话框■■■■■■■■■■
function Mission_DialogBox_Unpack(%Npc,%Player,%State,%Conv,%Param,%Mid)
{
	%PlayerID = %Player.GetPlayerID();
	%NpcID = %Npc.GetDataID();

	//领取、完成任务后不执行后续对话框处理
	%ConvText = GetMissionData(%Mid,$Mission_Data_Conv);
	%MidState = GetSubStr(%State,0,3) == 110 ? 6 : 7;

	if (HasBit(%ConvText,%MidState) > 0)
	{
		CloseMissionDuiHuaKuang(%NpcID,%PlayerID,1,43);
		%Conv.SetType(4);
		return 1;
	}

	//判定是否Data是否强制打开对话框
	%ConvText = GetMissionData(%Mid,$Mission_Data_Conv);
	%MidState = GetSubStr(%State,0,3) == 110 ? 0 : 1;
	if (HasBit(%ConvText,%MidState) > 0)
	{
		%Player.PostMid = 0;
		CloseMissionDuiHuaKuang(%NpcID,%PlayerID,%NpcID,42);
		NpcOnTrigger(%Conv,%Npc,%Player,0,%Param);
		return 2;
	}

	//获取基础信息
	%NpcA_Mid = GetStartNpcMission(%NpcID);			//可以领取的任务
	%NpcX_Mid = GetMidTalkNpcMission(%NpcID);		//正在进行中任务
	%NpcZ_Mid = GetEndNpcMission(%NpcID);				//可以完成的任务

	%NpcA_Mid_MaxNum = GetWordCount(%NpcA_Mid);	//可以领取的任务数量
	%NpcX_Mid_MaxNum = GetWordCount(%NpcX_Mid);	//正在进行中任务数量
	%NpcZ_Mid_MaxNum = GetWordCount(%NpcZ_Mid);	//可以完成的任务数量

	if (GetSubStr(%State,0,3) == 910)
	{
		//任务后续任务，直接弹出对话框
		%PostMid = GetMissionData(%Mid,$Mission_Data_PostMid);
		%PostMid_Num = GetWordCount(%PostMid,";");

		if (%PostMid > 0)
		{
			for (%a = 0; %a < %PostMid_Num; %a++)
			{
				%Post = GetWord(%PostMid,%a,";");
				if (CanDoThisMission(%Player,%Post,1,2,0) $= "")
				{
					%Player.PostMid = %Post;
					CloseMissionDuiHuaKuang(%NpcID,%PlayerID,%NpcID,42);
					NpcOnTrigger(%Conv,%Npc,%Player,0,%Param);
					return 3;
				}
				else
					%Player.PostMid = "";
			}
		}
	}

	//领取任务后强制关闭对话框
	//完成任务后强制关闭对话框
	%ConvText = GetMissionData(%Mid,$Mission_Data_Conv);
	%MidState = GetSubStr(%State,0,3) == 110 ? 4 : 5;
	if (HasBit(%ConvText,%MidState) > 0)
	{
		CloseMissionDuiHuaKuang(%NpcID,%PlayerID,1,43);
		%Conv.SetType(4);
		return 4;
	}


	//判断是否有可接任务
	for (%a = 0; %a < %NpcA_Mid_MaxNum; %a++)
	{
		%MidA = GetWord(%NpcA_Mid,%a);

		if (!Mission_Begin_SeeOption(%Player,%MidA))						//是否显示(特殊判断)
			if (CanDoThisMission(%Player,%MidA,1,0,0) $= "")
			{
				CloseMissionDuiHuaKuang(%NpcID,%PlayerID,%NpcID,42);
				NpcOnTrigger(%Conv,%Npc,%Player,0,%Param);
				return 5;
			}
	}

	//判断是否有中途任务
	for (%x = 0; %x < %NpcX_Mid_MaxNum; %x++)
	{
		%MidX = GetWord(%NpcX_Mid,%x);
		if (!Mission_midway_SeeOption(%Player,%MidX))								//是否显示(特殊判断)
			if (CanDoMidwayMission(%Npc,%Player,%Mid,0,0,0) > 0)
			{
				CloseMissionDuiHuaKuang(%NpcID,%PlayerID,%NpcID,42);
				NpcOnTrigger(%Conv,%Npc,%Player,0,%Param);
				return 6;
			}
	}

	//判断是否有完成任务
	for (%z = 0; %z < %NpcZ_Mid_MaxNum; %z++)
	{
		%MidZ = GetWord(%NpcZ_Mid,%z);
		if (!Mission_End_SeeOption(%Player,%MidZ))							//是否显示(特殊判断)
			if (CanDoThisMission(%Player,%MidZ,2,0,0) $= "")
			{
				CloseMissionDuiHuaKuang(%NpcID,%PlayerID,%NpcID,42);
				NpcOnTrigger(%Conv,%Npc,%Player,0,%Param);
				return 7;
			}
	}

	//领取任务后设置开启界面
	if (GetSubStr(%State,0,3) == 110)
	{
		%Player.PostMid = %Mid;
		if (GetMissionData(%Mid,$Mission_Data_NpcZ) == %NpcID)
			if (CanDoThisMission(%Player,%Mid,2,0,0) $= "")
			{
				CloseMissionDuiHuaKuang(%NpcID,%PlayerID,%NpcID,42);
				NpcOnTrigger(%Conv,%Npc,%Player,0,%Param);
				return 8;
			}
	}

	//关闭对话框
	%Conv.SetType(4);
	CloseMissionDuiHuaKuang(%NpcID,%PlayerID,1,43);

	return -1;
}

//■■■■■■■■■■■■共享任务■■■■■■■■■■■■■■■■■■■■
//－－－共享任务触发－－－
//－－－通过任务界面接取任务－－－

//－－－共享任务触发－－－
function Mission_Share(%Player,%Mid,%State)
{

	// 记住下面两条指令对于物品触发任务非常重要
	%Conv = %Player.GetConversation();

	%Conv.Reset();	//重置所有选项
	%Conv.SetTriggerType(1);
	%Conv.SetTriggerMission(%Mid);

	if (%State == -1)
	{
		%Conv.SetType(4);
		%Conv.Send(%Player);
		return;
	}

	%Conv.SetType(2);

	if (%State == 0)
		%Conv.SetText(110 @ %Mid,110 @ %Mid);	//开启任务描述接受界面

	if ((%State > 0)&&(strlen(%State) == 8)&&(GetSubStr(%State,0,3) == 110))
		AddMissionAccepted(%Player,%Conv,%Mid);	//设置任务相关信息

	%Conv.Send(%Player);
}


//－－－通过任务界面接取任务－－－
function Mission_UI_Accepted(%Player,%Mid,%index)
{
	if (CanDoThisMission(%Player,%Mid,1,0,0) $= "")
		AddMissionAccepted(%Player,%Conv,%Mid);
}

//■■■■■■■■■■■■设置旗标■■■■■■■■■■■■■■■■■■■■
function AddMissionFlag(%Player,%Mid,%FlagA,%FlagDDD)
{
	//%FlagA = 旗标值
	//%FlagDDD = 设置完成的值，默认添加1

	if (%Player.IsAcceptedMission(%Mid))
	{
		%FlagAAA = %Player.GetMissionFlag(%Mid,%FlagA);				//目标当前数量
		%FlagBBB = %Player.GetMissionFlag(%Mid,%FlagA - 100);	//目标最大数量
		%FlagCCC = %Player.GetMissionFlag(%Mid,%FlagA - 200);	//目标编号

		if (%FlagAAA < %FlagBBB)
		{
			if (GetSubStr(%FlagCCC,0,1) == 1)%FlagTxt = GetItemData(%FlagCCC,1);						//道具
			else if (GetSubStr(%FlagCCC,0,1) == 4)%FlagTxt = GetNpcData(%FlagCCC,1);							//NPC
			else if (GetSubStr(%FlagCCC,0,1) == 5)%FlagTxt = GetCollectionObjectname(%FlagCCC);	//采集
			else if (GetSubStr(%FlagCCC,0,1) == 8)%FlagTxt = GetTriggerData(%FlagCCC,3);				//区域

			if (%FlagDDD > 0)
			{
				%FlagAAA = %FlagDDD + %FlagAAA;
				%FlagAAA = (%FlagAAA > %FlagBBB) ? %FlagBBB : %FlagAAA;
			}
			else
				%FlagAAA++;

			%Player.SetMissionFlag(%Mid,%FlagA,%FlagAAA);

			if (%FlagTxt $= "")
				%FlagTxt = GetMissionData(%Mid,$Mission_Data_Name); //获取任务名字
			SendOneScreenMessage(1,"完成 【"@%FlagTxt@"】 "@%FlagAAA@"/"@%FlagBBB@"",%Player);

			//特殊触发
			AddMissionFlagB(%Player,%Mid,%FlagA,%FlagAAA);

			Cancel($AddMissionFlag[%Player,%Mid]);
			$AddMissionFlag[%Player,%Mid] = Schedule(600,0,"AddMissionFlag_UPCS",%Player,%Mid);

			return 1;
		}
	}

	return 0;
}
function AddMissionFlag_UPCS(%Player,%Mid)
{
	%Player.UpdateMission(%Mid);
}

function AddMissionFlagB(%Player,%Mid,%FlagA,%FlagAAA)
{
	if ((20005 + (GetHomeplace(%Player) - 1) * 200) == %Mid)
	{
		//给予技能使用豆腐干提示
		if (%FlagAAA == 1)
			ServerOnSptAction(%Player.GetPlayerID(),1003,36);

		//给予完成任务提示
		if (%FlagAAA == 6)
			%Player.ShowDialogOk(2000000080,53,0);
	}
}

//■■■■■■■■■■■■答题任务■■■■■■■■■■■■■■■■■■■■
function AddMissionQuiz(%Npc,%Player,%State,%Conv,%Mid,%FlagA)
{
	%NpcID = %Npc.GetDataID();

	if (!%Player.IsAcceptedMission(%Mid))
		return;

	if (%Player.GetMissionFlag(%Mid,%FlagA - 100) == 0)
		return;

	if (%Player.GetMissionFlag(%Mid,%FlagA) > 0)
		return;

	switch (%State)
	{
		case 0:
			%Player.Ok = %Player.No = 1;
			%Conv.AddOption(500 @ %Mid,500 @ %Mid); //答题
	}

	if ((%State >= 500 @ %Mid) && (%State < 600 @ %Mid))
	{
		%Player.MidDaTi = 1;

		%AAA = GetSubStr(%State,1,1);	//当前为第几题
		%BBB = GetSubStr(%State,2,1);	//当前选项内容

		//答题阶段
		if (%State == 500 @ %Mid)
		{
			if ($AddMissionQuiz[%Mid,1,%Player.Ok] !$= "")
			{
				%Conv.SetText(51 @ %Player.Ok @ %Mid);
				for (%i=3; %i<10; %i++)
				{
					%option = $AddMissionQuiz[%Mid,%i,%Player.Ok];
					if (%option !$= "")
					{
						if (%Player.No == -1)
						{
							%Player.No = 1;
							%ZZ = 4000000;				//如果答错
						}
						%State = 5 @ %i @ %Player.Ok @ %Mid;		//拼出选项
						%Conv.AddOption(%State + %ZZ,%State);	//选项
					}
					else
						break;
				}
			}
			else
			{
				if (%Player.IsAcceptedMission(%Mid))
				{
					%FlagAAA = %Player.GetMissionFlag(%Mid,%FlagA);
					%Player.SetMissionFlag(%Mid,%FlagA,%FlagAAA + 1,true);
				}

				%Player.PostMid = %Mid;
				if (GetMissionData(%Mid,$Mission_Data_NpcZ) == %NpcID)
					Mission_Normal(%Npc,%Player,0,%Conv,%Param);//返回直接交任务
				else
					%Conv.SetType(4);

				AddMissionQuizB(%Npc,%Player,%State,%Conv,%Mid,%FlagA);
			}
		}
		else	//解答阶段
		{
			%Accurate = $AddMissionQuiz[%Mid,2,%Player.Ok];	//正确的
			%Selective = GetSubStr(%State,1,1) - 2;					//选择的
			if (%Accurate == %Selective)
			{
				%Player.Ok++;
				AddMissionQuiz(%Npc,%Player,500 @ %Mid,%Conv,%Mid,%FlagA);
			}
			else
			{
				%Player.No = -1;
				AddMissionQuiz(%Npc,%Player,500 @ %Mid,%Conv,%Mid,%FlagA);
			}
		}
	}
}
function AddMissionQuizB(%Npc,%Player,%State,%Conv,%Mid,%FlagA)
{
	switch (%Mid)
	{
		case 21507:
			//			%Player.PutItem(105099251, 4);
			//			%Player.PutItem(105099252, 1);
			//			if(%Player.AddItem(1, %Mid)) //直接打开包裹提示
			//				ServerOnSptAction(%Player.GetPlayerID(), 105099252, 23);
	}
}

//答题任务 - 一个NCP只答一个问题，有多个NPC，如：任务10019
function AddMissionQuizOneTopic(%Player,%State,%Conv,%Mid,%Flag)
{
	if (!%Player.IsAcceptedMission(%Mid))
		return;

	if (%Player.GetMissionFlag(%Mid,%Flag - 100) == 0)
		return;

	if (%Player.GetMissionFlag(%Mid,%Flag) == 1)     //对话NPC目标已经完成时返回
		return;

	switch (%State)
	{
		case 0:
			%Conv.SetText((511 + 10*(%Flag - 1300)) @ %Mid);//题目
			%Conv.AddOption((513 + 10*(%Flag - 1300)) @ %Mid,(513 + 10*(%Flag - 1300)) @ %Mid);     //答案一
			%Conv.AddOption((514 + 10*(%Flag - 1300)) @ %Mid,(514 + 10*(%Flag - 1300)) @ %Mid);     //答案二
			%Conv.AddOption((515 + 10*(%Flag - 1300)) @ %Mid,(515 + 10*(%Flag - 1300)) @ %Mid);     //答案三
	}
	if ((%State > 500 @ %Mid) && (%State < 600 @ %Mid))
	{
		%QuestionID = GetSubStr(%State,1,1);	    //当前为第几题
		%ChoseKeyID = GetSubStr(%State,2,1) - 2;	//玩家选择的答案

		if ($AddMissionQuizOneTopic[%Mid,%QuestionID,2] !$= %ChoseKeyID)
		{
			SendOneScreenMessage(2,"真可惜，差一点就答对了！",%Player);  //发送错误提示信息
			%Conv.SetType(4);
		}
		else
		{
			%Player.SetMissionFlag(%Mid,%Flag,1,true); //完成对话目标
			SendOneScreenMessage(1,"你竟然真的答对了，孺子可教也！",%Player);  //回答正确
			%Conv.SetType(4);
		}
	}
}


//■■■■■■■■■■■■需要获得任务物品的采集物■■■■■■■■■■■■
//任务采集事件处理
function MissionCollectEventDispose(%Player,%Event,%EventID)
{
	if ($Item_Mission[%EventID] $= "")
		return;
	%MidList = $Item_Mission[%EventID];
	for (%i = 0; %i < GetWordCount(%MidList); %i++)
	{
		%Mid = GetWord(%MidList,%i);
		if (!%Player.IsAcceptedMission(%Mid))//是否已接次任务，并判断是否满足条件
			continue;

		%CollectList = GetMissionData(%Mid,$Mission_Data_Cj);	    //采集物列表
		%CollectNum  = GetWordCount(%CollectList,";");             //采集物总数
		%ItemList    = GetMissionData(%Mid,$Mission_Data_ItemGet);	//所需物品列表

		for (%j = 0; %j < %CollectNum/2; %j++)
		{
			%CollectID   = GetWord(%CollectList,%j * 2,";");       //采集物ID
			%CollectFlag = GetWord(%CollectList,%j * 2 + 1,";");   //决定该采集物是否给予物品
			if (%CollectID != %EventID)
				continue;

			if (%CollectFlag >= 2200 && %CollectFlag < 2300)
			{
				%ID     = (%CollectFlag - 2200) *2;
				%ItemID = GetWord(%ItemList,%ID,";");   //获取物品ID
				if (%ItemID !$= "")
				{
					%Player.PutItem(%ItemID,1);
					%Player.AddItem(3,%EventID);
					return;
				}
			}
		}
	}
}
//■■■■■■■■■■■■需要获得任务物品的采集物■■■■■■■■■■■■

//■■■■■■■■■■■■采集对应的任务编号■■■■■■■■■■■■■■■

$Item_Mission[552000001] = "10017"; //采集药草
$Item_Mission[552000036] = "20203"; //采集鼠窝
$Item_Mission[553000018] = "29101"; //采集枯木灵芝
$Item_Mission[553000019] = "29105"; //采集柴火
$Item_Mission[553000023] = "29114"; //采集野果
$Item_Mission[553000024] = "29115"; //采集荷叶
$Item_Mission[553000025] = "29116"; //采集珠子
$Item_Mission[553000026] = "29118"; //采集针线
$Item_Mission[553000027] = "29124"; //采集荷花
$Item_Mission[553000028] = "29125"; //采集紫晶石
$Item_Mission[553000031] = "29137"; //采集虎牙草
$Item_Mission[553000032] = "29138"; //采集紫萱草
$Item_Mission[553000033] = "29142"; //采集炉水
$Item_Mission[553000034] = "29146"; //采集布匹
$Item_Mission[553000035] = "29148"; //采集莲藕
$Item_Mission[552000022] = "29230"; //采集岩松
$Item_Mission[552000023] = "29231"; //采集雪松
$Item_Mission[552000024] = "29232"; //采集灵晶
$Item_Mission[552000025] = "29233"; //采集冰莲花
$Item_Mission[552000026] = "29234"; //采集清冷液
$Item_Mission[552000027] = "29235"; //采集柴火
$Item_Mission[552000030] = "29239"; //采集雪绒草
$Item_Mission[552000032] = "29241"; //采集寒葵草
$Item_Mission[552000033] = "29242"; //采集遗失的护符
$Item_Mission[552000035] = "29244"; //采集原石
$Item_Mission[553000040] = "10691"; //采集佘兰草
$Item_Mission[553000037] = "10021"; //采集海蚌
$Item_Mission[553000038] = "10141"; //采集蚕蛹
$Item_Mission[553000039] = "10091"; //采集龙延草
$Item_Mission[553000045] = "10431"; //采集凝魂草
$Item_Mission[553000046] = "10471"; //采集一壶清水
$Item_Mission[553000047] = "10521"; //采集香樟叶
$Item_Mission[553000048] = "10521"; //采集仙草
$Item_Mission[553000049] = "10481"; //采集鱼群
$Item_Mission[552000017] = "11061"; //采集遗失首饰
$Item_Mission[552000018] = "11111 29227"; //采集寒冰草
$Item_Mission[552000037] = "11321"; //青髓草
$Item_Mission[552000038] = "29326 11361"; //灵竹
$Item_Mission[552000039] = "29333 11411"; //蘑菇
$Item_Mission[552000040] = "29332 11451"; //灵泉
$Item_Mission[552000041] = "11491"; //避水珍珠
$Item_Mission[552000042] = "11501"; //海草
$Item_Mission[552000043] = "29327"; //竹笋
$Item_Mission[552000046] = "29331"; //竹叶
$Item_Mission[552000047] = "29334"; //仙人掌
$Item_Mission[552000048] = "29335"; //满天星
$Item_Mission[552000049] = "29336"; //枯草
$Item_Mission[552000052] = "29339"; //椰子
$Item_Mission[552000053] = "29340"; //多肉植物
$Item_Mission[552000057] = "29344"; //香芋

//--------------------------下面是只计数不给道具的采集----------------------------
$TriggerEvent_Mission[552000010] = "20149 2230;";		//伏灵草
$TriggerEvent_Mission[552000011] = "20149 2230;";		//灵枫木
$TriggerEvent_Mission[552000012] = "20149 2230;";		//紫兰花
$TriggerEvent_Mission[552000013] = "20149 2230;";		//卷宗
$TriggerEvent_Mission[552000014] = "20149 2230;";		//玄天露
$TriggerEvent_Mission[552000002] = "20149 2230;10221 2230;";		//蓬莱道经
$TriggerEvent_Mission[553000020] = "29109 2230;";		 //渔网
$TriggerEvent_Mission[553000021] = "29111 2230;";		 //火把
$TriggerEvent_Mission[553000022] = "29112 2230;";		 //宝藏
$TriggerEvent_Mission[553000029] = "29129 2230;";		 //笼子
$TriggerEvent_Mission[553000030] = "29131 2230;";		 //炼仙炉
$TriggerEvent_Mission[553000036] = "29113 2230;";		 //祭坛
$TriggerEvent_Mission[553000050] = "20149 2230;10221 2230;";		//蓬莱道经
$TriggerEvent_Mission[553000051] = "10991 2230;";		 //水源
$TriggerEvent_Mission[553000052] = "11011 2230;";		 //镇魔封印
$TriggerEvent_Mission[552000019] = "11121 2230;29236 2230";		 //被困修士
$TriggerEvent_Mission[552000020] = "29228 2230;";		 //木箱
$TriggerEvent_Mission[552000021] = "29229 2230;";		 //寒风
$TriggerEvent_Mission[552000028] = "29237 2230;";		 //封剑台
$TriggerEvent_Mission[552000029] = "29238 2230;";		 //笼子
$TriggerEvent_Mission[552000031] = "29240 2230;";		 //封剑印记
$TriggerEvent_Mission[552000034] = "29243 2230;";		 //白虎台
$TriggerEvent_Mission[552000044] = "29329 2230;";		 //露水
$TriggerEvent_Mission[552000045] = "29330 2230;";		 //池水
$TriggerEvent_Mission[552000050] = "29337 2230;";		 //水轮车
$TriggerEvent_Mission[552000051] = "29338 2230;";		 //彩虹桥
$TriggerEvent_Mission[552000054] = "29341 2230;";		 //溪水
$TriggerEvent_Mission[552000055] = "29342 2230;";		 //竹筏
$TriggerEvent_Mission[552000056] = "29343 2230;";		 //丹炉
$TriggerEvent_Mission[552000058] = "29345 2230;";		 //杂草
$TriggerEvent_Mission[552000059] = "29328 2230;";		 //荷花
//■■■■■■■■■■■■采集对应的任务编号■■■■■■■■■■■■■■■

	
//■■■■■■■■■■■■【特殊对话框】■■■■【发送客户端开关界面】■■
function CloseMissionDuiHuaKuang(%NpcID,%PlayerID,%State,%MMM)
{
	if ($NPC_MissionTS[%NpcID] > 0)
		ServerOnSptAction(%PlayerID,%State,%MMM);
}

//■■■■■■■■■■■■【特殊对话框】■■■■【发送客户端闲聊对白】■■
function OpenDuiHuaKuang_XL(%NpcID,%Player,%State,%MMM)
{
	%PlayerID = %Player.GetPlayerID();
	if ($NPC_MissionTS[%NpcID] > 0)
		ServerOnSptAction(%PlayerID,%State,%MMM);
}