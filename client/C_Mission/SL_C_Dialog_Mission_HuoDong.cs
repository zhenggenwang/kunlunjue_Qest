
//function MissionxxxxxDialog( %Npc, %Player, %Mid, %Tid )//通用任务基础模板
//{
//	//echo( "%Tid ==" @ %Tid );
//	switch ( %Tid )
//	{
//
//		case 10001:	return "<t>废话</t><b/>"; //任务目标
//		case 10002:	return "<t>废话</t><b/>"; //接任务对白
//		case 10005:	return "<t>废话</t><b/>"; //任务完成时对白
//
//		case 20001:return "<t></t><b/>";//接任务前NPC的废话
//		case 21001:return "<t></t><b/>";//接任务前玩家的废话
//
//		case 30001:return "<t>1</t><b/>";//交任务前NPC的废话
//		case 31001:return "<t>1</t><b/>";//交任务前玩家的废话
//
//		case 30002:return "<t>2</t><b/>";//交任务前NPC的废话
//		case 31002:return "<t>2</t><b/>";//交任务前玩家的废话
//	}
//	if ( %Tid <= 20000 || %Tid >= 40000 )
//		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
//	else
//		return "";
//}
//■■■■■■■■■■■【大型活动类的任务】■■■■■■■【对白部分】■■■■■■■■■■■■■■

//■■■■■■■■■■■【冰火试练任务对白】■■■■■■■■■■■■■■

function Mission20103Dialog(%Npc,%Player,%Mid,%Tid)		   //寒冰之魂
{
	switch (%Tid)
	{
		case 10001:	return "<t>本座修炼神功暂需九天之上的寒冰之霜为引，你且去极寒之地取来，必有重赏。</t><b/>";
		case 10002:	return "<t>做的不错。</t><b/>";
		case 10005:	return "<t>采集寒冰之霜*5</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission20104Dialog(%Npc,%Player,%Mid,%Tid)		   //烈火之炎
{
	switch (%Tid)
	{
		case 10001:	return "<t>本座修炼神功暂需黄泉之下的烈火之炎为引，你且去极炎之地取来，必有重赏</t><b/>";
		case 10002:	return "<t>做的不错。</t><b/>";
		case 10005:	return "<t>采集烈火之炎*5</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission20105Dialog(%Npc,%Player,%Mid,%Tid)		   //铲除蟾妖
{
	switch (%Tid)
	{
		case 10001:	return "<t>据门下弟子来报，极寒之地的寒冰蟾窃玉偷香，乃为一害，我等修炼之人，上体天心，下怀民意，尔等前去降妖除魔！</t><b/>";
		case 10002:	return "<t>做的不错。</t><b/>";
		case 10005:	return "<t>击败寒冰蟾*10</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission20106Dialog(%Npc,%Player,%Mid,%Tid)		   //铲除妖蟒
{
	switch (%Tid)
	{
		case 10001:	return "<t>据门下弟子来报，极炎之地的烈焰蟒为害四方，乃为一害，我等修炼之人，上体天心，下怀民意，尔等前去降妖除魔！</t><b/>";
		case 10002:	return "<t>做的不错。</t><b/>";
		case 10005:	return "<t>击败烈焰蟒*10</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission20107Dialog(%Npc,%Player,%Mid,%Tid)		   //乔装采药·一
{
	switch (%Tid)
	{
		case 10001:	return "<t>灵泉之侧有灵药已到成熟之时，本使者考验下尔等变幻神通，前去采摘灵药回交本使！</t><b/>";
		case 10002:	return "<t>做的不错。</t><b/>";
		case 10005:	return "<t>采集灵药</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission20108Dialog(%Npc,%Player,%Mid,%Tid)		   //乔装采药·二
{
	switch (%Tid)
	{
		case 10001:	return "<t>灵泉之侧有灵药已到成熟之时，本使者考验下尔等变幻神通，前去采摘灵药回交本使！</t><b/>";
		case 10002:	return "<t>做的不错。</t><b/>";
		case 10005:	return "<t>完成五次采集灵药</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission20109Dialog(%Npc,%Player,%Mid,%Tid)		   //冰火之珠·一
{
	switch (%Tid)
	{
		case 10001:	return "<t>千年前掌门发现此地，观其阴阳交汇时有异宝现世，尔等可前往交汇之地碰碰仙缘，必有奇遇！</t><b/>";
		case 10002:	return "<t>做的不错。</t><b/>";
		case 10005:	return "<t>寻回异宝。</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission20110Dialog(%Npc,%Player,%Mid,%Tid)		   //冰火之珠·二
{
	switch (%Tid)
	{
		case 10001:	return "<t>千年前掌门发现此地，观其阴阳交汇时有异宝现世，尔等可前往交汇之地碰碰仙缘，必有奇遇！</t><b/>";
		case 10002:	return "<t>做的不错。</t><b/>";
		case 10005:	return "<t>寻回五件异宝。</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission20115Dialog(%Npc,%Player,%Mid,%Tid)		   //降妖除魔
{
	switch (%Tid)
	{
		case 10001:	return "<t>群妖暴动，异与以往，必有领头者，尔等为我昆仑天之骄子，现奉掌门法旨前去围剿</t><b/>";
		case 10002:	return "<t>做的不错。</t><b/>";
		case 10005:	return "<t>击败寒冰之魂*1</t><b/>"
			@ "<t>击败烈焰之魂*1</t><b/>"
			@ "<t>击败守护之魂*1</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}


function Mission20148dialog(%Npc,%Player,%Mid,%Tid)//诛妖
{
	%GeShi = 31203;
	switch (%Tid)
	{
		case 10001:	return "<t>按照唤妖铃的指引，找到并击败妖灵。</t><b/>";
		case 10002:	return "<t>我辈修士，当以斩妖除魔为己任，奈何本仙形单影只，力不从心，你可源助我一臂之力？</t><b/>" @ $Get_Dialog_GeShi[31403] @ "接取此任务需要扣除</t><t>[</t>" @ ChangeMoneyText(6000) @ "<t>]</t><b/>";
		case 10005:	return "<t>不错，这是你的酬劳。</t><b/>";
		case 910:
			%Player.ClearMissionItem(%Mid);
			%Player.AddItemToMission(%Mid,1,113090002,1);
			%Text = $Get_Dialog_GeShi[%GeShi] @ "	概率获得奖励：</t><b/>" @ GetFixedMissionItemText(%Mid) @ "<b/>";
			return %Text;
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}

function Mission20149dialog(%Npc,%Player,%Mid,%Tid)//师门尽忠
{
	%GeShi = 31203;
	%MidTarget = %player.getmissionflag(%Mid,10300);
	//echo( "%MidTarget===" @ %MidTarget );
	%Act4015[0] = GetAct(%player,4015,0);
	%Act4015[1] = GetAct(%player,4015,1);
	switch (%Tid)
	{
		case 10001:
			switch (%MidTarget)
			{
				case 410100003:	return "<t>向长老询问最近门派近况。</t><b/>"; ////对话NPC 	玄业
				case 410100004:	return "<t>向长老询问最近门派近况。</t><b/>"; ////对话NPC 	玄光
				case 410100005:	return "<t>向长老询问最近门派近况。</t><b/>"; ////对话NPC 	玄仁
				case 410100006:	return "<t>向师兄询问最近门派近况。</t><b/>"; ////对话NPC 	张平凡
				case 410100007:	return "<t>向师兄询问最近门派近况。</t><b/>"; ////对话NPC 	杨子石
				case 410100008:	return "<t>向师姐询问最近门派近况。</t><b/>"; ////对话NPC 	张德山
				case 410100009:	return "<t>向长老询问最近门派近况。</t><b/>"; ////对话NPC 	王君
				case 410100011:	return "<t>向守卫询问最近门派近况。</t><b/>"; ////对话NPC 	王知章
				case 410100032:	return "<t>向童子询问最近门派近况。</t><b/>"; ////对话NPC 	芳华
				case 410100031:	return "<t>向童子询问最近门派近况。</t><b/>"; ////对话NPC 	刹那
				case 108020994:	return "<t>采购掌门所需之物交给掌门。</t><b/>"; ////获得物品	百丈蚕丝
				case 108020995:	return "<t>采购掌门所需之物交给掌门。</t><b/>"; ////获得物品	灵兽卵
				case 108020996:	return "<t>采购掌门所需之物交给掌门。</t><b/>"; ////获得物品	补兽笼
				case 108020997:	return "<t>采购掌门所需之物交给掌门。</t><b/>"; ////获得物品	千年温玉
				case 108020998:	return "<t>采购掌门所需之物交给掌门。</t><b/>"; ////获得物品	铁木
				case 108020999:	return "<t>采购掌门所需之物交给掌门。</t><b/>"; ////获得物品	玄星石
				case 108021000:	return "<t>采购掌门所需之物交给掌门。</t><b/>"; ////获得物品	玄海冰魄
				case 108021002:	return "<t>且去装一瓶灵泉来给掌门养鱼儿。</t><b/>"; //获得物品	泠泷泉 108021001	空瓶子
				case 552000010:	return "<t>为掌门寻找炼器所需灵材。</t><b/>"; ////采集	伏灵草
				case 552000011:	return "<t>为掌门寻找炼器所需灵材。</t><b/>"; ////采集	灵枫木
				case 552000012:	return "<t>为掌门寻找炼器所需灵材。</t><b/>"; ////采集	紫兰花
				case 552000013:	return "<t>有几页卷宗随风飘走了，且去寻来。</t><b/>"; ////采集	卷宗
				case 552000014:	return "<t>为掌门寻找炼器所需灵材。</t><b/>"; ////采集	玄天露
				case 553000050:	return "<t>熟读蓬莱道经一次。</t><b/>"; ////采集	蓬莱道经
				case 410101020:	return "<t>剑斩肉身，心斩元神！</t><b/>"; ////挑战心魔	心魔
				case 410101002:	return "<t>青灵螺在蓬莱湾出没</t><b/>";
				case 410101004:	return "<t>螃蟹精在蓬莱湾出没</t><b/>";
				case 410101014:	return "<t>灵菇小妖在禁地出没</t><b/>";
				case 410101015:	return "<t>树妖在禁地出没</t><b/>";
				default:return "<t>掌门事物繁忙，可前去询问是否需要帮助，为门派贡献一份心力。</t><b/>";
			}
		case 10002:	return "<t>本座杂物甚多，你可愿为本座分担一些，为广大我蓬莱贡献一份力？</t><b/>";
		case 10005:	return "<t>不错，不错，辛苦你了。</t><b/>";
		case 910:
			%exp = 62;
			%Level = %Player.getlevel();
			if (%Level < 30) %levelxishu = 0.3;
			else if (%Level < 40) %levelxishu = 1;
			else if (%Level < 50) %levelxishu = 1.2;
			else if (%Level < 60) %levelxishu = 1.6;
			else if (%Level < 70) %levelxishu = 2;
			else %levelxishu = 2.2;
			//给予经验	EXP = （62+环数*8）*玩家等级对应经验 * 等级微调系数
			%exp = (%exp +  %Act4015[0] * 8) * $Monster_Exp[%Level,1] * %levelxishu;
			%Exp = mfloor(%Exp);
			%Exp = $Get_Dialog_GeShi[%GeShi] @ "	经验奖励：</t>" @ %exp @ "<b/>";
			if (%Act4015[0] == 10  && %Act4015[1] == 0)
			{
				%Player.ClearMissionItem(%Mid);
				%Player.AddItemToMission(%Mid,1,105109341,1);
				%Text = $Get_Dialog_GeShi[%GeShi] @ "	特殊奖励：</t><b/>" @ GetFixedMissionItemText(%Mid) @ "<b/>";
			}
			return %Exp @ %Text;
		case 400: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "询问近况 </t>";
		case 500:
			%ran = getrandom(1,3);
			switch (%ran)
			{
				case 1:%txt = "<t>杂事多啊，我都快累死了。</t>";
				case 2:%txt = "<t>你且回禀掌门，此处有我，尽管放心。</t>";
				case 3:%txt = "<t>外海妖魔又蠢蠢欲动了，多事之秋啊！</t>";
			}
			return %txt;

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}

function Mission20147Dialog(%Npc,%Player,%Mid,%Tid)//押镖
{
	%GeShi = 31203;
	switch (%Tid)
	{
		case 10001:	return "<t>把镖车押送到封魔城内，寻找总镖头交差。</t><b/>";
		case 10002:	return "<t>此去途中危险重重，阁下千万当心。</t><b/>";
		case 10005:	return "<t>不错，辛苦阁下了，来人呐，赏钱奉上。</t><b/>";
		case 910:
			%Act1 = GetAct(GetPlayer(),4018,1);
			%PinZhi1 = mfloor(%Act1/100);
			%DangCi1 = mfloor((%Act1 - %PinZhi1 * 100)/10);
			%IsBrok1 = %Act1%10;
			%State1 = $YaBiaoHuoDong_StateRecord[%PinZhi1,%DangCi1];
			if (%IsBrok1 == 1)
				%PlayerMoney = GetWord($YaBiaoHuoDong_Gold[%State1],3);
			else
				%PlayerMoney = GetWord($YaBiaoHuoDong_Gold[%State1],5);
			//echo( "%PlayerMoney==" @ %PlayerMoney );
			if (%PlayerMoney * 1 == 0)
				%Money = $Get_Dialog_GeShi[%GeShi] @ "	金钱奖励：最高可获得 </t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[600000055],3)) @ "<b/>";
			else
				%Money = $Get_Dialog_GeShi[%GeShi] @ "	金钱奖励：</t>" @ ChangeMoneyText(%PlayerMoney) @ "<b/>";
			//echo( "%Money==" @ %Money );
			%Player.ClearMissionItem(%Mid);
			if (%PinZhi1 != 0)
			{
				for (%i = 1; %i <= 99; %i++)
				{
					if ($YaBiaoHuoDong_Item[%PinZhi1,%i] $= "")
						break;
					%ItemID = GetWord($YaBiaoHuoDong_Item[%PinZhi1,%i],0);
					%Player.AddItemToMission(%Mid,1,%ItemID,1);
				}
				%Text = $Get_Dialog_GeShi[%GeShi] @ "	有几率获得以下物品：</t><b/>" @ GetFixedMissionItemText(%Mid) @ "<b/>";
			}
			else
			{
				for (%i = 1; %i <= 99; %i++)
				{
					if ($YaBiaoHuoDong_Item[5,%i] $= "")
						break;
					%ItemID = GetWord($YaBiaoHuoDong_Item[5,%i],0);
					%Player.AddItemToMission(%Mid,1,%ItemID,1);
				}
				%Text = $Get_Dialog_GeShi[%GeShi] @ "	有几率获得以下物品：</t><b/>" @ GetFixedMissionItemText(%Mid) @ "<b/>";
			}
			return %Money @ %Text;
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}

function Mission20028Dialog(%Npc,%Player,%Mid,%Tid)//秘咒除魔
{
	%GeShi = 31203;
	switch (%Tid)
	{
		case 10001:	return "<t>寻找妖魔，铲除之。</t><b/>";
		case 10002:	return "<t>妖魔肆虐神州，大势恶化，时不待我，城主大人特颁下凡是消灭妖魔头领者，可获得天材地宝提升修为！</t><b/>";
		case 10005:	return "<t>不错，辛苦阁下了。</t><b/>";
		case 910:
			%Level = %Player.GetLevel();
			if (%Level <= 45) %Exp= 60000;
			else if (%Level <= 60) %Exp= 99200;
			else if (%Level <= 75) %Exp= 154400;
			else if (%Level <= 90) %Exp= 230400;
			else if (%Level <= 100)%Exp= 331200;
			%Exp = $Get_Dialog_GeShi[%GeShi] @ "	经验奖励：</t>" @ %Exp @ "<b/>";
			%HuoYue = $Get_Dialog_GeShi[%GeShi] @ "	帮派活跃：</t>" @ 50 @ "<b/>";
			return %Exp @ %HuoYue;
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}

function Mission20029Dialog(%Npc,%Player,%Mid,%Tid){ Mission_20029_20035_Dialog(%Npc,%Player,%Mid,%Tid,1); }//斩妖除魔·一
function Mission20030Dialog(%Npc,%Player,%Mid,%Tid){ Mission_20029_20035_Dialog(%Npc,%Player,%Mid,%Tid,2); }//斩妖除魔·二
function Mission20031Dialog(%Npc,%Player,%Mid,%Tid){ Mission_20029_20035_Dialog(%Npc,%Player,%Mid,%Tid,3); }//斩妖除魔·三
function Mission20032Dialog(%Npc,%Player,%Mid,%Tid){ Mission_20029_20035_Dialog(%Npc,%Player,%Mid,%Tid,4); }//斩妖除魔·四
function Mission20033Dialog(%Npc,%Player,%Mid,%Tid){ Mission_20029_20035_Dialog(%Npc,%Player,%Mid,%Tid,5); }//斩妖除魔·五
function Mission20034Dialog(%Npc,%Player,%Mid,%Tid){ Mission_20029_20035_Dialog(%Npc,%Player,%Mid,%Tid,6); }//斩妖除魔·六
function Mission20035Dialog(%Npc,%Player,%Mid,%Tid){ Mission_20029_20035_Dialog(%Npc,%Player,%Mid,%Tid,7); }//斩妖除魔·七
function Mission_20029_20035_Dialog(%Npc,%Player,%Mid,%Tid,%MapNumber)
{
	%GeShi = 31203;
	switch (%Tid)
	{
		case 10001:	return "<t>前往地宫内，降妖除魔。</t><b/>";
		case 10002:	return "<t>地宫之内，封印有无穷妖孽，能除一只算一只，诛魔亦是修行！</t><b/>";
		case 10005:	return "<t>不错，辛苦阁下了。</t><b/>";
		case 910:
			%OneExp = $Monster_Exp[%Player.Getlevel(),1];
			//经验奖励 = 总杀怪数量 * 任务等级对应怪物经验 * 10%
			//echo( "%OneExp===" @ %OneExp );
			%FlagA = %Player.GetMissionFlag(%Mid,1200);
			%FlagB = %Player.GetMissionFlag(%Mid,1300);
			if (%FlagA >= %FlagB)
				%Exp = $Get_Dialog_GeShi[%GeShi] @ "	经验奖励：</t>" @ %OneExp * 10 @ "<t> + ???</t>" @ "<b/>";
			else
				%Exp = $Get_Dialog_GeShi[%GeShi] @ "	经验奖励：</t>" @ mfloor(%OneExp * %FlagB *  0.1) @ "<b/>";
			return %Exp;
	}

	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}

function Mission20150Dialog(%Npc,%Player,%Mid,%Tid)
{
	%GeShi = 31203;

	%Level = GetPlayer().GetLevel();


	switch (%Tid)
	{
		case 10001:	return "<t>前往指定的地图击败指定的怪物。</t><b/>";
		case 10002:
			if (%Level <= 44) %Itemname = "<l i='105109321 ' t='itemid'/>";
			else if (%Level <= 59) %Itemname = "<l i='105109322 ' t='itemid'/>";
			else if (%Level <= 74) %Itemname = "<l i='105109323 ' t='itemid'/>";
			else if (%Level <= 89) %Itemname = "<l i='105109324 ' t='itemid'/>";
			else  %Itemname = "<l i='105109325 ' t='itemid'/>";

			return "<t>只要给我10颗</t>" @ %Itemname @ "<t>，我将给予你一个试炼机会。</t><b/>";
		case 10005:	return "<t>不错，不错。</t><b/>";
		case 910:
			%OneExp = $Monster_Exp[%Player.Getlevel(),1];
			//经验奖励 = 总杀怪数量 * 任务等级对应怪物经验 * 10%
			%Exp = $Get_Dialog_GeShi[%GeShi] @ "	经验奖励：</t>" @ %OneExp * 1000 @ "<b/>";
			return %Exp;
	}

	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}

function Mission20146Dialog(%Npc,%Player,%Mid,%Tid)
{
	%GeShi = 31203;
	switch (%Tid)
	{
		case 10001:	return "<t>前往师门商店，为玲珑长老购买此物。</t><b/>";
		case 10002:
			return "<t>玲珑长老久居昆仑，需要些许师门物资，你且回到蓬莱，为长老采购一番。</t><b/>";
		case 10005:	return "<t>你是如何得知我需此物的？（我明明只写在漂流瓶里……）</t><b/>";
		case 910:
			%Level = %Player.GetLevel();
			%OneExp = $Monster_Exp[%Level,1];
			if (%Level < 40) %LevelXiShu = 1;
			else if (%Level < 50) %LevelXiShu = 1.2;
			else if (%Level < 60) %LevelXiShu = 1.6;
			else if (%Level < 70) %LevelXiShu = 2;
			else %LevelXiShu = 2.2;
			%Exp =  mfloor(%OneExp * 80 * %LevelXiShu);

			%Exp = $Get_Dialog_GeShi[%GeShi] @ "	经验奖励：</t>" @ %Exp @ "<b/>";
			return %Exp;
	}

	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}

function Mission20151Dialog(%Npc, %Player, %Mid, %Tid)//收集灵魄
{
	%GeShi = 31203;
	switch (%Tid)
	{
		case 10001:	return "<t>斩妖除魔，收集妖魔灵魄。</t><b/><t>怪物等级不可低于自身等级10级。</t><b/>";
		case 10002:	return "<t>妖魔肆虐，凡我修士，人人皆要以除魔为己任！</t><b/>";
		case 10005:	return "<t>不错，辛苦阁下了。</t><b/>";
		case 910:
			%Level = %Player.GetLevel();
			if (%Level <= 45) %Exp= 60000;
			else if (%Level <= 60) %Exp= 99200;
			else if (%Level <= 75) %Exp= 154400;
			else if (%Level <= 90) %Exp= 230400;
			else if (%Level <= 100)%Exp= 331200;
			%Exp = $Get_Dialog_GeShi[%GeShi] @ "	经验奖励：</t>" @ %Exp @ "<b/>";
			%HuoYue = $Get_Dialog_GeShi[%GeShi] @ "	帮派活跃：</t>" @ 50 @ "<b/>";
			return %Exp @ %HuoYue;
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}

function Mission20036Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 1); }//英雄贴·一
function Mission20037Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 3); }//英雄贴·二
function Mission20038Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 5); }//英雄贴·三
function Mission20039Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 7); }//英雄贴·四
function Mission20040Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//英雄贴·五
function Mission20041Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//英雄贴·六
function Mission20042Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//英雄贴·七
function Mission20043Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 1); }//英雄贴·一
function Mission20044Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 3); }//英雄贴·二
function Mission20045Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 5); }//英雄贴·三
function Mission20046Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 7); }//英雄贴·四
function Mission20047Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//英雄贴·五
function Mission20048Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//英雄贴·六
function Mission20049Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//英雄贴·七
function Mission20050Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 1); }//英雄贴·一
function Mission20051Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 3); }//英雄贴·二
function Mission20052Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 5); }//英雄贴·三
function Mission20053Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 7); }//英雄贴·四
function Mission20054Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//英雄贴·五
function Mission20055Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//英雄贴·六
function Mission20056Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//英雄贴·七
function Mission20057Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 1); }//英雄贴·一
function Mission20058Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 3); }//英雄贴·二
function Mission20059Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 5); }//英雄贴·三
function Mission20060Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 7); }//英雄贴·四
function Mission20061Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//英雄贴·五
function Mission20062Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//英雄贴·六
function Mission20063Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//英雄贴·七
function Mission20064Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 1); }//英雄贴·一
function Mission20065Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 3); }//英雄贴·二
function Mission20066Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 5); }//英雄贴·三
function Mission20067Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 7); }//英雄贴·四
function Mission20068Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//英雄贴·五
function Mission20069Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//英雄贴·六
function Mission20070Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//英雄贴·七
function MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid,%ExpXiShu)
{
	%GeShi = 31203;
	switch (%Tid)
	{
		case 10001:	return "<t>斩妖除魔，匡扶正道，可增加自身在修士界的威望。</t><b/>";
		case 10002:	return "<t>妖魔肆虐，凡我修士，人人皆要以除魔为己任！</t><b/>";
		case 10005:	return "<t>不错，辛苦阁下了。</t><b/>";
		case 910:
			%Level = %Player.GetLevel();
			%OneExp = $Monster_Exp[%Level, 1];

			if (%Level < 40) %LevelXiShu = 1;
			else if (%Level < 50) %LevelXiShu = 1.2;
			else if (%Level < 60) %LevelXiShu = 1.6;
			else if (%Level < 70) %LevelXiShu = 2;
			else %LevelXiShu = 2.2;
			%Exp =  %OneExp * 500 * %LevelXiShu * %ExpXiShu;

			%Exp = $Get_Dialog_GeShi[%GeShi] @ "	经验奖励：</t>" @ %Exp @ "<b/>";
			return %Exp ;
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}

function Mission20146Dialog(%Npc, %Player, %Mid, %Tid)
{
	%GeShi = 31203;
	switch (%Tid)
	{
		case 10001:	return "<t>前往师门商店，为玲珑长老购买此物。</t><b/>";
		case 10002:
			return "<t>玲珑长老久居昆仑，需要些许师门物资，你且回到蓬莱，为长老采购一番。</t><b/>";
		case 10005:	return "<t>你是如何得知我需此物的？（我明明只写在漂流瓶里……）</t><b/>";
		case 910:
			%Level = %Player.GetLevel();
			%OneExp = $Monster_Exp[%Level, 1];
			if (%Level < 40) %LevelXiShu = 1;
			else if (%Level < 50) %LevelXiShu = 1.2;
			else if (%Level < 60) %LevelXiShu = 1.6;
			else if (%Level < 70) %LevelXiShu = 2;
			else %LevelXiShu = 2.2;
			%Exp =  mfloor(%OneExp * 80 * %LevelXiShu);

			%Exp = $Get_Dialog_GeShi[%GeShi] @ "	经验奖励：</t>" @ %Exp @ "<b/>";
			return %Exp;
	}

	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}