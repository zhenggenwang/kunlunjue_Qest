//function MissionxxxxxDialog( %Npc, %Player, %Mid, %Tid )//ͨ���������ģ��
//{
//	//echo( "%Tid ==" @ %Tid );
//	switch ( %Tid )
//	{
//
//		case 10001:	return "<t>�ϻ�</t><b/>"; //����Ŀ��
//		case 10002:	return "<t>�ϻ�</t><b/>"; //������԰�
//		case 10005:	return "<t>�ϻ�</t><b/>"; //�������ʱ�԰�
//
//		case 20001:return "<t></t><b/>";//������ǰNPC�ķϻ�
//		case 21001:return "<t></t><b/>";//������ǰ��ҵķϻ�
//
//		case 30001:return "<t>1</t><b/>";//������ǰNPC�ķϻ�
//		case 31001:return "<t>1</t><b/>";//������ǰ��ҵķϻ�
//
//		case 30002:return "<t>2</t><b/>";//������ǰNPC�ķϻ�
//		case 31002:return "<t>2</t><b/>";//������ǰ��ҵķϻ�
//	}
//	if ( %Tid <= 20000 || %Tid >= 40000 )
//		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
//	else
//		return "";
//}
//����������������������������������������������Ի���������������������������������
//��������������������������������֧�ߡ�����Ի���������������������������������
//������������������������������������ܡ�����Ի���������������������������������
//�����������������������������������ͼ��ס�����Ի���������������������������������


//����������������������������������������������Ի���������������������������������
function Mission20001Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,1); } //����֮��
function Mission20002Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,2); } //�һ�֮��
function Mission20003Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,3); } //��������
function Mission20004Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,4); } //��������
function Mission20005Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,5); } //��װ��ҩ
function Mission20006Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,6); } //����֮�顤һ
function Mission20007Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,7); } //����֮�顤��
function Mission20008Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,8); } //������ħ
function Mission20009Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,1); } //����֮��
function Mission20010Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,2); } //�һ�֮��
function Mission20011Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,3); } //��������
function Mission20012Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,4); } //��������
function Mission20013Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,5); } //��װ��ҩ
function Mission20014Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,6); } //����֮�顤һ
function Mission20015Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,7); } //����֮�顤��
function Mission20016Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,8); } //������ħ
function Mission20017Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,1); } //����֮��
function Mission20018Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,2); } //�һ�֮��
function Mission20019Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,3); } //��������
function Mission20020Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,4); } //��������
function Mission20021Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,5); } //��װ��ҩ
function Mission20022Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,6); } //����֮�顤һ
function Mission20023Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,7); } //����֮�顤��
function Mission20024Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,8); } //������ħ
function Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,%Optype)
{
	switch (%Tid)
	{
		case 10001:
			switch (%Optype)//����Ŀ��
			{
				case 1:return "<t>ǰ������֮�زɼ�����֮˪�������</t><b/>";
				case 2:return "<t>ǰ������֮�زɼ��һ�֮�׽�������</t><b/>";
				case 3:return "<t>ǰ������֮�ػ��ܺ�˪��</t><b/>";
				case 4:return "<t>ǰ������֮�ػ���������</t><b/>";
				case 5:return "<t>�ɼ��ɲݽ�����ǧѰ</t><b/>";
				case 6:return "<t>�ռ���ʯ����ʯ����ʯ����һ��</t><b/>";
				case 7:return "<t>�ռ���ʯ����ʯ����ʯ���</t><b/>";
				case 8:return "<t>���ܺ���֮�ꡢ����֮�ꡢ�ػ�֮��</t><b/>";
			}
		case 10002:	//������԰�
			switch (%Optype)
			{
				case 1:return "<t>����֮��ʢ������֮˪����������Ϊ�������ܹ���ɼ�һЩ���ͺ���</t><b/>";
				case 2:return "<t>����֮��ʢ���һ�֮�ף���������Ϊ�������ܹ���ɼ�һЩ���ͺ���</t><b/>";
				case 3:return "<t>����֮�ؾ������ֺ�˪�ᣬ��Ҫ��ȡ����֮�ǣ����뽫�ι������</t><b/>";
				case 4:return "<t>����֮�ؾ������������棬��Ҫ��ȡ�һ�֮�ף����뽫�ι������</t><b/>";
				case 5:return "<t>�����֮���׺�������������Ϊ��Ҫ�е�ҩ���巽�ɽ��룬������ҪһЩ���嵤ҩ����Ҫ���ɲ�</t><b/>";
				case 6:return "<t>���嵤ҩ�����ɲݲ�������Ҫע��������ʯ���������ɼ�Ч</t><b/>";
				case 7:return "<t>������ʯ��ã������뿪ʥ�������ͱ��΢������Ҫ�ɼ�����������������</t><b/>";
				case 8:return "<t>�˵������������ɵ���ħռɽΪ��������Щ���ﶼ��Ϊ���У�ʵ���ǿɶ�</t><b/>";
			}
		case 10005:	return "<t>������������ˡ�</t><b/>";
		case 910:
			%Level = %Player.GetLevel();
			if (%Level < 30) %LevelXiShu = 0.5;
			else if (%Level < 40) %LevelXiShu = 1.2;
			else if (%Level < 50) %LevelXiShu = 1.2;
			else if (%Level < 60) %LevelXiShu = 1.6;
			else if (%Level < 70) %LevelXiShu = 2.0;
			else %LevelXiShu = 2.2;

			if (%Level < 25) %LVExp = 0;
			else if (%Level < 40) %LVExp = 20000;
			else if (%Level < 50) %LVExp = 30000;
			else if (%Level < 60) %LVExp = 50000;
			else if (%Level < 70) %LVExp = 80000;
			else if (%Level < 80) %LVExp = 100000;
			else if (%Level < 90) %LVExp = 120000;
			else  %LVExp = 120000;

			switch (%Optype)//����Ŀ��
			{
				case 1://����֮��
					%LikeMonSterNum = 60;
					%PinZhiXiShu = 1;
				case 2://�һ�֮��
					%LikeMonSterNum = 60;
					%PinZhiXiShu = 1;
				case 3://�������
					%LikeMonSterNum = 100;
					%PinZhiXiShu = 1;
				case 4://��������
					%LikeMonSterNum = 100;
					%PinZhiXiShu = 1;
				case 5://��װ��ҩ
					for (%i = 0; %i <= 4; %i++)
					{
						if (GetSrc(%Player,%Src + %i) == 0)
						{
							%NowState = %i + 1;
							break;
						}
					}
					if (%NowState == 5)
					{
						%PinZhiXiShu = 1.1; //80ֻ1.0 80ֻ1.2 ƽ��1.1
						%LikeMonSterNum = 160;
					}
					else
					{
						%LikeMonSterNum = 80;
						switch (%NowState)
						{
							case 1:%PinZhiXiShu = 0.6;
							case 2:%PinZhiXiShu = 0.7;
							case 3:%PinZhiXiShu = 0.8;
							case 4:%PinZhiXiShu = 0.9;
						}
					}

				case 6://����֮�顤һ
					%LikeMonSterNum = 100;
					if (%Player.GetBuffCount(39906,1) >= 1) %PinZhiXiShu = 1;
					else if (%Player.GetBuffCount(39906,2) >= 1) %PinZhiXiShu = 2;
					else if (%Player.GetBuffCount(39906,3) >= 1) %PinZhiXiShu = 4;
					else %PinZhiXiShu = 1;
					%NeedMid = %Mid + 1;
					if (%player.IsAcceptedMission(%NeedMid))
					{
						%NeedFalg = %Player.GetMissionFlag(%NeedMid,10320);
						%Player.SetMissionFlag(%NeedMid,10320,%NeedFalg + %PinZhiXiShu);
						%Player.UpdateMission(%Mid);
					}

				case 7://����֮�顤��
					%LikeMonSterNum = 100;
					%NeedFalg = %Player.GetMissionFlag(%Mid,10330);
					//echo( getplayer( ).getmissionflag( 20007, 10330 ) );
					//echo( %Mid @ "    %NeedFalg===" @ %NeedFalg );
					%PinZhiXiShu = %NeedFalg * 0.3;
				case 8://������ħ
					%LikeMonSterNum = 300;
					%PinZhiXiShu = 1;
			}
			%MonSterExp = $Monster_Exp[%Level,1];
			%Exp = mfloor(%MonSterExp *(%LikeMonSterNum + %Level) * %PinZhiXiShu * %LevelXiShu + %LVExp);

			if (CanDoThisMission(%Player,%Mid,2,0,0) $= "")	//�Ƿ��Ѿ��ɽ���
				%Exp = $Get_Dialog_GeShi[31403] @ "���齱����</t>" @ %Exp @ "<b/>";
			else
				%Exp = $Get_Dialog_GeShi[31403] @ "���齱����</t>" @ %Exp @ "<t> + ???</t>" @ "<b/>";

			return $Get_Dialog_GeShi[31401] @ %Exp @ "</t>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}

function Mission20025Dialog(%Npc,%Player,%Mid,%Tid){ Mission20025_20027Dialog(%Npc,%Player,%Mid,%Tid); }
function Mission20026Dialog(%Npc,%Player,%Mid,%Tid){ Mission20025_20027Dialog(%Npc,%Player,%Mid,%Tid); }
function Mission20027Dialog(%Npc,%Player,%Mid,%Tid){ Mission20025_20027Dialog(%Npc,%Player,%Mid,%Tid); }
function Mission20025_20027Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>��ס�ü������������Ĳ��ϻ����������ʹ�</t><b/>";
		case 10002:	return "<t>�����������ޣ������ḯ����ȫ���Ǳ���������£�๿�ҩ��צ����������Ѽ�Щ����</t><b/>";
		case 10005:	return "<t>������������ˡ�</t><b/>";
		case 910:
			%ItemCount[1] = %Player.GetitemCount(108020006);//����֮��
			%ItemCount[2] = %Player.GetitemCount(108020007);//����֮�
			%ItemCount[3] = %Player.GetitemCount(108020008);//����֮צ
			if (%ItemCount[1] >= %ItemCount[2])
				%Count = %ItemCount[2];
			else
				%Count = %ItemCount[1];
			if (%ItemCount[3] <  %Count)
				%Count = %ItemCount[3];
			%Count = mfloor(%Count/10)*10;
			if (%Count < 10)
				%Count = 10;

			//%Player.ClearMissionItem( %Mid );	//���֮ǰ����Ʒ��ʾ
			//%Player.AddItemToMission( %Mid, 1, 108020208, 1 );	
			%Level = %Player.GetLevel();
			if (%Level < 30) %LevelXiShu = 0.5;
			else if (%Level < 40) %LevelXiShu = 1.0;
			else if (%Level < 50) %LevelXiShu = 1.2;
			else if (%Level < 60) %LevelXiShu = 1.6;
			else if (%Level < 70) %LevelXiShu = 2.0;
			else %LevelXiShu = 2.2;

			if (%Level < 25) %LVExp = 0;
			else if (%Level < 40) %LVExp = 20000;
			else if (%Level < 50) %LVExp = 30000;
			else if (%Level < 60) %LVExp = 50000;
			else if (%Level < 70) %LVExp = 80000;
			else if (%Level < 80) %LVExp = 100000;
			else if (%Level < 90) %LVExp = 120000;
			else  %LVExp = 120000;

			%LikeMonSterNum = 300 * %Count/10;
			%PinZhiXiShu = 1;

			%MonSterExp = $Monster_Exp[%Level,1];
			%Exp = %MonSterExp *(%LikeMonSterNum + %Level) * %PinZhiXiShu * %LevelXiShu + %LVExp;
			%Exp = mfloor(%Exp);
			%GeShi = 31405;
			%Txt = "<t>��ǰ�׶Σ�ÿ�ֲ��Ͽ۳� </t>" @ $Get_Dialog_GeShi[31409] @ %Count / 10 @ "</t><t> ������</t><b/>";
			%Exp = $Get_Dialog_GeShi[31403] @ "���齱����</t>" @ %Exp @ "<b/>";
			//echo( "%Exp===" @ %Exp );
			//%Item = $Get_Dialog_GeShi[ 31403 ] @ "�м��ʻ��������Ʒ��</t><b/>" @ GetFixedMissionItemText( %Mid );
			return $Get_Dialog_GeShi[31401] @ %Txt @ %Exp @ %Item @ "</t>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
//����������������������������������������������Ի���������������������������������

//��������������������������������֧�ߡ�����Ի���������������������������������
function Mission20201Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�ð�ֽ���ؼ���¼����</t><b/>";
		case 10002:	return "<t>Ҫ�������ؼ�û���⣬���ؼ�֮����֮����Ϊ���ӣ���Ҫƾ�ռ�סҲ̫�������ˣ��ô�ҲҪ����һ��ֽ������¼��</t><b/>";
		case 10005:	return "<t>�мǣ��˼�����Ҫʩ�����ϲ����ͷš��������㼸�����Ժ�ɾ�Ҫ���Լ���취��ȡ�ˡ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}

function Mission20205Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ǰ�����ɹ�Ѱ��������ʿ���������������</t><b/>";
		case 10002:	return "<t>���ٲ�����������ʿ��������䱦�������������ɹȡ�Ҫ����Ե������������ͨ�����Ŀ��飬�ͻ���һ������</t><b/>";
		case 10005:	return "<t>�����治����Ȼ��Ե���Ǿ�ѡһ��ϲ���������ɡ�</t><b/>";

		case 411:return $Icon[4] @ $Get_Dialog_GeShi[31495] @"<t>���ܿ���</t>";

		case 511:return "<t>��Ȼ�����Ǳ���Ե�֣�������ʵ����ͨ���ҵĿ��飬���ҽ�����һ�����</t><b/>";
		case 512:return "<t>��ֻ������ҵ���裬�����������ķ��������Ƿ��ܹ�սʤ����</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission20206Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>�������</t><b/>";
		case 10002:	return "<t>���ٲ�����������ʿ��������䱦�������������ɹȡ�Ҫ����Ե������������ͨ�����Ŀ��飬�ͻ���һ������</t><b/>";
		case 10005:	return "<t>�����治����Ȼ��Ե���Ǿ�ѡһ��ϲ���������ɡ�</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission20202Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>����͵��ɣҶ�Ľ��</t><b/>";
		case 10002:	return "<t>�����԰����������ֺö����������͵ʳ��ɣҶ�����ڻ�����Ӽ���������ܰ������СŮ�м�������</t><b/>";
		case 10005:	return "<t>�������ǰ��˴�æ�ˣ�СŮ�м���������</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission20203Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>���������һ�������</t><b/>";
		case 10002:	return "<t>��Щ��������Խ��Խ�����ˣ�͵����ʳҲ�����ˣ���͵�����ҵ������顣��ɵð��ҽ�ѵ��ѵ���ǣ�˳����Ұ��������һ�����</t><b/>";
		case 10005:	return "<t>лл����Ұ��������һ�����</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission20204Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>��������ȡ������</t><b/>";
		case 10002:	return "<t>Ҷ����ȱ��һЩ�������������أ���ȥ��һ�����ɡ�</t><b/>";
		case 10005:	return "<t>�����ˣ������������м�����ķ����������ˡ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission20207Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>���3��ʦ�ž���</t><b/>";
		case 10002:	return "<t>��������æ��������ӷֵ��������Ϊʦ�ž���</t><b/>";
		case 10005:	return "<t>����Ҫ���10��ʦ�ž�������ɻ�ûƽ�����</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
//��������������������������������֧�ߡ�����Ի���������������������������������


//������������������������������������ܡ�����Ի���������������������������������
function Mission30101Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30111Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30121Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30131Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30201Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30202Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30203Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30301Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30302Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30303Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30401Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30402Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30403Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30501Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30502Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30503Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30601Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30602Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30603Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30701Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30702Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30703Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30102Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30103Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30104Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30105Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30106Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30107Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30108Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30109Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30110Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30112Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30113Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30114Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30115Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30116Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30117Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30118Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30119Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30120Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30122Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30123Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30124Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30125Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30126Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30127Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30128Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30129Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30130Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30132Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30133Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30134Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30135Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30136Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30137Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30138Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30139Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30140Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30204Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30205Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30206Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30207Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30208Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30209Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30210Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30211Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30212Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30304Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30305Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30306Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30307Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30308Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30309Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30310Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30311Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30312Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30404Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30405Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30406Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30407Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30408Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30409Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30410Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30411Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30412Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30504Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30505Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30506Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30507Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30508Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30509Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30510Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30511Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30512Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30604Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30605Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30606Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30607Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30608Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30609Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30610Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30611Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30612Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30704Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30705Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30706Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30707Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30708Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30709Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30710Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30711Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30712Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

$MissionDialog[30101,10001]="��������ѧϰ�ڿ�";
$MissionDialog[30101,10002]="��Ҫ����ѧϰ�ڿ�����Ҫ��һ�������Ĺ��߲��аɡ���ȥ�ӻ��̵���һ�ѿ��������������";
$MissionDialog[30101,10005]="��������������ʴϻۣ��ҾͰ��ڿ�ľ��ϴ��ڸ���";

$MissionDialog[30102,10001]="ѧϰ���߼��������";
$MissionDialog[30102,10002]="����������е��������͵Ļ��������Ҫ�����ȱ��˸߳�ʮ�����ٱ������ࡣΪ�˿�����ĺ��ģ�����ȥ��10��ͭ����";
$MissionDialog[30102,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�����񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30103,10001]="ѧϰ���߼��������";
$MissionDialog[30103,10002]="�����ڿ�ʼ���Ҿ�Ҫָ�����������ڿ�֮�����������š��ڴ�������֮ǰ�������Ҫ����10�����󣬻���Ҫѯ��һλ�ڿ��ʦ���ĵò��С�";
$MissionDialog[30103,10005]="�����벻�����Ȼ���ܵõ�����ʦ�����ĵã��������컯�������ڿ�ʼ�����̤���ڿ�ʦ����ҵ���Ժ�����֮��ʢ��Ҫ�����ˡ�";

$MissionDialog[30104,10001]="ѧϰ���߼��������";
$MissionDialog[30104,10002]="���е�������������û����ֵ��˻��ǲ�Ҫѧ�ĺá������ھͺúÿ����㣬�����ܷ��ڳ�10���������ҿ������Ƿ���ʵ�һ����ʦ��";
$MissionDialog[30104,10005]="������Ȼ��ª�������ӳ�ɫ�Ͽ�����������ôһ���������ã��ã������㻹�ܵ�����ʦ��";

$MissionDialog[30105,10001]="ѧϰ���߼��������";
$MissionDialog[30105,10002]="�벻������ڿ��������������������ڿ�ʼ���Ҿ�Ҫָ�����������ڿ�֮������������֮ǰ�������Ҫ����10�����";
$MissionDialog[30105,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�����񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30106,10001]="ѧϰ���߼��������";
$MissionDialog[30106,10002]="�������Ѿ������������ڿ�������Ҫ��Ϊ���ڿ��ʦ�ˡ���������Ĺ�أ���Ҫ���������չ�Ļ�����������ʦ����10�������";
$MissionDialog[30106,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�����񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30107,10001]="ѧϰ���߼��������";
$MissionDialog[30107,10002]="�������ڵ��ڿ����Ѿ������������ʦ����ˣ������ҿ�Ҫ�������㣬�߼��������Ǻ����ҵ��ģ�������ܽ���10���������ҾͰѸ߼��ڿ�֮���������㡣";
$MissionDialog[30107,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�����񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30108,10001]="ѧϰ���߼��������";
$MissionDialog[30108,10002]="�����������ֻ��һ��֮ң�ˣ��������ͨ���ҵĿ��飬�ڳ�10��ħ���������ҾͰ��������ڿ�֮���������㣬�����ܳ�Ϊ����";
$MissionDialog[30108,10005]="��������ڿ�֮���Ѿ��ﵽ�����ˣ����Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30109,10001]="ѧϰ���߼��������";
$MissionDialog[30109,10002]="��������ڿ�֮���Ѿ��ﵽ�����ˣ�������Ҫ֪��ѧ��ֹ�����������֣����ܴﵽ�ڿ�֮���壬ֻҪ�����ó�10���������������һ��֮����";
$MissionDialog[30109,10005]="��ϲ���ڿ��ܸ�����һ�㣬���Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30110,10001]="ѧϰ���߼��������";
$MissionDialog[30110,10002]="��������ڿ�֮���Ѿ������ﵽ���壬�����ó�10���Ͻ�������������ڿ�֮���塣";
$MissionDialog[30110,10005]="��ϲ�㣬�Ѿ���Ϊ�˹Ž�ﵽ�ڿ󶥷�ĵ�һ�ˣ�����ǰ�޹��˺������ߡ�";

$MissionDialog[30111,10001]="��ף֦ɽѧϰ��ľ";
$MissionDialog[30111,10002]="��Ҫ����ѧϰ��ľ������Ҫ��һ�������Ĺ��߲��аɡ���ȥ�ӻ��̵���һ�ѷ���������������";
$MissionDialog[30111,10005]="��������������ʴϻۣ��ҾͰѷ�ľ�ľ��ϴ��ڸ���";

$MissionDialog[30112,10001]="ѧϰ���߼��������";
$MissionDialog[30112,10002]="����������е��������͵Ļ��������Ҫ�����ȱ��˸߳�ʮ�����ٱ������ࡣΪ�˿�����ĺ��ģ�����ȥ��10����ľ��";
$MissionDialog[30112,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ����ľ���񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30113,10001]="ѧϰ���߼��������";
$MissionDialog[30113,10002]="�����ڿ�ʼ���Ҿ�Ҫָ���������ķ�ľ֮�����������š��ڴ�������֮ǰ�������Ҫ����10��ͩľ������Ҫѯ��һλ��ľ��ʦ���ĵò��С�";
$MissionDialog[30113,10005]="�����벻�����Ȼ���ܵõ�����ʦ�����ĵã��������컯�������ڿ�ʼ�����̤�뷥ľʦ����ҵ���Ժ�����֮��ʢ��Ҫ�����ˡ�";

$MissionDialog[30114,10001]="ѧϰ���߼��������";
$MissionDialog[30114,10002]="���е�������������û����ֵ��˻��ǲ�Ҫѧ�ĺá������ھͺúÿ����㣬�����ܷ�ľ��10����ľ�����ҿ������Ƿ���ʵ�һ����ľʦ��";
$MissionDialog[30114,10005]="��ľ�ķ�����Ȼ��ª�������ӳ�ɫ�Ͽ�����������ôһ���������ã��ã������㻹�ܵ�����ʦ��";

$MissionDialog[30115,10001]="ѧϰ���߼��������";
$MissionDialog[30115,10002]="�벻����ķ�ľ���������������������ڿ�ʼ���Ҿ�Ҫָ���������ķ�ľ֮������������֮ǰ�������Ҫ����10��ɼľ��";
$MissionDialog[30115,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ����ľ���񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30116,10001]="ѧϰ���߼��������";
$MissionDialog[30116,10002]="�������Ѿ����������˷�ľ��������Ҫ��Ϊ�˷�ľ��ʦ�ˡ���������Ĺ�أ���Ҫ���������չ�Ļ�����������ʦ����10̴ľ��";
$MissionDialog[30116,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ����ľ���񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30117,10001]="ѧϰ���߼��������";
$MissionDialog[30117,10002]="�������ڵķ�ľ���ɼ�ֱ������������������ҿ�Ҫ�������㣬�߼�ľ�Ŀ��Ǻ����ҵ��ģ�������ܽ���10����ľ���ҾͰѸ߼���ľ֮���������㡣";
$MissionDialog[30117,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ����ľ���񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30118,10001]="ѧϰ���߼��������";
$MissionDialog[30118,10002]="�������뷥ľ����ֻ��һ��֮ң�ˣ��������ͨ���ҵĿ��飬����10����ľ�������ҾͰ������ķ�ľ֮���������㣬�����ܳ�Ϊ��ľ����";
$MissionDialog[30118,10005]="������ķ�ľ֮���Ѿ��ﵽ��ľ�����ˣ����Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30119,10001]="ѧϰ���߼��������";
$MissionDialog[30119,10002]="������ķ�ľ֮���Ѿ��ﵽ��ľ�����ˣ�������Ҫ֪��ѧ��ֹ�����������֣����ܴﵽ��ľ֮���壬ֻҪ�����ó�10����ľ����������һ��֮����";
$MissionDialog[30119,10005]="��ϲ�㷥ľ���ܸ�����һ�㣬���Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30120,10001]="ѧϰ���߼��������";
$MissionDialog[30120,10002]="������ķ�ľ֮���Ѿ������ﵽ���壬�����ó�10����ľ�����������ɷ�ľ֮���塣";
$MissionDialog[30120,10005]="��ϲ�㣬�Ѿ���Ϊ�˹Ž�ﵽ��ľ����ĵ�һ�ˣ�����ǰ�޹��˺������ߡ�";

$MissionDialog[30121,10001]="�����ɷ�ѧϰ��ҩ";
$MissionDialog[30121,10002]="��Ҫ����ѧϰ��ҩ������Ҫ��һ�������Ĺ��߲��аɡ���ȥ�ӻ��̵���һ������������������";
$MissionDialog[30121,10005]="��������������ʴϻۣ��ҾͰѲ�ҩ�ľ��ϴ��ڸ���";

$MissionDialog[30122,10001]="ѧϰ���߼��������";
$MissionDialog[30122,10002]="����������е��������͵Ļ��������Ҫ�����ȱ��˸߳�ʮ�����ٱ������ࡣΪ�˿�����ĺ��ģ�����ȥ�ɼ�10���ϲ���";
$MissionDialog[30122,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ����ũ�o�������Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30123,10001]="ѧϰ���߼��������";
$MissionDialog[30123,10002]="�����ڿ�ʼ���Ҿ�Ҫָ���������Ĳ�ҩ֮�����������š��ڴ�������֮ǰ�������Ҫ����10��������������Ҫѯ��һλ��ҩ��ʦ���ĵò��С�";
$MissionDialog[30123,10005]="�����벻�����Ȼ���ܵõ�����ʦ�����ĵã��������컯�������ڿ�ʼ�����̤���ҩʦ����ҵ���Ժ�����֮��ʢ��Ҫ�����ˡ�";

$MissionDialog[30124,10001]="ѧϰ���߼��������";
$MissionDialog[30124,10002]="���е�������������û����ֵ��˻��ǲ�Ҫѧ�ĺá������ھͺúÿ����㣬�����ܷ��ҩ��10�����ڣ����ҿ������Ƿ���ʵ�һ����ҩʦ��";
$MissionDialog[30124,10005]="��ҩ����Ȼ����һЩ�Ӳݣ������ӳ�ɫ�Ͽ�����������ôһ���������ã��ã������㻹�ܵ�����ҩʦ��";

$MissionDialog[30125,10001]="ѧϰ���߼��������";
$MissionDialog[30125,10002]="�벻����Ĳ�ҩ���������������������ڿ�ʼ���Ҿ�Ҫָ���������Ĳ�ҩ֮������������֮ǰ�������Ҫ����10�����顣";
$MissionDialog[30125,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ����ũ�o�������Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30126,10001]="ѧϰ���߼��������";
$MissionDialog[30126,10002]="�������Ѿ����������˲�ҩ��������Ҫ��Ϊ�˲�ҩ��ʦ�ˡ���������Ĺ�أ���Ҫ���������չ�Ļ�����������ʦ����10��Ұɽ�Ρ�";
$MissionDialog[30126,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ����ũ�o�������Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30127,10001]="ѧϰ���߼��������";
$MissionDialog[30127,10002]="�������ڵĲ�ҩ���ɼ�ֱ��������ũ���������ҿ�Ҫ�������㣬�߼�ҩ�Ͽ��Ǻ����ռ��ģ�������ܽ���10�������Ĳݣ��ҾͰѸ߼���ҩ֮���������㡣";
$MissionDialog[30127,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ����ũ�o�������Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30128,10001]="ѧϰ���߼��������";
$MissionDialog[30128,10002]="����������ũ�oֻ��һ��֮ң�ˣ��������ͨ���ҵĿ��飬�ɼ�10��������γ������ҾͰ������Ĳ�ҩ֮���������㣬�����ܳ�Ϊ��ũ�o��";
$MissionDialog[30128,10005]="������Ĳ�ҩ֮���Ѿ��ﵽ��ũ�o�ˣ����Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30129,10001]="ѧϰ���߼��������";
$MissionDialog[30129,10002]="������Ĳ�ҩ֮���Ѿ��ﵽ��ũ�o�ˣ�������Ҫ֪��ѧ��ֹ�����������֣����ܴﵽ��ҩ֮���壬ֻҪ�����ó�10�������Ĳݣ���������һ��֮����";
$MissionDialog[30129,10005]="��ϲ���ҩ���ܸ�����һ�㣬���Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30130,10001]="ѧϰ���߼��������";
$MissionDialog[30130,10002]="������Ĳ�ҩ֮���Ѿ������ﵽ���壬�����ó�10��������Σ����������ɲ�ҩ֮���塣";
$MissionDialog[30130,10005]="��ϲ�㣬�Ѿ���Ϊ�˹Ž�ﵽ��ҩ����ĵ�һ�ˣ�����ǰ�޹��˺������ߡ�";

$MissionDialog[30131,10001]="�����ѧϰ����";
$MissionDialog[30131,10002]="��Ҫ����ѧϰ���㣬����Ҫ��һ�������Ĺ��߲��аɡ���ȥ�ӻ��̵���һ����˴�����������";
$MissionDialog[30131,10005]="��������������ʴϻۣ��ҾͰѵ���ľ��ϴ��ڸ���";

$MissionDialog[30132,10001]="ѧϰ���߼��������";
$MissionDialog[30132,10002]="����������е��������͵Ļ��������Ҫ�����ȱ��˸߳�ʮ�����ٱ������ࡣΪ�˿�����ĺ��ģ�����ȥ��10����Ϻ��";
$MissionDialog[30132,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�����񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30133,10001]="ѧϰ���߼��������";
$MissionDialog[30133,10002]="�����ڿ�ʼ���Ҿ�Ҫָ���������ĵ���֮�����������š��ڴ�������֮ǰ�������Ҫ����10����з������Ҫѯ��һλ�����ʦ���ĵò��С�";
$MissionDialog[30133,10005]="�����벻�����Ȼ���ܵõ�����ʦ�����ĵã��������컯�������ڿ�ʼ�����̤�����ʦ����ҵ���Ժ�����֮��ʢ��Ҫ�����ˡ�";

$MissionDialog[30134,10001]="ѧϰ���߼��������";
$MissionDialog[30134,10002]="���е�������������û����ֵ��˻��ǲ�Ҫѧ�ĺá������ھͺúÿ����㣬�����ܷ�����10�����㣬���ҿ������Ƿ���ʵ�һ������ʦ��";
$MissionDialog[30134,10005]="�⼸������ȻС����������ȥ��������ôһ���������ã��ã������㻹�ܵ�������ʦ��";

$MissionDialog[30135,10001]="ѧϰ���߼��������";
$MissionDialog[30135,10002]="�벻����ĵ��㱾�������������������ڿ�ʼ���Ҿ�Ҫָ���������ĵ���֮������������֮ǰ�������Ҫ����10�����㡣";
$MissionDialog[30135,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�����񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30136,10001]="ѧϰ���߼��������";
$MissionDialog[30136,10002]="�������Ѿ����������˵��㼼������Ҫ��Ϊ�˵����ʦ�ˡ���������Ĺ�أ���Ҫ���������չ�Ļ�����������ʦ����10����㡣";
$MissionDialog[30136,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�����񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30137,10001]="ѧϰ���߼��������";
$MissionDialog[30137,10002]="�������ڵĵ��㼼���Ѿ���������Ϫ�ӳ���ˣ������ҿ�Ҫ�������㣬�߼�������Ǻ��ѵ��ģ�������ܽ���10���������ҾͰѸ߼�����֮���������㡣";
$MissionDialog[30137,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�����񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30138,10001]="ѧϰ���߼��������";
$MissionDialog[30138,10002]="������������ֻ��һ��֮ң�ˣ��������ͨ���ҵĿ��飬����10������������ҾͰ������ĵ���֮���������㣬�����ܳ�Ϊ����";
$MissionDialog[30138,10005]="������ĵ���֮���Ѿ��ﵽ�����ˣ����Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30139,10001]="ѧϰ���߼��������";
$MissionDialog[30139,10002]="������ĵ���֮���Ѿ��ﵽ�����ˣ�������Ҫ֪��ѧ��ֹ�����������֣����ܴﵽ����֮���壬ֻҪ�����ó�10���Ĳ��㣬��������һ��֮����";
$MissionDialog[30139,10005]="��ϲ����㼼�ܸ�����һ�㣬���Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30140,10001]="ѧϰ���߼��������";
$MissionDialog[30140,10002]="������ĵ���֮���Ѿ������ﵽ���壬�����ó�10�����㣬���������ɵ���֮���塣";
$MissionDialog[30140,10005]="��ϲ�㣬�Ѿ���Ϊ�˹Ž�ﵽ���㶥��ĵ�һ�ˣ�����ǰ�޹��˺������ߡ�";

$MissionDialog[30201,10001]="ѯ��������";
$MissionDialog[30201,10002]="��Ҫѧϰ����֮����������������ͭ�󶧲���֤����������츳����ȥ���������˽������";
$MissionDialog[30201,10005]="����Ҫ����ͭ�󶧣�";

$MissionDialog[30202,10001]="��Ҫ����������ͭ�󶧵Ĳ���";
$MissionDialog[30202,10002]="ͭ���ͨ���ڿ��ã���������ҹ���</t><b/><t>���ڼ��ͳ�ˮ�������سǵ�����һ��������";
$MissionDialog[30202,10005]="���ϼ����䷽�Ϳ�������ͭ��";

$MissionDialog[30203,10001]="�������ƺõ�ͭ��ȥ�������";
$MissionDialog[30203,10002]="�������ƺõ�ͭ��ȥ�������";
$MissionDialog[30203,10005]="��Ȼ�����ʹ��ˣ����һ������Ҳ�ͷ��Ľ����������������㡣";

$MissionDialog[30204,10001]="ѧϰ���߼��������";
$MissionDialog[30204,10002]="����������е��������͵Ļ��������Ҫ�����ȱ��˸߳�ʮ�����ٱ������ࡣΪ�˿�����ĺ��ģ�����ȥ����10��ͭ����";
$MissionDialog[30204,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�����񹤣������Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30205,10001]="ѧϰ���߼��������";
$MissionDialog[30205,10002]="�����ڿ�ʼ���Ҿ�Ҫָ��������������֮�����������š��ڴ�������֮ǰ�������Ҫ����10�����󶧣�����Ҫѯ��һλ�����ʦ���ĵò��С�";
$MissionDialog[30205,10005]="�����벻�����Ȼ���ܵõ�����ʦ�����ĵã��������컯�������ڿ�ʼ�����̤������ʦ����ҵ���Ժ�����֮��ʢ��Ҫ�����ˡ�";

$MissionDialog[30206,10001]="ѧϰ���߼��������";
$MissionDialog[30206,10002]="���е�������������û����ֵ��˻��ǲ�Ҫѧ�ĺá������ھͺúÿ����㣬�����ܷ������10�����󶧣����ҿ������Ƿ���ʵ�һ������ʦ��";
$MissionDialog[30206,10005]="����������Ȼ��ª�������ӳ�ɫ�Ͽ�����������ôһ���������ã��ã������㻹�ܵ�����ʦ��";

$MissionDialog[30207,10001]="ѧϰ���߼��������";
$MissionDialog[30207,10002]="�벻��������챾�������������������ڿ�ʼ���Ҿ�Ҫָ��������������֮������������֮ǰ�������Ҫ����10����󶧡�";
$MissionDialog[30207,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�����񹤣������Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30208,10001]="ѧϰ���߼��������";
$MissionDialog[30208,10002]="�������Ѿ����������˶��켼������Ҫ��Ϊ��������ʦ�ˡ���������Ĺ�أ���Ҫ���������չ�Ļ�����������ʦ����10������󶧡�";
$MissionDialog[30208,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�����񹤣������Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30209,10001]="ѧϰ���߼��������";
$MissionDialog[30209,10002]="�������ڵĶ��켼���Ѿ��������ܹ��ɽ�����ˣ������ҿ�Ҫ�������㣬�߼�����֮���Ĳ��Ͽ��Ǻ����ռ��ģ�������ܽ���10�������󶧣��ҾͰѸ߼�����֮���������㡣";
$MissionDialog[30209,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�����񹤣������Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30210,10001]="ѧϰ���߼��������";
$MissionDialog[30210,10002]="�����������ֻ��һ��֮ң�ˣ��������ͨ���ҵĿ��飬������10��ħ�𶧳������ҾͰ������Ķ���֮���������㣬�����ܳ�Ϊ���񹤡�";
$MissionDialog[30210,10005]="�����������֮���Ѿ��ﵽ�����ˣ����Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30211,10001]="ѧϰ���߼��������";
$MissionDialog[30211,10002]="�����������֮���Ѿ��ﵽ�����ˣ�������Ҫ֪��ѧ��ֹ�����������֣����ܴﵽ����֮���壬ֻҪ�����ó�10������󶧣���������һ��֮����";
$MissionDialog[30211,10005]="��ϲ�����켼�ܸ�����һ�㣬���Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30212,10001]="ѧϰ���߼��������";
$MissionDialog[30212,10002]="�����������֮���Ѿ������ﵽ���壬�����ó�10���Ͻ�󶧣���������������֮���塣";
$MissionDialog[30212,10005]="��ϲ�㣬�Ѿ���Ϊ�˹Ž�ﵽ���춥��ĵ�һ�ˣ�����ǰ�޹��˺������ߡ�";

$MissionDialog[30301,10001]="ѯ�ʾ�ϼ";
$MissionDialog[30301,10002]="��Ҫѧϰ�÷�֮�����������������ݡ�鲼����֤����������츳����ȥ�Ҿ�ϼ�˽������";
$MissionDialog[30301,10005]="����Ҫ����ݡ�鲼��";

$MissionDialog[30302,10001]="��Ҫ��������ݡ�鲼�Ĳ���";
$MissionDialog[30302,10002]="�����ͨ����ֵ��䣬��������ҹ���</t><b/><t>̴ľ��ʹ��߿������سǵ�֯���������";
$MissionDialog[30302,10005]="���ϼ����䷽�Ϳ�������ݡ�鲼";

$MissionDialog[30303,10001]="��������õ�ݡ�鲼ȥ�������";
$MissionDialog[30303,10002]="��������õ�ݡ�鲼ȥ�������";
$MissionDialog[30303,10005]="��Ȼ�����ʹ��ˣ����һ������Ҳ�ͷ��Ľ��˲÷����������㡣";

$MissionDialog[30304,10001]="ѧϰ���߼��������";
$MissionDialog[30304,10002]="����������е��������͵Ļ��������Ҫ�����ȱ��˸߳�ʮ�����ٱ������ࡣΪ�˿�����ĺ��ģ�����ȥ����10��ݡ�鲼��";
$MissionDialog[30304,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�������޷죬�����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30305,10001]="ѧϰ���߼��������";
$MissionDialog[30305,10002]="�����ڿ�ʼ���Ҿ�Ҫָ���������Ĳ÷�֮�����������š��ڴ�������֮ǰ�������Ҫ����10����ɴ������Ҫѯ��һλ�÷��ʦ���ĵò��С�";
$MissionDialog[30305,10005]="�����벻�����Ȼ���ܵõ�����ʦ�����ĵã��������컯�������ڿ�ʼ�����̤��÷�ʦ����ҵ���Ժ�����֮��ʢ��Ҫ�����ˡ�";

$MissionDialog[30306,10001]="ѧϰ���߼��������";
$MissionDialog[30306,10002]="���е�������������û����ֵ��˻��ǲ�Ҫѧ�ĺá������ھͺúÿ����㣬�����ܷ���ҳ�10������ɴ�����ҿ������Ƿ���ʵ�һ���÷�ʦ��";
$MissionDialog[30306,10005]="�Ⲽ�ϵ���Ȼ��ª�������ӳ�ɫ�Ͽ�����������ôһ���������ã��ã������㻹�ܵ�����ʦ��";

$MissionDialog[30307,10001]="ѧϰ���߼��������";
$MissionDialog[30307,10002]="�벻����Ĳ÷챾�������������������ڿ�ʼ���Ҿ�Ҫָ���������Ĳ÷�֮������������֮ǰ�������Ҫ����10���ƽ�Ƭ��";
$MissionDialog[30307,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�������޷죬�����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30308,10001]="ѧϰ���߼��������";
$MissionDialog[30308,10002]="�������Ѿ����������˲÷켼������Ҫ��Ϊ�˲÷��ʦ�ˡ���������Ĺ�أ���Ҫ���������չ�Ļ�����������ʦ����10�������޾�";
$MissionDialog[30308,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�������޷죬�����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30309,10001]="ѧϰ���߼��������";
$MissionDialog[30309,10002]="�������ڵĲ÷켼���Ѿ�������������˫����ˣ������ҿ�Ҫ�������㣬�߼��÷�֮���Ĳ��Ͽ��Ǻ����ռ��ģ�������ܽ���10����ӰɴƬ���ҾͰѸ߼��÷�֮���������㡣";
$MissionDialog[30309,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�������޷죬�����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30310,10001]="ѧϰ���߼��������";
$MissionDialog[30310,10002]="�������������޷�ֻ��һ��֮ң�ˣ��������ͨ���ҵĿ��飬���ҳ�10�������Ƭ�������ҾͰ������Ĳ÷�֮���������㣬�����ܳ�Ϊ�����޷졣";
$MissionDialog[30310,10005]="������Ĳ÷�֮���Ѿ��ﵽ�����޷��ˣ����Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30311,10001]="ѧϰ���߼��������";
$MissionDialog[30311,10002]="������Ĳ÷�֮���Ѿ��ﵽ�����޷��ˣ�������Ҫ֪��ѧ��ֹ�����������֣����ܴﵽ�÷�֮���壬ֻҪ�����ó�10������ɴ�У���������һ��֮����";
$MissionDialog[30311,10005]="��ϲ��÷켼�ܸ�����һ�㣬���Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30312,10001]="ѧϰ���߼��������";
$MissionDialog[30312,10002]="������Ĳ÷�֮���Ѿ������ﵽ���壬�����ó�10������篶У����������ɲ÷�֮���塣";
$MissionDialog[30312,10005]="��ϲ�㣬�Ѿ���Ϊ�˹Ž�ﵽ�÷춥��ĵ�һ�ˣ�����ǰ�޹��˺������ߡ�";

$MissionDialog[30401,10001]="ѯ������ʯ";
$MissionDialog[30401,10002]="��Ҫѧϰ����֮������������������ľľ�ϲ���֤����������츳����ȥ������ʯ�˽������";
$MissionDialog[30401,10005]="����Ҫ������ľľ�ϣ�";

$MissionDialog[30402,10001]="��Ҫ������������ľľ�ϵĲ���";
$MissionDialog[30402,10002]="��ľ��ͨ����ľ��ã���������ҹ���</t><b/><t>ɰֽ�������سǵ��ɶ�������";
$MissionDialog[30402,10005]="���ϼ����䷽�Ϳ���������ľľ��";

$MissionDialog[30403,10001]="�������ƺõ���ľľ��ȥ�������";
$MissionDialog[30403,10002]="�������ƺõ���ľľ��ȥ�������";
$MissionDialog[30403,10005]="��Ȼ�����ʹ��ˣ����һ������Ҳ�ͷ��Ľ����������������㡣";

$MissionDialog[30404,10001]="ѧϰ���߼��������";
$MissionDialog[30404,10002]="����������е��������͵Ļ��������Ҫ�����ȱ��˸߳�ʮ�����ٱ������ࡣΪ�˿�����ĺ��ģ�����ȥ����10����ľľ��";
$MissionDialog[30404,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ���񽳣������Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30405,10001]="ѧϰ���߼��������";
$MissionDialog[30405,10002]="�����ڿ�ʼ���Ҿ�Ҫָ��������������֮�����������š��ڴ�������֮ǰ�������Ҫ����10��ͩľľ�ϣ�����Ҫѯ��һλ������ʦ���ĵò��С�";
$MissionDialog[30405,10005]="�����벻�����Ȼ���ܵõ�����ʦ�����ĵã��������컯�������ڿ�ʼ�����̤������ʦ����ҵ���Ժ�����֮��ʢ��Ҫ�����ˡ�";

$MissionDialog[30406,10001]="ѧϰ���߼��������";
$MissionDialog[30406,10002]="���е�������������û����ֵ��˻��ǲ�Ҫѧ�ĺá������ھͺúÿ����㣬�����ܷ�������10����ľľ�ϣ����ҿ������Ƿ���ʵ�һ������ʦ��";
$MissionDialog[30406,10005]="��ľ����������Ȼ��ª�������ӳ�ɫ�Ͽ�����������ôһ���������ã��ã������㻹�ܵ�������ʦ��";

$MissionDialog[30407,10001]="ѧϰ���߼��������";
$MissionDialog[30407,10002]="�벻������������������������������ڿ�ʼ���Ҿ�Ҫָ��������������֮������������֮ǰ�������Ҫ����10��ɼľľ�ϡ�";
$MissionDialog[30407,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ���񽳣������Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30408,10001]="ѧϰ���߼��������";
$MissionDialog[30408,10002]="�������Ѿ�����������������������Ҫ��Ϊ��������ʦ�ˡ���������Ĺ�أ���Ҫ���������չ�Ļ�����������ʦ����10̴ľľ�ϡ�";
$MissionDialog[30408,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ���񽳣������Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30409,10001]="ѧϰ���߼��������";
$MissionDialog[30409,10002]="�������ڵ����������Ѿ��ӽ�����³���ˣ������ҿ�Ҫ�������㣬�߼�����֮���Ĳ��Ͽ��Ǻ����ռ��ģ�������ܽ���10����ľľ�ϣ��ҾͰѸ߼�����֮���������㡣";
$MissionDialog[30409,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ���񽳣������Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30410,10001]="ѧϰ���߼��������";
$MissionDialog[30410,10002]="����������ֻ��һ��֮ң�ˣ��������ͨ���ҵĿ��飬������10����ľľ�ϳ������ҾͰ�����������֮���������㣬�����ܳ�Ϊ�񽳡�";
$MissionDialog[30410,10005]="�����������֮���Ѿ��ﵽ���ˣ����Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30411,10001]="ѧϰ���߼��������";
$MissionDialog[30411,10002]="�����������֮���Ѿ��ﵽ���ˣ�������Ҫ֪��ѧ��ֹ�����������֣����ܴﵽ����֮���壬ֻҪ�����ó�10����ľľ�ϣ���������һ��֮����";
$MissionDialog[30411,10005]="��ϲ���������ܸ�����һ�㣬���Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30412,10001]="ѧϰ���߼��������";
$MissionDialog[30412,10002]="�����������֮���Ѿ������ﵽ���壬�����ó�10����ľľ�ϣ���������������֮���塣";
$MissionDialog[30412,10005]="��ϲ�㣬�Ѿ���Ϊ�˹Ž�ﵽ��������ĵ�һ�ˣ�����ǰ�޹��˺������ߡ�";

$MissionDialog[30501,10001]="ѯ������";
$MissionDialog[30501,10002]="��Ҫѧϰ����֮�����������������ϲ�ҩ�۲���֤����������츳����ȥ�������˽������";
$MissionDialog[30501,10005]="����Ҫ�����ϲ�ҩ�ۣ�";

$MissionDialog[30502,10001]="��Ҫ�����������ϲ�ҩ�۵Ĳ���";
$MissionDialog[30502,10002]="�ϲݿ�ͨ����ҩ��ã���������ҹ���</t><b/><t>ҩƿ�������سǵ�������������";
$MissionDialog[30502,10005]="���ϼ����䷽�Ϳ��������ϲ�ҩ��";

$MissionDialog[30503,10001]="�������ƺõ��ϲ�ҩ��ȥ�������";
$MissionDialog[30503,10002]="�������ƺõ��ϲ�ҩ��ȥ�������";
$MissionDialog[30503,10005]="��Ȼ�����ʹ��ˣ����һ������Ҳ�ͷ��Ľ����������������㡣";

$MissionDialog[30504,10001]="ѧϰ���߼��������";
$MissionDialog[30504,10002]="����������е��������͵Ļ��������Ҫ�����ȱ��˸߳�ʮ�����ٱ������ࡣΪ�˿�����ĺ��ģ�����ȥ����10���ϲ�ҩ����";
$MissionDialog[30504,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ����ҽ�������Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30505,10001]="ѧϰ���߼��������";
$MissionDialog[30505,10002]="�����ڿ�ʼ���Ҿ�Ҫָ��������������֮�����������š��ڴ�������֮ǰ�������Ҫ����10�ݽ�����ҩ�ۣ�����Ҫѯ��һλ������ʦ���ĵò��С�";
$MissionDialog[30505,10005]="�����벻�����Ȼ���ܵõ�����ʦ�����ĵã��������컯�������ڿ�ʼ�����̤������ʦ����ҵ���Ժ�����֮��ʢ��Ҫ�����ˡ�";

$MissionDialog[30506,10001]="ѧϰ���߼��������";
$MissionDialog[30506,10002]="���е�������������û����ֵ��˻��ǲ�Ҫѧ�ĺá������ھͺúÿ����㣬�����ܷ�������10������ҩ�ۣ����ҿ������Ƿ���ʵ�һ������ʦ��";
$MissionDialog[30506,10005]="�ⵤҩ����Ȼ��ª�������ӳ�ɫ�Ͽ�����������ôһ���������ã��ã������㻹�ܵ�����ʦ��";

$MissionDialog[30507,10001]="ѧϰ���߼��������";
$MissionDialog[30507,10002]="�벻������������������������������ڿ�ʼ���Ҿ�Ҫָ��������������֮������������֮ǰ�������Ҫ����10�ݵ���ҩ�ۡ�";
$MissionDialog[30507,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ����ҽ�������Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30508,10001]="ѧϰ���߼��������";
$MissionDialog[30508,10002]="�������Ѿ�����������������������Ҫ��Ϊ��������ʦ�ˡ���������Ĺ�أ���Ҫ���������չ�Ļ�����������ʦ����10��Ұɽ��ҩ�ۡ�";
$MissionDialog[30508,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ����ҽ�������Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30509,10001]="ѧϰ���߼��������";
$MissionDialog[30509,10002]="�������ڵ����������Ѿ��ӽ���ȵ�����ˣ������ҿ�Ҫ�������㣬�߼�����֮���Ĳ��Ͽ��Ǻ����ռ��ģ�������ܽ���10�ݶ����Ĳ�ҩ�ۣ��ҾͰѸ߼�����֮���������㡣";
$MissionDialog[30509,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ����ҽ�������Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30510,10001]="ѧϰ���߼��������";
$MissionDialog[30510,10002]="����������ҽֻ��һ��֮ң�ˣ��������ͨ���ҵĿ��飬����10�ݾ������ҩ�۳������ҾͰ�����������֮���������㣬�����ܳ�Ϊ��ҽ��";
$MissionDialog[30510,10005]="�����������֮���Ѿ��ﵽ��ҽ�ˣ����Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30511,10001]="ѧϰ���߼��������";
$MissionDialog[30511,10002]="�����������֮���Ѿ��ﵽ��ҽ�ˣ�������Ҫ֪��ѧ��ֹ�����������֣����ܴﵽ����֮���壬ֻҪ�����ó�10��Ұ��֥ҩ�ۣ���������һ��֮����";
$MissionDialog[30511,10005]="��ϲ���������ܸ�����һ�㣬���Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30512,10001]="ѧϰ���߼��������";
$MissionDialog[30512,10002]="�����������֮���Ѿ������ﵽ���壬�����ó�10�ݾ�����֥ҩ�ۣ���������������֮���塣";
$MissionDialog[30512,10005]="��ϲ�㣬�Ѿ���Ϊ�˹Ž�ﵽ��������ĵ�һ�ˣ�����ǰ�޹��˺������ߡ�";

$MissionDialog[30601,10001]="ѯ�������";
$MissionDialog[30601,10002]="��Ҫѧϰ����֮�������������Ƴ������ֽ����֤����������츳����ȥ��������˽������";
$MissionDialog[30601,10005]="����Ҫ���������ֽ��";

$MissionDialog[30602,10001]="��Ҫ���������������ֽ�Ĳ���";
$MissionDialog[30602,10002]="��ľ��ͨ����ľ��ã���������ҹ���</t><b/><t>ɰֽ�������سǵ��ɶ�������";
$MissionDialog[30602,10005]="���ϼ����䷽�Ϳ������������ֽ";

$MissionDialog[30603,10001]="���������õ������ֽȥ�������";
$MissionDialog[30603,10002]="���������õ������ֽȥ�������";
$MissionDialog[30603,10005]="��Ȼ�����ʹ��ˣ����һ������Ҳ�ͷ��Ľ��˷������������㡣";

$MissionDialog[30604,10001]="ѧϰ���߼��������";
$MissionDialog[30604,10002]="����������е��������͵Ļ��������Ҫ�����ȱ��˸߳�ʮ�����ٱ������ࡣΪ�˿�����ĺ��ģ�����ȥ����10�������ֽ��";
$MissionDialog[30604,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�����񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30605,10001]="ѧϰ���߼��������";
$MissionDialog[30605,10002]="�����ڿ�ʼ���Ҿ�Ҫָ���������ķ���֮�����������š��ڴ�������֮ǰ�������Ҫ����10�����ʷ�ֽ������Ҫѯ��һλ�����ʦ���ĵò��С�";
$MissionDialog[30605,10005]="�����벻�����Ȼ���ܵõ�����ʦ�����ĵã��������컯�������ڿ�ʼ�����̤�����ʦ����ҵ���Ժ�����֮��ʢ��Ҫ�����ˡ�";

$MissionDialog[30606,10001]="ѧϰ���߼��������";
$MissionDialog[30606,10002]="���е�������������û����ֵ��˻��ǲ�Ҫѧ�ĺá������ھͺúÿ����㣬�����ܷ�������10����Ʒ��ֽ�����ҿ������Ƿ���ʵ�һ������ʦ��";
$MissionDialog[30606,10005]="�������Ȼ��ª�������ӳ�ɫ�Ͽ�����������ôһ���������ã��ã������㻹�ܵ�������ʦ��";

$MissionDialog[30607,10001]="ѧϰ���߼��������";
$MissionDialog[30607,10002]="�벻����ķ��䱾�������������������ڿ�ʼ���Ҿ�Ҫָ���������ķ���֮������������֮ǰ�������Ҫ����10����Ʒ��ֽ��";
$MissionDialog[30607,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�����񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30608,10001]="ѧϰ���߼��������";
$MissionDialog[30608,10002]="�������Ѿ����������˷��似������Ҫ��Ϊ�˷����ʦ�ˡ���������Ĺ�أ���Ҫ���������չ�Ļ�����������ʦ����10����Ʒ��ֽ��";
$MissionDialog[30608,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�����񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30609,10001]="ѧϰ���߼��������";
$MissionDialog[30609,10002]="�������ڵķ��似���Ѿ��ӽ��������ˣ������ҿ�Ҫ�������㣬�߼�����֮���Ĳ��Ͽ��Ǻ����ռ��ģ�������ܽ���10�����ʷ�ֽ���ҾͰѸ߼�����֮���������㡣";
$MissionDialog[30609,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ�����񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30610,10001]="ѧϰ���߼��������";
$MissionDialog[30610,10002]="�����������ֻ��һ��֮ң�ˣ��������ͨ���ҵĿ��飬������10��������ֽ�������ҾͰ������ķ���֮���������㣬�����ܳ�Ϊ����";
$MissionDialog[30610,10005]="������ķ���֮���Ѿ��ﵽ�����ˣ����Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30611,10001]="ѧϰ���߼��������";
$MissionDialog[30611,10002]="������ķ���֮���Ѿ��ﵽ�����ˣ�������Ҫ֪��ѧ��ֹ�����������֣����ܴﵽ����֮���壬ֻҪ�����ó�10�����ʷ�ֽ����������һ��֮����";
$MissionDialog[30611,10005]="��ϲ����似�ܸ�����һ�㣬���Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30612,10001]="ѧϰ���߼��������";
$MissionDialog[30612,10002]="������ķ���֮���Ѿ������ﵽ���壬�����ó�10��������ֽ�����������ɷ���֮���塣";
$MissionDialog[30612,10005]="��ϲ�㣬�Ѿ���Ϊ�˹Ž�ﵽ���䶥��ĵ�һ�ˣ�����ǰ�޹��˺������ߡ�";

$MissionDialog[30701,10001]="ѯ���ִ�ɩ";
$MissionDialog[30701,10002]="��Ҫѧϰ���֮��������������⿳�����ˮ����֤����������츳����ȥ���ִ�ɩ�˽������";
$MissionDialog[30701,10005]="����Ҫ��⿱���ˮ��";

$MissionDialog[30702,10001]="��Ҫ��������⿱���ˮ�Ĳ���";
$MissionDialog[30702,10002]="���ɿ�ͨ����ֵ��䣬��������ҹ���</t><b/><t>���Ͽ������سǵ����ȶ�������";
$MissionDialog[30702,10005]="���ϼ����䷽�Ϳ�����⿱���ˮ";

$MissionDialog[30703,10001]="������⿺õı���ˮȥ�������";
$MissionDialog[30703,10002]="������⿺õı���ˮȥ�������";
$MissionDialog[30703,10005]="��Ȼ�����ʹ��ˣ����һ������Ҳ�ͷ��Ľ���������������㡣";

$MissionDialog[30704,10001]="ѧϰ���߼��������";
$MissionDialog[30704,10002]="����������е��������͵Ļ��������Ҫ�����ȱ��˸߳�ʮ�����ٱ������ࡣΪ�˿�����ĺ��ģ�����ȥ���10������ˮ��";
$MissionDialog[30704,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ��ʳ�񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30705,10001]="ѧϰ���߼��������";
$MissionDialog[30705,10002]="�����ڿ�ʼ���Ҿ�Ҫָ�������������֮�����������š��ڴ�������֮ǰ�������Ҫ����10����ۣ�����Ҫѯ��һλ��⿴�ʦ���ĵò��С�";
$MissionDialog[30705,10005]="�����벻�����Ȼ���ܵõ�����ʦ�����ĵã��������컯�������ڿ�ʼ�����̤�����ʦ����ҵ���Ժ�����֮��ʢ��Ҫ�����ˡ�";

$MissionDialog[30706,10001]="ѧϰ���߼��������";
$MissionDialog[30706,10002]="���е�������������û����ֵ��˻��ǲ�Ҫѧ�ĺá������ھͺúÿ����㣬�����ܷ���⿳�10�����������ҿ������Ƿ���ʵ�һ�����ʦ��";
$MissionDialog[30706,10005]="��Щʳ����Ȼ��ª�������ӳ�ɫ�Ͽ�����������ôһ���������ã��ã������㻹�ܵ������ʦ��";

$MissionDialog[30707,10001]="ѧϰ���߼��������";
$MissionDialog[30707,10002]="�벻�������⿱��������������������ڿ�ʼ���Ҿ�Ҫָ�������������֮������������֮ǰ�������Ҫ����10����衣";
$MissionDialog[30707,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ��ʳ�񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30708,10001]="ѧϰ���߼��������";
$MissionDialog[30708,10002]="�������Ѿ�������������⿼�������Ҫ��Ϊ����⿴�ʦ�ˡ���������Ĺ�أ���Ҫ���������չ�Ļ�����������ʦ����10���׷ۡ�";
$MissionDialog[30708,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ��ʳ�񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30709,10001]="ѧϰ���߼��������";
$MissionDialog[30709,10002]="�������ڵ���⿼����Ѿ���ֱ���ȵ��������ˣ������ҿ�Ҫ�������㣬�߼����֮���Ĳ��Ͽ��Ǻ����ռ��ģ�������ܽ���10���������ҾͰѸ߼����֮���������㡣";
$MissionDialog[30709,10005]="�ܺã���ƾ����ݺ��ģ����ձض���������е��г�Ϊһ��ʳ�񣬲����Ժ�Ҫ���Ŭ��,��ʲô�����ĵط������������ҡ�";

$MissionDialog[30710,10001]="ѧϰ���߼��������";
$MissionDialog[30710,10002]="��������ʳ��ֻ��һ��֮ң�ˣ��������ͨ���ҵĿ��飬������15����Ƥ�������ҾͰ����������֮���������㣬�����ܳ�Ϊʳ��";
$MissionDialog[30710,10005]="����������֮���Ѿ��ﵽʳ���ˣ����Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30711,10001]="ѧϰ���߼��������";
$MissionDialog[30711,10002]="����������֮���Ѿ��ﵽʳ���ˣ�������Ҫ֪��ѧ��ֹ�����������֣����ܴﵽ���֮���壬ֻҪ�����ó�10�����ڣ���������һ��֮����";
$MissionDialog[30711,10005]="��ϲ����⿼��ܸ�����һ�㣬���Ѿ�û��ʲô�����ٽ���ģ������Ժ�����ƿ���ĵط������������Ұ�æ��";

$MissionDialog[30712,10001]="ѧϰ���߼��������";
$MissionDialog[30712,10002]="����������֮���Ѿ������ﵽ���壬�����ó�10���������������������֮���塣";
$MissionDialog[30712,10005]="��ϲ�㣬�Ѿ���Ϊ�˹Ž�ﵽ��⿶���ĵ�һ�ˣ�����ǰ�޹��˺������ߡ�";

function MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001: return "<t>" @ $MissionDialog[%Mid,%Tid] @ "</t><b/>";
		case 10002: return "<t>" @ $MissionDialog[%Mid,%Tid] @ "</t><b/>";
		case 10005: return "<t>" @ $MissionDialog[%Mid,%Tid] @ "</t><b/>";

		case 411: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "ѯ���ĵ�</t>";

		case 511: return "<t>���²���ǿ���������黹�ý�����֣�</t>";
		case 512: return "<t>�ҿ�����֪���������ǿ�ң�Ҳʵ�ڲ�����˼�ܾ��ˣ�</t>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}

//������������������������������������ܡ�����Ի���������������������������������



//�����������������������������������ͼ��ס�����Ի���������������������������������
function Mission29101Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29102Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29103Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29104Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29105Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29106Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29107Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29108Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29109Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29110Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29111Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29112Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29113Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29114Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29115Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29116Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29117Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29118Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29119Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29120Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29121Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29122Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29123Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29124Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29125Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29126Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29127Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29128Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29129Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29130Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29131Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29132Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29133Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29134Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29135Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29136Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29137Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29138Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29139Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29140Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29141Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29142Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29143Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29144Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29145Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29146Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29147Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29148Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29149Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29150Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29201Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29202Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29203Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29204Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29205Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29206Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29207Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29208Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29209Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29210Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29211Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29212Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29213Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29214Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29215Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29216Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29217Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29218Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29219Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29220Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29221Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29222Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29223Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29224Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29225Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29226Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29227Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29228Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29229Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29230Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29231Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29232Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29233Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29234Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29235Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29236Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29237Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29238Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29239Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29240Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29241Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29242Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29243Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29244Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29245Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29246Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29247Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29248Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29249Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29250Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29301Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29302Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29303Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29304Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29305Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29306Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29307Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29308Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29309Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29310Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29311Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29312Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29313Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29314Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29315Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29316Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29317Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29318Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29319Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29320Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29321Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29322Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29323Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29324Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29325Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29326Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29327Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29328Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29329Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29330Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29331Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29332Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29333Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29334Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29335Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29336Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29337Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29338Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29339Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29340Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29341Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29342Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29343Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29344Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29345Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29346Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29347Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29348Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29349Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29350Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29401Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29402Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29403Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29404Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29405Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29406Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29407Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29408Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29409Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29410Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29411Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29412Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29413Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29414Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29415Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29416Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29417Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29418Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29419Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29420Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29421Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29422Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29423Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29424Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29425Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29426Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29427Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29428Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29429Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29430Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29431Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29432Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29433Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29434Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29435Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29436Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29437Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29438Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29439Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29440Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29441Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29442Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29443Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29444Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29445Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29446Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29447Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29448Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29449Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29450Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29501Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29502Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29503Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29504Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29505Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29506Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29507Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29508Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29509Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29510Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29511Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29512Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29513Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29514Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29515Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29516Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29517Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29518Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29519Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29520Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29521Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29522Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29523Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29524Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29525Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29526Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29527Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29528Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29529Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29530Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29531Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29532Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29533Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29534Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29535Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29536Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29537Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29538Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29539Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29540Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29541Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29542Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29543Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29544Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29545Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29546Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29547Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29548Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29549Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29550Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29601Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29602Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29603Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29604Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29605Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29606Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29607Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29608Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29609Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29610Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29611Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29612Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29613Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29614Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29615Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29616Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29617Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29618Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29619Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29620Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29621Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29622Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29623Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29624Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29625Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29626Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29627Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29628Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29629Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29630Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29631Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29632Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29633Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29634Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29635Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29636Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29637Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29638Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29639Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29640Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29641Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29642Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29643Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29644Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29645Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29646Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29647Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29648Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29649Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29650Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }

$MissionDialog[29101,10001]="ǰ��·��Ѱ�ҿ�ľ��֥�����ɷ�";
$MissionDialog[29101,10002]="�����ż�ҩ�Ŀ�ľ��֥�����ˣ��鷳�����ȥ��ڲ�һЩ����";
$MissionDialog[29101,10005]="������������ˡ�";

$MissionDialog[29102,10001]="�����ͻ����ռ����ǽ������ɷ�";
$MissionDialog[29102,10002]="����о���ҩ��ȱ��һЩ���ǣ���ɽ���ϻ�������ͣ���һ��СŮ�ӿ�����Ǻ�";
$MissionDialog[29102,10005]="������������ˡ�";

$MissionDialog[29103,10001]="������������ռ���Ѫ�������ɷ�";
$MissionDialog[29103,10002]="�����ŵ�ҪһֱûʲôЧ������˵��Ҫ�������Ѫ��ҩ�������κ����ŵĲ�";
$MissionDialog[29103,10005]="������������ˡ�";

$MissionDialog[29104,300]="����¸��ӹ������˰�";
$MissionDialog[29104,10001]="Ѱ�ҽ�ʦ��³��ʦ�����¸���";
$MissionDialog[29104,10002]="���쿳���ҵĸ��Ӷ��������ˣ��ɷ�������³��ʦ��һ���¸���";
$MissionDialog[29104,10005]="������������ˡ�";

$MissionDialog[29105,10001]="����ף֦ɽ�ռ����";
$MissionDialog[29105,10002]="�ҿ��˺ö����ڴ�ڵģ�һ���˰᲻��������ʿ�ɷ����ȥ��һЩ����";
$MissionDialog[29105,10005]="������������ˡ�";

$MissionDialog[29106,10001]="��������";
$MissionDialog[29106,10002]="��˵��ڳ����˻���˵������������ڶ����ҳ���ȥ�����ˣ������ô����";
$MissionDialog[29106,10005]="������������ˡ�";

$MissionDialog[29107,10001]="���ܿ����������ռ����ɽ�������";
$MissionDialog[29107,10002]="�����ҵ�����һ�����㣬���ҵ���Ͷ�Ū���ˣ�Ҫ����һ�����ʵ���Ϳɲ����װ�";
$MissionDialog[29107,10005]="������������ˡ�";

$MissionDialog[29108,10001]="���ܳ�â��";
$MissionDialog[29108,10002]="���������Ϲ���û������ˣ�Ҫ����ץ��ֻ�������ͺ���";
$MissionDialog[29108,10005]="������������ˡ�";

$MissionDialog[29109,10001]="�޸�����";
$MissionDialog[29109,10002]="������棬����ɹ�����ҵ������Ѿ����ˣ������޲�һ�°�";
$MissionDialog[29109,10005]="������������ˡ�";

$MissionDialog[29110,10001]="������Ѫ����";
$MissionDialog[29110,10002]="��֪Ϊ�Σ������������˺ö����ӣ�ר����Ѫ�������Ƕ����ҳ�ȥ��";
$MissionDialog[29110,10005]="������������ˡ�";

$MissionDialog[29111,10001]="ǰ�������ڵ�ȼ���";
$MissionDialog[29111,10002]="�����и����ӳ�Ѩ������·�ڵ��ϻ�ѷ�ֹ���ӳ���";
$MissionDialog[29111,10005]="������������ˡ�";

$MissionDialog[29112,10001]="ǰ����ɳ��Ѱ̽����";
$MissionDialog[29112,10002]="��˵��ɳ����Զ����������ı��أ�����һֱ��ɳ���ػ������������˶���Ҳû������";
$MissionDialog[29112,10005]="������������ˡ�";

$MissionDialog[29113,10001]="ǰ������̶��̳��ɼ���";
$MissionDialog[29113,10002]="���ӵ��ﴫͳÿ�¶�Ҫȥ��̳���죬���������ˣ��߲�����";
$MissionDialog[29113,10005]="������������ˡ�";

$MissionDialog[29114,10001]="Ѱ��Ұ������ͯ��";
$MissionDialog[29114,10002]="�峤�����ҳ�ȥ�棬����ժ���ӳԺò���";
$MissionDialog[29114,10005]="������������ˡ�";

$MissionDialog[29115,10001]="ǰ������������ժ��Ҷ����ͯ��";
$MissionDialog[29115,10002]="���꿩�����꿩��ժ��Ƭ��Ҷ��ñ����";
$MissionDialog[29115,10005]="������������ˡ�";

$MissionDialog[29116,10001]="ǰ�����������������ӽ���ͯ��";
$MissionDialog[29116,10002]="�ҵ����ӵ����������ˣ�����ȥ�ĵĵط��Ҷ����˱�ǵ�";
$MissionDialog[29116,10005]="������������ˡ�";

$MissionDialog[29117,10001]="�����ͻ����ռ���Ƥ����������";
$MissionDialog[29117,10002]="�������ˣ����Ů����һ��Ƥ����ů��Ҫ����Щ��Ƥ�ͺ���";
$MissionDialog[29117,10005]="������������ˡ�";

$MissionDialog[29118,10001]="�������߽���������";
$MissionDialog[29118,10002]="��ʹ��ˣ��۾�����ʹ�ˣ�������ߵ��ڵ����Ҷ����������Ҳ�����";
$MissionDialog[29118,10005]="������������ˡ�";

$MissionDialog[29119,10001]="�����ͻ����ռ������Ů����";
$MissionDialog[29119,10002]="������Щ�ɳڣ����������ˣ�Ҫ����Щ���������ң��ǿɾ�̫����";
$MissionDialog[29119,10005]="������������ˡ�";

$MissionDialog[29120,10001]="���ܿ����������ռ���֦����Ů����";
$MissionDialog[29120,10002]="��֧��Ҫ�����ˣ���Ҫ��һЩ��֦������";
$MissionDialog[29120,10005]="������������ˡ�";

$MissionDialog[29121,10001]="�������ɳ��";
$MissionDialog[29121,10002]="��������Щɳ��ð����ׯ���ɲ��������ǵó�";
$MissionDialog[29121,10005]="������������ˡ�";

$MissionDialog[29122,10001]="��������׺�����ȡ�׺�Ƥ����Ů����";
$MissionDialog[29122,10002]="�������ϰ׺���ëƤ��Ư���ˣ��϶���һЩ�ü�Ǯ";
$MissionDialog[29122,10005]="������������ˡ�";

$MissionDialog[29123,300]="�����Ҷ������ƵĽ�ҩ���ú���";
$MissionDialog[29123,10001]="Ѱ��ҩʦ��ǧ��ȡ����ҩ";
$MissionDialog[29123,10002]="�������в����˵ģ����С��ֻҪ���㡭�������ˣ�����Ҫ��ҩʦȥ��ҩ��";
$MissionDialog[29123,10005]="������������ˡ�";

$MissionDialog[29124,10001]="ǰ����ɳ��Ѱ�Һɻ�����Ҷ�";
$MissionDialog[29124,10002]="��ϲ���ɻ�����ϲ���������ĺɻ����������ĺɻ������ڻ�ɳ�е�ˮ��ʢ��";
$MissionDialog[29124,10005]="������������ˡ�";

$MissionDialog[29125,10001]="ǰ���Ͼ�̶Ѱ���Ͼ�ʯ����Ҷ�";
$MissionDialog[29125,10002]="Ů�������Ͷ�һЩ��������Ķ���û�еֿ���";
$MissionDialog[29125,10005]="������������ˡ�";

$MissionDialog[29126,10001]="����ɽ���������ħ";
$MissionDialog[29126,10002]="����һ��ȥ���������ħ���ͽ�����ƽ�֣�����";
$MissionDialog[29126,10005]="������������ˡ�";

$MissionDialog[29127,10001]="���ܿ���ħ��";
$MissionDialog[29127,10002]="��ʰ����ħ��������С����Ҳ�õ����ҳ���ô";
$MissionDialog[29127,10005]="������������ˡ�";

$MissionDialog[29128,300]="�ع��ն������˵�������ȥ��";
$MissionDialog[29128,10001]="Ѱ�ҵع�������̽�ع���Ϣ";
$MissionDialog[29128,10002]="��˵�ع��ڵĹ��������ޱȣ����Ҷ��ǻ����������ģ������ȴ�̽һ��";
$MissionDialog[29128,10005]="������������ˡ�";

$MissionDialog[29129,10001]="�޸�����";
$MissionDialog[29129,10002]="�����ƻ����ӷ������ϻ����������ϻ�����ׯ�����Ȱ��Ұ������޺ã��Ұ��ϻ�ץ����";
$MissionDialog[29129,10005]="������������ˡ�";

$MissionDialog[29130,10001]="��������׺����ռ��׺�β������ʦ��";
$MissionDialog[29130,10002]="��׺���β�Ϳ����������ǰ������ʣ���ȥ�͸�Ҷ�����һ����ϲ����";
$MissionDialog[29130,10005]="������������ˡ�";

$MissionDialog[29131,10001]="ǰ������¯�鿴����¯���";
$MissionDialog[29131,10002]="ʦ�������ڴ��տ�����¯��ά��¯���¶Ȳ��䣬���������������һ�˵Ļ������ٺ�";
$MissionDialog[29131,10005]="������������ˡ�";

$MissionDialog[29132,10001]="���ܿ���ħ��";
$MissionDialog[29132,10002]="�ҵ��ڴ��ػ���ׯ���ɷ�����һ��֮���˳�����ħ��";
$MissionDialog[29132,10005]="������������ˡ�";

$MissionDialog[29133,10001]="�����ѻ�ɳ��";
$MissionDialog[29133,10002]="ɳ������֮�أ����ر��ɳ�������������ַ����ǵط�";
$MissionDialog[29133,10005]="������������ˡ�";

$MissionDialog[29134,300]="û���⣬�㿴��Щ�����Ϻõı�����";
$MissionDialog[29134,10001]="Ѱ�ҽ�ʦ³��ʦ�������";
$MissionDialog[29134,10002]="���ǵ�սʿ���ս�����������Ѿ�ĥ���ˣ�ϣ�����ҽ�ʦ����һƥ�µı���";
$MissionDialog[29134,10005]="������������ˡ�";

$MissionDialog[29135,10001]="�����������ռ�����β������ǧ��";
$MissionDialog[29135,10002]="����Ҫ��ҩ��ȱ���������β�ͣ���������̶���ǳ�����ȥ�ĵط�";
$MissionDialog[29135,10005]="������������ˡ�";

$MissionDialog[29136,10001]="���ܿ���ħ�����ռ����ڵ�������ǧ��";
$MissionDialog[29136,10002]="��˵����ħ���Ѿ��������������ˣ����ǵ��ڵ�����һζ��ҩ�İ�";
$MissionDialog[29136,10005]="������������ˡ�";

$MissionDialog[29137,10001]="ǰ��������Ѱ�һ����ݽ�����ǧ��";
$MissionDialog[29137,10002]="����Ҫ��ҩ��ȱ���˻����ݣ��Ҽǵ���������һ���кܶ�";
$MissionDialog[29137,10005]="������������ˡ�";

$MissionDialog[29138,10001]="ǰ��������Ѱ������ݽ�����ǧ��";
$MissionDialog[29138,10002]="����Ҫ��ҩ��ȱ��������ݣ��Ҽǵ���������һ���кܶ�";
$MissionDialog[29138,10005]="������������ˡ�";

$MissionDialog[29139,10001]="���ܻ��ȣ��ռ�����������ǧ��";
$MissionDialog[29139,10002]="�����о�һ����ҩ������ȱ���˻������ĸ�";
$MissionDialog[29139,10005]="������������ˡ�";

$MissionDialog[29140,10001]="�����������ռ����ݽ���³��ʦ";
$MissionDialog[29140,10002]="��������������������˵����̶�������������������Ӧ���в��������ð�";
$MissionDialog[29140,10005]="������������ˡ�";

$MissionDialog[29141,10001]="���ܱ����������ռ����ڵ�����³��ʦ";
$MissionDialog[29141,10002]="����һ�Ѻ�������ͨ�����϶����У���Ҫ��ʯ�ĳ��ı��������ڵ�";
$MissionDialog[29141,10005]="������������ˡ�";

$MissionDialog[29142,10001]="ǰ������¯�ռ�����¯ˮ����³��ʦ";
$MissionDialog[29142,10002]="��¯����¶��ڻ�����������������Ҫ��˵�е�����¯֮ˮ�����ڻ�";
$MissionDialog[29142,10005]="������������ˡ�";

$MissionDialog[29143,10001]="���ܱ����������ռ������Ƚ�������";
$MissionDialog[29143,10002]="���ӻ��̾���ʲô�������գ����ȱһЩ�������������";
$MissionDialog[29143,10005]="������������ˡ�";

$MissionDialog[29144,10001]="�������ɳ������ȡɳʯ���׽�������";
$MissionDialog[29144,10002]="���ӻ��̾���ʲô�������գ����ȱһЩɳʯ����";
$MissionDialog[29144,10005]="������������ˡ�";

$MissionDialog[29145,10001]="������Ѫ���ã��ռ����ӳ�򽻸�����";
$MissionDialog[29145,10002]="���ӻ��̾���ʲô�������գ����ȱһЩ��Ѫ���õĳ��";
$MissionDialog[29145,10005]="������������ˡ�";

$MissionDialog[29146,10001]="ǰ��·�ڰ��˲�ƥ��������";
$MissionDialog[29146,10002]="�˲�ƥ����������ֻ��ͣ����·�ߣ����ǵ������ֲ��㣬�����ô����";
$MissionDialog[29146,10005]="������������ˡ�";

$MissionDialog[29147,300]="��......��׼������";
$MissionDialog[29147,10001]="Ѱ�ҿ�����ף֦ɽ";
$MissionDialog[29147,10002]="��������ˣ�û�в����ô������";
$MissionDialog[29147,10005]="������������ˡ�";

$MissionDialog[29148,10001]="ǰ������������ժ��ź�������";
$MissionDialog[29148,10002]="���ϳ�ʲô�����Ⲣ���ѣ���Ϊʲô��û���ˣ�ֻ��ȥ������Щ��ź";
$MissionDialog[29148,10005]="������������ˡ�";

$MissionDialog[29149,10001]="���ܻ��ȣ��ռ����꽻�����";
$MissionDialog[29149,10002]="��˵�������Ļ������Ϻõ����ϣ�������������ζ���ã�����������Ϊ��";
$MissionDialog[29149,10005]="������������ˡ�";

$MissionDialog[29150,300]="�ҿɶ��ǵ��أ��������˼�������";
$MissionDialog[29150,10001]="Ѱ�������������к�";
$MissionDialog[29150,10002]="��˵�����������ض��飬���Ҹ���˵һ�����ǵø�������������";
$MissionDialog[29150,10005]="������������ˡ�";

//------------------------------------------------------------------------
$MissionDialog[29201,10001]="���ܺ�������";
$MissionDialog[29201,10002]="ǰ�����ص�·������һЩ��������Ϯ��·�ˣ��ð����ǳ����źá�";
$MissionDialog[29201,10005]="������������ˡ�";

$MissionDialog[29202,10001]="���ܲ�ѩ��ʦ";
$MissionDialog[29202,10002]="��ѩӪ����ʦ��֪��������ıдʲô����Ҫ�����ǽ���";
$MissionDialog[29202,10005]="������������ˡ�";

$MissionDialog[29203,10001]="���ܲ�ɽҰ��";
$MissionDialog[29203,10002]="ѩ��ƽԭ��Ұ�˱�÷ǳ����꣬��Ҫǰȥ����һ��";
$MissionDialog[29203,10005]="������������ˡ�";

$MissionDialog[29204,10001]="����ѩ��";
$MissionDialog[29204,10002]="ѩ��ƽԭ��ѩ����÷ǳ����꣬��Ҫǰȥ����һ��";
$MissionDialog[29204,10005]="������������ˡ�";

$MissionDialog[29205,10001]="���ܽ�ū";
$MissionDialog[29205,10002]="��ū̫��Ļ���ħ������Ʒ�ӡ������Ҫ��������";
$MissionDialog[29205,10005]="������������ˡ�";

$MissionDialog[29206,10001]="���ܺ�������,��ȡ����֮ӡ";
$MissionDialog[29206,10002]="��ʦ����ô���ƿ��ܵģ���ŪһЩ����֮ӡ�о�һ��";
$MissionDialog[29206,10005]="������������ˡ�";

$MissionDialog[29207,10001]="���ܺ�������,��ȡ����֮צ";
$MissionDialog[29207,10002]="����֮צҲ�����������ĺò��ϣ��ܶ�ŪһЩ�����ͺ�";
$MissionDialog[29207,10005]="������������ˡ�";

$MissionDialog[29208,10001]="���ܺ�������,��ȡ����֮��";
$MissionDialog[29208,10002]="��������Ʒ�պ���ҪһЩ����֮��";
$MissionDialog[29208,10005]="������������ˡ�";

$MissionDialog[29209,10001]="���ܺ�������,��ȡ����֮��";
$MissionDialog[29209,10002]="��˵���ܵ����ݿ������ɻ������ᱣ�������";
$MissionDialog[29209,10005]="������������ˡ�";

$MissionDialog[29210,10001]="���ܺ�������,��ȡ����֮��";
$MissionDialog[29210,10002]="���ܵ��۾�����챦ʯһ���������⣬��ĺ���Ҫ";
$MissionDialog[29210,10005]="������������ˡ�";

$MissionDialog[29211,10001]="���ܲ�ѩ��ʦ����ȡ��ʦ��";
$MissionDialog[29211,10002]="��ʦ�ķ����治���أ�Ӧ��������һЩ�ú��о�";
$MissionDialog[29211,10005]="������������ˡ�";

$MissionDialog[29212,10001]="���ܲ�ѩ��ʦ����ȡ��ʦ����";
$MissionDialog[29212,10002]="����ʦ���Ǽ��뵽�����У������Ӻܴ��������";
$MissionDialog[29212,10005]="������������ˡ�";

$MissionDialog[29213,10001]="���ܲ�ѩ��ʦ����ȡǬ����";
$MissionDialog[29213,10002]="��˵��ʦ��Ǭ���������кõ�С�����������������Ʒ��";
$MissionDialog[29213,10005]="������������ˡ�";

$MissionDialog[29214,10001]="���ܲ�ѩ��ʦ����ȡ��ʦӡ";
$MissionDialog[29214,10002]="�������ʦӡ�Ƿ������ӡһ���أ�����ϸ��һ��";
$MissionDialog[29214,10005]="������������ˡ�";

$MissionDialog[29215,10001]="���ܲ�ɽҰ�ˣ���ȡҰ��ͷ��";
$MissionDialog[29215,10002]="Ұ�˵�ͷ���պö��Һ�����";
$MissionDialog[29215,10005]="������������ˡ�";

$MissionDialog[29216,10001]="���ܲ�ɽҰ�ˣ���ȡҰ��ë��";
$MissionDialog[29216,10002]="Ұ�˲����·�Ҳ�����䣬ë��Ӧ�úܱ�ů��";
$MissionDialog[29216,10005]="������������ˡ�";

$MissionDialog[29217,10001]="����ѩ������ȡѩ���ڵ�";
$MissionDialog[29217,10002]="ѩ�����ڵ�����һζ�ܺõ�ҩ��";
$MissionDialog[29217,10005]="������������ˡ�";

$MissionDialog[29218,10001]="����ѩ������ȡѩ��֮β";
$MissionDialog[29218,10002]="ѩ����β��ëɫ�ܲ����أ��������ÿ����·���";
$MissionDialog[29218,10005]="������������ˡ�";

$MissionDialog[29219,10001]="����ѩ������ȡѩ�����";
$MissionDialog[29219,10002]="������ѩ�������������������ò�����";
$MissionDialog[29219,10005]="������������ˡ�";

$MissionDialog[29220,10001]="����ѩ������ȡѩ��֮��";
$MissionDialog[29220,10002]="ѩ����Ӳ�Ľǣ�Ҳ�Ǻ���ɱ�����ģ�����������ǹ";
$MissionDialog[29220,10005]="������������ˡ�";

$MissionDialog[29221,10001]="����ѩ������ȡѩ��ëƤ";
$MissionDialog[29221,10002]="Ҫ����ѩ����ëƤ���·�Ӧ�ø���ů��";
$MissionDialog[29221,10005]="������������ˡ�";

$MissionDialog[29222,10001]="����ѩ������ȡѩ��֮צ";
$MissionDialog[29222,10002]="צ����Ȼ������������������ҩ�ƣ���ЧҲ�Ǻܲ����";
$MissionDialog[29222,10005]="������������ˡ�";

$MissionDialog[29223,10001]="����ѩ������ȡѩ�����";
$MissionDialog[29223,10002]="��ô�캮�ض��ĵط��������Ļ�ֻ��ѩ���������";
$MissionDialog[29223,10005]="������������ˡ�";

$MissionDialog[29224,10001]="���ܽ�ū����ȡ��ū����";
$MissionDialog[29224,10002]="�����м��뽣ū���ǣ���ʹ������������";
$MissionDialog[29224,10005]="������������ˡ�";

$MissionDialog[29225,10001]="���ܽ�ū����ȡ��֮����";
$MissionDialog[29225,10002]="��ū���ǽ����������ռ�һЩ��֮����Ҳ�Ǵ��кô�";
$MissionDialog[29225,10005]="������������ˡ�";

$MissionDialog[29226,10001]="���ܽ�ū����ȡ��ū�꾧";
$MissionDialog[29226,10002]="��ū�ľ���������˾��壬������ֱ��ʹ�ã�����������ϲ���о��о�";
$MissionDialog[29226,10005]="������������ˡ�";

$MissionDialog[29227,10001]="�ɼ�������";
$MissionDialog[29227,10002]="����������Ĳ�ҩ�����ˣ���ȥ���Ҳ�ժһЩ��";
$MissionDialog[29227,10005]="������������ˡ�";

$MissionDialog[29228,10001]="����ľ��";
$MissionDialog[29228,10002]="�������ʳ�ﴢ���������ľ����ܰ��Ұ������";
$MissionDialog[29228,10005]="������������ˡ�";

$MissionDialog[29229,10001]="�ռ����ϵĴ̹Ǻ�˪";
$MissionDialog[29229,10002]="ȥ���ϰѴ̹Ǻ�˪�ռ�������˵�����кܴ���ô���";
$MissionDialog[29229,10005]="������������ˡ�";

$MissionDialog[29230,10001]="��ժ����Ҷ";
$MissionDialog[29230,10002]="�������±��ϵ�����Ҷ�������صĹ�Ч����ժһЩ���ͺ�";
$MissionDialog[29230,10005]="������������ˡ�";

$MissionDialog[29231,10001]="��ժѩ�ɹ�";
$MissionDialog[29231,10002]="ѩ�ɹ�Ҳ�Ǻܺõ�ʳ�ģ�ȥ����ժһ����";
$MissionDialog[29231,10005]="������������ˡ�";

$MissionDialog[29232,10001]="�����龧";
$MissionDialog[29232,10002]="�龧��������Ө��͸�ģ�����������һ���ÿ�";
$MissionDialog[29232,10005]="������������ˡ�";

$MissionDialog[29233,10001]="�ɼ�������";
$MissionDialog[29233,10002]="��������������������Ƕ����Ʒ���кܺõ�Ч����";
$MissionDialog[29233,10005]="������������ˡ�";

$MissionDialog[29234,10001]="�ռ�����Һ";
$MissionDialog[29234,10002]="ʹ������Һ�Ļ���������Ч�����ã���취ȥŪһЩ��";
$MissionDialog[29234,10005]="������������ˡ�";

$MissionDialog[29235,10001]="���˲��";
$MissionDialog[29235,10002]="���Ұ�һЩ���ɣ�������������Ҳ�����";
$MissionDialog[29235,10005]="������������ˡ�";

$MissionDialog[29236,10001]="��ȱ�������ʿ";
$MissionDialog[29236,10002]="������ʿ����ʦץ���ˣ����ܰ����ǾȻ�����";
$MissionDialog[29236,10005]="������������ˡ�";

$MissionDialog[29237,10001]="���⽣̨";
$MissionDialog[29237,10002]="ȥ���Ҽ��һ�·⽣̨��ʲô����";
$MissionDialog[29237,10005]="������������ˡ�";

$MissionDialog[29238,10001]="�ƻ���ѩӪ������";
$MissionDialog[29238,10002]="��Ҫǰȥ�Ѳ�ѩӪ�������ƻ���";
$MissionDialog[29238,10005]="������������ˡ�";

$MissionDialog[29239,10001]="�ɼ�ѩ�޲�";
$MissionDialog[29239,10002]="ѩ�޲ݿ�����ûʲô�ر𣬵����кܺõ���������";
$MissionDialog[29239,10005]="������������ˡ�";

$MissionDialog[29240,10001]="�鿴�⽣ӡ��";
$MissionDialog[29240,10002]="�⽣ӡ��Ҫ�Ǳ��ƻ��ˣ�ħ����Ҫ���Ʒ�ӡ���Ͻ�ȥ�鿴һ��";
$MissionDialog[29240,10005]="������������ˡ�";

$MissionDialog[29241,10001]="�ɼ�������";
$MissionDialog[29241,10002]="����������Ҳ����Ҫ�����ݣ���ȥ���Ҳ�һЩ������";
$MissionDialog[29241,10005]="������������ˡ�";

$MissionDialog[29242,10001]="�һ���ʧ�Ļ���";
$MissionDialog[29242,10002]="Ľ�ݹ������ҵĻ������ˣ����ܰ����һ�����";
$MissionDialog[29242,10005]="������������ˡ�";

$MissionDialog[29243,10001]="�鿴�׻�̨";
$MissionDialog[29243,10002]="�׻�̨�����Ƶ��ˣ�ȥ�鿴һ���Ǻ�����Ϊ";
$MissionDialog[29243,10005]="������������ˡ�";

$MissionDialog[29244,10001]="�ռ�ԭʯ";
$MissionDialog[29244,10002]="��˵Ľ�ݹ���ϲ���о���ֵ�ʯͷ��ȥ��һЩ��������";
$MissionDialog[29244,10005]="������������ˡ�";

$MissionDialog[29245,300]="��л�ˣ�����ѩ����̿ѽ";
$MissionDialog[29245,10001]="Ѱ�ҽ����";
$MissionDialog[29245,10002]="�캮�ض��Ľ����һ�������⣬�����͵�ȡů��̼���";
$MissionDialog[29245,10005]="������������ˡ�";

$MissionDialog[29246,300]="������·�ˣ�лл�������һؼ�";
$MissionDialog[29246,10001]="Ѱ��������";
$MissionDialog[29246,10002]="���ƹ������߶��ˣ�����ȥ�����һ�����";
$MissionDialog[29246,10005]="������������ˡ�";

$MissionDialog[29247,300]="��ѩӪ����ʦ�ɲ��öԸ�ѽ";
$MissionDialog[29247,10001]="Ѱ���ԭZ";
$MissionDialog[29247,10002]="���ԭZѯ��һ�²�ѩӪ�����������";
$MissionDialog[29247,10005]="������������ˡ�";

$MissionDialog[29248,300]="ѩ��ƽԭ����һ�㶼��ƽ����";
$MissionDialog[29248,10001]="Ѱ������";
$MissionDialog[29248,10002]="������ѯ��ѩ��ƽԭ���������";
$MissionDialog[29248,10005]="������������ˡ�";

$MissionDialog[29249,300]="����Ϳ������ˣ�ֻ�Ǽ�װ��֪������Ҫ���ұ���Ӵ";
$MissionDialog[29249,10001]="Ѱ��Ľ������";
$MissionDialog[29249,10002]="����ϲ��Ľ�ݹ���ܾ��ˣ�ϣ�����ܰ������ﰮ��";
$MissionDialog[29249,10005]="������������ˡ�";

$MissionDialog[29250,300]="�������������ţ����Բ����ʲô����";
$MissionDialog[29250,10001]="Ѱ����־��";
$MissionDialog[29250,10002]="����־��ѯ�ʷ⽣̨���������";
$MissionDialog[29250,10005]="������������ˡ�";

//------------------------------------------------------------------------
$MissionDialog[ 29301, 10001 ]="����Ť������";
$MissionDialog[ 29301, 10002 ]="�������ڱؾ�֮·����סȥ·������ͨ�кܲ�����";
$MissionDialog[ 29301, 10005 ]="������������ˡ�";

$MissionDialog[ 29302, 10001 ]="���ܹ�����è";
$MissionDialog[ 29302, 10002 ]="��è�����ڴ˰�ռ�����֣����ݲ�������Ҫȥ��ѵһ�²���";
$MissionDialog[ 29302, 10005 ]="������������ˡ�";

$MissionDialog[ 29303, 10001 ]="���̶ܱ����";
$MissionDialog[ 29303, 10002 ]="��Щ�������о綾���ٲ���ȥһЩ�������������ж�";
$MissionDialog[ 29303, 10005 ]="������������ˡ�";

$MissionDialog[ 29304, 10001 ]="��������ħ��";
$MissionDialog[ 29304, 10002 ]="�ٲ�������Щ����ħ����������������Ҫ����������";
$MissionDialog[ 29304, 10005 ]="������������ˡ�";

$MissionDialog[ 29305, 10001 ]="����ľ����";
$MissionDialog[ 29305, 10002 ]="ľ��������͵����Ȫ���ð����Ǹ��ܲ���";
$MissionDialog[ 29305, 10005 ]="������������ˡ�";

$MissionDialog[ 29306, 10001 ]="���ܱ��캣��";
$MissionDialog[ 29306, 10002 ]="��Щ��������ˣ�����������̲�ϣ��ð����Ǹϻ�ȥ";
$MissionDialog[ 29306, 10005 ]="������������ˡ�";

$MissionDialog[ 29307, 10001 ]="����δ���ε�����ħ��";
$MissionDialog[ 29307, 10002 ]="Ҫ����ħ������֮ǰ�Ͳ����ɾ����";
$MissionDialog[ 29307, 10005 ]="������������ˡ�";

$MissionDialog[ 29308, 10001 ]="����Ť������,��������";
$MissionDialog[ 29308, 10002 ]="��˵�����������������������������;�ɾͷǳ�����";
$MissionDialog[ 29308, 10005 ]="������������ˡ�";

$MissionDialog[ 29309, 10001 ]="����Ť������,�������";
$MissionDialog[ 29309, 10002 ]="������������Դ�����ϵ������Ҫ����ժһЩ��������������������ʳ����";
$MissionDialog[ 29309, 10005 ]="������������ˡ�";

$MissionDialog[ 29310, 10001 ]="���ܹ�����è����ȡ��è�嵶";
$MissionDialog[ 29310, 10002 ]="��˵��è�������ֳֵ����ֳָ��������׺ݣ�Ҫ��������һЩ�����ͺ���";
$MissionDialog[ 29310, 10005 ]="������������ˡ�";

$MissionDialog[ 29311, 10001 ]="���ܹ�����è����ȡ��è������";
$MissionDialog[ 29311, 10002 ]="��è���˵����׿��Ƽ򵥣�������ȴ���ˣ������һЩ���о��о�";
$MissionDialog[ 29311, 10005 ]="������������ˡ�";

$MissionDialog[ 29312, 10001 ]="���ܹ�����è����ȡ��è�師";
$MissionDialog[ 29312, 10002 ]="��˵��è�������ֳֵ����ֳָ��������׺ݣ�Ҫ��������һЩ�����ͺ���";
$MissionDialog[ 29312, 10005 ]="������������ˡ�";

$MissionDialog[ 29313, 10001 ]="���̶ܱ���ܣ���ȡ���Ƥ";
$MissionDialog[ 29313, 10002 ]="��ܵĶ�����Ƥ��ҩ��Ҳ����Ƥ��ҩʦ��ŪЩ���Ƥ���ͺ���";
$MissionDialog[ 29313, 10005 ]="������������ˡ�";

$MissionDialog[ 29314, 10001 ]="���̶ܱ���ܣ���ȡ�����";
$MissionDialog[ 29314, 10002 ]="��ܰ�Ƥ֮�����Ҳ�ǿ���ʳ�õģ��ر������ϵ����Ϊ����";
$MissionDialog[ 29314, 10005 ]="������������ˡ�";

$MissionDialog[ 29315, 10001 ]="���̶ܱ���ܣ���ȡ�������";
$MissionDialog[ 29315, 10002 ]="��ܹ�����������Ҳ�Ǵ���Ǭ�����ռ������д��ô���";
$MissionDialog[ 29315, 10005 ]="������������ˡ�";

$MissionDialog[ 29316, 10001 ]="��������ħ������ȡ���黨��";
$MissionDialog[ 29316, 10002 ]="����ħ������Ϊʳ��ȫ��Կ�Ϊҩ��ȥ�ռ�һЩ���黨����";
$MissionDialog[ 29316, 10005 ]="������������ˡ�";

$MissionDialog[ 29317, 10001 ]="��������ħ������ȡ���黨��";
$MissionDialog[ 29317, 10002 ]="����ħ������Ϊʳ��ȫ��Կ�Ϊҩ��ȥ�ռ�һЩ���黨���";
$MissionDialog[ 29317, 10005 ]="������������ˡ�";

$MissionDialog[ 29318, 10001 ]="��������ħ������ȡ���黨��";
$MissionDialog[ 29318, 10002 ]="����ħ������Ϊʳ��ȫ��Կ�Ϊҩ��ȥ�ռ�һЩ���黨���";
$MissionDialog[ 29318, 10005 ]="������������ˡ�";

$MissionDialog[ 29319, 10001 ]="��������ħ������ȡ���黨Ҷ";
$MissionDialog[ 29319, 10002 ]="����ħ������Ϊʳ��ȫ��Կ�Ϊҩ��ȥ�ռ�һЩ���黨Ҷ��";
$MissionDialog[ 29319, 10005 ]="������������ˡ�";

$MissionDialog[ 29320, 10001 ]="����ľ���ޣ�ľ����β��";
$MissionDialog[ 29320, 10002 ]="ľ����Ϊľ�޽���壬β��ȱ�������������Ʒ�ĺò���";
$MissionDialog[ 29320, 10005 ]="������������ˡ�";

$MissionDialog[ 29321, 10001 ]="����ľ���ޣ�ľ����֮צ";
$MissionDialog[ 29321, 10002 ]="ľ����Ϊľ�޽���壬צ�ӻ�����ô�����������������ĺò���";
$MissionDialog[ 29321, 10005 ]="������������ˡ�";

$MissionDialog[ 29322, 10001 ]="����ľ���ޣ�ľ����֮��";
$MissionDialog[ 29322, 10002 ]="ľ����Ϊľ�޽���壬���ݻ�����ô��Ӳ�������������ĺò���";
$MissionDialog[ 29322, 10005 ]="������������ˡ�";

$MissionDialog[ 29323, 10001 ]="���ܱ��캣�࣬��ȡ����֮��";
$MissionDialog[ 29323, 10002 ]="���캣���Ӳ����ǣ�������������ò�����";
$MissionDialog[ 29323, 10005 ]="������������ˡ�";

$MissionDialog[ 29324, 10001 ]="���ܱ��캣�࣬����֮צ";
$MissionDialog[ 29324, 10002 ]="���������צ�ӣ��������������";
$MissionDialog[ 29324, 10005 ]="������������ˡ�";

$MissionDialog[ 29325, 10001 ]="���ܱ��캣�࣬����֮��";
$MissionDialog[ 29325, 10002 ]="Ҫ�����к���֮���Ļ����ں����ƶ���ܿ�Ŷ";
$MissionDialog[ 29325, 10005 ]="������������ˡ�";

$MissionDialog[ 29326, 10001 ]="�ɼ�����";
$MissionDialog[ 29326, 10002 ]="���������ֹ����ҩ�����������ܴ���ô�����ȥ��æ�ɼ�һЩ����";
$MissionDialog[ 29326, 10005 ]="������������ˡ�";

$MissionDialog[ 29327, 10001 ]="�ɼ�����";
$MissionDialog[ 29327, 10002 ]="���ʵ�������Ƿǳ������ʳ��";
$MissionDialog[ 29327, 10005 ]="������������ˡ�";

$MissionDialog[ 29328, 10001 ]="�ɼ��ɻ�";
$MissionDialog[ 29328, 10002 ]="�������ֳ��еĺɻ������ǳ�ïʢ��";
$MissionDialog[ 29328, 10005 ]="������������ˡ�";

$MissionDialog[ 29329, 10001 ]="�ռ�¶ˮ";
$MissionDialog[ 29329, 10002 ]="�����е�¶ˮ����һζ�ܺõ�ҩ��";
$MissionDialog[ 29329, 10005 ]="������������ˡ�";

$MissionDialog[ 29330, 10001 ]="�ɻ���ˮ";
$MissionDialog[ 29330, 10002 ]="����û����Ȫ����ɻ����е�ˮҲ����ͨ��ϪˮҪ��";
$MissionDialog[ 29330, 10005 ]="������������ˡ�";

$MissionDialog[ 29331, 10001 ]="�ɼ���Ҷ";
$MissionDialog[ 29331, 10002 ]="��Ҷ����û��ʲô���ã���ʵҲ������������Ʒ��Ŷ";
$MissionDialog[ 29331, 10005 ]="������������ˡ�";

$MissionDialog[ 29332, 10001 ]="�ռ���Ȫ";
$MissionDialog[ 29332, 10002 ]="ʳ���м���һЩ��Ȫ���ͻ�����ζ�ޱ���";
$MissionDialog[ 29332, 10005 ]="������������ˡ�";

$MissionDialog[ 29333, 10001 ]="�ɼ�Ģ��";
$MissionDialog[ 29333, 10002 ]="Ģ����Ȼ����Ϊҩ������Ҳ������Ϊ���ʳ�ĵ�";
$MissionDialog[ 29333, 10005 ]="������������ˡ�";

$MissionDialog[ 29334, 10001 ]="�ɼ�������";
$MissionDialog[ 29334, 10002 ]="�ռ�һЩ����ɳ̲���������������һ����кܴ���ô�";
$MissionDialog[ 29334, 10005 ]="������������ˡ�";

$MissionDialog[ 29335, 10001 ]="�ɼ�������";
$MissionDialog[ 29335, 10002 ]="�ɼ�һЩ�����ǣ���������Ư���Ļ���";
$MissionDialog[ 29335, 10005 ]="������������ˡ�";

$MissionDialog[ 29336, 10001 ]="�ɼ��ݲ�";
$MissionDialog[ 29336, 10002 ]="�ռ�һЩ�ݲ��������һ����кܴ���ô���";
$MissionDialog[ 29336, 10005 ]="������������ˡ�";

$MissionDialog[ 29337, 10001 ]="����ˮ�ֳ�";
$MissionDialog[ 29337, 10002 ]="���������ˮ�ֳ����ˣ��ܰ���ȥ����һ����";
$MissionDialog[ 29337, 10005 ]="������������ˡ�";

$MissionDialog[ 29338, 10001 ]="�о��ʺ���";
$MissionDialog[ 29338, 10002 ]="����Ĳʺ��Ȼ���ԲŲ���ȥ���Ǻ�ԭ�򣬿ɷ�ȥ�о��о�";
$MissionDialog[ 29338, 10005 ]="������������ˡ�";

$MissionDialog[ 29339, 10001 ]="�ɼ�Ҭ��";
$MissionDialog[ 29339, 10002 ]="ɳ̲�ϵ�Ҭ�ӿ��Ƿǳ���ζ��";
$MissionDialog[ 29339, 10005 ]="������������ˡ�";

$MissionDialog[ 29340, 10001 ]="�ɼ�����ֲ��";
$MissionDialog[ 29340, 10002 ]="�ռ�һЩ����ɳ̲�ϵĶ���ֲ��ҿ����кܴ���ô�";
$MissionDialog[ 29340, 10005 ]="������������ˡ�";

$MissionDialog[ 29341, 10001 ]="�ռ�Ϫˮ";
$MissionDialog[ 29341, 10002 ]="������������ҪһЩϪˮ�����";
$MissionDialog[ 29341, 10005 ]="������������ˡ�";

$MissionDialog[ 29342, 10001 ]="�̶���";
$MissionDialog[ 29342, 10002 ]="ͣ���ڱ��ϵ��񷤿챻�����ˣ�����ȥ�������";
$MissionDialog[ 29342, 10005 ]="������������ˡ�";

$MissionDialog[ 29343, 10001 ]="�������¯";
$MissionDialog[ 29343, 10002 ]="�ҵ�����¯��Ļ�֪��Ϩ����û�У�����ȥ���һ�°�";
$MissionDialog[ 29343, 10005 ]="������������ˡ�";

$MissionDialog[ 29344, 10001 ]="�ɼ�����";
$MissionDialog[ 29344, 10002 ]="����������ڵ������Ŷ����Ҫ�ԵĻ���Ҫ�����﷭����";
$MissionDialog[ 29344, 10005 ]="������������ˡ�";

$MissionDialog[ 29345, 10001 ]="�����Ӳ�";
$MissionDialog[ 29345, 10002 ]="��ֲ����ĵ������������Ӳݣ��鷳���ҳ�ȥһЩ�Ӳݰ�";
$MissionDialog[ 29345, 10005 ]="������������ˡ�";

$MissionDialog[ 29346, 300 ]="�������������ˣ�ʲô���鶼û��";
$MissionDialog[ 29346, 10001 ]="�Ի�С����";
$MissionDialog[ 29346, 10002 ]="ǰ��ѯ��С������ʲô��Ҫ��æ��";
$MissionDialog[ 29346, 10005 ]="������������ˡ�";

$MissionDialog[ 29347, 300 ]="�̫��Σ�գ�û��ʵ�������Ҳ����������";
$MissionDialog[ 29347, 10001 ]="�Ի�ѩܰ";
$MissionDialog[ 29347, 10002 ]="ǰ��ѯ��ѩܰ������Թ������";
$MissionDialog[ 29347, 10005 ]="������������ˡ�";

$MissionDialog[ 29348, 300 ]="��Ҫ��ҩ���Ҷ��ռ����ˣ����Ͼ��͹�ȥ";
$MissionDialog[ 29348, 10001 ]="�Ի���ƽ��";
$MissionDialog[ 29348, 10002 ]="ǰ��ѯ����ƽ��ҩ���Ƿ��ռ����";
$MissionDialog[ 29348, 10005 ]="������������ˡ�";

$MissionDialog[ 29349, 300 ]="���������￴�أ���������Ȫ�������";
$MissionDialog[ 29349, 10001 ]="�Ի��ɶ�";
$MissionDialog[ 29349, 10002 ]="ǰ��ѯ�ʿɶ���Ȫ�Ƿ�������";
$MissionDialog[ 29349, 10005 ]="������������ˡ�";

$MissionDialog[ 29350, 300 ]="�����Ұ�����չ���Ĳ�ľ�������Ż�������ľ�޽����";
$MissionDialog[ 29350, 10001 ]="�Ի��ɶ�";
$MissionDialog[ 29350, 10002 ]="ǰ��ѯ�ʿɶ�ľ����ԭ��";
$MissionDialog[ 29250, 10005 ]="������������ˡ�";

//------------------------------------------------------

function MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 300:	return "<t>" @ $MissionDialog[%Mid,%Tid] @ "</t><b/>";
		case 10001:	return "<t>" @ $MissionDialog[%Mid,%Tid] @ "</t><b/>";
		case 10002:	return "<t>" @ $MissionDialog[%Mid,%Tid] @ "</t><b/>";
		case 10005:	return "<t>" @ $MissionDialog[%Mid,%Tid] @ "</t><b/>";
		case 910:
			if (%Player.IsAcceptedMission(%Mid))
			{
				%Begin = 4025;
				%End = 4029;
			}
			else
			{
				%Mapid = GetZoneID();
				%Begin = $XuanShangJiXiong[%MapID,0];
				%End = $XuanShangJiXiong[%MapID,9];
			}
			for (%i = %Begin; %i <= %End; %i++)
			{
				%MidID = GetAct(%Player,%i,0) + 29000;
				if (%MidID == %Mid)
				{
					%CoLor =  GetAct(%Player,%i,1);
					break;
				}
			}
			%MissionData_Exp = GetMissionData(%Mid,$Mission_Data_OtherRecordA);
			switch (%CoLor)
			{
				case 1:%ExpBeiShu = 1;
				case 2:%ExpBeiShu = 1.3;
				case 3:%ExpBeiShu = 1.8;
				case 4:%ExpBeiShu = 2.8;
				case 5:%ExpBeiShu = 4;
				case 6:%ExpBeiShu = 5;
			}
			%Exp = %MissionData_Exp * %ExpBeiShu;
			%Exp = mfloor(%Exp);
			%ShowNumber = %Mid%1000;
			if (%CoLor >= 2)
			{
				%MapID = GetZoneID();
				%Player.ClearMissionItem(%ShowNumber);	//���֮ǰ����Ʒ��ʾ
				for (%i = 1; %i <=99; %i++)
				{
					//echo( "$XuanShangJiXiongItem[ " @ %MapID @ "," @ %CoLor @ "," @  %i @ " ]====" @ $XuanShangJiXiongItem[ %MapID, %CoLor, %i ] );
					if ($XuanShangJiXiongItem[%MapID,%CoLor,%i] $= "")
						break;
					%ItemID = GetWord($XuanShangJiXiongItem[%MapID,%CoLor,%i],0);
					%ItemNum = GetWord($XuanShangJiXiongItem[%MapID,%CoLor,%i],2);
					%Player.AddItemToMission(%ShowNumber,1,%ItemID,%ItemNum);
				}
			}


			%Txt = "<t>�������������� </t>" @ $Get_Dialog_GeShi[31409] @ %ExpBeiShu @ "</t><b/>";
			%Exp = $Get_Dialog_GeShi[31403] @ "���齱����</t>" @ %Exp @ "<b/>";
			if (%CoLor >= 2)
				%Item = $Get_Dialog_GeShi[31403] @ "�м��ʻ��������Ʒ�е�һ�֣�</t><b/>" @ GetFixedMissionItemText(%ShowNumber);
			//echo( "%Item ===" @ %Item );
			return $Get_Dialog_GeShi[31401] @ %Txt @ %Exp @ %Item @ "</t>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}

function Mission29999Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ɱ��</t><b/>";
		case 10002:	return "<t>ɱ��</t><b/>";
		case 10005:	return "<t>ɱ��</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
//�����������������������������������ͼ��ס�����Ի���������������������������������