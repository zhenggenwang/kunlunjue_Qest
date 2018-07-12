//�����������������������ɼ��ﴥ���ܽӿڡ�������������������������������������
//�����������������������ɼ����¼�����ű�������������������������������������
//��������������������������������򴥷��ű�����������������������������������
//��������������������������״̬�¼������ű�����������������������������������
//��������������������������·���¼������ű�����������������������������������
//�����������������������������ս��������������������������������������������
//�������������������������񡢻�������ɼ������жϡ�������������������������
//������������������������̯��������������������������������������������������

//�����������������������ɼ��ﴥ���ܽӿڡ�������������������������������������
//�ɼ��ɹ�����ýű�
function OnServerTriggerEvent(%Player,%Event)
{
	%EventID = %Event.GetDataID();
	%EventStr = GetSubStr(%EventID,0,3);
	//echo( "�ɼ��ﴥ���ܽӿ� ==" @ %EventID );
	//װ������
	//if ( %eventStr $= "550")
	//	return TriggerEvent_551000000( %Player, %Event, %EventID );
	//�������زɼ�
	if (%eventStr $= "551")
		return OnServerTriggerEvent_551(%Player,%Event,%EventID);

	//���񡢻��������زɼ�
	else if (%eventStr >= 552)
		return OnServerTriggerEvent_552(%Player,%Event,%EventID);

	return true;
}

function OnServerTriggerEvent_551(%Player,%Event,%EventID)
{
	%FuncName = "TriggerEvent_" @ %EventID;
	if (isFunction(%FuncName))
		return eval(%FuncName @ "(%Player, %Event, %EventID);");
	return true;
}





//���񡢻�������ɼ������ж�
function OnServerTriggerEvent_552(%Player,%Event,%EventID)
{
	//��Ҫ��ȡ������Ʒ�Ĳɼ���
	MissionCollectEventDispose(%Player,%Event,%EventID);
	//--------------����ɼ�����-----------------------------
	if ($TriggerEvent_Mission[%EventID] !$= "")
	{
		%Count = GetWordCount($TriggerEvent_Mission[%EventID],";");
		if (%Count > 0)
		{
			for (%i =0; %i < %Count; %i++)
			{
				%MissionList = getWord($TriggerEvent_Mission[%EventID],%i,";");
				%MissionID = GetWord(%MissionList,0);
				%FlagID = GetWord(%MissionList,1);

				if (%Player.IsAcceptedMission(%MissionID))
				{
					%MissionFlag2230 = %Player.GetMissionFlag(%MissionID,%FlagID);
					%MissionFlag2330 = %Player.GetMissionFlag(%MissionID,%FlagID + 100);
					if (%MissionFlag2330 < %MissionFlag2230)
					{
						%Player.SetMissionFlag(%MissionID,%FlagID + 100,%MissionFlag2330++);

						%Target = %Player.GetMissionFlag(%MissionID,%FlagID-100);
						if (GetNpcData(%Target,0) >  0)
							%Txt = "����";
						else if (GetItemData(%Target,0) >  0)
							%Txt = "��ȡ";
						if (%Txt !$= "")
							SendOneScreenMessage(1,%Txt @ "��" @ %MonsterName @ "�� "@ %MissionFlag2330 @ "/" @ %MissionFlag2230,%Player);
						Schedule(500,0,"eval",%Player @ ".UpdateMission(" @ %MissionID @ "); ");
					}
				}
			}
		}
	}
	//-------------------------------------------------------
	%FuncName = "TriggerEvent_" @ %EventID;
	if (isFunction(%FuncName))
		return eval(%FuncName @ "(%Player, %Event, %EventID);");

	return true;
}
//�����������������������ɼ����¼�����ű�������������������������������������
//������TriggerEvent_552030067(%Player, %Event, %EventID);

//��������������������������״̬�¼������ű�����������������������������������
//����״̬�ܽӿ�
//����״̬����

//����״̬�ܽӿ�
function OnScheduleBuffer(%Player,%BuffID,%IsAuto)
{
	//%IsAuto = 0; �ֶ�����
	//%IsAuto = 1; �Զ�����
	//����һ��Ҫ����һ��ֵ

	%BuffIni = 1;
	%FuncName = "ScheduleBuff_" @ %BuffID;
	if (isFunction(%FuncName))
		%BuffIni = eval(%FuncName @ "(%Player, %BuffID, %IsAuto);");

	if (%BuffIni == 0)
		%BuffIni = 0;

	//���ط�0����ʾ%buffid��Ҫ��������Ƴ���
	return %BuffIni;
}

//����״̬����
//������ScheduleBuff_1000(%Player, %BuffID, %IsAuto);

function ScheduleBuff_2032(%Player,%BuffID,%IsAuto)
{
	if (!%Player.IsSchbuff(2031))
		return true;
	%Exp = $Monster_Exp[%Player.GetLevel(),1] * 3;
	AllAddExp(%Player,%Exp);
	%Player.Setschbuff(2032);
	return 0;
}

function ScheduleBuff_1000(%Player,%BuffID,%IsAuto)
{
	//echo("ÿ���ӽ���һЩ״̬���" );
	if ($SL_HuoDong_Old !$= $SL_HuoDong)
		%Player.SendPlayerString(2,$SL_HuoDong,0);//���ͻ���ÿ���
	if ($SL_YunYingHuoDong_Old !$= $SL_YunYingHuoDong)
		SendPlayerStringToClient(%Player, 10);//������Ӫ����ÿ���
	//echo("$SL_YunYingHuoDong_Old==" @ $SL_YunYingHuoDong_Old);
	//echo("$SL_YunYingHuoDong==" @ $SL_YunYingHuoDong);
	if ($SL_JieMianKaiGuan_Old !$= $SL_JieMianKaiGuan)
		%Player.SendPlayerString(11,$SL_JieMianKaiGuan,0);//���ͽ������ÿ���
	
	//��ʱ�������߸���
	if ($SL_XianShiQiangGou_OldInfo !$= $SL_XianShiQiangGou_NewInfo )
	{
		sendNewXianShiQiangGouItemInfo(%Player, $SL_XianShiQiangGou_NewInfo);
		$SL_XianShiQiangGou_OldInfo = $SL_XianShiQiangGou_NewInfo;
	}
	
	%Player.Setschbuff(1000);
	return 0;
}
//��������������������������·���¼������ű�����������������������������������
//����·���ܽӿ�
//����·�㴥��

//����·���ܽӿ�
function onReachWayPoint(%Caster,%PathId,%index)
{
	//%PathId ·����
	//%index  ·��λ��
	//echo( "============================================" );
	//echo(%Caster.getobjectname() @ "  %PathId ==" @  %PathId @  "  %index==" @ %index);
	//echo( "============================================" );
	switch (%PathId)
	{
		case 11030001:schedule(1000,0,"gotocopymap",%Npc,1306);
		case 10100001:HelpDirectByIndex(%Caster.GetPlayerID(),7);
		case 10100007:Schedule(500,0,"eval",%Caster @ ".FlyPathID = 0; ");
		case 10100006:Schedule(500,0,"eval",%Caster @ ".FlyPathID = 0; ");
		case 10010001:Schedule(1000,0,"eval",%Caster @ ".FlyPathID = 0; ");
		case 10010002:Schedule(1000,0,"eval",%Caster @ ".FlyPathID = 0; ");
	}
}


//�����������������������������ս��������������������������������������������
//����ս���ܴ���
//�뿪ս���ܴ���
//����ս������

//����ս���ܴ���
function onCombatBegin(%Npc)
{
	%NpcID = %Npc.GetDataID();

	AddSkill_TongYongAI(%obj,%NpcID);

	%FuncName = "MonsterCombatBegin_" @ %NpcID;

	if (isFunction(%FuncName))
		eval(%FuncName @ "(%Npc);");
}

//�뿪ս���ܴ���
function onCombatEnd(%Npc)
{
	%NpcID = %Npc.GetDataID();
	%FuncName = "MonsterCombatEnd_" @ %NpcID;

	if (isFunction(%FuncName))
		eval(%FuncName @ "(%Npc);");
}

//����ս������
//MonsterCombatBegin_440440440(%Npc);
//�뿪ս������
//MonsterCombatEnd_440440440(%Npc);


//�������������������������񡢻�������ɼ������жϡ�������������������������

//�������������������������񡢻�������ɼ������жϡ�������������������������


//������������������������̯��������������������������������������������������
//��ʼ��̯
function S_StartStallState(%Player)
{
	//%Player.AddBuff( 330640111 );
}

//������̯
function S_EndStallState(%Player)
{
	//%Player.RemoveBuff( 330640111 );
}
//������������������������̯��������������������������������������������������


