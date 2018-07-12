//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//管理客户端与服务端的所有全局变量：任务数据变量不在本脚本内
//==================================================================================
//■■■■■■■■■■■传送所需坐标■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■经验值公式相关■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■道具鉴定符变量■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■传送所需坐标■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■排行榜类型■■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■紫色装备编号（40级）■■■■■■■■■■■■■■■■■■
//
//----->=1300 填副本编号  <1300 填地图编号
$Transport_Xyz[1001] = "2.21296 -9.75009 191.874";//昆仑城
$Transport_Xyz[1010] = "-3.43812 112.837 144.857";//蓬莱
$Transport_Xyz[1101] ="159.742 59.1848 72.0209";//望仙岭
$Transport_Xyz[1102] = "34.3 -33.9 134.496";//苍山雪海
$Transport_Xyz[1103] = "-10.0746 -12.7732 100.835";//云梦沼泽
$Transport_Xyz[1104] = "171.102 206.931 93.5948";//神弃荒原
$Transport_Xyz[1105] = "82.2266 162.289 114.611";//香海禅林
$Transport_Xyz[1106] = "82.2266 162.289 114.611";//昆仑废墟
$Transport_Xyz[1118] = "11.4548 41.4497 75.0217";//镇魔殿
$Transport_Xyz[1119] = "166.334 -168.646 119.969";//封魔城
$Transport_Xyz[1120] = "-86.3645 69.1422 108.48";//冰火试炼1层
$Transport_Xyz[1121] = "-86.905 69.7343 108.48";//冰火试炼2层
$Transport_Xyz[1122] = "-86.905 69.7343 108.48";//冰火试炼3层
$Transport_Xyz[1128] ="-170.21 -14.9695 112";//陨仙窟
$Transport_Xyz[1129] ="115.687 -204.45 106.548";//落日神陵
$Transport_Xyz[1130] ="-11.8862 -163.31 173.557";//深海迷宫
$Transport_Xyz[1199] ="-33.794 -41.7006 100.021";//测试地图

$Transport_Xyz[1301] ="-170.311 157.338 313.206";//时空裂痕
$Transport_Xyz[1302] ="157.3 -125.586 173.872";//炼魔渊
$Transport_Xyz[1303] ="186.794 106.527 100.214";//蓬莱禁地
$Transport_Xyz[1304] ="2.77221 48.1875 178.727";//幻境争霸
$Transport_Xyz[1305] ="3.07835 102.019 155.892";//心魔幻境
$Transport_Xyz[1306] ="-143.082 163.067 100.661";//诛神问心阵
$Transport_Xyz[1307] ="1.59172 147.923 158.045";//鸿蒙试炼 低等级
$Transport_Xyz[1308] ="1.59172 147.923 158.045";//鸿蒙试炼 中等级
$Transport_Xyz[1309] ="1.59172 147.923 158.045";//鸿蒙试炼 高等级
$Transport_Xyz[1310] ="0.0813078 0.0406539 107.678";//江山社稷
$Transport_Xyz[1311] ="-9.96639 -32.7376 75.167";//血魔封印阵
$Transport_Xyz[1312] ="3.07835 102.019 155.892";//黄金宝藏1306
$Transport_Xyz[1313] ="142 95 128";//刀剑神域1305 低级
$Transport_Xyz[1314] ="142 95 128";//刀剑神域1305 中级
$Transport_Xyz[1315] ="142 95 128";//刀剑神域1305 高级
$Transport_Xyz[1316] ="1 -82.3952 110.126";//云罗镜1303 
$Transport_Xyz[1317] ="146.468 -156.748 197.226";//妖灵天宫1308 
$Transport_Xyz[1318] ="-40.6925 -38.7479 108.015";//封神秘境 1308 

//蓬莱----1010 
$Transport_Xyz[810100100] = "12.9752 -17.3127 126.125";		//落点
$Transport_Xyz[810100101] = "-3.97263 -31.9032 126.125";		//前往昆仑传送门
$Transport_Xyz[810100102] = "-30.4517, -53.978, 125.773";		//蓬莱码头
$Transport_Xyz[810100103] = "-145.664 21.5775 117";//渔村
$Transport_Xyz[810100104] = "-132.862 38.101 125";//田野
$Transport_Xyz[810100105] = "93.0824 70.6411 134.687";//禁地台上
$Transport_Xyz[810100106] = "129.244 12.2293 122.011";//禁地台下
$Transport_Xyz[810100115] = "-60.4202 -81.2395 107.787";
$Transport_Xyz[810100116] = "8.36209 -63.5942 109.021";//蓬莱 -->望仙谷

//$Transport_TargetID[ 810100102 ] = "810100115";//蓬莱 -->渔村 
$Transport_TargetID[810100103] = "810100104";//渔村 -->田野
$Transport_TargetID[810100104] = "810100103";//田野 -->渔村
//$Transport_TargetID[ 810100105 ] = "810100106";//禁地台上 -->禁地
//$Transport_TargetID[ 810100106 ] = "810100105";//禁地 -->禁地台上
//$Transport_TargetID[ 810100115 ] = "810100102";//前往蓬莱码头
$Transport_TargetID[810100116] = "1101 20";//前往望仙谷

//望仙岭---1101
$Transport_Xyz[811010100] = "31.8704 7.45114 72.6409";
$Transport_Xyz[811010101] = "227.188 -84.6738 99.9812";			//副本入口
$Transport_Xyz[811010102] = "-87.972 144.08 88.738";			//望仙岭
$Transport_Xyz[811010103] = "-97.7798 -68.6222 72.1875";			//前往望仙谷BOSS刷新地点
$Transport_Xyz[811010104] = "-105.47 -123.948 89.0625";			//望仙谷BOSS刷新地点
$Transport_Xyz[811010105] = "-108.36 11.8156 88.0957";
$Transport_Xyz[811010106] = "31.8704 7.45114 72.6409";//传送使者的坐标
$Transport_Xyz[811010114] = "67.3006 -146.258 87.371";//往云梦泽

$Transport_TargetID[811010101] = "810100116 20";//望仙岭 -->蓬莱
$Transport_TargetID[811010102] = "810010102 20";//望仙谷 -->昆仑
$Transport_TargetID[811010103] = "811010104 30";//望仙谷 -->望仙谷BOSS刷新地点
$Transport_TargetID[811010104] = "811010103"; //望仙谷BOSS刷新地点  -->望仙谷
$Transport_TargetID[811010105] = "811280100 30";//望仙谷 -->陨仙窟
$Transport_TargetID[811010114] = "811030101 40";//望仙谷 -->云梦泽

//昆仑---1001
$Transport_Xyz[810010100] = "68.4164 -40.9293 180.13";	 //
$Transport_Xyz[810010101] = "41.6773 112.485 195.461";	 //    
$Transport_Xyz[810010102] = "67.5434 -221.922 166.314";	 //望仙谷传送回来落点
$Transport_Xyz[810010103] = "238.841 139.891 197.831";	 //苍山雪海传送门
$Transport_Xyz[810010105] = "-171.612 -173.569 198.954";	 //封魔城传送门
$Transport_Xyz[810010106] = "-153.27 173.16 195.116";	 //灵脉传送门
$Transport_Xyz[810010108] = "";
$Transport_Xyz[810010115] = "41.9802 109.795 195.503";

$Transport_TargetID[810010102] = "811010102 20";//
$Transport_TargetID[810010103] = "811020107 30";//昆仑 --> 苍山雪海
$Transport_TargetID[810010106] = "810010100 30";
$Transport_TargetID[810010105] = "811190110 10";
//苍山雪海特殊区域坐标

$Transport_Xyz[811020101] = "-220.139 36.854 60.0219";	//左上角	  
$Transport_Xyz[811020102] = "-193.121 -29.016 60";		//左下角		
$Transport_Xyz[811020103] = "222.738 80.9133 110.022";	//右上角	  
$Transport_Xyz[811020107] = "118.942 -116.456 147.452";		//传送落点
$Transport_Xyz[811020108] = "-64.82 61.7508 119.059";		//落日神陵入口

$Transport_TargetID[811020107] = "810010103 30"; //苍山雪海 -->昆仑
$Transport_TargetID[811020108] = "811290100 40"; //苍山雪海 -->落日神陵

$Transport_Xyz[811030100] = "41.0912 -17.1737 100.555";//云梦泽
$Transport_Xyz[ 811030101 ] = "-82.1169 185.382 115.522";//云梦泽 上
$Transport_Xyz[ 811030109 ] = "146.421 -100.276 101.862";//云梦泽 下
$Transport_Xyz[ 811030110 ] = "-154.998 -7.73606 106.461";//云梦泽 左

$Transport_TargetID[ 811030101 ] = "811010114 40";//云梦泽--望仙谷
$Transport_TargetID[ 811030109 ] = "811300101 40";//云梦泽--深海迷宫
$Transport_TargetID[ 811030110 ] = "  ";//云梦泽--香海

//封魔城
$Transport_Xyz[811190110] = "166.334 -168.646 119.969";//昆仑传送门
$Transport_Xyz[811190101] = "31.0867 35.7784 98.6669";//南门近郊
$Transport_Xyz[811190107] = "50.9138 -160.494 120";//龙首关
$Transport_TargetID[811190110] = "810010105"; //封魔城 -->昆仑
//冰火试练
$Transport_Xyz[811200100] = "-86.3645 69.1422 108.48";//冰火试炼1层
$Transport_Xyz[811210100] = "-86.3645 69.1422 108.48";//冰火试炼1层
$Transport_Xyz[811220100] = "-86.3645 69.1422 108.48";//冰火试炼1层

//陨仙窟
$Transport_Xyz[811280100] = "-188.245 -16.2916 123.088";//陨仙窟1层入口
$Transport_Xyz[811280200] = "18.8765 -14.5926 100.393";//传送 陨仙窟2层
$Transport_Xyz[811280202] = "-80.0312 -68.1085 108.485";
$Transport_Xyz[811280203] = "20.9943 -14.1292 100";

$Transport_TargetID[811280201] = "811010105 30"; //陨仙窟-->望仙岭
$Transport_TargetID[811280202] = "811280203 30";
$Transport_TargetID[811280203] = "811280202 30";

//落日神陵
$Transport_Xyz[811290100] = "115.687 -204.45 106.548";//【落日神陵1层】
$Transport_Xyz[811290200] = "160.979 125.502 111.042";//【落日神陵2层】
$Transport_Xyz[811290300] = "-116.576 164.16 118.02";//【落日神陵3层】
$Transport_Xyz[811290400] = "-117.981 -46.8495 110.021";//【落日神陵4层】

$Transport_Xyz[811290101] = "115.687 -204.45 106.548";//
$Transport_Xyz[811290102] = "114.788 -22.0674 106";//
$Transport_Xyz[811290201] = "160.979 125.502 111.042";//
$Transport_Xyz[811290202] = "66.3701 125.754 111.022";//
$Transport_Xyz[811290301] = "-116.576 164.16 118.02";//
$Transport_Xyz[811290302] = "-118.574 39.5122 112";//
$Transport_Xyz[811290401] = "-117.981 -46.8495 110.021";//

$Transport_TargetID[811290101] = "811020108 40";//落日神陵->苍山雪海
$Transport_TargetID[811290102] = "811290201 40";//1层->2层
$Transport_TargetID[811290201] = "811290102 40";//2层->1层
$Transport_TargetID[811290202] = "811290301 40";//2层->3层
$Transport_TargetID[811290301] = "811290202 40";//3层->2层
$Transport_TargetID[811290302] = "811290401 40";//3层->4层
$Transport_TargetID[811290401] = "811290302 40";//4层->3层

//深海迷宫
$Transport_Xyz[811300100] = "-11.8862 -163.31 173.557";//深海迷宫1层
$Transport_Xyz[811300200] = "134.389 -10.3318 139.708";//深海迷宫2层
$Transport_Xyz[811300300] = "-160.219 131.284 110.513";//深海迷宫3层
$Transport_Xyz[811300400] = "-159.892 -131.045 243.95";//深海迷宫4层

$Transport_Xyz[811300101] = "-15.2494 -162.25 173.536";
$Transport_Xyz[811300102] = "134.807 -52.9462 162.548";
$Transport_Xyz[811300201] = "134.382 -12.8144 138.849";
$Transport_Xyz[811300202] = "49.249 170.246 137.406";
$Transport_Xyz[811300301] = "-160.737 135.151 110.492";
$Transport_Xyz[811300302] = "-117.75 -49.7499 108.023";
$Transport_Xyz[811300401] = "-167.219 -123.145 244.335";

$Transport_TargetID[811300101] = "811030109 40";//深海迷宫->云梦泽
$Transport_TargetID[811300102] = "811300201 40";//1层->2层
$Transport_TargetID[811300201] = "811300102 40";//2层->1层
$Transport_TargetID[811300202] = "811300301 40";//2层->3层
$Transport_TargetID[811300301] = "811300202 40";//3层->2层
$Transport_TargetID[811300302] = "811300401 40";//3层->4层
$Transport_TargetID[811300401] = "811300302 40";//4层->3层

