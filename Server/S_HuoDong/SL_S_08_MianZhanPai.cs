//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//免战牌
//==================================================================================
//39907	1	免战
//2029 2 1 72000 0 0 1 1 item/105021004 <t>【免战牌】</t><b/><t>---------------------</t><b/><t>高挂免战牌，拒绝参战。</t><b/><t>---------------------</t><b/><t>携带此状态无法攻击其他玩家，也不可以被其他玩家攻击。请远离首领怪物区域，否则将会失去此状态</t>
//2030 2 2 60	1 0	0 1 item/105021004 <t>【免战牌】</t><b/><t>---------------------</t><b/><t>每分钟触发是否给予免战</t>

//■■■【免战牌】■■■■■【道具使用触发】■■■■■■■
//■■■【免战牌】■■■■■【免战调度BUFF】■■■■■■■
//■■■【免战牌】■■■■■【杀人禁止免战】■■■■■■■
//■■■【免战牌】■■■■■【区域是否可免战】■■■■■■
//■■■【免战牌】■■■■■【挂机触发】■■■■■■■■■

//■■■【免战牌】■■■■■【道具使用触发】■■■■■■■
function Trigger_105109091(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109091_105109098(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,20); }
function Trigger_105109092(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109091_105109098(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,34); }
function Trigger_105109093(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109091_105109098(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,35); }
function Trigger_105109094(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109091_105109098(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,36); }
function Trigger_105109095(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109091_105109098(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,37); }
function Trigger_105109096(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109091_105109098(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,38); }
function Trigger_105109097(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109091_105109098(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,39); }
function Trigger_105109098(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109091_105109098(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,40); }

function Trigger_105109091_105109098(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%Dialogid)
{
	%Time = GetLocalTime();
	%H = GetWord(%Time,3);	//小时
	%M = GetWord(%Time,4);	//分钟
	%S = GetWord(%Time,5);	//秒
	if (%H >= 6 && %H < 22)
	{
		%Txt = "免战牌只允许在22:00至次日6:00之前使用";
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		return;
	}
	if (%Player.IsSchbuff(2029))
	{
		%Txt = "当前状态无法使用免战牌";
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		return;
	}
	if (%Player.GetPKValue() > 0)
	{
		%Txt = "红名状态无法使用免战牌";
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		return;
	}
	%IsCanOpen = GetIsCanOpenMianZhan(%Player,0);
	if (!%IsCanOpen)
	{
		%Txt = "当前区域不允许开启免战";
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		return;
	}
	%Player.ShowDialogOk(2000000020,%Dialogid,1);
}

function MianZhanPaiUse(%Player,%ItemID,%Timemins)
{
	%Time = GetLocalTime();
	%H = GetWord(%Time,3);	//小时
	%M = GetWord(%Time,4);	//分钟
	%S = GetWord(%Time,5);	//秒
	if (%H <= 23)
		%CanHaveTime = (24 - %H) * 60 + 6 * 60 - %M;
	else
		%CanHaveTime = (6 - %H) * 60 - %M;
	%NowHaveTime = mceil(%Player.GetSchBuff(2040)/60);
	//echo( "%CanHaveTime===" @ %CanHaveTime );
	//echo( "%NowHaveTime===" @ %NowHaveTime );
	if (%NowHaveTime >= %CanHaveTime)
	{
		SendOneScreenMessage(2,"你的免战时间已达到上限",%Player);
		return;
	}
	if (%Timemins + %NowHaveTime > %CanHaveTime)
		%Timemins = %CanHaveTime - %NowHaveTime;

	//echo( "%Timemins===" @ %Timemins );
	%Player.PutItem(%ItemID,-1);
	if (%Player.Additem(1,%ItemID))
	{
		if (%Player.IsSchBuff(2040) ==1)
			%Player.AddSchBuff(2040,-%Timemins * 60);
		else
		{
			%Player.SetSchBuff(2040);
			%Player.AddSchBuff(2040,39600 - %Timemins * 60);
		}

		//%Player.SetSchbuff( 2030 );
		//%Player.AddBuff( 399070001, %Player, 1 );
	}
}
//■■■【免战牌】■■■■■【道具使用触发】■■■■■■■

//■■■【免战牌】■■■■■【免战调度BUFF】■■■■■■■
function ScheduleBuff_2030(%Player,%BuffID,%IsAuto)
{
	//echo( "====" @ %Player.GetObjectname( ) @ "  2029===" @ %Player.GetSchbuff( 2029 )  @ "    2030===" @ %Player.GetSchbuff( 2030 ) @ "  2040===" @ %Player.GetSchbuff( 2040 ));
	if (%Player.GetSchBuff(2040) >= 1)
	{
		if ($NowServerTime3 <= 360 || $NowServerTime3 >= 1320)
		{
			if (%Player.AssistantRecord == 1)
				%Player.AddBuff(399070001,%Player,1);
			%Player.SetSchbuff(2030);
			return 0;
		}
		else
		{
			%Player.RemoveSchBuff(2040);
			return 1;
		}
	}
	return 1;
}
function ScheduleBuff_2041(%Player,%BuffID,%IsAuto)
{
	%Time = GetLocalTime();
	%H = GetWord(%Time,3);	//小时
	%M = GetWord(%Time,4);	//分钟
	%S = GetWord(%Time,5);	//秒
	if (%H >= 6 && %H < 22)
	{
		%Txt = "免战牌只允许在22:00至次日6:00之前使用";
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		return 1;
	}
	if (%Player.IsSchbuff(2029))
	{
		%Txt = "当前状态无法使用免战牌";
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		return 1;
	}
	if (%Player.GetPKValue() > 0)
	{
		%Txt = "红名状态无法使用免战牌";
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		return 1;
	}
	%IsCanOpen = GetIsCanOpenMianZhan(%Player,0);
	if (!%IsCanOpen)
	{
		%Txt = "当前区域不允许开启免战";
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		return 1;
	}
	if (%Player.AssistantRecord == 1)
	{
		%Player.SetSchbuff(2030);
		%Player.AddBuff(399070001,%Player,1);
	}
	return 1;
}
//■■■【免战牌】■■■■■【免战调度BUFF】■■■■■■■

//■■■【免战牌】■■■■■【杀人禁止免战】■■■■■■■
function PlayeronDeathForMianZhanPai(%Player,%Killer)
{
	if (%Player.GetPkValue() > 0)
		return;
	%BuffTime = %Killer.GetSchbuff(2029);
	if (%BuffTime >= 3600)
		return;
	%Killer.SetSchbuff(2029);
	%Killer.AddSchbuff(2029,68400);
}
//■■■【免战牌】■■■■■【杀人禁止免战】■■■■■■■

//■■■【免战牌】■■■■■【区域是否可免战】■■■■■■
function GetIsCanOpenMianZhan(%Player,%TriggerID)
{
	if (%TriggerID == 0)
		%TriggerID = %Player.GetTriggerid();
	%TriNumber = GetSubStr(%TriggerID,6,1);
	switch (%TriNumber)
	{
		case 1:
			%MapID = GetSubStr(GetZoneID(),0,4);
			switch (%MapID)
			{
				case 1119:return false;
				case 1118:return false;
				case 1120:return false;
				case 1121:return false;
				case 1122:return false;
				default:
					if (%MapID > 1300)
						return false;
			}
			switch (%TriggerID)
			{
				case 811020106:return false;
			}
			return true;
		default:
			return false;
	}
}
//■■■【免战牌】■■■■■【区域是否可免战】■■■■■■

//■■■【免战牌】■■■■■【挂机触发】■■■■■■■■■
function  ChangeCombatAssistant(%Player,%State)
{
	//echo( "挂机触发===" @ %State );
	switch (%State)
	{
		case 1://开始挂机
			if (%Player.GetSchBuff(2040) >= 1)
				%Player.SetSchbuff(2041);
			%Player.AssistantRecord = 1;
		case 0://结束挂机
			%Player.AssistantRecord = 0;
			if (%Player.GetBuffCount(39907,1) >= 1)
				%Player.RemoveBuff(399070001);
			if (%Player.IsSchbuff(2041))
				%Player.RemoveSchBuff(2041);
			if (%Player.IsSchbuff(2030))
				%Player.RemoveSchBuff(2030);
	}
}
//■■■【免战牌】■■■■■【挂机触发】■■■■■■■■■
