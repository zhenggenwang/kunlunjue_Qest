//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//���������ű���������������ͨ����ű�
//��ͨ��������ͳһ������ģ�巽ʽ����
//
//==================================================================================
//������������������������������������������������������������������������
//����������������������������ű��ܽӿڡ���������������������������������
//������������������������������ȡ����������������������������������������
//��������������������������;�Ի�����������������������������������������
//������������������������������ɴ���������������������������������������

//����������������������������������û�����Ϣ����������������������������
//������������������������������;���û�����Ϣ����������������������������
//����������������������������������û�����Ϣ����������������������������
//������������������������������Ϣ�жϴ���ӿڡ���������������������������
//��������������������������ȡ��������������Ի����������������������

//�����������������������������������������������������������������������
//����������������������������������������������������������������������
//�����������������������������������������������������������������������
//��������������������������Ҫ���������Ʒ�Ĳɼ��������������������������
//�������������������������ɼ���Ӧ�������š�����������������������������

//������������������������������Ի��򡿡������������Ϳͻ��˿��ؽ��桿����

//����������������������������ű��ܽӿڡ���������������������������������
function Mission_Normal(%Npc,%Player,%State,%Conv,%Param)
{
	%ConvText = 0;

	%NpcID = %Npc.GetDataid();//��ȡNPCID

	%NpcA_Mid = GetStartNpcMission(%NpcID);//������ȡ������
	%NpcX_Mid = GetMidTalkNpcMission(%NpcID);	//���ڽ���������
	%NpcZ_Mid = GetEndNpcMission(%NpcID);//������ɵ�����

	%NpcA_Mid_MaxNum = GetWordCount(%NpcA_Mid);//������ȡ����������
	%NpcZ_Mid_MaxNum = GetWordCount(%NpcZ_Mid);//������ɵ���������
	%NpcX_Mid_MaxNum = GetWordCount(%NpcX_Mid);//���ڽ�������������

	if (%State == 0)
	{
		//������ǰNPC���пɽ������񣬲�������Ӧѡ��
		for (%z = 0; %z < %NpcZ_Mid_MaxNum; %z++)
		{
			%Mid = GetWord(%NpcZ_Mid,%z);												//��ȡ����ID
			if (!Mission_End_SeeOption(%Player,%Mid))							//�Ƿ���ʾ(�����ж�)
				if (CanDoThisMission(%Player,%Mid,2,0,0) $= "")	//�Ƿ���ʾ(�����ж�)
					if (%Mid == %Player.PostMid)
						%Conv.AddOption(900 @ %Mid,910 @ %Mid,5);			//��ʾ������ѡ��
					else
						%Conv.AddOption(900 @ %Mid,910 @ %Mid,2);			//��ʾ������ѡ��

		}

		//������ǰNPC������;�Ի������񣬲�������Ӧѡ��
		for (%z = 0; %z < %NpcX_Mid_MaxNum; %z++)
		{
			%Mid = GetWord(%NpcX_Mid,%z);															//��ȡ����ID
			if (!Mission_midway_SeeOption(%Player,%Mid))								//�Ƿ���ʾ(�����ж�)
				if (CanDoMidwayMission(%Npc,%Player,%Mid,0,0,0) > 0)	//�Ƿ���ʾ(�����ж�)
				{

					%Conv.AddOption(200 @ %Mid,210 @ %Mid);								//��ʾ������ѡ��
				}
		}
		switch ($Mission_ActRecord[%NpcID] * 1)
		{
			case 0:
				//������ǰNPC���пɽӵ����񣬲�������Ӧѡ��
				for (%a = 0; %a < %NpcA_Mid_MaxNum; %a++)
				{
					%Mid = GetWord(%NpcA_Mid,%a);												//��ȡ����ID
					//echo("Mission_Begin_SeeOption(" @ %Player @ "," @ %Mid @ ")=====" @ Mission_Begin_SeeOption(%Player, %Mid));
					//echo("CanDoThisMission("@ %Player @ "," @ %Mid @ ", 1, 0, 0)====" @ CanDoThisMission(%Player, %Mid, 1, 0, 0));
					if (!Mission_Begin_SeeOption(%Player,%Mid))						//�Ƿ���ʾ(�����ж�)
						if (CanDoThisMission(%Player,%Mid,1,0,0) $= "")	//�Ƿ���ʾ(�����ж�)
						{
							if (%Mid == %Player.PostMid)
								%Conv.AddOption(100 @ %Mid,110 @ %Mid,4);//��ʾ������ѡ��(��1������)
							else
								%Conv.AddOption(100 @ %Mid,110 @ %Mid,1);//��ʾ������ѡ��(��2������)
						}
				}
			default://�ⲿ��NPC�����������ѭ��������Ҫ��������
				%Act = $Mission_ActRecord[%NpcID];
				//%Activity1 = GetWord( %Player.Getactivity( %Act ), 1 );
				//------------��ȡ���NPC�������е�����==7��������
				%NeedMission = "";
				for (%bbc = 0; %bbc < %NpcA_Mid_MaxNum; %bbc++)
				{
					%Midbbc = GetWord(%NpcA_Mid,%bbc);
					%Midtypebbc = GetMissionData(%Midbbc,$Mission_Data_Type);
					if (%Midtype  == 7)
						%NeedMission = %Midbbc @ " " @ %NeedMission;
				}
				%NeedMissionCount = GetWordcount(%NeedMission);
				for (%jj = 0; %jj < %NeedMissionCount; %jj++)
				{
					%Midjj = GetWord(%NeedMission,%jj);
					%Midtypejj = GetMissionData(%Midjj,$Mission_Data_Type);
					if (%Player.IsAcceptedMission(%Midjj) && %Midtypejj  == 7)//�Ƿ��ѽ�����
					{
						%NoMoreMid = 1;
						break;
					}
				}
				for (%a = 0; %a < %NpcA_Mid_MaxNum; %a++)
				{
					%Mid = GetWord(%NpcA_Mid,%a);
					%Midtype = GetMissionData(%Mid,$Mission_Data_Type);
					%MidRecord = 0;//ÿ�ο�ʼ�ж�ǰ��ʼ�����
					%Activity0 = GetWord(%Player.Getactivity(%Act),0)* 1;

					if (%Midtype == 7 && %NoMoreMid  != 1)//������ճ����� ��Ҫ���⴦��
					{
						if (%Activity0 <= 0)
						{
							%Ran = GetRandom(0,%NeedMissionCount -1);
							%NeddMid = GetWord(%NeedMission,%Ran);
							if (GetMissionData(%NeddMid,$Mission_Data_Mid) > 0)
							{
								%MidRecord = %NeddMid;
								SetAct(%Player,%Act,%MidRecord,0);
							}
						}
						else
						{
							if (%Player.IsAcceptedMission(%Activity0))//�Ƿ��ѽ�����
								%MidRecord = 0;
							else
								%MidRecord = %Activity0;
						}
					}
					else
						%MidRecord = %Mid;

					if (%MidRecord > 0)
					{
						if (!Mission_Begin_SeeOption(%Player,%MidRecord))						//�Ƿ���ʾ(�����ж�)
							if (CanDoThisMission(%Player,%MidRecord,1,0,0) $= "")	//�Ƿ���ʾ(�����ж�)
							{
								if (%MidRecord == %Player.PostMid)
									%Conv.AddOption(100 @ %MidRecord,110 @ %MidRecord,4);//��ʾ������ѡ��(��1������)
								else
									%Conv.AddOption(100 @ %MidRecord,110 @ %MidRecord,1);//��ʾ������ѡ��(��2������)
							}
					}
				}
		}
	}

	if ((%State > 0)&&(strlen(%State) == 8))
	{
		//��ȡ������Ϣ
		%MidState = GetSubStr(%State,0,3);						//��ȡ�������ͣ��ɽӡ��ɽ���
		%Mid      = GetSubStr(%State,3,5);						//��ȡ������
		//������Ҫ�жϵ�ǰ��
		switch (%MidState)
		{
			case 110:	%Type = 0;
			case 210:	%Type = -1;
			case 910:	%Type = 1;
			default: return;
		}

		//����ǰ���жϣ����⣩
		%Result = Mission_Estimate_Confluence(%Player,%Conv,%Mid,%Type);
		if (%Result == 0)
		{
			%MidName = "Mission_Normal_" @ %MidState;
			eval(%MidName @ "(%Npc, %Player, %State, %Conv, %Param, %Mid);");
		}
	}
}

//������������������������������ȡ����������������������������������������
function Mission_Normal_110(%Npc,%Player,%State,%Conv,%Param,%Mid)
{
	//������ܲ���
	if (CanDoThisMission(%Player,%Mid,1,1,1) $= "")
	{
		//�������������Ϣ
		%Txt = AddMissionAccepted(%Player,%Conv,%Mid);

		//��ȡ��Npc�Ƿ��пɽӡ��ɽ����������
		%Unpack = Mission_DialogBox_Unpack(%Npc,%Player,%State,%Conv,%Param,%Mid);
	}
	else
		%Conv.SetType(4);
}

//��������������������������;�Ի�����������������������������������������
function Mission_Normal_210(%Npc,%Player,%State,%Conv,%Param,%Mid)
{
	%FlagID = CanDoMidwayMission(%Npc,%Player,%Mid,0,0,0);
	if (%FlagID > 0)
		AddMissionMidway(%FlagID,%Player,%Mid,%Param,%Conv);
	else
		%Conv.SetType(4);
}

//������������������������������ɴ���������������������������������������
function Mission_Normal_910(%Npc,%Player,%State,%Conv,%Param,%Mid)
{
	if (CanDoThisMission(%Player,%Mid,2,1,1) $= "")
	{
		//����������
		AddMissionReward(%Player,%Mid,%Param,%Conv);
		//��ȡ��Npc�Ƿ��пɽӡ��ɽ����������
		%Unpack = Mission_DialogBox_Unpack(%Npc,%Player,%State,%Conv,%Param,%Mid);
	}
	else
		%Conv.SetType(4);
}

//����������������������������������û�����Ϣ����������������������������
function AddMissionAccepted(%Player,%Conv,%Mid)
{
	//�������ж�
	if (%Player.GetCaptivateState() >= 1)
	{
		%Conv.SetText(86);
		%Conv.AddOption(4,0);
		%Conv.Send(%Player);
		return SendWhyMsg(%Player,"V",0,1);
	}

	//�����������
	%Player.SetMissionFlag(%Mid,1,1);

	//��ʾ��ȡ��Ϣ
	SendOneChatMessage($chatMsg_Person,"<t>��������[" @ GetMissionData(%Mid,$Mission_Data_Name) @ "]����</t>",%Player);
	SendOneScreenMessage(1,"��������[" @ GetMissionData(%Mid,$Mission_Data_Name) @ "]����",%Player);

	//�����Ƿ���Ҫɱ��
	%MissionData_MonsterKill = GetMissionData(%Mid,$Mission_Data_KillMonster);
	%MissionData_MonsterKill_Num = GetWordCount(%MissionData_MonsterKill,";");
	if (%MissionData_MonsterKill !$= "0")
		for (%i = 0; %i < %MissionData_MonsterKill_Num; %i++)
		{
			%Monster = GetWord(%MissionData_MonsterKill,%i * 2,";");
			%KillNum = GetWord(%MissionData_MonsterKill,%i * 2 + 1,";");

			if ((%Monster $= "")&&(%KillNum $= ""))
				break;
			else
			{
				%Player.SetMissionFlag(%Mid,3100 + %i,%Monster);	//����,������
				%Player.SetMissionFlag(%Mid,3200 + %i,%KillNum);	//����,��������
				%Player.SetMissionFlag(%Mid,3300 + %i,0); 				//����,���ﵱǰ����
			}
		}

	//������;�Ƿ���ҪѰ��Ŀ��
	%MissionData_NpcX = GetMissionData(%Mid,$Mission_Data_NpcX);
	%MissionData_NpcX_Num = GetWordCount(%MissionData_NpcX,";");
	if (%MissionData_NpcX !$= "0")
		for (%i = 0; %i < %MissionData_NpcX_Num; %i++)
		{
			%NpcX    = GetWord(%MissionData_NpcX,%i * 2,";");
			%NpcXNum = GetWord(%MissionData_NpcX,%i * 2 + 1,";");

			if ((%NpcX $= "")&&(%NpcXNum $= ""))
				break;
			else
			{
				%Player.SetMissionFlag(%Mid,1150 + %i,%NpcX);			//����,Ŀ����
				%Player.SetMissionFlag(%Mid,1250 + %i,%NpcXNum);	//����,Ŀ�괥������
				%Player.SetMissionFlag(%Mid,1350 + %i,0); 				//����,Ŀ�괥����ǰ����
			}
		}

	//�����Ƿ���Ҫ��ȡ��Ʒ
	%MissionData_ItemGet = GetMissionData(%Mid,$Mission_Data_ItemGet);
	%MissionData_ItemGet_Num = GetWordCount(%MissionData_ItemGet,";");
	if (%MissionData_ItemGet !$= "0")
		for (%i = 0; %i < %MissionData_ItemGet_Num; %i++)
		{
			%ItemGet = GetWord(%MissionData_ItemGet,%i * 2,";");
			%GetNum  = GetWord(%MissionData_ItemGet,%i * 2 + 1,";");

			if ((%ItemGet $= "")&&(%GetNum $= ""))
				break;
			else
			{
				if (%Player.GetItemCount(%ItemGet) > %GetNum)
					%NowNum  = %GetNum;
				else
					%NowNum  = %Player.GetItemCount(%ItemGet);

				%Player.SetMissionFlag(%Mid,2100 + %i,%ItemGet);	//����,ITEM���
				%Player.SetMissionFlag(%Mid,2200 + %i,%GetNum);		//����,ITEM��ȡ����
				%Player.SetMissionFlag(%Mid,2300 + %i,%NowNum); 	//����,ITEM��ȡ��ǰ����
			}
		}

	//�����Ƿ���Ҫ������Ʒ
	%MissionData_ItemAdd = GetMissionData(%Mid,$Mission_Data_ItemAdd);
	%MissionData_ItemAdd_Num = GetWordCount(%MissionData_ItemAdd,";");

	if (GetMissionData(%Mid,$Mission_Data_ItemDelete) > 0)
		if (%MissionData_ItemAdd !$= "0")
			for (%i = 0; %i < %MissionData_ItemAdd_Num; %i++)
			{
				%ItemAdd = GetWord(%MissionData_ItemAdd,%i * 2,";");
				%AddNum  = GetWord(%MissionData_ItemAdd,%i * 2 + 1,";");

				if ((%ItemAdd $= "")&&(%AddNum $= ""))
					break;
				else
				{
					if (%Player.GetItemCount(%ItemAdd) > %AddNum)
						%NowNum  = %AddNum;
					else
						%NowNum  = %Player.GetItemCount(%ItemAdd);
					%Player.SetMissionFlag(%Mid,2150 + %i,%ItemAdd);	//����,ITEM���
					%Player.SetMissionFlag(%Mid,2250 + %i,%AddNum);		//����,ITEM��������
					%Player.SetMissionFlag(%Mid,2350 + %i,%NowNum);		//����,ITEM���䵱ǰ����
				}
			}

	//�����Ƿ���Ҫʹ���������
	%MissionData_Target = GetMissionData(%Mid,$Mission_Data_ItemUseTarget);
	%MissionData_Target_Num = GetWordCount(%MissionData_Target,";");

	if (%MissionData_Target !$= "0")
	{
		for (%i = 0; %i < %MissionData_Target_Num; %i++)
		{
			%Target = GetWord(%MissionData_Target,%i * 2,";");
			%TarNum = GetWord(%MissionData_Target,%i * 2 + 1,";");

			if ((%Target $= "")&&(%TarNum $= ""))
				break;
			else
			{
				//��δ�ɼ�����������
				if (GetSubStr(%Target,0,1) == 5)
					%Cj = 1030;	//2130 2230 2330
				//echo( 1100 + %Cj + %i @ "    %Target=" @ %Target  @ "   %TarNum===" @ %TarNum );
				%Player.SetMissionFlag(%Mid,1100 + %Cj + %i,%Target);		//����,������
				%Player.SetMissionFlag(%Mid,1200 + %Cj + %i,%TarNum);		//����,���ⴥ������
				%Player.SetMissionFlag(%Mid,1300 + %Cj + %i,0); 				//����,���ⴥ����ǰ����
			}
		}
	}

	//�����Ƿ���Ҫ�����Ĳɼ��¼�
	%Mission_Data_Cj = GetMissionData(%Mid,$Mission_Data_Cj);
	%Mission_Data_Cj_Num = GetWordCount(%Mission_Data_Cj,";");
	//echo( "%Mission_Data_Cj===" @ %Mission_Data_Cj );
	//echo( "%Mission_Data_Cj_Num===" @ %Mission_Data_Cj_Num );
	if (%Mission_Data_Cj !$= "0")
	{
		for (%i = 0; %i < %Mission_Data_Cj_Num; %i++)
		{
			%Cj_A = GetWord(%Mission_Data_Cj,%i * 2,";");
			%Cj_Z = GetWord(%Mission_Data_Cj,%i * 2 + 1,";");

			if ((%Cj_A $= "")&&(%Cj_Z $= ""))
				break;
			else
			{
				//echo( 1400 + %i @ "    %Mid===" @ %Mid @ "   " @ "%Cj_A===" @ %Cj_A  @ "   " @ "%Cj_Z===" @ %Cj_Z );
				//echo( );
				%Player.SetMissionFlag(%Mid,1400 + %i,%Cj_A);		//����,�ɼ�����
				%Player.SetMissionFlag(%Mid,1500 + %i,%Cj_Z);		//����,�ɼ��ｻ�����
			}
		}
	}
	//echo( %Player.GetMissionFlag( %Mid, 1400 ) );
	//echo( %Player.GetMissionFlag( %Mid, 1500 ) );
	//echo( %Player.GetMissionFlag( %Mid, 1600 ) );
	//����״̬
	%MissionData_X_Man = GetMissionData(%Mid,$Mission_Data_X_Man);
	if (%MissionData_X_Man !$= "0")
	{
		%Player.SetMissionFlag(%Mid,6000,%MissionData_X_Man); //����,����Buff״̬���
		%Player.AddBuff(%MissionData_X_Man,0);
	}

	//����9000��9100���[��������]
	%Mission_EspeciallyTrigger = GetMissionData(%Mid,$Mission_Data_EspeciallyTrigger);
	for (%i = 0; %i < 3; %i++)
	{
		if (HasBit(%Mission_EspeciallyTrigger,4 + %i) > 0)
			%Player.SetMissionFlag(%Mid,9000 + %i,1);

		if (HasBit(%Mission_EspeciallyTrigger,7 + %i) > 0)
			%Player.SetMissionFlag(%Mid,9100 + %i,1);
	}

	%Player.UpdateMission(%Mid);//����������Ϣ
	if (%Player.LogicFloorRecord <= 0)
		HelpDirectByIndex(%Player.GetPlayerID(),64);	//���ͽ�������Ч
	ServerOnSptAction(%Player.GetPlayerID(),%Mid,3);//ͨѶ�ͻ���
	//��ȡ����ʱǰ�ô���
	Mission_Estimate_Confluence(%Player,%Conv,%Mid,2);
}

