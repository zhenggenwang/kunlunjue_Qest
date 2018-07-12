//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//从SL_C_Mission_UI.cs文件接过来
//
//客户端任务相关界面旗标分类控制
//==================================================================================
//■■■■■■■■■■获取任务交接NPC的编号■■■■■■■■■■■■■■■■■
//■■■■■■■■■■获取任务类头描述总接口■■■■■■■■■■■■■■■■■
//■■■■■■■■■■获取任务描述【永久】类头说明■■■■■■■■■■■■■■
//■■■■■■■■■■获取任务描述【暂时】类头说明■■■■■■■■■■■■■■
//■■■■■■■■■■更新地图与NPC头顶标记■■■■■■■■■■■■■■■■■
//■■■■■■■■■■【通用】获取任务归属地图■■■■■■■■■■■■■■■■

//■■■■■■■■■■获取任务交接NPC的编号■■■■■■■■■■■■■■■■■
//－－－获取NpcA－－－
function GetNpcA(%Mid)
{
	%Player = GetPlayer();
	%NpcID = 0;
	switch (%Mid)
	{
		case 20147:%NpcID = -1;//押镖
		case 20149:%NpcID = 410100001;//师门任务
		case 20001:%NpcID = 411200002;//寒冰之魂
		case 20002:%NpcID = 411200003;//烈火之炎
		case 20003:%NpcID = 411200002;//铲除冰蜥
		case 20004:%NpcID = 411200003;//铲除火蜥
		case 20005:%NpcID = 411200001;//乔装采药
		case 20006:%NpcID = 411200001;//冰火之珠·一
		case 20007:%NpcID = 411200001;//冰火之珠·二
		case 20008:%NpcID = 411200001;//降妖除魔
		case 20009:%NpcID = 411210002;//寒冰之魂
		case 20010:%NpcID = 411210003;//烈火之炎
		case 20011:%NpcID = 411210002;//铲除冰蜥
		case 20012:%NpcID = 411210003;//铲除火蜥
		case 20013:%NpcID = 411210001;//乔装采药
		case 20014:%NpcID = 411210001;//冰火之珠·一
		case 20015:%NpcID = 411210001;//冰火之珠·二
		case 20016:%NpcID = 411210001;//降妖除魔
		case 20017:%NpcID = 411220002;//寒冰之魂
		case 20018:%NpcID = 411220003;//烈火之炎
		case 20019:%NpcID = 411220002;//铲除冰蜥
		case 20020:%NpcID = 411220003;//铲除火蜥
		case 20021:%NpcID = 411220001;//乔装采药
		case 20022:%NpcID = 411220001;//冰火之珠·一
		case 20023:%NpcID = 411220001;//冰火之珠·二
		case 20024:%NpcID = 411220001;//降妖除魔
		default:
			%NpcID = GetMissionData(%Mid,$Mission_Data_NpcA);
	}
	return %NpcID;
}
//－－－获取NpcZ－－－
function GetNpcZ(%Mid)
{
	//echo( "into GetNPCz" );
	%Player = GetPlayer();
	%NpcID = 0;
	switch (%Mid)
	{
		case 0: %NpcID = 0;
		default:
			%NpcID = GetMissionData(%Mid,$Mission_Data_NpcZ);
	}
	return %NpcID;
}
//■■■■■■■■■■获取任务交接NPC的编号■■■■■■■■■■■■■■■■■


//■■■■■■■■■■获取任务类头描述总接口■■■■■■■■■■■■■■■■■
function  GetMission_LeiTou_Text(%Mid,%type,%Num)
{
	//echo( "%type===" @ %type );
	switch$(%Type)
	{
		case "Npc":
			switch (%mid)
			{
				case 10161: %Text = "学习：";
				case 10151: %Text = "完成：";
				case 10291: %Text = "探查：";
				case 10221: %Text = "使用：";
				case 10231: %Text = "学习：";
				case 10241: %Text = "前往：";
				case 10761: %Text = "完成：";
				case 10781: %Text = "完成：";
				case 10801: %Text = "完成：";
				case 11232: %Text = "前往：";
				case 20207: %Text = "完成：";
				case 10931: %Text = "探查：";
				case 10951: %Text = "前往：";
				case 11021: %Text = "前往：";
				case 11041: %Text = "前往：";
				case 30101: %Text = "戴上：";
				case 30111: %Text = "戴上：";
				case 30121: %Text = "戴上：";
				case 30131: %Text = "戴上：";
				default: %Text = "对话：";
			}
			return $Get_Dialog_GeShi[31201] @ " ·" @  %Text @ "</t>";
		case "MonsterKill":
			switch (%mid)
			{

				case 20001:%Text = "采集：";//寒冰之魂
				case 20002:%Text = "采集：";//烈火之炎
				case 20003:%Text = "击败：";//铲除蟾妖
				case 20004:%Text = "击败：";//铲除妖蟒
				case 20005:%Text = "采集：";//乔装采药
				case 20006:%Text = "采集：";//冰火之珠·一
				case 20007:%Text = "完成：";//冰火之珠·二
				case 20008:%Text = "击败：";//降妖除魔
				case 20009:%Text = "采集：";//寒冰之魂
				case 20010:%Text = "采集：";//烈火之炎
				case 20011:%Text = "击败：";//铲除蟾妖
				case 20012:%Text = "击败：";//铲除妖蟒
				case 20013:%Text = "采集：";//乔装采药
				case 20014:%Text = "采集：";//冰火之珠·一
				case 20015:%Text = "完成：";//冰火之珠·二
				case 20016:%Text = "击败：";//降妖除魔
				case 20017:%Text = "采集：";//寒冰之魂
				case 20018:%Text = "采集：";//烈火之炎
				case 20019:%Text = "击败：";//铲除蟾妖
				case 20020:%Text = "击败：";//铲除妖蟒
				case 20021:%Text = "采集：";//乔装采药
				case 20022:%Text = "采集：";//冰火之珠·一
				case 20023:%Text = "完成：";//冰火之珠·二
				case 20024:%Text = "击败：";//降妖除魔
					
				default: %Text = "击败：";
			}
			return $Get_Dialog_GeShi[31201] @ " ·" @  %Text @ "</t>";
		case "ItemAdd":
			return $Get_Dialog_GeShi[31201] @ " ·物品：" @ "</t>";
		case "ItemGet":
			switch (%mid)
			{
				case 10021: %Text = "采集：";
				case 10101: %Text = "采集：";
				case 10131: %Text = "采集：";
				case 20107: %Text = "寻回一株灵药：";
				default: %Text = "物品：";
			}
			return $Get_Dialog_GeShi[31201] @ " ·" @  %Text @ "</t>";
		case "Target":
			switch (%Mid)
			{
				case 10017:%Text = "完成：";
				
				case 20107:%Text = "采集一株灵药：";
				case 20108:%Text = "采集5株灵药：";
				case 20109:%Text = "寻回一颗神石:";
				case 20110:%Text =  "寻到5颗神石:";
				case 20115:%Text =  "围剿妖王:";

				case 20029:%Text =  "击败:";
				case 20030:%Text =  "击败:";
				case 20031:%Text =  "击败:";
				case 20032:%Text =  "击败:";
				case 20033:%Text =  "击败:";
				case 20034:%Text =  "击败:";
				case 20035:%Text =  "击败:";

				case 20151:%Text =  "击败:";
				
				case 29999:%Text = "杀死怪物：";
				default:%Text = "使用：";
			}
			return $Get_Dialog_GeShi[31201] @ " ·" @  %Text @ "</t>";
		case "Step":
			return $Get_Dialog_GeShi[31201] @ " ·未知：" @ "</t>";
		case "Collect":
			switch (%Mid)
			{

				case 10221:%Text = "参悟：";
				case 10032:%Text = "诵读：";
				case 10111:%Text = "使用符笔画符";
				default:%Text = "采集：";
			}
			return $Get_Dialog_GeShi[31201] @ " ·" @  %Text @ "</t>";	//采集
		case "forever":
			return Mission_Frontforever(GetPlayer(),%Mid,%Num);	//描述【永久】
		case "Test":
			return Mission_FrontTest(GetPlayer(),%Mid,%Num);		//描述【暂时】
	}

}
//■■■■■■■■■■获取任务类头描述总接口■■■■■■■■■■■■■■■■■

//■■■■■■■■■■获取任务描述【永久】类头说明■■■■■■■■■■■■■■■■■
function Mission_Frontforever(%Player,%Mid,%Num)
{
	%ziti = $Get_Dialog_GeShi[31201];//默认字体
	//echo( "%Mid===" @ %Mid @ "   %Num===" @ %Num );
	switch (%Mid)
	{
		case 10018:%MidText = "<t>跟随</t>"@ Getfindpath(GetMissionData(%Mid,$Mission_Data_NpcA),%Mid,0,31214) @ "<t>进入禁地</t>";
		case 20103:%MidText = "<t>去极寒之地取来寒冰之霜</t>";
		case 20104:%MidText = "<t>去极炎之地取来烈火之炎</t>";
		case 20105:%MidText = "<t>击败极寒之地的寒冰蟾</t>";
		case 20106:%MidText = "<t>击败极炎之地的烈焰蟒</t>";
		case 20107:%MidText = "<t>前去采摘灵药回交试炼使者！</t>";
		case 20108:%MidText = "<t>前去采摘灵药回交试炼使者！</t>";
		case 20109:%MidText = "<t>前去采摘灵药回交试炼使者！</t>";
		case 20110:%MidText = "<t>前去采摘灵药回交试炼使者！</t>";
		case 20111:%MidText = "<t>前去采摘灵药回交试炼使者！</t>";
		case 20112:%MidText = "<t>做的不错，本座有赏！</t>";
		case 20113:%MidText = "<t>前往阴阳交汇之地搜寻异宝！</t>";
		case 20114:%MidText = "<t>做的不错，本座有赏！</t>";
		case 20115:%MidText = "<t>奉法旨前去围剿群妖领头者</t>";
		case 20001:%MidText = "<t>去极寒之地取来寒冰之霜</t>";//寒冰之魂
		case 20002:%MidText = "<t>去极炎之地取来烈火之炎</t>";//烈火之炎
		case 20005://乔装采药
			%NowNum = 44;
			for (%i = 44; %i <=48; %i++)
			{
				if (GetSrc(%Player,%i) == 1)
					%NowNum = %i;
			}
			%MidText = "<t>当前已完成 </t>" @ $Get_Dialog_GeShi[31201] @ %NowNum - 43 @ "</t><t>/5 次</t>";
		case 20006:%MidText = "<t>获取奇石、灵石、神石中的任意一种</t>";//冰火之珠·一
		case 20009:%MidText = "<t>去极寒之地取来寒冰之霜</t>";//寒冰之魂
		case 20010:%MidText = "<t>去极炎之地取来烈火之炎</t>";//烈火之炎
		case 20013://乔装采药
			%NowNum = 44;
			for (%i = 44; %i <=48; %i++)
			{
				if (GetSrc(%Player,%i) == 1)
					%NowNum = %i;
			}
			%MidText = "<t>当前已完成 </t>" @ $Get_Dialog_GeShi[31201] @ %NowNum - 43 @ "</t><t>/5 次</t>";
		case 20014:%MidText = "<t>获取奇石、灵石、神石中的任意一种</t>";//冰火之珠·一
		case 20017:%MidText = "<t>去极寒之地取来寒冰之霜</t>";//寒冰之魂
		case 20018:%MidText = "<t>去极炎之地取来烈火之炎</t>";//烈火之炎
		case 20021://乔装采药
			%NowNum = 44;
			for (%i = 44; %i <=48; %i++)
			{
				if (GetSrc(%Player,%i) == 1)
					%NowNum = %i;
			}
			%MidText = "<t>当前已完成 </t>" @ $Get_Dialog_GeShi[31201] @ %NowNum - 43 @ "</t><t>/5 次</t>";
		case 20022:%MidText = "<t>获取奇石、灵石、神石中的任意一种</t>";//冰火之珠·一
		case 20025:%MidText = "<t>获取越多材料提交任务时奖励越丰厚</t>";
		case 20026:%MidText = "<t>获取越多材料提交任务时奖励越丰厚</t>";
		case 20027:%MidText = "<t>获取越多材料提交任务时奖励越丰厚</t>";
		case 20147:

			%Act4018[0] = GetAct(%player,4018,0) * 1;
			//echo( "%Act4018[ 0 ]==" @ %Act4018[ 0 ] );
			%MidText = "<t>当前已接取 </t>" @ $Get_Dialog_GeShi[31201] @ %Act4018[0] @ "</t><t>/</t>" @ VIP_getNowTequanLvMaxCnt(%Player, 7) @ "</t> 次</t>";
		case 20149:
			switch (%num)
			{
				case 0:
					%Act4015[0] = GetAct(%player,4015,0) * 1;
					%Act4015[1] = GetAct(%player,4015,1) * 1;
					%MidText = "<t>当前已接 </t>" @ $Get_Dialog_GeShi[31201] @ %Act4015[0] @ "</t><t>/10 次</t>";
				case 1:
					%MidTarget = %player.getmissionflag(%Mid,10300);
					switch (%MidTarget)
					{
						case 410100003:%MidText = "<t>向长老询问最近门派近况。</t><b/>"; ////对话NPC 	玄业
						case 410100004:%MidText = "<t>向长老询问最近门派近况。</t><b/>"; ////对话NPC 	玄光
						case 410100005:%MidText = "<t>向长老询问最近门派近况。</t><b/>"; ////对话NPC 	玄仁
						case 410100006:%MidText = "<t>向师兄询问最近门派近况。</t><b/>"; ////对话NPC 	张平凡
						case 410100007:%MidText = "<t>向师兄询问最近门派近况。</t><b/>"; ////对话NPC 	杨子石
						case 410100008:%MidText = "<t>向师姐询问最近门派近况。</t><b/>"; ////对话NPC 	张德山
						case 410100009:%MidText = "<t>向长老询问最近门派近况。</t><b/>"; ////对话NPC 	王君
						case 410100011:%MidText = "<t>向守卫询问最近门派近况。</t><b/>"; ////对话NPC 	王知章
						case 410100032:%MidText = "<t>向童子询问最近门派近况。</t><b/>"; ////对话NPC 	芳华
						case 410100031:%MidText = "<t>向童子询问最近门派近况。</t><b/>"; ////对话NPC 	刹那
						case 108020994:%MidText = "<t>前往『</t>" @ Getfindpath(410100009,0,0,31214) @ "<t>』购买</t>";
						case 108020995:%MidText = "<t>前往『</t>" @ Getfindpath(410100009,0,0,31214) @ "<t>』购买</t>";
						case 108020996:%MidText = "<t>前往『</t>" @ Getfindpath(410100009,0,0,31214) @ "<t>』购买</t>";
						case 108020997:%MidText = "<t>前往『</t>" @ Getfindpath(410100009,0,0,31214) @ "<t>』购买</t>";
						case 108020998:%MidText = "<t>前往『</t>" @ Getfindpath(410100009,0,0,31214) @ "<t>』购买</t>";
						case 108020999:%MidText = "<t>前往『</t>" @ Getfindpath(410100009,0,0,31214) @ "<t>』购买</t>";
						case 108021000:%MidText = "<t>前往『</t>" @ Getfindpath(410100009,0,0,31214) @ "<t>』购买</t>";
						case 108021002:%MidText = "<t>在</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(108021002);\",\"" @ $Get_Dialog_GeShi[31414] @ "荷花池</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>使用</t>" @ "<l i='" @ 108021001 @ "' t='itemid'/>";
						case 552000010:	%MidText = "<t>替掌门搜集灵材</t>";
						case 552000011:	%MidText = "<t>替掌门搜集灵材</t>";
						case 552000012:	%MidText = "<t>替掌门搜集灵材</t>";
						case 552000013:	%MidText = "<t>替掌门搜集灵材</t>";
						case 552000014:	%MidText = "<t>替掌门搜集灵材</t>";
						case 553000050:	%MidText = "<t>读万卷书，行万里路</t>";
						case 410101020:	%MidText = "<t>寻找『</t>" @ Getfindpath(410100006,0,0,31214) @ "<t>』开启心魔幻境</t>";//心魔
						case 410101002:	%MidText = "<t>前往『蓬莱湾』铲除妖魔</t>";//花妖
						case 410101004:	%MidText = "<t>前往『蓬莱湾』铲除妖魔</t>";//狼妖护卫
						case 410101014:	%MidText = "<t>前往『禁地』铲除妖魔</t>";//狂化的狼妖
						case 410101015:	%MidText = "<t>前往『禁地』铲除妖魔</t>";//疯狂的野猪
					}
			}
		case 20150:
			%Act4098[0] = GetAct(%player,4098,0) * 1;
			%MidText = "<t>今日已接 </t>" @ $Get_Dialog_GeShi[31201] @ %Act4098[0] @ "</t><t>/10 次</t>";
		
		
		
		case 29999: %MidText = "<t>击杀任意怪物</t>";
		default:
			%MidText = "文字描述[永久]";
	}
	
	return %ziti @ "<t> ·</t>" @ %MidText @ "</t>";
}
//■■■■■■■■■■获取任务描述【永久】类头说明■■■■■■■■■■■■■■■■■

//■■■■■■■■■■获取任务描述【暂时】类头说明■■■■■■■■■■■■■■■■■
function Mission_FrontTest(%Player,%Mid,%Num)
{
	//echo( "%Player==" @ %player @ "  %Mid===" @ %mid @ "  %Num===" @ %num );
	%ziti = $Get_Dialog_GeShi[31201];//默认字体
	%ziti = "<t f='宋体' m='1' v='1' n='12' h='0'c='0xffffffff' o='0x010101ff'>";
	switch (%Mid)
	{
		case 20148:
			switch (%num)
			{
				case 0:
					%Act4012[0] = GetAct(%Player,4012,0);
					%MidText = "<t>今天已完成次数：</t>" @ $Get_Dialog_GeShi[31201] @ %Act4012[0] @ "</t><t>/10</t>";
				case 1:
					%MidText = "<t>妖灵出现位置：</t>" @ "<l i='" @ "8" @ getact(getplayer(),4013,0) @ "0100 " @ $strMapRanPosRecord[getact(getplayer(),4013,0),getact(getplayer(),4013,1)] @ "' t='path'/>";
					//echo( "8" @ getact( getplayer( ), 4013, 0 ) @ "0100 " @ $strMapRanPosRecord[ getact( getplayer( ), 4013, 0 ), getact( getplayer( ), 4013, 1 ) ] );
				case 2:
					%MidText = "<t>到达后使用唤妖铃</t>";
					return  "<t f='宋体' m='1' v='1' n='14' h='0'c='0xffffffff' o='0x010101ff'></t>" @ %ziti @ "<t> ·</t>" @ %MidText @ "</t>";
			}
		case 10021:	%MidText = "<t>左键点击海蚌采集</t>";
		case 10061:	%MidText = "<t>击败螃蟹精获得螃蟹</t>";
		case 10141:	%MidText = "<t>左键点击蚕蛹采集</t>";
		case 10091:	%MidText = "<t>左键点击龙延草采集</t>";
		case 10121:	%MidText = "<t>打开包裹点击技能书学习</t>";
		case 10221:	%MidText = "<t>点击蓬莱道经参悟，获得道果</t>";
		case 10461:	%MidText = "<t>击败枯树老妖获得柴火</t>";
		case 10481: %MidText = "<t>装备鱼杆即可钓鱼</t>";
		case 10801: %MidText = "<t>完成任意3次冰火试炼内的任务</t>";
		case 20207: %MidText = "<t>完成3次师门尽忠任务</t>";
		case 20201:	%MidText = "<t>白纸可在杂货商店购买</t>";
		case 20205:	%MidText = "<t>前往望仙谷寻找云游隐士</t>";
		case 20203:	%MidText = "<t>捣毁鼠窝寻找玲珑珠</t>";
		case 20204:	%MidText = "<t>击败树妖获得树心</t>";
		case 30202:	%MidText = "<t>挖矿获得铜矿，其他在铸造商店购买</t>";
		case 30302:	%MidText = "<t>打怪掉落粗麻，其他在裁缝商店购买</t>";
		case 30402:	%MidText = "<t>伐木获得柳木，砂纸在制器商店购买</t>";
		case 30502:	%MidText = "<t>采药获得紫草，药品在炼丹商店购买</t>";
		case 30602:	%MidText = "<t>伐木获得柳木，砂纸在制器商店购买</t>";
		case 30702:	%MidText = "<t>打怪掉落薄荷，调料在烹饪商店购买</t>";
	}
	return %ziti @ "<t> ·</t>" @ %MidText @ "</t>";
}
//■■■■■■■■■■获取任务描述【暂时】类头说明■■■■■■■■■■■■■■■■■



//■■■■■■■■■■更新地图与NPC头顶标记■■■■■■■■■■■■■■■■■
function UpdateMissionEffect(%Player,%Mid,%Index)
{
	putout("更新地图与NPC头顶标记   %Player  " @ %Player @ "  %Mid   " @   %Mid @  "   %Index    " @ %Index);
	if (%Player == 0)
		return;
	//刷新后续任务
	if (%Index == 2)
	{
		delTrackMissionEx(%Mid);	//删除指定任务的地图标记
		delNpcTopMissionIcon(%Mid);	//删除指定任务的Npc标记

		%NextMission = GetNextMission(%Mid);
		%Type = GetMissionData(%Mid,$Mission_Data_Type);

		if (%NextMission !$= "")
		{
			%MidNum = GetWordCount(%NextMission);

			for (%i = 0; %i < %MidNum; %i++)
				UpdateMissionEffect(%Player,GetWord(%NextMission,%i),1);
		}

		//刷新自身标记
		if ((%Type == 3) || (%Type == 9))
			UpdateMissionEffect(%Player,%Mid,1);

		return;
	}

	if (%Mid > 0)
	{
		//更新单个任务
		%Mission_Name = GetMissionData(%Mid,$Mission_Data_Name);

		delTrackMissionEx(%Mid);	//删除指定任务的地图标记
		delNpcTopMissionIcon(%Mid);	//删除指定任务的Npc标记

		//判断是已接还是可接
		if (%Player.IsAcceptedMission(%Mid))
		{
			%NpcZ = GetNpcZ(%Mid);
			%Family = %Player.GetFamily();

			if (CanDoThisMission(%Player,%Mid,2,0,0) $= "")	//是否已经可交付
			{
				if (%NpcZ > 0)
				{
					insertTrackMissionEx(%Mid,"任务：【" @ %Mission_Name @ "】",%NpcZ,1);	//添加地图标记
					insertNpcTopMissionIcon(%Mid,%NpcZ,1);	//添加Npc标记，可交问号
				}
			}
			else
			{
				//Npc头顶标记
				if (%NpcZ > 0)
					insertNpcTopMissionIcon(%Mid,%NpcZ,5);	//添加Npc标记，不可交问号

				//任务怪物击败数量是否足够
				for (%i = 0; %i < 9; %i++)
				{
					%Monster = %Player.GetMissionFlag(%Mid,3100 + %i);
					%KillNum = %Player.GetMissionFlag(%Mid,3200 + %i);

					if (%Monster == 0)
						break;

					if (%Player.GetMissionFlag(%Mid,3300 + %i) < %Player.GetMissionFlag(%Mid,3200 + %i))
						insertTrackMissionEx(%Mid,"任务：【" @ %Mission_Name @ "】",%Monster,8);
				}

				//任务中途的对话目标数量是否足够
				for (%i = 0; %i < 9; %i++)
				{
					%NpcX    = %Player.GetMissionFlag(%Mid,1150 + %i);
					%NpcXNum = %Player.GetMissionFlag(%Mid,1250 + %i);

					if (%NpcX == 0)
						break;

					if ((%NpcX > 0)&&(%Player.GetMissionFlag(%Mid,1350 + %i) < %NpcXNum))
					{
						insertTrackMissionEx(%Mid,"任务：【" @ %Mission_Name @ "】",%NpcX,9);
						insertNpcTopMissionIcon(%Mid,%NpcX,9);	//添加Npc标记，中途对话标记
					}
				}

				//特殊旗标的旗标名如果是NPC编号时，在此NPC头顶添加可对话标记
				for (%i = 0; %i < 9; %i++)
				{
					%NpcX    = %Player.GetMissionFlag(%Mid,1100 + %i);
					%NpcXNum = %Player.GetMissionFlag(%Mid,1200 + %i);

					if (%NpcX == 0)
						break;

					if (GetSubStr(%NpcX,0,1) $= "4") //首位是 4 表示此ID是NPC编号
					{
						if (%Player.GetMissionFlag(%Mid,1300 + %i) < %NpcXNum)
						{
							insertTrackMissionEx(%Mid,"任务：【" @ %Mission_Name @ "】",%NpcX,9);
							insertNpcTopMissionIcon(%Mid,%NpcX,9);	//添加Npc标记，中途对话标记
						}
					}
				}

				//任务获取道具是否足够
				for (%i = 0; %i < 9; %i++)
				{
					%ItemGet = %Player.GetMissionFlag(%Mid,2100 + %i);
					%GetNum  = %Player.GetMissionFlag(%Mid,2200 + %i);

					if (%ItemGet == 0)
						break;

					if (%Player.GetMissionFlag(%Mid,2300 + %i) < %Player.GetMissionFlag(%Mid,2200 + %i))
						if ($Item_Monster[%ItemGet] !$= "")
							insertTrackMissionEx(%Mid,"任务：【" @ %Mission_Name @ "】",$Item_Monster[%ItemGet],7);
				}

				//任务使用道具触发目标数量是否足够
				for (%i = 0; %i < 9; %i++)
				{
					%Target = %Player.GetMissionFlag(%Mid,1100 + %i);
					%TarNum = %Player.GetMissionFlag(%Mid,1200 + %i);

					if (%Target == 0)
						break;

					if (%Player.GetMissionFlag(%Mid,1300 + %i) < %TarNum)
						if ($Item_Monster[%ItemGet] !$= "")
							insertTrackMissionEx(%Mid,"任务：【" @ %Mission_Name @ "】",$Item_Monster[%ItemGet],7);
				}

				//任务采集触发目标数量是否足够
				for (%i = 0; %i < 9; %i++)
				{
					%CollectGet = %Player.GetMissionFlag(%Mid,2130 + %i);
					%CollectNum = %Player.GetMissionFlag(%Mid,2230 + %i);

					if (%CollectGet == 0)
						break;

					if (%Player.GetMissionFlag(%Mid,2330 + %i) < %CollectNum)
						insertTrackMissionEx(%Mid,"任务：【" @ %Mission_Name @ "】",%CollectGet,7);
				}
			}
		}
		else
		{
			%NpcA = GetNpcA(%Mid);
			if (%NpcA > 0)
			{
				%Type = 0;
				//echo( "CanDoThisMission( %Player, %Mid, 1, 0, 0 ) ===" @ CanDoThisMission( %Player, %Mid, 1, 0, 0 ) );
				if (!Mission_Begin_SeeOption(%Player, %Mid))//是否显示(特殊判断)
				{
					if (CanDoThisMission(%Player, %Mid, 1, 0, 0) $= "")	//是否已经可接
					{
						switch (GetMissionData(%Mid, $Mission_Data_Type))
						{
							case 0:	%Type = 3;	//"〖圣地任务〗"//支线任务接受图标
							case 1:	%Type = 2;	//"〖章回任务〗"//主线任务接受图标
							case 2:	%Type = 3;	//"〖支线剧情〗"//支线任务接受图标
							case 3: %Type = 4;	//"〖每日循环〗"//循环任务接受图标
							case 4:	%Type = 3;	//"〖帮派任务〗"//支线任务接受图标
							case 5:	%Type = 3;	//"〖指引任务〗"//支线任务接受图标
							case 6: %Type = 3;	//"〖活动任务〗"//支线任务接受图标
							case 7:	%Type = 3;	//"〖其它任务〗"//支线任务接受图标
							case 9:	%Type = 3;	//"〖战场任务〗"//支线任务接受图标
							default: %Type = 3;	//支线任务接受图标
						}
					}
					//是否已经可接，用可视等级来判断
					if ((%Type == 0) && (CanDoThisMission(%Player, %Mid, 1, 2, 0) $= ""))
						%Type = 6;//红色叹号
				}
				if (%Type > 0)
				{
					insertTrackMissionEx(%Mid,"任务：【" @ %Mission_Name @ "】",%NpcA,%Type);	//添加地图标记
					insertNpcTopMissionIcon(%Mid,%NpcA,%Type);	//添加Npc标记，可接叹号
				}
			}
		}
	}
	else
	{
		//先来已接的
		%AcceptCount = %Player.GetAcceptedMission();	// 任务已接数量

		//遍历玩家所有已接任务，添加相应标记
		if (%AcceptCount > 0)
			for (%i = 0; %i < %AcceptCount; %i++)
			{
				if (%Player.GetMission(%i) > 0)
					UpdateMissionEffect(%Player,%Player.GetMission(%i),1);
			}

		//再来可接的
		%Playerleve = %Player.GetLevel();
		%Midleve = GetCanSeeMission(%Playerleve);
		%MidNum = GetWordCount(%Midleve);

		//循环所有可视等级的可接任务，添加标记
		if (%MidNum !$= "")
			for (%i = 0; %i < %MidNum; %i++)
			{
				%Mid = GetWord(%Midleve,%i);

				if (CanDoThisMission(%Player,%Mid,1,0,0) $= "")	//是否显示(常规判断)
				{
					delTrackMissionEx(%Mid);	//删除指定任务的地图标记
					delNpcTopMissionIcon(%Mid);	//删除指定任务的Npc标记

					UpdateMissionEffect(%Player,%Mid,1);
				}
			}
	}
}
//■■■■■■■■■■更新地图与NPC头顶标记■■■■■■■■■■■■■■■■■
//■■■■■■■■■■【通用】获取任务归属地图■■■■■■■■■■■■■■■■
function GetMissionMap(%Player,%Mid,%Back)
{
	switch (%Mid)
	{
		case 0:%Type = 1;
		default:%Type = 0;
	}

	switch (%Type)
	{
		case 0://默认条件
			%Mid_Kind = GetMissionData(%Mid,$Mission_Data_Map_Area);
			%MapName  =	GetTriggerData(%Mid_Kind,3);

		case 1://特殊条件

		default://默认条件
			%Mid_Kind = GetMissionData(%Mid,$Mission_Data_Map_Area);
			%MapName  =	GetTriggerData(%Mid_Kind,3);
	}

	//确认返回值
	switch (%Back)
	{
		case 1:return %MapName;
		case 2:return %Mid_Kind;
	}
}

//■■■■■■■■■■【通用】获取任务归属地图■■■■■■■■■■■■■■■■
