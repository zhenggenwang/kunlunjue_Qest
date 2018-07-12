/*
================================================================================
注：所有脚本开头，均需注明本脚本的大致说明文字


功能说明：1.鼠标双击活动条目寻径相关NPC
2.鼠标单击活动条目显示活动详细信息


Author: 郑根旺
Date  : 2012.04.27
================================================================================
*/


//■■■■■■■■■■豆腐干设置属性先关■■■■■■■■■■■■■■■
//■■■■■■■■■■豆腐干打开内容相关■■■■■■■■■■■■■■■
//■■■■■■■■■■豆腐干创建控件相关■■■■■■■■■■■■■■■
//■■■■■■■■■■豆腐干关闭触发相关■■■■■■■■■■■■■■■
//■■■■■■■■■■豆腐干指向包裹内容■■■■■■■■■■■■■■■
//■■■■■■■■■■任务类对话指引界面■■■■■■■■■■■■■■■
//■■■■■■■■■■接取删除任务触发■■■■■■■■■■■■■■■■
//■■■■■■■■■■界面按钮触发■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■任务旗标满足交付条件时触发■■■■■■■■■■■
//■■■■■■■■■■挂机界面推荐技能组合■■■■■■■■■■■■■■

$FuGanNum = 10057;
//OpenDouFuGan(%ID) 打开豆腐干
//OpenDouFuGan_AllBagWndGui(%Item, %Txt)

//■■■■■■■■■■豆腐干设置属性先关■■■■■■■■■■■■■■■
//打开豆腐干------------------------------------------------------------------------------------------------------------------
function OpenDouFuGan(%ID)
{
	%Time = 10000;															//显示时间
	%Format_Black  = $Get_Dialog_GeShi[31400];	//黑色字体
	%Format_Yellow = $Get_Dialog_GeShi[31404];	//黄色字体
	%Format_Green  = $Get_Dialog_GeShi[31414];	//草绿色字体
	%format_Red    = $Get_Dialog_GeShi[31406];  //红色

	if (("Mini_TimerTriggerCtrl_HelpWnd_" @ %ID).isVisible() == 1)
	{
		("Mini_TimerTriggerCtrl_HelpWnd_" @ %ID).setVisible(0);

		("Mini_TimerTriggerCtrl_HelpWnd_" @ %ID).delete();
	}
	putout("打开豆腐干%DialogID===" @ %ID);
	switch (%ID)
	{
		//OpenHelpDirectWnd( "FBDeliverCtrl", "3", "左键点击", 30000, "-170 -5", 1 );//点击离开副本
		case 1:
			%Tab = "<t f='黑体' m='0' n='18' b='1' h='1' gct='0xffff00ff' gcb='0xd9680dff'>";
			OpenHelpDirectWnd("BottomControlWndGui","6",%Tab @ "<b/><t>按“TAB”键选中怪物</t><t>按快捷键“2”释放技能</t>",0,"390 70",%ID);//点击施放技能
		case 2:OpenHelpDirectWnd("FBDeliverCtrl","3","左键点击",30000,"-170 -5",%ID);//点击离开副本
		case 3:
			OpenHelpDirectWnd("FightAssistant_Skill_ShortcutWnd","2","点击开启",10000,"10 -80",%ID);//指引开启自动战斗
		case 4:
			if (GetPlayer().IsAcceptedMission(10018))
			{
				if (Mini_TimerTriggerCtrl_HelpWnd_3.isVisible() == 1)
				{
					Mini_TimerTriggerCtrl_HelpWnd_3.setVisible(0);
					Mini_TimerTriggerCtrl_HelpWnd_3.delete();
				}
				OpenHelpDirectWnd("FightAssistantWnd","3","点击关闭",0,"600 0",%ID);
			}

		case 5://关闭包裹界面指引
			OpenHelpDirectWnd("AllBagWndGui","3","点击关闭",0,"200 10",%ID);
		case 6://指引查看装备属性
			OpenHelpDirectWnd("KLPlayerInfoGui","1","查看属性",0,"210 495",%ID);
		case 7:
			OpenHelpDirectWnd("KLPlayerInfoGui","3","点击关闭",0,"580 50",%ID);
		case 8:
			OpenHelpDirectWnd("KLJEquipStrengthenWnd","4","点击强化",10000,"570 368",%ID);
		case 9:
			OpenHelpDirectWnd("KLJEquipStrengGui","4","点击鉴定",10000,"550 415",%ID);
		case 10:
			OpenHelpDirectWnd("MissionDialogWndGui","4","<t>点击选项</t>",10000,"100 240",%ID);

		case 11:OpenHelpDirectWnd("BottomControlWndGui","2","<t>选中目标攻击</t>",10000,"410 150",%ID);

		case 12:OpenHelpDirectWnd("BottomControlWndBtnGui","2","打开包裹",10000,"30 -100",%ID);
		case 13:OpenHelpDirectWnd( "SkillHintWndGui", "4", "一键拖动技能", 30000, "130 170", %ID );
		case 14://打开界面
			OpenHelpDirectWnd("BirdViewMapGui","3","点击打开",30000,"-85 230",%ID);
			$UpLinePartyWndRecord = 4;
		case 15://领取礼包
			if ($RecordIsUseThis == 1)
				return;
			OpenHelpDirectWnd("UpLinePartyWndGui","1","点击领取",30000,"520 435",%ID);
			$RecordIsUseThis = 1;
		case 16:OpenHelpDirectWnd("AllBagWndGui","2","点击分解",0,"150 310",%ID);
		case 17:OpenHelpDirectWnd("BottomControlWndGui","2","打开扩展栏",0,"780 140",%ID);
		case 18://攻略界面
			//echo("============================" @ $StrtegyHelpDirectRecord);
			switch ($StrtegyHelpDirectRecord)
			{
				case 1:
					OpenHelpDirectWnd("StrategyWndGui","2","点击选项",0,"185 120",%ID);
				case 2:
					OpenHelpDirectWnd("StrategyWndGui","3","点击选项",0,"0 270",%ID);
				case 3:
					OpenHelpDirectWnd("StrategyWndGui","3","点击领取",0,"900 470",%ID);
					$StrtegyHelpDirectRecord = 4;
			}
		case 19://攻略界面
			OpenHelpDirectWnd("StrategyWndGui","3","点击关闭",0,"780 20",%ID);
		case 20:
			OpenHelpDirectWnd("BottomControlWndBtnGui", "4", "领取在线奖励", 0, "40 -140", %ID);
			
		case 21:
			if (!("TimerTriggerStart_OKBtn_" @ $DouFuGanState[21]).isactive())
				return;
			switch ($DouFuGanState[21])
			{
				case 0:OpenHelpDirectWnd("TimerTriggerCtrlTotalWnd", "2", "领取奖励", 30000, "280 -30", %ID);
				case 1:OpenHelpDirectWnd("TimerTriggerCtrlTotalWnd", "2", "领取奖励", 30000, "280 40", %ID);
				case 2:OpenHelpDirectWnd("TimerTriggerCtrlTotalWnd", "2", "领取奖励", 30000, "280 100", %ID);
				case 3:OpenHelpDirectWnd("TimerTriggerCtrlTotalWnd", "2", "领取奖励", 30000, "280 160", %ID);
			}
		case 22:OpenHelpDirectWnd("FightAssistantWnd","2","点击应用",0,"720 400",%ID);
		case 23:%Tab = "<t f='黑体' m='0' n='18' b='1' h='1' gct='0xffff00ff' gcb='0xd9680dff'>";
			OpenHelpDirectWnd( "BottomControlWndGui", "6", %Tab @ "<b/><b/><t>按“0”可快捷上坐骑</t>", 0, "690 70", %ID );
		case 24:OpenHelpDirectWnd("FightAssistantWnd","2","推荐设置",0,"630 400",%ID);
		case 25:
			if (!KLPlayerInfoGui.IsVisible())
			{
				OpenKLPlayerInfoGui();
				CloseNewFunctionTipFlash(1,0);
			}
			$PetZhiYinRecord = 1;
			OpenHelpDirectWnd("KLPlayerInfoGui","4","点击打开",0,"330 100",%ID);
		case 26:
			closeHelpDirect1_4(25);
			//%Tab1 = "<t f='黑体' m='0' n='18' b='1' h='1' gct='0xffff00ff' gcb='0xd9680dff'>";
			%Tab2 = "<t f='楷体_GB2312' m='0' n='16' b='1' h='1' c='0xf3d300ff' o='0x291b00ff'>";				//黄色
			OpenHelpDirectWnd("KLPlayerInfoGui","8",%Tab2 @ "<b/><t>拖拽坐骑头像</t>" @ %Tab2 @ "<t>放入快捷栏里</t>" @ %Text @ "更方便召唤哦</t>",0,"130 145",%ID);
			$PetZhiYinRecord = 0;
		case 27://获得包裹后指引使用
			if (!AllBagWndGui.IsVisible())
				OpenBag();
			switch ($DouFuGanState[27])
			{
				case 1:Schedule(1000, 0, "OpenDouFuGan_AllBagWndGui", 112010055, 0);
				case 2:Schedule(1000, 0, "OpenDouFuGan_AllBagWndGui", 112010056, 0);
			}
		case 30:OpenHelpDirectWnd("EquipChangeWnd","4","一键穿戴",30000,"230 165",%ID);
		case 31:OpenHelpDirectWnd("UpLinePartyWndGui","3","点击关闭",30000,"750 0",%ID);
		case 10001:OpenHelpDirectWnd("MissionTraceWnd","4","点击寻路",30000,"30 60",%ID);
		case 10002:OpenHelpDirectWnd("MissionTraceWnd","4","点击寻路",30000,"80 40",%ID);
		case 10011:
			if (GetPlayer().GetMissionFlag(%id,3200) == GetPlayer().GetMissionFlag(%id,3300))//任务旗标已经完成
				OpenHelpDirectWnd("MissionTraceWnd","4","点击寻路",30000,"80 40",%ID);
			else
				OpenHelpDirectWnd("MissionTraceWnd","4","点击寻路",30000,"30 60",%ID);
		case 10021:
			if (GetPlayer().GetMissionFlag(%id,2200) == GetPlayer().GetMissionFlag(%id,2300))//任务旗标已经完成
				OpenHelpDirectWnd("MissionTraceWnd","4","点击寻路",30000,"80 40",%ID);
			else
				OpenHelpDirectWnd("MissionTraceWnd","4","点击寻路",30000,"30 70",%ID);
		case 10032:OpenHelpDirectWnd("MissionDialogWndGui","4","<t>点击选项</t>",0,"100 145",%ID);
		case 10041:OpenHelpDirectWnd("MissionTraceWnd","4","点击寻路",30000,"80 40",%ID);

		case 10061:
			if (GetPlayer().GetMissionFlag(%id,2200) == GetPlayer().GetMissionFlag(%id,2300))
				OpenHelpDirectWnd("MissionTraceWnd","4","点击寻路",30000,"80 40",%ID);
			else
				OpenHelpDirectWnd("MissionTraceWnd","4","点击寻路",30000,"30 70",%ID);
		case 10071:OpenHelpDirectWnd("MissionTraceWnd","4","点击寻路",30000,"80 40",%ID);
		case 10081:OpenHelpDirectWnd("MissionTraceWnd","4","点击寻路",30000,"80 40",%ID); 
		case 10091:
			if (GetPlayer().GetMissionFlag(%id,2200) == GetPlayer().GetMissionFlag(%id,2300))
				OpenHelpDirectWnd("MissionTraceWnd","4","点击寻路",30000,"80 40",%ID);
			else
				OpenHelpDirectWnd("MissionTraceWnd","4","点击寻路",30000,"30 70",%ID);
		case 10101:OpenHelpDirectWnd( "MissionTraceWnd", "4", "点击寻路", 30000, "80 40", %ID );
		case 10111:OpenHelpDirectWnd("MissionTraceWnd","4","点击寻路",30000,"80 40",%ID);
		case 10121:OpenHelpDirectWnd( "MissionTraceWnd", "4", "点击寻路", 30000, "80 40", %ID );
		case 10131:OpenHelpDirectWnd( "MissionTraceWnd", "4", "点击寻路", 30000, "80 40", %ID );	
		case 10141:
			if ( GetPlayer( ).GetMissionFlag( %id, 2200 ) == GetPlayer( ).GetMissionFlag( %id, 2300 ) )
				OpenHelpDirectWnd( "MissionTraceWnd", "4", "点击寻路", 30000, "80 40", %ID );
			else
				OpenHelpDirectWnd( "MissionTraceWnd", "4", "点击寻路", 30000, "30 70", %ID );
		case 10151:OpenHelpDirectWnd( "MissionTraceWnd", "4", "点击寻路", 30000, "80 40", %ID );
		case 10161:OpenHelpDirectWnd( "MissionTraceWnd", "4", "点击寻路", 30000, "80 40", %ID );
		case 10162:OpenHelpDirectWnd( "MissionTraceWnd", "4", "点击寻路", 30000, "80 40", %ID );
		case 10163:
			if ( GetPlayer( ).GetMissionFlag( %id, 3200 ) == GetPlayer( ).GetMissionFlag( %id, 3300 ) )
				OpenHelpDirectWnd( "MissionTraceWnd", "4", "点击寻路", 30000, "80 40", %ID );
			else
				OpenHelpDirectWnd( "MissionTraceWnd", "4", "点击寻路", 30000, "30 60", %ID );
		case 10171:
			OpenHelpDirectWnd("MissionTraceWnd","4","点击寻路",30000,"80 40",%ID);
		case 10221:OpenHelpDirectWnd("MissionTraceWnd","4","点击寻路",30000,"80 40",%ID);
		case 10231:
			for (%i = 0; %i < 5; %i++)
			{
				%ItemID = 105220004 + %i * 10000;
				if (GetPlayer().Getitemcount(%ItemID) > 0)
				{
					OpenDouFuGan_AllBagWndGui(%ItemID,5);//指引包裹内容
					break;
				}
			}
		case 10321:
			%Text = "<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>原来此处就是灵童出生之地啊！灵气真够浓郁的，都快凝结成玉石了</t>";
			Dialog_OnlyOK_COVER_Content.setContent(%Text);

			Dialog_OnlyOK_COVER_OKBTN.settext("确定");
			Dialog_OnlyOK_COVER_OKBTN.command = "Dialog_OnlyOK_COVER.setVisible(0);";

			Dialog_OnlyOK_COVER.setVisible(true);
		case 10361:
			%Player = GetPlayer();
			%Record = 0;
			%MainNum = GetStrategyMainBtnNum();
			//echo( "%MainNum===" @ %MainNum );
			for (%i = 0; %i < %MainNum; %i++)//单独攻略奖励
			{
				%SubNum = GetStrategySubBtnNum(%i);
				//echo( "%SubNum===" @ %SubNum );
				for (%j = 0; %j < %SubNum; %j++)
				{
					%Src = $StrategySubBtnSrc[%i,%j];
					//echo( "%Src===" @ %Src );
					//echo( "$StrategySubBtnSrc[" @ %i @ "," @ %j @ "]===" @ $StrategySubBtnSrc[ %i, %j ]  @ "   " @  $StrategySubBtnTit[ %i, %j ] @ "   " @ GetSrc( %Player, %Src ) );
					if (GetSrc(%Player,%Src) == 1 && GetSrc(%Player,%Src + 1) == 0 && %Src !$="")
					{
						%Record = 1;
						//echo( "$StrategySubBtnSrc[" @ %i @ "," @ %j @ "]===" @ $StrategySubBtnSrc[ %i, %j ]  @ "   " @  $StrategySubBtnSrc[ %i, %j ] );
						break;
					}
				}
			}
			//echo( "%Record===" @ %Record );
			if (%Record == 1)
			{
				%Tab1 = "<t f='黑体' m='0' n='18' b='1' h='1' gct='0xffff00ff' gcb='0xd9680dff'>";
				%Tab2 = "<t f='楷体_GB2312' m='0' n='16' b='1' h='1' c='0xf3d300ff' o='0x291b00ff'>";
				OpenHelpDirectWnd("MissionTraceWnd","7",%Tab1 @ "<t>领取攻略奖励</t><b/>" @ %Tab2 @ "<t>恭喜您学会自动战斗</t><t>完成攻略有奖励可领取</t>",0,"-250 -140",%ID);
			}
	}

}

