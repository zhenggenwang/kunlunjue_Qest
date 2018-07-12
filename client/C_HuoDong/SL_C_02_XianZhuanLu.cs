//■■■■【活动大全系统】■■■■■收到服务端开关配置■■■■■■■■
//■■■■【活动大全系统】■■■■■活动总数量计算■■■■■■■■■■
//■■■■【活动大全系统】■■■■■全局变量存放■■■■■■■■■■■
//■■■■【活动大全系统】■■■■■活动文本显示■■■■■■■■■■■

//根据类型和状态获取活动数量:function GetActivityNumByType( %type, %litState )  %type:1-3 %litState:0-1
//设置各活动的信息：ShowBtnActivityMessage( %num, %type, %litState );
//活动等级："active_lv_text_" @%i
//活动名称："active_name_text_" @%i
//当前活动次数："active_curnum_text_" @%i
//活动开放时间："active_time_text_" @%i
//活动组队类型："active_team_text_" @%i
//副本类型图片："active_type_bmp_" @ %i  
//点击按钮右侧详细信息显示：function SetDetailsContent( %type, %i )//参数不太确定
//活动目的text控件：Activity_Purpose_text
//活动背景text控件：Activity_Details_text
//
//105100261	少量经验
//105100262	大量经验
//105100263	海量经验
//105100264	少量金币
//105100265	大量金币
//105100266	少量元宝
//105100267	大量元宝
//105100268	技能书
//105100269	商城道具
//105100270	特殊配方
//105100271	生活材料
//105100272	蓝色装备( 40-49级 )
//105100273	紫色装备( 40-49级 )
//105100274	蓝色装备( 50-59级 )
//105100275	紫色装备( 50-59级 )
//105100276	蓝色装备( 60-69级 )
//105100277	紫色装备( 60-69级 )
//105100278	蓝色装备( 70-79级 )
//105100279	紫色装备( 70-79级 )
//105100280	蓝色装备( 80-89级 )
//105100281	紫色装备( 80-89级 )
//105100282	蓝色装备( 90-99级 )
//105100283	紫色装备( 90-99级 )
//105100284	蓝色装备( 100-109级 )
//105100285	紫色装备( 100-109级 )
//105100286	蓝色装备( 110-119级 )
//105100287	紫色装备( 110-119级 )
//105100288	蓝色装备( 120-129级 )
//105100289	紫色装备( 120-129级 )
//105100290	蓝色装备( 130-139级 )
//105100291	紫色装备( 130-139级 )
//105100292	蓝色装备( 140-150级 )
//105100293	紫色装备( 140-150级 )
//105100294	橙色装备
//105100295	神兵利器
//105100296	生活材料
//105100297	普通道具
//105100298	珍贵道具
//105100299	稀有道具


//■■■■【活动大全系统】■■■■■全局变量存放■■■■■■■■■■■
function GetActivitytext()
{

	//-------------------------------群英汇聚----------------------
	$SL_HuoDong_Actmsg[1] = "20 2";//可见等级 活动类型(1 2 3)
	$active_lv_text_[1] = "等级:" @ GetWord($SL_HuoDong_Actmsg[1],0);
	$active_name_text_[1] = "群英汇聚";
	$active_curnum_text_[1]= GetSrc(GetPlayer(),3) * 1 @ "/1";
	$active_time_text_[1] = "时间：19:00--20:00";
	$active_team_text_[1]= "人数：不限";
	$active_type_bmp_[1] ="gameres/gui/images/activetype_2.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[1] = "gameres/gui/images/ActivityTypeBmp_001.png";//底图 	1道具	2地宫	3经验	4世界
	$Activity_Purpose_text[1] = "待得夕阳西下时，帮主将在昆仑召唤熊熊的图腾，众修士环绕图腾而坐，分享今日收货，其乐融融，修为快速增长。";

	getplayer().ClearMissionItem(1);
	getplayer().AddItemToMission(1,1,105100262,1);
	$Activity_Details_text[1] = "<t>寻找帮主召唤帮派图腾，领取一份暖暖的图腾之力吧。当然，你也可以付出一点小小的代价，去其他帮派获得图腾。</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	入口：</t>" @ $Get_Dialog_GeShi[31426] @ "	昆仑	</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\""@ "FindPath( 810010107 );" @"\",\"" @ $Get_Dialog_GeShi[31214] @ "会盟广场" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	19:00-20:00</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	次数：</t>" @ $Get_Dialog_GeShi[31426] @ "	每天1次</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	不限</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(1) @ "<b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "<t>图腾等级越高，奖励越丰厚！</t><b/><b/>";
	$Active_PathToDes[1] = "CloseActivityWnd();findpath(810010107);";

	//------------------------------------------------------------

	//-------------------------------时空裂痕----------------------
	$SL_HuoDong_Actmsg[2] = "30 2";//可见等级 活动类型(1 2 3)
	$active_lv_text_[2] = "等级:" @ GetWord($SL_HuoDong_Actmsg[2],0);
	$active_name_text_[2] = "时空裂痕";
	$active_curnum_text_[2]= GetAct(GetPlayer(),3029,0) * 1 @ "/1";
	$active_time_text_[2] = "时间：19:00--22:00";
	$active_team_text_[2]= "人数：组队";
	$active_type_bmp_[2] ="gameres/gui/images/activetype_2.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[2] = "gameres/gui/images/ActivityTypeBmp_002.png";//底图 	1道具	2地宫	3经验	4世界
	$Activity_Purpose_text[2] = "魔界妖魔欲冲破神器封印入侵人间界，蓬莱掌门号令蓬莱弟子前往诛杀妖魔，加固神器封印！";
	getplayer().ClearMissionItem(2);
	getplayer().AddItemToMission(2,1,105100263,1);
	$Activity_Details_text[2] = "<t>进入时空裂痕内的修士，会获得一种神奇的本命星之魂魄，提高星魂等级，可以额外获得大量的奖励</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	入口：</t>" @ $Get_Dialog_GeShi[31426] @ "	昆仑	</t>" @ Getfindpath(410010209,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	19:00--22:00</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	次数：</t>" @ $Get_Dialog_GeShi[31426] @ "	每天1次</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	建议3人以上队伍</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(2) @ "<b/>";
	$Active_PathToDes[2] = "CloseActivityWnd();findpath(410010209);";
	//------------------------------------------------------------

	//-------------------------------炼魔渊----------------------
	$SL_HuoDong_Actmsg[3] = "45 1";//可见等级 活动类型(1 2 3)
	$active_lv_text_[3] = "等级:" @ GetWord($SL_HuoDong_Actmsg[3],0);
	$active_name_text_[3] = "炼魔渊";
	$active_curnum_text_[3]= GetAct(GetPlayer(),3030,0) + GetAct(GetPlayer(),3030,1) @ "/3";
	$active_time_text_[3] = "时间：不限";
	$active_team_text_[3]= "人数：组队";
	$active_type_bmp_[3] ="gameres/gui/images/activetype_5.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[3] = "gameres/gui/images/ActivityTypeBmp_003.png";//底图 	1道具	2地宫	3经验	4世界
	$Activity_Purpose_text[3] = "血魔召集魔教众人久攻不下昆仑，一众魔头被蓬莱掌门以大法力禁锢在炼魔渊。";

	getplayer().ClearMissionItem(3);
	getplayer().AddItemToMission(3,1,105100262,1);
	getplayer().AddItemToMission(3,1,105105401,1);
	getplayer().AddItemToMission(3,1,105105403,1);
	getplayer().AddItemToMission(3,1,105105405,1);
	getplayer().AddItemToMission(3,1,105105407,1);
	getplayer().AddItemToMission(3,1,105105451,1);
	getplayer().AddItemToMission(3,1,105105453,1);
	getplayer().AddItemToMission(3,1,105105455,1);
	getplayer().AddItemToMission(3,1,105105457,1);
	$Activity_Details_text[3] = "<t>蓬莱掌门为提升门下弟子实力，召集精英弟子前往炼魔渊拿魔教众徒试炼，以提升自己修为！</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	入口：</t>" @ $Get_Dialog_GeShi[31426] @ "	昆仑	</t>" @ Getfindpath(410010204,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	不限</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	次数：</t>" @
		$Get_Dialog_GeShi[31426] @ "	1.每天免费进入1次</t><b/>" @
		$Get_Dialog_GeShi[31426] @ "								2.使用</t>" @ "<l i='105109201 ' t='itemid'/>" @ $Get_Dialog_GeShi[31426] @ "进入副本，每天可用2次</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	建议6人组队</t><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(3) @ "<b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "<t>炼魔渊挑战开启后，无法中途暂停哦！</t><b/>";
	$Active_PathToDes[3] = "CloseActivityWnd();findpath(410010204);";
	//------------------------------------------------------------

	//-------------------------------幻境争霸----------------------
	$SL_HuoDong_Actmsg[4] = "40 2";//可见等级 活动类型(1 2 3)
	$active_lv_text_[4] = "等级:" @ GetWord($SL_HuoDong_Actmsg[4],0);
	$active_name_text_[4] = "幻境争霸";
	$active_curnum_text_[4]= GetSrc(GetPlayer(),4) * 1  @ "/1";
	$active_time_text_[4] = "时间：周一 三 五 20:00-20:05";
	$active_team_text_[4]= "人数：单人";
	$active_type_bmp_[4] ="gameres/gui/images/activetype_5.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[4] = "gameres/gui/images/ActivityTypeBmp_004.png";//底图 	1道具	2地宫	3经验	4世界
	$Activity_Purpose_text[4] = "无尽的昆仑仙境中，有一片残酷的修士善恶场，唯有最强者才能登临顶峰。击败足够数量的修士，即可进更高层，被杀则会跌落低层。";
	getplayer().ClearMissionItem(4);
	getplayer().AddItemToMission(4,1,105100262,1);
	getplayer().AddItemToMission(4,1,105105303,1);
	getplayer().AddItemToMission(4,1,105105304,1);
	getplayer().AddItemToMission(4,1,105105713,1);
	getplayer().AddItemToMission(4,1,105090412,1);
	getplayer().AddItemToMission(4,1,105090413,1);
	getplayer().AddItemToMission(4,1,105100103,1);
	getplayer().AddItemToMission(4,1,105100103,1);
	getplayer().AddItemToMission(4,1,105090414,1);

	$Activity_Details_text[4] = "<t>所处层数越高，奖励越丰富。最高层有许多古修遗留的宝藏，开启后有机会获得珍惜道具。</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	入口：</t>" @ $Get_Dialog_GeShi[31426] @ "	昆仑	</t>" @ Getfindpath(410010211,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	周 一 三 五 20:00-20:05</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	次数：</t>" @	$Get_Dialog_GeShi[31426] @ "	每天1次</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	单人</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(4) @ "<b/>";
	$Active_PathToDes[4] = "CloseActivityWnd();findpath(410010211);";
	//------------------------------------------------------------

	//-------------------------------世界首领----------------------
	$SL_HuoDong_Actmsg[5] = "30 3";//可见等级 活动类型(1 2 3) ActivityTypeBmp_3.png 野外BOSS  ActivityTypeBmp_4.png 地宫首领
	$SL_HuoDong_Boss[1] = "荣耀使者 30 ActivityTypeBmp_5_001.png 810010100 6 440000015 activetype_4.png";//名字 等级 底图 地图 刷新CD 坐标 显示类型
	$SL_HuoDong_Boss[2] = "雕像使者 40 ActivityTypeBmp_5_002.png 811190100 6 440000016 activetype_4.png";//名字 等级 底图 地图 刷新CD 坐标 显示类型
	$SL_HuoDong_Boss[3] = "青丘狐王 50 ActivityTypeBmp_5_003.png 811010100 6 440000001 activetype_4.png";//名字 等级 底图 地图 刷新CD 坐标 显示类型
	$SL_HuoDong_Boss[4] = "幽城鬼王 55 ActivityTypeBmp_5_004.png 811280200 8 440000008 activetype_3.png";//名字 等级 底图 地图 刷新CD 坐标 显示类型
	$SL_HuoDong_Boss[5] = "雪海魔君 60 ActivityTypeBmp_5_005.png 811020100 6 440000002 activetype_4.png";//名字 等级 底图 地图 刷新CD 坐标 显示类型
	$SL_HuoDong_Boss[6] = "裂魂太岁 65 ActivityTypeBmp_5_006.png 811290400 8 440000009 activetype_3.png";//名字 等级 底图 地图 刷新CD 坐标 显示类型
	$SL_HuoDong_Boss[7] = "天纹夜叉 70 ActivityTypeBmp_5_007.png 811030100 6 440000003 activetype_4.png";//名字 等级 底图 地图 刷新CD 坐标 显示类型
	$SL_HuoDong_Boss[8] = "暴君龙王 75 ActivityTypeBmp_5_008.png 811300400 8 440000010 activetype_3.png";//名字 等级 底图 地图 刷新CD 坐标 显示类型
	$SL_HuoDong_Boss[9] = "1104的对 80 ActivityTypeBmp_5_009.png 811040100 6 440000004 activetype_4.png";//名字 等级 底图 地图 刷新CD 坐标 显示类型

	$Activity_Purpose_text[5, 1] = "荣耀使者携带着一枚勋章，此物乃是创建帮派的关键之物，只有战胜他才有机会获得此物。";
	$Activity_Purpose_text[5, 2] = "雕像使者携带着一枚雕像印章，拥有此物，才可以参与角逐封魔城主之争。";
	$Activity_Purpose_text[5, 3] = "相传，千年前，狐王曾是望仙谷的一只普通狐狸，一朝得遇机缘化形成妖。";
	$Activity_Purpose_text[5, 4] = "据传说，鬼王乃陨仙窟内死去的仙人怨气所化，怨气不散，永生永世不得超脱。";
	$Activity_Purpose_text[5, 5] = "数千年前被冰封在苍山雪海之下的古老魔族，雪山崩坍后破封而出。";
	$Activity_Purpose_text[5, 6] = "昔年落日神殿的守卫者，威震四海的半神强者。";
	$Activity_Purpose_text[5, 7] = "原本可以飞行的夜叉，因在战斗中失去翅膀而变得凶暴，无恶不作";
	$Activity_Purpose_text[5, 8] = "深居在海底的霸主，凶悍而残暴";
	$Activity_Purpose_text[5, 9] = "上古神魔大战，战死神弃荒芜的古魔残躯复生而成。不灭的意志将其牢牢束缚在此，无法安息。";

	$SL_HuoDong_Bossitemlist[1] = "105109052";
	$SL_HuoDong_Bossitemlist[2] = "105109053";
	$SL_HuoDong_Bossitemlist[3] = "105090501 105090502 105090601 105090602 105090511 105090512 105090513 105090611 105090612 105090613 116010003 105105302 106071032";
	$SL_HuoDong_Bossitemlist[4] =	"109011102 109012102 109013102 109014102 101014005 101024005 101034005 101044005 105105302 116010003 105090511 105090512 105090513 105090611 105090612 105090613 ";
	$SL_HuoDong_Bossitemlist[5] =	"105090511 105090512 105090611 105090612 105105302 105105303 116010003 106071033";
	$SL_HuoDong_Bossitemlist[6] = "109011103 109012103 109013103 109014103 101014006 101024006 101034006 101044006 105105302 105105303 116010003 105090511 105090512 105090513 105090611 105090612 105090613 ";
	$SL_HuoDong_Bossitemlist[7] =	"105090511 105090512 105090611 105090612 105090521 105090522 105090621 105090622 105105302 105105303 116010003 106071034";
	$SL_HuoDong_Bossitemlist[8] = "109011104 109012104 109013104 109014104 101014007 101024007 101034007 101044007 105105302 105105303 116010003 105090521 105090522 105090523 105090621 105090622 105090623 ";
	$SL_HuoDong_Bossitemlist[9] = "109011104 109012104 109013104 109014104 101014007 101024007 101034007 101044007 105105302 105105303 116010003 105090521 105090522 105090523 105090621 105090622 105090623 ";
	for (%i=1; %i<=99; %i++)
	{
		if ($SL_HuoDong_Boss[%i] $= "")
			break;
		$active_lv_text_[5,%i] = "等级:" @ GetWord($SL_HuoDong_Boss[%i],1);
		$active_name_text_[5,%i] = GetWord($SL_HuoDong_Boss[%i],0);
		$active_curnum_text_[5,%i]= "";
		$active_time_text_[5,%i] = "时间：" @ getword($SL_HuoDong_Boss[%i],4) @ "小时刷新一次";
		$active_team_text_[5,%i]= "人数：组队";
		$active_type_bmp_[5,%i] ="gameres/gui/images/" @ GetWord($SL_HuoDong_Boss[%i],6);// 1  道具活动 2  经验活动 3地宫首领 4世界首领
		$CreateActivityBmp_[5,%i] = "gameres/gui/images/" @  GetWord($SL_HuoDong_Boss[%i],2);//底图 1道具	2地宫	3经验	4世界

		getplayer().ClearMissionItem(500 + %i);
		for (%j =0; %j<=99; %j++)
		{
			%itemID = getword($SL_HuoDong_Bossitemlist[%i],%j);
			if (%itemID > 0)
				getplayer().AddItemToMission(500 + %i,1,%itemID,1);
			else
				break;
		}
		//%PathID = "<l i='" @ "8" @ getword( $SL_HuoDong_Boss[ %i ], 3 ) @ "0100 " @ getword( $SL_HuoDong_Boss[ %i ], 5 ) @ " " @ getword( $SL_HuoDong_Boss[ %i ], 6 ) @ " " @ getword( $SL_HuoDong_Boss[ %i ], 7 ) @ "' t='path'/>";

		$Activity_Details_text[5,%i] =
			$Get_Dialog_GeShi[31428] @ "	刷新地点：</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(" @ GetWord($SL_HuoDong_Boss[%i],5) @ ");\",\"" @ $Get_Dialog_GeShi[31414] @ GetTriggerData(GetWord($SL_HuoDong_Boss[%i],3),3) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>"  @
			$Get_Dialog_GeShi[31428] @ "	刷新时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	" @ getword($SL_HuoDong_Boss[%i],4) @ "小时刷新一次</t><b/>" @
			$Get_Dialog_GeShi[31428] @ "	首领奖励：</t><b/>" @ GetFixedMissionItemText(500 + %i);
		//$Active_PathToDes[ 5, %i ] = "CloseActivityWnd();findpath(" @ %PathID @ ");";
	}

	//------------------------------------------------------------
	//-------------------------------诛妖----------------------
	$SL_HuoDong_Actmsg[6] = "36 1";//可见等级 活动类型(1 2 3)
	$active_lv_text_[6] = "等级:" @ GetWord($SL_HuoDong_Actmsg[6],0);
	$active_name_text_[6] = "诛妖";
	$active_curnum_text_[6]= Getact(GetPlayer(),4012,0) * 1  @ "/10";
	$active_time_text_[6] = "时间：不限";
	$active_team_text_[6]= "人数：单人";
	$active_type_bmp_[6] ="gameres/gui/images/activetype_1.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[6] = "gameres/gui/images/ActivityTypeBmp_006.png";//底图 	1道具	2地宫	3经验	4世界
	$Activity_Purpose_text[6] = "上古时代，妖魔纵横。上古人族崛起后，把妖魔或驱逐或封印。然，妖魔祸乱人间之心不死，人族修士，当为人族之剑，斩妖除魔。";
	getplayer().ClearMissionItem(6);
	getplayer().AddItemToMission(6,1,113090002,1);
	$Activity_Details_text[6] = "<t>昆仑奇人在昆仑城寻找能帮他除妖的高手猛士，并以上古妖魔的藏宝图作为报酬。扬名立万、斩妖收宝的机缘就在眼前，修士，你还在犹豫什么？</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	地点：</t>" @ $Get_Dialog_GeShi[31426] @ "	昆仑	</t>" @ Getfindpath(410010205,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	不限</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	次数：</t>" @	$Get_Dialog_GeShi[31426] @ "	每天10次</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	单人</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(6) @ "<b/>";
	$Active_PathToDes[6] = "CloseActivityWnd();findpath(410010205);";
	//------------------------------------------------------------
	//-------------------------------藏宝图----------------------
	$SL_HuoDong_Actmsg[7] = "35 1";//可见等级 活动类型(1 2 3)
	$active_lv_text_[7] = "等级:" @ GetWord($SL_HuoDong_Actmsg[7],0);
	$active_name_text_[7] = "藏宝图";
	$active_curnum_text_[7]= Getact(GetPlayer(), 4012, 1) * 1  @ "/" @ VIP_getNowTequanLvMaxCnt(getPlayer(), 8);
	$active_time_text_[7] = "时间：不限";
	$active_team_text_[7]= "人数：单人";
	$active_type_bmp_[7] ="gameres/gui/images/activetype_1.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[7] = "gameres/gui/images/ActivityTypeBmp_007.png";//底图 	1道具	2地宫	3经验	4世界
	$Activity_Purpose_text[7] = "上古妖魔战败之际，将天材地宝、珍贵法宝藏匿于隐秘之处,以待他日卷土重来。岂料,转眼十万年已逝,人族强盛,妖魔万古算计终成空。";
	getplayer().ClearMissionItem(7);
	getplayer().AddItemToMission(7,1,105100131,1);
	getplayer().AddItemToMission(7,1,105100102,1);
	getplayer().AddItemToMission(7,1,105100112,1);
	getplayer().AddItemToMission(7,1,105105302,1);
	getplayer().AddItemToMission(7,1,105105303,1);
	getplayer().AddItemToMission(7,1,105090801,1);
	getplayer().AddItemToMission(7,1,112010006,1);
	getplayer().AddItemToMission(7,1,112020003,1);
	getplayer().AddItemToMission(7,1,109020508,1);
	getplayer().AddItemToMission(7,1,109030505,1);


	$Activity_Details_text[7] = "<t>每次开启藏宝图，即可获得藏宝地点，有机会获得珍贵宝藏，也可能一无所获，还有可能释放出被封印的上古妖魔之灵。</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	地点：</t>" @ $Get_Dialog_GeShi[31426] @ "	主城、野外地图</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	不限</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	次数：	</t>" @ $Get_Dialog_GeShi[ 31426 ] @ VIP_getNowTequanLvMaxCnt( getPlayer( ), 8 ) @ "次/天</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	不限</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(7) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	藏宝图可以通过完成诛妖任务获得哦！</t>";
	$Active_PathToDes[7] = "CloseActivityWnd();findpath(410010205);";
	//------------------------------------------------------------

	//-------------------------------师门尽忠----------------------
	$SL_HuoDong_Actmsg[8] = "35 1";//可见等级 活动类型(1 2 3)
	$active_lv_text_[8] = "等级:" @ GetWord($SL_HuoDong_Actmsg[8],0);
	$active_name_text_[8] = "师门尽忠";
	$active_curnum_text_[8]= Getact(GetPlayer(),4015,0) * 1  @ "/10";
	$active_time_text_[8] = "时间：不限";
	$active_team_text_[8]= "人数：单人";
	$active_type_bmp_[8] ="gameres/gui/images/activetype_2.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[8] = "gameres/gui/images/ActivityTypeBmp_008.png";//底图 	1道具	2地宫	3经验	4世界
	$Activity_Purpose_text[8] = "门派事物繁忙，望诸弟子空闲之余勿忘折返蓬莱，分担琐碎杂物，为门派尽忠。";
	getplayer().ClearMissionItem(8);
	getplayer().AddItemToMission(8,1,105100262,1);
	$Activity_Details_text[8] = "<t>每天可以完成10次师门尽忠任务，完成的次数越多，奖励越高。如果放弃任务，不清除当前次数，且10分钟内无法接取任务。</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	地点：</t>" @ $Get_Dialog_GeShi[31426] @ "	蓬莱	</t>" @ Getfindpath(410100001,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	不限</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	次数：</t>" @	$Get_Dialog_GeShi[31426] @ "	每天10次</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	单人</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(8) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	完成10次师门尽忠任务并且中途没有放弃过任何一环的话获得特殊奖励</t>" @ "<l i='105109341 ' t='itemid'/>";
	$Active_PathToDes[8] = "CloseActivityWnd();findpath(410100001);";
	//------------------------------------------------------------

	//-------------------------------诛神问心阵----------------------
	$SL_HuoDong_Actmsg[9] = "40 2";//可见等级 活动类型(1 2 3)
	$active_lv_text_[9] = "等级:" @ GetWord($SL_HuoDong_Actmsg[9],0);
	$active_name_text_[9] = "诛神问心阵";
	$active_curnum_text_[9]= Getact(GetPlayer(),4016,0) * 1  @ "/3";
	$active_time_text_[9] = "时间：18:00-24:00";
	$active_team_text_[9]= "人数：单人";
	$active_type_bmp_[9] ="gameres/gui/images/activetype_1.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[9] = "gameres/gui/images/ActivityTypeBmp_009.png";//底图 	1道具	2地宫	3经验	4世界
	$Activity_Purpose_text[9] = "上古之时，天尊有感世人仙路漫漫,道途多桀，遂将其随身法宝丢入凡尘，化作一方阵法世界，名为诛神问心境，内藏无数道法传承、神兵法宝。且命遗族巨人看守，有缘者可入内寻求仙缘。";
	getplayer().ClearMissionItem(9);
	getplayer().AddItemToMission(9,1,116120073,1);
	getplayer().AddItemToMission(9,1,116120074,1);
	getplayer().AddItemToMission(9,1,116120075,1);
	getplayer().AddItemToMission(9,1,116120076,1);
	getplayer().AddItemToMission(9,1,116120077,1);

	$Activity_Details_text[9] = "<t>诛神问心阵一共有10道关卡，每闯过一道关卡即可获得一份奖励。在副本中死亡即挑战失败。关卡数越高，难度越大，奖励越丰厚</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	地点：</t>" @ $Get_Dialog_GeShi[31426] @ "	云梦沼泽	</t>" @ Getfindpath(413030001,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	18:00-24:00</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	次数：</t>" @	$Get_Dialog_GeShi[31426] @ "	每天可挑战3次</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	单人</t><b/>"@
		$Get_Dialog_GeShi[31428] @ "	当前关卡：</t>" @ ((Getact(GetPlayer(),4016,1) * 1 <= 10) ? $Get_Dialog_GeShi[31426] @ "	" @ Getact(GetPlayer(),4016,1) * 1 @ "/10</t>" : $Get_Dialog_GeShi[31426] @ "	已通关</t>") @ "<b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(9) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	每个关卡的宝箱每天只可领取一次</t><b/>" @ "<t>	在副本中死亡即挑战失败</t>";
	$Active_PathToDes[9] = "CloseActivityWnd();findpath(413030001);";
	//------------------------------------------------------------

	//-------------------------------鸿蒙试炼----------------------
	$SL_HuoDong_Actmsg[10] = "40 2";//可见等级 活动类型(1 2 3)
	$active_lv_text_[10] = "等级:" @ GetWord($SL_HuoDong_Actmsg[10],0);
	$active_name_text_[10] = "鸿蒙试炼";
	$active_curnum_text_[10]= GetSrc(GetPlayer(),5)  @ "/1";
	$active_time_text_[10] = "时间：周二 四 六 20:00-20:05";
	$active_team_text_[10]= "人数：单人";
	$active_type_bmp_[10] ="gameres/gui/images/activetype_5.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[10] = "gameres/gui/images/ActivityTypeBmp_010.png";//底图 	1道具	2地宫	3经验	4世界
	$Activity_Purpose_text[10] = "陨仙界是一片破碎的小世界，危机重重，步步杀机，时有天灾爆发，身处天灾之内即时有通天之能也无法存活";
	getplayer().ClearMissionItem(10);
	getplayer().AddItemToMission(10,1,105100262,1);
	getplayer().AddItemToMission(10,1,105100111,1);
	getplayer().AddItemToMission(10,1,105100121,1);
	getplayer().AddItemToMission(10,1,105100112,1);
	getplayer().AddItemToMission(10,1,105100122,1);
	getplayer().AddItemToMission(10,1,105105302,1);
	getplayer().AddItemToMission(10,1,105105303,1);
	$Activity_Details_text[10] = "<t>在陨仙界内，能获得持续不断的修为灌注，但世界之力有限，如果人数过多，将无法获得修为奖励。</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	地点：</t>" @ $Get_Dialog_GeShi[31426] @ "	昆仑	</t>" @ Getfindpath(410010212,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	周二 四 六 20:00-20:05</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	次数：</t>" @	$Get_Dialog_GeShi[31426] @ "	1次/天</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	单人</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(10) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	在副本中死亡即挑战失败</t>";
	$Active_PathToDes[10] = "CloseActivityWnd();findpath(410010212);";
	//------------------------------------------------------------
	//-------------------------------押镖-------------------------
	$SL_HuoDong_Actmsg[11] = "50 2";//可见等级 活动类型(1 2 3)
	$active_lv_text_[11] = "等级:" @ GetWord($SL_HuoDong_Actmsg[11],0);
	$active_name_text_[11] = "押镖";
	$active_curnum_text_[11]= Getact(GetPlayer(),4018,0) * 1  @ "/" @ VIP_getNowTequanLvMaxCnt(getPlayer(), 7);
	$active_time_text_[11] = "时间：12:00-22:00";
	$active_team_text_[11]= "人数：单人";
	$active_type_bmp_[11] ="gameres/gui/images/activetype_5.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[11] = "gameres/gui/images/ActivityTypeBmp_011.png";//底图 	1道具	2地宫	3经验	4世界
	$Activity_Purpose_text[11] = "封魔城最近需要运送大量物资，镇远镖局人手欠缺，招募大量修士接取赏金任务。";
	getplayer().ClearMissionItem(11);
	getplayer().AddItemToMission(11,1,105100262,1);
	getplayer().AddItemToMission(11,1,105100265,1);
	getplayer().AddItemToMission(11,1,105105301,1);
	getplayer().AddItemToMission(11,1,105105302,1);
	getplayer().AddItemToMission(11,1,105105303,1);
	getplayer().AddItemToMission(11,1,105105304,1);
	getplayer().AddItemToMission(11,1,105180150,1);
	getplayer().AddItemToMission(11,1,105180151,1);
	getplayer().AddItemToMission(11,1,105180152,1);
	$Activity_Details_text[11] = "<t>押镖前需要选择本次押金，押镖完成后返还押金，同时获得押金乘以50%的金币作为押镖奖励。如果在押镖途中死亡，本次押镖失败。</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	地点：</t>" @ $Get_Dialog_GeShi[31426] @ "	封魔城	</t>" @ "<l i='811190100 108.295 -188.031 120' t='path'/>" @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	12:00-22:00</t><b/>" @
		$Get_Dialog_GeShi[ 31428 ] @ "	次数：	</t>" @ $Get_Dialog_GeShi[ 31426 ] @ VIP_getNowTequanLvMaxCnt( getPlayer( ), 7 ) @ "次/天</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	单人</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(11) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	该地图为高危险区域，混乱战斗，死亡后有掉落物品风险。</t>";
	$Active_PathToDes[11] = "CloseActivityWnd();findpath(411190001);";
	//-----------------------------钓鱼----------------------------
	$SL_HuoDong_Actmsg[12] = "30 2";//可见等级 活动类型(1 2 3)
	$active_lv_text_[12] = "等级:" @ GetWord($SL_HuoDong_Actmsg[12],0);
	$active_name_text_[12] = "蓬莱仙钓";
	$active_curnum_text_[12]= GetAct(getplayer(),4022,1) * 1@ "/10";
	$active_time_text_[12] = "时间：18:30-19:00";
	$active_team_text_[12]= "人数：单人";
	$active_type_bmp_[12] ="gameres/gui/images/activetype_1.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[12] = "gameres/gui/images/ActivityTypeBmp_012.png";//底图 	1道具	2地宫	3经验	4世界
	$Activity_Purpose_text[12] = "壮阔的海岸，白色的沙滩，于垂钓之中收获惊喜，在轻松之余感受乐趣。拿起鱼竿，向着海滩出发吧。";
	getplayer().ClearMissionItem(12);
	getplayer().AddItemToMission(12,1,105109303,1);
	getplayer().AddItemToMission(12,1,106050301,1);
	getplayer().AddItemToMission(12,1,106050302,1);
	getplayer().AddItemToMission(12,1,106050303,1);
	getplayer().AddItemToMission(12,1,106050304,1);
	getplayer().AddItemToMission(12,1,106050305,1);
	getplayer().AddItemToMission(12,1,106050306,1);
	getplayer().AddItemToMission(12,1,106050307,1);

	getplayer().AddItemToMission(12,1,GetNewItemIDForLevel(getplayer(),113050004),1);
	getplayer().AddItemToMission(12,1,GetNewItemIDForLevel(getplayer(),105109321),1);
	getplayer().AddItemToMission(12,1,GetNewItemIDForLevel(getplayer(),105105701),1);
	getplayer().AddItemToMission(12,1,GetNewItemIDForLevel(getplayer(),105090603),1);
	getplayer().AddItemToMission(12,1,GetNewItemIDForLevel(getplayer(),105090503),1);
	$Activity_Details_text[12] = "<t>携带一份</t>" @ "<l i='105109301 ' t='itemid'/>" @ "<t>寻找</t>" @ Getfindpath(410100012,0,0,31214) @ "<t>兑换鱼饵，才可以参加垂钓活动。</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	地点：</t>" @ $Get_Dialog_GeShi[31426] @ "	蓬莱湾	</t>" @ "<l i='810100100 -67.873 -127.528 107.257' t='path'/>" @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	18:30-19:00</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	单人</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(12) @ "<b/>";
	$Active_PathToDes[12] = "CloseActivityWnd();findpath(810100109); ";
	//-------------------------------------------------------------
	//-----------------------------聆经悟道----------------------------
	$SL_HuoDong_Actmsg[13] = "30 1";//可见等级 活动类型(1 2 3)
	$active_lv_text_[13] = "等级:" @ GetWord($SL_HuoDong_Actmsg[13],0);
	$active_name_text_[13] = "聆经悟道";
	$active_curnum_text_[13]= "不限";
	$active_time_text_[13] = "时间：不限";
	$active_team_text_[13]= "人数：单人";
	$active_type_bmp_[13] ="gameres/gui/images/activetype_2.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[13] = "gameres/gui/images/ActivityTypeBmp_013.png";//底图 	1道具	2地宫	3经验	4世界
	$Activity_Purpose_text[13] = "传说，蓬莱藏经阁有道书三千卷，阅尽三千道书，飞升指日可待。";
	getplayer().ClearMissionItem(13);
	getplayer().AddItemToMission(13,1,105100261,1);
	getplayer().AddItemToMission(13,1,105109312,1);
	getplayer().AddItemToMission(13,1,105109313,1);
	getplayer().AddItemToMission(13,1,105109314,1);
	getplayer().AddItemToMission(13,1,105109315,1);
	$Activity_Details_text[13] = "<t>读书破万卷，修道如有神。闲暇之余，可前去聆经台，参悟道经，修身养神。</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	地点：</t>" @ $Get_Dialog_GeShi[31426] @ "	聆经台	</t>" @ "<l i='810100100 8.72428 67.0598 135.177' t='path'/>" @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	全天（除去首座论经时）</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	单人</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(13) @ "<b/>";
	$Active_PathToDes[13] = "CloseActivityWnd();findpath(410100023);";
	//-------------------------------------------------------------
	//-----------------------------首座论经----------------------------
	$SL_HuoDong_Actmsg[14] = "30 2";//可见等级 活动类型(1 2 3)
	$active_lv_text_[14] = "等级:" @ GetWord($SL_HuoDong_Actmsg[14],0);
	$active_name_text_[14] = "首座论经";
	$active_curnum_text_[14]= GetAct(GetPlayer(),4024,0) + GetAct(GetPlayer(),4024,1) @ "/30";
	$active_time_text_[14] = "时间：20:30-20:55";
	$active_team_text_[14]= "人数：不限";
	$active_type_bmp_[14] ="gameres/gui/images/activetype_2.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[14] = "gameres/gui/images/ActivityTypeBmp_014.png";//底图 	1道具	2地宫	3经验	4世界
	$Activity_Purpose_text[14] = "蓬莱藏经阁长老，每日于聆经台讲道，有缘者皆可前来听道，有造化者可从中获益良多。";

	getplayer().ClearMissionItem(14);
	getplayer().AddItemToMission(14,1,105100262,1);
	getplayer().AddItemToMission(14,1,105109312,1);
	getplayer().AddItemToMission(14,1,105109313,1);
	getplayer().AddItemToMission(14,1,105109314,1);
	getplayer().AddItemToMission(14,1,105109315,1);
	$Activity_Details_text[14] = "<t>宁长老每次提问时，听道者需按照“是”、“非”选择一方站立，方可获得修为增长。答题完毕后，可前去寻找</t>" @ Getfindpath(410100031,0,0,31214) @ "<t>领取奖励。</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	地点：</t>" @ $Get_Dialog_GeShi[31426] @ "	聆经台	</t>" @ "<l i='810100100 8.72428 67.0598 135.177' t='path'/>" @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	20:30-20:55</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	不限</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(14) @ "<b/>";
	$Active_PathToDes[14] = "CloseActivityWnd();findpath(410100031);";
	//-------------------------------------------------------------
	//-----------------------------冰火试炼----------------------------
	$SL_HuoDong_Actmsg[15] = "30 1";//可见等级 活动类型(1 2 3)
	$active_lv_text_[15] = "等级:" @ GetWord($SL_HuoDong_Actmsg[15],0);
	$active_name_text_[15] = "冰火试炼";
	$active_curnum_text_[15]= GetSrc(GetPlayer(),40) +  GetSrc(GetPlayer(),41) +  GetSrc(GetPlayer(),42) +  GetSrc(GetPlayer(),43) +  GetSrc(GetPlayer(),49) +  GetSrc(GetPlayer(),55) +  GetSrc(GetPlayer(),56) @ "/7";
	$active_time_text_[15] = "时间：不限";
	$active_team_text_[15]= "人数：不限";
	$active_type_bmp_[15] ="gameres/gui/images/activetype_2.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[15] = "gameres/gui/images/ActivityTypeBmp_015.png";//底图 	1道具	2地宫	3经验	4世界
	$Activity_Purpose_text[15] = "曾经是昆仑区域的一处禁地，现在开放给各路修士，可免费进入。冰火试炼内有无尽宝藏，同时也危机重重。";
	getplayer().ClearMissionItem(15);
	getplayer().AddItemToMission(15,1,105100263,1);
	$Activity_Details_text[15] = "<t>完成七个每日任务可以获得活跃度和大量经验奖励，同时本地图还有无限循环任务【铲除翼妖】。</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	地点：</t>" @ $Get_Dialog_GeShi[31426] @ "	冰火试炼	</t>" @ Getfindpath(410010141,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	不限</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	不限</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(15) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	该地图为高危险区域，混乱战斗，死亡后有掉落物品风险。</t>";
	$Active_PathToDes[15] = "CloseActivityWnd();findpath(410010141);";
	//-------------------------------------------------------------
	//-----------------------------悬赏缉凶----------------------------
	$SL_HuoDong_Actmsg[16] = "30 1";//可见等级 活动类型(1 2 3)
	$active_lv_text_[16] = "等级:" @ GetWord($SL_HuoDong_Actmsg[16],0);
	$active_name_text_[16] = "悬赏缉凶";
	$active_curnum_text_[16]= "不限";
	$active_time_text_[16] = "时间：不限";
	$active_team_text_[16]= "人数：组队";
	$active_type_bmp_[16] ="gameres/gui/images/activetype_2.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[16] = "gameres/gui/images/ActivityTypeBmp_016.png";//底图 	1道具	2地宫	3经验	4世界
	$Activity_Purpose_text[16] = "尘世是非多，遂有一悬赏榜，召集各路修士前去助阵，斩妖除魔，积累功德。";
	getplayer().ClearMissionItem(16);
	getplayer().AddItemToMission(16,1,105100262,1);
	$Activity_Details_text[16] = "<t>各大地图都可领取悬赏任务，悬赏任务分白、绿、蓝、紫、橙数个品阶，完成品阶越高的任务，奖励越丰厚，获得的活跃度也越高！</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	地点：</t>" @ $Get_Dialog_GeShi[31426] @ "	望仙谷	</t>" @ Getfindpath(411010010,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31426] @ "	       苍山雪海	</t>" @ Getfindpath(411010010,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	不限</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	单人</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(16) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	接取和自身等级相符合的任务，奖励更高哦。</t>";
	$Active_PathToDes[16] = "CloseActivityWnd();findpath(411010010);";
	//-------------------------------------------------------------
	//-----------------------------血魔封印阵----------------------------
	$SL_HuoDong_Actmsg[17] = "40 1";//可见等级 活动类型(1 2 3)
	$active_lv_text_[17] = "等级:" @ GetWord($SL_HuoDong_Actmsg[17],0);
	$active_name_text_[17] = "血魔封印阵";
	$active_curnum_text_[17]= GetSrc(GetPlayer(),57) @ "/1";
	$active_time_text_[17] = "时间：不限";
	$active_team_text_[17]= "人数：组队";
	$active_type_bmp_[17] ="gameres/gui/images/activetype_2.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[17] = "gameres/gui/images/ActivityTypeBmp_017.png";//底图 	1道具	2地宫	3经验	4世界
	$Activity_Purpose_text[17] = "血魔围攻昆仑城之战时，一众魔教头目被蓬莱掌门封印于炼魔渊，剩下的教徒教众则被打入血魔封印大阵中日夜炼化。";
	getplayer().ClearMissionItem(17);
	getplayer().AddItemToMission(17,1,105100263,1);
	$Activity_Details_text[17] = "<t>蓬莱掌门为提升门下弟子实力，召集精英弟子前往血魔封印大阵拿魔教众徒试炼，以提升自己修为！</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	地点：</t>" @ $Get_Dialog_GeShi[31426] @ "	昆仑	</t>" @ Getfindpath(410010203,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	不限</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	组队（建议6人）</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(17) @ "<b/>";
	$Active_PathToDes[17] = "CloseActivityWnd();findpath(410010203);";
	//-------------------------------------------------------------
	//-----------------------------黄金宝藏----------------------------
	$SL_HuoDong_Actmsg[18] = "35 1";//可见等级 活动类型(1 2 3)
	$active_lv_text_[18] = "等级:" @ GetWord($SL_HuoDong_Actmsg[18],0);
	$active_name_text_[18] = "黄金宝藏";
	$active_curnum_text_[18]= "不限";
	$active_time_text_[18] = "时间：不限";
	$active_team_text_[18]= "人数：单人";
	$active_type_bmp_[18] ="gameres/gui/images/activetype_1.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[18] = "gameres/gui/images/ActivityTypeBmp_018.png";//底图 	1道具	2地宫	3经验	4世界
	$Activity_Purpose_text[18] = "千年前，有一暴君穷王国之力，搜集天下奇珍，珍藏于机关密境之中，世人称之为黄金宝藏。";
	getplayer().ClearMissionItem(18);
	getplayer().AddItemToMission(18,1,105100265,1);
	getplayer().AddItemToMission(18,1,105105301,1);
	getplayer().AddItemToMission(18,1,105105302,1);
	getplayer().AddItemToMission(18,1,105105303,1);

	$Activity_Details_text[18] = "<t>黄金宝藏中有种种机关密境，如若走错一步，则身死魂灭。</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	地点：</t>" @ $Get_Dialog_GeShi[31426] @ "	昆仑	</t>" @ Getfindpath(410010206,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	不限</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	单人</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(18) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	仔细查看系统提示，踏错传送门，挑战失败</t>";
	$Active_PathToDes[18] = "CloseActivityWnd();findpath(410010206);";
	//-------------------------------------------------------------
	//-----------------------------刀剑神域----------------------------
	$SL_HuoDong_Actmsg[19] = "50 2";//可见等级 活动类型(1 2 3)
	$active_lv_text_[19] = "等级:" @ GetWord($SL_HuoDong_Actmsg[19],0);
	$active_name_text_[19] = "刀剑神域";
	$active_curnum_text_[19]= GetSrc(GetPlayer(),57) @ "/1";
	$active_time_text_[19] = "时间：21:10-21:40";
	$active_team_text_[19]= "人数：单人";
	$active_type_bmp_[19] ="gameres/gui/images/activetype_5.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[19] = "gameres/gui/images/ActivityTypeBmp_019.png";//底图 	1道具	2地宫	3经验	4世界
	$Activity_Purpose_text[19] = "刀剑神域乃一上古战场，仙人百战之地，入内历练可大幅度增长修为。";
	getplayer().ClearMissionItem(19);
	getplayer().AddItemToMission(19,1,105100262,1);
	getplayer().AddItemToMission(19,1,105105303,1);
	getplayer().AddItemToMission(19,1,105105304,1);
	getplayer().AddItemToMission(19,1,105180070,1);
	getplayer().AddItemToMission(19,1,105180071,1);
	getplayer().AddItemToMission(19,1,105180072,1);
	getplayer().AddItemToMission(19,1,105180090,1);
	getplayer().AddItemToMission(19,1,105180091,1);
	getplayer().AddItemToMission(19,1,105180092,1);
	$Activity_Details_text[19] = "<t>完成战场内试炼使者的任务，以及击败敌对阵营修士，可获得大量经验奖励！</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	地点：</t>" @ $Get_Dialog_GeShi[31426] @ "	昆仑	</t>" @ Getfindpath(410010207,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	21:00</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	单人</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(19) @ "<b/>";
	$Active_PathToDes[19] = "CloseActivityWnd();findpath(410010207);";
	//-------------------------------------------------------------

	//-----------------------------紫星传功----------------------------
	$SL_HuoDong_Actmsg[20] = "30 1";//可见等级 活动类型(1 2 3)
	$active_lv_text_[20] = "等级:" @ GetWord($SL_HuoDong_Actmsg[20],0);
	$active_name_text_[20] = "紫星传功";
	$active_curnum_text_[20]= GetAct(GetPlayer(),4098,0) * 1 @ "/10";
	$active_time_text_[20] = "时间：不限";
	$active_team_text_[20]= "人数：单人";
	$active_type_bmp_[20] ="gameres/gui/images/activetype_2.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[20] = "gameres/gui/images/ActivityTypeBmp_020.png";//底图 	1道具	2地宫	3经验	4世界

	%Level = GetPlayer().GetLevel();
	if (%Level <= 44) %Itemname = "<l i='105109321 ' t='itemid'/>";
	else if (%Level <= 44) %Itemname = "<l i='105109321 ' t='itemid'/>";
	else if (%Level <= 59) %Itemname = "<l i='105109322 ' t='itemid'/>";
	else if (%Level <= 74) %Itemname = "<l i='105109323 ' t='itemid'/>";
	else if (%Level <= 89) %Itemname = "<l i='105109324 ' t='itemid'/>";
	else  %Itemname = "<l i='105109325 ' t='itemid'/>";

	$Activity_Purpose_text[20] = "<t>传功使者萧长河正在收集世间奇物</t>" @ %Itemname @ "<t>，前往上缴</t>" @ %Itemname @ "<t>即可获得萧长老的试炼任务。</t>";
	getplayer().ClearMissionItem(20);
	getplayer().AddItemToMission(20,1,105100263,1);

	$Activity_Details_text[20] = "<t>上缴和自己等级对应的</t>" @ %Itemname @ "<t>，即可接取相应等级的试炼任务！</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	地点：</t>" @ $Get_Dialog_GeShi[31426] @ "	昆仑	</t>" @ Getfindpath(410010104,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	不限</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	单人</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(20) @ "<b/>";
	$Active_PathToDes[20] = "CloseActivityWnd();findpath(410010104);";
	//-------------------------------------------------------------

	//-----------------------------镇魔殿----------------------------
	$SL_HuoDong_Actmsg[21] = "40 1";//可见等级 活动类型(1 2 3)
	$active_lv_text_[21] = "等级:" @ GetWord($SL_HuoDong_Actmsg[21],0);
	$active_name_text_[21] = "镇魔殿";
	$active_curnum_text_[21]= "不限";
	$active_time_text_[21] = "时间：6小时开启一次";
	$active_team_text_[21]= "人数：不限";
	$active_type_bmp_[21] ="gameres/gui/images/activetype_1.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[21] = "gameres/gui/images/ActivityTypeBmp_021.png";//底图 	1道具	2地宫	3经验	4世界

	%Level = GetPlayer().GetLevel();
	if (%Level <= 44) %Itemname = "<l i='105109321 ' t='itemid'/>";
	else if (%Level <= 44) %Itemname = "<l i='105109321 ' t='itemid'/>";
	else if (%Level <= 59) %Itemname = "<l i='105109322 ' t='itemid'/>";
	else if (%Level <= 74) %Itemname = "<l i='105109323 ' t='itemid'/>";
	else if (%Level <= 89) %Itemname = "<l i='105109324 ' t='itemid'/>";
	else  %Itemname = "<l i='105109325 ' t='itemid'/>";

	$Activity_Purpose_text[21] = "<t>落日神陵的万年寒冰下方，有一地下宫殿，镇封了无数尸魔，击败尸魔，就有机会获得其生前所习战技。</t>";
	getplayer().ClearMissionItem(21);
	getplayer().AddItemToMission(21,1,105100268,1);

	$Activity_Details_text[21] = "<t>在落日神陵2层，有一尸卫镇守着地下宫殿入口，击败尸卫，镇魔殿的入口将会显现。</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	入口：</t>" @ $Get_Dialog_GeShi[31426] @ "	落日神陵	</t>" @ Getfindpath(411180001,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	6小时开启一次</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	等级：</t>" @ $Get_Dialog_GeShi[31426] @ "	最低40级可进入</t><b/>"@
		$Get_Dialog_GeShi[31426] @ "	       建议60级以上前往</t><b/>"@
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	不限（建议多人组队）</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(21) @ "<b/>";
	$Active_PathToDes[21] = "CloseActivityWnd();findpath(410010104);";
	//-------------------------------------------------------------
	//-----------------------------云罗镜----------------------------
	$SL_HuoDong_Actmsg[22] = "40 1";//可见等级 活动类型(1 2 3)
	$active_lv_text_[22] = "等级:" @ GetWord($SL_HuoDong_Actmsg[22],0);
	$active_name_text_[22] = "云罗镜";
	$active_curnum_text_[22]= GetSrc(GetPlayer(),191) @ "/1";
	$active_time_text_[22] = "时间：不限";
	$active_team_text_[22]= "人数：6人以上";
	$active_type_bmp_[22] ="gameres/gui/images/activetype_5.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[22] = "gameres/gui/images/ActivityTypeBmp_022.png";//底图 	1道具	2地宫	3经验	4世界

	%Level = GetPlayer().GetLevel();
	if (%Level <= 44) %Itemname = "<l i='105109321 ' t='itemid'/>";
	else if (%Level <= 44) %Itemname = "<l i='105109321 ' t='itemid'/>";
	else if (%Level <= 59) %Itemname = "<l i='105109322 ' t='itemid'/>";
	else if (%Level <= 74) %Itemname = "<l i='105109323 ' t='itemid'/>";
	else if (%Level <= 89) %Itemname = "<l i='105109324 ' t='itemid'/>";
	else  %Itemname = "<l i='105109325 ' t='itemid'/>";

	$Activity_Purpose_text[22] = "<t>昆仑有一奇异空间，名为云罗境，内有神秘祭坛，可召唤异域强者降临。</t>";
	getplayer().ClearMissionItem(22);
	getplayer().AddItemToMission(22,1,105100268,1);

	$Activity_Details_text[22] = "<t>帮派使者左正文，掌控着此处空间的入口。各大帮主，可携带帮众前去挑战云罗教主，战胜教主后可获得教主宝藏。</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	入口：</t>" @ $Get_Dialog_GeShi[31426] @ "	昆仑	</t>" @ Getfindpath(410010107,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	不限</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	等级：</t>" @ $Get_Dialog_GeShi[31426] @ "	最低40级可进入</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	6人以上</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(22) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	只有帮主才可以开启副本挑战，只有帮派成员才可以进入此副本。</t>";
	$Active_PathToDes[22] = "CloseActivityWnd();findpath(410010107);";
	//-------------------------------------------------------------
	//-----------------------------封神秘境----------------------------
	$SL_HuoDong_Actmsg[23] = "35 1";//可见等级 活动类型(1 2 3)
	$active_lv_text_[23] = "等级:" @ GetWord($SL_HuoDong_Actmsg[23], 0);
	$active_name_text_[23] = "封神秘境";
	$active_curnum_text_[23] = GetAct(getplayer(), 4103, 0) * 1 @ "/1";
	$active_time_text_[23] = "时间：不限";
	$active_team_text_[23] = "人数：3人以上";
	$active_type_bmp_[23] = "gameres/gui/images/activetype_1.png";// 1  道具活动 2  经验活动 3地宫首领 4世界首领
	$CreateActivityBmp_[23] = "gameres/gui/images/ActivityTypeBmp_022.png";//底图 	1道具	2地宫	3经验	4世界

	%Level = getplayer().GetLevel();
	%Level = mfloor(%Level / 10);
	if (%Level < 40)
		%level = 40;
	switch (%level)
	{
	case 40:%itemid = 105100273;//紫色装备(40 - 49级)
	case 40:%itemid = 105100275;//紫色装备(50 - 59级)
	case 40:%itemid = 105100277;//紫色装备(60 - 69级)
	case 40:%itemid = 105100279;//紫色装备(70 - 79级)
	case 40:%itemid = 105100281;//紫色装备(80 - 89级)
	case 40:%itemid = 105100283;//紫色装备(90 - 99级)
	default:%itemid = 1051002831;//
	}

	$Activity_Purpose_text[23] = "<t>封神演义登云台，花落诸门到谁家。</t>";
	getplayer().ClearMissionItem(23);
	getplayer().AddItemToMission(23, 1, %itemid, 1);

	$Activity_Details_text[23] = "<t>35级以上修士组建队伍，与昆仑城的天师对话即可进入封神秘境，击杀副本内怪物有几率获得紫色装备。精英怪物的掉率是普通怪物的五倍，首领必定掉落相当于队伍人数的紫装。</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	入口：</t>" @ $Get_Dialog_GeShi[31426] @ "	昆仑	</t>" @ Getfindpath(413180001, 0, 0, 31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	时间：</t>" @ $Get_Dialog_GeShi[31426] @ "	不限</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	等级：</t>" @ $Get_Dialog_GeShi[31426] @ "	35级</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	人数：</t>" @ $Get_Dialog_GeShi[31426] @ "	建议3人以上</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	奖励：</t><b/>" @ GetFixedMissionItemText(23) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	如果是帮派成员，击败副本首领后，额外获得帮派活跃奖励。</t>";
	$Active_PathToDes[23] = "CloseActivityWnd();findpath(413180001);";
	//-------------------------------------------------------------
}

//■■■■【活动大全系统】■■■■■全局变量存放■■■■■■■■■■■



//■■■■【活动大全系统】■■■■■收到服务端开关配置■■■■■■■■
//Getallactivitybactive("1 1 1 1 1" @ " 1 1 1 1 1 1 -1 1 1 1 1 -1 1 1 1 1 -1 1 1 1 1 1 1 -1 1");
function Getallactivitybactive(%type)
{
	//echo( "%type=======" @ %type );
	$SL_HuoDong = %type;
	GetActivitytext();
	//echo( "$SL_HuoDong========================" @ $SL_HuoDong );
	$SL_HuoDong[1]="";
	$SL_HuoDong[2]="";
	$SL_HuoDong[3]="";
	$SL_HuoDong_Lvjudg[1]="";
	$SL_HuoDong_Lvjudg[2]="";
	$SL_HuoDong_Lvjudg[3]="";
	%Count = getwordcount(%type);
	%Level = GetPlayer().getlevel();
	for (%i = 0; %i < %Count; %i++)
	{
		%bActive = GetWord(%type,%i);
		if (%bActive $= "-1")
			continue;
		if (%i == 4)//BOSS，单独处理
		{
			for (%j = 1; %j <= 99; %j++)
			{
				if ($SL_HuoDong_Boss[%j] $= "")
					break;
				if (GetWord($SL_HuoDong_Boss[%j],1) $= "9999")
					continue;
				$SL_HuoDong[3] = %j @ " " @ $SL_HuoDong[3];
				$SL_HuoDong_Lvjudg[3] = %j @ " " @ $SL_HuoDong_Lvjudg[3];
			}
		}
		else
		{
			%SL_level  = getword($SL_HuoDong_Actmsg[%i + 1],0);
			%SL_type  = getword($SL_HuoDong_Actmsg[%i + 1],1);

			if (%SL_level != 9999)
				$SL_HuoDong[%SL_type] = %i + 1 @ " " @ $SL_HuoDong[%SL_type];

			if (%bActive $= "1" && %Level >= %SL_level - 10)
				$SL_HuoDong_Lvjudg[%SL_type] = %i + 1 @ " " @ $SL_HuoDong_Lvjudg[%SL_type];

		}
	}

	//------------------排序一下--------------------
	//echo( "$SL_HuoDong[ 1 ] ==" @ $SL_HuoDong[ 1 ] );
	//echo( "$SL_HuoDong[ 2 ] ==" @ $SL_HuoDong[ 2 ] );
	//echo( "$SL_HuoDong[ 3 ] ==" @ $SL_HuoDong[ 3 ] );

	//echo( "$SL_HuoDong_Lvjudg[ 1 ] ==" @ $SL_HuoDong_Lvjudg[ 1 ] );
	//echo( "$SL_HuoDong_Lvjudg[ 2 ] ==" @ $SL_HuoDong_Lvjudg[ 2 ] );
	//echo( "$SL_HuoDong_Lvjudg[ 3 ] ==" @ $SL_HuoDong_Lvjudg[ 3 ] );
	//echo( "----------------换算后------------------------" );
	//接下来开始排序
	for (%i=1; %i<=2; %i++)
	{
		//-------------所有活动------------------
		%count = getwordcount($SL_HuoDong[%i]);
		//echo( "%i===" @ %i @ "  %count==="@ %count );
		for (%x=0; %x < %count; %x++)
		{
			%iact[%x] = getword($SL_HuoDong[%i],%x);
			//echo( "%iact[ " @ %x @ " ]===" @ %iact[ %x ] );
		}

		//echo( "====" @ %iact[ 1 ] @ "=========" );
		for (%j=0; %j < %count - 1; %j++)
		{
			for (%a = %j +1; %a < %count; %a++)
			{
				//echo( "getword( $SL_HuoDong_Actmsg[ %iact[ %x ] ] ==" @ getword( $SL_HuoDong_Actmsg[ %iact[ %x ] ],0) @ "------------getword( $SL_HuoDong_Actmsg[ %iact[ %a ] ]==" @ getword( $SL_HuoDong_Actmsg[ %iact[ %a ] ] ,0));
				//echo( "$SL_HuoDong_Actmsg[ " @ %iact[ %j ] @ "]===" @ $SL_HuoDong_Actmsg[ %iact[ %j ] ] );
				if (getword($SL_HuoDong_Actmsg[%iact[%j]],0) < getword($SL_HuoDong_Actmsg[%iact[%a]],0))
				{
					//echo( $SL_HuoDong_Actmsg[ %iact[ %j ] ] @ "-------------" @  $SL_HuoDong_Actmsg[ %iact[ %a ] ] );
					%key = %iact[%j];
					%iact[%j] = %iact[%a];
					%iact[%a] = %key;
				}
			}
		}

		for (%x=0; %x < %count; %x++)
		{
			%iacthuodong[%i] = %iact[%x] @ " " @ %iacthuodong[%i];
			//echo( "%iacthuodong[ " @ %i @ "]==" @ %iacthuodong[ %i ] );
		}

		//echo( "====" @ %iact[ 1 ] @ "=========" );
		$SL_HuoDong[%i] = %iacthuodong[%i];

		//echo( "$SL_HuoDong[ " @ %i @ "]===" @ $SL_HuoDong[ %i ] );
		//---------------可参与的活动-----------------
		%count = getwordcount($SL_HuoDong_Lvjudg[%i]);

		//echo( "%i===" @ %i @ "  %count==="@ %count );
		for (%x=0; %x < %count; %x++)
		{
			%iact[%x] = getword($SL_HuoDong_Lvjudg[%i],%x);
		}

		for (%j=0; %j < %count - 1; %j++)
		{
			for (%a = %j +1; %a < %count; %a++)
			{
				if (getword($SL_HuoDong_Actmsg[%iact[%j]],0) < getword($SL_HuoDong_Actmsg[%iact[%a]],0))
				{
					%key = %iact[%j];
					%iact[%j] = %iact[%a];
					%iact[%a] = %key;
				}
			}
		}

		for (%x=0; %x < %count; %x++)
		{
			%iacthuodonglvjudge[%i] = %iact[%x] @ " " @ %iacthuodonglvjudge[%i];
		}
		$SL_HuoDong_Lvjudg[%i] = %iacthuodonglvjudge[%i];

		//echo( "$SL_HuoDong_Lvjudg[ " @ %i @ "]===" @ $SL_HuoDong_Lvjudg[ %i ] );
	}

	//-------------------BOSS的排序------------------
	%count = getwordcount($SL_HuoDong[3]);
	for (%x=0; %x < %count; %x++)
	{
		%iact[%x] = getword($SL_HuoDong[3],%x);
	}

	for (%j=0; %j < %count - 1; %j++)
	{
		for (%a = %j +1; %a < %count; %a++)
		{
			if (getword($SL_HuoDong_Boss[%iact[%j]],1) < getword($SL_HuoDong_Boss[%iact[%a]],1))
			{
				%key = %iact[%j];
				%iact[%j] = %iact[%a];
				%iact[%a] = %key;
			}
		}
	}

	for (%x=0; %x < %count; %x++)
	{
		%iacthuodongboss[3] = %iact[%x] @ " " @ %iacthuodongboss[3];
	}
	$SL_HuoDong_Lvjudg[3] = $SL_HuoDong[3] = %iacthuodongboss[3];
	//echo( "$SL_HuoDong_Lvjudg[ 3 ] ==" @ $SL_HuoDong_Lvjudg[ 3 ] );
	//echo( "$SL_HuoDong ==" @ $SL_HuoDong );
	//echo( "$SL_HuoDong[ 1 ] ==" @ $SL_HuoDong[ 1 ] );
	//echo( "$SL_HuoDong[ 2 ] ==" @ $SL_HuoDong[ 2 ] );
	//echo( "$SL_HuoDong[ 3 ] ==" @ $SL_HuoDong[ 3 ] );

	//echo( "$SL_HuoDong_Lvjudg[ 1 ] ==" @ $SL_HuoDong_Lvjudg[ 1 ] );
	//echo( "$SL_HuoDong_Lvjudg[ 2 ] ==" @ $SL_HuoDong_Lvjudg[ 2 ] );
	//echo( "$SL_HuoDong_Lvjudg[ 3 ] ==" @ $SL_HuoDong_Lvjudg[ 3 ] );
	//---------------刷新界面-------------------------------
	ShowBtnActivityMessage(getwordcount($SL_HuoDong[1]),1,0);
	ShowBtnActivityMessage(getwordcount($SL_HuoDong[2]),2,0);
	ShowBtnActivityMessage(getwordcount($SL_HuoDong[3]),3,0);
}
//■■■■【活动大全系统】■■■■■收到服务端开关配置■■■■■■■■

//■■■■【活动大全系统】■■■■■活动总数量计算■■■■■■■■■■
function GetActivityNumByType(%type,%litState)
{
	//echo( "%type ==" @ %type );
	//echo( "%litState ==" @ %litState );
	if (%litState == 1)
		eval("%str = $SL_HuoDong_Lvjudg[" @ %type @ "];");
	else
		eval("%str = $SL_HuoDong[" @ %type @ "];");

	//echo( " %str===" @  %str );
	return getwordcount(%str);
}

//■■■■【活动大全系统】■■■■■活动总数量计算■■■■■■■■■■



//■■■■【活动大全系统】■■■■■活动文本显示■■■■■■■■■■■
function ShowBtnActivityMessage(%num,%type,%litState)
{
	//echo( "%num ==" @ %num  @ "   %type===" @ %type  @ "  %litState===" @ %litState @ "   $SL_HuoDong==" @ $SL_HuoDong );

	GetActivitytext();//重新刷新全局变量，防止错误

	if (%litState == 1)
		eval("%str = $SL_HuoDong_Lvjudg[" @ %type @ "];");
	else
		eval("%str = $SL_HuoDong[" @ %type @ "];");

	if (%num  == 0)
		%num = Getwordcount(%str);
	switch (%type)
	{
		case 3:
			for (%i=0; %i< %num; %i++)
			{
				%Active = 5;
				%iid = getword(%str,%i);
				//echo( "%iid====" @ %iid  @ "      " @  $active_time_text_[ %Active, %iid ] );
				("active_lv_text_" @ %i).settext($active_lv_text_[%Active,%iid]);
				("active_name_text_" @ %i).SetContent("<t m='0' f='黑体' n='20' gct='0xffffffff' gcb='0x1FA6F3ff'>" @ $active_name_text_[%Active,%iid] @ "</t>");
				("active_curnum_text_" @ %i).settext($active_curnum_text_[%Active,%iid]);
				("active_time_text_" @ %i).settext($active_time_text_[%Active,%iid]);
				("active_team_text_" @ %i).settext($active_team_text_[%Active,%iid]);
				("active_type_bmp_" @ %i).setbitmap($active_type_bmp_[%Active,%iid]);
				("CreateActivityBmp_" @ %i).setbitmap($CreateActivityBmp_[%Active,%iid]);
			}
		default:
			//echo( "%str==" @ %str );
			for (%i=0; %i<%num; %i++)
			{
				%Active = GetWord(%str,%i);
				//echo( "%Active===" @ %Active );
				//echo( "$active_name_text_[ %Active, %iid ]==" @ $active_name_text_[ %Active, %iid ] );
				("active_lv_text_" @ %i).settext($active_lv_text_[%Active]);
				("active_name_text_" @ %i).SetContent("<t m='0' f='黑体' n='20' gct='0xffffffff' gcb='0x1FA6F3ff'>" @ $active_name_text_[%Active] @ "</t>");
				("active_curnum_text_" @ %i).settext($active_curnum_text_[%Active]);
				("active_time_text_" @ %i).settext($active_time_text_[%Active]);
				("active_team_text_" @ %i).settext($active_team_text_[%Active]);
				("active_type_bmp_" @ %i).setbitmap($active_type_bmp_[%Active]);
				("CreateActivityBmp_" @ %i).setbitmap($CreateActivityBmp_[%Active]);
			}
	}
	SetDetailsContent(%type,0);
}

function SetDetailsContent(%type,%i)
{
	//echo( "%type===" @ %type  @ "  %i===" @ %i );
	switch (%type)
	{
		case 3:
			eval("%str = $SL_HuoDong[" @ %type @ "];");
			%Active = GetWord(%str,%i);

			Activity_Purpose_text.setcontent($Get_Dialog_GeShi[31428] @ $Activity_Purpose_text[5,%Active] @ "</t>");
			Activity_Details_text.setcontent($Get_Dialog_GeShi[31428] @ $Activity_Details_text[5,%Active] @ "</t>");
			//Active_PathToDes.Command = $Active_PathToDes[ 5, %i + 1 ] ;
			Active_PathToDes.setvisible(0);
		default:
			if (LimitedActivelySelect.IsStateOn())
				eval("%str = $SL_HuoDong_Lvjudg[" @ %type @ "];");
			else
				eval("%str = $SL_HuoDong[" @ %type @ "];");
			//echo( "%str====" @ %str );
			%Active = GetWord(%str,%i);
			Activity_Purpose_text.setcontent($Get_Dialog_GeShi[31428] @ $Activity_Purpose_text[%Active] @ "</t>");
			Activity_Details_text.setcontent($Get_Dialog_GeShi[31428] @ $Activity_Details_text[%Active] @ "</t>");
			//Active_PathToDes.Command( $Active_PathToDes[ %i ] );
			Active_PathToDes.setvisible(1);
			Active_PathToDes.Command = $Active_PathToDes[%Active];
	}
}
//■■■■【活动大全系统】■■■■■活动文本显示■■■■■■■■■■■
