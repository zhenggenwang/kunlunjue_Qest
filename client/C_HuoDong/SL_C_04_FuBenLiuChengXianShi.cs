//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//����������ս���׶�������ʾ����
//==================================================================================

//����������ʱ���Ѻۡ���������������������
//������������ħԨ������������������������
//����������Ѫħ��ӡ���������������������
//�����������þ����ԡ���������������������
//������������������������������������
//���������������������������������������


//����������ʱ���Ѻۡ���������������������

function ShiKongLieHenFuBenTongJiWnd(%Player,%Text)
{
	//echo( "%Player===" @ %Player @ "    %Text===" @ %Text );
	CanCel($ShiKongLieHenFuBenTongJiWnd);
	//if ( %Player.Gettriggerid( ) !$= "813010100" )
	//	return;
	%GuaKa = GetWord(%Text,0);//��ǰ��������
	%NextTime =  GetWord(%Text,1);//��һ�����ﵹ��ʱ
	//echo( " GuaKa====" @ %GuaKa );
	//echo( " NextTime====" @ %NextTime );
	//echo( " Text====" @ %Text );

	%GuaKaText = "��ǰ������������ " @ %GuaKa @ " ��";
	%NextTimeTxt = %NextTime @ " ��";

	if (%GuaKa == 0)
		%GuaKaText = "δ��ʼ";
	if (%GuaKa == -1)
		%GuaKaText = "�ѽ���";

	if (%GuaKa <= 0 || %GuaKa >= 40)
		%NextTimeTxt = "��";

	switch (%GuaKa + 1)
	{
		case 10:%TeShuText = "��һ����������������";
		case 20:%TeShuText = "��һ�����д����������͵Ϯ";
		case 25:%TeShuText = "��һ����������������";
		case 34:%TeShuText = "��һ�����д����������͵Ϯ";
		case 40:%TeShuText = "��һ�������ռ�����������";
	}
	FBMessageAppear();	//�򿪸�����Ϣ����
	%Title = $Get_Dialog_GeShi[11400];	//����
	%XiaoBiaoTi = $Get_Dialog_GeShi[31201];	//Xiao����
	FBProgressMessage.clearitem();
	%Node[1] = AddFBProgressNode(0,%Title @ "�������ſ���</t>",1,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "��" @ %GuaKaText @ "</t>",1*100 + 0,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "���²����ﵹ��ʱ��" @ %NextTimeTxt @ "</t>",1*100 + 1,0);
	if (%TeShuText !$= "")
		AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "��" @ %TeShuText @ "</t>",1*100 + 2,0);

	FBProgressMessage.buildVisibleTree(0);

	%NextTime--;
	if (%NextTime >= 0)
		$ShiKongLieHenFuBenTongJiWnd = schedule(1000,0,"ShiKongLieHenFuBenTongJiWnd",%Player,%GuaKa @ " " @  %NextTime);
}
//����������ʱ���Ѻۡ���������������������


//������������ħԨ������������������������
function LianMoYuanFuBenTongJiWnd(%Player,%Text)
{
	//echo( "%Text===" @ %Text );
	CanCel($LianMoYuanFuBenTongJiWnd);
	if (%Player.Gettriggerid() !$= "813010200")
		return;
	%GuaKia = GetWord(%Text,0);
	if (%GuaKia > 25)
		%GuaKia = "��ͨ��";

	%Time = GetWord(%Text,1);
	//echo( "%Time===" @ %Time );
	if (%Time == 99999)
	{
		%TimeTxt = "δ������ս";
	}
	else
	{
		if (%Time == 1)
			%TimeTxt = "��ս����";
		else
		{
			%M = mfloor(%Time/60);
			%S = %Time%60;
			if (%M <= 9)
				%M = "0" @ %M;
			if (%S <= 9)
				%S = "0" @ %S;
			%TimeTxt = %M @ ":" @ %S;
		}
	}

	FBMessageAppear();	//�򿪸�����Ϣ����
	%Title = $Get_Dialog_GeShi[11400];	//����
	%XiaoBiaoTi = $Get_Dialog_GeShi[31201];	//Xiao����
	FBProgressMessage.clearitem();
	%Node[1] = AddFBProgressNode(0,%Title @ "�������ſ���</t>",1,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "����ɹؿ���" @ %GuaKia @ "</t>",1*100 + 0,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "��ʣ��ʱ�䣺" @ %TimeTxt @ "</t>",1*100 + 1,0);

	FBProgressMessage.buildVisibleTree(0);

	%Time--;
	if (%Time > 0 && %Time < 90000)
		$LianMoYuanFuBenTongJiWnd = schedule(1000,0,"LianMoYuanFuBenTongJiWnd",%Player,%GuaKia @ " " @  %Time);
}
//������������ħԨ������������������������

//����������Ѫħ��ӡ���������������������
//XueMoFengYinZhenFuBenTongJiWnd( GetPlayer(), "0 0 0" ); XueMoFengYinZhenFuBenTongJiWnd( GetPlayer(), "2 1500 17 410010203.0.410010204.1.410010205.2" );

function XueMoFengYinZhenFuBenTongJiWnd(%Player,%Text)
{
	CanCel($XueMoFengYinZhenFuBenTongJiWnd);
	%MapID = GetZoneID();
	if (%MapID != 130701)
	{

		return;
	}
	//echo( "%Text==============================" @ %Text );
	%LostTime = GetWord(%Text,0);
	%BoShu = GetWord(%Text,1);
	%MonsterNumber = GetWord(%Text,2);
	%BossMsg = GetWord(%Text,3);

	if (%BoShu == 0)
		%GuaKia = "ս��δ����";
	else
		%GuaKia = "��ǰ�ڣ�" @ %BoShu @ " ��";

	%M = mfloor(%LostTime/60);
	%S = %LostTime%60;
	if (%M <= 9)
		%M = "0" @ %M;
	if (%S <= 9)
		%S = "0" @ %S;
	%TimeTxt = %M @ "��" @ %S;

	FBMessageAppear();	//�򿪸�����Ϣ����
	%Title = $Get_Dialog_GeShi[11400];	//����
	%XiaoBiaoTi = $Get_Dialog_GeShi[31201];	//Xiao����
	FBProgressMessage.clearitem();
	%Node[1] = AddFBProgressNode(0,%Title @ "�������ſ���</t>",1,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "������ʣ��ʱ�䣺" @ %TimeTxt @ "</t>",1*100 + 0,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "��" @ %GuaKia @ "</t>",1*100 + 1,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "��������������" @ %MonsterNumber @ "</t>",1*100 + 2,0);

	//echo( "%BossMsg==" @ %BossMsg );
	if (%BossMsg !$= "")
	{
		%Count = GetWordCount(%BossMsg,".");
		if (%Count > 1)
		{
			%j = 3;
			for (%i = 0; %i < %Count; %i++)
			{
				%BossID = GetWord(%BossMsg,%i,".");
				%i++;
				%BossState = GetWord(%BossMsg,%i,".");
				//echo( "%BossState==" @ %BossState );
				switch (%BossState)
				{
					case 0: %StateText = "δ��ս";
					case 1: %StateText = "ս����";
					case 2: %StateText = "�ѻ���";
				}
				%StateText = GetNpcData(%BossID,1) @ "��" @  %StateText;
				AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "��" @ %StateText @ "</t>",1*100 + %j,0);
				%j++;
			}
		}
	}
	FBProgressMessage.buildVisibleTree(0);
	%LostTime--;
	%Text = %LostTime @ " " @ %BoShu @ " " @ %MonsterNumber @ " " @ %BossMsg;
	if (%LostTime >= 0)
		$XueMoFengYinZhenFuBenTongJiWnd = schedule(1000,0,"XueMoFengYinZhenFuBenTongJiWnd",%Player,%Text);
}
//����������Ѫħ��ӡ���������������������

//�����������þ����ԡ���������������������
//HuanJingZhengBaFuBenTongJiWnd( GetPlayer(), "150 10 12 15 36 41 55 3" );
function HuanJingZhengBaFuBenTongJiWnd(%Player,%Text)
{
	//echo( "%Text===" @ %Text );
	CanCel($HuanJingZhengBaFuBenTongJiWnd);
	%MapID = GetZoneID();
	if (%MapID != 130201)
	{

		return;
	}
	%Time = GetWord(%Text,0);
	%PeopleNumber[100] = GetWord(%Text,1);
	%PeopleNumber[200] = GetWord(%Text,2);
	%PeopleNumber[300] = GetWord(%Text,3);
	%PeopleNumber[400] = GetWord(%Text,4);
	%PeopleNumber[500] = GetWord(%Text,5);
	%KillNumber = GetWord(%Text,6);
	%NowState = GetWord(%Text,7);
	//echo( "%NowState===" @ %NowState );
	if (%Time >= 1800)
		%TimeTxt = "ս������";
	else
	{
		if (%Time < 120)
			%TimeTxt = "ս��δ��ʼ";
		else
		{
			%M = mfloor((1800-%Time)/60);
			%S = (1800-%Time)%60;
			if (%M <= 9)
				%M = "0" @ %M;
			if (%S <= 9)
				%S = "0" @ %S;
			%TimeTxt = %M @ "��" @ %S;
		}
	}
	%TriggerID = %Player.GetTriggerID();
	switch (%TriggerID)
	{
		case 813020100:
			%JinSheng = "׼�����ȴ���";
		case 813020500:
			if (%NowState >= 0)
				%JinSheng = "�ѽ�������߲�";
			else
				%JinSheng = "���� " @ 5 + %NowState @ " �κ󽵼�";
		case 813020200:
			if (%NowState >= 0)
				%JinSheng = "���� " @ 5 - %NowState @ " �˺����";
			else
				%JinSheng = "���� 5 �˺����";
		default:
			if (%NowState >= 0)
				%JinSheng = "���� " @ 5 - %NowState @ " �˺����";
			else
				%JinSheng = "���� " @ 5 + %NowState @ " �κ󽵼�";
	}
	FBMessageAppear();	//�򿪸�����Ϣ����
	%Title = $Get_Dialog_GeShi[11400];	//����
	%XiaoBiaoTi = $Get_Dialog_GeShi[31201];	//Xiao����
	FBProgressMessage.clearitem();
	%Node[1] = AddFBProgressNode(0,%Title @ "���������ݡ�</t>",1,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "����ɱ������" @ %KillNumber @ " ��</t>",1*100 + 0,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "����ǰ״̬��" @ %JinSheng @ "</t>",1*100 + 1,0);

	%Node[2] = AddFBProgressNode(0,%Title @ "��ս�����ݡ���</t>",2,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "��ʣ��ʱ�䣺" @ %TimeTxt @ "</t>",2*100 + 0,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "���þ�һ�㣺" @ %PeopleNumber[200] @ " ��</t>",2*100 + 1,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "���þ����㣺" @ %PeopleNumber[300] @ " ��</t>",2*100 + 2,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "���þ����㣺" @ %PeopleNumber[400] @ " ��</t>",2*100 + 3,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "���þ��Ĳ㣺" @ %PeopleNumber[500] @ " ��</t>",2*100 + 4,0);
	FBProgressMessage.buildVisibleTree(0);


	%Time++;
	%Text = %Time @ " " @ %PeopleNumber[100] @ " " @ %PeopleNumber[200] @ " " @ %PeopleNumber[300] @ " " @ %PeopleNumber[400] @ " " @ %PeopleNumber[500] @ " " @ %KillNumber @ " " @ %NowState;

	if (%Time <= 1800)
		$HuanJingZhengBaFuBenTongJiWnd = schedule(1000,0,"HuanJingZhengBaFuBenTongJiWnd",%Player,%Text);
}
//�����������þ����ԡ���������������������

//������������������������������������
//YunXianJieDaTaoShaFuBenTongJiWnd(getplayer(),"-1 -1 -1 -1 3 12 12");
function YunXianJieDaTaoShaFuBenTongJiWnd(%Player,%Text)
{
	//echo( "%Text===" @ %Text );
	CanCel($YunXianJieDaTaoShaFuBenTongJiWnd);
	%MapID = GetZoneID();
	if (%MapID != 130401)
	{
		BigViewMap_triggeridbmp_1.setvisible(0);
		BigViewMap_triggeridbmp_2.setvisible(0);
		BigViewMap_triggeridbmp_3.setvisible(0);
		BigViewMap_triggeridbmp_4.setvisible(0);
		BigViewMap_triggeridbmp_5.setvisible(0);

		return;
	}
	//echo( "%Text==" @ %Text );
	//0 �� 4λ-----�����¼  >0 �������� -1 ��ʾ�����Ѿ��� 
	//5λ ս��ʱ����ʱ
	//6λ ɱ������
	%State1 =  GetWord(%Text,0);
	%State2 =  GetWord(%Text,1);
	%State3 =  GetWord(%Text,2);
	%State4 =  GetWord(%Text,3);
	%State5 =  GetWord(%Text,4);
	%Time = GetWord(%Text,5);
	%KillNumBer = GetWord(%Text,6);

	if (%State1 >= 0) %Title1 = "��� " @ %State1 @ " ��"; else { %Title1 = "�����"; BigViewMap_triggeridbmp_1.setvisible(1); }
	if (%State2 >= 0) %Title2 = "��� " @ %State2 @ " ��"; else { %Title2 = "�����"; BigViewMap_triggeridbmp_2.setvisible(1); }
	if (%State3 >= 0) %Title3 = "��� " @ %State3 @ " ��"; else { %Title3 = "�����"; BigViewMap_triggeridbmp_3.setvisible(1); }
	if (%State4 >= 0) %Title4 = "��� " @ %State4 @ " ��"; else { %Title4 = "�����"; BigViewMap_triggeridbmp_4.setvisible(1); }
	if (%State5 >= 0) %Title5 = "��� " @ %State5 @ " ��"; else { %Title5 = "�����"; BigViewMap_triggeridbmp_5.setvisible(1); }
	if (%Time >= 3600)
	{
		%TimeTxt = "ս��δ��ʼ";
		BigViewMap_triggeridbmp_1.setvisible(0);
		BigViewMap_triggeridbmp_2.setvisible(0);
		BigViewMap_triggeridbmp_3.setvisible(0);
		BigViewMap_triggeridbmp_4.setvisible(0);
		BigViewMap_triggeridbmp_5.setvisible(0);
	}
	else
	{
		if (%Time <= 1)
		{
			BigViewMap_triggeridbmp_1.setvisible(0);
			BigViewMap_triggeridbmp_2.setvisible(0);
			BigViewMap_triggeridbmp_3.setvisible(0);
			BigViewMap_triggeridbmp_4.setvisible(0);
			BigViewMap_triggeridbmp_5.setvisible(0);
			%TimeTxt = "ս���ѽ���";
		}
		else
		{
			%M = mfloor(%Time/60);
			%S = %Time%60;
			if (%M <= 9)
				%M = "0" @ %M;
			if (%S <= 9)
				%S = "0" @ %S;
			%TimeTxt = %M @ "��" @ %S;
		}
	}
	%KillTxt = "��ǰɱ�У�" @ %KillNumBer @ "��";

	FBMessageAppear();	//�򿪸�����Ϣ����
	%Title = $Get_Dialog_GeShi[11400];	//����
	%XiaoBiaoTi = $Get_Dialog_GeShi[31201];	//Xiao����
	FBProgressMessage.clearitem();

	%Node[1] = AddFBProgressNode(0,%Title @ "�����˸ſ���</t>",1,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "������ʱ�䣺" @ %TimeTxt @ "</t>",1*100 + 0,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "��" @ %KillTxt @ "</t>",1*100 + 1,0);

	%Node[2] = AddFBProgressNode(0,%Title @ "��ս�����ݡ���</t>",2,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "�������̨��" @ %Title1 @ "</t>",2*100 + 0,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "����������" @ %Title2 @ "</t>",2*100 + 1,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "���׻�����" @ %Title3 @ "</t>",2*100 + 2,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "����ȸ����" @ %Title4 @ "</t>",2*100 + 3,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "����������" @ %Title5 @ "</t>",2*100 + 4,0);
	FBProgressMessage.buildVisibleTree(0);


	%Time--;
	%Text = %State1 @ " " @ %State2 @ " " @ %State3 @ " " @ %State4 @ " " @ %State5 @ " " @ %Time @ " " @ %KillNumBer;
	if (%Time > 0)
		$YunXianJieDaTaoShaFuBenTongJiWnd = schedule(1000,0,"YunXianJieDaTaoShaFuBenTongJiWnd",%Player,%Text);
}


//������������������������������������

//���������������������������������������
//����ʣ��ʱ�� ��Ӫ1���� ��Ӫ2���� �������� ���˻������� ����������  DaoJianShenYuFuBenTongJiWnd( getplayer(),"1900 15 35 2 9 3" );
function DaoJianShenYuFuBenTongJiWnd(%Player,%Text)
{
	CanCel($DaoJianShenYuFuBenTongJiWnd);
	%MapID = GetZoneID();

	if (%MapID != 130501)
	{

		return;
	}
	%Force = %Player.GetForce();
	switch (%Force)
	{
		case 1:%ForceName = "�쵶";
		case 2:%ForceName = "��";
		case 0:%ForceName = "����";
	}
	$CopyMap1305State0 =  GetWord(%Text,0) * 1;//����ʣ��ʱ��
	$CopyMap1305State1 =  GetWord(%Text,1) * 1;//��Ӫ1����
	$CopyMap1305State2 =  GetWord(%Text,2) * 1;//��Ӫ2����
	$CopyMap1305State3 =  GetWord(%Text,3) * 1;//��������
	$CopyMap1305State4 =  GetWord(%Text,4) * 1;//���˻�������
	$CopyMap1305State5 =  GetWord(%Text,5) * 1;//����������

	if ($CopyMap1305State0 <= 0)
		%Text0 = "ս���ѽ���";
	else
	{
		%M = mfloor($CopyMap1305State0/60);
		%S = $CopyMap1305State0%60;
		if (%M <= 9)
			%M = "0" @ %M;
		if (%S <= 9)
			%S = "0" @ %S;
		%Text0 = %M @ "��" @ %S;
	}

	FBMessageAppear();	//�򿪸�����Ϣ����
	%Title = $Get_Dialog_GeShi[11400];	//����
	%XiaoBiaoTi = $Get_Dialog_GeShi[31201];	//Xiao����
	FBProgressMessage.clearitem();

	%Node[1] = AddFBProgressNode(0,%Title @ "��ս���ſ���</t>",1,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "��ʣ��ʱ�䣺" @ %Text0 @ "</t>",1*100 + 0,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "���쵶��Ӫ��" @ $CopyMap1305State1 @ " ��</t>",1*100 + 1,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "������Ӫ��" @ $CopyMap1305State2 @ " ��</t>",1*100 + 2,0);

	%Node[2] = AddFBProgressNode(0,%Title @ "���������ݡ�</t>",2,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "��������Ӫ��" @ %ForceName @ "</t>",2*100 + 0,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "��ս��������" @ $CopyMap1305State3 @ "</t>",2*100 + 1,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "�����ܵо���" @ $CopyMap1305State4 @ "</t>",2*100 + 2,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "���ɼ����ʣ�" @ $CopyMap1305State5 * 1 @ "/5" @ "</t>",2*100 + 3,0);
	FBProgressMessage.buildVisibleTree(0);

	$CopyMap1305State0--;
	%Text = $CopyMap1305State0 @ " " @ $CopyMap1305State1 @ " " @ $CopyMap1305State2 @ " " @ $CopyMap1305State3 @ " " @ $CopyMap1305State4 @ " " @ $CopyMap1305State5;
	if ($CopyMap1305State0 > 0)
		$DaoJianShenYuFuBenTongJiWnd = schedule(1000,0,"DaoJianShenYuFuBenTongJiWnd",%Player,%Text);
}
//���������������������������������������
