//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//
//==================================================================================
//SpNewCj2( 263016, 551011004, 0, 0, 180, "1 1 1" );


$TriggerEvent[551011001,1] ="106020001 1 25";/*ͭ��*/
$TriggerEvent[551011001,2] ="106020001 2 5";/*ͭ��*/
$TriggerEvent[551011001,3] ="106020001 5 3";/*ͭ��*/
$TriggerEvent[551011001,4] ="106020501 1 17";/*��ʯ*/
$TriggerEvent[551011001,5] ="106020501 2 5";/*��ʯ*/
$TriggerEvent[551011001,6] ="106020511 1 25";/*��ʯ*/

$TriggerEvent[551011002,1] ="106020002 1 25";/*����*/
$TriggerEvent[551011002,2] ="106020002 2 5";/*����*/
$TriggerEvent[551011002,3] ="106020002 5 3";/*����*/
$TriggerEvent[551011002,4] ="106020502 1 17";/*Ǧʯ*/
$TriggerEvent[551011002,5] ="106020502 2 5";/*Ǧʯ*/
$TriggerEvent[551011002,6] ="106020511 1 25";/*��ʯ*/

$TriggerEvent[551011003,1] ="106020003 1 25";/*����*/
$TriggerEvent[551011003,2] ="106020003 2 5";/*����*/
$TriggerEvent[551011003,3] ="106020003 5 3";/*����*/
$TriggerEvent[551011003,4] ="106020503 1 14";/*пʯ*/
$TriggerEvent[551011003,5] ="106020503 2 5";/*пʯ*/
$TriggerEvent[551011003,6] ="106020512 1 28";/*����*/

$TriggerEvent[551011004,1] ="106020004 1 25";/*���*/
$TriggerEvent[551011004,2] ="106020004 2 5 ";/*���*/
$TriggerEvent[551011004,3] ="106020004 5 3 ";/*���*/
$TriggerEvent[551011004,4] ="106020504 1 13";/*��ʯ*/
$TriggerEvent[551011004,5] ="106020504 2 2 ";/*��ʯ*/
$TriggerEvent[551011004,6] ="106020512 1 32";/*����*/

$TriggerEvent[551011005,1] ="106020005 1 25";/*������*/
$TriggerEvent[551011005,2] ="106020005 2 5";/*������*/
$TriggerEvent[551011005,3] ="106020005 5 3";/*������*/
$TriggerEvent[551011005,4] ="106020505 1 13";/*����ʯ*/
$TriggerEvent[551011005,5] ="106020505 2 4";/*����ʯ*/
$TriggerEvent[551011005,6] ="106020512 1 31";/*����*/

$TriggerEvent[551011006,1] ="106020006 1 25";/*������*/
$TriggerEvent[551011006,2] ="106020006 2 5";/*������	*/
$TriggerEvent[551011006,3] ="106020006 5 3";/*������	*/
$TriggerEvent[551011006,4] ="106020506 1 13";/*����ʯ*/
$TriggerEvent[551011006,5] ="106020506 2 3";/*����ʯ	*/
$TriggerEvent[551011006,6] ="106020512 1 31";/*����	*/

$TriggerEvent[551011007,1] ="106020007 1 25";/*ħ���*/
$TriggerEvent[551011007,2] ="106020007 2 5";/*ħ���	*/
$TriggerEvent[551011007,3] ="106020007 5 3";/*ħ���	*/
$TriggerEvent[551011007,4] ="106020507 1 12";/*ϼ��ʯ*/
$TriggerEvent[551011007,5] ="106020507 2 3";/*ϼ��ʯ	*/
$TriggerEvent[551011007,6] ="106020512 1 32";/*����	*/

$TriggerEvent[551011008,1] ="106020008 1 25";/*�����*/
$TriggerEvent[551011008,2] ="106020008 2 5";/*�����	*/
$TriggerEvent[551011008,3] ="106020008 5 3";/*�����	*/
$TriggerEvent[551011008,4] ="106020508 1 11";/*���ʯ*/
$TriggerEvent[551011008,5] ="106020508 2 4";/*���ʯ	*/
$TriggerEvent[551011008,6] ="106020512 1 33";/*����	*/

$TriggerEvent[551011009,1] ="106020009 1 25";/*�Ͻ��*/
$TriggerEvent[551011009,2] ="106020009 2 5";/*�Ͻ��	*/
$TriggerEvent[551011009,3] ="106020009 5 3";/*�Ͻ��	*/
$TriggerEvent[551011009,4] ="106020509 1 12";/*����ʯ*/
$TriggerEvent[551011009,5] ="106020509 2 4";/*����ʯ	*/
$TriggerEvent[551011009,6] ="106020512 1 32";/*����	*/

$TriggerEvent[551011010,1] ="106020010 1 25";/*ҫ���*/
$TriggerEvent[551011010,2] ="106020010 2 5";/*ҫ���	*/
$TriggerEvent[551011010,3] ="106020010 5 3";/*ҫ���	*/
$TriggerEvent[551011010,4] ="106020510 1 13";/*����ʯ*/
$TriggerEvent[551011010,5] ="106020510 2 4";/*����ʯ	*/
$TriggerEvent[551011010,6] ="106020512 1 31";/*����	*/

function TriggerEvent_551011001(%Player,%Event,%EventID){ TriggerEvent_551011001_551011010(%Player,%Event,%EventID,501011001); }
function TriggerEvent_551011002(%Player,%Event,%EventID){ TriggerEvent_551011001_551011010(%Player,%Event,%EventID,501011002); }
function TriggerEvent_551011003(%Player,%Event,%EventID){ TriggerEvent_551011001_551011010(%Player,%Event,%EventID,501011003); }
function TriggerEvent_551011004(%Player,%Event,%EventID){ TriggerEvent_551011001_551011010(%Player,%Event,%EventID,501011004); }
function TriggerEvent_551011005(%Player,%Event,%EventID){ TriggerEvent_551011001_551011010(%Player,%Event,%EventID,501011005); }
function TriggerEvent_551011006(%Player,%Event,%EventID){ TriggerEvent_551011001_551011010(%Player,%Event,%EventID,501011006); }
function TriggerEvent_551011007(%Player,%Event,%EventID){ TriggerEvent_551011001_551011010(%Player,%Event,%EventID,501011007); }
function TriggerEvent_551011008(%Player,%Event,%EventID){ TriggerEvent_551011001_551011010(%Player,%Event,%EventID,501011008); }
function TriggerEvent_551011009(%Player,%Event,%EventID){ TriggerEvent_551011001_551011010(%Player,%Event,%EventID,501011009); }
function TriggerEvent_551011010(%Player,%Event,%EventID){ TriggerEvent_551011001_551011010(%Player,%Event,%EventID,501011010); }
function TriggerEvent_551011001_551011010(%Player,%Event,%EventID,%Skill)
{
	if (%Player.GetBagEmptyCount() < 1)
	{
		%Txt = "��ı��������������������";
		SendOneScreenMessage(1,%Txt,%Player);	//��ɫ��Ϣ
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
	}
	SetStrategyRecord(%Player,$StrategySubBtnSrc[3,0]);//���Դ�����¼
	/*%Mark = 0;
	for ( %i = 501011010; %i >= %Skill; %i-- )
	{
	if ( isLearnLivingSkill( %Player.GetPlayerID( ), %i )  == 1 )
	{
	%Mark = %i;
	break;
	}
	}
	if ( %Mark  <= 0 )
	return;*/
	%Ran = GetRanDom(1,100);
	%RecordRan = 0;
	//echo( "%Ran===" @ %Ran );
	for (%i = 1; %i <=10; %i++)
	{
		if ($TriggerEvent[%EventID,%i] $= "")
			break;
		%OneRan = GetWord($TriggerEvent[%EventID,%i],2);
		%RecordRan = %RecordRan + %OneRan;
		if (%RecordRan >= %Ran && %OneRan > 0)
		{
			%ItemID = GetWord($TriggerEvent[%EventID,%i],0);
			%ItemNum = GetWord($TriggerEvent[%EventID,%i],1);
			break;
		}
	}
	if (%ItemID > 0 &&  %ItemNum > 0)
	{
		%Player.PutItem(%ItemID,%ItemNum);
		if (%Player.Additem(4,%EventID) && %ItemID != 106020512 && %ItemID != 106020511)
		{
			for (%i = 501011010; %i >= %Skill; %i--)
			{
				if (isLearnLivingSkill(%Player.GetPlayerID(),%i) == 1)
				{
					addLivingSkillGuerdon(%Player,%i,1);
					break;
				}
			}
		}
	}
	else
	{
		%Index = GetSpecialjade(%Player,0,4,%EventID);
		if (%Index == 0)
			SendOneScreenMessage(1,"���ź���һ��ͷ�ӿգ�ʲôҲû�ڵ�",%Player);
	}
}




$TriggerEvent[551021001,1] = "106040001 1 25";//
$TriggerEvent[551021001,2] = "106040001 2 5";//
$TriggerEvent[551021001,3] = "106040001 5 3";//
$TriggerEvent[551021001,4] = "106040501 1 17";//
$TriggerEvent[551021001,5] = "106040501 2 5";//
$TriggerEvent[551021001,6] = "106040511 1 25";//

$TriggerEvent[551021002,1] = "106040002 1 25";//
$TriggerEvent[551021002,2] = "106040002 2 5";//
$TriggerEvent[551021002,3] = "106040002 5 3";//
$TriggerEvent[551021002,4] = "106040501 1 17";//
$TriggerEvent[551021002,5] = "106040501 2 5";//
$TriggerEvent[551021002,6] = "106040511 1 25";//

$TriggerEvent[551021003,1] = "106040003 1 25";//
$TriggerEvent[551021003,2] = "106040003 2 5";//
$TriggerEvent[551021003,3] = "106040003 5 3";//
$TriggerEvent[551021003,4] = "106040501 1 14";//
$TriggerEvent[551021003,5] = "106040501 2 5";//
$TriggerEvent[551021003,6] = "106040511 1 28";//

$TriggerEvent[551021004,1] = "106040004 1 25";//
$TriggerEvent[551021004,2] = "106040004 2 5";//
$TriggerEvent[551021004,3] = "106040004 5 3";//
$TriggerEvent[551021004,4] = "106040501 1 13";//
$TriggerEvent[551021004,5] = "106040501 2 2";//
$TriggerEvent[551021004,6] = "106040511 1 32";//

$TriggerEvent[551021005,1] = "106040005 1 25";//
$TriggerEvent[551021005,2] = "106040005 2 5";//
$TriggerEvent[551021005,3] = "106040005 5 3";//
$TriggerEvent[551021005,4] = "106040501 1 13";//
$TriggerEvent[551021005,5] = "106040501 2 4";//
$TriggerEvent[551021005,6] = "106040511 1 31";//

$TriggerEvent[551021006,1] = "106040006 1 25";//
$TriggerEvent[551021006,2] = "106040006 2 5";//
$TriggerEvent[551021006,3] = "106040006 5 3";//
$TriggerEvent[551021006,4] = "106040501 1 13";//
$TriggerEvent[551021006,5] = "106040501 2 3";//
$TriggerEvent[551021006,6] = "106040511 1 31";//

$TriggerEvent[551021007,1] = "106040007 1 25";//
$TriggerEvent[551021007,2] = "106040007 2 5";//
$TriggerEvent[551021007,3] = "106040007 5 3";//
$TriggerEvent[551021007,4] = "106040501 1 12";//
$TriggerEvent[551021007,5] = "106040501 2 3";//
$TriggerEvent[551021007,6] = "106040511 1 32";//

$TriggerEvent[551021008,1] = "106040008 1 25";//
$TriggerEvent[551021008,2] = "106040008 2 5";//
$TriggerEvent[551021008,3] = "106040008 5 3";//
$TriggerEvent[551021008,4] = "106040501 1 11";//
$TriggerEvent[551021008,5] = "106040501 2 4";//
$TriggerEvent[551021008,6] = "106040511 1 33";//

$TriggerEvent[551021009,1] = "106040009 1 25";//
$TriggerEvent[551021009,2] = "106040009 2 5";//
$TriggerEvent[551021009,3] = "106040009 5 3";//
$TriggerEvent[551021009,4] = "106040501 1 12";//
$TriggerEvent[551021009,5] = "106040501 2 4";//
$TriggerEvent[551021009,6] = "106040511 1 32";//

$TriggerEvent[551021010,1] = "106040010 1 25";//
$TriggerEvent[551021010,2] = "106040010 2 5";//
$TriggerEvent[551021010,3] = "106040010 5 3";//
$TriggerEvent[551021010,4] = "106040501 1 13";//
$TriggerEvent[551021010,5] = "106040501 2 4";//
$TriggerEvent[551021010,6] = "106040511 1 31";//

