/*
================================================================================
ע�����нű���ͷ������ע�����ű��Ĵ���˵������


���Խ���


Author: Irelia
Date  : 2017.08.21
================================================================================
*/
//�������������Խ��桿����������������ˢ�¡���������������
//�������������Խ��桿���������������ӿؼ����ݡ�����������
//�������������Խ��桿�����������ӿؼ���ť����������������
//�������������Խ��桿������������ȡ���������������������
//�������������Խ��桿������������ȡ����Խ�������������
//�������������Խ��桿����������ͳ���������Ľ��ȡ���������
//�������������Խ��桿�������������ʱ֪ͨ����˼�¼������
//�������������Խ��桿������������ʾ�������ȡ��Ч��������


//�������������Խ��桿����������������ˢ�¡���������������
function GetStrategyWndText()//ˢ�¹��Խ��������
{
	%Player = GetPlayer();

	Strategy_progressbar_Text_1.SetText($GongLueGiftNeedYueLi[1]);	 //��ȡ�����Ҫ������
	Strategy_progressbar_Text_2.SetText($GongLueGiftNeedYueLi[2]);	 //��ȡ�����Ҫ������
	Strategy_progressbar_Text_3.SetText($GongLueGiftNeedYueLi[3]);	 //��ȡ�����Ҫ������
	Strategy_progressbar_Text_4.SetText($GongLueGiftNeedYueLi[4]);	 //��ȡ�����Ҫ������
	Strategy_progressbar_Item_0.setobject(1,$GongLueGiftYueLiItem[1]);//�ܵĽ������
	Strategy_progressbar_Item_1.setobject(1,$GongLueGiftYueLiItem[2]);//�ܵĽ������
	Strategy_progressbar_Item_2.setobject(1,$GongLueGiftYueLiItem[3]);//�ܵĽ������
	Strategy_progressbar_Item_3.setobject(1,$GongLueGiftYueLiItem[4]);//�ܵĽ������

	%YueLi = GetStrategyYueLiCount(%Player);//���㵱ǰ��ɵ�����

	if (GetSrc(%Player, 60) == 0){ StrategySorceButton_0.setvisible(1); if (%YueLi > $GongLueGiftNeedYueLi[1]){ StrategySorceButton_0.setactive(1); StrategySorceButton_0.Settext("��ȡ���"); } else { StrategySorceButton_0.setactive(0); StrategySorceButton_0.Settext("������ȡ"); } }
	else StrategySorceButton_0.setvisible(0);//��ȡ������İ�ť
	if (GetSrc(%Player, 61) == 0){ StrategySorceButton_1.setvisible(1); if (%YueLi > $GongLueGiftNeedYueLi[2]){ StrategySorceButton_1.setactive(1); StrategySorceButton_1.Settext("��ȡ���"); } else { StrategySorceButton_1.setactive(0); StrategySorceButton_1.Settext("������ȡ"); } }
	else StrategySorceButton_1.setvisible(0);//��ȡ������İ�ť
	if (GetSrc(%Player, 62) == 0){ StrategySorceButton_2.setvisible(1); if (%YueLi > $GongLueGiftNeedYueLi[3]){ StrategySorceButton_2.setactive(1); StrategySorceButton_2.Settext("��ȡ���"); } else { StrategySorceButton_2.setactive(0); StrategySorceButton_2.Settext("������ȡ"); } }
	else StrategySorceButton_2.setvisible(0);//��ȡ������İ�ť
	if (GetSrc(%Player, 63) == 0){ StrategySorceButton_3.setvisible(1); if (%YueLi > $GongLueGiftNeedYueLi[4]){ StrategySorceButton_3.setactive(1); StrategySorceButton_3.Settext("��ȡ���"); } else { StrategySorceButton_3.setactive(0); StrategySorceButton_3.Settext("������ȡ"); } }
	else StrategySorceButton_3.setvisible(0);//��ȡ������İ�ť

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
	Strategy_progressbar.setScriptValue(%JinDu); //���ý����� 0.03 0.18 0.4 0.67 1
	//--------��������ť-----------------
	%Num = GetStrategyMainBtnNum();
	for (%i = 0; %i < %Num; %i++)
	{
		("StrategyMainButton_" @ %i).delete();
		if (!isObject("StrategyMainButton_" @ %i))
		{
            %file = "KLJStrategyMainButton_BtnProfile0" @ %i;
			new GuiButtonCtrl("StrategyMainButton_" @ %i){ //���ť
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

				new GuiBitmapCtrl("StrategyMainButton_ImportantNote" @ %i){//��ʾ
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
	//-----------------�����Ӱ�ť----------------------

	//echo( "%$RecordStrategyMain===" @ $RecordStrategyMain );
	//echo( "%$RecordStrategySub===" @ $RecordStrategySub );
	StrategyMainButtonContent($RecordStrategyMain * 1);
	("StrategyMainButton_" @ $RecordStrategyMain).SetStateOn(1);
	SetMainbtnBlink();
}
//�������������Խ��桿����������������ˢ�¡���������������

//�������������Խ��桿���������������ӿؼ����ݡ�����������

function GetStrategySubButtonIfno(%Type,%i)//ˢ���ӿؼ����������
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
			("StrategySubButtonTextB_" @ %i).Settext("������+" @  %YueLi);
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
//�������������Խ��桿���������������ӿؼ����ݡ�����������

//�������������Խ��桿�����������ӿؼ���ť����������������
function StrategySubButtonContent(%MainType,%SubType)//�ӿؼ���ť�Ĵ���
{
	//echo("�ӿؼ���ť�Ĵ���%MainType==" @ %MainType @ "    %SubType===" @ %SubType);
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
		StrategySubBmp2Text_2.SetText("����������");
		if (%YueLi > 0)
		{
			StrategySubBmp2Text_3.setvisible(1);
			StrategySubBmp2Text_3.SetText("������" @ %YueLi);
		}
		if (%ItemID > 0)
		{
			StrategySubBmp2Text_4.setvisible(1);
			StrategySubBmp2Text_5.setvisible(1);
			StrategySubBmp2Text_6.setvisible(1);
			StrategySubBmp2Text_4.SetText("���ߣ�");
			StrategySubBmp2Text_5.SetObject(1,%ItemID);
			StrategySubBmp2Text_6.Command = "StrategyGetOneGift(" @ %MainType @ "," @ %SubType @ ");";
			StrategySubBmp2Text_7.setvisible(1);
		}
		if (GetSrc(GetPlayer(),%Src) == 0)
		{
			StrategySubBmp2Text_6.SetText("������ȡ");
			StrategySubBmp2Text_6.SetActive(0);
		}
		else
		{
			if (GetSrc(GetPlayer(),%Src + 1) == 0)
			{
				StrategySubBmp2Text_6.SetText("����ȡ");
				StrategySubBmp2Text_6.SetActive(1);
			}
			else
			{
				StrategySubBmp2Text_6.SetText("����ȡ");
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
//�������������Խ��桿�����������ӿؼ���ť����������������

//�������������Խ��桿������������ȡ���������������������
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
		SetScreenMessage("�����������㣬�޷���ȡ���",$Color[2]);
		SetChatMessage("����ǰ�Ѵﵽ����" @ %YueLi @ "�㣬����" @ $GongLueGiftNeedYueLi[%type + 1] @ "�㣬�޷���ȡ����",$Color[2],$chatMsg_System);
		return;
	}
	if (GetBagEmptyNum() < 1)
	{
		SetScreenMessage("�����ռ䲻��",$Color[2]);
		return;
	}
	("StrategySorceButton_" @ %type).SetVisible(0);
	ClientOnSptAction(31,%type);//ͨѶ�����
	ScheduleSetMainbtnBlink();//ˢ�°�ť��Ч

}
//�������������Խ��桿������������ȡ���������������������

//�������������Խ��桿������������ȡ����Խ�������������
function StrategyGetOneGift(%MainType,%SubType)//��ȡ��ɹ��Խ���
{
	//echo("��ȡ��ɹ��Խ���%MainType==" @ %MainType @ "    %SubType===" @ %SubType);
	if (GetBagEmptyNum() < 1)
	{
		SetScreenMessage("�����ռ䲻��",$Color[2]);
		return;
	}
	%Src = $StrategySubBtnSrc[%MainType,%SubType];
	if (GetSrc(GetPlayer(),%Src) == 1)
	{
		if (GetSrc(GetPlayer(),%Src + 1) == 1)
		{
			SetScreenMessage("������ȡ�������",$Color[2]);
			return;
		}
		else
		{
			%Msg = (%MainType + 1) *10000 + %SubType;
			//echo("%Msg===" @ %Msg);
			ClientOnSptAction(32,%Msg);//ͨѶ�����
			ScheduleSetMainbtnBlink();//ˢ�°�ť��Ч

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
		SetScreenMessage("��û�д��Ŀ�꣬�޷���ȡ����",$Color[2]);
		return;
	}

}
//�������������Խ��桿������������ȡ����Խ�������������

//�������������Խ��桿�������������ʱ֪ͨ����˼�¼������
function SetStrategyWndRecord(%Src)
{
	if (GetPlayer().GetLevel() < 20)
		return;
	if (GetSrc(GetPlayer(),%Src) == 0)
		ClientOnSptAction(33,%Src);//ͨѶ�����
}
//�������������Խ��桿�������������ʱ֪ͨ����˼�¼������

//�������������Խ��桿������������ʾ�������ȡ��Ч�������� 
function SetMainbtnBlink()
{
	//echo( "============��ʾ�������ȡ��Ч========" );
	%Player = GetPlayer();
	BirdPrefButton_Blink.Setvisible(0);
	CornucopiaWndBtn_Blink.Setvisible(0);
	ChargeWndBtn_Blink.Setvisible(0);
	StrategyWndBtn_Blink.Setvisible(0);
	LingJiangWndBtn_Blink.Setvisible(0);
	TimerTriggerCtrl_MinWnd.setvisible(0);
	LingMaiWndBtn_Blink.Setvisible(0);
	//---------------------------------������˸����Ч------------------------------------------------
	if (%Player.GetLevel() >= 50 && GetSrc(%Player,187) == 0)
	{
		LingMaiWndBtn_Blink.Setvisible(1);
	}
	//---------------------------------��������ʱ�佱��------------------------------------------------
	//if ( 1 == CanGetStateOnlineReward( %Player, 7 ) )
	//{
	//	TimerTriggerCtrl_MinWnd.setvisible( 1 );
	//	UpdateTimerCtrlNew( );
	//}
	//---------------------------------BirdPrefButton_Blink  //�ػ���Ч---------------------------------
	//if (GetAct(%Player,3999,0) < 1)
	if ($BirdPrefButton_Blink != 1)
		BirdPrefButton_Blink.Setvisible(1);
	//---------------------------------CornucopiaWndBtn_Blink//�۱�����Ч-------------------------------
	%Times = GetAct(%Player,3038,0)%1000;//ʣ����Ѵ���
	if (%Times >= 1 && !%Player.Isschbuff(2007))
		CornucopiaWndBtn_Blink.Setvisible(1);
	//---------------------------------ChargeWndBtn_Blink //��ֵ��Ч---------------------------------
	if (GetIsCanReceiveFirstRecharge(%Player) > 0)//�ж��׳����
		ChargeWndBtn_Blink.Setvisible(1);
	if (!ChargeWndBtn_Blink.Isvisible())
	{
		for (%i = 0; %i <= 4; %i++) //�ж�ÿ�ճ�ֵ
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
		for (%i = 0; %i <= 34; %i++) //�ж���ȡ����
		{
			if (GetIsCanReceiveRechargeHaoLi(%Player,%i) == 0)
			{
				ChargeWndBtn_Blink.Setvisible(1);
				break;
			}
		}
	}
	//---------------------------------StrategyWndBtn_Blink //������Ч---------------------------------
	%YueLi = GetStrategyYueLiCount(%Player);
	//echo( "%YueLi===========" @ %YueLi );
	for (%i = 0; %i <= 3; %i++) //�������
	{
		if (GetSrc(%Player,60 + %i) == 0 && $GongLueGiftNeedYueLi[%i + 1] <= %YueLi)
		{
			StrategyWndBtn_Blink.Setvisible(1);
			break;
		}
	}
	%MainNum = GetStrategyMainBtnNum();
	for (%i = 0; %i < %MainNum; %i++)//�������Խ���
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
	//---------------------------------LingJiangWndBtn_Blink //�콱������Ч---------------------------------
	UpLinePartyButton_Blink_1.setvisible(0);
	UpLinePartyButton_Blink_2.setvisible(0);
	UpLinePartyButton_Blink_3.setvisible(0);
	UpLinePartyButton_Blink_4.setvisible(0);
	for (%i = 1; %i <= 7; %i++) //�������
	{
		if (("UpLineQiTianHaoLiButon_" @ %i).isActive())
		{
			//echo("�콱������Ч ===");
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
	%Level = %Player.GetLevel(); //�ȼ����
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
	//---------------------------------ChengJiuWndBtn_Effects //�ɾͽ�����Ч---------------------------------
	if (CanDrawAchieveMentGift())
		ChengJiuWndBtn_Effects.setvisible(1);
	else
		ChengJiuWndBtn_Effects.setvisible(0);

}
function ScheduleSetMainbtnBlink()
{
	CanCel($ScheduleSetMainbtnBlink);
	$ScheduleSetMainbtnBlink = Schedule(2000,0,"SetMainbtnBlink");//ˢ�°�ť��Ч
}
//�������������Խ��桿������������ʾ�������ȡ��Ч��������
