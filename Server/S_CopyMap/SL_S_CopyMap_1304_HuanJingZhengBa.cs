//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//�þ�����
//==================================================================================

//�����������þ����ԡ�����������ȫ�ֱ�����š���������������
//�����������þ����ԡ�����������ϵͳ���桿������������������
//�����������þ����ԡ�����������NPC���ͶԻ� ����������������
//�����������þ����ԡ���������������������������������������
//�����������þ����ԡ�������������ҽ��븱������������������
//�����������þ����ԡ�����������ս�����̵���ʱ��������������
//�����������þ����ԡ�������������ɫ����������������������
//�����������þ����ԡ�������������һ�����ҡ���������������
//�����������þ����ԡ����������������������̡���������������
//�����������þ����ԡ������������������򴥷�����������������
//�����������þ����ԡ��������������齱�����㡿��������������
//�����������þ����ԡ������������ɼ����䴥������������������

//�����������þ����ԡ�����������ϵͳ���桿������������������
function CopyMap_HuanJingZhengBa_StytemMsg(%YY,%MM,%DD,%H,%M,%S)
{
	if (GetZoneid() != 1001)
		return;
	if ($SL_HuanJingZhengBa_bActive != 1)
		return;
	%LocalWeek = GetLocalWeek();
	%Count = GetWordCount($SL_HuanJingZhengBa_Week);
	%Mark = 0;
	for (%i=0; %i < %Count; %i++)
	{
		%OpenWeek = GetWord($SL_HuanJingZhengBa_Week,%i) * 1;
		if (%OpenWeek == %LocalWeek)
		{
			%Mark = 1;
			break;
		}
	}
	if (%Mark != 1)
		return;

	%TimeNow = %H * 60 + %M;
	%TimeStart = GetWord($SL_HuanJingZhengBa_StartTime,0,":") * 60 + GetWord($SL_HuanJingZhengBa_StartTime,1,":");
	%Havetime = %TimeStart - %TimeNow;
	if (%Havetime == 10 || %Havetime == 5 || %Havetime == 0)
	{
		%HuoDongMingCheng = GetHuoDongName("�þ�����",1);
		%HuoDongMingCheng2 = GetHuoDongName("�þ�����",2);
		//%Path = GetTraceButton( "findpath(410010211);", GetNpcData( 410010211, 1 ) );//NPCѰ��
		%Path = "<l i='810010100 -50.8703 -93.6181 185.678' t='path'/>";
		if (%Havetime > 0)
		{
			%Text = %HuoDongMingCheng @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ %Havetime @ "</t><t>���Ӻ�����</t>" @ $SL_HuanJingZhengBa_Level @ "<t>������ʿ��ǰ��</t>" @ %Path @ "<t>������ս��</t>";
			%Text2 = %HuoDongMingCheng2 @ "<t>����</t>" @ $Get_Dialog_GeShi[60002] @ %Havetime @ "</t><t>���Ӻ���</t>";
		}
		else
		{
			%Text = %HuoDongMingCheng @ "<t>�Ѿ�������</t>" @ $SL_HuanJingZhengBa_Level @ "<t>������ʿ��ǰ��</t>" @ %Path @ "<t>������ս��</t>";
			%Text2 = %HuoDongMingCheng2 @ "<t>�Ѿ�����</t>";
		}
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
}
//�����������þ����ԡ�����������ϵͳ���桿������������������

//�����������þ����ԡ�����������NPC���ͶԻ� ����������������
function NpcOnTrigger_Dialog_410010211(%Npc,%Player,%State,%Conv,%Param)
{
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000013);
			if (Getzoneid() < 1300)
				%Conv.AddOption(600000014,600000014);
		case 600000014:
			%Conv.Settype(4);
			if (%Player.Getlevel() < $SL_HuanJingZhengBa_Level)
			{
				%text = $SL_HuanJingZhengBa_Level @ "�������޷���ս�þ����ԣ�";
				SendOneScreenMessage(2,%text,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
				return;
			}
			if ($SL_HuanJingZhengBa_State_bActive != 1)
			{
				%text = "�þ�������δ���ţ�";
				SendOneScreenMessage(2,%text,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
				return;
			}
			if (SvrIsMyselfHasTeam(%Player.GetPlayerID()))
			{
				%text = "ֻ�����˽��룡";
				SendOneScreenMessage(2,%text,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
				return;
			}
			GoToNextMap(%Player,1304,"");
	}
}
//�����������þ����ԡ�����������NPC���ͶԻ� ����������������


//�����������þ����ԡ���������������������������������������
function SvrCopymapOpen_1304_Trigger(%CopyMapID,%CopymapDataID)
{
	CanCel($SptCopymap_1304_Combat[%CopyMapID]);
	$CopyMap1304Msg[%CopyMapID] = "0 0 0 0 0 0";
	$SptCopymap_1304_Combat[%CopyMapID] = schedule(1000,0,"SptCopymap_1304_CombatFlow",%CopyMapID,0);//��ʼִ��ս������
}
//�����������þ����ԡ���������������������������������������


//�����������þ����ԡ�������������ҽ��븱������������������
function sptCopymap_OnEnter_1304_Trigger(%CopyMapID,%Player)
{
	%Player.SetForce(%Player);
	%Player.SetShapeName("������ʿ");
	%PlayerID = %Player.GetPlayerID();
	$SptCopymap1304NowKillState[%CopyMapID,%PlayerID] = 0;//��ǰ����״̬��¼
	$CopyMap1304TimeRecord[%CopyMapID,%PlayerID] = 0;

	if ($SptCopymap_1304_States[%CopyMapID]  >= 1)
	{
		%Player.SetSchBuff(2002);
		%X = GetWord($Transport_Xyz[813020200],0);
		%Y = GetWord($Transport_Xyz[813020200],1);
		%Pos = GetNavPos(%X,%Y,30);
		%Pos_X = GetWord(%Pos,0);
		%Pos_Y = GetWord(%Pos,1);
		%Pos_Z = GetWord(%Pos,2);
		if (%Pos_X == 0 && %Pos_Y == 0 && %Pos_Z == 0)
		{
			%Pos_X = %X;
			%Pos_Y = %Y;
			%Pos_Z = GetWord($Transport_Xyz[813020200],2);
		}
		%Player.TransportObject(0,0,%Pos_X,%Pos_Y,%Pos_Z);
	}

	%Msg = $CopyMap1304Msg[%CopyMapID] @ " " @ $CopyMap1304TimeRecord[%CopyMapID,%PlayerID] * 1 @ " " @ $SptCopymap1304NowKillState[%CopyMapID,%PlayerID] * 1;
	%Player.SendPlayerString(6,%Msg,0);
}
//�����������þ����ԡ�������������ҽ��븱������������������

//�����������þ����ԡ�����������ս�����̵���ʱ��������������
function SptCopymap_1304_CombatFlow(%CopyMapID,%Step)
{
	CanCel($SptCopymap_1304_Combat[%CopyMapID]);
	$CopyMap1304TimeRecord[%CopyMapID] = %Step;//ս������ʱ���¼
	//echo( "$CopyMap1304TimeRecord[ %CopyMapID ]===" @ $CopyMap1304TimeRecord[ %CopyMapID ] );
	%Time = 10;
	if (%Step == 60)
	{
		%text = "�þ����Ի���1���ӿ�ս��������׼��";
		SendAllChatMessageLayer(0,$Get_Dialog_GeShi[31406]  @ %text @ "</t>",%CopyMapID);	//���͸�������Ϣ( ��Ļ���� )
		SendAllScreenMessageLayer(0,%text,%CopyMapID);	//���͸�������Ϣ( ��Ļ�м� )
	}
	if (%Step >= 109 && %Step < 120)
	{
		%text = "����" @ 120 - %Step @ "�뿪ս��������׼��";
		SendAllChatMessageLayer(0,$Get_Dialog_GeShi[31406]  @ %text @ "</t>",%CopyMapID);	//���͸�������Ϣ( ��Ļ���� )
		SendAllScreenMessageLayer(0,%text,%CopyMapID);	//���͸�������Ϣ( ��Ļ�м� )
		%Time = 1;
	}
	if (%Step == 120)
	{
		$SptCopymap_1304_States[%CopyMapID] = 1;

		%text = "ս����ʼ";
		SendAllChatMessageLayer(0,$Get_Dialog_GeShi[31406]  @ %text @ "</t>",%CopyMapID);	//���͸�������Ϣ( ��Ļ���� )
		SendAllScreenMessageLayer(0,%text,%CopyMapID);	//���͸�������Ϣ( ��Ļ�м� )

		%X = GetWord($Transport_Xyz[813020200],0);
		%Y = GetWord($Transport_Xyz[813020200],1);
		%TeammateList = SptCopyMap_GetAllPlayer(%CopyMapID);//��ȡ���������Ϣ
		%TeammateNum = SptCopyMap_GetPlayerCount(%CopyMapID);//��ȡ�����������
		for (%i = 0; %i < %TeammateNum; %i++)
		{
			%Player = GetWord(%TeammateList,%i);

			%Player.SetSchBuff(2002);
			SetSrc(%Player,4);
			%Pos = GetNavPos(%X,%Y,30);
			%Pos_X = GetWord(%Pos,0);
			%Pos_Y = GetWord(%Pos,1);
			%Pos_Z = GetWord(%Pos,2);
			if (%Pos_X == 0 && %Pos_Y == 0 && %Pos_Z == 0)
			{
				%Pos_X = %X;
				%Pos_Y = %Y;
				%Pos_Z = GetWord($Transport_Xyz[813020200],2);
			}
			%Player.TransportObject(0,0,%Pos_X,%Pos_Y,%Pos_Z);
		}
		%Time = 10;
	}
	if (%Step == 1500 || %Step == 1200 || %Step == 900  || %Step == 600  || %Step == 300)//ˢ�±���
	{
		for (%i = 1; %i <=3; %i++)
		{
			%Pos = GetNavPos(GetWord($Transport_Xyz[813020400],0),GetWord($Transport_Xyz[813020400],1),30);
			if (%Pos $= "" || %Pos $= "0 0 0")
				%Pos = $Transport_Xyz[813020400];
			%Obj = SpNewCj2(0,553000041,%Pos,%CopyMapID,GetRandom(0,360),"1.5 1.5 1.5");

			%Pos = GetNavPos(GetWord($Transport_Xyz[813020500],0),GetWord($Transport_Xyz[813020500],1),30);
			if (%Pos $= "" || %Pos $= "0 0 0")
				%Pos = $Transport_Xyz[813020500];
			%Obj = SpNewCj2(0,553000042,%Pos,%CopyMapID,GetRandom(0,360),"2 2 2");
		}
		if (%Step == 1500)
		{
			%Pos = GetNavPos(GetWord($Transport_Xyz[813020500],0),GetWord($Transport_Xyz[813020500],1),30);
			if (%Pos $= "" || %Pos $= "0 0 0")
				%Pos = $Transport_Xyz[813020500];
			%Obj = SpNewCj2(0,553000043,%Pos,%CopyMapID,GetRandom(0,360),"2 2 2");
		}
		%Name = $Get_Dialog_GeShi[31422] @ "���þ����ء�</t>";
		%Path1 = "<l i='813020400 -105.851 110.093 204.246' t='path'/>";
		%Path2 = "<l i='813020500 118.502 103.178 202.577' t='path'/>";
		%Text1 = %Path1 @ "<t>������</t>" @ %Name @ "<t>��</t>";
		%Text2 = %Path2 @ "<t>������</t>" @ %Name @ "<t>��</t>";
		SendAllChatMessageLayer(0,$Get_Dialog_GeShi[31406]  @ %text1 @ "</t>",%CopyMapID);	//���͸�������Ϣ( ��Ļ���� )
		SendAllChatMessageLayer(0,$Get_Dialog_GeShi[31406]  @ %text2 @ "</t>",%CopyMapID);
	}
	if (%Step >= 1800)//��������
	{
		%Time = 0;
		SptCopymap_1304_Close(%CopyMapID);
	}
	//-----------�Ƿ���ս����Ϣ�Ĵ���-------------

	if (%Step%30 == 10)//ÿ30�뷢��һ��
	{
		$CopyMap1304PeoPleRecord[%CopyMapID,813020100] = 0;//��������
		$CopyMap1304PeoPleRecord[%CopyMapID,813020200] = 0;//��������
		$CopyMap1304PeoPleRecord[%CopyMapID,813020300] = 0;//��������
		$CopyMap1304PeoPleRecord[%CopyMapID,813020400] = 0;//��������
		$CopyMap1304PeoPleRecord[%CopyMapID,813020500] = 0;//��������

		%TeammateList = SptCopyMap_GetAllPlayer(%CopyMapID);//��ȡ���������Ϣ
		%TeammateNum = SptCopyMap_GetPlayerCount(%CopyMapID);//��ȡ�����������
		for (%i = 0; %i < %TeammateNum; %i++)
		{
			%Player = getword(%TeammateList,%i);
			%PlayerTarGetID = %Player.GetTriggerid();
			%PlayerTarGetID = GetSubStr(%PlayerTarGetID,0,7) @ "00";
			$CopyMap1304PeoPleRecord[%CopyMapID,%PlayerTarGetID]++;
		}
		//��¼����
		$CopyMap1304Msg[%CopyMapID] = $CopyMap1304TimeRecord[%CopyMapID] @ " " @ $CopyMap1304PeoPleRecord[%CopyMapID,813020100] @ " " @ $CopyMap1304PeoPleRecord[%CopyMapID,813020200] @ " " @ $CopyMap1304PeoPleRecord[%CopyMapID,813020300] @ " " @ $CopyMap1304PeoPleRecord[%CopyMapID,813020400] @ " " @ $CopyMap1304PeoPleRecord[%CopyMapID,813020500];
		for (%i = 0; %i < %TeammateNum; %i++)
		{
			%Player = getword(%TeammateList,%i);
			%PlayerID = %Player.GetPlayerID();
			%Msg = $CopyMap1304Msg[%CopyMapID] @ " " @ $CopyMap1304TimeRecord[%CopyMapID,%PlayerID] * 1 @ " " @ $SptCopymap1304NowKillState[%CopyMapID,%PlayerID] * 1;//���͵����������ɱ����
			//echo( "%Msg=cccc=" @ %Msg );
			%Player.SendPlayerString(6,%Msg,0);//�������пͻ������ÿ���
		}
	}

	//------------------------
	if (%Time > 0)
		$SptCopymap_1304_Combat[%CopyMapID] = schedule(%Time * 1000,0,"SptCopymap_1304_CombatFlow",%CopyMapID,%Step + %Time);//��ʼִ��ս������

}
//�����������þ����ԡ�����������ս�����̵���ʱ��������������


//�����������þ����ԡ�������������ɫ����������������������
function SvrEventOnDisabled_1304(%Player,%Optype)
{
	if (%Optype == 0)
	{
		schedule(5 * 1000,0,"SvrEventOnDisabled_1304",%Player,%Optype + 10);
		return;
	}
	if (%Optype == 10)
	{
		%CopyMapID = %Player.GetLayerID();
		%TriggerID = %Player.GetTriggerID();
		%PlayerID = %Player.GetPlayerID();
		$SptCopymap1304NowKillState[%CopyMapID,%PlayerID]--;

		if (%TriggerID > 813020200 && $SptCopymap1304NowKillState[%CopyMapID,%PlayerID] <= -5)//������
		{
			%TriggerID = %TriggerID - 100;
			$SptCopymap1304NowKillState[%CopyMapID,%PlayerID] = 0;

		}
		%X = GetWord($Transport_Xyz[%TriggerID],0);
		%Y = GetWord($Transport_Xyz[%TriggerID],1);
		%Pos = GetNavPos(%X,%Y,30);
		%Pos_X = GetWord(%Pos,0);
		%Pos_Y = GetWord(%Pos,1);
		%Pos_Z = GetWord(%Pos,2);
		if (%Pos_X == 0 && %Pos_Y == 0 && %Pos_Z == 0)
		{
			%Pos_X = %X;
			%Pos_Y = %Y;
			%Pos_Z = GetWord($Transport_Xyz[%TriggerID],2);
		}
		%Player.SetDamageState(Enabled);	//�������
		%Player.AddBuff(399020200,%Player,50);
		%Player.AddBuff(390030003);	//�޵�BUFF

		%Player.TransportObject(0,0,%Pos_X,%Pos_Y,%Pos_Z);

		%Msg = $CopyMap1304Msg[%CopyMapID] @ " " @ $CopyMap1304TimeRecord[%CopyMapID,%PlayerID] * 1 @ " " @ $SptCopymap1304NowKillState[%CopyMapID,%PlayerID];//���͵����������ɱ����
		//echo( "%Msg=aaa=" @ %Msg );
		%Player.SendPlayerString(6,%Msg,0);
	}

}
//�����������þ����ԡ�������������ɫ����������������������

//�����������þ����ԡ�������������һ�����ҡ���������������
function PlayeronDeathCast_1304(%Player,%killer)
{
	%CopyMapID = %killer.GetLayerID();

	%killerID = %killer.GetPlayerID();
	if ($SptCopymap1304NowKillState[%CopyMapID,%killerID] <= 0)
		$SptCopymap1304NowKillState[%CopyMapID,%killerID] = 1;
	else
		$SptCopymap1304NowKillState[%CopyMapID,%killerID]++;

	$CopyMap1304TimeRecord[%CopyMapID,%killerID]++;
	//if ( $CopyMap1304TimeRecord[ %CopyMapID, %killerID ] >= 5 )
	//	$CopyMap1304TimeRecord[ %CopyMapID, %killerID ] = 5;

	%TriggerID = %killer.GetTriggerID();
	if ($SptCopymap1304NowKillState[%CopyMapID,%killerID] >= 5 && %TriggerID < 813020500)//����֮·
	{
		%TriggerID = %TriggerID + 100;

		$SptCopymap1304NowKillState[%CopyMapID,%killerID] = 0;

		%X = GetWord($Transport_Xyz[%TriggerID],0);
		%Y = GetWord($Transport_Xyz[%TriggerID],1);
		%Pos = GetNavPos(%X,%Y,30);
		%Pos_X = GetWord(%Pos,0);
		%Pos_Y = GetWord(%Pos,1);
		%Pos_Z = GetWord(%Pos,2);
		if (%Pos_X == 0 && %Pos_Y == 0 && %Pos_Z == 0)
		{
			%Pos_X = %X;
			%Pos_Y = %Y;
			%Pos_Z = GetWord($Transport_Xyz[%TriggerID],2);
		}
		%killer.TransportObject(0,0,%Pos_X,%Pos_Y,%Pos_Z);
	}
	%Msg = $CopyMap1304Msg[%CopyMapID] @ " " @ $CopyMap1304TimeRecord[%CopyMapID,%killerID] * 1 @ " " @ $SptCopymap1304NowKillState[%CopyMapID,%killerID];//���͵����������ɱ����

	//echo( "%Msg=bbb=" @ %Msg );
	%killer.SendPlayerString(6,%Msg,0);
}
//�����������þ����ԡ�������������һ�����ҡ���������������

//�����������þ����ԡ����������������������̡���������������
function SptCopymap_1304_Close(%CopyMapID)
{
	SptCopymap_Close(%CopyMapID);//�رո�����
	%Pos_X = GetWord($Transport_Xyz[813020100],0);
	%Pos_Y = GetWord($Transport_Xyz[813020100],1);
	%Pos_Z = GetWord($Transport_Xyz[813020100],2);
	%TeammateList = SptCopyMap_GetAllPlayer(%CopyMapID);//��ȡ���������Ϣ
	%TeammateNum = SptCopyMap_GetPlayerCount(%CopyMapID);//��ȡ�����������
	for (%i = 0; %i < %TeammateNum; %i++)
	{
		%Player = GetWord(%TeammateList,%i);
		%Player.TransportObject(0,0,GetRanDom(%Pos_X - 5,%Pos_X + 5),GetRanDom(%Pos_Y - 5,%Pos_Y + 5),%Pos_Z);
		if (%Player.Isschbuff(2002))
			%Player.RemoveSchbuff(2002);
		%text = "���λþ����Ի��������������뿪ս��";
		SendAllChatMessageLayer(0,$Get_Dialog_GeShi[31406]  @ %text @ "</t>",%CopyMapID);	//���͸�������Ϣ( ��Ļ���� )
		SendAllScreenMessageLayer(0,%text,%CopyMapID);	//���͸�������Ϣ( ��Ļ�м� )
	}
}
//�����������þ����ԡ����������������������̡���������������

//�����������þ����ԡ������������������򴥷�����������������
function PlayerEnterTrigger_813020100(%Player,%TriggerId){ PlayerEnterTrigger_813020200_813020500(%Player,%TriggerId); }
function PlayerEnterTrigger_813020200(%Player,%TriggerId){ PlayerEnterTrigger_813020200_813020500(%Player,%TriggerId); }
function PlayerEnterTrigger_813020300(%Player,%TriggerId){ PlayerEnterTrigger_813020200_813020500(%Player,%TriggerId); }
function PlayerEnterTrigger_813020400(%Player,%TriggerId){ PlayerEnterTrigger_813020200_813020500(%Player,%TriggerId); }
function PlayerEnterTrigger_813020500(%Player,%TriggerId){ PlayerEnterTrigger_813020200_813020500(%Player,%TriggerId); }
function PlayerEnterTrigger_813020200_813020500(%Player,%TriggerId)
{
	%CopyMapID = %Player.GetLayerID();
	$CopyMap1304PeoPleRecord[%CopyMapID,%TriggerID]++;
	$CopyMap1304Msg[%CopyMapID] = $CopyMap1304TimeRecord[%CopyMapID] * 1@ " " @ $CopyMap1304PeoPleRecord[%CopyMapID,813020100] * 1 @ " " @ $CopyMap1304PeoPleRecord[%CopyMapID,813020200] * 1 @ " " @ $CopyMap1304PeoPleRecord[%CopyMapID,813020300] * 1 @ " " @ $CopyMap1304PeoPleRecord[%CopyMapID,813020400] * 1 @ " " @ $CopyMap1304PeoPleRecord[%CopyMapID,813020500] * 1;
	//echo( "$CopyMap1304Msg[ %CopyMapID ]===" @ $CopyMap1304Msg[ %CopyMapID ] );
}
function PlayerOnExitTrigger_813020100(%Player){ PlayerOnExitTrigger_813020200_813020500(%Player,813020100); }
function PlayerOnExitTrigger_813020200(%Player){ PlayerOnExitTrigger_813020200_813020500(%Player,813020200); }
function PlayerOnExitTrigger_813020300(%Player){ PlayerOnExitTrigger_813020200_813020500(%Player,813020300); }
function PlayerOnExitTrigger_813020400(%Player){ PlayerOnExitTrigger_813020200_813020500(%Player,813020400); }
function PlayerOnExitTrigger_813020500(%Player){ PlayerOnExitTrigger_813020200_813020500(%Player,813020500); }
function PlayerOnExitTrigger_813020200_813020500(%Player,%TriggerId)
{
	%CopyMapID = %Player.GetLayerID();
	$CopyMap1304PeoPleRecord[%CopyMapID,%TriggerID]--;
	$CopyMap1304Msg[%CopyMapID] = $CopyMap1304TimeRecord[%CopyMapID] * 1@ " " @ $CopyMap1304PeoPleRecord[%CopyMapID,813020100] * 1 @ " " @ $CopyMap1304PeoPleRecord[%CopyMapID,813020200] * 1 @ " " @ $CopyMap1304PeoPleRecord[%CopyMapID,813020300] * 1 @ " " @ $CopyMap1304PeoPleRecord[%CopyMapID,813020400] * 1 @ " " @ $CopyMap1304PeoPleRecord[%CopyMapID,813020500] * 1;
	//echo( "$CopyMap1304Msg[ %CopyMapID ]===" @ $CopyMap1304Msg[ %CopyMapID ] );
}
//�����������þ����ԡ������������������򴥷�����������������

//�����������þ����ԡ��������������齱�����㡿��������������
function ScheduleBuff_2002(%Player,%BuffID,%IsAuto)//�þ����Ծ���BUFF
{
	%TriggerID = %Player.Gettriggerid();

	%Exp_LeiJiaBeiShu = 0;
	if (%Player.ISschbuff(1997)) %Exp_LeiJiaBeiShu = 1;	  //���鵤�ļӳ�
	else if (%Player.ISschbuff(1998)) %Exp_LeiJiaBeiShu = 1.5; //���鵤�ļӳ�
	else if (%Player.ISschbuff(1999)) %Exp_LeiJiaBeiShu = 2;	  //���鵤�ļӳ�

	%Level = %Player.getlevel();
	if (%Level < 30) %levelxishu = 0.3;
	else if (%Level < 40) %levelxishu = 1;
	else if (%Level < 50) %levelxishu = 1.2;
	else if (%Level < 60) %levelxishu = 1.6;
	else if (%Level < 70) %levelxishu = 2;
	else %levelxishu = 2.2;

	switch (%TriggerID)
	{
		case 813020200: %expbeishu = 1.0;
		case 813020300: %expbeishu = 1.2;
		case 813020400: %expbeishu = 1.5;
		case 813020500: %expbeishu = 2.0;
		default:
			return 1;
	}
	%Exp = $Monster_Exp[%Level,1] * %expbeishu * %levelxishu *(1 + %Exp_LeiJiaBeiShu);
	if (%Exp > 0)
		AllAddExp(%Player,%Exp);
	%Player.SetSchbuff(2002);
	return 0;
}
//�����������þ����ԡ��������������齱�����㡿��������������


//�����������þ����ԡ������������ɼ����䴥������������������
function TriggerEvent_553000041(%Player,%Event,%EventID)//3�㱦��
{
	%ItemID[0] = 105105301; %ItemMsg[0] = 0; %itemRan[0] = 2000;
	%ItemID[1] = 105105302; %ItemMsg[1] = 2; %itemRan[1] = 1504;
	%ItemID[2] = 105105303; %ItemMsg[2] = 2; %itemRan[2] = 1166;
	%ItemID[3] = 105105713; %ItemMsg[3] = 3; %itemRan[3] = 532;
	%ItemID[4] = 105090411; %ItemMsg[4] = 2; %itemRan[4] = 1366;
	%ItemID[5] = 105090412; %ItemMsg[5] = 3; %itemRan[5] = 400;
	%ItemID[6] = 105100101; %ItemMsg[6] = 2; %itemRan[6] = 1266;
	%ItemID[7] = 105100111; %ItemMsg[7] = 2; %itemRan[7] = 1266;
	%ItemID[8] = 105100131; %ItemMsg[8] = 2; %itemRan[8] = 500;
	%Ran = GetRanDom(1,10000);
	%All = 0;
	for (%i = 0; %i <= 8; %i++)
	{
		%All = %All + %itemRan[%i];
		if (%All >= %Ran)
		{
			%ItemID = %ItemID[%i];
			%Msg = %ItemMsg[%i];
			break;
		}
	}
	if (%ItemID > 0)
	{
		%Player.PutItem(%ItemID,1);
		if (%Player.Additem(4,%EventID))
		{
			if (%Msg > 0)
			{
				%ItemName1 = GetItemName(%ItemID,1);
				%ItemName2 = GetItemName(%ItemID,2);
				%HuoDongMingCheng1 = GetHuoDongName("�þ�����",1);
				%HuoDongMingCheng2 = GetHuoDongName("�þ�����",2);
				%MapName = GetMapName(%Player,2);
				%Path = "<l i='" @ GetSubStr(%Player.Gettriggerid(),0,7) @ "00 " @ %Player.GetPosition() @ "' t='path'/>";
				%Text1 = "<t>������ʿ��</t>" @ %Path @ "<t>����</t>" @ %HuoDongMingCheng1 @ "<t>���</t>" @ %ItemName1 @ "<t>������˭��</t>";
				%Text2 = "<t>������ʿ��</t>" @ %MapName @ "<t>����</t>" @ %HuoDongMingCheng2 @ "<t>���</t>" @ %ItemName2 @ "<t>������˭��</t>";
				switch (%Msg)
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
	return true;
}

function TriggerEvent_553000042(%Player,%Event,%EventID)//4�㱦��
{
	%ItemID[0] = 105105301; %ItemMsg[0] = 0; %itemRan[0] = 1000;
	%ItemID[1] = 105105302; %ItemMsg[1] = 2; %itemRan[1] = 502;
	%ItemID[2] = 105105303; %ItemMsg[2] = 2; %itemRan[2] = 1856;
	%ItemID[3] = 105105304; %ItemMsg[3] = 3; %itemRan[3] = 300;
	%ItemID[4] = 105105713; %ItemMsg[4] = 3; %itemRan[4] = 700;
	%ItemID[5] = 105090412; %ItemMsg[5] = 3; %itemRan[5] = 700;
	%ItemID[6] = 105090413; %ItemMsg[6] = 3; %itemRan[6] = 500;
	%ItemID[7] = 105100102; %ItemMsg[7] = 2; %itemRan[7] = 1850;
	%ItemID[8] = 105100112; %ItemMsg[8] = 2; %itemRan[8] = 1850;
	%ItemID[9] = 105100131; %ItemMsg[9] = 2; %itemRan[9] = 742;

	%Ran = GetRanDom(1,10000);
	%All = 0;
	for (%i = 0; %i <= 9; %i++)
	{
		%All = %All + %itemRan[%i];
		if (%All >= %Ran)
		{
			%ItemID = %ItemID[%i];
			%Msg = %ItemMsg[%i];
			break;
		}
	}
	if (%ItemID > 0)
	{
		%Player.PutItem(%ItemID,1);
		if (%Player.Additem(4,%EventID))
		{
			if (%Msg > 0)
			{
				%ItemName1 = GetItemName(%ItemID,1);
				%ItemName2 = GetItemName(%ItemID,2);
				%HuoDongMingCheng1 = GetHuoDongName("�þ�����",1);
				%HuoDongMingCheng2 = GetHuoDongName("�þ�����",2);
				%MapName = GetMapName(%Player,2);
				%Path = "<l i='" @ GetSubStr(%Player.Gettriggerid(),0,7) @ "00 " @ %Player.GetPosition() @ "' t='path'/>";
				%Text1 = "<t>������ʿ��</t>" @ %Path @ "<t>����</t>" @ %HuoDongMingCheng1 @ "<t>���</t>" @ %ItemName1 @ "<t>������˭��</t>";
				%Text2 = "<t>������ʿ��</t>" @ %MapName @ "<t>����</t>" @ %HuoDongMingCheng2 @ "<t>���</t>" @ %ItemName2 @ "<t>������˭��</t>";
				switch (%Msg)
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

	return true;
}

function TriggerEvent_553000043(%Player,%Event,%EventID)//���Ĵ���
{
	%ItemID[1] = 105105303; %ItemMsg[1] = 3; %itemRan[1] = 1250;
	%ItemID[2] = 105105304; %ItemMsg[2] = 3; %itemRan[2] = 1250;
	%ItemID[3] = 105105713; %ItemMsg[3] = 3; %itemRan[3] = 1250;
	%ItemID[4] = 105090412; %ItemMsg[4] = 3; %itemRan[4] = 1250;
	%ItemID[5] = 105090413; %ItemMsg[5] = 3; %itemRan[5] = 1250;
	%ItemID[6] = 105100103; %ItemMsg[6] = 3; %itemRan[6] = 1250;
	%ItemID[7] = 105100103; %ItemMsg[7] = 3; %itemRan[7] = 1250;
	%ItemID[8] = 105090414; %ItemMsg[8] = 3; %itemRan[8] = 1250;

	%Ran = GetRanDom(1,10000);
	%All = 0;
	for (%i = 1; %i <= 8; %i++)
	{
		%All = %All + %itemRan[%i];
		if (%All >= %Ran)
		{
			%ItemID = %ItemID[%i];
			%Msg = %ItemMsg[%i];
			break;
		}
	}
	if (%ItemID > 0)
	{
		%Player.PutItem(%ItemID,1);
		if (%Player.Additem(4,%EventID))
		{
			if (%Msg > 0)
			{
				%ItemName1 = GetItemName(%ItemID,1);
				%ItemName2 = GetItemName(%ItemID,2);
				%HuoDongMingCheng1 = GetHuoDongName("�þ�����",1);
				%HuoDongMingCheng2 = GetHuoDongName("�þ�����",2);
				%MapName = GetMapName(%Player,2);
				%Path = "<l i='" @ GetSubStr(%Player.Gettriggerid(),0,7) @ "00 " @ %Player.GetPosition() @ "' t='path'/>";
				%Text1 = "<t>������ʿ��</t>" @ %Path @ "<t>����</t>" @ %HuoDongMingCheng1 @ "<t>���</t>" @ %ItemName1 @ "<t>������˭��</t>";
				%Text2 = "<t>������ʿ��</t>" @ %MapName @ "<t>����</t>" @ %HuoDongMingCheng2 @ "<t>���</t>" @ %ItemName2 @ "<t>������˭��</t>";
				switch (%Msg)
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

	return true;
}
//�����������þ����ԡ������������ɼ����䴥������������������