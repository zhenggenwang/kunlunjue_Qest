//■■■■■■■■【特殊对话框】■■■【开启总触发耶】■■■■■■■■■■■■■
//■■■■■■■■【特殊对话框】■■■【闲聊对白文字】■■■■■■■■■■■■■
//■■■■■■■■【特殊对话框】■■■【清除活动选项】■■■■■■■■■■■■■
//■■■■■■■■【特殊对话框】■■■【关闭对话框】■■■■■■■■■■■■■■

//■■■■■■■■【特殊对话框】■■■【任务选项相关】■■■■■■■■■■■■■

//■■■■■■■■【特殊对话框】■■■【设置闲聊文字】■■■■■■■■■■■■■
//■■■■■■■■【特殊对话框】■■■【设置选项文字】■■■■■■■■■■■■■
//■■■■■■■■【特殊对话框】■■■【设置返回文字】■■■■■■■■■■■■■

//■■■■■■■■【特殊对话框】■■■【设置参加活动选项】■■■■■■■■■■■
//■■■■■■■■【特殊对话框】■■■【设置下一步选项】■■■■■■■■■■■■
//■■■■■■■■【特殊对话框】■■■【设置活动返回选项】■■■■■■■■■■■

//■■■■■■■■【特殊对话框】■■■【常规选项触发】■■■■■■■■■■■■■
//■■■■■■■■【特殊对话框】■■■【圣地圣主】■■■■■■■■■■■■■■■
//■■■■■■■■【特殊对话框】■■■【杜如晦】■■■■■■■■■■■■■■■■
//■■■■■■■■【特殊对话框】■■■【李靖】■■■■■■■■■■■■■■■■■
//■■■■■■■■【特殊对话框】■■■【李元霸】■■■■■■■■■■■■■■■■
//■■■■■■■■【特殊对话框】■■■【西天取经】■■■■■■■■■■■■■■■
//■■■■■■■■【特殊对话框】■■■【侠义师徒】■■■■■■■■■■■■■■■
//■■■■■■■■【特殊对话框】■■■【水落石出】■■■■■■■■■■■■■■■
//■■■■■■■■【特殊对话框】■■■【绘制画像】■■■■■■■■■■■■■■■
//■■■■■■■■【特殊对话框】■■■【申请官职和领取俸禄】■■■■■■■■■■

//■■■■■■■■【特殊接任务界面】■■■【清剿和潜伏两条任务线】■■■■■■■


//■■■■■■■■【特殊对话框】■■■【开启总触发耶】■■■■■■■■■■■■■
function OpenNPC_MissionTS(%NpcID,%State)
{
	%Player = GetPlayer();

	//清空选项
	clearButton();
	ClearMissionbutton();

	//关闭其他框
	SpecialMissionDialog2WndGui.setvisible(0);
	SpecialMissionDialog3WndGui.setvisible(0);

	//闲聊对白
	SpecialGUIDialogText.setcontent(Get_Npc_DialogTS(%NpcID));

	//头像设置
	%NPC_MoXing = GetNpcData(%NpcID,5);
	SpecialGUIDialogNpcIcon.setBitmap("gameres/Data/icon/newhead/new_" @ %NPC_MoXing);

	//任务选项
	OpenNPC_Mission_Normal(%NpcID,%State);

	//对话选项
	OpenNPC_Mission_Special(%NpcID,%State);

	//打开特殊界面
	if (SpecialMissionDialogWndGui.isvisible() == 0)
		OpenOrCloseSpecialMissionDialogWnd();
}
//■■■■■■■■【特殊对话框】■■■【开启总触发耶】■■■■■■■■■■■■■

//■■■■■■■■【特殊对话框】■■■【闲聊对白文字】■■■■■■■■■■■■■
function Get_Npc_DialogTS(%NpcID)
{
	if ($NpcRandomDialog[%NpcID,1] !$= "")
	{
		%D = 1;
		if ($NpcRandomDialog[%NpcID,2] !$= ""){ %D = 2; }
		if ($NpcRandomDialog[%NpcID,3] !$= ""){ %D = 3; }

		return $Get_Dialog_GeShi[50010] @ $NpcRandomDialog[%NpcID,GetRandom(1,%D)] @ "</t>";
	}
	else
		return $Get_Dialog_GeShi[50010] @ "欢迎来到《昆仑决》的世界</t><b/><b/>";
}
//■■■■■■■■【特殊对话框】■■■【闲聊对白文字】■■■■■■■■■■■■■

//■■■■■■■■【特殊对话框】■■■【清除活动选项】■■■■■■■■■■■■■
function ClearMissionbutton()
{
	SpecialMissionDialog4_button.setvisible(0);
	SpecialGUIDialog4AccpetBtn.setvisible(0);
	SpecialGUIDialog4CancelBtn.setvisible(0);
}
//■■■■■■■■【特殊对话框】■■■【清除活动选项】■■■■■■■■■■■■■

//■■■■■■■■【特殊对话框】■■■【关闭对话框】■■■■■■■■■■■■■■
function closeNPC_MissionTS(%Type)
{
	switch (%Type)
	{
		case 1://关闭所有界面
			CloseSpecialMissionDialogWndGui();//关闭特殊任务对话框
			CloseSpecialMissionDialog2WndGuiSchedule();	//关闭接任务窗口-详细描述
			CloseSpecialMissionDialog3WndGuiSchedule();	//关闭完成任务窗口-完成描述

		case 2://关闭所有界面
			SpecialMissionDialogWndGui.setvisible(0); 	//关闭特殊任务对话框
			SpecialMissionDialog3WndGui.setvisible(0);	//关闭完成任务窗口-完成描述
			SpecialMissionDialog2WndGui.setvisible(0);	//关闭完成任务窗口-完成描述
	}
}
//■■■■■■■■【特殊对话框】■■■【关闭对话框】■■■■■■■■■■■■■■

//■■■■■■■■【特殊对话框】■■■【任务选项相关】■■■■■■■■■■■■■
function OpenNPC_Mission_Normal(%NpcID,%State)
{
	if (%State != 0)
		return;

	%Player = GetPlayer();
	%NpcA_Mid = GetStartNpcMission(%NpcID);		//可以领取的任务
	%NpcX_Mid = GetMidTalkNpcMission(%NpcID);	//正在进行中任务
	%NpcZ_Mid = GetEndNpcMission(%NpcID);			//可以完成的任务

	%NpcA_Mid_MaxNum = GetWordCount(%NpcA_Mid);	//可以领取的任务数量
	%NpcX_Mid_MaxNum = GetWordCount(%NpcX_Mid);	//正在进行中任务数量
	%NpcZ_Mid_MaxNum = GetWordCount(%NpcZ_Mid);	//可以完成的任务数量

	//遍历当前NPC所有可交的任务，并给予相应选项
	for (%z = 0; %z < %NpcZ_Mid_MaxNum; %z++)
	{
		%Mid = GetWord(%NpcZ_Mid,%z);												//获取任务ID
		if (!Mission_End_SeeOption(%Player,%Mid))							//是否显示(特殊判断)
			if (CanDoThisMission(%Player,%Mid,2,0,0) $= "")	//是否显示(常规判断)
				SetMission(%NpcID,%Mid,910);
	}

	//遍历当前NPC所有中途对话的任务，并给予相应选项
	for (%z = 0; %z < %NpcX_Mid_MaxNum; %z++)
	{
		%Mid = GetWord(%NpcX_Mid,%z);															//获取任务ID
		if (CanDoMidwayMission(%NpcID,%Player,%Mid,0,0,0) > 0)	//是否显示(常规判断)
			SetMission(%NpcID,%Mid,210);
	}

	//遍历当前NPC所有可接的任务，并给予相应选项
	for (%a = 0; %a < %NpcA_Mid_MaxNum; %a++)
	{
		%Mid = GetWord(%NpcA_Mid,%a);											//获取任务ID
		if (!Mission_Begin_SeeOption(%Player,%Mid))							//是否显示(特殊判断)
			if (CanDoThisMission(%Player,%Mid,1,0,0) $= "")	//是否显示(常规判断)
			{
				SetMission(%NpcID,%Mid,110);
			}
	}
}

//■■■■■■■■【特殊对话框】■■■【任务选项相关】■■■■■■■■■■■■■


//■■■■■■■■【特殊对话框】■■■【接交任务相关】■■■■■■■■■■■■■
function SetMission(%NpcID,%Mid,%Dialog)
{
	if ($SetMission == 5)
		return;

	%Player = GetPlayer();

	OpenNPC_Mission_AN();

	%kind       	= GetMissionKind(%Mid);
	%Mid_LeiXin 	= $MissionKind[%kind,2];

	if (%kind == 10)
		%GeShi[110] = $Get_Dialog_GeShi[50021];
	else
		%GeShi[110] = $Get_Dialog_GeShi[50011];

	//领取任务选项文字
	if (%Dialog == 110)%Txt = GetMissionIcon(%Mid) @ %GeShi[110] @ %Mid_LeiXin @ "－" @ GetMission_Name(%Player,%Mid,3) @ "</t>";		//接取
	else if (%Dialog == 210)%Txt = $Icon[4] @ $Get_Dialog_GeShi[50012] @ "对话 －" @ GetMission_Name(%Player,%Mid,3) @ "</t>";												//中途
	else if (%Dialog == 910)%Txt = $Icon[2] @ $Get_Dialog_GeShi[50012] @ %Mid_LeiXin @ "－" @ GetMission_Name(%Player,%Mid,3) @ "（完成）</t>";				//完成
	("ReciveMissionBtn" @ $SetMission).settext(%Txt);

	//领取任务选项触发
	if (%Dialog == 110)("ReciveMissionBtn" @ $SetMission).command = "SetMission110(" @ %NpcID @ ","@ %Mid @ ");ZhiYin_Mission(2," @  %Mid @ ","@ %Dialog @ ");";
	else if (%Dialog == 210)("ReciveMissionBtn" @ $SetMission).command = "SetMission210(" @ %NpcID @ ","@ %Mid @ ");ZhiYin_Mission(3," @  %Mid @ ","@ %Dialog @ ");";
	else if (%Dialog == 910)("ReciveMissionBtn" @ $SetMission).command = "SetMission910(" @ %NpcID @ ","@ %Mid @ ");ZhiYin_Mission(4," @  %Mid @ ","@ %Dialog @ ");";

	//指引
	ZhiYin_Mission(1,%Mid,%Dialog);
}

function ZhiYin_Mission(%tey,%Mid,%Dialog)
{
	return;
}
function SetMission110(%NpcID,%Mid)
{
	%Player = GetPlayer();

	//关闭其他框
	SpecialMissionDialogWndGui.setvisible(0);	//关闭特殊任务对话框
	SpecialMissionDialog3WndGui.setvisible(0);	//关闭完成任务窗口-完成描述

	//打开领取任务界面
	OpenSpecialMissionDialog2WndGui();

	//SpecialGUIDialog2NpcIcon //接受任务头像

	//接受任务描述
	%TxtA = eval("Mission" @ %Mid @ "Dialog" @ "(%Npc, %Player, %Mid, 10002);");

	//任务奖励
	%TxtB = GetMissionHortation(%Mid,3,10050);

	SpecialGUIDialog2Text.setcontent($Get_Dialog_GeShi[50013] @ %TxtA @ "<b/>" @ $Icon[100] @ "<b/>" @ %TxtB @ "</t>");

	SpecialGUIDialog2Awards.setcontent(%TxtB);

	//接受按钮
	SpecialGUIDialog2AccpetBtn.command = "ClientOnSptAction(29, "@%Mid@");closeNPC_MissionTS(2);Closeupgrade_modelchoiceGui();";

	//取消按钮
	SpecialGUIDialog2CancelBtn.command = "OpenNPC_MissionTS("@%NpcID@", 0);";

	//头像设置
	%NPC_MoXing = GetNpcData(%NpcID,5);
	SpecialGUIDialog2NpcIcon.setBitmap("gameres/Data/icon/newhead/new_" @ %NPC_MoXing);
}

function SetMission210(%NpcID,%Mid)
{
	%Player = GetPlayer();
	clearButton();
	%FlagID = CanDoMidwayMission(%NpcID,%Player,%Mid,%Type,%Other,%Msg);
	ClientOnSptAction(34,%Mid @ %FlagID - 1150);
	OpenNPC_Mission_ZT(300 + (%FlagID - 1150) @ %Mid);
	OpenNPC_Mission_HH(%NpcID,0);
}

function SetMission910(%NpcID,%Mid)
{
	%Player = GetPlayer();

	//关闭其他框
	SpecialMissionDialogWndGui.setvisible(0);	//关闭特殊任务对话框
	SpecialMissionDialog2WndGui.setvisible(0);	//关闭完成任务窗口-完成描述

	OpenSpecialMissionDialog3WndGui();

	//完成任务描述
	%TxtA = eval("Mission" @ %Mid @ "Dialog" @ "(%Npc, %Player, %Mid, 10005);");

	//任务奖励
	%TxtB = GetMissionHortation(%Mid,4,10050);

	SpecialGUIDialog3Text.setcontent($Get_Dialog_GeShi[50013] @ %TxtA @ "<b/>" @ $Icon[100] @ "<b/>" @ %TxtB @ "</t>");

	//完成按钮
	SpecialGUIDialog3CompleteBtn.command = "ClientOnSptAction(30, "@%Mid@");";

	//取消按钮
	SpecialGUIDialog3ReturnBtn.command = "OpenNPC_MissionTS("@%NpcID@", 0);";

	//头像设置
	%NPC_MoXing = GetNpcData(%NpcID,5);
	SpecialGUIDialog3NpcIcon.setBitmap("gameres/Data/icon/newhead/new_" @ %NPC_MoXing);
}
//■■■■■■■■【特殊对话框】■■■【接交任务相关】■■■■■■■■■■■■■

