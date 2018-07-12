

//■■■■■■■■■■■【星套强化相关】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【三色石合成相关】■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【三色石分解相关】■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【经脉冲穴相关】■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【经脉淬炼相关】■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【队伍界面相关】■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【角色界面相关】■■■■■■■■■■■■■■■■■

//===================================================热感显示框属性设置===================================================

if (!isObject(GuiTooltipsHoverProfile)) new GuiControlProfile(GuiTooltipsHoverProfile:GuiDefaultProfile)
{
	opaque = false;
	hasBitmapArray = true;
	fillColor = "3 3 7 179";
	border = "-1";
	bitmap = "gameres/gui/images/Hover";
};

//====================================================反沉迷时间获取函数=================================================

function ShowCaptivateTime(%hour,%minute)  //疲劳时间
{
	if (%minute!=0)
	{
		if (%hour==0)
		{
			$time = "累计在线时间："@%minute @ "分钟";
			$time2 = "<b/><t>累计在线时间："@%minute @ "分钟</t>";
		}
		else
		{
			$time = "累计在线时间："@%hour @"小时"@%minute @ "分钟";
			$time2 = "<b/><t>累计在线时间："@%hour @"小时"@%minute @ "分钟</t>";
		}
	}
	else
	{
		if (%hour!=0)
		{
			$time = "累计在线时间："@%hour @"小时";
			$time2 = "<b/><t>累计在线时间："@%hour @"小时</t>";
		}
		else
		{
			$time = "";
			$time2 = "";
		}
	}
	StartTooltip("Exp");
	StartTooltip("Captivate_Img");

}

//====================================================世界地图热感显示=================================================

function showViewMapInfo(%mapId)
{
	switch$(%mapId)
	{
			case "810010100":
				worldMapCtl.tooltipWidth = 210;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>长安</t><b/><t c='0x00ff00ff'>主城和平地图</t><b/><t>建议等级：16-21级，36-42级</t></t>";

			case "810020100":
				worldMapCtl.tooltipWidth = 210;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>洛阳</t><b/><t c='0x00ff00ff'>主城和平地图</t><b/><t>建议等级：16-21级，36-42级</t></t>";

			case "810040100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>白虎圣地</t><b/><t c='0x00ff00ff'>新手地图</t><b/><t>建议等级：1-16级</t></t>";

			case "810050100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>青龙圣地</t><b/><t c='0x00ff00ff'>新手地图</t><b/><t>建议等级：1-16级</t></t>";

			case "810060100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>玄武圣地</t><b/><t c='0x00ff00ff'>新手地图</t><b/><t>建议等级：1-16级</t></t>";

			case "810070100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>朱雀圣地</t><b/><t c='0x00ff00ff'>新手地图</t><b/><t>建议等级：1-16级</t></t>";

			case "810080100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>轩辕圣地</t><b/><t c='0x00ff00ff'>新手地图</t><b/><t>建议等级：1-16级</t></t>";

			case "811010100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>蜀中平原</t><b/><t c='0x00ff00ff'>野外中立地图</t><b/><t>建议等级：21-34级</t></t>";

			case "811020100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>扬州</t><b/><t c='0x00ff00ff'>野外和平地图</t><b/><t>建议等级：46-56级</t></t>";

			case "811030100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>太原</t><b/><t c='0xffff00ff'>野外中立地图</t><b/><t>建议等级：56-66级</t></t>";

			case "811040100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>敦煌</t><b/><t c='0xffff00ff'>野外中立地图</t><b/><t>建议等级：66-76级</t></t>";

			case "811050100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>辽东</t><b/><t c='0xffff00ff'>野外中立地图</t><b/><t>建议等级：76-86级</t></t>";

			case "811060100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>突厥</t><b/><t c='0xffff00ff'>野外中立地图</t><b/><t>建议等级：86-96级</t></t>";

			case "811280100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>酆都鬼城</t><b/><t c='0xff0000ff'>地宫混战地图</t></t>";

			case "811290100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>楼兰古城</t><b/><t c='0xff0000ff'>地宫混战地图</t></t>";

			case "811300100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>秦始皇陵</t><b/><t c='0xff0000ff'>地宫混战地图</t></t>";

			case "813010100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>大雁塔</t><b/><t c='0xffff00ff'>和平地图</t></t>";

			case "813020100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>时空裂痕</t><b/><t c='0xffff00ff'>和平地图</t></t>";

			case "813030100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>皇宫</t><b/><t c='0xffff00ff'>和平地图</t></t>";

			case "813040100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>圣地密室</t><b/><t c='0xffff00ff'>和平地图</t></t>";

			case "813050100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>十八路反王</t><b/><t c='0xffff00ff'>和平地图</t></t>";

			case "813060100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>渡劫台</t><b/><t c='0xffff00ff'>和平地图</t></t>";

			case "814010100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>囚仙牢</t><b/><t c='0xffff00ff'>和平地图</t></t>";


			default:
				worldMapCtl.tooltip ="";

				worldMapCtl.tooltip ="";
				worldMapCtl.tooltipProfile = "GuiTooltipsHoverProfile";

	}
}

//====================================================UI控件热感显示=================================================

function StartTooltip(%ctrl)
{
	%Player = GetPlayer();

	if (%Player==0) return;

	%Family  = %Player.GetFamily();
	%Classes = %Player.GetClasses(0);
	%lidao_or_zhili = %Player.GetClasses(0);

	if (%Family ==0){ %Family1 = "无门阀";  %Strength ="1.50";%Intellect ="1.26";%Pneuma ="2.83"; }
	else if (%Family ==1){ %Family1 = "李阀";%Strength ="1.57";%Intellect ="1.32";%Pneuma ="2.96"; }
	else if (%Family ==2){ %Family1 = "宇文阀";%Strength ="1.57";%Intellect ="1.32";%Pneuma ="2.96"; }
	else if (%Family ==3){ %Family1 = "寇阀";%Strength ="1.50";%Intellect ="1.26";%Pneuma ="2.83"; }
	else if (%Family ==4){ %Family1 = "宋阀";%Strength ="1.57";%Intellect ="1.32";%Pneuma ="2.96"; }
	else if (%Family ==5){ %Family1 = "李阀";%Strength ="1.50";%Intellect ="1.26";%Pneuma ="2.83"; }
	else if (%Family ==6){ %Family1 = "宇文阀";%Strength ="1.50";%Intellect ="1.26";%Pneuma ="2.83"; }
	else if (%Family ==7){ %Family1 = "寇阀";%Strength ="1.57";%Intellect ="1.32";%Pneuma ="2.96"; }
	else if (%Family ==8){ %Family1 = "宋阀";%Strength ="1.50";%Intellect ="1.26";%Pneuma ="2.83"; }

	if (%Classes==0){ %Classes1="新手"; }
	else if (%Classes==1){ %Classes1="战士";%liliang ="1.57";%zhili =""; }
	else if (%Classes==2){ %Classes1="侠客";%liliang ="1.57";%zhili =""; }
	else if (%Classes==3){ %Classes1="法师";%liliang ="";%zhili ="1.32"; }
	else if (%Classes==4){ %Classes1="道士";%liliang ="";%zhili ="1.32"; }
	else if (%Classes==5){ %Classes1="箭翎";%liliang ="1.57";%zhili =""; }


	if (%lidao_or_zhili == 1){ %lidao_or_zhili1 = "力道";%gongjishanghai1 = "物理";%wuxigongji1 = "土"; }
	else  if (%lidao_or_zhili == 2){ %lidao_or_zhili1 = "力道";%gongjishanghai1 = "物理";%wuxigongji1 = "金"; }
	else  if (%lidao_or_zhili == 3){ %lidao_or_zhili1 = "智力";%gongjishanghai1 = "法术";%wuxigongji1 = "火"; }
	else  if (%lidao_or_zhili == 4){ %lidao_or_zhili1 = "智力";%gongjishanghai1 = "法术";%wuxigongji1 = "冰"; }
	else  if (%lidao_or_zhili == 5){ %lidao_or_zhili1 = "力道";%gongjishanghai1 = "物理";%wuxigongji1 = "毒"; }

	%ctrl.tooltipProfile = "GuiTooltipsHoverProfile";

	switch$(%ctrl.GetName())
	{
		//===============================================================================主界面信息==========================================================================================================================
			case "KLPlayerInfoEquipShort_11":
				if ($MissionZhiYin[10032] == 3)
				{
					//关闭豆腐干
					closeHelpDirect1_4(6);
					//开启豆腐干
					OpenDouFuGan(7);
					$MissionZhiYin[10032] = 4;
				}
			case "Exp":

				%Exp1 = %Player.GetExp();        //获得当前经验脚本命令
				%Exp2 = %Player.GetLevelExp();   //获得当前经验上限脚本命令

				if (%Player.GetLevel() < 60){ %size = 230; }
				else if ((%Player.GetLevel() >= 60) && (%Player.GetLevel() < 90)){ %size = 240; }
				else if ((%Player.GetLevel() >= 90) && (%Player.GetLevel() < 120)){ %size = 250; }

				//if(%Exp1 < %Exp2){%clue = "";}
				//else if((%Exp1>=%Exp2)&&(%Exp1< %Exp2*3)){%clue = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>(可升级)</t>";%clue2 ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击角色按钮后,再点击升级按钮可以升级</t>";}
				//else if(%Exp1==3*%Exp2){%clue = "<t c='0xff1200ff'>(经验储存达上限)</t>";%clue2 ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击角色按钮后,再点击升级按钮可以升级</t>";%Color1 = "c='0xff0000ff'";}

				//if(%Player.GetLevel() >= 40)
				//	{
				//		%clue3 ="<b/><t>当前储存经验最大值：</t><t "@ %Color1 @">"@ translateNumToString(3*%Exp2) @"</t>";
				//	}

				%ctrl.tooltipWidth = %size;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>人物经验</t>   <t>"@ %clue @"</t><b/><t>经验值："@ %Exp1 @"/"@ %Exp2 @"</t>"@ %clue3 @""@ $time2 @""@ %clue2 @"</t>";

			case "InputPlayerName_TextTip":
				%ctrl.tooltipWidth = 195;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>展开/隐藏角色神兽头像信息</t></t>";

			case "BirdViewMap_PingBitMap"://ping值显示 0 良好 1 繁忙 2 拥挤 3断线 

				if ($PingSate == 0){ %Ping = "</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>良好"; %width = "130"; }
				else if ($PingSate == 1){ %Ping = "</t><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>繁忙"; %Ping2 ="<b/><t>您当前的网络有点不稳定，可尝试以下操作：</t><b/><t>1、请检查服务器的网络服务商与您网络服务商是否一致</t><b/><t>2、请检查自己电脑或局域网是否正在下载，或使用了限制网络流量的软件</t>"; %width = "300"; }
				else if ($PingSate == 2){ %Ping = "</t><t gct='0xff7171ff' gcb='0xff3c00ff'>拥挤";%Ping2 ="<b/><t>您当前的网络不稳定，可尝试以下操作：</t><b/><t>1、请检查服务器的网络服务商与您网络服务商是否一致</t><b/><t>2、请检查自己电脑或局域网是否正在下载，或使用了限制网络流量的软件</t><b/><t>3、您可以通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>“系统设置”</t><t>调整游戏画面质量，来提高游戏流畅度</t><b/><t>4、您可以启动</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>“娃娃模式”</t><t>进行游戏，提高游戏画面帧数</t>"; %width = "300"; }
				else if ($PingSate == 3){ %Ping = "</t><t c='0x8f8f8eff'>断线"; %width = "130"; }

				%ctrl.tooltipWidth = %width;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>网络延时："@ %Ping @"</t>"@ %Ping2 @"</t>";

			case "PlayerMinimizeButton":
				%ctrl.tooltipWidth = 195;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>展开/隐藏角色神兽头像信息</t></t>";

			case "PlayerMaxmizeButton":
				%ctrl.tooltipWidth = 195;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>展开/隐藏角色神兽头像信息</t></t>";

			case "HideBottomButtonBtn":
				%ctrl.tooltipWidth = 140;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>展开/隐藏通用菜单</t></t>";

			case "InMapButton":
				if (BirdViewHideGui.IsVisible())
				{
					%ctrl.tooltipWidth = 130;
					%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>隐藏小地图模式</t></t>";
				}
				else
				{
					%ctrl.tooltipWidth = 130;
					%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>开启小地图模式</t></t>";
				}
			case "PlayerIconGui":
				%ctrl.tooltipWidth = 185;
				if (%Player.GetHP() >= %Player.GetMaxHP()*0.5){ %Color = ""; }
				else if (%Player.GetHP() < %Player.GetMaxHP()*0.5) { %Color = "c='0xff1200ff'"; }

				if (%Player.GetMP() >= %Player.GetMaxMP()*0.5){ %Color1 = ""; }
				else if (%Player.GetMP() < %Player.GetMaxMP()*0.5) { %Color1 = "c='0xff1200ff'"; }


				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Player.GetPlayerName() @ "</t><b/>" @
					"<t>" @ %Classes1 @ ",</t><t>" @ %Player.Getlevel() @ "级</t><b/>" @
					"<t>生命[HP]：</t><t "@ %Color @">"@ %Player.GetHP() @"</t><t>/</t><t>"@ %Player.GetMaxHP() @"</t><b/>"@
					"<t>法力[MP]：</t><t "@ %Color1 @">"@ %Player.GetMP() @"</t><t>/</t><t>"@ %Player.GetMaxMP() @"</t><b/>"; //@ 
				//"<t>活力[PP]：</t><t "@ %Color1 @">"@ %Player.GetPP() @"</t><t>/</t><t>" @ %Player.GetMaxPP() @ "</t></t>";//去掉之前的化神

				//【 人物头像 】战斗力
			case "FightingPowerButton":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>战斗力</t><b/>" @
					"<t>战斗力是人物综合能力的体现，战斗中，战斗力更高的一方会获得额外无视防御和受伤害减免加成，双方战斗力差越大，加成越高，最高可获50%加成。</t></t>";

			case "GrowAssistantTurnOnBnt":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>成长宝典</t><b/><t>成长宝典会将当前您该了解的信息推荐给您，在您的历程中，成长宝典将一直伴随在您的左右。</t></t>";

				//		case "TheurgyUseWndOpenBtn":
				//			%ctrl.tooltipWidth = 260;
				//			%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>仙术法典</t><b/><t>法典中篆刻着从远古传承至今的各种神通，在峥嵘的尚武岁月中，这些仙术神通必能使您的赫赫威名弘扬三界</t></t>";

			case "PetIconGui"://神兽头像
				%ctrl.tooltipWidth = 170;

				%nSpawnedPetSlot = GetPlayer().GetSpawnedPetSlot();

				%sNewName = PetOperation_GetPetName(%nSpawnedPetSlot);

				%PetLv = PetOperation_GetPetLevel(%nSpawnedPetSlot);
				%nPetCurHp = PetOperation_GetPetHp(%nSpawnedPetSlot);
				%nPetMaxHp = PetOperation_GetPetMaxHp(%nSpawnedPetSlot);

				%nPetCurMp = PetOperation_GetPetMp(%nSpawnedPetSlot);
				%nPetMaxMp = PetOperation_GetPetMaxMp(%nSpawnedPetSlot);

				%nGeneration = PetOperation_GetPetGeneration(%nSpawnedPetSlot);
				if (%nGeneration == 1){ %PetGeneration = "一代"; }
				else if (%nGeneration == 2){ %PetGeneration = "二代"; }
				else if (%nGeneration == 3){ %PetGeneration = "三代"; }

				%nStyle = PetOperation_GetPetStyle(%nSpawnedPetSlot);
				if (%nStyle ==1){ %PetStyle = "神兽宝宝"; }
				else if (%nStyle ==2){ %PetStyle = "变异宝宝"; }
				else if (%nStyle ==3){ %PetStyle = "成年神兽"; }
				else if (%nStyle ==4){ %PetStyle = "变异神兽"; }

				if (%nPetCurHp >= %nPetMaxHp*0.5){ %Color = ""; }
				else if (%nPetCurHp < %nPetMaxHp*0.5) { %Color = "c='0xff1200ff'"; }

				if (%nPetCurMp >= %nPetMaxMp*0.5){ %Color1 = ""; }
				else if (%nPetCurMp < %nPetMaxMp*0.5) { %Color1 = "c='0xff1200ff'"; }


				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %sNewName @"</t><b/><t>"@ %PetLv @ "级 "@ %PetGeneration @ "" @ %PetStyle @ "</t><b/><t>体力[HP]：</t><t "@ %Color @">"@ %nPetCurHp @"</t><t>/</t><t>"@ %nPetMaxHp @"</t></t>";

			case "PetAttackButton":
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='0' f='黑体' b='1'n='14'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>攻击姿态</t><b/><t>神兽跟随攻击主人当前目标</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击切换至防御姿态</t></t>";

			case "PetDefendButton":
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip ="<t m='0' f='黑体' b='1'n='14'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>防御姿态</t><b/><t>神兽只跟随在主人身旁</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击切换至攻击姿态</t></t>";

			case "DeferBitMap_Bnt1":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神元力 [简称：PP]</t><b/><t>化神幻化、内力技能都将消耗元力</t><b/><t>幻化状态下将持续消耗元力槽内的元力</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击可查看化神信息</t></t>";

			case "LiveUpButton_Open":
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='0' f='黑体' b='1'n='14'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>复活神兽</t><b/><t>左键点击</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>关闭</t><t>自动复活神兽</t></t>";

			case "LiveUpButton_Close":
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='0' f='黑体' b='1' n='14'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>复活神兽</t><b/><t>左键点击</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>开启</t><t>自动复活神兽</t></t>";

				/*
				case "DeferBitMap_Bnt2":
				%lingli = %player.getTrumpPoints();
				%lingliMax = %player.getTrumpMaxPoints();
				if(%lingli == 0){%Color1 = "gct='0xff7171ff' gcb='0xff3c00ff' ";}

				if(%lingliMax !=0 )
				{
				%linglitxt1 ="<t>";
				%linglitxt2 ="[</t><t "@ %Color1 @">"@%lingli @"</t><t>/"@ %lingliMax @"]</t>";
				}

				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %linglitxt1 @"星宿灵气 "@ %linglitxt2 @"</t><b/><t>星宿开启自动战斗后会持续消耗灵气</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击可自定义自动战斗设置</t></t>";
				*/
				//		case "LeftOutButton":
				//			%nActiveSpiritSlot = %player.getActiveSpiritSlot();
				//
				//			%ctrl.tooltipWidth = 210;
				//			%txt="<b/><t>化神可让你拥有更加强大的伤害和酷炫的外形</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>角色达到2修,可获得圣地化神</t>";

				//			if($CurSelectModeId == 0){%KJJ ="（P）";}
				//			else if($CurSelectModeId == 1){%KJJ ="（Alt+P）";}
				//			else if($CurSelectModeId == 2){%KJJ ="（P）";}
				//			else if($CurSelectModeId == 3)
				//				{
				//				if(GetHotKey("打开/关闭角色化神界面") !$= "")
				//						%KJJ = "（" @ GetHotKey("打开/关闭角色化神界面") @ "）";
				//				}
				//			if (%nActiveSpiritSlot != -1)
				//				{
				//					%ctrl.tooltipWidth = 250;
				//					%txt="<b/><t>化神可让你拥有更加强大的伤害和酷炫的外形</t>";
				//				}
				//
				//			%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神信息 "@ %KJJ @"</t>"@ %txt @"</t>";

			case "SeekLoadDialog_MinWnd"://寻径提示
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>目前处于寻径中....</t><b/><t>前往["@ $CurrentSeekLoadText1 @"]["@ $CurrentSeekLoadText2 @"]</t></t>";

				//===================================================================星宿快捷栏======================================================================
				/*
				case "LingQiProgressBarTip"://灵气值进度条
				%lingli = %player.getTrumpPoints();
				%lingliMax = %player.getTrumpMaxPoints();

				if(%lingli == 0){%Color1 = "c='0xff0000ff'";}

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>星宿灵气值：</t><t "@ %Color1 @">"@ %lingli @"</t><t>/"@ %lingliMax @"</t><b/><t>自动战斗将持续消耗星宿的智力值</t><b/><t>昆仑决商城内可购买</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>灵气丹</t><t>补充灵气值</t></t>";


				case "FaBaoProgressBarTip"://星宿经验
				%exp = %player.getTrumpExp();
				%expMax = %player.getTrumpMaxExp();

				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>星宿经验值：</t><t>"@ %exp @"/"@ %expMax @"</t><b/><t>1、每释放一次星宿技能即可提升一点星宿经验值</t><b/><t>2、当星宿等级达到6/11/16级，会自动激活镶嵌槽</t><b/><t>3、每个镶嵌槽可以镶嵌1个星宿碎片，当镶嵌满3个星宿碎片时，会变成完整星宿配件，提供更多的属性加成</t></t>";

				*/
				//===================================================================队伍快捷信息======================================================================
			case "MagicCimeliaButtom":

				if ($CurSelectModeId == 0){ %KJJ ="（Z）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+Z）"; }
				else if ($CurSelectModeId == 2){ %KJJ ="（Z）"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭界面") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭战斗助手界面") @ "）";
				}

				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>战斗助手 "@ %KJJ @"</t><b/><t>角色3修装备星宿后,将开启自动战斗功能</t></t>";


			case "TeammateHideButton": //队伍缩小按钮
				if (isFile("gameres/gui/images/GUIWindow30_1_016.png")){ %Team1 = "<i s='gameres/gui/images/GUIWindow30_1_016.png' w='16' h='16'/>"; }
				else{ %Team11 = ""; }
				if (isFile("gameres/gui/images/GUIWindow30_1_017.png")){ %Team2 = "<i s='gameres/gui/images/GUIWindow30_1_017.png' w='16' h='16'/>"; }
				else{ %Team12 = ""; }

				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>隐藏与展开队友头像</t><b/><t>队友头顶图标说明：</t><b/><t>"@ %Team1 @"</t><t>  队长的标志</t><b/><t>"@ %Team2 @"</t><t>  队员的标志</t></t>";


			case "TeammateIcon0_0":
				%Idd = TeammateIcon0_0.getplayer();
				%Id = ClientGetPlayer(%Idd);
				%Name = Cache_getPlayerName(%Idd);
				%LV = Cache_getPlayerLevel(%Idd);



				%Level = "<t>"@ %LV @ "级</t>";
				%TeamClasses1 = UI_GetJobName(spt_CacheGetPlayerJob(%Idd));


				%Xianlu = sptGetTeammateLineId(%Idd);
				%ditu = sptGetTeammateTriggerName(%Idd);
				if (%ditu $=""){ %ditu ="获取地图信息中..."; }

				if (sptGetTeammateZoneId(%Idd) > 9999)
				{
					%Xianlu ="副本:";
				}
				else
				{
					%Xianlu ="";
				}

				/* 	%TeamRace = Cache_getPlayerFamily(%Idd);
				if(%TeamRace ==1){%TeamFamily1 = "<t>李阀,</t>";}
				else if(%TeamRace ==2){%TeamFamily1 = "<t>宇文阀,</t>";}
				else if(%TeamRace ==3){%TeamFamily1 = "<t>寇阀,</t>";}
				else if(%TeamRace ==4){%TeamFamily1 = "<t>宋阀,</t>";}
				else if(%TeamRace ==5){%TeamFamily1 = "<t>李阀,</t>";}
				else if(%TeamRace ==6){%TeamFamily1 = "<t>宇文阀,</t>";}
				else if(%TeamRace ==7){%TeamFamily1 = "<t>寇阀,</t>";}
				else if(%TeamRace ==8){%TeamFamily1 = "<t>宋阀,</t>";} */

				if (%id == 0)
				{
					%HP = "未知";
					%MaxHP = "";
					%MP = "未知";
					%MaxMP = "";
					%online = SptTeam_IsOnline(%Idd);
					if (%online==0){ %Team="<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>该队员已离线</t>"; %size = 170; }
					else if (%online==1)
					{
						%Team="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>"@  %Xianlu @""@ %ditu @"</t>";
						%size = 180;
					}
				}
				else
				{
					%HP = %Id.GetHP();
					%MaxHP = "/"@ %Id.GetMaxHP() @"";
					%MP = %Id.GetMP();
					%MaxMP = "/"@ %Id.GetMaxMP() @"";
					%size = 180;
					%TeamClasses = %Id.GetClasses(0);
					if (%TeamClasses==0){ %TeamClasses1=""; }


					if (%Id.GetHP() >= %Id.GetMaxHP()*0.5){ %Color = ""; }
					else if (%Id.GetHP() < %Id.GetMaxHP()*0.5) { %Color = "c='0xff1200ff'"; }

					if (%Id.GetMP() >= %Id.GetMaxMP()*0.5){ %Color1 = ""; }
					else if (%Id.GetMP() < %Id.GetMaxMP()*0.5) { %Color1 = "c='0xff1200ff'"; }
				}

				%ctrl.tooltipWidth = %size;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Name @"</t><b/>"@ %TeamFamily1 @"  "@ %Level @"  "@ %TeamClasses1 @"<b/><t>生命(HP)：</t><t "@ %Color @">"@ %HP @"</t><t>"@ %MaxHP @"</t><b/><t>法力(MP)：</t><t "@ %Color1 @">"@ %MP @"</t><t>"@ %MaxMP @"</t>"@ %Team @"</t>";

			case "TeammateIcon1_1":
				%Idd = TeammateIcon1_1.getplayer();
				%Id = ClientGetPlayer(%Idd);
				%Name = Cache_getPlayerName(%Idd);
				%LV = Cache_getPlayerLevel(%Idd);



				%Level = "<t>"@ %LV @ "级</t>";
				%TeamClasses1 = UI_GetJobName(spt_CacheGetPlayerJob(%Idd));

				%Xianlu = sptGetTeammateLineId(%Idd);
				%ditu = sptGetTeammateTriggerName(%Idd);
				if (%ditu $=""){ %ditu ="获取地图信息中..."; }

				if (sptGetTeammateZoneId(%Idd) > 9999)
				{
					%Xianlu ="副本:";
				}
				else
				{
					%Xianlu ="";
				}

				/* 	%TeamRace = Cache_getPlayerFamily(%Idd);
				if(%TeamRace ==1){%TeamFamily1 = "<t>李阀,</t>";}
				else if(%TeamRace ==2){%TeamFamily1 = "<t>宇文阀,</t>";}
				else if(%TeamRace ==3){%TeamFamily1 = "<t>寇阀,</t>";}
				else if(%TeamRace ==4){%TeamFamily1 = "<t>宋阀,</t>";}
				else if(%TeamRace ==5){%TeamFamily1 = "<t>李阀,</t>";}
				else if(%TeamRace ==6){%TeamFamily1 = "<t>宇文阀,</t>";}
				else if(%TeamRace ==7){%TeamFamily1 = "<t>寇阀,</t>";}
				else if(%TeamRace ==8){%TeamFamily1 = "<t>宋阀,</t>";}*/

				if (%id == 0)
				{
					%HP = "未知";
					%MaxHP = "";
					%MP = "未知";
					%MaxMP = "";
					%online = SptTeam_IsOnline(%Idd);
					if (%online==0){ %Team="<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>该队员已离线</t>"; %size = 170; }
					else if (%online==1)
					{
						%Team="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>"@  %Xianlu @""@ %ditu @"</t>";
						%size = 180;
					}
				}
				else
				{
					%HP = %Id.GetHP();
					%MaxHP = "/"@ %Id.GetMaxHP() @"";
					%MP = %Id.GetMP();
					%MaxMP = "/"@ %Id.GetMaxMP() @"";
					%size = 180;
					%TeamClasses = %Id.GetClasses(0);
					if (%TeamClasses==0){ %TeamClasses1="新手"; }


					if (%Id.GetHP() >= %Id.GetMaxHP()*0.5){ %Color = ""; }
					else if (%Id.GetHP() < %Id.GetMaxHP()*0.5) { %Color = "c='0xff1200ff'"; }

					if (%Id.GetMP() >= %Id.GetMaxMP()*0.5){ %Color1 = ""; }
					else if (%Id.GetMP() < %Id.GetMaxMP()*0.5) { %Color1 = "c='0xff1200ff'"; }
				}

				%ctrl.tooltipWidth = %size;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Name @"</t><b/>"@ %TeamFamily1 @"  "@ %Level @"  "@ %TeamClasses1@"<b/><t>生命(HP)：</t><t "@ %Color @">"@ %HP @"</t><t>"@ %MaxHP @"</t><b/><t>法力(MP)：</t><t "@ %Color1 @">"@ %MP @"</t><t>"@ %MaxMP @"</t>"@ %Team @"</t>";

			case "TeammateIcon2_2":
				%Idd = TeammateIcon2_2.getplayer();
				%Id = ClientGetPlayer(%Idd);
				%Name = Cache_getPlayerName(%Idd);
				%LV = Cache_getPlayerLevel(%Idd);



				%Level = "<t>"@ %LV @ "级</t>";
				%TeamClasses1 = UI_GetJobName(spt_CacheGetPlayerJob(%Idd));

				%Xianlu = sptGetTeammateLineId(%Idd);
				%ditu = sptGetTeammateTriggerName(%Idd);
				if (%ditu $=""){ %ditu ="获取地图信息中..."; }

				if (sptGetTeammateZoneId(%Idd) > 9999)
				{
					%Xianlu ="副本:";
				}
				else
				{
					%Xianlu ="";
				}

				/* 	%TeamRace = Cache_getPlayerFamily(%Idd);
				if(%TeamRace ==1){%TeamFamily1 = "<t>李阀,</t>";}
				else if(%TeamRace ==2){%TeamFamily1 = "<t>宇文阀,</t>";}
				else if(%TeamRace ==3){%TeamFamily1 = "<t>寇阀,</t>";}
				else if(%TeamRace ==4){%TeamFamily1 = "<t>宋阀,</t>";}
				else if(%TeamRace ==5){%TeamFamily1 = "<t>李阀,</t>";}
				else if(%TeamRace ==6){%TeamFamily1 = "<t>宇文阀,</t>";}
				else if(%TeamRace ==7){%TeamFamily1 = "<t>寇阀,</t>";}
				else if(%TeamRace ==8){%TeamFamily1 = "<t>宋阀,</t>";}*/

				if (%id == 0)
				{
					%HP = "未知";
					%MaxHP = "";
					%MP = "未知";
					%MaxMP = "";
					%online = SptTeam_IsOnline(%Idd);
					if (%online==0){ %Team="<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>该队员已离线</t>"; %size = 170; }
					else if (%online==1)
					{
						%Team="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>"@  %Xianlu @""@ %ditu @"</t>";
						%size = 180;
					}
				}
				else
				{
					%HP = %Id.GetHP();
					%MaxHP = "/"@ %Id.GetMaxHP() @"";
					%MP = %Id.GetMP();
					%MaxMP = "/"@ %Id.GetMaxMP() @"";
					%size = 180;
					%TeamClasses = %Id.GetClasses(0);
					if (%TeamClasses==0){ %TeamClasses1="新手"; }


					if (%Id.GetHP() >= %Id.GetMaxHP()*0.5){ %Color = ""; }
					else if (%Id.GetHP() < %Id.GetMaxHP()*0.5) { %Color = "c='0xff1200ff'"; }

					if (%Id.GetMP() >= %Id.GetMaxMP()*0.5){ %Color1 = ""; }
					else if (%Id.GetMP() < %Id.GetMaxMP()*0.5) { %Color1 = "c='0xff1200ff'"; }
				}

				%ctrl.tooltipWidth = %size;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Name @"</t><b/>"@ %TeamFamily1 @"  "@ %Level @"  "@ %TeamClasses1@"<b/><t>生命(HP)：</t><t "@ %Color @">"@ %HP @"</t><t>"@ %MaxHP @"</t><b/><t>法力(MP)：</t><t "@ %Color1 @">"@ %MP @"</t><t>"@ %MaxMP @"</t>"@ %Team @"</t>";

			case "TeammateIcon3_3":
				%Idd = TeammateIcon3_3.getplayer();
				%Id = ClientGetPlayer(%Idd);
				%Name = Cache_getPlayerName(%Idd);
				%LV = Cache_getPlayerLevel(%Idd);



				%Level = "<t>"@ %LV @ "级</t>";
				%TeamClasses1 = UI_GetJobName(spt_CacheGetPlayerJob(%Idd));

				%Xianlu = sptGetTeammateLineId(%Idd);
				%ditu = sptGetTeammateTriggerName(%Idd);
				if (%ditu $=""){ %ditu ="获取地图信息中..."; }

				if (sptGetTeammateZoneId(%Idd) > 9999)
				{
					%Xianlu ="副本:";
				}
				else
				{
					%Xianlu ="";
				}

				/* 	%TeamRace = Cache_getPlayerFamily(%Idd);
				if(%TeamRace ==1){%TeamFamily1 = "<t>李阀,</t>";}
				else if(%TeamRace ==2){%TeamFamily1 = "<t>宇文阀,</t>";}
				else if(%TeamRace ==3){%TeamFamily1 = "<t>寇阀,</t>";}
				else if(%TeamRace ==4){%TeamFamily1 = "<t>宋阀,</t>";}
				else if(%TeamRace ==5){%TeamFamily1 = "<t>李阀,</t>";}
				else if(%TeamRace ==6){%TeamFamily1 = "<t>宇文阀,</t>";}
				else if(%TeamRace ==7){%TeamFamily1 = "<t>寇阀,</t>";}
				else if(%TeamRace ==8){%TeamFamily1 = "<t>宋阀,</t>";}*/

				if (%id == 0)
				{
					%HP = "未知";
					%MaxHP = "";
					%MP = "未知";
					%MaxMP = "";
					%online = SptTeam_IsOnline(%Idd);
					if (%online==0){ %Team="<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>该队员已离线</t>"; %size = 170; }
					else if (%online==1)
					{
						%Team="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>"@  %Xianlu @""@ %ditu @"</t>";
						%size = 180;
					}
				}
				else
				{
					%HP = %Id.GetHP();
					%MaxHP = "/"@ %Id.GetMaxHP() @"";
					%MP = %Id.GetMP();
					%MaxMP = "/"@ %Id.GetMaxMP() @"";
					%size = 180;
					%TeamClasses = %Id.GetClasses(0);
					if (%TeamClasses==0){ %TeamClasses1="新手"; }


					if (%Id.GetHP() >= %Id.GetMaxHP()*0.5){ %Color = ""; }
					else if (%Id.GetHP() < %Id.GetMaxHP()*0.5) { %Color = "c='0xff1200ff'"; }

					if (%Id.GetMP() >= %Id.GetMaxMP()*0.5){ %Color1 = ""; }
					else if (%Id.GetMP() < %Id.GetMaxMP()*0.5) { %Color1 = "c='0xff1200ff'"; }
				}

				%ctrl.tooltipWidth = %size;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Name @"</t><b/>"@ %TeamFamily1 @"  "@ %Level @"  "@ %TeamClasses1@"<b/><t>生命(HP)：</t><t "@ %Color @">"@ %HP @"</t><t>"@ %MaxHP @"</t><b/><t>法力(MP)：</t><t "@ %Color1 @">"@ %MP @"</t><t>"@ %MaxMP @"</t>"@ %Team @"</t>";

			case "TeammateIcon4_4":
				%Idd = TeammateIcon4_4.getplayer();
				%Id = ClientGetPlayer(%Idd);
				%Name = Cache_getPlayerName(%Idd);
				%LV = Cache_getPlayerLevel(%Idd);

				%Tens = mFloor(%LV/10);
				%Num = %LV%10;

				%Level = "<t>"@ %LV @ "级</t>";
				%TeamClasses1 = UI_GetJobName(spt_CacheGetPlayerJob(%Idd));

				%Xianlu = sptGetTeammateLineId(%Idd);
				%ditu = sptGetTeammateTriggerName(%Idd);
				if (%ditu $=""){ %ditu ="获取地图信息中..."; }

				if (sptGetTeammateZoneId(%Idd) > 9999)
				{
					%Xianlu ="副本:";
				}
				else
				{
					%Xianlu ="";
				}

				/*	%TeamRace = Cache_getPlayerFamily(%Idd);
				if(%TeamRace ==1){%TeamFamily1 = "<t>李阀,</t>";}
				else if(%TeamRace ==2){%TeamFamily1 = "<t>宇文阀,</t>";}
				else if(%TeamRace ==3){%TeamFamily1 = "<t>寇阀,</t>";}
				else if(%TeamRace ==4){%TeamFamily1 = "<t>宋阀,</t>";}
				else if(%TeamRace ==5){%TeamFamily1 = "<t>李阀,</t>";}
				else if(%TeamRace ==6){%TeamFamily1 = "<t>宇文阀,</t>";}
				else if(%TeamRace ==7){%TeamFamily1 = "<t>寇阀,</t>";}
				else if(%TeamRace ==8){%TeamFamily1 = "<t>宋阀,</t>";}*/

				if (%id == 0)
				{
					%HP = "未知";
					%MaxHP = "";
					%MP = "未知";
					%MaxMP = "";
					%online = SptTeam_IsOnline(%Idd);
					if (%online==0){ %Team="<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>该队员已离线</t>"; %size = 170; }
					else if (%online==1)
					{
						%Team="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>"@  %Xianlu @""@ %ditu @"</t>";
						%size = 180;
					}
				}
				else
				{
					%HP = %Id.GetHP();
					%MaxHP = "/"@ %Id.GetMaxHP() @"";
					%MP = %Id.GetMP();
					%MaxMP = "/"@ %Id.GetMaxMP() @"";
					%size = 180;
					%TeamClasses = %Id.GetClasses(0);
					if (%TeamClasses==0){ %TeamClasses1="新手"; }


					if (%Id.GetHP() >= %Id.GetMaxHP()*0.5){ %Color = ""; }
					else if (%Id.GetHP() < %Id.GetMaxHP()*0.5) { %Color = "c='0xff1200ff'"; }

					if (%Id.GetMP() >= %Id.GetMaxMP()*0.5){ %Color1 = ""; }
					else if (%Id.GetMP() < %Id.GetMaxMP()*0.5) { %Color1 = "c='0xff1200ff'"; }
				}

				%ctrl.tooltipWidth = %size;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Name @"</t><b/>"@ %TeamFamily1 @"  "@ %Level @"  "@ %TeamClasses1@"<b/><t>生命(HP)：</t><t "@ %Color @">"@ %HP @"</t><t>"@ %MaxHP @"</t><b/><t>法力(MP)：</t><t "@ %Color1 @">"@ %MP @"</t><t>"@ %MaxMP @"</t>"@ %Team @"</t>";

			case "TeammateIcon5_5":
				%Idd = TeammateIcon5_5.getplayer();
				%Id = ClientGetPlayer(%Idd);
				%Name = Cache_getPlayerName(%Idd);
				%LV = Cache_getPlayerLevel(%Idd);



				%Level = "<t>"@ %LV @ "级</t>";
				%TeamClasses1 = UI_GetJobName(spt_CacheGetPlayerJob(%Idd));

				%Xianlu = sptGetTeammateLineId(%Idd);
				%ditu = sptGetTeammateTriggerName(%Idd);
				if (%ditu $=""){ %ditu ="获取地图信息中..."; }

				if (sptGetTeammateZoneId(%Idd) > 9999)
				{
					%Xianlu ="副本:";
				}
				else
				{
					%Xianlu ="";
				}

				/*	%TeamRace = Cache_getPlayerFamily(%Idd);
				if(%TeamRace ==1){%TeamFamily1 = "<t>李阀,</t>";}
				else if(%TeamRace ==2){%TeamFamily1 = "<t>宇文阀,</t>";}
				else if(%TeamRace ==3){%TeamFamily1 = "<t>寇阀,</t>";}
				else if(%TeamRace ==4){%TeamFamily1 = "<t>宋阀,</t>";}
				else if(%TeamRace ==5){%TeamFamily1 = "<t>李阀,</t>";}
				else if(%TeamRace ==6){%TeamFamily1 = "<t>宇文阀,</t>";}
				else if(%TeamRace ==7){%TeamFamily1 = "<t>寇阀,</t>";}
				else if(%TeamRace ==8){%TeamFamily1 = "<t>宋阀,</t>";}*/

				if (%id == 0)
				{
					%HP = "未知";
					%MaxHP = "";
					%MP = "未知";
					%MaxMP = "";
					%online = SptTeam_IsOnline(%Idd);
					if (%online==0){ %Team="<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>该队员已离线</t>"; %size = 170; }
					else if (%online==1)
					{
						%Team="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>"@  %Xianlu @""@ %ditu @"</t>";
						%size = 180;
					}
				}
				else
				{
					%HP = %Id.GetHP();
					%MaxHP = "/"@ %Id.GetMaxHP() @"";
					%MP = %Id.GetMP();
					%MaxMP = "/"@ %Id.GetMaxMP() @"";
					%size = 180;
					%TeamClasses = %Id.GetClasses(0);
					if (%TeamClasses==0){ %TeamClasses1="新手"; }


					if (%Id.GetHP() >= %Id.GetMaxHP()*0.5){ %Color = ""; }
					else if (%Id.GetHP() < %Id.GetMaxHP()*0.5) { %Color = "c='0xff1200ff'"; }

					if (%Id.GetMP() >= %Id.GetMaxMP()*0.5){ %Color1 = ""; }
					else if (%Id.GetMP() < %Id.GetMaxMP()*0.5) { %Color1 = "c='0xff1200ff'"; }
				}

				%ctrl.tooltipWidth = %size;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Name @"</t><b/>"@ %TeamFamily1 @"  "@ %Level @"  "@ %TeamClasses1@"<b/><t>生命(HP)：</t><t "@ %Color @">"@ %HP @"</t><t>"@ %MaxHP @"</t><b/><t>法力(MP)：</t><t "@ %Color1 @">"@ %MP @"</t><t>"@ %MaxMP @"</t>"@ %Team @"</t>";

			case "SelectChannelButton1"://聊天界面全服页
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>全服频道</t><b/><t>该分页显示游戏中所有频道的聊天信息</t><b/><t>系统默认分页,无法进行自定义修改</t></t>";


			case "SelectChannelButton2"://聊天界面附近页
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>附近频道</t><b/><t>该分页显示附近区域信息及密语信息</t><b/><t>系统默认分页,无法进行自定义修改</t></t>";

			case "SelectChannelButton8"://聊天界面团队页
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>队伍&团队频道</t><b/><t>该分页显示队伍和团队聊天信息及密语信息</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>左键单击</t><t>可直接在团队频道内发言</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键单击</t><t>可直接在队伍频道内发言</t><b/><t>系统默认分页,无法进行自定义修改</t></t>";

			case "SelectChannelButton3"://聊天界面个人页
				%ctrl.tooltipWidth = 260;
				if (%Family !=0)
				{
					%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>个人频道</t><b/><t>该分页显示玩家的聊天信息及密语信息</t><b/><t>系统默认分页,无法进行自定义修改</t></t>";
				}
				else
				{
					%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>个人频道</t><b/><t>该分页显示玩家个人聊天信息</t><b/><t>系统默认分页,无法进行自定义修改</t></t>";
				}




			case "SelectChannelButton4"://聊天队伍页
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>队伍频道</t><b/><t>该分页显示玩家队伍的聊天信息及密语信息</t><b/><t>系统默认分页,无法进行自定义修改</t></t>";

			case "SelectChannelButton5"://聊天界面帮派页
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>帮派频道</t><b/><t>该分页显示帮派内聊天信息及密语信息</t><b/><t>系统默认分页,无法进行自定义修改</t></t>";

			case "SelectChannelButton6":	//自定义频道
				%ctrl.tooltipWidth = 290;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>自定义频道</t><b/><t>该分页可自定义设置显示聊天信息</t><b/><t>点击右侧</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>聊天设置</t><t>可对自定义频道进行设置</t></t>";

			case "UpMaqnifyButton":	//聊天显示区域变高
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>改变聊天区域高度</t><b/><t>左键单击改变聊天显示区域纵向高度</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键单击</t><t>纵向高度恢复至默认高度</t></t>";

			case "RightMaqnifyButton":	//聊天显示区域变长
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>改变聊天区域宽度</t><b/><t>左键单击改变聊天显示区域横向宽度</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键单击</t><t>横向宽度恢复至默认宽度</t></t>";

			case "ChatWndClearButton":	//聊天信息清除
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>清空聊天信息</t><b/><t>点击清除聊天显示区域信息</t></t>";

			case "ChatWndSettingButton":	//聊天设置
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>聊天设置</t><b/><t>自定义频道、聊天背景透明度设置</t></t>";

			case "ChatWndUnLockButton":	//聊天锁定
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>聊天显示区域锁定</t><b/><t>点击按钮聊天显示区域将完全穿透</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>建议战斗过程中使用</t></t>";

			case "ChatWndLockButton":	//聊天解锁
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>聊天显示区域解锁</t><b/><t>点击按钮聊天显示区域取消完全穿透</t></t>";

			case "FaceButton":	//聊天表情
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>表情</t><b/><t>点击打开表情动作界面</t></t>";

			case "InputButton":	//聊天发送
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>发送</t><b/><t>点击发送输入框内信息或</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>按Enter键</t><t>发送信息</t></t>";


				//商城热感提示

			case "MallWnd_ScorePVE":	//积分
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>积分</t><b/><t>可通过提取</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>元宝</t><t>获得该积分</t><b/><t>积分可以在</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>充值豪礼</t><t>界面兑换大礼包</t></t>";


			case "MallWnd_ScoreBmp":	//积分
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>积分</t><b/><t>可通过提取</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>元宝</t><t>获得该积分</t><b/><t>积分可以在</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>充值豪礼</t><t>界面兑换大礼包</t></t>";

			case "MallWnd_SilverBmp":	//金钱
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>金钱</t><b/><t>可通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>任务、活动、出售物品、交易</t><t>等获得该金钱</t></t>";

			case "MallWnd_Copper":	//金钱
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>金钱</t><b/><t>可通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>任务、活动、出售物品、交易</t><t>等获得该金钱</t></t>";

			case "MallWnd_GoldBmp":	//金钱
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>金钱</t><b/><t>可通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>任务、活动、出售物品、交易</t><t>等获得该金钱</t></t>";
			case "MallWnd_Copper":	//金钱
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>金钱</t><b/><t>可通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>任务、活动、出售物品、交易</t><t>等获得该金钱</t></t>";
			case "MallWnd_Silver":	//金钱
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>金钱</t><b/><t>可通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>任务、活动、出售物品、交易</t><t>等获得该金钱</t></t>";
			case "MallWnd_Gold":	//金钱
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>金钱</t><b/><t>可通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>任务、活动、出售物品、交易</t><t>等获得该金钱</t></t>";


			case "MallWnd_MoneyBmp":	//元宝
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元宝</t><b/><t>可通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>充值、活动、交易</t><t>等途径获得该元宝</t></t>";

			case "MallWnd_YuanBao":	//元宝
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元宝</t><b/><t>可通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>充值、活动、交易</t><t>等途径获得该元宝</t></t>";


				//战斗助手热感
			case "FightAssistantBnt_pickup_white_01":	//白色装备
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>白色装备</t><b/><t>包括白色品质的：</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>头部、身体、手部、肩部、腰部、背部、脚部、项链、护符、戒指、长枪、刀剑、法器、法杖、时装、羽翼</t><t>等道具物品</t></t>";

			case "FightAssistantBnt_pickup_green_01":	//绿色装备
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>绿色装备</t><b/><t>包括绿色品质的：</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>头部、身体、手部、肩部、腰部、背部、脚部、项链、护符、戒指、长枪、刀剑、法器、法杖、时装、羽翼</t><t>等道具物品</t></t>";

			case "FightAssistantBnt_pickup_blue_01":	//蓝色装备
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>蓝色装备</t><b/><t>包括蓝色品质的：</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>头部、身体、手部、肩部、腰部、背部、脚部、项链、护符、戒指、长枪、刀剑、法器、法杖、时装、羽翼</t><t>等道具物品</t></t>";

			case "FightAssistantBnt_pickup_purple_01":	//紫色装备
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>紫色装备</t><b/><t>包括紫色及以上品质的：</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>头部、身体、手部、肩部、腰部、背部、脚部、项链、护符、戒指、长枪、刀剑、法器、法杖、时装、羽翼</t><t>等道具物品</t></t>";

			case "FightAssistantBnt_pickup_rare_01":	//稀有物品
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>稀有装备</t><b/><t>包括：</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>施法材料、宝物、称号、造化符、璞玉、鉴宝幸运符、附加材料</t><t>等道具物品</t></t>";

			case "FightAssistantBnt_pickup_common_01":	//普通物品
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>普通物品</t><b/><t>包括：</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>书籍、物品、礼包</t><t>等道具物品</t></t>";
			case "FightAssistantBnt_pickup_task_01"://任务物品
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>任务物品</t><b/><t>包括：</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>任务、任务物品</t><t>等道具物品</t></t>";
			case "FightAssistantBnt_pickup_money_01"://金币
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>金币</t><b/><t>包括：</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>散落在地上的金钱</t></t>";
			case "FightAssistantBnt_pickup_formula_01":	//配方
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>配方</t><b/><t>包括：</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>铸造图纸、裁缝图纸、工艺图纸、符咒图纸、炼丹图纸、烹饪图纸</t><t>等道具物品</t></t>";

			case "FightAssistantBnt_pickup_skillbook_01":	//技能书
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>技能书</t><b/><t>包括的：</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>战士技能书、法师技能书、道士技能书、技能升级卷轴</t><t>等道具物品</t></t>";

			case "FightAssistantBnt_pickup_expendable_01":	//药物食品
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>药品食物</t><b/><t>包括：</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>药品、食物</t><t>等道具物品</t></t>";

			case "FightAssistantBnt_pickup_material_01":	//宝石
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>宝石</t><b/><t>包括：</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>宝石碎片、红宝石、蓝宝石、绿宝石</t><t>等道具物品</t></t>";
			case "FightAssistantBnt_pickup_livingMeterial_01"://生活材料
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>生活材料</t><b/><t>包括：</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>草药、矿物、农作物、木材、鱼类、兽肉、奇珍、布料、纸张</t><t>等道具物品</t></t>";

			case "FightAssistantBnt_pickup_other_01":	//其他
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>其他</t><b/><t>包括：</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>工具、包裹、卷轴、法宝、灵兽封印、骑宠封印</t><t>等道具物品</t></t>";


				//==============================================================================================角色界面相关================================================================
			case "KLJPlayerSuitbtn":
				StartTooltip_DTPlayerInfo_FashionLevel(%ctrl,$g_MySelfEquipLevel);
			case "KLJTargetInfoGuiSuitbtn":
				StartTooltip_DTPlayerInfo_FashionLevel(%ctrl,$g_TargetEquipLevel);
			case "KLPlayerInfo_FYZtext":
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>福缘</t><b/><t>福缘影响鉴宝获取道具的概率，装备掉落的概率，装备附加属性出现的概率，造化神石合成成功率。</t></t>";
			case "KLPlayerInfo_FYZ":
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>福缘</t><b/><t>福缘影响鉴宝获取道具的概率，装备掉落的概率，装备附加属性出现的概率，造化神石合成成功率。</t></t>";
			case "KLPlayerInfo_ZDLtext":
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>战斗力</t><b/><t>根据装备属性、技能等级、人物等级等计算出的角色属性评分。</t></t>";
			case "KLPlayerInfo_ZDL":
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>战斗力</t><b/><t>根据装备属性、技能等级、人物等级等计算出的角色属性评分。</t></t>";
			case "KLPlayerInfo_SLZtext":
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>善恶值</t><b/><t>恶意攻击打败其他角色会导致善恶值提高，善恶值影响自身死亡时的爆率。</t></t>";
			case "KLPlayerInfo_SLZ":
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>善恶值</t><b/><t>恶意攻击打败其他角色会导致善恶值提高，善恶值影响自身死亡时的爆率。</t></t>";
			case "KLPlayerInfo_ExpPercentControl":
				%Exp1 = %Player.GetExp();        //获得当前经验脚本命令
				%Exp2 = %Player.GetLevelExp();   //获得当前经验上限脚本命令

				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>人物经验</t><b/><t>经验值："@ %Exp1 @"/"@ %Exp2 @"</t></t>";
			case "KLPlayerInfo_LL"://力量属性
				%Strength = GetPlayer().GetStrength();	//获取对象力量值
				switch (%Player.GetClasses(0))
				{
					case 1://战士
						%Text1 = mfloor(%Strength * 0.67);
						%Text2 = mfloor(%Strength * 1.33);
						%Text3 = mfloor(%Strength * 0);
						%Text4 = mfloor(%Strength * 0.39);
					case 2://刺客
						%Text1 = mfloor(%Strength * 0.67);
						%Text2 = mfloor(%Strength * 1.33);
						%Text3 = mfloor(%Strength * 0.39);
						%Text4 = mfloor(%Strength * 0);
					case 3://法师
						%Text1 = mfloor(%Strength * 0);
						%Text2 = mfloor(%Strength * 0);
						%Text3 = mfloor(%Strength * 0);
						%Text4 = mfloor(%Strength * 0);
					case 4://道士
						%Text1 = mfloor(%Strength * 0);
						%Text2 = mfloor(%Strength * 0);
						%Text3 = mfloor(%Strength * 0);
						%Text4 = mfloor(%Strength * 0);
					case 5://弓手
						%Text1 = mfloor(%Strength * 0.67);
						%Text2 = mfloor(%Strength * 1.33);
						%Text3 = mfloor(%Strength * 0.39);
						%Text4 = mfloor(%Strength * 0);
				}
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>力量属性</t><b/><t>该属性会增加以下属性值：</t><b/><t>1、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>最小物理攻击 +" @ %Text1 @ "</t><b/><t>2、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>最大物理攻击 +" @ %Text2 @ "</t><b/><t>3、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>暴击 +" @ %Text3 @ "</t><b/><t>4、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>物理防御 +" @ %Text4 @ "</t></t>";

			case "KLPlayerInfo_Intellect"://智力

				%Intellect = GetPlayer().GetIntellect(); //获取对象智力值
				switch (%Player.GetClasses(0))
				{
					case 1://战士
						%Text1 = mfloor(%Intellect * 0);
						%Text2 = mfloor(%Intellect * 0);
						%Text3 = mfloor(%Intellect * 0);
						%Text4 = mfloor(%Intellect * 0);
					case 2://刺客
						%Text1 = mfloor(%Intellect * 0);
						%Text2 = mfloor(%Intellect * 0);
						%Text3 = mfloor(%Intellect * 0);
						%Text4 = mfloor(%Intellect * 0);
					case 3://法师
						%Text1 = mfloor(%Intellect * 0.67);
						%Text2 = mfloor(%Intellect * 1.33);
						%Text3 = mfloor(%Intellect * 0.39);
						%Text4 = mfloor(%Intellect * 0);
					case 4://奶妈
						%Text1 = mfloor(%Intellect * 0.67);
						%Text2 = mfloor(%Intellect * 1.33);
						%Text3 = mfloor(%Intellect * 0);
						%Text4 = mfloor(%Intellect * 0.52);
					case 5://弓手
						%Text1 = mfloor(%Intellect * 0);
						%Text2 = mfloor(%Intellect * 0);
						%Text3 = mfloor(%Intellect * 0);
						%Text4 = mfloor(%Intellect * 0);
				}

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>智力属性</t><b/><t>该属性会增加以下属性值：</t><b/><t>1、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>最小法术攻击 +" @ %Text1 @ "</t><b/><t>2、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>最大法术攻击 +" @ %Text2 @ "</t><b/><t>3、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>暴击伤害 +" @ %Text3 @ "</t><b/><t>4、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>法术防御 +" @ %Text4 @ "</t></t>";

			case "KLPlayerInfo_TL"://体力
				%Stamina = GetPlayer().getStamina();	//获取对象体质值
				switch (%Player.GetClasses(0))
				{
					case 1://战士
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
					case 2://刺客
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
					case 3://法师
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
					case 4://奶妈
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
					case 5://弓手
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
				}

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>体力属性</t><b/><t>该属性会增加以下属性值：</t><b/><t>1、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>生命值 +" @ %Text1 @ "</t><b/><t>2、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>生命恢复 +" @ %Text2 @ "</t></t>";

			case "KLPlayerInfo_JS"://精神
				%Mana = GetPlayer().GetMana();	//获取对象法力值
				switch (%Player.GetClasses(0))
				{
					case 1://战士
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0);
						%Text4 = mfloor(%Mana * 0);
					case 2://刺客
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0);
						%Text4 = mfloor(%Mana * 0);
					case 3://法师
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0.54);
						%Text4 = mfloor(%Mana * 1.08);
					case 4://奶妈
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0.54);
						%Text4 = mfloor(%Mana * 1.08);
					case 5://弓手
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0);
						%Text4 = mfloor(%Mana * 0);
				}

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>精神属性</t><b/><t>该属性会增加以下属性值：</t><b/><t>1、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>法力上限 +" @ %Text1 @ "</t><b/><t>2、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>法力回复 +" @ %Text2 @ "</t><b/><t>3、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>最小法术攻击 +" @ %Text3 @ "</t><b/><t>4、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>最大法术攻击 +" @ %Text4 @ "</t></t>";


			case "KLPlayerInfo_LLtext"://力量属性
				%Strength = GetPlayer().GetStrength();	//获取对象力量值
				switch (%Player.GetClasses(0))
				{
					case 1://战士
						%Text1 = mfloor(%Strength * 0.67);
						%Text2 = mfloor(%Strength * 1.33);
						%Text3 = mfloor(%Strength * 0);
						%Text4 = mfloor(%Strength * 0.39);
					case 2://刺客
						%Text1 = mfloor(%Strength * 0.67);
						%Text2 = mfloor(%Strength * 1.33);
						%Text3 = mfloor(%Strength * 0.39);
						%Text4 = mfloor(%Strength * 0);
					case 3://法师
						%Text1 = mfloor(%Strength * 0);
						%Text2 = mfloor(%Strength * 0);
						%Text3 = mfloor(%Strength * 0);
						%Text4 = mfloor(%Strength * 0);
					case 4://道士
						%Text1 = mfloor(%Strength * 0);
						%Text2 = mfloor(%Strength * 0);
						%Text3 = mfloor(%Strength * 0);
						%Text4 = mfloor(%Strength * 0);
					case 5://弓手
						%Text1 = mfloor(%Strength * 0.67);
						%Text2 = mfloor(%Strength * 1.33);
						%Text3 = mfloor(%Strength * 0.39);
						%Text4 = mfloor(%Strength * 0);
				}
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>力量属性</t><b/><t>该属性会增加以下属性值：</t><b/><t>1、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>最小物理攻击 +" @ %Text1 @ "</t><b/><t>2、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>最大物理攻击 +" @ %Text2 @ "</t><b/><t>3、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>暴击 +" @ %Text3 @ "</t><b/><t>4、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>物理防御 +" @ %Text4 @ "</t></t>";

			case "KLPlayerInfo_Intellecttext"://智力

				%Intellect = GetPlayer().GetIntellect(); //获取对象智力值
				switch (%Player.GetClasses(0))
				{
					case 1://战士
						%Text1 = mfloor(%Intellect * 0);
						%Text2 = mfloor(%Intellect * 0);
						%Text3 = mfloor(%Intellect * 0);
						%Text4 = mfloor(%Intellect * 0);
					case 2://刺客
						%Text1 = mfloor(%Intellect * 0);
						%Text2 = mfloor(%Intellect * 0);
						%Text3 = mfloor(%Intellect * 0);
						%Text4 = mfloor(%Intellect * 0);
					case 3://法师
						%Text1 = mfloor(%Intellect * 0.67);
						%Text2 = mfloor(%Intellect * 1.33);
						%Text3 = mfloor(%Intellect * 0.39);
						%Text4 = mfloor(%Intellect * 0);
					case 4://奶妈
						%Text1 = mfloor(%Intellect * 0.67);
						%Text2 = mfloor(%Intellect * 1.33);
						%Text3 = mfloor(%Intellect * 0);
						%Text4 = mfloor(%Intellect * 0.52);
					case 5://弓手
						%Text1 = mfloor(%Intellect * 0);
						%Text2 = mfloor(%Intellect * 0);
						%Text3 = mfloor(%Intellect * 0);
						%Text4 = mfloor(%Intellect * 0);
				}

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>智力属性</t><b/><t>该属性会增加以下属性值：</t><b/><t>1、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>最小法术攻击 +" @ %Text1 @ "</t><b/><t>2、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>最大法术攻击 +" @ %Text2 @ "</t><b/><t>3、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>暴击伤害 +" @ %Text3 @ "</t><b/><t>4、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>法术防御 +" @ %Text4 @ "</t></t>";

			case "KLPlayerInfo_TLtext"://体力
				%Stamina = GetPlayer().getStamina();	//获取对象体质值
				switch (%Player.GetClasses(0))
				{
					case 1://战士
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
					case 2://刺客
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
					case 3://法师
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
					case 4://奶妈
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
					case 5://弓手
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
				}

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>体力属性</t><b/><t>该属性会增加以下属性值：</t><b/><t>1、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>生命值 +" @ %Text1 @ "</t><b/><t>2、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>生命恢复 +" @ %Text2 @ "</t></t>";

			case "KLPlayerInfo_JStext"://精神
				%Mana = GetPlayer().GetMana();	//获取对象法力值
				switch (%Player.GetClasses(0))
				{
					case 1://战士
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0);
						%Text4 = mfloor(%Mana * 0);
					case 2://刺客
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0);
						%Text4 = mfloor(%Mana * 0);
					case 3://法师
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0.54);
						%Text4 = mfloor(%Mana * 1.08);
					case 4://奶妈
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0.54);
						%Text4 = mfloor(%Mana * 1.08);
					case 5://弓手
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0);
						%Text4 = mfloor(%Mana * 0);
				}

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>精神属性</t><b/><t>该属性会增加以下属性值：</t><b/><t>1、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>法力上限 +" @ %Text1 @ "</t><b/><t>2、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>法力回复 +" @ %Text2 @ "</t><b/><t>3、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>最小法术攻击 +" @ %Text3 @ "</t><b/><t>4、</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>最大法术攻击 +" @ %Text4 @ "</t></t>";





			case "KLPlayerInfo_WLGJ"://物理攻击
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>物理攻击</t><b/><t>影响物理攻击造成的基础伤害</t></t>";

			case "KLPlayerInfo_FSGJ"://法术攻击
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>法术攻击</t><b/><t>影响法术攻击造成的基础伤害</t></t>";

			case "KLPlayerInfo_BJ"://暴击
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>暴击</t><b/><t>影响攻击中出现暴击的概率</t></t>";

			case "KLPlayerInfo_BJSH"://暴击伤害
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>暴击伤害</t><b/><t>出现暴击时造成伤害的比例</t></t>";

			case "KLPlayerInfo_HXYJ"://会心一击
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>会心一击</t><b/><t>影响攻击中出现会心一击的概率</t></t>";

			case "KLPlayerInfo_HXSH"://会心伤害
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>会心伤害</t><b/><t>出现会心一击时造成伤害的比例</t></t>";

			case "KLPlayerInfo_WLMZ"://物理命中
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>物理命中</t><b/><t>影响物理攻击成功命中目标的概率</t></t>";

			case "KLPlayerInfo_FSMZ"://法术命中
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>法术命中</t><b/><t>影响法术攻击成功命中目标的概率</t></t>";


			case "KLPlayerInfo_SHFJ"://附加伤害
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>附加伤害</t><b/><t>附加固定值伤害</t></t>";


			case "KLPlayerInfo_WSWLFY"://无视物理防御
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>无视物理防御</t><b/><t>攻击时抵消对方一部分物理防御</t></t>";

			case "KLPlayerInfo_WSFSFY"://无视法术防御
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>无视法术防御</t><b/><t>攻击时抵消对方一部分法术防御</t></t>";


			case "KLPlayerInfo_WLSHJS"://物理伤害加深
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>物理伤害加深</t><b/><t>影响物理攻击时增加伤害比例</t></t>";

			case "KLPlayerInfo_FSSHJS"://法术伤害加深
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>法术伤害加深</t><b/><t>影响法术攻击时增加伤害比例</t></t>";

			case "KLPlayerInfo_WLFY"://物理防御
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>物理防御</t><b/><t>受到物理攻击时抵消一部分伤害</t></t>";

			case "KLPlayerInfo_FSFY"://法术防御
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>法术防御</t><b/><t>受到法术攻击时抵消一部分伤害</t></t>";

			case "KLPlayerInfo_ZL"://治疗值
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>治疗值</t><b/><t>道士施展治疗技能时增加一定恢复量</t></t>";

			case "KLPlayerInfo_BJJM"://暴击减免
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>暴击减免</t><b/><t>降低受到暴击的概率</t></t>";

			case "KLPlayerInfo_BSJM"://暴击伤害减免
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>暴击伤害减免</t><b/><t>降低受到暴击时的伤害比例</t></t>";

			case "KLPlayerInfo_WLSB"://物理闪避
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>物理闪避</t><b/><t>影响受到物理攻击时闪避的概率</t></t>";

			case "KLPlayerInfo_FSSB"://法术闪避
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>法术闪避</t><b/><t>影响受到法术攻击时闪避的概率</t></t>";

			case "KLPlayerInfo_WGSHJM"://物攻伤害减免
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>物攻伤害减免</t><b/><t>受到物理技能攻击时降低伤害比例</t></t>";

			case "KLPlayerInfo_FGSHJMJM"://法攻伤害减免
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>法攻伤害减免</t><b/><t>受到法术技能攻击时降低伤害比例</t></t>";

			case "KLPlayerInfo_SHJM"://伤害减免
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>伤害减免</t><b/><t>减免固定值伤害</t></t>";

			case "KLPlayerInfo_HXSHJM"://会心伤害减免
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>会心伤害减免</t><b/><t>降低受到会心一击时的伤害比例</t></t>";

			case "KLPlayerInfo_HXYJFY"://会心一击防御
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>会心一击防御</t><b/><t>降低受到会心一击的概率</t></t>";

			case "KLPlayerInfo_XY"://幸运值
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>幸运值</t><b/><t>增加攻击时随机出高攻击的概率</t></t>";

			case "KLPlayerInfo_YDSD"://移动速度
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>移动速度</t><b/><t>影响非坐骑状态时移动速度</t></t>";

			case "KLPlayerInfo_ZQYDSD"://坐骑移动速度
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>坐骑移动速度</t><b/><t>影响坐骑状态时移动速度</t></t>";

			case "KLPlayerInfo_SMZDHF"://生命自动恢复
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>生命自动恢复</t><b/><t>每3秒自动恢复的生命值</t></t>";

			case "KLPlayerInfo_FLZDHF"://法力自动恢复
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>法力自动恢复</t><b/><t>每3秒自动恢复的法力值</t></t>";

			case "KLPlayerInfo_GJSD"://攻击速度
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>攻击速度</t><b/><t>影响攻击时速度</t></t>";

			case "KLPlayerInfo_SFSD"://施法速度
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>施法速度</t><b/><t>影响攻击时速度</t></t>";

			case "KLPlayerInfo_XYQH"://眩晕强化
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>眩晕强化</t><b/><t>技能攻击时增加眩晕目标的成功率</t></t>";

			case "KLPlayerInfo_HSQH"://昏睡强化
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>昏睡强化</t><b/><t>技能攻击时增加昏睡目标的成功率</t></t>";

			case "KLPlayerInfo_CMQH"://沉默强化
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>沉默强化</t><b/><t>技能攻击时增加沉默目标的成功率</t></t>";

			case "KLPlayerInfo_XYKX"://眩晕抗性
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>眩晕抗性</t><b/><t>受到眩晕技能攻击时降低被眩晕的概率</t></t>";

			case "KLPlayerInfo_HSKX"://昏睡抗性
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>昏睡抗性</t><b/><t>受到昏睡技能攻击时降低被眩晕的概率</t></t>";

			case "KLPlayerInfo_CMKX"://沉默抗性
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>沉默抗性</t><b/><t>受到沉默技能攻击时降低被眩晕的概率</t></t>";




				//生活技能学习介绍

			case "LifeSkillStudyWndButtom_00"://武器+铸造
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' h='1' n='16' c='0xf3d300ff' o='0x010101ff'>采矿技能+铸造技能</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>采矿技能：</t><t>是一项基础技能，可在</t><t gct='0xff65feff' gcb='0xff65feff'>望仙谷、苍山雪海、陨仙窟、玄冰迷窟</t><t>等野外、地宫寻找到矿脉，采矿可以产出：</t><t gct='0xff65feff' gcb='0xff65feff'>铜矿、铁矿、银矿、金矿</t><t>等.</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>铸造技能：</t><t>是一个可以铸造出武器的生活技能，铸造的武器包含了</t><t gct='0xff65feff' gcb='0xff65feff'>40-100级的紫色、橙色武器，</t><t>铸造武器所需要的图纸和材料可以从怪物身上掉落，但是其中的矿石材料需要采矿产出.</t><b/><t gct='0xf3d300ff' gcb='0xf3d300ff'>采矿产出的矿石是铸造武器必不可少的材料，这两个技能是非常好的一种搭配组合</t></t>";

			case "LifeSkillStudyWndButtom_10"://采药+炼丹
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' h='1' n='16' c='0xf3d300ff' o='0x010101ff'>采药技能+炼丹技能</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>采药技能：</t><t>是一项基础技能，可在</t><t gct='0xff65feff' gcb='0xff65feff'>望仙谷、云梦泽</t><t>等野外找到草药，然后可以将草药带到</t><t gct='0xff65feff' gcb='0xff65feff'>炼丹炉</t><t>处炼制丹药或者卖给商店换取金钱.</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>炼丹技能：</t><t>是一个可以炼制药品的生活技能，可以炼制</t><t gct='0xff65feff' gcb='0xff65feff'>恢复类、状态类、特殊类以及施法材料</t><t>等丹药.</t><b/><t gct='0xf3d300ff' gcb='0xf3d300ff'>药材最大的用处就是拿去炼制丹药，采药+炼丹这两个技能搭配的也算是完美了</t></t>";

			case "LifeSkillStudyWndButtom_20"://伐木+制器
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' h='1' n='16' c='0xf3d300ff' o='0x010101ff'>伐木技能+制器技能</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>伐木技能：</t><t>是一项基础技能，可在</t><t gct='0xff65feff' gcb='0xff65feff'>望仙谷、苍山雪海、云梦泽</t><t>等野外地图中寻找到木材，可将木材制作成</t><t gct='0xff65feff' gcb='0xff65feff'>符纸、饰品类装备</t><t>等其他物品.</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>制器技能：</t><t>是一个可以制作出饰品类的装备，饰品类包含了</t><t gct='0xff65feff' gcb='0xff65feff'>护符、项链、戒指</t><t>，是获取优良装备的必学技能.</t><b/><t gct='0xf3d300ff' gcb='0xf3d300ff'>伐木技能虽然可以搭配多种其他技能，但是如果想提升装备品质，这两个组合也是个不错的选择</t></t>";

			case "LifeSkillStudyWndButtom_01"://钓鱼+烹饪
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' h='1' n='16' c='0xf3d300ff' o='0x010101ff'>钓鱼技能+烹饪技能</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>钓鱼技能：</t><t>是一项基础技能，可在</t><t gct='0xff65feff' gcb='0xff65feff'>望仙谷、云梦泽</t><t>等野外地图找到鱼群，钓到的鱼类可以拿去</t><t gct='0xff65feff' gcb='0xff65feff'>烹饪鼎或NPC商店</t><t>处制作食物或者换取金币.</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>烹饪技能：</t><t>是一个可以烹饪出美味食物的技能，烹饪技能可以制作</t><t gct='0xff65feff' gcb='0xff65feff'>恢复类、状态类、特殊类以及施法材料</t><t>的食物，从此成为食神不再是梦想.</t><b/><t gct='0xf3d300ff' gcb='0xf3d300ff'>新鲜的鱼类搭配厨娘的厨艺，美味的食物就是这样诞生的，这两个技能的搭配学习简直绝配</t></t>";

			case "LifeSkillStudyWndButtom_11"://伐木+符咒
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' h='1' n='16' c='0xf3d300ff' o='0x010101ff'>伐木技能+符咒技能</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>伐木技能：</t><t>是一项基础技能，可在</t><t gct='0xff65feff' gcb='0xff65feff'>望仙谷、苍山雪海、云梦泽</t><t>等野外地图中寻找到木材，可将木材制作成</t><t gct='0xff65feff' gcb='0xff65feff'>符纸、饰品类装备</t><t>等其他物品.</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>符咒技能：</t><t>是一个可以制作出各类符咒，符咒包含了</t><t gct='0xff65feff' gcb='0xff65feff'>鉴宝符、鉴定符、战斗符以及施法材料</t><t>，这些符咒提供了很好的辅助作用，大大的提升了游戏的乐趣.</t><b/><t gct='0xf3d300ff' gcb='0xf3d300ff'>伐木技能虽然可以搭配多种其他技能，如果您想制作辅助类的符咒，选择这两个组合也是很完美的</t></t>";


			case "LifeSkillStudyWndButtom_21"://裁缝
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' h='1' n='16' c='0xf3d300ff' o='0x010101ff'>裁缝</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>裁缝技能：</t><t>是一项基础生活技能，但是制作的物品种类最多，包括了</t><t gct='0xff65feff' gcb='0xff65feff'>头盔、衣服、背部、肩部、手部、腰部、脚部</t><t>七大防具类装备，还可以制作乾坤袋.但是制作这些物品所用的材料基本上都需要</t><t gct='0xff65feff' gcb='0xff65feff'>怪物掉落</t><t>这也是这个生活技能的独特之处.</t><b/><t gct='0xf3d300ff' gcb='0xf3d300ff'>这个生活技能比较特殊，可能不需要其他技能的搭配学习，但是材料获取上难度也稍微增大了一点，如果想提升装备品质等级，这个技能也是必备技能之一</t></t>";

				
			case "KLJAttackCityWndGui_Tips"://攻城战规则介绍
				%ctrl.tooltipWidth = 420;
				%ctrl.tooltip =
					"<t m='1' f='宋体' n='12'><t m='0' f='黑体' h='1' n='16' c='0xf3d300ff' o='0x010101ff'>攻城战申请规则</t><b/>" @ 
					"<t gct='0x00ff00ff' gcb='0x2cffeeff'>申请规则：</t><b/>" @ 
					"<t>1、由帮派帮主发起申请，可以自由选择</t>" @ "<t gct='0xff1200ff' gcb='0xff3c00ff'>7天内</t><t>的任意一天竞价（不能同时竞价多天的攻城）。</t><b/>" @ 
					"<t>2、</t>" @ "<t gct='0xff1200ff' gcb='0xff3c00ff'>2级及以上帮派</t>" @ "<t>才有申请资格，占领帮派不得参与申请。</t><b/>" @ 
					"<t>3、帮主上缴</t>" @ "<t gct='0xff1200ff' gcb='0xff3c00ff'>雕像印章1枚、金条10根</t>" @ "<t>获得竞价资格，帮主可通过追加金条来竞价。</t><b/>" @ 
					"<t>4、竞价在攻城前一天的</t><t gct='0xff1200ff' gcb='0xff3c00ff'>晚上20：00</t><t>结算，价高者获得次日的攻城资格。</t><b/>" @
					"<t>5、竞价失败的，雕像印章不予返还，竞价消耗的金条，系统</t><t gct='0xff1200ff' gcb='0xff3c00ff'>扣除10根</t><t>，剩余的以邮件的形式返还。</t><b/>" @
					"<t>6、竞价成功的帮主，以邮件形式通知该帮主获得XXXX年XX月XX日攻城资格</t><b/>" @
					"<t gct='0x00ff00ff' gcb='0x2cffeeff'>占领帮派奖励：</t><b/>" @ 
					"<t>1、昆仑城设立帮主的雕像:</t><t gct='0xff65feff' gcb='0xff65feff'>城主雕像</t><b/>" @
					"<t>2、不同级别的帮派成员可获得对应的称号奖励。</t><b/>" @ 
					"<t>3、占领帮派在封魔城内的中立NPC进行商店消费时，</t><t gct='0xff65feff' gcb='0xff65feff'>享8折优惠</t><t>（仅限通用类的金币商店）。</t></t>";


			case "RuleDescribe_btn"://全民夺宝规则介绍
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip =
					"<t m='1' f='宋体' n='12'><t m='0' f='黑体' h='1' n='16' c='0xf3d300ff' o='0x010101ff'>全民夺宝规则介绍</t><b/>" @
					"<t gct='0x00ff00ff' gcb='0x2cffeeff'>购买规则：</t><b/>" @
					"<t>1、可以在进行中的夺宝场次中购买商品</t><b/>" @
					"<t>2、购买一份商品需要消耗一份</t>" @ "<t gct='0xff65feff' gcb='0xff65feff'>夺宝符</t>" @ "<b/>" @
					"<t>3、只能购买一份宝贝最多一半的商品份数</t><b/>" @
					"<t>4、您可以在我的夺宝中查看进行中的宝贝信息</t><b/>" @
					"<t gct='0x00ff00ff' gcb='0x2cffeeff'>开奖规则：</t><b/>" @
					"<t>1、本场次结束时间已到，系统将会进行开奖结算</t><b/>" @
					"<t>2、某一件宝贝的商品份数全部售罄，该宝贝将会提前开奖结算</t><b/>" @
					"<t>3、您购买的份数除以宝贝的出售总份数，就是您获奖的几率</t><b/>" @
					"<t>4、您可以在我的夺宝中查看已开奖的信息</t><b/>";
				//系统按钮  
			case "OpenPlayerInfoButtom":

				if ($CurSelectModeId == 0){ %KJJ ="（C）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+C）"; }
				else if ($CurSelectModeId == 2){ %KJJ ="（C）"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭角色属性界面") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭角色属性界面") @ "）";
				}

				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>角色属性 "@ %KJJ @"</t><b/><t>记录当前角色装备、坐骑、称号、时装、战斗属性等角色信息</t></t>";

			case "ItemBagButton":

				if ($CurSelectModeId == 0){ %KJJ ="（B）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+B）"; }
				else if ($CurSelectModeId == 2){ %KJJ ="（B）"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭背包界面") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭背包界面") @ "）";
				}

				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>背包 "@ %KJJ @"</t><b/><t>记录当前角色携带的物品信息,点击</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>「摆摊」</t><t>按钮可打开摊位信息</t></t>";

				//case "OpenPetInfoButtom":
				//
				//	if($CurSelectModeId == 0){%KJJ1 ="（X）";}
				//	else if($CurSelectModeId == 1){%KJJ1 ="（Alt+X）";}
				//	else if($CurSelectModeId == 2){%KJJ1 ="（X）";}
				//	else if($CurSelectModeId == 3)
				//			{
				//			if(GetHotKey("打开/关闭侍卫界面") !$= "")
				//				%KJJ1 = "（" @ GetHotKey("打开/关闭侍卫界面") @ "）";
				//
				//			}
				//
				//	%ctrl.tooltipWidth = 200;
				//	%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫 "@ %KJJ1 @"</t><b/><t>角色第一次成功轮回后即可获得第一个侍卫</t></t>";

				//	case "OpenTroopInfoButtom":
				//
				//		if($CurSelectModeId == 0){%KJJ ="（T）";}
				//		else if($CurSelectModeId == 1){%KJJ ="（Alt+T）";}
				//		else if($CurSelectModeId == 2){%KJJ ="（T）";}
				//		else if($CurSelectModeId == 3)
				//			{
				//				if(GetHotKey("打开/关闭队伍界面") !$= "")
				//					%KJJ = "（" @ GetHotKey("打开/关闭队伍界面") @ "）";
				//			}
				//
				//		%ctrl.tooltipWidth = 180;
				//		%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>队伍 "@ %KJJ @"</t><b/><t>记录当前角色队伍的信息,可查询附近玩家的信息</t></t>";

			case "OpenSkillInfoButtom":

				if ($CurSelectModeId == 0){ %KJJ ="（K）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+K）"; }
				else if ($CurSelectModeId == 2){ %KJJ ="（K）"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭战斗技能界面") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭战斗技能界面") @ "）";
				}

				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>技能 "@ %KJJ @"</t><b/><t>记录当前角色领悟的战斗技能和生活技能信息</t></t>";

			case "OpenMissionInfoButtom":

				if ($CurSelectModeId == 0){ %KJJ ="（Q）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+Q）"; }
				else if ($CurSelectModeId == 2){ %KJJ ="（Q）"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭任务界面") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭任务界面") @ "）";
				}

				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>任务 "@ %KJJ @"</t><b/><t>记录当前角色已接任务和可接任务的信息</t></t>";

			case "OpenFriendInfoButtom":

				if ($CurSelectModeId == 0){ %KJJ ="（F）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+F）"; }
				else if ($CurSelectModeId == 2){ %KJJ ="（F）"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭社会关系界面") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭社会关系界面") @ "）";
				}

				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>社会关系 "@ %KJJ @"</t><b/><t>记录当前角色好友、队伍、对手、黑名单等信息</t></t>";

				//		case "OpenHonorInfoButtom":

				//			if($CurSelectModeId == 0){%KJJ ="（K）";}
				//			else if($CurSelectModeId == 1){%KJJ ="（Alt+K）";}
				//			else if($CurSelectModeId == 2){%KJJ ="（K）";}
				//			else if($CurSelectModeId == 3)
				//				{
				//					if(GetHotKey("打开/关闭荣誉界面") !$= "")
				//						%KJJ = "（" @ GetHotKey("打开/关闭荣誉界面") @ "）";
				//				}

				//		%ctrl.tooltipWidth = 210;
				//		%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>竞技场</t><b/><t>记录角色在竞技场和战场中的信息</t><b/><t c='0x00ff00ff'>功能暂未开放，敬请期待</t>";

				//case "PuddlerInfoButtom":
				//
				//		if($CurSelectModeId == 0){%KJJ ="（U）";}
				//		else if($CurSelectModeId == 1){%KJJ ="（Alt+U）";}
				//		else if($CurSelectModeId == 2){%KJJ ="";}
				//		else if($CurSelectModeId == 3)
				//			{
				//				if(GetHotKey("打开/关闭炼器界面") !$= "")
				//					%KJJ = "（" @ GetHotKey("打开/关闭炼器界面") @ "）";
				//			}
				//
				//		%ctrl.tooltipWidth = 220;
				//		%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>炼器 "@ %KJJ @"</t><b/><t>天地间的四大灵物：归元鼎、炼元炉、本命灵珠、天珠镶嵌</t></t>";


			case "FuDiInfoButtom":

				if ($CurSelectModeId == 0){ %KJJ ="（G）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+G）"; }
				else if ($CurSelectModeId == 2){ %KJJ ="（G）"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭、") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭帮派界面") @ "）";
				}

				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>帮派 "@ %KJJ @"</t><b/><t>记录当前角色帮派的信息</t></t>";

			case "OpenKLJSystemButton":

				if ($CurSelectModeId == 0){ %KJJ ="（O）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+O）"; }
				else if ($CurSelectModeId == 2){ %KJJ ="（O）"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭系统设置界面") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭系统设置界面") @ "）";
				}

				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>系统 "@ %KJJ @"</t><b/><t>切换角色功能</t><b/><t>退出游戏功能</t><b/><t>记录游戏本地的系统和游戏设置信息</t></t>";

			case "BirdShopWndBtn":
				if ($CurSelectModeId == 0){ %KJJ ="（V）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+V）"; }
				else if ($CurSelectModeId == 2){ %KJJ ="（V）"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭元宝商城") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭元宝商城") @ "）";
				}

				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元宝商城 "@ %KJJ @"</t><b/><t>可使用元宝在此购买各种常用物品和道具</t></t>";
			case "BirdSuiTangButton1":
				if ($CurSelectModeId == 0){ %KJJ ="（Y）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+Y）"; }
				else if ($CurSelectModeId == 2){ %KJJ ="（Y）"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭活动大全界面") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭活动大全界面") @ "）";
				}

				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>活动大全 "@ %KJJ @"</t><b/><t>可在此查看所有的日常活动信息</t></t>";
			case "BirdPrefButton":
				if (GetHotKey("打开/关闭随机商店") !$= "")
					%KJJ = "（" @ GetHotKey("打开/关闭随机商店") @ "）";
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>随机商店 "@ %KJJ @"</t><b/><t>可在此购买各种打折优惠的物品和道具</t><b/><t>每日0、6、12、18点系统自动刷新更换商品列表</t></t>";
			case "CornucopiaWndBtn":
				if (GetHotKey("打开/关闭聚宝盆") !$= "")
					%KJJ = "（" @ GetHotKey("打开/关闭聚宝盆") @ "）";
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>聚宝盆 "@ %KJJ @"</t><b/><t>可在此获得大量金币</t></t>";
			case "BirdTranferWndBtn":
				if (GetHotKey("打开/关闭视角选择") !$= "")
					%KJJ = "（" @ GetHotKey("打开/关闭视角选择") @ "）";
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>视角选择 "@ %KJJ @"</t><b/><t>可在此切换角色视角</t></t>";
			case "ChargeWndBtnA":
				if (GetHotKey("打开/关闭充值界面") !$= "")
					%KJJ = "（" @ GetHotKey("打开/关闭充值界面") @ "）";
				%ctrl.tooltipWidth = 180;

				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>充值界面 "@ %KJJ @"</t><b/><t>可在此充值元宝、提取元宝、领取充值礼包</t></t>";
				//%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' gct='0xffff00ff' gcb='0xd9680dff'>充值界面 "@ %KJJ @"</t><b/><t>可在此充值元宝、提取元宝、领取充值礼包</t></t>";
			case "LingMaiWndBtn":
				if (GetHotKey("打开/关闭灵脉指引") !$= "")
					%KJJ = "（" @ GetHotKey("打开/关闭灵脉指引") @ "）";
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>灵脉指引 "@ %KJJ @"</t><b/><t>可在此前往昆仑灵脉，挖取灵脉可获得珍稀道具</t></t>";
			case "StrategyWndBtn":
				if (GetHotKey("打开/关闭灵脉指引") !$= "")
					%KJJ = "（" @ GetHotKey("打开/关闭灵脉指引") @ "）";
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>攻略指引 "@ %KJJ @"</t><b/><t>可在此查看所有游戏攻略和指引帮助，同时增长阅历以及获得阅历奖励</t></t>";
			case "LingJiangWndBtn":
				if (GetHotKey("打开/关闭领奖界面") !$= "")
					%KJJ = "（" @ GetHotKey("打开/关闭领奖界面") @ "）";
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>领奖界面 "@ %KJJ @"</t><b/><t>可在此领取新手七天好礼、等级礼包、媒体礼包</t><b/><t>可在此进行每日签到</t><b/><t>可在此查看日活跃完成状况</t></t>";

				//==============================================================================================主界面系统功能按钮热感================================================================
				/* 写一半没写完
				case "OpenPlayerInfoButtom":	//角色信息
				%ctrl.tooltipWidth = 90;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>角色（C）</t></t>";

				case "OpenPlayerInfoButtom":	//任务信息
				%ctrl.tooltipWidth = 90;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>任务（Q）</t></t>";

				case "BottomControlWndGui3_1":	//化神信息
				%ctrl.tooltipWidth = 90;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神（P）</t></t>";

				case "BottomControlWndGui3_2":	//武魂
				%ctrl.tooltipWidth = 90;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>武魂</t></t>";

				case "BottomControlWndGui3_3":	//衣橱
				%ctrl.tooltipWidth = 90;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>衣橱</t></t>";

				case "OpenPlayerInfoButtom":	//任务信息
				%ctrl.tooltipWidth = 90;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>任务信息（Q）</t></t>";

				case "OpenPlayerInfoButtom":	//任务信息
				%ctrl.tooltipWidth = 90;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>任务信息（Q）</t></t>";

				case "OpenPlayerInfoButtom":	//任务信息
				%ctrl.tooltipWidth = 120;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>任务信息（Q）</t></t>";

				case "OpenPlayerInfoButtom":	//任务信息
				%ctrl.tooltipWidth = 120;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>任务信息（Q）</t></t>";







				*/
				//==============================================================================================小地图区域按钮================================================================

				//=========================小地图模式====================================

			case "BirdUniqueButton"://特色玩法
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>特色玩法</t><b/><t>点击可查看昆仑决的特色玩法内容</t></t>";


			case "GrowAssistantTurnOnBnt1"://百晓生
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>百晓生</t><b/><t>点击可查看昆仑决的各个功能指引</t></t>";


			case "BirdBigMapButton"://地图

				if ($CurSelectModeId == 0){ %KJJ1 ="（M）"; }
				else if ($CurSelectModeId == 1){ %KJJ1 ="（Alt+M）"; }
				else if ($CurSelectModeId == 2){ %KJJ1 =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭区域地图") !$= "")
						%KJJ1 = "（" @ GetHotKey("打开/关闭区域地图") @ "）";
				}

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>区域地图 "@ %KJJ1@"</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>重要区域寻径：</t><t>在区域地图右侧有当前地图内重要的寻径列表,鼠标单击,角色自动前往指定的地点</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>小地图点击：</t><t>左键单击小地图任意可寻径的位置,角色自动前往指定的地点</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>区域地图点击：</t><t>左键单击区域地图上任意可寻径的位置,角色自动前往指定的地点</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>坐标寻径：</t><t>在区域地图上的坐标寻径功能内输入可以寻径的坐标,角色自动前往指定的地点</t></t>";


			case "BirdShopButton":
				if ($CurSelectModeId == 0){ %KJJ ="（V）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+V）"; }
				else if ($CurSelectModeId == 2){ %KJJ ="（V）"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭拍卖行") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭拍卖行") @ "）";
				}
				%ctrl.tooltipWidth = 205;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>拍卖行</t><b/><t>在拍卖行中可参与竞拍，同时还能寄售装备等道具</t></t>";


			case "BirdLetterButton"://邮件

				if ($CurSelectModeId == 0){ %KJJ ="（J）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+J）"; }
				else if ($CurSelectModeId == 2){ %KJJ =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭邮件界面") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭邮件界面") @ "）";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>邮件 "@ %KJJ @"</t><b/><t>用于对好友的书信、物品的发送和接收</t></t>";


			case "BirdSuiTangButton"://活动大全

				if ($CurSelectModeId == 0){ %KJJ ="（Y）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+Y）"; }
				else if ($CurSelectModeId == 2){ %KJJ =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭活动大全") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭活动大全") @ "）";
				}

				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>活动大全 "@ %KJJ @"</t><b/><t>记录昆仑决所有可参加的活动信息</t></t>";

			case "BirdLockButton"://安全锁

				if ($CurSelectModeId == 0){ %KJJ =""; }
				else if ($CurSelectModeId == 1){ %KJJ =""; }
				else if ($CurSelectModeId == 2){ %KJJ =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭安全设置") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭安全设置") @ "）";
				}

				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>安全设置 "@ %KJJ @"</t><b/><t>设置二级密码可对游戏进行安全锁设置,可以确保您的财产安全,可对物品、神兽、骑宠、化神进行单独加锁</t></t>";


			case "BirdGradeButton"://排行榜

				if ($CurSelectModeId == 0){ %KJJ ="（B）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+B）"; }
				else if ($CurSelectModeId == 2){ %KJJ =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭排行榜界面") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭排行榜界面") @ "）";
				}
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>排行榜</t><b/><t>记录昆仑决中荣登排行榜的玩家信息</t></t>";


			case "BirdTuiMapButton"://推广
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>推广</t><b/><t>通过邀请好友加入游戏，即可获得高额奖励</t></t>";

			case "BirdPresentButton"://媒体礼包
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>礼包</t><b/><t>可通过官网、合作媒体等获得的序列号在此兑换各式礼包</t></t>";

			case "BirdFuMapButton"://福利礼包
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>福利领取</t><b/><t>当您达到一定条件后即可在此领取福利</t></t>";

			case "BirdViewAngleButton"://视角选择
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>视角选择</t><b/><t>2.5D、2.9D、3D模式任你选择</t></t>";

			case "BirdKuaFuButton"://跨线
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>免费跨服</t><b/><t>可让您结交更多的朋友和挑战更高的对手</t></t>";

			case "BirdZhuanMapButton"://财神转转转
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>财神转转转</t><b/><t>每日都可免费在此获得抽取大奖的机会，千万不要错过</t></t>";

			case "BirdButtonNorthButton"://地图指北
				%ctrl.tooltipWidth = 140;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>视角恢复默认方向</t></t>";
			case "BirdMapName"://地图名称
				%ctrl.tooltipWidth = 380;
				%ctrl.tooltip =
					"<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>地图危险说明</t><b/>" @
					"<t c='0xffffffff'>安全-无法攻击其他玩家，也无法被其他玩家攻击。</t><b/>" @
					"<t c='0xffffffff'>普通-有可能被恶意攻击，需小心谨慎。死亡后几率掉落装备、道具。</t><b/>" @
					"<t c='0xffffffff'>危险-此地图可任意攻击，极度危险。死亡后几率掉落装备、道具。</t><b/>" @
					"<t c='0xffffffff'>副本-副本内死亡不掉落任何装备、道具。</t><b/>" @
					"<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>地图颜色说明</t><b/>" @
					"<t c='0x46ff15ff'>绿色-地图为中立地图,不能攻击玩家</t><b/>" @
					"<t c='0xffff00ff'>黄色-地图为混战地图,可以攻击玩家  </t><b/>" @
					"<t c='0xff1200ff'>红色-地图为善恶地图,可以攻击玩家,不会增加善恶值</t></t>";
			case "BirdViewBitMap_point":
				%ctrl.tooltipWidth = 80;
				%Text = $NowPingValue @ "ms";
				%ctrl.tooltip ="<t m='0' f='黑体' h='1' v='1' n='14'><t c='0xffffffff'>" @ %Text @ "</t></t>";
				//=========================大按钮模式=====================================
			case "BirdButtonUniqueButton"://特色玩法
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>特色玩法</t><b/><t>点击可查看昆仑决的特色玩法内容</t></t>";


			case "BirdGrowAssistantTurnOnBnt"://百晓生
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>百晓生</t><b/><t>点击可查看昆仑决的各个功能指引</t></t>";


			case "BirdButtonSuiTangButton"://活动大全

				if ($CurSelectModeId == 0){ %KJJ ="（Y）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+Y）"; }
				else if ($CurSelectModeId == 2){ %KJJ =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭活动大全") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭活动大全") @ "）";
				}

				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>活动大全 "@ %KJJ @"</t><b/><t>记录昆仑决所有可参加的活动信息</t></t>";


			case "BirdButtonBigMapButton"://大地图

				if ($CurSelectModeId == 0){ %KJJ1 ="（M）"; }
				else if ($CurSelectModeId == 1){ %KJJ1 ="（Alt+M）"; }
				else if ($CurSelectModeId == 2){ %KJJ1 =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭区域地图") !$= "")
						%KJJ1 = "（" @ GetHotKey("打开/关闭区域地图") @ "）";
				}

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>区域地图 "@ %KJJ1@"</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>重要区域寻径：</t><t>在区域地图右侧有当前地图内重要的寻径列表,鼠标单击,角色自动前往指定的地点</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>小地图点击：</t><t>左键单击小地图任意可寻径的位置,角色自动前往指定的地点</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>区域地图点击：</t><t>左键单击区域地图上任意可寻径的位置,角色自动前往指定的地点</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>坐标寻径：</t><t>在区域地图上的坐标寻径功能内输入可以寻径的坐标,角色自动前往指定的地点</t></t>";
			case "BirdViewWordMapButton"://地图
				if ($CurSelectModeId == 0){ %KJJ ="（M）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+M）"; }
				else if ($CurSelectModeId == 2){ %KJJ =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭大地图") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭大地图") @ "）";
				}

				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>地图 "@ %KJJ @"</t><b/><t>显示当前地图信息</t></t>";
			case "BirdButtonMapName"://地图名称
				%ctrl.tooltipWidth = 315;
				%ctrl.tooltip =
					"<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>地图危险说明</t><b/>" @
					"<t c='0xffffffff'>普通-死亡后不掉落任何物品</t><b/>" @
					"<t c='0xffffffff'>副本-死亡后不掉落任何物品</t><b/>" @
					"<t c='0xffffffff'>危险-死亡后有几率掉落道具、装备、金钱，善恶值越高，掉落几率越大</t><b/>" @
					"<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>地图颜色说明</t><b/>" @
					"<t c='0x46ff15ff'>绿色-地图为中立地图,不能进行攻击玩家K</t><b/>" @
					"<t c='0xffff00ff'>黄色-地图为混战地图,可以攻击玩家  </t><b/>" @
					"<t c='0xff1200ff'>红色-地图为善恶地图,可以攻击玩家,不会增加善恶值</t></t>";

			case "BirdButtonYouJianButton": //邮件
				if ($CurSelectModeId == 0){ %KJJ ="（J）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+J）"; }
				else if ($CurSelectModeId == 2){ %KJJ =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭邮件界面") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭邮件界面") @ "）";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>邮件 "@ %KJJ @"</t><b/><t>用于对好友的书信、物品的发送和接收</t></t>";


			case "BirdButtonLockButton"://安全锁

				if ($CurSelectModeId == 0){ %KJJ =""; }
				else if ($CurSelectModeId == 1){ %KJJ =""; }
				else if ($CurSelectModeId == 2){ %KJJ =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭安全设置") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭安全设置") @ "）";
				}

				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>安全设置 "@ %KJJ @"</t><b/><t>设置二级密码可对游戏进行安全锁设置,可以确保您的财产安全,可对物品、神兽、骑宠、化神进行单独加锁</t></t>";


			case "BirdButtonPaiButton"://排行榜

				if ($CurSelectModeId == 0){ %KJJ ="（B）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+B）"; }
				else if ($CurSelectModeId == 2){ %KJJ =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭排行榜界面") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭排行榜界面") @ "）";
				}
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>排行榜</t><b/><t>记录昆仑决中荣登排行榜的玩家信息</t></t>";




			case "BirdButtonshopButton"://拍卖行
				if ($CurSelectModeId == 0){ %KJJ ="（V）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+V）"; }
				else if ($CurSelectModeId == 2){ %KJJ ="（V）"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭拍卖行") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭拍卖行") @ "）";
				}
				%ctrl.tooltipWidth = 205;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>拍卖行</t><b/><t>在拍卖行中可参与竞拍，同时还能寄售装备等道具</t></t>";






			case "BirdHelpMapButton"://帮助按钮

				if ($CurSelectModeId == 0){ %KJJ ="（H）"; }
				else if ($CurSelectModeId == 1){ %KJJ ="（Alt+H）"; }
				else if ($CurSelectModeId == 2){ %KJJ ="（H）"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭帮助界面") !$= "")
						%KJJ = "（" @ GetHotKey("打开/关闭帮助界面") @ "）";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>游戏帮助"@ %KJJ @"</t><b/><t>对昆仑决各系统的说明,能让你更好的了解游戏</t></t>";


			case "BirdButtonTuiButton"://推广
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>推广</t><b/><t>通过邀请好友加入游戏，即可获得高额奖励</t></t>";

			case "BirdButtonPresentButton"://媒体礼包
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>礼包</t><b/><t>可通过官网、合作媒体等获得的序列号在此兑换各式礼包</t></t>";

			case "BirdButtonFuButton"://福利礼包
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>福利领取</t><b/><t>当您达到一定条件后即可在此领取福利</t></t>";

			case "BirdButtonAngleButton"://视角选择
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>视角选择</t><b/><t>2.5D、2.9D、3D模式任你选择</t></t>";

			case "BirdButtonKuaFuButton"://跨线
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>免费跨服</t><b/><t>可让您结交更多的朋友和挑战更高的对手</t></t>";

			case "BirdButtonZhuanButton"://财神转转转
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>财神转转转</t><b/><t>每日都可免费在此获得抽取大奖的机会，千万不要错过</t></t>";



				//=======================================================================================主界面任务追踪部分=================================================================================
			case "ShowTraceTreeButtton_Change":
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>任务追踪</t><b/><t>帮您记录当前已接任务的完成情况,和当前可接任务的信息</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>单击[任务追踪]可展开和隐藏任务信息追踪面板</t></t>";

			case "ShowTraceTreeButtton_PartyChange":
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>活动追踪</t><b/><t>帮您记录当前进行中或即将进行的活动信息</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>单击[活动追踪]可展开或隐藏活动信息追踪面板</t></t>";

			case "ShowTraceTreeButtton_Setting":
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>任务追踪设置</t><b/><t>对任务追踪窗口的宽度、长度、透明度进行自定义设置</t></t>";

			case "ShowTraceTreeButtton_PartySetting":
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>活动追踪设置</t><b/><t>对活动追踪窗口的宽度、长度、透明度进行自定义设置</t></t>";

			case "ShowTraceTreeButtton_Close":
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>关闭任务追踪</t><b/><t>通过任务界面中任务追踪勾选按钮可以控制界面的打开和关闭状态</t></t>";

			case "ShowTraceTreeButtton_PartyClose":
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>关闭活动追踪</t><b/><t>通过活动大全界面中活动追踪勾选按钮可以控制界面的打开和关闭状态</t></t>";

			case "ShowTraceTreeButtton_Lock":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>窗口锁定状态</t><b/><t>任务追踪面板锁定状态不能被拖动操作</t><b/><t>要改变该窗口显示位置，单击按钮进入窗口解锁状态</t></t>";

			case "ShowTraceTreeButtton_Unlock":
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>窗口解锁状态</t><b/><t>鼠标左键可拖动任务追踪面板,但不能穿透窗口</t></t>";

			case "ShowTraceTreeButtton_Party_Lock":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>窗口锁定状态</t><b/><t>活动追踪面板锁定状态不能被拖动操作</t><b/><t>要改变该窗口显示位置，单击按钮进入窗口解锁状态</t></t>";

			case "ShowTraceTreeButtton_Party_Unlock":
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>窗口解锁状态</t><b/><t>鼠标左键可拖动活动追踪面板,但不能穿透窗口</t></t>";

			case "SencondPwdTipWnd_lock":	//安全锁

				%state = %player.getSecondPWDState();
				if (%state == 0){ %lockNews1 ="安全锁密码还未设置";%lockNews2 = "<b/><t c='0xF450CFff' >点击进入安全设置页面设置二级密码</t>"; }
				else if (%state == 2){ %lockNews1 ="安全锁解锁状态"; %lockNews2 = "<b/><t c='0xF450CFff' >点击按钮对安全锁加锁</t>"; }

				%ctrl.tooltipWidth = 290;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %lockNews1 @"</t><b/><t>每次角色上线后都处于安全锁定状态,此状态下无法进行交易、买卖、进阶装备等操作</t>"@ %lockNews2 @"</t>";

			case "SencondPwdTipWnd_Unlock":	//安全锁
				%ctrl.tooltipWidth = 290;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>安全锁定状态</t><b/><t>每次角色上线后都处于安全锁定状态,此状态下无法进行交易、买卖、进阶装备等操作</t><b/><t c='0x8f8f8eff' >*忘记密码在安全设置中可强行解除密码*</t><b/><t c='0x46ff15ff' >点击弹出输入二级密码对安全锁进行解锁</t></t>";

				/*case "PKCloseButton":	//和平按钮
				if(isFile("gameres/data/icon/help/PK1.png")){%PK1 = "<i s='gameres/data/icon/help/PK1.png' w='16' h='16'/>";}else{%PK1 = "";}
				if(isFile("gameres/data/icon/help/PK2.png")){%PK2 = "<i s='gameres/data/icon/help/PK2.png' w='16' h='16'/>";}else{%PK2 = "";}
				if(isFile("gameres/data/icon/help/PK3.png")){%PK3 = "<i s='gameres/data/icon/help/PK3.png' w='16' h='16'/>";}else{%PK3 = "";}
				if(isFile("gameres/data/icon/help/PK4.png")){%PK4 = "<i s='gameres/data/icon/help/PK4.png' w='16' h='16'/>";}else{%PK4 = "";}

				if(GetPkValue()>0)
				{
				%txt1 = "<b/><t>可找</t><t c='0x00ff00ff' >长安宁道奇</t><t>或</t><t c='0x00ff00ff'>监狱罚恶司</t><t>用师德减少善恶值</t>";
				%txt2 = "<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>死亡惩罚说明：</t><b/><t>0≤善恶值≤4  被怪物击败,装备会掉落10%耐久值</t><b/><t>   善恶值＞4  被怪物击败,装备会掉落20%耐久值</t>";
				%Width ="340";
				}
				else
				{
				%Width ="280";
				}
				%ctrl.tooltipWidth = %Width;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>和平模式</t><b/><t>当前模式无法攻击其他玩家,被善恶模式的玩家攻击可以合法的反击</t><b/><t gct='0xff1200ff' gcb='0xff3c00ff'>当前善恶值："@ GetPkValue() @"</t>"@ %txt1 @"<b/><t>头顶图标说明：</t><b/><t>   善恶值= 0  无图标显示</t><b/><t>0＜善恶值≤4  </t>"@ %PK1 @"<t>中立状态</t><b/><t>4＜善恶值≤6  </t>"@ %PK2 @"<t>恶人状态</t><b/><t>6＜善恶值≤9  </t>"@ %PK3 @"<t>公敌状态I</t><b/><t>   善恶值＞9  </t>"@ %PK4 @"<t>公敌状态II</t>"@ %txt2 @"<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击切换至善恶模式</t></t>";
				*/
				/*case "PKOpenButton":	//善恶按钮
				if(isFile("gameres/data/icon/help/PK1.png")){%PK1 = "<i s='gameres/data/icon/help/PK1.png' w='16' h='16'/>";}else{%PK1 = "";}
				if(isFile("gameres/data/icon/help/PK2.png")){%PK2 = "<i s='gameres/data/icon/help/PK2.png' w='16' h='16'/>";}else{%PK2 = "";}
				if(isFile("gameres/data/icon/help/PK3.png")){%PK3 = "<i s='gameres/data/icon/help/PK3.png' w='16' h='16'/>";}else{%PK3 = "";}
				if(isFile("gameres/data/icon/help/PK4.png")){%PK4 = "<i s='gameres/data/icon/help/PK4.png' w='16' h='16'/>";}else{%PK4 = "";}

				if(GetPkValue()>0)
				{
				%txt1 = "<b/><t>可在</t><t c='0x00ff00ff' >人物信息</t><t>的</t><t c='0x00ff00ff'>其他信息界面</t><t>中点击善恶值旁的清除按钮来减少善恶值</t>";
				%txt2 = "";
				%Width ="340";
				}
				else
				{
				%Width ="290";
				}

				%PKkaiguan1 = %player.getForceState();//势力状态
				%PKkaiguan2 = %player.getWarState();//宣战状态
				%PKkaiguan3 = %player.getPKState();//善恶状态

				if			(%PKkaiguan1 == 1){%PKtext1 = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>势力模式</t>";
				%moshishuoming1 = "<t>1、可在非和平区域内攻击敌对势力玩家,且击败敌势力对玩家不会增加善恶值</t><b/><t>2、击败与自身等级不超过15级的玩家可获得功勋值</t><b/><t gct='0xff1200ff' gcb='0xff3c00ff'>当前善恶值："@ GetPkValue() @"</t>";
				%moshishuoming = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>点击可选择切换PK模式</t><b/><t c='0x8f8f8eff'>*需在非战斗状态下持续5分钟才能切换至和平模式</t>";
				}

				else if(%PKkaiguan2 == 1){%PKtext1 = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>帮派模式</t><b/><t>可在非和平区域内攻击帮派宣战中的敌对玩家,且击败帮派宣战中的敌对玩家不会增加善恶值</t>";
				%moshishuoming1 = "<t gct='0xff1200ff' gcb='0xff3c00ff'>当前善恶值："@ GetPkValue() @"</t><b/><t>头顶图标说明：</t><b/><t>   善恶值= 0  无图标显示</t><b/><t>0＜善恶值≤4  </t>"@ %PK1 @"<t>中立状态</t><b/><t>4＜善恶值≤6  </t>"@ %PK2 @"<t>恶人状态</t><b/><t>6＜善恶值≤9  </t>"@ %PK3 @"<t>公敌状态I</t><b/><t>   善恶值＞9  </t>"@ %PK4 @"<t>公敌状态II</t>";
				%moshishuoming = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>点击可选择切换PK模式</t><b/><t c='0x8f8f8eff'>*需在非战斗状态下持续5分钟才能切换至和平模式</t>";
				}

				else if(%PKkaiguan3 == 1){%PKtext1 = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>善恶模式</t><b/><t>可在非和平区域内攻击任何玩家,且击败其他善恶模式的玩家不会增加善恶值</t>";
				%moshishuoming1 = "<t gct='0xff1200ff' gcb='0xff3c00ff'>当前善恶值："@ GetPkValue() @"</t><b/><t>头顶图标说明：</t><b/><t>   善恶值= 0  无图标显示</t><b/><t>0＜善恶值≤4  </t>"@ %PK1 @"<t>中立状态</t><b/><t>4＜善恶值≤6  </t>"@ %PK2 @"<t>恶人状态</t><b/><t>6＜善恶值≤9  </t>"@ %PK3 @"<t>公敌状态I</t><b/><t>   善恶值＞9  </t>"@ %PK4 @"<t>公敌状态II</t>";
				%moshishuoming = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>点击可选择切换PK模式</t><b/><t c='0x8f8f8eff'>*需在非战斗状态下持续5分钟才能切换至和平模式</t>";
				}

				else   {%PKtext1 = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>和平模式</t><b/><t>当前模式无法攻击其他玩家,被善恶模式的玩家攻击可以合法的反击</t>";
				%moshishuoming = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>点击可选择切换PK模式</t>";
				%moshishuoming1 = "<t gct='0xff1200ff' gcb='0xff3c00ff'>当前善恶值："@ GetPkValue() @"</t><b/><t>头顶图标说明：</t><b/><t>   善恶值= 0  无图标显示</t><b/><t>0＜善恶值≤4  </t>"@ %PK1 @"<t>中立状态</t><b/><t>4＜善恶值≤6  </t>"@ %PK2 @"<t>恶人状态</t><b/><t>6＜善恶值≤9  </t>"@ %PK3 @"<t>公敌状态I</t><b/><t>   善恶值＞9  </t>"@ %PK4 @"<t>公敌状态II</t>";
				}



				%ctrl.tooltipWidth = %Width;
				%ctrl.tooltip = ""@ %PKtext1 @"<b/>"@ %moshishuoming1 @""@ %txt2 @"<b/>"@ %moshishuoming @"";*/



			case "PKOpenButtonControl":	//pk模式开关
				if (isFile("gameres/data/icon/help/pk1.png")){ %pk1 = "<i s='gameres/data/icon/help/pk1.png' w='20' h='20'/>"; }
				else{ %pk1 = ""; }
				if (isFile("gameres/data/icon/help/pk2.png")){ %pk2 = "<i s='gameres/data/icon/help/pk2.png' w='20' h='20'/>"; }
				else{ %pk2 = ""; }
				if (isFile("gameres/data/icon/help/pk3.png")){ %pk3 = "<i s='gameres/data/icon/help/pk3.png' w='20' h='20'/>"; }
				else{ %pk3 = ""; }
				if (isFile("gameres/data/icon/help/pk4.png")){ %pk4 = "<i s='gameres/data/icon/help/pk4.png' w='20' h='20'/>"; }
				else{ %pk4 = ""; }
				if (isFile("gameres/data/icon/help/pk5.png")){ %pk5 = "<i s='gameres/data/icon/help/pk5.png' w='20' h='20'/>"; }
				else{ %pk5 = ""; }

				%ctrl.tooltipWidth = 290;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>战斗模式</t><b/><t>点击可对战斗模式进行任意切换,和平模式下不可攻击其他任何玩家;防卫模式下可对红名、黄名玩家攻击；全体模式下可攻击任何玩家</t><b/><t gct='0xff1200ff' gcb='0xff3c00ff'><t>当前善恶值："@ GetPkValue() @"</t><b/><t gct='0xffffffff' gcb='0xffffffff'><t>头顶图标说明：</t><b/><t> 0≤善恶值≤2      无图标显示</t><b/><t> 2＜善恶值≤5   </t>"@ %pk1 @"<t>中立状态</t><b/><t> 5＜善恶值≤10  </t>"@ %pk2 @"<t>恶人状态</t><b/><t>10＜善恶值≤20  </t>"@ %pk3 @"<t>公敌状态I</t><b/><t>20＜善恶值≤50  </t>"@ %pk4 @"<t>公敌状态II</t><b/><t>    善恶值＞50  </t>"@ %pk5 @"<t>公敌状态III</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'><t>提示:当玩家</t><t gct='0xff1200ff' gcb='0xff3c00ff'> 善恶值≥6 </t><t>时,使用回城卷会传送到牢房里去!</t></t>";



			case "PKModePopUpWnd_Check01":	//和平模式按钮
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>和平模式</t><b/><t>不可攻击任何其他玩家</t></t>";

			case "PKModePopUpWnd_Check02":	//防卫模式按钮
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>防卫模式</t><b/><t>不可攻击白名玩家，可对红名、黄名玩家攻击</t><b/><t>(队友、帮会成员不会受到伤害)</t></t>";

			case "PKModePopUpWnd_Check03":	//全体模式按钮
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>全体模式</t><b/><t>可攻击任何玩家</t><b/><t>(队友、帮会成员不会受到伤害)</t></t>";

			case "PlayerIconAssistantButton":	//战斗助手按钮
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>战斗助手(Z)</t><b/><t>可打开战斗助手界面,体验自动刷怪的乐趣</t></t>";

			case "PlayerIconMuteButton":	//控制音量按钮
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>静音模式</t><b/><t>点击可</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>开启/关闭</t><t>静音模式</t><b/><t>右键点击可</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>打开</t><t>音乐设置界面</t>";

			case "Captivate_Img":	//反沉迷图标
				%ctrl.tooltipWidth = 340;
				if ($Captivate_oldtype == 1){ %Captivate_hint="<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>处于疲劳状态  "@$time@"</t><b/><t>角色经验,金币,积分等游戏收益将减半，且无法获得道具收益。</t><b/><t c='0x46ff15ff' >只有当角色累计下线时间满5小时,才能清除该状态</t>"; }
				else if ($Captivate_oldtype == 2){ %Captivate_hint="<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>处于不健康状态  "@$time@"</t><b/><t>角色经验,生活技能经验,金币,声望,活力值,物品等游戏收益都将为零。</t><b/><t c='0x46ff15ff' >只有当角色累计下线时间满5小时,才能清除该状态</t>"; }

				%ctrl.tooltip ="<t m='1' f='宋体' n='12'>"@%Captivate_hint @"</t> ";



			case "StallWndGui_DealInfo":	//摆摊交易提示
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>              交易提示</t><b/><t>   本交易可能因为被盗申诉，或者其他原因被撤销</t><b/><t>   </t><b/><t>   除在游戏中用虚拟物品相互交易，</t><t gct='0xff1200ff' gcb='0xff3c00ff'>您绝不可以在游戏之外用现实货币或者现实物品，交换游戏内的虚拟物品（含游戏币）。</t><t>否则一旦本交易被撤销，交易对方只会返还您现在用于交易的虚拟物品，而不会返还您支出的现实货币或现实物品。您因此造成的损失，只能向交易方依法索赔，昆仑决官方不会对此承担任何责任。</t><b/><t></t><t gct='0xff1200ff' gcb='0xff3c00ff'>   玩家之间用现实货币/现实物品交换游戏内的虚拟物品是违规行为，此类交易不会得到昆仑决官方的保护。</t><t>详细规则请见《昆仑决通行证用户协议》《昆仑决游戏使用规则》以及昆仑决官方公布的其他有关规则。</t><b/><t> </t><b/><t><t gct='0xff1200ff' gcb='0xff3c00ff'>       本规则自2017年10月1日起正式生效</t></t>";
			case "StallSeeWndGui_DealInfo":
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>              交易提示</t><b/><t>   本交易可能因为被盗申诉，或者其他原因被撤销</t><b/><t>   </t><b/><t>   除在游戏中用虚拟物品相互交易，</t><t gct='0xff1200ff' gcb='0xff3c00ff'>您绝不可以在游戏之外用现实货币或者现实物品，交换游戏内的虚拟物品（含游戏币）。</t><t>否则一旦本交易被撤销，交易对方只会返还您现在用于交易的虚拟物品，而不会返还您支出的现实货币或现实物品。您因此造成的损失，只能向交易方依法索赔，昆仑决官方不会对此承担任何责任。</t><b/><t></t><t gct='0xff1200ff' gcb='0xff3c00ff'>   玩家之间用现实货币/现实物品交换游戏内的虚拟物品是违规行为，此类交易不会得到昆仑决官方的保护。</t><t>详细规则请见《昆仑决通行证用户协议》《昆仑决游戏使用规则》以及昆仑决官方公布的其他有关规则。</t><b/><t> </t><b/><t><t gct='0xff1200ff' gcb='0xff3c00ff'>       本规则自2017年10月1日起正式生效</t></t>";
			case "TradeHelpWndGui_DealInfo":	//交易提示
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>              交易提示</t><b/><t>   本交易可能因为被盗申诉，或者其他原因被撤销</t><b/><t>   </t><b/><t>   除在游戏中用虚拟物品相互交易，</t><t gct='0xff1200ff' gcb='0xff3c00ff'>您绝不可以在游戏之外用现实货币或者现实物品，交换游戏内的虚拟物品（含游戏币）。</t><t>否则一旦本交易被撤销，交易对方只会返还您现在用于交易的虚拟物品，而不会返还您支出的现实货币或现实物品。您因此造成的损失，只能向交易方依法索赔，昆仑决官方不会对此承担任何责任。</t><b/><t></t><t gct='0xff1200ff' gcb='0xff3c00ff'>   玩家之间用现实货币/现实物品交换游戏内的虚拟物品是违规行为，此类交易不会得到昆仑决官方的保护。</t><t>详细规则请见《昆仑决通行证用户协议》《昆仑决游戏使用规则》以及昆仑决官方公布的其他有关规则。</t><b/><t> </t><b/><t><t gct='0xff1200ff' gcb='0xff3c00ff'>       本规则自2017年10月1日起正式生效</t></t>";





			case "SoulUpgradeHintButton_Tips":	//化神升级提示按钮
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神天赋加点</t><b/><t>化神升级获得天赋点，可对化神天赋进行加点</t></t>";

			case "UpgradeHintButton_Tips":	//人物升级提示按钮
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>角色可升级</t><b/><t>点击按钮打开角色信息界面,再点击升级按钮可以升级</t></t>";

			case "PetUpgradeHintButton_Tips":	//神兽升级提示按钮
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽升级加点</t><b/><t>点击按钮打开神兽信息界面,对神兽进行潜力加点</t></t>";

			case "FriendChat_Btn":	//私聊缩小提示
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>与好友的私聊列表</t><b/><t>右键单击该图标将清空当前的私聊列表</t></t>";

			case "playeraskfor":	//个人消息盒提示
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>来自好友的信息</t></t>";

			case "SysMessageBox":	//系统消息盒提示
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>来自系统的信息</t></t>";

			case "Birdthree2p5to2p9Button"://2.5D
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前操作模式：2.5D</t><b/><t>该模式适合传统玩家，无需过多操作，简单游戏</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击选择2.9D或3D的操作模式</t></t>";

			case "Bird2p9to3Button"://2.9D
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前操作模式：2.9D</t><b/><t>该模式允许视角小幅度上下浮动，视野更开阔</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击选择2.5D或3D的操作模式</t></t>";

			case "Birdthree3to2p5Button"://3D
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前操作模式：3D</t><b/><t>全方位360度无死角，展示您拉风帅气的英姿</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击选择2.5D或2.9D的操作模式</t></t>";

			case "BirdButtonthree2p5to2p9Button"://2.5D
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前操作模式：2.5D</t><b/><t>该模式适合传统玩家，无需过多操作，简单游戏</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击选择2.9D或3D的操作模式</t></t>";

			case "BirdButton2p9to3Button"://2.9D
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前操作模式：2.9D</t><b/><t>该模式允许视角小幅度上下浮动，视野更开阔</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击选择2.5D或3D的操作模式</t></t>";

			case "BirdButtonthree3to2p5Button"://3D
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前操作模式：3D</t><b/><t>全方位360度无死角，展示您拉风帅气的英姿</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击选择2.5D或2.9D的操作模式</t></t>";





				//====================================================================================技能学习===========================================================================================================

			case "SkillStudyTxt_ComposeValue1"://当前职业熟练度
				%ctrl.tooltipWidth = 215;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前职业熟练度</t><b/><t>每次提升技能或学习新技能，角色的战斗力增加一点</t></t>";

			case "SkillWndSkillBitmap1"://技能熟练度
				%ctrl.tooltipWidth = 215;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前职业熟练度</t><b/><t>每次提升技能或学习新技能，角色的战斗力增加一点</t></t>";


				//============================================================================背包界面====================================================================================================
				//case "AllBag_AllItemButton"://显示全部 合包状态
				//	%ctrl.tooltipWidth = 110;
				//	%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>显示全部物品</t></t>";

			case "AllBag_PropButton"://显示道具(锦囊1)
				%ctrl.tooltipWidth = 120;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>锦囊1</t><b/><t>需要装备背包扩展道具开启</t></t>";

			case "AllBag_MissionButton"://显示任务物品
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>任务物品</t><b/><t>只显示任务相关物品</t></t>";

			case "AllBag_FashionButton"://显示时装物品
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>时装物品</t><b/><t>只显示时装相关物品</t></t>";

			case "AllBag_AllItemButton"://显示全部物品
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>全部物品</t><b/><t>显示背包里的全部物品</t></t>";

			case "AllBag_MaterialButton"://显示材料(锦囊2)
				%ctrl.tooltipWidth = 125;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>锦囊2</t><b/><t>需要装备背包扩展道具开启</t></t>";

			case "AllBag_ArrangeButton"://整理按钮
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>物品整理</t><b/><t m='1' f='宋体' n='12' gct='0x00ff00ff' gcb='0x2cffeeff'>点击按钮背包内物品按类型归类显示，可叠加物品将自动叠加显示</t></t>";

			case "AllBag_SplitItemButton"://拆分按钮
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>点击切换至拆分状态</t><b/><t m='1' f='宋体' n='12' gct='0x00ff00ff' gcb='0x2cffeeff'><t>再左键点击背包内待拆分的物品进行拆分</t></t>";

			case "AllBag_DestroyButton"://销毁按钮
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>点击切换至销毁状态</t><b/><t m='1' f='宋体' n='12' gct='0x00ff00ff' gcb='0x2cffeeff'><t>再左键点击背包内待销毁的物品进行销毁</t></t>";

			case "AllBag_DecomposeButton"://分解按钮
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>点击切换至分解状态</t><b/><t m='1' f='宋体' n='12' gct='0x00ff00ff' gcb='0x2cffeeff'><t>再左键点击背包内的装备或宝石进行分解</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>1、只能分解绿色或绿色品质以上装备，分解后可获得强化石</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>2、宝石分解可获得宝石碎片，宝石碎片可再次合成珍贵宝石</t></t>";

			case "AllBag_LockItemsButton"://加锁按钮
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>贵重物品锁定</t><b/><t m='1' f='宋体' n='12' gct='0x00ff00ff' gcb='0x2cffeeff'>点击按钮打开物品安全界面，可对背包内贵重物品进行加锁</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>物品锁定后将无法进行交易、分解，销毁等操作</t></t>";

			case "AllBagLingYuanGui": //绑定金
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>金币</t><b/><t>技能升级时需要消耗的货币，同时还能在随身商店购买商品</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>可通过完成各式任务和参加活动大全活动获得</t></t>";

			case "AllBagJingYuanGui": //交易金
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元宝</t><b/><t>拍卖行、摆摊交易时需要的货币，也可通过充值界面兑换成金币或者活跃积分</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>充值后的元宝需要提取到角色身上才可使用</t></t>";

			case "AllBagJiFengGui": //活跃积分
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>活跃积分</t><b/><t>提升装备、神兽等能力时需要消耗的积分，同时还能在随身商店购买商品</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>可通过完成各式任务和参加活动大全活动获得</t></t>";


			case "AllBag_RedundantBag1": //背包扩展栏
				//echo("===========================AllBag_RedundantBag1==="@AllBag_RedundantBagBackGround1.IsVisible());
				if (AllBag_RedundantBagBackGround1.IsVisible()){
					//echo("=============================="@AllBag_RedundantBagBackGround1.IsVisible());
					%ctrl.tooltipWidth = 240;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>扩展栏</t><b/><t>可通过装备乾坤袋增加背包容量</t></t>";
				}
				else{
					%ctrl.tooltipWidth = 0;
					%ctrl.tooltip = "";
				}
			case "AllBag_RedundantBag2": //背包扩展栏
				if (AllBag_RedundantBagBackGround2.IsVisible()){
					%ctrl.tooltipWidth = 240;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>扩展栏</t><b/><t>可通过装备乾坤袋增加背包容量</t></t>";
				}
				else{
					%ctrl.tooltipWidth = 0;
					%ctrl.tooltip = "";
				}
			case "AllBag_RedundantBag3": //背包扩展栏
				if (AllBag_RedundantBagBackGround3.IsVisible()){
					%ctrl.tooltipWidth = 240;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>扩展栏</t><b/><t>可通过装备乾坤袋增加背包容量</t></t>";
				}
				else{
					%ctrl.tooltipWidth = 0;
					%ctrl.tooltip = "";
				}
			case "AllBag_RedundantBag4": //背包扩展栏
				if (AllBag_RedundantBagBackGround4.IsVisible()){
					%ctrl.tooltipWidth = 240;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>扩展栏</t><b/><t>可通过装备乾坤袋增加背包容量</t></t>";
				}
				else{
					%ctrl.tooltipWidth = 0;
					%ctrl.tooltip = "";
				}
			case "AllBag_RedundantBag5": //背包扩展栏
				if (AllBag_RedundantBagBackGround5.IsVisible()){
					%ctrl.tooltipWidth = 240;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>扩展栏</t><b/><t>可通过装备乾坤袋增加背包容量</t></t>";
				}
				else{
					%ctrl.tooltipWidth = 0;
					%ctrl.tooltip = "";
				}
			case "AllBag_RedundantBag6": //背包扩展栏
				if (AllBag_RedundantBagBackGround6.IsVisible()){
					%ctrl.tooltipWidth = 240;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>扩展栏</t><b/><t>可通过装备乾坤袋增加背包容量</t></t>";
				}
				else{
					%ctrl.tooltipWidth = 0;
					%ctrl.tooltip = "";
				}
			case "AllBag_RedundantBag7": //背包扩展栏
				if (AllBag_RedundantBagBackGround7.IsVisible()){
					%ctrl.tooltipWidth = 240;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>扩展栏</t><b/><t>可通过装备乾坤袋增加背包容量</t></t>";
				}
				else{
					%ctrl.tooltipWidth = 0;
					%ctrl.tooltip = "";
				}
			case "AllBag_RedundantBag8": //背包扩展栏
				if (AllBag_RedundantBagBackGround8.IsVisible()){
					%ctrl.tooltipWidth = 240;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>扩展栏</t><b/><t>可通过装备乾坤袋增加背包容量</t></t>";
				}
				else{
					%ctrl.tooltipWidth = 0;
					%ctrl.tooltip = "";
				}


				//加锁界面说明

			case "ItemsSecurity_LockInfoExplainBtn"://加锁说明
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>物品安全说明</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>1.只有装备类可以锁定！</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>2.锁定的装备不会掉落并且不可交易！</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>3.死亡损失若随机到掉落的装备为已锁定的装备则该装备会变为破损状态，需修复后才可使用！</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>4.修复破损的装备时会给造成破损的人一定元宝（通过邮件形式发送）。</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>5.装备解锁需消耗钥匙，且需要3天时间，在此3天该解锁的装备效果与锁定相同。</t></t>";


				//仓库扩展栏

			case "AllBank_RedundantBag": //扩展栏
				if (0 == $g_SignWhetherZBBank){
					%ctrl.tooltipWidth = 240;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>扩展栏</t><b/><t>可通过装备仓库扩展包增加仓库容量</t></t>";
				}
				else{
					%ctrl.tooltipWidth = 0;
					%ctrl.tooltip = "";
				}




				//私聊界面清除按钮
			case "ChatFriendWnd_WriteLett": //扩展栏
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>清除消息</t><b/><t>点击此按钮可清除全部对话内容</t></t>";






				// case "AllBagXianShiGui":
				// %ctrl.tooltipWidth = 280;
				// %ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元宝</t><b/><t>RMB代币,可在昆仑决商城中消费</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>可从昆仑决商城进入官网进行充值，然后提取元宝至本服务器使用</t></t>";

				//	case "AllBag_ImmortalRockImage":
				//	%ctrl.tooltipWidth = 280;
				//	%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元宝</t><b/><t>RMB代币,可在昆仑决商城中消费</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>可从昆仑决商城进入官网进行充值，然后提取元宝至本服务器使用</t></t>";

				//	case "AllBag_BindImmortalRockImage":
				//	%ctrl.tooltipWidth = 280;
				//	%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>系统赠送的元宝</t><b/><t>不可交易的RMB代币，可在绑定昆仑决商城内购买商品</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>完成上线送礼、特殊活动都有机会获得绑定元宝</t></t>";

				//	case "AllBagBindXianShiGui":
				//	%ctrl.tooltipWidth = 280;
				//	%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>系统赠送的元宝</t><b/><t>不可交易的RMB代币，可在绑定昆仑决商城内购买商品</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>完成上线送礼、特殊活动都有机会获得绑定元宝</t></t>";

			case "AllBag_HotSellCommodityButton":
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>热卖商品</t><b/><t>昆仑决商城内最热卖商品的显示</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击按钮可切换热卖商品显示与隐藏状态</t></t>";

			case "AllBag_BusinessButton"://背包摆摊界面
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>摆摊</t><b/><t>可在昆仑主城摆摊交易</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>在指定地图内点击按钮即可打开摆摊窗口</t></t>";

			case "AllBag_CurrentlyItemNum":
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>·新手角色在线时间</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>满30分钟</t><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>后,</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>  将获得开启8格乾坤袋物品</t><b/><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>·参加活动有一定几率</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>  获得乾坤袋的奖励</t><b/><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>·在昆仑决商城中花费元宝可购买到</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>  开启数量更多的乾坤袋物品</t></t>";

			case "AllBag_ChongButton"://背包充值按钮
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>充值</t><b/><t>从这里可以进行元宝的充值和提取操作</t></t>";

			case "AllBag_ShopButton"://背包热卖商品
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>热卖商品</t><b/><t>点击可快速查看商城热卖商品！</t></t>";

			case "AllBag_GoldButton"://元宝交易
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元宝交易</t><b/><t>点击可打开交易界面进行元宝交易</t></t>";

			case "AllBag_DuiButton":
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元宝交易</t><b/><t>在开启的元宝交易界面中，可以进行元宝和金币的互换</t></t>";

			case "ChooseChongZhiStyleWnd_IntroBitmap1":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='黑体' n='14' b='1'>支付宝快捷充值</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>未绑定支付宝账号：</t><b/><t>1、点击【支付宝快捷充值】，进入支付宝页面</t><b/><t>2、输入需要绑定的支付宝账号</t><b/><t>3、绑定后点击【支付宝快捷充值】，直接打开游戏内支付宝快捷充值界面</t><b/><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>已绑定支付宝账号：</t><b/><t>1、点击【支付宝快捷充值】，输入需充值的金额并点确定</t><b/><t>2、系统向您绑定的手机发送验证码</t><b/><t>3、手机回复验证码，即可充值成功</t></t>";

				//============================================================================角色抗性页====================================================================================================
				//抵抗是减少被发动效果的概率，格挡是被发动效果后实际产生的有效度，抵抗是被发动效果后可以免疫效果再次发生的有效时间

			case "DTPlayerInfowGui_Dikang1"://抵抗
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>抵抗眩晕</t><b/><t>免疫产生眩晕效果的概率</t></t>";

			case "DTPlayerInfowGui_Dikang2":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>抵抗混乱</t><b/><t>免疫产生混乱效果的概率</t></t>";

			case "DTPlayerInfowGui_Dikang3":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>抵抗变身</t><b/><t>免疫产生变身效果的概率</t></t>";

			case "DTPlayerInfowGui_Dikang4":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>抵抗减速</t><b/><t>免疫产生减速效果的概率</t></t>";

			case "DTPlayerInfowGui_Dikang5":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>抵抗沉默</t><b/><t>免疫产生沉默效果的概率</t></t>";

			case "DTPlayerInfowGui_Dikang6":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>抵抗昏睡</t><b/><t>免疫产生昏睡效果的概率</t></t>";

			case "DTPlayerInfowGui_Dikang7":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>抵抗束缚</t><b/><t>免疫产生束缚效果的概率</t></t>";


			case "DTPlayerInfowGui_Gedang1": //格挡
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>眩晕格挡</t><b/><t>受到眩晕效果时减免相应的有效时间</t></t>";

			case "DTPlayerInfowGui_Gedang2":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>混乱格挡</t><b/><t>受到混乱效果时减免相应的有效时间</t></t>";

			case "DTPlayerInfowGui_Gedang3":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>变身格挡</t><b/><t>受到变身效果时减免相应的有效时间</t></t>";

			case "DTPlayerInfowGui_Gedang4":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>减速格挡</t><b/><t>受到减速效果时减免相应的有效时间</t></t>";

			case "DTPlayerInfowGui_Gedang5":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>沉默格挡</t><b/><t>受到沉默效果时减免相应的有效时间</t></t>";

			case "DTPlayerInfowGui_Gedang6":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>昏睡格挡</t><b/><t>受到昏睡效果时减免相应的有效时间</t></t>";

			case "DTPlayerInfowGui_Gedang7":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>束缚格挡</t><b/><t>受到束缚效果时减免相应的有效时间</t></t>";


			case "DTPlayerInfowGui_Kangxing1": //抗性
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>眩晕抗性</t><b/><t>眩晕抗性越高，眩晕效果解除后可免疫眩晕的时间越长</t></t>";

			case "DTPlayerInfowGui_Kangxing2":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>混乱抗性</t><b/><t>混乱抗性越高，混乱效果解除后可免疫混乱的时间越长</t></t>";

			case "DTPlayerInfowGui_Kangxing3":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>变身抗性</t><b/><t>变身抗性越高，变身效果解除后可免疫变身的时间越长</t></t>";

			case "DTPlayerInfowGui_Kangxing4":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>减速抗性</t><b/><t>减速抗性越高，减速效果解除后可免疫减速的时间越长</t></t>";

			case "DTPlayerInfowGui_Kangxing5":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>沉默抗性</t><b/><t>沉默抗性越高，沉默效果解除后可免疫沉默的时间越长</t></t>";

			case "DTPlayerInfowGui_Kangxing6":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>昏睡抗性</t><b/><t>昏睡抗性越高，昏睡效果解除后可免疫昏睡的时间越长</t></t>";

			case "DTPlayerInfowGui_Kangxing7":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>束缚抗性</t><b/><t>束缚抗性越高，束缚效果解除后可免疫束缚的时间越长</t></t>";

				//============================================================================角色装备属性====================================================================================================



			case "PlayerInfo_Family":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>圣地名称</t><b/><t>角色所属圣地</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>不同圣地对自身的基本属性影响也不同</t></t>";

			case "DTPlayerInfoGuiKX":
				%ctrl.tooltipWidth = 135;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>圣地标志</t><b/><t>"@  %Family1 @"的标志</t></t>";

			case "PlayerInfo_Faction"://时装按钮
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>时装与装备外形的切换</t><b/><t>显示普通时装或圣地时装，需点击</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>右上角的时装按钮</t><t>，进入时装界面进行设置</t></t>";

			case "PlayerInfo_ShowArmet"://头盔按钮
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>显示与隐藏头盔显示切换</t></t>";

			case "DTPlayerInfo_ZDbtn":
				%ctrl.tooltipWidth = 130;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>战斗属性</t></t>";

			case "PlayerInfo_AccouterButton":
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>切换至装备属性界面</t></t>";

			case "PlayerInfoGui_OpenRightWndButton":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>查看与隐藏角色属性信息</t></t>";

			case "DTPlayerInfo_Itemtext"://装备品质
				%ctrl.tooltipWidth = 350;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前角色装备的品质总值 </t><b/><t>1、装备品质可通过主界面中的强化按钮进行天珠镶嵌、装备进阶、增灵、换灵、洗灵、吞噬、升级等方式提升</t><b/><t>2、天珠等级越高增加的装备品质值越高</t></t>";

			case "PlayerInfo_NowExp"://经验条
				%ctrl.tooltipWidth = 340;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>人物经验</t><b/><t>1、显示：当前人物经验/升级所需经验</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >2、人物4修后经验最多可储存三倍的升级所需经验</t></t>";

			case "PlayerInfo_PlayerLevelUpButton"://升级
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>角色升级</t><b/><t>4修以后满足升级经验要求时</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>需手动点击</t><t>该按钮进行升级</t></t>";

			case "PlayerInfoGui_XiuShen_Num":
				%xiushenNum = getWorldPlayerTopDisaster();
				if (%xiushenNum == 0){ %xiushen1="<b/><t>当前杀怪无额外加成</t><b/><t>当尚武指数达到4或4以上时，杀怪将有收益加成</t>"; }
				else if (%xiushenNum == 1){ %xiushen1="<b/><t>当前杀怪无额外加成</t><b/><t>当尚武指数达到4或4以上时，杀怪将有收益加成</t>"; }
				else if (%xiushenNum == 2){ %xiushen1="<b/><t>当前杀怪无额外加成</t><b/><t>当尚武指数达到4或4以上时，杀怪将有收益加成</t>"; }
				else if (%xiushenNum == 3){ %xiushen1="<b/><t>当前杀怪无额外加成</t><b/><t>当尚武指数达到4或4以上时，杀怪将有收益加成</t>"; }
				else if (%xiushenNum == 4){ %xiushen1="<b/><t>当前全服65级以下玩家（含65级）杀怪获得的人物经验额外增加50%</t>"; }
				else if (%xiushenNum == 5){ %xiushen1="<b/><t>当前全服75级以下玩家（含75级）杀怪获得的人物经验额外增加75%</t>"; }
				else if (%xiushenNum == 6){ %xiushen1="<b/><t>当前全服85级以下玩家（含85级）杀怪获得的人物经验额外增加100%</t>"; }
				else if (%xiushenNum == 7){ %xiushen1="<b/><t>当前全服95级以下玩家（含95级）杀怪获得的人物经验额外增加125%</t>"; }
				else if (%xiushenNum == 8){ %xiushen1="<b/><t>当前全服105级以下玩家（含105级）杀怪获得的人物经验额外增加150%</t>"; }
				else if (%xiushenNum == 9){ %xiushen1="<b/><t>当前全服115级以下玩家（含115级）杀怪获得的人物经验额外增加200%</t>"; }
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前服务器尚武指数："@ %xiushenNum @"</t>"@%xiushen1 @"<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>小提示：尚武指数初始值为0，每当游戏中有人渡过天劫时，尚武指数便会提升。当尚武指数达到4或4以上时，杀怪将有额外收益加成。</t></t>";

			case "AllServerMovementGuiTxt":
				%xiushenNum = getWorldPlayerTopDisaster();
				if (%xiushenNum == 0){ %xiushen1="<b/><t>当前杀怪无额外加成</t><b/><t>当尚武指数达到4或4以上时，杀怪将有收益加成</t>"; }
				else if (%xiushenNum == 1){ %xiushen1="<b/><t>当前杀怪无额外加成</t><b/><t>当尚武指数达到4或4以上时，杀怪将有收益加成</t>"; }
				else if (%xiushenNum == 2){ %xiushen1="<b/><t>当前杀怪无额外加成</t><b/><t>当尚武指数达到4或4以上时，杀怪将有收益加成</t>"; }
				else if (%xiushenNum == 3){ %xiushen1="<b/><t>当前杀怪无额外加成</t><b/><t>当尚武指数达到4或4以上时，杀怪将有收益加成</t>"; }
				else if (%xiushenNum == 4){ %xiushen1="<b/><t>当前全服65级以下玩家（含65级）杀怪获得的人物经验额外增加50%</t>"; }
				else if (%xiushenNum == 5){ %xiushen1="<b/><t>当前全服75级以下玩家（含75级）杀怪获得的人物经验额外增加75%</t>"; }
				else if (%xiushenNum == 6){ %xiushen1="<b/><t>当前全服85级以下玩家（含85级）杀怪获得的人物经验额外增加100%</t>"; }
				else if (%xiushenNum == 7){ %xiushen1="<b/><t>当前全服95级以下玩家（含95级）杀怪获得的人物经验额外增加125%</t>"; }
				else if (%xiushenNum == 8){ %xiushen1="<b/><t>当前全服105级以下玩家（含105级）杀怪获得的人物经验额外增加150%</t>"; }
				else if (%xiushenNum == 9){ %xiushen1="<b/><t>当前全服115级以下玩家（含115级）杀怪获得的人物经验额外增加200%</t>"; }
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前服务器尚武指数："@ %xiushenNum @"</t>"@%xiushen1 @"<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>小提示：尚武指数初始值为0，每当游戏中有人渡过天劫时，尚武指数便会提升。当尚武指数达到4或4以上时，杀怪将有额外收益加成。</t></t>";


			case "PlayerInfo_Duoming"://装备的夺名按钮
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>装备的争榜夺名</t><b/><t>将您拥有的极品装备上传至排行榜内排名</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>装备栏上的装备可直接放入奇珍争榜夺名界面上传</t></t>";

			case "PlayerInfoEquip_Bmp1":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>获得更高品质装备提示</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >点击当前装备部位栏，会弹出获得更高品质装备途径界面</t></t>";

			case "PlayerInfoEquip_Bmp2":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>获得更高品质装备提示</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >点击当前装备部位栏，会弹出获得更高品质装备途径界面</t></t>";

			case "PlayerInfoEquip_Bmp3":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>获得更高品质装备提示</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >点击当前装备部位栏，会弹出获得更高品质装备途径界面</t></t>";

			case "PlayerInfoEquip_Bmp4":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>获得更高品质装备提示</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >点击当前装备部位栏，会弹出获得更高品质装备途径界面</t></t>";

			case "PlayerInfoEquip_Bmp5":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>获得更高品质装备提示</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >点击当前装备部位栏，会弹出获得更高品质装备途径界面</t></t>";

			case "PlayerInfoEquip_Bmp6":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>获得更高品质装备提示</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >点击当前装备部位栏，会弹出获得更高品质装备途径界面</t></t>";

			case "PlayerInfoEquip_Bmp7":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>获得更高品质装备提示</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >点击当前装备部位栏，会弹出获得更高品质装备途径界面</t></t>";

			case "PlayerInfoEquip_Bmp8":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>获得更高品质装备提示</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >点击当前装备部位栏，会弹出获得更高品质装备途径界面</t></t>";

			case "PlayerInfoEquip_Bmp9":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>获得更高品质装备提示</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >点击当前装备部位栏，会弹出获得更高品质装备途径界面</t></t>";

			case "PlayerInfoEquip_Bmp10":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>获得更高品质装备提示</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >点击当前装备部位栏，会弹出获得更高品质装备途径界面</t></t>";

			case "PlayerInfoEquip_Bmp11":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>获得更高品质装备提示</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >点击当前装备部位栏，会弹出获得更高品质装备途径界面</t></t>";

			case "PlayerInfoEquip_Bmp12":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>获得更高品质装备提示</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >点击当前装备部位栏，会弹出获得更高品质装备途径界面</t></t>";

			case "PlayerInfoEquip_Bmp13":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>获得更高品质装备提示</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >点击当前装备部位栏，会弹出获得更高品质装备途径界面</t></t>";


				//============================================================================安全设置=================================================================================================================

			case "SecurityCfgWnd_TimeGui_Sure"://设置
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>输入新的安全时间，点击确定按钮，将在24小时后生效</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>安全时间只能在1-30分钟内自定义设置</t></t>";

			case "SecurityCfgWnd_ItemGui_Lock"://锁定
				%state = %player.getSecondPWDState();
				if (%state == 0){ %lockNews ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>提示：你当前二级密码还未设置，需先设置二级密码</t>"; }
				%ctrl.tooltipWidth = 350;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>选中待加锁的物品，点击锁定按钮即可对物品加锁</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>物品锁定后将无法进行交易、分解，销毁等操作</t>"@ %lockNews @"</t>";

			case "SecurityCfgWnd_ItemGui_Unlock"://解锁
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>选中已加锁的物品，点击解锁按钮即可对物品解锁</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>解锁后的物品将进入3天的解锁确认期</t></t>";

			case "SecurityCfgWnd_PetInfoGui_LockButton"://锁定
				%state = %player.getSecondPWDState();
				if (%state == 0){ %lockNews ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>提示：你当前二级密码还未设置，需先设置二级密码</t>"; }
				%ctrl.tooltipWidth = 350;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>选中待加锁的神兽，点击锁定按钮即可对神兽加锁</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>神兽锁定后将无法进行交易、放生，炼化等操作</t>"@ %lockNews @"</t>";

			case "SecurityCfgWnd_PetInfoGui_UnlockButton"://解锁
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>选中已加锁的神兽，点击解锁按钮即可对神兽解锁</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>解锁后的神兽将进入3天的解锁确认期</t></t>";

			case "SecurityCfgWnd_MountGui_LockButton"://锁定
				%state = %player.getSecondPWDState();
				if (%state == 0){ %lockNews ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>提示：你当前二级密码还未设置，需先设置二级密码</t>"; }
				%ctrl.tooltipWidth = 350;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>选中待加锁的骑宠，点击锁定按钮即可对骑宠加锁</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>骑宠锁定后将无法放生</t>"@ %lockNews @"</t>";

			case "SecurityCfgWnd_MountGui_UnlockButton"://解锁
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>选中已加锁的骑宠，点击解锁按钮即可对骑宠解锁</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>解锁后的骑宠将进入3天的解锁确认期</t></t>";

			case "SecurityCfgWnd_SoulGui_LockButton"://锁定
				%state = %player.getSecondPWDState();
				if (%state == 0){ %lockNews ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>提示：你当前二级密码还未设置，需先设置二级密码</t>"; }
				%ctrl.tooltipWidth = 350;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>选中待加锁的化神，点击锁定按钮即可对化神加锁</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>化神锁定后将无法进行丢弃，洗点等操作</t>"@ %lockNews @"</t>";

			case "SecurityCfgWnd_SoulGui_UnlockButton"://解锁
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>选中已加锁的化神，点击解锁按钮即可对化神解锁</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>解锁后的化神将进入3天的解锁确认期</t></t>";

				//============================================================================队伍界面=================================================================================================================

			case "TeamNameEdit_1"://队伍名字
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>队伍名字</t><b/><t>队伍名字可以改名,鼠标激活队伍名字显示框,输入队伍新名字后,需点击改名按钮确认</t></t>";

			case "ChangeTeamNameBtn"://改名
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>队伍改名确认</t><b/><t>队伍名字最多11个汉字</t><b/><t>鼠标激活队伍名字显示框,输入队伍新名字后,需点击改名按钮确认</t></t>";

			case "TeammateIconHelping_1"://协助战斗
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>协助战斗</t><b/><t>可设定队员是否自动协助队长战斗</t><b/><t>当队长进入自动战斗时，开启战斗协助功能的队员也会自动进入自动战斗</t></t>";






				//============================================================================角色能力界面=================================================================================================================
				//PlayerAbility_Attack 攻击力
				//PlayerAbility_AttackHZ 攻击频率
				//PlayerAbility_Stabilize 稳定性
				//PlayerAbility_Breathe 生存
				//PlayerAbility_Therapy 治疗
				//PlayerAbility_Assistant 辅助

				//============================================================================角色信息界面=================================================================================================================



			case "DTPlayerInfo_vip"://VIP等级
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>VIP等级特权</t><b/><t>VIP等级越高特权越多</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击可进入VIP特权中心</t></t>";

			case "DTPlayerInfo_ZhuangSheng"://六道轮回等级
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>六道轮回等级 </t><b/><t>轮回等级越高获得的属性加成越高</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击查看轮回属性奖励</t></t>";



			case "DTPlayerInfo_PlayerName"://玩家名字
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>角色名</t></t>";

			case "DTPlayerInfo_DuoMingbtn"://夺名按钮
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>夺名按钮</t><b/><t>从这里可以将自身的装备品质值上传到排行榜中参与排名</t><b/><t c='0x00ff00ff' >功能暂未开放，敬请期待</t></t>";

			case "DTPlayerInfo_KXbtn":
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>抗性</t><b/><t>显示角色所有的抗性，包括抵抗、格挡、抗性三类</t></t>";

			case "DTPlayerInfo_ZDbtn":
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>战斗信息</t><b/><t>显示角色基本信息和战斗属性</t></t>";

			case "DTPlayerInfo_SZbtn":
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>时装</t><b/><t>角色拥有的时装都放在这里</t></t>";

			case "DTPlayerInfo_SJbtn"://升级
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>角色升级</t><b/><t>4修以后满足升级经验要求时</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>需手动点击</t><t>该按钮进行升级</t></t>";

			case "DTPlayerInfo_NowExp"://经验条
				%ctrl.tooltipWidth = 340;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>角色经验</t><b/><t>1、显示：当前角色经验/升级所需经验</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >2、角色4修后经验最多可储存三倍的升级所需经验</t></t>";



				//                                              ============================角色信息 - 战斗信息===============================


			case "DTPlayerInfowGui_Zhuansheng"://轮回
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>轮回等级</t><b/><t>每一次轮回都会获得属性加成</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>达到等级条件后可以找青龙圣地圣主进行轮回</t></t>";

			case "DTPlayerInfowGui_Lv"://等级
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>角色等级</t><b/><t>轮回可以重置角色等级并获得属性加成</t></t>";

			case "DTPlayerInfowGui_Work"://职业
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>职业</t><b/><t>不同职业的基本属性和攻击属性影响不同</t></t>";

			case "DTPlayerInfowgui_family"://职业

				if (%Family ==0){ %menfa = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>门阀势力</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1修5重后在圣地圣主处可接到加入门阀势力的任务</t></t>"; }
				if (%Family ==1){ %menfa = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>门阀势力</t><b/><t>与寇阀、宋阀是敌对势力，和宇文阀结盟中</t></t>"; }
				if (%Family ==2){ %menfa = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>门阀势力</t><b/><t>与寇阀、宋阀是敌对势力，和李阀结盟中</t></t>"; }
				if (%Family ==3){ %menfa = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>门阀势力</t><b/><t>与李阀、宇文阀是敌对势力，和宋阀结盟中</t></t>"; }
				if (%Family ==4){ %menfa = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>门阀势力</t><b/><t>与李阀、宇文阀是敌对势力，和寇阀结盟中</t></t>"; }
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = ""@ %menfa @"";

			case "DTPlayerInfo_ExpTiliText":
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>体力值 [简称：HP]</t><b/><t>显示：当前体力值/体力值上限</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>当前体力值为0时角色将死亡</t></t>";

			case "DTPlayerInfo_ExpJingliText":
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>精力值 [简称：MP]</t><b/><t>显示：当前精力值/精力值上限</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>角色释放战斗技能将消耗精力</t></t>";

			case "DTPlayerInfo_ExpYuanliText":
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元力值 [简称：PP]</t><b/><t>显示：当前元力值/元力值上限</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>化神幻化、内力技能都将消耗元力</t></t>";

			case "DTPlayerInfo_ExpHuoliText":
				%ctrl.tooltipWidth = 290;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>活力值</t><b/><t>1、显示：当前活力值/活力值上限</t><b/><t>2、生活技能制造时所消耗,不同的制造配方所消耗的活力值不同。与陌生人发邮件也将消耗活力值</t><b/><t>3、角色在线则就自动恢复活力值</t></t>";

			case "DTPlayerInfo_ExpShenfaText":

				if (%Classes==1){ %shenfa1="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>基本属性（身法）</t><b/><t>提升少量的"@ %gongjishanghai1 @"闪避和"@ %gongjishanghai1 @"命中</t></t>"; }
				else if (%Classes==2){ %shenfa1="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>基本属性（身法）</t><b/><t>提升少量的"@ %gongjishanghai1 @"闪避和"@ %gongjishanghai1 @"命中</t></t>"; }
				else if (%Classes==3){ %shenfa1="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>基本属性（身法）</t><b/><t>提升少量的"@ %gongjishanghai1 @"闪避和"@ %gongjishanghai1 @"命中</t></t>"; }
				else if (%Classes==4){ %shenfa1="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>基本属性（身法）</t><b/><t>提升少量的"@ %gongjishanghai1 @"闪避和"@ %gongjishanghai1 @"命中</t></t>"; }
				else if (%Classes==5){ %shenfa1="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>基本属性（身法）</t><b/><t>提升少量的"@ %gongjishanghai1 @"闪避和"@ %gongjishanghai1 @"命中</t></t>"; }
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = ""@ %shenfa1 @"";

			case "DTPlayerInfo_ExpJingshenText":
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>基本属性（精神）</t><b/><t>提高角色精力值上限</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1点精神可增加22.8点精力值上限同时提升少量的精力恢复速度</t></t>";

			case "DTPlayerInfo_ExpTipoText":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>基本属性（体魄）</t><b/><t>提高角色体力值上限</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1点体魄可增加13点体力值上限同时提升少量的体力恢复速度</t></t>";

			case "DTPlayerInfo_ExpNeiliText2":

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>基本属性（内力）</t><b/><t>提高角色内力攻击</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1点内力可增加2.83点内力攻击</t></t>";

			case "DTPlayerInfo_ExpNeiliText3":// 普通攻击类型		

				if (%Classes==1){ %gongji1="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>基本属性（力道）</t><b/><t>提升提高角色物理攻击</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1点力道可增加1.57物理攻击</t></t>"; }
				else if (%Classes==2){ %gongji1="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>基本属性（力道）</t><b/><t>提升提高角色物理攻击</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1点力道可增加1.57物理攻击</t></t>"; }
				else if (%Classes==3){ %gongji1="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>基本属性（智力）</t><b/><t>提升提高角色法术攻击</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1点智力可增加1.32法术攻击</t></t>"; }
				else if (%Classes==4){ %gongji1="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>基本属性（智力）</t><b/><t>提升提高角色法术攻击</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1点智力可增加1.32法术攻击</t></t>"; }
				else if (%Classes==5){ %gongji1="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>基本属性（力道）</t><b/><t>提升提高角色物理攻击</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1点力道可增加1.57物理攻击</t></t>"; }
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = ""@ %gongji1 @"";

			case "DTPlayerInfo_ExpNeiliText4":// 特殊攻击类型		
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>基本属性（"@ %wuxigongji1 @"灵）</t><b/><t>提高角色"@ %wuxigongji1 @"系攻击</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1点"@ %wuxigongji1 @"灵可增加1点"@ %wuxigongji1 @"系攻击</t></t>";

			case "DTPlayerInfo_ExpBaoJIText":
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>暴击</t><b/><t>提高角色产生暴击伤害的几率,数值越高越暴击几率就越大</t></t>";

			case "DTPlayerInfo_ExpZhiliaoText":
				%ctrl.tooltipWidth = 170;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>治疗</t><b/><t>自身所能提高的治疗值</t></t>";

			case "DTPlayerInfo_ExpJianRenText":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>坚韧</t><b/><t>数值越高越防止暴击几率就越大</t></t>";

			case "DTPlayerInfo_ExpFuyuanText"://福缘
				%ctrl.tooltipWidth = 205;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>福缘</t><b/><t>（功能暂未开放，敬请期待）</t>";

				//角色信息 - 攻击分页属性
			case "DTPlayerInfo_ExpGongXGongText":
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %gongjishanghai1 @"攻击</t><b/><t>自身所能造成的"@ %gongjishanghai1 @"伤害值</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >武器的攻击速度值越高,"@ %gongjishanghai1 @"攻击加成越大</t></t>";

			case "DTPlayerInfo_ExpGongText1":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>内力攻击（内力类）</t><b/><t>角色自身所能造成的内力伤害</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>受内力属性值影响</t></t>";

			case "DTPlayerInfo_ExpGongText2":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>物理闪避</t><b/><t>物理闪避值越高则闪避对手物理攻击几率越高</t></t>";

			case "DTPlayerInfo_ExpGongText3":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>法术闪避</t><b/><t>法术闪避值越高则闪避对手法术攻击几率越高</t></t>";

			case "DTPlayerInfo_ExpGongLingGongtext":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %wuxigongji1 @"灵攻击</t><b/><t>自身所能造成的"@ %wuxigongji1 @"系伤害值</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>受"@ %wuxigongji1 @"灵影响</t></t>";

			case "DTPlayerInfo_ExpGongMingZhongtext":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %gongjishanghai1 @"命中</t><b/><t>"@ %gongjishanghai1 @"命中越高则对手闪避你的"@ %gongjishanghai1 @"攻击几率越低</t></t>";

				//角色信息 - 防御分页属性

			case "DTPlayerInfo_ExpFangPageText1":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>物理防御</t><b/><t>受到物理攻击伤害时减免相应的伤害</t></t>";

			case "DTPlayerInfo_ExpFangPageText2":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>法术防御</t><b/><t>受到法术攻击伤害时减免相应的伤害</t></t>";

			case "DTPlayerInfo_ExpFangPageText3":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>内力防御</t><b/><t>受到内力攻击伤害时减免相应的伤害</t></t>";

			case "DTPlayerInfo_ExpFangPageText4":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>毒系抗性</t><b/><t>受到毒灵攻击伤害时减免相应的伤害</t></t>";

			case "DTPlayerInfo_ExpFangPageText5":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>火系抗性</t><b/><t>受到火灵攻击伤害时减免相应的伤害</t></t>";

			case "DTPlayerInfo_ExpFangPageText6":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>土系抗性</t><b/><t>受到土灵攻击伤害时减免相应的伤害</t></t>";

			case "DTPlayerInfo_ExpFangPageText7"://悟性
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>金系抗性</t><b/><t>受到金灵攻击伤害时减免相应的伤害</t></t>";

			case "DTPlayerInfo_ExpFangPageText8":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>冰系抗性</t><b/><t>受到冰灵攻击伤害时减免相应的伤害</t></t>";

				//角色信息 -其他分页属性

			case "DTPlayerInfo_ExpOtherText1":
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>无视"@ %gongjishanghai1 @"防御</t><b/><t>给对方造成"@ %gongjishanghai1 @"伤害时可无视对方的部分"@ %gongjishanghai1 @"防御值</t></t>";

			case "DTPlayerInfo_ExpOtherText2":
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>无视"@ %wuxigongji1 @"系抗性</t><b/><t>给对方造成"@ %wuxigongji1 @"系伤害时可无视对方的部分"@ %wuxigongji1 @"系抗性</t></t>";

			case "DTPlayerInfo_ExpOtherText7":
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>无视内力防御</t><b/><t>给对方造成内力伤害时可无视对方的部分内力防御</t></t>";

			case "DTPlayerInfo_ExpOtherText3":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>攻击速度</t><b/><t>获得的攻击速度加成</t></t>";

			case "DTPlayerInfo_ExpOtherText4":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>暴击倍数</t><b/><t>发动暴击伤害后相对普通伤害的增长值</t></t>";

			case "DTPlayerInfo_ExpOtherText5":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>移动速度</t><b/><t>获得的移动速度加成</t></t>";

			case "DTPlayerInfo_ExpOtherText6":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>抗暴击倍数</t><b/><t>受到暴击后对暴击伤害的减免</t></t>";


				//============================================================================查看目标角色信息界面=================================================================================================================

			case "TargetInfo_PlayerName"://名字
				%ctrl.tooltipWidth = 95;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>名字</t><b/><t>角色的名字</t></t>";

			case "TargetInfo_Level"://等级
				%ctrl.tooltipWidth = 120;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>等级</t><b/><t>角色等级</t></t>";

			case "TargetInfo_ItemQuality_1"://品质
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前角色所有装备的品质总值</t><b/><t>装备品质总值/天珠品质总值</t><b/><t>装备品质总值：装备</t></t>";

			case "TargetInfo_AccouterButton"://切换至装备属性
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>切换至装备属性界面</t></t>";

			case "TargetInfo_FashionButton": //切换至时装属性
				%ctrl.tooltipWidth = 130;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>切换至时装界面</t></t>";


				//=====================================================================================化神界面=============================================================================================================
			case "Avatar_Floor"://化神境界热感说明
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神境界</t><b/><t>每个化神分为6个境界，每提高1个境界，化神的等级上限提高20级</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>化神境界可以用炼身玉在界面中直接提升</t></t>";

			case "Avatar_Levelup"://化神升级按钮
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神升级</t><b/><t>手动点击按钮提升化神等级</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>需要消耗化神经验</t></t>";

			case "Avatar_Active"://化神激活
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>激活化神</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>此化神需要激活才可以使用</t></t>";

			case "Avatar_ExpBar"://化神经验条
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神经验</t><b/><t>当前化神经验/化神升级所需经验</t></t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>击败【秦俑阵、十八路反王、邪王墓】怪物可获得化神经验。</t></t>";

			case "SoulGenius_SpiritJingJie"://化神境界
				%nSpiritRace = SpiritOperationManager_GetSpiritType($SoulGeniusWnd_SpiritSlot);

				if (%nSpiritRace == 0){ %txt ="三才、炼心、光照、罡气、培元、混元、幻龙、合体、圣言、人王";%txt1="昆仑宗"; }
				else if (%nSpiritRace == 1){ %txt ="皈依、静思、修行、入灵、妙法、莲花、佛心、金身、涅槃、古佛";%txt1="雷音寺"; }
				else if (%nSpiritRace == 2){ %txt ="入静、观光、融合、心动、灵寂、元婴、出窍、分神、天劫、仙帝";%txt1="蓬莱派"; }
				else if (%nSpiritRace == 3){ %txt ="育种、抽芽、草灵、聚叶、精力、荆棘、分神、灵动、飞花、祖精";%txt1="飞花谷"; }
				else if (%nSpiritRace == 4){ %txt ="弃生、死门、聚魂、还虚、化形、阴气、幽血、冲魂、冥光、鬼神";%txt1="九幽教"; }
				else if (%nSpiritRace == 5){ %txt ="混合、聚神、分水、凝冰、灵合、御风、艮山、融元、雷动、元尊";%txt1="山海宗"; }
				else if (%nSpiritRace == 6){ %txt ="妖兽、幻化、醉生、梦死、灵寂、妖婴、梦魅、魂绕、幻杀、天妖";%txt1="幻灵宫"; }
				else if (%nSpiritRace == 7){ %txt ="魔骨、狂煞、无寂、贯众、心魔、恸天、十阵、无序、血界、魔皇";%txt1="天魔门"; }

				%ctrl.tooltipWidth = 440;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神境界</t><b/><t>1、"@ %txt1 @"的化神十个境界如下：</t><b/><t>"@ %txt @"</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>2、每种类型化神分为不同的十个境界,境界越高化神幻化后能力越强</t></t>";

			case "Avatar_UpgradeLVTip"://化神五行相克
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神五行相克规则</t><b/><t>1、所有化神对非化神状态玩家都有10%的攻击额外加成</t><b/><t>2、根据五行相克规则，攻击所克的属性化神时将有额外的攻击加成，无相克规则的则无攻击加成</t><b/><t>     </t><i s='gameres/data/icon/help/HS_01.png' w='150' h='150'/></t>";


			case "SoulGenius_SpiritLevel"://成长阶段
				%ctrl.tooltipWidth = 375;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>成长阶段</t><b/><t>1、显示：当前成长阶段/该境界下成长阶段的上限</t><b/><t>2、化神经验条满值后,成长阶段提升1级并获得天赋点1点</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>3、成长阶段达到上限后,将不能再提升,需对化神进行炼神</t></t>";

			case "SoulGenius_ExpText"://化神经验
				%ctrl.tooltipWidth = 380;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神经验</t><b/><t>1、显示：当前化神经验值/升级所需经验值</t><b/><t>2、角色击败妖怪,即可增加当前启用化神的经验值</t><b/><t>3、化神经验值满后将提高化神成长阶段1级和天赋点数1点</t></t>";

			case "SoulGenius_TalentLeftPts"://剩余天赋点数
				if ($CurSelectModeId == 0){ %KJJ =",查看按快捷键：K "; }
				else if ($CurSelectModeId == 1){ %KJJ =",查看按快捷键：Alt+K"; }
				else if ($CurSelectModeId == 2){ %KJJ =",查看按快捷键：K"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭战斗技能界面") !$= "")
						%KJJ = ",查看可按快捷键：" @ GetHotKey("打开/关闭战斗技能界面")@ "";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>剩余天赋点数</t><b/><t>1、化神经验条满值后,成长阶段提升1级并获得天赋点1点</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>2、可左键点击化神天赋图标进行加点</t><b/><t c='0xF450CFff'>3、激活出需手动释放的天赋技能显示在角色技能界面内"@ %KJJ @"</t></t>";

			case "SoulGenius_TalentPts"://已配点数
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>天赋已配点数</t><b/><t>1、天赋加点时要注意天赋技能对已配点数的需求</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>2、化神可通过洗点操作,清空已配天赋点,可对化神重新进行天赋配点</t></t>";

			case "SoulGenius_RemoveSpiritBtn"://丢弃按钮
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>丢弃化神</t><b/><t>启用化神、圣地化神、或在洗点、炼神状态下化神不能被丢弃</t></t>";

			case "SoulGenius_LockSpiritBtn"://锁定按钮
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>锁定化神</t><b/><t>点击按钮,打开安全设置界面可对化神进行加锁与解锁操作</t></t>";

			case "SoulGenius_SpiritSlot_1":

				if (SoulGenius_SpiritSlot_Image_1.Isvisible())
				{
					%ctrl.tooltipWidth = 275;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>被封的化神栏</t><b/><t>使用</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>化神石</t><t>可激活被封的化神栏</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>化神石</t><t>在大闹天宫活动中有一定几率获得，在昆仑决商城中可直接购买</t></t>";
				}

			case "SoulGenius_SpiritSlot_2":

				if (SoulGenius_SpiritSlot_Image_2.Isvisible())
				{
					%ctrl.tooltipWidth = 275;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>被封的化神栏</t><b/><t>使用</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>化神石</t><t>可激活被封的化神栏</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>化神石</t><t>在大闹天宫活动中有一定几率获得，在昆仑决商城中可直接购买</t></t>";
				}

			case "SoulGenius_SpiritSlot_3":

				if (SoulGenius_SpiritSlot_Image_3.Isvisible())
				{
					%ctrl.tooltipWidth = 275;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>被封的化神栏</t><b/><t>使用</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>化神石</t><t>可激活被封的化神栏</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>化神石</t><t>在大闹天宫活动中有一定几率获得，在昆仑决商城中可直接购买</t></t>";
				}

			case "SoulGenius_SpiritSlot_4":

				if (SoulGenius_SpiritSlot_Image_4.Isvisible())
				{
					%ctrl.tooltipWidth = 275;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>被封的化神栏</t><b/><t>使用</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>化神石</t><t>可激活被封的化神栏</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>化神石</t><t>在大闹天宫活动中有一定几率获得，在昆仑决商城中可直接购买</t></t>";
				}

			case "SoulGenius_Bnt_FindRefineSoulNPC":
				%ctrl.tooltipWidth = 350;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>左键单击,自动寻径到圣地化神管理员提升化神能力</t><b/><t>化神管理员有以下操作：</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>1、化神启用：</t><t>拥有两个以上化神,更换化神需进行启用化神操作</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>2、化神炼神：</t><t>成长阶段达上限后需进行炼神,提升化神境界使其拥有更加强大的能力</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>3、化神洗点：</t><t>化神洗点后,保留化神的当前境界和成长阶段,清空已配天赋点,可对化神重新进行天赋配点</t></t>";


			case "SoulGeniusBnt_OpenSkillWnd":
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>查看化神技能</t><b/><t>1、化神的幻化技能和激活出需手动释放的天赋技能显示在</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>角色技能界面化神技能页</t><t>内</t><b/><t>2、可鼠标左键拖动技能图标至快捷栏中</t></t>";

				//=====================================================================================操作设置界面=============================================================================================================
			case "HotKeyPopup_ChatFirst"://聊天优先
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>启用：</t><t>启用后聊天框一直处于可输入状态</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>禁用：</t><t>禁用后按Enter键聊天框可切换状态</t></t>";

			case "HotKeyPopup_SelfSpell"://自我施法
				%ctrl.tooltipWidth = 310;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>禁用：</t><t>关闭自我施法快捷方式</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>Alt：</t><t>按住Alt键,即可对自身施放增益技能</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>Ctrl：</t><t>按住Ctrl键,即可对自身施放增益技能</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>Shift：</t><t>按住Shift键,即可对自身施放增益技能</t></t>";

			case "Hotkey_SetasCustomBtn"://设置自定义
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>设置自定义</t><b/><t>可将当前的操作模式设置为自定义模式,即可在该模式的基础上作相应的快捷键修改</t></t>";

				//=====================================================================================神兵系列界面===============================================================================================================
			case "ShenTieRepair_ExplainBmp"://神兵修理
				%ctrl.tooltipWidth = 340;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兵修理说明：</t><b/><t>1、神兵修理需消耗玄铁碎片和元宝</t><b/><t>玄铁碎片可以通过活动:封神之会获得</t><b/><t>2、神兵的当前耐久降为0,神兵属性将不能发挥作用</t></t>";

			case "ShenTieMeltdown_ExplainBmp"://玄铁熔炼
				%ctrl.tooltipWidth = 370;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>玄铁熔炼说明：</t><b/><t>1、角色达到6修才能进行玄铁熔炼</t><b/><t>2、玄铁熔炼每次消耗一个玄铁熔炼液</t><b/><t>3、玄铁熔炼产物为玄铁碎片,玄铁碎片为可以交易的物品</t><b/><t>4、1个玄铁+1个玄铁熔炼液可以分解成3个玄铁碎片</t></t>";

			case "ShenTieCompose_ExplainBmp"://玄铁合成
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>玄铁合成说明：</t><b/><t>1、5个玄铁碎片+1个玄铁熔炼液可以合成1个玄铁</t><b/><t>2、合成的玄铁为不可交易</t></t>";

			case "ShenTieEnchase_ExplainBmp"://玄铁镶嵌
				%ctrl.tooltipWidth = 370;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兵技能镶嵌说明：</t><b/><t>1、每个神兵只能镶嵌一个神兵技能</t><b/><t>2、镶嵌的神兵技能等级必须不大于神兵使用等级</t><b/><t>3、神兵技能书镶嵌后，神兵会随机获得一个神兵技能。神兵使用等级越高，获取高级神兵技能的机会越大</t><b/><t>4、放入技能书符合镶嵌要求,则镶嵌100%成功</t></t>";

			case "ShenTiedeCompose_ExplainBmp"://神兵分解
				%ctrl.tooltipWidth = 420;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兵分解说明：</t><b/><t>1、神兵达到10阶即可分解</t><b/><t>2、神兵分解成功可获得一个的未开光神器(未开光神器等级=分解神兵等级+10)</t></t>";


				//===================================================================================生活技能界面==============================================================================================================================

			case "LivingSkillInfoLevelText":
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>生活等级</t><b/><t>制造道具、鉴定神兽、与陌生人发送邮件等消耗活力值的行为会增加生活经验值</t><b/><t c='0xff1200ff'>生活等级升级会提高活力值上限</t></t>";

			case "LivingSkillInfoExpText":
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>生活等级经验</t><b/><t>制造道具、鉴定神兽、与陌生人发送邮件等消耗活力值的行为会增加生活经验值</t><b/><t c='0xff1200ff'>生活等级升级会提高活力值上限</t></t>";

			default:
				StartTooltip2(%ctrl);

	}

	//对话内容
	%FuncName = "StartTooltip_"@ %ctrl.GetName();

	//发送isFunction
	if (isFunction(%FuncName))
		Call(%FuncName,%ctrl);
}


function StartTooltip2(%ctrl)
{
	%Player = GetPlayer();

	switch$(%ctrl.GetName())
	{

		//====================================================================================侍卫界面===========================================================================================================

			case "Mercenary_PetName"://侍卫名称
				%ctrl.tooltipWidth = 120;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫名字</t><b/><t>侍卫可以改名</t></t>";

			case "Mercenary_ChangeNameButton"://改名按钮
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫改名确认</t><b/><t>侍卫名字最长为八个汉字</t><b/><t>鼠标激活侍卫名称显示框,输入侍卫新名称后,需点击改名按钮确认</t></t>";

			case "Mercenary_ReBirth"://轮回
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>轮回等级</t><b/><t>侍卫的轮回等级，每一次轮回都会获得属性加成,准备轮回的侍卫需要将轮回进度增加到100%，轮回进度通过给侍卫使用'进度道具'来提升</t></t>";

			case "Mercenary_Level"://等级
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫等级</t><b/><t>轮回可以重置侍卫等级并获得属性加成</t></t>";

			case "Mercenary_Job"://职业
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>职业</t><b/><t>不同职业的基本属性和攻击属性影响不同</t></t>";

			case "Mercenary_intelligencePoint"://品阶
				%ctrl.tooltipWidth = 320;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫品阶</t><b/><t>品阶每提升1点,所有成长资质增加100点</t>";

			case "Mercenary_LearnInfo1_add"://增加体力修炼按钮
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>增加侍卫体力修炼</t><b/><t>影响侍卫体力最大值</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次增加5点</t></t>";

			case "Mercenary_LearnInfo1_dec"://减少体力修炼按钮
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>减少侍卫体力修炼</t><b/><t>影响侍卫体力最大值</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次清除5点</t></t></t>";

			case "Mercenary_LearnInfo2_add"://增加物攻修炼按钮
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>增加侍卫物攻修炼</t><b/><t>影响侍卫物理攻击最大值</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次增加5点</t></t></t>";

			case "Mercenary_LearnInfo2_dec"://减少物攻修炼按钮
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>减少侍卫物攻修炼</t><b/><t>影响侍卫物理攻击最大值</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次清除5点</t></t></t>";

			case "Mercenary_LearnInfo3_add"://增加法攻修炼按钮
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>增加侍卫法攻修炼</t><b/><t>影响侍卫法术攻击最大值</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次增加5点</t></t></t>";

			case "Mercenary_LearnInfo3_dec"://减少法攻修炼按钮
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>减少侍卫法攻修炼</t><b/><t>影响侍卫法术攻击最大值</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次清除5点</t></t></t>";

			case "Mercenary_LearnInfo4_add"://增加物防修炼按钮
				%ctrl.tooltipWidth = 170;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>增加侍卫物防修炼</t><b/><t>影响侍卫所受到的物理伤害减免值</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次增加5点</t></t></t>";

			case "Mercenary_LearnInfo4_dec"://减少物防修炼按钮
				%ctrl.tooltipWidth = 170;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>减少侍卫物防修炼</t><b/><t>影响侍卫所受到的物理伤害减免值</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次清除5点</t></t></t>";

			case "Mercenary_LearnInfo5_add"://增加法防修炼按钮
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>增加侍卫法防修炼</t><b/><t>影响侍卫所受到的法术伤害减免值</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次增加5点</t></t></t>";

			case "Mercenary_LearnInfo5_dec"://减少法防修炼按钮
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>减少侍卫法防修炼</t><b/><t>影响侍卫所受到的法术伤害减免值</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次清除5点</t></t></t>";

			case "Mercenary_LearnInfo6_add"://增加身法修炼按钮
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>增加侍卫身法修炼</t><b/><t>影响侍卫暴击和闪避的概率</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次增加5点</t></t></t>";

			case "Mercenary_LearnInfo6_dec"://减少身法修炼按钮
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>减少侍卫身法修炼</t><b/><t>影响侍卫暴击和闪避的概率</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次清除5点</t></t></t>";

			case "Mercenary_LearnInfo7"://潜能
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫升级后获得的潜能点</t><b/><t>侍卫每升1级可获得5点潜能</t><b/><t>可自由分配到体力修炼,物攻修炼,法攻修炼,物防修炼,法防修炼,身法六项属性上</t></t>";

			case "Mercenary_LearnInfo1"://体力修炼
				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫体力修炼</t><b/><t>提高侍卫体力上限</t>";

			case "Mercenary_LearnInfo2"://物攻修炼
				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫物攻修炼</t><b/><t>提高侍卫物攻值</t>";

			case "Mercenary_LearnInfo3"://法攻修炼
				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫法攻修炼</t><b/><t>提高侍卫法攻值</t>";

			case "Mercenary_LearnInfo4"://物防修炼
				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫物防修炼</t><b/><t>提高侍卫物防值</t>";

			case "Mercenary_LearnInfo5"://法防修炼
				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫法防修炼</t><b/><t>提高侍卫法防值</t>";

			case "Mercenary_LearnInfo6"://身法修炼
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫身法修炼</t><b/><t>影响侍卫的暴击和闪避几率</t>";

			case "Mercenary_HealthBar"://侍卫体力值
				%ctrl.tooltipWidth = 305;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫体力值</t><b/><t>侍卫当前体力值为0时,侍卫将死亡并收回</t><b/><t>通过【治疗】可以恢复侍卫的当前体力值</t><b/><t>治疗需要消耗金创药,可以在商人处购买</t></t>";

			case "Mercenary_loyaltyBar"://侍卫忠心值
				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫忠心值</t><b/><t>侍卫死亡后或持续出战忠心值会下降</t><b/><t>当忠心值低于60时侍卫将无法召唤</t><b/><t>可【赏赐】给侍卫宝物以提高忠心值</t></t>";

			case "Mercenary_ExpBar"://侍卫经验
				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫经验</t><b/><t>侍卫当前经验值/侍卫升至下一级经验值</t>";

			case "Mercenary_Treat"://侍卫治疗
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>治疗</t><b/><t>点击治疗可增加侍卫的体力值</t><b/><t>背包内需要有相关治疗物品</t>";

			case "Mercenary_Largess"://侍卫赏赐
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>赏赐</t><b/><t>点击赏赐可增加侍卫的快乐度</t><b/><t>背包内需要有侍卫宝物</t>";

			case "Mercenary_Attack1"://内力攻击
				%ctrl.tooltipWidth = 175;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫内力攻击（内力类）</t><b/><t>侍卫的内力伤害值</t>";

			case "Mercenary_Attack2"://物理攻击
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫物理攻击（物理类）</t><b/><t>侍卫的物理伤害值</t>";

			case "Mercenary_Attack3"://法术攻击
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫法术攻击（法术类）</t><b/><t>侍卫的法术伤害值</t>";

			case "Mercenary_Attack4"://物理命中
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫物理命中</t><b/><t>侍卫的物理命中能力</t><b/><t c='0xF450CFff'>物理命中越高则对手闪避你的物理攻击几率越低</t></t>";

			case "Mercenary_Attack5"://法术命中
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫法术命中</t><b/><t>侍卫的法术命中能力</t><b/><t c='0xF450CFff'>法术命中越高则对手闪避你的法术攻击几率越低</t></t>";

			case "Mercenary_Attack6"://物理闪避
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫物理闪避</t><b/><t>侍卫的物理闪避能力</t><b/><t c='0xF450CFff'>物理闪避越高则闪避对手物理攻击几率越高</t></t>";

			case "Mercenary_Attack7"://法术闪避
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫法术闪避</t><b/><t>侍卫的法术闪避能力</t><b/><t c='0xF450CFff'>法术闪避越高则闪避对手法术攻击几率越高</t></t>";

			case "Mercenary_Defence1"://内力防御
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>内力防御</t><b/><t>受到内力攻击伤害时减免相应的伤害</t></t>";

			case "Mercenary_Defence2"://物理防御
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>物理防御</t><b/><t>受到物理攻击伤害时减免相应的伤害</t></t>";

			case "Mercenary_Defence3"://法术防御
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>法术防御</t><b/><t>受到法术攻击伤害时减免相应的伤害</t></t>";

			case "Mercenary_Defence4"://土系抗性
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>土系抗性</t><b/><t>受到土灵攻击伤害时减免相应的伤害</t></t>";

			case "Mercenary_Defence5"://火系抗性
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>火系抗性</t><b/><t>受到火灵攻击伤害时减免相应的伤害</t></t>";

			case "Mercenary_Defence6"://毒系抗性
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>毒系抗性</t><b/><t>受到毒灵攻击伤害时减免相应的伤害</t></t>";

			case "Mercenary_Defence7"://金系抗性
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>金系抗性</t><b/><t>受到金灵攻击伤害时减免相应的伤害</t></t>";

			case "Mercenary_Defence8"://冰系抗性
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>冰系抗性</t><b/><t>受到冰灵攻击伤害时减免相应的伤害</t></t>";

			case "Mercenary_Other1"://其他暴击
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>暴击</t><b/><t>提高角色产生暴击伤害的几率,数值越高暴击几率越大</t></t>";

			case "Mercenary_Other2"://其他坚韧
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>坚韧</t><b/><t>数值越高防止暴击几率就越大</t></t>";

			case "Mercenary_Other3"://其他暴击倍数
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>暴击倍数</t><b/><t>发动暴击伤害后相对普通伤害的增长值</t></t>";

			case "Mercenary_Other4"://其他抗暴击倍数
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>抗暴击倍数</t><b/><t>受到暴击后对暴击伤害的减免</t></t>";

			case "Mercenary_Other5"://其他无视物理防御
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>无视物理防御</t><b/><t>物理攻击时可忽视对方的物理防御</t></t>";

			case "Mercenary_Other6"://其他无视法术防御
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>无视法术防御</t><b/><t>法术攻击时可忽视对方的法术防御</t></t>";

			case "Mercenary_Other7"://其他攻击速度
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>攻击速度</t><b/><t>获得的攻击速度加成</t></t>";

			case "Mercenary_GrowUpInfo1"://体力资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫体力资质</t><b/><t>影响“体力修炼”对侍卫体力值上限的加成</t>";

			case "Mercenary_GrowUpInfo2"://物攻资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫物攻资质</t><b/><t>影响“物攻修炼”对侍卫物攻值的加成</t>";

			case "Mercenary_GrowUpInfo3"://法攻资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫法攻资质</t><b/><t>影响“法攻修炼”对侍卫法攻值的加成</t>";

			case "Mercenary_GrowUpInfo4"://物防资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫物防资质</t><b/><t>影响“物防修炼”对侍卫物防值的加成</t>";

			case "Mercenary_GrowUpInfo5"://法防资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫法防资质</t><b/><t>影响“法防修炼”对侍卫法防值的加成</t>";

			case "Mercenary_GrowUpInfo6"://身法资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫身法资质</t><b/><t>影响“身法修炼”对侍卫闪避值和暴击率的加成</t>";

			case "Mercenary_ExploitBar"://功勋值
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>侍卫功勋值</t><b/><t>尚未开放,敬请期待</t>";

			case "Mercenary_AttriState"://侍卫攻击类型 1武将 2侠客 3羽士 5箭翎 4丹士
				%ctrl.tooltipWidth = 210;
				%nslot = getMerJob($SelectedMercenarySlot);
				if (%nslot== 3){ %HongJi="法术攻击";%JiaDian="<t gct='0x00ff00ff' gcb='0x2cffeeff'>法攻修炼</t><t>越高，伤害输出越高</t>"; }
				else                   { %HongJi="物理攻击";%JiaDian="<t gct='0x00ff00ff' gcb='0x2cffeeff'>物攻修炼</t><t>越高，伤害输出越高</t>"; }

				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>攻击类型："@ %HongJi @"</t><b/><t>"@ %JiaDian @"</t></t>";

				//====================================================================================神兽界面===========================================================================================================

			case "PetInfoGui_ghxz":
				%ctrl.tooltipWidth = 385;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>左键单击,自动寻径到长安慕容心处提升神兽能力</t><b/><t>提升神兽能力有以下方式：</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>1、品阶进阶：</t><t>神兽品阶每提升1点,所有成长资质增加100点</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>2、神兽炼化：</t><t>对根骨大于0的神兽进行炼化获得根骨丹</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>3、神兽精炼：</t><t>将神兽宝宝和变异宝宝精炼获得神兽技能书</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>4、神兽洗炼：</t><t>神兽脱胎换骨到1级,提升一定的成长资质</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>5、神兽繁殖：</t><t>与异性的神兽宝宝繁殖下一代神兽</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>6、神兽技能学习：</t><t>通过参加活动和商城购买获得技能书,通过学习增加神兽的技能</t></t>";


			case "PetInfoWnd_PetShortCut5"://

				if (PetInfoWnd_PetSlot_Image_5.Isvisible())
				{
					%ctrl.tooltipWidth = 220;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>被封的神兽栏位</t><b/><t>使用</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽栏</t><t>激活被封的神兽栏位</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽栏</t><t>可以在昆仑决商城内购买</t></t>";
				}

			case "PetInfoWnd_PetShortCut6"://

				if (PetInfoWnd_PetSlot_Image_6.Isvisible())
				{
					%ctrl.tooltipWidth = 220;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>被封的神兽栏位</t><b/><t>使用</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽栏</t><t>激活被封的神兽栏位</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽栏</t><t>可以在昆仑决商城内购买</t></t>";
				}

			case "PetInfoWnd_PetShortCut7"://

				if (PetInfoWnd_PetSlot_Image_7.Isvisible())
				{
					%ctrl.tooltipWidth = 220;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>被封的神兽栏位</t><b/><t>使用</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽栏</t><t>激活被封的神兽栏位</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽栏</t><t>可以在昆仑决商城内购买</t></t>";
				}


			case "PetInfoWnd_PetShortCut8"://
				if (PetInfoWnd_PetSlot_Image_8.Isvisible())
				{
					%ctrl.tooltipWidth = 220;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>被封的神兽栏位</t><b/><t>使用</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽栏</t><t>激活被封的神兽栏位</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽栏</t><t>可以在昆仑决商城内购买</t></t>";
				}


			case "PetInfoWnd_PetActType"://攻击类型
				%ctrl.tooltipWidth = 210;
				%nslot = PetOperation_GetPetAttackType($PetInfoWnd_PetSlot);
				if (%nslot==0){ %HongJi="物理攻击";%JiaDian="<t>增加</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>力道</t><t>可加强物理攻击效果</t>"; }

				else  { %HongJi="法术攻击";%JiaDian="<t>增加</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>智力</t><t>可加强法术攻击效果</t>"; }

				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>攻击类型："@ %HongJi @"</t><b/><t>"@ %JiaDian @"</t></t>";

			case "PetInfoWnd_PetRank"://潜力
				%ctrl.tooltipWidth = 290;
				%IsIdentify = PetOperation_IsPetIdentify($PetInfoWnd_PetSlot);

				if (%IsIdentify)
				{
					%nChengZhangLv = PetOperation_GetPetChengZhangLv($PetInfoWnd_PetSlot);
					if (%nChengZhangLv >= 18 && %nChengZhangLv < 840){ %PinZhi = "<t c= '0xffffffff'>「普通」</t>"; }
					else if (%nChengZhangLv >= 840 && %nChengZhangLv < 1560){ %PinZhi = "<t c= '0x46ff15ff'>「优秀」</t>"; }
					else if (%nChengZhangLv >= 1560 && %nChengZhangLv < 2220){ %PinZhi = "<t c= '0x226fffff'>「精英」</t>"; }
					else if (%nChengZhangLv >= 2220 && %nChengZhangLv < 2860){ %PinZhi = "<t c= '0xca57ffff'>「完美」</t>"; }
					else if (%nChengZhangLv >= 2860 && %nChengZhangLv < 3300){ %PinZhi = "<t c= '0xff9600ff'>「传说」</t>"; }
					else if (%nChengZhangLv >= 3300){ %PinZhi = "<t c= '0xff1200ff'>「逆天」</t>"; }

					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前神兽潜力为：</t>"@ %PinZhi @"<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>·通过神兽洗炼操作可改变神兽潜力</t><b/><t>普通：神兽加点时获得正常的属性成长</t><b/><t c='0x26da13ff'>优秀：神兽加点时获得额外20%的属性成长</t><b/><t c='0x226fffff'>精英：神兽加点时获得额外40%的属性成长</t><b/><t c='0xca57ffff'>完美：神兽加点时获得额外60%的属性成长</t><b/><t c='0xff9600ff'>传说：神兽加点时获得额外80%的属性成长</t><b/><t c='0xff1200ff'>逆天：神兽加点时获得额外100%的属性成长</t></t>";
				}
				else
				{
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽潜力   </t><t c= '0xff1200ff'>未鉴定</t><b/><t c='0x5adfffff'>可在慕容心处鉴定潜力</t><b/><t>普通：神兽加点时获得正常的属性成长</t><b/><t c='0x26da13ff'>优秀：神兽加点时获得额外20%的属性成长</t><b/><t c='0x226fffff'>精英：神兽加点时获得额外40%的属性成长</t><b/><t c='0xca57ffff'>完美：神兽加点时获得额外60%的属性成长</t><b/><t c='0xff9600ff'>传说：神兽加点时获得额外80%的属性成长</t><b/><t c='0xff1200ff'>逆天：神兽加点时获得额外100%的属性成长</t></t>";
				}

			case "PetInfoWnd_PetDevelopRate"://潜力
				%ctrl.tooltipWidth = 290;

				%IsIdentify = PetOperation_IsPetIdentify($PetInfoWnd_PetSlot);

				if (%IsIdentify)
				{
					%nChengZhangLv = PetOperation_GetPetChengZhangLv($PetInfoWnd_PetSlot);
					if (%nChengZhangLv >= 18 && %nChengZhangLv < 840){ %PinZhi = "<t c= '0xffffffff'>「普通」</t>"; }
					else if (%nChengZhangLv >= 840 && %nChengZhangLv < 1560){ %PinZhi = "<t c= '0x46ff15ff'>「优秀」</t>"; }
					else if (%nChengZhangLv >= 1560 && %nChengZhangLv < 2220){ %PinZhi = "<t c= '0x226fffff'>「精英」</t>"; }
					else if (%nChengZhangLv >= 2220 && %nChengZhangLv < 2860){ %PinZhi = "<t c= '0xca57ffff'>「完美」</t>"; }
					else if (%nChengZhangLv >= 2860 && %nChengZhangLv < 3300){ %PinZhi = "<t c= '0xff9600ff'>「传说」</t>"; }
					else if (%nChengZhangLv >= 3300){ %PinZhi = "<t c= '0xff1200ff'>「逆天」</t>"; }

					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前神兽潜力为：</t>"@ %PinZhi @"<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>·通过神兽洗炼操作可改变神兽潜力</t><b/><t>普通：神兽加点时获得正常的属性成长</t><b/><t c='0x26da13ff'>优秀：神兽加点时获得额外20%的属性成长</t><b/><t c='0x226fffff'>精英：神兽加点时获得额外40%的属性成长</t><b/><t c='0xca57ffff'>完美：神兽加点时获得额外60%的属性成长</t><b/><t c='0xff9600ff'>传说：神兽加点时获得额外80%的属性成长</t><b/><t c='0xff1200ff'>逆天：神兽加点时获得额外100%的属性成长</t></t>";
				}
				else
				{
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽潜力   </t><t c= '0xff1200ff'>未鉴定</t><b/><t c='0x5adfffff'>可在慕容心处鉴定潜力</t><b/><t>普通：神兽加点时获得正常的属性成长</t><b/><t c='0x26da13ff'>优秀：神兽加点时获得额外20%的属性成长</t><b/><t c='0x226fffff'>精英：神兽加点时获得额外40%的属性成长</t><b/><t c='0xca57ffff'>完美：神兽加点时获得额外60%的属性成长</t><b/><t c='0xff9600ff'>传说：神兽加点时获得额外80%的属性成长</t><b/><t c='0xff1200ff'>逆天：神兽加点时获得额外100%的属性成长</t></t>";
				}

			case "PetInfoWnd_PetColligate"://携带等级

				%PetLv = PetOperation_GetPetLevel($PetInfoWnd_PetSlot);
				%NeedLv = PetOperation_GetPetSpawnLevel($PetInfoWnd_PetSlot);
				%playerLv = GetPlayer().getLevel();
				%FinNeedLv = 0;
				if (%PetLv - 10 <= %NeedLv)
					%FinNeedLv = %NeedLv;
				else
					%FinNeedLv = %PetLv - 10;

				if (%playerLv < %FinNeedLv){ %txt ="<b/><t c= '0xff0000ff'>您的角色等级未达到神兽携带等级，无法召唤神兽出战</t>"; }

				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽携带等级</t><b/><t>角色等级大于等于携带等级，才能携带神兽</t>"@ %txt @"</t>";

			case "PetInfoWnd_NeedPlayerLevel"://携带等级

				%PetLv = PetOperation_GetPetLevel($PetInfoWnd_PetSlot);
				%NeedLv = PetOperation_GetPetSpawnLevel($PetInfoWnd_PetSlot);
				%playerLv = GetPlayer().getLevel();
				%FinNeedLv = 0;
				if (%PetLv - 10 <= %NeedLv)
					%FinNeedLv = %NeedLv;
				else
					%FinNeedLv = %PetLv - 10;

				if (%playerLv < %FinNeedLv){ %txt ="<b/><t c= '0xff0000ff'>您的角色等级未达到神兽携带等级，无法召唤神兽出战</t>"; }

				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽携带等级</t><b/><t>角色等级大于等于携带等级，才能携带神兽</t>"@ %txt @"</t>";

			case "PetInfoWnd_PetName"://神兽名称
				%ctrl.tooltipWidth = 120;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽名字</t><b/><t>神兽可以改名</t></t>";

			case "PetInfoWnd_CnangeNameButton"://改名按钮
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽改名确认</t><b/><t>神兽名字最长为八个汉字</t><b/><t>鼠标激活神兽名称显示框,输入神兽新名称后,需点击改名按钮确认</t></t>";

			case "PetInfoWnd_PetTitle"://神兽称号
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽称号</t><b/><t>当神兽的品阶、潜力、资质达到一定条件,即可在神兽训练师-</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>慕容心</t><t>处领取称号</t></t>";

			case "PetInfoWnd_PetLevel"://神兽等级
				%ctrl.tooltipWidth = 120;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽等级</t><b/><t>神兽当前的等级</t></t>";

			case "PetInfoWnd_PetStatus"://神兽状态
				%nStatus = PetOperation_GetPetStatus($PetInfoWnd_PetSlot);
				if (%nStatus == 1){ %PetStatus = "出战状态"; }
				else if (%nStatus == 2){ %PetStatus = "合体状态"; }
				else if (%nStatus == 4)
				{
					%PetStatus = "修行状态";
					%nLeftTime = TimerCtrlMgr_GetPetStudyLeftTime($PetInfoWnd_PetSlot);

					%minute = %nLeftTime % 60;
					%hour = (%nLeftTime - %minute) / 60;
					if (%nLeftTime >=60)     { %Time = "<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>修行剩余时间："@ %hour @ "小时" @ %minute @ "分钟</t>"; }
					else if (%nLeftTime >= 1){ %Time = "<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>修行剩余时间："@ %minute @ "分钟</t>"; }
					else if (%nLeftTime < 1) { %Time = "<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>修行剩余时间：小于1分钟</t>"; }
				}
				else if (%nStatus == 7){ %PetStatus = "繁殖中状态";%Time ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>整个繁殖过程会持续2个小时,完成繁殖后,双方需与慕容心对话领取二代神兽宝宝</t>"; }
				else if (%nStatus == 8){ %PetStatus = "繁殖完成状态";%Time ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>当前您的神兽已经繁殖完成,双方前往慕容心对话即可领取二代神兽宝宝</t>"; }

				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽处于"@ %PetStatus @"</t><b/><t>"@ %PetStatus @"的神兽将不能进行放生、交易、炼化、鉴定等操作</t>"@ %Time @"</t>";


				//		case "PetInfoWnd_PetRace"://神兽种族
				//			%nType = PetOperation_GetPetType($PetInfoWnd_PetSlot);
				//			if(%nType ==0 ){%PetType = "人形";}
				//			else if(%nType ==1 ){%PetType = "水族";}
				//			else if(%nType ==2 ){%PetType = "妖兽";}
				//			else if(%nType ==3 ){%PetType = "特殊";}
				//			else if(%nType ==4 ){%PetType = "幽冥";}
				//			else if(%nType ==5 ){%PetType = "植物";}
				//			else if(%nType ==6 ){%PetType = "飞禽";}
				//			else if(%nType ==7 ){%PetType = "上古";}
				//			else if(%nType ==8 ){%PetType = "走兽";}
				//			else if(%nType ==9 ){%PetType = "昆虫";}
				//			%ctrl.tooltipWidth = 130;
				//			%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽类型为"@ %PetType @"</t></t>";
				//

			case "PetInfoWnd_TuJianButton":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽图鉴</t><b/><t>点击可显示该类神兽所有变异的神兽属性</t></t>";

			case "PetInfoWnd_Duoming"://神兽的夺名按钮
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽的争榜夺名</t><b/><t>将您拥有的极品神兽上传至排行榜内排名</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽属性提升后需再次上传，系统才能更新您的神兽排名信息</t></t>";

			case "PetInfoWnd_Bnt_Evaluation"://神兽评价按钮
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽资质评价</t><b/><t>将您当前的神兽资质属性更加直观的显示</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽资质信息页可了解同类别神兽的资质比较</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>同级别资质信息页可了解相同级别神兽的资质比较</t></t>";

			case "PetInfoWnd_PetPaiMing"://神兽排名
				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽排名</t><b/><t>在排行榜异兽栏内可查看到其他神兽的综合值排名</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >神兽需手动上传至排行榜内，神兽属性提升后需再次上传，系统才能更新您的神兽排名信息</t></t>";

			case "PetInfoWnd_PetPaiMing"://神兽排名
				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽排名</t><b/><t>在排行榜异兽栏内可查看到其他神兽的综合值排名</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >神兽需手动上传至排行榜内，神兽属性提升后需再次上传，系统才能更新您的神兽排名信息</t></t>";

			case "PetInfoWnd_PetOpen"://神兽召唤
				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>召唤神兽</t><b/><t>只可召唤不大于角色1修的神兽</t><b/><t>神兽品阶每升1点,要求角色等级提高1级</t></t>";

			case "PetInfoWnd_PetClose"://取消召唤
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>收回神兽</t><b/><t>只可召唤不大于角色1修的神兽</t></t>";

			case "PetInfoWnd_PetSkill"://神兽技能栏
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽技能页</t><b/><t>神兽的被动技能以及玩家手动释放的技能</t><b/><t>通过参加活动和商城购买获得神兽技能书,在慕容心那可让神兽学会技能书技能</t></t>";

			case "PetInfoWnd_PetAbility"://神兽能力栏
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽能力页</t><b/><t>神兽升级有一定几率可以领悟神兽能力</t><b/><t>调整神兽能力图标可以改变性格爆发时能力的释放顺序</t></t>";

			case "PetInfoWnd_HP"://神兽体力值
				%ctrl.tooltipWidth = 305;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽体力值</t><b/><t>神兽当前体力值为0时,神兽将死亡并收回</t><b/><t>通过【治疗】可以恢复神兽的当前体力值</t><b/><t>治疗需要消耗血丹,可以在神兽商人处购买</t></t>";

				//		case "PetInfoWnd_MP"://神兽精力值
				//			%ctrl.tooltipWidth = 305;
				//			%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽精力值</t><b/><t>神兽施放技能时需要消耗精力值</t><b/><t>点击【补气】可以恢复神兽的当前精力值</t><b/><t>补气需要消耗岚灵石,可以在神兽商人处购买</t></t>";

			case "PetInfoWnd_Happy"://神兽快乐
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽快乐度</t><b/><t>神兽死亡后快乐度会下降</t><b/><t>当快乐度低于60时神兽将无法召唤</t><b/><t>可在神兽商人处购买神兽玩具增加神兽快乐度</t></t>";

			case "PetInfoWnd_Exp"://神兽经验
				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽经验</t><b/><t>神兽当前经验值/神兽升至下一级经验值</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>当神兽等级大于等于角色等级5级时，神兽将无法再获得神兽经验</t></t>";

			case "PetInfoWnd_PetFeeding1"://神兽治疗
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>治疗</t><b/><t>点击治疗可增加神兽的体力值</t><b/><t>背包内需要有相关治疗物品</t></t>";

				//		case "PetInfoWnd_PetFeeding2"://神兽补气
				//			%ctrl.tooltipWidth = 210;
				//			%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>补气</t><b/><t>点击补气可增加神兽的精力值</t><b/><t>背包内需要有相关补气物品</t></t>";

			case "PetInfoWnd_PetDomestication"://神兽赏赐
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>赏赐</t><b/><t>点击赏赐可增加神兽的快乐度</t><b/><t>背包内需要有神兽玩具物品</t></t>";

			case "PetInfoWnd_PetSetFree"://神兽放生
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽放生</t><b/><t>放生后的神兽将从神兽栏消失。安全时间、出战、合体、修行、鉴定等状态下的神兽无法放生</t></t>";

			case "PetInfoWnd_PetLock"://神兽锁定
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽锁定</t><b/><t>对神兽进行加锁</t><b/><t>神兽加锁后将不能被放生及交易</t></t>";

			case "PetInfoWnd_PetStudy"://神兽修行
				%ctrl.tooltipWidth = 225;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽修行</t><b/><t>处于空闲状态的神兽可进行相应的修行</t></t>";

			case "HeTiAttribute_bmp"://合体属性文字的说明       
				%nPetHTshuxing = Pet_getCombinationInfo($PetInfoWnd_PetSlot);//获取当前选中神兽的合体附加属性
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' c='0xf3d300ff' o='0x010101ff'>神兽合体附加属性：</t><b/>"@ %nPetHTshuxing @"<b/><t m='1' f='宋体' n='12'>神兽的</t><t m='1' f='宋体' n='12' gct='0x00ff00ff' gcb='0x2cffeeff'>等级、品阶、资质、潜力、变异等级、技能个数</t><t m='1' f='宋体' n='12'>都会影响合体附加的属性大小</t>";


			case "PetInfoWnd_PetPatron"://神兽合体附加属性说明       
				%nPetHTshuxing = Pet_getCombinationInfo($PetInfoWnd_PetSlot);//获取当前选中神兽的合体附加属性
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' c='0xf3d300ff' o='0x010101ff'>神兽合体附加属性：</t><b/>"@ %nPetHTshuxing @"<b/><t m='1' f='宋体' n='12'>神兽的</t><t m='1' f='宋体' n='12' gct='0x00ff00ff' gcb='0x2cffeeff'>等级、品阶、资质、潜力、变异等级、技能个数</t><t m='1' f='宋体' n='12'>都会影响合体附加的属性大小</t>";

			case "PetInfoWnd_Tooltip1"://品阶
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>品阶</t><b/><t>品阶每提升1点，所有成长资质增加100点。</t><b/><t>提升品阶需要消耗灵慧果。</t></t>";

			case "PetInfoWnd_Tooltip2"://根骨
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽根骨</t><b/><t>影响神兽炼化后获得的灵慧果。</t><b/><t>灵慧果可以增加神兽品阶，提高神兽的成长资质。</t></t>";

			case "PetInfoWnd_Tooltip3"://智力
				%mainAttri =GetMainAttribute($PetInfoWnd_PetSlot);//1 体魄 2 智力 3 力道

				%nslot = PetOperation_GetPetAttackType($PetInfoWnd_PetSlot);
				if (%nslot == 0)
				{
					if (%mainAttri == 3){ %mainAttri1="</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>[推荐主加]"; }
					%ctrl.tooltipWidth = 160;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽力道  "@ %mainAttri1 @"</t><b/><t>提高神兽物理攻击伤害</t></t>";
				}
				else
				{
					if (%mainAttri == 2){ %mainAttri1="</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>[推荐主加]"; }
					%ctrl.tooltipWidth = 160;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽智力  "@ %mainAttri1 @"</t><b/><t>提高神兽法术攻击伤害</t></t>";
				}

			case "PetInfoWnd_Tooltip5"://体魄
				%mainAttri =GetMainAttribute($PetInfoWnd_PetSlot);//1 体魄 2 智力 3 力道
				if (%mainAttri == 1){ %mainAttri1="</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>[推荐主加]"; }

				%ctrl.tooltipWidth = 175;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽体魄  "@ %mainAttri1 @"</t><b/><t>提高神兽体力最大值</t></t>";

			case "PetInfoWnd_Tooltip6"://精神
				%ctrl.tooltipWidth = 165;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽精神  "@ %mainAttri1 @"</t><b/><t>提高神兽物理防御、法术防御</t></t>";

			case "PetInfoWnd_Tooltip7"://身法
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽身法</t><b/><t>影响神兽的闪避和暴击几率</t></t>";

			case "PetInfoWnd_Tooltip8"://内力
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽内力</t><b/><t>提高神兽内力伤害</t></t>";

			case "PetInfoWnd_Tooltip9"://潜力
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽升级后获得的潜力点</t><b/><t>神兽每升1级可获得5点潜力</t><b/><t>可自由分配到体魄、精神、力道、智力、身法五项属性上</t></t>";

			case "PetInfoWnd_Tooltip10"://变异等级
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>最高变异等级：</t><b/><t>变异等级越高，神兽的属性越高，血量越高。宠物在特定变异等级会改变外形。</t><b/><t>可以通过吞噬精魄灵珠或者别的神兽来提升变异等级。</t></t>";

			case "PetInfoWnd_PetHuiGen"://品阶
				%ctrl.tooltipWidth = 320;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽品阶</t><b/><t>品阶每提升1点,所有成长资质增加100点</t><b/><t>神兽达到1修后即可到慕容心处进行品阶提升</t><b/><t>进阶需要消耗根骨丹,通过炼化具有根骨的神兽可以获得根骨丹</t></t>";

			case "PetInfoWnd_PetGenGu"://根骨
				%ctrl.tooltipWidth = 310;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽根骨</t><b/><t>影响神兽炼化后获得的根骨丹</t><b/><t>根骨丹可以增加神兽品阶,提高神兽的成长资质</t></t>";

			case "PetInfoWnd_PetTiPo"://体魄
				%mainAttri =GetMainAttribute($PetInfoWnd_PetSlot);//1 体魄 2 智力 3 力道
				if (%mainAttri == 1){ %mainAttri1="</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>[推荐主加]"; }

				%ctrl.tooltipWidth = 155;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽体魄 "@ %mainAttri1 @"</t><b/><t>提高神兽体力最大值</t></t>";

			case "PetInfoWnd_PetJingLi"://精力
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽精神</t><b/><t>提高神兽物理防御、法术防御</t></t>";

			case "PetInfoWnd_PetLiDao"://神兽 攻击属性，力道OR智力
				%mainAttri =GetMainAttribute($PetInfoWnd_PetSlot);//1 体魄 2 智力 3 力道
				%nslot = PetOperation_GetPetAttackType($PetInfoWnd_PetSlot);
				if (%nslot==0)
				{
					if (%mainAttri == 3)
					{
						%mainAttri1="<t gct='0x00ff00ff' gcb='0x2cffeeff'>[推荐主加]</t><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽力道</t><b/><t>增加神兽物理攻击最大值，提高神兽法术攻击伤害</t>";
					}
					else if (%mainAttri == 1)
					{
						%mainAttri1="<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽力道</t><b/><t>增加神兽物理攻击最大值，提高神兽物理攻击伤害</t>";
					}
				}
				else {
					if (%mainAttri == 2)
					{
						%mainAttri1="<t gct='0x00ff00ff' gcb='0x2cffeeff'>[推荐主加]</t><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽智力</t><b/><t>增加神兽法术攻击最大值，提高神兽法术攻击伤害</t>";
					}
					else if (%mainAttri == 1)
					{
						%mainAttri1="<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽智力</t><b/><t>增加神兽法术攻击最大值，提高神兽法术攻击伤害</t>";
					}
				}
				%ctrl.tooltipWidth = 175;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'>"@ %mainAttri1 @"</t>";


			case "PetInfoWnd_PetLingLi"://智力
				%mainAttri =GetMainAttribute($PetInfoWnd_PetSlot);//1 体魄 2 智力 3 力道
				if (%mainAttri == 2){ %mainAttri1="</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>[推荐主加]"; }
				%ctrl.tooltipWidth = 175;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽智力  "@ %mainAttri1 @"</t><b/><t>增加神兽法术攻击最大值，提高神兽法术攻击伤害</t></t>";

			case "PetInfoWnd_PetMingJie"://身法
				%ctrl.tooltipWidth = 195;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽身法</t><b/><t>影响神兽的闪避和暴击几率</t></t>";

			case "PetInfoWnd_PetYuanLi"://内力
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽内力</t><b/><t>提高神兽内力伤害</t></t>";

			case "PetInfoWnd_PetQianLi"://潜力
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽升级后获得的潜力点</t><b/><t>神兽每升1级可获得5点潜力</t><b/><t>可自由分配到体魄、精神、力道、智力、身法五项属性上</t></t>";

			case "PetInfoWnd_PetTiPoAdd"://增加体魄按钮
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>增加神兽体魄</t><b/><t>影响神兽体力最大值</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次增加5点</t></t>";

			case "PetInfoWnd_PetTiPoDec"://减少体魄按钮
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>减少神兽体魄</t><b/><t>影响神兽体力最大值</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次清除5点</t></t></t>";

			case "PetInfoWnd_PetJingLiAdd"://增加精力按钮
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>增加神兽精神</t><b/><t>影响神兽物理防御、法术防御</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次增加5点</t></t></t>";

			case "PetInfoWnd_PetJingLiDec"://减少精力按钮
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>减少神兽精神</t><b/><t>影响神兽物理防御、法术防御</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次清除5点</t></t></t>";

			case "PetInfoWnd_PetLiDaoAdd"://增加力道按钮
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>增加神兽力道</t><b/><t>影响神兽物理攻击最大值</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次增加5点</t></t></t>";

			case "PetInfoWnd_PetLiDaoDec"://减少力道按钮
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>减少神兽力道</t><b/><t>影响神兽物理攻击最大值</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次清除5点</t></t></t>";

			case "PetInfoWnd_PetLingLiAdd"://增加智力按钮
				%ctrl.tooltipWidth = 170;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>增加神兽智力</t><b/><t>影响神兽法术攻击伤害</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次增加5点</t></t></t>";

			case "PetInfoWnd_PetLingLiDec"://减少智力按钮
				%ctrl.tooltipWidth = 170;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>减少神兽智力</t><b/><t>影响神兽法术攻击伤害</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次清除5点</t></t></t>";

			case "PetInfoWnd_PetMingJieAdd"://增加身法按钮
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>增加神兽身法</t><b/><t>影响神兽的闪避和暴击几率</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次增加5点</t></t></t>";

			case "PetInfoWnd_PetMingJieDec"://减少身法按钮
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>减少神兽身法</t><b/><t>影响神兽的闪避和暴击几率</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次清除5点</t></t></t>";

			case "PetInfoWnd_PetYuanLiAdd"://增加内力按钮
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>增加神兽内力</t><b/><t>影响神兽内力攻击</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次增加5点</t></t></t>";

			case "PetInfoWnd_PetYuanLiDec"://减少内力按钮
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>减少神兽内力</t><b/><t>影响神兽内力攻击</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击一次清除5点</t></t></t>";

			case "Attack_Physics"://物理攻击
				%ctrl.tooltipWidth = 175;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽物理攻击（物理类）</t><b/><t>神兽的物理伤害值</t></t>";

			case "Attack_YuanLi"://法术攻击
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽法术攻击（法术类）</t><b/><t>神兽的法术伤害值</t></t>";

			case "Attack_NeiLi"://内力攻击
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽内力攻击</t><b/><t>神兽的内力伤害值</t></t>";

			case "Attack_Mu"://木
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽物理命中</t><b/><t>神兽的物理命中能力</t><b/><t c='0xF450CFff'>物理命中越高则对手闪避你的物理攻击几率越低</t></t>";

			case "Attack_Huo"://火
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽法术命中</t><b/><t>神兽的法术命中能力</t><b/><t c='0xF450CFff'>法术命中越高则对手闪避你的法术攻击几率越低</t></t>";

			case "Attack_Shui"://水
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽物理闪避</t><b/><t>神兽的物理闪避能力</t><b/><t c='0xF450CFff'>物理闪避越高则闪避对手物理攻击几率越高</t></t>";

			case "Attack_Jin"://金
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽法术闪避</t><b/><t>神兽的法术闪避能力</t><b/><t c='0xF450CFff'>法术闪避越高则闪避对手法术攻击几率越高</t></t>";

			case "Attack_Tu"://土
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽土系攻击（法术类）</t><b/><t>神兽的土系攻击伤害能力</t><b/><t c='0xF450CFff'>土系攻击受五灵法术和土灵伤害影响</t></t>";

			case "Recovery_Physics"://内力防御
				%ctrl.tooltipWidth = 275;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽内力防御</t><b/><t>抵御内力伤害</t></t>";

			case "Recovery_YuanLi"://物理防御
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽物理防御</t><b/><t>受到物理攻击时减免相应的伤害</t><b/><t c='0xF450CFff'>神兽物理防御受物理防御影响</t></t>";

			case "Recovery_Mu"://木防御
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽法术防御</t><b/><t>受到法术攻击时减免相应的伤害</t><b/><t c='0xF450CFff'>神兽法术防御受法术防御影响</t></t>";

			case "Recovery_Huo"://火防御
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽火灵抗性</t><b/><t>抵御火系攻击造成的伤害</t><b/><t c='0xF450CFff'>受神兽装备上法术防御和火灵抗性影响</t></t>";

			case "Recovery_Shui"://水防御
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽水灵抗性</t><b/><t>抵御冰系攻击造成的伤害</t><b/><t c='0xF450CFff'>受神兽装备上法术防御和水灵抗性影响</t></t>";

			case "Recovery_Jin"://金防御
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽金灵抗性</t><b/><t>抵御金系攻击造成的伤害</t><b/><t c='0xF450CFff'>受神兽装备上法术防御和金灵抗性影响</t></t>";

			case "Recovery_Tu"://土防御
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽土灵抗性</t><b/><t>抵御土系攻击造成的伤害</t><b/><t c='0xF450CFff'>受神兽装备上法术防御和土灵抗性影响</t></t>";

			case "Other_BaoJiLv"://暴击倍数

				%ctrl.tooltipWidth = 165;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽暴击倍数</t><b/><t>发动暴击伤害后相对普通伤害的增长值</t></t>";

			case "Other_ShanBi"://闪避
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽闪避</t><b/><t>闪避值越高则有更高的机会闪避对手攻击</t></t>";

			case "Other_BaoJi"://暴击
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽暴击</t><b/><t>让神兽发动暴击伤害,暴击通常比普通伤害高</t></t>";

			case "Other_ZhiLiao"://治疗
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽治疗</t><b/><t>神兽所能提高的治疗值</t></t>";

			case "MoveWnd2_TiPo"://体魄资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽体魄资质</t><b/><t>影响“体魄”对神兽体力值上限的加成</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>通过神兽洗炼可改变神兽成长资质</t></t>";

			case "MoveWnd2_JingLi"://精力资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽精神资质</t><b/><t>影响“精神”对神兽物理防御、法术防御的加成</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>通过神兽洗炼可改变神兽成长资质</t></t>";

			case "MoveWnd2_LiDao"://力道资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽力道资质</t><b/><t>影响“力道”对神兽物理攻击的加成</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>通过神兽洗炼可改变神兽成长资质</t></t>";

			case "MoveWnd2_LingLi"://智力资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽智力资质</t><b/><t>影响“智力”对神兽五行攻击的加成</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>通过神兽洗炼可改变神兽成长资质</t></t>";

			case "MoveWnd2_MinJie"://身法资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽身法资质</t><b/><t>影响“身法”对神兽闪避和暴击的加成</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>通过神兽洗炼可改变神兽成长资质</t></t>";

			case "MoveWnd3_1"://正直
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>正直性格</t><b/><t>性格等级越高，受正直性格影响的技能释放几率就越高</t><b/><t>正直性格爆发时，正直性格影响的技能释放几率是100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽修行可以改变性格阶段</t></t>";

			case "MoveWnd3_2"://活泼
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>活泼性格</t><b/><t>性格等级越高，受活泼性格影响的技能释放几率就越高</t><b/><t>活泼性格爆发时，活泼性格影响的技能释放几率是100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽修行可以改变性格阶段</t></t>";

			case "MoveWnd3_3"://稳重
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>稳重性格</t><b/><t>性格等级越高，受稳重性格影响的技能释放几率就越高</t><b/><t>稳重性格爆发时，稳重性格影响的技能释放几率是100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽修行可以改变性格阶段</t></t>";

			case "MoveWnd3_4"://勇猛
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>勇猛性格</t><b/><t>性格等级越高，受勇猛性格影响的技能释放几率就越高</t><b/><t>勇猛性格爆发时，勇猛性格影响的技能释放几率是100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽修行可以改变性格阶段</t></t>";

			case "MoveWnd3_5"://冷静
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>冷静性格</t><b/><t>性格等级越高，受冷静性格影响的技能释放几率就越高</t><b/><t>冷静性格爆发时，冷静性格影响的技能释放几率是100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽修行可以改变性格阶段</t></t>";

			case "MoveWnd4_SelfID"://神兽ID
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽ID</t><b/><t>每只神兽只有唯一的神兽ID</t></t>";

			case "MoveWnd4_SpouseID"://配偶ID
				%nGeneration = PetOperation_GetPetGeneration($PetInfoWnd_PetSlot);
				%nStyle = PetOperation_GetPetStyle($PetInfoWnd_PetSlot);
				%Dengji = PetOpreation_GetBreedLvLimit($PetInfoWnd_PetSlot);


				if ((%nGeneration == 1)&&(%nStyle ==1))//是否为神兽宝宝和一代神兽宝宝
				{
					%ctrl.tooltipWidth = 280;
					if (MoveWnd4_SpouseID.GetText()==0)//是否已繁殖
					{
						%txt1 = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>单身，可繁殖后代</t>";
						%txt2 = "可以寻找异性宝宝繁殖下一代神兽，再次繁殖需在上次繁殖的等级上提升2修，而且必须与同一个配偶繁殖下一代";
						%txt3 = "<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>可繁殖等级为："@ %Dengji @"级</t>";
					}
					else
					{
						%txt1 = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>已婚，已繁殖</t>";
						%txt2 = "可以寻找异性宝宝繁殖下一代神兽，再次繁殖需在上次繁殖的等级上提升2修，而且必须与同一个配偶繁殖下一代";
						%txt3 = "<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>可繁殖等级为："@ %Dengji @"级</t>";
					}
				}
				else
				{
					%ctrl.tooltipWidth = 220;
					%txt1 = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>无繁殖能力</t>";
					%txt2 = "只有一代神兽宝宝才能繁殖后代";
				}

				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>配偶ID  </t>"@ %txt1 @"<b/><t>"@ %txt2 @"</t>"@ %txt3 @"</t>";


			case "PetSkillBar_PetExp"://神兽经验
				%nSpawnedPetSlot = GetPlayer().GetSpawnedPetSlot();
				%nPetCurExp = PetOperation_GetPetExp(%nSpawnedPetSlot);
				%nPetMaxExp = PetOperation_GetPetMaxExp(%nSpawnedPetSlot);
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽经验</t><b/><t>经验值："@ %nPetCurExp @"/"@ %nPetMaxExp @"</t></t>";

			case "PetSkillBar_SkillBtn"://神兽技能
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽技能</t><b/><t>神兽的被动技能以及玩家手动释放的技能</t><b/><t>通过参加活动和商城购买获得神兽技能书,在慕容心那可让神兽学会技能书技能</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击切换为神兽能力</t></t>";

			case "PetSkillBar_AbilityBtn"://神兽能力
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽能力</t><b/><t>神兽升级有一定几率可以领悟神兽能力</t><b/><t>调整神兽能力图标可以改变性格爆发时能力的释放顺序</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击切换为神兽技能</t></t>";

			case "PetSkillBar_MaxBtn"://神兽快捷栏放大
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>展开神兽技能栏</t><b/><t>左键单击可将神兽技能栏显示为展开状态</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>按住左边神兽图标可拖动神兽技能栏</t></t>";

			case "PetSkillBar_MinBtn"://神兽快捷栏缩小
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>隐藏神兽技能栏</t><b/><t>左键单击可将神兽技能栏显示为缩小状态</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>左键长按左边神兽头像可拖动神兽技能栏</t></t>";
				//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			case "PetEvaluationWnd_Pg1_Xing1"://五星体魄资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽体魄资质</t><b/><t>影响“体魄”对神兽体力值上限的加成</t></t>";

			case "PetEvaluationWnd_Pg1_Xing2"://精力资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽精神资质</t><b/><t>影响“精神”对神兽物理防御、法术防御</t></t>";

			case "PetEvaluationWnd_Pg1_Xing3"://力道资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽力道资质</t><b/><t>影响“力道”对神兽物理攻击的加成</t></t>";

			case "PetEvaluationWnd_Pg1_Xing4"://智力资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽智力资质</t><b/><t>影响“智力”对神兽五行攻击的加成</t></t>";

			case "PetEvaluationWnd_Pg1_Xing5"://身法资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽身法资质</t><b/><t>影响“身法”对神兽闪避和暴击的加成</t></t>";

			case "PetEvaluationWnd_Pg1_Xing6"://内力资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽内力资质</t><b/><t>影响“内力”对神兽内力攻击的加成</t></t>";

			case "PetEvaluationWnd_Pg2_Xing1"://体魄资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽体魄资质</t><b/><t>影响“体魄”对神兽体力值上限的加成</t></t>";

			case "PetEvaluationWnd_Pg2_Xing2"://精力资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽精神资质</t><b/><t>影响“精神”对神兽物理防御、法术防御</t></t>";

			case "PetEvaluationWnd_Pg2_Xing3"://力道资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽力道资质</t><b/><t>影响“力道”对神兽物理攻击的加成</t></t>";

			case "PetEvaluationWnd_Pg2_Xing4"://智力资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽智力资质</t><b/><t>影响“智力”对神兽五行攻击的加成</t></t>";

			case "PetEvaluationWnd_Pg2_Xing5"://身法资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽身法资质</t><b/><t>影响“身法”对神兽闪避和暴击的加成</t></t>";

			case "PetEvaluationWnd_Pg2_Xing6"://内力资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽内力资质</t><b/><t>影响“内力”对神兽内力攻击的加成</t></t>";
				//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
			case "PetEvaluationWnd_Bmp_Tipo1"://六边形体魄资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽体魄资质</t><b/><t>影响“体魄”对神兽体力值上限的加成</t></t>";

			case "PetEvaluationWnd_Bmp_Jingli1"://精力资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽精神资质</t><b/><t>影响“精神”对神兽物理防御、法术防御</t></t>";

			case "PetEvaluationWnd_Bmp_Lidao1"://力道资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽力道资质</t><b/><t>影响“力道”对神兽物理攻击的加成</t></t>";

			case "PetEvaluationWnd_Bmp_Lingli1"://智力资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽智力资质</t><b/><t>影响“智力”对神兽五行攻击的加成</t></t>";

			case "PetEvaluationWnd_Bmp_Minjie1"://身法资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽身法资质</t><b/><t>影响“身法”对神兽闪避和暴击的加成</t></t>";

			case "PetEvaluationWnd_Bmp_Yuanli1"://内力资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽内力资质</t><b/><t>影响“内力”对神兽内力攻击的加成</t></t>";

			case "PetEvaluationWnd_Bmp_Tipo2"://六边形体魄资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽体魄资质</t><b/><t>影响“体魄”对神兽体力值上限的加成</t></t>";

			case "PetEvaluationWnd_Bmp_Jingli2"://精神资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽精神资质</t><b/><t>影响“精神”对神兽物理防御、法术防御</t></t>";

			case "PetEvaluationWnd_Bmp_Lidao2"://力道资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽力道资质</t><b/><t>影响“力道”对神兽物理攻击的加成</t></t>";

			case "PetEvaluationWnd_Bmp_Lingli2"://智力资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽智力资质</t><b/><t>影响“智力”对神兽五行攻击的加成</t></t>";

			case "PetEvaluationWnd_Bmp_Minjie2"://身法资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽身法资质</t><b/><t>影响“身法”对神兽闪避和暴击的加成</t></t>";

			case "PetEvaluationWnd_Bmp_Yuanli2"://内力资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽内力资质</t><b/><t>影响“内力”对神兽内力攻击的加成</t></t>";

			case "PetEvaluationWnd_MainIcon"://主力属性
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>推荐主加属性标识</t><b/><t>根据神兽资质而推荐的主加属性会有此标识</t></t>";


				//====================================================================================查看神兽界面==========================================================================================================
			case "OtherPetInfoWnd_PetRank"://潜力
				%ctrl.tooltipWidth = 290;

				%IsIdentify = Other_IsPetIdentify();

				if (%IsIdentify)
				{
					%nChengZhangLv = Other_GetPetChengZhangLv();

					if (%nChengZhangLv >= 18 && %nChengZhangLv < 840){ %PinZhi = "<t c= '0xffffffff'>「普通」</t>"; }
					else if (%nChengZhangLv >= 840 && %nChengZhangLv < 1560){ %PinZhi = "<t c= '0x46ff15ff'>「优秀」</t>"; }
					else if (%nChengZhangLv >= 1560 && %nChengZhangLv < 2220){ %PinZhi = "<t c= '0x226fffff'>「精英」</t>"; }
					else if (%nChengZhangLv >= 2220 && %nChengZhangLv < 2860){ %PinZhi = "<t c= '0xca57ffff'>「完美」</t>"; }
					else if (%nChengZhangLv >= 2860 && %nChengZhangLv < 3300){ %PinZhi = "<t c= '0xff9600ff'>「传说」</t>"; }
					else if (%nChengZhangLv >= 3300){ %PinZhi = "<t c= '0xff1200ff'>「逆天」</t>"; }

					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前神兽潜力为：</t>"@ %PinZhi@"<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>·通过神兽洗炼操作可改变神兽潜力</t><b/><t>普通：神兽加点时获得正常的属性成长</t><b/><t c='0x26da13ff'>优秀：神兽加点时获得额外20%的属性成长</t><b/><t c='0x226fffff'>精英：神兽加点时获得额外40%的属性成长</t><b/><t c='0xca57ffff'>完美：神兽加点时获得额外60%的属性成长</t><b/><t c='0xff9600ff'>传说：神兽加点时获得额外80%的属性成长</t><b/><t c='0xff1200ff'>逆天：神兽加点时获得额外100%的属性成长</t></t>";
				}
				else
				{
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽潜力   </t><t c= '0xff1200ff'>未鉴定</t><b/><t c='0x5adfffff'>可在慕容心处鉴定潜力</t><b/><t>普通：神兽加点时获得正常的属性成长</t><b/><t c='0x26da13ff'>优秀：神兽加点时获得额外20%的属性成长</t><b/><t c='0x226fffff'>精英：神兽加点时获得额外40%的属性成长</t><b/><t c='0xca57ffff'>完美：神兽加点时获得额外60%的属性成长</t><b/><t c='0xff9600ff'>传说：神兽加点时获得额外80%的属性成长</t><b/><t c='0xff1200ff'>逆天：神兽加点时获得额外100%的属性成长</t></t>";
				}

			case "OtherPetInfoWnd_PetDevelopRate"://潜力
				%ctrl.tooltipWidth = 290;

				%IsIdentify = Other_IsPetIdentify();

				if (%IsIdentify)
				{
					%nChengZhangLv = Other_GetPetChengZhangLv();

					if (%nChengZhangLv >= 18 && %nChengZhangLv < 840){ %PinZhi = "<t c= '0xffffffff'>「普通」</t>"; }
					else if (%nChengZhangLv >= 840 && %nChengZhangLv < 1560){ %PinZhi = "<t c= '0x46ff15ff'>「优秀」</t>"; }
					else if (%nChengZhangLv >= 1560 && %nChengZhangLv < 2220){ %PinZhi = "<t c= '0x226fffff'>「精英」</t>"; }
					else if (%nChengZhangLv >= 2220 && %nChengZhangLv < 2860){ %PinZhi = "<t c= '0xca57ffff'>「完美」</t>"; }
					else if (%nChengZhangLv >= 2860 && %nChengZhangLv < 3300){ %PinZhi = "<t c= '0xff9600ff'>「传说」</t>"; }
					else if (%nChengZhangLv >= 3300){ %PinZhi = "<t c= '0xff1200ff'>「逆天」</t>"; }

					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前神兽潜力为：</t>"@ %PinZhi@"<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>·通过神兽洗炼操作可改变神兽潜力</t><b/><t>普通：神兽加点时获得正常的属性成长</t><b/><t c='0x26da13ff'>优秀：神兽加点时获得额外20%的属性成长</t><b/><t c='0x226fffff'>精英：神兽加点时获得额外40%的属性成长</t><b/><t c='0xca57ffff'>完美：神兽加点时获得额外60%的属性成长</t><b/><t c='0xff9600ff'>传说：神兽加点时获得额外80%的属性成长</t><b/><t c='0xff1200ff'>逆天：神兽加点时获得额外100%的属性成长</t></t>";
				}
				else
				{
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽潜力   </t><t c= '0xff1200ff'>未鉴定</t><b/><t c='0x5adfffff'>可在慕容心处鉴定潜力</t><b/><t>普通：神兽加点时获得正常的属性成长</t><b/><t c='0x26da13ff'>优秀：神兽加点时获得额外20%的属性成长</t><b/><t c='0x226fffff'>精英：神兽加点时获得额外40%的属性成长</t><b/><t c='0xca57ffff'>完美：神兽加点时获得额外60%的属性成长</t><b/><t c='0xff9600ff'>传说：神兽加点时获得额外80%的属性成长</t><b/><t c='0xff1200ff'>逆天：神兽加点时获得额外100%的属性成长</t></t>";
				}


			case "OtherPetInfoWnd_NeedPlayerLevel"://携带等级
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽携带等级</t><b/><t>角色等级大于等于携带等级，才能携带神兽</t></t>";

			case "OtherPetInfoWnd_PetColligate"://携带等级
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽携带等级</t><b/><t>角色等级大于等于携带等级，才能携带神兽</t></t>";

			case "OtherPetInfoWnd_PetName"://神兽名称
				%ctrl.tooltipWidth = 120;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽名字</t><b/><t>神兽可以改名</t></t>";

			case "OtherPetInfoWnd_PetTitle"://神兽称号
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽称号</t><b/><t>当神兽的品阶、潜力、资质达到一定条件,即可在慕容心处领取称号</t></t>";

			case "OtherPetInfoWnd_TuJianButton":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽图鉴</t><b/><t>点击可显示该类神兽所有变异的神兽属性</t></t>";

			case "OtherPetInfoWnd_PetLevel"://神兽等级
				%ctrl.tooltipWidth = 120;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽等级</t><b/><t>神兽当前的等级</t></t>";

			case "OtherPetInfoWnd_PetStatus"://神兽状态
				%nStatus = Other_GetPetStatus();
				if (%nStatus == 1){ %PetStatus = "出战状态"; }
				else if (%nStatus == 2){ %PetStatus = "合体状态"; }
				else if (%nStatus == 4){ %PetStatus = "修行状态"; }
				else if (%nStatus == 7){ %PetStatus = "繁殖中状态"; }
				else if (%nStatus == 8){ %PetStatus = "繁殖完成状态"; }
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽处于"@ %PetStatus @"</t><b/><t>"@ %PetStatus @"的神兽将不能进行放生、交易、炼化、鉴定等操作</t></t>";

			case "OtherPetInfoWnd_PetSkill"://神兽技能栏
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽技能页</t><b/><t>神兽的被动技能以及玩家手动释放的技能</t><b/><t>通过参加活动和商城购买获得神兽技能书,在慕容心那可让神兽学会技能书技能</t></t>";

			case "OtherPetInfoWnd_PetAbility"://神兽能力栏
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽能力页</t><b/><t>神兽升级有一定几率可以领悟神兽能力</t><b/><t>调整神兽能力图标可以改变性格爆发时能力的释放顺序</t></t>";

			case "OtherPetInfoWnd_HP"://神兽体力值
				%ctrl.tooltipWidth = 305;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽体力值</t><b/><t>神兽当前体力值为0时,神兽将死亡并收回</t><b/><t>通过【喂食】可以恢复神兽的当前体力值</t><b/><t>喂食需要消耗血灵石,可以在神兽商人处购买</t></t>";

				/*		case "OtherPetInfoWnd_MP"://神兽精力值
				%ctrl.tooltipWidth = 305;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽精力值</t><b/><t>神兽施放技能时需要消耗精力值</t><b/><t>点击【补气】可以恢复神兽的当前精力值</t><b/><t>补气需要消耗岚灵石,可以在神兽商人处购买</t></t>";
				*/
			case "OtherPetInfoWnd_Happy"://神兽快乐
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽快乐度</t><b/><t>神兽死亡后快乐度会下降</t><b/><t>神兽在召唤状态每隔一段时间会减少快乐度</t><b/><t>当快乐度低于60时神兽将无法召唤</t><b/><t>可在神兽商人处购买神兽玩具增加神兽快乐度</t></t>";

			case "OtherPetInfoWnd_Exp"://神兽经验
				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽经验</t><b/><t>神兽当前经验值/神兽升至下一级经验值</t></t>";
			case "OtherPetInfoWnd_PetHuiGen"://品阶
				%ctrl.tooltipWidth = 320;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽品阶</t><b/><t>品阶每提升1点,所有成长资质增加100点</t><b/><t>神兽达到1修后即可到慕容心处进行品阶提升</t><b/><t>进阶需要消耗根骨丹,通过炼化具有根骨的神兽可以获得根骨丹</t></t>";

			case "OtherPetInfoWnd_PetGenGu"://根骨
				%ctrl.tooltipWidth = 310;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽根骨</t><b/><t>影响神兽炼化后获得的根骨丹</t><b/><t>根骨丹可以增加神兽品阶,提高神兽的成长资质</t></t>";

			case "OtherPetInfoWnd_PetTiPo"://体魄
				%ctrl.tooltipWidth = 155;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽体魄</t><b/><t>提高神兽体力最大值</t></t>";

			case "OtherPetInfoWnd_PetJingLi"://精神
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽精神</t><b/><t>提高神兽物理防御、法术防御</t></t>";

			case "OtherPetInfoWnd_PetLiDao"://力道
				%ctrl.tooltipWidth = 175;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽力道</t><b/><t>增加神兽物理攻击最大值</t></t>";

			case "OtherPetInfoWnd_PetLingLi"://智力
				%ctrl.tooltipWidth = 165;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽智力</t><b/><t>提高神兽法术攻击伤害</t></t>";

			case "OtherPetInfoWnd_PetMingJie"://身法
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽身法</t><b/><t>影响神兽的闪避和暴击几率</t></t>";

			case "OtherPetInfoWnd_PetYuanLi"://内力
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽内力</t><b/><t>提高神兽内力攻击伤害</t></t>";

			case "OtherPetInfoWnd_PetQianLi"://潜力
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽潜力</t><b/><t>神兽每升1级可获得5点潜力</t><b/><t>可自由分配到体魄、力道、智力、身法四项属性上</t></t>";

			case "OtherAttack_Physics"://物理攻击
				%ctrl.tooltipWidth = 175;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽物理攻击（物理类）</t><b/><t>神兽的物理伤害值</t></t>";

			case "OtherAttack_YuanLi"://法术攻击
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽法术攻击（法术类）</t><b/><t>神兽的法术伤害值</t></t>";

			case "OtherAttack_Mu"://物理命中
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽物理命中</t><b/><t>神兽的物理命中能力</t><b/><t c='0xF450CFff'>物理命中越高则对手闪避你的物理攻击几率越低</t></t>";

			case "OtherAttack_Huo"://法术命中
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽法术命中</t><b/><t>神兽的法术命中能力</t><b/><t c='0xF450CFff'>法术命中越高则对手闪避你的法术攻击几率越低</t></t>";

			case "OtherAttack_Shui"://物理闪避
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽物理闪避</t><b/><t>神兽的物理闪避能力</t><b/><t c='0xF450CFff'>物理闪避越高则闪避对手物理攻击几率越高</t></t>";

			case "OtherAttack_Jin"://法术闪避
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽法术闪避</t><b/><t>神兽的法术闪避能力</t><b/><t c='0xF450CFff'>法术闪避越高则闪避对手法术攻击几率越高</t></t>";

			case "OtherRecovery_Physics"://内力防御
				%ctrl.tooltipWidth = 175;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽内力防御</t><b/><t>抵御内力伤害</t></t>";

			case "OtherRecovery_YuanLi"://物理防御
				%ctrl.tooltipWidth = 275;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽物理防御</t><b/><t>受到物理攻击时减免相应的伤害</t><b/><t c='0xF450CFff'>神兽物理防御受物理防御影响</t></t>";

			case "OtherRecovery_Mu"://法术防御
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽法术防御</t><b/><t>受到法术攻击时减免相应的伤害</t><b/><t c='0xF450CFff'>神兽法术防御受法术防御影响</t></t>";

			case "OtherOther_ZhiLiao"://治疗
				%ctrl.tooltipWidth = 165;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽治疗</t><b/><t>神兽所能提高的治疗值</t></t>";

			case "OtherOther_ShanBi"://闪避
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽闪避</t><b/><t>闪避值越高则有更高的机会闪避对手攻击</t></t>";

			case "OtherOther_BaoJi"://暴击
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽暴击</t><b/><t>让神兽发动暴击伤害,暴击通常比普通伤害高</t></t>";

			case "OtherOther_BaoJiLv"://暴击率
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽暴击倍数</t><b/><t>发动暴击伤害后相对普通伤害的增长值</t></t>";

			case "OtherMoveWnd2_TiPo"://体魄资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽体魄资质</t><b/><t>影响“体魄”对神兽体力值上限的加成</t></t>";

			case "OtherMoveWnd2_JingLi"://精神资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽精神资质</t><b/><t>影响“精神”对神兽物理防御、法术防御</t></t>";

			case "OtherMoveWnd2_LiDao"://力道资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽力道资质</t><b/><t>影响“力道”对神兽物理攻击的加成</t></t>";

			case "OtherMoveWnd2_LingLi"://智力资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽智力资质</t><b/><t>影响“智力”对神兽五行攻击的加成</t></t>";

			case "OtherMoveWnd2_MinJie"://身法资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽身法资质</t><b/><t>影响“身法”对神兽闪避和暴击的加成</t></t>";

			case "OtherMoveWnd2_YuanLi"://内力资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽内力资质</t><b/><t>影响“内力”对神兽内力攻击的加成</t></t>";

			case "OtherMoveWnd3_1"://正直
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>正直性格</t><b/><t>性格阶段越高，受正直性格影响的技能释放几率就越高</t><b/><t>正直性格爆发时，正直性格影响的技能释放几率是100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽修行可以改变性格阶段</t></t>";

			case "OtherMoveWnd3_2"://活泼
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>活泼性格</t><b/><t>性格阶段越高，受活泼性格影响的技能释放几率就越高</t><b/><t>活泼性格爆发时，活泼性格影响的技能释放几率是100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽修行可以改变性格阶段</t></t>";

			case "OtherMoveWnd3_3"://稳重
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>稳重性格</t><b/><t>性格阶段越高，受稳重性格影响的技能释放几率就越高</t><b/><t>稳重性格爆发时，稳重性格影响的技能释放几率是100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽修行可以改变性格阶段</t></t>";

			case "OtherMoveWnd3_4"://勇猛
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>勇猛性格</t><b/><t>性格阶段越高，受勇猛性格影响的技能释放几率就越高</t><b/><t>勇猛性格爆发时，勇猛性格影响的技能释放几率是100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽修行可以改变性格阶段</t></t>";

			case "OtherMoveWnd3_5"://冷静
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>冷静性格</t><b/><t>性格阶段越高，受冷静性格影响的技能释放几率就越高</t><b/><t>冷静性格爆发时，冷静性格影响的技能释放几率是100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>神兽修行可以改变性格阶段</t></t>";

				//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
			case "OtherPetEvaluationWnd_Pg1_Xing1"://五星体魄资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽体魄资质</t><b/><t>影响“体魄”对神兽体力值上限的加成</t></t>";

			case "OtherPetEvaluationWnd_Pg1_Xing2"://精神资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽精神资质</t><b/><t>影响“精神”对神兽物理防御、法术防御</t></t>";

			case "OtherPetEvaluationWnd_Pg1_Xing3"://力道资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽力道资质</t><b/><t>影响“力道”对神兽物理攻击的加成</t></t>";

			case "OtherPetEvaluationWnd_Pg1_Xing4"://智力资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽智力资质</t><b/><t>影响“智力”对神兽五行攻击的加成</t></t>";

			case "OtherPetEvaluationWnd_Pg1_Xing5"://身法资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽身法资质</t><b/><t>影响“身法”对神兽闪避和暴击的加成</t></t>";

			case "OtherPetEvaluationWnd_Pg1_Xing6"://内力资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽内力资质</t><b/><t>影响“内力”对神兽内力攻击的加成</t></t>";

			case "OtherPetEvaluationWnd_Pg2_Xing1"://体魄资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽体魄资质</t><b/><t>影响“体魄”对神兽体力值上限的加成</t></t>";

			case "OtherPetEvaluationWnd_Pg2_Xing2"://精神资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽精神资质</t><b/><t>影响“精神”对神兽物理防御、法术防御</t></t>";

			case "OtherPetEvaluationWnd_Pg2_Xing3"://力道资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽力道资质</t><b/><t>影响“力道”对神兽物理攻击的加成</t></t>";

			case "OtherPetEvaluationWnd_Pg2_Xing4"://智力资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽智力资质</t><b/><t>影响“智力”对神兽五行攻击的加成</t></t>";

			case "OtherPetEvaluationWnd_Pg2_Xing5"://身法资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽身法资质</t><b/><t>影响“身法”对神兽闪避和暴击的加成</t></t>";

			case "OtherPetEvaluationWnd_Pg2_Xing6"://内力资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽内力资质</t><b/><t>影响“内力”对神兽内力攻击的加成</t></t>";
				//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
			case "OtherPetEvaluationWnd_Bmp_Tipo1"://六边形体魄资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽体魄资质</t><b/><t>影响“体魄”对神兽体力值上限的加成</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Jingli1"://精神资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽精神资质</t><b/><t>影响“精神”对神兽物理防御、法术防御</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Lidao1"://力道资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽力道资质</t><b/><t>影响“力道”对神兽物理攻击的加成</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Lingli1"://智力资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽智力资质</t><b/><t>影响“智力”对神兽五行攻击的加成</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Minjie1"://身法资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽身法资质</t><b/><t>影响“身法”对神兽闪避和暴击的加成</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Yuanli1"://内力资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽内力资质</t><b/><t>影响“内力”对神兽内力攻击的加成</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Tipo2"://六边形体魄资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽体魄资质</t><b/><t>影响“体魄”对神兽体力值上限的加成</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Jingli2"://精神资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽精神资质</t><b/><t>影响“精神”对神兽物理防御、法术防御</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Lidao2"://力道资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽力道资质</t><b/><t>影响“力道”对神兽物理攻击的加成</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Lingli2"://智力资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽智力资质</t><b/><t>影响“智力”对神兽五行攻击的加成</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Minjie2"://身法资质
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽身法资质</t><b/><t>影响“身法”对神兽闪避和暴击的加成</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Yuanli2"://内力资质
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽内力资质</t><b/><t>影响“内力”对神兽内力攻击的加成</t></t>";


				//====================================================================================神兽繁殖等系列界面===========================================================================================================

			case "PetBreed_ExplainTooltip"://神兽繁殖说明
				%ctrl.tooltipWidth = 380;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽繁殖条件：</t><b/><t>·神兽类型要求都为神兽宝宝</t><t c='0xF450CFff'>(变异宝宝不能繁殖后代)</t><b/><t>·一代神兽宝宝繁殖要求4修，下次繁殖等级在上次繁殖等级的基础上增加2修</t><b/><t>·进行繁殖的两个神兽宝宝需互为配偶或性别不同</t><b/><t>·神兽的快乐度需要为100点</t><b/><t>·神兽的寿元不小于500点</t><b/><t>·繁殖的神兽需要为一代神兽宝宝</t><b/><t>·神兽的双方主人需要处于同一队伍</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>神兽繁殖规则：</t><b/><t>·整个繁殖过程会持续2个小时</t><b/><t>·神兽处于繁殖状态,不能进行出战、修行、放生等操作</t><b/><t>·完成繁殖后,双方需与慕容心对话领取神兽宝宝</t></t>";

				//====================================================================================神兽炼化===========================================================================================================

			case "PetDecompoundWnd_BmpExplain"://神兽炼化说明
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽炼化说明：</t><b/><t>1、根骨大于0的神兽才可以炼化</t><b/><t>2、炼化成功后，神兽将会消失</t><b/><t>3、神兽的根骨越高，炼化后获得高级根骨丹的几率越高</t><b/><t>4、根骨丹可以用于神兽品阶提升，品阶提升可以提高神兽的成长资质</t><b/><t>5、根骨在1-3的神兽，有几率产出初级根骨丹和中级根骨丹</t><b/><t>6、根骨在4-10的神兽，有几率产出初级根骨丹、中级根骨丹和高级根骨丹</t></t>";

			case "PetRefineSoulGui_explain"://神兽精炼说明
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽精炼要求：</t><b/><t>1、神兽等级达到5修</t><b/><t>2、神兽为宝宝或者变异宝宝</t><b/><t>3、神兽要求拥有技能</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽精炼规则：</t><b/><t>1、精炼成功后，神兽随机将一个技能记录在精炼书中</t><b/><t>2、记录的技能可以给其他神兽学习</t><b/><t>3、精炼后的神兽将会消失</t><b/><t>4、精炼不会失败</t></t>";

				//====================================================================================神兽学习技能===========================================================================================================

			case "PetSkillStudy_Tip"://神兽学习技能说明
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽学习技能说明：</t><b/><t>1、高级技能必然替换低级技能</t><b/><t>2、攻击特性、防御特性和属性特性各只能存在一种，同类（例如都是攻击特性的技能）之间必然替换</t><b/><t>3、当没有出现（1）和（2）的情况时，技能有一定几率激活新技能栏，技能会添加到新技能栏中</t><b/><t>4、若没有激活新技能栏时，新技能会任意替换一个神兽当前的技能</t></t>";


				//====================================================================================骑宠界面===========================================================================================================

			case "PetInfoWnd_QiPet_Name":
				%ctrl.tooltipWidth = 80;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>骑宠名字</t></t>";

			case "PetInfoWnd_QiPet_GradeTooltip":
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>骑宠等级</t><b/><t>通过骑宠进阶可提升骑宠等级,从而增加骑宠的移动速度与骑乘人数</t></t>";

			case "PetInfoWnd_QiPet_Jinweishi"://喂食
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>骑宠喂食</t><b/><t>喂食需要消耗骑宠食物，可在</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>商城</t><t>或者</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>骑乘商人</t><t>处购买</t></t>";

			case "PetInfoWnd_QiPet_MountCount":
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>可骑乘人数</t><b/><t>骑宠的等级越高,可骑乘的人数也越多</t></t>";

			case "PetInfoWnd_QiPet_SpeedupPercent":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>骑宠速度</t><b/><t>骑宠的等级越高,骑宠速度也越快</t></t>";

			case "PetInfoWnd_QiPet_Level":
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>骑乘等级</t><b/><t>角色等级要求不低于该等级才能骑乘</t></t>";

			case "PetInfoWnd_QiPet_TuJian":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>骑宠图鉴</t><b/><t>点击可显示该类骑宠所有等级的属性</t></t>";

			case "PetInfoWnd_QiPet_Lock":
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>骑宠锁定</t><b/><t>在安全设置中对骑宠进行加锁</t><b/><t>骑宠加锁后无法被放生</t></t>";

			case "PetInfoWnd_QiPet_Release":
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>骑宠放生</t><b/><t>点击放生后骑宠消失</t><b/><t>安全时间、骑乘中、锁定中的骑宠无法放生</t></t>";

			case "PetInfoWnd_QiPet_Status":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>骑宠处于骑乘状态</t><b/><t>不能进行放生、等级提升的操作</t></t>";

			case "PetInfoWnd_QiPet_Mount":
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>骑乘</t><b/><t>只可骑乘满足骑乘等级的骑宠</t></t>";

			case "PetInfoWnd_QiPet_UnMount":
				%ctrl.tooltipWidth = 80;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>收回骑宠</t></t>";

				/*		case "PetInfoWnd_QiPet_MountRace":
				%nRace = Mount_GetMountRace($PetInfoWnd_MountSlot);

				if(%nRace ==0 ){%QiPetRace = "昆仑宗";}
				else if(%nRace ==1 ){%QiPetRace = "雷音寺";}
				else if(%nRace ==2 ){%QiPetRace = "蓬莱派";}
				else if(%nRace ==3 ){%QiPetRace = "飞花谷";}
				else if(%nRace ==4 ){%QiPetRace = "九幽教";}
				else if(%nRace ==5 ){%QiPetRace = "山海宗";}
				else if(%nRace ==6 ){%QiPetRace = "幻灵宫";}
				else if(%nRace ==7 ){%QiPetRace = "天魔门";}
				else if(%nRace ==8 ){%QiPetRace = "神邸";}

				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>骑宠的种族为"@ %QiPetRace @"</t></t>";
				*/
			case "WuXingFaceSeriesBtn_OpenSoulWnd":
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神技能</t><b/><t>1、化神成长阶段提升后相应获得1点化神天赋点,左键单击化神天赋,激活化神技能</t><b/><t>2、激活化神主动技能(需玩家手动释放),则激活的技能会显示到当前化神技能页面内,左键拖动技能可放入快捷栏中,右键单击使用技能</t><b/><t c='0x46ff15ff' >点击按钮打开化神信息界面</t></t>";

				//====================================================================================好友界面===========================================================================================================

			case "RelationWndBnt_Add":
				%ctrl.tooltipWidth = 140;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>给好友加油</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击打开好友加油</t></t>";

			case "RelationWndBnt_Chat":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>与其私聊</t><b/><t>选中要私聊的好友，点击打开私聊界面</t></t>";

			case "RelationWndBnt_Team":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>邀请组队</t><b/><t>选中要组队的好友，点击发送组队邀请</t></t>";

			case "RelationWndBnt_Write":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>发送邮件</t><b/><t>选中要写信的好友，点击打开写信界面</t></t>";

			case "RelationWndBnt_Clear":
				%ctrl.tooltipWidth = 135;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>清空当前列表信息</t></t>";

			case "RelationWndCheckBnt_ShowOnline":
				%ctrl.tooltipWidth = 175;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>不勾选</t><t>  全部显示</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>勾选</t><t>    隐藏离线玩家</t></t>";

			case "RelationWndBnt_AddFriend1":
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>添加玩家为好友</t><b/><t>1、只有双方都互加为好友,才算真正成为好友</t><b/><t>2、如与好友的关系显示为</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>[陌生]</t><t>，那需要申请对方加您为好友，右键菜单内单击</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>“请求加为好友”</t><t>即可</t></t>";

			case "RelationWndBnt_AddBlacklist":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>添加玩家到黑名单</t><b/><t>无法查看黑名单内玩家发送的聊天信息和邮件</t></t>";

			case "FriendCheerWndBmp_Tips"://加油
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>加油流程说明</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>好友卜卦：</t><b/><t>1、通过卜卦可以获得一个1小时的倒计时，结束时将获得一个效果不菲的状态奖励！</t><b/><t>2、邀请你的朋友对你加油，将会减少等待的时间。</t><b/><t>3、卜卦不限制次数，但在带有卜卦与卜卦奖励状态时，不能继续卜卦。</t><b/><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>好友加油：</t><b/><t>1、通过给他加油，可以帮助他减少10分钟卜卦倒计时，从而更快速的获得奖励。</t><b/><t>2、每一次加油，你还有一定几率触发额外事件获得惊喜。</t><b/><t>3、加油不限制次数，但加油成功后，10分钟才可以继续加油。</t></t>";

			case "RelationWndBnt_SearchPerson"://千里眼
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>千里眼</t><b/><t>可以查询好友.仇人当前所在地图位置与服务器信息</t></t>";


				//====================================================================================进阶界面，天珠镶嵌，装备增灵等===========================================================================================================

			case "EquipPrefectStrengthenWnd_IntroBitmap1"://完美进阶说明
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>一键完美进阶说明</t><b/><t>1、材料消耗：</t><t gct='0x00ff00ff' gcb='0x2cffeeff'> (可分解绿色以上装备获得)</t><b/><t>  装备进阶等级1-2级：消耗白玉石</t><b/><t>  装备进阶等级3-4级：消耗青光石</t><b/><t>  装备进阶等级5-12级：消耗蓝田石</t><b/><t>  装备进阶等级13-15级 ：消耗紫微石</t><b/><b/><t>2、 一键完美进阶只会保留完美进阶，非完美进阶会自动执行退级操作，直至达到完美进阶</t></t>";

			case "EquipStrengthen_IntroBitmap"://进阶说明
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>装备进阶说明</t><b/><t>1、材料消耗：</t><t gct='0x00ff00ff' gcb='0x2cffeeff'> (可分解绿色以上装备获得)</t><b/><t>  装备进阶等级1-2级：消耗白玉石</t><b/><t>  装备进阶等级3-4级：消耗青光石</t><b/><t>  装备进阶等级5-12级：消耗蓝田石</t><b/><t>  装备进阶等级13-15级 ：消耗紫微石</t><b/><b/><t>2、所有装备都可以进行进阶，但</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >神兵进阶</t><t>不会对基础属性进行提升，只会增加附加属性</t><b/><t>3、</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >进阶必然成功</t><t>，但是每个等级进阶的值会有</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >波动</t><t>，当达到</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >完美进阶</t><t>时，进阶属性将翻倍，并退还此次进阶的进阶石</t><b/><t>4、进阶可以选择</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >退级</t><t>，退级无任何消耗，但装备进阶属性会倒退1级</t><b/><t>5、装备进阶+4至+15每次都会提升进阶附加属性，同时武器进阶等级4，7，10会开启进阶特效，使外形更美观</t></t>";

			case "EquipStrengthen_RichText4"://装备进阶品质
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>装备进阶品质 （体现装备进阶的完美程度）</t><b/><t>1、</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >进阶必然成功</t><t>，但是每次等级进阶的值会有</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >波动</t><b/><t>2、当达到</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >完美进阶</t><t>时，进阶属性将翻倍，并退还此次进阶的进阶石。装备品质达到</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >满星</t><t>则表示装备每次都达到完美进阶</t><b/><t>3、进阶未达到完美时，可选择</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >进阶退级</t><t>重新进行装备进阶，退级无任何消耗，但装备进阶属性会倒退1级</t></t>";

			case "EquipPunchHole_XiTips"://装备打孔
				%ctrl.tooltipWidth = 320;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>装备打孔</t><b/><t>1、装备打孔有失败的几率</t><b/><t>2.装备打孔可以放入锉刀，装备打孔必然成功</t><b/><t>3、锉刀消耗说明：</t><b/><t>  a、一级锉刀：可用于1--59级装备打孔</t><b/><t>  b、二级锉刀：可用于1--69级装备打孔</t><b/><t>  c、三级锉刀：可用于1--79级装备打孔</t><b/><t>  d、四级锉刀：可用于1--89级装备打孔</t></t>";

			case "EquipEmbedGem_btnMount":
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>镶嵌天珠</t><b/><t>1、把天珠放入相同颜色插槽内,并且符合天珠的镶嵌限制,点击按钮天珠镶嵌至装备</t><b/><t>2、可同时放入多颗天珠,点击按钮一同镶嵌至装备</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>注：镶嵌的天珠摘取后都将变为不可交易</t></t>";

			case "EquipEmbedGem_btnUnmount":
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>摘取天珠</t><b/><t>1、选中要摘取的天珠，点击按钮进行摘取操作</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>注：镶嵌的天珠摘取后都将变为不可交易</t></t>";

				//case "EquipEmbedGemBnt_FindNpc":
				//	%ctrl.tooltipWidth = 250;
				//	%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>左键单击,寻径至长安石中玉</t><b/><t>石中玉处可进行天珠合成,天珠碎片合成,装备打孔的操作</t></t>";

			case "EquipEmbedGem_Tip":
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>镶嵌天珠</t><b/><t>1、把天珠放入相同颜色插槽内,并且符合天珠的镶嵌限制,点击【镶嵌天珠】按钮天珠将镶嵌至装备</t><b/><t>2、可同时放入多颗天珠,点击按钮一同镶嵌至装备</t><b/><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>摘取天珠</t><b/><t>1、选中要摘取的天珠，点击【摘取天珠】按钮进行摘取操作</t><b/><t>2、摘取天珠要消耗一定数量的相应等级钢钳</t><b/><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>注：镶嵌的天珠摘取后都将变为不可交易</t></t>";

			case "AddIdentify_Introduce"://装备增灵
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>装备增灵</t><b/><t>1、只有生活技能制造的</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >6修以上的紫色逆天装备</t><t>才可进行增灵，</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >增灵必然成功</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>（注：副本出的紫色装备无法增灵）</t><b/><t>2、每次增灵增加逆天装备一条附加属性，最高可以增灵到九条附加属性</t><b/><t>3、装备增灵需要</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >增灵石</t><t>和</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >相应等级的紫色装备</t><t>一件，如6修逆天装备增灵需要6修增灵石和6修以上紫色装备一件</t><b/><t>4、增灵石可通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >参加活动或商城购买</t><t>获得</t><b/><t>5、增灵无法开启特殊属性，只有换灵才可以开启</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >特殊属性</t><b/><t>6、鼠标移至图标</t><t>"@ %Reward1 @"</t><t>，即可查看每项属性换灵出的特殊属性</t></t>";


			case "ChangeIdentify_Introduce_New"://装备换灵
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }


				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>装备换灵</t><b/><t>1、</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >6修以上的紫色逆天装备</t><t>可进行换灵</t><b/><t>2、换灵可以改变逆天装备的属性内容，但不会改变属性值的大小</t><b/><t>3、第6、7、8、9、10条属性可以通过换灵开启</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >特殊属性</t><b/><t>4、鼠标移至图标</t><t> "@ %Reward1 @"</t><t>，即可查看每项属性换灵出的特殊属性</t></t>";

			case "EquipClearSoulWnd_IntroBitmap"://装备洗灵
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>装备洗灵</t><b/><t>1、只有生活技能制造的</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >6修以上的紫色逆天装备</t><t>才可进行洗灵</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>（注：副本出的紫色装备无法洗灵）</t><b/><t>2、洗灵只改变属性值的大小，不会改变属性内容</t><b/><t>3、洗灵需要消耗</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >洗灵石</t><t>和</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >玄铁碎片</t><b/><t>4、</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >勾选“洗灵二次确认”</t><t>，可根据洗灵后的属性是否满意再考虑启用</t><b/><t>5、鼠标移至图标</t><t>"@ %Reward1 @"</t><t>，即可查看每项属性换灵出的特殊属性</t></t>";

			case "ChangeIdentify_CheckBox"://换灵二次确认
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>换灵二次确认</t><b/><t>勾选后，可以在</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >看到换灵后属性</t><t>的情况下，选择是否需要启用，不启用则保持换灵前。启用本功能，换灵需要的</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >消耗翻倍</t></t>";

			case "EquipClearSoulWnd_CheckBox"://洗灵二次确认
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>洗灵二次确认</t><b/><t>勾选后，可以在</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >看到洗灵后属性</t><t>的情况下，选择是否需要启用，不启用则保持洗灵前。启用本功能，洗灵需要的</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >消耗翻倍</t></t>";


				//========================================================================================================装备增灵========================================================================================

			case "AddIdentify_icon6"://增灵界面
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "武器的";%Shux = ""; }
				else if (%Leix $= 201){ %Buwei = "头部的";%Shux = ""; }
				else if (%Leix $= 202){ %Buwei = "胸部的";%Shux = ""; }
				else if (%Leix $= 203){ %Buwei = "背部的";%Shux = ""; }
				else if (%Leix $= 204){ %Buwei = "肩部的";%Shux = ""; }
				else if (%Leix $= 205){ %Buwei = "手部的";%Shux = ""; }
				else if (%Leix $= 206){ %Buwei = "腰部的";%Shux = ""; }
				else if (%Leix $= 207){ %Buwei = "脚部的";%Shux = ""; }
				else if (%Leix $= 301){ %Buwei = "护符的";%Shux = ""; }
				else if (%Leix $= 302){ %Buwei = "项链的";%Shux = ""; }
				else if (%Leix $= 303){ %Buwei = "戒指的";%Shux = ""; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"第六项品质属性说明</t><b/><t>此装备开启第六项属性，通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >装备换灵</t><t>可获得以下特殊属性：</t><b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>坚韧加成</t></t>";

			case "AddIdentify_icon7"://增灵界面
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "武器的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理攻击百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>毒系攻击百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>火系攻击百分比加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>土系攻击百分比加成</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>金系攻击百分比加成</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>冰系攻击百分比加成</t>"; }
				else if (%Leix $= 201){ %Buwei = "头部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理防御百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>毒系抗性百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>火系抗性百分比加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>土系抗性百分比加成</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>金系抗性百分比加成</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>冰系抗性百分比加成</t>"; }
				else if (%Leix $= 202){ %Buwei = "胸部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理防御百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>毒系抗性百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>火系抗性百分比加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>土系抗性百分比加成</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>金系抗性百分比加成</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>冰系抗性百分比加成</t>"; }
				else if (%Leix $= 203){ %Buwei = "背部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>内力百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理命中百分比</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术命中百分比</t>"; }
				else if (%Leix $= 204){ %Buwei = "肩部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理防御百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>毒系抗性百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>火系抗性百分比加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>土系抗性百分比加成</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>金系抗性百分比加成</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>冰系抗性百分比加成</t>"; }
				else if (%Leix $= 205){ %Buwei = "手部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>毒系抗性百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>火系抗性百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>土系抗性百分比加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>金系抗性百分比加成</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>冰系抗性百分比加成</t>"; }
				else if (%Leix $= 206){ %Buwei = "腰部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>内力百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理命中百分比</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术命中百分</t>"; }
				else if (%Leix $= 207){ %Buwei = "脚部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>毒系抗性百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>火系抗性百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>土系抗性百分比加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>金系抗性百分比加成</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>冰系抗性百分比加成</t>"; }
				else if (%Leix $= 301){ %Buwei = "护符的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>毒系攻击加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>火系攻击加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>土系攻击加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>金系攻击加成</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>冰系攻击加成</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>内力攻击百分比加成</t>"; }
				else if (%Leix $= 302){ %Buwei = "项链的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>毒系攻击加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>火系攻击加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>土系攻击加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>金系攻击加成</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>冰系攻击加成</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>内力攻击百分比加成</t>"; }
				else if (%Leix $= 303){ %Buwei = "戒指的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>毒系攻击加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>火系攻击加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>土系攻击加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>金系攻击加成</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>冰系攻击加成</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>内力攻击百分比加成</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"第七项品质属性说明</t><b/><t>此装备开启第七项属性，通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >装备换灵</t><t>可获得以下特殊属性：</t>"@ %Shux @"</t>";

			case "AddIdentify_icon8"://增灵界面
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "武器的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>攻击速度百分比加成</t>"; }
				else if (%Leix $= 201){ %Buwei = "头部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率减免百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力恢复加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力恢复加成</t>"; }
				else if (%Leix $= 202){ %Buwei = "胸部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力恢复加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力恢复加成</t>"; }
				else if (%Leix $= 203){ %Buwei = "背部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>闪避率百分比加成</t>"; }
				else if (%Leix $= 204){ %Buwei = "肩部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率减免百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力恢复加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力恢复加成</t>"; }
				else if (%Leix $= 205){ %Buwei = "手部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>攻击速度百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率减免百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力恢复加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力恢复加成</t>"; }
				else if (%Leix $= 206){ %Buwei = "腰部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>闪避率百分比加成</t>"; }
				else if (%Leix $= 207){ %Buwei = "脚部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>移动速度百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率减免百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力恢复加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力恢复加成</t>"; }
				else if (%Leix $= 301){ %Buwei = "护符的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率百分比加成</t>"; }
				else if (%Leix $= 302){ %Buwei = "项链的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率百分比加成</t>"; }
				else if (%Leix $= 303){ %Buwei = "戒指的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率百分比加成</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"第八项品质属性说明</t><b/><t>此装备开启第八项属性，通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >装备换灵</t><t>可获得以下特殊属性：</t>"@ %Shux @"</t>";

			case "AddIdentify_icon9"://增灵界面
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "武器的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击倍数百分比加成</t>"; }
				else if (%Leix $= 201){ %Buwei = "头部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力值百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力值百分比加成</t>"; }
				else if (%Leix $= 202){ %Buwei = "胸部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理伤害减免百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术伤害减免百分比加成</t>"; }
				else if (%Leix $= 203){ %Buwei = "背部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>力道百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>智力百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>治疗百分比加成</t>"; }
				else if (%Leix $= 204){ %Buwei = "肩部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力值百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力值百分比加成</t>"; }
				else if (%Leix $= 205){ %Buwei = "手部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力值百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力值百分比加成</t>"; }
				else if (%Leix $= 206){ %Buwei = "腰部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>力道百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>智力百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>治疗百分比加成</t>"; }
				else if (%Leix $= 207){ %Buwei = "脚部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力值百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力值百分比加成</t>"; }
				else if (%Leix $= 301){ %Buwei = "护符的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击倍数百分比加成</t>"; }
				else if (%Leix $= 302){ %Buwei = "项链的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击倍数百分比加成</t>"; }
				else if (%Leix $= 303){ %Buwei = "戒指的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>武将职业技能+1</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>侠客职业技能+1</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>羽士职业技能+1</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>丹士职业技能+1</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>祭司职业技能+1</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"第九项品质属性说明</t><b/><t>此装备开启第九项属性，通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >装备换灵</t><t>可获得以下特殊属性：</t>"@ %Shux @"</t>";


			case "AddIdentify_icon10"://增灵界面
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "武器的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>伤害减免</t>"; }
				else if (%Leix $= 201){ %Buwei = "头部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视物理防御</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视法术防御</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视内力防御</t>"; }
				else if (%Leix $= 202){ %Buwei = "胸部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视物理防御</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视法术防御</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视内力防御</t>"; }
				else if (%Leix $= 203){ %Buwei = "背部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视毒系抗性</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视火系抗性</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视土系抗性</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视金系抗性</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视冰系抗性</t>"; }
				else if (%Leix $= 204){ %Buwei = "肩部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视物理防御</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视法术防御</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视内力防御</t>"; }
				else if (%Leix $= 205){ %Buwei = "手部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视物理防御</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视法术防御</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视内力防御</t>"; }
				else if (%Leix $= 206){ %Buwei = "腰部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视毒系抗性</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视火系抗性</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视土系抗性</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视金系抗性</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视冰系抗性</t>"; }
				else if (%Leix $= 207){ %Buwei = "脚部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视物理防御</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视法术防御</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视内力防御</t>"; }
				else if (%Leix $= 301){ %Buwei = "护符的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>伤害减免</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视毒系抗性</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视火系抗性</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视土系抗性</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视金系抗性</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视冰系抗性</t>"; }
				else if (%Leix $= 302){ %Buwei = "项链的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>伤害减免</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视毒系抗性</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视火系抗性</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视土系抗性</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视金系抗性</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视冰系抗性</t>"; }
				else if (%Leix $= 303){ %Buwei = "戒指的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>伤害减免</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视毒系抗性</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视火系抗性</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视土系抗性</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视金系抗性</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视冰系抗性</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"第十项品质属性说明</t><b/><t>此装备开启第十项属性，通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >装备换灵</t><t>可获得以下特殊属性：</t>"@ %Shux @"</t>";





				//========================================================================================================装备重铸========================================================================================

			case "KLJEquipStrengGui_ProImg5"://第六条属性
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "武器的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>幸运值</t>"; }
				else if (%Leix $= 201){ %Buwei = "头部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击减免</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>全主属性</t>"; }
				else if (%Leix $= 202){ %Buwei = "胸部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击减免</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>全主属性</t>"; }
				else if (%Leix $= 203){ %Buwei = "背部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击减免</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>全主属性</t>"; }
				else if (%Leix $= 204){ %Buwei = "肩部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击减免</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>全主属性</t>"; }
				else if (%Leix $= 205){ %Buwei = "手部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>幸运值</t>"; }
				else if (%Leix $= 206){ %Buwei = "腰部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击减免</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>全主属性</t>"; }
				else if (%Leix $= 207){ %Buwei = "脚部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击减免</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>全主属性</t>"; }
				else if (%Leix $= 301){ %Buwei = "护符的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>治疗百分比</t>"; }
				else if (%Leix $= 302){ %Buwei = "项链的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>治疗百分比</t>"; }
				else if (%Leix $= 303){ %Buwei = "戒指的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>治疗百分比</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>幸运值</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"第六项品质属性说明</t><b/><t>此装备开启第六项属性，通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >装备重铸</t><t>可获得以下特殊属性：</t>"@ %Shux @"</t>";

			case "KLJEquipStrengGui_ProImg6"://第七条属性
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "武器的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最大物理攻击百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最大法术攻击百分比</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理攻击力百分比</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术攻击力百分比</t>"; }
				else if (%Leix $= 201){ %Buwei = "头部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最大物理攻击百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最大法术攻击百分比</t>"; }
				else if (%Leix $= 202){ %Buwei = "胸部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理防御百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术防御百分比</t>"; }
				else if (%Leix $= 203){ %Buwei = "背部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理防御百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术防御百分比</t>"; }
				else if (%Leix $= 204){ %Buwei = "肩部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最大生命百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最大法力百分比</t>"; }
				else if (%Leix $= 205){ %Buwei = "手部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最小物理攻击百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最小法术攻击百分比</t>"; }
				else if (%Leix $= 206){ %Buwei = "腰部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理防御百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术防御百分比</t>"; }
				else if (%Leix $= 207){ %Buwei = "脚部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最大生命百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最大法力百分比</t>"; }
				else if (%Leix $= 301){ %Buwei = "护符的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最小物理攻击百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最小法术攻击百分比</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最大物理攻击百分比</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最大法术攻击百分比</t>"; }
				else if (%Leix $= 302){ %Buwei = "项链的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最小物理攻击百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最小法术攻击百分比</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最大物理攻击百分比</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最大法术攻击百分比</t>"; }
				else if (%Leix $= 303){ %Buwei = "戒指的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最小物理攻击百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>最小法术攻击百分比</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理攻击力百分比</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术攻击力百分比</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"第七项品质属性说明</t><b/><t>此装备开启第七项属性，通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >装备重铸</t><t>可获得以下特殊属性：</t>"@ %Shux @"</t>";


			case "KLJEquipStrengGui_ProImg7"://第八条属性
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "武器的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理命中百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术命中百分比</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>福缘百分比</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>会心一击值</t>"; }
				else if (%Leix $= 201){ %Buwei = "头部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理命中百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术命中百分比</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>全主属性百分比</t>"; }
				else if (%Leix $= 202){ %Buwei = "胸部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理闪避百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术闪避百分比</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>福缘百分比</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力百分比</t>"; }
				else if (%Leix $= 203){ %Buwei = "背部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理闪避百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术闪避百分比</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>会心一击防御值</t>"; }
				else if (%Leix $= 204){ %Buwei = "肩部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理命中百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术命中百分比</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>幸运百分比</t>"; }
				else if (%Leix $= 205){ %Buwei = "手部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理命中百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术命中百分比</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>全主属性百分比</t>"; }
				else if (%Leix $= 206){ %Buwei = "腰部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理闪避百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术闪避百分比</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力百分比</t>"; }
				else if (%Leix $= 207){ %Buwei = "脚部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理闪避百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术闪避百分比</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>幸运百分比</t>"; }
				else if (%Leix $= 301){ %Buwei = "护符的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>福缘百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力百分比</t>"; }
				else if (%Leix $= 302){ %Buwei = "项链的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>福缘百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>会心一击值</t>"; }
				else if (%Leix $= 303){ %Buwei = "戒指的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理命中百分比</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术命中百分比</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>力量百分比</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>智力百分比</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精神百分比</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"第八项品质属性说明</t><b/><t>此装备开启第八项属性，通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >装备重铸</t><t>可获得以下特殊属性：</t>"@ %Shux @"</t>";

			case "KLJEquipStrengGui_ProImg8"://第九条属性
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "武器的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>攻击速度</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>战士技能等级+1</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法师技能等级+1</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>道士技能等级+1</t>"; }
				else if (%Leix $= 201){ %Buwei = "头部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击伤害百分比</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>施法速度</t>"; }
				else if (%Leix $= 202){ %Buwei = "胸部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率减免</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击伤害减免百分比</t>"; }
				else if (%Leix $= 203){ %Buwei = "背部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率减免</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击伤害减免百分比</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>坐骑移动速度</t>"; }
				else if (%Leix $= 204){ %Buwei = "肩部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物攻伤害加深</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法攻伤害加深</t>"; }
				else if (%Leix $= 205){ %Buwei = "手部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击伤害百分比</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>攻击速度</t>"; }
				else if (%Leix $= 206){ %Buwei = "腰部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率减免</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击伤害减免百分比</t>"; }
				else if (%Leix $= 207){ %Buwei = "脚部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率减免</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>移动速度</t>"; }
				else if (%Leix $= 301){ %Buwei = "护符的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>战士技能等级+1</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法师技能等级+1</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>道士技能等级+1</t>"; }
				else if (%Leix $= 302){ %Buwei = "项链的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击伤害百分比</t>"; }
				else if (%Leix $= 303){ %Buwei = "戒指的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物攻伤害加深</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法攻伤害加深</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"第九项品质属性说明</t><b/><t>此装备开启第九项属性，通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >装备重铸</t><t>可获得以下特殊属性：</t>"@ %Shux @"</t>";


			case "KLJEquipStrengGui_ProImg9"://第十条属性
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "武器的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>会心一击率</t>"; }
				else if (%Leix $= 201){ %Buwei = "头部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>会心伤害减免</t>"; }
				else if (%Leix $= 202){ %Buwei = "胸部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物攻受击伤害减免</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法攻受击伤害减免</t>"; }
				else if (%Leix $= 203){ %Buwei = "背部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>会心一击防御率</t>"; }
				else if (%Leix $= 204){ %Buwei = "肩部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物攻受击伤害减免</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法攻受击伤害减免</t>"; }
				else if (%Leix $= 205){ %Buwei = "手部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>会心一击伤害</t>"; }
				else if (%Leix $= 206){ %Buwei = "腰部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>会心一击防御率</t>"; }
				else if (%Leix $= 207){ %Buwei = "脚部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>会心伤害减免</t>"; }
				else if (%Leix $= 301){ %Buwei = "护符的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>会心一击伤害</t>"; }
				else if (%Leix $= 302){ %Buwei = "项链的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>会心一击率</t>"; }
				else if (%Leix $= 303){ %Buwei = "戒指的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>会心一击伤害</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"第十项品质属性说明</t><b/><t>此装备开启第十项属性，通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >装备重铸</t><t>可获得以下特殊属性：</t>"@ %Shux @"</t>";


				//========================================================================================================装备洗灵========================================================================================

			case "EquipClearSoulWnd3_zhuanimg_5"://
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "武器的";%Shux = ""; }
				else if (%Leix $= 201){ %Buwei = "头部的";%Shux = ""; }
				else if (%Leix $= 202){ %Buwei = "胸部的";%Shux = ""; }
				else if (%Leix $= 203){ %Buwei = "背部的";%Shux = ""; }
				else if (%Leix $= 204){ %Buwei = "肩部的";%Shux = ""; }
				else if (%Leix $= 205){ %Buwei = "手部的";%Shux = ""; }
				else if (%Leix $= 206){ %Buwei = "腰部的";%Shux = ""; }
				else if (%Leix $= 207){ %Buwei = "脚部的";%Shux = ""; }
				else if (%Leix $= 301){ %Buwei = "护符的";%Shux = ""; }
				else if (%Leix $= 302){ %Buwei = "项链的";%Shux = ""; }
				else if (%Leix $= 303){ %Buwei = "戒指的";%Shux = ""; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"第六项品质属性说明</t><b/><t>此装备开启第六项属性，通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >装备换灵</t><t>可获得以下特殊属性：</t><b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>坚韧加成</t></t>";


			case "EquipClearSoulWnd3_zhuanimg_6"://
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "武器的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理攻击百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>毒系攻击百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>火系攻击百分比加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>土系攻击百分比加成</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>金系攻击百分比加成</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>冰系攻击百分比加成</t>"; }
				else if (%Leix $= 201){ %Buwei = "头部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理防御百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>毒系抗性百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>火系抗性百分比加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>土系抗性百分比加成</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>金系抗性百分比加成</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>冰系抗性百分比加成</t>"; }
				else if (%Leix $= 202){ %Buwei = "胸部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理防御百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>毒系抗性百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>火系抗性百分比加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>土系抗性百分比加成</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>金系抗性百分比加成</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>冰系抗性百分比加成</t>"; }
				else if (%Leix $= 203){ %Buwei = "背部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>内力百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理命中百分比</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术命中百分比</t>"; }
				else if (%Leix $= 204){ %Buwei = "肩部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理防御百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>毒系抗性百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>火系抗性百分比加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>土系抗性百分比加成</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>金系抗性百分比加成</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>冰系抗性百分比加成</t>"; }
				else if (%Leix $= 205){ %Buwei = "手部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>毒系抗性百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>火系抗性百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>土系抗性百分比加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>金系抗性百分比加成</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>冰系抗性百分比加成</t>"; }
				else if (%Leix $= 206){ %Buwei = "腰部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>内力百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理命中百分比</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术命中百分比</t>"; }
				else if (%Leix $= 207){ %Buwei = "脚部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>毒系抗性百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>火系抗性百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>土系抗性百分比加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>金系抗性百分比加成</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>冰系抗性百分比加成</t>"; }
				else if (%Leix $= 301){ %Buwei = "护符的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>毒系攻击加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>火系攻击加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>土系攻击加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>金系攻击加成</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>冰系攻击加成</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>内力攻击百分比加成</t>"; }
				else if (%Leix $= 302){ %Buwei = "项链的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>毒系攻击加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>火系攻击加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>土系攻击加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>金系攻击加成</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>冰系攻击加成</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>内力攻击百分比加成</t>"; }
				else if (%Leix $= 303){ %Buwei = "戒指的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>毒系攻击加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>火系攻击加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>土系攻击加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>金系攻击加成</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>冰系攻击加成</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>内力攻击百分比加成</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"第七项品质属性说明</t><b/><t>此装备开启第七项属性，通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >装备换灵</t><t>可获得以下特殊属性：</t>"@ %Shux @"</t>";


			case "EquipClearSoulWnd3_zhuanimg_7"://
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "武器的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>攻击速度百分比加成</t>"; }
				else if (%Leix $= 201){ %Buwei = "头部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率减免百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力恢复加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力恢复加成</t>"; }
				else if (%Leix $= 202){ %Buwei = "胸部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力恢复加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力恢复加成</t>"; }
				else if (%Leix $= 203){ %Buwei = "背部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>闪避率百分比加成</t>"; }
				else if (%Leix $= 204){ %Buwei = "肩部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率减免百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力恢复加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力恢复加成</t>"; }
				else if (%Leix $= 205){ %Buwei = "手部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>攻击速度百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率减免百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力恢复加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力恢复加成</t>"; }
				else if (%Leix $= 206){ %Buwei = "腰部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>闪避率百分比加成</t>"; }
				else if (%Leix $= 207){ %Buwei = "脚部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>移动速度百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率减免百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力恢复加成</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力恢复加成</t>"; }
				else if (%Leix $= 301){ %Buwei = "护符的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率百分比加成</t>"; }
				else if (%Leix $= 302){ %Buwei = "项链的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率百分比加成</t>"; }
				else if (%Leix $= 303){ %Buwei = "戒指的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击率百分比加成</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"第八项品质属性说明</t><b/><t>此装备开启第八项属性，通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >装备换灵</t><t>可获得以下特殊属性：</t>"@ %Shux @"</t>";

			case "EquipClearSoulWnd3_zhuanimg_8"://
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "武器的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击倍数百分比加成</t>"; }
				else if (%Leix $= 201){ %Buwei = "头部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力值百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力值百分比加成</t>"; }
				else if (%Leix $= 202){ %Buwei = "胸部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>物理伤害减免百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>法术伤害减免百分比加成</t>"; }
				else if (%Leix $= 203){ %Buwei = "背部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>力道百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>智力百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>治疗百分比加成</t>"; }
				else if (%Leix $= 204){ %Buwei = "肩部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力值百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力值百分比加成</t>"; }
				else if (%Leix $= 205){ %Buwei = "手部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力值百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力值百分比加成</t>"; }
				else if (%Leix $= 206){ %Buwei = "腰部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>力道百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>智力百分比加成</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>治疗百分比加成</t>"; }
				else if (%Leix $= 207){ %Buwei = "脚部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>体力值百分比加成</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>精力值百分比加成</t>"; }
				else if (%Leix $= 301){ %Buwei = "护符的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击倍数百分比加成</t>"; }
				else if (%Leix $= 302){ %Buwei = "项链的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>暴击倍数百分比加成</t>"; }
				else if (%Leix $= 303){ %Buwei = "戒指的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>武将职业技能+1</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>侠客职业技能+1</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>羽士职业技能+1</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>丹士职业技能+1</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>祭司职业技能+1</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"第九项品质属性说明</t><b/><t>此装备开启第九项属性，通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >装备换灵</t><t>可获得以下特殊属性：</t>"@ %Shux @"</t>";


			case "EquipClearSoulWnd3_zhuanimg_9"://
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "武器的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>伤害减免</t>"; }
				else if (%Leix $= 201){ %Buwei = "头部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视物理防御</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视法术防御</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视内力防御</t>"; }
				else if (%Leix $= 202){ %Buwei = "胸部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视物理防御</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视法术防御</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视内力防御</t>"; }
				else if (%Leix $= 203){ %Buwei = "背部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视毒系抗性</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视火系抗性</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视土系抗性</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视金系抗性</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视冰系抗性</t>"; }
				else if (%Leix $= 204){ %Buwei = "肩部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视物理防御</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视法术防御</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视内力防御</t>"; }
				else if (%Leix $= 205){ %Buwei = "手部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视物理防御</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视法术防御</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视内力防御</t>"; }
				else if (%Leix $= 206){ %Buwei = "腰部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视毒系抗性</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视火系抗性</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视土系抗性</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视金系抗性</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视冰系抗性</t>"; }
				else if (%Leix $= 207){ %Buwei = "脚部的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视物理防御</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视法术防御</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视内力防御</t>"; }
				else if (%Leix $= 301){ %Buwei = "护符的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>伤害减免</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视毒系抗性</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视火系抗性</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视土系抗性</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视金系抗性</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视冰系抗性</t>"; }
				else if (%Leix $= 302){ %Buwei = "项链的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>伤害减免</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视毒系抗性</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视火系抗性</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视土系抗性</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视金系抗性</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视冰系抗性</t>"; }
				else if (%Leix $= 303){ %Buwei = "戒指的";%Shux = "<b/><t>1、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>伤害减免</t><b/><t>2、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视毒系抗性</t><b/><t>3、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视火系抗性</t><b/><t>4、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视土系抗性</t><b/><t>5、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视金系抗性</t><b/><t>6、</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>无视冰系抗性</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"第十项品质属性说明</t><b/><t>此装备开启第十项属性，通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >装备换灵</t><t>可获得以下特殊属性：</t>"@ %Shux @"</t>";


				//====================================================================================邮件界面===========================================================================================================
			case "MailWnd_Text_LetterNum1"://文本未读

				if (isFile("gameres/gui/images/GUIWindow40_1_006.png")){ %weidu1 = "<i s='gameres/gui/images/GUIWindow40_1_006.png' w='16' h='16'/>"; }
				else{ %weidu1 = ""; }
				if (isFile("gameres/gui/images/GUIWindow40_1_007.png")){ %weidu2 = "<i s='gameres/gui/images/GUIWindow40_1_007.png' w='16' h='16'/>"; }
				else{ %weidu2 = ""; }
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前未读文本邮件数量</t><b/>"@ %weidu1 @"<t>:邮件未读状态</t><b/>"@ %weidu2 @"<t>:邮件有背包状态</t></t>";

			case "MailWnd_Text_LetterNum2"://背包未读
				if (isFile("gameres/gui/images/GUIWindow40_1_006.png")){ %weidu1 = "<i s='gameres/gui/images/GUIWindow40_1_006.png' w='16' h='16'/>"; }
				else{ %weidu1 = ""; }
				if (isFile("gameres/gui/images/GUIWindow40_1_007.png")){ %weidu2 = "<i s='gameres/gui/images/GUIWindow40_1_007.png' w='16' h='16'/>"; }
				else{ %weidu2 = ""; }

				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前未读背包邮件数量</t><b/>"@ %weidu1 @"<t>:邮件未读状态</t><b/>"@ %weidu2 @"<t>:邮件有背包状态</t></t>";

			case "MailWnd_Text_LetterNum0"://系统未读
				if (isFile("gameres/gui/images/GUIWindow40_1_006.png")){ %weidu1 = "<i s='gameres/gui/images/GUIWindow40_1_006.png' w='16' h='16'/>"; }
				else{ %weidu1 = ""; }
				if (isFile("gameres/gui/images/GUIWindow40_1_007.png")){ %weidu2 = "<i s='gameres/gui/images/GUIWindow40_1_007.png' w='16' h='16'/>"; }
				else{ %weidu2 = ""; }

				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前未读系统邮件数量</t><b/>"@ %weidu1 @"<t>:邮件未读状态</t><b/>"@ %weidu2 @"<t>:邮件有背包状态</t></t>";

			case "MailWnd_CollectionNum"://已收邮件
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>已收邮件</t><b/><t>已收邮件达上限时，应及时删除已读邮件，否则将无法接收新邮件</t></t>";

			case "MailWnd_ClearMailButton"://清空邮件
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>清空已读邮件</t><b/><t>1、清空文本、背包、系统三类已读的邮件</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>2、如有未收取物品和元宝的邮件，将不会被清空</t></t>";

			case "MailWnd_DelectMailButton"://删除邮件
				%ctrl.tooltipWidth = 330;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>删除选中邮件</t><b/><t>1、需勾选想要删除的邮件，再点击该按钮</t><b/><t>2、点击本页全选，当前页内所有邮件都会被选中</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>3、如有未收取物品和元宝的邮件，将不会被清空</t></t>";

			case "MailWnd_WriteMailButton"://写信
				%ctrl.tooltipWidth = 170;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>写信</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击打开邮件编辑界面</t></t>";

			case "MailWnd_SendmailPage_Topic"://主题
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>邮件主题（必填）</t><b/><t>主题最多可输入12个汉字</t></t>";

			case "MailWnd_SendmailPage_FriendNameButton"://收信人
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>邮件收信人（必填）</t><b/><t>1、人物1修前无法给非好友发送邮件，1修及以上可给非好友发送邮件但需消耗10点活力</t><b/><t>2、如收信人为非好友，建议您点击右侧的</t><t c='0x2cffeeff'o='0x010101ff'>[加为好友]</t><t>，与对方建立好友关系</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>左键单击可给其他好友发送邮件</t></t>";

			case "MailWnd_SendmailPage_Edit"://正文
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>邮件正文（必填）</t><b/><t>正文最多可输入128个汉字</t></t>";

			case "MailWnd_SendmailPage_MoneySilver"://金钱
				if (isFile("gameres/gui/images/GUIWindow31_1_024.png")){ %jinyuan1 = "<i s='gameres/gui/images/GUIWindow31_1_024.png' w='16' h='16'/>"; }
				else{ %jinyuan1 = "金"; }
				if (isFile("gameres/gui/images/GUIWindow31_1_025.png")){ %jinyuan2 = "<i s='gameres/gui/images/GUIWindow31_1_025.png' w='16' h='16'/>"; }
				else{ %jinyuan2 = "银"; }
				if (isFile("gameres/gui/images/GUIWindow31_1_026.png")){ %jinyuan3 = "<i s='gameres/gui/images/GUIWindow31_1_026.png' w='16' h='16'/>"; }
				else{ %jinyuan2 = "铜"; }
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>寄送元宝</t><b/><t>1修前无法给非好友寄送物品与元宝</t><b/><t>每次寄送元宝上限为999</t>"@%jinyuan1@"<t>99</t>"@%jinyuan2@"<t>99</t>"@%jinyuan3@"</t></t>";

			case "MailWnd_SendmailPage_MoneyCopper"://金钱
				%ctrl.tooltipWidth = 250;
				if (isFile("gameres/gui/images/GUIWindow31_1_024.png")){ %jinyuan1 = "<i s='gameres/gui/images/GUIWindow31_1_024.png' w='16' h='16'/>"; }
				else{ %jinyuan1 = "金"; }
				if (isFile("gameres/gui/images/GUIWindow31_1_025.png")){ %jinyuan2 = "<i s='gameres/gui/images/GUIWindow31_1_025.png' w='16' h='16'/>"; }
				else{ %jinyuan2 = "银"; }
				if (isFile("gameres/gui/images/GUIWindow31_1_026.png")){ %jinyuan3 = "<i s='gameres/gui/images/GUIWindow31_1_026.png' w='16' h='16'/>"; }
				else{ %jinyuan2 = "铜"; }
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>寄送元宝</t><b/><t>1修前无法给非好友寄送物品与元宝</t><b/><t>每次寄送元宝上限为999</t>"@%jinyuan1@"<t>99</t>"@%jinyuan2@"<t>99</t>"@%jinyuan3@"</t></t>";

			case "MailWnd_SendmailPage_MoneyGold"://金钱
				%ctrl.tooltipWidth = 250;
				if (isFile("gameres/gui/images/GUIWindow31_1_024.png")){ %jinyuan1 = "<i s='gameres/gui/images/GUIWindow31_1_024.png' w='16' h='16'/>"; }
				else{ %jinyuan1 = "金"; }
				if (isFile("gameres/gui/images/GUIWindow31_1_025.png")){ %jinyuan2 = "<i s='gameres/gui/images/GUIWindow31_1_025.png' w='16' h='16'/>"; }
				else{ %jinyuan2 = "银"; }
				if (isFile("gameres/gui/images/GUIWindow31_1_026.png")){ %jinyuan3 = "<i s='gameres/gui/images/GUIWindow31_1_026.png' w='16' h='16'/>"; }
				else{ %jinyuan2 = "铜"; }
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>寄送元宝</t><b/><t>1修前无法给非好友寄送物品与元宝</t><b/><t>每次寄送元宝上限为999</t>"@%jinyuan1@"<t>99</t>"@%jinyuan2@"<t>99</t>"@%jinyuan3@"</t></t>";

			case "MailWnd_GetMoneyButton"://全部收取
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>全部收取</t><b/><t>点击该按钮将全部收取寄送的物品和金钱</t></t>";

				//====================================================================================趣味答题===========================================================================================================

			case "AnswerQuestionTurnOnBnt_Tips":
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>答题活动</t><b/><t>目前处于答题活动时间,如果您还未参加,可单击马上加入答题活动</t></t>";

			case "AnswerQuestionBmp_1"://积分说明
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>答题积分规则：</t><b/><t>1、每一题最高作答基础分为20分,在20秒答题时间内作答,第1-2秒内作答正确可获得20分,3-4秒内获得18分,依次类推</t><t c='0xadfff2ff'>(作答正确至少获得5分+连续正确答题奖励分)</t><b/><t>2、连续正确答题数：连续正确答题数越高，可获得更多奖励分(放弃答题不会中断之前的连续答对次数)</t><b/><b/><t c='0x00ff00ff'>使用双倍积分功能：</t><b/><t>1、勾选该功能后获得的积分会翻倍，并从背包里扣除一张</t><t gct='0xff65feff' gcb='0xff65feff'>答题双倍得分卡</t><b/><t>2、每天答题可使用三次</t></t>";

			case "AnswerQuestionBmp_2"://流程说明
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>答题活动流程：</t><b/><t>1、准备阶段：1分钟准备时间，结束后进入读题阶段</t><b/><t>2、读题阶段：有5秒钟的读题时间</t><b/><t>3、答题阶段：有20秒钟的答题时间，此时可以选择答案，点击“提交”进行作答，所用时间越少获得的积分越多</t><b/><t>4、宣布结果：有5秒钟的宣布结果时间</t><b/><b/><t c='0x00ff00ff'>答题活动奖励：</t><b/><t>活动结束后通过积分领取大量人物经验，积分前10名根据名次获得一定数量的【昆仑古币】和【蓬莱玉髓】与趣味称号，未进前10，但参与5次以上可获得1个【昆仑古币】。</t></t>";


			case "AnswerQuestionCheckBox_Use"://勾选按钮
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>勾选：</t><t>启用双倍积分功能，答题正确后积分可翻四倍</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>不勾选：</t><t>答题正确后积分正常不翻倍</t></t>";

				//====================================================================================系统设置===========================================================================================================

			case "SysSettingMenu_Resolving"://系统设置-分辨率
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>改变游戏画面的分辨率，降低此项可以提高运行速度</t></t>";

			case "SysSettingMenu_FSAA"://系统设置-抗锯齿
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>能消除游戏画面中物体的边缘锯齿，使画面看起来更为平滑</t></t>";

			case "SysSettingCheckBtn_Window"://系统设置-窗口显示
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' c='0xf3d300ff' o='0x010101ff'><t>勾选此选项可在窗口模式下进行游戏</t><b/><t>如勾选此选项，游戏画面将以您设置的窗口分辨率值为准</t></t>";

			case "SysSettingCheckBtn_FullWindow"://系统设置-窗口最大化
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>勾选此选项以最大化窗口显示并去除边框</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>勾选窗口显示，才能操作窗口最大化</t></t>";

			case "SysSetSlider_ScreenPlayer"://系统设置-同屏人数
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>调整游戏屏幕内显示的玩家人数，减少同屏人数可提高游戏运行速度</t></t>";

			case "SysSetSlider_SceneEffect"://系统设置-特效细节
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>调整游戏屏幕内显示的特效细节，降低特效显示细节可提高游戏运行速度,部分特效需要重启游戏方可起效</t></t>";

			case "SysSettingCheckBtn_Quiet"://系统设置-静音
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>启用和禁用游戏内所有声音</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>勾选后立即生效</t></t>";

			case "SysSettingCheckBtn_OpenSound"://系统设置-音效
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>启用和禁用游戏内音效效果</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>勾选后立即生效</t></t>";

			case "SysSettingCheckBtn_OpenMusic"://系统设置-音乐
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>启用和禁用游戏内背景音乐</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>勾选后立即生效</t></t>";

			case "SysSetSlider_MusicVolume"://系统设置-音乐音量
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>调节游戏内背景音乐的音量</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>开启音乐勾选状态下调节有效</t></t>";

			case "SysSetSlider_SoundVolume"://系统设置-音效音量
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>调节游戏内音效效果的音量</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>开启音效勾选状态下调节有效</t></t>";

			case "SysSetSlider_Lighteness"://系统设置-亮度
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>调整游戏内画面的明亮度</t></t>";

			case "SysSetSlider_Contrast"://系统设置-对比度
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>调整游戏内画面的对比度</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>对比度值越大，游戏画面的色彩越丰富</t></t>";

			case "SysSetSlider_TexturePrecision"://系统设置-贴图精度
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>调整游戏内所有模型贴图的精细度，降低此值可明显提高游戏运行的速度，但会适当弱化游戏的美化效果</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>此项改动需重启游戏后才能生效</t></t>";

			case "SysSetSlider_ShadowDetail"://系统设置-阴影细节
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>调整游戏内角色和环境的阴影渲染质量，降低此项可以提高游戏运行速度</t></t>";

			case "SysSetSlider_SceneDetail"://系统设置-场景细节
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>调整游戏内所有模型面的数量，降低此项可以提高运行速度</t></t>";

			case "SysSettingCheckBtn_StaticAnimation"://系统设置-物件动画
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>启用游戏中物件具有动画的效果，禁用此项可以略微提高游戏运行速度</t></t>";

			case "SysSettingCheckBtn_FSBrightness"://系统设置-全屏泛光
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>启用全屏泛光效果，可以柔化物体边缘和照明，禁用此项有时可以提高游戏运行速度</t></t>";

			case "SysSettingCheckBtn_WaterReflaction"://系统设置-水面反射
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>启用游戏水面反射的效果，禁用此项可以略微提高游戏运行速度</t></t>";

			case "SysSettingCheckBtn_ZhiWaWaMode"://系统设置-纸娃娃模式
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>游戏中玩家统一变为纸娃娃模型，启用此项可降低显卡压力、节约系统资源、让您能流畅的体验游戏乐趣</t></t>";

				//		case "SysSettingCheckBtn_CoastEffect"://系统设置-海岸效果
				//			%ctrl.tooltipWidth = 230;
				//			%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>启用游戏中的海岸效果，禁用此项可以略微提高游戏运行速度</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>该功能尚未开放</t></t>";


				//====================================================================================复活界面===========================================================================================================

			case "ResurgenceButton_1"://(原地复活)

				%Player = GetPlayer();
				if ((%Player.GetMetempsychosis() == 0) && (%Player.GetLevel() < 40)){ %txt = "剩余原地复活次数：无限制（1道4修0重以下）"; }
				else { %txt = "今日剩余原地复活次数："@ GetPlayer().GetOntheSpotRiseCount() @"次"; }


				ResurgenceWnd_Tips.setContent(%txt);


			case "ResurgenceButton_2"://(复活点复活)
				%txt ="当前复活点："@ GetRiseMap() @" ";
				ResurgenceWnd_Tips.setContent(%txt);

			case "ResurgenceButton_3"://(复活点复活)
				ResurgenceWnd_Tips.setContent("消耗 100 元宝立即原地复活");

			case "Resurgence_AskBtn"://(使用元宝原地复活)
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>死亡惩罚</t><b/><t>1、死亡时会不损失装备耐久度和金币</t><b/><t>2、死亡时善恶值过高将会被传入监狱</t></t>";

				//群雄争霸副本中的两个复活控件
			case "SpecialResurgenceButton_1":	//复活到前一层
				ResurgenceWnd_Tips.setContent("复活到前面一层，不会消耗金币");

			case "SpecialResurgenceButton_2":	//原地复活
				ResurgenceWnd_Tips.setContent("消耗少量的金币立即原地复活");

				//====================================================================================倒计时说明===========================================================================================================

			case "TimerTriggerCtrl_Min_Icon":
				if (%Player.GetLevel() <  5)
				{
					%Minute = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>5</t>";
					%ctrl.tooltipWidth = 250;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>在线奖励</t><b/><t>达到"@%Minute@"级时您可领取一份惊喜礼物</t></t>";
				}
				else{
					if (0 == $TimerTriggerLeftMinute && 0 == $TimerTriggerLeftSecond)
					{
						%ctrl.tooltipWidth = 250;
						%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>在线奖励</t><b/><t>您有一份惊喜礼物可领取</t></t>";
					}
					else{
						%Minute = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>"@ $TimerTriggerLeftMinute@"</t>分";
						%Second = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>"@ $TimerTriggerLeftSecond@"</t>秒";
						%ctrl.tooltipWidth = 250;
						%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>在线奖励</t><b/><t>"@ %Minute @""@ %Second @"之后您将获得一份惊喜礼物</t></t>";
					}
				}



				//====================================================================================上线提示界面===========================================================================================================

			case "UpLinePartyWnd_SignIn_Btn":
				%ctrl.tooltipWidth = 320;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>上线即有好礼相送</t><b/><t>每日上线可领取上线礼包一份</t><b/><t>每周累计领取</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>5次</t><t>上线礼包可再获得一份周礼包</t><b/><t>每月累计领取</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>20次</t><t>上线礼包可再获得一份月礼包</t></t>";

			case "UpLinePartyWnd_Draww_Btn1":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>每周累计领取</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>5次</t><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>点击即可获得一份周礼包大礼：</t><b/><t>1,000,000经验奖励</t><b/><t>100,000金币</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>还有机会获得道具奖励</t></t>";

			case "UpLinePartyWnd_Drawd_Btn1":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>每月累计领取</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>20次</t><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>点击即可获得一份月礼包大礼：</t><b/><t>5,000,000经验奖励</t><b/><t>300,000金币</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>还有机会获得2000元宝和玄铁等道具奖励</t></t>";

			case "UpLinePartyWnd_FreeBtn"://免费领取
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>免费领取额外经验</t><b/><t>当角色低于4修时，储存的经验一次最多只能提升2级，溢出的经验将会自动存入师德的经验池中，可使用师德来兑换</t></t>";

				//====================================================================================神兽分析界面===========================================================================================================

			case "PetEvaluationWnd_Bmp_Rate"://X坐标
				%ctrl.tooltipWidth = 290;

				%IsIdentify = PetOperation_IsPetIdentify($PetInfoWnd_PetSlot);

				if (%IsIdentify)
				{
					%nChengZhangLv = PetOperation_GetPetChengZhangLv($PetInfoWnd_PetSlot);

					if (%nChengZhangLv >= 18 && %nChengZhangLv < 840){ %PinZhi = "<t c= '0xffffffff'>「普通」</t>"; }
					else if (%nChengZhangLv >= 840 && %nChengZhangLv < 1560){ %PinZhi = "<t c= '0x46ff15ff'>「优秀」</t>"; }
					else if (%nChengZhangLv >= 1560 && %nChengZhangLv < 2220){ %PinZhi = "<t c= '0x226fffff'>「精英」</t>"; }
					else if (%nChengZhangLv >= 2220 && %nChengZhangLv < 2860){ %PinZhi = "<t c= '0xca57ffff'>「完美」</t>"; }
					else if (%nChengZhangLv >= 2860 && %nChengZhangLv < 3300){ %PinZhi = "<t c= '0xff9600ff'>「传说」</t>"; }
					else if (%nChengZhangLv >= 3300){ %PinZhi = "<t c= '0xff1200ff'>「逆天」</t>"; }

					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>当前神兽潜力为：</t>"@ %PinZhi @"<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>·通过神兽洗炼操作可改变神兽潜力</t><b/><t>普通：神兽加点时获得正常的属性成长</t><b/><t c='0x26da13ff'>优秀：神兽加点时获得额外20%的属性成长</t><b/><t c='0x226fffff'>精英：神兽加点时获得额外40%的属性成长</t><b/><t c='0xca57ffff'>完美：神兽加点时获得额外60%的属性成长</t><b/><t c='0xff9600ff'>传说：神兽加点时获得额外80%的属性成长</t><b/><t c='0xff1200ff'>逆天：神兽加点时获得额外100%的属性成长</t></t>";
				}
				else
				{
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽潜力   </t><t c= '0xff1200ff'>未鉴定</t><b/><t c='0x5adfffff'>可在慕容心处鉴定潜力</t><b/><t>普通：神兽加点时获得正常的属性成长</t><b/><t c='0x26da13ff'>优秀：神兽加点时获得额外20%的属性成长</t><b/><t c='0x226fffff'>精英：神兽加点时获得额外40%的属性成长</t><b/><t c='0xca57ffff'>完美：神兽加点时获得额外60%的属性成长</t><b/><t c='0xff9600ff'>传说：神兽加点时获得额外80%的属性成长</t><b/><t c='0xff1200ff'>逆天：神兽加点时获得额外100%的属性成长</t></t>";
				}

				//====================================================================================大地图===========================================================================================================

			case "BigViewMap_Xpos"://X坐标
				%ctrl.tooltipWidth = 140;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>输入X坐标点</t><b/><t>输入区间为[1-100]</t></t>";

			case "BigViewMap_Ypos"://Y坐标
				%ctrl.tooltipWidth = 140;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>输入Y坐标点</t><b/><t>输入区间为[1-100]</t></t>";

			case "BigViewMapBtn_Startoff"://出发按钮
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>坐标寻径</t><b/><t>输入X、Y坐标点，点击按钮，角色自动寻径到目标点</t></t>";
			case "RecordPosButton"://记录坐标
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip =
					"<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>记录传送点</t><b/>" @
					"<t>在当前角色的坐标处记录一个标记后，可以直接点击标记传送到此处。</t><b/>" @
					"<t>每次传送需要消耗一个</t><t c='0xff65feff' o='0x2c2c2cff'>[星界石]</t><b/>" @
					"<t>此功能只能在野外地图、蓬莱、昆仑城使用</t></t>";

			case "BigViewMap_MaterialSign0":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[0];//生活材料标记
			case "BigViewMap_MaterialSign1":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[1];//生活材料标记
			case "BigViewMap_MaterialSign2":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[2];//生活材料标记
			case "BigViewMap_MaterialSign3":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[3];//生活材料标记
			case "BigViewMap_MaterialSign4":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[4];//生活材料标记
			case "BigViewMap_MaterialSign5":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[5];//生活材料标记
			case "BigViewMap_MaterialSign6":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[6];//生活材料标记
			case "BigViewMap_MaterialSign7":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[7];//生活材料标记
			case "BigViewMap_MaterialSign8":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[8];//生活材料标记
			case "BigViewMap_MaterialSign9":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[9];//生活材料标记
			case "BigViewMap_MaterialSign10":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[10];//生活材料标记
			case "BigViewMap_MaterialSign11":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[11];//生活材料标记
			case "BigViewMap_MaterialSign12":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[12];//生活材料标记
			case "BigViewMap_MaterialSign13":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[13];//生活材料标记
			case "BigViewMap_MaterialSign14":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[14];//生活材料标记
			case "BigViewMap_MaterialSign15":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[15];//生活材料标记
			case "BigViewMap_MaterialSign16":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[16];//生活材料标记
			case "BigViewMap_MaterialSign17":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[17];//生活材料标记
			case "BigViewMap_MaterialSign18":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[18];//生活材料标记
			case "BigViewMap_MaterialSign19":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[19];//生活材料标记
				//====================================================================================主界面icon显示热感===========================================================================================================


			case "UpLinePartyTurnOnBnt_Tips"://今日可接取的目标任务
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>接取今日目标</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >左键点击打开今日目标界面接取任务和领取奖励</t></t>";

			case "WuHun"://武魂按钮
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>武魂</t><b/><t>左键点击打开武魂背包，等级越高的武魂增加的人物属性越多</t><b/><t c='0x00ff00ff' >武魂可以通过搜魂获得</t></t>";

			case "JingMai"://经脉
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>经脉</t><b/><t>通过不断强化自身的任督冲三脉，可提升自身属性</t><b/><t c='0x00ff00ff' >经脉强化材料可在剧情副本中获得</t></t>";

			case "PlayerLevelOperateCue_1"://选择职业技能
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>选择职业技能</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >达到1修可前往圣地技能师处选择主职业技能</t></t>";

			case "PlayerLevelOperateCue_2"://领取化神
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>领取化神</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >达到2修可在圣地化神技能师处免费领取化神，使您在战斗力和外形上更加强大</t></t>";

			case "PlayerLevelOperateCue_3"://领取星宿
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>领取星宿</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >达到3修可领取集绚丽外表和自动战斗于一体的星宿</t></t>";

			case "PlayerLevelOperateCue_4"://仙术法典
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>仙术法典</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >达到4修完成仙术引导任务，便可熟练地使用所有仙术功能</t></t>";

			case "PlayerLevelOperateCue_5"://领取圣地专属坐骑
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>学习生活技能</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >到长安的太白金星会引导你学习生活技能，让您走上一条快速致富的道路</t></t>";

			case "PlayerLevelOperateCue_6"://加入/创建帮派
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>加入/创建帮派</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >可到长安或洛阳的帮派管理李密处加入/创建帮派</t></t>";

			case "PlayerLevelOperateCue_7"://收徒
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>收徒</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >可到长安的宁道奇处建立师徒关系，可获得丰厚经验哦</t></t>";

			case "PlayerLevelOperateCue_8"://选择第二职业
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>选择第二职业技能</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >达到6修可前往圣地技能师处选择第二职业技能</t></t>";

			case "PlayerLevelOperateCue_9"://拥有神兵
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>拥有神兵</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >达到6修可在洛阳神兵管理的张鸦九处打造一把帅气拉风，秒人于瞬间的神兵</t></t>";

			case "XiTurnOnBnt_Tips"://运营活动
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>昆仑决活动</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >左键点击打开当前昆仑决官网内进行的活动，参加活动可获得官方丰厚的奖品</t></t>";

			case "ExchangePoints_Min_Bnt"://装备兑换提示

				if ($CurSelectModeId == 0){ %KJJ ="<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>快速打开界面点击快捷键：N</t>"; }
				else if ($CurSelectModeId == 1){ %KJJ =""; }
				else if ($CurSelectModeId == 2){ %KJJ ="<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>快速打开界面点击快捷键：N</t>"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("打开/关闭积分商店界面") !$= "")
						%KJJ = "<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>快速打开界面点击快捷键：" @ GetHotKey("打开/关闭积分商店界面") @ "</t>";
				}

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>积分兑换</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >采用活动积分和战场积分可兑换当前有最适合您的装备</t>"@ %KJJ @"</t>";


				//====================================================================================功能操作界面===========================================================================================================

			case "TrumpInlayBmp_Explain"://镶嵌说明
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>镶嵌条件：</t><b/><t>1、星宿等级满足碎片的等级要求</t><b/><t>2、星宿碎片颜色与星宿镶嵌槽的颜色一致</t><b/><t>3、星宿品质满足碎片的品质要求</t><b/><t>4、角色活力大于等于20点</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>镶嵌规则：</t><b/><t>1、完成镶嵌的星宿在装备后，碎片的属性会加成到角色上</t><b/><t>2、同一个镶嵌槽中嵌入3个相同的碎片会自动组合成完成1个完整的配件</t><b/><t>3、在镶嵌槽中嵌入不同类型的碎片，旧的碎片会删除</t></t>";


			case "TrumpPuddlerBmp_Tips"://炼制说明
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>炼制条件：</t><b/><t>1、主星宿和副星宿要求等级25级且品质相同</t><b/><t>2、拥有足够的炼制材料</t><b/><t>3、需要消耗元宝</t><b/><t>4、星宿有剩余的炼制次数</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>炼制规则：</t><b/><t>1、炼制有成功率，普通星宿为90%，高级星宿为70%，特级星宿为50%</t><b/><t>2、炼制成功，主星宿的品质会提升</t><b/><t>3、不论炼制是否成功，副星宿都会消失</t></t>";


				//====================================================================================昆仑决商城===========================================================================================================

			case "BusinessCity_Recharge_Btn"://充值
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元宝充值</t><b/><t>可以到网页或者通过绑定的支付宝账号充值，充值后需要到“提取元宝”按钮处提取元宝才可以在服务器使用</t></t>";

			case "Vip_TodayGoalWnd_2_GetYuanBao"://VIP特权中心提取元宝
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>提取元宝</t><b/><t>充值后，需要在这里提取元宝才可以在本服务器使用</t></t>";

			case "BusinessCity_Drawing_Btn"://提取元宝
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>提取元宝</t><b/><t>充值后，需要在这里提取元宝才可以在本服务器使用</t></t>";

			case "BusinessCity_XianRock"://元宝
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元宝</t><b/><t>可在时装商城中购买时装，拍卖行中购买其他玩家出售的道具</t></t>";


				//====================================================================================帮派界面===========================================================================================================
			case "Family_CreatorWnd_CreateBTN"://创建帮派
				%ctrl.tooltipWidth = 275;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>创建帮派</t><b/><t>1、输入要创建的帮派名，点击确定，检测帮派名是否可创建</t></t>";

			case "Family_Wnd1_ChgAfficheBTN"://
				%ctrl.tooltipWidth = 275;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>修改帮派公告</t><b/><t>点击激活帮派公告编辑区，输入公告后，点击修改公告按钮，更新最新帮派公告</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>帮主和副帮主都有修改权限</t></t>";

			case "FamilyMemberMessage_Family_Info"://帮派等级说明
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>帮派成员等级所需贡献值条件：</t><b/><t>【新进帮众】：0～1000</t><b/><t>【普通帮众】：1000～10000</t><b/><t>【普通精英】：10000～30000</t><b/><t>【高级精英】：30000～100000</t><b/><t>【帮派元老】：100000～999999</t></t>";

			case "FamilyBaseBnt_ApoointMember"://任命
				%ctrl.tooltipWidth = 275;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>帮派职位任命</t><b/><t>1.帮主可以任命帮派成员为副帮主或堂主</t><b/><t>2.选择当前职位的玩家可以进行撤职操作</t><b/><t>3.每个玩家最多只能担任一个职位</t></t>";

			case "FamilyBaseText_Name"://帮派名称
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>帮派名称</t><b/><t>创建后帮派名称不可修改</t></t>";

			case "FamilyBaseText_LeaderName"://帮主
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>帮派帮主</t><b/><t>帮主和副帮主能添加成员和请离成员</t></t>";

			case "FamilyBaseText_Money"://帮派资金
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>帮派资金</t><b/><t>帮派成员可通过</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>跑商</t><t>和</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>捐献</t><t>来增加帮派资金，帮主可利用帮派资金进行帮派物资的研发和制造</t></t>";

			case "FamilyBaseText_Credit"://帮派声望
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>帮派声望</t><b/><t>1、显示：当前帮派声望值/帮派升下一级所需声望值</t><b/><t>2、帮派成员可通过完成帮派任务获得声望，帮派声望提高可提升帮派等级</t></t>";

			case "FamilyBaseText_Level"://帮派等级
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>帮派等级</t><b/><t>1、当前帮派声望达到升级所需声望值，帮主即可前往长安</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>李密</t><t>处提升帮派等级</t><b/><t>2、帮派等级越高可加入成员越多，还能制造更多的帮派物资</t></t>";

			case "FamilyBaseText_Activity"://帮派活跃度
				%ctrl.tooltipWidth = 340;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>帮派活跃度</t><b/><t>1、显示：当前帮派活跃度/当前帮派等级所需活跃度最小值</t><b/><t>2、活跃度是由所有帮派成员的当前活跃度累加而成</t><b/><t>3、只要帮派成员在线，完成帮派任务、参加活动、击败</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>不低于自己等级10级以上</t><t>的怪物都会增加一定活跃值</t><b/><t>4、活跃度会影响帮派</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>帮派声望</t><t>，但当前活跃值低于所需最小值时，将减少当前</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>30%</t><t>的帮派声望值</t></t>";

			case "Family_Wnd1ListBtn_memberLevel"://个人信息中的成员等级
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>帮派成员等级所需贡献值条件：</t><b/><t>【新进帮众】：0～1000</t><b/><t>【普通帮众】：1000～10000</t><b/><t>【普通精英】：10000～30000</t><b/><t>【高级精英】：30000～100000</t><b/><t>【帮派元老】：100000～999999</t></t>";

			case "Family_Wnd1ListBtn_level_Family"://帮派信息中的成员等级
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>帮派成员等级所需贡献值条件：</t><b/><t>【新进帮众】：0～1000</t><b/><t>【普通帮众】：1000～10000</t><b/><t>【普通精英】：10000～30000</t><b/><t>【高级精英】：30000～100000</t><b/><t>【帮派元老】：100000～999999</t></t>";

			case "FamilyBaseBmp_Business"://帮派跑商权
				if (FamilyBaseText_Business.GetText()$="0/0")
				{
					%ctrl.tooltipWidth = 265;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t gct='0xff7171ff' gcb='0xff3c00ff'>您的帮派未能进入活跃度排行榜，还未拥有跑商权</t><b/><t>每天只有进入帮派活跃度排行榜的2级以上帮派才可拥有跑商权</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>今日帮派跑商将会奖励大量金币</t></t>";
				}
				else
				{
					%ctrl.tooltipWidth = 250;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>您的帮派已拥有跑商权</t><b/><t>每天只有进入帮派活跃度排行榜的2级以上帮派才可拥有跑商权</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>今日帮派跑商将会奖励大量金币和额外的人物经验</t></t>";
				}
			case "FamilyBaseText_Business"://跑商权次数
				if (FamilyBaseText_Business.GetText()$="0/0")
				{
					%txt ="<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>您的帮派未能进入活跃度排行榜，还未拥有跑商权</t>";
				}
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>显示跑商权的剩余申请次数</t>"@ %txt @"</t>";

			case "FamilyBaseBnt_AddMember"://添加成员
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>添加成员</t><b/><t>帮主和副帮主可主动邀请无帮派的玩家加入帮派</t></t>";

			case "FamilyBaseBnt_List"://申请列表
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>申请列表</t><b/><t>帮主和副帮主可打开申请列表界面，允许提交申请加入的玩家进入帮派，并可设置自动允许玩家加入帮派</t></t>";

			case "FamilyBaseBnt_ChangeReMark"://修改备注
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>修改备注</t><b/><t>帮主和副帮主可对帮派内的成员添加备注说明</t></t>";

			case "FamilyBaseBnt_SetViceLeader"://设置副帮主
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>副帮主设置</t><b/><t>帮主可设置2位副帮主一起辅助管理帮派</t></t>";

				//			case "FamilyBaseBnt_GetPay"://领工资
				//				%ctrl.tooltipWidth = 220;
				//				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>领取工资</t><b/><t>仅在</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>周日</t><t>才可将自己的帮派货币以1:50的比例转换为金币</t></t>";

			case "FamilyBaseBnt_TransferLeader"://转让帮主
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>转让帮主</t><b/><t>帮主可将自己的职位转让其他的玩家</t></t>";

			case "FamilyBaseBnt_KickOut"://请离帮派
				%ctrl.tooltipWidth = 215;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>请离帮派</t><b/><t>帮主和副帮主可将帮派成员请离帮派</t></t>";

			case "FamilyBaseBnt_LevelFamily"://退出帮派
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>退出帮派</t><t gct='0xff7171ff' gcb='0xff3c00ff'> （慎重）</t><b/><t>退出帮派后重新加入，只保留80%的帮派贡献与帮派货币，如果加入新的帮派，则全部清空</t></t>";

			case "Family_Examine_Family_Memeber_Info"://查看帮众等级说明
				%ctrl.tooltipWidth = 285;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>帮众等级说明</t><b/><t>1、增加对帮派的贡献值会提升帮众等级，通过完成帮派任务、跑商、捐献等都会获得帮派贡献值</t><b/><t>2、帮众晋级说明：</t><b/><t>【新进帮众】：0～1000贡献值</t><b/><t>【普通帮众】：1000～10000贡献值</t><b/><t>【普通精英】：10000～30000贡献值</t><b/><t>【高级精英】：30000～100000贡献值</t><b/><t>【帮派元老】：100000～999999贡献值</t></t>";

			case "FamilyBaseText_OnlineCounts"://成员人数
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>成员人数</t><b/><t>1、显示：帮派已收人数/当前帮派等级可收人数</t><b/><t>2、提升帮派等级会增加可加入的成员人数上限</t></t>";

			case "FamilyBaseText_MyContribute"://我的贡献值
				%ctrl.tooltipWidth = 295;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>我的帮派贡献值</t><b/><t>1、通过完成帮派任务、跑商、捐献等都会获得帮派贡献值</t><b/><t>2、帮派贡献值提高可提升相应在帮派内的帮众等级</t></t>";

			case "FamilyBaseText_MyLevel"://我的帮派等级
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>我的帮众等级</t><b/><t>帮众等级可以通过提高对帮派的贡献值而提升等级</t><b/><t>帮众等级等级越高，帮派任务的奖励就越丰厚</t><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>帮众等级说明</t><b/><t>1、通过完成帮派任务、跑商、捐献等都会获得帮派贡献值</t><b/><t>2、帮众晋级说明：</t><b/><t>【新进帮众】：0～1000贡献值</t><b/><t>【普通帮众】：1000～10000贡献值</t><b/><t>【普通精英】：10000～30000贡献值</t><b/><t>【高级精英】：30000～100000贡献值</t><b/><t>【帮派元老】：100000～999999贡献值</t></t>";

			case "FamilyBaseText_MyMonmey"://我的帮派货币
				%ctrl.tooltipWidth = 305;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>我的帮派货币</t><b/><t>1、帮派货币只能通过【帮派跑商任务】获得</t><b/><t>2、帮派货币可在帮派物资内购买各种物品</t><b/><t>3、离开帮派会清空帮派货币</t></t>";

			case "Family_Wnd2_Bnt"://接取帮派任务
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>接取帮派任务</t><b/><t>同时只能接取一个帮派任务</t><b/><t>完成帮派可以获得大量的人物经验和增加帮派荣誉值</t></t>";

			case "Family_Wnd4_SetCumulateBTN"://设置建设副本
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>设置建设副本</t><b/><t>帮主或副帮主设置好建设副本，帮众才能给设置的副本进行建设</t></t>";

			case "Family_Wnd4_CumulateBTN"://点击虚灵
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>点击捐献</t><b/><t>捐献进度达到100%后帮主可开启帮派副本。开启副本后进度归零。</t></t>";

			case "Family_Wnd6_AddFamily"://添加帮派
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>添加帮派</t><b/><t>盟主和副盟主可主动邀请无血盟的帮派加入血盟</t></t>";

			case "Family_Wnd6_AskedList"://申请列表
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>申请列表</t><b/><t>盟主和副盟主可打开申请列表界面，允许提交申请加入的帮派进入血盟，并可设置自动允许帮派加入血盟</t></t>";

			case "Family_Wnd6_FamilyReMark"://帮派备注
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>修改帮派备注</t><b/><t>盟主和副盟主可对血盟内的帮派添加备注说明</t></t>";

			case "Family_Wnd6_TransferLeagueLeader"://转让盟主
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>转让盟主</t><b/><t>盟主可将自己的职位转让其他帮派的帮主</t></t>";

			case "Family_Wnd6_KickOutLeague"://请离血盟
				%ctrl.tooltipWidth = 215;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>请离血盟</t><b/><t>盟主和副盟主可将血盟内的帮派请离本血盟</t></t>";

			case "Family_Wnd6_LeaveLeague"://退出血盟
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>退出血盟</t><t gct='0xff7171ff' gcb='0xff3c00ff'> （慎重）</t><b/><t>退出血盟会清空跟本血盟有关的信息</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>帮派的帮主才能进行退出血盟操作</t></t>";

			case "Family_Wnd6_Domain"://领地
				%ctrl.tooltipWidth = 80;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>血盟领地</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>尚未开放</t></t>";

			case "Family_Wnd6_HolePlace"://洞天福地
				%ctrl.tooltipWidth = 80;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>洞天福地</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>尚未开放</t></t>";

			case "Family_Wnd6_Business_bitmap"://帮派跑商权
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t gct='0x00ff00ff' gcb='0x2cffeeff'>显示帮派是否拥有跑商权</t><b/><t>每天只有本服务器中帮派活跃度排名前30位的2级以上帮派才可拥有跑商权</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>可通过跑商获得大量金币</t></t>";

			case "Family_Wnd6_text1"://血盟名称
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>血盟名称</t><b/><t>创建后血盟名称不可修改</t></t>";

			case "Family_Wnd6_text2"://血盟等级
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>血盟等级</t><b/><t>由拥有的帮派等级之和决定，因此会随着帮派的进入和退出变化</t><b/><t>·血盟1级：帮派等级之和为1-8</t><b/><t>·血盟2级：帮派等级之和为9-17</t><b/><t>·血盟3级：帮派等级之和为18</t></t>";

			case "Family_Wnd6_text3"://血盟盟主
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>血盟盟主</t><b/><t>只有盟主和副盟主才能添加帮派和请离帮派等权限</t></t>";

			case "Family_Wnd6_text4"://血盟成员人数
				%ctrl.tooltipWidth = 275;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>血盟成员人数</t><b/><t>1、显示：血盟已有人数/血盟可收总人数</t><b/><t>血盟可收总人数为血盟内帮派的可收人数总和</t></t>";

			case "Family_Wnd6_text5"://血盟副盟主
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>血盟副盟主</t><b/><t>只有盟主和副盟主才能添加帮派和请离帮派等权限</t><b/><t>副盟主由血盟内帮派声望最高的帮主担任（除盟主帮派外）</t></t>";

			case "Family_Wnd6_text6"://血盟声望
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>血盟声望</t><b/><t>血盟声望为血盟内所有帮派声望的总和决定，总和越高血盟声望越高</t></t>";

			case "Family_Wnd6_text7"://帮派帮主
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>帮派帮主</t><b/><t>血盟内帮派的帮主名称</t></t>";

			case "Family_Wnd6_text8"://帮派人数
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>帮派人数</t><b/><t>选中帮派的成员人数</t></t>";

			case "Family_Wnd6_ChgLeagueAfficheBTN"://修改公告
				%ctrl.tooltipWidth = 275;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>修改血盟公告</t><b/><t>点击激活血盟公告编辑区，输入公告后，点击修改公告按钮，更新最新血盟公告</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>只有盟主和副盟主有修改权限</t></t>";

			case "Family_Wnd6_League_Affiche"://血盟公告
				%ctrl.tooltipWidth = 275;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>血盟公告</t><b/><t>盟主和副盟主可激活公告编辑区，发布血盟公告，点击修改公告按钮，所有血盟成员都能查看到最新的血盟公告</t></t>";

			case "Family_Wnd1ListBtn_state"://贡献值
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'>贡献值影响帮派成员等级</t>";

				//====================================================================================活动控件热感===========================================================================================================

			case "KillPointCountGUI_Count"://战斗积分
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>战斗积分说明</t><b/><t>一层晋级二层 战斗积分：12/12</t><b/><t>二层晋级三层 战斗积分：30/30</t><b/><t>三层晋级四层 战斗积分：54/54</t><b/><b/><t>二层降级一层 战斗积分：0/12</t><b/><t>三层降级二层 战斗积分：12/30</t><b/><t>四层降级三层 战斗积分：30/54</t></t>";

			
				//====================================================================================固定摊位===========================================================================================================

			case "FixedStaller_TaxTxt"://每日税额
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>每日税额</t><b/><t>每天凌晨12点系统从固定资金中扣除</t><b/><t>当固定资金数量不足支付每日税额时，商铺的所有权将被清除，一定要保证固定资金充裕</t></t>";

			case "FixedStaller_GloryTxt"://繁荣度
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>商铺繁荣度</t><b/><t>繁荣度越高，交易时系统所收的税收就越低</t><b/><t>每开启一页出售物品页或出售神兽页，繁荣度自动增加10点</t></t>";

			case "FixedStaller_RevenueTxt"://税收
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>交易税收</t><b/><t>物品出售后，系统会按照税收百分比收取交易税</t><b/><t>商铺的繁荣度越高所收的交易税越低</t></t>";

			case "FixedStall_TipIcon"://每日税额
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>每日税额</t><b/><t>每天凌晨0点系统从固定资金中扣除</t><b/><t>当固定资金数量不足支付每日税额时，商铺的所有权将被清除，一定要保证固定资金充裕</t></t>";

			case "FixedStaller_Revenue"://税收
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>交易税收</t><b/><t>物品出售后，系统会按照税收百分比收取交易税</t><b/><t>商铺的繁荣度越高所收的交易税越低</t></t>";

			case "FixedStaller_Glory"://繁荣度
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>商铺繁荣度</t><b/><t>繁荣度越高，交易时系统所收的税收就越低</t><b/><t>每开启一页出售物品页或出售神兽页，繁荣度自动增加10点</t></t>";

			case "FixedStaller_TaxTxt"://每日税额
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>每日税额</t><b/><t>每天凌晨12点系统从流动资金中扣除</t><b/><t>当流动资金数量不足支付每日税额时，商铺的所有权将被清除，一定要保证流动资金充裕</t></t>";

				//====================================================================================星宿界面战斗助手界面===========================================================================================================


			case "FightAssistant_Skill_ShortcutWnd_StartFightBtn"://开启星宿挂机
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>开启自动战斗（快捷键：=）</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>装备星宿后即可使用</t><b/><t>可在自动战斗设置（快捷键：Z）中设定技能和自动战斗范围等</t></t>";

			case "FightAssistant_Skill_ShortcutWnd_StopFightBtn"://关闭星宿挂机
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>关闭自动战斗（快捷键：=）</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>装备星宿后即可使用</t><b/><t>可在自动战斗设置（快捷键：Z）中设定技能和自动战斗范围等</t></t>";

			case "FightAssistant_LeftTime"://关闭星宿挂机
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>挂机保护剩余时间</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>每日0时重置为360分钟</t><b/><t>进入挂机保护状态后，将持续消耗此时间；时间不足时，将失去挂机保护状态</t></t>";


				/*
				case "FightAssistant_Skill_ShortcutWnd_FightBtn"://星宿挂机按钮
				%ctrl.tooltipWidth = 260;
				if (FightAssistant_Skill_ShortcutWnd_FightEffect.isVisible()) //按钮特效处于显示状态
				{
				%txt1="自动战斗开启中";
				%txt2="<t gct='0x00ff00ff' gcb='0x2cffeeff'>自动战斗将持续消耗星宿的智力值</t><b/><t>自动战斗时释放的技能需进入战斗助手进行设置</t>";
				}
				else
				{
				%txt1="自动战斗已关闭";
				%txt2="<t gct='0x00ff00ff' gcb='0x2cffeeff'>点击按钮可开启星宿自动战斗能力</t><b/><t>自动战斗时释放的技能需进入战斗助手进行设置</t>";
				}
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@%txt1 @"</t><b/><t>"@ %txt2@"</t></t>";
				*/
			case "FightAssistantBnt_Start"://开启星宿挂机
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>开启自动战斗（快捷键：=）</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>装备星宿后即可使用</t><b/><t>可勾选打开自动战斗快捷栏，快速便捷的开启与关闭自动战斗功能</t></t></t>";


			case "FightAssistantBnt_End"://关闭星宿挂机
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>关闭自动战斗（快捷键：=）</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>装备星宿后即可使用</t><b/><t>可勾选打开自动战斗快捷栏，快速便捷的开启与关闭自动战斗功能</t></t></t>";



				//====================================================================================天镜界面===========================================================================================================
			case "BirdTianJingButton"://天镜

				if (IsInArena())

				{
					%width=190;
					%txt="<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>天镜（竞技场中）</t><b/><t>目前您处于竞技场地图中</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击可查看竞技场统计信息</t>";
				}
				else if (GetZoneID()==1136 || IsInBattlefield())
				{
					%width=180;
					%txt="<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>天镜（战场中）</t><b/><t>目前您处于战场地图中</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击可查看战场统计信息</t>";
				}
				else
				{
					%nState =	SptRandTeamGetState();
					if (%nState == 1)
					{
						%width=260;
						%txt1="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>单人可直接打开天镜进行随机组队</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>组队状态下只有队长才能打开天镜选择要进入的副本</t>";

						%txt="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>天镜（随机组队）</t><b/><t>帮您快速的组成一支队伍，然后进入活动、副本、战场、竞技场。</t>"@ %txt1 @"";
					}

					else if ((%nState == 4)||(%nState == 5))
					{
						%width=240;
						%txt="<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>天镜（排队状态）</t><b/><t>目前您处于排队状态</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>打开队列等待界面，查看排队信息</t>";
					}
					else if (%nState == 6)
					{
						if (IsInCopyMap()==0)
						{
							%txt1="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击天镜按钮直接进入副本</t>";
						}
						else if (IsInCopyMap()==1)
						{
							%txt1="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>右键点击天镜按钮直接传出副本</t>";
						}
						%width=260;
						%txt="<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>天镜（排队完毕）</t><b/><t>目前您已经排队完毕</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>打开队列等待界面，点击进入按钮进副本</t>"@ %txt1 @"";
					}
				}

				%ctrl.tooltipWidth = %width;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'>"@ %txt @"</t>";

			case "RandomTeamRole_Defence"://副本随机-防御者
				if (RandomTeamRole_Defence.isActive()==0){ %txt="<b/><t c= '0xff1200ff'>您的职业不适合，无法选择此角色</t>"; }
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>防御者(武将)</t><b/><t>小队最坚强的壁垒</t><b/><t>主要负责吸引敌人仇恨并承担伤害</t>"@ %txt @"</t>";

			case "RandomTeamRole_Doctor"://副本随机-治疗者
				if (RandomTeamRole_Doctor.isActive()==0){ %txt="<b/><t c= '0xff1200ff'>您的职业不适合，无法选择此角色</t>"; }
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>治疗者(丹士)</t><b/><t>小队最依赖的后盾</t><b/><t>主要负责治疗小队成员</t>"@ %txt @"</t>";

			case "RandomTeamRole_Attacker"://副本随机-伤害者
				if (RandomTeamRole_Attacker.isActive()==0){ %txt="<b/><t c= '0xff1200ff'>您的职业不适合，无法选择此角色</t>"; }
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>伤害者</t><b/><t>小队最勇猛的输出</t><b/><t>主要负责对敌人输出大量伤害</t>"@ %txt @"</t>";



				//===============================================================================================武魂界面==================================================================================

				//exec("gameres/Data/Quest/Client/C_Tooltips.cs");


			case "SeeStarWnd_PickBtn"://一键拾取武魂
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'  f='黑体' n='14' >拾取所有武魂</t><b/><t>将绿色以上武魂全部拾取到武魂背包</t><b/><t>优先拾取品质高的武魂</t></t>";

			case "SeeStarWnd_SellBtn"://一键卖出灰色武魂
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'  f='黑体' n='14' >卖出所有灰色武魂</t><b/><t>将搜魂获得的灰色武魂全部卖出</t><b/><t>绿色以上武魂需要单独右键单击武魂才能卖出</t></t>";

			case "SeeStarWnd_ExchangeBtn"://领取武魂碎片
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'  f='黑体' n='14' >领取武魂碎片</t><b/><t>当您搜魂次数累计每到达1000次，即可赠送一个武魂碎片</t><b/><t>武魂碎片可兑换紫色，橙色武魂</t></t>";

			case "SeeStarWnd_XingXiangSuiPianTxt"://赠送武魂碎片
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'  f='黑体' n='14' >赠送武魂碎片</t><b/><t>当您搜魂次数累计每到达1000次，即可赠送一个武魂碎片</t><b/><t>武魂碎片可兑换紫色，橙色武魂</t></t>";

			case "SeeStarWnd_XingXiangSuiPianValue"://赠送武魂碎片
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'  f='黑体' n='14' >赠送武魂碎片</t><b/><t>当您搜魂次数累计每到达1000次，即可赠送一个武魂碎片</t><b/><t>武魂碎片可兑换紫色，橙色武魂</t></t>";

			case "SeeStarWnd_XingXiangBtn"://武魂界面
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'  f='黑体' n='14' >点击打开武魂界面</t><b/><t>搜魂获得的武魂需要在武魂界面内进行装备和融合</t></t>";

			case "SeeStarWnd_StarBtn0"://算命先生
				if (SeeStarWnd_StarBtn0.isActive())
					%txt = "</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>(点击搜魂)";

				if (isFile("gameres/gui/images/GUIWindow31_1_031.png")){ %Reward2 = "<i s='gameres/gui/images/GUIWindow31_1_031.png' w='16' h='16'/>"; }
				else{ %Reward2 = "金币"; }//金币

				if (%Player.GetVipTimer(1) > 0)
					%XiaoHao = "原价消耗：</t><t f='黑体' m='0' n='14' c='0x696668ff'>10,000</t>" @ %Reward2 @ "<b/><t>神将半价：5,000</t>" @ %Reward2;
				else
					%XiaoHao = "需要消耗：10,000";

				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>算命先生"@ %txt @"</t><b/><t>" @ %XiaoHao @ "</t></t>";

			case "SeeStarWnd_StarBtn1"://云游道人
				if (SeeStarWnd_StarBtn1.isActive())
				{
					%ctrl.tooltipWidth = 150;
					%txt = "</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>(点击搜魂)";
				}
				else
				{
					%ctrl.tooltipWidth = 190;
					%txt1 = "<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>算命先生有几率邀请云游道人</t>";
				}

				if (isFile("gameres/gui/images/GUIWindow31_1_031.png")){ %Reward2 = "<i s='gameres/gui/images/GUIWindow31_1_031.png' w='16' h='16'/>"; }
				else{ %Reward2 = "金币"; }//金币

				if (%Player.GetVipTimer(1) > 0)
					%XiaoHao = "原价消耗：</t><t f='黑体' m='0' n='14' c='0x696668ff'>15,000</t>" @ %Reward2 @ "<b/><t>神将半价：7,500</t>" @ %Reward2;
				else
					%XiaoHao = "需要消耗：15,000";

				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>云游道人"@ %txt @"</t><b/><t>" @ %XiaoHao @ %txt1 @"</t></t>";

			case "SeeStarWnd_StarBtn2"://门阀谋士
				if (SeeStarWnd_StarBtn2.isActive())
					%txt = "</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>(点击搜魂)";
				else
					%txt1 = "<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>云游道人有几率邀请门阀谋士</t>";

				if (isFile("gameres/gui/images/GUIWindow31_1_031.png")){ %Reward2 = "<i s='gameres/gui/images/GUIWindow31_1_031.png' w='16' h='16'/>"; }
				else{ %Reward2 = "金币"; }//金币

				if (%Player.GetVipTimer(1) > 0)
					%XiaoHao = "原价消耗：</t><t f='黑体' m='0' n='14' c='0x696668ff'>30,000</t>" @ %Reward2 @ "<b/><t>神将半价：15,000</t>" @ %Reward2;
				else
					%XiaoHao = "需要消耗：30,000";

				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>门阀谋士"@ %txt @"</t><b/><t>" @ %XiaoHao @ "</t>"@ %txt1 @"</t>";

			case "SeeStarWnd_StarBtn3"://圣地长老
				if (SeeStarWnd_StarBtn3.isActive())
				{
					%ctrl.tooltipWidth = 160;
					%txt = "</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>(点击搜魂)";
				}
				else
				{
					%ctrl.tooltipWidth = 220;
					%txt1 = "<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>门阀谋士有几率邀请圣地长老或直接点击【邀请】</t>";
				}

				if (isFile("gameres/gui/images/GUIWindow31_1_031.png")){ %Reward2 = "<i s='gameres/gui/images/GUIWindow31_1_031.png' w='16' h='16'/>"; }
				else{ %Reward2 = "金币"; }//金币

				if (%Player.GetVipTimer(1) > 0)
					%XiaoHao = "原价消耗：</t><t f='黑体' m='0' n='14' c='0x696668ff'>60,000</t>" @ %Reward2 @ "<b/><t>神将半价：30,000</t>" @ %Reward2;
				else
					%XiaoHao = "需要消耗：60,000";

				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>圣地长老"@ %txt @"</t><b/><t>" @ %XiaoHao @ "</t>"@ %txt1 @"</t>";

			case "SeeStarWnd_StarBtn4"://大国师
				if (SeeStarWnd_StarBtn4.isActive())
				{
					%ctrl.tooltipWidth = 180;
					%txt = "</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>(点击搜魂)";
				}
				else
				{
					%ctrl.tooltipWidth = 200;
					%txt1 = "<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>圣地长老有几率邀请大国师</t>";
				}

				if (isFile("gameres/gui/images/GUIWindow31_1_031.png")){ %Reward2 = "<i s='gameres/gui/images/GUIWindow31_1_031.png' w='16' h='16'/>"; }
				else{ %Reward2 = "金币"; }//金币

				if (%Player.GetVipTimer(1) > 0)
					%XiaoHao = "原价消耗：</t><t f='黑体' m='0' n='14' c='0x696668ff'>120,000</t>" @ %Reward2 @ "<b/><t>神将半价：60,000</t>" @ %Reward2;
				else
					%XiaoHao = "需要消耗：120,000";

				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>大国师"@ %txt @"</t><b/><t>" @ %XiaoHao @ "</t>"@ %txt1 @"</t>";

			case "SeeStarWnd_AuguryBtn"://武魂界面
				if (isFile("gameres/gui/images/GUIWindow31_1_027.png")){ %Reward1 = "<i s='gameres/gui/images/GUIWindow31_1_027.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }//金元
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>邀请圣地长老</t><b/><t>花费500</t><t>"@ %Reward1 @"</t><t>直接花元宝激活圣地长老</t><b/><t>必然获得升级武魂经验的</t><t c='0xff5400ff'>【神魂】 </t><t>且有几率获得高级武魂</t></t>";


			case "SeeStarWnd_StarBtnVIP"://武魂VIP功能
				%ctrl.tooltipWidth = 290;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>VIP功能</t><t gct='0xff7171ff' gcb='0xff3c00ff'>（达到VIP5时开放）</t><b/><t>点击可显示武魂VIP功能操作界面</t><b/><t>1.自动元宝搜魂（自动执行【邀请】功能）</t><b/><t>2.自动融合紫色以下武魂</t><b/><t>3.自动出售灰色武魂</t></t>";


			case "XingXiangWnd_SeeStarBtn"://前往搜魂

				%Player = GetPlayer();
				%Family  = %Player.GetFamily();
				if (%family < 3)
				{
					%souhun = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>前往搜魂</t><b/><t>点击后自动前往长安城</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>跋锋寒</t><t>处搜魂</t></t>";
				}
				else
				{
					%souhun = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>前往搜魂</t><b/><t>点击后自动前往洛阳城</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>跋锋寒</t><t>处搜魂</t></t>";
				}


				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = %souhun;

			case "XingXiangWnd_CombinationAllBtn"://融合武魂
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>融合背包内所有武魂</t><b/><t>武魂通过融合其他武魂获得经验，升级后将大幅度提升属性能力</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>融合方式：</t><b/><t>1、拖动武魂覆盖至其他武魂（两个武魂之间融合）</t><b/><t>2、点击【融合背包内所有武魂】按钮融合</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>融合规则：</t><b/><t>1、高品质的武魂融合低品质的武魂</t><b/><t>2、高等级的武魂融合低等级的武魂</t><b/><t>3、武魂融合后，两武魂的经验会相加</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>武魂仓库内的武魂将不会被融合</t></t>";

			case "XingXiangWnd_DecomposeBtn"://分解武魂
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>分解武魂</t><b/><t>分解橙色武魂获得武魂碎片，碎片可兑换紫色、橙色武魂</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击切换为分解状态，指向武魂背包内橙色武魂即可分解</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>搜魂状态下无法分解武魂</t></t>";

			case "XingXiangWnd_FengBtn1"://武魂
				%ctrl.tooltipWidth = 130;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>点击开启武魂格</t></t>";

			case "XingXiangWnd_FengBtn2"://武魂
				%ctrl.tooltipWidth = 130;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>点击开启武魂格</t></t>";

			case "XingXiangWnd_FengBtn3"://武魂
				%ctrl.tooltipWidth = 130;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>点击开启武魂格</t></t>";

			case "XingXiangWnd_FengBtn4"://武魂
				%ctrl.tooltipWidth = 130;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>点击开启武魂格</t></t>";

			case "XingXiangWnd_FengBtn5"://武魂
				%ctrl.tooltipWidth = 130;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>点击开启武魂格</t></t>";

			case "XingXiangWnd_FengBtn6"://武魂
				%ctrl.tooltipWidth = 130;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>点击开启武魂格</t></t>";

			case "XingXiangWnd_FengBtn7"://武魂
				%ctrl.tooltipWidth = 130;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>点击开启武魂格</t></t>";

				/*case "XingXiangWnd_PlayerModelBmp"://阵眼角色
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>阵眼</t><b/><t>主角拥有八个阵眼，装备紫色以上武魂即可激活</t><b/><t>装备满8个紫色以上品质武魂即可唤醒阵眼获得高额附加属性</t></t>";
				*/
			case "XingXiangWnd_StarBmp0"://阵眼
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>阵眼</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>（已激活）</t><b/><t>相应的武魂格装备紫色武魂后即被激活</t><b/><t>装备满8个紫色以上品质武魂即可唤醒法阵获得高额附加属性</t></t>";

			case "XingXiangWnd_StarBmp1"://阵眼
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>阵眼</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>（已激活）</t><b/><t>相应的武魂格装备紫色武魂后即被激活</t><b/><t>装备满8个紫色以上品质武魂即可唤醒法阵获得高额附加属性</t></t>";

			case "XingXiangWnd_StarBmp2"://阵眼
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>阵眼</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>（已激活）</t><b/><t>相应的武魂格装备紫色武魂后即被激活</t><b/><t>装备满8个紫色以上品质武魂即可唤醒法阵获得高额附加属性</t></t>";

			case "XingXiangWnd_StarBmp3"://阵眼
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>阵眼</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>（已激活）</t><b/><t>相应的武魂格装备紫色武魂后即被激活</t><b/><t>装备满8个紫色以上品质武魂即可唤醒法阵获得高额附加属性</t></t>";

			case "XingXiangWnd_StarBmp4"://阵眼
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>阵眼</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>（已激活）</t><b/><t>相应的武魂格装备紫色武魂后即被激活</t><b/><t>装备满8个紫色以上品质武魂即可唤醒法阵获得高额附加属性</t></t>";

			case "XingXiangWnd_StarBmp5"://阵眼
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>阵眼</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>（已激活）</t><b/><t>相应的武魂格装备紫色武魂后即被激活</t><b/><t>装备满8个紫色以上品质武魂即可唤醒法阵获得高额附加属性</t></t>";

			case "XingXiangWnd_StarBmp6"://阵眼
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>阵眼</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>（已激活）</t><b/><t>相应的武魂格装备紫色武魂后即被激活</t><b/><t>装备满8个紫色以上品质武魂即可唤醒法阵获得高额附加属性</t></t>";

			case "XingXiangWnd_StarBmp7"://阵眼
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>阵眼</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>（已激活）</t><b/><t>相应的武魂格装备紫色武魂后即被激活</t><b/><t>装备满8个紫色以上品质武魂即可唤醒法阵获得高额附加属性</t></t>";

			case "XingXiangWnd_ArouseBtn"://已激活阵眼

				if (XingXiangWnd_ArouseBtn.GetText()$="唤醒青龙法阵")
				{
					%ctrl.tooltipWidth = 250;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>未唤醒法阵</t><b/><t>装备满8个紫色以上品质武魂即可唤醒法阵</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>法阵等级与装备中的最低等级的武魂等级一致</t></t>";
				}
				else
				{
					%ctrl.tooltipWidth = 250;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>已唤醒法阵</t><b/><t>如装备的武魂不满足唤醒条件，法阵附加属性将消失，需要满足条件后重新唤醒</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>法阵等级与装备中的最低等级的武魂等级一致</t></t>";
				}


			case "XingXiangWnd_JingJieBtn0"://法阵
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>法阵</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>（使用中）</t><b/><t>装备满8个紫色以上品质武魂即可唤</t><b/><t>法阵等级与装备中的最低等级的武魂等级一致</t></t>";


			case "XingXiangWnd_PlayerModelBmp"://激活阵眼flash

				%Player = GetPlayer();
				%txt0="<b/><i s='gameres/gui/images/GUIWindow99_1_007.png' w='210' h='9'/><b/><t c='0x00ff00ff'>  法阵等级越高激活的属性越高</t>";
				%txt10="<b/><i s='gameres/gui/images/GUIWindow99_1_007.png' w='210' h='9'/><b/><t c='0x1ebe14ff'>下一阶法阵：</t>";

				if (%Player==0) return;

				%Family  = %Player.GetFamily();
				%Classes = %Player.GetClasses(0);
				%lidao_or_zhili = %Player.GetClasses(0);
				if (%lidao_or_zhili == 1){ %lidao_or_zhili1 = "力道";%gongjishanghai1 = "物理";%wuxigongji1 = "土"; }
				else  if (%lidao_or_zhili == 2){ %lidao_or_zhili1 = "力道";%gongjishanghai1 = "物理";%wuxigongji1 = "金"; }
				else  if (%lidao_or_zhili == 3){ %lidao_or_zhili1 = "智力";%gongjishanghai1 = "法术";%wuxigongji1 = "火"; }
				else  if (%lidao_or_zhili == 4){ %lidao_or_zhili1 = "智力";%gongjishanghai1 = "法术";%wuxigongji1 = "冰"; }
				else  												{ %lidao_or_zhili1 = "力道";%gongjishanghai1 = "物理";%wuxigongji1 = "毒"; }


				if (%Player.getCurrXingMaiLevel()==1)
				{
					%size ="230";%txt="         一阶法阵";
					%txt1="<b/><t c='0x4383d4ff'><t>所受到的伤害-10</t><b/><t>最大体力+150</t></t>";
					%txt1_1="<b/><t c='0x969399ff'><t>所受到的伤害-20</t><b/><t>最大体力+300</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"攻击+150</t></t>";
				}
				else if (%Player.getCurrXingMaiLevel()==2)
				{
					%size ="230";%txt="         二阶法阵";
					%txt1="<b/><t c='0x4383d4ff'><t>所受到的伤害-20</t><b/><t>最大体力+300</t>";
					%txt2="<b/><t>"@ %gongjishanghai1 @"攻击+150</t></t>";
					%txt1_1="<b/><t c='0x969399ff'><t>所受到的伤害-40</t><b/><t>最大体力+500</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"攻击+250</t>";
					%txt3_1="<b/><t>"@%wuxigongji1 @"灵攻击+250</t></t>";
				}
				else if (%Player.getCurrXingMaiLevel()==3)
				{
					%size ="230";%txt="         三阶法阵";
					%txt1="<b/><t c='0x4383d4ff'><t>所受到的伤害-40</t><b/><t>最大体力+500</t>";
					%txt2="<b/><t>"@ %gongjishanghai1 @"攻击+250</t>";
					%txt3="<b/><t>"@%wuxigongji1 @"灵攻击+250</t></t>";
					%txt1_1="<b/><t c='0x464646ff'><t>所受到的伤害-60</t><b/><t>最大体力+700</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"攻击+400</t>";
					%txt3_1="<b/><t>"@%wuxigongji1 @"灵攻击+400</t>";
					%txt4_1="<b/><t>内力攻击+400</t></t>";
				}
				else if (%Player.getCurrXingMaiLevel()==4)
				{
					%size ="230";%txt="         四阶法阵";
					%txt1="<b/><t c='0x4383d4ff'><t>所受到的伤害-60</t><b/><t>最大体力+700</t>";
					%txt2="<b/><t>"@ %gongjishanghai1 @"攻击+400</t>";
					%txt3="<b/><t>"@%wuxigongji1 @"灵攻击+400</t>";
					%txt4="<b/><t>内力攻击+400</t></t>";
					%txt1_1="<b/><t c='0x969399ff'><t>所受到的伤害-80</t><b/><t>最大体力+1000</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"攻击+600</t>";
					%txt3_1="<b/><t>"@%wuxigongji1 @"灵攻击+600</t>";
					%txt4_1="<b/><t>内力攻击+600</t>";
					%txt5_1="<b/><t>坚韧值+60</t></t>";
				}
				else if (%Player.getCurrXingMaiLevel()==5)
				{
					%size ="230";%txt="         五阶法阵";
					%txt1="<b/><t c='0xb012baff'><t>所受到的伤害-80</t><b/><t>最大体力+1000</t>";
					%txt2="<b/><t>"@ %gongjishanghai1 @"攻击+600</t>";
					%txt3="<b/><t>"@%wuxigongji1 @"灵攻击+600</t>";
					%txt4="<b/><t>内力攻击+600</t>";
					%txt5="<b/><t>坚韧值+60</t></t>";
					%txt1_1="<b/><t c='0x969399ff'><t>所受到的伤害-100</t><b/><t>最大体力+1500</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"攻击+1000</t>";
					%txt3_1="<b/><t>"@%wuxigongji1 @"灵攻击+1000</t>";
					%txt4_1="<b/><t>内力攻击+1000</t>";
					%txt5_1="<b/><t>坚韧值+120</t>";
					%txt6_1="<b/><t>暴击值+120</t></t>";
				}
				else if (%Player.getCurrXingMaiLevel()==6)
				{
					%size ="230";%txt="         六阶法阵";
					%txt1="<b/><t c='0xb012baff'><t>所受到的伤害-100</t><b/><t>最大体力+1500</t>";
					%txt2="<b/><t>"@ %gongjishanghai1 @"攻击+1000</t>";
					%txt3="<b/><t>"@%wuxigongji1 @"灵攻击+1000</t>";
					%txt4="<b/><t>内力攻击+1000</t>";
					%txt5="<b/><t>坚韧值+120</t>";
					%txt6="<b/><t>暴击值+120</t></t>";
					%txt1_1="<b/><t c='0x969399ff'><t>所受到的伤害-120</t><b/><t>最大体力+3500</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"攻击+2000</t>";
					%txt3_1="<b/><t>"@%wuxigongji1 @"灵攻击+2000</t>";
					%txt4_1="<b/><t>内力攻击+2000</t>";%txt5="<b/><t>坚韧值+250</t>";
					%txt6_1="<b/><t>暴击值+250</t>";
					%txt7_1="<b/><t>抗暴击倍数+10%</t></t>";
				}
				else if (%Player.getCurrXingMaiLevel()==7)
				{
					%size ="230";%txt="         七阶法阵";
					%txt1="<b/><t c='0xb012baff'><t>所受到的伤害-120</t><b/><t>最大体力+3500</t>";
					%txt2="<b/><t>"@ %gongjishanghai1 @"攻击+2000</t>";
					%txt3="<b/><t>"@%wuxigongji1 @"灵攻击+2000</t>";
					%txt4="<b/><t>内力攻击+2000</t>";%txt5="<b/><t>坚韧值+250</t>";
					%txt6="<b/><t>暴击值+250</t>";
					%txt7="<b/><t>抗暴击倍数+10%</t></t>";
					%txt1_1="<b/><t c='0x969399ff'><t>所受到的伤害-140</t><b/><t>最大体力+7500</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"攻击+4500</t>";
					%txt3_1="<b/><t>"@%wuxigongji1 @"灵攻击+4500</t>";
					%txt4_1="<b/><t>内力攻击+4500</t>";
					%txt5_1="<b/><t>坚韧值+450</t>";
					%txt6_1="<b/><t>暴击值+450</t>";
					%txt7_1="<b/><t>抗暴击倍数+20%</t>";
					%txt8_1="<b/><t>暴击倍数+20%</t></t>";
				}
				else if (%Player.getCurrXingMaiLevel()==8)
				{
					%size ="230";%txt="         八阶法阵";
					%txt1="<b/><t c='0xb012baff'><t>所受到的伤害-140</t><b/><t>最大体力+7500</t>";
					%txt2="<b/><t>"@ %gongjishanghai1 @"攻击+4500</t>";
					%txt3="<b/><t>"@%wuxigongji1 @"灵攻击+4500</t>";
					%txt4="<b/><t>内力攻击+4500</t>";
					%txt5="<b/><t>坚韧值+450</t>";
					%txt6="<b/><t>暴击值+450</t>";
					%txt7="<b/><t>抗暴击倍数+20%</t>";
					%txt8="<b/><t>暴击倍数+20%</t></t>";
					%txt1_1="<b/><t c='0x969399ff'><t>所受到的伤害-160</t><b/><t>最大体力+11250</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"攻击+7500</t>";
					%txt3_1="<b/><t>"@%wuxigongji1 @"灵攻击+7500</t>";
					%txt4_1="<b/><t>内力攻击+7500</t>";
					%txt5_1="<b/><t>坚韧值+900</t>";
					%txt6_1="<b/><t>暴击值+900</t>";
					%txt7_1="<b/><t>抗暴击倍数+30%</t>";
					%txt8_1="<b/><t>暴击倍数+30%</t></t>";
				}
				else if (%Player.getCurrXingMaiLevel()==9)
				{
					%size ="230";%txt="         九阶法阵";
					%txt1="<b/><t c='0xf26504ff'><t>所受到的伤害-160</t><b/><t>最大体力+11250</t>";
					%txt2="<b/><t>"@ %gongjishanghai1 @"攻击+7500</t>";
					%txt3="<b/><t>"@%wuxigongji1 @"灵攻击+7500</t>";
					%txt4="<b/><t>内力攻击+7500</t>";
					%txt5="<b/><t>坚韧值+900</t>";
					%txt6="<b/><t>暴击值+900</t>";
					%txt7="<b/><t>抗暴击倍数+30%</t>";
					%txt8="<b/><t>暴击倍数+30%</t></t>";
					%txt1_1="<b/><t c='0x969399ff'><t>所受到的伤害-180</t><b/><t>最大体力+14880</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"攻击+12000</t>";
					%txt3_1="<b/><t>"@%wuxigongji1 @"灵攻击+12000</t>";
					%txt4_1="<b/><t>内力攻击+12000</t>";
					%txt5_1="<b/><t>坚韧值+1900</t>";
					%txt6_1="<b/><t>暴击值+1900</t>";
					%txt7_1="<b/><t>抗暴击倍数+40%</t>";
					%txt8_1="<b/><t>暴击倍数+40%</t></t>";
				}
				else if (%Player.getCurrXingMaiLevel()==10)
				{
					%size ="230";%txt="         十阶法阵";
					%txt1="<b/><t c='0xf26504ff'><t>所受到的伤害-180</t><b/><t>最大体力+14880</t>";
					%txt2="<b/><t>"@ %gongjishanghai1 @"攻击+12000</t>";
					%txt3="<b/><t>"@%wuxigongji1 @"灵攻击+12000</t>";
					%txt4="<b/><t>内力攻击+12000</t>";
					%txt5="<b/><t>坚韧值+1900</t>";
					%txt6="<b/><t>暴击值+1900</t>";
					%txt7="<b/><t>抗暴击倍数+40%</t>";
					%txt8="<b/><t>暴击倍数+40%</t></t>";
					%txt10="";
				}
				else
				{
					%size ="230";%txt="<t>         一阶法阵</t><t c='0x969399ff' n='14'>（未激活)</t>";
					%txt1="<b/><t><t c='0x969399ff'><t>所受到的伤害-10</t><b/><t>最大体力+150</t></t>";
					%txt1_1="<b/><t c='0x969399ff'><t>所受到的伤害-20</t><b/><t>最大体力+300</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"攻击+150</t></t>";
				}

				%ctrl.tooltipWidth = %size;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t f='黑体' n='16'>"@ %txt @"</t><b/><t c='0xE1AA16ff'>激活属性：</t>"@ %txt1 @""@ %txt2 @""@ %txt3 @""@ %txt4 @""@ %txt5 @""@ %txt6 @""@ %txt7 @""@ %txt8 @""@ %txt9 @""@ %txt10 @""@ %txt1_1 @""@ %txt2_1 @""@ %txt3_1 @""@ %txt4_1 @""@ %txt5_1 @""@ %txt6_1 @""@ %txt7_1 @""@ %txt8_1 @""@ %txt9_1 @""@ %txt0 @"</t>";


			case "XingXiangWnd_LevelName"://阵眼等级

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>当前唤醒法阵的等级</t><b/><t>阵眼等级由装备在角色身上的紫色以上武魂中等级最低的武魂决定</t><b/><t>当法阵达到八阶以上就可额外获得多达9项战斗属性加成</t></t>";

			case "XingXiangWnd_XingLiValueBmp"://武魂界面-魂力值
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>武魂品质总值 </t><t>"@ GetPlayer().getCurrStarPowerSum() @"</t><b/><t>显示人物装备的武魂品质、武魂等级的综合值</t></t>";

			case "DTPlayerInfowGui_WuHunText"://角色界面-魂力值
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>武魂品质总值 </t><t>"@ GetPlayer().getCurrStarPowerSum() @"</t><b/><t>显示人物装备的武魂品质、武魂等级的综合值</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>左键单击可打开角色武魂界面</t></t>";

			case "TargetInfo_XingLiValueBmp"://查看他人角色界面-魂力值

				$XingMaiInfo[-1]="<t gct='0xff7171ff' gcb='0xff3c00ff'>法阵未激活</t>";
				$XingMaiInfo[1]="<t gct='0x00ff00ff' gcb='0x2cffeeff'>一阶法阵</t>";
				$XingMaiInfo[2]="<t gct='0x00ff00ff' gcb='0x2cffeeff'>二阶法阵</t>";
				$XingMaiInfo[3]="<t gct='0x00ff00ff' gcb='0x2cffeeff'>三阶法阵</t>";
				$XingMaiInfo[4]="<t gct='0x4383d4ff' gcb='0x4383d4ff'>四阶法阵</t>";
				$XingMaiInfo[5]="<t gct='0x4383d4ff' gcb='0x4383d4ff'>五阶法阵</t>";
				$XingMaiInfo[6]="<t gct='0x4383d4ff' gcb='0x4383d4ff'>六阶法阵</t>";
				$XingMaiInfo[7]="<t gct='0xa811b1ff' gcb='0xb012baff'>七阶法阵</t>";
				$XingMaiInfo[8]="<t gct='0xa811b1ff' gcb='0xb012baff'>八阶法阵</t>";
				$XingMaiInfo[9]="<t gct='0xa811b1ff' gcb='0xb012baff'>九阶法阵</t>";
				$XingMaiInfo[10]="<t gct='0xa811b1ff' gcb='0xb012baff'>十阶法阵</t>";

				%XingMai = GetTargetXingMaiLevel();
				%XingMaiLevel = $XingMaiInfo[%XingMai];

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>武魂品质总值</t> <b/><t>显示人物装备的武魂品质、武魂等级的综合值</t><b/><t>当前阵眼等级：</t>"@ %XingMaiLevel @"<t><b/>"@ GetTargetXingMaiInfo() @"</t></t>";

			case "XingXiangWnd_UploadBtn"://上传武魂品质
				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>上传武魂品质</t><b/><t>点击后武魂品质将上传至排行榜内</t></t>";

			case "XingXiangWnd_BaoDai_ActiveBtn0"://武魂宝袋
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>武魂宝袋</t><t gct='0x00ff00ff' gcb='0x2cffeeff'f='黑体' n='14'>（可激活）</t><b/><t>每天为武魂宝袋充能，可免费获得稀有橙色武魂</t></t>";

			case "XingXiangWnd_BaoDai_ActiveBtn"://武魂宝袋
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>武魂宝袋（可充能）</t><b/><t>每天为武魂宝袋充能，可免费获得稀有橙色武魂</t></t>";

			case "SeeStarWnd_AutoSeeStarBtn"://自动搜魂

				if (GetPlayer().GetLevel() < 60)
				{
					%ctrl.tooltipWidth = 200;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>自动搜魂</t><b/><t>需要角色等级达到6修才能使用，加油！！</t></t>";
				}
				else
				{
					%ctrl.tooltipWidth = 250;
					%ctrl.tooltip = "<t m='1' f='宋体' n='12' ><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>自动搜魂</t><b/><t>点击后开启自动搜魂，让你轻松获得各种武魂</t><b/><t>停止规则：</t><b/><t>1、再次点击自动搜魂按钮</t><b/><t>2、武魂格全部拥有武魂</t><b/><t>3、激活最高级别的大国师</t><b/><t>4、金币不足</t></t>";
				}

			case "SeeStarWnd_SeeStarNum"://累计搜魂次数
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>累计搜魂次数</t><b/><t>累计搜魂次数每达到1000次，即可获得一个武魂碎片的额外奖励</t><b/><t>武魂碎片可用于兑换紫色、橙色武魂</t></t>";


			case "XingXiangWnd_InventoryTipBmp"://武魂仓库
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>武魂仓库</t><b/><t>武魂仓库内的武魂不会被融合，可将闲置武魂放入仓库中</t></t>";

			case "XingXiangWnd_InfoBtn"://武魂属性与兑换
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>武魂属性与兑换</t><b/><t>可查看所有武魂初始和最终的附加属性</t><b/><t>紫色、橙色武魂可用武魂碎片兑换获得</t></t>";

			case "XingXiangWnd_XingXiangSuiPianBmp"://武魂碎片
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>武魂碎片</t><b/><t>点击【武魂属性与兑换】可兑换紫色、橙色品质武魂</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>武魂碎片获得途径：</t><b/><t>1、搜魂可获得武魂碎片</t><b/><t>2、分解橙色武魂可获得武魂碎片</t><b/><t>3、累计搜魂次数每1000次额外赠送一个武魂碎片</t></t>";

			case "XingXiangWnd_XingXiangSuiPianValue"://武魂碎片
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>拥有的武魂碎片数量</t><b/><t>点击【武魂属性与兑换】可兑换紫色、橙色品质武魂</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>武魂碎片获得途径：</t><b/><t>1、搜魂可获得武魂碎片</t><b/><t>2、分解橙色武魂可获得武魂碎片</t><b/><t>3、累计搜魂次数每1000次额外赠送一个武魂碎片</t></t>";

			case "XingXiangInfoWnd_XingXiangSuiPianBmp"://武魂碎片
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'f='黑体' n='14'>武魂碎片</t><b/><t>可用于兑换紫色、橙色品质武魂</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>武魂碎片获得途径：</t><b/><t>1、搜魂可获得武魂碎片</t><b/><t>2、分解橙色武魂可获得武魂碎片</t><b/><t>3、累计搜魂次数每1000次额外赠送一个武魂碎片</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_0"://兑换武魂0
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xff9600ff' f='黑体' n='14'>[神魂]</t><b/><t>角色达到6修即可消耗10个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_1"://兑换武魂1
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xff9600ff' f='黑体' n='14'>[真·举重若轻]</t><b/><t>角色达到6修即可消耗20个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_2"://兑换武魂2
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xff9600ff' f='黑体' n='14'>[真·十步一杀]</t><b/><t>角色达到6修即可消耗20个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_3"://兑换武魂3
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xff9600ff' f='黑体' n='14'>[真·上善若水]</t><b/><t>角色达到6修即可消耗20个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_4"://兑换武魂4
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xff9600ff' f='黑体' n='14'>[真·李代桃僵]</t><b/><t>角色达到6修即可消耗20个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_5"://兑换武魂5
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xff9600ff' f='黑体' n='14'>[真·金刚不灭]</t><b/><t>角色达到6修即可消耗20个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_6"://兑换武魂6
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xff9600ff' f='黑体' n='14'>[真·惊天一剑]</t><b/><t>角色达到6修即可消耗20个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_7"://兑换武魂7
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xff9600ff' f='黑体' n='14'>[真·妙手回春]</t><b/><t>角色达到6修即可消耗20个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_8"://兑换武魂8
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xff9600ff' f='黑体' n='14'>[真·天地同寿]</t><b/><t>角色达到6修即可消耗20个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_9"://兑换武魂9
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xff9600ff' f='黑体' n='14'>[真·心神合一]</t><b/><t>角色达到6修即可消耗20个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_10"://兑换武魂10
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xff9600ff' f='黑体' n='14'>[真·固若金汤]</t><b/><t>角色达到6修即可消耗20个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_11"://兑换武魂11
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xff9600ff' f='黑体' n='14'>[真·灵动九天]</t><b/><t>角色达到6修即可消耗20个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_12"://兑换武魂12
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xff9600ff' f='黑体' n='14'>[真·五气朝元]</t><b/><t>角色达到6修即可消耗20个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_13"://兑换武魂13
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xff9600ff' f='黑体' n='14'>[真·力拔山兮]</t><b/><t>角色达到6修即可消耗20个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_14"://兑换武魂14
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xca57ffff' f='黑体' n='14'>[生生不息]</t><b/><t>角色达到3修即可消耗5个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_15"://兑换武魂15
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xca57ffff' f='黑体' n='14'>[三花聚顶]</t><b/><t>角色达到3修即可消耗5个武魂碎片兑换</t></t>";

				//case "XingXiangInfoWnd_ControlArea_ExchangeBtn_15"://兑换武魂16
				//			%ctrl.tooltipWidth = 210;
				//			%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xca57ffff' f='黑体' n='14'>[笑里藏刀]</t><b/><t>角色达到3修即可消耗5个武魂碎片兑换</t></t>";

				//case "XingXiangInfoWnd_ControlArea_ExchangeBtn_16"://兑换武魂17
				//			%ctrl.tooltipWidth = 210;
				//			%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xca57ffff' f='黑体' n='14'>[无中生有]</t><b/><t>角色达到3修即可消耗5个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_16"://兑换武魂18
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xca57ffff' f='黑体' n='14'>[金蝉脱壳]</t><b/><t>角色达到3修即可消耗5个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_17"://兑换武魂19
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xca57ffff' f='黑体' n='14'>[金刚不灭]</t><b/><t>角色达到3修即可消耗5个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_18"://兑换武魂20
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xca57ffff' f='黑体' n='14'>[惊天一剑]</t><b/><t>角色达到3修即可消耗5个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_19"://兑换武魂21
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xca57ffff' f='黑体' n='14'>[妙手回春]</t><b/><t>角色达到3修即可消耗5个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_20"://兑换武魂22
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xca57ffff' f='黑体' n='14'>[聚气凝神]</t><b/><t>角色达到3修即可消耗5个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_21"://兑换武魂23
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xca57ffff' f='黑体' n='14'>[天地同寿]</t><b/><t>角色达到3修即可消耗5个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_22"://兑换武魂24
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xca57ffff' f='黑体' n='14'>[心神合一]</t><b/><t>角色达到3修即可消耗5个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_23"://兑换武魂25
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xca57ffff' f='黑体' n='14'>[固若金汤]</t><b/><t>角色达到3修即可消耗5个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_24"://兑换武魂26
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xca57ffff' f='黑体' n='14'>[灵动九天]</t><b/><t>角色达到3修即可消耗5个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_25"://兑换武魂27
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xca57ffff' f='黑体' n='14'>[五气朝元]</t><b/><t>角色达到3修即可消耗5个武魂碎片兑换</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_26"://兑换武魂28
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t c='0xca57ffff' f='黑体' n='14'>[力拔山兮]</t><b/><t>角色达到3修即可消耗5个武魂碎片兑换</t></t>";



				//====================================================================================奖励性价比图形说明====================================================================================================

			case "UpLinePartyWnd_Wnd_Tip"://奖励性价比图形说明
				if (isFile("gameres/gui/images/GUIWindow41_1_020.png")){ %Reward1 = "<i s='gameres/gui/images/GUIWindow41_1_020.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }//人物经验
				if (isFile("gameres/gui/images/GUIWindow41_1_021.png")){ %Reward2 = "<i s='gameres/gui/images/GUIWindow41_1_021.png' w='16' h='16'/>"; }
				else{ %Reward2 = ""; }//化神经验
				if (isFile("gameres/gui/images/GUIWindow41_1_022.png")){ %Reward3 = "<i s='gameres/gui/images/GUIWindow41_1_022.png' w='16' h='16'/>"; }
				else{ %Reward3 = ""; }//神兽经验
				if (isFile("gameres/gui/images/GUIWindow41_1_023.png")){ %Reward4 = "<i s='gameres/gui/images/GUIWindow41_1_023.png' w='16' h='16'/>"; }
				else{ %Reward4 = ""; }//金钱
				if (isFile("gameres/gui/images/GUIWindow41_1_024.png")){ %Reward5 = "<i s='gameres/gui/images/GUIWindow41_1_024.png' w='16' h='16'/>"; }
				else{ %Reward5 = ""; }//装备
				if (isFile("gameres/gui/images/GUIWindow41_1_025.png")){ %Reward6 = "<i s='gameres/gui/images/GUIWindow41_1_025.png' w='16' h='16'/>"; }
				else{ %Reward6 = ""; }//友好度

				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>奖励性价比说明</t><b/><t>"@ %Reward1@"</t><t>：表示活动奖励人物经验</t><b/><t>"@ %Reward2@"</t><t>：表示活动奖励化神经验</t><b/><t>"@ %Reward3@"</t><t>：表示活动奖励神兽经验</t><b/><t>"@ %Reward4@"</t><t>：表示活动奖励金钱</t><b/><t>"@ %Reward5@"</t><t>：表示活动奖励装备道具</t><b/><t>"@ %Reward6@"</t><t>：表示活动奖励友好度</t></t>";

			case "EveryweekBnt1"://奖励性价比图形说明
				if (isFile("gameres/gui/images/GUIWindow41_1_020.png")){ %Reward1 = "<i s='gameres/gui/images/GUIWindow41_1_020.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }//人物经验
				if (isFile("gameres/gui/images/GUIWindow41_1_021.png")){ %Reward2 = "<i s='gameres/gui/images/GUIWindow41_1_021.png' w='16' h='16'/>"; }
				else{ %Reward2 = ""; }//化神经验
				if (isFile("gameres/gui/images/GUIWindow41_1_022.png")){ %Reward3 = "<i s='gameres/gui/images/GUIWindow41_1_022.png' w='16' h='16'/>"; }
				else{ %Reward3 = ""; }//神兽经验
				if (isFile("gameres/gui/images/GUIWindow41_1_023.png")){ %Reward4 = "<i s='gameres/gui/images/GUIWindow41_1_023.png' w='16' h='16'/>"; }
				else{ %Reward4 = ""; }//金钱
				if (isFile("gameres/gui/images/GUIWindow41_1_024.png")){ %Reward5 = "<i s='gameres/gui/images/GUIWindow41_1_024.png' w='16' h='16'/>"; }
				else{ %Reward5 = ""; }//装备
				if (isFile("gameres/gui/images/GUIWindow41_1_025.png")){ %Reward6 = "<i s='gameres/gui/images/GUIWindow41_1_025.png' w='16' h='16'/>"; }
				else{ %Reward6 = ""; }//友好度

				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>奖励性价比说明</t><b/><t>"@ %Reward1@"</t><t>：表示活动奖励人物经验</t><b/><t>"@ %Reward2@"</t><t>：表示活动奖励化神经验</t><b/><t>"@ %Reward3@"</t><t>：表示活动奖励神兽经验</t><b/><t>"@ %Reward4@"</t><t>：表示活动奖励金钱</t><b/><t>"@ %Reward5@"</t><t>：表示活动奖励装备道具</t><b/><t>"@ %Reward6@"</t><t>：表示活动奖励友好度</t></t>";

			case "DayBnt1"://奖励性价比图形说明
				if (isFile("gameres/gui/images/GUIWindow41_1_020.png")){ %Reward1 = "<i s='gameres/gui/images/GUIWindow41_1_020.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }//人物经验
				if (isFile("gameres/gui/images/GUIWindow41_1_021.png")){ %Reward2 = "<i s='gameres/gui/images/GUIWindow41_1_021.png' w='16' h='16'/>"; }
				else{ %Reward2 = ""; }//化神经验
				if (isFile("gameres/gui/images/GUIWindow41_1_022.png")){ %Reward3 = "<i s='gameres/gui/images/GUIWindow41_1_022.png' w='16' h='16'/>"; }
				else{ %Reward3 = ""; }//神兽经验
				if (isFile("gameres/gui/images/GUIWindow41_1_023.png")){ %Reward4 = "<i s='gameres/gui/images/GUIWindow41_1_023.png' w='16' h='16'/>"; }
				else{ %Reward4 = ""; }//金钱
				if (isFile("gameres/gui/images/GUIWindow41_1_024.png")){ %Reward5 = "<i s='gameres/gui/images/GUIWindow41_1_024.png' w='16' h='16'/>"; }
				else{ %Reward5 = ""; }//装备
				if (isFile("gameres/gui/images/GUIWindow41_1_025.png")){ %Reward6 = "<i s='gameres/gui/images/GUIWindow41_1_025.png' w='16' h='16'/>"; }
				else{ %Reward6 = ""; }//友好度

				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>奖励性价比说明</t><b/><t>"@ %Reward1@"</t><t>：表示活动奖励人物经验</t><b/><t>"@ %Reward2@"</t><t>：表示活动奖励化神经验</t><b/><t>"@ %Reward3@"</t><t>：表示活动奖励神兽经验</t><b/><t>"@ %Reward4@"</t><t>：表示活动奖励金钱</t><b/><t>"@ %Reward5@"</t><t>：表示活动奖励装备道具</t><b/><t>"@ %Reward6@"</t><t>：表示活动奖励友好度</t></t>";

			case "Everydaybnt1"://奖励性价比图形说明
				if (isFile("gameres/gui/images/GUIWindow41_1_020.png")){ %Reward1 = "<i s='gameres/gui/images/GUIWindow41_1_020.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }//人物经验
				if (isFile("gameres/gui/images/GUIWindow41_1_021.png")){ %Reward2 = "<i s='gameres/gui/images/GUIWindow41_1_021.png' w='16' h='16'/>"; }
				else{ %Reward2 = ""; }//化神经验
				if (isFile("gameres/gui/images/GUIWindow41_1_022.png")){ %Reward3 = "<i s='gameres/gui/images/GUIWindow41_1_022.png' w='16' h='16'/>"; }
				else{ %Reward3 = ""; }//神兽经验
				if (isFile("gameres/gui/images/GUIWindow41_1_023.png")){ %Reward4 = "<i s='gameres/gui/images/GUIWindow41_1_023.png' w='16' h='16'/>"; }
				else{ %Reward4 = ""; }//金钱
				if (isFile("gameres/gui/images/GUIWindow41_1_024.png")){ %Reward5 = "<i s='gameres/gui/images/GUIWindow41_1_024.png' w='16' h='16'/>"; }
				else{ %Reward5 = ""; }//装备
				if (isFile("gameres/gui/images/GUIWindow41_1_025.png")){ %Reward6 = "<i s='gameres/gui/images/GUIWindow41_1_025.png' w='16' h='16'/>"; }
				else{ %Reward6 = ""; }//友好度

				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>奖励性价比说明</t><b/><t>"@ %Reward1@"</t><t>：表示活动奖励人物经验</t><b/><t>"@ %Reward2@"</t><t>：表示活动奖励化神经验</t><b/><t>"@ %Reward3@"</t><t>：表示活动奖励神兽经验</t><b/><t>"@ %Reward4@"</t><t>：表示活动奖励金钱</t><b/><t>"@ %Reward5@"</t><t>：表示活动奖励装备道具</t><b/><t>"@ %Reward6@"</t><t>：表示活动奖励友好度</t></t>";

			case "UnhandleTradebitmap"://有委托单
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>您当前还有元宝交易的委托未处理</t></t></t>";

			case "FBRewardWnd_ActivePrideFB"://领取多宝光辉
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>领取多宝光辉</t><b/><t>领取多宝光辉后，击败副本首领可获得高额经验和宝藏</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>多宝光辉状态只有进入副本后才能领取</t></t>";

			case "ProduceRock_RichBit"://炼丹炉
				if ($LivingCurrentSelectSeries == 1)
				{
					%Rich = "铸造需要在铸造炉附近";
				}
				else if ($LivingCurrentSelectSeries == 5)
				{
					%Rich = "炼丹需要在炼丹炉附近";
				}
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Rich @""@ %Rich2 @"</t></t>";

			case "ProduceRock_RichBnt"://前往炼丹炉
				if ($LivingCurrentSelectSeries == 1){ %Rich = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>铸造需要在铸造炉附近</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击此处可自动寻径至长安的铸造炉</t>"; }
				else if ($LivingCurrentSelectSeries == 5){ %Rich = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>炼丹需要在炼丹炉附近</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>点击此处可自动寻径至长安的炼丹炉</t>"; }
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'>"@ %Rich @"</t>";


			case "League_AreaInfoWnd_AttackerInfo"://血盟攻打申请说明

				%ctrl.tooltipWidth = 340;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>领地收益</t><b/><t>拥有领地的帮主/盟主每周一都可获得领地税收</t><b/><t>长安/洛阳领地税收：100万金币、1万活跃积分</t><b/><t>天下帝王领地税收：200万金币、2万活跃积分</t><b/><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>申请攻打规则</t><b/><t>长安/洛阳攻城战发起需求：</t><b/><t>1、达到3级帮派并缴纳2000帮派资金</t><b/><t>2、帮主至少需缴纳50万金币</t><b/><b/><t>天下帝王攻城战发起需求：</t><b/><t>1、达到2级血盟并已获得长安或洛阳领地</t><b/><t>2、血盟盟主至少需缴纳50万金币</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>报名截止时，捐献金额最靠前的帮派/血盟可获得攻打权限</t><b/><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>攻城战胜利条件</t><b/><t>攻方胜利条件：击毁领地中央首领即可获得胜利</t><b/><t>守方胜利条件：保护领地中央首领存在直至城战时间结束</t></t>";

			case "Family_AreaInfoWnd_AttackerInfo"://帮派攻打申请说明

				%ctrl.tooltipWidth = 340;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>领地收益</t><b/><t>拥有领地的帮主/盟主每周一都可获得领地税收</t><b/><t>长安/洛阳领地税收：100万金币、1万活跃积分</t><b/><t>天下帝王领地税收：200万金币、2万活跃积分</t><b/><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>申请攻打规则</t><b/><t>长安/洛阳攻城战发起需求：</t><b/><t>1、达到3级帮派并缴纳2000帮派资金</t><b/><t>2、帮主至少需缴纳50万金币</t><b/><b/><t>天下帝王攻城战发起需求：</t><b/><t>1、达到2级血盟并已获得长安或洛阳领地</t><b/><t>2、血盟盟主至少需缴纳50万金币</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>报名截止时，捐献金额最靠前的帮派/血盟可获得攻打权限</t><b/><b/><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>攻城战胜利条件</t><b/><t>攻方胜利条件：击毁领地中央首领即可获得胜利</t><b/><t>守方胜利条件：保护领地中央首领存在直至城战时间结束</t></t>";

				//=====================================================================神器阁==========================================
			case "ShenQiGeWndGui11_1"://轩辕剑按钮
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>强化</t><b/><t>这里可以通过宝石、进阶等方式提升您装备的品质</t></t>";

			case "ShenQiGeWndGui11_2"://炼妖壶按钮
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>神兽</t><b/><t>这里可以通过洗炼、学习技能等方式提升您神兽的能力</t></t>";

			case "ShenQiGeWndGui11_4"://伏羲琴按钮
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>时装</t><b/><t>这里可以通过镶嵌、合成等方式提升您时装的抗性能力</t></t>";

			case "ShenQiGeWndGui11_3"://崆峒印按钮
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>星宿</t><b/><t>这里可以通过炼制、升级等方式提升您星宿的属性</t></t>";

			case "ShenQiGeWndGui11_5"://女娲石按钮
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>女娲石</t><b/><t c='0x00ff00ff'>功能暂未开放，敬请期待</t></t>";

				//===============================================================================媒体礼包================================================

			case"DTReceiveGift_ReceiveGiftBtn"://媒体礼包
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>领取礼包</t><b/><t>输入序列号后点击即可获得媒体礼包</t><b/><t c='0x00ff00ff'>获得媒体礼包领取码请关注官网</t></t>";

				//===============================================================================竞技场================================================

			case"JingJiChangWndGUI_reward"://领取奖励
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>领取奖励</t><b/><t>每周都可以领取上周的竞技场排名奖励，只可领取一次</t><b/><t c='0x00ff00ff'>奖励不会累计，请及时领取</t></t>";

			case"JingJiChangWndGUI_AddBtn"://增加
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>增加额外挑战次数</t><b/><t>花费100元宝可增加一次额外挑战次数</t><b/><t c='0x00ff00ff'>会优先使用免费挑战次数</t></t>";


				//===============================================================================欢迎进入昆仑决界面================================================

			case "UpLinePartyTeQuan"://VIP特权
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>特权奖励</t><b/><t>成为尊贵的VIP成员，每天都享有特权</t></t>";

			case "UpLinePartyMianFei1"://免费领取工资
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>领取工资</t><b/><t>每天完成四个今日目标任务即可领取每日工资和活跃积分</t></t>";

			case "UpLinePartyMianFei2"://免费领取活动积分
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>领取活跃积分</t><b/><t>每天完成四个今日目标任务即可领取每日工资和活跃积分</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>活跃积分可在随身商店内购买各种物品</t></t>";

			case "UpLinePartyMianFei3"://免费领取离线经验
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>领取离线经验</t><b/><t>每个级别只能领取1次，每次领取的经验最多不超过当前角色升级经验的50%</t></t>";

			case "UpLinePartyMianFei4"://前往领取
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>领取双倍时间</t><b/><t>点击自动寻径至长安福星处领取双倍时间</t></t>";


				//===============================================================================财神转转转=========================================================================


			case "RandomAwardGuiStart"://财神转转转
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>开始解签</t><b/><t>每次解签消耗一枚化厄签，时来运转，豪礼今天入我手</t><b/><t>(化厄签不足时可用300元宝代替)</t><b/><t c='0x00ff00ff'>每解签一次，仙缘池增加60元宝</t>";
			case "KLJLuckDrawStartFive"://五连抽
                %ctrl.tooltipWidth = 200;
                %ctrl.tooltip ="<t c='0xffffffff'>五连解签消耗5枚化厄签</t><b/><t c='0xffffffff'>(化厄签不足时可用1500元宝代替)</t><b/><t c='0x00ff00ff'>每五连解签，仙缘池增加300元宝</t>";
            case "KLJLuckDrawStartTen"://十连抽
                %ctrl.tooltipWidth = 240;
                %ctrl.tooltip ="<t c='0xffffffff'>十连解签消耗10枚化厄签</t><b/><t c='0xffffffff'>每次参与十连解签有33%的概率额外获得一颗宝石</t><b/><t c='0xffffffff'>(化厄签不足时可用3000元宝代替)</t><b/><t c='0x00ff00ff'>每十连解签，仙缘池增加600元宝</t>";
            
            case "RandomAwardGuiLingQu"://领取奖励
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>领取奖励</t><b/><t>点击即可领取您抽中的奖励</t><b/><t c='0x00ff00ff'>也可以使用重抽功能重新抽取</t></t>";

			case "RandomAwardGuiChongChou"://重抽
				%ctrl.tooltipWidth = 225;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>重抽</t><b/><t>每次重抽将消耗50 </t><i s='gameres/gui/images/GUIWindow31_1_027.png' w='16' h='18'/><b/><t c='0x00ff00ff'>可排除当前抽中的奖品（随机类奖励除外）重新再次抽奖</t></t>";

			 
            //===============================================================================祈愿豪礼=========================================================================


			case "KLJPrayGoodManners_QTBtn"://青铜祈福
                %ctrl.tooltipWidth = 150;
                %ctrl.tooltip ="<t c='0x00ff00ff'>消耗1祈福券(或消耗500元宝代替祈福券)</t>";
                    
			case "KLJPrayGoodManners_BYBtn"://白银祈福
                %ctrl.tooltipWidth = 150;
                %ctrl.tooltip ="<t c='0x00ff00ff'>消耗9祈福券(或消耗4500元宝代替祈福券)</t>";

            case "KLJPrayGoodManners_HJBtn"://黄金祈福
                %ctrl.tooltipWidth = 150;
                %ctrl.tooltip ="<t c='0x00ff00ff'>消耗20祈福券(或消耗10000元宝代替祈福券)</t>";



            //===============================================================================连续充值送豪礼=========================================================================
			 case "KLJDeluxeBagWndBigPrizeShow"://昆仑豪杰大礼包
				 %ctrl.tooltipWidth = 210;
				 %ctrl.tooltip =
					 "<t c='0x00ff00ff' f='宋体' n='16'>     昆仑豪杰大礼包</t><b/><b/><t c='0xf1b700ff' f='宋体' n='12'>当您累计充值满5天即可领取豪礼！开启此礼包可获得以下物品： </t><b/> "@
					 GetItemName(105105713, 1)@"<t c='0xF36215ff'> × 2</t><b/>"@
					 GetItemName(105090511, 1)@"<t c='0xF36215ff'> × 5</t><b/>"@
					 GetItemName(105090611, 1)@"<t c='0xF36215ff'> × 5</t><b/>"@
					 GetItemName(113050023, 1)@"<t c='0xF36215ff'> × 5</t><b/>"@
					 GetItemName(116030002, 1)@"<t c='0xF36215ff'> × 2</t><b/>"@
					 GetItemName(105090711, 1)@"<t c='0xF36215ff'> × 5</t><b/>"@
					 GetItemName(105109323, 1)@"<t c='0xF36215ff'> × 28</t><b/>"@
					 GetItemName(105021051, 1)@"<t c='0xF36215ff'> × 1</t><b/>"@
					 GetItemName(105021061, 1)@"<t c='0xF36215ff'> × 1</t><b/>"@
					 GetItemName(119015001, 1)@"<t c='0xF36215ff'> × 1</t>";


            //===============================================================================免费玩家乐园=========================================================================



			case "Getrewordbutton"://每日工资
				if ($TodayGoalWnd_Pagination[Getplayer()] == 1)
				{
					%CJdajiang = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>超级大奖</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>创建角色第七天后即可领取奖励，最高可领取：</t><b/><t>2,000,000 经验</t><b/><t>1,000,000 金币</t><b/><t>200 活跃积分</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>奖励会根据任务完成情况有所增减</t>";
				}
				else if ($TodayGoalWnd_Pagination[Getplayer()] == 2)
				{
					%CJdajiang = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>每日工资</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>完成任意四个每日福利任务后即可领取奖励：</t><b/><t>1,000,000 经验</t><b/><t>50,000 金币</t><b/><t>100 活跃积分</t><b/><t>财神转转转抽奖次数增加1</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>1道7修0重以上玩家还可额外获得100 </t><i s='gameres/gui/images/GUIWindow31_1_027.png' w='16' h='18'/>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'>"@ %CJdajiang @"</t>";

				//===============================================================================天劫境界=========================================================================

			case "FiveBitMipInMiddleReady_1"://未渡劫第一个
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>开光前期</t><b/><t>将等级提升至一道3修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>筑基后期</t><b/><t>将等级提升至二道3修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>辟谷中期</t><b/><t>将等级提升至三道3修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>修神前期</t><b/><t>将等级提升至四道3修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>心动后期</t><b/><t>将等级提升至五道3修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神中期</t><b/><t>将等级提升至六道3修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'>"@ %TJjingjie @"</t>";




			case "FiveBitMipInMiddleReady_2"://未渡劫第二个
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>开光中期</t><b/><t>将等级提升至一道4修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>练气前期</t><b/><t>将等级提升至二道4修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>辟谷后期</t><b/><t>将等级提升至三道4修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>修神中期</t><b/><t>将等级提升至四道4修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元婴前期</t><b/><t>将等级提升至五道4修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神后期</t><b/><t>将等级提升至六道4修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'>"@ %TJjingjie @"</t>";



			case "FiveBitMipInMiddleReady_3"://未渡劫第三个
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>开光后期</t><b/><t>将等级提升至一道5修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>练气中期</t><b/><t>将等级提升至二道5修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>金丹前期</t><b/><t>将等级提升至三道5修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>修神后期</t><b/><t>将等级提升至四道5修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元婴中期</t><b/><t>将等级提升至五道5修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>空冥前期</t><b/><t>将等级提升至六道5修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'>"@ %TJjingjie @"</t>";



			case "FiveBitMipInMiddleReady_4"://未渡劫第四个
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>筑基前期</t><b/><t>将等级提升至一道6修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>练气后期</t><b/><t>将等级提升至二道6修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>金丹中期</t><b/><t>将等级提升至三道6修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>心动前期</t><b/><t>将等级提升至四道6修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元婴后期</t><b/><t>将等级提升至五道6修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>空冥中期</t><b/><t>将等级提升至六道6修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'>"@ %TJjingjie @"</t>";


			case "FiveBitMipInMiddleReady_5"://未渡劫第五个
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>筑基中期</t><b/><t>将等级提升至一道7修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>辟谷前期</t><b/><t>将等级提升至二道7修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>金丹后期</t><b/><t>将等级提升至三道7修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>心动中期</t><b/><t>将等级提升至四道7修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神前期</t><b/><t>将等级提升至五道7修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>空冥后期</t><b/><t>将等级提升至六道7修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'>"@ %TJjingjie @"</t>";


			case "FiveBitMipInMiddleHas_1"://已渡劫第一个
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>开光前期</t><b/><t>将等级提升至一道3修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>筑基后期</t><b/><t>将等级提升至二道3修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>辟谷中期</t><b/><t>将等级提升至三道3修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>修神前期</t><b/><t>将等级提升至四道3修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>心动后期</t><b/><t>将等级提升至五道3修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神中期</t><b/><t>将等级提升至六道3修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'>"@ %TJjingjie @"</t>";




			case "FiveBitMipInMiddleHas_2"://已渡劫第二个
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>开光中期</t><b/><t>将等级提升至一道4修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>练气前期</t><b/><t>将等级提升至二道4修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>辟谷后期</t><b/><t>将等级提升至三道4修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>修神中期</t><b/><t>将等级提升至四道4修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元婴前期</t><b/><t>将等级提升至五道4修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神后期</t><b/><t>将等级提升至六道4修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'>"@ %TJjingjie @"</t>";



			case "FiveBitMipInMiddleHas_3"://已渡劫第三个
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>开光后期</t><b/><t>将等级提升至一道5修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>练气中期</t><b/><t>将等级提升至二道5修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>金丹前期</t><b/><t>将等级提升至三道5修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>修神后期</t><b/><t>将等级提升至四道5修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元婴中期</t><b/><t>将等级提升至五道5修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>空冥前期</t><b/><t>将等级提升至六道5修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'>"@ %TJjingjie @"</t>";



			case "FiveBitMipInMiddleHas_4"://已渡劫第四个
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>筑基前期</t><b/><t>将等级提升至一道6修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>练气后期</t><b/><t>将等级提升至二道6修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>金丹中期</t><b/><t>将等级提升至三道6修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>心动前期</t><b/><t>将等级提升至四道6修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元婴后期</t><b/><t>将等级提升至五道6修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>空冥中期</t><b/><t>将等级提升至六道6修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'>"@ %TJjingjie @"</t>";


			case "FiveBitMipInMiddleHas_5"://已渡劫第五个
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>筑基中期</t><b/><t>将等级提升至一道7修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>辟谷前期</t><b/><t>将等级提升至二道7修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>金丹后期</t><b/><t>将等级提升至三道7修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>心动中期</t><b/><t>将等级提升至四道7修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神前期</t><b/><t>将等级提升至五道7修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>空冥后期</t><b/><t>将等级提升至六道7修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}


				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'>"@ %TJjingjie @"</t>";




			case "FiveBitMipInMiddleNot_1"://未达条件第一个
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>开光前期</t><b/><t>将等级提升至一道3修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>筑基后期</t><b/><t>将等级提升至二道3修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>辟谷中期</t><b/><t>将等级提升至三道3修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>修神前期</t><b/><t>将等级提升至四道3修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>心动后期</t><b/><t>将等级提升至五道3修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神中期</t><b/><t>将等级提升至六道3修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'>"@ %TJjingjie @"</t>";




			case "FiveBitMipInMiddleNot_2"://未达条件第二个
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>开光中期</t><b/><t>将等级提升至一道4修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>练气前期</t><b/><t>将等级提升至二道4修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>辟谷后期</t><b/><t>将等级提升至三道4修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>修神中期</t><b/><t>将等级提升至四道4修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元婴前期</t><b/><t>将等级提升至五道4修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神后期</t><b/><t>将等级提升至六道4修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'>"@ %TJjingjie @"</t>";



			case "FiveBitMipInMiddleNot_3"://未达条件第三个
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>开光后期</t><b/><t>将等级提升至一道5修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>练气中期</t><b/><t>将等级提升至二道5修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>金丹前期</t><b/><t>将等级提升至三道5修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>修神后期</t><b/><t>将等级提升至四道5修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元婴中期</t><b/><t>将等级提升至五道5修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>空冥前期</t><b/><t>将等级提升至六道5修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'>"@ %TJjingjie @"</t>";



			case "FiveBitMipInMiddleNot_4"://未达条件第四个
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>筑基前期</t><b/><t>将等级提升至一道6修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>练气后期</t><b/><t>将等级提升至二道6修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>金丹中期</t><b/><t>将等级提升至三道6修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>心动前期</t><b/><t>将等级提升至四道6修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>元婴后期</t><b/><t>将等级提升至五道6修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>空冥中期</t><b/><t>将等级提升至六道6修9重可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'>"@ %TJjingjie @"</t>";


			case "FiveBitMipInMiddleNot_5"://未达条件第五个
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>筑基中期</t><b/><t>将等级提升至相应等级可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>辟谷前期</t><b/><t>将等级提升至相应等级可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>金丹后期</t><b/><t>将等级提升至相应等级可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>心动中期</t><b/><t>将等级提升至相应等级可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>化神前期</t><b/><t>将等级提升至相应等级可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>空冥后期</t><b/><t>将等级提升至相应等级可以进行渡劫，渡劫后将获得人物属性加成</t>";
				}


				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'>"@ %TJjingjie @"</t>";



				//===============================================================================经脉系统=========================================================================
				//upcs(99);OpenOrCloseJingLuo_MainWnd()
				/*
				105099251	一品洗髓丹
				105099252	二品洗髓丹
				105099253	三品洗髓丹
				105099254	四品洗髓丹
				105099255	五品洗髓丹
				*/


				//=================任脉系统===========

			case "RenMaiWnd_Unable_XueWei_1"://任脉-00承浆穴
				if ($DoufuGan_Item[105099251,2] > 0)
				{
					closeHelpDirect1_4(10028);

					OpenDouFuGan(10029);

					$DoufuGan_Item[105099251,2] = 0;
				}

				%item = GetPlayer().GetItemCount(105099251);
				%jingmai = GetCurGodPrintLevel(0,0);

				if (%jingmai == 0)
				{


					%FirstLevel1 ="承浆穴</t><t m='1' f='宋体' n='12' b='1' c='0x969399ff'>（0/2）";
					%Attr1 ="<t c='0x969399ff'>未激活：体力+200 精力+120</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：体力+280 精力+170</t><b/>";
					%Attr3 ="";
					%Attr4 ="";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>一品洗髓丹:"@ %item @"/1</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+200</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="承浆穴</t><t m='1' f='宋体' n='12' b='1' >（1/2）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+200 精力+120</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：体力+280 精力+170</t><b/>";
					%Attr3 ="";
					%Attr4 ="";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>一品洗髓丹:"@ %item @"/3</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+200</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="承浆穴</t><t m='1' f='宋体' n='12' b='1' >（2/2）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+200 精力+120</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：体力+280 精力+170</t><b/>";
					%Attr3 ="";
					%Attr4 ="";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活额外属性：</t><b/><t c='0xff00ffff'>最大体力+200</t>";
				}


				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='宋体' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";



			case "RenMaiWnd_Unable_XueWei_2"://任脉-01璇玑穴
				%item = GetPlayer().GetItemCount(105099252);
				%jingmai = GetCurGodPrintLevel(0,1);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="璇玑穴</t><t m='1' f='宋体' n='12' b='1' c='0x969399ff'>（0/4）";
					%Attr1 ="<t c='0x969399ff'>未激活：体力+220 精力+130</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：体力+310 精力+180</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：体力+430 精力+260</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：体力+600 精力+360</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>二品洗髓丹:"@ %item @"/1</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+500</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="璇玑穴</t><t m='1' f='宋体' n='12' b='1' >（1/4）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+220 精力+130</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：体力+310 精力+180</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：体力+430 精力+260</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：体力+600 精力+360</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>二品洗髓丹:"@ %item @"/3</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+500</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="璇玑穴</t><t m='1' f='宋体' n='12' b='1' >（2/4）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+220 精力+130</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：体力+310 精力+180</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：体力+430 精力+260</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：体力+600 精力+360</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>二品洗髓丹:"@ %item @"/5</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+500</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="璇玑穴</t><t m='1' f='宋体' n='12' b='1' >（3/4）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+220 精力+130</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：体力+310 精力+180</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：体力+430 精力+260</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：体力+600 精力+360</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>二品洗髓丹:"@ %item @"/7</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+500</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="璇玑穴</t><t m='1' f='宋体' n='12' b='1' >（4/4）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+220 精力+130</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：体力+310 精力+180</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：体力+430 精力+260</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：体力+600 精力+360</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活额外属性：</t><b/><t c='0xff00ffff'>最大体力+500</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='宋体' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";




			case "RenMaiWnd_Unable_XueWei_3"://任脉-02华盖穴
				%item = GetPlayer().GetItemCount(105099253);
				%jingmai = GetCurGodPrintLevel(0,2);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="华盖穴</t><t m='1' f='宋体' n='12' b='1' c='0x969399ff'>（0/5）";
					%Attr1 ="<t c='0x969399ff'>未激活：体力+240 精力+150</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：体力+340 精力+200</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：体力+470 精力+280</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：体力+660 精力+400</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：体力+930 精力+560</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>三品洗髓丹:"@ %item @"/2</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+900</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="华盖穴</t><t m='1' f='宋体' n='12' b='1' >（1/5）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+240 精力+150</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：体力+340 精力+200</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：体力+470 精力+280</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：体力+660 精力+400</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：体力+930 精力+560</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>三品洗髓丹:"@ %item @"/4</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+900</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="华盖穴</t><t m='1' f='宋体' n='12' b='1' >（2/5）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+240 精力+150</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：体力+340 精力+200</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：体力+470 精力+280</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：体力+660 精力+400</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：体力+930 精力+560</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>三品洗髓丹:"@ %item @"/6</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+900</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="华盖穴</t><t m='1' f='宋体' n='12' b='1' >（3/5）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+240 精力+150</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：体力+340 精力+200</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：体力+470 精力+280</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：体力+660 精力+400</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：体力+930 精力+560</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>三品洗髓丹:"@ %item @"/8</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+900</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="华盖穴</t><t m='1' f='宋体' n='12' b='1' >（4/5）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+240 精力+150</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：体力+340 精力+200</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：体力+470 精力+280</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：体力+660 精力+400</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：体力+930 精力+560</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>三品洗髓丹:"@ %item @"/10</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+900</t>";
				}
				else if (%jingmai == 5)
				{
					%FirstLevel1 ="华盖穴</t><t m='1' f='宋体' n='12' b='1' >（5/5）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+240 精力+150</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：体力+340 精力+200</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：体力+470 精力+280</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：体力+660 精力+400</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>已激活：体力+930 精力+560</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活额外属性：</t><b/><t c='0xff00ffff'>最大体力+900</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='宋体' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";



			case "RenMaiWnd_Unable_XueWei_4"://任脉-03玉堂穴
				%item = GetPlayer().GetItemCount(105099254);
				%jingmai = GetCurGodPrintLevel(0,3);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="玉堂穴</t><t m='1' f='宋体' n='12' b='1' c='0x969399ff'>（0/6）";
					%Attr1 ="<t c='0x969399ff'>未激活：体力+270  精力+160</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：体力+370  精力+220</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：体力+520  精力+310</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：体力+730  精力+440</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：体力+1020 精力+610</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：体力+1430 精力+860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>四品洗髓丹:"@ %item @"/2</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+1500</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="玉堂穴</t><t m='1' f='宋体' n='12' b='1' >（1/6）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+270  精力+160</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：体力+370  精力+220</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：体力+520  精力+310</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：体力+730  精力+440</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：体力+1020 精力+610</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：体力+1430 精力+860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>四品洗髓丹:"@ %item @"/4</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+1500</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="玉堂穴</t><t m='1' f='宋体' n='12' b='1' >（2/6）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+270  精力+160</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：体力+370  精力+220</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：体力+520  精力+310</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：体力+730  精力+440</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：体力+1020 精力+610</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：体力+1430 精力+860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>四品洗髓丹:"@ %item @"/6</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+1500</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="玉堂穴</t><t m='1' f='宋体' n='12' b='1' >（3/6）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+270  精力+160</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：体力+370  精力+220</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：体力+520  精力+310</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：体力+730  精力+440</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：体力+1020 精力+610</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：体力+1430 精力+860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>四品洗髓丹:"@ %item @"/8</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+1500</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="玉堂穴</t><t m='1' f='宋体' n='12' b='1' >（4/6）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+270  精力+160</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：体力+370  精力+220</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：体力+520  精力+310</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：体力+730  精力+440</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：体力+1020 精力+610</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：体力+1430 精力+860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>四品洗髓丹:"@ %item @"/10</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+1500</t>";
				}
				else if (%jingmai == 5)
				{
					%FirstLevel1 ="玉堂穴</t><t m='1' f='宋体' n='12' b='1' >（5/6）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+270  精力+160</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：体力+370  精力+220</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：体力+520  精力+310</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：体力+730  精力+440</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>已激活：体力+1020 精力+610</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：体力+1430 精力+860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>四品洗髓丹:"@ %item @"/12</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+1500</t>";
				}
				else if (%jingmai == 6)
				{
					%FirstLevel1 ="玉堂穴</t><t m='1' f='宋体' n='12' b='1' >（6/6）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+270  精力+160</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：体力+370  精力+220</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：体力+520  精力+310</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：体力+730  精力+440</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>已激活：体力+1020 精力+610</t><b/>";
					%Attr6 ="<t c='0x3D8FD8ff'>已激活：体力+1430 精力+860</t><b/>";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活额外属性：</t><b/><t c='0xff00ffff'>最大体力+1500</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='宋体' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";



			case "RenMaiWnd_Unable_XueWei_5"://任脉-04膻中穴
				%item = GetPlayer().GetItemCount(105099255);
				%jingmai = GetCurGodPrintLevel(0,4);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="膻中穴</t><t m='1' f='宋体' n='12' b='1' c='0x969399ff'>（0/7）";
					%Attr1 ="<t c='0x969399ff'>未激活：体力+290  精力+180</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：体力+410  精力+250</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：体力+570  精力+340</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：体力+800  精力+480</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：体力+1120 精力+670</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：体力+1570 精力+940</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：体力+2200 精力+1320</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/3</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+3000</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="膻中穴</t><t m='1' f='宋体' n='12' b='1' >（1/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+290  精力+180</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：体力+410  精力+250</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：体力+570  精力+340</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：体力+800  精力+480</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：体力+1120 精力+670</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：体力+1570 精力+940</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：体力+2200 精力+1320</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/5</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+3000</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="膻中穴</t><t m='1' f='宋体' n='12' b='1' >（2/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+290  精力+180</t><b/>";
					%Attr2 ="<t c='0x969399ff'>已激活：体力+410  精力+250</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：体力+570  精力+340</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：体力+800  精力+480</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：体力+1120 精力+670</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：体力+1570 精力+940</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：体力+2200 精力+1320</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/7</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+3000</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="膻中穴</t><t m='1' f='宋体' n='12' b='1' >（3/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+290  精力+180</t><b/>";
					%Attr2 ="<t c='0x969399ff'>已激活：体力+410  精力+250</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：体力+570  精力+340</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：体力+800  精力+480</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：体力+1120 精力+670</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：体力+1570 精力+940</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：体力+2200 精力+1320</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/9</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+3000</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="膻中穴</t><t m='1' f='宋体' n='12' b='1' >（6/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+290  精力+180</t><b/>";
					%Attr2 ="<t c='0x969399ff'>已激活：体力+410  精力+250</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：体力+570  精力+340</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：体力+800  精力+480</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：体力+1120 精力+670</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：体力+1570 精力+940</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：体力+2200 精力+1320</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/11</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+3000</t>";
				}
				else if (%jingmai == 5)
				{
					%FirstLevel1 ="膻中穴</t><t m='1' f='宋体' n='12' b='1' >（5/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+290  精力+180</t><b/>";
					%Attr2 ="<t c='0x969399ff'>已激活：体力+410  精力+250</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：体力+570  精力+340</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：体力+800  精力+480</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>已激活：体力+1120 精力+670</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：体力+1570 精力+940</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：体力+2200 精力+1320</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/13</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+3000</t>";
				}
				else if (%jingmai == 6)
				{
					%FirstLevel1 ="膻中穴</t><t m='1' f='宋体' n='12' b='1' >（6/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+290  精力+180</t><b/>";
					%Attr2 ="<t c='0x969399ff'>已激活：体力+410  精力+250</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：体力+570  精力+340</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：体力+800  精力+480</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>已激活：体力+1120 精力+670</t><b/>";
					%Attr6 ="<t c='0x3D8FD8ff'>已激活：体力+1570 精力+940</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：体力+2200 精力+1320</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/15</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>最大体力+3000</t>";
				}
				else if (%jingmai == 7)
				{
					%FirstLevel1 ="膻中穴</t><t m='1' f='宋体' n='12' b='1' >（7/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：体力+290  精力+180</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：体力+410  精力2+50</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：体力+570  精力+340</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：体力+800  精力+480</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>已激活：体力+1120 精力+670</t><b/>";
					%Attr6 ="<t c='0x3D8FD8ff'>已激活：体力+1570 精力+940</t><b/>";
					%Attr7 ="<t c='0x3D8FD8ff'>已激活：体力+2200 精力+1320</t><b/>";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活额外属性：</t><b/><t c='0xff00ffff'>最大体力+3000</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='宋体' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";



				//=================督脉系统===========

			case "DuMaiWnd_Unable_XueWei_1"://督脉-00商阳穴
				%item = GetPlayer().GetItemCount(105099251);
				%jingmai = GetCurGodPrintLevel(1,0);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="商阳穴</t><t m='1' f='宋体' n='12' b='1' c='0x969399ff'>（0/2）";
					%Attr1 ="<t c='0x969399ff'>未激活：物理攻击+50 法术攻击+50</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理攻击+70 法术攻击+70</t><b/>";
					%Attr3 ="";
					%Attr4 ="";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>一品洗髓丹:"@ %item @"/1</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+180</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="商阳穴</t><t m='1' f='宋体' n='12' b='1' >（1/2）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+50 法术攻击+50</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理攻击+70 法术攻击+70</t><b/>";
					%Attr3 ="";
					%Attr4 ="";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>一品洗髓丹:"@ %item @"/3</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+180</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="商阳穴</t><t m='1' f='宋体' n='12' b='1' >（2/2）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+50 法术攻击+50</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理攻击+70 法术攻击+70</t><b/>";
					%Attr3 ="";
					%Attr4 ="";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活额外属性：</t><b/><t c='0xff00ffff'>暴击值+180</t>";
				}


				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='宋体' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";




			case "DuMaiWnd_Unable_XueWei_2"://督脉-01肩贞穴
				if ($DoufuGan_Item[105099252,5] > 0)
				{
					closeHelpDirect1_4(10032);

					OpenDouFuGan(10029);

					$DoufuGan_Item[105099251,5] = 0;
				}


				%item = GetPlayer().GetItemCount(105099252);
				%jingmai = GetCurGodPrintLevel(1,1);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="肩井穴</t><t m='1' f='宋体' n='12' b='1' c='0x969399ff'>（0/4）";
					%Attr1 ="<t c='0x969399ff'>未激活：物理攻击+70  法术攻击+70</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理攻击+90  法术攻击+90</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理攻击+130 法术攻击+130</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理攻击+190 法术攻击+190</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>二品洗髓丹:"@ %item @"/1</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+315</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="肩井穴</t><t m='1' f='宋体' n='12' b='1' >（1/4）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+70  法术攻击+70</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理攻击+90  法术攻击+90</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理攻击+130 法术攻击+130</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理攻击+190 法术攻击+190</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>二品洗髓丹:"@ %item @"/3</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+315</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="肩井穴</t><t m='1' f='宋体' n='12' b='1' >（2/4）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+70  法术攻击+70</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理攻击+90  法术攻击+90</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理攻击+130 法术攻击+130</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理攻击+190 法术攻击+190</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>二品洗髓丹:"@ %item @"/5</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+315</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="肩井穴</t><t m='1' f='宋体' n='12' b='1' >（3/4）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+70  法术攻击+70</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理攻击+90  法术攻击+90</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理攻击+130 法术攻击+130</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理攻击+190 法术攻击+190</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>二品洗髓丹:"@ %item @"/7</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+315</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="肩井穴</t><t m='1' f='宋体' n='12' b='1' >（4/4）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+70  法术攻击+70</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理攻击+90  法术攻击+90</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理攻击+130 法术攻击+130</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：物理攻击+190 法术攻击+190</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活额外属性：</t><b/><t c='0xff00ffff'>暴击值+315</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='宋体' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";




			case "DuMaiWnd_Unable_XueWei_3"://督脉-02魂门穴
				%item = GetPlayer().GetItemCount(105099253);
				%jingmai = GetCurGodPrintLevel(1,2);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="魂门穴</t><t m='1' f='宋体' n='12' b='1' c='0x969399ff'>（0/5）";
					%Attr1 ="<t c='0x969399ff'>未激活：物理攻击+90  法术攻击+90</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理攻击+110 法术攻击+110</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理攻击+150 法术攻击+150</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理攻击+210 法术攻击+210</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理攻击+290 法术攻击+290</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>三品洗髓丹:"@ %item @"/2</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+630</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="魂门穴</t><t m='1' f='宋体' n='12' b='1' >（1/5）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+90  法术攻击+90</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理攻击+110 法术攻击+110</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理攻击+150 法术攻击+150</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理攻击+210 法术攻击+210</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理攻击+290 法术攻击+290</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>三品洗髓丹:"@ %item @"/4</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+630</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="魂门穴</t><t m='1' f='宋体' n='12' b='1' >（2/5）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+90  法术攻击+90</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理攻击+110 法术攻击+110</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理攻击+150 法术攻击+150</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理攻击+210 法术攻击+210</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理攻击+290 法术攻击+290</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>三品洗髓丹:"@ %item @"/6</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+630</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="魂门穴</t><t m='1' f='宋体' n='12' b='1' >（3/5）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+90  法术攻击+90</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理攻击+110 法术攻击+110</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理攻击+150 法术攻击+150</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理攻击+210 法术攻击+210</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理攻击+290 法术攻击+290</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>三品洗髓丹:"@ %item @"/8</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+630</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="魂门穴</t><t m='1' f='宋体' n='12' b='1' >（4/5）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+90  法术攻击+90</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理攻击+110 法术攻击+110</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理攻击+150 法术攻击+150</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：物理攻击+210 法术攻击+210</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理攻击+290 法术攻击+290</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>三品洗髓丹:"@ %item @"/10</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+630</t>";
				}
				else if (%jingmai == 5)
				{
					%FirstLevel1 ="魂门穴</t><t m='1' f='宋体' n='12' b='1' >（5/5）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+90  法术攻击+90</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理攻击+110 法术攻击+110</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理攻击+150 法术攻击+150</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：物理攻击+210 法术攻击+210</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>已激活：物理攻击+290 法术攻击+290</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活额外属性：</t><b/><t c='0xff00ffff'>暴击值+630</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='宋体' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";



			case "DuMaiWnd_Unable_XueWei_4"://督脉-03合阳穴
				%item = GetPlayer().GetItemCount(105099254);
				%jingmai = GetCurGodPrintLevel(1,3);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="合阳穴</t><t m='1' f='宋体' n='12' b='1' c='0x969399ff'>（0/6）";
					%Attr1 ="<t c='0x969399ff'>未激活：物理攻击+110 法术攻击+110</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理攻击+130 法术攻击+130</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理攻击+170 法术攻击+170</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理攻击+230 法术攻击+230</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理攻击+310 法术攻击+310</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理攻击+410 法术攻击+410</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>四品洗髓丹:"@ %item @"/2</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+1125</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="合阳穴</t><t m='1' f='宋体' n='12' b='1' >（1/6）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+110 法术攻击+110</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理攻击+130 法术攻击+130</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理攻击+170 法术攻击+170</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理攻击+230 法术攻击+230</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理攻击+310 法术攻击+310</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理攻击+410 法术攻击+410</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>四品洗髓丹:"@ %item @"/4</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+1125</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="合阳穴</t><t m='1' f='宋体' n='12' b='1' >（2/6）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+110 法术攻击+110</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理攻击+130 法术攻击+130</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理攻击+170 法术攻击+170</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理攻击+230 法术攻击+230</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理攻击+310 法术攻击+310</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理攻击+410 法术攻击+410</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>四品洗髓丹:"@ %item @"/6</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+1125</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="合阳穴</t><t m='1' f='宋体' n='12' b='1' >（3/6）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+110 法术攻击+110</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理攻击+130 法术攻击+130</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理攻击+170 法术攻击+170</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理攻击+230 法术攻击+230</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理攻击+310 法术攻击+310</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理攻击+410 法术攻击+410</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>四品洗髓丹:"@ %item @"/8</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+1125</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="合阳穴</t><t m='1' f='宋体' n='12' b='1' >（4/6）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+110 法术攻击+110</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理攻击+130 法术攻击+130</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理攻击+170 法术攻击+170</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：物理攻击+230 法术攻击+230</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理攻击+310 法术攻击+310</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理攻击+410 法术攻击+410</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>四品洗髓丹:"@ %item @"/10</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+1125</t>";
				}
				else if (%jingmai == 5)
				{
					%FirstLevel1 ="合阳穴</t><t m='1' f='宋体' n='12' b='1' >（5/6）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+110 法术攻击+110</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理攻击+130 法术攻击+130</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理攻击+170 法术攻击+170</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：物理攻击+230 法术攻击+230</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>已激活：物理攻击+310 法术攻击+310</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理攻击+410 法术攻击+410</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>四品洗髓丹:"@ %item @"/12</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+1125</t>";
				}
				else if (%jingmai == 6)
				{
					%FirstLevel1 ="合阳穴</t><t m='1' f='宋体' n='12' b='1' >（6/6）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+110 法术攻击+110</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理攻击+130 法术攻击+130</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理攻击+170 法术攻击+170</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：物理攻击+230 法术攻击+230</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>已激活：物理攻击+310 法术攻击+310</t><b/>";
					%Attr6 ="<t c='0x3D8FD8ff'>已激活：物理攻击+410 法术攻击+410</t><b/>";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活额外属性：</t><b/><t c='0xff00ffff'>暴击值+1125</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='宋体' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";



			case "DuMaiWnd_Unable_XueWei_5"://督脉-04金门穴
				%item = GetPlayer().GetItemCount(105099255);
				%jingmai = GetCurGodPrintLevel(1,4);


				if (%jingmai == 0)
				{
					%FirstLevel1 ="金门穴</t><t m='1' f='宋体' n='12' b='1' c='0x969399ff'>（0/7）";
					%Attr1 ="<t c='0x969399ff'>未激活：物理攻击+120 法术攻击+130</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理攻击+140 法术攻击+150</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理攻击+180 法术攻击+190</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理攻击+240 法术攻击+250</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理攻击+330 法术攻击+330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理攻击+430 法术攻击+430</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：物理攻击+650 法术攻击+550</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/3</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+2250</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="金门穴</t><t m='1' f='宋体' n='12' b='1' >（1/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+120 法术攻击+130</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理攻击+140 法术攻击+150</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理攻击+180 法术攻击+190</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理攻击+240 法术攻击+250</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理攻击+330 法术攻击+330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理攻击+430 法术攻击+430</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：物理攻击+650 法术攻击+550</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/5</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+2250</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="金门穴</t><t m='1' f='宋体' n='12' b='1' >（2/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+120 法术攻击+130</t><b/>";
					%Attr2 ="<t c='0x969399ff'>已激活：物理攻击+140 法术攻击+150</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理攻击+180 法术攻击+190</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理攻击+240 法术攻击+250</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理攻击+330 法术攻击+330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理攻击+430 法术攻击+430</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：物理攻击+650 法术攻击+550</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/7</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+2250</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="金门穴</t><t m='1' f='宋体' n='12' b='1' >（3/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+120 法术攻击+130</t><b/>";
					%Attr2 ="<t c='0x969399ff'>已激活：物理攻击+140 法术攻击+150</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理攻击+180 法术攻击+190</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理攻击+240 法术攻击+250</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理攻击+330 法术攻击+330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理攻击+430 法术攻击+430</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：物理攻击+650 法术攻击+550</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/9</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+2250</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="金门穴</t><t m='1' f='宋体' n='12' b='1' >（6/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+120 法术攻击+130</t><b/>";
					%Attr2 ="<t c='0x969399ff'>已激活：物理攻击+140 法术攻击+150</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理攻击+180 法术攻击+190</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：物理攻击+240 法术攻击+250</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理攻击+330 法术攻击+330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理攻击+430 法术攻击+430</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：物理攻击+650 法术攻击+550</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/11</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+2250</t>";
				}
				else if (%jingmai == 5)
				{
					%FirstLevel1 ="金门穴</t><t m='1' f='宋体' n='12' b='1' >（5/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+120 法术攻击+130</t><b/>";
					%Attr2 ="<t c='0x969399ff'>已激活：物理攻击+140 法术攻击+150</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理攻击+180 法术攻击+190</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：物理攻击+240 法术攻击+250</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>已激活：物理攻击+330 法术攻击+330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理攻击+430 法术攻击+430</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：物理攻击+650 法术攻击+550</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/13</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+2250</t>";
				}
				else if (%jingmai == 6)
				{
					%FirstLevel1 ="金门穴</t><t m='1' f='宋体' n='12' b='1' >（6/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+120 法术攻击+130</t><b/>";
					%Attr2 ="<t c='0x969399ff'>已激活：物理攻击+140 法术攻击+150</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理攻击+180 法术攻击+190</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：物理攻击+240 法术攻击+250</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>已激活：物理攻击+330 法术攻击+330</t><b/>";
					%Attr6 ="<t c='0x3D8FD8ff'>已激活：物理攻击+430 法术攻击+430</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：物理攻击+650 法术攻击+550</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/15</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>暴击值+2250</t>";
				}
				else if (%jingmai == 7)
				{
					%FirstLevel1 ="金门穴</t><t m='1' f='宋体' n='12' b='1' >（7/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理攻击+120 法术攻击+130</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理攻击+140 法术攻击+150</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理攻击+180 法术攻击+190</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：物理攻击+240 法术攻击+250</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>已激活：物理攻击+330 法术攻击+330</t><b/>";
					%Attr6 ="<t c='0x3D8FD8ff'>已激活：物理攻击+430 法术攻击+430</t><b/>";
					%Attr7 ="<t c='0x3D8FD8ff'>已激活：物理攻击+650 法术攻击+550</t><b/>";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活额外属性：</t><b/><t c='0xff00ffff'>暴击值+2250</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='宋体' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";


				//=================冲脉系统===========

			case "ChongMaiWnd_Unable_XueWei_1"://冲脉-00盲俞穴
				%item = GetPlayer().GetItemCount(105099251);
				%jingmai = GetCurGodPrintLevel(2,0);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="盲俞穴</t><t m='1' f='宋体' n='12' b='1' c='0x969399ff'>（0/2）";
					%Attr1 ="<t c='0x969399ff'>未激活：物理防御+200 法术防御+200</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理防御+280 法术防御+280</t><b/>";
					%Attr3 ="";
					%Attr4 ="";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>一品洗髓丹:"@ %item @"/1</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+200</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="盲俞穴</t><t m='1' f='宋体' n='12' b='1' >（1/2）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+200 法术防御+200</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理防御+280 法术防御+280</t><b/>";
					%Attr3 ="";
					%Attr4 ="";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>一品洗髓丹:"@ %item @"/3</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+200</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="盲俞穴</t><t m='1' f='宋体' n='12' b='1' >（2/2）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+200 法术防御+200</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理防御+280 法术防御+280</t><b/>";
					%Attr3 ="";
					%Attr4 ="";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活额外属性：</t><b/><t c='0xff00ffff'>坚韧值+200</t>";
				}


				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='宋体' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";




			case "ChongMaiWnd_Unable_XueWei_2"://冲脉-01石关穴
				%item = GetPlayer().GetItemCount(105099252);
				%jingmai = GetCurGodPrintLevel(2,1);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="石关穴</t><t m='1' f='宋体' n='12' b='1' c='0x969399ff'>（0/4）";
					%Attr1 ="<t c='0x969399ff'>未激活：物理防御+240 法术防御+240</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理防御+340 法术防御+340</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理防御+470 法术防御+470</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理防御+660 法术防御+660</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>二品洗髓丹:"@ %item @"/1</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+350</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="石关穴</t><t m='1' f='宋体' n='12' b='1' >（1/4）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+240 法术防御+240</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理防御+340 法术防御+340</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理防御+470 法术防御+470</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理防御+660 法术防御+660</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>二品洗髓丹:"@ %item @"/3</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+350</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="石关穴</t><t m='1' f='宋体' n='12' b='1' >（2/4）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+240 法术防御+240</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理防御+340 法术防御+340</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理防御+470 法术防御+470</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理防御+660 法术防御+660</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>二品洗髓丹:"@ %item @"/5</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+350</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="石关穴</t><t m='1' f='宋体' n='12' b='1' >（3/4）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+240 法术防御+240</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理防御+340 法术防御+340</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理防御+470 法术防御+470</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理防御+660 法术防御+660</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>二品洗髓丹:"@ %item @"/7</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+350</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="石关穴</t><t m='1' f='宋体' n='12' b='1' >（4/4）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+240 法术防御+240</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理防御+340 法术防御+340</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理防御+470 法术防御+470</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：物理防御+660 法术防御+660</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活额外属性：</t><b/><t c='0xff00ffff'>坚韧值+350</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='宋体' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";





			case "ChongMaiWnd_Unable_XueWei_3"://冲脉-02幽门穴
				%item = GetPlayer().GetItemCount(105099253);
				%jingmai = GetCurGodPrintLevel(2,2);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="幽门穴</t><t m='1' f='宋体' n='12' b='1' c='0x969399ff'>（0/5）";
					%Attr1 ="<t c='0x969399ff'>未激活：物理防御+290  法术防御+290</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理防御+400  法术防御+400</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理防御+560  法术防御+560</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理防御+790  法术防御+790</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理防御+1110 法术防御+1110</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>三品洗髓丹:"@ %item @"/2</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+700</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="幽门穴</t><t m='1' f='宋体' n='12' b='1' >（1/5）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+290  法术防御+290</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理防御+400  法术防御+400</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理防御+560  法术防御+560</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理防御+790  法术防御+790</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理防御+1110 法术防御+1110</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>三品洗髓丹:"@ %item @"/4</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+700</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="幽门穴</t><t m='1' f='宋体' n='12' b='1' >（2/5）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+290  法术防御+290</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理防御+400  法术防御+400</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理防御+560  法术防御+560</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理防御+790  法术防御+790</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理防御+1110 法术防御+1110</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>三品洗髓丹:"@ %item @"/6</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+700</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="幽门穴</t><t m='1' f='宋体' n='12' b='1' >（3/5）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+290  法术防御+290</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理防御+400  法术防御+400</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理防御+560  法术防御+560</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理防御+790  法术防御+790</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理防御+1110 法术防御+1110</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>三品洗髓丹:"@ %item @"/8</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+700</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="幽门穴</t><t m='1' f='宋体' n='12' b='1' >（4/5）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+290  法术防御+290</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理防御+400  法术防御+400</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理防御+560  法术防御+560</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：物理防御+790  法术防御+790</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理防御+1110 法术防御+1110</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>三品洗髓丹:"@ %item @"/10</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+700</t>";
				}
				else if (%jingmai == 5)
				{
					%FirstLevel1 ="幽门穴</t><t m='1' f='宋体' n='12' b='1' >（5/5）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+290  法术防御+290</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理防御+400  法术防御+400</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理防御+560  法术防御+560</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：物理防御+790  法术防御+790</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>已激活：物理防御+1110 法术防御+1110</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活额外属性：</t><b/><t c='0xff00ffff'>坚韧值+700</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='宋体' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";



			case "ChongMaiWnd_Unable_XueWei_4"://冲脉-03商曲穴
				%item = GetPlayer().GetItemCount(105099254);
				%jingmai = GetCurGodPrintLevel(2,3);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="商曲穴</t><t m='1' f='宋体' n='12' b='1' c='0x969399ff'>（0/6）";
					%Attr1 ="<t c='0x969399ff'>未激活：物理防御+350  法术防御+350</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理防御+480  法术防御+480</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理防御+680  法术防御+680</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理防御+950  法术防御+950</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理防御+1330 法术防御+1330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理防御+1860 法术防御+1860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>四品洗髓丹:"@ %item @"/2</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+1250</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="商曲穴</t><t m='1' f='宋体' n='12' b='1' >（1/6）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+350  法术防御+350</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理防御+480  法术防御+480</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理防御+680  法术防御+680</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理防御+950  法术防御+950</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理防御+1330 法术防御+1330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理防御+1860 法术防御+1860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>四品洗髓丹:"@ %item @"/4</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+1250</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="商曲穴</t><t m='1' f='宋体' n='12' b='1' >（2/6）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+350  法术防御+350</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理防御+480  法术防御+480</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理防御+680  法术防御+680</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理防御+950  法术防御+950</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理防御+1330 法术防御+1330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理防御+1860 法术防御+1860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>四品洗髓丹:"@ %item @"/6</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+1250</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="商曲穴</t><t m='1' f='宋体' n='12' b='1' >（3/6）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+350  法术防御+350</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理防御+480  法术防御+480</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理防御+680  法术防御+680</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理防御+950  法术防御+950</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理防御+1330 法术防御+1330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理防御+1860 法术防御+1860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>四品洗髓丹:"@ %item @"/8</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+1250</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="商曲穴</t><t m='1' f='宋体' n='12' b='1' >（4/6）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+350  法术防御+350</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理防御+480  法术防御+480</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理防御+680  法术防御+680</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：物理防御+950  法术防御+950</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理防御+1330 法术防御+1330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理防御+1860 法术防御+1860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>四品洗髓丹:"@ %item @"/10</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+1250</t>";
				}
				else if (%jingmai == 5)
				{
					%FirstLevel1 ="商曲穴</t><t m='1' f='宋体' n='12' b='1' >（5/6）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+350  法术防御+350</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理防御+480  法术防御+480</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理防御+680  法术防御+680</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：物理防御+950  法术防御+950</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>已激活：物理防御+1330 法术防御+1330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理防御+1860 法术防御+1860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>四品洗髓丹:"@ %item @"/12</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+1250</t>";
				}
				else if (%jingmai == 6)
				{
					%FirstLevel1 ="商曲穴</t><t m='1' f='宋体' n='12' b='1' >（6/6）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+350  法术防御+350</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理防御+480  法术防御+480</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理防御+680  法术防御+680</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：物理防御+950  法术防御+950</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>已激活：物理防御+1330 法术防御+1330</t><b/>";
					%Attr6 ="<t c='0x3D8FD8ff'>已激活：物理防御+1860 法术防御+1860</t><b/>";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活额外属性：</t><b/><t c='0xff00ffff'>坚韧值+1250</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='宋体' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";



			case "ChongMaiWnd_Unable_XueWei_5"://冲脉-04通谷穴
				%item = GetPlayer().GetItemCount(105099255);
				%jingmai = GetCurGodPrintLevel(2,4);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="通谷穴</t><t m='1' f='宋体' n='12' b='1' c='0x969399ff'>（0/7）";
					%Attr1 ="<t c='0x969399ff'>未激活：物理防御+410  法术防御+410</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理防御+580  法术防御+580</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理防御+810  法术防御+810</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理防御+1140 法术防御+1140</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理防御+1590 法术防御+1590</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理防御+2230 法术防御+2230</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：物理防御+3120 法术防御+3120</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/3</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+2500</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="通谷穴</t><t m='1' f='宋体' n='12' b='1' >（1/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+410  法术防御+410</t><b/>";
					%Attr2 ="<t c='0x969399ff'>未激活：物理防御+580  法术防御+580</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理防御+810  法术防御+810</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理防御+1140 法术防御+1140</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理防御+1590 法术防御+1590</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理防御+2230 法术防御+2230</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：物理防御+3120 法术防御+3120</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/5</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+2500</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="通谷穴</t><t m='1' f='宋体' n='12' b='1' >（2/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+410  法术防御+410</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理防御+580  法术防御+580</t><b/>";
					%Attr3 ="<t c='0x969399ff'>未激活：物理防御+810  法术防御+810</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理防御+1140 法术防御+1140</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理防御+1590 法术防御+1590</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理防御+2230 法术防御+2230</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：物理防御+3120 法术防御+3120</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/7</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+2500</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="通谷穴</t><t m='1' f='宋体' n='12' b='1' >（3/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+410  法术防御+410</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理防御+580  法术防御+580</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理防御+810  法术防御+810</t><b/>";
					%Attr4 ="<t c='0x969399ff'>未激活：物理防御+1140 法术防御+1140</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理防御+1590 法术防御+1590</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理防御+2230 法术防御+2230</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：物理防御+3120 法术防御+3120</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/9</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+2500</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="通谷穴</t><t m='1' f='宋体' n='12' b='1' >（6/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+410  法术防御+410</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理防御+580  法术防御+580</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理防御+810  法术防御+810</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：物理防御+1140 法术防御+1140</t><b/>";
					%Attr5 ="<t c='0x969399ff'>未激活：物理防御+1590 法术防御+1590</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理防御+2230 法术防御+2230</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：物理防御+3120 法术防御+3120</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/11</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+2500</t>";
				}
				else if (%jingmai == 5)
				{
					%FirstLevel1 ="通谷穴</t><t m='1' f='宋体' n='12' b='1' >（5/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+410  法术防御+410</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理防御+580  法术防御+580</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理防御+810  法术防御+810</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：物理防御+1140 法术防御+1140</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>已激活：物理防御+1590 法术防御+1590</t><b/>";
					%Attr6 ="<t c='0x969399ff'>未激活：物理防御+2230 法术防御+2230</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：物理防御+3120 法术防御+3120</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/13</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+2500</t>";
				}
				else if (%jingmai == 6)
				{
					%FirstLevel1 ="通谷穴</t><t m='1' f='宋体' n='12' b='1' >（6/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：物理防御+410  法术防御+410</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：物理防御+580  法术防御+580</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：物理防御+810  法术防御+810</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：物理防御+1140 法术防御+1140</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>已激活：物理防御+1590 法术防御+1590</t><b/>";
					%Attr6 ="<t c='0x3D8FD8ff'>已激活：物理防御+2230 法术防御+2230</t><b/>";
					%Attr7 ="<t c='0x969399ff'>未激活：物理防御+3120 法术防御+3120</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>冲穴需求：</t><b/><t c='0xff00ffff'>五品洗髓丹:"@ %item @"/15</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活所有属性后可获得额外属性：</t><b/><t c='0x969399ff'>坚韧值+2500</t>";
				}
				else if (%jingmai == 7)
				{
					%FirstLevel1 ="通谷穴</t><t m='1' f='宋体' n='12' b='1' >（7/7）";
					%Attr1 ="<t c='0x3D8FD8ff'>已激活：</t><t c='0x3D8FD8ff'>物理防御+410  法术防御+410</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>已激活：</t><t c='0x3D8FD8ff'>物理防御+580  法术防御+580</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>已激活：</t><t c='0x3D8FD8ff'>物理防御+810  法术防御+810</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>已激活：</t><t c='0x3D8FD8ff'>物理防御+1140 法术防御+1140</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>已激活：</t><t c='0x3D8FD8ff'>物理防御+1590 法术防御+1590</t><b/>";
					%Attr6 ="<t c='0x3D8FD8ff'>已激活：</t><t c='0x3D8FD8ff'>物理防御+2230 法术防御+2230</t><b/>";
					%Attr7 ="<t c='0x3D8FD8ff'>已激活：</t><t c='0x3D8FD8ff'>物理防御+3120 法术防御+3120</t><b/>";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>激活额外属性：</t><b/><t c='0xff00ffff'>坚韧值+2500</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='宋体' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";

			case "DTPlayerInfoGui_Tong1"://战斗力
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>战斗力用途</t><b/><t>与玩家战斗时，战斗力高的一方，会额外获得</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>无视防御</t><t>和</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>所受伤害减免</t><t>效果，双方</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>的战斗力差差距越大，</t><t>提升的效果越明显。</t>";

			case "DTPlayerInfo_ZDLtext"://战斗力
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>战斗力</t><b/><t>可通过游戏内多种系统玩法来提升战斗力</t>";

	}

	//【 欢乐大转盘 】界面相关
	switch$(%ctrl.GetName())
	{
			case "HappinessRandomAwardGuiChooseBag_1":%ctrl.tooltipWidth = 220;%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>白色福袋</t><b/><t>使用一级转运珠可以去除该福袋</t>";
			case "HappinessRandomAwardGuiChooseBag_2":%ctrl.tooltipWidth = 220;%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>绿色福袋</t><b/><t>使用二级转运珠可以去除该福袋，白色福袋也同时去除</t>";
			case "HappinessRandomAwardGuiChooseBag_3":%ctrl.tooltipWidth = 220;%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>蓝色福袋</t><b/><t>使用二级转运珠可以去除该福袋，白色福袋也同时去除</t>";
			case "HappinessRandomAwardGuiChooseBag_4":%ctrl.tooltipWidth = 220;%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>紫色福袋</t><b/><t>杨广收集天下奇珍藏于此福袋当中，时常拿出来把玩一下。某日不慎丢失...</t>";
			case "HappinessRandomAwardGuiChooseBag_5":%ctrl.tooltipWidth = 220;%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>橙色福袋</t><b/><t>蕴含了百年龙脉之气，光从袋口透露出的微微金光就可知袋内所装之物非同小可。</t>";

			case "HappinessRandomAward_Cancel_Dark_1":%ctrl.tooltipWidth = 150;%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>一级转运珠</t><b/><t>点击使用一级转运珠</t>";
			case "HappinessRandomAward_Cancel_Dark_2":%ctrl.tooltipWidth = 150;%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>二级转运珠</t><b/><t>点击使用二级转运珠</t>";
			case "HappinessRandomAward_Cancel_Dark_3":%ctrl.tooltipWidth = 150;%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>三级转运珠</t><b/><t>点击使用三级转运珠</t>";

			case "HappinessRandomAward_Cancel_Light_1":%ctrl.tooltipWidth = 150;%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>三级转运珠</t><b/><t>点击取消一级转运珠</t>";
			case "HappinessRandomAward_Cancel_Light_2":%ctrl.tooltipWidth = 150;%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>三级转运珠</t><b/><t>点击取消二级转运珠</t>";
			case "HappinessRandomAward_Cancel_Light_2":%ctrl.tooltipWidth = 150;%ctrl.tooltip ="<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>三级转运珠</t><b/><t>点击取消三级转运珠</t>";

			case "HappinessRandomAwardGuiStart":%ctrl.tooltipWidth = 220;%ctrl.tooltip ="<t m='1' f='宋体' n='12'>点击开始抽取福袋中的宝物，完成指定活动可获得抽奖次数</t>";



	}
}

function EndTooltip(%ctrl)
{

}


//■■■■■■■■■■■【星套强化相关】■■■■■■■■■■■■■■■■■■
function StartTooltip_DTPlayerInfo_FashionLevel(%ctrl,%Level)
{
	//%Level,强化等级		%ItemNum,装备数量
	//%Level = $FashionLevel;
	//%ItemNum = $CurColorFashionNum;
	//$g_MySelfEquipLevel  查看自己的信息
	//$g_TargetEquipLevel 目标界面按钮
	if (%Level < 3)
		%Level = 2;
	//字体颜色
	%YanSe[1]	= "<t m='0' f='黑体' h='1' b='1' n='16' c='0xf3d300ff' o='0x010101ff'>";		//标题文字
	%YanSe[2]	= "<t m='1' f='宋体' n='14' c='0xffffffff'>";												//描述文字
	%YanSe[3]	= "<t m='1' f='宋体' n='14' c='0xe8a455ff'>";												//描述文字（重点）
	%YanSe[3]	= "<t m='1' f='宋体' n='14' c='0xf3d300ff'>";
	%YanSe[4]	= "<t m='1' f='宋体' b='1' v='1' h='1' n='12' c='0x3b88ccff'>";	//分割线

	%ZtiYanSe[3] =	"<t c='0x00ff4eff' o='0x010101ff'";%TitleName[3] = "m='0' f='黑体' h='1' b='1' n='16'>" @ "三 才"; %EcName[3] = "m='1' f='宋体' n='14'>" @ "星套专属绿色光环";
	%ZtiYanSe[4] =	"<t c='0x00ff4eff' o='0x010101ff'";%TitleName[4] = "m='0' f='黑体' h='1' b='1' n='16'>" @ "四 象"; %EcName[4] = "m='1' f='宋体' n='14'>" @ "星套专属蓝色光环";
	%ZtiYanSe[5] =	"<t c='0x00ff4eff' o='0x010101ff'";%TitleName[5] = "m='0' f='黑体' h='1' b='1' n='16'>" @ "五 行"; %EcName[5] = "m='1' f='宋体' n='14'>" @ "星套专属紫色光环";

	%ZtiYanSe[6] =	"<t c='0x00baffff' o='0x2c2c2cff'";%TitleName[6] = "m='0' f='黑体' h='1' b='1' n='16'>" @ "六 合"; %EcName[6] = "m='1' f='宋体' n='14'>" @ "星套专属橙色光环";
	%ZtiYanSe[7] =	"<t c='0x00baffff' o='0x2c2c2cff'";%TitleName[7] = "m='0' f='黑体' h='1' b='1' n='16'>" @ "七 星"; %EcName[7] = "m='1' f='宋体' n='14'>" @ "星套专属红色光环";

	%ZtiYanSe[8] =	"<t c='0xff65feff' o='0x2c2c2cff'";%TitleName[8] = "m='0' f='黑体' h='1' b='1' n='16'>" @ "八 卦"; %EcName[8] = "m='1' f='宋体' n='14'>" @ "星套专属粉色光环";
	%ZtiYanSe[9] =	"<t c='0xff65feff' o='0x2c2c2cff'";%TitleName[9] = "m='0' f='黑体' h='1' b='1' n='16'>" @ "九 宫"; %EcName[9] = "m='1' f='宋体' n='14'>" @ "星套专属绿龙光环";

	%ZtiYanSe[10]=	"<t c='0xffa616ff' o='0x010101ff'";%TitleName[10]= "m='0' f='黑体' h='1' b='1' n='16'>" @ "十 方"; %EcName[10]= "m='1' f='宋体' n='14'>" @ "星套专属蓝龙光环";
	%ZtiYanSe[11]=	"<t c='0xffa616ff' o='0x010101ff'";%TitleName[11]= "m='0' f='黑体' h='1' b='1' n='16'>" @ "帝 陨"; %EcName[11]= "m='1' f='宋体' n='14'>" @ "星套专属紫龙光环";

	%ZtiYanSe[12]=	"<t c='0xffa616ff' o='0x010101ff'";%TitleName[12]= "m='0' f='黑体' h='1' b='1' n='16'>" @ "殇 神"; %EcName[12]= "m='1' f='宋体' n='14'>" @ "星套专属橙龙光环";
	%ZtiYanSe[13]=	"<t c='0xff0000ff' o='0x000000ff'";%TitleName[13]= "m='0' f='黑体' h='1' b='1' n='16'>" @ "主 宰"; %EcName[13]= "m='1' f='宋体' n='14'>" @ "星套专属红龙光环";
	%ZtiYanSe[14]=	"<t c='0xff0000ff' o='0x000000ff'";%TitleName[14]= "m='0' f='黑体' h='1' b='1' n='16'>" @ "天 谕"; %EcName[14]= "m='1' f='宋体' n='14'>" @ "星套专属红龙光环";
	%ZtiYanSe[15]=	"<t c='0xff0000ff' o='0x000000ff'";%TitleName[15]= "m='0' f='黑体' h='1' b='1' n='16'>" @ "无 极"; %EcName[15]= "m='1' f='宋体' n='14'>" @ "星套专属红龙光环";

	%HuiSe = "<t f='宋体' m='1' n='14' c='0xb2b2b2ff' o='0x010101ff'>";				//灰色

	if (%Level >= 3)
		%Txt0 =
		%ZtiYanSe[%Level] @ %TitleName[%Level] @ "</t><b/>" @
		%YanSe[2] @ "  穿戴</t>" @ %YanSe[3] @ "9件强化+" @ %Level @ "</t>" @ %YanSe[2] @ "的50级以上紫色装备</t><b/><b/>" @
		%YanSe[2] @ "  激活：</t>" @ %ZtiYanSe[%Level] @ %EcName[%Level] @ "</t><b/>";
	else
		%Txt0 ="<t m='0' f='黑体' h='1' b='1' v='1' n='16' c='0xb2b2b2ff' o='0x010101ff'>未激活</t>";

	if (%Level < 15)
		%Txt1 =
		%YanSe[4] @ "---------- 下一级 ----------</t><b/>" @
		"<t c='0xb2b2b2ff' o='0x010101ff'" @ %TitleName[%Level + 1] @ "</t><b/>" @
		%HuiSe @ "  穿戴9件强化+" @ %Level + 1 @ "的50级以上紫色装备</t><b/><b/>" @
		%HuiSe @ "  激活：</t>" @ "<t c='0xb2b2b2ff' o='0x010101ff'" @ %EcName[%Level + 1] @ "</t><b/>";

	%ctrl.tooltipWidth = 260;

	%Txt = %Txt0 @ %Txt1;

	%ctrl.tooltip = %Txt;
}


//■■■■■■■■■■■【三色石合成相关】■■■■■■■■■■■■■■■■■
function StartTooltip_ColorfulGem_Help0(%ctrl)
{
	//字体颜色
	%YanSe[1]	= "<t m='0' f='黑体' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//标题文字
	%YanSe[2,1]	= "<t m='1' f='宋体' n='12' c='0xffffffff'>";												//描述文字
	%YanSe[2,2]	= "<t m='1' f='宋体' n='12' c='0xe8a455ff'>";												//描述文字（重点）

	%Txt = %YanSe[1] @ "三色天珠合成说明：</t><b/>" @
		%YanSe[2,1] @ "1.三色天珠拥有三条属性，且属性数值和同等级天珠数值相同</t><b/>" @
		%YanSe[2,1] @ "2.合成只可放入同级别、不同属性的天珠</t><b/>" @
		%YanSe[2,1] @ "3.玄冰系列天珠不可参加合成</t><b/>" @
		%YanSe[2,1] @ "4.生成的天珠属性随机取参与合成的7个天珠中的3个</t>";

	%ctrl.tooltipWidth = 400;
	%ctrl.tooltip = %Txt;
}

//■■■■■■■■■■■【三色石分解相关】■■■■■■■■■■■■■■■■■
function StartTooltip_ColorfulGem_Help28(%ctrl)
{
	//字体颜色
	%YanSe[1]	= "<t m='0' f='黑体' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//标题文字
	%YanSe[2,1]	= "<t m='1' f='宋体' n='12' c='0xffffffff'>";												//描述文字
	%YanSe[2,2]	= "<t m='1' f='宋体' n='12' c='0xe8a455ff'>";												//描述文字（重点）

	%Txt = %YanSe[1] @ "三色天珠分解说明：</t><b/>" @
		%YanSe[2,1] @ "1.三色天珠可分解成三颗属性对应的单色天珠</t><b/>" @
		%YanSe[2,1] @ "2.分解后得到的天珠绑定</t>";

	%ctrl.tooltipWidth = 300;
	%ctrl.tooltip = %Txt;
}

//■■■■■■■■■■■【经脉冲穴相关】■■■■■■■■■■■■■■■■■
function StartTooltip_JingMai_EXP_Help(%ctrl)
{
	//字体颜色
	%YanSe[1]	= "<t m='0' f='黑体' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//标题文字
	%YanSe[2,1]	= "<t m='1' f='宋体' n='12' c='0xffffffff'>";												//描述文字
	%YanSe[2,2]	= "<t m='1' f='宋体' n='12' c='0xe8a455ff'>";												//描述文字（重点）

	%Txt = %YanSe[1] @ "穴道说明：</t><b/>" @
		%YanSe[2,1] @ "1.不同的穴道消耗不同的洗髓丹可进行冲穴，冲穴完毕后可激活该穴道。</t><b/>" @
		%YanSe[2,1] @ "2.该穴道激活后可进行开孔，开孔可随机获得一个颜色的孔，总共有四种颜色：红色、绿色、蓝色、三色</t><b/>" @
		%YanSe[2,1] @ "3.孔的颜色可决定这个孔可镶嵌何种颜色的天珠</t><b/>" @
		%YanSe[2,1] @ "4.三色孔最为珍贵，可镶嵌任何颜色天珠，并可以镶嵌最为珍贵的三色天珠</t><b/>" @
		%YanSe[2,2] @ "（三色天珠可在强化系统中的天珠界面内进行合成）</t><b/>" @
		%YanSe[2,1] @ "5.如果您对生成的孔的颜色不满意，可对开孔后的穴道进行散穴，散穴后再开孔可重新生成孔的颜色</t><b/>" @
		%YanSe[2,2] @ "（散穴后需要重新冲穴才能再开孔，请谨慎操作）</t><b/>" @
		%YanSe[2,1] @ "6.重新开孔可以提高获得三色孔的概率</t>";

	%ctrl.tooltipWidth = 680;
	%ctrl.tooltip = %Txt;
}

function StartTooltip_JinMai_Round_EXP(%ctrl)
{
	//字体颜色
	%YanSe[1]	= "<t m='0' f='黑体' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//标题文字
	%YanSe[2,1]	= "<t m='1' f='宋体' n='12' c='0xffffffff'>";												//描述文字
	%YanSe[2,2]	= "<t m='1' f='宋体' n='12' c='0xe8a455ff'>";												//描述文字（重点）

	%Txt = %YanSe[2,1] @ "当前穴道进度</t>";

	%ctrl.tooltipWidth = 120;
	%ctrl.tooltip = %Txt;
}

//■■■■■■■■■■■【经脉淬炼相关】■■■■■■■■■■■■■■■■■
function StartTooltip_JingMai_EXP_Help_1(%ctrl)
{
	//字体颜色
	%YanSe[1]	= "<t m='0' f='黑体' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//标题文字
	%YanSe[2,1]	= "<t m='1' f='宋体' n='12' c='0xffffffff'>";												//描述文字
	%YanSe[2,2]	= "<t m='1' f='宋体' n='12' c='0xe8a455ff'>";												//描述文字（重点）

	%Txt = %YanSe[1] @ "经脉淬炼说明：</t><b/>" @
		%YanSe[2,1] @ "1.相邻的两个穴道激活后，连接它们之间的经脉就可进行淬炼，淬炼需按照经脉的顺序进行。</t><b/>" @
		%YanSe[2,1] @ "2.直接在背包内使用炼体丹就可使您想淬炼的经脉获得经验</t><b/>" @
		%YanSe[2,1] @ "3.淬炼经脉得到一定经验后可获得经脉淬炼点数，经脉淬炼点数可用来升级经脉技能</t><b/>" @
		%YanSe[2,1] @ "4.每条经脉的每一淬炼阶段都有两个技能供您选择，选择其中一个技能升级后，则无法升级另外一个技能，选择前请谨慎考虑。</t><b/>" @
		%YanSe[2,1] @ "5.选择的经脉技能加满后才可升级下一阶段的经脉技能</t>";

	%ctrl.tooltipWidth = 630;
	%ctrl.tooltip = %Txt;
}

//未冲穴显示说明
function StartTooltip_JinMai_1_Unable_XueWei_1(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function StartTooltip_JinMai_1_Unable_XueWei_2(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function StartTooltip_JinMai_1_Unable_XueWei_3(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function StartTooltip_JinMai_1_Unable_XueWei_4(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function StartTooltip_JinMai_1_Unable_XueWei_5(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function StartTooltip_JinMai_2_Unable_XueWei_1(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function StartTooltip_JinMai_2_Unable_XueWei_2(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function StartTooltip_JinMai_2_Unable_XueWei_3(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function StartTooltip_JinMai_2_Unable_XueWei_4(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function StartTooltip_JinMai_2_Unable_XueWei_5(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function JinMai_Unable_XueWei(%ctrl)
{
	//字体颜色
	%YanSe[1]	= "<t m='0' f='黑体' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//标题文字
	%YanSe[2,1]	= "<t m='1' f='宋体' n='12' c='0xffffffff'>";												//描述文字
	%YanSe[2,2]	= "<t m='1' f='宋体' n='12' c='0xe8a455ff'>";												//描述文字（重点）

	%Txt = %YanSe[1] @ "穴道说明：</t><b/>" @
		%YanSe[2,1] @ "1.完成穴道冲穴进度后可激活穴道。</t><b/>" @
		%YanSe[2,1] @ "2.穴道激活后有附加属性。</t><b/>" @
		%YanSe[2,1] @ "3.穴道激活后可以为穴道开孔，用来镶嵌天珠。</t>";

	%ctrl.tooltipWidth = 320;
	%ctrl.tooltip = %Txt;
}

//开孔成功后显示说明
function StartTooltip_JingMai_1_Gem_1(%ctrl){ JinMai_Gem_KaiKong(0,%ctrl); }
function StartTooltip_JingMai_1_Gem_2(%ctrl){ JinMai_Gem_KaiKong(1,%ctrl); }
function StartTooltip_JingMai_1_Gem_3(%ctrl){ JinMai_Gem_KaiKong(2,%ctrl); }
function StartTooltip_JingMai_1_Gem_4(%ctrl){ JinMai_Gem_KaiKong(3,%ctrl); }
function StartTooltip_JingMai_1_Gem_5(%ctrl){ JinMai_Gem_KaiKong(4,%ctrl); }
function StartTooltip_JingMai_2_Gem_1(%ctrl){ JinMai_Gem_KaiKong(5,%ctrl); }
function StartTooltip_JingMai_2_Gem_2(%ctrl){ JinMai_Gem_KaiKong(6,%ctrl); }
function StartTooltip_JingMai_2_Gem_3(%ctrl){ JinMai_Gem_KaiKong(7,%ctrl); }
function StartTooltip_JingMai_2_Gem_4(%ctrl){ JinMai_Gem_KaiKong(8,%ctrl); }
function StartTooltip_JingMai_2_Gem_5(%ctrl){ JinMai_Gem_KaiKong(9,%ctrl); }
function JinMai_Gem_KaiKong(%Type,%ctrl)
{
	if (GetJinMaiHoleGemState(%Type,0) == 0)
	{
		//字体颜色
		%YanSe[1]	= "<t m='0' f='黑体' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//标题文字
		%YanSe[2,1]	= "<t m='1' f='宋体' n='12' c='0xffffffff'>";												//描述文字
		%YanSe[2,2]	= "<t m='1' f='宋体' n='12' c='0xe8a455ff'>";												//描述文字（重点）

		%Txt = %YanSe[1] @ "开孔说明：</t><b/>" @
			%YanSe[2,1] @ "1.孔有四种颜色：红色、蓝色、绿色、三色。</t><b/>" @
			%YanSe[2,1] @ "2.三色孔可镶嵌任意天珠，包括三色天珠（玄兵系列天珠无法镶嵌）。</t><b/>" @
			%YanSe[2,1] @ "3.对孔的颜色不满意可以散穴，重新冲穴开孔生成新的孔。</t><b/>" @
			%YanSe[2,1] @ "4.重新开孔会提高获得三色孔的概率。</t>";

		%ctrl.tooltipWidth = 350;
		%ctrl.tooltip = %Txt;
	}
	else
	{
		%ctrl.tooltip = "";
	}
}

//按钮功能说明
function StartTooltip_JinMai_1_ActiveBTN_1(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function StartTooltip_JinMai_1_ActiveBTN_2(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function StartTooltip_JinMai_1_ActiveBTN_3(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function StartTooltip_JinMai_1_ActiveBTN_4(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function StartTooltip_JinMai_1_ActiveBTN_5(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function StartTooltip_JinMai_2_ActiveBTN_1(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function StartTooltip_JinMai_2_ActiveBTN_2(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function StartTooltip_JinMai_2_ActiveBTN_3(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function StartTooltip_JinMai_2_ActiveBTN_4(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function StartTooltip_JinMai_2_ActiveBTN_5(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function JinMai_ActiveBTN_ChongXue(%ctrl)
{
	//字体颜色
	%YanSe[1]	= "<t m='0' f='黑体' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//标题文字
	%YanSe[2,1]	= "<t m='1' f='宋体' n='12' c='0xffffffff'>";												//描述文字
	%YanSe[2,2]	= "<t m='1' f='宋体' n='12' c='0xe8a455ff'>";												//描述文字（重点）

	%Txt = %YanSe[1] @ "按钮添状态说明：</t><b/>" @
		%YanSe[2,1] @ "1.冲穴：点击后会消耗相应道具进行冲穴，冲穴后会获得属性奖励。</t><b/>" @
		%YanSe[2,1] @ "2.开孔：穴道激活后可以进行开孔操作，开孔后会随机获得一个颜色的孔，可以镶嵌相应颜色的天珠。</t><b/>" @
		%YanSe[2,1] @ "3.散穴：对孔的颜色不满意可进行散穴，散穴后可再次重新开孔生成孔的颜色。没散穴一次都会增加获得三色孔的概率。</t><b/>" @
		%YanSe[2,1] @ "4.镶嵌：孔的颜色决定可镶嵌何种颜色的天珠。三色孔可镶嵌任何颜色天珠。（玄兵系列天珠无法镶嵌）。</t><b/>" @
		%YanSe[2,1] @ "5.摘取：镶嵌天珠的孔需要摘取天珠后才能进行散穴操作。</t>";

	%ctrl.tooltipWidth = 400;
	%ctrl.tooltip = %Txt;
}

function StartTooltip_JingMaiWndGui_Score_text(%ctrl)
{
	//字体颜色
	%YanSe[1]	= "<t m='0' f='黑体' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//标题文字
	%YanSe[2,1]	= "<t m='1' f='宋体' n='12' c='0xffffffff'>";												//描述文字
	%YanSe[2,2]	= "<t m='1' f='宋体' n='12' c='0xe8a455ff'>";												//描述文字（重点）

	%Txt = %YanSe[1] @ "经脉评分说明：</t><b/>" @
		%YanSe[2,1] @ "激活的穴道越多评分越高、镶嵌的天珠等级越高评分越高、经脉淬炼经验越高评分越高。</t>";

	%ctrl.tooltipWidth = 200;
	%ctrl.tooltip = %Txt;
}

//时装热感
function StartTooltip_DTPlayerInfo_SZZLtexthottip(%ctrl)
{
	//字体颜色
	%YanSe[1]	= "<t m='0' f='黑体' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//标题文字
	%YanSe[2,1]	= "<t m='1' f='宋体' n='12' c='0xffffffff'>";												//描述文字
	%YanSe[2,2]	= "<t m='1' f='宋体' n='12' c='0xe8a455ff'>";												//描述文字（重点）

	%Txt = %YanSe[1] @ "时装评分说明：</t><b/>" @
		%YanSe[2,1] @ "1.品质越高的时装评分越高，相同品质的时装也有不同。</t><b/>" @
		%YanSe[2,1] @ "2.橙色>紫色>蓝色>绿色。</t>";

	%ctrl.tooltipWidth = 220;
	%ctrl.tooltip = %Txt;
}


//■■■■■■■■■■■【队伍界面相关】■■■■■■■■■■■■■■■■■
//召唤队友
function StartTooltip_TeambeckonBtn(%ctrl)
{
	//字体颜色
	%YanSe[1]	= "<t m='0' f='黑体' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//标题文字
	%YanSe[2,1]	= "<t m='1' f='宋体' n='12' c='0xffffffff'>";												//描述文字
	%YanSe[2,2]	= "<t m='1' f='宋体' n='12' c='0xe8a455ff'>";												//描述文字（重点）

	%Txt = %YanSe[1] @ "召唤集合说明：</t><b/>" @
		%YanSe[2,1] @ "可将队友召唤集合到队长身边，需要消耗一个召唤符，可在元宝或积分商店购买。</t>";

	%ctrl.tooltipWidth = 220;
	%ctrl.tooltip = %Txt;
}

//请出队伍
function StartTooltip_KickOutTeamBtn(%ctrl)
{
	//字体颜色
	%YanSe[1]	= "<t m='0' f='黑体' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//标题文字
	%YanSe[2,1]	= "<t m='1' f='宋体' n='12' c='0xffffffff'>";												//描述文字
	%YanSe[2,2]	= "<t m='1' f='宋体' n='12' c='0xe8a455ff'>";												//描述文字（重点）

	%Txt = %YanSe[1] @ "请出队伍说明：</t><b/>" @
		%YanSe[2,1] @ "将选中的队员请出队伍</t>";

	%ctrl.tooltipWidth = 162;
	%ctrl.tooltip = %Txt;
}

//加为好友
function StartTooltip_jiaweixianyou(%ctrl)
{
	//字体颜色
	%YanSe[1]	= "<t m='0' f='黑体' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//标题文字
	%YanSe[2,1]	= "<t m='1' f='宋体' n='12' c='0xffffffff'>";												//描述文字
	%YanSe[2,2]	= "<t m='1' f='宋体' n='12' c='0xe8a455ff'>";												//描述文字（重点）

	%Txt = %YanSe[1] @ "加为好友说明：</t><b/>" @
		%YanSe[2,1] @ "将选中的队员加为好友</t>";

	%ctrl.tooltipWidth = 162;
	%ctrl.tooltip = %Txt;
}

//队伍跟随
function StartTooltip_TeamFollowBtn(%ctrl)
{
	//字体颜色
	%YanSe[1]	= "<t m='0' f='黑体' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//标题文字
	%YanSe[2,1]	= "<t m='1' f='宋体' n='12' c='0xffffffff'>";												//描述文字
	%YanSe[2,2]	= "<t m='1' f='宋体' n='12' c='0xe8a455ff'>";												//描述文字（重点）

	%Txt = %YanSe[1] @ "队伍跟随说明：</t><b/>" @
		%YanSe[2,1] @ "向队员发起跟随请求</t>";

	%ctrl.tooltipWidth = 150;
	%ctrl.tooltip = %Txt;
}

//邀请组队
function StartTooltip_TeamInviteBtn(%ctrl)
{
	//字体颜色
	%YanSe[1]	= "<t m='0' f='黑体' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//标题文字
	%YanSe[2,1]	= "<t m='1' f='宋体' n='12' c='0xffffffff'>";												//描述文字
	%YanSe[2,2]	= "<t m='1' f='宋体' n='12' c='0xe8a455ff'>";												//描述文字（重点）

	%Txt = %YanSe[1] @ "邀请组队说明：</t><b/>" @
		%YanSe[2,1] @ "向玩家发起组队请求</t>";

	%ctrl.tooltipWidth = 150;
	%ctrl.tooltip = %Txt;
}

//提升队长
function StartTooltip_DisplaceTeamHeaderBtn(%ctrl)
{
	//字体颜色
	%YanSe[1]	= "<t m='0' f='黑体' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//标题文字
	%YanSe[2,1]	= "<t m='1' f='宋体' n='12' c='0xffffffff'>";												//描述文字
	%YanSe[2,2]	= "<t m='1' f='宋体' n='12' c='0xe8a455ff'>";												//描述文字（重点）

	%Txt = %YanSe[1] @ "提升队长说明：</t><b/>" @
		%YanSe[2,1] @ "可将选中的队员提升为队长。</t>";

	%ctrl.tooltipWidth = 170;
	%ctrl.tooltip = %Txt;
}

//跟随队长
function StartTooltip_FollowLeaderBtn(%ctrl)
{
	//字体颜色
	%YanSe[1]	= "<t m='0' f='黑体' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//标题文字
	%YanSe[2,1]	= "<t m='1' f='宋体' n='12' c='0xffffffff'>";												//描述文字
	%YanSe[2,2]	= "<t m='1' f='宋体' n='12' c='0xe8a455ff'>";												//描述文字（重点）

	%Txt = %YanSe[1] @ "跟随说明：</t><b/>" @
		%YanSe[2,1] @ "将跟随队长</t>";

	%ctrl.tooltipWidth = 90;
	%ctrl.tooltip = %Txt;
}

