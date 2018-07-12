//                                                                                ==
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//世界BOSS
//                                                                                =
//■■■■【世界BOSS】■■■■【刷新函数】■■■■■■■■
//■■■■【世界BOSS】■■■■【BOSS死亡】■■■■■■■■
//■■■■【世界BOSS】■■■■【区域触发】■■■■■■■■

//■■■■【世界BOSS】■■■■【刷新函数】■■■■■■■■
function HuoDong_ShiJieBoss_Create(%YY,%MM,%DD,%H,%M,%S)
{
	if ($SL_ShiJieBoss_State_bActive != 1)
		return;
	%LineID = GetCurrentLineId();//线程ID
	%ZoneID = GetSubStr(GetZoneID(),0,4);
	//echo("                    ====" @  $SL_ShiJieBoss_bActive[ %ZoneID ] );
	//echo( $ShiJieBoss_MonSter[ %ZoneID ] );
	if ($SL_ShiJieBoss_bActive[%ZoneID] $= "")
		return;
	if (isobject($ShiJieBoss_MonSter[%ZoneID]))
		return;
	%LeiXin = %LineID @ %ZoneID;
	%Time_A = GetWord(GetServerSystemEvent(%LeiXin),0);
	%Time_B = GetWord(GetServerSystemEvent(%LeiXin),1);
	%TimeNowDays = %YY * 365 + %MM * 30 +  %DD;
	%TimeDieDays = GetSubStr(%Time_A,0,4) * 365 + GetSubStr(%Time_A,4,2) * 30 + GetSubStr(%Time_A,6,2);
	%Time_Now = %H * 60 + %M + (%TimeNowDays - %TimeDieDays) * 24 * 60;
	%Time_Die = %Time_B;
	%Time = %Time_Now - %Time_Die;
	%TimeCD = Getword($SL_ShiJieBoss_bActive[%ZoneID],1);
	echo("%LeiXin          " @ %LeiXin);
	echo("GetServerSystemEvent(%LeiXin)==" @ GetServerSystemEvent(%LeiXin));
	echo("%Time_A          " @ %Time_A);
	echo("%Time_B          " @ %Time_B);
	echo("%TimeNowDays     " @ %TimeNowDays);
	echo("%TimeDieDays     " @ %TimeDieDays);
	echo("%Time_Now     ===" @ %Time_Now);
	echo("%Time_Die     ===" @ %Time_Die);
	echo("%Time          ==" @ %Time);
	echo("%TimeCD          " @ %TimeCD);

	if (%Time >= %TimeCD * 60)
	{
		if (isobject($ShiJieBoss_MonSter[%ZoneID]))
			return;
		else
		{
			%NpcID = Getword($SL_ShiJieBoss_bActive[%ZoneID],0);
			%Pos = Getword($SL_ShiJieBoss_bActive[%ZoneID],2) @ " " @ Getword($SL_ShiJieBoss_bActive[%ZoneID],3) @ " " @ Getword($SL_ShiJieBoss_bActive[%ZoneID],4);
			$ShiJieBoss_MonSter[%ZoneID] = SpNewNpc2(0,%NpcID,%Pos,0,0);

			//%Tab = "<t c='0x2cffeeff'o='0x010101ff'>";//主要文本字体
			switch (%ZoneID)
			{
				case 1119:
					%TriggerID = "811190100";
				default:
					for (%i = 1; %i <= 9; %i++)
					{
						%TriggerIDA = "8" @ %ZoneID @ "0" @ %i *100;
						if (GetTriggerData(%TriggerIDA,0) > 0)
							%TriggerID = %TriggerIDA;
						else
							break;
					}
			}

			%Path = "<l i='" @ %TriggerID @ " " @ %Pos @ "' t='path'/>";
			%Teshu = GetNpcZiTiName(%NpcID,1);
			%Text = %Teshu @ "<t>出现在</t>" @ %Path @ "<t>。</t>";
			SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

			//echo( "%Triggerid====" @ %Triggerid );
			%MapName = GetMapName(%Triggerid,2);
			%Teshu2 = GetNpcZiTiName(%NpcID,2);
			%Text2 = %Teshu2 @ "<t>出现在</t>" @ $Get_Dialog_GeShi[60002] @ %MapName @ "</t><t>。</t>";
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);

			SetServerSystemEvent(%LeiXin,$NowServerTime1,%H * 60 + %M);
		}
	}
}
//■■■■【世界BOSS】■■■■【刷新函数】■■■■■■■■


//■■■■【世界BOSS】■■■■【BOSS死亡】■■■■■■■■
$BossItem[440000001] = "106071032 1 192 3;106071032 1 108 3;";
$BossItem[440000002] = "106071033 1 168 3;106071033 1 90 3;";
$BossItem[440000003] = "106071034 1 156 3;106071034 1 84 3;";
$BossItem[440000004] = "";
$BossItem[440000005] = "";
$BossItem[440000006] = "";
$BossItem[440000007] = "";
$BossItem[440000008] = "109011102 1 78 3;109012102 1 78 3;109013102 1 78 3;109014102 1 78 3;101014005 1 48 3;101024005 1 48 3;101034005 1 48 3;101044005 1 48 3;";
$BossItem[440000009] = "109011103 1 64 3;109012103 1 64 3;109013103 1 64 3;109014103 1 64 3;101014006 1 42 3;101024006 1 42 3;101034006 1 42 3;101044006 1 42 3;";
$BossItem[440000010] = "109011104 1 60 3;109012104 1 60 3;109013104 1 60 3;109014104 1 60 3;101014007 1 36 3;101024007 1 36 3;101034007 1 36 3;101044007 1 36 3;";
$BossItem[440000011] = "";
$BossItem[440000012] = "";
$BossItem[440000013] = "";
$BossItem[440000014] = "";

function KilledMonster_440000001(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_440000001_440000014(%Player,%Monster,%SharePlayerNum,%MaxConnection,$StrategySubBtnSrc[5,2]); }//青丘狐王
function KilledMonster_440000002(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_440000001_440000014(%Player,%Monster,%SharePlayerNum,%MaxConnection,$StrategySubBtnSrc[5,4]); }//苍山雪海BOS
function KilledMonster_440000003(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_440000001_440000014(%Player,%Monster,%SharePlayerNum,%MaxConnection,0); }//1103boss
function KilledMonster_440000004(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_440000001_440000014(%Player,%Monster,%SharePlayerNum,%MaxConnection,0); }//1104boss
function KilledMonster_440000005(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_440000001_440000014(%Player,%Monster,%SharePlayerNum,%MaxConnection,0); }//1105boss
function KilledMonster_440000006(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_440000001_440000014(%Player,%Monster,%SharePlayerNum,%MaxConnection,0); }//1106boss
function KilledMonster_440000007(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_440000001_440000014(%Player,%Monster,%SharePlayerNum,%MaxConnection,0); }//1107boss
function KilledMonster_440000008(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_440000001_440000014(%Player,%Monster,%SharePlayerNum,%MaxConnection,$StrategySubBtnSrc[5,3]); }//地宫1boss
function KilledMonster_440000009(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_440000001_440000014(%Player,%Monster,%SharePlayerNum,%MaxConnection,0); }//地宫2boss
function KilledMonster_440000010(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_440000001_440000014(%Player,%Monster,%SharePlayerNum,%MaxConnection,0); }//地宫3boss
function KilledMonster_440000011(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_440000001_440000014(%Player,%Monster,%SharePlayerNum,%MaxConnection,0); }//地宫4boss
function KilledMonster_440000012(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_440000001_440000014(%Player,%Monster,%SharePlayerNum,%MaxConnection,0); }//地宫5boss
function KilledMonster_440000013(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_440000001_440000014(%Player,%Monster,%SharePlayerNum,%MaxConnection,0); }//地宫6boss
function KilledMonster_440000014(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_440000001_440000014(%Player,%Monster,%SharePlayerNum,%MaxConnection,0); }//地宫7boss