//幻境争霸
$Transport_Xyz[813020100] = "2.77221 48.1875 178.727";//幻境争霸准备区
$Transport_Xyz[813020200] = "-92.4251 -113.377 172.218";//幻境争霸1层
$Transport_Xyz[813020300] = "120.434 -119.716 174.588";//幻境争霸2层
$Transport_Xyz[813020400] = "-105.851 110.093 204.246";//幻境争霸3层
$Transport_Xyz[813020500] = "118.502 103.178 202.577";//幻境争霸4层

//sptgetplayer(  50000207).TransportObject( 0, 0, 2.77221, 48.1875 ,178.727 );
//■■■■■■■■■■■传送所需坐标■■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■经验值公式相关■■■■■■■■■■■■■■■■■■■■■
if ($Now_Script == 2)
{
	//等级削减经验值比例	//共享范围内的队友人数加成
	$Lv_Exp[1] = 0.98;	$SharePlayerNum[1,1] = 1;	$SharePlayerNum[2,1] = 1;
	$Lv_Exp[2] = 0.96;   	$SharePlayerNum[1,2] = 1.15;	$SharePlayerNum[2,2] = 2.2;
	$Lv_Exp[3] = 0.94;   	$SharePlayerNum[1,3] = 1.4;	$SharePlayerNum[2,3] = 3.6;
	$Lv_Exp[4] = 0.92;   	$SharePlayerNum[1,4] = 1.8;	$SharePlayerNum[2,4] = 5.2;
	$Lv_Exp[5] = 0.90;   	$SharePlayerNum[1,5] = 2.1;	$SharePlayerNum[2,5] = 7;
	$Lv_Exp[6] = 0.88;   	$SharePlayerNum[1,6] = 2.5;	$SharePlayerNum[2,6] = 9;
	$Lv_Exp[7] = 0.86;
	$Lv_Exp[8] = 0.84;  		//共享范围内的队友最大关系加成
	$Lv_Exp[9] = 0.82;   		$MaxConnection[0] = 0;		//Temp,		// 临时
	$Lv_Exp[10] = 0.80;   	$MaxConnection[1] = 0.05;		//Friend,	// 好友
	$Lv_Exp[11] = 0.78;   	$MaxConnection[2] = 0.2;		//Consort,	// 配偶
	$Lv_Exp[12] = 0.76;   	$MaxConnection[3] = 0.2;		//Master,	// 师傅
	$Lv_Exp[13] = 0.74;  		$MaxConnection[4] = 0.05;		//Prentice,	// 徒弟
	$Lv_Exp[14] = 0.72;   	$MaxConnection[5] = 0.1;		//Buddie,	// 兄弟
	$Lv_Exp[15] = 0.70;   	$MaxConnection[6] = 0;		//Enemy,	// 仇人
	$Lv_Exp[16] = 0.68;   	$MaxConnection[7] = 0;		//Mute,		// 屏蔽
	$Lv_Exp[17] = 0.66;   	$MaxConnection[8] = 0;		//Engage,	// 订婚
	$Lv_Exp[18] = 0.64;   	$MaxConnection[9] = 0;		//Divorce,	// 离婚
	$Lv_Exp[19] = 0.62;
	$Lv_Exp[20] = 0.60;
	$Lv_Exp[21] = 0.58;
	$Lv_Exp[22] = 0.56;
	$Lv_Exp[23] = 0.54;
	$Lv_Exp[24] = 0.52;
	$Lv_Exp[25] = 0.50;
}
//■■■■■■■■■■■经验值公式相关■■■■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■道具鉴定符变量■■■■■■■■■■■■■■■■■■■■■
//$JianDingFu[鉴定符编号, 1] = "鉴定等级"; $JianDingFu[鉴定符编号, 2] = "普通 精良 完美 逆天";

