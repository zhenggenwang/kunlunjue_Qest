//������������������������������ع��ű�����������������������������������


//һ�����ѭ������
function Npc_Dialog_411290002(%Npc,%Player,%State,%Conv,%Param)
{
	%PlayerID = %Player.GetPlayerID();
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000015);											//��æ��������͵�����������ܲ��ܰ��������¶���
			if (%Player.IsAcceptedMission(20150)!=1)
				%Conv.AddOption(600000016,600000016);							//�ɼ���ҩ
			if (%Player.IsAcceptedMission(20151)!=1)
				%Conv.AddOption(600000017,600000017);							//��ս��Ӣ
			if (%Player.IsAcceptedMission(20152)!=1)
				%Conv.AddOption(600000018,600000018);							//��ѹȺ��
			if (%Player.IsAcceptedMission(20153)!=1)
				%Conv.AddOption(600000019,600000019);							//��Ԯɢ��
		case 600000016:
			%Conv.SetText(600000020);											//�˴ζ෬���ΰ�������Ȼ���¡���
			AddMissionAccepted(%Player,%Conv,20150);						//�ɼ���ҩ
		case 600000017:
			%Conv.SetText(600000020);											//�˴ζ෬���ΰ�������Ȼ���¡���
			AddMissionAccepted(%Player,%Conv,20151);						//��ս��Ӣ
		case 600000018:
			%Conv.SetText(600000020);											//�˴ζ෬���ΰ�������Ȼ���¡���
			AddMissionAccepted(%Player,%Conv,20152);						//��ѹȺ��
		case 600000019:
			%Conv.SetText(600000020);											//�˴ζ෬���ΰ�������Ȼ���¡���
			AddMissionAccepted(%Player,%Conv,20153);						//��Ԯɢ��
	}
}
//��������һ��Ӫ��
function Npc_Dialog_411291009_411291013(%Npc,%Player,%State,%Conv,%Param,%NeedHelpNpcID)
{
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000020);
			if (%Player.IsAcceptedMission(20153)==1)
			{

				%ThisNpcId = %Player.GetMissionflag(20153,1100);
				if (%NeedHelpNpcID == %ThisNpcId)
				{
					%Conv.AddOption(600000021,600000021);
				}
			}
		case 600000021:
			%Conv.SetText(600000022);
			%Player.SetMissionFlag(20153,1300,%ThisNpcId++);									//��������Ŀ����ɽ���+1
			%Player.updatemission(20153);
	}
}


//�������ѭ������
function Npc_Dialog_411290004(%Npc,%Player,%State,%Conv,%Param)
{
	%PlayerID = %Player.GetPlayerID();
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000015);											//��æ��������͵�����������ܲ��ܰ��������¶���
			if (%Player.IsAcceptedMission(20150)!=1)
				%Conv.AddOption(600000016,600000016);							//�ɼ���ҩ
			if (%Player.IsAcceptedMission(20151)!=1)
				%Conv.AddOption(600000017,600000017);							//��ս��Ӣ
			if (%Player.IsAcceptedMission(20152)!=1)
				%Conv.AddOption(600000018,600000018);							//��ѹȺ��
			if (%Player.IsAcceptedMission(20153)!=1)
				%Conv.AddOption(600000019,600000019);							//��Ԯɢ��
		case 600000016:
			AddMissionAccepted(%Player,%Conv,20154);						//�ɼ���ҩ
			%Conv.SetText(600000020);											//�˴ζ෬���ΰ�������Ȼ���¡���
		case 600000017:
			AddMissionAccepted(%Player,%Conv,20155);						//��ս��Ӣ
			%Conv.SetText(600000020);											//�˴ζ෬���ΰ�������Ȼ���¡���
		case 600000018:
			AddMissionAccepted(%Player,%Conv,20156);						//��ѹȺ��
			%Conv.SetText(600000020);											//�˴ζ෬���ΰ�������Ȼ���¡���
		case 600000019:
			AddMissionAccepted(%Player,%Conv,20157);						//��Ԯɢ��
			%Conv.SetText(600000020);											//�˴ζ෬���ΰ�������Ȼ���¡���
	}
}
//�����������Ӫ��
function Npc_Dialog_411291015_411291019(%Npc,%Player,%State,%Conv,%Param,%NeedHelpNpcID)
{
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000020);
			if (%Player.IsAcceptedMission(20157)==1)
			{

				%ThisNpcId = %Player.GetMissionflag(20157,1100);
				if (%NeedHelpNpcID == %ThisNpcId)
				{
					%Conv.AddOption(600000021,600000021);
				}
			}
		case 600000021:
			%Conv.SetText(600000022);
			%Player.SetMissionFlag(20157,1300,%ThisNpcId++);									//��������Ŀ����ɽ���+1
			%Player.updatemission(20157);
	}
}


//=============================��������1������=======================================
function Mission_Begin_Process_20150(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20150_20153(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_Begin_Process_20151(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20150_20153(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_Begin_Process_20152(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20150_20153(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_Begin_Process_20153(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20150_20153(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_Begin_Process_20150_20153(%Npc,%Player,%Conv,%Param,%Mid)
{
	switch (%Mid)
	{
		case 20150:
			%ItemID = GetRandom(108020108,108020112);								//δ�޸ģ���ʱ�����ɿߵĵ���
			%Player.SetMissionFlag(20150,1100,%ItemID);								//������ƷID
			%Player.SetMissionFlag(20150,1200,5);									//������Ʒ������
			%Player.SetMissionFlag(20150,1300,%Player.GetItemCount(%RandomId));	//������Ʒ��ǰ����
			%Player.updatemission(20150);
		case 20151:
			%SuperEnmityID = GetRandom(411291001,411291005);
			%Player.SetMissionFlag(20151,3100,%SuperEnmityID);						//���ù�����
			%Player.SetMissionFlag(20151,3200,7);									//���ù���������
			%Player.SetMissionFlag(20151,3300,0);									//���ù����ѻ�������
			%Player.updatemission(20151);
		case 20152:
			%EnmityID = GetRandom(411291006,411291010);
			%Player.SetMissionFlag(20152,3100,%EnmityID);							//���ù�����
			%Player.SetMissionFlag(20152,3200,30);									//���ù���������
			%Player.SetMissionFlag(20152,3300,0);									//���ù����ѻ�������
			%Player.updatemission(20152);
		case 20153:
			%NeedHelpNpcId = GetRandom(411290009,411290013);							//Ӫ��NPCID
			%Player.SetMissionFlag(20153,1100,%NeedHelpNpcId);
			%Player.SetMissionFlag(20153,1200,1);
			%Player.SetMissionFlag(20153,1300,0);
			%Player.UpdateMission(20153);
	}
}


//=============================��������2������=======================================

function Mission_Begin_Process_20154(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20154_20157(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_Begin_Process_20155(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20154_20157(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_Begin_Process_20156(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20154_20157(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_Begin_Process_20157(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20154_20157(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_Begin_Process_20154_20157(%Npc,%Player,%Conv,%Param,%Mid)
{
	switch (%Mid)
	{
		case 20150:
			%ItemID = GetRandom(108020113,108020117);								//δ�޸ģ���ʱ�����ɿߵĵ���
			%Player.SetMissionFlag(20154,1100,%ItemID);								//������ƷID
			%Player.SetMissionFlag(20154,1200,5);									//������Ʒ������
			%Player.SetMissionFlag(20154,1300,%Player.GetItemCount(%ItemID));		//������Ʒ��ǰ����
			%Player.updatemission(20154);
		case 20151:
			%SuperEnmityID = GetRandom(411291011,411291015);
			%Player.SetMissionFlag(20155,3100,%SuperEnmityID);						//���ù�����
			%Player.SetMissionFlag(20155,3200,7);									//���ù���������
			%Player.SetMissionFlag(20155,3300,0);									//���ù����ѻ�������
			%Player.updatemission(20155);
		case 20152:
			%EnmityID = GetRandom(411291016,411291020);
			%Player.SetMissionFlag(20156,3100,%EnmityID);							//���ù�����
			%Player.SetMissionFlag(20156,3200,30);									//���ù���������
			%Player.SetMissionFlag(20156,3300,0);									//���ù����ѻ�������
			%Player.updatemission(20156);
		case 20153:
			%NeedHelpNpcId = GetRandom(411290015,411290019);							//����Ӫ��NPC
			%Player.SetMissionFlag(20157,1100,%NeedHelpNpcId);
			%Player.SetMissionFlag(20157,1200,1);
			%Player.SetMissionFlag(20157,1300,0);
			%Player.UpdateMission(20157);
	}
}