

//■■■■■■■■■■■上线送惊喜活动■■■■■■■■■■■■■■■■■■■■
//■■■打开界面调用
//■■■界面属性
//■■■界面进度条显示
//■■■七日状态+进度条
//■■■超级大奖特效显示
//■■■任务描述显示
//■■■领取任务
//■■■领取奖励
//■■■七日目标－超级大奖
//■■■每日福利－超级大奖
//■■■最小化框显示
//■■■欢迎界面豆腐干显示
//■■■是否有奖励可领取

//■■■打开界面调用
function OpenOrCloseTargetWnd()
{
	if (!TodayGoalWnd.isvisible())
		UpdateSurprisePartyWnd(4);
	else
		TodayGoalWnd.SetVisible(0);
}
function UpdateSurprisePartyWnd(%State)
{
	//获取玩家player
	%Player = GetPlayer();

	//开启2个分页，并且调整位置
	TodayGoalWndGui_Tab1.setVisible(1);
	TodayGoalWndGui_Tab2.setVisible(0);
	TodayGoalWndGui_Tab1.setposition(7,38);
	TodayGoalWndGui_Tab2.setposition(110,38);

	if (%State != 3)
	{
		//打开主界面
		if (TodayGoalWnd.isVisible() == 0)
		{
			GameMainWndGui_Layer3.pushtoback(TodayGoalWnd);			//设置界面置顶
			TodayGoalWnd.SetVisible(1);													//设置显示上线送惊喜活动
		}
	}

	if (GetWord(%Player.GetActivity(1122),0) == 1)
	{
		TodayGoalWndGui_Tab1.setVisible(0);
		TodayGoalWndGui_Tab2.setposition(7,38);
		%State = $TodayGoalWnd_Pagination[%Player] = 2;
	}
	//如果点开分页
	else if (%State <= 2)
		$TodayGoalWnd_Pagination[%Player] = %State;
	//如果点击总开关
	else if ((%State == 4) && ($TodayGoalWnd_Pagination[%Player] == 0))
	{
		for (%In = 0; %In < 7; %In++)
		{
			%MidResult = DailyGoalWnd_fettle(%Mid,%In);
			if ((%MidResult == 5) || (%MidResult == 6))
				%MidAA++;
		}

		$TodayGoalWnd_Pagination[%Player] = (%MidAA < 7) ? 1 : 2;
		%State = $TodayGoalWnd_Pagination[%Player];


	}
	else
		%State = $TodayGoalWnd_Pagination[%Player];

	%State = $TodayGoalWnd_Pagination[%Player] = 1;

	//调用属性界面
	SurprisePartyWnd_TodayGoalWnd_unite(%State);

	//设置进度条界面
	if (%State == 1)
	{
		TodayGoalWnd_7_Days_Goal_Process.setVisible(true);
		DailyGoalWnd_Days_Goal_Process.setVisible(false);
		TodayGoalWndGui_Tab1.setStateOn(1);


		Getrewordbutton.setProfile("UPDownLineWndProfile_51");
		TodayGoalWnd_1_map.setBitmap("gameres/gui/images/calendar_seven_main");
	}
	else
	{
		TodayGoalWnd_7_Days_Goal_Process.setVisible(false);
		DailyGoalWnd_Days_Goal_Process.setVisible(true);
		TodayGoalWndGui_Tab2.setStateOn(1);

		Getrewordbutton.setProfile("UPDownLineWndProfile_5");
		TodayGoalWnd_1_map.setBitmap("gameres/gui/images/calendar_four_main");
	}
}
//■■■界面属性
function SurprisePartyWnd_TodayGoalWnd_unite(%State)
{
	//获取玩家player
	%Player = GetPlayer();

	//获得时间
	%Time = GetLocalTime();
	%Time = GetWord(%Time,1) @ GetWord(%Time,2);

	//与当前时间不符时，与服务器通讯
	if (GetWord(%Player.GetActivity(2002),0) < 8)
		if (GetWord(%Player.GetActivity(2002),1) !$= %Time)
			ClientOnSptAction(4,0);//设置可接

	//设置主界面豆腐干
	//CloseHelpDirectWnd(2);
	$OpenOrCloseUpLinePartyWnd_Trigger = 1;

	//设置界面文字
	OpenTodayGoalWnd_ListBox("",%State);

	//特效刷新
	DailyGoalWnd_GetSuperPrize_Effect();

	//进度状态
	TodayGoalWnd_Goal_Picture();	//今日状态+进度条
	DailyGoalWnd_Goal_Picture();	//七日状态+进度条

	//超级大奖
	if (%State == 1)
	{
		Getrewordbutton.command = "ClientOnSptAction(13, 1);";
		Getrewordbutton.SetActive((GetWord(%Player.GetActivity(1122),0)) ? 0 : 1);
	}
	else
	{
		Getrewordbutton.command = "ClientOnSptAction(13, 2);";
		Getrewordbutton.SetActive((GetWord(%Player.GetActivity(1123),0)) ? 0 : 1);
	}

	//豆腐干
	if (DailyGoalWnd_fettle($JRMB_Mission[0],0) == 4){ ShowHelpDirectByIndex(25); }
	if (DailyGoalWnd_fettle($JRMB_Mission[0],1) == 2){ ShowHelpDirectByIndex(26); }

	//最小化刷新
	Schedule(3000,0,"UpLine_PartyTurnOnBntWnd",%State);//更新最小化按钮
}

//获取任务的状态
function DailyGoalWnd_fettle(%Mid,%In)
{
	%Player = GetPlayer();
	%Mid = $JRMB_Mission[%In];
	%KKK = GetWord(%Player.GetActivity(2002),0);

	//目标是否开启
	if (%Mid >= 32520)
	{
		//判断是否到达等级
		%Level = %Player.GetLevel();
		if (GetMissionData(%Mid,$Mission_Data_LvA) > %Level)
			return 7;

		//是否已经完成
		if (GetWord(%Player.GetActivity($JRMB_Achieve[1110 + %In]),0) == 1)
			return 5;
	}

	//是否完成任务
	if (%Player.IsFinishedMission(%Mid))
		return 5;

	//已接任务时
	if (%Player.IsAcceptedMission(%Mid))
	{
		if (%Player.GetMissionFlag(%Mid,1300) >= %Player.GetMissionFlag(%Mid,1200))
			return 4;//任务-领取奖励
		else
			return 3;//任务-进行中
	}
	else if (%Mid < 32520)
	{
		if (%KKK < (%In+1))return 1;//任务-未开启
		else if (%KKK >(%In+1))return 6;//任务-过期
		else return 2;	//任务-可领取
	}
	else return 2;	//任务-可领取
}

//■■■七日状态+进度条
function TodayGoalWnd_Goal_Picture()
{
	%Player = GetPlayer();

	for (%i = 0; %i < 7; %i++)
	{
		//获取任务Id
		%Mid = $JRMB_Mission[%i];
		//获取任务状态
		%AAA = DailyGoalWnd_fettle(%Mid,%i);

		//设置进度条显示
		("TodayGoalWnd_Goal_"@%i+1).setVisible((%AAA > 1) ? 1 : 0);

		//设置图片编号
		if (%AAA == 3){ %Us = "397,462"; %Vs = "122,142"; }	//进行中
		else if (%AAA == 4){ %Us = "397,462"; %Vs = "122,142"; }	//进行中
		else if (%AAA == 5){ %Us = "397,462"; %Vs = "162,182"; }	//完成
		else if (%AAA == 6){ %Us = "397,462"; %Vs = "102,122"; } //已过期
		else { %Picture_Name = 0; } //初始化

		//设置状态显示
		if (%Picture_Name $= 0)
			("TodayGoalWnd_Goal_"@%i+1@"_State").setVisible(0);	//隐藏控件
		else
		{
			//显示控件
			("TodayGoalWnd_Goal_"@%i+1@"_State").setVisible(1);
			("TodayGoalWnd_Goal_"@%i+1@"_State").setCtrlImageUVs(%Us,%Vs);
		}
	}
}

//■■■今日状态+进度条
function DailyGoalWnd_Goal_Picture()
{
	%Player = GetPlayer();

	for (%i = 7; %i < 16; %i++)
	{
		//获取任务Id
		%Mid = $JRMB_Mission[%i];

		//获取任务状态
		if (DailyGoalWnd_fettle(%Mid,%i) == 5)
			%FFF++;
	}

	for (%i = 1; %i < 5; %i++)
	{
		if (%i <= %FFF)
		{
			("DailyGoalWnd_Goal_"@%i@"").setVisible(1);
			("DailyGoalWnd_Goal_"@%i@"_State").setVisible(1);
			("DailyGoalWnd_Goal_"@%i@"_State").setBitmap("Gameres/gui/images/GUIWindow75_1_008");
		}
		else
		{
			("DailyGoalWnd_Goal_"@%i@"_State").setVisible(0);
			("DailyGoalWnd_Goal_"@%i@"").setVisible(0);
		}
	}
}

//■■■超级大奖特效显示
function DailyGoalWnd_GetSuperPrize_Effect()
{
	%Player = GetPlayer();
	if (GetWord(%Player.GetActivity(1122),0) == 0)
	{
		for (%i = 0; %i < 7; %i++)
		{
			//获取任务Id
			%Mid = $JRMB_Mission[%i];
			//获取任务状态
			%AAA = DailyGoalWnd_fettle(%Mid,%i);

			//获取是否有进行中任务
			if ((%AAA == 3) || (%AAA == 4))
			{
				%Atelic++;
				break;
			}

			//获取是否完成
			if (%AAA == 5)
				%KKK++;
		}

		//完成大于1并且没有进行中任务则显示特效
		%ine = ((%KKK > 1) && (%Atelic == 0)) ? 1 : 0;
		TodayGoalWnd_GetSuperPrize_Effect.SetVisible(%ine);
	}
	else
		TodayGoalWnd_GetSuperPrize_Effect.SetVisible(0);

	//特效-今日
	if (GetWord(%Player.GetActivity(1123),0) == 0)
	{
		for (%i = 7; %i < 16; %i++)
		{
			//获取任务Id
			%Mid = $JRMB_Mission[%i];
			//获取任务状态
			%AAA = DailyGoalWnd_fettle(%Mid,%i);
			//如果完成数量大于5
			if (%AAA == 5)
				%MMM++;
		}

		//显示特效
		%ine = (%MMM >= 4) ? 1 : 0;
		DailyGoalWnd_GetSuperPrize_Effect.SetVisible(%ine);
	}
	else
		DailyGoalWnd_GetSuperPrize_Effect.SetVisible(0);
}

//■■■任务描述显示
function SurprisePartyWnd_ListBox_Choose(%State)
{
	%Player = GetPlayer();
	%list = TodayGoalWnd_ListBox.GetSelectedId();

	%Mid = $JRMB_Mission[%list];	//获取任务编号
	ClientOnSptAction(9,%list);
	if (%list < 7)
		%Open[1] = $Icon[92] @ "<b/><t>角色进入《昆仑决》的</t>" @ $Get_Dialog_GeShi[31412] @"第" @ %list + 1 @ "天</t><t>自动开启</t><b/><b/>";		//"任务开启";

	%Open[2] = $Icon[98] @ "<b/>" @ eval("Mission" @ %Mid @ "Dialog" @ "(%Npc, %Player, %Mid, 10001);") @ "<b/>";		//"任务目标";
	%Open[3] = $Icon[97] @ "<b/>" @ GetMissionHortation(%Mid,0);	//任务奖励

	TodayGoalWnd_Tips.SetContent(%Open[1] @ %Open[2] @ %Open[3]);
}

function SurprisePartyWnd_ListBox_Choose_ultimate(%Mid)
{
	//获取Player
	%Player = GetPlayer();

	//元宝奖励
	if (%Mid >= $JRMB_Mission[7]){ %MissionData_Gold = 20; }
	if (%MissionData_Gold != 0){ %Gold  = $Get_Dialog_GeShi[31412] @ " 绑定元宝： </t><t>[ " @ %MissionData_Gold  @ " ]</t><b/>"; }
	else{ %Gold  = ""; }

	//额外奖励
	if (%Mid == 32527)
		%Open[4] = SurprisePartyWnd_ListBox_ChooseA(%Player);
	else if (%Mid == 32520)
		%Open[4] = SurprisePartyWnd_ListBox_ChooseB(%Player);
	else if (%Mid == 32522)
		%Open[4] = SurprisePartyWnd_ListBox_ChooseC(%Player);
	else if (%Mid == 32525)
		%Open[4] = SurprisePartyWnd_ListBox_ChooseD(%Player);
	else if (%Mid == 32528)
		%Open[4] = SurprisePartyWnd_ListBox_ChooseE(%Player);

	return %Open[4];
}

function SurprisePartyWnd_ListBox_ChooseA(%Player)
{
	%leve = %Player.GetLevel();				//玩家等级
	%ExpA = $Monster_Exp[%leve,1];		//当前等级怪物经验

	%Mid = 32527;
	%MF[1] = %Player.GetMissionFlag(%Mid,10000);
	%MF[2] = %Player.GetMissionFlag(%Mid,10001);
	%MF[3] = %Player.GetMissionFlag(%Mid,10002);

	%Status[1]  = "平局";
	%Status[2]  = "失败";
	%Status[3]  = "胜利";
	%Status[0] = "未完成";
	// %status -1,1,0, 0表示平局，2表示胜利，1表示失败，%type是副本类型
	%ExpA = 100000;

	%OpenA = $Get_Dialog_GeShi[31406] @ " 根据胜负奖励不同经验：</t><b/>";
	%OpenB = $Get_Dialog_GeShi[31412] @ " 胜利场次1经验：</t><t> [ " @ 3*%ExpA@ " ]（" @ %Status[%MF[1]] @ "）</t><b/>";
	%OpenC = $Get_Dialog_GeShi[31412] @ " 胜利场次2经验：</t><t> [ " @ 6*%ExpA @ " ]（" @ %Status[%MF[2]] @ "）</t><b/>";
	%OpenD = $Get_Dialog_GeShi[31412] @ " 胜利场次3经验：</t><t> [ " @ 9*%ExpA @ " ]（" @ %Status[%MF[3]] @ "）</t>";

	%Open[4] = %OpenA @ %OpenB @ %OpenC @ %OpenD;			//"任务奖励";

	if (DailyGoalWnd_fettle(%Mid,14) == 5)
		%Open[4] = "";

	return %Open[4];
}

function SurprisePartyWnd_ListBox_ChooseB(%Player)
{
	%OpenC = $Get_Dialog_GeShi[31406] @ "【注：用100元宝可兑换200积分，但每天只可以兑换一次】</t>";

	%Open[4] = "<b/>" @ %OpenA @ %OpenB @ %OpenC;			//"任务奖励";

	return %Open[4];
}

function SurprisePartyWnd_ListBox_ChooseC(%Player)
{
	%OpenB = $Get_Dialog_GeShi[31412] @ " 完成此任务须开启势力模式，击败不同势力的玩家不会增加善恶值。</t><b/>";
	%OpenC = $Get_Dialog_GeShi[31406] @ "【注：10分钟内击败同一名敌对玩家不计数】</t>";

	%Open[4] = "<b/>" @ %OpenA @ %OpenB @ %OpenC;			//"任务奖励";

	return %Open[4];
}

