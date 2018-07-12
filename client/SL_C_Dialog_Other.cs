//■■■■■■■■■■■对话文本，脚本主入口■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■通用类对话的组合■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■任务类对话的组合■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■任务内容文字组合■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■道具类对话的组合■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■技能类对话的组合■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■状态类对话的组合■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■NPC类对话的组合■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■传送类相关对话■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■区域类相关对话■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■飞行类相关对话■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■上缴界面文字说明■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■游戏币的格式解析■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■任务名称前的图标解析■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■对话文本，脚本主入口■■■■■■■■■■■■■■■■■
function GetDialogText(%Npc,%Player,%DialogID,%Param)
{
	//echo( "-=======================" );
	//echo( "%DialogID====" @ %DialogID );
	//echo( "%Npc====" @ %Npc );
	//echo( "%Player====" @ %Player );
	//echo( "%Param====" @ %Param );
	$Recordconversationnpc =  %Npc;
	//小于7位的进入商店类对话
	if (strlen(%DialogID) <= 7)return Get_Shop_Dialog(%Npc,%Player,%DialogID,%Param);
	else if (strlen(%DialogID) == 8)return Get_Mission_Dialog(%Npc,%Player,%DialogID,%Param);	//任务类对话
	//9位编号的相关对话
	else if (strlen(%DialogID) == 9)
	{
		//可以依照ID来区分编号类型，也可依据编号首位数字来判断编号类型
		//编号首位代表大类标识，取值范围为1-9，目前已确定：
		%Dialog_SubStr = GetSubStr(%DialogID,0,1);

		if (%Dialog_SubStr $= "1"){ return Get_Item_Dialog(%Npc,%Player,%DialogID,%Param); }	//1、道具
		else if (%Dialog_SubStr $= "2"){ return Get_Skill_Dialog(%Npc,%Player,%DialogID,%Param); }	//2、技能
		else if (%Dialog_SubStr $= "3"){ return Get_Buff_Dialog(%Npc,%Player,%DialogID,%Param); }	//3、状态
		else if (%Dialog_SubStr $= "4"){ return Get_Npc_Dialog(%Npc,%Player,%DialogID,%Param); }	//4、NPC
		else if (%Dialog_SubStr $= "5"){ return Get_Transport_Dialog(%Npc,%Player,%DialogID,%Param); }	//5、传送
		else if (%Dialog_SubStr $= "6"){ return Get_TY_Dialog(%Npc,%Player,%DialogID,%Param); }	//6、昆仑决新增脚本
		else if (%Dialog_SubStr $= "7"){ return Get_HuoDong_Dialog(%Npc,%Player,%DialogID,%Param); }
		else if (%Dialog_SubStr $= "8"){ return Get_Area_Dialog(%Npc,%Player,%DialogID,%Param); }	//8、区域
		else if (%Dialog_SubStr $= "9"){ return Get_Fly_Dialog(%Npc,%Player,%DialogID,%Param); }	//9、尚未确定
	}
	if (strlen(%DialogID) == 10)
		return Get_YGBH_Dialog(%Npc,%Player,%DialogID,%Param);	//月光宝盒相关

	return "GetDialogText == 错误 Npc【"@%Npc@"】Player【"@%Player@"】DialogID【"@%DialogID@"】Id【"@%Param@"】";
}

//■■■■■■■■■■■通用类对话的组合■■■■■■■■■■■■■■■■■■■
function Get_TY_Dialog(%Npc,%Player,%DialogID,%Param)
{
	return Get_TY_Dialog_TY(%Npc,%Player,%DialogID,%Param);
}

//■■■■■■■■■■■任务类对话的组合■■■■■■■■■■■■■■■■■■■
function Get_Mission_Dialog(%Npc,%Player,%DialogID,%Param)
{
	%Tid = GetSubStr(%DialogID,0,3);
	%Mid = GetSubStr(%DialogID,3,5);
	%kind       	= GetMissionKind(%Mid);
	%Mid_LeiXin 	= $MissionKind[%kind,2];
	//echo( "%tid===" @ %tid );
	//新手指引 - 打开任务对话框时触发
	if (%Npc > 0)
		Get_Mission_Dialog_ZhiYinWed(%Player,%DialogID);

	//echo( "%Tid====" @ %Tid );
	//基本任务对话
	if (%Tid == 100)
	{

		//echo("任务接取名字选项显示===" @ GetMissionKind(%Mid));
		if (GetMissionKind(%Mid) == 1)
			return GetMissionIcon(%Mid) @ $Get_Dialog_GeShi[31492] @ %Mid_LeiXin @ "－" @ GetMission_Name(%Player,%Mid,1) @ "</t>";	//接取
		else
		{
			if (%Mid == 20036 || %Mid == 20043 || %Mid == 20050 || %Mid == 20057 || %Mid == 20064)
			{
				%class0 = %player.GetClasses(0);
				switch (%class0)
				{
					case 1:%HvaeShengWang = GetPrestige(%Player, 1, 1);
					case 2:%HvaeShengWang = GetPrestige(%Player, 1, 4);
					case 3:%HvaeShengWang = GetPrestige(%Player, 1, 2);
					case 4:%HvaeShengWang = GetPrestige(%Player, 1, 3);
					case 5:%HvaeShengWang = GetPrestige(%Player, 1, 5);
				}
				if (%HvaeShengWang < 10000)
					return GetMissionIcon(%Mid) @ $Get_Dialog_GeShi[31494] @ %Mid_LeiXin @ "－" @ GetMission_Name(%Player, %Mid, 1) @ "</t>";	//接取
				else
					return GetMissionIcon(%Mid) @ $Get_Dialog_GeShi[31496] @ %Mid_LeiXin @ "－" @ GetMission_Name(%Player, %Mid, 1) @ "</t>";	//接取
			}
			else
				return GetMissionIcon(%Mid) @ $Get_Dialog_GeShi[31496] @ %Mid_LeiXin @ "－" @ GetMission_Name(%Player, %Mid, 1) @ "</t>";	//接取
		}
	}
	else if (%Tid == 900)
	{
		if (CanDoThisMission(%Player,%Mid,2,0,0) $= "")
			%Mid_Over = "（完成）";
		else
			%Mid_Over = "";

		return $Icon[2] @ $Get_Dialog_GeShi[31493] @ %Mid_LeiXin @ "－" @ GetMission_Name(%Player,%Mid,1) @ %Mid_Over @ "</t>";	//交付
	}
	else if (%Tid == 999)
	{
		%Step = $Get_Dialog_GeShi[31492] @ %Mid_LeiXin @ %Mid @ " - " @ GetMission_Name(%Player,%Mid,1) @ "  [未完成]</t>";

		if (%Player.IsAcceptedMission(%Mid)){ %Step = $Get_Dialog_GeShi[31402] @ %Mid_LeiXin @ %Mid  @ " - " @ GetMission_Name(%Player,%Mid,1) @ "  [已接受]</t>"; }
		if (%Player.IsFinishedMission(%Mid)){ %Step = $Get_Dialog_GeShi[31493] @ %Mid_LeiXin @ %Mid  @ " - " @ GetMission_Name(%Player,%Mid,1) @ "  [已经完成]</t>"; }

		return %Step;
	}
	//正常，显示任务接受时对话
	else if (%Tid == 110) return "<b/>" @ Get_Mis_Dialog(%Npc,%Player,%Mid,2,0) @ $Icon[97] @ "<b/>" @ GetMissionHortation(%Mid,1,10050);
	//显示任务交付条件不满足时的对话
	else if (%Tid == 199) return Get_Mis_Dialog(%Npc,%Player,%Mid,2,0) @ $Icon[97] @ "<b/>" @ GetMissionHortation(%Mid,0,10050);
	//显示任务中途NPC的对话与选项
	else if (%Tid == 200) return $Icon[4] @ $Get_Dialog_GeShi[31492] @  "对话 － " @ GetMission_Name(%Player,%Mid,1) @ "</t>"; //中途
	//显示传送类选项
	else if (%Tid == 201) return $Icon[4] @ $Get_Dialog_GeShi[31492] @  "传送 － " @ GetMission_Name(%Player,%Mid,1) @ "</t>"; //传送
	//【特殊对话框】显示任务中途NPC的对话与选项
	else if (%Tid == 202) return $Icon[4] @ $Get_Dialog_GeShi[50012] @  "对话 － " @ GetMission_Name(%Player,%Mid,1) @ "</t>"; //中途
	//【特殊对话框】显示传送类选项
	else if (%Tid == 203) return $Icon[4] @ $Get_Dialog_GeShi[50015] @  "传送 － " @ GetMission_Name(%Player,%Mid,1) @ "</t>"; //传送

	//任务完成+任务奖励,显示任务交付时对话
	else if (%Tid == 910) return "<b/>" @ Get_Mis_Dialog(%Npc,%Player,%Mid,5,0) @ "<b/>" @ $Icon[97] @ "<b/>" @ GetMissionHortation(%Mid,2,10050);

	//20003,,任务追踪处的热感文字，任务目标+任务奖励
	else if (%Tid == 800)
	{
		//如果没身上没此任务，那就显示可接相关内容
		if (!%Player.IsAcceptedMission(%Mid))
			return $Get_Dialog_GeShi[31401] @ Get_Mis_Dialog(%Npc,%Player,%Mid,1,0) @ GetMission_Flag(%Player,%Mid,"Npc",100,3) @ "</t><b/>" @ $Icon[97] @ "<b/>" @ GetMissionHortation(%Mid,0,10010) @ "</t>";
		else
			return $Get_Dialog_GeShi[31401] @ Get_Mis_Dialog(%Npc,%Player,%Mid,1,0) @ GetMissionNeedText(%Player,%Mid,9999) @ $Icon[97] @ "<b/>" @ GetMissionHortation(%Mid,0,10010) @ "</t>";
	}

	//20010,3+1+6+2+4,任务难度+目标+需求+描述+奖励,任务界面内使用
	else if (%Tid == 888)
	{
		//如果没身上没此任务，那就显示可接相关内容
		if (!%Player.IsAcceptedMission(%Mid))
			return $Get_Dialog_GeShi[31401] @ Get_Mis_Dialog(%Npc,%Player,%Mid,1,0) @ GetMission_Flag(%Player,%Mid,"Npc",100,3) @ "</t>";
		else
			return $Get_Dialog_GeShi[31401] @ Get_Mis_Dialog(%Npc,%Player,%Mid,1,0) @ GetMissionNeedText(%Player,%Mid,9999) @ Get_Mis_Dialog(%Npc,%Player,%Mid,2,0) @ "</t>";
	}

	//超链接内的查看使用
	else if (%Tid == 889)
	{
		//显示任务简述 + 是否接取判断

		//已经接受：显示已接受
		if (%Player.IsAcceptedMission(%Mid))
			%MidTxt = $Get_Dialog_GeShi[31403] @ " √您正在进行此任务</t>";	//绿色字体
		else
		{
			//未接取情况

			//已完成情况
			if (%Player.IsFinishedMission(%Mid))
				%MidTxt = $Get_Dialog_GeShi[31404] @ " √您已经完成此任务</t>";	//黄色字体
			else
			{
				//未完成情况

				//满足接取条件
				if (CanDoThisMission(%Player,%Mid,1,0,0) !$= "")
					%MidTxt = $Get_Dialog_GeShi[31401] @ " ·</t>" @ $Get_Dialog_GeShi[31406] @ "您尚未接取此任务</t><b/>" @	//红色字体
					$Get_Dialog_GeShi[31401] @ " ·</t>" @ $Get_Dialog_GeShi[31406] @ "您不满足此任务的接取条件</t>";	//红色字体
				else
					%MidTxt = $Get_Dialog_GeShi[31401] @ " ·</t>" @ $Get_Dialog_GeShi[31406] @ "您尚未接取此任务</t><b/>" @	//红色字体
					$Get_Dialog_GeShi[31404] @ " √您满足此任务的接取条件</t><b/>" @	//黄色字体
					GetMission_Flag(%Player,%Mid,"Npc",100,3) @ "</t>";	//接任务NPC
			}
		}

		return $Get_Dialog_GeShi[31401] @ Get_Mis_Dialog(%Npc,%Player,%Mid,1,0) @ %MidTxt;
	}
	else if (%Tid == 820)
	{
		return Get_Mis_Dialog(%Npc,%Player,%Mid,1,0) @ Get_Mis_Dialog(%Npc,%Player,%Mid,2,0);
	}

	//自动将任务编号加入至函数命名中去，并执行相应的函数，寻找剩余对话
	%MDFunction = "Mission" @ %Mid @ "Dialog" @ "(%Npc, %Player, %Mid, %Tid);";
	return eval(%MDFunction);
}


