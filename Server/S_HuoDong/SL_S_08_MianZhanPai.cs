//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//��ս��
//==================================================================================
//39907	1	��ս
//2029 2 1 72000 0 0 1 1 item/105021004 <t>����ս�ơ�</t><b/><t>---------------------</t><b/><t>�߹���ս�ƣ��ܾ���ս��</t><b/><t>---------------------</t><b/><t>Я����״̬�޷�����������ң�Ҳ�����Ա�������ҹ�������Զ������������򣬷��򽫻�ʧȥ��״̬</t>
//2030 2 2 60	1 0	0 1 item/105021004 <t>����ս�ơ�</t><b/><t>---------------------</t><b/><t>ÿ���Ӵ����Ƿ������ս</t>

//����������ս�ơ�����������������ʹ�ô�������������������
//����������ս�ơ���������������ս����BUFF����������������
//����������ս�ơ�������������ɱ�˽�ֹ��ս����������������
//����������ս�ơ������������������Ƿ����ս��������������
//����������ս�ơ��������������һ�������������������������

//����������ս�ơ�����������������ʹ�ô�������������������
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
	%H = GetWord(%Time,3);	//Сʱ
	%M = GetWord(%Time,4);	//����
	%S = GetWord(%Time,5);	//��
	if (%H >= 6 && %H < 22)
	{
		%Txt = "��ս��ֻ������22:00������6:00֮ǰʹ��";
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		return;
	}
	if (%Player.IsSchbuff(2029))
	{
		%Txt = "��ǰ״̬�޷�ʹ����ս��";
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		return;
	}
	if (%Player.GetPKValue() > 0)
	{
		%Txt = "����״̬�޷�ʹ����ս��";
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		return;
	}
	%IsCanOpen = GetIsCanOpenMianZhan(%Player,0);
	if (!%IsCanOpen)
	{
		%Txt = "��ǰ������������ս";
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		return;
	}
	%Player.ShowDialogOk(2000000020,%Dialogid,1);
}

function MianZhanPaiUse(%Player,%ItemID,%Timemins)
{
	%Time = GetLocalTime();
	%H = GetWord(%Time,3);	//Сʱ
	%M = GetWord(%Time,4);	//����
	%S = GetWord(%Time,5);	//��
	if (%H <= 23)
		%CanHaveTime = (24 - %H) * 60 + 6 * 60 - %M;
	else
		%CanHaveTime = (6 - %H) * 60 - %M;
	%NowHaveTime = mceil(%Player.GetSchBuff(2040)/60);
	//echo( "%CanHaveTime===" @ %CanHaveTime );
	//echo( "%NowHaveTime===" @ %NowHaveTime );
	if (%NowHaveTime >= %CanHaveTime)
	{
		SendOneScreenMessage(2,"�����սʱ���Ѵﵽ����",%Player);
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
//����������ս�ơ�����������������ʹ�ô�������������������

//����������ս�ơ���������������ս����BUFF����������������
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
	%H = GetWord(%Time,3);	//Сʱ
	%M = GetWord(%Time,4);	//����
	%S = GetWord(%Time,5);	//��
	if (%H >= 6 && %H < 22)
	{
		%Txt = "��ս��ֻ������22:00������6:00֮ǰʹ��";
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		return 1;
	}
	if (%Player.IsSchbuff(2029))
	{
		%Txt = "��ǰ״̬�޷�ʹ����ս��";
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		return 1;
	}
	if (%Player.GetPKValue() > 0)
	{
		%Txt = "����״̬�޷�ʹ����ս��";
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		return 1;
	}
	%IsCanOpen = GetIsCanOpenMianZhan(%Player,0);
	if (!%IsCanOpen)
	{
		%Txt = "��ǰ������������ս";
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
//����������ս�ơ���������������ս����BUFF����������������

//����������ս�ơ�������������ɱ�˽�ֹ��ս����������������
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
//����������ս�ơ�������������ɱ�˽�ֹ��ս����������������

//����������ս�ơ������������������Ƿ����ս��������������
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
//����������ս�ơ������������������Ƿ����ս��������������

//����������ս�ơ��������������һ�������������������������
function  ChangeCombatAssistant(%Player,%State)
{
	//echo( "�һ�����===" @ %State );
	switch (%State)
	{
		case 1://��ʼ�һ�
			if (%Player.GetSchBuff(2040) >= 1)
				%Player.SetSchbuff(2041);
			%Player.AssistantRecord = 1;
		case 0://�����һ�
			%Player.AssistantRecord = 0;
			if (%Player.GetBuffCount(39907,1) >= 1)
				%Player.RemoveBuff(399070001);
			if (%Player.IsSchbuff(2041))
				%Player.RemoveSchBuff(2041);
			if (%Player.IsSchbuff(2030))
				%Player.RemoveSchBuff(2030);
	}
}
//����������ս�ơ��������������һ�������������������������
