//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//客户端与服务端共用的脚本函数
//==================================================================================

function UPCS_CS(%Num)
{
	//if( (%Num == 0 )||(%Num == 99) ){Exec("./HuoDong/DT_00_Function.cs");}

	if ((%Num == 1)||(%Num == 99)){ Exec("./SL_C_S_FenJie_HeChen.cs"); }
	if ((%Num == 2)||(%Num == 99)){ Exec("./SL_C_S_Final_Variables.cs"); }
	if ((%Num == 3)||(%Num == 99)){ Exec("./SL_C_S_Mission_Need.cs"); }
	if ((%Num == 4)||(%Num == 99)){ Exec("./SL_C_S_Prescription.cs"); }

	if ((%Num == 6)||(%Num == 99)){ Exec("./SL_C_S_GiftPacks.cs"); }
	if ((%Num == 7)||(%Num == 99)){ Exec("./SL_C_S_Mission_Manage.cs"); }
	if ((%Num == 8)||(%Num == 99)){ Exec("./SL_C_S_configuration.cs"); }
	if ((%Num == 9)||(%Num == 99)){ Exec("./SL_C_S_ActivityRecord.cs"); }
	if ((%Num == 10)||(%Num == 99)){ Exec("./SL_C_S_StrategyText.cs"); }
	if ((%Num == 11)||(%Num == 99)){ Exec("./SL_C_S_Mission_Begin_Front.cs"); }
	if ((%Num == 12)||(%Num == 99)){ Exec("./SL_C_S_Mission_End_Front.cs"); }
}

Schedule(1000,0,"UPCS_CS",99);

//■■■■■■■■■■■【月光宝盒文字内容】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【封装后台输出函数】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【取余数】■■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【获取野外切线是否允许】■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【获取聚宝盆是否开启】■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【获取当前玩家转生等级】■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【获取是否在活动时间内】■■■■■■■■■■■■■■■■
//■■■■■■■■■■■复活消耗计算■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【神将秦琼设置华山论剑次数上线】■■■■■■■■■■■■
//■■■■■■■■■■■【设置地图标记增加次数】■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【获取各种Data名称】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■界面飞行功能■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【获取从2000年后的某天】■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【获取VIP等级】■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【洗炼丹消耗】■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【判断武魂界面开启条件】■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【提升化身境界时触发】■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【指定对象发送特效】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【获取任务的类型】■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【获取不重复的随机数】■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【获取指定位的bit值】■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【采集掉物前置判断脚本】■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【获得任务名称脚本（程序用）】■■■■■■■■■■■■■
//■■■■■■■■■■■【仓库扩展相关判断脚本】■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【判断对象是否为玩家】■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【获取帮派跑商任务的奖励】■■■■■■■■■■■■■■■
//■■■■■■■■■■■【获取两个时间之间的间隔天数】■■■■■■■■■■■■■
//■■■■■■■■■■■【获取下几天的日期】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【神兽元抗进阶相关脚本】■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【神兽称号功能】■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【获取千里眼查询次数】■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【位运算功能】■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【返回星宿功能所需内容】■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【获取玩家出身地函数】■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【灵兽元抗进阶相关脚本】■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【设置免费观星次数】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【官职系统，判断玩家当前是文，武官的哪一品阶】■■■■■
//■■■■■■■■■■■【获得玩家所属主城势力】■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【获取该玩家当前可以领取的竞技场奖励】■■■■■■■■■
//■■■■■■■■■■■【区域变化触发区域优先级脚本】■■■■■■■■■■■■■
//■■■■■■■■■■■【货币显示通用脚本】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【获取bit值和act值的函数】■■■■■■■■■■■■■■■
//■■■■■■■■■■■【签到----取值函数】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【活跃----活跃度计算】■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【传送地图前置判断】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【发公告前的各种准备】■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■处理寻径按钮计数■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【角色进入战斗触发脚本】■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【大小比较函数】■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【怪物战斗力】相关■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■返回道具真实ID和数量■■■■■■■■■■■■■■■■■■
//■■■■■■■■道经■获取元宝消耗■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【获取随机装备】■■■■■■■■■■■■■■■■■■■■







//■■■■■■■■■■■【月光宝盒文字内容】■■■■■■■■■■■■■■■■■■
function Get_YGBH_Dialog(%Npc,%Player,%DialogID,%Param)
{
	switch (%DialogID)
	{
		//----------------------第一类功能-----基础属性设置------------------------------------------
		case 1000000000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>出来吧流浪狗</t>";
		case 1000000100:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>领取月光宝盒</t>";
		case 1000000200:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>打开师门商店</t>";
		case 1000000300:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>打开测试商店</t>";
		case 1000000400:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>打开仓库</t>";
		case 1000000500:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>打开邮箱</t>";

		case 1001000000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>基础属性设置</t>";

		case 1001010000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>角色等级修改</t>";

		case 1001010100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>↑↑↑等级上调最高</t>";
		case 1001010200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>↑↑↑等级上调10级</t>";
		case 1001010300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>↑↑↑等级上调5级</t>";
		case 1001010400:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>↑↑↑等级上调1级</t>";
		case 1001010500:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>↓↓↓等级下调1级</t>";
		case 1001010600:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>↓↓↓等级下调5级</t>";
		case 1001010700:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>↓↓↓等级下调10级</t>";
		case 1001010800:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>↓↓↓等级下调最低</t>";

		case 1001020000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加各种经验</t>";

		case 1001020100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>角色经验</t>";
			//case 1001020200:%Text[ 3 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>神兽经验</t>";

		case 1001030000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加各种金钱</t>";

		case 1001030100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>元宝</t>";
		case 1001030200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>金币</t>";
		case 1001030300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>绑定元宝</t>";
		case 1001030400:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>仓库元宝</t>";
		case 1001030500:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>活跃积分</t>";
		case 1001030600:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>战场积分</t>";
		case 1001030700:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>MDZZ！</t>";

		case 1001040000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>一键技能和装备</t>";
			//----------------------第二类功能-----传送世界地图------------------------------------------
		case 1002000000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>传送世界地图</t>";

		case 1002010000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>传送『昆仑』[主城]</t>";

		case 1002020000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>传送『蓬莱』[新手]</t>";

		case 1002030000:%Text[2] = $Get_Dialog_GeShi[31404] @ "<t>------华丽的分割线------</t>";

		case 1002040000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>传送『野外』[普通]</t>";

		case 1002040100:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【望仙岭】</t>";
		case 1002040200:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【苍山雪海】</t>";
		case 1002040300:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【云梦沼泽】</t>";
		case 1002040400:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【神弃荒原】</t>";
		case 1002040500:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【香海禅林】</t>";
		case 1002040600:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【昆仑废墟】</t>";
		case 1002041800:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【镇魔殿】</t>";
		case 1002041900:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【封魔城】</t>";
		case 1002049900:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【测试地图】</t>";

		case 1002050000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>传送『地宫』[普通]</t>";

		case 1002050100:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【冰火试炼1层】	</t>";
		case 1002050200:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【冰火试炼2层】	</t>";
		case 1002050300:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【冰火试炼3层】	</t>";
		case 1002050400:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【逐鹿之野】	</t>";
		case 1002050500:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【陨仙窟1层】	</t>";
		case 1002050600:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【陨仙窟2层】	</t>";
		case 1002050700:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【落日神陵1层】	</t>";
		case 1002050800:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【落日神陵2层】	</t>";
		case 1002050900:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【落日神陵3层】	</t>";
		case 1002051000:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【落日神陵4层】	</t>";
		case 1002051100:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【深海迷宫1层】	</t>";
		case 1002051200:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【深海迷宫2层】	</t>";
		case 1002051300:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【深海迷宫3层】	</t>";
		case 1002051400:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【深海迷宫4层】	</t>";

		case 1002060000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>传送『其它』[普通]</t>";

		case 1002070000:%Text[2] = $Get_Dialog_GeShi[31404] @ "<t>------分割线的逆袭------</t>";

		case 1002080000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>传送『活动』[副本]</t>";

		case 1002080100:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【时空裂痕】</t>";
		case 1002080200:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【炼魔渊】</t>";
		case 1002080300:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【蓬莱禁地】</t>";
		case 1002080400:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【心魔幻境】</t>";
		case 1002080500:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【诛神问心阵】</t>";
		case 1002080600:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【血魔封印阵】</t>";
		case 1002080700:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【黄金宝藏】</t>";
		case 1002080800:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【云罗镜】</t>";
		case 1002080900:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【妖灵迷宫】</t>";
		case 1002081000:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【封神秘境】</t>";

		case 1002090000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>传送『剧情』[副本]</t>";

		case 1002100000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>传送『战场』[副本]</t>";

		case 1002100100:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【幻境争霸】</t>";
		case 1002100200:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【鸿蒙试炼。低级】</t>";
		case 1002100300:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【鸿蒙试炼。中级】</t>";
		case 1002100400:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【鸿蒙试炼。高级】</t>";
		case 1002100500:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【江山社稷】</t>";
		case 1002100600:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>传送【刀剑神域】</t>";

		case 1002110000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>传送『其它』[副本]</t>";
			//----------------------第三类功能-----添加各种状态------------------------------------------
		case 1003000000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加各种状态</t>";

		case 1003010000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>战斗BUFF类</t>";

		case 1003010100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>无敌状态</t>";
		case 1003010200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>满血满蓝</t>";

		case 1003020000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>调度BUFF类</t>";

		case 1003030000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>清除各种状态</t>";

		case 1003030100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>清除不健康状态</t>";
		case 1003030200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>清除安全时间</t>";
		case 1003030300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>清除二级密码</t>";
		case 1003030400:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>一键清除上面所有</t>";

		case 1003040000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加测试技能</t>";

		case 1003040100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>污妖王之怒</t>";

			//----------------------第四类功能-----编号创建东西------------------------------------------
		case 1004000000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>编号创建东西</t>";

		case 1004010000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>界面刷新怪物</t>";
		case 1004020000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>界面刷新道具</t>";
		case 1004030000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>界面刷新采集</t>";
		case 1004040000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>界面接受任务</t>";
		case 1004050000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>界面添加神兽</t>";
		case 1004060000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加技能BUFF</t>";
			//----------------------第五类功能-----生活技能相关------------------------------------------
		case 1005000000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>生活技能相关</t>";

		case 1005010000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>学习一级技能</t>";
		case 1005020000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>学习满级技能</t>";
		case 1005030000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>增加熟练度</t>";
			//case 1005040000:%Text[ 1 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>工艺技能学习</t>";
			//case 1005050000:%Text[ 1 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>裁缝技能学习</t>";
			//case 1005060000:%Text[ 1 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>铸造技能学习</t>";
			//case 1005070000:%Text[ 1 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>采药技能学习</t>";
			//case 1005080000:%Text[ 1 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>钓鱼技能学习</t>";
			//case 1005090000:%Text[ 1 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>伐木技能学习</t>";
			//case 1005100000:%Text[ 1 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>烹饪技能学习</t>";
			//case 1005010000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>获取矿锄</t>";
			//case 1005020000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>获取鹤嘴锄</t>";
			//case 1005030000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>获取玄铁锄</t>";
			//case 1005040000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>刷新矿脉(RMB)</t>";
			//case 1005050000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>刷新铜矿脉（1级）</t>";
			//case 1005060000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>刷新铁矿脉（2级）</t>";
			//case 1005070000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>刷新银矿脉（3级）</t>";
			//case 1005080000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>刷新金矿脉（4级）</t>";
			//case 1005090000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>刷新黑铁矿脉（5级）</t>";
			//case 1005100000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>刷新秘银矿脉（6级）</t>";
			//case 1005110000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>刷新魔金矿脉（7级）</t>";
			//case 1005120000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>刷新紫金矿脉（8级）</t>";
			//case 1005130000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>刷新耀金矿脉（9级）</t>";
			//case 1005140000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>刷新七彩玄冰矿脉（10级）</t>";
			//----------------------第六类功能-----帮派功能------------------------------------------
		case 1006000000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>帮派功能相关</t>";

		case 1006010000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派等级</t>";

		case 1006020000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派声望（帮派数据）</t>";
		case 1006020100:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派声望（1000）</t>";
		case 1006020200:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派声望（5000）</t>";
		case 1006020300:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派声望（10000）</t>";

		case 1006030000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派活跃（帮派数据）</t>";
		case 1006030100:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派活跃（100）</t>";
		case 1006030200:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派活跃（1000）</t>";
		case 1006030300:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派活跃（10000）</t>";

		case 1006040000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派资金（帮派数据）</t>";
		case 1006040100:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派资金（100）</t>";
		case 1006040200:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派资金（1000）</t>";
		case 1006040300:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派资金（10000）</t>";

		case 1006050000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派货币（玩家数据）</t>";
		case 1006050100:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派货币（100）</t>";
		case 1006050200:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派货币（1000）</t>";
		case 1006050300:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派货币（10000）</t>";

		case 1006060000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派贡献（玩家数据）</t>";
		case 1006060100:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派贡献（100）</t>";
		case 1006060200:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派贡献（1000）</t>";
		case 1006060300:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加帮派贡献（10000）</t>";
			//----------------------第二十类功能-----快速测试功能------------------------------------------
		case 1020000000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>快速测试功能</t>";

		case 1020010000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>『包裹道具』清除</t>";
		case 1020020000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>设置目标死亡</t>";
		case 1020030000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>召唤木桩</t>";
		case 1020040000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>添加AI技能</t>";
		case 1020050000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>十八木人阵</t>";
		case 1020060000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>连续使用第一格道具</t>";
		case 1020070000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>刷新ModNpc</t>";
		case 1020080000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>善恶值修改</t>";
		case 1020090000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>『包裹道具』展示</t>";

		case 1020040100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>强韧体魄LV1</t>";
		case 1020040200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>强韧体魄LV2</t>";
		case 1020040300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>强韧体魄LV3</t>";
		case 1020040400:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>坚韧</t>";
		case 1020040500:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>风影盾</t>";
		case 1020040600:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>魔法盾</t>";
		case 1020040700:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>无双</t>";
		case 1020040800:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>防御LV1</t>";
		case 1020040900:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>防御LV2</t>";
		case 1020041000:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>防御LV3</t>";
		case 1020041100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>灵力抗性LV1</t>";
		case 1020041200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>灵力抗性LV2</t>";
		case 1020041300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>灵力抗性LV3</t>";
		case 1020041400:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>战神之躯</t>";
		case 1020041500:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>五行仙体</t>";
		case 1020041600:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>荆棘光环LV1</t>";
		case 1020041700:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>荆棘光环LV2</t>";
		case 1020041800:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>荆棘光环LV3</t>";
		case 1020041900:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>天生神力LV1</t>";
		case 1020042000:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>天生神力LV2</t>";
		case 1020042100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>天生神力LV3</t>";
		case 1020042200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>嗜血狂暴LV1</t>";
		case 1020042300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>嗜血狂暴LV2</t>";
		case 1020042400:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>嗜血狂暴LV3</t>";
		case 1020042500:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>疾风幻影LV1</t>";
		case 1020042600:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>疾风幻影LV2</t>";
		case 1020042700:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>疾风幻影LV3</t>";
		case 1020042800:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>混乱之治</t>";
		case 1020042900:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>擒龙手</t>";
		case 1020043000:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>麻痹</t>";
		case 1020043100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>抗拒火环</t>";
		case 1020043200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>空间转换</t>";
		case 1020043300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>挫志怒吼</t>";
		case 1020043400:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>临死反击LV1</t>";
		case 1020043500:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>临死反击LV2</t>";
		case 1020043600:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>临死反击LV3</t>";
		case 1020043700:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>魔神领域LV1</t>";
		case 1020043800:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>魔神领域LV2</t>";
		case 1020043900:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>魔神领域LV3</t>";
		case 1020044000:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>淬毒术LV1</t>";
		case 1020044100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>淬毒术LV2</t>";
		case 1020044200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>淬毒术LV3</t>";
		case 1020044300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>连击LV1</t>";
		case 1020044400:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>连击LV2</t>";
		case 1020044500:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>连击LV3</t>";
		case 1020044600:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>诛仙弑神</t>";
		case 1020044700:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>群魔乱舞</t>";
		case 1020044800:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>阴阳逆转</t>";
		case 1020044900:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>金系法术宗师LV3</t>";
		case 1020045000:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>火系法术宗师LV3</t>";
		case 1020045100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>冰系法术宗师LV3</t>";
		case 1020045200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>木系法术宗师LV3</t>";
		case 1020045300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>土系法术宗师LV3</t>";

		case 1020080100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>善恶值清零</t>";
		case 1020080200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>增加1点善恶值</t>";
		case 1020080300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>增加10点善恶值</t>";
		case 1020080400:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>增加100点善恶值</t>";
	}
	for (%i = 1; %i <= 5; %i++)
	{
		if (%Text[%i] !$= "")
			return %Text[%i];
	}
	return "";
}
//■■■■■■■■■■■【月光宝盒文字内容】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【封装后台输出函数】■■■■■■■■■■■■■■■■■■
function PutOut(%string)
{
	if (GetBuildString() $= "Debug")
		echo(%string);
}
//■■■■■■■■■■■【封装后台输出函数】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【取余数】■■■■■■■■■■■■■■■■■■■■■■■
//%numa 为被除数 %numb为除数
function Take_remainder(%numa,%numb)
{
	%Result= mfloor(%numa / %numb);
	%Result = %numa - %Result * %numb;
	return %Result;
}
//■■■■■■■■■■■【取余数】■■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【获取野外切线是否允许】■■■■■■■■■■■■■■■■
function GetDispatchLevel(%Player,%MapID)
{
	//获取玩家等级
	%PlayerLeve = %Player.GetLevel();

	if ((%MapID == 1101) || ((%MapID >= 1200) && (%MapID <= 1209)))
	{
		if (%PlayerLeve <= 37)
			return 1;
	}
	else if ((%MapID == 1102) || ((%MapID >= 1210) && (%MapID <= 1219)))
	{
		if (%PlayerLeve <= 50)
			return 1;
	}
	else if ((%MapID == 1103) || ((%MapID >= 1220) && (%MapID <= 1229)))
	{
		if (%PlayerLeve <= 55)
			return 1;
	}

	return 0;
}

function GetDispatchGoToNextMap(%Player,%MapID)
{
	//获取玩家等级
	%PlayerLeve = %Player.GetLevel();

	if ((%MapID == 1101) && (%PlayerLeve <= 37)) return 1;
	else if ((%MapID == 1102) && (%PlayerLeve <= 50)) return 1;
	else if ((%MapID == 1103) && (%PlayerLeve <= 55)) return 1;

	return 0;
}
//■■■■■■■■■■■【获取野外切线是否允许】■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【获取聚宝盆是否开启】■■■■■■■■■■■■■■■■■
function JuBaoPeng_bActive(%Player)
{
	%PLeve = GetMetempsychosisLeve(%Player);

	//设置【 聚宝盆 】按钮
	if ($JuBaoPeng_bActive == 0)
	{
		CornucopiaWndMiniBtn.setvisible(0);
	}
	else
		CornucopiaWndMiniBtn.setvisible((%PLeve >= 60) ? 1 : 0);

	CornucopiaHaveFreeNumShow();
}
//■■■■■■■■■■■【获取聚宝盆是否开启】■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【获取当前玩家转生等级】■■■■■■■■■■■■■■■■
function GetMetempsychosisLeve(%Player)
{
	//玩家等级
	%Level = %Player.GetLevel();

	//当前转生等级
	%ZsLeve = %Player.GetMetempsychosis();
	if (%ZsLeve == 0)
		return %Level;

	return %ZsLeve * 80 + (%ZsLeve - 1) * 10 + %Level;
}

//■■■■■■■■■■■【获取当前玩家转生等级】■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【获取野外首领是否可刷新】■■■■■■■■■■■■■■■

//首领刷新时间
$HuoDongDaQuan_ShuaXin[1] = 3 * 60; 	$HuoDongDaQuan_OhasesID[1] = 1300; $HuoDongDaQuan_Map[1] = 810010200;
$HuoDongDaQuan_ShuaXin[2] = 3 * 60;  $HuoDongDaQuan_OhasesID[2] = 1400; $HuoDongDaQuan_Map[2] = 810020200;
$HuoDongDaQuan_ShuaXin[3] = 6 * 60;  $HuoDongDaQuan_OhasesID[3] = 1500; $HuoDongDaQuan_Map[3] = 811010100;
$HuoDongDaQuan_ShuaXin[4] = 6 * 60;  $HuoDongDaQuan_OhasesID[4] = 1600; $HuoDongDaQuan_Map[4] = 811020100;
$HuoDongDaQuan_ShuaXin[5] = 12* 60;  $HuoDongDaQuan_OhasesID[5] = 1700; $HuoDongDaQuan_Map[5] = 811030100;
$HuoDongDaQuan_ShuaXin[6] = 12* 60;  $HuoDongDaQuan_OhasesID[6] = 1800; $HuoDongDaQuan_Map[6] = 811040100;
$HuoDongDaQuan_ShuaXin[7] = 24* 60;  $HuoDongDaQuan_OhasesID[7] = 1900; $HuoDongDaQuan_Map[7] = 811050100;
$HuoDongDaQuan_ShuaXin[8] = 12* 60;  $HuoDongDaQuan_OhasesID[8] = 2000; $HuoDongDaQuan_Map[8] = 811280400;
$HuoDongDaQuan_ShuaXin[9] = 12* 60;  $HuoDongDaQuan_OhasesID[9] = 2100; $HuoDongDaQuan_Map[9] = 811290400;
$HuoDongDaQuan_ShuaXin[10] = 24* 60;  $HuoDongDaQuan_OhasesID[10] = 2200; $HuoDongDaQuan_Map[10] = 811320400;
$HuoDongDaQuan_ShuaXin[11] = 8 * 60;  $HuoDongDaQuan_OhasesID[11] = 2500; $HuoDongDaQuan_Map[11] = 811320200;


$HuoDongDaQuan_Xyz[1] = "59.5871 -221.08 100.245  ";
$HuoDongDaQuan_Xyz[2] = "79.2353 -233.083 99.9999 ";
$HuoDongDaQuan_Xyz[3] = "-72.4593 -37.9539 108.142";
$HuoDongDaQuan_Xyz[4] = "-51.2517 -116.931 106.807";
$HuoDongDaQuan_Xyz[5] = "-84.2028 117.508 103.589 ";
$HuoDongDaQuan_Xyz[6] = "-64.072 -38.9146 101.063 ";
$HuoDongDaQuan_Xyz[7] = "40.938 -84.2256 99.7257  ";
$HuoDongDaQuan_Xyz[8] = "-45.941 -140.796 100		 ";
$HuoDongDaQuan_Xyz[9] = "-171.936 127.21 100			 ";
$HuoDongDaQuan_Xyz[10] = "178.717 164.447 104			 ";
$HuoDongDaQuan_Xyz[11] = "2.55736 46.4992,108			 ";

function HuoDongDaQuan_BOSS_TiemA(%i)
{
	//获取当前时间
	%Time = GetLocalTime();
	%DQ_DD = GetWord(%Time,2);	//日
	%DQ_HH = GetWord(%Time,3);	//时
	%DQ_MM = GetWord(%Time,4);	//分

	%Time = GetWord(%Time,3) * 60 + GetWord(%Time,4);

	if ($HuoDongDaQuan_BOSS_KaiQ[%i] == 1)
		return -1;

	//获取记录时间
	%DD = GetWord($HuoDongDaQuan_BOSS_Tiem[%i],0,"/");	//日
	%HH = GetWord($HuoDongDaQuan_BOSS_Tiem[%i],1,"/");	//时
	%MM = GetWord($HuoDongDaQuan_BOSS_Tiem[%i],2,"/");	//分

	//获取下次刷新时间
	%BossTiem = (%HH * 60 + %MM) + $HuoDongDaQuan_ShuaXin[%i];

	//获取剩余分钟
	%BossTiemA = %BossTiem - (%DQ_HH * 60 + %DQ_MM);

	//判断刷新时间是否隔天 && 判断当前时间是否已经隔天
	if ((%BossTiem > (24 * 60)) && (%DQ_DD != %DD))
	{
		//获取隔天刷新时间
		%BossTiemA = %BossTiem - 24 * 60;

		//判断是否超过时间
		if ((%DQ_HH * 60 + %DQ_MM) > %BossTiemA)
			return -2;
	}

	//判断是否超过时间
	else if (%BossTiemA <= 0)
		return -3;

	return %BossTiemA;
}
//■■■■■■■■■■■【获取野外首领是否可刷新】■■■■■■■■■■■■■■■

//■■■■■■■■■■■【获取是否在活动时间内】■■■■■■■■■■■■■■■■
function GetStartTime(%Name)
{
	%Time = GetLocalTime();
	%YY = GetWord(%Time,0); //年
	%MM = GetWord(%Time,1); //月
	%DD = GetWord(%Time,2); //日
	%H = GetWord(%Time,3); //时
	%M = GetWord(%Time,4); //分

	//获取活动是否开启
	eval("%bActive = $" @ %Name @ "_bActive;");

	if (%bActive == 0)
		return 1;

	/* 开启时间 */	eval("%StartTime = $" @ %Name @ "_StartTime;");
	/* 结束时间 */	eval("%EndTime = $" @ %Name @ "_EndTime;");

	//是否在该年份
	%StartYY = GetWord(%StartTime,0,".");	//开启年份
	%EndTimeYY = GetWord(%EndTime,0,".");	//结束年份

	if (!((%StartYY >= %YY) && (%YY <= %EndTimeYY)))
		return 2;

	%NowDD = translateNumToString((%YY * 365 * 24 * 60) + ((%MM * 31 + %DD) * 24 + %H) * 60 + %M);

	%StartH = GetWord(GetWord(%StartTime,3,"."),0,":");
	%EndH = GetWord(GetWord(%EndTime,3,"."),0,":");

	%StartM = GetWord(GetWord(%StartTime,3,"."),1,":");
	%EndM = GetWord(GetWord(%EndTime,3,"."),1,":");

	//获取开启时间
	%StartDD = translateNumToString((%StartYY * 365 * 24 * 60) + ((GetWord(%StartTime,1,".") * 31 + GetWord(%StartTime,2,".")) * 24 + %StartH) * 60 + %StartM);		//开启日期
	%EndTimeDD = translateNumToString((%EndTimeYY * 365 * 24 * 60) + ((GetWord(%EndTime,1,".") * 31 + GetWord(%EndTime,2,".")) * 24 + %EndH) * 60 + %EndM);					//结束日期

	if ((%NowDD >= %StartDD) && (%NowDD <= %EndTimeDD))
		return 0;

	return 3;
}

function GetStartTime(%Name)
{
	%Time = GetLocalTime();
	%YY = GetWord(%Time,0); //年
	%MM = GetWord(%Time,1); //月
	%DD = GetWord(%Time,2); //日
	%H = GetWord(%Time,3); //时
	%M = GetWord(%Time,4); //分

	//获取活动是否开启
	eval("%bActive = $" @ %Name @ "_bActive;");

	if (%bActive == 0)
		return 1;

	/* 开启时间 */	eval("%StartTime = $" @ %Name @ "_StartTime;");
	/* 结束时间 */	eval("%EndTime = $" @ %Name @ "_EndTime;");

	//是否在该年份
	%StartYY = GetWord(%StartTime,0,".");	//开启年份
	%EndTimeYY = GetWord(%EndTime,0,".");	//结束年份

	if (!((%StartYY >= %YY) && (%YY <= %EndTimeYY)))
		return 2;

	%NowDD = ((%MM * 31 + %DD) * 24 + %H) * 60 + %M;

	%StartH = GetWord(GetWord(%StartTime,3,"."),0,":");
	%EndH = GetWord(GetWord(%EndTime,3,"."),0,":");

	%StartM = GetWord(GetWord(%StartTime,3,"."),1,":");
	%EndM = GetWord(GetWord(%EndTime,3,"."),1,":");

	//获取开启时间
	%StartDD = ((GetWord(%StartTime,1,".") * 31 + GetWord(%StartTime,2,".")) * 24 + %StartH) * 60 + %StartM;		//开启日期
	%EndTimeDD = ((GetWord(%EndTime,1,".") * 31 + GetWord(%EndTime,2,".")) * 24 + %EndH) * 60 + %EndM;					//结束日期

	if ((%NowDD >= %StartDD) && (%NowDD <= %EndTimeDD))
		return 0;

	return 3;
}
//■■■■■■■■■■■【获取是否在活动时间内】■■■■■■■■■■■■■■■■

//■■■■■■■■■■■复活消耗计算■■■■■■■■■■■■■■■■■■■■
function FuHuoNeedMoney_Expend(%Player,%optype) //0 元宝 1 金币
{
	//获取玩家等级
	%Level = %Player.GetLevel();
	%ZsLevel = %Player.GetMetempsychosis();
	%Activity = 2209;
	%ActivityA = GetWord(%Player.GetActivity(%Activity),0) * 1;
	%ActivityB = GetWord(%Player.GetActivity(%Activity),1) * 1;
	switch (%optype)
	{
		case 0:
			//echo( "%ActivityB==" @ %ActivityB );
			%Money = 100 * mceil(%ActivityB /30);
			//echo( "%MoneyB==" @ %Money );
			%Money = (%Money < 100) ? 100 : %Money;
			//echo( "%MoneyC==" @ %Money );
			%Money = (%Money > 300) ? 300 : %Money;
			//echo( "%MoneyD==" @ %Money );
		case 1:
			%MianFeiCiShu =GetMianFeiFuHuoNumber(%Player);
			//echo( "%MianFeiCiShu==" @ %MianFeiCiShu );
			//echo( "%ActivityA==" @ %ActivityA );
			if (%ActivityA < %MianFeiCiShu)
				%Money = 0;
			else
			{
				if ($PlayerEnabledMoney[%ActivityA - %MianFeiCiShu] !$= "")
					%Money = $PlayerEnabledMoney[%ActivityA - %MianFeiCiShu];
				else
					%Money = 1000000;
			}
			//echo( "%Money==" @ %Money );
	}
	return %Money;
}
function GetMianFeiFuHuoNumber(%Player)//获取玩家免费复活次数
{
	return 3;
}
//■■■■■■■■■■■复活消耗计算■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【神将秦琼设置华山论剑次数上线】■■■■■■■■■■■■
function SetChallengeVipInc(%Player)
{
}
//■■■■■■■■■■■【神将秦琼设置华山论剑次数上线】■■■■■■■■■■■■

//■■■■■■■■■■■【判断是否可挂机】■■■■■■■■■■■■■■■■■■■
function canEnabledCombatAssistant(%Player)
{
	if (GetWord(%Player.GetActivity(2145),0) > 0)
		return 0;

	//可以挂机
	return 1;
}
//■■■■■■■■■■■【判断是否可挂机】■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【获取各种Data名称】■■■■■■■■■■■■■■■■■■
function GetanyDataName(%DataID)
{
	if (GetSubStr(%DataID,0,1) == 1)%DataName = GetItemData(%DataID,1);						//道具
	else if (GetSubStr(%DataID,0,1) == 4)%DataName = GetNpcData(%DataID,1);						//NPC
	else if (GetSubStr(%DataID,0,1) == 5)%DataName = GetCollectionObjectname(%DataID);	//采集
	else if (GetSubStr(%DataID,0,1) == 8)%DataName = GetTriggerData(%DataID,3);				//区域
	return %DataName;
}

//■■■■■■■■■■■界面飞行功能■■■■■■■■■■■■■■■■■■■■■■

//判断能否存储位置
function Transmission_canSavePos(%Player,%MapID)
{
	//if ( GetSubStr( %MapID, 1, 1 ) $= "3" )
	//	%Txt = "当前地图无法使用该传送。";

	//else if ( %Player.GetTriggerId( ) $= "811190108" || %Player.GetTriggerId( ) $= "811190109" )
	//	%Txt = "囚仙牢无法使用该传送。";

	//else if ( ( %MapID == 1128 ) || ( %MapID == 1129 ) || ( %MapID == 1130 ) || ( %MapID == 1132 ) )
	//	%Txt = "当前地图无法使用该传送。";

	%MapID = GetZoneID();
	switch (%MapID)
	{
		case 1001:return 1;
		case 1010:return 1;
		case 1101:return 1;
		case 1102:return 1;
		case 1103:return 1;
		case 1104:return 1;
		case 1105:return 1;
		case 1106:return 1;
		case 1107:return 1;
		default:
			%Txt = "当前地图无法使用该功能。";
			SetScreenMessage(%Txt,$Color[5]);
			return 0;
	}
}

//飞行条件(Player, 当前地图ID, 目标地图ID)
function Transmission_canFlyPos(%Player,%MapID,%TomapID)
{
	if (%Player.GetInteractionState() > 0)
		%Txt = "交互状态无法使用该功能。";

	else if ((%Player.GetMetempsychosis() == 0) && (%Player.GetLevel() < 15))
		%Txt = "15级以下无法使用该功能。";

	else if (%Player.GetFamilarityTarget() != 0)
		%Txt = "背负/拥抱状态下无法该功能。";

	else if (%Player.IsDisabled())
		%Txt = "死亡状态无法使用该功能。";

	else if (%Player.IsInCombat())
		%Txt = "战斗中无法使用该功能。";

	else if (%Player.isInMultiMount())
		%Txt = "多人骑乘下无法使用该功能。";


	if (%Txt !$= "")
	{
		if ($Now_Script == 1)
			SetScreenMessage(%Txt,$Color[2]);
		else
			SendOneScreenMessage(2,%Txt,%Player);

		return 0;
	}

	return 1;
}

//返回传送消耗积分
function getFlyTransmissionPosMoney()
{
	return 0;
}
//返回传送消耗道具
function getFlyTransmissionPosItem(%Player)
{
	//echo("返回传送消耗道具%Player===" @ %Player);
	//105109524   星界石	105109525   星界石(赠品)
	if (%Player.GetItemCount(105109525) >= 1)
		return 105109525;
	else
		return 105109524;
}
//返回免费传送次数
function getFreeFlyTransmissionPosCount()
{
	return 0;
}

//返回可记录总数  该值不能大于20
function getFlyTransmissionPosCount(%Player)
{
	return VIP_getNowTequanLvMaxCnt(%Player, 1);
}

//星界传送：单张地图可记录坐标总数
function getFlyTransmissionOneMapPosMax(%Player)
{
	return VIP_getNowTequanLvMaxCnt(%Player, 2);
}

//■■■■■■■■■■■获取从2000年后的某天■■■■■■■■■■■■■■■■■
//正向转换：20010101 =》367天
function Get2K_To_Day(%X_Day)
{
	//echo( "%X_Day====" @ %X_Day );
	%YY = GetSubStr(%X_Day,0,4) * 1;
	%MM = GetSubStr(%X_Day,4,2) * 1;
	%DD = GetSubStr(%X_Day,6,2) * 1;

	//获取传进来的年份是否为闰年
	if (%YY == mfloor(%YY / 4) * 4)
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

	//开始计算//年
	for (%YY_Next = 2000; %YY_Next < %YY; %YY_Next++)
	{
		if (%YY_Next == mfloor(%YY_Next / 4) * 4)
			%All_Y_Day = %All_Y_Day + 366;
		else
			%All_Y_Day = %All_Y_Day + 365;
	}
	//开始计算//月
	for (%MM_Next = 1; %MM_Next < %MM; %MM_Next++)
		%All_Y_Day = %All_Y_Day + %Mon[%MM_Next];

	//开始计算//天
	%All_Y_Day = %All_Y_Day + %DD;
	//echo( "%All_Y_Day====" @ %All_Y_Day );
	return %All_Y_Day;
}
//反向转换：367天 =》20010101
function GetDay_To_2K(%X_Day)
{
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

	//开始计算//年
	for (%YY_Next = 2000; %YY_Next < 3000; %YY_Next++)
	{
		if (%YY_Next == mfloor(%YY_Next / 4) * 4)
		{
			%Mon[02] = 29;
			%YY_Day = 366;
		}
		else
		{
			%Mon[02] = 28;
			%YY_Day = 365;
		}

		if (%X_Day > %YY_Day)
			%X_Day = %X_Day - %YY_Day;
		else
			break;
	}
	//开始计算//月
	for (%MM_Next = 1; %MM_Next < 13; %MM_Next++)
	{
		if (%X_Day > %Mon[%MM_Next])
			%X_Day = %X_Day - %Mon[%MM_Next];
		else
			break;
	}

	return %YY_Next * 10000 + %MM_Next * 100 + %X_Day;
}

function CaculateWeekDay(%Year,%Month,%Day)//根据日期 转换为星期几
{
	if (%Month == 1 || %Month == 2)
	{
		%Month += 12;
		%Year--;
	}
	%iWeek = (%Day + 2 * %Month + 3 * (%Month + 1) / 5 + %Year + %Year / 4 - %Year / 100 + %Year / 400) % 7;
	switch (%iWeek)
	{
		case 0: %iWeek = 1; //echo( "星期一" );
		case 1: %iWeek = 2; //echo( "星期二" );
		case 2: %iWeek = 3; //echo( "星期三" );
		case 3: %iWeek = 4; //echo( "星期四" );
		case 4: %iWeek = 5; //echo( "星期五" );
		case 5: %iWeek = 6; //echo( "星期六" );
		case 6: %iWeek = 0; //echo( "星期日" );
	}
	return %iWeek;
}
//■■■■■■■■■■■获取从2000年后的某天■■■■■■■■■■■■■■■■■■■



//■■■■■■■■■■■【获取vip等级】■■■■■■■■■■■■■■■■■■■■
function GetYuanBaovip(%Player)
{
	%YunaBao = %Player.getTotalDrawGold();
	if (%YunaBao >= 100 * 100000)return 10;
	else if (%YunaBao >= 100 * 50000)return 9;
	else if (%YunaBao >= 100 * 30000)return 8;
	else if (%YunaBao >= 100 * 20000)return 7;
	else if (%YunaBao >= 100 * 10000)return 6;
	else if (%YunaBao >= 100 * 5000)return 5;
	else if (%YunaBao >= 100 * 2000)return 4;
	else if (%YunaBao >= 100 * 500)return 3;
	else if (%YunaBao >= 100 * 100)return 2;
	else if (%YunaBao >= 100 * 10)return 1;
	else return 0;
}
//■■■■■■■■■■■【获取vip等级】■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【洗炼丹消耗】■■■■■■■■■■■■■■■■■■■■■
function sptGetPetHuanTongItemCount(%PetLevel,%PetDataID,%YuBao)
{
	//特殊宠物，返回特殊数量100点
	%PetDataID[1] = GetSubStr(%PetDataID,7,2);
	if ((%PetDataID[1] >= 51) && (%PetDataID[1] <= 68))
		return 100;

	if ((%PetLevel >= 1) && (%PetLevel <= 39))return 10;
	else if ((%PetLevel >= 40) && (%PetLevel <= 49))return 20;
	else if ((%PetLevel >= 50) && (%PetLevel <= 59))return 30;
	else if ((%PetLevel >= 60) && (%PetLevel <= 69))return 50;
	else if ((%PetLevel >= 70) && (%PetLevel <= 79))return 100;
	else if ((%PetLevel >= 80) && (%PetLevel <= 89))return 100;
	else if ((%PetLevel >= 90) && (%PetLevel <= 99))return 300;
}
//■■■■■■■■■■■【洗炼丹消耗】■■■■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【判断武魂界面开启条件】■■■■■■■■■■■■■■■■
function UpdateMetempsychosis(%Player)
{
	%Player = GetPlayer();

	//玩家等级
	if (GetMetempsychosisLeve(%Player) >= 65)
	{
		//开启武魂按钮
		//ShowWuHunBtn(1);
		//开启人物界面武魂按钮
		DTPlayerInfowGui_WuHunCtrl.setVisible(1);
	}
	else
	{
		//关闭武魂按钮
		//ShowWuHunBtn(0);
		//关闭人物界面武魂按钮
		DTPlayerInfowGui_WuHunCtrl.setVisible(0);
	}

	//更新【武魂】闪烁提示
	ShowFreeSouHunNUMOutLine();

	ShowAvatarCoverPicture(%ZSNum);
}
//■■■■■■■■■■■【判断武魂界面开启条件】■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【提升化身境界时触发】■■■■■■■■■■■■■■■■■
function avatarJingJieUp(%Player,%slot,%JingJie,%ADDJingJie)
{
	//根据化生境界设置消耗编号
	switch (%JingJie)
	{
		case 0:%ItemID = 105103038;
		case 1:%ItemID = 105103039;
		case 2:%ItemID = 105103040;
		case 3:%ItemID = 105103041;
		case 4:%ItemID = 105103042;
	}

	//根据化生阶级设置消耗数量
	if (%slot < 5){ %ItemNum = 1; }
	else if (%slot < 10){ %ItemNum = 3; }
	else if (%slot < 15){ %ItemNum = 6; }
	else if (%slot < 20){ %ItemNum = 10; }
	else if (%slot < 25){ %ItemNum = 30; }
	else if (%slot < 30){ %ItemNum = 60; }
	else %ItemNum = 60;

	if ($Now_Script == 1)
		return %ItemID @ " " @ %ItemNum;
	else
	{
		%Player.PutItem(%ItemID,-%ItemNum);
		return (%Player.AddItem(13,18)) ? 1 : 0;
	}
}
//■■■■■■■■■■■【提升化身境界时触发】■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【指定对象发送特效】■■■■■■■■■■■■■■■■■■
function AddEffect(%Type,%Obj,%EffectID)
{
	switch (%Type)
	{
		case 1:
			//玩家
			%Obj.AddPacket(%EffectID);	//发送接受任务特效

		case 2:
			//怪物或NPC
			%Obj.AddPacket(%EffectID);	//发送接受任务特效
	}
}
//■■■■■■■■■■■【指定对象发送特效】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【获取任务的类型】■■■■■■■■■■■■■■■■■■■
function GetMissionKind(%Mid)
{
	return GetMissionData(%Mid,$Mission_Data_Type);
}
//■■■■■■■■■■■【获取任务的类型】■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【获取不重复的随机数】■■■■■■■■■■■■■■■■■
function GetRandomNum(%Num,%Begin,%End)
{
	//可随机范围内总数
	%ArrayCount = %End-%Begin+1;
	if (%ArrayCount<=0)
		return;

	//初始化队列
	%Index = 0;
	for (%i = %Begin; %i <= %End; %i++)
	{
		%Array[%Index] = %i;
		%Index++;
	}

	//做循环
	for (%i = 0; %i < %ArrayCount; %i++)
	{
		if (%i >= %Num)//数量够了
			break;

		%Roll = GetRandom(%i,%ArrayCount-1);//从未排序位中随机

		if (%i == 0)
			%Temp = %Array[%Roll];
		else
			%Temp = %Temp @ " " @ %Array[%Roll];

		%Array[%Roll] = %Array[%i];//换位	保证待随机的队列中都是未随机到的数
	}

	return %Temp;
}

function GetRandomNum2(%Num,%Begin,%End,%NoIn)//获取不重复的随机数,并且排除掉%Noin里面的数
{
	%ArrayCount = %End-%Begin+1;
	if (%ArrayCount <= 0)
		return;

	%PaiChuCount = GetWordCount(%NoIn);
	//初始化队列
	%Index = 0;
	for (%i = %Begin; %i <= %End; %i++)
	{
		%Record = 0;
		for (%j = 0; %j < %PaiChuCount; %j++)
		{
			%PaiChuShuZi = GetWord(%NoIn,%j);
			if (%PaiChuShuZi == %i)
			{
				%Record = 1;
				break;
			}
		}
		if (%Record  == 0)
		{
			%Array[%Index] = %i;
			%Index++;
		}
	}
	if (%Array[0] $= "")
		return;
	if (%Index < %Num)
		%Num = %Index;
	//做循环
	for (%i = 0; %i < %Index; %i++)
	{
		if (%i >= %Num)//数量够了
			break;

		%Roll = GetRandom(%i,%Index-1);//从未排序位中随机

		if (%i == 0)
			%Temp = %Array[%Roll];
		else
			%Temp = %Temp @ " " @ %Array[%Roll];

		%Array[%Roll] = %Array[%i];//换位	保证待随机的队列中都是未随机到的数
	}
	//echo( "%Temp===" @ %Temp );
	return %Temp;
}
//GetRandomNum2( 10, 1, 20, "1 5 3 8 9 4 6 10 12 20 13 15" );
//■■■■■■■■■■■【获取不重复的随机数】■■■■■■■■■■■■■■■■■



//■■■■■■■■■■■【采集掉物前置判断脚本】■■■■■■■■■■■■■■■■
function EventTriggerCondition(%Player,%nEventTriggerId,%Event)
{
	//echo("采集物的事件ID ==" @  %nEventTriggerId);
	//%nEventTriggerId = 采集物的事件ID

	%PlayerID = %Player.GetPlayerID();
	%CopyMapID = %Player.GetLayerId();
	%Ys = %Player.GetActivity(2083);
	%YHs = GetWord(%Ys,0);//获取次数
	%YFs = GetWord(%Ys,1);//获取次数

	%Bs = %Player.GetActivity(2084);
	%BHs = GetWord(%Bs,0);//获取次数

	if ($Now_Script == 1)
		%BaoG = GetBagEmptyNum();//获得包裹栏
	else
		%BaoG = %Player.GetBagEmptyCount();//获得包裹栏

	switch$(%nEventTriggerId)
	{
		case "553000017":
			if ($Now_Script == 1)
			{
				if (%BaoG < 1)
					return 5035;
				if (%Player.Getlevel() < 30)
					return 4758;
			}
			return 0;
		case "551030101":
			if ($Now_Script == 1)
			{
				if (%BaoG < 1)
					return 5035;
				if (%Player.Getlevel() < 30)
					return 20161;
			}
			return 0;
		case "552000003":
			if (%Player.GetSchbuff(2013) > 0)
				return 30803;
			if (%Player.GetSchbuff(2012) <= 0)
				return 30804;
			if ($Now_Script == 2)
			{
				if (%Player.Getlevel() < $SL_LingJingWuDao_Level)
					return 20161;
			}
		case "552000002":
			%AAA = %Player.IsAcceptedMission(10221);
			if (%AAA != 1)
			{
				if ($Now_Script == 2)
				{
					if (%Player.Getlevel() < $SL_LingJingWuDao_Level)
						return 20161;
				}
				if (%Player.GetSchbuff(2013) > 0)
					return 30803;
				if (%Player.GetSchbuff(2014) >= 43200)
					return 30805;
			}
		case "551010101":
			if (%BaoG > 0)
				return 0;
			else
				return 5035;
		case "551011001":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011001;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011002":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011002;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				//echo("%Mark ====" @ %Mark);
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011003":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011003;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011004":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011004;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011005":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011005;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011006":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011006;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011007":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011007;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011008":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011008;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011009":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011009;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011010":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011010;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011501":
			%ItemID = %Player.GetEquip(13);
			if (%ItemID != 107020101)
				return 4834;
			if (%BaoG < 1)
				return 5035;
			return 0;
		case "551011502":
			%ItemID = %Player.GetEquip(13);
			if (%ItemID != 107020101)
				return 4834;
			if (%BaoG < 1)
				return 5035;
			return 0;
		case "551011511":
			%ItemID = %Player.GetEquip(13);
			if (%ItemID != 107020201)
				return 4835;
			if (%BaoG < 1)
				return 5035;
			return 0;
		case "551011512":
			%ItemID = %Player.GetEquip(13);
			if (%ItemID != 107020201)
				return 4835;
			if (%BaoG < 1)
				return 5035;
			return 0;
		case 552000006:
			//echo( "啊啊啊===" @  %Player.GetBuffCount( 39903, 1 ) );
			if (%Player.GetBuffCount(39903,1) >= 1)
				return 35601;
			for (%i = 3; %i >= 1; %i--)
			{
				//echo( "ooo===" @  %Player.GetBuffCount( 39906, %i ) );
				if (%Player.GetBuffCount(39906,%i) >= 1)
					return 35601;
			}
			return 0;
		case "552000004":if (%player.IsAcceptedMission(20001) || %player.IsAcceptedMission(20001 + 8) ||%player.IsAcceptedMission(20001 + 16)) return 0; else return 5038;
		case "552000005":if (%player.IsAcceptedMission(20002) || %player.IsAcceptedMission(20002 + 8) ||%player.IsAcceptedMission(20002 + 16)) return 0; else return 5038;
		case "552000006":if (%player.IsAcceptedMission(20005) || %player.IsAcceptedMission(20005 + 8) ||%player.IsAcceptedMission(20005 + 16)) return 0; else return 5038;
		case "552000007":
			if (%player.IsAcceptedMission(20006) || %player.IsAcceptedMission(20006 + 8) ||%player.IsAcceptedMission(20006 + 16)) return 0; else return 5038;
			if (%Player.GetBuffCount(39903,1) >= 1)
				return 35601;
			if (%Player.GetBuffCount(39906,3) >= 1)
				return 35602;
			if (%Player.GetBuffCount(39906,2) >= 1)
				return 35602;
			if (%Player.GetBuffCount(39906,1) >= 1)
				return 35602;
			return 0;
		case "552000008":
			if (%player.IsAcceptedMission(20006) || %player.IsAcceptedMission(20006 + 8) ||%player.IsAcceptedMission(20006 + 16)) return 0; else return 5038;
			if (%Player.GetBuffCount(39903,1) >= 1)
				return 35601;
			if (%Player.GetBuffCount(39906,3) >= 1)
				return 35602;
			if (%Player.GetBuffCount(39906,2) >= 1)
				return 35602;
			return 0;
		case "552000009":
			if (%player.IsAcceptedMission(20006) || %player.IsAcceptedMission(20006 + 8) ||%player.IsAcceptedMission(20006 + 16)) return 0; else return 5038;
			if (%Player.GetBuffCount(39903,1) >= 1)
				return 35601;
			if (%Player.GetBuffCount(39906,3) >= 1)
				return 35602;
			return 0;
		case "552000015":
			if ($PlayerMissionRecord[%CopyMapID,%PlayerID] >= 5)
				return 35603;
			return 0;
		case "552000016":
			if ($PlayerMissionRecord[%CopyMapID,%PlayerID] >= 5)
				return 35603;
			return 0;
		case "553000002":
			if (%BaoG < 1)
				return 5035;
		case "553000003":
			if (%BaoG < 10)
				return 5035;
		case "553000004":
			if (%BaoG < 10)
				return 5035;
		case "553000005":
			if (%BaoG < 10)
				return 5035;
		case "553000006":
			if (%BaoG < 10)
				return 5035;
		case "553000007":
			if (%BaoG < 10)
				return 5035;
		case "553000008":
			if (%BaoG < 10)
				return 5035;
		case "553000009":
			if (%BaoG < 10)
				return 5035;
		case "553000010":
			if (%BaoG < 10)
				return 5035;
		case "553000011":
			if (%BaoG < 10)
				return 5035;
		case "553000012":
			if (%BaoG < 10)
				return 5035;
		case "553000057":if (GetSrc(%Player,191) == 1)return 30507; else return 0;
		case "553000058":if (GetSrc(%Player,192) == 1)return 30507; else return 0;
		case "553000059":if (GetSrc(%Player,193) == 1)return 30507; else return 0;
		case "553000060":if (GetSrc(%Player,194) == 1)return 30507; else return 0;
		case "553000062":if (%Player.IsSchbuff(2043))return 30508;else return 0;
	}
	return 0;
}
//■■■■■■■■■■■【采集掉物前置判断脚本】■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【获取道具信息】■■■■■■■■■■■■■■■■
new ItemObject(ItemObj)
{
};
//■■■■■■■■■■■【获取道具信息】■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【获得任务名称脚本（程序用）】■■■■■■■■■■■■■
function GetMissionName(%Mid)
{
	return GetMissionData(%Mid,$Mission_Data_Name);
}
//■■■■■■■■■■■【获得任务名称脚本（程序用）】■■■■■■■■■■■■■

//■■■■■■■■■■■【仓库扩展相关判断脚本】■■■■■■■■■■■■■■■■
//仓库扩展按钮是否可点击
function Cs_Bank_CanBuySpace(%Player,%Num)
{
	if ((%Player.GetLevel() < 10) || (%Num == 120))
		return 0;//不可点击
	else
		return 1;//可点击
}
//扩展相应格子需要消耗的元宝
function Cs_Bank_NeedMoney(%Num)
{
	switch (%Num)
	{
		case 32:return 500;
		case 40:return 500;
		case 48:return 500;
		case 56:return 500;
		case 64:return 1000;
		case 72:return 1000;
		case 80:return 1500;
		case 88:return 1500;
		case 96:return 2000;
	}

	return 0;
}
//扩展相应格子需要消耗的道具
function Cs_Bank_NeedItemType(%Num)
{

	return 0;
}
//■■■■■■■■■■■【仓库扩展相关判断脚本】■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【判断对象是否为玩家】■■■■■■■■■■■■■■■■■
//返回1000为男玩家 1500为女玩家 0为不是玩家
function IsPlayer(%Obj)
{
	if (!isobject(%Obj))
		return 0;

	%DataID = %Obj.GetDataID();

	//if ( %DataID == 1000 || %DataID == 1500 )
	//	return %DataID;
	//else
	//	return 0;
	if (%DataID < 30000)
		return %DataID;
	else
		return 0;
}
//■■■■■■■■■■■【判断对象是否为玩家】■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【获取帮派跑商任务的奖励】■■■■■■■■■■■■■■■

function Mission_Special_23015_Award(%Player)
{
	//玩家等级
	%Level = %Player.GetLevel();
	%Cz = 1212;

	//已完成次数
	%AAA = GetWord(%Player.GetActivity(%Cz),0) * 1 + 1;
	//最大跑商次数
	%BBB = GetWord(%Player.GetActivity(%Cz),1) * 1;
	%CCC = GetSubStr(%BBB,1,2) * 1;

	//基础值
	if (%Level <=  49){ %JXZ = 1100; }
	else if (%Level <=  59){ %JXZ = 2200; }
	else if (%Level <=  69){ %JXZ = 3450; }
	else if (%Level <=  79){ %JXZ = 4500; }
	else if (%Level <=  89){ %JXZ = 5800; }
	else if (%Level <=  99){ %JXZ = 6900; }
	else if (%Level <= 109){ %JXZ = 7700; }
	else if (%Level <= 119){ %JXZ = 8400; }
	else if (%Level <= 129){ %JXZ = 9600; }

	//奖励
	return %JXZ + %AAA * 100 + %CCC / 5 * 2500;
}
//■■■■■■■■■■■【获取帮派跑商任务的奖励】■■■■■■■■■■■■■■■


//■■■■■■■■■■■【获取两个时间之间的间隔天数】■■■■■■■■■■■■■
function Get_Day_Day(%DayA,%DayB)
{
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

	%Day_A_Y = GetSubStr(%DayA,0,4) * 1;
	%Day_A_M = GetSubStr(%DayA,4,2) * 1;
	%Day_A_D = GetSubStr(%DayA,6,2) * 1;

	%Day_B_Y = GetSubStr(%DayB,0,4) * 1;
	%Day_B_M = GetSubStr(%DayB,4,2) * 1;
	%Day_B_D = GetSubStr(%DayB,6,2) * 1;

	%Back_A_D = %Day_A_D;
	for (%a = 2011; %a <= %Day_A_Y; %a++)
	{
		//获取是否为闰年
		if ((%Day_A_Y == 2012)||(%Day_A_Y == 2016)||(%Day_A_Y == 2020)||(%Day_A_Y == 2024)||(%Day_A_Y == 2028)||(%Day_A_Y == 2032))
			%Mon[02] = 29;
		else
			%Mon[02] = 28;

		for (%i = 1; %i < %Day_A_M; %i++)
		{
			%Back_A_D = %Back_A_D + %Mon[%i];
		}
	}

	%Back_B_D = %Day_B_D;
	for (%a = 2011; %a <= %Day_B_Y; %a++)
	{
		//获取是否为闰年
		if ((%Day_B_Y == 2012)||(%Day_B_Y == 2016)||(%Day_B_Y == 2020)||(%Day_B_Y == 2024)||(%Day_B_Y == 2028)||(%Day_B_Y == 2032))
			%Mon[02] = 29;
		else
			%Mon[02] = 28;

		for (%i = 1; %i < %Day_B_M; %i++)
		{
			%Back_B_D = %Back_B_D + %Mon[%i];
		}
	}
	return %Back_B_D - %Back_A_D;
}
//■■■■■■■■■■■【获取两个时间之间的间隔天数】■■■■■■■■■■■■■

//■■■■■■■■■■■【获取下几天的日期】■■■■■■■■■■■■■■■■■■
function GetNextDay(%X_Day,%NextDay)
{
	%YY = GetSubStr(%X_Day,0,4) * 1;
	%MM = GetSubStr(%X_Day,4,2) * 1;
	%DD = GetSubStr(%X_Day,6,2) * 1;

	//获取传进来的年份是否为闰年
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

	//如果这一天超过的本月最大天数，则月数进位
	if ((%DD + %NextDay) > %Mon[%MM])
	{
		%DD_Next = %DD + %NextDay - %Mon[%MM];

		//如果月数进位超过12数，则年数进位
		if ((%MM + 1) > 12)
		{
			%YY_Next = %YY + 1;
			%MM_Next = %MM;
		}
		else
		{
			%YY_Next = %YY;
			%MM_Next = %MM + 1;
		}
	}
	else
	{
		%YY_Next = %YY;
		%MM_Next = %MM;
		%DD_Next = %DD + %NextDay;
	}

	//将不足两位的补成两位
	if (strlen(%MM_Next) == 1)%MM_Next = "0" @ %MM_Next;
	if (strlen(%DD_Next) == 1)%DD_Next = "0" @ %DD_Next;

	return %YY_Next @ " " @ %MM_Next @ " " @ %DD_Next;
}

//■■■■■■■■■■■【获取下几天的日期】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【神兽元抗进阶相关脚本】■■■■■■■■■■■■■■■■
//获取当前进阶等级需要消耗的道具
function GetPetStrengthenItem(%lv)
{
	switch (%lv)
	{
		case 0: return "116010101";//神兽元抗进阶石;
		case 1: return "116010102";//神兽元抗进阶石;
		case 2: return "116010103";//神兽元抗进阶石;
		case 3: return "116010104";//神兽元抗进阶石;
		case 4: return "116010105";//神兽元抗进阶石;
		default:return "116010106";//神兽元抗进阶石;
	}
}
//获取当前进阶等级需要消耗的钱
function GetPetStrengthenMoney(%lv)
{
	return 30000 * (%lv + 1) - 10000;
}
//获取当前进阶等级最终的成功几率
function PetStrengthen(%lv)
{
	switch (%lv)
	{
		case 0:
			%X = GetRandom(1,10000);
			if (%X <= 2800)return 1;
			else if (%X <= 7600)return 2;
			else return 3;

		case 1:
			%X = GetRandom(1,10000);
			if (%X <= 3000)return 1;
			else if (%X <= 8200)return 2;
			else return 3;

		case 2:
			%X = GetRandom(1,10000);
			if (%X <= 1000)return 1;
			else if (%X <= 4000)return 2;
			else if (%X <= 8800)return 3;
			else return 4;

		case 3:
			%X = GetRandom(1,10000);
			if (%X <= 1000)return 1;
			else if (%X <= 3000)return 2;
			else if (%X <= 6000)return 3;
			else if (%X <= 9000)return 4;
			else return 5;

		case 4:
			%X = GetRandom(1,10000);
			if (%X <= 1000)return 1;
			else if (%X <= 2000)return 2;
			else if (%X <= 3000)return 3;
			else if (%X <= 6000)return 4;
			else if (%X <= 9050)return 5;
			else return 6;

		default:
			%X = GetRandom(1,10000);
			if (%X <= 1000)return 1;
			else if (%X <= 2000)return 2;
			else if (%X <= 3000)return 3;
			else if (%X <= 4000)return 4;
			else if (%X <= 6100)return 5;
			else if (%X <= 9150)return 6;
			else return 7;
	}
}
//获取单个进阶比例
function GetPetStrengthenRang(%lv)
{
	switch (%lv)
	{
		case 0: return "0";
		case 1: return "1-3";
		case 2: return "1-4";
		case 3: return "1-5";
		case 4: return "1-6";
		case 5: return "1-7";
		default:return "0";
	}
}
//获取总和进阶比例
function GetPetStrengthenAmountRang(%lv)
{
	switch (%lv)
	{
		case 0: return "1-3";
		case 1: return "2-6";
		case 2: return "3-10";
		case 3: return "4-15";
		case 4: return "5-21";
		case 5: return "6-28";
		default:return "0";
	}
}
//判断此等级是否为完美进阶
function isPerfectStrengthen(%lv,%Num)
{
	switch (%lv)
	{
		case 0: %P = 3;
		case 1: %P = 5;
		case 2: %P = 7;
		case 3: %P = 9;
		case 4: %P = 11;
		case 5: %P = 13;
		default:%P = 0;
	}

	if (%Num >= %P)
		return 1;
	else
		return 0;
}
//■■■■■■■■■■■【神兽元抗进阶相关脚本】■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【神兽称号功能】■■■■■■■■■■■■■■■■■■■■
function GetPetDesignationName(%NameID)
{
	//神兽显示称号=潜力称号+“的”+元抗称号+资质称号
	if (%NameID < 111)
		return "";
	//潜力称号
	%Name_A = GetSubStr(%NameID,0,1);
	switch (%Name_A)
	{
		case 1:%Name_A_Txt = "";
		case 2:%Name_A_Txt = "完美的";
		case 3:%Name_A_Txt = "传说的";
		case 4:%Name_A_Txt = "逆天的";
		default:%Name_A_Txt = "";
	}
	//元抗称号
	%Name_B = GetSubStr(%NameID,1,1);
	switch (%Name_B)
	{
		case 1:%Name_B_Txt = "";
		case 2:%Name_B_Txt = "地护";
		case 3:%Name_B_Txt = "神佑";
		case 4:%Name_B_Txt = "齐天";
		default:%Name_B_Txt = "";
	}
	//资质称号
	%Name_C = GetSubStr(%NameID,2,1);
	switch (%Name_C)
	{
		case 1:
			if ((%Name_B > 1)||(%Name_A > 1))
				%Name_C_Txt = "神兽";
			else
				%Name_C_Txt = "";
		case 2:%Name_C_Txt = "奇兽";
		case 3:%Name_C_Txt = "玄兽";
		case 4:%Name_C_Txt = "仙兽";
		default:%Name_C_Txt = "";
	}

	return %Name_A_Txt @ %Name_B_Txt @ %Name_C_Txt;
}
//■■■■■■■■■■■【神兽称号功能】■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【获取千里眼查询次数】■■■■■■■■■■■■■■■■■
function GetQianLiYanNum()
{
	%Player = GetPlayer();

	%XS = %Player.GetActivity(2047);
	%XS_B = 1 - GetWord(%XS,0) * 1;				//记录千里眼的值2

	if (%XS_B < 0)
		%XS_B = 0;

	if (%XS_B > 1)
		%XS_B = 1;

	return %XS_B;
}
//■■■■■■■■■■■【获取千里眼查询次数】■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【位运算功能】■■■■■■■■■■■■■■■■■■■■■

function CheckBit(%num,%bit)
{
	return (%num & (1 << %bit)) != 0;
}

//判断标志位是否存在
function HasBit(%src,%bit)
{
	return %src & (1<< %bit);
}

//设置标志位
function SetBit(%src,%bit)
{
	return %src | (1<< %bit);
}

//清除标志位
function ClearBit(%src,%bit)
{
	return %src & ~(1<< %bit);
}

//把一个16位数字转换成 16个2进制数字
function GetBitNum(%src)
{
	%value = (%src & 0x00000001) @ "," @ ((%src >> 1) & 0x00000001) @ "," @ ((%src >> 2) & 0x00000001) @ "," @ ((%src >> 3) & 0x00000001) @ "," @ ((%src >> 4) & 0x00000001) @ "," @ ((%src >> 5) & 0x00000001) @ "," @ ((%src >> 6) & 0x00000001) @ "," @ ((%src >> 7) & 0x00000001) @ "," @ ((%src >> 8) & 0x00000001) @ "," @ ((%src >> 9) & 0x00000001) @ "," @ ((%src >> 10) & 0x00000001) @ "," @ ((%src >> 11) & 0x00000001) @ "," @ ((%src >> 12) & 0x00000001) @ "," @ ((%src >> 13) & 0x00000001) @ "," @ ((%src >> 14) & 0x00000001) @ "," @ ((%src >> 15) & 0x00000001);
	//echo( %value );
}
//设置16个1位数字0~1，合并为1个32位数值
//SetBitNum(1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1);
function SetBitNum(%src1,%src2,%src3,%src4,%src5,%src6,%src7,%src8,%src9,%src10,%src11,%src12,%src13,%src14,%src15,%src16)
{
	return (%src1 & 0x00000001) | ((%src2 & 0x00000001) * (1 << 1)) | ((%src3 & 0x00000001) * (1 << 2)) | ((%src4 & 0x00000001) * (1 << 3)) | ((%src5 & 0x00000001) * (1 << 4)) | ((%src6 & 0x00000001) * (1 << 5)) | ((%src7 & 0x00000001) * (1 << 6)) | ((%src8 & 0x00000001) * (1 << 7)) | ((%src9 & 0x00000001) * (1 << 8)) | ((%src10 & 0x00000001) * (1 << 9)) | ((%src11 & 0x00000001) * (1 << 10)) | ((%src12 & 0x00000001) * (1 << 11)) | ((%src13 & 0x00000001) * (1 << 12)) | ((%src14 & 0x00000001) * (1 << 13)) | ((%src15 & 0x00000001) * (1 << 14)) | ((%src16 & 0x00000001) * (1 << 15));
}
//■■■■■■■■■■■【位运算功能】■■■■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【返回星宿功能所需内容】■■■■■■■■■■■■■■■■
// 返回炼制星宿需要的元宝数量
// %LevelLimit 要炼制的星宿的等级
// %StarLevel  要炼制的星宿的星级
function GetStrengthenTrumpNeedMoney(%LevelLimit,%StarLevel)
{
	%DesStarLevel = %StarLevel + 1;
	switch (%DesStarLevel)
	{
		case 1:%Lv[1] = 5; %Lv[18] = 5; %Lv[60] = 35; %Lv[80] = 90;
		case 2:%Lv[1] = 5; %Lv[18] = 5; %Lv[60] = 35; %Lv[80] = 90;
		case 3:%Lv[1] = 5; %Lv[18] = 5; %Lv[60] = 35; %Lv[80] = 90;
		case 4:%Lv[1] = 10; %Lv[18] = 10; %Lv[60] = 45; %Lv[80] = 105;
		case 5:%Lv[1] = 10; %Lv[18] = 10; %Lv[60] = 45; %Lv[80] = 105;
		case 6:%Lv[1] = 10; %Lv[18] = 10; %Lv[60] = 45; %Lv[80] = 105;
		case 7:%Lv[1] = 15; %Lv[18] = 15; %Lv[60] = 55; %Lv[80] = 120;
		case 8:%Lv[1] = 15; %Lv[18] = 15; %Lv[60] = 55; %Lv[80] = 120;
		case 9:%Lv[1] = 15; %Lv[18] = 15; %Lv[60] = 55; %Lv[80] = 120;
		case 10:%Lv[1] = 20; %Lv[18] = 20; %Lv[60] = 65; %Lv[80] = 135;
		case 11:%Lv[1] = 20; %Lv[18] = 20; %Lv[60] = 65; %Lv[80] = 135;
		case 12:%Lv[1] = 20; %Lv[18] = 20; %Lv[60] = 65; %Lv[80] = 135;
		case 13:%Lv[1] = 25; %Lv[18] = 25; %Lv[60] = 75; %Lv[80] = 150;
		case 14:%Lv[1] = 25; %Lv[18] = 25; %Lv[60] = 75; %Lv[80] = 150;
		case 15:%Lv[1] = 25; %Lv[18] = 25; %Lv[60] = 75; %Lv[80] = 150;
	}
	return %Lv[%LevelLimit];
}
// 返回炼制星宿需要的碎片数量
// %LevelLimit 要炼制的星宿的等级
// %StarLevel  要炼制的星宿的星级
function GetStrengthenTrumpNeedPieceNum(%LevelLimit,%StarLevel)
{
	%DesStarLevel = %StarLevel + 1;
	switch (%DesStarLevel)
	{
		case 1:%Lv[1] = 3; %Lv[18] = 3; %Lv[60] = 3; %Lv[80] = 3;
		case 2:%Lv[1] = 3; %Lv[18] = 3; %Lv[60] = 3; %Lv[80] = 3;
		case 3:%Lv[1] = 3; %Lv[18] = 3; %Lv[60] = 3; %Lv[80] = 3;
		case 4:%Lv[1] = 6; %Lv[18] = 6; %Lv[60] = 6; %Lv[80] = 6;
		case 5:%Lv[1] = 6; %Lv[18] = 6; %Lv[60] = 6; %Lv[80] = 6;
		case 6:%Lv[1] = 6; %Lv[18] = 6; %Lv[60] = 6; %Lv[80] = 6;
		case 7:%Lv[1] = 9; %Lv[18] = 9; %Lv[60] = 9; %Lv[80] = 9;
		case 8:%Lv[1] = 9; %Lv[18] = 9; %Lv[60] = 9; %Lv[80] = 9;
		case 9:%Lv[1] = 9; %Lv[18] = 9; %Lv[60] = 9; %Lv[80] = 9;
		case 10:%Lv[1] = 12; %Lv[18] = 12; %Lv[60] = 12; %Lv[80] = 12;
		case 11:%Lv[1] = 12; %Lv[18] = 12; %Lv[60] = 12; %Lv[80] = 12;
		case 12:%Lv[1] = 12; %Lv[18] = 12; %Lv[60] = 12; %Lv[80] = 12;
		case 13:%Lv[1] = 15; %Lv[18] = 15; %Lv[60] = 15; %Lv[80] = 15;
		case 14:%Lv[1] = 15; %Lv[18] = 15; %Lv[60] = 15; %Lv[80] = 15;
		case 15:%Lv[1] = 15; %Lv[18] = 15; %Lv[60] = 15; %Lv[80] = 15;
	}
	return %Lv[%LevelLimit];
}
// 返回升级星宿需要的元宝数量
// %LevelLimit 要升级的星宿的等级
// %StarLevel  要升级的星宿的星级
function GetUpgradeTrumpNeedMoney(%LevelLimit,%StarLevel)
{
	switch (%LevelLimit)
	{
		case 18:return 150;
		case 60:return 200;
	}
	return 150;
}
// 返回升级星宿需要的碎片数量
// %LevelLimit 要升级的星宿的等级
// %StarLevel  要升级的星宿的星级
function GetUpgradeTrumpNeedPieceNum(%LevelLimit,%StarLevel)
{
	return 10;
}
// 返回升级星宿后可能得到的星宿的道具ID列表
// %LevelLimit 要升级的星宿的等级
// 结果形式为"ItemID01 ItemID02 ... "以空格分格
function GetTrumpUpgradeResultList(%LevelLimit)
{
	switch (%LevelLimit)
	{
		case 18:return "117020012 117030012 117040012";
		case 60:return "117020023 117030023 117040023";
	}

	return "117020012 117030012 117040012";
}
//■■■■■■■■■■■【返回星宿功能所需内容】■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【获取玩家出身地函数】■■■■■■■■■■■■■■■■■
function GetHomeplace(%Player)
{
	%ActivityA = GetWord(%Player.GetActivity(2068),0);
	return 5;
}
//■■■■■■■■■■■【获取玩家出身地函数】■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【灵兽元抗进阶相关脚本】■■■■■■■■■■■■■■■■
//获取当前进阶等级需要消耗的道具
function GetPetStrengthenItem(%lv)
{
	//	switch(%lv)
	//	{
	//		case 0: return "116010101";//灵兽元抗进阶石;
	//		case 1: return "116010102";//灵兽元抗进阶石;
	//		case 2: return "116010103";//灵兽元抗进阶石;
	//		case 3: return "116010104";//灵兽元抗进阶石;
	//		case 4: return "116010105";//灵兽元抗进阶石;
	//		default:return "116010106";//灵兽元抗进阶石;
	//	}

	return "116010101";
}
//获取当前进阶等级需要消耗的钱
function GetPetStrengthenMoney(%lv)
{
	return 30000 * (%lv + 1) - 10000;
}
//获取当前进阶等级最终的成功几率
function PetStrengthen(%lv)
{
	switch (%lv)
	{
		case 0:
			%X = GetRandom(1,10000);
			if (%X <= 4000)return 1;
			else if (%X <= 8000)return 2;
			else return 6;

		case 1:
			%X = GetRandom(1,10000);
			if (%X <= 4000)return 1;
			else if (%X <= 8500)return 2;
			else return 6;

		case 2:
			%X = GetRandom(1,10000);
			if (%X <= 3000)return 1;
			else if (%X <= 6000)return 2;
			else if (%X <= 9000)return 3;
			else return 8;

		case 3:
			%X = GetRandom(1,10000);
			if (%X <= 2375)return 1;
			else if (%X <= 4750)return 2;
			else if (%X <= 7125)return 3;
			else if (%X <= 9500)return 4;
			else return 10;

		case 4:
			%X = GetRandom(1,10000);
			if (%X <= 1960)return 1;
			else if (%X <= 3920)return 2;
			else if (%X <= 5880)return 3;
			else if (%X <= 7840)return 4;
			else if (%X <= 9750)return 5;
			else return 12;

		default:
			%X = GetRandom(1,10000);
			if (%X <= 1640)return 1;
			else if (%X <= 3280)return 2;
			else if (%X <= 4920)return 3;
			else if (%X <= 6560)return 4;
			else if (%X <= 8205)return 5;
			else if (%X <= 9820)return 6;
			else return 14;
	}
}
//获取单个进阶比例
function GetPetStrengthenRang(%lv)
{
	switch (%lv)
	{
		case 1: return 3;
		case 2: return 3;
		case 3: return 4;
		case 4: return 5;
		case 5: return 6;
		case 6: return 7;
		default:return 0;
	}
}
//获取总和进阶比例
function GetPetStrengthenAmountRang(%lv)
{
	switch (%lv)
	{
		case 1: return 6;
		case 2: return 12;
		case 3: return 20;
		case 4: return 30;
		case 5: return 42;
		case 6: return 56;
		default:return 0;
	}
}
//判断此等级是否为完美进阶
function isPerfectStrengthen(%lv,%Num)
{
	switch (%lv)
	{
		case 1: %P = 6;
		case 2: %P = 6;
		case 3: %P = 8;
		case 4: %P = 10;
		case 5: %P = 12;
		case 6: %P = 14;
		default:%P = 0;
	}

	if (%Num >= %P)
		return 1;
	else
		return 0;
}
function GetPetStrengthenItemCount(%Lv)
{
	return %Lv + 1;
}
//■■■■■■■■■■■【灵兽元抗进阶相关脚本】■■■■■■■■■■■■■■■■



//■■■■■■■■■■■【设置免费观星次数】■■■■■■■■■■■■■■■■■■
function FreeGuanXing(%Player,%newCount)
{
}
//■■■■■■■■■■■【设置免费观星次数】■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【官职系统，判断玩家当前是文，武官的哪一品阶】■■■■■
function GetGuanZhiLevel(%Player,%type)
{
	%FirstGuanZhiID = GetDesignationFirstIDByType(%type);  //获取文/武官的第一个官位的ID

	for (%i=%FirstGuanZhiID+17; %i>=%FirstGuanZhiID; %i--)
	{
		if (%Player.sptIsDesignationExist(%i))
			return %i;
	}
	return -1;
}
//■■■■■■■■■■■【官职系统 - 判断玩家当前是文/武官的哪一品阶】■■■■■

//■■■■■■■■■■■【获得玩家所属主城势力】■■■■■■■■■■■■■■■■
function HasBit_City_Force(%Player)
{
	//%Family = %Player.GetFamily();
	//switch (%Family)
	//{
	//	case 1:return 1;	//李阀
	//	case 2:return 1;	//宇文
	//	case 3:return 2;	//寇阀
	//	case 4:return 2;	//宋阀

	//	default: return 0;
	//}
	return 0;
}

//■■■■■■■■■■■【获取该玩家当前可以领取的竞技场奖励】■■■■■■■■■
function GetJingJiChangAward_CS(%Player,%Olddrank,%Combat)
{
	%JJC_Award[1,1] = 1500; %JJC_Award[1,2] = 1500; %JJC_Award[1,3] = 350;
	%JJC_Award[2,1] = 1450; %JJC_Award[2,2] = 1450; %JJC_Award[2,3] = 330;
	%JJC_Award[3,1] = 1400; %JJC_Award[3,2] = 1400; %JJC_Award[3,3] = 300;
	%JJC_Award[4,1] = 1300; %JJC_Award[4,2] = 1300; %JJC_Award[4,3] = 250;
	%JJC_Award[5,1] = 1250; %JJC_Award[5,2] = 1250; %JJC_Award[5,3] = 240;
	%JJC_Award[6,1] = 1200; %JJC_Award[6,2] = 1200; %JJC_Award[6,3] = 230;
	%JJC_Award[7,1] = 1150; %JJC_Award[7,2] = 1150; %JJC_Award[7,3] = 220;
	%JJC_Award[8,1] = 1100; %JJC_Award[8,2] = 1100; %JJC_Award[8,3] = 210;
	%JJC_Award[9,1] = 1050; %JJC_Award[9,2] = 1050; %JJC_Award[9,3] = 200;
	%JJC_Award[10,1] = 1000; %JJC_Award[10,2] = 1000; %JJC_Award[10,3] = 190;
	%JJC_Award[11,1] = 800; %JJC_Award[11,2] = 800; %JJC_Award[11,3] = 150;
	%JJC_Award[12,1] = 600; %JJC_Award[12,2] = 600; %JJC_Award[12,3] = 130;
	%JJC_Award[13,1] = 500; %JJC_Award[13,2] = 400; %JJC_Award[13,3] = 120;
	%JJC_Award[14,1] = 400; %JJC_Award[14,2] = 300; %JJC_Award[14,3] = 100;
	%JJC_Award[15,1] = 300; %JJC_Award[15,2] = 200; %JJC_Award[15,3] = 60;
	%JJC_Award[16,1] = 200; %JJC_Award[16,2] = 150; %JJC_Award[16,3] = 50;
	%JJC_Award[17,1] = 100; %JJC_Award[17,2] = 100; %JJC_Award[17,3] = 20;
	%JJC_Award[18,1] = 350; %JJC_Award[18,2] = 350; %JJC_Award[18,3] = 55;
	%JJC_Award[19,1] = 350; %JJC_Award[19,2] = 350; %JJC_Award[19,3] = 55;
	%JJC_Award[20,1] = 350; %JJC_Award[20,2] = 350; %JJC_Award[20,3] = 55;
	%JJC_Award[21,1] = 300; %JJC_Award[21,2] = 300; %JJC_Award[21,3] = 50;
	%JJC_Award[51,1] = 200; %JJC_Award[51,2] = 200; %JJC_Award[51,3] = 40;
	%JJC_Award[101,1] = 150; %JJC_Award[101,2] = 150; %JJC_Award[101,3] = 30;
	%JJC_Award[201,1] = 100; %JJC_Award[201,2] = 100; %JJC_Award[201,3] = 20;
	%JJC_Award[301,1] = 50; %JJC_Award[301,2] = 80; %JJC_Award[301,3] = 10;
	%JJC_Award[501,1] = 20; %JJC_Award[501,2] = 50; %JJC_Award[501,3] = 5;

	if (%Olddrank >= 501) %MingCi = 501;
	else if (%Olddrank >= 301) %MingCi = 301;
	else if (%Olddrank >= 201) %MingCi = 201;
	else if (%Olddrank >= 101) %MingCi = 101;
	else if (%Olddrank >= 51) %MingCi = 51;
	else if (%Olddrank >= 21) %MingCi = 21;
	else %MingCi = %Olddrank;

	%XiShu = %Combat/20 + 0.05;
	if (%XiShu > 3) %XiShu = 3;

	%JiFen = %JJC_Award[%MingCi,1] * %XiShu;
	%Exp   = %JJC_Award[%MingCi,2] * %XiShu * 10000;
	%Money = %JJC_Award[%MingCi,3] * %XiShu * 10000;

	return %JiFen @ " " @ %Exp @ " " @ %Money;
}

//■■■■■■■■■■■【区域变化触发区域优先级脚本】■■■■■■■■■■■■■
// 成为优先级的区域
function onTopPriority(%Player,%triggerId)
{
	//echo( "%triggerId =AA=" @ %triggerId );
}
// 原先优先级最高的区域 优先级降低时
function onLowPriority(%Player,%triggerId)
{
	//echo( "%triggerId =BB=" @ %triggerId );
}
//■■■■■■■■■■■【区域变化触发区域优先级脚本】■■■■■■■■■■■■■


//■■■■■■■■■■■【货币显示通用脚本】■■■■■■■■■■■■■■■■■■
function ChangeMoneyText(%money)
{
	if (%money $= ""  || %money == 0)
		return "";
	%Jin = mfloor(%money /10000);
	%Yin = mfloor((%money - %Jin * 10000)/100);
	%Ton = %money - %Jin * 10000 - %Yin * 100;

	if (%Jin > 0) %Text1 = "<t>" @ %Jin @ "</t>" @ $Icon[85];
	if (%Yin > 0) %Text2 = "<t>" @ %Yin @ "</t>" @ $Icon[86];
	if (%Ton > 0) %Text3 = "<t>" @ %Ton @ "</t>" @ $Icon[87];

	//SetChatMessage( %Text1 @ %Text2 @ %Text3, $Color[ 5 ], $chatMsg_System );
	//echo( %Text1 @ %Text2 @ %Text3 );
	return %Text1 @ %Text2 @ %Text3;
}

//■■■■■■■■■■■【货币显示通用脚本】■■■■■■■■■■■■■■■■■■

function HuanLeDaZhuanPan_Item(%DataID)
{
	return "";
}
function Family_City_DiaoXiang_Restart()
{
	return;
}
// 刷新当前任务描述
function RefreshMissionDesc(%MissionID)
{
	if ($CurrentMissionID != %MissionID || %MissionID == -1)
	{
		SingleWnd2_ShowMissionInfo.setcontent("");
		SingleWnd2_ShowMissionInfo1.setcontent("");
	}
	else
	{
		SingleWnd2_ShowMissionInfo.setcontent(GetMissionText(GetPlayer(),%MissionID));
		SingleWnd2_ShowMissionInfo1.setcontent($Icon[97] @ "<b/>" @ GetMissionHortation(%MissionID,0,10000));
	}
}


//■■■■■■■■■■■【获取bit值和act值的函数】■■■■■■■■■■■■■■■
function GetSrc(%Player,%bit)
{
	%ActivityID = GetWord($Src_ReturnTime_ActivityID[%bit],0);
	%Resut =  GetWord($Src_ReturnTime_ActivityID[%bit],1);

	//echo( "%ActivityID  ===" @ %ActivityID   @ "   %Resut===" @ %Resut );
	if (%Resut <= 15)
	{
		%Numbers = GetAct(%Player,%ActivityID,0);
		return CheckBit(%Numbers,%Resut -1);
	}
	else
	{
		%Numbers = GetAct(%Player,%ActivityID,1);
		return CheckBit(%Numbers,%Resut -16);
	}
}
//获取Act的值 %bit 0位或者1位
function GetAct(%Player,%ActivityID,%bit)
{
	return GetWord(%Player.GetActivity(%ActivityID),%bit) * 1;
}
//■■■■■■■■■■■【获取bit值和act值的函数】■■■■■■■■■■■■■■■

//■■■■■■■■■■■【签到----取值函数】■■■■■■■■■■■■■■■■■■
function GetQiandaoRecord(%Player,%Days)//获取某一天的签到记录
{
	if (%Days > 15)
		return CheckBit(GetAct(%Player,4020,1),%Days - 16);
	else
		return CheckBit(GetAct(%Player,4020,0),%Days);
}
function GetALLQianDaoRecord(%Player)//获取当月签到具体记录
{
	%Title = GetQiandaoRecord(%Player,1);
	for (%i = 2; %i<=31; %i++)
	{
		%Title = %Title @ " " @ GetQiandaoRecord(%Player,%i);
	}
	//echo( "%Title===" @ %Title );
	return %Title;
}
function GetALLQianDaoRecordDays(%Player)//获取本月签到天数
{
	%Num = 0;
	for (%i = 1; %i<=31; %i++)
	{
		%Num = %Num + GetQiandaoRecord(%Player,%i);
	}
	//echo( "%Num===" @ %Num );
	return %Num;
}
//■■■■■■■■■■■【签到----取值函数】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【活跃----活跃度计算】■■■■■■■■■■■■■■■■■
function GetHuoYueDuRecord(%Player)
{
	for (%i = 1; %i<= 3; %i++)
	{
		for (%j= 1; %j <= 99; %j++)
		{
			if ($HuoYueDuRecord[%i,%j] $= "")
				break;
			%Optype = GetWord($HuoYueDuRecord[%i,%j],1);
			%RecordID = GetWord($HuoYueDuRecord[%i,%j],2);
			%NeedCount = GetWord($HuoYueDuRecord[%i,%j],3);
			%GiveHuoYue = GetWord($HuoYueDuRecord[%i,%j],4);
			switch$(%Optype)
			{
		case "Src":
			%HaveCount = GetSrc(%Player,%RecordID);
		case "Act0":
			%HaveCount = GetAct(%Player,%RecordID,0)*1;
		case "Act1":
			%HaveCount = GetAct(%Player,%RecordID,1)*1;
		case "Spcl":
			%HaveCount = GetSpclHuoYueDu(%Player,%RecordID);
			%GiveHuoYue = GetSpclHuoYueDuAddNumBer(%Player,%RecordID,%GiveHuoYue);
			}
			if (%HaveCount >= %NeedCount)
				%HuoYue = %HuoYue + %GiveHuoYue;
		}
	}
	//echo( "%HuoYue====" @ %HuoYue );
	return %HuoYue * 1;
}
function GetSpclHuoYueDu(%Player,%RecordID)//特殊处理的活跃度完成进度计算
{
	switch (%RecordID)
	{
		case 1://冰火试炼的特殊处理
			%HaveCount = GetSrc(%Player,40) +  GetSrc(%Player,41) +  GetSrc(%Player,42) +  GetSrc(%Player,43) +  GetSrc(%Player,49) +  GetSrc(%Player,55) +  GetSrc(%Player,56);
			//echo( "%HaveCount===" @ %HaveCount );
		case 2://押镖的特殊处理 每次+2点 一共10点
			%HaveCount = GetAct(%Player,4018,0) * 1;
		case 3:
			%HaveCount = GetAct(%Player,4092,0) * 1;
		case 4:
			%Act = GetAct(%Player,4094,0);
			%Time = GetLocalTime();
			%Month = GetWord(%Time,1);
			%Day = GetWord(%Time,2);
			if (%Day < 10)
				%Day = "0" @ %Day;
			if (%Act * 1 ==  (%Month @ %Day) * 1)
				%HaveCount = 1;
			else
				%HaveCount = 0;
	}
	return %HaveCount;
}
function GetSpclHuoYueDuAddNumBer(%Player,%RecordType,%GiveHuoYue)//特殊处理的活跃度完成给予数值计算
{
	//echo( "%GiveHuoYue===" @ %GiveHuoYue );
	switch (%RecordType)
	{
		case 1://冰火试炼的特殊处理
			%GiveHuoYue = %GiveHuoYue;
		case 2://押镖的特殊处理 每次+2点 一共10点
			%HaveCount = GetAct(%Player,4018,0) * 1;
			%GiveHuoYue = %HaveCount * 2;
			if (%GiveHuoYue <= 0)
				%GiveHuoYue = 10;
		case 3:
			%Color = GetAct(%Player,4092,1) * 1;
			switch (%Color)
			{
				case 1:%GiveHuoYue = 1;
				case 2:%GiveHuoYue = 2;
				case 3:%GiveHuoYue = 3;
				case 4:%GiveHuoYue = 5;
				case 5:%GiveHuoYue = 8;
				case 6:%GiveHuoYue = 10;
				default:%GiveHuoYue = %GiveHuoYue;
			}
	}
	return %GiveHuoYue;
}

//■■■■■■■■■■■【活跃----活跃度计算】■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【传送地图前置判断】■■■■■■■■■■■■■■■■■
function CanTransportobject(%Player,%optype)//通用传送前置
{
	//玩家是否死亡
	if (%Player.IsDisabled())
	{
		return 0;
	}
	switch (%optype)
	{
		case 1://普通的NPC传送
			if (%Player.isInMultiMount())
			{
				%Txt = "多人骑乘下无法前往此地图";
				SendOneScreenMessage(2,%Txt,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
				return 0;
			}
		case 2://地图按钮传送 客户端触发
			//echo( "%Player.IsAcceptedMission( 20147 )===" @ %Player.IsAcceptedMission( 20147 ) );
			if (%Player.IsAcceptedMission(20147))
			{
				SendOneScreenMessage(2,"押镖时无法传送",%Player);
				return 0;
			}
			if (%Player.GetTriggerId() $= "811190108" || %Player.GetTriggerId() $= "811190109")
			{
				SendOneScreenMessage(2, "囚仙牢无法使用本功能", %Player);
				return 0;
			}
			if (%Player.GetLevel() < 30)
			{
				SendOneScreenMessage(2, "您的角色低于30级，无法进行传送", %Player);
				SendOneChatMessage($chatMsg_System, "<t>您的角色低于40级，无法进行传送</t>", %Player);
				return 0;
			}
			if (%Player.GetFamilarityTarget() != 0)
			{
				SendOneScreenMessage(2, "背负/拥抱状态下无法使用本功能", %Player);
				return 0;
			}
			if (%Player.isInMultiMount())
			{
				%Txt = "多人骑乘下无法前往此地图";
				SendOneScreenMessage(2, %Txt, %Player);
				SendOneChatMessage($chatMsg_System, "<t>" @ %Txt @ "</t>", %Player);
				return 0;
			}
		case 3://千里眼
			if (%Player.GetLevel() < 40)
			{
				SendOneScreenMessage(2,"您的角色低于40级，无法进行传送",%Player);
				SendOneChatMessage($chatMsg_System,"<t>您的角色低于40级，无法进行传送</t>",%Player);
				return 0;
			}
			//玩家当前正忙，有交互状态，不能传送
			if ((%Player.GetInteractionState() == 1)||(%Player.GetInteractionState() == 2)||(%Player.GetInteractionState() > 3))
			{
				SendWhyMsg(%Player,"H",0,1);
				return 0;
			}
			if (GetSubStr(%Together,2,1) $= "3")
			{
				SendOneScreenMessage(2,"目标玩家正在副本内，无法直接前往",%Player);
				SendOneChatMessage($chatMsg_System,"<t>目标玩家正在副本内，无法直接前往</t>",%Player);
				return 0;
			}
			if (GetSubStr(GetZoneID(),1,1) $= "3")
			{
				SendOneScreenMessage(2,"您正在副本内，无法直接前往",%Player);
				SendOneChatMessage($chatMsg_System,"<t>您正在副本内，无法直接前往</t>",%Player);
				return 0;
			}
			if (%Player.GetTriggerId() $= "811190108" || %Player.GetTriggerId() $= "811190109")
			{
				SendOneScreenMessage(2,"囚仙牢无法使用本功能",%Player);
				return 0;
			}
			if (%Player.GetTriggerId() $= "811190108" || %Player.GetTriggerId() $= "811190109")
			{
				SendOneScreenMessage(2,"监狱无法使用本功能",%Player);
				return 0;
			}
			if (%Player.GetFamilarityTarget() != 0)
			{
				SendOneScreenMessage(2,"背负/拥抱状态下无法使用本功能",%Player);
				return 0;
			}
			if (%Player.IsDisabled())
			{
				SendWhyMsg(%Player,"AA",0,1);//死亡状态无法使用回城符
				return 0;
			}
			if (%Player.IsInCombat())
			{
				SendWhyMsg(%Player,"AB",0,1);//玩家是否战斗中
				return 0;
			}
			if (%Player.isInMultiMount())
			{
				SendOneScreenMessage(2,"多人骑乘下无法使用本功能",%Player);
				SendOneChatMessage($chatMsg_System,"<t>多人骑乘下无法使用本功能</t>",%Player);
				return 0;
			}
			if (%Player.IsAcceptedMission(20147))
			{
				SendOneScreenMessage(2,"押镖时无法传送",%Player);
				return 0;
			}
		case 4://向队长集合
			%PlayerID = %Player.GetPlayerID();
			if (SvrIsMyselfHasTeam(%PlayerID) == 0)
			{
				SendWhyMsg(%Player,"BF",0,1);//您没有队伍，无法使用
				return 0;
			}
			if (SvrIsMyselfCaption(%PlayerID))
			{
				SendWhyMsg(%Player,"BG",0,1);//该功能只能是队员才可执行
				return 0;
			}
			if (%Player.IsAcceptedMission(20147))
			{
				SendOneScreenMessage(2,"押镖时无法传送",%Player);
				return 0;
			}
			
		case 5://使用集合符
			if (%Player.IsAcceptedMission(20147))
			{
				SendOneScreenMessage(2,"押镖时无法传送",%Player);
				return 0;
			}
			if (%Player.Getlevel() < 30)
			{
				SendOneScreenMessage(2, "等级不足，30级以上才可以被召唤", %Player);
				return 0;
			}
		case 6://回城卷
			if (%Player.IsDisabled())
			{
				SendWhyMsg(%Player,"AA",0,1);//死亡状态无法使用回城符
				return 0;
			}
			if (%Player.GetBuffCount(39903,1) >= 1 || %Player.GetBuffCount(39904,1) >= 1)
			{
				SendOneScreenMessage(2,"携带有草药，无法传送",%Player);
				return 0;
			}
			if (%Player.GetBuffCount(39906,1) >= 1 || %Player.GetBuffCount(39906,2) >= 1 || %Player.GetBuffCount(39906,3) >= 1)
			{
				SendOneScreenMessage(2,"携带有灵石，无法传送",%Player);
				return 0;
			}
			if (%Player.IsAcceptedMission(20147))
			{
				SendOneScreenMessage(2,"您正在押镖，无法传送",%Player);
				return 0;
			}
		case 7://随机卷
			if (%Player.IsDisabled())
			{
				SendWhyMsg(%Player,"AA",0,1);//死亡状态无法使用回城符
				return 0;
			}
			if (%Player.GetBuffCount(39903,1) >= 1 || %Player.GetBuffCount(39904,1) >= 1)
			{
				SendOneScreenMessage(2,"携带有草药，无法传送",%Player);
				return 0;
			}
			if (%Player.GetBuffCount(39906,1) >= 1 || %Player.GetBuffCount(39906,2) >= 1 || %Player.GetBuffCount(39906,3) >= 1)
			{
				SendOneScreenMessage(2,"携带有灵石，无法传送",%Player);
				return 0;
			}
			if (%Player.IsAcceptedMission(20147))
			{
				SendOneScreenMessage(2,"您正在押镖，无法传送",%Player);
				return 0;
			}
	}
	return 1;
}
//■■■■■■■■■■■【传送地图前置判断】■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【发公告前的各种准备】■■■■■■■■■■■■■■■■■
function GetPlayerZiTiName(%Player,%optype)
{
	switch (%optype)
	{
		case 1: %PlayerName = "<l i='"@ %Player.GetPlayerName() @ " "@ %Player.GetPlayerID() @ "' t='name' />";
		case 2: %PlayerName = $Get_Dialog_GeShi[60006] @ "『" @ %Player.GetPlayerName() @ "』</t>";
	}
	return %PlayerName;
}
function GetNpcZiTiName(%Npc,%optype)
{
	if (isobject(%Npc))
		%NpcID = %Npc.GetDataID();
	else
		%NpcID = %Npc;
	switch (%optype)
	{
		case 1: %NpcName = $Get_Dialog_GeShi[31421] @ "『" @ GetNpcData(%NpcID,1) @ "』</t>";
		case 2: %NpcName = $Get_Dialog_GeShi[60003] @ "『" @ GetNpcData(%NpcID,1) @ "』</t>";
	}
	return %NpcName;
}
function GetHuoDongName(%HuoDong,%optype)
{
	switch (%optype)
	{
		case 1: %HuoDongName = $Get_Dialog_GeShi[31421] @ "『" @ %HuoDong @ "』</t>";
		case 2: %HuoDongName = $Get_Dialog_GeShi[60003] @ "『" @ %HuoDong @ "』</t>";
	}
	return %HuoDongName;
}
function GetMapName(%Caster,%optype)
{
	//echo(" %Caster===" @  %Caster @ "     " @ isobject(%Caster));
	if (isobject(%Caster))
	{
		%TriggerID = %Caster.GetTriggerId();
		%Pos = %Caster.GetPosition();
	}
	else
	{
		%TriggerID = %Caster;
		%Pos = %optype;
	}
	//echo("%TriggerID==" @ %TriggerID @ "   %Pos===" @ %Pos);
	switch (%optype)
	{
		case 1: %Path = "<l i='" @ GetSubStr(%TriggerID,0,7) @ "00 " @ %Pos @ "' t='path'/>";
		case 2:
			%MapID = GetZoneID();

			%MapName = GetTriggerData(GetSubStr(%TriggerID,0,7) @ "00",3);
			%TriggerName = GetTriggerData(%TriggerID,3);

			if (%MapName $= %TriggerName)
				%Path = $Get_Dialog_GeShi[60003] @ %MapName @ "</t>";
			else
				%Path = $Get_Dialog_GeShi[60003] @ %MapName @ "</t>" @ $Get_Dialog_GeShi[60002] @ %TriggerName @ "</t>";
		default: %Path = "<l i='" @ %TriggerID @ %Pos @ "' t='path'/>";
	}
	return %Path;
}
function GetItemName(%ItemID,%optype)
{
	switch (%optype)
	{
		case 1: %ItemName = "<l v='1' h='1' i='" @ %ItemID @ " ' t='itemid'/>";
		case 2:
			%ItemName = GetItemData(%ItemID,1);
			%Clor = GetItemData(%ItemID,20);
			switch (%Clor)
			{
				case 2: %Ziti = $Get_Dialog_GeShi[60004];//白色
				case 3: %Ziti = $Get_Dialog_GeShi[60006];//绿色
				case 4: %Ziti = $Get_Dialog_GeShi[60005];//蓝色
				case 5: %Ziti = $Get_Dialog_GeShi[60002];//紫色
				case 6: %Ziti = $Get_Dialog_GeShi[60003];//橙
				case 7: %Ziti = $Get_Dialog_GeShi[60007];//红色
				default: %Ziti = $Get_Dialog_GeShi[60004];
			}
			%ItemName = %Ziti @  "[" @ %ItemName @ "]</t>";
	}
	return %ItemName;
}
//■■■■■■■■■■■【发公告前的各种准备】■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■处理寻径按钮计数■■■■■■■■■■■■■■■■■■■■
function Get_TraceButton()
{
	$TraceButton = $TraceButton + 1;
	%Back = "TraceButton" @ $TraceButton;
	return %Back;
}

function Get_ChatButton()
{
	$ChatButton = $ChatButton + 1;
	%Back = "ChatButton" @ $ChatButton;
	return %Back;
}
//■■■■■■■■■■■处理寻径按钮计数■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【角色进入战斗触发脚本】■■■■■■■■■■■■■■■■
function onPlayerCombatBegin(%Player)//客户端服务端同时触发，添加功能的时候要区分客户端和服务端
{
	//echo( "角色进入战斗触发脚本%Player===" @ %Player );
	//%MapID = GetZoneID( );
}
//■■■■■■■■■■■【角色进入战斗触发脚本】■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【大小比较函数】■■■■■■■■■■■■■■■■■■■■
function getMin(%a,%b)
{
	if (%a > %b)
		return %b;
	else
		return %a;
}
function getMax(%a,%b)
{
	if (%a < %b)
		return %b;
	else
		return %a;
}
//■■■■■■■■■■■【大小比较函数】■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【怪物战斗力】相关■■■■■■■■■■■■■■■■■■■
//返回相应战斗力值

//返回相应战斗力值
function GetNpcBattleGiftValue(%Monster)
{
	//获取副本层
	%CopyMapID = %Monster.GetLayerId();

	//获取副本DataID
	%CopymapDataID = SptGetCopymapDataId(%CopyMapID);

	switch (%CopymapDataID)
	{
		//【 时空裂痕之变 】活动副本
		case 1314: return $XuanWuMen_NpcBattleGiftValue[%CopyMapID];
	}

	return 0;
}
//■■■■■■■■■■■【怪物战斗力】相关■■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【快捷购买 -- 返回商品ID和售价】■■■■■■■■■■
$QuickPurchase_Itemid[0] = 105106004; $QuickPurchase_Price[0] = 100; //夺宝符
$QuickPurchase_Itemid[1] = 105109524; $QuickPurchase_Price[1] = 100; //星界石
//OpenBuyItemInterfaceWndGui($QuickPurchase_Itemid[0], $QuickPurchase_Price[0]);




//■■■■■■■■■■■返回道具真实ID和数量■■■■■■■■■■■■■■■■■■
function getItemTrueIDOrCnt(%Player, %oldItemID, %cntInfo, %Spare)
{
	%Plv = %Player.Getlevel();
	if(%Plv < 10) %Plv = 10;
	else if(%Plv >= 15 && %Plv < 20) %Plv = 20;
	
	%sex = %Player.GetSex();
	%liyuVipLv = VIP_getTequanLv(%Player, 1);
	
	if(%oldItemID*1 > 0)
	{
		//时装
		%ItemSubtype = GetItemData(%oldItemID,3);
		if (%ItemSubtype == 210)//身体时装
		{
			if(%sex == 2)
				return %oldItemID + 500;
			else return %oldItemID;
		}

		switch(%oldItemID)
		{
			case 105020303:	//3级凝血丹(赠品)
				return 105020300 + Mfloor(%Plv/10);
			
			case 105020353:	//3级聚神散(赠品)
				return 105020350 + Mfloor(%Plv/10);
			
			case 105020103:	//3级凝血丹
				return 105020100 + Mfloor(%Plv/10);
			
			case 105020153:	//3级聚神散
				return 105020150 + Mfloor(%Plv/10);
			
			case 105100201:	//简约版【攻·琥珀】（赠品）
				if(%Spare*1 > 0)
					return %oldItemID;
					
						 if(%liyuVipLv == 1) return 105021601;
				else if(%liyuVipLv == 2) return 105021603;
				else if(%liyuVipLv == 3) return 105021605;
			
			case 105100202:	//简约版【防·琥珀】（赠品）
				if(%Spare*1 > 0)
					return %oldItemID;
					
						 if(%liyuVipLv == 1) return 105021602;
				else if(%liyuVipLv == 2) return 105021604;
				else if(%liyuVipLv == 3) return 105021606;
			
			case 102103029:	//专属时装1件
				if(%sex == 2) return 102103529;
				else return %oldItemID;
			
			case 105021201:	//不死丹(赠品)
				if(%Spare == 1)	//显示用
				{
							 if(%Plv < 70)  return 105021201;
					else if(%Plv < 90)  return 105021202;
					else if(%Plv < 100) return 105021203;
					else								return 105021204;
				}
				else	//实际给予
				{
					if(%liyuVipLv == 2)
					{
								 if(%Plv < 70)  return 105021221;	//黄金
						else if(%Plv < 90)  return 105021222;
						else if(%Plv < 100) return 105021223;
						else								return 105021224;
					}
					else if(%liyuVipLv == 3)
					{
								 if(%Plv < 70)  return 105021241;	//白金
						else if(%Plv < 90)  return 105021242;
						else if(%Plv < 100) return 105021243;
						else								return 105021244;
					}
				}
			
			case 105021211:	//朝元散(赠品)
				if(%Spare == 1)	//显示用
				{
							 if(%Plv < 70)  return 105021211;
					else if(%Plv < 90)  return 105021212;
					else if(%Plv < 100) return 105021213;
					else								return 105021214;
				}
				else	//实际给予
				{
					if(%liyuVipLv == 2)
					{
								 if(%Plv < 70)  return 105021231;	//黄金
						else if(%Plv < 90)  return 105021232;
						else if(%Plv < 100) return 105021233;
						else								return 105021234;
					}
					else if(%liyuVipLv == 3)
					{
								 if(%Plv < 70)  return 105021251;	//白金
						else if(%Plv < 90)  return 105021252;
						else if(%Plv < 100) return 105021253;
						else								return 105021254;
					}
				}
		}
		return %oldItemID;
	}
	
	if(%cntInfo !$= "")
	{
		%min = GetWord(%cntInfo,0,"-");
		%max = GetWord(%cntInfo,1,"-");
		%cnt = GetRandom(%min,%max);
		return %cnt;
	}
	
	return 0;
}


//■■■■■■■■道经■获取元宝消耗■■■■■■■■■■■■■■■■■■■
function SpecialItem_DaoJing_GetYuanBaoExpend(%Player, %type)
{
	%YB[1] = %YB[2] = %YB[3] = 200;
	%YB[4] = %YB[5] = %YB[6] = 400;
	%YB[7] = %YB[8] = %YB[9] = 500;
	%YB[10] = 600;
	
	%ActiveAA = GetAct(%Player,4300,0)*1 + 1;
	if(%ActiveAA <= 10)
		%NeedYB = %YB[%ActiveAA];
	else
		%NeedYB = %YB[10] + (%ActiveAA-10)*100;
	
	if(%type == 2)
		return %NeedYB;
	else
		return %NeedYB*2+100;
}
//■■■■■■■■道经■获取元宝消耗■■■■■■■■■■■■■■■■■■■■■■


//■■■■■■■■道经■获取元宝消耗■■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【获取随机装备】■■■■■■■■■■■■■■■■■■■■
function GetRanDomPurpleEquipment(%Level)
{
	%classes = getrandom(1, 3);
	switch (%classes)
	{
	case 1:%classes = 1;
	case 2:%classes = 4;
	case 3:%classes = 8;
	}
	%number = getrandom(1, 18);
	if (%number == 1)
	{
		%ran = getrandom(1, 100);//替换为刀剑类武器
		if (%ran <= 20)
		{
			%classes = 31;
			%number = 1;
		}
	}
	%itemid = $PurpleEquipment_LevelForty[%classes, %number];
	%itemid = %itemid - 4 + mfloor(%Level / 10);
	return %itemid;
}
//■■■■■■■■■■■【获取随机装备】■■■■■■■■■■■■■■■■■■■■