function TriggerEvent_551021001(%Player,%Event,%EventID){ TriggerEvent_551021001_551021010(%Player,%Event,%EventID,501021001); } //һ����ľ
function TriggerEvent_551021002(%Player,%Event,%EventID){ TriggerEvent_551021001_551021010(%Player,%Event,%EventID,501021002); } //������ľ
function TriggerEvent_551021003(%Player,%Event,%EventID){ TriggerEvent_551021001_551021010(%Player,%Event,%EventID,501021003); } //������ľ
function TriggerEvent_551021004(%Player,%Event,%EventID){ TriggerEvent_551021001_551021010(%Player,%Event,%EventID,501021004); } //�ļ���ľ
function TriggerEvent_551021005(%Player,%Event,%EventID){ TriggerEvent_551021001_551021010(%Player,%Event,%EventID,501021005); } //�弶��ľ
function TriggerEvent_551021006(%Player,%Event,%EventID){ TriggerEvent_551021001_551021010(%Player,%Event,%EventID,501021006); } //������ľ
function TriggerEvent_551021007(%Player,%Event,%EventID){ TriggerEvent_551021001_551021010(%Player,%Event,%EventID,501021007); } //�߼���ľ
function TriggerEvent_551021008(%Player,%Event,%EventID){ TriggerEvent_551021001_551021010(%Player,%Event,%EventID,501021008); } //�˼���ľ
function TriggerEvent_551021009(%Player,%Event,%EventID){ TriggerEvent_551021001_551021010(%Player,%Event,%EventID,501021009); } //�ż���ľ
function TriggerEvent_551021010(%Player,%Event,%EventID){ TriggerEvent_551021001_551021010(%Player,%Event,%EventID,501021010); } //ʮ����ľ
function TriggerEvent_551021001_551021010(%Player,%Event,%EventID,%Skill)
{
	if (%Player.GetBagEmptyCount() < 1)
	{
		%Txt = "��ı��������������������";
		SendOneScreenMessage(1,%Txt,%Player);	//��ɫ��Ϣ
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
	}
	SetStrategyRecord(%Player,$StrategySubBtnSrc[3,1]);//���Դ�����¼
	/*%Mark = 0;
	for ( %i = 501021010; %i >= %Skill; %i-- )
	{
	if ( isLearnLivingSkill( %Player.GetPlayerID( ), %i )  == 1 )
	{
	%Mark = %i;
	break;
	}
	}
	if ( %Mark  <= 0 )
	return;*/

	%Ran = GetRanDom(1,100);
	%RecordRan = 0;
	for (%i = 1; %i <=10; %i++)
	{
		if ($TriggerEvent[%EventID,%i] $= "")
			break;
		%OneRan = GetWord($TriggerEvent[%EventID,%i],2);
		%RecordRan = %RecordRan + %OneRan;
		if (%RecordRan >= %Ran && %OneRan > 0)
		{
			%ItemID = GetWord($TriggerEvent[%EventID,%i],0);
			%ItemNum = GetWord($TriggerEvent[%EventID,%i],1);
			break;
		}
	}
	if (%ItemID > 0 &&  %ItemNum > 0)
	{
		%Player.PutItem(%ItemID,%ItemNum);
		if (%Player.Additem(4,%EventID) && %ItemID != 106040511)
		{
			for (%i = 501021010; %i >= %Skill; %i--)
			{
				if (isLearnLivingSkill(%Player.GetPlayerID(),%i) == 1)
				{
					addLivingSkillGuerdon(%Player,%i,1);
					break;
				}
			}
		}
	}
	else
	{
		%Txt = "���ź���һ��ͷ��ƫ��ʲôҲû���";
		SendOneScreenMessage(1,%Txt,%Player);	//��ɫ��Ϣ
	}
}

$TriggerEvent[551031001,1] = "106050201 1 45";
$TriggerEvent[551031001,2] = "106050202 1 5";
$TriggerEvent[551031001,3] = "106050101 1 43";
$TriggerEvent[551031001,4] = "106050105 1 4";
$TriggerEvent[551031001,5] = "105109301 1 2";
$TriggerEvent[551031001,6] = "105109303 1 1";

$TriggerEvent[551031002,1] = "106050202 1 45";
$TriggerEvent[551031002,2] = "106050203 1 5";
$TriggerEvent[551031002,3] = "106050101 1 43";
$TriggerEvent[551031002,4] = "106050105 1 4";
$TriggerEvent[551031002,5] = "105109301 1 2";
$TriggerEvent[551031002,6] = "105109303 1 1";

$TriggerEvent[551031003,1] = "106050203 1 45";
$TriggerEvent[551031003,2] = "106050204 1 5";
$TriggerEvent[551031003,3] = "106050101 1 43";
$TriggerEvent[551031003,4] = "106050105 1 4";
$TriggerEvent[551031003,5] = "105109301 1 2";
$TriggerEvent[551031003,6] = "105109303 1 1";

$TriggerEvent[551031004,1] = "106050204 1 45";
$TriggerEvent[551031004,2] = "106050205 1 5";
$TriggerEvent[551031004,3] = "106050101 1 43";
$TriggerEvent[551031004,4] = "106050105 1 4";
$TriggerEvent[551031004,5] = "105109301 1 2";
$TriggerEvent[551031004,6] = "105109303 1 1";

$TriggerEvent[551031005,1] = "106050205 1 45";
$TriggerEvent[551031005,2] = "106050206 1 5";
$TriggerEvent[551031005,3] = "106050101 1 43";
$TriggerEvent[551031005,4] = "106050105 1 4";
$TriggerEvent[551031005,5] = "105109301 1 2";
$TriggerEvent[551031005,6] = "105109303 1 1";

$TriggerEvent[551031006,1] = "106050206 1 45";
$TriggerEvent[551031006,2] = "106050207 1 5";
$TriggerEvent[551031006,3] = "106050101 1 43";
$TriggerEvent[551031006,4] = "106050105 1 4";
$TriggerEvent[551031006,5] = "105109301 1 2";
$TriggerEvent[551031006,6] = "105109303 1 1";

$TriggerEvent[551031007,1] = "106050207 1 45";
$TriggerEvent[551031007,2] = "106050208 1 5";
$TriggerEvent[551031007,3] = "106050101 1 43";
$TriggerEvent[551031007,4] = "106050105 1 4";
$TriggerEvent[551031007,5] = "105109301 1 2";
$TriggerEvent[551031007,6] = "105109303 1 1";

$TriggerEvent[551031008,1] = "106050208 1 45";
$TriggerEvent[551031008,2] = "106050209 1 5";
$TriggerEvent[551031008,3] = "106050101 1 43";
$TriggerEvent[551031008,4] = "106050105 1 4";
$TriggerEvent[551031008,5] = "105109301 1 2";
$TriggerEvent[551031008,6] = "105109303 1 1";

$TriggerEvent[551031009,1] = "106050209 1 45";
$TriggerEvent[551031009,2] = "106050210 1 5";
$TriggerEvent[551031009,3] = "106050101 1 43";
$TriggerEvent[551031009,4] = "106050105 1 4";
$TriggerEvent[551031009,5] = "105109301 1 2";
$TriggerEvent[551031009,6] = "105109303 1 1";

$TriggerEvent[551031010,1] = "106050209 1 45";
$TriggerEvent[551031010,2] = "106050210 1 5";
$TriggerEvent[551031010,3] = "106050101 1 43";
$TriggerEvent[551031010,4] = "106050105 1 4";
$TriggerEvent[551031010,5] = "105109301 1 2";
$TriggerEvent[551031010,6] = "105109303 1 1";


function TriggerEvent_551031001(%Player,%Event,%EventID){ TriggerEvent_551031001_551031010(%Player,%Event,%EventID,501031001); } //1����Ⱥ
function TriggerEvent_551031002(%Player,%Event,%EventID){ TriggerEvent_551031001_551031010(%Player,%Event,%EventID,501031002); } //2����Ⱥ
function TriggerEvent_551031003(%Player,%Event,%EventID){ TriggerEvent_551031001_551031010(%Player,%Event,%EventID,501031003); } //3����Ⱥ
function TriggerEvent_551031004(%Player,%Event,%EventID){ TriggerEvent_551031001_551031010(%Player,%Event,%EventID,501031004); } //4����Ⱥ
function TriggerEvent_551031005(%Player,%Event,%EventID){ TriggerEvent_551031001_551031010(%Player,%Event,%EventID,501031005); } //5����Ⱥ
function TriggerEvent_551031006(%Player,%Event,%EventID){ TriggerEvent_551031001_551031010(%Player,%Event,%EventID,501031006); } //6����Ⱥ
function TriggerEvent_551031007(%Player,%Event,%EventID){ TriggerEvent_551031001_551031010(%Player,%Event,%EventID,501031007); } //7����Ⱥ
function TriggerEvent_551031008(%Player,%Event,%EventID){ TriggerEvent_551031001_551031010(%Player,%Event,%EventID,501031008); } //8����Ⱥ
function TriggerEvent_551031009(%Player,%Event,%EventID){ TriggerEvent_551031001_551031010(%Player,%Event,%EventID,501031009); } //9����Ⱥ
function TriggerEvent_551031010(%Player,%Event,%EventID){ TriggerEvent_551031001_551031010(%Player,%Event,%EventID,501031010); } //10����Ⱥ
function TriggerEvent_551031001_551031010(%Player,%Event,%EventID,%Skill)
{
	if (%Player.GetBagEmptyCount() < 1)
	{
		%Txt = "��ı��������������������";
		SendOneScreenMessage(1,%Txt,%Player);//��ɫ��Ϣ
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
	}
	SetStrategyRecord(%Player,$StrategySubBtnSrc[3,2]);//���Դ�����¼
	%Ran = GetRanDom(1,100);
	%RecordRan = 0;
	//echo( "%Ran===" @ %Ran );
	for (%i = 1; %i <=10; %i++)
	{
		if ($TriggerEvent[%EventID,%i] $= "")
			break;
		%OneRan = GetWord($TriggerEvent[%EventID,%i],2);
		%RecordRan = %RecordRan + %OneRan;
		if (%RecordRan >= %Ran && %OneRan > 0)
		{
			%ItemID = GetWord($TriggerEvent[%EventID,%i],0);
			%ItemNum = GetWord($TriggerEvent[%EventID,%i],1);
			break;
		}
	}
	if (%ItemID > 0 &&  %ItemNum > 0)
	{
		%Player.PutItem(%ItemID,%ItemNum);
		if (%Player.Additem(4,%EventID))
		{
			for (%i = 501031010; %i >= %Skill; %i--)
			{
				if (isLearnLivingSkill(%Player.GetPlayerID(),%i) == 1)
				{
					addLivingSkillGuerdon(%Player,%i,1);
					break;
				}
			}
		}
	}

}

function TriggerEvent_551051001(%Player,%Event,%EventID){ TriggerEvent_551051001_551051010(%Player,%Event,%EventID,501051001); } //һ��ҩ��
function TriggerEvent_551051002(%Player,%Event,%EventID){ TriggerEvent_551051001_551051010(%Player,%Event,%EventID,501051002); } //����ҩ��
function TriggerEvent_551051003(%Player,%Event,%EventID){ TriggerEvent_551051001_551051010(%Player,%Event,%EventID,501051003); } //����ҩ��
function TriggerEvent_551051004(%Player,%Event,%EventID){ TriggerEvent_551051001_551051010(%Player,%Event,%EventID,501051004); } //�ļ�ҩ��
function TriggerEvent_551051005(%Player,%Event,%EventID){ TriggerEvent_551051001_551051010(%Player,%Event,%EventID,501051005); } //�弶ҩ��
function TriggerEvent_551051006(%Player,%Event,%EventID){ TriggerEvent_551051001_551051010(%Player,%Event,%EventID,501051006); } //����ҩ��
function TriggerEvent_551051007(%Player,%Event,%EventID){ TriggerEvent_551051001_551051010(%Player,%Event,%EventID,501051007); } //�߼�ҩ��
function TriggerEvent_551051008(%Player,%Event,%EventID){ TriggerEvent_551051001_551051010(%Player,%Event,%EventID,501051008); } //�˼�ҩ��
function TriggerEvent_551051009(%Player,%Event,%EventID){ TriggerEvent_551051001_551051010(%Player,%Event,%EventID,501051009); } //�ż�ҩ��
function TriggerEvent_551051010(%Player,%Event,%EventID){ TriggerEvent_551051001_551051010(%Player,%Event,%EventID,501051010); } //ʮ��ҩ��
function TriggerEvent_551051001_551051010(%Player,%Event,%EventID,%Skill)
{
	//if ( %Player.GetBagEmptyCount( ) < 1 )
	//{
	//	%Txt = "��ı��������������������";
	//	SendOneScreenMessage( 1, %Txt, %Player );//��ɫ��Ϣ
	//	SendOneChatMessage( $chatMsg_System, "<t>" @ %Txt @ "</t>", %Player );
	//}
	SetStrategyRecord(%Player,$StrategySubBtnSrc[3,3]);//���Դ�����¼
	for (%i = 501051010; %i >= %Skill; %i--)
	{
		if (isLearnLivingSkill(%Player.GetPlayerID(),%i) == 1)
		{
			addLivingSkillGuerdon(%Player,%i,1);
			break;
		}
	}
	return true;
}