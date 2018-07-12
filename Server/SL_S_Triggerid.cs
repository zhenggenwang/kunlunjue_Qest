//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//本处脚本多为 区域触发专用 功能性脚本，所有地图均会载入
//==================================================================================
//■■■■■■■■■■■角色进出区域触发脚本■■■■■■■■■■■
//■■■■■■■■■■■怪物进出区域触发脚本■■■■■■■■■■■
//■■■■■■■■■■■进出区域储存玩家编号■■■■■■■■■■■
//■■■【区域触发】■■■■【1010】■■■【蓬莱】■■■■■■■■
//■■■【区域触发】■■■■【1001】■■■【昆仑】■■■■■■■■
//■■■【区域触发】■■■■【1101】■■■【望仙谷】■■■■■■■



//上田野：-149.21 25.4789 116.506  田野上主城：-71.5519 107.092 124.529     下右边野区：91.2146 70.5762 134.25           上右边野区：125.758 17.7665 122.023
//SptGetPlayer( 50000022).TransportObject(0, 0,-149.21 ,20.4789 ,120.506);
//SptMail_Send( 50000146, 0, 0, 123, 321, "123", "222" );SptMail_Send( 50000146, 0, 0, 123, 0, "123", "222" );SptMail_Send( 50000146, 0, 0, 0, 321, "123", "222" );
//SptMail_Send(  50000250, 105180255, 1, 111, 222, "123", "222" );
//■■■■■■■■■■■角色进出区域触发脚本■■■■■■■■■■■
//进入区域触发脚本
//离开区域触发脚本
//进入区域特殊触发脚本

//进入区域触发脚本
function OnEnterTrigger(%Player,%TriggerId)
{
	putout(" 【 进入区域触发脚本 】 = " @ %TriggerId);
	//echo( "=====" @ %player.gettriggerid( ) );
	//获取PlayerID
	%PlayerID = %Player.GetPlayerID();
	%CopyMapID = %Player.GetLayerID();

	//-----------是否是传送区域---------------------
	if ($Transport_TargetID[%TriggerId] !$= "")
	{
		%TargetTriggerId = GetWord($Transport_TargetID[%TriggerId],0);
		%iLevelNeed = GetWord($Transport_TargetID[%TriggerId],1) * 1;
		%iLevel = GetMetempsychosisLeve(%Player);
		if ( %TriggerId == 811030110 )
		{
			SendOneScreenMessage( 2, "该地图暂未开放，敬请期待！", %player );
			return;
		}
		if (!%player.isschbuff(1003))
		{
			if (%iLevel >=  %iLevelNeed)
			{
				%Player.SetSchbuff(1003);//虚无BUFF
				SpNewEff(%Player,$SP_Effect[6],0);//传送特效
				//echo( "%TargetTriggerId===============" @ %TargetTriggerId );
				GoToNextMap(%Player,%TargetTriggerId,"");
			}
			else
			{
				SendOneScreenMessage(2,"要求等级" @ %iLevelNeed @ "，你的等级不足，无法传送",%player);
				SendOneChatMessage($chatMsg_System,"<t>要求等级" @ %iLevelNeed @ "，你的等级不足，无法传送</t>",%player);
			}
		}
	}
	//---------------------------------------------------------------
	if (%Player.Isschbuff(2040))//判断该区域是否允许免战
	{
		%IsCanOpenMianZhan = GetIsCanOpenMianZhan(%Player,%TriggerID);
		if (!%IsCanOpenMianZhan)
		{
			if (%Player.GetBuffCount(39907,1) >= 1)
				%Player.RemoveBuff(399070001);
			if (%Player.IsSchbuff(2041))
				%Player.RemoveSchBuff(2041);
			if (%Player.IsSchbuff(2030))
				%Player.RemoveSchBuff(2030);
		}
	}

	//----------是否给予进入安全区域和危险区域的提示-----------------
	//else if ( %CopyMapID <= 1 && %Player.Getlevel( ) >= 30 )//副本内不做处理
	//{
	//	if ( %Player.inTriggerId !$= "" )
	//		%CanPkLast = CheckBit( GetTriggerData( %Player.inTriggerId, 11 ), 2 );
	//	%CanPkNow = CheckBit( GetTriggerData( %TriggerId, 11 ), 2 );
	//	//echo( "CanPkLast ====" @ %CanPkLast );
	//	//echo( "CanPkNow ====" @ %CanPkNow );
	//	if ( %CanPkNow !=  %CanPkLast )
	//	{
	//		switch ( %CanPkNow )
	//		{
	//			case 0:
	//				%Text = "你已进入安全区域，当前区域无法PK";
	//				SendOneScreenMessage( 1, %Text, %player );
	//				SendOneChatMessage( $chatMsg_System, "<t>" @ %Text @ "</t>", %player );
	//			case 1:
	//				%Text = "你已进入危险区域，当前区域可PK";
	//				SendOneScreenMessage( 2, %Text, %player );
	//				SendOneChatMessage( $chatMsg_System, "<t>" @ %Text @ "</t>", %player );
	//		}
	//	}
	//}
	//%Player.inTriggerId = %TriggerId;//记录区域
	//----------------------------------------------------------------

	//特殊处理
	%FuncName = "PlayerEnterTrigger_" @ %TriggerID;
	if (isFunction(%FuncName))
		eval(%FuncName @ "(%Player, %TriggerId);");
}



//进入区域特殊触发脚本
//范例：PlayerEnterTrigger_100000001(%Player, %TriggerId);




//离开区域触发脚本
function OnExitTrigger(%Player,%triggerId)
{
	Putout(" 【 离开区域触发脚本 】 = " @ %TriggerId);

	%FuncName = "PlayerOnExitTrigger_" @ %TriggerID;
	if (isFunction(%FuncName))
		eval(%FuncName @ "(%Player);");
}
//■■■■■■■■■■■角色进出区域触发脚本■■■■■■■■■■■

//■■■■■■■■■■■怪物进出区域触发脚本■■■■■■■■■■■
//进入区域总接口
//离开区域总接口
//进出区域触发脚本

//进入区域总接口
function OnNpcEnterTrigger(%Npc,%TriggerID)
{
	%FuncName = "NpcEnterTrigger_" @ %TriggerID;
	if (isFunction(%FuncName))
		eval(%FuncName @ "(%Npc, %TriggerID);");
}

//离开区域总接口
function OnNpcExitTrigger(%Npc,%triggerId)
{
	%FuncName = "NpcExitTrigger_" @ %TriggerID;
	if (isFunction(%FuncName))
		eval(%FuncName @ "(%Npc, %TriggerID);");
}

//进入区域触发脚本范例：
//NpcEnterTrigger_813020101(%Npc, %TriggerID);
//离开区域触发脚本范例：
//NpcExitTrigger_813020101(%Npc, %TriggerID);

//■■■■■■■■■■■怪物进出区域触发脚本■■■■■■■■■■■

//■■■■■■■■■■■进出区域储存玩家编号■■■■■■■■■■■
function Trigger_Area_PlayerMemory(%Player,%TriggerId,%fashion)
{
	%CopyMapID = %Player.GetLayerId();
	%CopyMapID = (%CopyMapID == 0) ? 1 : %CopyMapID;

	%AreaID = $Camera_Begin_Player[%CopyMapID,%TriggerId];
	%T_Num = GetWordCount(%AreaID);

	switch (%fashion)
	{
		//进入区域时的触发
		case 0:
			if (%AreaID $= "")
				%Player_A = $Camera_Begin_Player[%CopyMapID,%TriggerId] = %Player;
			else
				%Player_A = $Camera_Begin_Player[%CopyMapID,%TriggerId] = %AreaID @" "@%Player;

			//离开区域时的触发
		case 1:
			%Player_A = $Camera_Begin_Player[%CopyMapID,%TriggerId] = "";
			for (%i = 0; %i < %T_Num; %i++)
			{
				%Player_B = GetWord(%AreaID,%i," ");

				if ((%Player_B !$= %Player) && (isobject(%Player_B) == 1) && (%Player_B.GetDamageState() $= "Enabled"))
					%Player_A = $Camera_Begin_Player[%CopyMapID,%TriggerId] = (%Player_A $= "") ? %Player_B : %Player_A @" "@%Player_B;
			}

		case 2:
			%Player_A = $Camera_Begin_Player[%CopyMapID,%TriggerId] = "";
			for (%i = 0; %i < %T_Num; %i++)
			{
				%Player_B = GetWord(%AreaID,%i," ");

				if ((isobject(%Player_B) == 1) && (%Player_B.GetDamageState() $= "Enabled"))
				{
					//获取区域内所有Npc
					%Player_A = $Camera_Begin_Player[%CopyMapID,%TriggerId] = (%Player_A $= "") ? %Player_B : %Player_A @" "@%Player_B;
				}
			}

		case 3:
			for (%i = 0; %i < %T_Num; %i++)
			{
				%Player_B = GetWord(%AreaID,%i," ");

				if ((isobject(%Player_B) == 1) && (%Player_B.GetDamageState() $= "Enabled"))
				{
					if ((%Player_B.GetEnterTriggerId(1) == 811030120) || (%Player_B.GetEnterTriggerId(2) == 811030120))
					{
						//获取区域内所有可战斗的Npc
						if (%Player_B.GetBuffCount(33065,10) == 0)
							%Player_C = (%Player_C $= "") ? %Player_B : %Player_C @" "@%Player_B;
					}
				}
			}
			return %Player_C;

	}

	return %Player_A;
}


//■■■■■■■■■■■进出区域储存玩家编号■■■■■■■■■■■

//■■■【区域触发】■■■■【1010】■■■【蓬莱】■■■■■■■■
//-----新建角色登录时进入区域----
function PlayerEnterTrigger_810100101(%Player,%TriggerId)
{
	return;
	//echo( "PlayerEnterTrigger_810100101===" @ %TriggerId );
	if (%Player.IsFinishedMission(10001))
		return;
	if (%Player.Trigger[810100101] == 1)
		return;
	%Player.Trigger[810100101] = 1;

	CanCel(%Player.Schedule[10001]);
	%Player.Schedule[10001]  = Schedule(2000,0,"eval",%Player @ ".SetMovieMode(1, 10001);");
}
function PlayerEnterTrigger_810100102(%Player,%TriggerId)
{
	//echo( "============SSSSSSSSSSSSSS==============" @ %TriggerId );
	if (%Player.FlyPathID == 0)
	{
		%Player.FlyPathID = 10100007;
		FlyMeToTheMoon(%Player,10100007,702005801);
	}
}
function PlayerEnterTrigger_810100115(%Player,%TriggerId)
{
	//echo( "============DDDDDDDDDDDDDDDDDDD==============" @ %TriggerId );
	if (%Player.FlyPathID == 0)
	{
		%Player.FlyPathID = 10100006;
		FlyMeToTheMoon(%Player,10100006,702005801);
	}
}

function PlayerEnterTrigger_810010104(%Player,%TriggerId)
{
	if (%Player.GetLevel() < 20)
	{
		SendOneScreenMessage(2,"等级低于20级，无法前往封魔城",%Player);
		return;
	}
	//echo( "============SSSSSSSSSSSSSS==============" @ %TriggerId );
	if (%Player.FlyPathID == 0)
	{
		%Player.FlyPathID = 10010001;
		FlyMeToTheMoon(%Player,10010001,702005801);
	}
}
function PlayerEnterTrigger_810010105(%Player,%TriggerId)
{
	//echo( "============SSSSSSSSSSSSSS==============" @ %TriggerId );
	if (%Player.FlyPathID == 0)
	{
		%Player.FlyPathID = 10010002;
		FlyMeToTheMoon(%Player,10010002,702005801);
	}
}

function PlayerEnterTrigger_810100117(%Player,%TriggerId)//试炼之地
{
	%AAA = %Player.IsAcceptedMission(10241);
	if (%AAA == 1)
	{
		%Player.ShowDialogOk(2000000017,17,0);//确认框
	}
}
function PlayerEnterTrigger_810100118(%Player,%TriggerId)//探查源头
{
	if (%Player.IsAcceptedMission(10291))
	{
		%Player.ShowDialogOk(2000000018,18,0);//确认框
	}
	if (%Player.IsAcceptedMission(10301))
	{
		%Type = %Player.GetMissionFlag(10301,3300);
		%Num = %Player.GetMissionFlag(10301,3200);
		//echo( "%Type=====" @ %Type @ "%Num=======" @ %Num );
		if (%Type != %Num)
		{
			ChangeLogicFloor(%Player,0,%Player);//进入镜像层
			Mission_Special_10301(%Player,%mid);//重新树怪
		}
	}
}


function PlayerEnterTrigger_810100200(%Player,%TriggerId)
{
	%AAA = %Player.IsAcceptedMission(10341);
	if (%AAA == 1)
	{
		Schedule( 200, 0, "HelpDirectByIndex", %Player.getPlayerID(), 30 );
		//播放小电影
		Schedule(2200,0,"CameraPathBegin",%Player.GetControllingClient(),10100010);
	}
}
//------------离开初始小岛触发----------
function PlayerOnExitTrigger_810100101(%Player,%TriggerId)
{
	if (%Player.IsAcceptedMission(10001))
	{
		%Player.SetMission(10001,1);//完成第一个任务
		AddMissionAccepted(%Player,0,10002);//接第二个任务
	}
}



//■■■【区域触发】■■■■【1010】■■■【蓬莱】■■■■■■■■

//■■■【区域触发】■■■■【1101】■■■【望仙谷】■■■■■■■

function PlayerEnterTrigger_811010100(%Player,%TriggerId)
{
	//echo( "%TriggerId=========" @ %TriggerId );
	if (%Player.IsAcceptedMission(10421))
	{
		%Player.AddDesignation(801);//初出茅庐      	添加一个新的称号
		%Player.SetCurDesignationIDZone(801);//	设置此称号为当前正在使用的称号
		%PlayerID = %Player.GetPlayerID();
		//通讯客户端	打开指引界面
		//echo( "%PlayerID=========" @ %PlayerID );
		Schedule(3000,0,"HelpDirectByIndex",%PlayerID,14);
	}
}

function PlayerEnterTrigger_811010103(%Player,%TriggerId)//探秘狐王
{
	if (%Player.IsAcceptedMission(10931))
	{
		%Player.ShowDialogOk(2000000031,31,0);//确认框
	}
}
function PlayerEnterTrigger_811280100(%Player,%TriggerId)//陨仙窟
{
	if (%Player.IsAcceptedMission(10951))
	{
		Schedule(5000,0,"TanKuangQueRen_10951",%Player,10951);
	}
}
function PlayerEnterTrigger_811280202(%Player,%TriggerId)//陨仙窟二层
{
	if (%Player.IsAcceptedMission(11021))
	{
		%Player.SetMission(11021,1);//完成
		%Player.AddExp(25705);
		AddMissionAccepted(%Player,0,11022);//接下一个任务
	}
}
function PlayerEnterTrigger_811020100(%Player,%TriggerId)//苍山雪海
{
	if (%Player.IsAcceptedMission(11041))
	{
		Schedule(3000,0,"ShiMenPaoHuan_11041",%Player,11041);
	}
}
function PlayerEnterTrigger_811020103( %Player, %TriggerId )//封剑台
{
	if ( %Player.IsAcceptedMission( 11232 ) )
	{
		%Player.ShowDialogOk( 2000000019, 19, 0 );//确认框
	}
}