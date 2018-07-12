//=============================================================================
// 文档说明:帮派活动界面
// 创建时间:2018-03-19
// 创建人: Irelia

// 修改人: 
// 修改时间: 
//=============================================================================

//■■■■【帮派活动界面】■■■■活动数量获取■■■■■■■■
//■■■■【帮派活动界面】■■■■活动内容获取■■■■■■■■

//■■■■【帮派活动界面】■■■■活动名称获取■■■■■■■■
function GetOrgActivityNumber()//活动数量
{
	return 9;
}
function GetOrgActivityName(%index)//活动名称
{
	//echo("活动名称获取====" @ %index);
	switch (%index)
	{
		case 0: return  $Get_Dialog_GeShi[31429] @ "每日工资</t>";
		case 1: return  $Get_Dialog_GeShi[31429] @ "帮派捐献</t>";
		case 2: return  $Get_Dialog_GeShi[31429] @ "秘咒除魔</t>";
		case 3: return  $Get_Dialog_GeShi[31429] @ "收集灵魄</t>";
		case 4: return  $Get_Dialog_GeShi[31429] @ "妖灵天宫</t>";
		case 5: return  $Get_Dialog_GeShi[31429] @ "封神秘境</t>";
		case 6: return  $Get_Dialog_GeShi[31429] @ "群英汇聚</t>";
		case 7: return  $Get_Dialog_GeShi[31429] @ "云罗镜</t>";
		case 8: return  $Get_Dialog_GeShi[31429] @ "帮会七重天</t>";
		case 9: return  $Get_Dialog_GeShi[31429] @ "封魔城攻城战</t>";
		case 10:return  $Get_Dialog_GeShi[31429] @ "领地战</t>";
	}
}

function GetOrgActivitysituation(%index)//完成情况
{
	%TitleA = $Get_Dialog_GeShi[31416];//已完成
	%TitleB = $Get_Dialog_GeShi[31429];//没完成
	%Player = GetPlayer();
	switch (%index)
	{
		case 0: %MaxVal = 1; %Val = GetSrc(%Player, 195);//"每日工资";
		case 1: %MaxVal = 1; %Val = GetSrc(%Player, 196);//"帮派捐献";
		case 2: %MaxVal = 1; %Val = GetSrc(%Player, 59);//"秘咒除魔";
		case 3: %MaxVal = 1; %Val = GetSrc(%Player, 197);//"收集灵魄";
		case 4: %MaxVal = 2; %Val = GetAct(%Player, 4102, 0) * 1;//"妖灵天宫";
		case 5: %MaxVal = 1; %Val = GetAct(%Player, 4103, 0) * 1;//"封神秘境";
		case 6: %MaxVal = 1; %Val = GetSrc(%Player, 3);//"群英汇聚";
		case 7: %MaxVal = 4; %Val = GetSrc(%Player, 191) + GetSrc(%Player, 192) + GetSrc(%Player, 193) + GetSrc(%Player, 194);//"云罗镜";
		case 8: //"帮会七重天";
			%MaxVal = 7;
			%Act0 = GetAct(%Player, 4104, 0) * 1;
			if (%Act0 == 0)
				%Val = 0;
			for (%i = 1; %i<= 9; %i++)
			{
				if (!CheckBit(%num, %bit))
				{
					%Record = %i - 1;
					break;
				}
			}
			%Val = %Record;
		case 9: //"封魔城攻城战";
		case 10://"领地战";
	}
	//echo("%Val ===" @ %Val @ "     %MaxVal===" @ %MaxVal);
	if (%index <= 7)
	{
		if (%MaxVal == %Val)
			%Txt = %TitleA @ "已完成</t>";
		else
			%Txt = %TitleB @ "已完成：" @ %Val @ "/" @ %MaxVal @ "</t>";
	}
	else if (%index == 8)
	{
		%LocalWeek = GetLocalWeek();	//判断开启星期
		if (%LocalWeek == 0 || %LocalWeek == 6)
		{
			if (%MaxVal == %Val)
				%Txt = %TitleA @ "已完成</t>";
			else
				%Txt = %TitleB @ "已完成：" @ %Val @ "/" @ %MaxVal @ "</t>";
		}
		else
			%Txt = %TitleB @ "周末开放</t>";
	}
	else
	{
		if (%MaxVal == %Val)
			%Txt = %TitleA @ "已完成</t>";
		else
			%Txt = %TitleB @ "已完成：" @ %Val @ "/" @ %MaxVal @ "</t>";
	}
	//echo("活动进度获取====" @ %index @ "   " @ %Txt);
	return %Txt;
}
//■■■■【帮派活动界面】■■■■活动名称获取■■■■■■■■



//■■■■【帮派活动界面】■■■■活动内容获取■■■■■■■■
function KLJFactionActivityTiTleButtonCommand(%index)
{
	%Player = GetPlayer();
	$NowFactionActivityButtonRecord = %index;
	%GeShi = 31403;

	KLJFactionActivityJoinBtn.Setvisible(0);
	switch (%index)
	{
		case 0: //"每日工资";
			%Text[0] =
				"<t>每天可在此领取一次帮派工资。</t><b/><b/>" @
				"<t>帮派工资的数额受以下数据影响：</t><b/>" @
				"<t>  1、您所在的帮派等级</t><b/>" @
				"<t>  2、在帮派里的职位</t><b/>" @
				"<t>  3、角色等级</t><b/>" @
				"<t>  4、上周的帮派贡献值</t><b/><b/>";

			%Exp = $Get_Dialog_GeShi[%GeShi] @ "经验奖励：</t>" @ "<t>50000</t><b/>";
			%Money = $Get_Dialog_GeShi[%GeShi] @ "金钱奖励：</t>" @ ChangeMoneyText(10000) @ "<b/>";
			%HueYue = $Get_Dialog_GeShi[%GeShi] @ "帮派活跃：</t>" @ "<t>20</t><b/>";

			%Player.ClearMissionItem(%index);

			%Player.AddItemToMission(%index, 1, 105100262, 1);
			%Player.AddItemToMission(%index, 1, 105105303, 1);
			%Player.AddItemToMission(%index, 1, 105105304, 1);
			%Player.AddItemToMission(%index, 1, 105180070, 1);
			%Player.AddItemToMission(%index, 1, 105180071, 1);
			%Player.AddItemToMission(%index, 1, 105180072, 1);
			%Player.AddItemToMission(%index, 1, 105180090, 1);
			%Player.AddItemToMission(%index, 1, 105180091, 1);
			%Player.AddItemToMission(%index, 1, 105180092, 1);
			%Text = $Get_Dialog_GeShi[%GeShi] @ "有几率获得以下物品：</t><b/>" @ GetFixedMissionItemText(%index) @ "<b/><b/>";
			%Text[1] = %Exp @ %Money @ %HueYue @ %Text;

			%Text[2] = "";
			if (GetSrc(%Player, 195) == 0)
			{
				KLJFactionActivityJoinBtn.Setvisible(1);
				KLJFactionActivityJoinBtn.settext("领取工资");
				KLJFactionActivityJoinBtn.Command = "JoinKLJFactionActivity(" @ %index @ ");";
			}
			else
				KLJFactionActivityJoinBtn.Setvisible(0);
		case 1: //"帮派捐献";
			%Text[0] =
				"<t>每天的第一次帮派捐献可获得此奖励。</t><b/><b/>" @
				"<t>该奖励受以下数据影响：</t><b/>" @
				"<t>  1、您所在的帮派等级</t><b/>" @
				"<t>  2、在帮派里的职位</t><b/>" @
				"<t>  3、角色等级</t><b/><b/>";

			%Exp = $Get_Dialog_GeShi[%GeShi] @ "经验奖励：</t>" @ "<t>50000</t><b/>";
			%HueYue = $Get_Dialog_GeShi[%GeShi] @ "帮派活跃：</t>" @ "<t>20</t><b/>";
			%ItemText = "";

			%Text[1] = %Exp @ %Money @ %HueYue @ %ItemText;

			%Text[2] = "<t>前往 </t>"  @ Getfindpath(410010107, 0, 0, 31214) @ "<t> 参与帮派捐献</t><b/>";
		case 2: //"秘咒除魔";
			%Text[0] = 
				"<t>妖魔肆虐神州，大势恶化，时不待我，城主大人特颁下凡是消灭妖魔头领者，可获得天材地宝提升修为！</t><b/><b/>" @
				"<t>五行灵魔法力滔天，单人战之，恐陷久战之苦，不妨寻上几个道友，联手除魔。</t><b/>";

			%Level = %Player.GetLevel();
			if (%Level <= 45) %Exp= 60000;
			else if (%Level <= 60) %Exp= 99200;
			else if (%Level <= 75) %Exp= 154400;
			else if (%Level <= 90) %Exp= 230400;
			else if (%Level <= 100)%Exp= 331200;
			%Exp = $Get_Dialog_GeShi[%GeShi] @ "经验奖励：</t>" @ %Exp @ "<b/>";
			%Money = $Get_Dialog_GeShi[%GeShi] @ "金钱奖励：</t>" @ ChangeMoneyText(10000) @ "<b/>";
			%HueYue = $Get_Dialog_GeShi[%GeShi] @ "帮派活跃：</t>" @ "<t>30</t><b/>";
			%ItemText = "";

			%Text[1] = %Exp @ %Money @ %HueYue @ %ItemText;

			%Text[2] = "<t>前往 </t>"  @ Getfindpath(410010107, 0, 0, 31214) @ "<t> 领取任务</t><b/>";
		case 3: //"收集灵魄";
			%Text[0] =
				"<t>妖魔肆虐，凡我修士，人人皆要以除魔为己任！</t><b/><b/>" @
				"<t>斩妖除魔，收集妖魔灵魄为证。</t><b/>";

			%Level = %Player.GetLevel();
			if (%Level <= 45) %Exp= 60000;
			else if (%Level <= 60) %Exp= 99200;
			else if (%Level <= 75) %Exp= 154400;
			else if (%Level <= 90) %Exp= 230400;
			else if (%Level <= 100)%Exp= 331200;
			%Exp = $Get_Dialog_GeShi[%GeShi] @ "经验奖励：</t>" @ %Exp @ "<b/>";
			%Money = $Get_Dialog_GeShi[%GeShi] @ "金钱奖励：</t>" @ ChangeMoneyText(10000) @ "<b/>";
			%HueYue = $Get_Dialog_GeShi[%GeShi] @ "帮派活跃：</t>" @ "<t>30</t><b/>";
			%ItemText = "";

			%Text[1] = %Exp @ %Money @ %HueYue @ %ItemText;

			%Text[2] = "<t> 前往 </t>"  @ Getfindpath(410010107, 0, 0, 31214) @ "<t> 领取任务</t><b/>";
		case 4: //"妖灵天宫";
			%Text[0] =
				"<t>暂未开放</t><b/>";
		case 5: //"封神秘境";
			%Level = %Player.GetLevel();
			%Level = mfloor(%Level / 10);
			if (%Level < 40)
				%level = 40;
			switch (%level)
			{
			case 40:%itemid = 105100273;//紫色装备(40 - 49级)
			case 40:%itemid = 105100275;//紫色装备(50 - 59级)
			case 40:%itemid = 105100277;//紫色装备(60 - 69级)
			case 40:%itemid = 105100279;//紫色装备(70 - 79级)
			case 40:%itemid = 105100281;//紫色装备(80 - 89级)
			case 40:%itemid = 105100283;//紫色装备(90 - 99级)
			default:%itemid = 1051002831;//
			}
			%Text[0] =
				"<t>封神演义登云台，花落诸门到谁家。35级以上修士组建3人以上队伍，与昆仑城的天师对话即可进入封神秘境，击杀副本内怪物有几率获得紫色装备。</t><b/>" @	
				"<t>全副本有71只普通怪物，8只精英怪，1个首领怪。</t><b/>" @ 
				"<t>精英怪物的掉率是普通怪物的五倍，首领必定掉落相当于队伍人数的紫装。</t><b/>";

			%HueYue = $Get_Dialog_GeShi[%GeShi] @ "帮派活跃：</t>" @ "<t>100</t><b/>";
			%ItemText = "";
			%Player.ClearMissionItem(%index);
			%Player.AddItemToMission(%index, 1, %itemid, 1);
			%ItemText = GetFixedMissionItemText(%index) @ "<b/><b/>";
			%Text[1] = %HueYue @ %ItemText;

			%Text[2] =
				"<t>点击打开</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"closestrategywndgui();OpenOrCloseActivityWnd();CreateActivityByType(2);\",\"" @ $Get_Dialog_GeShi[31214] @ "活动大全" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>可查看详细信息</t><b/>" @
				"<t>前往 </t>"  @ Getfindpath(413180001, 0, 0, 31214) @ "<t> 参加活动</t><b/>";
		case 6: //"群英汇聚";
			%Text[0] =
				"<t>夕阳西下时，帮主将在昆仑召唤熊熊的图腾，众修士环绕图腾而坐，分享今日收货，其乐融融，修为快速增长。</t><b/>" @
				"<t>各大帮主，可携带帮众前去挑战云罗教主，战胜教主后可获得教主宝藏。</t><b/>";
			
			%HueYue = $Get_Dialog_GeShi[%GeShi] @ "帮派活跃：</t>" @ "<t>20</t><b/>";
			%ItemText = "";
			%Player.ClearMissionItem(%index);

			%Player.AddItemToMission(%index, 1, 105100262, 1);
			%ItemText = GetFixedMissionItemText(%index) @ "<b/><b/>";

			%Text[1] = %HueYue @ %ItemText;

			%Text[2] =
				"<t>点击打开</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"closestrategywndgui();OpenOrCloseActivityWnd();CreateActivityByType(2);\",\"" @ $Get_Dialog_GeShi[31214] @ "活动大全" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>可查看详细奖励</t><b/>" @
				"<t>前往 </t>"  @ Getfindpath(810010107, 0, 0, 31214) @ "<t> 参加活动</t><b/>";

		case 7: //"云罗镜";
			%Text[0] =
				"<t>昆仑有一奇异空间，名为云罗境，内有神秘祭坛，可召唤异域强者降临。</t><b/>" @
				"<t>寻找帮主召唤帮派图腾，领取一份暖暖的图腾之力吧。</t><b/>";

			%Level = %Player.GetLevel();
			%Text[1] =
				$Get_Dialog_GeShi[31421] @ "教 主 宝藏</t>"  @ $Get_Dialog_GeShi[%GeShi] @ "  帮派活跃：</t>" @ 20 @ $Get_Dialog_GeShi[%GeShi] @ "  经验奖励：</t>" @ $Monster_Exp[%Level, 1] * 500 @ "<b/>" @
				$Get_Dialog_GeShi[31421] @ "左护法宝藏</t>"  @ $Get_Dialog_GeShi[%GeShi] @ "  帮派活跃：</t>" @ 10 @ $Get_Dialog_GeShi[%GeShi] @ "  经验奖励：</t>" @ $Monster_Exp[%Level, 1] * 100 @ "<b/>" @
				$Get_Dialog_GeShi[31421] @ "右护法宝藏</t>"  @ $Get_Dialog_GeShi[%GeShi] @ "  帮派活跃：</t>" @ 10 @ $Get_Dialog_GeShi[%GeShi] @ "  经验奖励：</t>" @ $Monster_Exp[%Level, 1] * 100 @ "<b/>" @
				$Get_Dialog_GeShi[31421] @ "长 老 宝藏</t>"  @ $Get_Dialog_GeShi[%GeShi] @ "  帮派活跃：</t>" @ 10 @ $Get_Dialog_GeShi[%GeShi] @ "  经验奖励：</t>" @ $Monster_Exp[%Level, 1] * 200 @ "<b/>";

			%Text[2] = 
				"<t>点击打开</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"closestrategywndgui();OpenOrCloseActivityWnd();CreateActivityByType(1);\",\"" @ $Get_Dialog_GeShi[31214] @ "活动大全" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>可查看详细奖励</t><b/>" @
				"<t>前往 </t>"  @ Getfindpath(410010107, 0, 0, 31214) @ "<t> 进入副本</t><b/>";

		case 8: //"帮会七重天";
			%Text[0] =
				"<t>暂未开放</t><b/>";
		case 9: //"封魔城攻城战";
		case 10://"领地战";
	}


	if (%Text[0] !$= "")
	{
		//echo("%Text[0]===" @ %Text[0]);
		FactionActivity_Bg_bmp.setvisible(1);
		FactionActivity_Purpose_text.setvisible(1);
		FactionActivity_Purpose_text.SetContent($Get_Dialog_GeShi[31401] @ %Text[0] @ "</t>");
	}
	else
	{
		FactionActivity_Bg_bmp.setvisible(0);
		FactionActivity_Purpose_text.setvisible(0);
	}
	if (%Text[1] !$= "")
	{
		//echo("%Text[1]===" @ %Text[1]);
		FactionActivity_Reward_bmp.setvisible(1);
		FactionActivity_Reward_text.setvisible(1);
		FactionActivity_Reward_text.SetContent($Get_Dialog_GeShi[31401] @ %Text[1] @ "</t>");
	}
	else
	{
		FactionActivity_Reward_bmp.setvisible(0);
		FactionActivity_Reward_text.setvisible(0);
	}
	if (%Text[2] !$= "")
	{
		//echo("%Text[2]===" @ %Text[2]);
		FactionActivity_Join_bmp.setvisible(1);
		FactionActivity_Join_text.setvisible(1);
		FactionActivity_Join_text.SetContent($Get_Dialog_GeShi[31401] @ %Text[2] @ "</t>");
	}
	else
	{
		FactionActivity_Join_bmp.setvisible(0);
		FactionActivity_Join_text.setvisible(0);
	}
}
//■■■■【帮派活动界面】■■■■活动内容获取■■■■■■■■

//■■■■【帮派活动界面】■■■■点击按钮触发■■■■■■■■
function JoinKLJFactionActivity(%index)
{
	putout("帮派活动界面 点击按钮触发 %index===" @ %index);
	switch (%index)
	{
		case 0: //"每日工资";
			if (GetSrc(GetPlayer(), 195) == 0)
				ClientOnSptAction(39, 0);//通讯服务端
			else
				SetScreenMessage("您已经领取过今日的帮派工资", $Color[2]);
		case 1: //"帮派捐献";
		case 2: //"秘咒除魔";
		case 3: //"收集灵魄";
		case 4: //"妖灵天宫";
		case 5: //"封神秘境";
		case 6: //"群英汇聚";
		case 7: //"云罗镜";
		case 8: //"帮会七重天";
		case 9: //"封魔城攻城战";
		case 10://"领地战";
	}
}
//■■■■【帮派活动界面】■■■■点击按钮触发■■■■■■■■