//■■■■■■■■【特殊对话框】■■■【设置闲聊文字】■■■■■■■■■■■■■
function OpenNPC_Mission_XL(%DialogID)
{
	%Player = GetPlayer();
	%Txt = GetDialogText(0,%Player,%DialogID,0);
	SpecialGUIDialogText.setcontent($Get_Dialog_GeShi[50016] @ %Txt @ "</t>");
}
//■■■■■■■■【特殊对话框】■■■【设置中途文字】■■■■■■■■■■■■■
function OpenNPC_Mission_ZT(%DialogID)
{
	%Player = GetPlayer();
	%Txt = GetDialogText(0,%Player,%DialogID,0);
	SpecialGUIDialogText.setcontent($Get_Dialog_GeShi[50016] @ %Txt @ "</t>");
}

//■■■■■■■■【特殊对话框】■■■【设置选项文字】■■■■■■■■■■■■■
function OpenNPC_Mission_XX(%NpcID,%DialogID,%command)
{
	%Player = GetPlayer();

	//创建按钮
	OpenNPC_Mission_AN();

	%Txt = GetDialogText(0,%Player,%DialogID,0);
	("ReciveMissionBtn" @ $SetMission).settext(%Txt);
	("ReciveMissionBtn" @ $SetMission).command = "OpenNPC_MissionTS("@%NpcID@", "@%command@");";
	("ReciveMissionBtn" @ $SetMission).Visible = "1";
}

function OpenNPC_Mission_AN()
{
	$SetMission++;
	CreateNpcDialogBtn();
}
//■■■■■■■■【特殊对话框】■■■【设置返回文字】■■■■■■■■■■■■■
function OpenNPC_Mission_HH(%NpcID,%command)
{
	OpenNPC_Mission_AN();

	%Txt =  $Icon[14] @ $Get_Dialog_GeShi[50016] @ "返回上一级";
	("ReciveMissionBtn" @ $SetMission).settext(%Txt);
	("ReciveMissionBtn" @ $SetMission).command = "OpenNPC_MissionTS("@%NpcID@", "@%command@");";
}

//■■■■■■■■【特殊对话框】■■■【设置参加活动选项】■■■■■■■■■■■
function OpenNPC_Mission_CJHD(%NpcID,%Command)
{
	SpecialMissionDialog4_button.setposition(746,165 + 30);
	SpecialMissionDialog4_button.setvisible(1);
	SpecialGUIDialog4AccpetBtn.setvisible(1);
	SpecialGUIDialog4AccpetBtn.command = "OpenNPC_MissionTS("@%NpcID@", "@%command@");";
	SpecialGUIDialog4AccpetBtn.setProfile("DTMissionDialogWnd4GuiBtn_Profile");
}

//■■■■■■■■【特殊对话框】■■■【设置下一步选项】■■■■■■■■■■■■
function OpenNPC_Mission_XYB(%NpcID,%Command)
{
	SpecialMissionDialog4_button.setposition(746,165 + 30);
	SpecialMissionDialog4_button.setvisible(1);
	SpecialGUIDialog4AccpetBtn.setvisible(1);
	SpecialGUIDialog4AccpetBtn.command = "OpenNPC_MissionTS("@%NpcID@", "@%command@");";
	SpecialGUIDialog4AccpetBtn.setProfile("DTMissionDialogWnd4GuiBtn_Profile1");
}

//■■■■■■■■【特殊对话框】■■■【设置活动返回选项】■■■■■■■■■■■
function OpenNPC_Mission_HDHH(%NpcID,%Command)
{
	SpecialMissionDialog4_button.setposition(746,165 + 30);
	SpecialMissionDialog4_button.setvisible(1);
	SpecialGUIDialog4CancelBtn.setvisible(1);
	SpecialGUIDialog4CancelBtn.command = "OpenNPC_MissionTS("@%NpcID@", "@%command@");";
}
