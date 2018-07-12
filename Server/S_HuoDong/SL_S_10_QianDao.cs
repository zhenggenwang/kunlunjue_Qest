//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//签到功能
//==================================================================================
//■■■■【签到】■■■■【存取函数】■■■■■■
//■■■■【签到】■■■■【登录签到】■■■■■■
//■■■■【签到】■■■■【补签】■■■■■■■■
//■■■■【签到】■■■■【登录计时】■■■■■■

//■■■■【签到】■■■■【存放函数】■■■■■■
function SetQianDaoRecord(%Player,%Days)
{
	if (%Days == 0)
		return;
	if (%Days > 15)
	{
		%Act = GetAct(%Player,4020,1);
		%Act = SetBit(%Act,%Days - 16);
		SetAct(%Player,4020,GetAct(%Player,4020,0),%Act);
	}
	else
	{
		%Act = GetAct(%Player,4020,0);
		%Act = SetBit(%Act,%Days);
		SetAct(%Player,4020,%Act,GetAct(%Player,4020,1));
	}
	//-----------发放每天签到奖励---------
	if (GetSubStr($NowServerTime1,6,2) * 1 == %Days * 1 && GetSrc(%Player,7) == 0)//补签没有每天奖励
	{
		AddItem_BaoGuoNo_Mail(%Player,GetMeiRiQianDaoLingJiangItem(),1,1,"3 4020");
		SetSrc(%player,7);
	}
	//--------发放累计天数奖励----------
	%HaveDaysrecord = GetALLQianDaoRecordDays(%Player);//获取本月签到天数
	for (%i = 1; %i<= 4; %i++)
	{
		if (%HaveDaysrecord >= $MeiYueLeiJiQianDao[%i] && GetSrc(%Player,7 + %i) == 0)
		{
			SetSrc(%player,7 + %i);
			AddItem_BaoGuoNo_Mail(%Player, GetMeiYueLeiJiQianDaoItem(%i), 1, 1, "3 4020");

			//%ItemID = "<l i='" @ GetMeiYueLeiJiQianDaoItem(%i) @ "' t='itemid'/>";
			//%PathID = "<l i='810010100 124.213 2.14262 100.059' t='path'/>";
			//%MailText = "<t>您本月累计签到天数达到 </t>" @ $Get_Dialog_GeShi[31222] @ %HaveDaysrecord @ "</t><t>天，获得</t>" @ %ItemID @ "<b/><t>请及时收取,祝您游戏愉快！</t>";
			//
			//%MailText = $Get_Dialog_GeShi[31406] @ %MailText @ "</t>";
			//SptMail_SendBindPlayer(%Player.GetPlayerID(),GetMeiYueLeiJiQianDaoItem(%i),1,0,0,"签到累计奖励",%MailText,0,1);
		}
	}
}
//■■■■【签到】■■■■【存放函数】■■■■■■



//■■■■【签到】■■■■【点击签到】■■■■■■
function RecordLonginGame(%Player)
{
	%ToDay = GetSubStr($NowServerTime1,6,2);
	if (GetQiandaoRecord(%Player,%ToDay) == 0)
	{
		SetQianDaoRecord(%Player,%ToDay);
		SetStrategyRecord(%Player,$StrategySubBtnSrc[2,1]);//攻略触发记录
	}
}
//■■■■【签到】■■■■【点击签到】■■■■■■


//■■■■【签到】■■■■【补签】■■■■■■■■
function QianDaoBuQian(%Player)
{
	%ToDay = GetSubStr($NowServerTime1,6,2);
	for (%i = 1; %i< %ToDay; %i++)
	{
		%Bit = GetQiandaoRecord(%Player,%i);
		if (%Bit == 0)
		{
			%Player.ReduceMoney($QianDaoBuQian,1,1,4020);
			SetQianDaoRecord(%Player,%i);
			SendOneScreenMessage(1,"补签成功",%Player);
			SendOneChatMessage($chatMsg_System,"<t>补签成功</t>",%Player);
			return;
		}
	}
	SendOneScreenMessage(1,"没有需要补签的日期",%Player);
	SendOneChatMessage($chatMsg_System,"<t>没有需要补签的日期</t>",%Player);
	return;
}
//■■■■【签到】■■■■【补签】■■■■■■■■

//■■■■【签到】■■■■【登录计时】■■■■■■

function DengLuZaiXianJiShi(%Player)
{
	//echo( "%Player === " @  %Player );
	if (GetSrc(%Player,12) == 1)
		return;
	//echo( "%Player === " @  %Player );
	if (%player.isschbuff(2008) == 1)
		return;
	//echo( "%Player === " @  %Player );
	%Player.Setschbuff(2008);
	//echo( %Player.isschbuff( 2008 ) );
}

function ScheduleBuff_2008(%Player,%BuffID,%IsAuto)//2008 2 2 900 1 0 0 1 item/105028001 <t>【在线计时】</t><b/><t>---------------------</t><b/><t>当计时结束后，获得在线15分钟活跃度奖励</t>
{
	SetSrc(%Player,12);
	%Player.removeschbuff(2008);
	%Player.Setschbuff(2009);
	return 0;
}
function ScheduleBuff_2009(%Player,%BuffID,%IsAuto)//2009 2 2 900 1 0 0 1 item/105028001 <t>【在线计时】</t><b/><t>---------------------</t><b/><t>当计时结束后，获得在线30分钟活跃度奖励</t>
{
	SetSrc(%Player,13);
	SendRenShuTongJito1001(%Player);//服务器记录当前活跃玩家+1
	%Player.removeschbuff(2009);
	%Player.Setschbuff(2010);
	return 0;
}
function ScheduleBuff_2010(%Player,%BuffID,%IsAuto)//2010 2 2 1800 1	0 0 1 item/105028001 <t>【在线计时】</t><b/><t>---------------------</t><b/><t>当计时结束后，获得在线1小时活跃度奖励</t>
{
	SetSrc(%Player,14);
	%Player.removeschbuff(2010);
	%Player.Setschbuff(2011);
	return 0;
}
function ScheduleBuff_2011(%Player,%BuffID,%IsAuto)//2011 2 2 3600 1	0 0 1 item/105028001 <t>【在线计时】</t><b/><t>---------------------</t><b/><t>当计时结束后，获得在线2小时活跃度奖励</t>
{
	SetSrc(%Player,15);
	return 1;
}