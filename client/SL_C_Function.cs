//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//�ͻ��˺����ű�����ֻ�ڿͻ���ʹ�ã������������鲻�����˺���ʹ����ͬ����
//==================================================================================

//�����������������������������ֻع�����Ч��������������������������������������
//������������������������ȡ����ǰ��ͼ���������������������������������������
//����������������������NPC���������Ұ�����������Ƿ�Ҫ��������Ч��������������
//�����������������������ͻ�������������á�������������������������������������
//�����������������������ͻ���������ʾ�����������������������������������������

//�������������������������水ť������������������������������������������������

//�����������������������ͻ�����ʾС��ͼ���������������������������������������
//�����������������������ֿ���չ������������������������������������������������
//�����������������������ĳ�����Ӱ������������������������������
//��������������������������������������������������������������������������

//�����������������������������л����ͼ����������������������������������������
//�����������������������¹ⱦ�пؼ���������������������������������

//���������������������������ػ���˵���ű�����������������������������������������
//���������������������������Զ�װ�����ܹ��ܡ�������������������������������������
//�����������������������л���ͼ��������������������������������������������������

//����������������������������濪������������������������������������������������
//���������������������������Ҹ����������������������������������������������
//�������������������������Ԫ�������������������������������������������������

//����������������������Ѱ·����λ�ô���������������������������������������������

//����������������������ʹ�ð������ߴ���������������������������������������������
//�����������������������϶��������ߴ���������������������������������������������

//��������������������������¼�����ʾ�򴥷���������������������������������������

//���������������������ͻ���������������ָ���������������������������
//���������������������������ء�����������������������
//�������������������������÷�ƭ������Ϣ��������������������
//�������������������������⽱����ť�����������������������


//������������������������½ʱ��ӭ���津������������������������������������������
function uiClearUpLinePartyWnd()
{

}
function UpdateUpLinePartyWnd()
{

}
function DengLuJieMianePartyWnd()
{
	//��½ʱ��ӭ���津��
	//if ( $OpenUpLinePartyWnd == 1 )
	//	OpenUpLinePartyWnd( 3 );
	//else
	//	OpenUpLinePartyWnd( 1 );
	//
	//$OpenUpLinePartyWnd = 0;
}
//������������������������½ʱ��ӭ���津������������������������������������������

//�����������������������������ֻع�����Ч��������������������������������������
function GetCurMetempsychosisEffectId(%Leve)
{
	if (%Leve == 1) return 690761;
	else if (%Leve == 2) return 690762;
	else if (%Leve >= 2) return 690763;

	return 0;
}
//�����������������������������ֻع�����Ч��������������������������������������

//������������������������ȡ����ǰ��ͼ���������������������������������������
//��ȡ����ǰ��ͼ��
function GetMissionIcon(%MID)
{
	switch (GetMissionData(%MID,$Mission_Data_Type))
	{
		case 0:	return $Icon[18];	//"��ʥ������"//֧���������ͼ��
		case 1:	return $Icon[17];	//"���»�����"//�����������ͼ��
		case 2:	return $Icon[18];	//"��֧�߾��顽"//֧���������ͼ��
		case 3:	return $Icon[19];	//"��ÿ��ѭ����"//ѭ���������ͼ��
		case 4:	return $Icon[18];	//"����������"//֧���������ͼ��
		case 5:	return $Icon[18];	//"��ָ������"//֧���������ͼ��
		case 6:	return $Icon[18];	//"�������"//֧���������ͼ��
		case 7:	return $Icon[18];	//"����������"//֧���������ͼ��
		default: return $Icon[18];	//֧���������ͼ��
	}
}
//������������������������ȡ����ǰ��ͼ���������������������������������������

//����������������������NPC���������Ұ�����������Ƿ�Ҫ��������Ч��������������
//NPC���������Ұ�����������Ƿ�Ҫ��������Ч
function Player::inNpcScope(%Player,%Npc)
{
	%NpcID = %Npc.GetDataID();
	//echo( "%Npc ===" @ %Npc @ "    %NpcID===" @ %NpcID );
	switch (%NpcID)
	{
		case 410100012:
			if (GetPlayer().IsAcceptedMission(10002))
				%Npc.Addpacket(900159);
	}
}
//����������������������NPC���������Ұ�����������Ƿ�Ҫ��������Ч��������������

//�����������������������ͻ�������������á�������������������������������������
function ClientEventLevelUp(%PlayerID)
{
	%Player = GetPlayer();
	%Lv = %Player.GetLevel();
	%LunHuiLv = %Player.GetMetempsychosis();
	LevelJudgeOnlineReward(%lv);//ˢ�����߽�������
	//��ˢ���������Ŀɽ���
	RefreshMission(%Player,99,0);

	//�ͻ���������������ָ������
	ClientLeve_BangZhuJieMian(%Lv);
	//�������ܵ�ָ��ͼ��
	if (isCanLearnNewSkill() && %Lv > 30)
		PlayerSkillStudyGui.setvisible(1);
	switch (%Lv)
	{
		case 10:
			OpenDouFuGan(14);
		case 35://35����������ָ������
			OpenKLJMissionGuidanceGui();
	}
	if ($WndNeedOpen !$= "")
		GetAllWndNeedOpen($WndNeedOpen);//ˢ�µ�ͼ����İ�ť����
	if ($YunYingbActiveText !$= "")
		SetAllYunYingbActive();//ˢ����Ӫ���ť
	

}

//�����������������������ͻ���������ʾ�����������������������������������������
function GetPlayerLvHelpTxt(%Lv,%isHistroy)
{
}
//�����������������������ͻ���������ʾ�����������������������������������������




//�����������������������ͻ�����ʾС��ͼ���������������������������������������

function OnEnterTrigger(%TriggerId)
{
	//echo( "%TriggerId====" @ %TriggerId );
	//	%TriggerId = %Player.GetTriggerId();
	//
	//	if(GetSubStr(GetZoneID(),0,4) $= "1333" && GetSubStr(%TriggerId,6,1) > 1 )
	//		ShowHelpDirectByIndex(200);
}
//�����������������������ͻ�����ʾС��ͼ���������������������������������������


//�����������������������ֿ���չ������������������������������������������������
function Cs_ShowBankText(%Num)
{
	//echo( "�ֿ���չ��������===" @ %Num );
	switch (%Num)
	{
		case 12:return "<t>10��ʱ����ѿ���6��ռ� </t>";
		case 18:return "<t>����ռ���Ԫ����100  </t>"@$Icon[89];
		case 24:return "<t>����ռ���Ԫ����500  </t>"@$Icon[89];
		case 30:return "<t>����ռ���Ԫ����500  </t>"@$Icon[89];
		case 36:return "<t>����ռ���Ԫ����1000 </t>"@$Icon[89];
		case 42:return "<t>����ռ���Ԫ����1000 </t>"@$Icon[89];
		case 48:return "<t>����ռ���Ԫ����1000 </t>"@$Icon[89];
		case 54:return "<t>����ռ���Ԫ����1000 </t>"@$Icon[89];
		case 60:return "<t>����ռ���Ԫ����1000 </t>"@$Icon[89];
		case 66:return "<t>����ռ���Ԫ����1000 </t>"@$Icon[89];
		case 72:return "<t>����ռ���Ԫ����1000 </t>"@$Icon[89];
		case 78:return "<t>����ռ���Ԫ����1000 </t>"@$Icon[89];
		case 84:return "<t>����ռ���Ԫ����1000 </t>"@$Icon[89];
		case 90:return "<t>���Ѿ����ֿ�ȫ����չ��</t>";
	}
}
//�����������������������ֿ���չ������������������������������������������������

//�����������������������ĳ�����Ӱ������������������������������
//�ĳ�����Ӱ
function SetLightForNormal()
{
	//	if(GetZoneID() !$= "131001")
	//		return;

	//����Flash
	OpenGameTaskSectionWnd(31);

	//�Ļ�����ɫ ����
	setSunLight("0.35 0.35 0.3 1","0.7 0.7 0.45 1","0.75 0.75 0.45 1","0 0.1 0.7 1","0.4 0.996078 0.996078 0");
}

function SetLightForEvilMode()
{
	if (GetZoneID() !$= "131001")
		return;

	//����Flash
	OpenGameTaskSectionWnd(32);

	//�Ļ�����ɫ ����
	Schedule(2000,0,"SetSunLigthForFSZH",0);
}

function SetSunLigthForFSZH(%index)
{
	//0 ��ҹģʽ 1 ����ģʽ
	if (%index == 0)
		setSunLight("0.223529 0.329412 0.431373 1","0.729412 0.807843 0.882353 1","0.101961 0.109804 0.384314 1","0.05098 0.05098 0.07451 1","0.078431 0.215686 0.345098 0");
	else if (%index == 1)
		setSunLight("0.35 0.35 0.3 1","0.7 0.7 0.45 1","0.75 0.75 0.45 1","0 0.1 0.7 1","0.4 0.996078 0.996078 0");
}

//�����������������������ĳ�����Ӱ������������������������������

//��������������������������������������������������������������������������
//��ɫ��¼ʱˢ�°����������
function SetFamilyMissionWnd()
{
	%Player = GetPlayer();
	%Family = %Player.GetFamily();
}
//��������������������������������������������������������������������������



//���������������������������ػ���˵���ű�����������������������������������������
function Org_GetBossInfo(%BossID,%BossGet)
{
	%Player = GetPlayer();

	//��ȡ�ػ�������
	%BossName = GetNpcData(%BossID,$Monster_Data_Name);
}
//���������������������������ػ���˵���ű�����������������������������������������



//�����������������������������л����ͼ����������������������������������������
function ViewMapChangeTig()
{
	//echo("�������л����ͼ����==="  @ $SelectBigMapName);
	//ɾ�����ͼ��ʶ
	BigViewMapCtrl.clearTmpBitmaps();

	RefreshMaterialSign($SelectBigMapName);

	if ($SelectBigMapName $= "��ص�ͼ")Theurgy_CoachDirection(2);
	else if ($SelectBigMapName $= "������")
	{
		Theurgy_CoachDirection(3);
		Theurgy_CoachDirection(11);
	}
}
//�����������������������������л����ͼ����������������������������������������


//�����������������������¹ⱦ�пؼ���������������������������������
if (ShopWnd_NpcZHJM.isvisible())
{
	ShopWnd_NpcZHJM.Setvisible(0);
	ShopWnd_NpcZHJM.delete();
}
new GuiBitmapWindowCtrl(ShopWnd_NpcZHJM)
{
	canSaveDynamicFields = "0";
	Enabled = "1";
	isContainer = "1";
	LogicLayer = "0";
	HorizSizing = "center";
	VertSizing = "center";
	position = "600 300";
	Extent = "300 172";
	MinExtent = "8 2";
	canSave = "1";
	Visible = "0";
	mustPrerender = "0";
	caseFreeze = "1";
	tooltipWidth = "100";
	hovertime = "1000";
	alpha = "255";
	useFadeout = "1";
	wrap = "0";
	MoveHotspot = "0 0 1024 768";
	bitmap = "gameres/gui/images/YueGuangBaoHe.png";

	//������������������
	new GuiTextEditCtrl(BatchSellWnd_TextEdit_CH1){
		canSaveDynamicFields = "0";
		Enabled = "1";
		isContainer = "0";
		Profile = "GuiGeneralTextEditProfile_3";
		HorizSizing = "right";
		VertSizing = "bottom";
		position = "220 42";
		Extent = "70 24";
		MinExtent = "8 2";
		canSave = "1";
		Visible = "1";
		mustPrerender = "0";
		hovertime = "1000";
		Margin = "0 0 0 0";
		Padding = "0 0 0 0";
		AnchorTop = "1";
		AnchorBottom = "0";
		AnchorLeft = "1";
		AnchorRight = "0";
		maxLength = "1024";
		historySize = "0";
		password = "0";
		tabComplete = "0";
		KeyEnter = "1";
		bUseMaxNum = "0";
		bUseMinNum = "0";
		maxNum = "499999999";
		minNum = "1";
		sinkAllKeyEvents = "0";
		passwordMask = "*";
		textCanOffset = "0";
		Text = "";
	};

	//����š�����������
	new GuiTextEditCtrl(BatchSellWnd_TextEdit_CH2){
		canSaveDynamicFields = "0";
		Enabled = "1";
		isContainer = "0";
		Profile = "GuiGeneralTextEditProfile_3";
		HorizSizing = "right";
		VertSizing = "bottom";
		position = "88 111";
		Extent = "146 24";
		MinExtent = "8 2";
		canSave = "1";
		Visible = "1";
		mustPrerender = "0";
		hovertime = "1000";
		Margin = "0 0 0 0";
		Padding = "0 0 0 0";
		AnchorTop = "1";
		AnchorBottom = "0";
		AnchorLeft = "1";
		AnchorRight = "0";
		maxLength = "1024";
		historySize = "0";
		password = "0";
		tabComplete = "0";
		KeyEnter = "1";
		bUseMaxNum = "0";
		bUseMinNum = "0";
		maxNum = "499999999";
		minNum = "1";
		sinkAllKeyEvents = "0";
		passwordMask = "*";
		textCanOffset = "0";
		Text = "999999999";
	};

	//������������������
	new GuiTextEditCtrl(BatchSellWnd_TextEdit_CH3){
		canSaveDynamicFields = "0";
		Enabled = "1";
		isContainer = "0";
		Profile = "GuiGeneralTextEditProfile_3";
		HorizSizing = "right";
		VertSizing = "bottom";
		position = "88 135";
		Extent = "146 24";
		MinExtent = "8 2";
		canSave = "1";
		Visible = "1";
		mustPrerender = "0";
		hovertime = "1000";
		Margin = "0 0 0 0";
		Padding = "0 0 0 0";
		AnchorTop = "1";
		AnchorBottom = "0";
		AnchorLeft = "1";
		AnchorRight = "0";
		maxLength = "1024";
		historySize = "0";
		password = "0";
		tabComplete = "0";
		KeyEnter = "1";
		bUseMaxNum = "0";
		bUseMinNum = "0";
		maxNum = "499999999";
		minNum = "1";
		sinkAllKeyEvents = "0";
		passwordMask = "*";
		textCanOffset = "0";
		Text = "1";
	};

	//����������ť
	new GuiButtonCtrl(BatchSellWnd_SSButton)
	{
		canSaveDynamicFields = "0";
		Enabled = "1";
		isContainer = "0";
		Profile = "GuiTheurgyUseButtonProfile";
		HorizSizing = "right";
		VertSizing = "bottom";
		position = "210 55";
		Extent = "80 50";
		MinExtent = "8 2";
		canSave = "1";
		Visible = "1";
		mustPrerender = "0";
		Command = "ShopWnd_NpcZHJM_SSButton();";
		hovertime = "1000";
		text = "�� ��";
		groupNum = "-1";
		buttonType = "PushButton";
		useMouseEvents = "0";
		IsStateOn = "0";
	};

	//ȷ�ϰ�ť
	new GuiButtonCtrl(BatchSellWnd_OKButton)
	{
		canSaveDynamicFields = "0";
		Enabled = "1";
		isContainer = "0";
		Profile = "GuiTheurgyUseButtonProfile";
		HorizSizing = "right";
		VertSizing = "bottom";
		position = "210 100";
		Extent = "80 70";
		MinExtent = "8 2";
		canSave = "1";
		Visible = "1";
		mustPrerender = "0";
		Command = "ShopWnd_NpcZHJM_Search();";
		hovertime = "1000";
		text = "ȷ ��";
		groupNum = "-1";
		buttonType = "PushButton";
		useMouseEvents = "0";
		IsStateOn = "0";
	};

	//�رհ�ť
	new GuiButtonCtrl(BatchSellWnd_CancelButton)
	{
		canSaveDynamicFields = "0";
		Enabled = "1";
		isContainer = "0";
		Profile = "GuiCloseButtonProfile2";
		HorizSizing = "right";
		VertSizing = "bottom";
		position = "262 5";
		Extent = "25 25";
		MinExtent = "8 2";
		canSave = "1";
		Visible = "1";
		mustPrerender = "0";
		hovertime = "1000";
		groupNum = "-1";
		buttonType = "PushButton";
		useMouseEvents = "0";
		IsStateOn = "0";
		Command = "ShopWnd_NpcZHJM.setVisible(0);";
	};

	//����š���ʾ
	new GuiRichTextCtrl(BatchSellWnd_CancelButton1)
	{
		canSaveDynamicFields = "0";
		Enabled = "1";
		isContainer = "0";
		LogicLayer = "0";
		Profile = "ONineProfile";
		HorizSizing = "right";
		VertSizing = "bottom";
		position = "24 109";
		Extent = "60 20";
		MinExtent = "8 2";
		canSave = "1";
		Visible = "1";
		mustPrerender = "0";
		tooltipWidth = "100";
		hovertime = "1000";
		LineHeight = "16";
	};

	//����������ʾ
	new GuiRichTextCtrl(BatchSellWnd_CancelButton2)
	{
		canSaveDynamicFields = "0";
		Enabled = "1";
		isContainer = "0";
		LogicLayer = "0";
		Profile = "ONineProfile";
		HorizSizing = "right";
		VertSizing = "bottom";
		position = "24 135";
		Extent = "60 20";
		MinExtent = "8 2";
		canSave = "1";
		Visible = "1";
		mustPrerender = "0";
		tooltipWidth = "100";
		hovertime = "1000";
		LineHeight = "16";
	};

	//�������
	new GuiScrollCtrl()
	{
		canSaveDynamicFields = "0";
		Enabled = "1";
		isContainer = "1";
		LogicLayer = "0";
		Profile = "GuiCurrencyScrollProfile_4";
		HorizSizing = "right";
		VertSizing = "bottom";
		position = "19 40";
		Extent = "170 60";
		MinExtent = "8 2";
		canSave = "1";
		Visible = "1";
		mustPrerender = "0";
		caseFreeze = "1";
		tooltipWidth = "100";
		hovertime = "1000";
		willFirstRespond = "1";
		hScrollBar = "alwaysOff";
		vScrollBar = "dynamic";
		constantThumbHeight = "0";
		childMargin = "0 0";

		new GuiListBoxAdvCtrl(BatchSellWnd_CancelButton3)
		{
			HorizSizing = "right";
			VertSizing = "bottom";
			position = "19 40";
			Extent = "170 56";
			MinExtent = "8 2";
			canSave = "1";
			columns = "170";
			lineHeight = "18";
			isOnRender = 1;
			selectImage = "gameres/gui/images/GUIbutton02_1_014";
			overImage   = "gameres/gui/images/GUIbutton02_1_013";
		};
	};
};

GameMainWndGui_Layer4.Add(ShopWnd_NpcZHJM);


function Set_ShopWnd_NpcZHJM(%III)
{
	$ShopWnd_NpcZHJM = %III;
	if (ShopWnd_NpcZHJM.isVisible() == 0)
		ShopWnd_NpcZHJM.setVisible(1);

	if (%III == 2  || %III == 1)
	{
		BatchSellWnd_TextEdit_CH1.setVisible(1); //��������
		BatchSellWnd_SSButton.setVisible(1); 			//������ť
		BatchSellWnd_CancelButton3.setVisible(1); //�������
	}
	else
	{
		BatchSellWnd_TextEdit_CH1.setVisible(0); //��������
		BatchSellWnd_SSButton.setVisible(0); 			//������ť
		BatchSellWnd_CancelButton3.setVisible(0); //�������
	}

	%Tab1 = "<t f='����' m='0' n='14' b='1' gct='0xffff00ff' gcb='0xd9680dff'>";

	BatchSellWnd_CancelButton1.Setcontent(%Tab1 @ "���</t>");
	if (%III  == 6)
		BatchSellWnd_CancelButton2.Setcontent(%Tab1 @ "����</t>");
	else
		BatchSellWnd_CancelButton2.Setcontent(%Tab1 @ "����</t>");
}

function ShopWnd_NpcZHJM_SSButton()
{
	BatchSellWnd_CancelButton3.clearitems();

	//��ȡ������Ʒ
	%ITEMText = BatchSellWnd_TextEdit_CH1.GetValue();

	if (%ITEMText $= "")
		return;

	if ($ShopWnd_NpcZHJM == 1)
		%ITEMNum = QueryNPCIDS_ByName(%ITEMText,2);

	else if ($ShopWnd_NpcZHJM == 2)
		%ITEMNum = QueryItemIDS_ByName(%ITEMText,2);		//ɸѡ������Ʒ

	%Tab = "<t f='����' m='0' n='13' b='1' v='1' c='0x00b0f0ff'>";

	if (%ITEMNum $= "")
	{
		BatchSellWnd_CancelButton3.AddItem(%Tab @ "�����ڸ���Ʒ��</t>" TAB "<t>" @ %TiemID @ "</t>",0);
		return;
	}

	if ($ShopWnd_NpcZHJM == 1)
	{
		%WordCount = GetWordCount(%ITEMNum);
		for (%i = 0; %i < %WordCount; %i++)
		{
			%TiemID = GetWord(%ITEMNum,%i);
			BatchSellWnd_CancelButton3.AddItem(%Tab @ getNpcData(%TiemID,1) @ "    " @ getNpcData(%TiemID,2) @ "</t>" TAB "<t>" @ %TiemID @ "</t>",%i);
			BatchSellWnd_CancelButton3.SetCommand("BatchSellWnd_TextEdit_CH2.setText(" @ %TiemID @ ");",%i);
		}
	}
	else if ($ShopWnd_NpcZHJM == 2)
	{
		%WordCount = GetWordCount(%ITEMNum);
		for (%i = 0; %i < %WordCount; %i++)
		{
			%TiemID = GetWord(%ITEMNum,%i);
			BatchSellWnd_CancelButton3.AddItem(%Tab @ GetItemData(%TiemID,1) @"</t>" TAB "<t>" @ %TiemID @ "</t>",%i);
			BatchSellWnd_CancelButton3.SetCommand("BatchSellWnd_TextEdit_CH2.setText(" @ %TiemID @ ");",%i);
		}
	}
}

//ȷ��
function ShopWnd_NpcZHJM_Search()
{
	%text = BatchSellWnd_TextEdit_CH2.GetValue();
	%text_CH3 = BatchSellWnd_TextEdit_CH3.GetValue();

	if ($ShopWnd_NpcZHJM == 1)
	{
		if (GetNpcData(%text,0) !$= "")
		{
			ClientOnSptAction(1,%text_CH3);
			ClientOnSptAction(2,%text);
		}
		else
			SetScreenMessage("�����Ŵ���",$Color[2]);
	}
	else if ($ShopWnd_NpcZHJM == 2)
	{
		if (GetItemData(%text,0) !$= "")
		{
			ClientOnSptAction(1,%text_CH3);
			ClientOnSptAction(3,%text);
		}
		else
			SetScreenMessage("���߱�Ŵ���",$Color[2]);
	}
	else if ($ShopWnd_NpcZHJM == 3)
	{
		if (GetCollectionObjectname(%text) !$= "")
		{
			ClientOnSptAction(1,%text_CH3);
			ClientOnSptAction(4,%text);
		}
		else
			SetScreenMessage("�ɼ���Ŵ���",$Color[2]);
	}
	else if ($ShopWnd_NpcZHJM == 4)
	{
		if (GetMissionData(%text,$Mission_Data_Mid) !$= "")
		{
			ClientOnSptAction(1,%text_CH3);
			ClientOnSptAction(5,%text);
		}
		else
			SetScreenMessage("�����Ŵ���",$Color[2]);
	}
	else if ($ShopWnd_NpcZHJM == 5)
	{
		if (GetPetData(%text,0) !$= "")
		{
			ClientOnSptAction(1,%text_CH3);
			ClientOnSptAction(6,%text);
		}
		else
			SetScreenMessage("���ޱ�Ŵ���",$Color[2]);
	}
	else if ($ShopWnd_NpcZHJM == 6)
	{
		if ((GetSubStr(%text,0,1) $= "2" || GetSubStr(%text,0,1) $= "3") && (strlen(%text) == 9))
		{
			ClientOnSptAction(1,%text_CH3);
			ClientOnSptAction(8,%text);
		}
		else
			SetScreenMessage("BUFF���߼��ܱ�Ŵ���",$Color[2]);
	}
}

//���������������������������Զ�װ�����ܹ��ܡ�������������������������������������
// װ����ʱ�Զ����ؼ���
function GetAutoLoadSkill(%PlayerClass)
{
	return $AutoLoadSkills[%PlayerClass];
}

// �����Զ����ؼ���
// %PlayerClass ���ְҵ
// %SkillID     ����ID
// %CoolTime    ����ʹ��ʱ����
function AddAutoLoadSkillConf(%PlayerClass,%SkillID,%CoolTime)
{
	%ConfObj = new ScriptObject()
	{
		SkillID  = %SkillID;
		CoolTime = %CoolTime;
	};

	$AutoLoadSkills[%PlayerClass] = $AutoLoadSkills[%PlayerClass] SPC %ConfObj;
}

for (%i = 0; %i < 5; %i++)
{
	$AutoLoadSkills[%i] = "";
}

//�佫
AddAutoLoadSkillConf(1,210010001,0);
AddAutoLoadSkillConf(1,210040001,0);

//����
AddAutoLoadSkillConf(2,220010001,0);
AddAutoLoadSkillConf(2,220020001,600);
AddAutoLoadSkillConf(2,220030001,0);

//��ʿ
AddAutoLoadSkillConf(3,230010001,0);
AddAutoLoadSkillConf(3,230020001,0);
AddAutoLoadSkillConf(3,230040001,60);

//��ʿ
AddAutoLoadSkillConf(4,240010001,0);
AddAutoLoadSkillConf(4,240020001,60);
AddAutoLoadSkillConf(4,240030001,0);

//����
AddAutoLoadSkillConf(5,250010001,0);
AddAutoLoadSkillConf(5,250020001,0);
AddAutoLoadSkillConf(5,250040001,12);

//���������������������������Զ�װ�����ܹ��ܡ�������������������������������������

//�����������������������л���ͼ��������������������������������������������������
function SvrEventTransporClient(%Player,%optype)//1��¼��2�л��̣߳�3�л���ͼ
{
	if (%Player == 0)
		return;
	//echo( "%Player =======================" @ %Player @ "					%optype=-=========================" @ %optype );
	%MapID = GetZoneID();
	%Triggerid = %Player.GetTriggerid();

	//ˢ�°�ť��Ч
	ScheduleSetMainbtnBlink();
	//��ʾ����׷����Ϣ,���ظ�����Ϣ
	if (%MapID <= 1300)
		Schedule(2000,0,"TaskTraceMessageAppear");
	//��ˢ���������Ŀɽ���
	RefreshMission(%Player, 99, 0);
	if (%optype == 1)
	{
		//��ȡpingֵ
		SetPingPack();
		//ˢ�����߽�������
		showFristOpenOnlineReward();

		//�������ܵ�ָ��ͼ��
		//echo( "�������ܵ�ָ��ͼ��===" @ isCanLearnNewSkill( ) @ "    " @  %Player.GetLevel( ) );
		if (isCanLearnNewSkill() && (%Player.GetLevel() > 30))
			PlayerSkillStudyGui.setvisible(1);
		else
			PlayerSkillStudyGui.setvisible(0);
		//���ع��Խ��������
		SetStrategyBtnText();
		if (!TimerTriggerCtrl_MinWndTX.isvisible())
			closeHelpDirect1_4(20);
	}
}


//�����������������������л���ͼ��������������������������������������������������

//����������������������������濪������������������������������������������������
function FillResurgenceModelMSG()
{
	//��ȡ���Player
	%Player = GetPlayer();

	%Activity = 2209;
	%ActivityA = GetWord(%Player.GetActivity(%Activity),0) * 1;
	%ActivityB = GetWord(%Player.GetActivity(%Activity),1) * 1;

	//��ʼ�����ť
	ReAliveModel_Tang_Button.Setactive(1);
	ReAliveModel_Gold_Button.Setactive(1);

	//�Ƿ��ֹ��Ҹ���
	%TriggerID[9] = GetTriggerData(%Player.GetTriggerId(),11);
	%TangBiFuHuoNo = HasBit(%TriggerID[9],16);

	//�Ƿ��ֹԪ������
	%TriggerID[9] = GetTriggerData(%Player.GetTriggerId(),11);
	%YuanBaoFuHuoNo = HasBit(%TriggerID[9],15);

	%TxtButton1 = "���ԭ�ظ���";

	//echo("�������==================");
	//��Ҹ������
	if (%TangBiFuHuoNo > 0)
	{
		ReAliveModel_Tang_Button.Setactive(0);
		%Txt1 = $Get_Dialog_GeShi[31406] @ "��ֹ��Ҹ���</t><b/><b/>" @ $Get_Dialog_GeShi[31402] @ "��ǰ�����޷���Ҹ����ѡ��������ʽ��</t>";
	}
	if (HasBit(GetTriggerData(%Player.GetTriggerId(),11),27))
	{
		%Txt1 = "<t>����ԭ�ظ���</t><b/><b/>" @ $Get_Dialog_GeShi[31402] @ "�����������Ľ�ң������޵�5��</t>";
		%TxtButton1 = "ԭ�ظ���";
	}
	else if ((%Player.GetMetempsychosis() == 0) && (%Player.GetLevel() < 20))
		%Txt1 = "<t>��ǰ��Ѹ���</t><b/><b/>" @ $Get_Dialog_GeShi[31402] @ "20�����¸����������Ľ�ҡ�</t>";
	else
	{
		%Money = FuHuoNeedMoney_Expend(%Player,1);
		if (%Money == 0)
		{
			%Txt1 = "<t>��ǰ��Ѹ���</t>" @ "<b/><b/>" @ $Get_Dialog_GeShi[31402] @ "����ʣ����Ѹ��������" @ GetMianFeiFuHuoNumber(%Player) - %ActivityA @ "��</t>";
		}
		else
		{
			if (%Player.GetMoney(2) < %Money)
				%TxtTangBi = "<b/>" @ $Get_Dialog_GeShi[31406] @ "��ǰ��Ҳ��㣡</t>";

			%Txt1 = "<t>���Ľ�ң�</t>" @ ChangeMoneyText(%money) @ " " @ %TxtTangBi @ "<b/><b/>" @ $Get_Dialog_GeShi[31402] @ "��Ҹ������ô�����" @ %ActivityA - GetMianFeiFuHuoNumber(%Player) @ "��</t>";
		}

	}

	ReAliveModel_Tang_Button.text = %TxtButton1;
	ReAliveModelMSG_1.Setcontent(%Txt1);

	//����㸴�����
	//if (HasBit_City_Force(%Player) == 1)
	//	%TriggerId = GetTriggerData(%Player.GetTriggerId(),6);
	//else
	//	%TriggerId = GetTriggerData(%Player.GetTriggerId(),8);

	%TriggerId = GetTriggerData(%Player.GetTriggerId(), 6);
	

	%TriggerId = (%TriggerId == 0) ? %Player.GetTriggerId() : "8" @ %TriggerId @ "0100";
	
	if (%TriggerId == 811190200)
		%TriggerId = 811190100;
	
	//echo("������濪������ =="  @ %TriggerId);

	%Txt2 = "����㣺" @ GetTriggerData(%TriggerId,3);

	//if ( %YuanBaoFuHuoNo == 0 )
	//	%Txt4 = "<b/><b/>" @ $Get_Dialog_GeShi[ 31402 ] @ "����㸴�����ԭ�ظ���ġ�������ġ���</t>";
	//else
	//	%Txt4 = "<b/><b/>" @ $Get_Dialog_GeShi[ 31402 ] @ "                     </t>";

	ReAliveModelMSG_2.Setcontent(%Txt2);

	//Ԫ���������
	if (%YuanBaoFuHuoNo > 0)
	{
		ReAliveModel_Gold_Button.Setactive(0);
		%Txt3 = $Get_Dialog_GeShi[31406] @ "��ֹԪ������</t><b/><b/>" @ $Get_Dialog_GeShi[31402] @ "��ǰ�����޷�Ԫ�������ѡ��������ʽ��</t>";
	}
	else
	{
		%Money = FuHuoNeedMoney_Expend(%Player,0);
		if (%Player.GetMoney(1) < %Money)
		{
			%cmd[1] = "OpenOrCloseChongZhiWndGui();";
			%Button[1] = "<c cid='" @ Get_TraceButton() @ "' cmd='\"" @ %cmd[1] @ "\",\"" @ $Get_Dialog_GeShi[31414]  @ "��ֵƽ̨" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />";

			%TxtYuanBao = "<b/>" @ $Get_Dialog_GeShi[31406] @ "��ǰԪ�����㣡</t><b/><b/>" @ $Get_Dialog_GeShi[31402] @ "Ԫ����ͨ��</t>" @ %Button[1] @ $Get_Dialog_GeShi[31402] @ "���г�ֵ��</t>";
		}
		%Txt3 = "<t>����Ԫ����</t>" @ %Money @ $Icon[89] @ %TxtYuanBao;
	}

	ReAliveModelMSG_3.Setcontent(%Txt3);

	%MapId = GetSubStr(GetZoneID(),0,4);
	
	//�����Զ����ظ���㸴��ʱ��
	if (%Player.GetTriggerId() == 811190200)$Resurgenc_lefttime = 8;
}
//����������������������������濪������������������������������������������������

//���������������������������Ҹ����������������������������������������������
function ReAliveModel_Tang_Cmd()
{
	//��ȡ���Player
	%Player = GetPlayer();
	%Money = FuHuoNeedMoney_Expend(%Player,1);

	if (%Player.GetMoney(2) < %Money)
	{
		SetScreenMessage("���Ľ�Ҳ��㣬�޷�ʹ�øø��",$Color[2]);
		return;
	}

	%Time = mFloor(getRiseCdTime() / 1000);
	if (%Time > 0)
	{
		SetScreenMessage("����Ҫ�ȴ� " @ %Time @ "�� ��ſɸ��",$Color[2]);
		return;
	}

	//ͨѶ������
	ClientOnSptAction(7,2);
}
//���������������������������Ҹ����������������������������������������������


//�������������������������Ԫ�������������������������������������������������
function ReAliveModel_Gold_Cmd()
{
	//��ȡ���Player
	%Player = GetPlayer();

	%Money = FuHuoNeedMoney_Expend(%Player,0);

	if (%Player.GetMoney(1) < %Money)
	{
		SetScreenMessage("����Ԫ�����㣬�޷�ʹ�øø��",$Color[2]);
		return;
	}

	%Time = mFloor(getRiseCdTime() / 1000);
	if (%Time > 0)
	{
		SetScreenMessage("����Ҫ�ȴ� " @ %Time @ "�� ��ſɸ��",$Color[2]);
		return;
	}

	//ͨѶ������
	ClientOnSptAction(7,1);
}
//�������������������������Ԫ�������������������������������������������������


//����������������������Ѱ·����λ�ô���������������������������������������������
function Findpath_IsNeedChange(%PathId)//Ѱ����ŵ����⴦��
{
	putout("Ѱ����ŵ�Ԥ����====" @ %PathId);
	
	if ($Item_Text[%PathId] !$= "")
	{
		//echo( $Item_Text[ %PathId ] );
		SetScreenMessage($Item_Text[%PathId],$Color[5]);
		return 0;
	}

	if ($Item_Monster[%PathId] !$= "")
		%PathId = $Item_Monster[%PathId];
	else
	{
		switch (%PathId)
		{
			case 410010113://����
				if (GetPlayer().IsAcceptedMission(10821) && GetZoneID() >= 1120 && GetZoneID() <= 1122)
				{
					SetScreenMessage("��ͨ��Ҷ�ǰ�����سǻ��˹㳡Ѱ�Ҹ���", $Color[5]);
					return 0;
				}
			case 444444454:
				%PathId = 553000050;
			case 108020001://����֮˪
				%Lv = GetPlayer().GetLevel();
				if (%Lv < 45){ %MapID = 1120; }
				else if (%Lv >= 45 && %Lv < 60){ %MapID = 1121; }
				else if (%Lv >= 60){ %MapID = 1122; }

				%PathId = "5" @ %MapID @ "0005";
			case 108020002://�һ�֮��
				%Lv = GetPlayer().GetLevel();
				if (%Lv < 45){ %MapID = 1120; }
				else if (%Lv >= 45 && %Lv < 60){ %MapID = 1121; }
				else if (%Lv >= 60){ %MapID = 1122; }

				%PathId = "5" @ %MapID @ "0006";
			case 108020003://��ҩ
				%Lv = GetPlayer().GetLevel();
				if (%Lv < 45){ %MapID = 1120; }
				else if (%Lv >= 45 && %Lv < 60){ %MapID = 1121; }
				else if (%Lv >= 60){ %MapID = 1122; }

				%PathId = "5" @ %MapID @ "0007";
			case 108020004://������ʯ

				%Lv = GetPlayer().GetLevel();
				if (%Lv < 45){ %MapID = 1120; }
				else if (%Lv >= 45 && %Lv < 60){ %MapID = 1121; }
				else if (%Lv >= 60){ %MapID = 1122; }

				%Ran = GetRandom(1,3);
				switch (%Ran)
				{
					case 1:
						%PathId = "5" @ %MapID @ "0008";
					case 2:
						%PathId = "5" @ %MapID @ "0009";
					case 3:
						%PathId = "5" @ %MapID @ "0010";
				}
			case 108020006://����֮��
				%Lv = GetPlayer().GetLevel();
				if ( %Lv < 45 ){ %MapID = 1120; }
				else if ( %Lv >= 45 && %Lv < 60 ){ %MapID = 1121; }
				else if ( %Lv >= 60 ){ %MapID = 1122; }
				%PathId = "4" @ %MapID @ "0106";
			case 108020007://����֮�
				%Lv = GetPlayer().GetLevel();
				if ( %Lv < 45 ){ %MapID = 1120; }
				else if ( %Lv >= 45 && %Lv < 60 ){ %MapID = 1121; }
				else if ( %Lv >= 60 ){ %MapID = 1122; }
				%PathId = "4" @ %MapID @ "0107";
			case 108020008://����֮צ
				%Lv = GetPlayer().GetLevel( );
				if ( %Lv < 45 ){ %MapID = 1120; }
				else if ( %Lv >= 45 && %Lv < 60 ){ %MapID = 1121; }
				else if ( %Lv >= 60 ){ %MapID = 1122; }
				%PathId = "4" @ %MapID @ "0108";
			case 444444452://ѧϰ������
				OpenAllBag();//�򿪰���
				return 0;
		}
	}
	//echo("%PathId===" @ %PathId);
	return %PathId;
}
function findpath_MissionZhiYin(%FindpathID)//���Ѱ·����
{
	//echo("%FindpathID====" @ %FindpathID);
	switch (%FindpathID)
	{
		case 410101004:closeHelpDirect1_4(10061);
		case 410101025:closeHelpDirect1_4(10001);
		case 410100012:closeHelpDirect1_4( 10002 ); closeHelpDirect1_4( 10011 ); closeHelpDirect1_4( 10081 );
		case 410101002:closeHelpDirect1_4(10011);
		case 553000037:closeHelpDirect1_4(10021);
		case 410100016:closeHelpDirect1_4(10021);
		case 410100014:closeHelpDirect1_4(10041);
		case 410100018:closeHelpDirect1_4(10061);
		case 410100013:closeHelpDirect1_4( 10111 ); closeHelpDirect1_4( 10121 ); closeHelpDirect1_4( 10071 );
		case 410100027:closeHelpDirect1_4( 10081 ); closeHelpDirect1_4( 10131 ); closeHelpDirect1_4( 10141 ); closeHelpDirect1_4( 10151 );
		case 553000038:closeHelpDirect1_4(10141);
		case 410101007:closeHelpDirect1_4(10121);
		case 410100010:closeHelpDirect1_4( 10162 ); closeHelpDirect1_4( 10163 );
		case 410100065:closeHelpDirect1_4( 10101 );
		case 410100054:closeHelpDirect1_4(10091);
		case 553000039:closeHelpDirect1_4(10091);
		case 410100055:closeHelpDirect1_4(10171);
		case 410101005:closeHelpDirect1_4( 10163 );
		case 410100020:closeHelpDirect1_4( 10161 );
	}
}

function ExecedWhenEndFindPath(%PathID,%index)
{
	PutOut("%PathID ===" @ %PathID  @ "   %index===" @ %index);
	%Player = GetPlayer();
	switch (%index)
	{
		case 0://Ѱ·��ϴ���
			switch (%Pathid)
			{
				case 410100055:
					if (%Player.IsAcceptedMission(10171))
						OpenDouFuGan(10171);
				case 410101025:
					if (%Player.IsAcceptedMission(10001))
						OpenDouFuGan(10001);
				case 410100012:
					if (%Player.IsAcceptedMission(10002))
						OpenDouFuGan(10002);
					if (%Player.IsAcceptedMission(10011))
						OpenDouFuGan(10011);
					if ( %Player.IsAcceptedMission( 10081 ) )
						OpenDouFuGan( 10081 );
				case 410101002:
					if (%Player.IsAcceptedMission(10011))
						OpenDouFuGan(10011);
				case 553000037:
					if (%Player.IsAcceptedMission(10021))
						OpenDouFuGan(10021);
				case 410100020:
					if ( %Player.IsAcceptedMission( 10161 ) )
						OpenDouFuGan( 10161 );
				case 410100016:
					if (%Player.IsAcceptedMission(10021))
						OpenDouFuGan(10021);
				case 410100014:
					if (%Player.IsAcceptedMission(10041))
						OpenDouFuGan(10041);
				case 410100018:
					if (%Player.IsAcceptedMission(10061))
						OpenDouFuGan(10061);
				case 410100013:
					if (%Player.IsAcceptedMission(10111))
						OpenDouFuGan(10111);
					if ( %Player.IsAcceptedMission( 10071 ) )
						OpenDouFuGan( 10071 );
				case 410100027:
					if (%Player.IsAcceptedMission(10081))
						OpenDouFuGan(10081);
					if ( %Player.IsAcceptedMission( 10131 ) )
						OpenDouFuGan( 10131 );
					if (%Player.IsAcceptedMission(10141))
						OpenDouFuGan(10141);
					if ( %Player.IsAcceptedMission( 10151 ) )
						OpenDouFuGan( 10151 );
				case 553000038:
					if (%Player.IsAcceptedMission(10141))
						OpenDouFuGan(10141);
				case 410101007:
					if (%Player.IsAcceptedMission(10121))
						OpenDouFuGan(10121);
				case 410100010:
					if ( %Player.IsAcceptedMission( 10162 ) )
						OpenDouFuGan( 10162 );
					if (%Player.IsAcceptedMission(10163))
						OpenDouFuGan(10163);
				case 410100065:
					if (%Player.IsAcceptedMission(10101))
						OpenDouFuGan(10101);
				case 410101005:
					if ( %Player.IsAcceptedMission( 10163 ) )
						OpenDouFuGan( 10163 );
				case 410100054:
					if (%Player.IsAcceptedMission(10091))
						OpenDouFuGan(10091);
				case 553000039:
					if (%Player.IsAcceptedMission(10091))
						OpenDouFuGan(10091);
				case 410101004:
					if (%Player.IsAcceptedMission(10061))
						OpenDouFuGan(10061);
				case 10061:
					%Tab1 = "<t f='����_GB2312' m='0' n='16' c='0xffffffff' o='0x000000ff'>";//��ɫ����
					%Tab3 = "<t f='����_GB2312' m='0' n='16' c='0xff00ffff' o='0x000000ff'>";//��ɫ��ʾ
					%text = %Tab1 @ "ʹ�ÿ�ݼ�</t>" @ %Tab3 @ "E</t>" @ %Tab1 @ "��ʰȡ������Ʒ</t>";
					Dialog_OnlyOK.setVisible(true);
					Dialog_OnlyOK_Content.setContent(%text);
					Dialog_OnlyOK.OnReSize();
					Dialog_OnlyOK.SetOk("");
					Dialog_OnlyOK_OKBTN.command = "Dialog_OnlyOK.setvisible(0);";
			}
		default://Ѱ·���ﴥ��
			//echo("Ѱ·���ﴥ�� %Pathid ===" @  %Pathid);
			switch (%Pathid)
			{
				case 410101004:
					if (%Player.IsAcceptedMission(10061))
						OpenDouFuGan(1);
				case 410101005:
					if (%Player.IsAcceptedMission(10163))
						OpenDouFuGan(1);
				case 410101002:
					if (%Player.IsAcceptedMission(10011))
						SetCombatAssistant(true);
					//%Player.ClearMissionItem( 1 );
					//%Player.AddItemToMission( 1, 1, 108021004, 1 );

				case 553000050:
					if (%Player.IsAcceptedMission(10221))
					{
						%Tab1 = "<t f='����_GB2312' m='0' n='16' c='0xffffffff' o='0x000000ff'>";//��ɫ����
						%Tab3 = "<t f='����_GB2312' m='0' n='16' c='0x00ff4eff' o='0x291b00ff'>";//��ɫ��ʾ
						%text = %Tab1 @ "������</t>" @ %Tab3 @ "��������</t>" @ %Tab1 @ "���в���</t>";
						Dialog_OnlyOK.setVisible(true);
						Dialog_OnlyOK_Content.setContent(%text);
						Dialog_OnlyOK.OnReSize();
						Dialog_OnlyOK.SetOk("");
						Dialog_OnlyOK_OKBTN.command = "Dialog_OnlyOK.setvisible(0);";
					}

				case 553000037:
					if (%Player.IsAcceptedMission(10021))
					{
						%Tab1 = "<t f='����_GB2312' m='0' n='16' c='0xffffffff' o='0x000000ff'>";//��ɫ����
						%Tab3 = "<t f='����_GB2312' m='0' n='16' c='0x00ff4eff' o='0x291b00ff'>";//��ɫ��ʾ
						%text = %Tab1 @ "������</t>" @ %Tab3 @ "����</t>" @ %Tab1 @ "���ɲɼ�</t>";
						Dialog_OnlyOK.setVisible(true);
						Dialog_OnlyOK_Content.setContent(%text);
						Dialog_OnlyOK.OnReSize();
						Dialog_OnlyOK.SetOk("");
						Dialog_OnlyOK_OKBTN.command = "Dialog_OnlyOK.setvisible(0);";
					}


				default:return;
			}

	}
}
//����������������������Ѱ·����λ�ô���������������������������������������������

//����������������������ʹ�ð������ߴ���������������������������������������������
function SendCurUsingItemId(%IitemID)
{
	putout("ʹ�ð������ߴ���====" @ %IitemID);

	%Player = GetPlayer();

	%FuncName = "CurUsingItemId_" @ %IitemID;
	if (isFunction(%FuncName))
		return eval(%FuncName @ "(%Player, %IitemID);");

	switch (%IitemID)
	{
		case 112010055:closeHelpDirect1_4(0);
		case 112010056:closeHelpDirect1_4(0);
		case 105109041:OpenOrCloseChargeChatWnd();//ʹ�����ȴ򿪺�������
		case 105109042:OpenOrCloseChargeChatWnd();//ʹ�ô����ȴ򿪺�������
		case 108021004:closeHelpDirect1_4(0);

		case 108021001:
			%Posx = GetWord(%Player.GetPosition(),0);
			%Posy = GetWord(%Player.GetPosition(),1);
			%X = -26.2497;
			%Y = 65.519;
			if (msqrt(mpow(%Posx - %X,2) + mpow(%Posy - %Y,2)) >= 10)
				findpath(108021002);
		case 113050003:
			if ($MissionZhiYin[10781] == 2)
			{
				closeHelpDirect1_4(0);
				OpenDouFuGan(9);
				CloseAllBag();
				$MissionZhiYin[10781] = 3;
			}
		case 108021019: //����
			//echo("%Player.IsAcceptedMission( 10221 )=======" @ %Player.IsAcceptedMission(10221));
			if (%Player.IsAcceptedMission(10221))
			{
				CloseAllBag();//�رհ���
				%Text = "<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>��Ͼʱ��ɲ�����������Ŷ����þ���ͬʱ���м��ʻ��</t>" @ $Get_Dialog_GeShi[31403] @"<t>����</t>";
				Dialog_OnlyOK_COVER_Content.setContent(%Text);
				Dialog_OnlyOK_COVER.setVisible(true);
				Dialog_OnlyOK_COVER_OKBTN.settext("��������");
				Dialog_OnlyOK_COVER_OKBTN.command = "Dialog_OnlyOK_COVER.setVisible(0);findpath(410100008);";
			}
		case 107050001:
			if (%Player.IsAcceptedMission(10481))
			{
				CloseAllBag();
				%Tab1 = "<t f='����_GB2312' m='0' n='16' c='0xffffffff' o='0x000000ff'>";//��ɫ����
				%Tab3 = "<t f='����_GB2312' m='0' n='16' c='0x00ff4eff' o='0x291b00ff'>";//��ɫ��ʾ
				%text = %Tab1 @ "���Ե��</t>" @ %Tab3 @ "��Ⱥ</t>" @ %Tab1 @ "���е���</t>";
				Dialog_OnlyOK.setVisible(true);
				Dialog_OnlyOK_Content.setContent(%text);
				Dialog_OnlyOK.OnReSize();
				Dialog_OnlyOK.SetOk("");
				Dialog_OnlyOK_OKBTN.command = "Dialog_OnlyOK.setvisible(0);findpath( 553000049 );";
			}


		default:
			$MissionZhiYin[10032] = %Player.IsAcceptedMission(10032);
			$MissionZhiYin[10281] = %Player.IsAcceptedMission(10281);
			$MissionZhiYin[10761] = %Player.IsAcceptedMission(10761);

			if ($MissionZhiYin[10032] == 1)
			{
				//echo( "$MissionZhiYin[ 10032 ]=======" @ $MissionZhiYin[ 10032 ] );
				//��������װ��������ָ���رհ�������
				for (%i = 0; %i <= 9; %i++)
				{
					%Item = getword($MissionData_ItemChose[10031],%i * 2,";");
					//echo( "%ItemID==" @ %ItemID );
					if (%IitemID ==  %Item)
					{
						closeHelpDirect1_4(0);
						OpenDouFuGan(5);
						$MissionZhiYin[10032] = 2;
						break;
					}
				}
			}
			if ($MissionZhiYin[10281] == 1)
			{
				for (%i = 0; %i <= 9; %i++)
				{
					%Item = getword($MissionData_ItemChose[10271],%i * 2,";");
					if (%IitemID == %Item)
					{

						closeHelpDirect1_4(0);
						OpenDouFuGan(16);
						$MissionZhiYin[10281] = 2;
						break;
					}
				}
			}
			if ($MissionZhiYin[10761] == 1)
			{
				for (%i = 0; %i <= 9; %i++)
				{
					%Item = getword($Mission_Data_ItemClasses[10751],%i * 2,";");
					if (%IitemID == %Item)
					{
						closeHelpDirect1_4(0);
						OpenDouFuGan(8);
						CloseAllBag();
						break;
					}
				}
			}
			if (%Player.IsAcceptedMission(10781) && $MissionZhiYin[10781] != 3)
			{
				for (%i = 0; %i <= 9; %i++)
				{
					%Item = getword($Mission_Data_ItemClasses[10771],%i * 2,";");
					if (%IitemID == %Item)
					{
						closeHelpDirect1_4(0);
						OpenDouFuGan_AllBagWndGui(113050003,0);//ָ���������˷�
						$MissionZhiYin[10781] = 2;
						break;
					}
				}
			}
	}
	//ʹ�á�����װ���������������
	if (GetItemData(%IitemID,2) == 15)
	{
		OpenOrClosePetInfoWnd();
		("PetNewEquipmentShowMove" @ GetItemData(%IitemID,3) - 1501).setvisible(1);
	}
}
//����������������������ʹ�ð������ߴ���������������������������������������������

//�����������������������϶��������ߴ���������������������������������������������
function OnInventoryMouseDragged(%IitemID)
{
	putout("�϶��������ߴ���===" @  %IitemID);
	%Player = GetPlayer();

	%FuncName = "InventoryMouseDragged_" @ %IitemID;
	if (isFunction(%FuncName))
		return eval(%FuncName @ "(%Player, %IitemID);");
}

function hideAllPanel()
{

}
//�����������������������϶��������ߴ���������������������������������������������

//��������������������������¼�����ʾ�򴥷���������������������������������������
function OpenSkillHintHappend()
{
	//echo("����¼�����ʾ�򴥷�");
}
//��������������������������¼�����ʾ�򴥷���������������������������������������


//���������������������ͻ���������������ָ�����������������������������
function ClientLeve_BangZhuJieMian(%Lv)
{
	//echo("�ͻ���������������ָ������==" @ %lv);
	/*if ( ( %Lv == 20 ) || ( %Lv == 30 ) || ( %Lv == 35 ) || ( %Lv == 40 ) || ( %Lv == 50 ) || ( %Lv == 55 ) || ( %Lv == 60 ) || ( %Lv == 70 ) || ( %Lv == 75 ) || ( %Lv == 80 ) )
	{
	ShowMiniBirdViewMapHelpIcon( );
	}*/

}
//���������������������ͻ���������������ָ�����������������������������


//���������������������������ء�����������������������
function SearchNpcRoad(%SkillId)
{
	//echo( "�����Ѱ��  " @ %SkillId );
	%Skill = GetSubStr(%SkillId,0,6);
	%SkillLevel = isLearnLivingSkill(%Player.GetPlayerID(),%SkillId);//��ȡ�Ƿ�ѧϰ�������
	switch (%Skill)
	{
		case 501011: %PathNpc = 410100016;//�ɿ���
		case 501021: %PathNpc = 411010002;//��ľ����
		case 501051: %PathNpc = 411010001;//��ҩ����
		case 501031: %PathNpc = 410100012;//���㼼��

		case 502011: %PathNpc = 410100058;//���켼��
		case 503011: %PathNpc = 410100004;//�÷켼��
		case 504011: %PathNpc = 410100059;//��������
		case 505011: %PathNpc = 410100060;//���似��
		case 506011: %PathNpc = 410100003;//��������
		case 507011: %PathNpc = 410100005;//��⿼���
	}
	if (%SkillLevel == 0)
		%PathNpc = 410010144; //���û��ѧϰ���ܣ�Ѱ�������ʦ
	if (%PathNpc > 0 && GetNpcData(%PathNpc,0) > 0)
		findpath(%PathNpc);
}
function TransmitSkillId(%LvSkillID)
{
	%Player = GetPlayer();
	%Lv = %Player.GetLevel();
	//echo( "ѧϰ�����%LvSkillID===" @ %LvSkillID );
	%Skill = GetSubStr(%LvSkillID,0,6);
	if (%Lv < 35)
	{
		SetScreenMessage("�ȼ�����35���޷�ѧϰ�����",$Color[2]);
		return;
	}
	switch (%Skill)
	{
		case 501011: %Type = 1;//�ɿ���
			ClientOnSptAction(30,1);
		case 501021: %Type = 2;//��ľ����
			ClientOnSptAction(30,2);
		case 501031: %Type = 3;//���㼼��
			ClientOnSptAction(30,4);
		case 501051: %Type = 4;//��ҩ����
			ClientOnSptAction(30,3);

		case 502011: %Type = 5;//���켼��
			ClientOnSptAction(30,5);
		case 503011: %Type = 6;//�÷켼��
			ClientOnSptAction(30,6);
		case 504011: %Type = 7;//��������
			ClientOnSptAction(30,7);
		case 505011: %Type = 8;//���似��
			ClientOnSptAction(30,9);
		case 506011: %Type = 9;//��������
			ClientOnSptAction(30,8);
		case 507011: %Type = 10;//��⿼���	
			ClientOnSptAction(30,10);
	}
	//if ( %Type <= 4 )
	//	%Src = 189;
	//else
	//	%Src = 190;
	//if ( GetSrc( %Player, %Src ) == 1 )
	//{
	//	SetScreenMessage( "ѧϰʧ�ܣ�����ѧ�������������", $Color[ 2 ] );
	//	return;
	//}
}
//���������������������������ء�����������������������

//�����������������������÷�ƭ������Ϣ��������������������
//���÷�ƭ������Ϣ
function Fang_Pian_Fang_Dao()
{
	%a = GetRandom(1,4);
	switch (%a)
	{
		case 1:%Txt = "�ٷ�������˽�ĺ��ʼ��ķ�ʽ����ҷ����н����콱��Ϣ��Ҳ�������κ������������Ҫ�ʺź����롣";
		case 2:%Txt = "ϵͳ�����������ɫȫ�����ú�ɫ����Ϣǰ�������[ϵͳ]Ƶ���ı�־��";
		case 3:%Txt = "��ע�������ỰƵ������Ϣ���ݣ����ַ���������ַ����Һ󣬽�������������ɲ���������Ϣɧ�ţ�";
		case 4:%Txt = "�ٷ�����ͨ���κη�ʽ�������Ҫ�˺����롢���֤���롢�����������Ϣ����������͸¶��";
	}

	SetChatMessage("<t f='����' m='1' n='14' c='0xff0000ff' o='0x010101ff'>" @ %Txt @ "</t>","",$chatMsg_System);
	Cancel($Fang_Pian_Fang_Dao);
	$Fang_Pian_Fang_Dao = Schedule(3600 * 1000,0,"Fang_Pian_Fang_Dao");
}

Schedule(60000,0,"Fang_Pian_Fang_Dao");
//�������������������������÷�ƭ������Ϣ��������������������

//�������������������������⽱����ť�����������������������
function ReceiveRewardsTrigger()
{
	//echo( "���⽱����ť�������" );
	if (GetBagEmptyNum() < 2)
	{
		SetScreenMessage("�����ռ䲻��",$Color[2]);
		SetChatMessage("�����ռ䲻�㣬��׼��2�����ϵİ����ռ䡣",$Color[2],$chatMsg_Person);
		return;
	}
	ClientOnSptAction(35,0);//ͨѶ�����
}
//�������������������������⽱����ť�����������������������
