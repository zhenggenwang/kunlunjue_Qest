//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//客户端函数脚本集，只在客户端使用，但函数名建议不与服务端函数使用相同名称
//==================================================================================

//■■■■■■■■■■■【六道轮回功能特效】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■获取任务前的图标■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■NPC进入玩家视野触发，决定是否要顶？！特效■■■■■■■
//■■■■■■■■■■■客户端玩家升级调用■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■客户端升级提示帮助界面■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■界面按钮触发■■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■客户端显示小地图规则■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■仓库扩展需求描述■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■改场景光影■■■■■■■■■■■■■■■
//■■■■■■■■■■■帮派任务界面■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■开启、切换大地图触发■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■月光宝盒控件■■■■■■■■■■■■■■■■

//■■■■■■■■■■■帮派守护神说明脚本■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■星宿自动装备技能功能■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■切换地图触发■■■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■复活界面开启触发■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■点击金币复活触发■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■点击元宝复活触发■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■寻路到达位置触发■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■使用包裹道具触发■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■拖动包裹道具触发■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■获得新技能提示框触发■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■客户端升级触发帮助指引界面■■■■■■■■■■■
//■■■■■■■■■■生活技能相关■■■■■■■■■■■■
//■■■■■■■■■■■设置防骗防盗信息■■■■■■■■■■
//■■■■■■■■■■■答题奖励按钮点击触发■■■■■■■■


//■■■■■■■■■■■登陆时欢迎界面触发■■■■■■■■■■■■■■■■■■■■
function uiClearUpLinePartyWnd()
{

}
function UpdateUpLinePartyWnd()
{

}
function DengLuJieMianePartyWnd()
{
	//登陆时欢迎界面触发
	//if ( $OpenUpLinePartyWnd == 1 )
	//	OpenUpLinePartyWnd( 3 );
	//else
	//	OpenUpLinePartyWnd( 1 );
	//
	//$OpenUpLinePartyWnd = 0;
}
//■■■■■■■■■■■登陆时欢迎界面触发■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【六道轮回功能特效】■■■■■■■■■■■■■■■■■■
function GetCurMetempsychosisEffectId(%Leve)
{
	if (%Leve == 1) return 690761;
	else if (%Leve == 2) return 690762;
	else if (%Leve >= 2) return 690763;

	return 0;
}
//■■■■■■■■■■■【六道轮回功能特效】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■获取任务前的图标■■■■■■■■■■■■■■■■■■■
//获取任务前的图标
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
//■■■■■■■■■■■获取任务前的图标■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■NPC进入玩家视野触发，决定是否要顶？！特效■■■■■■■
//NPC进入玩家视野触发，决定是否要顶？！特效
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
//■■■■■■■■■■■NPC进入玩家视野触发，决定是否要顶？！特效■■■■■■■

//■■■■■■■■■■■客户端玩家升级调用■■■■■■■■■■■■■■■■■■■
function ClientEventLevelUp(%PlayerID)
{
	%Player = GetPlayer();
	%Lv = %Player.GetLevel();
	%LunHuiLv = %Player.GetMetempsychosis();
	LevelJudgeOnlineReward(%lv);//刷新在线奖励界面
	//重刷各任务界面的可接树
	RefreshMission(%Player,99,0);

	//客户端升级触发帮助指引界面
	ClientLeve_BangZhuJieMian(%Lv);
	//升级技能的指引图标
	if (isCanLearnNewSkill() && %Lv > 30)
		PlayerSkillStudyGui.setvisible(1);
	switch (%Lv)
	{
		case 10:
			OpenDouFuGan(14);
		case 35://35级弹出任务指引界面
			OpenKLJMissionGuidanceGui();
	}
	if ($WndNeedOpen !$= "")
		GetAllWndNeedOpen($WndNeedOpen);//刷新地图区域的按钮开关
	if ($YunYingbActiveText !$= "")
		SetAllYunYingbActive();//刷新运营活动按钮
	

}

//■■■■■■■■■■■客户端升级提示帮助界面■■■■■■■■■■■■■■■■■
function GetPlayerLvHelpTxt(%Lv,%isHistroy)
{
}
//■■■■■■■■■■■客户端升级提示帮助界面■■■■■■■■■■■■■■■■■




//■■■■■■■■■■■客户端显示小地图规则■■■■■■■■■■■■■■■■■■

function OnEnterTrigger(%TriggerId)
{
	//echo( "%TriggerId====" @ %TriggerId );
	//	%TriggerId = %Player.GetTriggerId();
	//
	//	if(GetSubStr(GetZoneID(),0,4) $= "1333" && GetSubStr(%TriggerId,6,1) > 1 )
	//		ShowHelpDirectByIndex(200);
}
//■■■■■■■■■■■客户端显示小地图规则■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■仓库扩展需求描述■■■■■■■■■■■■■■■■■■■■
function Cs_ShowBankText(%Num)
{
	//echo( "仓库扩展需求描述===" @ %Num );
	switch (%Num)
	{
		case 12:return "<t>10级时将免费开启6格空间 </t>";
		case 18:return "<t>购买空间需元宝：100  </t>"@$Icon[89];
		case 24:return "<t>购买空间需元宝：500  </t>"@$Icon[89];
		case 30:return "<t>购买空间需元宝：500  </t>"@$Icon[89];
		case 36:return "<t>购买空间需元宝：1000 </t>"@$Icon[89];
		case 42:return "<t>购买空间需元宝：1000 </t>"@$Icon[89];
		case 48:return "<t>购买空间需元宝：1000 </t>"@$Icon[89];
		case 54:return "<t>购买空间需元宝：1000 </t>"@$Icon[89];
		case 60:return "<t>购买空间需元宝：1000 </t>"@$Icon[89];
		case 66:return "<t>购买空间需元宝：1000 </t>"@$Icon[89];
		case 72:return "<t>购买空间需元宝：1000 </t>"@$Icon[89];
		case 78:return "<t>购买空间需元宝：1000 </t>"@$Icon[89];
		case 84:return "<t>购买空间需元宝：1000 </t>"@$Icon[89];
		case 90:return "<t>您已经将仓库全部扩展了</t>";
	}
}
//■■■■■■■■■■■仓库扩展需求描述■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■改场景光影■■■■■■■■■■■■■■■
//改场景光影
function SetLightForNormal()
{
	//	if(GetZoneID() !$= "131001")
	//		return;

	//播放Flash
	OpenGameTaskSectionWnd(31);

	//改环境颜色 渐变
	setSunLight("0.35 0.35 0.3 1","0.7 0.7 0.45 1","0.75 0.75 0.45 1","0 0.1 0.7 1","0.4 0.996078 0.996078 0");
}

function SetLightForEvilMode()
{
	if (GetZoneID() !$= "131001")
		return;

	//播放Flash
	OpenGameTaskSectionWnd(32);

	//改环境颜色 渐变
	Schedule(2000,0,"SetSunLigthForFSZH",0);
}

function SetSunLigthForFSZH(%index)
{
	//0 黑夜模式 1 正常模式
	if (%index == 0)
		setSunLight("0.223529 0.329412 0.431373 1","0.729412 0.807843 0.882353 1","0.101961 0.109804 0.384314 1","0.05098 0.05098 0.07451 1","0.078431 0.215686 0.345098 0");
	else if (%index == 1)
		setSunLight("0.35 0.35 0.3 1","0.7 0.7 0.45 1","0.75 0.75 0.45 1","0 0.1 0.7 1","0.4 0.996078 0.996078 0");
}

//■■■■■■■■■■■改场景光影■■■■■■■■■■■■■■■

//■■■■■■■■■■■帮派任务界面■■■■■■■■■■■■■■■■■■■■■
//角色登录时刷新帮派任务界面
function SetFamilyMissionWnd()
{
	%Player = GetPlayer();
	%Family = %Player.GetFamily();
}
//■■■■■■■■■■■帮派任务界面■■■■■■■■■■■■■■■■■■■■■



//■■■■■■■■■■■帮派守护神说明脚本■■■■■■■■■■■■■■■■■■■■
function Org_GetBossInfo(%BossID,%BossGet)
{
	%Player = GetPlayer();

	//获取守护神名称
	%BossName = GetNpcData(%BossID,$Monster_Data_Name);
}
//■■■■■■■■■■■帮派守护神说明脚本■■■■■■■■■■■■■■■■■■■■



//■■■■■■■■■■■开启、切换大地图触发■■■■■■■■■■■■■■■■■■
function ViewMapChangeTig()
{
	//echo("开启、切换大地图触发==="  @ $SelectBigMapName);
	//删除大地图标识
	BigViewMapCtrl.clearTmpBitmaps();

	RefreshMaterialSign($SelectBigMapName);

	if ($SelectBigMapName $= "天地地图")Theurgy_CoachDirection(2);
	else if ($SelectBigMapName $= "仙游岭")
	{
		Theurgy_CoachDirection(3);
		Theurgy_CoachDirection(11);
	}
}
//■■■■■■■■■■■开启、切换大地图触发■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■月光宝盒控件■■■■■■■■■■■■■■■■
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

	//【搜索】输入框的文字
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

	//【编号】输入框的文字
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

	//【数量】输入框的文字
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

	//【搜索】按钮
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
		text = "搜 索";
		groupNum = "-1";
		buttonType = "PushButton";
		useMouseEvents = "0";
		IsStateOn = "0";
	};

	//确认按钮
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
		text = "确 定";
		groupNum = "-1";
		buttonType = "PushButton";
		useMouseEvents = "0";
		IsStateOn = "0";
	};

	//关闭按钮
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

	//【编号】显示
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

	//【数量】显示
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

	//搜索结果
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
		BatchSellWnd_TextEdit_CH1.setVisible(1); //搜索输入
		BatchSellWnd_SSButton.setVisible(1); 			//搜索按钮
		BatchSellWnd_CancelButton3.setVisible(1); //搜索结果
	}
	else
	{
		BatchSellWnd_TextEdit_CH1.setVisible(0); //搜索输入
		BatchSellWnd_SSButton.setVisible(0); 			//搜索按钮
		BatchSellWnd_CancelButton3.setVisible(0); //搜索结果
	}

	%Tab1 = "<t f='黑体' m='0' n='14' b='1' gct='0xffff00ff' gcb='0xd9680dff'>";

	BatchSellWnd_CancelButton1.Setcontent(%Tab1 @ "编号</t>");
	if (%III  == 6)
		BatchSellWnd_CancelButton2.Setcontent(%Tab1 @ "层数</t>");
	else
		BatchSellWnd_CancelButton2.Setcontent(%Tab1 @ "数量</t>");
}

function ShopWnd_NpcZHJM_SSButton()
{
	BatchSellWnd_CancelButton3.clearitems();

	//获取搜索物品
	%ITEMText = BatchSellWnd_TextEdit_CH1.GetValue();

	if (%ITEMText $= "")
		return;

	if ($ShopWnd_NpcZHJM == 1)
		%ITEMNum = QueryNPCIDS_ByName(%ITEMText,2);

	else if ($ShopWnd_NpcZHJM == 2)
		%ITEMNum = QueryItemIDS_ByName(%ITEMText,2);		//筛选搜索物品

	%Tab = "<t f='黑体' m='0' n='13' b='1' v='1' c='0x00b0f0ff'>";

	if (%ITEMNum $= "")
	{
		BatchSellWnd_CancelButton3.AddItem(%Tab @ "不存在该物品！</t>" TAB "<t>" @ %TiemID @ "</t>",0);
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

//确定
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
			SetScreenMessage("怪物编号错误",$Color[2]);
	}
	else if ($ShopWnd_NpcZHJM == 2)
	{
		if (GetItemData(%text,0) !$= "")
		{
			ClientOnSptAction(1,%text_CH3);
			ClientOnSptAction(3,%text);
		}
		else
			SetScreenMessage("道具编号错误",$Color[2]);
	}
	else if ($ShopWnd_NpcZHJM == 3)
	{
		if (GetCollectionObjectname(%text) !$= "")
		{
			ClientOnSptAction(1,%text_CH3);
			ClientOnSptAction(4,%text);
		}
		else
			SetScreenMessage("采集编号错误",$Color[2]);
	}
	else if ($ShopWnd_NpcZHJM == 4)
	{
		if (GetMissionData(%text,$Mission_Data_Mid) !$= "")
		{
			ClientOnSptAction(1,%text_CH3);
			ClientOnSptAction(5,%text);
		}
		else
			SetScreenMessage("任务编号错误",$Color[2]);
	}
	else if ($ShopWnd_NpcZHJM == 5)
	{
		if (GetPetData(%text,0) !$= "")
		{
			ClientOnSptAction(1,%text_CH3);
			ClientOnSptAction(6,%text);
		}
		else
			SetScreenMessage("神兽编号错误",$Color[2]);
	}
	else if ($ShopWnd_NpcZHJM == 6)
	{
		if ((GetSubStr(%text,0,1) $= "2" || GetSubStr(%text,0,1) $= "3") && (strlen(%text) == 9))
		{
			ClientOnSptAction(1,%text_CH3);
			ClientOnSptAction(8,%text);
		}
		else
			SetScreenMessage("BUFF或者技能编号错误",$Color[2]);
	}
}

//■■■■■■■■■■■星宿自动装备技能功能■■■■■■■■■■■■■■■■■■■
// 装星宿时自动加载技能
function GetAutoLoadSkill(%PlayerClass)
{
	return $AutoLoadSkills[%PlayerClass];
}

// 配置自动加载技能
// %PlayerClass 玩家职业
// %SkillID     技能ID
// %CoolTime    技能使用时间间隔
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

//武将
AddAutoLoadSkillConf(1,210010001,0);
AddAutoLoadSkillConf(1,210040001,0);

//侠客
AddAutoLoadSkillConf(2,220010001,0);
AddAutoLoadSkillConf(2,220020001,600);
AddAutoLoadSkillConf(2,220030001,0);

//羽士
AddAutoLoadSkillConf(3,230010001,0);
AddAutoLoadSkillConf(3,230020001,0);
AddAutoLoadSkillConf(3,230040001,60);

//丹士
AddAutoLoadSkillConf(4,240010001,0);
AddAutoLoadSkillConf(4,240020001,60);
AddAutoLoadSkillConf(4,240030001,0);

//箭翎
AddAutoLoadSkillConf(5,250010001,0);
AddAutoLoadSkillConf(5,250020001,0);
AddAutoLoadSkillConf(5,250040001,12);

//■■■■■■■■■■■星宿自动装备技能功能■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■切换地图触发■■■■■■■■■■■■■■■■■■■■■■■
function SvrEventTransporClient(%Player,%optype)//1登录，2切换线程，3切换地图
{
	if (%Player == 0)
		return;
	//echo( "%Player =======================" @ %Player @ "					%optype=-=========================" @ %optype );
	%MapID = GetZoneID();
	%Triggerid = %Player.GetTriggerid();

	//刷新按钮特效
	ScheduleSetMainbtnBlink();
	//显示任务追踪信息,隐藏副本信息
	if (%MapID <= 1300)
		Schedule(2000,0,"TaskTraceMessageAppear");
	//重刷各任务界面的可接树
	RefreshMission(%Player, 99, 0);
	if (%optype == 1)
	{
		//获取ping值
		SetPingPack();
		//刷新在线奖励界面
		showFristOpenOnlineReward();

		//升级技能的指引图标
		//echo( "升级技能的指引图标===" @ isCanLearnNewSkill( ) @ "    " @  %Player.GetLevel( ) );
		if (isCanLearnNewSkill() && (%Player.GetLevel() > 30))
			PlayerSkillStudyGui.setvisible(1);
		else
			PlayerSkillStudyGui.setvisible(0);
		//加载攻略界面的内容
		SetStrategyBtnText();
		if (!TimerTriggerCtrl_MinWndTX.isvisible())
			closeHelpDirect1_4(20);
	}
}


//■■■■■■■■■■■切换地图触发■■■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■复活界面开启触发■■■■■■■■■■■■■■■■■■■■■
function FillResurgenceModelMSG()
{
	//获取玩家Player
	%Player = GetPlayer();

	%Activity = 2209;
	%ActivityA = GetWord(%Player.GetActivity(%Activity),0) * 1;
	%ActivityB = GetWord(%Player.GetActivity(%Activity),1) * 1;

	//初始化复活按钮
	ReAliveModel_Tang_Button.Setactive(1);
	ReAliveModel_Gold_Button.Setactive(1);

	//是否禁止金币复活
	%TriggerID[9] = GetTriggerData(%Player.GetTriggerId(),11);
	%TangBiFuHuoNo = HasBit(%TriggerID[9],16);

	//是否禁止元宝复活
	%TriggerID[9] = GetTriggerData(%Player.GetTriggerId(),11);
	%YuanBaoFuHuoNo = HasBit(%TriggerID[9],15);

	%TxtButton1 = "金币原地复活";

	//echo("复活界面==================");
	//金币复活界面
	if (%TangBiFuHuoNo > 0)
	{
		ReAliveModel_Tang_Button.Setactive(0);
		%Txt1 = $Get_Dialog_GeShi[31406] @ "禁止金币复活</t><b/><b/>" @ $Get_Dialog_GeShi[31402] @ "当前区域无法金币复活，请选择其他方式。</t>";
	}
	if (HasBit(GetTriggerData(%Player.GetTriggerId(),11),27))
	{
		%Txt1 = "<t>立即原地复活</t><b/><b/>" @ $Get_Dialog_GeShi[31402] @ "复活无需消耗金币，并且无敌5秒</t>";
		%TxtButton1 = "原地复活";
	}
	else if ((%Player.GetMetempsychosis() == 0) && (%Player.GetLevel() < 20))
		%Txt1 = "<t>当前免费复活</t><b/><b/>" @ $Get_Dialog_GeShi[31402] @ "20级以下复活无需消耗金币。</t>";
	else
	{
		%Money = FuHuoNeedMoney_Expend(%Player,1);
		if (%Money == 0)
		{
			%Txt1 = "<t>当前免费复活</t>" @ "<b/><b/>" @ $Get_Dialog_GeShi[31402] @ "今日剩余免费复活次数：" @ GetMianFeiFuHuoNumber(%Player) - %ActivityA @ "次</t>";
		}
		else
		{
			if (%Player.GetMoney(2) < %Money)
				%TxtTangBi = "<b/>" @ $Get_Dialog_GeShi[31406] @ "当前金币不足！</t>";

			%Txt1 = "<t>消耗金币：</t>" @ ChangeMoneyText(%money) @ " " @ %TxtTangBi @ "<b/><b/>" @ $Get_Dialog_GeShi[31402] @ "金币复活已用次数：" @ %ActivityA - GetMianFeiFuHuoNumber(%Player) @ "次</t>";
		}

	}

	ReAliveModel_Tang_Button.text = %TxtButton1;
	ReAliveModelMSG_1.Setcontent(%Txt1);

	//复活点复活界面
	//if (HasBit_City_Force(%Player) == 1)
	//	%TriggerId = GetTriggerData(%Player.GetTriggerId(),6);
	//else
	//	%TriggerId = GetTriggerData(%Player.GetTriggerId(),8);

	%TriggerId = GetTriggerData(%Player.GetTriggerId(), 6);
	

	%TriggerId = (%TriggerId == 0) ? %Player.GetTriggerId() : "8" @ %TriggerId @ "0100";
	
	if (%TriggerId == 811190200)
		%TriggerId = 811190100;
	
	//echo("复活界面开启触发 =="  @ %TriggerId);

	%Txt2 = "复活点：" @ GetTriggerData(%TriggerId,3);

	//if ( %YuanBaoFuHuoNo == 0 )
	//	%Txt4 = "<b/><b/>" @ $Get_Dialog_GeShi[ 31402 ] @ "复活点复活将重置原地复活的『金币消耗』。</t>";
	//else
	//	%Txt4 = "<b/><b/>" @ $Get_Dialog_GeShi[ 31402 ] @ "                     </t>";

	ReAliveModelMSG_2.Setcontent(%Txt2);

	//元宝复活界面
	if (%YuanBaoFuHuoNo > 0)
	{
		ReAliveModel_Gold_Button.Setactive(0);
		%Txt3 = $Get_Dialog_GeShi[31406] @ "禁止元宝复活</t><b/><b/>" @ $Get_Dialog_GeShi[31402] @ "当前区域无法元宝复活，请选择其他方式。</t>";
	}
	else
	{
		%Money = FuHuoNeedMoney_Expend(%Player,0);
		if (%Player.GetMoney(1) < %Money)
		{
			%cmd[1] = "OpenOrCloseChongZhiWndGui();";
			%Button[1] = "<c cid='" @ Get_TraceButton() @ "' cmd='\"" @ %cmd[1] @ "\",\"" @ $Get_Dialog_GeShi[31414]  @ "充值平台" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />";

			%TxtYuanBao = "<b/>" @ $Get_Dialog_GeShi[31406] @ "当前元宝不足！</t><b/><b/>" @ $Get_Dialog_GeShi[31402] @ "元宝可通过</t>" @ %Button[1] @ $Get_Dialog_GeShi[31402] @ "进行充值。</t>";
		}
		%Txt3 = "<t>消耗元宝：</t>" @ %Money @ $Icon[89] @ %TxtYuanBao;
	}

	ReAliveModelMSG_3.Setcontent(%Txt3);

	%MapId = GetSubStr(GetZoneID(),0,4);
	
	//设置自动返回复活点复活时间
	if (%Player.GetTriggerId() == 811190200)$Resurgenc_lefttime = 8;
}
//■■■■■■■■■■■复活界面开启触发■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■点击金币复活触发■■■■■■■■■■■■■■■■■■■■■
function ReAliveModel_Tang_Cmd()
{
	//获取玩家Player
	%Player = GetPlayer();
	%Money = FuHuoNeedMoney_Expend(%Player,1);

	if (%Player.GetMoney(2) < %Money)
	{
		SetScreenMessage("您的金币不足，无法使用该复活。",$Color[2]);
		return;
	}

	%Time = mFloor(getRiseCdTime() / 1000);
	if (%Time > 0)
	{
		SetScreenMessage("您需要等待 " @ %Time @ "秒 后才可复活。",$Color[2]);
		return;
	}

	//通讯服务器
	ClientOnSptAction(7,2);
}
//■■■■■■■■■■■点击金币复活触发■■■■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■点击元宝复活触发■■■■■■■■■■■■■■■■■■■■■
function ReAliveModel_Gold_Cmd()
{
	//获取玩家Player
	%Player = GetPlayer();

	%Money = FuHuoNeedMoney_Expend(%Player,0);

	if (%Player.GetMoney(1) < %Money)
	{
		SetScreenMessage("您的元宝不足，无法使用该复活。",$Color[2]);
		return;
	}

	%Time = mFloor(getRiseCdTime() / 1000);
	if (%Time > 0)
	{
		SetScreenMessage("您需要等待 " @ %Time @ "秒 后才可复活。",$Color[2]);
		return;
	}

	//通讯服务器
	ClientOnSptAction(7,1);
}
//■■■■■■■■■■■点击元宝复活触发■■■■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■寻路到达位置触发■■■■■■■■■■■■■■■■■■■■■
function Findpath_IsNeedChange(%PathId)//寻径编号的特殊处理
{
	putout("寻径编号的预处理====" @ %PathId);
	
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
			case 410010113://福星
				if (GetPlayer().IsAcceptedMission(10821) && GetZoneID() >= 1120 && GetZoneID() <= 1122)
				{
					SetScreenMessage("请通过叶璇前往昆仑城会盟广场寻找福星", $Color[5]);
					return 0;
				}
			case 444444454:
				%PathId = 553000050;
			case 108020001://寒冰之霜
				%Lv = GetPlayer().GetLevel();
				if (%Lv < 45){ %MapID = 1120; }
				else if (%Lv >= 45 && %Lv < 60){ %MapID = 1121; }
				else if (%Lv >= 60){ %MapID = 1122; }

				%PathId = "5" @ %MapID @ "0005";
			case 108020002://烈火之炎
				%Lv = GetPlayer().GetLevel();
				if (%Lv < 45){ %MapID = 1120; }
				else if (%Lv >= 45 && %Lv < 60){ %MapID = 1121; }
				else if (%Lv >= 60){ %MapID = 1122; }

				%PathId = "5" @ %MapID @ "0006";
			case 108020003://草药
				%Lv = GetPlayer().GetLevel();
				if (%Lv < 45){ %MapID = 1120; }
				else if (%Lv >= 45 && %Lv < 60){ %MapID = 1121; }
				else if (%Lv >= 60){ %MapID = 1122; }

				%PathId = "5" @ %MapID @ "0007";
			case 108020004://奇异神石

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
			case 108020006://翼妖之羽
				%Lv = GetPlayer().GetLevel();
				if ( %Lv < 45 ){ %MapID = 1120; }
				else if ( %Lv >= 45 && %Lv < 60 ){ %MapID = 1121; }
				else if ( %Lv >= 60 ){ %MapID = 1122; }
				%PathId = "4" @ %MapID @ "0106";
			case 108020007://翼妖之喙
				%Lv = GetPlayer().GetLevel();
				if ( %Lv < 45 ){ %MapID = 1120; }
				else if ( %Lv >= 45 && %Lv < 60 ){ %MapID = 1121; }
				else if ( %Lv >= 60 ){ %MapID = 1122; }
				%PathId = "4" @ %MapID @ "0107";
			case 108020008://翼妖之爪
				%Lv = GetPlayer().GetLevel( );
				if ( %Lv < 45 ){ %MapID = 1120; }
				else if ( %Lv >= 45 && %Lv < 60 ){ %MapID = 1121; }
				else if ( %Lv >= 60 ){ %MapID = 1122; }
				%PathId = "4" @ %MapID @ "0108";
			case 444444452://学习技能书
				OpenAllBag();//打开包裹
				return 0;
		}
	}
	//echo("%PathId===" @ %PathId);
	return %PathId;
}
function findpath_MissionZhiYin(%FindpathID)//点击寻路触发
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
		case 0://寻路打断触发
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
					%Tab1 = "<t f='楷体_GB2312' m='0' n='16' c='0xffffffff' o='0x000000ff'>";//白色正文
					%Tab3 = "<t f='楷体_GB2312' m='0' n='16' c='0xff00ffff' o='0x000000ff'>";//紫色提示
					%text = %Tab1 @ "使用快捷键</t>" @ %Tab3 @ "E</t>" @ %Tab1 @ "可拾取掉落物品</t>";
					Dialog_OnlyOK.setVisible(true);
					Dialog_OnlyOK_Content.setContent(%text);
					Dialog_OnlyOK.OnReSize();
					Dialog_OnlyOK.SetOk("");
					Dialog_OnlyOK_OKBTN.command = "Dialog_OnlyOK.setvisible(0);";
			}
		default://寻路到达触发
			//echo("寻路到达触发 %Pathid ===" @  %Pathid);
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
						%Tab1 = "<t f='楷体_GB2312' m='0' n='16' c='0xffffffff' o='0x000000ff'>";//白色正文
						%Tab3 = "<t f='楷体_GB2312' m='0' n='16' c='0x00ff4eff' o='0x291b00ff'>";//绿色提示
						%text = %Tab1 @ "左键点击</t>" @ %Tab3 @ "蓬莱道经</t>" @ %Tab1 @ "进行参悟</t>";
						Dialog_OnlyOK.setVisible(true);
						Dialog_OnlyOK_Content.setContent(%text);
						Dialog_OnlyOK.OnReSize();
						Dialog_OnlyOK.SetOk("");
						Dialog_OnlyOK_OKBTN.command = "Dialog_OnlyOK.setvisible(0);";
					}

				case 553000037:
					if (%Player.IsAcceptedMission(10021))
					{
						%Tab1 = "<t f='楷体_GB2312' m='0' n='16' c='0xffffffff' o='0x000000ff'>";//白色正文
						%Tab3 = "<t f='楷体_GB2312' m='0' n='16' c='0x00ff4eff' o='0x291b00ff'>";//绿色提示
						%text = %Tab1 @ "左键点击</t>" @ %Tab3 @ "海蚌</t>" @ %Tab1 @ "即可采集</t>";
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
//■■■■■■■■■■■寻路到达位置触发■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■使用包裹道具触发■■■■■■■■■■■■■■■■■■■■■
function SendCurUsingItemId(%IitemID)
{
	putout("使用包裹道具触发====" @ %IitemID);

	%Player = GetPlayer();

	%FuncName = "CurUsingItemId_" @ %IitemID;
	if (isFunction(%FuncName))
		return eval(%FuncName @ "(%Player, %IitemID);");

	switch (%IitemID)
	{
		case 112010055:closeHelpDirect1_4(0);
		case 112010056:closeHelpDirect1_4(0);
		case 105109041:OpenOrCloseChargeChatWnd();//使用喇叭打开喊话界面
		case 105109042:OpenOrCloseChargeChatWnd();//使用大喇叭打开喊话界面
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
		case 108021019: //道果
			//echo("%Player.IsAcceptedMission( 10221 )=======" @ %Player.IsAcceptedMission(10221));
			if (%Player.IsAcceptedMission(10221))
			{
				CloseAllBag();//关闭包裹
				%Text = "<t m ='0' f='黑体' n='14' c='0xdeeeedff' v='1'>闲暇时间可参与聆经悟道活动哦，获得经验同时还有几率获得</t>" @ $Get_Dialog_GeShi[31403] @"<t>道果</t>";
				Dialog_OnlyOK_COVER_Content.setContent(%Text);
				Dialog_OnlyOK_COVER.setVisible(true);
				Dialog_OnlyOK_COVER_OKBTN.settext("继续任务");
				Dialog_OnlyOK_COVER_OKBTN.command = "Dialog_OnlyOK_COVER.setVisible(0);findpath(410100008);";
			}
		case 107050001:
			if (%Player.IsAcceptedMission(10481))
			{
				CloseAllBag();
				%Tab1 = "<t f='楷体_GB2312' m='0' n='16' c='0xffffffff' o='0x000000ff'>";//白色正文
				%Tab3 = "<t f='楷体_GB2312' m='0' n='16' c='0x00ff4eff' o='0x291b00ff'>";//绿色提示
				%text = %Tab1 @ "可以点击</t>" @ %Tab3 @ "鱼群</t>" @ %Tab1 @ "进行钓鱼</t>";
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
				//穿戴新手装备触发，指引关闭包裹界面
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
						OpenDouFuGan_AllBagWndGui(113050003,0);//指引鉴定幸运符
						$MissionZhiYin[10781] = 2;
						break;
					}
				}
			}
	}
	//使用【神兽装备】后开启宠物界面
	if (GetItemData(%IitemID,2) == 15)
	{
		OpenOrClosePetInfoWnd();
		("PetNewEquipmentShowMove" @ GetItemData(%IitemID,3) - 1501).setvisible(1);
	}
}
//■■■■■■■■■■■使用包裹道具触发■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■拖动包裹道具触发■■■■■■■■■■■■■■■■■■■■■
function OnInventoryMouseDragged(%IitemID)
{
	putout("拖动包裹道具触发===" @  %IitemID);
	%Player = GetPlayer();

	%FuncName = "InventoryMouseDragged_" @ %IitemID;
	if (isFunction(%FuncName))
		return eval(%FuncName @ "(%Player, %IitemID);");
}

function hideAllPanel()
{

}
//■■■■■■■■■■■拖动包裹道具触发■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■获得新技能提示框触发■■■■■■■■■■■■■■■■■■■
function OpenSkillHintHappend()
{
	//echo("获得新技能提示框触发");
}
//■■■■■■■■■■■获得新技能提示框触发■■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■客户端升级触发帮助指引界面■■■■■■■■■■■■
function ClientLeve_BangZhuJieMian(%Lv)
{
	//echo("客户端升级触发帮助指引界面==" @ %lv);
	/*if ( ( %Lv == 20 ) || ( %Lv == 30 ) || ( %Lv == 35 ) || ( %Lv == 40 ) || ( %Lv == 50 ) || ( %Lv == 55 ) || ( %Lv == 60 ) || ( %Lv == 70 ) || ( %Lv == 75 ) || ( %Lv == 80 ) )
	{
	ShowMiniBirdViewMapHelpIcon( );
	}*/

}
//■■■■■■■■■■客户端升级触发帮助指引界面■■■■■■■■■■■■


//■■■■■■■■■■生活技能相关■■■■■■■■■■■■
function SearchNpcRoad(%SkillId)
{
	//echo( "生活技能寻径  " @ %SkillId );
	%Skill = GetSubStr(%SkillId,0,6);
	%SkillLevel = isLearnLivingSkill(%Player.GetPlayerID(),%SkillId);//获取是否学习该生活技能
	switch (%Skill)
	{
		case 501011: %PathNpc = 410100016;//采矿技能
		case 501021: %PathNpc = 411010002;//伐木技能
		case 501051: %PathNpc = 411010001;//采药技能
		case 501031: %PathNpc = 410100012;//钓鱼技能

		case 502011: %PathNpc = 410100058;//铸造技能
		case 503011: %PathNpc = 410100004;//裁缝技能
		case 504011: %PathNpc = 410100059;//制器技能
		case 505011: %PathNpc = 410100060;//符咒技能
		case 506011: %PathNpc = 410100003;//炼丹技能
		case 507011: %PathNpc = 410100005;//烹饪技能
	}
	if (%SkillLevel == 0)
		%PathNpc = 410010144; //如果没有学习技能，寻径生活大师
	if (%PathNpc > 0 && GetNpcData(%PathNpc,0) > 0)
		findpath(%PathNpc);
}
function TransmitSkillId(%LvSkillID)
{
	%Player = GetPlayer();
	%Lv = %Player.GetLevel();
	//echo( "学习生活技能%LvSkillID===" @ %LvSkillID );
	%Skill = GetSubStr(%LvSkillID,0,6);
	if (%Lv < 35)
	{
		SetScreenMessage("等级不足35，无法学习生活技能",$Color[2]);
		return;
	}
	switch (%Skill)
	{
		case 501011: %Type = 1;//采矿技能
			ClientOnSptAction(30,1);
		case 501021: %Type = 2;//伐木技能
			ClientOnSptAction(30,2);
		case 501031: %Type = 3;//钓鱼技能
			ClientOnSptAction(30,4);
		case 501051: %Type = 4;//采药技能
			ClientOnSptAction(30,3);

		case 502011: %Type = 5;//铸造技能
			ClientOnSptAction(30,5);
		case 503011: %Type = 6;//裁缝技能
			ClientOnSptAction(30,6);
		case 504011: %Type = 7;//制器技能
			ClientOnSptAction(30,7);
		case 505011: %Type = 8;//符咒技能
			ClientOnSptAction(30,9);
		case 506011: %Type = 9;//炼丹技能
			ClientOnSptAction(30,8);
		case 507011: %Type = 10;//烹饪技能	
			ClientOnSptAction(30,10);
	}
	//if ( %Type <= 4 )
	//	%Src = 189;
	//else
	//	%Src = 190;
	//if ( GetSrc( %Player, %Src ) == 1 )
	//{
	//	SetScreenMessage( "学习失败，您已学会其他的生活技能", $Color[ 2 ] );
	//	return;
	//}
}
//■■■■■■■■■■生活技能相关■■■■■■■■■■■■

//■■■■■■■■■■设置防骗防盗信息■■■■■■■■■■
//设置防骗防盗信息
function Fang_Pian_Fang_Dao()
{
	%a = GetRandom(1,4);
	switch (%a)
	{
		case 1:%Txt = "官方不会以私聊和邮件的方式向玩家发布中奖或领奖信息，也不会以任何理由向玩家索要帐号和密码。";
		case 2:%Txt = "系统公告的文字颜色全部采用红色，信息前都会带有[系统]频道的标志。";
		case 3:%Txt = "请注意鉴别各会话频道的信息内容，发现发布盗号网址的玩家后，将其加入黑名单后可不再受其信息骚扰！";
		case 4:%Txt = "官方不会通过任何方式向玩家索要账号密码、身份证号码、二级密码等信息，请勿随意透露。";
	}

	SetChatMessage("<t f='宋体' m='1' n='14' c='0xff0000ff' o='0x010101ff'>" @ %Txt @ "</t>","",$chatMsg_System);
	Cancel($Fang_Pian_Fang_Dao);
	$Fang_Pian_Fang_Dao = Schedule(3600 * 1000,0,"Fang_Pian_Fang_Dao");
}

Schedule(60000,0,"Fang_Pian_Fang_Dao");
//■■■■■■■■■■■设置防骗防盗信息■■■■■■■■■■

//■■■■■■■■■■■答题奖励按钮点击触发■■■■■■■■
function ReceiveRewardsTrigger()
{
	//echo( "答题奖励按钮点击触发" );
	if (GetBagEmptyNum() < 2)
	{
		SetScreenMessage("包裹空间不足",$Color[2]);
		SetChatMessage("包裹空间不足，请准备2格以上的包裹空间。",$Color[2],$chatMsg_Person);
		return;
	}
	ClientOnSptAction(35,0);//通讯服务端
}
//■■■■■■■■■■■答题奖励按钮点击触发■■■■■■■■
