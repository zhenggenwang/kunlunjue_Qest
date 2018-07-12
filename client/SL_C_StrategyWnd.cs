/*
================================================================================
注：所有脚本开头，均需注明本脚本的大致说明文字


攻略界面


Author: Irelia
Date  : 2017.08.21
================================================================================
*/
//■■■■【攻略界面】■■■■【主界面刷新】■■■■■■■
//■■■■【攻略界面】■■■■【单独子控件内容】■■■■■
//■■■■【攻略界面】■■■■【子控件按钮触发】■■■■■
//■■■■【攻略界面】■■■■【领取进度礼包】■■■■■■
//■■■■【攻略界面】■■■■【领取单项攻略奖励】■■■■
//■■■■【攻略界面】■■■■【统计总阅历的进度】■■■■
//■■■■【攻略界面】■■■■【完成时通知服务端记录】■■
//■■■■【攻略界面】■■■■【显示礼包可领取特效】■■■


//■■■■【攻略界面】■■■■【主界面刷新】■■■■■■■
function GetStrategyWndText()//刷新攻略界面的内容
{
	%Player = GetPlayer();

	Strategy_progressbar_Text_1.SetText($GongLueGiftNeedYueLi[1]);	 //领取礼包需要的阅历
	Strategy_progressbar_Text_2.SetText($GongLueGiftNeedYueLi[2]);	 //领取礼包需要的阅历
	Strategy_progressbar_Text_3.SetText($GongLueGiftNeedYueLi[3]);	 //领取礼包需要的阅历
	Strategy_progressbar_Text_4.SetText($GongLueGiftNeedYueLi[4]);	 //领取礼包需要的阅历
	Strategy_progressbar_Item_0.setobject(1,$GongLueGiftYueLiItem[1]);//总的进度礼包
	Strategy_progressbar_Item_1.setobject(1,$GongLueGiftYueLiItem[2]);//总的进度礼包
	Strategy_progressbar_Item_2.setobject(1,$GongLueGiftYueLiItem[3]);//总的进度礼包
	Strategy_progressbar_Item_3.setobject(1,$GongLueGiftYueLiItem[4]);//总的进度礼包

	%YueLi = GetStrategyYueLiCount(%Player);//计算当前完成的阅历

	if (GetSrc(%Player, 60) == 0){ StrategySorceButton_0.setvisible(1); if (%YueLi > $GongLueGiftNeedYueLi[1]){ StrategySorceButton_0.setactive(1); StrategySorceButton_0.Settext("领取礼包"); } else { StrategySorceButton_0.setactive(0); StrategySorceButton_0.Settext("不可领取"); } }
	else StrategySorceButton_0.setvisible(0);//领取总礼包的按钮
	if (GetSrc(%Player, 61) == 0){ StrategySorceButton_1.setvisible(1); if (%YueLi > $GongLueGiftNeedYueLi[2]){ StrategySorceButton_1.setactive(1); StrategySorceButton_1.Settext("领取礼包"); } else { StrategySorceButton_1.setactive(0); StrategySorceButton_1.Settext("不可领取"); } }
	else StrategySorceButton_1.setvisible(0);//领取总礼包的按钮
	if (GetSrc(%Player, 62) == 0){ StrategySorceButton_2.setvisible(1); if (%YueLi > $GongLueGiftNeedYueLi[3]){ StrategySorceButton_2.setactive(1); StrategySorceButton_2.Settext("领取礼包"); } else { StrategySorceButton_2.setactive(0); StrategySorceButton_2.Settext("不可领取"); } }
	else StrategySorceButton_2.setvisible(0);//领取总礼包的按钮
	if (GetSrc(%Player, 63) == 0){ StrategySorceButton_3.setvisible(1); if (%YueLi > $GongLueGiftNeedYueLi[4]){ StrategySorceButton_3.setactive(1); StrategySorceButton_3.Settext("领取礼包"); } else { StrategySorceButton_3.setactive(0); StrategySorceButton_3.Settext("不可领取"); } }
	else StrategySorceButton_3.setvisible(0);//领取总礼包的按钮

	if (%YueLi >  $GongLueGiftNeedYueLi[4])
		%JinDu = 1;
	else if (%YueLi >=  $GongLueGiftNeedYueLi[3])
		%JinDu = ((%YueLi - $GongLueGiftNeedYueLi[3])/($GongLueGiftNeedYueLi[4] - $GongLueGiftNeedYueLi[3])) *(0.975 - 0.67) + 0.67;
	else if (%YueLi >=  $GongLueGiftNeedYueLi[2])
		%JinDu = ((%YueLi - $GongLueGiftNeedYueLi[2])/($GongLueGiftNeedYueLi[3] - $GongLueGiftNeedYueLi[2])) *(0.67 - 0.4) + 0.4;
	else if (%YueLi >=  $GongLueGiftNeedYueLi[1])
		%JinDu = ((%YueLi - $GongLueGiftNeedYueLi[1])/($GongLueGiftNeedYueLi[2] - $GongLueGiftNeedYueLi[1])) *(0.4 - 0.18) + 0.18;
	else
		%JinDu =(%YueLi /$GongLueGiftNeedYueLi[1]) *(0.18 - 0.03)+ 0.03;

	//echo( "%YueLi===" @ %YueLi );
	//echo( "%JinDu===" @ %JinDu );
	Strategy_progressbar.setScriptValue(%JinDu); //设置进度条 0.03 0.18 0.4 0.67 1
	//--------创建主按钮-----------------
	%Num = GetStrategyMainBtnNum();
	for (%i = 0; %i < %Num; %i++)
	{
		("StrategyMainButton_" @ %i).delete();
		if (!isObject("StrategyMainButton_" @ %i))
		{
            %file = "KLJStrategyMainButton_BtnProfile0" @ %i;
			new GuiButtonCtrl("StrategyMainButton_" @ %i){ //活动按钮
				canSaveDynamicFields = "0";
				Enabled = "1";
				isContainer = "0";
				Profile = %file;
				position = %i*85 + 116 SPC 214;
				//position = %i*91 SPC 212;
				Extent = "88 32";
				Visible = "1";
				HorizSizing = "right";
				VertSizing = "bottom";
				MinExtent = "8 2";
				canSave = "1";
				Visible = "1";
				mustPrerender = "0";
				Command = "StrategyMainButtonContent("@ %i @ ");";
				hovertime = "1000";
				groupNum = "1";
				buttonType = "RadioButton";
				useMouseEvents = "0";
				IsStateOn = "0";

				new GuiBitmapCtrl("StrategyMainButton_ImportantNote" @ %i){//提示
					canSaveDynamicFields = "0";
					Enabled = "1";
					isContainer = "0";
					LogicLayer = "0";
					Profile = "GuiModelessDialogProfile";
					HorizSizing = "right";
					VertSizing = "bottom";
					position = "73 4";
					Extent = "14 15";
					MinExtent = "8 2";
					canSave = "1";
					Visible = "0";
					mustPrerender = "0";
					alpha = "255";
					useFadeout = "1";
					bitmap = "gameres/gui/images/KLJMailPrompt";
					wrap = "0";
				};
			};
			Strategy_Container.add("StrategyMainButton_" @ %i);
			//("StrategyMainButton_" @ %i).Settext($StrategyMainBtnName[%i]);
		}
	}
	//-----------------创建子按钮----------------------

	//echo( "%$RecordStrategyMain===" @ $RecordStrategyMain );
	//echo( "%$RecordStrategySub===" @ $RecordStrategySub );
	StrategyMainButtonContent($RecordStrategyMain * 1);
	("StrategyMainButton_" @ $RecordStrategyMain).SetStateOn(1);
	SetMainbtnBlink();
}
//■■■■【攻略界面】■■■■【主界面刷新】■■■■■■■

//■■■■【攻略界面】■■■■【单独子控件内容】■■■■■

function GetStrategySubButtonIfno(%Type,%i)//刷新子控件里面的内容
{

	%Name = $StrategySubBtnTit[%Type,%i];
	%YueLi = $StrategySubBtnYLi[%Type,%i];
	%ItemID = GetWord($StrategySubBtnIte[%Type,%i],0);
	%ItemNum = GetWord($StrategySubBtnIte[%Type,%i],1);
	%Src = $StrategySubBtnSrc[%Type,%i];

	("StrategySubButtonTextA_" @ %i).Settext(%Name);
	if (%YueLi > 0 || %ItemID > 0)
	{
		("StrategySubButton_" @ %i).setProfile("StrategyButtonProfile3");
		("StrategySubButtonTextA_" @ %i).SetPosition(60,25);

		if (%YueLi > 0)
		{
			("StrategySubButtonTextB_" @ %i).Settext("阅历：+" @  %YueLi);
			("StrategySubButtonTextB_" @ %i).Setvisible(1);
		}
		else
			("StrategySubButtonTextB_" @ %i).Setvisible(0);

		if (%ItemID > 0)
		{
			("StrategySubButtonItem_" @ %i).SetObject(1,%ItemID);
			("StrategySubButtonItem_" @ %i).Setvisible(1);
			("StrategySubButtonItembmp_" @ %i).Setvisible(1);
		}
		else
		{
			("StrategySubButtonItem_" @ %i).Setvisible(0);
			("StrategySubButtonItembmp_" @ %i).Setvisible(0);
		}
	}
	else
	{
		("StrategySubButton_" @ %i).setProfile("StrategyButtonProfile4");
		("StrategySubButtonTextA_" @ %i).SetPosition(60,45);

		("StrategySubButtonItem_" @ %i).Setvisible(0);
		("StrategySubButtonTextB_" @ %i).Setvisible(0);
		("StrategySubButtonItembmp_" @ %i).Setvisible(0);
	}



	if (GetSrc(GetPlayer(),%Src) == 1 && %Src > 0)
	{
		("StrategySubButtonbmp_" @ %i).Setvisible(1);
		if (GetSrc(GetPlayer(),%Src + 1) == 1)
			("StrategySubButtonbmp_" @ %i).SetBitmap("gameres/gui/images/strategywnd_007");
		else
			("StrategySubButtonbmp_" @ %i).SetBitmap("gameres/gui/images/strategywnd_008");
	}
	else
		("StrategySubButtonbmp_" @ %i).Setvisible(0);
}
//■■■■【攻略界面】■■■■【单独子控件内容】■■■■■

//■■■■【攻略界面】■■■■【子控件按钮触发】■■■■■
function StrategySubButtonContent(%MainType,%SubType)//子控件按钮的触发
{
	//echo("子控件按钮的触发%MainType==" @ %MainType @ "    %SubType===" @ %SubType);
	CanCel($ScheduleSetMainbtnBlink);
	if (!("StrategySubButton_" @ %SubType).IsStateOn())
		("StrategySubButton_" @ %SubType).SetStateOn(1);
	$RecordStrategySub = %SubType;
	Strategy_SubContainer.Setvisible(1);
	StrategyWndGui.SetExtent(1234,548);

	%Name = $StrategySubBtnTit[%MainType,%SubType];
	%YueLi = $StrategySubBtnYLi[%MainType,%SubType];
	%ItemID = GetWord($StrategySubBtnIte[%MainType,%SubType],0);
	%ItemNum = GetWord($StrategySubBtnIte[%MainType,%SubType],1);
	%Src = $StrategySubBtnSrc[%MainType,%SubType];
	%Msg = $StrategySubBtnMsg[%MainType,%SubType];

	StrategySubBmp2Text_0.SetText(%Name);
	StrategySubBmp2Text_1.SetContent(%Msg);

	if (%YueLi > 0 || %ItemID > 0)
	{
		StrategySubBmp2Text_2.setvisible(1);
		StrategySubBmp2Text_2.SetText("历练奖励：");
		if (%YueLi > 0)
		{
			StrategySubBmp2Text_3.setvisible(1);
			StrategySubBmp2Text_3.SetText("阅历：" @ %YueLi);
		}
		if (%ItemID > 0)
		{
			StrategySubBmp2Text_4.setvisible(1);
			StrategySubBmp2Text_5.setvisible(1);
			StrategySubBmp2Text_6.setvisible(1);
			StrategySubBmp2Text_4.SetText("道具：");
			StrategySubBmp2Text_5.SetObject(1,%ItemID);
			StrategySubBmp2Text_6.Command = "StrategyGetOneGift(" @ %MainType @ "," @ %SubType @ ");";
			StrategySubBmp2Text_7.setvisible(1);
		}
		if (GetSrc(GetPlayer(),%Src) == 0)
		{
			StrategySubBmp2Text_6.SetText("不可领取");
			StrategySubBmp2Text_6.SetActive(0);
		}
		else
		{
			if (GetSrc(GetPlayer(),%Src + 1) == 0)
			{
				StrategySubBmp2Text_6.SetText("可领取");
				StrategySubBmp2Text_6.SetActive(1);
			}
			else
			{
				StrategySubBmp2Text_6.SetText("已领取");
				StrategySubBmp2Text_6.SetActive(0);
			}
		}
	}
	else
	{
		StrategySubBmp2Text_2.setvisible(0);
		StrategySubBmp2Text_3.setvisible(0);
		StrategySubBmp2Text_4.setvisible(0);
		StrategySubBmp2Text_5.setvisible(0);
		StrategySubBmp2Text_6.setvisible(0);
		StrategySubBmp2Text_7.setvisible(0);
	}
	if (GetPlayer().IsAcceptedMission(10361) && $StrtegyHelpDirectRecord == 2)
	{
		$StrtegyHelpDirectRecord = 3;
		OpenDouFuGan(18);
	}
}
//■■■■【攻略界面】■■■■【子控件按钮触发】■■■■■

//■■■■【攻略界面】■■■■【领取进度礼包】■■■■■■
function StrategyAllSorceGift(%type)//
{
	%Player = GetPlayer();
	switch (%type)
	{
		case 0:%Src = 60;
		case 1:%Src = 61;
		case 2:%Src = 62;
		case 3:%Src = 63;
	}
	if (GetSrc(%Player,%Src) == 1)
		return;
	%YueLi = GetStrategyYueLiCount(%Player);
	//echo( "%YueLi===" @ %YueLi );
	//echo( "$GongLueGiftNeedYueLi[ %type + 1 ]===" @ $GongLueGiftNeedYueLi[ %type + 1 ] );
	if (%YueLi < $GongLueGiftNeedYueLi[%type + 1])
	{
		SetScreenMessage("您的阅历不足，无法领取礼包",$Color[2]);
		SetChatMessage("您当前已达到阅历" @ %YueLi @ "点，不足" @ $GongLueGiftNeedYueLi[%type + 1] @ "点，无法领取奖励",$Color[2],$chatMsg_System);
		return;
	}
	if (GetBagEmptyNum() < 1)
	{
		SetScreenMessage("包裹空间不足",$Color[2]);
		return;
	}
	("StrategySorceButton_" @ %type).SetVisible(0);
	ClientOnSptAction(31,%type);//通讯服务端
	ScheduleSetMainbtnBlink();//刷新按钮特效

}
//■■■■【攻略界面】■■■■【领取进度礼包】■■■■■■

//■■■■【攻略界面】■■■■【领取单项攻略奖励】■■■■
function StrategyGetOneGift(%MainType,%SubType)//领取完成攻略奖励
{
	//echo("领取完成攻略奖励%MainType==" @ %MainType @ "    %SubType===" @ %SubType);
	if (GetBagEmptyNum() < 1)
	{
		SetScreenMessage("包裹空间不足",$Color[2]);
		return;
	}
	%Src = $StrategySubBtnSrc[%MainType,%SubType];
	if (GetSrc(GetPlayer(),%Src) == 1)
	{
		if (GetSrc(GetPlayer(),%Src + 1) == 1)
		{
			SetScreenMessage("您已领取过该项奖励",$Color[2]);
			return;
		}
		else
		{
			%Msg = (%MainType + 1) *10000 + %SubType;
			//echo("%Msg===" @ %Msg);
			ClientOnSptAction(32,%Msg);//通讯服务端
			ScheduleSetMainbtnBlink();//刷新按钮特效

			if (GetPlayer().IsAcceptedMission(10361))
			{
				closeHelpDirect1_4(18);
				OpenDouFuGan(19);
			}
		}
		("StrategySubButtonbmp_" @ %SubType).SetBitmap("gameres/gui/images/strategywnd_007");
	}
	else
	{
		SetScreenMessage("您没有达成目标，无法领取奖励",$Color[2]);
		return;
	}

}
//■■■■【攻略界面】■■■■【领取单项攻略奖励】■■■■

//■■■■【攻略界面】■■■■【完成时通知服务端记录】■■
function SetStrategyWndRecord(%Src)
{
	if (GetPlayer().GetLevel() < 20)
		return;
	if (GetSrc(GetPlayer(),%Src) == 0)
		ClientOnSptAction(33,%Src);//通讯服务端
}
//■■■■【攻略界面】■■■■【完成时通知服务端记录】■■

//■■■■【攻略界面】■■■■【显示礼包可领取特效】■■■ 
function SetMainbtnBlink()
{
	//echo( "============显示礼包可领取特效========" );
	%Player = GetPlayer();
	BirdPrefButton_Blink.Setvisible(0);
	CornucopiaWndBtn_Blink.Setvisible(0);
	ChargeWndBtn_Blink.Setvisible(0);
	StrategyWndBtn_Blink.Setvisible(0);
	LingJiangWndBtn_Blink.Setvisible(0);
	TimerTriggerCtrl_MinWnd.setvisible(0);
	LingMaiWndBtn_Blink.Setvisible(0);
	//---------------------------------灵脉闪烁的特效------------------------------------------------
	if (%Player.GetLevel() >= 50 && GetSrc(%Player,187) == 0)
	{
		LingMaiWndBtn_Blink.Setvisible(1);
	}
	//---------------------------------新手在线时间奖励------------------------------------------------
	//if ( 1 == CanGetStateOnlineReward( %Player, 7 ) )
	//{
	//	TimerTriggerCtrl_MinWnd.setvisible( 1 );
	//	UpdateTimerCtrlNew( );
	//}
	//---------------------------------BirdPrefButton_Blink  //特惠特效---------------------------------
	//if (GetAct(%Player,3999,0) < 1)
	if ($BirdPrefButton_Blink != 1)
		BirdPrefButton_Blink.Setvisible(1);
	//---------------------------------CornucopiaWndBtn_Blink//聚宝盆特效-------------------------------
	%Times = GetAct(%Player,3038,0)%1000;//剩余免费次数
	if (%Times >= 1 && !%Player.Isschbuff(2007))
		CornucopiaWndBtn_Blink.Setvisible(1);
	//---------------------------------ChargeWndBtn_Blink //充值特效---------------------------------
	if (GetIsCanReceiveFirstRecharge(%Player) > 0)//判断首充礼包
		ChargeWndBtn_Blink.Setvisible(1);
	if (!ChargeWndBtn_Blink.Isvisible())
	{
		for (%i = 0; %i <= 4; %i++) //判断每日充值
		{
			if (GetIsCanReceiveRechargeDays(%Player,%i) == 0)
			{
				ChargeWndBtn_Blink.Setvisible(1);
				break;
			}
		}
	}
	if (!ChargeWndBtn_Blink.Isvisible())
	{
		for (%i = 0; %i <= 34; %i++) //判断提取豪礼
		{
			if (GetIsCanReceiveRechargeHaoLi(%Player,%i) == 0)
			{
				ChargeWndBtn_Blink.Setvisible(1);
				break;
			}
		}
	}
	//---------------------------------StrategyWndBtn_Blink //攻略特效---------------------------------
	%YueLi = GetStrategyYueLiCount(%Player);
	//echo( "%YueLi===========" @ %YueLi );
	for (%i = 0; %i <= 3; %i++) //进度礼包
	{
		if (GetSrc(%Player,60 + %i) == 0 && $GongLueGiftNeedYueLi[%i + 1] <= %YueLi)
		{
			StrategyWndBtn_Blink.Setvisible(1);
			break;
		}
	}
	%MainNum = GetStrategyMainBtnNum();
	for (%i = 0; %i < %MainNum; %i++)//单独攻略奖励
	{
		("StrategyMainButton_ImportantNote" @ %i).setvisible(0);
		%SubNum = GetStrategySubBtnNum(%i);
		for (%j = 0; %j < %SubNum; %j++)
		{
			%Src = $StrategySubBtnSrc[%i,%j];
			//echo( %i @ " " @ %j @ "===" @ $StrategySubBtnSrc[ %i, %j ]  @ "   " @  $StrategySubBtnTit[ %i, %j ] @ "   " @ GetSrc( %Player, %Src ) @ "   " @ GetSrc( %Player, %Src + 1 ) );
			if (GetSrc(%Player,%Src) == 1 && GetSrc(%Player,%Src + 1) == 0 && %Src !$="")
			{
				if (!StrategyWndBtn_Blink.isvisible())
					StrategyWndBtn_Blink.Setvisible(1);
				if (!("StrategyMainButton_ImportantNote" @ %i).isvisible())
					("StrategyMainButton_ImportantNote" @ %i).setvisible(1);
			}
		}
	}
	//---------------------------------LingJiangWndBtn_Blink //领奖界面特效---------------------------------
	UpLinePartyButton_Blink_1.setvisible(0);
	UpLinePartyButton_Blink_2.setvisible(0);
	UpLinePartyButton_Blink_3.setvisible(0);
	UpLinePartyButton_Blink_4.setvisible(0);
	for (%i = 1; %i <= 7; %i++) //七天好礼
	{
		if (("UpLineQiTianHaoLiButon_" @ %i).isActive())
		{
			//echo("领奖界面特效 ===");
			LingJiangWndBtn_Blink.Setvisible(1);
			UpLinePartyButton_Blink_1.setvisible(1);
			break;
		}
	}
	%NowHaveAct = GetHuoYueDuRecord(GetPlayer());
	for (%i =1; %i <= 4; %i++)
	{
		if (GetSrc(GetPlayer(), %i + 35) == 0 && %NowHaveAct >= $MeiRiLiLian_HuoYueDu[%i])
		{
			LingJiangWndBtn_Blink.Setvisible(1);
			UpLinePartyButton_Blink_2.setvisible(1);
			break;
		}
	}

	if (GetSrc(%Player,7) == 0)
	{
		LingJiangWndBtn_Blink.Setvisible(1);
		UpLinePartyButton_Blink_3.setvisible(1);
	}
	%Level = %Player.GetLevel(); //等级礼包
	//echo( "%Level ===" @ %Level );
	for (%i = 1; %i < $UpLineLevelGiftMaxNum; %i++)
	{
		%NeedLevel = GetWord($UpLineLevelGift[%i],1);
		%Src = GetWord($UpLineLevelGift[%i],2);
		//echo( "%NeedLevel ===" @ %NeedLevel @ "     %Src===" @ %Src @ "      " @ GetSrc( %Player, %Src ) );
		if (%Level >=  %NeedLevel &&  GetSrc(%Player,%Src) == 0)
		{
			LingJiangWndBtn_Blink.Setvisible(1);
			UpLinePartyButton_Blink_4.setvisible(1);
			break;
		}
	}
	//---------------------------------ChengJiuWndBtn_Effects //成就界面特效---------------------------------
	if (CanDrawAchieveMentGift())
		ChengJiuWndBtn_Effects.setvisible(1);
	else
		ChengJiuWndBtn_Effects.setvisible(0);

}
function ScheduleSetMainbtnBlink()
{
	CanCel($ScheduleSetMainbtnBlink);
	$ScheduleSetMainbtnBlink = Schedule(2000,0,"SetMainbtnBlink");//刷新按钮特效
}
//■■■■【攻略界面】■■■■【显示礼包可领取特效】■■■
