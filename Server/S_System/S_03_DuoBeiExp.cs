//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//�౶���鵤
//
//==================================================================================
//�����������������ű������������������鵤����ʹ�á���������������
//�����������������ű���������������������ȡÿ��˫����������������
//�����������������ű�������������������ȼ��ӳɼ��㡿������������


//�����������������ű������������������鵤����ʹ�á���������������
function Trigger_105028001(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ) { Trigger_105028001_105028022(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1997,1998,1999); }//˫�����鵤
function Trigger_105028002(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ) { Trigger_105028001_105028022(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1997,1998,1999); }//˫�����鵤����Ʒ��
function Trigger_105028011(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ) { Trigger_105028001_105028022(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1998,1997,1999); }//2.5�����鵤
function Trigger_105028012(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ) { Trigger_105028001_105028022(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1998,1997,1999); }//2.5�����鵤����Ʒ��
function Trigger_105028021(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ) { Trigger_105028001_105028022(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1999,1998,1997); }//�������鵤
function Trigger_105028022(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ) { Trigger_105028001_105028022(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1999,1998,1997); }//�������鵤����Ʒ��

function Trigger_105028001_105028022(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%SchBuffID,%NoSchBuff1,%NoSchBuff2)
{
	if (%Player.IsSchBuff(%NoSchBuff1) == 1 || %Player.IsSchBuff(%NoSchBuff2) == 1)
	{
		%Txt = "���Ѿ�����������ӳɣ��޷���ʹ�þ��鵤";
		SendOneScreenMessage(2,%Txt,%Player);
		return;
	}
	if (%Player.GetSchBuff(%SchBuffID) < 68400)
	{
		%Player.PutItem(%Type,-1);
		if (%Player.AddItem(4,%Type))
		{
			if (%Player.IsSchBuff(%SchBuffID) ==1)
				%Player.AddSchBuff(%SchBuffID,-3600);
			else
			{
				%Player.SetSchBuff(%SchBuffID);
				%Player.AddSchBuff(%SchBuffID,82800);
			}
		}
		else
		{
			%Txt = "��û���㹻����Ʒ";
			SendOneScreenMessage(2,%Txt,%Player);	//��ɫ��Ϣ
			SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		}
	}
	else
		SendOneScreenMessage(2,"������Я����˫��ʱ���Ѵﵽ����",%Player);
}

//�����������������ű������������������鵤����ʹ�á���������������

//�����������������ű���������������������ȡÿ��˫����������������
function NpcDiaLog_410010113(%Npc,%Player,%State,%Conv)
{
	switch (%State)
	{
		case 0:
			if (GetSrc(%Player,1) == 0)
				%Conv.AddOption(100000,100000);//��ȡ�������˫��
			%Conv.AddOption(100001,100001);//�洢˫������ʱ��
			%Conv.AddOption(100002,100002);//ȡ��˫������ʱ��
		case 100000://��ȡ�������˫��
			if (GetSrc(%Player,1) == 0)
			{
				if (%Player.GetSchBuff(1997) < 50400)
				{
					SetSrc(%Player,1);
					if (%Player.IsSchBuff(1997) ==1)
						%Player.AddSchBuff(1997,-18000);
					else
					{
						%Player.SetSchBuff(1997);
						%Player.AddSchBuff(1997,50400);
					}
					SendOneScreenMessage(1,"��ȡ�ɹ�",%Player);
					SetStrategyRecord(%Player,$StrategySubBtnSrc[1,1]);//���Դ�����¼
					%Conv.Settype(4);
				}
				else
					SendOneScreenMessage(2,"�޷���ȡ�������ϵ�˫��ʱ�����",%Player);
			}
		case 100001://�洢˫������ʱ��
			%Conv.SetText(100008);
			%Conv.AddOption(100004,100004); //�洢һСʱ<
			%Conv.AddOption(100005,100005); //�洢ȫ��</t
			%Conv.AddOption(4,0);
		case 100002://ȡ��˫������ʱ��
			%Conv.SetText(100008);
			%Conv.AddOption(100006,100006);	//ȡ��һСʱ</t>";
			%Conv.AddOption(100007,100007);	//ȡ��ȫ��</t>";
			%Conv.AddOption(4,0);
		case 100004://�洢һСʱ
			%ACT_A = GetAct(%Player,3031,0);
			%ACT_B = GetAct(%Player,3031,1);
			%Time = %ACT_A * 3600 + %ACT_B;
			if (%Time >= 72000)
			{
				SendOneScreenMessage(2,"�޷��洢���洢��˫��ʱ�䲻�ܳ���20Сʱ",%Player);
				NpcCanDoJob(%Npc,%Player,0,%Conv);
			}
			else if (%Player.GetSchBuff(1997) < 3600)
			{
				SendOneScreenMessage(2,"�޷��洢�����ϵ�˫��ʱ�䲻��",%Player);
				NpcCanDoJob(%Npc,%Player,0,%Conv);
			}
			else
			{
				%ACT_A = %ACT_A + 1;
				%Player.AddSchBuff(1997,3600);
				SetAct(%Player,3031,%ACT_A,%ACT_B);
				SendOneScreenMessage(1,"�洢�ɹ�",%Player);

				%Conv.SetText(100008);
				%Conv.AddOption(100004,100004); //�洢һСʱ<
				%Conv.AddOption(100005,100005); //�洢ȫ��</t
				%Conv.AddOption(4,0);
			}
		case 100005://�洢ȫ��
			%ACT_A = GetAct(%Player,3031,0);
			%ACT_B = GetAct(%Player,3031,1);
			%Time = %ACT_A * 3600 + %ACT_B;

			if (%Time + %Player.GetSchBuff(1997) >= 72000)
			{
				SendOneScreenMessage(2,"�޷��洢���洢��˫��ʱ�䲻�ܳ���20Сʱ",%Player);
				NpcCanDoJob(%Npc,%Player,0,%Conv);
			}
			else if (%Player.GetSchBuff(1997) < 60)
			{
				SendOneScreenMessage(2,"�޷��洢�����ϵ�˫��ʱ�䲻��",%Player);
				NpcCanDoJob(%Npc,%Player,0,%Conv);
			}
			else
			{
				%ACT_B = %ACT_B + %Player.GetSchBuff(1997);
				%ACT_A = %ACT_A + mfloor(%ACT_B  / 3600);
				%ACT_B = Take_remainder(%ACT_B,3600);

				SetAct(%Player,3031,%ACT_A,%ACT_B);
				%Player.RemoveSchBuff(1997);
				SendOneScreenMessage(1,"�洢�ɹ�",%Player);
				%Conv.SetText(100008);
				%Conv.AddOption(4,0);
			}

		case 100006://ȡ��һСʱ
			%ACT_A = GetAct(%Player,3031,0);
			%ACT_B = GetAct(%Player,3031,1);
			%Time = %ACT_A * 3600 + %ACT_B;
			if (%Time < 3600)
			{
				SendOneScreenMessage(2,"ȡ��ʧ�ܣ��洢��˫��ʱ�䲻��",%Player);
				%Conv.SetText(100008);
				%Conv.AddOption(4,0);
			}
			else if (%Player.GetSchBuff(1997) + 3600 >= 68400)
			{
				SendOneScreenMessage(2,"ȡ��ʧ�ܣ����ϵ�˫���������",%Player);
				%Conv.SetText(100008);
				%Conv.AddOption(4,0);
			}
			else
			{
				%ACT_A = %ACT_A - 1;
				SetAct(%Player,3031,%ACT_A,%ACT_B);

				if (%Player.IsSchBuff(1997) ==1)
					%Player.AddSchBuff(1997,-3600);
				else
				{
					%Player.SetSchBuff(1997);
					%Player.AddSchBuff(1997,82800);
				}
				SendOneScreenMessage(1,"ȡ���ɹ�",%Player);
				%Conv.SetText(100008);
				%Conv.AddOption(100006,100006);	//ȡ��һСʱ</t>";
				%Conv.AddOption(100007,100007);	//ȡ��ȫ��</t>";
				%Conv.AddOption(4,0);
			}

		case 100007://ȡ��ȫ��
			%ACT_A = GetAct(%Player,3031,0);
			%ACT_B = GetAct(%Player,3031,1);
			%Time = %ACT_A * 3600 + %ACT_B;
			if (%Time > 0)
			{
				if (%Player.GetSchBuff(1997) + %Time >= 68400)
				{
					SendOneScreenMessage(2,"ȡ��ʧ�ܣ����ϵ�˫���������",%Player);
					%Conv.SetText(100008);
					%Conv.AddOption(4,0);
				}
				else
				{
					SetAct(%Player,3031,0,0);

					if (%Player.IsSchBuff(1997) ==1)
						%Player.AddSchBuff(1997,-%Time);
					else
					{
						%Player.SetSchBuff(1997);
						%Player.AddSchBuff(1997,86400 - %Time);
					}

					SendOneScreenMessage(1,"ȡ���ɹ�",%Player);
					%Conv.SetText(100008);
					%Conv.AddOption(4,0);
				}
			}
			else
			{
				SendOneScreenMessage(2,"ȡ��ʧ�ܣ�û�д洢��˫��ʱ��",%Player);
				%Conv.SetText(100008);
				%Conv.AddOption(4,0);
			}
	}
}
//�����������������ű���������������������ȡÿ��˫����������������



//�����������������ű�������������������ȼ��ӳɼ��㡿������������
function ShiJieLevelJiaCheng(%Player)//�������ӵ�ǰ�ļӳ�BUFF�ȼ�
{
	%Level = %Player.GetLevel();
	%Cha = $MaxLevelRecord - %Level;
	//echo( " %Level===" @  %Level );
	//echo( " %$MaxLevelRecord===" @  $MaxLevelRecord );
	//echo( " %Cha===" @  %Cha );
	if (%Cha <= 3)
	{
		%Player.ShiJieLevelJiaCheng = 0;
		return;
	}
	%BuffID = 39908 * 10000 + %Cha;
	//echo( " %BuffID===" @  %BuffID );
	%Player.Addbuff(%BuffID,%Player,1);
	%Player.ShiJieLevelJiaCheng = (%Cha-3)*0.03;
}
function SetShiJieZuiGaoLevel(%Playerid,%Level)//�洢ȫ����ߵȼ�
{
	//echo( "�洢ȫ����ߵȼ�=====" @ %Playerid );
	%MapID = GetZoneid();
	if (%MapID != 1001)
		return;
	%LineID = GetCurrentLineId();//�߳�ID
	%MaxLevel = GetWord(GetServerSystemEvent(%LineID),1);
	if (%MaxLevel < %Level)
	{
		SetServerSystemEvent(%LineID,%Playerid,%Level);
		$MaxLevelRecord = %Level;
	}
}
function SendShiJieLevelto1001(%PlayerID,%Level)//֪ͨ1001ˢ����ߵȼ�
{
	if (%Level > $MaxLevelRecord)
	{
		%List = %PlayerID @ "," @ %Level;
		%Functionname = "SetShiJieZuiGaoLevel(" @ %PlayerID @ "," @ %Level @ ");";
		//echo( "%Functionname===" @ %Functionname );
		SptInterMapExecute(1001,%Functionname);
	}
}
function GetShiJieZuiGaoLevel()//��ȡȫ����ߵȼ�
{
	%LineID = GetCurrentLineId();//�߳�ID
	%MaxLevel = GetWord(GetServerSystemEvent(%LineID),1);
	if (%MaxLevel > $MaxLevelRecord)
		$MaxLevelRecord = %MaxLevel;
	if ($MaxLevelRecord > 120)
		$MaxLevelRecord = 120;
}
function GetShiJieLevelJiaChengNum(%Player)//��ȡ������ߵȼ�����ӳ�����ֵ
{
	%Source = 1 + %Player.ShiJieLevelJiaCheng;
	return %Source;
}
//�����������������ű�������������������ȼ��ӳɼ��㡿������������
