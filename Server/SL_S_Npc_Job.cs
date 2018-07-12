//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//�����ű���ΪNPC�����Խű������е�ͼ��������
//�ű����������NPC�����������ʾ
//==================================================================================


//���й�������Ĵ����
function Npc_Job(%Npc,%Player,%State,%Conv)
{
	//NPC���ܷ��ࣺ
	//6λ��
	//��λ1���̵���
	//��λ2�����ܽ�����

	//4λ����ͼ���
	//5λ�����͵�ͼָ����

	//���깦��
	NpcOpenShop(%Npc,%Player,%State,%Conv);

	//���������Խ���
	NpcOpenJob(%Npc,%Player,%State,%Conv);

	//���������ԶԻ����޽���
	NpcCanDoJob(%Npc,%Player,%State,%Conv);

	//Npc���͹���
	NpcTransportObject(%Npc,%Player,%State,%Conv);

	//���е㹦��
	NpcFly(%Npc,%Player,%State,%Conv);

	//���ָ��ְ���
	NewPlayerHelp(%Npc,%Player,%State,%Conv);

	//��������
	//	ShenXianYiShi(%Npc, %Player, %State , %Conv);

	//�뿪����ͳһ����
	leave_CopyMap_Operate(%Npc,%Player,%State,%Conv);

}

//���깦��
function NpcOpenShop(%Npc,%Player,%State,%Conv)
{
	if (%State == 0)
	{
		%Player.ShengWangShop1 = "";
		%Player.ShengWangShop2 = "";
	}
	if (%State == 0)
	{
		switch (%Npc.GetDataID())
		{
			//---------------1010--------------
			case 410100064:
				%Time = GetLocalTime();
				%DQ_HH = GetWord(%Time,3);	//ʱ
				%LocalWeek = GetLocalWeek();
				if (%LocalWeek == 0 && %DQ_HH >= 17 && %DQ_HH < 19)
					%Conv.AddOption(410119,410119);//�����̵�
			case 410100012://���
				if ( %player.getlevel( ) >= 30 )
					%Conv.AddOption( 410120, 410120 );//����̵�
			case 410100058:
				if ( %player.getlevel( ) <= 30 )
					%Conv.AddOption( 410100, 410100 );//�����̵�
				//%Conv.AddOption(410101,410101);//�����̵�
				//%Conv.AddOption(410102,410102);//�䷽�̵�
			case 410100003:
				if ( %player.getlevel( ) <= 30 )
					%Conv.AddOption( 410103, 410103 );//ҩƷ�̵�
				//%Conv.AddOption(410104,410104);//�����̵�
				//%Conv.AddOption(410105,410105);//�䷽�̵�
			case 410100060:
				if ( %player.getlevel( ) <= 30 )
					%Conv.AddOption( 410106, 410106 );//�����̵�
				//%Conv.AddOption(410107,410107);//�����̵�
				//%Conv.AddOption(410108,410108);//�����̵�
			case 410100004:
				if ( %player.getlevel( ) <= 30 )
					%Conv.AddOption( 410109, 410109 );//װ���̵�
				//%Conv.AddOption(410110,410110);//�÷��̵�
				//%Conv.AddOption(410111,410111);//�䷽�̵�
			case 410100059:
				if ( %player.getlevel( ) <= 30 )
					%Conv.AddOption( 410112, 410112 );//��Ʒ�̵�
				//%Conv.AddOption(410113,410113);//�����̵�
				//%Conv.AddOption(410114,410114);//�䷽�̵�
			case 410100005:
				if ( %player.getlevel( ) <= 30 )
					%Conv.AddOption( 410115, 410115 );//ʳ���̵�
				//%Conv.AddOption(410116,410116);//����̵�
				//%Conv.AddOption(410117,410117);//�䷽�̵�
			case 410100009:
				if ( %player.getlevel( ) <= 30 )
					%Conv.AddOption( 410118, 410118 );//�ӻ���
				if ( %player.getlevel( ) >= 20 )
					%Conv.AddOption( 430000, 430000 );

				//--------------1001-------------------
			case 410010116:
				%Conv.AddOption(410000,410000);//�����̵�
				%Conv.AddOption(410001,410001);//�����̵�
				%Conv.AddOption(410002,410002);//�䷽�̵�
			case 410010115:
				%Conv.AddOption(410003,410003);//ҩƷ�̵�
				%Conv.AddOption(410004,410004);//�����̵�
				%Conv.AddOption(410005,410005);//�䷽�̵�
			case 410010119:
				%Conv.AddOption(410006,410006);//�����̵�
				%Conv.AddOption(410007,410007);//�����̵�
				%Conv.AddOption(410008,410008);//�����̵�
			case 410010117:
				%Conv.AddOption(410009,410009);//װ���̵�
				%Conv.AddOption(410010,410010);//�÷��̵�
				%Conv.AddOption(410011,410011);//�䷽�̵�
			case 410010118:
				%Conv.AddOption(410012,410012);//��Ʒ�̵�
				%Conv.AddOption(410013,410013);//�����̵�
				%Conv.AddOption(410014,410014);//�䷽�̵�
			case 410010140:
				%Conv.AddOption(410015,410015);//ʳ���̵�
				%Conv.AddOption(410016,410016);//����̵�
				%Conv.AddOption(410017,410017);//�䷽�̵�
			case 410010111:
				%Conv.AddOption(410018,410018);//�ӻ���
			case 410010215:
				%Conv.AddOption(430001,430001);//�����̵�
			case 410010216:
				%Conv.AddOption( 410019, 410019 );//Ȥζ����
			case 410010201:
				if ( $SL_ManYueQingDianStore_State_bActive == 1 )
					%Conv.AddOption( 430002, 430002 );//������Ů
			case 410010013:
				%Level = %Player.GetLevel( );
				if ( %Level <= 49 ) %Conv.AddOption( 410021, 410021 );
				else if ( %Level <= 69 ) %Conv.AddOption( 410022, 410022 );
				else if ( %Level <= 89 ) %Conv.AddOption( 410023, 410023 );
				else  %Conv.AddOption( 410024, 410024 );
			case 410010014:
				%Level = %Player.GetLevel( );
				if ( %Level <= 49 ) %Conv.AddOption( 410031, 410031 );
				else if ( %Level <= 69 ) %Conv.AddOption( 410032, 410032 );
				else if ( %Level <= 89 ) %Conv.AddOption( 410033, 410033 );
				else  %Conv.AddOption( 410034, 410034 );

				//------------------1101----------------
			case 411010015:
				%Conv.AddOption(410200,410200);//�����̵�
				%Conv.AddOption(100077,100077);//װ������
			case 411010014:
				%Conv.AddOption(410203,410203);//ҩƷ�̵�
			
			case 411010017:
				%Conv.AddOption(410209,410209);//װ���̵�
			case 411010019:
				%Conv.AddOption(410212,410212);//��Ʒ�̵�
			case 411010018:
				%Conv.AddOption(410215,410215);//ʳ���̵�
			case 411010016:
				%Conv.AddOption(410218,410218);//�ӻ���

				//------------------1102-----------------
			case 411020006:
				%Conv.AddOption(410300,410300);//�����̵�
				%Conv.AddOption(100077,100077);//װ������
			case 411020005:
				%Conv.AddOption(410303,410303);//ҩƷ�̵�
			case 411020008:
				%Conv.AddOption(410309,410309);//װ���̵�
			case 411020014:
				%Conv.AddOption(410312,410312);//��Ʒ�̵�
			case 411020009:
				%Conv.AddOption(410315,410315);//ʳ���̵�
			case 411020007:
				%Conv.AddOption(410318,410318);//�ӻ���

				//------------------1103------------------
			case 411030007:
				%Conv.AddOption( 410400, 410400 );//�����̵�
				%Conv.AddOption( 100077, 100077 );//װ������
			case 411030006:
				%Conv.AddOption( 410403, 410403 );//ҩƷ�̵�
			case 411030011:
				%Conv.AddOption( 410409, 410409 );//װ���̵�
			case 411030003:
				%Conv.AddOption( 410412, 410412 );//��Ʒ�̵�
			case 411030012:
				%Conv.AddOption( 410415, 410415 );//ʳ���̵�
			case 411030010:
				%Conv.AddOption( 410418, 410418 );//�ӻ���

				//-----------------�����̵�--------------
			case 410010134://ս����
				%ShengWangJieDuan[1] = 50000;
				%ShengWangJieDuan[2] = 580000;
				%ShengWangJieDuan[3] = 2000000;
				%ShengWangJieDuan[4] = 6000000;
				%ShengWangJieDuan[5] = 15000000;
				%ShengWang = GetPrestige(%Player, 1, 1);
				
				if (%ShengWang >= %ShengWangJieDuan[1] && %ShengWang < %ShengWangJieDuan[2]) { %Player.ShengWangShop1 = 410035; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[2] && %ShengWang < %ShengWangJieDuan[3]) { %Player.ShengWangShop1 = 410036; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[3] && %ShengWang < %ShengWangJieDuan[4]) { %Player.ShengWangShop1 = 410037; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[4] && %ShengWang < %ShengWangJieDuan[5]) { %Player.ShengWangShop1 = 410038; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[5]) { %Player.ShengWangShop1 = 410039; %Player.ShengWangShop2 = 0; }
				else { %Player.ShengWangShop1 = 410035; %Player.ShengWangShop2 = -1; }

				if (%Player.ShengWangShop1 > 0) %Conv.AddOption(%Player.ShengWangShop1, %Player.ShengWangShop1);
				if (%Player.ShengWangShop2 > 0) %Conv.AddOption(%Player.ShengWangShop2, %Player.ShengWangShop2);

				
			case 410010135://������
				%ShengWangJieDuan[1] = 50000;
				%ShengWangJieDuan[2] = 580000;
				%ShengWangJieDuan[3] = 2000000;
				%ShengWangJieDuan[4] = 6000000;
				%ShengWangJieDuan[5] = 15000000;
				%ShengWang = GetPrestige(%Player, 1, 4);

				if (%ShengWang >= %ShengWangJieDuan[1] && %ShengWang < %ShengWangJieDuan[2]) { %Player.ShengWangShop1 = 410040; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[2] && %ShengWang < %ShengWangJieDuan[3]) { %Player.ShengWangShop1 = 410041; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[3] && %ShengWang < %ShengWangJieDuan[4]) { %Player.ShengWangShop1 = 410042; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[4] && %ShengWang < %ShengWangJieDuan[5]) { %Player.ShengWangShop1 = 410043; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[5]) { %Player.ShengWangShop1 = 410044; %Player.ShengWangShop2 = 0; }
				else { %Player.ShengWangShop1 = 410040; %Player.ShengWangShop2 = -1; }

				if (%Player.ShengWangShop1 > 0) %Conv.AddOption(%Player.ShengWangShop1, %Player.ShengWangShop1);
				if (%Player.ShengWangShop2 > 0) %Conv.AddOption(%Player.ShengWangShop2, %Player.ShengWangShop2);

			case 410010136://������
				%ShengWangJieDuan[1] = 50000;
				%ShengWangJieDuan[2] = 580000;
				%ShengWangJieDuan[3] = 2000000;
				%ShengWangJieDuan[4] = 6000000;
				%ShengWangJieDuan[5] = 15000000;
				%ShengWang = GetPrestige(%Player, 1, 2);
				//echo("%ShengWang===" @ %ShengWang);
				if (%ShengWang >= %ShengWangJieDuan[1] && %ShengWang < %ShengWangJieDuan[2]){ %Player.ShengWangShop1 = 410045; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[2] && %ShengWang < %ShengWangJieDuan[3]){ %Player.ShengWangShop1 = 410046; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[3] && %ShengWang < %ShengWangJieDuan[4]){ %Player.ShengWangShop1 = 410047; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[4] && %ShengWang < %ShengWangJieDuan[5]){ %Player.ShengWangShop1 = 410048; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[5]) { %Player.ShengWangShop1 = 410049; %Player.ShengWangShop2 = 0; }
				else { %Player.ShengWangShop1 = 410045; %Player.ShengWangShop2 = -1; }

				if (%Player.ShengWangShop1 > 0) %Conv.AddOption(%Player.ShengWangShop1, %Player.ShengWangShop1);
				if (%Player.ShengWangShop2 > 0) %Conv.AddOption(%Player.ShengWangShop2, %Player.ShengWangShop2);

				//echo("%Player.ShengWangShop1===" @ %Player.ShengWangShop1);
				//echo("%Player.ShengWangShop2===" @ %Player.ShengWangShop2);
			case 410010137://������
				%ShengWangJieDuan[1] = 50000;
				%ShengWangJieDuan[2] = 580000;
				%ShengWangJieDuan[3] = 2000000;
				%ShengWangJieDuan[4] = 6000000;
				%ShengWangJieDuan[5] = 15000000;
				%ShengWang = GetPrestige(%Player, 1, 3);
				if (%ShengWang >= %ShengWangJieDuan[1] && %ShengWang < %ShengWangJieDuan[2]){ %Player.ShengWangShop1 = 410050; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[2] && %ShengWang < %ShengWangJieDuan[3]){ %Player.ShengWangShop1 = 410051; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[3] && %ShengWang < %ShengWangJieDuan[4]){ %Player.ShengWangShop1 = 410052; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[4] && %ShengWang < %ShengWangJieDuan[5]){ %Player.ShengWangShop1 = 410053; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[5]){ %Player.ShengWangShop1 = 410054; %Player.ShengWangShop2 = 0; }
				else { %Player.ShengWangShop1 = 410050; %Player.ShengWangShop2 = -1; }

				if (%Player.ShengWangShop1 > 0) %Conv.AddOption(%Player.ShengWangShop1, %Player.ShengWangShop1);
				if (%Player.ShengWangShop2 > 0) %Conv.AddOption(%Player.ShengWangShop2, %Player.ShengWangShop2);
			//case 410010135://������
			//	%ShengWangJieDuan[1] = 50000;
			//	%ShengWangJieDuan[2] = 580000;
			//	%ShengWangJieDuan[3] = 2800000;
			//	%ShengWangJieDuan[4] = 6000000;
			//	%ShengWangJieDuan[5] = 15000000;
			//	%ShengWang = GetPrestige(%Player, 1, 5);
			//	if (%ShengWang >= %ShengWangJieDuan[1] && %ShengWang < %ShengWangJieDuan[2]) { %Player.ShengWangShop1 = 410055; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
			//	else if (%ShengWang >= %ShengWangJieDuan[2] && %ShengWang < %ShengWangJieDuan[3]) { %Player.ShengWangShop1 = 410056; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
			//	else if (%ShengWang >= %ShengWangJieDuan[3] && %ShengWang < %ShengWangJieDuan[4]) { %Player.ShengWangShop1 = 410057; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
			//	else if (%ShengWang >= %ShengWangJieDuan[4] && %ShengWang < %ShengWangJieDuan[5]) { %Player.ShengWangShop1 = 410058; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
			//	else if (%ShengWang >= %ShengWangJieDuan[5]) { %Player.ShengWangShop1 = 410059; %Player.ShengWangShop2 = 0; }
			//	else { %Player.ShengWangShop1 = 410055; %Player.ShengWangShop2 = -1; }
			//
			//	if (%Player.ShengWangShop1 > 0) %Conv.AddOption(%Player.ShengWangShop1, %Player.ShengWangShop1);
			//	if (%Player.ShengWangShop2 > 0) %Conv.AddOption(%Player.ShengWangShop2, %Player.ShengWangShop2);
			case 411010004://������
				%Conv.AddOption(410206, 410206);//�����̵�

				%ShengWangJieDuan[1] = 50000;
				%ShengWangJieDuan[2] = 580000;
				%ShengWangJieDuan[3] = 2800000;
				%ShengWangJieDuan[4] = 6000000;
				%ShengWangJieDuan[5] = 15000000;
				%ShengWang = GetPrestige(%Player, 2, 1);
				if (%ShengWang >= %ShengWangJieDuan[1] && %ShengWang < %ShengWangJieDuan[2]) { %Player.ShengWangShop1 = 410220; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[2] && %ShengWang < %ShengWangJieDuan[3]) { %Player.ShengWangShop1 = 410221; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[3] && %ShengWang < %ShengWangJieDuan[4]) { %Player.ShengWangShop1 = 410222; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[4] && %ShengWang < %ShengWangJieDuan[5]) { %Player.ShengWangShop1 = 410223; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[5]) { %Player.ShengWangShop1 = 410224; %Player.ShengWangShop2 = 0; }
				else { %Player.ShengWangShop1 = 410220; %Player.ShengWangShop2 = -1; }

				if (%Player.ShengWangShop1 > 0) %Conv.AddOption(%Player.ShengWangShop1, %Player.ShengWangShop1);
				if (%Player.ShengWangShop2 > 0) %Conv.AddOption(%Player.ShengWangShop2, %Player.ShengWangShop2);

				//echo("%Player.ShengWangShop1===" @ %Player.ShengWangShop1);
				//echo("%Player.ShengWangShop2===" @ %Player.ShengWangShop2);
			case 411020010://�׻�կ
				%ShengWangJieDuan[1] = 50000;
				%ShengWangJieDuan[2] = 580000;
				%ShengWangJieDuan[3] = 2800000;
				%ShengWangJieDuan[4] = 6000000;
				%ShengWangJieDuan[5] = 15000000;
				%ShengWang = GetPrestige(%Player, 2, 2);
				if (%ShengWang >= %ShengWangJieDuan[1] && %ShengWang < %ShengWangJieDuan[2]) { %Player.ShengWangShop1 = 410320; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[2] && %ShengWang < %ShengWangJieDuan[3]) { %Player.ShengWangShop1 = 410321; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[3] && %ShengWang < %ShengWangJieDuan[4]) { %Player.ShengWangShop1 = 410322; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[4] && %ShengWang < %ShengWangJieDuan[5]) { %Player.ShengWangShop1 = 410323; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[5]) { %Player.ShengWangShop1 = 410324; %Player.ShengWangShop2 = 0; }
				else { %Player.ShengWangShop1 = 410320; %Player.ShengWangShop2 = -1; }

				if (%Player.ShengWangShop1 > 0) %Conv.AddOption(%Player.ShengWangShop1, %Player.ShengWangShop1);
				if (%Player.ShengWangShop2 > 0) %Conv.AddOption(%Player.ShengWangShop2, %Player.ShengWangShop2);
			case 411030015://���ƶ�
				%ShengWangJieDuan[1] = 50000;
				%ShengWangJieDuan[2] = 580000;
				%ShengWangJieDuan[3] = 2800000;
				%ShengWangJieDuan[4] = 6000000;
				%ShengWangJieDuan[5] = 15000000;
				%ShengWang = GetPrestige(%Player, 2, 3);
				if (%ShengWang >= %ShengWangJieDuan[1] && %ShengWang < %ShengWangJieDuan[2]) { %Player.ShengWangShop1 = 410420; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[2] && %ShengWang < %ShengWangJieDuan[3]) { %Player.ShengWangShop1 = 410421; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[3] && %ShengWang < %ShengWangJieDuan[4]) { %Player.ShengWangShop1 = 410422; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[4] && %ShengWang < %ShengWangJieDuan[5]) { %Player.ShengWangShop1 = 410423; %Player.ShengWangShop2 = %Player.ShengWangShop1 + 1; }
				else if (%ShengWang >= %ShengWangJieDuan[5]) { %Player.ShengWangShop1 = 410424; %Player.ShengWangShop2 = 0; }
				else { %Player.ShengWangShop1 = 410420; %Player.ShengWangShop2 = -1; }

				if (%Player.ShengWangShop1 > 0) %Conv.AddOption(%Player.ShengWangShop1, %Player.ShengWangShop1);
				if (%Player.ShengWangShop2 > 0) %Conv.AddOption(%Player.ShengWangShop2, %Player.ShengWangShop2);
		}						 
	}
	//echo("=======================================================");
	//echo("State===" @ %State);
	//echo("%Player.ShengWangShop1===" @ %Player.ShengWangShop1);
	//echo("%Player.ShengWangShop2===" @ %Player.ShengWangShop2);
	if ((%State >= 400000)&&(%State < 500000))
	{
		if (%Player.ShengWangShop2 == %State)
		{
			SendOneScreenMessage(2, "������������", %Player);
			NpcOnTrigger(%Conv, %Npc, %Player, 0, -1);
		}
		else if (%Player.ShengWangShop2 == -1 && %Player.ShengWangShop1 == %State)
		{
			SendOneScreenMessage(2, "������������", %Player);
			NpcOnTrigger(%Conv, %Npc, %Player, 0, -1);
		}
		else
		{
			%Conv.SetType(4);
			OpenNpcShop(%Player, %State);
		}
	}
}
//���������Խ���
function NpcOpenJob(%Npc,%Player,%State,%Conv)
{
	%PlayerID = %Player.GetPlayerID();
	%NpcID = %Npc.GetDataID();
	if (%State  == 0)
	{
		//----------------------ɸѡ���NPC�����Ƿ���������������ѡ��----------------------------
		%NpcA_Mid = GetStartNpcMission(%NpcID);//������ȡ������
		%NpcX_Mid = GetMidTalkNpcMission(%NpcID);	//���ڽ���������
		%NpcZ_Mid = GetEndNpcMission(%NpcID);//������ɵ�����
		%NpcA_Mid_MaxNum = GetWordCount(%NpcA_Mid);//������ȡ����������
		%NpcZ_Mid_MaxNum = GetWordCount(%NpcZ_Mid);//������ɵ���������
		%NpcX_Mid_MaxNum = GetWordCount(%NpcX_Mid);//���ڽ�������������
		for (%a = 0; %a < %NpcA_Mid_MaxNum; %a++)
		{
			%Mid = GetWord(%NpcA_Mid,%a);//��ȡ����ID
			if (!Mission_Begin_SeeOption(%Player,%Mid))//�Ƿ���ʾ(�����ж�)
				if (CanDoThisMission(%Player,%Mid,1,0,0) $= "")	//�Ƿ���ʾ(�����ж�)
				{
					%Recrod = 1;
					break;
				}
		}
		if (%Recrod != 1)
		{
			for (%z = 0; %z < %NpcZ_Mid_MaxNum; %z++)
			{
				%Mid = GetWord(%NpcZ_Mid,%z);//��ȡ����ID
				if (%Player.IsAcceptedMission(%Mid))
				{
					%Recrod = 1;
					break;
				}
			}
		}
		if (%Recrod != 1)
		{
			for (%z = 0; %z < %NpcX_Mid_MaxNum; %z++)
			{
				%Mid = GetWord(%NpcX_Mid,%z);//��ȡ����ID
				if (%Player.IsAcceptedMission(%Mid))
				{
					%Recrod = 1;
					break;
				}
			}
		}
		//-----------------------------------------------------------------------------------------------
		switch (%Npc.GetDataID())
		{
			case 410010001:
				if ($SL_CityAttack_bActive == 1)
				{
					if (%Recrod == 1)
						%Conv.AddOption(100085, 100085);
					else
						return NpcOpenJob(%Npc, %Player, 100085, %Conv);
				}
			case 410010108://��Ʒ��ʷ
				if (%Recrod == 1)
					%Conv.AddOption(100016,100016);
				else
					return NpcOpenJob(%Npc,%Player,100016,%Conv);

			case 410010123://��ʯ�������
				if (%Recrod == 1)
					%Conv.AddOption(100022,100022);
				else
					return NpcOpenJob(%Npc,%Player,100022,%Conv);

			case 410010122://װ����������
				if (%Recrod == 1)
					%Conv.AddOption(100023,100023);
				else
					return NpcOpenJob(%Npc,%Player,100023,%Conv);

			case 410010121://װ��ǿ������
				if (%Recrod == 1)
					%Conv.AddOption(100024,100024);
				else
					return NpcOpenJob(%Npc,%Player,100024,%Conv);

			case 410010102://������
				%Conv.AddOption(100025,100025);

			case 411010009://������
				%Conv.AddOption(100025,100025);

			case 411020002://������
				%Conv.AddOption(100025,100025);

			case 410100052://������
				%Conv.AddOption(100025,100025);
			case 411030009://������
				%Conv.AddOption(100025, 100025);
			case 410010124://����̨
				if (%Recrod == 1)
					%Conv.AddOption(100027,100027);
				else
					return NpcOpenJob(%Npc,%Player,100027,%Conv);

			case 410010125://����¯
				if (%Recrod == 1)
					%Conv.AddOption(100028,100028);
				else
					return NpcOpenJob(%Npc,%Player,100028,%Conv);

			case 410010126://����̨
				if (%Recrod == 1)
					%Conv.AddOption(100029,100029);
				else
					return NpcOpenJob(%Npc,%Player,100029,%Conv);

			case 410010127:	//��⿶�
				if (%Recrod == 1)
					%Conv.AddOption(100030,100030);
				else
					return NpcOpenJob(%Npc,%Player,100030,%Conv);

			case 410010128://�Ʒ���
				if (%Recrod == 1)
					%Conv.AddOption(100031,100031);
				else
					return NpcOpenJob(%Npc,%Player,100031,%Conv);

			case 410010139://����̨
				if (%Recrod == 1)
					%Conv.AddOption(100032,100032);
				else
					return NpcOpenJob(%Npc,%Player,100032,%Conv);
			case 410010120://������ʦ
				if (%Recrod == 1)
					%Conv.AddOption(100075,100075);
				else
					return NpcOpenJob(%Npc,%Player,100075,%Conv);
			case 410010142://װ������
				if (%Recrod == 1)
					%Conv.AddOption(100077,100077);
				else
					return NpcOpenJob(%Npc,%Player,100077,%Conv);
			case 410010143://��ʯ�ϳ�
				if (%Recrod == 1)
					%Conv.AddOption(100076,100076);
				else
					return NpcOpenJob(%Npc,%Player,100076,%Conv);
			case 411010010://1101 ���ͼ���
				%Conv.AddOption(100026,100026);
			case 411020003://1102 ���ͼ���
				%Conv.AddOption(100026,100026);
			case 411030004://1103 ���ͼ���
				%Conv.AddOption( 100026, 100026 );

			case 410010106:
				if (%Recrod == 1)
					%Conv.AddOption(100078,100078);
				else
					return NpcOpenJob(%Npc,%Player,100078,%Conv);
			case 410010144://�����ѧϰ
				if (%Recrod == 1)
					%Conv.AddOption(100082,100082);
				else
					return NpcOpenJob(%Npc,%Player,100082,%Conv);
			case 410010145:
				return NpcOpenJob(%Npc,%Player,100021,%Conv);
			case 410010101:
				%Conv.AddOption(100021,100021);
		}
	}
	switch (%Npc.GetDataID())
	{
		case 410010107://�������
			FamilyDialog(%Npc,%Player,%State,%Conv);
	}
	switch (%State)
	{
		case 100021:
			%Player.OpenBank(0);
		case 100016://�콱
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,1);	//ͨѶ�ͻ���
		case 100022://��ʯ
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,2);	//ͨѶ�ͻ���
			HelpDirectByIndex(%PlayerID,28);	//�򿪱���
		case 100023://����
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,3);	//ͨѶ�ͻ���
			HelpDirectByIndex(%PlayerID,28);
		case 100024://ǿ��
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,4);	//ͨѶ�ͻ���
			HelpDirectByIndex(%PlayerID,28);
		case 100025://����
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,5);	//ͨѶ�ͻ���
		case 100026:
			%Level = %Player.GetLevel();
			%MapId = GetZoneID();
			%Conv.Settype(4);
			if (%Level >= $SL_XuanShangJiXiong_Level[%MapId])
				HelpDirectByIndex(%PlayerID,8);	//ͨѶ�ͻ���
			else
			{
				SendOneScreenMessage(2,$SL_XuanShangJiXiong_Level[%MapId] @ "�����ϲſ��Խ�ȡ����ͼ���ͼ�������",%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ $SL_XuanShangJiXiong_Level[%MapId] @ "�����ϲſ��Խ�ȡ����ͼ���ͼ�������" @ "</t>",%Player);
			}
		case 100027://������̨
			%Conv.Settype(4);
			ServerOnSptAction(%PlayerID,1,14);
		case 100028://������¯
			%Conv.Settype(4);
			ServerOnSptAction(%PlayerID,5,14);
		case 100029://�򿪷���̨
			%Conv.Settype(4);
			ServerOnSptAction(%PlayerID,2,14);
		case 100030://����⿶�
			%Conv.Settype(4);
			ServerOnSptAction(%PlayerID,6,14);
		case 100031://���Ʒ���
			%Conv.Settype(4);
			ServerOnSptAction(%PlayerID,4,14);
		case 100032://������̨
			%Conv.Settype(4);
			ServerOnSptAction(%PlayerID,3,14);
		case 100075://�򿪼�������
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,9);	//ͨѶ�ͻ���
			HelpDirectByIndex(%PlayerID,28);
		case 100076://����ʯ�ϳɽ���
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,10);	//ͨѶ�ͻ���
			HelpDirectByIndex(%PlayerID,28);
		case 100077://��װ���������
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,13);	//ͨѶ�ͻ���
		case 100078://��Ԫ�����׽���
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,19);	//ͨѶ�ͻ���
		case 100082:
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,24);	//ͨѶ�ͻ���
		case 100085:
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,27);	//ͨѶ�ͻ���
	}
}
//���������ԶԻ����޽���
function NpcCanDoJob(%Npc,%Player,%State,%Conv)
{
	if (%State  == 0)
	{
		switch (%Npc.GetDataID())
		{
			case 410100006:
				if (%Player.IsAcceptedMission(20149) && %player.getmissionflag(20149,10300) == 410101020 && %player.getmissionflag(20149,3300) == 0 && !%Player.Isschbuff(2021))
					%Conv.AddOption(100015,100015);
			case 410010205:
				%Conv.AddOption(100017,100017);
				%Conv.AddOption(100018,100018);

			case 410010216:
				%Conv.AddOption(100079,100079);
		}
	}
	switch (%Npc.GetDataID())
	{
		case  410010113://˫������
			NpcDiaLog_410010113(%Npc,%Player,%State,%Conv);//ÿ��˫��������ȡ
		case 410010114://����	ɾ�Ŵ���
			DeletePlayer(%Npc,%Player,%State,%Conv);
		case 411190023://��ħ�ǹ���Ա
			NpcDiaLog_411190023(%Npc, %Player, %State, %Conv);
			//case 410100001:
		case 410010134://ʹ�ߡ�ս
			%Player.MainType = 1;
			%Player.SubType = 1;
			NpcDiaLog_410010134_410010137(%Npc, %Player, %State, %Conv);
		case 410010136://ʹ�ߡ���
			%Player.MainType = 1;
			%Player.SubType = 2;
			NpcDiaLog_410010134_410010137(%Npc, %Player, %State, %Conv);
		case 410010137://ʹ�ߡ���
			%Player.MainType = 1;
			%Player.SubType = 3;
			NpcDiaLog_410010134_410010137(%Npc, %Player, %State, %Conv);
		case 411010004:	//���ɹȣ�		����
			%Player.MainType = 2;
			%Player.SubType = 1;
			NpcDiaLog_410010134_410010137(%Npc, %Player, %State, %Conv);
		case 411020010:	//��ɽѩ����	��
			%Player.MainType = 2;
			%Player.SubType = 2;
			NpcDiaLog_410010134_410010137(%Npc, %Player, %State, %Conv);
		case 411030015:	//������		���
			%Player.MainType = 2;
			%Player.SubType = 3;
			NpcDiaLog_410010134_410010137(%Npc, %Player, %State, %Conv);

	}
	switch (%State)
	{
		case 100015:
			GoToNextMap(%Player,1305,"");
		case 100017:
			%Conv.Settext(100019);
			%Conv.AddOption(4,0);
		case 100018:
			%Conv.Settext(100020);
			%Conv.AddOption(4,0);
		case 100079:
			%Conv.Settext(100080);
			%Conv.AddOption(100081,100081);
		case 100081:
			%Conv.Settype(4);
			OnSptActionEvent_S(%Player,35,0);
	}
}
//Npc���͹���
function NpcTransportObject(%Npc,%Player,%State,%Conv)
{
	//echo( "%State=== " @ %State );
	%NpcID = %Npc.GetDataID();
	
	if (%State == 0)
	{
		if ($Transport_Npc[%NpcID] !$= "")
		{
			%Number = GetWordCount($Transport_Npc[%NpcID],";");
			for (%i = 0; %i < %Number; %i++)
			{
				%MsgList =  GetWord($Transport_Npc[%NpcID],%i,";");
				%WanttoMapID = GetWord(%MsgList,0);
				//%NeedMoney = GetWord( %MsgList, 1 );
				//%LevelMin = GetWord( %MsgList, 2 );
				//%LevelMax = GetWord( %MsgList, 3 );
				if (strlen(%WanttoMapID) == 4)
					%WanttoMapID = "5" @ %WanttoMapID @ "0100";
				else if (strlen(%WanttoMapID) == 9)
					%WanttoMapID = "5" @ GetSubStr(%WanttoMapID,1,8);
				else break;

				if (GetTriggerData("8" @ GetSubStr(%WanttoMapID,1,8),0) > 0)
					%Conv.AddOption(%WanttoMapID,%WanttoMapID);

			}
		}
	}
	if (strlen(%State) == 9 && GetSubStr(%State,0,1) $= "5")
	{
		%Conv.SetType(4);
		%TarGetID = "8" @ GetSubStr(%State,1,8);
		//echo( "%TarGetID===" @ %TarGetID );
		//echo( "$CalculationNpcTransport[ " @ %NpcID @ "," @  %TarGetID @ "," @ " 1 ] ===" @ $CalculationNpcTransport[ %NpcID, %TarGetID, 1 ] );
		if ($CalculationNpcTransport[%NpcID,%TarGetID,1] $= "")
		{
			%Number = GetWordCount($Transport_Npc[%NpcID],";");
			//echo( "$Transport_Npc[ %NpcID ]==" @ $Transport_Npc[ %NpcID ]  @ "   " @ %Number );
			for (%i = 0; %i < %Number; %i++)
			{
				%MsgList =  GetWord($Transport_Npc[%NpcID],%i,";");
				%WanttoMapID = GetWord(%MsgList,0);
				%NeedMoney = GetWord(%MsgList,1);
				%LevelMin = GetWord(%MsgList,2);
				%LevelMax = GetWord(%MsgList,3);
				//echo( "%MsgList===" @ %MsgList );
				//echo( "%WanttoMapID===" @ %WanttoMapID );
				//echo( "%NeedMoney===" @ %NeedMoney );
				//echo( "%LevelMin===" @ %LevelMin );
				//echo( "%LevelMax===" @ %LevelMax );
				if (strlen(%WanttoMapID) == 4)
					%WanttoMapID = "8" @ %WanttoMapID @ "0100";
				else if (strlen(%WanttoMapID) == 9)
					%WanttoMapID = "8" @ GetSubStr(%WanttoMapID,1,8);

				if (%WanttoMapID $= %TarGetID)
				{
					$CalculationNpcTransport[%NpcID,%TarGetID,1] = %NeedMoney;
					$CalculationNpcTransport[%NpcID,%TarGetID,2] = %LevelMin;
					$CalculationNpcTransport[%NpcID,%TarGetID,3] = %LevelMax;
					break;
				}
			}
		}
		//echo("===" @ $CalculationNpcTransport[ %NpcID, %TarGetID, 1 ] );
		//echo("===" @ $CalculationNpcTransport[ %NpcID, %TarGetID, 2 ] );
		//echo("===" @ $CalculationNpcTransport[ %NpcID, %TarGetID, 3 ] );

		%Level = %Player.GetLevel();
		if (%Level < $CalculationNpcTransport[%NpcID,%TarGetID,2])
			%Text = "������͵ȼ�����" @ $CalculationNpcTransport[%NpcID,%TarGetID,2] @ "��";
		else if (%Level > $CalculationNpcTransport[%NpcID,%TarGetID,3])
			%Text = "������ߵȼ�����" @ $CalculationNpcTransport[%NpcID,%TarGetID,3] @ "��";
		else if (%Player.getmoney(2) < $CalculationNpcTransport[%NpcID,%TarGetID,1])
			%Text = "��Ǯ���㣬��Ҫ" @ $CalculationNpcTransport[%NpcID,%TarGetID,1] @ "ͭ���ͷ�";
		else
			%Text = "";
		if (%Text $= "")
		{
			%Player.ReduceMoney($CalculationNpcTransport[%NpcID,%TarGetID,1],2,4,%NpcID);
			GoToNextMap(%Player,"8" @ GetSubStr(%State,1,8),"");
		}
		else
		{
			SendOneScreenMessage(2,%Text,%Player);
			SendOneChatMessage($chatMsg_System,"<t>" @ %Text @ "</t>",%Player);
		}
	}
}

//���е㹦��
function NpcFly(%Npc,%Player,%State,%Conv)
{	//
	//����·����11030001
	//	������811030100
	//	��������811030101
	//���е㹦��
	//switch ( %State )
	//{
	//	case 310001:%Conv.SetType( 4 ); FlyMeToTheMoon( %Player, 11030001, 700010000 );
	//}
}
//���ָ��ְ���
function NewPlayerHelp(%Npc,%Player,%State,%Conv)
{

}

//�뿪����ͳһ����
function leave_CopyMap_Operate(%Npc,%Player,%State,%Conv)
{

}


//ɾ����ɫ
function DeletePlayer(%Npc,%Player,%State,%Conv)
{
	switch (%State)
	{
		case 0:
			%Conv.SetText(100010);	//ɾ����ɫ˵��
			%Conv.AddOption(100009,100009);  //ɾ����ɫ
			if (IfApplyDeletePlayer(%Player.GetPlayerID()))
				%Conv.AddOption(100011,100011);  //ȡ��ɾ����ɫ

		case 100009:
			if (!IfApplyDeletePlayer(%Player.GetPlayerID()))
			{
				%Conv.SetText(100012);	//ȷ��Ҫɾ����
				%Conv.AddOption(100009,100010);  //ɾ����ɫ
			}
			else
				%Conv.SetText(100013);	//���Ѿ�����ɾ��
			%Conv.AddOption(4,0);  //����
		case 100010:
			%Conv.SetType(4);
			switch (CanDeletePlayer(%Player.GetPlayerID()))
			{
				case 0:
					ConfirmDeletePlayer(%Player.GetPlayerID());	//0�ɹ�
					%Txt = "����ɹ�";
					SendOneScreenMessage(2,%Txt,%Player);
					SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
				default:
					SendWhyNoDeletePlayerMsg(%Player,CanDeletePlayer(%Player.GetPlayerID()));
			}

		case 100011:
			%Conv.SetType(4);
			CancelDeletePlayer(%Player.GetPlayerID());//ȡ��ɾ����ɫѡ��
	}
}

function SendWhyNoDeletePlayerMsg(%Player,%Why)
{
	//echo( "%Why ===" @ %Why );
	switch (%Why)
	{
		//case 1:	%Txt = "��ǰ��ɫ������";
		case 2: %Txt = "���Ľ�ɫ����ɾ��ʱ��δ��3��";
		case 3: %Txt = "����ǰ��ɫ���ܴ��ڰ�����";
		case 4: %Txt = "����ǰ��ɫ���ܴ��ڽ����";
		case 5: %Txt = "����ǰ��ɫ���ܴ�����Ե��";
		case 6: %Txt = "����ǰ��ɫ���ܴ���ʦͽ��ϵ��";
		case 7: %Txt = "����ǰ��ɫ���ܴ���ʦͽ��ϵ��";
		case 8: %Txt = "����ǰ��ɫ����ӵ������";
		case 9: %Txt = "����ǰ��ɫ�е�������������״̬";
		case 10:%Txt = "����ǰ��ɫ����������������״̬";
		case 11:%Txt = "����ǰ��ɫ��������������״̬";
		case 12:%Txt = "����ǰ��ɫ�л�������������״̬";
		default:%Txt = "δ֪ԭ���޷�ɾ����ɫ";
	}
	SendOneScreenMessage(2,%Txt,%Player);
	SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
}

//%NpcID = 410010008  %State==0 %NpcName = �Ϲ�ʫ��  %Pos == 16.0388 -37.1326 182.003

function NpcDiaLog_410010134_410010137(%Npc, %Player, %State, %Conv)
{
	switch (%State)
	{
		case 0:
			%Conv.AddOption(100087, 100087);
		case 100087:
			%Conv.Settext(100088);
			//%Conv.AddOption(100089, 100089);//����1��
			%Conv.AddOption(100090, 100090);//���׽���
			%Conv.AddOption(100091, 100091);//���׽�ש
			%Conv.AddOption(100100, 100100);//����һ������
			%Conv.AddOption(100101, 100101);//���׶�������
			%Conv.AddOption(100102, 100102);//������������
			%Conv.AddOption(100103, 100103);//�����ļ�����
			%Conv.AddOption(100104, 100104);//�����弶����
			%Conv.AddOption(100105, 100105);//������������
			%Conv.AddOption(100106, 100106);//�����߼�����
			%Conv.AddOption(100107, 100107);//���װ˼�����
			//%Conv.AddOption(100108, 100108);//���׾ż�����
			//%Conv.AddOption(100109, 100109);//����ʮ������

		case 100089://����1��
			%Conv.Settext(100092);
			%Conv.AddOption(100093, 100093);
		case 100093:
			%retuenState = 100089;
			if (%Player.GetMoney(2) < 10000)
			{
				SendOneScreenMessage(2, "���Ľ�Ҳ���", %Player);
				SendOneChatMessage($chatMsg_System, "<t>���Ľ�Ҳ��㡣</t>", %Player);
			}
			else
			{
				%Player.Reducemoney(10000, 2, 5, 4105);
				AddPrestige(%Player, $PrestigeStageActID[%Player.MainType, %Player.SubType], 300);
			}
		case 100090://���׽���
			%Conv.Settext(100094);
			%Conv.AddOption(100095, 100095);
			%Conv.AddOption(100096, 100096);
			%Conv.AddOption(4, 100087);
		case 100095:
			%retuenState = 100090;
			%Itemid[1] = 105105303;
			%ItemNum[1] = 1;
		case 100096:
			%retuenState = 100090;
			%Itemid[1] = 105105303;
			%ItemNum[1] = 999;

		case 100091://���׽�ש
			%Conv.Settext(100097);
			%Conv.AddOption(100098, 100098);
			%Conv.AddOption(100099, 100099);
			%Conv.AddOption(4, 100087);
		case 100098:
			%retuenState = 100091;
			%Itemid[1] = 105105304;
			%ItemNum[1] = 1;
		case 100099:
			%retuenState = 100091;
			%Itemid[1] = 105105304;
			%ItemNum[1] = 999;
	}
	if (%State == 100099 || %State == 100098 || %State == 100096 || %State == 100095)//���׽����ͽ�ש
	{
		if (%ItemNum[1] == 999)
			%ItemNum[1] = %Player.GetItemCount(%Itemid[1]);

		if (%Itemid[1] > 0 && %ItemNum[1] > 0)
		{
		
			if (%Player.GetItemCount(%Itemid[1] < %ItemNum[1]))
			{
				SendOneScreenMessage(2, "����"@ GetItemdata(%Itemid[1]) @"����", %Player);
				SendOneChatMessage($chatMsg_System, "<t>����</t>" @ GetItemdata(%Itemid[1]) @ "<t>���㡣</t>", %Player);
			}
			else
			{
				%Player.PutItem(%Itemid[1], -%ItemNum[1]);
				if (%Player.Additem(5, 4105))
					AddPrestige(%Player, $PrestigeStageActID[%Player.MainType, %Player.SubType], $MenPaiShengWangJuanXian[%Itemid[1]] * %ItemNum[1]);
			}
		}
	}
	if (%State >= 100100 && %State <= 100109)
	{
		%Conv.Settext(%State + 10);
		%Conv.AddOption(%State + 20, %State + 20);
		%Conv.AddOption(4, 100087);
	}
	if (%State >= 100120 && %State <= 100129)
	{
		%retuenState = 100087;
		%Level = %State - 100120;
		for (%i = 1; %i <= 4; %i++)
		{
			%ItemID = 105109400 + %Level * 10 + %i;
			%ItemNum = %Player.GetItemCount(%ItemID);
			if (%ItemNum > 0)
			{
				%Player.PutItem(%ItemID, -%ItemNum);
				if (%Player.Additem(5, 4105))
					AddPrestige(%Player, $PrestigeStageActID[%Player.MainType, %Player.SubType], $MenPaiShengWangJuanXian[%ItemID] * %ItemNum);
			}
		}
	}
	if (%retuenState > 0)
		NpcDiaLog_410010134_410010137(%Npc, %Player, %retuenState, %Conv);
}