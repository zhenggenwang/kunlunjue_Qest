//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//��������
//==================================================================================
//AiBuff_Trigger_Remove( %Player,%Mid )	//buff�Ƴ�ͳһ������������Ҫ��buffskilldata������
/*
===================================================================================
ע�����нű���ͷ������ע�����ű��Ĵ���˵������


���ܣ���������

===================================================================================
*/
//������������������������������NPC �Ի���������������������
//�����������������������������������ȡǰ���жϡ�������������
//�����������������������������������ȡʱ������������������
//�������������������������������������ǰ���жϡ�������������
//�������������������������������������ʱ������������������
//�����������������������������������ͼ����������������������
//��������������������������������һ�����ҡ�����������������
//�������������������������������ɼ���������������������������
//������������������������������������������������������������

//������������������������������NPC �Ի���������������������
function BingHuoShiLian_DiaLog(%Npc,%Player,%State,%Conv)
{
	if ($SL_BingHuoShiLian_State_bActive != 1)
		return;
	%NpcID = %Npc.GetDataID();
	%Level = %Player.GetLevel();
	if (%Level <= 44) %MidJia = 0;
	else if (%Level <= 59) %MidJia = 8;
	else if (%Level <= 75) %MidJia = 16;

	//echo( " %State=== " @  %State );
	switch (%State)
	{
		case 0:
			%Conv.Settext(600000080);
			switch (%Npcid)
			{
				case 411200001:%Optype = 1;//��ǧѰ	����ʹ��
				case 411200002:%Optype = 2;//���	��֮ʥʹ
				case 411200003:%Optype = 3;//����	��֮ʥʹ
				case 411210001:%Optype = 1;//��ǧѰ	����ʹ��
				case 411210002:%Optype = 2;//���	��֮ʥʹ
				case 411210003:%Optype = 3;//����	��֮ʥʹ
				case 411220001:%Optype = 1;//��ǧѰ	����ʹ��
				case 411220002:%Optype = 2;//���	��֮ʥʹ
				case 411220003:%Optype = 3;//����	��֮ʥʹ
			}
			switch (%optype)
			{
				case 1://��ǧѰ	����ʹ��
					//echo( 20006 + %MidJia );
					//echo( GetSrc( %Player, 55 ) );
					//echo( !%player.IsAcceptedMission( 20006 + %MidJia ) );
					if (GetSrc(%Player,49) == 0 && !%player.IsAcceptedMission(20005 + %MidJia))%Conv.AddOption(600000085,600000085);
					if (GetSrc(%Player,54) == 0 && !%player.IsAcceptedMission(20006 + %MidJia))%Conv.AddOption(600000086,600000086);
					if (GetSrc(%Player,56) == 0 && !%player.IsAcceptedMission(20008 + %MidJia))%Conv.AddOption(600000087,600000087);
				case 2://���	��֮ʥʹ
					if (GetSrc(%Player,40) == 0 && !%player.IsAcceptedMission(20001 + %MidJia))%Conv.AddOption(600000081,600000081);
					if (GetSrc(%Player,42) == 0 && !%player.IsAcceptedMission(20003 + %MidJia))%Conv.AddOption(600000083,600000083);
				case 3://����	��֮ʥʹ
					if (GetSrc(%Player,41) == 0 && !%player.IsAcceptedMission(20002 + %MidJia))%Conv.AddOption(600000082,600000082);
					if (GetSrc(%Player,43) == 0 && !%player.IsAcceptedMission(20004 + %MidJia))%Conv.AddOption(600000084,600000084);
			}
		case 600000081: %Mid = 20001  + %MidJia; %MidName = "Mission_Begin_Front_"@ %Mid; %Txt = eval(%MidName @ "(%Npc, %Player, %Conv, %Param, %Mid);"); if (%Txt $= "")AddMissionAccepted(%Player,%Conv,%Mid); return BingHuoShiLian_DiaLog(%Npc,%Player,0,%Conv);// ����֮��
		case 600000082: %Mid = 20002  + %MidJia; %MidName = "Mission_Begin_Front_"@ %Mid; %Txt = eval(%MidName @ "(%Npc, %Player, %Conv, %Param, %Mid);"); if (%Txt $= "")AddMissionAccepted(%Player,%Conv,%Mid); return BingHuoShiLian_DiaLog(%Npc,%Player,0,%Conv);// �һ�֮��
		case 600000083: %Mid = 20003  + %MidJia; %MidName = "Mission_Begin_Front_"@ %Mid; %Txt = eval(%MidName @ "(%Npc, %Player, %Conv, %Param, %Mid);"); if (%Txt $= "")AddMissionAccepted(%Player,%Conv,%Mid); return BingHuoShiLian_DiaLog(%Npc,%Player,0,%Conv);// �������
		case 600000084: %Mid = 20004  + %MidJia; %MidName = "Mission_Begin_Front_"@ %Mid; %Txt = eval(%MidName @ "(%Npc, %Player, %Conv, %Param, %Mid);"); if (%Txt $= "")AddMissionAccepted(%Player,%Conv,%Mid); return BingHuoShiLian_DiaLog(%Npc,%Player,0,%Conv);// ��������
		case 600000085: %Mid = 20005  + %MidJia; %MidName = "Mission_Begin_Front_"@ %Mid; %Txt = eval(%MidName @ "(%Npc, %Player, %Conv, %Param, %Mid);"); if (%Txt $= "")AddMissionAccepted(%Player,%Conv,%Mid); return BingHuoShiLian_DiaLog(%Npc,%Player,0,%Conv);// ��װ��ҩ
		case 600000086: %Mid = 20006  + %MidJia; %MidName = "Mission_Begin_Front_"@ %Mid; %Txt = eval(%MidName @ "(%Npc, %Player, %Conv, %Param, %Mid);"); if (%Txt $= "")AddMissionAccepted(%Player,%Conv,%Mid); return BingHuoShiLian_DiaLog(%Npc,%Player,0,%Conv);// ����֮��
		case 600000087: %Mid = 20008  + %MidJia; %MidName = "Mission_Begin_Front_"@ %Mid; %Txt = eval(%MidName @ "(%Npc, %Player, %Conv, %Param, %Mid);"); if (%Txt $= "")AddMissionAccepted(%Player,%Conv,%Mid); return BingHuoShiLian_DiaLog(%Npc,%Player,0,%Conv);// ������ħ
	}
}

//������������������������������NPC �Ի���������������������


//�����������������������������������ȡʱ������������������
function Mission_Begin_Process_20001(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,9100); }//����֮��
function Mission_Begin_Process_20002(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,9100); }//�һ�֮��
function Mission_Begin_Process_20003(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//�������
function Mission_Begin_Process_20004(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//��������
function Mission_Begin_Process_20005(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,9100); }//��װ��ҩ
function Mission_Begin_Process_20006(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,9100); }//����֮�顤һ
function Mission_Begin_Process_20007(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//����֮�顤��
function Mission_Begin_Process_20008(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//������ħ
function Mission_Begin_Process_20009(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,9100); }//����֮��
function Mission_Begin_Process_20010(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,9100); }//�һ�֮��
function Mission_Begin_Process_20011(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//�������
function Mission_Begin_Process_20012(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//��������
function Mission_Begin_Process_20013(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,9100); }//��װ��ҩ
function Mission_Begin_Process_20014(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,9100); }//����֮�顤һ
function Mission_Begin_Process_20015(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//����֮�顤��
function Mission_Begin_Process_20016(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//������ħ
function Mission_Begin_Process_20017(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,9100); }//����֮��
function Mission_Begin_Process_20018(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,9100); }//�һ�֮��
function Mission_Begin_Process_20019(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//�������
function Mission_Begin_Process_20020(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//��������
function Mission_Begin_Process_20021(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,9100); }//��װ��ҩ
function Mission_Begin_Process_20022(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,9100); }//����֮�顤һ
function Mission_Begin_Process_20023(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//����֮�顤��
function Mission_Begin_Process_20024(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//������ħ


function Mission_Begin_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,%Flag)
{
	//echo("%Mid===" @ %Mid);
	if (%Mid == 20006 || %Mid == 20014 || %Mid == 20022)
	{
		if (GetSrc(%Player,50) == 0)
			AddMissionAccepted(%Player,%Conv,%Mid + 1);
	}
	if (%Flag > 0)
	{
		%Player.SetMissionFlag(%Mid,%Flag,1);
		%Player.UpdateMission(%Mid);
	}

}

function Mission_Begin_Process_20025(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20025_20027(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_Begin_Process_20026(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20025_20027(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_Begin_Process_20027(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20025_20027(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_Begin_Process_20025_20027(%Npc,%Player,%Conv,%Param,%Mid)
{
	%Player.SetMissionFlag(%Mid,9100,1);
	%Player.UpdateMission(%Mid);
}
//�����������������������������������ȡʱ������������������

//�������������������������������������ʱ������������������
function Mission_End_Process_20001(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,40,0); }//����֮��
function Mission_End_Process_20002(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,41,0); }//�һ�֮��
function Mission_End_Process_20003(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,42,0); }//�������
function Mission_End_Process_20004(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,43,0); }//��������
function Mission_End_Process_20005(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,44,"399030001 399040001"); }//��װ��ҩ
function Mission_End_Process_20006(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,50,"399060001 399060002 399060003"); }//����֮�顤һ
function Mission_End_Process_20007(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,55,0); }//����֮�顤��
function Mission_End_Process_20008(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,56,0); }//������ħ
function Mission_End_Process_20009(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,40,0); }//����֮��
function Mission_End_Process_20010(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,41,0); }//�һ�֮��
function Mission_End_Process_20011(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,42,0); }//�������
function Mission_End_Process_20012(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,43,0); }//��������
function Mission_End_Process_20013(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,44,"399030001 399040001"); }//��װ��ҩ
function Mission_End_Process_20014(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,50,"399060001 399060002 399060003"); }//����֮�顤һ
function Mission_End_Process_20015(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,55,0); }//����֮�顤��
function Mission_End_Process_20016(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,56,0); }//������ħ
function Mission_End_Process_20017(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,40,0); }//����֮��
function Mission_End_Process_20018(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,41,0); }//�һ�֮��
function Mission_End_Process_20019(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,42,0); }//�������
function Mission_End_Process_20020(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,43,0); }//��������
function Mission_End_Process_20021(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,44,"399030001 399040001"); }//��װ��ҩ
function Mission_End_Process_20022(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,50,"399060001 399060002 399060003"); }//����֮�顤һ
function Mission_End_Process_20023(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,55,0); }//����֮�顤��
function Mission_End_Process_20024(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,56,0); }//������ħ

function  Mission_End_Process_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,%Src,%NeedBuff)
{
	//------------------��¼�Ѿ����--------------------
	if (%Src == 44 || %Src == 50)//���⴦��
	{
		for (%i = 0; %i <= 4; %i++)
		{
			if (GetSrc(%Player,%Src + %i) == 0)
			{
				SetSrc(%Player,%Src + %i);
				%NowState = %i + 1;
				if (%Src + %i == 48)
					SetSrc(%Player,49);//��¼��ҩ����ȫ�����
				if (%Src == 50)//����Ǳ���֮�顣һ ���±���֮�������
				{
					%NowFlag = %Src + %i - 49;
					%NowMid = %Mid + 1;
					if (%Player.IsAcceptedMission(%NowMid))
					{
						%Player.SetMissionFlag(%NowMid,3300,%NowFlag);
						%Player.UpdateMission(%NowMid);
					}
				}
				break;
			}
		}
	}
	else SetSrc(%Player,%Src);
	//-------------------------------------------------
	//--------------------��������----------------------
	%Level = %Player.GetLevel();
	if (%Level < 30) %LevelXiShu = 0.5;
	else if (%Level < 40) %LevelXiShu = 1.2;
	else if (%Level < 50) %LevelXiShu = 1.2;
	else if (%Level < 60) %LevelXiShu = 1.6;
	else if (%Level < 70) %LevelXiShu = 2.0;
	else %LevelXiShu = 2.2;

	if (%Level < 25) %LVExp = 0;
	else if (%Level < 40) %LVExp = 20000;
	else if (%Level < 50) %LVExp = 30000;
	else if (%Level < 60) %LVExp = 50000;
	else if (%Level < 70) %LVExp = 80000;
	else if (%Level < 80) %LVExp = 100000;
	else if (%Level < 90) %LVExp = 120000;
	else  %LVExp = 120000;

	switch ((%Mid - 20000)%8)
	{
		case 1://����֮��
			%LikeMonSterNum = 60;
			%PinZhiXiShu = 1;
		case 2://�һ�֮��
			%LikeMonSterNum = 60;
			%PinZhiXiShu = 1;
		case 3://�������
			%LikeMonSterNum = 100;
			%PinZhiXiShu = 1;
		case 4://��������
			%LikeMonSterNum = 100;
			%PinZhiXiShu = 1;
		case 5://��װ��ҩ
			if (%NowState == 5)
			{
				%PinZhiXiShu = 1.1; //80ֻ1.0 80ֻ1.2 ƽ��1.1
				%LikeMonSterNum = 160;
			}
			else
			{
				%LikeMonSterNum = 80;
				switch (%NowState)
				{
					case 1:%PinZhiXiShu = 0.6;
					case 2:%PinZhiXiShu = 0.7;
					case 3:%PinZhiXiShu = 0.8;
					case 4:%PinZhiXiShu = 0.9;
				}
			}
			//echo("GetSrc(%Player, 49) ====" @ GetSrc(%Player, 49) @ "   " @ %Mid);
			if (GetSrc(%Player, 49) == 0)
				Schedule(200, 0, "AddMissionAccepted", %Player, 0, %Mid);
		case 6://����֮�顤һ
			%LikeMonSterNum = 100;
			if (%Player.GetBuffCount(39906,1) >= 1) %PinZhiXiShu = 1;
			else if (%Player.GetBuffCount(39906,2) >= 1) %PinZhiXiShu = 2;
			else if (%Player.GetBuffCount(39906,3) >= 1) %PinZhiXiShu = 4;

			%NeedMid = %Mid + 1;
			//echo( "%NeedMid======" @ %NeedMid );
			if (%player.IsAcceptedMission(%NeedMid))
			{
				%NeedFalg = %Player.GetMissionFlag(%NeedMid,10330);
				//echo( "%NeedFalg======" @ %NeedFalg );
				%Player.SetMissionFlag(%NeedMid,10330,%NeedFalg + %PinZhiXiShu);
				Schedule(1000,0,"eval",%Player @ ".UpdateMission(" @ %NeedMid @ "); ");
			}
			//echo("GetSrc(%Player, 54) ====" @ GetSrc(%Player, 54) @ "   " @ %Mid);
			if (GetSrc(%Player, 54) == 0)
				Schedule(200, 0, "AddMissionAccepted",%Player,0,%Mid);
		case 7://����֮�顤��
			%LikeMonSterNum = 100;
			%NeedFalg = %Player.GetMissionFlag(%Mid,10330);
			%PinZhiXiShu = %NeedFalg * 0.3;

			%Ran = GetRanDom(1,10);
			if (%Ran <= 1)
			{
				%Player.PutItem(105180090,1);
				%Player.Additem(1,%Mid);
			}
		case 0://������ħ
			%LikeMonSterNum = 300;
			%PinZhiXiShu = 1;

			%Ran = GetRanDom(1,10);
			if (%Ran <= 1)
			{
				%Player.PutItem(105180070,1);
				%Player.Additem(1,%Mid);
			}
	}
	%MonSterExp = $Monster_Exp[%Level,1];
	%Exp = %MonSterExp *(%LikeMonSterNum + %Level) * %PinZhiXiShu * %LevelXiShu + %LVExp;
	AllAddExp(%Player,%Exp);
	//---------------------���������������------------
	if (%Src != 55)
		BingHuoShiLian_10801(%Player,10801);
	//---------------------���BUFF---------------------
	//echo( "%NeedBuff====" @ %NeedBuff );
	if (%NeedBuff != 0)
	{
		for (%i = 0; %i <= 2; %i++)
		{
			%Buff = getword(%NeedBuff,%i);
			//echo( "%Buff====" @ %Buff );
			if (%Buff $= "" || %Buff == 0)
				break;
			//echo( GetSubStr( %Buff, 0, 5 ) );
			//echo( GetSubStr( %Buff, 5, 4 ) );
			//echo( %Player.GetBuffCount( GetSubStr( %Buff, 0, 5 ), GetSubStr( %Buff, 5, 4 ) ));
			if (%Player.GetBuffCount(GetSubStr(%Buff,0,5),GetSubStr(%Buff,5,4)) >= 1)
				%Player.RemoveBuff(%Buff);
		}
	}
	%ActC = GetSrc(%Player,40) +  GetSrc(%Player,41) +  GetSrc(%Player,42) +  GetSrc(%Player,43) +  GetSrc(%Player,49) +  GetSrc(%Player,55) +  GetSrc(%Player,56);
	if (%ActC == 7)
		AddAchievementWatch(%Player,0,31,1);//��¼�ɾ�
}
function Mission_End_Process_20025(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20025_20027(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_20026(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20025_20027(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_20027(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20025_20027(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_20025_20027(%Npc,%Player,%Conv,%Param,%Mid)
{
	%ItemCount[1] = %Player.GetitemCount(108020006);//����֮��
	%ItemCount[2] = %Player.GetitemCount(108020007);//����֮�
	%ItemCount[3] = %Player.GetitemCount(108020008);//����֮צ
	if (%ItemCount[1] >= %ItemCount[2])
		%Count = %ItemCount[2];
	else
		%Count = %ItemCount[1];
	if (%ItemCount[3] <  %Count)
		%Count = %ItemCount[3];
	%Count = mfloor(%Count/10)*10;
	if (%Count < 10)
		%Count = 10;
	%Player.PutItem(108020006,-%Count);
	%Player.PutItem(108020007,-%Count);
	%Player.PutItem(108020008,-%Count);
	if (%Player.additem(1,%Mid))
	{
		%Level = %Player.GetLevel();
		if (%Level < 30) %LevelXiShu = 0.5;
		else if (%Level < 40) %LevelXiShu = 1.0;
		else if (%Level < 50) %LevelXiShu = 1.2;
		else if (%Level < 60) %LevelXiShu = 1.6;
		else if (%Level < 70) %LevelXiShu = 2.0;
		else %LevelXiShu = 2.2;

		if (%Level < 25) %LVExp = 0;
		else if (%Level < 40) %LVExp = 20000;
		else if (%Level < 50) %LVExp = 30000;
		else if (%Level < 60) %LVExp = 50000;
		else if (%Level < 70) %LVExp = 80000;
		else if (%Level < 80) %LVExp = 100000;
		else if (%Level < 90) %LVExp = 120000;
		else  %LVExp = 120000;

		%LikeMonSterNum = 300 * %Count/10;
		%PinZhiXiShu = 1;

		%MonSterExp = $Monster_Exp[%Level,1];
		%Exp = %MonSterExp *(%LikeMonSterNum + %Level) * %PinZhiXiShu * %LevelXiShu + %LVExp;
		AllAddExp(%Player,%Exp);
	}

}
//�������������������������������������ʱ������������������


//�������������������������������ɼ���������������������������
function TriggerEvent_552000004(%Player,%Event,%EventID){ TriggerEvent_552000004_552000009(%Player,%Event,%EventID,20001,0,"����֮˪"); }//����֮˪
function TriggerEvent_552000005(%Player,%Event,%EventID){ TriggerEvent_552000004_552000009(%Player,%Event,%EventID,20002,0,"�һ�֮��"); }//�һ�֮��
function TriggerEvent_552000006(%Player,%Event,%EventID){ TriggerEvent_552000004_552000009(%Player,%Event,%EventID,20005,399030001,"��ҩ"); }//��ҩ
function TriggerEvent_552000007(%Player,%Event,%EventID){ TriggerEvent_552000004_552000009(%Player,%Event,%EventID,20006,399060001,"��ʯ"); }//��ʯ
function TriggerEvent_552000008(%Player,%Event,%EventID){ TriggerEvent_552000004_552000009(%Player,%Event,%EventID,20006,399060002,"��ʯ"); }//��ʯ
function TriggerEvent_552000009(%Player,%Event,%EventID){ TriggerEvent_552000004_552000009(%Player,%Event,%EventID,20006,399060003,"��ʯ"); }//��ʯ
function TriggerEvent_552000004_552000009(%Player,%Event,%EventID,%MidList,%BuffID,%Name)
{
	%Level = %Player.GetLevel();
	if (%Level <= 44) %MidJia = 0;
	else if (%Level <= 59) %MidJia = 8;
	else if (%Level <= 75) %MidJia = 16;

	%Mid = %MidList + %MidJia;
	//echo( "%Mid===" @ %Mid @ "    " @ %player.IsAcceptedMission( %Mid ) );
	if (%player.IsAcceptedMission(%Mid))
	{
		%NeedFlag = %Player.GetMissionFlag(%Mid,3200);
		%HaveFlag = %Player.GetMissionFlag(%Mid,3300);
		//echo( "%NeedFlag===" @ %NeedFlag );
		//echo( "%HaveFlag===" @ %HaveFlag );
		if (%NeedFlag > 1 && %HaveFlag < %NeedFlag)
			%HaveFlag++;
		else if (%NeedFlag == 1)
			%HaveFlag = 1;
		//echo( "%HaveFlag===" @ %HaveFlag );
		SendOneScreenMessage(1,"��á�" @ %Name @ "�� "@ %HaveFlag @ "/" @ %NeedFlag,%Player);
		%Player.SetMissionFlag(%Mid,3300,%HaveFlag);
		%Player.UpdateMission(%Mid);

		if (%BuffID > 0)
			%Player.Addbuff(%BuffID,%Player,1);
		return 0;
	}
	else
	{
		//switch ( %EventID )
		//{
		//	case 552000004:%MidID = 20001 + %MidJia;  %Src = 40;
		//	case 552000005:%MidID = 20002 + %MidJia;  %Src = 41;
		//	case 552000006:%MidID = 20005 + %MidJia;  %Src = 49;
		//	case 552000007:%MidID = 20006 + %MidJia;  %Src = 54;
		//	case 552000008:%MidID = 20006 + %MidJia;  %Src = 54;
		//	case 552000009:%MidID = 20006 + %MidJia;  %Src = 54;
		//}
		//if ( GetSrc( %Player, %Src ) == 1 )
		//{
		//	SendOneScreenMessage( 2, "���Ѿ���ɸ����񣬲���Ҫ�ٲɼ���", %Player );
		//	SendOneChatMessage( $chatMsg_System, "<t>���Ѿ���ɸ����񣬲���Ҫ�ٲɼ���</t>", %Player );
		//}
		//else
		//{
		//	%MidName = "Mission_Begin_Front_"@ %MidID;
		//	%Txt = eval( %MidName @ "(0, %Player, 0, 0, %MidID);" );
		//	//echo( "%Txt===" @ %Txt );
		//	if ( %Txt$= "" )
		//	{
		//		//echo( "%MidID===" @ %MidID );
		//		AddMissionAccepted( %Player, 0, %MidID );
		//		%MidName = "TriggerEvent_"@ %EventID;
		//		eval( %MidName @ "(%Player, %Event, %EventID);" );
		//	}
		//	else
		//	{
		//		SendOneScreenMessage( 2, "��ĵȼ����ʺϵ�ǰ��ͼ���ɼ�ʧ��", %Player );
		//		SendOneChatMessage( $chatMsg_System, "<t>��ĵȼ����ʺϵ�ǰ��ͼ���ɼ�ʧ��</t>", %Player );
		//	}
		//}
		SendOneScreenMessage(2, "���Ƚ�ȡ��Ӧ����������", %Player);
		SendOneChatMessage($chatMsg_System, "<t>���Ƚ�ȡ��Ӧ����������</t>", %Player);
		return 0;
	}
}
//�������������������������������ɼ���������������������������

//�����������������������������������ͼ����������������������
function BingHuoShiLianChuLi(%Player)
{
	%MapID = GetZoneid();

	%Level = %Player.GetLevel();
	if (%Level <= 44){ %MidA = 20005; %MidB = 20006; }
	else if (%Level <= 59) { %MidA = 20013; %MidB = 20014; }
	else if (%Level <= 75) { %MidA = 20021; %MidB = 20022; }

	if (%Player.IsAcceptedMission(%MidA))
	{
		//putout("�������� ��������====" @ %MidA);
		%Player.SetMissionFlag(%MidA, 3300, 0);
		%Player.UpdateMission(%MidA);
	}
	if (%Player.IsAcceptedMission(%MidB))
	{
		//putout("�������� ��������====" @ %MidB);
		%Player.SetMissionFlag(%MidB, 3300, 0);
		%Player.UpdateMission(%MidB);
	}

	if (%MapID != 1120 && %MapID != 1121 && %MapID != 1122)
		return;
	if ($SL_BingHuoShiLian_State_bActive != 1)
	{
		for (%i = 20001; %i <= 20024; %i++)
		{
			if (%player.IsAcceptedMission(%i))
				%Player.DelMission(%i);
		}
	}
	else
	{
		%Level = %Player.GetLevel();
		if (%Level <= 44) %MidJia = 0;
		else if (%Level <= 59) %MidJia = 8;
		else if (%Level <= 75) %MidJia = 16;
		for (%i = 20001; %i<= 20008; %i++)
		{
			%RightMid = %i + %MidJia;
			for (%j = 0; %j<= 2; %j++)
			{
				%NowMid = %i + %j * 8;
				if (%player.IsAcceptedMission(%NowMid) && %NowMid != %RightMid)
				{
					//echo( "��ǰ����====" @ %NowMid @ "      ������ӵ�����====" @ %RightMid );
					%Player.DelMission(%NowMid);
					AddMissionAccepted(%Player,0,%RightMid);
					break;
				}
			}
		}
	}
}
//�����������������������������������ͼ����������������������

//��������������������������������һ�����ҡ�����������������
function IceFire_PvP_BeKill(%Player,%Killer)
{
	if (%Player.GetBuffCount(39903,1) >= 1)
	{
		%Player.RemoveBuff(399040001);
		%Player.RemoveBuff(399030001);
		SendOneScreenMessage(2,"��Ĳ�ҩ�Ѿ���ʧ�����»�ȥ�ɼ���",%Player);
		SendOneChatMessage($chatMsg_System,"<t>��Ĳ�ҩ�Ѿ���ʧ�����»�ȥ�ɼ���</t>",%Player);

		%Level = %Player.GetLevel();
		if (%Level <= 44) %Mid = 20005;
		else if (%Level <= 59) %Mid = 20013;
		else if (%Level <= 75) %Mid = 20021;

		%Player.SetMissionFlag(%Mid,3300,0);
		%Player.UpdateMission(%Mid);
	}
	for (%i = 1; %i <= 3; %i++)
	{
		if (%Player.GetBuffCount(39906,%i) >=1)
			%PLv = %i;
		if (%Killer.GetBuffCount(39906,%i) >=1)
			%KLv = %i;
	}
	if (%PLv > 0)
	{
		%Player.RemoveBuff(399060000 + %PLv);

		SendOneScreenMessage(2, "�����ʯ�Ѿ���ʧ�����»�ȥ�ɼ���", %Player);
		SendOneChatMessage($chatMsg_System, "<t>�����ʯ�Ѿ���ʧ�����»�ȥ�ɼ���</t>", %Player);

		%Level = %Player.GetLevel();
		if (%Level <= 44) %Mid = 20006;
		else if (%Level <= 59) %Mid = 20014;
		else if (%Level <= 75) %Mid = 20022;

		%Player.SetMissionFlag(%Mid, 3300, 0);
		%Player.UpdateMission(%Mid);
	}
		

	%Level = %Killer.GetLevel();
	if (%Level <= 44) %Mid = 20006;
	else if (%Level <= 59) %Mid = 20014;
	else if (%Level <= 75) %Mid = 20022;
	if (%PLv > %KLv && %Killer.IsAcceptedMission(%Mid))
		%Killer.Addbuff(399060000 + %PLv,%Killer,1);
}
//��������������������������������һ�����ҡ�����������������



//������������������������������������������������������������
function KilledMonster_411200106(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411200106_411220108(%Player,%Monster,%SharePlayerNum,%MaxConnection,20025,108020006); }//��������
function KilledMonster_411200107(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411200106_411220108(%Player,%Monster,%SharePlayerNum,%MaxConnection,20025,108020007); }//��������
function KilledMonster_411200108(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411200106_411220108(%Player,%Monster,%SharePlayerNum,%MaxConnection,20025,108020008); }//��������
function KilledMonster_411210106(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411200106_411220108(%Player,%Monster,%SharePlayerNum,%MaxConnection,20026,108020006); }//��������
function KilledMonster_411210107(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411200106_411220108(%Player,%Monster,%SharePlayerNum,%MaxConnection,20026,108020007); }//��������
function KilledMonster_411210108(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411200106_411220108(%Player,%Monster,%SharePlayerNum,%MaxConnection,20026,108020008); }//��������
function KilledMonster_411220106(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411200106_411220108(%Player,%Monster,%SharePlayerNum,%MaxConnection,20027,108020006); }//��������
function KilledMonster_411220107(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411200106_411220108(%Player,%Monster,%SharePlayerNum,%MaxConnection,20027,108020007); }//��������
function KilledMonster_411220108(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411200106_411220108(%Player,%Monster,%SharePlayerNum,%MaxConnection,20027,108020008); }//��������
function KilledMonster_411200106_411220108(%Player,%Monster,%SharePlayerNum,%MaxConnection,%Mid,%ItemID)
{
	//echo( "%SharePlayerNum ===" @ %SharePlayerNum );
	if (!%player.IsAcceptedMission(%Mid))
		return;
	%Random = 1000;
	%Random = mfloor(%Random/%SharePlayerNum);
	%Ran = GetRandom(1,10000);
	if (%Ran <= %Random)
	{
		%Player.Putitem(%ItemID,1);
		%Player.Additem(1,%Mid);
	}
}

//������������������������������������������������������������
