//==================================================================================
//服务端所有的脚本入口，只存脚本加载路径的添加，每添加一个脚本，均需注明脚本的大致内容
//
//
//本处加载的脚本，所有地图服务器均会载入
//==================================================================================

//■■■■■任务道具绑定寻径变量■■■■■■■■■■■■■■■■■■■■■■■■
//■■■■■任务相关名称■■■■■■■■■■■■■■■■■■■■■■■■■■■■
//■■■■■图标变量■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
//■■■■■活动说明■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
//■■■■■西天取经对白■■■■■■■■■■■■■■■■■■■■■■■■■■■■
//■■■■■副本中显示BOSS信息和玩家成就时所用的全局变量■■■■■■■■■■■■

//■■■■■任务道具绑定寻径变量■■■■■■■■■■■■■■■■■■■■■■■■
//填写规则：

$Item_Monster[108021006] = "411020020"; //挖矿心得
$Item_Monster[108021007] = "410100053"; //伐木心得
$Item_Monster[108021008] = "410100002"; //采药心得
$Item_Monster[108021009] = "411010003"; //钓鱼心得
$Item_Monster[108021010] = "410010116"; //铸造心得
$Item_Monster[108021011] = "410010117"; //裁缝心得
$Item_Monster[108021012] = "410010118"; //制器心得
$Item_Monster[108021013] = "410010115"; //炼丹心得
$Item_Monster[108021014] = "410010119"; //符咒心得
$Item_Monster[108021015] = "410010140"; //烹饪心得
$Item_Monster[108021016] = "410010111"; //白纸
$Item_Monster[108021018] = "410101015"; //树心
$Item_Monster[106070101] = "410010116"; //助融剂
$Item_Monster[106070201] = "410010116"; //池水
$Item_Monster[106070111] = "410010117"; //檀木卷
$Item_Monster[106070211] = "410010117"; //粗线
$Item_Monster[106070121] = "410010118"; //砂纸
$Item_Monster[106070141] = "410010115"; //药瓶
$Item_Monster[106070151] = "410010140"; //调料
$Item_Monster[108020994] = "410100009"; //百丈蚕丝
$Item_Monster[108020995] = "410100009"; //灵兽卵
$Item_Monster[108020996] = "410100009"; //补兽笼
$Item_Monster[108020997] = "410100009"; //千年温玉
$Item_Monster[108020998] = "410100009"; //铁木
$Item_Monster[108020999] = "410100009"; //玄星石
$Item_Monster[108021000] = "410100009"; //玄海冰魄
$Item_Monster[410101020] = "410100006";
$Item_Monster[444444451] = "811280202";//陨仙窟二层
$Item_Monster[444444448] = "410100001";//师门尽忠
$Item_Monster[444444445] = "410010121";//强化装备
$Item_Monster[444444446] = "410010122";//鉴定装备
$Item_Monster[444444455] = "810010103";//苍山雪海
$Item_Monster[444444456] = "410010111";//矿锄
$Item_Monster[444444457] = "410010111";//伐斧
$Item_Monster[444444458] = "410010111";//镰刀
$Item_Monster[444444459] = "410010111";//渔杆
$Item_Monster[444444460] = "811020103";//封剑台
$Item_Monster[108020028] = "411011003";//虎皮
$Item_Monster[108020029] = "411011004";//狐皮
$Item_Monster[108021020] = "411011004";//狂躁狐内丹
$Item_Monster[108020102] = "411011003";//虎骨
$Item_Monster[108020103] = "411011004";//狐血
$Item_Monster[108020105] = "411011001";//枯树干
$Item_Monster[108020110] = "411011003";//虎皮
$Item_Monster[108020112] = "411011003";//虎筋
$Item_Monster[108020113] = "411011001";//树枝
$Item_Monster[108020114] = "411011005";//白狐皮
$Item_Monster[108020117] = "411011005";//白狐尾
$Item_Monster[108020118] = "411011008";//鳄鱼尾
$Item_Monster[108020119] = "411011012";//狐内丹
$Item_Monster[108020122] = "411011002";//花根
$Item_Monster[108020123] = "411011008";//铁齿
$Item_Monster[108020124] = "411011009";//铁丹
$Item_Monster[108020126] = "411011009";//鳄鱼腿
$Item_Monster[108020127] = "411011010";//沙石铠甲
$Item_Monster[108020128] = "411011006";//蚊子翅膀
$Item_Monster[108020131] = "411011002";//花瓣
$Item_Monster[108020012] = "411011002";//花粉
$Item_Monster[108020017] = "410100054";//令牌
$Item_Monster[108020020] = "410101004";//螃蟹
$Item_Monster[108020162] = "410101004";//遗失之物
$Item_Monster[108020022] = "411011001";//柴火
$Item_Monster[108020030] = "411281004";//蛇胆
$Item_Monster[108020034] = "411021004";//雪豹内丹
$Item_Monster[108020132] = "411021001";//傀儡之印
$Item_Monster[108020133] = "411021001";//傀儡之爪
$Item_Monster[108020134] = "411021001";//傀儡之角
$Item_Monster[108020135] = "411021001";//傀儡之牙
$Item_Monster[108020136] = "411021001";//傀儡之眼
$Item_Monster[108020137] = "411021002";//巫师杖
$Item_Monster[108020138] = "411021002";//巫师精魄
$Item_Monster[108020139] = "411021002";//乾坤囊
$Item_Monster[108020140] = "411021002";//巫师印
$Item_Monster[108020141] = "411021003";//野人头蛮
$Item_Monster[108020142] = "411021003";//野人毛发
$Item_Monster[108020143] = "411021004";//雪豹之尾
$Item_Monster[108020144] = "411021004";//雪豹獠牙
$Item_Monster[108020145] = "411021004";//雪豹之角
$Item_Monster[108020146] = "411021004";//雪豹毛皮
$Item_Monster[108020147] = "411021004";//雪豹之爪
$Item_Monster[108020148] = "411021004";//雪豹肉块
$Item_Monster[108020149] = "411021005";//剑灵精魂
$Item_Monster[108020150] = "411021005";//灵之剑气
$Item_Monster[108020151] = "411021005";//剑灵魂晶
$Item_Monster[108020177] = "411031003";//树精藤条
$Item_Monster[108020178] = "411031003";//树精灵果
$Item_Monster[108020179] = "411031001";//熊猫族刀
$Item_Monster[108020180] = "411031001";//熊猫族铠甲
$Item_Monster[108020181] = "411031001";//熊猫族斧
$Item_Monster[108020182] = "411031004";//蟾蜍皮
$Item_Monster[108020183] = "411031004";//蟾蜍腿
$Item_Monster[108020184] = "411031004";//蟾蜍气囊
$Item_Monster[108020185] = "411031006";//噬灵花根
$Item_Monster[108020186] = "411031006";//噬灵花瓣
$Item_Monster[108020187] = "411031006";//噬灵花蕊
$Item_Monster[108020188] = "411031006";//噬灵花叶
$Item_Monster[108020189] = "411031002";//木灵兽尾巴
$Item_Monster[108020190] = "411031002";//木灵兽之爪
$Item_Monster[108020191] = "411031002";//木灵兽之牙
$Item_Monster[108020192] = "411031005";//海鬣之壳
$Item_Monster[108020193] = "411031005";//海鬣之爪
$Item_Monster[108020194] = "411031005";//海鬣之鳍
$Item_Monster[108020195] = "411030010";//玉锦瓶

$Item_Monster[108030002] ="811280201";//地宫1怪物
$Item_Monster[108030003] ="811290101";//地宫2怪物
$Item_Monster[108030004] ="811300101";//地宫3怪物
$Item_Monster[108030005] ="811310101";//地宫4怪物
$Item_Monster[108030006] ="811320101";//地宫5怪物
$Item_Monster[108030007] ="811330101";//地宫6怪物
$Item_Monster[108030008] ="811340101";//地宫7怪物

$Item_Monster[108021005] = "552000001"; //采集药草
//例子：$Item_Monster[108020051] = "410700059";
//============↑=========↑===========↑============
//=========全局变量====道具编号====怪物编号：如有多个采用空格隔开=====
//Item_Monster 道具寻路
//Item_Text 文字提示
//Item_Button 按钮提示
//Monster_Monster 怪物寻路

$Item_Text[108020005] = "完成【冰火之珠·一】任务";
$Item_Text[440000018] = "请先达到指定位置使用唤妖铃";
$Item_Text[106020001] = "铜矿可在陨仙窟挖一级矿获得";
$Item_Text[106090001] = "粗麻可通过杀怪掉落";
$Item_Text[106040001] = "柳木木料可前往望仙谷伐木获得";
$Item_Text[106010201] = "紫草可前往望向采集一级草药获得";
$Item_Text[106030001] = "薄荷可通过杀怪掉落";
//$Item_Text[ 444444452 ] = "打开背包使用技能书学习技能";
$Item_Text[411011015] = "[云游隐士]皇埔奇行踪不定，有缘即可遇见";
$Item_Text[411010020] = "[云游隐士]皇埔奇行踪不定，有缘即可遇见";
$Item_Text[108030009] = "在野外、地宫等地图击败不低于自身10级的怪物";

$Item_Monster[411102023] = "553000203";//10136
$Item_Monster[108050503] = "553000177";//10137
$Item_Monster[108050504] = "411102001";//10138
$Item_Monster[108050505] = "553000178";//10139
$Item_Monster[108050506] = "411102002";//10140
$Item_Monster[108050507] = "411102002";//10141
$Item_Monster[108050508] = "553000179";//10142
$Item_Monster[108050509] = "411102007";//10143
$Item_Monster[108050510] = "553000180";//10144
$Item_Monster[108050511] = "411102009";//10145
$Item_Monster[108050512] = "411102009";//10146
$Item_Monster[108050530] = "553000182";//10148
$Item_Monster[108050514] = "553000183";//10149
$Item_Monster[108050515] = "411102008";//10152
$Item_Monster[108050518] = "553000184";//10155
$Item_Monster[108050519] = "401102033";//10156
$Item_Monster[108050520] = "553000185";//10157
$Item_Monster[108050522] = "553000189";//10163
$Item_Monster[108050524] = "411102003";//10165
$Item_Monster[108050525] = "553000190";//10167
$Item_Monster[108050526] = "553000191";//10167
$Item_Monster[108050527] = "553000192";//10167
$Item_Monster[411102025] = "401102012";//10170
$Item_Monster[108050529] = "553000194";//10171
$Item_Monster[108050531] = "401102015";//10173
$Item_Monster[108050533] = "401102012";//10175
$Item_Monster[108050534] = "411102003";//10176
$Item_Monster[108050535] = "553000196";//10177
$Item_Monster[108050537] = "401102004";//10178
$Item_Monster[108050539] = "411102005";//10180
$Item_Monster[108050540] = "553000197";//10181
$Item_Monster[108050541] = "553000199";//10182
$Item_Monster[108050542] = "411102022";//10184
$Item_Monster[411102026] = "553000198";//10187
$Item_Monster[411102027] = "553000198";//10187
$Item_Monster[108050546] = "411102021";//10190
$Item_Monster[108050547] = "553000202";//10191
$Item_Monster[108050548] = "411102014";//10196
$Item_Monster[108050549] = "411102015";//10197
$Item_Monster[108050550] = "411102016";//10198

$Item_Monster[108021017] = "552000036"; //玲珑珠
$Item_Monster[108020009] = "553000037"; //海蚌
$Item_Monster[108020011] = "553000038"; //蚕蛹
$Item_Monster[108020016] = "553000039"; //龙延草
$Item_Monster[108020015] = "553000040"; //佘兰草
$Item_Monster[108020101] = "553000018"; //枯木灵芝
$Item_Monster[108020104] = "553000019"; //柴火
$Item_Monster[108020107] = "553000023"; //野果
$Item_Monster[108020108] = "553000024"; //荷叶
$Item_Monster[108020109] = "553000025"; //珠子
$Item_Monster[108020111] = "553000026"; //针线
$Item_Monster[108020115] = "553000027"; //荷花
$Item_Monster[108020116] = "553000028"; //紫晶石
$Item_Monster[108020120] = "553000031"; //虎牙草
$Item_Monster[108020121] = "553000032"; //紫萱草
$Item_Monster[108020125] = "553000033"; //炉水
$Item_Monster[108020129] = "553000034"; //布匹
$Item_Monster[108020130] = "553000035"; //莲藕
$Item_Monster[108020021] = "553000045"; //凝魂草
$Item_Monster[108020023] = "553000046"; //水井
$Item_Monster[108020024] = "553000047"; //香樟叶
$Item_Monster[108020025] = "553000048"; //仙草
$Item_Monster[108020026] = "553000049"; //大鱼
$Item_Monster[108020032] = "552000017"; //遗失的首饰
$Item_Monster[108020033] = "552000018"; //寒冰草
$Item_Monster[108020152] = "552000022"; //岩松
$Item_Monster[108020153] = "552000023"; //雪松
$Item_Monster[108020154] = "552000024"; //灵晶
$Item_Monster[108020155] = "552000025"; //冰莲花
$Item_Monster[108020156] = "552000026"; //清冷液
$Item_Monster[108020157] = "552000027"; //柴火
$Item_Monster[108020158] = "552000030"; //雪绒草
$Item_Monster[108020159] = "552000032"; //寒葵草
$Item_Monster[108020160] = "552000033"; //遗失的护符
$Item_Monster[108020161] = "552000035"; //原石
$Item_Monster[108020163] = "552000037"; //青髓草
$Item_Monster[108020164] = "552000038"; //灵竹
$Item_Monster[108020165] = "552000039"; //蘑菇
$Item_Monster[108020166] = "552000040"; //灵泉
$Item_Monster[108020167] = "552000041"; //避水珍珠
$Item_Monster[108020168] = "552000042"; //海草
$Item_Monster[108020169] = "552000043"; //竹笋
$Item_Monster[108020170] = "552000046"; //竹叶
$Item_Monster[108020171] = "552000047"; //仙人掌
$Item_Monster[108020172] = "552000048"; //满天星
$Item_Monster[108020173] = "552000049"; //枯草
$Item_Monster[108020174] = "552000052"; //椰子
$Item_Monster[108020175] = "552000053"; //多肉植物
$Item_Monster[108020176] = "552000057"; //香芋



//■■■■■任务道具绑定寻径变量■■■■■■■■■■■■■■■■■■■■■■■■


//■■■■■任务相关名称■■■■■■■■■■■■■■■■■■■■■■■■■■■■

if ($Now_Script == 1)
{
	$MissionKind[0,1] = "〖门阀任务〗";	$MissionKind[0,2] = "门阀";	$MissionKind[0,3] = "阀";
	$MissionKind[1,1] = "〖主线任务〗";	$MissionKind[1,2] = "主线";	$MissionKind[1,3] = "主";
	$MissionKind[2,1] = "〖支线任务〗";	$MissionKind[2,2] = "支线";	$MissionKind[2,3] = "支";
	$MissionKind[3,1] = "〖循环任务〗";	$MissionKind[3,2] = "循环";	$MissionKind[3,3] = "循";
	$MissionKind[4,1] = "〖帮派任务〗";	$MissionKind[4,2] = "帮派";	$MissionKind[4,3] = "族";
	$MissionKind[5,1] = "〖功能指引〗";	$MissionKind[5,2] = "指引";	$MissionKind[5,3] = "引";
	$MissionKind[6,1] = "〖活动任务〗";	$MissionKind[6,2] = "活动";	$MissionKind[6,3] = "活";
	$MissionKind[7,1] = "〖每日任务〗";	$MissionKind[7,2] = "每日";	$MissionKind[7,3] = "常";
	$MissionKind[8,1] = "〖支线剧情〗";	$MissionKind[8,2] = "支线";	$MissionKind[8,3] = "支";
	$MissionKind[9,1] = "〖战场任务〗";	$MissionKind[9,2] = "战场";	$MissionKind[9,3] = "战";
	$MissionKind[10,1] = "〖史诗任务〗";	$MissionKind[10,2] = "史诗";	$MissionKind[10,3] = "史";
}
//■■■■■任务相关名称■■■■■■■■■■■■■■■■■■■■■■■■■■■■

//■■■■■图标变量■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
if ($Now_Script == 1)
{
	if (isFile("gameres/data/icon/function/accept.png")){ $Icon[1] = "<i s='gameres/data/icon/function/accept.png' pw='24' ph='24'/> "; }
	else{ $Icon[1] = ""; }//任务接受图标

	if (isFile("gameres/data/icon/function/finish.png")){ $Icon[2] = "<i s='gameres/data/icon/function/finish.png' pw='24' ph='24'/> "; }
	else{ $Icon[2] = ""; }//任务完成图标

	if (isFile("gameres/data/icon/function/business.png")){ $Icon[3] = "<i s='gameres/data/icon/function/business.png' pw='24' ph='24'/> "; }
	else{ $Icon[3] = ""; }//元宝商城图标

	if (isFile("gameres/data/icon/function/dialog.png")){ $Icon[4] = "<i s='gameres/data/icon/function/dialog.png' pw='24' ph='24'/> "; }
	else{ $Icon[4] = ""; }//对话图标

	if (isFile("gameres/data/icon/function/function.png")){ $Icon[5] = "<i s='gameres/data/icon/function/function.png' pw='24' ph='24'/> "; }
	else{ $Icon[5] = ""; }//功能图标

	if (isFile("gameres/data/icon/function/help.png")){ $Icon[6] = "<i s='gameres/data/icon/function/help.png' pw='24' ph='24'/> "; }
	else{ $Icon[6] = ""; }//帮助图标

	if (isFile("gameres/data/icon/function/repository.png")){ $Icon[7] = "<i s='gameres/data/icon/function/repository.png' pw='24' ph='24'/> "; }
	else{ $Icon[7] = ""; }//仓库图标

	if (isFile("gameres/data/icon/function/shop.png")){ $Icon[8] = "<i s='gameres/data/icon/function/shop.png' pw='24' ph='24'/> "; }
	else{ $Icon[8] = ""; }//商店图标

	if (isFile("gameres/data/icon/function/study.png")){ $Icon[9] = "<i s='gameres/data/icon/function/study.png' pw='24' ph='24'/> "; }
	else{ $Icon[9] = ""; }//学习图标

	if (isFile("gameres/data/icon/function/transport.png")){ $Icon[10] = "<i s='gameres/data/icon/function/transport.png' pw='24' ph='24'/> "; }
	else{ $Icon[10] = ""; }//传送图标

	if (isFile("gameres/data/icon/function/fly.png")){ $Icon[11] = "<i s='gameres/data/icon/function/fly.png' pw='24' ph='24'/> "; }
	else{ $Icon[11] = ""; }//飞行传送图标

	if (isFile("gameres/data/icon/function/unfinished.png")){ $Icon[12] = "<i s='gameres/data/icon/function/unfinished.png' pw='24' ph='24'/> "; }
	else{ $Icon[12] = ""; }//任务未完成图标

	if (isFile("gameres/data/icon/function/activity.png")){ $Icon[13] = "<i s='gameres/data/icon/function/activity.png' pw='24' ph='24'/> "; }
	else{ $Icon[13] = ""; }//活动相关图标

	if (isFile("gameres/data/icon/function/return.png")){ $Icon[14] = "<i s='gameres/data/icon/function/return.png' pw='24' ph='24'/> "; }
	else{ $Icon[14] = ""; }//返回图标

	if (isFile("gameres/data/icon/function/cannot_finish.png")){ $Icon[15] = "<i s='gameres/data/icon/function/cannot_finish.png' pw='24' ph='24'/> "; }
	else{ $Icon[15] = ""; }//任务未完成图标
	if (isFile("gameres/data/icon/function/finish.png")){ $Icon[16] = "<i s='gameres/data/icon/function/finish.png' pw='24' ph='24'/> "; }
	else{ $Icon[16] = ""; }//任务完成图标
	if (isFile("gameres/data/icon/function/lateral_minssion.png")){ $Icon[17] = "<i s='gameres/data/icon/function/lateral_minssion.png' pw='24' ph='24'/> "; }
	else{ $Icon[17] = ""; }//主线任务接受图标
	if (isFile("gameres/data/icon/function/chapter_mission.png")){ $Icon[18] = "<i s='gameres/data/icon/function/chapter_mission.png' pw='24' ph='24'/> "; }
	else{ $Icon[18] = ""; }//支线任务接受图标
	if (isFile("gameres/data/icon/function/Cyc_mission.png")){ $Icon[19] = "<i s='gameres/data/icon/function/Cyc_mission.png' pw='24' ph='24'/> "; }
	else{ $Icon[19] = ""; }//循环任务接受图标
	if (isFile("gameres/data/icon/function/dissatisfy_mission.png")){ $Icon[20] = "<i s='gameres/data/icon/function/dissatisfy_mission.png' pw='24' ph='24'/> "; }
	else{ $Icon[20] = ""; }//任务接受条件不足图标

	if (isFile("gameres/gui/images/GUIWindow35_1_041.png")){ $Icon[21] = "<i s='gameres/gui/images/GUIWindow35_1_041.png' pw='24' ph='24'/> "; }
	else{ $Icon[21] = ""; }//圣图标
	if (isFile("gameres/gui/images/GUIWindow35_1_042.png")){ $Icon[22] = "<i s='gameres/gui/images/GUIWindow35_1_042.png' pw='24' ph='24'/> "; }
	else{ $Icon[22] = ""; }//仙图标
	if (isFile("gameres/gui/images/GUIWindow35_1_043.png")){ $Icon[23] = "<i s='gameres/gui/images/GUIWindow35_1_043.png' pw='24' ph='24'/> "; }
	else{ $Icon[23] = ""; }//佛图标
	if (isFile("gameres/gui/images/GUIWindow35_1_044.png")){ $Icon[24] = "<i s='gameres/gui/images/GUIWindow35_1_044.png' pw='24' ph='24'/> "; }
	else{ $Icon[24] = ""; }//怪图标
	if (isFile("gameres/gui/images/GUIWindow35_1_045.png")){ $Icon[25] = "<i s='gameres/gui/images/GUIWindow35_1_045.png' pw='24' ph='24'/> "; }
	else{ $Icon[25] = ""; }//精图标
	if (isFile("gameres/gui/images/GUIWindow35_1_046.png")){ $Icon[26] = "<i s='gameres/gui/images/GUIWindow35_1_046.png' pw='24' ph='24'/> "; }
	else{ $Icon[26] = ""; }//妖图标
	if (isFile("gameres/gui/images/GUIWindow35_1_047.png")){ $Icon[27] = "<i s='gameres/gui/images/GUIWindow35_1_047.png' pw='24' ph='24'/> "; }
	else{ $Icon[27] = ""; }//鬼图标
	if (isFile("gameres/gui/images/GUIWindow35_1_048.png")){ $Icon[28] = "<i s='gameres/gui/images/GUIWindow35_1_048.png' pw='24' ph='24'/> "; }
	else{ $Icon[28] = ""; }//魔图标
	if (isFile("gameres/data/icon/function/marry.png")){ $Icon[29] = "<i s='gameres/data/icon/function/marry.png' pw='24' ph='24'/> "; }
	else{ $Icon[29] = ""; }//姻缘图标

	if (isFile("gameres/data/icon/function/Mission_1.png")){ $Icon[30] = "<i s='gameres/data/icon/function/Mission_1.png' pw='24' ph='24'/> "; }
	else{ $Icon[30] = ""; }//
	if (isFile("gameres/data/icon/function/Mission_2.png")){ $Icon[31] = "<i s='gameres/data/icon/function/Mission_2.png' pw='24' ph='24'/> "; }
	else{ $Icon[31] = ""; }//
	if (isFile("gameres/data/icon/function/Mission_3.png")){ $Icon[32] = "<i s='gameres/data/icon/function/Mission_3.png' pw='24' ph='24'/> "; }
	else{ $Icon[32] = ""; }//
	if (isFile("gameres/data/icon/function/Mission_4.png")){ $Icon[33] = "<i s='gameres/data/icon/function/Mission_4.png' pw='24' ph='24'/> "; }
	else{ $Icon[33] = ""; }//
	if (isFile("gameres/data/icon/function/Mission_5.png")){ $Icon[34] = "<i s='gameres/data/icon/function/Mission_5.png' pw='24' ph='24'/> "; }
	else{ $Icon[34] = ""; }//
	if (isFile("gameres/data/icon/function/Mission_6.png")){ $Icon[35] = "<i s='gameres/data/icon/function/Mission_6.png' pw='24' ph='24'/> "; }
	else{ $Icon[35] = ""; }//

	if (isFile("gameres/data/icon/function/divorce.png")){ $Icon[36] = "<i s='gameres/data/icon/function/divorce.png' pw='24' ph='24'/> "; }
	else{ $Icon[36] = ""; }//离婚图标
	if (isFile("gameres/data/icon/function/diploid.png")){ $Icon[37] = "<i s='gameres/data/icon/function/diploid.png' pw='24' ph='24'/> "; }
	else{ $Icon[37] = ""; }//双倍图标
	if (isFile("gameres/data/icon/function/copy.png")){ $Icon[38] = "<i s='gameres/data/icon/function/copy.png' pw='24' ph='24'/> "; }
	else{ $Icon[38] = ""; }//副本图标
	if (isFile("gameres/Data/icon/function/Unknow_1.png")) { $Icon[39] = "<i s='gameres/Data/icon/function/Unknow_1.png' pw='24' ph='24'/> "; }
	else{ $Icon[39] = ""; }//定位图标
	if (isFile("gameres/gui/images/GUIWindow30_1_018.png")){ $Icon[40] = "<i s='gameres/gui/images/GUIWindow35_1_151.png' pw='24' ph='24'/> "; }
	else{ $Icon[40] = ""; }//本圣地

	//任务追踪主界面显示的复选框
	if (isFile("gameres/Data/icon/function/mission_11.png")){ $Icon[41] = "<i s='gameres/Data/icon/function/mission_11.png' /> "; }
	else{ $Icon[41] = ""; }//任务追踪勾选

	if (isFile("gameres/gui/images/GUIWindow31_1_024.png")){ $Icon[81] = "<i s='gameres/gui/images/GUIWindow31_1_024.png' pw='24' ph='24'/> "; }
	else{ $Icon[81] = "金 </t>"; }//元宝
	if (isFile("gameres/gui/images/GUIWindow31_1_025.png")){ $Icon[82] = "<i s='gameres/gui/images/GUIWindow31_1_025.png' pw='24' ph='24'/> "; }
	else{ $Icon[82] = "银 </t>"; }//银元
	if (isFile("gameres/gui/images/GUIWindow31_1_026.png")){ $Icon[83] = "<i s='gameres/gui/images/GUIWindow31_1_026.png' pw='24' ph='24'/> "; }
	else{ $Icon[83] = "铜 </t>"; }//铜元

	if (isFile("gameres/gui/images/KLJGoldTradingWnd06.png")){ $Icon[85] = "<i s='gameres/gui/images/KLJGoldTradingWnd06.png' pw='20' ph='21'/> "; }
	else{ $Icon[85] = "金 </t>"; }//金币
	if (isFile("gameres/gui/images/KLJGoldTradingWnd08.png")){ $Icon[86] = "<i s='gameres/gui/images/KLJGoldTradingWnd08.png' pw='20' ph='21'/> "; }
	else{ $Icon[86] = "银 </t>"; }//银币
	if (isFile("gameres/gui/images/KLJGoldTradingWnd07.png")){ $Icon[87] = "<i s='gameres/gui/images/KLJGoldTradingWnd07.png' pw='20' ph='21'/> "; }
	else{ $Icon[87] = "铜 </t>"; }//铜币

	if (isFile("gameres/gui/images/GUIWindow41_1_008.png")){ $Icon[88] = "<i s='gameres/gui/images/GUIWindow41_1_008.png' pw='24' ph='24'/> "; }
	else{ $Icon[88] = "活动奖励</t>"; }//活动奖励
	if (isFile("gameres/gui/images/GUIWindow31_1_027.png")){ $Icon[89] = "<i s='gameres/gui/images/GUIWindow31_1_027.png' pw='24' ph='24'/> "; }
	else{ $Icon[89] = "元宝</t>"; }//活动奖励
	if (isFile("gameres/gui/images/GUIWindow31_1_031.png")){ $Icon[90] = "<i s='gameres/gui/images/GUIWindow31_1_031.png' pw='24' ph='24'/> "; }
	else{ $Icon[90] = "金币</t>"; }//活动奖励
	if (isFile("gameres/Data/icon/function/mission.png")){ $Icon[91] = "<i s='gameres/Data/icon/function/mission.png' pw='33' ph='14'/> "; }
	else{ $Icon[91] = "完成</t>"; }//完成

	if (isFile("gameres/gui/images/GUIWindow25_1_014.png")){ $Icon[92] = "<i s='gameres/gui/images/GUIWindow25_1_014.png' pw='24' ph='24'/> "; }
	else{ $Icon[92] = "任务开启 </t>"; }//任务开启
	if (isFile("gameres/gui/images/GUIWindow25_1_013.png")){ $Icon[93] = "<i s='gameres/gui/images/GUIWindow25_1_013.png' pw='24' ph='24'/> "; }
	else{ $Icon[93] = "活动奖励 </t>"; }//活动奖励
	if (isFile("gameres/gui/images/GUIWindow25_1_012.png")){ $Icon[94] = "<i s='gameres/gui/images/GUIWindow25_1_012.png' pw='24' ph='24'/> "; }
	else{ $Icon[94] = "活动明细 </t>"; }//活动明细
	if (isFile("gameres/gui/images/GUIWindow25_1_009.png")){ $Icon[95] = "<i s='gameres/gui/images/GUIWindow25_1_009.png' pw='24' ph='24'/> "; }
	else{ $Icon[95] = "任务难度 </t>"; }//任务难度

	if (isFile("gameres/gui/images/GUIWindow25_1_008.png")){ $Icon[96] = "<i s='gameres/gui/images/GUIWindow25_1_008.png' pw='80' ph='21'/> "; }
	else{ $Icon[96] = "任务完成</t>"; }//任务完成
	if (isFile("gameres/gui/images/GUIWindow25_1_007.png")){ $Icon[97] = "<i s='gameres/gui/images/GUIWindow25_1_007.png' pw='80' ph='21'/> "; }
	else{ $Icon[97] = "任务奖励</t>"; }//任务奖励
	if (isFile("gameres/gui/images/GUIWindow25_1_006.png")){ $Icon[98] = "<i s='gameres/gui/images/GUIWindow25_1_006.png' pw='80' ph='21'/> "; }
	else{ $Icon[98] = "任务目标</t>"; }//任务目标
	if (isFile("gameres/gui/images/GUIWindow25_1_005.png")){ $Icon[99] = "<i s='gameres/gui/images/GUIWindow25_1_005.png' pw='80' ph='21'/> "; }
	else{ $Icon[99] = "任务描述</t>"; }//任务描述

	if (isFile("gameres/Data/icon/function/new_NPC_1.png")){ $Icon[100] = "<i s='gameres/Data/icon/function/new_NPC_1.png' pw='24' ph='24'/> "; }
	else{ $Icon[100] = "任务奖励 </t>"; }//增大版任务奖励

	if (isFile("gameres/gui/images/orgactivitry_001.png")){ $Icon[101] = "<i s='gameres/gui/images/orgactivitry_001.png' pw='80' ph='21'/> "; }
	else{ $Icon[101] = "描 述 </t>"; }//帮派活动界面 描 述

	if (isFile("gameres/gui/images/orgactivitry_002.png")){ $Icon[102] = "<i s='gameres/gui/images/orgactivitry_002.png' pw='80' ph='21'/> "; }
	else{ $Icon[102] = "奖 励 </t>"; }//帮派活动界面 奖 励

	if (isFile("gameres/gui/images/orgactivitry_003.png")){ $Icon[103] = "<i s='gameres/gui/images/orgactivitry_003.png' pw='80' ph='21'/> "; }
	else{ $Icon[103] = "参 加 </t>"; }//帮派活动界面 参 加

	if (isFile("gameres/Data/icon/function/Mission_14.png")){ $Icon[200,1] = "<i s='gameres/Data/icon/function/Mission_14.png'/> "; }
	else{ $Icon[200,1] = "修理</t>"; }//修理
	if (isFile("gameres/Data/icon/function/Mission_14_1.png")){ $Icon[200,2] = "<i s='gameres/Data/icon/function/Mission_14_1.png'/> "; }
	else{ $Icon[200,2] = "修理</t>"; }//
	if (isFile("gameres/Data/icon/function/Mission_15.png")){ $Icon[201,1] = "<i s='gameres/Data/icon/function/Mission_15.png'/> "; }
	else{ $Icon[201,1] = "传送</t>"; }//传送
	if (isFile("gameres/Data/icon/function/Mission_15_1.png")){ $Icon[201,2] = "<i s='gameres/Data/icon/function/Mission_15_1.png'/> "; }
	else{ $Icon[201,2] = "传送</t>"; }//
	if (isFile("gameres/Data/icon/function/Mission_16.png")){ $Icon[202,1] = "<i s='gameres/Data/icon/function/Mission_16.png'/> "; }
	else{ $Icon[202,1] = "充能</t>"; }//充能
	if (isFile("gameres/Data/icon/function/Mission_16_1.png")){ $Icon[202,2] = "<i s='gameres/Data/icon/function/Mission_16_1.png'/> "; }
	else{ $Icon[202,2] = "充能</t>"; }//
	if (isFile("gameres/Data/icon/function/Mission_17.png")){ $Icon[203,1] = "<i s='gameres/Data/icon/function/Mission_17.png'/> "; }
	else{ $Icon[203,1] = "召唤</t>"; }//召唤
	if (isFile("gameres/Data/icon/function/Mission_17_1.png")){ $Icon[203,2] = "<i s='gameres/Data/icon/function/Mission_17_1.png'/> "; }
	else{ $Icon[203,2] = "召唤</t>"; }//
	if (isFile("gameres/Data/icon/function/Mission_18.png")){ $Icon[204,1] = "<i s='gameres/Data/icon/function/Mission_18.png'/> "; }
	else{ $Icon[204,1] = "抽奖</t>"; }//抽奖
	if (isFile("gameres/Data/icon/function/Mission_18_1.png")){ $Icon[204,2] = "<i s='gameres/Data/icon/function/Mission_18_1.png'/> "; }
	else{ $Icon[204,2] = "抽奖</t>"; }//
	if (isFile("gameres/Data/icon/function/Mission_19.png")){ $Icon[205,1] = "<i s='gameres/Data/icon/function/Mission_19.png'/> "; }
	else{ $Icon[205,1] = "进入</t>"; }//进入
	if (isFile("gameres/Data/icon/function/Mission_19_1.png")){ $Icon[205,2] = "<i s='gameres/Data/icon/function/Mission_19_1.png'/> "; }
	else{ $Icon[205,2] = "进入</t>"; }//
	if (isFile("gameres/Data/icon/function/Mission_8.png")){ $Icon[206,1] = "<i s='gameres/Data/icon/function/Mission_8.png'/> "; }
	else{ $Icon[206,1] = "领取</t>"; }//领取
	if (isFile("gameres/Data/icon/function/Mission_8_1.png")){ $Icon[206,2] = "<i s='gameres/Data/icon/function/Mission_8_1.png'/> "; }
	else{ $Icon[206,2] = "领取</t>"; }//
	if (isFile("gameres/Data/icon/function/Mission_20.png")){ $Icon[207,1] = "<i s='gameres/Data/icon/function/Mission_20.png'/> "; }
	else{ $Icon[207,1] = "查看</t>"; }//查看
	if (isFile("gameres/Data/icon/function/Mission_20_1.png")){ $Icon[207,2] = "<i s='gameres/Data/icon/function/Mission_20_1.png'/> "; }
	else{ $Icon[207,2] = "查看</t>"; }//
}
//■■■■■图标变量■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■

//■■■■■活动说明■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■


//■■■■■西天取经对白■■■■■■■■■■■■■■■■■■■■■■■■■■■■
if ($Now_Script == 1)
{
	$Xunx_Text[400001265,1] = "金麟岂是池中物，玄武天变蛟化龙";											$Xunx_Text[400001265,2] ="贞观始，千秋传，万古圣君治长安";
	$Xunx_Text[400001266,1] = "秀鸾刀，桃花马，刀枪不入红莲花";											$Xunx_Text[400001266,2] ="巾帼命，须眉心，金戈铁马娘子军";
	$Xunx_Text[400001267,1] = "驸马爷，将门子，凌烟阁内一十四";											$Xunx_Text[400001267,2] ="胡琵琶，美人计，妙招连挫鲜卑敌";
	$Xunx_Text[400001269,1] = "用兵如神赛孙子，智勇两全卫国公";											$Xunx_Text[400001269,2] ="卫国公，智勇全，凌烟阁内居第八";
	$Xunx_Text[400001270,1] = "珍珑美貌倾天下，红拂歌伎智无双";											$Xunx_Text[400001270,2] ="风尘三侠名传四海，美貌歌伎机智无双";
	$Xunx_Text[400001271,1] = "秦王幕僚何人首，十八学士杜尚书";											$Xunx_Text[400001271,2] ="杜宰相，蔡国公，凌烟阁内居第三";
	$Xunx_Text[400001272,1] = "凶名赫赫三板斧，混世魔王程知节";											$Xunx_Text[400001272,2] ="卢国公，三板斧，凌烟阁内一十九";
	$Xunx_Text[401302001,1] = "黑炭面，鄂国公，凌烟阁内居第七";											$Xunx_Text[401302001,2] ="敬德黑面千古传，中华门神保平安";
	$Xunx_Text[400001274,1] = "齐王梦断时空裂痕，尉迟刀下作亡魂";											$Xunx_Text[400001274,2] ="窦后四子号齐王，时空裂痕内赴黄泉";
	$Xunx_Text[400001277,1] = "本是同根生，相煎何太急，若为江山故，一箭命呜呼";			$Xunx_Text[400001277,2] ="太子高枕本无忧，咄咄逼人自掘坟";
	$Xunx_Text[400001288,1] = "神拳太保小孟尝，双锏门神佑四方";											$Xunx_Text[400001288,2] ="护国公，字叔宝，凌烟阁内二十四";
	$Xunx_Text[400001289,1] = "英国公，名李勣，凌烟阁内二十三";											$Xunx_Text[400001289,2] ="三朝帝君皆倚重，有勇有谋玲珑心";
	$Xunx_Text[400001291,1] = "子承父贪，轻薄公子弑君妄称帝";   										  $Xunx_Text[400001291,2] ="多行不义必自毙，突厥遗首恨难息";
	$Xunx_Text[400001293,1] = "手持凤翅镏金镗，胯下赤炭火龙驹";											$Xunx_Text[400001293,2] ="南北战，东西伐，马前不走三合将";

	$Xunx_Text[401002137,1] = "雄才伟略第一刀，天资纵人宋逍遥";											$Xunx_Text[401002137,2] = "天刀无瑕十全美，岭南阀主怎无缺";
	$Xunx_Text[401002138,1] = "手持井中月，背负刺日弓，巧遇长生诀，立志平天下";			$Xunx_Text[401002138,2] = "红颜知己李秀宁，金屋藏娇宋玉致";
	$Xunx_Text[401002139,1] = "与仲齐名曰双龙，翩翩若仙不凡俗";											$Xunx_Text[401002139,2] = "凡俗是非几多愁，愿携青璇隐无忧";
	$Xunx_Text[401002140,1] = "宋家千金情窦开，不见仲郎难心安";											$Xunx_Text[401002140,2] = "谁家千金出芙蓉，七巧玲珑如玉致";
	$Xunx_Text[401002142,1] = "佛心大悲，慈航普度，弃身只为众生苦";									$Xunx_Text[401002142,2] = "心似磐石意如山，只把徐郎剑下伤";
	$Xunx_Text[401002143,1] = "恨连绵，情难了，愿与子陵共逍遥";											$Xunx_Text[401002143,2] = "一生，一世，爱你恨你";
	$Xunx_Text[401002144,1] = "幻影剑法独步天下，剑走偏锋";												  $Xunx_Text[401002144,2] = "杨坚之孙，杨勇之子，石之轩之徒";
	$Xunx_Text[401002156,1] = "枣阳槊，乌龙驹，赤发灵官单将军";											$Xunx_Text[401002156,2] = "骁勇飞将刺秦王，尉迟马前饮恨空";
	$Xunx_Text[401002157,1] = "白龙马，神飞枪，第七好汉罗公子";											$Xunx_Text[401002157,2] = "俏小生，罗家郎，第七好汉擅使枪";
	$Xunx_Text[401002158,1] = "不齿行满率众投唐，士信拒降头断河东";									$Xunx_Text[401002158,2] = "少年士信甚勇武，割鼻报功头一遭";
	$Xunx_Text[401002159,1] = "宋阀世子悯天人，专情如一好儿郎";											$Xunx_Text[401002159,2] = "梦中人，难厮守，宋家郎，心不忘";
	$Xunx_Text[401305002,1] = "神勇无匹斩宇文成都，骁勇善战破十八反王";							$Xunx_Text[401305002,2] = "四明山上脚一踏八方臣服，举锤骂天却不想英年早逝";
}
//■■■■■西天取经对白■■■■■■■■■■■■■■■■■■■■■■■■■■■■


//■■■■■副本中显示BOSS信息和玩家成就时所用的全局变量■■■■■■■■■■■■
//三打瓦岗寨
$ChengJiu_BossID[1311,1] = 411311001; $ChengJiu_BossName[1311,1] = "第1关『丁彦平』"; $ChengJiu_BossInfo[1311,1] = 60000;
$ChengJiu_BossID[1311,2] = 411311003; $ChengJiu_BossName[1311,2] = "第2关『魏文通』"; $ChengJiu_BossInfo[1311,2] = 60001;
$ChengJiu_BossID[1311,3] = 411311005; $ChengJiu_BossName[1311,3] = "第3关『裴元庆』"; $ChengJiu_BossInfo[1311,3] = 60002;
$ChengJiu_BossID[1311,4] = 411311024; $ChengJiu_BossName[1311,4] = "第4关『杨林』"; $ChengJiu_BossInfo[1311,4] = 60003;

//虎牢关之战
$ChengJiu_BossID[1312,1] = 411312038; $ChengJiu_BossName[1312,1] = "第1关『孟海公』"; $ChengJiu_BossInfo[1312,1] = 60004;
$ChengJiu_BossID[1312,2] = 411312018; $ChengJiu_BossName[1312,2] = "第2关『王世充』"; $ChengJiu_BossInfo[1312,2] = 60005;
$ChengJiu_BossID[1312,3] = 411312019; $ChengJiu_BossName[1312,3] = "第3关『单雄信』"; $ChengJiu_BossInfo[1312,3] = 60006;
$ChengJiu_BossID[1312,4] = 411312020; $ChengJiu_BossName[1312,4] = "第4关『窦建德』"; $ChengJiu_BossInfo[1312,4] = 60007;

