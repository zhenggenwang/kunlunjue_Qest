

function UPCS_CopyMapFunction(%Num)
{
	if ((%Num == 1) || (%Num == 99)) { Exec("./SL_S_CopyMap_1301_ShiKongLieHeng.cs"); }
	if ((%Num == 2) || (%Num == 99)) { Exec("./SL_S_CopyMap_1302_LianMoYuan.cs"); }
	if ((%Num == 3) || (%Num == 99)) { Exec("./SL_S_CopyMap_1303_PengLaiJingDi.cs"); }
	if ((%Num == 4) || (%Num == 99)) { Exec("./SL_S_CopyMap_1304_HuanJingZhengBa.cs"); }
	if ((%Num == 5) || (%Num == 99)) { Exec("./SL_S_CopyMap_1305_XinMoHuanJing.cs"); }
	if ((%Num == 6) || (%Num == 99)) { Exec("./SL_S_CopyMap_1306_ZhuShenWenXinZhen.cs"); }
	if ((%Num == 7) || (%Num == 99)) { Exec("./SL_S_CopyMap_1307_YunXianJieDaTaoSha.cs"); }
	if ((%Num == 11) || (%Num == 99)) { Exec("./SL_S_CopyMap_1311_XueMoFengYinZhen.cs"); }
	if ((%Num == 12) || (%Num == 99)) { Exec("./SL_S_CopyMap_1312_HuangJingBaoZang.cs"); }
	if ((%Num == 13) || (%Num == 99)) { Exec("./SL_S_CopyMap_1313_DaoJianShenYu.cs"); }
	if ((%Num == 16) || (%Num == 99)) { Exec("./SL_S_CopyMap_1316_YunLuoJing.cs"); }
	if ((%Num == 17) || (%Num == 99)) { Exec("./SL_S_CopyMap_1317_YaoLingTianGong.cs"); }
	if ((%Num == 18)|| (%Num == 99)) { Exec("./SL_S_CopyMap_1318_FengShenMiJing.cs"); }
}
UPCS_CopyMapFunction(99);
//���������������������������ܡ����������������Ի����ܡ�������������������������������������
//���������������������������ܡ�������������������������������������������������������������
//���������������������������ܡ����������������رմ�������������������������������������

//���������������������������ܡ�������������ҽ��븱����������������������������������������
//���������������������������ܡ���������������뿪������������������������������������������
//���������������������������ܡ���������������뿪���鴥������������������������������������

//���������������������������ܡ�����������������Ϣ���ܡ�������������������������������������

//���������������������������ܡ������������ӳ����븱����ʾ���ѹ��ܡ�������������������������
//���������������������������ܡ���������������ʱ�뿪�������ܡ�������������������������������

//������������������������������������������븱�����꡿������������������������������������
//������������������������������������������븱��������������������������������������������
//���������������������������������������ͶƱ�߳�������������������������������������������
//�������������������������������������������������ӡ�������������������������������������

//��������������������ս�����ܡ���������������ʱ�䴥����������������������������������������
//��������������������ս�����ܡ�������������������������������������������������������������

//�����������������������ս�����������������븱�����꡿������������������������������������
//�����������������������ս�����������������븱���жϡ�������������������������������������
//�����������������������ս�����������������븱��������������������������������������������



//���������������������������ܡ����������������Ի����ܡ�������������������������������������
function NpcOnTrigger_CopyMap(%Npc,%Player,%State,%Conv,%Param)
{
	//������ڸ�������ֹͣ
	if (GetSubStr(GetZoneID(),1,1) != 3)
		return;
	%Npc =  %Npc;
	%Player =  %Player;
	%State =  %State;
	%Conv =  %Conv;
	%Param =  %Param;

	%CopyMapID = %Player.GetLayerId();
	%CopymapDataID = SptGetCopymapDataId(%CopyMapID);
	//��ȡNpc���
	%NpcID = %Npc.GetDataID();
	//echo( "%State====" @ %State );
	//�Ի�����
	%FuncName = "NpcOnTrigger_CopyMap_"@ %CopymapDataID @ "_" @ %NpcID;

	//echo( " %State ===" @  %State @ "   ����==" @ $SL_LianMoYuan_Boss_State[ %CopyMapID ] @ "  %Conv==" @ %Conv @ "  %Player==" @ %Player );
	//����isFunction
	//if ( isFunction( %FuncName ) )
	//	eval( %FuncName @ "(%Npc, %Player, %State, %Conv, %Param);" );
	//����isFunction
	if (isFunction(%FuncName))
		eval(%FuncName @ "("@%Npc@", "@%Player@", "@%State@", "@%Conv@", "@%Param@");");
}
//���������������������������ܡ����������������Ի����ܡ�������������������������������������

//���������������������������ܡ�������������������������������������������������������������
function SvrCopymapOpen(%CopyMapID,%MapID)
{
	//��ȡ����DataID
	%CopymapDataID = SptGetCopymapDataId(%CopyMapID);

	//��������������NPC
	%FuncName = "SvrCopymapOpen_" @ %CopymapDataID @ "_Trigger";

	if (isFunction(%FuncName))
		eval(%FuncName @ "(%CopyMapID, %CopymapDataID);");
	//ͳһ��ʽΪ,�磺
	//SvrCopymapOpen_1301_Trigger(%CopyMapID, %MapID);


	//��¼��������ʱ��
	for (%i=1; %i<100; %i++)
	{
		if ($JuQingRanking_MapID[%i] $= "")
			break;

		if (%CopymapDataID == $JuQingRanking_MapID[%i])
		{
			%Time = GetLocalTime();
			%H = GetWord(%Time, 3);	//Сʱ
			%M = GetWord(%Time, 4);	//����
			%S = GetWord(%Time, 5);	//��

			$JuQingRanking_Times[%CopyMapID] = %H * 3600 + %M * 60 + %S;
			break;
		}
	}
}
//���������������������������ܡ�������������������������������������������������������������

//���������������������������ܡ����������������رմ�������������������������������������
function CloseCopyMap(%CopyMapID)
{
	%CopymapDataID = SptGetCopymapDataId(%CopyMapID);
	switch (%CopymapDataID)
	{
		case 1301:
			CanCel($SptCopymap_1301_Combat[%CopyMapID]);
		case 1302:
			CanCel($SL_LianMoYuan_Schedule[%CopyMapID]);
	}
	SvrClearLayer(%CopyMapID);
}
//���������������������������ܡ����������������رմ�������������������������������������

//���������������������������ܡ�������������ҽ��븱����������������������������������������
function SptCopymap_OnEnter(%Player)
{
	//����Ҵ���
	if (!isobject(%Player))
		return;

	//������Ϣ��
	%PlayerID = %Player.GetPlayerID();
	%CopyMapID = %Player.GetLayerId();

	//��ȡ����DataID
	%CopymapDataID = SptGetCopymapDataId(%CopyMapID);

	//��¼��ʼ����ID
	if ($SptCopymap_BelongTeamID[%CopyMapID] $= "")
		$SptCopymap_BelongTeamID[%CopyMapID] = %Player.GetTeamId();

	//�����ض�����ʱ��BOSS��Ϣ����
	ChengJiuSys_OpenWnd(%Player,%CopyMapID);

	//��������������NPC
	%FuncName = "SptCopymap_OnEnter_"@ %CopymapDataID @ "_Trigger";

	if (isFunction(%FuncName))
		eval(%FuncName @ "(%CopyMapID, %Player);");

	//ͳһ��ʽΪ,�磺
	//SptCopymap_OnEnter_1301_Trigger(%CopyMapID, %Player);
}
//���������������������������ܡ�������������ҽ��븱����������������������������������������

//���������������������������ܡ�����������������Ϣ���ܡ�������������������������������������
function ChengJiuSys_OpenWnd(%Player,%CopyMapID)
{
	//���ܿ���
	if ($ChengJiuSys_Client_bActive < 1)
		return;

	%PlayerID = %Player.GetPlayerID();
	%CopymapDataID = SptGetCopymapDataId(%CopyMapID);
}
//���������������������������ܡ�����������������Ϣ���ܡ�������������������������������������


//���������������������������ܡ���������������뿪������������������������������������������
function SptCopymap_onLeave(%PlayerID)
{
	%Player = SptGetPlayer(%PlayerID);
	%CopyMapID = %Player.GetLayerId();

	//��ȡ����DataID
	%CopymapDataID = SptGetCopymapDataId(%CopyMapID);

	//����˴���
	BFCorps_DelPlayer(%PlayerID);	//�����뿪ս���Ŷ�

	//�뿪������ͼ����
	//switch(%CopymapDataID)
	//{
	//	case 1363: %Player.RemoveSchBuff(9001040);	//�����
	//}
}
//���������������������������ܡ���������������뿪������������������������������������������


//���������������������������ܡ���������������뿪���鴥������������������������������������
function SptCopymap_OnLeaveTeam(%Player)
{
	if (!isobject(%Player))
		return;

	//��ȡ������
	%CopyMapID = %Player.GetLayerId();

	//����Ƕ��˸���
	if (SptCopymap_GetPlayerCount(%CopyMapID) > 1)
	{
		//��ȡ����DataID
		%CopymapDataID = SptGetCopymapDataId(%CopyMapID);

		//����Ҫ�������ĸ���
		//switch(%CopymapDataID)
		//{
		//	case 1381:return; //�ƾ�
		//}

		%Msg = "������һ�������У����������ͳ�����";
		SendOneChatMessage($chatMsg_System,"<t>"@ %Msg @"</t>",%Player);
		Schedule(2000,0,"RemovePlayerOnLeaveTeam",%Player,%PlayerID,%CopyMapID,0);
	}
}

function RemovePlayerOnLeaveTeam(%Player,%PlayerID,%CopyMapID,%Step)
{
	%PlayerID = %Player.GetPlayerID();

	//����ڸ���
	if (GetSubStr(GetZoneID(),1,1) != 3)
		return;

	//��������
	if (SptCopymap_GetPlayerCount(%CopyMapID) <= 1)
		return;

	//����ID�Ƿ�Ϊ��ʼID
	if ($SptCopymap_BelongTeamID[%CopyMapID] == %Player.GetTeamId())
		return;

	switch (%Step)
	{
		case 0:%text = "������60����뿪������"; %Time = 30;
		case 1:%text = "������30����뿪������"; %Time = 20;
		case 2:%text = "������10����뿪������"; %Time = 5;
		case 3:%text = "������5����뿪������"; %Time = 1;
		case 4:%text = "������4����뿪������"; %Time = 1;
		case 5:%text = "������3����뿪������"; %Time = 1;
		case 6:%text = "������2����뿪������"; %Time = 1;
		case 7:%text = "������1����뿪������"; %Time = 1;

		default:
			SptCopymap_RemovePlayer(%PlayerID);
	}

	if (%text !$= "")
	{
		%Step++;
		SendOneChatMessage($chatMsg_System,%text,%Player);
	}

	if (%Time > 0)
		Schedule(%Time * 1000,0,"RemovePlayerOnLeaveTeam",%Player,%PlayerID,%CopyMapID,%Step);
}
//���������������������������ܡ���������������뿪���鴥������������������������������������

//���������������������������ܡ������������ӳ����븱����ʾ���ѹ��ܡ�������������������������
function CaptainEnter_CopyMap_Suggestive(%Player,%PlayerID,%CopyMapID)
{
	%MapDataID = SptGetCopymapDataId(%CopyMapID);
	if (SvrIsMyselfCaption(%PlayerID) > 0)
	{
		//switch(%MapDataID)
		//{
		//	case 1301:AllLineMessage_PlayerID_A(%PlayerID, %MapDataID, 2000000054, 80);	//������
		//	case 813140100:AllLineMessage_PlayerID_A(%PlayerID, 2000000054, %MapID);	//����
		//	case 813190100:AllLineMessage_PlayerID_A(%PlayerID, 2000000055, %MapID);	//����
		//	case 813140200:AllLineMessage_PlayerID_A(%PlayerID, 2000000056, %MapID);	//��߸
		//	case 813140300:AllLineMessage_PlayerID_A(%PlayerID, 2000000057, %MapID);	//����
		//	case 813060100:AllLineMessage_PlayerID_A(%PlayerID, 2000000058, %MapID);	//�Ź�
		//	case 813070100:AllLineMessage_PlayerID_A(%PlayerID, 2000000059, %MapID);	//������
		//	case 813090100:AllLineMessage_PlayerID_A(%PlayerID, 2000000060, %MapID);	//�϶�
		//	case 813110100:AllLineMessage_PlayerID_A(%PlayerID, 2000000061, %MapID);	//����
		//	case 813120100:AllLineMessage_PlayerID_A(%PlayerID, 2000000062, %MapID);	//�丸
		//	case 813300100:AllLineMessage_PlayerID_A(%PlayerID, 2000000063, %MapID);	//�����
		//}
	}
}
//���������������������������ܡ������������ӳ����븱����ʾ���ѹ��ܡ�������������������������


//���������������������������ܡ���������������ʱ�뿪�������ܡ�������������������������������
function RemoveCopyMapOnLeaveTeam(%CopyMapID,%Step)
{
	//����ڸ���
	if (GetSubStr(GetZoneID(),1,1) != 3)
		return;

	//����������Ϊ��ʱ����ͣ����ʱ
	%TeammateNum = SptCopyMap_GetPlayerCount(%CopyMapID);
	if (%TeammateNum == 0)
		return;

	switch (%Step)
	{
		case 0:%Text = "��������30���Ӻ�رգ�";	%Time = 600;
		case 1:%Text = "��������20���Ӻ�رգ�";	%Time = 600;
		case 2:%Text = "��������10���Ӻ�رգ�";	%Time = 300;
		case 3:%Text = "��������5���Ӻ�رգ�";	%Time = 60;
		case 4:%Text = "��������4���Ӻ�رգ�";	%Time = 60;
		case 5:%Text = "��������3���Ӻ�رգ�";	%Time = 60;
		case 6:%Text = "��������2���Ӻ�رգ�";	%Time = 60;
		case 7:%Text = "��������60���رգ�";		%Time = 30;
		case 8:%Text = "��������30���رգ�";		%Time = 10;
		case 9:%Text = "��������20���رգ�";		%Time = 10;
		case 10:%Text = "��������10���رգ�";		%Time = 5;
		case 11:%Text = "��������5���رգ�";		%Time = 1;
		case 12:%Text = "��������4���رգ�";		%Time = 1;
		case 13:%Text = "��������3���رգ�";		%Time = 1;
		case 14:%Text = "��������2���رգ�";		%Time = 1;
		case 15:%Text = "��������1���رգ�";		%Time = 1;
		default:
			%Time = 0;
	}

	if (%Time == 0)
	{
		%TeammateList = SptCopyMap_GetAllPlayer(%CopyMapID);
		%TeammateNum = SptCopyMap_GetPlayerCount(%CopyMapID);

		for (%i=0; %i< %TeammateNum; %i++)
		{
			//��ȡPlayer
			%Player = GetWord(%TeammateList,%i);
			//��ȡ����PlayerID
			%PlayerID = %Player.GetPlayerID();
			//�����뿪����
			SptCopymap_RemovePlayer(%PlayerID);
		}
		return;
	}

	if (%Time > 0)
	{
		SendAllChatMessageLayer($chatMsg_System,$Get_Dialog_GeShi[31419] @ %Text @"</t>",%CopyMapID);
		SendAllScreenMessageLayer(1,%Text,%CopyMapID);

		Schedule(%Time * 1000,0,"RemoveCopyMapOnLeaveTeam",%CopyMapID,%Step++);
	}
}
//���������������������������ܡ���������������ʱ�뿪�������ܡ�������������������������������

//��������������������ս�����ܡ���������������ʱ�䴥����������������������������������������
function sptOnCombatStarted(%DataID)
{
	//����������ʾ
	%FuncName = "CopyMap_TimeBegin_"@ %DataID;

	//����isFunction
	if (isFunction(%FuncName))
		eval(%FuncName @ "("@%DataID@");");
}
//��������������������ս�����ܡ���������������ʱ�䴥����������������������������������������

//��������������������ս�����ܡ�������������������������������������������������������������
function SptCheckCombatQueue(%MapID,%Player)
{
	//����������ʾ
	%FuncName = "CopyMap_CheckCombatQueue_"@ %MapID;

	//����isFunction
	if (isFunction(%FuncName))
		eval("return " @ %FuncName @ "("@%MapID@", "@%Player@");");
}
//��������������������ս�����ܡ�������������������������������������������������������������

//������������������������������������������븱�����꡿������������������������������������
$CopyMap_In[1311] = "B11";//�������߸�կ��
$CopyMap_In[1312] = "B12";//�����ι�֮ս��
$CopyMap_In[1313] = "B19";//�����յ�һվ��
$CopyMap_In[1328] = "B36";//���ʶ����¡�
//������������������������������������������븱�����꡿������������������������������������


//������������������������������������������븱��������������������������������������������
function TransportRandTeamPlayer(%Player,%MapID,%MapLevel)
{
	//��ȡ��������
	%Map_GoTo = $CopyMap_In[%MapID];

	if (%Map_GoTo $= "")
	{
		%Txt = "δ�ҵ�����������꣡�������-" @ %MapID @ ":" @ %MapLevel;

		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		return;
	}

	%Player.AddBuff(391080003,%Player);			//�����������buff
	%Player.RecordActivity(%MapID,5,0,0);	//��������־��¼
	//GoToNextMap(%Player, %Map_GoTo, 0, 0, 0);	//����
}
//������������������������������������������븱��������������������������������������������

//���������������������������������������ͶƱ�߳�������������������������������������������
function RandTeamPlayerKick(%Player)
{
	//�����뿪����
	SptCopymap_RemovePlayer(%Player.GetPlayerID());
}
//���������������������������������������ͶƱ�߳�������������������������������������������

//�������������������������������������������������ӡ�������������������������������������
function RandPlayerLeaveTeam(%Player)
{
	//�����뿪����
	SptCopymap_RemovePlayer(%Player.GetPlayerID());
}
//�������������������������������������������������ӡ�������������������������������������

//�����������������������ս�����������������븱�����꡿������������������������������������
$CopyMap_In[1338,1] = "B32";//����ս��ԭ����������24v24
$CopyMap_In[1338,2] = "B33";//����ս��ԭ����������24v24

$CopyMap_In[1339,1] = "B30";//����ս��ԭ����������6v6
$CopyMap_In[1339,2] = "B31";//����ս��ԭ����������6v6

$CopyMap_In[1379,1] = "B49";//��������1v1������1
$CopyMap_In[1379,2] = "B50";//��������1v1������2

$CopyMap_In[1369,1] = "B52";//��������̨������1
$CopyMap_In[1369,2] = "B53";//��������̨������2
//�����������������������ս�����������������븱�����꡿������������������������������������

//�����������������������ս�����������������븱���жϡ�������������������������������������
function TransporPlayerToArena_On(%Player)
{
	if ((%Player.IsSchBuff(20023016))||(%Player.IsSchBuff(20023017)))
	{
		SendOneScreenMessage(2,"�����ڷ����޷����д���",%Player);
		return 0;
	}
	if (%Player.isInMultiMount())
	{
		SendOneScreenMessage(2,"����������޷�ǰ���˵�ͼ",%Player);
		return 0;
	}

	return 1;
}
//�����������������������ս�����������������븱���жϡ�������������������������������������

//�����������������������ս�����������������븱��������������������������������������������
function TransporPlayerToArena(%Player,%CopyMapLv,%Lv,%MapID)
{
}
//�����������������������ս�����������������븱��������������������������������������������
