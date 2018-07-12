//�������������������������񽻽������жϡ���������������������������������
//������������������������;���������жϡ���������������������������������

//��������������������������ȡ����ǰ�������жϡ���������������������������
//�������������������������������ǰ�������жϡ���������������������������

//��������������������������ԭ����Ϣ��������������������������������������

//�������������������������񽻽������жϡ���������������������������������
//if(%Other == 1) �ж��Ƿ���Ը�����ߣ�������
//if(%Other == 2) ��Ҫ�ж���������


function CanDoThisMission(%Player,%Mid,%Type,%Other,%Msg)
{
	//��������������ж�
	if (%Type == 1)
	{
		//�Ƿ��Ѿ���ɵ�ǰ����
		if (%Player.IsFinishedMission(%Mid))
			return SendWhyMsg(%Player,"B",%Type,%Msg);

		//�Ƿ��Ѿ����ܵ�ǰ����
		if (%Player.IsAcceptedMission(%Mid))
			return SendWhyMsg(%Player,"A",%Type,%Msg);

		//�ж�������ܵȼ�	//�Ƿ��Ѿ��ﵽ������ܵȼ�
		%Lv = (%Other < 2) ? $Mission_Data_LvA : $Mission_Data_SeeLvA;
		if (%Player.GetLevel() < GetMissionData(%Mid,%Lv))
			return SendWhyMsg(%Player,"L",%Type,%Msg);

		//ְҵ�ж�
		%PreClasses  = GetMissionData(%Mid,$Mission_Data_Family);
		if (%PreClasses > 0)
		{
			//echo("%PreClasses===" @ %PreClasses);
			%Classes = %Player.GetClasses(0);
			for (%i = 0; %i < 5; %i++)
			{
				if (HasBit(%PreClasses,%i) > 0)
					if (%Classes == (%i+1))
					{
						%ClassesH = "Pass";
						break;
					}
			}
			if (%ClassesH !$= "Pass")
				return SendWhyMsg(%Player,"BI",%Type,%Msg);
		}

		//�ŷ��ж�
		%PreFamily  = GetMissionData(%Mid,$Mission_Data_Classes);
		if (%PreFamily > 0)
		{
			%Family = %Player.GetFamily();
			for (%i = 0; %i < 4; %i++)
			{
				if (HasBit(%PreFamily,%i) > 0)
					if (%Family == (%i + 1))
					{
						%FamilyH = "Pass";
						break;
					}
			}
			if (%FamilyH !$= "Pass")
				return SendWhyMsg(%Player,"BJ",%Type,%Msg);
		}

		//������ж�
		%PreHomeplace  = GetMissionData(%Mid,$Mission_Data_Homeplace);
		if (%PreHomeplace > 0)
		{
			%Homeplace = GetHomeplace(%Player);
			for (%i = 0; %i < 5; %i++)
			{
				if (HasBit(%PreHomeplace,%i) > 0)
					if (%Homeplace == (%i + 1))
					{
						%HomeplaceH = "Pass";
						break;
					}
			}
			if (%HomeplaceH !$= "Pass")
				return SendWhyMsg(%Player,"F",%Type,%Msg);
		}

		//ǰ����������
		%PreMid = GetMissionData(%Mid,$Mission_Data_PreMid);

		//����ǰ�������ж�
		if (%PreMid > 1)
		{
			//�������δ��ɣ��򷵻ش�����ʾ
			if (!%Player.IsFinishedMission(%PreMid))
				return SendWhyMsg(%Player,"C",%Type,%Msg);
		}

		//�ж�ǰ�������ж��Ƿ�����
		//%Mission_EspeciallyTrigger = GetMissionData( %Mid, $Mission_Data_EspeciallyTrigger );
		/*
		if ( HasBit( %Mission_EspeciallyTrigger, 0 ) > 0 )
		{
		%MidName = "Mission_Begin_Front_"@ %Mid;
		%Mission_Begin = eval( %MidName @ "(%Npc, %Player, %Conv, %Param, %Mid);" );
		//echo( "�ж�ǰ�������ж��Ƿ�����%Mission_Begin ====" @ %Mission_Begin );
		//����ǿͻ��� ���� ֵΪ-1�򷵻ش���
		if ( ( $Now_Script == 1 ) && ( %Mission_Begin == -1 ) )
		return %Mission_Begin;
		else if ( %Other > 0 )
		{
		//��������ڿ��򷵻ش���
		if ( %Mission_Begin !$= "" )
		return %Mission_Begin;
		}
		}
		*/
		//�����������⴦��
		if (%Mid >= 20001 && %Mid <= 20024)
		{
			%MidName = "Mission_Begin_Front_"@ %Mid;
			%Mission_Begin = eval(%MidName @ "(%Npc, %Player, %Conv, %Param, %Mid);");
			if (%Mission_Begin !$= "")
				return %Mission_Begin;
		}
		//�ж��Ƿ�Ҫ�ٶ��������������
		if (%Other == 1)
		{
			//�Ƿ��ڲ�����״̬
			if (%Player.GetCaptivateState() >= 1)
				return SendWhyMsg(%Player,"V",0,1);

			//�Ѿ����ܵ����������Ƿ�����
			if (%Player.GetAcceptedMission() >= 20)
				return SendWhyMsg(%Player,"Q",%Type,%Msg);

			%ItemAdd = GetMissionData(%Mid,$Mission_Data_ItemAdd);		//���������ĵ���
			%ItemAddDel = GetMissionData(%Mid,$Mission_Data_ItemDelete);	//�Ƿ�Ҫ�۳����ϵ���

			if (($Now_Script == 2)&&(%ItemAdd !$= "0"))
			{
				%F = GetWordCount(%ItemAdd,";") / 2;

				for (%i = 0; %i < %F; %i++)
				{
					%Item = GetWord(%ItemAdd,%i * 2,";");
					%Num  = GetWord(%ItemAdd,%i * 2 + 1,";");

					if ((%Item $= "")&&(%Num $= ""))
						break;
					else
					{
						%Classes = %Player.GetClasses(0) - 1;
						%DataClasses = GetItemData(%Item,113);

						if ((%Num > 0) && ((%DataClasses == 0) || (HasBit(%DataClasses,%Classes))))
						{
							//ֱ��װ������
							%ConvText = GetMissionData(%Mid,$Mission_Data_EspeciallyTrigger);

							%bItemAdd = %Player.PutItem(%Item,%Num);
							%ItemText = %Item;

							//��ȡ�Ƿ�������Ʒ��
							%Mission_EspeciallyTrigger = GetMissionData(%Mid,$Mission_Data_EspeciallyTrigger);
							if (HasBit(%Mission_EspeciallyTrigger,10) > 0)
								%Player.SetPutItemProperty(%bItemAdd,1,%Player.GetPlayerID());
						}
					}
				}

				if (%ItemText > 0)
					%bItemAdd = %Player.AddItem(1,%Mid);

				if (!%bItemAdd)
					return SendWhyMsg(%Player,"I",%Type,%Msg);
			}

			//�ж��Ƿ���Ҫ�򿪰�������ʾ
			%ConvText = GetMissionData(%Mid,$Mission_Data_Conv);
			if ((HasBit(%ConvText,2) > 0) && (%ItemText > 0))
				ServerOnSptAction(%Player.GetPlayerID(),%ItemText,1);
		}
	}

	//��������������ж�
	if (%Type == 2)
	{
		if (%Player.IsFinishedMission(%Mid))		{ return SendWhyMsg(%Player,"B",%Type,%Msg); }		//�Ƿ��Ѿ���ɵ�ǰ����
		if (!%Player.IsAcceptedMission(%Mid))	{ return SendWhyMsg(%Player,"A",%Type,%Msg); }		//�Ƿ��Ѿ����ܵ�ǰ����

		//�����ȡ�����Ƿ��㹻
		for (%i = 0; %i < 9; %i++)
		{
			%ItemGet = %Player.GetMissionFlag(%Mid,2100 + %i);
			%GetNum  = %Player.GetMissionFlag(%Mid,2200 + %i);

			if (%ItemGet == 0)
				break;

			if (%Player.GetMissionFlag(%Mid,2300 + %i) < %Player.GetMissionFlag(%Mid,2200 + %i))
				return SendWhyMsg(%Player,"G",%Type,%Msg);
		}

		//������ʱ���ĵ����Ƿ��㹻����
		if (GetMissionData(%Mid,$Mission_Data_ItemDelete) > 0)//�Ƿ�Ҫ�۳���������ĵ��ߵ���
			for (%i = 0; %i < 9; %i++)
			{
				%ItemAdd    = %Player.GetMissionFlag(%Mid,2150 + %i);
				%AddNum     = %Player.GetMissionFlag(%Mid,2250 + %i);

				if (%ItemAdd == 0)
					break;

				if (%Player.GetMissionFlag(%Mid,2350 + %i) < %Player.GetMissionFlag(%Mid,2250 + %i))
					return SendWhyMsg(%Player,"S",%Type,%Msg);
			}

		//����ʹ�õ��������Ƿ��㹻
		for (%i = 0; %i < 9; %i++)
		{
			%ItemUse = %Player.GetMissionFlag(%Mid,2400 + %i);
			%UseNum  = %Player.GetMissionFlag(%Mid,2500 + %i);

			if (%ItemUse == 0)
				break;

			if (%Player.GetMissionFlag(%Mid,2600 + %i) < %UseNum)
				return SendWhyMsg(%Player,"U",%Type,%Msg);
		}

		//����ʹ�õ��ߴ���Ŀ�������Ƿ��㹻
		for (%i = 0; %i < 9; %i++)
		{
			%Target = %Player.GetMissionFlag(%Mid,1100 + %i);
			%TarNum = %Player.GetMissionFlag(%Mid,1200 + %i);

			if (%Target == 0)
				break;

			if (%Player.GetMissionFlag(%Mid,1300 + %i) < %TarNum)
				return SendWhyMsg(%Player,"T",%Type,%Msg);
		}

		//������;�ĶԻ�Ŀ�������Ƿ��㹻
		for (%i = 0; %i < 9; %i++)
		{
			%NpcX    = %Player.GetMissionFlag(%Mid,1150 + %i);
			%NpcXNum = %Player.GetMissionFlag(%Mid,1250 + %i);

			if (%NpcX == 0)
				break;

			if ((%NpcX > 0)&&(%Player.GetMissionFlag(%Mid,1350 + %i) < %NpcXNum)&&(%Other == 0))
				return SendWhyMsg(%Player,"N",%Type,%Msg);
		}

		//���������������Ƿ��㹻
		for (%i = 0; %i < 9; %i++)
		{
			%Monster = %Player.GetMissionFlag(%Mid,3100 + %i);
			%KillNum = %Player.GetMissionFlag(%Mid,3200 + %i);

			if (%Monster == 0)
				break;

			if (%Player.GetMissionFlag(%Mid,3300 + %i) < %Player.GetMissionFlag(%Mid,3200 + %i))
				return SendWhyMsg(%Player,"M",%Type,%Msg);
		}

		//�жϴ���������
		for (%i = 0; %i < 9; %i++)
		{
			%Step8X_Min = %Player.GetMissionFlag(%Mid,8100 + %i);
			%Step8X_Max = %Player.GetMissionFlag(%Mid,8000 + %i);

			if (%Step8X_Min == 0)
				break;

			if (%Player.GetMissionFlag(%Mid,8100 + %i) < %Player.GetMissionFlag(%Mid,8000 + %i))
				return SendWhyMsg(%Player,"P",%Type,%Msg);
		}

		//����ɼ�����Ŀ�������Ƿ��㹻
		for (%i = 0; %i < 9; %i++)
		{
			%CollectGet = %Player.GetMissionFlag(%Mid,2130 + %i);
			%CollectNum = %Player.GetMissionFlag(%Mid,2230 + %i);

			if (%CollectGet == 0)
				break;

			if (%Player.GetMissionFlag(%Mid,2330 + %i) < %CollectNum)
				return SendWhyMsg(%Player,"BK",%Type,%Msg);

		}

		//�ж�ǰ�������ж��Ƿ�����
		%Mission_EspeciallyTrigger = GetMissionData(%Mid,$Mission_Data_EspeciallyTrigger);
		if (HasBit(%Mission_EspeciallyTrigger,1) > 0)
		{
			%MidName = "Mission_End_Front_"@ %Mid;
			if (isFunction(%MidName))
				%Mission_End = eval("%Mission_End = " @ %MidName @ "(%Npc, %Player, %Conv, %Param, %Mid);");
			if (($Now_Script == 1) && (%Mission_End == -1))
				return %Mission_End;
			else if (%Other > 0)
			{
				if (%Mission_End !$= "")
					return %Mission_End;
			}
		}

		//�ж��Ƿ�Ҫ�ٶ��������������
		if (%Other == 1)
		{
			//�Ƿ��Ѿ��ﵽ���񽻸��ȼ�
			echo("�Ƿ��Ѿ��ﵽ���񽻸��ȼ�   " @ GetMetempsychosisLeve(%Player) @ "   " @ GetMissionData(%Mid,$Mission_Data_LvZ));
			if (GetMetempsychosisLeve(%Player) < GetMissionData(%Mid,$Mission_Data_LvZ))
				return SendWhyMsg(%Player,"Z",%Type,%Msg);
		}
	}

	return "";
}


//������������������������;���������жϡ���������������������������������
function CanDoMidwayMission(%Npc,%Player,%Mid,%Type,%Other,%Msg)
{
	//�Ƿ��Ѿ���ɵ�ǰ����
	if (%Player.IsFinishedMission(%Mid))
		return SendWhyMsg(%Player,"B",%Type,%Msg);

	//�Ƿ��Ѿ����ܵ�ǰ����
	if (!%Player.IsAcceptedMission(%Mid))
		return SendWhyMsg(%Player,"A",%Type,%Msg);

	switch (%Mid)
	{
		case 10001:return 0;//��������
		case 20205:return 0;//������ʿ
		case 10191:return 0;
		case 10241:return 0;
		case 10291:return 0;
		case 30001:return 0;//�����
		case 30002:return 0;
	}
	//������;�ĶԻ�Ŀ�������Ƿ��㹻
	for (%i = 0; %i < 9; %i++)
	{
		%NpcX    = %Player.GetMissionFlag(%Mid,1150 + %i);	//����,Ŀ����
		%NpcXNum = %Player.GetMissionFlag(%Mid,1250 + %i);	//����,Ŀ�괥������

		if (%NpcX == 0)
			break;

		if ((%Npc == %NpcX) || (%Npc.GetDataID() == %NpcX))
			if (%Player.GetMissionFlag(%Mid,1350 + %i) != %NpcXNum)
				return 1150 + %i;
	}

	return "";
}

//��������������������������ԭ����Ϣ��������������������������������������
function SendWhyMsg(%Player,%TiaoJian,%Type,%Msg)
{
	%Txt1 = "";
	%Txt2 = "";

	//�ж��Ƿ�Ҫ������Ϣ
	if (%Msg == 1)
		for (%i = 0; %i < 99; %i++)
		{
			%Why = GetWord(%TiaoJian,%i);
			if (%Why $= "")
				break;
			else
			{
				switch$(%Why)
				{
		case "A":%Txt1 = "���Ѿ������˴�����";
		case "B":%Txt1 = "���Ѿ�����˴�����";
		case "C":%Txt1 = "����δ���ǰ������";
		case "D":%Txt1 = "��δ��ӵ�������Ч��";
		case "E":%Txt1 = "ʱ���Ѵ����ޣ��޷���������";
		case "F":%Txt1 = "����ʥ�ز���";
		case "G":%Txt1 = "���ڽ��������Ʒ����������";

		case "H":%Txt1 = "������ɵ�ǰ�Ĳ��������԰�";
		case "I":%Txt1 = "�������������Ų�����Ʒ��";
		case "J":%Txt1 = "��ɫ�ȼ�����10�����޷�ʹ�ñ�����";
		case "K":%Txt1 = "������ֻ���ڡ��߳�1��ʹ��";
		case "L":%Txt1 = "���ĵȼ����ͣ��޷���ȡ����";
		case "M":%Txt1 = "���ڽ�����Ĺ�������������";
		case "N":%Txt1 = "����δ�ҵ�������Ҫ�Ի���NPC";

		case "O":%Txt1 = "���ľ��鲻��";
		case "P":%Txt1 = "��ѧ����Ӧ�������";
		case "Q":%Txt1 = "�����Ͻ��ܵ�������������";
		case "R":%Txt1 = "�����ڸ����ڣ��޷��л���ͼ";
		case "S":%Txt1 = "���ڽ��������Ʒ����������";
		case "T":%Txt1 = "���ڽ����������������";

		case "U":%Txt1 = "���ڽ��������Ʒ����������";
		case "V":%Txt1 = "���Ѿ����벻����״̬���޷��ӽ�����";
		case "W":%Txt1 = "���ľ�������������ֵ��40�������ֶ�����";
		case "X":%Txt1 = "���ı�������ɡ�Ů洵����ӡ�����";
		case "Y":%Txt1 = "���ľ����Ѿ��ﵽ���ޣ��޷��ۻ���������";
		case "Z":%Txt1 = "���ĵȼ����ͣ��޷��������";

		case "AA":%Txt1 = "���Ľ�ɫ������������ѡ�񸴻�";
		case "AB":%Txt1 = "���Ľ�ɫ����ս���У����Ժ�����";
		case "AC":%Txt1 = "���Ķ�Ա���ڸ��������ȼ��������԰�";
		case "AD":%Txt1 = "�ù���ֻ���Ƕӳ��ſ�ִ��";
		case "AE":%Txt1 = "���鲻����ù��ܵĿ�������";
		case "AF":%Txt1 = "��������ù��ܵĿ�������";
		case "AG":%Txt1 = "��ǰ�����ڵ�����¼��Ѿ�����";
		case "AH":%Txt1 = "����¼��������ã����Ժ�����";
		case "AI":%Txt1 = "����Ҫ����ǰ�����������ۻ������ſɽ��жɽ�";
		case "AJ":%Txt1 = "�������޷��ٴ�ʹ�øù����ˣ�������������";
		case "AK":%Txt1 = "���Ѿ���ȡ�˰�������������ɸ�����";
		case "AL":%Txt1 = "�������˸��������Ժ�һ��ʱ��������½�ȡ";
		case "AM":%Txt1 = "ʥ�ز������ù���ֻ�ܱ�ʥ�ص����ʹ��";
		case "AN":%Txt1 = "���ĵȼ����ͣ���Ҫ30���ſ�ִ�б�����";
		case "AO":%Txt1 = "��ǰ�����ڽ�ֹʹ�ô���Ʒ";
		case "AP":%Txt1 = "���Ѿ����벻����״̬�������������";
		case "AQ":%Txt1 = "���Ѿ����벻����״̬������������";
		case "AR":%Txt1 = "Ŀ���ڸ����ڣ��޷�ֱ��ǰ��";
		case "AS":%Txt1 = "�����ǰ������޷�ʹ�ñ�����";
		case "AT":%Txt1 = "�����ɵ�������������������";
		case "AU":%Txt1 = "���Ľ�Ҳ���";
		case "AV":%Txt1 = "��û�а���";
		case "AW":%Txt1 = "������ɱ�������������޷���ø��������";
		case "AX":%Txt1 = "�����յ�[��������]���������꣬������������";
		case "AY":%Txt1 = "��ǰ��ͼ�޷�ʹ�ñ�����";
		case "AZ":%Txt1 = "��û���㹻����Ʒ";

		case "BA":%Txt1 = "�����ǹ������޷�ʹ��";
		case "BB":%Txt1 = "�������ط����޷�ʹ��";
		case "BC":%Txt1 = "ֻ���ڹ���ս��ͼ��ʹ��";
		case "BD":%Txt1 = "ֻ�ܶ���ͨ�Ĺ��ǳ�ʹ�ã���ǰĿ����Ч";
		case "BE":%Txt1 = "Ŀ�깥�ǳ��Ѿ���װ�ɴ�Ч�����޷��ظ���װ";
		case "BF":%Txt1 = "��û�ж��飬�޷�ʹ��";
		case "BG":%Txt1 = "�ù���ֻ���Ƕ�Ա�ſ�ִ��";
		case "BH":%Txt1 = "������ɴ˶Ի�����";
		case "BI":%Txt1 = "���ĵ�ǰ��ְҵ�޷���ȡ������";
		case "BJ":%Txt1 = "���ĵ�ǰ���ŷ��޷���ȡ������";
		case "BK":%Txt1 = "����δ�ռ��㹻��Ҫ�ɼ�����Ʒ";
		case "BL":%Txt1 = "���ĵȼ��������޷�����û���";
		case "BM":%Txt1 = "��û����Ӧ���ߣ��޷�����û���";
		case "BN":%Txt1 = "����һ�εĶɽٽ�����δ��ȡ";
		case "BO":%Txt1 = "���Ľ����Ѿ�ֱ��װ��";
		case "BP":%Txt1 = "������λ�������޷��������";
		case "BQ":%Txt1 = "�����յ�[�����ػ���]���������꣬������������";
		case "BR":%Txt1 = "�����յ�[������Դ]���������꣬������������";
		case "BS":%Txt1 = "�����յ�[����б�]���������꣬������������";
		case "BT":%Txt1 = "�����յ�[��һ���]���������꣬������������";
				}

				//�жϵ�ǰ�Ƿ�Ϊ�ͻ��˵��ã���ϵͳ��Ϣ
				if ($Now_Script == 1)
				{
					SetScreenMessage(%Txt1,$Color[2]);
					SetChatMessage(%Txt1,$Color[2],$chatMsg_Person);
				}
				else
				{
					SendOneScreenMessage(2,%Txt1,%Player);
					SendOneChatMessage($chatMsg_System,"<t>" @ %Txt1 @ "</t>",%Player);
				}
			}
		}

	return %TiaoJian;
}


function SendWhyMsg_A(%Player,%Txt,%Msg)
{
	if (%Msg == 0)
		return;

	//�жϵ�ǰ�Ƿ�Ϊ�ͻ��˵��ã���ϵͳ��Ϣ
	if ($Now_Script == 1)
	{
		SetScreenMessage(%Txt,$Color[2]);
		SetChatMessage(%Txt,$Color[2],$chatMsg_Person);
	}
	else
	{
		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
	}
}