//■■■■■■■■■■■任务内容文字组合■■■■■■■■■■■■■■■■■■■
function Get_Mis_Dialog(%Npc,%Player,%Mid,%Tid,%State)
{
	//echo( " %Tid===" @  %Tid );
	//任务通用文字
	switch (%Tid)
	{
		case 1:
			%T10001 = eval("Mission" @ %Mid @ "Dialog" @ "(%Npc, %Player, %Mid, 10001);");	//"任务目标";
			%Txt = $Icon[98] @ "<b/>" @ %T10001 @ "<b/>";

		case 2:
			%TxtID = %Player.GetMissionFlag(%Mid,4000);

			if (%TxtID < 1)
				%TxtID = 10002;

			%T10002 = eval("Mission" @ %Mid @ "Dialog" @ "(%Npc, %Player, %Mid, %TxtID);");	//"任务描述";
			%Txt = $Icon[99] @ "<b/>" @ %T10002 @ "<b/>";

		case 3:
			%Txt = $Icon[95] @ GetMission_NanDu(%Mid);	//"任务难度";

		case 4://奖励移除

		case 5:
			%T10005 = eval("Mission" @ %Mid @ "Dialog" @ "(%Npc, %Player, %Mid, 10005);");	//"任务完成对话";
			%Txt = $Icon[96] @ "<b/>" @ %T10005;
	}

	if (%Txt !$= "")
		return  $Get_Dialog_GeShi[31401]  @ %Txt @ "</t>";

	return "Get_Mis_Dialog == 错误 Tid【"@%Tid@"】";
}


//■■■■■■■■■■■道具类对话的组合■■■■■■■■■■■■■■■■■■■
function Get_Item_Dialog(%Npc,%Player,%DialogID,%Param)
{
	if (%DialogID > 0)
	{
		switch$(%DialogID)
		{
		case "105089001":
		case "108020208":
			return "<t>SendMuBan( %Player )：对话模板、公告模板请搜索函数</t>";
		default:
			//礼包类道具组合对话
			if ((GetItemData(%DialogID,2) == 5) && (GetItemData(%DialogID,3) == 518))
			{
				//清除之前的物品显示
				%Player.ClearMissionItem(10057);
				%Player.ClearMissionItem(10058);
				%Player.ClearMissionItem(10059);

				%Item_Num_All = $Item_Bao[%DialogID];

				%NumAll = GetWord(%Item_Num_All,0);//礼包内道具数量
				%Type   = GetWord(%Item_Num_All,1);//礼包类型
				%TeShu = GetWord(%Item_Num_All,2);//绑定标识以及特殊处理

				//echo( "%Item_Num_All=====" @ %Item_Num_All );
				//echo( "%NumAll====="  @ %NumAll );
				//echo( "%Type=====" @  %Type );
				//echo( "%TeShu====="  @ %TeShu );
				switch (%Type)
				{
					case 1:
						for (%i = 0; %i < %NumAll; %i++)
						{
							//echo( "$Item_Bao[ " @ %DialogID @ "," @  %i + 1 @ "]=="  @ $Item_Bao[ %DialogID, %i + 1 ] );
							%Item = GetWord($Item_Bao[%DialogID,%i + 1],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 1],1);
							//echo( "%Item====="  @ %Item  @ "   %Num====" @ %Num );
							%Player.AddItemToMission(10057,1,%Item,%Num);
						}
						%Txt1 = "<t>打开此礼包，你将获得以下物品：</t><b/>" @ GetFixedMissionItemText(10057);
						//echo( "%Txt1 ===" @ %Txt1 );
					case 2:
						for (%i = 0; %i < %NumAll; %i++)
						{
							//echo( "$Item_Bao[ " @ %DialogID @ "," @  %i + 1 @ "]=="  @ $Item_Bao[ %DialogID, %i + 1 ] );
							%Item = GetWord($Item_Bao[%DialogID,%i + 1],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 1],1);
							//echo( "%Item====="  @ %Item  @ "   %Num====" @ %Num );
							%Player.AddItemToMission(10057,0,%Item,%Num);
						}
						%Txt1 = "<t>打开此礼包，你将从以下物品序列中选中获得某个物品：</t><b/>" @ GetOptionalMissionItemText(10057);
					case 3:
						for (%i = 0; %i < %NumAll; %i++)
						{
							//echo( "$Item_Bao[ " @ %DialogID @ "," @  %i + 1 @ "]=="  @ $Item_Bao[ %DialogID, %i + 1 ] );
							%Item = GetWord($Item_Bao[%DialogID,%i + 1],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 1],1);
							//%Ran  = GetWord( $Item_Bao[ %DialogID, %i + 1 ], 2 );
							//echo( "%Item====="  @ %Item  @ "   %Num====" @ %Num );
							if (%Item > 0)
								%Player.AddItemToMission(10057,1,%Item,%Num);
						}
						%Txt1 = "<t>打开此礼包，你将从以下物品中随机获取一件：</t><b/>" @ GetFixedMissionItemText(10057);
					case 4:
						for (%i = 0; %i < %NumAll; %i++)
						{
							%Item = GetWord($Item_Bao[%DialogID,%i + 1],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 1],1);
							if (%Item > 0)
							{
								%record1 = 1;
								%Player.AddItemToMission(10057,1,%Item,%Num);
							}
							%Item = GetWord($Item_Bao[%DialogID,%i + 101],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 101],1);
							if (%Item > 0)
							{
								%record2 = 1;
								%Player.AddItemToMission(10058,1,%Item,%Num);
							}
						}
						if (%record1 == 1 && %record2 == 1)
							%Txt1 = "<t>打开此礼包，你将获得以下物品：</t><b/>" @ GetFixedMissionItemText(10057)  @ "<b/><b/><t>同时,有一定几率获得以下物品：</t><b/>" @ GetFixedMissionItemText(10058);
						else if (%record1 == 1 && %record2 == 0)
							%Txt1 = "<t>打开此礼包，你将获得以下物品：</t><b/>" @ GetFixedMissionItemText(10057);
						else if (%record1 == 0 && %record2 == 1)
							%Txt1 = "<t>打开此礼包，有一定几率获得以下物品：</t><b/>" @ GetFixedMissionItemText(10058);
					case 5:
						for (%i = 0; %i < %NumAll; %i++)
						{
							%Item = GetWord($Item_Bao[%DialogID,%i + 1],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 1],1);
							if (%Item > 0)
							{
								%record1 = 1;
								%Player.AddItemToMission(10057,1,%Item,%Num);
							}
							%Item = GetWord($Item_Bao[%DialogID,%i + 101],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 101],1);
							if (%Item > 0)
							{
								%record2 = 1;
								%Player.AddItemToMission(10058,1,%Item,%Num);
							}
						}
						if (%record1 == 1 && %record2 == 1)
							%Txt1 = "<t>打开此礼包，你将获得以下物品：</t><b/>" @ GetFixedMissionItemText(10057)  @ "<b/><b/><t>同时,有一定几率获得以下物品：</t><b/>" @ GetFixedMissionItemText(10058);
						else if (%record1 == 1 && %record2 == 0)
							%Txt1 = "<t>打开此礼包，你将获得以下物品：</t><b/>" @ GetFixedMissionItemText(10057);
						else if (%record1 == 0 && %record2 == 1)
							%Txt1 = "<t>打开此礼包，有一定几率获得以下物品：</t><b/>" @ GetFixedMissionItemText(10058);
					case 6:
						for (%i = 0; %i < %NumAll; %i++)
						{
							%Item = GetWord($Item_Bao[%DialogID,%i + 1],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 1],1);
							%LvSpc = GetWord($Item_Bao[%DialogID,%i + 1],3);
							//echo( "%LvSpc=============" @ %LvSpc );
							if (%LvSpc $= "LvSp1")
								%Item = GetNewItemIDForLevel(%Player,%Item);
							if (%Item > 0)
							{
								%record1 = 1;
								%Player.AddItemToMission(10057,1,%Item,%Num);
							}
							%Item = GetWord($Item_Bao[%DialogID,%i + 101],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 101],1);
							%LvSpc = GetWord($Item_Bao[%DialogID,%i + 101],3);
							if (%LvSpc $= "LvSp1")
								%Item = GetNewItemIDForLevel(%Player,%Item);
							if (%Item > 0)
							{
								%record2 = 1;
								%Player.AddItemToMission(10058,1,%Item,%Num);
							}

							%Item = GetWord($Item_Bao[%DialogID,%i + 1001],0);
							%Num  = GetWord($Item_Bao[%DialogID,%i + 1001],1);
							%LvSpc = GetWord($Item_Bao[%DialogID,%i + 1001],3);
							if (%LvSpc $= "LvSp1")
								%Item = GetNewItemIDForLevel(%Player,%Item);
							if (%Item > 0)
							{
								%record3 = 1;
								%Player.AddItemToMission(10059,1,%Item,%Num);
							}
						}
						%Txt1 = "<t>打开此礼包，</t>";
						%Txt2 = "";
						%Txt3 = "";
						%Txt4 = "";
						if (%record1 == 1)
							%Txt2 = "<t>你将获得以下物品：</t><b/>" @ GetFixedMissionItemText(10057) @ "<b/>";
						if (%record2 == 1)
							%Txt3 = "<t>随机获得以下其中一件物品：</t><b/>" @ GetFixedMissionItemText(10058) @ "<b/>";
						if (%record3 == 1)
							%Txt4 = "<t>有一定几率获得以下物品：</t><b/>" @ GetFixedMissionItemText(10059) @ "<b/>";

						%Txt1 = %Txt1 @ %Txt2 @ %Txt3 @ %Txt4;
				}
				//0=可选奖励	GetOptionalMissionItemText( %missionid )
				//	1=必给奖励	GetFixedMissionItemText( %missionid )

				return $Get_Dialog_GeShi[31401] @ %Txt1 @ "</t>";
			}
		}
	}

	return "Get_Item_Dialog == 错误 Npc【"@%Npc@"】Player【"@%Player@"】DialogID【"@%DialogID@"】Id【"@%Param@"】";
}

//■■■■■■■■■■■技能类对话的组合■■■■■■■■■■■■■■■■■■■
function Get_Skill_Dialog(%Npc,%Player,%DialogID,%Param)
{
	return "Get_Skill_Dialog == 错误 Npc【"@%Npc@"】Player【"@%Player@"】DialogID【"@%DialogID@"】Id【"@%Param@"】";
}

//■■■■■■■■■■■状态类对话的组合■■■■■■■■■■■■■■■■■■■
function Get_Buff_Dialog(%Npc,%Player,%DialogID,%Param)
{
	return "Get_Buff_Dialog == 错误 Npc【"@%Npc@"】Player【"@%Player@"】DialogID【"@%DialogID@"】Id【"@%Param@"】";
}

//■■■■■■■■■■■NPC类对话的组合■■■■■■■■■■■■■■■■■■■
function Get_Npc_Dialog(%Npc,%Player,%DialogID,%Param)
{
	if (%Npc.GetDataID() $= %DialogID)
	{
		if ($NpcRandomDialog[%Npc.GetDataID(),1] !$= "")
		{
			%D = 1;
			if ($NpcRandomDialog[%Npc.GetDataID(),2] !$= ""){ %D = 2; }
			if ($NpcRandomDialog[%Npc.GetDataID(),3] !$= ""){ %D = 3; }

			return "<t>" @ $NpcRandomDialog[%Npc.GetDataID(),GetRandom(1,%D)] @ "</t>";
		}
		else
			return $Get_Dialog_GeShi[31401] @ "欢迎来到《昆仑决》的世界</t><b/><b/>";
	}
	else
		return "Get_Npc_Dialog == 编号不对 NpcID【"@%Npc.GetDataID()@"】Player【"@%Player@"】DialogID【"@%DialogID@"】Id【"@%Param@"】";

	return "Get_Npc_Dialog == 错误 Npc【"@%Npc@"】Player【"@%Player@"】DialogID【"@%DialogID@"】Id【"@%Param@"】";
}

//■■■■■■■■■■■传送类相关对话■■■■■■■■■■■■■■■■■■■■
function Get_Transport_Dialog(%Npc,%Player,%DialogID,%Param)
{

	%objID = "8" @ GetSubStr(%DialogID,1,8);
	%objName = GetTriggerData(%objID,3);

	%NpcID = %Npc.GetDataid();
	//echo( "==============================" );
	//echo( "%DialogID===" @ %DialogID );
	//echo( "%NpcID ==" @ %NpcID );
	//echo( "%objID ==" @ %objID );
	if ($CalculationNpcTransport[%NpcID,%objID,1] $= "")
	{
		%Number = GetWordCount($Transport_Npc[%NpcID],";");
		//echo( "$Transport_Npc[ %NpcID ]==" @ $Transport_Npc[ %NpcID ] );
		for (%i = 0; %i < %Number; %i++)
		{
			%MsgList =  GetWord($Transport_Npc[%NpcID],%i,";");
			%WanttoMapID = GetWord(%MsgList,0);
			%NeedMoney = GetWord(%MsgList,1);
			%LevelMin = GetWord(%MsgList,2);
			%LevelMax = GetWord(%MsgList,3);

			if (strlen(%WanttoMapID) == 4)
				%WanttoMapID = "8" @ %WanttoMapID @ "0100";
			else if (strlen(%WanttoMapID) == 9)
				%WanttoMapID = "8" @ GetSubStr(%WanttoMapID,1,8);

			if (%WanttoMapID $= %objID)
			{
				$CalculationNpcTransport[%NpcID,%objID,1] = %NeedMoney;
				$CalculationNpcTransport[%NpcID,%objID,2] = %LevelMin;
				$CalculationNpcTransport[%NpcID,%objID,3] = %LevelMax;
				break;
			}
		}
	}
	//echo("1====" @ $CalculationNpcTransport[ %NpcID, %objID, 1 ] );
	//echo("2====" @ $CalculationNpcTransport[ %NpcID, %objID, 2 ] );
	//echo("3====" @ $CalculationNpcTransport[ %NpcID, %objID, 3 ] );
	%Level = %Player.GetLevel();
	if (%Level < $CalculationNpcTransport[%NpcID,%objID,2])
		%Text = $Icon[10] @ $Get_Dialog_GeShi[31407] @ "<t>传送 - 【</t>" @ %objName @ "<t>】</t></t>";
	else if (%Level > $CalculationNpcTransport[%NpcID,%objID,3])
		%Text = $Icon[10] @ $Get_Dialog_GeShi[31407] @ "<t>传送 - 【</t>" @ %objName @ "<t>】</t></t>";
	else if (%Player.getmoney(2) < $CalculationNpcTransport[%NpcID,%objID,1])
		%Text = $Icon[10] @ $Get_Dialog_GeShi[31407] @ "<t>传送 - 【</t>" @ %objName @ "<t>】</t></t>";
	else
	{
		%showmoney = ChangeMoneyText($CalculationNpcTransport[%NpcID,%objID,1]);
		if (%showmoney $= "")
			%Text = $Icon[10] @ $Get_Dialog_GeShi[31401] @ "<t>传送 - 【</t>" @ %objName @ "<t>】</t>";
		else
			%Text = $Icon[10] @ $Get_Dialog_GeShi[31401] @ "<t>传送 - 【</t>" @ %objName @ "<t>】[</t>" @ %showmoney @ "<t>]</t></t>";
	}
	//echo( "%Text===" @ %Text );
	return %Text;
}
//■■■■■■■■■■■区域类相关对话■■■■■■■■■■■■■■■■■■■■
function Get_Area_Dialog(%Npc,%Player,%DialogID,%Param)
{
	return "Get_Area_Dialog == 错误 Npc【"@%Npc@"】Player【"@%Player@"】DialogID【"@%DialogID@"】Id【"@%Param@"】";
}

//■■■■■■■■■■■飞行类相关对话■■■■■■■■■■■■■■■■■■■■
function Get_Fly_Dialog(%Npc,%Player,%DialogID,%Param)
{
	%FlyID = GetSubStr(%DialogID,1,8);

	switch$(%FlyID)
	{
		case "10010101":
	}

	return "Get_Fly_Dialog == 错误 Npc【"@%Npc@"】Player【"@%Player@"】DialogID【"@%DialogID@"】Id【"@%Param@"】";
}

//获取通用类对话
function Get_Shop_Dialog(%Npc,%Player,%DialogID,%Param)
{
	%DialogLog = strlen(%DialogID);

	//以DialogID的长度来区分，小于2位的独立显示
	if (%DialogLog < 3)
	{
		switch (%DialogID)
		{
			case 0: return $Get_Dialog_GeShi[31401] @ "欢迎来到《昆仑决》世界！</t><b/><b/>";
			case 1:	return $Icon[4] @ $Get_Dialog_GeShi[31493] @ "结束对话</t>";
			case 2:	return "<t>接受任务</t>";
			case 3:	return $Icon[1] @ $Get_Dialog_GeShi[31493] @ "完成任务</t>";
			case 4:	return $Icon[14] @ "<t>返回</t>";
			case 5:	return $Icon[5] @ "<t>打开</t>";
			case 6:	return "<t>你的背包已满，放不下了，请清理一下吧</t>";
			case 7:	return "<t>物品数据错误</t>";
			case 8:	return  $Icon[4] @"<t>知道了</t>";
			case 9:	return "<t>查看物品</t>";
			case 10:return $Icon[4] @ $Get_Dialog_GeShi[31493] @ "关闭</t>";
			case 11:return $Icon[4] @ "<t>离开这里</t>";
			case 12:return "<t>清除师门惩罚</t>";
			case 13:return "<t>启动控制台</t>";
			case 14:return "<t>让我改变某个任务的状态</t>";
			case 15:return "直接接受";
			case 16:return "<t>直接完成</t>";
			case 17:return "<t>强制放弃</t>";
			case 18:return "<t>设置成未完成状态</t>";
			case 19:return "<t>【圣地任务】</t>";
			case 20:return "<t>【章回任务】</t>";
			case 21:return "<t>【支线剧情】</t>";
			case 22:return "<t>【每日循环】</t>";
			case 23:return "<t>【帮派任务】</t>";
			case 24:return "<t>【指引任务】</t>";
			case 25:return "<t>【其它任务】</t>";
			case 26:return "<t>目前暂无此类任务</t>";
			case 27:return "<t>你想对此任务干什么？</t>";
			case 28:return "<t>重置福神的祝福</t>";
			case 29:return "<t>让我牛逼吧！</t>";
			case 30:return "<t>爆发吧！小宇宙！（改变你的圣地值）</t>";
			case 31:return "<t>不对哦，你没有足够的货币……</t>";
			case 32:return "<t>暂未开放，敬请期待！</t>";
			case 33:return $Icon[5] @ "<t>灵珠进阶</t>";
			case 34:return "<t>本命灵珠进阶条件不满足，无法提升阶段</t>";
			case 35:return $Icon[6] @ "<t>进阶指南</t>";
			case 36:return $Icon[5] @ "<t>开启【感悟】</t>";
			case 37:return $Icon[5] @ "<t>开启【感悟】</t>";
			case 38:return $Icon[5] @ "<t>化身相关</t>";
			case 39:return $Icon[5] @ "<t>加一个化身</t>";
			case 40:return $Icon[5] @ "<t>提升化身等级</t>";
			case 41:return $Icon[5] @ "<t>增加化身境界</t>";
			case 42:return "<t>【10001】圣</t>";
			case 43:return "<t>【10002】佛</t>";
			case 44:return "<t>【10003】仙</t>";
			case 45:return "<t>【10004】精</t>";
			case 46:return "<t>【10005】鬼</t>";
			case 47:return "<t>【10006】怪</t>";
			case 48:return "<t>【10007】妖</t>";
			case 49:return "<t>【10008】魔</t>";
			case 50:return "<t>【10011】圣</t>";
			case 51:return "<t>【10012】佛</t>";
			case 52:return "<t>【10013】仙</t>";
			case 53:return "<t>【10014】精</t>";
			case 54:return "<t>【10015】鬼</t>";
			case 55:return "<t>【10016】怪</t>";
			case 56:return "<t>【10017】妖</t>";
			case 57:return "<t>【10018】魔</t>";

		}
		switch (%DialogID)
		{
			case 58:return $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>召唤【高帅富】</t>";
			case 59:return $Icon[5] @ $Get_Dialog_GeShi[31407] @ "<t>召唤【矮丑穷】</t>";
			case 60:return "<t>不对哦，你不是队长，无法使用……</t>";
			case 61:return "<t>不对哦，你的队员没有全部集合……</t>";
			case 62:return "<t>你今天已经使用过此功能，请明天再来吧……</t>";
			case 63:return "<t>师徒相关</t>";
			case 64:return "<t>增加资格(师傅等级)</t>";
			case 65:return "<t>增加师德</t>";
			case 66:return "<t>你今天已经参加过此活动了，请明天再来吧……</t>";
			case 67:return $Icon[5] @ $Get_Dialog_GeShi[31491] @ "测试选项文字格式</t>";
			case 68:return $Icon[5] @ $Get_Dialog_GeShi[31492] @ "测试选项文字格式</t>";
			case 69:return $Icon[5] @ $Get_Dialog_GeShi[31493] @ "测试选项文字格式</t>";
			case 70:return $Icon[5] @ $Get_Dialog_GeShi[31494] @ "测试选项文字格式</t>";
			case 71:return $Icon[5] @ $Get_Dialog_GeShi[31495] @ "测试选项文字格式</t>";
			case 72:return "<t>升级当前神兽经验</t>";
			case 73:return "<t>……悲惨人生</t>";
			case 74:return "<t>准备好了吗？我们前往鬼村！</t>";
			case 75:return $Icon[10] @ $Get_Dialog_GeShi[31493] @ "我准备好了</t>";
			case 76:return "<t>清除安全时间</t>";
			case 77:return "<t>改变神兽性格</t>";
			case 78:return "<t>添加好感度(9999点)</t>";
			case 79:return "<t>真.独孤求败</t>";
			case 80:return "<t>信曾哥没用</t>";
			case 81:return "<t>清除监狱状态</t>";
			case 82:return "<t>清除善恶值</t>";
			case 83:return "<t>添加星宿经验</t>";
			case 84:return "<t>一键进阶打孔</t>";
			case 85:return "<t>请把要打孔进阶的装备放在包裹第一行第一列，集中注意力，对它轻轻吹一口气，再点选项...</t>";
			case 86:return "<t>您已经进入不健康状态，无法接交任务</t>";
			case 87:return "<t>添加星宿经验（每次100点）</t>";
			case 88:return "<t>添加星宿经验（每次1000点）</t>";
			case 89:return "<t>添加星宿经验（每次10000点）</t>";
			case 90:return "<t>一键学习门派技能</t>";
			case 91:return "<t>你未选择门派，请先选择门派</t>";
			case 92:return "<t>选择五行属性技能</t>";
			case 93:return "<t>学习所有主系技能</t>";
			case 94:return "<t>学习所有辅系技能</t>";
			case 95:return "<t>请先选择门派，并在未学习任何主或辅系技能的情况下使用，否则后果自负。</t>";
			case 96:return "<t>屏蔽防沉迷</t>";
			case 97:return "<t>【10101】通用治疗</t>";
			case 98:return "<t>打开固定摊位界面</t>";
			case 99:return "<t>给我10000点积分</t>";
		}
	}
	else
	{
		//以DialogID的长度来区分
		switch (%DialogLog)
		{
			case 3:
			case 4:
			case 5:
				switch (%DialogID)
				{
					case 400001: return $Icon[8] @ "<t>所有道具测试</t>";
					case 400002: return $Icon[8] @ "<t>镶嵌测试商店</t>";
					case 400003: return $Icon[8] @ "<t>1--80级武器测试</t>";
					case 400004: return $Icon[8] @ "<t>1--80级防具测试</t>";
					case 400005: return $Icon[8] @ "<t>1--80级饰品测试</t>";
					case 400006: return $Icon[8] @ "<t>进阶测试商店</t>";
					case 400007: return $Icon[8] @ "<t>鉴定测试商店</t>";
					case 400008: return $Icon[8] @ "<t>模型测试商店</t>";
					case 400009: return $Icon[8] @ "<t>任务测试商店</t>";
					case 400010: return $Icon[8] @ "<t>测试商店</t>";
					case 400011: return $Icon[8] @ "<t>技能书商店</t>";
					case 400012: return $Icon[8] @ "<t>商店功能测试</t>";
					case 400013: return $Icon[8] @ "<t>视频专用商店</t>";
				}
			case 6:
				if (GetSubStr(%DialogID,0,1) == 4)		   //如果是6位，且ID的第二位是1，例如410005
				{
					switch (%DialogID)
					{
						//-----测试商店------------
						case 400001: return $Icon[8] @ "<t>常用测试商店</t>";
						case 400002: return $Icon[8] @ "<t>测试商店</t>";
							//---------通用商店-------	
						case 410000: return $Icon[8] @ "<t>武器商店</t>";
						case 410001: return $Icon[8] @ "<t>铸造商店</t>";
						case 410002: return $Icon[8] @ "<t>配方商店</t>";
						case 410003: return $Icon[8] @ "<t>药品商店</t>";
						case 410004: return $Icon[8] @ "<t>炼丹商店</t>";
						case 410005: return $Icon[8] @ "<t>配方商店</t>";
						case 410006: return $Icon[8] @ "<t>战技商店</t>";
						case 410007: return $Icon[8] @ "<t>制符商店</t>";
						case 410008: return $Icon[8] @ "<t>配方商店</t>";
						case 410009: return $Icon[8] @ "<t>装备商店</t>";
						case 410010: return $Icon[8] @ "<t>裁缝商店</t>";
						case 410011: return $Icon[8] @ "<t>配方商店</t>";
						case 410012: return $Icon[8] @ "<t>饰品商店</t>";
						case 410013: return $Icon[8] @ "<t>制器商店</t>";
						case 410014: return $Icon[8] @ "<t>配方商店</t>";
						case 410015: return $Icon[8] @ "<t>食物商店</t>";
						case 410016: return $Icon[8] @ "<t>烹饪商店</t>";
						case 410017: return $Icon[8] @ "<t>配方商店</t>";
						case 410018: return $Icon[8] @ "<t>杂货店</t>";
						case 410019: return $Icon[8] @ "<t>昆仑古币商店</t>";

						case 410021: return $Icon[7] @ "<t>灵晶商店</t>";
						case 410022: return $Icon[7] @ "<t>灵晶商店</t>";
						case 410023: return $Icon[7] @ "<t>灵晶商店</t>";
						case 410024: return $Icon[7] @ "<t>灵晶商店</t>";
						case 410031: return $Icon[7] @ "<t>神石商店</t>";
						case 410032: return $Icon[7] @ "<t>神石商店</t>";
						case 410033: return $Icon[7] @ "<t>神石商店</t>";
						case 410034: return $Icon[7] @ "<t>神石商店</t>";

						case 410100: return $Icon[8] @ "<t>武器商店</t>";
						case 410101: return $Icon[8] @ "<t>铸造商店</t>";
						case 410102: return $Icon[8] @ "<t>配方商店</t>";
						case 410103: return $Icon[8] @ "<t>药品商店</t>";
						case 410104: return $Icon[8] @ "<t>炼丹商店</t>";
						case 410105: return $Icon[8] @ "<t>配方商店</t>";
						case 410106: return $Icon[8] @ "<t>战技商店</t>";
						case 410107: return $Icon[8] @ "<t>制符商店</t>";
						case 410108: return $Icon[8] @ "<t>配方商店</t>";
						case 410109: return $Icon[8] @ "<t>装备商店</t>";
						case 410110: return $Icon[8] @ "<t>裁缝商店</t>";
						case 410111: return $Icon[8] @ "<t>配方商店</t>";
						case 410112: return $Icon[8] @ "<t>饰品商店</t>";
						case 410113: return $Icon[8] @ "<t>制器商店</t>";
						case 410114: return $Icon[8] @ "<t>配方商店</t>";
						case 410115: return $Icon[8] @ "<t>食物商店</t>";
						case 410116: return $Icon[8] @ "<t>烹饪商店</t>";
						case 410117: return $Icon[8] @ "<t>配方商店</t>";
						case 410118: return $Icon[8] @ "<t>杂货店</t>";
						case 410119: return $Icon[8] @ "<t>神秘商店</t>";
						case 410120: return $Icon[8] @ "<t>渔具商店</t>";

						case 410200: return $Icon[8] @ "<t>武器商店</t>";
						case 410201: return $Icon[8] @ "<t>铸造商店</t>";
						case 410202: return $Icon[8] @ "<t>配方商店</t>";
						case 410203: return $Icon[8] @ "<t>药品商店</t>";
						case 410204: return $Icon[8] @ "<t>炼丹商店</t>";
						case 410205: return $Icon[8] @ "<t>配方商店</t>";
						case 410206: return $Icon[8] @ "<t>战技商店</t>";
						case 410207: return $Icon[8] @ "<t>制符商店</t>";
						case 410208: return $Icon[8] @ "<t>配方商店</t>";
						case 410209: return $Icon[8] @ "<t>装备商店</t>";
						case 410210: return $Icon[8] @ "<t>裁缝商店</t>";
						case 410211: return $Icon[8] @ "<t>配方商店</t>";
						case 410212: return $Icon[8] @ "<t>饰品商店</t>";
						case 410213: return $Icon[8] @ "<t>制器商店</t>";
						case 410214: return $Icon[8] @ "<t>配方商店</t>";
						case 410215: return $Icon[8] @ "<t>食物商店</t>";
						case 410216: return $Icon[8] @ "<t>烹饪商店</t>";
						case 410217: return $Icon[8] @ "<t>配方商店</t>";
						case 410218: return $Icon[8] @ "<t>杂货店</t>";

						case 410300: return $Icon[8] @ "<t>武器商店</t>";
						case 410301: return $Icon[8] @ "<t>铸造商店</t>";
						case 410302: return $Icon[8] @ "<t>配方商店</t>";
						case 410303: return $Icon[8] @ "<t>药品商店</t>";
						case 410304: return $Icon[8] @ "<t>炼丹商店</t>";
						case 410305: return $Icon[8] @ "<t>配方商店</t>";
						case 410306: return $Icon[8] @ "<t>战技商店</t>";
						case 410307: return $Icon[8] @ "<t>制符商店</t>";
						case 410308: return $Icon[8] @ "<t>配方商店</t>";
						case 410309: return $Icon[8] @ "<t>装备商店</t>";
						case 410310: return $Icon[8] @ "<t>裁缝商店</t>";
						case 410311: return $Icon[8] @ "<t>配方商店</t>";
						case 410312: return $Icon[8] @ "<t>饰品商店</t>";
						case 410313: return $Icon[8] @ "<t>制器商店</t>";
						case 410314: return $Icon[8] @ "<t>配方商店</t>";
						case 410315: return $Icon[8] @ "<t>食物商店</t>";
						case 410316: return $Icon[8] @ "<t>烹饪商店</t>";
						case 410317: return $Icon[8] @ "<t>配方商店</t>";
						case 410318: return $Icon[8] @ "<t>杂货店</t>";

						case 410400: return $Icon[8] @ "<t>武器商店</t>";
						case 410401: return $Icon[8] @ "<t>铸造商店</t>";
						case 410402: return $Icon[8] @ "<t>配方商店</t>";
						case 410403: return $Icon[8] @ "<t>药品商店</t>";
						case 410404: return $Icon[8] @ "<t>炼丹商店</t>";
						case 410405: return $Icon[8] @ "<t>配方商店</t>";
						case 410406: return $Icon[8] @ "<t>战技商店</t>";
						case 410407: return $Icon[8] @ "<t>制符商店</t>";
						case 410408: return $Icon[8] @ "<t>配方商店</t>";
						case 410409: return $Icon[8] @ "<t>装备商店</t>";
						case 410410: return $Icon[8] @ "<t>裁缝商店</t>";
						case 410411: return $Icon[8] @ "<t>配方商店</t>";
						case 410412: return $Icon[8] @ "<t>饰品商店</t>";
						case 410413: return $Icon[8] @ "<t>制器商店</t>";
						case 410414: return $Icon[8] @ "<t>配方商店</t>";
						case 410415: return $Icon[8] @ "<t>食物商店</t>";
						case 410416: return $Icon[8] @ "<t>烹饪商店</t>";
						case 410417: return $Icon[8] @ "<t>配方商店</t>";
						case 410418: return $Icon[8] @ "<t>杂货店</t>";

						case 410500: return $Icon[8] @ "<t>武器商店</t>";
						case 410501: return $Icon[8] @ "<t>铸造商店</t>";
						case 410502: return $Icon[8] @ "<t>配方商店</t>";
						case 410503: return $Icon[8] @ "<t>药品商店</t>";
						case 410504: return $Icon[8] @ "<t>炼丹商店</t>";
						case 410505: return $Icon[8] @ "<t>配方商店</t>";
						case 410506: return $Icon[8] @ "<t>战技商店</t>";
						case 410507: return $Icon[8] @ "<t>制符商店</t>";
						case 410508: return $Icon[8] @ "<t>配方商店</t>";
						case 410509: return $Icon[8] @ "<t>装备商店</t>";
						case 410510: return $Icon[8] @ "<t>裁缝商店</t>";
						case 410511: return $Icon[8] @ "<t>配方商店</t>";
						case 410512: return $Icon[8] @ "<t>饰品商店</t>";
						case 410513: return $Icon[8] @ "<t>制器商店</t>";
						case 410514: return $Icon[8] @ "<t>配方商店</t>";
						case 410515: return $Icon[8] @ "<t>食物商店</t>";
						case 410516: return $Icon[8] @ "<t>烹饪商店</t>";
						case 410517: return $Icon[8] @ "<t>配方商店</t>";
						case 410518: return $Icon[8] @ "<t>杂货店</t>";

						case 410600: return $Icon[8] @ "<t>武器商店</t>";
						case 410601: return $Icon[8] @ "<t>铸造商店</t>";
						case 410602: return $Icon[8] @ "<t>配方商店</t>";
						case 410603: return $Icon[8] @ "<t>药品商店</t>";
						case 410604: return $Icon[8] @ "<t>炼丹商店</t>";
						case 410605: return $Icon[8] @ "<t>配方商店</t>";
						case 410606: return $Icon[8] @ "<t>战技商店</t>";
						case 410607: return $Icon[8] @ "<t>制符商店</t>";
						case 410608: return $Icon[8] @ "<t>配方商店</t>";
						case 410609: return $Icon[8] @ "<t>装备商店</t>";
						case 410610: return $Icon[8] @ "<t>裁缝商店</t>";
						case 410611: return $Icon[8] @ "<t>配方商店</t>";
						case 410612: return $Icon[8] @ "<t>饰品商店</t>";
						case 410613: return $Icon[8] @ "<t>制器商店</t>";
						case 410614: return $Icon[8] @ "<t>配方商店</t>";
						case 410615: return $Icon[8] @ "<t>食物商店</t>";
						case 410616: return $Icon[8] @ "<t>烹饪商店</t>";
						case 410617: return $Icon[8] @ "<t>配方商店</t>";
						case 410618: return $Icon[8] @ "<t>杂货店</t>";

						case 410700: return $Icon[8] @ "<t>武器商店</t>";
						case 410701: return $Icon[8] @ "<t>铸造商店</t>";
						case 410702: return $Icon[8] @ "<t>配方商店</t>";
						case 410703: return $Icon[8] @ "<t>药品商店</t>";
						case 410704: return $Icon[8] @ "<t>炼丹商店</t>";
						case 410705: return $Icon[8] @ "<t>配方商店</t>";
						case 410706: return $Icon[8] @ "<t>战技商店</t>";
						case 410707: return $Icon[8] @ "<t>制符商店</t>";
						case 410708: return $Icon[8] @ "<t>配方商店</t>";
						case 410709: return $Icon[8] @ "<t>装备商店</t>";
						case 410710: return $Icon[8] @ "<t>裁缝商店</t>";
						case 410711: return $Icon[8] @ "<t>配方商店</t>";
						case 410712: return $Icon[8] @ "<t>饰品商店</t>";
						case 410713: return $Icon[8] @ "<t>制器商店</t>";
						case 410714: return $Icon[8] @ "<t>配方商店</t>";
						case 410715: return $Icon[8] @ "<t>食物商店</t>";
						case 410716: return $Icon[8] @ "<t>烹饪商店</t>";
						case 410717: return $Icon[8] @ "<t>配方商店</t>";
						case 410718: return $Icon[8] @ "<t>杂货店</t>";

						case 410800: return $Icon[8] @ "<t>武器商店</t>";
						case 410801: return $Icon[8] @ "<t>铸造商店</t>";
						case 410802: return $Icon[8] @ "<t>配方商店</t>";
						case 410803: return $Icon[8] @ "<t>药品商店</t>";
						case 410804: return $Icon[8] @ "<t>炼丹商店</t>";
						case 410805: return $Icon[8] @ "<t>配方商店</t>";
						case 410806: return $Icon[8] @ "<t>战技商店</t>";
						case 410807: return $Icon[8] @ "<t>制符商店</t>";
						case 410808: return $Icon[8] @ "<t>配方商店</t>";
						case 410809: return $Icon[8] @ "<t>装备商店</t>";
						case 410810: return $Icon[8] @ "<t>裁缝商店</t>";
						case 410811: return $Icon[8] @ "<t>配方商店</t>";
						case 410812: return $Icon[8] @ "<t>饰品商店</t>";
						case 410813: return $Icon[8] @ "<t>制器商店</t>";
						case 410814: return $Icon[8] @ "<t>配方商店</t>";
						case 410815: return $Icon[8] @ "<t>食物商店</t>";
						case 410816: return $Icon[8] @ "<t>烹饪商店</t>";
						case 410817: return $Icon[8] @ "<t>配方商店</t>";
						case 410818: return $Icon[8] @ "<t>杂货店</t>";

							//--------封魔城 商店  在通用商店编号 + 10000------
						case 420000: return $Icon[8] @ "<t>武器商店</t>";
						case 420001: return $Icon[8] @ "<t>铸造商店</t>";
						case 420002: return $Icon[8] @ "<t>配方商店</t>";
						case 420003: return $Icon[8] @ "<t>药品商店</t>";
						case 420004: return $Icon[8] @ "<t>炼丹商店</t>";
						case 420005: return $Icon[8] @ "<t>配方商店</t>";
						case 420006: return $Icon[8] @ "<t>技能商店</t>";
						case 420007: return $Icon[8] @ "<t>装备商店</t>";
						case 420008: return $Icon[8] @ "<t>裁缝商店</t>";
						case 420009: return $Icon[8] @ "<t>配方商店</t>";
						case 420010: return $Icon[8] @ "<t>饰品商店</t>";
						case 420011: return $Icon[8] @ "<t>制器商店</t>";
						case 420012: return $Icon[8] @ "<t>配方商店</t>";
						case 420013: return $Icon[8] @ "<t>食物商店</t>";
						case 420014: return $Icon[8] @ "<t>烹饪商店</t>";
						case 420015: return $Icon[8] @ "<t>配方商店</t>";
						case 420016: return $Icon[8] @ "<t>杂货店</t>";
							//----其他商店----------------------
						case 430000: return $Icon[8] @ "<t>师门商店</t>";
						case 430001: return $Icon[8] @ "<t>海螺商店</t>";
						case 430002: return $Icon[8] @ "<t>庆典商店</t>";
						case 430003: return $Icon[8] @ "<t>渔具商店</t>";

						case 410035: if (GetPrestige(%Player, 1, 1) >= 50000)return $Icon[8] @ "<t>战·声望商店(一)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "战·声望商店(一)[声望50000点]</t>";
						case 410036: if (GetPrestige(%Player, 1, 1) >= 580000)return $Icon[8] @ "<t>战·声望商店(二)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "战·声望商店(二)[声望580000点]</t>";
						case 410037: if (GetPrestige(%Player, 1, 1) >= 2000000)return $Icon[8] @ "<t>战·声望商店(三)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "战·声望商店(三)[声望2000000点]</t>";
						case 410038: if (GetPrestige(%Player, 1, 1) >= 6000000)return $Icon[8] @ "<t>战·声望商店(四)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "战·声望商店(四)[声望6000000点]</t>";
						case 410039: if (GetPrestige(%Player, 1, 1) >= 15000000)return $Icon[8] @ "<t>战·声望商店(五)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "战·声望商店(五)[声望15000000点]</t>";

						case 410040: if (GetPrestige(%Player, 1, 4) >= 50000)return $Icon[8] @ "<t>刺·声望商店(一)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "刺·声望商店(一)[声望50000点]</t>";
						case 410041: if (GetPrestige(%Player, 1, 4) >= 580000)return $Icon[8] @ "<t>刺·声望商店(二)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "刺·声望商店(二)[声望580000点]</t>";
						case 410042: if (GetPrestige(%Player, 1, 4) >= 2000000)return $Icon[8] @ "<t>刺·声望商店(三)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "刺·声望商店(三)[声望2000000点]</t>";
						case 410043: if (GetPrestige(%Player, 1, 4) >= 6000000)return $Icon[8] @ "<t>刺·声望商店(四)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "刺·声望商店(四)[声望6000000点]</t>";
						case 410044: if (GetPrestige(%Player, 1, 4) >= 15000000)return $Icon[8] @ "<t>刺·声望商店(五)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "刺·声望商店(五)[声望15000000点]</t>";

						case 410045: if (GetPrestige(%Player, 1, 2) >= 50000)return $Icon[8] @ "<t>法·声望商店(一)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "法·声望商店(一)[声望50000点]</t>";
						case 410046: if (GetPrestige(%Player, 1, 2) >= 580000)return $Icon[8] @ "<t>法·声望商店(二)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "法·声望商店(二)[声望580000点]</t>";
						case 410047: if (GetPrestige(%Player, 1, 2) >= 2000000)return $Icon[8] @ "<t>法·声望商店(三)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "法·声望商店(三)[声望2000000点]</t>";
						case 410048: if (GetPrestige(%Player, 1, 2) >= 6000000)return $Icon[8] @ "<t>法·声望商店(四)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "法·声望商店(四)[声望6000000点]</t>";
						case 410049: if (GetPrestige(%Player, 1, 2) >= 15000000)return $Icon[8] @ "<t>法·声望商店(五)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "法·声望商店(五)[声望15000000点]</t>";

						case 410050: if (GetPrestige(%Player, 1, 3) >= 50000)return $Icon[8] @ "<t>道·声望商店(一)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "道·声望商店(一)[声望50000点]</t>";
						case 410051: if (GetPrestige(%Player, 1, 3) >= 580000)return $Icon[8] @ "<t>道·声望商店(二)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "道·声望商店(二)[声望580000点]</t>";
						case 410052: if (GetPrestige(%Player, 1, 3) >= 2000000)return $Icon[8] @ "<t>道·声望商店(三)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "道·声望商店(三)[声望2000000点]</t>";
						case 410053: if (GetPrestige(%Player, 1, 3) >= 6000000)return $Icon[8] @ "<t>道·声望商店(四)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "道·声望商店(四)[声望6000000点]</t>";
						case 410054: if (GetPrestige(%Player, 1, 3) >= 15000000)return $Icon[8] @ "<t>道·声望商店(五)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "道·声望商店(五)[声望15000000点]</t>";

						case 410055: if (GetPrestige(%Player, 1, 5) >= 50000)return $Icon[8] @ "<t>弓·声望商店(一)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "弓·声望商店(一)[声望50000点]</t>";
						case 410056: if (GetPrestige(%Player, 1, 5) >= 580000)return $Icon[8] @ "<t>弓·声望商店(二)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "弓·声望商店(二)[声望580000点]</t>";
						case 410057: if (GetPrestige(%Player, 1, 5) >= 2000000)return $Icon[8] @ "<t>弓·声望商店(三)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "弓·声望商店(三)[声望2000000点]</t>";
						case 410058: if (GetPrestige(%Player, 1, 5) >= 6000000)return $Icon[8] @ "<t>弓·声望商店(四)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "弓·声望商店(四)[声望6000000点]</t>";
						case 410059: if (GetPrestige(%Player, 1, 5) >= 15000000)return $Icon[8] @ "<t>弓·声望商店(五)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "弓·声望商店(五)[声望15000000点]</t>";

						case 410220: if (GetPrestige(%Player, 2, 1) >= 50000)return $Icon[8] @ "<t>望仙镇声望商店(一)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "望仙镇声望商店(一)[声望50000点]</t>";
						case 410221: if (GetPrestige(%Player, 2, 1) >= 580000)return $Icon[8] @ "<t>望仙镇声望商店(二)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "望仙镇声望商店(二)[声望580000点]</t>";
						case 410222: if (GetPrestige(%Player, 2, 1) >= 2000000)return $Icon[8] @ "<t>望仙镇声望商店(三)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "望仙镇声望商店(三)[声望2000000点]</t>";
						case 410223: if (GetPrestige(%Player, 2, 1) >= 6000000)return $Icon[8] @ "<t>望仙镇声望商店(四)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "望仙镇声望商店(四)[声望6000000点]</t>";
						case 410224: if (GetPrestige(%Player, 2, 1) >= 15000000)return $Icon[8] @ "<t>望仙镇声望商店(五)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "望仙镇声望商店(五)[声望15000000点]</t>";

						case 410320: if (GetPrestige(%Player, 2, 2) >= 50000)return $Icon[8] @ "<t>白虎寨声望商店(一)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "白虎寨声望商店(一)[声望50000点]</t>";
						case 410321: if (GetPrestige(%Player, 2, 2) >= 580000)return $Icon[8] @ "<t>白虎寨声望商店(二)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "白虎寨声望商店(二)[声望580000点]</t>";
						case 410322: if (GetPrestige(%Player, 2, 2) >= 2000000)return $Icon[8] @ "<t>白虎寨声望商店(三)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "白虎寨声望商店(三)[声望2000000点]</t>";
						case 410323: if (GetPrestige(%Player, 2, 2) >= 6000000)return $Icon[8] @ "<t>白虎寨声望商店(四)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "白虎寨声望商店(四)[声望6000000点]</t>";
						case 410324: if (GetPrestige(%Player, 2, 2) >= 15000000)return $Icon[8] @ "<t>白虎寨声望商店(五)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "白虎寨声望商店(五)[声望15000000点]</t>";

						case 410420: if (GetPrestige(%Player, 2, 3) >= 50000)return $Icon[8] @ "<t>泽云渡声望商店(一)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "泽云渡声望商店(一)[声望50000点]</t>";
						case 410421: if (GetPrestige(%Player, 2, 3) >= 580000)return $Icon[8] @ "<t>泽云渡声望商店(二)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "泽云渡声望商店(二)[声望580000点]</t>";
						case 410422: if (GetPrestige(%Player, 2, 3) >= 2000000)return $Icon[8] @ "<t>泽云渡声望商店(三)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "泽云渡声望商店(三)[声望2000000点]</t>";
						case 410423: if (GetPrestige(%Player, 2, 3) >= 6000000)return $Icon[8] @ "<t>泽云渡声望商店(四)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "泽云渡声望商店(四)[声望6000000点]</t>";
						case 410424: if (GetPrestige(%Player, 2, 3) >= 15000000)return $Icon[8] @ "<t>泽云渡声望商店(五)</t>"; else return $Icon[8] @ $Get_Dialog_GeShi[31407] @ "泽云渡声望商店(五)[声望15000000点]</t>";
					}
				}
				else
				{
					switch (%DialogID)
					{
						case 100000: return $Icon[5] @ "<t>领取本周免费双倍</t>";
						case 100001: return $Icon[5] @ "<t>存储双倍经验时间</t>";
						case 100002: return $Icon[5] @ "<t>取出双倍经验时间</t>";
						case 100004: return $Icon[5] @ "<t>存储一小时</t>";
						case 100005: return $Icon[5] @ "<t>存储全部</t>";
						case 100006: return $Icon[5] @ "<t>取出一小时</t>";
						case 100007: return $Icon[5] @ "<t>取出全部</t>";
						case 100008:
							%Act_A = GetAct(GetPlayer(),3031,0);
							%Act_B = GetAct(GetPlayer(),3031,1);
							%Time = mfloor(%Act_A * 60 + %Act_B/60);
							//echo( "%Act_A ==" @ %Act_A );
							//echo( "%Act_B ==" @ %Act_B );
							//echo( "%Time ==" @ %Time );
							return
								"<t>尊贵的修士：</t><b/>" @
								"<t>您当前存储的双倍时间：</t>" @ $Get_Dialog_GeShi[31403] @ %Time @ "</t><t> 分钟</t>";

						case 100009: return $Icon[5] @ "<t>删除角色</t>";
						case 100010: return "<t>  为了保护玩家的角色安全，角色无法直接删除，必须先在人物选择界面内点击删除来递交删除角色申请</t><b/>" @
							$Get_Dialog_GeShi[31403] @ "  在申请后会有3天的申请处理时间，3天后您才可以使用准备删除的角色来我这里确认删除，并在14天后自动取消删除角色申请</t><b/>" @
							"<t>  在角色申请删除后的任意时间内，您都可以随时取消删除，但在确认删除时，您必须满足以下条件才可以删除角色：</t><b/>" @
							$Get_Dialog_GeShi[31406] @ "  1.不能处于帮派、姻缘、结拜、师徒关系中</t><b/>" @
							$Get_Dialog_GeShi[31406] @ "  2.所拥有的物品、骑宠不能有锁定状态</t><b/>";
						case 100011:return $Icon[5] @ "<t>取消删除角色</t>";
						case 100012:return "<t>您确认要删除当前角色吗？</t>";
						case 100013:return "<t>您当前的角色已经递交删除申请</t>";
						case 100014:return $Icon[10] @ "<t>进入禁地</t>";
						case 100015:return $Icon[10] @ "<t>进入『心魔幻境』</t>";
						case 100016:return $Icon[5] @ "<t>兑换媒体礼包</t>";
						case 100017:return $Icon[6] @ "<t>了解【诛妖】相关</t>";
						case 100018:return $Icon[6] @ "<t>了解【藏宝图】相关</t>";
						case 100019:
							return "<t>上古时代，妖魔纵横。上古人族崛起后，把妖魔或驱逐或封印。然，妖魔祸乱人间之心不死，人族修士，当为人族之剑，斩妖除魔。帮助昆仑奇人击败妖魔，有机会获得</t>" @ "<l i='113090002' t='itemid'/>" @ "<t>。</t>";
						case 100020:
							return "<t>上古妖魔，将天材地宝、珍贵法宝藏匿于各个隐秘之处，以待将来有重归之日。岂料，前尘往事如过眼云烟，转眼十万年已逝，人族日渐强盛，妖魔万古算计终成空。不过，他们留下的</t>" @ "<l i='113090002' t='itemid'/>" @
								"<t>却浮现世间，开启宝藏后有机会获得各种珍贵道具奖励。</t>";
						case 100021:return $Icon[5] @ "<t>打开仓库</t>";
						case 100022:return $Icon[5] @ "<t>打开宝石界面</t>";
						case 100023:return $Icon[5] @ "<t>打开装备鉴定界面</t>";
						case 100024:return $Icon[5] @ "<t>打开装备强化界面</t>";
						case 100025:return $Icon[5] @ "<t>打开邮箱</t>";
						case 100026:
							%Level = getplayer().getlevel();
							if (%Level < 35)
								%Level = 35;
							return $Icon[19] @ $Get_Dialog_GeShi[31496] @ "循环-[" @ %Level @ "] 悬赏缉凶（接受）</t>";
						case 100027:return $Icon[5] @ "<t>打开铸造台</t>";
						case 100028:return $Icon[5] @ "<t>打开炼丹炉</t>";
						case 100029:return $Icon[5] @ "<t>打开缝纫台</t>";
						case 100030:return $Icon[5] @ "<t>打开烹饪鼎</t>";
						case 100031:return $Icon[5] @ "<t>打开制符案</t>";
						case 100032:return $Icon[5] @ "<t>打开制器台</t>";
						case 100033:
							if (GetPlayer().GetLevel() < 30)
								return	$Icon[5] @ $Get_Dialog_GeShi[31407] @ "创建帮派（需30级）</t>";
							else
								return $Icon[5] @ "<t>创建帮派</t>";
						case 100034:return $Icon[5] @ "<t>查询帮派</t>";
						case 100035:
							if (getplayer().GetOrgMemberLevel(1) < 6)
								return	$Icon[5] @ $Get_Dialog_GeShi[31407] @ "帮派升级（需帮主权限）</t>";
							else
								return $Icon[5] @ "<t>帮派升级</t>";
						case 100036:
							if (getplayer().GetOrgMemberLevel(1) < 6)
								return	$Icon[5] @ $Get_Dialog_GeShi[31407] @ "帮派宣战（需帮主权限）</t>";
							else
								return $Icon[5] @ "<t>帮派宣战</t>";
						case 100037:
							if (getplayer().GetOrgID() > 0)
								return $Icon[5] @ "<t>帮派捐献</t>";
							else
								return	$Icon[5] @ $Get_Dialog_GeShi[31407] @ "帮派捐献（需加入帮派）</t>";

						case 100038:return $Icon[5] @ "<t>捐献金条</t>";
						case 100039:return $Icon[5] @ "<t>捐献金砖</t>";
						case 100040:return $Icon[5] @ "<t>捐献一级奇珍</t>";
						case 100041:return $Icon[5] @ "<t>捐献二级奇珍</t>";
						case 100042:return $Icon[5] @ "<t>捐献三级奇珍</t>";
						case 100043:return $Icon[5] @ "<t>捐献四级奇珍</t>";
						case 100044:return $Icon[5] @ "<t>捐献五级奇珍</t>";
						case 100045:return $Icon[5] @ "<t>捐献六级奇珍</t>";
						case 100046:return $Icon[5] @ "<t>捐献七级奇珍</t>";
						case 100047:return $Icon[5] @ "<t>捐献八级奇珍</t>";
						case 100048:return $Icon[5] @ "<t>捐献九级奇珍</t>";
						case 100049:return $Icon[5] @ "<t>捐献十级奇珍</t>";
								
						case 100050:
							%ItemID[1] = 105105303; 
							%ItemName1 = "<l i='" @ %ItemID[1] @ "' t='itemid'/>";
							return
								"<t>捐献需要：</t><b/>" @
								"<t>    </t>" @ %ItemName1 @ "<t>* 1</t><b/>" @
								"<t>每捐献一份可增加：</t><b/>" @
								"<t>  声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%ItemID[1]] @ " </t><t>点</t><b/>";
						case 100051:
							%ItemID[1] = 105105304;
							%ItemName1 = "<l i='" @ %ItemID[1] @ "' t='itemid'/>";
							return
								"<t>捐献需要：</t><b/>" @
								"<t>    </t>" @ %ItemName1 @ "<t>* 1</t><b/>" @
								"<t>每捐献一份可增加：</t><b/>" @
								"<t>  声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%ItemID[1]] @ " </t><t>点</t><b/>";
						case 100052:
							%ItemID[1] = 105109401; %ItemID[2] = 105109402; %ItemID[3] = 105109403; %ItemID[4] = 105109404;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName[1] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[2] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[3] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[4] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";
						case 100053:
							%ItemID[1] = 105109411; %ItemID[2] = 105109412; %ItemID[3] = 105109413; %ItemID[4] = 105109414;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName[1] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[2] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[3] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[4] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";
						case 100054:
							%ItemID[1] = 105109421; %ItemID[2] = 105109422; %ItemID[3] = 105109423; %ItemID[4] = 105109424;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName[1] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[2] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[3] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[4] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";
						case 100055:
							%ItemID[1] = 105109431; %ItemID[2] = 105109432; %ItemID[3] = 105109433; %ItemID[4] = 105109434;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName[1] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[2] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[3] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[4] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";
						case 100056:
							%ItemID[1] = 105109441; %ItemID[2] = 105109442; %ItemID[3] = 105109443; %ItemID[4] = 105109444;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName[1] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[2] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[3] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[4] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";
						case 100057:
							%ItemID[1] = 105109451; %ItemID[2] = 105109452; %ItemID[3] = 105109453; %ItemID[4] = 105109454;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName[1] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[2] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[3] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[4] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";
						case 100058:
							%ItemID[1] = 105109461; %ItemID[2] = 105109462; %ItemID[3] = 105109463; %ItemID[4] = 105109464;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName[1] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[2] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[3] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[4] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";
						case 100059:
							%ItemID[1] = 105109471; %ItemID[2] = 105109472; %ItemID[3] = 105109473; %ItemID[4] = 105109474;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName[1] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[2] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[3] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[4] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";
						case 100060:
							%ItemID[1] = 105109481; %ItemID[2] = 105109482; %ItemID[3] = 105109483; %ItemID[4] = 105109484;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName[1] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[2] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[3] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[4] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";
						case 100061:
							%ItemID[1] = 105109491; %ItemID[2] = 105109492; %ItemID[3] = 105109493; %ItemID[4] = 105109494;
							%ItemName[1] = "<l i='" @ %Itemid[1] @ "' t='itemid'/>";
							%ItemName[2] = "<l i='" @ %Itemid[2] @ "' t='itemid'/>";
							%ItemName[3] = "<l i='" @ %Itemid[3] @ "' t='itemid'/>";
							%ItemName[4] = "<l i='" @ %Itemid[4] @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName[1] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[1]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[2] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[2]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[3] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[3]] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName[4] @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid[4]] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";
						case 100062:return $Icon[5] @ "<t>确定捐献</t>"; //废弃
						case 100063:return $Icon[5] @ "<t>确定捐献</t>"; //废弃
						case 100064:return $Icon[5] @ "<t>确定捐献</t>";
						case 100065:return $Icon[5] @ "<t>确定捐献</t>";
						case 100066:return $Icon[5] @ "<t>确定捐献</t>";
						case 100067:return $Icon[5] @ "<t>确定捐献</t>";
						case 100068:return $Icon[5] @ "<t>确定捐献</t>";
						case 100069:return $Icon[5] @ "<t>确定捐献</t>";
						case 100070:return $Icon[5] @ "<t>确定捐献</t>";
						case 100071:return $Icon[5] @ "<t>确定捐献</t>";
						case 100072:return $Icon[5] @ "<t>确定捐献</t>";
						case 100073:return $Icon[5] @ "<t>确定捐献</t>";

						case 100074:
								return "<t>可通过捐献金条、金砖、奇珍来增加门派声望。</t><b/>" @ %Text;

						case 100075:return $Icon[5] @ "<t>开始鉴宝</t>";
						case 100076:return $Icon[5] @ "<t>神石合成</t>";
						case 100077:return $Icon[5] @ "<t>装备修理</t>";
						case 100078:return $Icon[5] @ "<t>元宝交易</t>";
						case 100079:return $Icon[5] @ "<t>领取趣味答题奖励</t>";
						case 100080:
							%RanKing = %Player.getAnswerRank();//排名
							%Sorce = %Player.getAnswerPoint();//获取分数
							%Player.ClearMissionItem(10050);

							switch (%RanKing)
							{
								case 1: %ItemID[1] = 105090901; %ItemCount[1]= 6; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 301;
								case 2: %ItemID[1] = 105090901; %ItemCount[1]= 5; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 302;
								case 3: %ItemID[1] = 105090901; %ItemCount[1]= 4; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 303;
								case 4: %ItemID[1] = 105090901; %ItemCount[1]= 3; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
								case 5: %ItemID[1] = 105090901; %ItemCount[1]= 3; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
								case 6: %ItemID[1] = 105090901; %ItemCount[1]= 2; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
								case 7: %ItemID[1] = 105090901; %ItemCount[1]= 2; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
								case 8: %ItemID[1] = 105090901; %ItemCount[1]= 2; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
								case 9: %ItemID[1] = 105090901; %ItemCount[1]= 2; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
								case 10:%ItemID[1] = 105090901; %ItemCount[1]= 2; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
								default:
							}
							//EXP = 等级经验 * 积分 * 等级系数 + 等级段补充经验
							%Level = %Player.Getlevel();
							%OneExp = $Monster_Exp[%Level,1];

							if (%Level < 30) %Coefficient = 0.5;
							else if (%Level < 40) %Coefficient = 1;
							else if (%Level < 50) %Coefficient = 1.2;
							else if (%Level < 60) %Coefficient = 1.6;
							else if (%Level < 70) %Coefficient = 2.0;
							else %Coefficient = 2.2;

							if (%Level < 25) %LevelExp = 0;
							else if (%Level < 40) %LevelExp = 20000;
							else if (%Level < 50) %LevelExp = 30000;
							else if (%Level < 60) %LevelExp = 50000;
							else if (%Level < 70) %LevelExp = 80000;
							else if (%Level < 80) %LevelExp = 100000;
							else if (%Level < 90) %LevelExp = 120000;
							else if (%Level < 100) %LevelExp = 120000;
							else if (%Level < 110) %LevelExp = 120000;
							else if (%Level < 120) %LevelExp = 120000;
							else if (%Level < 130) %LevelExp = 120000;
							else if (%Level < 140) %LevelExp = 120000;
							else if (%Level < 150) %LevelExp = 120000;

							%Exp = %OneExp * %Sorce * %Coefficient + %LevelExp;
							%Exp = mfloor(%Exp);
							if (%Sorce  == 0)
								%Exp = 0;


							if (%RanKing  == 0)
								%Rank = "<t>我的排名：20名以外</t><b/>";
							else
								%Rank = "<t>我的排名：" @ %RanKing @ "</t><b/>";
							%Sorce = "<t>我的积分：" @ %Sorce @ "</t><b/>";
							%exp = "<t>我的经验：" @ %Exp @ "</t><b/>";
							%Item ="";
							for (%i = 1; %i <=9; %i++)
							{
								if (%ItemID[%i] > 0 && %ItemCount[%i] > 0)
								{
									%Item = "<t>道具奖励：</t><b/>";
									%Player.AddItemToMission(10050,1,%ItemID[%i],%ItemCount[%i]);
								}
								else
									break;
							}
							%Text = %Rank @ %Sorce @ %exp;
							return $Get_Dialog_GeShi[80002] @ %Text @ %Item @ "</t>" @ GetFixedMissionItemText(10050);
						case 100081:
							return $Icon[5] @ "<t>领取奖励</t>";
						case 100082:
							return $Icon[5] @ "<t>生活技能学习</t>";
						case 100083://帮派升级条件
							return
								$Get_Dialog_GeShi[80001] @ "1级帮派升级需要：</t><b/>" @
								GetItemName(105105303,1) @ "<t>* 10</t><b/>" @
								"<t> 帮派活跃达到 </t>" @ $Get_Dialog_GeShi[31409] @ "10000 </t><t>点</t><b/>" @
								"<t> 帮派声望达到 </t>" @ $Get_Dialog_GeShi[31409] @ "10000 </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80001] @ "2级帮派升级需要：</t><b/>" @
								GetItemName(105105304,1) @ "<t>* 10</t><b/>" @
								"<t> 帮派活跃达到 </t>" @ $Get_Dialog_GeShi[31409] @ "20000 </t><t>点</t><b/>" @
								"<t> 帮派声望达到 </t>" @ $Get_Dialog_GeShi[31409] @ "100000 </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80001] @ "3级帮派升级需要：</t><b/>" @
								GetItemName(105105304,1) @ "<t>* 50</t><b/>" @
								GetItemName(105105305,1) @ "<t>* 1</t><b/>" @
								"<t> 帮派活跃达到 </t>" @ $Get_Dialog_GeShi[31409] @ "30000 </t><t>点</t><b/>" @
								"<t> 帮派声望达到 </t>" @ $Get_Dialog_GeShi[31409] @ "250000 </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80001] @ "4级帮派升级需要：</t><b/>" @
								GetItemName(105105304,1) @ "<t>* 100</t><b/>" @
								GetItemName(105105305,1) @ "<t>* 10</t><b/>" @
								"<t> 帮派活跃达到 </t>" @ $Get_Dialog_GeShi[31409] @ "40000 </t><t>点</t><b/>" @
								"<t> 帮派声望达到 </t>" @ $Get_Dialog_GeShi[31409] @ "1000000 </t><t>点</t>";

						case 100084:
							return $Icon[5] @ "<t>我要升级</t>";
						case 100085:
							return $Icon[5] @ "<t>【攻城战】申请</t>";
						case 100086:
							return $Icon[5] @ "<t>称号领取</t>";
						case 100087:return $Icon[5] @ "<t>声望捐献</t>";
						case 100088:
							//echo("%Player.gettarget()==="@ %Player.gettarget());
							switch (%Player.gettarget().getdataid())
							{
								case 410010134:%Text = $Get_Dialog_GeShi[80001] @ "当前拥有战门声望：" @ GetPrestige(%Player, 1, 1) * 1 @ " 点</t>";//战
								case 410010136:%Text = $Get_Dialog_GeShi[80001] @ "当前拥有法门声望：" @ GetPrestige(%Player, 1, 2) * 1 @ " 点</t>";//法
								case 410010137:%Text = $Get_Dialog_GeShi[80001] @ "当前拥有道门声望：" @ GetPrestige(%Player, 1, 3) * 1 @ " 点</t>";//道
								case 410010135:%Text = $Get_Dialog_GeShi[80001] @ "当前拥有隐门声望：" @ GetPrestige(%Player, 1, 4) * 1 @ " 点</t>";//刺

								case 411010004:%Text = $Get_Dialog_GeShi[80001] @ "当前拥有望仙镇声望：" @ GetPrestige(%Player, 2, 1) * 1 @ " 点</t>";
								case 411020010:%Text = $Get_Dialog_GeShi[80001] @ "当前拥有白虎寨声望：" @ GetPrestige(%Player, 2, 2) * 1 @ " 点</t>";
								case 411030015:%Text = $Get_Dialog_GeShi[80001] @ "当前拥有泽云度声望：" @ GetPrestige(%Player, 2, 3) * 1 @ " 点</t>";
							}
							return
								"<t>缥缈仙途，逆天而行气运之争，门派声望有助于抢夺先机！可通过捐献金条、金砖、奇珍来增加门派声望。</t><b/>" @ %Text;

						case 100089:return $Icon[5] @ "<t>捐献1金</t>";
						case 100090:return $Icon[5] @ "<t>捐献金条</t>";
						case 100091:return $Icon[5] @ "<t>捐献金砖</t>";
						case 100092:
							return
								"<t>捐献需要：</t><b/>" @
								"<t>    每次1金币</t><b/>" @
								"<t>每捐献一份可增加：</t><b/>" @
								"<t>  声望 </t>" @ $Get_Dialog_GeShi[31409] @ "300 </t><t>点</t><b/>";
						case 100093:return $Icon[5] @ "<t>确定捐献</t>";

						case 100094:
							%Itemid = 105105303;
							%ItemName1 = "<l i='" @ %Itemid @ "' t='itemid'/>";
							return
								"<t>捐献需要：</t><b/>" @
								"<t>    </t>" @ %ItemName1 @ "<t>* 1</t><b/>" @
								"<t>每捐献一份可增加：</t><b/>" @
								"<t>  声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid] @ " </t><t>点</t><b/>";
						case 100095:return $Icon[5] @ "<t>捐献一根</t>";
						case 100096:return $Icon[5] @ "<t>捐献所有</t>";

						case 100097:
							%Itemid = 105105304;
							%ItemName1 = "<l i='" @ %Itemid @ "' t='itemid'/>";
							return
								"<t>捐献需要：</t><b/>" @
								"<t>    </t>" @ %ItemName1 @ "<t>* 1</t><b/>" @
								"<t>每捐献一份可增加：</t><b/>" @
								"<t>  声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid] @ " </t><t>点</t><b/>";
						case 100098:return $Icon[5] @ "<t>捐献一块</t>";
						case 100099:return $Icon[5] @ "<t>捐献所有</t>";

						case 100100:return $Icon[5] @ "<t>捐献一级奇珍</t>";
						case 100101:return $Icon[5] @ "<t>捐献二级奇珍</t>";
						case 100102:return $Icon[5] @ "<t>捐献三级奇珍</t>";
						case 100103:return $Icon[5] @ "<t>捐献四级奇珍</t>";
						case 100104:return $Icon[5] @ "<t>捐献五级奇珍</t>";
						case 100105:return $Icon[5] @ "<t>捐献六级奇珍</t>";
						case 100106:return $Icon[5] @ "<t>捐献七级奇珍</t>";
						case 100107:return $Icon[5] @ "<t>捐献八级奇珍</t>";
						case 100108:return $Icon[5] @ "<t>捐献九级奇珍</t>";
						case 100109:return $Icon[5] @ "<t>捐献十级奇珍</t>";

						case 100110:
							%Itemid1 = 105109401;
							%Itemid2 = 105109402;
							%Itemid3 = 105109403;
							%Itemid4 = 105109404;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName1 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName2 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName3 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName4 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";
						case 100111:
							%Itemid1 = 105109411;
							%Itemid2 = 105109412;
							%Itemid3 = 105109413;
							%Itemid4 = 105109414;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName1 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName2 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName3 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName4 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";
						case 100112:
							%Itemid1 = 105109421;
							%Itemid2 = 105109422;
							%Itemid3 = 105109423;
							%Itemid4 = 105109424;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName1 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName2 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName3 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName4 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";
						case 100113:
							%Itemid1 = 105109431;
							%Itemid2 = 105109432;
							%Itemid3 = 105109433;
							%Itemid4 = 105109434;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName1 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName2 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName3 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName4 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";
						case 100114:
							%Itemid1 = 105109441;
							%Itemid2 = 105109442;
							%Itemid3 = 105109443;
							%Itemid4 = 105109444;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName1 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName2 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName3 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName4 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";
						case 100115:
							%Itemid1 = 105109451;
							%Itemid2 = 105109452;
							%Itemid3 = 105109453;
							%Itemid4 = 105109454;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName1 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName2 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName3 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName4 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";
						case 100116:
							%Itemid1 = 105109461;
							%Itemid2 = 105109462;
							%Itemid3 = 105109463;
							%Itemid4 = 105109464;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName1 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName2 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName3 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName4 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";
						case 100117:
							%Itemid1 = 105109471;
							%Itemid2 = 105109472;
							%Itemid3 = 105109473;
							%Itemid4 = 105109474;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName1 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName2 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName3 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName4 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";
						case 100118:
							%Itemid1 = 105109481;
							%Itemid2 = 105109482;
							%Itemid3 = 105109483;
							%Itemid4 = 105109484;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName1 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName2 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName3 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName4 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";
						case 100119:
							%Itemid1 = 105109491;
							%Itemid2 = 105109492;
							%Itemid3 = 105109493;
							%Itemid4 = 105109494;
							%ItemName1 = "<l i='" @ %Itemid1 @ "' t='itemid'/>";
							%ItemName2 = "<l i='" @ %Itemid2 @ "' t='itemid'/>";
							%ItemName3 = "<l i='" @ %Itemid3 @ "' t='itemid'/>";
							%ItemName4 = "<l i='" @ %Itemid4 @ "' t='itemid'/>";
							return
								"<t>捐献</t>" @ %ItemName1 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid1] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName2 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid2] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName3 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid3] @ " </t><t>点</t><b/>" @
								"<t>捐献</t>" @ %ItemName4 @ "<t>* 1可增加声望 </t>" @ $Get_Dialog_GeShi[31409] @ $MenPaiShengWangJuanXian[%Itemid4] @ " </t><t>点</t><b/>" @
								$Get_Dialog_GeShi[80004] @ "点击确定后，上缴包裹内所有此等级奇珍。</t>";

						case 100120:return $Icon[5] @ "<t>确定捐献</t>";
						case 100121:return $Icon[5] @ "<t>确定捐献</t>";
						case 100122:return $Icon[5] @ "<t>确定捐献</t>";
						case 100123:return $Icon[5] @ "<t>确定捐献</t>";
						case 100124:return $Icon[5] @ "<t>确定捐献</t>";
						case 100125:return $Icon[5] @ "<t>确定捐献</t>";
						case 100126:return $Icon[5] @ "<t>确定捐献</t>";
						case 100127:return $Icon[5] @ "<t>确定捐献</t>";
						case 100128:return $Icon[5] @ "<t>确定捐献</t>";
						case 100129:return $Icon[5] @ "<t>确定捐献</t>";


						//-------------------帮派捐献的金条捐献和金砖捐献----------------
						case 100130:return $Icon[5] @ "<t>捐献一根</t>";
						case 100131:return $Icon[5] @ "<t>捐献全部</t>";
						case 100132:return $Icon[5] @ "<t>捐献一块</t>";
						case 100133:return $Icon[5] @ "<t>捐献全部</t>";
					}
					//%ItemName1 = "<l i='" @ 105109491 @ "' t='itemid'/>";
					//%ItemName2 = "<l i='" @ 105109492 @ "' t='itemid'/>";
					//%ItemName3 = "<l i='" @ 105109494 @ "' t='itemid'/>";
					//return
					//	"<t>捐献需要：</t><b/>" @
					//	"<t>    </t>" @ %ItemName1 @ "<t>* 10</t><b/>" @
					//	"<t>    </t>" @ %ItemName2 @ "<t>* 10</t><b/>" @
					//	"<t>    </t>" @ %ItemName3 @ "<t>* 10</t><b/>" @
					//	"<t>每捐献一份可增加：</t><b/>" @
					//	"<t>  帮派声望 </t>" @ $Get_Dialog_GeShi[31409] @ "18 </t><t>点</t><b/>";
				}
			case 7:
				//活动追踪特殊拼凑 800 @ %PlayGameID(4位)
				if (GetSubStr(%DialogID,0,3) == 800)
				{
					//活动追踪特殊拼凑 800 @ %PlayGameID(4位)
					%PlayGameID = %DialogID%100;
					return $Icon[94] @ "<b/><t>  </t>" @ $PlayGameHelpEx[%PlayGameID,2];
				}
			case 8:
		}
	}
	return "Get_TY_Dialog == 错误 Npc【"@%Npc@"】Player【"@%Player@"】DialogID【"@%DialogID@"】Id【"@%Param@"】";
}


//■■■■■■■■■■■上缴界面文字说明■■■■■■■■■■■■■■■■■■■
function GetMissionSubmitDialogText(%missionid)
{
	%player = Getplayer();
	switch (%missionid)
	{
		case 1000:return
			$Get_Dialog_GeShi[11400] @ "◆『3级天珠升级卷』使用：</t><b/>" @
			"<t>  ·将『3级宝石』拖入上缴栏</t><b/>" @
			"<t>  ·确认后将自动扣除『3级天珠升级卷』</t><b/>" @
			"<t>  ·成功后将获得对应的『4级宝石』</t><b/><b/>" @
			$Get_Dialog_GeShi[11400] @ "◆特别注意：</t><b/>" @
			"<t>  ·升级后的『4级宝石』将会『不可交易』</t>";
	}
}

//■■■■■■■■■■■游戏币的格式解析■■■■■■■■■■■■■■■■■■■
function Mission_Special_Money_HX(%MissionData_Money,%Genre)
{

	//%MissionData_Money 总量
	//%Genre 金钱类型 0金币，1元宝

	//元宝奖励解析
	if (%MissionData_Money != 0)
	{
		%a = %MissionData_Money;
		%b = 9 - strlen(%a);
		%c = "1";
		for (%i = 0; %i < %b; %i++)
			%c = %c @ "0";

		%Money = %c @ %a;

		%Money_A = GetSubStr(%Money,1,5) + 0;	//金币
		%Money_B = GetSubStr(%Money,6,2) + 0;	//银币
		%Money_C = GetSubStr(%Money,8,2) + 0;	//铜币

		%Txt = $Get_Dialog_GeShi[31401];

		%Icon_G = (%Genre == 0) ? 85 : 81;

		if (%Money_A > 0)
			%Show_A = %Txt @ %Money_A @ "</t> "@ $Icon[%Icon_G];
		else
			%Show_A = "";

		if (%Money_B > 0)
			%Show_B = %Txt @ %Money_B @ "</t> " @ $Icon[%Icon_G+1];
		else
			%Show_B = "";

		if (%Money_C > 0)
			%Show_C = %Txt @ %Money_C @ "</t> " @ $Icon[%Icon_G+2];
		else
			%Show_C = "";

		return %Money = $Get_Dialog_GeShi[31412] @ "</t>" @ %Show_A @ %Show_B @ %Show_C @ "<t></t>";
	}
	else
		return %Money = "";
}

//获取任务前的图标
//■■■■■■■■■■■任务名称前的图标解析■■■■■■■■■■■■■■■■■
function GetMissionIcon(%MID)
{
	switch (GetMissionData(%MID,$Mission_Data_Type))
	{
		case 0:	return $Icon[18];	//"〖圣地任务〗"//支线任务接受图标
		case 1:	return $Icon[17];	//"〖章回任务〗"//主线任务接受图标
		case 2:	return $Icon[18];	//"〖支线剧情〗"//支线任务接受图标
		case 3:	return $Icon[19];	//"〖每日循环〗"//循环任务接受图标
		case 4:	return $Icon[18];	//"〖帮派任务〗"//支线任务接受图标
		case 5:	return $Icon[18];	//"〖指引任务〗"//支线任务接受图标
		case 6:	return $Icon[18];	//"〖活动任务〗"//支线任务接受图标
		case 7:	return $Icon[18];	//"〖其它任务〗"//支线任务接受图标
		default: return $Icon[18];	//支线任务接受图标
	}
}

//活动特殊文字
function Get_HuoDong_Dialog(%Npc,%Player,%DialogID,%Param)
{
	//以活动编号命名，不足9位用0代替
	//必须以7开头，如：7 001 000 01
	//自行按照顺序排列
	%Dlg = GetSubStr(%DialogID,1,3);
	%MDFunction = "HuoDong_" @ %Dlg @ "_Dialog" @ "(%Npc, %Player, %DialogID);";
	return eval(%MDFunction);
}

function HuoDong_001_Dialog(%Npc,%Player,%DialogID)
{
	return %Txt;
}

