//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//ǩ������
//==================================================================================
//����������ǩ����������������ȡ������������������
//����������ǩ����������������¼ǩ����������������
//����������ǩ����������������ǩ������������������
//����������ǩ����������������¼��ʱ��������������

//����������ǩ����������������ź�����������������
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
	//-----------����ÿ��ǩ������---------
	if (GetSubStr($NowServerTime1,6,2) * 1 == %Days * 1 && GetSrc(%Player,7) == 0)//��ǩû��ÿ�콱��
	{
		AddItem_BaoGuoNo_Mail(%Player,GetMeiRiQianDaoLingJiangItem(),1,1,"3 4020");
		SetSrc(%player,7);
	}
	//--------�����ۼ���������----------
	%HaveDaysrecord = GetALLQianDaoRecordDays(%Player);//��ȡ����ǩ������
	for (%i = 1; %i<= 4; %i++)
	{
		if (%HaveDaysrecord >= $MeiYueLeiJiQianDao[%i] && GetSrc(%Player,7 + %i) == 0)
		{
			SetSrc(%player,7 + %i);
			AddItem_BaoGuoNo_Mail(%Player, GetMeiYueLeiJiQianDaoItem(%i), 1, 1, "3 4020");

			//%ItemID = "<l i='" @ GetMeiYueLeiJiQianDaoItem(%i) @ "' t='itemid'/>";
			//%PathID = "<l i='810010100 124.213 2.14262 100.059' t='path'/>";
			//%MailText = "<t>�������ۼ�ǩ�������ﵽ </t>" @ $Get_Dialog_GeShi[31222] @ %HaveDaysrecord @ "</t><t>�죬���</t>" @ %ItemID @ "<b/><t>�뼰ʱ��ȡ,ף����Ϸ��죡</t>";
			//
			//%MailText = $Get_Dialog_GeShi[31406] @ %MailText @ "</t>";
			//SptMail_SendBindPlayer(%Player.GetPlayerID(),GetMeiYueLeiJiQianDaoItem(%i),1,0,0,"ǩ���ۼƽ���",%MailText,0,1);
		}
	}
}
//����������ǩ����������������ź�����������������



//����������ǩ�����������������ǩ����������������
function RecordLonginGame(%Player)
{
	%ToDay = GetSubStr($NowServerTime1,6,2);
	if (GetQiandaoRecord(%Player,%ToDay) == 0)
	{
		SetQianDaoRecord(%Player,%ToDay);
		SetStrategyRecord(%Player,$StrategySubBtnSrc[2,1]);//���Դ�����¼
	}
}
//����������ǩ�����������������ǩ����������������


//����������ǩ����������������ǩ������������������
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
			SendOneScreenMessage(1,"��ǩ�ɹ�",%Player);
			SendOneChatMessage($chatMsg_System,"<t>��ǩ�ɹ�</t>",%Player);
			return;
		}
	}
	SendOneScreenMessage(1,"û����Ҫ��ǩ������",%Player);
	SendOneChatMessage($chatMsg_System,"<t>û����Ҫ��ǩ������</t>",%Player);
	return;
}
//����������ǩ����������������ǩ������������������

//����������ǩ����������������¼��ʱ��������������

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

function ScheduleBuff_2008(%Player,%BuffID,%IsAuto)//2008 2 2 900 1 0 0 1 item/105028001 <t>�����߼�ʱ��</t><b/><t>---------------------</t><b/><t>����ʱ�����󣬻������15���ӻ�Ծ�Ƚ���</t>
{
	SetSrc(%Player,12);
	%Player.removeschbuff(2008);
	%Player.Setschbuff(2009);
	return 0;
}
function ScheduleBuff_2009(%Player,%BuffID,%IsAuto)//2009 2 2 900 1 0 0 1 item/105028001 <t>�����߼�ʱ��</t><b/><t>---------------------</t><b/><t>����ʱ�����󣬻������30���ӻ�Ծ�Ƚ���</t>
{
	SetSrc(%Player,13);
	SendRenShuTongJito1001(%Player);//��������¼��ǰ��Ծ���+1
	%Player.removeschbuff(2009);
	%Player.Setschbuff(2010);
	return 0;
}
function ScheduleBuff_2010(%Player,%BuffID,%IsAuto)//2010 2 2 1800 1	0 0 1 item/105028001 <t>�����߼�ʱ��</t><b/><t>---------------------</t><b/><t>����ʱ�����󣬻������1Сʱ��Ծ�Ƚ���</t>
{
	SetSrc(%Player,14);
	%Player.removeschbuff(2010);
	%Player.Setschbuff(2011);
	return 0;
}
function ScheduleBuff_2011(%Player,%BuffID,%IsAuto)//2011 2 2 3600 1	0 0 1 item/105028001 <t>�����߼�ʱ��</t><b/><t>---------------------</t><b/><t>����ʱ�����󣬻������2Сʱ��Ծ�Ƚ���</t>
{
	SetSrc(%Player,15);
	return 1;
}