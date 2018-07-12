//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//�ͻ���������ؽ�������ʾ���ı�
//==================================================================================
//ˢ�������Ի����UI����
//������������������������ӡ����¡�ɾ������ɣ����������ˢ�¡���������������������
//|+|�����������������������������ѽӽ��棨������������������������������������������
//|+|����������������������������ɽӽ��棨������������������������������������������
//|+|��������������������������������棨������������������������������������������
//|+|�����������������������������ѽӽ��棨������������������������������������������
//|+|����������������������������ɽӽ��棨������������������������������������������

//|+|��������������������ˢ�������ѽӽ��棨������������������������������������������
//|+|��������������������ˢ������ɽӽ��棨������������������������������������������
//|+|��������������������ˢ����������棨������������������������������������������

//|+|��������������������ˢ�������ѽӽ��棨������������������������������������������
//|+|��������������������ˢ������ɽӽ��棨������������������������������������������

//|+|�������������������������XX�������񴥷�����������������������������������������

//���������������������׷�ٽ����������������������������������������������������
//���������������������������ʱ������²�������������������������������������������
//����������������������������ʱ������²�������������������������������������������
//��������������������ɾ������ʱ������²�������������������������������������������

//����������������������ȡ����ȫ�������ı�������������������������������������������
//����������������������ȡ���������ı�����������������������������������������������
//����������������������ȡ�����Ѷȡ�����������������������������������������������
//����������������������ȡ�����������ơ�������������������������������������������
//����������������������ȡ������ꡢ��ɫ����ʽ������������������������������������

//����������������������ȡ������Ʒ����ͷ˵����������������������������������������
//����������������������ȡ����ʹ�á���ͷ˵����������������������������������������
//����������������������ȡ���񡾲ɼ�����ͷ˵����������������������������������������
//����������������������ȡ�������������á���ͷ˵������������������������������������
//����������������������ȡ������������ʱ����ͷ˵������������������������������������

//����������������������ͨ�á���ȡ���������ͼ������������������������������������
//����������������������ͨ�á��ͻ���Ѱ·������������������������������������������
//����������������������������ȡ��������Ϣ��������������������������������������
//�����������������������������ȫ������ICON��������������������������������������

//���������������������������������񴥷���������������������������������������


//|+|������������������������ӡ����¡�ɾ������ɣ����������ˢ�¡���������������������
// ���ӿɽ��������ڵ�
function AddCanAcceptTreeNode(%node,%text,%missionId,%click)
{
	return MissionTraceWnd_CanSelectMissionTree.init(%node,%text,%missionId,%click);
}

//������ɾ������ڵ㣭����
function RefreshMission(%Player,%op,%Mid)
{
	if (isobject(%Player) == 0)
		%Player = GetPlayer();

	//��������������data�С��ӽ�ʱ��������һ�еġ��ӽ�����ʱ��������UI���桿ֵ����ѡʱ����
	%ConvText = GetMissionData(%Mid,$Mission_Data_Conv);
	if ((HasBit(%ConvText,8) > 0) && (%op != 99))
		RefreshMission(%Player,99,%Mid);

	//�������������¼�����
	RefreshMission_TeShu(%Mid,%op);

	switch (%op)
	{
		case 1: // ���һ������
			UIAddOneMission(%Player,%Mid);
			DeleteNodeForShareMission(%Player,%Mid);

			//���µ�ͼ��Npcͷ�����
			UpdateMissionEffect(%Player,%Mid,1);
			UpdateUITrackMissionEx();

			//�����»ؽ���
			MissionChapter(%Mid);

			//��ȡ�����Զ���ӹ���
			MissionSptAutoBuildTeam(%Mid);

			//�Զ�����ӳ�
			if (%Mid == 24000)
				AgreeTeamFollow();

		case 2:	// ����һ������
			UIUpdateOneMission(%Player,%Mid);
			//���µ�ͼ��Npcͷ�����
			UpdateMissionEffect(%Player,%Mid,1);
			UpdateUITrackMissionEx();

			//ֱ��ˢ���ѽӽ���
			CreateAcceptedMissionNode(%Player,%Mid,isOrderByMap(),true,0);

		case 4: // ɾ��һ������
			UIDelOneMission(%Player,%Mid);
			//���µ�ͼ��Npcͷ�����
			UpdateMissionEffect(%Player,%Mid,1);
			UpdateUITrackMissionEx();

		case 6:	//���һ������
			//ɾ�����񴥷�
			UIDelOneMission(%Player,%Mid);

			//���µ�ͼ��Npcͷ�����
			UpdateMissionEffect(%Player,%Mid,2);
			UpdateUITrackMissionEx();

		case 7: //����������������
			echo( "����������������===" @ %Player @ "=======" @ GetPlayer( ));
			if (isobject(%Player) == 1)
			{
				//���µ�ͼ��Npcͷ�����
				UpdateMissionEffect(%Player,0,0);
				UpdateUITrackMissionEx();

				Schedule(2000,0,"RefreshAcceptedMission",%Player);			//ˢ���ѽӽ��棨����
				RefreshTraceMission(%Player);															//ˢ���ѽӽ��棨����

				Schedule(4000,0,"RefreshCanAcceptMission_L",%Player);	//ˢ�¿ɽӽ��棨����
				Schedule(3000,0,"RefreshCanAcceptMission_K",%Player);	//ˢ�¿ɽӽ��棨����

				Schedule(3000,0,"OpenPlayerOperateCueWnd_7");

				$RefreshMission[7] = 2;
			}

		case 8: //�л���ͼ����
			//���µ�ͼ��Npcͷ�����
			UpdateMissionEffect(%Player,0,0);
			UpdateUITrackMissionEx();
			echo("$RefreshMission[7]  =======" @ $RefreshMission[7] @ "    %Player====" @ %Player);

			if ($RefreshMission[7] == 1 && isobject(%Player))
				RefreshMission(%Player,7,0);

		case 13: //�������й�����������
			RefreshShareMission(%Player);

		case 99: //������������ɽ�����
			//���µ�ͼ��Npcͷ�����
			UpdateMissionEffect(%Player,0,0);
			UpdateUITrackMissionEx();

			Schedule(2000,0,"RefreshAcceptedMission",%Player);//ˢ���ѽӽ��棨����
			RefreshTraceMission(%Player);//ˢ���ѽӽ��棨����

			Schedule(4000,0,"RefreshCanAcceptMission_L",%Player);//ˢ�¿ɽӽ��棨����
			Schedule(3000,0,"RefreshCanAcceptMission_K",%Player);//ˢ�¿ɽӽ��棨����

		default:
	}

	setMissionTraceWnd();
	CloseMisssionHover();//�ر������ȸн���
}

//������ɾ������ڵ㣭����
function DeleteNodeForShareMission(%Player,%Mid)
{
	%node = SingleWnd1_Tree3.findMissionTreeNode(%Mid);
	if (%node != 0)
		SingleWnd1_Tree3.clearChildItem(%node);
}


//|+|�����������������������������ѽӽ��棨������������������������������������������
function CreateAcceptedMissionNode(%Player,%Mid,%Mission_Map,%updateUI,%LeiXin)
{
	%node = SingleWnd1_Tree1.findMissionTreeNode(%Mid);
	if (%LeiXin == 0)
		SingleWnd1_Tree1.clearChildItem(%node);

	if (%Player.IsAcceptedMission(%Mid))
	{
		%kind       = GetMissionKind(%Mid);
		%Mid_LeiXin = $MissionKind[%kind,1];
		%MapName    = GetMissionMap(%Player,%Mid,1);
		%Mid_Kind   = GetMissionMap(%Player,%Mid,2);

		//����������棨���������Ƿ���������
		%Icon[1] = "<t>   </t>";
		if ((GetWord($DendriformMid[%Mid],2) == 1) || (%LeiXin == 0))
			%Icon[1] = $Icon[41] @ "<t> </t>";

		//�����������ͼƬ
		if (CanDoThisMission(%Player,%Mid,2,0,0) $= "")
		{
			%Mid_Over = $Icon[91];

			%Mission_Name = GetMission_Name(%Player,%Mid,1);
			//echo( "strlen( %Mission_Name )==" @ strlen( %Mission_Name ) );
			%Blank = 18 - strlen(%Mission_Name);
			for (%i=0; %i< %Blank; %i++)
				%PaiXu = %PaiXu @ " ";
		}

		%Gesi[1] = "<t f='����' b='1' m='0' n='16' c='0xffffffff' o='0x010101ff'>";	//������⣨��ɫ��
		%Gesi[2] = "<t f='����' b='0' m='1' n='14' c='0xf3db69ff' o='0x010101ff'>";	//�������ƣ���ɫ��
		%Gesi[3] = "<t f='����' b='0' m='1' n='14' c='0x00ff96ff' o='0x010101ff'>";	//�������ƣ���ɫ��
		%Gesi[4] = "<t f='����' b='0' m='1' n='14' c='0x696668ff' o='0x010101ff'>";	//�������ƣ���ɫ��


		%LvJ = GetMissionData(%Mid,$Mission_Data_LvJ);
		%LeveCa = %Player.GetLevel() - %LvJ;
		//��������ȼ�С������20�����ɫ
		//echo( "%LvJ====" @ %LvJ @ "   %LeveCa===" @ %LeveCa );
		if ((%LeveCa > 20) && (%LvJ != 0))
			%Mid_Name = %Gesi[4] @ GetMission_Name(%Player,%Mid,1);
		else if ((%LeveCa > 10) && (%LvJ != 0))
			%Mid_Name = %Gesi[3] @ GetMission_Name(%Player,%Mid,1);
		else
			%Mid_Name = %Gesi[2] @ GetMission_Name(%Player,%Mid,1);
		//echo( "%Mid_Name===" @ %Mid_Name );
		if (%LeiXin == 1)	//����������棨������������
			SingleWnd1_Tree1.setItemText(%node,%Icon[1] @ %Mid_Name @ %PaiXu @ "</t>" @ %Mid_Over);
		else
		{
			//Ĭ��ֵ�������������������ʹ�����
			if (%Mission_Map == 0)
			{
				//����������״1
				%Node[1] = AddTreeNode1(0," " @ %Gesi[1] @ %Mid_LeiXin @ "</t>",%kind,0,1);
				//ֻ�ڴ���ʱ��״1��¼
				if (%LeiXin == 0)$DendriformDefining[%Node[1]] = "1 " @ %kind @ " " @ 1;

				if (%Node[1] != 0)
				{
					//����������״2
					%Node[2] = AddTreeNode1(%Node[1],%Icon[1] @ %Mid_Name @ %PaiXu @ "</t>" @ %Mid_Over,%Mid,1,0);
					if (%LeiXin == 0)
					{
						$DendriformDefining[%Node[2]] = 2 @ " " @ %Mid @ " " @ 1;
						$DendriformMid[%Mid] = "2 " @ %kind @ " " @ 1 @ " " @ %Node[2];
					}
				}
			}

			//�޸�ֵ�����������Ե�ͼ���ִ�����
			if (%Mission_Map == 1)
			{
				//����������״1
				%Node[1] = AddTreeNode1(0," " @ %Gesi[1] @ "��" @ %MapName @ "��</t>",%Mid_Kind,0,1);
				//ֻ�ڴ���ʱ��״1��¼
				if (%LeiXin == 0)$DendriformDefining[%Node[1]] = "1 " @ %Mid_Kind @ " " @ 1;

				if (%Node[1] != 0)
				{
					//����������״2
					%Node[2] = AddTreeNode1(%Node[1],%Icon[1] @ %Mid_Name @ %PaiXu @ "</t>" @ %Mid_Over,%Mid,1,0);
					if (%LeiXin == 0)
					{
						$DendriformDefining[%Node[2]] = 2 @ " " @ %Mid @ " " @ 1;
						$DendriformMid[%Mid] = "2 " @ %Mid_Kind @ " " @ 1 @ " " @ %Node[2];
					}
				}
			}

			SingleWnd1_Tree1.expandToItem(0,1);

			if (%updateUI)
				SingleWnd1_Tree1.buildVisibleTree(true);
			setMissionTraceWnd();
		}
	}
}

//|+|����������������������������ɽӽ��棨������������������������������������������
function CreateCanAcceptMissionNode_L(%Player,%Mid,%Mission_Map,%updateUI)
{
	//�Ƴ���ʱ������
	deleteVariables("$MissionKeJie_Zhu_Schedule" @ %Mid);

	%Lv = %Player.GetLevel();
	%node = Singlewnd1_Tree2.findMissionTreeNode(%Mid);
	Singlewnd1_Tree2.clearChildItem(%node);

	%kind       	= GetMissionKind(%Mid);
	%Mid_LeiXin 	= $MissionKind[%kind,1];
	%MapName      = GetMissionMap(%Player,%Mid,1);
	%Mid_Kind     = GetMissionMap(%Player,%Mid,2);

	//������ɫ��ʽ
	%Gesi[1] = "<t f='����' b='1' m='0' n='14' c='0xffffffff' o='0x010101ff'>";	//������⣨��ɫ��
	%Gesi[2] = "<t f='����' b='0' m='1' n='14' c='0xf3db69ff' o='0x010101ff'>";	//�������ƣ���ɫ��

	//��������
	if (%Lv < GetMissionData(%Mid,$Mission_Data_LvA))
		%Mid_Name = $Get_Dialog_GeShi[31297] @ GetMission_Name(%Player,%Mid,1) @ "</t>";
	else
		%Mid_Name = %Gesi[2] @ GetMission_Name(%Player,%Mid,1) @ "</t>";

	//Ĭ��ֵ�������������������ʹ�����
	if (%Mission_Map == 0)
	{
		//echo( "%Mid_LeiXin===" @ %Mid_LeiXin );
		//��������ĵ�ͼ����
		%Map = AddTreeNode2(0,%Gesi[1] @ %Mid_LeiXin @ "</t>",%kind,0,1);
		//��������
		AddTreeNode2(%Map,%Gesi[2] @ %Mid_Name @ "</t>" @ %Mid_Over,%Mid,1,0);
	}
	else
	{
		//������������
		%LeiXin = AddTreeNode2(0,%Gesi[1] @ "��" @ %MapName @ "��</t>",%Mid_Kind,0,1);
		//��������
		%LeiXin1 = AddTreeNode2(%LeiXin,%Gesi[2] @ %Mid_Name @ "</t>" @ %Mid_Over,%Mid,1,0);
	}

	Singlewnd1_Tree2.expandToItem(0,1);

	if (%updateUI)
		Singlewnd1_Tree2.buildVisibleTree(true);
}


//|+|��������������������������������棨������������������������������������������
function CreateShareMissionNode(%Player,%Mid,%Mission_Map)
{
	%node = SingleWnd1_Tree3.findMissionTreeNode(%Mid);
	if (%node == 0)
	{
		%kind       = GetMissionKind(%Mid);
		%Mid_LeiXin = $MissionKind[%kind,1];
		%MapName    = GetMissionMap(%Player,%Mid,1);
		%Mid_Kind   = GetMissionMap(%Player,%Mid,2);

		//������ɫ��ʽ
		%Gesi = $Get_Dialog_GeShi[31292];

		//Ĭ��ֵ�������������������ʹ�����
		if (%Mission_Map == 0)
		{
			%rootnode = AddTreeNode3(0,$Get_Dialog_GeShi[31201] @ %Mid_LeiXin @ "</t>",%kind,0,1);
			if (%rootnode != 0)
			{
				if (%kind == 3)
					AddTreeNode3(%rootnode,%Gesi @ GetMission_Name(%Player,%Mid,1) @ "</t>",%Mid,1,0);
				else
				{
					//��������ĵ�ͼ����
					%Map = AddTreeNode3(%rootnode,$Get_Dialog_GeShi[31298] @ "��" @ %MapName @ "��</t>",%kind @ GetMissionData(%Mid,$Mission_Data_Map_Area),0,1);
					//��������
					AddTreeNode3(%Map,%Gesi @ GetMission_Name(%Player,%Mid,1) @ "</t>",%Mid,1,0);
				}
			}
		}

		//�޸�ֵ�����������Ե�ͼ���ִ�����
		if (%Mission_Map == 1)
		{
			if (%kind == 3)
			{
				%rootnode = AddTreeNode3(0,$Get_Dialog_GeShi[31201] @ %Mid_LeiXin @ "</t>",%kind,0,1);
				if (%rootnode != 0)
					AddTreeNode3(%rootnode,%Gesi @ GetMission_Name(%Player,%Mid,1) @ "</t>",%Mid,1,0);
			}
			else
			{
				%rootnode = AddTreeNode3(0,$Get_Dialog_GeShi[31298] @ "��" @ %MapName @ "��</t>",GetMissionData(%Mid,$Mission_Data_Map_Area),0,1);
				if (%rootnode != 0)
				{
					//������������
					%LeiXin = AddTreeNode3(%rootnode,$Get_Dialog_GeShi[31201] @ %Mid_LeiXin @ "</t>",GetMissionData(%Mid,$Mission_Data_Map_Area) @ %kind,0,1);
					//��������
					AddTreeNode3(%LeiXin,%Gesi @ GetMission_Name(%Player,%Mid,1) @ "</t>",%Mid,1,0);
				}
			}
		}
	}
}

//|+|�����������������������������ѽӽ��棨������������������������������������������

function CreateTraceMissionNode(%Player,%Mid,%updateUI)
{
	if (GetWord($DendriformMid[%Mid],2) == 0)
		return;

	%Mission_ZT = CanDoThisMission(%Player,%Mid,2,0,0);
	%kind       = GetMissionKind(%Mid);
	%Mid_LeiXin = $MissionKind[%kind,1];

	%Gesi[1] = "<t f='����' b='0' m='1' n='14' c='0xf3db69ff' o='0x010101ff'>";	//�������ƣ���ɫ��
	%Gesi[2] = "<t f='����' b='0' m='1' n='14' c='0x00ff64ff' o='0x010101ff'>";	//�������ƣ���ɫ��
	%Gesi[3] = "<t f='����' b='0' m='1' n='14' c='0xff6e00ff' o='0x010101ff'>";	//�������ƣ���ɫ��

	//��ʾ����׷�ٵ������Լ�״̬
	if (%Mission_ZT $= "")
	{
		%Blank[1] = "  ";
		%Mid_Name = %Gesi[2] @ GetMission_Name(%Player,%Mid,2) @ "</t>";
		%JMission_Npc = GetMission_Flag(%Player,%Mid,"Npc",99,6);
	}
	else
	{
		if (%kind == 10)%Mid_Name = %Gesi[3] @ GetMission_Name(%Player,%Mid,2);
		else %Mid_Name = %Gesi[1] @ GetMission_Name(%Player,%Mid,2);
	}
	//��������
	%Txt = "<c cid='ShowMissionInfoButton' cmd='\"MissionTraceHover(" @ %Mid @ ");\",\"" @ %Mid_Name @ "</t>\",\"GuiMissionTraceButtonProfile4\"' cf='createButton' />";

	if (%Mission_ZT $= "")
	{
		%Blank[2] = 85 - strlen(%blank[1] @ %Mid_Name @ GetNpcData(GetMissionData(%Mid,$Mission_Data_NpcZ),1));
		for (%i=0; %i< %Blank[2]; %i++)
			%PaiXu = %PaiXu @ " ";

		%Symbol = "<t>" @ %PaiXu @ "</t>" @ $Icon[91];
	}

	//��������
	%node = AddTraceTreeNode(0,%Blank[1] @ %Txt @ %JMission_Npc @ %Symbol,%Mid,0);

	//��ʾ����׷�ٵ�Ŀ��
	if (%node != 0)
	{
		//������н��
		MissionTraceWnd_Tree.removeAllChildren(%node);
		%Num = 0;

		//����9100����궼��ʾ��ȥ
		for (%x = 0; %x < 50; %x++)
		{
			%ii = 9100;
			if (%Player.GetMissionFlag(%Mid,%ii + %x) > 0)
			{
				%Num = %Num + 1;
				%NodeId = %Num * 100;
				%GetMissionNeedText = GetMissionNeedText(%Player,%Mid,%ii + %x);
				if (%GetMissionNeedText !$= "")
					AddTraceTreeNode(%node,%GetMissionNeedText,%Mid @ %NodeId,0);
			}
			else
				break;
		}

		//�����������꣬����������������ƶ��봦��
		if ((%Num > 0) && (%Mission_ZT $= ""))
			MissionTraceWnd_Tree.setItemText(%node,%Txt @ %JMission_Npc @ %Symbol);

		if (%Mission_ZT !$= "")
		{
			for (%i = 0; %i < 8; %i++)
			{
				switch (%i)
				{
					case 0:%ii = 9000;//����˵��
					case 1:%ii = 2250;//�������
					case 2:%ii = 2200;//�Ѽ�����
					case 3:%ii = 1200;//Ѱ��Ŀ��
					case 4:%ii = 3200;//ɱ�ּ���
					case 5:%ii = 1250;//Ѱ������Ŀ��
					case 6:%ii = 8000;//������ֵ
					case 7:%ii = 2230;//�ɼ����
				}

				for (%x = 0; %x < 50; %x++)
				{
					if (%Player.GetMissionFlag(%Mid,%ii + %x) > 0)
					{
						%Num = %Num + 1;
						%NodeId = %Num * 100;

						%GetMissionNeedText = GetMissionNeedText(%Player,%Mid,%ii + %x);
						if (%GetMissionNeedText !$= "")
							AddTraceTreeNode(%node,%GetMissionNeedText,%Mid @ %NodeId,0);
					}
					else
						break;
				}
			}
		}

		if (%updateUI)
			MissionTraceWnd_Tree.buildVisibleTree(0);
	}
}

CreateTraceMissionNode(getplayer(),20148,true);

//|+|����������������������������ɽӽ��棨������������������������������������������
//�������ڵ㴴��������
function CreateCanAcceptMissionNode_K(%Player,%NoUse)
{
	%Lv = %Player.GetLevel();
	%MapID = GetMapId();

	%MissionID[1] = GetCanSeeMission(%Lv);
	%AcceptCountNum = GetWordCount(%MissionID[1]);

	if (%NoUse == 0)
	{
		//������������ѽ����񣬽����������ӵ����б�
		for (%i = 0; %i < %AcceptCountNum; %i++)
		{
			%Mid = GetWord(%MissionID[1],%i);
			if (GetMissionData(%Mid,$Mission_Data_Map_Area) == %MapID)
			{
				if (CanDoThisMission(%Player,%Mid,1,2,0) $= "")
				{
					//ɾ������ʱ
					if ($MissionKeJie_Fu_Schedule[%Mid] > 0)
						Cancel($MissionKeJie_Fu_Schedule[%Mid]);

					//��������
					$MissionKeJie_Fu_Schedule[%Mid] = Schedule(%S++ * 500,0,"AddOneCanAcceptMissionNode",%Player,%Mid,true);
				}
			}
			else
				%MissionID[2] = (%MissionID[2] $= "") ? %Mid : %MissionID[2] @ " " @ %Mid;
		}

		//��ʾ���ʣ�������ѽ�������ӵ����б�
		%AcceptCountNum = GetWordCount(%MissionID[2]);
		for (%i = 0; %i < %AcceptCountNum; %i++)
		{
			%Mid = GetWord(%MissionID[2],%i);

			//������׷�����ϴ���һ��������
			if (CanDoThisMission(%Player,%Mid,1,2,0) $= "")
			{
				//ɾ������ʱ
				if ($MissionKeJie_Fu_Schedule[%Mid] > 0)
					Cancel($MissionKeJie_Fu_Schedule[%Mid]);

				$MissionKeJie_Fu_Schedule[%Mid] = $MissionKeJie_Fu_Schedule[%Mid] = Schedule(%S++ * 500,0,"AddOneCanAcceptMissionNode",%Player,%Mid,true);
			}
		}

		MissionTraceWnd_CanSelectMissionTree.buildVisibleTree(0);
	}
	else
	{
		%Mid = %NoUse;
		if (CanDoThisMission(%Player,%Mid,1,2,0) $= "")
			AddOneCanAcceptMissionNode(%Player,%Mid,true);
	}
}
// �ж��Ƿ񰴵�ͼ��������
function isOrderByMap()
{
	return (MissionWndGui_ArrayMissionButton.getText() !$= "����ͼ��������");
}

function setMissionTraceWnd()
{
	//MissionTraceWnd.setWidth( $missionTraceWidth );
	//TraceTreeBackWnd.setWidth( $missionTraceWidth-3 );
	//TraceTreeBackWndExt.setWidth( $missionTraceWidth-3 );
	//SingleWnd2_ScrollCtrl.setWidth( $missionTraceWidth-13 );
	//SingleWnd2_ScrollCtrl_CanSelectMission.setWidth( $missionTraceWidth-13 );

	//MissionTraceWnd.setHeight( $missionTraceHeight+25 );
	//TraceTreeBackWnd.setHeight( $missionTraceHeight );
	//TraceTreeBackWndExt.setHeight( $missionTraceHeight );
	//SingleWnd2_ScrollCtrl.setHeight( $missionTraceHeight );
	//SingleWnd2_ScrollCtrl_CanSelectMission.setHeight( $missionTraceHeight );

	TraceTreeBackWnd.setAlpha(255-$missionTraceAlpha);
}
//�������ڵ㴴��������
function AddOneCanAcceptMissionNode(%Player,%Mid,%updateUI)
{
	//�Ƴ���ʱ������
	deleteVariables("$MissionKeJie_Fu_Schedule" @ %Mid);

	%Lv = %Player.GetLevel();
	%Mission_Map = isOrderByMap();

	%kind       = GetMissionKind(%Mid);
	%Mid_Kind     = GetMissionMap(%Player,%Mid,2);

	if (%Mission_Map == 0)
	{
		%MapName = $MissionKind[%kind,1];
		%rootnode = MissionTraceWnd_CanSelectMissionTree.findMissionTreeNode(%kind);
		if (%rootnode == 0)
			%rootnode = AddCanAcceptTreeNode(0,$Get_Dialog_GeShi[31298] @  %MapName @ "</t>",%kind,0);
	}
	else
	{
		%MapName      = GetMissionMap(%Player,%Mid,1);
		%rootnode = MissionTraceWnd_CanSelectMissionTree.findMissionTreeNode(%Mid_Kind);
		if (%rootnode == 0)
			%rootnode = AddCanAcceptTreeNode(0,$Get_Dialog_GeShi[31298] @ "��" @ %MapName @ "��</t>",%Mid_Kind,0);
	}

	if (%rootnode != 0)
	{
		switch (%Mid)
		{
			case 0:%Map = 0; %NpcA = 0;
			default:
				%NpcA = GetMissionData(%Mid,$Mission_Data_NpcA);
				%Map  = %Mid_Kind;
		}

		%MissionNode = MissionTraceWnd_CanSelectMissionTree.findMissionTreeNode(%Mid);
		if (%MissionNode == 0)
		{
			//��������
			if (%Lv < GetMissionData(%Mid,$Mission_Data_LvA))
				%Mid_Name = $Get_Dialog_GeShi[31297] @ GetMission_Name(%Player,%Mid,1) @ "</t>";
			else
			{
				if (GetMissionData(%Mid,$Mission_Data_Type) == 1)
					%Mid_Name = $Get_Dialog_GeShi[31292] @ GetMission_Name(%Player,%Mid,1) @ "</t>";
				else
					%Mid_Name = $Get_Dialog_GeShi[31296] @ GetMission_Name(%Player,%Mid,1) @ "</t>";
			}

			%TxtA = "<c cid='ShowMissionInfoButton' cmd='\"MissionTraceHover("@%Mid@");\",\"" @ %Mid_Name @ "\",\"GuiMissionTraceButtonProfile4\"' cf='createButton' />";
			%TxtB = "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(" @ %NpcA @ ");\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(%NpcA,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />";

			%Mission_Name = AddCanAcceptTreeNode(%rootnode,%TxtA @ %TxtB,%Mid,0);
		}
	}

	if (%updateUI)
		MissionTraceWnd_CanSelectMissionTree.buildVisibleTree(0);
}



//|+|��������������������ˢ�������ѽӽ��棨������������������������������������������
function RefreshAcceptedMission(%Player)
{
	// ������������������б�
	Singlewnd1_Tree1.clearitem();

	// �����ѽ�����
	%AcceptCount = %Player.GetAcceptedMission();

	// ˢ��UI���ѽ���������
	RefreshMissionNum(%AcceptCount);

	// ˢ��UI����������,��ȡ������Ϣ��ִ��GetMissionText����
	RefreshMissionDesc(-1);

	// ����������Ե�ͼ���ఴť��
	%Mission_Map = (isOrderByMap()) ? 1 : 0;

	//������������ѽ����񣬽���ӵ����б�
	%AcceptCountNum = %Player.GetAcceptedMission();

	%MapID = GetSubStr(GetZoneID(),0,4);
	%ListA = "";
	%ListB = "";
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = %Player.GetMission(%i);
		%MissionMap = GetSubStr(GetMissionData(%Mid,$Mission_Data_Map_Area),1,4);
		if (%MissionMap == %MapID)
			%ListA = %Mid @ " " @ %ListA;
		else
			%ListB = %Mid @ " " @ %ListB;
	}
	%List = %ListA @ %ListB;
	//echo( "%List===" @ %List );
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = GetWord(%List,%i);

		//���ѽ��������ϴ���һ������������
		CreateAcceptedMissionNode(%Player,%Mid,%Mission_Map,true,%LeiXin);
		//echo( "%Player=== " @ %Player @ "  %Mid ===" @ %Mid @ "%Mission_Map====" @ %Mission_Map @ "     %LeiXin ===" @ %LeiXin );
	}

	// ȱʡչ���ѽ�������
	SingleWnd1_Tree1.expandToItem(0,1);
	SingleWnd1_Tree1.buildVisibleTree(false);
	setMissionTraceWnd();

	//ˢ������׷�ٽ���
	RefreshTraceMission(%Player);
}

//|+|��������������������ˢ������ɽӽ��棨������������������������������������������
function RefreshCanAcceptMission_L(%Player)
{
	//��ȡ��ҵȼ�
	%Leve = %Player.GetLevel();

	//������нڵ�
	Singlewnd1_Tree2.clearitem();

	//��Ӧ��Ӧ��ͼ����
	%Mission_Map = (isOrderByMap()) ? 1 : 0;

	%Lv_Mission = GetCanSeeMission(%Leve);
	%AcceptCountNum = GetWordCount(%Lv_Mission);

	//echo( "%List===" @ %List );
	//������������ѽ�������ӵ����б�
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = GetWord(%Lv_Mission,%i);

		//ɾ������ʱ
		if ($MissionKeJie_Zhu_Schedule[%Mid] > 0)
			Cancel($MissionKeJie_Zhu_Schedule[%Mid]);

		//�ڿɽ��������ϴ���һ������������
		if (CanDoThisMission(%Player,%Mid,1,2,0) $= "")
			$MissionKeJie_Zhu_Schedule[%Mid] = Schedule(%S++ * 500,0,"CreateCanAcceptMissionNode_L",%Player,%Mid,%Mission_Map,true);
	}

	// ȱʡչ���ɽ�������
	Singlewnd1_Tree2.expandToItem(0,1);
	Singlewnd1_Tree2.buildVisibleTree(false);
}

//|+|��������������������ˢ����������棨������������������������������������������
function RefreshShareMission(%Player)
{

}

//|+|��������������������ˢ�������ѽӽ��棨������������������������������������������
function RefreshTraceMission(%Player)
{
	MissionTraceWnd_Tree.clearitem();
	//echo("========ˢ�������ѽӽ���====");
	//������������ѽ����񣬽�����ɵ�����������ӵ����б�
	%AcceptCountNum = %Player.GetAcceptedMission();

	%MapID = GetSubStr(GetZoneID(),0,4);
	%ListA = "";
	%ListB = "";
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = %Player.GetMission(%i);
		%MissionMap = GetSubStr(GetMissionData(%Mid,$Mission_Data_Map_Area),1,4);
		if (%MissionMap == %MapID)
			%ListA = %Mid @ " " @ %ListA;
		else
			%ListB = %Mid @ " " @ %ListB;
	}
	%List = %ListA @ %ListB;
	//echo( "%List===" @ %List );

	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = GetWord(%List,%i);
		if ((GetMissionData(%Mid,$Mission_Data_Type) == 1) && (CanDoThisMission(%Player,%Mid,2,0,0) $= ""))
		{
			if ( GetMissionData( %Mid, $Mission_Data_Map_Area ) $= "810100100"|| GetMissionData( %Mid, $Mission_Data_Map_Area ) $= "810010100" )
				GotoFinishMissIonpath(%Mid);
			CreateTraceMissionNode(%Player,%Mid,true);
		}
		else
			%MissionID[1] = (%MissionID[1] $= "") ? %Mid : %MissionID[1] @ " " @ %Mid;
	}
	//������������ѽ����񣬽�������������ӵ����б�
	%AcceptCountNum = GetWordCount(%MissionID[1]);
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = GetWord(%MissionID[1],%i);
		if (GetMissionData(%Mid,$Mission_Data_Type) == 1)
			CreateTraceMissionNode(%Player,%Mid,true);
		else
			%MissionID[2] = (%MissionID[2] $= "") ? %Mid : %MissionID[2] @ " " @ %Mid;
	}

	//������������ѽ����񣬽���ɵ���������ʾ
	%AcceptCountNum = GetWordCount(%MissionID[2]);
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = GetWord(%MissionID[2],%i);
		if (CanDoThisMission(%Player,%Mid,2,0,0) $= "")
			CreateTraceMissionNode(%Player,%Mid,true);
		else
			%MissionID[3] = (%MissionID[3] $= "") ? %Mid : %MissionID[3] @ " " @ %Mid;
	}

	//������������ѽ����񣬽����������ӵ����б�
	%AcceptCountNum = GetWordCount(%MissionID[3]);
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = GetWord(%MissionID[3],%i);
		if (GetMissionData(%Mid,$Mission_Data_Type) == 6)
			CreateTraceMissionNode(%Player,%Mid,true);
		else
			%MissionID[4] = (%MissionID[4] $= "") ? %Mid : %MissionID[4] @ " " @ %Mid;
	}

	//��ʾ���ʣ�������ѽ�������ӵ����б�
	%AcceptCountNum = GetWordCount(%MissionID[4]);
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = GetWord(%MissionID[4],%i);
		//������׷�����ϴ���һ��������
		CreateTraceMissionNode(%Player,%Mid,true);
	}

	if (%AcceptCount != 0)
	{
		MissionTraceWnd_Tree.expandToItem(0,1);
		MissionTraceWnd_Tree.buildVisibleTree(false);
	}


}

//|+|��������������������ˢ������ɽӽ��棨������������������������������������������
function RefreshCanAcceptMission_K(%Player)
{
	// ������нڵ�
	MissionTraceWnd_CanSelectMissionTree.clearitem();
	// ������׷�����ϴ���һ��������
	CreateCanAcceptMissionNode_K(%Player,0);
	// չ���ڵ�
	MissionTraceWnd_CanSelectMissionTree.expandToItem(0,1);
	MissionTraceWnd_CanSelectMissionTree.buildVisibleTree(false);
}

//|+|�������������������������XX�������񴥷�����������������������������������������
function CheckFilterMission()
{
	%Player = GetPlayer();
	if (isOrderByMap())
		MissionWndGui_ArrayMissionButton.setText("����ͼ��������");
	else
		MissionWndGui_ArrayMissionButton.setText("��������������");

	RefreshAcceptedMission(%Player);	//ˢ���ѽӽ��棨����
	RefreshTraceMission(%Player);			//ˢ���ѽӽ��棨����

	Schedule(1000,0,"RefreshCanAcceptMission_L",%Player);	//ˢ�¿ɽӽ��棨����
	Schedule(1000,0,"RefreshCanAcceptMission_K",%Player);	//ˢ�¿ɽӽ��棨����
}

//���������������������׷�ٽ����������������������������������������������������
function uiUpdatePartyTraceWndTree(%par,%par1,%par2,%par3,%par4,%par5)
{
}

//���������������������������ʱ������²�������������������������������������������
function UIAddOneMission(%Player,%Mid)
{

	//putout("�������ʱ������²���====");
	// ����������Ч
	PlayOnceSound(U_021);

	// ˢ��UI���ѽ���������
	RefreshMissionNum(%Player.GetAcceptedMission());

	//----------------------------------------------------------------------------//
	//-------------------------�������-------------------------------------------//
	//----------------------------------------------------------------------------//

	// ����������Ե�ͼ���ఴť��
	if (isOrderByMap())
		%Mission_Map = 1;
	else
		%Mission_Map = 0;

	// ���ѽ��������ϴ���һ������������
	CreateAcceptedMissionNode(%Player,%Mid,%Mission_Map,true,0);

	// ɾ��������桾�ɽ��������ϵĽڵ�
	%node1 = Singlewnd1_Tree2.findMissionTreeNode(%Mid);
	if (%node1 != 0)
		Singlewnd1_Tree2.clearChildItem(%node1);

	// ɾ��ǰ�ö���������桾�ɽ��������ϵĽڵ�
	%Back_A = GetMissionData(%Mid,$Mission_Data_Back_A);
	%Back_A_Num = GetWordCount(%Back_A,";");
	if (%Back_A !$= "0")
		for (%i = 0; %i < %Back_A_Num; %i++)
		{
			%mission = GetWord(%Back_A,%i,";");

			%node2_1 = Singlewnd1_Tree2.findMissionTreeNode(%mission);
			if (%node2_1 != 0)
				Singlewnd1_Tree2.clearChildItem(%node2_1);
		}

	// ȱʡչ������������
	SingleWnd1_Tree1.expandToItem(0,1);
	SingleWnd1_Tree2.expandToItem(0,1);

	SingleWnd1_Tree1.buildVisibleTree(false);
	SingleWnd1_Tree2.buildVisibleTree(false);
	// ����������Ϣ�������ǿɼ��ģ�ˢ����������
	RefreshMissionDesc(%Mid);

	//----------------------------------------------------------------------------//
	//-------------------------����׷�ٽ���-------------------------------------------//
	//----------------------------------------------------------------------------//
	// ������׷�����ϴ���һ��������
	RefreshTraceMission(%Player);

	// ��׷�ٽ���ġ��ɽӡ������Ƴ�һ��������
	%node2 = MissionTraceWnd_CanSelectMissionTree.findMissionTreeNode(%Mid);
	if (%node2 != 0)
		MissionTraceWnd_CanSelectMissionTree.clearChildItem(%node2);

	// ��׷�ٽ���ġ��ɽӡ������Ƴ�һ��ǰ�ö���������
	%Back_A = GetMissionData(%Mid,$Mission_Data_Back_A);//Mission_Data_Back_A
	%Back_A_Num = GetWordCount(%Back_A,";");
	if (%Back_A !$= "0")
		for (%i = 0; %i < %Back_A_Num; %i++)
		{
			%mission = GetWord(%Back_A,%i,";");

			%node2_1 = MissionTraceWnd_CanSelectMissionTree.findMissionTreeNode(%mission);
			if (%node2_1 != 0)
				MissionTraceWnd_CanSelectMissionTree.clearChildItem(%node2_1);
		}

	MissionTraceWnd_Tree.buildVisibleTree(false);
	MissionTraceWnd_CanSelectMissionTree.buildVisibleTree(false);
}

//����������������������������ʱ������²�������������������������������������������
function UIUpdateOneMission(%Player,%Mid)
{
	RefreshMissionDesc(%Mid);

	// ɾ��������桾�ɽ��������ϵĽڵ�
	%node1 = Singlewnd1_Tree2.findMissionTreeNode(%Mid);
	if (%node1 != 0)
	{
		Singlewnd1_Tree2.clearChildItem(%node1);
		Singlewnd1_Tree2.buildVisibleTree(false);
	}

	//������׷�����ϴ���һ��������
	RefreshTraceMission(%Player);

	// ��׷�ٽ���ġ��ɽӡ������Ƴ�һ��������
	%node2 = MissionTraceWnd_CanSelectMissionTree.findMissionTreeNode(%Mid);
	if (%node2 != 0)
	{
		MissionTraceWnd_CanSelectMissionTree.clearChildItem(%node2);
		MissionTraceWnd_CanSelectMissionTree.buildVisibleTree(false);
	}
}

//��������������������ɾ������ʱ������²�������������������������������������������
function UIDelOneMission(%Player,%Mid)
{
	if ($CurrentMissionID == %Mid)
		$CurrentMissionID = -1;

	// ˢ��UI���ѽ���������
	RefreshMissionNum(%Player.GetAcceptedMission());

	// ��������桾�ѽ����������Ƴ�һ��������
	%node = SingleWnd1_Tree1.findMissionTreeNode(%Mid);
	SingleWnd1_Tree1.clearChildItem(%node);

	//��������桾�ɽ������������һ��������
	if (isOrderByMap())
		%Mission_Map = 1;
	else
		%Mission_Map = 0;

	//��ӵ�ǰ����
	if (CanDoThisMission(%Player,%Mid,1,2,0) $= "")
		CreateCanAcceptMissionNode_L(%Player,%Mid,%Mission_Map,true);

	// ��ӿ��ܵĺ�������
	%NextMission = GetNextMission(%Mid);
	if (%NextMission !$= "")
	{
		%MidNum = GetWordCount(%NextMission);

		for (%i = 0; %i < %MidNum; %i++)
		{
			%MidNext = GetWord(%NextMission,%i);
			if (CanDoThisMission(%Player,%Mid,1,2,0) $= "")
				CreateCanAcceptMissionNode_L(%Player,%MidNext,%Mission_Map,true);
		}
	}

	//����������Ϣ�������ǿ��ӵ�
	if (SingleWnd2_ShowMissionInfo.isVisible())
		RefreshMissionDesc(%Mid);

	//��׷�ٽ��桾�ѽӡ������Ƴ�һ��������
	%node = MissionTraceWnd_Tree.findMissionTreeNode(%Mid);
	MissionTraceWnd_Tree.clearChildItem(%node);

	//��׷�ٽ��桾�ɽӡ����ϴ���һ��������
	CreateCanAcceptMissionNode_K(%Player,0);

	//ˢ��������
	SingleWnd1_Tree1.buildVisibleTree(false);
	SingleWnd1_Tree2.buildVisibleTree(false);

	MissionTraceWnd_Tree.buildVisibleTree(false);
	setMissionTraceWnd();
}

//����������������������ȡ����ȫ�������ı�������������������������������������������
function GetMissionText(%Player,%Mid)
{
	if ((strlen(%Mid) >= 6)||(strlen(%Mid) <= 1))
		return "";

	if (strlen(%Mid) <= 4)
		%Mid = "8880" @ %Mid;
	else
		%Mid = "888" @ %Mid;

	return GetDialogText(0,%Player,%Mid,0);
}

//����������������������ȡ���������ı�����������������������������������������������
function GetMissionNeedText(%Player,%Mid,%Type)
{
	if (%Type < 9999)
	{
		if ((%Type >= 1200)&&(%Type < 1250)&&(%Player.GetMissionFlag(%Mid,%Type) > 0))
			return GetMission_Flag(%Player,%Mid,"Target",%Type - 1200,5);

		if ((%Type >= 1250)&&(%Type < 1300)&&(%Player.GetMissionFlag(%Mid,%Type) > 0))
			return GetMission_Flag(%Player,%Mid,"Npc",%Type - 1250,5);

		if ((%Type >= 2200)&&(%Type < 2230)&&(%Player.GetMissionFlag(%Mid,%Type) > 0))
			return GetMission_Flag(%Player,%Mid,"ItemGet",%Type - 2200,5);

		if ((%Type >= 2230)&&(%Type < 2250)&&(%Player.GetMissionFlag(%Mid,%Type) > 0))
			return GetMission_Flag(%Player,%Mid,"Collect",%Type - 2230,5);

		if ((%Type >= 2250)&&(%Type < 2300)&&(%Player.GetMissionFlag(%Mid,%Type) > 0))
			return GetMission_Flag(%Player,%Mid,"ItemAdd",%Type - 2250,5);

		if ((%Type >= 3200)&&(%Type < 3300)&&(%Player.GetMissionFlag(%Mid,%Type) > 0))
			return GetMission_Flag(%Player,%Mid,"MonsterKill",%Type - 3200,5);

		if ((%Type >= 8000)&&(%Type < 9000)&&(%Player.GetMissionFlag(%Mid,%Type) > 0))
			return GetMission_Flag(%Player,%Mid,"Step",%Type - 8000,5);

		if ((%Type >= 9000)&&(%Type < 9100)&&(%Player.GetMissionFlag(%Mid,%Type) > 0))
			return GetMission_Flag(%Player,%Mid,"Test",%Type - 9000,5);

		if ((%Type >= 9100)&&(%Type < 9200)&&(%Player.GetMissionFlag(%Mid,%Type) > 0))
			return GetMission_Flag(%Player,%Mid,"forever",%Type - 9100,5);
	}

	if (%Type == 9999)
	{
		%TxtA = "";
		for (%i = 0; %i < 9; %i++)
		{
			switch (%i)
			{
				case 0:%ii = 9100;//��������
				case 1:%ii = 9000;//��������
				case 2:%ii = 2250;//�������
				case 3:%ii = 2200;//�Ѽ�����
				case 4:%ii = 1200;//Ѱ��Ŀ��
				case 5:%ii = 3200;//ɱ�ּ���
				case 6:%ii = 1250;//Ѱ������Ŀ��
				case 7:%ii = 8000;//������ֵ
				case 8:%ii = 2230;//�ɼ����
			}

			for (%x = 0; %x < 50; %x++)
			{
				if (%Player.GetMissionFlag(%Mid,%ii + %x) > 0)
				{
					%GetMissionNeedText = GetMissionNeedText(%Player,%Mid,%ii + %x);
					if (%GetMissionNeedText !$= "")
						%TxtA = %TxtA @ GetMissionNeedText(%Player,%Mid,%ii + %x) @ "<b/>";
				}
				else
					break;
			}
		}

		%TxtZ = GetMission_Flag(%Player,%Mid,"Npc",99,4) @ "<b/>";
		return %TxtA @ %TxtZ;
	}

	return "GetMissionNeedText = ���� Player��"@%Player@"��Mid��"@%Mid@"��Type��"@%Type@"��";
}

//����������������������ȡ�����Ѷȡ�����������������������������������������������
function GetMission_NanDu(%Mid)
{
	%Png1 = isFile("gameres/gui/images/GUIWindow26_1_010.png");
	%Png2 = isFile("gameres/gui/images/GUIWindow26_1_011.png");

	if ((%Mid == 20002)||(%Mid == 20003))
	{
		%Player = GetPlayer();

		if (%Player.GetLevel() >= 10){ %NanDu1 = 1; }
		if (%Player.GetLevel() >= 20){ %NanDu1 = 1; }
		if (%Player.GetLevel() >= 30){ %NanDu1 = 2; }
		if (%Player.GetLevel() >= 40){ %NanDu1 = 2; }
	}
	else
		%NanDu1 = GetMissionData(%Mid,$Mission_Data_NanDu);

	%NanDu2 = 9 - %NanDu1;

	%R1 = "";
	%R2 = "";

	if ((%Png1 == 1)&&(%Png2 == 1))
	{
		for (%i = 0; %i < %NanDu1; %i++)
			%R1 = %R1 @ "<i s='gameres/gui/images/GUIWindow26_1_010.png' w='16' h='16'/>";

		for (%i = 0; %i < %NanDu2; %i++)
			%R2 = %R2 @ "<i s='gameres/gui/images/GUIWindow26_1_011.png' w='16' h='16'/>";

		return %R1 @ %R2;
	}
	else
	{
		for (%i = 0; %i < %NanDu1; %i++)
			%R1 = %R1 @ "��";

		for (%i = 0; %i < %NanDu2; %i++)
			%R2 = %R2 @ "��";

		return $Get_Dialog_GeShi[31206] @ %R1 @ "</t> <t>" @ %R2 @ "</t>";
	}

	return "��ͼƬ���ݴ���<b/>";
}

//����������������������ȡ�����������ơ�������������������������������������������
function GetMission_Name(%Player,%Mid,%Type)
{
	if (%Player == 0)
		%Player = GetPlayer();

	%Lv = GetMissionData(%Mid,$Mission_Data_LvJ);
	%Lv_P = %Player.GetLevel();
	%kind	= GetMissionKind(%Mid);

	if (%Lv == 0)
		%Lv = %Lv_P;

	%Mission_Name = "[" @ %Lv @ "] " @ GetMissionData(%Mid,$Mission_Data_Name);

	if (%Type == 0)
		return $Get_Dialog_GeShi[31800] @ %Mission_Name @ "</t>";

	else if (%Type == 1)
		return %Mission_Name;

	else if (%Type == 3)
		return %Mission_Name;

	//�����ѽӽ��棨������
	else if (%Type == 2)
	{
		$Mission_Name = GetMissionData(%Mid,$Mission_Data_Name);
		%Mun = 9 - strlen($Mission_Name);

		for (%i = 0; %i <= %Mun; %i++)
			%KongGe = %KongGe @ " ";

		return "[" @ $MissionKind[%kind,2] @ "]" @ $Mission_Name;
	}
}

//����������������������ȡ������ꡢ��ɫ����ʽ������������������������������������
//��������ȡNpcA������
//��������ȡNpcZ������
function GetMission_Flag(%Player,%Mid,%Type,%Num,%GetBack)
{
	%MissionData	= "MissionData_" @ %Mid;
	//����
	switch$(%Type)
	{
		case "Npc":
			switch (%Num)
			{
				case 100:%Id_Type = GetNpcA(%Mid);
				case 99:%Id_Type = GetNpcZ(%Mid);
				default:%Id_Type = %Player.GetMissionFlag(%Mid,1150 + %Num);
			}
		case "MonsterKill"://ɱ������
			%Id_Type = %Player.GetMissionFlag(%Mid,3100 + %Num);
			%Id_Num  = %Player.GetMissionFlag(%Mid,3200 + %Num);

		case "ItemAdd":			//����Ʒ
			%Id_Type = %Player.GetMissionFlag(%Mid,2150 + %Num);
			%Id_Num	 = %Player.GetMissionFlag(%Mid,2250 + %Num);

		case "ItemGet":			//ȡ��Ʒ
			%Id_Type = %Player.GetMissionFlag(%Mid,2100 + %Num);
			%Id_Num  = %Player.GetMissionFlag(%Mid,2200 + %Num);

		case "Collect":			//�ɼ���
			%Id_Type = %Player.GetMissionFlag(%Mid,2130 + %Num);
			%Id_Num  = %Player.GetMissionFlag(%Mid,2230 + %Num);

		case "Target":			//��������
			%Id_Type = %Player.GetMissionFlag(%Mid,1100 + %Num);
			%Id_Num  = %Player.GetMissionFlag(%Mid,1200 + %Num);
	}

	//------------------------------------��ϲ���----------------------------------------��----
	switch (%GetBack)
	{
		case 99:			//����
			switch (strlen(%Id_Type))
			{
				case 5:return "";	//5λ�ı��
				case 9:						//9λ�ı��
					switch$(%Id_Type)
					{
				case "0":
					}
					switch (GetSubStr(%Id_Type,0,1))
					{
						case 1:return GetItemData(%Id_Type,1);//����
						case 4:return GetNpcData(%Id_Type,1);	//NPC��
						case 5:return GetCollectionObjectname(%Id_Type);//�ɼ�
						case 8:return GetTriggerData(%Id_Type,3);	//����
						case 9:	//����׷�� �����������ų�ͻ
							switch$(%Id_Type)
							{
						case "0":return "�������";
							}
					}
				default: return "";
			}

		case 98:	//��ͼ
			return $Get_Dialog_GeShi[31212] @ $Mission_Map[GetMissionData(%Mid,$Mission_Data_Map_Area),2] @ "</t>";

		case 97:	//���꣬�а�ɫ�»�����Ѱ����ť
			%XYZ      = GetRoute_Position(%Id_Type);
			%Map      = GetSubStr(GetRoute_MapID(%Id_Type),1,4);
			%Map_XYZ1 = Pos3DTo2D(GetMissionData(%Mid,$Mission_Data_Map_Area),GetWord(%XYZ,0),GetWord(%XYZ,1));
			%Map_XYZ2 = GetWord(%Map_XYZ1,0) @ "," @ GetWord(%Map_XYZ1,1);

			return "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath("@%Id_Type@");\",\"" @ $Get_Dialog_GeShi[31214] @ "(" @ %Map_XYZ2 @ ")</t>\",\"GuiMissionTraceButtonProfile3\"' cf='createButton' />";

		case 96:			//��������ɫ����
			switch$(%Type)
			{
		case "Npc":         %NumId = 1050;	//NPC
		case "MonsterKill": %NumId = 3000;	//����
		case "ItemGet":     %NumId = 2000;	//����
		case "ItemAdd":     %NumId = 2050;	//����
		case "Target":      %NumId = 1000;	//������
		case "Collect":     %NumId = 2030;	//�ɼ���
			}

			%KillNumMin = %Player.GetMissionFlag(%Mid,%NumId + %Num + 300);//��ǰ����
			%KillNumMax = %Player.GetMissionFlag(%Mid,%NumId + %Num + 200);//�������

			return " " @ %KillNumMin @ "/" @ %KillNumMax @ "</t>";

		case 95://Ŀ��ִ�ж���
			//echo( "=====================" @ GetMission_LeiTou_Text( %Mid, %type ) );
			return GetMission_LeiTou_Text(%Mid,%type,%Num);
			//------------------------------------��ϲ���----------------------------------------��----
			//�˴���ʼ���
		case 1:			//���أ�����ɫ������
			switch$(%Type)
			{
		case "Npc":         %Color = 31212;	//NPC
		case "MonsterKill": %Color = 31206;	//����
		case "ItemGet":     %Color = 31212;	//����
		case "ItemAdd":     %Color = 31212;	//����
		case "Target":      %Color = 31212;	//Ŀ��
		case "Collect":     %Color = 31212;	//�ɼ���
			}

			return $Get_Dialog_GeShi[%Color] @ GetMission_Flag(%Player,%Mid,%Type,%Num,99) @ "</t>";

		case 2:			//���أ�λ��+����+��+����ɫ��NPC��+Ѱ������
			return "<t>λ��</t>" @ GetMission_Flag(%Player,%Mid,%Type,%Num,98) @ "<t>��</t>" @ GetMission_Flag(%Player,%Mid,%Type,%Num,1) @ GetMission_Flag(%Player,%Mid,%Type,%Num,97);

		case 3:			//���أ�������NPC
			//echo( "%Id_Type==" @ %Id_Type );
			%Over = $Get_Dialog_GeShi[31201] @ " ��</t>";
			%SeeLv = $Get_Dialog_GeShi[31201] @ "������</t>";
			%Button = "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath("@%Id_Type@");\",\"" @ $Get_Dialog_GeShi[31214] @ GetMission_Flag(%Player,%Mid,%Type,%Num,99) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' /><b/>";


			if (%Player.GetLevel() < GetMissionData(%Mid,$Mission_Data_LvA))
				%EndTxt = "<b/>" @ $Get_Dialog_GeShi[31206] @ "����Ҫ�������ȼ��ſ��Խ��ܴ�����</t>";
			else
				%EndTxt = "";
			//echo( %Over @ "   " @ %SeeLv @ "   " @ %Button @ "   " @ %EndTxt );
			//echo( "%Button==" @ %Button );
			return %Over @ %SeeLv @ %Button @ %EndTxt;
		case 4:	//���أ�������NPC
			if (%Id_Type > 0)
			{
				if (CanDoThisMission(%Player,%Mid,2,0,0) $= "")
					%Over = $Get_Dialog_GeShi[31212] @ " ��</t>";
				else
					%Over = $Get_Dialog_GeShi[31201] @ " ��</t>";

				if (GetNpcZ(%Mid) == -1)  //������NPC���Ϊ-1ʱ��������UI�в���ʾ������NPC
					return;

				%NpcZ = GetMission_Flag(%Player,%Mid,%Type,%Num,99);
				%NpcZ = (%NpcZ $= "") ? "NpcZ" : %NpcZ;
				%FindpathID = Getfindpath(%Id_Type,%Mid,%NpcZ,31214);

				return %Over @ $Get_Dialog_GeShi[31201] @ "������</t>" @ %FindpathID @ "<b/>";
			}
			else
				return "";
		case 5:	//���أ��ѻ���/��ʰȡ/�ѶԻ�+��ɫ��NPC��+����+Ѱ����ʽ

			//����������Ƿ����㣬��ΪҪ��ɫ
			switch$(%Type)
			{
		case "Npc":         %NumId = 1050;	//NPC
		case "MonsterKill": %NumId = 3000;	//����
		case "ItemGet":     %NumId = 2000;	//����
		case "ItemAdd":     %NumId = 2050;	//����
		case "Target":      %NumId = 1000;	//������
		case "Collect":     %NumId = 2030;	//�ɼ���
			}

			//��������
			if (%NumId > 0)
			{
				%KillNumMin = %Player.GetMissionFlag(%Mid,%NumId + %Num + 300);//��ǰ����
				%KillNumMax = %Player.GetMissionFlag(%Mid,%NumId + %Num + 200);//�������

				if (%KillNumMin < %KillNumMax)
				{
					%ColorA = 31201;	//��ɫ
					%ColorB = 31214;	//����ɫ+�»���
					%OK = " ��";
				}
				else
				{
					%ColorA = 31212;	//��ɫ���»���
					%ColorB = 31212;	//��ɫ���»���
					%OK = " ��";
				}

				%KillNumTxt = $Get_Dialog_GeShi[%ColorA] @ %KillNumMin @ "/" @ %KillNumMax @ "</t>";
			}
			else
			{
				%ColorA = 31201;	//��ɫ
				%OK = " ��";
			}

			//��ȡѰ·ID
			%FindpathID = Getfindpath(%Id_Type,%Mid,0,%ColorB);
			%GetMission_Flag = GetMission_Flag(%Player,%Mid,%Type,%Num,95);
			if (%GetMission_Flag $= "")
				return "";

			return $Get_Dialog_GeShi[%ColorA] @ %OK @ %GetMission_Flag @"</t>"@ %FindpathID @ %KillNumTxt;

		case 6:	//���أ�׷�ٽ��潻����NPC
			%NpcZ = GetMission_Flag(%Player,%Mid,%Type,%Num,99);
			%NpcZ = (%NpcZ $= "") ? "NpcZ" : %NpcZ;
			%FindpathID = Getfindpath(%Id_Type,%Mid,%NpcZ,31214);
			return %FindpathID;
	}

	return "��1="@%Player@"����2="@%Mid@"����3="@%Type@"����4="@%Num@"����5="@%GetBack@"��";
}

//����������������������ͨ�á��ͻ���Ѱ·������������������������������������������
function Getfindpath(%FindpathID,%Mid,%Txt,%ColorB)
{
	%Player = GetPlayer();

	//����������ѡ��
	if (%Txt $= "NpcZ")
	{

	}

	if (%Txt $= "0")
		switch (GetSubStr(%FindpathID,0,1))
	{
			case 1:%Txt = GetItemData(%FindpathID,1);					//����
			case 4:%Txt = GetNpcData(%FindpathID,1);						//NPC��
			case 5:%Txt = GetCollectionObjectname(%FindpathID);		//�ɼ�
			case 8:%Txt = GetTriggerData(%FindpathID,3);				//����
	}

	//�����Ÿñ����б�ţ����޸�Ѱ·Ŀ��
	if ($Item_Monster[%FindpathID] > 0)
	{
		%Mon_Num_Max = GetWordCount($Item_Monster[%FindpathID]);
		%Mon_Nun     = GetRandom(1,%Mon_Num_Max);
		%FindpathID = GetWord($Item_Monster[%FindpathID],%Mon_Nun - 1);
	}

	//����������ţ����⴦��
	if ($Monster_Monster[%FindpathID,%Mid] > 0)
		%FindpathID = $Monster_Monster[%FindpathID,%Mid];

	//���ݱ�����⴦��
	switch (%FindpathID)
	{
		case 418001003: %FindpathID = $HuoDong_YGBK_ID[%Player.GetMissionFlag(%Mid,10001)];
	}

	//Ѱ·����
	%TraceButton = "findpath("@%FindpathID@");";

	//���������
	if ($Item_Text[%FindpathID] !$= "")
		%TraceButton = "SetScreenMessage($Item_Text["@%FindpathID@"], $Color[5]);";

	//����󶨰�ť
	if ($Item_Button[%FindpathID] !$= "")
		%TraceButton = $Item_Button[%FindpathID];

	if ((%Txt $= "") || (%Txt $= "0"))
		return "";

	return "<c cid='" @ Get_TraceButton() @ "' cmd='\""@%TraceButton@"\",\"" @
		$Get_Dialog_GeShi[%ColorB] @ %Txt @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />";
}

//����������������������������ȡ��������Ϣ��������������������������������������
function GetMissionHortation(%Mid,%State,%WndType)
{
	//echo( "%Mid ==" @ %Mid  @ "   %State==" @  %State @ " %WndType===" @ %WndType );
	if (%Mid == -1)
		return "";

	%Player = GetPlayer();

	switch (%State)
	{
		case 1:%PaiXuNum = 86;	%PaiXuNameA = 3; %GeShi = 31212; %newline = "";
		case 3:%PaiXuNum = 80;	%PaiXuNameA = 2; %GeShi = 31212; %newline = "";
		case 4:%PaiXuNum = 80;	%PaiXuNameA = 2; %GeShi = 31212; %newline = "";
		default:
			%PaiXuNum = 86;	%PaiXuNameA = 3; %GeShi = 31212; %newline = "";
	}

	//���ȫ������ICON
	for (%i=%WndType; %i<=(%WndType+9); %i++)
		%Player.ClearMissionItem(%i);

	//���ﾭ�齱��
	%MissionData_Exp = GetMissionData(%Mid,$Mission_Data_Exp);
	if (%MissionData_Exp != 0)
		%Exp = $Get_Dialog_GeShi[%GeShi] @ " ���ﾭ�飺</t><t>[ "@ %MissionData_Exp @" ]</t>";

	//Ԫ������
	%MissionData_Money = GetMissionData(%Mid,$Mission_Data_Money);
	if (%MissionData_Money != 0)
		%Money = $Get_Dialog_GeShi[%GeShi] @ "  Ԫ  �� ��</t><t>[ "@ %MissionData_Money @ " </t>" @ $Icon[89] @ "<t> ]</t>";

	//��ҽ���
	%MissionData_Yuan = GetMissionData(%Mid,$Mission_Data_Yuan);
	//%MissionData_Yuan = 1234567;
	if (%MissionData_Yuan != 0)
		%Yuan = $Get_Dialog_GeShi[%GeShi] @ "  ��  Ǯ ��</t><t>[ </t>" @ ChangeMoneyText(%MissionData_Yuan) @ "<t> ]</t>";

	//��Ծ���ֽ���
	%MissionData_JiFen = GetMissionData(%Mid,$Mission_Data_JiFen);
	if (%MissionData_JiFen != 0)
		%JiFen = $Get_Dialog_GeShi[%GeShi] @ " ��Ծ���֣�</t>[ " @ %MissionData_JiFen @ " ]";

	//ս������
	if (GetMissionData(%Mid,1) == 9)
		%ZcJF = $Get_Dialog_GeShi[%GeShi] @ " ս�����֣�</t>[ 5 ]";

	//״̬
	%MissionData_Buff = GetMissionData(%Mid,$Mission_Data_Buff);
	if (%MissionData_Buff !$= "0")
	{
	}

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
					{
						%SkillTxt = 1;
						%Player.AddItemToMission(%WndType+2,1,%Skill,1);
					}
				}
			}
		}

		if (%SkillTxt > 0)
			%Skill = $Get_Dialog_GeShi[%GeShi] @ " ���ܽ�����</t>" @ %newline @ GetFixedMissionItemText(%WndType+2);
	}

	if ((%State == 1) || (%State == 3))
	{
		//��ȡ����������
		%MissionData_ItemAdd = GetMissionData(%Mid,$Mission_Data_ItemAdd);
		%MissionData_ItemDelete = GetMissionData(%Mid,$Mission_Data_ItemDelete);
		if ((%MissionData_ItemAdd !$= "0") && (%MissionData_ItemDelete == 0))
		{
			//����ְҵ�������
			%Classes = %Player.GetClasses(0);
			for (%i = 0; %i < 50; %i++)
			{
				%ItemAdd = GetWord(%MissionData_ItemAdd,%i * 2,";");
				%ItemNum  = GetWord(%MissionData_ItemAdd,%i * 2 + 1,";");

				if ((%ItemAdd $= "")&&(%ItemNum $= ""))
					break;
				else
				{
					if (HasBit(GetItemData(%ItemAdd,113),%Classes - 1) > 0)
						%Player.AddItemToMission(%WndType+3,1,%ItemAdd,%ItemNum);
				}
			}

			%ItemAdd = $Get_Dialog_GeShi[%GeShi] @ " ��ȡ������</t>" @ %newline @ GetFixedMissionItemText(%WndType+3);
		}
	}

	%Sex = %Player.GetSex();
	%Classes = %Player.GetClasses(0);
	//ѡ���Ե���
	if ($MissionData_ItemChose[%Mid] !$= "")
	{
		//echo( "===================" @ %Mid @ "     ===" @ $MissionData_ItemChose[ %Mid ] );
		for (%i = 0; %i <= 99; %i++)
		{
			%Item = GetWord($MissionData_ItemChose[%Mid],%i * 2,";");
			%Num  = GetWord($MissionData_ItemChose[%Mid],%i * 2 + 1,";");
			//echo( "%Item=AA==" @ %Item @ "    %Num===" @ %Num );
			if ((%Item $= "")&&(%Num $= ""))
				break;
			//echo( "%Item=VV==" @ %Item @ "    %Num===" @ %Num );
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

	if (%MissionData_ItemChose !$= "0" && %MissionData_ItemChose !$= "")
	{
		if (%mid != 24108)
		{
			for (%i = 0; %i < 200; %i++)
			{
				%Item = GetWord(%MissionData_ItemChose,%i * 2,";");
				%Num  = GetWord(%MissionData_ItemChose,%i * 2 + 1,";");

				if ((%Item $= "")&&(%Num $= ""))
					break;
				else
					%Player.AddItemToMission(%WndType+1,0,%Item,%Num);
			}
			%ItemChose = $Get_Dialog_GeShi[%GeShi] @ " ��ѡ���ߣ�</t>" @ %newline @ GetOptionalMissionItemText(%WndType+1);
		}
	}

	//�ظ����� || ����ְҵ�������
	if ($MissionData_ItemSet[%Mid] !$= "")
		%MissionData_ItemChose = $MissionData_ItemSet[%Mid];
	else
		%MissionData_ItemSet = GetMissionData(%Mid,$Mission_Data_ItemSet);

	if ($Mission_Data_ItemClasses[%Mid] !$= "")
		%MissionData_ItemClasses = $Mission_Data_ItemClasses[%Mid];
	else
		%MissionData_ItemClasses = GetMissionData(%Mid,$Mission_Data_ItemClasses);

	if ((%MissionData_ItemSet !$= "0") || (%MissionData_ItemClasses !$= "0"))
	{
		for (%i = 0; %i < 50; %i++)
		{
			%Item = GetWord(%MissionData_ItemSet,%i * 2,";");
			%Num  = GetWord(%MissionData_ItemSet,%i * 2 + 1,";");

			if ((%Item $= "")&&(%Num $= ""))
				break;
			else
				%Player.AddItemToMission(%WndType,1,%Item,%Num);
		}

		//����ְҵ�������
		%Classes = %Player.GetClasses(0);
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
						%Player.AddItemToMission(%WndType,1,%ItemClasses,%SetNum);
				}
			}
		}
		%ItemSet = $Get_Dialog_GeShi[%GeShi] @ " �������ߣ�</t>" @ %newline @ GetFixedMissionItemText(%WndType);
	}

	if (%Exp   !$= "") { %Amount++; %Name[0] = %Exp; }
	if (%Money !$= "") { %Amount++; %Name[1] = %Money; }
	if (%Yuan  !$= "") { %Amount++; %Name[2] = %Yuan; }
	if (%JiFen !$= "") { %Amount++; %Name[3] = %JiFen; }
	if (%ZcJF  !$= "") { %Amount++; %Name[4] = %ZcJF; }

	//���������ݸ�ֵ%PaiXu
	%PaiXuName = 0;
	for (%i=0; %i<7; %i++)
	{
		if (%Name[%i] !$= "")
		{
			%PaiXu[%PaiXuName] = %Name[%i];
			%PaiXuName++;
		}
	}

	if (%PaiXuName > %PaiXuNameA)
	{
		%RewardNum = mCeil(%PaiXuName / 2);
		for (%i=0; %i< %RewardNum; %i++)
		{
			%Blank = %PaiXuNum - strlen(%PaiXu[%i]);
			for (%ii=0; %ii< %Blank; %ii++)
				%PaiXu[%i] = %PaiXu[%i] @ " ";

			//��1λ
			%Reward = %Reward @ %PaiXu[%i];
			//��2λ
			%Reward = %Reward @ %PaiXu[%i + %RewardNum] @ "<b/>";
		}
	}
	else for (%i=0; %i< %PaiXuName; %i++)
		%Reward = %Reward @ %PaiXu[%i] @ "<b/>";

	//���⴦����߽�������
	if (%Skill 		!$= "")%ItemText[%ItemText++] = %Skill;
	if (%ItemAdd 	!$= "")%ItemText[%ItemText++] = %ItemAdd;
	if (%ItemChose !$= "")%ItemText[%ItemText++] = %ItemChose;
	if (%ItemSet 	!$= "")%ItemText[%ItemText++] = %ItemSet;
	for (%i=1; %i<=%ItemText; %i++)
	{
		%BBB = (%i != %ItemText) ? "<b/>" : "";
		%ItemTextNum = %ItemTextNum @ %ItemText[%i] @ %BBB;
	}

	%Reward = %Reward @ %Buff @ %ItemTextNum @ %ShengWang;
	if (%Reward !$= "")
	{
		%Txt = %Reward;
		//echo( "%Txt ===" @ %Txt );
		if ((%Mid >= $JRMB_Mission[0]) && (%Mid <= $JRMB_Mission[15]))
			%Txt = %Txt @ SurprisePartyWnd_ListBox_Choose_ultimate(%Mid);
	}

	%Txt = %Txt  @ eval("Mission" @ %Mid @ "Dialog" @ "(%Npc, %Player, %Mid, 910);");

	return $Get_Dialog_GeShi[31201] @ %Txt @ "</t>";
}

//�����������������������������ȫ������ICON��������������������������������������
function AllClearMissionItem(%Player)
{
	for (%i=10000; %i<=10009; %i++)
		%Player.ClearMissionItem(%i);

	for (%i=10010; %i<=10019; %i++)
		%Player.ClearMissionItem(%i);

	for (%i=10050; %i<=10059; %i++)
		%Player.ClearMissionItem(%i);
}

function MissionSptAutoBuildTeam(%Mid)
{
	//��������ǿ�ƹرնԻ���
	%ConvText = GetMissionData(%Mid,$Mission_Data_Conv);
	if (HasBit(%ConvText,9) > 0)
		sptAutoBuildTeam();
	//AgreeTeamFollow(); �Զ�����
}

function MissionChapter(%Mid_CS)
{
	%Player = GetPlayer();
	%Mid[1] = "20001 20201 20401 20601 20801";
	%Mid[2] = "21005 21006 21105 21106";
	%Mid[3] = "10000";
	%Mid[4] = "10100";
	%Mid[5] = "10200";
	%Mid[6] = "10300";
	%Mid[7] = "10400";
	%Mid[8] = "10500";

	for (%i = 8; %i > 0; %i--)
	{
		%MidNum = GetWordCount(%Mid[%i]);
		for (%ii = 0; %ii < %MidNum; %ii++)
		{
			%Mid = GetWord(%Mid[%i],%ii);

			//			//������Ļ�м��»�ͼƬ
			//			if(%Mid_CS == %Mid)
			//				Setspecial_mission_chaptersbitmap("Taskgui_ZJ_" @ %i @ ".png", 2000);

			//��������׷���»�ͼƬ
			if (%ZhangHuiOK == 0)
				if ((%Player.IsAcceptedMission(%Mid)) || (%Player.IsFinishedMission(%Mid)))
				{
					//��ʾƪ��ͼƬ
					ShowOrHideTraceChapterBmp(1);
					//��ʾ�½�
					SetMissionTraceChapterBmp(%i);
					//����ѭ��
					%ZhangHuiOK++;
				}
		}
	}
	//��ʾƪ��ͼƬ
	//if ( %ZhangHuiOK == 0 )
	//	ShowOrHideTraceChapterBmp( 0 );
}

function RightClickSingleWnd1_Tree1(%col)
{
	%Player = GetPlayer();
	//��ȡ��״������
	%DendriformType = GetWord($DendriformDefining[%col],0);
	//��ȡ��״�ı��
	%DendriformID = GetWord($DendriformDefining[%col],1);
	//��ȡ��״����ʾ
	%DendriformShow = GetWord($DendriformDefining[%col],2);

	//����һ����״�ڵ���������
	if (%DendriformType == 1)
	{
		//����������״
		for (%i = 1; %i <= 100; %i++)
		{
			//������������
			%DendriformDefining[0] = GetWord($DendriformDefining[%i],0);
			//�������ı��
			%DendriformDefining[1] = GetWord($DendriformDefining[%i],1);
			if (%DendriformDefining[0] != 2)
				continue;

			//��������׷��״̬
			%Show = (%DendriformShow == 0) ? 1 : 0;
			$DendriformDefining[%col] = %DendriformType @ " " @ %DendriformID @ " " @ %Show;

			//��������׷�ٽ���
			RightClickSingleWnd1_Tree2(%Player,%DendriformShow,%DendriformType,%DendriformID,%DendriformDefining[1]);
		}
	}
	//��������������
	else if (%DendriformType == 2)
		RightClickSingleWnd1_Tree2(%Player,%DendriformShow,%DendriformType,0,%DendriformID);

	//ˢ������׷�ٽ���
	RefreshTraceMission(%Player);
}

function RightClickSingleWnd1_Tree2(%Player,%DendriformShow,%DendriformType,%DendriformID,%Mid)
{
	%kind1 = GetWord($DendriformMid[%Mid],1);	//����1����״
	%Hide = GetWord($DendriformMid[%Mid],2);		//������ʾ��״̬
	%kind3 = GetWord($DendriformMid[%Mid],3);	//������ʾ��״̬

	switch (%DendriformType)
	{
		case 1:%Compare[1] = %kind1; %Compare[2] = %DendriformID; %Hide = %DendriformShow;
		case 2:%Compare[1] = 0; %Compare[2] = 0;
	}

	//��������׷������
	if (%Compare[1] == %Compare[2])
	{
		//��������׷������
		if (%Hide == 1)
		{
			%node = MissionTraceWnd_Tree.findMissionTreeNode(%Mid);
			MissionTraceWnd_Tree.clearChildItem(%node);

			MissionTraceWnd_Tree.buildVisibleTree(false);
			setMissionTraceWnd();

			$DendriformDefining[%kind3] = 2 @ " " @ %Mid @ " " @ 0;
			$DendriformMid[%Mid] = "2 " @ %kind1 @ " " @ 0;
		}
		else //��ʾ����׷������
		{
			$DendriformDefining[%kind3] = 2 @ " " @ %Mid @ " " @ 1;
			$DendriformMid[%Mid] = "2 " @ %kind1 @ " " @ 1;
		}

		//ˢ�¿ɽӽ�������
		CreateAcceptedMissionNode(%Player,%Mid,isOrderByMap(),true,1);
	}
}

function SortMission(%Player,%ZhuangTai)
{
	//��ȡ��ҵȼ�
	%Leve = %Player.GetLevel();
	//�Ѿ�������
	if (%ZhuangTai == 0)
	{
		//������������ѽ����񣬽�����ɵ�����������ӵ����б�
		%AcceptCountNum = %Player.GetAcceptedMission();
		for (%i = 0; %i < %AcceptCountNum; %i++)
			%Mid[%i] = %Player.GetMission(%i);
	}
	else //δ������
	{
		//��ȡ��ҵ�ǰ�ε�����
		%Lv_Mission = GetCanSeeMission(%Leve);
		%AcceptCountNum = GetWordCount(%Lv_Mission);
		%n = 0;

		for (%i = 0; %i < %AcceptCountNum; %i++)
		{
			%Mid_N = GetWord(%Lv_Mission,%i);
			if (CanDoThisMission(%Player,%Mid_N,1,2,0) $= "")
			{
				%Mid[%n] = %Mid_N;
				%n++;
			}
		}
		//�����������¸�ֵ
		%AcceptCountNum = %n;
	}

	for (%i = 0; %i < %AcceptCountNum - 1; %i++)
	{
		//��ȡ����ȼ�
		//��ȡ�Դ洢����
		%leveNum = GetWordCount(%Prepareleve);

		for (%ii = 0; %ii < (%AcceptCountNum - 1 - %i); %ii++)
		{
			//��ȡ������
			%Midleve[%ii] = GetMissionData(%Mid[%ii],$Mission_Data_LvJ);
			%Midleve[%ii + 1] = GetMissionData(%Mid[%ii + 1],$Mission_Data_LvJ);

			if (%Midleve[%ii] == 0)
				%Midleve[%ii] = %Leve;

			if (%Midleve[%ii] > %Midleve[%ii + 1])
			{
				%MidReserve = %Mid[%ii];
				%Mid[%ii] = %Mid[%ii + 1];
				%Mid[%ii + 1] = %MidReserve;
			}
		}

		//���������
		%iiiNum = %AcceptCountNum - %i - 1;
		%Mid = (%Mid $= "") ? %Mid[%iiiNum] : %Mid @ " " @ %Mid[%iiiNum];
	}

	return %Mid;
}

function RefreshMission_TeShu(%Mid,%op)
{
	%Player = GetPlayer();

	closeHelpDirect1_4(10019);

	//��ȡ����
	if (%op == 1)
	{
		if (%Mid == 20801)findpath(GetMissionData(%Mid,$Mission_Data_NpcZ));	//
		if (%Mid == 20803)findpath(GetMissionData(%Mid,$Mission_Data_NpcZ));	//
		if (%Mid == 20805)findpath(411005013);

		if (%Mid == 20808)
		{
			$Packet[610001] = AddEffectPacket(610001,0,"13.3454 65.6114 101.5","1 0 0 0",0,0,-2,0);
			SetScreenMessage("ͨ�������ס��ٻ��Ĵ����Ž�����ǰ����ʥ������ʹ����",$Color[5]);
			Schedule(1500,0,"findpath",810050102);
		}
		if (%Mid == 20810)findpath(GetMissionData(%Mid,$Mission_Data_NpcZ));	//֧Ԯ����
		if (%Mid == 20811)findpath(411005001);	//�����ݲ���
		if (%Mid == 20812)findpath(411005002);	//��仨��
		if (%Mid == 20813)findpath(411005004);	//�����
		if (%Mid == 20815)findpath(411005008);	//��Ʀ����
		if (%Mid == 20816)findpath(GetMissionData(%Mid,$Mission_Data_NpcZ));	//�µ�����
		if (%Mid == 20817)findpath(411005005);	//����̿�
		if (%Mid == 20818)findpath(411005006);	//����̿�
		if ((%Mid == 21505) || (%Mid == 21605))
		{
			if ($showOrHidePanel < 1)
				showExPanel();

			// OpenDouFuGan(10026);	//��©���澭
		}

		//װ������
		if ((%Mid == 21500) || (%Mid == 21600))
		{
			//�򿪰���
			OpenAllBag();

			//���߶�����ָ��
			OpenDouFuGan_AllBagWndGui(113050001,0);

			//��¼ʹ��113050025���ߺ�ָ��
			$DoufuGan_Item[113050001,1] = GetMission_Data_ItemClasses(%Mid);
		}

		//װ������
		if ((%Mid == 21503) || (%Mid == 21603))
		{
			//�򿪰���
			OpenAllBag();

			//���߶�����ָ��
			OpenDouFuGan_AllBagWndGui(116010001,0);

			$SendCurUsingItemId[116010001,1] = GetMission_Data_ItemClasses(%Mid);
		}

		//�� ��©���澭 �� �л����ɽӽ���
		if ((%Mid == 21505) || (%Mid == 21605))
			OpenCurrentlyMission();

		//�� һ������ �� ��ʾ����
		if ((%Mid == 21510) || (%Mid == 21510))
			SetScreenMessage("������ʮ��·�����������ҧ����һ���ɣ�",$Color[5]);
	}

	//������;
	if (%op == 2)
	{
		//С������
		if ((%Mid == 20805) && (CanDoThisMission(%Player,20805,2,0,0) $= ""))
		{
			SetCombatAssistant(false);
			Schedule(500,0,"findpath",GetMissionData(%Mid,$Mission_Data_NpcZ));
		}

		//�����ݲ���
		if ((%Mid == 20811) && (CanDoThisMission(%Player,20811,2,0,0) $= ""))
		{
			SetCombatAssistant(false);
			Schedule(500,0,"findpath",GetMissionData(%Mid,$Mission_Data_NpcZ));
		}

		//��仨��
		if ((%Mid == 20812) && (CanDoThisMission(%Player,20812,2,0,0) $= ""))
		{
			SetCombatAssistant(false);
			Schedule(500,0,"findpath",GetMissionData(%Mid,$Mission_Data_NpcZ));
		}

		//��Ʀ����
		if ((%Mid == 20815) && (CanDoThisMission(%Player,20815,2,0,0) $= ""))
		{
			SetCombatAssistant(false);
			Schedule(500,0,"findpath",GetMissionData(%Mid,$Mission_Data_NpcZ));
		}

		//����̿�
		if ((%Mid == 20817) && (CanDoThisMission(%Player,20817,2,0,0) $= ""))
		{
			SetCombatAssistant(false);
			Schedule(500,0,"findpath",GetMissionData(%Mid,$Mission_Data_NpcZ));
		}

		//������ - ����
		if ((%Mid == 21508) && (CanDoThisMission(%Player,21508,2,0,0) $= ""))
			ClientOnSptAction(131,1);

		//������ - ����
		if ((%Mid == 21608) && (CanDoThisMission(%Player,21608,2,0,0) $= ""))
			ClientOnSptAction(131,2);
	}

	//�������
	if (%op == 6)
	{
		//�� ���޹ȵ��� �� �л����ɽӽ���
		if ((%Mid == 21504) || (%Mid == 21604))
			OpenCanSelectMission();
	}
}

function GetMission_Data_ItemClasses(%Mid)
{
	%Player = GetPlayer();

	//�ظ����� || ����ְҵ�������
	%MissionData_ItemClasses = GetMissionData(%Mid,$Mission_Data_ItemAdd);

	if (%MissionData_ItemClasses !$= "0")
	{
		//����ְҵ�������
		%Classes = %Player.GetClasses(0);
		for (%i = 0; %i < 9; %i++)
		{
			%ItemClasses = GetWord(%MissionData_ItemClasses,%i * 2,";");
			%SetNum  = GetWord(%MissionData_ItemClasses,%i * 2 + 1,";");

			if ((%ItemClasses $= "") && (%SetNum $= ""))
				break;
			else
			{
				if (HasBit(GetItemData(%ItemClasses,113),%Classes - 1) > 0)
					return %ItemClasses;
			}
		}
	}
}


function CheckDialogState(%state)
{
	%MidState = GetSubStr(%State,0,3);
	%Mid      = GetSubStr(%State,3,5);
	%checkok  = "";

	if (%MidState == 110)
		%checkok = CanDoThisMission(GetPlayer(),%Mid,1,1,1);

	if (%MidState == 910)
		%checkok = CanDoThisMission(GetPlayer(),%Mid,2,1,1);

	////echo("%checkok = "@%checkok);
	return %checkok;
}