//关闭豆腐干------------------------------------------------------------------------------------------------------------------
function CloseDouFuGan(%ID)
{
	switch (%ID)
	{
		case 1000:
	}
}

//■■■■■■■■■■豆腐干设置属性先关■■■■■■■■■■■■■■■

/*

closeHelpDirect1_4(10051);

OpenDouFuGan(10051);

//660
//400

//1090
//700

$YiDongPos = 5;

function AAAA(%Ax, %Ay, %Bx, %By)
{
Cancel($SSSS);

%Nx = %Bx - %Ax;
%Ny = %By - %Ay;

//移动的次数
%TimeCi = ((%Nx >= %Ny) ? %Nx:%Ny) / $YiDongPos;

//移动的速度
%Nx = %Nx / %TimeCi;
%Ny = %Ny / %TimeCi;

//计算每次缩放
%Extent = Mini_TimerTriggerCtrl_HelpWnd_10051.getExtent();
%ExtentX = GetWord(%Extent, 0);
%ExtentY = GetWord(%Extent, 1);

%NExtentX = %ExtentX / %TimeCi;
%NExtentY = %ExtentY / %TimeCi;

SSSS(%TimeCi, %Ax, %Ay, %Nx, %Ny, %ExtentX, %ExtentY, %NExtentX, %NExtentY);
}

function SSSS(%TimeCi, %Ax, %Ay, %Nx, %Ny, %ExtentX, %ExtentY, %NExtentX, %NExtentY)
{
echo(%TimeCi@" "@%Ax@" "@%Ay@" "@%Nx@" "@%Ny@" "@%ExtentX@" "@%ExtentY@" "@%NExtentX@" "@%NExtentY);
if(%TimeCi <= 0)
return;

//设置移动
Mini_TimerTriggerCtrl_HelpWnd_10051.setposition(%Ax, %Ay);

//下次移动计算
%Ax = %Ax + %Nx;
%Ay = %Ay + %Ny;

//设置大小
Mini_TimerTriggerCtrl_HelpWnd_10051.setExtent(%ExtentX, %ExtentY);

//下次大小计算
%ExtentX = %ExtentX - %NExtentX;
%ExtentY = %ExtentY - %NExtentY;

$SSSS = Schedule(20, 0, "SSSS", %TimeCi--, %Ax, %Ay, %Nx, %Ny, %ExtentX, %ExtentY, %NExtentX, %NExtentY);
}

AAAA(500, 300, 1124, 800);

*/
//■■■■■■■■■■任务类对话指引界面■■■■■■■■■■■■■■■
function Get_Mission_Dialog_ZhiYinWed(%Player,%DialogID)
{
	/*
	900开头 交付任务的选项
	910开头 交付任务的弹出对话框
	100开头 接取任务的选项
	110开头 接取任务的弹出对话框
	*/
	//echo("任务类对话指引界面%DialogID===" @ %DialogID);
	if (strlen(%DialogID) > 5)
		%MissIonID = GetSubStr(%DialogID,3,strlen(%DialogID) -3);
	else
		%MissIonID = %DialogID;

	if (("Mini_TimerTriggerCtrl_HelpWnd_" @ %MissIonID).isvisible())
		closeHelpDirect1_4(%MissIonID);
	//echo( "%MissIonID===" @ %MissIonID );
	if (%MissIonID <= 10161)//药园前的所有主线任务
	{
		if (strlen(%DialogID)  == 5)
		{
			OpenHelpDirectWnd("MissionDialog2ClildWndGui","3","<t>点击下一步</t>",0,"-80 380",%MissIonID);
			//echo( "%MissIonID===" @ %MissIonID );
		}
		else
		{
			//echo( "%任务类对话指引界面MissIonID===" @ %MissIonID );
			switch (GetSubStr(%DialogID,0,3))
			{
				case 900:
					if (%MissIonID != 10032)
						OpenHelpDirectWnd("MissionDialogWndGui","4","<t>点击选项</t>",0,"100 145",%MissIonID);
				case 910:
					OpenHelpDirectWnd("MissionDialog2ClildWndGui","3","<t>点击完成</t>",0,"-80 380",%MissIonID);
				case 110:
					OpenHelpDirectWnd("MissionDialog2ClildWndGui","3","<t>点击接受</t>",0,"-80 380",%MissIonID);
				case 100:
					OpenHelpDirectWnd("MissionDialogWndGui","4","<t>点击接受</t>",0,"100 145",%MissIonID);
			}
		}
	}
	switch (%DialogID)
	{
		//case 10002:
		//	//echo( "点击下一步" );
		//	OpenHelpDirectWnd( "MissionDialog2ClildWndGui", "3", "<t>点击下一步</t>", 0, "-80 380", %MissIonID );
		//case 90010002:
		//	OpenHelpDirectWnd( "MissionDialogWndGui", "4", "<t>点击选项</t>", 0, "100 145", %MissIonID );
		//case 90010031:
		//	OpenHelpDirectWnd( "MissionDialogWndGui", "4", "<t>点击选项</t>", 0, "100 145", %MissIonID );
		//case 91010002:
		//	OpenHelpDirectWnd( "MissionDialog2ClildWndGui", "3", "<t>点击完成</t>", 0, "-80 380", %MissIonID );
		//case 91010011:
		//	OpenHelpDirectWnd( "MissionDialog2ClildWndGui", "3", "<t>点击完成</t>", 0, "-80 380", %MissIonID );
		case 91010031:
			%Classes = getPlayer().GetClasses(0);
			switch (%Classes)
			{
				case 1:%Text = "<t>长枪";
				case 3:%Text = "<t>法器";
				case 4:%Text = "<t>法杖";
			}
			%Tab1 = "<t f='黑体' m='0' n='18' b='1' h='1' gct='0xffff00ff' gcb='0xd9680dff'>";
			%Tab2 = "<t f='楷体_GB2312' m='0' n='16' b='1' h='1' c='0xf3d300ff' o='0x291b00ff'>";				//黄色
			OpenHelpDirectWnd("MissionDialog2ClildWndGui","8",%Tab1 @ "<t>选择一件武器</t><b/>" @ %Tab2 @ "<t>刀剑是通用武器</t>" @ %Text @ "是本职业专属武器</t>",0,"180 270",%MissIonID);

		case 10010011:
			OpenHelpDirectWnd("MissionDialogWndGui","1","><t>点击选项</t>",0,"200 45",%MissIonID);
		case 11010011:
			OpenHelpDirectWnd("MissionDialog2ClildWndGui","3","点击接受任务",0,"-80 380",%MissIonID);
			//case 90010003:
			//	OpenHelpDirectWnd( "MissionDialogWndGui", "1", "<t></t><b/><t>点击选项</t>", 0, "200 45", %ID );
	}
}
//■■■■■■■■■■任务类对话指引界面■■■■■■■■■■■■■■■

//■■■■■■■■■■接取删除任务触发■■■■■■■■■■■■■■■■
//%optype 1 接取任务 2 删除任务
function Open_MissionZhiYin(%Mid, %optype)
{
	putout("接取删除任务触发%Mid====" @ %Mid  @ "     %optype====" @ %optype);
	//任务指引
	switch (%optype)
	{
		case 1:
			switch (%Mid)
			{
				case 10001:OpenDouFuGan(%Mid);
				case 10002:Schedule(12000, 0, "OpenDouFuGan", %Mid);
				case 10011:OpenDouFuGan(%Mid);
				case 10021:OpenDouFuGan(%Mid);
				case 10031:OpenDouFuGan(%Mid);
				case 10041:OpenDouFuGan(%Mid);
				case 10061:OpenDouFuGan(%Mid);
				case 10071:OpenDouFuGan(%Mid);
				case 10081:OpenDouFuGan(%Mid);
				case 10091:OpenDouFuGan(%Mid);
				case 10101:Schedule(19 * 1000, 0, "OpenDouFuGan", %Mid);
				case 10111:Schedule(13 * 1000, 0, "OpenDouFuGan", %Mid);
				case 10121:
					ExitConversation();//关闭交互对话
					OpenDouFuGan(12);//指引打开包裹
				case 10131:OpenDouFuGan(%Mid);
				case 10141:OpenDouFuGan(%Mid);
				case 10151:OpenDouFuGan(30);
				case 10161:OpenDouFuGan(%Mid);
				case 10162:OpenDouFuGan( %Mid );
				case 10163:OpenDouFuGan(%Mid);
				case 10231:
					%Text = "<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>二师姐传你蓬莱秘术，快快学习吧</t>";
					Dialog_OnlyOK_COVER_Content.setContent(%Text);

					Dialog_OnlyOK_COVER_OKBTN.settext("确定");
					Dialog_OnlyOK_COVER_OKBTN.command = "Dialog_OnlyOK_COVER.setVisible(0);OpenAllBag( );OpenDouFuGan( 10231 );";
					Dialog_OnlyOK_COVER.setVisible(true);
				case 10281:
					OpenAllBag();//打开包裹
					for (%i = 0; %i <= 20; %i++)
					{
						%ItemID = getword($MissionData_ItemChose[10271], %i * 2, ";");
						if (GetPlayer().Getitemcount(%ItemID) > 0)
						{
							OpenDouFuGan_AllBagWndGui(%ItemID, 4);//指引包裹内容
							break;
						}
					}
				case 10321:ExitConversation();//关闭交互对话
					Schedule(11000, 0, "OpenDouFuGan", %Mid);
				case 10361:OpenDouFuGan(%Mid);
				case 10481:OpenAllBag(); Schedule(1000, 0, "OpenDouFuGan_AllBagWndGui", 107050001, 0);//指引包裹内容
				case 10761:
					OpenKLJStrengthenByType(1);//打开强化界面
					Schedule(500, 0, "OpenAllBag");
					for (%i = 0; %i <= 20; %i++)
					{
						%ItemID = getword($Mission_Data_ItemClasses[10751], %i * 2, ";");
						if (GetPlayer().Getitemcount(%ItemID) > 0)
						{
							OpenDouFuGan_AllBagWndGui(%ItemID, 0);//指引包裹内容
							break;
						}
					}
				case 10771:
					for (%i = 0; %i <= 20; %i++)
					{
						%ItemID = getword($Mission_Data_ItemClasses[10751], %i * 2, ";");
						if (GetPlayer().Getitemcount(%ItemID) > 0)
						{
							%index = GetItem_ToBagIndex(%itemid);//客户端 搜索道具在包裹内的位置
							hintGetEquipInfo(%index);
							break;
						}
					}
				case 10781:
					OpenKLJEquipStrengGui();//鉴定界面
					Schedule(500, 0, "OpenAllBag");
					for (%i = 0; %i <= 20; %i++)
					{
						%ItemID = getword($Mission_Data_ItemClasses[10771], %i * 2, ";");
						//echo( "%ItemID====" @ %ItemID );
						if (GetPlayer().Getitemcount(%ItemID) > 0)
						{
							OpenDouFuGan_AllBagWndGui(%ItemID, 0);//指引包裹内容
							break;
						}
					}
				case 10791:
					for (%i = 0; %i <= 20; %i++)
					{
						%ItemID = getword($Mission_Data_ItemClasses[10771], %i * 2, ";");
						if (GetPlayer().Getitemcount(%ItemID) > 0)
						{
							%index = GetItem_ToBagIndex(%itemid);//客户端 搜索道具在包裹内的位置
							hintGetEquipInfo(%index);
							break;
						}
					}
				case 10811:findpath(410010141);
				default:return;
			}
		case 2:
			UpdateMissionEffect(GetPlayer(), %Mid, 1);
		default:
			return;
	}

}
//■■■■■■■■■■接取删除任务触发■■■■■■■■■■■■■■■
$ShapeFashion[1,1,1] = 102081001;			//战士时装1
$ShapeFashion[1,1,2] = 102081001;			//战士时装2
$ShapeFashion[1,1,3] = 102081022;			//战士时装3

$ShapeFashion[2,1,1] = 102081002;			//侠客时装1
$ShapeFashion[2,1,2] = 102081002;			//侠客时装2
$ShapeFashion[2,1,3] = 102081021;			//侠客时装3

$ShapeFashion[3,1,1] = 102081003;			//法师时装1
$ShapeFashion[3,1,2] = 102081003;			//法师时装2
$ShapeFashion[3,1,3] = 102081023;			//法师时装3

$ShapeFashion[4,1,1] = 102081004;			//道士时装1
$ShapeFashion[4,1,2] = 102081004;			//道士时装2
$ShapeFashion[4,1,3] = 102081025;			//道士时装3

$ShapeFashion[5,1,1] = 102081005;			//箭翎时装1
$ShapeFashion[5,1,2] = 102081005;			//箭翎时装2
$ShapeFashion[5,1,3] = 102081024;			//箭翎时装3


//■■■■■■■■■■界面按钮触发■■■■■■■■■■■■■■■■■■

function CloseHelpDirectByIndex(%index,%type)
{
	%Player = GetPlayer();

	switch (%index)
	{
		case 1://玩家点击寻径后关闭
		case 2://玩家点击交付任务选项关闭
		case 3://玩家点击完成按钮任务关闭
		case 4://玩家打开包裹后关闭
			$MissionZhiYin[10121] = %Player.IsAcceptedMission(10121);
			if ($MissionZhiYin[10121] == 1)
			{
				closeHelpDirect1_4(12);
				for (%i = 0; %i < 5; %i++)
				{
					%ItemID = 105220003 + %i * 10000;
					if (GetPlayer().Getitemcount(%ItemID) > 0)
					{
						OpenDouFuGan_AllBagWndGui(%ItemID,5);//指引包裹内容
						break;
					}
				}
			}
		case 5://玩家装备了武器后关闭

		case 6://玩家使用了系统快捷键触发
			if (%type == 0) //职业技能1
				closeHelpDirect1_4(11);
			if (%type == 1)
				closeHelpDirect1_4(1);

		case 7://玩家打开了神兽界面后关闭

		case 8://玩家给神兽加点后关闭

		case 13://玩家打开【技能界面】触发
			closeHelpDirectWndGui7_7();

		case 14://玩家点击学习技能按钮后关闭

		case 17://点击技能确定选择后关闭 --需增加

		case 18://点击学习技能按钮后关闭 --需增加

		case 23://点击技能学习按钮后关闭 --需增加

		case 42://点击包裹里中分解按钮后关闭
			if ($MissionZhiYin[10281] == 2)
			{
				closeHelpDirect1_4(16);
				for (%i = 0; %i <= 9; %i++)
				{
					%ItemID = getword($MissionData_ItemChose[10031],%i * 2,";");
					if (GetPlayer().Getitemcount(%ItemID) > 0)
					{
						OpenDouFuGan_AllBagWndGui(%ItemID,2);//指引包裹内容
						$MissionZhiYin[10281] = 3;
						break;
					}
				}
			}

		case 45://玩家打开了技能界面后关闭 --需增加
			//CloseHelpDirectWnd(3);

		case 46://玩家点击骑宠界面【骑乘】按钮触发

		case 47://玩家点击侍卫界面【侍卫】按钮触发

		case 48://玩家点击化身界面【升级】按钮触发

		case 49://玩家点击人物界面【升级】按钮触发

		case 50://玩家点击技能界面【技能升级】按钮触发

		case 51://打开【队伍】界面时触发


		case 52://打开【好友】界面时触发


		case 53://打开【财神转转转】界面时触发


		case 54://打开【衣橱】界面时触发


		case 55://打开【伏羲琴】界面时触发


		case 56://打开【炼妖壶】界面时触发


		case 57://完成一次【神兽鉴定】时触发


		case 58://成功学习任意一种【生活技能】时触发


		case 59://打开【战斗助手】界面时触发


		case 60://成功分解一件装备时触发
			if ($MissionZhiYin[10281] == 3)
			{
				//CloseAllBag( );
				closeHelpDirect1_4(0);
				$MissionZhiYin[10281] = 0;
			}

		case 61://打开【轩辕剑】界面时触发


		case 62://完成一次【装备进阶】时触发


		case 63://进行一次【化神变身】时触发


		case 64://打开【随身商店】界面时触发


		case 65://打开【呼朋唤友】界面时触发


		case 66://打开【排行榜】界面时触发


		case 67://在华山论剑中完成一次【挑战】


		case 68://进入一次【汤泉宫】地图


		case 69://加入一个【帮派】


		case 70://打开【天劫】界面时触发


		case 71://参加一次时空裂痕活动


		case 72://完成一次圣地尽忠任务


		case 73://获得一只40级可携带的神兽


		case 74://参加一次藏宝图活动


		case 75://完成一次西天取经活动


		case 76://参加一次科举活动


		case 77://参加一次邪王墓活动


		case 78://参加一次杨公宝库活动


		case 79://参加一次十八路反王活动


		case 80://参加一次倭寇入侵活动


		case 81://进入一次决战中原战场


		case 82://进入一次三大瓦岗寨副本


		case 83://打开【经脉】界面时触发


		case 84://获得一只65级可携带的神兽


		case 85: //CloseHelpDirectWnd(1); //点击善恶按钮后关闭

		case 86://进入一次虎牢关之战副本


		case 87://进入一次中日第一战副本


		case 88://完成一次六道轮回


		case 89://打开【女娲石】界面时触发


		case 90://打开【武魂】界面时触发


		case 91://点击【包裹】关闭按钮触发
			//关闭指引豆腐干
			closeHelpDirect1_4(5);
			if ($MissionZhiYin[10032] == 2)
			{
				//if ( !KLPlayerInfoGui.Isvisible( ) )//打开人物属性界面
				//{
				//	OpenKLPlayerInfoGui( );
				//	CloseNewFunctionTipFlash( 1, 0 );
				//}
				//$MissionZhiYin[ 10032 ] = 3;
				OpenDouFuGan(10032);
			}
		case 92://点击【人物】关闭按钮触发
			if ($MissionZhiYin[10032] == 4)
			{
				OpenDouFuGan(10032);
				$MissionZhiYin[10032] = 0;
			}
		case 93://点击【装备绑定】确认按钮触发

		case 94://点击【强化】关闭按钮触发

		case 95:
			//【宠物鉴定界面】宠物放入后触发1

		case 96:
			//【宠物鉴定界面】点击鉴定后触发


		case 97:
			//【宠物强化界面】点击进阶触发

		case 98://【筋脉图】点击冲穴按钮触发

		case 99://【筋脉图】点击任脉按钮触发

		case 100://【筋脉图】点击肩贞穴按钮触发

		case 101://【化神】点击激活、升级触发
			//激活触发
		case 102://【强化界面】装备打孔按钮触发

		case 103://【强化界面】天珠镶嵌切页按钮触发

		case 104://【强化界面】天珠放入后按钮触发

		case 105://【强化界面】镶嵌天珠按钮触发

		case 106://【强化界面】碎片合成树状1触发

		case 107://【强化界面】碎片合成树状2触发

		case 108://【强化界面】合成天珠按钮触发

		case 109://【挂机界面】点击打开触发

		case 111://【挂机】开启、关闭触发

		case 112://【神兽界面】点击召唤成功后触发

		case 113://【神兽界面】点击关闭触发

		case 114://【神兽界面】点击强化触发

		case 115:// 【挂机界面】点击开触发
			closeHelpDirect1_4(3);
		case 116:// 鉴定后触发
			//switch ( %type )
			//{
			//	case 8:OpenAllBag( );
			//	case 11:OpenAllBag( );
			//}
			
		case 117://强化触发
			
	}
}
//■■■■■■■■■■界面按钮触发■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■任务旗标满足交付条件时触发■■■■■■■■■■■
function GotoFinishMissIonpath(%Mid)//
{
	switch (%Mid)
	{
		case 10011:
			SetCombatAssistant(0); Schedule(300,0,"findpath",410100012);
			OpenDouFuGan(%Mid);
		case 10021:OpenDouFuGan(%Mid);
		case 10061:
			%Text = "<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>这是何物？还是回去找人问问清楚吧</t>";
			Dialog_OnlyOK_COVER_Content.setContent( %Text );
			Dialog_OnlyOK_COVER_OKBTN.settext( "确定" );
			Dialog_OnlyOK_COVER_OKBTN.command = "Dialog_OnlyOK_COVER.setVisible(0);findpath(410100018);";
			Dialog_OnlyOK_COVER.setVisible( true );
		case 10091:OpenDouFuGan(%Mid);
		case 10121:CloseAllBag( ); OpenDouFuGan( 13 ); OpenDouFuGan( %Mid );
		case 10141:OpenDouFuGan( %Mid );
		case 10151:OpenDouFuGan( %Mid );
		case 10163:OpenDouFuGan( %Mid );
		case 10171:OpenDouFuGan( %Mid );
		case 10191:ExitConversation();findpath(410100062);
		case 10231:CloseAllBag(); OpenDouFuGan(17);
		case 10221:CloseAllBag();
		case 10032:
			OpenAllBag();//打开包裹
			for (%i = 0; %i <= 9; %i++)
			{
				%ItemID = getword($MissionData_ItemChose[10031],%i * 2,";");
				//echo( "%ItemID====" @ %ItemID );
				if (GetPlayer().Getitemcount(%ItemID) > 0)
				{
					OpenDouFuGan_AllBagWndGui(%ItemID,4);//指引包裹内容
					break;
				}
			}
		case 10821:findpath( 410010113 );
		case 11022:
			//echo( "===========11022" );
			%Text = "<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>此处怨气太重，感觉力量被压制了，看来没有游仙符箓是待不下去了</t>";
			Dialog_OnlyOK_COVER_Content.setContent(%Text);
			Dialog_OnlyOK_COVER_OKBTN.settext("确定");
			Dialog_OnlyOK_COVER_OKBTN.command = "Dialog_OnlyOK_COVER.setVisible(0);findpath( 411280101 );";
			Dialog_OnlyOK_COVER.setVisible(true);

		default:return;
	}
	//SetCombatAssistant( false );//停止挂机
	//findpath( GetMissionData( %Mid, $Mission_Data_NpcZ ) );
}
//■■■■■■■■■■任务旗标满足交付条件时触发■■■■■■■■■■■■



//■■■■■■■■■■豆腐干打开内容相关■■■■■■■■■■■■■■■
function OpenHelpDirectWnd(%aimCtrl,%type,%Txt,%Time,%OffsetXY,%Index)
{
	Cancel($HelpDirectID[%Index]);
	//	echo( "%Index===" @ %Index @ "    %type===" @ %type );
	closeHelpDirect1_4(%Index);

	//	//是否提示
	//	if($bGCancelHelpDirect || !isobject(%aimCtrl))
	//		return;

	//创建新控件
	GuiHelpDirectWndGui1(%Index,%type);

	//设置控件文字
	if (%type <= 4)
		%Tab = "<t f='黑体' m='0' n='16' b='1' h='1' gct='0xffff00ff' gcb='0xd9680dff'>";
	("Mini_TimerTriggerCtrl_HelpWnd_1_" @ %Index).setContent(%Tab @ %Txt @ "</t>");

	//获取绑定控件位置
	%aimCtrlPos = %aimCtrl.GetPosition();

	//获取控件需要设置位置
	%NewPosX = GetWord(%aimCtrlPos,0) + GetWord(%OffsetXY,0);
	%NewPosY = GetWord(%aimCtrlPos,1) + GetWord(%OffsetXY,1);

	//设置控件位置
	("Mini_TimerTriggerCtrl_HelpWnd_" @ %Index).setPosition(%NewPosX,%NewPosY);
	GameMainWndGui_Layer4.pushtoback("Mini_TimerTriggerCtrl_HelpWnd_" @ %Index);

	//绑定控件
	//echo("%aimCtrl===" @ %aimCtrl @ "    %Index===" @ %Index @ "    " @ ("Mini_TimerTriggerCtrl_HelpWnd_" @ %Index).getId());
	%aimCtrl.addStickControl(("Mini_TimerTriggerCtrl_HelpWnd_" @ %Index).getId());

	//设置界面开关
	if (%aimCtrl.IsVisible())
		("Mini_TimerTriggerCtrl_HelpWnd_" @ %Index).setVisible(1);

	//echo( "豆腐干位置===" @( "Mini_TimerTriggerCtrl_HelpWnd_" @ %Index.getposition( ) ));
	//echo( "%NewPosX===" @ %NewPosX @ "%NewPosY====" @ %NewPosY );
	if (%Time > 0)
		$HelpDirectID[%Index] = Schedule(%Time,0,"closeHelpDirect1_4",%Index);
}
//■■■■■■■■■■豆腐干打开内容相关■■■■■■■■■■■■■■■


//■■■■■■■■■■豆腐干创建控件相关■■■■■■■■■■■■■■■
function GuiHelpDirectWndGui1(%i,%type)
{
	// OpenHelpDirectWnd( "AllBagWndGui", "4", "点击关闭", 0, "250 -60", 1 );
	if (%type == 1) { %bitmap = "gameres/gui/images/GUIWindow81_1_064.png"; %Extent = "166 53"; %Extent1 = "100 40"; %position1 = "53 20"; }
	if (%type == 2) { %bitmap = "gameres/gui/images/GUIWindow81_1_065.png"; %Extent = "120 97"; %Extent1 = "100 40"; %position1 = "10 18"; }
	if (%type == 3) { %bitmap = "gameres/gui/images/GUIWindow81_1_066.png"; %Extent = "166 53"; %Extent1 = "100 40"; %position1 = "10 18"; }
	if (%type == 4) { %bitmap = "gameres/gui/images/GUIWindow81_1_067.png"; %Extent = "120 97"; %Extent1 = "100 40"; %position1 = "10 63"; }

	if (%type == 5) { %bitmap = "gameres/gui/images/GUIWindow81_1_068.png"; %Extent = "240 169"; %Extent1 = "180 90"; %position1 = "30 50"; %position2 = "80 130"; }//大图片指引 上
	if (%type == 6) { %bitmap = "gameres/gui/images/GUIWindow81_1_069.png"; %Extent = "240 169"; %Extent1 = "180 90"; %position1 = "30 10"; %position2 = "80 90"; }//大图片指引 下
	if (%type == 7) { %bitmap = "gameres/gui/images/GUIWindow81_1_070.png"; %Extent = "280 130"; %Extent1 = "180 90"; %position1 = "30 10"; %position2 = "80 90"; }//大图片指引 右
	if (%type == 8) { %bitmap = "gameres/gui/images/GUIWindow81_1_071.png"; %Extent = "280 130"; %Extent1 = "180 90"; %position1 = "70 10"; %position2 = "120 90"; }//大图片指引 左

	//echo( "%type===" @ %type @ "    %i====" @ %i );
	new GuiMoveBitmapCtrl("Mini_TimerTriggerCtrl_HelpWnd_" @ %i){
		canSaveDynamicFields = "0";
		Enabled = "1";
		isContainer = "0";
		Profile = "GuiModelessDialogProfile";
		HorizSizing = "left";
		VertSizing = "top";
		position = "200 200";
		Extent = %Extent;
		MinExtent = "8 2";
		canSave = "1";
		Visible = "0";
		mustPrerender = "0";
		tooltipWidth = "100";
		hovertime = "1000";
		alpha = "255";
		useFadeout = "0";
		bitmap = %bitmap;
		wrap = "0";
		MoveSpeed = "0";
		IsMove = "0";
		IsXDirection = "0";
		IsYDirection = "0";
		MoveType = "1";
		UpdateTime = "100";

		new GuiRichTextCtrl("Mini_TimerTriggerCtrl_HelpWnd_1_" @ %i)
		{
			hovertime = "1000";
			HorizSizing = "left";
			VertSizing = "bottom";
			position = %position1;
			Extent = %Extent1;
			Visible = "1";
		};
	};
	GameMainWndGui_Layer4.add("Mini_TimerTriggerCtrl_HelpWnd_" @ %i);
	if (%type > 4)
	{
		new GuiButtonCtrl("Mini_TimerTriggerCtrl_HelpWnd_2_" @ %i){
			canSaveDynamicFields = "0";
			Enabled = "1";
			isContainer = "0";
			Profile = "TimerTriggerCtrlHelpButtonProfile";
			position = %position2;
			Extent = "76 25";
			Visible = "1";
			HorizSizing = "right";
			VertSizing = "bottom";
			MinExtent = "8 2";
			canSave = "1";
			Visible = "1";
			mustPrerender = "0";
			Command = "closeHelpDirect1_4(" @ %i @ ");";
			hovertime = "1000";
			groupNum = "1";
			buttonType = "PushButton";
			useMouseEvents = "0";
			text = "我知道了";
			IsStateOn = "0";
		};
		("Mini_TimerTriggerCtrl_HelpWnd_" @ %i).add("Mini_TimerTriggerCtrl_HelpWnd_2_" @ %i);
	}
}
//OpenHelpDirectWnd( "MissionDialog2ClildWndGui", "6", "<t>选择一件武器</t><b/><t>选择一件武器</t><b/><t>选择一件武器</t><b/><t>选择一件武器</t>", 0, "180 300",10031);
//Mini_TimerTriggerCtrl_HelpWnd_1_10031.setcontent( "<t>撒打算大所大所多撒打算打打撒打算大所大所多撒所多撒打算打打撒打算大所大所多撒打算打打</t>" );
//Mini_TimerTriggerCtrl_HelpWnd_1_10031.setposition( 30, 70 );
//■■■■■■■■■■豆腐干创建控件相关■■■■■■■■■■■■■■■


//■■■■■■■■■■豆腐干关闭相关触发■■■■■■■■■■■■■■■
function closeHelpDirect1_4(%Index)
{
	//echo( "豆腐干关闭相关触发 === " @  %Index );
	if (!isobject(("Mini_TimerTriggerCtrl_HelpWnd_" @ %Index)))
		return;
	("Mini_TimerTriggerCtrl_HelpWnd_" @ %Index).setVisible(0);

	("Mini_TimerTriggerCtrl_HelpWnd_" @ %Index).delete();
}

function For_closeHelpDirect()
{
	//遍历玩家所有已接任务，将添加到树列表
	%Player = GetPlayer();
	%AcceptCountNum = %Player.GetAcceptedMission();
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = %Player.GetMission(%i);
		if (("Mini_TimerTriggerCtrl_HelpWnd_" @ %Mid).isVisible() == 1)
		{
			closeHelpDirect1_4(%Mid);
			return;
		}
	}
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = %Player.GetMission(%i);
		//是否需要寻路指引
		For_OpenHelpDirect(%Mid,GetMissionData(%Mid,$Mission_Data_Type),GetMissionData(%Mid,$Mission_Data_Map_Area));
	}
}
function For_OpenHelpDirect(%Mid,%Mission_Data_Type,%Mission_Data_Map_Area)
{
	if (%Mission_Data_Type == 1 &&  %Mission_Data_Map_Area  $= "810100100")
		OpenDouFuGan(%Mid);
}
//■■■■■■■■■■豆腐干关闭相关触发■■■■■■■■■■■■■■■

//■■■■■■■■■■豆腐干指向包裹内容■■■■■■■■■■■■■■■
//OpenDouFuGan_AllBagWndGui(102013293,0);
function OpenDouFuGan_AllBagWndGui(%Item,%Txt)
{
	//如果参数小于100
	if (strlen(%Item) <= 3)
		%ItemIndex = %Item;

	else //获取包裹位置
		%ItemIndex = GetItem_ToBagIndex(%Item);

	if (%ItemIndex == -1)
		return;

	%PositionX = 1;
	%PositionY = mceil(%ItemIndex/8 - 7)*44;

	ChatWnd_ShowMessage_scroll.setScrollPosition(%PositionX, %PositionY);
	//echo("豆腐干指向包裹内容===" @  %Item  @ "   " @ %txt);
	//if ( %ItemIndex < 40 ) ChooseTabItem( 0 );
	//else if ( %ItemIndex < 80 ){ ChooseTabItem( 1 ); %ItemIndex = %ItemIndex - 40; }
	//else { ChooseTabItem( 3 ); %ItemIndex = %ItemIndex - 80; }
	//echo( "%ItemIndex===" @ %ItemIndex );
	//设置包裹位置特效
	TimeHintEquipInfo(%ItemIndex);

	//设置后续
	$SendCurUsingItemId[%Item] = 1;

	//豆腐干位置
	%Hang = mfloor(%ItemIndex / 8);
	%Lie = %ItemIndex%8;
	if (%Hang >= 7)
		%Hang = 6;

	%x = -20 + (45 * %Lie);
	%y = -10 + (44 * %Hang);

	//echo("豆腐干指向包裹内容%ItemIndex=== " @ %ItemIndex);
	//echo("豆腐干指向包裹内容%Hang=== " @ %Hang);
	//echo("豆腐干指向包裹内容%Lie=== " @ %Lie);
	//echo("豆腐干指向包裹内容%x=== " @ %x);
	//echo("豆腐干指向包裹内容%y=== " @ %y);

	%Format_Black  = $Get_Dialog_GeShi[31200];	//黑色字体

	if (%Txt == 0) %Txt = "右键点击";
	else if (%Txt == 1) %Txt = "左键鉴定";
	else if (%Txt == 2) %Txt = "左键分解";
	else if (%Txt == 3) %Txt = "左键拖动";
	else if (%Txt == 4) %Txt = "右键装备武器";
	else if (%Txt == 5) %Txt = "右键学习技能";

	OpenHelpDirectWnd("AllBagWndGui",2,%Txt,0,%x @ " " @ %y,0);
}
//■■■■■■■■■■豆腐干指向包裹内容■■■■■■■■■■■■■■■
//35级指引界面
function SelectKLJMissionGuidanceGuiBtn(%Type)
{
	switch (%Type)
	{
		case 1://主线
			CloseKLJMissionGuidanceGui();//关闭界面
			findpath(411200001);//寻径NPC
		case 2://冰火试炼
			CloseKLJMissionGuidanceGui();
			findpath(411200001);
		case 3://生活技能
			CloseKLJMissionGuidanceGui();
			findpath(410010144);

	}
}
function PengLaiDaoJing_ChuFa()//使用道果
{
	clearVocalStatus( );//打断采集
	%Text = "<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>欲速则不达，修行之事还需要循序渐进慢慢来，获得道果一枚</t>";
	Dialog_OnlyOK_COVER_Content.setContent( %Text );

	Dialog_OnlyOK_COVER_OKBTN.settext("确定");
	Dialog_OnlyOK_COVER_OKBTN.command = "Dialog_OnlyOK_COVER.setVisible(0);OpenAllBag( );OpenDouFuGan_AllBagWndGui( 108021019, 0 );";
	Dialog_OnlyOK_COVER.setVisible(true);
}
function ZiDongZhanDou_ZhiYin()//自动战斗
{
	FightAssistantBnt_skillshortcut.setStateOn(1);
	ShowHideFightAssistantSkillShortcutWnd();

	%Tab1 = "<t f='楷体_GB2312' m='0' n='16' c='0xffffffff' o='0x000000ff'>";//白色正文
	%Tab3 = "<t f='楷体_GB2312' m='0' n='16' c='0xff00ffff' o='0x000000ff'>";//紫色提示
	%text = %Tab1 @ "					使用快键键</t><b/>" @ %Tab3 @ "	      “ Z ”</t><b/>" @ %Tab1 @ "	可打开战斗助手界面</t>";
	Dialog_OnlyOK.setVisible(true);
	Dialog_OnlyOK_Content.setContent(%text);
	Dialog_OnlyOK.OnReSize();
	Dialog_OnlyOK.SetOk("");
	Dialog_OnlyOK_OKBTN.command = "Dialog_OnlyOK.setvisible(false);OpenCloseFightAssistantWnd();OpenDouFuGan( 24 );";
}

function KLJRecommendatorySettingBase_2()
{
	if (GetPlayer().IsAcceptedMission(10341))
	{
		closeHelpDirect1_4(24);
		OpenDouFuGan(22);
	}
}
function KLJApplyFightAssistantBase_2()
{
	if (GetPlayer().IsAcceptedMission(10341) >= 1 && $MissionZhiYin[10341] != 1)
	{
		CloseFightAssistantWnd();
		closeHelpDirect1_4(22);
		OpenDouFuGan(3);
		$MissionZhiYin[10341] = 1;
	}
}


//■■■■■■■■■■挂机界面推荐技能组合■■■■■■■■■■■■■■
function AddFightAssistantSkill()
{
	%Player = GetPlayer();
	%Classes = %Player.GetClasses(0);
	%Level = %Player.GetLevel();
	switch (%Classes)
	{
		case 1://战士
			%SkillID[0] = 21014; %SkillTime[0] = 13;//无灭袭
			%SkillID[1] = 21010; %SkillTime[1] = 8;//狮子吼
			%SkillID[2] = 21004; %SkillTime[2] = 6;//回旋斩
			%SkillID[3] = 21002; %SkillTime[3] = 3;//半月斩
			%SkillID[4] = 21003; %SkillTime[4] = 3;//裂地斩
			%SkillID[5] = 21001; %SkillTime[5] = 2;//袭风刺
		case 3://法师
			%SkillID[0] = 23007; %SkillTime[0] = 55;//护身爵
			%SkillID[1] = 23003; %SkillTime[1] = 4;	//火墙术
			%SkillID[2] = 23010; %SkillTime[2] = 18;//星辰诀
			%SkillID[3] = 23006; %SkillTime[3] = 5;	//龙卷风术
			%SkillID[4] = 23002; %SkillTime[4] = 3;	//落雷术
			%SkillID[5] = 23001; %SkillTime[5] = 2;	//火焰术
		case 4://道士
			%SkillID[0] = 24007; %SkillTime[0] = 55;//真元护体
			%SkillID[1] = 24013; %SkillTime[1] = 28;//落英缤纷
			%SkillID[2] = 24003; %SkillTime[2] = 6;//诅咒
			%SkillID[3] = 24006; %SkillTime[3] = 4;//灵魂符咒
			%SkillID[4] = 24002; %SkillTime[4] = 3;//陨星咒
			%SkillID[5] = 24001; %SkillTime[5] = 2;//寒冰咒
	}
	for (%i = 0; %i < 6; %i++)
	{
		("FightAssistantShortCut_Skill" @ %i).setContentId(0);
		("FightAssistantText_FireTime" @ %i).setText("");
	}
	%AssistantPos = 0;
	for (%i = 0; %i < 6; %i++)
	{
		if (%SkillID[%i] > 0 && %Player.GetSkillLevel(%SkillID[%i]) >= 1)
		{
			putout("挂机界面技能组合%AssistantPos===" @ %AssistantPos);
			%Skill = %SkillID[%i] * 10000 + %Player.GetSkillLevel(%SkillID[%i]);
			("FightAssistantShortCut_Skill" @ %AssistantPos).setContentId(%Skill);
			("FightAssistantText_FireTime" @ %AssistantPos).setText(%SkillTime[%i]);
			%AssistantPos++;
		}
		Ai_SetSpell(%i,true,("FightAssistantText_FireTime" @ %i).getText(),("FightAssistantShortCut_Skill" @ %i).getContentId());
	}
}
//■■■■■■■■■■挂机界面推荐技能组合■■■■■■■■■■■■■■


function OnOpenePKState(%mode)
{
	//echo("=================================有人在偷偷切换PK模式==================================" @  %mode);
	%player = getPlayer();
	%MapAreaName=getCurrentZoneArea();
	switch (%mode)
	{
		case 0:
			if (%player.canSwitchPKState(0,1) != 1)
			{
				SetPKModeBtnState($g_OldSelectMode);
				return;
			}
			//PKStateDescribe.setText("和平");
			//PK_bmp.setbitmap("gameres/gui/images/KLJ_PlayerIconPKHP.png");
			PKOpenButton_1.setProfile("TargetIconGuiWndProfileBtn_12");
			//PKStateDescribe.setColor(06,255,12);
			%player.setGEState(0);
			%player.setPKState(0);
		case 1:
			if (%player.canSwitchPKState(1,1) != 1)
			{
				SetPKModeBtnState($g_OldSelectMode);
				return;
			}
			//PKStateDescribe.setText("善恶");
			//PK_bmp.setbitmap("gameres/gui/images/KLJ_PlayerIconPKSE.png");
			PKOpenButton_1.setProfile("TargetIconGuiWndProfileBtn_18");
			//PKStateDescribe.setColor(03,216,255);
			%player.setGEState(1);
		case 2:
			//需要判断是否成功切换宣战模式的函数
			if (%player.canSwitchPKState(1,1) != 1)
			{
				SetPKModeBtnState($g_OldSelectMode);
				return;
			}
			//PKStateDescribe.setText("善恶");
			//PK_bmp.setbitmap("gameres/gui/images/KLJ_PlayerIconPKSL.png");
			PKOpenButton_1.setProfile("TargetIconGuiWndProfileBtn_17");
			//PKStateDescribe.setColor(255,0,0);
			%player.setPKState(1);
	}
	setPkCheckState(%mode+1);
}
