//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//藏宝图
//=================================================================================
//■■■■【藏宝图】■■■■【全局变量】■■■■■■■■
//■■■■【藏宝图】■■■■【任务处理】■■■■■■■■
//■■■■【藏宝图】■■■■【道具使用】■■■■■■■■
//■■■■【藏宝图】■■■■【宝箱奖励】■■■■■■■■
//■■■■【藏宝图】■■■■【妖王死亡触发】■■■■■■



//■■■■【藏宝图】■■■■【全局变量】■■■■■■■■
$CangBaoTu_YaoWang_MaxNumBer[0] = 5;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[1] = 3;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[2] = 3;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[3] = 3;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[4] = 3;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[5] = 3;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[6] = 3;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[7] = 3;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[8] = 3;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[9] = 5;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[10] =5;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[11] =5;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[12] =5;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[13] =5;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[14] =5;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[15] =5;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[16] =5;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[17] =5;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[18] =15;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[19] =15;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[20] =15;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[21] =15;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[22] =15;	 //妖王标准数量限制
$CangBaoTu_YaoWang_MaxNumBer[23] =5;	 //妖王标准数量限制

$CangBaoTu_YaoWang_CreateCD[0] = 3;//刷新CD
$CangBaoTu_YaoWang_CreateCD[1] = 5;//刷新CD
$CangBaoTu_YaoWang_CreateCD[2] = 5;//刷新CD
$CangBaoTu_YaoWang_CreateCD[3] = 5;//刷新CD
$CangBaoTu_YaoWang_CreateCD[4] = 5;//刷新CD
$CangBaoTu_YaoWang_CreateCD[5] = 5;//刷新CD
$CangBaoTu_YaoWang_CreateCD[6] = 5;//刷新CD
$CangBaoTu_YaoWang_CreateCD[7] = 5;//刷新CD
$CangBaoTu_YaoWang_CreateCD[8] = 5;//刷新CD
$CangBaoTu_YaoWang_CreateCD[9] = 3;//刷新CD
$CangBaoTu_YaoWang_CreateCD[10]= 3;//刷新CD
$CangBaoTu_YaoWang_CreateCD[11]= 3;//刷新CD
$CangBaoTu_YaoWang_CreateCD[12]= 3;//刷新CD
$CangBaoTu_YaoWang_CreateCD[13]= 3;//刷新CD
$CangBaoTu_YaoWang_CreateCD[14]= 3;//刷新CD
$CangBaoTu_YaoWang_CreateCD[15]= 3;//刷新CD
$CangBaoTu_YaoWang_CreateCD[16]= 3;//刷新CD
$CangBaoTu_YaoWang_CreateCD[17]= 3;//刷新CD
$CangBaoTu_YaoWang_CreateCD[18]= 2;//刷新CD
$CangBaoTu_YaoWang_CreateCD[19]= 2;//刷新CD
$CangBaoTu_YaoWang_CreateCD[20]= 2;//刷新CD
$CangBaoTu_YaoWang_CreateCD[21]= 2;//刷新CD
$CangBaoTu_YaoWang_CreateCD[22]= 2;//刷新CD
$CangBaoTu_YaoWang_CreateCD[23]= 3;//刷新CD

//■■■■【藏宝图】■■■■【全局变量】■■■■■■■■

//■■■■【藏宝图】■■■■【任务处理】■■■■■■■■

function Mission_Begin_Process_20148(%Npc,%Player,%Conv,%Param,%Mid)
{
	%Act4012[0] = GetAct(%Player,4012,0);
	%Act4012[1] = GetAct(%Player,4012,1);
	SetAct(%Player,4012,%Act4012[0]++,%Act4012[1]);

	%Player.ReduceMoney(6000,2,4,20148);
	%index = %Player.Putitem(108030001,1);
	%Player.additem(1,%Mid);

	%List = GetRandomPosForMap(0);
	%MapID = GetWord(%List,0);
	%PosID = GetWord(%List,1);
	SetAct(%Player,4013,%mapid,%posid);
	//%Conv.settext( 600000023 );
	%Player.SetMissionFlag(%Mid,3100,440000018);
	%Player.SetMissionFlag(%Mid,3200,1);
	%Player.SetMissionFlag(%Mid,3300,0);

	%Player.SetMissionFlag(%Mid,9000,1);
	%Player.SetMissionFlag(%Mid,9001,1);
	%Player.SetMissionFlag(%Mid,9002,1);

	%Player.UpdateMission(%Mid);
}
function Mission_End_Process_20148(%Npc,%Player,%Conv,%Param,%Mid)
{
	if ($SL_CangBaoTu_State_bActive == 1)
	{
		%ran =getrandom(1,100);
		if (%ran >= 50)
		{
			%player.putitem(113090002,1);
			%player.additem(1,%Mid);
		}
	}
}
//■■■■【藏宝图】■■■■【任务处理】■■■■■■■■


//■■■■【藏宝图】■■■■【道具使用】■■■■■■■■
//108030001	唤妖铃
function Trigger_108030001(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	%Act4013[0] = GetAct(%Player,4013,0);
	%Act4013[1] = GetAct(%Player,4013,1);
	%MapID = getzoneid();
	if (%state == 0)
	{
		if (%MapID != %Act4013[0])
			%dialogid = 600000023;
		else
		{
			%Pos_A = $strMapRanPosRecord[%Act4013[0],%Act4013[1]];
			%Pos_AX = GetWord(%Pos_A,0);
			%Pos_AY = GetWord(%Pos_A,1);
			%Pos_B = %player.getposition();
			%Pos_BX = GetWord(%Pos_B,0);
			%Pos_BY = GetWord(%Pos_B,1);
			if (msqrt(mpow(%Pos_AX - %Pos_BX,2)+mpow(%Pos_AY - %Pos_BY,2)) > 10)
				%dialogid = 600000023;
			else
				%dialogid = 0;
		}
		if (%dialogid > 0)
		{
			// 记住下面两条指令对于物品触发任务非常重要
			%Conv.Reset();	//重置所有选项
			%Conv.SetTriggerType(1);
			%Conv.SetTriggerMission(%Type);
			%Conv.SetType(1);
			%Conv.SetText(%dialogid);
			%Conv.Send(%Player);
		}
		else
		{
			%Player.putitem(%Type,-1);
			if (%player.additem(1,%type))
			{
				%Monster = SpNewNpc3(0,440000018,%Player.GetPosition(),0,0,"1 1 1");
				%Monster.SetLevel(%Player.GetLevel());//设置计算怪物等级
				%Monster.SetExclusivePlayerId(%Player.getplayerid());
				%Monster.SetExclusivePlayerName(%player.getobjectname());	//单独设置独占的称号
				%Monster.BelongPlayer = %Player.GetPlayerID();
				%T = "妖灵已经出现，请尽快将其诛杀。";
				SendOneChatMessage($chatMsg_System,%T,%Player); //玩家公告
			}
		}
	}
}
//113090002	藏宝图
function Trigger_113090001(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){Trigger_113090002(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ);}
function Trigger_113090002(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	//echo( "%XYZ===" @ %XYZ  @ "     %State===" @ %State);
	if ($SL_CangBaoTu_State_bActive != 1)
	{
		SendOneScreenMessage(2,"藏宝图活动暂时已经关闭，无法使用",%Player);
		return;
	}
	if (%Player.getlevel() < $SL_CangBaoTu_Level)
	{
		SendOneScreenMessage(2,"等级低于" @ $SL_CangBaoTu_Level @ "级，无法开启藏宝图",%Player);
		%Conv.settype(4);
		return -1;
	}
	%Conv.Reset();	//重置所有选项
	%Conv.SetTriggerType(1);
	%Conv.SetTriggerMission(%Type);
	%Conv.SetType(1);

	if (%state == 0)
	{
		if (%Player.isHavePoint(%XYZ) == 0)
		{
			%List = GetRandomPosForMap(0);
			%MapID = GetWord(%List,0);
			%PosID = GetWord(%List,1);

			%Player.SetTreasurePos(%XYZ,8 @ %MapID @ "0100",%PosID,0);
			setact(%player,4014,%MapID,%PosID);
			%dialogid = 600000024;
		}
		else
		{
			%triggerid = %Player.GetPositionPoint(%XYZ,0);
			%PosID = %Player.GetPositionPoint(%XYZ,1);
			//echo( "%triggerid ===" @ %triggerid );
			//echo( "%PosID ===" @ %PosID );
			%TargetMapid = getsubstr(%triggerid,1,4);
			%nowmapid = getzoneid();
			setact(%player,4014,%TargetMapid,%PosID);
			//echo( getact( %player, 4014, 0 ) @ " " @  getact( %player, 4014, 1 ) );
			if (%TargetMapid  != %nowmapid)
				%dialogid = 600000024;
			else
			{
				%tarPosX = getword($strMapRanPosRecord[%TargetMapid,%PosID],0);
				%tarPosY = getword($strMapRanPosRecord[%TargetMapid,%PosID],1);
				%nowposX = getword(%player.getposition(),0);
				%nowposY = getword(%player.getposition(),1);
				if (msqrt(mpow(%tarPosX - %nowposX,2) + mpow(%tarPosY - %nowposY,2)) >= 10)
					%dialogid = 600000024;
				else
					%dialogid = 0;
			}
		}
		if (%dialogid > 0)
		{
			%Conv.SetText(%dialogid);
			%Conv.Send(%Player);
		}
		else
		{
			%conv.settype(4);
			%Act4012[0] = GetAct(%Player,4012,0);
			%Act4012[1] = GetAct(%Player,4012,1);
			//echo("VIP_getNowTequanLvMaxCnt(%Player, 8)=====" @ VIP_getNowTequanLvMaxCnt(%Player, 8));
			if (%Act4012[1] >= VIP_getNowTequanLvMaxCnt(%Player, 8))
			{
				%T = "您今日的开图" @ VIP_getNowTequanLvMaxCnt(%Player, 8) @ "次，已达到上限。";
				SendOneScreenMessage(2,%T,%Player);
				SendOneChatMessage($chatMsg_System,%T,%Player);
			}
			else
			{
				if (%Act4012[1] == 9)
					SetStrategyRecord(%Player,108);//攻略触发记录

				SetAct(%player,4012,%Act4012[0],%Act4012[1]++);
				//%Player.putitem( %type, -1 );
				//if ( %player.additem( 1, %type ) )
				DelItemFromInventoryByIndex(%Player.GetPlayerID(),%XYZ,%Type,1,16,Type);
				Trigger_113090002_A(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ);
			}
			%Conv.SetType(4);
			%Conv.Send(%Player);
		}
	}
	//
}
function Trigger_113090002_A(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	%Pos = %player.getposition();
	%mapid = getzoneid();
	%Ran = getrandom(1,100);
	//触发类型	概率	说明
	//空空如也	20%	说明东西都没		自身屏幕中央	哎呀，看来此张宝图为赝品，浪费时力！！！
	//闪电	10%	掉血50% + 250*等级		全服屏幕中央	xxx在xxx地方寻宝触怒一方神灵，惹得神明降下雷霆之怒！
	//迷雾	10%	眩晕15S		全服屏幕中央	xxx在xxx地方寻宝挖出地脉中的瘴气，弄的晕头转向，好不狼狈！
	//小妖	55%	宝箱奖励		全服屏幕中央	xxx运气不错，在xx地挖宝，拾得小妖遗留下来的xxx
	//妖王	5%	宝箱奖励		全服屏幕中央+左下	福兮祸兮？xxx在xx地挖宝，触动了仙魔封印，妖王逃往XX祸害四方，望八方修士前往降服！
	%PlayerName = GetPlayerZiTiName(%Player,1);
	%PlayerName2 = GetPlayerZiTiName(%Player,2);
	%MapName = GetMapName(%Player,2);
	%Path = "<l i='" @ GetSubStr(%Player.Gettriggerid(),0,7) @ "00 " @ %Player.GetPosition() @ "' t='path'/>";

	if (%ran <= 20)
	{
		%T = "哎呀，看来此张宝图为赝品，浪费时力！！！";
		SendOneScreenMessage(2,%T,%Player);
		SendOneChatMessage($chatMsg_System,%T,%Player);
	}
	else if (%ran <= 30)
	{
		%Msg2 = %Playername2 @ "<t>在</t>" @ %MapName  @ "<t>寻宝触怒一方神灵，惹得神明降下雷霆之怒！</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg2 @ "</t>", $chatMsg_Type_Normal2);
	}
	else if (%ran <= 40)
	{
		%Msg2 = %Playername2 @ "<t>在</t>" @ %MapName  @ "<t>寻宝挖出地脉中的瘴气，弄的晕头转向，好不狼狈！</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg2 @ "</t>", $chatMsg_Type_Normal2);
	}
	else if (%ran <= 95)
	{
		%obj = SpNewCj2(%Player,553000002,0,%player.getlayerid(),0,"1 1 1");
		%Obj.masterplayer = %player.getplayerid();
		%Obj.masterplayername  = %player.getplayername();
		%Obj.setshapename("妖王的宝箱（" @  %Obj.masterplayername  @ "）");

		%BaoxiangName  = $Get_Dialog_GeShi[31422] @ "【妖王的宝箱】</t>";
		%Msg2 = %Playername2 @ "<t>运气不错，在</t>" @ %MapName  @ "<t>挖宝，拾得小妖遗留下来的</t>" @ %BaoxiangName;
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg2 @ "</t>", $chatMsg_Type_Normal2);
	}
	else
	{
		if ($CangBaoTu_YaoWang_NumBerNow < $CangBaoTu_YaoWang_MaxNumBer && $CangBaoTu_YaoWang_CreateCD <= 0)
		{
			switch (getrandom(1,3))
			{
				case 1:%text = GetPlayerZiTiName(%Player,1) @ "<t>在</t>" @ %Path @ "<t>挖宝时，一不留神破坏了封印，一只妖王破封而出,修士们可前去斩妖除魔！</t>";
				case 2:%text = GetPlayerZiTiName(%Player,1) @ "<t>在挖宝时，一头撞进了妖王的老巢，哪位修士前往</t>" @ %Path @ "<t>救他一命。</t>";
				case 3:%text = "<t>福兮祸兮？</t>" @ GetPlayerZiTiName(%Player,1) @ "<t>在</t>" @ %Path @ "<t>挖宝，触动了仙魔封印，妖王逃往</t>" @ %Path @ "<t>祸害四方，望八方修士前往降服！</t>";
			}
			//echo( "text===" @ %text );
			if (%text !$="")
				SendOneLineMessage($Get_Dialog_GeShi[31419] @ %text @ "</t>");


			%Teshu2 = $Get_Dialog_GeShi[60003] @ "『" @ GetNpcData(440000017,1) @ "』</t>"; //活动名称 橙色
			%Text2 = %Teshu2 @ "<t>出现在</t>" @ $Get_Dialog_GeShi[60002] @ %MapName @ "<t>。</t>";
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);


			%Opj = SpNewNpc3(0,440000017,%Pos,%player.getlayerid(),0,"1 1 1");
			%Opj.setlevel(%player.getlevel());
			$MonsterCount[%mapid,440000017]++;
			$CangBaoTu_YaoWang_NumBerNow++;

			$CangBaoTu_YaoWang_CreateCD = 1;
			%Time = GetLocalTime();
			%H = GetWord(%Time,3);	//小时
			CanCel($ResultYaoWang_CeateCD);
			$ResultYaoWang_CeateCD = Schedule($CangBaoTu_YaoWang_CreateCD[%H] * 60 * 1000,0,"ResultYaoWang_CeateCD");
		}
		else
		{
			%T = "哎呀，看来此张宝图为赝品，浪费时力！！！";
			SendOneScreenMessage(2,%T,%Player);
			SendOneChatMessage($chatMsg_System,%T,%Player);
		}
	}
}
//■■■■【藏宝图】■■■■【道具使用】■■■■■■■■


