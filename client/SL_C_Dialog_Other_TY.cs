//■■■■■■■■■■■获取活动对话■■■■■■■■■■■■■■■■■

$YuanBaoShangCheng = "<c cid='" @ Get_TraceButton() @ "' cmd='\"" @ "OpenBusinessCity();setSuperMarketType(4);setBusinessCityItemType(2);" @ "\",\"" @ $Get_Dialog_GeShi[80005]  @ "元宝商城" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />";
function Get_TY_Dialog_TY(%Npc,%Player,%DialogID,%Param)
{
	switch (%DialogID)
	{
		case 600000000: return $Get_Dialog_GeShi[80002] @ /*默认为白色格式（最外层嵌套）*/
			$Get_Dialog_GeShi[80000] @ "◆群英汇聚：</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆开放时间：</t><t>每天</t>" @ $Get_Dialog_GeShi[80003] @ " 19:00 " @ "</t><t>开始</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆活动奖励：</t><t>大量经验</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆参与规则：</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "1、帮主召唤帮派图腾</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "2、帮众们向图腾领取图腾之力状态</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "3、沐浴图腾之力，可持续获得经验</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "4、你也可以花费一定的元宝领取其他帮派的图腾</t><b/>" @
			$Get_Dialog_GeShi[80004] @ "小提示：如果领取的不是本帮的图腾，需要花费200元宝才可以领取图腾状态（其中100元宝将由召唤该图腾的帮主获得）。</t>";

		case 600000001: return $Icon[5] @ "<t>领取图腾之力</t>";

		case 600000002: return $Get_Dialog_GeShi[31492] @ "你不是本帮成员，需要花费200元宝才能领取（其中100元宝将由召唤该图腾的帮主获得），是否确认领取?</t>";

		case 600000003: return $Icon[5] @ "<t>确定领取（点击扣除200元宝)</t>";

		case 600000004: return $Get_Dialog_GeShi[80002] @ /*默认为白色格式（最外层嵌套）*/
			$Get_Dialog_GeShi[80000] @ "◆时空裂痕◆</t>" @
			$Get_Dialog_GeShi[80001] @ "◆开放时间：</t><t>每天</t>" @ $Get_Dialog_GeShi[80003] @ " 19:00--22:00 " @ "</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆挑战建议：</t><t>三人（战、法、道）以上</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆副本奖励：</t><t>大量经验</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆参与规则：</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "1、每人每天可挑战一次</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "2、副本内寻找自己的本命星刷新星魂等级</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "3、根据不同的星魂等级获得不同的经验倍数</t><b/>" @
			$Get_Dialog_GeShi[80004] @ "小提示：进入副本后，免费刷新一次星魂等级！</t></t>";

		case 600000005: return $Icon[10] @ "<t>进入副本</t>";

		case 600000006: return $Get_Dialog_GeShi[80002] @ /*默认为白色格式（最外层嵌套）*/
			$Get_Dialog_GeShi[80000] @ "◆时空裂痕◆</t>" @
			$Get_Dialog_GeShi[80001] @ "◆开放时间：</t><t>每天</t>" @ $Get_Dialog_GeShi[80003] @ " 19:00--22:00 " @ "</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆挑战建议：</t><t>三人（战、法、道）以上</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆副本奖励：</t><t>大量经验</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆参与规则：</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "1、每人每天可挑战一次</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "2、副本内寻找自己的本命星刷新星魂等级</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "3、根据不同的星魂等级获得不同的经验倍数</t><b/>" @
			$Get_Dialog_GeShi[80004] @ "小提示：进入副本后，免费刷新一次星魂等级！</t></t>";
		case 600000007: return $Icon[5] @ "<t>开启挑战</t>";

		case 600000008:  return $Get_Dialog_GeShi[80002] @ /*默认为白色格式（最外层嵌套）*/
			$Get_Dialog_GeShi[80000] @ "◆炼魔渊◆</t>" @
			$Get_Dialog_GeShi[80001] @ "◆开放时间：</t><t>全天开放</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆挑战建议：</t><t>6人</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆副本奖励：</t><t>珍贵道具</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆参与规则：</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "1、每人每天可免费挑战</t>" @ $Get_Dialog_GeShi[80003] @ " 1 </t>" @ "<t>次</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "2、使用</t>" @ "<l i='105109201 ' t='itemid'/>" @ "<t>挑战，每天可用</t>" @ $Get_Dialog_GeShi[80003] @ " 2 </t><t>次</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "3、击败地宫怪物有几率掉落</t>" @ GetItemName(105109201,1) @ "<b/>" @
			$Get_Dialog_GeShi[80002] @ "4、每击败一个首领，即可获得一份奖励，同时进入下一关</t><b/>" @
			$Get_Dialog_GeShi[80004] @ "小提示：副本挑战时间为10分，挑战开启后无法中途暂停！</t></t>";

		case 600000009: return $Icon[10] @ "<t>进入副本</t>";

		case 600000010: return $Get_Dialog_GeShi[80002] @ /*默认为白色格式（最外层嵌套）*/
			$Get_Dialog_GeShi[80001] @ "◆挑战规则：</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "1、由队长开启挑战</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "2、上一个首领死亡后可以开启下一个挑战首领</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "3、总共挑战时间为10分，中途无休息时间，无法暂停</t><b/>"@
			$Get_Dialog_GeShi[80004] @ "小提示：开启挑战后无法中途停止!</t><b/>";

		case 600000011: return $Icon[5] @ "<t>开启挑战</t>";

		case 600000012: return $Icon[5] @ "<t>挑战下一个首领</t>";

		case 600000013:  return $Get_Dialog_GeShi[80002] @ /*默认为白色格式（最外层嵌套）*/
			$Get_Dialog_GeShi[80000] @ "◆幻境争霸◆</t>" @
			$Get_Dialog_GeShi[80001] @ "◆开放时间：</t><t>周一、三、五" @ " </t>" @ $Get_Dialog_GeShi[80003] @ "20:00-20:05" @ " </t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆挑战等级：</t><t>40级</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆挑战人数：</t><t>单人进入</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆副本奖励：</t><t>珍贵道具、大量经验</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆参与规则：</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "1、只允许单人进入</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "2、幻境争霸有4层，越高层奖励越多</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "3、击败一人获得一层状态，死亡一次减少一层</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "4、当累积</t>" @ $Get_Dialog_GeShi[80003] @ " 5 </t>" @ "<t>层状态，进入下一层</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "5、当状态层数为</t>" @ $Get_Dialog_GeShi[80003] @ " 0 </t>" @ "<t>时，会跌落到上一层</t><b/>" @
			$Get_Dialog_GeShi[80004] @ "小提示：在幻境争霸内，所有的人都是你的敌人！</t></t>";

		case 600000014: return $Icon[10] @ "<t>进入副本</t>";

		case 600000015:  return $Get_Dialog_GeShi[80002] @ /*默认为白色格式（最外层嵌套）*/
			$Get_Dialog_GeShi[80000] @ "◆陨仙窟一层◆</t>" @
			$Get_Dialog_GeShi[80001] @ "◆开放时间：</t>"  @ $Get_Dialog_GeShi[80003] @ " </t><t>永久</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆挑战等级：</t><t>20-30级</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "1、只允许单人进入</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "2、陨仙窟最近很多事故发生，你可愿意帮我一起整顿陨仙窟？</t><b/>" @
			$Get_Dialog_GeShi[80004] @ "小提示：在陨仙窟内，所有的人都是你的敌人！</t></t>";

		case 600000016: return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "<t>采集仙药</t>";/*默认为白色格式（最外层嵌套）*/

		case 600000017: return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "<t>挑战精英怪物</t>";/*默认为白色格式（最外层嵌套）*/

		case 600000018: return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "<t>镇压群妖</t>";/*默认为白色格式（最外层嵌套）*/

		case 600000019: return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "<t>寻找失踪散修</t>";/*默认为白色格式（最外层嵌套）*/
		case 600000020: return "<t>此次多亏你多次帮助，不然恐怕……</t>";/*默认为白色格式（最外层嵌套）*/

		case 600000021: return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "<t>可算寻到你了，我先帮你处理下伤口。</t>";/*默认为白色格式（最外层嵌套）*/

		case 600000022: return $Get_Dialog_GeShi[80002] @ "<t>我已无大碍，可以自己回去了，多谢道友！</t>";/*默认为白色格式（最外层嵌套）*/

		case 600000023: return $Get_Dialog_GeShi[80002] @ "<t>妖灵出现在</t>" @ "<l i='" @ "8" @ getact(getplayer(),4013,0) @ "0100 " @ $strMapRanPosRecord[getact(getplayer(),4013,0),getact(getplayer(),4013,1)] @ "' t='path'/>" @ $Get_Dialog_GeShi[80002] @ "，赶快前去吧！</t>";

		case 600000024: return $Get_Dialog_GeShi[80002] @ "<t>藏宝图指向的方位在</t>" @ "<l i='" @ "8" @ getact(getplayer(),4014,0) @ "0100 " @ $strMapRanPosRecord[getact(getplayer(),4014,0),getact(getplayer(),4014,1)] @ "' t='path'/>" @ $Get_Dialog_GeShi[80002] @ "附近，不要瞎点点！</t>";

		case 600000025:
			%Level = getplayer().getlevel();
			if (%Level < 35)
				%Level = 35;
			return $Icon[19] @ $Get_Dialog_GeShi[31496] @ "循环-[" @ %Level @ "] 师门尽忠（接受）</t>";
		case 600000026: return $Get_Dialog_GeShi[80002] @ /*默认为白色格式（最外层嵌套）*/
			$Get_Dialog_GeShi[80000] @ "◆诛神问心阵◆</t>" @
			$Get_Dialog_GeShi[80001] @ "◆开放时间：</t><t>18:00-24:00 </t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆挑战等级：</t><t>40级</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆挑战人数：</t><t>单人</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆副本奖励：</t><t>珍贵道具</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "◆参与规则：</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "1、只允许单人进入</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "2、诛神问心阵每天可以挑战3次</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "3、诛神问心阵一共有10关</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "4、成功挑战一道关卡奖励一个宝箱，同一道关卡的宝箱一天只能开启一次</t><b/>" @
			$Get_Dialog_GeShi[80004] @ "小提示：在诛神问心阵内，死亡即挑战失败</t></t>";

		case 600000027: return $Icon[10] @ $Get_Dialog_GeShi[80002] @ "挑战『诛神问心阵』</t>";
		case 600000028:
			%Act = getact(%player,4016,1) * 1;
			if (%Act <= 10)
				return $Icon[5] @ "<t>开启挑战（当前第" @ %act @ "关）</t>";
			else
				return $Icon[5] @ "<t>已经通关</t>";

		case 600000029:
			return $Get_Dialog_GeShi[80002] @ /*默认为白色格式（最外层嵌套）*/
				$Get_Dialog_GeShi[80000] @ "◆鸿蒙试炼◆</t>" @
				$Get_Dialog_GeShi[80001] @ "◆开放时间：</t><t>周二、四、六" @ " </t>" @ $Get_Dialog_GeShi[80003] @ "20:00-20:05" @ " </t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆挑战等级：</t><t>40级</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆挑战人数：</t><t>单人</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆副本奖励：</t><t>大量经验，珍贵道具</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆参与规则：</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "1、只允许单人进入</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "2、该副本为善恶地图，任意善恶无惩罚</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "3、在战场内坚持的越久，奖励越丰富</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "4、战场开启当天，只允许挑战一次</t><b/>" @
				$Get_Dialog_GeShi[80004] @ "小提示：死亡后将无法继续参赛</t></t>";
		case 600000030: return $Icon[10] @ $Get_Dialog_GeShi[80002] @ "进入『鸿蒙试炼』</t>";
		case 600000031: return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "领取奖励</t>";
		case 600000032: return $Icon[38] @ $Get_Dialog_GeShi[80006] @ "<t>太弱了！你还是多召唤些分身吧！</t>";
		case 600000033: return $Get_Dialog_GeShi[80002] @ "<t>哈哈哈哈总有一天你们这些伪君子会被我们杀光！</t>";

		case 600000034: return $Get_Dialog_GeShi[80002] @ "<t>前往苍山雪海 蛇族：左上角</t>";
		case 600000035: return $Get_Dialog_GeShi[80002] @ "<t>前往苍山雪海 鬼族：左下角</t>";
		case 600000036: return $Get_Dialog_GeShi[80002] @ "<t>前往苍山雪海 羽族：右上角</t>";

		case 600000037: return $Icon[38] @ $Get_Dialog_GeShi[80006] @ "<t>让你的长老们来吧！</t>";
		case 600000038: return $Get_Dialog_GeShi[80002] @ "<t>我族永垂不朽！！</t>";
			//-------------------押镖活动----------------
		case 600000039: return "<t>押镖活动尚未开始，你来早了。</t>";
		case 600000040:	 //押镖活动介绍
			return $Get_Dialog_GeShi[80002] @ /*默认为白色格式（最外层嵌套）*/
				$Get_Dialog_GeShi[80000] @ "◆押镖◆</t>" @
				$Get_Dialog_GeShi[80001] @ "◆开放时间：</t><t>12:00-22:00 </t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆需要等级：</t><t>50级</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆活动奖励：</t><t>大量金钱</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆参与规则：</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "1、押送颜色品质越高的镖车，奖励越丰厚</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "2、押送完成后，根据所缴押金获得奖励</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "3、如中途被击败、离开封魔城，失去镖车</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "4、击败运镖者，掉落金币，击败者获得破损的镖车</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "5、破损的镖车可以继续押送获得奖励</t>";
		case 600000041:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "押送镖车（押金：</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "）</t>";
		case 600000042:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "押送镖车（押金：</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "）</t>";
		case 600000043:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "押送镖车（押金：</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "）</t>";

		case 600000044:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "押送镖车（押金：</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "）</t>";
		case 600000045:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "押送镖车（押金：</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "）</t>";
		case 600000046:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "押送镖车（押金：</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "）</t>";

		case 600000047:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "押送镖车（押金：</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "）</t>";
		case 600000048:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "押送镖车（押金：</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "）</t>";
		case 600000049:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "押送镖车（押金：</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "）</t>";

		case 600000050:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "押送镖车（押金：</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "）</t>";
		case 600000051:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "押送镖车（押金：</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "）</t>";
		case 600000052:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "押送镖车（押金：</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "）</t>";

		case 600000053:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "押送镖车（押金：</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "）</t>";
		case 600000054:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "押送镖车（押金：</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "）</t>";
		case 600000055:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "押送镖车（押金：</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "）</t>";
			//-------------------押镖活动----------------
			//------------------钓鱼活动-------------
		case 600000056:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "兑换称号[渔·清溪渔童]</t>";
		case 600000057:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "兑换称号[渔·三溪渔子]</t>";
		case 600000058:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "兑换称号[渔·五湖渔郎]</t>";
		case 600000059:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "兑换称号[渔·七江渔叟]</t>";
		case 600000060:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "兑换称号[渔·孤舟渔隐]</t>";
		case 600000061:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "兑换称号[渔·临江独钓]</t>";
		case 600000062:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "兑换称号[渔·临江仙]</t>";
		case 600000063:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "兑换称号[渔·垂天下]</t>";
		case 600000064:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "兑换称号[渔·隐士]</t>";
		case 600000065:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "兑换称号[渔·无名]</t>";

		case 600000066:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "上缴[金枪鱼]</t>";
		case 600000067:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "上缴[鲈鱼]</t>";
		case 600000068:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "上缴[鳐鱼]</t>";
		case 600000069:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "上缴[赤焰鳟]</t>";
		case 600000070:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "上缴[金鳞鲤鱼]</t>";

		case 600000071:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "兑换鱼饵</t>";
			//---------------------聆经悟道--------------------------------
		case 600000072:return $Get_Dialog_GeShi[80002] @ "<t>可使用此道具前往</t>" @ "<l i='" @ "810100100 32.0509 57.8391 137.561' t='path'/>" @ $Get_Dialog_GeShi[80002] @ "附近，寻找传功长老兑换参悟仙经的时间</t>";
		case 600000073:	 //押镖活动介绍
			return $Get_Dialog_GeShi[80002] @ /*默认为白色格式（最外层嵌套）*/
				$Get_Dialog_GeShi[80000] @ "◆聆经悟道◆</t>" @
				$Get_Dialog_GeShi[80001] @ "◆开放时间：</t>" @ $Get_Dialog_GeShi[80003] @ "00:00-21:00 21:30-23:59 </t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆需要等级：</t><t>30级</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆活动奖励：</t><t>大量经验</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆参与规则：</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "1、参悟【蓬莱道经】，进入打坐状态，每隔10秒获得一次经验</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "2、参悟【蓬莱仙经】，进入打坐状态，每隔5秒获得一次经验</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "3、参悟【蓬莱仙经】，需上缴【悟经牌】</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "4、每块【悟经牌】可兑换一小时参悟仙经的时间，每人每天限兑换3次</t><b/>" @
				$Get_Dialog_GeShi[80004] @ "小提示：【蓬莱仙经】总共只有8处，可在聆经童子处，使用元神参悟，元神参悟不受限制！</t>";
		case 600000074:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "兑换参悟仙经时间</t>";
		case 600000075:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "开启元神悟道</t>";
		case 600000076:	 //押镖活动介绍
			return $Get_Dialog_GeShi[80002] @ /*默认为白色格式（最外层嵌套）*/
				$Get_Dialog_GeShi[80000] @ "◆元神悟道◆</t>" @
				$Get_Dialog_GeShi[80001] @ "◆参与规则</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "1、使用【悟经牌】兑换时间后，可在此处开启元神悟道</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "2、元神悟道，不受参悟仙经的8人限制</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "3、元神悟道，可以前往任意地图、副本，但是不可离线</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "4、开启元神悟道需要扣除一定数量的元宝，根据当前的悟道时间而定</t>";
			//-----------------------------首座论经--------------
		case 600000077:
			return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "领取【论经】奖励</t>";
		case 600000078:
			%Act0 = GetAct(GetPlayer(),4024,0) * 1;
			%Act1 = GetAct(GetPlayer(),4024,1) * 1;
			if (%Act0  + %Act1 > 0)
				return
				$Get_Dialog_GeShi[31401] @ "今日总共答题数：</t>" @ $Get_Dialog_GeShi[31403] @  %Act0 + %Act1 @ "</t><b/>" @
				$Get_Dialog_GeShi[31401] @ "其中答对的数量：</t>" @ $Get_Dialog_GeShi[31403] @  %Act0 @ "</t>";
			else
				return "<t>您已领取奖励，或者未参加活动。</t>";
		case 600000079:
			return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "领取奖励</t>";
			//------------------------首座论经-----------------
			//------------------------冰火试炼-----------------
		case 600000080://任务介绍
			if (GetSrc(GetPlayer(),40) == 0) %Text[1] = "<t>寒冰之魂：当前 0/1 次</t><b/>"; else %Text[1] = "<t>寒冰之魂：</t>" @ $Get_Dialog_GeShi[31403] @ "已完成</t><b/>";
			if (GetSrc(GetPlayer(),41) == 0) %Text[2] = "<t>烈火之炎：当前 0/1 次</t><b/>"; else %Text[2] = "<t>烈火之炎：</t>" @ $Get_Dialog_GeShi[31403] @ "已完成</t><b/>";
			if (GetSrc(GetPlayer(),42) == 0) %Text[3] = "<t>铲除蟾妖：当前 0/1 次</t><b/>"; else %Text[3] = "<t>铲除蟾妖：</t>" @ $Get_Dialog_GeShi[31403] @ "已完成</t><b/>";
			if (GetSrc(GetPlayer(),43) == 0) %Text[4] = "<t>铲除妖蟒：当前 0/1 次</t><b/>"; else %Text[4] = "<t>铲除妖蟒：</t>" @ $Get_Dialog_GeShi[31403] @ "已完成</t><b/>";
			%Num = 0;
			for (%s = 44; %s <=48; %s++)
			{
				if (GetSrc(GetPlayer(),%s) == 1)
					%Num++;
			}
			if (%Num < 5)
				%Text[5] = "<t>乔装采药：当前 </t>" @ %Num @ "<t>/5 次</t><b/>";
			else
				%Text[5] = "<t>乔装采药：</t>" @ $Get_Dialog_GeShi[31403] @ "已完成</t><b/>";

			%Num = 0;
			for (%s = 50; %s <=54; %s++)
			{
				if (GetSrc(GetPlayer(),%s) == 1)
					%Num++;
			}
			if (%Num < 5)
				%Text[6] = "<t>冰火之珠：当前 </t>" @ %Num @ "<t>/5 次</t><b/>";
			else
				%Text[6] = "<t>冰火之珠：</t>" @ $Get_Dialog_GeShi[31403] @ "已完成</t><b/>";
			if (GetSrc(GetPlayer(),56) == 0) %Text[7] = "<t>降妖除魔：当前 0/1 次</t>"; else %Text[7] = "<t>降妖除魔：</t>" @ $Get_Dialog_GeShi[31403] @ "已完成</t>";
			%Txt = $Get_Dialog_GeShi[31426] @ "今日试炼任务完成度</t><b/>";
			for (%i = 1; %i <= 7; %i++)
			{
				%Txt = %Txt @ "<t> ★ </t>" @ %Text[%i];
			}
			return %Txt;
		case 600000081:return $Icon[19] @ $Get_Dialog_GeShi[31496] @ "每日-[" @ getplayer().getlevel() @ "] 寒冰之魂（接受）</t>";
		case 600000082:return $Icon[19] @ $Get_Dialog_GeShi[31496] @ "每日-[" @ getplayer().getlevel() @ "] 烈火之炎（接受）</t>";
		case 600000083:return $Icon[19] @ $Get_Dialog_GeShi[31496] @ "每日-[" @ getplayer().getlevel() @ "] 铲除蟾妖（接受）</t>";
		case 600000084:return $Icon[19] @ $Get_Dialog_GeShi[31496] @ "每日-[" @ getplayer().getlevel() @ "] 铲除妖蟒（接受）</t>";
		case 600000085:return $Icon[19] @ $Get_Dialog_GeShi[31496] @ "每日-[" @ getplayer().getlevel() @ "] 乔装采药（接受）</t>";
		case 600000086:return $Icon[19] @ $Get_Dialog_GeShi[31496] @ "每日-[" @ getplayer().getlevel() @ "] 冰火之珠（接受）</t>";
		case 600000087:return $Icon[19] @ $Get_Dialog_GeShi[31496] @ "每日-[" @ getplayer().getlevel() @ "] 降妖除魔（接受）</t>";
			//------------------------冰火试炼-----------------
			//-----------------------星魂对话------------------
		case 600000088:
			%Act0 = GetAct(GetPlayer(),4091,0) * 1;
			%Act1 = GetAct(GetPlayer(),4091,1) * 1;
			switch (%Act0)
			{
				case 0:	%BenMing = $Get_Dialog_GeShi[31401] @ "白色本命星</t>";
				case 1:	%BenMing = $Get_Dialog_GeShi[31401] @ "白色本命星</t>";
				case 2:	%BenMing = $Get_Dialog_GeShi[31403] @ "绿色本命星</t>";
				case 3:	%BenMing = $Get_Dialog_GeShi[31402] @ "蓝色本命星</t>";
				case 4:	%BenMing = $Get_Dialog_GeShi[31409] @ "紫色本命星</t>";
				case 5:	%BenMing = $Get_Dialog_GeShi[31421] @ "橙色本命星</t>";
			}
			return
				$Get_Dialog_GeShi[31401] @ "当前本命星：</t>" @ $Get_Dialog_GeShi[31403] @  %BenMing @ "</t><b/>" @
				$Get_Dialog_GeShi[31401] @ "本命星在时空裂痕中将获得高额经验加成</t><b/>" @
				$Get_Dialog_GeShi[31401] @ "每天进入时空裂痕时免费刷新一次星级</t><b/>" @
				$Get_Dialog_GeShi[31401] @ "白色</t>" @ "<t>星级：1倍经验加成</t><b/>" @
				$Get_Dialog_GeShi[31403] @ "绿色</t>" @ "<t>星级：2倍经验加成</t><b/>" @
				$Get_Dialog_GeShi[31402] @ "蓝色</t>" @ "<t>星级：3倍经验加成</t><b/>" @
				$Get_Dialog_GeShi[31409] @ "紫色</t>" @ "<t>星级：4倍经验加成</t><b/>" @
				$Get_Dialog_GeShi[31421] @ "橙色</t>" @ "<t>星级：5倍经验加成</t>";
		case 600000089:
			return $Icon[5] @ "<t>提升本命星魂</t>";
		case 600000090:
			%Act1 = GetAct(%Player,4091,1);
			switch (%Act1)
			{
				case 0:	%BenMing = $Get_Dialog_GeShi[31401] @ "白色本命星</t>";
				case 1:	%BenMing = $Get_Dialog_GeShi[31401] @ "白色本命星</t>";
				case 2:	%BenMing = $Get_Dialog_GeShi[31403] @ "绿色本命星</t>";
				case 3:	%BenMing = $Get_Dialog_GeShi[31402] @ "蓝色本命星</t>";
				case 4:	%BenMing = $Get_Dialog_GeShi[31409] @ "紫色本命星</t>";
				case 5:	%BenMing = $Get_Dialog_GeShi[31421] @ "橙色本命星</t>";
			}
			return $Icon[5] @ "<t>设置成今日最高本命</t>" @ %BenMing;
			//-------------------------------------------------
			//-------------------------血魔封印阵--------------
		case 600000091:
			return $Get_Dialog_GeShi[80002] @ /*默认为白色格式（最外层嵌套）*/
				$Get_Dialog_GeShi[80000] @ "◆血魔封印阵◆</t>" @
				$Get_Dialog_GeShi[80001] @ "◆开放时间：</t><t>全天 </t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆需要等级：</t><t>30级</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆建议人数：</t><t>6 人</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆活动奖励：</t><t>大量经验</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆参与规则：</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "1、每人每天可参与一次</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "2、副本一共分6波，前五波为20只精英怪加1只精英统领,第六波为首领关卡</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "3、副本开启后，怪物处于封印状态,每间隔15秒，将会有一只怪物解除封印</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "4、解除封印状态的怪物，击败后额外获得100%经验奖励</t><b/>" @
				$Get_Dialog_GeShi[80004] @ "小提示：可以选择提前解除封印来节约时间哦！</t>";
		case 600000092:
			return $Icon[10] @ $Get_Dialog_GeShi[80002] @ "进入副本</t>";
		case 600000093:
			return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "开启副本</t>";
		case 600000094:
			return "<t>是否受够了等待的过程，可以选择让我帮你提前解开本波怪物的封印，解除封印后的怪物击败的经验奖励翻倍，每次解封需要</t>" @ $Get_Dialog_GeShi[31403] @ "200</t>" @ "<t>元宝</t>";
		case 600000095:
			return $Icon[5] @ "<t>解除封印</t>";
		case 600000096:
			return "<t>本次解封需要</t>" @ $Get_Dialog_GeShi[31403] @ "200</t>" @ "<t>元宝，是否确定解封</t>";
		case 600000097:
			return $Icon[5] @ "<t>确定</t>";
			//-------------------------------------------------
			//-----------------------------黄金宝藏-------------------
		case 600000098:
			return $Get_Dialog_GeShi[80002] @ /*默认为白色格式（最外层嵌套）*/
				$Get_Dialog_GeShi[80000] @ "◆黄金宝藏◆</t>" @
				$Get_Dialog_GeShi[80001] @ "◆开放时间：</t><t>全天 </t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆需要等级：</t><t>35级</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆建议人数：</t><t>单人</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆活动奖励：</t><t>大量金币</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆参与规则：</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "1、每次进入宝藏需要一枚</t>" @ "<l i='105109341 ' t='itemid'/>" @ "<b/>" @
				$Get_Dialog_GeShi[80002] @ "2、根据系统提示进入对应的传送门</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "3、副本内一共4波挑战，每波刷怪20个</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "4、每个怪物都会掉落大量金币</t><b/>" @
				$Get_Dialog_GeShi[80004] @ "小提示1：如果踏错传送门，被机关秒杀，本次副本即失败！</t><b/>" @
				$Get_Dialog_GeShi[80004] @ "小提示2：黄金宝藏的怪物极其强大，建议逐一击败！</t>";
		case 600000099:
			return $Icon[10] @ "<t>进入副本</t>";

			//-------------------------------------------------
			//-----------------------------刀剑神域-------------------
		case 600000100:
			return $Get_Dialog_GeShi[80002] @ /*默认为白色格式（最外层嵌套）*/
				$Get_Dialog_GeShi[80000] @ "◆刀剑神域◆</t>" @
				$Get_Dialog_GeShi[80001] @ "◆开放时间：</t>" @ $Get_Dialog_GeShi[80003] @ "21:00 </t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆需要等级：</t><t>50级</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆建议人数：</t><t>单人</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆活动奖励：</t><t>大量经验</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆参与规则：</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "1、刀剑神域内，分两大阵营，生死角逐</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "2、进入副本后，随机分配加入一方阵营</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "3、完成10次试炼任务，可获得经验奖励</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "4、击败敌对阵营，获得经验奖励</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "5、战场结束时，将根据每个人的战斗时长和击败战绩给予奖励</t><b/>" @
				$Get_Dialog_GeShi[80004] @ "小提示：提前退出战场，无法获得最后的奖励</t>";
		case 600000101:
			return $Icon[10] @ "<t>进入副本</t>";
			//-------------------------------------------------
			//-----------------------------灵脉商店-------------------
		case 600000102:
			%Text = "<t>挖掘</t>" @ $Get_Dialog_GeShi[31421] @ " 灵石矿脉</t>" @ "<t>，每次可获得</t>" @ GetItemName(GetOne_HeZuiChu_ZaKuang(getplayer(),1),1) @ "<t>一个，且有60%几率额外获得</t>" @ GetItemName(105109001,1) @ "<t>等珍惜道具，开启</t>" @ GetItemName(105109001,1) @ "<t>有机会获得以下珍惜物品：</t><b/>";
			%Player.ClearMissionItem(10050);
			%Player.AddItemToMission(10050,1,113050002,1);
			%Player.AddItemToMission(10050,1,105090503,1);
			%Player.AddItemToMission(10050,1,105090603,1);
			%Player.AddItemToMission(10050,1,105109031,1);
			%Player.AddItemToMission(10050,1,105109061,1);
			%Player.AddItemToMission(10050,1,116060105,1);
			%Player.AddItemToMission(10050,1,116060106,1);
			%Player.AddItemToMission(10050,1,116060107,1);
			%Player.AddItemToMission(10050,1,116060108,1);
			%Player.AddItemToMission(10050,1,116080005,1);
			%Player.AddItemToMission(10050,1,116080006,1);
			%Player.AddItemToMission(10050,1,116080007,1);
			%Player.AddItemToMission(10050,1,116080008,1);
			%Player.AddItemToMission(10050,1,116060002,1);
			%Player.AddItemToMission(10050,1,105028011,1);
			return $Get_Dialog_GeShi[80002] @ %Text @ "</t>" @ GetFixedMissionItemText(10050);
		case 600000103:
			%Text = "<t>挖掘</t>" @ $Get_Dialog_GeShi[31421] @ " 神石矿脉</t>" @ "<t>，每次可获得</t>" @ GetItemName(GetOne_HeZuiChu_KuangDing(getplayer(),1),1) @ "<t>一个，且有60%几率额外获得</t>" @ GetItemName(105109021,1) @ "<t>等珍惜道具，开启</t>" @ GetItemName(105109021,1) @ "<t>有机会获得以下珍惜物品：</t><b/>";
			%Player.ClearMissionItem(10050);
			%Player.AddItemToMission(10050,1,116060107,1);
			%Player.AddItemToMission(10050,1,116060108,1);
			%Player.AddItemToMission(10050,1,116060109,1);
			%Player.AddItemToMission(10050,1,116060110,1);
			%Player.AddItemToMission(10050,1,116080007,1);
			%Player.AddItemToMission(10050,1,116080008,1);
			%Player.AddItemToMission(10050,1,116080009,1);
			%Player.AddItemToMission(10050,1,116080010,1);
			%Player.AddItemToMission(10050,1,116060003,1);
			%Player.AddItemToMission(10050,1,116070002,1);
			%Player.AddItemToMission(10050,1,105105514,1);
			%Player.AddItemToMission(10050,1,105105524,1);
			%Player.AddItemToMission(10050,1,105290025,1);
			%Player.AddItemToMission(10050,1,105290035,1);
			%Player.AddItemToMission(10050,1,105180072,1);
			%Player.AddItemToMission(10050,1,105180092,1);
			%Player.AddItemToMission(10050,1,105180152,1);
			%Player.AddItemToMission(10050,1,105180073,1);
			%Player.AddItemToMission(10050,1,105180093,1);
			%Player.AddItemToMission(10050,1,105180153,1);
			%Player.AddItemToMission(10050,1,105180074,1);
			%Player.AddItemToMission(10050,1,105180094,1);
			%Player.AddItemToMission(10050,1,105180154,1);
			%Player.AddItemToMission(10050,1,105105304,1);
			%Player.AddItemToMission(10050,1,105105305,1);
			%Player.AddItemToMission(10050,1,105028021,1);

			return $Get_Dialog_GeShi[80002] @ %Text @ "</t>" @ GetFixedMissionItemText(10050);
			//-----------------------------灵脉商店-------------------
			//-----------------------------云罗镜-------------------
		case 600000104:
			if (getplayer().GetOrgID() > 0)
				return $Icon[10] @  "<t>传送云罗镜（帮派副本）</t>";
			else
				return $Icon[10] @ $Get_Dialog_GeShi[31407] @ "<t>传送云罗镜（帮派副本）</t>";
		case 600000105:
			return $Get_Dialog_GeShi[80002] @ /*默认为白色格式（最外层嵌套）*/
				$Get_Dialog_GeShi[80000] @ "◆云罗镜◆</t>" @
				$Get_Dialog_GeShi[80001] @ "◆建议人数：</t><t>帮派集体参与</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆活动奖励：</t><t>大量经验、珍惜道具</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆参与规则：</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "1、由帮主进行召唤</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "2、同一个宝藏只能每人每天只能获取一次</t><b/>" @
				$Get_Dialog_GeShi[80004] @ "小提示：推荐优先击败左右护法、长老，可降低云罗教主的挑战难度。</t>";
		case 600000106:
			if (getplayer().GetOrgMemberLevel(1) < 6)
				return $Icon[5] @ $Get_Dialog_GeShi[31407] @ "<t>召唤【云罗教主】</t>";
			else
				return $Icon[5]  @ "<t>召唤【云罗教主】</t>";
		case 600000107:
			return $Get_Dialog_GeShi[80002] @ /*默认为白色格式（最外层嵌套）*/
				$Get_Dialog_GeShi[80000] @ "倍率说明：</t>";
		case 600000108:
			return $Icon[5]  @ "<t>召唤【刷新倍数】</t>";
			//-----------------------------云罗镜-------------------
		
		//道经
		case 600000110:
			%NeedYB2 = SpecialItem_DaoJing_GetYuanBaoExpend(%Player, 2);
			%NeedYB3 = SpecialItem_DaoJing_GetYuanBaoExpend(%Player, 3);
			return $Get_Dialog_GeShi[80002] @ /*默认为白色格式（最外层嵌套）*/
				$Get_Dialog_GeShi[80000] @ "◆道经◆</t>" @
				$Get_Dialog_GeShi[80001] @ "◆免费使用道经:</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "<t>每</t>"@ $Get_Dialog_GeShi[80006] @"6小时</t><t>使用一次，有机率获得</t>"@ $Get_Dialog_GeShi[80006] @"双倍</t><t>经验。</t><b/>"@
				$Get_Dialog_GeShi[80001] @ "◆花费少量元宝使用道经:</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "<t>每天</t>"@ $Get_Dialog_GeShi[80006] @"第一次</t><t>使用消耗</t>"@ $Get_Dialog_GeShi[80006] @%NeedYB2@ "</t><t>元宝，有机率获得</t>"@ $Get_Dialog_GeShi[80006] @"双倍</t><t>经验，使用次数越多消耗的元宝越多，每天</t>"@ $Get_Dialog_GeShi[80006] @"0点</t><t>重置次数。</t><b/>"@
				$Get_Dialog_GeShi[80001] @ "◆花费大量元宝使用道经:</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "<t>每天</t>"@ $Get_Dialog_GeShi[80006] @"第一次</t><t>使用消耗</t>"@ $Get_Dialog_GeShi[80006] @%NeedYB3@ "</t><t>元宝，必然获得</t>"@ $Get_Dialog_GeShi[80006] @"双倍</t><t>经验，使用次数越多消耗的元宝越多，每天</t>"@ $Get_Dialog_GeShi[80006] @"0点</t><t>重置次数。</t><b/>"@
				$Get_Dialog_GeShi[80001] @ "◆今日已付费使用: </t>" @
				$Get_Dialog_GeShi[80002] @ GetAct(%Player,4300,0)*1 @"次</t>";
				
		
		case 600000111: return $Icon[5]  @ "<t>免费使用</t>"@ $Get_Dialog_GeShi[80006] @"(每6小时一次)</t>";
		case 600000112: return $Icon[5]  @ "<t>花费"@ SpecialItem_DaoJing_GetYuanBaoExpend(%Player, 2) @"元宝使用</t>"@ $Get_Dialog_GeShi[80006] @"(几率翻倍)</t>";
		case 600000113: return $Icon[5]  @ "<t>花费"@ SpecialItem_DaoJing_GetYuanBaoExpend(%Player, 3) @"元宝使用</t>"@ $Get_Dialog_GeShi[80006] @"(必然翻倍)</t>";
		case 600000114:return "<t>【道经】相差功能已关闭，重启时间请关注游戏更新公告。</t>";
		case 600000115:return "<t>【道经】每6小时只能免费使用一次。</t>";
		case 600000116:return "<t>你的元宝不足，无法付费使用【道经】</t>";
		case 600000117:return "<t>付费使用【道经】，每天最多使用20次，请大佬明天再用吧！</t>";

			//-----------------------------封神秘境-------------------
		case 600000118:
			return $Get_Dialog_GeShi[80002] @ /*默认为白色格式（最外层嵌套）*/
				$Get_Dialog_GeShi[80000] @ "◆封神秘境◆</t>" @
				$Get_Dialog_GeShi[80001] @ "◆开放时间：</t><t>全天 </t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆需要等级：</t><t>35级</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆建议人数：</t><t>3人以上</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆活动奖励：</t><t>紫色装备</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "◆参与规则：</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "1、每次每天可进入一次</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "2、副本任意怪物均有几率掉落紫色装备</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "3、精英怪物掉落几率翻倍，首领怪物必定掉落紫色装备</t><b/>" @
				$Get_Dialog_GeShi[80004] @ "小提示1：掉落装备的等级对应副本玩家平均等级！</t><b/>" @
				$Get_Dialog_GeShi[80004] @ "小提示2：帮派成员玩家击败首领后额外获得100点帮派活跃！</t>";
		case 600000119:
			return $Icon[5]  @ "<t>开启挑战</t>";
		case 600000120:
			return $Icon[5]  @ "<t>挑战秘境</t>";
			//--------------------------------------------------------
		
	}
}
function showGodStoneInvariantInfo()
{
	%color= "<t m='1' f='宋体' n='14' c='0xffffffff' b='0'>";
	%str  = %color @ "造化神石合成说明：</t><b/>";
	%str  = %str @ %color @"1.同等级的造化神石可合成更高一级的神石。</t><b/>";
	%str  = %str @ %color @"2.福缘值越高，合成的成功率就越高。</t><b/>";
	%str  = %str @ %color @"3.使用五个造化神石合成，成功率100%。</t><b/>";
	%str  = %str @ %color @"4.低于5级的造化神石无法用于合成。</t>";
	KLJGodStoneGui_TipsInfo.setcontent(%str);
}

