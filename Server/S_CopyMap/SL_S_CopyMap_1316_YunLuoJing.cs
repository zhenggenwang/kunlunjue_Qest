//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//���޾�
//==================================================================================
//�������������޾�������������ȫ�ֱ�������������������
//�������������޾�������������������������������������
//�������������޾���������������ҽ��븱��������������
//�������������޾������������� NPC�Ի�����������������
//�������������޾�������������������������������������
//�������������޾��������������ɼ����䴥��������������
//�������������޾�����������������ս������������������

//�������������޾�������������ȫ�ֱ�������������������
$CopyMapPosRecord1316[0]="0.127668 0.137097 105.071";//����
$CopyMapPosRecord1316[1]="-61.6246 0.59848 102.84";//�󻤷�
$CopyMapPosRecord1316[2]="61.6226 -0.594851 102.84";//�һ���
$CopyMapPosRecord1316[3]="0.49874 66.8154 106.56";//����


$EventPosRecord[1303,1] = "8.9567 14.0409 105.071";//���޽��Ľڵ�
$EventPosRecord[1303,2] = "14.4285 3.88098 105.071";//���޽��Ľڵ�
$EventPosRecord[1303,3] = "-0.708245 18.6175 105.171";//���޽��Ľڵ�
$EventPosRecord[1303,4] = "-14.3488 -3.34424 105.071";//���޽��Ľڵ�
$EventPosRecord[1303,5] = "-11.489 -13.8675 105.071";//���޽��Ľڵ�
$EventPosRecord[1303,6] = "-0.307822 -18.5197 105.171";//���޽��Ľڵ�
//413033001	���޽���
//413033002	�����󻤷�
//413033003	�����һ���
//413033004	���޳���
//SptMail_Send(  50000159, 105105303, 1, 0, 0, "���߽���", "һ������" );
//SptMail_Send(  50000159, 0, 0, 123456, 654321, "���߽���", "һ������" );
//�������������޾�������������ȫ�ֱ�������������������



//�������������޾�������������������������������������
function SvrCopymapOpen_1316_Trigger(%CopyMapID,%CopymapDataID)
{
	if (!isobject($CopyMapNpcRecord1316[%CopyMapID,1]))
		$CopyMapNpcRecord1316[%CopyMapID,1] = SpNewNpc2(0,413032001,"-2.74134 -81.1813 110.113",%CopyMapID,90);

	//if (!isobject($CopyMapNpcRecord1316[%CopyMapID,2]))
	//	$CopyMapNpcRecord1316[%CopyMapID,2] = SpNewNpc2(0,413032002,"2.93102 -81.3177 110.113",%CopyMapID,270);

	$CopyMapBattleStateReocrd[%CopyMapID] = 0;
	$CopyMapGiftStateReocrd[%CopyMapID] = 1;
}
//�������������޾�������������������������������������

//�������������޾���������������ҽ��븱��������������
function SptCopymap_OnEnter_1316_Trigger(%CopyMapID,%Player)
{

}
//�������������޾���������������ҽ��븱��������������

//�������������޾������������� NPC�Ի�����������������
function YunLuoJing_TransPortObject(%Npc,%Player,%State,%Conv)
{
	switch (%State)
	{
		case 0:
			%Conv.AddOption(600000104,600000104);
		case 600000104:
			if (%Player.GetLevel() < $SL_YunLuoJing_Level)
			{
				%Txt1 = $SL_YunLuoJing_Level @ "�����ϵİ��ɳ�Ա�ſ��ԲμӴ˸���";
				SendOneScreenMessage(2,%Txt1,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %Txt1 @ "</t>",%Player);
				return NpcOnTrigger(%Conv,%Npc,%Player,0,-1);
			}
			if (%Player.GetOrgID() > 0)
			{
				gotonextmap(%Player,"1316","");
			}
			else
			{
				%Txt1 = "�˸���Ϊ������ս��������Ҫ�ȼ�����ɲſ��Բμ�";
				SendOneScreenMessage(2,%Txt1,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %Txt1 @ "</t>",%Player);
				return NpcOnTrigger(%Conv,%Npc,%Player,0,-1);
			}
	}
}
function YunLuoJing_DiaLog(%Npc,%Player,%State,%Conv)
{
	%CopyMapID = %Player.GetLayerID();
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000105);
			if ($CopyMapBattleStateReocrd[%CopyMapID] != 1)
				%Conv.AddOption(600000106,600000106);
		case 600000106:
			if (%Player.GetOrgMemberLevel(1) < 6)//�Ƿ��ǰ���
			{
				%Txt1 = "��Ҫ�����ſ��Կ�������";
				SendOneScreenMessage(2,%Txt1,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %Txt1 @ "</t>",%Player);
				return YunLuoJing_DiaLog(%Npc,%Player,0,%Conv);
			}
			%Player.ShowDialogOk(2000000035,41,1);
			%Conv.SetType(4);
	}
}
function CreateMonsterForYunLuoJing(%Player)
{
	%CopyMapID = %Player.GetLayerID();
	if ($CopyMapBattleStateReocrd[%CopyMapID] > 0)
		return;
	$CopyMapBattleStateReocrd[%CopyMapID] = 1;
	//SptCopymap_Close( %CopyMapID );//�رո�����
	if (!isobject($CopyMapBattleStateReocrd[%CopyMapID,1]))
		$CopyMapBattleStateReocrd[%CopyMapID,1] = SpNewNpc2(0,413033001,$CopyMapPosRecord1316[0],%CopyMapID,180);
	if (!isobject($CopyMapBattleStateReocrd[%CopyMapID,2]))
		$CopyMapBattleStateReocrd[%CopyMapID,2] = SpNewNpc2(0,413033002,$CopyMapPosRecord1316[1],%CopyMapID,90);
	if (!isobject($CopyMapBattleStateReocrd[%CopyMapID,3]))
		$CopyMapBattleStateReocrd[%CopyMapID,3] = SpNewNpc2(0,413033003,$CopyMapPosRecord1316[2],%CopyMapID,270);
	if (!isobject($CopyMapBattleStateReocrd[%CopyMapID,4]))
		$CopyMapBattleStateReocrd[%CopyMapID,4] = SpNewNpc2(0,413033004,$CopyMapPosRecord1316[3],%CopyMapID,180);

	%Level = SptCopyMap_GetPlayerCorpsLvA(%CopyMapID);
	$CopyMapBattleStateReocrd[%CopyMapID,1].SetLevel(%Level);
	$CopyMapBattleStateReocrd[%CopyMapID,2].SetLevel(%Level);
	$CopyMapBattleStateReocrd[%CopyMapID,3].SetLevel(%Level);
	$CopyMapBattleStateReocrd[%CopyMapID,4].SetLevel(%Level);

	$CopyMapBattleStateReocrd[%CopyMapID,1].AddBuff(320800001,$CopyMapBattleStateReocrd[%CopyMapID,1],1);
	$CopyMapBattleStateReocrd[%CopyMapID,1].AddBuff(320810001,$CopyMapBattleStateReocrd[%CopyMapID,1],1);
	$CopyMapBattleStateReocrd[%CopyMapID,1].AddBuff(320820001,$CopyMapBattleStateReocrd[%CopyMapID,1],1);

	//echo("$CopyMapBattleStateReocrd[" @ %CopyMapID @ ", 1 ]====" @ $CopyMapBattleStateReocrd[%CopyMapID,1]);
	//echo("$CopyMapBattleStateReocrd[" @ %CopyMapID @ ", 2 ]====" @ $CopyMapBattleStateReocrd[%CopyMapID,2]);
	//echo("$CopyMapBattleStateReocrd[" @ %CopyMapID @ ", 3 ]====" @ $CopyMapBattleStateReocrd[%CopyMapID,3]);
	//echo("$CopyMapBattleStateReocrd[" @ %CopyMapID @ ", 4 ]====" @ $CopyMapBattleStateReocrd[%CopyMapID,4]);

	%text = "������" @ %Player.GetObjectName() @ "���ٻ����ˡ����޽�������";
	SendAllChatMessageLayer(0,$Get_Dialog_GeShi[31406]  @ %text @ "</t>",%CopyMapID);	//���͸�������Ϣ( ��Ļ���� )
	SendAllScreenMessageLayer(0,%text,%CopyMapID);	//���͸�������Ϣ( ��Ļ�м� )
}

function YunLuoJing_DiaLogB(%Npc,%Player,%State,%Conv)
{
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000107);
			%Conv.AddOption(600000108,600000108);
	}
}
//�������������޾������������� NPC�Ի�����������������


//�������������޾�������������������������������������
function NpcObjectonDeathcast_413033001(%Monster,%Killer){ NpcObjectonDeathcast_413033001_413033004(%Monster,%Killer,553000057,0); } //���޽���
function NpcObjectonDeathcast_413033002(%Monster,%Killer){ NpcObjectonDeathcast_413033001_413033004(%Monster,%Killer,553000058,32080); } //�����󻤷�
function NpcObjectonDeathcast_413033003(%Monster,%Killer){ NpcObjectonDeathcast_413033001_413033004(%Monster,%Killer,553000059,32081); } //�����һ���
function NpcObjectonDeathcast_413033004(%Monster,%Killer){ NpcObjectonDeathcast_413033001_413033004(%Monster,%Killer,553000060,32082); } //���޳���

function NpcObjectonDeathcast_413033001_413033004(%Monster,%Killer,%EventId,%Buff)
{
	%NpcId = %Monster.GetDataID();
	%CopyMapID = %Monster.GetLayerID();
	//echo( "�����޾�����������������������������" @ %NpcId  @ "     " @ %CopyMapID );

	%Obj = SpNewCj2(0,%EventId,%Monster.GetPosition(),%CopyMapID,0,"1 1 1");

	if (%Buff > 0)
	{
		if ($CopyMapBattleStateReocrd[%CopyMapID,1].GetBuffCount(%Buff,1) >= 1)
			$CopyMapBattleStateReocrd[%CopyMapID,1].Removebuff(%Buff*10000+1);
	}
	switch (%NpcId)
	{
		case 413033001:
			%TeammateList = SptCopyMap_GetAllPlayer(%CopyMapID);//��ȡ���������Ϣ
			%TeammateNum = SptCopyMap_GetPlayerCount(%CopyMapID);//��ȡ�����������
			for (%i = 0; %i < %TeammateNum; %i++)
			{
				%Player = Getword(%TeammateList, %i);
				if (%Player.GetOrgMemberLevel(1) == 6)
				{
					%Master = %Player;
					break;
				}
			}
			if (!isobject(%Master))
				%Master = %Killer;
			%Playername1 = GetPlayerZiTiName(%Master, 1);
			%Playername2 = GetPlayerZiTiName(%Master, 2);
			%NpcName1 = GetHuoDongName(GetNpcData(%NpcId, 1), 1);
			%NpcName2 = GetHuoDongName(GetNpcData(%NpcId, 1), 2);
			%MapName1 = GetMapName(%Master, 1);
			%MapName2 = GetMapName(%Master, 2);
			%ItemName1 = GetHuoDongName("���ޱ���", 1);
			%ItemName2 = GetHuoDongName("���ޱ���", 2);

			%Txt1 = %Playername1 @ "<t>���������</t>" @ %MapName1 @ "<t>��ս��ã�սʤ��</t>" @ %NpcName1 @ "<t>��</t>"@ %ItemName1 @ "<t>�������У�</t>";
			%Txt2 = %Playername2 @ "<t>���������</t>" @ %MapName2 @ "<t>��ս��ã�սʤ��</t>" @ %NpcName2 @ "<t>��</t>" @ %ItemName2 @ "<t>�������У�</t>";
			SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Txt1 @ "</t>");
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Txt2 @ "</t>", $chatMsg_Type_Normal2);
		case 413033004:
			//echo("%Monster.SuiCongNumber====="@ %Monster.SuiCongNumber);
			for (%i = 0; %i <= %Monster.SuiCongNumber; %i++)
			{
				%Obj = %Monster.SuiCong[%i];
				//echo("%Obj====="@ %Obj);
				if (isobject(%Obj))
					%Obj.SafeDeleteObject();
			}
				
	}
}
//�������������޾�������������������������������������

//�������������޾��������������ɼ����䴥��������������
function TriggerEvent_553000057(%Player,%Event,%EventID){ TriggerEvent_553000057_553000060(%Player,%Event,%EventID,191,500,20); }
function TriggerEvent_553000058(%Player,%Event,%EventID){ TriggerEvent_553000057_553000060(%Player,%Event,%EventID,192,100,10); }
function TriggerEvent_553000059(%Player,%Event,%EventID){ TriggerEvent_553000057_553000060(%Player,%Event,%EventID,193,100,10); }
function TriggerEvent_553000060(%Player,%Event,%EventID){ TriggerEvent_553000057_553000060(%Player,%Event,%EventID,194,200,10); }
function TriggerEvent_553000057_553000060(%Player,%Event,%EventID,%Src,%NumBer,%HuoYueSorce)
{
	SetSrc(%Player,%Src);
	AddFamily_HuoYue(%Player, %HuoYueSorce);
	HelpDirectByIndex(%Player.GetPlayerID(), 31);	//ͨѶ�ͻ���

	%Exp = $Monster_Exp[%Player.GetLevel(),1] * %NumBer;
	AllAddExp(%Player,%Exp);

	if (%EventID == 553000057)
		AddAchievementWatch(%Player,0,36,1);//��¼�ɾ�
	return true;

}
function TriggerEvent_553000061(%Player,%Event,%EventID)//�ڵ�
{
	%Event.SafedeleteObject();
	%CopyMapID = %Player.GetLayerID();
	$IsReomoveJieDianRecord[%CopyMapID]++;
	if ($IsReomoveJieDianRecord[%CopyMapID] < 6)
		return true;
	%BuffCount = $CopyMapBattleStateReocrd[%CopyMapID,1].GetBuffCount(32075,1);
	if (%BuffCount > 0)
	{
		$CopyMapBattleStateReocrd[%CopyMapID,1].RemoveBuff(320750001);
	}
	return true;
}
//�������������޾��������������ɼ����䴥��������������

//�������������޾�����������������ս������������������
function MonsterCombatEnd_413033001(%Npc)
{
	%CopyMapID = %Npc.GetLayerID();

	for (%i = 1;%i <= 6;%i++)
	{
		if (isobject($EventIDRecord[%CopyMapID,%i]))
			$EventIDRecord[%CopyMapID,%i].SafedeleteObject();
	}
	%BuffCount = $CopyMapBattleStateReocrd[%CopyMapID,1].GetBuffCount(32075,1);
	if (%BuffCount > 0)
	{
		$CopyMapBattleStateReocrd[%CopyMapID,1].RemoveBuff(320750001);
	}
}
function MonsterCombatEnd_413033004(%Npc)
{
	for (%i = 0; %i <= %Npc.SuiCongNumber; %i++)
	{
		%Obj = %Npc.SuiCong[%i];
		//echo("%Obj====="@ %Obj);
		if (isobject(%Obj))
			%Obj.SafeDeleteObject();
	}
	%Npc.SuiCongNumber = 0;
}
//�������������޾�����������������ս������������������
//320760001	쫷���	skill/320110002.png	�����˺�
//320770001	�ѵ����	skill/320110003.png	�˺�
//320780001	�ѵ����	skill/3153.png	ѣ��
//320790001	��ǽ��	skill/320120002.png	�����˺