//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//��������
//==================================================================================
//�����������������������������ȫ�ֱ�����������������
//������������������������������������������������
//������������������������������ɼ�������������������
//�����������������������������NPC�Ի���������������
//���������������������������������ʹ�ô�������������
//����������������������������������¼��������������
//��������������������������������������������������


//�����������������������������ȫ�ֱ�����������������
$LingJingWuDaoJingBook[1,1] = "552000003;36.1083 65.6861 137.86;90;1 1 1";//�ɾ�
$LingJingWuDaoJingBook[1,2] = "552000003;45.5447 65.9128 137.86;90;1 1 1";//�ɾ�
$LingJingWuDaoJingBook[1,3] = "552000003;52.9835 59.5605 137.86;90;1 1 1";//�ɾ�
$LingJingWuDaoJingBook[1,4] = "552000003;54.3275 49.9489 137.86;90;1 1 1";//�ɾ�
$LingJingWuDaoJingBook[1,5] = "552000003;50.1028 42.5771 137.86;90;1 1 1";//�ɾ�
$LingJingWuDaoJingBook[1,6] = "552000003;41.3585 39.1191 137.86;90;1 1 1";//�ɾ�
$LingJingWuDaoJingBook[1,7] = "552000003;32.1418 41.7511 137.86;90;1 1 1";//�ɾ�
$LingJingWuDaoJingBook[1,8] = "552000003;26.9786 50.1475 137.86;90;1 1 1";//�ɾ�

$LingJingWuDaoJingBook[2,1] = "552000002;16 71 135.177;0;1 1 1";//����
$LingJingWuDaoJingBook[2,2] = "552000002;16 65 135.177;0;1 1 1";//����
$LingJingWuDaoJingBook[2,3] = "552000002;16 59 135.177;0;1 1 1";//����
$LingJingWuDaoJingBook[2,4] = "552000002;11 71 135.177;0;1 1 1";//����
$LingJingWuDaoJingBook[2,5] = "552000002;11 65 135.177;0;1 1 1";//����
$LingJingWuDaoJingBook[2,6] = "552000002;11 59 135.177;0;1 1 1";//����
$LingJingWuDaoJingBook[2,7]= "552000002;6 71 135.177;0;1 1 1";	//����
$LingJingWuDaoJingBook[2,8]= "552000002;6 65 135.177;0;1 1 1";	//����
$LingJingWuDaoJingBook[2,9]= "552000002;6 59 135.177;0;1 1 1";	//����

//$LingJingWuDaoJingBook[ 2, 1 ] = "552000002;16 77 135.177;0;1 1 1";//����
//$LingJingWuDaoJingBook[ 2, 2 ] = "552000002;16 71 135.177;0;1 1 1";//����
//$LingJingWuDaoJingBook[ 2, 3 ] = "552000002;16 65 135.177;0;1 1 1";//����
//$LingJingWuDaoJingBook[ 2, 4 ] = "552000002;16 59 135.177;0;1 1 1";//����
//$LingJingWuDaoJingBook[ 2, 5 ] = "552000002;16 53 135.177;0;1 1 1";//����
//$LingJingWuDaoJingBook[ 2, 6 ] = "552000002;11 77 135.177;0;1 1 1";//����
//$LingJingWuDaoJingBook[ 2, 7 ] = "552000002;11 71 135.177;0;1 1 1";//����
//$LingJingWuDaoJingBook[ 2, 8 ] = "552000002;11 65 135.177;0;1 1 1";//����
//$LingJingWuDaoJingBook[ 2, 9 ] = "552000002;11 59 135.177;0;1 1 1";//����
//$LingJingWuDaoJingBook[ 2, 10 ]= "552000002;11 53 135.177;0;1 1 1";//����
//$LingJingWuDaoJingBook[ 2, 11 ]= "552000002;6 77 135.177;0;1 1 1";	//����
//$LingJingWuDaoJingBook[ 2, 12 ]= "552000002;6 71 135.177;0;1 1 1";	//����
//$LingJingWuDaoJingBook[ 2, 13 ]= "552000002;6 65 135.177;0;1 1 1";	//����
//$LingJingWuDaoJingBook[ 2, 14 ]= "552000002;6 59 135.177;0;1 1 1";	//����
//$LingJingWuDaoJingBook[ 2, 15 ]= "552000002;6 53 135.177;0;1 1 1";	//����
//$LingJingWuDaoJingBook[ 2, 16 ]= "552000002;1 77 135.177;0;1 1 1";	//����
//$LingJingWuDaoJingBook[ 2, 17 ]= "552000002;1 71 135.177;0;1 1 1";	//����
//$LingJingWuDaoJingBook[ 2, 18 ]= "552000002;1 65 135.177;0;1 1 1";	//����
//$LingJingWuDaoJingBook[ 2, 19 ]= "552000002;1 59 135.177;0;1 1 1";	//����
//$LingJingWuDaoJingBook[ 2, 20 ]= "552000002;1 53 135.177;0;1 1 1";	//����

//�����������������������������ȫ�ֱ�����������������

//������������������������������������������������
function LingJingWuDaoHuoDongStart(%YY,%MM,%DD,%H,%M,%S)
{
	if (!(GetZoneID() == 1010 || GetZoneID() == 1011))
		return;
	//echo( "$SL_LingJingWuDao_State_bActive===" @ $SL_LingJingWuDao_State_bActive );
	if ($SL_LingJingWuDao_State_bActive == 1)
	{
		for (%i = 1; %i<= 2; %i++)
		{
			for (%j = 1; %j <= 99; %j++)
			{
				if ($LingJingWuDaoJingBook[%i,%j] $= "")
					break;
				if (!isobject($LingJingWuDaoJingBookRecord[%i,%j]))
				{
					%Id = Getword($LingJingWuDaoJingBook[%i,%j],0,";");
					%Pos = Getword($LingJingWuDaoJingBook[%i,%j],1,";");
					%Rot = Getword($LingJingWuDaoJingBook[%i,%j],2,";");
					%Scale = Getword($LingJingWuDaoJingBook[%i,%j],3,";");
					$LingJingWuDaoJingBookRecord[%i,%j] = SpNewCj(0,%ID,%Pos,%Rot,%Scale);
				}
			}
		}
		if (!isobject($LingJingWuDao[1]))
			$LingJingWuDao[1] = SpNewNpc2(0,410100023,"36.2311 55.2419 137.561",0,300);
		if (!isobject($LingJingWuDao[2]))
			$LingJingWuDao[2] = SpNewNpc2(0,410100031,"38.0868 56.315 137.561",0,300);
		if (!isobject($LingJingWuDao[3]))
			$LingJingWuDao[3] = SpNewNpc2(0,410100032,"36.2843 53.3335 137.561",0,300);
	}
	else
	{
		for (%i = 1; %i<= 2; %i++)
		{
			for (%j = 1; %j <= 99; %j++)
			{
				if ($LingJingWuDaoJingBook[%i,%j] $= "")
					break;
				if (isobject($LingJingWuDaoJingBookRecord[%i,%j]))
					$LingJingWuDaoJingBookRecord[%i,%j].Safedeleteobject();
			}
		}

	}
}
//������������������������������������������������

//���������������������������������ʹ�ô�������������
function Trigger_105109312(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109312_105109316(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,100); }
function Trigger_105109313(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109312_105109316(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,200); }
function Trigger_105109314(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109312_105109316(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,300); }
function Trigger_105109315(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109312_105109316(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,600); }
function Trigger_105109316(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109312_105109316(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1000); }
function Trigger_105109312_105109316(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%Exp)
{
	%Level = %player.getlevel();
	%Exp = %Exp * $Monster_Exp[%Level,1];
	%Player.Putitem(%type,-1);
	if (%Player.Additem(1,%type))
		AllAddExp(%Player,%Exp);

}
function Trigger_105109311(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)//����
{
	%Conv.Reset();	//��������ѡ��
	%Conv.SetTriggerType(1);
	%Conv.SetTriggerMission(%Type);
	%Conv.SetType(1);
	%PlayerID = %Player.GetPlayerID();
	if (%State == 0)
		%Conv.SetText(600000072,600000072);
	%Conv.Send(%Player);
}
function Trigger_108021019( %Conv, %Player, %Type, %State, %TriggerType, %TriggerID, %Param, %XYZ )//ʹ���������
{
	if ( %Player.IsAcceptedMission( 10221 ) )
	{
		%Level = %player.getlevel( );
		%Exp = 100 * $Monster_Exp[ %Level, 1 ];
		%Player.Putitem( %type, -1 );
		if ( %Player.Additem( 1, %type ) )
			AllAddExp( %Player, %Exp );//��100ֻ�־���
		
		%Player.SetMissionFlag( 10221, 1350, 1 );
		SendOneScreenMessage( 1, "ʹ�õ���  1/1", %Player );//������
		%Player.UpdateMission( 10221 );
	}
	else 
	{
		%Player.Putitem( %type, -1 );
		%Player.Additem( 1, %type );
	}
}
//���������������������������������ʹ�ô�������������
/*
2012 2 3 10800 1 0 1 1 item/105028001 <t>�����������</t><b/><t>---------------------</t><b/><t>Ԫ������ɾ���ÿ��5��ɻ��һ�ξ��齱��</t>
2013 2 2 5 1 0 0 1 item/105028001 <t>�����������</t><b/><t>---------------------</t><b/><t>Ԫ������ɾ���ÿ��5��ɻ��һ�ξ��齱��</t>
2014 2 2 50400 1 0 1 1 item/105028001 <t>�����������</t><b/><t>---------------------</t><b/><t>������鲻��������·���������ƣ��״̬������״̬����12Сʱʱ���޷��������</t>
*/

//������������������������������ɼ�������������������
function TriggerEvent_552000003(%Player,%Event,%EventID)
{
	if (%Player.GetSchbuff(2013) > 0)
	{
		SendOneScreenMessage(2,"���ѿ���Ԫ�����",%Player);
		SendOneChatMessage($chatMsg_System,"<t>���ѿ���Ԫ������������ڴ˲���</t>",%Player);
		%Player.Addbuff(320740001,%Player,1);
		return;
	}
	if (%Player.GetSchbuff(2012) > 0)
	{
		JingLingWuDaoExpAdd(%Player,2);
		recordreadbook(%Player);
		LingJingWuDao_GetDaoGuo(%Player,2);
	}
	else
	{
		SendOneScreenMessage(2,"������ʱ�䲻��",%Player);
		SendOneChatMessage($chatMsg_System,"<t>������ʱ�䲻�㣡</t>",%Player);
		%Player.Addbuff(320740001,%Player,1);
	}
}
function TriggerEvent_552000002(%Player,%Event,%EventID)
{
	//echo(%Player.GetSchbuff(2014));
	if (%Player.GetSchbuff(2013) > 0)
	{
		SendOneScreenMessage(2,"���ѿ���Ԫ�����",%Player);
		SendOneChatMessage($chatMsg_System,"<t>���ѿ���Ԫ������������ڴ˲���</t>",%Player);
		%Player.Addbuff(320740001,%Player,1);
		return;
	}
	if (%Player.GetSchbuff(2014) >= 43200)
	{
		SendOneScreenMessage(2,"�Ѿ������������ƣ��״̬���޷�����",%Player);
		SendOneChatMessage($chatMsg_System,"<t>�޵�֮�ˣ����ܱ��Ų��������Ͻ�����ǰ�����س�����쳾��������Ϊ��</t>",%Player);
		//GoToNextMap( %Player, 1001, "" );
		%Player.Addbuff(320740001,%Player,1);
		return;
	}
	if (%Player.isschbuff(2014) == 0)
	{
		%Player.setschbuff(2014);
		%Player.Addschbuff(2014,50380);
	}
	else
		%Player.Addschbuff(2014,-20);
	JingLingWuDaoExpAdd(%Player,1);
	recordreadbook(%Player);
	LingJingWuDao_GetDaoGuo(%Player,1);
	if (%Player.IsAcceptedMission(10221))//�����������
	{
		%PlayerID = %Player.GetPlayerID();
		%Type = %Player.GetMissionFlag(10221,2330);
		%Num = %Player.GetMissionFlag(10221,2230);
		if (%Type  == %Num)
		{
			%Player.addpacket( 625009 );//������Ч
			%Player.Addbuff(320740001,0,1);//��ϲɼ�
			%Player.putItem( 108021019, 1 );//��һ������
			%Player.addItem(1,10221);
			Schedule( 700, 0, "HelpDirectByIndex",%PlayerID, 17 );	//ͨѶ�ͻ���
			return;
		}
	}
}
function TriggerEvent_553000050(%Player,%Event,%EventID)//����ɼ�	��������
{
	if (%Player.IsAcceptedMission(10221))
	{
		%PlayerID = %Player.GetPlayerID();
		%Type = %Player.GetMissionFlag(10221,2330);
		%Num = %Player.GetMissionFlag(10221,2230);
		if (%Type  == %Num)
		{
			%Player.addpacket( 625009 );
			%Player.Addbuff(320740001,0,1);//��ϲɼ�
			%Player.putItem( 108021019, 1 );//��һ������
			%Player.addItem(1,10221);
			Schedule( 700, 0, "HelpDirectByIndex", %PlayerID, 17 );	//ͨѶ�ͻ���
			return;
		}
	}
}
function JingLingWuDaoExpAdd(%Player,%optype)
{
	%Level = %player.getlevel();
	%Exp_LeiJiaBeiShu = 0;
	if (%Player.ISschbuff(1997)) %Exp_LeiJiaBeiShu = 1;	  //���鵤�ļӳ�
	else if (%Player.ISschbuff(1998)) %Exp_LeiJiaBeiShu = 1.5; //���鵤�ļӳ�
	else if (%Player.ISschbuff(1999)) %Exp_LeiJiaBeiShu = 2;	  //���鵤�ļӳ�

	switch (%optype)
	{
		case 1://��Ѳɼ�
			%JingYanXiShu = 0.3;
		case 2://�շѲɼ�
			%JingYanXiShu = 0.3;
		case 3://Ԫ�����
			%JingYanXiShu = 0.3;
	}
	%Exp = $Monster_Exp[%Level,1] * %JingYanXiShu * (1 +  %Exp_LeiJiaBeiShu);
	AllAddExp(%Player,%Exp);
}

//������������������������������ɼ�������������������

//�����������������������������NPC�Ի���������������
function LingJingWuDao_DiaLogA(%Npc,%Player,%State,%Conv)//�Ͻ�����
{
	switch (%state)
	{
		case 0:
			%Conv.Settext(600000073,600000073);
			if ($SL_LingJingWuDao_State_bActive == 1)
				%Conv.AddOption(600000074,600000074);
		case 600000074:
			%Conv.Settext(600000073,600000073);
			%Conv.AddOption(600000074,600000074);
			if (%Player.getitemcount(105109311) < 1)
			{
				SendOneScreenMessage(2,"���߲��㣬�һ�ʧ��",%Player);
				SendOneChatMessage($chatMsg_System,"<t>��û���㹻�������ƣ��һ�ʧ�ܣ�</t>",%Player);
				return;
			}
			%Act0 = GetAct(%Player,4023,0);
			%Act1 = GetAct(%Player,4023,1);
			if (%Act0 >= 3)
			{
				SendOneScreenMessage(2,"�һ������ﵽ����,�һ�ʧ��",%Player);
				SendOneChatMessage($chatMsg_System,"<t>ÿ��ֻ����һ�3�������ƣ������������ɣ�</t>",%Player);
				return;
			}

			%Player.putitem(105109311,-1);
			if (%Player.Additem(1,105109311))
			{
				//echo( %Player.GetSchbuff( 2012 ) );
				if (%Player.isschbuff(2012) == 0)
				{
					%Player.Setschbuff(2012);
					%Player.Addschbuff(2012,7200);
				}
				else
					%Player.Addschbuff(2012,-3600);
				//echo( %Player.GetSchbuff( 2012 ) );
				//echo( "-------------------" );
				%Act0++;
				SetAct(%Player,4023,%Act0,%Act1);
				%Nowtime = Mceil(%Player.GetSchbuff(2012)/60);
				SendOneScreenMessage(2,"�һ��ɹ�����ǰ�ɲ����ɾ���" @ %Nowtime @ "����",%Player);
				SendOneChatMessage($chatMsg_System,"<t>�һ��ɹ�����ǰ�ɲ����ɾ���" @ %Nowtime @ "����,�����Ѷһ�" @ %Act0 @ "�Σ�ÿ��ɶһ�3�Ρ�</t>",%Player);
			}
	}
}
function LingJingWuDao_DiaLogB(%Npc,%Player,%State,%Conv)//�ٻ�Ԫ�����
{
	switch (%State)
	{
		case 0:
			%Conv.Settext(600000076,600000076);
			%Conv.AddOption(600000075,600000075);
		case 600000075:
			%Conv.Settype(4);
			if (%Player.GetSchbuff(2012) <= 60)
			{
				SendOneScreenMessage(2,"��û���㹻�����ʱ��",%Player);
				SendOneChatMessage($chatMsg_System,"<t>ʹ�����ƶһ������ʱ�䲻�㣬����ʧ��</t>",%Player);
				return;
			}
			%NeedMoney = mceil(%Player.GetSchbuff(2012)/3600 * 100);
			ServerOnSptAction(%Player.GetPlayerID(),%NeedMoney,12);//ͨѶ�ͻ���
	}
}
function LingJingWuDao_YuanShenWuDaoStart(%Player)
{
	%NeedMoney = mceil(%Player.GetSchbuff(2012)/3600 * 100);
	if (%NeedMoney > 0)
	{
		if (%Player.GetMoney(1) >=  %NeedMoney)
		{
			%Player.Reducemoney(%NeedMoney,1,5,2013);
			%Player.SetSchbuff(2013);
		}
		else
		{
			SendOneScreenMessage(2,"Ԫ������",%Player);
			SendOneChatMessage($chatMsg_System,"<t>Ԫ�����㣬����ʧ��</t>",%Player);
		}
	}
}
function ScheduleBuff_2013(%Player,%BuffID,%IsAuto)
{
	if (%Player.GetSchbuff(2012) <= 1)
		return 1;
	JingLingWuDaoExpAdd(%Player,3);
	%Player.Setschbuff(2013);
	recordreadbook(%Player);
	LingJingWuDao_GetDaoGuo(%Player,2);
	return 0;
}
//�����������������������������NPC�Ի���������������
//function xxxxx( %rot )
//{
//	%Number = 8;
//	$LingJingWuDaoJingBookRecord[ 1, %Number ].Safedeleteobject( );
//	%Id = Getword( $LingJingWuDaoJingBook[ 1, %Number ], 0, ";" );
//	%Pos = Getword( $LingJingWuDaoJingBook[ 1, %Number ], 1, ";" );
//	%Scale = Getword( $LingJingWuDaoJingBook[ 1, %Number ], 3, ";" );
//
//	$LingJingWuDaoJingBookRecord[ 1, %Number ] = SpNewCj( 0, %ID, %Pos, %Rot, %Scale );
//}
//����������������������������������¼��������������
function recordreadbook(%Player)
{
	SetAct(%Player,4023,getword(%Player.getactivity(4023),0),getword(%Player.getactivity(4023),1)+ 1);
}
//����������������������������������¼��������������

//��������������������������������������������������
function LingJingWuDao_GetDaoGuo(%Player,%optype)
{
	switch (%Optype)
	{
		case 1:
			%RanDom = GetRandom(1,10000);
			if (%RanDom <= 13)
			{
				%Player.Putitem(105109312,1);
				%Player.Additem(1,4023);
			}
			%RanDom = GetRandom(1,10000);
			if (%RanDom <= 6)
			{
				%Player.Putitem(105109313,1);
				%Player.Additem(1,4023);
			}
			%RanDom = GetRandom(1,10000);
			if (%RanDom <= 2)
			{
				%Player.Putitem(105109314,1);
				%Player.Additem(1,4023);
			}
			%RanDom = GetRandom(1,10000);
			if (%RanDom <= 1)
			{
				%Player.Putitem(105109315,1);
				%Player.Additem(1,4023);
			}
		case 2:
			%RanDom = GetRandom(1,10000);
			if (%RanDom <= 13)
			{
				%Player.Putitem(105109313,1);
				%Player.Additem(1,4023);
			}
			%RanDom = GetRandom(1,10000);
			if (%RanDom <= 9)
			{
				%Player.Putitem(105109314,1);
				%Player.Additem(1,4023);
			}
			%RanDom = GetRandom(1,10000);
			if (%RanDom <= 4)
			{
				%Player.Putitem(105109315,1);
				%Player.Additem(1,4023);
			}
			%RanDom = GetRandom(1,10000);
			if (%RanDom <= 2)
			{
				%Player.Putitem(105109316,1);
				%Player.Additem(1,4023);
			}
	}
}
//��������������������������������������������������