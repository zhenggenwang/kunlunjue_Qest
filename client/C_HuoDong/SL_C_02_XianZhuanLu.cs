//�������������ȫϵͳ�������������յ�����˿������á���������������
//�������������ȫϵͳ������������������������������������������
//�������������ȫϵͳ������������ȫ�ֱ�����š���������������������
//�������������ȫϵͳ��������������ı���ʾ����������������������

//�������ͺ�״̬��ȡ�����:function GetActivityNumByType( %type, %litState )  %type:1-3 %litState:0-1
//���ø������Ϣ��ShowBtnActivityMessage( %num, %type, %litState );
//��ȼ���"active_lv_text_" @%i
//����ƣ�"active_name_text_" @%i
//��ǰ�������"active_curnum_text_" @%i
//�����ʱ�䣺"active_time_text_" @%i
//�������ͣ�"active_team_text_" @%i
//��������ͼƬ��"active_type_bmp_" @ %i  
//�����ť�Ҳ���ϸ��Ϣ��ʾ��function SetDetailsContent( %type, %i )//������̫ȷ��
//�Ŀ��text�ؼ���Activity_Purpose_text
//�����text�ؼ���Activity_Details_text
//
//105100261	��������
//105100262	��������
//105100263	��������
//105100264	�������
//105100265	�������
//105100266	����Ԫ��
//105100267	����Ԫ��
//105100268	������
//105100269	�̳ǵ���
//105100270	�����䷽
//105100271	�������
//105100272	��ɫװ��( 40-49�� )
//105100273	��ɫװ��( 40-49�� )
//105100274	��ɫװ��( 50-59�� )
//105100275	��ɫװ��( 50-59�� )
//105100276	��ɫװ��( 60-69�� )
//105100277	��ɫװ��( 60-69�� )
//105100278	��ɫװ��( 70-79�� )
//105100279	��ɫװ��( 70-79�� )
//105100280	��ɫװ��( 80-89�� )
//105100281	��ɫװ��( 80-89�� )
//105100282	��ɫװ��( 90-99�� )
//105100283	��ɫװ��( 90-99�� )
//105100284	��ɫװ��( 100-109�� )
//105100285	��ɫװ��( 100-109�� )
//105100286	��ɫװ��( 110-119�� )
//105100287	��ɫװ��( 110-119�� )
//105100288	��ɫװ��( 120-129�� )
//105100289	��ɫװ��( 120-129�� )
//105100290	��ɫװ��( 130-139�� )
//105100291	��ɫװ��( 130-139�� )
//105100292	��ɫװ��( 140-150�� )
//105100293	��ɫװ��( 140-150�� )
//105100294	��ɫװ��
//105100295	�������
//105100296	�������
//105100297	��ͨ����
//105100298	������
//105100299	ϡ�е���


//�������������ȫϵͳ������������ȫ�ֱ�����š���������������������
function GetActivitytext()
{

	//-------------------------------ȺӢ���----------------------
	$SL_HuoDong_Actmsg[1] = "20 2";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[1] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[1],0);
	$active_name_text_[1] = "ȺӢ���";
	$active_curnum_text_[1]= GetSrc(GetPlayer(),3) * 1 @ "/1";
	$active_time_text_[1] = "ʱ�䣺19:00--20:00";
	$active_team_text_[1]= "����������";
	$active_type_bmp_[1] ="gameres/gui/images/activetype_2.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[1] = "gameres/gui/images/ActivityTypeBmp_001.png";//��ͼ 	1����	2�ع�	3����	4����
	$Activity_Purpose_text[1] = "����Ϧ������ʱ���������������ٻ����ܵ�ͼ�ڣ�����ʿ����ͼ�ڶ�������������ջ����������ڣ���Ϊ����������";

	getplayer().ClearMissionItem(1);
	getplayer().AddItemToMission(1,1,105100262,1);
	$Activity_Details_text[1] = "<t>Ѱ�Ұ����ٻ�����ͼ�ڣ���ȡһ��ůů��ͼ��֮���ɡ���Ȼ����Ҳ���Ը���һ��СС�Ĵ��ۣ�ȥ�������ɻ��ͼ�ڡ�</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	��ڣ�</t>" @ $Get_Dialog_GeShi[31426] @ "	����	</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\""@ "FindPath( 810010107 );" @"\",\"" @ $Get_Dialog_GeShi[31214] @ "���˹㳡" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	19:00-20:00</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	ÿ��1��</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(1) @ "<b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "<t>ͼ�ڵȼ�Խ�ߣ�����Խ���</t><b/><b/>";
	$Active_PathToDes[1] = "CloseActivityWnd();findpath(810010107);";

	//------------------------------------------------------------

	//-------------------------------ʱ���Ѻ�----------------------
	$SL_HuoDong_Actmsg[2] = "30 2";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[2] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[2],0);
	$active_name_text_[2] = "ʱ���Ѻ�";
	$active_curnum_text_[2]= GetAct(GetPlayer(),3029,0) * 1 @ "/1";
	$active_time_text_[2] = "ʱ�䣺19:00--22:00";
	$active_team_text_[2]= "���������";
	$active_type_bmp_[2] ="gameres/gui/images/activetype_2.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[2] = "gameres/gui/images/ActivityTypeBmp_002.png";//��ͼ 	1����	2�ع�	3����	4����
	$Activity_Purpose_text[2] = "ħ����ħ������������ӡ�����˼�磬�������ź�����������ǰ����ɱ��ħ���ӹ�������ӡ��";
	getplayer().ClearMissionItem(2);
	getplayer().AddItemToMission(2,1,105100263,1);
	$Activity_Details_text[2] = "<t>����ʱ���Ѻ��ڵ���ʿ������һ������ı�����֮���ǣ�����ǻ�ȼ������Զ����ô����Ľ���</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	��ڣ�</t>" @ $Get_Dialog_GeShi[31426] @ "	����	</t>" @ Getfindpath(410010209,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	19:00--22:00</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	ÿ��1��</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	����3�����϶���</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(2) @ "<b/>";
	$Active_PathToDes[2] = "CloseActivityWnd();findpath(410010209);";
	//------------------------------------------------------------

	//-------------------------------��ħԨ----------------------
	$SL_HuoDong_Actmsg[3] = "45 1";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[3] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[3],0);
	$active_name_text_[3] = "��ħԨ";
	$active_curnum_text_[3]= GetAct(GetPlayer(),3030,0) + GetAct(GetPlayer(),3030,1) @ "/3";
	$active_time_text_[3] = "ʱ�䣺����";
	$active_team_text_[3]= "���������";
	$active_type_bmp_[3] ="gameres/gui/images/activetype_5.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[3] = "gameres/gui/images/ActivityTypeBmp_003.png";//��ͼ 	1����	2�ع�	3����	4����
	$Activity_Purpose_text[3] = "Ѫħ�ټ�ħ�����˾ù��������أ�һ��ħͷ�����������Դ�����������ħԨ��";

	getplayer().ClearMissionItem(3);
	getplayer().AddItemToMission(3,1,105100262,1);
	getplayer().AddItemToMission(3,1,105105401,1);
	getplayer().AddItemToMission(3,1,105105403,1);
	getplayer().AddItemToMission(3,1,105105405,1);
	getplayer().AddItemToMission(3,1,105105407,1);
	getplayer().AddItemToMission(3,1,105105451,1);
	getplayer().AddItemToMission(3,1,105105453,1);
	getplayer().AddItemToMission(3,1,105105455,1);
	getplayer().AddItemToMission(3,1,105105457,1);
	$Activity_Details_text[3] = "<t>��������Ϊ�������µ���ʵ�����ټ���Ӣ����ǰ����ħԨ��ħ����ͽ�������������Լ���Ϊ��</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	��ڣ�</t>" @ $Get_Dialog_GeShi[31426] @ "	����	</t>" @ Getfindpath(410010204,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @
		$Get_Dialog_GeShi[31426] @ "	1.ÿ����ѽ���1��</t><b/>" @
		$Get_Dialog_GeShi[31426] @ "								2.ʹ��</t>" @ "<l i='105109201 ' t='itemid'/>" @ $Get_Dialog_GeShi[31426] @ "���븱����ÿ�����2��</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	����6�����</t><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(3) @ "<b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "<t>��ħԨ��ս�������޷���;��ͣŶ��</t><b/>";
	$Active_PathToDes[3] = "CloseActivityWnd();findpath(410010204);";
	//------------------------------------------------------------

	//-------------------------------�þ�����----------------------
	$SL_HuoDong_Actmsg[4] = "40 2";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[4] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[4],0);
	$active_name_text_[4] = "�þ�����";
	$active_curnum_text_[4]= GetSrc(GetPlayer(),4) * 1  @ "/1";
	$active_time_text_[4] = "ʱ�䣺��һ �� �� 20:00-20:05";
	$active_team_text_[4]= "����������";
	$active_type_bmp_[4] ="gameres/gui/images/activetype_5.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[4] = "gameres/gui/images/ActivityTypeBmp_004.png";//��ͼ 	1����	2�ع�	3����	4����
	$Activity_Purpose_text[4] = "�޾��������ɾ��У���һƬ�п����ʿ�ƶ񳡣�Ψ����ǿ�߲��ܵ��ٶ��塣�����㹻��������ʿ�����ɽ����߲㣬��ɱ������Ͳ㡣";
	getplayer().ClearMissionItem(4);
	getplayer().AddItemToMission(4,1,105100262,1);
	getplayer().AddItemToMission(4,1,105105303,1);
	getplayer().AddItemToMission(4,1,105105304,1);
	getplayer().AddItemToMission(4,1,105105713,1);
	getplayer().AddItemToMission(4,1,105090412,1);
	getplayer().AddItemToMission(4,1,105090413,1);
	getplayer().AddItemToMission(4,1,105100103,1);
	getplayer().AddItemToMission(4,1,105100103,1);
	getplayer().AddItemToMission(4,1,105090414,1);

	$Activity_Details_text[4] = "<t>��������Խ�ߣ�����Խ�ḻ����߲��������������ı��أ��������л�������ϧ���ߡ�</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	��ڣ�</t>" @ $Get_Dialog_GeShi[31426] @ "	����	</t>" @ Getfindpath(410010211,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	�� һ �� �� 20:00-20:05</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @	$Get_Dialog_GeShi[31426] @ "	ÿ��1��</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(4) @ "<b/>";
	$Active_PathToDes[4] = "CloseActivityWnd();findpath(410010211);";
	//------------------------------------------------------------

	//-------------------------------��������----------------------
	$SL_HuoDong_Actmsg[5] = "30 3";//�ɼ��ȼ� �����(1 2 3) ActivityTypeBmp_3.png Ұ��BOSS  ActivityTypeBmp_4.png �ع�����
	$SL_HuoDong_Boss[1] = "��ҫʹ�� 30 ActivityTypeBmp_5_001.png 810010100 6 440000015 activetype_4.png";//���� �ȼ� ��ͼ ��ͼ ˢ��CD ���� ��ʾ����
	$SL_HuoDong_Boss[2] = "����ʹ�� 40 ActivityTypeBmp_5_002.png 811190100 6 440000016 activetype_4.png";//���� �ȼ� ��ͼ ��ͼ ˢ��CD ���� ��ʾ����
	$SL_HuoDong_Boss[3] = "������� 50 ActivityTypeBmp_5_003.png 811010100 6 440000001 activetype_4.png";//���� �ȼ� ��ͼ ��ͼ ˢ��CD ���� ��ʾ����
	$SL_HuoDong_Boss[4] = "�ĳǹ��� 55 ActivityTypeBmp_5_004.png 811280200 8 440000008 activetype_3.png";//���� �ȼ� ��ͼ ��ͼ ˢ��CD ���� ��ʾ����
	$SL_HuoDong_Boss[5] = "ѩ��ħ�� 60 ActivityTypeBmp_5_005.png 811020100 6 440000002 activetype_4.png";//���� �ȼ� ��ͼ ��ͼ ˢ��CD ���� ��ʾ����
	$SL_HuoDong_Boss[6] = "�ѻ�̫�� 65 ActivityTypeBmp_5_006.png 811290400 8 440000009 activetype_3.png";//���� �ȼ� ��ͼ ��ͼ ˢ��CD ���� ��ʾ����
	$SL_HuoDong_Boss[7] = "����ҹ�� 70 ActivityTypeBmp_5_007.png 811030100 6 440000003 activetype_4.png";//���� �ȼ� ��ͼ ��ͼ ˢ��CD ���� ��ʾ����
	$SL_HuoDong_Boss[8] = "�������� 75 ActivityTypeBmp_5_008.png 811300400 8 440000010 activetype_3.png";//���� �ȼ� ��ͼ ��ͼ ˢ��CD ���� ��ʾ����
	$SL_HuoDong_Boss[9] = "1104�Ķ� 80 ActivityTypeBmp_5_009.png 811040100 6 440000004 activetype_4.png";//���� �ȼ� ��ͼ ��ͼ ˢ��CD ���� ��ʾ����

	$Activity_Purpose_text[5, 1] = "��ҫʹ��Я����һöѫ�£��������Ǵ������ɵĹؼ�֮�ֻ��սʤ�����л����ô��";
	$Activity_Purpose_text[5, 2] = "����ʹ��Я����һö����ӡ�£�ӵ�д���ſ��Բ�������ħ����֮����";
	$Activity_Purpose_text[5, 3] = "�ഫ��ǧ��ǰ�������������ɹȵ�һֻ��ͨ���꣬һ��������Ե���γ�����";
	$Activity_Purpose_text[5, 4] = "�ݴ�˵�����������ɿ�����ȥ������Թ��������Թ����ɢ�������������ó��ѡ�";
	$Activity_Purpose_text[5, 5] = "��ǧ��ǰ�������ڲ�ɽѩ��֮�µĹ���ħ�壬ѩɽ��̮���Ʒ������";
	$Activity_Purpose_text[5, 6] = "�����������������ߣ������ĺ��İ���ǿ�ߡ�";
	$Activity_Purpose_text[5, 7] = "ԭ�����Է��е�ҹ�棬����ս����ʧȥ��������ױ����޶���";
	$Activity_Purpose_text[5, 8] = "����ں��׵İ������׺����б�";
	$Activity_Purpose_text[5, 9] = "�Ϲ���ħ��ս��ս���������ߵĹ�ħ�����������ɡ��������־�������������ڴˣ��޷���Ϣ��";

	$SL_HuoDong_Bossitemlist[1] = "105109052";
	$SL_HuoDong_Bossitemlist[2] = "105109053";
	$SL_HuoDong_Bossitemlist[3] = "105090501 105090502 105090601 105090602 105090511 105090512 105090513 105090611 105090612 105090613 116010003 105105302 106071032";
	$SL_HuoDong_Bossitemlist[4] =	"109011102 109012102 109013102 109014102 101014005 101024005 101034005 101044005 105105302 116010003 105090511 105090512 105090513 105090611 105090612 105090613 ";
	$SL_HuoDong_Bossitemlist[5] =	"105090511 105090512 105090611 105090612 105105302 105105303 116010003 106071033";
	$SL_HuoDong_Bossitemlist[6] = "109011103 109012103 109013103 109014103 101014006 101024006 101034006 101044006 105105302 105105303 116010003 105090511 105090512 105090513 105090611 105090612 105090613 ";
	$SL_HuoDong_Bossitemlist[7] =	"105090511 105090512 105090611 105090612 105090521 105090522 105090621 105090622 105105302 105105303 116010003 106071034";
	$SL_HuoDong_Bossitemlist[8] = "109011104 109012104 109013104 109014104 101014007 101024007 101034007 101044007 105105302 105105303 116010003 105090521 105090522 105090523 105090621 105090622 105090623 ";
	$SL_HuoDong_Bossitemlist[9] = "109011104 109012104 109013104 109014104 101014007 101024007 101034007 101044007 105105302 105105303 116010003 105090521 105090522 105090523 105090621 105090622 105090623 ";
	for (%i=1; %i<=99; %i++)
	{
		if ($SL_HuoDong_Boss[%i] $= "")
			break;
		$active_lv_text_[5,%i] = "�ȼ�:" @ GetWord($SL_HuoDong_Boss[%i],1);
		$active_name_text_[5,%i] = GetWord($SL_HuoDong_Boss[%i],0);
		$active_curnum_text_[5,%i]= "";
		$active_time_text_[5,%i] = "ʱ�䣺" @ getword($SL_HuoDong_Boss[%i],4) @ "Сʱˢ��һ��";
		$active_team_text_[5,%i]= "���������";
		$active_type_bmp_[5,%i] ="gameres/gui/images/" @ GetWord($SL_HuoDong_Boss[%i],6);// 1  ���߻ 2  ���� 3�ع����� 4��������
		$CreateActivityBmp_[5,%i] = "gameres/gui/images/" @  GetWord($SL_HuoDong_Boss[%i],2);//��ͼ 1����	2�ع�	3����	4����

		getplayer().ClearMissionItem(500 + %i);
		for (%j =0; %j<=99; %j++)
		{
			%itemID = getword($SL_HuoDong_Bossitemlist[%i],%j);
			if (%itemID > 0)
				getplayer().AddItemToMission(500 + %i,1,%itemID,1);
			else
				break;
		}
		//%PathID = "<l i='" @ "8" @ getword( $SL_HuoDong_Boss[ %i ], 3 ) @ "0100 " @ getword( $SL_HuoDong_Boss[ %i ], 5 ) @ " " @ getword( $SL_HuoDong_Boss[ %i ], 6 ) @ " " @ getword( $SL_HuoDong_Boss[ %i ], 7 ) @ "' t='path'/>";

		$Activity_Details_text[5,%i] =
			$Get_Dialog_GeShi[31428] @ "	ˢ�µص㣺</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(" @ GetWord($SL_HuoDong_Boss[%i],5) @ ");\",\"" @ $Get_Dialog_GeShi[31414] @ GetTriggerData(GetWord($SL_HuoDong_Boss[%i],3),3) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>"  @
			$Get_Dialog_GeShi[31428] @ "	ˢ��ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	" @ getword($SL_HuoDong_Boss[%i],4) @ "Сʱˢ��һ��</t><b/>" @
			$Get_Dialog_GeShi[31428] @ "	���콱����</t><b/>" @ GetFixedMissionItemText(500 + %i);
		//$Active_PathToDes[ 5, %i ] = "CloseActivityWnd();findpath(" @ %PathID @ ");";
	}

	//------------------------------------------------------------
	//-------------------------------����----------------------
	$SL_HuoDong_Actmsg[6] = "36 1";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[6] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[6],0);
	$active_name_text_[6] = "����";
	$active_curnum_text_[6]= Getact(GetPlayer(),4012,0) * 1  @ "/10";
	$active_time_text_[6] = "ʱ�䣺����";
	$active_team_text_[6]= "����������";
	$active_type_bmp_[6] ="gameres/gui/images/activetype_1.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[6] = "gameres/gui/images/ActivityTypeBmp_006.png";//��ͼ 	1����	2�ع�	3����	4����
	$Activity_Purpose_text[6] = "�Ϲ�ʱ������ħ�ݺᡣ�Ϲ���������󣬰���ħ��������ӡ��Ȼ����ħ�����˼�֮�Ĳ�����������ʿ����Ϊ����֮����ն����ħ��";
	getplayer().ClearMissionItem(6);
	getplayer().AddItemToMission(6,1,113090002,1);
	$Activity_Details_text[6] = "<t>�������������س�Ѱ���ܰ��������ĸ�����ʿ�������Ϲ���ħ�Ĳر�ͼ��Ϊ���ꡣ��������ն���ձ��Ļ�Ե������ǰ����ʿ���㻹����ԥʲô��</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ص㣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����	</t>" @ Getfindpath(410010205,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @	$Get_Dialog_GeShi[31426] @ "	ÿ��10��</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(6) @ "<b/>";
	$Active_PathToDes[6] = "CloseActivityWnd();findpath(410010205);";
	//------------------------------------------------------------
	//-------------------------------�ر�ͼ----------------------
	$SL_HuoDong_Actmsg[7] = "35 1";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[7] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[7],0);
	$active_name_text_[7] = "�ر�ͼ";
	$active_curnum_text_[7]= Getact(GetPlayer(), 4012, 1) * 1  @ "/" @ VIP_getNowTequanLvMaxCnt(getPlayer(), 8);
	$active_time_text_[7] = "ʱ�䣺����";
	$active_team_text_[7]= "����������";
	$active_type_bmp_[7] ="gameres/gui/images/activetype_1.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[7] = "gameres/gui/images/ActivityTypeBmp_007.png";//��ͼ 	1����	2�ع�	3����	4����
	$Activity_Purpose_text[7] = "�Ϲ���ħս��֮�ʣ�����ĵر�����󷨱�����������֮��,�Դ����վ�������������,ת��ʮ��������,����ǿʢ,��ħ�������ճɿա�";
	getplayer().ClearMissionItem(7);
	getplayer().AddItemToMission(7,1,105100131,1);
	getplayer().AddItemToMission(7,1,105100102,1);
	getplayer().AddItemToMission(7,1,105100112,1);
	getplayer().AddItemToMission(7,1,105105302,1);
	getplayer().AddItemToMission(7,1,105105303,1);
	getplayer().AddItemToMission(7,1,105090801,1);
	getplayer().AddItemToMission(7,1,112010006,1);
	getplayer().AddItemToMission(7,1,112020003,1);
	getplayer().AddItemToMission(7,1,109020508,1);
	getplayer().AddItemToMission(7,1,109030505,1);


	$Activity_Details_text[7] = "<t>ÿ�ο����ر�ͼ�����ɻ�òر��ص㣬�л�������󱦲أ�Ҳ����һ�����񣬻��п����ͷų�����ӡ���Ϲ���ħ֮�顣</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ص㣺</t>" @ $Get_Dialog_GeShi[31426] @ "	���ǡ�Ұ���ͼ</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������	</t>" @ $Get_Dialog_GeShi[ 31426 ] @ VIP_getNowTequanLvMaxCnt( getPlayer( ), 8 ) @ "��/��</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(7) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ر�ͼ����ͨ���������������Ŷ��</t>";
	$Active_PathToDes[7] = "CloseActivityWnd();findpath(410010205);";
	//------------------------------------------------------------

	//-------------------------------ʦ�ž���----------------------
	$SL_HuoDong_Actmsg[8] = "35 1";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[8] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[8],0);
	$active_name_text_[8] = "ʦ�ž���";
	$active_curnum_text_[8]= Getact(GetPlayer(),4015,0) * 1  @ "/10";
	$active_time_text_[8] = "ʱ�䣺����";
	$active_team_text_[8]= "����������";
	$active_type_bmp_[8] ="gameres/gui/images/activetype_2.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[8] = "gameres/gui/images/ActivityTypeBmp_008.png";//��ͼ 	1����	2�ع�	3����	4����
	$Activity_Purpose_text[8] = "�������ﷱæ��������ӿ���֮�������۷��������ֵ��������Ϊ���ɾ��ҡ�";
	getplayer().ClearMissionItem(8);
	getplayer().AddItemToMission(8,1,105100262,1);
	$Activity_Details_text[8] = "<t>ÿ��������10��ʦ�ž���������ɵĴ���Խ�࣬����Խ�ߡ�����������񣬲������ǰ��������10�������޷���ȡ����</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ص㣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����	</t>" @ Getfindpath(410100001,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @	$Get_Dialog_GeShi[31426] @ "	ÿ��10��</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(8) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	���10��ʦ�ž�����������;û�з������κ�һ���Ļ�������⽱��</t>" @ "<l i='105109341 ' t='itemid'/>";
	$Active_PathToDes[8] = "CloseActivityWnd();findpath(410100001);";
	//------------------------------------------------------------

	//-------------------------------����������----------------------
	$SL_HuoDong_Actmsg[9] = "40 2";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[9] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[9],0);
	$active_name_text_[9] = "����������";
	$active_curnum_text_[9]= Getact(GetPlayer(),4016,0) * 1  @ "/3";
	$active_time_text_[9] = "ʱ�䣺18:00-24:00";
	$active_team_text_[9]= "����������";
	$active_type_bmp_[9] ="gameres/gui/images/activetype_1.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[9] = "gameres/gui/images/ActivityTypeBmp_009.png";//��ͼ 	1����	2�ع�	3����	4����
	$Activity_Purpose_text[9] = "�Ϲ�֮ʱ�������и�������·����,��;����콫�����������뷲��������һ�������磬��Ϊ�������ľ����ڲ������������С��������������������˿��أ���Ե�߿�����Ѱ����Ե��";
	getplayer().ClearMissionItem(9);
	getplayer().AddItemToMission(9,1,116120073,1);
	getplayer().AddItemToMission(9,1,116120074,1);
	getplayer().AddItemToMission(9,1,116120075,1);
	getplayer().AddItemToMission(9,1,116120076,1);
	getplayer().AddItemToMission(9,1,116120077,1);

	$Activity_Details_text[9] = "<t>����������һ����10���ؿ���ÿ����һ���ؿ����ɻ��һ�ݽ������ڸ�������������սʧ�ܡ��ؿ���Խ�ߣ��Ѷ�Խ�󣬽���Խ���</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ص㣺</t>" @ $Get_Dialog_GeShi[31426] @ "	��������	</t>" @ Getfindpath(413030001,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	18:00-24:00</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @	$Get_Dialog_GeShi[31426] @ "	ÿ�����ս3��</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/>"@
		$Get_Dialog_GeShi[31428] @ "	��ǰ�ؿ���</t>" @ ((Getact(GetPlayer(),4016,1) * 1 <= 10) ? $Get_Dialog_GeShi[31426] @ "	" @ Getact(GetPlayer(),4016,1) * 1 @ "/10</t>" : $Get_Dialog_GeShi[31426] @ "	��ͨ��</t>") @ "<b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(9) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ÿ���ؿ��ı���ÿ��ֻ����ȡһ��</t><b/>" @ "<t>	�ڸ�������������սʧ��</t>";
	$Active_PathToDes[9] = "CloseActivityWnd();findpath(413030001);";
	//------------------------------------------------------------

	//-------------------------------��������----------------------
	$SL_HuoDong_Actmsg[10] = "40 2";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[10] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[10],0);
	$active_name_text_[10] = "��������";
	$active_curnum_text_[10]= GetSrc(GetPlayer(),5)  @ "/1";
	$active_time_text_[10] = "ʱ�䣺�ܶ� �� �� 20:00-20:05";
	$active_team_text_[10]= "����������";
	$active_type_bmp_[10] ="gameres/gui/images/activetype_5.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[10] = "gameres/gui/images/ActivityTypeBmp_010.png";//��ͼ 	1����	2�ع�	3����	4����
	$Activity_Purpose_text[10] = "���ɽ���һƬ�����С���磬Σ�����أ�����ɱ����ʱ�����ֱ�����������֮�ڼ�ʱ��ͨ��֮��Ҳ�޷����";
	getplayer().ClearMissionItem(10);
	getplayer().AddItemToMission(10,1,105100262,1);
	getplayer().AddItemToMission(10,1,105100111,1);
	getplayer().AddItemToMission(10,1,105100121,1);
	getplayer().AddItemToMission(10,1,105100112,1);
	getplayer().AddItemToMission(10,1,105100122,1);
	getplayer().AddItemToMission(10,1,105105302,1);
	getplayer().AddItemToMission(10,1,105105303,1);
	$Activity_Details_text[10] = "<t>�����ɽ��ڣ��ܻ�ó������ϵ���Ϊ��ע��������֮�����ޣ�����������࣬���޷������Ϊ������</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ص㣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����	</t>" @ Getfindpath(410010212,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	�ܶ� �� �� 20:00-20:05</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @	$Get_Dialog_GeShi[31426] @ "	1��/��</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(10) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ڸ�������������սʧ��</t>";
	$Active_PathToDes[10] = "CloseActivityWnd();findpath(410010212);";
	//------------------------------------------------------------
	//-------------------------------Ѻ��-------------------------
	$SL_HuoDong_Actmsg[11] = "50 2";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[11] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[11],0);
	$active_name_text_[11] = "Ѻ��";
	$active_curnum_text_[11]= Getact(GetPlayer(),4018,0) * 1  @ "/" @ VIP_getNowTequanLvMaxCnt(getPlayer(), 7);
	$active_time_text_[11] = "ʱ�䣺12:00-22:00";
	$active_team_text_[11]= "����������";
	$active_type_bmp_[11] ="gameres/gui/images/activetype_5.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[11] = "gameres/gui/images/ActivityTypeBmp_011.png";//��ͼ 	1����	2�ع�	3����	4����
	$Activity_Purpose_text[11] = "��ħ�������Ҫ���ʹ������ʣ���Զ�ھ�����Ƿȱ����ļ������ʿ��ȡ�ͽ�����";
	getplayer().ClearMissionItem(11);
	getplayer().AddItemToMission(11,1,105100262,1);
	getplayer().AddItemToMission(11,1,105100265,1);
	getplayer().AddItemToMission(11,1,105105301,1);
	getplayer().AddItemToMission(11,1,105105302,1);
	getplayer().AddItemToMission(11,1,105105303,1);
	getplayer().AddItemToMission(11,1,105105304,1);
	getplayer().AddItemToMission(11,1,105180150,1);
	getplayer().AddItemToMission(11,1,105180151,1);
	getplayer().AddItemToMission(11,1,105180152,1);
	$Activity_Details_text[11] = "<t>Ѻ��ǰ��Ҫѡ�񱾴�Ѻ��Ѻ����ɺ󷵻�Ѻ��ͬʱ���Ѻ�����50%�Ľ����ΪѺ�ڽ����������Ѻ��;������������Ѻ��ʧ�ܡ�</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ص㣺</t>" @ $Get_Dialog_GeShi[31426] @ "	��ħ��	</t>" @ "<l i='811190100 108.295 -188.031 120' t='path'/>" @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	12:00-22:00</t><b/>" @
		$Get_Dialog_GeShi[ 31428 ] @ "	������	</t>" @ $Get_Dialog_GeShi[ 31426 ] @ VIP_getNowTequanLvMaxCnt( getPlayer( ), 7 ) @ "��/��</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(11) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	�õ�ͼΪ��Σ�����򣬻���ս�����������е�����Ʒ���ա�</t>";
	$Active_PathToDes[11] = "CloseActivityWnd();findpath(411190001);";
	//-----------------------------����----------------------------
	$SL_HuoDong_Actmsg[12] = "30 2";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[12] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[12],0);
	$active_name_text_[12] = "�����ɵ�";
	$active_curnum_text_[12]= GetAct(getplayer(),4022,1) * 1@ "/10";
	$active_time_text_[12] = "ʱ�䣺18:30-19:00";
	$active_team_text_[12]= "����������";
	$active_type_bmp_[12] ="gameres/gui/images/activetype_1.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[12] = "gameres/gui/images/ActivityTypeBmp_012.png";//��ͼ 	1����	2�ع�	3����	4����
	$Activity_Purpose_text[12] = "׳���ĺ�������ɫ��ɳ̲���ڴ���֮���ջ�ϲ��������֮�������Ȥ��������ͣ����ź�̲�����ɡ�";
	getplayer().ClearMissionItem(12);
	getplayer().AddItemToMission(12,1,105109303,1);
	getplayer().AddItemToMission(12,1,106050301,1);
	getplayer().AddItemToMission(12,1,106050302,1);
	getplayer().AddItemToMission(12,1,106050303,1);
	getplayer().AddItemToMission(12,1,106050304,1);
	getplayer().AddItemToMission(12,1,106050305,1);
	getplayer().AddItemToMission(12,1,106050306,1);
	getplayer().AddItemToMission(12,1,106050307,1);

	getplayer().AddItemToMission(12,1,GetNewItemIDForLevel(getplayer(),113050004),1);
	getplayer().AddItemToMission(12,1,GetNewItemIDForLevel(getplayer(),105109321),1);
	getplayer().AddItemToMission(12,1,GetNewItemIDForLevel(getplayer(),105105701),1);
	getplayer().AddItemToMission(12,1,GetNewItemIDForLevel(getplayer(),105090603),1);
	getplayer().AddItemToMission(12,1,GetNewItemIDForLevel(getplayer(),105090503),1);
	$Activity_Details_text[12] = "<t>Я��һ��</t>" @ "<l i='105109301 ' t='itemid'/>" @ "<t>Ѱ��</t>" @ Getfindpath(410100012,0,0,31214) @ "<t>�һ�������ſ��ԲμӴ������</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ص㣺</t>" @ $Get_Dialog_GeShi[31426] @ "	������	</t>" @ "<l i='810100100 -67.873 -127.528 107.257' t='path'/>" @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	18:30-19:00</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(12) @ "<b/>";
	$Active_PathToDes[12] = "CloseActivityWnd();findpath(810100109); ";
	//-------------------------------------------------------------
	//-----------------------------�������----------------------------
	$SL_HuoDong_Actmsg[13] = "30 1";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[13] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[13],0);
	$active_name_text_[13] = "�������";
	$active_curnum_text_[13]= "����";
	$active_time_text_[13] = "ʱ�䣺����";
	$active_team_text_[13]= "����������";
	$active_type_bmp_[13] ="gameres/gui/images/activetype_2.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[13] = "gameres/gui/images/ActivityTypeBmp_013.png";//��ͼ 	1����	2�ع�	3����	4����
	$Activity_Purpose_text[13] = "��˵�������ؾ����е�����ǧ���ľ���ǧ���飬����ָ�տɴ���";
	getplayer().ClearMissionItem(13);
	getplayer().AddItemToMission(13,1,105100261,1);
	getplayer().AddItemToMission(13,1,105109312,1);
	getplayer().AddItemToMission(13,1,105109313,1);
	getplayer().AddItemToMission(13,1,105109314,1);
	getplayer().AddItemToMission(13,1,105109315,1);
	$Activity_Details_text[13] = "<t>����������޵���������Ͼ֮�࣬��ǰȥ����̨�������������������</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ص㣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����̨	</t>" @ "<l i='810100100 8.72428 67.0598 135.177' t='path'/>" @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	ȫ�죨��ȥ�����۾�ʱ��</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(13) @ "<b/>";
	$Active_PathToDes[13] = "CloseActivityWnd();findpath(410100023);";
	//-------------------------------------------------------------
	//-----------------------------�����۾�----------------------------
	$SL_HuoDong_Actmsg[14] = "30 2";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[14] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[14],0);
	$active_name_text_[14] = "�����۾�";
	$active_curnum_text_[14]= GetAct(GetPlayer(),4024,0) + GetAct(GetPlayer(),4024,1) @ "/30";
	$active_time_text_[14] = "ʱ�䣺20:30-20:55";
	$active_team_text_[14]= "����������";
	$active_type_bmp_[14] ="gameres/gui/images/activetype_2.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[14] = "gameres/gui/images/ActivityTypeBmp_014.png";//��ͼ 	1����	2�ع�	3����	4����
	$Activity_Purpose_text[14] = "�����ؾ����ϣ�ÿ��������̨��������Ե�߽Կ�ǰ�����������컯�߿ɴ��л������ࡣ";

	getplayer().ClearMissionItem(14);
	getplayer().AddItemToMission(14,1,105100262,1);
	getplayer().AddItemToMission(14,1,105109312,1);
	getplayer().AddItemToMission(14,1,105109313,1);
	getplayer().AddItemToMission(14,1,105109314,1);
	getplayer().AddItemToMission(14,1,105109315,1);
	$Activity_Details_text[14] = "<t>������ÿ������ʱ���������谴�ա��ǡ������ǡ�ѡ��һ��վ�������ɻ����Ϊ������������Ϻ󣬿�ǰȥѰ��</t>" @ Getfindpath(410100031,0,0,31214) @ "<t>��ȡ������</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ص㣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����̨	</t>" @ "<l i='810100100 8.72428 67.0598 135.177' t='path'/>" @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	20:30-20:55</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(14) @ "<b/>";
	$Active_PathToDes[14] = "CloseActivityWnd();findpath(410100031);";
	//-------------------------------------------------------------
	//-----------------------------��������----------------------------
	$SL_HuoDong_Actmsg[15] = "30 1";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[15] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[15],0);
	$active_name_text_[15] = "��������";
	$active_curnum_text_[15]= GetSrc(GetPlayer(),40) +  GetSrc(GetPlayer(),41) +  GetSrc(GetPlayer(),42) +  GetSrc(GetPlayer(),43) +  GetSrc(GetPlayer(),49) +  GetSrc(GetPlayer(),55) +  GetSrc(GetPlayer(),56) @ "/7";
	$active_time_text_[15] = "ʱ�䣺����";
	$active_team_text_[15]= "����������";
	$active_type_bmp_[15] ="gameres/gui/images/activetype_2.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[15] = "gameres/gui/images/ActivityTypeBmp_015.png";//��ͼ 	1����	2�ع�	3����	4����
	$Activity_Purpose_text[15] = "���������������һ�����أ����ڿ��Ÿ���·��ʿ������ѽ��롣�������������޾����أ�ͬʱҲΣ�����ء�";
	getplayer().ClearMissionItem(15);
	getplayer().AddItemToMission(15,1,105100263,1);
	$Activity_Details_text[15] = "<t>����߸�ÿ��������Ի�û�Ծ�Ⱥʹ������齱����ͬʱ����ͼ��������ѭ�����񡾲�����������</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ص㣺</t>" @ $Get_Dialog_GeShi[31426] @ "	��������	</t>" @ Getfindpath(410010141,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(15) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	�õ�ͼΪ��Σ�����򣬻���ս�����������е�����Ʒ���ա�</t>";
	$Active_PathToDes[15] = "CloseActivityWnd();findpath(410010141);";
	//-------------------------------------------------------------
	//-----------------------------���ͼ���----------------------------
	$SL_HuoDong_Actmsg[16] = "30 1";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[16] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[16],0);
	$active_name_text_[16] = "���ͼ���";
	$active_curnum_text_[16]= "����";
	$active_time_text_[16] = "ʱ�䣺����";
	$active_team_text_[16]= "���������";
	$active_type_bmp_[16] ="gameres/gui/images/activetype_2.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[16] = "gameres/gui/images/ActivityTypeBmp_016.png";//��ͼ 	1����	2�ع�	3����	4����
	$Activity_Purpose_text[16] = "�����ǷǶ࣬����һ���Ͱ��ټ���·��ʿǰȥ����ն����ħ�����۹��¡�";
	getplayer().ClearMissionItem(16);
	getplayer().AddItemToMission(16,1,105100262,1);
	$Activity_Details_text[16] = "<t>�����ͼ������ȡ����������������ְס��̡������ϡ�������Ʒ�ף����Ʒ��Խ�ߵ����񣬽���Խ��񣬻�õĻ�Ծ��ҲԽ�ߣ�</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ص㣺</t>" @ $Get_Dialog_GeShi[31426] @ "	���ɹ�	</t>" @ Getfindpath(411010010,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31426] @ "	       ��ɽѩ��	</t>" @ Getfindpath(411010010,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(16) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	��ȡ������ȼ�����ϵ����񣬽�������Ŷ��</t>";
	$Active_PathToDes[16] = "CloseActivityWnd();findpath(411010010);";
	//-------------------------------------------------------------
	//-----------------------------Ѫħ��ӡ��----------------------------
	$SL_HuoDong_Actmsg[17] = "40 1";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[17] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[17],0);
	$active_name_text_[17] = "Ѫħ��ӡ��";
	$active_curnum_text_[17]= GetSrc(GetPlayer(),57) @ "/1";
	$active_time_text_[17] = "ʱ�䣺����";
	$active_team_text_[17]= "���������";
	$active_type_bmp_[17] ="gameres/gui/images/activetype_2.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[17] = "gameres/gui/images/ActivityTypeBmp_017.png";//��ͼ 	1����	2�ع�	3����	4����
	$Activity_Purpose_text[17] = "ѪħΧ�����س�֮սʱ��һ��ħ��ͷĿ���������ŷ�ӡ����ħԨ��ʣ�µĽ�ͽ�����򱻴���Ѫħ��ӡ��������ҹ������";
	getplayer().ClearMissionItem(17);
	getplayer().AddItemToMission(17,1,105100263,1);
	$Activity_Details_text[17] = "<t>��������Ϊ�������µ���ʵ�����ټ���Ӣ����ǰ��Ѫħ��ӡ������ħ����ͽ�������������Լ���Ϊ��</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ص㣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����	</t>" @ Getfindpath(410010203,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	��ӣ�����6�ˣ�</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(17) @ "<b/>";
	$Active_PathToDes[17] = "CloseActivityWnd();findpath(410010203);";
	//-------------------------------------------------------------
	//-----------------------------�ƽ𱦲�----------------------------
	$SL_HuoDong_Actmsg[18] = "35 1";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[18] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[18],0);
	$active_name_text_[18] = "�ƽ𱦲�";
	$active_curnum_text_[18]= "����";
	$active_time_text_[18] = "ʱ�䣺����";
	$active_team_text_[18]= "����������";
	$active_type_bmp_[18] ="gameres/gui/images/activetype_1.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[18] = "gameres/gui/images/ActivityTypeBmp_018.png";//��ͼ 	1����	2�ع�	3����	4����
	$Activity_Purpose_text[18] = "ǧ��ǰ����һ����������֮�����Ѽ��������䣬����ڻ����ܾ�֮�У����˳�֮Ϊ�ƽ𱦲ء�";
	getplayer().ClearMissionItem(18);
	getplayer().AddItemToMission(18,1,105100265,1);
	getplayer().AddItemToMission(18,1,105105301,1);
	getplayer().AddItemToMission(18,1,105105302,1);
	getplayer().AddItemToMission(18,1,105105303,1);

	$Activity_Details_text[18] = "<t>�ƽ𱦲��������ֻ����ܾ��������ߴ�һ��������������</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ص㣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����	</t>" @ Getfindpath(410010206,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(18) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	��ϸ�鿴ϵͳ��ʾ��̤�����ţ���սʧ��</t>";
	$Active_PathToDes[18] = "CloseActivityWnd();findpath(410010206);";
	//-------------------------------------------------------------
	//-----------------------------��������----------------------------
	$SL_HuoDong_Actmsg[19] = "50 2";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[19] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[19],0);
	$active_name_text_[19] = "��������";
	$active_curnum_text_[19]= GetSrc(GetPlayer(),57) @ "/1";
	$active_time_text_[19] = "ʱ�䣺21:10-21:40";
	$active_team_text_[19]= "����������";
	$active_type_bmp_[19] ="gameres/gui/images/activetype_5.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[19] = "gameres/gui/images/ActivityTypeBmp_019.png";//��ͼ 	1����	2�ع�	3����	4����
	$Activity_Purpose_text[19] = "����������һ�Ϲ�ս�������˰�ս֮�أ����������ɴ����������Ϊ��";
	getplayer().ClearMissionItem(19);
	getplayer().AddItemToMission(19,1,105100262,1);
	getplayer().AddItemToMission(19,1,105105303,1);
	getplayer().AddItemToMission(19,1,105105304,1);
	getplayer().AddItemToMission(19,1,105180070,1);
	getplayer().AddItemToMission(19,1,105180071,1);
	getplayer().AddItemToMission(19,1,105180072,1);
	getplayer().AddItemToMission(19,1,105180090,1);
	getplayer().AddItemToMission(19,1,105180091,1);
	getplayer().AddItemToMission(19,1,105180092,1);
	$Activity_Details_text[19] = "<t>���ս��������ʹ�ߵ������Լ����ܵж���Ӫ��ʿ���ɻ�ô������齱����</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ص㣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����	</t>" @ Getfindpath(410010207,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	21:00</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(19) @ "<b/>";
	$Active_PathToDes[19] = "CloseActivityWnd();findpath(410010207);";
	//-------------------------------------------------------------

	//-----------------------------���Ǵ���----------------------------
	$SL_HuoDong_Actmsg[20] = "30 1";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[20] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[20],0);
	$active_name_text_[20] = "���Ǵ���";
	$active_curnum_text_[20]= GetAct(GetPlayer(),4098,0) * 1 @ "/10";
	$active_time_text_[20] = "ʱ�䣺����";
	$active_team_text_[20]= "����������";
	$active_type_bmp_[20] ="gameres/gui/images/activetype_2.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[20] = "gameres/gui/images/ActivityTypeBmp_020.png";//��ͼ 	1����	2�ع�	3����	4����

	%Level = GetPlayer().GetLevel();
	if (%Level <= 44) %Itemname = "<l i='105109321 ' t='itemid'/>";
	else if (%Level <= 44) %Itemname = "<l i='105109321 ' t='itemid'/>";
	else if (%Level <= 59) %Itemname = "<l i='105109322 ' t='itemid'/>";
	else if (%Level <= 74) %Itemname = "<l i='105109323 ' t='itemid'/>";
	else if (%Level <= 89) %Itemname = "<l i='105109324 ' t='itemid'/>";
	else  %Itemname = "<l i='105109325 ' t='itemid'/>";

	$Activity_Purpose_text[20] = "<t>����ʹ�������������ռ���������</t>" @ %Itemname @ "<t>��ǰ���Ͻ�</t>" @ %Itemname @ "<t>���ɻ�������ϵ���������</t>";
	getplayer().ClearMissionItem(20);
	getplayer().AddItemToMission(20,1,105100263,1);

	$Activity_Details_text[20] = "<t>�Ͻɺ��Լ��ȼ���Ӧ��</t>" @ %Itemname @ "<t>�����ɽ�ȡ��Ӧ�ȼ�����������</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ص㣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����	</t>" @ Getfindpath(410010104,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(20) @ "<b/>";
	$Active_PathToDes[20] = "CloseActivityWnd();findpath(410010104);";
	//-------------------------------------------------------------

	//-----------------------------��ħ��----------------------------
	$SL_HuoDong_Actmsg[21] = "40 1";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[21] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[21],0);
	$active_name_text_[21] = "��ħ��";
	$active_curnum_text_[21]= "����";
	$active_time_text_[21] = "ʱ�䣺6Сʱ����һ��";
	$active_team_text_[21]= "����������";
	$active_type_bmp_[21] ="gameres/gui/images/activetype_1.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[21] = "gameres/gui/images/ActivityTypeBmp_021.png";//��ͼ 	1����	2�ع�	3����	4����

	%Level = GetPlayer().GetLevel();
	if (%Level <= 44) %Itemname = "<l i='105109321 ' t='itemid'/>";
	else if (%Level <= 44) %Itemname = "<l i='105109321 ' t='itemid'/>";
	else if (%Level <= 59) %Itemname = "<l i='105109322 ' t='itemid'/>";
	else if (%Level <= 74) %Itemname = "<l i='105109323 ' t='itemid'/>";
	else if (%Level <= 89) %Itemname = "<l i='105109324 ' t='itemid'/>";
	else  %Itemname = "<l i='105109325 ' t='itemid'/>";

	$Activity_Purpose_text[21] = "<t>������������꺮���·�����һ���¹�����������ʬħ������ʬħ�����л���������ǰ��ϰս����</t>";
	getplayer().ClearMissionItem(21);
	getplayer().AddItemToMission(21,1,105100268,1);

	$Activity_Details_text[21] = "<t>����������2�㣬��һʬ�������ŵ��¹�����ڣ�����ʬ������ħ�����ڽ������֡�</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	��ڣ�</t>" @ $Get_Dialog_GeShi[31426] @ "	��������	</t>" @ Getfindpath(411180001,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	6Сʱ����һ��</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ȼ���</t>" @ $Get_Dialog_GeShi[31426] @ "	���40���ɽ���</t><b/>"@
		$Get_Dialog_GeShi[31426] @ "	       ����60������ǰ��</t><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	���ޣ����������ӣ�</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(21) @ "<b/>";
	$Active_PathToDes[21] = "CloseActivityWnd();findpath(410010104);";
	//-------------------------------------------------------------
	//-----------------------------���޾�----------------------------
	$SL_HuoDong_Actmsg[22] = "40 1";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[22] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[22],0);
	$active_name_text_[22] = "���޾�";
	$active_curnum_text_[22]= GetSrc(GetPlayer(),191) @ "/1";
	$active_time_text_[22] = "ʱ�䣺����";
	$active_team_text_[22]= "������6������";
	$active_type_bmp_[22] ="gameres/gui/images/activetype_5.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[22] = "gameres/gui/images/ActivityTypeBmp_022.png";//��ͼ 	1����	2�ع�	3����	4����

	%Level = GetPlayer().GetLevel();
	if (%Level <= 44) %Itemname = "<l i='105109321 ' t='itemid'/>";
	else if (%Level <= 44) %Itemname = "<l i='105109321 ' t='itemid'/>";
	else if (%Level <= 59) %Itemname = "<l i='105109322 ' t='itemid'/>";
	else if (%Level <= 74) %Itemname = "<l i='105109323 ' t='itemid'/>";
	else if (%Level <= 89) %Itemname = "<l i='105109324 ' t='itemid'/>";
	else  %Itemname = "<l i='105109325 ' t='itemid'/>";

	$Activity_Purpose_text[22] = "<t>������һ����ռ䣬��Ϊ���޾����������ؼ�̳�����ٻ�����ǿ�߽��١�</t>";
	getplayer().ClearMissionItem(22);
	getplayer().AddItemToMission(22,1,105100268,1);

	$Activity_Details_text[22] = "<t>����ʹ�������ģ��ƿ��Ŵ˴��ռ����ڡ������������Я������ǰȥ��ս���޽�����սʤ������ɻ�ý������ء�</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	��ڣ�</t>" @ $Get_Dialog_GeShi[31426] @ "	����	</t>" @ Getfindpath(410010107,0,0,31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ȼ���</t>" @ $Get_Dialog_GeShi[31426] @ "	���40���ɽ���</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	6������</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(22) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ֻ�а����ſ��Կ���������ս��ֻ�а��ɳ�Ա�ſ��Խ���˸�����</t>";
	$Active_PathToDes[22] = "CloseActivityWnd();findpath(410010107);";
	//-------------------------------------------------------------
	//-----------------------------�����ؾ�----------------------------
	$SL_HuoDong_Actmsg[23] = "35 1";//�ɼ��ȼ� �����(1 2 3)
	$active_lv_text_[23] = "�ȼ�:" @ GetWord($SL_HuoDong_Actmsg[23], 0);
	$active_name_text_[23] = "�����ؾ�";
	$active_curnum_text_[23] = GetAct(getplayer(), 4103, 0) * 1 @ "/1";
	$active_time_text_[23] = "ʱ�䣺����";
	$active_team_text_[23] = "������3������";
	$active_type_bmp_[23] = "gameres/gui/images/activetype_1.png";// 1  ���߻ 2  ���� 3�ع����� 4��������
	$CreateActivityBmp_[23] = "gameres/gui/images/ActivityTypeBmp_022.png";//��ͼ 	1����	2�ع�	3����	4����

	%Level = getplayer().GetLevel();
	%Level = mfloor(%Level / 10);
	if (%Level < 40)
		%level = 40;
	switch (%level)
	{
	case 40:%itemid = 105100273;//��ɫװ��(40 - 49��)
	case 40:%itemid = 105100275;//��ɫװ��(50 - 59��)
	case 40:%itemid = 105100277;//��ɫװ��(60 - 69��)
	case 40:%itemid = 105100279;//��ɫװ��(70 - 79��)
	case 40:%itemid = 105100281;//��ɫװ��(80 - 89��)
	case 40:%itemid = 105100283;//��ɫװ��(90 - 99��)
	default:%itemid = 1051002831;//
	}

	$Activity_Purpose_text[23] = "<t>�����������̨���������ŵ�˭�ҡ�</t>";
	getplayer().ClearMissionItem(23);
	getplayer().AddItemToMission(23, 1, %itemid, 1);

	$Activity_Details_text[23] = "<t>35��������ʿ�齨���飬�����سǵ���ʦ�Ի����ɽ�������ؾ�����ɱ�����ڹ����м��ʻ����ɫװ������Ӣ����ĵ�������ͨ������屶������ض������൱�ڶ�����������װ��</t><b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "	��ڣ�</t>" @ $Get_Dialog_GeShi[31426] @ "	����	</t>" @ Getfindpath(413180001, 0, 0, 31214) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	ʱ�䣺</t>" @ $Get_Dialog_GeShi[31426] @ "	����</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	�ȼ���</t>" @ $Get_Dialog_GeShi[31426] @ "	35��</t><b/>" @
		$Get_Dialog_GeShi[31428] @ "	������</t>" @ $Get_Dialog_GeShi[31426] @ "	����3������</t><b/><b/>"@
		$Get_Dialog_GeShi[31428] @ "	������</t><b/>" @ GetFixedMissionItemText(23) @ "<b/>" @
		$Get_Dialog_GeShi[31428] @ "	����ǰ��ɳ�Ա�����ܸ�������󣬶����ð��ɻ�Ծ������</t>";
	$Active_PathToDes[23] = "CloseActivityWnd();findpath(413180001);";
	//-------------------------------------------------------------
}

//�������������ȫϵͳ������������ȫ�ֱ�����š���������������������



//�������������ȫϵͳ�������������յ�����˿������á���������������
//Getallactivitybactive("1 1 1 1 1" @ " 1 1 1 1 1 1 -1 1 1 1 1 -1 1 1 1 1 -1 1 1 1 1 1 1 -1 1");
function Getallactivitybactive(%type)
{
	//echo( "%type=======" @ %type );
	$SL_HuoDong = %type;
	GetActivitytext();
	//echo( "$SL_HuoDong========================" @ $SL_HuoDong );
	$SL_HuoDong[1]="";
	$SL_HuoDong[2]="";
	$SL_HuoDong[3]="";
	$SL_HuoDong_Lvjudg[1]="";
	$SL_HuoDong_Lvjudg[2]="";
	$SL_HuoDong_Lvjudg[3]="";
	%Count = getwordcount(%type);
	%Level = GetPlayer().getlevel();
	for (%i = 0; %i < %Count; %i++)
	{
		%bActive = GetWord(%type,%i);
		if (%bActive $= "-1")
			continue;
		if (%i == 4)//BOSS����������
		{
			for (%j = 1; %j <= 99; %j++)
			{
				if ($SL_HuoDong_Boss[%j] $= "")
					break;
				if (GetWord($SL_HuoDong_Boss[%j],1) $= "9999")
					continue;
				$SL_HuoDong[3] = %j @ " " @ $SL_HuoDong[3];
				$SL_HuoDong_Lvjudg[3] = %j @ " " @ $SL_HuoDong_Lvjudg[3];
			}
		}
		else
		{
			%SL_level  = getword($SL_HuoDong_Actmsg[%i + 1],0);
			%SL_type  = getword($SL_HuoDong_Actmsg[%i + 1],1);

			if (%SL_level != 9999)
				$SL_HuoDong[%SL_type] = %i + 1 @ " " @ $SL_HuoDong[%SL_type];

			if (%bActive $= "1" && %Level >= %SL_level - 10)
				$SL_HuoDong_Lvjudg[%SL_type] = %i + 1 @ " " @ $SL_HuoDong_Lvjudg[%SL_type];

		}
	}

	//------------------����һ��--------------------
	//echo( "$SL_HuoDong[ 1 ] ==" @ $SL_HuoDong[ 1 ] );
	//echo( "$SL_HuoDong[ 2 ] ==" @ $SL_HuoDong[ 2 ] );
	//echo( "$SL_HuoDong[ 3 ] ==" @ $SL_HuoDong[ 3 ] );

	//echo( "$SL_HuoDong_Lvjudg[ 1 ] ==" @ $SL_HuoDong_Lvjudg[ 1 ] );
	//echo( "$SL_HuoDong_Lvjudg[ 2 ] ==" @ $SL_HuoDong_Lvjudg[ 2 ] );
	//echo( "$SL_HuoDong_Lvjudg[ 3 ] ==" @ $SL_HuoDong_Lvjudg[ 3 ] );
	//echo( "----------------�����------------------------" );
	//��������ʼ����
	for (%i=1; %i<=2; %i++)
	{
		//-------------���л------------------
		%count = getwordcount($SL_HuoDong[%i]);
		//echo( "%i===" @ %i @ "  %count==="@ %count );
		for (%x=0; %x < %count; %x++)
		{
			%iact[%x] = getword($SL_HuoDong[%i],%x);
			//echo( "%iact[ " @ %x @ " ]===" @ %iact[ %x ] );
		}

		//echo( "====" @ %iact[ 1 ] @ "=========" );
		for (%j=0; %j < %count - 1; %j++)
		{
			for (%a = %j +1; %a < %count; %a++)
			{
				//echo( "getword( $SL_HuoDong_Actmsg[ %iact[ %x ] ] ==" @ getword( $SL_HuoDong_Actmsg[ %iact[ %x ] ],0) @ "------------getword( $SL_HuoDong_Actmsg[ %iact[ %a ] ]==" @ getword( $SL_HuoDong_Actmsg[ %iact[ %a ] ] ,0));
				//echo( "$SL_HuoDong_Actmsg[ " @ %iact[ %j ] @ "]===" @ $SL_HuoDong_Actmsg[ %iact[ %j ] ] );
				if (getword($SL_HuoDong_Actmsg[%iact[%j]],0) < getword($SL_HuoDong_Actmsg[%iact[%a]],0))
				{
					//echo( $SL_HuoDong_Actmsg[ %iact[ %j ] ] @ "-------------" @  $SL_HuoDong_Actmsg[ %iact[ %a ] ] );
					%key = %iact[%j];
					%iact[%j] = %iact[%a];
					%iact[%a] = %key;
				}
			}
		}

		for (%x=0; %x < %count; %x++)
		{
			%iacthuodong[%i] = %iact[%x] @ " " @ %iacthuodong[%i];
			//echo( "%iacthuodong[ " @ %i @ "]==" @ %iacthuodong[ %i ] );
		}

		//echo( "====" @ %iact[ 1 ] @ "=========" );
		$SL_HuoDong[%i] = %iacthuodong[%i];

		//echo( "$SL_HuoDong[ " @ %i @ "]===" @ $SL_HuoDong[ %i ] );
		//---------------�ɲ���Ļ-----------------
		%count = getwordcount($SL_HuoDong_Lvjudg[%i]);

		//echo( "%i===" @ %i @ "  %count==="@ %count );
		for (%x=0; %x < %count; %x++)
		{
			%iact[%x] = getword($SL_HuoDong_Lvjudg[%i],%x);
		}

		for (%j=0; %j < %count - 1; %j++)
		{
			for (%a = %j +1; %a < %count; %a++)
			{
				if (getword($SL_HuoDong_Actmsg[%iact[%j]],0) < getword($SL_HuoDong_Actmsg[%iact[%a]],0))
				{
					%key = %iact[%j];
					%iact[%j] = %iact[%a];
					%iact[%a] = %key;
				}
			}
		}

		for (%x=0; %x < %count; %x++)
		{
			%iacthuodonglvjudge[%i] = %iact[%x] @ " " @ %iacthuodonglvjudge[%i];
		}
		$SL_HuoDong_Lvjudg[%i] = %iacthuodonglvjudge[%i];

		//echo( "$SL_HuoDong_Lvjudg[ " @ %i @ "]===" @ $SL_HuoDong_Lvjudg[ %i ] );
	}

	//-------------------BOSS������------------------
	%count = getwordcount($SL_HuoDong[3]);
	for (%x=0; %x < %count; %x++)
	{
		%iact[%x] = getword($SL_HuoDong[3],%x);
	}

	for (%j=0; %j < %count - 1; %j++)
	{
		for (%a = %j +1; %a < %count; %a++)
		{
			if (getword($SL_HuoDong_Boss[%iact[%j]],1) < getword($SL_HuoDong_Boss[%iact[%a]],1))
			{
				%key = %iact[%j];
				%iact[%j] = %iact[%a];
				%iact[%a] = %key;
			}
		}
	}

	for (%x=0; %x < %count; %x++)
	{
		%iacthuodongboss[3] = %iact[%x] @ " " @ %iacthuodongboss[3];
	}
	$SL_HuoDong_Lvjudg[3] = $SL_HuoDong[3] = %iacthuodongboss[3];
	//echo( "$SL_HuoDong_Lvjudg[ 3 ] ==" @ $SL_HuoDong_Lvjudg[ 3 ] );
	//echo( "$SL_HuoDong ==" @ $SL_HuoDong );
	//echo( "$SL_HuoDong[ 1 ] ==" @ $SL_HuoDong[ 1 ] );
	//echo( "$SL_HuoDong[ 2 ] ==" @ $SL_HuoDong[ 2 ] );
	//echo( "$SL_HuoDong[ 3 ] ==" @ $SL_HuoDong[ 3 ] );

	//echo( "$SL_HuoDong_Lvjudg[ 1 ] ==" @ $SL_HuoDong_Lvjudg[ 1 ] );
	//echo( "$SL_HuoDong_Lvjudg[ 2 ] ==" @ $SL_HuoDong_Lvjudg[ 2 ] );
	//echo( "$SL_HuoDong_Lvjudg[ 3 ] ==" @ $SL_HuoDong_Lvjudg[ 3 ] );
	//---------------ˢ�½���-------------------------------
	ShowBtnActivityMessage(getwordcount($SL_HuoDong[1]),1,0);
	ShowBtnActivityMessage(getwordcount($SL_HuoDong[2]),2,0);
	ShowBtnActivityMessage(getwordcount($SL_HuoDong[3]),3,0);
}
//�������������ȫϵͳ�������������յ�����˿������á���������������

//�������������ȫϵͳ������������������������������������������
function GetActivityNumByType(%type,%litState)
{
	//echo( "%type ==" @ %type );
	//echo( "%litState ==" @ %litState );
	if (%litState == 1)
		eval("%str = $SL_HuoDong_Lvjudg[" @ %type @ "];");
	else
		eval("%str = $SL_HuoDong[" @ %type @ "];");

	//echo( " %str===" @  %str );
	return getwordcount(%str);
}

//�������������ȫϵͳ������������������������������������������



//�������������ȫϵͳ��������������ı���ʾ����������������������
function ShowBtnActivityMessage(%num,%type,%litState)
{
	//echo( "%num ==" @ %num  @ "   %type===" @ %type  @ "  %litState===" @ %litState @ "   $SL_HuoDong==" @ $SL_HuoDong );

	GetActivitytext();//����ˢ��ȫ�ֱ�������ֹ����

	if (%litState == 1)
		eval("%str = $SL_HuoDong_Lvjudg[" @ %type @ "];");
	else
		eval("%str = $SL_HuoDong[" @ %type @ "];");

	if (%num  == 0)
		%num = Getwordcount(%str);
	switch (%type)
	{
		case 3:
			for (%i=0; %i< %num; %i++)
			{
				%Active = 5;
				%iid = getword(%str,%i);
				//echo( "%iid====" @ %iid  @ "      " @  $active_time_text_[ %Active, %iid ] );
				("active_lv_text_" @ %i).settext($active_lv_text_[%Active,%iid]);
				("active_name_text_" @ %i).SetContent("<t m='0' f='����' n='20' gct='0xffffffff' gcb='0x1FA6F3ff'>" @ $active_name_text_[%Active,%iid] @ "</t>");
				("active_curnum_text_" @ %i).settext($active_curnum_text_[%Active,%iid]);
				("active_time_text_" @ %i).settext($active_time_text_[%Active,%iid]);
				("active_team_text_" @ %i).settext($active_team_text_[%Active,%iid]);
				("active_type_bmp_" @ %i).setbitmap($active_type_bmp_[%Active,%iid]);
				("CreateActivityBmp_" @ %i).setbitmap($CreateActivityBmp_[%Active,%iid]);
			}
		default:
			//echo( "%str==" @ %str );
			for (%i=0; %i<%num; %i++)
			{
				%Active = GetWord(%str,%i);
				//echo( "%Active===" @ %Active );
				//echo( "$active_name_text_[ %Active, %iid ]==" @ $active_name_text_[ %Active, %iid ] );
				("active_lv_text_" @ %i).settext($active_lv_text_[%Active]);
				("active_name_text_" @ %i).SetContent("<t m='0' f='����' n='20' gct='0xffffffff' gcb='0x1FA6F3ff'>" @ $active_name_text_[%Active] @ "</t>");
				("active_curnum_text_" @ %i).settext($active_curnum_text_[%Active]);
				("active_time_text_" @ %i).settext($active_time_text_[%Active]);
				("active_team_text_" @ %i).settext($active_team_text_[%Active]);
				("active_type_bmp_" @ %i).setbitmap($active_type_bmp_[%Active]);
				("CreateActivityBmp_" @ %i).setbitmap($CreateActivityBmp_[%Active]);
			}
	}
	SetDetailsContent(%type,0);
}

