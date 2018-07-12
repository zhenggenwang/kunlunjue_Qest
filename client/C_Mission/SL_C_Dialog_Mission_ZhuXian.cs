//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字

//客户端任务对话，【主线任务】
//==================================================================================
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
//==================================================================================

//■■■■■■■■■■■■■■蓬莱新手村■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■■■望仙谷任务■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■■■苍山雪海任务■■■■■■■■■■■■■■■■
//==================================================================================

//■■■■■■■■■■■■■■蓬莱新手村■■■■■■■■■■■■■■■■
function Mission10001Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		//if ( %Player.GetSex( ) == 1 )//男
		//{
		//	%Talk = "<t>瑞兽麒麟</t>";
		//}
		//else %Talk = "<t>烈焰火凤</t>";
		case 10001:	return "<t>上前与杨子石交谈，了解前因后果</t><b/>";
		case 10002:	return "<t>我是谁？</t><b/><t>发生了什么？</t><b/><t>为什么我会在这？</t><b/>";
		case 10005:	return "<t>此岛与我蓬莱仙山有千里之遥，唔，身无道行，流落至此，若无我等前来，你也够惨的…………</t><b/>"@
			"<t>瑞兽麒麟(烈焰火凤)会载你到山脚，你先找蓬逢大哥，回头我们就来</t><b/>";

		case 412: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "在下头昏脑胀，往日一片空白……这是</t>";
		case 413: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "这话？从何说起！</t>";
		case 414: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "呃，你看我怎么看也不像是有道行的人</t>";
		case 415: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "总感觉哪里不对！</t>";
		case 416: return $Icon[ 4 ] @ $Get_Dialog_GeShi[ 31495 ] @ "离开小岛！</t>";

		case 511: return "<t>少侠果然吉人自有天相，我们已等你多时了，不知你是否还记得是怎么来到这里的？</t><b/><b/><b/><b/>";
		case 512: return "<t>昔日小师妹在昆仑城历练，偶遇奇人莫前辈说有位英雄少年将出现在这，而你鬓发高耸，头角峥嵘，直插天际…………正是应了卦理之人。</t><b/><b/>";
		case 513: return "<t>简单说就是天降贪狼，荡平妖孽啦，你看九州山河，妖魔横行，我等修道之人上体天心，下悯世人，掌门联合各界修道人士，决定挑根骨上乘，传授仙法，以解救苍生，那莫前辈说你是那其中之一</t><b/>";
		case 514: return "<t>少侠，不要担心，如今时值年少，你根骨奇佳，只需时日并可一发冲天…………</t><b/><b/><b/><b/>";
		case 515:
			closeHelpDirect1_4(10);
			return "<t>此岛与我蓬莱仙山有千里之遥，唔，身无道行，流落至此，若无我等前来，你也够惨的…………</t><b/>"@
				"<t>瑞兽麒麟会载你到山脚，你先找蓬逢大哥，回头我们就来</t><b/>";
		case 516:
			closeHelpDirect1_4(10);
			return "<t>此岛与我蓬莱仙山有千里之遥，唔，身无道行，流落至此，若无我等前来，你也够惨的…………</t><b/>"@
				"<t>烈焰火凤会载你到山脚，你先找蓬逢大哥，回头我们就来</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10002Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>寻找蓬逢</t><b/>";
		case 10002:	return "<t>林姑娘交代你找到蓬逢！</t><b/>";
		case 10005:	return "<t>待我收了这网鱼虾，带你回村。你若闲暇无事，边上有太多青灵螺，泛滥成灾了，你可帮忙清除下。</t><b/>";

		case 30001: return"<t>你就是小旒歆口中的少年英才？怎么看都有点……</t><b/><t>哎，之前林姑娘有留话</t><b/>";
		case 31001:
			return"<t>不敢当…林姑娘送我过来未曾有交代，不知......？</t><b/>";
	}
}
function Mission10011Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>击败青灵螺</t><b/>";
		case 10002:	return "<t>沿海岸边上有许多青灵螺，快去清除一些吧</t><b/>";
		case 10005:	return "<t>拳脚利落嘛，难怪林姑娘对你另眼相看，他日上得仙山潜心修炼，登堂入室为期不远！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10021Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>搜集一些海鲜</t><b/>";
		case 10002:	return "<t>沿海岸边的寻找一些海蚌给给铁狂人送去吧</t><b/>";
		case 10005:	return "<t>哎，往事不堪回首，挑选一件称手兵刃吧！</t><b/>";

		case 20001: return"<t>需知刚才只是拳脚肉搏，不是法门仙术，修道之人，必有一柄神兵利器随身，才能最大限度的发挥自身的实力。</t><b/>";
		case 21001: return"<t>哪里才能获得神兵利器呢？</t><b/>";

		case 20002: return"<t>少侠，眼下你身无道行，给你神兵也无法驾驭，反到受其累，你待会可去找村头的铁狂人，他会为你准备一柄称手的武器。</t><b/>";
		case 21002: return"<t>好，我这就去</t><b/>";

		case 20003: return"<t>莫急呀，码头那边礁石处有很多海蚌，味道鲜美之极，铁狂人就好这口，你可去弄点，总好过你两手空空……</t><b/>";
		case 21003: return"<t>此话在理</t><b/>";

		case 30001: return"<t>哟，这蚌子肉肥嫩，可是一道美味啊，配上青虾，瞧我这口水都要留出来了，哎，你要知往日在山上，想开荤难啊……</t><b/>";
		case 31001: return"<t>原来大叔也是修道之人</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10031Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>选择武器</t><b/>";
		case 10002:	return "<t>挑选一把自己喜欢的武器吧</t><b/><t>刀剑为通用武器，另一把为本职业武器</t><b/>";
		case 10005:	return "<t>这是我精心锻造而成，虽不是什么神兵，但也称手之极，挑选一件吧，莫要辜负我一片心血哦！</t><b/>"@ 
			$Get_Dialog_GeShi[ 31404 ] @"<t>注意：商店购买的装备成长率均为80%，通过生活、打怪获得的装备生成时40%-100%成长率均等随机！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10032Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>装备上武器</t><b/>";
		case 10002:	return "<t>赶快试试铁狂人给你的武器吧！</t><b/><t>可按B打开背包，鼠标移动到武器上右键点击即可装备武器哦！</t><b/>";
		case 10005:	return "<t>武器是否还称手？</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10041Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>寻仙访道问竺君</t><b/>";
		case 10002:	return "<t>找到燕竺君询问修行事宜！</t><b/>";
		case 10005:	return "<t>您也是志在做一名降妖除魔的侠士啊！</t><b/>";

		case 20001: return"<t>我刚在村头看到你的搏斗，须知方才拳脚肉搏都差点伤到自己，算不得修行法门，真正的仙法，地动天摇，日月无光……遥想大长老剑指魔渊，威慑四海…………说远了</t><b/>";
		case 21001: return"<t>哪里才能学到真正的仙法呢？</t><b/>";

		case 20002: return"<t>我们这只是山下小渔村而已，真正的法门还得上蓬莱仙山！不过村子里头 燕竺君 他大哥在蓬莱修仙，时长回来，你可向他了解了解</t><b/>";
		case 21002: return"<t>好的，我这就去</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10051Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>燕竺君传授技巧</t><b/>";
		case 10002:	return "<t>向燕竺君学习技能，并将技能拖入快捷栏</t><b/>";
		case 10005:	return "<t>这只是基础的招式，还是需要多加练习才能运用自如！</t><b/>";

		case 20001: return"<t>嘿，你也想入仙门啊，我跟你说，可难哦，我大哥就被选中进入蓬莱修炼，我也在努力，争取能进蓬莱修道，届时横扫四方……</t><b/>";
		case 21001: return"<t>咳咳，燕兄果然好志气，不知燕兄可有入仙门之法？</t><b/>";

		case 20002: return"<t>我大兄说只有将身体淬炼硬朗，打好基础，才能更进一步修行仙法！</t><b/>";
		case 21002: return"<t>那一般你如何淬炼身体呢？</t><b/>";

		case 20003: return"<t>来，这是我大兄教我的基础招式，你也学学，技多不压身！</t><b/>";
		case 21003: return"<t>多谢燕兄！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10061Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>实战击败螃蟹精</t><b/>";
		case 10002:	return "<t>去村口沙滩上击败螃蟹精来练练身手吧！顺道可吧收获来的海鲜送给林大嫂哦！</t><b/>";
		case 10005:	return "<t>这个东西我认得</t><b/>";

		case 20001: return"<t>怎么样？我大兄传授的战技厉害吧！这只是基础的招式，还是需要多加练习才能运用自如！</t><b/>";
		case 21001: return"<t>那燕兄平日里如何练习呢？</t><b/>";

		case 20002: return"<t>这个容易，你来时可见村头虾精蟹灵？我平日都拿来练手脚，还能收获好多海鲜呢，隔壁的林大嫂最喜欢吃这啦。</t><b/>";
		case 21002: return"<t>我也去试试！</t><b/>";

		case 30001: return"<t>呦！这么多新鲜的螃蟹！</t><b/>";
		case 31001: return"<t>林大嫂，我在海边抓螃蟹的时候捡到这个物件，你看看是什么</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10071Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>归还物件</t><b/>";
		case 10002:	return "<t>村长家就在前面的房子，你可前去问一问！</t><b/>";
		case 10005:	return "<t>这可是冯大哥的物件，我来将此归还的</t><b/>";

		case 20001: return"<t>此物乃是村长儿子冯仁随身携带之物</t><b/>";
		case 21001: return"<t>那冯仁大哥在何处，我将此物还给他</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10081Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>去找景霞想办法解决</t><b/>";
		case 10002:	return "<t>那真是有劳少侠了。村里就景霞最聪明了，少侠可去找她问问吧</t><b/>";
		case 10005:	return "<t>村长的儿子出海数日未归，怕是出了意外，可否去寻找</t><b/>";

		case 20001: return"<t>吾儿前几日出海捕鱼，已经有好几天没有回家了，此物你是如何得到的？</t><b/>";
		case 21001: return"<t>此乃我在海湾拾取到的</t><b/>";

		case 20002: return"<t>他这次出海长久未归，也无音讯，莫不是在海上出了什么意外</t><b/>";
		case 21002: return"<t>老村长可就这么一个儿子，这事我不能不管</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10091Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>采集龙蜒草喂给灵兽吃</t><b/>";
		case 10002:	return "<t>园中有许多龙蜒草，是灵兽最喜爱吃的，你可以采摘一些去给它</t><b/>";
		case 10005:	return "<t>好香的龙蜒草啊</t><b/>";

		case 20001: return"<t>这几日海上风大浪大，可不能贸然出海</t><b/>";
		case 21001: return"<t>那可如何是好</t><b/>";
		case 20002: return"<t>莫要着急，玲珑长老的近日跑来我的园中玩耍，你可去讨好灵兽，让它在你去海上寻人</t><b/>";
		case 21002: return"<t>那应该如何讨好灵兽呢</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10101Dialog( %Npc, %Player, %Mid, %Tid )
{
	if ( %Tid == 20001 || %Tid == 30001 )
		Get_Mission_Dialog_ZhiYinWed( %Player, %Mid );
	switch ( %Tid )
	{
		case 10001:	return "<t>乘坐灵兽去寻人</t><b/>";
		case 10002:	return "<t>那你快坐上来吧</t><b/>";
		case 10005:	return "<t>你就是冯仁大哥吗</t><b/>";

		case 20001: return"<t>谢谢你给我这么美味的食物</t><b/>";
		case 21001: return"<t>真的好通人性啊，可以带我去海上寻一个人回来吗？</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10111Dialog( %Npc, %Player, %Mid, %Tid )
{
	if ( %Tid == 20001 || %Tid == 30001 )
		Get_Mission_Dialog_ZhiYinWed( %Player, %Mid );
	switch ( %Tid )
	{
		case 10001:	return "<t>将冯仁带回渔村找村长</t><b/>";
		case 10002:	return "<t>那太好了，我们这就回去吧。</t><b/>";
		case 10005:	return "<t>那真是太好了，老夫真是感激不尽。</t><b/>";

		case 20001: return"<t>正是。前几日捕鱼，遇见一只巡海夜叉，将我的船打翻了，我逃难至此，现在还不知如何是好。</t><b/>";
		case 21001: return"<t>不用担心，我就是来救你的</t><b/>";

		case 30001: return"<t>少侠可将人找回来了</t><b/>";
		case 31001: return"<t>是的</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10121Dialog( %Npc, %Player, %Mid, %Tid )
{
	if ( %Tid == 20001 || %Tid == 30001 )
		Get_Mission_Dialog_ZhiYinWed( %Player, %Mid );
	switch ( %Tid )
	{
		case 10001:	return "<t>秘录悟道</t><b/>";
		case 10002:	return "<t>参悟秘录，看是否能有所领悟</t><b/>";
		case 10005:	return "<t>少侠悟性不错，登堂入室指日可待！</t><b/>";

		case 20001: return"<t>这是祖上传下的秘法，想必对少侠也略有所帮助，少侠可参悟参悟。</t><b/>";
		case 21001: return"<t>感激不尽！</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10131Dialog( %Npc, %Player, %Mid, %Tid )
{
	if ( %Tid == 20001 || %Tid == 30001 )
		Get_Mission_Dialog_ZhiYinWed( %Player, %Mid );
	switch ( %Tid )
	{
		case 10001:	return "<t>前往拜谢景霞</t><b/>";
		case 10002:	return "<t>此事也多亏了景霞，可否替老夫前去道一声谢</t><b/>";
		case 10005:	return "<t>村长的儿子已经找回来了，多谢景霞姐姐指点</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10141Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>采集蚕蛹</t><b/>";
		case 10002:	return "<t>道谢可不是光用嘴说说的，帮我去园中采集一些蚕蛹来吧</t><b/>";
		case 10005:	return "<t>少侠手脚利落，想必身手也不凡吧!</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10151Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>裁剪衣物</t><b/>";
		case 10002:	return "<t>你的衣物过于陈旧，你且穿上试试看。可看看是否合身！</t><b/>";
		case 10005:	return "<t>这新衣物居然这般的合身</t><b/>";

		case 20001: return"<t>短短时间，采得如此之多，你稍等下，为你缝制几件衣物。</t><b/>";
		case 21001: return"<t>好的</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10161Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>与冯芸道别</t><b/>";
		case 10002:	return "<t>明白了那就去找她吧</t><b/>";
		case 10005:	return "<t>这是我的一点小心意，还望少侠收下</t><b/>";

		case 20001: return"<t>果然佛靠金装，人呢要衣装，穿上这身行头，有点仙风道骨的样子了。</t><b/>";
		case 21001: return"<t>为何一定要穿上这衣服呢</t><b/>";

		case 20002: return"<t>冯芸想与你道个别，有个惊喜要送给你，可不能这么灰头土脸去见她呀</t><b/>";
		case 21002: return"<t>多谢景霞姐，我明白了</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10162Dialog( %Npc, %Player, %Mid, %Tid )
{
	if ( %Tid == 20001 || %Tid == 30001 )
		Get_Mission_Dialog_ZhiYinWed( %Player, %Mid );
	switch ( %Tid )
	{
		case 10001:	return "<t>前往寻找玲珑长老</t><b/>";
		case 10002:	return "<t>那就去后山药园找玲珑长老吧</t><b/>";
		case 10005:	return "<t>这位仙姑就是玲珑长老吧，在下情急之下冒犯了您的灵兽，还望海涵</t><b/>";

		case 20001: return"<t>多谢少侠出手相助，让我大哥化险为夷</t><b/>";
		case 21001: return"<t>哪里哪里，这都是应该的</t><b/>";

		case 20002: return"<t>我为你指引一人，在后山药园中养修，你可是骑她的灵兽啊</t><b/>";
		case 21002: return"<t>好的，我知道了</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10163Dialog( %Npc, %Player, %Mid, %Tid )
{
	if ( %Tid == 20001 || %Tid == 30001 )
		Get_Mission_Dialog_ZhiYinWed( %Player, %Mid );
	switch ( %Tid )
	{
		case 10001:	return "<t>驱赶鼠妖</t><b/>";
		case 10002:	return "<t>不对，只需将这些鼠妖赶出药园即可</t><b/>";
		case 10005:	return "<t>真是身手不凡啊，看来资质挺不错的，这是我一匹普通的坐骑，就送给你了</t><b/>";

		case 20001: return"<t>这倒无妨，我这灵兽极通人性，你若是心怀不轨，它也不会亲近你的</t><b/>";
		case 21001: return"<t>原来是这样</t><b/>";

		case 20001: return"<t>不错不错，我等修炼之人，最讲究的就是仁义之心。我看你着实有缘，不知是否想寻得修仙炼道的法门呢</t><b/>";
		case 21001: return"<t>真的吗？求之不得</t><b/>";

		case 20002: return"<t>这倒是简单，不过我要考一考你，最近药园中有一些鼠妖残食药草，你懂了吗</t><b/>";
		case 21002: return"<t>明白了，这下这就去将鼠妖铲除干净</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10171Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>前往山门</t><b/>";
		case 10002:	return "<t>这是我的令牌，你拿去找蓬莱的弟子，他自会明白。</t><b/>";
		case 10005:	return "<t>原来是玲珑长老引荐，真是难得啊。</t><b/>";

		case 30001: return"<t>站住，此乃蓬莱仙山，凡人止步</t><b/>";
		case 31001: return"<t>是玲珑长老让我来的，这是她的令牌</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10181Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>背诵门规</t><b/>";
		case 10002:	return "<t>无规矩不成方圆，了解蓬莱仙门的门规!</t><b/>";
		case 10005:	return "<t>如今还未到山门大开广收门徒之时，你虽有长老引荐，但我蓬莱仙山的规矩坏不得！</t><b/>";

		case 20001: return"<t>虽说是玲珑长老引荐的，但规矩我还得说明下，有些事切不可为！我等修道之人，理应上体天心下合人道，出门在外遇见不平定要出手相助，降妖除魔乃我等修道本分。</t><b/>";
		case 21001: return"<t>本该如此，在下定当谨记</t><b/>";

		case 20002: return"<t>外出修行时，切勿胡乱使用仙术伤人性命，一旦获得善恶值，角色被击败会有所损失，当然，平时被击败也会有所损失。所以一定要勤加修炼。</t><b/>";
		case 21002: return"<t>是的</t><b/>";

		case 20003: return $Get_Dialog_GeShi[31404] @"<t>装备来源：</t><b/>"@
			$Get_Dialog_GeShi[31401] @"<t>1、在昆仑城</t>" @ $Get_Dialog_GeShi[31403] @"<t>裁缝、剑师</t>"@ $Get_Dialog_GeShi[31401] @"<t>处可购买获得</t><b/>"@
			"<t>2、通过</t>" @ $Get_Dialog_GeShi[31403] @"<t>生活制造</t>"@ $Get_Dialog_GeShi[31401] @"<t>获得</t><b/>"@
			"<t>3、通过击败</t>" @ $Get_Dialog_GeShi[31403] @"<t>首领、精英、头目</t>"@ $Get_Dialog_GeShi[31401] @"<t>获得</t><b/>"@
			$Get_Dialog_GeShi[31404] @"<t>    神器来源：</t><b/>"@ $Get_Dialog_GeShi[31401] @ "<t>神器唯一获得途径就是挑战击败</t>" @ $Get_Dialog_GeShi[31403] @"<t>首领</t>"@ $Get_Dialog_GeShi[31401] @"<t>获得</t><b/>";
		case 21003: return"<t>明白</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10191Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>通过戒律使考核！</t><b/>";
		case 10002:	return "<t>在戒律使处完成基本考核。</t><b/>";
		case 10005:	return "<t>孺子可教!</t><b/>";
		case 431: return $Icon[ 4 ] @ $Get_Dialog_GeShi[ 31491 ] @ "1、生活打造</t>";
		case 432: return $Icon[ 4 ] @ $Get_Dialog_GeShi[ 31491 ] @ "2、怪物掉落</t>";
		case 433: return $Icon[ 4 ] @ $Get_Dialog_GeShi[ 31497 ] @ "3、有钱能使…………</t>";
		case 434: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "明白了</t>";
		case 435: return $Icon[4] @ $Get_Dialog_GeShi[31491] @ "1、白名玩家</t>";
		case 436: return $Icon[4] @ $Get_Dialog_GeShi[31497] @ "2、红名玩家</t>";
		case 437: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "明白了</t>";
		case 438: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "返回</t>";
		case 531: return "<t>现我来考考你一些基本的修门知识： </t><b/><t>装备可通过什么途径获得？</t><b/><t>以下哪种说法</t>"@ $Get_Dialog_GeShi[31406] @"<t>错误</t><b/>";
		case 532: return $Get_Dialog_GeShi[31406] @"<t>答题错误</t>"@ $Get_Dialog_GeShi[31401] @"<t>，生活打造是修行之路上必备一门手艺，紫装、顶级神器皆可生活打造获得！</t><b/>";
		case 533: return $Get_Dialog_GeShi[31406] @"<t>答题错误</t>"@ $Get_Dialog_GeShi[31401] @"<t>，野外怪物可掉落成品紫装，首领是唯一产出神器的途径！</t><b/>";
		case 534: return $Get_Dialog_GeShi[31403] @"<t>答题正确</t>"@ $Get_Dialog_GeShi[31401] @"<t>，装备神器只可通过生活、击败怪物获得！顶级神器只能通过击败首领获得！</t><b/>";
		case 535: return "<t>战斗规则：</t><b/><t>任何人被击败均有概率会掉落装备</t><b/><t>以下哪种情况角色被击败更容易掉落物品</t><b/>";
		case 536: return $Get_Dialog_GeShi[31406] @"<t>答题错误</t>"@ $Get_Dialog_GeShi[31401] @"<t>，白名的概率极低，善恶值红名会增加被击败损失的惩罚！</t><b/>";
		case 537: return $Get_Dialog_GeShi[31403] @"<t>答题正确</t>"@ $Get_Dialog_GeShi[31401] @"<t>，白名被击败有较低的概率会掉落物品装备，善恶值红名会增加被击败掉物装备损失的概率！</t><b/>";
		case 538: return $Get_Dialog_GeShi[31403] @"<t>      </t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10192Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>去见见大师兄</t><b/>";
		case 10002:	return "<t>初来蓬莱，去觐见下大师兄吧，看看大师兄有何安排，大师兄是个很随和的人。</t><b/>";
		case 10005:	return "<t>万师兄，在下初来蓬莱，还请多多关照！</t><b/>";
	}
}


function Mission10201Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>聆听大师兄教诲。</t><b/>";
		case 10002:	return "<t>听大师兄讲解修行之法！</t><b/>";
		case 10005:	return "<t>修行之路犹如逆水行舟，不进则退，切忌鲁莽行事！</t><b/>";

		case 20001: return"<t>少侠快快请起，莫要多礼，我蓬莱可没世间这些凡俗的。听玲珑长老说起过你，说你是个妙人，要知修道之人，一切得本分夯实基础，才可飞的更远！</t><b/>";
		case 21001: return"<t>多谢师兄指点，必谨记。</t><b/>";

		case 20002: return"<t>讲经长老时长在讲经台开坛讲经，你商师姐常年在哪帮衬，如有不懂可去问她。你初入师门，师兄我送你一妙物，可防护一时，哈哈妙物送妙人！</t><b/>";
		case 21002: return"<t>多谢师兄</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10211Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>寻找商师姐</t><b/>";
		case 10002:	return "<t>商师姐就在诵经台附近，你且过去找她吧！</t><b/>";
		case 10005:	return "<t>初入蓬莱，还请师姐今后多多关照！</t><b/>";
	}
}
function Mission10221Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>询问师姐</t><b/>";
		case 10002:	return "<t>你也可以参悟下蓬莱道经，看看是否有所收获</t><b/>";
		case 10005:	return "<t>你也可以感受一下</t><b/>";

		case 20001: return"<t>小师弟，莫客气，我蓬莱正统修仙，想必大师兄也告诫过你，夯实基础才是根本，切勿学习旁门左道之术伤了根基。</t><b/>";
		case 21001: return"<t>多谢师姐指点。</t><b/>";

		case 20002: return"<t>宁长老常年再此讲经，你平日得空可来聆经悟道，有益修行，前些天张源在此悟道引得霞光满天，他日成就不可限量！</t><b/>";
		case 21002: return"<t>张师兄好厉害！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}

function Mission10231Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>替师姐探察试炼禁地</t><b/>";
		case 10002:	return "<t>拿着商师姐的手令去找试炼守卫王知章吧！</t><b/>";
		case 10005:	return "<t>这是茹云师姐的手令</t><b/>";

		case 20001: return"<t>须知修行出了修还得行！最近试炼之地又不太平，我传你一法，拿我手令，前去找试炼守卫，替师姐进去查看一番。</t><b/>";
		case 21001: return"<t>多谢师姐！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10232Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>获得使者赠礼</t><b/>";
		case 10002:	return "<t>是茹云师姐喊你来探察的啊，嗯，想必有两下子，给你个护肩防身，往前走一路到尽头自然而然就到了，切忌切勿鲁莽，量力而行！</t><b/>";
		case 10005:	return "<t>多谢王师兄！</t><b/>";
	}
}
function Mission10241Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>进入试炼之地</t><b/>";
		case 10002:	return "<t>往前走一路到尽头就到了试炼禁地了！</t><b/>";
		case 10005:	return "<t>想必这里就是试炼之地了！此处灵气异常丰厚，难怪草木成精。这么多，快泛滥了，得除去一点。</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10251Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>击败灵菇小妖</t><b/>";
		case 10002:	return "<t>此处灵气异常丰厚，难怪草木成精。这么多，快泛滥了，得除去一点。</t><b/>";
		case 10005:	return "<t>去找叶天舒吧！去他那历练下</t><b/>";
		case 30001: return"<t>刚见你施法除妖，略有所生疏，想必是刚来蓬莱不久吧，以你的悟性，只要勤学多用，自然就能熟能生巧了。</t><b/>";
		case 31001: return"<t>多谢夸奖！</t><b/>";

		case 30001: return"<t>这灵菇性格过于温和，挑战性不大，你若有胆量，可深入点，寻到叶天舒，他那倒是有些挑战！</t><b/>";
		case 31001: return"<t>好的！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10261Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>寻找叶天舒</t><b/>";
		case 10002:	return "<t>寻找叶天舒，挑战一下厉害点的妖魔！</t><b/>";
		case 10005:	return "<t>你想挑战更高级怪物？</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10271Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>获取一柄利器</t><b/>";
		case 10002:	return "<t>可看到眼前树妖？莫要小瞧，他们枝干坚韧，寻常武器可伤不到他们，这柄利器是用他们树心做制，稍有克制之用，拿着，你可上前一试。</t><b/>";
		case 10005:	return "<t>这柄利器是否还称手？</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10281Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>击败树妖</t><b/>";
		case 10002:	return "<t>这柄利器是否还称手？量力而行，莫要被树妖伤着，切忌只有实战才能迅速提升你的能力！</t><b/>";
		case 10005:	return "<t>实战效果如何？</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10291Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>探察树妖源头</t><b/>";
		case 10002:	return "<t>最近这些妖怪越来越猖狂了，想必是有原因的！你仔细探察一番！</t><b/>";
		case 10005:	return "<t></t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10301Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>击败树妖之灵</t><b/>";
		case 10002:	return "<t>树妖之灵出现了，迅速击败他！</t><b/>";
		case 10005:	return "<t>可有线索？</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10311Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>禀报大师兄</t><b/>";
		case 10002:	return "<t>速去禀报大师兄，试炼禁地所遇异事</t><b/>";
		case 10005:	return "<t>试炼之地异常</t><b/>";
		case 20001: return"<t>可有线索？</t><b/>";
		case 21001: return"<t>叶师兄，深处出现了树妖之灵，师弟觉得此事必有蹊跷，特来禀报，望师兄定夺。</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10321Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>探察秘地</t><b/>";
		case 10002:	return "<t>去探察下是否有什么异常！</t><b/>";
		case 10005:	return "<t>如何？可有异常？</t><b/>";
		case 20001: return"<t>这本不该如此，哎，昔日蓬莱有一灵童，孕育在浮空岛之中，为天地所生，成长起来必然法力滔天，护佑天下太平，可惜被……所害，夺其造化</t><b/>";
		case 21001: return"<t>啊！还有这样的事？那后来呢？</t><b/>";

		case 20002: return"<t>灵童本是天地所孕育，得天地护佑，虽说一身法力尽失，被迫涅槃，但也不至于消散于这天地之间，……怕其归来之时找其复仇，更用秘法将灵童的一丝灵光镇压在某处，哎，掌门得知此事已太晚，此乃我蓬莱一大憾事</t><b/>";
		case 21002: return"<t>灵童好可伶哦！谁这么可恶啊？</t><b/>";

		case 20003: return"<t>哎，往事都过去了，随缘吧，你且去看下昔日灵童孕育之地，是否有什异常</t><b/>";
		case 21003: return"<t>好的</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10331Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>寻找神农长老</t><b/>";
		case 10002:	return "<t>寻找神龙长老，就说要前往秘地一探。去了你就明白了！</t><b/>";
		case 10005:	return "<t>走，一起进秘地一探吧！</t><b/>";

		case 20001: return"<t>如何？可有异常？</t><b/>";
		case 21001: return"<t>未发现异常，但灵气即为丰厚，感觉都要凝成晶石了！</t><b/>";

		case 30001: return"<t>这手令……你实力还是太弱了，确定要进去？</t><b/>";
		case 31001: return"<t>啊？去哪？</t><b/>";

		case 30002: return"<t>咦？青玄没对你说？嘿，又算计我老头子，算了算了，我护着你去探察下吧！</t><b/>";
		case 31002: return"<t>有劳长老了</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10341Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>秘地谜底</t><b/>";
		case 10002:	return "<t>秘地探谜底？</t><b/>";
		case 10005:	return "<t>唔，良才美玉啊，呵，玲珑从哪找来的如此少年！</t><b/>";
		case 418: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "进入密地</t>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10351Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>发生了什么？？</t><b/>";
		case 10002:	return "<t>我实力涨了好多？？</t><b/>";
		case 10005:	return "<t>那神兵乃我蓬莱七大神兵之一，你他日下山除魔卫道时自然有你的机缘，说不得能得到一柄神兵，一切尽在机缘</t><b/>";

		case 30001: return"<t>资质不错，日后定成大器。方才老夫带你进入蓬莱秘地试炼一番，你所感悟的乃先贤所设考验……</t><b/>";
		case 31001: return"<t>好真实啊，刚才那神兵真称手，不知何时能有一把</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10361Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>觐见掌门</t><b/>";
		case 10002:	return "<t>方才掌门传书召见你，你去吧！</t><b/>";
		case 10005:	return "<t>你终于来了</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10371Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>掌门勉励</t><b/>";
		case 10002:	return "<t>我等修道之人，应历劫而起！你修道时日虽短，但修为尚可，可下山历练一番。</t><b/>";
		case 10005:	return "<t>你如今修为尚可，本应让你再修炼一些时日，然山下妖魔鬼怪肆掠，时不待我，只能提前让你下山历练，对你修行也大有好处！下山前去你大师兄处，他会有所心得告知你！</t><b/>";
		case 30001: return"<t>上山有些时日了，资质上乘，道行精进，已经有点仙风道骨的派头了，这样你下山闯荡，我们也放心了。</t><b/>";
		case 31001: return"<t>这么快就要下山了吗？</t><b/>";

		case 30002: return"<t>痴儿，难道你还要在这里呆一辈子？九天浩土，任驰骋纵横，降妖除魔为民除害，才不负所学。</t><b/>";
		case 31002: return"<t>确实也是。</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10381Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>大师兄谏言</t><b/>";
		case 10002:	return "<t>去寻你大师兄准备下山事宜吧！</t><b/>";
		case 10005:	return "<t>对了，我已很久未下山走动，你雷师弟刚从山下回来，可向其讨教下！</t><b/>";

		case 30001: return"<t>这么快就要下山了？原来是掌门所安排，也好，下山历练好过于山上闭门修炼，山下险恶，师弟切要小心！不可鲁莽行事！此乃我昔日下山游练时所获披风，暂无他用，小师弟带着，对你略有所帮助！</t><b/>";
		case 31001: return"<t>多谢大师兄关照！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10391Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>寻找雷秋亭</t><b/>";
		case 10002:	return "<t>寻找雷师兄，讨教下山准备事宜</t><b/>";
		case 10005:	return "<t>丹药得时长准备着，救死扶伤保命必不可少哦！</t><b/>";

		case 30001: return"<t>小师弟也要下山历练了？哎我跟你说，山下可好玩了，特别是珍馐美酒，那味道啊简直没得说！</t><b/>";
		case 31001: return"<t>师兄，你们下山都是这么历练的吗？</t><b/>";

		case 30002: return"<t>此言差矣，嘘，莫要对外讲，我只是告诉你有哪些好玩的，对了，行侠仗义乃我修道之人本份，切莫做伤天害理之事，我这还有些丹药，拿着路上说不定用的着。</t><b/>";
		case 31002: return"<t>多谢师兄</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10401Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>寻找飞天仙子</t><b/>";
		case 10002:	return "<t>下山历练少不得各地奔波，你去找叶璇仙子，她会告诉你下山事宜！</t><b/>";
		case 10005:	return "<t>你要下山历练？</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10411Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>飞天遁地之术</t><b/>";
		case 10002:	return "<t>我等修仙之人，飞天遁地之术，排山倒海之力均有所长，</t><b/>";
		case 10005:	return "<t>往日蓬莱弟子下山历练均从望仙谷开始，你也从这开始吧！</t><b/>";

		case 30001: return"<t>记好，任何地方只要你找到我，我都能带你去任何地方，前提是我觉得你有那实力哟！不然我可不想看你白白送死。</t><b/>";
		case 31001: return"<t>飞天遁地之术吗！看起来好厉害！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10421Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>下山历练，千里之行始于足下！就从望仙谷开始吧！</t><b/>";
		case 10002:	return "<t>掌门交代山下妖兽肆掠，提前下山历练铲除妖魔，保一方平安也是一大善事！</t><b/>";
		case 10005:	return "<t>姑娘看你面露难色，是否有什么难处？</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
//■■■■■■■■■■■■■■蓬莱新手村■■■■■■■■■■■■■■■■

//■■■■■■■■■■■■■■望仙谷任务■■■■■■■■■■■■■■■■
function Mission10431Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>山阴处寻找3颗凝魂草。</t><b/>";
		case 10002:	return "<t>凝魂草喜阴，常生长在阴暗的枯木处，去山阴处找找，帮梁飞飞采集3颗凝魂草吧！</t><b/>";
		case 10005:	return "<t>多谢少侠出手相助。</t><b/>";

		case 20001: return"<t>可是从蓬莱仙山而来的仙人？</t><b/>";
		case 21001: return"<t>姑娘莫慌，我乃下山修行之人，看姑娘焦急之态，是否有难处？</t><b/>";
		case 20002: return"<t>村长梁伯昔日除妖所受旧疾复发了，需要救命药草，可是这里妖魔肆掠，愁死我了。</t><b/>";
		case 21002: return"<t>如今妖兽肆掠，生灵涂炭，我等修士岂能坐等闲，不知姑娘所需何药材，我可试着帮你取来。</t><b/>";

		case 30001: return"<t>仙人如此之快！果然还是仙门之人有法子，哎，也不知道怎么了，最近山中老树都出现变异，今后出门可得小心了！</t><b/>";
		case 31001: return"<t>这才出山门，就遇到树妖残魔，看来此处定有蹊跷！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10441Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>祝枝山大叔早上出来打柴，能帮我找下他现在在哪里吗？</t><b/>";
		case 10002:	return "<t>此地突逢异变，估计樵夫被困在附近，仔细找找。</t><b/>";
		case 10005:	return "<t>哎呀，今日山谷大变，枯树成精了吓死老夫了！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10451Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>少侠来的正好！此地老树成精，对我们樵夫都产生了威胁！能帮忙一起清除下感激不尽！</t><b/>";
		case 10002:	return "<t>峡谷内枯树成精，对来往的人造成莫大的威胁，帮助樵夫清除一些吧。</t><b/>";
		case 10005:	return "<t>少侠好身手，除掉树妖，来往都安全多了，哎，突逢异变，估计有大事要发生了！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10461Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>替祝枝山取柴火送往梁婆婆处。</t><b/>";
		case 10002:	return "<t>枯树老妖的树干经久耐烧，帮祝枝山取得一些送给行走不便的梁婆婆吧！</t><b/>";
		case 10005:	return "<t>哎呀，多谢少侠送来柴火。老妪感激不尽。</t><b/>";
		case 20001:	return "<t>我此次出来原本打柴给梁婆婆送去，现遇枯树成精，准备在此候着提醒往来商贩，这枯树老妖的树干经久耐烧，不知少侠是否可帮取些柴火送给梁婆婆去？</t><b/>";
		case 21001:	return "<t>好说好说！我这就去帮取些柴火送去！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10471Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>打一壶清凉井水，给梁隐送去。</t><b/>";
		case 10002:	return "<t>旁边一口深井，打一壶清水，顺路送给在溪边垂钓的梁隐。</t><b/>";
		case 10005:	return "<t>多谢少侠送来清水解渴，少侠可知这渔之学问？</t><b/>";

		case 20001:	return "<t>最近山里不安全，少侠若要历练，可先前往镇上打探打探，据说最近镇上来了好多能人异士，正在想法子驱魔呢！</t><b/>";
		case 21001:	return "<t>有这事，我得去看看，说不得可尽些微薄之力，不知此处里镇上还有多远？</t><b/>";
		case 20002:	return "<t>出了庭院沿着岔路一直前行就能看到了。你若要前往，顺带帮老身打一壶井水顺路稍给梁隐，他在溪边垂钓。</t><b/>";
		case 21002:	return "<t>力所能及毫无问题！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10481Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>学渔翁尝试垂钓，看看第一次钓鱼能钓上什么！</t><b/>";
		case 10002:	return "<t>装备上渔翁的鱼竿，垂钓一会，感悟下渔之乐。</t><b/>";
		case 10005:	return "<t>少侠悟性不错，要知你好多师兄师姐当年可是半天没钓起一条鱼呢！</t><b/>";
		case 20001:	return "<t>这垂钓啊，是个修身养性的好法子，你看，生老病死，枯木逢春都是一个轮回，修士逆天而上，习得排山倒海之术，炼得回魂造化之丹，必遭天妒，所以红尘历练，炼心也是很重要的，想必贵派掌门让你下山历练也有此意。</t><b/>";
		case 21001:	return "<t>老丈说的有理。不知老丈能否传授垂钓之秘？</t><b/>";
		case 20002:	return "<t>少侠且记，贪多必烂，这大千世界，类似渔之术还有很多，你现刚下山，渔之道未必适合你，老夫今日传你一小技，他日你历练多时对此小技仍有兴趣，来此老夫倾囊相授。</t><b/>";
		case 21002:	return "<t>多谢老丈！</t><b/>";
		case 20003:	return "<t>你且带上老夫的鱼竿，尝试下对准鱼群垂钓看看。</t><b/>";
		case 21003:	return "<t>这就试试！</t><b/>";

		case 30001:	return "<t>嗯，确实是可造之才，老夫也不耽误你，老夫这根鱼竿送你，留作信物，待你达到35级后，若有兴趣一直学习垂钓之术再来此处找我吧！</t><b/>";
		case 31001:	return "<t>多谢老丈！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10491Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>前往望仙镇，游历小镇一番。</t><b/>";
		case 10002:	return "<t>给望仙镇梁伯送去你刚钓起的大鲤鱼。体验下小镇的风情。</t><b/>";
		case 10005:	return "<t>最近天地异变，来了不少能人异士，少侠能出手相助，老夫代镇上三千人感激不尽！</t><b/>";

		case 20001:	return "<t>少侠是准备去镇上逛逛？也好，修行最后还是得行，你可顺道带上此条大鲤鱼送给镇上的梁伯，人老了，他就好这肥嫩的鲤鱼。</t><b/>";
		case 21001:	return "<t>多谢老丈！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10501Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>帮梁伯将鲤鱼送到他女儿婉儿处。</t><b/>";
		case 10002:	return "<t>这鱼虽味美，处理起来太麻烦，少侠若有空，可帮忙送到小女婉儿处！</t><b/>";
		case 10005:	return "<t>家父让您见笑了，他就好这一口肥嫩的鲤鱼，这镇上人人都知道，少侠也是前来助阵的修士？</t><b/>";

		case 20001:	return "<t>哎呀，少侠如此客气，还捎了这美味过来，一定是那渔翁告诉你的吧，我告诉你啊，这渔翁可不简单，自他来这后，这一片水域就未见凶兽过了。</t><b/>";
		case 21001:	return "<t>原来如此，难怪那渔翁有如此之秘术。</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10511Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>烹饪是离不开调料的调制。帮婉儿去买一份秘制调料</t><b/>";
		case 10002:	return "<t>去镇上杂货商店邢秋处买一份调料给婉儿送去。</t><b/>";
		case 10005:	return "<t>少侠好面生啊，是刚从外地而来的？ 这婉儿要的调料啊，可不比一般货色，也只有从我这能弄到</t><b/>";

		case 20001:	return "<t>少侠可知这鲤鱼如何烹饪才美味？这望仙谷水清澈见底，鱼儿清鲜滑嫩，配上美味调料，那简直让人欲罢不能！</t><b/>";
		case 21001:	return "<t>呃，有这么夸张？</t><b/>";
		case 20002:	return "<t>少侠可否能帮小女子去杂货商处买一份调料，稍后小女子替你呈上美味。</t><b/>";
		case 21002:	return "<t>这就去……</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10521Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>替邢秋找寻调制调料的材料。</t><b/>";
		case 10002:	return "<t>镇子的门口有一株老樟树，就是它的叶子，这仙草树边也有，需仔细找找！</t><b/>";
		case 10005:	return "<t>少侠好快，这下材料齐了，我给你调制一份密料。</t><b/>";

		case 20001:	return "<t>这秘制调料需镇子外的仙草，香樟树叶加上我独门秘方调制而成，我手里也没这些东西，少侠若急需调料，可帮我采集这些材料我帮你调制！</t><b/>";
		case 21001:	return "<t>你说的香樟我理解，这仙草…………</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10531Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>邢秋终调制出一份秘制调料，送回给婉儿吧。</t><b/>";
		case 10002:	return "<t>这包就是婉儿所需的秘制调料，去给她送去吧。</t><b/>";
		case 10005:	return "<t>多谢公子为小女子取的这秘制调料。</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10541Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>等待婉儿制作美味，商讨烹饪之技。</t><b/>";
		case 10002:	return "<t>少侠可知这烹饪，也是一道非常实用的生活技能？</t><b/>";
		case 10005:	return "<t>据说昆仑城的厨娘林魅儿昔日酿的一坛三碗不过冈，另好多侠士都悟道升级了呢！</t><b/>";

		case 30001:	return "<t>虽说修行之人餐风饮露，无需五谷杂粮之食，但少侠可知烹饪之技也是道哦。要知往日食神烹制而成的美味，我等凡夫俗子食用后都能瞬间悟道成就仙术，</t><b/>";
		case 31001:	return "<t>还有如此之秘？看来掌门所吩咐下山历练增长见闻真是必须的。</t><b/>";
		case 30002:	return "<t>少侠若闲暇时可去昆仑城的食娘讨教一番，据传她可是食神在外的唯一弟子哦！</t><b/>";
		case 31002:	return "<t>他日必要去讨教一番</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10551Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>替婉儿将刚做好的鱼跃龙门送给给村上村民</t><b/>";
		case 10002:	return "<t>此道鱼跃龙门色香味俱全，真不可小觑这小姑娘的手艺啊！给村民们都送一份去吧。</t><b/>";
		case 10005:	return "<t>婉儿又叫人送来美味了啊，多谢少侠！</t><b/>";

		case 20001:	return "<t>少侠请看，这道鱼跃龙门，做好了，少侠若有空可替我送给镇上村民一份</t><b/>";
		case 21001:	return "<t>这菜色香味俱全，真让人食指大开啊！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10561Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>鲁匠师是望仙镇的铸造一把好手，跟他讨论下铸造之术吧</t><b/>";
		case 10002:	return "<t>少侠，你可知这铸造之术，小到村民日常家用，大到对修行之人锻造神器之用呢！</t><b/>";
		case 10005:	return "<t>神兵有灵，神兵需要自己温养最合适不过了，这把利器送你了，好生使用。</t><b/><t>你继续去给村民送去婉儿的美食吧！</t><b/>";

		case 30001:	return "<t>我这铸造之术是从昆仑城剑师西门一剑处所学的一些皮毛，你看这病兵刃，虽不是什么神兵利器，也好过一般之物。少侠他日若要锻造自己的神兵利器可向大师讨教一二，比有所得！</t><b/>";
		case 31001:	return "<t>原来所有的神兵利器都是自己打造的啊！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10571Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>继续替婉儿将鱼跃龙门这道菜送给镇上村民</t><b/>";
		case 10002:	return "<t>先送给药师吧，刚好顺路，药师华千骨是望仙镇的炼丹好手，顺道跟他讨论下炼丹之术吧</t><b/>";
		case 10005:	return "<t>婉儿又叫人送来美味了啊，多谢少侠！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10581Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>探讨炼丹之术</t><b/>";
		case 10002:	return "<t>少侠，这炼丹之术，非小道儿，修行之人历劫、挑战怪物都有受伤或力所不及之时，此时丹药可就派上大用处了。并且高级的丹药可提升自己的潜能。</t><b/>";
		case 10005:	return "<t>炼丹之道博大精深，少侠等你35级后可在昆仑城或蓬莱仙人处学习炼丹之术，此葫疗伤药是我随手炼制而成，送你防身之用吧</t><b/><t>我就不耽搁你给其他村民送去美食了！</t><b/>";

		case 30001:	return "<t>老夫年前时跟蓬莱仙人学习过一段时间的炼丹之术，这丹药是居家旅行保命必备之物，有时能大幅度提升自身能力哦！</t><b/>";
		case 31001:	return "<t>原来炼丹出了可炼出回血疗伤之药外，还可增强自身能力的啊！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10591Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>继续替婉儿将鱼跃龙门这道菜送给镇上村民</t><b/>";
		case 10002:	return "<t>送给布庄刑月姑娘吧，刑月姑娘可是镇上少有的裁缝好手，据说缝制而成的衣服铠甲能防各种妖魔鬼怪的攻击</t><b/>";
		case 10005:	return "<t>婉儿又叫人送来美味了啊，多谢少侠！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10601Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>探讨裁缝之术</t><b/>";
		case 10002:	return "<t>少侠可知这裁缝之术，精深者有补天之漏的能力，缝制而成的防具能防护住各种妖魔鬼怪的攻击哦！</t><b/>";
		case 10005:	return "<t>裁缝之术博大精深，等你到35级可在昆仑城或蓬莱仙地学习哦！这几件防具乃我平日闲暇时缝制的，送你护身之用！</t><b/><t>我就不耽搁你继续给村民送美味啦！</t><b/>";

		case 30001:	return "<t>昔日蓬莱仙子路过小镇，传授我此项之能，这裁缝啊，就心细即可，配上好材料可缝制出高级与顶级的防具，这样就不怕妖魔鬼怪了！材料可在平时击败妖魔鬼怪时收集到呢！</t><b/>";
		case 31001:	return "<t>原来下山历练除魔可获得高级装备的材料呀</t><b/>";
		case 30002:	return "<t>裁缝之术博大精深者能制成天衣无缝的防具，可保护你更好的在山下历练哦！</t><b/>";
		case 31002:	return "<t>他日可学习下这生活技能！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10611Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>继续替婉儿将鱼跃龙门这道菜送给镇上村民</t><b/>";
		case 10002:	return "<t>送给首饰店的琪儿吧，琪儿可是对饰品有极高的制作水准，可向其讨教一番制器之术哦</t><b/>";
		case 10005:	return "<t>婉儿又叫人送来美味了啊，多谢少侠！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10621Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>探讨制器之术</t><b/>";
		case 10002:	return "<t>少侠可知这制器除了能制作饰品，还可制作许多有趣的小玩意哦！别小看这些做出来的小玩意，可有大用哦！</t><b/>";
		case 10005:	return "<t>制器之术博通古今，等你到35级可在昆仑城或蓬莱仙地学习哦！这几件饰品可是我昨日赶制出来的~送你佩戴吧！</t><b/><t>我就不耽搁你继续给村民送美味啦！</t><b/>";

		case 30001:	return "<t>听说昔日匠神鲁班做出了一件惊天地的神兵级别的首饰，惹的整个昆仑城三日霞云不散，太厉害了！</t><b/>";
		case 31001:	return "<t>制器还可以做出神器级别的饰品？有如此只能堪称神匠啊！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10631Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>替婉儿将鱼跃龙门这道菜送给他父亲梁伯吧！</t><b/>";
		case 10002:	return "<t>梁伯最近可为镇上周边出现妖魔头疼呢，看看有没办法帮忙！</t><b/>";
		case 10005:	return "<t>少侠可算来了，这美味，婉儿的手艺又长进了！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10641Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>探察鳄鱼潭，击败伤人的铁鳄。</t><b/>";
		case 10002:	return "<t>前往鳄鱼潭探察一番，消灭掉伤人的铁鳄。保护过往行人安全。</t><b/>";
		case 10005:	return "<t>哎，长此以往这妖变何时是个头啊，村民的性命不保啊！</t><b/>";

		case 20001:	return "<t>哎，刚听村民说这后山鳄鱼潭的鳄鱼发疯一样的朝过往路人攻击，这怕要不了多少时日又要出事了。少侠可否帮老夫一探? 若能除去伤人的鳄鱼更好！</t><b/>";
		case 21001:	return "<t>村长莫慌，我这前往鳄鱼潭看看。</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10651Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>帮助梁伯找解决妖患之法。</t><b/>";
		case 10002:	return "<t>听说昆仑城来的赏金猎人有对此有办法，去问问吧！</t><b/>";
		case 10005:	return "<t>你说的我都知道，最近望仙谷确实不太太平，妖兽四起，我们修士定当维护一方平安。</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10661Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>槐花岭处花妖害人，去探察下并让刑烈冥看下你的实力吧！</t><b/>";
		case 10002:	return "<t>槐花岭处出现了花魅，迷惑往来的路人，前期探察一番，并看下是否有何线索</t><b/>";
		case 10005:	return "<t>观这花魂，看来这花妖异变有些时日了，只是一直出来害人，不知何故今日都已出动了。你做的很好，这件护手拿去防身吧。</t><b/>";

		case 20001:	return "<t>这妖兽肆掠，必有其因，你我皆修行之人，有行侠仗义出手相助的必要，但普通人万万不可如此，万一伤的性命如何是好。</t><b/>";
		case 21001:	return "<t>大哥说的事，这降妖除魔之事还得我们来做</t><b/>";
		case 20002:	return "<t>不知少侠身手如何，据说槐花岭处出现花妖魅惑往来的路人，想必花妖应该比较温和，不会太伤人，你去探察下吧，也好让我看见你的实力。</t><b/>";
		case 21002:	return "<t>槐花岭？我这就去探察下，看看花妖为何物。</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10671Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 300: return"<t>   </t><b/>";
		case 10001:	return "<t>寻找接应之人</t><b/>";
		case 10002:	return "<t>你拿我的令牌，路上会有人接应你的，你可向他说明情况</t><b/>";
		case 10005:	return "<t>此处通往昆仑之路也有许多狐妖变得非常狂躁</t><b/>";

		case 20001:	return "<t>此地异变频发。事有蹊跷，你我皆修仙之人，为民除害当为己任，我在此守住，前往昆仑城找大统领说明此地事宜，看他有何安排！</t><b/>";
		case 21001:	return "<t>好的</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10681Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>前往昆仑城禀报望仙谷异变频发的事情。</t><b/>";
		case 10002:	return "<t>需要取狂躁的狐内丹拿给大统领看，他自认就知道了</t><b/>";
		case 10005:	return "<t>竟有此事！看来神算子所言不虚，你送信而来，辛苦你了。</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10691Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>帮大统领询问神算子有无破解之法。</t><b/>";
		case 10002:	return "<t>初来昆仑城，这繁华的仙城，果然能人异士倍多，遇到神算子的话去询问下吧，顺道了解下为什么会指引旒歆师姐解救自己！</t><b/>";
		case 10005:	return "<t>童言无忌，小小少年从何而来，所来何事，为何而去？</t><b/>";

		case 20001:	return "<t>你初来昆仑城，可在此处好好逛逛，我去像城主大人禀报此事，你如遇到神算子，可代为问下他有何妙策！说不得过几日还得需要少侠前往望仙谷再跑一趟</t><b/>";
		case 21001:	return "<t>神算子……这不是小师姐林旒歆当时接我时说过的？？？</t><b/>";

		case 30001:	return "<t>仙人之路！仙人之路！上知天文下知地理！前知五千年后晓百年！</t><b/>";
		case 31001:	return "<t>…………仙人</t><b/>";

		case 30002:	return "<t>仙人之路！仙人之路！上知天文下知地理！前知五千年后晓百年！</t><b/>";
		case 31002:	return "<t>…………这骗子吧</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10701Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>神算子似乎有所顾忌故意答非所问！</t><b/>";
		case 10002:	return "<t>看来神算子莫前辈有所顾忌，答非所问，问不出个所以然来还是先逛逛吧！</t><b/>";
		case 10005:	return "<t>莫走，走了可就回不来了，小小少年可造之才，浪费了可惜呀！</t><b/>";

		case 20001:	return "<t>仙人之路！仙人之路！上知天文下知地理！前知五千年后晓百年！</t><b/>";
		case 21001:	return "<t>大师可知我是谁？</t><b/>";
		case 20002:	return "<t>仙人之路！仙人之路！上知天文下知地理！前知五千年后晓百年！</t><b/>";
		case 21002:	return "<t>…………大师可知我将要去何处？</t><b/>";
		case 20003:	return "<t>咦，我说你故意的是吧，你也不打听打听我神算子是谁，上知天文下知地理前后知晓五百年可不是吹的！</t><b/>";
		case 21003:	return "<t>那莫前辈可知为何我会出现在你面前？</t><b/>";
		case 20004:	return "<t>你是天文吗？你是地理吗？你是五百年吗？你什么都不是，我怎么会知晓你呢。</t><b/>";
		case 21004:	return "<t>!!!!!</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10711Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>神算子前辈给了一张破破烂烂的鬼画符。。拿着鸡毛当令箭？</t><b/>";
		case 10002:	return "<t>拿着符令去找符中书，让其传你一招保命之术。看看是否真的有效果吧！</t><b/>";
		case 10005:	return "<t>唔，真是神算子前辈的笔迹，欠他一个人情，总算可以还掉了，少年拿好，这就是秘籍！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10721Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>制符之术博大精深，可与符中书讨论其中奥秘</t><b/>";
		case 10002:	return "<t>制符之术，非旁门左道，往昔有符神上可招星辰，下可号令鬼神，威力无穷，还可为自己护身保命！</t><b/>";
		case 10005:	return "<t>此乃我闲暇时所铸</t><b/>";
		case 20001:	return "<t>三千大道我只取其一，制符！要知一张符咒放出，天地鬼门大开，古今英魂听我号令，无所不能，也是一大道所置</t><b/>";
		case 21001:	return "<t>这么厉害！看来此生活之技很有威力！</t><b/>";
		case 20002:	return "<t>你有莫前辈给你的符令，今后你若要学习制符，尽管来找我吧。</t><b/>";
		case 21002:	return "<t>多谢前辈！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10731Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>昆仑城内闲逛</t><b/>";
		case 10002:	return "<t>初来昆仑，你可闲逛会，稍后你去找大统领，估计他有所交代!</t><b/>";
		case 10005:	return "<t>少侠还在城中，如此甚好！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10741Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>前往卫兵统领处，看看如何进冰火试炼！参与考验</t><b/>";
		case 10002:	return "<t>卫兵统领在昆仑城会盟广场上方。可过去寻找他，他会指点你如何去挑战试炼！</t><b/>";
		case 10005:	return "<t>原来是大统领推荐的，身手定然不凡！</t><b/>";

		case 20001:	return "<t>吾刚与城主所议，望仙谷妖霍不可小视，但一时半会分不出人手特与城主相商。暂时开放试炼之地，凡能挑战冰火试炼者，均可领物资前往望仙谷协助除妖！</t><b/>";
		case 21001:	return "<t>小弟想前期一试，为民除害！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10751Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>冰火试炼凶险之极，还是尽量提升下自身能力吧！</t><b/>";
		case 10002:	return "<t>找到强化师【段宾工】将自身装备强化一下！</t><b/>";
		case 10005:	return "<t>是为去冰火试炼所准备的啊，嗯，理当如此！</t><b/>";

		case 20001:	return "<t>要知冰火试炼不可儿戏，你这一身防护还略有所欠，这些物资是城主发下来给本次试炼所准备的，你先拿一部分将自身防护提升下，才好去试炼！</t><b/>";
		case 21001:	return "<t>如此！多谢。</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10761Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>强化一身装备</t><b/>";
		case 10002:	return "<t>尽可能的多强化下装备吧，冰火试炼据说极为凶险，还是小心为上！</t><b/>";
		case 10005:	return "<t>这装备强化的勉强还行</t><b/>";

		case 20001:	return "<t>这强化之术呢是极为神奇的秘术，装备一旦强化，强化等级越高，效果越好</t><b/>";
		case 21001:	return "<t>这个自然，你当我傻啊~</t><b/>";

		case 20002:	return "<t>按理装备强化若失败了装备必然消失，但凡事都有个例外，你若在强化时，加上保护符，则失败不会消失，同样在强化+6以下时，若失败，系统会赠送你保护装备不消失！</t><b/>";
		case 21002:	return "<t> +6以下会保护失败装备不消失？！</t><b/>";

		case 20003:	return "<t>随着你等级境界提升，你可直接将当前等级的装备强化属性等等全部转移至高级装备上，只需付出一点微不足道的代价即可！</t><b/>";
		case 21003:	return "<t>原来如此！我来试试吧</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10771Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>光有强化，装备的潜能还未完全发挥，还是需要再鉴定下</t><b/>";
		case 10002:	return "<t>找到鉴定师【承媛】姑娘将装备鉴定下吧！30级紫色的装备就可参与鉴定了！</t><b/>";
		case 10005:	return "<t>原来是要参与冰火试炼的侠士啊，装备鉴定可大幅度提升能力哦！只需一些微不足道的金币即可。</t><b/>";

		case 20001:	return "<t>要知冰火试炼凶险无比，被击败了回有可能掉落装备道具的！看在你是大统领推荐的份上，送你点小材料，去讲装备鉴定下吧、</t><b/>";
		case 21001:	return "<t>多谢统领······</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10781Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>将身上的紫色品质装备鉴定一下</t><b/>";
		case 10002:	return "<t>鉴定可大幅度提升装备的属性能力，更有甚者可将装备涅槃重铸精炼大幅提升装备能力哦!放入鉴定幸运符可大幅提升装备鉴定成功率哦！</t><b/>";
		case 10005:	return "<t>不错，这样前往挑战冰火试炼我等才放心，你可将身上值钱珍惜之物暂存仓库再去也不迟！</t><b/>";

		case 20001:	return "<t>放入鉴定幸运符可大幅提升装备鉴定成功率哦！鉴定出来的属性今后可通过重铸来进行更改！</t><b/>";
		case 21001:	return "<t>原来如此，我来试试吧、！</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10791Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 301: return "<t>任何地方，只要你找到我，我都会卖你救命之丹药！无需多言</t><b/>";
		case 300: return "<t>任何地方，只要你找到我，我都会将你的装备修理焕然一新，当然，如若你一直在野外，也可使用快捷修理</t><b/>";
		case 303: return "<t>任何地方只要你需要，我都会卖你食物助你恢复生命法力！</t><b/>";
		case 304: return "<t>我只在主城哦，你可将东西存放在我这，保证安全万无一失哦！</t><b/>";
		case 302: return "<t>当你觉得你能学习更高级的战技法术时，你来我这可参悟学习，当然最大的可能还是你在战斗时缴获敌人的秘籍进行参悟！</t><b/>";
		case 10001:	return "<t>你可去买点药品、食物、技能书等之类的物品将自己调整至巅峰状态再去参与最适合不过了！</t><b/>";
		case 10002:	return "<t>你可在以下Npc处进行以下操作：</t><b/>" @
			"<t>1、购买药品：名医[柳宗来]</t><b/>" @
			"<t>2、装备修理：[南宫寻]</t><b/>" @
			"<t>3、购买食物：厨娘[林魅儿]</t><b/>" @
			"<t>4、物品存储：仓库管理员[苍曼宇]</t><b/>" @
			"<t>5、技能书购买：[符中书]</t><b/>";
		case 10005:	return "<t>进去试炼吧！一切小心为上哦！</t><b/>";

		case 30001:	return "<t>每日随时都可来参与冰火试炼哦！这里的奖励极为丰厚，既为试炼之地，在这里战斗是不会增加红名的。当然若你的善恶值过高，在试炼之地被击败会增大掉落装备的概率哦！</t><b/>";
		case 31001:	return "<t>原来红名会增加被击败掉物的概率呀！</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10801Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>完成3次任意冰火试炼任务</t><b/>";
		case 10002:	return "<t>每日随时都可来参与冰火试炼哦！这里的奖励极为丰厚,挑战几次试试看吧。</t><b/>";
		case 10005:	return "<t>嗯，表现的真不错，是否感觉自己的修为又增长了呢</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10811Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>了解极寒之地</t><b/>";
		case 10002:	return "<t>快去找冰火试炼内的使者了解一下吧</t><b/>";
		case 10005:	return "<t>我乃冰之圣使，掌管寒冰峡的试炼任务</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10812Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>了解极炎之地</t><b/>";
		case 10002:	return "<t>看你对此很陌生，再去找别人问问吧</t><b/>";
		case 10005:	return "<t>我乃焰之圣使，掌管烈焰谷的试炼任务</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10813Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>了解极灵之地</t><b/>";
		case 10002:	return "<t>若还想了解更多，再去找别人问问吧</t><b/>";
		case 10005:	return "<t>我乃试炼使者，掌管冰火试炼内灵草圣物</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10821Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 300:   return "<t>少侠可想知道快速提升等级的方法吗</t><b/>";
		case 10001:	return "<t>前往福星询问</t><b/>";
		case 10002:	return "<t>那你就要去找福星问清楚了，他就在昆仑城内</t><b/>";
		case 10005:	return "<t>每周都可以在我这领取5小时双倍经验，空闲时还可以储存起来</t><b/>";

		case 20001:	return "<t>实力有所提升，不知有何打算呢？</t><b/>";
		case 21001:	return "<t>我正要去找大统领请命前往望仙谷除妖</t><b/>";
		case 20002:	return "<t>原来如此，前往望仙谷除妖，也是一段不错的历练，抓住次机会快速提升一下自己吧</t><b/>";
		case 21002:	return "<t>可有什么快速提升的方法</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10831Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>打听黄金宝藏</t><b/>";
		case 10002:	return "<t>去找旁边的绾绾打听黄金宝藏的下落吧</t><b/>";
		case 10005:	return "<t>来找我的人都是为了打听黄金宝藏</t><b/>";

		case 20001:	return "<t>虽说提升等级是好，可我见你囊中羞涩，只怕日后是寸步难行啊</t><b/>";
		case 21001:	return "<t>我也正想问此事</t><b/>";
		case 20002:	return "<t>我只听说有个叫黄金宝藏的地方，需要有一定实力才能去</t><b/>";
		case 21002:	return "<t>那么黄金宝藏在哪呢？</t><b/>";

		case 30001:	return "<t>少侠来找我，一定是想打听黄金宝藏的下落吧</t><b/>";
		case 31001:	return "<t>我还没有说，你怎么知道</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10841Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 300:return "<t>门派事务繁忙，望诸弟子分担琐碎杂物，为师门尽忠</t><b/>";
		case 10001:	return "<t>了解师门任务</t><b/>";
		case 10002:	return "<t>完成10次师门尽忠就可以获得黄金密令，你先去了解一下吧</t><b/>";
		case 10005:	return "<t>如果放弃师门任务，需要等10分钟才能再次接</t><b/>";

		case 20001:	return "<t>黄金宝藏中可是有数不尽的黄金，但是必须要手持黄金密令的人才能进入</t><b/>";
		case 21001:	return "<t>如何才能获得黄金密令呢</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10851Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>询问藏宝图详情</t><b/>";
		case 10002:	return "<t>只要有藏宝图，就有可能找到珍宝。你可以去问问昆仑奇人</t><b/>";
		case 10005:	return "<t>你想的倒是挺美</t><b/>";

		case 20001:	return "<t>这黄金宝藏中虽然黄金无数，可是有些珍贵材料更是千金难求</t><b/>";
		case 21001:	return "<t>这等珍贵的材料，哪能这么容易找到</t><b/>";

		case 30001:	return "<t>来，少侠你看我这藏宝图，这里边儿可埋着宝贝呢</t><b/>";
		case 31001:	return "<t>哇，这藏宝图要给我吗？</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10861Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>回去找大统领复命</t><b/>";
		case 10002:	return "<t>现在要回去找大统领请命前往望仙谷除妖</t><b/>";
		case 10005:	return "<t>你通过冰火试炼回来了</t><b/>";

		case 20001:	return "<t>上古妖魔将秘宝藏匿于隐蔽的角落，只有击败妖灵，夺取他们的藏宝图，才有可能找到秘宝</t><b/>";
		case 21001:	return "<t>原来是这样</t><b/>";

		case 20002:	return "<t>怎么样，有没有兴趣帮我捉妖挖宝，挖到大秘宝那可就发大财了</t><b/>";
		case 21002:	return "<t>挖宝太费时间，还是日后再说吧</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10871Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>前往望仙谷</t><b/>";
		case 10002:	return "<t>能在冰火试炼中提升实力，看来你的悟性不错，去望仙谷找顾和光，他会分配你一些任务的</t><b/>";
		case 10005:	return "<t>是大统领命你来的。</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10881Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>将传播病疫的蚊子铲除</t><b/>";
		case 10002:	return "<t>少侠来的正是时候，附近出现了许多妖蚊，被它们叮上一口就可能染上病疫，让人防不胜防，得想办法除掉才好</t><b/>";
		case 10005:	return "<t>如此甚好，我们可以专心对付这里妖魔了</t><b/>";

		case 30001:	return "<t>多亏你来的及时，这些妖蚊对付起来可真麻烦，还让将士们的战斗力大打折扣</t><b/>";
		case 31001:	return "<t>降妖除魔乃是我等修士的本分</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10891Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>击败猛虎，用虎皮来伪装</t><b/>";
		case 10002:	return "<t>青丘岭附近有许多猛虎，可用这些虎皮来伪装，也算是为民除害了</t><b/>";
		case 10005:	return "<t>嗯，套上虎皮应该就不会引起注意了</t><b/>";

		case 20001:	return "<t>前面的邪龙坡就是妖魔的第一道防线，妖魔的主力都在陨仙窟内</t><b/>";
		case 21001:	return "<t>我先前去打探一番</t><b/>";

		case 20002:	return "<t>不可贸然行动，这样容易暴露，前去打探的话应该想办法伪装起来</t><b/>";
		case 21002:	return "<t>那该怎么办呢</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10901Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>前往邪龙坡打探</t><b/>";
		case 10002:	return "<t>前去打探要千万小心，一定要回来禀报情况，不可贸然行动</t><b/>";
		case 10005:	return "<t>黄沙遍地，难道会是沙妖作祟？</t><b/>";

		case 30001:	return "<t>可有打探到什么情况</t><b/>";
		case 31001:	return "<t>前方虽有树妖，但看似枯萎，虽有水源，但黄沙遍地</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10911Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>前往黄沙岭，查看沙妖情况</t><b/>";
		case 10002:	return "<t>你可前往黄沙岭去看看，那里常年被黄沙淹没，时常出现沙妖</t><b/>";
		case 10005:	return "<t>如此说来，也许还有另一种可能。</t><b/>";

		case 30001:	return "<t>怎么样，此事跟沙妖可有什么联系吗</t><b/>";
		case 31001:	return "<t>这些沙妖还没有那样的实力，看样子不是沙妖所为</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10921Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>打听狐王</t><b/>";
		case 10002:	return "<t>前方狐王洞内有一位青丘狐王在此闭关修炼，还有许多宝物防身，实力深不可测，不知是否跟它有关</t><b/>";
		case 10005:	return "<t>不可轻易前往，这狐王实力太强</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10931Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>击败狐王洞守卫，进入洞内查探</t><b/>";
		case 10002:	return "<t>进入狐王洞内查探千万不可惊扰到青丘狐王，否则你的下场会很惨！</t><b/>";
		case 10005:	return "<t>看来不是狐王所为吗</t><b/>";

		case 20001:	return "<t>狐王洞口有许多赤芒蚊在巡逻，必须将其击败才可进入洞内</t><b/>";
		case 21001:	return "<t>好的，没问题</t><b/>";

		case 30001:	return "<t>可发现狐王有什么异常？</t><b/>";
		case 31001:	return "<t>狐王潜心修炼，好像对外界是事并不关心</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10941Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>前往陨仙窟</t><b/>";
		case 10002:	return "<t>前去陨仙窟要多加小心，里面的妖魔都是会主动攻击人的</t><b/>";
		case 10005:	return "<t>我乃是此陨仙窟的守卫，一直在此守住地宫入口</t><b/>";

		case 20001:	return "<t>看来只有进入陨仙窟内瞧一瞧了，此事又要麻烦你了</t><b/>";
		case 21001:	return "<t>降妖除魔乃我等修道本分，何来麻烦</t><b/>";

		case 20001:	return "<t>站住！</t><b/>";
		case 21001:	return "<t>你是何人，为何我刚才来此没有发现你</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10951Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>进入陨仙窟内</t><b/>";
		case 10002:	return "<t>那好，进入地宫内如果遇到危险，便可来出口，我在此镇守妖魔不敢出来</t><b/>";
		case 10005:	return "<t>原来如此</t><b/>";

		case 20001:	return "<t>你来此处做什么</t><b/>";
		case 21001:	return "<t>妖魔四处作乱，我来前往陨仙窟内查看是何原因</t><b/>";

		case 20002:	return "<t>原来如此，这里面的妖魔比你想象的强大，而且都会主动攻击人，你确定要去？</t><b/>";
		case 21002:	return "<t>此事我不会坐视不理，一定要去</t><b/>";

		case 30001:	return "<t>地宫凶险之地，外面的守卫为何会放你进来</t><b/>";
		case 31001:	return "<t>妖魔四处作乱，我来前往陨仙窟内查看是何原因</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10961Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>击败噬魔犬证明实力</t><b/>";
		case 10002:	return "<t>如此说来，刚好最近噬魔犬显得有些暴躁，你去教训一下吧</t><b/>";
		case 10005:	return "<t>嗯，还可以。倘若是连噬魔犬也对付不了，也别想在这里混下去了</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10971Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>去寻找元波光了解</t><b/>";
		case 10002:	return "<t>我在此处也少有走动，具体情况要往深处寻找元波光了解清楚</t><b/>";
		case 10005:	return "<t>难道这就是元波光，看起来脸色发白，是什么厉害的功法？</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10981Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>抓蛇取胆</t><b/>";
		case 10002:	return "<t>前往深处寻找青葵蛇，获其蛇胆方可解毒</t><b/>";
		case 10005:	return "<t>太好了，有解药了。</t><b/>";

		case 20001:	return "<t>这位少侠来的正好，我在此探视不小心中毒了，可否帮我去弄点解药来</t><b/>";
		case 21001:	return "<t>原来是中毒了，那如何才能获得解药呢</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission10991Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>检测水质</t><b/>";
		case 10002:	return "<t>可能是这里的水有问题，应该前往水源处查看一下</t><b/>";
		case 10005:	return "<t>这位少侠请留步</t><b/>";

		case 20001:	return "<t>这次真的多亏了你及时出现</t><b/>";
		case 21001:	return "<t>可是这好端端的怎么会中毒呢</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11001Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>了解毒源</t><b/>";
		case 10002:	return "<t>此处水源被污染，只因一把被戾气侵袭的镇魔剑</t><b/>";
		case 10005:	return "<t>小心不要被戾气所反噬</t><b/>";

		case 20001:	return "<t>此水有毒，不可饮用</t><b/>";
		case 21001:	return "<t>这位前辈，为何知道这水有毒呢</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11011Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>封印镇魔剑</t><b/>";
		case 10002:	return "<t>那只好先将镇魔剑封印起来，日后再想办法</t><b/>";
		case 10005:	return "<t>二层更是戾气弥漫</t><b/>";

		case 20001:	return "<t>二层内有个幽城鬼王，散发出戾气无人能挡，只有使用游仙符箓才能抵挡片刻。</t><b/>";
		case 21001:	return "<t>那我要怎样获得这游仙符箓</t><b/>";

		case 20002:	return "<t>找符中书的生活技能就制作游仙符箓，但是也只能抵挡，无法驱散</t><b/>";
		case 21002:	return "<t>还要回去昆仑城，没有那么多时间了</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11021Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>前往陨仙窟二层</t><b/>";
		case 10002:	return "<t>去找陨仙窟二层的钟离泰鸿，了解鬼王的来源</t><b/>";
		case 10005:	return "<t>你想要了解这戾气来源</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11022Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>击败邪魅猴</t><b/>";
		case 10002:	return "<t>此处戾气气太重，力量会被压制，没有游仙符箓是待不下去的</t><b/>";
		case 10005:	return "<t>居然没有游仙符箓也敢来此，给你先拿着吧</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11031Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>了解情况，回去找大统领</t><b/>";
		case 10002:	return "<t>我在此处也只能抵挡戾气往外扩散，这件事情还是要回去找大统领汇报才行</t><b/>";
		case 10005:	return "<t>原来如此，辛苦你了</t><b/>";

		case 20001:	return "<t>数千年前，有几位上仙在此共同陨落，不甘的戾气充满了整个山窟，这鬼王就是这戾气所成</t><b/>";
		case 21001:	return "<t>那有什么办法解决呢</t><b/>";

		case 20002:	return "<t>此处戾气不散，即使击败鬼王，他也会集结戾气重生。</t><b/>";
		case 21002:	return "<t>那这不是无解了吗</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
//■■■■■■■■■■■■■■望仙谷任务■■■■■■■■■■■■■■■■

//■■■■■■■■■■■■■■苍山雪海任务■■■■■■■■■■■■■■■■
function Mission11040Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>解谜机缘</t><b/>";
		case 10002:	return "<t>之前的事情我会跟城主商量，你可以先回去调养休息。不过神算子好像在找你有事情，你可以去见见他。</t><b/>";
		case 10005:	return "<t>老夫掐指一算，你有一份机缘在苍山雪海，你可想知道？</t><b/>";

		case 30001:	return "<t>小家伙，你可总算来了。陨仙窟一游，是否觉得自己的修为又增进几分呢？</t><b/>";
		case 31001:	return "<t>确实有几分增进，前辈有何赐教...（这老瞎子又想忽悠我干嘛？）</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11041Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>前往苍山雪海</t><b/>";
		case 10002:	return "<t>天机……不可泄露！想知道你就自己去苍山雪海看看吧！</t><b/>";
		case 10005:	return "<t>路边突然冒出几只雪白的怪物，张牙舞爪的扑过来</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11051Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>击败冰雪傀儡</t><b/>";
		case 10002:	return "<t>路边突然冒出几只雪白的怪物，张牙舞爪的扑过来</t><b/>";
		case 10005:	return "<t>这里天寒地冻的，这位小妹妹怎么会在这里。</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11061Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>帮佩云找回首饰</t><b/>";
		case 10002:	return "<t>我本来是寻找遗失在这附近的首饰，谁知道会突然冒出许多傀儡怪，把我困在这里回不去了，你能帮我把首饰找回来吗？</t><b/>";
		case 10005:	return "<t>这里都这么危险了，你还只想着这个首饰，这个首饰有这么重要吗</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11071Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>送佩云回白虎寨</t><b/>";
		case 10002:	return "<t>这是我母亲留给我的，真是太谢谢你了，那么…你能送我回去吗，我就住在前方的白虎寨</t><b/>";
		case 10005:	return "<t>只不过如此危险之地，这位小妹怎会一人前往？</t><b/>";

		case 30001:	return "<t>多亏你将小女送回来，真是感激不尽。略微薄礼，还望笑纳。</t><b/>";
		case 31001:	return "<t>这只是举手之劳而已。</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11081Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>询问赵璟</t><b/>";
		case 10002:	return "<t>你可以去找赵璟正询问一下</t><b/>";
		case 10005:	return "<t>寒冰傀儡的事赵队长可调查到什么了</t><b/>";

		case 20001:	return "<t>这你就有所不知了，原本此处是没有这些傀儡怪的。只是不知道为何突然就冒出来了，护卫队长赵璟正在调查原因。</t><b/>";
		case 21001:	return "<t>那我倒是想看看，这到底是在搞什么鬼。</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11091Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>击败苍雪巫师</t><b/>";
		case 10002:	return "<t>哎。作为白虎寨的客人，还让你以身犯险，真是惭愧。</t><b/>";
		case 10005:	return "<t>好险！这些巫师巫术如此厉害，稍有不慎将会被迷惑心智，差点就回不来了</t><b/>";

		case 20001:	return "<t>倒是有一些眉目了，这些傀儡都是从苍雪营出来的，我曾派人去查，但是进去的人都没有回来了，我自己又无暇分身。</t><b/>";
		case 21001:	return "<t>既然如此，那我倒是要进去看看</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11101Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>寻找药师讨药</t><b/>";
		case 10002:	return "<t>巫术应该没有这么厉害，而是跟此处严寒的气候相辅相成，才会有如此大的威力。你可前往寻找药师讨要冰心丸抵御严寒，就不在畏惧这些巫师了</t><b/>";
		case 10005:	return "<t>华药师，我前往苍雪营需要冰心丸，能否赠我几粒？</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11111Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>采集寒冰草</t><b/>";
		case 10002:	return "<t>年轻人，你说的倒是轻巧。你可知我炼制冰心丸需要多少寒冰草吗，你若是能帮我采来，我就可以帮你炼制</t><b/>";
		case 10005:	return "<t>好的，有了冰心丸，那我就不怕那些巫师了</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11121Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>解救被困的修士</t><b/>";
		case 10002:	return "<t>听说那些失踪的修士只是困在里面了，这冰心丸的持续时间不够长，要抓紧时间，救出修士就回来</t><b/>";
		case 10005:	return "<t>他们能被救回来，真的有劳你了</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11131Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>寻找万宏光打听野人事情</t><b/>";
		case 10002:	return "<t>听他们回来的人说，在苍雪营有看到野人的痕迹。野人明明在雪松平原才会出现，你可以寻找万宏光打听一下</t><b/>";
		case 10005:	return "<t>听说有野人出现在苍雪营，来向你打听一些情况</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11141Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>击败仓雪野人</t><b/>";
		case 10002:	return "<t>说来也奇怪，我也偶尔看到野人，但是最近总觉得他们的性情变得非常暴躁。不如你自己去下面看看情况</t><b/>";
		case 10005:	return "<t>这些野人真是暴躁，但是看他们的形态，缺又跟刚开始遇到的寒冰傀儡有些相似</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11151Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>寻找客卿分析</t><b/>";
		case 10002:	return "<t>这么说来，这一串的事情似乎有着一些密切的联系，你可以去问我们冰雪聪明的客卿替你分析一下情况</t><b/>";
		case 10005:	return "<t>白虎寨的客卿竟然是一位如此美貌的女子，真是让人吃惊</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11161Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>询问野人原由</t><b/>";
		case 10002:	return "<t>过奖过奖，想必你就是来问我寒冰傀儡的事情的吧。大部分是经过我都听说了。你也真是胆识过人。</t><b/>";
		case 10005:	return "<t>哪里哪里，我发现了野人也傀儡之间有一些联系，此事你怎么看</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11171Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>击败雪豹</t><b/>";
		case 10002:	return "<t>哦，野人吗？如果是这样的话，那可能不只是野人了。雪松平原常常有雪豹出没，你去那里了解一下吧</t><b/>";
		case 10005:	return "<t>如你所料，雪豹也是变得比较异常</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11181Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>击败雪豹，获取雪豹内丹</t><b/>";
		case 10002:	return "<t>嗯，那就没错了。这些巫师就是迷惑了没有心智的野人和雪豹，用野人的躯体和雪豹的内丹制成了傀儡，你再去弄几个雪豹内丹来，我们需要细细研究。</t><b/>";
		case 10005:	return "<t>之前怎么不说，我又多跑了一趟。</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11191Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>将新的情况告诉万虎</t><b/>";
		case 10002:	return "<t>呵呵。此事急不得。你且将此事原由告诉寨主吧。</t><b/>";
		case 10005:	return "<t>这些巫师到底有何企图</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11201Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>寻找万志新询问封剑台情况</t><b/>";
		case 10002:	return "<t>莫不成是想要唤醒雪海魔君。还要再劳烦少侠跑一趟了，尽快去查看封剑台是否有异常，这是我的令牌</t><b/>";
		case 10005:	return "<t>我来此处检查封剑台是否有异常，这是令牌</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11211Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>询问封剑台前因后果</t><b/>";
		case 10002:	return "<t>我一直在此处，封剑台没有见人来过……咦！怎么突然会出现这么多剑奴。</t><b/>";
		case 10005:	return "<t>这些剑奴有什么问题吗？</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11221Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>询问封剑台前因后果</t><b/>";
		case 10002:	return "<t>这封剑台原本是封印的上古魔剑，偶尔有剑奴出现也是正常。可是一下子出现这么多，只怕是要冲破封印啊。</t><b/>";
		case 10005:	return "<t>那这可怎么办？</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11231Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>帮助击败剑灵</t><b/>";
		case 10002:	return "<t>快随我去将剑奴击溃，不能让魔剑冲破封印</t><b/>";
		case 10005:	return "<t>还好来的及时，不然这可不好处理</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11232Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>检查封剑台</t><b/>";
		case 10002:	return "<t>我们再去检查一下封剑台吧。</t><b/>";
		case 10005:	return "<t>先不管那么多了</t><b/>";

		case 30001:	return "<t>真是奇怪，我原本感觉这魔剑已经蠢蠢欲动，为何你一来，就变得安静下来了。</t><b/>";
		case 31001:	return "<t>刚才我也感觉身体有异样，但是也不清楚是何原因。</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11241Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>将封剑台情况告诉寨主</t><b/>";
		case 10002:	return "<t>真是辛苦你了，快将这里的情况告诉寨主吧。</t><b/>";
		case 10005:	return "<t>这魔剑原本就是他的武器，有所感应，如果拿到魔剑，他就能冲破结界，为祸人界。到时候又不免一片生灵涂炭。</t><b/>";

		case 30001:	return "<t>果然如此，看来这就是这些巫师的目的了</t><b/>";
		case 31001:	return "<t>可是魔剑跟雪海魔君又有什么联系呢</t><b/>";
		case 30002:	return "<t>如今雪海魔君沉睡在冰封王座中，还有上古仙人留下的铠甲在此震慑魔君，使其不敢出来。</t><b/>";
		case 31002:	return "<t>那有何惧</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11251Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>剿灭仓雪巫师</t><b/>";
		case 10002:	return "<t>不能让这些巫师的奸计得逞，我马上派人将他们剿灭，劳请你来助我们一臂之力。</t><b/>";
		case 10005:	return "<t>这些巫师真是狡猾，没那么容易歼灭。但是在苍雪营时我隐约听到桥那边有凄惨的叫声</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11261Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>回到昆仑告知莫前辈</t><b/>";
		case 10002:	return "<t>哎。看来这魔君真的要苏醒了，好在他现在没有魔剑。只怕这结界之力不能支撑太久。还需要前往昆仑城，集结更多修士一起来对付魔君</t><b/>";
		case 10005:	return "<t>呦，回来啦。看样子修为又增进不少啊</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}

//■■■■■■■■■■■■■■苍山雪海任务■■■■■■■■■■■■■■■■


//■■■■■■■■■■■■■■云梦泽任务■■■■■■■■■■■■■■■■
function Mission11271Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>魔剑之力</t><b/>";
		case 10002:	return "<t>这就是你的机缘，你身上残余的镇魔封印之力将魔剑的灵力吞噬了，这魔剑以后要永远沉睡了</t><b/>";
		case 10005:	return "<t>这不是挺好吗，这魔剑之力有何影响</t><b/>";

		case 20001:	return "<t>看来外界已经比想象的要混乱了</t><b/>";
		case 21001:	return "<t>有一个疑惑，为何靠近上古魔剑会内心狂躁不安。</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11281Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>天命不可违</t><b/>";
		case 10002:	return "<t>此乃天命不可违，只要你心无杂念，再有灵丹妙药相辅，便可化险为夷，今后就看你的造化了。</t><b/>";
		case 10005:	return "<t>那我要如何去寻找灵丹妙药</t><b/>";

		case 20001:	return "<t>倘若你能驾驭这份力量，今后就是所向披靡，若是被这份力量驾驭，轻则修为尽失，重则堕入魔道，万劫不复。</t><b/>";
		case 21001:	return "<t>竟然如此危险，那我宁可不要这力量</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11291Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>前往大统领</t><b/>";
		case 10002:	return "<t>灵材圣药最为丰盛的，那就是云梦泽了。此前大统领发布征集令，你去看看吧。</t><b/>";
		case 10005:	return "<t>我昆仑修士除魔有所损耗，现在需要人手前去云梦泽收集灵药。</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11301Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>前往云梦泽</t><b/>";
		case 10002:	return "<t>你可跟随其他修士一同前往。到了哪里，就有人接应你们。</t><b/>";
		case 10005:	return "<t>你就是前来收集灵药的吗</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11311Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>击败扭曲树精</t><b/>";
		case 10002:	return "<t>诸位总算是来了啊。我们这云梦泽遍地都是宝，只不过这里总有些树精挡道，麻烦你去将这些树精清除</t><b/>";
		case 10005:	return "<t>有劳你了，这样我就方便收集药材了</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11321Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>采集青髓草</t><b/>";
		case 10002:	return "<t>我还缺少一味青髓草，可否去帮我采一下呢，高台上随处可见</t><b/>";
		case 10005:	return "<t>嗯，这样第一种灵药的材料就齐了。</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11331Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>送达药师</t><b/>";
		case 10002:	return "<t>将这些材料送去华药师炼制吧</t><b/>";
		case 10005:	return "<t>华药师，这是第一种丹药的材料</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11341Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>寻要药材</t><b/>";
		case 10002:	return "<t>很好，那还有一种灵药材料，你去帮我问邢烈命拿</t><b/>";
		case 10005:	return "<t>少侠来拿灵药，只是这材料还未齐全呀</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11351Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>赶跑功夫熊猫</t><b/>";
		case 10002:	return "<t>需要翠竹林的灵竹，只是那里的熊猫可不好惹啊，若是能将他们赶跑就好了</t><b/>";
		case 10005:	return "<t>熊猫赶跑了，如此甚好</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11361Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>采集灵竹</t><b/>";
		case 10002:	return "<t>我还有其他事情忙，劳烦少侠去帮我采灵竹，送去华药师吧</t><b/>";
		case 10005:	return "<t>嗯，这灵竹是有了</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11371Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>抓几只蟾蜍</t><b/>";
		case 10002:	return "<t>蟾蜍虽毒，只要搭配合理，毒以药用也不是不可以的</t><b/>";
		case 10005:	return "<t>原来蟾蜍还有药用</t><b/>";

		case 20001:	return "<t>少侠若是能帮我去抓几只碧毒蟾蜍来就太好了</t><b/>";
		case 21001:	return "<t>这蟾蜍不是毒物吗？</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11381Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>抓几只噬灵魔花</t><b/>";
		case 10002:	return "<t>这就需要与他相辅而生的噬灵魔花，刚好去除他的毒性保存药性，你再去抓一些来吧</t><b/>";
		case 10005:	return "<t>这些噬灵魔花也太凶狠了吧,为何还能移动</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11391Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>蟾蜍未成形的噬灵魔花</t><b/>";
		case 10002:	return "<t>魔花成形，根离地面，以口噬灵，这些魔花吞噬灵力如此之快，这可不太好，得需要在他成形之前铲除才行</t><b/>";
		case 10005:	return "<t>原来这魔花成形之前是不会攻击人的</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11401Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>及时铲除</t><b/>";
		case 10002:	return "<t>还好来的及时，若是让这些魔花成形，又要多一份危险了</t><b/>";
		case 10005:	return "<t>可是刚才我经过那一片蘑菇时，身体有异样的感觉</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11411Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>采集蘑菇</t><b/>";
		case 10002:	return "<t>这些蘑菇稍有灵气，此次我们用不上，若是你的身体对此有异感，那就是说明你说身体正需要这味药材</t><b/>";
		case 10005:	return "<t>蘑菇采来了如此之多，应该怎么做呢</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11421Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>寻找可儿</t><b/>";
		case 10002:	return "<t>但是这蘑菇需要有密林灵泉水才可炼制，你去找看管灵泉的可儿讨要一些吧</t><b/>";
		case 10005:	return "<t>炼制药材想讨要一些灵泉水</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11431Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>赶跑木灵兽</t><b/>";
		case 10002:	return "<t>想要灵泉没有问题，可是这附近总有些木灵兽趁我不注意来偷喝灵泉水，你帮我把他们赶跑吧</t><b/>";
		case 10005:	return "<t>好的，真是麻烦你了</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11441Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>购买玉锦瓶</t><b/>";
		case 10002:	return "<t>但是这灵泉需要用玉锦瓶才能装，否责灵力散失，就跟普通溪水没有什么区别了，你自己前去购买吧</t><b/>";
		case 10005:	return "<t>请问是这样的瓶子吗</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11451Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>采集灵泉</t><b/>";
		case 10002:	return "<t>好了，你自己去打一壶灵泉吧</t><b/>";
		case 10005:	return "<t>灵泉已经拿来了，还请药师帮我炼制</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11461Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>增大药效</t><b/>";
		case 10002:	return "<t>我听闻深海迷宫有一种海草，能让此药效果倍增。只不过这深海危机重重，一般人可去不得啊</t><b/>";
		case 10005:	return "<t>我体内的魔剑之力已经隐隐发作，容不得我犹豫了。我该如何前往深海</t><b/>";

		case 20001:	return "<t>少侠莫要着急，这灵泉虽然有了，可还不能发挥最大药效</t><b/>";
		case 21001:	return "<t>那还有怎样才能发挥最大药效？</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11471Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>寻找雪馨</t><b/>";
		case 10002:	return "<t>进入深海之法只有雪馨知道，你可以找她问问清楚</t><b/>";
		case 10005:	return "<t>我想进入深海迷宫寻药，还请前辈指一条明路</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11481Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>击败变异海鬣</t><b/>";
		case 10002:	return "<t>年轻人，想进入深海寻药的人很多，可是没有几个是可以活着出来的。前往如此凶险之地，你至少要有能战胜变异海鬣的能力</t><b/>";
		case 10005:	return "<t>小小海鬣，不足为惧。</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11491Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>采集避水珍珠</t><b/>";
		case 10002:	return "<t>好，那我就放心教你怎么去，水中无氧气，一般修士想要在里面长时间停留，就必须要依靠避水珍珠。在近海处就能找到</t><b/>";
		case 10005:	return "<t>很不错，如此便可以前往了</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11501Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>采集海草</t><b/>";
		case 10002:	return "<t>深海凶险，自己去采集海草还要多加小心</t><b/>";
		case 10005:	return "<t>我已将海草采回，还望药师帮我炼制丹药</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11511Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>意外之喜</t><b/>";
		case 10002:	return "<t>够了够了，而且还有一些剩余，只是这剩余的部分你也没用，那我就自己留着了</t><b/>";
		case 10005:	return "<t>这倒是无妨</t><b/>";

		case 20001:	return "<t>哎呀，没想到真的拿到了，早知道让你多采一点了</t><b/>";
		case 21001:	return "<t>这，难道分量还不够吗？</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11521Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>修为大增</t><b/>";
		case 10002:	return "<t>大统领的任务也完成了，你要的东西也找到了。那快回昆仑城去吧</t><b/>";
		case 10005:	return "<t>莫前辈，此去我真的寻到了你说的丹药，现在感觉自己的修为有所增进</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission11531Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>灵寂境</t><b/>";
		case 10002:	return "<t>年轻人真是低调啊，你何止是增进一点，简直就是突飞猛进啊！</t><b/>";
		case 10005:	return "<t>没想到如此短的时间就已经修为就达到了灵寂境，后生可畏啊！</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}

//■■■■■■■■■■■■■■云梦泽任务■■■■■■■■■■■■■■■■