//������������������������������;���û�����Ϣ����������������������������
function AddMissionMidway(%FlagID,%Player,%Mid,%Param,%Conv)
{
	%NpcX  = %Player.GetMissionFlag(%Mid,%FlagID);				//��ȡ,Ŀ����
	%NpcXA = %Player.GetMissionFlag(%Mid,%FlagID + 100);	//��ȡ,Ŀ�괥������
	%NpcXB = %Player.GetMissionFlag(%Mid,%FlagID + 200);	//��ȡ,Ŀ�괥����ǰ����

	SendOneScreenMessage(1,"�Ի� ��"@ GetNpcData(%NpcX,1) @"�� "@%NpcXB + 1@"/"@%NpcXA,%Player);
	%Player.SetMissionFlag(%Mid,%FlagID + 200,%NpcXB + 1,true);	//����,Ŀ�괥����ǰ����
	%Conv.SetText(300 + (%FlagID - 1150) @ %Mid);
	

}

//����������������������������������û�����Ϣ����������������������������
function AddMissionReward(%Player,%Mid,%Param,%Conv)
{
	//��ȡ������Ϣ
	%PlayerID	= %Player.GetPlayerID();

	//�������ж�
	if (%Player.GetCaptivateState() >= 1)
	{
		%Conv.SetText(86);
		%Conv.AddOption(4,0);
		%Conv.Send(%Player);
		return SendWhyMsg(%Player,"V",0,1);
	}

	//�۳������ȡ����
	switch (%Mid)
	{
		case 20025:
		case 20026:
		case 20027:
		default:
			for (%i = 0; %i < 9; %i++)
			{
				%ItemGet = %Player.GetMissionFlag(%Mid,2100 + %i);
				%GetNum  = %Player.GetMissionFlag(%Mid,2200 + %i);

				%ItemType = GetItemData(%ItemGet, 3);
				//echo("%ItemType===" @ %ItemType);
				//echo("%GetNum===" @ %GetNum);
				//echo("$Item_Monster[%ItemGet]===" @ $Item_Monster[%ItemGet]);
				//echo("%Player.GetItemCount(%ItemGet)===" @ %Player.GetItemCount(%ItemGet));
				if (%ItemType == 802  && %Player.GetItemCount(%ItemGet) > %GetNum)//����۳�����������Ʒ
					%GetNum = %Player.GetItemCount(%ItemGet);
				//echo("%ItemGet===" @ %ItemGet);
				//echo("%GetNum===" @ %GetNum);
				if ((%ItemGet > 0) && (%GetNum > 0))
				{
					%Player.PutItem(%ItemGet,-%GetNum);
				}
				else
					break;
			}
	}
	//�۳�������ʱ���ĵ���
	%MissionData_ItemAdd = GetMissionData(%Mid,$Mission_Data_ItemAdd);
	%MissionData_ItemAdd_Num = GetWordCount(%MissionData_ItemAdd,";")/2;
	if (GetMissionData(%Mid,$Mission_Data_ItemDelete) > 0)
		if (%MissionData_ItemAdd !$= "0")
			for (%i = 0; %i < %MissionData_ItemAdd_Num; %i++)
			{
				%ItemAdd    = GetWord(%MissionData_ItemAdd,%i * 2,";");
				%AddNum     = GetWord(%MissionData_ItemAdd,%i * 2 + 1,";");

				if ((%ItemAdd $= "")&&(%AddNum $= ""))
					break;

				%PutItem[%index++] = %Player.PutItem(%ItemAdd,-%AddNum);
			}

	//ֱ��װ������
	%ConvText = GetMissionData(%Mid,$Mission_Data_EspeciallyTrigger);

	%Sex = %Player.GetSex();
	%Classes = %Player.GetClasses(0);

	//��ѡ���Ե���
	if ($MissionData_ItemChose[%Mid] !$= "")
	{
		for (%i = 0; %i <= 99; %i++)
		{
			%Item = GetWord($MissionData_ItemChose[%Mid],%i * 2,";");
			%Num  = GetWord($MissionData_ItemChose[%Mid],%i * 2 + 1,";");
			if ((%Item $= "")&&(%Num $= ""))
				break;
			//echo( "%Item===" @ %Item @ "    %Num===" @ %Num );
			%ItemJob =  GetItemData(%Item,113);
			%ItemSex = GetItemData(%Item,24);
			//echo( " CheckBit( " @ %ItemJob @ ", " @ %Classes - 1 @ " ) ======" @  CheckBit( %ItemJob, %Classes ) );
			if (CheckBit(%ItemJob,%Classes - 1) == 1)
			{
				if (%ItemSex == 0 || %ItemSex == %Sex)
					%MissionData_ItemChose = %MissionData_ItemChose @ %Item @ ";" @ %Num @ ";";
			}
		}
		//echo( "%MissionData_ItemChose===" @ %MissionData_ItemChose );
	}
	else
		%MissionData_ItemChose = GetMissionData(%Mid,$Mission_Data_ItemChose);
	//echo( "%MissionData_ItemChose ==" @ %MissionData_ItemChose );
	if (%MissionData_ItemChose !$= "0")
	{
		%ItemChose = GetWord(%MissionData_ItemChose,(%Param) * 2,";");
		%ChoseNum  = GetWord(%MissionData_ItemChose,(%Param) * 2 + 1,";");

		if ((%ItemChose !$= "")&&(%ChoseNum !$= ""))
		{
			if (HasBit(%ConvText,11) > 0)
				%ItemZhuangBei = (%ItemZhuangBei $= "") ? %ItemChose : %ItemZhuangBei @ ";" @ %ItemChose;
			else
			{
				%ItemChoseH = %ItemChose;
				%PutItem[%index++] = %Player.PutItem(%ItemChose,%ChoseNum);
			}
		}
	}
	//�ظ��ĵ���
	if ($MissionData_ItemSet[%Mid] !$= "")
		%MissionData_ItemChose = $MissionData_ItemSet[%Mid];
	else
		%MissionData_ItemSet = GetMissionData(%Mid,$Mission_Data_ItemSet);

	//echo( "%MissionData_ItemSet ==" @ %MissionData_ItemSet );
	if (%MissionData_ItemSet !$= "0")
		for (%i = 0; %i < 50; %i++)
		{
			%ItemSet = GetWord(%MissionData_ItemSet,%i * 2,";");
			%SetNum  = GetWord(%MissionData_ItemSet,%i * 2 + 1,";");

			if ((%ItemSet $= "")&&(%SetNum $= ""))
				break;
			else
			{
				if (HasBit(%ConvText,11) > 0)
					%ItemZhuangBei = (%ItemZhuangBei $= "") ? %ItemSet : %ItemZhuangBei @ ";" @ %ItemSet;
				else
				{
					%ItemSetH = %ItemSet;
					%PutItem[%index++] = %Player.PutItem(%ItemSet,%SetNum);
				}
			}
		}

	//����ְҵ�������
	if ($Mission_Data_ItemClasses[%Mid] !$= "")
		%MissionData_ItemClasses = $Mission_Data_ItemClasses[%Mid];
	else
		%MissionData_ItemClasses = GetMissionData(%Mid,$Mission_Data_ItemClasses);


	//echo( "%MissionData_ItemClasses ==" @ %MissionData_ItemClasses );
	if (%Mission_Data_Classes !$= "0")
		for (%i = 0; %i < 50; %i++)
		{
			%ItemClasses = GetWord(%MissionData_ItemClasses,%i * 2,";");
			%SetNum  = GetWord(%MissionData_ItemClasses,%i * 2 + 1,";");

			if ((%ItemClasses $= "")&&(%SetNum $= ""))
				break;
			else
			{
				if (HasBit(GetItemData(%ItemClasses,113),%Classes - 1) > 0)
				{
					if (GetItemData(%ItemClasses,24) == 0 || GetItemData(%ItemClasses,24) == %sex)
					{
						if (HasBit(%ConvText,11) > 0)
							%ItemZhuangBei = (%ItemZhuangBei $= "") ? %ItemClasses : %ItemZhuangBei @ ";" @ %ItemClasses;
						else
						{
							%ItemClassesH = %ItemClasses;
							%PutItem[%index++] = %Player.PutItem(%ItemClasses,%SetNum);
						}
					}

				}
			}
		}

	//��ȡ�Ƿ�������Ʒ��
	%Mission_EspeciallyTrigger = GetMissionData(%Mid,$Mission_Data_EspeciallyTrigger);
	if (HasBit(%Mission_EspeciallyTrigger,10) > 0)
	{
		for (%index = 1; %index < 100; %index++)
		{
			if (%PutItem[%index] $= "")
				break;

			//������ƷΪ��
			%Player.SetPutItemProperty(%PutItem[%index],1,%PlayerID);
		}
	}

	//�������ߣ�һ���Բ���
	if (!%Player.AddItem(1,%Mid))
		return SendWhyMsg(%Player,"T",0,1);

	//�ж��Ƿ���Ҫ�򿪰�������ʾ
	%ConvText = GetMissionData(%Mid,$Mission_Data_Conv);
	if (HasBit(%ConvText,3) > 0)
	{
		//ѡ���Ե���
		if (%ItemChoseH > 0)
			ServerOnSptAction(%Player.GetPlayerID(),%ItemChose,1);

		//�ظ�����
		if (%ItemSetH > 0)
			ServerOnSptAction(%Player.GetPlayerID(),%ItemSetH,1);

		//����ְҵ�������
		if (%ItemClassesH > 0)
			ServerOnSptAction(%Player.GetPlayerID(),%ItemClassesH,1);
	}

	//���ֱ��װ������
	if (%ItemZhuangBei !$= "")
	{
		for (%i = 0; %i < 9; %i++)
		{
			%ItemZhuangBeiID = GetWord(%ItemZhuangBei,%i,";");
			if (%ItemZhuangBeiID $= "")
				break;

			//������Ϊ��������
			if (GetItemData(%ItemZhuangBeiID,2) == 18)
			{
				%PetID = GetItemData(%ItemZhuangBeiID,35);
				%bTemp = GeneratePetInfo(%PlayerID,%PetID,1,2,0,1);//�����������

				if (%bTemp != -1)
				{
					%Player.AddBuff(320210023); //�ٻ����ﶨ��״̬
					%Player.SpawnPet(%bTemp);//�Զ��ٻ�����
					%Player.ShowDialogOk(2000000012,23,0);
				}
				else
					return SendWhyMsg(%Player,"BP",0,1);
			}
			else
			{
				if (%Player.AddItemToEquip(%ItemZhuangBeiID,0) == 1)
					%Player.ShowDialogOk(2000000013,23,0);
			}
		}
	}

	//��ȡ������������
	%TempExp = GetMissionData(%Mid,$Mission_Data_Exp);
	if (%TempExp > 0)
	{
		if (GetMissionData(%Mid,$Mission_Data_Type) == 1)
		{
			//�����ֻغ�ľ���ӳ�
			%Metempsychosis = %Player.GetMetempsychosis();
			%TempExp = %TempExp + (%TempExp * 0.5 * %Metempsychosis);
		}

		//��Ӿ���
		AllAddExp(%Player,%TempExp);
	}

	//����Ǯ
	%MissionData_Money = GetMissionData(%Mid,$Mission_Data_Money);
	if (%MissionData_Money > 0)
		%Player.AddMoney(%MissionData_Money,1,1,%Mid);

	//��Ԫ��
	%MissionData_Yuan = GetMissionData(%Mid,$Mission_Data_Yuan);
	if (%MissionData_Yuan > 0)
		%Player.AddMoney(%MissionData_Yuan,2,1,%Mid);

	//����Ծ����
	%MissionData_JiFen = GetMissionData(%Mid,$Mission_Data_JiFen);
	if (%MissionData_JiFen > 0)
		%Player.AddMoney(%MissionData_JiFen,7,1,%Mid);

	//����ְϵͳ���Ĺٳɾ�ֵ
	//%Player.AddCivilianValue( 5 );  //ÿ���һ��������5��ɾ�ֵ

	//���������������Ѿ���Ϊ������ؽ�����
	%MissionData_ShengWang = GetMissionData(%Mid,$Mission_Data_ShengWang);
	if (%MissionData_ShengWang > 0)
	{
		%leve = %Player.GetLevel();			//��ҵȼ�

		//�����Ծ���ֽ���
		%Player.AddMoney(2,7,1,%Mid);

		//switch ( %Player.GetOrgMemberLevel( 1 ) )
		//{
		//	case 0:%TooC = 1;		//1�����ڣ�����Ϊ1��
		//	case 1:%TooC = 1.5; //2�����ڣ�����Ϊ1.5��
		//	case 2:%TooC = 2;   //3�����ڣ�����Ϊ2��
		//	case 3:%TooC = 2.5; //4�����ڣ�����Ϊ2.5��
		//	case 4:%TooC = 3;   //5�����ڣ�����Ϊ3��
		//	case 5:%TooC = 3;		//������������Ϊ3��
		//	case 6:%TooC = 3;		//����������Ϊ3��
		//}

		////�ж��Ƿ��а��ɣ��ް����򲻸���������
		//if ( %FamilyID > 0 )
		//{
		//	//������ĩ������ʾ
		//	if ( %TooB > 1 )
		//		SendOneChatMessage( $chatMsg_Person, "<t>��ǰΪ��ĩ�����°������е����淭��</t>", %Player );
		//
		//	//������������  ���ɹ��׽���
		//	AddFamily_SW_GX( %Player, %Family_ShengWang * %TooB * %TooC, %Family_OverItem * %TooB * %TooC );
		//
		//	//��¼����������ɴ���
		//	SptOrg_AddMission( %PlayerID );
		//}
		//else
		//	SendOneChatMessage( $chatMsg_Person, "<t>����δ������ɣ���������ذ��ɽ�����ʧ</t>", %Player );

		//���ﾭ�齱��
		AllAddExp(%Player,%EXP * %leve * %TooB * %TooC);	//�������ﾭ��
	}
	else
		%ShengWang = "";

	//����ְҵ���輼��
	%MissionData_Skill = GetMissionData(%Mid,$Mission_Data_Skill);
	%MissionData_Skill_Num = GetWordCount(%MissionData_Skill,";");
	if (%MissionData_Skill !$= "0")
	{
		for (%i = 0; %i < %MissionData_Skill_Num; %i++)
		{
			%Skill = GetWord(%MissionData_Skill,%i,";");

			if (%Skill $= "")
				break;
			else
			{
				%ClassesID = GetItemData(%Skill,113);
				if (HasBit(%ClassesID,%Player.GetClasses(0) - 1) > 0)
				{
					%SkillBookID = GetItemData(%Skill,17);
					if (%Player.GetSkillLevel(%SkillBookID) == 0)
						%Player.AddSkill(%SkillBookID);
				}
			}
		}
	}

	//��״̬
	%MissionData_Buff = GetMissionData(%Mid,$Mission_Data_Buff);
	%MissionData_Buff_Num = GetWordCount(%MissionData_Buff,";");
	if (%MissionData_Buff !$= "0")
		for (%i = 0; %i < %MissionData_Buff_Num; %i++)
		{
			%Buff = GetWord(%MissionData_Buff,%i,";");

			if (%Buff $= "")
				break;
			else
				%Player.AddBuff(%Buff,0);
		}

	//�Ƴ�Buff
	if (%Player.GetMissionFlag(%Mid,6000) > 0)
		%Player.RemoveBuff(%Player.GetMissionFlag(%Mid,6000));

	//�������ʱǰ�ô���
	Mission_Estimate_Confluence(%Player,%Conv,%Mid,3);

	//�����������
	//echo( "GetMissionData( %Mid, $Mission_Data_Type )===" @ GetMissionData( %Mid, $Mission_Data_Type ) );
	switch (GetMissionData(%Mid,$Mission_Data_Type))
	{
		case 3:%Player.SetMission(%Mid,0);//ѭ������
		case 4:%Player.SetMission(%Mid,0);//��������
			//���á�ÿ�ա�������񡻡��������
			AddMissionFlag(%Player,32526,1300,0);
		case 6://ÿ������
			%Player.SetMission(%Mid,0);//����
		case 7://ÿ������
			%Player.SetMission(%Mid,0);//����
			%missiondata_mid=GetMissionData(%Mid,$Mission_Data_Mid);
		case 9://ս������
			%Player.AddMoney(5,8,1,%Mid);
		default://����������
			%Player.SetMission(%Mid,1);//���
	}

	//���û�����Ϣ
	%Player.RecordActivity(%Mid,1,0,0);						//��¼����־��������
	if (%Player.LogicFloorRecord <= 0)
		HelpDirectByIndex(%Player.GetPlayerID(),65);	//�������������Ч

	AddHappyFlyLv(%Player,5);										//���ӻ�Ծ��
	%Player.AddFrienValue_byTeam(2,10,2);				//��Ӻøж�

	return "";
}