//■■■■【藏宝图】■■■■【宝箱奖励】■■■■■■■■
function TriggerEvent_553000002(%Player,%Event,%EventID)
{
	//echo( "%Event=== " @ %Event );
	if (%Event.masterplayer != %player.getplayerid())
	{
		if (sptgetplayer(%Event.masterplayer).GetDamageState() $= "Enabled")
		{
			%T = "必须击败宝箱主人才可以开启宝箱";
			SendOneScreenMessage(2,%T,%Player);
			SendOneChatMessage($chatMsg_System,%T,%Player);
			return false;
		}
		%PlayerName = GetPlayerZiTiName(%Player,1);
		%Mastername = "<l i='" @ %Event.masterplayername @ " " @ %Event.masterplayer @ "' t='name' />";
		%Text = %Playername @ "<t>手起刀落，抢了</t>" @ %Mastername @ "<t>的</t>" @ $Get_Dialog_GeShi[31422] @ "妖王宝箱</t>" @ "<t>。</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");
		TriggerEvent_553000002_A(%player,1);
		%Event.safedeleteobject();
		return true;
	}
	else
	{
		TriggerEvent_553000002_A(%player,2);
		%Event.safedeleteobject();
		return true;
	}
}
function TriggerEvent_553000002_A(%player,%optype)
{
	//$SL_ZhuYao_item[ 1 ]  ="102106019;1;714;0";
	%GiveCount = 0;
	for (%i=1; %i<=99; %i++)
	{
		if ($SL_ZhuYao_item[%i] $= "")
			break;
		if (%GiveCount >= 2)
			break;

		%Ran = Getrandom(1,10000);
		%iran = getword($SL_ZhuYao_item[%i],2,";") * 1;
		if (%Ran <= %iran)
		{
			%itemid = getword($SL_ZhuYao_item[%i],0,";");
			%itemnum = getword($SL_ZhuYao_item[%i],1,";");
			%msg = getword($SL_ZhuYao_item[%i],3,";");

			if (%itemid > 0)
			{
				if (%itemid  == 105020503 || %itemid  == 105020553 || %itemid  == 109051001 || %itemid  == 109051011 || %itemid  == 109051021)
					%itemid = GetItemForPlayerLevel(%Player,%itemid);
				%player.putitem(%itemid,%itemnum);
				if (%player.additem(4,553000002))
				{
					%GiveCount++;
					if (%msg >= 1)
					{
						%ItemName = GetItemName(%ItemID,1);
						%ItemName2 = GetItemName(%ItemID,2);

						%PlayerName1 = GetPlayerZiTiName(%Player,1);
						%PlayerName2 = GetPlayerZiTiName(%Player,2);
						%HuoDongMingCheng1 = GetHuoDongName("妖王宝藏",1);
						%HuoDongMingCheng2 = GetHuoDongName("妖王宝藏",2);
						%MapName = GetMapName(%Player,2);
						%Path = "<l i='" @ GetSubStr(%Player.Gettriggerid(),0,7) @ "00 " @ %Player.GetPosition() @ "' t='path'/>";
						%Msgran = GetRanDom(1,4);
						//echo( "%Msgran===" @ %Msgran );
						switch (%Msgran)
						{
							case 1:
								%Text1 = "<t>福星高照，</t>" @ %PlayerName1 @ "<t>在</t>" @ %Path @ "<t>地挖掘藏宝图，喜获</t>" @ %ItemName @ "<t>！</t>";
								%Text2 = "<t>福星高照，</t>" @ %PlayerName2 @ "<t>在</t>" @ %MapName @ "<t>地挖掘藏宝图，喜获</t>" @ %ItemName2 @ "<t>！</t>";
							case 2:
								%Text1 = %PlayerName1 @ "<t>运气不错，在</t>" @ %Path @ "<t>地挖宝，拾得小妖遗留下来的</t>" @ %ItemName @ "<t>！</t>";
								%Text2 = %PlayerName2 @ "<t>运气不错，在</t>" @ %MapName @ "<t>地挖宝，拾得小妖遗留下来的</t>" @ %ItemName2 @ "<t>！</t>";
							case 3:
								%Text1 = %PlayerName1 @ "<t>好运不停，在</t>" @ %Path @ "<t>地挖宝，劫得妖王宝物</t>" @ %ItemName @ "<t>！</t>";
								%Text2 = %PlayerName2 @ "<t>好运不停，在</t>" @ %MapName @ "<t>地挖宝，劫得妖王宝物</t>" @ %ItemName2 @ "<t>！</t>";
							case 4:
								%Text1 = %PlayerName1 @ "<t>运气爆棚，在</t>" @ %Path @ "<t>赶跑妖王，得到妖王宝藏获得</t>" @ %ItemName @ "<t>！</t>";
								%Text2 = %PlayerName2 @ "<t>运气爆棚，在</t>" @ %MapName @ "<t>赶跑妖王，得到妖王宝藏获得</t>" @ %ItemName2 @ "<t>！</t>";
						}
						switch (%msg)
						{
							case 1:
								SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Text1 @ "</t>");
							case 2:
								SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
							case 3:
								SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Text1 @ "</t>");
								SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
						}
					}
				}
			}
		}
	}
	if (%GiveCount == 0)
	{
		%Lucky = %Player.GetLuck();//获取玩家福缘值
		%Money = (50 + %Player.GetLevel()) *9;
		%Money = %Money + (10000 - %Money)*((%Lucky/2000)+ mfloor((%Lucky/100))/20);
		%Money = GetRanDom(%Money,10000);
		%Player.AddMoney(%Money,2,4,553000002);
	}
}
//■■■■【藏宝图】■■■■【宝箱奖励】■■■■■■■■


//■■■■【藏宝图】■■■■【妖王死亡触发】■■■■■■
function NpcObjectonDeathcast_440000017(%Monster,%Player)
{
	%mapid = getzoneid();
	$MonsterCount[%mapid,440000017]--;


	%GiveCount = 0;
	for (%i=1; %i<=99; %i++)
	{
		if ($SL_ZhuYao_YaoWang[%i] $= "")
			break;
		if (%GiveCount >= 4)
			break;

		%Ran = Getrandom(1,10000);
		%iran = getword($SL_ZhuYao_YaoWang[%i],2,";") * 1;
		if (%Ran <= %iran)
		{
			%itemid = getword($SL_ZhuYao_YaoWang[%i],0,";");
			%itemnum = getword($SL_ZhuYao_YaoWang[%i],1,";");
			%msg = getword($SL_ZhuYao_YaoWang[%i],3,";");

			if (%itemid > 0)
			{
				if (%itemid  == 105020503 || %itemid  == 105020553 || %itemid  == 109051001 || %itemid  == 109051011 || %itemid  == 109051021)
					%itemid = GetItemForPlayerLevel(%Player,%itemid);
				%GiveCount++;
				SpNewDropItem(%Monster,%Player,%itemid,%itemnum,%msg);
			}
		}
	}
	%Lucky = %Player.GetLuck();//获取玩家福缘值
	%Money = (500 + %Player.GetLevel()) *10;
	%Money = %Money + (50000 - %Money)*((%Lucky/2000)+ mfloor((%Lucky/100))/20);
	%Money = GetRanDom(%Money,50000);
	//echo( "%Money===" @ %Money );
	SpNewDropItem(%Monster,%Player,105270001,%Money,0);
}
//■■■■【藏宝图】■■■■【妖王死亡触发】■■■■■■

//■■■■【藏宝图】■■■■【妖王数量控制】■■■■■■
function ResultYaoWang_CeateCD()
{
	CanCel($ResultYaoWang_CeateCD);
	$CangBaoTu_YaoWang_CreateCD = 0;
}
function CaoBaoTu_YaoWangNumBer(%YY,%MM,%DD,%H,%M,%S)
{
	if ($SL_ZhuYao_State_bActive != 1)
		return;
	if (%M == 0 || $CangBaoTu_YaoWang_MaxNumBer == 0)
	{
		CanCel($ResultYaoWang_CeateCD);
		$CangBaoTu_YaoWang_NumBerNow = 0;
		$CangBaoTu_YaoWang_CreateCD = 0;
		%HuoYueRenShu = GetRenShuTongJiForEveryday(3);
		%HuoYueRenShu = GetWord(%HuoYueRenShu,0) + GetWord(%HuoYueRenShu,1) + GetWord(%HuoYueRenShu,2);//活跃人数
		if (%HuoYueRenShu < 200)
			%HuoYueRenShu = 200;
		$CangBaoTu_YaoWang_MaxNumBer = mceil($CangBaoTu_YaoWang_MaxNumBer[%H] * (1 + (%HuoYueRenShu - 200)/500));
	}

}
//■■■■【藏宝图】■■■■【妖王数量控制】■■■■■■

function GetItemForPlayerLevel(%Player,%itemid)
{
	switch (%itemid)
	{
		case 105020503://跌打药
			%ItemID[1] = 105020503; %NeedLevel[1] = 30;	//跌打药
			%ItemID[2] = 105020504; %NeedLevel[2] = 40;	//金创药
			%ItemID[3] = 105020505; %NeedLevel[3] = 50;	//活血丹
			%ItemID[4] = 105020506; %NeedLevel[4] = 60;	//大还丹
			%ItemID[5] = 105020507; %NeedLevel[5] = 70;	//血梨丹
			%ItemID[6] = 105020508; %NeedLevel[6] = 80;	//三花聚命丹
			%ItemID[7] = 105020509; %NeedLevel[7] = 90;	//五虎保命丹
			%ItemID[8] = 105020510; %NeedLevel[8] = 100;//九花续命丹
		case 105020553://回灵露
			%ItemID[1] = 105020553; %NeedLevel[1] = 30;//回灵露
			%ItemID[2] = 105020554; %NeedLevel[2] = 40;//黄仙露
			%ItemID[3] = 105020555; %NeedLevel[3] = 50;//聚灵散
			%ItemID[4] = 105020556; %NeedLevel[4] = 60;//还神散
			%ItemID[5] = 105020557; %NeedLevel[5] = 70;//玉露散
			%ItemID[6] = 105020558; %NeedLevel[6] = 80;//三花凝神散
			%ItemID[7] = 105020559; %NeedLevel[7] = 90;//五气聚魂散
			%ItemID[8] = 105020560; %NeedLevel[8] = 100;//九天凝神散
		case 109051001://《金创药》药方
			%ItemID[1] = 109051001; %NeedLevel[1] = 40;//《金创药》药方
			%ItemID[2] = 109051002; %NeedLevel[2] = 50;//《活血丹》药方
			%ItemID[3] = 109051003; %NeedLevel[3] = 60;//《大还丹》药方
			%ItemID[4] = 109051004; %NeedLevel[4] = 70;//《血梨丹》药方
			%ItemID[5] = 109051005; %NeedLevel[5] = 80;//《三花聚命丹》药方
			%ItemID[6] = 109051006; %NeedLevel[6] = 90;//《五虎保命丹》药方
			%ItemID[7] = 109051007; %NeedLevel[7] = 100;//《九花续命丹》药方
		case 109051011://《黄仙露》药方
			%ItemID[1] = 109051011; %NeedLevel[1] = 40;//《黄仙露》药方		
			%ItemID[2] = 109051012; %NeedLevel[2] = 50;//《聚灵散》药方		
			%ItemID[3] = 109051013; %NeedLevel[3] = 60;//《还神散》药方		
			%ItemID[4] = 109051014; %NeedLevel[4] = 70;//《玉露散》药方		
			%ItemID[5] = 109051015; %NeedLevel[5] = 80;//《三花凝神散》药方
			%ItemID[6] = 109051016; %NeedLevel[6] = 90;//《五气聚魂散》药方
			%ItemID[7] = 109051017; %NeedLevel[7] = 100;//《九天凝神散》药方
		case 109051021://《六阳正气丸》药方
			%ItemID[1] = 109051021; %NeedLevel[1] = 50;//《六阳正气丸》药方
			%ItemID[2] = 109051022; %NeedLevel[2] = 65;//《天香玉露丸》药方
			%ItemID[3] = 109051023; %NeedLevel[3] = 80;//《神农百草丸》药方
			%ItemID[4] = 109051024; %NeedLevel[4] = 95;//《回天再造丸》药方
	}
	%PlayerLevel = %Player.GetLevel();
	for (%i = 1; %i <=99; %i++)
	{
		if (%ItemID[%i] $= "" || %NeedLevel[%i] > %PlayerLevel)
		{
			%Record = %i - 1;
			break;
		}
	}
	if (%Record == 0)
		%EndItemID = %itemid;
	else
		%EndItemID = %ItemID[%Record];
	return %EndItemID;
}
/*
%ItemID[ 1 ] = 111; %NeedLevel[ 1 ] = 111;//
%ItemID[ 2 ] = 111; %NeedLevel[ 2 ] = 111;//
%ItemID[ 3 ] = 111; %NeedLevel[ 3 ] = 111;//
%ItemID[ 4 ] = 111; %NeedLevel[ 4 ] = 111;//
%ItemID[ 5 ] = 111; %NeedLevel[ 5 ] = 111;//
%ItemID[ 6 ] = 111; %NeedLevel[ 6 ] = 111;//
%ItemID[ 7 ] = 111; %NeedLevel[ 7 ] = 111;//
%ItemID[ 8 ] = 111; %NeedLevel[ 8 ] = 111;//
%ItemID[ 9 ] = 111; %NeedLevel[ 9 ] = 111;//
%ItemID[ 10 ]= 111; %NeedLevel[ 10 ]= 111;//
%ItemID[ 11 ]= 111; %NeedLevel[ 11 ]= 111;//
%ItemID[ 12 ]= 111; %NeedLevel[ 12 ]= 111;//
%ItemID[ 13 ]= 111; %NeedLevel[ 13 ]= 111;//
%ItemID[ 14 ]= 111; %NeedLevel[ 14 ]= 111;//
*/