//中日第一战
$ChengJiu_BossID[1313,1] = 411330005; $ChengJiu_BossName[1313,1] = "第1关『村上龙一郎』"; $ChengJiu_BossInfo[1313,1] = 60008;
$ChengJiu_BossID[1313,2] = 411330014; $ChengJiu_BossName[1313,2] = "第2关『神川岛刚』"; $ChengJiu_BossInfo[1313,2] = 60009;
$ChengJiu_BossID[1313,3] = 411330023; $ChengJiu_BossName[1313,3] = "第3关『泰阴冥蛇』"; $ChengJiu_BossInfo[1313,3] = 60010;
$ChengJiu_BossID[1313,4] = 411330024; $ChengJiu_BossName[1313,4] = "第4关『花岭姬』"; $ChengJiu_BossInfo[1313,4] = 60011;

//中日第一战
$ChengJiu_BossID[1314,1] = 411328002; $ChengJiu_BossName[1314,1] = "第1关『傅采林』";	$ChengJiu_BossInfo[1314,1] = 60012;
$ChengJiu_BossID[1314,2] = 411328003; $ChengJiu_BossName[1314,2] = "第2关『毕玄』";	$ChengJiu_BossInfo[1314,2] = 60013;
$ChengJiu_BossID[1314,3] = 411328004; $ChengJiu_BossName[1314,3] = "第3关『宁道奇』";	$ChengJiu_BossInfo[1314,3] = 60014;
$ChengJiu_BossID[1314,4] = 411328005; $ChengJiu_BossName[1314,4] = "第4关『石之轩』";	$ChengJiu_BossInfo[1314,4] = 60015;
//■■■■■副本中显示BOSS信息和玩家成就时所用的全局变量■■■■■■■■■■■■


//■■■■■程序用于在客户端显示【充值返利】活动的图标■■■■■■■■■■■■■
$ChongZhiFanLi_StartTime = "2013.2.5";
$ChongZhiFanLi_EndTime   = "2013.2.28";