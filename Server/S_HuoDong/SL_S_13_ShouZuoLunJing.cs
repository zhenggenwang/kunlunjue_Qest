//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//�����۾��
//==================================================================================
//���������������۾�������������ȫ�ֱ�����������������
//���������������۾��������������������������������
//���������������۾�����������������̡�������������
//���������������۾����������������Ϳͻ�����Ϣ��������
//���������������۾������������������ɼ������������
//���������������۾��������������ɼ�������������������
//���������������۾�������������Npc�Ի���������������


//���������������۾��������������������������������
function ShouZuoLunJingHuoDongStart(%YY,%MM,%DD,%H,%M,%S)
{
	if (GetZoneID() != 1010)
		return;
	if ($SL_ShouZuoLunJing_bActive != 1)
		return;
	%Nowtime = %H * 60 + %M;
	%Starttime = getword($SL_ShouZuoLunJing_StartTime,0,":") * 60 + getword($SL_ShouZuoLunJing_StartTime,1,":");
	%Endtime = getword($SL_ShouZuoLunJing_EndTime,0,":") * 60 + getword($SL_ShouZuoLunJing_EndTime,1,":");
	%Path = "<l i='810100100 9.78292 67.6866 135.177' t='path'/>";

	%HuoDongMingCheng = GetHuoDongName("�����۾�",1);

	%Text = "";
	if (%Starttime -  %Nowtime  == 10)
	{
		%Text = %HuoDongMingCheng @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ "10</t><t>���Ӻ�����" @ $SL_ShouZuoLunJing_Level @ "��������ʿ��ǰ��</t>" @ %Path @ "<t>�μӻ��</t>";
		%Text2 = GetHuoDongName("�����۾�",2) @ "<t>����</t>" @ $Get_Dialog_GeShi[60002]  @ "10</t><t>���Ӻ���</t>";
	}
	if (%Starttime -  %Nowtime  == 5)
	{
		%Text = %HuoDongMingCheng @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ "5</t><t>���Ӻ�����" @ $SL_ShouZuoLunJing_Level @ "��������ʿ��ǰ��</t>" @ %Path @ "<t>�μӻ��</t>";
		%Text2 = GetHuoDongName("�����۾�",2) @ "<t>����</t>" @ $Get_Dialog_GeShi[60002]  @ "5</t><t>���Ӻ���</t>";
	}
	if (%Starttime -  %Nowtime  == 1)
	{
		%Text = %HuoDongMingCheng @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ "1</t><t>���Ӻ�����" @ $SL_ShouZuoLunJing_Level @ "��������ʿ��ǰ��</t>" @ %Path @ "<t>�μӻ��</t>";
		%Text2 = GetHuoDongName("�����۾�",2) @ "<t>����</t>" @ $Get_Dialog_GeShi[60002]  @ "1</t><t>���Ӻ���</t>";
	}
	if (%Starttime -  %Nowtime  == 0)
	{
		%Text = %HuoDongMingCheng @ "<t>�Ѿ�������" @ $SL_ShouZuoLunJing_Level @ "��������ʿ��ǰ��</t>" @ %Path @ "<t>�μӻ��</t>";
		%Text2 = GetHuoDongName("�����۾�",2) @ "<t>�Ѿ�����</t>";
	}
	if (%Text !$= "")
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");
	if (%Text2 !$= "")
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);

	if ($SL_ShouZuoLunJing_State_bActive  == 1)
	{
		if ($ShouZuoLunJingIsBegin == 0)
		{
			$ShouZuoLunJingIsBegin = 1;
			if (!isobject($ShouZuoLunJingShi))
				$ShouZuoLunJingShi = SpNewNpc2(0,410100047,"10 72 135.199",0,90);
			if (!isobject($ShouZuoLunJingFei))
				$ShouZuoLunJingFei = SpNewNpc2(0,410100048,"10 58 135.199",0,90);
			if (!isobject($ShouZuoLunJingFaTi))
				$ShouZuoLunJingFaTi = SpNewNpc2(0,410100049,"10 65 135.198",0,90);
			if (isobject($LingJingWuDao[1]))
				$LingJingWuDao[1].Safedeleteobject();
			if (!isobject($ShouZuoLunJingJianKaoLaoShi))
				$ShouZuoLunJingJianKaoLaoShi = SpNewNpc2(0,410100050,"10 65 135.198",0,90);
			ShouZuoLunJingGoGoGo(-3);
		}
	}
	else
	{
		$ShouZuoLunJingIsBegin = 0;
		if (!isobject($LingJingWuDao[1]))
			$LingJingWuDao[1] = SpNewNpc2(0,410100023,"36.2311 55.2419 137.561",0,300);
	}
}
//���������������۾��������������������������������

//���������������۾�����������������̡�������������
function ShouZuoLunJingGoGoGo(%State)
{
	//echo( "%State ====" @ %State );
	Cancel($ShouZuoLunJingGoGoGo);//���������ʱ
	switch (%State)
	{
		case -3:
			SendAllChatMessage(0,"<t>�����۾�����1���Ӻ�ʼ��������ʿ����׼����</t>");
			%Time = 30;
		case -2:
			SendAllChatMessage(0,"<t>�����۾�����30���ʼ��������ʿ����׼����</t>");
			%Time = 20;
		case -1:
			SendAllChatMessage(0,"<t>�����۾�����10���ʼ��������ʿ����׼����</t>");
			%Time = 10;
		case 0:
			$ShouZuoLunJingRecord = 0;
			SendAllChatMessage(0, "<t>�����۾���ʼ��������ʿ׼����ʼ���⡣</t>");
			%Time = 1;
		default:
			$ShouZuoLunJingRecord++;
			if ($ShouZuoLunJingRecord > 30)
			{
				%HuoDongMingCheng = GetHuoDongName("�����۾�",1);
				%Path = "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100031);\",\"" @ $Get_Dialog_GeShi[31414] @ GetNpcData(410100031,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />";
				//echo( "%Path===" @ %Path );
				%Text = %HuoDongMingCheng @ "<t>�Ѿ�����������ʿ��ǰ��</t>" @ %Path @ "<t>��ȡ���⽱����</t>";
				//echo( "%Text===" @ %Text );
				%Text2 = GetHuoDongName("�����۾�",2) @ "<t>�Ѿ�������</t>";
				SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");
				SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);

				if (isobject($ShouZuoLunJingShi))
					$ShouZuoLunJingShi.Safedeleteobject();
				if (isobject($ShouZuoLunJingFei))
					$ShouZuoLunJingFei.Safedeleteobject();
				if (isobject($ShouZuoLunJingFaTi))
					$ShouZuoLunJingFaTi.Safedeleteobject();
				if (isobject($ShouZuoLunJingJianKaoLaoShi))
					$ShouZuoLunJingJianKaoLaoShi.Safedeleteobject();

				if (!isobject($LingJingWuDao[1]))
					$LingJingWuDao[1] = SpNewNpc2(0,410100023,"36.2311 55.2419 137.561",0,300);
				return;
			}
			if ($ShouZuoLunJingRecord%10 >= 1 && $ShouZuoLunJingRecord%10 <= 5)//������Ŀ
				%TiMuType = 1;
			else //�Ƿǵߵ���
				%TiMuType = 2;

			$ShouZuoLunJingQR = GetRandom(1,$HuoDong_BJCCC_MaxQuestionNum);
			switch (%TiMuType)
			{
				case 1:
					if ($HuoDong_BJCCC_A[$ShouZuoLunJingQR])
					{
						$ShouZuoLunJingRightTrid = "810100107";
						$ShouZuoLunJingWrongTrid = "810100108";
					}
					else
					{
						$ShouZuoLunJingRightTrid = "810100108";
						$ShouZuoLunJingWrongTrid = "810100107";
					}
				case 2:
					if ($HuoDong_BJCCC_A[$ShouZuoLunJingQR])
					{
						$ShouZuoLunJingRightTrid = "810100108";
						$ShouZuoLunJingWrongTrid = "810100107";
					}
					else
					{
						$ShouZuoLunJingRightTrid = "810100107";
						$ShouZuoLunJingWrongTrid = "810100108";
					}
			}
			//echo("�Ե�===" @ $ShouZuoLunJingRightTrid @ "     ���===" @  $ShouZuoLunJingWrongTrid  @ "     $ShouZuoLunJingRecord==" @ $ShouZuoLunJingRecord);
			$ShouZuoLunJingFaTi.Addbuff(390280001,$ShouZuoLunJingFaTi,1);
			Schedule(20000,0,"eval",$ShouZuoLunJingFaTi @ ".AddBuff(390290001," @ $ShouZuoLunJingFaTi @ ", 1 ); ");
			$ShouZuoLunJingQR = %TiMuType * 1000 + $ShouZuoLunJingQR;
			if ($ShouZuoLunJingRecord == 5 || $ShouZuoLunJingRecord == 10 || $ShouZuoLunJingRecord == 15 || $ShouZuoLunJingRecord == 20 || $ShouZuoLunJingRecord == 25)
			{
				%Time = 90;
				Schedule(30000,0,"SptCrateJingShu");
			}
			else
				%Time = 30;
	}
	$ShouZuoLunJingGoGoGo = Schedule(%Time * 1000,0,"ShouZuoLunJingGoGoGo",%State++);
}
//390280001����
//390290001����
//$ShouZuoLunJingFaTi.Addbuff( 390280001, $ShouZuoLunJingFaTi, 1 );
//���������������۾�����������������̡�������������


//���������������۾����������������Ϳͻ�����Ϣ��������
function ShouZuoLunJing_ShouDaoTiMu(%Player)//����ҷ���Ŀ
{
	if (%Player.GetLevel() < $SL_ShouZuoLunJing_Level)
		return;
	if (%Player.GetClassName() !$= "Player")
		return;
	//echo( "����Ŀ%Player===" @ %Player );
	if (%Player.GetLevel() < 30)
		return;
	ServerOnSptAction(%Player.GetPlayerID(),$ShouZuoLunJingQR,13);//ͨѶ�ͻ���
}
function ShouZuoLunJing_FaDaAn(%Player)//���� ����������Ϣ
{
	if (%Player.GetLevel() < $SL_ShouZuoLunJing_Level)
		return;
	if (%Player.GetClassName() !$= "Player")
		return;
	%Triggerid = %Player.GetTriggerID();
	//echo( "����%Player===" @ %Player.getobjectname( ) @ "   ��������===" @ %Triggerid );
	%Act0 = GetAct(%Player,4024,0);
	%Act1 = GetAct(%Player,4024,1);

	%Level = %Player.getlevel();
	if (%Level < 30) %levelxishu = 0.3;
	else if (%Level < 40) %levelxishu = 1;
	else if (%Level < 50) %levelxishu = 1.2;
	else if (%Level < 60) %levelxishu = 1.6;
	else if (%Level < 70) %levelxishu = 2;
	else %levelxishu = 2.2;

	%Exp_LeiJiaBeiShu = 0;
	if (%Player.ISschbuff(1997)) %Exp_LeiJiaBeiShu = 1;	  //���鵤�ļӳ�
	else if (%Player.ISschbuff(1998)) %Exp_LeiJiaBeiShu = 1.5; //���鵤�ļӳ�
	else if (%Player.ISschbuff(1999)) %Exp_LeiJiaBeiShu = 2;	  //���鵤�ļӳ�

	if (%Triggerid $=  $ShouZuoLunJingRightTrid) //�����
	{
		ServerOnSptAction(%Player.GetPlayerID(),7777,13);//ͨѶ�ͻ���
		%isright = 10;//��Խ�������
		%Act0++;
		AddBuffForDaTi(%Player,1);
	}
	else if (%Triggerid $= $ShouZuoLunJingWrongTrid)//����
	{
		ServerOnSptAction(%Player.GetPlayerID(),8888,13);//ͨѶ�ͻ���
		%isright = 4;//���������
		%Act1++;
		AddBuffForDaTi(%Player,2);
	}
	//���⾭�齱����EXP = ��ҵȼ����ﾭ�� * ��Դ����ϵ�� * �ȼ�ϵ��΢�� *˫��
	%Exp = $Monster_Exp[%Level,1] * %isright * %levelxishu *(1 + %Exp_LeiJiaBeiShu);
	AllAddExp(%Player,%Exp);
	SetAct(%Player,4024,%Act0,%Act1);
}
function AddBuffForDaTi(%Player,%Right)
{
	//echo( "%Player.GetBuffCount( 39026 ,1)===" @ %Player.GetBuffCount( 39026, 1 ) );
	//echo( "%Player.GetBuffCount( 39027 ,1)===" @ %Player.GetBuffCount( 39027, 1 ) );
	switch (%Right)
	{
		case 1:
			if (%Player.GetBuffCount(39027,1) >= 1)
				%Player.AddBuff(390270001,%Player,-1);
			else
				%Player.AddBuff(390260001,%Player,1);
		case 2:
			if (%Player.GetBuffCount(39026,1) >= 1)
				%Player.AddBuff(390260001,%Player,-1);
			else
				%Player.AddBuff(390270001,%Player,1);
	}
}
//���������������۾����������������Ϳͻ�����Ϣ��������

//���������������۾������������������ɼ������������
function SptCrateJingShu()
{
	%Posx = 10;
	%Posy = 65;
	for (%i = 1; %i<=5; %i++)
	{
		%RanX = GetRandom(%Posx - 7,%Posx + 7);
		%RanY = GetRandom(%Posy - 7,%Posy + 7);
		%Pos = %RanX @ " " @ %RanY @ " 135.98";
		SpNewCj2(0,553000017,%Pos,0,GetRandom(1,180),"0.4 0.4 0.4");
	}
	%JingShuName  = $Get_Dialog_GeShi[31422] @ "���۵����顿</t>";
	%Path = "<l i='810100100 10.1582 64.654 135.177' t='path'/>";
	%Text = %JingShuName @ "<t>������</t>" @ %Path @ "<t>��</t>";
	SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");
}
//���������������۾������������������ɼ������������

//���������������۾��������������ɼ�������������������
//function TriggerEvent_553000017( %Player, %Event, %EventID )
//{
//	%Ran = GetRandom( 1, 100 );
//	if ( %Ran <= 15 ) %ItemID  = 105109312;
//	else if ( %Ran <= 65 ) %ItemID  = 105109313;
//	else if ( %Ran <= 85 ) %ItemID  = 105109314;
//	else if ( %Ran <= 95 ) %ItemID  = 105109315;
//	else if ( %Ran <= 100 ) %ItemID  = 105109316;
//	%Player.Putitem( %ItemID, 1 );
//	%Player.additem( 4, %EventID );
//	%Event.Safedeleteobject( );
//	return 1;
//}
//���������������۾��������������ɼ�������������������


//���������������۾�������������Npc�Ի���������������
function ShouZuoLunJing_DiaLog(%Npc,%Player,%State,%Conv)
{
	%Act0 = GetAct(%Player,4024,0) * 1;
	%Act1 = GetAct(%Player,4024,0) * 1;
	%Src = GetSrc(%Player, 199);
	switch (%State)
	{
		case 0:
			%Conv.AddOption(600000077,600000077);
		case 600000077:
			%Conv.SetText(600000078);
			if (%Act0 + %Act1 > 0 && %Src == 0)
				%Conv.AddOption(600000079,600000079);
		case 600000079:
			%Conv.Settype(4);
			//�������	EXP =��(��Դ��� + ��������* 6 + max�������-�������0��* 9 )* �ȼ����ھ��� *�ȼ�ϵ��΢��
			%Level = %Player.getlevel();
			if (%Level < 30) %levelxishu = 0.3;
			else if (%Level < 40) %levelxishu = 1;
			else if (%Level < 50) %levelxishu = 1.2;
			else if (%Level < 60) %levelxishu = 1.6;
			else if (%Level < 70) %levelxishu = 2;
			else %levelxishu = 2.2;

			%right = %Act0 + %Act1;
			%worng = %Act0 - %Act1;
			if (%worng  < 0)
				%worng = 0;
			%exp = (%right * 6 + %worng * 9) * $Monster_Exp[%Level,1] * %levelxishu;
			AllAddExp(%Player,%exp);
			SendOneScreenMessage(1,"���ѳɹ���ȡ�۾�����",%Player);
			//SetAct(%Player,4024,0,0);
			SetSrc(%Player, 199);
			AddAchievementWatch(%Player,0,30,1);//��¼�ɾ�
	}
}


//���������������۾�������������Npc�Ի���������������

