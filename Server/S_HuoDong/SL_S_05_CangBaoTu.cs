//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//�ر�ͼ
//=================================================================================
//�����������ر�ͼ������������ȫ�ֱ���������������������
//�����������ر�ͼ����������������������������������
//�����������ر�ͼ����������������ʹ�á�����������������
//�����������ر�ͼ���������������佱��������������������
//�����������ر�ͼ��������������������������������������



//�����������ر�ͼ������������ȫ�ֱ���������������������
$CangBaoTu_YaoWang_MaxNumBer[0] = 5;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[1] = 3;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[2] = 3;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[3] = 3;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[4] = 3;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[5] = 3;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[6] = 3;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[7] = 3;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[8] = 3;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[9] = 5;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[10] =5;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[11] =5;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[12] =5;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[13] =5;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[14] =5;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[15] =5;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[16] =5;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[17] =5;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[18] =15;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[19] =15;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[20] =15;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[21] =15;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[22] =15;	 //������׼��������
$CangBaoTu_YaoWang_MaxNumBer[23] =5;	 //������׼��������

$CangBaoTu_YaoWang_CreateCD[0] = 3;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[1] = 5;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[2] = 5;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[3] = 5;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[4] = 5;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[5] = 5;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[6] = 5;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[7] = 5;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[8] = 5;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[9] = 3;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[10]= 3;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[11]= 3;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[12]= 3;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[13]= 3;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[14]= 3;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[15]= 3;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[16]= 3;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[17]= 3;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[18]= 2;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[19]= 2;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[20]= 2;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[21]= 2;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[22]= 2;//ˢ��CD
$CangBaoTu_YaoWang_CreateCD[23]= 3;//ˢ��CD

//�����������ر�ͼ������������ȫ�ֱ���������������������

//�����������ر�ͼ����������������������������������

function Mission_Begin_Process_20148(%Npc,%Player,%Conv,%Param,%Mid)
{
	%Act4012[0] = GetAct(%Player,4012,0);
	%Act4012[1] = GetAct(%Player,4012,1);
	SetAct(%Player,4012,%Act4012[0]++,%Act4012[1]);

	%Player.ReduceMoney(6000,2,4,20148);
	%index = %Player.Putitem(108030001,1);
	%Player.additem(1,%Mid);

	%List = GetRandomPosForMap(0);
	%MapID = GetWord(%List,0);
	%PosID = GetWord(%List,1);
	SetAct(%Player,4013,%mapid,%posid);
	//%Conv.settext( 600000023 );
	%Player.SetMissionFlag(%Mid,3100,440000018);
	%Player.SetMissionFlag(%Mid,3200,1);
	%Player.SetMissionFlag(%Mid,3300,0);

	%Player.SetMissionFlag(%Mid,9000,1);
	%Player.SetMissionFlag(%Mid,9001,1);
	%Player.SetMissionFlag(%Mid,9002,1);

	%Player.UpdateMission(%Mid);
}
function Mission_End_Process_20148(%Npc,%Player,%Conv,%Param,%Mid)
{
	if ($SL_CangBaoTu_State_bActive == 1)
	{
		%ran =getrandom(1,100);
		if (%ran >= 50)
		{
			%player.putitem(113090002,1);
			%player.additem(1,%Mid);
		}
	}
}
//�����������ر�ͼ����������������������������������


//�����������ر�ͼ����������������ʹ�á�����������������
//108030001	������
function Trigger_108030001(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	%Act4013[0] = GetAct(%Player,4013,0);
	%Act4013[1] = GetAct(%Player,4013,1);
	%MapID = getzoneid();
	if (%state == 0)
	{
		if (%MapID != %Act4013[0])
			%dialogid = 600000023;
		else
		{
			%Pos_A = $strMapRanPosRecord[%Act4013[0],%Act4013[1]];
			%Pos_AX = GetWord(%Pos_A,0);
			%Pos_AY = GetWord(%Pos_A,1);
			%Pos_B = %player.getposition();
			%Pos_BX = GetWord(%Pos_B,0);
			%Pos_BY = GetWord(%Pos_B,1);
			if (msqrt(mpow(%Pos_AX - %Pos_BX,2)+mpow(%Pos_AY - %Pos_BY,2)) > 10)
				%dialogid = 600000023;
			else
				%dialogid = 0;
		}
		if (%dialogid > 0)
		{
			// ��ס��������ָ�������Ʒ��������ǳ���Ҫ
			%Conv.Reset();	//��������ѡ��
			%Conv.SetTriggerType(1);
			%Conv.SetTriggerMission(%Type);
			%Conv.SetType(1);
			%Conv.SetText(%dialogid);
			%Conv.Send(%Player);
		}
		else
		{
			%Player.putitem(%Type,-1);
			if (%player.additem(1,%type))
			{
				%Monster = SpNewNpc3(0,440000018,%Player.GetPosition(),0,0,"1 1 1");
				%Monster.SetLevel(%Player.GetLevel());//���ü������ȼ�
				%Monster.SetExclusivePlayerId(%Player.getplayerid());
				%Monster.SetExclusivePlayerName(%player.getobjectname());	//�������ö�ռ�ĳƺ�
				%Monster.BelongPlayer = %Player.GetPlayerID();
				%T = "�����Ѿ����֣��뾡�콫����ɱ��";
				SendOneChatMessage($chatMsg_System,%T,%Player); //��ҹ���
			}
		}
	}
}
//113090002	�ر�ͼ
function Trigger_113090001(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){Trigger_113090002(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ);}
function Trigger_113090002(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	//echo( "%XYZ===" @ %XYZ  @ "     %State===" @ %State);
	if ($SL_CangBaoTu_State_bActive != 1)
	{
		SendOneScreenMessage(2,"�ر�ͼ���ʱ�Ѿ��رգ��޷�ʹ��",%Player);
		return;
	}
	if (%Player.getlevel() < $SL_CangBaoTu_Level)
	{
		SendOneScreenMessage(2,"�ȼ�����" @ $SL_CangBaoTu_Level @ "�����޷������ر�ͼ",%Player);
		%Conv.settype(4);
		return -1;
	}
	%Conv.Reset();	//��������ѡ��
	%Conv.SetTriggerType(1);
	%Conv.SetTriggerMission(%Type);
	%Conv.SetType(1);

	if (%state == 0)
	{
		if (%Player.isHavePoint(%XYZ) == 0)
		{
			%List = GetRandomPosForMap(0);
			%MapID = GetWord(%List,0);
			%PosID = GetWord(%List,1);

			%Player.SetTreasurePos(%XYZ,8 @ %MapID @ "0100",%PosID,0);
			setact(%player,4014,%MapID,%PosID);
			%dialogid = 600000024;
		}
		else
		{
			%triggerid = %Player.GetPositionPoint(%XYZ,0);
			%PosID = %Player.GetPositionPoint(%XYZ,1);
			//echo( "%triggerid ===" @ %triggerid );
			//echo( "%PosID ===" @ %PosID );
			%TargetMapid = getsubstr(%triggerid,1,4);
			%nowmapid = getzoneid();
			setact(%player,4014,%TargetMapid,%PosID);
			//echo( getact( %player, 4014, 0 ) @ " " @  getact( %player, 4014, 1 ) );
			if (%TargetMapid  != %nowmapid)
				%dialogid = 600000024;
			else
			{
				%tarPosX = getword($strMapRanPosRecord[%TargetMapid,%PosID],0);
				%tarPosY = getword($strMapRanPosRecord[%TargetMapid,%PosID],1);
				%nowposX = getword(%player.getposition(),0);
				%nowposY = getword(%player.getposition(),1);
				if (msqrt(mpow(%tarPosX - %nowposX,2) + mpow(%tarPosY - %nowposY,2)) >= 10)
					%dialogid = 600000024;
				else
					%dialogid = 0;
			}
		}
		if (%dialogid > 0)
		{
			%Conv.SetText(%dialogid);
			%Conv.Send(%Player);
		}
		else
		{
			%conv.settype(4);
			%Act4012[0] = GetAct(%Player,4012,0);
			%Act4012[1] = GetAct(%Player,4012,1);
			//echo("VIP_getNowTequanLvMaxCnt(%Player, 8)=====" @ VIP_getNowTequanLvMaxCnt(%Player, 8));
			if (%Act4012[1] >= VIP_getNowTequanLvMaxCnt(%Player, 8))
			{
				%T = "�����յĿ�ͼ" @ VIP_getNowTequanLvMaxCnt(%Player, 8) @ "�Σ��Ѵﵽ���ޡ�";
				SendOneScreenMessage(2,%T,%Player);
				SendOneChatMessage($chatMsg_System,%T,%Player);
			}
			else
			{
				if (%Act4012[1] == 9)
					SetStrategyRecord(%Player,108);//���Դ�����¼

				SetAct(%player,4012,%Act4012[0],%Act4012[1]++);
				//%Player.putitem( %type, -1 );
				//if ( %player.additem( 1, %type ) )
				DelItemFromInventoryByIndex(%Player.GetPlayerID(),%XYZ,%Type,1,16,Type);
				Trigger_113090002_A(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ);
			}
			%Conv.SetType(4);
			%Conv.Send(%Player);
		}
	}
	//
}
function Trigger_113090002_A(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	%Pos = %player.getposition();
	%mapid = getzoneid();
	%Ran = getrandom(1,100);
	//��������	����	˵��
	//�տ���Ҳ	20%	˵��������û		������Ļ����	��ѽ���������ű�ͼΪ��Ʒ���˷�ʱ��������
	//����	10%	��Ѫ50% + 250*�ȼ�		ȫ����Ļ����	xxx��xxx�ط�Ѱ����ŭһ�����飬�ǵ�������������֮ŭ��
	//����	10%	ѣ��15S		ȫ����Ļ����	xxx��xxx�ط�Ѱ���ڳ������е�������Ū����ͷת�򣬺ò��Ǳ���
	//С��	55%	���佱��		ȫ����Ļ����	xxx����������xx���ڱ���ʰ��С������������xxx
	//����	5%	���佱��		ȫ����Ļ����+����	������⣿xxx��xx���ڱ�����������ħ��ӡ����������XX�����ķ������˷���ʿǰ��������
	%PlayerName = GetPlayerZiTiName(%Player,1);
	%PlayerName2 = GetPlayerZiTiName(%Player,2);
	%MapName = GetMapName(%Player,2);
	%Path = "<l i='" @ GetSubStr(%Player.Gettriggerid(),0,7) @ "00 " @ %Player.GetPosition() @ "' t='path'/>";

	if (%ran <= 20)
	{
		%T = "��ѽ���������ű�ͼΪ��Ʒ���˷�ʱ��������";
		SendOneScreenMessage(2,%T,%Player);
		SendOneChatMessage($chatMsg_System,%T,%Player);
	}
	else if (%ran <= 30)
	{
		%Msg2 = %Playername2 @ "<t>��</t>" @ %MapName  @ "<t>Ѱ����ŭһ�����飬�ǵ�������������֮ŭ��</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg2 @ "</t>", $chatMsg_Type_Normal2);
	}
	else if (%ran <= 40)
	{
		%Msg2 = %Playername2 @ "<t>��</t>" @ %MapName  @ "<t>Ѱ���ڳ������е�������Ū����ͷת�򣬺ò��Ǳ���</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg2 @ "</t>", $chatMsg_Type_Normal2);
	}
	else if (%ran <= 95)
	{
		%obj = SpNewCj2(%Player,553000002,0,%player.getlayerid(),0,"1 1 1");
		%Obj.masterplayer = %player.getplayerid();
		%Obj.masterplayername  = %player.getplayername();
		%Obj.setshapename("�����ı��䣨" @  %Obj.masterplayername  @ "��");

		%BaoxiangName  = $Get_Dialog_GeShi[31422] @ "�������ı��䡿</t>";
		%Msg2 = %Playername2 @ "<t>����������</t>" @ %MapName  @ "<t>�ڱ���ʰ��С������������</t>" @ %BaoxiangName;
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg2 @ "</t>", $chatMsg_Type_Normal2);
	}
	else
	{
		if ($CangBaoTu_YaoWang_NumBerNow < $CangBaoTu_YaoWang_MaxNumBer && $CangBaoTu_YaoWang_CreateCD <= 0)
		{
			switch (getrandom(1,3))
			{
				case 1:%text = GetPlayerZiTiName(%Player,1) @ "<t>��</t>" @ %Path @ "<t>�ڱ�ʱ��һ�������ƻ��˷�ӡ��һֻ�����Ʒ����,��ʿ�ǿ�ǰȥն����ħ��</t>";
				case 2:%text = GetPlayerZiTiName(%Player,1) @ "<t>���ڱ�ʱ��һͷײ�����������ϳ�����λ��ʿǰ��</t>" @ %Path @ "<t>����һ����</t>";
				case 3:%text = "<t>������⣿</t>" @ GetPlayerZiTiName(%Player,1) @ "<t>��</t>" @ %Path @ "<t>�ڱ�����������ħ��ӡ����������</t>" @ %Path @ "<t>�����ķ������˷���ʿǰ��������</t>";
			}
			//echo( "text===" @ %text );
			if (%text !$="")
				SendOneLineMessage($Get_Dialog_GeShi[31419] @ %text @ "</t>");


			%Teshu2 = $Get_Dialog_GeShi[60003] @ "��" @ GetNpcData(440000017,1) @ "��</t>"; //����� ��ɫ
			%Text2 = %Teshu2 @ "<t>������</t>" @ $Get_Dialog_GeShi[60002] @ %MapName @ "<t>��</t>";
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);


			%Opj = SpNewNpc3(0,440000017,%Pos,%player.getlayerid(),0,"1 1 1");
			%Opj.setlevel(%player.getlevel());
			$MonsterCount[%mapid,440000017]++;
			$CangBaoTu_YaoWang_NumBerNow++;

			$CangBaoTu_YaoWang_CreateCD = 1;
			%Time = GetLocalTime();
			%H = GetWord(%Time,3);	//Сʱ
			CanCel($ResultYaoWang_CeateCD);
			$ResultYaoWang_CeateCD = Schedule($CangBaoTu_YaoWang_CreateCD[%H] * 60 * 1000,0,"ResultYaoWang_CeateCD");
		}
		else
		{
			%T = "��ѽ���������ű�ͼΪ��Ʒ���˷�ʱ��������";
			SendOneScreenMessage(2,%T,%Player);
			SendOneChatMessage($chatMsg_System,%T,%Player);
		}
	}
}
//�����������ر�ͼ����������������ʹ�á�����������������


//�����������ر�ͼ���������������佱��������������������
function TriggerEvent_553000002(%Player,%Event,%EventID)
{
	//echo( "%Event=== " @ %Event );
	if (%Event.masterplayer != %player.getplayerid())
	{
		if (sptgetplayer(%Event.masterplayer).GetDamageState() $= "Enabled")
		{
			%T = "������ܱ������˲ſ��Կ�������";
			SendOneScreenMessage(2,%T,%Player);
			SendOneChatMessage($chatMsg_System,%T,%Player);
			return false;
		}
		%PlayerName = GetPlayerZiTiName(%Player,1);
		%Mastername = "<l i='" @ %Event.masterplayername @ " " @ %Event.masterplayer @ "' t='name' />";
		%Text = %Playername @ "<t>�����䣬����</t>" @ %Mastername @ "<t>��</t>" @ $Get_Dialog_GeShi[31422] @ "��������</t>" @ "<t>��</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");
		TriggerEvent_553000002_A(%player,1);
		%Event.safedeleteobject();
		return true;
	}
	else
	{
		TriggerEvent_553000002_A(%player,2);
		%Event.safedeleteobject();
		return true;
	}
}
function TriggerEvent_553000002_A(%player,%optype)
{
	//$SL_ZhuYao_item[ 1 ]  ="102106019;1;714;0";
	%GiveCount = 0;
	for (%i=1; %i<=99; %i++)
	{
		if ($SL_ZhuYao_item[%i] $= "")
			break;
		if (%GiveCount >= 2)
			break;

		%Ran = Getrandom(1,10000);
		%iran = getword($SL_ZhuYao_item[%i],2,";") * 1;
		if (%Ran <= %iran)
		{
			%itemid = getword($SL_ZhuYao_item[%i],0,";");
			%itemnum = getword($SL_ZhuYao_item[%i],1,";");
			%msg = getword($SL_ZhuYao_item[%i],3,";");

			if (%itemid > 0)
			{
				if (%itemid  == 105020503 || %itemid  == 105020553 || %itemid  == 109051001 || %itemid  == 109051011 || %itemid  == 109051021)
					%itemid = GetItemForPlayerLevel(%Player,%itemid);
				%player.putitem(%itemid,%itemnum);
				if (%player.additem(4,553000002))
				{
					%GiveCount++;
					if (%msg >= 1)
					{
						%ItemName = GetItemName(%ItemID,1);
						%ItemName2 = GetItemName(%ItemID,2);

						%PlayerName1 = GetPlayerZiTiName(%Player,1);
						%PlayerName2 = GetPlayerZiTiName(%Player,2);
						%HuoDongMingCheng1 = GetHuoDongName("��������",1);
						%HuoDongMingCheng2 = GetHuoDongName("��������",2);
						%MapName = GetMapName(%Player,2);
						%Path = "<l i='" @ GetSubStr(%Player.Gettriggerid(),0,7) @ "00 " @ %Player.GetPosition() @ "' t='path'/>";
						%Msgran = GetRanDom(1,4);
						//echo( "%Msgran===" @ %Msgran );
						switch (%Msgran)
						{
							case 1:
								%Text1 = "<t>���Ǹ��գ�</t>" @ %PlayerName1 @ "<t>��</t>" @ %Path @ "<t>���ھ�ر�ͼ��ϲ��</t>" @ %ItemName @ "<t>��</t>";
								%Text2 = "<t>���Ǹ��գ�</t>" @ %PlayerName2 @ "<t>��</t>" @ %MapName @ "<t>���ھ�ر�ͼ��ϲ��</t>" @ %ItemName2 @ "<t>��</t>";
							case 2:
								%Text1 = %PlayerName1 @ "<t>����������</t>" @ %Path @ "<t>���ڱ���ʰ��С������������</t>" @ %ItemName @ "<t>��</t>";
								%Text2 = %PlayerName2 @ "<t>����������</t>" @ %MapName @ "<t>���ڱ���ʰ��С������������</t>" @ %ItemName2 @ "<t>��</t>";
							case 3:
								%Text1 = %PlayerName1 @ "<t>���˲�ͣ����</t>" @ %Path @ "<t>���ڱ����ٵ���������</t>" @ %ItemName @ "<t>��</t>";
								%Text2 = %PlayerName2 @ "<t>���˲�ͣ����</t>" @ %MapName @ "<t>���ڱ����ٵ���������</t>" @ %ItemName2 @ "<t>��</t>";
							case 4:
								%Text1 = %PlayerName1 @ "<t>���������</t>" @ %Path @ "<t>�����������õ��������ػ��</t>" @ %ItemName @ "<t>��</t>";
								%Text2 = %PlayerName2 @ "<t>���������</t>" @ %MapName @ "<t>�����������õ��������ػ��</t>" @ %ItemName2 @ "<t>��</t>";
						}
						switch (%msg)
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
		}
	}
	if (%GiveCount == 0)
	{
		%Lucky = %Player.GetLuck();//��ȡ��Ҹ�Եֵ
		%Money = (50 + %Player.GetLevel()) *9;
		%Money = %Money + (10000 - %Money)*((%Lucky/2000)+ mfloor((%Lucky/100))/20);
		%Money = GetRanDom(%Money,10000);
		%Player.AddMoney(%Money,2,4,553000002);
	}
}
//�����������ر�ͼ���������������佱��������������������


//�����������ر�ͼ��������������������������������������
function NpcObjectonDeathcast_440000017(%Monster,%Player)
{
	%mapid = getzoneid();
	$MonsterCount[%mapid,440000017]--;


	%GiveCount = 0;
	for (%i=1; %i<=99; %i++)
	{
		if ($SL_ZhuYao_YaoWang[%i] $= "")
			break;
		if (%GiveCount >= 4)
			break;

		%Ran = Getrandom(1,10000);
		%iran = getword($SL_ZhuYao_YaoWang[%i],2,";") * 1;
		if (%Ran <= %iran)
		{
			%itemid = getword($SL_ZhuYao_YaoWang[%i],0,";");
			%itemnum = getword($SL_ZhuYao_YaoWang[%i],1,";");
			%msg = getword($SL_ZhuYao_YaoWang[%i],3,";");

			if (%itemid > 0)
			{
				if (%itemid  == 105020503 || %itemid  == 105020553 || %itemid  == 109051001 || %itemid  == 109051011 || %itemid  == 109051021)
					%itemid = GetItemForPlayerLevel(%Player,%itemid);
				%GiveCount++;
				SpNewDropItem(%Monster,%Player,%itemid,%itemnum,%msg);
			}
		}
	}
	%Lucky = %Player.GetLuck();//��ȡ��Ҹ�Եֵ
	%Money = (500 + %Player.GetLevel()) *10;
	%Money = %Money + (50000 - %Money)*((%Lucky/2000)+ mfloor((%Lucky/100))/20);
	%Money = GetRanDom(%Money,50000);
	//echo( "%Money===" @ %Money );
	SpNewDropItem(%Monster,%Player,105270001,%Money,0);
}
//�����������ر�ͼ��������������������������������������

//�����������ر�ͼ�����������������������ơ�������������
function ResultYaoWang_CeateCD()
{
	CanCel($ResultYaoWang_CeateCD);
	$CangBaoTu_YaoWang_CreateCD = 0;
}
function CaoBaoTu_YaoWangNumBer(%YY,%MM,%DD,%H,%M,%S)
{
	if ($SL_ZhuYao_State_bActive != 1)
		return;
	if (%M == 0 || $CangBaoTu_YaoWang_MaxNumBer == 0)
	{
		CanCel($ResultYaoWang_CeateCD);
		$CangBaoTu_YaoWang_NumBerNow = 0;
		$CangBaoTu_YaoWang_CreateCD = 0;
		%HuoYueRenShu = GetRenShuTongJiForEveryday(3);
		%HuoYueRenShu = GetWord(%HuoYueRenShu,0) + GetWord(%HuoYueRenShu,1) + GetWord(%HuoYueRenShu,2);//��Ծ����
		if (%HuoYueRenShu < 200)
			%HuoYueRenShu = 200;
		$CangBaoTu_YaoWang_MaxNumBer = mceil($CangBaoTu_YaoWang_MaxNumBer[%H] * (1 + (%HuoYueRenShu - 200)/500));
	}

}
//�����������ر�ͼ�����������������������ơ�������������

function GetItemForPlayerLevel(%Player,%itemid)
{
	switch (%itemid)
	{
		case 105020503://����ҩ
			%ItemID[1] = 105020503; %NeedLevel[1] = 30;	//����ҩ
			%ItemID[2] = 105020504; %NeedLevel[2] = 40;	//��ҩ
			%ItemID[3] = 105020505; %NeedLevel[3] = 50;	//��Ѫ��
			%ItemID[4] = 105020506; %NeedLevel[4] = 60;	//�󻹵�
			%ItemID[5] = 105020507; %NeedLevel[5] = 70;	//Ѫ�浤
			%ItemID[6] = 105020508; %NeedLevel[6] = 80;	//����������
			%ItemID[7] = 105020509; %NeedLevel[7] = 90;	//�廢������
			%ItemID[8] = 105020510; %NeedLevel[8] = 100;//�Ż�������
		case 105020553://����¶
			%ItemID[1] = 105020553; %NeedLevel[1] = 30;//����¶
			%ItemID[2] = 105020554; %NeedLevel[2] = 40;//����¶
			%ItemID[3] = 105020555; %NeedLevel[3] = 50;//����ɢ
			%ItemID[4] = 105020556; %NeedLevel[4] = 60;//����ɢ
			%ItemID[5] = 105020557; %NeedLevel[5] = 70;//��¶ɢ
			%ItemID[6] = 105020558; %NeedLevel[6] = 80;//��������ɢ
			%ItemID[7] = 105020559; %NeedLevel[7] = 90;//�����ۻ�ɢ
			%ItemID[8] = 105020560; %NeedLevel[8] = 100;//��������ɢ
		case 109051001://����ҩ��ҩ��
			%ItemID[1] = 109051001; %NeedLevel[1] = 40;//����ҩ��ҩ��
			%ItemID[2] = 109051002; %NeedLevel[2] = 50;//����Ѫ����ҩ��
			%ItemID[3] = 109051003; %NeedLevel[3] = 60;//���󻹵���ҩ��
			%ItemID[4] = 109051004; %NeedLevel[4] = 70;//��Ѫ�浤��ҩ��
			%ItemID[5] = 109051005; %NeedLevel[5] = 80;//��������������ҩ��
			%ItemID[6] = 109051006; %NeedLevel[6] = 90;//���廢��������ҩ��
			%ItemID[7] = 109051007; %NeedLevel[7] = 100;//���Ż���������ҩ��
		case 109051011://������¶��ҩ��
			%ItemID[1] = 109051011; %NeedLevel[1] = 40;//������¶��ҩ��		
			%ItemID[2] = 109051012; %NeedLevel[2] = 50;//������ɢ��ҩ��		
			%ItemID[3] = 109051013; %NeedLevel[3] = 60;//������ɢ��ҩ��		
			%ItemID[4] = 109051014; %NeedLevel[4] = 70;//����¶ɢ��ҩ��		
			%ItemID[5] = 109051015; %NeedLevel[5] = 80;//����������ɢ��ҩ��
			%ItemID[6] = 109051016; %NeedLevel[6] = 90;//�������ۻ�ɢ��ҩ��
			%ItemID[7] = 109051017; %NeedLevel[7] = 100;//����������ɢ��ҩ��
		case 109051021://�����������衷ҩ��
			%ItemID[1] = 109051021; %NeedLevel[1] = 50;//�����������衷ҩ��
			%ItemID[2] = 109051022; %NeedLevel[2] = 65;//��������¶�衷ҩ��
			%ItemID[3] = 109051023; %NeedLevel[3] = 80;//����ũ�ٲ��衷ҩ��
			%ItemID[4] = 109051024; %NeedLevel[4] = 95;//�����������衷ҩ��
	}
	%PlayerLevel = %Player.GetLevel();
	for (%i = 1; %i <=99; %i++)
	{
		if (%ItemID[%i] $= "" || %NeedLevel[%i] > %PlayerLevel)
		{
			%Record = %i - 1;
			break;
		}
	}
	if (%Record == 0)
		%EndItemID = %itemid;
	else
		%EndItemID = %ItemID[%Record];
	return %EndItemID;
}
/*
%ItemID[ 1 ] = 111; %NeedLevel[ 1 ] = 111;//
%ItemID[ 2 ] = 111; %NeedLevel[ 2 ] = 111;//
%ItemID[ 3 ] = 111; %NeedLevel[ 3 ] = 111;//
%ItemID[ 4 ] = 111; %NeedLevel[ 4 ] = 111;//
%ItemID[ 5 ] = 111; %NeedLevel[ 5 ] = 111;//
%ItemID[ 6 ] = 111; %NeedLevel[ 6 ] = 111;//
%ItemID[ 7 ] = 111; %NeedLevel[ 7 ] = 111;//
%ItemID[ 8 ] = 111; %NeedLevel[ 8 ] = 111;//
%ItemID[ 9 ] = 111; %NeedLevel[ 9 ] = 111;//
%ItemID[ 10 ]= 111; %NeedLevel[ 10 ]= 111;//
%ItemID[ 11 ]= 111; %NeedLevel[ 11 ]= 111;//
%ItemID[ 12 ]= 111; %NeedLevel[ 12 ]= 111;//
%ItemID[ 13 ]= 111; %NeedLevel[ 13 ]= 111;//
%ItemID[ 14 ]= 111; %NeedLevel[ 14 ]= 111;//
*/