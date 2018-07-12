//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//
//��ħ��
//==================================================================================
//411180001	ʬ��
//411180002	ʬ�� ������
//411180003	ʬ�� ����
//411180004	ʬ�� �ٵ�
//411181001	������

//������������ħ�����������ʬ��������������������
//������������ħ��������������ͶԻ���������������
//������������ħ�����������ʬ��ˢ�¡�������������
//������������ħ�����������ʬ��������������������



//������������ħ�����������ʬ��������������������
function KilledMonster_411180001(%Player,%Monster,%SharePlayerNum,%MaxConnection)
{
	if (%Monster.Record == 1)
		return;
	if ($SL_ShiMoDian_bActive != 1)
		return;
	//echo( "ʬ������=====" );
	%Pos = %Monster.GetPosition();

	%HuoDongMingCheng1 = GetHuoDongName("��ħ�����",1);
	%HuoDongMingCheng2 = GetHuoDongName("��ħ�����",2);

	%NpcName1 = GetNpcZiTiName(%Monster.GetDataID(),1);
	%NpcName2 = GetNpcZiTiName(%Monster.GetDataID(),2);
	%MapName1 = GetMapName(%Monster,1);
	%MapName2 = GetMapName(%Monster,2);

	%Text1 = %NpcName1 @ "<t>�����ܣ�</t>" @ %HuoDongMingCheng1 @ "<t>������</t>" @ %MapName1 @ "<t>��</t>";
	%Text2 = %NpcName2 @ "<t>�����ܣ�</t>" @ %HuoDongMingCheng2 @ "<t>������</t>" @ %MapName2 @ "<t>��</t>";
	SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
	SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);

	SpNewNpc2(0,411181001,%Pos,%Monster.GetLayerID(),0);
	%Functionname = "SptCreateShiMoDianMonSter( );";
	SptInterMapExecute(1118,%Functionname);
	%Monster.Record = 1;
	Schedule(10000,0,"KilledMonster_411180001_A",%Monster);
}
function KilledMonster_411180001_A(%Monster)
{
	%Monster.Record = 0;
}
//������������ħ�����������ʬ��������������������


//������������ħ��������������ͶԻ���������������
function GotoShiMoDian_DiaLog(%Npc,%Player,%State,%Conv)
{
	%Conv.Settype(4);
	if (%Player.GetLevel() < $SL_ShiMoDian_Level)
	{
		SendOneScreenMessage(2,"���Ľ�ɫ����" @ $SL_ShiMoDian_Level @ "�����޷�������ħ��",%Player);
		return;
	}
	AddAchievementWatch(%Player,0,38,1);//��¼�ɾ�
	%Pos = $strMapRanPosRecord[1118,GetRandom(1,$strMapRanPosRecordMax[1118])];
	%Player.TransportObject(0,1118,GetWord(%Pos,0),GetWord(%Pos,1),GetWord(%Pos,2));
}

//������������ħ��������������ͶԻ���������������

//������������ħ�����������ʬ��ˢ�¡�������������
function SptCreateShiMoDianMonSter()
{
	%MapID = GetZoneID();
	if (%MapID != 1118)
		return;
	%PlayerNumber = GetRenShuTongJiFortoday();//��ȡ����Ļ�Ծ�û�����
	if (%PlayerNumber <= 200)
		%Number = 1;
	else
		%Number = mfloor(%PlayerNumber  - 200)/100 + 1;
	//echo("%Number==== " @ %Number);
	for (%i = 1; %i <= %Number; %i++)
	{
		//echo("%i==" @ %i);
		%Pos = $strMapRanPosRecord[1118,GetRandom(1,$strMapRanPosRecordMax[1118])];
		%X = GetWord(%Pos,0);
		%Y = GetWord(%Pos,1);
		%Z = GetWord(%Pos,2);
		%X = GetRanDom(%X - 2,%X + 2);
		%Y = GetRanDom(%Y - 2,%Y + 2);
		%Pos = %X @ " " @ %Y @ " " @ %Z;
		if (!isobject($ShiMoDianMonSter[%i]))
			$ShiMoDianMonSter[%i] = SpNewNpc2(0,411180002,%Pos,0,GetRanDom(0,360));
		if (!isobject($ShiMoDianMonSter[%Number + %i]))
			$ShiMoDianMonSter[%Number + %i] = SpNewNpc2(0,411180003,%Pos,0,GetRanDom(0,360));
	}
	for (%i = 1; %i <= 50 - %Number * 2; %i++)
	{
		//echo("%i==" @ %i);
		%Pos = $strMapRanPosRecord[1118,GetRandom(1,$strMapRanPosRecordMax[1118])];
		%X = GetWord(%Pos,0);
		%Y = GetWord(%Pos,1);
		%Z = GetWord(%Pos,2);
		%X = GetRanDom(%X - 2,%X + 2);
		%Y = GetRanDom(%Y - 2,%Y + 2);
		%Pos = %X @ " " @ %Y @ " " @ %Z;

		if (!isobject($ShiMoDianMonSter[%i + %Number * 2]))
			$ShiMoDianMonSter[%i + %Number * 2] = SpNewNpc2(0,411180004,%Pos,0,GetRanDom(0,360));
	}
}
//������������ħ�����������ʬ��ˢ�¡�������������


//������������ħ�����������ʬ��������������������
function NpcObjectonDeathcast_411180002(%Monster,%Killer)//����
{

}
function NpcObjectonDeathcast_411180003(%Monster,%Killer)//����
{

}
function NpcObjectonDeathcast_411180004(%Monster,%Killer)//�ٹ�
{

}
//������������ħ�����������ʬ��������������������