//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//��SL_C_Mission_UI.cs�ļ��ӹ���
//
//�ͻ���������ؽ������������
//==================================================================================
//����������������������ȡ���񽻽�NPC�ı�š���������������������������������
//����������������������ȡ������ͷ�����ܽӿڡ���������������������������������
//����������������������ȡ�������������á���ͷ˵������������������������������
//����������������������ȡ������������ʱ����ͷ˵������������������������������
//�����������������������µ�ͼ��NPCͷ����ǡ���������������������������������
//����������������������ͨ�á���ȡ���������ͼ��������������������������������

//����������������������ȡ���񽻽�NPC�ı�š���������������������������������
//��������ȡNpcA������
function GetNpcA(%Mid)
{
	%Player = GetPlayer();
	%NpcID = 0;
	switch (%Mid)
	{
		case 20147:%NpcID = -1;//Ѻ��
		case 20149:%NpcID = 410100001;//ʦ������
		case 20001:%NpcID = 411200002;//����֮��
		case 20002:%NpcID = 411200003;//�һ�֮��
		case 20003:%NpcID = 411200002;//��������
		case 20004:%NpcID = 411200003;//��������
		case 20005:%NpcID = 411200001;//��װ��ҩ
		case 20006:%NpcID = 411200001;//����֮�顤һ
		case 20007:%NpcID = 411200001;//����֮�顤��
		case 20008:%NpcID = 411200001;//������ħ
		case 20009:%NpcID = 411210002;//����֮��
		case 20010:%NpcID = 411210003;//�һ�֮��
		case 20011:%NpcID = 411210002;//��������
		case 20012:%NpcID = 411210003;//��������
		case 20013:%NpcID = 411210001;//��װ��ҩ
		case 20014:%NpcID = 411210001;//����֮�顤һ
		case 20015:%NpcID = 411210001;//����֮�顤��
		case 20016:%NpcID = 411210001;//������ħ
		case 20017:%NpcID = 411220002;//����֮��
		case 20018:%NpcID = 411220003;//�һ�֮��
		case 20019:%NpcID = 411220002;//��������
		case 20020:%NpcID = 411220003;//��������
		case 20021:%NpcID = 411220001;//��װ��ҩ
		case 20022:%NpcID = 411220001;//����֮�顤һ
		case 20023:%NpcID = 411220001;//����֮�顤��
		case 20024:%NpcID = 411220001;//������ħ
		default:
			%NpcID = GetMissionData(%Mid,$Mission_Data_NpcA);
	}
	return %NpcID;
}
//��������ȡNpcZ������
function GetNpcZ(%Mid)
{
	//echo( "into GetNPCz" );
	%Player = GetPlayer();
	%NpcID = 0;
	switch (%Mid)
	{
		case 0: %NpcID = 0;
		default:
			%NpcID = GetMissionData(%Mid,$Mission_Data_NpcZ);
	}
	return %NpcID;
}
//����������������������ȡ���񽻽�NPC�ı�š���������������������������������


//����������������������ȡ������ͷ�����ܽӿڡ���������������������������������
function  GetMission_LeiTou_Text(%Mid,%type,%Num)
{
	//echo( "%type===" @ %type );
	switch$(%Type)
	{
		case "Npc":
			switch (%mid)
			{
				case 10161: %Text = "ѧϰ��";
				case 10151: %Text = "��ɣ�";
				case 10291: %Text = "̽�飺";
				case 10221: %Text = "ʹ�ã�";
				case 10231: %Text = "ѧϰ��";
				case 10241: %Text = "ǰ����";
				case 10761: %Text = "��ɣ�";
				case 10781: %Text = "��ɣ�";
				case 10801: %Text = "��ɣ�";
				case 11232: %Text = "ǰ����";
				case 20207: %Text = "��ɣ�";
				case 10931: %Text = "̽�飺";
				case 10951: %Text = "ǰ����";
				case 11021: %Text = "ǰ����";
				case 11041: %Text = "ǰ����";
				case 30101: %Text = "���ϣ�";
				case 30111: %Text = "���ϣ�";
				case 30121: %Text = "���ϣ�";
				case 30131: %Text = "���ϣ�";
				default: %Text = "�Ի���";
			}
			return $Get_Dialog_GeShi[31201] @ " ��" @  %Text @ "</t>";
		case "MonsterKill":
			switch (%mid)
			{

				case 20001:%Text = "�ɼ���";//����֮��
				case 20002:%Text = "�ɼ���";//�һ�֮��
				case 20003:%Text = "���ܣ�";//�������
				case 20004:%Text = "���ܣ�";//��������
				case 20005:%Text = "�ɼ���";//��װ��ҩ
				case 20006:%Text = "�ɼ���";//����֮�顤һ
				case 20007:%Text = "��ɣ�";//����֮�顤��
				case 20008:%Text = "���ܣ�";//������ħ
				case 20009:%Text = "�ɼ���";//����֮��
				case 20010:%Text = "�ɼ���";//�һ�֮��
				case 20011:%Text = "���ܣ�";//�������
				case 20012:%Text = "���ܣ�";//��������
				case 20013:%Text = "�ɼ���";//��װ��ҩ
				case 20014:%Text = "�ɼ���";//����֮�顤һ
				case 20015:%Text = "��ɣ�";//����֮�顤��
				case 20016:%Text = "���ܣ�";//������ħ
				case 20017:%Text = "�ɼ���";//����֮��
				case 20018:%Text = "�ɼ���";//�һ�֮��
				case 20019:%Text = "���ܣ�";//�������
				case 20020:%Text = "���ܣ�";//��������
				case 20021:%Text = "�ɼ���";//��װ��ҩ
				case 20022:%Text = "�ɼ���";//����֮�顤һ
				case 20023:%Text = "��ɣ�";//����֮�顤��
				case 20024:%Text = "���ܣ�";//������ħ
					
				default: %Text = "���ܣ�";
			}
			return $Get_Dialog_GeShi[31201] @ " ��" @  %Text @ "</t>";
		case "ItemAdd":
			return $Get_Dialog_GeShi[31201] @ " ����Ʒ��" @ "</t>";
		case "ItemGet":
			switch (%mid)
			{
				case 10021: %Text = "�ɼ���";
				case 10101: %Text = "�ɼ���";
				case 10131: %Text = "�ɼ���";
				case 20107: %Text = "Ѱ��һ����ҩ��";
				default: %Text = "��Ʒ��";
			}
			return $Get_Dialog_GeShi[31201] @ " ��" @  %Text @ "</t>";
		case "Target":
			switch (%Mid)
			{
				case 10017:%Text = "��ɣ�";
				
				case 20107:%Text = "�ɼ�һ����ҩ��";
				case 20108:%Text = "�ɼ�5����ҩ��";
				case 20109:%Text = "Ѱ��һ����ʯ:";
				case 20110:%Text =  "Ѱ��5����ʯ:";
				case 20115:%Text =  "Χ������:";

				case 20029:%Text =  "����:";
				case 20030:%Text =  "����:";
				case 20031:%Text =  "����:";
				case 20032:%Text =  "����:";
				case 20033:%Text =  "����:";
				case 20034:%Text =  "����:";
				case 20035:%Text =  "����:";

				case 20151:%Text =  "����:";
				
				case 29999:%Text = "ɱ�����";
				default:%Text = "ʹ�ã�";
			}
			return $Get_Dialog_GeShi[31201] @ " ��" @  %Text @ "</t>";
		case "Step":
			return $Get_Dialog_GeShi[31201] @ " ��δ֪��" @ "</t>";
		case "Collect":
			switch (%Mid)
			{

				case 10221:%Text = "����";
				case 10032:%Text = "�ж���";
				case 10111:%Text = "ʹ�÷��ʻ���";
				default:%Text = "�ɼ���";
			}
			return $Get_Dialog_GeShi[31201] @ " ��" @  %Text @ "</t>";	//�ɼ�
		case "forever":
			return Mission_Frontforever(GetPlayer(),%Mid,%Num);	//���������á�
		case "Test":
			return Mission_FrontTest(GetPlayer(),%Mid,%Num);		//��������ʱ��
	}

}
//����������������������ȡ������ͷ�����ܽӿڡ���������������������������������

//����������������������ȡ�������������á���ͷ˵������������������������������������
function Mission_Frontforever(%Player,%Mid,%Num)
{
	%ziti = $Get_Dialog_GeShi[31201];//Ĭ������
	//echo( "%Mid===" @ %Mid @ "   %Num===" @ %Num );
	switch (%Mid)
	{
		case 10018:%MidText = "<t>����</t>"@ Getfindpath(GetMissionData(%Mid,$Mission_Data_NpcA),%Mid,0,31214) @ "<t>�������</t>";
		case 20103:%MidText = "<t>ȥ����֮��ȡ������֮˪</t>";
		case 20104:%MidText = "<t>ȥ����֮��ȡ���һ�֮��</t>";
		case 20105:%MidText = "<t>���ܼ���֮�صĺ����</t>";
		case 20106:%MidText = "<t>���ܼ���֮�ص�������</t>";
		case 20107:%MidText = "<t>ǰȥ��ժ��ҩ�ؽ�����ʹ�ߣ�</t>";
		case 20108:%MidText = "<t>ǰȥ��ժ��ҩ�ؽ�����ʹ�ߣ�</t>";
		case 20109:%MidText = "<t>ǰȥ��ժ��ҩ�ؽ�����ʹ�ߣ�</t>";
		case 20110:%MidText = "<t>ǰȥ��ժ��ҩ�ؽ�����ʹ�ߣ�</t>";
		case 20111:%MidText = "<t>ǰȥ��ժ��ҩ�ؽ�����ʹ�ߣ�</t>";
		case 20112:%MidText = "<t>���Ĳ����������ͣ�</t>";
		case 20113:%MidText = "<t>ǰ����������֮����Ѱ�챦��</t>";
		case 20114:%MidText = "<t>���Ĳ����������ͣ�</t>";
		case 20115:%MidText = "<t>�ּǰȥΧ��Ⱥ����ͷ��</t>";
		case 20001:%MidText = "<t>ȥ����֮��ȡ������֮˪</t>";//����֮��
		case 20002:%MidText = "<t>ȥ����֮��ȡ���һ�֮��</t>";//�һ�֮��
		case 20005://��װ��ҩ
			%NowNum = 44;
			for (%i = 44; %i <=48; %i++)
			{
				if (GetSrc(%Player,%i) == 1)
					%NowNum = %i;
			}
			%MidText = "<t>��ǰ����� </t>" @ $Get_Dialog_GeShi[31201] @ %NowNum - 43 @ "</t><t>/5 ��</t>";
		case 20006:%MidText = "<t>��ȡ��ʯ����ʯ����ʯ�е�����һ��</t>";//����֮�顤һ
		case 20009:%MidText = "<t>ȥ����֮��ȡ������֮˪</t>";//����֮��
		case 20010:%MidText = "<t>ȥ����֮��ȡ���һ�֮��</t>";//�һ�֮��
		case 20013://��װ��ҩ
			%NowNum = 44;
			for (%i = 44; %i <=48; %i++)
			{
				if (GetSrc(%Player,%i) == 1)
					%NowNum = %i;
			}
			%MidText = "<t>��ǰ����� </t>" @ $Get_Dialog_GeShi[31201] @ %NowNum - 43 @ "</t><t>/5 ��</t>";
		case 20014:%MidText = "<t>��ȡ��ʯ����ʯ����ʯ�е�����һ��</t>";//����֮�顤һ
		case 20017:%MidText = "<t>ȥ����֮��ȡ������֮˪</t>";//����֮��
		case 20018:%MidText = "<t>ȥ����֮��ȡ���һ�֮��</t>";//�һ�֮��
		case 20021://��װ��ҩ
			%NowNum = 44;
			for (%i = 44; %i <=48; %i++)
			{
				if (GetSrc(%Player,%i) == 1)
					%NowNum = %i;
			}
			%MidText = "<t>��ǰ����� </t>" @ $Get_Dialog_GeShi[31201] @ %NowNum - 43 @ "</t><t>/5 ��</t>";
		case 20022:%MidText = "<t>��ȡ��ʯ����ʯ����ʯ�е�����һ��</t>";//����֮�顤һ
		case 20025:%MidText = "<t>��ȡԽ������ύ����ʱ����Խ���</t>";
		case 20026:%MidText = "<t>��ȡԽ������ύ����ʱ����Խ���</t>";
		case 20027:%MidText = "<t>��ȡԽ������ύ����ʱ����Խ���</t>";
		case 20147:

			%Act4018[0] = GetAct(%player,4018,0) * 1;
			//echo( "%Act4018[ 0 ]==" @ %Act4018[ 0 ] );
			%MidText = "<t>��ǰ�ѽ�ȡ </t>" @ $Get_Dialog_GeShi[31201] @ %Act4018[0] @ "</t><t>/</t>" @ VIP_getNowTequanLvMaxCnt(%Player, 7) @ "</t> ��</t>";
		case 20149:
			switch (%num)
			{
				case 0:
					%Act4015[0] = GetAct(%player,4015,0) * 1;
					%Act4015[1] = GetAct(%player,4015,1) * 1;
					%MidText = "<t>��ǰ�ѽ� </t>" @ $Get_Dialog_GeShi[31201] @ %Act4015[0] @ "</t><t>/10 ��</t>";
				case 1:
					%MidTarget = %player.getmissionflag(%Mid,10300);
					switch (%MidTarget)
					{
						case 410100003:%MidText = "<t>����ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	��ҵ
						case 410100004:%MidText = "<t>����ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	����
						case 410100005:%MidText = "<t>����ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	����
						case 410100006:%MidText = "<t>��ʦ��ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	��ƽ��
						case 410100007:%MidText = "<t>��ʦ��ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	����ʯ
						case 410100008:%MidText = "<t>��ʦ��ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	�ŵ�ɽ
						case 410100009:%MidText = "<t>����ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	����
						case 410100011:%MidText = "<t>������ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	��֪��
						case 410100032:%MidText = "<t>��ͯ��ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	����
						case 410100031:%MidText = "<t>��ͯ��ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	ɲ��
						case 108020994:%MidText = "<t>ǰ����</t>" @ Getfindpath(410100009,0,0,31214) @ "<t>������</t>";
						case 108020995:%MidText = "<t>ǰ����</t>" @ Getfindpath(410100009,0,0,31214) @ "<t>������</t>";
						case 108020996:%MidText = "<t>ǰ����</t>" @ Getfindpath(410100009,0,0,31214) @ "<t>������</t>";
						case 108020997:%MidText = "<t>ǰ����</t>" @ Getfindpath(410100009,0,0,31214) @ "<t>������</t>";
						case 108020998:%MidText = "<t>ǰ����</t>" @ Getfindpath(410100009,0,0,31214) @ "<t>������</t>";
						case 108020999:%MidText = "<t>ǰ����</t>" @ Getfindpath(410100009,0,0,31214) @ "<t>������</t>";
						case 108021000:%MidText = "<t>ǰ����</t>" @ Getfindpath(410100009,0,0,31214) @ "<t>������</t>";
						case 108021002:%MidText = "<t>��</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(108021002);\",\"" @ $Get_Dialog_GeShi[31414] @ "�ɻ���</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>ʹ��</t>" @ "<l i='" @ 108021001 @ "' t='itemid'/>";
						case 552000010:	%MidText = "<t>�������Ѽ����</t>";
						case 552000011:	%MidText = "<t>�������Ѽ����</t>";
						case 552000012:	%MidText = "<t>�������Ѽ����</t>";
						case 552000013:	%MidText = "<t>�������Ѽ����</t>";
						case 552000014:	%MidText = "<t>�������Ѽ����</t>";
						case 553000050:	%MidText = "<t>������飬������·</t>";
						case 410101020:	%MidText = "<t>Ѱ�ҡ�</t>" @ Getfindpath(410100006,0,0,31214) @ "<t>��������ħ�þ�</t>";//��ħ
						case 410101002:	%MidText = "<t>ǰ���������塻������ħ</t>";//����
						case 410101004:	%MidText = "<t>ǰ���������塻������ħ</t>";//��������
						case 410101014:	%MidText = "<t>ǰ�������ء�������ħ</t>";//�񻯵�����
						case 410101015:	%MidText = "<t>ǰ�������ء�������ħ</t>";//����Ұ��
					}
			}
		case 20150:
			%Act4098[0] = GetAct(%player,4098,0) * 1;
			%MidText = "<t>�����ѽ� </t>" @ $Get_Dialog_GeShi[31201] @ %Act4098[0] @ "</t><t>/10 ��</t>";
		
		
		
		case 29999: %MidText = "<t>��ɱ�������</t>";
		default:
			%MidText = "��������[����]";
	}
	
	return %ziti @ "<t> ��</t>" @ %MidText @ "</t>";
}
//����������������������ȡ�������������á���ͷ˵������������������������������������

//����������������������ȡ������������ʱ����ͷ˵������������������������������������
function Mission_FrontTest(%Player,%Mid,%Num)
{
	//echo( "%Player==" @ %player @ "  %Mid===" @ %mid @ "  %Num===" @ %num );
	%ziti = $Get_Dialog_GeShi[31201];//Ĭ������
	%ziti = "<t f='����' m='1' v='1' n='12' h='0'c='0xffffffff' o='0x010101ff'>";
	switch (%Mid)
	{
		case 20148:
			switch (%num)
			{
				case 0:
					%Act4012[0] = GetAct(%Player,4012,0);
					%MidText = "<t>��������ɴ�����</t>" @ $Get_Dialog_GeShi[31201] @ %Act4012[0] @ "</t><t>/10</t>";
				case 1:
					%MidText = "<t>�������λ�ã�</t>" @ "<l i='" @ "8" @ getact(getplayer(),4013,0) @ "0100 " @ $strMapRanPosRecord[getact(getplayer(),4013,0),getact(getplayer(),4013,1)] @ "' t='path'/>";
					//echo( "8" @ getact( getplayer( ), 4013, 0 ) @ "0100 " @ $strMapRanPosRecord[ getact( getplayer( ), 4013, 0 ), getact( getplayer( ), 4013, 1 ) ] );
				case 2:
					%MidText = "<t>�����ʹ�û�����</t>";
					return  "<t f='����' m='1' v='1' n='14' h='0'c='0xffffffff' o='0x010101ff'></t>" @ %ziti @ "<t> ��</t>" @ %MidText @ "</t>";
			}
		case 10021:	%MidText = "<t>�����������ɼ�</t>";
		case 10061:	%MidText = "<t>�����з������з</t>";
		case 10141:	%MidText = "<t>��������Ӽ�ɼ�</t>";
		case 10091:	%MidText = "<t>���������Ӳݲɼ�</t>";
		case 10121:	%MidText = "<t>�򿪰������������ѧϰ</t>";
		case 10221:	%MidText = "<t>��������������򣬻�õ���</t>";
		case 10461:	%MidText = "<t>���ܿ���������ò��</t>";
		case 10481: %MidText = "<t>װ����˼��ɵ���</t>";
		case 10801: %MidText = "<t>�������3�α��������ڵ�����</t>";
		case 20207: %MidText = "<t>���3��ʦ�ž�������</t>";
		case 20201:	%MidText = "<t>��ֽ�����ӻ��̵깺��</t>";
		case 20205:	%MidText = "<t>ǰ�����ɹ�Ѱ��������ʿ</t>";
		case 20203:	%MidText = "<t>��������Ѱ��������</t>";
		case 20204:	%MidText = "<t>���������������</t>";
		case 30202:	%MidText = "<t>�ڿ���ͭ�������������̵깺��</t>";
		case 30302:	%MidText = "<t>��ֵ�����飬�����ڲ÷��̵깺��</t>";
		case 30402:	%MidText = "<t>��ľ�����ľ��ɰֽ�������̵깺��</t>";
		case 30502:	%MidText = "<t>��ҩ����ϲݣ�ҩƷ�������̵깺��</t>";
		case 30602:	%MidText = "<t>��ľ�����ľ��ɰֽ�������̵깺��</t>";
		case 30702:	%MidText = "<t>��ֵ��䱡�ɣ�����������̵깺��</t>";
	}
	return %ziti @ "<t> ��</t>" @ %MidText @ "</t>";
}
//����������������������ȡ������������ʱ����ͷ˵������������������������������������



//�����������������������µ�ͼ��NPCͷ����ǡ���������������������������������
function UpdateMissionEffect(%Player,%Mid,%Index)
{
	putout("���µ�ͼ��NPCͷ�����   %Player  " @ %Player @ "  %Mid   " @   %Mid @  "   %Index    " @ %Index);
	if (%Player == 0)
		return;
	//ˢ�º�������
	if (%Index == 2)
	{
		delTrackMissionEx(%Mid);	//ɾ��ָ������ĵ�ͼ���
		delNpcTopMissionIcon(%Mid);	//ɾ��ָ�������Npc���

		%NextMission = GetNextMission(%Mid);
		%Type = GetMissionData(%Mid,$Mission_Data_Type);

		if (%NextMission !$= "")
		{
			%MidNum = GetWordCount(%NextMission);

			for (%i = 0; %i < %MidNum; %i++)
				UpdateMissionEffect(%Player,GetWord(%NextMission,%i),1);
		}

		//ˢ��������
		if ((%Type == 3) || (%Type == 9))
			UpdateMissionEffect(%Player,%Mid,1);

		return;
	}

	if (%Mid > 0)
	{
		//���µ�������
		%Mission_Name = GetMissionData(%Mid,$Mission_Data_Name);

		delTrackMissionEx(%Mid);	//ɾ��ָ������ĵ�ͼ���
		delNpcTopMissionIcon(%Mid);	//ɾ��ָ�������Npc���

		//�ж����ѽӻ��ǿɽ�
		if (%Player.IsAcceptedMission(%Mid))
		{
			%NpcZ = GetNpcZ(%Mid);
			%Family = %Player.GetFamily();

			if (CanDoThisMission(%Player,%Mid,2,0,0) $= "")	//�Ƿ��Ѿ��ɽ���
			{
				if (%NpcZ > 0)
				{
					insertTrackMissionEx(%Mid,"���񣺡�" @ %Mission_Name @ "��",%NpcZ,1);	//��ӵ�ͼ���
					insertNpcTopMissionIcon(%Mid,%NpcZ,1);	//���Npc��ǣ��ɽ��ʺ�
				}
			}
			else
			{
				//Npcͷ�����
				if (%NpcZ > 0)
					insertNpcTopMissionIcon(%Mid,%NpcZ,5);	//���Npc��ǣ����ɽ��ʺ�

				//���������������Ƿ��㹻
				for (%i = 0; %i < 9; %i++)
				{
					%Monster = %Player.GetMissionFlag(%Mid,3100 + %i);
					%KillNum = %Player.GetMissionFlag(%Mid,3200 + %i);

					if (%Monster == 0)
						break;

					if (%Player.GetMissionFlag(%Mid,3300 + %i) < %Player.GetMissionFlag(%Mid,3200 + %i))
						insertTrackMissionEx(%Mid,"���񣺡�" @ %Mission_Name @ "��",%Monster,8);
				}

				//������;�ĶԻ�Ŀ�������Ƿ��㹻
				for (%i = 0; %i < 9; %i++)
				{
					%NpcX    = %Player.GetMissionFlag(%Mid,1150 + %i);
					%NpcXNum = %Player.GetMissionFlag(%Mid,1250 + %i);

					if (%NpcX == 0)
						break;

					if ((%NpcX > 0)&&(%Player.GetMissionFlag(%Mid,1350 + %i) < %NpcXNum))
					{
						insertTrackMissionEx(%Mid,"���񣺡�" @ %Mission_Name @ "��",%NpcX,9);
						insertNpcTopMissionIcon(%Mid,%NpcX,9);	//���Npc��ǣ���;�Ի����
					}
				}

				//������������������NPC���ʱ���ڴ�NPCͷ����ӿɶԻ����
				for (%i = 0; %i < 9; %i++)
				{
					%NpcX    = %Player.GetMissionFlag(%Mid,1100 + %i);
					%NpcXNum = %Player.GetMissionFlag(%Mid,1200 + %i);

					if (%NpcX == 0)
						break;

					if (GetSubStr(%NpcX,0,1) $= "4") //��λ�� 4 ��ʾ��ID��NPC���
					{
						if (%Player.GetMissionFlag(%Mid,1300 + %i) < %NpcXNum)
						{
							insertTrackMissionEx(%Mid,"���񣺡�" @ %Mission_Name @ "��",%NpcX,9);
							insertNpcTopMissionIcon(%Mid,%NpcX,9);	//���Npc��ǣ���;�Ի����
						}
					}
				}

				//�����ȡ�����Ƿ��㹻
				for (%i = 0; %i < 9; %i++)
				{
					%ItemGet = %Player.GetMissionFlag(%Mid,2100 + %i);
					%GetNum  = %Player.GetMissionFlag(%Mid,2200 + %i);

					if (%ItemGet == 0)
						break;

					if (%Player.GetMissionFlag(%Mid,2300 + %i) < %Player.GetMissionFlag(%Mid,2200 + %i))
						if ($Item_Monster[%ItemGet] !$= "")
							insertTrackMissionEx(%Mid,"���񣺡�" @ %Mission_Name @ "��",$Item_Monster[%ItemGet],7);
				}

				//����ʹ�õ��ߴ���Ŀ�������Ƿ��㹻
				for (%i = 0; %i < 9; %i++)
				{
					%Target = %Player.GetMissionFlag(%Mid,1100 + %i);
					%TarNum = %Player.GetMissionFlag(%Mid,1200 + %i);

					if (%Target == 0)
						break;

					if (%Player.GetMissionFlag(%Mid,1300 + %i) < %TarNum)
						if ($Item_Monster[%ItemGet] !$= "")
							insertTrackMissionEx(%Mid,"���񣺡�" @ %Mission_Name @ "��",$Item_Monster[%ItemGet],7);
				}

				//����ɼ�����Ŀ�������Ƿ��㹻
				for (%i = 0; %i < 9; %i++)
				{
					%CollectGet = %Player.GetMissionFlag(%Mid,2130 + %i);
					%CollectNum = %Player.GetMissionFlag(%Mid,2230 + %i);

					if (%CollectGet == 0)
						break;

					if (%Player.GetMissionFlag(%Mid,2330 + %i) < %CollectNum)
						insertTrackMissionEx(%Mid,"���񣺡�" @ %Mission_Name @ "��",%CollectGet,7);
				}
			}
		}
		else
		{
			%NpcA = GetNpcA(%Mid);
			if (%NpcA > 0)
			{
				%Type = 0;
				//echo( "CanDoThisMission( %Player, %Mid, 1, 0, 0 ) ===" @ CanDoThisMission( %Player, %Mid, 1, 0, 0 ) );
				if (!Mission_Begin_SeeOption(%Player, %Mid))//�Ƿ���ʾ(�����ж�)
				{
					if (CanDoThisMission(%Player, %Mid, 1, 0, 0) $= "")	//�Ƿ��Ѿ��ɽ�
					{
						switch (GetMissionData(%Mid, $Mission_Data_Type))
						{
							case 0:	%Type = 3;	//"��ʥ������"//֧���������ͼ��
							case 1:	%Type = 2;	//"���»�����"//�����������ͼ��
							case 2:	%Type = 3;	//"��֧�߾��顽"//֧���������ͼ��
							case 3: %Type = 4;	//"��ÿ��ѭ����"//ѭ���������ͼ��
							case 4:	%Type = 3;	//"����������"//֧���������ͼ��
							case 5:	%Type = 3;	//"��ָ������"//֧���������ͼ��
							case 6: %Type = 3;	//"�������"//֧���������ͼ��
							case 7:	%Type = 3;	//"����������"//֧���������ͼ��
							case 9:	%Type = 3;	//"��ս������"//֧���������ͼ��
							default: %Type = 3;	//֧���������ͼ��
						}
					}
					//�Ƿ��Ѿ��ɽӣ��ÿ��ӵȼ����ж�
					if ((%Type == 0) && (CanDoThisMission(%Player, %Mid, 1, 2, 0) $= ""))
						%Type = 6;//��ɫ̾��
				}
				if (%Type > 0)
				{
					insertTrackMissionEx(%Mid,"���񣺡�" @ %Mission_Name @ "��",%NpcA,%Type);	//��ӵ�ͼ���
					insertNpcTopMissionIcon(%Mid,%NpcA,%Type);	//���Npc��ǣ��ɽ�̾��
				}
			}
		}
	}
	else
	{
		//�����ѽӵ�
		%AcceptCount = %Player.GetAcceptedMission();	// �����ѽ�����

		//������������ѽ����������Ӧ���
		if (%AcceptCount > 0)
			for (%i = 0; %i < %AcceptCount; %i++)
			{
				if (%Player.GetMission(%i) > 0)
					UpdateMissionEffect(%Player,%Player.GetMission(%i),1);
			}

		//�����ɽӵ�
		%Playerleve = %Player.GetLevel();
		%Midleve = GetCanSeeMission(%Playerleve);
		%MidNum = GetWordCount(%Midleve);

		//ѭ�����п��ӵȼ��Ŀɽ�������ӱ��
		if (%MidNum !$= "")
			for (%i = 0; %i < %MidNum; %i++)
			{
				%Mid = GetWord(%Midleve,%i);

				if (CanDoThisMission(%Player,%Mid,1,0,0) $= "")	//�Ƿ���ʾ(�����ж�)
				{
					delTrackMissionEx(%Mid);	//ɾ��ָ������ĵ�ͼ���
					delNpcTopMissionIcon(%Mid);	//ɾ��ָ�������Npc���

					UpdateMissionEffect(%Player,%Mid,1);
				}
			}
	}
}
//�����������������������µ�ͼ��NPCͷ����ǡ���������������������������������
//����������������������ͨ�á���ȡ���������ͼ��������������������������������
function GetMissionMap(%Player,%Mid,%Back)
{
	switch (%Mid)
	{
		case 0:%Type = 1;
		default:%Type = 0;
	}

	switch (%Type)
	{
		case 0://Ĭ������
			%Mid_Kind = GetMissionData(%Mid,$Mission_Data_Map_Area);
			%MapName  =	GetTriggerData(%Mid_Kind,3);

		case 1://��������

		default://Ĭ������
			%Mid_Kind = GetMissionData(%Mid,$Mission_Data_Map_Area);
			%MapName  =	GetTriggerData(%Mid_Kind,3);
	}

	//ȷ�Ϸ���ֵ
	switch (%Back)
	{
		case 1:return %MapName;
		case 2:return %Mid_Kind;
	}
}

//����������������������ͨ�á���ȡ���������ͼ��������������������������������
