//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//��ȡ����ǰ���ж�
//==================================================================================
//������������������������������������������������������������������������
//�������������Ǵ�����������������ȡǰ�á�������������
//�����������������񡿡��������������ȡǰ���жϡ�����
//�����������������������������������ȡǰ���жϡ�����
//�����������������񡿡��������������ȡǰ���жϡ�����
//�����������������񡿡��������������ȡǰ���жϡ�����
//case 0: %MidName = "Mission_Begin_Front_"@ %Mid;		//��ȡ����ǰ���ж�
/*����:
function Mission_Begin_Front_24108(%Npc, %Player, %Conv, %Param, %Mid)
{
if((%Player.IsSchBuff(40001040))||(GetMetempsychosisLeve(%player) < 160))
{
//SendOneScreenMessage(2,"��ոշ���������Ҫ��һ��ʱ��������½�ȡ", %Player);
//%Conv.settype(4);
return -1;
}
if(GetWord(%Player.GetActivity(3103), 0)>199)
{
//SendOneScreenMessage(2,"��ոշ���������Ҫ��һ��ʱ��������½�ȡ", %Player);
//%Conv.settype(4);
return -1;
}
if (GetWord(%Player.GetActivity(3103), 0)>199)
{
return -1;
}
return "";
}
*/

//������������������������������������������������������������������������

//------------------------�ڿ�------------------------
function Mission_Begin_Front_30102(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501011001); }
function Mission_Begin_Front_30103(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501011002); }
function Mission_Begin_Front_30104(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501011003); }
function Mission_Begin_Front_30105(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501011004); }
function Mission_Begin_Front_30106(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501011005); }
function Mission_Begin_Front_30107(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501011006); }
function Mission_Begin_Front_30108(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501011007); }
function Mission_Begin_Front_30109(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501011008); }
function Mission_Begin_Front_30110(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501011009); }
//------------------------��ľ------------------------
function Mission_Begin_Front_30112(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501021001); }
function Mission_Begin_Front_30113(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501021002); }
function Mission_Begin_Front_30114(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501021003); }
function Mission_Begin_Front_30115(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501021004); }
function Mission_Begin_Front_30116(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501021005); }
function Mission_Begin_Front_30117(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501021006); }
function Mission_Begin_Front_30118(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501021007); }
function Mission_Begin_Front_30119(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501021008); }
function Mission_Begin_Front_30120(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501021009); }
//------------------------��ҩ------------------------
function Mission_Begin_Front_30122(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501051001); }
function Mission_Begin_Front_30123(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501051002); }
function Mission_Begin_Front_30124(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501051003); }
function Mission_Begin_Front_30125(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501051004); }
function Mission_Begin_Front_30126(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501051005); }
function Mission_Begin_Front_30127(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501051006); }
function Mission_Begin_Front_30128(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501051007); }
function Mission_Begin_Front_30129(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501051008); }
function Mission_Begin_Front_30130(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501051009); }
//------------------------����------------------------
function Mission_Begin_Front_30132(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501031001); }
function Mission_Begin_Front_30133(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501031002); }
function Mission_Begin_Front_30134(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501031003); }
function Mission_Begin_Front_30135(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501031004); }
function Mission_Begin_Front_30136(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501031005); }
function Mission_Begin_Front_30137(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501031006); }
function Mission_Begin_Front_30138(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501031007); }
function Mission_Begin_Front_30139(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501031008); }
function Mission_Begin_Front_30140(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,501031009); }
//------------------------����------------------------
function Mission_Begin_Front_30204(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,502011001); }
function Mission_Begin_Front_30205(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,502011002); }
function Mission_Begin_Front_30206(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,502011003); }
function Mission_Begin_Front_30207(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,502011004); }
function Mission_Begin_Front_30208(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,502011005); }
function Mission_Begin_Front_30209(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,502011006); }
function Mission_Begin_Front_30210(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,502011007); }
function Mission_Begin_Front_30211(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,502011008); }
function Mission_Begin_Front_30212(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,502011009); }
//------------------------�÷�------------------------
function Mission_Begin_Front_30304(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,503011001); }
function Mission_Begin_Front_30305(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,503011002); }
function Mission_Begin_Front_30306(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,503011003); }
function Mission_Begin_Front_30307(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,503011004); }
function Mission_Begin_Front_30308(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,503011005); }
function Mission_Begin_Front_30309(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,503011006); }
function Mission_Begin_Front_30310(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,503011007); }
function Mission_Begin_Front_30311(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,503011008); }
function Mission_Begin_Front_30312(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,503011009); }
//------------------------����------------------------
function Mission_Begin_Front_30404(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,504011001); }
function Mission_Begin_Front_30405(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,504011002); }
function Mission_Begin_Front_30406(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,504011003); }
function Mission_Begin_Front_30407(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,504011004); }
function Mission_Begin_Front_30408(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,504011005); }
function Mission_Begin_Front_30409(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,504011006); }
function Mission_Begin_Front_30410(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,504011007); }
function Mission_Begin_Front_30411(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,504011008); }
function Mission_Begin_Front_30412(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,504011009); }
//------------------------����------------------------
function Mission_Begin_Front_30504(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,506011001); }
function Mission_Begin_Front_30505(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,506011002); }
function Mission_Begin_Front_30506(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,506011003); }
function Mission_Begin_Front_30507(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,506011004); }
function Mission_Begin_Front_30508(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,506011005); }
function Mission_Begin_Front_30509(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,506011006); }
function Mission_Begin_Front_30510(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,506011007); }
function Mission_Begin_Front_30511(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,506011008); }
function Mission_Begin_Front_30512(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,506011009); }
//------------------------����------------------------
function Mission_Begin_Front_30604(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,505011001); }
function Mission_Begin_Front_30605(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,505011002); }
function Mission_Begin_Front_30606(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,505011003); }
function Mission_Begin_Front_30607(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,505011004); }
function Mission_Begin_Front_30608(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,505011005); }
function Mission_Begin_Front_30609(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,505011006); }
function Mission_Begin_Front_30610(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,505011007); }
function Mission_Begin_Front_30611(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,505011008); }
function Mission_Begin_Front_30612(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,505011009); }
//------------------------���------------------------
function Mission_Begin_Front_30704(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,507011001); }
function Mission_Begin_Front_30705(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,507011002); }
function Mission_Begin_Front_30706(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,507011003); }
function Mission_Begin_Front_30707(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,507011004); }
function Mission_Begin_Front_30708(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,507011005); }
function Mission_Begin_Front_30709(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,507011006); }
function Mission_Begin_Front_30710(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,507011007); }
function Mission_Begin_Front_30711(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,507011008); }
function Mission_Begin_Front_30712(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,507011009); }

function Mission_ShengHuoJiNeng_ShengJi(%Npc,%Player,%Conv,%Param,%Mid,%Skillid)
{
	%ShuLian = %Player.GetLivingskillGuerdon(%Skillid);//��ȡ��ǰ������
	%ShuLianMax = %Player.GetLivingskillMaxGuerdon(%Skillid);//��ȡ��������Ҫ��������
	//echo( "%shulian=======" @ %ShuLian  @ "%shulianmax======" @ %ShuLIanMax );
	if (%ShuLian < %ShuLianMax)
	{
		SendOneScreenMessage(2,"���������Ȳ��㣬ȥ��һ��������",%Player);
		%Conv.settype(4);
		return -1;
	}
	return "";
}


//������������������������������������������������������������������������



//�����������������������������������ȡǰ���жϡ�������������
function Mission_Begin_Front_20001(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,44,40); }
function Mission_Begin_Front_20002(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,44,41); }
function Mission_Begin_Front_20003(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,44,42); }
function Mission_Begin_Front_20004(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,44,43); }
function Mission_Begin_Front_20005(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,44,44); }
function Mission_Begin_Front_20006(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,44,50); }
function Mission_Begin_Front_20007(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,44,55); }
function Mission_Begin_Front_20008(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,44,56); }
function Mission_Begin_Front_20009(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,59,40); }
function Mission_Begin_Front_20010(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,59,41); }
function Mission_Begin_Front_20011(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,59,42); }
function Mission_Begin_Front_20012(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,59,43); }
function Mission_Begin_Front_20013(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,59,44); }
function Mission_Begin_Front_20014(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,59,50); }
function Mission_Begin_Front_20015(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,59,55); }
function Mission_Begin_Front_20016(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,59,56); }
function Mission_Begin_Front_20017(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,75,40); }
function Mission_Begin_Front_20018(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,75,41); }
function Mission_Begin_Front_20019(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,75,42); }
function Mission_Begin_Front_20020(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,75,43); }
function Mission_Begin_Front_20021(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,75,44); }
function Mission_Begin_Front_20022(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,75,50); }
function Mission_Begin_Front_20023(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,75,55); }
function Mission_Begin_Front_20024(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,75,56); }

function Mission_Begin_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,%MaxLevel,%Src)
{
	//echo( "%Mid===" @ %Mid );
	//echo( "%MaxLevel===" @ %MaxLevel );
	//echo( "%Src===" @ %Src );
	if (%player.IsAcceptedMission(%Mid))
		return -1;
	//echo( %player.IsAcceptedMission( %Mid ) );
	if (%Player.Getlevel() > %MaxLevel)
		return -2;
	//echo( %Player.Getlevel( ) );
	if (%Src == 44 || %Src == 50)//���⴦��
	{
		for (%i = 0; %i <= 4; %i++)
		{
			if (GetSrc(%Player,%Src + %i) == 0)
				return "";
		}
		//echo( " %S====" @  %Src );
		return -3;
	}
	else if (GetSrc(%Player,%Src) == 1)
		return -4;
	return "";
}

//�����������������������������������ȡǰ���жϡ�������������


//�����������������񡿡��������������ȡǰ���жϡ�����
function Mission_Begin_Front_20148(%Npc,%Player,%Conv,%Param,%Mid)
{
	if (%Player.getlevel() < $SL_ZhuYao_Level)
	{
		SendOneScreenMessage(2,"�ȼ�����" @ $SL_ZhuYao_Level @ "�����޷���ȡ��������",%Player);
		%Conv.settype(4);
		return -1;
	}
	if ($SL_ZhuYao_State_bActive != 1)
	{
		//SendOneScreenMessage( 2, "���������ѹرգ��޷���ȡ��", %Player );
		//%Conv.settype( 4 );
		return -1;
	}
	%Act4012[0] = GetAct(%Player,4012,0);
	if (%Act4012[0] >= 10)
	{
		SendOneScreenMessage(2,"������Ѿ����10�Σ����������ɣ�",%Player);
		%Conv.settype(4);
		return -1;
	}
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"����������λ���㣡",%Player);
		%Conv.settype(4);
		return -1;
	}
	if (%Player.GetMoney(2) < 6000)
	{
		SendOneScreenMessage(2,"��Ҳ��㣬��ȡ������Ҫ60����",%Player);
		%Conv.settype(4);
		return -1;
	}
	return "";
}
//�����������������񡿡��������������ȡǰ���жϡ�����

//�������������Ǵ�����������������ȡǰ�á�������������
function Mission_Begin_Front_20150(%Npc,%Player,%Conv,%Param,%Mid)
{
	%Level = %Player.GetLevel();
	if (%Level <= 44) %ItemID = 105109321;
	else if (%Level <= 59) %ItemID = 105109322;
	else if (%Level <= 74) %ItemID = 105109323;
	else if (%Level <= 89) %ItemID = 105109324;
	else  %ItemID = 105109325;

	%Count = %Player.GetItemCount(%ItemID);
	if (%Count <10)
	{
		SendOneScreenMessage(2,"��û���㹻������ʯ",%Player);
		%Conv.settype(4);
		return -1;
	}
	%Act0 =  GetAct(%Player,4098,0);
	if (%Act0 >= 10)
	{
		SendOneScreenMessage(2,"ÿ��ֻ�����10�Σ�������������",%Player);
		%Conv.settype(4);
		return -1;
	}
	return "";
}
//�������������Ǵ�����������������ȡǰ�á�������������

//�����������������񡿡��������������ȡǰ���жϡ�����
function Mission_Begin_Front_20028(%Npc, %Player, %Conv, %Param, %Mid)
{
	if (GetSrc(%Player, 59) == 1)
	{
		%Text = "������Ѿ���ȡ���������ˣ�����������";
		SendOneScreenMessage(2, %Text, %Player);
		SendOneChatMessage($chatMsg_System, "<t>" @ %Text @ "</t>", %Player);
		return -1;
	}
	if (%Player.GetLevel() < 30)
		return -1;
	return "";
}
function Mission_Begin_Front_20151(%Npc, %Player, %Conv, %Param, %Mid)
{
	if (GetSrc(%Player, 197) == 1)
	{
		%Text = "������Ѿ���ȡ���������ˣ�����������";
		SendOneScreenMessage(2, %Text, %Player);
		SendOneChatMessage($chatMsg_System, "<t>" @ %Text @ "</t>", %Player);
		return -1;
	}
	if (%Player.GetLevel() < 30)
		return -1;
	return "";
}
//�����������������񡿡��������������ȡǰ���жϡ�����




//�����������������񡿡��������������ȡǰ���жϡ�����
function Mission_Begin_Front_20036(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ������һ
function Mission_Begin_Front_20037(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20038(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20039(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20040(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20041(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20042(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20043(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ������һ
function Mission_Begin_Front_20044(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20045(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20046(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20047(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20048(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20049(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20050(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ������һ
function Mission_Begin_Front_20051(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20052(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20053(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20054(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20055(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20056(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20057(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ������һ
function Mission_Begin_Front_20058(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20059(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20060(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20061(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20062(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20063(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20064(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ������һ
function Mission_Begin_Front_20065(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20066(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20067(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20068(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20069(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20070(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//Ӣ��������
function Mission_Begin_Front_20036_20070(%Npc, %Player, %Conv, %Param, %Mid)//
{
	%class0 = %player.GetClasses(0);
	switch (%class0)
	{
		case 1:%HvaeShengWang = GetPrestige(%Player, 1, 1);//ս
		case 2:%HvaeShengWang = GetPrestige(%Player, 1, 4);//��
		case 3:%HvaeShengWang = GetPrestige(%Player, 1, 2);//��
		case 4:%HvaeShengWang = GetPrestige(%Player, 1, 3);//��
		case 5:%HvaeShengWang = GetPrestige(%Player, 1, 5);//��
	}

	//echo("%Mid===" @ %Mid);
	//echo("%class0===" @ %class0);
	//echo("%HvaeShengWang===" @ %HvaeShengWang);
	if (%HvaeShengWang < 10000)
	{
		%Text = "������������10000�㣬�޷���ȡ������";
		SendOneScreenMessage(2, %Text, %Player);
		SendOneChatMessage($chatMsg_System, "<t>" @ %Text @ "</t>", %Player);
		return -1;
	}
	return "";
}

//�����������������񡿡��������������ȡǰ���жϡ�����