function SetDetailsContent(%type,%i)
{
	//echo( "%type===" @ %type  @ "  %i===" @ %i );
	switch (%type)
	{
		case 3:
			eval("%str = $SL_HuoDong[" @ %type @ "];");
			%Active = GetWord(%str,%i);

			Activity_Purpose_text.setcontent($Get_Dialog_GeShi[31428] @ $Activity_Purpose_text[5,%Active] @ "</t>");
			Activity_Details_text.setcontent($Get_Dialog_GeShi[31428] @ $Activity_Details_text[5,%Active] @ "</t>");
			//Active_PathToDes.Command = $Active_PathToDes[ 5, %i + 1 ] ;
			Active_PathToDes.setvisible(0);
		default:
			if (LimitedActivelySelect.IsStateOn())
				eval("%str = $SL_HuoDong_Lvjudg[" @ %type @ "];");
			else
				eval("%str = $SL_HuoDong[" @ %type @ "];");
			//echo( "%str====" @ %str );
			%Active = GetWord(%str,%i);
			Activity_Purpose_text.setcontent($Get_Dialog_GeShi[31428] @ $Activity_Purpose_text[%Active] @ "</t>");
			Activity_Details_text.setcontent($Get_Dialog_GeShi[31428] @ $Activity_Details_text[%Active] @ "</t>");
			//Active_PathToDes.Command( $Active_PathToDes[ %i ] );
			Active_PathToDes.setvisible(1);
			Active_PathToDes.Command = $Active_PathToDes[%Active];
	}
}
//�������������ȫϵͳ��������������ı���ʾ����������������������
