//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//�ڿ�
//==================================================================================

//SpNewCj2( 0, 551010101, "10.1963 79.4818 126.428", 0, 180, "1 1 1" );
//107020001	���ʿ��	����
//107020002	���ʿ��	����
//107020003	�������	����
//107020101	�����	����
//107020201	������	����
//105109101	�����������
//105109102	�����������
//105109103	�����������
//105109111	������������
//105109112	������������
//105109113	������������
//105105300	��Ҷ��
//105105301	��Ҷ��
//105105302	��
//105105303	����
//105105304	��ש
//105105305	��ʯ

//�����������ڿ󡿡�����������ʯ������������������������
//�����������ڿ󡿡�����������ʯ������������������������
//�����������ڿ󡿡����������ӿ���㺯������������������
//�����������ڿ󡿡�������������޸���������������������
//�����������ڿ󡿡����������龧��ʯʹ�á���������������
//�����������ڿ󡿡����������������������������������
//�����������ڿ󡿡��������������̵�չʾ����������������

//�����������ڿ󡿡�����������ʯ������������������������
function TriggerEvent_551011501(%Player,%Event,%EventID){ TriggerEvent_551011501_551011502(%Player,%Event,%EventID); }//��ʯ����
function TriggerEvent_551011502(%Player,%Event,%EventID){ TriggerEvent_551011501_551011502(%Player,%Event,%EventID); }//��ʯ����
function TriggerEvent_551011501_551011502(%Player,%Event,%EventID)
{
	%ItemID = %Player.GetEquip(13);
	%Playername = %Player.GetObjectname();
	%Ran = GetRandom(1,10000);
	//echo( "%Ran ===" @ %Ran );
	if (%Ran <= 3000){ %ItemID = 105109001; %ItemNum = 1; %MsgType = 0; }
	else if (%Ran <= 3300){ %ItemID = 105109001; %ItemNum = 2; %MsgType = 2; }
	else if (%Ran <= 3420){ %ItemID = 105109001; %ItemNum = 5; %MsgType = 2; }
	else if (%Ran <= 3470){ %ItemID = 105109001; %ItemNum = 8; %MsgType = 2; }
	else if (%Ran <= 3500){ %ItemID = 105109001; %ItemNum = 10; %MsgType = 2; }
	else if (%Ran <= 3515){ %ItemID = 105109001; %ItemNum = 20; %MsgType = 2; }
	else if (%Ran <= 3521){ %ItemID = 105109001; %ItemNum = 50; %MsgType = 2; }
	else if (%Ran <= 3524){ %ItemID = 105109001; %ItemNum = 100; %MsgType = 2; }
	else if (%Ran <= 4524){ %ItemID = 0; %ItemNum = 0; %MsgType = 0; }
	else if (%Ran <= 5524){ %ItemID = 0; %ItemNum = 0; %MsgType = 0; }
	else if (%Ran <= 6524){ %ItemID = 105105300; %ItemNum = 1; %MsgType = 0; }
	else if (%Ran <= 8000){ %ItemID = 105105301; %ItemNum = 1; %MsgType = 0; }
	else if (%Ran <= 10000){ %ItemID = 0; %ItemNum = 0; %MsgType = 0; GetSpecialjade(%Player,1,4,%EventID); }

	%Kuang = GetOne_HeZuiChu_ZaKuang(%Player,1);
	%Player.PutItem(%Kuang,1);
	if (%ItemID > 0 && %ItemNum > 0)
		%Player.Putitem(%ItemID,%ItemNum);
	%Player.Additem(4,%EventID);

	if (%MsgType == 1 )
	{
		%Msg ="�����콵����ϲ����" @ %ItemNum  @ "ö" @ GetItemData(%ItemID,1);
		SendOneScreenMessage(2,%Msg,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Msg @ "</t>",%Player);
	}
	if (%MsgType == 2)
	{
		%ItemName = GetItemName(%ItemID,1);
		%ItemName2 = GetItemName(%ItemID,2);

		//%Msg1 ="�����콵����ϲ����" @ %ItemNum  @ "ö" @ GetItemData( %ItemID, 1 );
		%Playername2 = GetPlayerZiTiName(%Player,1);
		%Playername3= GetPlayerZiTiName(%Player,2);
		%Msg2 ="<t>�콵����</t>" @ %Playername2 @ "<t>���ھ�������������</t>" @ $Get_Dialog_GeShi[31420] @ %ItemNum  @ "</t><t>ö</t>" @ %ItemName;
		%Msg3 ="<t>�콵����</t>" @ %Playername3 @ "<t>���ھ�������������</t>" @ %ItemNum  @ "<t>ö</t>" @ %ItemName2;
		//SendOneScreenMessage( 2, %Msg1, %Player );
		SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Msg2 @ "</t>");
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg3 @ "</t>", $chatMsg_Type_Normal2);
	}
}
//�����������ڿ󡿡�����������ʯ������������������������


//�����������ڿ󡿡�����������ʯ������������������������
function TriggerEvent_551011511(%Player,%Event,%EventID){ TriggerEvent_551011511_551011512(%Player,%Event,%EventID); }//��ʯ����
function TriggerEvent_551011512(%Player,%Event,%EventID){ TriggerEvent_551011511_551011512(%Player,%Event,%EventID); }//��ʯ����
function TriggerEvent_551011511_551011512(%Player,%Event,%EventID)
{
	%ItemID = %Player.GetEquip(13);
	%PlayerName = GetPlayerZiTiName(%Player,1);
	%PlayerName2 = GetPlayerZiTiName(%Player,2);
	%Ran = GetRandom(1,10000);
	//echo( "%Ran ===" @ %Ran );
	if (%Ran <= 3000){ %ItemID = 105109021; %ItemNum = 1; %MsgType = 0; }
	else if (%Ran <= 3300){ %ItemID = 105109021; %ItemNum = 2; %MsgType = 2; }
	else if (%Ran <= 3420){ %ItemID = 105109021; %ItemNum = 5; %MsgType = 2; }
	else if (%Ran <= 3470){ %ItemID = 105109021; %ItemNum = 8; %MsgType = 2; }
	else if (%Ran <= 3500){ %ItemID = 105109021; %ItemNum = 10; %MsgType = 2; }
	else if (%Ran <= 3515){ %ItemID = 105109021; %ItemNum = 20; %MsgType = 2; }
	else if (%Ran <= 3521){ %ItemID = 105109021; %ItemNum = 50; %MsgType = 2; }
	else if (%Ran <= 3524){ %ItemID = 105109021; %ItemNum = 100; %MsgType = 2; }
	else if (%Ran <= 4524){ %ItemID = 0; %ItemNum = 0; %MsgType = 0; }
	else if (%Ran <= 5524){ %ItemID = 0; %ItemNum = 0; %MsgType = 0; }
	else if (%Ran <= 6524){ %ItemID = 105105300; %ItemNum = 1; %MsgType = 0; }
	else if (%Ran <= 8000){ %ItemID = 105105301; %ItemNum = 1; %MsgType = 0; }
	else if (%Ran <= 10000){ %ItemID = 0; %ItemNum = 0; %MsgType = 0;GetSpecialjade(%Player,10,4,%EventID); }

	%Kuang = GetOne_HeZuiChu_KuangDing(%Player,1);
	%Player.PutItem(%Kuang,1);
	if (%ItemID > 0 && %ItemNum > 0)
		%Player.Putitem(%ItemID,%ItemNum);
	%Player.Additem(4,%EventID);

	if (%MsgType == 1)
	{
		%Msg ="�����콵����ϲ����" @ %ItemNum  @ "ö" @ GetItemData(%ItemID,1);
		SendOneScreenMessage(1,%Msg,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Msg @ "</t>",%Player);
	}
	if (%MsgType == 2)
	{
		%ItemName = GetItemName(%ItemID,1);
		%ItemName2 = GetItemName(%ItemID,2);

		//%Msg1 ="�����콵����ϲ����" @ %ItemNum  @ "ö" @ GetItemData( %ItemID, 1 );
		%Playername2 = GetPlayerZiTiName(%Player,1);
		%Playername3= GetPlayerZiTiName(%Player,2);
		%Msg2 ="<t>�콵����</t>" @ %Playername2 @ "<t>���ھ�������������</t>" @ $Get_Dialog_GeShi[31420] @ %ItemNum  @ "</t><t>ö</t>" @ %ItemName;
		%Msg3 ="<t>�콵����</t>" @ %Playername3 @ "<t>���ھ�������������</t>" @ %ItemNum  @ "<t>ö</t>" @ %ItemName2;
		//SendOneScreenMessage( 2, %Msg1, %Player );
		SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Msg2 @ "</t>");
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg3 @ "</t>", $chatMsg_Type_Normal2);
	}
}
//�����������ڿ󡿡�����������ʯ������������������������


//�����������ڿ󡿡�������������޸���������������������
//������
function Trigger_105109101(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109101_105109113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,107020101,11); }
function Trigger_105109102(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109101_105109113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,107020101,58); }
function Trigger_105109103(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109101_105109113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,107020101,120); }
function Trigger_105109111(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109101_105109113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,107020201,11); }
function Trigger_105109112(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109101_105109113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,107020201,58); }
function Trigger_105109113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109101_105109113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,107020201,120); }
function Trigger_105109101_105109113(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%TargetItem,%Count)
{
	%ItemID = %Player.GetEquip(13);
	%PlayerName = GetPlayerZiTiName(%Player,1);
	%Player.AttachItemObject(ItemObj,2,13);
	%Num = ItemObj.RemainUseTimes;
	//echo( "%ItemID ==" @ %ItemID @ "	%Num ===" @ %Num );
	%Itemname = GetItemData(%ItemID,1);
	if (%ItemID <= 0)
	{
		%Text = "����װ��һ�����";
		SendOneScreenMessage(2,%Text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Text @ "</t>",%Player);
		return;
	}
	if (%ItemID != %TargetItem)
	{
		%Text = "�˵����޷�����" @ %Itemname @ "������ʹ�ô���";
		SendOneScreenMessage(2,%Text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Text @ "</t>",%Player);
		return;
	}
	if (%Count + %Num > 500)
	{
		%Itemname = GetItemData(%ItemID,1);
		%Text = "ʣ��ʹ�ô������ߣ��޷�����";
		SendOneScreenMessage(2,%Text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Text @ "</t>",%Player);
		return;
	}
	%Player.PutItem(%Type,-1);
	if (%Player.AddItem(1,%type))
	{
		%Player.setEquipItemUsedTimes(%ItemID,13,%Count + %Num);
		//%Text = %Itemname @��"����ɹ�����ǰ��ʹ�ô�����" @ %Count + %Num;
		%Text = %Itemname @ "����ɹ�����ǰ��ʹ�ô�����" @ %Count + %Num;
		SendOneScreenMessage(1,%Text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Text @ "</t>",%Player);
	}
}
//263016.setEquipItemUsedTimes( 107020101, 13, 15 );

//�����������ڿ󡿡�������������޸���������������������


//�����������ڿ󡿡����������龧��ʯʹ�á���������������
//�����龧
//-------------------����ID ���� ���� ���ݵȼ����� ����-------
$ItemGet[105109001,1]="113050002 1 0 1 200";//������ - ��ɫ        200
$ItemGet[105109001,2]="113050003 1 0 1 100";//������ - ��ɫ        300
$ItemGet[105109001,3]="113050004 1 0 1 100";//������ - ��ɫ        400
$ItemGet[105109001,4]="105090501 1 0 1 400";//����ʯ - ��ɫ        800
$ItemGet[105109001,5]="105090502 1 0 1 200";//����ʯ - ��ɫ        1000
$ItemGet[105109001,6]="105090503 1 3 1 150";//����ʯ - ��ɫ        1150
$ItemGet[105109001,7]="105090601 1 0 1 400";//����ʯ - ��ɫ        1550
$ItemGet[105109001,8]="105090602 1 0 1 200";//����ʯ - ��ɫ        1750
$ItemGet[105109001,9]="105090603 1 3 1 150";//����ʯ - ��ɫ        1900
$ItemGet[105109001,10]="105090701 1 0 1 400";//����ʯ - ��ɫ        2300
$ItemGet[105109001,11]="105109031 1 2 0 160";//����̵�ˢ����        2460
$ItemGet[105109001,12]="105109061 1 2 0 100";//��Ӣ��        2560
$ItemGet[105109001,13]="105109321 1 0 1 700";//����ʯ        3260
$ItemGet[105109001,14]="105105701 1 0 1 100";//�ǻ��飨һ�ף�        3360
$ItemGet[105109001,15]="116060105 1 2 0 120";//5���컯��ʯ        3480
$ItemGet[105109001,16]="116060106 1 3 0 100";//6���컯��ʯ        3580
$ItemGet[105109001,17]="116060107 1 3 0 76";//7���컯��ʯ        3656
$ItemGet[105109001,18]="116060108 1 3 0 2";//8���컯��ʯ        3658
$ItemGet[105109001,19]="116080005 1 2 0 90";//�칤����壩        3748
$ItemGet[105109001,20]="116080006 1 3 0 80";//�칤�������        3828
$ItemGet[105109001,21]="116080007 1 3 0 36";//�칤����ߣ�        3864
$ItemGet[105109001,22]="116080008 1 3 0 1";//�칤����ˣ�        3865
$ItemGet[105109001,23]="116060001 1 0 0 100";//����ʯ        3965
$ItemGet[105109001,24]="116060002 1 2 0 150";//����ʯ        4115
$ItemGet[105109001,25]="116070001 1 0 0 200";//��Ԫ��        4315
$ItemGet[105109001,26]="105105301 1 0 0 800";//��Ҷ��        5115
$ItemGet[105109001,27]="105105302 1 0 0 800";//��        5915
$ItemGet[105109001,28]="105105303 1 0 0 500";//����        6415
$ItemGet[105109001,29]="105028001 1 0 0 373";//˫�����鵤        6788
$ItemGet[105109001,30]="105028011 1 3 0 100";//2.5�����鵤        6888
$ItemGet[105109001,31]="113020001 1 0 0 312";//���Ϸ�        7200
$ItemGet[105109001,32]="113020011 1 0 0 300";//�ٻ���        7500
$ItemGet[105109001,33]="113010051 1 0 0 1900";//�������        9400
$ItemGet[105109001,34]="105109081 1 0 0 300";//���������ӡ        9700
$ItemGet[105109001,35]="105109082 1 0 0 300";//���������ӡ        10000


//������ʯ
//-------------------����ID ���� ���� ���ݵȼ����� ����-------
$ItemGet[105109021,1] = "113050005 1 0 1 250"; //������ - ��ɫ
$ItemGet[105109021,2] = "105090502 1 0 1 100"; //����ʯ - ��ɫ
$ItemGet[105109021,3] = "105090503 1 0 1 200"; //����ʯ - ��ɫ
$ItemGet[105109021,4] = "105090602 1 0 1 100"; //����ʯ - ��ɫ
$ItemGet[105109021,5] = "105090603 1 0 1 200"; //����ʯ - ��ɫ
$ItemGet[105109021,6] = "105090712 1 0 1 100"; //����ʯ - ��ɫ
$ItemGet[105109021,7] = "105090713 1 0 1 200"; //����ʯ - ��ɫ
$ItemGet[105109021,8] = "116060106 1 0 0 500"; //6���컯��ʯ
$ItemGet[105109021,9] = "116060107 1 3 0 380"; //7���컯��ʯ
$ItemGet[105109021,10]= "116060108 1 3 0 10"; //8���컯��ʯ
$ItemGet[105109021,11]= "116060109 1 3 0 2"; //9���컯��ʯ
$ItemGet[105109021,12]= "116060110 1 3 0 1"; //10���컯��ʯ
$ItemGet[105109021,13]= "116080007 1 3 0 180"; //�칤����ߣ�
$ItemGet[105109021,14]= "116080008 1 3 0 5"; //�칤����ˣ�
$ItemGet[105109021,15]= "116080009 1 3 0 1"; //�칤����ţ�
$ItemGet[105109021,16]= "116080010 1 3 0 1"; //�칤���ʮ��
$ItemGet[105109021,17]= "116060003 1 3 0 200"; //����ʯ
$ItemGet[105109021,18]= "116070002 1 3 0 100"; //��起�
$ItemGet[105109021,19]= "105105503 1 0 0 500"; //2����ʯ������
$ItemGet[105109021,20]= "105105504 1 0 0 400"; //2����ʯ������
$ItemGet[105109021,21]= "105105512 1 0 0 500"; //3����ʯ������
$ItemGet[105109021,22]= "105105513 1 0 0 300"; //3����ʯ������
$ItemGet[105109021,23]= "105105514 1 3 0 200"; //3����ʯ������
$ItemGet[105109021,24]= "105105522 1 0 0 60"; //4����ʯ������
$ItemGet[105109021,25]= "105105523 1 0 0 40"; //4����ʯ������
$ItemGet[105109021,26]= "105105524 1 3 0 20"; //4����ʯ������
$ItemGet[105109021,27]= "105290024 1 0 0 250"; //3����ʯ�컯��
$ItemGet[105109021,28]= "105290025 1 3 0 250"; //3����ʯ�컯��
$ItemGet[105109021,29]= "105290033 1 0 0 120"; //4����ʯ�컯��
$ItemGet[105109021,30]= "105290034 1 0 0 80"; //4����ʯ�컯��
$ItemGet[105109021,31]= "105290035 1 3 0 60"; //4����ʯ�컯��
$ItemGet[105109021,32]= "105180072 1 3 0 800"; //3���챦ʯ������
$ItemGet[105109021,33]= "105180092 1 3 0 800"; //3���̱�ʯ������
$ItemGet[105109021,34]= "105180152 1 3 0 550"; //3����ʯ������
$ItemGet[105109021,35]= "105180073 1 3 0 30"; //4���챦ʯ������
$ItemGet[105109021,36]= "105180093 1 3 0 30"; //4���̱�ʯ������
$ItemGet[105109021,37]= "105180153 1 3 0 30"; //4����ʯ������
$ItemGet[105109021,38]= "105180074 1 3 0 10"; //5���챦ʯ������
$ItemGet[105109021,39]= "105180094 1 3 0 10"; //5���̱�ʯ������
$ItemGet[105109021,40]= "105180154 1 3 0 10"; //5����ʯ������
$ItemGet[105109021,41]= "105105303 1 0 0 1000"; //����
$ItemGet[105109021,42]= "105105304 1 3 0 600"; //��ש
$ItemGet[105109021,43]= "105105305 1 3 0 10"; //��ʯ
$ItemGet[105109021,44]= "105028011 1 0 0 500"; //2.5�����鵤
$ItemGet[105109021,45]= "105028021 1 3 0 310"; //3�����鵤


function Trigger_105109001(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109001_105109021(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }
function Trigger_105109021(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ){ Trigger_105109001_105109021(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ); }

function Trigger_105109001_105109021(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"������������ȷ��������������1���λ��",%Player);
		return;
	}
	//echo( "==================== =============");
	%Ran = GetRanDom(1,10000);
	%RanRecord = 0;
	for (%i = 1; %i <= 99; %i++)
	{
		//echo( "$ItemGet[ " @ %Type @ "," @ %i  @ "]===" @ $ItemGet[ %Type, %i ] );
		if ($ItemGet[%Type,%i] $= "")
			break;
		%OneRan = GetWord($ItemGet[%Type,%i],4);
		%RanRecord = %RanRecord + %OneRan;
		if (%RanRecord >=  %Ran && %OneRan > 0)
		{
			//echo( "%RanRecord ===" @ %RanRecord );
			//echo( "%i ===" @ %i );
			%ItemID = GetWord($ItemGet[%Type,%i],0);
			%ItemNum = GetWord($ItemGet[%Type,%i],1);
			%MsgType = GetWord($ItemGet[%Type,%i],2);
			%Isspeicl = GetWord($ItemGet[%Type,%i],3);
			break;
		}
	}
	//echo( "%Ran ===" @ %Ran );
	//echo( "%ItemID==A==" @ %ItemID  @ "    %ItemNum===" @ %ItemNum  @  "   %Ran===" @ %Ran );
	if (%ItemID > 0 && %ItemNum > 0)
	{
		if (%Isspeicl == 1)
			%ItemID = Trigger_105109001_105109021A(%Player,%ItemID);
		%Player.Putitem(%Type,-1);
		%Player.Putitem(%ItemID,%ItemNum);
		//echo( "%ItemID====" @ %ItemID @ "    " @ GetItemData( %ItemID, 1 ) );
		if (%Player.additem(1,%type))
		{
			//echo( "%ItemID==B==" @ %ItemID );
			if (%MsgType > 0)
			{
				%ItemNameA0 = GetItemName(%Type,1);
				%ItemNameA1 = GetItemName(%Type,2);
				%ItemNameB0 = GetItemName(%ItemID,1);
				%ItemNameB1 = GetItemName(%ItemID,2);
				%PlayerName0 = GetPlayerZiTiName(%Player,1);
				%PlayerName1 = GetPlayerZiTiName(%Player,2);

				%Text0 ="<t>���Ǹ���</t>" @ %PlayerName0 @ "<t>���ִ�</t>" @ %ItemNameA0 @ "<t>�����</t>" @ %ItemNameB0 @ "<t>��</t>";
				%Text1 ="<t>���Ǹ���</t>" @ %PlayerName1 @ "<t>���ִ�</t>" @ %ItemNameA1 @ "<t>�����</t>" @ %ItemNameB1;

				switch (%MsgType)
				{
					case 1:
						SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text0 @ "</t>");
					case 2:
						SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text1 @ "</t>", $chatMsg_Type_Normal2);
					case 3:
						SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text0 @ "</t>");
						SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text1 @ "</t>", $chatMsg_Type_Normal2);
				}
			}
		}
	}
}

// Trigger_105109001_105109021A( 263087, 113050005 );
function Trigger_105109001_105109021A(%Player,%ItemID)
{
	//%echo = 1;
	//echo( "����ǰ===" @ %ItemID );
	if (%ItemID == 105109061 || %ItemID == 105109321 || %ItemID == 105105701)
		%AddNum = 1;
	else
		%AddNum = 10;
	%Level = %Player.GetLevel();
	%NeedItemID[0] = %ItemID;
	for (%i = 1; %i <= 10; %i++)
	{
		%ItemID = %ItemID + %AddNum;
		%NeedItemID[%i] = %ItemID;
		%ItemLV = GetItemData(%ItemID,$Item_Data_Lv);
		if (%ItemLV >= %Level)
		{
			%ItemID = %NeedItemID[%i - 1];
			//echo( "%ItemID==========="  @ %ItemID );
			break;
		}
	}
	//echo( "%ItemID ===" @ %ItemID );
	if (%echo == 1)
		echo("%ItemID ===" @ %ItemID @   "   " @ GetItemData(%ItemID,1));
	return %ItemID;
}
//�����������ڿ󡿡����������龧��ʯʹ�á���������������


//�����������ڿ󡿡����������������������������������
$SpecialjadeLuck[1] = 100;
$SpecialjadeLuck[2] = 200;
$SpecialjadeLuck[3] = 300;
$SpecialjadeLuck[4] = 400;
$SpecialjadeLuck[5] = 9999;

$SpecialjadeRan[1] = 70;//����ٵļ��ʣ�����Ϊ��
$SpecialjadeRan[2] = 65;//����ٵļ��ʣ�����Ϊ��
$SpecialjadeRan[3] = 60;//����ٵļ��ʣ�����Ϊ��
$SpecialjadeRan[4] = 55;//����ٵļ��ʣ�����Ϊ��
$SpecialjadeRan[5] = 50;//����ٵļ��ʣ�����Ϊ��

$Specialjade[1,1] = 105300001;/*��1*/ $Specialjade[2,1] = 105300011;/*��11*/ $Specialjade[3,1] =105300021;/*��21*/
$Specialjade[1,2] = 105300002;/*��2*/ $Specialjade[2,2] = 105300012;/*��12*/ $Specialjade[3,2] =105300022;/*��22*/
$Specialjade[1,3] = 105300003;/*��3*/ $Specialjade[2,3] = 105300013;/*��13*/ $Specialjade[3,3] =105300023;/*��23*/
$Specialjade[1,4] = 105300004;/*��4*/ $Specialjade[2,4] = 105300014;/*��14*/ $Specialjade[3,4] =105300024;/*��24*/
$Specialjade[1,5] = 105300005;/*��5*/ $Specialjade[2,5] = 105300015;/*��15*/ $Specialjade[3,5] =105300025;/*��25*/
$Specialjade[1,6] = 105300006;/*��1*/ $Specialjade[2,6] = 105300016;/*��11*/ $Specialjade[3,6] =105300026;/*��21*/
$Specialjade[1,7] = 105300007;/*��2*/ $Specialjade[2,7] = 105300017;/*��12*/ $Specialjade[3,7] =105300027;/*��22*/
$Specialjade[1,8] = 105300008;/*��3*/ $Specialjade[2,8] = 105300018;/*��13*/ $Specialjade[3,8] =105300028;/*��23*/
$Specialjade[1,9] = 105300009;/*��4*/ $Specialjade[2,9] = 105300019;/*��14*/ $Specialjade[3,9] =105300029;/*��24*/
$Specialjade[1,10]= 105300010;/*��5*/ $Specialjade[2,10]= 105300020;/*��15*/ $Specialjade[3,10]=105300030;/*��25*/

function GetSpecialjade(%Player,%TakeGold,%Maintype,%Subtype)
{

	switch (%TakeGold)
	{
		case 0:
			%Ran = Getrandom(1,1000);
			if (%Ran > 1)
				return 0;
		case 1:
			%Ran = Getrandom(1,100);
			if (%Ran > 1)
				return 0;
		case 10:
			%Ran = Getrandom(1,100);
			if (%Ran > 3)
				return 0;
	}
	%FuYuan = %Player.GetLuck();
	for (%i = 1; %i <= 5; %i++)
	{
		if (%FuYuan < $SpecialjadeLuck[%i])
		{
			%Row = %i;
			break;
		}
	}
	%Ran = GetRanDom(1,100);
	if (%Ran > $SpecialjadeRan[%Row])
		%Row = %Row + 5;

	%Level = %Player.GetLevel();
	if (%Level <= 50)
		%Column = 1;
	else if (%Level <= 60)
	{
		%Ran = GetRanDom(1,100);
		if (%Ran <= 40)
			%Column = 1;
		else
			%Column = 2;
	}
	else
	{
		%Ran = GetRanDom(1,100);
		if (%Ran <= 20)
			%Column = 1;
		else if (%Ran <= 50)
			%Column = 2;
		else
			%Column = 3;
	}
	if (%Column > 0 && %Row  > 0)
		%ItemId = $Specialjade[%Column,%Row];
	if (%ItemId > 0)
	{
		//echo( "%ItemId====" @ %ItemId );
		%index = %Player.PutItem(%ItemId,1);
		%player.SetPutItemProduceName(%index,%player.GetPlayerName() @ "����Ե��" @ %FuYuan @ "�����ɾ�");
		%Player.Additem(%Maintype,%Subtype);
		return 1;
	}
}
//�����������ڿ󡿡����������������������������������
//function wakuangxxx( )
//{
//	%Player = SptGetplayer( 50000324 );
//	%Pos = %Player.FindItem( 1, 105300001 );
//	%Player.AttachItemObject( ItemObj, 1, %Pos );//�Ȱѵ������Ʒ��������
//	%Player.ItemID = %ItemID;
//	%Player.Master = %PlayerID;//������
//	%Player.MasterName = %Player.GetPlayername( );//�����ߵ�����
//	%Player.ItemObj[ 0 ] = ItemObj.Quantity;		// ��Ʒ����(����װ����ֻ��Ϊ1)					
//	%Player.ItemObj[ 1 ] = ItemObj.BindPlayer;		// ����ID(Ҳ�����ڴ洢������ӿ��������ID
//	%Player.ItemObj[ 2 ] = ItemObj.BindFriend;		// �󶨺��ѽ�ɫID����ʹ����Ʒ				
//	%Player.ItemObj[ 3 ] = ItemObj.ActiveFlag;		// ��Ʒ�����־								
//	%Player.ItemObj[ 4 ] = ItemObj.LapseTime;		// ʣ������
//	%Player.ItemObj[ 5 ] = ItemObj.RemainUseTimes;	// ʣ��ʹ�ô���								
//	%Player.ItemObj[ 6 ] = ItemObj.LockedLeftTime;	// ��Ʒ��ʣ��ʱ�䣨�룩						
//	%Player.ItemObj[ 7 ] = ItemObj.Quality;		// ��ƷƷ�ʵȼ�									
//	%Player.ItemObj[ 8 ] = ItemObj.CurWear;		// ��ǰ�;ö�									
//	%Player.ItemObj[ 9 ] = ItemObj.CurMaxWear;		// ��ǰ����;ö�							
//	%Player.ItemObj[ 10 ] = ItemObj.CurAdroit;		// ��ǰ������								
//	%Player.ItemObj[ 11 ] = ItemObj.CurAdroitLv;		// ��ǰ�����ȵȼ�							
//	%Player.ItemObj[ 12 ] = ItemObj.ActivatePro;		// ��������Ч�������־						
//	%Player.ItemObj[ 13 ] = ItemObj.RandPropertyID;	// �����������ID							
//	%Player.ItemObj[ 14 ] = ItemObj.IDEProValue0;		// �����󸽼�����ֵ0						
//	%Player.ItemObj[ 15 ] = ItemObj.IDEProValue1;		// �����󸽼�����ֵ1						
//	%Player.ItemObj[ 16 ] = ItemObj.IDEProValue2;		// �����󸽼�����ֵ2						
//	%Player.ItemObj[ 17 ] = ItemObj.IDEProValue3;		// �����󸽼�����ֵ3						
//	%Player.ItemObj[ 18 ] = ItemObj.IDEProValue4;		// �����󸽼�����ֵ4						
//	%Player.ItemObj[ 19 ] = ItemObj.IDEProValue5;		// �����󸽼�����ֵ5						
//	%Player.ItemObj[ 20 ] = ItemObj.IDEProValue6;		// �����󸽼�����ֵ6						
//	%Player.ItemObj[ 21 ] = ItemObj.IDEProValue7;		// �����󸽼�����ֵ7						
//	%Player.ItemObj[ 22 ] = ItemObj.IDEProValue8;		// �����󸽼�����ֵ8						
//	%Player.ItemObj[ 23 ] = ItemObj.IDEProValue9;		// �����󸽼�����ֵ9						
//	%Player.ItemObj[ 24 ] = ItemObj.IDEProValue10;	// �����󸽼�����ֵ10						
//	%Player.ItemObj[ 25 ] = ItemObj.IDEProValue11;	// �����󸽼�����ֵ11						
//	%Player.ItemObj[ 26 ] = ItemObj.EquipStrengthens;	// װ��ǿ��������							
//	%Player.ItemObj[ 27 ] = ItemObj.EquipStrengthenValue00;//װ��ǿ������ȼ�ֵ1					
//	%Player.ItemObj[ 28 ] = ItemObj.EquipStrengthenValue01;//װ��ǿ������ȼ�����ֵ1				
//	%Player.ItemObj[ 29 ] = ItemObj.EquipStrengthenValue10;//װ��ǿ������ȼ�ֵ2					
//	%Player.ItemObj[ 30 ] = ItemObj.EquipStrengthenValue11;//װ��ǿ������ȼ�����ֵ2				
//	%Player.ItemObj[ 31 ] = ItemObj.EquipStrengthenValue20;//װ��ǿ������ȼ�ֵ3					
//	%Player.ItemObj[ 32 ] = ItemObj.EquipStrengthenValue21;//װ��ǿ������ȼ�����ֵ3				
//	%Player.ItemObj[ 33 ] = ItemObj.WuXingID;						// ����ID						
//	%Player.ItemObj[ 34 ] = ItemObj.WuXingPro;						// ����Ч������				
//	%Player.ItemObj[ 35 ] = ItemObj.SkillAForEquip;					// װ���ϻ�ȡ����������ID	
//	%Player.ItemObj[ 36 ] = ItemObj.SkillBForEquip;					// װ���ϻ�ȡ�ı�������ID	
//	%Player.ItemObj[ 37 ] = ItemObj.EmbedSlot0;		// װ����Ƕ�׵ı�ʯID						
//	%Player.ItemObj[ 38 ] = ItemObj.EmbedSlot1;		// װ����Ƕ�׵ı�ʯID						
//	%Player.ItemObj[ 39 ] = ItemObj.EmbedSlot2;		// װ����Ƕ�׵ı�ʯID						
//	%Player.ItemObj[ 40 ] = ItemObj.EmbedSlot3;		// װ����Ƕ�׵ı�ʯID						
//	%Player.ItemObj[ 41 ] = ItemObj.EmbedSlot4;		// װ����Ƕ�׵ı�ʯID						
//	%Player.ItemObj[ 42 ] = ItemObj.EmbedSlot5;		// װ����Ƕ�׵ı�ʯID						
//	%Player.ItemObj[ 43 ] = ItemObj.EmbedSlot6;		// װ����Ƕ�׵ı�ʯID						
//	%Player.ItemObj[ 44 ] = ItemObj.EmbedSlot7;		// װ����Ƕ�׵ı�ʯID						
//	%Player.ItemObj[ 45 ] = ItemObj.EXPOR_RESERV0;								//��չ����0		
//	%Player.ItemObj[ 46 ] = ItemObj.EXPOR_RESERV1;								//��չ����1		
//	%Player.ItemObj[ 47 ] = ItemObj.EXPOR_RESERV2;								//��չ����2		
//	%Player.ItemObj[ 48 ] = ItemObj.EXPOR_RESERV3;								//��չ����3		
//	%Player.ItemObj[ 49 ] = ItemObj.EXPOR_RESERV4;								//��չ����4		
//	%Player.ItemObj[ 50 ] = ItemObj.EXPRO_EATLIMIT;								//����ÿ������	
//	%Player.ItemObj[ 51 ] = ItemObj.EXPRO_EATCOUNT;								//�������ɴ���	
//	%Player.ItemObj[ 52 ] = ItemObj.EXPRO_GATHERSOULLEVEL;						//����ȼ�		
//	%Player.ItemObj[ 53 ] = ItemObj.EXPRO_EATPRO0;								//��������0		
//	%Player.ItemObj[ 54 ] = ItemObj.EXPRO_EATPRO1;								//��������1		
//	%Player.ItemObj[ 55 ] = ItemObj.EXPRO_ITEMID;								//��Ʒģ��ID		
//	//%Player.ItemObj[ 55 ] = %ItemID;
//	//--------------�������-------------
//	echo( "------------------------" );
//	echo( %Player.ItemID );
//	echo( %ItemName );
//	echo( %Player.ItemObj[ 0 ] );
//	echo( %Player.Master );//������
//	echo( %Player.MasterName );//�����ߵ�����
//	for ( %i = 0; %i<=55; %i++ )
//	{
//		echo( "λ��" @ %i @ "���ݣ�" @ %Player.ItemObj[ %i ] );
//	}
//}


//�����������ڿ󡿡��������������̵�չʾ����������������
function QiShiShangDianDialog(%Npc,%Player,%State,%Conv)//��ʯ�̵�չʾ
{
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000102);
	}
}
function ShenShiShangDianDialog(%Npc,%Player,%State,%Conv)//��ʯ�̵�չʾ
{
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000103);
	}
}
//�����������ڿ󡿡��������������̵�չʾ����������������
//StallSeeWndGui_DealInfo
//StallWndGui_DealInfo