//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//�����ű���Ϊ ���򴥷�ר�� �����Խű������е�ͼ��������
//==================================================================================
//������������������������ɫ�������򴥷��ű�����������������������
//��������������������������������򴥷��ű�����������������������
//�����������������������������򴢴���ұ�š���������������������
//�����������򴥷�������������1010��������������������������������
//�����������򴥷�������������1001�������������ء�����������������
//�����������򴥷�������������1101�������������ɹȡ���������������



//����Ұ��-149.21 25.4789 116.506  ��Ұ�����ǣ�-71.5519 107.092 124.529     ���ұ�Ұ����91.2146 70.5762 134.25           ���ұ�Ұ����125.758 17.7665 122.023
//SptGetPlayer( 50000022).TransportObject(0, 0,-149.21 ,20.4789 ,120.506);
//SptMail_Send( 50000146, 0, 0, 123, 321, "123", "222" );SptMail_Send( 50000146, 0, 0, 123, 0, "123", "222" );SptMail_Send( 50000146, 0, 0, 0, 321, "123", "222" );
//SptMail_Send(  50000250, 105180255, 1, 111, 222, "123", "222" );
//������������������������ɫ�������򴥷��ű�����������������������
//�������򴥷��ű�
//�뿪���򴥷��ű�
//�����������ⴥ���ű�

//�������򴥷��ű�
function OnEnterTrigger(%Player,%TriggerId)
{
	putout(" �� �������򴥷��ű� �� = " @ %TriggerId);
	//echo( "=====" @ %player.gettriggerid( ) );
	//��ȡPlayerID
	%PlayerID = %Player.GetPlayerID();
	%CopyMapID = %Player.GetLayerID();

	//-----------�Ƿ��Ǵ�������---------------------
	if ($Transport_TargetID[%TriggerId] !$= "")
	{
		%TargetTriggerId = GetWord($Transport_TargetID[%TriggerId],0);
		%iLevelNeed = GetWord($Transport_TargetID[%TriggerId],1) * 1;
		%iLevel = GetMetempsychosisLeve(%Player);
		if ( %TriggerId == 811030110 )
		{
			SendOneScreenMessage( 2, "�õ�ͼ��δ���ţ������ڴ���", %player );
			return;
		}
		if (!%player.isschbuff(1003))
		{
			if (%iLevel >=  %iLevelNeed)
			{
				%Player.SetSchbuff(1003);//����BUFF
				SpNewEff(%Player,$SP_Effect[6],0);//������Ч
				//echo( "%TargetTriggerId===============" @ %TargetTriggerId );
				GoToNextMap(%Player,%TargetTriggerId,"");
			}
			else
			{
				SendOneScreenMessage(2,"Ҫ��ȼ�" @ %iLevelNeed @ "����ĵȼ����㣬�޷�����",%player);
				SendOneChatMessage($chatMsg_System,"<t>Ҫ��ȼ�" @ %iLevelNeed @ "����ĵȼ����㣬�޷�����</t>",%player);
			}
		}
	}
	//---------------------------------------------------------------
	if (%Player.Isschbuff(2040))//�жϸ������Ƿ�������ս
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

	//----------�Ƿ������밲ȫ�����Σ���������ʾ-----------------
	//else if ( %CopyMapID <= 1 && %Player.Getlevel( ) >= 30 )//�����ڲ�������
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
	//				%Text = "���ѽ��밲ȫ���򣬵�ǰ�����޷�PK";
	//				SendOneScreenMessage( 1, %Text, %player );
	//				SendOneChatMessage( $chatMsg_System, "<t>" @ %Text @ "</t>", %player );
	//			case 1:
	//				%Text = "���ѽ���Σ�����򣬵�ǰ�����PK";
	//				SendOneScreenMessage( 2, %Text, %player );
	//				SendOneChatMessage( $chatMsg_System, "<t>" @ %Text @ "</t>", %player );
	//		}
	//	}
	//}
	//%Player.inTriggerId = %TriggerId;//��¼����
	//----------------------------------------------------------------

	//���⴦��
	%FuncName = "PlayerEnterTrigger_" @ %TriggerID;
	if (isFunction(%FuncName))
		eval(%FuncName @ "(%Player, %TriggerId);");
}



//�����������ⴥ���ű�
//������PlayerEnterTrigger_100000001(%Player, %TriggerId);




//�뿪���򴥷��ű�
function OnExitTrigger(%Player,%triggerId)
{
	Putout(" �� �뿪���򴥷��ű� �� = " @ %TriggerId);

	%FuncName = "PlayerOnExitTrigger_" @ %TriggerID;
	if (isFunction(%FuncName))
		eval(%FuncName @ "(%Player);");
}
//������������������������ɫ�������򴥷��ű�����������������������

//��������������������������������򴥷��ű�����������������������
//���������ܽӿ�
//�뿪�����ܽӿ�
//�������򴥷��ű�

//���������ܽӿ�
function OnNpcEnterTrigger(%Npc,%TriggerID)
{
	%FuncName = "NpcEnterTrigger_" @ %TriggerID;
	if (isFunction(%FuncName))
		eval(%FuncName @ "(%Npc, %TriggerID);");
}

//�뿪�����ܽӿ�
function OnNpcExitTrigger(%Npc,%triggerId)
{
	%FuncName = "NpcExitTrigger_" @ %TriggerID;
	if (isFunction(%FuncName))
		eval(%FuncName @ "(%Npc, %TriggerID);");
}

//�������򴥷��ű�������
//NpcEnterTrigger_813020101(%Npc, %TriggerID);
//�뿪���򴥷��ű�������
//NpcExitTrigger_813020101(%Npc, %TriggerID);

//��������������������������������򴥷��ű�����������������������

//�����������������������������򴢴���ұ�š���������������������
function Trigger_Area_PlayerMemory(%Player,%TriggerId,%fashion)
{
	%CopyMapID = %Player.GetLayerId();
	%CopyMapID = (%CopyMapID == 0) ? 1 : %CopyMapID;

	%AreaID = $Camera_Begin_Player[%CopyMapID,%TriggerId];
	%T_Num = GetWordCount(%AreaID);

	switch (%fashion)
	{
		//��������ʱ�Ĵ���
		case 0:
			if (%AreaID $= "")
				%Player_A = $Camera_Begin_Player[%CopyMapID,%TriggerId] = %Player;
			else
				%Player_A = $Camera_Begin_Player[%CopyMapID,%TriggerId] = %AreaID @" "@%Player;

			//�뿪����ʱ�Ĵ���
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
					//��ȡ����������Npc
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
						//��ȡ���������п�ս����Npc
						if (%Player_B.GetBuffCount(33065,10) == 0)
							%Player_C = (%Player_C $= "") ? %Player_B : %Player_C @" "@%Player_B;
					}
				}
			}
			return %Player_C;

	}

	return %Player_A;
}


//�����������������������������򴢴���ұ�š���������������������

//�����������򴥷�������������1010��������������������������������
//-----�½���ɫ��¼ʱ��������----
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
		SendOneScreenMessage(2,"�ȼ�����20�����޷�ǰ����ħ��",%Player);
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

function PlayerEnterTrigger_810100117(%Player,%TriggerId)//����֮��
{
	%AAA = %Player.IsAcceptedMission(10241);
	if (%AAA == 1)
	{
		%Player.ShowDialogOk(2000000017,17,0);//ȷ�Ͽ�
	}
}
function PlayerEnterTrigger_810100118(%Player,%TriggerId)//̽��Դͷ
{
	if (%Player.IsAcceptedMission(10291))
	{
		%Player.ShowDialogOk(2000000018,18,0);//ȷ�Ͽ�
	}
	if (%Player.IsAcceptedMission(10301))
	{
		%Type = %Player.GetMissionFlag(10301,3300);
		%Num = %Player.GetMissionFlag(10301,3200);
		//echo( "%Type=====" @ %Type @ "%Num=======" @ %Num );
		if (%Type != %Num)
		{
			ChangeLogicFloor(%Player,0,%Player);//���뾵���
			Mission_Special_10301(%Player,%mid);//��������
		}
	}
}


function PlayerEnterTrigger_810100200(%Player,%TriggerId)
{
	%AAA = %Player.IsAcceptedMission(10341);
	if (%AAA == 1)
	{
		Schedule( 200, 0, "HelpDirectByIndex", %Player.getPlayerID(), 30 );
		//����С��Ӱ
		Schedule(2200,0,"CameraPathBegin",%Player.GetControllingClient(),10100010);
	}
}
//------------�뿪��ʼС������----------
function PlayerOnExitTrigger_810100101(%Player,%TriggerId)
{
	if (%Player.IsAcceptedMission(10001))
	{
		%Player.SetMission(10001,1);//��ɵ�һ������
		AddMissionAccepted(%Player,0,10002);//�ӵڶ�������
	}
}



//�����������򴥷�������������1010��������������������������������

//�����������򴥷�������������1101�������������ɹȡ���������������

function PlayerEnterTrigger_811010100(%Player,%TriggerId)
{
	//echo( "%TriggerId=========" @ %TriggerId );
	if (%Player.IsAcceptedMission(10421))
	{
		%Player.AddDesignation(801);//����é®      	���һ���µĳƺ�
		%Player.SetCurDesignationIDZone(801);//	���ô˳ƺ�Ϊ��ǰ����ʹ�õĳƺ�
		%PlayerID = %Player.GetPlayerID();
		//ͨѶ�ͻ���	��ָ������
		//echo( "%PlayerID=========" @ %PlayerID );
		Schedule(3000,0,"HelpDirectByIndex",%PlayerID,14);
	}
}

function PlayerEnterTrigger_811010103(%Player,%TriggerId)//̽�غ���
{
	if (%Player.IsAcceptedMission(10931))
	{
		%Player.ShowDialogOk(2000000031,31,0);//ȷ�Ͽ�
	}
}
function PlayerEnterTrigger_811280100(%Player,%TriggerId)//���ɿ�
{
	if (%Player.IsAcceptedMission(10951))
	{
		Schedule(5000,0,"TanKuangQueRen_10951",%Player,10951);
	}
}
function PlayerEnterTrigger_811280202(%Player,%TriggerId)//���ɿ߶���
{
	if (%Player.IsAcceptedMission(11021))
	{
		%Player.SetMission(11021,1);//���
		%Player.AddExp(25705);
		AddMissionAccepted(%Player,0,11022);//����һ������
	}
}
function PlayerEnterTrigger_811020100(%Player,%TriggerId)//��ɽѩ��
{
	if (%Player.IsAcceptedMission(11041))
	{
		Schedule(3000,0,"ShiMenPaoHuan_11041",%Player,11041);
	}
}
function PlayerEnterTrigger_811020103( %Player, %TriggerId )//�⽣̨
{
	if ( %Player.IsAcceptedMission( 11232 ) )
	{
		%Player.ShowDialogOk( 2000000019, 19, 0 );//ȷ�Ͽ�
	}
}