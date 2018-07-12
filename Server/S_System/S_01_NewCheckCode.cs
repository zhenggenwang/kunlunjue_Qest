//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//所有活动数据编号表
//
//==================================================================================

//快速跳转入口，选中后使用F3即可，如果你不是用UE，那就帮不了你了

//■■■■■■■倒计时清除的值列表■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■获取0到24小时后的时间■■■■■■■■■■■■■■■■■■■■
$SetPlayGameReturnTime = 0;
function SetPlayGameReturnTime(%YY,%MM,%DD,%H,%M,%S)
{

	//在某一点清空值的Act方式
	//if(%H < 6)
	//	$PlayGameReturnTime[2] = %Year @ %MM @ %DD @ "0701";
	//else
	//	{
	//		if(%DD == %Mon[ %MM ])
	//			{
	//				%DD_A = "01";
	//				%MM_A = %MM + 1;
	//			}
	//			else
	//				{
	//					%DD_A = %DD + 1;
	//					%MM_A = %MM;
	//				}
	//		if(strlen(%MM_A) == 1)%MM_A = "0" @ %MM_A;
	//		if(strlen(%DD_A) == 1)%DD_A = "0" @ %DD_A;

	//		$PlayGameReturnTime[2] = %Year @ %MM_A @ %DD_A @ "0701";
	//	}
	if (%H >= 0 && %H < 4)%H4 = 0;
	else if (%H >= 4 && %H < 8)%H4 = 4;
	else if (%H >= 8 && %H < 12)%H4 = 8;
	else if (%H >= 12 && %H < 16)%H4 = 12;
	else if (%H >= 16 && %H < 20)%H4 = 16;
	else if (%H >= 20 && %H < 24)%H4 = 20;

	$XZL_ClearTime_Hour[1] = GetNeedTime(1,%YY,%MM,%DD,%H);//下一个小时整点清除
	$XZL_ClearTime_4Hour[1] = GetNeedTime(4,%YY,%MM,%DD,%H4);//
	$XZL_ClearTime_6Hour[1] = GetNeedTime(6,%YY,%MM,%DD,%H4);

	$XZL_ClearTime_Never[1] = 0;    //从不重置
	$XZL_ClearTime_Tomorrow[1] = 1;	//每日的01分重置，数组内以分钟为单位
	$XZL_ClearTime_week[1] = 2;			//每周的01周重置，数组内以周数为单位
	$XZL_ClearTime_month[1] = 3;		//每月的01号重置，数组内以月份为单位


	$PlayGameReturnTime[3015] = $XZL_ClearTime_Hour[1];//记录循环任务的CD	Npc编号：
	$PlayGameReturnTime[3016] = $XZL_ClearTime_Hour[1];//记录循环任务的CD	Npc编号：
	$PlayGameReturnTime[3017] = $XZL_ClearTime_Hour[1];//记录循环任务的CD	Npc编号：
	$PlayGameReturnTime[3018] = $XZL_ClearTime_Hour[1];//记录循环任务的CD	Npc编号：
	$PlayGameReturnTime[3019] = $XZL_ClearTime_Hour[1];//记录循环任务的CD	Npc编号：
	$PlayGameReturnTime[3020] = $XZL_ClearTime_Hour[1];//记录循环任务的CD	Npc编号：

	$PlayGameReturnTime[3032] =$XZL_ClearTime_4Hour[1];//随机商店的记录
	$PlayGameReturnTime[3033] =$XZL_ClearTime_4Hour[1];//随机商店的记录
	$PlayGameReturnTime[3034] =$XZL_ClearTime_4Hour[1];//随机商店的记录
	$PlayGameReturnTime[3035] =$XZL_ClearTime_4Hour[1];//随机商店的记录
	$PlayGameReturnTime[3036] =$XZL_ClearTime_4Hour[1];//随机商店的记录
	$PlayGameReturnTime[3037] =$XZL_ClearTime_4Hour[1];//随机商店的记录

	$PlayGameReturnTime[3998] = $XZL_ClearTime_Never[1];//用于记录在版本更新后是否需要重置随机商店
	$PlayGameReturnTime[3999] = $XZL_ClearTime_Tomorrow[1];//随机商店的记录 0位免费次数记录 1位暂时空着
	$PlayGameReturnTime[4000] =$XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4001] =$XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4002] =$XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4003] =$XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4004] =$XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4005] =$XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4006] =$XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4007] =$XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4008] =$XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4009] =$XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4010] =$XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4011] =$XZL_ClearTime_6Hour[1];//随机商店的记录
	//控制下面的各个时间设置，只需要执行1次即可
	if ($SetPlayGameReturnTime == 0)
		$SetPlayGameReturnTime = 1;
	else
		return;

	for (%i=0; %i<=99; %i++)//这部分用来做SetSrc函数的位运算记录所用
	{
		$PlayGameReturnTime[2600 + %i] = $XZL_ClearTime_Never[1];
		$PlayGameReturnTime[2700 + %i] = $XZL_ClearTime_Tomorrow[1];
		$PlayGameReturnTime[2800 + %i] = $XZL_ClearTime_week[1];
		$PlayGameReturnTime[2900 + %i] = $XZL_ClearTime_month[1];
	}

	//$PlayGameReturnTime[1] = %Day_ReturnTime;			//女娲补天活动重置时间：今日的23点59分

	$PlayGameReturnTime[2209] = $XZL_ClearTime_Tomorrow[1];//金币复活次数记录
	$PlayGameReturnTime[3001] = $XZL_ClearTime_Tomorrow[1];//群英汇聚

	$PlayGameReturnTime[3002] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020005] =3002;//记录循环任务的CD	Npc编号：411020005
	$PlayGameReturnTime[3003] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020001] =3003;//记录循环任务的CD	Npc编号：411020001
	$PlayGameReturnTime[3004] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020002] =3004;//记录循环任务的CD	Npc编号：411020002
	$PlayGameReturnTime[3005] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020003] =3005;//记录循环任务的CD	Npc编号：411020003
	$PlayGameReturnTime[3006] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020004] =3006;//记录循环任务的CD	Npc编号：411020004
	$PlayGameReturnTime[3007] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020101] =3007;//记录循环任务的CD	Npc编号：411020101
	$PlayGameReturnTime[3008] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020121] =3008;//记录循环任务的CD	Npc编号：411020121
	$PlayGameReturnTime[3009] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020141] =3009;//记录循环任务的CD	Npc编号：411020141
	$PlayGameReturnTime[3010] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020161] =3010;//记录循环任务的CD	Npc编号：411020161
	$PlayGameReturnTime[3011] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020181] =3011;//记录循环任务的CD	Npc编号：411020181
	$PlayGameReturnTime[3012] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020221] =3012;//记录循环任务的CD	Npc编号：411020221
	$PlayGameReturnTime[3013] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020241] =3013;//记录循环任务的CD	Npc编号：411020241
	$PlayGameReturnTime[3014] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020261] =3014;//记录循环任务的CD	Npc编号：411020261

	$PlayGameReturnTime[3015] = $XZL_ClearTime_Hour[1];//记录循环任务的CD	Npc编号：
	$PlayGameReturnTime[3016] = $XZL_ClearTime_Hour[1];//记录循环任务的CD	Npc编号：
	$PlayGameReturnTime[3017] = $XZL_ClearTime_Hour[1];//记录循环任务的CD	Npc编号：
	$PlayGameReturnTime[3018] = $XZL_ClearTime_Hour[1];//记录循环任务的CD	Npc编号：
	$PlayGameReturnTime[3019] = $XZL_ClearTime_Hour[1];//记录循环任务的CD	Npc编号：
	$PlayGameReturnTime[3020] = $XZL_ClearTime_Hour[1];//记录循环任务的CD	Npc编号：


	$PlayGameReturnTime[3028] = $XZL_ClearTime_Tomorrow[1];//奖励领取状况
	$PlayGameReturnTime[3029] = $XZL_ClearTime_Tomorrow[1];//时空裂痕
	$PlayGameReturnTime[3030] = $XZL_ClearTime_Tomorrow[1];//炼魔渊 0位 免费次数是否使用 1位收费次数记录
	$PlayGameReturnTime[3031] = $XZL_ClearTime_Never[1];//角色存储的双倍时间

	$PlayGameReturnTime[3032] =$XZL_ClearTime_4Hour[1];//随机商店的记录
	$PlayGameReturnTime[3033] =$XZL_ClearTime_4Hour[1];//随机商店的记录
	$PlayGameReturnTime[3034] =$XZL_ClearTime_4Hour[1];//随机商店的记录
	$PlayGameReturnTime[3035] =$XZL_ClearTime_4Hour[1];//随机商店的记录
	$PlayGameReturnTime[3036] =$XZL_ClearTime_4Hour[1];//随机商店的记录
	$PlayGameReturnTime[3037] =$XZL_ClearTime_4Hour[1];//随机商店的记录

	$PlayGameReturnTime[3038] = $XZL_ClearTime_Tomorrow[1];//聚宝盆记录 0位 免费次数剩余 + 已经使用元宝兑换次数记录, 1位 今日兑换次数总记录

	$PlayGameReturnTime[3998] = $XZL_ClearTime_Never[1];//用于记录在版本更新后是否需要重置随机商店 0位记录 1位展示空着
	$PlayGameReturnTime[3999] = $XZL_ClearTime_Tomorrow[1];//随机商店的记录 0位免费次数记录 1位暂时空着
	$PlayGameReturnTime[4000] = $XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4001] = $XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4002] = $XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4003] = $XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4004] = $XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4005] = $XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4006] = $XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4007] = $XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4008] = $XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4009] = $XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4010] = $XZL_ClearTime_6Hour[1];//随机商店的记录
	$PlayGameReturnTime[4011] = $XZL_ClearTime_6Hour[1];//随机商店的记录

	$PlayGameReturnTime[4012] =$XZL_ClearTime_Tomorrow[1];//藏宝图活动记录  0位 诛妖任务次数 1位藏宝图开启次数
	$PlayGameReturnTime[4013] =$XZL_ClearTime_Never[1];//诛妖任务的坐标记录
	$PlayGameReturnTime[4014] =$XZL_ClearTime_Never[1];//藏宝图挖宝的坐标记录
	$PlayGameReturnTime[4015] =$XZL_ClearTime_Tomorrow[1];//0位 记录师门任务完成了几次  1位 放弃任务几次
	$PlayGameReturnTime[4016] =$XZL_ClearTime_Tomorrow[1];//0位 今天第几次参加  1位 记录打到了第几关
	$PlayGameReturnTime[4017] =$XZL_ClearTime_Never[1];//0位 记录玩家总共参与仙缘解签活动参与的总次数，永不清除
	$PlayGameReturnTime[4018] =$XZL_ClearTime_Tomorrow[1];// 押镖活动记录 0位记录当前接镖几次 1位记录现在的押镖状态
	$PlayGameReturnTime[4019] =$XZL_ClearTime_Never[1];//玩家归属线 0位 最初创建角色时的线ID 1位 当前所在的线ID
	$PlayGameReturnTime[4020] =$XZL_ClearTime_month[1];//记录玩家登录签到功能 0位 1号到15号 1位 16号到31号
	$PlayGameReturnTime[4021] =$XZL_ClearTime_Never[1];//记录玩家新建角色 7天送好礼 0位角色创建时间 1位 根据bit值记录是否已经领取该奖励
	$PlayGameReturnTime[4022] =$XZL_ClearTime_Tomorrow[1];//蓬莱仙钓活动记录  0位 是否已经兑换过鱼饵 1位 今天钓了几条鱼
	$PlayGameReturnTime[4023] =$XZL_ClearTime_Tomorrow[1];//聆经悟道记录 0位 今天兑换了聆经牌几块 1位 今天聆经悟道多少次
	$PlayGameReturnTime[4024] =$XZL_ClearTime_Tomorrow[1];//首座论经 0位 答对了几题 1位 答错了几题

	$PlayGameReturnTime[4025] =$XZL_ClearTime_Never[1];//悬赏缉凶 身上的任务记录 0位 任务编号 1位 任务颜色品质
	$PlayGameReturnTime[4026] =$XZL_ClearTime_Never[1];//悬赏缉凶 身上的任务记录 0位 任务编号 1位 任务颜色品质
	$PlayGameReturnTime[4027] =$XZL_ClearTime_Never[1];//悬赏缉凶 身上的任务记录 0位 任务编号 1位 任务颜色品质
	$PlayGameReturnTime[4028] =$XZL_ClearTime_Never[1];//悬赏缉凶 身上的任务记录 0位 任务编号 1位 任务颜色品质
	$PlayGameReturnTime[4029] =$XZL_ClearTime_Never[1];//悬赏缉凶 身上的任务记录 0位 任务编号 1位 任务颜色品质

	$PlayGameReturnTime[4030] = $XZL_ClearTime_Never[1];//悬赏缉凶 1101地图 第0个任务
	$PlayGameReturnTime[4031] = $XZL_ClearTime_Never[1];//悬赏缉凶 1101地图 第1个任务
	$PlayGameReturnTime[4032] = $XZL_ClearTime_Never[1];//悬赏缉凶 1101地图 第2个任务
	$PlayGameReturnTime[4033] = $XZL_ClearTime_Never[1];//悬赏缉凶 1101地图 第3个任务
	$PlayGameReturnTime[4034] = $XZL_ClearTime_Never[1];//悬赏缉凶 1101地图 第4个任务
	$PlayGameReturnTime[4035] = $XZL_ClearTime_Never[1];//悬赏缉凶 1101地图 第5个任务
	$PlayGameReturnTime[4036] = $XZL_ClearTime_Never[1];//悬赏缉凶 1101地图 第6个任务
	$PlayGameReturnTime[4037] = $XZL_ClearTime_Never[1];//悬赏缉凶 1101地图 第7个任务
	$PlayGameReturnTime[4038] = $XZL_ClearTime_Never[1];//悬赏缉凶 1101地图 第8个任务
	$PlayGameReturnTime[4039] = $XZL_ClearTime_Never[1];//悬赏缉凶 1101地图 第9个任务
	$PlayGameReturnTime[4040] = $XZL_ClearTime_Never[1];//悬赏缉凶 1102地图 第0个任务
	$PlayGameReturnTime[4041] = $XZL_ClearTime_Never[1];//悬赏缉凶 1102地图 第1个任务
	$PlayGameReturnTime[4042] = $XZL_ClearTime_Never[1];//悬赏缉凶 1102地图 第2个任务
	$PlayGameReturnTime[4043] = $XZL_ClearTime_Never[1];//悬赏缉凶 1102地图 第3个任务
	$PlayGameReturnTime[4044] = $XZL_ClearTime_Never[1];//悬赏缉凶 1102地图 第4个任务
	$PlayGameReturnTime[4045] = $XZL_ClearTime_Never[1];//悬赏缉凶 1102地图 第5个任务
	$PlayGameReturnTime[4046] = $XZL_ClearTime_Never[1];//悬赏缉凶 1102地图 第6个任务
	$PlayGameReturnTime[4047] = $XZL_ClearTime_Never[1];//悬赏缉凶 1102地图 第7个任务
	$PlayGameReturnTime[4048] = $XZL_ClearTime_Never[1];//悬赏缉凶 1102地图 第8个任务
	$PlayGameReturnTime[4049] = $XZL_ClearTime_Never[1];//悬赏缉凶 1102地图 第9个任务
	$PlayGameReturnTime[4050] = $XZL_ClearTime_Never[1];//悬赏缉凶 1103地图 第0个任务
	$PlayGameReturnTime[4051] = $XZL_ClearTime_Never[1];//悬赏缉凶 1103地图 第1个任务
	$PlayGameReturnTime[4052] = $XZL_ClearTime_Never[1];//悬赏缉凶 1103地图 第2个任务
	$PlayGameReturnTime[4053] = $XZL_ClearTime_Never[1];//悬赏缉凶 1103地图 第3个任务
	$PlayGameReturnTime[4054] = $XZL_ClearTime_Never[1];//悬赏缉凶 1103地图 第4个任务
	$PlayGameReturnTime[4055] = $XZL_ClearTime_Never[1];//悬赏缉凶 1103地图 第5个任务
	$PlayGameReturnTime[4056] = $XZL_ClearTime_Never[1];//悬赏缉凶 1103地图 第6个任务
	$PlayGameReturnTime[4057] = $XZL_ClearTime_Never[1];//悬赏缉凶 1103地图 第7个任务
	$PlayGameReturnTime[4058] = $XZL_ClearTime_Never[1];//悬赏缉凶 1103地图 第8个任务
	$PlayGameReturnTime[4059] = $XZL_ClearTime_Never[1];//悬赏缉凶 1103地图 第9个任务
	$PlayGameReturnTime[4060] = $XZL_ClearTime_Never[1];//悬赏缉凶 1104地图 第0个任务
	$PlayGameReturnTime[4061] = $XZL_ClearTime_Never[1];//悬赏缉凶 1104地图 第1个任务
	$PlayGameReturnTime[4062] = $XZL_ClearTime_Never[1];//悬赏缉凶 1104地图 第2个任务
	$PlayGameReturnTime[4063] = $XZL_ClearTime_Never[1];//悬赏缉凶 1104地图 第3个任务
	$PlayGameReturnTime[4064] = $XZL_ClearTime_Never[1];//悬赏缉凶 1104地图 第4个任务
	$PlayGameReturnTime[4065] = $XZL_ClearTime_Never[1];//悬赏缉凶 1104地图 第5个任务
	$PlayGameReturnTime[4066] = $XZL_ClearTime_Never[1];//悬赏缉凶 1104地图 第6个任务
	$PlayGameReturnTime[4067] = $XZL_ClearTime_Never[1];//悬赏缉凶 1104地图 第7个任务
	$PlayGameReturnTime[4068] = $XZL_ClearTime_Never[1];//悬赏缉凶 1104地图 第8个任务
	$PlayGameReturnTime[4069] = $XZL_ClearTime_Never[1];//悬赏缉凶 1104地图 第9个任务
	$PlayGameReturnTime[4070] = $XZL_ClearTime_Never[1];//悬赏缉凶 1105地图 第0个任务
	$PlayGameReturnTime[4071] = $XZL_ClearTime_Never[1];//悬赏缉凶 1105地图 第1个任务
	$PlayGameReturnTime[4072] = $XZL_ClearTime_Never[1];//悬赏缉凶 1105地图 第2个任务
	$PlayGameReturnTime[4073] = $XZL_ClearTime_Never[1];//悬赏缉凶 1105地图 第3个任务
	$PlayGameReturnTime[4074] = $XZL_ClearTime_Never[1];//悬赏缉凶 1105地图 第4个任务
	$PlayGameReturnTime[4075] = $XZL_ClearTime_Never[1];//悬赏缉凶 1105地图 第5个任务
	$PlayGameReturnTime[4076] = $XZL_ClearTime_Never[1];//悬赏缉凶 1105地图 第6个任务
	$PlayGameReturnTime[4077] = $XZL_ClearTime_Never[1];//悬赏缉凶 1105地图 第7个任务
	$PlayGameReturnTime[4078] = $XZL_ClearTime_Never[1];//悬赏缉凶 1105地图 第8个任务
	$PlayGameReturnTime[4079] = $XZL_ClearTime_Never[1];//悬赏缉凶 1105地图 第9个任务
	$PlayGameReturnTime[4080] = $XZL_ClearTime_Never[1];//悬赏缉凶 1106地图 第0个任务
	$PlayGameReturnTime[4081] = $XZL_ClearTime_Never[1];//悬赏缉凶 1106地图 第1个任务
	$PlayGameReturnTime[4082] = $XZL_ClearTime_Never[1];//悬赏缉凶 1106地图 第2个任务
	$PlayGameReturnTime[4083] = $XZL_ClearTime_Never[1];//悬赏缉凶 1106地图 第3个任务
	$PlayGameReturnTime[4084] = $XZL_ClearTime_Never[1];//悬赏缉凶 1106地图 第4个任务
	$PlayGameReturnTime[4085] = $XZL_ClearTime_Never[1];//悬赏缉凶 1106地图 第5个任务
	$PlayGameReturnTime[4086] = $XZL_ClearTime_Never[1];//悬赏缉凶 1106地图 第6个任务
	$PlayGameReturnTime[4087] = $XZL_ClearTime_Never[1];//悬赏缉凶 1106地图 第7个任务
	$PlayGameReturnTime[4088] = $XZL_ClearTime_Never[1];//悬赏缉凶 1106地图 第8个任务
	$PlayGameReturnTime[4089] = $XZL_ClearTime_Never[1];//悬赏缉凶 1106地图 第9个任务

	$PlayGameReturnTime[4090] = $XZL_ClearTime_Tomorrow[1];//悬赏缉凶 0位 已经使用免费刷新的次数 1位 使用道具刷新的次数
	$PlayGameReturnTime[4091] = $XZL_ClearTime_Tomorrow[1];//星魂刷新记录 0位 当前星魂级别 1位 今日历史最高级别
	$PlayGameReturnTime[4092] = $XZL_ClearTime_Tomorrow[1];//悬赏缉凶  0位 今日完成次数 1位 今日完成的最高品质任务
	$PlayGameReturnTime[4093] = $XZL_ClearTime_Tomorrow[1];//黄金宝藏  0位 今日进入副本次数 1位最近一次打到了低级关
	$PlayGameReturnTime[4094] = $XZL_ClearTime_Never[1];//刀剑神域  0位 记录上次参加战场的时间 1位 记录上次战场的排名
	$PlayGameReturnTime[4095] = $XZL_ClearTime_Tomorrow[1];//记录每日充值 0位 bit计算领取哪些礼包 1位 今天充值数量
	$PlayGameReturnTime[4096] = $XZL_ClearTime_Tomorrow[1];//时尚好礼
	$PlayGameReturnTime[4097] = $XZL_ClearTime_Never[1];//记录首充礼包 0位 1领取0没有领取 1位 当前充值额度
	$PlayGameReturnTime[4098] = $XZL_ClearTime_Tomorrow[1];//记录紫星传功 0位 今日接取次数
	$PlayGameReturnTime[4099] = $XZL_ClearTime_Tomorrow[1];//记录趣味答题的双倍功能使用次数
	$PlayGameReturnTime[4100] = $XZL_ClearTime_week[1];//记录每周排行榜称号奖励
	$PlayGameReturnTime[4101] = $XZL_ClearTime_Tomorrow[1];//记录趣味答题的答题次数

	$PlayGameReturnTime[4102] = $XZL_ClearTime_Tomorrow[1];//帮派活动	妖灵天宫记录
	$PlayGameReturnTime[4103] = $XZL_ClearTime_Tomorrow[1];//帮派活动	封神秘境记录
	$PlayGameReturnTime[4104] = $XZL_ClearTime_week[1];//帮派活动	帮会七重天记录
		 
	$PlayGameReturnTime[4105] = $XZL_ClearTime_Never[1];//战门
	$PlayGameReturnTime[4106] = $XZL_ClearTime_Never[1];//法门
	$PlayGameReturnTime[4107] = $XZL_ClearTime_Never[1];//道门
	$PlayGameReturnTime[4108] = $XZL_ClearTime_Never[1];//刺门
	$PlayGameReturnTime[4109] = $XZL_ClearTime_Never[1];//弓门
	$PlayGameReturnTime[4110] = $XZL_ClearTime_Never[1];//望仙镇
	$PlayGameReturnTime[4111] = $XZL_ClearTime_Never[1];//白虎寨
	$PlayGameReturnTime[4112] = $XZL_ClearTime_Never[1];//泽云度
	$PlayGameReturnTime[4113] = $XZL_ClearTime_Never[1];//蛮荒神殿
	$PlayGameReturnTime[4114] = $XZL_ClearTime_Never[1];//香海禅林
	$PlayGameReturnTime[4115] = $XZL_ClearTime_Never[1];//昆仑废墟
	$PlayGameReturnTime[4116] = $XZL_ClearTime_Never[1];//文采
	$PlayGameReturnTime[4117] = $XZL_ClearTime_Never[1];//忠义
	$PlayGameReturnTime[4118] = $XZL_ClearTime_Never[1];//师徒
	$PlayGameReturnTime[4119] = $XZL_ClearTime_Never[1];//鲜花
	$PlayGameReturnTime[4120] = $XZL_ClearTime_Never[1];//绿叶
	$PlayGameReturnTime[4121] = $XZL_ClearTime_Never[1];//狭义
	$PlayGameReturnTime[4122] = $XZL_ClearTime_Never[1];//挑战首领
	
	$PlayGameReturnTime[4123] = $XZL_ClearTime_Never[1];//畅玩特权
	$PlayGameReturnTime[4124] = $XZL_ClearTime_Never[1];//尊享礼遇
	//4124 ~ 4129 备用：xxxx特权  其它功能请从4130开始
	$PlayGameReturnTime[4128] = $XZL_ClearTime_week[1];		 //尊享礼遇：记录每一项奖励领取状态14
	$PlayGameReturnTime[4129] = $XZL_ClearTime_Tomorrow[1];//尊享礼遇：记录每一项奖励领取状态1-13
	
	//连续5天充值送豪礼
	$PlayGameReturnTime[4130] = $XZL_ClearTime_Tomorrow[1];	//0每日提取元宝总量
	$PlayGameReturnTime[4131] = $XZL_ClearTime_Never[1];		//0是否可以领取奖励（第0-7位）,1表示是否已领取奖励（第0-7位）
	
	//我的形象我做主
	$PlayGameReturnTime[4132] = $XZL_ClearTime_Tomorrow[1];	//时装，0礼包、1特价
	$PlayGameReturnTime[4133] = $XZL_ClearTime_Tomorrow[1];	//坐骑，0礼包、1特价
	
	//悠享基金
	$PlayGameReturnTime[4134] = $XZL_ClearTime_Tomorrow[1];	//是否已经领取奖励
	
	$PlayGameReturnTime[4135] = $XZL_ClearTime_Never[1];	//帮派贡献
	
	//悠享基金
	$PlayGameReturnTime[4136] = $XZL_ClearTime_Never[1];	//是否已经购买过【悠享基金】
	
	
	
	//限时抢购4200~4299
	$PlayGameReturnTime[4200] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4201] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4202] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4203] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4204] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4205] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4206] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4207] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4208] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4209] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4210] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4211] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4212] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4213] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4214] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4215] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4216] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4217] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4218] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4219] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4220] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4221] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4222] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4223] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4224] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4225] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4226] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4227] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4228] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4229] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	$PlayGameReturnTime[4230] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	//4200~4299
	$PlayGameReturnTime[4299] = $XZL_ClearTime_Never[1];	//每件物品的限购数量
	
	$PlayGameReturnTime[4300] = $XZL_ClearTime_Tomorrow[1];	//道经使用次数
	
	
	//-----------10000~19999 编号给商城用了，记录购买次数----------------
}

//■■■■■■■倒计时清除的值列表■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■获取0到24小时后的时间■■■■■■■■■■■■■■■■■■■■
function GetNeedTime(%NeedTime,%YY,%MM,%DD,%H)//获取几个小时后的时间,精确到小时
{

	//获取本年是否为闰年
	if ((%YY == 2012)||(%YY == 2016)||(%YY == 2020)||(%YY == 2024)||(%YY == 2028)||(%YY == 2032))
		%Mon[02] = 29;
	else
		%Mon[02] = 28;

	%Mon[01] = 31;
	%Mon[03] = 31;
	%Mon[04] = 30;
	%Mon[05] = 31;
	%Mon[06] = 30;
	%Mon[07] = 31;
	%Mon[08] = 31;
	%Mon[09] = 30;
	%Mon[10] = 31;
	%Mon[11] = 30;
	%Mon[12] = 31;
	//------------计算时间-----------
	%H = %H + %NeedTime;
	if (%H >= 24)
	{
		%H = %H - 24;
		%DD++;
		if (%DD > %Mon[%MM])
		{
			%DD = "01";
			%MM++;
			if (%MM > 12)
			{
				%MM = "01";
				%YY++;
			}
		}
	}
	//将不足两位的补成两位
	%Year = GetSubStr(%YY,2,2);
	if (strlen(%MM) == 1)%MM = "0" @ %MM;
	if (strlen(%DD) == 1)%DD = "0" @ %DD;
	if (strlen(%H) == 1)%H = "0" @ %H;
	//echo( "Time===" @ %Year @ %MM @ %DD @ %H @ "00" );
	return %Year @ %MM @ %DD @ %H @ "00";
}
//■■■■■■■获取0到24小时后的时间■■■■■■■■■■■■■■■■■■■■