function KilledMonster_440000001_440000014(%Player,%Monster,%SharePlayerNum,%MaxConnection,%StrategyId)
{
	%NpcID = GetNpcData(%Monster.GetDataId(),0);
	%FuYuan = %Player.getLuck();//福缘值
	%HuoYueRenShu = GetRenShuTongJiForEveryday(3);
	%HuoYueRenShu = GetWord(%HuoYueRenShu,0) + GetWord(%HuoYueRenShu,1) + GetWord(%HuoYueRenShu,2);//活跃人数
	if (%HuoYueRenShu < 200)
		%HuoYueRenShu = 200;
	if (%HuoYueRenShu > 1000)
		%HuoYueRenShu = 1000;
	//（基础概率/有效范围人数）*（1+（活跃人数/500）+ （自身福缘值/1000））
	if ($BossItem[%NpcID] !$= "")
	{
		%Count = GetWordCount($BossItem[%NpcID],";");
		for (%i = 0; %i < %Count; %i++)
		{
			%List = GetWord($BossItem[%NpcID],%i,";");
			%ItemID = GetWord(%List,0);
			%ItemNum = GetWord(%List,1);
			%Ran = GetWord(%List,2);
			%Msg = GetWord(%List,3);
			%Ran = (%Ran / %SharePlayerNum) *(1+(%HuoYueRenShu /500)+(%FuYuan /1000));
			%RanDom = GetRanDom(1,10000);
			if (%RanDom < %Ran)
				SpNewDropItem(%Monster,%Player,%ItemID,%ItemNum,%Msg);
		}
	}
	if (%StrategyId > 0)
		SetStrategyRecord(%Player,%StrategyId);//攻略触发记录
}
function KilledMonster_440000015(%Player,%Monster,%SharePlayerNum,%MaxConnection)//建帮令boss 
{
	SetStrategyRecord(%Player,$StrategySubBtnSrc[5,0]);//攻略触发记录
}
function KilledMonster_440000016(%Player,%Monster,%SharePlayerNum,%MaxConnection)//攻城令boss
{
	SetStrategyRecord(%Player,$StrategySubBtnSrc[5,1]);//攻略触发记录
}
function NpcObjectonDeathcast_440000001(%Monster,%Killer) { NpcKilled_ShiJieBoss(%Monster,%Killer); }	//青丘狐王
function NpcObjectonDeathcast_440000002(%Monster,%Killer) { NpcKilled_ShiJieBoss(%Monster,%Killer); }	//苍山雪海BOS
function NpcObjectonDeathcast_440000003(%Monster,%Killer) { NpcKilled_ShiJieBoss(%Monster,%Killer); }	//1103boss
function NpcObjectonDeathcast_440000004(%Monster,%Killer) { NpcKilled_ShiJieBoss(%Monster,%Killer); }	//1104boss
function NpcObjectonDeathcast_440000005(%Monster,%Killer) { NpcKilled_ShiJieBoss(%Monster,%Killer); }	//1105boss
function NpcObjectonDeathcast_440000006(%Monster,%Killer) { NpcKilled_ShiJieBoss(%Monster,%Killer); }	//1106boss
function NpcObjectonDeathcast_440000007(%Monster,%Killer) { NpcKilled_ShiJieBoss(%Monster,%Killer); }	//1107boss
function NpcObjectonDeathcast_440000008(%Monster,%Killer) { NpcKilled_ShiJieBoss(%Monster,%Killer); }	//地宫1boss
function NpcObjectonDeathcast_440000009(%Monster,%Killer) { NpcKilled_ShiJieBoss(%Monster,%Killer); }	//地宫2boss
function NpcObjectonDeathcast_440000010(%Monster,%Killer) { NpcKilled_ShiJieBoss(%Monster,%Killer); }	//地宫3boss
function NpcObjectonDeathcast_440000011(%Monster,%Killer) { NpcKilled_ShiJieBoss(%Monster,%Killer); }	//地宫4boss
function NpcObjectonDeathcast_440000012(%Monster,%Killer) { NpcKilled_ShiJieBoss(%Monster,%Killer); }	//地宫5boss
function NpcObjectonDeathcast_440000013(%Monster,%Killer) { NpcKilled_ShiJieBoss(%Monster,%Killer); }	//地宫6boss
function NpcObjectonDeathcast_440000014(%Monster,%Killer) { NpcKilled_ShiJieBoss(%Monster,%Killer); }	//地宫7boss
function NpcKilled_ShiJieBoss(%Monster,%Killer)
{
	%Time = GetLocalTime();
	%LineID = GetCurrentLineId();//线程ID
	%ZoneID = GetSubStr(GetZoneID(),0,4);
	%LeiXin = %LineID @ %ZoneID;
	%H = GetWord(%Time,3); //时
	%M = GetWord(%Time,4);
	echo("%LeiXin====" @ %LeiXin);
	echo("%$NowServerTime1====" @ $NowServerTime1);
	echo("%H * 60 + %M====" @ %H * 60 + %M);
	SetServerSystemEvent(%LeiXin,$NowServerTime1,%H * 60 + %M);
}

function NpcObjectonDeathcast_440000015(%Monster,%Killer) //建帮令boss 
{
	%Time = GetLocalTime();
	%LineID = GetCurrentLineId();//线程ID
	%ZoneID = GetSubStr(GetZoneID(),0,4);
	%LeiXin = %LineID @ %ZoneID;
	%H = GetWord(%Time,3); //时
	%M = GetWord(%Time,4);
	SetServerSystemEvent(%LeiXin,$NowServerTime1,%H * 60 + %M);
	SpNewDropItem(%Monster,%Killer,105109052,1,3);
}

function NpcObjectonDeathcast_440000016(%Monster,%Killer) //攻城令boss
{
	%Time = GetLocalTime();
	%LineID = GetCurrentLineId();//线程ID
	%ZoneID = GetSubStr(GetZoneID(),0,4);
	%LeiXin = %LineID @ %ZoneID;
	%H = GetWord(%Time,3); //时
	%M = GetWord(%Time,4);
	SetServerSystemEvent(%LeiXin,$NowServerTime1,%H * 60 + %M);
	SpNewDropItem(%Monster,%Killer,105109053,1,3);
}
//■■■■【世界BOSS】■■■■【BOSS死亡】■■■■■■■■

//■■■■【世界BOSS】■■■■【区域触发】■■■■■■■■
function Trigger_114070001(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_114070001_114070007(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,399170001,2033); }//游仙符箓
function Trigger_114070002(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_114070001_114070007(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,399170002,2034); }//落日符箓
function Trigger_114070003(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_114070001_114070007(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,399170003,2035); }//地宫符箓
function Trigger_114070004(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_114070001_114070007(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,399170004,2036); }//地宫符箓
function Trigger_114070005(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_114070001_114070007(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,399170005,2037); }//地宫符箓
function Trigger_114070006(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_114070001_114070007(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,399170006,2038); }//地宫符箓
function Trigger_114070007(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_114070001_114070007(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,399170007,2039); }//地宫符箓
function Trigger_114070001_114070007(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%BuffID,%FreeSchbuff)
{
	%Player.Putitem(%type,-1);
	if (%Player.Additem(1,%type))
	{
		//echo("=================" @ %Player.GetBuffCount(GetSubStr(%BuffID,0,5),GetSubStr(%BuffID,5,4)));
		if (%Player.GetBuffCount(GetSubStr(%BuffID,0,5),GetSubStr(%BuffID,5,4)) >  0)
			%Player.AddBuff(%BuffID,%Player,-1);

		%Player.SetSchbuff(%FreeSchbuff);
	}
}
//PlayerEnterTrigger_811280200( 263271,811280200);
function PlayerEnterTrigger_811280200(%Player,%TriggerId){ PlayerEnterTrigger_811280200_811400100(%Player,%TriggerId,2033,399170001,2022); }
function PlayerEnterTrigger_811290400(%Player,%TriggerId){ PlayerEnterTrigger_811280200_811400100(%Player,%TriggerId,2034,399170002,2023); }
function PlayerEnterTrigger_811300400(%Player,%TriggerId){ PlayerEnterTrigger_811280200_811400100(%Player,%TriggerId,2035,399170003,2024); }
function PlayerEnterTrigger_811310400(%Player,%TriggerId){ PlayerEnterTrigger_811280200_811400100(%Player,%TriggerId,2036,399170004,2025); }
function PlayerEnterTrigger_811320400(%Player,%TriggerId){ PlayerEnterTrigger_811280200_811400100(%Player,%TriggerId,2037,399170005,2026); }
function PlayerEnterTrigger_811330400(%Player,%TriggerId){ PlayerEnterTrigger_811280200_811400100(%Player,%TriggerId,2038,399170006,2027); }
function PlayerEnterTrigger_811340400(%Player,%TriggerId){ PlayerEnterTrigger_811280200_811400100(%Player,%TriggerId,2039,399170007,2028); }
function PlayerEnterTrigger_811280200_811400100(%Player,%TriggerId,%FreeSchbuff,%BuffID,%SchBuffID)
{
	%Player.SetSchbuff(%SchBuffID);
	if (%Player.IsSchbuff(%FreeSchbuff))
		return;
	%Player.AddBuff(%BuffID,%Player,1);
}

function PlayerOnExitTrigger_811280200(%Player){ PlayerOnExitTrigger_811280200_811400100(%Player,2033,399170001,2022); }
function PlayerOnExitTrigger_811290400(%Player){ PlayerOnExitTrigger_811280200_811400100(%Player,2034,399170002,2023); }
function PlayerOnExitTrigger_811300400(%Player){ PlayerOnExitTrigger_811280200_811400100(%Player,2035,399170003,2024); }
function PlayerOnExitTrigger_811310400(%Player){ PlayerOnExitTrigger_811280200_811400100(%Player,2036,399170004,2025); }
function PlayerOnExitTrigger_811320400(%Player){ PlayerOnExitTrigger_811280200_811400100(%Player,2037,399170005,2026); }
function PlayerOnExitTrigger_811330400(%Player){ PlayerOnExitTrigger_811280200_811400100(%Player,2038,399170006,2027); }
function PlayerOnExitTrigger_811340400(%Player){ PlayerOnExitTrigger_811280200_811400100(%Player,2039,399170007,2028); }
function PlayerOnExitTrigger_811280200_811400100(%Player,%FreeSchbuff,%BuffID,%SchBuffID)
{
	if (%Player.GetBuffCount(GetSubStr(%BuffID,0,5),GetSubStr(%BuffID,5,4)) >  0)
		%Player.AddBuff(%BuffID,%Player,-1);

	%Player.RemoveSchBuff(%SchBuffID);
}
function ScheduleBuff_2022(%Player,%BuffID,%IsAuto){ ScheduleBuff_2022_2028(%Player,2022,%IsAuto,2033,399170001,811280200); }
function ScheduleBuff_2023(%Player,%BuffID,%IsAuto){ ScheduleBuff_2022_2028(%Player,2023,%IsAuto,2034,399170002,811290400); }
function ScheduleBuff_2024(%Player,%BuffID,%IsAuto){ ScheduleBuff_2022_2028(%Player,2024,%IsAuto,2035,399170003,811300400); }
function ScheduleBuff_2025(%Player,%BuffID,%IsAuto){ ScheduleBuff_2022_2028(%Player,2025,%IsAuto,2036,399170004,811310400); }
function ScheduleBuff_2026(%Player,%BuffID,%IsAuto){ ScheduleBuff_2022_2028(%Player,2026,%IsAuto,2037,399170005,811320400); }
function ScheduleBuff_2027(%Player,%BuffID,%IsAuto){ ScheduleBuff_2022_2028(%Player,2027,%IsAuto,2038,399170006,811330400); }
function ScheduleBuff_2028(%Player,%BuffID,%IsAuto){ ScheduleBuff_2022_2028(%Player,2028,%IsAuto,2039,399170007,811340400); }
function ScheduleBuff_2022_2028(%Player,%SchBuffID,%IsAuto,%FreeSchbuff,%BuffID,%TriggerID)
{
	//echo( "%Player.GetTriggerID( )==" @ %Player.GetTriggerID( ) );
	if (%Player.GetTriggerID() != %TriggerID)
	{
		if (%Player.GetBuffCount(GetSubStr(%BuffID,0,5),GetSubStr(%BuffID,5,4)) >  0)
			%Player.AddBuff(%BuffID,%Player,-1);
		return true;
	}
	%Player.SetSchbuff(%SchBuffID);
	if (%Player.IsSchbuff(%FreeSchbuff))
	{
		if (%Player.GetBuffCount(GetSubStr(%BuffID,0,5),GetSubStr(%BuffID,5,4)) >  0)
			%Player.AddBuff(%BuffID,%Player,-1);
		return 0;
	}
	%Player.AddBuff(%BuffID,%Player,1);
	return 0;
}
//■■■■【世界BOSS】■■■■【区域触发】■■■■■■■■

$PosRecordForRan = 0;
function SetPosForRan(%Player)
{
	$PosRecordForRan[$PosRecordForRan] = %Player.GetPosition();
	$PosRecordForRan++;
}
function GetPosForRan()
{
	for (%i = 0; %i < 999; %i++)
	{
		if ($PosRecordForRan[%i] !$= "")
		{
			%NumBer = %i + 1;
			if (%NumBer <= 9) %NumBer = "  " @ %NumBer;
			if (%NumBer <= 99) %NumBer = " " @ %NumBer;
			echo("===" @ %NumBer @ "     " @ $PosRecordForRan[%i]);
		}
		else
			break;
	}
}
