
//■■■■■■■■■■■客户端通讯调用脚本【新】■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■客户端收集服务端传送的字符串触发■■■■■■■■■■■■■
//■■■■■■■■■■■客户端收讯息脚本■■■■■■■■■■■■■■■■■■■■■




//■■■■■■■■■■■客户端通讯调用脚本【新】■■■■■■■■■■■■■■■■■
//ServerOnSptAction( %Player.GetPlayerID( ), %Type, %Subtype );   %Type为传递数值，%SubType为switch判断条件值
function OnSptActionEvent_C(%Type,%Subtype)
{
	%Player = GetPlayer();
	%MapID = GetSubStr(GetZoneid(),0,4);
	switch (%Subtype)
	{
		case 1://开启包裹并指向对应道具
			OpenAllBag();
			OpenDouFuGan_AllBagWndGui(%Type,0);
		case 2:
			Set_ShopWnd_NpcZHJM(%Type);
		case 3://接任务处理
			Open_MissionZhiYin(%Type,1);
		case 4://删除任务处理
			Open_MissionZhiYin(%Type,2);
		case 5:
			OpenDouFuGan(1);
		case 6:
			OpenDouFuGan(2);
		case 7:
			//echo("%Type===" @ %Type);
			if (%Type == 51 || %Type == 52)
				%number = 20;
			else if (%Type == 55 || %Type == 54 || %Type == 53)
				%number = 50;
			else 
				%number = 0;
			if (%number > 0)
			{
				if (getranklevel(%number - 1) <50)
				{
					SetScreenMessage("需要排行榜第" @ %number @ "名的玩家达到50级以上，才可以接此镖", 0xff0000);
					SetChatMessage("需要排行榜第" @ %number @ "名的玩家达到50级以上，才可以接此镖。", $Color[2], $chatMsg_System);
					return;
				}
			}
			%Text = "<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>  押送本趟镖车，需要上缴押金</t><b/>" @
				"<t m ='0' f='黑体' n='14' c='0xff00ffff' v='1'>" @ "<t>          </t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold["6000000" @ %Type],2)) @ "</t><b/>" @
				"<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>      是否确定押镖？</t>";
			Dialog_OK_Cancel.setContent(%Text);
			Dialog_OK_Cancel.setOk("确定","ClientOnSptAction( 13, 0 );");//通讯服务端
			Dialog_OK_Cancel.SetCancel("取消","");
			Dialog_OK_Cancel.setVisible(1);
		case 8:
			$JuBaoPengMoney = %Type;
			JuBaoPengShowMoney(10);
			schedule(3000,0,"UpdateCornucopiaWnd");
		case 9:
			SetUpLineParty($UpLinePartyWndRecord);
		case 10:
			$ChioseLevelGiftRecord++;
			if ($ChioseLevelGiftRecord > 6)
				SetUpLineParty($UpLinePartyWndRecord);
			else
			{
				UpLineLevelGiftCommand($ChioseLevelGiftRecord);
				("UpLineLevelGift_Button_" @ $ChioseLevelGiftRecord).setStateOn(1);
			}
			$UpLineLevelGiftCommandSetItem = 0;
		case 11:
			SetUpLineParty($UpLinePartyWndRecord);
		case 12:
			%Text = "<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>开启元神悟道，需要扣除 </t>" @
				"<t m ='0' f='黑体' n='14' c='0xff00ffff' v='1'>" @ %Type @ " </t>" @
				"<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>元宝，是否确定开启？</t>";
			Dialog_OK_Cancel.setContent(%Text);
			Dialog_OK_Cancel.setOk("确定","ClientOnSptAction( 19, 0 );");//通讯服务端
			Dialog_OK_Cancel.SetCancel("取消","");
			Dialog_OK_Cancel.setVisible(1);
		case 13://首座论经
			%Triggerid = %Player.Gettriggerid();
			if (%Triggerid != 810100114 && %Triggerid != 810100108 && %Triggerid != 810100107)
				return;
			//echo( "%Type==========" @ %Type );
			switch (%Type)
			{
				case 7777:
					SetBaJieCaiCaiCaiPloyGUIResult(1,1000,500,100);// 答对了
				case 8888:
					SetBaJieCaiCaiCaiPloyGUIResult(0,1000,500,100); //答错了
				default:
					%Question = %Type%1000;
					%bReversed = mfloor(%Type/1000);
					%strQuestion = $HuoDong_BJCCC_Q[%Question];
					//echo( "%Question==========" @ %Question );
					//echo( "%bReversed==========" @ %bReversed );
					//echo( "%strQuestion==========" @ %strQuestion );
					if (%bReversed == 2)//是非颠倒
						%Yes = 0;
					else
						%Yes = 1;
					OpenBaJieCaiCaiCaiPloyWndGui(%Yes,%Question);
			}
		case 14://打开生活技能界面
			UI_OpenKLJLifeSkillWnd(%Type);
		case 15:
			SetTextForXuanShangJiXiongWnd();//刷新悬赏缉凶界面
		case 16:
			//echo( "%Type ===========" @ %Type );
			switch (%Type)
			{
				case 1:%Nmae = "玄武";
				case 2:%Nmae = "青龙";
				case 3:%Nmae = "朱雀";
				case 4:%Nmae = "白虎";
			}
			%Text = "<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>前往 </t>" @
				"<t m ='0' f='黑体' n='14' c='0xff00ffff' v='1'>" @ %Nmae @ " </t><t>传送阵，挑战心魔</t>" @
				"<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>（踏错传送门，本次副本即失败）</t>";
			Dialog_OK_Cancel.setContent(%Text);
			Dialog_OK_Cancel.setOk("确定","");//通讯服务端
			Dialog_OK_Cancel.SetCancel("取消","");
			Dialog_OK_Cancel.setVisible(1);
		case 17://切换地图、登录时客户端触发
			SvrEventTransporClient(%Player,%Type);
		case 18://黄金宝藏的通讯
			echo("%Type ===黄金宝藏的通讯========" @ %Type);
			switch (%Type)
			{
				case 1:%Nmae = "玄武";
				case 2:%Nmae = "青龙";
				case 3:%Nmae = "朱雀";
				case 4:%Nmae = "白虎";
			}
			%Text = "<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>前往 </t>" @
				"<t m ='0' f='黑体' n='14' c='0xff00ffff' v='1'>" @ %Nmae @ " </t><t>传送阵</t>" @
				"<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>（踏错传送门，本次副本即失败）</t>";
			Dialog_OK_Cancel.setContent(%Text);
			Dialog_OK_Cancel.setOk("确定","");//通讯服务端
			Dialog_OK_Cancel.SetCancel("取消","");
			Dialog_OK_Cancel.setVisible(1);
		case 19:
			switch (%Type)
			{
				case 1://帮派创建
					OpenKLJFaction_CreatorWnd();
				case 2://帮派升级
					%Text = "<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>本次帮派升级需要 </t>" @ "<l i='105105303' t='itemid'/>" @ "<t>* 10，是否确定升级帮派</t>";
					Dialog_OK_Cancel.setContent("<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>" @ %Text @ "</t>");
					Dialog_OK_Cancel.setOk("确定","ClientOnSptAction( 22, 2 );");//通讯服务端
					Dialog_OK_Cancel.SetCancel("取消","");
					Dialog_OK_Cancel.setVisible(1);
				case 3://帮派升级
					%Text = "<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>本次帮派升级需要 </t>" @ "<l i='105105304' t='itemid'/>" @ "<t>* 10，是否确定升级帮派</t>";
					Dialog_OK_Cancel.setContent("<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>" @ %Text @ "</t>");
					Dialog_OK_Cancel.setOk("确定","ClientOnSptAction( 22, 3 );");//通讯服务端
					Dialog_OK_Cancel.SetCancel("取消","");
					Dialog_OK_Cancel.setVisible(1);
				case 4://帮派升级
					%Text = "<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>本次帮派升级需要 </t>" @ "<l i='105105304' t='itemid'/>" @ "<t>* 50 </t> " @ "<l i='105105305' t='itemid'/>" @ "<t>* 1，是否确定升级帮派</t>";
					Dialog_OK_Cancel.setContent("<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>" @ %Text @ "</t>");
					Dialog_OK_Cancel.setOk("确定","ClientOnSptAction( 22, 4 );");//通讯服务端
					Dialog_OK_Cancel.SetCancel("取消","");
					Dialog_OK_Cancel.setVisible(1);
				case 5://帮派升级
					%Text = "<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>本次帮派升级需要 </t>" @ "<l i='105105304' t='itemid'/>" @ "<t>* 100 </t> " @ "<l i='105105305' t='itemid'/>" @ "<t>* 10，是否确定升级帮派</t>";
					Dialog_OK_Cancel.setContent("<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>" @ %Text @ "</t>");
					Dialog_OK_Cancel.setOk("确定","ClientOnSptAction( 22, 5 );");//通讯服务端
					Dialog_OK_Cancel.SetCancel("取消","");
					Dialog_OK_Cancel.setVisible(1);
				case 6:
				case 666://查询帮派
					Org_Query(1);
			}
		case 20://刷新充值礼包界面
			echo("刷新充值礼包界面 ====" @ %type);
			RefreshChargeGiftWnd(%type);
		case 21://副本内使用随机卷轴的判断
			echo("TYpe ==============" @ %type);
			%Text = "<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>您当前在副本内，是否确定使用回城卷 </t>";
			Dialog_OK_Cancel.setContent("<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>" @ %Text @ "</t>");
			Dialog_OK_Cancel.setOk("确定","ClientOnSptAction( 28," @  %Type @ ");");//通讯服务端
			Dialog_OK_Cancel.SetCancel("取消","");
			Dialog_OK_Cancel.setVisible(1);
		
		case 22:	//更新限时抢购界面显示
			ShowFlashSalePageNum(%type);

	}
}

//
//■■■■■■■■■■■客户端通讯调用脚本【新】■■■■■■■■■■■■■■■■■



//■■■■■■■■■■■客户端收集服务端传送的字符串触发■■■■■■■■■■■■■
//%Player.SendPlayerString(1000, "111111111", 0);
function ReceivePlayerString(%ID,%text,%Player)
{
	%Player = GetPlayer();
	
	switch (%ID)
	{
		case 1:

		case 2:
			//echo( "%text================"  @ %text );
			Getallactivitybactive(%text);
			ScheduleSetMainbtnBlink();//刷新按钮特效
		case 3://炼魔渊副本客户端界面触发
			LianMoYuanFuBenTongJiWnd(%Player,%Text);
		case 4://时空裂痕副本客户端界面显示
			ShiKongLieHenFuBenTongJiWnd(%Player,%Text);
		case 5://血魔封印阵副本客户端界面显示
			XueMoFengYinZhenFuBenTongJiWnd(%Player,%Text);
		case 6://幻境争霸副本客户端界面显示
			HuanJingZhengBaFuBenTongJiWnd(%Player,%Text);
		case 7://鸿蒙试炼副本客户端界面显示
			YunXianJieDaTaoShaFuBenTongJiWnd(%Player,%Text);
		case 8://刀剑神域副本客户端界面显示
			DaoJianShenYuFuBenTongJiWnd(%Player,%Text);
		case 9:
			Rise_ConfirmDlg(GetWord(%Text,0),GetWord(%Text,1),GetWord(%Text,2),60);
		case 10://运营活动的配置开关1
			$SL_YunYingHuoDong1 = %text;
		case 11://界面开关配置
			GetAllWndNeedOpen(%Text);
		case 12://运营活动的配置开关2
			$SL_YunYingHuoDong2 = %text;
			Schedule(3000, 0, "SetAllYunYingbActive");
		
		case 13:	//限时抢购在线更新
			analysisXianShiQiangGouReceiveInfo(%text);
		
		//角色上线时客户端接收限时抢购的物品库存
		case 14:
			XianShiQiangGou_ReceiveClientKuCunNum(%text);
		
		//角色购买限时商店物品时客户端接收限时抢购的物品库存
		case 15:
			%shopID = GetWord(%text,0);
			%index  = GetWord(%text,1);
			%KuCun  = GetWord(%text,2);
			%SelfCnt = GetWord(%text,3);
			$XianShiQiangGou_ItemKuCun[$CurrentLineId, %shopID, %index] = %KuCun;
	}
}

//■■■■■■■■■■■客户端收集服务端传送的字符串触发■■■■■■■■■■■■■


//■■■■■■■■■■■客户端收讯息脚本■■■■■■■■■■■■■■■■■■■■
//HelpDirectByIndex
function ShowHelpDirectByIndex(%index)
{
	%Player = GetPlayer();

	//指引标识相关
	//OpenHelpDirectWnd(%aimCtrl,%type,%Horiz,%Vert,%txt,%time,偏移)
	//%aimCtrl(要指向的控件名)
	//%type(1 箭头左上  2 箭头右上 3 箭头右下 4 箭头左下)
	//%Horiz (1 左偏移 2中  3右偏移)
	//%Vert(1 上偏移 2中  3下偏移)
	//%txt(要显示的内容,支持带解析)
	//%time(关闭界面的时间,0为不关闭)
	//偏移，正数向下，负数向上
	//例:OpenHelpDirectWnd("PlayerIconGui",1,3,3,"这里是显示个人信息的地方",8000);
	//人物图像 -> ""PlayerIconGui""
	//队友图像 -> ""TeammateIconGui""
	//神兽图像 -> ""PetIconGui""
	//目标图像 ->  ""TargetPlayerIconGui""
	//底部控制栏-> ""BottomControlWndGui""
	//小地图  -> ""BirdViewMapGui""
	//聊天窗口 ->""ChatWndGuiAll""
	//任务追踪 -> ""MissionTraceWnd""
	//快捷按钮条1 -> ""BottomControlWndGui""
	//快捷按钮条2 -> ""BottomControlWndGui1""
	//任务界面"" ->MissionWndGui_EntireWnd
	//背包(合)界面"" ->AllBagWndGui
	//背包(分)界面"" ->SingleBagWndGui
	//主任务对话窗口"" ->MissionDialogWndGui
	//接交任务详细描述窗口"" ->MissionDialog2ClildWndGui
	//任务上缴物品界面"" ->MissionDialog3WndGui
	//新技能提示框""     ->SkillHintWndGui
	//地图界面 -> ""BigViewMap""
	//神兽界面 -> ""PetInfoGui""
	//BUFF界面(自己)-> ""ShowBuffWnd""
	//BUFF界面(目标)-> ""ObjectBuffWnd""
	//技能学习界面->""SkillStudyWndGui""
	//技能系选择 ->""SkillSelectWndGui""
	//升级提示界面 ->""UpgradeHintButton""
	//鉴定界面 ->"ItemAppraiseWndGui"
	//练器界面 -> Puddler_MainWnd
	//本命灵珠界面 -> LifeBeadMainWnd
	//组队界面框 -> NewTeamWndGui
	//装备进阶框 -> EquipStrengthenWnd
	//尚武宝典框 -> GrowAssistantTurnOnBnt

	//延迟关闭时间
	%Time = 60000;
	//默认字体格式
	%GeSi = $Get_Dialog_GeShi[41603];

	switch (%index)
	{
		case 1:
			$UpLinePartyWndRecord= 5;
			OpenOrCloseUpLinePartyWndGui();//打开领取奖品界面
		case 2://打开宝石
			ChoseOpenKLJGemStoneWnd(1);
		case 3://打开鉴定
			OpenKLJEquipStrengGui();
		case 4://打开强化
			OpenKLJStrengthenByType(1);
		case 5://打开邮箱
			OpenMailWnd();
		case 6://角色初始化
			Birdthree2p9to3ButtonChickB();//初始化时切换视角
			Schedule(2000,0,"SvrEventTransporClient",%Player,1);
		case 7://新角色完成第一次飞行路径后，自动寻径
			$UpLinePartyWndRecord= 1;
			//OpenOrCloseUpLinePartyWndGui( );//打开领取奖品界面
			findpath(410100012);
		case 8://打开悬赏缉凶界面
			OpenOrCloseXuanShangJiXiongWnd();
		case 9://打开鉴宝界面
			OpenKLJKamPoWnd();
		case 10://打开神石合成界面
			OpenKLJGodStoneGui();
		case 11://刷新攻略界面
			//echo( "============刷新攻略界面============" );
			//Schedule( 3000, 0, "GetStrategyWndText" );
			GetStrategyWndText();
		case 12:
			ExecedWhenEndFindPath(10061,0);//指引拾取掉落物
		case 13://打开修理界面
			OpenOrCloseEquipNpcRepairGui();
		case 14://打开指引界面
			OpenPKGuidanceGui();
		case 15://分解触发
			CloseHelpDirectByIndex(60,0);
		case 16:
			OpenDouFuGan(10);
		case 17:
			PengLaiDaoJing_ChuFa();//采集道经触发
		case 18:
			ZiDongZhanDou_ZhiYin();
		case 19://元宝交易
			OpenKLJGoldTradingGuiWnd();
		case 20://坐骑指引，关闭包裹
			OpenDouFuGan( 23 );
			CloseAllBag();
		case 21:
			//echo( "通讯收到，播放特效" );
			$BirdPrefButton_Blink = 0;
			BirdPrefButton_Blink.Setvisible(1);
		case 22:
			OpenDouFuGan(25);
		case 23://刷新聚宝盆界面
			if (!CornucopiaWnd.IsVisible())
				OpenOrCloseCornucopiaWnd();
			UpdateCornucopiaWnd();
			SetMainbtnBlink();
		case 24://打开生活技能学习界面
			OpenLifeSkillStudyWndGui();
		case 25:findpath(410101007);//飞行结束都自动寻径
		case 26:findpath(410100055);
		case 27://打开攻城战界面
			OpenKLJAttackCityWndGui();
		case 28://打开背包
			OpenAllBag();
		case 29:
			ShowDialogOK("您已进入疲劳游戏时间，无法参与副本活动，为了您的健康，请尽快下线休息，做适当身体活动，合理安排学习生活");
		case 30:addMotionBlurScreenEffect( 2000 );
		case 31://刷新帮派活动界面
			ShowFactionWndGuiType(3);
		case 64:
			AddEffect(1,GetPlayer(),$SP_Effect[1]);	//发送接受任务特效
		case 65:
			AddEffect(1,GetPlayer(),$SP_Effect[2]);	//发送交付任务特效
	}
}

function Spirit_Skill_Face()
{
	if (HelpDirectWndGui_1.isVisible() == 1)
		ShowHelpDirectByIndex(29);
}


//■■■■■■■■■■■客户端收讯息脚本■■■■■■■■■■■■■■■■■■■■
