//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//部分只记录 1 和 0值的活动记录   这个编号 必须按顺序 填 不能跳不能跳
//
//==================================================================================
//■■■■■■■■■■■【活动变量记录】■■■■■■■■■■■■■■■■■■■■
//这个编号 必须按顺序 填 不能跳不能跳
$Src_ClearTime_Never = 0;    //从不重置
$Src_ClearTime_Day = 1;	//每日的01分重置，数组内以分钟为单位
$Src_ClearTime_Week = 2;			//每周的01周重置，数组内以周数为单位
$Src_ClearTime_Month = 3;		//每月的01号重置，数组内以月份为单位

$Src_ReturnTime[1]= $Src_ClearTime_Week;//记录是否已经领取过 本周免费双倍时间
$Src_ReturnTime[2]= $Src_ClearTime_Never;//记录是否 弹框提示需要手动升级
$Src_ReturnTime[3]= $Src_ClearTime_Day;//群英汇聚
$Src_ReturnTime[4]= $Src_ClearTime_Day;//幻境争霸
$Src_ReturnTime[5]= $Src_ClearTime_Day;//鸿蒙试炼 今天是否已经参加
$Src_ReturnTime[6]= $Src_ClearTime_Day;//鸿蒙试炼 今天是否领取奖励
$Src_ReturnTime[7]= $Src_ClearTime_Day;//签到领奖 今天是否已经领取签到奖励
$Src_ReturnTime[8]= $Src_ClearTime_Month;//签到领奖 每月签到累计天数奖励记录
$Src_ReturnTime[9]= $Src_ClearTime_Month;//签到领奖 每月签到累计天数奖励记录
$Src_ReturnTime[10]= $Src_ClearTime_Month;//签到领奖 每月签到累计天数奖励记录
$Src_ReturnTime[11]= $Src_ClearTime_Month;//签到领奖 每月签到累计天数奖励记录
$Src_ReturnTime[12]= $Src_ClearTime_Day;//日活跃度记录 登录15分钟
$Src_ReturnTime[13]= $Src_ClearTime_Day;//日活跃度记录 登录30分钟
$Src_ReturnTime[14]= $Src_ClearTime_Day;//日活跃度记录 登录1小时
$Src_ReturnTime[15]= $Src_ClearTime_Day;//日活跃度记录 登录2小时
$Src_ReturnTime[16]= $Src_ClearTime_Never;//领取等级礼包记录1
$Src_ReturnTime[17]= $Src_ClearTime_Never;//领取等级礼包记录2
$Src_ReturnTime[18]= $Src_ClearTime_Never;//领取等级礼包记录3
$Src_ReturnTime[19]= $Src_ClearTime_Never;//领取等级礼包记录4
$Src_ReturnTime[20]= $Src_ClearTime_Never;//领取等级礼包记录5
$Src_ReturnTime[21]= $Src_ClearTime_Never;//领取等级礼包记录6
$Src_ReturnTime[22]= $Src_ClearTime_Never;//领取等级礼包记录7
$Src_ReturnTime[23]= $Src_ClearTime_Never;//领取等级礼包记录8
$Src_ReturnTime[24]= $Src_ClearTime_Never;//领取等级礼包记录9
$Src_ReturnTime[25]= $Src_ClearTime_Never;//领取等级礼包记录10
$Src_ReturnTime[26]= $Src_ClearTime_Never;//领取等级礼包记录11
$Src_ReturnTime[27]= $Src_ClearTime_Never;//领取等级礼包记录12
$Src_ReturnTime[28]= $Src_ClearTime_Never;//领取等级礼包记录13
$Src_ReturnTime[29]= $Src_ClearTime_Never;//领取等级礼包记录14
$Src_ReturnTime[30]= $Src_ClearTime_Never;//领取等级礼包记录15
$Src_ReturnTime[31]= $Src_ClearTime_Never;//领取等级礼包记录16
$Src_ReturnTime[32]= $Src_ClearTime_Never;//领取等级礼包记录17
$Src_ReturnTime[33]= $Src_ClearTime_Never;//领取等级礼包记录18
$Src_ReturnTime[34]= $Src_ClearTime_Never;//领取等级礼包记录19
$Src_ReturnTime[35]= $Src_ClearTime_Never;//领取等级礼包记录20
$Src_ReturnTime[36]= $Src_ClearTime_Day;//活跃度礼包领取记录 活跃度1礼包
$Src_ReturnTime[37]= $Src_ClearTime_Day;//活跃度礼包领取记录 活跃度2礼包
$Src_ReturnTime[38]= $Src_ClearTime_Day;//活跃度礼包领取记录 活跃度3礼包
$Src_ReturnTime[39]= $Src_ClearTime_Day;//活跃度礼包领取记录 活跃度4礼包
$Src_ReturnTime[40]= $Src_ClearTime_Day;//记录冰火试炼任务完成情况 寒冰之魂
$Src_ReturnTime[41]= $Src_ClearTime_Day;//记录冰火试炼任务完成情况 烈火之炎
$Src_ReturnTime[42]= $Src_ClearTime_Day;//记录冰火试炼任务完成情况 铲除蟾妖
$Src_ReturnTime[43]= $Src_ClearTime_Day;//记录冰火试炼任务完成情况 铲除妖蟒
$Src_ReturnTime[44]= $Src_ClearTime_Day;//记录冰火试炼任务完成情况 乔装采药第1次
$Src_ReturnTime[45]= $Src_ClearTime_Day;//记录冰火试炼任务完成情况 乔装采药第2次
$Src_ReturnTime[46]= $Src_ClearTime_Day;//记录冰火试炼任务完成情况 乔装采药第3次
$Src_ReturnTime[47]= $Src_ClearTime_Day;//记录冰火试炼任务完成情况 乔装采药第4次
$Src_ReturnTime[48]= $Src_ClearTime_Day;//记录冰火试炼任务完成情况 乔装采药第5次
$Src_ReturnTime[49]= $Src_ClearTime_Day;//记录冰火试炼任务完成情况 乔装采药全部完成
$Src_ReturnTime[50]= $Src_ClearTime_Day;//记录冰火试炼任务完成情况 冰火之珠·一第1次
$Src_ReturnTime[51]= $Src_ClearTime_Day;//记录冰火试炼任务完成情况 冰火之珠·一第2次
$Src_ReturnTime[52]= $Src_ClearTime_Day;//记录冰火试炼任务完成情况 冰火之珠·一第3次
$Src_ReturnTime[53]= $Src_ClearTime_Day;//记录冰火试炼任务完成情况 冰火之珠·一第4次
$Src_ReturnTime[54]= $Src_ClearTime_Day;//记录冰火试炼任务完成情况 冰火之珠·一第5次
$Src_ReturnTime[55]= $Src_ClearTime_Day;//记录冰火试炼任务完成情况 冰火之珠·二
$Src_ReturnTime[56]= $Src_ClearTime_Day;//记录冰火试炼任务完成情况 降妖除魔
$Src_ReturnTime[57]= $Src_ClearTime_Day;//记录血魔封印阵 今日是否参加
$Src_ReturnTime[58]= $Src_ClearTime_Day;//记录师门尽忠 今日是否完成过心魔幻境副本
$Src_ReturnTime[59]= $Src_ClearTime_Day;//记录秘咒除魔任务 今日是否已接取过
$Src_ReturnTime[60]= $Src_ClearTime_Never;//攻略界面 阅历礼包领取记录
$Src_ReturnTime[61]= $Src_ClearTime_Never;//攻略界面 阅历礼包领取记录
$Src_ReturnTime[62]= $Src_ClearTime_Never;//攻略界面 阅历礼包领取记录
$Src_ReturnTime[63]= $Src_ClearTime_Never;//攻略界面 阅历礼包领取记录
$Src_ReturnTime[64]= $Src_ClearTime_Never;//攻略界面		组队
$Src_ReturnTime[65]= $Src_ClearTime_Never;//攻略界面 		组队
$Src_ReturnTime[66]= $Src_ClearTime_Never;//攻略界面 		添加好友
$Src_ReturnTime[67]= $Src_ClearTime_Never;//攻略界面 		添加好友
$Src_ReturnTime[68]= $Src_ClearTime_Never;//攻略界面 		帮派
$Src_ReturnTime[69]= $Src_ClearTime_Never;//攻略界面 		帮派
$Src_ReturnTime[70]= $Src_ClearTime_Never;//攻略界面 		拍卖行
$Src_ReturnTime[71]= $Src_ClearTime_Never;//攻略界面 		拍卖行
$Src_ReturnTime[72]= $Src_ClearTime_Never;//攻略界面 		摆摊
$Src_ReturnTime[73]= $Src_ClearTime_Never;//攻略界面 		摆摊
$Src_ReturnTime[74]= $Src_ClearTime_Never;//攻略界面 		千里传音
$Src_ReturnTime[75]= $Src_ClearTime_Never;//攻略界面 		千里传音
$Src_ReturnTime[76]= $Src_ClearTime_Never;//攻略界面 		写信
$Src_ReturnTime[77]= $Src_ClearTime_Never;//攻略界面 		写信
$Src_ReturnTime[78]= $Src_ClearTime_Never;//攻略界面 		自动战斗
$Src_ReturnTime[79]= $Src_ClearTime_Never;//攻略界面 		自动战斗
$Src_ReturnTime[80]= $Src_ClearTime_Never;//攻略界面 		双倍经验
$Src_ReturnTime[81]= $Src_ClearTime_Never;//攻略界面 		双倍经验
$Src_ReturnTime[82]= $Src_ClearTime_Never;//攻略界面 		学习技能
$Src_ReturnTime[83]= $Src_ClearTime_Never;//攻略界面 		学习技能
$Src_ReturnTime[84]= $Src_ClearTime_Never;//攻略界面 		升级技能
$Src_ReturnTime[85]= $Src_ClearTime_Never;//攻略界面 		升级技能
$Src_ReturnTime[86]= $Src_ClearTime_Never;//攻略界面 		分解装备
$Src_ReturnTime[87]= $Src_ClearTime_Never;//攻略界面 		分解装备
$Src_ReturnTime[88]= $Src_ClearTime_Never;//攻略界面 		强化装备
$Src_ReturnTime[89]= $Src_ClearTime_Never;//攻略界面 		强化装备
$Src_ReturnTime[90]= $Src_ClearTime_Never;//攻略界面 		鉴定装备
$Src_ReturnTime[91]= $Src_ClearTime_Never;//攻略界面 		鉴定装备
$Src_ReturnTime[92]= $Src_ClearTime_Never;//攻略界面 		装备重铸
$Src_ReturnTime[93]= $Src_ClearTime_Never;//攻略界面 		装备重铸
$Src_ReturnTime[94]= $Src_ClearTime_Never;//攻略界面 		装备精炼
$Src_ReturnTime[95]= $Src_ClearTime_Never;//攻略界面 		装备精炼
$Src_ReturnTime[96]= $Src_ClearTime_Never;//攻略界面 		装备涅槃
$Src_ReturnTime[97]= $Src_ClearTime_Never;//攻略界面 		装备涅槃
$Src_ReturnTime[98]= $Src_ClearTime_Never;//攻略界面 		神石合成
$Src_ReturnTime[99]= $Src_ClearTime_Never;//攻略界面 		神石合成
$Src_ReturnTime[100]= $Src_ClearTime_Never;//攻略界面		鉴宝
$Src_ReturnTime[101]= $Src_ClearTime_Never;//攻略界面		鉴宝
$Src_ReturnTime[102]= $Src_ClearTime_Never;//攻略界面		每日活跃
$Src_ReturnTime[103]= $Src_ClearTime_Never;//攻略界面		每日活跃
$Src_ReturnTime[104]= $Src_ClearTime_Never;//攻略界面		签到打卡
$Src_ReturnTime[105]= $Src_ClearTime_Never;//攻略界面		签到打卡
$Src_ReturnTime[106]= $Src_ClearTime_Never;//攻略界面		经验获得
$Src_ReturnTime[107]= $Src_ClearTime_Never;//攻略界面		经验获得
$Src_ReturnTime[108]= $Src_ClearTime_Never;//攻略界面		道具获得
$Src_ReturnTime[109]= $Src_ClearTime_Never;//攻略界面		道具获得
$Src_ReturnTime[110]= $Src_ClearTime_Never;//攻略界面		金钱获得
$Src_ReturnTime[111]= $Src_ClearTime_Never;//攻略界面		金钱获得
$Src_ReturnTime[112]= $Src_ClearTime_Never;//攻略界面		PVP活动
$Src_ReturnTime[113]= $Src_ClearTime_Never;//攻略界面		PVP活动
$Src_ReturnTime[114]= $Src_ClearTime_Never;//攻略界面		采矿
$Src_ReturnTime[115]= $Src_ClearTime_Never;//攻略界面		采矿
$Src_ReturnTime[116]= $Src_ClearTime_Never;//攻略界面		伐木
$Src_ReturnTime[117]= $Src_ClearTime_Never;//攻略界面		伐木
$Src_ReturnTime[118]= $Src_ClearTime_Never;//攻略界面		钓鱼
$Src_ReturnTime[119]= $Src_ClearTime_Never;//攻略界面		钓鱼
$Src_ReturnTime[120]= $Src_ClearTime_Never;//攻略界面		采药
$Src_ReturnTime[121]= $Src_ClearTime_Never;//攻略界面		采药
$Src_ReturnTime[122]= $Src_ClearTime_Never;//攻略界面		铸造
$Src_ReturnTime[123]= $Src_ClearTime_Never;//攻略界面		铸造
$Src_ReturnTime[124]= $Src_ClearTime_Never;//攻略界面		裁缝
$Src_ReturnTime[125]= $Src_ClearTime_Never;//攻略界面		裁缝
$Src_ReturnTime[126]= $Src_ClearTime_Never;//攻略界面		制器
$Src_ReturnTime[127]= $Src_ClearTime_Never;//攻略界面		制器
$Src_ReturnTime[128]= $Src_ClearTime_Never;//攻略界面		符咒
$Src_ReturnTime[129]= $Src_ClearTime_Never;//攻略界面		符咒
$Src_ReturnTime[130]= $Src_ClearTime_Never;//攻略界面		炼丹
$Src_ReturnTime[131]= $Src_ClearTime_Never;//攻略界面		炼丹
$Src_ReturnTime[132]= $Src_ClearTime_Never;//攻略界面		烹饪
$Src_ReturnTime[133]= $Src_ClearTime_Never;//攻略界面		烹饪
$Src_ReturnTime[134]= $Src_ClearTime_Never;//攻略界面		荣耀使者
$Src_ReturnTime[135]= $Src_ClearTime_Never;//攻略界面		荣耀使者
$Src_ReturnTime[136]= $Src_ClearTime_Never;//攻略界面		雕像使者
$Src_ReturnTime[137]= $Src_ClearTime_Never;//攻略界面		雕像使者
$Src_ReturnTime[138]= $Src_ClearTime_Never;//攻略界面		青丘狐王
$Src_ReturnTime[139]= $Src_ClearTime_Never;//攻略界面		青丘狐王
$Src_ReturnTime[140]= $Src_ClearTime_Never;//攻略界面		幽城鬼王
$Src_ReturnTime[141]= $Src_ClearTime_Never;//攻略界面		幽城鬼王
$Src_ReturnTime[142]= $Src_ClearTime_Never;//攻略界面		雪海魔君
$Src_ReturnTime[143]= $Src_ClearTime_Never;//攻略界面		雪海魔君
$Src_ReturnTime[144]= $Src_ClearTime_Never;//提取豪礼礼包0
$Src_ReturnTime[145]= $Src_ClearTime_Never;//提取豪礼礼包1
$Src_ReturnTime[146]= $Src_ClearTime_Never;//提取豪礼礼包2
$Src_ReturnTime[147]= $Src_ClearTime_Never;//提取豪礼礼包3
$Src_ReturnTime[148]= $Src_ClearTime_Never;//提取豪礼礼包4
$Src_ReturnTime[149]= $Src_ClearTime_Never;//提取豪礼礼包5
$Src_ReturnTime[150]= $Src_ClearTime_Never;//提取豪礼礼包6
$Src_ReturnTime[151]= $Src_ClearTime_Never;//提取豪礼礼包7
$Src_ReturnTime[152]= $Src_ClearTime_Never;//提取豪礼礼包8
$Src_ReturnTime[153]= $Src_ClearTime_Never;//提取豪礼礼包9
$Src_ReturnTime[154]= $Src_ClearTime_Never;//提取豪礼礼包10
$Src_ReturnTime[155]= $Src_ClearTime_Never;//提取豪礼礼包11
$Src_ReturnTime[156]= $Src_ClearTime_Never;//提取豪礼礼包12
$Src_ReturnTime[157]= $Src_ClearTime_Never;//提取豪礼礼包13
$Src_ReturnTime[158]= $Src_ClearTime_Never;//提取豪礼礼包14
$Src_ReturnTime[159]= $Src_ClearTime_Never;//提取豪礼礼包15
$Src_ReturnTime[160]= $Src_ClearTime_Never;//提取豪礼礼包16
$Src_ReturnTime[161]= $Src_ClearTime_Never;//提取豪礼礼包17
$Src_ReturnTime[162]= $Src_ClearTime_Never;//提取豪礼礼包18
$Src_ReturnTime[163]= $Src_ClearTime_Never;//提取豪礼礼包19
$Src_ReturnTime[164]= $Src_ClearTime_Never;//提取豪礼礼包20
$Src_ReturnTime[165]= $Src_ClearTime_Never;//提取豪礼礼包21
$Src_ReturnTime[166]= $Src_ClearTime_Never;//提取豪礼礼包22
$Src_ReturnTime[167]= $Src_ClearTime_Never;//提取豪礼礼包23
$Src_ReturnTime[168]= $Src_ClearTime_Never;//提取豪礼礼包24
$Src_ReturnTime[169]= $Src_ClearTime_Never;//提取豪礼礼包25
$Src_ReturnTime[170]= $Src_ClearTime_Never;//提取豪礼礼包26
$Src_ReturnTime[171]= $Src_ClearTime_Never;//提取豪礼礼包27
$Src_ReturnTime[172]= $Src_ClearTime_Never;//提取豪礼礼包28
$Src_ReturnTime[173]= $Src_ClearTime_Never;//提取豪礼礼包29
$Src_ReturnTime[174]= $Src_ClearTime_Never;//提取豪礼礼包30
$Src_ReturnTime[175]= $Src_ClearTime_Never;//提取豪礼礼包31
$Src_ReturnTime[176]= $Src_ClearTime_Never;//提取豪礼礼包32
$Src_ReturnTime[177]= $Src_ClearTime_Never;//提取豪礼礼包33
$Src_ReturnTime[178]= $Src_ClearTime_Never;//提取豪礼礼包34
$Src_ReturnTime[179]= $Src_ClearTime_Never;//新手在线奖励1
$Src_ReturnTime[180]= $Src_ClearTime_Never;//新手在线奖励2
$Src_ReturnTime[181]= $Src_ClearTime_Never;//新手在线奖励3
$Src_ReturnTime[182]= $Src_ClearTime_Never;//新手在线奖励4
$Src_ReturnTime[183]= $Src_ClearTime_Never;//新手在线奖励5
$Src_ReturnTime[184]= $Src_ClearTime_Never;//新手在线奖励6
$Src_ReturnTime[185]= $Src_ClearTime_Never;//新手在线奖励7
$Src_ReturnTime[186]= $Src_ClearTime_Never;//新手在线奖励8
$Src_ReturnTime[187]= $Src_ClearTime_Day;//今天是否去过灵脉
$Src_ReturnTime[188]= $Src_ClearTime_Never;//购买坐骑使用后的指引
$Src_ReturnTime[189]= $Src_ClearTime_Never;//生活技能1学习记录
$Src_ReturnTime[190]= $Src_ClearTime_Never;//生活技能2学习记录
$Src_ReturnTime[191]= $Src_ClearTime_Day;//云罗教主宝箱
$Src_ReturnTime[192]= $Src_ClearTime_Day;//云罗左护法宝箱
$Src_ReturnTime[193]= $Src_ClearTime_Day;//云罗右护法宝箱
$Src_ReturnTime[194]= $Src_ClearTime_Day;//云罗长老宝箱
$Src_ReturnTime[195]= $Src_ClearTime_Day;//帮派活动 每日工资记录
$Src_ReturnTime[196]= $Src_ClearTime_Day;//帮派活动 帮派捐献记录
$Src_ReturnTime[197]= $Src_ClearTime_Day;//帮派活动 收集灵魄记录
$Src_ReturnTime[198]= $Src_ClearTime_Day;//每日声望任务完成记录
$Src_ReturnTime[199]= $Src_ClearTime_Day;//首座论经额外奖励是否领取


function GetAll_SrcNumbers()
{
	$Src_ReturnTime_Never = 0;
	$Src_ReturnTime_Day = 0;
	$Src_ReturnTime_Week = 0;
	$Src_ReturnTime_Month = 0;
	for (%i=1; %i<=9999; %i++)
	{
		if ($Src_ReturnTime[%i] $="")
			break;
		switch ($Src_ReturnTime[%i])
		{
			case 0:
				$Src_ReturnTime_Never++;
				$Src_ReturnTime_Optype[%i] = $Src_ReturnTime_Never;
				%bit = $Src_ReturnTime_Never;
				%ActivityID = 2600;
			case 1:
				$Src_ReturnTime_Day++;
				$Src_ReturnTime_Optype[%i] = $Src_ReturnTime_Day;
				%bit = $Src_ReturnTime_Day;
				%ActivityID = 2700;
			case 2:
				$Src_ReturnTime_Week++;
				$Src_ReturnTime_Optype[%i] = $Src_ReturnTime_Week;
				%bit = $Src_ReturnTime_Week;
				%ActivityID = 2800;
			case 3:
				$Src_ReturnTime_Month++;
				$Src_ReturnTime_Optype[%i] = $Src_ReturnTime_Month;
				%bit = $Src_ReturnTime_Month;
				%ActivityID = 2900;
		}
		%ResutA = mfloor(%bit/30);
		%ResutB = %bit%30;
		if (%ResutB == 0)
		{
			%ResutA--;
			%ResutB = 30;
		}
		%ActivityID = %ActivityID + %ResutA;
		//%i ===68  %bit==30  %ResutA==0  %ResutB===30   %ActivityID==2601   存储 === 2601 30
		$Src_ReturnTime_ActivityID[%i] = %ActivityID @ " " @ %ResutB;
		//echo( "%i ===" @ %i @ "  %bit==" @ %bit @ "  %ResutA==" @ %ResutA @ "  %ResutB===" @ %ResutB @ "   %ActivityID==" @ %ActivityID @ "   存储 === " @ $Src_ReturnTime_ActivityID[ %i ] );

	}
}
GetAll_SrcNumbers();
//■■■■■■■■■■■【记录函数】■■■■■■■■■■■■■■■■■■■■■■
