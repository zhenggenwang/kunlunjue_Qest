//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//��������
//���߾���
//�������
//
//==================================================================================
//�������������������������������������߾��顿��������������������������������
function Mission_Special_10001(%Npc,%Player,%State,%Conv,%mid)//����ָ���Ի�����ʯ
{
	%PlayerID = %Player.GetPlayerID();
	%AAA = %Player.IsAcceptedMission(10001);//��ȡ����
	HelpDirectByIndex(%PlayerID,16);
	if (%AAA ==1)
	{
		switch (%state)
		{
			case 0:
				%Conv.SetText(511 @ %Mid);
				%Conv.AddOption(412 @ %Mid,412 @ %Mid);
			case 412 @ %Mid:
				%Conv.SetText(512 @ %Mid);
				%Conv.AddOption(413 @ %Mid,413 @ %Mid);
			case 413 @ %Mid:
				%Conv.SetText(513 @ %Mid);
				%Conv.AddOption(414 @ %Mid,414 @ %Mid);
			case 414 @ %Mid:
				%Conv.SetText(514 @ %Mid);
				%Conv.AddOption(415 @ %Mid,415 @ %Mid);
			case 415 @ %Mid:
				if (%Player.GetSex() == 1)//��
				{
					%Conv.SetText(515 @ %Mid);
					%Player.SetMission(10001,1);//�������
					Schedule(6000,0,"AddMissionAccepted",%Player,0,10002);//����һ������
					Schedule(3000,0,"OnSptActionEvent_S",%Player,9,%SubType);
				}
				else
				{
					%Conv.SetText(516 @ %Mid);
					%Player.SetMission(10001,1);//�������
					Schedule(6000,0,"AddMissionAccepted",%Player,0,10002);//����һ������
					Schedule(3000,0,"OnSptActionEvent_S",%Player,9,%SubType);
				}
		}
	}
	else
	{
		switch ( %state )
		{
			case 0:
				%Conv.SetText( 514 @ %Mid );
				%Conv.AddOption( 416 @ %Mid, 416 @ %Mid );
			case 416 @ %Mid:
				if ( %Player.GetSex( ) == 1 )//��
				{
					%Conv.SetText( 515 @ %Mid );
					Schedule( 6000, 0, "AddMissionAccepted", %Player, 0, 10002 );//����һ������
					Schedule( 3000, 0, "OnSptActionEvent_S", %Player, 9, %SubType );
				}
				else
				{
					%Conv.SetText( 516 @ %Mid );
					Schedule( 6000, 0, "AddMissionAccepted", %Player, 0, 10002 );//����һ������
					Schedule( 3000, 0, "OnSptActionEvent_S", %Player, 9, %SubType );
				}
		}
	}
}

function Mission_ChuanDaiZhuangBei_10151(%Player,%Mid)
{
	if (%Player.IsAcceptedMission(10151))
	{
		%Player.SetMissionFlag(%Mid,1350,1);
		SendOneScreenMessage(1,"����װ��  1/1",%Player);
		%Player.UpdateMission(%Mid);
	}
}
function Mission_Special_10191(%Npc,%Player,%State,%Conv,%mid)//����
{
	if (%Player.IsAcceptedMission(10191))//��ȡ����
	{
		%Type = %Player.GetMissionFlag(10191,1350);
		%Num = %Player.GetMissionFlag(10191,1250);
		if (%Type < %Num)
		{
			switch (%state)
			{
				case 0:
					%Conv.SetText(531 @ %Mid);
					%Conv.AddOption(431 @ %Mid,431 @ %Mid);
					%Conv.AddOption(432 @ %Mid,432 @ %Mid);
					%Conv.AddOption(433 @ %Mid,433 @ %Mid);
				case 431 @ %Mid:
					%Conv.SetText(532 @ %Mid);
					%Conv.AddOption(4,0);
				case 432 @ %Mid:
					%Conv.SetText(533 @ %Mid);
					%Conv.AddOption(4,0);
				case 433 @ %Mid:
					%Conv.SetText(534 @ %Mid);
					%Conv.AddOption(434 @ %Mid,434 @ %Mid);
				case 434 @ %Mid:
					%Conv.SetText(535 @ %Mid);
					%Conv.AddOption(435 @ %Mid,435 @ %Mid);
					%Conv.AddOption(436 @ %Mid,436 @ %Mid);
				case 435 @ %Mid:
					%Conv.SetText(536 @ %Mid);
					%Conv.AddOption( 438 @ %Mid, 438 @ %Mid );
				case 436 @ %Mid:
					%Conv.SetText(537 @ %Mid);
					%Conv.AddOption(437 @ %Mid,437 @ %Mid);
				case 437 @ %Mid:
					%Conv.SetText(538 @ %Mid);
					%Player.SetMissionFlag(%Mid,1350,1);
					SendOneScreenMessage(1,"�������  1/1",%Player);
					%Player.UpdateMission(%Mid);
				case 438 @ %Mid:
					%Conv.SetText( 535 @ %Mid );
					%Conv.AddOption( 435 @ %Mid, 435 @ %Mid );
					%Conv.AddOption( 436 @ %Mid, 436 @ %Mid );
			}
		}
	}
}

function Mission_End_Process_10163(%Npc,%Player,%Conv,%Param,%Mid)//ָ��ʹ������
{
	ServerOnSptAction(%Player.GetPlayerID(),119014025,1);
}
function TanKuangQueRen_10241(%Player)//����֮��  ����ȷ��
{
	if (%Player.IsAcceptedMission(10241))
	{
		%Player.SetMission(10241,1);//���
		%Player.AddExp(1000);
		AddMissionAccepted(%Player,0,10251);//����һ������
	}
}
function TanKuangQueRen_10291(%Player)//̽��Դͷ  ����ȷ��
{
	if (%Player.IsAcceptedMission(10291))
	{
		ChangeLogicFloor(%Player,0,%Player);//���뾵���
		%Player.SetMission(10291,1);//���
		%Player.AddExp(1500);
		AddMissionAccepted(%Player,0,10301);//����һ������
	}
}
function Mission_Special_10301(%Player,%mid)//������������
{
	if (!isobject(%Player.Monster_ShuYaoZhiLing))//�ж��������û��
	{
		%Monster = SpNewNpc(%Player,410101016,"138.038 -55.6684 144.906",0);
		%Monster.SetExclusivePlayerId(%Player.GetPlayerID()); //���ù����ռ���
		ChangeLogicFloor(%Monster,0,%Player);
		%Player.Monster_ShuYaoZhiLing = %Monster;
	}
}


function Mission_Special_10341(%Npc,%Player,%State,%Conv,%mid)//�����ܵ�
{
	%AAA = %Player.IsAcceptedMission(10341);

	if (%AAA >=1)
	{
		switch (%state)
		{
			case 0:
				%Conv.AddOption(418 @ %Mid,418 @ %Mid);
			case 418 @ %Mid:
				%player.TransportObject(0,0,-175.45,141.746,430.737);//��������
		}
	}
}

function XiaoDianYing_ChuFa_001(%Npc,%Player,%State,%Conv,%mid)
{
	//echo( "%Mid ====" @ %Mid @ "     " @ %Player.IsAcceptedMission( 10341 ) );
	if (%Player.IsAcceptedMission(10341))
	{
		//������Ҿ���
		ChangeLogicFloor(%Player,%Player,0);
		%player.Addbuff(390210001);  //��ʱ�������buff
		SendOneScreenMessage(1,"��á�������塿",%Player);
	}
}

function XiaoDianYing_ChuFa_003(%Npc,%Player,%State,%Conv,%mid)//���������Ѿ����
{
	if (%Player.IsAcceptedMission(10341))
	{
		%player.TransportObject(0,0,33.4158,115.416,135);//��������
		%Player.Removebuff(390210001);//ɾ�����buff
		ChangeLogicFloor(%Player,%Player,0);
		%Player.SetMission(10341,1);//���
		AddMissionAccepted(%Player,0,10351);//����һ������
		%Lv = %Player.getLevel();
		%Exp = %Player.getExp();
		if (%Lv < 29){ %Player.AddLevel(29 - %Lv); }
		if (%Lv <= 29) { %Player.AddExp(26950 - %Exp); }
	}
}
$XinShouRenWu_Monster_ID[1,1]  = "413031011";	$XinShouRenWu_Monster_XYZ[1,1] = "-178.419 140.165 430.717";	$XinShouRenWu_Monster_Ret[1,1] = "0  ";
$XinShouRenWu_Monster_ID[1,2]  = "410100057";	$XinShouRenWu_Monster_XYZ[1,2] = "-175.983 162.488 432.793";	$XinShouRenWu_Monster_Ret[1,2] = "180";
$XinShouRenWu_Monster_ID[1,3]  = "410100024";	$XinShouRenWu_Monster_XYZ[1,3] = "98.303 -206.185 108.364 ";	$XinShouRenWu_Monster_Ret[1,3] = "150";
$XinShouRenWu_Monster_ID[1,4]  = "410100025";	$XinShouRenWu_Monster_XYZ[1,4] = "100.461 -205.963 107.688";	$XinShouRenWu_Monster_Ret[1,4] = "180";
function XinShouRenWu_spnewnpc()//��������NPCˢ��
{
	//echo( "$XinShouRenWu_NPC =====================" @ $XinShouRenWu_NPC );
	if (getzoneid() < 1010 && getzoneid() > 1012)
		return;
	//if ( $XinShouRenWu_Npc_shuaxinjilu = 1 )//ˢ�¼�¼
	//	return;
	if ($XinShouRenWu_NPC < 1 && getzoneid() >= 1010 && getzoneid() <= 1012)
	{
		for (%i = 1; %i <= 4; %i++)
		{
			%Monster_ID = $XinShouRenWu_Monster_ID[1,%i];	//��ȡ���
			%Monster_XYZ = $XinShouRenWu_Monster_XYZ[1,%i];	//��ȡ����
			%Monster_Ret = $XinShouRenWu_Monster_Ret[1,%i];	//��ȡ����

			$XinShouRenWu_NPC =SpNewNpc2(0,%Monster_ID,%Monster_XYZ,0,%Monster_Ret);//����NPC
			ChangeLogicFloor($XinShouRenWu_NPC,0,1);

		}
		//$XinShouRenWu_Npc_shuaxinjilu = 1;//ˢ�¼�¼
	}
}
/*
$XinShouRenWu_Obj_ID[1,1]  = "553000037";	$XinShouRenWu_Obj_XYZ[1,1] = "-139.75 -121.252 106.699";
$XinShouRenWu_Obj_ID[1,2]  = "553000037";	$XinShouRenWu_Obj_XYZ[1,2] = "-143.245 -124.527 106.622";
$XinShouRenWu_Obj_ID[1,3]  = "553000037";	$XinShouRenWu_Obj_XYZ[1,3] = "-140.709 -129.22 106.736";
$XinShouRenWu_Obj_ID[1,4]  = "553000038";	$XinShouRenWu_Obj_XYZ[1,4] = "-143.314 11.727 117";//
$XinShouRenWu_Obj_ID[1,5]  = "553000038";	$XinShouRenWu_Obj_XYZ[1,5] = "-144.822 12.553 117";//
$XinShouRenWu_Obj_ID[1,6]  = "553000038";	$XinShouRenWu_Obj_XYZ[1,6] = "-151.302 13.282 117";//
$XinShouRenWu_Obj_ID[1,7]  = "553000039";	$XinShouRenWu_Obj_XYZ[1,7] = "-108.237 88.7385 125";
$XinShouRenWu_Obj_ID[1,8]  = "553000039";	$XinShouRenWu_Obj_XYZ[1,8] = "-104.215 93.8193 125";
$XinShouRenWu_Obj_ID[1,9]  = "553000039";	$XinShouRenWu_Obj_XYZ[1,9] = "-101.957 101.66 125";
function XinShouRenWu_spnewcj()//��������ɼ���ˢ��
{

	return;
	if ($XinShouRenWu_CJ < 1 && getzoneid() >= 1010 && getzoneid() <= 1012)
	{
		for (%i = 1; %i <= 9; %i++)
		{
			%Obj_ID = $XinShouRenWu_Obj_ID[1,%i];	//��ȡ���
			%Obj_XYZ = $XinShouRenWu_Obj_XYZ[1,%i];	//��ȡ����
			//Player �ɼ���ID ����  ���� ��С
			$XinShouRenWu_CJ =SpNewCj(0,%Obj_ID,%Obj_XYZ,0,"1 1 1");//�����ɼ�
			//$XinShouRenWu_CJ.AddPacket( 900158 );//�����Ч
		}
	}
}*/