function SurprisePartyWnd_ListBox_ChooseD(%Player)
{
	if (%Player.GetFamily() < 3)
	{
		%level = %Player.GetLevel();
		if (%level < 30){ %NpcID1 = 401101042; %DiMing = "蜀中"; }
		else if (%level < 40){ %NpcID1 = 401102034; %DiMing = "扬州"; }
		else if (%level < 50){ %NpcID1 = 401103051; %DiMing = "太原"; }
		else if (%level < 60){ %NpcID1 = 401104027; %DiMing = "敦煌"; }
		else if (%level < 70){ %NpcID1 = 401105030; %DiMing = "辽东"; }
		else{ %NpcID1 = 401106027; %DiMing = "突厥"; }
	}
	else
	{
		%level = %Player.GetLevel();
		if (%level < 30){ %NpcID1 = 401101043; %DiMing = "蜀中"; }
		else if (%level < 40){ %NpcID1 = 401102035; %DiMing = "扬州"; }
		else if (%level < 50){ %NpcID1 = 401103052; %DiMing = "太原"; }
		else if (%level < 60){ %NpcID1 = 401104028; %DiMing = "敦煌"; }
		else if (%level < 70){ %NpcID1 = 401105031; %DiMing = "辽东"; }
		else{ %NpcID1 = 401106028; %DiMing = "突厥"; }
	}

	%OpenB = $Get_Dialog_GeShi[31412] @ "◆参与方式：</t><b/>" @
		"<t>"@%DiMing@"</t>"@"<t><c cid='" @ Get_TraceButton() @ "' cmd='\"findpath("@%NpcID1@");\",\"" @ $Get_Dialog_GeShi[31414] @ GetNpcData(%NpcID1,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @"<t>（点击NPC前往接取任务）</t><b/>";
	return "<b/>" @ %OpenA @ %OpenB @ %OpenC;			//"任务奖励";
}

function SurprisePartyWnd_ListBox_ChooseE(%Player)
{
	%Player.ClearMissionItem(10030);	//清除之前的物品显示
	%Player.ClearMissionItem(10031);	//清除之前的物品显示

	//媒体礼包
	%Player.AddItemToMission(10030,1,105103065,1);	//50点积分卡
	%Player.AddItemToMission(10030,1,113010081,1);	//50万经验卷轴
	%Player.AddItemToMission(10030,1,105028002,1);	//双倍经验丹
	%Player.AddItemToMission(10030,1,105100028,1);	//抽奖次数

	//幸运大礼包
	%Player.AddItemToMission(10031,1,105103030,1);	//500000金币兑换券
	%Player.AddItemToMission(10031,1,105103070,1);	//200点活跃积分卡
	%Player.AddItemToMission(10031,1,119011070,1);	//玄冰战虎

	%Txt[1] = $Get_Dialog_GeShi[31412] @ "『媒体礼包』奖励：</t><b/>" @ GetFixedMissionItemText(10030) @ "<b/>";
	%Txt[2] = $Get_Dialog_GeShi[31412] @ "『幸运大礼包』奖励：</t><b/>" @ GetFixedMissionItemText(10031);

	return %Txt[1] @ %Txt[2];
}
//■■■领取任务
function SurprisePartyWnd_AcceptTask_Accept(%FenLei)
{
	%Player = GetPlayer();
	//CloseHelpDirectWnd(4);

	%list = ("TodayGoalWnd_ListBox" @ %FenLei).GetSelectedId();
	%AAA = DailyGoalWnd_fettle($JRMB_Mission[%list],%list);
	if (%list !$= "")
	{
		if (%AAA == 1){ %txt = "该任务还未开启。"; }
		else if (%AAA == 2){ %txt = "可接"; }
		else if (%AAA == 3){ %txt = "您已经领取了该任务！"; }
		else if (%AAA == 4){ %txt = "完成"; }
		else if (%AAA == 5){ %txt = "您已经完成该任务！"; }
		else if (%AAA == 6){ %txt = "该任务已过期，请选择其它任务领取吧！"; }

		if (%txt $= "可接"){ ClientOnSptAction(5,%list); }
		else if (%txt $= "完成"){ ClientOnSptAction(6,%list); }
		else { SetScreenMessage(%txt,$Color[2]); }

		//错误检查
		if ((%AAA == 0) && (%list[1] < 0))
			ClientOnSptAction(7,%AAA @ %list);
	}
}

//■■■最小化框显示
function UpLine_PartyTurnOnBntWnd(%State)
{
	if (UpLine_A_PartyTurnOnBntWnd(2) > 0)
		UpLinePartyTurnOnBntWnd.setvisible(1);
	else
		UpLinePartyTurnOnBntWnd.setvisible(0);

	OpenOrCloseFestivity_use();
}

//获取是否有未接或未完成等
function UpLine_A_PartyTurnOnBntWnd(%Activity)
{
	%Player = GetPlayer();
	for (%i = 0; %i < 6; %i++)
	{
		//获取任务编号
		%Mid = 32510 + %i;
		//获取任务状态
		%AAA = DailyGoalWnd_fettle(%Mid,%i);
		if ((%AAA == 2) || (%AAA == %Activity) || (%AAA == 4))
			return 1;
	}
	return 0;
}



//■■■欢迎进入昆仑决世界
function OpenOrCloseUpLinePartyWnd_Trigger(%State)
{
	%Player = GetPlayer();

	//设置免费玩家乐园
	%AAA = GetWord(%Player.GetActivity(2002),0);
	OpenTodayGoalWnd_ListBox(1,2);

	%Tab1 = "<t f='微软雅黑' m='0' n='12' c='0xffffffff' o='0x010101ff'>";

	//当前活跃值
	%Activity2241[0] = GetWord(%Player.GetActivity(2241),0);
	%Activity2241[0] = (%Activity2241[0] == 0) ? 0 : %Activity2241[0];

	WelcomePartyWnd_Text_Activity.setcontent(%Tab1 @ %Activity2241[0] @ "点</t>");
	WelcomePartyWnd_Text_Activity.setposition(140,114);

	//已登陆天数
	WelcomePartyWnd_Text_day.setcontent(%Tab1 @ %Player.GetSignInMCount() @ "天</t>");
	WelcomePartyWnd_Text_day.setposition(166,241);

	for (%i = 0; %i < 4; %i++)
	{
		%Activity = 2246;

		//每日福利奖励显示1
		%Player.ClearMissionItem(10160 + %i); %Player.AddItemToMission(10160 + %i,1,$MeiYueFuLi_Item[1 + %i],1);
		("GetWelAwardBtn_" @ 1 + %i @ "_3").setcontent(GetFixedMissionItemText(10160 + %i));

		//每日福利奖励显示2
		%getWelAwardNeedGoal_Tab = "<t f='微软雅黑' m='0' n='11' c='0xafa35eff'>";
		("GetWelAwardNeedGoal_" @ 1 + %i).setcontent(%getWelAwardNeedGoal_Tab @ "登陆" @ $MeiYueFuLi_HuoYueDu[1 + %i] @ "天礼包</t>");

		//设置领取按钮触发
		("GetWelAwardBtn_" @ %i + 1 @ "_1").command = "ClientOnSptAction(115, " @ %i @ ");";

		//已领取礼包
		if (GetWord(%Player.GetActivity(%Activity + %i),0) > 0)
		{
			("GetWelAwardBtn_" @ %i + 1 @ "_2").setVisible(1);	//开启【已领取】
			("GetWelAwardBtn_" @ %i + 1 @ "_1").setVisible(0);	//开启【领取】
		}

		//不可领取礼包
		else if (%Player.GetSignInMCount() < $MeiYueFuLi_HuoYueDu[%i + 1])
		{
			("GetWelAwardBtn_" @ %i + 1 @ "_2").setVisible(0);	//开启【已领取】
			("GetWelAwardBtn_" @ %i + 1 @ "_1").setVisible(1);	//关闭【领取】
			("GetWelAwardBtn_" @ %i + 1 @ "_1").SetActive(0);		//灰色【领取】
		}

		//可以领取礼包
		else
		{
			("GetWelAwardBtn_" @ %i + 1 @ "_2").setVisible(0);	//开启【已领取】
			("GetWelAwardBtn_" @ %i + 1 @ "_1").setVisible(1);	//开启【领取】
			("GetWelAwardBtn_" @ %i + 1 @ "_1").SetActive(1);		//亮色【领取】
		}
	}

	//离线经验
	%ActivityTab1 = "<t f='微软雅黑' b='0' m='0' n='18' c='0xffffffff' o='0x010101ff'>";
	%EncourageExp = %Player.GetEncourageExp();
	UpLinePartyWnd_Text_Experience.setcontent(%ActivityTab1 @ %EncourageExp @ "</t>");
	UpLinePartyMianFei3.command = "DrawEncourageExp();";

	//双倍时间
	%ShuangBei_A = %Player.GetActivity(2000);	//读取赠送的双倍时间值
	%ShiJian_A = GetWord(%ShuangBei_A,0) * 1;		//读取赠送的双倍时间值

	if (%ShiJian_A <= 0)
		%ShiJian_A = 0;

	if (%ShiJian_A >= 300)
		%ShiJian_A = 300;

	//设置剩余时间
	UpLinePartyWnd_Text_Time.setcontent(%Tab1 @ 300 - %ShiJian_A @ "分钟" @ "</t>");
	UpLinePartyWnd_Text_Time.setposition(180,146);

	UpLinePartyMianFei4.command = "findpath(400001060);";
}

function LinePartyWndMessage(%State)
{
	if (%State == 11)%Txt = "完成4个【每日福利】任务即可领取【每日工资】。";
	else if (%State == 12)%Txt = "您已领取【工资奖励】。";
	else if (%State == 21)%Txt = "完成【每日福利】任务即可获得活跃积分。";
	else if (%State == 22)%Txt = "您已领取【活跃积分奖励】。";
	SetScreenMessage(%Txt,$Color[5]);
}
//■■■■■■■■■■■上线送惊喜活动■■■■■■■■■■■■■■■■■■■■

function OpenTodayGoalWnd_ListBox(%FenLei,%State)
{
	//获取玩家Player
	%Player = GetPlayer();

	//获得时间
	%Time = GetLocalTime();
	%Time = GetWord(%Time,1) @ GetWord(%Time,2);

	//与当前时间不符时，与服务器通讯
	if (GetWord(%Player.GetActivity(2002),0) < 8)
		if (GetWord(%Player.GetActivity(2002),1) !$= %Time)
			ClientOnSptAction(4,0);//设置可接

	//获得时间
	%Time = GetLocalTime();
	%Time = GetWord(%Time,1) @ GetWord(%Time,2);

	//初始化界面
	("TodayGoalWnd_ListBox" @ %FenLei).clearitems();
	%A = 0; %II= 0;

	if (%FenLei $= "")
	{
		%KongGe = "   ";
		TodayGoalWnd_Tips.setcontent("");
		if (%State == 1)%Txt = "完成任务越多，超级大奖奖励丰厚";
		else if (%State == 2)%Txt = "完成4个【每日福利】任务即可领取每日工资";
		TodayGoalWndGuiTimeText.setcontent("<t f='黑体' m='0' v='0' n='14' c='0x00ff4eff'>" @ %Txt @ "</t>");
	}

	%Tab1 = "<t f='楷体_GB2312' m='0' n='16' c='0xffffffff'>";//白色正文-其它
	%Tab2 = "<t f='楷体_GB2312' m='0' n='16' c='0xf3d300ff'>";//黄色正文-可接
	%Tab3 = "<t f='楷体_GB2312' m='0' n='16' c='0x00ff4eff'>";//绿色正文-可交

	%tinct[1] = $Get_Dialog_GeShi[31491];	%Icon[1] = $Icon[30];	//未开启
	%tinct[2]	= $Get_Dialog_GeShi[31491];	%Icon[2] = $Icon[31];	//领取任务
	%tinct[3]	= $Get_Dialog_GeShi[31491];	%Icon[3] = $Icon[32];	//进行中
	%tinct[4]	= $Get_Dialog_GeShi[31491];	%Icon[4] = $Icon[33];	//领取奖励
	%tinct[5]	= $Get_Dialog_GeShi[31493];	%Icon[5] = $Icon[34];	//任务完成
	%tinct[6]	= $Get_Dialog_GeShi[31491];	%Icon[6] = $Icon[35];	//任务过期
	%tinct[7] = $Get_Dialog_GeShi[31491];	%Icon[7] = $Icon[30];	//未开启

	%txt[0] = "『第1日』初出茅庐";	%txt[7] = "每日『福星高照』";
	%txt[1] = "『第2日』涉足江湖";	%txt[8] = "每日『讨伐令』";
	%txt[2] = "『第3日』混个脸熟";	%txt[9] = "每日『击败敌对势力』";
	%txt[3] = "『第4日』小有名气";	%txt[10] = "每日『循环任务』";
	%txt[4] = "『第5日』左右逢源";	%txt[11] = "每日『福神的祝福』";
	%txt[5] = "『第6日』声名鹊起";	%txt[12] = "每日『巧夺粮草』";
	%txt[6] = "『第7日』名动江湖";	%txt[13] = "每日『帮派任务』";
	%txt[14] = "每日『竞技场』";
	%txt[15] = "每日『媒体礼包』";
	if (%State == 1)
	{
		%A = 0; %II = 7;
	}
	else
	{
		%A = 7; %II = 16;
	}

	for (%i = %A; %i < %II; %i++)
	{
		//获取任务Id
		%Mid = $JRMB_Mission[%i];

		//获取任务状态
		%AAA = DailyGoalWnd_fettle(%Mid,%i);

		//任务名颜色设定
		if (%AAA == 2) %Tab = %Tab2;
		else if (%AAA == 4) %Tab = %Tab3;
		else %Tab = %Tab1;

		//颜色 + 任务名
		%KKK[2] = %Tab @ %txt[%i];

		//解析按钮
		%button = "</t><c cid='" @ Get_TraceButton() @ "' cmd='\"SurprisePartyWnd_AcceptTask_Accept("@ %FenLei @");\",\""@%Icon[%AAA]@"</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' /><t>";

		("TodayGoalWnd_ListBox" @ %FenLei).AddItem(%KKK[2] @ "</t>"TAB"<t>" @ %KongGe @ %button @ "</t>",%i);
		if (%FenLei $= "")
			("TodayGoalWnd_ListBox" @ %FenLei).SetCommand("SurprisePartyWnd_ListBox_Choose("@%State@");",%i);
	}
}

function EveryDayGoalWnd()
{
	%Player = GetPlayer();

	%PositionX = EveryDayGoalWndListBox_Scroll.getScrollPositionX();
	%PositionY = EveryDayGoalWndListBox_Scroll.getScrollPositionY();

	//设置打开界面
	//	EveryDayGoalWnd.setVisible(1);

	//清空条目
	EveryDayGoalWnd_ListBox.clearitems();

	%Tab2 = "<t f='微软雅黑' m='0' n='11' v='0' c='0xffffffff' u='0x352d13ff' >";
	%Tab3 = "<t f='微软雅黑' m='0' n='11' v='0' c='0xffffffff' >";
	%Tab4 = "<t f='微软雅黑' m='0' n='11' v='0' c='0x00ff4eff' u='0x423818ff' >";
	%Tab5 = "<t f='微软雅黑' m='0' n='11' v='0' c='0x00ff4eff' >";

	//活跃度兑换

	EveryDayNeedGoal_2.setcontent(%EveryDayNeedGoal_Tab @ " 达到" @ $MeiRiLiLian_HuoYueDu[2] @ "点活跃度</t>");
	EveryDayNeedGoal_3.setcontent(%EveryDayNeedGoal_Tab @ " 达到" @ $MeiRiLiLian_HuoYueDu[3] @ "点活跃度</t>");
	EveryDayNeedGoal_4.setcontent(%EveryDayNeedGoal_Tab @ " 达到" @ $MeiRiLiLian_HuoYueDu[4] @ "点活跃度</t>");

	for (%i = 1; %i <= 25; %i++)
	{
		if ((%i == 7) && (%i[26] == 0))
		{
			%i = 26;
			%i[26] = 1;
		}

		if (($EveryDayGoal_Hide[GetWord($EveryDayGoal[0,%i],1)] == 1) && (GetWord($EveryDayGoal[0,%i],0) == 1))
			continue;

		%Tab1[1] = "<t f='微软雅黑' m='0' n='12' v='0' c='0x00b0f0ff' u='0x423818ff' >";
		%Tab1[2] = "<t f='微软雅黑' m='0' n='13' v='0' c='0xf3d300ff' u='0x423818ff' >";
		%Tab1[3] = "<t f='微软雅黑' m='0' n='12' v='0' c='0x00ff4eff' u='0x423818ff' >";

		%Activity[%i] = GetWord(%Player.GetActivity(GetWord($EveryDayGoal[0,%i],2)),0);
		%Activity[%i] = (%Activity[%i] == 0) ? 0 : %Activity[%i];

		//条目1（完成图片）
		if (GetWord($EveryDayGoal[0,%i],0) == 1)
		{
			if (%Activity[%i] >= GetWord($EveryDayGoal[0,%i],3))
				%Txt[1,%i] = "<t>  </t><i s='gameres/gui/images/DTOnline_BiaoTi_1.png' pw='14' ph='14' /> ";
			else
				%Txt[1,%i] = "<t>  </t><i s='gameres/gui/images/DTOnline_BiaoTi_2.png' pw='14' ph='14' /> ";
		}
		else
		{
			if ($EveryDayGoal_Hide[GetWord($EveryDayGoal[0,%i],1)] == 0)
				%Icon = "<i s='gameres/gui/images/GUIbutton03_1_008.png' pw='18' ph='18' /> ";
			else
				%Icon = "<i s='gameres/gui/images/GUIbutton03_1_007.png' pw='18' ph='16' /> ";


			%Txt[1,%i] = "<c cid='" @ Get_TraceButton() @ "' cmd='\"FunctionEveryDayGoal_Hide(" @ %i @ ");\",\""@%Icon@"</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />";
		}

		//标题2（标题）
		switch (%i)
		{
			case 1: %png = "<i s='gameres/gui/images/DTOnline_zxjl.png'pw='130' ph='18' /> ";
			case 6: %png = "<i s='gameres/gui/images/DTOnline_bzhd.png'pw='130' ph='18' /> ";
			case 13: %png = "<i s='gameres/gui/images/DTOnline_sdhd.png'pw='130' ph='18' /> ";
			case 17: %png = "<i s='gameres/gui/images/DTOnline_tzhd.png'pw='130' ph='18' /> ";
			case 23: %png = "<i s='gameres/gui/images/DTOnline_qthd.png'pw='130' ph='18' /> ";
		}

		%Txt[2,%i] = $EveryDayGoal[1,%i];
		%TxtNum[2,%i] = 24 - strlen(%Txt[2,%i]);
		for (%ii = 0; %ii < %TxtNum[2,%i]; %ii++)
			%Txt[2,%i] = %Txt[2,%i] @ " ";

		if (GetWord($EveryDayGoal[0,%i],0) == 0)
			%Txt[2,%i] = %png;
		else if (%Activity[%i] >= GetWord($EveryDayGoal[0,%i],3))
			%Txt[2,%i] = %Tab1[3] @ %Txt[2,%i];
		else
			%Txt[2,%i] = %Tab1[1] @ %Txt[2,%i];

		if (GetWord($EveryDayGoal[0,%i],0) == 1)
		{
			//标题（完成情况）
			if (%Activity[%i] >= GetWord($EveryDayGoal[0,%i],3))
				%Txt[3,%i] = %Tab4 @ "已达成</t>";
			else
				%Txt[3,%i] = %Tab2 @ " " @ %Activity[%i] @ "/" @ GetWord($EveryDayGoal[0,%i],3) @ "</t>";

			//标题（活跃度奖励）
			if (%Activity[%i] >= GetWord($EveryDayGoal[0,%i],3))
				%Txt[4,%i] = %Tab5 @ "+" @ GetWord($EveryDayGoal[0,%i],4) @ "</t>";
			else
				%Txt[4,%i] = %Tab3 @ "+" @ GetWord($EveryDayGoal[0,%i],4) @ "</t>";
		}
		else if (%i == 1)
		{
			%Txt[3,%i] = "<t f='黑体' m='0' b='1' n='12' gct='0xffff00ff' gcb='0xd9680dff'>已完成</t>";
			%Txt[4,%i] = "<t f='黑体' m='0' b='1' n='12' gct='0xffff00ff' gcb='0xd9680dff'>奖励</t>";
		}

		EveryDayGoalWnd_ListBox.AddItem(%Txt[1,%i] TAB %Txt[2,%i] @ "</t>" TAB %Txt[3,%i] TAB %Txt[4,%i],%i);
		EveryDayGoalWnd_ListBox.SetCommand("EveryDayGoalWnd_ListBox_Choose(" @ %i @ ");",%i);

		if ((%i == 26) && (%i[26] == 1))
			%i = 6;
	}

	//当前活跃度显示
	%CurDynamicNUM_Tab1 = "<t f='黑体' m='0' b='1' n='14' gct='0xaaa68cff' gcb='0xe5c614ff'>";
	%CurDynamicNUM_Tab2 = "<t f='微软雅黑' m='0' b='0' n='12' c='0xffffffff' o='0x352d13ff'>";

	%Activity2241[0] = GetWord(%Player.GetActivity(2241),0);
	%Activity2241[0] = (%Activity2241[0] == 0) ? 0 : %Activity2241[0];

	CurDynamicNUM.setcontent(%CurDynamicNUM_Tab1 @ "·当前活跃度：</t>" @ %CurDynamicNUM_Tab2 @ %Activity2241[0] @ "</t>");

	//设置每日历练进度条文子
	CurCompletedMissionNUM.setcontent("<t f='微软雅黑' m='0' n='12' c='0xffffffff' >" @ %Activity2241[0] @ "/145</t>");

	//设置每日历练进度条
	%MissionEXP = %Activity2241[0] / 145;
	TodayCompletedMissionEXP.setScriptValue(%MissionEXP);

	for (%i = 0; %i < 4; %i++)
	{
		%Activity = 2242;

		//每日历练奖励显示1
		%Player.ClearMissionItem(10150 + %i); %Player.AddItemToMission(10150 + %i,1,GetMeiRiLiLianItem(1 + %i),1);
		("GetawardBtn_" @ 1 + %i @ "_3").setcontent(GetFixedMissionItemText(10150 + %i));

		//每日历练奖励显示2
		%EveryDayNeedGoal_Tab = "<t f='微软雅黑' m='0' n='11' c='0xafa35eff'>";
		("EveryDayNeedGoal_" @ %i + 1).setcontent(%EveryDayNeedGoal_Tab @ " 达到" @ $MeiRiLiLian_HuoYueDu[1 + %i] @ "点活跃度</t>");

		//设置领取按钮触发
		("GetawardBtn_" @ %i + 1 @ "_1").command = "ClientOnSptAction(114, " @ %i @ ");";

		//已领取礼包
		if (GetWord(%Player.GetActivity(%Activity + %i),0) > 0)
		{
			("GetawardBtn_" @ %i + 1 @ "_2").setVisible(1);	//开启【已领取】
			("GetawardBtn_" @ %i + 1 @ "_1").setVisible(0);	//关闭【领取】
			("GetawardBtn_" @ %i + 1 @ "_1").SetActive(0);	//灰色【领取】
		}

		//不可领取礼包
		else if (GetWord(%Player.GetActivity(2241),0) < $MeiRiLiLian_HuoYueDu[%i + 1])
		{
			("GetawardBtn_" @ %i + 1 @ "_2").setVisible(0);	//开启【已领取】
			("GetawardBtn_" @ %i + 1 @ "_1").setVisible(1);	//关闭【领取】
			("GetawardBtn_" @ %i + 1 @ "_1").SetActive(0);	//灰色【领取】
		}

		//可以领取礼包
		else
		{
			("GetawardBtn_" @ %i + 1 @ "_2").setVisible(0);	//开启【已领取】
			("GetawardBtn_" @ %i + 1 @ "_1").setVisible(1);	//开启【领取】
			("GetawardBtn_" @ %i + 1 @ "_1").SetActive(1);	//亮色【领取】
		}
	}

	//设置滚动条位置
	EveryDayGoalWndListBox_Scroll.setScrollPosition(%PositionX,%PositionY);
}

function FunctionEveryDayGoal_Hide(%i)
{
	%Hide = $EveryDayGoal_Hide[GetWord($EveryDayGoal[0,%i],1)];
	$EveryDayGoal_Hide[GetWord($EveryDayGoal[0,%i],1)] = (%Hide == 0) ? 1 : 0;

	EveryDayGoalWnd();
}


function EveryDayGoalWnd_ListBox_Choose(%i)
{
	%Txt = EveryDayGoalWnd_Txt2(%i);
	EveryDayGoalWnd_MSG.setcontent("<t>" @ %Txt @ "</t>");
}

function EveryDayGoalWnd_Txt2(%i)
{
	%Player = GetPlayer();

	%Tab1 = "<t f='黑体' m='0' n='16' b='1'gct='0xffff00ff' gcb='0xd9680dff'>";
	%Tab2 = "<t f='微软雅黑' m='0' n='13' c='0xffffffff'>";
	%Tab3 = "<t f='微软雅黑' m='0' n='12' v='1' c='0x00b0f0ff'>";

	%Tab4 = "<t f='微软雅黑' m='0' n='13' v='2' u='0xbfff00ff' c='0xbfff00ff'>";
	%Tab5 = "<t f='微软雅黑' m='0' n='12' v='2' u='0xbfff00ff' c='0xbfff00ff'>";

	switch (%i)
	{
		case 1:%Txt =
			%Tab2 @ "   持续在线即可完成的历练。简单、方便、快捷！</t>";

		case 2:%Txt =
			%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 登录一次游戏</t><b/>" @
			%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 1点活跃度</t>";

		case 3:
			%Time = 900 - %Player.GetSchbuff(1040);
			%TimeFen = mFloor(%Time / 60);
			%TimeMiao = %Time - %TimeFen * 60;

			%Txt =
				%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 今日累计在线15分钟</t><b/>" @
				%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 2点活跃度</t><b/>" @
				%Tab3 @ "（已累计在线时间: " @ %TimeFen @ "分" @ %TimeMiao @ "秒）</t>";

		case 4:
			%Time = 1800 - %Player.GetSchbuff(1041);
			%TimeFen = mFloor(%Time / 60);
			%TimeMiao = %Time - %TimeFen * 60;

			%Txt =
				%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 今日累计在线30分钟</t><b/>" @
				%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 3点活跃度</t><b/>" @
				%Tab3 @ "（已累计在线时间: " @ %TimeFen @ "分" @ %TimeMiao @ "秒）</t>";

		case 5:
			%Time = 3600 - %Player.GetSchbuff(1042);
			%TimeFen = mFloor(%Time / 60);
			%TimeMiao = %Time - %TimeFen * 60;

			%Txt =
				%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 今日累计在线60分钟</t><b/>" @
				%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 6点活跃度</t><b/>" @
				%Tab3 @ "（已累计在线时间: " @ %TimeFen @ "分" @ %TimeMiao @ "秒）</t>";

		case 6:%Txt =
			%Tab2 @ "   每日必做的历练。经验、道具奖励十分的丰厚，无法错过的诱惑！</t>";

		case 7:%Txt =
			%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 完成10次圣地尽忠任务</t><b/>" @
			%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 6点活跃度</t><b/>" @
			%Tab1 @ "参与方式:</t>" @ %Tab2 @ " 圣地 </t>" @ Getfindpath(401005002,0,%Tab4 @ GetNpcData(401005002,1),31214) @ %Tab2 @ " 处报名</t>";

		case 8:%Txt =
			%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 参加1次秦佣阵副本</t><b/>" @
			%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 8点活跃度</t><b/>" @
			%Tab1 @ "参与方式:</t>" @ " </t><b/>" @
			%Tab2 @ "  长安</t>" @ Getfindpath(400001601,0,%Tab4 @ GetNpcData(400001601,1),31214) @
			%Tab2 @ "  洛阳</t>" @ Getfindpath(401002268,0,%Tab4 @ GetNpcData(401002268,1),31214);

		case 9:%Txt =
			%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 参加1次时空裂痕活动</t><b/>" @
			%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 8点活跃度</t><b/>" @
			%Tab1 @ "参与方式:</t>" @ %Tab2 @ " 长安 </t>" @ Getfindpath(401302001,0,%Tab4 @ GetNpcData(401302001,1),31214) @ %Tab2 @ " 处报名</t><b/>" @
			%Tab3 @ "（活动开启时间: 11:00至13:00 19:30至20:30）</t>";

		case 10:
			%cmd[1] = "OpenOrCloseFamilyWnd();";
			%Button[1] = "<c cid='" @ Get_TraceButton() @ "' cmd='\"" @ %cmd[1] @ "\",\"" @ %Tab4 @ "帮派界面" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />";

			%Txt =
				%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 完成3次帮派任务</t><b/>" @
				%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 10点活跃度</t><b/>" @
				%Tab1 @ "参与方式:</t>" @ %Button[1] @ %Tab2 @ " 处报名</t>";

		case 11:%Txt =
			%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 完成3次藏宝图任务</t><b/>" @
			%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 6点活跃度</t><b/>" @
			%Tab1 @ "参与方式:</t>" @ %Tab2 @ " 洛阳 </t>" @ Getfindpath(401002143,0,%Tab4 @ "婠婠",31214) @ %Tab2 @ " 处报名</t>";

		case 12:%Txt =
			%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 完成5次西天取经任务</t><b/>" @
			%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 10点活跃度</t><b/>" @
			%Tab1 @ "参与方式:</t>" @ %Tab2 @ " 长安 </t>" @ Getfindpath(400001295,0,%Tab4 @ GetNpcData(400001295,1),31214) @ %Tab2 @ " 处报名</t>";

		case 13:%Txt =
			%Tab2 @ "   固定时间内才能参加的活动，人气最旺，奖励最丰厚！</t>";

		case 14:%Txt =
			%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 完成1次倭寇入侵活动</t><b/>" @
			%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 5点活跃度</t><b/>" @
			%Tab1 @ "参与方式:</t>" @ %Tab2 @ " 圣地 </t>" @ Getfindpath(810050101,0,%Tab4 @ "东瀛倭寇",31214) @ %Tab2 @ " 处报名</t><b/>" @
			%Tab3 @ "（ [ 东瀛倭寇 ] 在活动时间内才会刷新 ）</t>";

		case 15:%Txt =
			%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 完成1次英雄美人任务</t><b/>" @
			%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 5点活跃度</t><b/>" @
			%Tab1 @ "参与方式:</t>" @ %Tab2 @ " 圣地 </t>" @ Getfindpath(400001269,0,%Tab4 @ GetNpcData(400001269,1),31214) @ %Tab2 @ " 处报名</t><b/>" @
			%Tab3 @ "（ 18:00至19:00 邀请异性朋友一同参加 ）</t>";

		case 16:%Txt =
			%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 参加1次科举活动</t><b/>" @
			%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 10点活跃度</t><b/>" @
			%Tab1 @ "参与方式:</t>" @ %Tab2 @ " 圣地 </t>" @ Getfindpath(401303001,0,%Tab4 @ GetNpcData(401303001,1),31214) @ %Tab2 @ " 处报名</t><b/>" @
			%Tab3 @ "（ 每周一、三、五晚上的21点开启 ）</t>";

		case 17:%Txt =
			%Tab2 @ "   需要相当的实力和团队配合才能完成的活动，奖励和你的付出成正比。</t>";

		case 18:%Txt =
			%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 参加1次剧情副本（组队）</t><b/>" @
			%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 10点活跃度</t><b/>" @
			%Tab1 @ "参与方式:</t>" @ %Tab2 @ " 完成以下任意副本都可完成目标</t><b/>" @
			%Tab3 @ " ·『三打瓦岗寨』60级 - 长安 </t>" @ Getfindpath(400001603,0,%Tab5 @ "瓦岗寨",31214) @ %Tab3 @ "处进入</t><b/>" @
			%Tab3 @ " ·『虎牢关之战』70级 - 长安 </t>" @ Getfindpath(400001604,0,%Tab5 @ "虎牢关",31214) @ %Tab3 @ "处进入</t><b/>" @
			%Tab3 @ " ·『中日第一战』80级 - 长安 </t>" @ Getfindpath(400001605,0,%Tab5 @ "第一战",31214) @ %Tab3 @ "处进入</t><b/>" @
			%Tab3 @ " ·『问鼎天下  』90级 - 长安 </t>" @ Getfindpath(400001606,0,%Tab5 @ "问鼎天下",31214) @ %Tab3 @ "处进入</t>";

		case 19:%Txt =
			%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 参加1次剧情副本（英雄）</t><b/>" @
			%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 5点活跃度</t><b/>" @
			%Tab1 @ "参与方式:</t>" @ %Tab2 @ " 完成以下任意副本都可完成目标</t><b/>" @
			%Tab3 @ " ·『三打瓦岗寨』60级 - 长安 </t>" @ Getfindpath(400001603,0,%Tab5 @ "瓦岗寨",31214) @ %Tab3 @ "处进入</t><b/>" @
			%Tab3 @ " ·『虎牢关之战』70级 - 长安 </t>" @ Getfindpath(400001604,0,%Tab5 @ "虎牢关",31214) @ %Tab3 @ "处进入</t><b/>" @
			%Tab3 @ " ·『中日第一战』80级 - 长安 </t>" @ Getfindpath(400001605,0,%Tab5 @ "第一战",31214) @ %Tab3 @ "处进入</t><b/>" @
			%Tab3 @ " ·『问鼎天下  』90级 - 长安 </t>" @ Getfindpath(400001606,0,%Tab5 @ "问鼎天下",31214) @ %Tab3 @ "处进入</t>";

		case 20:%Txt =
			%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 参加1次挑战名将副本</t><b/>" @
			%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 6点活跃度</t><b/>" @
			%Tab1 @ "参与方式:</t>" @ %Tab2 @ " 长安 </t>" @ Getfindpath(400001149,0,%Tab4 @ GetNpcData(400001149,1),31214) @ %Tab2 @ " 处报名</t>";

		case 21:%Txt =
			%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 参加1次邪王墓副本</t><b/>" @
			%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 6点活跃度</t><b/>" @
			%Tab1 @ "参与方式:</t>" @ %Tab2 @ " 长安 </t>" @ Getfindpath(400001023,0,%Tab4 @ GetNpcData(400001023,1),31214) @ %Tab2 @ " 处报名</t>";

		case 22:%Txt =
			%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 参加1次杨公宝库副本</t><b/>" @
			%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 6点活跃度</t><b/>" @
			%Tab1 @ "参与方式:</t>" @ " </t><b/>" @
			%Tab2 @ "  长安</t>" @ Getfindpath(401001015,0,%Tab4 @ GetNpcData(401001015,1),31214) @
			%Tab2 @ "  洛阳</t>" @ Getfindpath(401002176,0,%Tab4 @ GetNpcData(401002176,1),31214);

		case 23:%Txt =
			%Tab2 @ "   各有特色的活动，你可以挑选感兴趣的参与。</t>";

		case 24:%Txt =
			%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 完成金榜题名活动</t><b/>" @
			%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 6点活跃度</t><b/>" @
			%Tab1 @ "参与方式:</t>" @ %Tab2 @ " 19：00 - 19：30 参与答题</t>";

		case 25:%Txt =
			%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 领取真龙之气</t><b/>" @
			%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 8点活跃度</t><b/>" @
			%Tab1 @ "参与方式:</t>" @ %Tab2 @ " 长安 </t>" @ Getfindpath(401131006,0,%Tab4 @ GetNpcData(401131006,1),31214) @ %Tab2 @ " 处报名</t>";

		case 26:%Txt =
			%Tab1 @ "完成目标:</t>" @ %Tab2 @ " 参加1次十八路反王副本</t><b/>" @
			%Tab1 @ "完成奖励:</t>" @ %Tab2 @ " 8点活跃度</t><b/>" @
			%Tab1 @ "参与方式:</t>" @ " </t><b/>" @
			%Tab2 @ "  长安</t>" @ Getfindpath(401305001,0,%Tab4 @ GetNpcData(401305001,1),31214) @
			%Tab2 @ "  洛阳</t>" @ Getfindpath(401305002,0,%Tab4 @ GetNpcData(401305002,1),31214);
	}

	return %Txt;
}


//■■■是否有奖励可领取
function MeiYueFuLi_NoLingQu(%Player)
{
	for (%i = 0; %i < 4; %i++)
	{
		%Activity = 2246 + %i;

		//已领取礼包
		if (GetWord(%Player.GetActivity(%Activity),0) > 0)
			continue;

		//不可领取礼包
		if (%Player.GetSignInMCount() < $MeiYueFuLi_HuoYueDu[%i + 1])
			continue;

		return 1;
	}

	return 0;
}
