//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//钓鱼活动
//==================================================================================
//■■■■【钓鱼】■■■■【全局变量】■■■■■■
//■■■■【钓鱼】■■■■【活动开启】■■■■■■
//■■■■【钓鱼】■■■■【采集触发】■■■■■■
//■■■■【钓鱼】■■■■【海怪触发】■■■■■■
//■■■■【钓鱼】■■■■【NPC对话】■■■■■■

//活动时间	每天18:50--19：10
//活动地图	蓬莱新手村半圆沙滩
//参与方式	定点垂钓，支持同时钓鱼人数30-40人
//相关道具	各等级鱼竿、鱼饵，各种小鱼小虾，贝壳，中型鱼，大型鱼
//当前活动区域可开善恶模式
//活动详细	创建采集物钓鱼台30-40个
//采集钓鱼台触发
//消耗钓鱼竿耐久度、鱼饵数量
//30秒完成一次钓鱼
//根据鱼竿鱼饵等级，概率获得各种鱼
//
//特殊事件	触发海妖来袭
//海面走过来一只大型海妖，合力帮助击败掉落大量物品

//■■■■【钓鱼】■■■■【全局变量】■■■■■■
$SL_DiaoYuYuQunPos[1] = "-51.8028 -94.7527 105.697";
$SL_DiaoYuYuQunPos[2] = "-49.7597 -97.838 105.302";
$SL_DiaoYuYuQunPos[3] = "-51.6713 -99.1353 105.937";
$SL_DiaoYuYuQunPos[4] = "-48.7831 -102.168 105.491";
$SL_DiaoYuYuQunPos[5] = "-49.3591 -104.528 105.771";
$SL_DiaoYuYuQunPos[6] = "-48.5471 -107.268 105.786";
$SL_DiaoYuYuQunPos[7] = "-50.1443 -109.714 106.079";
$SL_DiaoYuYuQunPos[8] = "-48.3271 -110.708 105.902";
$SL_DiaoYuYuQunPos[9] = "-49.8016 -113.598 106.203";
$SL_DiaoYuYuQunPos[10] ="-50.6489 -116.333 106.289";
$SL_DiaoYuYuQunPos[11] ="-51.9447 -118.866 106.415";
$SL_DiaoYuYuQunPos[12] ="-52.1537 -121.539 106.471";
$SL_DiaoYuYuQunPos[13] ="-51.8055 -127.393 106.441";
$SL_DiaoYuYuQunPos[14] ="-51.5717 -132.562 106.471";
$SL_DiaoYuYuQunPos[15] ="-51.1732 -135.225 106.375";
$SL_DiaoYuYuQunPos[16] ="-51.1024 -140.922 106.182";
$SL_DiaoYuYuQunPos[17] ="-54.214 -147.565 105.919";
$SL_DiaoYuYuQunPos[18] ="-55.6213 -151.667 105.775";
$SL_DiaoYuYuQunPos[19] ="-60.316 -156.95 105.646";
$SL_DiaoYuYuQunPos[20] ="-64.2436 -158.729 105.514";
$SL_DiaoYuYuQunPos[21] ="-67.2399 -159.728 105.366";
$SL_DiaoYuYuQunPos[22] ="-70.1347 -160.722 105.35";
$SL_DiaoYuYuQunPos[23] ="-72.5982 -156.768 105.791";
$SL_DiaoYuYuQunPos[24] ="-76.1414 -160.444 105.572";
$SL_DiaoYuYuQunPos[25] ="-78.6148 -157.215 105.821";
$SL_DiaoYuYuQunPos[26] ="-79.7257 -159.749 105.693";
$SL_DiaoYuYuQunPos[27] ="-83.9059 -157.973 105.936";
$SL_DiaoYuYuQunPos[28] ="-86.2521 -158.686 106.007";
$SL_DiaoYuYuQunPos[29] ="-88.6648 -158.414 106.07";
$SL_DiaoYuYuQunPos[30] ="-94.2497 -159.75 106.133";
$SL_DiaoYuYuQunPos[31] ="-96.7108 -160.242 106.164";
$SL_DiaoYuYuQunPos[32] ="-99.2204 -161.715 106.146";
$SL_DiaoYuYuQunPos[33] ="-104.225 -162.748 106.136";
$SL_DiaoYuYuQunPos[34] ="-109.701 -162.667 106.255";

//■■■■【钓鱼】■■■■【全局变量】■■■■■■

//■■■■【钓鱼】■■■■【活动开启】■■■■■■
function DiaoYuHuoDong_StytemMsg(%YY,%MM,%DD,%H,%M,%S)
{
	if (GetZoneID() != 1010)
		return;
	if ($SL_DiaoYu_bActive != 1)
		return;
	if (%H == 23 && %M == 59)
	{
		$CreateJiaoLongRecord = 0;
		$DiaoYuChengHaoRecordTwo = 0;
		$DiaoYuChengHaoRecordOne = 0;
	}
	%Nowtime = %H * 60 + %M;
	%Starttime = getword($SL_DiaoYu_StartTime,0,":") * 60 + getword($SL_DiaoYu_StartTime,1,":");
	%Endtime = getword($SL_DiaoYu_EndTime,0,":") * 60 + getword($SL_DiaoYu_EndTime,1,":");
	//%Path = GetTraceButton( "findpath(410010302);", GetNpcData( 410010302, 1 ) );//NPC寻径
	%Path = "<l i='810100100 -121.087 -151.498 107.652' t='path'/>";

	%HuoDongMingCheng = GetHuoDongName("蓬莱仙钓",1);

	%ItemName1 = GetItemName(105109301,1);//蓬莱仙钓参赛券
	%ItemName2 = GetItemName(106050307,1);//金鳞鲤鱼
	%ItemName3 = GetItemName(106050306,1);//赤焰鳟

	%Text = "";
	if (%Starttime -  %Nowtime  == 10)
	{
		%Text = %HuoDongMingCheng @ "<t>将在</t>" @ $Get_Dialog_GeShi[31420] @ "10</t><t>分钟后开启，" @ $SL_DiaoYu_Level @ "级以上修士可携带</t>" @ %ItemName1 @ "<t>前往</t>" @ %Path @ "<t>垂钓活动。昆仑城内云游隐士皇浦奇将授予钓到</t>" @ %ItemName2 @ "<t>和</t>" @ %ItemName3 @ "<t>的玩家相应名次。每日仅有一位第一名，五位第二名。</t>";
		%Text2 = GetHuoDongName("蓬莱仙钓",2) @ "<t>将于</t>" @ $Get_Dialog_GeShi[60002]  @ "10</t><t>分钟后开启</t>";
	}
	if (%Starttime -  %Nowtime  == 5)
	{
		%Text2 = GetHuoDongName("蓬莱仙钓",2) @ "<t>将于</t>" @ $Get_Dialog_GeShi[60002]  @ "5</t><t>分钟后开启</t>";
		%Text = %HuoDongMingCheng @ "<t>将在</t>" @ $Get_Dialog_GeShi[31420] @ "5</t><t>分钟后开启，" @ $SL_DiaoYu_Level @ "级以上修士可携带</t>" @ %ItemName1 @ "<t>前往</t>" @ %Path @ "<t>垂钓活动。昆仑城内云游隐士皇浦奇将授予钓到</t>" @ %ItemName2 @ "<t>和</t>" @ %ItemName3 @ "<t>的玩家相应名次。每日仅有一位第一名，五位第二名。</t>";
	}
	if (%Starttime -  %Nowtime  == 1)
	{
		%Text2 = GetHuoDongName("蓬莱仙钓",2) @ "<t>将于</t>" @ $Get_Dialog_GeShi[60002]  @ "1</t><t>分钟后开启</t>";
		%Text = %HuoDongMingCheng @ "<t>将在</t>" @ $Get_Dialog_GeShi[31420] @ "1</t><t>分钟后开启，" @ $SL_DiaoYu_Level @ "级以上修士可携带</t>" @ %ItemName1 @ "<t>前往</t>" @ %Path @ "<t>垂钓活动。昆仑城内云游隐士皇浦奇将授予钓到</t>" @ %ItemName2 @ "<t>和</t>" @ %ItemName3 @ "<t>的玩家相应名次。每日仅有一位第一名，五位第二名。</t>";
	}
	if (%Starttime -  %Nowtime  == 0)
	{
		CreateYuQun();
		%Text2 = GetHuoDongName("蓬莱仙钓",2) @ "<t>已经开启。</t>";
		%Text = %HuoDongMingCheng @ "<t>已经开启，" @ $SL_DiaoYu_Level @ "级以上修士可携带</t>" @ %ItemName1 @ "<t>前往</t>" @ %Path @ "<t>垂钓活动。昆仑城内云游隐士皇浦奇将授予钓到</t>" @ %ItemName2 @ "<t>和</t>" @ %ItemName3 @ "<t>的玩家相应名次。每日仅有一位第一名，五位第二名。</t>";
	}
	if (%Endtime - %Nowtime == 10)
	{
		%Text2 = GetHuoDongName("蓬莱仙钓",2) @ "<t>还有</t>" @ $Get_Dialog_GeShi[60002]  @ "10</t><t>分钟结束</t>";
		%Text = %HuoDongMingCheng @ "<t>还有</t>" @ $Get_Dialog_GeShi[31420] @ "10</t><t>分钟结束，修士们抓紧时间哦。昆仑城内云游隐士皇浦奇将授予钓到</t>" @ %ItemName2 @ "<t>和</t>" @ %ItemName3 @ "<t>的玩家相应名次。每日仅有一位第一名，五位第二名。</t>";
	}
	if ($CreateYuQunRecord <= 0 && $SL_DiaoYu_State_bActive == 1)
		CreateYuQun();
	if (%Text !$= "")
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");
	if (%Text2 !$= "")
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
}

//■■■■【钓鱼】■■■■【活动开启】■■■■■■


//■■■■【钓鱼】■■■■【采集触发】■■■■■■
function TriggerEvent_551030101(%Player,%Event,%EventID)
{
	//echo( "钓鱼中==========" @ %Event );
	if ($SL_DiaoYu_State_bActive != 1)
	{
		SendOneScreenMessage(2,"活动已经结束，鱼群已经离去",%Player);
		return;
	}
	if (%Player.getitemcount(105109302) < 1)
	{
		SendOneScreenMessage(2,"鱼饵不足,垂钓失败",%Player);
		return;
	}
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"包裹空格不足",%Player);
		return;
	}
	%Player.Putitem(105109302,-1);
	if (%Player.Additem(1,%EventID))
	{
		%Event.Safedeleteobject();

		%Act0 = GetAct(%Player,4022,0);
		%Act1 = GetAct(%Player,4022,1);
		SetAct(%Player,4022,%Act0,%Act1++);

		%RanDom = getrandom(1,10000);
		//$SL_DiaoYu_Item[ 1 ] = "106050301;5480;1;0;0;"; //金枪鱼
		for (%i = 1; %i< 99; %i++)
		{
			if ($SL_DiaoYu_Item[%i] $= "")
				break;
			%ItemID = Getword($SL_DiaoYu_Item[%i],0);
			%Ran = Getword($SL_DiaoYu_Item[%i],1) + %Ran;
			%ItemCount = Getword($SL_DiaoYu_Item[%i],2);
			%Property = Getword($SL_DiaoYu_Item[%i],3);
			%Msg = Getword($SL_DiaoYu_Item[%i],4);
			//echo( "%ItemID===" @ %ItemID );
			//echo( "%Ran===" @ %Ran );
			//echo( "%ItemCount===" @ %ItemCount );
			//echo( "%Property===" @ %Property );
			//echo( "%Msg===" @ %Msg );
			if (%RanDom <= %Ran)
			{
				AddItem_BaoGuoNo_Mail(%Player,%ItemID,%ItemCount,%Property,"3 4022");
				if (%Msg >= 1)//聊天框公告
				{
					%ItemName   = "<l i='" @ %ItemID @ "' t='itemid'/>";
					%PlayerName = GetPlayerZiTiName(%Player,1);
					%HuoDongMingCheng = GetHuoDongName("蓬莱仙钓",1);
					%Text = %PlayerName @ "<t>在参加</t>" @ %HuoDongMingCheng @ "<t>时钓上来一条</t>"@ %ItemName @ "<t>，真是羡煞众人！</t>";
					SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Text @ "</t>");
					if (%Msg == 2)//全屏公告
					{
						%Txt = GetPlayerZiTiName(%Player,2) @ "<t>在参加</t>" @ GetHuoDongName("蓬莱仙钓",2)  @ "<t>时钓上来一条</t>" @ %ItemName @ $Get_Dialog_GeShi[60001] @ "<t>，真是羡煞旁人！</t>";
						SendOneLineMessage(%Txt, $chatMsg_Type_Normal2);
					}
				}
				break;
			}
		}
		//---触发 巡海夜叉--------
		%Ran = GetRandom(1,1000);
		if (%Ran <= 25)
		{
			%Pos = %Player.GetPosition();
			%NpcPos = GetNavPos(GetWord(%Pos,0),GetWord(%Pos,1),20);
			%MonSter = SpNewNpc2(0,410101018,%NpcPos,0,0);
			%MonSter.Addhate(%Player,100);
			SendAllChatMessage(0,"<t>巡海夜叉：一群宵小，又来残害我等水族，既被吾发现，饶你们不得！</t>");//发送跑马信息
		}
	}
}
function TriggerEvent_553000053(%Player,%Event,%EventID){ return true; }
function TriggerEvent_553000054(%Player,%Event,%EventID){ return true; }
function TriggerEvent_553000055(%Player,%Event,%EventID){ return true; }
function TriggerEvent_553000056(%Player,%Event,%EventID){ return true; }
//■■■■【钓鱼】■■■■【采集触发】■■■■■■



//■■■■【钓鱼】■■■■【海怪触发】■■■■■■

function NpcObjectonDeathcast_410101018(%Monster,%Killer)//巡海夜叉
{
	SendAllChatMessage(10,"<t>巡海夜叉：尔等莫要猖狂，待我禀报大王，率军回来收拾尔等！</t>");//发送信息
	%Pos = %Monster.GetPosition();
	for (%i = 1; %i <=3; %i++)
	{
		%CjPos = GetNavPos(GetWord(%Pos,0),GetWord(%Pos,1),20);
		SpNewCj(0,553000053,%CjPos,GetRanDom(0,360),"1 1 1");
	}
	for (%i = 1; %i <=7; %i++)
	{
		%CjPos = GetNavPos(GetWord(%Pos,0),GetWord(%Pos,1),20);
		SpNewCj(0,553000054,%CjPos,GetRanDom(0,360),"1 1 1");
	}
	//---触发 蛟龙--------
	%Ran = GetRandom(1,1000);
	if (%Ran <= 25 && $CreateJiaoLongRecord != 1)
	{
		$CreateJiaoLongRecord = 1;
		%Pos = %Killer.GetPosition();
		%NpcPos = GetNavPos(GetWord(%Pos,0),GetWord(%Pos,1),20);
		%MonSter = SpNewNpc2(0,410101019,%NpcPos,0,0);
		%MonSter.Addhate(%Killer,100);
		SendAllChatMessage(0,"<t>蛟龙：残我水族，夺我海域，不共戴天！</t>");//发送跑马信息
	}
}
function NpcObjectonDeathcast_410101019(%Monster,%Killer)//蛟龙
{
	SendAllChatMessage(10,"<t>蛟龙：风紧，扯呼！</t>");//发送信息
	%Pos = %Monster.GetPosition();
	for (%i = 1; %i <= 5; %i++)
	{
		%CjPos = GetNavPos(GetWord(%Pos,0),GetWord(%Pos,1),20);
		SpNewCj(0,553000055,%CjPos,GetRanDom(0,360),"1 1 1");
	}
	for (%i = 1; %i <= 5; %i++)
	{
		%CjPos = GetNavPos(GetWord(%Pos,0),GetWord(%Pos,1),20);
		SpNewCj(0,553000056,%CjPos,GetRanDom(0,360),"1 1 1");
	}
}
//■■■■【钓鱼】■■■■【海怪触发】■■■■■■


//■■■■【钓鱼】■■■■【NPC对话】■■■■■■
$SL_DiaoYuChengHaoXiangGuan[101] = "600000056 105109303 5";//渔·清溪渔童
$SL_DiaoYuChengHaoXiangGuan[102] = "600000057 105109303 20";//渔·三溪渔子
$SL_DiaoYuChengHaoXiangGuan[103] = "600000058 105109303 50";//渔·五湖渔郎
$SL_DiaoYuChengHaoXiangGuan[104] = "600000059 105109303 80";//渔·七江渔叟
$SL_DiaoYuChengHaoXiangGuan[105] = "600000060 105109303 100";//渔·孤舟渔隐
$SL_DiaoYuChengHaoXiangGuan[106] = "600000061 105109303 200";//渔·临江独钓
$SL_DiaoYuChengHaoXiangGuan[107] = "600000062 105109303 300";//渔·临江仙
$SL_DiaoYuChengHaoXiangGuan[108] = "600000063 105109303 500";//渔·垂天下
$SL_DiaoYuChengHaoXiangGuan[109] = "600000064 105109303 800";//渔·隐士
$SL_DiaoYuChengHaoXiangGuan[110] = "600000065 105109303 1000";//渔·无名

function DiaoYuHuoDong_DiaLogA(%Npc,%Player,%State,%Conv)//钓鱼兑换鱼饵
{
	if (%Player.getlevel() < $SL_DiaoYu_Level)
		return;
	echo("兑换鱼饵===%State=" @ %State);
	%Time = GetLocalTime();
	%H = getword(%Time,3);
	%M = getword(%Time,4);
	switch (%state)
	{
		case 0:
			%Conv.AddOption(600000071,600000071);
			if (%Player.sptIsDesignationExist(101) == 0)
				%Conv.AddOption(GetWord($SL_DiaoYuChengHaoXiangGuan[101],0),GetWord($SL_DiaoYuChengHaoXiangGuan[101],0));
			else
			{
				for (%i = 110; %i>=102; %i--)
				{
					if (%Player.sptIsDesignationExist(%i) == 0 && %Player.sptIsDesignationExist(%i - 1) == 1)
						%Conv.AddOption(GetWord($SL_DiaoYuChengHaoXiangGuan[%i],0),GetWord($SL_DiaoYuChengHaoXiangGuan[%i],0));
				}
			}
		case 600000071:
			%Nowtime = %H * 60  + %M;
			%Starttime = getword($SL_DiaoYu_StartTime,0,":") * 60 + getword($SL_DiaoYu_StartTime,1,":");
			%Endtime = getword($SL_DiaoYu_EndTime,0,":") * 60 + getword($SL_DiaoYu_EndTime,1,":");
			//echo("Starttime====" @ %Starttime @ "Nowtime======" @ %Nowtime @ "Endtime====" @ %Endtime);
			if (%Starttime  >= %Nowtime + 10 || %Nowtime >= %Endtime)
			{
				//%Conv.Settype(4);
				SendOneScreenMessage(2,"不在兑换时间内，无法兑换",%Player);
				SendOneChatMessage($chatMsg_System,"<t>不在兑换时间内，无法兑换。鱼饵兑换功能在活动开始前10分钟开放，活动结束时关闭。</t>",%Player);
				return DiaoYuHuoDong_DiaLogA(%Npc, %Player, 0, %Conv);
			}
			%Player.ShowDialogOk(2000000004,5,1);

		case 600000056:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000005, 6, 1);
		case 600000057:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000006, 7, 1);
		case 600000058:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000007, 8, 1);
		case 600000059:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000008, 9, 1);
		case 600000060:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000009, 10, 1);
		case 600000061:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000010, 11, 1);
		case 600000062:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000011, 12, 1);
		case 600000063:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000012, 13, 1);
		case 600000064:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000013, 14, 1);
		case 600000065:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000014, 15, 1);
	}
}
function DiaoYuChengHaoDuiHuan(%Player,%DesignationExist)
{
	//echo( " %DesignationExist=====" @ %DesignationExist );
	if (%Player.sptIsDesignationExist(%DesignationExist)  == 1)
		return;
	%ItemID = GetWord($SL_DiaoYuChengHaoXiangGuan[%DesignationExist],1);
	%ItemCount = GetWord($SL_DiaoYuChengHaoXiangGuan[%DesignationExist],2);
	//echo( " %DesignationExist=====" @ %DesignationExist );
	//echo( " %ItemID=====" @ %ItemID );
	//echo( " %ItemCount=====" @ %ItemCount );
	if (%Player.GetitemCount(%ItemID) < %ItemCount)
	{
		SendOneScreenMessage(2,"兑换材料不足",%Player);
		return;
	}
	%Player.Putitem(%ItemID,-%ItemCount);
	if (%Player.Additem(1,4022))
	{
		SendOneScreenMessage(2,"兑换成功",%Player);
		%Player.AddDesignation(%DesignationExist);//      	添加一个新的称号
		%Player.SetCurDesignationIDZone(%DesignationExist);//	设置此称号为当前正在使用的称号
	}
}

function DiaoYuHuoDong_DiaLogA_A(%Player)
{
	//蓬莱仙钓参赛券	105109301
	//	鱼饵	105109302
	if (%Player.getitemcount(105109301) < 1)
	{
		SendOneScreenMessage(2,"兑换失败，没有足够的蓬莱仙钓参赛券",%Player);
		return;
	}
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"包裹空格不足",%Player);
		return;
	}
	%Act0 = GetAct(%Player,4022,0);
	%Act1 = GetAct(%Player,4022,1);
	if (%Act0 > 0)
	{
		SendOneScreenMessage(2,"每天只能兑换一次鱼饵",%Player);
		return;
	}
	%Player.putitem(105109301,-1);
	if (%Player.additem(1,105109301))
	{
		SetAct(%Player,4022,%Act0++,%Act1);
		%Player.putitem(105109302,10);
		%Player.Additem(1,105109301);
		AddAchievementWatch(%Player,0,42,1);//记录成就
		SendOneScreenMessage(1,"兑换成功",%Player);
	}
}

function DiaoYuHuoDong_DiaLogB(%Npc,%Player,%State,%Conv)//钓鱼兑换奖励 皇浦奇
{
	%Level = %Player.GetLevel();
	if (%Level < 40) %levelxishu = 1;
	else if (%Level < 50) %levelxishu = 1.2;
	else if (%Level < 60) %levelxishu = 1.6;
	else if (%Level < 70) %levelxishu = 2.0;
	else %levelxishu = 2.2;

	%ExpNumbers[106050301] = 80; //金枪鱼
	%ExpNumbers[106050302] = 160;//鲈鱼
	%ExpNumbers[106050303] = 300;//鳐鱼
	%ExpNumbers[106050306] = 500;//赤焰鳟
	%ExpNumbers[106050307] = 600;//金鳞鲤鱼
	%ExpNumbers[106050304] = 0;  //泪螺
	%ExpNumbers[106050305] = 80; //贝壳
	%ExpNumbers[105109303] = 0;  //垂钓心得
	switch (%state)
	{
		case 0:
			if (%Player.Getitemcount(106050301) >= 1) %Conv.AddOption(600000066,600000066);//"上缴[金枪鱼]</t>";
			if (%Player.Getitemcount(106050302) >= 1) %Conv.AddOption(600000067,600000067);//"上缴[鲈鱼]</t>";
			if (%Player.Getitemcount(106050303) >= 1) %Conv.AddOption(600000068,600000068);//"上缴[鳐鱼]</t>";
			if (%Player.Getitemcount(106050306) >= 1) %Conv.AddOption(600000069,600000069);//"上缴[赤焰鳟]</t>";
			if (%Player.Getitemcount(106050307) >= 1) %Conv.AddOption(600000070,600000070);//"上缴[金鳞鲤鱼]</t>";
		case 600000066://"上缴[金枪鱼]</t>";
			%Count = %Player.GetItemcount(106050301);
			%Player.Putitem(106050301,-%Count);
			if (%Player.Additem(1,106050301))
			{
				%Exp = $Monster_Exp[%Level,1] * %ExpNumbers[106050301] * %levelxishu * %Count;
				AllAddExp(%Player,%Exp);
				SendOneScreenMessage(2,"兑换成功，获得" @ %Exp @ "点经验奖励",%Player);
				SendOneChatMessage($chatMsg_System,"<t>兑换成功，获得" @ %Exp @ "点经验奖励</t>",%Player);
			}

		case 600000067://"上缴[鲈鱼]</t>";
			%Count = %Player.GetItemcount(106050302);
			%Player.Putitem(106050302,-%Count);
			if (%Player.Additem(1,106050302))
			{
				%Exp = $Monster_Exp[%Level,1] * %ExpNumbers[106050302] * %levelxishu * %Count;
				AllAddExp(%Player,%Exp);
				SendOneScreenMessage(2,"兑换成功，获得" @ %Exp @ "点经验奖励",%Player);
				SendOneChatMessage($chatMsg_System,"<t>兑换成功，获得" @ %Exp @ "点经验奖励</t>",%Player);
			}
		case 600000068://"上缴[鳐鱼]</t>";
			%Count = %Player.GetItemcount(106050303);
			%Player.Putitem(106050303,-%Count);
			if (%Player.Additem(1,106050303))
			{
				%Exp = $Monster_Exp[%Level,1] * %ExpNumbers[106050303] * %levelxishu * %Count;
				AllAddExp(%Player,%Exp);
				SendOneScreenMessage(2,"兑换成功，获得" @ %Exp @ "点经验奖励",%Player);
				SendOneChatMessage($chatMsg_System,"<t>兑换成功，获得" @ %Exp @ "点经验奖励</t>",%Player);
			}
		case 600000069://"上缴[赤焰鳟]</t>";
			if ($DiaoYuChengHaoRecordTwo >= 5)
			{
				SendOneScreenMessage(2,"你来晚了，老夫今日已经获得足够的赤焰鳟了",%Player);
				SendOneChatMessage($chatMsg_System,"<t>你来晚了，老夫今日已经获得足够的赤焰鳟了,请明日再来吧。</t>",%Player);
			}
			else
			{
				%Player.Putitem(106050306,-1);
				if (%Player.Additem(1,106050306))
				{
					%Exp = $Monster_Exp[%Level,1] * %ExpNumbers[106050306] * %levelxishu * 1;
					AllAddExp(%Player,%Exp);
					SendOneScreenMessage(2,"兑换成功，获得" @ %Exp @ "点经验奖励",%Player);
					SendOneChatMessage($chatMsg_System,"<t>兑换成功，获得" @ %Exp @ "点经验奖励</t>",%Player);

					$DiaoYuChengHaoRecordTwo++;

					%PlayerName1 = GetPlayerZiTiName(%Player,1);
					%PlayerName2 = GetPlayerZiTiName(%Player,2);
					%ItemName1 = GetItemName(106050306,1);
					%ItemName2 = GetItemName(106050306,2);
					%HuoDongMingCheng1 = GetHuoDongName("蓬莱仙钓",1);
					%HuoDongMingCheng2 = GetHuoDongName("蓬莱仙钓",2);
					%NpcName1 = GetNpcZiTiName(410010202,1);
					%NpcName2 = GetNpcZiTiName(410010202,2);
					%Path = GetMapName(%Player,1);
					if ($DiaoYuChengHaoRecordTwo == 5)
						%Text1 = %PlayerName1 @ "<t>参与</t>" @ %HuoDongMingCheng1 @ "<t>钓起</t>" @ %ItemName1 @ "<t>，上缴给云游隐士</t>" @ %NpcName1 @ %Path @ "<t>荣获第二名！今日第二名还有" @ 5 - $DiaoYuChengHaoRecordTwo @ "个名额！</t>";
					else
						%Text1 = %PlayerName1 @ "<t>参与</t>" @ %HuoDongMingCheng1 @ "<t>钓起</t>" @ %ItemName1 @ "<t>，上缴给云游隐士</t>" @ %NpcName1 @ %Path @ "<t>荣获第二名！今日第二名名额已全部奖励完毕！</t>";
					%Text2 = %PlayerName2 @ "<t>参与</t>" @ %HuoDongMingCheng2 @ "<t>钓起</t>" @ %ItemName2 @ "<t>，上缴给云游隐士</t>" @ %NpcName2 @ "<t>荣获第二名！</t>";
					SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
					SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);

					AddAchievementWatch(%Player, 0, 48, 1);//记录成就
					if (!%Player.sptIsDesignationExist(202))
					{
						%Player.AddDesignation(202);//      	添加一个新的称号
						%Player.SetCurDesignationIDZone(202);//	设置此称号为当前正在使用的称号
					}
				}
			}

		case 600000070://"上缴[金鳞鲤鱼]</t>";
			if ($DiaoYuChengHaoRecordOne == 1)
			{
				SendOneScreenMessage(2,"你来晚了，老夫今日已经获得到金鳞鲤鱼了",%Player);
				SendOneChatMessage($chatMsg_System,"<t>你来晚了，老夫今日已经获得到金鳞鲤鱼了,请明日再来吧。</t>",%Player);
			}
			else
			{
				%Player.Putitem(106050307,-1);
				if (%Player.Additem(1,106050307))
				{
					%Exp = $Monster_Exp[%Level,1] * %ExpNumbers[106050307] * %levelxishu * 1;
					AllAddExp(%Player,%Exp);
					SendOneScreenMessage(2,"兑换成功，获得" @ %Exp @ "点经验奖励",%Player);
					SendOneChatMessage($chatMsg_System,"<t>兑换成功，获得" @ %Exp @ "点经验奖励</t>",%Player);

					$DiaoYuChengHaoRecordOne = 1;

					%PlayerName1 = GetPlayerZiTiName(%Player,1);
					%PlayerName2 = GetPlayerZiTiName(%Player,2);
					%ItemName1 = GetItemName(106050307,1);
					%ItemName2 = GetItemName(106050307,2);
					%HuoDongMingCheng1 = GetHuoDongName("蓬莱仙钓",1);
					%HuoDongMingCheng2 = GetHuoDongName("蓬莱仙钓",2);
					%NpcName1 = GetNpcZiTiName(410010202,1);
					%NpcName2 = GetNpcZiTiName(410010202,2);
					%Path = GetMapName(%Player,1);
					%Text1 = %PlayerName1 @ "<t>参与</t>" @ %HuoDongMingCheng1 @ "<t>钓起</t>" @ %ItemName1 @ %Path @ "<t>，上缴给云游隐士</t>" @ %NpcName1 @ "<t>，夺得今日仙钓大赛第一名！</t>";
					%Text2 = %PlayerName2 @ "<t>参与</t>" @ %HuoDongMingCheng2 @ "<t>钓起</t>" @ %ItemName2 @ "<t>，上缴给云游隐士</t>" @ %NpcName2 @ "<t>，夺得今日仙钓大赛第一名！</t>";
					SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
					SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);

					AddAchievementWatch(%Player, 0, 47, 1);//记录成就

					if (!%Player.sptIsDesignationExist(201))
					{
						%Player.AddDesignation(201);//      	添加一个新的称号
						%Player.SetCurDesignationIDZone(201);//	设置此称号为当前正在使用的称号
					}
				}
			}
	}
	if (%State > 0)
		return DiaoYuHuoDong_DiaLogB(%Npc,%Player,0,%Conv);
}


function DiaoYuHuoDong_DiaLogC(%Npc,%Player,%State,%Conv)//钓鱼兑换奖励 	玲珑
{

}
//■■■■【钓鱼】■■■■【NPC对话】■■■■■■

//■■■■【钓鱼】■■■■【刷新鱼群】■■■■■■
function CreateYuQun()
{
	if (GetZoneID() != 1010)
		return;
	deleteVariables("$CreateYuQunRecord");
	CanCel($CreateYuQunRecord);
	if ($SL_DiaoYu_State_bActive != 1)
	{
		for (%i = 1; %i<=15; %i++)
		{
			if (isobject($YuQunDuiXiangRecord[%i]))
				$YuQunDuiXiangRecord[%i].SafeDeleteObject();
		}
		return;
	}
	for (%i = 1; %i<=15; %i++)
	{
		%Ran = getrandom(1,34);
		%pos = $SL_DiaoYuYuQunPos[%Ran];
		//echo( %i @ "===============" @ isobject( $YuQunDuiXiangRecord[ %i ] ));
		if (!isobject($YuQunDuiXiangRecord[%i]))
		{
			//echo( "刷新" @ %i );
			$YuQunDuiXiangRecord[%i] = SpNewCj2(0,551030101,%Pos,0,0,"1 1 1");
		}
	}
	$CreateYuQunRecord = schedule(30*1000,0,"CreateYuQun");
}
//■■■■【钓鱼】■■■■【刷新鱼群】■■■■■■