function JianSingZhiYin_10781(%Player,%mid)//����ָ��
{
	//( "%mid =====================" @ %mid );
	%Player.SetMissionFlag(%Mid,1350,1);
	SendOneScreenMessage(1,"�������  1/1",%Player);
	%Player.UpdateMission(%Mid);
}
function QiangHuaZhiYin_10761(%Player,%mid)//ǿ��ָ��
{
	//echo( "%mid =====================" @ %mid );
	%Player.SetMissionFlag(%Mid,1350,1);
	SendOneScreenMessage(1,"ǿ�����  1/1",%Player);
	%Player.UpdateMission(%Mid);
}

function BingHuoShiLian_10801(%Player,%mid)//��������
{
	if (%Player.IsAcceptedMission(10801))
	{
		%FlagA = %Player.GetMissIonFlag(%Mid,1250);
		%FlagB = %Player.GetMissIonFlag(%Mid,1350);
		if (%FlagB < %FlagA)
			%FlagB++;
		%Player.SetMissionFlag(%Mid,1350,%FlagB);

		SendOneScreenMessage(1,"��������  " @ %FlagB @ "/" @ %FlagA,%Player);
		%Player.UpdateMission(%Mid);
	}
}
function ShiMenPaoHuan_20207(%Player,%mid)//ʦ���ܻ�
{
	//echo( "%mid =====================" @ %mid );
	%FlagA = %Player.GetMissIonFlag(%Mid,1250);
	%FlagB = %Player.GetMissIonFlag(%Mid,1350);
	if (%FlagB < %FlagA)
		%FlagB++;
	%Player.SetMissionFlag(%Mid,1350,%FlagB);

	SendOneScreenMessage(1,"ʦ�ž���  " @ %FlagB @ "/" @ %FlagA,%Player);
	%Player.UpdateMission(%Mid);
}
function TanKuangQueRen_10931(%Player)//������
{
	if (%Player.IsAcceptedMission(10931))
	{
		%Player.SetMissionFlag(10931,1350,1);
		SendOneScreenMessage(1,"̽�������  1/1",%Player);
		%Player.UpdateMission(10931);
	}
}
function TanKuangQueRen_10951(%Player,%Mid)//���ɿ�
{
	if (%Player.IsAcceptedMission(10951))
	{
		%Player.SetMissionFlag(%Mid,1350,1);
		SendOneScreenMessage(1,"�������ɿ�  1/1",%Player);
		%Player.UpdateMission(%Mid);
	}
}
function TanKuangQueRen_11021(%Player)//���ɿ߶���
{
	if (%Player.IsAcceptedMission(11021))
	{
		%Player.SetMissionFlag(11021,1350,1);
		SendOneScreenMessage(1,"���ɿ߶���  1/1",%Player);
		%Player.UpdateMission(11021);
	}
}
function ShiMenPaoHuan_11041(%Player,%mid)//��ɽѩ��
{
	%Player.SetMission(%mid,1);
	%Player.AddExp(26357);
	AddMissionAccepted(%Player,0,11051);
}
function ZhuXianRenWu_ChuanSong( %Player, %Mid )//����������ȷ�Ͽ�
{
	if ( %Player.IsAcceptedMission( %Mid ) )
	{
		switch ( %mid )
		{
			case 10871:GoToNextMap(%Player,"811010106","");//��������
			case 11031:GoToNextMap(%Player,"810010100","");//��������
			case 10841:GoToNextMap( %Player, 1010, "" );//���͵�ͼ
		}
	}
}
function TanKuangQueRen_11232( %Player ) //���ħ��
{
	if ( %Player.IsAcceptedMission( 11232 ) )
	{
		%Player.SetMissionFlag( 11232, 1350, 1 );
		SendOneScreenMessage( 1, "�⽣̨  1/1", %Player );
		%Player.UpdateMission( 11232 );
	}
}

//�������������������������������������߾��顿��������������������������������

//����������������������������������֧�����񡿡�������������������������������
function WangXianGu_YunYouYinShi_ShuaXin(%YY,%MM,%DD,%H,%M,%S)//������ʿ���λ��ˢ��
{
	if (getzoneid() != 1101)
		return;

	if (%M == 10 || %M == 30 || %M == 50)
	{
		%Ran = getRandom(1,10);
		switch (%Ran)
		{
			case 1: %XYZ = "142.669 17.4483 73.2201";	%Ret = 300;
			case 2: %XYZ = "134.409 -61.2822 72.5938";	%Ret = 315;
			case 3: %XYZ = "144.838 -140.402 95.1603";	%Ret = 350;
			case 4: %XYZ = "51.2035 -125.976 92.2325";	%Ret = 45;
			case 5: %XYZ = "-54.3288 -126.769 87.3125"; %Ret = 315;
			case 6: %XYZ = "-15.1805 -58.2074 72.7971"; %Ret = 30;
			case 7: %XYZ = "-109.178 -40.0561 82.7171"; %Ret = 345;
			case 8: %XYZ = "10.4918 41.3 72.4716";		%Ret = 330;
			case 9: %XYZ = "116.825 121.002 87.5822";	%Ret = 235;
			case 10: %XYZ = "-69.3262 147.339 87.271";	%Ret = 180;
		}
		SpNewNpc2(0,411010020,%XYZ,0,%Ret);//ÿ20����ˢһ��NPC
	}

}

function WangXianGu_YunYouYinShi_ChuFa(%Npc,%Player,%State,%Conv,%Mid)
{
	if (%Player.IsAcceptedMission(20205))
	{
		%Type = %Player.GetMissionFlag(20205,1350);
		%Num = %Player.GetMissionFlag(20205,1250);
		if (%Type < %Num)
		{
			switch (%state)
			{
				case 0:
					%Conv.SetText(511 @ %Mid);
					%Conv.AddOption(411 @ %Mid,411 @ %Mid);
				case 411 @ %Mid:
					%Conv.SetText(512 @ %Mid);
					%Player.SetMission( 20205, 1 );//���
					AddMissionAccepted( %Player, 0, 20206 );//����һ������
					%Pos = %Player.GetPosition();//�������
					%Monster = SpNewNpc(%Player,411011015,%Pos,0);//ˢ�����
					%Monster.SetExclusivePlayerId(%Player.GetPlayerID()); //���ù����ռ���
			}
		}
	}
}


//����������������������������������֧�����񡿡�������������������������������

//����������������������������������������顿��������������������������������

function ShengHuoJiNeng_30101(%Player){ ShengHuoJiNeng_30101_30701(%Player,0); }
function ShengHuoJiNeng_30111(%Player){ ShengHuoJiNeng_30101_30701(%Player,1); }
function ShengHuoJiNeng_30121(%Player){ ShengHuoJiNeng_30101_30701(%Player,2); }
function ShengHuoJiNeng_30131(%Player){ ShengHuoJiNeng_30101_30701(%Player,3); }
function ShengHuoJiNeng_30201(%Player){ ShengHuoJiNeng_30101_30701(%Player,4); }
function ShengHuoJiNeng_30301(%Player){ ShengHuoJiNeng_30101_30701(%Player,5); }
function ShengHuoJiNeng_30401(%Player){ ShengHuoJiNeng_30101_30701(%Player,6); }
function ShengHuoJiNeng_30501(%Player){ ShengHuoJiNeng_30101_30701(%Player,7); }
function ShengHuoJiNeng_30601(%Player){ ShengHuoJiNeng_30101_30701(%Player,8); }
function ShengHuoJiNeng_30701(%Player){ ShengHuoJiNeng_30101_30701(%Player,9); }

function ShengHuoJiNeng_30101_30701(%Player,%Num)//�����	����ȷ�ϴ���
{
	switch (%Num)
	{
		case 0:
			SetSrc(%Player,189);//����һѧϰ��¼
			AddMissionAccepted(%Player,0,30101);//���ڿ�����
		case 1:
			SetSrc(%Player,189);
			AddMissionAccepted(%Player,0,30111);//�ӷ�ľ����
		case 2:
			SetSrc(%Player,189);
			AddMissionAccepted(%Player,0,30121);//�Ӳ�ҩ����
		case 3:
			SetSrc(%Player,189);
			AddMissionAccepted(%Player,0,30131);//�ӵ�������
		case 4:
			SetSrc(%Player,190);//���ܶ�ѧϰ��¼
			AddMissionAccepted(%Player,0,30201);//����������
		case 5:
			SetSrc(%Player,190);
			AddMissionAccepted(%Player,0,30301);//�ӷ�������
		case 6:
			SetSrc(%Player,190);
			AddMissionAccepted(%Player,0,30401);//����������
		case 7:
			SetSrc(%Player,190);
			AddMissionAccepted(%Player,0,30501);//����������
		case 8:
			SetSrc(%Player,190);
			AddMissionAccepted(%Player,0,30601);//�ӷ�������
		case 9:
			SetSrc(%Player,190);
			AddMissionAccepted(%Player,0,30701);//���������
	}
}
//------------------������ĵ�--------------
function Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,%Mid)
{
	if (%Player.IsAcceptedMission(%Mid))//��ȡ����
	{
		switch (%Mid)
		{
			case 30103:%ItemID = 108021006;
			case 30113:%ItemID = 108021007;
			case 30123:%ItemID = 108021008;
			case 30133:%ItemID = 108021009;
			case 30205:%ItemID = 108021010;
			case 30305:%ItemID = 108021011;
			case 30405:%ItemID = 108021012;
			case 30505:%ItemID = 108021013;
			case 30605:%ItemID = 108021014;
			case 30705:%ItemID = 108021015;
		}
		switch (%State)
		{
			case 0:
				%Conv.SetText(511 @ %Mid);
				%Conv.AddOption(411 @ %Mid,411 @ %Mid);
			case 411 @ %Mid:
				%Conv.SetText(512 @ %Mid);
				AddItem_BaoGuoNo_Mail(%Player, %ItemID, 1, 1, "1 " @ %Mid);//���������
		}
	}
}
//---------�����������������---------
function Mission_ChuanDaiShengHuoDaoJu(%Player,%Mid)
{
	if (%Player.IsAcceptedMission(%Mid))
	{
		%Player.SetMissionFlag(%Mid,1350,1);
		SendOneScreenMessage(1,"�����������  1/1",%Player);
		%Player.UpdateMission(%Mid);
	}
}

//����������������������������������������顿��������������������������������
