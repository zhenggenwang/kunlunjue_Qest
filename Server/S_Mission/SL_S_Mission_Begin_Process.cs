//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//��ȡ������̴���
//==================================================================================
//������������������������������������������ָ��������������������������������


//case 2: %MidName = "Mission_Begin_Process_"@ %Mid;	//��ȡ������̴���
/*����:
function Mission_Begin_Process_24108(%Npc, %Player, %Conv, %Param, %Mid)
{
//��һ�����Ϣ
if(%Player.IsSchBuff(40001040))
{
SendOneScreenMessage(2,"��ոշ���������Ҫ��һ��ʱ��������½�ȡ", %Player);
return;
}
if (GetWord(%Player.GetActivity(3103), 0)>199)
{
SendOneScreenMessage(2,"������ɱ����ܻ�ϵ������", %Player);
return ;
}
%Activity = GetWord(%Player.GetActivity(3103), 0) ;	//�ܴ���
if (%Activity <20) %ran=getrandom(1,12);
else if (%Activity <50) %ran=getrandom(13,29);
else if (%Activity <90) %ran=getrandom(30,48);
else if (%Activity <140 )%ran=getrandom(49,65);
else %ran=getrandom(66,95);
////echo("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" @ %ran);
//ȷ����������
if (%ran <= 65)
Mission_Runloop_Affair(%Npc, %Player, %Conv, %Param, %Mid,%ran);
else Mission_Runloop_Affair_new(%Npc, %Player, %Conv, %Param, %Mid,%ran);
//���ö�����꣬��ʾ�ɼ�����
%Player.SetMissionFlag(%Mid, 9100, 1);
//��������
%Player.UpdateMission(%Mid);
}*/

//������������������������������������������ָ��������������������������������

function Mission_Begin_Process_10051(%Npc,%Player,%Conv,%Param,%Mid)//Ѱ�ɷõ�
{
	%Conv.Settype(4);
	%Classes = %Player.GetClasses(0);
	switch (%Classes)
	{
		case 1:%Skill[1] = 210010001; %Skill[2] = 210020001; //սʿ
		case 2:%Skill[1] = 220010001; %Skill[2] = 220020001; //�̿�
		case 3:%Skill[1] = 230010001; %Skill[2] = 230020001; //��ʦ
		case 4:%Skill[1] = 240010001; %Skill[2] = 240020001; //��ʿ
		case 5:%Skill[1] = 250010001; %Skill[2] = 250020001; //����
	}
	//���ְҵ����
	%Player.AddSkill(%Skill[1]);	//ְҵ����1
	%Player.AddSkill(%Skill[2]);	//ְҵ����2
	%Player.AddObjectToPanel(2,%Skill[1],1);
	%Player.AddObjectToPanel(2,%Skill[2],2);
}
function Mission_Begin_Process_10071( %Npc, %Player, %Conv, %Param, %Mid )//���ԭ��
{
	%Conv.Settype( 4 );
	%Item = %Player.GetItemCount( 108020162 );//��ȡ������������
	if ( %Item != 1 )//���û��
	{
		AddItem_BaoGuoNo_Mail(%Player, 108020162, 1, 1, "1 " @ %Mid);//��һ����ʧ֮��
	}
}
function Mission_Begin_Process_10121(%Npc,%Player,%Conv,%Param,%Mid)//��¼���
{
	%Conv.Settype(4);
	%Classes = %Player.GetClasses(0);
	switch (%Classes)
	{
		case 1:%ItemID = 105220003;//սʿ
		case 2:%ItemID = 105230003;//�̿�
		case 3:%ItemID = 105240003;//��ʦ
		case 4:%ItemID = 105250003;//��ʿ
		case 5:%ItemID = 105260003;//����
	}
	AddItem_BaoGuoNo_Mail(%Player, %ItemID, 1, 1, "1 " @ %Mid);//��������
}
function Mission_Begin_Process_10151(%Npc,%Player,%Conv,%Param,%Mid)//�ü��·�
{
	$Mission_Item_10151[1,1] = "102022000;102022050;";
	$Mission_Item_10151[1,3] = "102022200;102022250;";
	$Mission_Item_10151[1,4] = "102022300;102022350;";
	%Conv.Settype(4);
	%Classes = %Player.GetClasses(0);//��ȡְҵ
	%Sex = %Player.GetSex();//��ȡ�Ա�
	if (%Sex == 1)//����
	{
		%ItemID = getword($Mission_Item_10151[1,%Classes],0,";");
		AddItem_BaoGuoNo_Mail(%Player, %ItemID, 1, 0, "1 " @ %Mid);
	}
	else
	{
		%ItemID = getword($Mission_Item_10151[1,%Classes],1,";");
		AddItem_BaoGuoNo_Mail(%Player, %ItemID, 1, 0, "1 " @ %Mid);
	}
}

function Mission_Begin_Process_10111(%Npc,%Player,%Conv,%Param,%Mid)//���Ϲ���
{
	//echo( "%Player===" @ %Player.getobjectname( ) );
	%Conv.Settype(4);
	%Random = getrandom( 1, 3 );
	switch ( %Random )
	{
		case 1:%Num = 10100301;
		case 2:%Num = 10100302;
		case 3:%Num = 10100303;
	}
	FlyMeToTheMoon( %Player, %Num, 704001801 );
}

function Mission_Begin_Process_10101(%Npc,%Player,%Conv,%Param,%Mid)//����Ѱ��
{
	//echo( "%Player===" @ %Player.getobjectname( ) );
	%Conv.Settype(4);
	%Random = getrandom( 1, 3 );
	switch ( %Random )
	{
		case 1:%Num = 10100201;
		case 2:%Num = 10100202;
		case 3:%Num = 10100203;
	}
	FlyMeToTheMoon(%Player,%Num,704001801);//����·��
}
function Mission_Begin_Process_10201(%Npc,%Player,%Conv,%Param,%Mid)//ʦ�ֽ̻�
{
	%Conv.Settype(4);
	%Classes = %Player.GetClasses(0);
	switch (%Classes)
	{
		case 1:%ItemID = 103022000;//սʿ
		case 2:%ItemID = 103020101;//�̿�
		case 3:%ItemID = 103022200;//��ʦ
		case 4:%ItemID = 103022300;//��ʿ
		case 5:%ItemID = 103020401;//����
	}
	AddItem_BaoGuoNo_Mail(%Player, %ItemID, 1, 0, "1 " @ %Mid);//����ְҵ������
}
function Mission_Begin_Process_10231(%Npc,%Player,%Conv,%Param,%Mid)//����֮;
{
	%Conv.Settype(4);
	%Classes = %Player.GetClasses(0);
	switch (%Classes)
	{
		case 1:%ItemID = 105220004;//սʿ
		case 2:%ItemID = 105230004;//�̿�
		case 3:%ItemID = 105240004;//��ʦ
		case 4:%ItemID = 105250005;//��ʿ
		case 5:%ItemID = 105260004;//����
	}
	AddItem_BaoGuoNo_Mail(%Player, %ItemID, 1, 1, "1 " @ %Mid);//��������
}

function Mission_Begin_Process_10311(%Npc,%Player,%Conv,%Param,%Mid)//��������
{
	%Conv.Settype(4);
	%Random = getrandom( 1, 3 );
	switch ( %Random )
	{
		case 1:%Num = 10100401;
		case 2:%Num = 10100402;
		case 3:%Num = 10100403;
	}
	FlyMeToTheMoon(%Player,%Num,701002601);
}
function Mission_Begin_Process_10321(%Npc,%Player,%Conv,%Param,%Mid)//��������
{
	%Conv.Settype(4);
	%Random = getrandom( 1, 3 );
	switch ( %Random )
	{
		case 1:%Num = 10100501;
		case 2:%Num = 10100502;
		case 3:%Num = 10100503;
	}
	FlyMeToTheMoon(%Player,%Num,701002601);
}

function Mission_Begin_Process_10301(%Npc,%Player,%Conv,%Param,%Mid)//����֮��
{
	%Conv.Settype(4);
	%Monster = SpNewNpc(%Player,410101016,"138.038 -55.6684 144.906",0);
	%Monster.SetExclusivePlayerId(%Player.GetPlayerID()); //���ù����ռ���
	ChangeLogicFloor(%Monster,0,%Player);
	%Player.Monster_ShuYaoZhiLing = %Monster;
}


function Mission_Begin_Process_10481(%Npc,%Player,%Conv,%Param,%Mid)//�����
{
	%Conv.Settype(4);
	AddItem_BaoGuoNo_Mail(%Player, 107050001, 1, 0, "1 " @ %Mid);

}
function Mission_Begin_Process_10491(%Npc,%Player,%Conv,%Param,%Mid)//��һ������
{
	%Conv.Settype(4);
	AddItem_BaoGuoNo_Mail(%Player, 108020026, 1, 1, "1 " @ %Mid);

}
function Mission_Begin_Process_10761(%Npc,%Player,%Conv,%Param,%Mid)//����ʯ
{
	%Conv.Settype(4);
	AddItem_BaoGuoNo_Mail(%Player, 116060051, 1, 0, "1 " @ %Mid);

}

function Mission_Begin_Process_10841(%Npc,%Player,%Conv,%Param,%Mid)//ʦ���ܻ�
{
	%Conv.Settype(4);
	//GoToNextMap(%Player,1010,"");//���͵�ͼ
	%Player.ShowDialogOk( 2000000038, 44, 1 );//ȷ�Ͽ�
}
function Mission_Begin_Process_10871(%Npc,%Player,%Conv,%Param,%Mid)//����������
{
	%Conv.Settype(4);
	//GoToNextMap(%Player,"811010106","");//��������
	%Player.ShowDialogOk( 2000000036, 42, 1 );//ȷ�Ͽ�
}
function Mission_Begin_Process_11031(%Npc,%Player,%Conv,%Param,%Mid)//��������
{
	%Conv.Settype(4);
	//GoToNextMap(%Player,"810010100","");//��������
	%Player.ShowDialogOk(2000000037,43,1);//ȷ�Ͽ�
}


//������������������������������������������ָ��������������������������������

function Mission_Begin_Process_20029(%Npc,%Player,%Conv,%Param,%Mid) { Mission_Begin_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }	//ն����ħ��һ
function Mission_Begin_Process_20030(%Npc,%Player,%Conv,%Param,%Mid) { Mission_Begin_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }	//ն����ħ����
function Mission_Begin_Process_20031(%Npc,%Player,%Conv,%Param,%Mid) { Mission_Begin_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }	//ն����ħ����
function Mission_Begin_Process_20032(%Npc,%Player,%Conv,%Param,%Mid) { Mission_Begin_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }	//ն����ħ����
function Mission_Begin_Process_20033(%Npc,%Player,%Conv,%Param,%Mid) { Mission_Begin_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }	//ն����ħ����
function Mission_Begin_Process_20034(%Npc,%Player,%Conv,%Param,%Mid) { Mission_Begin_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }	//ն����ħ����
function Mission_Begin_Process_20035(%Npc,%Player,%Conv,%Param,%Mid) { Mission_Begin_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }	//ն����ħ����
function Mission_Begin_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid)
{
	switch (%Mid)
	{
		case 20029:%MissionTarget = 108030002;//108030002	���ɿ߹���
		case 20030:%MissionTarget = 108030003;//108030003	��ڤ���߹���
		case 20031:%MissionTarget = 108030004;//108030004	��Թ�����
		case 20032:%MissionTarget = 108030005;//108030005	�ع�4����
		case 20033:%MissionTarget = 108030006;//108030006	�ع�5����
		case 20034:%MissionTarget = 108030007;//108030007	�ع�6����
		case 20035:%MissionTarget = 108030008;//108030008	�ع�7����
		default:return 0;
	}
	//echo( "%Mid ===" @ %Mid @ "     ====" @ %MissionTarget );
	if (%MissionTarget > 0)
	{
		//echo("=================" @  %Player.IsAcceptedMission( %Mid ) );
		%Player.SetMissionFlag(%Mid,1100,%MissionTarget);
		%Player.SetMissionFlag(%Mid,1200,100);
		%Player.SetMissionFlag(%Mid,1300,0);
		%Player.UpdateMission(%Mid);
	}
}
//263197.SetMissionFlag( 20029, 1101, 108030002 );	263197.SetMissionFlag( 20029, 1201, 100 ); 263197.SetMissionFlag( 20029, 1301, 0 ); 263197.UpdateMission( 20029 );
function Mission_Begin_Process_20146(%Npc,%Player,%Conv,%Param,%Mid)
{
	%MissionTarget = GetRandom(108020994,108021000);
	%Player.SetMissionFlag(%Mid,2100,%MissionTarget);
	%Player.SetMissionFlag(%Mid,2200,2);
	%Player.SetMissionFlag(%Mid,2300,0);
	%Player.UpdateMission(%Mid);
}
function Mission_Begin_Process_30101(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_30101_30131(%Npc,%Player,%Conv,%Param,%Mid,107020001); }
function Mission_Begin_Process_30111(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_30101_30131(%Npc,%Player,%Conv,%Param,%Mid,107040001); }
function Mission_Begin_Process_30121(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_30101_30131(%Npc,%Player,%Conv,%Param,%Mid,107010001); }
function Mission_Begin_Process_30131(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_30101_30131(%Npc,%Player,%Conv,%Param,%Mid,107050001); }
//���������������ߣ�������ʱֱ��������
function Mission_Begin_Process_30101_30131(%Npc,%Player,%Conv,%Param,%Mid,%Num)
{
	%ItemID = %Player.GetEquip(13);// ��ȡ�������ID
	for (%i = 1; %i <= 3; %i++)
	{
		if (%ItemID == %Num)
		{
			%Player.SetMissionFlag(%Mid,1350,1);
			SendOneScreenMessage(1,"���  1/1",%Player);
			%Player.UpdateMission(%Mid);
		}
		%Num++;
	}
}
/*
function Mission_Begin_Process_20036(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ������һ
function Mission_Begin_Process_20037(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20038(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20039(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20040(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20041(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20042(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20043(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ������һ
function Mission_Begin_Process_20044(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20045(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20046(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20047(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20048(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20049(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20050(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ������һ
function Mission_Begin_Process_20051(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20052(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20053(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20054(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20055(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20056(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20057(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ������һ
function Mission_Begin_Process_20058(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20059(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20060(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20061(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20062(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20063(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20064(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ������һ
function Mission_Begin_Process_20065(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20066(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20067(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20068(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20069(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20070(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid)//
{
	%Level = %Player.GetLevel();
	if (%Level <= 59) { %NpcID = 411291103; %Num = 40; }
	else if (%Level <= 69) { %NpcID = 411301103; %Num = 40; }
	else if (%Level <= 79) { %NpcID = 411301103; %Num = 400; }
	else if (%Level <= 89) { %NpcID = 411301103; %Num = 400; }
	else if (%Level <= 99) { %NpcID = 411301103; %Num = 400; }
	else if (%Level <= 109) { %NpcID = 411301103; %Num = 400; }
	else if (%Level <= 119) { %NpcID = 411301103; %Num = 400; }

	%Player.SetMissionFlag(%Mid, 3100, %NpcID);
	%Player.SetMissionFlag(%Mid, 3200, %Num);
	%Player.SetMissionFlag(%Mid, 3300, 0);
	%Player.UpdateMission(%Mid);
}
*/