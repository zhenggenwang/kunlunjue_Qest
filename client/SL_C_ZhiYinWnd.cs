/*
================================================================================
ע�����нű���ͷ������ע�����ű��Ĵ���˵������


����˵����1.���˫�����ĿѰ�����NPC
2.��굥�����Ŀ��ʾ���ϸ��Ϣ


Author: ֣����
Date  : 2012.04.27
================================================================================
*/


//�����������������������������������ȹء�����������������������������
//�������������������������ɴ�������ء�����������������������������
//�������������������������ɴ����ؼ���ء�����������������������������
//�������������������������ɹرմ�����ء�����������������������������
//��������������������������ָ��������ݡ�����������������������������
//��������������������������Ի�ָ�����������������������������������
//����������������������ȡɾ�����񴥷���������������������������������
//�����������������������水ť����������������������������������������
//������������������������������㽻������ʱ��������������������������
//���������������������һ������Ƽ�������ϡ���������������������������

$FuGanNum = 10057;
//OpenDouFuGan(%ID) �򿪶�����
//OpenDouFuGan_AllBagWndGui(%Item, %Txt)

//�����������������������������������ȹء�����������������������������
//�򿪶�����------------------------------------------------------------------------------------------------------------------
function OpenDouFuGan(%ID)
{
	%Time = 10000;															//��ʾʱ��
	%Format_Black  = $Get_Dialog_GeShi[31400];	//��ɫ����
	%Format_Yellow = $Get_Dialog_GeShi[31404];	//��ɫ����
	%Format_Green  = $Get_Dialog_GeShi[31414];	//����ɫ����
	%format_Red    = $Get_Dialog_GeShi[31406];  //��ɫ

	if (("Mini_TimerTriggerCtrl_HelpWnd_" @ %ID).isVisible() == 1)
	{
		("Mini_TimerTriggerCtrl_HelpWnd_" @ %ID).setVisible(0);

		("Mini_TimerTriggerCtrl_HelpWnd_" @ %ID).delete();
	}
	putout("�򿪶�����%DialogID===" @ %ID);
	switch (%ID)
	{
		//OpenHelpDirectWnd( "FBDeliverCtrl", "3", "������", 30000, "-170 -5", 1 );//����뿪����
		case 1:
			%Tab = "<t f='����' m='0' n='18' b='1' h='1' gct='0xffff00ff' gcb='0xd9680dff'>";
			OpenHelpDirectWnd("BottomControlWndGui","6",%Tab @ "<b/><t>����TAB����ѡ�й���</t><t>����ݼ���2���ͷż���</t>",0,"390 70",%ID);//���ʩ�ż���
		case 2:OpenHelpDirectWnd("FBDeliverCtrl","3","������",30000,"-170 -5",%ID);//����뿪����
		case 3:
			OpenHelpDirectWnd("FightAssistant_Skill_ShortcutWnd","2","�������",10000,"10 -80",%ID);//ָ�������Զ�ս��
		case 4:
			if (GetPlayer().IsAcceptedMission(10018))
			{
				if (Mini_TimerTriggerCtrl_HelpWnd_3.isVisible() == 1)
				{
					Mini_TimerTriggerCtrl_HelpWnd_3.setVisible(0);
					Mini_TimerTriggerCtrl_HelpWnd_3.delete();
				}
				OpenHelpDirectWnd("FightAssistantWnd","3","����ر�",0,"600 0",%ID);
			}

		case 5://�رհ�������ָ��
			OpenHelpDirectWnd("AllBagWndGui","3","����ر�",0,"200 10",%ID);
		case 6://ָ���鿴װ������
			OpenHelpDirectWnd("KLPlayerInfoGui","1","�鿴����",0,"210 495",%ID);
		case 7:
			OpenHelpDirectWnd("KLPlayerInfoGui","3","����ر�",0,"580 50",%ID);
		case 8:
			OpenHelpDirectWnd("KLJEquipStrengthenWnd","4","���ǿ��",10000,"570 368",%ID);
		case 9:
			OpenHelpDirectWnd("KLJEquipStrengGui","4","�������",10000,"550 415",%ID);
		case 10:
			OpenHelpDirectWnd("MissionDialogWndGui","4","<t>���ѡ��</t>",10000,"100 240",%ID);

		case 11:OpenHelpDirectWnd("BottomControlWndGui","2","<t>ѡ��Ŀ�깥��</t>",10000,"410 150",%ID);

		case 12:OpenHelpDirectWnd("BottomControlWndBtnGui","2","�򿪰���",10000,"30 -100",%ID);
		case 13:OpenHelpDirectWnd( "SkillHintWndGui", "4", "һ���϶�����", 30000, "130 170", %ID );
		case 14://�򿪽���
			OpenHelpDirectWnd("BirdViewMapGui","3","�����",30000,"-85 230",%ID);
			$UpLinePartyWndRecord = 4;
		case 15://��ȡ���
			if ($RecordIsUseThis == 1)
				return;
			OpenHelpDirectWnd("UpLinePartyWndGui","1","�����ȡ",30000,"520 435",%ID);
			$RecordIsUseThis = 1;
		case 16:OpenHelpDirectWnd("AllBagWndGui","2","����ֽ�",0,"150 310",%ID);
		case 17:OpenHelpDirectWnd("BottomControlWndGui","2","����չ��",0,"780 140",%ID);
		case 18://���Խ���
			//echo("============================" @ $StrtegyHelpDirectRecord);
			switch ($StrtegyHelpDirectRecord)
			{
				case 1:
					OpenHelpDirectWnd("StrategyWndGui","2","���ѡ��",0,"185 120",%ID);
				case 2:
					OpenHelpDirectWnd("StrategyWndGui","3","���ѡ��",0,"0 270",%ID);
				case 3:
					OpenHelpDirectWnd("StrategyWndGui","3","�����ȡ",0,"900 470",%ID);
					$StrtegyHelpDirectRecord = 4;
			}
		case 19://���Խ���
			OpenHelpDirectWnd("StrategyWndGui","3","����ر�",0,"780 20",%ID);
		case 20:
			OpenHelpDirectWnd("BottomControlWndBtnGui", "4", "��ȡ���߽���", 0, "40 -140", %ID);
			
		case 21:
			if (!("TimerTriggerStart_OKBtn_" @ $DouFuGanState[21]).isactive())
				return;
			switch ($DouFuGanState[21])
			{
				case 0:OpenHelpDirectWnd("TimerTriggerCtrlTotalWnd", "2", "��ȡ����", 30000, "280 -30", %ID);
				case 1:OpenHelpDirectWnd("TimerTriggerCtrlTotalWnd", "2", "��ȡ����", 30000, "280 40", %ID);
				case 2:OpenHelpDirectWnd("TimerTriggerCtrlTotalWnd", "2", "��ȡ����", 30000, "280 100", %ID);
				case 3:OpenHelpDirectWnd("TimerTriggerCtrlTotalWnd", "2", "��ȡ����", 30000, "280 160", %ID);
			}
		case 22:OpenHelpDirectWnd("FightAssistantWnd","2","���Ӧ��",0,"720 400",%ID);
		case 23:%Tab = "<t f='����' m='0' n='18' b='1' h='1' gct='0xffff00ff' gcb='0xd9680dff'>";
			OpenHelpDirectWnd( "BottomControlWndGui", "6", %Tab @ "<b/><b/><t>����0���ɿ��������</t>", 0, "690 70", %ID );
		case 24:OpenHelpDirectWnd("FightAssistantWnd","2","�Ƽ�����",0,"630 400",%ID);
		case 25:
			if (!KLPlayerInfoGui.IsVisible())
			{
				OpenKLPlayerInfoGui();
				CloseNewFunctionTipFlash(1,0);
			}
			$PetZhiYinRecord = 1;
			OpenHelpDirectWnd("KLPlayerInfoGui","4","�����",0,"330 100",%ID);
		case 26:
			closeHelpDirect1_4(25);
			//%Tab1 = "<t f='����' m='0' n='18' b='1' h='1' gct='0xffff00ff' gcb='0xd9680dff'>";
			%Tab2 = "<t f='����_GB2312' m='0' n='16' b='1' h='1' c='0xf3d300ff' o='0x291b00ff'>";				//��ɫ
			OpenHelpDirectWnd("KLPlayerInfoGui","8",%Tab2 @ "<b/><t>��ק����ͷ��</t>" @ %Tab2 @ "<t>����������</t>" @ %Text @ "�������ٻ�Ŷ</t>",0,"130 145",%ID);
			$PetZhiYinRecord = 0;
		case 27://��ð�����ָ��ʹ��
			if (!AllBagWndGui.IsVisible())
				OpenBag();
			switch ($DouFuGanState[27])
			{
				case 1:Schedule(1000, 0, "OpenDouFuGan_AllBagWndGui", 112010055, 0);
				case 2:Schedule(1000, 0, "OpenDouFuGan_AllBagWndGui", 112010056, 0);
			}
		case 30:OpenHelpDirectWnd("EquipChangeWnd","4","һ������",30000,"230 165",%ID);
		case 31:OpenHelpDirectWnd("UpLinePartyWndGui","3","����ر�",30000,"750 0",%ID);
		case 10001:OpenHelpDirectWnd("MissionTraceWnd","4","���Ѱ·",30000,"30 60",%ID);
		case 10002:OpenHelpDirectWnd("MissionTraceWnd","4","���Ѱ·",30000,"80 40",%ID);
		case 10011:
			if (GetPlayer().GetMissionFlag(%id,3200) == GetPlayer().GetMissionFlag(%id,3300))//��������Ѿ����
				OpenHelpDirectWnd("MissionTraceWnd","4","���Ѱ·",30000,"80 40",%ID);
			else
				OpenHelpDirectWnd("MissionTraceWnd","4","���Ѱ·",30000,"30 60",%ID);
		case 10021:
			if (GetPlayer().GetMissionFlag(%id,2200) == GetPlayer().GetMissionFlag(%id,2300))//��������Ѿ����
				OpenHelpDirectWnd("MissionTraceWnd","4","���Ѱ·",30000,"80 40",%ID);
			else
				OpenHelpDirectWnd("MissionTraceWnd","4","���Ѱ·",30000,"30 70",%ID);
		case 10032:OpenHelpDirectWnd("MissionDialogWndGui","4","<t>���ѡ��</t>",0,"100 145",%ID);
		case 10041:OpenHelpDirectWnd("MissionTraceWnd","4","���Ѱ·",30000,"80 40",%ID);

		case 10061:
			if (GetPlayer().GetMissionFlag(%id,2200) == GetPlayer().GetMissionFlag(%id,2300))
				OpenHelpDirectWnd("MissionTraceWnd","4","���Ѱ·",30000,"80 40",%ID);
			else
				OpenHelpDirectWnd("MissionTraceWnd","4","���Ѱ·",30000,"30 70",%ID);
		case 10071:OpenHelpDirectWnd("MissionTraceWnd","4","���Ѱ·",30000,"80 40",%ID);
		case 10081:OpenHelpDirectWnd("MissionTraceWnd","4","���Ѱ·",30000,"80 40",%ID); 
		case 10091:
			if (GetPlayer().GetMissionFlag(%id,2200) == GetPlayer().GetMissionFlag(%id,2300))
				OpenHelpDirectWnd("MissionTraceWnd","4","���Ѱ·",30000,"80 40",%ID);
			else
				OpenHelpDirectWnd("MissionTraceWnd","4","���Ѱ·",30000,"30 70",%ID);
		case 10101:OpenHelpDirectWnd( "MissionTraceWnd", "4", "���Ѱ·", 30000, "80 40", %ID );
		case 10111:OpenHelpDirectWnd("MissionTraceWnd","4","���Ѱ·",30000,"80 40",%ID);
		case 10121:OpenHelpDirectWnd( "MissionTraceWnd", "4", "���Ѱ·", 30000, "80 40", %ID );
		case 10131:OpenHelpDirectWnd( "MissionTraceWnd", "4", "���Ѱ·", 30000, "80 40", %ID );	
		case 10141:
			if ( GetPlayer( ).GetMissionFlag( %id, 2200 ) == GetPlayer( ).GetMissionFlag( %id, 2300 ) )
				OpenHelpDirectWnd( "MissionTraceWnd", "4", "���Ѱ·", 30000, "80 40", %ID );
			else
				OpenHelpDirectWnd( "MissionTraceWnd", "4", "���Ѱ·", 30000, "30 70", %ID );
		case 10151:OpenHelpDirectWnd( "MissionTraceWnd", "4", "���Ѱ·", 30000, "80 40", %ID );
		case 10161:OpenHelpDirectWnd( "MissionTraceWnd", "4", "���Ѱ·", 30000, "80 40", %ID );
		case 10162:OpenHelpDirectWnd( "MissionTraceWnd", "4", "���Ѱ·", 30000, "80 40", %ID );
		case 10163:
			if ( GetPlayer( ).GetMissionFlag( %id, 3200 ) == GetPlayer( ).GetMissionFlag( %id, 3300 ) )
				OpenHelpDirectWnd( "MissionTraceWnd", "4", "���Ѱ·", 30000, "80 40", %ID );
			else
				OpenHelpDirectWnd( "MissionTraceWnd", "4", "���Ѱ·", 30000, "30 60", %ID );
		case 10171:
			OpenHelpDirectWnd("MissionTraceWnd","4","���Ѱ·",30000,"80 40",%ID);
		case 10221:OpenHelpDirectWnd("MissionTraceWnd","4","���Ѱ·",30000,"80 40",%ID);
		case 10231:
			for (%i = 0; %i < 5; %i++)
			{
				%ItemID = 105220004 + %i * 10000;
				if (GetPlayer().Getitemcount(%ItemID) > 0)
				{
					OpenDouFuGan_AllBagWndGui(%ItemID,5);//ָ����������
					break;
				}
			}
		case 10321:
			%Text = "<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>ԭ���˴�������ͯ����֮�ذ��������湻Ũ���ģ������������ʯ��</t>";
			Dialog_OnlyOK_COVER_Content.setContent(%Text);

			Dialog_OnlyOK_COVER_OKBTN.settext("ȷ��");
			Dialog_OnlyOK_COVER_OKBTN.command = "Dialog_OnlyOK_COVER.setVisible(0);";

			Dialog_OnlyOK_COVER.setVisible(true);
		case 10361:
			%Player = GetPlayer();
			%Record = 0;
			%MainNum = GetStrategyMainBtnNum();
			//echo( "%MainNum===" @ %MainNum );
			for (%i = 0; %i < %MainNum; %i++)//�������Խ���
			{
				%SubNum = GetStrategySubBtnNum(%i);
				//echo( "%SubNum===" @ %SubNum );
				for (%j = 0; %j < %SubNum; %j++)
				{
					%Src = $StrategySubBtnSrc[%i,%j];
					//echo( "%Src===" @ %Src );
					//echo( "$StrategySubBtnSrc[" @ %i @ "," @ %j @ "]===" @ $StrategySubBtnSrc[ %i, %j ]  @ "   " @  $StrategySubBtnTit[ %i, %j ] @ "   " @ GetSrc( %Player, %Src ) );
					if (GetSrc(%Player,%Src) == 1 && GetSrc(%Player,%Src + 1) == 0 && %Src !$="")
					{
						%Record = 1;
						//echo( "$StrategySubBtnSrc[" @ %i @ "," @ %j @ "]===" @ $StrategySubBtnSrc[ %i, %j ]  @ "   " @  $StrategySubBtnSrc[ %i, %j ] );
						break;
					}
				}
			}
			//echo( "%Record===" @ %Record );
			if (%Record == 1)
			{
				%Tab1 = "<t f='����' m='0' n='18' b='1' h='1' gct='0xffff00ff' gcb='0xd9680dff'>";
				%Tab2 = "<t f='����_GB2312' m='0' n='16' b='1' h='1' c='0xf3d300ff' o='0x291b00ff'>";
				OpenHelpDirectWnd("MissionTraceWnd","7",%Tab1 @ "<t>��ȡ���Խ���</t><b/>" @ %Tab2 @ "<t>��ϲ��ѧ���Զ�ս��</t><t>��ɹ����н�������ȡ</t>",0,"-250 -140",%ID);
			}
	}

}

//�رն�����------------------------------------------------------------------------------------------------------------------
function CloseDouFuGan(%ID)
{
	switch (%ID)
	{
		case 1000:
	}
}

//�����������������������������������ȹء�����������������������������

/*

closeHelpDirect1_4(10051);

OpenDouFuGan(10051);

//660
//400

//1090
//700

$YiDongPos = 5;

function AAAA(%Ax, %Ay, %Bx, %By)
{
Cancel($SSSS);

%Nx = %Bx - %Ax;
%Ny = %By - %Ay;

//�ƶ��Ĵ���
%TimeCi = ((%Nx >= %Ny) ? %Nx:%Ny) / $YiDongPos;

//�ƶ����ٶ�
%Nx = %Nx / %TimeCi;
%Ny = %Ny / %TimeCi;

//����ÿ������
%Extent = Mini_TimerTriggerCtrl_HelpWnd_10051.getExtent();
%ExtentX = GetWord(%Extent, 0);
%ExtentY = GetWord(%Extent, 1);

%NExtentX = %ExtentX / %TimeCi;
%NExtentY = %ExtentY / %TimeCi;

SSSS(%TimeCi, %Ax, %Ay, %Nx, %Ny, %ExtentX, %ExtentY, %NExtentX, %NExtentY);
}

function SSSS(%TimeCi, %Ax, %Ay, %Nx, %Ny, %ExtentX, %ExtentY, %NExtentX, %NExtentY)
{
echo(%TimeCi@" "@%Ax@" "@%Ay@" "@%Nx@" "@%Ny@" "@%ExtentX@" "@%ExtentY@" "@%NExtentX@" "@%NExtentY);
if(%TimeCi <= 0)
return;

//�����ƶ�
Mini_TimerTriggerCtrl_HelpWnd_10051.setposition(%Ax, %Ay);

//�´��ƶ�����
%Ax = %Ax + %Nx;
%Ay = %Ay + %Ny;

//���ô�С
Mini_TimerTriggerCtrl_HelpWnd_10051.setExtent(%ExtentX, %ExtentY);

//�´δ�С����
%ExtentX = %ExtentX - %NExtentX;
%ExtentY = %ExtentY - %NExtentY;

$SSSS = Schedule(20, 0, "SSSS", %TimeCi--, %Ax, %Ay, %Nx, %Ny, %ExtentX, %ExtentY, %NExtentX, %NExtentY);
}

AAAA(500, 300, 1124, 800);

*/
//��������������������������Ի�ָ�����������������������������������
function Get_Mission_Dialog_ZhiYinWed(%Player,%DialogID)
{
	/*
	900��ͷ ���������ѡ��
	910��ͷ ��������ĵ����Ի���
	100��ͷ ��ȡ�����ѡ��
	110��ͷ ��ȡ����ĵ����Ի���
	*/
	//echo("������Ի�ָ������%DialogID===" @ %DialogID);
	if (strlen(%DialogID) > 5)
		%MissIonID = GetSubStr(%DialogID,3,strlen(%DialogID) -3);
	else
		%MissIonID = %DialogID;

	if (("Mini_TimerTriggerCtrl_HelpWnd_" @ %MissIonID).isvisible())
		closeHelpDirect1_4(%MissIonID);
	//echo( "%MissIonID===" @ %MissIonID );
	if (%MissIonID <= 10161)//ҩ԰ǰ��������������
	{
		if (strlen(%DialogID)  == 5)
		{
			OpenHelpDirectWnd("MissionDialog2ClildWndGui","3","<t>�����һ��</t>",0,"-80 380",%MissIonID);
			//echo( "%MissIonID===" @ %MissIonID );
		}
		else
		{
			//echo( "%������Ի�ָ������MissIonID===" @ %MissIonID );
			switch (GetSubStr(%DialogID,0,3))
			{
				case 900:
					if (%MissIonID != 10032)
						OpenHelpDirectWnd("MissionDialogWndGui","4","<t>���ѡ��</t>",0,"100 145",%MissIonID);
				case 910:
					OpenHelpDirectWnd("MissionDialog2ClildWndGui","3","<t>������</t>",0,"-80 380",%MissIonID);
				case 110:
					OpenHelpDirectWnd("MissionDialog2ClildWndGui","3","<t>�������</t>",0,"-80 380",%MissIonID);
				case 100:
					OpenHelpDirectWnd("MissionDialogWndGui","4","<t>�������</t>",0,"100 145",%MissIonID);
			}
		}
	}
	switch (%DialogID)
	{
		//case 10002:
		//	//echo( "�����һ��" );
		//	OpenHelpDirectWnd( "MissionDialog2ClildWndGui", "3", "<t>�����һ��</t>", 0, "-80 380", %MissIonID );
		//case 90010002:
		//	OpenHelpDirectWnd( "MissionDialogWndGui", "4", "<t>���ѡ��</t>", 0, "100 145", %MissIonID );
		//case 90010031:
		//	OpenHelpDirectWnd( "MissionDialogWndGui", "4", "<t>���ѡ��</t>", 0, "100 145", %MissIonID );
		//case 91010002:
		//	OpenHelpDirectWnd( "MissionDialog2ClildWndGui", "3", "<t>������</t>", 0, "-80 380", %MissIonID );
		//case 91010011:
		//	OpenHelpDirectWnd( "MissionDialog2ClildWndGui", "3", "<t>������</t>", 0, "-80 380", %MissIonID );
		case 91010031:
			%Classes = getPlayer().GetClasses(0);
			switch (%Classes)
			{
				case 1:%Text = "<t>��ǹ";
				case 3:%Text = "<t>����";
				case 4:%Text = "<t>����";
			}
			%Tab1 = "<t f='����' m='0' n='18' b='1' h='1' gct='0xffff00ff' gcb='0xd9680dff'>";
			%Tab2 = "<t f='����_GB2312' m='0' n='16' b='1' h='1' c='0xf3d300ff' o='0x291b00ff'>";				//��ɫ
			OpenHelpDirectWnd("MissionDialog2ClildWndGui","8",%Tab1 @ "<t>ѡ��һ������</t><b/>" @ %Tab2 @ "<t>������ͨ������</t>" @ %Text @ "�Ǳ�ְҵר������</t>",0,"180 270",%MissIonID);

		case 10010011:
			OpenHelpDirectWnd("MissionDialogWndGui","1","><t>���ѡ��</t>",0,"200 45",%MissIonID);
		case 11010011:
			OpenHelpDirectWnd("MissionDialog2ClildWndGui","3","�����������",0,"-80 380",%MissIonID);
			//case 90010003:
			//	OpenHelpDirectWnd( "MissionDialogWndGui", "1", "<t></t><b/><t>���ѡ��</t>", 0, "200 45", %ID );
	}
}
//��������������������������Ի�ָ�����������������������������������

//����������������������ȡɾ�����񴥷���������������������������������
//%optype 1 ��ȡ���� 2 ɾ������
function Open_MissionZhiYin(%Mid, %optype)
{
	putout("��ȡɾ�����񴥷�%Mid====" @ %Mid  @ "     %optype====" @ %optype);
	//����ָ��
	switch (%optype)
	{
		case 1:
			switch (%Mid)
			{
				case 10001:OpenDouFuGan(%Mid);
				case 10002:Schedule(12000, 0, "OpenDouFuGan", %Mid);
				case 10011:OpenDouFuGan(%Mid);
				case 10021:OpenDouFuGan(%Mid);
				case 10031:OpenDouFuGan(%Mid);
				case 10041:OpenDouFuGan(%Mid);
				case 10061:OpenDouFuGan(%Mid);
				case 10071:OpenDouFuGan(%Mid);
				case 10081:OpenDouFuGan(%Mid);
				case 10091:OpenDouFuGan(%Mid);
				case 10101:Schedule(19 * 1000, 0, "OpenDouFuGan", %Mid);
				case 10111:Schedule(13 * 1000, 0, "OpenDouFuGan", %Mid);
				case 10121:
					ExitConversation();//�رս����Ի�
					OpenDouFuGan(12);//ָ���򿪰���
				case 10131:OpenDouFuGan(%Mid);
				case 10141:OpenDouFuGan(%Mid);
				case 10151:OpenDouFuGan(30);
				case 10161:OpenDouFuGan(%Mid);
				case 10162:OpenDouFuGan( %Mid );
				case 10163:OpenDouFuGan(%Mid);
				case 10231:
					%Text = "<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>��ʦ�㴫���������������ѧϰ��</t>";
					Dialog_OnlyOK_COVER_Content.setContent(%Text);

					Dialog_OnlyOK_COVER_OKBTN.settext("ȷ��");
					Dialog_OnlyOK_COVER_OKBTN.command = "Dialog_OnlyOK_COVER.setVisible(0);OpenAllBag( );OpenDouFuGan( 10231 );";
					Dialog_OnlyOK_COVER.setVisible(true);
				case 10281:
					OpenAllBag();//�򿪰���
					for (%i = 0; %i <= 20; %i++)
					{
						%ItemID = getword($MissionData_ItemChose[10271], %i * 2, ";");
						if (GetPlayer().Getitemcount(%ItemID) > 0)
						{
							OpenDouFuGan_AllBagWndGui(%ItemID, 4);//ָ����������
							break;
						}
					}
				case 10321:ExitConversation();//�رս����Ի�
					Schedule(11000, 0, "OpenDouFuGan", %Mid);
				case 10361:OpenDouFuGan(%Mid);
				case 10481:OpenAllBag(); Schedule(1000, 0, "OpenDouFuGan_AllBagWndGui", 107050001, 0);//ָ����������
				case 10761:
					OpenKLJStrengthenByType(1);//��ǿ������
					Schedule(500, 0, "OpenAllBag");
					for (%i = 0; %i <= 20; %i++)
					{
						%ItemID = getword($Mission_Data_ItemClasses[10751], %i * 2, ";");
						if (GetPlayer().Getitemcount(%ItemID) > 0)
						{
							OpenDouFuGan_AllBagWndGui(%ItemID, 0);//ָ����������
							break;
						}
					}
				case 10771:
					for (%i = 0; %i <= 20; %i++)
					{
						%ItemID = getword($Mission_Data_ItemClasses[10751], %i * 2, ";");
						if (GetPlayer().Getitemcount(%ItemID) > 0)
						{
							%index = GetItem_ToBagIndex(%itemid);//�ͻ��� ���������ڰ����ڵ�λ��
							hintGetEquipInfo(%index);
							break;
						}
					}
				case 10781:
					OpenKLJEquipStrengGui();//��������
					Schedule(500, 0, "OpenAllBag");
					for (%i = 0; %i <= 20; %i++)
					{
						%ItemID = getword($Mission_Data_ItemClasses[10771], %i * 2, ";");
						//echo( "%ItemID====" @ %ItemID );
						if (GetPlayer().Getitemcount(%ItemID) > 0)
						{
							OpenDouFuGan_AllBagWndGui(%ItemID, 0);//ָ����������
							break;
						}
					}
				case 10791:
					for (%i = 0; %i <= 20; %i++)
					{
						%ItemID = getword($Mission_Data_ItemClasses[10771], %i * 2, ";");
						if (GetPlayer().Getitemcount(%ItemID) > 0)
						{
							%index = GetItem_ToBagIndex(%itemid);//�ͻ��� ���������ڰ����ڵ�λ��
							hintGetEquipInfo(%index);
							break;
						}
					}
				case 10811:findpath(410010141);
				default:return;
			}
		case 2:
			UpdateMissionEffect(GetPlayer(), %Mid, 1);
		default:
			return;
	}

}
//����������������������ȡɾ�����񴥷�������������������������������
$ShapeFashion[1,1,1] = 102081001;			//սʿʱװ1
$ShapeFashion[1,1,2] = 102081001;			//սʿʱװ2
$ShapeFashion[1,1,3] = 102081022;			//սʿʱװ3

$ShapeFashion[2,1,1] = 102081002;			//����ʱװ1
$ShapeFashion[2,1,2] = 102081002;			//����ʱװ2
$ShapeFashion[2,1,3] = 102081021;			//����ʱװ3

$ShapeFashion[3,1,1] = 102081003;			//��ʦʱװ1
$ShapeFashion[3,1,2] = 102081003;			//��ʦʱװ2
$ShapeFashion[3,1,3] = 102081023;			//��ʦʱװ3

$ShapeFashion[4,1,1] = 102081004;			//��ʿʱװ1
$ShapeFashion[4,1,2] = 102081004;			//��ʿʱװ2
$ShapeFashion[4,1,3] = 102081025;			//��ʿʱװ3

$ShapeFashion[5,1,1] = 102081005;			//����ʱװ1
$ShapeFashion[5,1,2] = 102081005;			//����ʱװ2
$ShapeFashion[5,1,3] = 102081024;			//����ʱװ3


//�����������������������水ť����������������������������������������

function CloseHelpDirectByIndex(%index,%type)
{
	%Player = GetPlayer();

	switch (%index)
	{
		case 1://��ҵ��Ѱ����ر�
		case 2://��ҵ����������ѡ��ر�
		case 3://��ҵ����ɰ�ť����ر�
		case 4://��Ҵ򿪰�����ر�
			$MissionZhiYin[10121] = %Player.IsAcceptedMission(10121);
			if ($MissionZhiYin[10121] == 1)
			{
				closeHelpDirect1_4(12);
				for (%i = 0; %i < 5; %i++)
				{
					%ItemID = 105220003 + %i * 10000;
					if (GetPlayer().Getitemcount(%ItemID) > 0)
					{
						OpenDouFuGan_AllBagWndGui(%ItemID,5);//ָ����������
						break;
					}
				}
			}
		case 5://���װ����������ر�

		case 6://���ʹ����ϵͳ��ݼ�����
			if (%type == 0) //ְҵ����1
				closeHelpDirect1_4(11);
			if (%type == 1)
				closeHelpDirect1_4(1);

		case 7://��Ҵ������޽����ر�

		case 8://��Ҹ����޼ӵ��ر�

		case 13://��Ҵ򿪡����ܽ��桿����
			closeHelpDirectWndGui7_7();

		case 14://��ҵ��ѧϰ���ܰ�ť��ر�

		case 17://�������ȷ��ѡ���ر� --������

		case 18://���ѧϰ���ܰ�ť��ر� --������

		case 23://�������ѧϰ��ť��ر� --������

		case 42://����������зֽⰴť��ر�
			if ($MissionZhiYin[10281] == 2)
			{
				closeHelpDirect1_4(16);
				for (%i = 0; %i <= 9; %i++)
				{
					%ItemID = getword($MissionData_ItemChose[10031],%i * 2,";");
					if (GetPlayer().Getitemcount(%ItemID) > 0)
					{
						OpenDouFuGan_AllBagWndGui(%ItemID,2);//ָ����������
						$MissionZhiYin[10281] = 3;
						break;
					}
				}
			}

		case 45://��Ҵ��˼��ܽ����ر� --������
			//CloseHelpDirectWnd(3);

		case 46://��ҵ�������桾��ˡ���ť����

		case 47://��ҵ���������桾��������ť����

		case 48://��ҵ��������桾��������ť����

		case 49://��ҵ��������桾��������ť����

		case 50://��ҵ�����ܽ��桾������������ť����

		case 51://�򿪡����顿����ʱ����


		case 52://�򿪡����ѡ�����ʱ����


		case 53://�򿪡�����תתת������ʱ����


		case 54://�򿪡��³�������ʱ����


		case 55://�򿪡������١�����ʱ����


		case 56://�򿪡�������������ʱ����


		case 57://���һ�Ρ����޼�����ʱ����


		case 58://�ɹ�ѧϰ����һ�֡�����ܡ�ʱ����


		case 59://�򿪡�ս�����֡�����ʱ����


		case 60://�ɹ��ֽ�һ��װ��ʱ����
			if ($MissionZhiYin[10281] == 3)
			{
				//CloseAllBag( );
				closeHelpDirect1_4(0);
				$MissionZhiYin[10281] = 0;
			}

		case 61://�򿪡���ԯ��������ʱ����


		case 62://���һ�Ρ�װ�����ס�ʱ����


		case 63://����һ�Ρ��������ʱ����


		case 64://�򿪡������̵꡿����ʱ����


		case 65://�򿪡������ѡ�����ʱ����


		case 66://�򿪡����а񡿽���ʱ����


		case 67://�ڻ�ɽ�۽������һ�Ρ���ս��


		case 68://����һ�Ρ���Ȫ������ͼ


		case 69://����һ�������ɡ�


		case 70://�򿪡���١�����ʱ����


		case 71://�μ�һ��ʱ���Ѻۻ


		case 72://���һ��ʥ�ؾ�������


		case 73://���һֻ40����Я��������


		case 74://�μ�һ�βر�ͼ�


		case 75://���һ������ȡ���


		case 76://�μ�һ�οƾٻ


		case 77://�μ�һ��а��Ĺ�


		case 78://�μ�һ�������


		case 79://�μ�һ��ʮ��·�����


		case 80://�μ�һ���������ֻ


		case 81://����һ�ξ�ս��ԭս��


		case 82://����һ�������߸�կ����


		case 83://�򿪡�����������ʱ����


		case 84://���һֻ65����Я��������


		case 85: //CloseHelpDirectWnd(1); //����ƶ�ť��ر�

		case 86://����һ�λ��ι�֮ս����


		case 87://����һ�����յ�һս����


		case 88://���һ�������ֻ�


		case 89://�򿪡�Ů�ʯ������ʱ����


		case 90://�򿪡���꡿����ʱ����


		case 91://������������رհ�ť����
			//�ر�ָ��������
			closeHelpDirect1_4(5);
			if ($MissionZhiYin[10032] == 2)
			{
				//if ( !KLPlayerInfoGui.Isvisible( ) )//���������Խ���
				//{
				//	OpenKLPlayerInfoGui( );
				//	CloseNewFunctionTipFlash( 1, 0 );
				//}
				//$MissionZhiYin[ 10032 ] = 3;
				OpenDouFuGan(10032);
			}
		case 92://���������رհ�ť����
			if ($MissionZhiYin[10032] == 4)
			{
				OpenDouFuGan(10032);
				$MissionZhiYin[10032] = 0;
			}
		case 93://�����װ���󶨡�ȷ�ϰ�ť����

		case 94://�����ǿ�����رհ�ť����

		case 95:
			//������������桿�������󴥷�1

		case 96:
			//������������桿��������󴥷�


		case 97:
			//������ǿ�����桿������״���

		case 98://������ͼ�������Ѩ��ť����

		case 99://������ͼ�����������ť����

		case 100://������ͼ���������Ѩ��ť����

		case 101://�����񡿵�������������
			//�����
		case 102://��ǿ�����桿װ����װ�ť����

		case 103://��ǿ�����桿������Ƕ��ҳ��ť����

		case 104://��ǿ�����桿��������ť����

		case 105://��ǿ�����桿��Ƕ���鰴ť����

		case 106://��ǿ�����桿��Ƭ�ϳ���״1����

		case 107://��ǿ�����桿��Ƭ�ϳ���״2����

		case 108://��ǿ�����桿�ϳ����鰴ť����

		case 109://���һ����桿����򿪴���

		case 111://���һ����������رմ���

		case 112://�����޽��桿����ٻ��ɹ��󴥷�

		case 113://�����޽��桿����رմ���

		case 114://�����޽��桿���ǿ������

		case 115:// ���һ����桿���������
			closeHelpDirect1_4(3);
		case 116:// �����󴥷�
			//switch ( %type )
			//{
			//	case 8:OpenAllBag( );
			//	case 11:OpenAllBag( );
			//}
			
		case 117://ǿ������
			
	}
}
//�����������������������水ť����������������������������������������

//������������������������������㽻������ʱ��������������������������
function GotoFinishMissIonpath(%Mid)//
{
	switch (%Mid)
	{
		case 10011:
			SetCombatAssistant(0); Schedule(300,0,"findpath",410100012);
			OpenDouFuGan(%Mid);
		case 10021:OpenDouFuGan(%Mid);
		case 10061:
			%Text = "<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>���Ǻ�����ǻ�ȥ�������������</t>";
			Dialog_OnlyOK_COVER_Content.setContent( %Text );
			Dialog_OnlyOK_COVER_OKBTN.settext( "ȷ��" );
			Dialog_OnlyOK_COVER_OKBTN.command = "Dialog_OnlyOK_COVER.setVisible(0);findpath(410100018);";
			Dialog_OnlyOK_COVER.setVisible( true );
		case 10091:OpenDouFuGan(%Mid);
		case 10121:CloseAllBag( ); OpenDouFuGan( 13 ); OpenDouFuGan( %Mid );
		case 10141:OpenDouFuGan( %Mid );
		case 10151:OpenDouFuGan( %Mid );
		case 10163:OpenDouFuGan( %Mid );
		case 10171:OpenDouFuGan( %Mid );
		case 10191:ExitConversation();findpath(410100062);
		case 10231:CloseAllBag(); OpenDouFuGan(17);
		case 10221:CloseAllBag();
		case 10032:
			OpenAllBag();//�򿪰���
			for (%i = 0; %i <= 9; %i++)
			{
				%ItemID = getword($MissionData_ItemChose[10031],%i * 2,";");
				//echo( "%ItemID====" @ %ItemID );
				if (GetPlayer().Getitemcount(%ItemID) > 0)
				{
					OpenDouFuGan_AllBagWndGui(%ItemID,4);//ָ����������
					break;
				}
			}
		case 10821:findpath( 410010113 );
		case 11022:
			//echo( "===========11022" );
			%Text = "<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>�˴�Թ��̫�أ��о�������ѹ���ˣ�����û�����ɷ����Ǵ�����ȥ��</t>";
			Dialog_OnlyOK_COVER_Content.setContent(%Text);
			Dialog_OnlyOK_COVER_OKBTN.settext("ȷ��");
			Dialog_OnlyOK_COVER_OKBTN.command = "Dialog_OnlyOK_COVER.setVisible(0);findpath( 411280101 );";
			Dialog_OnlyOK_COVER.setVisible(true);

		default:return;
	}
	//SetCombatAssistant( false );//ֹͣ�һ�
	//findpath( GetMissionData( %Mid, $Mission_Data_NpcZ ) );
}
//������������������������������㽻������ʱ����������������������������



//�������������������������ɴ�������ء�����������������������������
function OpenHelpDirectWnd(%aimCtrl,%type,%Txt,%Time,%OffsetXY,%Index)
{
	Cancel($HelpDirectID[%Index]);
	//	echo( "%Index===" @ %Index @ "    %type===" @ %type );
	closeHelpDirect1_4(%Index);

	//	//�Ƿ���ʾ
	//	if($bGCancelHelpDirect || !isobject(%aimCtrl))
	//		return;

	//�����¿ؼ�
	GuiHelpDirectWndGui1(%Index,%type);

	//���ÿؼ�����
	if (%type <= 4)
		%Tab = "<t f='����' m='0' n='16' b='1' h='1' gct='0xffff00ff' gcb='0xd9680dff'>";
	("Mini_TimerTriggerCtrl_HelpWnd_1_" @ %Index).setContent(%Tab @ %Txt @ "</t>");

	//��ȡ�󶨿ؼ�λ��
	%aimCtrlPos = %aimCtrl.GetPosition();

	//��ȡ�ؼ���Ҫ����λ��
	%NewPosX = GetWord(%aimCtrlPos,0) + GetWord(%OffsetXY,0);
	%NewPosY = GetWord(%aimCtrlPos,1) + GetWord(%OffsetXY,1);

	//���ÿؼ�λ��
	("Mini_TimerTriggerCtrl_HelpWnd_" @ %Index).setPosition(%NewPosX,%NewPosY);
	GameMainWndGui_Layer4.pushtoback("Mini_TimerTriggerCtrl_HelpWnd_" @ %Index);

	//�󶨿ؼ�
	//echo("%aimCtrl===" @ %aimCtrl @ "    %Index===" @ %Index @ "    " @ ("Mini_TimerTriggerCtrl_HelpWnd_" @ %Index).getId());
	%aimCtrl.addStickControl(("Mini_TimerTriggerCtrl_HelpWnd_" @ %Index).getId());

	//���ý��濪��
	if (%aimCtrl.IsVisible())
		("Mini_TimerTriggerCtrl_HelpWnd_" @ %Index).setVisible(1);

	//echo( "������λ��===" @( "Mini_TimerTriggerCtrl_HelpWnd_" @ %Index.getposition( ) ));
	//echo( "%NewPosX===" @ %NewPosX @ "%NewPosY====" @ %NewPosY );
	if (%Time > 0)
		$HelpDirectID[%Index] = Schedule(%Time,0,"closeHelpDirect1_4",%Index);
}
//�������������������������ɴ�������ء�����������������������������


//�������������������������ɴ����ؼ���ء�����������������������������
function GuiHelpDirectWndGui1(%i,%type)
{
	// OpenHelpDirectWnd( "AllBagWndGui", "4", "����ر�", 0, "250 -60", 1 );
	if (%type == 1) { %bitmap = "gameres/gui/images/GUIWindow81_1_064.png"; %Extent = "166 53"; %Extent1 = "100 40"; %position1 = "53 20"; }
	if (%type == 2) { %bitmap = "gameres/gui/images/GUIWindow81_1_065.png"; %Extent = "120 97"; %Extent1 = "100 40"; %position1 = "10 18"; }
	if (%type == 3) { %bitmap = "gameres/gui/images/GUIWindow81_1_066.png"; %Extent = "166 53"; %Extent1 = "100 40"; %position1 = "10 18"; }
	if (%type == 4) { %bitmap = "gameres/gui/images/GUIWindow81_1_067.png"; %Extent = "120 97"; %Extent1 = "100 40"; %position1 = "10 63"; }

	if (%type == 5) { %bitmap = "gameres/gui/images/GUIWindow81_1_068.png"; %Extent = "240 169"; %Extent1 = "180 90"; %position1 = "30 50"; %position2 = "80 130"; }//��ͼƬָ�� ��
	if (%type == 6) { %bitmap = "gameres/gui/images/GUIWindow81_1_069.png"; %Extent = "240 169"; %Extent1 = "180 90"; %position1 = "30 10"; %position2 = "80 90"; }//��ͼƬָ�� ��
	if (%type == 7) { %bitmap = "gameres/gui/images/GUIWindow81_1_070.png"; %Extent = "280 130"; %Extent1 = "180 90"; %position1 = "30 10"; %position2 = "80 90"; }//��ͼƬָ�� ��
	if (%type == 8) { %bitmap = "gameres/gui/images/GUIWindow81_1_071.png"; %Extent = "280 130"; %Extent1 = "180 90"; %position1 = "70 10"; %position2 = "120 90"; }//��ͼƬָ�� ��

	//echo( "%type===" @ %type @ "    %i====" @ %i );
	new GuiMoveBitmapCtrl("Mini_TimerTriggerCtrl_HelpWnd_" @ %i){
		canSaveDynamicFields = "0";
		Enabled = "1";
		isContainer = "0";
		Profile = "GuiModelessDialogProfile";
		HorizSizing = "left";
		VertSizing = "top";
		position = "200 200";
		Extent = %Extent;
		MinExtent = "8 2";
		canSave = "1";
		Visible = "0";
		mustPrerender = "0";
		tooltipWidth = "100";
		hovertime = "1000";
		alpha = "255";
		useFadeout = "0";
		bitmap = %bitmap;
		wrap = "0";
		MoveSpeed = "0";
		IsMove = "0";
		IsXDirection = "0";
		IsYDirection = "0";
		MoveType = "1";
		UpdateTime = "100";

		new GuiRichTextCtrl("Mini_TimerTriggerCtrl_HelpWnd_1_" @ %i)
		{
			hovertime = "1000";
			HorizSizing = "left";
			VertSizing = "bottom";
			position = %position1;
			Extent = %Extent1;
			Visible = "1";
		};
	};
	GameMainWndGui_Layer4.add("Mini_TimerTriggerCtrl_HelpWnd_" @ %i);
	if (%type > 4)
	{
		new GuiButtonCtrl("Mini_TimerTriggerCtrl_HelpWnd_2_" @ %i){
			canSaveDynamicFields = "0";
			Enabled = "1";
			isContainer = "0";
			Profile = "TimerTriggerCtrlHelpButtonProfile";
			position = %position2;
			Extent = "76 25";
			Visible = "1";
			HorizSizing = "right";
			VertSizing = "bottom";
			MinExtent = "8 2";
			canSave = "1";
			Visible = "1";
			mustPrerender = "0";
			Command = "closeHelpDirect1_4(" @ %i @ ");";
			hovertime = "1000";
			groupNum = "1";
			buttonType = "PushButton";
			useMouseEvents = "0";
			text = "��֪����";
			IsStateOn = "0";
		};
		("Mini_TimerTriggerCtrl_HelpWnd_" @ %i).add("Mini_TimerTriggerCtrl_HelpWnd_2_" @ %i);
	}
}
//OpenHelpDirectWnd( "MissionDialog2ClildWndGui", "6", "<t>ѡ��һ������</t><b/><t>ѡ��һ������</t><b/><t>ѡ��һ������</t><b/><t>ѡ��һ������</t>", 0, "180 300",10031);
//Mini_TimerTriggerCtrl_HelpWnd_1_10031.setcontent( "<t>���������������������������������������������������������������������������</t>" );
//Mini_TimerTriggerCtrl_HelpWnd_1_10031.setposition( 30, 70 );
//�������������������������ɴ����ؼ���ء�����������������������������


//�������������������������ɹر���ش���������������������������������
function closeHelpDirect1_4(%Index)
{
	//echo( "�����ɹر���ش��� === " @  %Index );
	if (!isobject(("Mini_TimerTriggerCtrl_HelpWnd_" @ %Index)))
		return;
	("Mini_TimerTriggerCtrl_HelpWnd_" @ %Index).setVisible(0);

	("Mini_TimerTriggerCtrl_HelpWnd_" @ %Index).delete();
}

function For_closeHelpDirect()
{
	//������������ѽ����񣬽���ӵ����б�
	%Player = GetPlayer();
	%AcceptCountNum = %Player.GetAcceptedMission();
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = %Player.GetMission(%i);
		if (("Mini_TimerTriggerCtrl_HelpWnd_" @ %Mid).isVisible() == 1)
		{
			closeHelpDirect1_4(%Mid);
			return;
		}
	}
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = %Player.GetMission(%i);
		//�Ƿ���ҪѰ·ָ��
		For_OpenHelpDirect(%Mid,GetMissionData(%Mid,$Mission_Data_Type),GetMissionData(%Mid,$Mission_Data_Map_Area));
	}
}
function For_OpenHelpDirect(%Mid,%Mission_Data_Type,%Mission_Data_Map_Area)
{
	if (%Mission_Data_Type == 1 &&  %Mission_Data_Map_Area  $= "810100100")
		OpenDouFuGan(%Mid);
}
//�������������������������ɹر���ش���������������������������������

//��������������������������ָ��������ݡ�����������������������������
//OpenDouFuGan_AllBagWndGui(102013293,0);
function OpenDouFuGan_AllBagWndGui(%Item,%Txt)
{
	//�������С��100
	if (strlen(%Item) <= 3)
		%ItemIndex = %Item;

	else //��ȡ����λ��
		%ItemIndex = GetItem_ToBagIndex(%Item);

	if (%ItemIndex == -1)
		return;

	%PositionX = 1;
	%PositionY = mceil(%ItemIndex/8 - 7)*44;

	ChatWnd_ShowMessage_scroll.setScrollPosition(%PositionX, %PositionY);
	//echo("������ָ���������===" @  %Item  @ "   " @ %txt);
	//if ( %ItemIndex < 40 ) ChooseTabItem( 0 );
	//else if ( %ItemIndex < 80 ){ ChooseTabItem( 1 ); %ItemIndex = %ItemIndex - 40; }
	//else { ChooseTabItem( 3 ); %ItemIndex = %ItemIndex - 80; }
	//echo( "%ItemIndex===" @ %ItemIndex );
	//���ð���λ����Ч
	TimeHintEquipInfo(%ItemIndex);

	//���ú���
	$SendCurUsingItemId[%Item] = 1;

	//������λ��
	%Hang = mfloor(%ItemIndex / 8);
	%Lie = %ItemIndex%8;
	if (%Hang >= 7)
		%Hang = 6;

	%x = -20 + (45 * %Lie);
	%y = -10 + (44 * %Hang);

	//echo("������ָ���������%ItemIndex=== " @ %ItemIndex);
	//echo("������ָ���������%Hang=== " @ %Hang);
	//echo("������ָ���������%Lie=== " @ %Lie);
	//echo("������ָ���������%x=== " @ %x);
	//echo("������ָ���������%y=== " @ %y);

	%Format_Black  = $Get_Dialog_GeShi[31200];	//��ɫ����

	if (%Txt == 0) %Txt = "�Ҽ����";
	else if (%Txt == 1) %Txt = "�������";
	else if (%Txt == 2) %Txt = "����ֽ�";
	else if (%Txt == 3) %Txt = "����϶�";
	else if (%Txt == 4) %Txt = "�Ҽ�װ������";
	else if (%Txt == 5) %Txt = "�Ҽ�ѧϰ����";

	OpenHelpDirectWnd("AllBagWndGui",2,%Txt,0,%x @ " " @ %y,0);
}
//��������������������������ָ��������ݡ�����������������������������
//35��ָ������
function SelectKLJMissionGuidanceGuiBtn(%Type)
{
	switch (%Type)
	{
		case 1://����
			CloseKLJMissionGuidanceGui();//�رս���
			findpath(411200001);//Ѱ��NPC
		case 2://��������
			CloseKLJMissionGuidanceGui();
			findpath(411200001);
		case 3://�����
			CloseKLJMissionGuidanceGui();
			findpath(410010144);

	}
}
function PengLaiDaoJing_ChuFa()//ʹ�õ���
{
	clearVocalStatus( );//��ϲɼ�
	%Text = "<t m ='0' f='����' n='14' c='0xdeeeedff' v='1'>�����򲻴����֮�»���Ҫѭ�򽥽�����������õ���һö</t>";
	Dialog_OnlyOK_COVER_Content.setContent( %Text );

	Dialog_OnlyOK_COVER_OKBTN.settext("ȷ��");
	Dialog_OnlyOK_COVER_OKBTN.command = "Dialog_OnlyOK_COVER.setVisible(0);OpenAllBag( );OpenDouFuGan_AllBagWndGui( 108021019, 0 );";
	Dialog_OnlyOK_COVER.setVisible(true);
}
function ZiDongZhanDou_ZhiYin()//�Զ�ս��
{
	FightAssistantBnt_skillshortcut.setStateOn(1);
	ShowHideFightAssistantSkillShortcutWnd();

	%Tab1 = "<t f='����_GB2312' m='0' n='16' c='0xffffffff' o='0x000000ff'>";//��ɫ����
	%Tab3 = "<t f='����_GB2312' m='0' n='16' c='0xff00ffff' o='0x000000ff'>";//��ɫ��ʾ
	%text = %Tab1 @ "					ʹ�ÿ����</t><b/>" @ %Tab3 @ "	      �� Z ��</t><b/>" @ %Tab1 @ "	�ɴ�ս�����ֽ���</t>";
	Dialog_OnlyOK.setVisible(true);
	Dialog_OnlyOK_Content.setContent(%text);
	Dialog_OnlyOK.OnReSize();
	Dialog_OnlyOK.SetOk("");
	Dialog_OnlyOK_OKBTN.command = "Dialog_OnlyOK.setvisible(false);OpenCloseFightAssistantWnd();OpenDouFuGan( 24 );";
}

function KLJRecommendatorySettingBase_2()
{
	if (GetPlayer().IsAcceptedMission(10341))
	{
		closeHelpDirect1_4(24);
		OpenDouFuGan(22);
	}
}
function KLJApplyFightAssistantBase_2()
{
	if (GetPlayer().IsAcceptedMission(10341) >= 1 && $MissionZhiYin[10341] != 1)
	{
		CloseFightAssistantWnd();
		closeHelpDirect1_4(22);
		OpenDouFuGan(3);
		$MissionZhiYin[10341] = 1;
	}
}


//���������������������һ������Ƽ�������ϡ���������������������������
function AddFightAssistantSkill()
{
	%Player = GetPlayer();
	%Classes = %Player.GetClasses(0);
	%Level = %Player.GetLevel();
	switch (%Classes)
	{
		case 1://սʿ
			%SkillID[0] = 21014; %SkillTime[0] = 13;//����Ϯ
			%SkillID[1] = 21010; %SkillTime[1] = 8;//ʨ�Ӻ�
			%SkillID[2] = 21004; %SkillTime[2] = 6;//����ն
			%SkillID[3] = 21002; %SkillTime[3] = 3;//����ն
			%SkillID[4] = 21003; %SkillTime[4] = 3;//�ѵ�ն
			%SkillID[5] = 21001; %SkillTime[5] = 2;//Ϯ���
		case 3://��ʦ
			%SkillID[0] = 23007; %SkillTime[0] = 55;//�����
			%SkillID[1] = 23003; %SkillTime[1] = 4;	//��ǽ��
			%SkillID[2] = 23010; %SkillTime[2] = 18;//�ǳ���
			%SkillID[3] = 23006; %SkillTime[3] = 5;	//�������
			%SkillID[4] = 23002; %SkillTime[4] = 3;	//������
			%SkillID[5] = 23001; %SkillTime[5] = 2;	//������
		case 4://��ʿ
			%SkillID[0] = 24007; %SkillTime[0] = 55;//��Ԫ����
			%SkillID[1] = 24013; %SkillTime[1] = 28;//��Ӣ�ͷ�
			%SkillID[2] = 24003; %SkillTime[2] = 6;//����
			%SkillID[3] = 24006; %SkillTime[3] = 4;//������
			%SkillID[4] = 24002; %SkillTime[4] = 3;//������
			%SkillID[5] = 24001; %SkillTime[5] = 2;//������
	}
	for (%i = 0; %i < 6; %i++)
	{
		("FightAssistantShortCut_Skill" @ %i).setContentId(0);
		("FightAssistantText_FireTime" @ %i).setText("");
	}
	%AssistantPos = 0;
	for (%i = 0; %i < 6; %i++)
	{
		if (%SkillID[%i] > 0 && %Player.GetSkillLevel(%SkillID[%i]) >= 1)
		{
			putout("�һ����漼�����%AssistantPos===" @ %AssistantPos);
			%Skill = %SkillID[%i] * 10000 + %Player.GetSkillLevel(%SkillID[%i]);
			("FightAssistantShortCut_Skill" @ %AssistantPos).setContentId(%Skill);
			("FightAssistantText_FireTime" @ %AssistantPos).setText(%SkillTime[%i]);
			%AssistantPos++;
		}
		Ai_SetSpell(%i,true,("FightAssistantText_FireTime" @ %i).getText(),("FightAssistantShortCut_Skill" @ %i).getContentId());
	}
}
//���������������������һ������Ƽ�������ϡ���������������������������


function OnOpenePKState(%mode)
{
	//echo("=================================������͵͵�л�PKģʽ==================================" @  %mode);
	%player = getPlayer();
	%MapAreaName=getCurrentZoneArea();
	switch (%mode)
	{
		case 0:
			if (%player.canSwitchPKState(0,1) != 1)
			{
				SetPKModeBtnState($g_OldSelectMode);
				return;
			}
			//PKStateDescribe.setText("��ƽ");
			//PK_bmp.setbitmap("gameres/gui/images/KLJ_PlayerIconPKHP.png");
			PKOpenButton_1.setProfile("TargetIconGuiWndProfileBtn_12");
			//PKStateDescribe.setColor(06,255,12);
			%player.setGEState(0);
			%player.setPKState(0);
		case 1:
			if (%player.canSwitchPKState(1,1) != 1)
			{
				SetPKModeBtnState($g_OldSelectMode);
				return;
			}
			//PKStateDescribe.setText("�ƶ�");
			//PK_bmp.setbitmap("gameres/gui/images/KLJ_PlayerIconPKSE.png");
			PKOpenButton_1.setProfile("TargetIconGuiWndProfileBtn_18");
			//PKStateDescribe.setColor(03,216,255);
			%player.setGEState(1);
		case 2:
			//��Ҫ�ж��Ƿ�ɹ��л���սģʽ�ĺ���
			if (%player.canSwitchPKState(1,1) != 1)
			{
				SetPKModeBtnState($g_OldSelectMode);
				return;
			}
			//PKStateDescribe.setText("�ƶ�");
			//PK_bmp.setbitmap("gameres/gui/images/KLJ_PlayerIconPKSL.png");
			PKOpenButton_1.setProfile("TargetIconGuiWndProfileBtn_17");
			//PKStateDescribe.setColor(255,0,0);
			%player.setPKState(1);
	}
	setPkCheckState(%mode+1);
}
