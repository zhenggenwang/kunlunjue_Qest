

//����������������������������ǿ����ء�������������������������������������
//��������������������������ɫʯ�ϳ���ء�����������������������������������
//��������������������������ɫʯ�ֽ���ء�����������������������������������
//������������������������������Ѩ��ء�����������������������������������
//����������������������������������ء�����������������������������������
//���������������������������������ء�����������������������������������
//��������������������������ɫ������ء�����������������������������������

//===================================================�ȸ���ʾ����������===================================================

if (!isObject(GuiTooltipsHoverProfile)) new GuiControlProfile(GuiTooltipsHoverProfile:GuiDefaultProfile)
{
	opaque = false;
	hasBitmapArray = true;
	fillColor = "3 3 7 179";
	border = "-1";
	bitmap = "gameres/gui/images/Hover";
};

//====================================================������ʱ���ȡ����=================================================

function ShowCaptivateTime(%hour,%minute)  //ƣ��ʱ��
{
	if (%minute!=0)
	{
		if (%hour==0)
		{
			$time = "�ۼ�����ʱ�䣺"@%minute @ "����";
			$time2 = "<b/><t>�ۼ�����ʱ�䣺"@%minute @ "����</t>";
		}
		else
		{
			$time = "�ۼ�����ʱ�䣺"@%hour @"Сʱ"@%minute @ "����";
			$time2 = "<b/><t>�ۼ�����ʱ�䣺"@%hour @"Сʱ"@%minute @ "����</t>";
		}
	}
	else
	{
		if (%hour!=0)
		{
			$time = "�ۼ�����ʱ�䣺"@%hour @"Сʱ";
			$time2 = "<b/><t>�ۼ�����ʱ�䣺"@%hour @"Сʱ</t>";
		}
		else
		{
			$time = "";
			$time2 = "";
		}
	}
	StartTooltip("Exp");
	StartTooltip("Captivate_Img");

}

//====================================================�����ͼ�ȸ���ʾ=================================================

function showViewMapInfo(%mapId)
{
	switch$(%mapId)
	{
			case "810010100":
				worldMapCtl.tooltipWidth = 210;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t c='0x00ff00ff'>���Ǻ�ƽ��ͼ</t><b/><t>����ȼ���16-21����36-42��</t></t>";

			case "810020100":
				worldMapCtl.tooltipWidth = 210;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t c='0x00ff00ff'>���Ǻ�ƽ��ͼ</t><b/><t>����ȼ���16-21����36-42��</t></t>";

			case "810040100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�׻�ʥ��</t><b/><t c='0x00ff00ff'>���ֵ�ͼ</t><b/><t>����ȼ���1-16��</t></t>";

			case "810050100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ʥ��</t><b/><t c='0x00ff00ff'>���ֵ�ͼ</t><b/><t>����ȼ���1-16��</t></t>";

			case "810060100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ʥ��</t><b/><t c='0x00ff00ff'>���ֵ�ͼ</t><b/><t>����ȼ���1-16��</t></t>";

			case "810070100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ȸʥ��</t><b/><t c='0x00ff00ff'>���ֵ�ͼ</t><b/><t>����ȼ���1-16��</t></t>";

			case "810080100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ԯʥ��</t><b/><t c='0x00ff00ff'>���ֵ�ͼ</t><b/><t>����ȼ���1-16��</t></t>";

			case "811010100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ƽԭ</t><b/><t c='0x00ff00ff'>Ұ��������ͼ</t><b/><t>����ȼ���21-34��</t></t>";

			case "811020100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t c='0x00ff00ff'>Ұ���ƽ��ͼ</t><b/><t>����ȼ���46-56��</t></t>";

			case "811030100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>̫ԭ</t><b/><t c='0xffff00ff'>Ұ��������ͼ</t><b/><t>����ȼ���56-66��</t></t>";

			case "811040100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ػ�</t><b/><t c='0xffff00ff'>Ұ��������ͼ</t><b/><t>����ȼ���66-76��</t></t>";

			case "811050100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ɶ�</t><b/><t c='0xffff00ff'>Ұ��������ͼ</t><b/><t>����ȼ���76-86��</t></t>";

			case "811060100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ͻ��</t><b/><t c='0xffff00ff'>Ұ��������ͼ</t><b/><t>����ȼ���86-96��</t></t>";

			case "811280100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ۺ�����</t><b/><t c='0xff0000ff'>�ع���ս��ͼ</t></t>";

			case "811290100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>¥���ų�</t><b/><t c='0xff0000ff'>�ع���ս��ͼ</t></t>";

			case "811300100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ʼ����</t><b/><t c='0xff0000ff'>�ع���ս��ͼ</t></t>";

			case "813010100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t c='0xffff00ff'>��ƽ��ͼ</t></t>";

			case "813020100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ʱ���Ѻ�</t><b/><t c='0xffff00ff'>��ƽ��ͼ</t></t>";

			case "813030100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ʹ�</t><b/><t c='0xffff00ff'>��ƽ��ͼ</t></t>";

			case "813040100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ʥ������</t><b/><t c='0xffff00ff'>��ƽ��ͼ</t></t>";

			case "813050100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ʮ��·����</t><b/><t c='0xffff00ff'>��ƽ��ͼ</t></t>";

			case "813060100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ɽ�̨</t><b/><t c='0xffff00ff'>��ƽ��ͼ</t></t>";

			case "814010100":
				worldMapCtl.tooltipWidth = 140;
				worldMapCtl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t c='0xffff00ff'>��ƽ��ͼ</t></t>";


			default:
				worldMapCtl.tooltip ="";

				worldMapCtl.tooltip ="";
				worldMapCtl.tooltipProfile = "GuiTooltipsHoverProfile";

	}
}

//====================================================UI�ؼ��ȸ���ʾ=================================================

function StartTooltip(%ctrl)
{
	%Player = GetPlayer();

	if (%Player==0) return;

	%Family  = %Player.GetFamily();
	%Classes = %Player.GetClasses(0);
	%lidao_or_zhili = %Player.GetClasses(0);

	if (%Family ==0){ %Family1 = "���ŷ�";  %Strength ="1.50";%Intellect ="1.26";%Pneuma ="2.83"; }
	else if (%Family ==1){ %Family1 = "�";%Strength ="1.57";%Intellect ="1.32";%Pneuma ="2.96"; }
	else if (%Family ==2){ %Family1 = "���ķ�";%Strength ="1.57";%Intellect ="1.32";%Pneuma ="2.96"; }
	else if (%Family ==3){ %Family1 = "�ܷ�";%Strength ="1.50";%Intellect ="1.26";%Pneuma ="2.83"; }
	else if (%Family ==4){ %Family1 = "�η�";%Strength ="1.57";%Intellect ="1.32";%Pneuma ="2.96"; }
	else if (%Family ==5){ %Family1 = "�";%Strength ="1.50";%Intellect ="1.26";%Pneuma ="2.83"; }
	else if (%Family ==6){ %Family1 = "���ķ�";%Strength ="1.50";%Intellect ="1.26";%Pneuma ="2.83"; }
	else if (%Family ==7){ %Family1 = "�ܷ�";%Strength ="1.57";%Intellect ="1.32";%Pneuma ="2.96"; }
	else if (%Family ==8){ %Family1 = "�η�";%Strength ="1.50";%Intellect ="1.26";%Pneuma ="2.83"; }

	if (%Classes==0){ %Classes1="����"; }
	else if (%Classes==1){ %Classes1="սʿ";%liliang ="1.57";%zhili =""; }
	else if (%Classes==2){ %Classes1="����";%liliang ="1.57";%zhili =""; }
	else if (%Classes==3){ %Classes1="��ʦ";%liliang ="";%zhili ="1.32"; }
	else if (%Classes==4){ %Classes1="��ʿ";%liliang ="";%zhili ="1.32"; }
	else if (%Classes==5){ %Classes1="����";%liliang ="1.57";%zhili =""; }


	if (%lidao_or_zhili == 1){ %lidao_or_zhili1 = "����";%gongjishanghai1 = "����";%wuxigongji1 = "��"; }
	else  if (%lidao_or_zhili == 2){ %lidao_or_zhili1 = "����";%gongjishanghai1 = "����";%wuxigongji1 = "��"; }
	else  if (%lidao_or_zhili == 3){ %lidao_or_zhili1 = "����";%gongjishanghai1 = "����";%wuxigongji1 = "��"; }
	else  if (%lidao_or_zhili == 4){ %lidao_or_zhili1 = "����";%gongjishanghai1 = "����";%wuxigongji1 = "��"; }
	else  if (%lidao_or_zhili == 5){ %lidao_or_zhili1 = "����";%gongjishanghai1 = "����";%wuxigongji1 = "��"; }

	%ctrl.tooltipProfile = "GuiTooltipsHoverProfile";

	switch$(%ctrl.GetName())
	{
		//===============================================================================��������Ϣ==========================================================================================================================
			case "KLPlayerInfoEquipShort_11":
				if ($MissionZhiYin[10032] == 3)
				{
					//�رն�����
					closeHelpDirect1_4(6);
					//����������
					OpenDouFuGan(7);
					$MissionZhiYin[10032] = 4;
				}
			case "Exp":

				%Exp1 = %Player.GetExp();        //��õ�ǰ����ű�����
				%Exp2 = %Player.GetLevelExp();   //��õ�ǰ�������޽ű�����

				if (%Player.GetLevel() < 60){ %size = 230; }
				else if ((%Player.GetLevel() >= 60) && (%Player.GetLevel() < 90)){ %size = 240; }
				else if ((%Player.GetLevel() >= 90) && (%Player.GetLevel() < 120)){ %size = 250; }

				//if(%Exp1 < %Exp2){%clue = "";}
				//else if((%Exp1>=%Exp2)&&(%Exp1< %Exp2*3)){%clue = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>(������)</t>";%clue2 ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�����ɫ��ť��,�ٵ��������ť��������</t>";}
				//else if(%Exp1==3*%Exp2){%clue = "<t c='0xff1200ff'>(���鴢�������)</t>";%clue2 ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�����ɫ��ť��,�ٵ��������ť��������</t>";%Color1 = "c='0xff0000ff'";}

				//if(%Player.GetLevel() >= 40)
				//	{
				//		%clue3 ="<b/><t>��ǰ���澭�����ֵ��</t><t "@ %Color1 @">"@ translateNumToString(3*%Exp2) @"</t>";
				//	}

				%ctrl.tooltipWidth = %size;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ﾭ��</t>   <t>"@ %clue @"</t><b/><t>����ֵ��"@ %Exp1 @"/"@ %Exp2 @"</t>"@ %clue3 @""@ $time2 @""@ %clue2 @"</t>";

			case "InputPlayerName_TextTip":
				%ctrl.tooltipWidth = 195;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>չ��/���ؽ�ɫ����ͷ����Ϣ</t></t>";

			case "BirdViewMap_PingBitMap"://pingֵ��ʾ 0 ���� 1 ��æ 2 ӵ�� 3���� 

				if ($PingSate == 0){ %Ping = "</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>����"; %width = "130"; }
				else if ($PingSate == 1){ %Ping = "</t><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��æ"; %Ping2 ="<b/><t>����ǰ�������е㲻�ȶ����ɳ������²�����</t><b/><t>1������������������������������������Ƿ�һ��</t><b/><t>2�������Լ����Ի�������Ƿ��������أ���ʹ���������������������</t>"; %width = "300"; }
				else if ($PingSate == 2){ %Ping = "</t><t gct='0xff7171ff' gcb='0xff3c00ff'>ӵ��";%Ping2 ="<b/><t>����ǰ�����粻�ȶ����ɳ������²�����</t><b/><t>1������������������������������������Ƿ�һ��</t><b/><t>2�������Լ����Ի�������Ƿ��������أ���ʹ���������������������</t><b/><t>3��������ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ϵͳ���á�</t><t>������Ϸ�����������������Ϸ������</t><b/><t>4������������</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>������ģʽ��</t><t>������Ϸ�������Ϸ����֡��</t>"; %width = "300"; }
				else if ($PingSate == 3){ %Ping = "</t><t c='0x8f8f8eff'>����"; %width = "130"; }

				%ctrl.tooltipWidth = %width;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������ʱ��"@ %Ping @"</t>"@ %Ping2 @"</t>";

			case "PlayerMinimizeButton":
				%ctrl.tooltipWidth = 195;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>չ��/���ؽ�ɫ����ͷ����Ϣ</t></t>";

			case "PlayerMaxmizeButton":
				%ctrl.tooltipWidth = 195;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>չ��/���ؽ�ɫ����ͷ����Ϣ</t></t>";

			case "HideBottomButtonBtn":
				%ctrl.tooltipWidth = 140;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>չ��/����ͨ�ò˵�</t></t>";

			case "InMapButton":
				if (BirdViewHideGui.IsVisible())
				{
					%ctrl.tooltipWidth = 130;
					%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����С��ͼģʽ</t></t>";
				}
				else
				{
					%ctrl.tooltipWidth = 130;
					%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����С��ͼģʽ</t></t>";
				}
			case "PlayerIconGui":
				%ctrl.tooltipWidth = 185;
				if (%Player.GetHP() >= %Player.GetMaxHP()*0.5){ %Color = ""; }
				else if (%Player.GetHP() < %Player.GetMaxHP()*0.5) { %Color = "c='0xff1200ff'"; }

				if (%Player.GetMP() >= %Player.GetMaxMP()*0.5){ %Color1 = ""; }
				else if (%Player.GetMP() < %Player.GetMaxMP()*0.5) { %Color1 = "c='0xff1200ff'"; }


				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Player.GetPlayerName() @ "</t><b/>" @
					"<t>" @ %Classes1 @ ",</t><t>" @ %Player.Getlevel() @ "��</t><b/>" @
					"<t>����[HP]��</t><t "@ %Color @">"@ %Player.GetHP() @"</t><t>/</t><t>"@ %Player.GetMaxHP() @"</t><b/>"@
					"<t>����[MP]��</t><t "@ %Color1 @">"@ %Player.GetMP() @"</t><t>/</t><t>"@ %Player.GetMaxMP() @"</t><b/>"; //@ 
				//"<t>����[PP]��</t><t "@ %Color1 @">"@ %Player.GetPP() @"</t><t>/</t><t>" @ %Player.GetMaxPP() @ "</t></t>";//ȥ��֮ǰ�Ļ���

				//�� ����ͷ�� ��ս����
			case "FightingPowerButton":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ս����</t><b/>" @
					"<t>ս�����������ۺ����������֣�ս���У�ս�������ߵ�һ�����ö������ӷ��������˺�����ӳɣ�˫��ս������Խ�󣬼ӳ�Խ�ߣ���߿ɻ�50%�ӳɡ�</t></t>";

			case "GrowAssistantTurnOnBnt":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ɳ�����</t><b/><t>�ɳ�����Ὣ��ǰ�����˽����Ϣ�Ƽ������������������У��ɳ����佫һֱ�������������ҡ�</t></t>";

				//		case "TheurgyUseWndOpenBtn":
				//			%ctrl.tooltipWidth = 260;
				//			%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>������׭���Ŵ�Զ�Ŵ�������ĸ�����ͨ������ɵ����������У���Щ������ͨ����ʹ���ĺպ�������������</t></t>";

			case "PetIconGui"://����ͷ��
				%ctrl.tooltipWidth = 170;

				%nSpawnedPetSlot = GetPlayer().GetSpawnedPetSlot();

				%sNewName = PetOperation_GetPetName(%nSpawnedPetSlot);

				%PetLv = PetOperation_GetPetLevel(%nSpawnedPetSlot);
				%nPetCurHp = PetOperation_GetPetHp(%nSpawnedPetSlot);
				%nPetMaxHp = PetOperation_GetPetMaxHp(%nSpawnedPetSlot);

				%nPetCurMp = PetOperation_GetPetMp(%nSpawnedPetSlot);
				%nPetMaxMp = PetOperation_GetPetMaxMp(%nSpawnedPetSlot);

				%nGeneration = PetOperation_GetPetGeneration(%nSpawnedPetSlot);
				if (%nGeneration == 1){ %PetGeneration = "һ��"; }
				else if (%nGeneration == 2){ %PetGeneration = "����"; }
				else if (%nGeneration == 3){ %PetGeneration = "����"; }

				%nStyle = PetOperation_GetPetStyle(%nSpawnedPetSlot);
				if (%nStyle ==1){ %PetStyle = "���ޱ���"; }
				else if (%nStyle ==2){ %PetStyle = "���챦��"; }
				else if (%nStyle ==3){ %PetStyle = "��������"; }
				else if (%nStyle ==4){ %PetStyle = "��������"; }

				if (%nPetCurHp >= %nPetMaxHp*0.5){ %Color = ""; }
				else if (%nPetCurHp < %nPetMaxHp*0.5) { %Color = "c='0xff1200ff'"; }

				if (%nPetCurMp >= %nPetMaxMp*0.5){ %Color1 = ""; }
				else if (%nPetCurMp < %nPetMaxMp*0.5) { %Color1 = "c='0xff1200ff'"; }


				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %sNewName @"</t><b/><t>"@ %PetLv @ "�� "@ %PetGeneration @ "" @ %PetStyle @ "</t><b/><t>����[HP]��</t><t "@ %Color @">"@ %nPetCurHp @"</t><t>/</t><t>"@ %nPetMaxHp @"</t></t>";

			case "PetAttackButton":
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='0' f='����' b='1'n='14'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������̬</t><b/><t>���޸��湥�����˵�ǰĿ��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����л���������̬</t></t>";

			case "PetDefendButton":
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip ="<t m='0' f='����' b='1'n='14'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������̬</t><b/><t>����ֻ��������������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����л���������̬</t></t>";

			case "DeferBitMap_Bnt1":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ԫ�� [��ƣ�PP]</t><b/><t>����û����������ܶ�������Ԫ��</t><b/><t>�û�״̬�½���������Ԫ�����ڵ�Ԫ��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ɲ鿴������Ϣ</t></t>";

			case "LiveUpButton_Open":
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='0' f='����' b='1'n='14'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>������</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>�ر�</t><t>�Զ���������</t></t>";

			case "LiveUpButton_Close":
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='0' f='����' b='1' n='14'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>������</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>����</t><t>�Զ���������</t></t>";

				/*
				case "DeferBitMap_Bnt2":
				%lingli = %player.getTrumpPoints();
				%lingliMax = %player.getTrumpMaxPoints();
				if(%lingli == 0){%Color1 = "gct='0xff7171ff' gcb='0xff3c00ff' ";}

				if(%lingliMax !=0 )
				{
				%linglitxt1 ="<t>";
				%linglitxt2 ="[</t><t "@ %Color1 @">"@%lingli @"</t><t>/"@ %lingliMax @"]</t>";
				}

				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %linglitxt1 @"�������� "@ %linglitxt2 @"</t><b/><t>���޿����Զ�ս����������������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>������Զ����Զ�ս������</t></t>";
				*/
				//		case "LeftOutButton":
				//			%nActiveSpiritSlot = %player.getActiveSpiritSlot();
				//
				//			%ctrl.tooltipWidth = 210;
				//			%txt="<b/><t>���������ӵ�и���ǿ����˺��Ϳ��ŵ�����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ɫ�ﵽ2��,�ɻ��ʥ�ػ���</t>";

				//			if($CurSelectModeId == 0){%KJJ ="��P��";}
				//			else if($CurSelectModeId == 1){%KJJ ="��Alt+P��";}
				//			else if($CurSelectModeId == 2){%KJJ ="��P��";}
				//			else if($CurSelectModeId == 3)
				//				{
				//				if(GetHotKey("��/�رս�ɫ�������") !$= "")
				//						%KJJ = "��" @ GetHotKey("��/�رս�ɫ�������") @ "��";
				//				}
				//			if (%nActiveSpiritSlot != -1)
				//				{
				//					%ctrl.tooltipWidth = 250;
				//					%txt="<b/><t>���������ӵ�и���ǿ����˺��Ϳ��ŵ�����</t>";
				//				}
				//
				//			%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ϣ "@ %KJJ @"</t>"@ %txt @"</t>";

			case "SeekLoadDialog_MinWnd"://Ѱ����ʾ
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ŀǰ����Ѱ����....</t><b/><t>ǰ��["@ $CurrentSeekLoadText1 @"]["@ $CurrentSeekLoadText2 @"]</t></t>";

				//===================================================================���޿����======================================================================
				/*
				case "LingQiProgressBarTip"://����ֵ������
				%lingli = %player.getTrumpPoints();
				%lingliMax = %player.getTrumpMaxPoints();

				if(%lingli == 0){%Color1 = "c='0xff0000ff'";}

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������ֵ��</t><t "@ %Color1 @">"@ %lingli @"</t><t>/"@ %lingliMax @"</t><b/><t>�Զ�ս���������������޵�����ֵ</t><b/><t>���ؾ��̳��ڿɹ���</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>������</t><t>��������ֵ</t></t>";


				case "FaBaoProgressBarTip"://���޾���
				%exp = %player.getTrumpExp();
				%expMax = %player.getTrumpMaxExp();

				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾���ֵ��</t><t>"@ %exp @"/"@ %expMax @"</t><b/><t>1��ÿ�ͷ�һ�����޼��ܼ�������һ�����޾���ֵ</t><b/><t>2�������޵ȼ��ﵽ6/11/16�������Զ�������Ƕ��</t><b/><t>3��ÿ����Ƕ�ۿ�����Ƕ1��������Ƭ������Ƕ��3��������Ƭʱ��������������������ṩ��������Լӳ�</t></t>";

				*/
				//===================================================================��������Ϣ======================================================================
			case "MagicCimeliaButtom":

				if ($CurSelectModeId == 0){ %KJJ ="��Z��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+Z��"; }
				else if ($CurSelectModeId == 2){ %KJJ ="��Z��"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�رս���") !$= "")
						%KJJ = "��" @ GetHotKey("��/�ر�ս�����ֽ���") @ "��";
				}

				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ս������ "@ %KJJ @"</t><b/><t>��ɫ3��װ�����޺�,�������Զ�ս������</t></t>";


			case "TeammateHideButton": //������С��ť
				if (isFile("gameres/gui/images/GUIWindow30_1_016.png")){ %Team1 = "<i s='gameres/gui/images/GUIWindow30_1_016.png' w='16' h='16'/>"; }
				else{ %Team11 = ""; }
				if (isFile("gameres/gui/images/GUIWindow30_1_017.png")){ %Team2 = "<i s='gameres/gui/images/GUIWindow30_1_017.png' w='16' h='16'/>"; }
				else{ %Team12 = ""; }

				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������չ������ͷ��</t><b/><t>����ͷ��ͼ��˵����</t><b/><t>"@ %Team1 @"</t><t>  �ӳ��ı�־</t><b/><t>"@ %Team2 @"</t><t>  ��Ա�ı�־</t></t>";


			case "TeammateIcon0_0":
				%Idd = TeammateIcon0_0.getplayer();
				%Id = ClientGetPlayer(%Idd);
				%Name = Cache_getPlayerName(%Idd);
				%LV = Cache_getPlayerLevel(%Idd);



				%Level = "<t>"@ %LV @ "��</t>";
				%TeamClasses1 = UI_GetJobName(spt_CacheGetPlayerJob(%Idd));


				%Xianlu = sptGetTeammateLineId(%Idd);
				%ditu = sptGetTeammateTriggerName(%Idd);
				if (%ditu $=""){ %ditu ="��ȡ��ͼ��Ϣ��..."; }

				if (sptGetTeammateZoneId(%Idd) > 9999)
				{
					%Xianlu ="����:";
				}
				else
				{
					%Xianlu ="";
				}

				/* 	%TeamRace = Cache_getPlayerFamily(%Idd);
				if(%TeamRace ==1){%TeamFamily1 = "<t>�,</t>";}
				else if(%TeamRace ==2){%TeamFamily1 = "<t>���ķ�,</t>";}
				else if(%TeamRace ==3){%TeamFamily1 = "<t>�ܷ�,</t>";}
				else if(%TeamRace ==4){%TeamFamily1 = "<t>�η�,</t>";}
				else if(%TeamRace ==5){%TeamFamily1 = "<t>�,</t>";}
				else if(%TeamRace ==6){%TeamFamily1 = "<t>���ķ�,</t>";}
				else if(%TeamRace ==7){%TeamFamily1 = "<t>�ܷ�,</t>";}
				else if(%TeamRace ==8){%TeamFamily1 = "<t>�η�,</t>";} */

				if (%id == 0)
				{
					%HP = "δ֪";
					%MaxHP = "";
					%MP = "δ֪";
					%MaxMP = "";
					%online = SptTeam_IsOnline(%Idd);
					if (%online==0){ %Team="<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>�ö�Ա������</t>"; %size = 170; }
					else if (%online==1)
					{
						%Team="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>"@  %Xianlu @""@ %ditu @"</t>";
						%size = 180;
					}
				}
				else
				{
					%HP = %Id.GetHP();
					%MaxHP = "/"@ %Id.GetMaxHP() @"";
					%MP = %Id.GetMP();
					%MaxMP = "/"@ %Id.GetMaxMP() @"";
					%size = 180;
					%TeamClasses = %Id.GetClasses(0);
					if (%TeamClasses==0){ %TeamClasses1=""; }


					if (%Id.GetHP() >= %Id.GetMaxHP()*0.5){ %Color = ""; }
					else if (%Id.GetHP() < %Id.GetMaxHP()*0.5) { %Color = "c='0xff1200ff'"; }

					if (%Id.GetMP() >= %Id.GetMaxMP()*0.5){ %Color1 = ""; }
					else if (%Id.GetMP() < %Id.GetMaxMP()*0.5) { %Color1 = "c='0xff1200ff'"; }
				}

				%ctrl.tooltipWidth = %size;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Name @"</t><b/>"@ %TeamFamily1 @"  "@ %Level @"  "@ %TeamClasses1 @"<b/><t>����(HP)��</t><t "@ %Color @">"@ %HP @"</t><t>"@ %MaxHP @"</t><b/><t>����(MP)��</t><t "@ %Color1 @">"@ %MP @"</t><t>"@ %MaxMP @"</t>"@ %Team @"</t>";

			case "TeammateIcon1_1":
				%Idd = TeammateIcon1_1.getplayer();
				%Id = ClientGetPlayer(%Idd);
				%Name = Cache_getPlayerName(%Idd);
				%LV = Cache_getPlayerLevel(%Idd);



				%Level = "<t>"@ %LV @ "��</t>";
				%TeamClasses1 = UI_GetJobName(spt_CacheGetPlayerJob(%Idd));

				%Xianlu = sptGetTeammateLineId(%Idd);
				%ditu = sptGetTeammateTriggerName(%Idd);
				if (%ditu $=""){ %ditu ="��ȡ��ͼ��Ϣ��..."; }

				if (sptGetTeammateZoneId(%Idd) > 9999)
				{
					%Xianlu ="����:";
				}
				else
				{
					%Xianlu ="";
				}

				/* 	%TeamRace = Cache_getPlayerFamily(%Idd);
				if(%TeamRace ==1){%TeamFamily1 = "<t>�,</t>";}
				else if(%TeamRace ==2){%TeamFamily1 = "<t>���ķ�,</t>";}
				else if(%TeamRace ==3){%TeamFamily1 = "<t>�ܷ�,</t>";}
				else if(%TeamRace ==4){%TeamFamily1 = "<t>�η�,</t>";}
				else if(%TeamRace ==5){%TeamFamily1 = "<t>�,</t>";}
				else if(%TeamRace ==6){%TeamFamily1 = "<t>���ķ�,</t>";}
				else if(%TeamRace ==7){%TeamFamily1 = "<t>�ܷ�,</t>";}
				else if(%TeamRace ==8){%TeamFamily1 = "<t>�η�,</t>";}*/

				if (%id == 0)
				{
					%HP = "δ֪";
					%MaxHP = "";
					%MP = "δ֪";
					%MaxMP = "";
					%online = SptTeam_IsOnline(%Idd);
					if (%online==0){ %Team="<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>�ö�Ա������</t>"; %size = 170; }
					else if (%online==1)
					{
						%Team="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>"@  %Xianlu @""@ %ditu @"</t>";
						%size = 180;
					}
				}
				else
				{
					%HP = %Id.GetHP();
					%MaxHP = "/"@ %Id.GetMaxHP() @"";
					%MP = %Id.GetMP();
					%MaxMP = "/"@ %Id.GetMaxMP() @"";
					%size = 180;
					%TeamClasses = %Id.GetClasses(0);
					if (%TeamClasses==0){ %TeamClasses1="����"; }


					if (%Id.GetHP() >= %Id.GetMaxHP()*0.5){ %Color = ""; }
					else if (%Id.GetHP() < %Id.GetMaxHP()*0.5) { %Color = "c='0xff1200ff'"; }

					if (%Id.GetMP() >= %Id.GetMaxMP()*0.5){ %Color1 = ""; }
					else if (%Id.GetMP() < %Id.GetMaxMP()*0.5) { %Color1 = "c='0xff1200ff'"; }
				}

				%ctrl.tooltipWidth = %size;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Name @"</t><b/>"@ %TeamFamily1 @"  "@ %Level @"  "@ %TeamClasses1@"<b/><t>����(HP)��</t><t "@ %Color @">"@ %HP @"</t><t>"@ %MaxHP @"</t><b/><t>����(MP)��</t><t "@ %Color1 @">"@ %MP @"</t><t>"@ %MaxMP @"</t>"@ %Team @"</t>";

			case "TeammateIcon2_2":
				%Idd = TeammateIcon2_2.getplayer();
				%Id = ClientGetPlayer(%Idd);
				%Name = Cache_getPlayerName(%Idd);
				%LV = Cache_getPlayerLevel(%Idd);



				%Level = "<t>"@ %LV @ "��</t>";
				%TeamClasses1 = UI_GetJobName(spt_CacheGetPlayerJob(%Idd));

				%Xianlu = sptGetTeammateLineId(%Idd);
				%ditu = sptGetTeammateTriggerName(%Idd);
				if (%ditu $=""){ %ditu ="��ȡ��ͼ��Ϣ��..."; }

				if (sptGetTeammateZoneId(%Idd) > 9999)
				{
					%Xianlu ="����:";
				}
				else
				{
					%Xianlu ="";
				}

				/* 	%TeamRace = Cache_getPlayerFamily(%Idd);
				if(%TeamRace ==1){%TeamFamily1 = "<t>�,</t>";}
				else if(%TeamRace ==2){%TeamFamily1 = "<t>���ķ�,</t>";}
				else if(%TeamRace ==3){%TeamFamily1 = "<t>�ܷ�,</t>";}
				else if(%TeamRace ==4){%TeamFamily1 = "<t>�η�,</t>";}
				else if(%TeamRace ==5){%TeamFamily1 = "<t>�,</t>";}
				else if(%TeamRace ==6){%TeamFamily1 = "<t>���ķ�,</t>";}
				else if(%TeamRace ==7){%TeamFamily1 = "<t>�ܷ�,</t>";}
				else if(%TeamRace ==8){%TeamFamily1 = "<t>�η�,</t>";}*/

				if (%id == 0)
				{
					%HP = "δ֪";
					%MaxHP = "";
					%MP = "δ֪";
					%MaxMP = "";
					%online = SptTeam_IsOnline(%Idd);
					if (%online==0){ %Team="<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>�ö�Ա������</t>"; %size = 170; }
					else if (%online==1)
					{
						%Team="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>"@  %Xianlu @""@ %ditu @"</t>";
						%size = 180;
					}
				}
				else
				{
					%HP = %Id.GetHP();
					%MaxHP = "/"@ %Id.GetMaxHP() @"";
					%MP = %Id.GetMP();
					%MaxMP = "/"@ %Id.GetMaxMP() @"";
					%size = 180;
					%TeamClasses = %Id.GetClasses(0);
					if (%TeamClasses==0){ %TeamClasses1="����"; }


					if (%Id.GetHP() >= %Id.GetMaxHP()*0.5){ %Color = ""; }
					else if (%Id.GetHP() < %Id.GetMaxHP()*0.5) { %Color = "c='0xff1200ff'"; }

					if (%Id.GetMP() >= %Id.GetMaxMP()*0.5){ %Color1 = ""; }
					else if (%Id.GetMP() < %Id.GetMaxMP()*0.5) { %Color1 = "c='0xff1200ff'"; }
				}

				%ctrl.tooltipWidth = %size;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Name @"</t><b/>"@ %TeamFamily1 @"  "@ %Level @"  "@ %TeamClasses1@"<b/><t>����(HP)��</t><t "@ %Color @">"@ %HP @"</t><t>"@ %MaxHP @"</t><b/><t>����(MP)��</t><t "@ %Color1 @">"@ %MP @"</t><t>"@ %MaxMP @"</t>"@ %Team @"</t>";

			case "TeammateIcon3_3":
				%Idd = TeammateIcon3_3.getplayer();
				%Id = ClientGetPlayer(%Idd);
				%Name = Cache_getPlayerName(%Idd);
				%LV = Cache_getPlayerLevel(%Idd);



				%Level = "<t>"@ %LV @ "��</t>";
				%TeamClasses1 = UI_GetJobName(spt_CacheGetPlayerJob(%Idd));

				%Xianlu = sptGetTeammateLineId(%Idd);
				%ditu = sptGetTeammateTriggerName(%Idd);
				if (%ditu $=""){ %ditu ="��ȡ��ͼ��Ϣ��..."; }

				if (sptGetTeammateZoneId(%Idd) > 9999)
				{
					%Xianlu ="����:";
				}
				else
				{
					%Xianlu ="";
				}

				/* 	%TeamRace = Cache_getPlayerFamily(%Idd);
				if(%TeamRace ==1){%TeamFamily1 = "<t>�,</t>";}
				else if(%TeamRace ==2){%TeamFamily1 = "<t>���ķ�,</t>";}
				else if(%TeamRace ==3){%TeamFamily1 = "<t>�ܷ�,</t>";}
				else if(%TeamRace ==4){%TeamFamily1 = "<t>�η�,</t>";}
				else if(%TeamRace ==5){%TeamFamily1 = "<t>�,</t>";}
				else if(%TeamRace ==6){%TeamFamily1 = "<t>���ķ�,</t>";}
				else if(%TeamRace ==7){%TeamFamily1 = "<t>�ܷ�,</t>";}
				else if(%TeamRace ==8){%TeamFamily1 = "<t>�η�,</t>";}*/

				if (%id == 0)
				{
					%HP = "δ֪";
					%MaxHP = "";
					%MP = "δ֪";
					%MaxMP = "";
					%online = SptTeam_IsOnline(%Idd);
					if (%online==0){ %Team="<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>�ö�Ա������</t>"; %size = 170; }
					else if (%online==1)
					{
						%Team="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>"@  %Xianlu @""@ %ditu @"</t>";
						%size = 180;
					}
				}
				else
				{
					%HP = %Id.GetHP();
					%MaxHP = "/"@ %Id.GetMaxHP() @"";
					%MP = %Id.GetMP();
					%MaxMP = "/"@ %Id.GetMaxMP() @"";
					%size = 180;
					%TeamClasses = %Id.GetClasses(0);
					if (%TeamClasses==0){ %TeamClasses1="����"; }


					if (%Id.GetHP() >= %Id.GetMaxHP()*0.5){ %Color = ""; }
					else if (%Id.GetHP() < %Id.GetMaxHP()*0.5) { %Color = "c='0xff1200ff'"; }

					if (%Id.GetMP() >= %Id.GetMaxMP()*0.5){ %Color1 = ""; }
					else if (%Id.GetMP() < %Id.GetMaxMP()*0.5) { %Color1 = "c='0xff1200ff'"; }
				}

				%ctrl.tooltipWidth = %size;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Name @"</t><b/>"@ %TeamFamily1 @"  "@ %Level @"  "@ %TeamClasses1@"<b/><t>����(HP)��</t><t "@ %Color @">"@ %HP @"</t><t>"@ %MaxHP @"</t><b/><t>����(MP)��</t><t "@ %Color1 @">"@ %MP @"</t><t>"@ %MaxMP @"</t>"@ %Team @"</t>";

			case "TeammateIcon4_4":
				%Idd = TeammateIcon4_4.getplayer();
				%Id = ClientGetPlayer(%Idd);
				%Name = Cache_getPlayerName(%Idd);
				%LV = Cache_getPlayerLevel(%Idd);

				%Tens = mFloor(%LV/10);
				%Num = %LV%10;

				%Level = "<t>"@ %LV @ "��</t>";
				%TeamClasses1 = UI_GetJobName(spt_CacheGetPlayerJob(%Idd));

				%Xianlu = sptGetTeammateLineId(%Idd);
				%ditu = sptGetTeammateTriggerName(%Idd);
				if (%ditu $=""){ %ditu ="��ȡ��ͼ��Ϣ��..."; }

				if (sptGetTeammateZoneId(%Idd) > 9999)
				{
					%Xianlu ="����:";
				}
				else
				{
					%Xianlu ="";
				}

				/*	%TeamRace = Cache_getPlayerFamily(%Idd);
				if(%TeamRace ==1){%TeamFamily1 = "<t>�,</t>";}
				else if(%TeamRace ==2){%TeamFamily1 = "<t>���ķ�,</t>";}
				else if(%TeamRace ==3){%TeamFamily1 = "<t>�ܷ�,</t>";}
				else if(%TeamRace ==4){%TeamFamily1 = "<t>�η�,</t>";}
				else if(%TeamRace ==5){%TeamFamily1 = "<t>�,</t>";}
				else if(%TeamRace ==6){%TeamFamily1 = "<t>���ķ�,</t>";}
				else if(%TeamRace ==7){%TeamFamily1 = "<t>�ܷ�,</t>";}
				else if(%TeamRace ==8){%TeamFamily1 = "<t>�η�,</t>";}*/

				if (%id == 0)
				{
					%HP = "δ֪";
					%MaxHP = "";
					%MP = "δ֪";
					%MaxMP = "";
					%online = SptTeam_IsOnline(%Idd);
					if (%online==0){ %Team="<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>�ö�Ա������</t>"; %size = 170; }
					else if (%online==1)
					{
						%Team="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>"@  %Xianlu @""@ %ditu @"</t>";
						%size = 180;
					}
				}
				else
				{
					%HP = %Id.GetHP();
					%MaxHP = "/"@ %Id.GetMaxHP() @"";
					%MP = %Id.GetMP();
					%MaxMP = "/"@ %Id.GetMaxMP() @"";
					%size = 180;
					%TeamClasses = %Id.GetClasses(0);
					if (%TeamClasses==0){ %TeamClasses1="����"; }


					if (%Id.GetHP() >= %Id.GetMaxHP()*0.5){ %Color = ""; }
					else if (%Id.GetHP() < %Id.GetMaxHP()*0.5) { %Color = "c='0xff1200ff'"; }

					if (%Id.GetMP() >= %Id.GetMaxMP()*0.5){ %Color1 = ""; }
					else if (%Id.GetMP() < %Id.GetMaxMP()*0.5) { %Color1 = "c='0xff1200ff'"; }
				}

				%ctrl.tooltipWidth = %size;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Name @"</t><b/>"@ %TeamFamily1 @"  "@ %Level @"  "@ %TeamClasses1@"<b/><t>����(HP)��</t><t "@ %Color @">"@ %HP @"</t><t>"@ %MaxHP @"</t><b/><t>����(MP)��</t><t "@ %Color1 @">"@ %MP @"</t><t>"@ %MaxMP @"</t>"@ %Team @"</t>";

			case "TeammateIcon5_5":
				%Idd = TeammateIcon5_5.getplayer();
				%Id = ClientGetPlayer(%Idd);
				%Name = Cache_getPlayerName(%Idd);
				%LV = Cache_getPlayerLevel(%Idd);



				%Level = "<t>"@ %LV @ "��</t>";
				%TeamClasses1 = UI_GetJobName(spt_CacheGetPlayerJob(%Idd));

				%Xianlu = sptGetTeammateLineId(%Idd);
				%ditu = sptGetTeammateTriggerName(%Idd);
				if (%ditu $=""){ %ditu ="��ȡ��ͼ��Ϣ��..."; }

				if (sptGetTeammateZoneId(%Idd) > 9999)
				{
					%Xianlu ="����:";
				}
				else
				{
					%Xianlu ="";
				}

				/*	%TeamRace = Cache_getPlayerFamily(%Idd);
				if(%TeamRace ==1){%TeamFamily1 = "<t>�,</t>";}
				else if(%TeamRace ==2){%TeamFamily1 = "<t>���ķ�,</t>";}
				else if(%TeamRace ==3){%TeamFamily1 = "<t>�ܷ�,</t>";}
				else if(%TeamRace ==4){%TeamFamily1 = "<t>�η�,</t>";}
				else if(%TeamRace ==5){%TeamFamily1 = "<t>�,</t>";}
				else if(%TeamRace ==6){%TeamFamily1 = "<t>���ķ�,</t>";}
				else if(%TeamRace ==7){%TeamFamily1 = "<t>�ܷ�,</t>";}
				else if(%TeamRace ==8){%TeamFamily1 = "<t>�η�,</t>";}*/

				if (%id == 0)
				{
					%HP = "δ֪";
					%MaxHP = "";
					%MP = "δ֪";
					%MaxMP = "";
					%online = SptTeam_IsOnline(%Idd);
					if (%online==0){ %Team="<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>�ö�Ա������</t>"; %size = 170; }
					else if (%online==1)
					{
						%Team="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>"@  %Xianlu @""@ %ditu @"</t>";
						%size = 180;
					}
				}
				else
				{
					%HP = %Id.GetHP();
					%MaxHP = "/"@ %Id.GetMaxHP() @"";
					%MP = %Id.GetMP();
					%MaxMP = "/"@ %Id.GetMaxMP() @"";
					%size = 180;
					%TeamClasses = %Id.GetClasses(0);
					if (%TeamClasses==0){ %TeamClasses1="����"; }


					if (%Id.GetHP() >= %Id.GetMaxHP()*0.5){ %Color = ""; }
					else if (%Id.GetHP() < %Id.GetMaxHP()*0.5) { %Color = "c='0xff1200ff'"; }

					if (%Id.GetMP() >= %Id.GetMaxMP()*0.5){ %Color1 = ""; }
					else if (%Id.GetMP() < %Id.GetMaxMP()*0.5) { %Color1 = "c='0xff1200ff'"; }
				}

				%ctrl.tooltipWidth = %size;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Name @"</t><b/>"@ %TeamFamily1 @"  "@ %Level @"  "@ %TeamClasses1@"<b/><t>����(HP)��</t><t "@ %Color @">"@ %HP @"</t><t>"@ %MaxHP @"</t><b/><t>����(MP)��</t><t "@ %Color1 @">"@ %MP @"</t><t>"@ %MaxMP @"</t>"@ %Team @"</t>";

			case "SelectChannelButton1"://�������ȫ��ҳ
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ȫ��Ƶ��</t><b/><t>�÷�ҳ��ʾ��Ϸ������Ƶ����������Ϣ</t><b/><t>ϵͳĬ�Ϸ�ҳ,�޷������Զ����޸�</t></t>";


			case "SelectChannelButton2"://������渽��ҳ
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ƶ��</t><b/><t>�÷�ҳ��ʾ����������Ϣ��������Ϣ</t><b/><t>ϵͳĬ�Ϸ�ҳ,�޷������Զ����޸�</t></t>";

			case "SelectChannelButton8"://��������Ŷ�ҳ
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����&�Ŷ�Ƶ��</t><b/><t>�÷�ҳ��ʾ������Ŷ�������Ϣ��������Ϣ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������</t><t>��ֱ�����Ŷ�Ƶ���ڷ���</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ�����</t><t>��ֱ���ڶ���Ƶ���ڷ���</t><b/><t>ϵͳĬ�Ϸ�ҳ,�޷������Զ����޸�</t></t>";

			case "SelectChannelButton3"://����������ҳ
				%ctrl.tooltipWidth = 260;
				if (%Family !=0)
				{
					%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ƶ��</t><b/><t>�÷�ҳ��ʾ��ҵ�������Ϣ��������Ϣ</t><b/><t>ϵͳĬ�Ϸ�ҳ,�޷������Զ����޸�</t></t>";
				}
				else
				{
					%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ƶ��</t><b/><t>�÷�ҳ��ʾ��Ҹ���������Ϣ</t><b/><t>ϵͳĬ�Ϸ�ҳ,�޷������Զ����޸�</t></t>";
				}




			case "SelectChannelButton4"://�������ҳ
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ƶ��</t><b/><t>�÷�ҳ��ʾ��Ҷ����������Ϣ��������Ϣ</t><b/><t>ϵͳĬ�Ϸ�ҳ,�޷������Զ����޸�</t></t>";

			case "SelectChannelButton5"://����������ҳ
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ƶ��</t><b/><t>�÷�ҳ��ʾ������������Ϣ��������Ϣ</t><b/><t>ϵͳĬ�Ϸ�ҳ,�޷������Զ����޸�</t></t>";

			case "SelectChannelButton6":	//�Զ���Ƶ��
				%ctrl.tooltipWidth = 290;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�Զ���Ƶ��</t><b/><t>�÷�ҳ���Զ���������ʾ������Ϣ</t><b/><t>����Ҳ�</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��������</t><t>�ɶ��Զ���Ƶ����������</t></t>";

			case "UpMaqnifyButton":	//������ʾ������
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ı���������߶�</t><b/><t>��������ı�������ʾ��������߶�</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ�����</t><t>����߶Ȼָ���Ĭ�ϸ߶�</t></t>";

			case "RightMaqnifyButton":	//������ʾ����䳤
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ı�����������</t><b/><t>��������ı�������ʾ���������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ�����</t><t>�����Ȼָ���Ĭ�Ͽ��</t></t>";

			case "ChatWndClearButton":	//������Ϣ���
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���������Ϣ</t><b/><t>������������ʾ������Ϣ</t></t>";

			case "ChatWndSettingButton":	//��������
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�Զ���Ƶ�������챳��͸��������</t></t>";

			case "ChatWndUnLockButton":	//��������
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������ʾ��������</t><b/><t>�����ť������ʾ������ȫ��͸</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ս��������ʹ��</t></t>";

			case "ChatWndLockButton":	//�������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������ʾ�������</t><b/><t>�����ť������ʾ����ȡ����ȫ��͸</t></t>";

			case "FaceButton":	//�������
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>����򿪱��鶯������</t></t>";

			case "InputButton":	//���췢��
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>����������������Ϣ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Enter��</t><t>������Ϣ</t></t>";


				//�̳��ȸ���ʾ

			case "MallWnd_ScorePVE":	//����
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>��ͨ����ȡ</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>Ԫ��</t><t>��øû���</t><b/><t>���ֿ�����</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ֵ����</t><t>����һ������</t></t>";


			case "MallWnd_ScoreBmp":	//����
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>��ͨ����ȡ</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>Ԫ��</t><t>��øû���</t><b/><t>���ֿ�����</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ֵ����</t><t>����һ������</t></t>";

			case "MallWnd_SilverBmp":	//��Ǯ
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ǯ</t><b/><t>��ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>���񡢻��������Ʒ������</t><t>�Ȼ�øý�Ǯ</t></t>";

			case "MallWnd_Copper":	//��Ǯ
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ǯ</t><b/><t>��ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>���񡢻��������Ʒ������</t><t>�Ȼ�øý�Ǯ</t></t>";

			case "MallWnd_GoldBmp":	//��Ǯ
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ǯ</t><b/><t>��ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>���񡢻��������Ʒ������</t><t>�Ȼ�øý�Ǯ</t></t>";
			case "MallWnd_Copper":	//��Ǯ
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ǯ</t><b/><t>��ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>���񡢻��������Ʒ������</t><t>�Ȼ�øý�Ǯ</t></t>";
			case "MallWnd_Silver":	//��Ǯ
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ǯ</t><b/><t>��ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>���񡢻��������Ʒ������</t><t>�Ȼ�øý�Ǯ</t></t>";
			case "MallWnd_Gold":	//��Ǯ
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ǯ</t><b/><t>��ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>���񡢻��������Ʒ������</t><t>�Ȼ�øý�Ǯ</t></t>";


			case "MallWnd_MoneyBmp":	//Ԫ��
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ԫ��</t><b/><t>��ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ֵ���������</t><t>��;����ø�Ԫ��</t></t>";

			case "MallWnd_YuanBao":	//Ԫ��
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ԫ��</t><b/><t>��ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ֵ���������</t><t>��;����ø�Ԫ��</t></t>";


				//ս�������ȸ�
			case "FightAssistantBnt_pickup_white_01":	//��ɫװ��
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ɫװ��</t><b/><t>������ɫƷ�ʵģ�</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>ͷ�������塢�ֲ����粿���������������Ų�����������������ָ����ǹ�����������������ȡ�ʱװ������</t><t>�ȵ�����Ʒ</t></t>";

			case "FightAssistantBnt_pickup_green_01":	//��ɫװ��
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ɫװ��</t><b/><t>������ɫƷ�ʵģ�</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>ͷ�������塢�ֲ����粿���������������Ų�����������������ָ����ǹ�����������������ȡ�ʱװ������</t><t>�ȵ�����Ʒ</t></t>";

			case "FightAssistantBnt_pickup_blue_01":	//��ɫװ��
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ɫװ��</t><b/><t>������ɫƷ�ʵģ�</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>ͷ�������塢�ֲ����粿���������������Ų�����������������ָ����ǹ�����������������ȡ�ʱװ������</t><t>�ȵ�����Ʒ</t></t>";

			case "FightAssistantBnt_pickup_purple_01":	//��ɫװ��
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ɫװ��</t><b/><t>������ɫ������Ʒ�ʵģ�</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>ͷ�������塢�ֲ����粿���������������Ų�����������������ָ����ǹ�����������������ȡ�ʱװ������</t><t>�ȵ�����Ʒ</t></t>";

			case "FightAssistantBnt_pickup_rare_01":	//ϡ����Ʒ
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ϡ��װ��</t><b/><t>������</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>ʩ�����ϡ�����ƺš��컯������񡢼������˷������Ӳ���</t><t>�ȵ�����Ʒ</t></t>";

			case "FightAssistantBnt_pickup_common_01":	//��ͨ��Ʒ
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ͨ��Ʒ</t><b/><t>������</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>�鼮����Ʒ�����</t><t>�ȵ�����Ʒ</t></t>";
			case "FightAssistantBnt_pickup_task_01"://������Ʒ
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ʒ</t><b/><t>������</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>����������Ʒ</t><t>�ȵ�����Ʒ</t></t>";
			case "FightAssistantBnt_pickup_money_01"://���
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���</t><b/><t>������</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>ɢ���ڵ��ϵĽ�Ǯ</t></t>";
			case "FightAssistantBnt_pickup_formula_01":	//�䷽
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�䷽</t><b/><t>������</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ͼֽ���÷�ͼֽ������ͼֽ������ͼֽ������ͼֽ�����ͼֽ</t><t>�ȵ�����Ʒ</t></t>";

			case "FightAssistantBnt_pickup_skillbook_01":	//������
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t>�����ģ�</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>սʿ�����顢��ʦ�����顢��ʿ�����顢������������</t><t>�ȵ�����Ʒ</t></t>";

			case "FightAssistantBnt_pickup_expendable_01":	//ҩ��ʳƷ
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ҩƷʳ��</t><b/><t>������</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>ҩƷ��ʳ��</t><t>�ȵ�����Ʒ</t></t>";

			case "FightAssistantBnt_pickup_material_01":	//��ʯ
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ʯ</t><b/><t>������</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ʯ��Ƭ���챦ʯ������ʯ���̱�ʯ</t><t>�ȵ�����Ʒ</t></t>";
			case "FightAssistantBnt_pickup_livingMeterial_01"://�������
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t><b/><t>������</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ҩ�����ũ���ľ�ġ����ࡢ���⡢���䡢���ϡ�ֽ��</t><t>�ȵ�����Ʒ</t></t>";

			case "FightAssistantBnt_pickup_other_01":	//����
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>������</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>���ߡ����������ᡢ���������޷�ӡ������ӡ</t><t>�ȵ�����Ʒ</t></t>";


				//==============================================================================================��ɫ�������================================================================
			case "KLJPlayerSuitbtn":
				StartTooltip_DTPlayerInfo_FashionLevel(%ctrl,$g_MySelfEquipLevel);
			case "KLJTargetInfoGuiSuitbtn":
				StartTooltip_DTPlayerInfo_FashionLevel(%ctrl,$g_TargetEquipLevel);
			case "KLPlayerInfo_FYZtext":
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ե</t><b/><t>��ԵӰ�������ȡ���ߵĸ��ʣ�װ������ĸ��ʣ�װ���������Գ��ֵĸ��ʣ��컯��ʯ�ϳɳɹ��ʡ�</t></t>";
			case "KLPlayerInfo_FYZ":
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ե</t><b/><t>��ԵӰ�������ȡ���ߵĸ��ʣ�װ������ĸ��ʣ�װ���������Գ��ֵĸ��ʣ��컯��ʯ�ϳɳɹ��ʡ�</t></t>";
			case "KLPlayerInfo_ZDLtext":
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ս����</t><b/><t>����װ�����ԡ����ܵȼ�������ȼ��ȼ�����Ľ�ɫ�������֡�</t></t>";
			case "KLPlayerInfo_ZDL":
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ս����</t><b/><t>����װ�����ԡ����ܵȼ�������ȼ��ȼ�����Ľ�ɫ�������֡�</t></t>";
			case "KLPlayerInfo_SLZtext":
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ƶ�ֵ</t><b/><t>���⹥�����������ɫ�ᵼ���ƶ�ֵ��ߣ��ƶ�ֵӰ����������ʱ�ı��ʡ�</t></t>";
			case "KLPlayerInfo_SLZ":
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ƶ�ֵ</t><b/><t>���⹥�����������ɫ�ᵼ���ƶ�ֵ��ߣ��ƶ�ֵӰ����������ʱ�ı��ʡ�</t></t>";
			case "KLPlayerInfo_ExpPercentControl":
				%Exp1 = %Player.GetExp();        //��õ�ǰ����ű�����
				%Exp2 = %Player.GetLevelExp();   //��õ�ǰ�������޽ű�����

				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ﾭ��</t><b/><t>����ֵ��"@ %Exp1 @"/"@ %Exp2 @"</t></t>";
			case "KLPlayerInfo_LL"://��������
				%Strength = GetPlayer().GetStrength();	//��ȡ��������ֵ
				switch (%Player.GetClasses(0))
				{
					case 1://սʿ
						%Text1 = mfloor(%Strength * 0.67);
						%Text2 = mfloor(%Strength * 1.33);
						%Text3 = mfloor(%Strength * 0);
						%Text4 = mfloor(%Strength * 0.39);
					case 2://�̿�
						%Text1 = mfloor(%Strength * 0.67);
						%Text2 = mfloor(%Strength * 1.33);
						%Text3 = mfloor(%Strength * 0.39);
						%Text4 = mfloor(%Strength * 0);
					case 3://��ʦ
						%Text1 = mfloor(%Strength * 0);
						%Text2 = mfloor(%Strength * 0);
						%Text3 = mfloor(%Strength * 0);
						%Text4 = mfloor(%Strength * 0);
					case 4://��ʿ
						%Text1 = mfloor(%Strength * 0);
						%Text2 = mfloor(%Strength * 0);
						%Text3 = mfloor(%Strength * 0);
						%Text4 = mfloor(%Strength * 0);
					case 5://����
						%Text1 = mfloor(%Strength * 0.67);
						%Text2 = mfloor(%Strength * 1.33);
						%Text3 = mfloor(%Strength * 0.39);
						%Text4 = mfloor(%Strength * 0);
				}
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�����Ի�������������ֵ��</t><b/><t>1��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��С������ +" @ %Text1 @ "</t><b/><t>2��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��������� +" @ %Text2 @ "</t><b/><t>3��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>���� +" @ %Text3 @ "</t><b/><t>4��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>������� +" @ %Text4 @ "</t></t>";

			case "KLPlayerInfo_Intellect"://����

				%Intellect = GetPlayer().GetIntellect(); //��ȡ��������ֵ
				switch (%Player.GetClasses(0))
				{
					case 1://սʿ
						%Text1 = mfloor(%Intellect * 0);
						%Text2 = mfloor(%Intellect * 0);
						%Text3 = mfloor(%Intellect * 0);
						%Text4 = mfloor(%Intellect * 0);
					case 2://�̿�
						%Text1 = mfloor(%Intellect * 0);
						%Text2 = mfloor(%Intellect * 0);
						%Text3 = mfloor(%Intellect * 0);
						%Text4 = mfloor(%Intellect * 0);
					case 3://��ʦ
						%Text1 = mfloor(%Intellect * 0.67);
						%Text2 = mfloor(%Intellect * 1.33);
						%Text3 = mfloor(%Intellect * 0.39);
						%Text4 = mfloor(%Intellect * 0);
					case 4://����
						%Text1 = mfloor(%Intellect * 0.67);
						%Text2 = mfloor(%Intellect * 1.33);
						%Text3 = mfloor(%Intellect * 0);
						%Text4 = mfloor(%Intellect * 0.52);
					case 5://����
						%Text1 = mfloor(%Intellect * 0);
						%Text2 = mfloor(%Intellect * 0);
						%Text3 = mfloor(%Intellect * 0);
						%Text4 = mfloor(%Intellect * 0);
				}

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�����Ի�������������ֵ��</t><b/><t>1��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��С�������� +" @ %Text1 @ "</t><b/><t>2��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��������� +" @ %Text2 @ "</t><b/><t>3��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>�����˺� +" @ %Text3 @ "</t><b/><t>4��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������� +" @ %Text4 @ "</t></t>";

			case "KLPlayerInfo_TL"://����
				%Stamina = GetPlayer().getStamina();	//��ȡ��������ֵ
				switch (%Player.GetClasses(0))
				{
					case 1://սʿ
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
					case 2://�̿�
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
					case 3://��ʦ
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
					case 4://����
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
					case 5://����
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
				}

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�����Ի�������������ֵ��</t><b/><t>1��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ֵ +" @ %Text1 @ "</t><b/><t>2��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>�����ָ� +" @ %Text2 @ "</t></t>";

			case "KLPlayerInfo_JS"://����
				%Mana = GetPlayer().GetMana();	//��ȡ������ֵ
				switch (%Player.GetClasses(0))
				{
					case 1://սʿ
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0);
						%Text4 = mfloor(%Mana * 0);
					case 2://�̿�
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0);
						%Text4 = mfloor(%Mana * 0);
					case 3://��ʦ
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0.54);
						%Text4 = mfloor(%Mana * 1.08);
					case 4://����
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0.54);
						%Text4 = mfloor(%Mana * 1.08);
					case 5://����
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0);
						%Text4 = mfloor(%Mana * 0);
				}

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�����Ի�������������ֵ��</t><b/><t>1��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������� +" @ %Text1 @ "</t><b/><t>2��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>�����ظ� +" @ %Text2 @ "</t><b/><t>3��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��С�������� +" @ %Text3 @ "</t><b/><t>4��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��������� +" @ %Text4 @ "</t></t>";


			case "KLPlayerInfo_LLtext"://��������
				%Strength = GetPlayer().GetStrength();	//��ȡ��������ֵ
				switch (%Player.GetClasses(0))
				{
					case 1://սʿ
						%Text1 = mfloor(%Strength * 0.67);
						%Text2 = mfloor(%Strength * 1.33);
						%Text3 = mfloor(%Strength * 0);
						%Text4 = mfloor(%Strength * 0.39);
					case 2://�̿�
						%Text1 = mfloor(%Strength * 0.67);
						%Text2 = mfloor(%Strength * 1.33);
						%Text3 = mfloor(%Strength * 0.39);
						%Text4 = mfloor(%Strength * 0);
					case 3://��ʦ
						%Text1 = mfloor(%Strength * 0);
						%Text2 = mfloor(%Strength * 0);
						%Text3 = mfloor(%Strength * 0);
						%Text4 = mfloor(%Strength * 0);
					case 4://��ʿ
						%Text1 = mfloor(%Strength * 0);
						%Text2 = mfloor(%Strength * 0);
						%Text3 = mfloor(%Strength * 0);
						%Text4 = mfloor(%Strength * 0);
					case 5://����
						%Text1 = mfloor(%Strength * 0.67);
						%Text2 = mfloor(%Strength * 1.33);
						%Text3 = mfloor(%Strength * 0.39);
						%Text4 = mfloor(%Strength * 0);
				}
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�����Ի�������������ֵ��</t><b/><t>1��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��С������ +" @ %Text1 @ "</t><b/><t>2��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��������� +" @ %Text2 @ "</t><b/><t>3��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>���� +" @ %Text3 @ "</t><b/><t>4��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>������� +" @ %Text4 @ "</t></t>";

			case "KLPlayerInfo_Intellecttext"://����

				%Intellect = GetPlayer().GetIntellect(); //��ȡ��������ֵ
				switch (%Player.GetClasses(0))
				{
					case 1://սʿ
						%Text1 = mfloor(%Intellect * 0);
						%Text2 = mfloor(%Intellect * 0);
						%Text3 = mfloor(%Intellect * 0);
						%Text4 = mfloor(%Intellect * 0);
					case 2://�̿�
						%Text1 = mfloor(%Intellect * 0);
						%Text2 = mfloor(%Intellect * 0);
						%Text3 = mfloor(%Intellect * 0);
						%Text4 = mfloor(%Intellect * 0);
					case 3://��ʦ
						%Text1 = mfloor(%Intellect * 0.67);
						%Text2 = mfloor(%Intellect * 1.33);
						%Text3 = mfloor(%Intellect * 0.39);
						%Text4 = mfloor(%Intellect * 0);
					case 4://����
						%Text1 = mfloor(%Intellect * 0.67);
						%Text2 = mfloor(%Intellect * 1.33);
						%Text3 = mfloor(%Intellect * 0);
						%Text4 = mfloor(%Intellect * 0.52);
					case 5://����
						%Text1 = mfloor(%Intellect * 0);
						%Text2 = mfloor(%Intellect * 0);
						%Text3 = mfloor(%Intellect * 0);
						%Text4 = mfloor(%Intellect * 0);
				}

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�����Ի�������������ֵ��</t><b/><t>1��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��С�������� +" @ %Text1 @ "</t><b/><t>2��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��������� +" @ %Text2 @ "</t><b/><t>3��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>�����˺� +" @ %Text3 @ "</t><b/><t>4��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������� +" @ %Text4 @ "</t></t>";

			case "KLPlayerInfo_TLtext"://����
				%Stamina = GetPlayer().getStamina();	//��ȡ��������ֵ
				switch (%Player.GetClasses(0))
				{
					case 1://սʿ
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
					case 2://�̿�
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
					case 3://��ʦ
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
					case 4://����
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
					case 5://����
						%Text1 = mfloor(%Stamina * 15);
						%Text2 = mfloor(%Stamina * 0.3);
				}

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�����Ի�������������ֵ��</t><b/><t>1��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ֵ +" @ %Text1 @ "</t><b/><t>2��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>�����ָ� +" @ %Text2 @ "</t></t>";

			case "KLPlayerInfo_JStext"://����
				%Mana = GetPlayer().GetMana();	//��ȡ������ֵ
				switch (%Player.GetClasses(0))
				{
					case 1://սʿ
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0);
						%Text4 = mfloor(%Mana * 0);
					case 2://�̿�
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0);
						%Text4 = mfloor(%Mana * 0);
					case 3://��ʦ
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0.54);
						%Text4 = mfloor(%Mana * 1.08);
					case 4://����
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0.54);
						%Text4 = mfloor(%Mana * 1.08);
					case 5://����
						%Text1 = mfloor(%Mana * 17.6);
						%Text2 = mfloor(%Mana * 0.04);
						%Text3 = mfloor(%Mana * 0);
						%Text4 = mfloor(%Mana * 0);
				}

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�����Ի�������������ֵ��</t><b/><t>1��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������� +" @ %Text1 @ "</t><b/><t>2��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>�����ظ� +" @ %Text2 @ "</t><b/><t>3��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��С�������� +" @ %Text3 @ "</t><b/><t>4��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��������� +" @ %Text4 @ "</t></t>";





			case "KLPlayerInfo_WLGJ"://������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t>Ӱ����������ɵĻ����˺�</t></t>";

			case "KLPlayerInfo_FSGJ"://��������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>Ӱ�취��������ɵĻ����˺�</t></t>";

			case "KLPlayerInfo_BJ"://����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>Ӱ�칥���г��ֱ����ĸ���</t></t>";

			case "KLPlayerInfo_BJSH"://�����˺�
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����˺�</t><b/><t>���ֱ���ʱ����˺��ı���</t></t>";

			case "KLPlayerInfo_HXYJ"://����һ��
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����һ��</t><b/><t>Ӱ�칥���г��ֻ���һ���ĸ���</t></t>";

			case "KLPlayerInfo_HXSH"://�����˺�
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����˺�</t><b/><t>���ֻ���һ��ʱ����˺��ı���</t></t>";

			case "KLPlayerInfo_WLMZ"://��������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>Ӱ���������ɹ�����Ŀ��ĸ���</t></t>";

			case "KLPlayerInfo_FSMZ"://��������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>Ӱ�취�������ɹ�����Ŀ��ĸ���</t></t>";


			case "KLPlayerInfo_SHFJ"://�����˺�
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����˺�</t><b/><t>���ӹ̶�ֵ�˺�</t></t>";


			case "KLPlayerInfo_WSWLFY"://�����������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����������</t><b/><t>����ʱ�����Է�һ�����������</t></t>";

			case "KLPlayerInfo_WSFSFY"://���ӷ�������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ӷ�������</t><b/><t>����ʱ�����Է�һ���ַ�������</t></t>";


			case "KLPlayerInfo_WLSHJS"://�����˺�����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����˺�����</t><b/><t>Ӱ��������ʱ�����˺�����</t></t>";

			case "KLPlayerInfo_FSSHJS"://�����˺�����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����˺�����</t><b/><t>Ӱ�취������ʱ�����˺�����</t></t>";

			case "KLPlayerInfo_WLFY"://�������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t><b/><t>�ܵ�������ʱ����һ�����˺�</t></t>";

			case "KLPlayerInfo_FSFY"://��������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�ܵ���������ʱ����һ�����˺�</t></t>";

			case "KLPlayerInfo_ZL"://����ֵ
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ֵ</t><b/><t>��ʿʩչ���Ƽ���ʱ����һ���ָ���</t></t>";

			case "KLPlayerInfo_BJJM"://��������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�����ܵ������ĸ���</t></t>";

			case "KLPlayerInfo_BSJM"://�����˺�����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����˺�����</t><b/><t>�����ܵ�����ʱ���˺�����</t></t>";

			case "KLPlayerInfo_WLSB"://��������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>Ӱ���ܵ�������ʱ���ܵĸ���</t></t>";

			case "KLPlayerInfo_FSSB"://��������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>Ӱ���ܵ���������ʱ���ܵĸ���</t></t>";

			case "KLPlayerInfo_WGSHJM"://�﹥�˺�����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�﹥�˺�����</t><b/><t>�ܵ������ܹ���ʱ�����˺�����</t></t>";

			case "KLPlayerInfo_FGSHJMJM"://�����˺�����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����˺�����</t><b/><t>�ܵ��������ܹ���ʱ�����˺�����</t></t>";

			case "KLPlayerInfo_SHJM"://�˺�����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�˺�����</t><b/><t>����̶�ֵ�˺�</t></t>";

			case "KLPlayerInfo_HXSHJM"://�����˺�����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����˺�����</t><b/><t>�����ܵ�����һ��ʱ���˺�����</t></t>";

			case "KLPlayerInfo_HXYJFY"://����һ������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����һ������</t><b/><t>�����ܵ�����һ���ĸ���</t></t>";

			case "KLPlayerInfo_XY"://����ֵ
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ֵ</t><b/><t>���ӹ���ʱ������߹����ĸ���</t></t>";

			case "KLPlayerInfo_YDSD"://�ƶ��ٶ�
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ƶ��ٶ�</t><b/><t>Ӱ�������״̬ʱ�ƶ��ٶ�</t></t>";

			case "KLPlayerInfo_ZQYDSD"://�����ƶ��ٶ�
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����ƶ��ٶ�</t><b/><t>Ӱ������״̬ʱ�ƶ��ٶ�</t></t>";

			case "KLPlayerInfo_SMZDHF"://�����Զ��ָ�
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����Զ��ָ�</t><b/><t>ÿ3���Զ��ָ�������ֵ</t></t>";

			case "KLPlayerInfo_FLZDHF"://�����Զ��ָ�
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����Զ��ָ�</t><b/><t>ÿ3���Զ��ָ��ķ���ֵ</t></t>";

			case "KLPlayerInfo_GJSD"://�����ٶ�
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����ٶ�</t><b/><t>Ӱ�칥��ʱ�ٶ�</t></t>";

			case "KLPlayerInfo_SFSD"://ʩ���ٶ�
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ʩ���ٶ�</t><b/><t>Ӱ�칥��ʱ�ٶ�</t></t>";

			case "KLPlayerInfo_XYQH"://ѣ��ǿ��
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ѣ��ǿ��</t><b/><t>���ܹ���ʱ����ѣ��Ŀ��ĳɹ���</t></t>";

			case "KLPlayerInfo_HSQH"://��˯ǿ��
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��˯ǿ��</t><b/><t>���ܹ���ʱ���ӻ�˯Ŀ��ĳɹ���</t></t>";

			case "KLPlayerInfo_CMQH"://��Ĭǿ��
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ĭǿ��</t><b/><t>���ܹ���ʱ���ӳ�ĬĿ��ĳɹ���</t></t>";

			case "KLPlayerInfo_XYKX"://ѣ�ο���
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ѣ�ο���</t><b/><t>�ܵ�ѣ�μ��ܹ���ʱ���ͱ�ѣ�εĸ���</t></t>";

			case "KLPlayerInfo_HSKX"://��˯����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��˯����</t><b/><t>�ܵ���˯���ܹ���ʱ���ͱ�ѣ�εĸ���</t></t>";

			case "KLPlayerInfo_CMKX"://��Ĭ����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ĭ����</t><b/><t>�ܵ���Ĭ���ܹ���ʱ���ͱ�ѣ�εĸ���</t></t>";




				//�����ѧϰ����

			case "LifeSkillStudyWndButtom_00"://����+����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' h='1' n='16' c='0xf3d300ff' o='0x010101ff'>�ɿ���+���켼��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�ɿ��ܣ�</t><t>��һ��������ܣ�����</t><t gct='0xff65feff' gcb='0xff65feff'>���ɹȡ���ɽѩ�������ɿߡ������Կ�</t><t>��Ұ�⡢�ع�Ѱ�ҵ��������ɿ���Բ�����</t><t gct='0xff65feff' gcb='0xff65feff'>ͭ���������󡢽��</t><t>��.</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���켼�ܣ�</t><t>��һ���������������������ܣ����������������</t><t gct='0xff65feff' gcb='0xff65feff'>40-100������ɫ����ɫ������</t><t>������������Ҫ��ͼֽ�Ͳ��Ͽ��Դӹ������ϵ��䣬�������еĿ�ʯ������Ҫ�ɿ����.</t><b/><t gct='0xf3d300ff' gcb='0xf3d300ff'>�ɿ�����Ŀ�ʯ�����������ز����ٵĲ��ϣ������������Ƿǳ��õ�һ�ִ������</t></t>";

			case "LifeSkillStudyWndButtom_10"://��ҩ+����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' h='1' n='16' c='0xf3d300ff' o='0x010101ff'>��ҩ����+��������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ҩ���ܣ�</t><t>��һ��������ܣ�����</t><t gct='0xff65feff' gcb='0xff65feff'>���ɹȡ�������</t><t>��Ұ���ҵ���ҩ��Ȼ����Խ���ҩ����</t><t gct='0xff65feff' gcb='0xff65feff'>����¯</t><t>�����Ƶ�ҩ���������̵껻ȡ��Ǯ.</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������ܣ�</t><t>��һ����������ҩƷ������ܣ���������</t><t gct='0xff65feff' gcb='0xff65feff'>�ָ��ࡢ״̬�ࡢ�������Լ�ʩ������</t><t>�ȵ�ҩ.</t><b/><t gct='0xf3d300ff' gcb='0xf3d300ff'>ҩ�������ô�������ȥ���Ƶ�ҩ����ҩ+�������������ܴ����Ҳ����������</t></t>";

			case "LifeSkillStudyWndButtom_20"://��ľ+����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' h='1' n='16' c='0xf3d300ff' o='0x010101ff'>��ľ����+��������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ľ���ܣ�</t><t>��һ��������ܣ�����</t><t gct='0xff65feff' gcb='0xff65feff'>���ɹȡ���ɽѩ����������</t><t>��Ұ���ͼ��Ѱ�ҵ�ľ�ģ��ɽ�ľ��������</t><t gct='0xff65feff' gcb='0xff65feff'>��ֽ����Ʒ��װ��</t><t>��������Ʒ.</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������ܣ�</t><t>��һ��������������Ʒ���װ������Ʒ�������</t><t gct='0xff65feff' gcb='0xff65feff'>��������������ָ</t><t>���ǻ�ȡ����װ���ı�ѧ����.</t><b/><t gct='0xf3d300ff' gcb='0xf3d300ff'>��ľ������Ȼ���Դ�������������ܣ��������������װ��Ʒ�ʣ����������Ҳ�Ǹ������ѡ��</t></t>";

			case "LifeSkillStudyWndButtom_01"://����+���
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' h='1' n='16' c='0xf3d300ff' o='0x010101ff'>���㼼��+��⿼���</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���㼼�ܣ�</t><t>��һ��������ܣ�����</t><t gct='0xff65feff' gcb='0xff65feff'>���ɹȡ�������</t><t>��Ұ���ͼ�ҵ���Ⱥ�����������������ȥ</t><t gct='0xff65feff' gcb='0xff65feff'>��⿶���NPC�̵�</t><t>������ʳ����߻�ȡ���.</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��⿼��ܣ�</t><t>��һ��������⿳���ζʳ��ļ��ܣ���⿼��ܿ�������</t><t gct='0xff65feff' gcb='0xff65feff'>�ָ��ࡢ״̬�ࡢ�������Լ�ʩ������</t><t>��ʳ��Ӵ˳�Ϊʳ����������.</t><b/><t gct='0xf3d300ff' gcb='0xf3d300ff'>���ʵ�����������ĳ��գ���ζ��ʳ��������������ģ����������ܵĴ���ѧϰ��ֱ����</t></t>";

			case "LifeSkillStudyWndButtom_11"://��ľ+����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' h='1' n='16' c='0xf3d300ff' o='0x010101ff'>��ľ����+���似��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ľ���ܣ�</t><t>��һ��������ܣ�����</t><t gct='0xff65feff' gcb='0xff65feff'>���ɹȡ���ɽѩ����������</t><t>��Ұ���ͼ��Ѱ�ҵ�ľ�ģ��ɽ�ľ��������</t><t gct='0xff65feff' gcb='0xff65feff'>��ֽ����Ʒ��װ��</t><t>��������Ʒ.</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���似�ܣ�</t><t>��һ������������������䣬���������</t><t gct='0xff65feff' gcb='0xff65feff'>����������������ս�����Լ�ʩ������</t><t>����Щ�����ṩ�˺ܺõĸ������ã�������������Ϸ����Ȥ.</t><b/><t gct='0xf3d300ff' gcb='0xf3d300ff'>��ľ������Ȼ���Դ�������������ܣ������������������ķ��䣬ѡ�����������Ҳ�Ǻ�������</t></t>";


			case "LifeSkillStudyWndButtom_21"://�÷�
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' h='1' n='16' c='0xf3d300ff' o='0x010101ff'>�÷�</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�÷켼�ܣ�</t><t>��һ���������ܣ�������������Ʒ������࣬������</t><t gct='0xff65feff' gcb='0xff65feff'>ͷ�����·����������粿���ֲ����������Ų�</t><t>�ߴ������װ��������������Ǭ����.����������Щ��Ʒ���õĲ��ϻ����϶���Ҫ</t><t gct='0xff65feff' gcb='0xff65feff'>�������</t><t>��Ҳ���������ܵĶ���֮��.</t><b/><t gct='0xf3d300ff' gcb='0xf3d300ff'>�������ܱȽ����⣬���ܲ���Ҫ�������ܵĴ���ѧϰ�����ǲ��ϻ�ȡ���Ѷ�Ҳ��΢������һ�㣬���������װ��Ʒ�ʵȼ����������Ҳ�Ǳر�����֮һ</t></t>";

				
			case "KLJAttackCityWndGui_Tips"://����ս�������
				%ctrl.tooltipWidth = 420;
				%ctrl.tooltip =
					"<t m='1' f='����' n='12'><t m='0' f='����' h='1' n='16' c='0xf3d300ff' o='0x010101ff'>����ս�������</t><b/>" @ 
					"<t gct='0x00ff00ff' gcb='0x2cffeeff'>�������</t><b/>" @ 
					"<t>1���ɰ��ɰ����������룬��������ѡ��</t>" @ "<t gct='0xff1200ff' gcb='0xff3c00ff'>7����</t><t>������һ�쾺�ۣ�����ͬʱ���۶���Ĺ��ǣ���</t><b/>" @ 
					"<t>2��</t>" @ "<t gct='0xff1200ff' gcb='0xff3c00ff'>2�������ϰ���</t>" @ "<t>���������ʸ�ռ����ɲ��ò������롣</t><b/>" @ 
					"<t>3�������Ͻ�</t>" @ "<t gct='0xff1200ff' gcb='0xff3c00ff'>����ӡ��1ö������10��</t>" @ "<t>��þ����ʸ񣬰�����ͨ��׷�ӽ��������ۡ�</t><b/>" @ 
					"<t>4�������ڹ���ǰһ���</t><t gct='0xff1200ff' gcb='0xff3c00ff'>����20��00</t><t>���㣬�۸��߻�ô��յĹ����ʸ�</t><b/>" @
					"<t>5������ʧ�ܵģ�����ӡ�²��践�����������ĵĽ�����ϵͳ</t><t gct='0xff1200ff' gcb='0xff3c00ff'>�۳�10��</t><t>��ʣ������ʼ�����ʽ������</t><b/>" @
					"<t>6�����۳ɹ��İ��������ʼ���ʽ֪ͨ�ð������XXXX��XX��XX�չ����ʸ�</t><b/>" @
					"<t gct='0x00ff00ff' gcb='0x2cffeeff'>ռ����ɽ�����</t><b/>" @ 
					"<t>1�����س����������ĵ���:</t><t gct='0xff65feff' gcb='0xff65feff'>��������</t><b/>" @
					"<t>2����ͬ����İ��ɳ�Ա�ɻ�ö�Ӧ�ĳƺŽ�����</t><b/>" @ 
					"<t>3��ռ������ڷ�ħ���ڵ�����NPC�����̵�����ʱ��</t><t gct='0xff65feff' gcb='0xff65feff'>��8���Ż�</t><t>������ͨ����Ľ���̵꣩��</t></t>";


			case "RuleDescribe_btn"://ȫ��ᱦ�������
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip =
					"<t m='1' f='����' n='12'><t m='0' f='����' h='1' n='16' c='0xf3d300ff' o='0x010101ff'>ȫ��ᱦ�������</t><b/>" @
					"<t gct='0x00ff00ff' gcb='0x2cffeeff'>�������</t><b/>" @
					"<t>1�������ڽ����еĶᱦ�����й�����Ʒ</t><b/>" @
					"<t>2������һ����Ʒ��Ҫ����һ��</t>" @ "<t gct='0xff65feff' gcb='0xff65feff'>�ᱦ��</t>" @ "<b/>" @
					"<t>3��ֻ�ܹ���һ�ݱ������һ�����Ʒ����</t><b/>" @
					"<t>4�����������ҵĶᱦ�в鿴�����еı�����Ϣ</t><b/>" @
					"<t gct='0x00ff00ff' gcb='0x2cffeeff'>��������</t><b/>" @
					"<t>1�������ν���ʱ���ѵ���ϵͳ������п�������</t><b/>" @
					"<t>2��ĳһ����������Ʒ����ȫ���������ñ���������ǰ��������</t><b/>" @
					"<t>3��������ķ������Ա����ĳ����ܷ������������񽱵ļ���</t><b/>" @
					"<t>4�����������ҵĶᱦ�в鿴�ѿ�������Ϣ</t><b/>";
				//ϵͳ��ť  
			case "OpenPlayerInfoButtom":

				if ($CurSelectModeId == 0){ %KJJ ="��C��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+C��"; }
				else if ($CurSelectModeId == 2){ %KJJ ="��C��"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�رս�ɫ���Խ���") !$= "")
						%KJJ = "��" @ GetHotKey("��/�رս�ɫ���Խ���") @ "��";
				}

				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ɫ���� "@ %KJJ @"</t><b/><t>��¼��ǰ��ɫװ��������ƺš�ʱװ��ս�����ԵȽ�ɫ��Ϣ</t></t>";

			case "ItemBagButton":

				if ($CurSelectModeId == 0){ %KJJ ="��B��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+B��"; }
				else if ($CurSelectModeId == 2){ %KJJ ="��B��"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�رձ�������") !$= "")
						%KJJ = "��" @ GetHotKey("��/�رձ�������") @ "��";
				}

				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���� "@ %KJJ @"</t><b/><t>��¼��ǰ��ɫЯ������Ʒ��Ϣ,���</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>����̯��</t><t>��ť�ɴ�̯λ��Ϣ</t></t>";

				//case "OpenPetInfoButtom":
				//
				//	if($CurSelectModeId == 0){%KJJ1 ="��X��";}
				//	else if($CurSelectModeId == 1){%KJJ1 ="��Alt+X��";}
				//	else if($CurSelectModeId == 2){%KJJ1 ="��X��";}
				//	else if($CurSelectModeId == 3)
				//			{
				//			if(GetHotKey("��/�ر���������") !$= "")
				//				%KJJ1 = "��" @ GetHotKey("��/�ر���������") @ "��";
				//
				//			}
				//
				//	%ctrl.tooltipWidth = 200;
				//	%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���� "@ %KJJ1 @"</t><b/><t>��ɫ��һ�γɹ��ֻغ󼴿ɻ�õ�һ������</t></t>";

				//	case "OpenTroopInfoButtom":
				//
				//		if($CurSelectModeId == 0){%KJJ ="��T��";}
				//		else if($CurSelectModeId == 1){%KJJ ="��Alt+T��";}
				//		else if($CurSelectModeId == 2){%KJJ ="��T��";}
				//		else if($CurSelectModeId == 3)
				//			{
				//				if(GetHotKey("��/�رն������") !$= "")
				//					%KJJ = "��" @ GetHotKey("��/�رն������") @ "��";
				//			}
				//
				//		%ctrl.tooltipWidth = 180;
				//		%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���� "@ %KJJ @"</t><b/><t>��¼��ǰ��ɫ�������Ϣ,�ɲ�ѯ������ҵ���Ϣ</t></t>";

			case "OpenSkillInfoButtom":

				if ($CurSelectModeId == 0){ %KJJ ="��K��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+K��"; }
				else if ($CurSelectModeId == 2){ %KJJ ="��K��"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�ر�ս�����ܽ���") !$= "")
						%KJJ = "��" @ GetHotKey("��/�ر�ս�����ܽ���") @ "��";
				}

				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���� "@ %KJJ @"</t><b/><t>��¼��ǰ��ɫ�����ս�����ܺ��������Ϣ</t></t>";

			case "OpenMissionInfoButtom":

				if ($CurSelectModeId == 0){ %KJJ ="��Q��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+Q��"; }
				else if ($CurSelectModeId == 2){ %KJJ ="��Q��"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�ر��������") !$= "")
						%KJJ = "��" @ GetHotKey("��/�ر��������") @ "��";
				}

				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���� "@ %KJJ @"</t><b/><t>��¼��ǰ��ɫ�ѽ�����Ϳɽ��������Ϣ</t></t>";

			case "OpenFriendInfoButtom":

				if ($CurSelectModeId == 0){ %KJJ ="��F��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+F��"; }
				else if ($CurSelectModeId == 2){ %KJJ ="��F��"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�ر�����ϵ����") !$= "")
						%KJJ = "��" @ GetHotKey("��/�ر�����ϵ����") @ "��";
				}

				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ϵ "@ %KJJ @"</t><b/><t>��¼��ǰ��ɫ���ѡ����顢���֡�����������Ϣ</t></t>";

				//		case "OpenHonorInfoButtom":

				//			if($CurSelectModeId == 0){%KJJ ="��K��";}
				//			else if($CurSelectModeId == 1){%KJJ ="��Alt+K��";}
				//			else if($CurSelectModeId == 2){%KJJ ="��K��";}
				//			else if($CurSelectModeId == 3)
				//				{
				//					if(GetHotKey("��/�ر���������") !$= "")
				//						%KJJ = "��" @ GetHotKey("��/�ر���������") @ "��";
				//				}

				//		%ctrl.tooltipWidth = 210;
				//		%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t>��¼��ɫ�ھ�������ս���е���Ϣ</t><b/><t c='0x00ff00ff'>������δ���ţ������ڴ�</t>";

				//case "PuddlerInfoButtom":
				//
				//		if($CurSelectModeId == 0){%KJJ ="��U��";}
				//		else if($CurSelectModeId == 1){%KJJ ="��Alt+U��";}
				//		else if($CurSelectModeId == 2){%KJJ ="";}
				//		else if($CurSelectModeId == 3)
				//			{
				//				if(GetHotKey("��/�ر���������") !$= "")
				//					%KJJ = "��" @ GetHotKey("��/�ر���������") @ "��";
				//			}
				//
				//		%ctrl.tooltipWidth = 220;
				//		%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���� "@ %KJJ @"</t><b/><t>��ؼ���Ĵ������Ԫ������Ԫ¯���������顢������Ƕ</t></t>";


			case "FuDiInfoButtom":

				if ($CurSelectModeId == 0){ %KJJ ="��G��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+G��"; }
				else if ($CurSelectModeId == 2){ %KJJ ="��G��"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�رա�") !$= "")
						%KJJ = "��" @ GetHotKey("��/�رհ��ɽ���") @ "��";
				}

				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���� "@ %KJJ @"</t><b/><t>��¼��ǰ��ɫ���ɵ���Ϣ</t></t>";

			case "OpenKLJSystemButton":

				if ($CurSelectModeId == 0){ %KJJ ="��O��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+O��"; }
				else if ($CurSelectModeId == 2){ %KJJ ="��O��"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�ر�ϵͳ���ý���") !$= "")
						%KJJ = "��" @ GetHotKey("��/�ر�ϵͳ���ý���") @ "��";
				}

				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ϵͳ "@ %KJJ @"</t><b/><t>�л���ɫ����</t><b/><t>�˳���Ϸ����</t><b/><t>��¼��Ϸ���ص�ϵͳ����Ϸ������Ϣ</t></t>";

			case "BirdShopWndBtn":
				if ($CurSelectModeId == 0){ %KJJ ="��V��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+V��"; }
				else if ($CurSelectModeId == 2){ %KJJ ="��V��"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�ر�Ԫ���̳�") !$= "")
						%KJJ = "��" @ GetHotKey("��/�ر�Ԫ���̳�") @ "��";
				}

				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ԫ���̳� "@ %KJJ @"</t><b/><t>��ʹ��Ԫ���ڴ˹�����ֳ�����Ʒ�͵���</t></t>";
			case "BirdSuiTangButton1":
				if ($CurSelectModeId == 0){ %KJJ ="��Y��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+Y��"; }
				else if ($CurSelectModeId == 2){ %KJJ ="��Y��"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�رջ��ȫ����") !$= "")
						%KJJ = "��" @ GetHotKey("��/�رջ��ȫ����") @ "��";
				}

				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ȫ "@ %KJJ @"</t><b/><t>���ڴ˲鿴���е��ճ����Ϣ</t></t>";
			case "BirdPrefButton":
				if (GetHotKey("��/�ر�����̵�") !$= "")
					%KJJ = "��" @ GetHotKey("��/�ر�����̵�") @ "��";
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����̵� "@ %KJJ @"</t><b/><t>���ڴ˹�����ִ����Żݵ���Ʒ�͵���</t><b/><t>ÿ��0��6��12��18��ϵͳ�Զ�ˢ�¸�����Ʒ�б�</t></t>";
			case "CornucopiaWndBtn":
				if (GetHotKey("��/�رվ۱���") !$= "")
					%KJJ = "��" @ GetHotKey("��/�رվ۱���") @ "��";
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�۱��� "@ %KJJ @"</t><b/><t>���ڴ˻�ô������</t></t>";
			case "BirdTranferWndBtn":
				if (GetHotKey("��/�ر��ӽ�ѡ��") !$= "")
					%KJJ = "��" @ GetHotKey("��/�ر��ӽ�ѡ��") @ "��";
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ӽ�ѡ�� "@ %KJJ @"</t><b/><t>���ڴ��л���ɫ�ӽ�</t></t>";
			case "ChargeWndBtnA":
				if (GetHotKey("��/�رճ�ֵ����") !$= "")
					%KJJ = "��" @ GetHotKey("��/�رճ�ֵ����") @ "��";
				%ctrl.tooltipWidth = 180;

				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ֵ���� "@ %KJJ @"</t><b/><t>���ڴ˳�ֵԪ������ȡԪ������ȡ��ֵ���</t></t>";
				//%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' gct='0xffff00ff' gcb='0xd9680dff'>��ֵ���� "@ %KJJ @"</t><b/><t>���ڴ˳�ֵԪ������ȡԪ������ȡ��ֵ���</t></t>";
			case "LingMaiWndBtn":
				if (GetHotKey("��/�ر�����ָ��") !$= "")
					%KJJ = "��" @ GetHotKey("��/�ر�����ָ��") @ "��";
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ָ�� "@ %KJJ @"</t><b/><t>���ڴ�ǰ��������������ȡ�����ɻ����ϡ����</t></t>";
			case "StrategyWndBtn":
				if (GetHotKey("��/�ر�����ָ��") !$= "")
					%KJJ = "��" @ GetHotKey("��/�ر�����ָ��") @ "��";
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ָ�� "@ %KJJ @"</t><b/><t>���ڴ˲鿴������Ϸ���Ժ�ָ��������ͬʱ���������Լ������������</t></t>";
			case "LingJiangWndBtn":
				if (GetHotKey("��/�ر��콱����") !$= "")
					%KJJ = "��" @ GetHotKey("��/�ر��콱����") @ "��";
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�콱���� "@ %KJJ @"</t><b/><t>���ڴ���ȡ����������񡢵ȼ������ý�����</t><b/><t>���ڴ˽���ÿ��ǩ��</t><b/><t>���ڴ˲鿴�ջ�Ծ���״��</t></t>";

				//==============================================================================================������ϵͳ���ܰ�ť�ȸ�================================================================
				/* дһ��ûд��
				case "OpenPlayerInfoButtom":	//��ɫ��Ϣ
				%ctrl.tooltipWidth = 90;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ɫ��C��</t></t>";

				case "OpenPlayerInfoButtom":	//������Ϣ
				%ctrl.tooltipWidth = 90;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Q��</t></t>";

				case "BottomControlWndGui3_1":	//������Ϣ
				%ctrl.tooltipWidth = 90;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����P��</t></t>";

				case "BottomControlWndGui3_2":	//���
				%ctrl.tooltipWidth = 90;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���</t></t>";

				case "BottomControlWndGui3_3":	//�³�
				%ctrl.tooltipWidth = 90;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�³�</t></t>";

				case "OpenPlayerInfoButtom":	//������Ϣ
				%ctrl.tooltipWidth = 90;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ϣ��Q��</t></t>";

				case "OpenPlayerInfoButtom":	//������Ϣ
				%ctrl.tooltipWidth = 90;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ϣ��Q��</t></t>";

				case "OpenPlayerInfoButtom":	//������Ϣ
				%ctrl.tooltipWidth = 120;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ϣ��Q��</t></t>";

				case "OpenPlayerInfoButtom":	//������Ϣ
				%ctrl.tooltipWidth = 120;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ϣ��Q��</t></t>";







				*/
				//==============================================================================================С��ͼ����ť================================================================

				//=========================С��ͼģʽ====================================

			case "BirdUniqueButton"://��ɫ�淨
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ɫ�淨</t><b/><t>����ɲ鿴���ؾ�����ɫ�淨����</t></t>";


			case "GrowAssistantTurnOnBnt1"://������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t>����ɲ鿴���ؾ��ĸ�������ָ��</t></t>";


			case "BirdBigMapButton"://��ͼ

				if ($CurSelectModeId == 0){ %KJJ1 ="��M��"; }
				else if ($CurSelectModeId == 1){ %KJJ1 ="��Alt+M��"; }
				else if ($CurSelectModeId == 2){ %KJJ1 =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�ر������ͼ") !$= "")
						%KJJ1 = "��" @ GetHotKey("��/�ر������ͼ") @ "��";
				}

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����ͼ "@ %KJJ1@"</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ҫ����Ѱ����</t><t>�������ͼ�Ҳ��е�ǰ��ͼ����Ҫ��Ѱ���б�,��굥��,��ɫ�Զ�ǰ��ָ���ĵص�</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>С��ͼ�����</t><t>�������С��ͼ�����Ѱ����λ��,��ɫ�Զ�ǰ��ָ���ĵص�</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����ͼ�����</t><t>������������ͼ�������Ѱ����λ��,��ɫ�Զ�ǰ��ָ���ĵص�</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ѱ����</t><t>�������ͼ�ϵ�����Ѱ���������������Ѱ��������,��ɫ�Զ�ǰ��ָ���ĵص�</t></t>";


			case "BirdShopButton":
				if ($CurSelectModeId == 0){ %KJJ ="��V��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+V��"; }
				else if ($CurSelectModeId == 2){ %KJJ ="��V��"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�ر�������") !$= "")
						%KJJ = "��" @ GetHotKey("��/�ر�������") @ "��";
				}
				%ctrl.tooltipWidth = 205;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t>���������пɲ��뾺�ģ�ͬʱ���ܼ���װ���ȵ���</t></t>";


			case "BirdLetterButton"://�ʼ�

				if ($CurSelectModeId == 0){ %KJJ ="��J��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+J��"; }
				else if ($CurSelectModeId == 2){ %KJJ =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�ر��ʼ�����") !$= "")
						%KJJ = "��" @ GetHotKey("��/�ر��ʼ�����") @ "��";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ʼ� "@ %KJJ @"</t><b/><t>���ڶԺ��ѵ����š���Ʒ�ķ��ͺͽ���</t></t>";


			case "BirdSuiTangButton"://���ȫ

				if ($CurSelectModeId == 0){ %KJJ ="��Y��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+Y��"; }
				else if ($CurSelectModeId == 2){ %KJJ =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�رջ��ȫ") !$= "")
						%KJJ = "��" @ GetHotKey("��/�رջ��ȫ") @ "��";
				}

				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ȫ "@ %KJJ @"</t><b/><t>��¼���ؾ����пɲμӵĻ��Ϣ</t></t>";

			case "BirdLockButton"://��ȫ��

				if ($CurSelectModeId == 0){ %KJJ =""; }
				else if ($CurSelectModeId == 1){ %KJJ =""; }
				else if ($CurSelectModeId == 2){ %KJJ =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�رհ�ȫ����") !$= "")
						%KJJ = "��" @ GetHotKey("��/�رհ�ȫ����") @ "��";
				}

				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ȫ���� "@ %KJJ @"</t><b/><t>���ö�������ɶ���Ϸ���а�ȫ������,����ȷ�����ĲƲ���ȫ,�ɶ���Ʒ�����ޡ���衢������е�������</t></t>";


			case "BirdGradeButton"://���а�

				if ($CurSelectModeId == 0){ %KJJ ="��B��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+B��"; }
				else if ($CurSelectModeId == 2){ %KJJ =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�ر����а����") !$= "")
						%KJJ = "��" @ GetHotKey("��/�ر����а����") @ "��";
				}
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���а�</t><b/><t>��¼���ؾ����ٵ����а�������Ϣ</t></t>";


			case "BirdTuiMapButton"://�ƹ�
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ƹ�</t><b/><t>ͨ��������Ѽ�����Ϸ�����ɻ�ø߶��</t></t>";

			case "BirdPresentButton"://ý�����
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���</t><b/><t>��ͨ������������ý��Ȼ�õ����к��ڴ˶һ���ʽ���</t></t>";

			case "BirdFuMapButton"://�������
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������ȡ</t><b/><t>�����ﵽһ�������󼴿��ڴ���ȡ����</t></t>";

			case "BirdViewAngleButton"://�ӽ�ѡ��
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ӽ�ѡ��</t><b/><t>2.5D��2.9D��3Dģʽ����ѡ��</t></t>";

			case "BirdKuaFuButton"://����
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ѿ��</t><b/><t>�������ύ��������Ѻ���ս���ߵĶ���</t></t>";

			case "BirdZhuanMapButton"://����תתת
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����תתת</t><b/><t>ÿ�ն�������ڴ˻�ó�ȡ�󽱵Ļ��ᣬǧ��Ҫ���</t></t>";

			case "BirdButtonNorthButton"://��ͼָ��
				%ctrl.tooltipWidth = 140;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ӽǻָ�Ĭ�Ϸ���</t></t>";
			case "BirdMapName"://��ͼ����
				%ctrl.tooltipWidth = 380;
				%ctrl.tooltip =
					"<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ͼΣ��˵��</t><b/>" @
					"<t c='0xffffffff'>��ȫ-�޷�����������ң�Ҳ�޷���������ҹ�����</t><b/>" @
					"<t c='0xffffffff'>��ͨ-�п��ܱ����⹥������С�Ľ������������ʵ���װ�������ߡ�</t><b/>" @
					"<t c='0xffffffff'>Σ��-�˵�ͼ�����⹥��������Σ�ա��������ʵ���װ�������ߡ�</t><b/>" @
					"<t c='0xffffffff'>����-�����������������κ�װ�������ߡ�</t><b/>" @
					"<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ͼ��ɫ˵��</t><b/>" @
					"<t c='0x46ff15ff'>��ɫ-��ͼΪ������ͼ,���ܹ������</t><b/>" @
					"<t c='0xffff00ff'>��ɫ-��ͼΪ��ս��ͼ,���Թ������  </t><b/>" @
					"<t c='0xff1200ff'>��ɫ-��ͼΪ�ƶ��ͼ,���Թ������,���������ƶ�ֵ</t></t>";
			case "BirdViewBitMap_point":
				%ctrl.tooltipWidth = 80;
				%Text = $NowPingValue @ "ms";
				%ctrl.tooltip ="<t m='0' f='����' h='1' v='1' n='14'><t c='0xffffffff'>" @ %Text @ "</t></t>";
				//=========================��ťģʽ=====================================
			case "BirdButtonUniqueButton"://��ɫ�淨
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ɫ�淨</t><b/><t>����ɲ鿴���ؾ�����ɫ�淨����</t></t>";


			case "BirdGrowAssistantTurnOnBnt"://������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t>����ɲ鿴���ؾ��ĸ�������ָ��</t></t>";


			case "BirdButtonSuiTangButton"://���ȫ

				if ($CurSelectModeId == 0){ %KJJ ="��Y��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+Y��"; }
				else if ($CurSelectModeId == 2){ %KJJ =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�رջ��ȫ") !$= "")
						%KJJ = "��" @ GetHotKey("��/�رջ��ȫ") @ "��";
				}

				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ȫ "@ %KJJ @"</t><b/><t>��¼���ؾ����пɲμӵĻ��Ϣ</t></t>";


			case "BirdButtonBigMapButton"://���ͼ

				if ($CurSelectModeId == 0){ %KJJ1 ="��M��"; }
				else if ($CurSelectModeId == 1){ %KJJ1 ="��Alt+M��"; }
				else if ($CurSelectModeId == 2){ %KJJ1 =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�ر������ͼ") !$= "")
						%KJJ1 = "��" @ GetHotKey("��/�ر������ͼ") @ "��";
				}

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����ͼ "@ %KJJ1@"</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ҫ����Ѱ����</t><t>�������ͼ�Ҳ��е�ǰ��ͼ����Ҫ��Ѱ���б�,��굥��,��ɫ�Զ�ǰ��ָ���ĵص�</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>С��ͼ�����</t><t>�������С��ͼ�����Ѱ����λ��,��ɫ�Զ�ǰ��ָ���ĵص�</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����ͼ�����</t><t>������������ͼ�������Ѱ����λ��,��ɫ�Զ�ǰ��ָ���ĵص�</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ѱ����</t><t>�������ͼ�ϵ�����Ѱ���������������Ѱ��������,��ɫ�Զ�ǰ��ָ���ĵص�</t></t>";
			case "BirdViewWordMapButton"://��ͼ
				if ($CurSelectModeId == 0){ %KJJ ="��M��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+M��"; }
				else if ($CurSelectModeId == 2){ %KJJ =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�رմ��ͼ") !$= "")
						%KJJ = "��" @ GetHotKey("��/�رմ��ͼ") @ "��";
				}

				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ͼ "@ %KJJ @"</t><b/><t>��ʾ��ǰ��ͼ��Ϣ</t></t>";
			case "BirdButtonMapName"://��ͼ����
				%ctrl.tooltipWidth = 315;
				%ctrl.tooltip =
					"<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ͼΣ��˵��</t><b/>" @
					"<t c='0xffffffff'>��ͨ-�����󲻵����κ���Ʒ</t><b/>" @
					"<t c='0xffffffff'>����-�����󲻵����κ���Ʒ</t><b/>" @
					"<t c='0xffffffff'>Σ��-�������м��ʵ�����ߡ�װ������Ǯ���ƶ�ֵԽ�ߣ����伸��Խ��</t><b/>" @
					"<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ͼ��ɫ˵��</t><b/>" @
					"<t c='0x46ff15ff'>��ɫ-��ͼΪ������ͼ,���ܽ��й������K</t><b/>" @
					"<t c='0xffff00ff'>��ɫ-��ͼΪ��ս��ͼ,���Թ������  </t><b/>" @
					"<t c='0xff1200ff'>��ɫ-��ͼΪ�ƶ��ͼ,���Թ������,���������ƶ�ֵ</t></t>";

			case "BirdButtonYouJianButton": //�ʼ�
				if ($CurSelectModeId == 0){ %KJJ ="��J��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+J��"; }
				else if ($CurSelectModeId == 2){ %KJJ =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�ر��ʼ�����") !$= "")
						%KJJ = "��" @ GetHotKey("��/�ر��ʼ�����") @ "��";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ʼ� "@ %KJJ @"</t><b/><t>���ڶԺ��ѵ����š���Ʒ�ķ��ͺͽ���</t></t>";


			case "BirdButtonLockButton"://��ȫ��

				if ($CurSelectModeId == 0){ %KJJ =""; }
				else if ($CurSelectModeId == 1){ %KJJ =""; }
				else if ($CurSelectModeId == 2){ %KJJ =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�رհ�ȫ����") !$= "")
						%KJJ = "��" @ GetHotKey("��/�رհ�ȫ����") @ "��";
				}

				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ȫ���� "@ %KJJ @"</t><b/><t>���ö�������ɶ���Ϸ���а�ȫ������,����ȷ�����ĲƲ���ȫ,�ɶ���Ʒ�����ޡ���衢������е�������</t></t>";


			case "BirdButtonPaiButton"://���а�

				if ($CurSelectModeId == 0){ %KJJ ="��B��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+B��"; }
				else if ($CurSelectModeId == 2){ %KJJ =""; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�ر����а����") !$= "")
						%KJJ = "��" @ GetHotKey("��/�ر����а����") @ "��";
				}
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���а�</t><b/><t>��¼���ؾ����ٵ����а�������Ϣ</t></t>";




			case "BirdButtonshopButton"://������
				if ($CurSelectModeId == 0){ %KJJ ="��V��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+V��"; }
				else if ($CurSelectModeId == 2){ %KJJ ="��V��"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�ر�������") !$= "")
						%KJJ = "��" @ GetHotKey("��/�ر�������") @ "��";
				}
				%ctrl.tooltipWidth = 205;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t>���������пɲ��뾺�ģ�ͬʱ���ܼ���װ���ȵ���</t></t>";






			case "BirdHelpMapButton"://������ť

				if ($CurSelectModeId == 0){ %KJJ ="��H��"; }
				else if ($CurSelectModeId == 1){ %KJJ ="��Alt+H��"; }
				else if ($CurSelectModeId == 2){ %KJJ ="��H��"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�رհ�������") !$= "")
						%KJJ = "��" @ GetHotKey("��/�رհ�������") @ "��";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ϸ����"@ %KJJ @"</t><b/><t>�����ؾ���ϵͳ��˵��,��������õ��˽���Ϸ</t></t>";


			case "BirdButtonTuiButton"://�ƹ�
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ƹ�</t><b/><t>ͨ��������Ѽ�����Ϸ�����ɻ�ø߶��</t></t>";

			case "BirdButtonPresentButton"://ý�����
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���</t><b/><t>��ͨ������������ý��Ȼ�õ����к��ڴ˶һ���ʽ���</t></t>";

			case "BirdButtonFuButton"://�������
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������ȡ</t><b/><t>�����ﵽһ�������󼴿��ڴ���ȡ����</t></t>";

			case "BirdButtonAngleButton"://�ӽ�ѡ��
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ӽ�ѡ��</t><b/><t>2.5D��2.9D��3Dģʽ����ѡ��</t></t>";

			case "BirdButtonKuaFuButton"://����
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ѿ��</t><b/><t>�������ύ��������Ѻ���ս���ߵĶ���</t></t>";

			case "BirdButtonZhuanButton"://����תתת
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����תתת</t><b/><t>ÿ�ն�������ڴ˻�ó�ȡ�󽱵Ļ��ᣬǧ��Ҫ���</t></t>";



				//=======================================================================================����������׷�ٲ���=================================================================================
			case "ShowTraceTreeButtton_Change":
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����׷��</t><b/><t>������¼��ǰ�ѽ������������,�͵�ǰ�ɽ��������Ϣ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����[����׷��]��չ��������������Ϣ׷�����</t></t>";

			case "ShowTraceTreeButtton_PartyChange":
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�׷��</t><b/><t>������¼��ǰ�����л򼴽����еĻ��Ϣ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����[�׷��]��չ�������ػ��Ϣ׷�����</t></t>";

			case "ShowTraceTreeButtton_Setting":
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����׷������</t><b/><t>������׷�ٴ��ڵĿ�ȡ����ȡ�͸���Ƚ����Զ�������</t></t>";

			case "ShowTraceTreeButtton_PartySetting":
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�׷������</t><b/><t>�Ի׷�ٴ��ڵĿ�ȡ����ȡ�͸���Ƚ����Զ�������</t></t>";

			case "ShowTraceTreeButtton_Close":
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ر�����׷��</t><b/><t>ͨ���������������׷�ٹ�ѡ��ť���Կ��ƽ���Ĵ򿪺͹ر�״̬</t></t>";

			case "ShowTraceTreeButtton_PartyClose":
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�رջ׷��</t><b/><t>ͨ�����ȫ�����л׷�ٹ�ѡ��ť���Կ��ƽ���Ĵ򿪺͹ر�״̬</t></t>";

			case "ShowTraceTreeButtton_Lock":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������״̬</t><b/><t>����׷���������״̬���ܱ��϶�����</t><b/><t>Ҫ�ı�ô�����ʾλ�ã�������ť���봰�ڽ���״̬</t></t>";

			case "ShowTraceTreeButtton_Unlock":
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ڽ���״̬</t><b/><t>���������϶�����׷�����,�����ܴ�͸����</t></t>";

			case "ShowTraceTreeButtton_Party_Lock":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������״̬</t><b/><t>�׷���������״̬���ܱ��϶�����</t><b/><t>Ҫ�ı�ô�����ʾλ�ã�������ť���봰�ڽ���״̬</t></t>";

			case "ShowTraceTreeButtton_Party_Unlock":
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ڽ���״̬</t><b/><t>���������϶��׷�����,�����ܴ�͸����</t></t>";

			case "SencondPwdTipWnd_lock":	//��ȫ��

				%state = %player.getSecondPWDState();
				if (%state == 0){ %lockNews1 ="��ȫ�����뻹δ����";%lockNews2 = "<b/><t c='0xF450CFff' >������밲ȫ����ҳ�����ö�������</t>"; }
				else if (%state == 2){ %lockNews1 ="��ȫ������״̬"; %lockNews2 = "<b/><t c='0xF450CFff' >�����ť�԰�ȫ������</t>"; }

				%ctrl.tooltipWidth = 290;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %lockNews1 @"</t><b/><t>ÿ�ν�ɫ���ߺ󶼴��ڰ�ȫ����״̬,��״̬���޷����н��ס�����������װ���Ȳ���</t>"@ %lockNews2 @"</t>";

			case "SencondPwdTipWnd_Unlock":	//��ȫ��
				%ctrl.tooltipWidth = 290;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ȫ����״̬</t><b/><t>ÿ�ν�ɫ���ߺ󶼴��ڰ�ȫ����״̬,��״̬���޷����н��ס�����������װ���Ȳ���</t><b/><t c='0x8f8f8eff' >*���������ڰ�ȫ�����п�ǿ�н������*</t><b/><t c='0x46ff15ff' >������������������԰�ȫ�����н���</t></t>";

				/*case "PKCloseButton":	//��ƽ��ť
				if(isFile("gameres/data/icon/help/PK1.png")){%PK1 = "<i s='gameres/data/icon/help/PK1.png' w='16' h='16'/>";}else{%PK1 = "";}
				if(isFile("gameres/data/icon/help/PK2.png")){%PK2 = "<i s='gameres/data/icon/help/PK2.png' w='16' h='16'/>";}else{%PK2 = "";}
				if(isFile("gameres/data/icon/help/PK3.png")){%PK3 = "<i s='gameres/data/icon/help/PK3.png' w='16' h='16'/>";}else{%PK3 = "";}
				if(isFile("gameres/data/icon/help/PK4.png")){%PK4 = "<i s='gameres/data/icon/help/PK4.png' w='16' h='16'/>";}else{%PK4 = "";}

				if(GetPkValue()>0)
				{
				%txt1 = "<b/><t>����</t><t c='0x00ff00ff' >����������</t><t>��</t><t c='0x00ff00ff'>��������˾</t><t>��ʦ�¼����ƶ�ֵ</t>";
				%txt2 = "<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>�����ͷ�˵����</t><b/><t>0���ƶ�ֵ��4  ���������,װ�������10%�;�ֵ</t><b/><t>   �ƶ�ֵ��4  ���������,װ�������20%�;�ֵ</t>";
				%Width ="340";
				}
				else
				{
				%Width ="280";
				}
				%ctrl.tooltipWidth = %Width;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ƽģʽ</t><b/><t>��ǰģʽ�޷������������,���ƶ�ģʽ����ҹ������ԺϷ��ķ���</t><b/><t gct='0xff1200ff' gcb='0xff3c00ff'>��ǰ�ƶ�ֵ��"@ GetPkValue() @"</t>"@ %txt1 @"<b/><t>ͷ��ͼ��˵����</t><b/><t>   �ƶ�ֵ= 0  ��ͼ����ʾ</t><b/><t>0���ƶ�ֵ��4  </t>"@ %PK1 @"<t>����״̬</t><b/><t>4���ƶ�ֵ��6  </t>"@ %PK2 @"<t>����״̬</t><b/><t>6���ƶ�ֵ��9  </t>"@ %PK3 @"<t>����״̬I</t><b/><t>   �ƶ�ֵ��9  </t>"@ %PK4 @"<t>����״̬II</t>"@ %txt2 @"<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����л����ƶ�ģʽ</t></t>";
				*/
				/*case "PKOpenButton":	//�ƶ�ť
				if(isFile("gameres/data/icon/help/PK1.png")){%PK1 = "<i s='gameres/data/icon/help/PK1.png' w='16' h='16'/>";}else{%PK1 = "";}
				if(isFile("gameres/data/icon/help/PK2.png")){%PK2 = "<i s='gameres/data/icon/help/PK2.png' w='16' h='16'/>";}else{%PK2 = "";}
				if(isFile("gameres/data/icon/help/PK3.png")){%PK3 = "<i s='gameres/data/icon/help/PK3.png' w='16' h='16'/>";}else{%PK3 = "";}
				if(isFile("gameres/data/icon/help/PK4.png")){%PK4 = "<i s='gameres/data/icon/help/PK4.png' w='16' h='16'/>";}else{%PK4 = "";}

				if(GetPkValue()>0)
				{
				%txt1 = "<b/><t>����</t><t c='0x00ff00ff' >������Ϣ</t><t>��</t><t c='0x00ff00ff'>������Ϣ����</t><t>�е���ƶ�ֵ�Ե������ť�������ƶ�ֵ</t>";
				%txt2 = "";
				%Width ="340";
				}
				else
				{
				%Width ="290";
				}

				%PKkaiguan1 = %player.getForceState();//����״̬
				%PKkaiguan2 = %player.getWarState();//��ս״̬
				%PKkaiguan3 = %player.getPKState();//�ƶ�״̬

				if			(%PKkaiguan1 == 1){%PKtext1 = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ģʽ</t>";
				%moshishuoming1 = "<t>1�����ڷǺ�ƽ�����ڹ����ж��������,�һ��ܵ���������Ҳ��������ƶ�ֵ</t><b/><t>2������������ȼ�������15������ҿɻ�ù�ѫֵ</t><b/><t gct='0xff1200ff' gcb='0xff3c00ff'>��ǰ�ƶ�ֵ��"@ GetPkValue() @"</t>";
				%moshishuoming = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>�����ѡ���л�PKģʽ</t><b/><t c='0x8f8f8eff'>*���ڷ�ս��״̬�³���5���Ӳ����л�����ƽģʽ</t>";
				}

				else if(%PKkaiguan2 == 1){%PKtext1 = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ģʽ</t><b/><t>���ڷǺ�ƽ�����ڹ���������ս�еĵж����,�һ��ܰ�����ս�еĵж���Ҳ��������ƶ�ֵ</t>";
				%moshishuoming1 = "<t gct='0xff1200ff' gcb='0xff3c00ff'>��ǰ�ƶ�ֵ��"@ GetPkValue() @"</t><b/><t>ͷ��ͼ��˵����</t><b/><t>   �ƶ�ֵ= 0  ��ͼ����ʾ</t><b/><t>0���ƶ�ֵ��4  </t>"@ %PK1 @"<t>����״̬</t><b/><t>4���ƶ�ֵ��6  </t>"@ %PK2 @"<t>����״̬</t><b/><t>6���ƶ�ֵ��9  </t>"@ %PK3 @"<t>����״̬I</t><b/><t>   �ƶ�ֵ��9  </t>"@ %PK4 @"<t>����״̬II</t>";
				%moshishuoming = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>�����ѡ���л�PKģʽ</t><b/><t c='0x8f8f8eff'>*���ڷ�ս��״̬�³���5���Ӳ����л�����ƽģʽ</t>";
				}

				else if(%PKkaiguan3 == 1){%PKtext1 = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ƶ�ģʽ</t><b/><t>���ڷǺ�ƽ�����ڹ����κ����,�һ��������ƶ�ģʽ����Ҳ��������ƶ�ֵ</t>";
				%moshishuoming1 = "<t gct='0xff1200ff' gcb='0xff3c00ff'>��ǰ�ƶ�ֵ��"@ GetPkValue() @"</t><b/><t>ͷ��ͼ��˵����</t><b/><t>   �ƶ�ֵ= 0  ��ͼ����ʾ</t><b/><t>0���ƶ�ֵ��4  </t>"@ %PK1 @"<t>����״̬</t><b/><t>4���ƶ�ֵ��6  </t>"@ %PK2 @"<t>����״̬</t><b/><t>6���ƶ�ֵ��9  </t>"@ %PK3 @"<t>����״̬I</t><b/><t>   �ƶ�ֵ��9  </t>"@ %PK4 @"<t>����״̬II</t>";
				%moshishuoming = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>�����ѡ���л�PKģʽ</t><b/><t c='0x8f8f8eff'>*���ڷ�ս��״̬�³���5���Ӳ����л�����ƽģʽ</t>";
				}

				else   {%PKtext1 = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ƽģʽ</t><b/><t>��ǰģʽ�޷������������,���ƶ�ģʽ����ҹ������ԺϷ��ķ���</t>";
				%moshishuoming = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>�����ѡ���л�PKģʽ</t>";
				%moshishuoming1 = "<t gct='0xff1200ff' gcb='0xff3c00ff'>��ǰ�ƶ�ֵ��"@ GetPkValue() @"</t><b/><t>ͷ��ͼ��˵����</t><b/><t>   �ƶ�ֵ= 0  ��ͼ����ʾ</t><b/><t>0���ƶ�ֵ��4  </t>"@ %PK1 @"<t>����״̬</t><b/><t>4���ƶ�ֵ��6  </t>"@ %PK2 @"<t>����״̬</t><b/><t>6���ƶ�ֵ��9  </t>"@ %PK3 @"<t>����״̬I</t><b/><t>   �ƶ�ֵ��9  </t>"@ %PK4 @"<t>����״̬II</t>";
				}



				%ctrl.tooltipWidth = %Width;
				%ctrl.tooltip = ""@ %PKtext1 @"<b/>"@ %moshishuoming1 @""@ %txt2 @"<b/>"@ %moshishuoming @"";*/



			case "PKOpenButtonControl":	//pkģʽ����
				if (isFile("gameres/data/icon/help/pk1.png")){ %pk1 = "<i s='gameres/data/icon/help/pk1.png' w='20' h='20'/>"; }
				else{ %pk1 = ""; }
				if (isFile("gameres/data/icon/help/pk2.png")){ %pk2 = "<i s='gameres/data/icon/help/pk2.png' w='20' h='20'/>"; }
				else{ %pk2 = ""; }
				if (isFile("gameres/data/icon/help/pk3.png")){ %pk3 = "<i s='gameres/data/icon/help/pk3.png' w='20' h='20'/>"; }
				else{ %pk3 = ""; }
				if (isFile("gameres/data/icon/help/pk4.png")){ %pk4 = "<i s='gameres/data/icon/help/pk4.png' w='20' h='20'/>"; }
				else{ %pk4 = ""; }
				if (isFile("gameres/data/icon/help/pk5.png")){ %pk5 = "<i s='gameres/data/icon/help/pk5.png' w='20' h='20'/>"; }
				else{ %pk5 = ""; }

				%ctrl.tooltipWidth = 290;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ս��ģʽ</t><b/><t>����ɶ�ս��ģʽ���������л�,��ƽģʽ�²��ɹ��������κ����;����ģʽ�¿ɶԺ�����������ҹ�����ȫ��ģʽ�¿ɹ����κ����</t><b/><t gct='0xff1200ff' gcb='0xff3c00ff'><t>��ǰ�ƶ�ֵ��"@ GetPkValue() @"</t><b/><t gct='0xffffffff' gcb='0xffffffff'><t>ͷ��ͼ��˵����</t><b/><t> 0���ƶ�ֵ��2      ��ͼ����ʾ</t><b/><t> 2���ƶ�ֵ��5   </t>"@ %pk1 @"<t>����״̬</t><b/><t> 5���ƶ�ֵ��10  </t>"@ %pk2 @"<t>����״̬</t><b/><t>10���ƶ�ֵ��20  </t>"@ %pk3 @"<t>����״̬I</t><b/><t>20���ƶ�ֵ��50  </t>"@ %pk4 @"<t>����״̬II</t><b/><t>    �ƶ�ֵ��50  </t>"@ %pk5 @"<t>����״̬III</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'><t>��ʾ:�����</t><t gct='0xff1200ff' gcb='0xff3c00ff'> �ƶ�ֵ��6 </t><t>ʱ,ʹ�ûسǾ�ᴫ�͵��η���ȥ!</t></t>";



			case "PKModePopUpWnd_Check01":	//��ƽģʽ��ť
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ƽģʽ</t><b/><t>���ɹ����κ��������</t></t>";

			case "PKModePopUpWnd_Check02":	//����ģʽ��ť
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ģʽ</t><b/><t>���ɹ���������ң��ɶԺ�����������ҹ���</t><b/><t>(���ѡ�����Ա�����ܵ��˺�)</t></t>";

			case "PKModePopUpWnd_Check03":	//ȫ��ģʽ��ť
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ȫ��ģʽ</t><b/><t>�ɹ����κ����</t><b/><t>(���ѡ�����Ա�����ܵ��˺�)</t></t>";

			case "PlayerIconAssistantButton":	//ս�����ְ�ť
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ս������(Z)</t><b/><t>�ɴ�ս�����ֽ���,�����Զ�ˢ�ֵ���Ȥ</t></t>";

			case "PlayerIconMuteButton":	//����������ť
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ģʽ</t><b/><t>�����</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>����/�ر�</t><t>����ģʽ</t><b/><t>�Ҽ������</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��</t><t>�������ý���</t>";

			case "Captivate_Img":	//������ͼ��
				%ctrl.tooltipWidth = 340;
				if ($Captivate_oldtype == 1){ %Captivate_hint="<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>����ƣ��״̬  "@$time@"</t><b/><t>��ɫ����,���,���ֵ���Ϸ���潫���룬���޷���õ������档</t><b/><t c='0x46ff15ff' >ֻ�е���ɫ�ۼ�����ʱ����5Сʱ,���������״̬</t>"; }
				else if ($Captivate_oldtype == 2){ %Captivate_hint="<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>���ڲ�����״̬  "@$time@"</t><b/><t>��ɫ����,����ܾ���,���,����,����ֵ,��Ʒ����Ϸ���涼��Ϊ�㡣</t><b/><t c='0x46ff15ff' >ֻ�е���ɫ�ۼ�����ʱ����5Сʱ,���������״̬</t>"; }

				%ctrl.tooltip ="<t m='1' f='����' n='12'>"@%Captivate_hint @"</t> ";



			case "StallWndGui_DealInfo":	//��̯������ʾ
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>              ������ʾ</t><b/><t>   �����׿�����Ϊ�������ߣ���������ԭ�򱻳���</t><b/><t>   </t><b/><t>   ������Ϸ����������Ʒ�໥���ף�</t><t gct='0xff1200ff' gcb='0xff3c00ff'>��������������Ϸ֮������ʵ���һ�����ʵ��Ʒ��������Ϸ�ڵ�������Ʒ������Ϸ�ң���</t><t>����һ�������ױ����������׶Է�ֻ�᷵�����������ڽ��׵�������Ʒ�������᷵����֧������ʵ���һ���ʵ��Ʒ���������ɵ���ʧ��ֻ�����׷��������⣬���ؾ��ٷ�����Դ˳е��κ����Ρ�</t><b/><t></t><t gct='0xff1200ff' gcb='0xff3c00ff'>   ���֮������ʵ����/��ʵ��Ʒ������Ϸ�ڵ�������Ʒ��Υ����Ϊ�����ཻ�ײ���õ����ؾ��ٷ��ı�����</t><t>��ϸ������������ؾ�ͨ��֤�û�Э�顷�����ؾ���Ϸʹ�ù����Լ����ؾ��ٷ������������йع���</t><b/><t> </t><b/><t><t gct='0xff1200ff' gcb='0xff3c00ff'>       ��������2017��10��1������ʽ��Ч</t></t>";
			case "StallSeeWndGui_DealInfo":
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>              ������ʾ</t><b/><t>   �����׿�����Ϊ�������ߣ���������ԭ�򱻳���</t><b/><t>   </t><b/><t>   ������Ϸ����������Ʒ�໥���ף�</t><t gct='0xff1200ff' gcb='0xff3c00ff'>��������������Ϸ֮������ʵ���һ�����ʵ��Ʒ��������Ϸ�ڵ�������Ʒ������Ϸ�ң���</t><t>����һ�������ױ����������׶Է�ֻ�᷵�����������ڽ��׵�������Ʒ�������᷵����֧������ʵ���һ���ʵ��Ʒ���������ɵ���ʧ��ֻ�����׷��������⣬���ؾ��ٷ�����Դ˳е��κ����Ρ�</t><b/><t></t><t gct='0xff1200ff' gcb='0xff3c00ff'>   ���֮������ʵ����/��ʵ��Ʒ������Ϸ�ڵ�������Ʒ��Υ����Ϊ�����ཻ�ײ���õ����ؾ��ٷ��ı�����</t><t>��ϸ������������ؾ�ͨ��֤�û�Э�顷�����ؾ���Ϸʹ�ù����Լ����ؾ��ٷ������������йع���</t><b/><t> </t><b/><t><t gct='0xff1200ff' gcb='0xff3c00ff'>       ��������2017��10��1������ʽ��Ч</t></t>";
			case "TradeHelpWndGui_DealInfo":	//������ʾ
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>              ������ʾ</t><b/><t>   �����׿�����Ϊ�������ߣ���������ԭ�򱻳���</t><b/><t>   </t><b/><t>   ������Ϸ����������Ʒ�໥���ף�</t><t gct='0xff1200ff' gcb='0xff3c00ff'>��������������Ϸ֮������ʵ���һ�����ʵ��Ʒ��������Ϸ�ڵ�������Ʒ������Ϸ�ң���</t><t>����һ�������ױ����������׶Է�ֻ�᷵�����������ڽ��׵�������Ʒ�������᷵����֧������ʵ���һ���ʵ��Ʒ���������ɵ���ʧ��ֻ�����׷��������⣬���ؾ��ٷ�����Դ˳е��κ����Ρ�</t><b/><t></t><t gct='0xff1200ff' gcb='0xff3c00ff'>   ���֮������ʵ����/��ʵ��Ʒ������Ϸ�ڵ�������Ʒ��Υ����Ϊ�����ཻ�ײ���õ����ؾ��ٷ��ı�����</t><t>��ϸ������������ؾ�ͨ��֤�û�Э�顷�����ؾ���Ϸʹ�ù����Լ����ؾ��ٷ������������йع���</t><b/><t> </t><b/><t><t gct='0xff1200ff' gcb='0xff3c00ff'>       ��������2017��10��1������ʽ��Ч</t></t>";





			case "SoulUpgradeHintButton_Tips":	//����������ʾ��ť
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����츳�ӵ�</t><b/><t>������������츳�㣬�ɶԻ����츳���мӵ�</t></t>";

			case "UpgradeHintButton_Tips":	//����������ʾ��ť
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ɫ������</t><b/><t>�����ť�򿪽�ɫ��Ϣ����,�ٵ��������ť��������</t></t>";

			case "PetUpgradeHintButton_Tips":	//����������ʾ��ť
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���������ӵ�</t><b/><t>�����ť��������Ϣ����,�����޽���Ǳ���ӵ�</t></t>";

			case "FriendChat_Btn":	//˽����С��ʾ
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ѵ�˽���б�</t><b/><t>�Ҽ�������ͼ�꽫��յ�ǰ��˽���б�</t></t>";

			case "playeraskfor":	//������Ϣ����ʾ
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���Ժ��ѵ���Ϣ</t></t>";

			case "SysMessageBox":	//ϵͳ��Ϣ����ʾ
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ϵͳ����Ϣ</t></t>";

			case "Birdthree2p5to2p9Button"://2.5D
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰ����ģʽ��2.5D</t><b/><t>��ģʽ�ʺϴ�ͳ��ң�����������������Ϸ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���ѡ��2.9D��3D�Ĳ���ģʽ</t></t>";

			case "Bird2p9to3Button"://2.9D
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰ����ģʽ��2.9D</t><b/><t>��ģʽ�����ӽ�С�������¸�������Ұ������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���ѡ��2.5D��3D�Ĳ���ģʽ</t></t>";

			case "Birdthree3to2p5Button"://3D
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰ����ģʽ��3D</t><b/><t>ȫ��λ360�������ǣ�չʾ������˧����Ӣ��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���ѡ��2.5D��2.9D�Ĳ���ģʽ</t></t>";

			case "BirdButtonthree2p5to2p9Button"://2.5D
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰ����ģʽ��2.5D</t><b/><t>��ģʽ�ʺϴ�ͳ��ң�����������������Ϸ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���ѡ��2.9D��3D�Ĳ���ģʽ</t></t>";

			case "BirdButton2p9to3Button"://2.9D
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰ����ģʽ��2.9D</t><b/><t>��ģʽ�����ӽ�С�������¸�������Ұ������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���ѡ��2.5D��3D�Ĳ���ģʽ</t></t>";

			case "BirdButtonthree3to2p5Button"://3D
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰ����ģʽ��3D</t><b/><t>ȫ��λ360�������ǣ�չʾ������˧����Ӣ��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���ѡ��2.5D��2.9D�Ĳ���ģʽ</t></t>";





				//====================================================================================����ѧϰ===========================================================================================================

			case "SkillStudyTxt_ComposeValue1"://��ǰְҵ������
				%ctrl.tooltipWidth = 215;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰְҵ������</t><b/><t>ÿ���������ܻ�ѧϰ�¼��ܣ���ɫ��ս��������һ��</t></t>";

			case "SkillWndSkillBitmap1"://����������
				%ctrl.tooltipWidth = 215;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰְҵ������</t><b/><t>ÿ���������ܻ�ѧϰ�¼��ܣ���ɫ��ս��������һ��</t></t>";


				//============================================================================��������====================================================================================================
				//case "AllBag_AllItemButton"://��ʾȫ�� �ϰ�״̬
				//	%ctrl.tooltipWidth = 110;
				//	%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ʾȫ����Ʒ</t></t>";

			case "AllBag_PropButton"://��ʾ����(����1)
				%ctrl.tooltipWidth = 120;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����1</t><b/><t>��Ҫװ��������չ���߿���</t></t>";

			case "AllBag_MissionButton"://��ʾ������Ʒ
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ʒ</t><b/><t>ֻ��ʾ���������Ʒ</t></t>";

			case "AllBag_FashionButton"://��ʾʱװ��Ʒ
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ʱװ��Ʒ</t><b/><t>ֻ��ʾʱװ�����Ʒ</t></t>";

			case "AllBag_AllItemButton"://��ʾȫ����Ʒ
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ȫ����Ʒ</t><b/><t>��ʾ�������ȫ����Ʒ</t></t>";

			case "AllBag_MaterialButton"://��ʾ����(����2)
				%ctrl.tooltipWidth = 125;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����2</t><b/><t>��Ҫװ��������չ���߿���</t></t>";

			case "AllBag_ArrangeButton"://����ť
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ʒ����</t><b/><t m='1' f='����' n='12' gct='0x00ff00ff' gcb='0x2cffeeff'>�����ť��������Ʒ�����͹�����ʾ���ɵ�����Ʒ���Զ�������ʾ</t></t>";

			case "AllBag_SplitItemButton"://��ְ�ť
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����л������״̬</t><b/><t m='1' f='����' n='12' gct='0x00ff00ff' gcb='0x2cffeeff'><t>�������������ڴ���ֵ���Ʒ���в��</t></t>";

			case "AllBag_DestroyButton"://���ٰ�ť
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����л�������״̬</t><b/><t m='1' f='����' n='12' gct='0x00ff00ff' gcb='0x2cffeeff'><t>�������������ڴ����ٵ���Ʒ��������</t></t>";

			case "AllBag_DecomposeButton"://�ֽⰴť
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����л����ֽ�״̬</t><b/><t m='1' f='����' n='12' gct='0x00ff00ff' gcb='0x2cffeeff'><t>�������������ڵ�װ����ʯ���зֽ�</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>1��ֻ�ֽܷ���ɫ����ɫƷ������װ�����ֽ��ɻ��ǿ��ʯ</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>2����ʯ�ֽ�ɻ�ñ�ʯ��Ƭ����ʯ��Ƭ���ٴκϳ����ʯ</t></t>";

			case "AllBag_LockItemsButton"://������ť
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ʒ����</t><b/><t m='1' f='����' n='12' gct='0x00ff00ff' gcb='0x2cffeeff'>�����ť����Ʒ��ȫ���棬�ɶԱ����ڹ�����Ʒ���м���</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>��Ʒ�������޷����н��ס��ֽ⣬���ٵȲ���</t></t>";

			case "AllBagLingYuanGui": //�󶨽�
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���</t><b/><t>��������ʱ��Ҫ���ĵĻ��ң�ͬʱ�����������̵깺����Ʒ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ͨ����ɸ�ʽ����Ͳμӻ��ȫ����</t></t>";

			case "AllBagJingYuanGui": //���׽�
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ԫ��</t><b/><t>�����С���̯����ʱ��Ҫ�Ļ��ң�Ҳ��ͨ����ֵ����һ��ɽ�һ��߻�Ծ����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ֵ���Ԫ����Ҫ��ȡ����ɫ���ϲſ�ʹ��</t></t>";

			case "AllBagJiFengGui": //��Ծ����
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ծ����</t><b/><t>����װ�������޵�����ʱ��Ҫ���ĵĻ��֣�ͬʱ�����������̵깺����Ʒ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ͨ����ɸ�ʽ����Ͳμӻ��ȫ����</t></t>";


			case "AllBag_RedundantBag1": //������չ��
				//echo("===========================AllBag_RedundantBag1==="@AllBag_RedundantBagBackGround1.IsVisible());
				if (AllBag_RedundantBagBackGround1.IsVisible()){
					//echo("=============================="@AllBag_RedundantBagBackGround1.IsVisible());
					%ctrl.tooltipWidth = 240;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��չ��</t><b/><t>��ͨ��װ��Ǭ�������ӱ�������</t></t>";
				}
				else{
					%ctrl.tooltipWidth = 0;
					%ctrl.tooltip = "";
				}
			case "AllBag_RedundantBag2": //������չ��
				if (AllBag_RedundantBagBackGround2.IsVisible()){
					%ctrl.tooltipWidth = 240;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��չ��</t><b/><t>��ͨ��װ��Ǭ�������ӱ�������</t></t>";
				}
				else{
					%ctrl.tooltipWidth = 0;
					%ctrl.tooltip = "";
				}
			case "AllBag_RedundantBag3": //������չ��
				if (AllBag_RedundantBagBackGround3.IsVisible()){
					%ctrl.tooltipWidth = 240;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��չ��</t><b/><t>��ͨ��װ��Ǭ�������ӱ�������</t></t>";
				}
				else{
					%ctrl.tooltipWidth = 0;
					%ctrl.tooltip = "";
				}
			case "AllBag_RedundantBag4": //������չ��
				if (AllBag_RedundantBagBackGround4.IsVisible()){
					%ctrl.tooltipWidth = 240;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��չ��</t><b/><t>��ͨ��װ��Ǭ�������ӱ�������</t></t>";
				}
				else{
					%ctrl.tooltipWidth = 0;
					%ctrl.tooltip = "";
				}
			case "AllBag_RedundantBag5": //������չ��
				if (AllBag_RedundantBagBackGround5.IsVisible()){
					%ctrl.tooltipWidth = 240;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��չ��</t><b/><t>��ͨ��װ��Ǭ�������ӱ�������</t></t>";
				}
				else{
					%ctrl.tooltipWidth = 0;
					%ctrl.tooltip = "";
				}
			case "AllBag_RedundantBag6": //������չ��
				if (AllBag_RedundantBagBackGround6.IsVisible()){
					%ctrl.tooltipWidth = 240;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��չ��</t><b/><t>��ͨ��װ��Ǭ�������ӱ�������</t></t>";
				}
				else{
					%ctrl.tooltipWidth = 0;
					%ctrl.tooltip = "";
				}
			case "AllBag_RedundantBag7": //������չ��
				if (AllBag_RedundantBagBackGround7.IsVisible()){
					%ctrl.tooltipWidth = 240;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��չ��</t><b/><t>��ͨ��װ��Ǭ�������ӱ�������</t></t>";
				}
				else{
					%ctrl.tooltipWidth = 0;
					%ctrl.tooltip = "";
				}
			case "AllBag_RedundantBag8": //������չ��
				if (AllBag_RedundantBagBackGround8.IsVisible()){
					%ctrl.tooltipWidth = 240;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��չ��</t><b/><t>��ͨ��װ��Ǭ�������ӱ�������</t></t>";
				}
				else{
					%ctrl.tooltipWidth = 0;
					%ctrl.tooltip = "";
				}


				//��������˵��

			case "ItemsSecurity_LockInfoExplainBtn"://����˵��
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ʒ��ȫ˵��</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>1.ֻ��װ�������������</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>2.������װ��������䲢�Ҳ��ɽ��ף�</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>3.������ʧ������������װ��Ϊ��������װ�����װ�����Ϊ����״̬�����޸���ſ�ʹ�ã�</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>4.�޸������װ��ʱ�������������һ��Ԫ����ͨ���ʼ���ʽ���ͣ���</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>5.װ������������Կ�ף�����Ҫ3��ʱ�䣬�ڴ�3��ý�����װ��Ч����������ͬ��</t></t>";


				//�ֿ���չ��

			case "AllBank_RedundantBag": //��չ��
				if (0 == $g_SignWhetherZBBank){
					%ctrl.tooltipWidth = 240;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��չ��</t><b/><t>��ͨ��װ���ֿ���չ�����Ӳֿ�����</t></t>";
				}
				else{
					%ctrl.tooltipWidth = 0;
					%ctrl.tooltip = "";
				}




				//˽�Ľ��������ť
			case "ChatFriendWnd_WriteLett": //��չ��
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����Ϣ</t><b/><t>����˰�ť�����ȫ���Ի�����</t></t>";






				// case "AllBagXianShiGui":
				// %ctrl.tooltipWidth = 280;
				// %ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ԫ��</t><b/><t>RMB����,�������ؾ��̳�������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�ɴ����ؾ��̳ǽ���������г�ֵ��Ȼ����ȡԪ������������ʹ��</t></t>";

				//	case "AllBag_ImmortalRockImage":
				//	%ctrl.tooltipWidth = 280;
				//	%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ԫ��</t><b/><t>RMB����,�������ؾ��̳�������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�ɴ����ؾ��̳ǽ���������г�ֵ��Ȼ����ȡԪ������������ʹ��</t></t>";

				//	case "AllBag_BindImmortalRockImage":
				//	%ctrl.tooltipWidth = 280;
				//	%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ϵͳ���͵�Ԫ��</t><b/><t>���ɽ��׵�RMB���ң����ڰ����ؾ��̳��ڹ�����Ʒ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>������������������л����ð�Ԫ��</t></t>";

				//	case "AllBagBindXianShiGui":
				//	%ctrl.tooltipWidth = 280;
				//	%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ϵͳ���͵�Ԫ��</t><b/><t>���ɽ��׵�RMB���ң����ڰ����ؾ��̳��ڹ�����Ʒ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>������������������л����ð�Ԫ��</t></t>";

			case "AllBag_HotSellCommodityButton":
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ʒ</t><b/><t>���ؾ��̳�����������Ʒ����ʾ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�����ť���л�������Ʒ��ʾ������״̬</t></t>";

			case "AllBag_BusinessButton"://������̯����
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��̯</t><b/><t>�����������ǰ�̯����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ָ����ͼ�ڵ����ť���ɴ򿪰�̯����</t></t>";

			case "AllBag_CurrentlyItemNum":
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����ֽ�ɫ����ʱ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��30����</t><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��,</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>  ����ÿ���8��Ǭ������Ʒ</t><b/><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���μӻ��һ������</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>  ���Ǭ�����Ľ���</t><b/><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������ؾ��̳��л���Ԫ���ɹ���</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>  �������������Ǭ������Ʒ</t></t>";

			case "AllBag_ChongButton"://������ֵ��ť
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ֵ</t><b/><t>��������Խ���Ԫ���ĳ�ֵ����ȡ����</t></t>";

			case "AllBag_ShopButton"://����������Ʒ
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ʒ</t><b/><t>����ɿ��ٲ鿴�̳�������Ʒ��</t></t>";

			case "AllBag_GoldButton"://Ԫ������
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ԫ������</t><b/><t>����ɴ򿪽��׽������Ԫ������</t></t>";

			case "AllBag_DuiButton":
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ԫ������</t><b/><t>�ڿ�����Ԫ�����׽����У����Խ���Ԫ���ͽ�ҵĻ���</t></t>";

			case "ChooseChongZhiStyleWnd_IntroBitmap1":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='����' n='14' b='1'>֧������ݳ�ֵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>δ��֧�����˺ţ�</t><b/><t>1�������֧������ݳ�ֵ��������֧����ҳ��</t><b/><t>2��������Ҫ�󶨵�֧�����˺�</t><b/><t>3���󶨺�����֧������ݳ�ֵ����ֱ�Ӵ���Ϸ��֧������ݳ�ֵ����</t><b/><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ѱ�֧�����˺ţ�</t><b/><t>1�������֧������ݳ�ֵ�����������ֵ�Ľ���ȷ��</t><b/><t>2��ϵͳ�����󶨵��ֻ�������֤��</t><b/><t>3���ֻ��ظ���֤�룬���ɳ�ֵ�ɹ�</t></t>";

				//============================================================================��ɫ����ҳ====================================================================================================
				//�ֿ��Ǽ��ٱ�����Ч���ĸ��ʣ����Ǳ�����Ч����ʵ�ʲ�������Ч�ȣ��ֿ��Ǳ�����Ч�����������Ч���ٴη�������Чʱ��

			case "DTPlayerInfowGui_Dikang1"://�ֿ�
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ֿ�ѣ��</t><b/><t>���߲���ѣ��Ч���ĸ���</t></t>";

			case "DTPlayerInfowGui_Dikang2":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ֿ�����</t><b/><t>���߲�������Ч���ĸ���</t></t>";

			case "DTPlayerInfowGui_Dikang3":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ֿ�����</t><b/><t>���߲�������Ч���ĸ���</t></t>";

			case "DTPlayerInfowGui_Dikang4":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ֿ�����</t><b/><t>���߲�������Ч���ĸ���</t></t>";

			case "DTPlayerInfowGui_Dikang5":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ֿ���Ĭ</t><b/><t>���߲�����ĬЧ���ĸ���</t></t>";

			case "DTPlayerInfowGui_Dikang6":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ֿ���˯</t><b/><t>���߲�����˯Ч���ĸ���</t></t>";

			case "DTPlayerInfowGui_Dikang7":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ֿ�����</t><b/><t>���߲�������Ч���ĸ���</t></t>";


			case "DTPlayerInfowGui_Gedang1": //��
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ѣ�θ�</t><b/><t>�ܵ�ѣ��Ч��ʱ������Ӧ����Чʱ��</t></t>";

			case "DTPlayerInfowGui_Gedang2":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���Ҹ�</t><b/><t>�ܵ�����Ч��ʱ������Ӧ����Чʱ��</t></t>";

			case "DTPlayerInfowGui_Gedang3":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����</t><b/><t>�ܵ�����Ч��ʱ������Ӧ����Чʱ��</t></t>";

			case "DTPlayerInfowGui_Gedang4":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ٸ�</t><b/><t>�ܵ�����Ч��ʱ������Ӧ����Чʱ��</t></t>";

			case "DTPlayerInfowGui_Gedang5":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ĭ��</t><b/><t>�ܵ���ĬЧ��ʱ������Ӧ����Чʱ��</t></t>";

			case "DTPlayerInfowGui_Gedang6":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��˯��</t><b/><t>�ܵ���˯Ч��ʱ������Ӧ����Чʱ��</t></t>";

			case "DTPlayerInfowGui_Gedang7":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t>�ܵ�����Ч��ʱ������Ӧ����Чʱ��</t></t>";


			case "DTPlayerInfowGui_Kangxing1": //����
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ѣ�ο���</t><b/><t>ѣ�ο���Խ�ߣ�ѣ��Ч������������ѣ�ε�ʱ��Խ��</t></t>";

			case "DTPlayerInfowGui_Kangxing2":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ҿ���</t><b/><t>���ҿ���Խ�ߣ�����Ч�����������߻��ҵ�ʱ��Խ��</t></t>";

			case "DTPlayerInfowGui_Kangxing3":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t>������Խ�ߣ�����Ч�����������߱����ʱ��Խ��</t></t>";

			case "DTPlayerInfowGui_Kangxing4":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ٿ���</t><b/><t>���ٿ���Խ�ߣ�����Ч�����������߼��ٵ�ʱ��Խ��</t></t>";

			case "DTPlayerInfowGui_Kangxing5":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ĭ����</t><b/><t>��Ĭ����Խ�ߣ���ĬЧ�����������߳�Ĭ��ʱ��Խ��</t></t>";

			case "DTPlayerInfowGui_Kangxing6":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��˯����</t><b/><t>��˯����Խ�ߣ���˯Ч�����������߻�˯��ʱ��Խ��</t></t>";

			case "DTPlayerInfowGui_Kangxing7":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>��������Խ�ߣ�����Ч������������������ʱ��Խ��</t></t>";

				//============================================================================��ɫװ������====================================================================================================



			case "PlayerInfo_Family":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ʥ������</t><b/><t>��ɫ����ʥ��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ͬʥ�ض�����Ļ�������Ӱ��Ҳ��ͬ</t></t>";

			case "DTPlayerInfoGuiKX":
				%ctrl.tooltipWidth = 135;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ʥ�ر�־</t><b/><t>"@  %Family1 @"�ı�־</t></t>";

			case "PlayerInfo_Faction"://ʱװ��ť
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ʱװ��װ�����ε��л�</t><b/><t>��ʾ��ͨʱװ��ʥ��ʱװ������</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>���Ͻǵ�ʱװ��ť</t><t>������ʱװ�����������</t></t>";

			case "PlayerInfo_ShowArmet"://ͷ����ť
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ʾ������ͷ����ʾ�л�</t></t>";

			case "DTPlayerInfo_ZDbtn":
				%ctrl.tooltipWidth = 130;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ս������</t></t>";

			case "PlayerInfo_AccouterButton":
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�л���װ�����Խ���</t></t>";

			case "PlayerInfoGui_OpenRightWndButton":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�鿴�����ؽ�ɫ������Ϣ</t></t>";

			case "DTPlayerInfo_Itemtext"://װ��Ʒ��
				%ctrl.tooltipWidth = 350;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰ��ɫװ����Ʒ����ֵ </t><b/><t>1��װ��Ʒ�ʿ�ͨ���������е�ǿ����ť����������Ƕ��װ�����ס����顢���顢ϴ�顢���ɡ������ȷ�ʽ����</t><b/><t>2������ȼ�Խ�����ӵ�װ��Ʒ��ֵԽ��</t></t>";

			case "PlayerInfo_NowExp"://������
				%ctrl.tooltipWidth = 340;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ﾭ��</t><b/><t>1����ʾ����ǰ���ﾭ��/�������辭��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >2������4�޺������ɴ����������������辭��</t></t>";

			case "PlayerInfo_PlayerLevelUpButton"://����
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ɫ����</t><b/><t>4���Ժ�������������Ҫ��ʱ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���ֶ����</t><t>�ð�ť��������</t></t>";

			case "PlayerInfoGui_XiuShen_Num":
				%xiushenNum = getWorldPlayerTopDisaster();
				if (%xiushenNum == 0){ %xiushen1="<b/><t>��ǰɱ���޶���ӳ�</t><b/><t>������ָ���ﵽ4��4����ʱ��ɱ�ֽ�������ӳ�</t>"; }
				else if (%xiushenNum == 1){ %xiushen1="<b/><t>��ǰɱ���޶���ӳ�</t><b/><t>������ָ���ﵽ4��4����ʱ��ɱ�ֽ�������ӳ�</t>"; }
				else if (%xiushenNum == 2){ %xiushen1="<b/><t>��ǰɱ���޶���ӳ�</t><b/><t>������ָ���ﵽ4��4����ʱ��ɱ�ֽ�������ӳ�</t>"; }
				else if (%xiushenNum == 3){ %xiushen1="<b/><t>��ǰɱ���޶���ӳ�</t><b/><t>������ָ���ﵽ4��4����ʱ��ɱ�ֽ�������ӳ�</t>"; }
				else if (%xiushenNum == 4){ %xiushen1="<b/><t>��ǰȫ��65��������ң���65����ɱ�ֻ�õ����ﾭ���������50%</t>"; }
				else if (%xiushenNum == 5){ %xiushen1="<b/><t>��ǰȫ��75��������ң���75����ɱ�ֻ�õ����ﾭ���������75%</t>"; }
				else if (%xiushenNum == 6){ %xiushen1="<b/><t>��ǰȫ��85��������ң���85����ɱ�ֻ�õ����ﾭ���������100%</t>"; }
				else if (%xiushenNum == 7){ %xiushen1="<b/><t>��ǰȫ��95��������ң���95����ɱ�ֻ�õ����ﾭ���������125%</t>"; }
				else if (%xiushenNum == 8){ %xiushen1="<b/><t>��ǰȫ��105��������ң���105����ɱ�ֻ�õ����ﾭ���������150%</t>"; }
				else if (%xiushenNum == 9){ %xiushen1="<b/><t>��ǰȫ��115��������ң���115����ɱ�ֻ�õ����ﾭ���������200%</t>"; }
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰ����������ָ����"@ %xiushenNum @"</t>"@%xiushen1 @"<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>С��ʾ������ָ����ʼֵΪ0��ÿ����Ϸ�����˶ɹ����ʱ������ָ�����������������ָ���ﵽ4��4����ʱ��ɱ�ֽ��ж�������ӳɡ�</t></t>";

			case "AllServerMovementGuiTxt":
				%xiushenNum = getWorldPlayerTopDisaster();
				if (%xiushenNum == 0){ %xiushen1="<b/><t>��ǰɱ���޶���ӳ�</t><b/><t>������ָ���ﵽ4��4����ʱ��ɱ�ֽ�������ӳ�</t>"; }
				else if (%xiushenNum == 1){ %xiushen1="<b/><t>��ǰɱ���޶���ӳ�</t><b/><t>������ָ���ﵽ4��4����ʱ��ɱ�ֽ�������ӳ�</t>"; }
				else if (%xiushenNum == 2){ %xiushen1="<b/><t>��ǰɱ���޶���ӳ�</t><b/><t>������ָ���ﵽ4��4����ʱ��ɱ�ֽ�������ӳ�</t>"; }
				else if (%xiushenNum == 3){ %xiushen1="<b/><t>��ǰɱ���޶���ӳ�</t><b/><t>������ָ���ﵽ4��4����ʱ��ɱ�ֽ�������ӳ�</t>"; }
				else if (%xiushenNum == 4){ %xiushen1="<b/><t>��ǰȫ��65��������ң���65����ɱ�ֻ�õ����ﾭ���������50%</t>"; }
				else if (%xiushenNum == 5){ %xiushen1="<b/><t>��ǰȫ��75��������ң���75����ɱ�ֻ�õ����ﾭ���������75%</t>"; }
				else if (%xiushenNum == 6){ %xiushen1="<b/><t>��ǰȫ��85��������ң���85����ɱ�ֻ�õ����ﾭ���������100%</t>"; }
				else if (%xiushenNum == 7){ %xiushen1="<b/><t>��ǰȫ��95��������ң���95����ɱ�ֻ�õ����ﾭ���������125%</t>"; }
				else if (%xiushenNum == 8){ %xiushen1="<b/><t>��ǰȫ��105��������ң���105����ɱ�ֻ�õ����ﾭ���������150%</t>"; }
				else if (%xiushenNum == 9){ %xiushen1="<b/><t>��ǰȫ��115��������ң���115����ɱ�ֻ�õ����ﾭ���������200%</t>"; }
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰ����������ָ����"@ %xiushenNum @"</t>"@%xiushen1 @"<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>С��ʾ������ָ����ʼֵΪ0��ÿ����Ϸ�����˶ɹ����ʱ������ָ�����������������ָ���ﵽ4��4����ʱ��ɱ�ֽ��ж�������ӳɡ�</t></t>";


			case "PlayerInfo_Duoming"://װ���Ķ�����ť
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>װ�����������</t><b/><t>����ӵ�еļ�Ʒװ���ϴ������а�������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>װ�����ϵ�װ����ֱ�ӷ�������������������ϴ�</t></t>";

			case "PlayerInfoEquip_Bmp1":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ø���Ʒ��װ����ʾ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�����ǰװ����λ�����ᵯ����ø���Ʒ��װ��;������</t></t>";

			case "PlayerInfoEquip_Bmp2":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ø���Ʒ��װ����ʾ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�����ǰװ����λ�����ᵯ����ø���Ʒ��װ��;������</t></t>";

			case "PlayerInfoEquip_Bmp3":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ø���Ʒ��װ����ʾ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�����ǰװ����λ�����ᵯ����ø���Ʒ��װ��;������</t></t>";

			case "PlayerInfoEquip_Bmp4":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ø���Ʒ��װ����ʾ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�����ǰװ����λ�����ᵯ����ø���Ʒ��װ��;������</t></t>";

			case "PlayerInfoEquip_Bmp5":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ø���Ʒ��װ����ʾ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�����ǰװ����λ�����ᵯ����ø���Ʒ��װ��;������</t></t>";

			case "PlayerInfoEquip_Bmp6":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ø���Ʒ��װ����ʾ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�����ǰװ����λ�����ᵯ����ø���Ʒ��װ��;������</t></t>";

			case "PlayerInfoEquip_Bmp7":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ø���Ʒ��װ����ʾ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�����ǰװ����λ�����ᵯ����ø���Ʒ��װ��;������</t></t>";

			case "PlayerInfoEquip_Bmp8":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ø���Ʒ��װ����ʾ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�����ǰװ����λ�����ᵯ����ø���Ʒ��װ��;������</t></t>";

			case "PlayerInfoEquip_Bmp9":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ø���Ʒ��װ����ʾ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�����ǰװ����λ�����ᵯ����ø���Ʒ��װ��;������</t></t>";

			case "PlayerInfoEquip_Bmp10":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ø���Ʒ��װ����ʾ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�����ǰװ����λ�����ᵯ����ø���Ʒ��װ��;������</t></t>";

			case "PlayerInfoEquip_Bmp11":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ø���Ʒ��װ����ʾ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�����ǰװ����λ�����ᵯ����ø���Ʒ��װ��;������</t></t>";

			case "PlayerInfoEquip_Bmp12":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ø���Ʒ��װ����ʾ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�����ǰװ����λ�����ᵯ����ø���Ʒ��װ��;������</t></t>";

			case "PlayerInfoEquip_Bmp13":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ø���Ʒ��װ����ʾ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�����ǰװ����λ�����ᵯ����ø���Ʒ��װ��;������</t></t>";


				//============================================================================��ȫ����=================================================================================================================

			case "SecurityCfgWnd_TimeGui_Sure"://����
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����µİ�ȫʱ�䣬���ȷ����ť������24Сʱ����Ч</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>��ȫʱ��ֻ����1-30�������Զ�������</t></t>";

			case "SecurityCfgWnd_ItemGui_Lock"://����
				%state = %player.getSecondPWDState();
				if (%state == 0){ %lockNews ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ʾ���㵱ǰ�������뻹δ���ã��������ö�������</t>"; }
				%ctrl.tooltipWidth = 350;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ѡ�д���������Ʒ�����������ť���ɶ���Ʒ����</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>��Ʒ�������޷����н��ס��ֽ⣬���ٵȲ���</t>"@ %lockNews @"</t>";

			case "SecurityCfgWnd_ItemGui_Unlock"://����
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ѡ���Ѽ�������Ʒ�����������ť���ɶ���Ʒ����</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>���������Ʒ������3��Ľ���ȷ����</t></t>";

			case "SecurityCfgWnd_PetInfoGui_LockButton"://����
				%state = %player.getSecondPWDState();
				if (%state == 0){ %lockNews ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ʾ���㵱ǰ�������뻹δ���ã��������ö�������</t>"; }
				%ctrl.tooltipWidth = 350;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ѡ�д����������ޣ����������ť���ɶ����޼���</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>�����������޷����н��ס������������Ȳ���</t>"@ %lockNews @"</t>";

			case "SecurityCfgWnd_PetInfoGui_UnlockButton"://����
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ѡ���Ѽ��������ޣ����������ť���ɶ����޽���</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>����������޽�����3��Ľ���ȷ����</t></t>";

			case "SecurityCfgWnd_MountGui_LockButton"://����
				%state = %player.getSecondPWDState();
				if (%state == 0){ %lockNews ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ʾ���㵱ǰ�������뻹δ���ã��������ö�������</t>"; }
				%ctrl.tooltipWidth = 350;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ѡ�д���������裬���������ť���ɶ�������</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>����������޷�����</t>"@ %lockNews @"</t>";

			case "SecurityCfgWnd_MountGui_UnlockButton"://����
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ѡ���Ѽ�������裬���������ť���ɶ�������</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>���������轫����3��Ľ���ȷ����</t></t>";

			case "SecurityCfgWnd_SoulGui_LockButton"://����
				%state = %player.getSecondPWDState();
				if (%state == 0){ %lockNews ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ʾ���㵱ǰ�������뻹δ���ã��������ö�������</t>"; }
				%ctrl.tooltipWidth = 350;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ѡ�д������Ļ��񣬵��������ť���ɶԻ������</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>�����������޷����ж�����ϴ��Ȳ���</t>"@ %lockNews @"</t>";

			case "SecurityCfgWnd_SoulGui_UnlockButton"://����
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ѡ���Ѽ����Ļ��񣬵��������ť���ɶԻ������</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>������Ļ��񽫽���3��Ľ���ȷ����</t></t>";

				//============================================================================�������=================================================================================================================

			case "TeamNameEdit_1"://��������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�������ֿ��Ը���,��꼤�����������ʾ��,������������ֺ�,����������ťȷ��</t></t>";

			case "ChangeTeamNameBtn"://����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������ȷ��</t><b/><t>�����������11������</t><b/><t>��꼤�����������ʾ��,������������ֺ�,����������ťȷ��</t></t>";

			case "TeammateIconHelping_1"://Э��ս��
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Э��ս��</t><b/><t>���趨��Ա�Ƿ��Զ�Э���ӳ�ս��</t><b/><t>���ӳ������Զ�ս��ʱ������ս��Э�����ܵĶ�ԱҲ���Զ������Զ�ս��</t></t>";






				//============================================================================��ɫ��������=================================================================================================================
				//PlayerAbility_Attack ������
				//PlayerAbility_AttackHZ ����Ƶ��
				//PlayerAbility_Stabilize �ȶ���
				//PlayerAbility_Breathe ����
				//PlayerAbility_Therapy ����
				//PlayerAbility_Assistant ����

				//============================================================================��ɫ��Ϣ����=================================================================================================================



			case "DTPlayerInfo_vip"://VIP�ȼ�
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>VIP�ȼ���Ȩ</t><b/><t>VIP�ȼ�Խ����ȨԽ��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ɽ���VIP��Ȩ����</t></t>";

			case "DTPlayerInfo_ZhuangSheng"://�����ֻصȼ�
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����ֻصȼ� </t><b/><t>�ֻصȼ�Խ�߻�õ����Լӳ�Խ��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����鿴�ֻ����Խ���</t></t>";



			case "DTPlayerInfo_PlayerName"://�������
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ɫ��</t></t>";

			case "DTPlayerInfo_DuoMingbtn"://������ť
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������ť</t><b/><t>��������Խ������װ��Ʒ��ֵ�ϴ������а��в�������</t><b/><t c='0x00ff00ff' >������δ���ţ������ڴ�</t></t>";

			case "DTPlayerInfo_KXbtn":
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>��ʾ��ɫ���еĿ��ԣ������ֿ����񵲡���������</t></t>";

			case "DTPlayerInfo_ZDbtn":
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ս����Ϣ</t><b/><t>��ʾ��ɫ������Ϣ��ս������</t></t>";

			case "DTPlayerInfo_SZbtn":
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ʱװ</t><b/><t>��ɫӵ�е�ʱװ����������</t></t>";

			case "DTPlayerInfo_SJbtn"://����
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ɫ����</t><b/><t>4���Ժ�������������Ҫ��ʱ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���ֶ����</t><t>�ð�ť��������</t></t>";

			case "DTPlayerInfo_NowExp"://������
				%ctrl.tooltipWidth = 340;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ɫ����</t><b/><t>1����ʾ����ǰ��ɫ����/�������辭��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >2����ɫ4�޺������ɴ����������������辭��</t></t>";



				//                                              ============================��ɫ��Ϣ - ս����Ϣ===============================


			case "DTPlayerInfowGui_Zhuansheng"://�ֻ�
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ֻصȼ�</t><b/><t>ÿһ���ֻض��������Լӳ�</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�ﵽ�ȼ����������������ʥ��ʥ�������ֻ�</t></t>";

			case "DTPlayerInfowGui_Lv"://�ȼ�
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ɫ�ȼ�</t><b/><t>�ֻؿ������ý�ɫ�ȼ���������Լӳ�</t></t>";

			case "DTPlayerInfowGui_Work"://ְҵ
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ְҵ</t><b/><t>��ְͬҵ�Ļ������Ժ͹�������Ӱ�첻ͬ</t></t>";

			case "DTPlayerInfowgui_family"://ְҵ

				if (%Family ==0){ %menfa = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ŷ�����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1��5�غ���ʥ��ʥ�����ɽӵ������ŷ�����������</t></t>"; }
				if (%Family ==1){ %menfa = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ŷ�����</t><b/><t>��ܷ����η��ǵж������������ķ�������</t></t>"; }
				if (%Family ==2){ %menfa = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ŷ�����</t><b/><t>��ܷ����η��ǵж����������������</t></t>"; }
				if (%Family ==3){ %menfa = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ŷ�����</t><b/><t>��������ķ��ǵж����������η�������</t></t>"; }
				if (%Family ==4){ %menfa = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ŷ�����</t><b/><t>��������ķ��ǵж��������Ϳܷ�������</t></t>"; }
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = ""@ %menfa @"";

			case "DTPlayerInfo_ExpTiliText":
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ֵ [��ƣ�HP]</t><b/><t>��ʾ����ǰ����ֵ/����ֵ����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ǰ����ֵΪ0ʱ��ɫ������</t></t>";

			case "DTPlayerInfo_ExpJingliText":
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ֵ [��ƣ�MP]</t><b/><t>��ʾ����ǰ����ֵ/����ֵ����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ɫ�ͷ�ս�����ܽ����ľ���</t></t>";

			case "DTPlayerInfo_ExpYuanliText":
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ԫ��ֵ [��ƣ�PP]</t><b/><t>��ʾ����ǰԪ��ֵ/Ԫ��ֵ����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����û����������ܶ�������Ԫ��</t></t>";

			case "DTPlayerInfo_ExpHuoliText":
				%ctrl.tooltipWidth = 290;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ֵ</t><b/><t>1����ʾ����ǰ����ֵ/����ֵ����</t><b/><t>2�����������ʱ������,��ͬ�������䷽�����ĵĻ���ֵ��ͬ����İ���˷��ʼ�Ҳ�����Ļ���ֵ</t><b/><t>3����ɫ��������Զ��ָ�����ֵ</t></t>";

			case "DTPlayerInfo_ExpShenfaText":

				if (%Classes==1){ %shenfa1="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������ԣ�����</t><b/><t>����������"@ %gongjishanghai1 @"���ܺ�"@ %gongjishanghai1 @"����</t></t>"; }
				else if (%Classes==2){ %shenfa1="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������ԣ�����</t><b/><t>����������"@ %gongjishanghai1 @"���ܺ�"@ %gongjishanghai1 @"����</t></t>"; }
				else if (%Classes==3){ %shenfa1="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������ԣ�����</t><b/><t>����������"@ %gongjishanghai1 @"���ܺ�"@ %gongjishanghai1 @"����</t></t>"; }
				else if (%Classes==4){ %shenfa1="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������ԣ�����</t><b/><t>����������"@ %gongjishanghai1 @"���ܺ�"@ %gongjishanghai1 @"����</t></t>"; }
				else if (%Classes==5){ %shenfa1="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������ԣ�����</t><b/><t>����������"@ %gongjishanghai1 @"���ܺ�"@ %gongjishanghai1 @"����</t></t>"; }
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = ""@ %shenfa1 @"";

			case "DTPlayerInfo_ExpJingshenText":
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������ԣ�����</t><b/><t>��߽�ɫ����ֵ����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1�㾫�������22.8�㾫��ֵ����ͬʱ���������ľ����ָ��ٶ�</t></t>";

			case "DTPlayerInfo_ExpTipoText":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������ԣ����ǣ�</t><b/><t>��߽�ɫ����ֵ����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1�����ǿ�����13������ֵ����ͬʱ���������������ָ��ٶ�</t></t>";

			case "DTPlayerInfo_ExpNeiliText2":

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������ԣ�������</t><b/><t>��߽�ɫ��������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1������������2.83����������</t></t>";

			case "DTPlayerInfo_ExpNeiliText3":// ��ͨ��������		

				if (%Classes==1){ %gongji1="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������ԣ�������</t><b/><t>������߽�ɫ������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1������������1.57������</t></t>"; }
				else if (%Classes==2){ %gongji1="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������ԣ�������</t><b/><t>������߽�ɫ������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1������������1.57������</t></t>"; }
				else if (%Classes==3){ %gongji1="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������ԣ�������</t><b/><t>������߽�ɫ��������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1������������1.32��������</t></t>"; }
				else if (%Classes==4){ %gongji1="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������ԣ�������</t><b/><t>������߽�ɫ��������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1������������1.32��������</t></t>"; }
				else if (%Classes==5){ %gongji1="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������ԣ�������</t><b/><t>������߽�ɫ������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1������������1.57������</t></t>"; }
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = ""@ %gongji1 @"";

			case "DTPlayerInfo_ExpNeiliText4":// ���⹥������		
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������ԣ�"@ %wuxigongji1 @"�飩</t><b/><t>��߽�ɫ"@ %wuxigongji1 @"ϵ����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>1��"@ %wuxigongji1 @"�������1��"@ %wuxigongji1 @"ϵ����</t></t>";

			case "DTPlayerInfo_ExpBaoJIText":
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>��߽�ɫ���������˺��ļ���,��ֵԽ��Խ�������ʾ�Խ��</t></t>";

			case "DTPlayerInfo_ExpZhiliaoText":
				%ctrl.tooltipWidth = 170;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>����������ߵ�����ֵ</t></t>";

			case "DTPlayerInfo_ExpJianRenText":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>��ֵԽ��Խ��ֹ�������ʾ�Խ��</t></t>";

			case "DTPlayerInfo_ExpFuyuanText"://��Ե
				%ctrl.tooltipWidth = 205;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ե</t><b/><t>��������δ���ţ������ڴ���</t>";

				//��ɫ��Ϣ - ������ҳ����
			case "DTPlayerInfo_ExpGongXGongText":
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %gongjishanghai1 @"����</t><b/><t>����������ɵ�"@ %gongjishanghai1 @"�˺�ֵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�����Ĺ����ٶ�ֵԽ��,"@ %gongjishanghai1 @"�����ӳ�Խ��</t></t>";

			case "DTPlayerInfo_ExpGongText1":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���������������ࣩ</t><b/><t>��ɫ����������ɵ������˺�</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����������ֵӰ��</t></t>";

			case "DTPlayerInfo_ExpGongText2":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>��������ֵԽ�������ܶ�������������Խ��</t></t>";

			case "DTPlayerInfo_ExpGongText3":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>��������ֵԽ�������ܶ��ַ�����������Խ��</t></t>";

			case "DTPlayerInfo_ExpGongLingGongtext":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %wuxigongji1 @"�鹥��</t><b/><t>����������ɵ�"@ %wuxigongji1 @"ϵ�˺�ֵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��"@ %wuxigongji1 @"��Ӱ��</t></t>";

			case "DTPlayerInfo_ExpGongMingZhongtext":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %gongjishanghai1 @"����</t><b/><t>"@ %gongjishanghai1 @"����Խ��������������"@ %gongjishanghai1 @"��������Խ��</t></t>";

				//��ɫ��Ϣ - ������ҳ����

			case "DTPlayerInfo_ExpFangPageText1":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t><b/><t>�ܵ��������˺�ʱ������Ӧ���˺�</t></t>";

			case "DTPlayerInfo_ExpFangPageText2":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�ܵ����������˺�ʱ������Ӧ���˺�</t></t>";

			case "DTPlayerInfo_ExpFangPageText3":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�ܵ����������˺�ʱ������Ӧ���˺�</t></t>";

			case "DTPlayerInfo_ExpFangPageText4":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ϵ����</t><b/><t>�ܵ����鹥���˺�ʱ������Ӧ���˺�</t></t>";

			case "DTPlayerInfo_ExpFangPageText5":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ϵ����</t><b/><t>�ܵ����鹥���˺�ʱ������Ӧ���˺�</t></t>";

			case "DTPlayerInfo_ExpFangPageText6":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ϵ����</t><b/><t>�ܵ����鹥���˺�ʱ������Ӧ���˺�</t></t>";

			case "DTPlayerInfo_ExpFangPageText7"://����
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ϵ����</t><b/><t>�ܵ����鹥���˺�ʱ������Ӧ���˺�</t></t>";

			case "DTPlayerInfo_ExpFangPageText8":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ϵ����</t><b/><t>�ܵ����鹥���˺�ʱ������Ӧ���˺�</t></t>";

				//��ɫ��Ϣ -������ҳ����

			case "DTPlayerInfo_ExpOtherText1":
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����"@ %gongjishanghai1 @"����</t><b/><t>���Է����"@ %gongjishanghai1 @"�˺�ʱ�����ӶԷ��Ĳ���"@ %gongjishanghai1 @"����ֵ</t></t>";

			case "DTPlayerInfo_ExpOtherText2":
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����"@ %wuxigongji1 @"ϵ����</t><b/><t>���Է����"@ %wuxigongji1 @"ϵ�˺�ʱ�����ӶԷ��Ĳ���"@ %wuxigongji1 @"ϵ����</t></t>";

			case "DTPlayerInfo_ExpOtherText7":
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>���Է���������˺�ʱ�����ӶԷ��Ĳ�����������</t></t>";

			case "DTPlayerInfo_ExpOtherText3":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����ٶ�</t><b/><t>��õĹ����ٶȼӳ�</t></t>";

			case "DTPlayerInfo_ExpOtherText4":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���������˺��������ͨ�˺�������ֵ</t></t>";

			case "DTPlayerInfo_ExpOtherText5":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ƶ��ٶ�</t><b/><t>��õ��ƶ��ٶȼӳ�</t></t>";

			case "DTPlayerInfo_ExpOtherText6":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������</t><b/><t>�ܵ�������Ա����˺��ļ���</t></t>";


				//============================================================================�鿴Ŀ���ɫ��Ϣ����=================================================================================================================

			case "TargetInfo_PlayerName"://����
				%ctrl.tooltipWidth = 95;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>��ɫ������</t></t>";

			case "TargetInfo_Level"://�ȼ�
				%ctrl.tooltipWidth = 120;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ȼ�</t><b/><t>��ɫ�ȼ�</t></t>";

			case "TargetInfo_ItemQuality_1"://Ʒ��
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰ��ɫ����װ����Ʒ����ֵ</t><b/><t>װ��Ʒ����ֵ/����Ʒ����ֵ</t><b/><t>װ��Ʒ����ֵ��װ��</t></t>";

			case "TargetInfo_AccouterButton"://�л���װ������
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�л���װ�����Խ���</t></t>";

			case "TargetInfo_FashionButton": //�л���ʱװ����
				%ctrl.tooltipWidth = 130;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�л���ʱװ����</t></t>";


				//=====================================================================================�������=============================================================================================================
			case "Avatar_Floor"://���񾳽��ȸ�˵��
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���񾳽�</t><b/><t>ÿ�������Ϊ6�����磬ÿ���1�����磬����ĵȼ��������20��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���񾳽�������������ڽ�����ֱ������</t></t>";

			case "Avatar_Levelup"://����������ť
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�ֶ������ť��������ȼ�</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ҫ���Ļ�����</t></t>";

			case "Avatar_Active"://���񼤻�
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�˻�����Ҫ����ſ���ʹ��</t></t>";

			case "Avatar_ExpBar"://��������
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t>��ǰ������/�����������辭��</t></t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���ܡ���ٸ��ʮ��·������а��Ĺ������ɻ�û����顣</t></t>";

			case "SoulGenius_SpiritJingJie"://���񾳽�
				%nSpiritRace = SpiritOperationManager_GetSpiritType($SoulGeniusWnd_SpiritSlot);

				if (%nSpiritRace == 0){ %txt ="���š����ġ����ա��������Ԫ����Ԫ�����������塢ʥ�ԡ�����";%txt1="������"; }
				else if (%nSpiritRace == 1){ %txt ="�������˼�����С����顢������������ġ������������ŷ�";%txt1="������"; }
				else if (%nSpiritRace == 2){ %txt ="�뾲���۹⡢�ںϡ��Ķ�����š�ԪӤ�����ϡ�������١��ɵ�";%txt1="������"; }
				else if (%nSpiritRace == 3){ %txt ="���֡���ѿ�����顢��Ҷ�������������������鶯���ɻ����澫";%txt1="�ɻ���"; }
				else if (%nSpiritRace == 4){ %txt ="���������š��ۻꡢ���顢���Ρ���������Ѫ����ꡢڤ�⡢����";%txt1="���Ľ�"; }
				else if (%nSpiritRace == 5){ %txt ="��ϡ����񡢷�ˮ����������ϡ����硢��ɽ����Ԫ���׶���Ԫ��";%txt1="ɽ����"; }
				else if (%nSpiritRace == 6){ %txt ="���ޡ��û�����������������š���Ӥ�����ȡ����ơ���ɱ������";%txt1="���鹬"; }
				else if (%nSpiritRace == 7){ %txt ="ħ�ǡ���ɷ���޼š����ڡ���ħ�����졢ʮ������Ѫ�硢ħ��";%txt1="��ħ��"; }

				%ctrl.tooltipWidth = 440;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���񾳽�</t><b/><t>1��"@ %txt1 @"�Ļ���ʮ���������£�</t><b/><t>"@ %txt @"</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>2��ÿ�����ͻ����Ϊ��ͬ��ʮ������,����Խ�߻���û�������Խǿ</t></t>";

			case "Avatar_UpgradeLVTip"://�����������
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������˹���</t><b/><t>1�����л���Էǻ���״̬��Ҷ���10%�Ĺ�������ӳ�</t><b/><t>2������������˹��򣬹������˵����Ի���ʱ���ж���Ĺ����ӳɣ�����˹�������޹����ӳ�</t><b/><t>     </t><i s='gameres/data/icon/help/HS_01.png' w='150' h='150'/></t>";


			case "SoulGenius_SpiritLevel"://�ɳ��׶�
				%ctrl.tooltipWidth = 375;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ɳ��׶�</t><b/><t>1����ʾ����ǰ�ɳ��׶�/�þ����³ɳ��׶ε�����</t><b/><t>2������������ֵ��,�ɳ��׶�����1��������츳��1��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>3���ɳ��׶δﵽ���޺�,������������,��Ի����������</t></t>";

			case "SoulGenius_ExpText"://������
				%ctrl.tooltipWidth = 380;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t>1����ʾ����ǰ������ֵ/�������辭��ֵ</t><b/><t>2����ɫ��������,�������ӵ�ǰ���û���ľ���ֵ</t><b/><t>3��������ֵ������߻���ɳ��׶�1�����츳����1��</t></t>";

			case "SoulGenius_TalentLeftPts"://ʣ���츳����
				if ($CurSelectModeId == 0){ %KJJ =",�鿴����ݼ���K "; }
				else if ($CurSelectModeId == 1){ %KJJ =",�鿴����ݼ���Alt+K"; }
				else if ($CurSelectModeId == 2){ %KJJ =",�鿴����ݼ���K"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�ر�ս�����ܽ���") !$= "")
						%KJJ = ",�鿴�ɰ���ݼ���" @ GetHotKey("��/�ر�ս�����ܽ���")@ "";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ʣ���츳����</t><b/><t>1������������ֵ��,�ɳ��׶�����1��������츳��1��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>2���������������츳ͼ����мӵ�</t><b/><t c='0xF450CFff'>3����������ֶ��ͷŵ��츳������ʾ�ڽ�ɫ���ܽ�����"@ %KJJ @"</t></t>";

			case "SoulGenius_TalentPts"://�������
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�츳�������</t><b/><t>1���츳�ӵ�ʱҪע���츳���ܶ��������������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>2�������ͨ��ϴ�����,��������츳��,�ɶԻ������½����츳���</t></t>";

			case "SoulGenius_RemoveSpiritBtn"://������ť
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���û���ʥ�ػ��񡢻���ϴ�㡢����״̬�»����ܱ�����</t></t>";

			case "SoulGenius_LockSpiritBtn"://������ť
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�����ť,�򿪰�ȫ���ý���ɶԻ�����м������������</t></t>";

			case "SoulGenius_SpiritSlot_1":

				if (SoulGenius_SpiritSlot_Image_1.Isvisible())
				{
					%ctrl.tooltipWidth = 275;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ļ�����</t><b/><t>ʹ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ʯ</t><t>�ɼ����Ļ�����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ʯ</t><t>�ڴ����칬�����һ�����ʻ�ã������ؾ��̳��п�ֱ�ӹ���</t></t>";
				}

			case "SoulGenius_SpiritSlot_2":

				if (SoulGenius_SpiritSlot_Image_2.Isvisible())
				{
					%ctrl.tooltipWidth = 275;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ļ�����</t><b/><t>ʹ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ʯ</t><t>�ɼ����Ļ�����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ʯ</t><t>�ڴ����칬�����һ�����ʻ�ã������ؾ��̳��п�ֱ�ӹ���</t></t>";
				}

			case "SoulGenius_SpiritSlot_3":

				if (SoulGenius_SpiritSlot_Image_3.Isvisible())
				{
					%ctrl.tooltipWidth = 275;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ļ�����</t><b/><t>ʹ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ʯ</t><t>�ɼ����Ļ�����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ʯ</t><t>�ڴ����칬�����һ�����ʻ�ã������ؾ��̳��п�ֱ�ӹ���</t></t>";
				}

			case "SoulGenius_SpiritSlot_4":

				if (SoulGenius_SpiritSlot_Image_4.Isvisible())
				{
					%ctrl.tooltipWidth = 275;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ļ�����</t><b/><t>ʹ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ʯ</t><t>�ɼ����Ļ�����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ʯ</t><t>�ڴ����칬�����һ�����ʻ�ã������ؾ��̳��п�ֱ�ӹ���</t></t>";
				}

			case "SoulGenius_Bnt_FindRefineSoulNPC":
				%ctrl.tooltipWidth = 350;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������,�Զ�Ѱ����ʥ�ػ������Ա������������</t><b/><t>�������Ա�����²�����</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>1���������ã�</t><t>ӵ���������ϻ���,����������������û������</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>2����������</t><t>�ɳ��׶δ����޺����������,�������񾳽�ʹ��ӵ�и���ǿ�������</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>3������ϴ�㣺</t><t>����ϴ���,��������ĵ�ǰ����ͳɳ��׶�,��������츳��,�ɶԻ������½����츳���</t></t>";


			case "SoulGeniusBnt_OpenSkillWnd":
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�鿴������</t><b/><t>1������Ļû����ܺͼ�������ֶ��ͷŵ��츳������ʾ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ɫ���ܽ��滯����ҳ</t><t>��</t><b/><t>2�����������϶�����ͼ�����������</t></t>";

				//=====================================================================================�������ý���=============================================================================================================
			case "HotKeyPopup_ChatFirst"://��������
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ã�</t><t>���ú������һֱ���ڿ�����״̬</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>���ã�</t><t>���ú�Enter���������л�״̬</t></t>";

			case "HotKeyPopup_SelfSpell"://����ʩ��
				%ctrl.tooltipWidth = 310;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ã�</t><t>�ر�����ʩ����ݷ�ʽ</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>Alt��</t><t>��סAlt��,���ɶ�����ʩ�����漼��</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>Ctrl��</t><t>��סCtrl��,���ɶ�����ʩ�����漼��</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>Shift��</t><t>��סShift��,���ɶ�����ʩ�����漼��</t></t>";

			case "Hotkey_SetasCustomBtn"://�����Զ���
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����Զ���</t><b/><t>�ɽ���ǰ�Ĳ���ģʽ����Ϊ�Զ���ģʽ,�����ڸ�ģʽ�Ļ���������Ӧ�Ŀ�ݼ��޸�</t></t>";

				//=====================================================================================���ϵ�н���===============================================================================================================
			case "ShenTieRepair_ExplainBmp"://�������
				%ctrl.tooltipWidth = 340;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������˵����</t><b/><t>1���������������������Ƭ��Ԫ��</t><b/><t>������Ƭ����ͨ���:����֮����</t><b/><t>2������ĵ�ǰ�;ý�Ϊ0,������Խ����ܷ�������</t></t>";

			case "ShenTieMeltdown_ExplainBmp"://��������
				%ctrl.tooltipWidth = 370;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������˵����</t><b/><t>1����ɫ�ﵽ6�޲��ܽ�����������</t><b/><t>2����������ÿ������һ����������Һ</t><b/><t>3��������������Ϊ������Ƭ,������ƬΪ���Խ��׵���Ʒ</t><b/><t>4��1������+1����������Һ���Էֽ��3��������Ƭ</t></t>";

			case "ShenTieCompose_ExplainBmp"://�����ϳ�
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����ϳ�˵����</t><b/><t>1��5��������Ƭ+1����������Һ���Ժϳ�1������</t><b/><t>2���ϳɵ�����Ϊ���ɽ���</t></t>";

			case "ShenTieEnchase_ExplainBmp"://������Ƕ
				%ctrl.tooltipWidth = 370;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���������Ƕ˵����</t><b/><t>1��ÿ�����ֻ����Ƕһ���������</t><b/><t>2����Ƕ��������ܵȼ����벻�������ʹ�õȼ�</t><b/><t>3�������������Ƕ�������������һ��������ܡ����ʹ�õȼ�Խ�ߣ���ȡ�߼�������ܵĻ���Խ��</t><b/><t>4�����뼼���������ǶҪ��,����Ƕ100%�ɹ�</t></t>";

			case "ShenTiedeCompose_ExplainBmp"://����ֽ�
				%ctrl.tooltipWidth = 420;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ֽ�˵����</t><b/><t>1������ﵽ10�׼��ɷֽ�</t><b/><t>2������ֽ�ɹ��ɻ��һ����δ��������(δ���������ȼ�=�ֽ�����ȼ�+10)</t></t>";


				//===================================================================================����ܽ���==============================================================================================================================

			case "LivingSkillInfoLevelText":
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ȼ�</t><b/><t>������ߡ��������ޡ���İ���˷����ʼ������Ļ���ֵ����Ϊ�����������ֵ</t><b/><t c='0xff1200ff'>����ȼ���������߻���ֵ����</t></t>";

			case "LivingSkillInfoExpText":
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ȼ�����</t><b/><t>������ߡ��������ޡ���İ���˷����ʼ������Ļ���ֵ����Ϊ�����������ֵ</t><b/><t c='0xff1200ff'>����ȼ���������߻���ֵ����</t></t>";

			default:
				StartTooltip2(%ctrl);

	}

	//�Ի�����
	%FuncName = "StartTooltip_"@ %ctrl.GetName();

	//����isFunction
	if (isFunction(%FuncName))
		Call(%FuncName,%ctrl);
}


function StartTooltip2(%ctrl)
{
	%Player = GetPlayer();

	switch$(%ctrl.GetName())
	{

		//====================================================================================��������===========================================================================================================

			case "Mercenary_PetName"://��������
				%ctrl.tooltipWidth = 120;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�������Ը���</t></t>";

			case "Mercenary_ChangeNameButton"://������ť
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������ȷ��</t><b/><t>���������Ϊ�˸�����</t><b/><t>��꼤������������ʾ��,�������������ƺ�,����������ťȷ��</t></t>";

			case "Mercenary_ReBirth"://�ֻ�
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ֻصȼ�</t><b/><t>�������ֻصȼ���ÿһ���ֻض��������Լӳ�,׼���ֻص�������Ҫ���ֻؽ������ӵ�100%���ֻؽ���ͨ��������ʹ��'���ȵ���'������</t></t>";

			case "Mercenary_Level"://�ȼ�
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����ȼ�</t><b/><t>�ֻؿ������������ȼ���������Լӳ�</t></t>";

			case "Mercenary_Job"://ְҵ
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ְҵ</t><b/><t>��ְͬҵ�Ļ������Ժ͹�������Ӱ�첻ͬ</t></t>";

			case "Mercenary_intelligencePoint"://Ʒ��
				%ctrl.tooltipWidth = 320;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ʒ��</t><b/><t>Ʒ��ÿ����1��,���гɳ���������100��</t>";

			case "Mercenary_LearnInfo1_add"://��������������ť
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������������</t><b/><t>Ӱ�������������ֵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ������5��</t></t>";

			case "Mercenary_LearnInfo1_dec"://��������������ť
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������������</t><b/><t>Ӱ�������������ֵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ�����5��</t></t></t>";

			case "Mercenary_LearnInfo2_add"://�����﹥������ť
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���������﹥����</t><b/><t>Ӱ���������������ֵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ������5��</t></t></t>";

			case "Mercenary_LearnInfo2_dec"://�����﹥������ť
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���������﹥����</t><b/><t>Ӱ���������������ֵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ�����5��</t></t></t>";

			case "Mercenary_LearnInfo3_add"://���ӷ���������ť
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������������</t><b/><t>Ӱ�����������������ֵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ������5��</t></t></t>";

			case "Mercenary_LearnInfo3_dec"://���ٷ���������ť
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������������</t><b/><t>Ӱ�����������������ֵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ�����5��</t></t></t>";

			case "Mercenary_LearnInfo4_add"://�������������ť
				%ctrl.tooltipWidth = 170;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���������������</t><b/><t>Ӱ���������ܵ��������˺�����ֵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ������5��</t></t></t>";

			case "Mercenary_LearnInfo4_dec"://�������������ť
				%ctrl.tooltipWidth = 170;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���������������</t><b/><t>Ӱ���������ܵ��������˺�����ֵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ�����5��</t></t></t>";

			case "Mercenary_LearnInfo5_add"://���ӷ���������ť
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������������</t><b/><t>Ӱ���������ܵ��ķ����˺�����ֵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ������5��</t></t></t>";

			case "Mercenary_LearnInfo5_dec"://���ٷ���������ť
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������������</t><b/><t>Ӱ���������ܵ��ķ����˺�����ֵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ�����5��</t></t></t>";

			case "Mercenary_LearnInfo6_add"://������������ť
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������������</t><b/><t>Ӱ���������������ܵĸ���</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ������5��</t></t></t>";

			case "Mercenary_LearnInfo6_dec"://������������ť
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������������</t><b/><t>Ӱ���������������ܵĸ���</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ�����5��</t></t></t>";

			case "Mercenary_LearnInfo7"://Ǳ��
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����������õ�Ǳ�ܵ�</t><b/><t>����ÿ��1���ɻ��5��Ǳ��</t><b/><t>�����ɷ��䵽��������,�﹥����,��������,�������,��������,������������</t></t>";

			case "Mercenary_LearnInfo1"://��������
				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>���������������</t>";

			case "Mercenary_LearnInfo2"://�﹥����
				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����﹥����</t><b/><t>��������﹥ֵ</t>";

			case "Mercenary_LearnInfo3"://��������
				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>�����������ֵ</t>";

			case "Mercenary_LearnInfo4"://�������
				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����������</t><b/><t>����������ֵ</t>";

			case "Mercenary_LearnInfo5"://��������
				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>�����������ֵ</t>";

			case "Mercenary_LearnInfo6"://������
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������</t><b/><t>Ӱ�������ı��������ܼ���</t>";

			case "Mercenary_HealthBar"://��������ֵ
				%ctrl.tooltipWidth = 305;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������ֵ</t><b/><t>������ǰ����ֵΪ0ʱ,�������������ջ�</t><b/><t>ͨ�������ơ����Իָ������ĵ�ǰ����ֵ</t><b/><t>������Ҫ���Ľ�ҩ,���������˴�����</t></t>";

			case "Mercenary_loyaltyBar"://��������ֵ
				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������ֵ</t><b/><t>����������������ս����ֵ���½�</t><b/><t>������ֵ����60ʱ�������޷��ٻ�</t><b/><t>�ɡ��ʹ͡��������������������ֵ</t></t>";

			case "Mercenary_ExpBar"://��������
				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>������ǰ����ֵ/����������һ������ֵ</t>";

			case "Mercenary_Treat"://��������
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>������ƿ���������������ֵ</t><b/><t>��������Ҫ�����������Ʒ</t>";

			case "Mercenary_Largess"://�����ʹ�
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ʹ�</t><b/><t>����ʹͿ����������Ŀ��ֶ�</t><b/><t>��������Ҫ����������</t>";

			case "Mercenary_Attack1"://��������
				%ctrl.tooltipWidth = 175;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������������������ࣩ</t><b/><t>�����������˺�ֵ</t>";

			case "Mercenary_Attack2"://������
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����������������ࣩ</t><b/><t>�����������˺�ֵ</t>";

			case "Mercenary_Attack3"://��������
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������������������ࣩ</t><b/><t>�����ķ����˺�ֵ</t>";

			case "Mercenary_Attack4"://��������
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>������������������</t><b/><t c='0xF450CFff'>��������Խ������������������������Խ��</t></t>";

			case "Mercenary_Attack5"://��������
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>�����ķ�����������</t><b/><t c='0xF450CFff'>��������Խ�������������ķ�����������Խ��</t></t>";

			case "Mercenary_Attack6"://��������
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>������������������</t><b/><t c='0xF450CFff'>��������Խ�������ܶ�������������Խ��</t></t>";

			case "Mercenary_Attack7"://��������
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>�����ķ�����������</t><b/><t c='0xF450CFff'>��������Խ�������ܶ��ַ�����������Խ��</t></t>";

			case "Mercenary_Defence1"://��������
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�ܵ����������˺�ʱ������Ӧ���˺�</t></t>";

			case "Mercenary_Defence2"://�������
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t><b/><t>�ܵ��������˺�ʱ������Ӧ���˺�</t></t>";

			case "Mercenary_Defence3"://��������
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�ܵ����������˺�ʱ������Ӧ���˺�</t></t>";

			case "Mercenary_Defence4"://��ϵ����
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ϵ����</t><b/><t>�ܵ����鹥���˺�ʱ������Ӧ���˺�</t></t>";

			case "Mercenary_Defence5"://��ϵ����
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ϵ����</t><b/><t>�ܵ����鹥���˺�ʱ������Ӧ���˺�</t></t>";

			case "Mercenary_Defence6"://��ϵ����
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ϵ����</t><b/><t>�ܵ����鹥���˺�ʱ������Ӧ���˺�</t></t>";

			case "Mercenary_Defence7"://��ϵ����
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ϵ����</t><b/><t>�ܵ����鹥���˺�ʱ������Ӧ���˺�</t></t>";

			case "Mercenary_Defence8"://��ϵ����
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ϵ����</t><b/><t>�ܵ����鹥���˺�ʱ������Ӧ���˺�</t></t>";

			case "Mercenary_Other1"://��������
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>��߽�ɫ���������˺��ļ���,��ֵԽ�߱�������Խ��</t></t>";

			case "Mercenary_Other2"://��������
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>��ֵԽ�߷�ֹ�������ʾ�Խ��</t></t>";

			case "Mercenary_Other3"://������������
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���������˺��������ͨ�˺�������ֵ</t></t>";

			case "Mercenary_Other4"://��������������
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������</t><b/><t>�ܵ�������Ա����˺��ļ���</t></t>";

			case "Mercenary_Other5"://���������������
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����������</t><b/><t>������ʱ�ɺ��ӶԷ����������</t></t>";

			case "Mercenary_Other6"://�������ӷ�������
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ӷ�������</t><b/><t>��������ʱ�ɺ��ӶԷ��ķ�������</t></t>";

			case "Mercenary_Other7"://���������ٶ�
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����ٶ�</t><b/><t>��õĹ����ٶȼӳ�</t></t>";

			case "Mercenary_GrowUpInfo1"://��������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조��������������������ֵ���޵ļӳ�</t>";

			case "Mercenary_GrowUpInfo2"://�﹥����
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����﹥����</t><b/><t>Ӱ�조�﹥�������������﹥ֵ�ļӳ�</t>";

			case "Mercenary_GrowUpInfo3"://��������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조��������������������ֵ�ļӳ�</t>";

			case "Mercenary_GrowUpInfo4"://�������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����������</t><b/><t>Ӱ�조������������������ֵ�ļӳ�</t>";

			case "Mercenary_GrowUpInfo5"://��������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조��������������������ֵ�ļӳ�</t>";

			case "Mercenary_GrowUpInfo6"://������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������</t><b/><t>Ӱ�조������������������ֵ�ͱ����ʵļӳ�</t>";

			case "Mercenary_ExploitBar"://��ѫֵ
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������ѫֵ</t><b/><t>��δ����,�����ڴ�</t>";

			case "Mercenary_AttriState"://������������ 1�佫 2���� 3��ʿ 5���� 4��ʿ
				%ctrl.tooltipWidth = 210;
				%nslot = getMerJob($SelectedMercenarySlot);
				if (%nslot== 3){ %HongJi="��������";%JiaDian="<t gct='0x00ff00ff' gcb='0x2cffeeff'>��������</t><t>Խ�ߣ��˺����Խ��</t>"; }
				else                   { %HongJi="������";%JiaDian="<t gct='0x00ff00ff' gcb='0x2cffeeff'>�﹥����</t><t>Խ�ߣ��˺����Խ��</t>"; }

				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������ͣ�"@ %HongJi @"</t><b/><t>"@ %JiaDian @"</t></t>";

				//====================================================================================���޽���===========================================================================================================

			case "PetInfoGui_ghxz":
				%ctrl.tooltipWidth = 385;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������,�Զ�Ѱ��������Ľ���Ĵ�������������</t><b/><t>�����������������·�ʽ��</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>1��Ʒ�׽��ף�</t><t>����Ʒ��ÿ����1��,���гɳ���������100��</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>2������������</t><t>�Ը��Ǵ���0�����޽���������ø��ǵ�</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>3�����޾�����</t><t>�����ޱ����ͱ��챦������������޼�����</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>4������ϴ����</t><t>������̥���ǵ�1��,����һ���ĳɳ�����</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>5�����޷�ֳ��</t><t>�����Ե����ޱ�����ֳ��һ������</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>6�����޼���ѧϰ��</t><t>ͨ���μӻ���̳ǹ����ü�����,ͨ��ѧϰ�������޵ļ���</t></t>";


			case "PetInfoWnd_PetShortCut5"://

				if (PetInfoWnd_PetSlot_Image_5.Isvisible())
				{
					%ctrl.tooltipWidth = 220;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����������λ</t><b/><t>ʹ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>������</t><t>������������λ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>������</t><t>���������ؾ��̳��ڹ���</t></t>";
				}

			case "PetInfoWnd_PetShortCut6"://

				if (PetInfoWnd_PetSlot_Image_6.Isvisible())
				{
					%ctrl.tooltipWidth = 220;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����������λ</t><b/><t>ʹ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>������</t><t>������������λ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>������</t><t>���������ؾ��̳��ڹ���</t></t>";
				}

			case "PetInfoWnd_PetShortCut7"://

				if (PetInfoWnd_PetSlot_Image_7.Isvisible())
				{
					%ctrl.tooltipWidth = 220;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����������λ</t><b/><t>ʹ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>������</t><t>������������λ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>������</t><t>���������ؾ��̳��ڹ���</t></t>";
				}


			case "PetInfoWnd_PetShortCut8"://
				if (PetInfoWnd_PetSlot_Image_8.Isvisible())
				{
					%ctrl.tooltipWidth = 220;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����������λ</t><b/><t>ʹ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>������</t><t>������������λ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>������</t><t>���������ؾ��̳��ڹ���</t></t>";
				}


			case "PetInfoWnd_PetActType"://��������
				%ctrl.tooltipWidth = 210;
				%nslot = PetOperation_GetPetAttackType($PetInfoWnd_PetSlot);
				if (%nslot==0){ %HongJi="������";%JiaDian="<t>����</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>����</t><t>�ɼ�ǿ������Ч��</t>"; }

				else  { %HongJi="��������";%JiaDian="<t>����</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>����</t><t>�ɼ�ǿ��������Ч��</t>"; }

				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������ͣ�"@ %HongJi @"</t><b/><t>"@ %JiaDian @"</t></t>";

			case "PetInfoWnd_PetRank"://Ǳ��
				%ctrl.tooltipWidth = 290;
				%IsIdentify = PetOperation_IsPetIdentify($PetInfoWnd_PetSlot);

				if (%IsIdentify)
				{
					%nChengZhangLv = PetOperation_GetPetChengZhangLv($PetInfoWnd_PetSlot);
					if (%nChengZhangLv >= 18 && %nChengZhangLv < 840){ %PinZhi = "<t c= '0xffffffff'>����ͨ��</t>"; }
					else if (%nChengZhangLv >= 840 && %nChengZhangLv < 1560){ %PinZhi = "<t c= '0x46ff15ff'>�����㡹</t>"; }
					else if (%nChengZhangLv >= 1560 && %nChengZhangLv < 2220){ %PinZhi = "<t c= '0x226fffff'>����Ӣ��</t>"; }
					else if (%nChengZhangLv >= 2220 && %nChengZhangLv < 2860){ %PinZhi = "<t c= '0xca57ffff'>��������</t>"; }
					else if (%nChengZhangLv >= 2860 && %nChengZhangLv < 3300){ %PinZhi = "<t c= '0xff9600ff'>����˵��</t>"; }
					else if (%nChengZhangLv >= 3300){ %PinZhi = "<t c= '0xff1200ff'>�����졹</t>"; }

					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰ����Ǳ��Ϊ��</t>"@ %PinZhi @"<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ͨ������ϴ�������ɸı�����Ǳ��</t><b/><t>��ͨ�����޼ӵ�ʱ������������Գɳ�</t><b/><t c='0x26da13ff'>���㣺���޼ӵ�ʱ��ö���20%�����Գɳ�</t><b/><t c='0x226fffff'>��Ӣ�����޼ӵ�ʱ��ö���40%�����Գɳ�</t><b/><t c='0xca57ffff'>���������޼ӵ�ʱ��ö���60%�����Գɳ�</t><b/><t c='0xff9600ff'>��˵�����޼ӵ�ʱ��ö���80%�����Գɳ�</t><b/><t c='0xff1200ff'>���죺���޼ӵ�ʱ��ö���100%�����Գɳ�</t></t>";
				}
				else
				{
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ǳ��   </t><t c= '0xff1200ff'>δ����</t><b/><t c='0x5adfffff'>����Ľ���Ĵ�����Ǳ��</t><b/><t>��ͨ�����޼ӵ�ʱ������������Գɳ�</t><b/><t c='0x26da13ff'>���㣺���޼ӵ�ʱ��ö���20%�����Գɳ�</t><b/><t c='0x226fffff'>��Ӣ�����޼ӵ�ʱ��ö���40%�����Գɳ�</t><b/><t c='0xca57ffff'>���������޼ӵ�ʱ��ö���60%�����Գɳ�</t><b/><t c='0xff9600ff'>��˵�����޼ӵ�ʱ��ö���80%�����Գɳ�</t><b/><t c='0xff1200ff'>���죺���޼ӵ�ʱ��ö���100%�����Գɳ�</t></t>";
				}

			case "PetInfoWnd_PetDevelopRate"://Ǳ��
				%ctrl.tooltipWidth = 290;

				%IsIdentify = PetOperation_IsPetIdentify($PetInfoWnd_PetSlot);

				if (%IsIdentify)
				{
					%nChengZhangLv = PetOperation_GetPetChengZhangLv($PetInfoWnd_PetSlot);
					if (%nChengZhangLv >= 18 && %nChengZhangLv < 840){ %PinZhi = "<t c= '0xffffffff'>����ͨ��</t>"; }
					else if (%nChengZhangLv >= 840 && %nChengZhangLv < 1560){ %PinZhi = "<t c= '0x46ff15ff'>�����㡹</t>"; }
					else if (%nChengZhangLv >= 1560 && %nChengZhangLv < 2220){ %PinZhi = "<t c= '0x226fffff'>����Ӣ��</t>"; }
					else if (%nChengZhangLv >= 2220 && %nChengZhangLv < 2860){ %PinZhi = "<t c= '0xca57ffff'>��������</t>"; }
					else if (%nChengZhangLv >= 2860 && %nChengZhangLv < 3300){ %PinZhi = "<t c= '0xff9600ff'>����˵��</t>"; }
					else if (%nChengZhangLv >= 3300){ %PinZhi = "<t c= '0xff1200ff'>�����졹</t>"; }

					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰ����Ǳ��Ϊ��</t>"@ %PinZhi @"<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ͨ������ϴ�������ɸı�����Ǳ��</t><b/><t>��ͨ�����޼ӵ�ʱ������������Գɳ�</t><b/><t c='0x26da13ff'>���㣺���޼ӵ�ʱ��ö���20%�����Գɳ�</t><b/><t c='0x226fffff'>��Ӣ�����޼ӵ�ʱ��ö���40%�����Գɳ�</t><b/><t c='0xca57ffff'>���������޼ӵ�ʱ��ö���60%�����Գɳ�</t><b/><t c='0xff9600ff'>��˵�����޼ӵ�ʱ��ö���80%�����Գɳ�</t><b/><t c='0xff1200ff'>���죺���޼ӵ�ʱ��ö���100%�����Գɳ�</t></t>";
				}
				else
				{
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ǳ��   </t><t c= '0xff1200ff'>δ����</t><b/><t c='0x5adfffff'>����Ľ���Ĵ�����Ǳ��</t><b/><t>��ͨ�����޼ӵ�ʱ������������Գɳ�</t><b/><t c='0x26da13ff'>���㣺���޼ӵ�ʱ��ö���20%�����Գɳ�</t><b/><t c='0x226fffff'>��Ӣ�����޼ӵ�ʱ��ö���40%�����Գɳ�</t><b/><t c='0xca57ffff'>���������޼ӵ�ʱ��ö���60%�����Գɳ�</t><b/><t c='0xff9600ff'>��˵�����޼ӵ�ʱ��ö���80%�����Գɳ�</t><b/><t c='0xff1200ff'>���죺���޼ӵ�ʱ��ö���100%�����Գɳ�</t></t>";
				}

			case "PetInfoWnd_PetColligate"://Я���ȼ�

				%PetLv = PetOperation_GetPetLevel($PetInfoWnd_PetSlot);
				%NeedLv = PetOperation_GetPetSpawnLevel($PetInfoWnd_PetSlot);
				%playerLv = GetPlayer().getLevel();
				%FinNeedLv = 0;
				if (%PetLv - 10 <= %NeedLv)
					%FinNeedLv = %NeedLv;
				else
					%FinNeedLv = %PetLv - 10;

				if (%playerLv < %FinNeedLv){ %txt ="<b/><t c= '0xff0000ff'>���Ľ�ɫ�ȼ�δ�ﵽ����Я���ȼ����޷��ٻ����޳�ս</t>"; }

				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Я���ȼ�</t><b/><t>��ɫ�ȼ����ڵ���Я���ȼ�������Я������</t>"@ %txt @"</t>";

			case "PetInfoWnd_NeedPlayerLevel"://Я���ȼ�

				%PetLv = PetOperation_GetPetLevel($PetInfoWnd_PetSlot);
				%NeedLv = PetOperation_GetPetSpawnLevel($PetInfoWnd_PetSlot);
				%playerLv = GetPlayer().getLevel();
				%FinNeedLv = 0;
				if (%PetLv - 10 <= %NeedLv)
					%FinNeedLv = %NeedLv;
				else
					%FinNeedLv = %PetLv - 10;

				if (%playerLv < %FinNeedLv){ %txt ="<b/><t c= '0xff0000ff'>���Ľ�ɫ�ȼ�δ�ﵽ����Я���ȼ����޷��ٻ����޳�ս</t>"; }

				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Я���ȼ�</t><b/><t>��ɫ�ȼ����ڵ���Я���ȼ�������Я������</t>"@ %txt @"</t>";

			case "PetInfoWnd_PetName"://��������
				%ctrl.tooltipWidth = 120;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���޿��Ը���</t></t>";

			case "PetInfoWnd_CnangeNameButton"://������ť
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޸���ȷ��</t><b/><t>���������Ϊ�˸�����</t><b/><t>��꼤������������ʾ��,�������������ƺ�,����������ťȷ��</t></t>";

			case "PetInfoWnd_PetTitle"://���޳ƺ�
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޳ƺ�</t><b/><t>�����޵�Ʒ�ס�Ǳ�������ʴﵽһ������,����������ѵ��ʦ-</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>Ľ����</t><t>����ȡ�ƺ�</t></t>";

			case "PetInfoWnd_PetLevel"://���޵ȼ�
				%ctrl.tooltipWidth = 120;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޵ȼ�</t><b/><t>���޵�ǰ�ĵȼ�</t></t>";

			case "PetInfoWnd_PetStatus"://����״̬
				%nStatus = PetOperation_GetPetStatus($PetInfoWnd_PetSlot);
				if (%nStatus == 1){ %PetStatus = "��ս״̬"; }
				else if (%nStatus == 2){ %PetStatus = "����״̬"; }
				else if (%nStatus == 4)
				{
					%PetStatus = "����״̬";
					%nLeftTime = TimerCtrlMgr_GetPetStudyLeftTime($PetInfoWnd_PetSlot);

					%minute = %nLeftTime % 60;
					%hour = (%nLeftTime - %minute) / 60;
					if (%nLeftTime >=60)     { %Time = "<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ʣ��ʱ�䣺"@ %hour @ "Сʱ" @ %minute @ "����</t>"; }
					else if (%nLeftTime >= 1){ %Time = "<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ʣ��ʱ�䣺"@ %minute @ "����</t>"; }
					else if (%nLeftTime < 1) { %Time = "<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ʣ��ʱ�䣺С��1����</t>"; }
				}
				else if (%nStatus == 7){ %PetStatus = "��ֳ��״̬";%Time ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>������ֳ���̻����2��Сʱ,��ɷ�ֳ��,˫������Ľ���ĶԻ���ȡ�������ޱ���</t>"; }
				else if (%nStatus == 8){ %PetStatus = "��ֳ���״̬";%Time ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ǰ���������Ѿ���ֳ���,˫��ǰ��Ľ���ĶԻ�������ȡ�������ޱ���</t>"; }

				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޴���"@ %PetStatus @"</t><b/><t>"@ %PetStatus @"�����޽����ܽ��з��������ס������������Ȳ���</t>"@ %Time @"</t>";


				//		case "PetInfoWnd_PetRace"://��������
				//			%nType = PetOperation_GetPetType($PetInfoWnd_PetSlot);
				//			if(%nType ==0 ){%PetType = "����";}
				//			else if(%nType ==1 ){%PetType = "ˮ��";}
				//			else if(%nType ==2 ){%PetType = "����";}
				//			else if(%nType ==3 ){%PetType = "����";}
				//			else if(%nType ==4 ){%PetType = "��ڤ";}
				//			else if(%nType ==5 ){%PetType = "ֲ��";}
				//			else if(%nType ==6 ){%PetType = "����";}
				//			else if(%nType ==7 ){%PetType = "�Ϲ�";}
				//			else if(%nType ==8 ){%PetType = "����";}
				//			else if(%nType ==9 ){%PetType = "����";}
				//			%ctrl.tooltipWidth = 130;
				//			%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������Ϊ"@ %PetType @"</t></t>";
				//

			case "PetInfoWnd_TuJianButton":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ͼ��</t><b/><t>�������ʾ�����������б������������</t></t>";

			case "PetInfoWnd_Duoming"://���޵Ķ�����ť
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޵��������</t><b/><t>����ӵ�еļ�Ʒ�����ϴ������а�������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�����������������ٴ��ϴ���ϵͳ���ܸ�����������������Ϣ</t></t>";

			case "PetInfoWnd_Bnt_Evaluation"://�������۰�ť
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>������ǰ�������������Ը���ֱ�۵���ʾ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����������Ϣҳ���˽�ͬ������޵����ʱȽ�</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>ͬ����������Ϣҳ���˽���ͬ�������޵����ʱȽ�</t></t>";

			case "PetInfoWnd_PetPaiMing"://��������
				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�����а��������ڿɲ鿴���������޵��ۺ�ֵ����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�������ֶ��ϴ������а��ڣ������������������ٴ��ϴ���ϵͳ���ܸ�����������������Ϣ</t></t>";

			case "PetInfoWnd_PetPaiMing"://��������
				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�����а��������ڿɲ鿴���������޵��ۺ�ֵ����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�������ֶ��ϴ������а��ڣ������������������ٴ��ϴ���ϵͳ���ܸ�����������������Ϣ</t></t>";

			case "PetInfoWnd_PetOpen"://�����ٻ�
				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ٻ�����</t><b/><t>ֻ���ٻ������ڽ�ɫ1�޵�����</t><b/><t>����Ʒ��ÿ��1��,Ҫ���ɫ�ȼ����1��</t></t>";

			case "PetInfoWnd_PetClose"://ȡ���ٻ�
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ջ�����</t><b/><t>ֻ���ٻ������ڽ�ɫ1�޵�����</t></t>";

			case "PetInfoWnd_PetSkill"://���޼�����
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޼���ҳ</t><b/><t>���޵ı��������Լ�����ֶ��ͷŵļ���</t><b/><t>ͨ���μӻ���̳ǹ��������޼�����,��Ľ�����ǿ�������ѧ�Ἴ���鼼��</t></t>";

			case "PetInfoWnd_PetAbility"://����������
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������ҳ</t><b/><t>����������һ�����ʿ���������������</t><b/><t>������������ͼ����Ըı��Ը񱬷�ʱ�������ͷ�˳��</t></t>";

			case "PetInfoWnd_HP"://��������ֵ
				%ctrl.tooltipWidth = 305;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������ֵ</t><b/><t>���޵�ǰ����ֵΪ0ʱ,���޽��������ջ�</t><b/><t>ͨ�������ơ����Իָ����޵ĵ�ǰ����ֵ</t><b/><t>������Ҫ����Ѫ��,�������������˴�����</t></t>";

				//		case "PetInfoWnd_MP"://���޾���ֵ
				//			%ctrl.tooltipWidth = 305;
				//			%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾���ֵ</t><b/><t>����ʩ�ż���ʱ��Ҫ���ľ���ֵ</t><b/><t>��������������Իָ����޵ĵ�ǰ����ֵ</t><b/><t>������Ҫ�������ʯ,�������������˴�����</t></t>";

			case "PetInfoWnd_Happy"://���޿���
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޿��ֶ�</t><b/><t>������������ֶȻ��½�</t><b/><t>�����ֶȵ���60ʱ���޽��޷��ٻ�</t><b/><t>�����������˴�������������������޿��ֶ�</t></t>";

			case "PetInfoWnd_Exp"://���޾���
				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾���</t><b/><t>���޵�ǰ����ֵ/����������һ������ֵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�����޵ȼ����ڵ��ڽ�ɫ�ȼ�5��ʱ�����޽��޷��ٻ�����޾���</t></t>";

			case "PetInfoWnd_PetFeeding1"://��������
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>������ƿ��������޵�����ֵ</t><b/><t>��������Ҫ�����������Ʒ</t></t>";

				//		case "PetInfoWnd_PetFeeding2"://���޲���
				//			%ctrl.tooltipWidth = 210;
				//			%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>����������������޵ľ���ֵ</t><b/><t>��������Ҫ����ز�����Ʒ</t></t>";

			case "PetInfoWnd_PetDomestication"://�����ʹ�
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ʹ�</t><b/><t>����ʹͿ��������޵Ŀ��ֶ�</t><b/><t>��������Ҫ�����������Ʒ</t></t>";

			case "PetInfoWnd_PetSetFree"://���޷���
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޷���</t><b/><t>����������޽�����������ʧ����ȫʱ�䡢��ս�����塢���С�������״̬�µ������޷�����</t></t>";

			case "PetInfoWnd_PetLock"://��������
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�����޽��м���</t><b/><t>���޼����󽫲��ܱ�����������</t></t>";

			case "PetInfoWnd_PetStudy"://��������
				%ctrl.tooltipWidth = 225;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ڿ���״̬�����޿ɽ�����Ӧ������</t></t>";

			case "HeTiAttribute_bmp"://�����������ֵ�˵��       
				%nPetHTshuxing = Pet_getCombinationInfo($PetInfoWnd_PetSlot);//��ȡ��ǰѡ�����޵ĺ��帽������
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12' c='0xf3d300ff' o='0x010101ff'>���޺��帽�����ԣ�</t><b/>"@ %nPetHTshuxing @"<b/><t m='1' f='����' n='12'>���޵�</t><t m='1' f='����' n='12' gct='0x00ff00ff' gcb='0x2cffeeff'>�ȼ���Ʒ�ס����ʡ�Ǳ��������ȼ������ܸ���</t><t m='1' f='����' n='12'>����Ӱ����帽�ӵ����Դ�С</t>";


			case "PetInfoWnd_PetPatron"://���޺��帽������˵��       
				%nPetHTshuxing = Pet_getCombinationInfo($PetInfoWnd_PetSlot);//��ȡ��ǰѡ�����޵ĺ��帽������
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12' c='0xf3d300ff' o='0x010101ff'>���޺��帽�����ԣ�</t><b/>"@ %nPetHTshuxing @"<b/><t m='1' f='����' n='12'>���޵�</t><t m='1' f='����' n='12' gct='0x00ff00ff' gcb='0x2cffeeff'>�ȼ���Ʒ�ס����ʡ�Ǳ��������ȼ������ܸ���</t><t m='1' f='����' n='12'>����Ӱ����帽�ӵ����Դ�С</t>";

			case "PetInfoWnd_Tooltip1"://Ʒ��
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ʒ��</t><b/><t>Ʒ��ÿ����1�㣬���гɳ���������100�㡣</t><b/><t>����Ʒ����Ҫ������۹���</t></t>";

			case "PetInfoWnd_Tooltip2"://����
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޸���</t><b/><t>Ӱ�������������õ���۹���</t><b/><t>��۹�������������Ʒ�ף�������޵ĳɳ����ʡ�</t></t>";

			case "PetInfoWnd_Tooltip3"://����
				%mainAttri =GetMainAttribute($PetInfoWnd_PetSlot);//1 ���� 2 ���� 3 ����

				%nslot = PetOperation_GetPetAttackType($PetInfoWnd_PetSlot);
				if (%nslot == 0)
				{
					if (%mainAttri == 3){ %mainAttri1="</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>[�Ƽ�����]"; }
					%ctrl.tooltipWidth = 160;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������  "@ %mainAttri1 @"</t><b/><t>��������������˺�</t></t>";
				}
				else
				{
					if (%mainAttri == 2){ %mainAttri1="</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>[�Ƽ�����]"; }
					%ctrl.tooltipWidth = 160;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������  "@ %mainAttri1 @"</t><b/><t>������޷��������˺�</t></t>";
				}

			case "PetInfoWnd_Tooltip5"://����
				%mainAttri =GetMainAttribute($PetInfoWnd_PetSlot);//1 ���� 2 ���� 3 ����
				if (%mainAttri == 1){ %mainAttri1="</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>[�Ƽ�����]"; }

				%ctrl.tooltipWidth = 175;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������  "@ %mainAttri1 @"</t><b/><t>��������������ֵ</t></t>";

			case "PetInfoWnd_Tooltip6"://����
				%ctrl.tooltipWidth = 165;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾���  "@ %mainAttri1 @"</t><b/><t>������������������������</t></t>";

			case "PetInfoWnd_Tooltip7"://��
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t>Ӱ�����޵����ܺͱ�������</t></t>";

			case "PetInfoWnd_Tooltip8"://����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>������������˺�</t></t>";

			case "PetInfoWnd_Tooltip9"://Ǳ��
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����������õ�Ǳ����</t><b/><t>����ÿ��1���ɻ��5��Ǳ��</t><b/><t>�����ɷ��䵽���ǡ�����������������������������</t></t>";

			case "PetInfoWnd_Tooltip10"://����ȼ�
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��߱���ȼ���</t><b/><t>����ȼ�Խ�ߣ����޵�����Խ�ߣ�Ѫ��Խ�ߡ��������ض�����ȼ���ı����Ρ�</t><b/><t>����ͨ�����ɾ���������߱����������������ȼ���</t></t>";

			case "PetInfoWnd_PetHuiGen"://Ʒ��
				%ctrl.tooltipWidth = 320;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ʒ��</t><b/><t>Ʒ��ÿ����1��,���гɳ���������100��</t><b/><t>���޴ﵽ1�޺󼴿ɵ�Ľ���Ĵ�����Ʒ������</t><b/><t>������Ҫ���ĸ��ǵ�,ͨ���������и��ǵ����޿��Ի�ø��ǵ�</t></t>";

			case "PetInfoWnd_PetGenGu"://����
				%ctrl.tooltipWidth = 310;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޸���</t><b/><t>Ӱ�������������õĸ��ǵ�</t><b/><t>���ǵ�������������Ʒ��,������޵ĳɳ�����</t></t>";

			case "PetInfoWnd_PetTiPo"://����
				%mainAttri =GetMainAttribute($PetInfoWnd_PetSlot);//1 ���� 2 ���� 3 ����
				if (%mainAttri == 1){ %mainAttri1="</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>[�Ƽ�����]"; }

				%ctrl.tooltipWidth = 155;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������� "@ %mainAttri1 @"</t><b/><t>��������������ֵ</t></t>";

			case "PetInfoWnd_PetJingLi"://����
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾���</t><b/><t>������������������������</t></t>";

			case "PetInfoWnd_PetLiDao"://���� �������ԣ�����OR����
				%mainAttri =GetMainAttribute($PetInfoWnd_PetSlot);//1 ���� 2 ���� 3 ����
				%nslot = PetOperation_GetPetAttackType($PetInfoWnd_PetSlot);
				if (%nslot==0)
				{
					if (%mainAttri == 3)
					{
						%mainAttri1="<t gct='0x00ff00ff' gcb='0x2cffeeff'>[�Ƽ�����]</t><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�����������������ֵ��������޷��������˺�</t>";
					}
					else if (%mainAttri == 1)
					{
						%mainAttri1="<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�����������������ֵ����������������˺�</t>";
					}
				}
				else {
					if (%mainAttri == 2)
					{
						%mainAttri1="<t gct='0x00ff00ff' gcb='0x2cffeeff'>[�Ƽ�����]</t><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�������޷����������ֵ��������޷��������˺�</t>";
					}
					else if (%mainAttri == 1)
					{
						%mainAttri1="<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�������޷����������ֵ��������޷��������˺�</t>";
					}
				}
				%ctrl.tooltipWidth = 175;
				%ctrl.tooltip = "<t m='1' f='����' n='12'>"@ %mainAttri1 @"</t>";


			case "PetInfoWnd_PetLingLi"://����
				%mainAttri =GetMainAttribute($PetInfoWnd_PetSlot);//1 ���� 2 ���� 3 ����
				if (%mainAttri == 2){ %mainAttri1="</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>[�Ƽ�����]"; }
				%ctrl.tooltipWidth = 175;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������  "@ %mainAttri1 @"</t><b/><t>�������޷����������ֵ��������޷��������˺�</t></t>";

			case "PetInfoWnd_PetMingJie"://��
				%ctrl.tooltipWidth = 195;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t>Ӱ�����޵����ܺͱ�������</t></t>";

			case "PetInfoWnd_PetYuanLi"://����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>������������˺�</t></t>";

			case "PetInfoWnd_PetQianLi"://Ǳ��
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����������õ�Ǳ����</t><b/><t>����ÿ��1���ɻ��5��Ǳ��</t><b/><t>�����ɷ��䵽���ǡ�����������������������������</t></t>";

			case "PetInfoWnd_PetTiPoAdd"://�������ǰ�ť
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�������������ֵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ������5��</t></t>";

			case "PetInfoWnd_PetTiPoDec"://�������ǰ�ť
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�������������ֵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ�����5��</t></t></t>";

			case "PetInfoWnd_PetJingLiAdd"://���Ӿ�����ť
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������޾���</t><b/><t>Ӱ�����������������������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ������5��</t></t></t>";

			case "PetInfoWnd_PetJingLiDec"://���پ�����ť
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������޾���</t><b/><t>Ӱ�����������������������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ�����5��</t></t></t>";

			case "PetInfoWnd_PetLiDaoAdd"://����������ť
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ���������������ֵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ������5��</t></t></t>";

			case "PetInfoWnd_PetLiDaoDec"://����������ť
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ���������������ֵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ�����5��</t></t></t>";

			case "PetInfoWnd_PetLingLiAdd"://����������ť
				%ctrl.tooltipWidth = 170;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�����޷��������˺�</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ������5��</t></t></t>";

			case "PetInfoWnd_PetLingLiDec"://����������ť
				%ctrl.tooltipWidth = 170;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�����޷��������˺�</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ�����5��</t></t></t>";

			case "PetInfoWnd_PetMingJieAdd"://��������ť
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������</t><b/><t>Ӱ�����޵����ܺͱ�������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ������5��</t></t></t>";

			case "PetInfoWnd_PetMingJieDec"://��������ť
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������</t><b/><t>Ӱ�����޵����ܺͱ�������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ�����5��</t></t></t>";

			case "PetInfoWnd_PetYuanLiAdd"://����������ť
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ��������������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ������5��</t></t></t>";

			case "PetInfoWnd_PetYuanLiDec"://����������ť
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ��������������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ����һ�����5��</t></t></t>";

			case "Attack_Physics"://������
				%ctrl.tooltipWidth = 175;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����������������ࣩ</t><b/><t>���޵������˺�ֵ</t></t>";

			case "Attack_YuanLi"://��������
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޷��������������ࣩ</t><b/><t>���޵ķ����˺�ֵ</t></t>";

			case "Attack_NeiLi"://��������
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>���޵������˺�ֵ</t></t>";

			case "Attack_Mu"://ľ
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>���޵�������������</t><b/><t c='0xF450CFff'>��������Խ������������������������Խ��</t></t>";

			case "Attack_Huo"://��
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޷�������</t><b/><t>���޵ķ�����������</t><b/><t c='0xF450CFff'>��������Խ�������������ķ�����������Խ��</t></t>";

			case "Attack_Shui"://ˮ
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>���޵�������������</t><b/><t c='0xF450CFff'>��������Խ�������ܶ�������������Խ��</t></t>";

			case "Attack_Jin"://��
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޷�������</t><b/><t>���޵ķ�����������</t><b/><t c='0xF450CFff'>��������Խ�������ܶ��ַ�����������Խ��</t></t>";

			case "Attack_Tu"://��
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������ϵ�����������ࣩ</t><b/><t>���޵���ϵ�����˺�����</t><b/><t c='0xF450CFff'>��ϵ���������鷨���������˺�Ӱ��</t></t>";

			case "Recovery_Physics"://��������
				%ctrl.tooltipWidth = 275;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>���������˺�</t></t>";

			case "Recovery_YuanLi"://�������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����������</t><b/><t>�ܵ�������ʱ������Ӧ���˺�</t><b/><t c='0xF450CFff'>��������������������Ӱ��</t></t>";

			case "Recovery_Mu"://ľ����
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޷�������</t><b/><t>�ܵ���������ʱ������Ӧ���˺�</t><b/><t c='0xF450CFff'>���޷��������ܷ�������Ӱ��</t></t>";

			case "Recovery_Huo"://�����
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޻��鿹��</t><b/><t>������ϵ������ɵ��˺�</t><b/><t c='0xF450CFff'>������װ���Ϸ��������ͻ��鿹��Ӱ��</t></t>";

			case "Recovery_Shui"://ˮ����
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ˮ�鿹��</t><b/><t>������ϵ������ɵ��˺�</t><b/><t c='0xF450CFff'>������װ���Ϸ���������ˮ�鿹��Ӱ��</t></t>";

			case "Recovery_Jin"://�����
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޽��鿹��</t><b/><t>������ϵ������ɵ��˺�</t><b/><t c='0xF450CFff'>������װ���Ϸ��������ͽ��鿹��Ӱ��</t></t>";

			case "Recovery_Tu"://������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������鿹��</t><b/><t>������ϵ������ɵ��˺�</t><b/><t c='0xF450CFff'>������װ���Ϸ������������鿹��Ӱ��</t></t>";

			case "Other_BaoJiLv"://��������

				%ctrl.tooltipWidth = 165;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ޱ�������</t><b/><t>���������˺��������ͨ�˺�������ֵ</t></t>";

			case "Other_ShanBi"://����
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>����ֵԽ�����и��ߵĻ������ܶ��ֹ���</t></t>";

			case "Other_BaoJi"://����
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ޱ���</t><b/><t>�����޷��������˺�,����ͨ������ͨ�˺���</t></t>";

			case "Other_ZhiLiao"://����
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>����������ߵ�����ֵ</t></t>";

			case "MoveWnd2_TiPo"://��������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���ǡ�����������ֵ���޵ļӳ�</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>ͨ������ϴ���ɸı����޳ɳ�����</t></t>";

			case "MoveWnd2_JingLi"://��������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾�������</t><b/><t>Ӱ�조���񡱶�����������������������ļӳ�</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>ͨ������ϴ���ɸı����޳ɳ�����</t></t>";

			case "MoveWnd2_LiDao"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조�������������������ļӳ�</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>ͨ������ϴ���ɸı����޳ɳ�����</t></t>";

			case "MoveWnd2_LingLi"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���������������й����ļӳ�</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>ͨ������ϴ���ɸı����޳ɳ�����</t></t>";

			case "MoveWnd2_MinJie"://������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������</t><b/><t>Ӱ�조�������������ܺͱ����ļӳ�</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>ͨ������ϴ���ɸı����޳ɳ�����</t></t>";

			case "MoveWnd3_1"://��ֱ
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ֱ�Ը�</t><b/><t>�Ը�ȼ�Խ�ߣ�����ֱ�Ը�Ӱ��ļ����ͷż��ʾ�Խ��</t><b/><t>��ֱ�Ը񱬷�ʱ����ֱ�Ը�Ӱ��ļ����ͷż�����100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������п��Ըı��Ը�׶�</t></t>";

			case "MoveWnd3_2"://����
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����Ը�</t><b/><t>�Ը�ȼ�Խ�ߣ��ܻ����Ը�Ӱ��ļ����ͷż��ʾ�Խ��</t><b/><t>�����Ը񱬷�ʱ�������Ը�Ӱ��ļ����ͷż�����100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������п��Ըı��Ը�׶�</t></t>";

			case "MoveWnd3_3"://����
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����Ը�</t><b/><t>�Ը�ȼ�Խ�ߣ��������Ը�Ӱ��ļ����ͷż��ʾ�Խ��</t><b/><t>�����Ը񱬷�ʱ�������Ը�Ӱ��ļ����ͷż�����100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������п��Ըı��Ը�׶�</t></t>";

			case "MoveWnd3_4"://����
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����Ը�</t><b/><t>�Ը�ȼ�Խ�ߣ��������Ը�Ӱ��ļ����ͷż��ʾ�Խ��</t><b/><t>�����Ը񱬷�ʱ�������Ը�Ӱ��ļ����ͷż�����100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������п��Ըı��Ը�׶�</t></t>";

			case "MoveWnd3_5"://�侲
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�侲�Ը�</t><b/><t>�Ը�ȼ�Խ�ߣ����侲�Ը�Ӱ��ļ����ͷż��ʾ�Խ��</t><b/><t>�侲�Ը񱬷�ʱ���侲�Ը�Ӱ��ļ����ͷż�����100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������п��Ըı��Ը�׶�</t></t>";

			case "MoveWnd4_SelfID"://����ID
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ID</t><b/><t>ÿֻ����ֻ��Ψһ������ID</t></t>";

			case "MoveWnd4_SpouseID"://��żID
				%nGeneration = PetOperation_GetPetGeneration($PetInfoWnd_PetSlot);
				%nStyle = PetOperation_GetPetStyle($PetInfoWnd_PetSlot);
				%Dengji = PetOpreation_GetBreedLvLimit($PetInfoWnd_PetSlot);


				if ((%nGeneration == 1)&&(%nStyle ==1))//�Ƿ�Ϊ���ޱ�����һ�����ޱ���
				{
					%ctrl.tooltipWidth = 280;
					if (MoveWnd4_SpouseID.GetText()==0)//�Ƿ��ѷ�ֳ
					{
						%txt1 = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>�����ɷ�ֳ���</t>";
						%txt2 = "����Ѱ�����Ա�����ֳ��һ�����ޣ��ٴη�ֳ�����ϴη�ֳ�ĵȼ�������2�ޣ����ұ�����ͬһ����ż��ֳ��һ��";
						%txt3 = "<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�ɷ�ֳ�ȼ�Ϊ��"@ %Dengji @"��</t>";
					}
					else
					{
						%txt1 = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>�ѻ飬�ѷ�ֳ</t>";
						%txt2 = "����Ѱ�����Ա�����ֳ��һ�����ޣ��ٴη�ֳ�����ϴη�ֳ�ĵȼ�������2�ޣ����ұ�����ͬһ����ż��ֳ��һ��";
						%txt3 = "<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�ɷ�ֳ�ȼ�Ϊ��"@ %Dengji @"��</t>";
					}
				}
				else
				{
					%ctrl.tooltipWidth = 220;
					%txt1 = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>�޷�ֳ����</t>";
					%txt2 = "ֻ��һ�����ޱ������ܷ�ֳ���";
				}

				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��żID  </t>"@ %txt1 @"<b/><t>"@ %txt2 @"</t>"@ %txt3 @"</t>";


			case "PetSkillBar_PetExp"://���޾���
				%nSpawnedPetSlot = GetPlayer().GetSpawnedPetSlot();
				%nPetCurExp = PetOperation_GetPetExp(%nSpawnedPetSlot);
				%nPetMaxExp = PetOperation_GetPetMaxExp(%nSpawnedPetSlot);
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾���</t><b/><t>����ֵ��"@ %nPetCurExp @"/"@ %nPetMaxExp @"</t></t>";

			case "PetSkillBar_SkillBtn"://���޼���
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޼���</t><b/><t>���޵ı��������Լ�����ֶ��ͷŵļ���</t><b/><t>ͨ���μӻ���̳ǹ��������޼�����,��Ľ�����ǿ�������ѧ�Ἴ���鼼��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����л�Ϊ��������</t></t>";

			case "PetSkillBar_AbilityBtn"://��������
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>����������һ�����ʿ���������������</t><b/><t>������������ͼ����Ըı��Ը񱬷�ʱ�������ͷ�˳��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����л�Ϊ���޼���</t></t>";

			case "PetSkillBar_MaxBtn"://���޿�����Ŵ�
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>չ�����޼�����</t><b/><t>��������ɽ����޼�������ʾΪչ��״̬</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ס�������ͼ����϶����޼�����</t></t>";

			case "PetSkillBar_MinBtn"://���޿������С
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������޼�����</t><b/><t>��������ɽ����޼�������ʾΪ��С״̬</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��������������ͷ����϶����޼�����</t></t>";
				//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			case "PetEvaluationWnd_Pg1_Xing1"://������������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���ǡ�����������ֵ���޵ļӳ�</t></t>";

			case "PetEvaluationWnd_Pg1_Xing2"://��������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾�������</t><b/><t>Ӱ�조���񡱶����������������������</t></t>";

			case "PetEvaluationWnd_Pg1_Xing3"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조�������������������ļӳ�</t></t>";

			case "PetEvaluationWnd_Pg1_Xing4"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���������������й����ļӳ�</t></t>";

			case "PetEvaluationWnd_Pg1_Xing5"://������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������</t><b/><t>Ӱ�조�������������ܺͱ����ļӳ�</t></t>";

			case "PetEvaluationWnd_Pg1_Xing6"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���������������������ļӳ�</t></t>";

			case "PetEvaluationWnd_Pg2_Xing1"://��������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���ǡ�����������ֵ���޵ļӳ�</t></t>";

			case "PetEvaluationWnd_Pg2_Xing2"://��������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾�������</t><b/><t>Ӱ�조���񡱶����������������������</t></t>";

			case "PetEvaluationWnd_Pg2_Xing3"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조�������������������ļӳ�</t></t>";

			case "PetEvaluationWnd_Pg2_Xing4"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���������������й����ļӳ�</t></t>";

			case "PetEvaluationWnd_Pg2_Xing5"://������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������</t><b/><t>Ӱ�조�������������ܺͱ����ļӳ�</t></t>";

			case "PetEvaluationWnd_Pg2_Xing6"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���������������������ļӳ�</t></t>";
				//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
			case "PetEvaluationWnd_Bmp_Tipo1"://��������������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���ǡ�����������ֵ���޵ļӳ�</t></t>";

			case "PetEvaluationWnd_Bmp_Jingli1"://��������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾�������</t><b/><t>Ӱ�조���񡱶����������������������</t></t>";

			case "PetEvaluationWnd_Bmp_Lidao1"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조�������������������ļӳ�</t></t>";

			case "PetEvaluationWnd_Bmp_Lingli1"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���������������й����ļӳ�</t></t>";

			case "PetEvaluationWnd_Bmp_Minjie1"://������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������</t><b/><t>Ӱ�조�������������ܺͱ����ļӳ�</t></t>";

			case "PetEvaluationWnd_Bmp_Yuanli1"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���������������������ļӳ�</t></t>";

			case "PetEvaluationWnd_Bmp_Tipo2"://��������������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���ǡ�����������ֵ���޵ļӳ�</t></t>";

			case "PetEvaluationWnd_Bmp_Jingli2"://��������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾�������</t><b/><t>Ӱ�조���񡱶����������������������</t></t>";

			case "PetEvaluationWnd_Bmp_Lidao2"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조�������������������ļӳ�</t></t>";

			case "PetEvaluationWnd_Bmp_Lingli2"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���������������й����ļӳ�</t></t>";

			case "PetEvaluationWnd_Bmp_Minjie2"://������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������</t><b/><t>Ӱ�조�������������ܺͱ����ļӳ�</t></t>";

			case "PetEvaluationWnd_Bmp_Yuanli2"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���������������������ļӳ�</t></t>";

			case "PetEvaluationWnd_MainIcon"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�Ƽ��������Ա�ʶ</t><b/><t>�����������ʶ��Ƽ����������Ի��д˱�ʶ</t></t>";


				//====================================================================================�鿴���޽���==========================================================================================================
			case "OtherPetInfoWnd_PetRank"://Ǳ��
				%ctrl.tooltipWidth = 290;

				%IsIdentify = Other_IsPetIdentify();

				if (%IsIdentify)
				{
					%nChengZhangLv = Other_GetPetChengZhangLv();

					if (%nChengZhangLv >= 18 && %nChengZhangLv < 840){ %PinZhi = "<t c= '0xffffffff'>����ͨ��</t>"; }
					else if (%nChengZhangLv >= 840 && %nChengZhangLv < 1560){ %PinZhi = "<t c= '0x46ff15ff'>�����㡹</t>"; }
					else if (%nChengZhangLv >= 1560 && %nChengZhangLv < 2220){ %PinZhi = "<t c= '0x226fffff'>����Ӣ��</t>"; }
					else if (%nChengZhangLv >= 2220 && %nChengZhangLv < 2860){ %PinZhi = "<t c= '0xca57ffff'>��������</t>"; }
					else if (%nChengZhangLv >= 2860 && %nChengZhangLv < 3300){ %PinZhi = "<t c= '0xff9600ff'>����˵��</t>"; }
					else if (%nChengZhangLv >= 3300){ %PinZhi = "<t c= '0xff1200ff'>�����졹</t>"; }

					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰ����Ǳ��Ϊ��</t>"@ %PinZhi@"<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ͨ������ϴ�������ɸı�����Ǳ��</t><b/><t>��ͨ�����޼ӵ�ʱ������������Գɳ�</t><b/><t c='0x26da13ff'>���㣺���޼ӵ�ʱ��ö���20%�����Գɳ�</t><b/><t c='0x226fffff'>��Ӣ�����޼ӵ�ʱ��ö���40%�����Գɳ�</t><b/><t c='0xca57ffff'>���������޼ӵ�ʱ��ö���60%�����Գɳ�</t><b/><t c='0xff9600ff'>��˵�����޼ӵ�ʱ��ö���80%�����Գɳ�</t><b/><t c='0xff1200ff'>���죺���޼ӵ�ʱ��ö���100%�����Գɳ�</t></t>";
				}
				else
				{
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ǳ��   </t><t c= '0xff1200ff'>δ����</t><b/><t c='0x5adfffff'>����Ľ���Ĵ�����Ǳ��</t><b/><t>��ͨ�����޼ӵ�ʱ������������Գɳ�</t><b/><t c='0x26da13ff'>���㣺���޼ӵ�ʱ��ö���20%�����Գɳ�</t><b/><t c='0x226fffff'>��Ӣ�����޼ӵ�ʱ��ö���40%�����Գɳ�</t><b/><t c='0xca57ffff'>���������޼ӵ�ʱ��ö���60%�����Գɳ�</t><b/><t c='0xff9600ff'>��˵�����޼ӵ�ʱ��ö���80%�����Գɳ�</t><b/><t c='0xff1200ff'>���죺���޼ӵ�ʱ��ö���100%�����Գɳ�</t></t>";
				}

			case "OtherPetInfoWnd_PetDevelopRate"://Ǳ��
				%ctrl.tooltipWidth = 290;

				%IsIdentify = Other_IsPetIdentify();

				if (%IsIdentify)
				{
					%nChengZhangLv = Other_GetPetChengZhangLv();

					if (%nChengZhangLv >= 18 && %nChengZhangLv < 840){ %PinZhi = "<t c= '0xffffffff'>����ͨ��</t>"; }
					else if (%nChengZhangLv >= 840 && %nChengZhangLv < 1560){ %PinZhi = "<t c= '0x46ff15ff'>�����㡹</t>"; }
					else if (%nChengZhangLv >= 1560 && %nChengZhangLv < 2220){ %PinZhi = "<t c= '0x226fffff'>����Ӣ��</t>"; }
					else if (%nChengZhangLv >= 2220 && %nChengZhangLv < 2860){ %PinZhi = "<t c= '0xca57ffff'>��������</t>"; }
					else if (%nChengZhangLv >= 2860 && %nChengZhangLv < 3300){ %PinZhi = "<t c= '0xff9600ff'>����˵��</t>"; }
					else if (%nChengZhangLv >= 3300){ %PinZhi = "<t c= '0xff1200ff'>�����졹</t>"; }

					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰ����Ǳ��Ϊ��</t>"@ %PinZhi@"<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ͨ������ϴ�������ɸı�����Ǳ��</t><b/><t>��ͨ�����޼ӵ�ʱ������������Գɳ�</t><b/><t c='0x26da13ff'>���㣺���޼ӵ�ʱ��ö���20%�����Գɳ�</t><b/><t c='0x226fffff'>��Ӣ�����޼ӵ�ʱ��ö���40%�����Գɳ�</t><b/><t c='0xca57ffff'>���������޼ӵ�ʱ��ö���60%�����Գɳ�</t><b/><t c='0xff9600ff'>��˵�����޼ӵ�ʱ��ö���80%�����Գɳ�</t><b/><t c='0xff1200ff'>���죺���޼ӵ�ʱ��ö���100%�����Գɳ�</t></t>";
				}
				else
				{
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ǳ��   </t><t c= '0xff1200ff'>δ����</t><b/><t c='0x5adfffff'>����Ľ���Ĵ�����Ǳ��</t><b/><t>��ͨ�����޼ӵ�ʱ������������Գɳ�</t><b/><t c='0x26da13ff'>���㣺���޼ӵ�ʱ��ö���20%�����Գɳ�</t><b/><t c='0x226fffff'>��Ӣ�����޼ӵ�ʱ��ö���40%�����Գɳ�</t><b/><t c='0xca57ffff'>���������޼ӵ�ʱ��ö���60%�����Գɳ�</t><b/><t c='0xff9600ff'>��˵�����޼ӵ�ʱ��ö���80%�����Գɳ�</t><b/><t c='0xff1200ff'>���죺���޼ӵ�ʱ��ö���100%�����Գɳ�</t></t>";
				}


			case "OtherPetInfoWnd_NeedPlayerLevel"://Я���ȼ�
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Я���ȼ�</t><b/><t>��ɫ�ȼ����ڵ���Я���ȼ�������Я������</t></t>";

			case "OtherPetInfoWnd_PetColligate"://Я���ȼ�
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Я���ȼ�</t><b/><t>��ɫ�ȼ����ڵ���Я���ȼ�������Я������</t></t>";

			case "OtherPetInfoWnd_PetName"://��������
				%ctrl.tooltipWidth = 120;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���޿��Ը���</t></t>";

			case "OtherPetInfoWnd_PetTitle"://���޳ƺ�
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޳ƺ�</t><b/><t>�����޵�Ʒ�ס�Ǳ�������ʴﵽһ������,������Ľ���Ĵ���ȡ�ƺ�</t></t>";

			case "OtherPetInfoWnd_TuJianButton":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ͼ��</t><b/><t>�������ʾ�����������б������������</t></t>";

			case "OtherPetInfoWnd_PetLevel"://���޵ȼ�
				%ctrl.tooltipWidth = 120;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޵ȼ�</t><b/><t>���޵�ǰ�ĵȼ�</t></t>";

			case "OtherPetInfoWnd_PetStatus"://����״̬
				%nStatus = Other_GetPetStatus();
				if (%nStatus == 1){ %PetStatus = "��ս״̬"; }
				else if (%nStatus == 2){ %PetStatus = "����״̬"; }
				else if (%nStatus == 4){ %PetStatus = "����״̬"; }
				else if (%nStatus == 7){ %PetStatus = "��ֳ��״̬"; }
				else if (%nStatus == 8){ %PetStatus = "��ֳ���״̬"; }
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޴���"@ %PetStatus @"</t><b/><t>"@ %PetStatus @"�����޽����ܽ��з��������ס������������Ȳ���</t></t>";

			case "OtherPetInfoWnd_PetSkill"://���޼�����
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޼���ҳ</t><b/><t>���޵ı��������Լ�����ֶ��ͷŵļ���</t><b/><t>ͨ���μӻ���̳ǹ��������޼�����,��Ľ�����ǿ�������ѧ�Ἴ���鼼��</t></t>";

			case "OtherPetInfoWnd_PetAbility"://����������
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������ҳ</t><b/><t>����������һ�����ʿ���������������</t><b/><t>������������ͼ����Ըı��Ը񱬷�ʱ�������ͷ�˳��</t></t>";

			case "OtherPetInfoWnd_HP"://��������ֵ
				%ctrl.tooltipWidth = 305;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������ֵ</t><b/><t>���޵�ǰ����ֵΪ0ʱ,���޽��������ջ�</t><b/><t>ͨ����ιʳ�����Իָ����޵ĵ�ǰ����ֵ</t><b/><t>ιʳ��Ҫ����Ѫ��ʯ,�������������˴�����</t></t>";

				/*		case "OtherPetInfoWnd_MP"://���޾���ֵ
				%ctrl.tooltipWidth = 305;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾���ֵ</t><b/><t>����ʩ�ż���ʱ��Ҫ���ľ���ֵ</t><b/><t>��������������Իָ����޵ĵ�ǰ����ֵ</t><b/><t>������Ҫ�������ʯ,�������������˴�����</t></t>";
				*/
			case "OtherPetInfoWnd_Happy"://���޿���
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޿��ֶ�</t><b/><t>������������ֶȻ��½�</t><b/><t>�������ٻ�״̬ÿ��һ��ʱ�����ٿ��ֶ�</t><b/><t>�����ֶȵ���60ʱ���޽��޷��ٻ�</t><b/><t>�����������˴�������������������޿��ֶ�</t></t>";

			case "OtherPetInfoWnd_Exp"://���޾���
				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾���</t><b/><t>���޵�ǰ����ֵ/����������һ������ֵ</t></t>";
			case "OtherPetInfoWnd_PetHuiGen"://Ʒ��
				%ctrl.tooltipWidth = 320;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ʒ��</t><b/><t>Ʒ��ÿ����1��,���гɳ���������100��</t><b/><t>���޴ﵽ1�޺󼴿ɵ�Ľ���Ĵ�����Ʒ������</t><b/><t>������Ҫ���ĸ��ǵ�,ͨ���������и��ǵ����޿��Ի�ø��ǵ�</t></t>";

			case "OtherPetInfoWnd_PetGenGu"://����
				%ctrl.tooltipWidth = 310;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޸���</t><b/><t>Ӱ�������������õĸ��ǵ�</t><b/><t>���ǵ�������������Ʒ��,������޵ĳɳ�����</t></t>";

			case "OtherPetInfoWnd_PetTiPo"://����
				%ctrl.tooltipWidth = 155;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>��������������ֵ</t></t>";

			case "OtherPetInfoWnd_PetJingLi"://����
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾���</t><b/><t>������������������������</t></t>";

			case "OtherPetInfoWnd_PetLiDao"://����
				%ctrl.tooltipWidth = 175;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>�����������������ֵ</t></t>";

			case "OtherPetInfoWnd_PetLingLi"://����
				%ctrl.tooltipWidth = 165;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>������޷��������˺�</t></t>";

			case "OtherPetInfoWnd_PetMingJie"://��
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t>Ӱ�����޵����ܺͱ�������</t></t>";

			case "OtherPetInfoWnd_PetYuanLi"://����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>����������������˺�</t></t>";

			case "OtherPetInfoWnd_PetQianLi"://Ǳ��
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ǳ��</t><b/><t>����ÿ��1���ɻ��5��Ǳ��</t><b/><t>�����ɷ��䵽���ǡ�������������������������</t></t>";

			case "OtherAttack_Physics"://������
				%ctrl.tooltipWidth = 175;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����������������ࣩ</t><b/><t>���޵������˺�ֵ</t></t>";

			case "OtherAttack_YuanLi"://��������
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޷��������������ࣩ</t><b/><t>���޵ķ����˺�ֵ</t></t>";

			case "OtherAttack_Mu"://��������
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>���޵�������������</t><b/><t c='0xF450CFff'>��������Խ������������������������Խ��</t></t>";

			case "OtherAttack_Huo"://��������
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޷�������</t><b/><t>���޵ķ�����������</t><b/><t c='0xF450CFff'>��������Խ�������������ķ�����������Խ��</t></t>";

			case "OtherAttack_Shui"://��������
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>���޵�������������</t><b/><t c='0xF450CFff'>��������Խ�������ܶ�������������Խ��</t></t>";

			case "OtherAttack_Jin"://��������
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޷�������</t><b/><t>���޵ķ�����������</t><b/><t c='0xF450CFff'>��������Խ�������ܶ��ַ�����������Խ��</t></t>";

			case "OtherRecovery_Physics"://��������
				%ctrl.tooltipWidth = 175;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>���������˺�</t></t>";

			case "OtherRecovery_YuanLi"://�������
				%ctrl.tooltipWidth = 275;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����������</t><b/><t>�ܵ�������ʱ������Ӧ���˺�</t><b/><t c='0xF450CFff'>��������������������Ӱ��</t></t>";

			case "OtherRecovery_Mu"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޷�������</t><b/><t>�ܵ���������ʱ������Ӧ���˺�</t><b/><t c='0xF450CFff'>���޷��������ܷ�������Ӱ��</t></t>";

			case "OtherOther_ZhiLiao"://����
				%ctrl.tooltipWidth = 165;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>����������ߵ�����ֵ</t></t>";

			case "OtherOther_ShanBi"://����
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>����ֵԽ�����и��ߵĻ������ܶ��ֹ���</t></t>";

			case "OtherOther_BaoJi"://����
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ޱ���</t><b/><t>�����޷��������˺�,����ͨ������ͨ�˺���</t></t>";

			case "OtherOther_BaoJiLv"://������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ޱ�������</t><b/><t>���������˺��������ͨ�˺�������ֵ</t></t>";

			case "OtherMoveWnd2_TiPo"://��������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���ǡ�����������ֵ���޵ļӳ�</t></t>";

			case "OtherMoveWnd2_JingLi"://��������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾�������</t><b/><t>Ӱ�조���񡱶����������������������</t></t>";

			case "OtherMoveWnd2_LiDao"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조�������������������ļӳ�</t></t>";

			case "OtherMoveWnd2_LingLi"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���������������й����ļӳ�</t></t>";

			case "OtherMoveWnd2_MinJie"://������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������</t><b/><t>Ӱ�조�������������ܺͱ����ļӳ�</t></t>";

			case "OtherMoveWnd2_YuanLi"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���������������������ļӳ�</t></t>";

			case "OtherMoveWnd3_1"://��ֱ
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ֱ�Ը�</t><b/><t>�Ը�׶�Խ�ߣ�����ֱ�Ը�Ӱ��ļ����ͷż��ʾ�Խ��</t><b/><t>��ֱ�Ը񱬷�ʱ����ֱ�Ը�Ӱ��ļ����ͷż�����100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������п��Ըı��Ը�׶�</t></t>";

			case "OtherMoveWnd3_2"://����
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����Ը�</t><b/><t>�Ը�׶�Խ�ߣ��ܻ����Ը�Ӱ��ļ����ͷż��ʾ�Խ��</t><b/><t>�����Ը񱬷�ʱ�������Ը�Ӱ��ļ����ͷż�����100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������п��Ըı��Ը�׶�</t></t>";

			case "OtherMoveWnd3_3"://����
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����Ը�</t><b/><t>�Ը�׶�Խ�ߣ��������Ը�Ӱ��ļ����ͷż��ʾ�Խ��</t><b/><t>�����Ը񱬷�ʱ�������Ը�Ӱ��ļ����ͷż�����100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������п��Ըı��Ը�׶�</t></t>";

			case "OtherMoveWnd3_4"://����
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����Ը�</t><b/><t>�Ը�׶�Խ�ߣ��������Ը�Ӱ��ļ����ͷż��ʾ�Խ��</t><b/><t>�����Ը񱬷�ʱ�������Ը�Ӱ��ļ����ͷż�����100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������п��Ըı��Ը�׶�</t></t>";

			case "OtherMoveWnd3_5"://�侲
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�侲�Ը�</t><b/><t>�Ը�׶�Խ�ߣ����侲�Ը�Ӱ��ļ����ͷż��ʾ�Խ��</t><b/><t>�侲�Ը񱬷�ʱ���侲�Ը�Ӱ��ļ����ͷż�����100%</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������п��Ըı��Ը�׶�</t></t>";

				//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
			case "OtherPetEvaluationWnd_Pg1_Xing1"://������������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���ǡ�����������ֵ���޵ļӳ�</t></t>";

			case "OtherPetEvaluationWnd_Pg1_Xing2"://��������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾�������</t><b/><t>Ӱ�조���񡱶����������������������</t></t>";

			case "OtherPetEvaluationWnd_Pg1_Xing3"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조�������������������ļӳ�</t></t>";

			case "OtherPetEvaluationWnd_Pg1_Xing4"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���������������й����ļӳ�</t></t>";

			case "OtherPetEvaluationWnd_Pg1_Xing5"://������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������</t><b/><t>Ӱ�조�������������ܺͱ����ļӳ�</t></t>";

			case "OtherPetEvaluationWnd_Pg1_Xing6"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���������������������ļӳ�</t></t>";

			case "OtherPetEvaluationWnd_Pg2_Xing1"://��������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���ǡ�����������ֵ���޵ļӳ�</t></t>";

			case "OtherPetEvaluationWnd_Pg2_Xing2"://��������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾�������</t><b/><t>Ӱ�조���񡱶����������������������</t></t>";

			case "OtherPetEvaluationWnd_Pg2_Xing3"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조�������������������ļӳ�</t></t>";

			case "OtherPetEvaluationWnd_Pg2_Xing4"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���������������й����ļӳ�</t></t>";

			case "OtherPetEvaluationWnd_Pg2_Xing5"://������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������</t><b/><t>Ӱ�조�������������ܺͱ����ļӳ�</t></t>";

			case "OtherPetEvaluationWnd_Pg2_Xing6"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���������������������ļӳ�</t></t>";
				//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
			case "OtherPetEvaluationWnd_Bmp_Tipo1"://��������������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���ǡ�����������ֵ���޵ļӳ�</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Jingli1"://��������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾�������</t><b/><t>Ӱ�조���񡱶����������������������</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Lidao1"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조�������������������ļӳ�</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Lingli1"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���������������й����ļӳ�</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Minjie1"://������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������</t><b/><t>Ӱ�조�������������ܺͱ����ļӳ�</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Yuanli1"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���������������������ļӳ�</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Tipo2"://��������������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���ǡ�����������ֵ���޵ļӳ�</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Jingli2"://��������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾�������</t><b/><t>Ӱ�조���񡱶����������������������</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Lidao2"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조�������������������ļӳ�</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Lingli2"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���������������й����ļӳ�</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Minjie2"://������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������</t><b/><t>Ӱ�조�������������ܺͱ����ļӳ�</t></t>";

			case "OtherPetEvaluationWnd_Bmp_Yuanli2"://��������
				%ctrl.tooltipWidth = 255;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������������</t><b/><t>Ӱ�조���������������������ļӳ�</t></t>";


				//====================================================================================���޷�ֳ��ϵ�н���===========================================================================================================

			case "PetBreed_ExplainTooltip"://���޷�ֳ˵��
				%ctrl.tooltipWidth = 380;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޷�ֳ������</t><b/><t>����������Ҫ��Ϊ���ޱ���</t><t c='0xF450CFff'>(���챦�����ܷ�ֳ���)</t><b/><t>��һ�����ޱ�����ֳҪ��4�ޣ��´η�ֳ�ȼ����ϴη�ֳ�ȼ��Ļ���������2��</t><b/><t>�����з�ֳ���������ޱ����軥Ϊ��ż���Ա�ͬ</t><b/><t>�����޵Ŀ��ֶ���ҪΪ100��</t><b/><t>�����޵���Ԫ��С��500��</t><b/><t>����ֳ��������ҪΪһ�����ޱ���</t><b/><t>�����޵�˫��������Ҫ����ͬһ����</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'o='0x010101ff'>���޷�ֳ����</t><b/><t>��������ֳ���̻����2��Сʱ</t><b/><t>�����޴��ڷ�ֳ״̬,���ܽ��г�ս�����С������Ȳ���</t><b/><t>����ɷ�ֳ��,˫������Ľ���ĶԻ���ȡ���ޱ���</t></t>";

				//====================================================================================��������===========================================================================================================

			case "PetDecompoundWnd_BmpExplain"://��������˵��
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������˵����</t><b/><t>1�����Ǵ���0�����޲ſ�������</t><b/><t>2�������ɹ������޽�����ʧ</t><b/><t>3�����޵ĸ���Խ�ߣ��������ø߼����ǵ��ļ���Խ��</t><b/><t>4�����ǵ�������������Ʒ��������Ʒ����������������޵ĳɳ�����</t><b/><t>5��������1-3�����ޣ��м��ʲ����������ǵ����м����ǵ�</t><b/><t>6��������4-10�����ޣ��м��ʲ����������ǵ����м����ǵ��͸߼����ǵ�</t></t>";

			case "PetRefineSoulGui_explain"://���޾���˵��
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾���Ҫ��</t><b/><t>1�����޵ȼ��ﵽ5��</t><b/><t>2������Ϊ�������߱��챦��</t><b/><t>3������Ҫ��ӵ�м���</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���޾�������</t><b/><t>1�������ɹ������������һ�����ܼ�¼�ھ�������</t><b/><t>2����¼�ļ��ܿ��Ը���������ѧϰ</t><b/><t>3������������޽�����ʧ</t><b/><t>4����������ʧ��</t></t>";

				//====================================================================================����ѧϰ����===========================================================================================================

			case "PetSkillStudy_Tip"://����ѧϰ����˵��
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ѧϰ����˵����</t><b/><t>1���߼����ܱ�Ȼ�滻�ͼ�����</t><b/><t>2���������ԡ��������Ժ��������Ը�ֻ�ܴ���һ�֣�ͬ�ࣨ���綼�ǹ������Եļ��ܣ�֮���Ȼ�滻</t><b/><t>3����û�г��֣�1���ͣ�2�������ʱ��������һ�����ʼ����¼����������ܻ���ӵ��¼�������</t><b/><t>4����û�м����¼�����ʱ���¼��ܻ������滻һ�����޵�ǰ�ļ���</t></t>";


				//====================================================================================������===========================================================================================================

			case "PetInfoWnd_QiPet_Name":
				%ctrl.tooltipWidth = 80;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t></t>";

			case "PetInfoWnd_QiPet_GradeTooltip":
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ȼ�</t><b/><t>ͨ�������׿��������ȼ�,�Ӷ����������ƶ��ٶ����������</t></t>";

			case "PetInfoWnd_QiPet_Jinweishi"://ιʳ
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ιʳ</t><b/><t>ιʳ��Ҫ�������ʳ�����</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>�̳�</t><t>����</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������</t><t>������</t></t>";

			case "PetInfoWnd_QiPet_MountCount":
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���������</t><b/><t>���ĵȼ�Խ��,����˵�����ҲԽ��</t></t>";

			case "PetInfoWnd_QiPet_SpeedupPercent":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ٶ�</t><b/><t>���ĵȼ�Խ��,����ٶ�ҲԽ��</t></t>";

			case "PetInfoWnd_QiPet_Level":
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��˵ȼ�</t><b/><t>��ɫ�ȼ�Ҫ�󲻵��ڸõȼ��������</t></t>";

			case "PetInfoWnd_QiPet_TuJian":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ͼ��</t><b/><t>�������ʾ����������еȼ�������</t></t>";

			case "PetInfoWnd_QiPet_Lock":
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t><b/><t>�ڰ�ȫ�����ж������м���</t><b/><t>���������޷�������</t></t>";

			case "PetInfoWnd_QiPet_Release":
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t>��������������ʧ</t><b/><t>��ȫʱ�䡢����С������е�����޷�����</t></t>";

			case "PetInfoWnd_QiPet_Status":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��账�����״̬</t><b/><t>���ܽ��з������ȼ������Ĳ���</t></t>";

			case "PetInfoWnd_QiPet_Mount":
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���</t><b/><t>ֻ�����������˵ȼ������</t></t>";

			case "PetInfoWnd_QiPet_UnMount":
				%ctrl.tooltipWidth = 80;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ջ����</t></t>";

				/*		case "PetInfoWnd_QiPet_MountRace":
				%nRace = Mount_GetMountRace($PetInfoWnd_MountSlot);

				if(%nRace ==0 ){%QiPetRace = "������";}
				else if(%nRace ==1 ){%QiPetRace = "������";}
				else if(%nRace ==2 ){%QiPetRace = "������";}
				else if(%nRace ==3 ){%QiPetRace = "�ɻ���";}
				else if(%nRace ==4 ){%QiPetRace = "���Ľ�";}
				else if(%nRace ==5 ){%QiPetRace = "ɽ����";}
				else if(%nRace ==6 ){%QiPetRace = "���鹬";}
				else if(%nRace ==7 ){%QiPetRace = "��ħ��";}
				else if(%nRace ==8 ){%QiPetRace = "��ۡ";}

				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������Ϊ"@ %QiPetRace @"</t></t>";
				*/
			case "WuXingFaceSeriesBtn_OpenSoulWnd":
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t>1������ɳ��׶���������Ӧ���1�㻯���츳��,������������츳,�������</t><b/><t>2���������������(������ֶ��ͷ�),�򼤻�ļ��ܻ���ʾ����ǰ������ҳ����,����϶����ܿɷ���������,�Ҽ�����ʹ�ü���</t><b/><t c='0x46ff15ff' >�����ť�򿪻�����Ϣ����</t></t>";

				//====================================================================================���ѽ���===========================================================================================================

			case "RelationWndBnt_Add":
				%ctrl.tooltipWidth = 140;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����Ѽ���</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����򿪺��Ѽ���</t></t>";

			case "RelationWndBnt_Chat":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����˽��</t><b/><t>ѡ��Ҫ˽�ĵĺ��ѣ������˽�Ľ���</t></t>";

			case "RelationWndBnt_Team":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t><b/><t>ѡ��Ҫ��ӵĺ��ѣ���������������</t></t>";

			case "RelationWndBnt_Write":
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����ʼ�</t><b/><t>ѡ��Ҫд�ŵĺ��ѣ������д�Ž���</t></t>";

			case "RelationWndBnt_Clear":
				%ctrl.tooltipWidth = 135;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��յ�ǰ�б���Ϣ</t></t>";

			case "RelationWndCheckBnt_ShowOnline":
				%ctrl.tooltipWidth = 175;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ѡ</t><t>  ȫ����ʾ</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ѡ</t><t>    �����������</t></t>";

			case "RelationWndBnt_AddFriend1":
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ϊ����</t><b/><t>1��ֻ��˫��������Ϊ����,����������Ϊ����</t><b/><t>2��������ѵĹ�ϵ��ʾΪ</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>[İ��]</t><t>������Ҫ����Է�����Ϊ���ѣ��Ҽ��˵��ڵ���</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������Ϊ���ѡ�</t><t>����</t></t>";

			case "RelationWndBnt_AddBlacklist":
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����ҵ�������</t><b/><t>�޷��鿴����������ҷ��͵�������Ϣ���ʼ�</t></t>";

			case "FriendCheerWndBmp_Tips"://����
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������˵��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���Ѳ��ԣ�</t><b/><t>1��ͨ�����Կ��Ի��һ��1Сʱ�ĵ���ʱ������ʱ�����һ��Ч�����Ƶ�״̬������</t><b/><t>2������������Ѷ�����ͣ�������ٵȴ���ʱ�䡣</t><b/><t>3�����Բ����ƴ��������ڴ��в����벷�Խ���״̬ʱ�����ܼ������ԡ�</t><b/><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���Ѽ��ͣ�</t><b/><t>1��ͨ���������ͣ����԰���������10���Ӳ��Ե���ʱ���Ӷ������ٵĻ�ý�����</t><b/><t>2��ÿһ�μ��ͣ��㻹��һ�����ʴ��������¼���þ�ϲ��</t><b/><t>3�����Ͳ����ƴ����������ͳɹ���10���Ӳſ��Լ������͡�</t></t>";

			case "RelationWndBnt_SearchPerson"://ǧ����
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ǧ����</t><b/><t>���Բ�ѯ����.���˵�ǰ���ڵ�ͼλ�����������Ϣ</t></t>";


				//====================================================================================���׽��棬������Ƕ��װ�������===========================================================================================================

			case "EquipPrefectStrengthenWnd_IntroBitmap1"://��������˵��
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>һ����������˵��</t><b/><t>1���������ģ�</t><t gct='0x00ff00ff' gcb='0x2cffeeff'> (�ɷֽ���ɫ����װ�����)</t><b/><t>  װ�����׵ȼ�1-2�������İ���ʯ</t><b/><t>  װ�����׵ȼ�3-4�����������ʯ</t><b/><t>  װ�����׵ȼ�5-12������������ʯ</t><b/><t>  װ�����׵ȼ�13-15�� ��������΢ʯ</t><b/><b/><t>2�� һ����������ֻ�ᱣ���������ף����������׻��Զ�ִ���˼�������ֱ���ﵽ��������</t></t>";

			case "EquipStrengthen_IntroBitmap"://����˵��
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>װ������˵��</t><b/><t>1���������ģ�</t><t gct='0x00ff00ff' gcb='0x2cffeeff'> (�ɷֽ���ɫ����װ�����)</t><b/><t>  װ�����׵ȼ�1-2�������İ���ʯ</t><b/><t>  װ�����׵ȼ�3-4�����������ʯ</t><b/><t>  װ�����׵ȼ�5-12������������ʯ</t><b/><t>  װ�����׵ȼ�13-15�� ��������΢ʯ</t><b/><b/><t>2������װ�������Խ��н��ף���</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >�������</t><t>����Ի������Խ���������ֻ�����Ӹ�������</t><b/><t>3��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >���ױ�Ȼ�ɹ�</t><t>������ÿ���ȼ����׵�ֵ����</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >����</t><t>�����ﵽ</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >��������</t><t>ʱ���������Խ����������˻��˴ν��׵Ľ���ʯ</t><b/><t>4�����׿���ѡ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >�˼�</t><t>���˼����κ����ģ���װ���������Իᵹ��1��</t><b/><t>5��װ������+4��+15ÿ�ζ����������׸������ԣ�ͬʱ�������׵ȼ�4��7��10�Ὺ��������Ч��ʹ���θ�����</t></t>";

			case "EquipStrengthen_RichText4"://װ������Ʒ��
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>װ������Ʒ�� ������װ�����׵������̶ȣ�</t><b/><t>1��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >���ױ�Ȼ�ɹ�</t><t>������ÿ�εȼ����׵�ֵ����</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >����</t><b/><t>2�����ﵽ</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >��������</t><t>ʱ���������Խ����������˻��˴ν��׵Ľ���ʯ��װ��Ʒ�ʴﵽ</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >����</t><t>���ʾװ��ÿ�ζ��ﵽ��������</t><b/><t>3������δ�ﵽ����ʱ����ѡ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >�����˼�</t><t>���½���װ�����ף��˼����κ����ģ���װ���������Իᵹ��1��</t></t>";

			case "EquipPunchHole_XiTips"://װ�����
				%ctrl.tooltipWidth = 320;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>װ�����</t><b/><t>1��װ�������ʧ�ܵļ���</t><b/><t>2.װ����׿��Է���ﱵ���װ����ױ�Ȼ�ɹ�</t><b/><t>3��ﱵ�����˵����</t><b/><t>  a��һ��ﱵ���������1--59��װ�����</t><b/><t>  b������ﱵ���������1--69��װ�����</t><b/><t>  c������ﱵ���������1--79��װ�����</t><b/><t>  d���ļ�ﱵ���������1--89��װ�����</t></t>";

			case "EquipEmbedGem_btnMount":
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ƕ����</t><b/><t>1�������������ͬ��ɫ�����,���ҷ����������Ƕ����,�����ť������Ƕ��װ��</t><b/><t>2����ͬʱ����������,�����ťһͬ��Ƕ��װ��</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>ע����Ƕ������ժȡ�󶼽���Ϊ���ɽ���</t></t>";

			case "EquipEmbedGem_btnUnmount":
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ժȡ����</t><b/><t>1��ѡ��Ҫժȡ�����飬�����ť����ժȡ����</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>ע����Ƕ������ժȡ�󶼽���Ϊ���ɽ���</t></t>";

				//case "EquipEmbedGemBnt_FindNpc":
				//	%ctrl.tooltipWidth = 250;
				//	%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������,Ѱ��������ʯ����</t><b/><t>ʯ���񴦿ɽ�������ϳ�,������Ƭ�ϳ�,װ����׵Ĳ���</t></t>";

			case "EquipEmbedGem_Tip":
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ƕ����</t><b/><t>1�������������ͬ��ɫ�����,���ҷ����������Ƕ����,�������Ƕ���顿��ť���齫��Ƕ��װ��</t><b/><t>2����ͬʱ����������,�����ťһͬ��Ƕ��װ��</t><b/><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ժȡ����</t><b/><t>1��ѡ��Ҫժȡ�����飬�����ժȡ���顿��ť����ժȡ����</t><b/><t>2��ժȡ����Ҫ����һ����������Ӧ�ȼ���ǯ</t><b/><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>ע����Ƕ������ժȡ�󶼽���Ϊ���ɽ���</t></t>";

			case "AddIdentify_Introduce"://װ������
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>װ������</t><b/><t>1��ֻ������������</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >6�����ϵ���ɫ����װ��</t><t>�ſɽ������飬</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >�����Ȼ�ɹ�</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>��ע������������ɫװ���޷����飩</t><b/><t>2��ÿ��������������װ��һ���������ԣ���߿������鵽������������</t><b/><t>3��װ��������Ҫ</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >����ʯ</t><t>��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >��Ӧ�ȼ�����ɫװ��</t><t>һ������6������װ��������Ҫ6������ʯ��6��������ɫװ��һ��</t><b/><t>4������ʯ��ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >�μӻ���̳ǹ���</t><t>���</t><b/><t>5�������޷������������ԣ�ֻ�л���ſ��Կ���</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >��������</t><b/><t>6���������ͼ��</t><t>"@ %Reward1 @"</t><t>�����ɲ鿴ÿ�����Ի��������������</t></t>";


			case "ChangeIdentify_Introduce_New"://װ������
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }


				%ctrl.tooltipWidth = 270;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>װ������</t><b/><t>1��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >6�����ϵ���ɫ����װ��</t><t>�ɽ��л���</t><b/><t>2��������Ըı�����װ�����������ݣ�������ı�����ֵ�Ĵ�С</t><b/><t>3����6��7��8��9��10�����Կ���ͨ�����鿪��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >��������</t><b/><t>4���������ͼ��</t><t> "@ %Reward1 @"</t><t>�����ɲ鿴ÿ�����Ի��������������</t></t>";

			case "EquipClearSoulWnd_IntroBitmap"://װ��ϴ��
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>װ��ϴ��</t><b/><t>1��ֻ������������</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >6�����ϵ���ɫ����װ��</t><t>�ſɽ���ϴ��</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>��ע������������ɫװ���޷�ϴ�飩</t><b/><t>2��ϴ��ֻ�ı�����ֵ�Ĵ�С������ı���������</t><b/><t>3��ϴ����Ҫ����</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >ϴ��ʯ</t><t>��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >������Ƭ</t><b/><t>4��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >��ѡ��ϴ�����ȷ�ϡ�</t><t>���ɸ���ϴ���������Ƿ������ٿ�������</t><b/><t>5���������ͼ��</t><t>"@ %Reward1 @"</t><t>�����ɲ鿴ÿ�����Ի��������������</t></t>";

			case "ChangeIdentify_CheckBox"://�������ȷ��
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������ȷ��</t><b/><t>��ѡ�󣬿�����</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >�������������</t><t>������£�ѡ���Ƿ���Ҫ���ã��������򱣳ֻ���ǰ�����ñ����ܣ�������Ҫ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >���ķ���</t></t>";

			case "EquipClearSoulWnd_CheckBox"://ϴ�����ȷ��
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ϴ�����ȷ��</t><b/><t>��ѡ�󣬿�����</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >����ϴ�������</t><t>������£�ѡ���Ƿ���Ҫ���ã��������򱣳�ϴ��ǰ�����ñ����ܣ�ϴ����Ҫ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >���ķ���</t></t>";


				//========================================================================================================װ������========================================================================================

			case "AddIdentify_icon6"://�������
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "������";%Shux = ""; }
				else if (%Leix $= 201){ %Buwei = "ͷ����";%Shux = ""; }
				else if (%Leix $= 202){ %Buwei = "�ز���";%Shux = ""; }
				else if (%Leix $= 203){ %Buwei = "������";%Shux = ""; }
				else if (%Leix $= 204){ %Buwei = "�粿��";%Shux = ""; }
				else if (%Leix $= 205){ %Buwei = "�ֲ���";%Shux = ""; }
				else if (%Leix $= 206){ %Buwei = "������";%Shux = ""; }
				else if (%Leix $= 207){ %Buwei = "�Ų���";%Shux = ""; }
				else if (%Leix $= 301){ %Buwei = "������";%Shux = ""; }
				else if (%Leix $= 302){ %Buwei = "������";%Shux = ""; }
				else if (%Leix $= 303){ %Buwei = "��ָ��";%Shux = ""; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"������Ʒ������˵��</t><b/><t>��װ���������������ԣ�ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >װ������</t><t>�ɻ�������������ԣ�</t><b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ͼӳ�</t></t>";

			case "AddIdentify_icon7"://�������
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ٷֱȼӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ٷֱȼӳ�</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ٷֱȼӳ�</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ٷֱȼӳ�</t>"; }
				else if (%Leix $= 201){ %Buwei = "ͷ����";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��������ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t>"; }
				else if (%Leix $= 202){ %Buwei = "�ز���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��������ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t>"; }
				else if (%Leix $= 203){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������аٷֱ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������аٷֱ�</t>"; }
				else if (%Leix $= 204){ %Buwei = "�粿��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��������ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t>"; }
				else if (%Leix $= 205){ %Buwei = "�ֲ���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t>"; }
				else if (%Leix $= 206){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������аٷֱ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������аٷ�</t>"; }
				else if (%Leix $= 207){ %Buwei = "�Ų���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t>"; }
				else if (%Leix $= 301){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���������ٷֱȼӳ�</t>"; }
				else if (%Leix $= 302){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���������ٷֱȼӳ�</t>"; }
				else if (%Leix $= 303){ %Buwei = "��ָ��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���������ٷֱȼӳ�</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"������Ʒ������˵��</t><b/><t>��װ���������������ԣ�ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >װ������</t><t>�ɻ�������������ԣ�</t>"@ %Shux @"</t>";

			case "AddIdentify_icon8"://�������
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٶȰٷֱȼӳ�</t>"; }
				else if (%Leix $= 201){ %Buwei = "ͷ����";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʼ���ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t>"; }
				else if (%Leix $= 202){ %Buwei = "�ز���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t>"; }
				else if (%Leix $= 203){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʰٷֱȼӳ�</t>"; }
				else if (%Leix $= 204){ %Buwei = "�粿��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʼ���ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t>"; }
				else if (%Leix $= 205){ %Buwei = "�ֲ���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٶȰٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʼ���ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t>"; }
				else if (%Leix $= 206){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʰٷֱȼӳ�</t>"; }
				else if (%Leix $= 207){ %Buwei = "�Ų���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�ƶ��ٶȰٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʼ���ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t>"; }
				else if (%Leix $= 301){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʰٷֱȼӳ�</t>"; }
				else if (%Leix $= 302){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʰٷֱȼӳ�</t>"; }
				else if (%Leix $= 303){ %Buwei = "��ָ��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʰٷֱȼӳ�</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"�ڰ���Ʒ������˵��</t><b/><t>��װ�������ڰ������ԣ�ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >װ������</t><t>�ɻ�������������ԣ�</t>"@ %Shux @"</t>";

			case "AddIdentify_icon9"://�������
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���������ٷֱȼӳ�</t>"; }
				else if (%Leix $= 201){ %Buwei = "ͷ����";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ֵ�ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ֵ�ٷֱȼӳ�</t>"; }
				else if (%Leix $= 202){ %Buwei = "�ز���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����˺�����ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����˺�����ٷֱȼӳ�</t>"; }
				else if (%Leix $= 203){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ưٷֱȼӳ�</t>"; }
				else if (%Leix $= 204){ %Buwei = "�粿��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ֵ�ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ֵ�ٷֱȼӳ�</t>"; }
				else if (%Leix $= 205){ %Buwei = "�ֲ���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ֵ�ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ֵ�ٷֱȼӳ�</t>"; }
				else if (%Leix $= 206){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ưٷֱȼӳ�</t>"; }
				else if (%Leix $= 207){ %Buwei = "�Ų���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ֵ�ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ֵ�ٷֱȼӳ�</t>"; }
				else if (%Leix $= 301){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���������ٷֱȼӳ�</t>"; }
				else if (%Leix $= 302){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���������ٷֱȼӳ�</t>"; }
				else if (%Leix $= 303){ %Buwei = "��ָ��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�佫ְҵ����+1</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ְҵ����+1</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ʿְҵ����+1</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ʿְҵ����+1</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��˾ְҵ����+1</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"�ھ���Ʒ������˵��</t><b/><t>��װ�������ھ������ԣ�ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >װ������</t><t>�ɻ�������������ԣ�</t>"@ %Shux @"</t>";


			case "AddIdentify_icon10"://�������
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�˺�����</t>"; }
				else if (%Leix $= 201){ %Buwei = "ͷ����";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӷ�������</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������������</t>"; }
				else if (%Leix $= 202){ %Buwei = "�ز���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӷ�������</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������������</t>"; }
				else if (%Leix $= 203){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���Ӷ�ϵ����</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӻ�ϵ����</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������ϵ����</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӽ�ϵ����</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӱ�ϵ����</t>"; }
				else if (%Leix $= 204){ %Buwei = "�粿��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӷ�������</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������������</t>"; }
				else if (%Leix $= 205){ %Buwei = "�ֲ���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӷ�������</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������������</t>"; }
				else if (%Leix $= 206){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���Ӷ�ϵ����</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӻ�ϵ����</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������ϵ����</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӽ�ϵ����</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӱ�ϵ����</t>"; }
				else if (%Leix $= 207){ %Buwei = "�Ų���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӷ�������</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������������</t>"; }
				else if (%Leix $= 301){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�˺�����</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���Ӷ�ϵ����</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӻ�ϵ����</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������ϵ����</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӽ�ϵ����</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӱ�ϵ����</t>"; }
				else if (%Leix $= 302){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�˺�����</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���Ӷ�ϵ����</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӻ�ϵ����</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������ϵ����</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӽ�ϵ����</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӱ�ϵ����</t>"; }
				else if (%Leix $= 303){ %Buwei = "��ָ��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�˺�����</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���Ӷ�ϵ����</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӻ�ϵ����</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������ϵ����</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӽ�ϵ����</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӱ�ϵ����</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"��ʮ��Ʒ������˵��</t><b/><t>��װ��������ʮ�����ԣ�ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >װ������</t><t>�ɻ�������������ԣ�</t>"@ %Shux @"</t>";





				//========================================================================================================װ������========================================================================================

			case "KLJEquipStrengGui_ProImg5"://����������
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ֵ</t>"; }
				else if (%Leix $= 201){ %Buwei = "ͷ����";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>ȫ������</t>"; }
				else if (%Leix $= 202){ %Buwei = "�ز���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>ȫ������</t>"; }
				else if (%Leix $= 203){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>ȫ������</t>"; }
				else if (%Leix $= 204){ %Buwei = "�粿��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>ȫ������</t>"; }
				else if (%Leix $= 205){ %Buwei = "�ֲ���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ֵ</t>"; }
				else if (%Leix $= 206){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>ȫ������</t>"; }
				else if (%Leix $= 207){ %Buwei = "�Ų���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>ȫ������</t>"; }
				else if (%Leix $= 301){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ưٷֱ�</t>"; }
				else if (%Leix $= 302){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ưٷֱ�</t>"; }
				else if (%Leix $= 303){ %Buwei = "��ָ��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ưٷֱ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ֵ</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"������Ʒ������˵��</t><b/><t>��װ���������������ԣ�ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >װ������</t><t>�ɻ�������������ԣ�</t>"@ %Shux @"</t>";

			case "KLJEquipStrengGui_ProImg6"://����������
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����������ٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����������ٷֱ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���������ٷֱ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����������ٷֱ�</t>"; }
				else if (%Leix $= 201){ %Buwei = "ͷ����";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����������ٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����������ٷֱ�</t>"; }
				else if (%Leix $= 202){ %Buwei = "�ز���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��������ٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���������ٷֱ�</t>"; }
				else if (%Leix $= 203){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��������ٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���������ٷֱ�</t>"; }
				else if (%Leix $= 204){ %Buwei = "�粿��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��������ٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������ٷֱ�</t>"; }
				else if (%Leix $= 205){ %Buwei = "�ֲ���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��С�������ٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��С���������ٷֱ�</t>"; }
				else if (%Leix $= 206){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��������ٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���������ٷֱ�</t>"; }
				else if (%Leix $= 207){ %Buwei = "�Ų���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��������ٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������ٷֱ�</t>"; }
				else if (%Leix $= 301){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��С�������ٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��С���������ٷֱ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����������ٷֱ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����������ٷֱ�</t>"; }
				else if (%Leix $= 302){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��С�������ٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��С���������ٷֱ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����������ٷֱ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����������ٷֱ�</t>"; }
				else if (%Leix $= 303){ %Buwei = "��ָ��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��С�������ٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��С���������ٷֱ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���������ٷֱ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����������ٷֱ�</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"������Ʒ������˵��</t><b/><t>��װ���������������ԣ�ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >װ������</t><t>�ɻ�������������ԣ�</t>"@ %Shux @"</t>";


			case "KLJEquipStrengGui_ProImg7"://�ڰ�������
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������аٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������аٷֱ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��Ե�ٷֱ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����һ��ֵ</t>"; }
				else if (%Leix $= 201){ %Buwei = "ͷ����";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������аٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������аٷֱ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>ȫ�����԰ٷֱ�</t>"; }
				else if (%Leix $= 202){ %Buwei = "�ز���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������ܰٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������ܰٷֱ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��Ե�ٷֱ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱ�</t>"; }
				else if (%Leix $= 203){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������ܰٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������ܰٷֱ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����һ������ֵ</t>"; }
				else if (%Leix $= 204){ %Buwei = "�粿��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������аٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������аٷֱ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���˰ٷֱ�</t>"; }
				else if (%Leix $= 205){ %Buwei = "�ֲ���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������аٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������аٷֱ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>ȫ�����԰ٷֱ�</t>"; }
				else if (%Leix $= 206){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������ܰٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������ܰٷֱ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱ�</t>"; }
				else if (%Leix $= 207){ %Buwei = "�Ų���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������ܰٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������ܰٷֱ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���˰ٷֱ�</t>"; }
				else if (%Leix $= 301){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��Ե�ٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱ�</t>"; }
				else if (%Leix $= 302){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��Ե�ٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����һ��ֵ</t>"; }
				else if (%Leix $= 303){ %Buwei = "��ָ��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������аٷֱ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������аٷֱ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱ�</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ٷֱ�</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"�ڰ���Ʒ������˵��</t><b/><t>��װ�������ڰ������ԣ�ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >װ������</t><t>�ɻ�������������ԣ�</t>"@ %Shux @"</t>";

			case "KLJEquipStrengGui_ProImg8"://�ھ�������
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٶ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>սʿ���ܵȼ�+1</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ʦ���ܵȼ�+1</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ʿ���ܵȼ�+1</t>"; }
				else if (%Leix $= 201){ %Buwei = "ͷ����";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����˺��ٷֱ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>ʩ���ٶ�</t>"; }
				else if (%Leix $= 202){ %Buwei = "�ز���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʼ���</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����˺�����ٷֱ�</t>"; }
				else if (%Leix $= 203){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʼ���</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����˺�����ٷֱ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ƶ��ٶ�</t>"; }
				else if (%Leix $= 204){ %Buwei = "�粿��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�﹥�˺�����</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����˺�����</t>"; }
				else if (%Leix $= 205){ %Buwei = "�ֲ���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����˺��ٷֱ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٶ�</t>"; }
				else if (%Leix $= 206){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʼ���</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����˺�����ٷֱ�</t>"; }
				else if (%Leix $= 207){ %Buwei = "�Ų���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʼ���</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�ƶ��ٶ�</t>"; }
				else if (%Leix $= 301){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>սʿ���ܵȼ�+1</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ʦ���ܵȼ�+1</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ʿ���ܵȼ�+1</t>"; }
				else if (%Leix $= 302){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����˺��ٷֱ�</t>"; }
				else if (%Leix $= 303){ %Buwei = "��ָ��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�﹥�˺�����</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����˺�����</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"�ھ���Ʒ������˵��</t><b/><t>��װ�������ھ������ԣ�ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >װ������</t><t>�ɻ�������������ԣ�</t>"@ %Shux @"</t>";


			case "KLJEquipStrengGui_ProImg9"://��ʮ������
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����һ����</t>"; }
				else if (%Leix $= 201){ %Buwei = "ͷ����";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����˺�����</t>"; }
				else if (%Leix $= 202){ %Buwei = "�ز���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�﹥�ܻ��˺�����</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ܻ��˺�����</t>"; }
				else if (%Leix $= 203){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����һ��������</t>"; }
				else if (%Leix $= 204){ %Buwei = "�粿��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�﹥�ܻ��˺�����</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ܻ��˺�����</t>"; }
				else if (%Leix $= 205){ %Buwei = "�ֲ���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����һ���˺�</t>"; }
				else if (%Leix $= 206){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����һ��������</t>"; }
				else if (%Leix $= 207){ %Buwei = "�Ų���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����˺�����</t>"; }
				else if (%Leix $= 301){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����һ���˺�</t>"; }
				else if (%Leix $= 302){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����һ����</t>"; }
				else if (%Leix $= 303){ %Buwei = "��ָ��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����һ���˺�</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"��ʮ��Ʒ������˵��</t><b/><t>��װ��������ʮ�����ԣ�ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >װ������</t><t>�ɻ�������������ԣ�</t>"@ %Shux @"</t>";


				//========================================================================================================װ��ϴ��========================================================================================

			case "EquipClearSoulWnd3_zhuanimg_5"://
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "������";%Shux = ""; }
				else if (%Leix $= 201){ %Buwei = "ͷ����";%Shux = ""; }
				else if (%Leix $= 202){ %Buwei = "�ز���";%Shux = ""; }
				else if (%Leix $= 203){ %Buwei = "������";%Shux = ""; }
				else if (%Leix $= 204){ %Buwei = "�粿��";%Shux = ""; }
				else if (%Leix $= 205){ %Buwei = "�ֲ���";%Shux = ""; }
				else if (%Leix $= 206){ %Buwei = "������";%Shux = ""; }
				else if (%Leix $= 207){ %Buwei = "�Ų���";%Shux = ""; }
				else if (%Leix $= 301){ %Buwei = "������";%Shux = ""; }
				else if (%Leix $= 302){ %Buwei = "������";%Shux = ""; }
				else if (%Leix $= 303){ %Buwei = "��ָ��";%Shux = ""; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"������Ʒ������˵��</t><b/><t>��װ���������������ԣ�ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >װ������</t><t>�ɻ�������������ԣ�</t><b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ͼӳ�</t></t>";


			case "EquipClearSoulWnd3_zhuanimg_6"://
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ٷֱȼӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ٷֱȼӳ�</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ٷֱȼӳ�</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ٷֱȼӳ�</t>"; }
				else if (%Leix $= 201){ %Buwei = "ͷ����";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��������ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t>"; }
				else if (%Leix $= 202){ %Buwei = "�ز���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��������ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t>"; }
				else if (%Leix $= 203){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������аٷֱ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������аٷֱ�</t>"; }
				else if (%Leix $= 204){ %Buwei = "�粿��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��������ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t>"; }
				else if (%Leix $= 205){ %Buwei = "�ֲ���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t>"; }
				else if (%Leix $= 206){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������аٷֱ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�������аٷֱ�</t>"; }
				else if (%Leix $= 207){ %Buwei = "�Ų���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ���԰ٷֱȼӳ�</t>"; }
				else if (%Leix $= 301){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���������ٷֱȼӳ�</t>"; }
				else if (%Leix $= 302){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���������ٷֱȼӳ�</t>"; }
				else if (%Leix $= 303){ %Buwei = "��ָ��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ϵ�����ӳ�</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���������ٷֱȼӳ�</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"������Ʒ������˵��</t><b/><t>��װ���������������ԣ�ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >װ������</t><t>�ɻ�������������ԣ�</t>"@ %Shux @"</t>";


			case "EquipClearSoulWnd3_zhuanimg_7"://
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٶȰٷֱȼӳ�</t>"; }
				else if (%Leix $= 201){ %Buwei = "ͷ����";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʼ���ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t>"; }
				else if (%Leix $= 202){ %Buwei = "�ز���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t>"; }
				else if (%Leix $= 203){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʰٷֱȼӳ�</t>"; }
				else if (%Leix $= 204){ %Buwei = "�粿��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʼ���ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t>"; }
				else if (%Leix $= 205){ %Buwei = "�ֲ���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٶȰٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʼ���ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t>"; }
				else if (%Leix $= 206){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʰٷֱȼӳ�</t>"; }
				else if (%Leix $= 207){ %Buwei = "�Ų���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�ƶ��ٶȰٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʼ���ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ָ��ӳ�</t>"; }
				else if (%Leix $= 301){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʰٷֱȼӳ�</t>"; }
				else if (%Leix $= 302){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʰٷֱȼӳ�</t>"; }
				else if (%Leix $= 303){ %Buwei = "��ָ��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ʰٷֱȼӳ�</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"�ڰ���Ʒ������˵��</t><b/><t>��װ�������ڰ������ԣ�ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >װ������</t><t>�ɻ�������������ԣ�</t>"@ %Shux @"</t>";

			case "EquipClearSoulWnd3_zhuanimg_8"://
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���������ٷֱȼӳ�</t>"; }
				else if (%Leix $= 201){ %Buwei = "ͷ����";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ֵ�ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ֵ�ٷֱȼӳ�</t>"; }
				else if (%Leix $= 202){ %Buwei = "�ز���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����˺�����ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����˺�����ٷֱȼӳ�</t>"; }
				else if (%Leix $= 203){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ưٷֱȼӳ�</t>"; }
				else if (%Leix $= 204){ %Buwei = "�粿��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ֵ�ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ֵ�ٷֱȼӳ�</t>"; }
				else if (%Leix $= 205){ %Buwei = "�ֲ���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ֵ�ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ֵ�ٷֱȼӳ�</t>"; }
				else if (%Leix $= 206){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����ٷֱȼӳ�</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ưٷֱȼӳ�</t>"; }
				else if (%Leix $= 207){ %Buwei = "�Ų���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ֵ�ٷֱȼӳ�</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ֵ�ٷֱȼӳ�</t>"; }
				else if (%Leix $= 301){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���������ٷֱȼӳ�</t>"; }
				else if (%Leix $= 302){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���������ٷֱȼӳ�</t>"; }
				else if (%Leix $= 303){ %Buwei = "��ָ��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�佫ְҵ����+1</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>����ְҵ����+1</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ʿְҵ����+1</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��ʿְҵ����+1</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>��˾ְҵ����+1</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"�ھ���Ʒ������˵��</t><b/><t>��װ�������ھ������ԣ�ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >װ������</t><t>�ɻ�������������ԣ�</t>"@ %Shux @"</t>";


			case "EquipClearSoulWnd3_zhuanimg_9"://
				if (isFile("gameres/gui/images/GUIbutton03_1_045.png")){ %Reward1 = "<i s='gameres/gui/images/GUIbutton03_1_045.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }
				%Leix = GetPartOfEquip();
				if ((%Leix $=101)||(%Leix $=102)||(%Leix $=103)||(%Leix $=104)||(%Leix $=105)||(%Leix $=106)||(%Leix $=107)){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�˺�����</t>"; }
				else if (%Leix $= 201){ %Buwei = "ͷ����";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӷ�������</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������������</t>"; }
				else if (%Leix $= 202){ %Buwei = "�ز���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӷ�������</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������������</t>"; }
				else if (%Leix $= 203){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���Ӷ�ϵ����</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӻ�ϵ����</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������ϵ����</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӽ�ϵ����</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӱ�ϵ����</t>"; }
				else if (%Leix $= 204){ %Buwei = "�粿��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӷ�������</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������������</t>"; }
				else if (%Leix $= 205){ %Buwei = "�ֲ���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӷ�������</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������������</t>"; }
				else if (%Leix $= 206){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���Ӷ�ϵ����</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӻ�ϵ����</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������ϵ����</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӽ�ϵ����</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӱ�ϵ����</t>"; }
				else if (%Leix $= 207){ %Buwei = "�Ų���";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�����������</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӷ�������</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������������</t>"; }
				else if (%Leix $= 301){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�˺�����</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���Ӷ�ϵ����</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӻ�ϵ����</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������ϵ����</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӽ�ϵ����</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӱ�ϵ����</t>"; }
				else if (%Leix $= 302){ %Buwei = "������";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�˺�����</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���Ӷ�ϵ����</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӻ�ϵ����</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������ϵ����</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӽ�ϵ����</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӱ�ϵ����</t>"; }
				else if (%Leix $= 303){ %Buwei = "��ָ��";%Shux = "<b/><t>1��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>�˺�����</t><b/><t>2��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���Ӷ�ϵ����</t><b/><t>3��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӻ�ϵ����</t><b/><t>4��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>������ϵ����</t><b/><t>5��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӽ�ϵ����</t><b/><t>6��</t><t>"@ %Reward1 @"</t><t gct='0x05f5feff' gcb='0x3d8fd8ff'>���ӱ�ϵ����</t>"; }

				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Buwei @"��ʮ��Ʒ������˵��</t><b/><t>��װ��������ʮ�����ԣ�ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff' >װ������</t><t>�ɻ�������������ԣ�</t>"@ %Shux @"</t>";


				//====================================================================================�ʼ�����===========================================================================================================
			case "MailWnd_Text_LetterNum1"://�ı�δ��

				if (isFile("gameres/gui/images/GUIWindow40_1_006.png")){ %weidu1 = "<i s='gameres/gui/images/GUIWindow40_1_006.png' w='16' h='16'/>"; }
				else{ %weidu1 = ""; }
				if (isFile("gameres/gui/images/GUIWindow40_1_007.png")){ %weidu2 = "<i s='gameres/gui/images/GUIWindow40_1_007.png' w='16' h='16'/>"; }
				else{ %weidu2 = ""; }
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰδ���ı��ʼ�����</t><b/>"@ %weidu1 @"<t>:�ʼ�δ��״̬</t><b/>"@ %weidu2 @"<t>:�ʼ��б���״̬</t></t>";

			case "MailWnd_Text_LetterNum2"://����δ��
				if (isFile("gameres/gui/images/GUIWindow40_1_006.png")){ %weidu1 = "<i s='gameres/gui/images/GUIWindow40_1_006.png' w='16' h='16'/>"; }
				else{ %weidu1 = ""; }
				if (isFile("gameres/gui/images/GUIWindow40_1_007.png")){ %weidu2 = "<i s='gameres/gui/images/GUIWindow40_1_007.png' w='16' h='16'/>"; }
				else{ %weidu2 = ""; }

				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰδ�������ʼ�����</t><b/>"@ %weidu1 @"<t>:�ʼ�δ��״̬</t><b/>"@ %weidu2 @"<t>:�ʼ��б���״̬</t></t>";

			case "MailWnd_Text_LetterNum0"://ϵͳδ��
				if (isFile("gameres/gui/images/GUIWindow40_1_006.png")){ %weidu1 = "<i s='gameres/gui/images/GUIWindow40_1_006.png' w='16' h='16'/>"; }
				else{ %weidu1 = ""; }
				if (isFile("gameres/gui/images/GUIWindow40_1_007.png")){ %weidu2 = "<i s='gameres/gui/images/GUIWindow40_1_007.png' w='16' h='16'/>"; }
				else{ %weidu2 = ""; }

				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰδ��ϵͳ�ʼ�����</t><b/>"@ %weidu1 @"<t>:�ʼ�δ��״̬</t><b/>"@ %weidu2 @"<t>:�ʼ��б���״̬</t></t>";

			case "MailWnd_CollectionNum"://�����ʼ�
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����ʼ�</t><b/><t>�����ʼ�������ʱ��Ӧ��ʱɾ���Ѷ��ʼ��������޷��������ʼ�</t></t>";

			case "MailWnd_ClearMailButton"://����ʼ�
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ѷ��ʼ�</t><b/><t>1������ı���������ϵͳ�����Ѷ����ʼ�</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>2������δ��ȡ��Ʒ��Ԫ�����ʼ��������ᱻ���</t></t>";

			case "MailWnd_DelectMailButton"://ɾ���ʼ�
				%ctrl.tooltipWidth = 330;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ɾ��ѡ���ʼ�</t><b/><t>1���蹴ѡ��Ҫɾ�����ʼ����ٵ���ð�ť</t><b/><t>2�������ҳȫѡ����ǰҳ�������ʼ����ᱻѡ��</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>3������δ��ȡ��Ʒ��Ԫ�����ʼ��������ᱻ���</t></t>";

			case "MailWnd_WriteMailButton"://д��
				%ctrl.tooltipWidth = 170;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>д��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>������ʼ��༭����</t></t>";

			case "MailWnd_SendmailPage_Topic"://����
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ʼ����⣨���</t><b/><t>������������12������</t></t>";

			case "MailWnd_SendmailPage_FriendNameButton"://������
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ʼ������ˣ����</t><b/><t>1������1��ǰ�޷����Ǻ��ѷ����ʼ���1�޼����Ͽɸ��Ǻ��ѷ����ʼ���������10�����</t><b/><t>2����������Ϊ�Ǻ��ѣ�����������Ҳ��</t><t c='0x2cffeeff'o='0x010101ff'>[��Ϊ����]</t><t>����Է��������ѹ�ϵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��������ɸ��������ѷ����ʼ�</t></t>";

			case "MailWnd_SendmailPage_Edit"://����
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ʼ����ģ����</t><b/><t>������������128������</t></t>";

			case "MailWnd_SendmailPage_MoneySilver"://��Ǯ
				if (isFile("gameres/gui/images/GUIWindow31_1_024.png")){ %jinyuan1 = "<i s='gameres/gui/images/GUIWindow31_1_024.png' w='16' h='16'/>"; }
				else{ %jinyuan1 = "��"; }
				if (isFile("gameres/gui/images/GUIWindow31_1_025.png")){ %jinyuan2 = "<i s='gameres/gui/images/GUIWindow31_1_025.png' w='16' h='16'/>"; }
				else{ %jinyuan2 = "��"; }
				if (isFile("gameres/gui/images/GUIWindow31_1_026.png")){ %jinyuan3 = "<i s='gameres/gui/images/GUIWindow31_1_026.png' w='16' h='16'/>"; }
				else{ %jinyuan2 = "ͭ"; }
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ԫ��</t><b/><t>1��ǰ�޷����Ǻ��Ѽ�����Ʒ��Ԫ��</t><b/><t>ÿ�μ���Ԫ������Ϊ999</t>"@%jinyuan1@"<t>99</t>"@%jinyuan2@"<t>99</t>"@%jinyuan3@"</t></t>";

			case "MailWnd_SendmailPage_MoneyCopper"://��Ǯ
				%ctrl.tooltipWidth = 250;
				if (isFile("gameres/gui/images/GUIWindow31_1_024.png")){ %jinyuan1 = "<i s='gameres/gui/images/GUIWindow31_1_024.png' w='16' h='16'/>"; }
				else{ %jinyuan1 = "��"; }
				if (isFile("gameres/gui/images/GUIWindow31_1_025.png")){ %jinyuan2 = "<i s='gameres/gui/images/GUIWindow31_1_025.png' w='16' h='16'/>"; }
				else{ %jinyuan2 = "��"; }
				if (isFile("gameres/gui/images/GUIWindow31_1_026.png")){ %jinyuan3 = "<i s='gameres/gui/images/GUIWindow31_1_026.png' w='16' h='16'/>"; }
				else{ %jinyuan2 = "ͭ"; }
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ԫ��</t><b/><t>1��ǰ�޷����Ǻ��Ѽ�����Ʒ��Ԫ��</t><b/><t>ÿ�μ���Ԫ������Ϊ999</t>"@%jinyuan1@"<t>99</t>"@%jinyuan2@"<t>99</t>"@%jinyuan3@"</t></t>";

			case "MailWnd_SendmailPage_MoneyGold"://��Ǯ
				%ctrl.tooltipWidth = 250;
				if (isFile("gameres/gui/images/GUIWindow31_1_024.png")){ %jinyuan1 = "<i s='gameres/gui/images/GUIWindow31_1_024.png' w='16' h='16'/>"; }
				else{ %jinyuan1 = "��"; }
				if (isFile("gameres/gui/images/GUIWindow31_1_025.png")){ %jinyuan2 = "<i s='gameres/gui/images/GUIWindow31_1_025.png' w='16' h='16'/>"; }
				else{ %jinyuan2 = "��"; }
				if (isFile("gameres/gui/images/GUIWindow31_1_026.png")){ %jinyuan3 = "<i s='gameres/gui/images/GUIWindow31_1_026.png' w='16' h='16'/>"; }
				else{ %jinyuan2 = "ͭ"; }
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ԫ��</t><b/><t>1��ǰ�޷����Ǻ��Ѽ�����Ʒ��Ԫ��</t><b/><t>ÿ�μ���Ԫ������Ϊ999</t>"@%jinyuan1@"<t>99</t>"@%jinyuan2@"<t>99</t>"@%jinyuan3@"</t></t>";

			case "MailWnd_GetMoneyButton"://ȫ����ȡ
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ȫ����ȡ</t><b/><t>����ð�ť��ȫ����ȡ���͵���Ʒ�ͽ�Ǯ</t></t>";

				//====================================================================================Ȥζ����===========================================================================================================

			case "AnswerQuestionTurnOnBnt_Tips":
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>Ŀǰ���ڴ���ʱ��,�������δ�μ�,�ɵ������ϼ������</t></t>";

			case "AnswerQuestionBmp_1"://����˵��
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������ֹ���</t><b/><t>1��ÿһ��������������Ϊ20��,��20�����ʱ��������,��1-2����������ȷ�ɻ��20��,3-4���ڻ��18��,��������</t><t c='0xadfff2ff'>(������ȷ���ٻ��5��+������ȷ���⽱����)</t><b/><t>2��������ȷ��������������ȷ������Խ�ߣ��ɻ�ø��ཱ����(�������ⲻ���ж�֮ǰ��������Դ���)</t><b/><b/><t c='0x00ff00ff'>ʹ��˫�����ֹ��ܣ�</t><b/><t>1����ѡ�ù��ܺ��õĻ��ֻᷭ�������ӱ�����۳�һ��</t><t gct='0xff65feff' gcb='0xff65feff'>����˫���÷ֿ�</t><b/><t>2��ÿ������ʹ������</t></t>";

			case "AnswerQuestionBmp_2"://����˵��
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������̣�</t><b/><t>1��׼���׶Σ�1����׼��ʱ�䣬������������׶�</t><b/><t>2������׶Σ���5���ӵĶ���ʱ��</t><b/><t>3������׶Σ���20���ӵĴ���ʱ�䣬��ʱ����ѡ��𰸣�������ύ��������������ʱ��Խ�ٻ�õĻ���Խ��</t><b/><t>4�������������5���ӵ��������ʱ��</t><b/><b/><t c='0x00ff00ff'>����������</t><b/><t>�������ͨ��������ȡ�������ﾭ�飬����ǰ10���������λ��һ�������ġ����عűҡ��͡��������衿��Ȥζ�ƺţ�δ��ǰ10��������5�����Ͽɻ��1�������عűҡ���</t></t>";


			case "AnswerQuestionCheckBox_Use"://��ѡ��ť
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ѡ��</t><t>����˫�����ֹ��ܣ�������ȷ����ֿɷ��ı�</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ѡ��</t><t>������ȷ���������������</t></t>";

				//====================================================================================ϵͳ����===========================================================================================================

			case "SysSettingMenu_Resolving"://ϵͳ����-�ֱ���
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ı���Ϸ����ķֱ��ʣ����ʹ��������������ٶ�</t></t>";

			case "SysSettingMenu_FSAA"://ϵͳ����-�����
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������Ϸ����������ı�Ե��ݣ�ʹ���濴������Ϊƽ��</t></t>";

			case "SysSettingCheckBtn_Window"://ϵͳ����-������ʾ
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12' c='0xf3d300ff' o='0x010101ff'><t>��ѡ��ѡ����ڴ���ģʽ�½�����Ϸ</t><b/><t>�繴ѡ��ѡ���Ϸ���潫�������õĴ��ڷֱ���ֵΪ׼</t></t>";

			case "SysSettingCheckBtn_FullWindow"://ϵͳ����-�������
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ѡ��ѡ������󻯴�����ʾ��ȥ���߿�</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ѡ������ʾ�����ܲ����������</t></t>";

			case "SysSetSlider_ScreenPlayer"://ϵͳ����-ͬ������
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ϸ��Ļ����ʾ���������������ͬ�������������Ϸ�����ٶ�</t></t>";

			case "SysSetSlider_SceneEffect"://ϵͳ����-��Чϸ��
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ϸ��Ļ����ʾ����Чϸ�ڣ�������Ч��ʾϸ�ڿ������Ϸ�����ٶ�,������Ч��Ҫ������Ϸ������Ч</t></t>";

			case "SysSettingCheckBtn_Quiet"://ϵͳ����-����
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���úͽ�����Ϸ����������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ѡ��������Ч</t></t>";

			case "SysSettingCheckBtn_OpenSound"://ϵͳ����-��Ч
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���úͽ�����Ϸ����ЧЧ��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ѡ��������Ч</t></t>";

			case "SysSettingCheckBtn_OpenMusic"://ϵͳ����-����
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���úͽ�����Ϸ�ڱ�������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ѡ��������Ч</t></t>";

			case "SysSetSlider_MusicVolume"://ϵͳ����-��������
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ϸ�ڱ������ֵ�����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������ֹ�ѡ״̬�µ�����Ч</t></t>";

			case "SysSetSlider_SoundVolume"://ϵͳ����-��Ч����
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ϸ����ЧЧ��������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>������Ч��ѡ״̬�µ�����Ч</t></t>";

			case "SysSetSlider_Lighteness"://ϵͳ����-����
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ϸ�ڻ����������</t></t>";

			case "SysSetSlider_Contrast"://ϵͳ����-�Աȶ�
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ϸ�ڻ���ĶԱȶ�</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�Աȶ�ֵԽ����Ϸ�����ɫ��Խ�ḻ</t></t>";

			case "SysSetSlider_TexturePrecision"://ϵͳ����-��ͼ����
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ϸ������ģ����ͼ�ľ�ϸ�ȣ����ʹ�ֵ�����������Ϸ���е��ٶȣ������ʵ�������Ϸ������Ч��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����Ķ���������Ϸ�������Ч</t></t>";

			case "SysSetSlider_ShadowDetail"://ϵͳ����-��Ӱϸ��
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ϸ�ڽ�ɫ�ͻ�������Ӱ��Ⱦ���������ʹ�����������Ϸ�����ٶ�</t></t>";

			case "SysSetSlider_SceneDetail"://ϵͳ����-����ϸ��
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ϸ������ģ��������������ʹ��������������ٶ�</t></t>";

			case "SysSettingCheckBtn_StaticAnimation"://ϵͳ����-�������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ϸ��������ж�����Ч�������ô��������΢�����Ϸ�����ٶ�</t></t>";

			case "SysSettingCheckBtn_FSBrightness"://ϵͳ����-ȫ������
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ȫ������Ч���������ữ�����Ե�����������ô�����ʱ���������Ϸ�����ٶ�</t></t>";

			case "SysSettingCheckBtn_WaterReflaction"://ϵͳ����-ˮ�淴��
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ϸˮ�淴���Ч�������ô��������΢�����Ϸ�����ٶ�</t></t>";

			case "SysSettingCheckBtn_ZhiWaWaMode"://ϵͳ����-ֽ����ģʽ
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ϸ�����ͳһ��Ϊֽ����ģ�ͣ����ô���ɽ����Կ�ѹ������Լϵͳ��Դ��������������������Ϸ��Ȥ</t></t>";

				//		case "SysSettingCheckBtn_CoastEffect"://ϵͳ����-����Ч��
				//			%ctrl.tooltipWidth = 230;
				//			%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ϸ�еĺ���Ч�������ô��������΢�����Ϸ�����ٶ�</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�ù�����δ����</t></t>";


				//====================================================================================�������===========================================================================================================

			case "ResurgenceButton_1"://(ԭ�ظ���)

				%Player = GetPlayer();
				if ((%Player.GetMetempsychosis() == 0) && (%Player.GetLevel() < 40)){ %txt = "ʣ��ԭ�ظ�������������ƣ�1��4��0�����£�"; }
				else { %txt = "����ʣ��ԭ�ظ��������"@ GetPlayer().GetOntheSpotRiseCount() @"��"; }


				ResurgenceWnd_Tips.setContent(%txt);


			case "ResurgenceButton_2"://(����㸴��)
				%txt ="��ǰ����㣺"@ GetRiseMap() @" ";
				ResurgenceWnd_Tips.setContent(%txt);

			case "ResurgenceButton_3"://(����㸴��)
				ResurgenceWnd_Tips.setContent("���� 100 Ԫ������ԭ�ظ���");

			case "Resurgence_AskBtn"://(ʹ��Ԫ��ԭ�ظ���)
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����ͷ�</t><b/><t>1������ʱ�᲻��ʧװ���;öȺͽ��</t><b/><t>2������ʱ�ƶ�ֵ���߽��ᱻ�������</t></t>";

				//Ⱥ�����Ը����е���������ؼ�
			case "SpecialResurgenceButton_1":	//���ǰһ��
				ResurgenceWnd_Tips.setContent("���ǰ��һ�㣬�������Ľ��");

			case "SpecialResurgenceButton_2":	//ԭ�ظ���
				ResurgenceWnd_Tips.setContent("���������Ľ������ԭ�ظ���");

				//====================================================================================����ʱ˵��===========================================================================================================

			case "TimerTriggerCtrl_Min_Icon":
				if (%Player.GetLevel() <  5)
				{
					%Minute = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>5</t>";
					%ctrl.tooltipWidth = 250;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���߽���</t><b/><t>�ﵽ"@%Minute@"��ʱ������ȡһ�ݾ�ϲ����</t></t>";
				}
				else{
					if (0 == $TimerTriggerLeftMinute && 0 == $TimerTriggerLeftSecond)
					{
						%ctrl.tooltipWidth = 250;
						%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���߽���</t><b/><t>����һ�ݾ�ϲ�������ȡ</t></t>";
					}
					else{
						%Minute = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>"@ $TimerTriggerLeftMinute@"</t>��";
						%Second = "<t gct='0x00ff00ff' gcb='0x2cffeeff'>"@ $TimerTriggerLeftSecond@"</t>��";
						%ctrl.tooltipWidth = 250;
						%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���߽���</t><b/><t>"@ %Minute @""@ %Second @"֮���������һ�ݾ�ϲ����</t></t>";
					}
				}



				//====================================================================================������ʾ����===========================================================================================================

			case "UpLinePartyWnd_SignIn_Btn":
				%ctrl.tooltipWidth = 320;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���߼��к�������</t><b/><t>ÿ�����߿���ȡ�������һ��</t><b/><t>ÿ���ۼ���ȡ</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>5��</t><t>����������ٻ��һ�������</t><b/><t>ÿ���ۼ���ȡ</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>20��</t><t>����������ٻ��һ�������</t></t>";

			case "UpLinePartyWnd_Draww_Btn1":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ÿ���ۼ���ȡ</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>5��</t><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������ɻ��һ�����������</t><b/><t>1,000,000���齱��</t><b/><t>100,000���</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>���л����õ��߽���</t></t>";

			case "UpLinePartyWnd_Drawd_Btn1":
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ÿ���ۼ���ȡ</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>20��</t><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������ɻ��һ�����������</t><b/><t>5,000,000���齱��</t><b/><t>300,000���</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>���л�����2000Ԫ���������ȵ��߽���</t></t>";

			case "UpLinePartyWnd_FreeBtn"://�����ȡ
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����ȡ���⾭��</t><b/><t>����ɫ����4��ʱ������ľ���һ�����ֻ������2��������ľ��齫���Զ�����ʦ�µľ�����У���ʹ��ʦ�����һ�</t></t>";

				//====================================================================================���޷�������===========================================================================================================

			case "PetEvaluationWnd_Bmp_Rate"://X����
				%ctrl.tooltipWidth = 290;

				%IsIdentify = PetOperation_IsPetIdentify($PetInfoWnd_PetSlot);

				if (%IsIdentify)
				{
					%nChengZhangLv = PetOperation_GetPetChengZhangLv($PetInfoWnd_PetSlot);

					if (%nChengZhangLv >= 18 && %nChengZhangLv < 840){ %PinZhi = "<t c= '0xffffffff'>����ͨ��</t>"; }
					else if (%nChengZhangLv >= 840 && %nChengZhangLv < 1560){ %PinZhi = "<t c= '0x46ff15ff'>�����㡹</t>"; }
					else if (%nChengZhangLv >= 1560 && %nChengZhangLv < 2220){ %PinZhi = "<t c= '0x226fffff'>����Ӣ��</t>"; }
					else if (%nChengZhangLv >= 2220 && %nChengZhangLv < 2860){ %PinZhi = "<t c= '0xca57ffff'>��������</t>"; }
					else if (%nChengZhangLv >= 2860 && %nChengZhangLv < 3300){ %PinZhi = "<t c= '0xff9600ff'>����˵��</t>"; }
					else if (%nChengZhangLv >= 3300){ %PinZhi = "<t c= '0xff1200ff'>�����졹</t>"; }

					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰ����Ǳ��Ϊ��</t>"@ %PinZhi @"<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ͨ������ϴ�������ɸı�����Ǳ��</t><b/><t>��ͨ�����޼ӵ�ʱ������������Գɳ�</t><b/><t c='0x26da13ff'>���㣺���޼ӵ�ʱ��ö���20%�����Գɳ�</t><b/><t c='0x226fffff'>��Ӣ�����޼ӵ�ʱ��ö���40%�����Գɳ�</t><b/><t c='0xca57ffff'>���������޼ӵ�ʱ��ö���60%�����Գɳ�</t><b/><t c='0xff9600ff'>��˵�����޼ӵ�ʱ��ö���80%�����Գɳ�</t><b/><t c='0xff1200ff'>���죺���޼ӵ�ʱ��ö���100%�����Գɳ�</t></t>";
				}
				else
				{
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ǳ��   </t><t c= '0xff1200ff'>δ����</t><b/><t c='0x5adfffff'>����Ľ���Ĵ�����Ǳ��</t><b/><t>��ͨ�����޼ӵ�ʱ������������Գɳ�</t><b/><t c='0x26da13ff'>���㣺���޼ӵ�ʱ��ö���20%�����Գɳ�</t><b/><t c='0x226fffff'>��Ӣ�����޼ӵ�ʱ��ö���40%�����Գɳ�</t><b/><t c='0xca57ffff'>���������޼ӵ�ʱ��ö���60%�����Գɳ�</t><b/><t c='0xff9600ff'>��˵�����޼ӵ�ʱ��ö���80%�����Գɳ�</t><b/><t c='0xff1200ff'>���죺���޼ӵ�ʱ��ö���100%�����Գɳ�</t></t>";
				}

				//====================================================================================���ͼ===========================================================================================================

			case "BigViewMap_Xpos"://X����
				%ctrl.tooltipWidth = 140;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����X�����</t><b/><t>��������Ϊ[1-100]</t></t>";

			case "BigViewMap_Ypos"://Y����
				%ctrl.tooltipWidth = 140;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Y�����</t><b/><t>��������Ϊ[1-100]</t></t>";

			case "BigViewMapBtn_Startoff"://������ť
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ѱ��</t><b/><t>����X��Y����㣬�����ť����ɫ�Զ�Ѱ����Ŀ���</t></t>";
			case "RecordPosButton"://��¼����
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip =
					"<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��¼���͵�</t><b/>" @
					"<t>�ڵ�ǰ��ɫ�����괦��¼һ����Ǻ󣬿���ֱ�ӵ����Ǵ��͵��˴���</t><b/>" @
					"<t>ÿ�δ�����Ҫ����һ��</t><t c='0xff65feff' o='0x2c2c2cff'>[�ǽ�ʯ]</t><b/>" @
					"<t>�˹���ֻ����Ұ���ͼ�����������س�ʹ��</t></t>";

			case "BigViewMap_MaterialSign0":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[0];//������ϱ��
			case "BigViewMap_MaterialSign1":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[1];//������ϱ��
			case "BigViewMap_MaterialSign2":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[2];//������ϱ��
			case "BigViewMap_MaterialSign3":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[3];//������ϱ��
			case "BigViewMap_MaterialSign4":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[4];//������ϱ��
			case "BigViewMap_MaterialSign5":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[5];//������ϱ��
			case "BigViewMap_MaterialSign6":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[6];//������ϱ��
			case "BigViewMap_MaterialSign7":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[7];//������ϱ��
			case "BigViewMap_MaterialSign8":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[8];//������ϱ��
			case "BigViewMap_MaterialSign9":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[9];//������ϱ��
			case "BigViewMap_MaterialSign10":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[10];//������ϱ��
			case "BigViewMap_MaterialSign11":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[11];//������ϱ��
			case "BigViewMap_MaterialSign12":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[12];//������ϱ��
			case "BigViewMap_MaterialSign13":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[13];//������ϱ��
			case "BigViewMap_MaterialSign14":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[14];//������ϱ��
			case "BigViewMap_MaterialSign15":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[15];//������ϱ��
			case "BigViewMap_MaterialSign16":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[16];//������ϱ��
			case "BigViewMap_MaterialSign17":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[17];//������ϱ��
			case "BigViewMap_MaterialSign18":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[18];//������ϱ��
			case "BigViewMap_MaterialSign19":	%ctrl.tooltipWidth = 200; %ctrl.tooltip = $BigViewMap_MaterialSign[19];//������ϱ��
				//====================================================================================������icon��ʾ�ȸ�===========================================================================================================


			case "UpLinePartyTurnOnBnt_Tips"://���տɽ�ȡ��Ŀ������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ȡ����Ŀ��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�������򿪽���Ŀ������ȡ�������ȡ����</t></t>";

			case "WuHun"://��갴ť
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���</t><b/><t>����������걳�����ȼ�Խ�ߵ�������ӵ���������Խ��</t><b/><t c='0x00ff00ff' >������ͨ���ѻ���</t></t>";

			case "JingMai"://����
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>ͨ������ǿ��������ζ�����������������������</t><b/><t c='0x00ff00ff' >����ǿ�����Ͽ��ھ��鸱���л��</t></t>";

			case "PlayerLevelOperateCue_1"://ѡ��ְҵ����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ѡ��ְҵ����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�ﵽ1�޿�ǰ��ʥ�ؼ���ʦ��ѡ����ְҵ����</t></t>";

			case "PlayerLevelOperateCue_2"://��ȡ����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ȡ����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�ﵽ2�޿���ʥ�ػ�����ʦ�������ȡ����ʹ����ս�����������ϸ���ǿ��</t></t>";

			case "PlayerLevelOperateCue_3"://��ȡ����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ȡ����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�ﵽ3�޿���ȡ��Ѥ�������Զ�ս����һ�������</t></t>";

			case "PlayerLevelOperateCue_4"://��������
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�ﵽ4����������������񣬱��������ʹ��������������</t></t>";

			case "PlayerLevelOperateCue_5"://��ȡʥ��ר������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ѧϰ�����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >��������̫�׽��ǻ�������ѧϰ����ܣ���������һ�������¸��ĵ�·</t></t>";

			case "PlayerLevelOperateCue_6"://����/��������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����/��������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�ɵ������������İ��ɹ������ܴ�����/��������</t></t>";

			case "PlayerLevelOperateCue_7"://��ͽ
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ͽ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�ɵ������������洦����ʦͽ��ϵ���ɻ�÷����Ŷ</t></t>";

			case "PlayerLevelOperateCue_8"://ѡ��ڶ�ְҵ
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ѡ��ڶ�ְҵ����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�ﵽ6�޿�ǰ��ʥ�ؼ���ʦ��ѡ��ڶ�ְҵ����</t></t>";

			case "PlayerLevelOperateCue_9"://ӵ�����
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ӵ�����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�ﵽ6�޿�����������������ѻ�Ŵ�����һ��˧�����磬������˲������</t></t>";

			case "XiTurnOnBnt_Tips"://��Ӫ�
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ؾ��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >�������򿪵�ǰ���ؾ������ڽ��еĻ���μӻ�ɻ�ùٷ����Ľ�Ʒ</t></t>";

			case "ExchangePoints_Min_Bnt"://װ���һ���ʾ

				if ($CurSelectModeId == 0){ %KJJ ="<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>���ٴ򿪽�������ݼ���N</t>"; }
				else if ($CurSelectModeId == 1){ %KJJ =""; }
				else if ($CurSelectModeId == 2){ %KJJ ="<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>���ٴ򿪽�������ݼ���N</t>"; }
				else if ($CurSelectModeId == 3)
				{
					if (GetHotKey("��/�رջ����̵����") !$= "")
						%KJJ = "<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>���ٴ򿪽�������ݼ���" @ GetHotKey("��/�رջ����̵����") @ "</t>";
				}

				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ֶһ�</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff' >���û���ֺ�ս�����ֿɶһ���ǰ�����ʺ�����װ��</t>"@ %KJJ @"</t>";


				//====================================================================================���ܲ�������===========================================================================================================

			case "TrumpInlayBmp_Explain"://��Ƕ˵��
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ƕ������</t><b/><t>1�����޵ȼ�������Ƭ�ĵȼ�Ҫ��</t><b/><t>2��������Ƭ��ɫ��������Ƕ�۵���ɫһ��</t><b/><t>3������Ʒ��������Ƭ��Ʒ��Ҫ��</t><b/><t>4����ɫ�������ڵ���20��</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ƕ����</t><b/><t>1�������Ƕ��������װ������Ƭ�����Ի�ӳɵ���ɫ��</t><b/><t>2��ͬһ����Ƕ����Ƕ��3����ͬ����Ƭ���Զ���ϳ����1�����������</t><b/><t>3������Ƕ����Ƕ�벻ͬ���͵���Ƭ���ɵ���Ƭ��ɾ��</t></t>";


			case "TrumpPuddlerBmp_Tips"://����˵��
				%ctrl.tooltipWidth = 300;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������</t><b/><t>1�������޺͸�����Ҫ��ȼ�25����Ʒ����ͬ</t><b/><t>2��ӵ���㹻�����Ʋ���</t><b/><t>3����Ҫ����Ԫ��</t><b/><t>4��������ʣ������ƴ���</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ƹ���</t><b/><t>1�������гɹ��ʣ���ͨ����Ϊ90%���߼�����Ϊ70%���ؼ�����Ϊ50%</t><b/><t>2�����Ƴɹ��������޵�Ʒ�ʻ�����</t><b/><t>3�����������Ƿ�ɹ��������޶�����ʧ</t></t>";


				//====================================================================================���ؾ��̳�===========================================================================================================

			case "BusinessCity_Recharge_Btn"://��ֵ
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ԫ����ֵ</t><b/><t>���Ե���ҳ����ͨ���󶨵�֧�����˺ų�ֵ����ֵ����Ҫ������ȡԪ������ť����ȡԪ���ſ����ڷ�����ʹ��</t></t>";

			case "Vip_TodayGoalWnd_2_GetYuanBao"://VIP��Ȩ������ȡԪ��
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ȡԪ��</t><b/><t>��ֵ����Ҫ��������ȡԪ���ſ����ڱ�������ʹ��</t></t>";

			case "BusinessCity_Drawing_Btn"://��ȡԪ��
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ȡԪ��</t><b/><t>��ֵ����Ҫ��������ȡԪ���ſ����ڱ�������ʹ��</t></t>";

			case "BusinessCity_XianRock"://Ԫ��
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ԫ��</t><b/><t>����ʱװ�̳��й���ʱװ���������й���������ҳ��۵ĵ���</t></t>";


				//====================================================================================���ɽ���===========================================================================================================
			case "Family_CreatorWnd_CreateBTN"://��������
				%ctrl.tooltipWidth = 275;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>1������Ҫ�����İ����������ȷ�������������Ƿ�ɴ���</t></t>";

			case "Family_Wnd1_ChgAfficheBTN"://
				%ctrl.tooltipWidth = 275;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�޸İ��ɹ���</t><b/><t>���������ɹ���༭�������빫��󣬵���޸Ĺ��水ť���������°��ɹ���</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�����͸����������޸�Ȩ��</t></t>";

			case "FamilyMemberMessage_Family_Info"://���ɵȼ�˵��
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ɳ�Ա�ȼ����蹱��ֵ������</t><b/><t>���½����ڡ���0��1000</t><b/><t>����ͨ���ڡ���1000��10000</t><b/><t>����ͨ��Ӣ����10000��30000</t><b/><t>���߼���Ӣ����30000��100000</t><b/><t>������Ԫ�ϡ���100000��999999</t></t>";

			case "FamilyBaseBnt_ApoointMember"://����
				%ctrl.tooltipWidth = 275;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ְλ����</t><b/><t>1.���������������ɳ�ԱΪ������������</t><b/><t>2.ѡ��ǰְλ����ҿ��Խ��г�ְ����</t><b/><t>3.ÿ��������ֻ�ܵ���һ��ְλ</t></t>";

			case "FamilyBaseText_Name"://��������
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>������������Ʋ����޸�</t></t>";

			case "FamilyBaseText_LeaderName"://����
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ɰ���</t><b/><t>�����͸���������ӳ�Ա�������Ա</t></t>";

			case "FamilyBaseText_Money"://�����ʽ�
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����ʽ�</t><b/><t>���ɳ�Ա��ͨ��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>����</t><t>��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>����</t><t>�����Ӱ����ʽ𣬰��������ð����ʽ���а������ʵ��з�������</t></t>";

			case "FamilyBaseText_Credit"://��������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>1����ʾ����ǰ��������ֵ/��������һ����������ֵ</t><b/><t>2�����ɳ�Ա��ͨ����ɰ�������������������������߿��������ɵȼ�</t></t>";

			case "FamilyBaseText_Level"://���ɵȼ�
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ɵȼ�</t><b/><t>1����ǰ���������ﵽ������������ֵ����������ǰ������</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>����</t><t>���������ɵȼ�</t><b/><t>2�����ɵȼ�Խ�߿ɼ����ԱԽ�࣬�����������İ�������</t></t>";

			case "FamilyBaseText_Activity"://���ɻ�Ծ��
				%ctrl.tooltipWidth = 340;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ɻ�Ծ��</t><b/><t>1����ʾ����ǰ���ɻ�Ծ��/��ǰ���ɵȼ������Ծ����Сֵ</t><b/><t>2����Ծ���������а��ɳ�Ա�ĵ�ǰ��Ծ���ۼӶ���</t><b/><t>3��ֻҪ���ɳ�Ա���ߣ���ɰ������񡢲μӻ������</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>�������Լ��ȼ�10������</t><t>�Ĺ��ﶼ������һ����Ծֵ</t><b/><t>4����Ծ�Ȼ�Ӱ�����</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��������</t><t>������ǰ��Ծֵ����������Сֵʱ�������ٵ�ǰ</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>30%</t><t>�İ�������ֵ</t></t>";

			case "Family_Wnd1ListBtn_memberLevel"://������Ϣ�еĳ�Ա�ȼ�
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ɳ�Ա�ȼ����蹱��ֵ������</t><b/><t>���½����ڡ���0��1000</t><b/><t>����ͨ���ڡ���1000��10000</t><b/><t>����ͨ��Ӣ����10000��30000</t><b/><t>���߼���Ӣ����30000��100000</t><b/><t>������Ԫ�ϡ���100000��999999</t></t>";

			case "Family_Wnd1ListBtn_level_Family"://������Ϣ�еĳ�Ա�ȼ�
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ɳ�Ա�ȼ����蹱��ֵ������</t><b/><t>���½����ڡ���0��1000</t><b/><t>����ͨ���ڡ���1000��10000</t><b/><t>����ͨ��Ӣ����10000��30000</t><b/><t>���߼���Ӣ����30000��100000</t><b/><t>������Ԫ�ϡ���100000��999999</t></t>";

			case "FamilyBaseBmp_Business"://��������Ȩ
				if (FamilyBaseText_Business.GetText()$="0/0")
				{
					%ctrl.tooltipWidth = 265;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t gct='0xff7171ff' gcb='0xff3c00ff'>���İ���δ�ܽ����Ծ�����а񣬻�δӵ������Ȩ</t><b/><t>ÿ��ֻ�н�����ɻ�Ծ�����а��2�����ϰ��ɲſ�ӵ������Ȩ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���հ������̽��ά���������</t></t>";
				}
				else
				{
					%ctrl.tooltipWidth = 250;
					%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���İ�����ӵ������Ȩ</t><b/><t>ÿ��ֻ�н�����ɻ�Ծ�����а��2�����ϰ��ɲſ�ӵ������Ȩ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���հ������̽��ά��������ҺͶ�������ﾭ��</t></t>";
				}
			case "FamilyBaseText_Business"://����Ȩ����
				if (FamilyBaseText_Business.GetText()$="0/0")
				{
					%txt ="<b/><t gct='0xff7171ff' gcb='0xff3c00ff'>���İ���δ�ܽ����Ծ�����а񣬻�δӵ������Ȩ</t>";
				}
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ʾ����Ȩ��ʣ���������</t>"@ %txt @"</t>";

			case "FamilyBaseBnt_AddMember"://��ӳ�Ա
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ӳ�Ա</t><b/><t>�����͸����������������ް��ɵ���Ҽ������</t></t>";

			case "FamilyBaseBnt_List"://�����б�
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����б�</t><b/><t>�����͸������ɴ������б���棬�����ύ����������ҽ�����ɣ����������Զ�������Ҽ������</t></t>";

			case "FamilyBaseBnt_ChangeReMark"://�޸ı�ע
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�޸ı�ע</t><b/><t>�����͸������ɶ԰����ڵĳ�Ա��ӱ�ע˵��</t></t>";

			case "FamilyBaseBnt_SetViceLeader"://���ø�����
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����������</t><b/><t>����������2λ������һ�����������</t></t>";

				//			case "FamilyBaseBnt_GetPay"://�칤��
				//				%ctrl.tooltipWidth = 220;
				//				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ȡ����</t><b/><t>����</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>����</t><t>�ſɽ��Լ��İ��ɻ�����1:50�ı���ת��Ϊ���</t></t>";

			case "FamilyBaseBnt_TransferLeader"://ת�ð���
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ת�ð���</t><b/><t>�����ɽ��Լ���ְλת�����������</t></t>";

			case "FamilyBaseBnt_KickOut"://�������
				%ctrl.tooltipWidth = 215;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t><b/><t>�����͸������ɽ����ɳ�Ա�������</t></t>";

			case "FamilyBaseBnt_LevelFamily"://�˳�����
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�˳�����</t><t gct='0xff7171ff' gcb='0xff3c00ff'> �����أ�</t><b/><t>�˳����ɺ����¼��룬ֻ����80%�İ��ɹ�������ɻ��ң���������µİ��ɣ���ȫ�����</t></t>";

			case "Family_Examine_Family_Memeber_Info"://�鿴���ڵȼ�˵��
				%ctrl.tooltipWidth = 285;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ڵȼ�˵��</t><b/><t>1�����Ӷ԰��ɵĹ���ֵ���������ڵȼ���ͨ����ɰ����������̡����׵ȶ����ð��ɹ���ֵ</t><b/><t>2�����ڽ���˵����</t><b/><t>���½����ڡ���0��1000����ֵ</t><b/><t>����ͨ���ڡ���1000��10000����ֵ</t><b/><t>����ͨ��Ӣ����10000��30000����ֵ</t><b/><t>���߼���Ӣ����30000��100000����ֵ</t><b/><t>������Ԫ�ϡ���100000��999999����ֵ</t></t>";

			case "FamilyBaseText_OnlineCounts"://��Ա����
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ա����</t><b/><t>1����ʾ��������������/��ǰ���ɵȼ���������</t><b/><t>2���������ɵȼ������ӿɼ���ĳ�Ա��������</t></t>";

			case "FamilyBaseText_MyContribute"://�ҵĹ���ֵ
				%ctrl.tooltipWidth = 295;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ҵİ��ɹ���ֵ</t><b/><t>1��ͨ����ɰ����������̡����׵ȶ����ð��ɹ���ֵ</t><b/><t>2�����ɹ���ֵ��߿�������Ӧ�ڰ����ڵİ��ڵȼ�</t></t>";

			case "FamilyBaseText_MyLevel"://�ҵİ��ɵȼ�
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ҵİ��ڵȼ�</t><b/><t>���ڵȼ�����ͨ����߶԰��ɵĹ���ֵ�������ȼ�</t><b/><t>���ڵȼ��ȼ�Խ�ߣ���������Ľ�����Խ���</t><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ڵȼ�˵��</t><b/><t>1��ͨ����ɰ����������̡����׵ȶ����ð��ɹ���ֵ</t><b/><t>2�����ڽ���˵����</t><b/><t>���½����ڡ���0��1000����ֵ</t><b/><t>����ͨ���ڡ���1000��10000����ֵ</t><b/><t>����ͨ��Ӣ����10000��30000����ֵ</t><b/><t>���߼���Ӣ����30000��100000����ֵ</t><b/><t>������Ԫ�ϡ���100000��999999����ֵ</t></t>";

			case "FamilyBaseText_MyMonmey"://�ҵİ��ɻ���
				%ctrl.tooltipWidth = 305;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ҵİ��ɻ���</t><b/><t>1�����ɻ���ֻ��ͨ���������������񡿻��</t><b/><t>2�����ɻ��ҿ��ڰ��������ڹ��������Ʒ</t><b/><t>3���뿪���ɻ���հ��ɻ���</t></t>";

			case "Family_Wnd2_Bnt"://��ȡ��������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ȡ��������</t><b/><t>ͬʱֻ�ܽ�ȡһ����������</t><b/><t>��ɰ��ɿ��Ի�ô��������ﾭ������Ӱ�������ֵ</t></t>";

			case "Family_Wnd4_SetCumulateBTN"://���ý��踱��
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ý��踱��</t><b/><t>�����򸱰������úý��踱�������ڲ��ܸ����õĸ������н���</t></t>";

			case "Family_Wnd4_CumulateBTN"://�������
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t><b/><t>���׽��ȴﵽ100%������ɿ������ɸ�����������������ȹ��㡣</t></t>";

			case "Family_Wnd6_AddFamily"://��Ӱ���
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ӱ���</t><b/><t>�����͸�����������������Ѫ�˵İ��ɼ���Ѫ��</t></t>";

			case "Family_Wnd6_AskedList"://�����б�
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����б�</t><b/><t>�����͸������ɴ������б���棬�����ύ�������İ��ɽ���Ѫ�ˣ����������Զ�������ɼ���Ѫ��</t></t>";

			case "Family_Wnd6_FamilyReMark"://���ɱ�ע
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�޸İ��ɱ�ע</t><b/><t>�����͸������ɶ�Ѫ���ڵİ�����ӱ�ע˵��</t></t>";

			case "Family_Wnd6_TransferLeagueLeader"://ת������
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ת������</t><b/><t>�����ɽ��Լ���ְλת���������ɵİ���</t></t>";

			case "Family_Wnd6_KickOutLeague"://����Ѫ��
				%ctrl.tooltipWidth = 215;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ѫ��</t><b/><t>�����͸������ɽ�Ѫ���ڵİ������뱾Ѫ��</t></t>";

			case "Family_Wnd6_LeaveLeague"://�˳�Ѫ��
				%ctrl.tooltipWidth = 245;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�˳�Ѫ��</t><t gct='0xff7171ff' gcb='0xff3c00ff'> �����أ�</t><b/><t>�˳�Ѫ�˻���ո���Ѫ���йص���Ϣ</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>���ɵİ������ܽ����˳�Ѫ�˲���</t></t>";

			case "Family_Wnd6_Domain"://���
				%ctrl.tooltipWidth = 80;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ѫ�����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��δ����</t></t>";

			case "Family_Wnd6_HolePlace"://���츣��
				%ctrl.tooltipWidth = 80;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���츣��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��δ����</t></t>";

			case "Family_Wnd6_Business_bitmap"://��������Ȩ
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ʾ�����Ƿ�ӵ������Ȩ</t><b/><t>ÿ��ֻ�б��������а��ɻ�Ծ������ǰ30λ��2�����ϰ��ɲſ�ӵ������Ȩ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ͨ�����̻�ô������</t></t>";

			case "Family_Wnd6_text1"://Ѫ������
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ѫ������</t><b/><t>������Ѫ�����Ʋ����޸�</t></t>";

			case "Family_Wnd6_text2"://Ѫ�˵ȼ�
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ѫ�˵ȼ�</t><b/><t>��ӵ�еİ��ɵȼ�֮�;�������˻����Ű��ɵĽ�����˳��仯</t><b/><t>��Ѫ��1�������ɵȼ�֮��Ϊ1-8</t><b/><t>��Ѫ��2�������ɵȼ�֮��Ϊ9-17</t><b/><t>��Ѫ��3�������ɵȼ�֮��Ϊ18</t></t>";

			case "Family_Wnd6_text3"://Ѫ������
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ѫ������</t><b/><t>ֻ�������͸�����������Ӱ��ɺ�������ɵ�Ȩ��</t></t>";

			case "Family_Wnd6_text4"://Ѫ�˳�Ա����
				%ctrl.tooltipWidth = 275;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ѫ�˳�Ա����</t><b/><t>1����ʾ��Ѫ����������/Ѫ�˿���������</t><b/><t>Ѫ�˿���������ΪѪ���ڰ��ɵĿ��������ܺ�</t></t>";

			case "Family_Wnd6_text5"://Ѫ�˸�����
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ѫ�˸�����</t><b/><t>ֻ�������͸�����������Ӱ��ɺ�������ɵ�Ȩ��</t><b/><t>��������Ѫ���ڰ���������ߵİ������Σ������������⣩</t></t>";

			case "Family_Wnd6_text6"://Ѫ������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ѫ������</t><b/><t>Ѫ������ΪѪ�������а����������ܺ;������ܺ�Խ��Ѫ������Խ��</t></t>";

			case "Family_Wnd6_text7"://���ɰ���
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���ɰ���</t><b/><t>Ѫ���ڰ��ɵİ�������</t></t>";

			case "Family_Wnd6_text8"://��������
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>ѡ�а��ɵĳ�Ա����</t></t>";

			case "Family_Wnd6_ChgLeagueAfficheBTN"://�޸Ĺ���
				%ctrl.tooltipWidth = 275;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�޸�Ѫ�˹���</t><b/><t>�������Ѫ�˹���༭�������빫��󣬵���޸Ĺ��水ť����������Ѫ�˹���</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>ֻ�������͸��������޸�Ȩ��</t></t>";

			case "Family_Wnd6_League_Affiche"://Ѫ�˹���
				%ctrl.tooltipWidth = 275;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ѫ�˹���</t><b/><t>�����͸������ɼ����༭��������Ѫ�˹��棬����޸Ĺ��水ť������Ѫ�˳�Ա���ܲ鿴�����µ�Ѫ�˹���</t></t>";

			case "Family_Wnd1ListBtn_state"://����ֵ
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'>����ֵӰ����ɳ�Ա�ȼ�</t>";

				//====================================================================================��ؼ��ȸ�===========================================================================================================

			case "KillPointCountGUI_Count"://ս������
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ս������˵��</t><b/><t>һ��������� ս�����֣�12/12</t><b/><t>����������� ս�����֣�30/30</t><b/><t>��������Ĳ� ս�����֣�54/54</t><b/><b/><t>���㽵��һ�� ս�����֣�0/12</t><b/><t>���㽵������ ս�����֣�12/30</t><b/><t>�Ĳ㽵������ ս�����֣�30/54</t></t>";

			
				//====================================================================================�̶�̯λ===========================================================================================================

			case "FixedStaller_TaxTxt"://ÿ��˰��
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ÿ��˰��</t><b/><t>ÿ���賿12��ϵͳ�ӹ̶��ʽ��п۳�</t><b/><t>���̶��ʽ���������֧��ÿ��˰��ʱ�����̵�����Ȩ���������һ��Ҫ��֤�̶��ʽ��ԣ</t></t>";

			case "FixedStaller_GloryTxt"://���ٶ�
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���̷��ٶ�</t><b/><t>���ٶ�Խ�ߣ�����ʱϵͳ���յ�˰�վ�Խ��</t><b/><t>ÿ����һҳ������Ʒҳ���������ҳ�����ٶ��Զ�����10��</t></t>";

			case "FixedStaller_RevenueTxt"://˰��
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����˰��</t><b/><t>��Ʒ���ۺ�ϵͳ�ᰴ��˰�հٷֱ���ȡ����˰</t><b/><t>���̵ķ��ٶ�Խ�����յĽ���˰Խ��</t></t>";

			case "FixedStall_TipIcon"://ÿ��˰��
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ÿ��˰��</t><b/><t>ÿ���賿0��ϵͳ�ӹ̶��ʽ��п۳�</t><b/><t>���̶��ʽ���������֧��ÿ��˰��ʱ�����̵�����Ȩ���������һ��Ҫ��֤�̶��ʽ��ԣ</t></t>";

			case "FixedStaller_Revenue"://˰��
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����˰��</t><b/><t>��Ʒ���ۺ�ϵͳ�ᰴ��˰�հٷֱ���ȡ����˰</t><b/><t>���̵ķ��ٶ�Խ�����յĽ���˰Խ��</t></t>";

			case "FixedStaller_Glory"://���ٶ�
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���̷��ٶ�</t><b/><t>���ٶ�Խ�ߣ�����ʱϵͳ���յ�˰�վ�Խ��</t><b/><t>ÿ����һҳ������Ʒҳ���������ҳ�����ٶ��Զ�����10��</t></t>";

			case "FixedStaller_TaxTxt"://ÿ��˰��
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ÿ��˰��</t><b/><t>ÿ���賿12��ϵͳ�������ʽ��п۳�</t><b/><t>�������ʽ���������֧��ÿ��˰��ʱ�����̵�����Ȩ���������һ��Ҫ��֤�����ʽ��ԣ</t></t>";

				//====================================================================================���޽���ս�����ֽ���===========================================================================================================


			case "FightAssistant_Skill_ShortcutWnd_StartFightBtn"://�������޹һ�
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����Զ�ս������ݼ���=��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>װ�����޺󼴿�ʹ��</t><b/><t>�����Զ�ս�����ã���ݼ���Z�����趨���ܺ��Զ�ս����Χ��</t></t>";

			case "FightAssistant_Skill_ShortcutWnd_StopFightBtn"://�ر����޹һ�
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ر��Զ�ս������ݼ���=��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>װ�����޺󼴿�ʹ��</t><b/><t>�����Զ�ս�����ã���ݼ���Z�����趨���ܺ��Զ�ս����Χ��</t></t>";

			case "FightAssistant_LeftTime"://�ر����޹һ�
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�һ�����ʣ��ʱ��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>ÿ��0ʱ����Ϊ360����</t><b/><t>����һ�����״̬�󣬽��������Ĵ�ʱ�䣻ʱ�䲻��ʱ����ʧȥ�һ�����״̬</t></t>";


				/*
				case "FightAssistant_Skill_ShortcutWnd_FightBtn"://���޹һ���ť
				%ctrl.tooltipWidth = 260;
				if (FightAssistant_Skill_ShortcutWnd_FightEffect.isVisible()) //��ť��Ч������ʾ״̬
				{
				%txt1="�Զ�ս��������";
				%txt2="<t gct='0x00ff00ff' gcb='0x2cffeeff'>�Զ�ս���������������޵�����ֵ</t><b/><t>�Զ�ս��ʱ�ͷŵļ��������ս�����ֽ�������</t>";
				}
				else
				{
				%txt1="�Զ�ս���ѹر�";
				%txt2="<t gct='0x00ff00ff' gcb='0x2cffeeff'>�����ť�ɿ��������Զ�ս������</t><b/><t>�Զ�ս��ʱ�ͷŵļ��������ս�����ֽ�������</t>";
				}
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@%txt1 @"</t><b/><t>"@ %txt2@"</t></t>";
				*/
			case "FightAssistantBnt_Start"://�������޹һ�
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����Զ�ս������ݼ���=��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>װ�����޺󼴿�ʹ��</t><b/><t>�ɹ�ѡ���Զ�ս������������ٱ�ݵĿ�����ر��Զ�ս������</t></t></t>";


			case "FightAssistantBnt_End"://�ر����޹һ�
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ر��Զ�ս������ݼ���=��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>װ�����޺󼴿�ʹ��</t><b/><t>�ɹ�ѡ���Զ�ս������������ٱ�ݵĿ�����ر��Զ�ս������</t></t></t>";



				//====================================================================================�쾵����===========================================================================================================
			case "BirdTianJingButton"://�쾵

				if (IsInArena())

				{
					%width=190;
					%txt="<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�쾵���������У�</t><b/><t>Ŀǰ�����ھ�������ͼ��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ɲ鿴������ͳ����Ϣ</t>";
				}
				else if (GetZoneID()==1136 || IsInBattlefield())
				{
					%width=180;
					%txt="<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�쾵��ս���У�</t><b/><t>Ŀǰ������ս����ͼ��</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ɲ鿴ս��ͳ����Ϣ</t>";
				}
				else
				{
					%nState =	SptRandTeamGetState();
					if (%nState == 1)
					{
						%width=260;
						%txt1="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���˿�ֱ�Ӵ��쾵����������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���״̬��ֻ�жӳ����ܴ��쾵ѡ��Ҫ����ĸ���</t>";

						%txt="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�쾵�������ӣ�</t><b/><t>�������ٵ����һ֧���飬Ȼ�������������ս������������</t>"@ %txt1 @"";
					}

					else if ((%nState == 4)||(%nState == 5))
					{
						%width=240;
						%txt="<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�쾵���Ŷ�״̬��</t><b/><t>Ŀǰ�������Ŷ�״̬</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�򿪶��еȴ����棬�鿴�Ŷ���Ϣ</t>";
					}
					else if (%nState == 6)
					{
						if (IsInCopyMap()==0)
						{
							%txt1="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ�����쾵��ťֱ�ӽ��븱��</t>";
						}
						else if (IsInCopyMap()==1)
						{
							%txt1="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ҽ�����쾵��ťֱ�Ӵ�������</t>";
						}
						%width=260;
						%txt="<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�쾵���Ŷ���ϣ�</t><b/><t>Ŀǰ���Ѿ��Ŷ����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�򿪶��еȴ����棬������밴ť������</t>"@ %txt1 @"";
					}
				}

				%ctrl.tooltipWidth = %width;
				%ctrl.tooltip ="<t m='1' f='����' n='12'>"@ %txt @"</t>";

			case "RandomTeamRole_Defence"://�������-������
				if (RandomTeamRole_Defence.isActive()==0){ %txt="<b/><t c= '0xff1200ff'>����ְҵ���ʺϣ��޷�ѡ��˽�ɫ</t>"; }
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������(�佫)</t><b/><t>С�����ǿ�ı���</t><b/><t>��Ҫ�����������˳�޲��е��˺�</t>"@ %txt @"</t>";

			case "RandomTeamRole_Doctor"://�������-������
				if (RandomTeamRole_Doctor.isActive()==0){ %txt="<b/><t c= '0xff1200ff'>����ְҵ���ʺϣ��޷�ѡ��˽�ɫ</t>"; }
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������(��ʿ)</t><b/><t>С���������ĺ��</t><b/><t>��Ҫ��������С�ӳ�Ա</t>"@ %txt @"</t>";

			case "RandomTeamRole_Attacker"://�������-�˺���
				if (RandomTeamRole_Attacker.isActive()==0){ %txt="<b/><t c= '0xff1200ff'>����ְҵ���ʺϣ��޷�ѡ��˽�ɫ</t>"; }
				%ctrl.tooltipWidth = 230;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�˺���</t><b/><t>С�������͵����</t><b/><t>��Ҫ����Ե�����������˺�</t>"@ %txt @"</t>";



				//===============================================================================================������==================================================================================

				//exec("gameres/Data/Quest/Client/C_Tooltips.cs");


			case "SeeStarWnd_PickBtn"://һ��ʰȡ���
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'  f='����' n='14' >ʰȡ�������</t><b/><t>����ɫ�������ȫ��ʰȡ����걳��</t><b/><t>����ʰȡƷ�ʸߵ����</t></t>";

			case "SeeStarWnd_SellBtn"://һ��������ɫ���
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'  f='����' n='14' >�������л�ɫ���</t><b/><t>���ѻ��õĻ�ɫ���ȫ������</t><b/><t>��ɫ���������Ҫ�����Ҽ���������������</t></t>";

			case "SeeStarWnd_ExchangeBtn"://��ȡ�����Ƭ
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'  f='����' n='14' >��ȡ�����Ƭ</t><b/><t>�����ѻ�����ۼ�ÿ����1000�Σ���������һ�������Ƭ</t><b/><t>�����Ƭ�ɶһ���ɫ����ɫ���</t></t>";

			case "SeeStarWnd_XingXiangSuiPianTxt"://���������Ƭ
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'  f='����' n='14' >���������Ƭ</t><b/><t>�����ѻ�����ۼ�ÿ����1000�Σ���������һ�������Ƭ</t><b/><t>�����Ƭ�ɶһ���ɫ����ɫ���</t></t>";

			case "SeeStarWnd_XingXiangSuiPianValue"://���������Ƭ
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'  f='����' n='14' >���������Ƭ</t><b/><t>�����ѻ�����ۼ�ÿ����1000�Σ���������һ�������Ƭ</t><b/><t>�����Ƭ�ɶһ���ɫ����ɫ���</t></t>";

			case "SeeStarWnd_XingXiangBtn"://������
				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'  f='����' n='14' >�����������</t><b/><t>�ѻ��õ������Ҫ���������ڽ���װ�����ں�</t></t>";

			case "SeeStarWnd_StarBtn0"://��������
				if (SeeStarWnd_StarBtn0.isActive())
					%txt = "</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>(����ѻ�)";

				if (isFile("gameres/gui/images/GUIWindow31_1_031.png")){ %Reward2 = "<i s='gameres/gui/images/GUIWindow31_1_031.png' w='16' h='16'/>"; }
				else{ %Reward2 = "���"; }//���

				if (%Player.GetVipTimer(1) > 0)
					%XiaoHao = "ԭ�����ģ�</t><t f='����' m='0' n='14' c='0x696668ff'>10,000</t>" @ %Reward2 @ "<b/><t>�񽫰�ۣ�5,000</t>" @ %Reward2;
				else
					%XiaoHao = "��Ҫ���ģ�10,000";

				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>��������"@ %txt @"</t><b/><t>" @ %XiaoHao @ "</t></t>";

			case "SeeStarWnd_StarBtn1"://���ε���
				if (SeeStarWnd_StarBtn1.isActive())
				{
					%ctrl.tooltipWidth = 150;
					%txt = "</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>(����ѻ�)";
				}
				else
				{
					%ctrl.tooltipWidth = 190;
					%txt1 = "<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���������м����������ε���</t>";
				}

				if (isFile("gameres/gui/images/GUIWindow31_1_031.png")){ %Reward2 = "<i s='gameres/gui/images/GUIWindow31_1_031.png' w='16' h='16'/>"; }
				else{ %Reward2 = "���"; }//���

				if (%Player.GetVipTimer(1) > 0)
					%XiaoHao = "ԭ�����ģ�</t><t f='����' m='0' n='14' c='0x696668ff'>15,000</t>" @ %Reward2 @ "<b/><t>�񽫰�ۣ�7,500</t>" @ %Reward2;
				else
					%XiaoHao = "��Ҫ���ģ�15,000";

				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>���ε���"@ %txt @"</t><b/><t>" @ %XiaoHao @ %txt1 @"</t></t>";

			case "SeeStarWnd_StarBtn2"://�ŷ�ıʿ
				if (SeeStarWnd_StarBtn2.isActive())
					%txt = "</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>(����ѻ�)";
				else
					%txt1 = "<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���ε����м��������ŷ�ıʿ</t>";

				if (isFile("gameres/gui/images/GUIWindow31_1_031.png")){ %Reward2 = "<i s='gameres/gui/images/GUIWindow31_1_031.png' w='16' h='16'/>"; }
				else{ %Reward2 = "���"; }//���

				if (%Player.GetVipTimer(1) > 0)
					%XiaoHao = "ԭ�����ģ�</t><t f='����' m='0' n='14' c='0x696668ff'>30,000</t>" @ %Reward2 @ "<b/><t>�񽫰�ۣ�15,000</t>" @ %Reward2;
				else
					%XiaoHao = "��Ҫ���ģ�30,000";

				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>�ŷ�ıʿ"@ %txt @"</t><b/><t>" @ %XiaoHao @ "</t>"@ %txt1 @"</t>";

			case "SeeStarWnd_StarBtn3"://ʥ�س���
				if (SeeStarWnd_StarBtn3.isActive())
				{
					%ctrl.tooltipWidth = 160;
					%txt = "</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>(����ѻ�)";
				}
				else
				{
					%ctrl.tooltipWidth = 220;
					%txt1 = "<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�ŷ�ıʿ�м�������ʥ�س��ϻ�ֱ�ӵ�������롿</t>";
				}

				if (isFile("gameres/gui/images/GUIWindow31_1_031.png")){ %Reward2 = "<i s='gameres/gui/images/GUIWindow31_1_031.png' w='16' h='16'/>"; }
				else{ %Reward2 = "���"; }//���

				if (%Player.GetVipTimer(1) > 0)
					%XiaoHao = "ԭ�����ģ�</t><t f='����' m='0' n='14' c='0x696668ff'>60,000</t>" @ %Reward2 @ "<b/><t>�񽫰�ۣ�30,000</t>" @ %Reward2;
				else
					%XiaoHao = "��Ҫ���ģ�60,000";

				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>ʥ�س���"@ %txt @"</t><b/><t>" @ %XiaoHao @ "</t>"@ %txt1 @"</t>";

			case "SeeStarWnd_StarBtn4"://���ʦ
				if (SeeStarWnd_StarBtn4.isActive())
				{
					%ctrl.tooltipWidth = 180;
					%txt = "</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>(����ѻ�)";
				}
				else
				{
					%ctrl.tooltipWidth = 200;
					%txt1 = "<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>ʥ�س����м���������ʦ</t>";
				}

				if (isFile("gameres/gui/images/GUIWindow31_1_031.png")){ %Reward2 = "<i s='gameres/gui/images/GUIWindow31_1_031.png' w='16' h='16'/>"; }
				else{ %Reward2 = "���"; }//���

				if (%Player.GetVipTimer(1) > 0)
					%XiaoHao = "ԭ�����ģ�</t><t f='����' m='0' n='14' c='0x696668ff'>120,000</t>" @ %Reward2 @ "<b/><t>�񽫰�ۣ�60,000</t>" @ %Reward2;
				else
					%XiaoHao = "��Ҫ���ģ�120,000";

				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>���ʦ"@ %txt @"</t><b/><t>" @ %XiaoHao @ "</t>"@ %txt1 @"</t>";

			case "SeeStarWnd_AuguryBtn"://������
				if (isFile("gameres/gui/images/GUIWindow31_1_027.png")){ %Reward1 = "<i s='gameres/gui/images/GUIWindow31_1_027.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }//��Ԫ
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>����ʥ�س���</t><b/><t>����500</t><t>"@ %Reward1 @"</t><t>ֱ�ӻ�Ԫ������ʥ�س���</t><b/><t>��Ȼ���������꾭���</t><t c='0xff5400ff'>����꡿ </t><t>���м��ʻ�ø߼����</t></t>";


			case "SeeStarWnd_StarBtnVIP"://���VIP����
				%ctrl.tooltipWidth = 290;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>VIP����</t><t gct='0xff7171ff' gcb='0xff3c00ff'>���ﵽVIP5ʱ���ţ�</t><b/><t>�������ʾ���VIP���ܲ�������</t><b/><t>1.�Զ�Ԫ���ѻ꣨�Զ�ִ�С����롿���ܣ�</t><b/><t>2.�Զ��ں���ɫ�������</t><b/><t>3.�Զ����ۻ�ɫ���</t></t>";


			case "XingXiangWnd_SeeStarBtn"://ǰ���ѻ�

				%Player = GetPlayer();
				%Family  = %Player.GetFamily();
				if (%family < 3)
				{
					%souhun = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>ǰ���ѻ�</t><b/><t>������Զ�ǰ��������</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ϸ溮</t><t>���ѻ�</t></t>";
				}
				else
				{
					%souhun = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>ǰ���ѻ�</t><b/><t>������Զ�ǰ��������</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>�Ϸ溮</t><t>���ѻ�</t></t>";
				}


				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = %souhun;

			case "XingXiangWnd_CombinationAllBtn"://�ں����
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>�ںϱ������������</t><b/><t>���ͨ���ں���������þ��飬�����󽫴����������������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�ںϷ�ʽ��</t><b/><t>1���϶���긲����������꣨�������֮���ںϣ�</t><b/><t>2��������ںϱ�����������꡿��ť�ں�</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�ںϹ���</t><b/><t>1����Ʒ�ʵ�����ںϵ�Ʒ�ʵ����</t><b/><t>2���ߵȼ�������ںϵ͵ȼ������</t><b/><t>3������ںϺ������ľ�������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>���ֿ��ڵ���꽫���ᱻ�ں�</t></t>";

			case "XingXiangWnd_DecomposeBtn"://�ֽ����
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>�ֽ����</t><b/><t>�ֽ��ɫ����������Ƭ����Ƭ�ɶһ���ɫ����ɫ���</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����л�Ϊ�ֽ�״̬��ָ����걳���ڳ�ɫ��꼴�ɷֽ�</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>�ѻ�״̬���޷��ֽ����</t></t>";

			case "XingXiangWnd_FengBtn1"://���
				%ctrl.tooltipWidth = 130;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>�����������</t></t>";

			case "XingXiangWnd_FengBtn2"://���
				%ctrl.tooltipWidth = 130;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>�����������</t></t>";

			case "XingXiangWnd_FengBtn3"://���
				%ctrl.tooltipWidth = 130;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>�����������</t></t>";

			case "XingXiangWnd_FengBtn4"://���
				%ctrl.tooltipWidth = 130;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>�����������</t></t>";

			case "XingXiangWnd_FengBtn5"://���
				%ctrl.tooltipWidth = 130;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>�����������</t></t>";

			case "XingXiangWnd_FengBtn6"://���
				%ctrl.tooltipWidth = 130;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>�����������</t></t>";

			case "XingXiangWnd_FengBtn7"://���
				%ctrl.tooltipWidth = 130;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>�����������</t></t>";

				/*case "XingXiangWnd_PlayerModelBmp"://���۽�ɫ
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>����</t><b/><t>����ӵ�а˸����ۣ�װ����ɫ������꼴�ɼ���</t><b/><t>װ����8����ɫ����Ʒ����꼴�ɻ������ۻ�ø߶������</t></t>";
				*/
			case "XingXiangWnd_StarBmp0"://����
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>����</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>���Ѽ��</t><b/><t>��Ӧ������װ����ɫ���󼴱�����</t><b/><t>װ����8����ɫ����Ʒ����꼴�ɻ��ѷ����ø߶������</t></t>";

			case "XingXiangWnd_StarBmp1"://����
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>����</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>���Ѽ��</t><b/><t>��Ӧ������װ����ɫ���󼴱�����</t><b/><t>װ����8����ɫ����Ʒ����꼴�ɻ��ѷ����ø߶������</t></t>";

			case "XingXiangWnd_StarBmp2"://����
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>����</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>���Ѽ��</t><b/><t>��Ӧ������װ����ɫ���󼴱�����</t><b/><t>װ����8����ɫ����Ʒ����꼴�ɻ��ѷ����ø߶������</t></t>";

			case "XingXiangWnd_StarBmp3"://����
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>����</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>���Ѽ��</t><b/><t>��Ӧ������װ����ɫ���󼴱�����</t><b/><t>װ����8����ɫ����Ʒ����꼴�ɻ��ѷ����ø߶������</t></t>";

			case "XingXiangWnd_StarBmp4"://����
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>����</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>���Ѽ��</t><b/><t>��Ӧ������װ����ɫ���󼴱�����</t><b/><t>װ����8����ɫ����Ʒ����꼴�ɻ��ѷ����ø߶������</t></t>";

			case "XingXiangWnd_StarBmp5"://����
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>����</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>���Ѽ��</t><b/><t>��Ӧ������װ����ɫ���󼴱�����</t><b/><t>װ����8����ɫ����Ʒ����꼴�ɻ��ѷ����ø߶������</t></t>";

			case "XingXiangWnd_StarBmp6"://����
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>����</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>���Ѽ��</t><b/><t>��Ӧ������װ����ɫ���󼴱�����</t><b/><t>װ����8����ɫ����Ʒ����꼴�ɻ��ѷ����ø߶������</t></t>";

			case "XingXiangWnd_StarBmp7"://����
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>����</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>���Ѽ��</t><b/><t>��Ӧ������װ����ɫ���󼴱�����</t><b/><t>װ����8����ɫ����Ʒ����꼴�ɻ��ѷ����ø߶������</t></t>";

			case "XingXiangWnd_ArouseBtn"://�Ѽ�������

				if (XingXiangWnd_ArouseBtn.GetText()$="������������")
				{
					%ctrl.tooltipWidth = 250;
					%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>δ���ѷ���</t><b/><t>װ����8����ɫ����Ʒ����꼴�ɻ��ѷ���</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ȼ���װ���е���͵ȼ������ȼ�һ��</t></t>";
				}
				else
				{
					%ctrl.tooltipWidth = 250;
					%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>�ѻ��ѷ���</t><b/><t>��װ������겻���㻽�����������󸽼����Խ���ʧ����Ҫ�������������»���</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����ȼ���װ���е���͵ȼ������ȼ�һ��</t></t>";
				}


			case "XingXiangWnd_JingJieBtn0"://����
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>����</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ʹ���У�</t><b/><t>װ����8����ɫ����Ʒ����꼴�ɻ�</t><b/><t>����ȼ���װ���е���͵ȼ������ȼ�һ��</t></t>";


			case "XingXiangWnd_PlayerModelBmp"://��������flash

				%Player = GetPlayer();
				%txt0="<b/><i s='gameres/gui/images/GUIWindow99_1_007.png' w='210' h='9'/><b/><t c='0x00ff00ff'>  ����ȼ�Խ�߼��������Խ��</t>";
				%txt10="<b/><i s='gameres/gui/images/GUIWindow99_1_007.png' w='210' h='9'/><b/><t c='0x1ebe14ff'>��һ�׷���</t>";

				if (%Player==0) return;

				%Family  = %Player.GetFamily();
				%Classes = %Player.GetClasses(0);
				%lidao_or_zhili = %Player.GetClasses(0);
				if (%lidao_or_zhili == 1){ %lidao_or_zhili1 = "����";%gongjishanghai1 = "����";%wuxigongji1 = "��"; }
				else  if (%lidao_or_zhili == 2){ %lidao_or_zhili1 = "����";%gongjishanghai1 = "����";%wuxigongji1 = "��"; }
				else  if (%lidao_or_zhili == 3){ %lidao_or_zhili1 = "����";%gongjishanghai1 = "����";%wuxigongji1 = "��"; }
				else  if (%lidao_or_zhili == 4){ %lidao_or_zhili1 = "����";%gongjishanghai1 = "����";%wuxigongji1 = "��"; }
				else  												{ %lidao_or_zhili1 = "����";%gongjishanghai1 = "����";%wuxigongji1 = "��"; }


				if (%Player.getCurrXingMaiLevel()==1)
				{
					%size ="230";%txt="         һ�׷���";
					%txt1="<b/><t c='0x4383d4ff'><t>���ܵ����˺�-10</t><b/><t>�������+150</t></t>";
					%txt1_1="<b/><t c='0x969399ff'><t>���ܵ����˺�-20</t><b/><t>�������+300</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"����+150</t></t>";
				}
				else if (%Player.getCurrXingMaiLevel()==2)
				{
					%size ="230";%txt="         ���׷���";
					%txt1="<b/><t c='0x4383d4ff'><t>���ܵ����˺�-20</t><b/><t>�������+300</t>";
					%txt2="<b/><t>"@ %gongjishanghai1 @"����+150</t></t>";
					%txt1_1="<b/><t c='0x969399ff'><t>���ܵ����˺�-40</t><b/><t>�������+500</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"����+250</t>";
					%txt3_1="<b/><t>"@%wuxigongji1 @"�鹥��+250</t></t>";
				}
				else if (%Player.getCurrXingMaiLevel()==3)
				{
					%size ="230";%txt="         ���׷���";
					%txt1="<b/><t c='0x4383d4ff'><t>���ܵ����˺�-40</t><b/><t>�������+500</t>";
					%txt2="<b/><t>"@ %gongjishanghai1 @"����+250</t>";
					%txt3="<b/><t>"@%wuxigongji1 @"�鹥��+250</t></t>";
					%txt1_1="<b/><t c='0x464646ff'><t>���ܵ����˺�-60</t><b/><t>�������+700</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"����+400</t>";
					%txt3_1="<b/><t>"@%wuxigongji1 @"�鹥��+400</t>";
					%txt4_1="<b/><t>��������+400</t></t>";
				}
				else if (%Player.getCurrXingMaiLevel()==4)
				{
					%size ="230";%txt="         �Ľ׷���";
					%txt1="<b/><t c='0x4383d4ff'><t>���ܵ����˺�-60</t><b/><t>�������+700</t>";
					%txt2="<b/><t>"@ %gongjishanghai1 @"����+400</t>";
					%txt3="<b/><t>"@%wuxigongji1 @"�鹥��+400</t>";
					%txt4="<b/><t>��������+400</t></t>";
					%txt1_1="<b/><t c='0x969399ff'><t>���ܵ����˺�-80</t><b/><t>�������+1000</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"����+600</t>";
					%txt3_1="<b/><t>"@%wuxigongji1 @"�鹥��+600</t>";
					%txt4_1="<b/><t>��������+600</t>";
					%txt5_1="<b/><t>����ֵ+60</t></t>";
				}
				else if (%Player.getCurrXingMaiLevel()==5)
				{
					%size ="230";%txt="         ��׷���";
					%txt1="<b/><t c='0xb012baff'><t>���ܵ����˺�-80</t><b/><t>�������+1000</t>";
					%txt2="<b/><t>"@ %gongjishanghai1 @"����+600</t>";
					%txt3="<b/><t>"@%wuxigongji1 @"�鹥��+600</t>";
					%txt4="<b/><t>��������+600</t>";
					%txt5="<b/><t>����ֵ+60</t></t>";
					%txt1_1="<b/><t c='0x969399ff'><t>���ܵ����˺�-100</t><b/><t>�������+1500</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"����+1000</t>";
					%txt3_1="<b/><t>"@%wuxigongji1 @"�鹥��+1000</t>";
					%txt4_1="<b/><t>��������+1000</t>";
					%txt5_1="<b/><t>����ֵ+120</t>";
					%txt6_1="<b/><t>����ֵ+120</t></t>";
				}
				else if (%Player.getCurrXingMaiLevel()==6)
				{
					%size ="230";%txt="         ���׷���";
					%txt1="<b/><t c='0xb012baff'><t>���ܵ����˺�-100</t><b/><t>�������+1500</t>";
					%txt2="<b/><t>"@ %gongjishanghai1 @"����+1000</t>";
					%txt3="<b/><t>"@%wuxigongji1 @"�鹥��+1000</t>";
					%txt4="<b/><t>��������+1000</t>";
					%txt5="<b/><t>����ֵ+120</t>";
					%txt6="<b/><t>����ֵ+120</t></t>";
					%txt1_1="<b/><t c='0x969399ff'><t>���ܵ����˺�-120</t><b/><t>�������+3500</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"����+2000</t>";
					%txt3_1="<b/><t>"@%wuxigongji1 @"�鹥��+2000</t>";
					%txt4_1="<b/><t>��������+2000</t>";%txt5="<b/><t>����ֵ+250</t>";
					%txt6_1="<b/><t>����ֵ+250</t>";
					%txt7_1="<b/><t>����������+10%</t></t>";
				}
				else if (%Player.getCurrXingMaiLevel()==7)
				{
					%size ="230";%txt="         �߽׷���";
					%txt1="<b/><t c='0xb012baff'><t>���ܵ����˺�-120</t><b/><t>�������+3500</t>";
					%txt2="<b/><t>"@ %gongjishanghai1 @"����+2000</t>";
					%txt3="<b/><t>"@%wuxigongji1 @"�鹥��+2000</t>";
					%txt4="<b/><t>��������+2000</t>";%txt5="<b/><t>����ֵ+250</t>";
					%txt6="<b/><t>����ֵ+250</t>";
					%txt7="<b/><t>����������+10%</t></t>";
					%txt1_1="<b/><t c='0x969399ff'><t>���ܵ����˺�-140</t><b/><t>�������+7500</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"����+4500</t>";
					%txt3_1="<b/><t>"@%wuxigongji1 @"�鹥��+4500</t>";
					%txt4_1="<b/><t>��������+4500</t>";
					%txt5_1="<b/><t>����ֵ+450</t>";
					%txt6_1="<b/><t>����ֵ+450</t>";
					%txt7_1="<b/><t>����������+20%</t>";
					%txt8_1="<b/><t>��������+20%</t></t>";
				}
				else if (%Player.getCurrXingMaiLevel()==8)
				{
					%size ="230";%txt="         �˽׷���";
					%txt1="<b/><t c='0xb012baff'><t>���ܵ����˺�-140</t><b/><t>�������+7500</t>";
					%txt2="<b/><t>"@ %gongjishanghai1 @"����+4500</t>";
					%txt3="<b/><t>"@%wuxigongji1 @"�鹥��+4500</t>";
					%txt4="<b/><t>��������+4500</t>";
					%txt5="<b/><t>����ֵ+450</t>";
					%txt6="<b/><t>����ֵ+450</t>";
					%txt7="<b/><t>����������+20%</t>";
					%txt8="<b/><t>��������+20%</t></t>";
					%txt1_1="<b/><t c='0x969399ff'><t>���ܵ����˺�-160</t><b/><t>�������+11250</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"����+7500</t>";
					%txt3_1="<b/><t>"@%wuxigongji1 @"�鹥��+7500</t>";
					%txt4_1="<b/><t>��������+7500</t>";
					%txt5_1="<b/><t>����ֵ+900</t>";
					%txt6_1="<b/><t>����ֵ+900</t>";
					%txt7_1="<b/><t>����������+30%</t>";
					%txt8_1="<b/><t>��������+30%</t></t>";
				}
				else if (%Player.getCurrXingMaiLevel()==9)
				{
					%size ="230";%txt="         �Ž׷���";
					%txt1="<b/><t c='0xf26504ff'><t>���ܵ����˺�-160</t><b/><t>�������+11250</t>";
					%txt2="<b/><t>"@ %gongjishanghai1 @"����+7500</t>";
					%txt3="<b/><t>"@%wuxigongji1 @"�鹥��+7500</t>";
					%txt4="<b/><t>��������+7500</t>";
					%txt5="<b/><t>����ֵ+900</t>";
					%txt6="<b/><t>����ֵ+900</t>";
					%txt7="<b/><t>����������+30%</t>";
					%txt8="<b/><t>��������+30%</t></t>";
					%txt1_1="<b/><t c='0x969399ff'><t>���ܵ����˺�-180</t><b/><t>�������+14880</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"����+12000</t>";
					%txt3_1="<b/><t>"@%wuxigongji1 @"�鹥��+12000</t>";
					%txt4_1="<b/><t>��������+12000</t>";
					%txt5_1="<b/><t>����ֵ+1900</t>";
					%txt6_1="<b/><t>����ֵ+1900</t>";
					%txt7_1="<b/><t>����������+40%</t>";
					%txt8_1="<b/><t>��������+40%</t></t>";
				}
				else if (%Player.getCurrXingMaiLevel()==10)
				{
					%size ="230";%txt="         ʮ�׷���";
					%txt1="<b/><t c='0xf26504ff'><t>���ܵ����˺�-180</t><b/><t>�������+14880</t>";
					%txt2="<b/><t>"@ %gongjishanghai1 @"����+12000</t>";
					%txt3="<b/><t>"@%wuxigongji1 @"�鹥��+12000</t>";
					%txt4="<b/><t>��������+12000</t>";
					%txt5="<b/><t>����ֵ+1900</t>";
					%txt6="<b/><t>����ֵ+1900</t>";
					%txt7="<b/><t>����������+40%</t>";
					%txt8="<b/><t>��������+40%</t></t>";
					%txt10="";
				}
				else
				{
					%size ="230";%txt="<t>         һ�׷���</t><t c='0x969399ff' n='14'>��δ����)</t>";
					%txt1="<b/><t><t c='0x969399ff'><t>���ܵ����˺�-10</t><b/><t>�������+150</t></t>";
					%txt1_1="<b/><t c='0x969399ff'><t>���ܵ����˺�-20</t><b/><t>�������+300</t>";
					%txt2_1="<b/><t>"@ %gongjishanghai1 @"����+150</t></t>";
				}

				%ctrl.tooltipWidth = %size;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t f='����' n='16'>"@ %txt @"</t><b/><t c='0xE1AA16ff'>�������ԣ�</t>"@ %txt1 @""@ %txt2 @""@ %txt3 @""@ %txt4 @""@ %txt5 @""@ %txt6 @""@ %txt7 @""@ %txt8 @""@ %txt9 @""@ %txt10 @""@ %txt1_1 @""@ %txt2_1 @""@ %txt3_1 @""@ %txt4_1 @""@ %txt5_1 @""@ %txt6_1 @""@ %txt7_1 @""@ %txt8_1 @""@ %txt9_1 @""@ %txt0 @"</t>";


			case "XingXiangWnd_LevelName"://���۵ȼ�

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>��ǰ���ѷ���ĵȼ�</t><b/><t>���۵ȼ���װ���ڽ�ɫ���ϵ���ɫ��������еȼ���͵�������</t><b/><t>������ﵽ�˽����ϾͿɶ����ö��9��ս�����Լӳ�</t></t>";

			case "XingXiangWnd_XingLiValueBmp"://������-����ֵ
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>���Ʒ����ֵ </t><t>"@ GetPlayer().getCurrStarPowerSum() @"</t><b/><t>��ʾ����װ�������Ʒ�ʡ����ȼ����ۺ�ֵ</t></t>";

			case "DTPlayerInfowGui_WuHunText"://��ɫ����-����ֵ
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>���Ʒ����ֵ </t><t>"@ GetPlayer().getCurrStarPowerSum() @"</t><b/><t>��ʾ����װ�������Ʒ�ʡ����ȼ����ۺ�ֵ</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��������ɴ򿪽�ɫ������</t></t>";

			case "TargetInfo_XingLiValueBmp"://�鿴���˽�ɫ����-����ֵ

				$XingMaiInfo[-1]="<t gct='0xff7171ff' gcb='0xff3c00ff'>����δ����</t>";
				$XingMaiInfo[1]="<t gct='0x00ff00ff' gcb='0x2cffeeff'>һ�׷���</t>";
				$XingMaiInfo[2]="<t gct='0x00ff00ff' gcb='0x2cffeeff'>���׷���</t>";
				$XingMaiInfo[3]="<t gct='0x00ff00ff' gcb='0x2cffeeff'>���׷���</t>";
				$XingMaiInfo[4]="<t gct='0x4383d4ff' gcb='0x4383d4ff'>�Ľ׷���</t>";
				$XingMaiInfo[5]="<t gct='0x4383d4ff' gcb='0x4383d4ff'>��׷���</t>";
				$XingMaiInfo[6]="<t gct='0x4383d4ff' gcb='0x4383d4ff'>���׷���</t>";
				$XingMaiInfo[7]="<t gct='0xa811b1ff' gcb='0xb012baff'>�߽׷���</t>";
				$XingMaiInfo[8]="<t gct='0xa811b1ff' gcb='0xb012baff'>�˽׷���</t>";
				$XingMaiInfo[9]="<t gct='0xa811b1ff' gcb='0xb012baff'>�Ž׷���</t>";
				$XingMaiInfo[10]="<t gct='0xa811b1ff' gcb='0xb012baff'>ʮ�׷���</t>";

				%XingMai = GetTargetXingMaiLevel();
				%XingMaiLevel = $XingMaiInfo[%XingMai];

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>���Ʒ����ֵ</t> <b/><t>��ʾ����װ�������Ʒ�ʡ����ȼ����ۺ�ֵ</t><b/><t>��ǰ���۵ȼ���</t>"@ %XingMaiLevel @"<t><b/>"@ GetTargetXingMaiInfo() @"</t></t>";

			case "XingXiangWnd_UploadBtn"://�ϴ����Ʒ��
				%ctrl.tooltipWidth = 150;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>�ϴ����Ʒ��</t><b/><t>��������Ʒ�ʽ��ϴ������а���</t></t>";

			case "XingXiangWnd_BaoDai_ActiveBtn0"://��걦��
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>��걦��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'f='����' n='14'>���ɼ��</t><b/><t>ÿ��Ϊ��걦�����ܣ�����ѻ��ϡ�г�ɫ���</t></t>";

			case "XingXiangWnd_BaoDai_ActiveBtn"://��걦��
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>��걦�����ɳ��ܣ�</t><b/><t>ÿ��Ϊ��걦�����ܣ�����ѻ��ϡ�г�ɫ���</t></t>";

			case "SeeStarWnd_AutoSeeStarBtn"://�Զ��ѻ�

				if (GetPlayer().GetLevel() < 60)
				{
					%ctrl.tooltipWidth = 200;
					%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>�Զ��ѻ�</t><b/><t>��Ҫ��ɫ�ȼ��ﵽ6�޲���ʹ�ã����ͣ���</t></t>";
				}
				else
				{
					%ctrl.tooltipWidth = 250;
					%ctrl.tooltip = "<t m='1' f='����' n='12' ><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>�Զ��ѻ�</t><b/><t>��������Զ��ѻ꣬�������ɻ�ø������</t><b/><t>ֹͣ����</t><b/><t>1���ٴε���Զ��ѻ갴ť</t><b/><t>2������ȫ��ӵ�����</t><b/><t>3��������߼���Ĵ��ʦ</t><b/><t>4����Ҳ���</t></t>";
				}

			case "SeeStarWnd_SeeStarNum"://�ۼ��ѻ����
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>�ۼ��ѻ����</t><b/><t>�ۼ��ѻ����ÿ�ﵽ1000�Σ����ɻ��һ�������Ƭ�Ķ��⽱��</t><b/><t>�����Ƭ�����ڶһ���ɫ����ɫ���</t></t>";


			case "XingXiangWnd_InventoryTipBmp"://���ֿ�
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>���ֿ�</t><b/><t>���ֿ��ڵ���겻�ᱻ�ںϣ��ɽ�����������ֿ���</t></t>";

			case "XingXiangWnd_InfoBtn"://���������һ�
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>���������һ�</t><b/><t>�ɲ鿴��������ʼ�����յĸ�������</t><b/><t>��ɫ����ɫ�����������Ƭ�һ����</t></t>";

			case "XingXiangWnd_XingXiangSuiPianBmp"://�����Ƭ
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>�����Ƭ</t><b/><t>��������������һ����ɶһ���ɫ����ɫƷ�����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�����Ƭ���;����</t><b/><t>1���ѻ�ɻ�������Ƭ</t><b/><t>2���ֽ��ɫ���ɻ�������Ƭ</t><b/><t>3���ۼ��ѻ����ÿ1000�ζ�������һ�������Ƭ</t></t>";

			case "XingXiangWnd_XingXiangSuiPianValue"://�����Ƭ
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>ӵ�е������Ƭ����</t><b/><t>��������������һ����ɶһ���ɫ����ɫƷ�����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�����Ƭ���;����</t><b/><t>1���ѻ�ɻ�������Ƭ</t><b/><t>2���ֽ��ɫ���ɻ�������Ƭ</t><b/><t>3���ۼ��ѻ����ÿ1000�ζ�������һ�������Ƭ</t></t>";

			case "XingXiangInfoWnd_XingXiangSuiPianBmp"://�����Ƭ
				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'f='����' n='14'>�����Ƭ</t><b/><t>�����ڶһ���ɫ����ɫƷ�����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�����Ƭ���;����</t><b/><t>1���ѻ�ɻ�������Ƭ</t><b/><t>2���ֽ��ɫ���ɻ�������Ƭ</t><b/><t>3���ۼ��ѻ����ÿ1000�ζ�������һ�������Ƭ</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_0"://�һ����0
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xff9600ff' f='����' n='14'>[���]</t><b/><t>��ɫ�ﵽ6�޼�������10�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_1"://�һ����1
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xff9600ff' f='����' n='14'>[�桤��������]</t><b/><t>��ɫ�ﵽ6�޼�������20�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_2"://�һ����2
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xff9600ff' f='����' n='14'>[�桤ʮ��һɱ]</t><b/><t>��ɫ�ﵽ6�޼�������20�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_3"://�һ����3
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xff9600ff' f='����' n='14'>[�桤������ˮ]</t><b/><t>��ɫ�ﵽ6�޼�������20�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_4"://�һ����4
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xff9600ff' f='����' n='14'>[�桤����ҽ�]</t><b/><t>��ɫ�ﵽ6�޼�������20�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_5"://�һ����5
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xff9600ff' f='����' n='14'>[�桤��ղ���]</t><b/><t>��ɫ�ﵽ6�޼�������20�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_6"://�һ����6
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xff9600ff' f='����' n='14'>[�桤����һ��]</t><b/><t>��ɫ�ﵽ6�޼�������20�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_7"://�һ����7
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xff9600ff' f='����' n='14'>[�桤���ֻش�]</t><b/><t>��ɫ�ﵽ6�޼�������20�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_8"://�һ����8
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xff9600ff' f='����' n='14'>[�桤���ͬ��]</t><b/><t>��ɫ�ﵽ6�޼�������20�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_9"://�һ����9
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xff9600ff' f='����' n='14'>[�桤�����һ]</t><b/><t>��ɫ�ﵽ6�޼�������20�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_10"://�һ����10
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xff9600ff' f='����' n='14'>[�桤��������]</t><b/><t>��ɫ�ﵽ6�޼�������20�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_11"://�һ����11
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xff9600ff' f='����' n='14'>[�桤�鶯����]</t><b/><t>��ɫ�ﵽ6�޼�������20�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_12"://�һ����12
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xff9600ff' f='����' n='14'>[�桤������Ԫ]</t><b/><t>��ɫ�ﵽ6�޼�������20�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_13"://�һ����13
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xff9600ff' f='����' n='14'>[�桤����ɽ��]</t><b/><t>��ɫ�ﵽ6�޼�������20�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_14"://�һ����14
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xca57ffff' f='����' n='14'>[������Ϣ]</t><b/><t>��ɫ�ﵽ3�޼�������5�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_15"://�һ����15
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xca57ffff' f='����' n='14'>[�����۶�]</t><b/><t>��ɫ�ﵽ3�޼�������5�������Ƭ�һ�</t></t>";

				//case "XingXiangInfoWnd_ControlArea_ExchangeBtn_15"://�һ����16
				//			%ctrl.tooltipWidth = 210;
				//			%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xca57ffff' f='����' n='14'>[Ц��ص�]</t><b/><t>��ɫ�ﵽ3�޼�������5�������Ƭ�һ�</t></t>";

				//case "XingXiangInfoWnd_ControlArea_ExchangeBtn_16"://�һ����17
				//			%ctrl.tooltipWidth = 210;
				//			%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xca57ffff' f='����' n='14'>[��������]</t><b/><t>��ɫ�ﵽ3�޼�������5�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_16"://�һ����18
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xca57ffff' f='����' n='14'>[����ѿ�]</t><b/><t>��ɫ�ﵽ3�޼�������5�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_17"://�һ����19
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xca57ffff' f='����' n='14'>[��ղ���]</t><b/><t>��ɫ�ﵽ3�޼�������5�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_18"://�һ����20
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xca57ffff' f='����' n='14'>[����һ��]</t><b/><t>��ɫ�ﵽ3�޼�������5�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_19"://�һ����21
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xca57ffff' f='����' n='14'>[���ֻش�]</t><b/><t>��ɫ�ﵽ3�޼�������5�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_20"://�һ����22
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xca57ffff' f='����' n='14'>[��������]</t><b/><t>��ɫ�ﵽ3�޼�������5�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_21"://�һ����23
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xca57ffff' f='����' n='14'>[���ͬ��]</t><b/><t>��ɫ�ﵽ3�޼�������5�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_22"://�һ����24
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xca57ffff' f='����' n='14'>[�����һ]</t><b/><t>��ɫ�ﵽ3�޼�������5�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_23"://�һ����25
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xca57ffff' f='����' n='14'>[��������]</t><b/><t>��ɫ�ﵽ3�޼�������5�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_24"://�һ����26
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xca57ffff' f='����' n='14'>[�鶯����]</t><b/><t>��ɫ�ﵽ3�޼�������5�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_25"://�һ����27
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xca57ffff' f='����' n='14'>[������Ԫ]</t><b/><t>��ɫ�ﵽ3�޼�������5�������Ƭ�һ�</t></t>";

			case "XingXiangInfoWnd_ControlArea_ExchangeBtn_26"://�һ����28
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t c='0xca57ffff' f='����' n='14'>[����ɽ��]</t><b/><t>��ɫ�ﵽ3�޼�������5�������Ƭ�һ�</t></t>";



				//====================================================================================�����Լ۱�ͼ��˵��====================================================================================================

			case "UpLinePartyWnd_Wnd_Tip"://�����Լ۱�ͼ��˵��
				if (isFile("gameres/gui/images/GUIWindow41_1_020.png")){ %Reward1 = "<i s='gameres/gui/images/GUIWindow41_1_020.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }//���ﾭ��
				if (isFile("gameres/gui/images/GUIWindow41_1_021.png")){ %Reward2 = "<i s='gameres/gui/images/GUIWindow41_1_021.png' w='16' h='16'/>"; }
				else{ %Reward2 = ""; }//������
				if (isFile("gameres/gui/images/GUIWindow41_1_022.png")){ %Reward3 = "<i s='gameres/gui/images/GUIWindow41_1_022.png' w='16' h='16'/>"; }
				else{ %Reward3 = ""; }//���޾���
				if (isFile("gameres/gui/images/GUIWindow41_1_023.png")){ %Reward4 = "<i s='gameres/gui/images/GUIWindow41_1_023.png' w='16' h='16'/>"; }
				else{ %Reward4 = ""; }//��Ǯ
				if (isFile("gameres/gui/images/GUIWindow41_1_024.png")){ %Reward5 = "<i s='gameres/gui/images/GUIWindow41_1_024.png' w='16' h='16'/>"; }
				else{ %Reward5 = ""; }//װ��
				if (isFile("gameres/gui/images/GUIWindow41_1_025.png")){ %Reward6 = "<i s='gameres/gui/images/GUIWindow41_1_025.png' w='16' h='16'/>"; }
				else{ %Reward6 = ""; }//�Ѻö�

				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����Լ۱�˵��</t><b/><t>"@ %Reward1@"</t><t>����ʾ��������ﾭ��</t><b/><t>"@ %Reward2@"</t><t>����ʾ�����������</t><b/><t>"@ %Reward3@"</t><t>����ʾ��������޾���</t><b/><t>"@ %Reward4@"</t><t>����ʾ�������Ǯ</t><b/><t>"@ %Reward5@"</t><t>����ʾ�����װ������</t><b/><t>"@ %Reward6@"</t><t>����ʾ������Ѻö�</t></t>";

			case "EveryweekBnt1"://�����Լ۱�ͼ��˵��
				if (isFile("gameres/gui/images/GUIWindow41_1_020.png")){ %Reward1 = "<i s='gameres/gui/images/GUIWindow41_1_020.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }//���ﾭ��
				if (isFile("gameres/gui/images/GUIWindow41_1_021.png")){ %Reward2 = "<i s='gameres/gui/images/GUIWindow41_1_021.png' w='16' h='16'/>"; }
				else{ %Reward2 = ""; }//������
				if (isFile("gameres/gui/images/GUIWindow41_1_022.png")){ %Reward3 = "<i s='gameres/gui/images/GUIWindow41_1_022.png' w='16' h='16'/>"; }
				else{ %Reward3 = ""; }//���޾���
				if (isFile("gameres/gui/images/GUIWindow41_1_023.png")){ %Reward4 = "<i s='gameres/gui/images/GUIWindow41_1_023.png' w='16' h='16'/>"; }
				else{ %Reward4 = ""; }//��Ǯ
				if (isFile("gameres/gui/images/GUIWindow41_1_024.png")){ %Reward5 = "<i s='gameres/gui/images/GUIWindow41_1_024.png' w='16' h='16'/>"; }
				else{ %Reward5 = ""; }//װ��
				if (isFile("gameres/gui/images/GUIWindow41_1_025.png")){ %Reward6 = "<i s='gameres/gui/images/GUIWindow41_1_025.png' w='16' h='16'/>"; }
				else{ %Reward6 = ""; }//�Ѻö�

				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����Լ۱�˵��</t><b/><t>"@ %Reward1@"</t><t>����ʾ��������ﾭ��</t><b/><t>"@ %Reward2@"</t><t>����ʾ�����������</t><b/><t>"@ %Reward3@"</t><t>����ʾ��������޾���</t><b/><t>"@ %Reward4@"</t><t>����ʾ�������Ǯ</t><b/><t>"@ %Reward5@"</t><t>����ʾ�����װ������</t><b/><t>"@ %Reward6@"</t><t>����ʾ������Ѻö�</t></t>";

			case "DayBnt1"://�����Լ۱�ͼ��˵��
				if (isFile("gameres/gui/images/GUIWindow41_1_020.png")){ %Reward1 = "<i s='gameres/gui/images/GUIWindow41_1_020.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }//���ﾭ��
				if (isFile("gameres/gui/images/GUIWindow41_1_021.png")){ %Reward2 = "<i s='gameres/gui/images/GUIWindow41_1_021.png' w='16' h='16'/>"; }
				else{ %Reward2 = ""; }//������
				if (isFile("gameres/gui/images/GUIWindow41_1_022.png")){ %Reward3 = "<i s='gameres/gui/images/GUIWindow41_1_022.png' w='16' h='16'/>"; }
				else{ %Reward3 = ""; }//���޾���
				if (isFile("gameres/gui/images/GUIWindow41_1_023.png")){ %Reward4 = "<i s='gameres/gui/images/GUIWindow41_1_023.png' w='16' h='16'/>"; }
				else{ %Reward4 = ""; }//��Ǯ
				if (isFile("gameres/gui/images/GUIWindow41_1_024.png")){ %Reward5 = "<i s='gameres/gui/images/GUIWindow41_1_024.png' w='16' h='16'/>"; }
				else{ %Reward5 = ""; }//װ��
				if (isFile("gameres/gui/images/GUIWindow41_1_025.png")){ %Reward6 = "<i s='gameres/gui/images/GUIWindow41_1_025.png' w='16' h='16'/>"; }
				else{ %Reward6 = ""; }//�Ѻö�

				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����Լ۱�˵��</t><b/><t>"@ %Reward1@"</t><t>����ʾ��������ﾭ��</t><b/><t>"@ %Reward2@"</t><t>����ʾ�����������</t><b/><t>"@ %Reward3@"</t><t>����ʾ��������޾���</t><b/><t>"@ %Reward4@"</t><t>����ʾ�������Ǯ</t><b/><t>"@ %Reward5@"</t><t>����ʾ�����װ������</t><b/><t>"@ %Reward6@"</t><t>����ʾ������Ѻö�</t></t>";

			case "Everydaybnt1"://�����Լ۱�ͼ��˵��
				if (isFile("gameres/gui/images/GUIWindow41_1_020.png")){ %Reward1 = "<i s='gameres/gui/images/GUIWindow41_1_020.png' w='16' h='16'/>"; }
				else{ %Reward1 = ""; }//���ﾭ��
				if (isFile("gameres/gui/images/GUIWindow41_1_021.png")){ %Reward2 = "<i s='gameres/gui/images/GUIWindow41_1_021.png' w='16' h='16'/>"; }
				else{ %Reward2 = ""; }//������
				if (isFile("gameres/gui/images/GUIWindow41_1_022.png")){ %Reward3 = "<i s='gameres/gui/images/GUIWindow41_1_022.png' w='16' h='16'/>"; }
				else{ %Reward3 = ""; }//���޾���
				if (isFile("gameres/gui/images/GUIWindow41_1_023.png")){ %Reward4 = "<i s='gameres/gui/images/GUIWindow41_1_023.png' w='16' h='16'/>"; }
				else{ %Reward4 = ""; }//��Ǯ
				if (isFile("gameres/gui/images/GUIWindow41_1_024.png")){ %Reward5 = "<i s='gameres/gui/images/GUIWindow41_1_024.png' w='16' h='16'/>"; }
				else{ %Reward5 = ""; }//װ��
				if (isFile("gameres/gui/images/GUIWindow41_1_025.png")){ %Reward6 = "<i s='gameres/gui/images/GUIWindow41_1_025.png' w='16' h='16'/>"; }
				else{ %Reward6 = ""; }//�Ѻö�

				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�����Լ۱�˵��</t><b/><t>"@ %Reward1@"</t><t>����ʾ��������ﾭ��</t><b/><t>"@ %Reward2@"</t><t>����ʾ�����������</t><b/><t>"@ %Reward3@"</t><t>����ʾ��������޾���</t><b/><t>"@ %Reward4@"</t><t>����ʾ�������Ǯ</t><b/><t>"@ %Reward5@"</t><t>����ʾ�����װ������</t><b/><t>"@ %Reward6@"</t><t>����ʾ������Ѻö�</t></t>";

			case "UnhandleTradebitmap"://��ί�е�
				%ctrl.tooltipWidth = 180;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ǰ����Ԫ�����׵�ί��δ����</t></t></t>";

			case "FBRewardWnd_ActivePrideFB"://��ȡ�౦���
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ȡ�౦���</t><b/><t>��ȡ�౦��Ժ󣬻��ܸ�������ɻ�ø߶��ͱ���</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>�౦���״ֻ̬�н��븱���������ȡ</t></t>";

			case "ProduceRock_RichBit"://����¯
				if ($LivingCurrentSelectSeries == 1)
				{
					%Rich = "������Ҫ������¯����";
				}
				else if ($LivingCurrentSelectSeries == 5)
				{
					%Rich = "������Ҫ������¯����";
				}
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>"@ %Rich @""@ %Rich2 @"</t></t>";

			case "ProduceRock_RichBnt"://ǰ������¯
				if ($LivingCurrentSelectSeries == 1){ %Rich = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ҫ������¯����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����˴����Զ�Ѱ��������������¯</t>"; }
				else if ($LivingCurrentSelectSeries == 5){ %Rich = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������Ҫ������¯����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>����˴����Զ�Ѱ��������������¯</t>"; }
				%ctrl.tooltipWidth = 160;
				%ctrl.tooltip = "<t m='1' f='����' n='12'>"@ %Rich @"</t>";


			case "League_AreaInfoWnd_AttackerInfo"://Ѫ�˹�������˵��

				%ctrl.tooltipWidth = 340;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t><b/><t>ӵ����صİ���/����ÿ��һ���ɻ�����˰��</t><b/><t>����/�������˰�գ�100���ҡ�1���Ծ����</t><b/><t>���µ������˰�գ�200���ҡ�2���Ծ����</t><b/><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���빥�����</t><b/><t>����/��������ս��������</t><b/><t>1���ﵽ3�����ɲ�����2000�����ʽ�</t><b/><t>2���������������50����</t><b/><b/><t>���µ�������ս��������</t><b/><t>1���ﵽ2��Ѫ�˲��ѻ�ó������������</t><b/><t>2��Ѫ���������������50����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>������ֹʱ�����׽���ǰ�İ���/Ѫ�˿ɻ�ù���Ȩ��</t><b/><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����սʤ������</t><b/><t>����ʤ����������������������켴�ɻ��ʤ��</t><b/><t>�ط�ʤ��������������������������ֱ����սʱ�����</t></t>";

			case "Family_AreaInfoWnd_AttackerInfo"://���ɹ�������˵��

				%ctrl.tooltipWidth = 340;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t><b/><t>ӵ����صİ���/����ÿ��һ���ɻ�����˰��</t><b/><t>����/�������˰�գ�100���ҡ�1���Ծ����</t><b/><t>���µ������˰�գ�200���ҡ�2���Ծ����</t><b/><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���빥�����</t><b/><t>����/��������ս��������</t><b/><t>1���ﵽ3�����ɲ�����2000�����ʽ�</t><b/><t>2���������������50����</t><b/><b/><t>���µ�������ս��������</t><b/><t>1���ﵽ2��Ѫ�˲��ѻ�ó������������</t><b/><t>2��Ѫ���������������50����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>������ֹʱ�����׽���ǰ�İ���/Ѫ�˿ɻ�ù���Ȩ��</t><b/><b/><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����սʤ������</t><b/><t>����ʤ����������������������켴�ɻ��ʤ��</t><b/><t>�ط�ʤ��������������������������ֱ����սʱ�����</t></t>";

				//=====================================================================������==========================================
			case "ShenQiGeWndGui11_1"://��ԯ����ť
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ǿ��</t><b/><t>�������ͨ����ʯ�����׵ȷ�ʽ������װ����Ʒ��</t></t>";

			case "ShenQiGeWndGui11_2"://��������ť
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>�������ͨ��ϴ����ѧϰ���ܵȷ�ʽ���������޵�����</t></t>";

			case "ShenQiGeWndGui11_4"://�����ٰ�ť
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ʱװ</t><b/><t>�������ͨ����Ƕ���ϳɵȷ�ʽ������ʱװ�Ŀ�������</t></t>";

			case "ShenQiGeWndGui11_3"://���ӡ��ť
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����</t><b/><t>�������ͨ�����ơ������ȷ�ʽ���������޵�����</t></t>";

			case "ShenQiGeWndGui11_5"://Ů�ʯ��ť
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>Ů�ʯ</t><b/><t c='0x00ff00ff'>������δ���ţ������ڴ�</t></t>";

				//===============================================================================ý�����================================================

			case"DTReceiveGift_ReceiveGiftBtn"://ý�����
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ȡ���</t><b/><t>�������кź������ɻ��ý�����</t><b/><t c='0x00ff00ff'>���ý�������ȡ�����ע����</t></t>";

				//===============================================================================������================================================

			case"JingJiChangWndGUI_reward"://��ȡ����
				%ctrl.tooltipWidth = 250;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ȡ����</t><b/><t>ÿ�ܶ�������ȡ���ܵľ���������������ֻ����ȡһ��</t><b/><t c='0x00ff00ff'>���������ۼƣ��뼰ʱ��ȡ</t></t>";

			case"JingJiChangWndGUI_AddBtn"://����
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���Ӷ�����ս����</t><b/><t>����100Ԫ��������һ�ζ�����ս����</t><b/><t c='0x00ff00ff'>������ʹ�������ս����</t></t>";


				//===============================================================================��ӭ�������ؾ�����================================================

			case "UpLinePartyTeQuan"://VIP��Ȩ
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ȩ����</t><b/><t>��Ϊ����VIP��Ա��ÿ�춼������Ȩ</t></t>";

			case "UpLinePartyMianFei1"://�����ȡ����
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ȡ����</t><b/><t>ÿ������ĸ�����Ŀ�����񼴿���ȡÿ�չ��ʺͻ�Ծ����</t></t>";

			case "UpLinePartyMianFei2"://�����ȡ�����
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ȡ��Ծ����</t><b/><t>ÿ������ĸ�����Ŀ�����񼴿���ȡÿ�չ��ʺͻ�Ծ����</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ծ���ֿ��������̵��ڹ��������Ʒ</t></t>";

			case "UpLinePartyMianFei3"://�����ȡ���߾���
				%ctrl.tooltipWidth = 220;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ȡ���߾���</t><b/><t>ÿ������ֻ����ȡ1�Σ�ÿ����ȡ�ľ�����಻������ǰ��ɫ���������50%</t></t>";

			case "UpLinePartyMianFei4"://ǰ����ȡ
				%ctrl.tooltipWidth = 200;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ȡ˫��ʱ��</t><b/><t>����Զ�Ѱ�����������Ǵ���ȡ˫��ʱ��</t></t>";


				//===============================================================================����תתת=========================================================================


			case "RandomAwardGuiStart"://����תתת
				%ctrl.tooltipWidth = 240;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ʼ��ǩ</t><b/><t>ÿ�ν�ǩ����һö����ǩ��ʱ����ת���������������</t><b/><t>(����ǩ����ʱ����300Ԫ������)</t><b/><t c='0x00ff00ff'>ÿ��ǩһ�Σ���Ե������60Ԫ��</t>";
			case "KLJLuckDrawStartFive"://������
                %ctrl.tooltipWidth = 200;
                %ctrl.tooltip ="<t c='0xffffffff'>������ǩ����5ö����ǩ</t><b/><t c='0xffffffff'>(����ǩ����ʱ����1500Ԫ������)</t><b/><t c='0x00ff00ff'>ÿ������ǩ����Ե������300Ԫ��</t>";
            case "KLJLuckDrawStartTen"://ʮ����
                %ctrl.tooltipWidth = 240;
                %ctrl.tooltip ="<t c='0xffffffff'>ʮ����ǩ����10ö����ǩ</t><b/><t c='0xffffffff'>ÿ�β���ʮ����ǩ��33%�ĸ��ʶ�����һ�ű�ʯ</t><b/><t c='0xffffffff'>(����ǩ����ʱ����3000Ԫ������)</t><b/><t c='0x00ff00ff'>ÿʮ����ǩ����Ե������600Ԫ��</t>";
            
            case "RandomAwardGuiLingQu"://��ȡ����
				%ctrl.tooltipWidth = 210;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ȡ����</t><b/><t>���������ȡ�����еĽ���</t><b/><t c='0x00ff00ff'>Ҳ����ʹ���س鹦�����³�ȡ</t></t>";

			case "RandomAwardGuiChongChou"://�س�
				%ctrl.tooltipWidth = 225;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�س�</t><b/><t>ÿ���س齫����50 </t><i s='gameres/gui/images/GUIWindow31_1_027.png' w='16' h='18'/><b/><t c='0x00ff00ff'>���ų���ǰ���еĽ�Ʒ������ཱ�����⣩�����ٴγ齱</t></t>";

			 
            //===============================================================================��Ը����=========================================================================


			case "KLJPrayGoodManners_QTBtn"://��ͭ��
                %ctrl.tooltipWidth = 150;
                %ctrl.tooltip ="<t c='0x00ff00ff'>����1��ȯ(������500Ԫ��������ȯ)</t>";
                    
			case "KLJPrayGoodManners_BYBtn"://������
                %ctrl.tooltipWidth = 150;
                %ctrl.tooltip ="<t c='0x00ff00ff'>����9��ȯ(������4500Ԫ��������ȯ)</t>";

            case "KLJPrayGoodManners_HJBtn"://�ƽ���
                %ctrl.tooltipWidth = 150;
                %ctrl.tooltip ="<t c='0x00ff00ff'>����20��ȯ(������10000Ԫ��������ȯ)</t>";



            //===============================================================================������ֵ�ͺ���=========================================================================
			 case "KLJDeluxeBagWndBigPrizeShow"://���غ��ܴ����
				 %ctrl.tooltipWidth = 210;
				 %ctrl.tooltip =
					 "<t c='0x00ff00ff' f='����' n='16'>     ���غ��ܴ����</t><b/><b/><t c='0xf1b700ff' f='����' n='12'>�����ۼƳ�ֵ��5�켴����ȡ���񣡿���������ɻ��������Ʒ�� </t><b/> "@
					 GetItemName(105105713, 1)@"<t c='0xF36215ff'> �� 2</t><b/>"@
					 GetItemName(105090511, 1)@"<t c='0xF36215ff'> �� 5</t><b/>"@
					 GetItemName(105090611, 1)@"<t c='0xF36215ff'> �� 5</t><b/>"@
					 GetItemName(113050023, 1)@"<t c='0xF36215ff'> �� 5</t><b/>"@
					 GetItemName(116030002, 1)@"<t c='0xF36215ff'> �� 2</t><b/>"@
					 GetItemName(105090711, 1)@"<t c='0xF36215ff'> �� 5</t><b/>"@
					 GetItemName(105109323, 1)@"<t c='0xF36215ff'> �� 28</t><b/>"@
					 GetItemName(105021051, 1)@"<t c='0xF36215ff'> �� 1</t><b/>"@
					 GetItemName(105021061, 1)@"<t c='0xF36215ff'> �� 1</t><b/>"@
					 GetItemName(119015001, 1)@"<t c='0xF36215ff'> �� 1</t>";


            //===============================================================================��������԰=========================================================================



			case "Getrewordbutton"://ÿ�չ���
				if ($TodayGoalWnd_Pagination[Getplayer()] == 1)
				{
					%CJdajiang = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>������ɫ������󼴿���ȡ��������߿���ȡ��</t><b/><t>2,000,000 ����</t><b/><t>1,000,000 ���</t><b/><t>200 ��Ծ����</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>���������������������������</t>";
				}
				else if ($TodayGoalWnd_Pagination[Getplayer()] == 2)
				{
					%CJdajiang = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ÿ�չ���</t><b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��������ĸ�ÿ�ո�������󼴿���ȡ������</t><b/><t>1,000,000 ����</t><b/><t>50,000 ���</t><b/><t>100 ��Ծ����</t><b/><t>����תתת�齱��������1</t><b/><t gct='0xff7171ff' gcb='0xff3c00ff'>1��7��0��������һ��ɶ�����100 </t><i s='gameres/gui/images/GUIWindow31_1_027.png' w='16' h='18'/>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'>"@ %CJdajiang @"</t>";

				//===============================================================================��پ���=========================================================================

			case "FiveBitMipInMiddleReady_1"://δ�ɽٵ�һ��
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ǰ��</t><b/><t>���ȼ�������һ��3��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ�����������3��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ٹ�����</t><b/><t>���ȼ�����������3��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ǰ��</t><b/><t>���ȼ��������ĵ�3��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�Ķ�����</t><b/><t>���ȼ����������3��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ�����������3��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'>"@ %TJjingjie @"</t>";




			case "FiveBitMipInMiddleReady_2"://δ�ɽٵڶ���
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ�������һ��4��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ǰ��</t><b/><t>���ȼ�����������4��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ٹȺ���</t><b/><t>���ȼ�����������4��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ��������ĵ�4��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ԪӤǰ��</t><b/><t>���ȼ����������4��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t><b/><t>���ȼ�����������4��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'>"@ %TJjingjie @"</t>";



			case "FiveBitMipInMiddleReady_3"://δ�ɽٵ�����
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t><b/><t>���ȼ�������һ��5��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ�����������5��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰ��</t><b/><t>���ȼ�����������5��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t><b/><t>���ȼ��������ĵ�5��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ԪӤ����</t><b/><t>���ȼ����������5��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ڤǰ��</t><b/><t>���ȼ�����������5��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'>"@ %TJjingjie @"</t>";



			case "FiveBitMipInMiddleReady_4"://δ�ɽٵ��ĸ�
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ǰ��</t><b/><t>���ȼ�������һ��6��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ�����������6��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t>���ȼ�����������6��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�Ķ�ǰ��</t><b/><t>���ȼ��������ĵ�6��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ԪӤ����</t><b/><t>���ȼ����������6��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ڤ����</t><b/><t>���ȼ�����������6��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'>"@ %TJjingjie @"</t>";


			case "FiveBitMipInMiddleReady_5"://δ�ɽٵ����
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ�������һ��7��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ٹ�ǰ��</t><b/><t>���ȼ�����������7��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�𵤺���</t><b/><t>���ȼ�����������7��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�Ķ�����</t><b/><t>���ȼ��������ĵ�7��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ǰ��</t><b/><t>���ȼ����������7��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ڤ����</t><b/><t>���ȼ�����������7��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'>"@ %TJjingjie @"</t>";


			case "FiveBitMipInMiddleHas_1"://�Ѷɽٵ�һ��
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ǰ��</t><b/><t>���ȼ�������һ��3��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ�����������3��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ٹ�����</t><b/><t>���ȼ�����������3��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ǰ��</t><b/><t>���ȼ��������ĵ�3��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�Ķ�����</t><b/><t>���ȼ����������3��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ�����������3��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'>"@ %TJjingjie @"</t>";




			case "FiveBitMipInMiddleHas_2"://�Ѷɽٵڶ���
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ�������һ��4��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ǰ��</t><b/><t>���ȼ�����������4��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ٹȺ���</t><b/><t>���ȼ�����������4��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ��������ĵ�4��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ԪӤǰ��</t><b/><t>���ȼ����������4��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t><b/><t>���ȼ�����������4��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'>"@ %TJjingjie @"</t>";



			case "FiveBitMipInMiddleHas_3"://�Ѷɽٵ�����
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t><b/><t>���ȼ�������һ��5��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ�����������5��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰ��</t><b/><t>���ȼ�����������5��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t><b/><t>���ȼ��������ĵ�5��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ԪӤ����</t><b/><t>���ȼ����������5��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ڤǰ��</t><b/><t>���ȼ�����������5��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'>"@ %TJjingjie @"</t>";



			case "FiveBitMipInMiddleHas_4"://�Ѷɽٵ��ĸ�
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ǰ��</t><b/><t>���ȼ�������һ��6��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ�����������6��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t>���ȼ�����������6��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�Ķ�ǰ��</t><b/><t>���ȼ��������ĵ�6��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ԪӤ����</t><b/><t>���ȼ����������6��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ڤ����</t><b/><t>���ȼ�����������6��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'>"@ %TJjingjie @"</t>";


			case "FiveBitMipInMiddleHas_5"://�Ѷɽٵ����
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ�������һ��7��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ٹ�ǰ��</t><b/><t>���ȼ�����������7��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�𵤺���</t><b/><t>���ȼ�����������7��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�Ķ�����</t><b/><t>���ȼ��������ĵ�7��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ǰ��</t><b/><t>���ȼ����������7��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ڤ����</t><b/><t>���ȼ�����������7��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}


				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'>"@ %TJjingjie @"</t>";




			case "FiveBitMipInMiddleNot_1"://δ��������һ��
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ǰ��</t><b/><t>���ȼ�������һ��3��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ�����������3��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ٹ�����</t><b/><t>���ȼ�����������3��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ǰ��</t><b/><t>���ȼ��������ĵ�3��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�Ķ�����</t><b/><t>���ȼ����������3��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ�����������3��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'>"@ %TJjingjie @"</t>";




			case "FiveBitMipInMiddleNot_2"://δ�������ڶ���
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ�������һ��4��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ǰ��</t><b/><t>���ȼ�����������4��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ٹȺ���</t><b/><t>���ȼ�����������4��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ��������ĵ�4��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ԪӤǰ��</t><b/><t>���ȼ����������4��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t><b/><t>���ȼ�����������4��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'>"@ %TJjingjie @"</t>";



			case "FiveBitMipInMiddleNot_3"://δ������������
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t><b/><t>���ȼ�������һ��5��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ�����������5��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ǰ��</t><b/><t>���ȼ�����������5��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�������</t><b/><t>���ȼ��������ĵ�5��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ԪӤ����</t><b/><t>���ȼ����������5��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ڤǰ��</t><b/><t>���ȼ�����������5��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'>"@ %TJjingjie @"</t>";



			case "FiveBitMipInMiddleNot_4"://δ���������ĸ�
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ǰ��</t><b/><t>���ȼ�������һ��6��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ�����������6��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>������</t><b/><t>���ȼ�����������6��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�Ķ�ǰ��</t><b/><t>���ȼ��������ĵ�6��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ԪӤ����</t><b/><t>���ȼ����������6��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ڤ����</t><b/><t>���ȼ�����������6��9�ؿ��Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}

				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'>"@ %TJjingjie @"</t>";


			case "FiveBitMipInMiddleNot_5"://δ�����������
				%tianjie = ReturnWitchTianJieBTNStateOn();

				if (%tianjie == 1)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��������</t><b/><t>���ȼ���������Ӧ�ȼ����Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 2)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�ٹ�ǰ��</t><b/><t>���ȼ���������Ӧ�ȼ����Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 3)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�𵤺���</t><b/><t>���ȼ���������Ӧ�ȼ����Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 4)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>�Ķ�����</t><b/><t>���ȼ���������Ӧ�ȼ����Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 5)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ǰ��</t><b/><t>���ȼ���������Ӧ�ȼ����Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}
				else if (%tianjie == 6)
				{
					%TJjingjie = "<t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ڤ����</t><b/><t>���ȼ���������Ӧ�ȼ����Խ��жɽ٣��ɽٺ󽫻���������Լӳ�</t>";
				}


				%ctrl.tooltipWidth = 190;
				%ctrl.tooltip = "<t m='1' f='����' n='12'>"@ %TJjingjie @"</t>";



				//===============================================================================����ϵͳ=========================================================================
				//upcs(99);OpenOrCloseJingLuo_MainWnd()
				/*
				105099251	һƷϴ�赤
				105099252	��Ʒϴ�赤
				105099253	��Ʒϴ�赤
				105099254	��Ʒϴ�赤
				105099255	��Ʒϴ�赤
				*/


				//=================����ϵͳ===========

			case "RenMaiWnd_Unable_XueWei_1"://����-00�н�Ѩ
				if ($DoufuGan_Item[105099251,2] > 0)
				{
					closeHelpDirect1_4(10028);

					OpenDouFuGan(10029);

					$DoufuGan_Item[105099251,2] = 0;
				}

				%item = GetPlayer().GetItemCount(105099251);
				%jingmai = GetCurGodPrintLevel(0,0);

				if (%jingmai == 0)
				{


					%FirstLevel1 ="�н�Ѩ</t><t m='1' f='����' n='12' b='1' c='0x969399ff'>��0/2��";
					%Attr1 ="<t c='0x969399ff'>δ�������+200 ����+120</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ�������+280 ����+170</t><b/>";
					%Attr3 ="";
					%Attr4 ="";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>һƷϴ�赤:"@ %item @"/1</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+200</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="�н�Ѩ</t><t m='1' f='����' n='12' b='1' >��1/2��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+200 ����+120</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ�������+280 ����+170</t><b/>";
					%Attr3 ="";
					%Attr4 ="";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>һƷϴ�赤:"@ %item @"/3</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+200</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="�н�Ѩ</t><t m='1' f='����' n='12' b='1' >��2/2��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+200 ����+120</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ������+280 ����+170</t><b/>";
					%Attr3 ="";
					%Attr4 ="";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>����������ԣ�</t><b/><t c='0xff00ffff'>�������+200</t>";
				}


				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='����' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";



			case "RenMaiWnd_Unable_XueWei_2"://����-01���Ѩ
				%item = GetPlayer().GetItemCount(105099252);
				%jingmai = GetCurGodPrintLevel(0,1);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="���Ѩ</t><t m='1' f='����' n='12' b='1' c='0x969399ff'>��0/4��";
					%Attr1 ="<t c='0x969399ff'>δ�������+220 ����+130</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ�������+310 ����+180</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ�������+430 ����+260</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ�������+600 ����+360</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/1</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+500</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="���Ѩ</t><t m='1' f='����' n='12' b='1' >��1/4��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+220 ����+130</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ�������+310 ����+180</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ�������+430 ����+260</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ�������+600 ����+360</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/3</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+500</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="���Ѩ</t><t m='1' f='����' n='12' b='1' >��2/4��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+220 ����+130</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ������+310 ����+180</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ�������+430 ����+260</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ�������+600 ����+360</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/5</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+500</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="���Ѩ</t><t m='1' f='����' n='12' b='1' >��3/4��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+220 ����+130</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ������+310 ����+180</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ������+430 ����+260</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ�������+600 ����+360</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/7</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+500</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="���Ѩ</t><t m='1' f='����' n='12' b='1' >��4/4��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+220 ����+130</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ������+310 ����+180</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ������+430 ����+260</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ������+600 ����+360</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>����������ԣ�</t><b/><t c='0xff00ffff'>�������+500</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='����' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";




			case "RenMaiWnd_Unable_XueWei_3"://����-02����Ѩ
				%item = GetPlayer().GetItemCount(105099253);
				%jingmai = GetCurGodPrintLevel(0,2);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' c='0x969399ff'>��0/5��";
					%Attr1 ="<t c='0x969399ff'>δ�������+240 ����+150</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ�������+340 ����+200</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ�������+470 ����+280</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ�������+660 ����+400</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ�������+930 ����+560</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/2</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+900</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��1/5��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+240 ����+150</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ�������+340 ����+200</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ�������+470 ����+280</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ�������+660 ����+400</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ�������+930 ����+560</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/4</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+900</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��2/5��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+240 ����+150</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ������+340 ����+200</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ�������+470 ����+280</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ�������+660 ����+400</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ�������+930 ����+560</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/6</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+900</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��3/5��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+240 ����+150</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ������+340 ����+200</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ������+470 ����+280</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ�������+660 ����+400</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ�������+930 ����+560</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/8</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+900</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��4/5��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+240 ����+150</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ������+340 ����+200</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ������+470 ����+280</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ������+660 ����+400</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ�������+930 ����+560</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/10</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+900</t>";
				}
				else if (%jingmai == 5)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��5/5��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+240 ����+150</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ������+340 ����+200</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ������+470 ����+280</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ������+660 ����+400</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>�Ѽ������+930 ����+560</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>����������ԣ�</t><b/><t c='0xff00ffff'>�������+900</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='����' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";



			case "RenMaiWnd_Unable_XueWei_4"://����-03����Ѩ
				%item = GetPlayer().GetItemCount(105099254);
				%jingmai = GetCurGodPrintLevel(0,3);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' c='0x969399ff'>��0/6��";
					%Attr1 ="<t c='0x969399ff'>δ�������+270  ����+160</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ�������+370  ����+220</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ�������+520  ����+310</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ�������+730  ����+440</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ�������+1020 ����+610</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ�������+1430 ����+860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/2</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+1500</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��1/6��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+270  ����+160</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ�������+370  ����+220</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ�������+520  ����+310</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ�������+730  ����+440</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ�������+1020 ����+610</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ�������+1430 ����+860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/4</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+1500</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��2/6��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+270  ����+160</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ������+370  ����+220</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ�������+520  ����+310</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ�������+730  ����+440</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ�������+1020 ����+610</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ�������+1430 ����+860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/6</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+1500</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��3/6��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+270  ����+160</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ������+370  ����+220</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ������+520  ����+310</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ�������+730  ����+440</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ�������+1020 ����+610</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ�������+1430 ����+860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/8</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+1500</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��4/6��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+270  ����+160</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ������+370  ����+220</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ������+520  ����+310</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ������+730  ����+440</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ�������+1020 ����+610</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ�������+1430 ����+860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/10</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+1500</t>";
				}
				else if (%jingmai == 5)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��5/6��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+270  ����+160</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ������+370  ����+220</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ������+520  ����+310</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ������+730  ����+440</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>�Ѽ������+1020 ����+610</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ�������+1430 ����+860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/12</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+1500</t>";
				}
				else if (%jingmai == 6)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��6/6��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+270  ����+160</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ������+370  ����+220</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ������+520  ����+310</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ������+730  ����+440</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>�Ѽ������+1020 ����+610</t><b/>";
					%Attr6 ="<t c='0x3D8FD8ff'>�Ѽ������+1430 ����+860</t><b/>";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>����������ԣ�</t><b/><t c='0xff00ffff'>�������+1500</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='����' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";



			case "RenMaiWnd_Unable_XueWei_5"://����-04����Ѩ
				%item = GetPlayer().GetItemCount(105099255);
				%jingmai = GetCurGodPrintLevel(0,4);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' c='0x969399ff'>��0/7��";
					%Attr1 ="<t c='0x969399ff'>δ�������+290  ����+180</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ�������+410  ����+250</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ�������+570  ����+340</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ�������+800  ����+480</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ�������+1120 ����+670</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ�������+1570 ����+940</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ�������+2200 ����+1320</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/3</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+3000</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��1/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+290  ����+180</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ�������+410  ����+250</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ�������+570  ����+340</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ�������+800  ����+480</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ�������+1120 ����+670</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ�������+1570 ����+940</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ�������+2200 ����+1320</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/5</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+3000</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��2/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+290  ����+180</t><b/>";
					%Attr2 ="<t c='0x969399ff'>�Ѽ������+410  ����+250</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ�������+570  ����+340</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ�������+800  ����+480</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ�������+1120 ����+670</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ�������+1570 ����+940</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ�������+2200 ����+1320</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/7</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+3000</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��3/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+290  ����+180</t><b/>";
					%Attr2 ="<t c='0x969399ff'>�Ѽ������+410  ����+250</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ������+570  ����+340</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ�������+800  ����+480</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ�������+1120 ����+670</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ�������+1570 ����+940</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ�������+2200 ����+1320</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/9</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+3000</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��6/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+290  ����+180</t><b/>";
					%Attr2 ="<t c='0x969399ff'>�Ѽ������+410  ����+250</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ������+570  ����+340</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ������+800  ����+480</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ�������+1120 ����+670</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ�������+1570 ����+940</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ�������+2200 ����+1320</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/11</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+3000</t>";
				}
				else if (%jingmai == 5)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��5/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+290  ����+180</t><b/>";
					%Attr2 ="<t c='0x969399ff'>�Ѽ������+410  ����+250</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ������+570  ����+340</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ������+800  ����+480</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>�Ѽ������+1120 ����+670</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ�������+1570 ����+940</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ�������+2200 ����+1320</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/13</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+3000</t>";
				}
				else if (%jingmai == 6)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��6/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+290  ����+180</t><b/>";
					%Attr2 ="<t c='0x969399ff'>�Ѽ������+410  ����+250</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ������+570  ����+340</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ������+800  ����+480</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>�Ѽ������+1120 ����+670</t><b/>";
					%Attr6 ="<t c='0x3D8FD8ff'>�Ѽ������+1570 ����+940</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ�������+2200 ����+1320</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/15</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>�������+3000</t>";
				}
				else if (%jingmai == 7)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��7/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ������+290  ����+180</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ������+410  ����2+50</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ������+570  ����+340</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ������+800  ����+480</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>�Ѽ������+1120 ����+670</t><b/>";
					%Attr6 ="<t c='0x3D8FD8ff'>�Ѽ������+1570 ����+940</t><b/>";
					%Attr7 ="<t c='0x3D8FD8ff'>�Ѽ������+2200 ����+1320</t><b/>";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>����������ԣ�</t><b/><t c='0xff00ffff'>�������+3000</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='����' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";



				//=================����ϵͳ===========

			case "DuMaiWnd_Unable_XueWei_1"://����-00����Ѩ
				%item = GetPlayer().GetItemCount(105099251);
				%jingmai = GetCurGodPrintLevel(1,0);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' c='0x969399ff'>��0/2��";
					%Attr1 ="<t c='0x969399ff'>δ���������+50 ��������+50</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ���������+70 ��������+70</t><b/>";
					%Attr3 ="";
					%Attr4 ="";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>һƷϴ�赤:"@ %item @"/1</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+180</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��1/2��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+50 ��������+50</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ���������+70 ��������+70</t><b/>";
					%Attr3 ="";
					%Attr4 ="";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>һƷϴ�赤:"@ %item @"/3</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+180</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��2/2��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+50 ��������+50</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ��������+70 ��������+70</t><b/>";
					%Attr3 ="";
					%Attr4 ="";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>����������ԣ�</t><b/><t c='0xff00ffff'>����ֵ+180</t>";
				}


				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='����' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";




			case "DuMaiWnd_Unable_XueWei_2"://����-01����Ѩ
				if ($DoufuGan_Item[105099252,5] > 0)
				{
					closeHelpDirect1_4(10032);

					OpenDouFuGan(10029);

					$DoufuGan_Item[105099251,5] = 0;
				}


				%item = GetPlayer().GetItemCount(105099252);
				%jingmai = GetCurGodPrintLevel(1,1);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="�羮Ѩ</t><t m='1' f='����' n='12' b='1' c='0x969399ff'>��0/4��";
					%Attr1 ="<t c='0x969399ff'>δ���������+70  ��������+70</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ���������+90  ��������+90</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ���������+130 ��������+130</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ���������+190 ��������+190</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/1</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+315</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="�羮Ѩ</t><t m='1' f='����' n='12' b='1' >��1/4��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+70  ��������+70</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ���������+90  ��������+90</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ���������+130 ��������+130</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ���������+190 ��������+190</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/3</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+315</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="�羮Ѩ</t><t m='1' f='����' n='12' b='1' >��2/4��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+70  ��������+70</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ��������+90  ��������+90</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ���������+130 ��������+130</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ���������+190 ��������+190</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/5</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+315</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="�羮Ѩ</t><t m='1' f='����' n='12' b='1' >��3/4��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+70  ��������+70</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ��������+90  ��������+90</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ��������+130 ��������+130</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ���������+190 ��������+190</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/7</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+315</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="�羮Ѩ</t><t m='1' f='����' n='12' b='1' >��4/4��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+70  ��������+70</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ��������+90  ��������+90</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ��������+130 ��������+130</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ��������+190 ��������+190</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>����������ԣ�</t><b/><t c='0xff00ffff'>����ֵ+315</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='����' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";




			case "DuMaiWnd_Unable_XueWei_3"://����-02����Ѩ
				%item = GetPlayer().GetItemCount(105099253);
				%jingmai = GetCurGodPrintLevel(1,2);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' c='0x969399ff'>��0/5��";
					%Attr1 ="<t c='0x969399ff'>δ���������+90  ��������+90</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ���������+110 ��������+110</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ���������+150 ��������+150</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ���������+210 ��������+210</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ���������+290 ��������+290</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/2</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+630</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��1/5��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+90  ��������+90</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ���������+110 ��������+110</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ���������+150 ��������+150</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ���������+210 ��������+210</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ���������+290 ��������+290</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/4</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+630</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��2/5��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+90  ��������+90</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ��������+110 ��������+110</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ���������+150 ��������+150</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ���������+210 ��������+210</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ���������+290 ��������+290</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/6</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+630</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��3/5��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+90  ��������+90</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ��������+110 ��������+110</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ��������+150 ��������+150</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ���������+210 ��������+210</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ���������+290 ��������+290</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/8</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+630</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��4/5��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+90  ��������+90</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ��������+110 ��������+110</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ��������+150 ��������+150</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ��������+210 ��������+210</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ���������+290 ��������+290</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/10</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+630</t>";
				}
				else if (%jingmai == 5)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��5/5��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+90  ��������+90</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ��������+110 ��������+110</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ��������+150 ��������+150</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ��������+210 ��������+210</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>�Ѽ��������+290 ��������+290</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>����������ԣ�</t><b/><t c='0xff00ffff'>����ֵ+630</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='����' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";



			case "DuMaiWnd_Unable_XueWei_4"://����-03����Ѩ
				%item = GetPlayer().GetItemCount(105099254);
				%jingmai = GetCurGodPrintLevel(1,3);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' c='0x969399ff'>��0/6��";
					%Attr1 ="<t c='0x969399ff'>δ���������+110 ��������+110</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ���������+130 ��������+130</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ���������+170 ��������+170</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ���������+230 ��������+230</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ���������+310 ��������+310</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ���������+410 ��������+410</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/2</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+1125</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��1/6��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+110 ��������+110</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ���������+130 ��������+130</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ���������+170 ��������+170</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ���������+230 ��������+230</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ���������+310 ��������+310</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ���������+410 ��������+410</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/4</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+1125</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��2/6��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+110 ��������+110</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ��������+130 ��������+130</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ���������+170 ��������+170</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ���������+230 ��������+230</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ���������+310 ��������+310</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ���������+410 ��������+410</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/6</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+1125</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��3/6��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+110 ��������+110</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ��������+130 ��������+130</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ��������+170 ��������+170</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ���������+230 ��������+230</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ���������+310 ��������+310</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ���������+410 ��������+410</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/8</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+1125</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��4/6��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+110 ��������+110</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ��������+130 ��������+130</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ��������+170 ��������+170</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ��������+230 ��������+230</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ���������+310 ��������+310</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ���������+410 ��������+410</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/10</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+1125</t>";
				}
				else if (%jingmai == 5)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��5/6��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+110 ��������+110</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ��������+130 ��������+130</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ��������+170 ��������+170</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ��������+230 ��������+230</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>�Ѽ��������+310 ��������+310</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ���������+410 ��������+410</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/12</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+1125</t>";
				}
				else if (%jingmai == 6)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��6/6��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+110 ��������+110</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ��������+130 ��������+130</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ��������+170 ��������+170</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ��������+230 ��������+230</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>�Ѽ��������+310 ��������+310</t><b/>";
					%Attr6 ="<t c='0x3D8FD8ff'>�Ѽ��������+410 ��������+410</t><b/>";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>����������ԣ�</t><b/><t c='0xff00ffff'>����ֵ+1125</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='����' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";



			case "DuMaiWnd_Unable_XueWei_5"://����-04����Ѩ
				%item = GetPlayer().GetItemCount(105099255);
				%jingmai = GetCurGodPrintLevel(1,4);


				if (%jingmai == 0)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' c='0x969399ff'>��0/7��";
					%Attr1 ="<t c='0x969399ff'>δ���������+120 ��������+130</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ���������+140 ��������+150</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ���������+180 ��������+190</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ���������+240 ��������+250</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ���������+330 ��������+330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ���������+430 ��������+430</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ���������+650 ��������+550</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/3</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+2250</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��1/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+120 ��������+130</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ���������+140 ��������+150</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ���������+180 ��������+190</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ���������+240 ��������+250</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ���������+330 ��������+330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ���������+430 ��������+430</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ���������+650 ��������+550</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/5</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+2250</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��2/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+120 ��������+130</t><b/>";
					%Attr2 ="<t c='0x969399ff'>�Ѽ��������+140 ��������+150</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ���������+180 ��������+190</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ���������+240 ��������+250</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ���������+330 ��������+330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ���������+430 ��������+430</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ���������+650 ��������+550</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/7</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+2250</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��3/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+120 ��������+130</t><b/>";
					%Attr2 ="<t c='0x969399ff'>�Ѽ��������+140 ��������+150</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ��������+180 ��������+190</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ���������+240 ��������+250</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ���������+330 ��������+330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ���������+430 ��������+430</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ���������+650 ��������+550</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/9</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+2250</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��6/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+120 ��������+130</t><b/>";
					%Attr2 ="<t c='0x969399ff'>�Ѽ��������+140 ��������+150</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ��������+180 ��������+190</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ��������+240 ��������+250</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ���������+330 ��������+330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ���������+430 ��������+430</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ���������+650 ��������+550</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/11</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+2250</t>";
				}
				else if (%jingmai == 5)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��5/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+120 ��������+130</t><b/>";
					%Attr2 ="<t c='0x969399ff'>�Ѽ��������+140 ��������+150</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ��������+180 ��������+190</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ��������+240 ��������+250</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>�Ѽ��������+330 ��������+330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ���������+430 ��������+430</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ���������+650 ��������+550</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/13</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+2250</t>";
				}
				else if (%jingmai == 6)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��6/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+120 ��������+130</t><b/>";
					%Attr2 ="<t c='0x969399ff'>�Ѽ��������+140 ��������+150</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ��������+180 ��������+190</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ��������+240 ��������+250</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>�Ѽ��������+330 ��������+330</t><b/>";
					%Attr6 ="<t c='0x3D8FD8ff'>�Ѽ��������+430 ��������+430</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ���������+650 ��������+550</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/15</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+2250</t>";
				}
				else if (%jingmai == 7)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��7/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��������+120 ��������+130</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ��������+140 ��������+150</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ��������+180 ��������+190</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ��������+240 ��������+250</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>�Ѽ��������+330 ��������+330</t><b/>";
					%Attr6 ="<t c='0x3D8FD8ff'>�Ѽ��������+430 ��������+430</t><b/>";
					%Attr7 ="<t c='0x3D8FD8ff'>�Ѽ��������+650 ��������+550</t><b/>";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>����������ԣ�</t><b/><t c='0xff00ffff'>����ֵ+2250</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='����' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";


				//=================����ϵͳ===========

			case "ChongMaiWnd_Unable_XueWei_1"://����-00ä��Ѩ
				%item = GetPlayer().GetItemCount(105099251);
				%jingmai = GetCurGodPrintLevel(2,0);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="ä��Ѩ</t><t m='1' f='����' n='12' b='1' c='0x969399ff'>��0/2��";
					%Attr1 ="<t c='0x969399ff'>δ����������+200 ��������+200</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ����������+280 ��������+280</t><b/>";
					%Attr3 ="";
					%Attr4 ="";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>һƷϴ�赤:"@ %item @"/1</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+200</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="ä��Ѩ</t><t m='1' f='����' n='12' b='1' >��1/2��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+200 ��������+200</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ����������+280 ��������+280</t><b/>";
					%Attr3 ="";
					%Attr4 ="";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>һƷϴ�赤:"@ %item @"/3</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+200</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="ä��Ѩ</t><t m='1' f='����' n='12' b='1' >��2/2��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+200 ��������+200</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ���������+280 ��������+280</t><b/>";
					%Attr3 ="";
					%Attr4 ="";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>����������ԣ�</t><b/><t c='0xff00ffff'>����ֵ+200</t>";
				}


				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='����' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";




			case "ChongMaiWnd_Unable_XueWei_2"://����-01ʯ��Ѩ
				%item = GetPlayer().GetItemCount(105099252);
				%jingmai = GetCurGodPrintLevel(2,1);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="ʯ��Ѩ</t><t m='1' f='����' n='12' b='1' c='0x969399ff'>��0/4��";
					%Attr1 ="<t c='0x969399ff'>δ����������+240 ��������+240</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ����������+340 ��������+340</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ����������+470 ��������+470</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ����������+660 ��������+660</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/1</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+350</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="ʯ��Ѩ</t><t m='1' f='����' n='12' b='1' >��1/4��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+240 ��������+240</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ����������+340 ��������+340</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ����������+470 ��������+470</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ����������+660 ��������+660</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/3</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+350</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="ʯ��Ѩ</t><t m='1' f='����' n='12' b='1' >��2/4��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+240 ��������+240</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ���������+340 ��������+340</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ����������+470 ��������+470</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ����������+660 ��������+660</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/5</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+350</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="ʯ��Ѩ</t><t m='1' f='����' n='12' b='1' >��3/4��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+240 ��������+240</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ���������+340 ��������+340</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ���������+470 ��������+470</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ����������+660 ��������+660</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/7</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+350</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="ʯ��Ѩ</t><t m='1' f='����' n='12' b='1' >��4/4��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+240 ��������+240</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ���������+340 ��������+340</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ���������+470 ��������+470</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ���������+660 ��������+660</t><b/>";
					%Attr5 ="";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>����������ԣ�</t><b/><t c='0xff00ffff'>����ֵ+350</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='����' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";





			case "ChongMaiWnd_Unable_XueWei_3"://����-02����Ѩ
				%item = GetPlayer().GetItemCount(105099253);
				%jingmai = GetCurGodPrintLevel(2,2);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' c='0x969399ff'>��0/5��";
					%Attr1 ="<t c='0x969399ff'>δ����������+290  ��������+290</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ����������+400  ��������+400</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ����������+560  ��������+560</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ����������+790  ��������+790</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ����������+1110 ��������+1110</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/2</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+700</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��1/5��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+290  ��������+290</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ����������+400  ��������+400</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ����������+560  ��������+560</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ����������+790  ��������+790</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ����������+1110 ��������+1110</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/4</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+700</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��2/5��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+290  ��������+290</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ���������+400  ��������+400</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ����������+560  ��������+560</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ����������+790  ��������+790</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ����������+1110 ��������+1110</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/6</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+700</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��3/5��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+290  ��������+290</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ���������+400  ��������+400</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ���������+560  ��������+560</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ����������+790  ��������+790</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ����������+1110 ��������+1110</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/8</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+700</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��4/5��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+290  ��������+290</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ���������+400  ��������+400</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ���������+560  ��������+560</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ���������+790  ��������+790</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ����������+1110 ��������+1110</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/10</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+700</t>";
				}
				else if (%jingmai == 5)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��5/5��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+290  ��������+290</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ���������+400  ��������+400</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ���������+560  ��������+560</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ���������+790  ��������+790</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>�Ѽ���������+1110 ��������+1110</t><b/>";
					%Attr6 ="";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>����������ԣ�</t><b/><t c='0xff00ffff'>����ֵ+700</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='����' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";



			case "ChongMaiWnd_Unable_XueWei_4"://����-03����Ѩ
				%item = GetPlayer().GetItemCount(105099254);
				%jingmai = GetCurGodPrintLevel(2,3);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' c='0x969399ff'>��0/6��";
					%Attr1 ="<t c='0x969399ff'>δ����������+350  ��������+350</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ����������+480  ��������+480</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ����������+680  ��������+680</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ����������+950  ��������+950</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ����������+1330 ��������+1330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ����������+1860 ��������+1860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/2</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+1250</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��1/6��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+350  ��������+350</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ����������+480  ��������+480</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ����������+680  ��������+680</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ����������+950  ��������+950</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ����������+1330 ��������+1330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ����������+1860 ��������+1860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/4</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+1250</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��2/6��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+350  ��������+350</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ���������+480  ��������+480</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ����������+680  ��������+680</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ����������+950  ��������+950</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ����������+1330 ��������+1330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ����������+1860 ��������+1860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/6</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+1250</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��3/6��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+350  ��������+350</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ���������+480  ��������+480</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ���������+680  ��������+680</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ����������+950  ��������+950</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ����������+1330 ��������+1330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ����������+1860 ��������+1860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/8</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+1250</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��4/6��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+350  ��������+350</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ���������+480  ��������+480</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ���������+680  ��������+680</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ���������+950  ��������+950</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ����������+1330 ��������+1330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ����������+1860 ��������+1860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/10</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+1250</t>";
				}
				else if (%jingmai == 5)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��5/6��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+350  ��������+350</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ���������+480  ��������+480</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ���������+680  ��������+680</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ���������+950  ��������+950</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>�Ѽ���������+1330 ��������+1330</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ����������+1860 ��������+1860</t><b/>";
					%Attr7 ="";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/12</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+1250</t>";
				}
				else if (%jingmai == 6)
				{
					%FirstLevel1 ="����Ѩ</t><t m='1' f='����' n='12' b='1' >��6/6��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+350  ��������+350</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ���������+480  ��������+480</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ���������+680  ��������+680</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ���������+950  ��������+950</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>�Ѽ���������+1330 ��������+1330</t><b/>";
					%Attr6 ="<t c='0x3D8FD8ff'>�Ѽ���������+1860 ��������+1860</t><b/>";
					%Attr7 ="";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>����������ԣ�</t><b/><t c='0xff00ffff'>����ֵ+1250</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='����' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";



			case "ChongMaiWnd_Unable_XueWei_5"://����-04ͨ��Ѩ
				%item = GetPlayer().GetItemCount(105099255);
				%jingmai = GetCurGodPrintLevel(2,4);

				if (%jingmai == 0)
				{
					%FirstLevel1 ="ͨ��Ѩ</t><t m='1' f='����' n='12' b='1' c='0x969399ff'>��0/7��";
					%Attr1 ="<t c='0x969399ff'>δ����������+410  ��������+410</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ����������+580  ��������+580</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ����������+810  ��������+810</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ����������+1140 ��������+1140</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ����������+1590 ��������+1590</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ����������+2230 ��������+2230</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ����������+3120 ��������+3120</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/3</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+2500</t>";
				}
				else if (%jingmai == 1)
				{
					%FirstLevel1 ="ͨ��Ѩ</t><t m='1' f='����' n='12' b='1' >��1/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+410  ��������+410</t><b/>";
					%Attr2 ="<t c='0x969399ff'>δ����������+580  ��������+580</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ����������+810  ��������+810</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ����������+1140 ��������+1140</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ����������+1590 ��������+1590</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ����������+2230 ��������+2230</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ����������+3120 ��������+3120</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/5</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+2500</t>";
				}
				else if (%jingmai == 2)
				{
					%FirstLevel1 ="ͨ��Ѩ</t><t m='1' f='����' n='12' b='1' >��2/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+410  ��������+410</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ���������+580  ��������+580</t><b/>";
					%Attr3 ="<t c='0x969399ff'>δ����������+810  ��������+810</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ����������+1140 ��������+1140</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ����������+1590 ��������+1590</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ����������+2230 ��������+2230</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ����������+3120 ��������+3120</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/7</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+2500</t>";
				}
				else if (%jingmai == 3)
				{
					%FirstLevel1 ="ͨ��Ѩ</t><t m='1' f='����' n='12' b='1' >��3/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+410  ��������+410</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ���������+580  ��������+580</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ���������+810  ��������+810</t><b/>";
					%Attr4 ="<t c='0x969399ff'>δ����������+1140 ��������+1140</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ����������+1590 ��������+1590</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ����������+2230 ��������+2230</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ����������+3120 ��������+3120</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/9</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+2500</t>";
				}
				else if (%jingmai == 4)
				{
					%FirstLevel1 ="ͨ��Ѩ</t><t m='1' f='����' n='12' b='1' >��6/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+410  ��������+410</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ���������+580  ��������+580</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ���������+810  ��������+810</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ���������+1140 ��������+1140</t><b/>";
					%Attr5 ="<t c='0x969399ff'>δ����������+1590 ��������+1590</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ����������+2230 ��������+2230</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ����������+3120 ��������+3120</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/11</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+2500</t>";
				}
				else if (%jingmai == 5)
				{
					%FirstLevel1 ="ͨ��Ѩ</t><t m='1' f='����' n='12' b='1' >��5/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+410  ��������+410</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ���������+580  ��������+580</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ���������+810  ��������+810</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ���������+1140 ��������+1140</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>�Ѽ���������+1590 ��������+1590</t><b/>";
					%Attr6 ="<t c='0x969399ff'>δ����������+2230 ��������+2230</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ����������+3120 ��������+3120</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/13</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+2500</t>";
				}
				else if (%jingmai == 6)
				{
					%FirstLevel1 ="ͨ��Ѩ</t><t m='1' f='����' n='12' b='1' >��6/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ���������+410  ��������+410</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ���������+580  ��������+580</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ���������+810  ��������+810</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ���������+1140 ��������+1140</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>�Ѽ���������+1590 ��������+1590</t><b/>";
					%Attr6 ="<t c='0x3D8FD8ff'>�Ѽ���������+2230 ��������+2230</t><b/>";
					%Attr7 ="<t c='0x969399ff'>δ����������+3120 ��������+3120</t><b/>";
					%Nitem ="<b/><t gct='0x00ff00ff' gcb='0x2cffeeff'>��Ѩ����</t><b/><t c='0xff00ffff'>��Ʒϴ�赤:"@ %item @"/15</t><b/>";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>�����������Ժ�ɻ�ö������ԣ�</t><b/><t c='0x969399ff'>����ֵ+2500</t>";
				}
				else if (%jingmai == 7)
				{
					%FirstLevel1 ="ͨ��Ѩ</t><t m='1' f='����' n='12' b='1' >��7/7��";
					%Attr1 ="<t c='0x3D8FD8ff'>�Ѽ��</t><t c='0x3D8FD8ff'>�������+410  ��������+410</t><b/>";
					%Attr2 ="<t c='0x3D8FD8ff'>�Ѽ��</t><t c='0x3D8FD8ff'>�������+580  ��������+580</t><b/>";
					%Attr3 ="<t c='0x3D8FD8ff'>�Ѽ��</t><t c='0x3D8FD8ff'>�������+810  ��������+810</t><b/>";
					%Attr4 ="<t c='0x3D8FD8ff'>�Ѽ��</t><t c='0x3D8FD8ff'>�������+1140 ��������+1140</t><b/>";
					%Attr5 ="<t c='0x3D8FD8ff'>�Ѽ��</t><t c='0x3D8FD8ff'>�������+1590 ��������+1590</t><b/>";
					%Attr6 ="<t c='0x3D8FD8ff'>�Ѽ��</t><t c='0x3D8FD8ff'>�������+2230 ��������+2230</t><b/>";
					%Attr7 ="<t c='0x3D8FD8ff'>�Ѽ��</t><t c='0x3D8FD8ff'>�������+3120 ��������+3120</t><b/>";
					%Nitem ="";
					%fujia ="<t gct='0xffc119ff' gcb='0xc9c555ff'>����������ԣ�</t><b/><t c='0xff00ffff'>����ֵ+2500</t>";
				}

				%ctrl.tooltipWidth = 280;
				%ctrl.tooltip = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff' m='1' f='����' n='14' b='1'>"@ %FirstLevel1 @"</t><b/><b/>"@ %Attr1 @""@ %Attr2 @""@ %Attr3 @""@ %Attr4 @""@ %Attr5 @""@ %Attr6 @""@ %Attr7 @""@ %Nitem @"<b/>"@ %fujia @"</t>";

			case "DTPlayerInfoGui_Tong1"://ս����
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ս������;</t><b/><t>�����ս��ʱ��ս�����ߵ�һ�����������</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>���ӷ���</t><t>��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>�����˺�����</t><t>Ч����˫��</t><t gct='0x00ff00ff' gcb='0x2cffeeff'>��ս��������Խ��</t><t>������Ч��Խ���ԡ�</t>";

			case "DTPlayerInfo_ZDLtext"://ս����
				%ctrl.tooltipWidth = 260;
				%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ս����</t><b/><t>��ͨ����Ϸ�ڶ���ϵͳ�淨������ս����</t>";

	}

	//�� ���ִ�ת�� ���������
	switch$(%ctrl.GetName())
	{
			case "HappinessRandomAwardGuiChooseBag_1":%ctrl.tooltipWidth = 220;%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ɫ����</t><b/><t>ʹ��һ��ת�������ȥ���ø���</t>";
			case "HappinessRandomAwardGuiChooseBag_2":%ctrl.tooltipWidth = 220;%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ɫ����</t><b/><t>ʹ�ö���ת�������ȥ���ø�������ɫ����Ҳͬʱȥ��</t>";
			case "HappinessRandomAwardGuiChooseBag_3":%ctrl.tooltipWidth = 220;%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ɫ����</t><b/><t>ʹ�ö���ת�������ȥ���ø�������ɫ����Ҳͬʱȥ��</t>";
			case "HappinessRandomAwardGuiChooseBag_4":%ctrl.tooltipWidth = 220;%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ɫ����</t><b/><t>����ռ�����������ڴ˸������У�ʱ���ó�������һ�¡�ĳ�ղ�����ʧ...</t>";
			case "HappinessRandomAwardGuiChooseBag_5":%ctrl.tooltipWidth = 220;%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��ɫ����</t><b/><t>�̺��˰�������֮������Ӵ���͸¶����΢΢���Ϳ�֪������װ֮���ͬС�ɡ�</t>";

			case "HappinessRandomAward_Cancel_Dark_1":%ctrl.tooltipWidth = 150;%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>һ��ת����</t><b/><t>���ʹ��һ��ת����</t>";
			case "HappinessRandomAward_Cancel_Dark_2":%ctrl.tooltipWidth = 150;%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ת����</t><b/><t>���ʹ�ö���ת����</t>";
			case "HappinessRandomAward_Cancel_Dark_3":%ctrl.tooltipWidth = 150;%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ת����</t><b/><t>���ʹ������ת����</t>";

			case "HappinessRandomAward_Cancel_Light_1":%ctrl.tooltipWidth = 150;%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ת����</t><b/><t>���ȡ��һ��ת����</t>";
			case "HappinessRandomAward_Cancel_Light_2":%ctrl.tooltipWidth = 150;%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ת����</t><b/><t>���ȡ������ת����</t>";
			case "HappinessRandomAward_Cancel_Light_2":%ctrl.tooltipWidth = 150;%ctrl.tooltip ="<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����ת����</t><b/><t>���ȡ������ת����</t>";

			case "HappinessRandomAwardGuiStart":%ctrl.tooltipWidth = 220;%ctrl.tooltip ="<t m='1' f='����' n='12'>�����ʼ��ȡ�����еı�����ָ����ɻ�ó齱����</t>";



	}
}

function EndTooltip(%ctrl)
{

}


//����������������������������ǿ����ء�������������������������������������
function StartTooltip_DTPlayerInfo_FashionLevel(%ctrl,%Level)
{
	//%Level,ǿ���ȼ�		%ItemNum,װ������
	//%Level = $FashionLevel;
	//%ItemNum = $CurColorFashionNum;
	//$g_MySelfEquipLevel  �鿴�Լ�����Ϣ
	//$g_TargetEquipLevel Ŀ����水ť
	if (%Level < 3)
		%Level = 2;
	//������ɫ
	%YanSe[1]	= "<t m='0' f='����' h='1' b='1' n='16' c='0xf3d300ff' o='0x010101ff'>";		//��������
	%YanSe[2]	= "<t m='1' f='����' n='14' c='0xffffffff'>";												//��������
	%YanSe[3]	= "<t m='1' f='����' n='14' c='0xe8a455ff'>";												//�������֣��ص㣩
	%YanSe[3]	= "<t m='1' f='����' n='14' c='0xf3d300ff'>";
	%YanSe[4]	= "<t m='1' f='����' b='1' v='1' h='1' n='12' c='0x3b88ccff'>";	//�ָ���

	%ZtiYanSe[3] =	"<t c='0x00ff4eff' o='0x010101ff'";%TitleName[3] = "m='0' f='����' h='1' b='1' n='16'>" @ "�� ��"; %EcName[3] = "m='1' f='����' n='14'>" @ "����ר����ɫ�⻷";
	%ZtiYanSe[4] =	"<t c='0x00ff4eff' o='0x010101ff'";%TitleName[4] = "m='0' f='����' h='1' b='1' n='16'>" @ "�� ��"; %EcName[4] = "m='1' f='����' n='14'>" @ "����ר����ɫ�⻷";
	%ZtiYanSe[5] =	"<t c='0x00ff4eff' o='0x010101ff'";%TitleName[5] = "m='0' f='����' h='1' b='1' n='16'>" @ "�� ��"; %EcName[5] = "m='1' f='����' n='14'>" @ "����ר����ɫ�⻷";

	%ZtiYanSe[6] =	"<t c='0x00baffff' o='0x2c2c2cff'";%TitleName[6] = "m='0' f='����' h='1' b='1' n='16'>" @ "�� ��"; %EcName[6] = "m='1' f='����' n='14'>" @ "����ר����ɫ�⻷";
	%ZtiYanSe[7] =	"<t c='0x00baffff' o='0x2c2c2cff'";%TitleName[7] = "m='0' f='����' h='1' b='1' n='16'>" @ "�� ��"; %EcName[7] = "m='1' f='����' n='14'>" @ "����ר����ɫ�⻷";

	%ZtiYanSe[8] =	"<t c='0xff65feff' o='0x2c2c2cff'";%TitleName[8] = "m='0' f='����' h='1' b='1' n='16'>" @ "�� ��"; %EcName[8] = "m='1' f='����' n='14'>" @ "����ר����ɫ�⻷";
	%ZtiYanSe[9] =	"<t c='0xff65feff' o='0x2c2c2cff'";%TitleName[9] = "m='0' f='����' h='1' b='1' n='16'>" @ "�� ��"; %EcName[9] = "m='1' f='����' n='14'>" @ "����ר�������⻷";

	%ZtiYanSe[10]=	"<t c='0xffa616ff' o='0x010101ff'";%TitleName[10]= "m='0' f='����' h='1' b='1' n='16'>" @ "ʮ ��"; %EcName[10]= "m='1' f='����' n='14'>" @ "����ר�������⻷";
	%ZtiYanSe[11]=	"<t c='0xffa616ff' o='0x010101ff'";%TitleName[11]= "m='0' f='����' h='1' b='1' n='16'>" @ "�� ��"; %EcName[11]= "m='1' f='����' n='14'>" @ "����ר�������⻷";

	%ZtiYanSe[12]=	"<t c='0xffa616ff' o='0x010101ff'";%TitleName[12]= "m='0' f='����' h='1' b='1' n='16'>" @ "�� ��"; %EcName[12]= "m='1' f='����' n='14'>" @ "����ר�������⻷";
	%ZtiYanSe[13]=	"<t c='0xff0000ff' o='0x000000ff'";%TitleName[13]= "m='0' f='����' h='1' b='1' n='16'>" @ "�� ��"; %EcName[13]= "m='1' f='����' n='14'>" @ "����ר�������⻷";
	%ZtiYanSe[14]=	"<t c='0xff0000ff' o='0x000000ff'";%TitleName[14]= "m='0' f='����' h='1' b='1' n='16'>" @ "�� ��"; %EcName[14]= "m='1' f='����' n='14'>" @ "����ר�������⻷";
	%ZtiYanSe[15]=	"<t c='0xff0000ff' o='0x000000ff'";%TitleName[15]= "m='0' f='����' h='1' b='1' n='16'>" @ "�� ��"; %EcName[15]= "m='1' f='����' n='14'>" @ "����ר�������⻷";

	%HuiSe = "<t f='����' m='1' n='14' c='0xb2b2b2ff' o='0x010101ff'>";				//��ɫ

	if (%Level >= 3)
		%Txt0 =
		%ZtiYanSe[%Level] @ %TitleName[%Level] @ "</t><b/>" @
		%YanSe[2] @ "  ����</t>" @ %YanSe[3] @ "9��ǿ��+" @ %Level @ "</t>" @ %YanSe[2] @ "��50��������ɫװ��</t><b/><b/>" @
		%YanSe[2] @ "  ���</t>" @ %ZtiYanSe[%Level] @ %EcName[%Level] @ "</t><b/>";
	else
		%Txt0 ="<t m='0' f='����' h='1' b='1' v='1' n='16' c='0xb2b2b2ff' o='0x010101ff'>δ����</t>";

	if (%Level < 15)
		%Txt1 =
		%YanSe[4] @ "---------- ��һ�� ----------</t><b/>" @
		"<t c='0xb2b2b2ff' o='0x010101ff'" @ %TitleName[%Level + 1] @ "</t><b/>" @
		%HuiSe @ "  ����9��ǿ��+" @ %Level + 1 @ "��50��������ɫװ��</t><b/><b/>" @
		%HuiSe @ "  ���</t>" @ "<t c='0xb2b2b2ff' o='0x010101ff'" @ %EcName[%Level + 1] @ "</t><b/>";

	%ctrl.tooltipWidth = 260;

	%Txt = %Txt0 @ %Txt1;

	%ctrl.tooltip = %Txt;
}


//��������������������������ɫʯ�ϳ���ء�����������������������������������
function StartTooltip_ColorfulGem_Help0(%ctrl)
{
	//������ɫ
	%YanSe[1]	= "<t m='0' f='����' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//��������
	%YanSe[2,1]	= "<t m='1' f='����' n='12' c='0xffffffff'>";												//��������
	%YanSe[2,2]	= "<t m='1' f='����' n='12' c='0xe8a455ff'>";												//�������֣��ص㣩

	%Txt = %YanSe[1] @ "��ɫ����ϳ�˵����</t><b/>" @
		%YanSe[2,1] @ "1.��ɫ����ӵ���������ԣ���������ֵ��ͬ�ȼ�������ֵ��ͬ</t><b/>" @
		%YanSe[2,1] @ "2.�ϳ�ֻ�ɷ���ͬ���𡢲�ͬ���Ե�����</t><b/>" @
		%YanSe[2,1] @ "3.����ϵ�����鲻�ɲμӺϳ�</t><b/>" @
		%YanSe[2,1] @ "4.���ɵ������������ȡ����ϳɵ�7�������е�3��</t>";

	%ctrl.tooltipWidth = 400;
	%ctrl.tooltip = %Txt;
}

//��������������������������ɫʯ�ֽ���ء�����������������������������������
function StartTooltip_ColorfulGem_Help28(%ctrl)
{
	//������ɫ
	%YanSe[1]	= "<t m='0' f='����' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//��������
	%YanSe[2,1]	= "<t m='1' f='����' n='12' c='0xffffffff'>";												//��������
	%YanSe[2,2]	= "<t m='1' f='����' n='12' c='0xe8a455ff'>";												//�������֣��ص㣩

	%Txt = %YanSe[1] @ "��ɫ����ֽ�˵����</t><b/>" @
		%YanSe[2,1] @ "1.��ɫ����ɷֽ���������Զ�Ӧ�ĵ�ɫ����</t><b/>" @
		%YanSe[2,1] @ "2.�ֽ��õ��������</t>";

	%ctrl.tooltipWidth = 300;
	%ctrl.tooltip = %Txt;
}

//������������������������������Ѩ��ء�����������������������������������
function StartTooltip_JingMai_EXP_Help(%ctrl)
{
	//������ɫ
	%YanSe[1]	= "<t m='0' f='����' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//��������
	%YanSe[2,1]	= "<t m='1' f='����' n='12' c='0xffffffff'>";												//��������
	%YanSe[2,2]	= "<t m='1' f='����' n='12' c='0xe8a455ff'>";												//�������֣��ص㣩

	%Txt = %YanSe[1] @ "Ѩ��˵����</t><b/>" @
		%YanSe[2,1] @ "1.��ͬ��Ѩ�����Ĳ�ͬ��ϴ�赤�ɽ��г�Ѩ����Ѩ��Ϻ�ɼ����Ѩ����</t><b/>" @
		%YanSe[2,1] @ "2.��Ѩ�������ɽ��п��ף����׿�������һ����ɫ�Ŀף��ܹ���������ɫ����ɫ����ɫ����ɫ����ɫ</t><b/>" @
		%YanSe[2,1] @ "3.�׵���ɫ�ɾ�������׿���Ƕ������ɫ������</t><b/>" @
		%YanSe[2,1] @ "4.��ɫ����Ϊ��󣬿���Ƕ�κ���ɫ���飬��������Ƕ��Ϊ������ɫ����</t><b/>" @
		%YanSe[2,2] @ "����ɫ�������ǿ��ϵͳ�е���������ڽ��кϳɣ�</t><b/>" @
		%YanSe[2,1] @ "5.����������ɵĿ׵���ɫ�����⣬�ɶԿ��׺��Ѩ������ɢѨ��ɢѨ���ٿ��׿��������ɿ׵���ɫ</t><b/>" @
		%YanSe[2,2] @ "��ɢѨ����Ҫ���³�Ѩ�����ٿ��ף������������</t><b/>" @
		%YanSe[2,1] @ "6.���¿��׿�����߻����ɫ�׵ĸ���</t>";

	%ctrl.tooltipWidth = 680;
	%ctrl.tooltip = %Txt;
}

function StartTooltip_JinMai_Round_EXP(%ctrl)
{
	//������ɫ
	%YanSe[1]	= "<t m='0' f='����' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//��������
	%YanSe[2,1]	= "<t m='1' f='����' n='12' c='0xffffffff'>";												//��������
	%YanSe[2,2]	= "<t m='1' f='����' n='12' c='0xe8a455ff'>";												//�������֣��ص㣩

	%Txt = %YanSe[2,1] @ "��ǰѨ������</t>";

	%ctrl.tooltipWidth = 120;
	%ctrl.tooltip = %Txt;
}

//����������������������������������ء�����������������������������������
function StartTooltip_JingMai_EXP_Help_1(%ctrl)
{
	//������ɫ
	%YanSe[1]	= "<t m='0' f='����' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//��������
	%YanSe[2,1]	= "<t m='1' f='����' n='12' c='0xffffffff'>";												//��������
	%YanSe[2,2]	= "<t m='1' f='����' n='12' c='0xe8a455ff'>";												//�������֣��ص㣩

	%Txt = %YanSe[1] @ "��������˵����</t><b/>" @
		%YanSe[2,1] @ "1.���ڵ�����Ѩ���������������֮��ľ����Ϳɽ��д����������谴�վ�����˳����С�</t><b/>" @
		%YanSe[2,1] @ "2.ֱ���ڱ�����ʹ�����嵤�Ϳ�ʹ��������ľ�����þ���</t><b/>" @
		%YanSe[2,1] @ "3.���������õ�һ�������ɻ�þ�������������������������������������������</t><b/>" @
		%YanSe[2,1] @ "4.ÿ��������ÿһ�����׶ζ����������ܹ���ѡ��ѡ������һ���������������޷���������һ�����ܣ�ѡ��ǰ��������ǡ�</t><b/>" @
		%YanSe[2,1] @ "5.ѡ��ľ������ܼ�����ſ�������һ�׶εľ�������</t>";

	%ctrl.tooltipWidth = 630;
	%ctrl.tooltip = %Txt;
}

//δ��Ѩ��ʾ˵��
function StartTooltip_JinMai_1_Unable_XueWei_1(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function StartTooltip_JinMai_1_Unable_XueWei_2(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function StartTooltip_JinMai_1_Unable_XueWei_3(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function StartTooltip_JinMai_1_Unable_XueWei_4(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function StartTooltip_JinMai_1_Unable_XueWei_5(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function StartTooltip_JinMai_2_Unable_XueWei_1(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function StartTooltip_JinMai_2_Unable_XueWei_2(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function StartTooltip_JinMai_2_Unable_XueWei_3(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function StartTooltip_JinMai_2_Unable_XueWei_4(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function StartTooltip_JinMai_2_Unable_XueWei_5(%ctrl){ JinMai_Unable_XueWei(%ctrl); }
function JinMai_Unable_XueWei(%ctrl)
{
	//������ɫ
	%YanSe[1]	= "<t m='0' f='����' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//��������
	%YanSe[2,1]	= "<t m='1' f='����' n='12' c='0xffffffff'>";												//��������
	%YanSe[2,2]	= "<t m='1' f='����' n='12' c='0xe8a455ff'>";												//�������֣��ص㣩

	%Txt = %YanSe[1] @ "Ѩ��˵����</t><b/>" @
		%YanSe[2,1] @ "1.���Ѩ����Ѩ���Ⱥ�ɼ���Ѩ����</t><b/>" @
		%YanSe[2,1] @ "2.Ѩ��������и������ԡ�</t><b/>" @
		%YanSe[2,1] @ "3.Ѩ����������ΪѨ�����ף�������Ƕ���顣</t>";

	%ctrl.tooltipWidth = 320;
	%ctrl.tooltip = %Txt;
}

//���׳ɹ�����ʾ˵��
function StartTooltip_JingMai_1_Gem_1(%ctrl){ JinMai_Gem_KaiKong(0,%ctrl); }
function StartTooltip_JingMai_1_Gem_2(%ctrl){ JinMai_Gem_KaiKong(1,%ctrl); }
function StartTooltip_JingMai_1_Gem_3(%ctrl){ JinMai_Gem_KaiKong(2,%ctrl); }
function StartTooltip_JingMai_1_Gem_4(%ctrl){ JinMai_Gem_KaiKong(3,%ctrl); }
function StartTooltip_JingMai_1_Gem_5(%ctrl){ JinMai_Gem_KaiKong(4,%ctrl); }
function StartTooltip_JingMai_2_Gem_1(%ctrl){ JinMai_Gem_KaiKong(5,%ctrl); }
function StartTooltip_JingMai_2_Gem_2(%ctrl){ JinMai_Gem_KaiKong(6,%ctrl); }
function StartTooltip_JingMai_2_Gem_3(%ctrl){ JinMai_Gem_KaiKong(7,%ctrl); }
function StartTooltip_JingMai_2_Gem_4(%ctrl){ JinMai_Gem_KaiKong(8,%ctrl); }
function StartTooltip_JingMai_2_Gem_5(%ctrl){ JinMai_Gem_KaiKong(9,%ctrl); }
function JinMai_Gem_KaiKong(%Type,%ctrl)
{
	if (GetJinMaiHoleGemState(%Type,0) == 0)
	{
		//������ɫ
		%YanSe[1]	= "<t m='0' f='����' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//��������
		%YanSe[2,1]	= "<t m='1' f='����' n='12' c='0xffffffff'>";												//��������
		%YanSe[2,2]	= "<t m='1' f='����' n='12' c='0xe8a455ff'>";												//�������֣��ص㣩

		%Txt = %YanSe[1] @ "����˵����</t><b/>" @
			%YanSe[2,1] @ "1.����������ɫ����ɫ����ɫ����ɫ����ɫ��</t><b/>" @
			%YanSe[2,1] @ "2.��ɫ�׿���Ƕ�������飬������ɫ���飨����ϵ�������޷���Ƕ����</t><b/>" @
			%YanSe[2,1] @ "3.�Կ׵���ɫ���������ɢѨ�����³�Ѩ���������µĿס�</t><b/>" @
			%YanSe[2,1] @ "4.���¿��׻���߻����ɫ�׵ĸ��ʡ�</t>";

		%ctrl.tooltipWidth = 350;
		%ctrl.tooltip = %Txt;
	}
	else
	{
		%ctrl.tooltip = "";
	}
}

//��ť����˵��
function StartTooltip_JinMai_1_ActiveBTN_1(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function StartTooltip_JinMai_1_ActiveBTN_2(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function StartTooltip_JinMai_1_ActiveBTN_3(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function StartTooltip_JinMai_1_ActiveBTN_4(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function StartTooltip_JinMai_1_ActiveBTN_5(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function StartTooltip_JinMai_2_ActiveBTN_1(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function StartTooltip_JinMai_2_ActiveBTN_2(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function StartTooltip_JinMai_2_ActiveBTN_3(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function StartTooltip_JinMai_2_ActiveBTN_4(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function StartTooltip_JinMai_2_ActiveBTN_5(%ctrl){ JinMai_ActiveBTN_ChongXue(%ctrl); }
function JinMai_ActiveBTN_ChongXue(%ctrl)
{
	//������ɫ
	%YanSe[1]	= "<t m='0' f='����' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//��������
	%YanSe[2,1]	= "<t m='1' f='����' n='12' c='0xffffffff'>";												//��������
	%YanSe[2,2]	= "<t m='1' f='����' n='12' c='0xe8a455ff'>";												//�������֣��ص㣩

	%Txt = %YanSe[1] @ "��ť��״̬˵����</t><b/>" @
		%YanSe[2,1] @ "1.��Ѩ��������������Ӧ���߽��г�Ѩ����Ѩ��������Խ�����</t><b/>" @
		%YanSe[2,1] @ "2.���ף�Ѩ���������Խ��п��ײ��������׺��������һ����ɫ�Ŀף�������Ƕ��Ӧ��ɫ�����顣</t><b/>" @
		%YanSe[2,1] @ "3.ɢѨ���Կ׵���ɫ������ɽ���ɢѨ��ɢѨ����ٴ����¿������ɿ׵���ɫ��ûɢѨһ�ζ������ӻ����ɫ�׵ĸ��ʡ�</t><b/>" @
		%YanSe[2,1] @ "4.��Ƕ���׵���ɫ��������Ƕ������ɫ�����顣��ɫ�׿���Ƕ�κ���ɫ���顣������ϵ�������޷���Ƕ����</t><b/>" @
		%YanSe[2,1] @ "5.ժȡ����Ƕ����Ŀ���Ҫժȡ�������ܽ���ɢѨ������</t>";

	%ctrl.tooltipWidth = 400;
	%ctrl.tooltip = %Txt;
}

function StartTooltip_JingMaiWndGui_Score_text(%ctrl)
{
	//������ɫ
	%YanSe[1]	= "<t m='0' f='����' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//��������
	%YanSe[2,1]	= "<t m='1' f='����' n='12' c='0xffffffff'>";												//��������
	%YanSe[2,2]	= "<t m='1' f='����' n='12' c='0xe8a455ff'>";												//�������֣��ص㣩

	%Txt = %YanSe[1] @ "��������˵����</t><b/>" @
		%YanSe[2,1] @ "�����Ѩ��Խ������Խ�ߡ���Ƕ������ȼ�Խ������Խ�ߡ�������������Խ������Խ�ߡ�</t>";

	%ctrl.tooltipWidth = 200;
	%ctrl.tooltip = %Txt;
}

//ʱװ�ȸ�
function StartTooltip_DTPlayerInfo_SZZLtexthottip(%ctrl)
{
	//������ɫ
	%YanSe[1]	= "<t m='0' f='����' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//��������
	%YanSe[2,1]	= "<t m='1' f='����' n='12' c='0xffffffff'>";												//��������
	%YanSe[2,2]	= "<t m='1' f='����' n='12' c='0xe8a455ff'>";												//�������֣��ص㣩

	%Txt = %YanSe[1] @ "ʱװ����˵����</t><b/>" @
		%YanSe[2,1] @ "1.Ʒ��Խ�ߵ�ʱװ����Խ�ߣ���ͬƷ�ʵ�ʱװҲ�в�ͬ��</t><b/>" @
		%YanSe[2,1] @ "2.��ɫ>��ɫ>��ɫ>��ɫ��</t>";

	%ctrl.tooltipWidth = 220;
	%ctrl.tooltip = %Txt;
}


//���������������������������������ء�����������������������������������
//�ٻ�����
function StartTooltip_TeambeckonBtn(%ctrl)
{
	//������ɫ
	%YanSe[1]	= "<t m='0' f='����' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//��������
	%YanSe[2,1]	= "<t m='1' f='����' n='12' c='0xffffffff'>";												//��������
	%YanSe[2,2]	= "<t m='1' f='����' n='12' c='0xe8a455ff'>";												//�������֣��ص㣩

	%Txt = %YanSe[1] @ "�ٻ�����˵����</t><b/>" @
		%YanSe[2,1] @ "�ɽ������ٻ����ϵ��ӳ���ߣ���Ҫ����һ���ٻ���������Ԫ��������̵깺��</t>";

	%ctrl.tooltipWidth = 220;
	%ctrl.tooltip = %Txt;
}

//�������
function StartTooltip_KickOutTeamBtn(%ctrl)
{
	//������ɫ
	%YanSe[1]	= "<t m='0' f='����' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//��������
	%YanSe[2,1]	= "<t m='1' f='����' n='12' c='0xffffffff'>";												//��������
	%YanSe[2,2]	= "<t m='1' f='����' n='12' c='0xe8a455ff'>";												//�������֣��ص㣩

	%Txt = %YanSe[1] @ "�������˵����</t><b/>" @
		%YanSe[2,1] @ "��ѡ�еĶ�Ա�������</t>";

	%ctrl.tooltipWidth = 162;
	%ctrl.tooltip = %Txt;
}

//��Ϊ����
function StartTooltip_jiaweixianyou(%ctrl)
{
	//������ɫ
	%YanSe[1]	= "<t m='0' f='����' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//��������
	%YanSe[2,1]	= "<t m='1' f='����' n='12' c='0xffffffff'>";												//��������
	%YanSe[2,2]	= "<t m='1' f='����' n='12' c='0xe8a455ff'>";												//�������֣��ص㣩

	%Txt = %YanSe[1] @ "��Ϊ����˵����</t><b/>" @
		%YanSe[2,1] @ "��ѡ�еĶ�Ա��Ϊ����</t>";

	%ctrl.tooltipWidth = 162;
	%ctrl.tooltip = %Txt;
}

//�������
function StartTooltip_TeamFollowBtn(%ctrl)
{
	//������ɫ
	%YanSe[1]	= "<t m='0' f='����' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//��������
	%YanSe[2,1]	= "<t m='1' f='����' n='12' c='0xffffffff'>";												//��������
	%YanSe[2,2]	= "<t m='1' f='����' n='12' c='0xe8a455ff'>";												//�������֣��ص㣩

	%Txt = %YanSe[1] @ "�������˵����</t><b/>" @
		%YanSe[2,1] @ "���Ա�����������</t>";

	%ctrl.tooltipWidth = 150;
	%ctrl.tooltip = %Txt;
}

//�������
function StartTooltip_TeamInviteBtn(%ctrl)
{
	//������ɫ
	%YanSe[1]	= "<t m='0' f='����' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//��������
	%YanSe[2,1]	= "<t m='1' f='����' n='12' c='0xffffffff'>";												//��������
	%YanSe[2,2]	= "<t m='1' f='����' n='12' c='0xe8a455ff'>";												//�������֣��ص㣩

	%Txt = %YanSe[1] @ "�������˵����</t><b/>" @
		%YanSe[2,1] @ "����ҷ����������</t>";

	%ctrl.tooltipWidth = 150;
	%ctrl.tooltip = %Txt;
}

//�����ӳ�
function StartTooltip_DisplaceTeamHeaderBtn(%ctrl)
{
	//������ɫ
	%YanSe[1]	= "<t m='0' f='����' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//��������
	%YanSe[2,1]	= "<t m='1' f='����' n='12' c='0xffffffff'>";												//��������
	%YanSe[2,2]	= "<t m='1' f='����' n='12' c='0xe8a455ff'>";												//�������֣��ص㣩

	%Txt = %YanSe[1] @ "�����ӳ�˵����</t><b/>" @
		%YanSe[2,1] @ "�ɽ�ѡ�еĶ�Ա����Ϊ�ӳ���</t>";

	%ctrl.tooltipWidth = 170;
	%ctrl.tooltip = %Txt;
}

//����ӳ�
function StartTooltip_FollowLeaderBtn(%ctrl)
{
	//������ɫ
	%YanSe[1]	= "<t m='0' f='����' b='1' n='14' c='0xf3d300ff' o='0x010101ff'>";		//��������
	%YanSe[2,1]	= "<t m='1' f='����' n='12' c='0xffffffff'>";												//��������
	%YanSe[2,2]	= "<t m='1' f='����' n='12' c='0xe8a455ff'>";												//�������֣��ص㣩

	%Txt = %YanSe[1] @ "����˵����</t><b/>" @
		%YanSe[2,1] @ "������ӳ�</t>";

	%ctrl.tooltipWidth = 90;
	%ctrl.tooltip = %Txt;
}