//鉴定符（普通）
$JianDingFu[113050001,1] = "29";	$JianDingFu[113050001,2] = "60 38 2";//20级鉴定符
$JianDingFu[113050007,1] = "39";	$JianDingFu[113050007,2] = "60 38 2";//30级鉴定符
$JianDingFu[113050013,1] = "49";	$JianDingFu[113050013,2] = "60 38 2";//40级鉴定符
$JianDingFu[113050019,1] = "59";	$JianDingFu[113050019,2] = "60 38 2";//50级鉴定符
$JianDingFu[113050025,1] = "69";	$JianDingFu[113050025,2] = "60 38 2";//60级鉴定符
$JianDingFu[113050031,1] = "79";	$JianDingFu[113050031,2] = "60 38 2";//70级鉴定符
$JianDingFu[113050037,1] = "89";	$JianDingFu[113050037,2] = "60 38 2";//80级鉴定符

//鉴定符（逆天）
$JianDingFu[113050006,1] = "29";	$JianDingFu[113050006,2] = "0 0 100";//20级鉴定符
$JianDingFu[113050012,1] = "39";	$JianDingFu[113050012,2] = "0 0 100";//30级鉴定符
$JianDingFu[113050018,1] = "49";	$JianDingFu[113050018,2] = "0 0 100";//40级鉴定符
$JianDingFu[113050024,1] = "59";	$JianDingFu[113050024,2] = "0 0 100";//50级鉴定符
$JianDingFu[113050030,1] = "69";	$JianDingFu[113050030,2] = "0 0 100";//60级鉴定符
$JianDingFu[113050036,1] = "79";	$JianDingFu[113050036,2] = "0 0 100";//70级鉴定符
$JianDingFu[113050042,1] = "89";	$JianDingFu[113050042,2] = "0 0 100";//80级鉴定符
$JianDingFu[113050048,1] = "99";	$JianDingFu[113050048,2] = "0 0 100";//80级鉴定符

//■■■■■■■■■■■道具鉴定符变量■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■排行榜类型■■■■■■■■■■■■■■■■■■■■■
//---------------------------------------个人-----------------------------------------
$eTopType_Level=eTopType_Start;// 等级
$eTopType_Rich=1;// 元宝
$eTopType_Rich_Money=2;// 财富金币包含仓库背包
$eTopType_LiteraryGrace=3;// 文采值参与答题活动积分领奖时候加文采值
$eTopType_Master=4;// 师徒榜根据个人的师徒声望值排序
$eTopType_EquipBattle=5;// 战斗力装备战斗力排行
$eTopType_MaleBattle=6;// 男性角色排行榜战斗力性别
$eTopType_FemaleBattle=7;// 女性角色排行榜战斗力性别
$eTopType_KillBoss=8;// 击杀boss榜击杀与自身等级上下浮动20级内的boss计数
$eTopType_DayMoney=9;// 日消费元宝
$eTopType_WeekMoney=10;// 周消费元宝
$eTopType_MonthMoney=11;// 月消费元宝
$eTopType_TotalMoney=12;// 总消费元宝
$eTopType_AnswerIntegral=13;// 答题积分答题后获得积分每天清一次
$eTopType_MassacreValue=14;// 杀戮值排行
$eTopType_Flower=15;// 鲜花榜女性玩家收到花朵数量
$eTopType_MaleFlower=16;// 魅力榜男性玩家收到花朵数量
$eTopType_DonateFlower=17;// 绿叶榜玩家捐献花朵数量
$eTopType_TowerValue=18;// 通天塔排行榜
$eTopType_PersonalReserve1=19;// 预留
$eTopType_PersonalReserve2=20;// 预留
$eTopType_PersonalReserve3=21;// 预留
$eTopType_PersonalReserve4=22;// 预留
$eTopType_PersonalReserve5=23;// 预留
$eTopType_PersonalReserve6=24;// 预留
$eTopType_PersonalReserve7=25;// 预留
$eTopType_PersonalReserve8=26;// 预留
$eTopType_PersonalReserve9=27;// 预留
$eTopType_PersonalReserve10=28;// 预留
$eTopType_PersonalReserve11=29;// 预留
$eTopType_PersonalReserve12=30;// 预留
//-----------------------------------------------------------end-----------------------------------------------
//------------------------------------职业-------------------------------------------------------------------------
$eTopType_WarriorLevel=31;// 战士等级
$eTopType_AssassinLevel=32;// 刺客等级
$eTopType_MageLevel=33;// 法师等级
$eTopType_TaoistLevel=34;// 道士等级
$eTopType_ArrowLevel=35;// 箭翎等级
$eTopType_WarriorPrestige=36;// 战士声望
$eTopType_AssassinPrestige=37;// 刺客声望
$eTopType_MagePrestige=38;// 法师声望
$eTopType_TaoistPrestige=39;// 道士声望
$eTopType_ArrowPrestige=40;// 箭翎声望
//----------------------------------------------------------end----------------------------------------------
//------------------------------------地图-----------------------------------------------------------------------
$eTopType_LoyalismValue=41;// 忠义榜在封魔城npc处上缴物资金条捐献获得
$eTopType_MapReserve1=42;// 预留
$eTopType_MapReserve2=43;// 预留
$eTopType_MapReserve3=44;// 预留
$eTopType_MapReserve4=45;// 预留
//----------------------------------------------------------end-----------------------------------------------
//------------------------------------帮派-----------------------------------------------------------------------
$eTopType_OrgLevel=46;// 帮派等级
$eTopType_OrgMember=47;// 帮派人数
$eTopType_OrgPrestige=48;// 帮派声望
$eTopType_OrgActivity=49;// 帮派活跃度
$eTopType_OrgMoney=50;// 帮派资金
$eTopType_OrgReserve1=51;// 预留
$eTopType_OrgReserve2=52;// 预留
$eTopType_OrgReserve3=53;// 预留
$eTopType_OrgReserve4=54;// 预留
$eTopType_OrgReserve5=55;// 预留
$eTopType_OrgReserve6=56;// 预留
//------------------------------------地图声望-------------------------------------------------------------------
$eTopType_MapPrestige_1101= 57;//1101地图声望
$eTopType_MapPrestige_1102= 58;//1102地图声望
$eTopType_MapPrestige_1103= 59;//1103地图声望
$eTopType_MapPrestige_1104= 60;//1104地图声望
$eTopType_MapPrestige_1105= 61;//1105地图声望
$eTopType_MapPrestige_1106= 62;//1106地图声望
$eTopType_MapPrestige_1107= 63;//1107地图声望
//■■■■■■■■■■■排行榜类型■■■■■■■■■■■■■■■■■■■■■



//■■■■■■■■■■■紫色装备编号（40级）■■■■■■■■■■■■■■■■■■
$PurpleEquipment_LevelForty[1, 1] = "101013004";//飞烟枪	武器	刀斧
$PurpleEquipment_LevelForty[1, 2] = "102013004";//飞烟战盔(男)	防具	头部
$PurpleEquipment_LevelForty[1, 3] = "102013054";//飞烟战盔(女)	防具	头部
$PurpleEquipment_LevelForty[1, 4] = "102023004";//飞烟战甲(男)	防具	身体
$PurpleEquipment_LevelForty[1, 5] = "102023054";//飞烟战甲(女)	防具	身体
$PurpleEquipment_LevelForty[1, 6] = "102033004";//飞烟披风(男)	防具	背部
$PurpleEquipment_LevelForty[1, 7] = "102033054";//飞烟披风(女)	防具	背部
$PurpleEquipment_LevelForty[1, 8] = "102043004";//飞烟护肩(男)	防具	肩部
$PurpleEquipment_LevelForty[1, 9] = "102043054";//飞烟护肩(女)	防具	肩部
$PurpleEquipment_LevelForty[1, 10] = "102053004";//飞烟护腕(男)	防具	手部
$PurpleEquipment_LevelForty[1, 11] = "102053054";//飞烟护腕(女)	防具	手部
$PurpleEquipment_LevelForty[1, 12] = "102063004";//飞烟腰带(男)	防具	腰部
$PurpleEquipment_LevelForty[1, 13] = "102063054";//飞烟腰带(女)	防具	腰部
$PurpleEquipment_LevelForty[1, 14] = "102073004";//飞烟战靴(男)	防具	脚部
$PurpleEquipment_LevelForty[1, 15] = "102073054";//飞烟战靴(女)	防具	脚部
$PurpleEquipment_LevelForty[1, 16] = "103013004";//飞烟护符	饰品	护符
$PurpleEquipment_LevelForty[1, 17] = "103023004";//飞烟项链	饰品	项链
$PurpleEquipment_LevelForty[1, 18] = "103033004";//飞烟戒指	饰品	戒指
$PurpleEquipment_LevelForty[1, 1] = "101023004";//幽魂刀	武器	刀剑
$PurpleEquipment_LevelForty[2, 2] = "102013104";//40级 - 刺客 - 紫色头部(男)	防具	头部
$PurpleEquipment_LevelForty[2, 3] = "102013154";//40级 - 刺客 - 紫色头部(女)	防具	头部
$PurpleEquipment_LevelForty[2, 4] = "102023104";//40级 - 刺客 - 紫色身体(男)	防具	身体
$PurpleEquipment_LevelForty[2, 5] = "102023154";//40级 - 刺客 - 紫色身体(女)	防具	身体
$PurpleEquipment_LevelForty[2, 6] = "102033104";//40级 - 刺客 - 紫色背部(男)	防具	背部
$PurpleEquipment_LevelForty[2, 7] = "102033154";//40级 - 刺客 - 紫色背部(女)	防具	背部
$PurpleEquipment_LevelForty[2, 8] = "102043104";//40级 - 刺客 - 紫色肩部(男)	防具	肩部
$PurpleEquipment_LevelForty[2, 9] = "102043154";//40级 - 刺客 - 紫色肩部(女)	防具	肩部
$PurpleEquipment_LevelForty[2, 10] = "102053104";//40级 - 刺客 - 紫色手部(男)	防具	手部
$PurpleEquipment_LevelForty[2, 11] = "102053154";//40级 - 刺客 - 紫色手部(女)	防具	手部
$PurpleEquipment_LevelForty[2, 12] = "102063104";//40级 - 刺客 - 紫色腰部(男)	防具	腰部
$PurpleEquipment_LevelForty[2, 13] = "102063154";//40级 - 刺客 - 紫色腰部(女)	防具	腰部
$PurpleEquipment_LevelForty[2, 14] = "102073104";//40级 - 刺客 - 紫色脚部(男)	防具	脚部
$PurpleEquipment_LevelForty[2, 15] = "102073154";//40级 - 刺客 - 紫色脚部(女)	防具	脚部
$PurpleEquipment_LevelForty[2, 16] = "103013104";//40级 - 刺客 - 紫色护符	饰品	护符
$PurpleEquipment_LevelForty[2, 17] = "103023104";//40级 - 刺客 - 紫色项链	饰品	项链
$PurpleEquipment_LevelForty[2, 18] = "103033104";//40级 - 刺客 - 紫色戒指	饰品	戒指
$PurpleEquipment_LevelForty[4, 1] = "101033004";//螣蛇塔	武器	法器
$PurpleEquipment_LevelForty[4, 2] = "102013204";//清心法帽(男)	防具	头部
$PurpleEquipment_LevelForty[4, 3] = "102013254";//清心法帽(女)	防具	头部
$PurpleEquipment_LevelForty[4, 4] = "102023204";//清心法袍(男)	防具	身体
$PurpleEquipment_LevelForty[4, 5] = "102023254";//清心法袍(女)	防具	身体
$PurpleEquipment_LevelForty[4, 6] = "102033204";//清心披风(男)	防具	背部
$PurpleEquipment_LevelForty[4, 7] = "102033254";//清心披风(女)	防具	背部
$PurpleEquipment_LevelForty[4, 8] = "102043204";//清心护肩(男)	防具	肩部
$PurpleEquipment_LevelForty[4, 9] = "102043254";//清心护肩(女)	防具	肩部
$PurpleEquipment_LevelForty[4, 10] = "102053204";//清心护手(男)	防具	手部
$PurpleEquipment_LevelForty[4, 11] = "102053254";//清心护手(女)	防具	手部
$PurpleEquipment_LevelForty[4, 12] = "102063204";//清心腰带(男)	防具	腰部
$PurpleEquipment_LevelForty[4, 13] = "102063254";//清心腰带(女)	防具	腰部
$PurpleEquipment_LevelForty[4, 14] = "102073204";//清心护履(男)	防具	脚部
$PurpleEquipment_LevelForty[4, 15] = "102073254";//清心护履(女)	防具	脚部
$PurpleEquipment_LevelForty[4, 16] = "103013204";//清心护符	饰品	护符
$PurpleEquipment_LevelForty[4, 17] = "103023204";//清心项链	饰品	项链
$PurpleEquipment_LevelForty[4, 18] = "103033204";//清心戒指	饰品	戒指
$PurpleEquipment_LevelForty[8, 1] = "101043004";//蓝凌法杖	武器	旗杖
$PurpleEquipment_LevelForty[8, 2] = "102013304";//天罡法帽(男)	防具	头部
$PurpleEquipment_LevelForty[8, 3] = "102013354";//天罡法帽(女)	防具	头部
$PurpleEquipment_LevelForty[8, 4] = "102023304";//天罡法袍(男)	防具	身体
$PurpleEquipment_LevelForty[8, 5] = "102023354";//天罡法袍(女)	防具	身体
$PurpleEquipment_LevelForty[8, 6] = "102033304";//天罡披风(男)	防具	背部
$PurpleEquipment_LevelForty[8, 7] = "102033354";//天罡披风(女)	防具	背部
$PurpleEquipment_LevelForty[8, 8] = "102043304";//天罡护肩(男)	防具	肩部
$PurpleEquipment_LevelForty[8, 9] = "102043354";//天罡护肩(女)	防具	肩部
$PurpleEquipment_LevelForty[8, 10] = "102053304";//天罡护手(男)	防具	手部
$PurpleEquipment_LevelForty[8, 11] = "102053354";//天罡护手(女)	防具	手部
$PurpleEquipment_LevelForty[8, 12] = "102063304";//天罡腰带(男)	防具	腰部
$PurpleEquipment_LevelForty[8, 13] = "102063354";//天罡腰带(女)	防具	腰部
$PurpleEquipment_LevelForty[8, 14] = "102073304";//天罡护履(男)	防具	脚部
$PurpleEquipment_LevelForty[8, 15] = "102073354";//天罡护履(女)	防具	脚部
$PurpleEquipment_LevelForty[8, 16] = "103013304";//天罡护符	饰品	护符
$PurpleEquipment_LevelForty[8, 17] = "103023304";//天罡项链	饰品	项链
$PurpleEquipment_LevelForty[8, 18] = "103033304";//天罡戒指	饰品	戒指
$PurpleEquipment_LevelForty[16, 1] = "101053004";//40级 - 猎人 - 紫色弓箭	武器	弓
$PurpleEquipment_LevelForty[16, 2] = "102013404";//40级 - 猎人 - 紫色头部(男)	防具	头部
$PurpleEquipment_LevelForty[16, 3] = "102013454";//40级 - 猎人 - 紫色头部(女)	防具	头部
$PurpleEquipment_LevelForty[16, 4] = "102023404";//40级 - 猎人 - 紫色身体(男)	防具	身体
$PurpleEquipment_LevelForty[16, 5] = "102023454";//40级 - 猎人 - 紫色身体(女)	防具	身体
$PurpleEquipment_LevelForty[16, 6] = "102033404";//40级 - 猎人 - 紫色背部(男)	防具	背部
$PurpleEquipment_LevelForty[16, 7] = "102033454";//40级 - 猎人 - 紫色背部(女)	防具	背部
$PurpleEquipment_LevelForty[16, 8] = "102043404";//40级 - 猎人 - 紫色肩部(男)	防具	肩部
$PurpleEquipment_LevelForty[16, 9] = "102043454";//40级 - 猎人 - 紫色肩部(女)	防具	肩部
$PurpleEquipment_LevelForty[16, 10] = "102053404";//40级 - 猎人 - 紫色手部(男)	防具	手部
$PurpleEquipment_LevelForty[16, 11] = "102053454";//40级 - 猎人 - 紫色手部(女)	防具	手部
$PurpleEquipment_LevelForty[16, 12] = "102063404";//40级 - 猎人 - 紫色腰部(男)	防具	腰部
$PurpleEquipment_LevelForty[16, 13] = "102063454";//40级 - 猎人 - 紫色腰部(女)	防具	腰部
$PurpleEquipment_LevelForty[16, 14] = "102073404";//40级 - 猎人 - 紫色脚部(男)	防具	脚部
$PurpleEquipment_LevelForty[16, 15] = "102073454";//40级 - 猎人 - 紫色脚部(女)	防具	脚部
$PurpleEquipment_LevelForty[16, 16] = "103013404";//40级 - 猎人 - 紫色护符	饰品	护符
$PurpleEquipment_LevelForty[16, 17] = "103023404";//40级 - 猎人 - 紫色项链	饰品	项链
$PurpleEquipment_LevelForty[16, 18] = "103033404";//40级 - 猎人 - 紫色戒指	饰品	戒指

$PurpleEquipment_LevelForty[31, 1] = "101023004";//幽魂刀	武器	刀剑

//■■■■■■■■■■■紫色装备编号（40级）■■■■■■■■■■■■■■■■■■