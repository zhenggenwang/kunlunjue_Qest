
//�����������������������ͻ���ͨѶ���ýű����¡�����������������������������������
//�����������������������ͻ����ռ�����˴��͵��ַ���������������������������������
//�����������������������ͻ�����ѶϢ�ű�������������������������������������������




//�����������������������ͻ���ͨѶ���ýű����¡�����������������������������������
//ServerOnSptAction( %Player.GetPlayerID( ), %Type, %Subtype );   %TypeΪ������ֵ��%SubTypeΪswitch�ж�����ֵ
function OnSptActionEvent_C(%Type,%Subtype)
{
	%Player = GetPlayer();
	%MapID = GetSubStr(GetZoneid(),0,4);
	switch (%Subtype)
	{
		case 1://����������ָ���Ӧ����
			OpenAllBag();
			OpenDouFuGan_AllBagWndGui(%Type,0);
		case 2:
			Set_ShopWnd_NpcZHJM(%Type);
		case 3://��������
			Open_MissionZhiYin(%Type,1);
		case 4://ɾ��������
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
					SetScreenMessage("��Ҫ���а��" @ %number @ "������Ҵﵽ50�����ϣ��ſ��ԽӴ���", 0xff0000);
					SetChatMessage("��Ҫ���а��" @ %number @ "������Ҵﵽ50�����ϣ��ſ��ԽӴ��ڡ�", $Color[2], $chatMsg_System);
					return;
				}
			}
			%Text = "<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>  Ѻ�ͱ����ڳ�����Ҫ�Ͻ�Ѻ��</t><b/>" @
				"<t m ='0' f='����' n='14' c='0xff00ffff' v='1'>" @ "<t>          </t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold["6000000" @ %Type],2)) @ "</t><b/>" @
				"<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>      �Ƿ�ȷ��Ѻ�ڣ�</t>";
			Dialog_OK_Cancel.setContent(%Text);
			Dialog_OK_Cancel.setOk("ȷ��","ClientOnSptAction( 13, 0 );");//ͨѶ�����
			Dialog_OK_Cancel.SetCancel("ȡ��","");
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
			%Text = "<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>����Ԫ���������Ҫ�۳� </t>" @
				"<t m ='0' f='����' n='14' c='0xff00ffff' v='1'>" @ %Type @ " </t>" @
				"<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>Ԫ�����Ƿ�ȷ��������</t>";
			Dialog_OK_Cancel.setContent(%Text);
			Dialog_OK_Cancel.setOk("ȷ��","ClientOnSptAction( 19, 0 );");//ͨѶ�����
			Dialog_OK_Cancel.SetCancel("ȡ��","");
			Dialog_OK_Cancel.setVisible(1);
		case 13://�����۾�
			%Triggerid = %Player.Gettriggerid();
			if (%Triggerid != 810100114 && %Triggerid != 810100108 && %Triggerid != 810100107)
				return;
			//echo( "%Type==========" @ %Type );
			switch (%Type)
			{
				case 7777:
					SetBaJieCaiCaiCaiPloyGUIResult(1,1000,500,100);// �����
				case 8888:
					SetBaJieCaiCaiCaiPloyGUIResult(0,1000,500,100); //�����
				default:
					%Question = %Type%1000;
					%bReversed = mfloor(%Type/1000);
					%strQuestion = $HuoDong_BJCCC_Q[%Question];
					//echo( "%Question==========" @ %Question );
					//echo( "%bReversed==========" @ %bReversed );
					//echo( "%strQuestion==========" @ %strQuestion );
					if (%bReversed == 2)//�Ƿǵߵ�
						%Yes = 0;
					else
						%Yes = 1;
					OpenBaJieCaiCaiCaiPloyWndGui(%Yes,%Question);
			}
		case 14://������ܽ���
			UI_OpenKLJLifeSkillWnd(%Type);
		case 15:
			SetTextForXuanShangJiXiongWnd();//ˢ�����ͼ��׽���
		case 16:
			//echo( "%Type ===========" @ %Type );
			switch (%Type)
			{
				case 1:%Nmae = "����";
				case 2:%Nmae = "����";
				case 3:%Nmae = "��ȸ";
				case 4:%Nmae = "�׻�";
			}
			%Text = "<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>ǰ�� </t>" @
				"<t m ='0' f='����' n='14' c='0xff00ffff' v='1'>" @ %Nmae @ " </t><t>��������ս��ħ</t>" @
				"<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>��̤�����ţ����θ�����ʧ�ܣ�</t>";
			Dialog_OK_Cancel.setContent(%Text);
			Dialog_OK_Cancel.setOk("ȷ��","");//ͨѶ�����
			Dialog_OK_Cancel.SetCancel("ȡ��","");
			Dialog_OK_Cancel.setVisible(1);
		case 17://�л���ͼ����¼ʱ�ͻ��˴���
			SvrEventTransporClient(%Player,%Type);
		case 18://�ƽ𱦲ص�ͨѶ
			echo("%Type ===�ƽ𱦲ص�ͨѶ========" @ %Type);
			switch (%Type)
			{
				case 1:%Nmae = "����";
				case 2:%Nmae = "����";
				case 3:%Nmae = "��ȸ";
				case 4:%Nmae = "�׻�";
			}
			%Text = "<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>ǰ�� </t>" @
				"<t m ='0' f='����' n='14' c='0xff00ffff' v='1'>" @ %Nmae @ " </t><t>������</t>" @
				"<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>��̤�����ţ����θ�����ʧ�ܣ�</t>";
			Dialog_OK_Cancel.setContent(%Text);
			Dialog_OK_Cancel.setOk("ȷ��","");//ͨѶ�����
			Dialog_OK_Cancel.SetCancel("ȡ��","");
			Dialog_OK_Cancel.setVisible(1);
		case 19:
			switch (%Type)
			{
				case 1://���ɴ���
					OpenKLJFaction_CreatorWnd();
				case 2://��������
					%Text = "<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>���ΰ���������Ҫ </t>" @ "<l i='105105303' t='itemid'/>" @ "<t>* 10���Ƿ�ȷ����������</t>";
					Dialog_OK_Cancel.setContent("<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>" @ %Text @ "</t>");
					Dialog_OK_Cancel.setOk("ȷ��","ClientOnSptAction( 22, 2 );");//ͨѶ�����
					Dialog_OK_Cancel.SetCancel("ȡ��","");
					Dialog_OK_Cancel.setVisible(1);
				case 3://��������
					%Text = "<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>���ΰ���������Ҫ </t>" @ "<l i='105105304' t='itemid'/>" @ "<t>* 10���Ƿ�ȷ����������</t>";
					Dialog_OK_Cancel.setContent("<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>" @ %Text @ "</t>");
					Dialog_OK_Cancel.setOk("ȷ��","ClientOnSptAction( 22, 3 );");//ͨѶ�����
					Dialog_OK_Cancel.SetCancel("ȡ��","");
					Dialog_OK_Cancel.setVisible(1);
				case 4://��������
					%Text = "<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>���ΰ���������Ҫ </t>" @ "<l i='105105304' t='itemid'/>" @ "<t>* 50 </t> " @ "<l i='105105305' t='itemid'/>" @ "<t>* 1���Ƿ�ȷ����������</t>";
					Dialog_OK_Cancel.setContent("<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>" @ %Text @ "</t>");
					Dialog_OK_Cancel.setOk("ȷ��","ClientOnSptAction( 22, 4 );");//ͨѶ�����
					Dialog_OK_Cancel.SetCancel("ȡ��","");
					Dialog_OK_Cancel.setVisible(1);
				case 5://��������
					%Text = "<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>���ΰ���������Ҫ </t>" @ "<l i='105105304' t='itemid'/>" @ "<t>* 100 </t> " @ "<l i='105105305' t='itemid'/>" @ "<t>* 10���Ƿ�ȷ����������</t>";
					Dialog_OK_Cancel.setContent("<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>" @ %Text @ "</t>");
					Dialog_OK_Cancel.setOk("ȷ��","ClientOnSptAction( 22, 5 );");//ͨѶ�����
					Dialog_OK_Cancel.SetCancel("ȡ��","");
					Dialog_OK_Cancel.setVisible(1);
				case 6:
				case 666://��ѯ����
					Org_Query(1);
			}
		case 20://ˢ�³�ֵ�������
			echo("ˢ�³�ֵ������� ====" @ %type);
			RefreshChargeGiftWnd(%type);
		case 21://������ʹ�����������ж�
			echo("TYpe ==============" @ %type);
			%Text = "<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>����ǰ�ڸ����ڣ��Ƿ�ȷ��ʹ�ûسǾ� </t>";
			Dialog_OK_Cancel.setContent("<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>" @ %Text @ "</t>");
			Dialog_OK_Cancel.setOk("ȷ��","ClientOnSptAction( 28," @  %Type @ ");");//ͨѶ�����
			Dialog_OK_Cancel.SetCancel("ȡ��","");
			Dialog_OK_Cancel.setVisible(1);
		
		case 22:	//������ʱ����������ʾ
			ShowFlashSalePageNum(%type);

	}
}

//
//�����������������������ͻ���ͨѶ���ýű����¡�����������������������������������



//�����������������������ͻ����ռ�����˴��͵��ַ���������������������������������
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
			ScheduleSetMainbtnBlink();//ˢ�°�ť��Ч
		case 3://��ħԨ�����ͻ��˽��津��
			LianMoYuanFuBenTongJiWnd(%Player,%Text);
		case 4://ʱ���Ѻ۸����ͻ��˽�����ʾ
			ShiKongLieHenFuBenTongJiWnd(%Player,%Text);
		case 5://Ѫħ��ӡ�󸱱��ͻ��˽�����ʾ
			XueMoFengYinZhenFuBenTongJiWnd(%Player,%Text);
		case 6://�þ����Ը����ͻ��˽�����ʾ
			HuanJingZhengBaFuBenTongJiWnd(%Player,%Text);
		case 7://�������������ͻ��˽�����ʾ
			YunXianJieDaTaoShaFuBenTongJiWnd(%Player,%Text);
		case 8://�������򸱱��ͻ��˽�����ʾ
			DaoJianShenYuFuBenTongJiWnd(%Player,%Text);
		case 9:
			Rise_ConfirmDlg(GetWord(%Text,0),GetWord(%Text,1),GetWord(%Text,2),60);
		case 10://��Ӫ������ÿ���1
			$SL_YunYingHuoDong1 = %text;
		case 11://���濪������
			GetAllWndNeedOpen(%Text);
		case 12://��Ӫ������ÿ���2
			$SL_YunYingHuoDong2 = %text;
			Schedule(3000, 0, "SetAllYunYingbActive");
		
		case 13:	//��ʱ�������߸���
			analysisXianShiQiangGouReceiveInfo(%text);
		
		//��ɫ����ʱ�ͻ��˽�����ʱ��������Ʒ���
		case 14:
			XianShiQiangGou_ReceiveClientKuCunNum(%text);
		
		//��ɫ������ʱ�̵���Ʒʱ�ͻ��˽�����ʱ��������Ʒ���
		case 15:
			%shopID = GetWord(%text,0);
			%index  = GetWord(%text,1);
			%KuCun  = GetWord(%text,2);
			%SelfCnt = GetWord(%text,3);
			$XianShiQiangGou_ItemKuCun[$CurrentLineId, %shopID, %index] = %KuCun;
	}
}

//�����������������������ͻ����ռ�����˴��͵��ַ���������������������������������


//�����������������������ͻ�����ѶϢ�ű�����������������������������������������
//HelpDirectByIndex
function ShowHelpDirectByIndex(%index)
{
	%Player = GetPlayer();

	//ָ����ʶ���
	//OpenHelpDirectWnd(%aimCtrl,%type,%Horiz,%Vert,%txt,%time,ƫ��)
	//%aimCtrl(Ҫָ��Ŀؼ���)
	//%type(1 ��ͷ����  2 ��ͷ���� 3 ��ͷ���� 4 ��ͷ����)
	//%Horiz (1 ��ƫ�� 2��  3��ƫ��)
	//%Vert(1 ��ƫ�� 2��  3��ƫ��)
	//%txt(Ҫ��ʾ������,֧�ִ�����)
	//%time(�رս����ʱ��,0Ϊ���ر�)
	//ƫ�ƣ��������£���������
	//��:OpenHelpDirectWnd("PlayerIconGui",1,3,3,"��������ʾ������Ϣ�ĵط�",8000);
	//����ͼ�� -> ""PlayerIconGui""
	//����ͼ�� -> ""TeammateIconGui""
	//����ͼ�� -> ""PetIconGui""
	//Ŀ��ͼ�� ->  ""TargetPlayerIconGui""
	//�ײ�������-> ""BottomControlWndGui""
	//С��ͼ  -> ""BirdViewMapGui""
	//���촰�� ->""ChatWndGuiAll""
	//����׷�� -> ""MissionTraceWnd""
	//��ݰ�ť��1 -> ""BottomControlWndGui""
	//��ݰ�ť��2 -> ""BottomControlWndGui1""
	//�������"" ->MissionWndGui_EntireWnd
	//����(��)����"" ->AllBagWndGui
	//����(��)����"" ->SingleBagWndGui
	//������Ի�����"" ->MissionDialogWndGui
	//�ӽ�������ϸ��������"" ->MissionDialog2ClildWndGui
	//�����Ͻ���Ʒ����"" ->MissionDialog3WndGui
	//�¼�����ʾ��""     ->SkillHintWndGui
	//��ͼ���� -> ""BigViewMap""
	//���޽��� -> ""PetInfoGui""
	//BUFF����(�Լ�)-> ""ShowBuffWnd""
	//BUFF����(Ŀ��)-> ""ObjectBuffWnd""
	//����ѧϰ����->""SkillStudyWndGui""
	//����ϵѡ�� ->""SkillSelectWndGui""
	//������ʾ���� ->""UpgradeHintButton""
	//�������� ->"ItemAppraiseWndGui"
	//�������� -> Puddler_MainWnd
	//����������� -> LifeBeadMainWnd
	//��ӽ���� -> NewTeamWndGui
	//װ�����׿� -> EquipStrengthenWnd
	//���䱦��� -> GrowAssistantTurnOnBnt

	//�ӳٹر�ʱ��
	%Time = 60000;
	//Ĭ�������ʽ
	%GeSi = $Get_Dialog_GeShi[41603];

	switch (%index)
	{
		case 1:
			$UpLinePartyWndRecord= 5;
			OpenOrCloseUpLinePartyWndGui();//����ȡ��Ʒ����
		case 2://�򿪱�ʯ
			ChoseOpenKLJGemStoneWnd(1);
		case 3://�򿪼���
			OpenKLJEquipStrengGui();
		case 4://��ǿ��
			OpenKLJStrengthenByType(1);
		case 5://������
			OpenMailWnd();
		case 6://��ɫ��ʼ��
			Birdthree2p9to3ButtonChickB();//��ʼ��ʱ�л��ӽ�
			Schedule(2000,0,"SvrEventTransporClient",%Player,1);
		case 7://�½�ɫ��ɵ�һ�η���·�����Զ�Ѱ��
			$UpLinePartyWndRecord= 1;
			//OpenOrCloseUpLinePartyWndGui( );//����ȡ��Ʒ����
			findpath(410100012);
		case 8://�����ͼ��׽���
			OpenOrCloseXuanShangJiXiongWnd();
		case 9://�򿪼�������
			OpenKLJKamPoWnd();
		case 10://����ʯ�ϳɽ���
			OpenKLJGodStoneGui();
		case 11://ˢ�¹��Խ���
			//echo( "============ˢ�¹��Խ���============" );
			//Schedule( 3000, 0, "GetStrategyWndText" );
			GetStrategyWndText();
		case 12:
			ExecedWhenEndFindPath(10061,0);//ָ��ʰȡ������
		case 13://���������
			OpenOrCloseEquipNpcRepairGui();
		case 14://��ָ������
			OpenPKGuidanceGui();
		case 15://�ֽⴥ��
			CloseHelpDirectByIndex(60,0);
		case 16:
			OpenDouFuGan(10);
		case 17:
			PengLaiDaoJing_ChuFa();//�ɼ���������
		case 18:
			ZiDongZhanDou_ZhiYin();
		case 19://Ԫ������
			OpenKLJGoldTradingGuiWnd();
		case 20://����ָ�����رհ���
			OpenDouFuGan( 23 );
			CloseAllBag();
		case 21:
			//echo( "ͨѶ�յ���������Ч" );
			$BirdPrefButton_Blink = 0;
			BirdPrefButton_Blink.Setvisible(1);
		case 22:
			OpenDouFuGan(25);
		case 23://ˢ�¾۱������
			if (!CornucopiaWnd.IsVisible())
				OpenOrCloseCornucopiaWnd();
			UpdateCornucopiaWnd();
			SetMainbtnBlink();
		case 24://�������ѧϰ����
			OpenLifeSkillStudyWndGui();
		case 25:findpath(410101007);//���н������Զ�Ѱ��
		case 26:findpath(410100055);
		case 27://�򿪹���ս����
			OpenKLJAttackCityWndGui();
		case 28://�򿪱���
			OpenAllBag();
		case 29:
			ShowDialogOK("���ѽ���ƣ����Ϸʱ�䣬�޷����븱�����Ϊ�����Ľ������뾡��������Ϣ�����ʵ�������������ѧϰ����");
		case 30:addMotionBlurScreenEffect( 2000 );
		case 31://ˢ�°��ɻ����
			ShowFactionWndGuiType(3);
		case 64:
			AddEffect(1,GetPlayer(),$SP_Effect[1]);	//���ͽ���������Ч
		case 65:
			AddEffect(1,GetPlayer(),$SP_Effect[2]);	//���ͽ���������Ч
	}
}

function Spirit_Skill_Face()
{
	if (HelpDirectWndGui_1.isVisible() == 1)
		ShowHelpDirectByIndex(29);
}


//�����������������������ͻ�����ѶϢ�ű�����������������������������������������
