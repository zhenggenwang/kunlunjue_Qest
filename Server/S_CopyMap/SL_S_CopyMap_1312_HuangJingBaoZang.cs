//===============================================SvrCopymapOpen_1308_Trigger( %CopyMapID, %CopymapDataID )===================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//�ƽ𱦲�
//==================================================================================
//�����������ƽ𱦲ء�����������ȫ�ֱ�������������������
//�����������ƽ𱦲ء�����������������������������������
//�����������ƽ𱦲ء��������������븱������������������
//�����������ƽ𱦲ء������������������򴥷�������������
//�����������ƽ𱦲ء�����������NPC�Ի��ű�������������
//�����������ƽ𱦲ء�����������������������������������
//�����������ƽ𱦲ء�����������ˢ�ֺ�������������������


//�����������ƽ𱦲ء�����������ȫ�ֱ�������������������
$CopyMap1312_EffectNameRecord[1] = 1; $CopyMap1312_EffectName[1] = "����"; $CopyMap1312_Effect[1] = 900147;/*����*/	$CopyMap1312_EffectPos[813060101] = "3.38564 91.6524 155.8";
$CopyMap1312_EffectNameRecord[2] = 2; $CopyMap1312_EffectName[2] = "����"; $CopyMap1312_Effect[2] = 900148;/*����*/	$CopyMap1312_EffectPos[813060102] = "14.5777 102.296 155.5";
$CopyMap1312_EffectNameRecord[3] = 3; $CopyMap1312_EffectName[3] = "��ȸ"; $CopyMap1312_Effect[3] = 900149;/*��ȸ*/	$CopyMap1312_EffectPos[813060103] = "-8.5722 102.291 155.5";
$CopyMap1312_EffectNameRecord[4] = 4; $CopyMap1312_EffectName[4] = "�׻�"; $CopyMap1312_Effect[4] = 900150;/*�׻�*/	$CopyMap1312_EffectPos[813060104] = "2.93578 113.608 155.9";
//�����������ƽ𱦲ء�����������ȫ�ֱ�������������������


//�����������ƽ𱦲ء�����������������������������������
function SvrCopymapOpen_1312_Trigger(%CopyMapID,%CopymapDataID)
{
	$copymappacketrecord[%CopyMapID] = GetRandomNum(4,1,4);
	$copymapdoorrecord[%CopyMapID] = GetRandomNum(4,1,4);
	//echo( "$copymappacketrecord[ %CopyMapID ]====" @ $copymappacketrecord[ %CopyMapID ] );
	//echo( "$copymapdoorrecord[ %CopyMapID ]====" @ $copymapdoorrecord[ %CopyMapID ] );
	$monsterrecord[%CopyMapID] = 0;
	for (%i = 0; %i < 4; %i++)
	{
		%Number = getword($copymappacketrecord[%CopyMapID],%i);
		$CopyMap1312_EffectRecord[%CopyMapID,813060100 + %i + 1,1] = $CopyMap1312_EffectNameRecord[%Number];
		$CopyMap1312_EffectRecord[%CopyMapID,813060100 + %i + 1,2] = addEffectPacket($CopyMap1312_Effect[%Number],0,$CopyMap1312_EffectPos[813060100 + %i + 1],"1 0 0 0",0,0,-1,%CopyMapID);
	}
}
//addEffectPacket( 900147, 0, getword( 263200.getposition( ), 0 ) @ " " @ getword( 263200.getposition( ), 1 )  @ " " @ getword( 263200.getposition( ), 2 ) + 3, "1 0 0 0", 0, 0, -1, 0 );
//addEffectPacket( 900148, 0, getword( 263200.getposition( ), 0 ) + 2 @ " " @ getword( 263200.getposition( ), 1 ) + 2 @ " " @ getword( 263200.getposition( ), 2 ) + 3, "1 0 0 0", 0, 0, -1, 0 );
//addEffectPacket( 900149, 0, getword( 263200.getposition( ), 0 ) + 4 @ " " @ getword( 263200.getposition( ), 1 ) + 4 @ " " @ getword( 263200.getposition( ), 2 ) + 3, "1 0 0 0", 0, 0, -1, 0 );
//addEffectPacket( 900150, 0, getword( 263200.getposition( ), 0 ) + 6 @ " " @ getword( 263200.getposition( ), 1 ) + 6 @ " " @ getword( 263200.getposition( ), 2 ) + 3, "1 0 0 0", 0, 0, -1, 0 );
//�����������ƽ𱦲ء�����������������������������������

//�����������ƽ𱦲ء��������������븱������������������
function SptCopymap_OnEnter_1312_Trigger(%CopyMapID,%Player)
{
	Cancel(%Player.Copymap1312);//���������ʱ
	%Player.Copymap1312 = Schedule(3000,0,"SptCopymap_OnEnter_1312_Trigger_A",%CopyMapID,%Player);
}
function SptCopymap_OnEnter_1312_Trigger_A(%CopyMapID,%Player)
{
	$Copymaplevel[%CopyMapID] = %Player.getlevel();
	%needdoor = getword($copymapdoorrecord[%CopyMapID],$monsterrecord[%CopyMapID]);
	%doorclor = getword($copymappacketrecord[%CopyMapID],%needdoor - 1);
	%Txt = "ǰ��" @ $CopyMap1312_EffectName[$CopyMap1312_EffectNameRecord[%doorclor]] @ "�����ţ�̤�����ţ����θ�����ʧ��)";
	SendOneScreenMessage(2,%Txt,%Player);
	SendOneChatMessage($chatMsg_System,%Txt,%Player);
	ServerOnSptAction(%Player.GetPlayerID(),%doorclor,18);//ͨѶ�ͻ���

	%Act0 = GetAct(%Player,4093,0);
	%Act0++;
	SetAct(%Player,4093,%Act0,0);
}
//�����������ƽ𱦲ء��������������븱������������������


//�����������ƽ𱦲ء�����������NPC�Ի��ű�������������
function HuangJinBaoZangDialog(%Npc,%Player,%State,%Conv)
{
	if ($SL_HuangJingBaoZang_State_bActive != 1)
		return;
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000098);
			%Conv.AddOption(600000099,600000099);
		case 600000099:
			%Conv.SetText(600000098);
			%Conv.AddOption(600000099,600000099);
			%Level = %Player.Getlevel();
			if (%Level < $SL_HuangJingBaoZang_Level)
			{
				%Txt = "�ȼ�����" @ $SL_HuangJingBaoZang_Level @ "�����޷���ս�ƽ𱦲�";
				SendOneScreenMessage(2,%Txt,%Player);
				SendOneChatMessage($chatMsg_System,%Txt,%Player);
				return;
			}
			if (%Player.GetItemCount(105109341) < 1)
			{
				%ItemName = GetItemData(105109341,1);
				%Txt = "����ʧ�ܣ����뱦����Ҫ��" @ %ItemName @ "��һö";
				SendOneScreenMessage(2,%Txt,%Player);
				SendOneChatMessage($chatMsg_System,%Txt,%Player);
				return;
			}
			if (SvrIsMyselfHasTeam(%Player.getPlayerID()))//�ж���
			{
				%Txt = "�˸���Ϊ������ս���������뿪������ٳ���";
				SendOneScreenMessage(2,%Txt,%Player);
				SendOneChatMessage($chatMsg_System,%Txt,%Player);
				return;
			}
			%Player.Putitem(105109341,-1);
			if (%Player.Additem(1,4093))
				GoToNextMap(%Player,1312,"");// "<t>���͡��ƽ𱦲ء�</t>";
	}
}
//�����������ƽ𱦲ء�����������NPC�Ի��ű�������������

//�����������ƽ𱦲ء������������������򴥷������������� 
function PlayerEnterTrigger_813060105(%Player,%TriggerId)
{
	%CopyMapID = %Player.GetLayerId();
	%CopymapDataID = SptGetCopymapDataId(%CopyMapID);
	if (%CopymapDataID == 1312)
	{
		if ($monsternumberrecord[%CopyMapID] <= 0 && %player.isschbuff(1003) != 1)
			NpcObjectonDeathcast_HuangJinBaoZang_A(0,%Player);
		else
		{
			%Txt = "��������������ſ��뿪��ǰ����";
			SendOneScreenMessage(2,%Txt,%Player);
			SendOneChatMessage($chatMsg_System,%Txt,%Player);
		}
		%Player.SetSchBuff(1003);		//����BUFF
	}
}

function PlayerEnterTrigger_813060101_813060104_A(%Player,%TriggerId)
{
	%CopyMapID = %Player.GetLayerId();
	if ($monsterrecord[%CopyMapID] > 3)
		return;
	if ($monsternumberrecord[%CopyMapID] > 0)
		return;
	//echo( "$copymapdoorrecord[ %CopyMapID ]===" @ $copymapdoorrecord[ %CopyMapID ] );
	//echo( "$monsterrecord[ %CopyMapID ]===" @ $monsterrecord[ %CopyMapID ] );
	if (%player.isschbuff(1003))
	{
		%Txt = "��ոմ�Խ���ޣ��Ժ��ٽ��д���";
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,%Txt,%Player);
		return;
	}
	%needdoor = getword($copymapdoorrecord[%CopyMapID],$monsterrecord[%CopyMapID]);
	%needdoor = 813060100 + %needdoor;
	//echo( "%TriggerId====" @ %TriggerId );
	//echo( "%needdoor====" @ %needdoor );
	%Player.TransportObject(0,0,0.421096,22.2225,139.775);
	if (%needdoor == %TriggerId)
	{
		Cancel(%Player.Copymap1312);//���������ʱ
		%Player.Copymap1312 = Schedule(2000,0,"sptcreatecopymapmonster",%CopyMapID,$monsterrecord[%CopyMapID]);
	}
	else
	{
		$monsterrecord[%CopyMapID] = 4;//��������
		%Txt = "�������һ������Ĵ����ţ�������֮������";
		Schedule(1000,0,"eval",%Player @ ".SetDamageState( Disabled ); ");
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,%Txt,%Player);
		Schedule(10000,0,"RemoveCopyMapOnLeaveTeam",%CopyMapID,3);

		for (%i = 1; %i <= 50; %i++)
		{
			addEffectPacket(900146,0,GetRanDom(-15,15) @ " " @ GetRanDom(-10,10) @ " 140.537","1 0 0 0",0,0,-1,%CopyMapID);
		}
	}
	%Player.SetSchBuff(1003);		//����BUFF
}
//�����������ƽ𱦲ء������������������򴥷�������������

//�����������ƽ𱦲ء�����������������������������������
function NpcObjectonDeathcast_413060001(%Monster,%Player)
{
	%Ran = GetRanDom(1,100);
	if (%Ran <= 50)
	{
		%Level = %Player.GetLevel();
		%Luck = %Player.getLuck();//��ȡ��Ҹ�Եֵ
		%MinMoney = (50 + %Level) * 3;
		%MaxMoney = (80 + %Level * 3) * 4;
		%MinMoney= %MinMoney + (%MaxMoney - %MinMoney)*((%Luck/20000) + (mfloor(%Luck /100))/20);
		%Money = GetRanDom(%MinMoney,%MaxMoney);
		SpNewDropItem(%Monster,%Player,105270001,%Money,0);
	}
	NpcObjectonDeathcast_HuangJinBaoZang(%Monster,%Player);
}
function NpcObjectonDeathcast_413060002(%Monster,%Player)
{
	%CopyMapID = %Player.GetLayerId();
	%Level = %Player.GetLevel();
	%ItemID[1] = 105105301; %ItemID[2] = 105105301; %ItemID[3] = 105105301; %ItemID[4] = 105105302; %ItemID[5] = 105105302; %ItemID[6] = 105105303;
	if (%Level < 60)
	{
		%ItemRan[1] = 100; %ItemRan[2] = 0; %ItemRan[3] = 0; %ItemRan[4] = 10; %ItemRan[5] = 0; %ItemRan[6] = 3;
	}
	else if (%Level < 80)
	{
		%ItemRan[1] = 100; %ItemRan[2] = 50; %ItemRan[3] = 0; %ItemRan[4] = 15; %ItemRan[5] = 5; %ItemRan[6] = 3;
	}
	else
	{
		%ItemRan[1] = 100; %ItemRan[2] = 50; %ItemRan[3] = 10; %ItemRan[4] = 15; %ItemRan[5] = 5; %ItemRan[6] = 3;
	}
	for (%i = 1; %i <=6; %i++)
	{
		%Ran = GetRanDom(1,100);
		//echo(%ran @ "    " @ %ItemRan[%i]);
		if (%Ran <= %ItemRan[%i])
		{
			%istrue = %Monster.DropItemAddToMap(%Player.GetPlayerID(),%ItemID[%i],1);
			if (%istrue)
			{
				%ItemName2 = GetItemName(%ItemID[%i],2);
				%PlayerName2 = GetPlayerZiTiName(%Player,2);
				%HuoDongMingCheng2 = GetHuoDongName("�ƽ𱦲�",2);
				%Msgtype = GetRanDom(1,2);
				switch (%Msgtype)
				{
					case 1:%Text2 = %PlayerName2 @ "<t>��ս</t>" @ %HuoDongMingCheng2 @ "<t>���</t>" @ %ItemName2 @ "<t>�����ǲ�Դ�����</t>";
					case 2:%Text2 = "<t>���Ǹ��գ�</t>" @ %PlayerName2 @ "<t>�ɹ���ս</t>" @ %HuoDongMingCheng2 @ "<t>ͨ�ػ��</t>" @ %ItemName2 @ "<t>�ʹ�����ң�</t>";
				}
				SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
			}
		}
	}

	SetStrategyRecord(%Player,$StrategySubBtnSrc[2,4]);//���Դ�����¼	
	%Txt = "��ս�ɹ���";
	SendOneScreenMessage(2,%Txt,%Player);
	SendOneChatMessage($chatMsg_System,%Txt,%Player);
	Schedule(10000,0,"RemoveCopyMapOnLeaveTeam",%CopyMapID,3);
	AddAchievementWatch(%Player,0,35,1);//��¼�ɾ�
}
function NpcObjectonDeathcast_HuangJinBaoZang(%Monster,%Player)
{
	%CopyMapID = %Player.GetLayerId();
	$monsternumberrecord[%CopyMapID]--;
	//echo( "ʣ���������====" @ $monsternumberrecord[ %CopyMapID ] );
	if ($monsternumberrecord[%CopyMapID] <= 0)
	{
		%Act0 = GetAct(%Player,4093,0);
		%Act1 = $monsterrecord[%CopyMapID] + 1;
		SetAct(%Player,4093,%Act0,%Act1);

		$monsterrecord[%CopyMapID]++;
		if ($monsterrecord[%CopyMapID] <= 3)
		{
			%Txt = "��ǰ�ؿ���ս�ɹ�������30����ͨ���������뿪";
			CanCel($NextDoorForHuangJinBaoZang[%CopyMapID]);
			$NextDoorForHuangJinBaoZang[%CopyMapID] = Schedule(30000,0,"NpcObjectonDeathcast_HuangJinBaoZang_A",%Monster,%Player);
		}
		else
		{
			%Pos = GetNavPos(1,1,20);
			if (%Pos $= "" || %Pos $= "0 0 0")
				%Pos = "1 1 141";
			%obj = SpNewNpc2(0,413060002,%Pos,%CopyMapID,getrandom(0,360));
			%obj.setlevel($Copymaplevel[%CopyMapID]);
		}
		if (%Txt !$= "")
		{
			SendOneScreenMessage(2,%Txt,%Player);
			SendOneChatMessage($chatMsg_System,%Txt,%Player);
		}
	}
}
function NpcObjectonDeathcast_HuangJinBaoZang_A(%Monster,%Player)
{

	%Player.TransportObject(0,0,3.07835,102.019,155.892);

	%CopyMapID = %Player.GetLayerId();
	CanCel($NextDoorForHuangJinBaoZang[%CopyMapID]);
	if ($monsterrecord[%CopyMapID] <= 3)
	{
		%needdoor = getword($copymapdoorrecord[%CopyMapID],$monsterrecord[%CopyMapID]);
		%doorclor = getword($copymappacketrecord[%CopyMapID],%needdoor - 1);
		%Txt = "ǰ��" @ $CopyMap1312_EffectName[$CopyMap1312_EffectNameRecord[%doorclor]] @ "�����ţ�̤�����ţ����θ�����ʧ��)";
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,%Txt,%Player);
		ServerOnSptAction(%Player.GetPlayerID(),%doorclor,18);//ͨѶ�ͻ���
	}
}
//�����������ƽ𱦲ء�����������������������������������

//�����������ƽ𱦲ء�����������ˢ�ֺ�������������������
function sptcreatecopymapmonster(%CopyMapID,%Optype)
{
	if (%Optype <= 2)
		%iMax = 20;
	else
		%iMax = 19;
	for (%i = 1; %i <= %iMax; %i++)
	{
		%Pos = GetNavPos(1,1,20);
		if (%Pos $= "" || %Pos $= "0 0 0")
			%Pos = "1 1 141";
		//%Pos = GetRanDom( -10, 10 ) @ " " @  GetRanDom( -10, 10 ) @ " 140.537";
		%obj = SpNewNpc2(0,413060001,%Pos,%CopyMapID,getrandom(0,360));
		%obj.setlevel($Copymaplevel[%CopyMapID]);
	}
	$monsternumberrecord[%CopyMapID] = %imax;
}
//�����������ƽ𱦲ء�����������ˢ�ֺ�������������������