//������������������������������Ϣ�жϴ���ӿڡ���������������������������
function Mission_Estimate_Confluence(%Player,%Conv,%Mid,%Type)
{
	//%Mission_EspeciallyTrigger = GetMissionData( %Mid, $Mission_Data_EspeciallyTrigger );
	//if ( HasBit( %Mission_EspeciallyTrigger, %Type ) > 0 )
	//{
	//echo( "%Type=====" @ %Type );
	//�����������
	switch (%Type)
	{
		case 0: %MidName = "Mission_Begin_Front_"@ %Mid;		//��ȡ����ǰ���ж�
		case 1: %MidName = "Mission_End_Front_"@ %Mid;			//�������ǰ���ж�

		case 2: %MidName = "Mission_Begin_Process_"@ %Mid;	//��ȡ������̴���
		case 3: %MidName = "Mission_End_Process_"@ %Mid;		//���������̴���
	}
	//echo( "%MidName=AAAA=" @ %MidName );
	//ִ��ƴд������
	if (isFunction(%MidName))
	{
		//echo("%MidName==" @ %MidName);

		%Txt = eval(%MidName @ "(%Npc, %Player, %Conv, %Param, %Mid);");
	}

	//���ص�ֵ
	if (%Txt !$= "")
	{
		//%Conv.SetText( %Txt );
		%Conv.AddOption(4,0);
		return %Txt;
	}
	//	}
}

