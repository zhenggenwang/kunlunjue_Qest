//■■■■■■■■■■■【各功能开关标志】■■■■■■■■■■■■■
//■■■■■■■■■■■【运营活动的配置】■■■■■■■■■■■■■
//■■■■■■■■■■■【常置活动的配置】■■■■■■■■■■■■■
//■■■■■■■■■■■【界面开关配置】■■■■■■■■■■■■■■


//■■■■■■■■■■■【各功能开关标志】■■■■■■■■■■■■■
//0为关闭，1为开启
//--------------------------功能开关--------------------------
$YueGuangBaoHe_108020208 = 1;		//出生给予月光宝盒功能
$g_EnableAnswer = 1;				//关闭自动答题功能，不建议修改
$BangPaiShouHuShen_bActive = 1;	//帮派召唤神

//■■■■■■■■■■■【各功能开关标志】■■■■■■■■■■■■■

//■■■■■■■■■■■【运营活动的配置】■■■■■■■■■■■■■
/*
活动开关配置说明
数组内的数字代表线路ID
bActive 为1 表示开启 0表示关闭
StartTime 表示开启的时间
EndTime 表示关闭的时间
每个线路都是单独配置，如果没有配置，则默认读取线路1的配置开关
*/
//-------提取元宝双倍积分反馈---------
$SL_ChongZhiFanKui_bActive[1]=1; //1开双倍 0普通倍数 -1关闭活动
$SL_ChongZhiFanKui_StartTime[1]="2018.05.21 11:00";
$SL_ChongZhiFanKui_EndTime[1]="2018.05.28 11:00";

$SL_ChongZhiFanKui_bActive[2]=1; //1开双倍 0普通倍数 -1关闭活动
$SL_ChongZhiFanKui_StartTime[2]="2017.11.01 19:00";
$SL_ChongZhiFanKui_EndTime[2]="2017.12.01 19:00";
//-------七日冲榜---------
$SL_BangShangYouMing_bActive[1]=1; //1开 0关
$SL_BangShangYouMing_StartTime[1]="2018.05.21 11:00";
$SL_BangShangYouMing_EndTime[1]="2018.05.28 11:00";//这个是显示按钮的结束时间，活动的真正结束时间在数据库里配

$SL_BangShangYouMing_bActive[2]=1; //1开 0关
$SL_BangShangYouMing_StartTime[2]="2018.03.05 09:00";
$SL_BangShangYouMing_EndTime[2]="2018.05.25 23:00";//这个是显示按钮的结束时间，活动的真正结束时间在数据库里配

//$ServiceRankItem 奖励数组
//-------行行出状元---------
$SL_HangHangChuZhuangYuan_bActive[1]=1; //1开 0关
$SL_HangHangChuZhuangYuan_StartTime[1]="2018.05.21 11:00";
$SL_HangHangChuZhuangYuan_EndTime[1]="2018.05.28 11:00";

$SL_HangHangChuZhuangYuan_bActive[2]=1; //1开 0关
$SL_HangHangChuZhuangYuan_StartTime[2]="2017.11.03 19:00";
$SL_HangHangChuZhuangYuan_EndTime[2]="2018.11.03 19:00";
//-------仙童降临---------
$SL_XianTongJiangLin_bActive[1]=1; //1开 0关
$SL_XianTongJiangLin_StartTime[1]="2018.05.21 14:00";
$SL_XianTongJiangLin_EndTime[1]="2018.05.28 21:00";

$SL_XianTongJiangLin_bActive[2]=1; //1开 0关
$SL_XianTongJiangLin_StartTime[2]="2018.03.05 14:00";
$SL_XianTongJiangLin_EndTime[2]="2018.03.12 21:00";

//-------关注微博---------
$SL_CareWeiBo_bActive[1]= 1;
$SL_CareWeiBo_StartTime[1]="2018.05.21 11:00";
$SL_CareWeiBo_EndTime[1]="2018.06.21 11:00";

$SL_CareWeiBo_bActive[2]= 1;
$SL_CareWeiBo_StartTime[2]="2017.11.04 11:00";
$SL_CareWeiBo_EndTime[2]="2018.06.05 11:00";

//---------满月庆典---------
$SL_ManYueQingDian_bActive[1]= 1; //活动开关
$SL_ManYueQingDian_StartTime[1]="2018.05.21 11:00";
$SL_ManYueQingDian_EndTime[1]="2018.06.21 11:00";//这个是显示按钮的结束时间，活动的真正结束时间在数据库里配
$SL_ManYueQingDianStore_bActive[1]= 1;//活动结束商店的开启时间段
$SL_ManYueQingDianStore_StartTime[1]="2018.06.22 00:00";
$SL_ManYueQingDianStore_EndTime[1]="2018.06.22 23:00";

$SL_ManYueQingDian_bActive[2]= 1; //活动开关
$SL_ManYueQingDian_StartTime[2]="2018.03.05 09:00";
$SL_ManYueQingDian_EndTime[2]="2018.05.25 22:59";//这个是显示按钮的结束时间，活动的真正结束时间在数据库里配
$SL_ManYueQingDianStore_bActive[2]= 1;//活动结束商店的开启时间段
$SL_ManYueQingDianStore_StartTime[2]="2018.04.04 23:00";
$SL_ManYueQingDianStore_EndTime[2]="2018.05.25 23:00";

//---------祈愿豪礼---------
$SL_QiYuanHaoLi_bActive[1]= 1;
$SL_QiYuanHaoLi_StartTime[1]="2018.05.21 11:00";
$SL_QiYuanHaoLi_EndTime[1]="2018.11.05 11:00";

$SL_QiYuanHaoLi_bActive[2]= 1;
$SL_QiYuanHaoLi_StartTime[2]="2018.05.21 11:00";
$SL_QiYuanHaoLi_EndTime[2]="2018.11.05 11:00";

//---------仙缘解签---------
$SL_LiShangWangLai_bActive[1]= 1;
$SL_LiShangWangLai_StartTime[1]="2018.05.21 11:00";
$SL_LiShangWangLai_EndTime[1]="2018.11.05 11:00";

$SL_LiShangWangLai_bActive[2]= 1;
$SL_LiShangWangLai_StartTime[2]="2017.11.04 11:00";
$SL_LiShangWangLai_EndTime[2]="2018.11.05 11:00";

//---------全民夺宝---------
$SL_QuanMinDuoBao_bActive[1]= 1;
$SL_QuanMinDuoBao_Week[1] = "0 1 3 5 2 4 6";
$SL_QuanMinDuoBao_StartTime[1]="2018.05.21 11:00";
$SL_QuanMinDuoBao_EndTime[1]="2018.11.05 11:00";

$SL_QuanMinDuoBao_bActive[2]= 1;
$SL_QuanMinDuoBao_Week[2] = "0 1 3 5 2 4 6";
$SL_QuanMinDuoBao_StartTime[2]="2017.11.04 11:00";
$SL_QuanMinDuoBao_EndTime[2]="2030.11.05 11:00";

//---------七天好礼---------
$SL_QiTianHaoLi_bActive[1]= 1;
//---------签到---------
$SL_QianDao_bActive[1]= 1;
//--------特权----------
$SL_TeQuan_bActive[1]= 1;
//--------连续充值------
$SL_LianXuChongZhi_bActive[1]= 1;
$SL_LianXuChongZhi_StartTime[1]="2018.05.21 11:00";
$SL_LianXuChongZhi_EndTime[1]="2018.5.28 24:00";
//--------限时礼包--时尚礼包----
$SL_XianShiLiBao_bActive[1]= 1;
$SL_XianShiLiBao_StartTime[1]="2018.06.1 11:00";
$SL_XianShiLiBao_EndTime[1]="2018.06.28 11:00";
//--------优享基金------
$SL_YouXiangJiJin_bActive[1]= 1;
$SL_YouXiangJiJin_StartTime[1]="2018.05.21 11:00";
$SL_YouXiangJiJin_EndTime[1]="2018.06.21 11:00";
//--------限时抢购------
$SL_XianShiQiangGou_bActive[1]= 1;
$SL_XianShiQiangGou_StartTime[1]="2018.5.7 07:00";
$SL_XianShiQiangGou_EndTime[1]="2018.5.10 22:00";
$SL_XianShiQiangGou_FreshTime[1,1] = "07:00|10:00|13:00|19:00";	//每次刷新的时间
$SL_XianShiQiangGou_FreshItem[1,1] = "6|12|20|30";	//本批刷新的最后一个道具的下标，如：第一批1~6、第二批7~12、第三批13~20、第四批21~30
//■■■■■■■■■■■【运营活动的配置】■■■■■■■■■■■■■

//■■■■■■■■■■■【常置活动的配置】■■■■■■■■■■■■■
//道经
$SpecialItem_DaoJing_bActive = 1;

//-------攻城战---------
$SL_CityAttack_bActive = 1;
//-------群英汇聚---------
$SL_JiaZuGouHuo_bActive = 1;
$SL_JiaZuGouHuo_StartTime = "19:00";
$SL_JiaZuGouHuo_EndTime = "20:00";
$SL_JiaZuGouHuo_Level = 20;//开放等级
//--------时空裂痕----------
$SL_XuanWuMen_bActive = 1;
$SL_XuanWuMen_StartTime = "19:00";
$SL_XuanWuMen_EndTime = "22:00";
$SL_XuanWuMen_Level = 30;//开放等级
//--------炼魔渊----------
$SL_LianMoYuan_bActive = 1;
$SL_LianMoYuan_StartTime = "00:00";
$SL_LianMoYuan_EndTime = "23:59";
$SL_LianMoYuan_MinLevel = 45;//最低可进入等级
//--------幻境争霸----------
$SL_HuanJingZhengBa_bActive = 1;
$SL_HuanJingZhengBa_Week = "1 3 5";//每周的哪几天开放
$SL_HuanJingZhengBa_Level = 40;//开放等级

$SL_HuanJingZhengBa_StartTime = "20:00";
$SL_HuanJingZhengBa_EndTime = "20:05";

//--------世界BOSS--------
$SL_ShiJieBoss_bActive = 1;
//-------------------编号---地图ID--NPCid--cd----坐标--
$SL_ShiJieBoss_bActive[1001] = "440000015 6 -25.934 -136.061 141.527";//建帮令boss
$SL_ShiJieBoss_bActive[1119] = "440000016 6 -129.196 -143.03 108.06";//攻城令boss

$SL_ShiJieBoss_bActive[1101] = "440000001 6 -138.999 -93.8154 90.035";//		望仙岭
$SL_ShiJieBoss_bActive[1102] = "440000002 6 -142.703 -31.5414 128.773";//		苍山雪海
$SL_ShiJieBoss_bActive[1103] = "440000003 6 -68.7502 -107 121.718";//			云梦沼泽
$SL_ShiJieBoss_bActive[1104] = "440000004 6 -126.32 3.99094 107.112";//奎章		莽荒神殿 
//$SL_ShiJieBoss_bActive[ 1105 ] = "440000005 6 123 223 245";//魔罗		香海禅林
//$SL_ShiJieBoss_bActive[ 1106 ] = "440000006 6 123 223 245";//睚眦		昆仑废墟
$SL_ShiJieBoss_bActive[1128] = "440000008 8 106.931 -14.9205 103.599";//地宫1boss	陨仙窟2层
$SL_ShiJieBoss_bActive[1129] = "440000009 8 -116.334 -121.201 108.083";//地宫2boss	落日神陵4层
$SL_ShiJieBoss_bActive[1130] = "440000010 8 -141.2 -149.028 244.004";//地宫3boss	深海迷宫4层
//$SL_ShiJieBoss_bActive[ 1132 ] = "440000010 8 123 223 245";//地宫3boss	石林秘境4层
//$SL_ShiJieBoss_bActive[ 1134 ] = "440000011 8 123 223 245";//地宫4boss	黑岩石窟4层
//$SL_ShiJieBoss_bActive[ 1136 ] = "440000012 8 123 223 245";//地宫5boss	须弥洞4层
//$SL_ShiJieBoss_bActive[ 1138 ] = "440000013 8 123 223 245";//地宫6boss	昆仑幻境3层

//--------诛妖-----------
$SL_ZhuYao_bActive = 1;
$SL_ZhuYao_Level = 35;//开放等级
//奖励信息   道具ID，道具数量，概率，是否公告
$SL_ZhuYao_item[1]  ="112010001;1;1254;0;";//1乾坤袋
$SL_ZhuYao_item[2]  ="112010002;1;895;0;";//2乾坤袋
$SL_ZhuYao_item[3]  ="112010003;1;479;2;";//3乾坤袋
$SL_ZhuYao_item[4]  ="112020001;1;479;2;";//仓库扩展包
$SL_ZhuYao_item[5]  ="112020002;1;287;2;";//仓库扩展包
$SL_ZhuYao_item[6]  ="109020501;1;418;0;";//《2格乾坤袋》配方
$SL_ZhuYao_item[7]  ="109020502;1;298;0;";//《3格乾坤袋》配方
$SL_ZhuYao_item[8]  ="109030501;1;160;2;";//《仓库扩展包( 8格 )》配方
$SL_ZhuYao_item[9]  ="109030502;1;96;3;";//《仓库扩展包( 12格 )》配方
$SL_ZhuYao_item[10] ="105020503;2;1277;0;";//跌打药
$SL_ZhuYao_item[11] ="105020553;2;1357;0;";//回灵露
$SL_ZhuYao_item[12] ="109051001;1;1277;0;";//《金创药》药方
$SL_ZhuYao_item[13] ="109051011;1;1277;0;";//《黄仙露》药方
$SL_ZhuYao_item[14] ="109051021;1;447;3;";//《六阳正气丸》药方
$SL_ZhuYao_item[15] ="105100131;1;928;3;";//紫星石礼包
$SL_ZhuYao_item[16] ="105100101;1;536;3;";//炼魂石礼包
$SL_ZhuYao_item[17] ="105100111;1;536;3;";//换魂石礼包
$SL_ZhuYao_item[18] ="105105300;1;2480;0;";//银叶子
$SL_ZhuYao_item[19] ="105105301;1;500;3;";//金叶子


$SL_ZhuYao_YaoWang[1] = "112010003;1;2567;0;";//3乾坤袋
$SL_ZhuYao_YaoWang[2] = "112010004;1;1497;2;";//4乾坤袋
$SL_ZhuYao_YaoWang[3] = "112010005;1;1112;2;";//5乾坤袋
$SL_ZhuYao_YaoWang[4] = "112010006;1;257;3;";//6乾坤袋
$SL_ZhuYao_YaoWang[5] = "112020002;1;2053;0;";//仓库扩展包
$SL_ZhuYao_YaoWang[6] = "112020003;1;513;0;";//仓库扩展包
$SL_ZhuYao_YaoWang[7] = "109020503;1;1949;0;";//《4格乾坤袋》配方
$SL_ZhuYao_YaoWang[8] = "109020504;1;1595;2;";//《5格乾坤袋》配方
$SL_ZhuYao_YaoWang[9] = "109020505;1;1063;2;";//《6格乾坤袋》配方
$SL_ZhuYao_YaoWang[10]= "109020506;1;532;3;";//《7格乾坤袋》配方
$SL_ZhuYao_YaoWang[11]= "109020507;1;266;3;";//《8格乾坤袋》配方
$SL_ZhuYao_YaoWang[12]= "109020508;1;89;3;";//《9格乾坤袋》配方
$SL_ZhuYao_YaoWang[13]= "109030503;1;1108;3;";//《仓库扩展包( 16格 )》配方
$SL_ZhuYao_YaoWang[14]= "109030504;1;354;3;";//《仓库扩展包( 20格 )》配方
$SL_ZhuYao_YaoWang[15]= "109030505;1;44;3;";//《仓库扩展包( 24格 )》配方
$SL_ZhuYao_YaoWang[16]= "105100101;1;2000;3;";//炼魂石礼包
$SL_ZhuYao_YaoWang[17]= "105100111;1;2000;3;";//换魂石礼包
$SL_ZhuYao_YaoWang[18]= "116030001;1;1250;3;";//一级打孔钻
$SL_ZhuYao_YaoWang[19]= "116030002;1;1250;3;";//二级打孔钻
$SL_ZhuYao_YaoWang[20]= "105100131;1;1250;3;";//紫星石礼包
$SL_ZhuYao_YaoWang[21]= "105100102;1;1125;3;";//炼魂石礼包
$SL_ZhuYao_YaoWang[22]= "105100112;1;1125;3;";//换魂石礼包
$SL_ZhuYao_YaoWang[23]= "105105301;1;3077;0;";//金叶子
$SL_ZhuYao_YaoWang[24]= "105105302;1;1603;3;";//金锭
$SL_ZhuYao_YaoWang[25]= "105105303;1;321;3;";//金条
$SL_ZhuYao_YaoWang[26]= "105090801;1;220;3;";//古神仙珍图

//--------藏宝图---------
$SL_CangBaoTu_bActive = 1;
$SL_CangBaoTu_Level = 35;//开放等级
//--------师门尽忠---------
$SL_ShiMenJinZong_bActive = 1;
$SL_ShiMenJinZong_Level = 35;
//--------诛神问心阵---------
$SL_ZhuShenWenXinZhen_bActive = 0;
$SL_ZhuShenWenXinZhen_StartTime= "08:00";
$SL_ZhuShenWenXinZhen_EndTime= "23:59";
//--------鸿蒙试炼---------
$SL_YunXianJie_bActive = 1;
$SL_YunXianJie_StartTime = "20:00";
$SL_YunXianJie_EndTime = "20:05";
$SL_YunXianJie_Week = "2 4 6";//每周的哪几天开放
$SL_YunXianJie_Level = 40;//开放等级

$SL_YunXianJie_Level[1307] = "40 49";	//低级副本 参与等级的区间
$SL_YunXianJie_Level[1308] = "50 59";	//中级副本 参与等级的区间
$SL_YunXianJie_Level[1309] = "60 99";	//高级副本 参与等级的区间

//--------押镖---------
$SL_YaBiao_bActive = 1;
$SL_YaBiao_StartTime = "12:00";
$SL_YaBiao_EndTime = "22:00";
$SL_YaBiao_Level = 50;//开放等级
//----------蓬莱仙钓-----------
$SL_DiaoYu_bActive = 1;
$SL_DiaoYu_StartTime = "18:30";
$SL_DiaoYu_EndTime = "19:00";
$SL_DiaoYu_Level = 30;//开放等级
//ID,概率，数量，绑定标识，公告
$SL_DiaoYu_Item[1] = "106050301 5480 1 0 0"; //金枪鱼
$SL_DiaoYu_Item[2] = "106050302 1500 1 0 0"; //鲈鱼
$SL_DiaoYu_Item[3] = "106050303 500 1 0 0"; //鳐鱼
$SL_DiaoYu_Item[4] = "106050306 180 1 0 1"; //赤焰鳟
$SL_DiaoYu_Item[5] = "106050307 40 1 0 1"; //金鳞鲤鱼
$SL_DiaoYu_Item[6] = "106050304 500 1 0 0"; //泪螺
$SL_DiaoYu_Item[7] = "106050305 1000 1 0 0"; //贝壳
$SL_DiaoYu_Item[8] = "105109303 800 1 0 0 "; //垂钓心得

//-------------聆经悟道-------------------
$SL_LingJingWuDao_bActive = 1;
$SL_LingJingWuDao_StartTime = "21:00";//关闭的时间,这个活动比较特殊
$SL_LingJingWuDao_EndTime = "20:30";//开启的时间,这个活动比较特殊
$SL_LingJingWuDao_Level = 30;//开放等级

//-------------首座论经-------------------
$SL_ShouZuoLunJing_bActive = 1;
$SL_ShouZuoLunJing_StartTime = "20:30";
$SL_ShouZuoLunJing_EndTime = "20:55";
$SL_ShouZuoLunJing_Level = 30;//开放等级

//-------------冰火试炼-------------------
$SL_BingHuoShiLian_bActive = 1;
//等级限制在传送功能限制中添加，没有通用开关
//-------------悬赏缉凶-------------------
$SL_XuanShangJiXiong_bActive = 1;
$SL_XuanShangJiXiong_Level[1101] = 35;//当前地图开放等级
$SL_XuanShangJiXiong_Level[1102] = 55;//当前地图开放等级
//--------------血魔封印阵----------------
$SL_XueMoFenYinZhen_bActive = 1;
$SL_XueMoFenYinZhen_MinLv = 40;//最低参与等级

//--------------黄金宝藏----------------
$SL_HuangJingBaoZang_bActive = 1;
$SL_HuangJingBaoZang_Level = 35;//开放等级 

//--------------刀剑神域----------------
$SL_DaoJianShenYu_bActive = 1;
$SL_DaoJianShenYu_StartTime = "21:10";
$SL_DaoJianShenYu_EndTime = "21:40";
$SL_DaoJianShenYu_Level = 50;//开放等级

//--------------紫星传功---------------
$SL_ZiXingChuanGong_bActive = 1;
$SL_ZiXingChuanGong_Level = 30;
//--------------镇魔殿----------------
$SL_ShiMoDian_bActive = 1;
$SL_ShiMoDian_Level = 40;
//-------------云罗镜------------------
$SL_YunLuoJing_bActive = 1;
$SL_YunLuoJing_Level = 40;

//-------------封神秘境------------------
$SL_FengShenMiJing_bActive = 1;
$SL_FengShenMiJing_Level = 35;

//■■■■■■■■■■■【常置活动的配置】■■■■■■■■■■■■■


//■■■■■■■■■■■【界面开关配置】■■■■■■■■■■■■■■

//-------排行榜杀戮------------------
$KLJRankVisibleSign = 1;  // 等于0隐藏  1显示

//-------活动大全------------------
$SL_HuoDongDaQuan_bActive = 1;  // 等于0隐藏  1显示

//-------特惠商城------------------
$SL_TeHuiShangCheng_bActive = 1;  // 等于0隐藏  1显示

//-------排行榜------------------
$SL_PaiHangBang_bActive = 1;  // 等于0隐藏  1显示

//-------聚宝盆------------------
$SL_JuBaoPeng_bActive = 1;  // 等于0隐藏  1显示

//-------转视角------------------
$SL_ZhuanShiJiao_bActive = 1;  // 等于0隐藏  1显示

//-------充值------------------
$SL_ChongZhi_bActive = 1;  // 等于0隐藏  1显示

//-------灵脉------------------
$SL_LingMai_bActive = 1;  // 等于0隐藏  1显示

//-------领奖------------------
$SL_LingJiang_bActive = 1;  // 等于0隐藏  1显示

//-------攻略------------------
$SL_GongLue_bActive = 1;  // 等于0隐藏  1显示

//-------成就------------------
$SL_ChengJiu_bActive = 1;  // 等于0隐藏  1显示

//-------成就------------------
$SL_HuoYue_bActive = 1;  // 等于0隐藏  1显示

//统合所有开关
$SL_JieMianKaiGuan_Old = $SL_JieMianKaiGuan;

$SL_JieMianKaiGuan =
$KLJRankVisibleSign @ " " @
$SL_HuoDongDaQuan_bActive @ " " @
$SL_TeHuiShangCheng_bActive @ " " @
$SL_PaiHangBang_bActive @ " " @
$SL_JuBaoPeng_bActive @ " " @
$SL_ZhuanShiJiao_bActive @ " " @
$SL_ChongZhi_bActive @ " " @
$SL_LingMai_bActive @ " " @
$SL_LingJiang_bActive @ " " @
$SL_GongLue_bActive @ " " @
$SL_ChengJiu_bActive @ " " @
$SL_HuoYue_bActive;
//■■■■■■■■■■■【界面开关配置】■■■■■■■■■■■■■■
