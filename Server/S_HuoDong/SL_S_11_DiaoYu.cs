//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//����
//==================================================================================
//�������������㡿����������ȫ�ֱ�����������������
//�������������㡿�����������������������������
//�������������㡿�����������ɼ�������������������
//�������������㡿�������������ִ�����������������
//�������������㡿����������NPC�Ի���������������

//�ʱ��	ÿ��18:50--19��10
//���ͼ	�������ִ��Բɳ̲
//���뷽ʽ	���㴹����֧��ͬʱ��������30-40��
//��ص���	���ȼ���͡����������С��СϺ�����ǣ������㣬������
//��ǰ�����ɿ��ƶ�ģʽ
//���ϸ	�����ɼ������̨30-40��
//�ɼ�����̨����
//���ĵ�����;öȡ��������
//30�����һ�ε���
//�����������ȼ������ʻ�ø�����
//
//�����¼�	����������Ϯ
//�����߹���һֻ���ͺ����������������ܵ��������Ʒ

//�������������㡿����������ȫ�ֱ�����������������
$SL_DiaoYuYuQunPos[1] = "-51.8028 -94.7527 105.697";
$SL_DiaoYuYuQunPos[2] = "-49.7597 -97.838 105.302";
$SL_DiaoYuYuQunPos[3] = "-51.6713 -99.1353 105.937";
$SL_DiaoYuYuQunPos[4] = "-48.7831 -102.168 105.491";
$SL_DiaoYuYuQunPos[5] = "-49.3591 -104.528 105.771";
$SL_DiaoYuYuQunPos[6] = "-48.5471 -107.268 105.786";
$SL_DiaoYuYuQunPos[7] = "-50.1443 -109.714 106.079";
$SL_DiaoYuYuQunPos[8] = "-48.3271 -110.708 105.902";
$SL_DiaoYuYuQunPos[9] = "-49.8016 -113.598 106.203";
$SL_DiaoYuYuQunPos[10] ="-50.6489 -116.333 106.289";
$SL_DiaoYuYuQunPos[11] ="-51.9447 -118.866 106.415";
$SL_DiaoYuYuQunPos[12] ="-52.1537 -121.539 106.471";
$SL_DiaoYuYuQunPos[13] ="-51.8055 -127.393 106.441";
$SL_DiaoYuYuQunPos[14] ="-51.5717 -132.562 106.471";
$SL_DiaoYuYuQunPos[15] ="-51.1732 -135.225 106.375";
$SL_DiaoYuYuQunPos[16] ="-51.1024 -140.922 106.182";
$SL_DiaoYuYuQunPos[17] ="-54.214 -147.565 105.919";
$SL_DiaoYuYuQunPos[18] ="-55.6213 -151.667 105.775";
$SL_DiaoYuYuQunPos[19] ="-60.316 -156.95 105.646";
$SL_DiaoYuYuQunPos[20] ="-64.2436 -158.729 105.514";
$SL_DiaoYuYuQunPos[21] ="-67.2399 -159.728 105.366";
$SL_DiaoYuYuQunPos[22] ="-70.1347 -160.722 105.35";
$SL_DiaoYuYuQunPos[23] ="-72.5982 -156.768 105.791";
$SL_DiaoYuYuQunPos[24] ="-76.1414 -160.444 105.572";
$SL_DiaoYuYuQunPos[25] ="-78.6148 -157.215 105.821";
$SL_DiaoYuYuQunPos[26] ="-79.7257 -159.749 105.693";
$SL_DiaoYuYuQunPos[27] ="-83.9059 -157.973 105.936";
$SL_DiaoYuYuQunPos[28] ="-86.2521 -158.686 106.007";
$SL_DiaoYuYuQunPos[29] ="-88.6648 -158.414 106.07";
$SL_DiaoYuYuQunPos[30] ="-94.2497 -159.75 106.133";
$SL_DiaoYuYuQunPos[31] ="-96.7108 -160.242 106.164";
$SL_DiaoYuYuQunPos[32] ="-99.2204 -161.715 106.146";
$SL_DiaoYuYuQunPos[33] ="-104.225 -162.748 106.136";
$SL_DiaoYuYuQunPos[34] ="-109.701 -162.667 106.255";

//�������������㡿����������ȫ�ֱ�����������������

//�������������㡿�����������������������������
function DiaoYuHuoDong_StytemMsg(%YY,%MM,%DD,%H,%M,%S)
{
	if (GetZoneID() != 1010)
		return;
	if ($SL_DiaoYu_bActive != 1)
		return;
	if (%H == 23 && %M == 59)
	{
		$CreateJiaoLongRecord = 0;
		$DiaoYuChengHaoRecordTwo = 0;
		$DiaoYuChengHaoRecordOne = 0;
	}
	%Nowtime = %H * 60 + %M;
	%Starttime = getword($SL_DiaoYu_StartTime,0,":") * 60 + getword($SL_DiaoYu_StartTime,1,":");
	%Endtime = getword($SL_DiaoYu_EndTime,0,":") * 60 + getword($SL_DiaoYu_EndTime,1,":");
	//%Path = GetTraceButton( "findpath(410010302);", GetNpcData( 410010302, 1 ) );//NPCѰ��
	%Path = "<l i='810100100 -121.087 -151.498 107.652' t='path'/>";

	%HuoDongMingCheng = GetHuoDongName("�����ɵ�",1);

	%ItemName1 = GetItemName(105109301,1);//�����ɵ�����ȯ
	%ItemName2 = GetItemName(106050307,1);//��������
	%ItemName3 = GetItemName(106050306,1);//������

	%Text = "";
	if (%Starttime -  %Nowtime  == 10)
	{
		%Text = %HuoDongMingCheng @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ "10</t><t>���Ӻ�����" @ $SL_DiaoYu_Level @ "��������ʿ��Я��</t>" @ %ItemName1 @ "<t>ǰ��</t>" @ %Path @ "<t>����������س���������ʿ�����潫�������</t>" @ %ItemName2 @ "<t>��</t>" @ %ItemName3 @ "<t>�������Ӧ���Ρ�ÿ�ս���һλ��һ������λ�ڶ�����</t>";
		%Text2 = GetHuoDongName("�����ɵ�",2) @ "<t>����</t>" @ $Get_Dialog_GeShi[60002]  @ "10</t><t>���Ӻ���</t>";
	}
	if (%Starttime -  %Nowtime  == 5)
	{
		%Text2 = GetHuoDongName("�����ɵ�",2) @ "<t>����</t>" @ $Get_Dialog_GeShi[60002]  @ "5</t><t>���Ӻ���</t>";
		%Text = %HuoDongMingCheng @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ "5</t><t>���Ӻ�����" @ $SL_DiaoYu_Level @ "��������ʿ��Я��</t>" @ %ItemName1 @ "<t>ǰ��</t>" @ %Path @ "<t>����������س���������ʿ�����潫�������</t>" @ %ItemName2 @ "<t>��</t>" @ %ItemName3 @ "<t>�������Ӧ���Ρ�ÿ�ս���һλ��һ������λ�ڶ�����</t>";
	}
	if (%Starttime -  %Nowtime  == 1)
	{
		%Text2 = GetHuoDongName("�����ɵ�",2) @ "<t>����</t>" @ $Get_Dialog_GeShi[60002]  @ "1</t><t>���Ӻ���</t>";
		%Text = %HuoDongMingCheng @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ "1</t><t>���Ӻ�����" @ $SL_DiaoYu_Level @ "��������ʿ��Я��</t>" @ %ItemName1 @ "<t>ǰ��</t>" @ %Path @ "<t>����������س���������ʿ�����潫�������</t>" @ %ItemName2 @ "<t>��</t>" @ %ItemName3 @ "<t>�������Ӧ���Ρ�ÿ�ս���һλ��һ������λ�ڶ�����</t>";
	}
	if (%Starttime -  %Nowtime  == 0)
	{
		CreateYuQun();
		%Text2 = GetHuoDongName("�����ɵ�",2) @ "<t>�Ѿ�������</t>";
		%Text = %HuoDongMingCheng @ "<t>�Ѿ�������" @ $SL_DiaoYu_Level @ "��������ʿ��Я��</t>" @ %ItemName1 @ "<t>ǰ��</t>" @ %Path @ "<t>����������س���������ʿ�����潫�������</t>" @ %ItemName2 @ "<t>��</t>" @ %ItemName3 @ "<t>�������Ӧ���Ρ�ÿ�ս���һλ��һ������λ�ڶ�����</t>";
	}
	if (%Endtime - %Nowtime == 10)
	{
		%Text2 = GetHuoDongName("�����ɵ�",2) @ "<t>����</t>" @ $Get_Dialog_GeShi[60002]  @ "10</t><t>���ӽ���</t>";
		%Text = %HuoDongMingCheng @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ "10</t><t>���ӽ�������ʿ��ץ��ʱ��Ŷ�����س���������ʿ�����潫�������</t>" @ %ItemName2 @ "<t>��</t>" @ %ItemName3 @ "<t>�������Ӧ���Ρ�ÿ�ս���һλ��һ������λ�ڶ�����</t>";
	}
	if ($CreateYuQunRecord <= 0 && $SL_DiaoYu_State_bActive == 1)
		CreateYuQun();
	if (%Text !$= "")
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");
	if (%Text2 !$= "")
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
}

//�������������㡿�����������������������������


//�������������㡿�����������ɼ�������������������
function TriggerEvent_551030101(%Player,%Event,%EventID)
{
	//echo( "������==========" @ %Event );
	if ($SL_DiaoYu_State_bActive != 1)
	{
		SendOneScreenMessage(2,"��Ѿ���������Ⱥ�Ѿ���ȥ",%Player);
		return;
	}
	if (%Player.getitemcount(105109302) < 1)
	{
		SendOneScreenMessage(2,"�������,����ʧ��",%Player);
		return;
	}
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"�����ո���",%Player);
		return;
	}
	%Player.Putitem(105109302,-1);
	if (%Player.Additem(1,%EventID))
	{
		%Event.Safedeleteobject();

		%Act0 = GetAct(%Player,4022,0);
		%Act1 = GetAct(%Player,4022,1);
		SetAct(%Player,4022,%Act0,%Act1++);

		%RanDom = getrandom(1,10000);
		//$SL_DiaoYu_Item[ 1 ] = "106050301;5480;1;0;0;"; //��ǹ��
		for (%i = 1; %i< 99; %i++)
		{
			if ($SL_DiaoYu_Item[%i] $= "")
				break;
			%ItemID = Getword($SL_DiaoYu_Item[%i],0);
			%Ran = Getword($SL_DiaoYu_Item[%i],1) + %Ran;
			%ItemCount = Getword($SL_DiaoYu_Item[%i],2);
			%Property = Getword($SL_DiaoYu_Item[%i],3);
			%Msg = Getword($SL_DiaoYu_Item[%i],4);
			//echo( "%ItemID===" @ %ItemID );
			//echo( "%Ran===" @ %Ran );
			//echo( "%ItemCount===" @ %ItemCount );
			//echo( "%Property===" @ %Property );
			//echo( "%Msg===" @ %Msg );
			if (%RanDom <= %Ran)
			{
				AddItem_BaoGuoNo_Mail(%Player,%ItemID,%ItemCount,%Property,"3 4022");
				if (%Msg >= 1)//����򹫸�
				{
					%ItemName   = "<l i='" @ %ItemID @ "' t='itemid'/>";
					%PlayerName = GetPlayerZiTiName(%Player,1);
					%HuoDongMingCheng = GetHuoDongName("�����ɵ�",1);
					%Text = %PlayerName @ "<t>�ڲμ�</t>" @ %HuoDongMingCheng @ "<t>ʱ������һ��</t>"@ %ItemName @ "<t>��������ɷ���ˣ�</t>";
					SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Text @ "</t>");
					if (%Msg == 2)//ȫ������
					{
						%Txt = GetPlayerZiTiName(%Player,2) @ "<t>�ڲμ�</t>" @ GetHuoDongName("�����ɵ�",2)  @ "<t>ʱ������һ��</t>" @ %ItemName @ $Get_Dialog_GeShi[60001] @ "<t>��������ɷ���ˣ�</t>";
						SendOneLineMessage(%Txt, $chatMsg_Type_Normal2);
					}
				}
				break;
			}
		}
		//---���� Ѳ��ҹ��--------
		%Ran = GetRandom(1,1000);
		if (%Ran <= 25)
		{
			%Pos = %Player.GetPosition();
			%NpcPos = GetNavPos(GetWord(%Pos,0),GetWord(%Pos,1),20);
			%MonSter = SpNewNpc2(0,410101018,%NpcPos,0,0);
			%MonSter.Addhate(%Player,100);
			SendAllChatMessage(0,"<t>Ѳ��ҹ�棺һȺ��С�������к��ҵ�ˮ�壬�ȱ��ᷢ�֣������ǲ��ã�</t>");//����������Ϣ
		}
	}
}
function TriggerEvent_553000053(%Player,%Event,%EventID){ return true; }
function TriggerEvent_553000054(%Player,%Event,%EventID){ return true; }
function TriggerEvent_553000055(%Player,%Event,%EventID){ return true; }
function TriggerEvent_553000056(%Player,%Event,%EventID){ return true; }
//�������������㡿�����������ɼ�������������������



//�������������㡿�������������ִ�����������������

function NpcObjectonDeathcast_410101018(%Monster,%Killer)//Ѳ��ҹ��
{
	SendAllChatMessage(10,"<t>Ѳ��ҹ�棺����ĪҪ���񣬴��������������ʾ�������ʰ���ȣ�</t>");//������Ϣ
	%Pos = %Monster.GetPosition();
	for (%i = 1; %i <=3; %i++)
	{
		%CjPos = GetNavPos(GetWord(%Pos,0),GetWord(%Pos,1),20);
		SpNewCj(0,553000053,%CjPos,GetRanDom(0,360),"1 1 1");
	}
	for (%i = 1; %i <=7; %i++)
	{
		%CjPos = GetNavPos(GetWord(%Pos,0),GetWord(%Pos,1),20);
		SpNewCj(0,553000054,%CjPos,GetRanDom(0,360),"1 1 1");
	}
	//---���� ����--------
	%Ran = GetRandom(1,1000);
	if (%Ran <= 25 && $CreateJiaoLongRecord != 1)
	{
		$CreateJiaoLongRecord = 1;
		%Pos = %Killer.GetPosition();
		%NpcPos = GetNavPos(GetWord(%Pos,0),GetWord(%Pos,1),20);
		%MonSter = SpNewNpc2(0,410101019,%NpcPos,0,0);
		%MonSter.Addhate(%Killer,100);
		SendAllChatMessage(0,"<t>����������ˮ�壬���Һ��򣬲������죡</t>");//����������Ϣ
	}
}
function NpcObjectonDeathcast_410101019(%Monster,%Killer)//����
{
	SendAllChatMessage(10,"<t>�����������������</t>");//������Ϣ
	%Pos = %Monster.GetPosition();
	for (%i = 1; %i <= 5; %i++)
	{
		%CjPos = GetNavPos(GetWord(%Pos,0),GetWord(%Pos,1),20);
		SpNewCj(0,553000055,%CjPos,GetRanDom(0,360),"1 1 1");
	}
	for (%i = 1; %i <= 5; %i++)
	{
		%CjPos = GetNavPos(GetWord(%Pos,0),GetWord(%Pos,1),20);
		SpNewCj(0,553000056,%CjPos,GetRanDom(0,360),"1 1 1");
	}
}
//�������������㡿�������������ִ�����������������


//�������������㡿����������NPC�Ի���������������
$SL_DiaoYuChengHaoXiangGuan[101] = "600000056 105109303 5";//�桤��Ϫ��ͯ
$SL_DiaoYuChengHaoXiangGuan[102] = "600000057 105109303 20";//�桤��Ϫ����
$SL_DiaoYuChengHaoXiangGuan[103] = "600000058 105109303 50";//�桤�������
$SL_DiaoYuChengHaoXiangGuan[104] = "600000059 105109303 80";//�桤�߽�����
$SL_DiaoYuChengHaoXiangGuan[105] = "600000060 105109303 100";//�桤��������
$SL_DiaoYuChengHaoXiangGuan[106] = "600000061 105109303 200";//�桤�ٽ�����
$SL_DiaoYuChengHaoXiangGuan[107] = "600000062 105109303 300";//�桤�ٽ���
$SL_DiaoYuChengHaoXiangGuan[108] = "600000063 105109303 500";//�桤������
$SL_DiaoYuChengHaoXiangGuan[109] = "600000064 105109303 800";//�桤��ʿ
$SL_DiaoYuChengHaoXiangGuan[110] = "600000065 105109303 1000";//�桤����

function DiaoYuHuoDong_DiaLogA(%Npc,%Player,%State,%Conv)//����һ����
{
	if (%Player.getlevel() < $SL_DiaoYu_Level)
		return;
	echo("�һ����===%State=" @ %State);
	%Time = GetLocalTime();
	%H = getword(%Time,3);
	%M = getword(%Time,4);
	switch (%state)
	{
		case 0:
			%Conv.AddOption(600000071,600000071);
			if (%Player.sptIsDesignationExist(101) == 0)
				%Conv.AddOption(GetWord($SL_DiaoYuChengHaoXiangGuan[101],0),GetWord($SL_DiaoYuChengHaoXiangGuan[101],0));
			else
			{
				for (%i = 110; %i>=102; %i--)
				{
					if (%Player.sptIsDesignationExist(%i) == 0 && %Player.sptIsDesignationExist(%i - 1) == 1)
						%Conv.AddOption(GetWord($SL_DiaoYuChengHaoXiangGuan[%i],0),GetWord($SL_DiaoYuChengHaoXiangGuan[%i],0));
				}
			}
		case 600000071:
			%Nowtime = %H * 60  + %M;
			%Starttime = getword($SL_DiaoYu_StartTime,0,":") * 60 + getword($SL_DiaoYu_StartTime,1,":");
			%Endtime = getword($SL_DiaoYu_EndTime,0,":") * 60 + getword($SL_DiaoYu_EndTime,1,":");
			//echo("Starttime====" @ %Starttime @ "Nowtime======" @ %Nowtime @ "Endtime====" @ %Endtime);
			if (%Starttime  >= %Nowtime + 10 || %Nowtime >= %Endtime)
			{
				//%Conv.Settype(4);
				SendOneScreenMessage(2,"���ڶһ�ʱ���ڣ��޷��һ�",%Player);
				SendOneChatMessage($chatMsg_System,"<t>���ڶһ�ʱ���ڣ��޷��һ�������һ������ڻ��ʼǰ10���ӿ��ţ������ʱ�رա�</t>",%Player);
				return DiaoYuHuoDong_DiaLogA(%Npc, %Player, 0, %Conv);
			}
			%Player.ShowDialogOk(2000000004,5,1);

		case 600000056:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000005, 6, 1);
		case 600000057:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000006, 7, 1);
		case 600000058:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000007, 8, 1);
		case 600000059:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000008, 9, 1);
		case 600000060:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000009, 10, 1);
		case 600000061:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000010, 11, 1);
		case 600000062:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000011, 12, 1);
		case 600000063:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000012, 13, 1);
		case 600000064:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000013, 14, 1);
		case 600000065:%Next = 1; %Conv.Settype(4); %Player.ShowDialogOk(2000000014, 15, 1);
	}
}
function DiaoYuChengHaoDuiHuan(%Player,%DesignationExist)
{
	//echo( " %DesignationExist=====" @ %DesignationExist );
	if (%Player.sptIsDesignationExist(%DesignationExist)  == 1)
		return;
	%ItemID = GetWord($SL_DiaoYuChengHaoXiangGuan[%DesignationExist],1);
	%ItemCount = GetWord($SL_DiaoYuChengHaoXiangGuan[%DesignationExist],2);
	//echo( " %DesignationExist=====" @ %DesignationExist );
	//echo( " %ItemID=====" @ %ItemID );
	//echo( " %ItemCount=====" @ %ItemCount );
	if (%Player.GetitemCount(%ItemID) < %ItemCount)
	{
		SendOneScreenMessage(2,"�һ����ϲ���",%Player);
		return;
	}
	%Player.Putitem(%ItemID,-%ItemCount);
	if (%Player.Additem(1,4022))
	{
		SendOneScreenMessage(2,"�һ��ɹ�",%Player);
		%Player.AddDesignation(%DesignationExist);//      	���һ���µĳƺ�
		%Player.SetCurDesignationIDZone(%DesignationExist);//	���ô˳ƺ�Ϊ��ǰ����ʹ�õĳƺ�
	}
}

function DiaoYuHuoDong_DiaLogA_A(%Player)
{
	//�����ɵ�����ȯ	105109301
	//	���	105109302
	if (%Player.getitemcount(105109301) < 1)
	{
		SendOneScreenMessage(2,"�һ�ʧ�ܣ�û���㹻�������ɵ�����ȯ",%Player);
		return;
	}
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"�����ո���",%Player);
		return;
	}
	%Act0 = GetAct(%Player,4022,0);
	%Act1 = GetAct(%Player,4022,1);
	if (%Act0 > 0)
	{
		SendOneScreenMessage(2,"ÿ��ֻ�ܶһ�һ�����",%Player);
		return;
	}
	%Player.putitem(105109301,-1);
	if (%Player.additem(1,105109301))
	{
		SetAct(%Player,4022,%Act0++,%Act1);
		%Player.putitem(105109302,10);
		%Player.Additem(1,105109301);
		AddAchievementWatch(%Player,0,42,1);//��¼�ɾ�
		SendOneScreenMessage(1,"�һ��ɹ�",%Player);
	}
}

function DiaoYuHuoDong_DiaLogB(%Npc,%Player,%State,%Conv)//����һ����� ������
{
	%Level = %Player.GetLevel();
	if (%Level < 40) %levelxishu = 1;
	else if (%Level < 50) %levelxishu = 1.2;
	else if (%Level < 60) %levelxishu = 1.6;
	else if (%Level < 70) %levelxishu = 2.0;
	else %levelxishu = 2.2;

	%ExpNumbers[106050301] = 80; //��ǹ��
	%ExpNumbers[106050302] = 160;//����
	%ExpNumbers[106050303] = 300;//����
	%ExpNumbers[106050306] = 500;//������
	%ExpNumbers[106050307] = 600;//��������
	%ExpNumbers[106050304] = 0;  //����
	%ExpNumbers[106050305] = 80; //����
	%ExpNumbers[105109303] = 0;  //�����ĵ�
	switch (%state)
	{
		case 0:
			if (%Player.Getitemcount(106050301) >= 1) %Conv.AddOption(600000066,600000066);//"�Ͻ�[��ǹ��]</t>";
			if (%Player.Getitemcount(106050302) >= 1) %Conv.AddOption(600000067,600000067);//"�Ͻ�[����]</t>";
			if (%Player.Getitemcount(106050303) >= 1) %Conv.AddOption(600000068,600000068);//"�Ͻ�[����]</t>";
			if (%Player.Getitemcount(106050306) >= 1) %Conv.AddOption(600000069,600000069);//"�Ͻ�[������]</t>";
			if (%Player.Getitemcount(106050307) >= 1) %Conv.AddOption(600000070,600000070);//"�Ͻ�[��������]</t>";
		case 600000066://"�Ͻ�[��ǹ��]</t>";
			%Count = %Player.GetItemcount(106050301);
			%Player.Putitem(106050301,-%Count);
			if (%Player.Additem(1,106050301))
			{
				%Exp = $Monster_Exp[%Level,1] * %ExpNumbers[106050301] * %levelxishu * %Count;
				AllAddExp(%Player,%Exp);
				SendOneScreenMessage(2,"�һ��ɹ������" @ %Exp @ "�㾭�齱��",%Player);
				SendOneChatMessage($chatMsg_System,"<t>�һ��ɹ������" @ %Exp @ "�㾭�齱��</t>",%Player);
			}

		case 600000067://"�Ͻ�[����]</t>";
			%Count = %Player.GetItemcount(106050302);
			%Player.Putitem(106050302,-%Count);
			if (%Player.Additem(1,106050302))
			{
				%Exp = $Monster_Exp[%Level,1] * %ExpNumbers[106050302] * %levelxishu * %Count;
				AllAddExp(%Player,%Exp);
				SendOneScreenMessage(2,"�һ��ɹ������" @ %Exp @ "�㾭�齱��",%Player);
				SendOneChatMessage($chatMsg_System,"<t>�һ��ɹ������" @ %Exp @ "�㾭�齱��</t>",%Player);
			}
		case 600000068://"�Ͻ�[����]</t>";
			%Count = %Player.GetItemcount(106050303);
			%Player.Putitem(106050303,-%Count);
			if (%Player.Additem(1,106050303))
			{
				%Exp = $Monster_Exp[%Level,1] * %ExpNumbers[106050303] * %levelxishu * %Count;
				AllAddExp(%Player,%Exp);
				SendOneScreenMessage(2,"�һ��ɹ������" @ %Exp @ "�㾭�齱��",%Player);
				SendOneChatMessage($chatMsg_System,"<t>�һ��ɹ������" @ %Exp @ "�㾭�齱��</t>",%Player);
			}
		case 600000069://"�Ͻ�[������]</t>";
			if ($DiaoYuChengHaoRecordTwo >= 5)
			{
				SendOneScreenMessage(2,"�������ˣ��Ϸ�����Ѿ�����㹻�ĳ�������",%Player);
				SendOneChatMessage($chatMsg_System,"<t>�������ˣ��Ϸ�����Ѿ�����㹻�ĳ�������,�����������ɡ�</t>",%Player);
			}
			else
			{
				%Player.Putitem(106050306,-1);
				if (%Player.Additem(1,106050306))
				{
					%Exp = $Monster_Exp[%Level,1] * %ExpNumbers[106050306] * %levelxishu * 1;
					AllAddExp(%Player,%Exp);
					SendOneScreenMessage(2,"�һ��ɹ������" @ %Exp @ "�㾭�齱��",%Player);
					SendOneChatMessage($chatMsg_System,"<t>�һ��ɹ������" @ %Exp @ "�㾭�齱��</t>",%Player);

					$DiaoYuChengHaoRecordTwo++;

					%PlayerName1 = GetPlayerZiTiName(%Player,1);
					%PlayerName2 = GetPlayerZiTiName(%Player,2);
					%ItemName1 = GetItemName(106050306,1);
					%ItemName2 = GetItemName(106050306,2);
					%HuoDongMingCheng1 = GetHuoDongName("�����ɵ�",1);
					%HuoDongMingCheng2 = GetHuoDongName("�����ɵ�",2);
					%NpcName1 = GetNpcZiTiName(410010202,1);
					%NpcName2 = GetNpcZiTiName(410010202,2);
					%Path = GetMapName(%Player,1);
					if ($DiaoYuChengHaoRecordTwo == 5)
						%Text1 = %PlayerName1 @ "<t>����</t>" @ %HuoDongMingCheng1 @ "<t>����</t>" @ %ItemName1 @ "<t>���Ͻɸ�������ʿ</t>" @ %NpcName1 @ %Path @ "<t>�ٻ�ڶ��������յڶ�������" @ 5 - $DiaoYuChengHaoRecordTwo @ "�����</t>";
					else
						%Text1 = %PlayerName1 @ "<t>����</t>" @ %HuoDongMingCheng1 @ "<t>����</t>" @ %ItemName1 @ "<t>���Ͻɸ�������ʿ</t>" @ %NpcName1 @ %Path @ "<t>�ٻ�ڶ��������յڶ���������ȫ��������ϣ�</t>";
					%Text2 = %PlayerName2 @ "<t>����</t>" @ %HuoDongMingCheng2 @ "<t>����</t>" @ %ItemName2 @ "<t>���Ͻɸ�������ʿ</t>" @ %NpcName2 @ "<t>�ٻ�ڶ�����</t>";
					SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
					SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);

					AddAchievementWatch(%Player, 0, 48, 1);//��¼�ɾ�
					if (!%Player.sptIsDesignationExist(202))
					{
						%Player.AddDesignation(202);//      	���һ���µĳƺ�
						%Player.SetCurDesignationIDZone(202);//	���ô˳ƺ�Ϊ��ǰ����ʹ�õĳƺ�
					}
				}
			}

		case 600000070://"�Ͻ�[��������]</t>";
			if ($DiaoYuChengHaoRecordOne == 1)
			{
				SendOneScreenMessage(2,"�������ˣ��Ϸ�����Ѿ���õ�����������",%Player);
				SendOneChatMessage($chatMsg_System,"<t>�������ˣ��Ϸ�����Ѿ���õ�����������,�����������ɡ�</t>",%Player);
			}
			else
			{
				%Player.Putitem(106050307,-1);
				if (%Player.Additem(1,106050307))
				{
					%Exp = $Monster_Exp[%Level,1] * %ExpNumbers[106050307] * %levelxishu * 1;
					AllAddExp(%Player,%Exp);
					SendOneScreenMessage(2,"�һ��ɹ������" @ %Exp @ "�㾭�齱��",%Player);
					SendOneChatMessage($chatMsg_System,"<t>�һ��ɹ������" @ %Exp @ "�㾭�齱��</t>",%Player);

					$DiaoYuChengHaoRecordOne = 1;

					%PlayerName1 = GetPlayerZiTiName(%Player,1);
					%PlayerName2 = GetPlayerZiTiName(%Player,2);
					%ItemName1 = GetItemName(106050307,1);
					%ItemName2 = GetItemName(106050307,2);
					%HuoDongMingCheng1 = GetHuoDongName("�����ɵ�",1);
					%HuoDongMingCheng2 = GetHuoDongName("�����ɵ�",2);
					%NpcName1 = GetNpcZiTiName(410010202,1);
					%NpcName2 = GetNpcZiTiName(410010202,2);
					%Path = GetMapName(%Player,1);
					%Text1 = %PlayerName1 @ "<t>����</t>" @ %HuoDongMingCheng1 @ "<t>����</t>" @ %ItemName1 @ %Path @ "<t>���Ͻɸ�������ʿ</t>" @ %NpcName1 @ "<t>����ý����ɵ�������һ����</t>";
					%Text2 = %PlayerName2 @ "<t>����</t>" @ %HuoDongMingCheng2 @ "<t>����</t>" @ %ItemName2 @ "<t>���Ͻɸ�������ʿ</t>" @ %NpcName2 @ "<t>����ý����ɵ�������һ����</t>";
					SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
					SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);

					AddAchievementWatch(%Player, 0, 47, 1);//��¼�ɾ�

					if (!%Player.sptIsDesignationExist(201))
					{
						%Player.AddDesignation(201);//      	���һ���µĳƺ�
						%Player.SetCurDesignationIDZone(201);//	���ô˳ƺ�Ϊ��ǰ����ʹ�õĳƺ�
					}
				}
			}
	}
	if (%State > 0)
		return DiaoYuHuoDong_DiaLogB(%Npc,%Player,0,%Conv);
}


function DiaoYuHuoDong_DiaLogC(%Npc,%Player,%State,%Conv)//����һ����� 	����
{

}
//�������������㡿����������NPC�Ի���������������

//�������������㡿����������ˢ����Ⱥ��������������
function CreateYuQun()
{
	if (GetZoneID() != 1010)
		return;
	deleteVariables("$CreateYuQunRecord");
	CanCel($CreateYuQunRecord);
	if ($SL_DiaoYu_State_bActive != 1)
	{
		for (%i = 1; %i<=15; %i++)
		{
			if (isobject($YuQunDuiXiangRecord[%i]))
				$YuQunDuiXiangRecord[%i].SafeDeleteObject();
		}
		return;
	}
	for (%i = 1; %i<=15; %i++)
	{
		%Ran = getrandom(1,34);
		%pos = $SL_DiaoYuYuQunPos[%Ran];
		//echo( %i @ "===============" @ isobject( $YuQunDuiXiangRecord[ %i ] ));
		if (!isobject($YuQunDuiXiangRecord[%i]))
		{
			//echo( "ˢ��" @ %i );
			$YuQunDuiXiangRecord[%i] = SpNewCj2(0,551030101,%Pos,0,0,"1 1 1");
		}
	}
	$CreateYuQunRecord = schedule(30*1000,0,"CreateYuQun");
}
//�������������㡿����������ˢ����Ⱥ��������������