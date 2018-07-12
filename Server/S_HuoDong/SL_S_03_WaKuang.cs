//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//挖矿
//==================================================================================

//SpNewCj2( 0, 551010101, "10.1963 79.4818 126.428", 0, 180, "1 1 1" );
//107020001	劣质矿锄	工具
//107020002	优质矿锄	工具
//107020003	精炼矿锄	工具
//107020101	鹤嘴锄	工具
//107020201	玄铁锄	工具
//105109101	鹤嘴锄增补符
//105109102	鹤嘴锄增补符
//105109103	鹤嘴锄增补符
//105109111	玄铁锄增补符
//105109112	玄铁锄增补符
//105109113	玄铁锄增补符
//105105300	银叶子
//105105301	金叶子
//105105302	金锭
//105105303	金条
//105105304	金砖
//105105305	钻石

//■■■■【挖矿】■■■■【灵石矿脉触发】■■■■■■■
//■■■■【挖矿】■■■■【神石矿脉触发】■■■■■■■
//■■■■【挖矿】■■■■【杂矿计算函数】■■■■■■■
//■■■■【挖矿】■■■■【矿锄修复函数】■■■■■■■
//■■■■【挖矿】■■■■【灵晶神石使用】■■■■■■■
//■■■■【挖矿】■■■■【璞玉额外产出】■■■■■■■
//■■■■【挖矿】■■■■【灵脉商店展示】■■■■■■■

//■■■■【挖矿】■■■■【灵石矿脉触发】■■■■■■■
function TriggerEvent_551011501(%Player,%Event,%EventID){ TriggerEvent_551011501_551011502(%Player,%Event,%EventID); }//灵石矿脉
function TriggerEvent_551011502(%Player,%Event,%EventID){ TriggerEvent_551011501_551011502(%Player,%Event,%EventID); }//灵石矿脉
function TriggerEvent_551011501_551011502(%Player,%Event,%EventID)
{
	%ItemID = %Player.GetEquip(13);
	%Playername = %Player.GetObjectname();
	%Ran = GetRandom(1,10000);
	//echo( "%Ran ===" @ %Ran );
	if (%Ran <= 3000){ %ItemID = 105109001; %ItemNum = 1; %MsgType = 0; }
	else if (%Ran <= 3300){ %ItemID = 105109001; %ItemNum = 2; %MsgType = 2; }
	else if (%Ran <= 3420){ %ItemID = 105109001; %ItemNum = 5; %MsgType = 2; }
	else if (%Ran <= 3470){ %ItemID = 105109001; %ItemNum = 8; %MsgType = 2; }
	else if (%Ran <= 3500){ %ItemID = 105109001; %ItemNum = 10; %MsgType = 2; }
	else if (%Ran <= 3515){ %ItemID = 105109001; %ItemNum = 20; %MsgType = 2; }
	else if (%Ran <= 3521){ %ItemID = 105109001; %ItemNum = 50; %MsgType = 2; }
	else if (%Ran <= 3524){ %ItemID = 105109001; %ItemNum = 100; %MsgType = 2; }
	else if (%Ran <= 4524){ %ItemID = 0; %ItemNum = 0; %MsgType = 0; }
	else if (%Ran <= 5524){ %ItemID = 0; %ItemNum = 0; %MsgType = 0; }
	else if (%Ran <= 6524){ %ItemID = 105105300; %ItemNum = 1; %MsgType = 0; }
	else if (%Ran <= 8000){ %ItemID = 105105301; %ItemNum = 1; %MsgType = 0; }
	else if (%Ran <= 10000){ %ItemID = 0; %ItemNum = 0; %MsgType = 0; GetSpecialjade(%Player,1,4,%EventID); }

	%Kuang = GetOne_HeZuiChu_ZaKuang(%Player,1);
	%Player.PutItem(%Kuang,1);
	if (%ItemID > 0 && %ItemNum > 0)
		%Player.Putitem(%ItemID,%ItemNum);
	%Player.Additem(4,%EventID);

	if (%MsgType == 1 )
	{
		%Msg ="好运天降，恭喜你获得" @ %ItemNum  @ "枚" @ GetItemData(%ItemID,1);
		SendOneScreenMessage(2,%Msg,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Msg @ "</t>",%Player);
	}
	if (%MsgType == 2)
	{
		%ItemName = GetItemName(%ItemID,1);
		%ItemName2 = GetItemName(%ItemID,2);

		//%Msg1 ="好运天降，恭喜你获得" @ %ItemNum  @ "枚" @ GetItemData( %ItemID, 1 );
		%Playername2 = GetPlayerZiTiName(%Player,1);
		%Playername3= GetPlayerZiTiName(%Player,2);
		%Msg2 ="<t>天降财神，</t>" @ %Playername2 @ "<t>在挖掘灵脉额外获得了</t>" @ $Get_Dialog_GeShi[31420] @ %ItemNum  @ "</t><t>枚</t>" @ %ItemName;
		%Msg3 ="<t>天降财神，</t>" @ %Playername3 @ "<t>在挖掘灵脉额外获得了</t>" @ %ItemNum  @ "<t>枚</t>" @ %ItemName2;
		//SendOneScreenMessage( 2, %Msg1, %Player );
		SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Msg2 @ "</t>");
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg3 @ "</t>", $chatMsg_Type_Normal2);
	}
}
//■■■■【挖矿】■■■■【灵石矿脉触发】■■■■■■■


//■■■■【挖矿】■■■■【神石矿脉触发】■■■■■■■
function TriggerEvent_551011511(%Player,%Event,%EventID){ TriggerEvent_551011511_551011512(%Player,%Event,%EventID); }//神石矿脉
function TriggerEvent_551011512(%Player,%Event,%EventID){ TriggerEvent_551011511_551011512(%Player,%Event,%EventID); }//神石矿脉
function TriggerEvent_551011511_551011512(%Player,%Event,%EventID)
{
	%ItemID = %Player.GetEquip(13);
	%PlayerName = GetPlayerZiTiName(%Player,1);
	%PlayerName2 = GetPlayerZiTiName(%Player,2);
	%Ran = GetRandom(1,10000);
	//echo( "%Ran ===" @ %Ran );
	if (%Ran <= 3000){ %ItemID = 105109021; %ItemNum = 1; %MsgType = 0; }
	else if (%Ran <= 3300){ %ItemID = 105109021; %ItemNum = 2; %MsgType = 2; }
	else if (%Ran <= 3420){ %ItemID = 105109021; %ItemNum = 5; %MsgType = 2; }
	else if (%Ran <= 3470){ %ItemID = 105109021; %ItemNum = 8; %MsgType = 2; }
	else if (%Ran <= 3500){ %ItemID = 105109021; %ItemNum = 10; %MsgType = 2; }
	else if (%Ran <= 3515){ %ItemID = 105109021; %ItemNum = 20; %MsgType = 2; }
	else if (%Ran <= 3521){ %ItemID = 105109021; %ItemNum = 50; %MsgType = 2; }
	else if (%Ran <= 3524){ %ItemID = 105109021; %ItemNum = 100; %MsgType = 2; }
	else if (%Ran <= 4524){ %ItemID = 0; %ItemNum = 0; %MsgType = 0; }
	else if (%Ran <= 5524){ %ItemID = 0; %ItemNum = 0; %MsgType = 0; }
	else if (%Ran <= 6524){ %ItemID = 105105300; %ItemNum = 1; %MsgType = 0; }
	else if (%Ran <= 8000){ %ItemID = 105105301; %ItemNum = 1; %MsgType = 0; }
	else if (%Ran <= 10000){ %ItemID = 0; %ItemNum = 0; %MsgType = 0;GetSpecialjade(%Player,10,4,%EventID); }

	%Kuang = GetOne_HeZuiChu_KuangDing(%Player,1);
	%Player.PutItem(%Kuang,1);
	if (%ItemID > 0 && %ItemNum > 0)
		%Player.Putitem(%ItemID,%ItemNum);
	%Player.Additem(4,%EventID);

	if (%MsgType == 1)
	{
		%Msg ="好运天降，恭喜你获得" @ %ItemNum  @ "枚" @ GetItemData(%ItemID,1);
		SendOneScreenMessage(1,%Msg,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Msg @ "</t>",%Player);
	}
	if (%MsgType == 2)
	{
		%ItemName = GetItemName(%ItemID,1);
		%ItemName2 = GetItemName(%ItemID,2);

		//%Msg1 ="好运天降，恭喜你获得" @ %ItemNum  @ "枚" @ GetItemData( %ItemID, 1 );
		%Playername2 = GetPlayerZiTiName(%Player,1);
		%Playername3= GetPlayerZiTiName(%Player,2);
		%Msg2 ="<t>天降财神，</t>" @ %Playername2 @ "<t>在挖掘灵脉额外获得了</t>" @ $Get_Dialog_GeShi[31420] @ %ItemNum  @ "</t><t>枚</t>" @ %ItemName;
		%Msg3 ="<t>天降财神，</t>" @ %Playername3 @ "<t>在挖掘灵脉额外获得了</t>" @ %ItemNum  @ "<t>枚</t>" @ %ItemName2;
		//SendOneScreenMessage( 2, %Msg1, %Player );
		SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Msg2 @ "</t>");
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg3 @ "</t>", $chatMsg_Type_Normal2);
	}
}
//■■■■【挖矿】■■■■【神石矿脉触发】■■■■■■■


