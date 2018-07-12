//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//攻略界面内具体各项内容保存信息
//
//==================================================================================
//■■■■【攻略界面】■■■■【阅历进度奖励相关】■■■■
//■■■■【攻略界面】■■■■【统计总阅历的进度】■■■■
//■■■■【攻略界面】■■■■【主控件文本】■■■■■■■
//■■■■【攻略界面】■■■■【子控件文本】■■■■■■■




//■■■■【攻略界面】■■■■【阅历进度奖励相关】■■■■
$GongLueGiftYueLiItem[1]= 105180221; $GongLueGiftNeedYueLi[1]= 20;
$GongLueGiftYueLiItem[2]= 105180222; $GongLueGiftNeedYueLi[2]= 60;
$GongLueGiftYueLiItem[3]= 105180223; $GongLueGiftNeedYueLi[3]= 120;
$GongLueGiftYueLiItem[4]= 105180224; $GongLueGiftNeedYueLi[4]= 180;
//■■■■【攻略界面】■■■■【阅历进度奖励相关】■■■■

//■■■■【攻略界面】■■■■【统计总阅历的进度】■■■■
function GetStrategyYueLiCount(%Player)//计算当前完成的阅历
{
	%YueLi = 0;
	%MainNum = GetStrategyMainBtnNum();
	//echo( "%MainNum===" @ %MainNum );
	for (%i = 0; %i < %MainNum; %i++)
	{
		%SubNum = GetStrategySubBtnNum(%i);
		//echo( "%SubNum===" @ %SubNum );
		for (%j = 0; %j < %SubNum; %j++)
		{
			%Src = $StrategySubBtnSrc[%i,%j];
			//echo( "%i ===" @ %i @ " %j===" @  %j @ "    %Src=== @ " @ %Src );
			if (GetSrc(%Player,%Src) == 1)
			{
				%YueLi = %YueLi + $StrategySubBtnYLi[%i,%j];
				//echo( "%Src ===" @ %Src  @ "     $StrategySubBtnYLi[ " @ %i @ "," @ %j @ "]===" @ $StrategySubBtnYLi[ %i, %j ] );
			}
		}
	}
	//echo( "%YueLi====" @ %YueLi );
	return %YueLi;
}
function GetStrategyYueLiAllCount(%Player)//计算总的阅历
{
	%AllYueLi = 0;
	%MainNum = GetStrategyMainBtnNum();
	for (%i = 0; %i < %MainNum; %i++)
	{
		%SubNum = GetStrategySubBtnNum(%i);
		for (%j = 0; %j < %SubNum; %j++)
		{
			%AllYueLi = %AllYueLi + $StrategySubBtnYLi[%i,%j];
		}
	}
	return %AllYueLi;
}
//■■■■【攻略界面】■■■■【统计总阅历的进度】■■■■

//■■■■【攻略界面】■■■■【主控件文本】■■■■■■■
$StrategyMainBtnName[0]= "玩家社交";
$StrategyMainBtnName[1]= "常用功能";
$StrategyMainBtnName[2]= "日常活动";
$StrategyMainBtnName[3]= "生活技能";
$StrategyMainBtnName[4]= "地图攻略";
$StrategyMainBtnName[5]= "首领怪物";

function GetStrategyMainBtnNum()//获取需要多少个主控件按钮
{
	for (%i = 0; %i < 99; %i++)
	{
		if ($StrategyMainBtnName[%i] $= "")
			break;
		%Record = %i;
	}
	return %Record + 1;
}
//■■■■【攻略界面】■■■■【主控件文本】■■■■■■■

//■■■■【攻略界面】■■■■【子控件文本】■■■■■■■
function SetStrategyBtnText()
{
	//攻略名称 阅历奖励 道具奖励 Src记录值
	//echo("■■【攻略界面】■■■■【子控件文本】■■■■■");
	//------------------玩家社交--------------------
	$StrategySubBtnTit[0,0]="组队";
	$StrategySubBtnYLi[0,0]="2";
	$StrategySubBtnIte[0,0]="113020002 5";
	$StrategySubBtnSrc[0,0]="64";
	if ($Now_Script == 1) $StrategySubBtnMsg[0,0]=$Get_Dialog_GeShi[31401] @
		"<t>组成一个队伍，携手队友一起打怪，乐趣无穷。</t><b/>" @
		"<t>可使用快捷键 </t>" @ $Get_Dialog_GeShi[31409] @ "Alt + T </t>" @ "<t>打开队伍界面，进行创建队伍、加入队伍、召集队友等操作</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：加入一个队伍，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[0,1]="添加好友";
	$StrategySubBtnYLi[0,1]="2";
	$StrategySubBtnIte[0,1]="113020002 5";
	$StrategySubBtnSrc[0,1]="66";
	if ($Now_Script == 1) $StrategySubBtnMsg[0,1]=$Get_Dialog_GeShi[31401] @
		"<t>寻三五好友，遨游昆仑世界。</t><b/>" @
		"<t>选中一个玩家 </t>" @ $Get_Dialog_GeShi[31409] @ "右键点击 </t>" @ "<t>玩家头像，可进行邀请添加好友操作</t><b/><b/>" @
		"<t>可使用快捷键 </t>" @ $Get_Dialog_GeShi[31409] @ "Alt + F </t>" @ "<t>打开好友界面，进行好友管理操作</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：成功添加一个好友，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[0,2]="帮派";
	$StrategySubBtnYLi[0,2]="5";
	$StrategySubBtnIte[0,2]="113020012 2";
	$StrategySubBtnSrc[0,2]="68";
	if ($Now_Script == 1) $StrategySubBtnMsg[0,2]=$Get_Dialog_GeShi[31401] @
		"<t>可以在 </t>" @ "<t>昆仑 </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010107);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010107,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>查询所有帮派操作</t><b/>" @
		"<t>可使用快捷键 </t>" @ $Get_Dialog_GeShi[31409] @ "Alt + G </t>" @ "<t>打开帮派界面，查看帮派相关的信息</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：加入一个帮派，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[0,3]="拍卖行";
	$StrategySubBtnYLi[0,3]="3";
	$StrategySubBtnIte[0,3]="113010102 5";
	$StrategySubBtnSrc[0,3]="70";
	if ($Now_Script == 1) $StrategySubBtnMsg[0,3]=$Get_Dialog_GeShi[31401] @
		"<t>暂未开放。</t><b/>";

	$StrategySubBtnTit[0,4]="摆摊";
	$StrategySubBtnYLi[0,4]="3";
	$StrategySubBtnIte[0,4]="113010102 5";
	$StrategySubBtnSrc[0,4]="72";
	if ($Now_Script == 1) $StrategySubBtnMsg[0,4]=$Get_Dialog_GeShi[31401] @
		"<t>可以通过摆摊来出售各种物品，也可以在其他玩家的摊位上购买需要的物品。</t><b/>" @
		"<t>可以在 </t>" @ "<t>昆仑 </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(810010108);\",\"" @ $Get_Dialog_GeShi[31214] @ "集市" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>摆摊。</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：第一次摆摊，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[0,5]="千里传音";
	$StrategySubBtnYLi[0,5]="5";
	$StrategySubBtnIte[0,5]="113010151 5";
	$StrategySubBtnSrc[0,5]="74";
	if ($Now_Script == 1) $StrategySubBtnMsg[0,5]=$Get_Dialog_GeShi[31401] @
		"<t>点击聊天区域上方的喇叭按钮，可呼出全服喊话界面。</t><b/>" @
		"<t>每次喊话需要消耗一个<t>" @ GetItemName(105109041,1) @"<t>或</t>" @ GetItemName(105109042,1) @ "<t>，专享独有的聊天频道，无与伦比</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：使用一次全服喊话，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[0,6]="写信";
	$StrategySubBtnYLi[0,6]="3";
	$StrategySubBtnIte[0,6]="113010152 10";
	$StrategySubBtnSrc[0,6]="76";
	if ($Now_Script == 1) $StrategySubBtnMsg[0,6]=$Get_Dialog_GeShi[31401] @
		"<t>可以通过写信，像自己的好友留言，并且寄送物品。</t><b/>" @
		"<t>可以在 </t>" @ "<t>昆仑</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010102);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010102,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>查看、收取、寄送邮件</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：选择一个好友，给ta写一封信，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[0,7]="竞技";
	$StrategySubBtnYLi[0,7]="";
	$StrategySubBtnIte[0,7]="";
	$StrategySubBtnSrc[0,7]="";
	if ($Now_Script == 1) $StrategySubBtnMsg[0,7]=$Get_Dialog_GeShi[31401] @
		$Get_Dialog_GeShi[31409] @ "攻击模式简介：</t><b/>" @
		"<t>通过左上角【人物头像】区域附近切换攻击模式</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "善恶值：</t><b/>" @
		"<t>击败白名玩家，会增加善恶值</t><b/>" @
		"<t>善恶值会影响死亡惩罚</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "死亡掉落：</t><b/>" @
		"<t>在所有的野外、地宫、主城等（非副本）地图，死亡后均有几率掉落包裹内的物品、身上的装备、以及身上携带的金币</t><b/>" @
		"<t>善恶值越高，死亡掉落概率越高</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "死亡保护：</t><b/>" @
		"<t>可以通过锁定装备，来避免装备在死亡后掉落，被锁定的装备有几率被损毁，需要修复后才可使用</t><b/>" @
		"<t>在包裹内存放</t>" @ GetItemName(105109051,1) @ "<t>，每次死亡会消耗一枚</t>" @ GetItemName(105109051,1) @ "<t>，同时避免其他损失</t></t>";

	//------------------常用功能--------------------
	$StrategySubBtnTit[1,0]="自动战斗";
	$StrategySubBtnYLi[1,0]="2";
	$StrategySubBtnIte[1,0]="105020303 50";
	$StrategySubBtnSrc[1,0]="78";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,0]=$Get_Dialog_GeShi[31401] @
		"<t>手动打怪太累，可以选择使用自动战斗功能哦。</t><b/><b/>" @
		"<t>可使用快捷键 </t>" @ $Get_Dialog_GeShi[31409] @ "Alt + Z </t>" @ "<t>打开自动战斗设置界面，进行喝药保护、技能施放、拾取筛选等操作</t><b/><b/>" @
		"<t>可使用快捷键 </t>" @ $Get_Dialog_GeShi[31409] @ " = </t>" @ "<t>直接开启自动战斗</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：使用一次自动战斗功能，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[1,1]="双倍经验";
	$StrategySubBtnYLi[1,1]="5";
	$StrategySubBtnIte[1,1]="105028012 1";
	$StrategySubBtnSrc[1,1]="80";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,1]=$Get_Dialog_GeShi[31401] @
		"<t>双倍经验状态下，击败怪物以及部分活动完成时，获得的经验奖励都是双倍</t><b/>" @
		"<t>系统每周免费赠送10小时的双倍时间</t><b/>" @
		"<t>昆仑</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010113);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010113,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>处领取每周免费双倍时间，以及存取双倍时间</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：领取一次每周免费双倍时间，即可获得历练奖励。</t></t>";


	$StrategySubBtnTit[1,2]="学习技能";
	$StrategySubBtnYLi[1,2]="2";
	$StrategySubBtnIte[1,2]="105020353 50";
	$StrategySubBtnSrc[1,2]="82";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,2]=$Get_Dialog_GeShi[31401] @
		"<t>技能界面快捷键：</t>" @ $Get_Dialog_GeShi[31409] @ "Alt + K </t>" @ "<b/>" @
		"<t>所有技能的学习都需要相应的技能书</t><b/>" @
		"<t>昆仑</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010119);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010119,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>处购买基础的技能书</t><b/>" @
		"<t>高等技能书，在</t>" @ $Get_Dialog_GeShi[31409] @ "镇魔殿 </t>" @ "<t>击败尸王有几率掉落</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：学习一个需求等级40级以上的职业技能，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[1,3]="升级技能";
	$StrategySubBtnYLi[1,3]="3";
	$StrategySubBtnIte[1,3]="105020353 50";
	$StrategySubBtnSrc[1,3]="84";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,3]=$Get_Dialog_GeShi[31401] @
		"<t>技能界面快捷键：</t>" @ $Get_Dialog_GeShi[31409] @ "Alt + K </t>" @ "<b/>" @
		"<t>技能升级后，技能效果将变的更加强大</t><b/>" @
		"<t>点击技能图标上方的 箭头 升级技能</t><b/>" @
		"<t>升级技能需要满足一定的等级条件</t><b/>" @
		"<t>升级技能需要消耗一定的金钱以及材料</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：升级一次职业技能，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[1,4]="分解装备";
	$StrategySubBtnYLi[1,4]="5";
	$StrategySubBtnIte[1,4]="116010001 10";
	$StrategySubBtnSrc[1,4]="86";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,4]=$Get_Dialog_GeShi[31401] @
		"<t>多余的装备，可以分解，分解装备后，有几率获得</t>" @  GetItemName(116010002,1) @ "<t>、</t>" @ GetItemName(116010003,1) @ "<b/>" @
		"<t>打开包裹（</t>" @ $Get_Dialog_GeShi[31409] @ "快捷键 Alt + B </t>" @ "<t>）后，点击包裹栏位下方的</t>" @ $Get_Dialog_GeShi[31409] @ "分解</t><t>按钮，即可分解装备</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：成功分解一件装备，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[1,5]="强化装备";
	$StrategySubBtnYLi[1,5]="8";
	$StrategySubBtnIte[1,5]="116010002 5";
	$StrategySubBtnSrc[1,5]="88";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,5]=$Get_Dialog_GeShi[31401] @
		"<t>装备强化后，根据装备的基础属性和强化等级，极大的提高装备的属性</t><b/>" @
		"<t>强化师：昆仑</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010121);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010121,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次装备强化操作，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[1,6]="鉴定装备";
	$StrategySubBtnYLi[1,6]="8";
	$StrategySubBtnIte[1,6]="113050004 2";
	$StrategySubBtnSrc[1,6]="90";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,6]=$Get_Dialog_GeShi[31401] @
		"<t>装备鉴定成功后，装备将获得新的鉴定属性</t><b/>" @
		"<t>鉴定师：昆仑</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010122);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010122,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次装备鉴定操作，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[1,7]="装备重铸";
	$StrategySubBtnYLi[1,7]="8";
	$StrategySubBtnIte[1,7]="116010001 10";
	$StrategySubBtnSrc[1,7]="92";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,7]=$Get_Dialog_GeShi[31401] @
		"<t>装备重铸，可以洗去无用的鉴定属性而获得全新属性。</t><b/>" @
		"<t>重铸师：昆仑</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010122);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010122,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次装备重铸操作，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[1,8]="装备精炼";
	$StrategySubBtnYLi[1,8]="8";
	$StrategySubBtnIte[1,8]="116010001 10";
	$StrategySubBtnSrc[1,8]="94";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,8]=$Get_Dialog_GeShi[31401] @
		"<t>装备精炼，可以将鉴定属性提高至上限。</t><b/>" @
		"<t>精炼师：昆仑</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010122);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010122,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次装备精炼操作，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[1,9]="装备涅槃";
	$StrategySubBtnYLi[1,9]="8";
	$StrategySubBtnIte[1,9]="116010002 10";
	$StrategySubBtnSrc[1,9]="96";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,9]=$Get_Dialog_GeShi[31401] @
		"<t>装备涅槃，可以重新随机生成一次装备的成长率</t><b/>" @
		"<t>装备成长率越高，其被强化获得的增加就越大</t><b/>" @
		"<t>涅槃师：昆仑</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010121);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010121,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次装备涅槃操作，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[1,10]="神石合成";
	$StrategySubBtnYLi[1,10]="8";
	$StrategySubBtnIte[1,10]="116010003 10";
	$StrategySubBtnSrc[1,10]="98";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,10]=$Get_Dialog_GeShi[31401] @
		"<t>造化神石合成，造化神石可使装备强化失败时不会有损失，并且提高强化成功几率</t><b/>" @
		"<t>神石合成师：昆仑</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010143);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010143,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次神石合成，即可获得历练奖励。</t></t>";


	$StrategySubBtnTit[1,11]="鉴宝";
	$StrategySubBtnYLi[1,11]="8";
	$StrategySubBtnIte[1,11]="105310001 1";
	$StrategySubBtnSrc[1,11]="100";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,11]=$Get_Dialog_GeShi[31401] @
		"<t>在获得</t>" @ GetItemName(105300016,1) @ "<t>可以寻找鉴宝师进行鉴宝，有几率获得各种珍惜道具</t><b/>" @
		"<t>鉴宝师：昆仑</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010120);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010120,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次鉴宝，即可获得历练奖励。</t></t>";
	//------------------日常活动--------------------
	$StrategySubBtnTit[2,0]="每日活跃";
	$StrategySubBtnYLi[2,0]="3";
	$StrategySubBtnIte[2,0]="105020303 50";
	$StrategySubBtnSrc[2,0]="102";
	if ($Now_Script == 1) $StrategySubBtnMsg[2,0]=$Get_Dialog_GeShi[31401] @
		"<t>每天达到对应的活跃度，即可领取活跃度礼包</t><b/>" @
		"<t>点击打开</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"closestrategywndgui();OpenOrCloseUpLinePartyWndGui();SetUpLineParty(2);\",\"" @ $Get_Dialog_GeShi[31214] @ "领奖界面" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>查看今日活跃</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：达到一次活跃99，领取日活跃礼包（豪华），即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[2,1]="签到打卡";
	$StrategySubBtnYLi[2,1]="3";
	$StrategySubBtnIte[2,1]="105028012 1";
	$StrategySubBtnSrc[2,1]="104";
	if ($Now_Script == 1) $StrategySubBtnMsg[2,1]=$Get_Dialog_GeShi[31401] @
		"<t>每天签到可领取签到礼包，每月累计相应的签到天数可领取每月活跃礼包</t><b/>" @
		"<t>点击打开</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"closestrategywndgui();OpenOrCloseUpLinePartyWndGui();SetUpLineParty(3);\",\"" @ $Get_Dialog_GeShi[31214] @ "领奖界面" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>进行签到</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次签到，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[2,2]="经验获得";
	$StrategySubBtnYLi[2,2]="12";
	$StrategySubBtnIte[2,2]="105104919 1";
	$StrategySubBtnSrc[2,2]="106";
	if ($Now_Script == 1) $StrategySubBtnMsg[2,2]=$Get_Dialog_GeShi[31401] @
		"<t>经验获得主要通过击败怪物、日常活动、任务获得</t><b/>" @
		"<t>经验活动和日常任务推荐：</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "冰火试炼 </t>" @ "<t>★★★★★</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "时空裂痕 </t>" @ "<t>★★★★★</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "血魔封印 </t>" @ "<t>★★★★★</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "师门尽忠 </t>" @ "<t>★★★★</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "紫星传功 </t>" @ "<t>★★★★</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "炼 魔 渊 </t>" @ "<t>★★★★</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "悬赏缉凶 </t>" @ "<t>★★★★</t><b/>" @
		"<t>点击打开</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"closestrategywndgui();OpenOrCloseActivityWnd();\",\"" @ $Get_Dialog_GeShi[31214] @ "活动大全界面" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>可查看所有日常活动</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：角色等级达到50级，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[2,3]="道具获得";
	$StrategySubBtnYLi[2,3]="8";
	$StrategySubBtnIte[2,3]="112010056 1";
	$StrategySubBtnSrc[2,3]="108";
	if ($Now_Script == 1) $StrategySubBtnMsg[2,3]=$Get_Dialog_GeShi[31401] @
		"<t>装备类道具主要由击败怪物（尤其是首领怪物）、生活技能（铸造、制器、裁缝）获得</t><b/>" @
		"<t>其他道具主要由完成日常活动、开启礼包、生活技能、击败怪物等多种多样的方式获得</t><b/>" @
		"<t>重点活动推荐：</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "炼 魔 渊 </t>" @ "<t>★★★★★</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "藏 宝 图 </t>" @ "<t>★★★★★</t><b/>" @
		"<t>点击打开</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"closestrategywndgui();OpenOrCloseActivityWnd();\",\"" @ $Get_Dialog_GeShi[31214] @ "活动大全界面" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>可查看所有日常活动</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：挖取10张藏宝图，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[2,4]="金钱获得";
	$StrategySubBtnYLi[2,4]="8";
	$StrategySubBtnIte[2,4]="105021061 1";
	$StrategySubBtnSrc[2,4]="110";
	if ($Now_Script == 1) $StrategySubBtnMsg[2,4]=$Get_Dialog_GeShi[31401] @
		"<t>金币是昆仑决的流通货币，购买、修理、技能升级、以及其他功能都需要消耗金币</t><b/>" @
		"<t>金币获得方式：</t><b/>" @
		"<t>1、通过向商店出售装备、材料、杂物获得</t><b/>" @
		"<t>2、参加各类活动获得</t><b/>" @
		"<t>重点活动推荐：</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "押    镖 </t>" @ "<t>★★★★★</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "黄金宝藏 </t>" @ "<t>★★★★★</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "藏 宝 图 </t>" @ "<t>★★★★</t><b/>" @
		"<t>点击打开</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"closestrategywndgui();OpenOrCloseActivityWnd();\",\"" @ $Get_Dialog_GeShi[31214] @ "活动大全界面" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>可查看所有日常活动</t><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次黄金宝藏副本，即可获得历练奖励。</t></t>";


	$StrategySubBtnTit[2,5]="竞技活动";
	$StrategySubBtnYLi[2,5]="10";
	$StrategySubBtnIte[2,5]="105021051 1";
	$StrategySubBtnSrc[2,5]="112";
	if ($Now_Script == 1) $StrategySubBtnMsg[2,5]=$Get_Dialog_GeShi[31401] @
		"<t>竞技活动是玩家可以和其他玩家同台竞技的平台</t><b/>" @
		"<t>重点活动推荐：</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "攻 城 战 </t>" @ "<t>★★★★★</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "冰火试炼 </t>" @ "<t>★★★★</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "刀剑神域 </t>" @ "<t>★★★★</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "鸿蒙试炼 </t>" @ "<t>★★★</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "幻境争霸 </t>" @ "<t>★★★</t><b/>" @
		"<t>点击打开</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"closestrategywndgui();OpenOrCloseActivityWnd();\",\"" @ $Get_Dialog_GeShi[31214] @ "活动大全界面" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>可查看所有日常活动</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：参加一次刀剑神域，并坚持战斗到结束，即可获得历练奖励。</t></t>";
	//------------------生活技能--------------------
	$StrategySubBtnTit[3,0]="采矿";
	$StrategySubBtnYLi[3,0]="5";
	$StrategySubBtnIte[3,0]="105021505 1";
	$StrategySubBtnSrc[3,0]="114";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,0]= $Get_Dialog_GeShi[31401] @
		"<t>采矿获得的矿石，可用于【铸造】技能锻造武器，也可卖给商店获得金币。采矿有几率获得</t>" @ GetItemName(105300001,1) @ "<t>。</t><b/>" @
		"<t>可在</t>" @ $Get_Dialog_GeShi[31409] @ "陨仙窟" @ "</t><t>、</t>" @ $Get_Dialog_GeShi[31409] @ "落日神陵" @ "</t><t>、</t>" @ $Get_Dialog_GeShi[31409] @ "深海迷宫" @ "</t><t>等各个野外、地宫地图寻找到矿脉。</t><b/><b/>" @
		"<t>技能学习： </t>" @ "<t>蓬莱</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100016);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100016,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次采矿，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[3,1]="伐木";
	$StrategySubBtnYLi[3,1]="5";
	$StrategySubBtnIte[3,1]="105021505 1";
	$StrategySubBtnSrc[3,1]="116";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,1]=$Get_Dialog_GeShi[31401] @
		"<t>伐木获得的木材，可用于【制器】技能、【符咒】技能，也可卖给商店获得金币。</t><b/>" @
		"<t>可在</t>" @ $Get_Dialog_GeShi[31409] @ "望仙谷" @ "</t><t>、</t>" @ $Get_Dialog_GeShi[31409] @ "苍山雪海" @ "</t><t>、</t>" @  $Get_Dialog_GeShi[31409] @ "云梦泽" @ "</t><t>等各个野外地图寻找到木材。</t><b/><b/>" @
		"<t>技能学习： </t>" @ "<t>蓬莱</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(411010002);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(411010002,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次伐木，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[3,2]="钓鱼";
	$StrategySubBtnYLi[3,2]="5";
	$StrategySubBtnIte[3,2]="105021505 1";
	$StrategySubBtnSrc[3,2]="118";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,2]=$Get_Dialog_GeShi[31401] @
		"<t>钓鱼获得的海鲜、河鲜，可用于【烹饪】技能，也可卖给商店获得金币。</t><b/>" @
		"<t>可在</t>" @ $Get_Dialog_GeShi[ 31409 ] @ "望仙谷" @ "</t><t>、</t>" @ $Get_Dialog_GeShi[ 31409 ] @ "苍山雪海" @ "</t><t>、</t>" @  $Get_Dialog_GeShi[ 31409 ] @ "云梦泽" @ "</t><t>等各个野外地图寻找到渔群。</t><b/><b/>" @
		"<t>技能学习： </t>" @ "<t>蓬莱</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100012);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100012,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次钓鱼，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[3,3]="采药";
	$StrategySubBtnYLi[3,3]="5";
	$StrategySubBtnIte[3,3]="105021505 1";
	$StrategySubBtnSrc[3,3]="120";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,3]=$Get_Dialog_GeShi[31401] @
		"<t>采药获得的药材，可用于【炼丹】技能，也可卖给商店获得金币。</t><b/>" @
		"<t>可在</t>" @ $Get_Dialog_GeShi[ 31409 ] @ "望仙谷" @ "</t><t>、</t>" @ $Get_Dialog_GeShi[ 31409 ] @ "苍山雪海" @ "</t><t>、</t>" @  $Get_Dialog_GeShi[ 31409 ] @ "云梦泽" @ "</t><t>等各个野外地图寻找到草药。</t><b/><b/>" @
		"<t>技能学习： </t>" @ "<t>蓬莱</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100010);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100010,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次采药，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[3,4]="铸造";
	$StrategySubBtnYLi[3,4]="10";
	$StrategySubBtnIte[3,4]="105021510 1";
	$StrategySubBtnSrc[3,4]="122";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,4]=$Get_Dialog_GeShi[31401] @
		"<t>【铸造】技能，可以锻造出紫色、橙色武器，以及金条、金锭、金砖。</t><b/>" @
		"<t>铸造所需的配方和材料，由怪物死亡随机掉落，铸造所需的矿物，由【采矿】所得。</t><b/><b/>" @
		"<t>技能学习： </t>" @ "<t>蓬莱</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100058);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100058,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次铸造，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[3,5]="裁缝";
	$StrategySubBtnYLi[3,5]="10";
	$StrategySubBtnIte[3,5]="105021510 1";
	$StrategySubBtnSrc[3,5]="124";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,5]=$Get_Dialog_GeShi[31401] @
		"<t>【裁缝】技能，可以锻造出紫色、橙色防具，以及乾坤袋。</t><b/>" @
		"<t>裁缝所需的配方和材料，由怪物死亡随机掉落。</t><b/><b/>" @
		"<t>技能学习： </t>" @ "<t>蓬莱</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100005);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100005,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次裁缝，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[3,6]="制器";
	$StrategySubBtnYLi[3,6]="10";
	$StrategySubBtnIte[3,6]="105021510 1";
	$StrategySubBtnSrc[3,6]="126";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,6]=$Get_Dialog_GeShi[31401] @
		"<t>【制器】技能，可以锻造出紫色、橙色首饰，以及仓库扩展包。</t><b/>" @
		"<t>制器所需的配方和材料，由怪物死亡随机掉落，部分材料由【伐木】所得。</t><b/><b/>" @
		"<t>技能学习： </t>" @ "<t>蓬莱</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100060);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100060,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次制器，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[3,7]="符咒";
	$StrategySubBtnYLi[3,7]="10";
	$StrategySubBtnIte[3,7]="105021510 1";
	$StrategySubBtnSrc[3,7]="128";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,7]=$Get_Dialog_GeShi[31401] @
		"<t>【符咒】技能，可以制造各类符咒，包括鉴宝符、鉴定符、道士施法材料、以及其他辅助战斗的符咒。</t><b/>" @
		"<t>符咒所需的配方和材料，由怪物死亡随机掉落，部分材料由【伐木】所得。</t><b/><b/>" @
		"<t>技能学习： </t>" @ "<t>蓬莱</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100003);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100003,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次制符，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[3,8]="炼丹";
	$StrategySubBtnYLi[3,8]="10";
	$StrategySubBtnIte[3,8]="105021510 1";
	$StrategySubBtnSrc[3,8]="130";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,8]=$Get_Dialog_GeShi[31401] @
		"<t>【炼丹】技能，可以制造各类丹药，包括回复类丹药、状态增益丹药、法师施法材料、以及特殊用途的丹药。</t><b/>" @
		"<t>炼丹所需的配方和材料，由怪物死亡随机掉落，部分材料由【采药】所得。</t><b/><b/>" @
		"<t>技能学习： </t>" @ "<t>蓬莱</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100004);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100004,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次炼丹，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[3,9]="烹饪";
	$StrategySubBtnYLi[3,9]="10";
	$StrategySubBtnIte[3,9]="105021510 1";
	$StrategySubBtnSrc[3,9]="132";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,9]=$Get_Dialog_GeShi[31401] @
		"<t>【烹饪】技能，可以制造各类丹药，包括回复类膳食、状态增益膳食、战士施法材料、以及特殊用途的药膳。</t><b/>" @
		"<t>烹饪所需的配方和材料，由怪物死亡随机掉落，部分材料由【钓鱼】所得。</t><b/><b/>" @
		"<t>技能学习： </t>" @ "<t>蓬莱</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100059);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100059,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次烹饪，即可获得历练奖励。</t></t>";
	//------------------地图攻略--------------------
	$StrategySubBtnTit[4,0]="蓬莱";
	$StrategySubBtnYLi[4,0]="";
	$StrategySubBtnIte[4,0]="";
	$StrategySubBtnSrc[4,0]="";
	if ($Now_Script == 1) $StrategySubBtnMsg[4,0]=$Get_Dialog_GeShi[31401] @
		"<t>蓬莱乃新手玩家的出生地，在此踏入昆仑世界开启修仙之途。</t><b/><b/>" @
		"<t>蓬莱可参加的活动有：</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "师门尽忠</t><t> 可寻找</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100001);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100001,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>参加</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "聆经悟道</t><t> 可寻找</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100001);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100001,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>参加</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "首座论经</t><t> 可寻找</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100001);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100001,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>参加</t>";

	$StrategySubBtnTit[4,1]="昆仑";
	$StrategySubBtnYLi[4,1]="";
	$StrategySubBtnIte[4,1]="";
	$StrategySubBtnSrc[4,1]="";
	if ($Now_Script == 1) $StrategySubBtnMsg[4,1]=$Get_Dialog_GeShi[31401] @
		"<t>昆仑，昆仑界的主城，最繁华之所在。</t><b/>" @
		"<t>昆仑城内提供各种服务：</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "邮件使者  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010102);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010102,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "传送使者  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010103);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010103,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "仓    库  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010101);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010101,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "杂 货 铺  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010111);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010111,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "药    店  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010115);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010115,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "技 能 书  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010119);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010119,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "帮派相关  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010107);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010107,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "双倍经验  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010113);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010113,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "摆    摊  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(810010108);\",\"" @ $Get_Dialog_GeShi[31214] @ "集市" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "装备相关  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010123);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010123,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010122);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010122,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010121);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010121,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "宝石相关  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010123);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010123,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "神石合成  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010143);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010143,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "鉴    宝  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010120);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010120,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "制 器 台  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010139);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010139,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "锻 造 台  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010124);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010124,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "烹 饪 鼎  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010127);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010127,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "缝 纫 台  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010126);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010126,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "炼 丹 炉  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010125);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010125,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "制 符 案  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010128);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010128,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "</t>";

	$StrategySubBtnTit[4,2]="封魔城";
	$StrategySubBtnYLi[4,2]="";
	$StrategySubBtnIte[4,2]="";
	$StrategySubBtnSrc[4,2]="";
	if ($Now_Script == 1) $StrategySubBtnMsg[4,2]=$Get_Dialog_GeShi[31401] @
		"<t>封魔城，主城。</t><b/>" @
		"<t>封魔城允许被玩家占领，占领帮派的帮主自动成为封魔城主。</t><b/>" @
		"<t>适合等级：50级以上</t><b/>" @
		"<t>重点推荐：</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "押镖 </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(411190001);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(411190001,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：封魔城属于</t>" @ $Get_Dialog_GeShi[31499] @ "强制开启全体攻击模式</t>" @ $Get_Dialog_GeShi[31421] @ "的高危地图，死亡后有可能</t>" @ $Get_Dialog_GeShi[31499] @ "<t>掉落装备</t></t>";

	$StrategySubBtnTit[4,3]="冰火试炼";
	$StrategySubBtnYLi[4,3]="";
	$StrategySubBtnIte[4,3]="";
	$StrategySubBtnSrc[4,3]="";
	if ($Now_Script == 1) $StrategySubBtnMsg[4,3]=$Get_Dialog_GeShi[31401] @
		"<t>冰火试炼，试炼地图，完成试炼任务可获得大量经验。</t><b/>" @
		"<t>适合等级：30 - 70</t><b/>" @
		"<t>传送入口 昆仑  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010141);\",\"" @ $Get_Dialog_GeShi[31214] @  GetNpcData(410010141,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		"<t>重点推荐：</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "试炼任务  降妖除魔</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "试炼任务  寒冰之魂</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "试炼任务  烈火之炎</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "试炼任务  铲除冰蜥</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "试炼任务  铲除火蜥</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "试炼任务  乔装采药</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "试炼任务  冰火之珠</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "试炼任务  铲除翼妖</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：冰火试炼属于</t>" @ $Get_Dialog_GeShi[31499] @ "强制开启全体攻击模式</t>" @ $Get_Dialog_GeShi[31421] @ "的高危地图，死亡后有可能</t>" @ $Get_Dialog_GeShi[31499] @ "<t>掉落装备</t></t>";

	$StrategySubBtnTit[4,4]="望仙谷";
	$StrategySubBtnYLi[4,4]="";
	$StrategySubBtnIte[4,4]="";
	$StrategySubBtnSrc[4,4]="";
	if ($Now_Script == 1) $StrategySubBtnMsg[4,4]=$Get_Dialog_GeShi[31401] @
		"<t>望仙谷，野外地图</t><b/>" @
		"<t>适合等级：30 - 45</t><b/>" @
		"<t>重点推荐：</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "任务 悬赏缉凶  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(411010010);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(411010010,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "任务 斩妖除魔  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(411010010);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(411010010,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "传送 陨 仙 窟  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(811010105);\",\"" @ $Get_Dialog_GeShi[31214] @ "陨仙窟入口" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "首领 青丘狐王  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(811010103);\",\"" @ $Get_Dialog_GeShi[31214] @ "首领领地入口" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "</t>";

	$StrategySubBtnTit[4,5]="陨仙窟";
	$StrategySubBtnYLi[4,5]="";
	$StrategySubBtnIte[4,5]="";
	$StrategySubBtnSrc[4,5]="";
	if ($Now_Script == 1) $StrategySubBtnMsg[4,5]=$Get_Dialog_GeShi[31401] @
		"<t>陨仙窟，地宫地图</t><b/>" @
		"<t>适合等级：35 - 50</t><b/>" @
		"<t>重点推荐：</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "首领 幽城鬼王  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(811280200);\",\"" @ $Get_Dialog_GeShi[31214] @ "落日神陵二层" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		"<t>地宫掉落：</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "紫色装备（30-40级）</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "生活技能配方、材料（1、2级） </t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：陨仙窟二层属于首领怪物领地，进入后将被压制属性，可使用。</t>" @ GetItemName(114070001,1) @ $Get_Dialog_GeShi[31421] @ "暂时性解除压制。</t></t>";

	$StrategySubBtnTit[4,6]="苍山雪海";
	$StrategySubBtnYLi[4,6]="";
	$StrategySubBtnIte[4,6]="";
	$StrategySubBtnSrc[4,6]="";
	if ($Now_Script == 1) $StrategySubBtnMsg[4,6]=$Get_Dialog_GeShi[31401] @
		"<t>苍山雪海，野外地图</t><b/>" @
		"<t>适合等级：45 - 60</t><b/>" @
		"<t>重点推荐：</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "任务 悬赏缉凶  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(411010010);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(411010010,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "任务 斩妖除魔  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(411010010);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(411010010,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "传送 落日神陵  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(811010105);\",\"" @ $Get_Dialog_GeShi[31214] @ "落日神陵入口" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "首领 雪海魔君  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(811010103);\",\"" @ $Get_Dialog_GeShi[31214] @ "首领领地入口" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "</t>";

	$StrategySubBtnTit[4,7]="落日神陵";
	$StrategySubBtnYLi[4,7]="";
	$StrategySubBtnIte[4,7]="";
	$StrategySubBtnSrc[4,7]="";
	if ($Now_Script == 1) $StrategySubBtnMsg[4,7]=$Get_Dialog_GeShi[31401] @
		"<t>落日神陵，地宫地图</t><b/>" @
		"<t>适合等级：50 - 65</t><b/>" @
		"<t>重点推荐：</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "首领 玄冰魔王  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(811280300);\",\"" @ $Get_Dialog_GeShi[31214] @ "落日神陵三层" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "传送 镇 魔 殿  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(411180001);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(411180001,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		"<t>地宫掉落：</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "紫色装备（50-60级）</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "生活技能配方、材料（3、4级） </t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：落日神陵三层属于首领怪物领地，进入后将被压制属性，可使用。</t>" @ GetItemName(114070002,1) @ $Get_Dialog_GeShi[31421] @ "暂时性解除压制。</t></t>";
	//------------------首领怪物--------------------
	$StrategySubBtnTit[5,0]="荣耀使者";
	$StrategySubBtnYLi[5,0]="10";
	$StrategySubBtnIte[5,0]="105105352 1";
	$StrategySubBtnSrc[5,0]="134";
	if ($Now_Script == 1) $StrategySubBtnMsg[5,0]=$Get_Dialog_GeShi[31401] @
		"<t>荣耀使者，唯一掉落帮派创建令</t>" @ GetItemName(105109052,1) @ "<t>的首领怪物</t><b/>" @
		"<t>刷新位置  </t>" @ $Get_Dialog_GeShi[31409] @ "昆仑 寒池小镇</t>" @ "<b/>" @
		"<t>刷新时间  </t>" @ $Get_Dialog_GeShi[31409] @ "6</t>" @ "<t>小时</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次击败，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[5,1]="雕像使者";
	$StrategySubBtnYLi[5,1]="10";
	$StrategySubBtnIte[5,1]="105105352 1";
	$StrategySubBtnSrc[5,1]="136";
	if ($Now_Script == 1) $StrategySubBtnMsg[5,1]=$Get_Dialog_GeShi[31401] @
		"<t>荣耀使者，唯一掉落获取攻城权限</t>" @ GetItemName(105109053,1) @ "<t>的首领怪物</t><b/>" @
		"<t>刷新位置  </t>" @ $Get_Dialog_GeShi[31409] @ "封魔城 神弃谷</t>" @ "<b/>" @
		"<t>刷新时间  </t>" @ $Get_Dialog_GeShi[31409] @ "6</t>" @ "<t>小时</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次击败，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[5,2]="青丘狐王";
	$StrategySubBtnYLi[5,2]="10";
	$StrategySubBtnIte[5,2]="105105301 1";
	$StrategySubBtnSrc[5,2]="138";
	if ($Now_Script == 1) $StrategySubBtnMsg[5,2]=$Get_Dialog_GeShi[31401] @
		"<t>青丘狐王，野外首领怪物</t><b/>" @
		"<t>怪物掉落  </t>" @ $Get_Dialog_GeShi[31409] @ "50级橙色装备的铸造材料</t><b/>" @
		"<t>刷新位置  </t>" @ $Get_Dialog_GeShi[31409] @ "望仙谷 首领领地</t>" @ "<b/>" @
		"<t>刷新时间  </t>" @ $Get_Dialog_GeShi[31409] @ "6</t>" @ "<t>小时</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次击败，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[5,3]="幽城鬼王";
	$StrategySubBtnYLi[5,3]="10";
	$StrategySubBtnIte[5,3]="105105301 1";
	$StrategySubBtnSrc[5,3]="140";
	if ($Now_Script == 1) $StrategySubBtnMsg[5,3]=$Get_Dialog_GeShi[31401] @
		"<t>幽城鬼王，地宫首领怪物</t><b/>" @
		"<t>怪物掉落  </t>" @ $Get_Dialog_GeShi[31409] @ "50级橙色装备、神器</t><b/>" @
		"<t>刷新位置  </t>" @ $Get_Dialog_GeShi[31409] @ "陨仙窟二层</t>" @ "<b/>" @
		"<t>刷新时间  </t>" @ $Get_Dialog_GeShi[31409] @ "8</t>" @ "<t>小时</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：陨仙窟二层属于首领怪物领地，进入后将被压制属性，可使用。</t>" @ GetItemName(114070001,1) @ $Get_Dialog_GeShi[31421] @ "暂时性解除压制。</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次击败，即可获得历练奖励。</t></t>";

	$StrategySubBtnTit[5,4]="雪海魔君";
	$StrategySubBtnYLi[5,4]="10";
	$StrategySubBtnIte[5,4]="105105302 1";
	$StrategySubBtnSrc[5,4]="142";
	if ($Now_Script == 1) $StrategySubBtnMsg[5,4]=$Get_Dialog_GeShi[31401] @
		"<t>雪海魔君，野外首领怪物</t><b/>" @
		"<t>怪物掉落  </t>" @ $Get_Dialog_GeShi[31409] @ "60级橙色装备的铸造材料</t><b/>" @
		"<t>刷新位置  </t>" @ $Get_Dialog_GeShi[31409] @ "苍山雪海 冰封王座</t>" @ "<b/>" @
		"<t>刷新时间  </t>" @ $Get_Dialog_GeShi[31409] @ "6</t>" @ "<t>小时</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "提示：完成一次击败，即可获得历练奖励。</t></t>";
}
function GetStrategySubBtnNum(%Type)//根据主控件返回需要多少个子控件
{
	//if ( %StrategySubBtnNum[ %Type ] $= "" )
	//{
	%StrategySubBtnNum[%Type] = 0;
	for (%i = 0; %i <=99; %i++)
	{
		//echo( "$StrategySubBtnTit[ " @ %Type @ "," @  %i @ "]==" @ $StrategySubBtnTit[ %Type, %i ] );
		if ($StrategySubBtnTit[%Type,%i] $= "")
			break;
		%StrategySubBtnNum[%Type]++;
	}
	//}
	return %StrategySubBtnNum[%Type];
}
Schedule(30000,0,"SetStrategyBtnText");
//■■■■【攻略界面】■■■■【子控件文本】■■■■■■■