//��������������������������ȡ��������������Ի����������������������
function Mission_DialogBox_Unpack(%Npc,%Player,%State,%Conv,%Param,%Mid)
{
	%PlayerID = %Player.GetPlayerID();
	%NpcID = %Npc.GetDataID();

	//��ȡ����������ִ�к����Ի�����
	%ConvText = GetMissionData(%Mid,$Mission_Data_Conv);
	%MidState = GetSubStr(%State,0,3) == 110 ? 6 : 7;

	if (HasBit(%ConvText,%MidState) > 0)
	{
		CloseMissionDuiHuaKuang(%NpcID,%PlayerID,1,43);
		%Conv.SetType(4);
		return 1;
	}

	//�ж��Ƿ�Data�Ƿ�ǿ�ƴ򿪶Ի���
	%ConvText = GetMissionData(%Mid,$Mission_Data_Conv);
	%MidState = GetSubStr(%State,0,3) == 110 ? 0 : 1;
	if (HasBit(%ConvText,%MidState) > 0)
	{
		%Player.PostMid = 0;
		CloseMissionDuiHuaKuang(%NpcID,%PlayerID,%NpcID,42);
		NpcOnTrigger(%Conv,%Npc,%Player,0,%Param);
		return 2;
	}

	//��ȡ������Ϣ
	%NpcA_Mid = GetStartNpcMission(%NpcID);			//������ȡ������
	%NpcX_Mid = GetMidTalkNpcMission(%NpcID);		//���ڽ���������
	%NpcZ_Mid = GetEndNpcMission(%NpcID);				//������ɵ�����

	%NpcA_Mid_MaxNum = GetWordCount(%NpcA_Mid);	//������ȡ����������
	%NpcX_Mid_MaxNum = GetWordCount(%NpcX_Mid);	//���ڽ�������������
	%NpcZ_Mid_MaxNum = GetWordCount(%NpcZ_Mid);	//������ɵ���������

	if (GetSubStr(%State,0,3) == 910)
	{
		//�����������ֱ�ӵ����Ի���
		%PostMid = GetMissionData(%Mid,$Mission_Data_PostMid);
		%PostMid_Num = GetWordCount(%PostMid,";");

		if (%PostMid > 0)
		{
			for (%a = 0; %a < %PostMid_Num; %a++)
			{
				%Post = GetWord(%PostMid,%a,";");
				if (CanDoThisMission(%Player,%Post,1,2,0) $= "")
				{
					%Player.PostMid = %Post;
					CloseMissionDuiHuaKuang(%NpcID,%PlayerID,%NpcID,42);
					NpcOnTrigger(%Conv,%Npc,%Player,0,%Param);
					return 3;
				}
				else
					%Player.PostMid = "";
			}
		}
	}

	//��ȡ�����ǿ�ƹرնԻ���
	//��������ǿ�ƹرնԻ���
	%ConvText = GetMissionData(%Mid,$Mission_Data_Conv);
	%MidState = GetSubStr(%State,0,3) == 110 ? 4 : 5;
	if (HasBit(%ConvText,%MidState) > 0)
	{
		CloseMissionDuiHuaKuang(%NpcID,%PlayerID,1,43);
		%Conv.SetType(4);
		return 4;
	}


	//�ж��Ƿ��пɽ�����
	for (%a = 0; %a < %NpcA_Mid_MaxNum; %a++)
	{
		%MidA = GetWord(%NpcA_Mid,%a);

		if (!Mission_Begin_SeeOption(%Player,%MidA))						//�Ƿ���ʾ(�����ж�)
			if (CanDoThisMission(%Player,%MidA,1,0,0) $= "")
			{
				CloseMissionDuiHuaKuang(%NpcID,%PlayerID,%NpcID,42);
				NpcOnTrigger(%Conv,%Npc,%Player,0,%Param);
				return 5;
			}
	}

	//�ж��Ƿ�����;����
	for (%x = 0; %x < %NpcX_Mid_MaxNum; %x++)
	{
		%MidX = GetWord(%NpcX_Mid,%x);
		if (!Mission_midway_SeeOption(%Player,%MidX))								//�Ƿ���ʾ(�����ж�)
			if (CanDoMidwayMission(%Npc,%Player,%Mid,0,0,0) > 0)
			{
				CloseMissionDuiHuaKuang(%NpcID,%PlayerID,%NpcID,42);
				NpcOnTrigger(%Conv,%Npc,%Player,0,%Param);
				return 6;
			}
	}

	//�ж��Ƿ����������
	for (%z = 0; %z < %NpcZ_Mid_MaxNum; %z++)
	{
		%MidZ = GetWord(%NpcZ_Mid,%z);
		if (!Mission_End_SeeOption(%Player,%MidZ))							//�Ƿ���ʾ(�����ж�)
			if (CanDoThisMission(%Player,%MidZ,2,0,0) $= "")
			{
				CloseMissionDuiHuaKuang(%NpcID,%PlayerID,%NpcID,42);
				NpcOnTrigger(%Conv,%Npc,%Player,0,%Param);
				return 7;
			}
	}

	//��ȡ��������ÿ�������
	if (GetSubStr(%State,0,3) == 110)
	{
		%Player.PostMid = %Mid;
		if (GetMissionData(%Mid,$Mission_Data_NpcZ) == %NpcID)
			if (CanDoThisMission(%Player,%Mid,2,0,0) $= "")
			{
				CloseMissionDuiHuaKuang(%NpcID,%PlayerID,%NpcID,42);
				NpcOnTrigger(%Conv,%Npc,%Player,0,%Param);
				return 8;
			}
	}

	//�رնԻ���
	%Conv.SetType(4);
	CloseMissionDuiHuaKuang(%NpcID,%PlayerID,1,43);

	return -1;
}

//�����������������������������������������������������������������������
//�������������񴥷�������
//������ͨ����������ȡ���񣭣���

//�������������񴥷�������
function Mission_Share(%Player,%Mid,%State)
{

	// ��ס��������ָ�������Ʒ��������ǳ���Ҫ
	%Conv = %Player.GetConversation();

	%Conv.Reset();	//��������ѡ��
	%Conv.SetTriggerType(1);
	%Conv.SetTriggerMission(%Mid);

	if (%State == -1)
	{
		%Conv.SetType(4);
		%Conv.Send(%Player);
		return;
	}

	%Conv.SetType(2);

	if (%State == 0)
		%Conv.SetText(110 @ %Mid,110 @ %Mid);	//���������������ܽ���

	if ((%State > 0)&&(strlen(%State) == 8)&&(GetSubStr(%State,0,3) == 110))
		AddMissionAccepted(%Player,%Conv,%Mid);	//�������������Ϣ

	%Conv.Send(%Player);
}


//������ͨ����������ȡ���񣭣���
function Mission_UI_Accepted(%Player,%Mid,%index)
{
	if (CanDoThisMission(%Player,%Mid,1,0,0) $= "")
		AddMissionAccepted(%Player,%Conv,%Mid);
}

//����������������������������������������������������������������������
function AddMissionFlag(%Player,%Mid,%FlagA,%FlagDDD)
{
	//%FlagA = ���ֵ
	//%FlagDDD = ������ɵ�ֵ��Ĭ�����1

	if (%Player.IsAcceptedMission(%Mid))
	{
		%FlagAAA = %Player.GetMissionFlag(%Mid,%FlagA);				//Ŀ�굱ǰ����
		%FlagBBB = %Player.GetMissionFlag(%Mid,%FlagA - 100);	//Ŀ���������
		%FlagCCC = %Player.GetMissionFlag(%Mid,%FlagA - 200);	//Ŀ����

		if (%FlagAAA < %FlagBBB)
		{
			if (GetSubStr(%FlagCCC,0,1) == 1)%FlagTxt = GetItemData(%FlagCCC,1);						//����
			else if (GetSubStr(%FlagCCC,0,1) == 4)%FlagTxt = GetNpcData(%FlagCCC,1);							//NPC
			else if (GetSubStr(%FlagCCC,0,1) == 5)%FlagTxt = GetCollectionObjectname(%FlagCCC);	//�ɼ�
			else if (GetSubStr(%FlagCCC,0,1) == 8)%FlagTxt = GetTriggerData(%FlagCCC,3);				//����

			if (%FlagDDD > 0)
			{
				%FlagAAA = %FlagDDD + %FlagAAA;
				%FlagAAA = (%FlagAAA > %FlagBBB) ? %FlagBBB : %FlagAAA;
			}
			else
				%FlagAAA++;

			%Player.SetMissionFlag(%Mid,%FlagA,%FlagAAA);

			if (%FlagTxt $= "")
				%FlagTxt = GetMissionData(%Mid,$Mission_Data_Name); //��ȡ��������
			SendOneScreenMessage(1,"��� ��"@%FlagTxt@"�� "@%FlagAAA@"/"@%FlagBBB@"",%Player);

			//���ⴥ��
			AddMissionFlagB(%Player,%Mid,%FlagA,%FlagAAA);

			Cancel($AddMissionFlag[%Player,%Mid]);
			$AddMissionFlag[%Player,%Mid] = Schedule(600,0,"AddMissionFlag_UPCS",%Player,%Mid);

			return 1;
		}
	}

	return 0;
}
function AddMissionFlag_UPCS(%Player,%Mid)
{
	%Player.UpdateMission(%Mid);
}

function AddMissionFlagB(%Player,%Mid,%FlagA,%FlagAAA)
{
	if ((20005 + (GetHomeplace(%Player) - 1) * 200) == %Mid)
	{
		//���輼��ʹ�ö�������ʾ
		if (%FlagAAA == 1)
			ServerOnSptAction(%Player.GetPlayerID(),1003,36);

		//�������������ʾ
		if (%FlagAAA == 6)
			%Player.ShowDialogOk(2000000080,53,0);
	}
}

//�����������������������������������������������������������������������
function AddMissionQuiz(%Npc,%Player,%State,%Conv,%Mid,%FlagA)
{
	%NpcID = %Npc.GetDataID();

	if (!%Player.IsAcceptedMission(%Mid))
		return;

	if (%Player.GetMissionFlag(%Mid,%FlagA - 100) == 0)
		return;

	if (%Player.GetMissionFlag(%Mid,%FlagA) > 0)
		return;

	switch (%State)
	{
		case 0:
			%Player.Ok = %Player.No = 1;
			%Conv.AddOption(500 @ %Mid,500 @ %Mid); //����
	}

	if ((%State >= 500 @ %Mid) && (%State < 600 @ %Mid))
	{
		%Player.MidDaTi = 1;

		%AAA = GetSubStr(%State,1,1);	//��ǰΪ�ڼ���
		%BBB = GetSubStr(%State,2,1);	//��ǰѡ������

		//����׶�
		if (%State == 500 @ %Mid)
		{
			if ($AddMissionQuiz[%Mid,1,%Player.Ok] !$= "")
			{
				%Conv.SetText(51 @ %Player.Ok @ %Mid);
				for (%i=3; %i<10; %i++)
				{
					%option = $AddMissionQuiz[%Mid,%i,%Player.Ok];
					if (%option !$= "")
					{
						if (%Player.No == -1)
						{
							%Player.No = 1;
							%ZZ = 4000000;				//������
						}
						%State = 5 @ %i @ %Player.Ok @ %Mid;		//ƴ��ѡ��
						%Conv.AddOption(%State + %ZZ,%State);	//ѡ��
					}
					else
						break;
				}
			}
			else
			{
				if (%Player.IsAcceptedMission(%Mid))
				{
					%FlagAAA = %Player.GetMissionFlag(%Mid,%FlagA);
					%Player.SetMissionFlag(%Mid,%FlagA,%FlagAAA + 1,true);
				}

				%Player.PostMid = %Mid;
				if (GetMissionData(%Mid,$Mission_Data_NpcZ) == %NpcID)
					Mission_Normal(%Npc,%Player,0,%Conv,%Param);//����ֱ�ӽ�����
				else
					%Conv.SetType(4);

				AddMissionQuizB(%Npc,%Player,%State,%Conv,%Mid,%FlagA);
			}
		}
		else	//���׶�
		{
			%Accurate = $AddMissionQuiz[%Mid,2,%Player.Ok];	//��ȷ��
			%Selective = GetSubStr(%State,1,1) - 2;					//ѡ���
			if (%Accurate == %Selective)
			{
				%Player.Ok++;
				AddMissionQuiz(%Npc,%Player,500 @ %Mid,%Conv,%Mid,%FlagA);
			}
			else
			{
				%Player.No = -1;
				AddMissionQuiz(%Npc,%Player,500 @ %Mid,%Conv,%Mid,%FlagA);
			}
		}
	}
}
function AddMissionQuizB(%Npc,%Player,%State,%Conv,%Mid,%FlagA)
{
	switch (%Mid)
	{
		case 21507:
			//			%Player.PutItem(105099251, 4);
			//			%Player.PutItem(105099252, 1);
			//			if(%Player.AddItem(1, %Mid)) //ֱ�Ӵ򿪰�����ʾ
			//				ServerOnSptAction(%Player.GetPlayerID(), 105099252, 23);
	}
}

//�������� - һ��NCPֻ��һ�����⣬�ж��NPC���磺����10019
function AddMissionQuizOneTopic(%Player,%State,%Conv,%Mid,%Flag)
{
	if (!%Player.IsAcceptedMission(%Mid))
		return;

	if (%Player.GetMissionFlag(%Mid,%Flag - 100) == 0)
		return;

	if (%Player.GetMissionFlag(%Mid,%Flag) == 1)     //�Ի�NPCĿ���Ѿ����ʱ����
		return;

	switch (%State)
	{
		case 0:
			%Conv.SetText((511 + 10*(%Flag - 1300)) @ %Mid);//��Ŀ
			%Conv.AddOption((513 + 10*(%Flag - 1300)) @ %Mid,(513 + 10*(%Flag - 1300)) @ %Mid);     //��һ
			%Conv.AddOption((514 + 10*(%Flag - 1300)) @ %Mid,(514 + 10*(%Flag - 1300)) @ %Mid);     //�𰸶�
			%Conv.AddOption((515 + 10*(%Flag - 1300)) @ %Mid,(515 + 10*(%Flag - 1300)) @ %Mid);     //����
	}
	if ((%State > 500 @ %Mid) && (%State < 600 @ %Mid))
	{
		%QuestionID = GetSubStr(%State,1,1);	    //��ǰΪ�ڼ���
		%ChoseKeyID = GetSubStr(%State,2,1) - 2;	//���ѡ��Ĵ�

		if ($AddMissionQuizOneTopic[%Mid,%QuestionID,2] !$= %ChoseKeyID)
		{
			SendOneScreenMessage(2,"���ϧ����һ��ʹ���ˣ�",%Player);  //���ʹ�����ʾ��Ϣ
			%Conv.SetType(4);
		}
		else
		{
			%Player.SetMissionFlag(%Mid,%Flag,1,true); //��ɶԻ�Ŀ��
			SendOneScreenMessage(1,"�㾹Ȼ��Ĵ���ˣ����ӿɽ�Ҳ��",%Player);  //�ش���ȷ
			%Conv.SetType(4);
		}
	}
}


//��������������������������Ҫ���������Ʒ�Ĳɼ��������������������������
//����ɼ��¼�����
function MissionCollectEventDispose(%Player,%Event,%EventID)
{
	if ($Item_Mission[%EventID] $= "")
		return;
	%MidList = $Item_Mission[%EventID];
	for (%i = 0; %i < GetWordCount(%MidList); %i++)
	{
		%Mid = GetWord(%MidList,%i);
		if (!%Player.IsAcceptedMission(%Mid))//�Ƿ��ѽӴ����񣬲��ж��Ƿ���������
			continue;

		%CollectList = GetMissionData(%Mid,$Mission_Data_Cj);	    //�ɼ����б�
		%CollectNum  = GetWordCount(%CollectList,";");             //�ɼ�������
		%ItemList    = GetMissionData(%Mid,$Mission_Data_ItemGet);	//������Ʒ�б�

		for (%j = 0; %j < %CollectNum/2; %j++)
		{
			%CollectID   = GetWord(%CollectList,%j * 2,";");       //�ɼ���ID
			%CollectFlag = GetWord(%CollectList,%j * 2 + 1,";");   //�����òɼ����Ƿ������Ʒ
			if (%CollectID != %EventID)
				continue;

			if (%CollectFlag >= 2200 && %CollectFlag < 2300)
			{
				%ID     = (%CollectFlag - 2200) *2;
				%ItemID = GetWord(%ItemList,%ID,";");   //��ȡ��ƷID
				if (%ItemID !$= "")
				{
					%Player.PutItem(%ItemID,1);
					%Player.AddItem(3,%EventID);
					return;
				}
			}
		}
	}
}
//��������������������������Ҫ���������Ʒ�Ĳɼ��������������������������

//�������������������������ɼ���Ӧ�������š�����������������������������

$Item_Mission[552000001] = "10017"; //�ɼ�ҩ��
$Item_Mission[552000036] = "20203"; //�ɼ�����
$Item_Mission[553000018] = "29101"; //�ɼ���ľ��֥
$Item_Mission[553000019] = "29105"; //�ɼ����
$Item_Mission[553000023] = "29114"; //�ɼ�Ұ��
$Item_Mission[553000024] = "29115"; //�ɼ���Ҷ
$Item_Mission[553000025] = "29116"; //�ɼ�����
$Item_Mission[553000026] = "29118"; //�ɼ�����
$Item_Mission[553000027] = "29124"; //�ɼ��ɻ�
$Item_Mission[553000028] = "29125"; //�ɼ��Ͼ�ʯ
$Item_Mission[553000031] = "29137"; //�ɼ�������
$Item_Mission[553000032] = "29138"; //�ɼ������
$Item_Mission[553000033] = "29142"; //�ɼ�¯ˮ
$Item_Mission[553000034] = "29146"; //�ɼ���ƥ
$Item_Mission[553000035] = "29148"; //�ɼ���ź
$Item_Mission[552000022] = "29230"; //�ɼ�����
$Item_Mission[552000023] = "29231"; //�ɼ�ѩ��
$Item_Mission[552000024] = "29232"; //�ɼ��龧
$Item_Mission[552000025] = "29233"; //�ɼ�������
$Item_Mission[552000026] = "29234"; //�ɼ�����Һ
$Item_Mission[552000027] = "29235"; //�ɼ����
$Item_Mission[552000030] = "29239"; //�ɼ�ѩ�޲�
$Item_Mission[552000032] = "29241"; //�ɼ�������
$Item_Mission[552000033] = "29242"; //�ɼ���ʧ�Ļ���
$Item_Mission[552000035] = "29244"; //�ɼ�ԭʯ
$Item_Mission[553000040] = "10691"; //�ɼ�������
$Item_Mission[553000037] = "10021"; //�ɼ�����
$Item_Mission[553000038] = "10141"; //�ɼ���Ӽ
$Item_Mission[553000039] = "10091"; //�ɼ����Ӳ�
$Item_Mission[553000045] = "10431"; //�ɼ������
$Item_Mission[553000046] = "10471"; //�ɼ�һ����ˮ
$Item_Mission[553000047] = "10521"; //�ɼ�����Ҷ
$Item_Mission[553000048] = "10521"; //�ɼ��ɲ�
$Item_Mission[553000049] = "10481"; //�ɼ���Ⱥ
$Item_Mission[552000017] = "11061"; //�ɼ���ʧ����
$Item_Mission[552000018] = "11111 29227"; //�ɼ�������
$Item_Mission[552000037] = "11321"; //�����
$Item_Mission[552000038] = "29326 11361"; //����
$Item_Mission[552000039] = "29333 11411"; //Ģ��
$Item_Mission[552000040] = "29332 11451"; //��Ȫ
$Item_Mission[552000041] = "11491"; //��ˮ����
$Item_Mission[552000042] = "11501"; //����
$Item_Mission[552000043] = "29327"; //����
$Item_Mission[552000046] = "29331"; //��Ҷ
$Item_Mission[552000047] = "29334"; //������
$Item_Mission[552000048] = "29335"; //������
$Item_Mission[552000049] = "29336"; //�ݲ�
$Item_Mission[552000052] = "29339"; //Ҭ��
$Item_Mission[552000053] = "29340"; //����ֲ��
$Item_Mission[552000057] = "29344"; //����

//--------------------------������ֻ�����������ߵĲɼ�----------------------------
$TriggerEvent_Mission[552000010] = "20149 2230;";		//�����
$TriggerEvent_Mission[552000011] = "20149 2230;";		//���ľ
$TriggerEvent_Mission[552000012] = "20149 2230;";		//������
$TriggerEvent_Mission[552000013] = "20149 2230;";		//����
$TriggerEvent_Mission[552000014] = "20149 2230;";		//����¶
$TriggerEvent_Mission[552000002] = "20149 2230;10221 2230;";		//��������
$TriggerEvent_Mission[553000020] = "29109 2230;";		 //����
$TriggerEvent_Mission[553000021] = "29111 2230;";		 //���
$TriggerEvent_Mission[553000022] = "29112 2230;";		 //����
$TriggerEvent_Mission[553000029] = "29129 2230;";		 //����
$TriggerEvent_Mission[553000030] = "29131 2230;";		 //����¯
$TriggerEvent_Mission[553000036] = "29113 2230;";		 //��̳
$TriggerEvent_Mission[553000050] = "20149 2230;10221 2230;";		//��������
$TriggerEvent_Mission[553000051] = "10991 2230;";		 //ˮԴ
$TriggerEvent_Mission[553000052] = "11011 2230;";		 //��ħ��ӡ
$TriggerEvent_Mission[552000019] = "11121 2230;29236 2230";		 //������ʿ
$TriggerEvent_Mission[552000020] = "29228 2230;";		 //ľ��
$TriggerEvent_Mission[552000021] = "29229 2230;";		 //����
$TriggerEvent_Mission[552000028] = "29237 2230;";		 //�⽣̨
$TriggerEvent_Mission[552000029] = "29238 2230;";		 //����
$TriggerEvent_Mission[552000031] = "29240 2230;";		 //�⽣ӡ��
$TriggerEvent_Mission[552000034] = "29243 2230;";		 //�׻�̨
$TriggerEvent_Mission[552000044] = "29329 2230;";		 //¶ˮ
$TriggerEvent_Mission[552000045] = "29330 2230;";		 //��ˮ
$TriggerEvent_Mission[552000050] = "29337 2230;";		 //ˮ�ֳ�
$TriggerEvent_Mission[552000051] = "29338 2230;";		 //�ʺ���
$TriggerEvent_Mission[552000054] = "29341 2230;";		 //Ϫˮ
$TriggerEvent_Mission[552000055] = "29342 2230;";		 //��
$TriggerEvent_Mission[552000056] = "29343 2230;";		 //��¯
$TriggerEvent_Mission[552000058] = "29345 2230;";		 //�Ӳ�
$TriggerEvent_Mission[552000059] = "29328 2230;";		 //�ɻ�
//�������������������������ɼ���Ӧ�������š�����������������������������

	
//������������������������������Ի��򡿡������������Ϳͻ��˿��ؽ��桿����
function CloseMissionDuiHuaKuang(%NpcID,%PlayerID,%State,%MMM)
{
	if ($NPC_MissionTS[%NpcID] > 0)
		ServerOnSptAction(%PlayerID,%State,%MMM);
}

//������������������������������Ի��򡿡������������Ϳͻ������Ķ԰ס�����
function OpenDuiHuaKuang_XL(%NpcID,%Player,%State,%MMM)
{
	%PlayerID = %Player.GetPlayerID();
	if ($NPC_MissionTS[%NpcID] > 0)
		ServerOnSptAction(%PlayerID,%State,%MMM);
}