//■■■■【挖矿】■■■■【矿锄修复函数】■■■■■■■
//增补符
function Trigger_105109101(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109101_105109113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,107020101,11); }
function Trigger_105109102(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109101_105109113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,107020101,58); }
function Trigger_105109103(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109101_105109113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,107020101,120); }
function Trigger_105109111(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109101_105109113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,107020201,11); }
function Trigger_105109112(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109101_105109113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,107020201,58); }
function Trigger_105109113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109101_105109113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,107020201,120); }
function Trigger_105109101_105109113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%TargetItem,%Count)
{
	%ItemID = %Player.GetEquip(13);
	%PlayerName = GetPlayerZiTiName(%Player,1);
	%Player.AttachItemObject(ItemObj,2,13);
	%Num = ItemObj.RemainUseTimes;
	//echo( "%ItemID ==" @ %ItemID @ "	%Num ===" @ %Num );
	%Itemname = GetItemData(%ItemID,1);
	if (%ItemID <= 0)
	{
		%Text = "请先装备一个矿锄";
		SendOneScreenMessage(2,%Text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Text @ "</t>",%Player);
		return;
	}
	if (%ItemID != %TargetItem)
	{
		%Text = "此道具无法给『" @ %Itemname @ "』补充使用次数";
		SendOneScreenMessage(2,%Text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Text @ "</t>",%Player);
		return;
	}
	if (%Count + %Num > 500)
	{
		%Itemname = GetItemData(%ItemID,1);
		%Text = "剩余使用次数过高，无法补充";
		SendOneScreenMessage(2,%Text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Text @ "</t>",%Player);
		return;
	}
	%Player.PutItem(%Type,-1);
	if (%Player.AddItem(1,%type))
	{
		%Player.setEquipItemUsedTimes(%ItemID,13,%Count + %Num);
		//%Text = %Itemname @　"补充成功，当前可使用次数：" @ %Count + %Num;
		%Text = %Itemname @ "补充成功，当前可使用次数：" @ %Count + %Num;
		SendOneScreenMessage(1,%Text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Text @ "</t>",%Player);
	}
}
//263016.setEquipItemUsedTimes( 107020101, 13, 15 );

//■■■■【挖矿】■■■■【矿锄修复函数】■■■■■■■


//■■■■【挖矿】■■■■【灵晶神石使用】■■■■■■■
//昆仑灵晶
//-------------------道具ID 数量 公告 根据等级处理 概率-------
$ItemGet[105109001,1]="113050002 1 0 1 200";//鉴定符 - 蓝色        200
$ItemGet[105109001,2]="113050003 1 0 1 100";//鉴定符 - 紫色        300
$ItemGet[105109001,3]="113050004 1 0 1 100";//鉴定符 - 橙色        400
$ItemGet[105109001,4]="105090501 1 0 1 400";//换魂石 - 蓝色        800
$ItemGet[105109001,5]="105090502 1 0 1 200";//换魂石 - 紫色        1000
$ItemGet[105109001,6]="105090503 1 3 1 150";//换魂石 - 橙色        1150
$ItemGet[105109001,7]="105090601 1 0 1 400";//炼魂石 - 蓝色        1550
$ItemGet[105109001,8]="105090602 1 0 1 200";//炼魂石 - 紫色        1750
$ItemGet[105109001,9]="105090603 1 3 1 150";//炼魂石 - 橙色        1900
$ItemGet[105109001,10]="105090701 1 0 1 400";//涅槃石 - 紫色        2300
$ItemGet[105109001,11]="105109031 1 2 0 160";//随机商店刷新令        2460
$ItemGet[105109001,12]="105109061 1 2 0 100";//聚英令        2560
$ItemGet[105109001,13]="105109321 1 0 1 700";//紫星石        3260
$ItemGet[105109001,14]="105105701 1 0 1 100";//星魂珠（一阶）        3360
$ItemGet[105109001,15]="116060105 1 2 0 120";//5级造化神石        3480
$ItemGet[105109001,16]="116060106 1 3 0 100";//6级造化神石        3580
$ItemGet[105109001,17]="116060107 1 3 0 76";//7级造化神石        3656
$ItemGet[105109001,18]="116060108 1 3 0 2";//8级造化神石        3658
$ItemGet[105109001,19]="116080005 1 2 0 90";//天工开物（五）        3748
$ItemGet[105109001,20]="116080006 1 3 0 80";//天工开物（六）        3828
$ItemGet[105109001,21]="116080007 1 3 0 36";//天工开物（七）        3864
$ItemGet[105109001,22]="116080008 1 3 0 1";//天工开物（八）        3865
$ItemGet[105109001,23]="116060001 1 0 0 100";//幸运石        3965
$ItemGet[105109001,24]="116060002 1 2 0 150";//吉星石        4115
$ItemGet[105109001,25]="116070001 1 0 0 200";//归元符        4315
$ItemGet[105109001,26]="105105301 1 0 0 800";//金叶子        5115
$ItemGet[105109001,27]="105105302 1 0 0 800";//金锭        5915
$ItemGet[105109001,28]="105105303 1 0 0 500";//金条        6415
$ItemGet[105109001,29]="105028001 1 0 0 373";//双倍经验丹        6788
$ItemGet[105109001,30]="105028011 1 3 0 100";//2.5倍经验丹        6888
$ItemGet[105109001,31]="113020001 1 0 0 312";//集合符        7200
$ItemGet[105109001,32]="113020011 1 0 0 300";//召唤符        7500
$ItemGet[105109001,33]="113010051 1 0 0 1900";//随机卷轴        9400
$ItemGet[105109001,34]="105109081 1 0 0 300";//攻·琥珀封印        9700
$ItemGet[105109001,35]="105109082 1 0 0 300";//防·琥珀封印        10000


//昆仑神石
//-------------------道具ID 数量 公告 根据等级处理 概率-------
$ItemGet[105109021,1] = "113050005 1 0 1 250"; //鉴定符 - 红色
$ItemGet[105109021,2] = "105090502 1 0 1 100"; //重铸石 - 紫色
$ItemGet[105109021,3] = "105090503 1 0 1 200"; //重铸石 - 橙色
$ItemGet[105109021,4] = "105090602 1 0 1 100"; //精炼石 - 紫色
$ItemGet[105109021,5] = "105090603 1 0 1 200"; //精炼石 - 橙色
$ItemGet[105109021,6] = "105090712 1 0 1 100"; //涅槃石 - 橙色
$ItemGet[105109021,7] = "105090713 1 0 1 200"; //涅槃石 - 红色
$ItemGet[105109021,8] = "116060106 1 0 0 500"; //6级造化神石
$ItemGet[105109021,9] = "116060107 1 3 0 380"; //7级造化神石
$ItemGet[105109021,10]= "116060108 1 3 0 10"; //8级造化神石
$ItemGet[105109021,11]= "116060109 1 3 0 2"; //9级造化神石
$ItemGet[105109021,12]= "116060110 1 3 0 1"; //10级造化神石
$ItemGet[105109021,13]= "116080007 1 3 0 180"; //天工开物（七）
$ItemGet[105109021,14]= "116080008 1 3 0 5"; //天工开物（八）
$ItemGet[105109021,15]= "116080009 1 3 0 1"; //天工开物（九）
$ItemGet[105109021,16]= "116080010 1 3 0 1"; //天工开物（十）
$ItemGet[105109021,17]= "116060003 1 3 0 200"; //鸿运石
$ItemGet[105109021,18]= "116070002 1 3 0 100"; //完璧符
$ItemGet[105109021,19]= "105105503 1 0 0 500"; //2级宝石升级符
$ItemGet[105109021,20]= "105105504 1 0 0 400"; //2级宝石升级符
$ItemGet[105109021,21]= "105105512 1 0 0 500"; //3级宝石升级符
$ItemGet[105109021,22]= "105105513 1 0 0 300"; //3级宝石升级符
$ItemGet[105109021,23]= "105105514 1 3 0 200"; //3级宝石升级符
$ItemGet[105109021,24]= "105105522 1 0 0 60"; //4级宝石升级符
$ItemGet[105109021,25]= "105105523 1 0 0 40"; //4级宝石升级符
$ItemGet[105109021,26]= "105105524 1 3 0 20"; //4级宝石升级符
$ItemGet[105109021,27]= "105290024 1 0 0 250"; //3级宝石造化符
$ItemGet[105109021,28]= "105290025 1 3 0 250"; //3级宝石造化符
$ItemGet[105109021,29]= "105290033 1 0 0 120"; //4级宝石造化符
$ItemGet[105109021,30]= "105290034 1 0 0 80"; //4级宝石造化符
$ItemGet[105109021,31]= "105290035 1 3 0 60"; //4级宝石造化符
$ItemGet[105109021,32]= "105180072 1 3 0 800"; //3级红宝石随机礼包
$ItemGet[105109021,33]= "105180092 1 3 0 800"; //3级绿宝石随机礼包
$ItemGet[105109021,34]= "105180152 1 3 0 550"; //3级宝石随机礼包
$ItemGet[105109021,35]= "105180073 1 3 0 30"; //4级红宝石随机礼包
$ItemGet[105109021,36]= "105180093 1 3 0 30"; //4级绿宝石随机礼包
$ItemGet[105109021,37]= "105180153 1 3 0 30"; //4级宝石随机礼包
$ItemGet[105109021,38]= "105180074 1 3 0 10"; //5级红宝石随机礼包
$ItemGet[105109021,39]= "105180094 1 3 0 10"; //5级绿宝石随机礼包
$ItemGet[105109021,40]= "105180154 1 3 0 10"; //5级宝石随机礼包
$ItemGet[105109021,41]= "105105303 1 0 0 1000"; //金条
$ItemGet[105109021,42]= "105105304 1 3 0 600"; //金砖
$ItemGet[105109021,43]= "105105305 1 3 0 10"; //钻石
$ItemGet[105109021,44]= "105028011 1 0 0 500"; //2.5倍经验丹
$ItemGet[105109021,45]= "105028021 1 3 0 310"; //3倍经验丹


function Trigger_105109001(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109001_105109021(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }
function Trigger_105109021(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109001_105109021(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }

function Trigger_105109001_105109021(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"包裹已满，请确保包裹中至少有1格空位！",%Player);
		return;
	}
	//echo( "==================== =============");
	%Ran = GetRanDom(1,10000);
	%RanRecord = 0;
	for (%i = 1; %i <= 99; %i++)
	{
		//echo( "$ItemGet[ " @ %Type @ "," @ %i  @ "]===" @ $ItemGet[ %Type, %i ] );
		if ($ItemGet[%Type,%i] $= "")
			break;
		%OneRan = GetWord($ItemGet[%Type,%i],4);
		%RanRecord = %RanRecord + %OneRan;
		if (%RanRecord >=  %Ran && %OneRan > 0)
		{
			//echo( "%RanRecord ===" @ %RanRecord );
			//echo( "%i ===" @ %i );
			%ItemID = GetWord($ItemGet[%Type,%i],0);
			%ItemNum = GetWord($ItemGet[%Type,%i],1);
			%MsgType = GetWord($ItemGet[%Type,%i],2);
			%Isspeicl = GetWord($ItemGet[%Type,%i],3);
			break;
		}
	}
	//echo( "%Ran ===" @ %Ran );
	//echo( "%ItemID==A==" @ %ItemID  @ "    %ItemNum===" @ %ItemNum  @  "   %Ran===" @ %Ran );
	if (%ItemID > 0 && %ItemNum > 0)
	{
		if (%Isspeicl == 1)
			%ItemID = Trigger_105109001_105109021A(%Player,%ItemID);
		%Player.Putitem(%Type,-1);
		%Player.Putitem(%ItemID,%ItemNum);
		//echo( "%ItemID====" @ %ItemID @ "    " @ GetItemData( %ItemID, 1 ) );
		if (%Player.additem(1,%type))
		{
			//echo( "%ItemID==B==" @ %ItemID );
			if (%MsgType > 0)
			{
				%ItemNameA0 = GetItemName(%Type,1);
				%ItemNameA1 = GetItemName(%Type,2);
				%ItemNameB0 = GetItemName(%ItemID,1);
				%ItemNameB1 = GetItemName(%ItemID,2);
				%PlayerName0 = GetPlayerZiTiName(%Player,1);
				%PlayerName1 = GetPlayerZiTiName(%Player,2);

				%Text0 ="<t>福星高照</t>" @ %PlayerName0 @ "<t>随手打开</t>" @ %ItemNameA0 @ "<t>获得了</t>" @ %ItemNameB0 @ "<t>。</t>";
				%Text1 ="<t>福星高照</t>" @ %PlayerName1 @ "<t>随手打开</t>" @ %ItemNameA1 @ "<t>获得了</t>" @ %ItemNameB1;

				switch (%MsgType)
				{
					case 1:
						SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text0 @ "</t>");
					case 2:
						SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text1 @ "</t>", $chatMsg_Type_Normal2);
					case 3:
						SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text0 @ "</t>");
						SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text1 @ "</t>", $chatMsg_Type_Normal2);
				}
			}
		}
	}
}

// Trigger_105109001_105109021A( 263087, 113050005 );
function Trigger_105109001_105109021A(%Player,%ItemID)
{
	//%echo = 1;
	//echo( "结算前===" @ %ItemID );
	if (%ItemID == 105109061 || %ItemID == 105109321 || %ItemID == 105105701)
		%AddNum = 1;
	else
		%AddNum = 10;
	%Level = %Player.GetLevel();
	%NeedItemID[0] = %ItemID;
	for (%i = 1; %i <= 10; %i++)
	{
		%ItemID = %ItemID + %AddNum;
		%NeedItemID[%i] = %ItemID;
		%ItemLV = GetItemData(%ItemID,$Item_Data_Lv);
		if (%ItemLV >= %Level)
		{
			%ItemID = %NeedItemID[%i - 1];
			//echo( "%ItemID==========="  @ %ItemID );
			break;
		}
	}
	//echo( "%ItemID ===" @ %ItemID );
	if (%echo == 1)
		echo("%ItemID ===" @ %ItemID @   "   " @ GetItemData(%ItemID,1));
	return %ItemID;
}
//■■■■【挖矿】■■■■【灵晶神石使用】■■■■■■■


//■■■■【挖矿】■■■■【璞玉额外产出】■■■■■■■
$SpecialjadeLuck[1] = 100;
$SpecialjadeLuck[2] = 200;
$SpecialjadeLuck[3] = 300;
$SpecialjadeLuck[4] = 400;
$SpecialjadeLuck[5] = 9999;

$SpecialjadeRan[1] = 70;//进入假的几率，否则为真
$SpecialjadeRan[2] = 65;//进入假的几率，否则为真
$SpecialjadeRan[3] = 60;//进入假的几率，否则为真
$SpecialjadeRan[4] = 55;//进入假的几率，否则为真
$SpecialjadeRan[5] = 50;//进入假的几率，否则为真

$Specialjade[1,1] = 105300001;/*假1*/ $Specialjade[2,1] = 105300011;/*假11*/ $Specialjade[3,1] =105300021;/*假21*/
$Specialjade[1,2] = 105300002;/*假2*/ $Specialjade[2,2] = 105300012;/*假12*/ $Specialjade[3,2] =105300022;/*假22*/
$Specialjade[1,3] = 105300003;/*假3*/ $Specialjade[2,3] = 105300013;/*假13*/ $Specialjade[3,3] =105300023;/*假23*/
$Specialjade[1,4] = 105300004;/*假4*/ $Specialjade[2,4] = 105300014;/*假14*/ $Specialjade[3,4] =105300024;/*假24*/
$Specialjade[1,5] = 105300005;/*假5*/ $Specialjade[2,5] = 105300015;/*假15*/ $Specialjade[3,5] =105300025;/*假25*/
$Specialjade[1,6] = 105300006;/*真1*/ $Specialjade[2,6] = 105300016;/*真11*/ $Specialjade[3,6] =105300026;/*真21*/
$Specialjade[1,7] = 105300007;/*真2*/ $Specialjade[2,7] = 105300017;/*真12*/ $Specialjade[3,7] =105300027;/*真22*/
$Specialjade[1,8] = 105300008;/*真3*/ $Specialjade[2,8] = 105300018;/*真13*/ $Specialjade[3,8] =105300028;/*真23*/
$Specialjade[1,9] = 105300009;/*真4*/ $Specialjade[2,9] = 105300019;/*真14*/ $Specialjade[3,9] =105300029;/*真24*/
$Specialjade[1,10]= 105300010;/*真5*/ $Specialjade[2,10]= 105300020;/*真15*/ $Specialjade[3,10]=105300030;/*真25*/

function GetSpecialjade(%Player,%TakeGold,%Maintype,%Subtype)
{

	switch (%TakeGold)
	{
		case 0:
			%Ran = Getrandom(1,1000);
			if (%Ran > 1)
				return 0;
		case 1:
			%Ran = Getrandom(1,100);
			if (%Ran > 1)
				return 0;
		case 10:
			%Ran = Getrandom(1,100);
			if (%Ran > 3)
				return 0;
	}
	%FuYuan = %Player.GetLuck();
	for (%i = 1; %i <= 5; %i++)
	{
		if (%FuYuan < $SpecialjadeLuck[%i])
		{
			%Row = %i;
			break;
		}
	}
	%Ran = GetRanDom(1,100);
	if (%Ran > $SpecialjadeRan[%Row])
		%Row = %Row + 5;

	%Level = %Player.GetLevel();
	if (%Level <= 50)
		%Column = 1;
	else if (%Level <= 60)
	{
		%Ran = GetRanDom(1,100);
		if (%Ran <= 40)
			%Column = 1;
		else
			%Column = 2;
	}
	else
	{
		%Ran = GetRanDom(1,100);
		if (%Ran <= 20)
			%Column = 1;
		else if (%Ran <= 50)
			%Column = 2;
		else
			%Column = 3;
	}
	if (%Column > 0 && %Row  > 0)
		%ItemId = $Specialjade[%Column,%Row];
	if (%ItemId > 0)
	{
		//echo( "%ItemId====" @ %ItemId );
		%index = %Player.PutItem(%ItemId,1);
		%player.SetPutItemProduceName(%index,%player.GetPlayerName() @ "（福缘：" @ %FuYuan @ "）所采掘");
		%Player.Additem(%Maintype,%Subtype);
		return 1;
	}
}
//■■■■【挖矿】■■■■【璞玉额外产出】■■■■■■■
//function wakuangxxx( )
//{
//	%Player = SptGetplayer( 50000324 );
//	%Pos = %Player.FindItem( 1, 105300001 );
//	%Player.AttachItemObject( ItemObj, 1, %Pos );//先把掉落的物品导出对象
//	%Player.ItemID = %ItemID;
//	%Player.Master = %PlayerID;//掉落者
//	%Player.MasterName = %Player.GetPlayername( );//掉落者的名称
//	%Player.ItemObj[ 0 ] = ItemObj.Quantity;		// 物品数量(对于装备，只能为1)					
//	%Player.ItemObj[ 1 ] = ItemObj.BindPlayer;		// 绑定者ID(也可用于存储灵魂链接开启后玩家ID
//	%Player.ItemObj[ 2 ] = ItemObj.BindFriend;		// 绑定好友角色ID共享使用物品				
//	%Player.ItemObj[ 3 ] = ItemObj.ActiveFlag;		// 物品激活标志								
//	%Player.ItemObj[ 4 ] = ItemObj.LapseTime;		// 剩余秒数
//	%Player.ItemObj[ 5 ] = ItemObj.RemainUseTimes;	// 剩余使用次数								
//	%Player.ItemObj[ 6 ] = ItemObj.LockedLeftTime;	// 物品锁剩余时间（秒）						
//	%Player.ItemObj[ 7 ] = ItemObj.Quality;		// 物品品质等级									
//	%Player.ItemObj[ 8 ] = ItemObj.CurWear;		// 当前耐久度									
//	%Player.ItemObj[ 9 ] = ItemObj.CurMaxWear;		// 当前最大耐久度							
//	%Player.ItemObj[ 10 ] = ItemObj.CurAdroit;		// 当前熟练度								
//	%Player.ItemObj[ 11 ] = ItemObj.CurAdroitLv;		// 当前熟练度等级							
//	%Player.ItemObj[ 12 ] = ItemObj.ActivatePro;		// 附加属性效果激活标志						
//	%Player.ItemObj[ 13 ] = ItemObj.RandPropertyID;	// 随机名称属性ID							
//	%Player.ItemObj[ 14 ] = ItemObj.IDEProValue0;		// 鉴定后附加属性值0						
//	%Player.ItemObj[ 15 ] = ItemObj.IDEProValue1;		// 鉴定后附加属性值1						
//	%Player.ItemObj[ 16 ] = ItemObj.IDEProValue2;		// 鉴定后附加属性值2						
//	%Player.ItemObj[ 17 ] = ItemObj.IDEProValue3;		// 鉴定后附加属性值3						
//	%Player.ItemObj[ 18 ] = ItemObj.IDEProValue4;		// 鉴定后附加属性值4						
//	%Player.ItemObj[ 19 ] = ItemObj.IDEProValue5;		// 鉴定后附加属性值5						
//	%Player.ItemObj[ 20 ] = ItemObj.IDEProValue6;		// 鉴定后附加属性值6						
//	%Player.ItemObj[ 21 ] = ItemObj.IDEProValue7;		// 鉴定后附加属性值7						
//	%Player.ItemObj[ 22 ] = ItemObj.IDEProValue8;		// 鉴定后附加属性值8						
//	%Player.ItemObj[ 23 ] = ItemObj.IDEProValue9;		// 鉴定后附加属性值9						
//	%Player.ItemObj[ 24 ] = ItemObj.IDEProValue10;	// 鉴定后附加属性值10						
//	%Player.ItemObj[ 25 ] = ItemObj.IDEProValue11;	// 鉴定后附加属性值11						
//	%Player.ItemObj[ 26 ] = ItemObj.EquipStrengthens;	// 装备强化过总数							
//	%Player.ItemObj[ 27 ] = ItemObj.EquipStrengthenValue00;//装备强化特殊等级值1					
//	%Player.ItemObj[ 28 ] = ItemObj.EquipStrengthenValue01;//装备强化特殊等级属性值1				
//	%Player.ItemObj[ 29 ] = ItemObj.EquipStrengthenValue10;//装备强化特殊等级值2					
//	%Player.ItemObj[ 30 ] = ItemObj.EquipStrengthenValue11;//装备强化特殊等级属性值2				
//	%Player.ItemObj[ 31 ] = ItemObj.EquipStrengthenValue20;//装备强化特殊等级值3					
//	%Player.ItemObj[ 32 ] = ItemObj.EquipStrengthenValue21;//装备强化特殊等级属性值3				
//	%Player.ItemObj[ 33 ] = ItemObj.WuXingID;						// 五行ID						
//	%Player.ItemObj[ 34 ] = ItemObj.WuXingPro;						// 五行效果属性				
//	%Player.ItemObj[ 35 ] = ItemObj.SkillAForEquip;					// 装备上获取的主动技能ID	
//	%Player.ItemObj[ 36 ] = ItemObj.SkillBForEquip;					// 装备上获取的被动技能ID	
//	%Player.ItemObj[ 37 ] = ItemObj.EmbedSlot0;		// 装备镶嵌孔的宝石ID						
//	%Player.ItemObj[ 38 ] = ItemObj.EmbedSlot1;		// 装备镶嵌孔的宝石ID						
//	%Player.ItemObj[ 39 ] = ItemObj.EmbedSlot2;		// 装备镶嵌孔的宝石ID						
//	%Player.ItemObj[ 40 ] = ItemObj.EmbedSlot3;		// 装备镶嵌孔的宝石ID						
//	%Player.ItemObj[ 41 ] = ItemObj.EmbedSlot4;		// 装备镶嵌孔的宝石ID						
//	%Player.ItemObj[ 42 ] = ItemObj.EmbedSlot5;		// 装备镶嵌孔的宝石ID						
//	%Player.ItemObj[ 43 ] = ItemObj.EmbedSlot6;		// 装备镶嵌孔的宝石ID						
//	%Player.ItemObj[ 44 ] = ItemObj.EmbedSlot7;		// 装备镶嵌孔的宝石ID						
//	%Player.ItemObj[ 45 ] = ItemObj.EXPOR_RESERV0;								//拓展属性0		
//	%Player.ItemObj[ 46 ] = ItemObj.EXPOR_RESERV1;								//拓展属性1		
//	%Player.ItemObj[ 47 ] = ItemObj.EXPOR_RESERV2;								//拓展属性2		
//	%Player.ItemObj[ 48 ] = ItemObj.EXPOR_RESERV3;								//拓展属性3		
//	%Player.ItemObj[ 49 ] = ItemObj.EXPOR_RESERV4;								//拓展属性4		
//	%Player.ItemObj[ 50 ] = ItemObj.EXPRO_EATLIMIT;								//吞噬每日上限	
//	%Player.ItemObj[ 51 ] = ItemObj.EXPRO_EATCOUNT;								//当日吞噬次数	
//	%Player.ItemObj[ 52 ] = ItemObj.EXPRO_GATHERSOULLEVEL;						//凝魂等级		
//	%Player.ItemObj[ 53 ] = ItemObj.EXPRO_EATPRO0;								//吞噬属性0		
//	%Player.ItemObj[ 54 ] = ItemObj.EXPRO_EATPRO1;								//吞噬属性1		
//	%Player.ItemObj[ 55 ] = ItemObj.EXPRO_ITEMID;								//物品模板ID		
//	//%Player.ItemObj[ 55 ] = %ItemID;
//	//--------------输出调试-------------
//	echo( "------------------------" );
//	echo( %Player.ItemID );
//	echo( %ItemName );
//	echo( %Player.ItemObj[ 0 ] );
//	echo( %Player.Master );//掉落者
//	echo( %Player.MasterName );//掉落者的名称
//	for ( %i = 0; %i<=55; %i++ )
//	{
//		echo( "位置" @ %i @ "数据：" @ %Player.ItemObj[ %i ] );
//	}
//}


//■■■■【挖矿】■■■■【灵脉商店展示】■■■■■■■
function QiShiShangDianDialog(%Npc,%Player,%State,%Conv)//奇石商店展示
{
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000102);
	}
}
function ShenShiShangDianDialog(%Npc,%Player,%State,%Conv)//神石商店展示
{
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000103);
	}
}
//■■■■【挖矿】■■■■【灵脉商店展示】■■■■■■■
//StallSeeWndGui_DealInfo
//StallWndGui_DealInfo