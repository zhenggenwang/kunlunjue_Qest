
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
//���������������������������ͻ������񡿡����������������԰ײ��֡�����������������������������

//������������������������������������԰ס�����������������������������

function Mission20103Dialog(%Npc,%Player,%Mid,%Tid)		   //����֮��
{
	switch (%Tid)
	{
		case 10001:	return "<t>�����������������֮�ϵĺ���֮˪Ϊ��������ȥ����֮��ȡ�����������͡�</t><b/>";
		case 10002:	return "<t>���Ĳ���</t><b/>";
		case 10005:	return "<t>�ɼ�����֮˪*5</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission20104Dialog(%Npc,%Player,%Mid,%Tid)		   //�һ�֮��
{
	switch (%Tid)
	{
		case 10001:	return "<t>���������������Ȫ֮�µ��һ�֮��Ϊ��������ȥ����֮��ȡ������������</t><b/>";
		case 10002:	return "<t>���Ĳ���</t><b/>";
		case 10005:	return "<t>�ɼ��һ�֮��*5</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission20105Dialog(%Npc,%Player,%Mid,%Tid)		   //�������
{
	switch (%Tid)
	{
		case 10001:	return "<t>�����µ�������������֮�صĺ��������͵�㣬��Ϊһ�����ҵ�����֮�ˣ��������ģ��»����⣬����ǰȥ������ħ��</t><b/>";
		case 10002:	return "<t>���Ĳ���</t><b/>";
		case 10005:	return "<t>���ܺ����*10</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission20106Dialog(%Npc,%Player,%Mid,%Tid)		   //��������
{
	switch (%Tid)
	{
		case 10001:	return "<t>�����µ�������������֮�ص�������Ϊ���ķ�����Ϊһ�����ҵ�����֮�ˣ��������ģ��»����⣬����ǰȥ������ħ��</t><b/>";
		case 10002:	return "<t>���Ĳ���</t><b/>";
		case 10005:	return "<t>����������*10</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission20107Dialog(%Npc,%Player,%Mid,%Tid)		   //��װ��ҩ��һ
{
	switch (%Tid)
	{
		case 10001:	return "<t>��Ȫ֮������ҩ�ѵ�����֮ʱ����ʹ�߿����¶��ȱ����ͨ��ǰȥ��ժ��ҩ�ؽ���ʹ��</t><b/>";
		case 10002:	return "<t>���Ĳ���</t><b/>";
		case 10005:	return "<t>�ɼ���ҩ</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission20108Dialog(%Npc,%Player,%Mid,%Tid)		   //��װ��ҩ����
{
	switch (%Tid)
	{
		case 10001:	return "<t>��Ȫ֮������ҩ�ѵ�����֮ʱ����ʹ�߿����¶��ȱ����ͨ��ǰȥ��ժ��ҩ�ؽ���ʹ��</t><b/>";
		case 10002:	return "<t>���Ĳ���</t><b/>";
		case 10005:	return "<t>�����βɼ���ҩ</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission20109Dialog(%Npc,%Player,%Mid,%Tid)		   //����֮�顤һ
{
	switch (%Tid)
	{
		case 10001:	return "<t>ǧ��ǰ���ŷ��ִ˵أ�������������ʱ���챦���������ȿ�ǰ������֮��������Ե������������</t><b/>";
		case 10002:	return "<t>���Ĳ���</t><b/>";
		case 10005:	return "<t>Ѱ���챦��</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission20110Dialog(%Npc,%Player,%Mid,%Tid)		   //����֮�顤��
{
	switch (%Tid)
	{
		case 10001:	return "<t>ǧ��ǰ���ŷ��ִ˵أ�������������ʱ���챦���������ȿ�ǰ������֮��������Ե������������</t><b/>";
		case 10002:	return "<t>���Ĳ���</t><b/>";
		case 10005:	return "<t>Ѱ������챦��</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission20115Dialog(%Npc,%Player,%Mid,%Tid)		   //������ħ
{
	switch (%Tid)
	{
		case 10001:	return "<t>Ⱥ������������������������ͷ�ߣ�����Ϊ��������֮���ӣ��ַ����ŷ�ּǰȥΧ��</t><b/>";
		case 10002:	return "<t>���Ĳ���</t><b/>";
		case 10005:	return "<t>���ܺ���֮��*1</t><b/>"
			@ "<t>��������֮��*1</t><b/>"
			@ "<t>�����ػ�֮��*1</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}


function Mission20148dialog(%Npc,%Player,%Mid,%Tid)//����
{
	%GeShi = 31203;
	switch (%Tid)
	{
		case 10001:	return "<t>���ջ������ָ�����ҵ����������顣</t><b/>";
		case 10002:	return "<t>�ұ���ʿ������ն����ħΪ���Σ��κα����ε�Ӱֻ���������ģ����Դ����һ��֮����</t><b/>" @ $Get_Dialog_GeShi[31403] @ "��ȡ��������Ҫ�۳�</t><t>[</t>" @ ChangeMoneyText(6000) @ "<t>]</t><b/>";
		case 10005:	return "<t>����������ĳ��͡�</t><b/>";
		case 910:
			%Player.ClearMissionItem(%Mid);
			%Player.AddItemToMission(%Mid,1,113090002,1);
			%Text = $Get_Dialog_GeShi[%GeShi] @ "	���ʻ�ý�����</t><b/>" @ GetFixedMissionItemText(%Mid) @ "<b/>";
			return %Text;
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}

function Mission20149dialog(%Npc,%Player,%Mid,%Tid)//ʦ�ž���
{
	%GeShi = 31203;
	%MidTarget = %player.getmissionflag(%Mid,10300);
	//echo( "%MidTarget===" @ %MidTarget );
	%Act4015[0] = GetAct(%player,4015,0);
	%Act4015[1] = GetAct(%player,4015,1);
	switch (%Tid)
	{
		case 10001:
			switch (%MidTarget)
			{
				case 410100003:	return "<t>����ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	��ҵ
				case 410100004:	return "<t>����ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	����
				case 410100005:	return "<t>����ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	����
				case 410100006:	return "<t>��ʦ��ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	��ƽ��
				case 410100007:	return "<t>��ʦ��ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	����ʯ
				case 410100008:	return "<t>��ʦ��ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	�ŵ�ɽ
				case 410100009:	return "<t>����ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	����
				case 410100011:	return "<t>������ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	��֪��
				case 410100032:	return "<t>��ͯ��ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	����
				case 410100031:	return "<t>��ͯ��ѯ��������ɽ�����</t><b/>"; ////�Ի�NPC 	ɲ��
				case 108020994:	return "<t>�ɹ���������֮�ｻ�����š�</t><b/>"; ////�����Ʒ	���ɲ�˿
				case 108020995:	return "<t>�ɹ���������֮�ｻ�����š�</t><b/>"; ////�����Ʒ	������
				case 108020996:	return "<t>�ɹ���������֮�ｻ�����š�</t><b/>"; ////�����Ʒ	������
				case 108020997:	return "<t>�ɹ���������֮�ｻ�����š�</t><b/>"; ////�����Ʒ	ǧ������
				case 108020998:	return "<t>�ɹ���������֮�ｻ�����š�</t><b/>"; ////�����Ʒ	��ľ
				case 108020999:	return "<t>�ɹ���������֮�ｻ�����š�</t><b/>"; ////�����Ʒ	����ʯ
				case 108021000:	return "<t>�ɹ���������֮�ｻ�����š�</t><b/>"; ////�����Ʒ	��������
				case 108021002:	return "<t>��ȥװһƿ��Ȫ���������������</t><b/>"; //�����Ʒ	����Ȫ 108021001	��ƿ��
				case 552000010:	return "<t>Ϊ����Ѱ������������ġ�</t><b/>"; ////�ɼ�	�����
				case 552000011:	return "<t>Ϊ����Ѱ������������ġ�</t><b/>"; ////�ɼ�	���ľ
				case 552000012:	return "<t>Ϊ����Ѱ������������ġ�</t><b/>"; ////�ɼ�	������
				case 552000013:	return "<t>�м�ҳ�������Ʈ���ˣ���ȥѰ����</t><b/>"; ////�ɼ�	����
				case 552000014:	return "<t>Ϊ����Ѱ������������ġ�</t><b/>"; ////�ɼ�	����¶
				case 553000050:	return "<t>�����������һ�Ρ�</t><b/>"; ////�ɼ�	��������
				case 410101020:	return "<t>��ն������նԪ��</t><b/>"; ////��ս��ħ	��ħ
				case 410101002:	return "<t>���������������û</t><b/>";
				case 410101004:	return "<t>�з�����������û</t><b/>";
				case 410101014:	return "<t>�鹽С���ڽ��س�û</t><b/>";
				case 410101015:	return "<t>�����ڽ��س�û</t><b/>";
				default:return "<t>�������ﷱæ����ǰȥѯ���Ƿ���Ҫ������Ϊ���ɹ���һ��������</t><b/>";
			}
		case 10002:	return "<t>�����������࣬���ԸΪ�����ֵ�һЩ��Ϊ�������������һ������</t><b/>";
		case 10005:	return "<t>���������������ˡ�</t><b/>";
		case 910:
			%exp = 62;
			%Level = %Player.getlevel();
			if (%Level < 30) %levelxishu = 0.3;
			else if (%Level < 40) %levelxishu = 1;
			else if (%Level < 50) %levelxishu = 1.2;
			else if (%Level < 60) %levelxishu = 1.6;
			else if (%Level < 70) %levelxishu = 2;
			else %levelxishu = 2.2;
			//���辭��	EXP = ��62+����*8��*��ҵȼ���Ӧ���� * �ȼ�΢��ϵ��
			%exp = (%exp +  %Act4015[0] * 8) * $Monster_Exp[%Level,1] * %levelxishu;
			%Exp = mfloor(%Exp);
			%Exp = $Get_Dialog_GeShi[%GeShi] @ "	���齱����</t>" @ %exp @ "<b/>";
			if (%Act4015[0] == 10  && %Act4015[1] == 0)
			{
				%Player.ClearMissionItem(%Mid);
				%Player.AddItemToMission(%Mid,1,105109341,1);
				%Text = $Get_Dialog_GeShi[%GeShi] @ "	���⽱����</t><b/>" @ GetFixedMissionItemText(%Mid) @ "<b/>";
			}
			return %Exp @ %Text;
		case 400: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "ѯ�ʽ��� </t>";
		case 500:
			%ran = getrandom(1,3);
			switch (%ran)
			{
				case 1:%txt = "<t>���¶డ���Ҷ��������ˡ�</t>";
				case 2:%txt = "<t>���һ������ţ��˴����ң����ܷ��ġ�</t>";
				case 3:%txt = "<t>�⺣��ħ�ִ��������ˣ�����֮�ﰡ��</t>";
			}
			return %txt;

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}

function Mission20147Dialog(%Npc,%Player,%Mid,%Tid)//Ѻ��
{
	%GeShi = 31203;
	switch (%Tid)
	{
		case 10001:	return "<t>���ڳ�Ѻ�͵���ħ���ڣ�Ѱ������ͷ���</t><b/>";
		case 10002:	return "<t>��ȥ;��Σ�����أ�����ǧ���ġ�</t><b/>";
		case 10005:	return "<t>������������ˣ������ţ���Ǯ���ϡ�</t><b/>";
		case 910:
			%Act1 = GetAct(GetPlayer(),4018,1);
			%PinZhi1 = mfloor(%Act1/100);
			%DangCi1 = mfloor((%Act1 - %PinZhi1 * 100)/10);
			%IsBrok1 = %Act1%10;
			%State1 = $YaBiaoHuoDong_StateRecord[%PinZhi1,%DangCi1];
			if (%IsBrok1 == 1)
				%PlayerMoney = GetWord($YaBiaoHuoDong_Gold[%State1],3);
			else
				%PlayerMoney = GetWord($YaBiaoHuoDong_Gold[%State1],5);
			//echo( "%PlayerMoney==" @ %PlayerMoney );
			if (%PlayerMoney * 1 == 0)
				%Money = $Get_Dialog_GeShi[%GeShi] @ "	��Ǯ��������߿ɻ�� </t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[600000055],3)) @ "<b/>";
			else
				%Money = $Get_Dialog_GeShi[%GeShi] @ "	��Ǯ������</t>" @ ChangeMoneyText(%PlayerMoney) @ "<b/>";
			//echo( "%Money==" @ %Money );
			%Player.ClearMissionItem(%Mid);
			if (%PinZhi1 != 0)
			{
				for (%i = 1; %i <= 99; %i++)
				{
					if ($YaBiaoHuoDong_Item[%PinZhi1,%i] $= "")
						break;
					%ItemID = GetWord($YaBiaoHuoDong_Item[%PinZhi1,%i],0);
					%Player.AddItemToMission(%Mid,1,%ItemID,1);
				}
				%Text = $Get_Dialog_GeShi[%GeShi] @ "	�м��ʻ��������Ʒ��</t><b/>" @ GetFixedMissionItemText(%Mid) @ "<b/>";
			}
			else
			{
				for (%i = 1; %i <= 99; %i++)
				{
					if ($YaBiaoHuoDong_Item[5,%i] $= "")
						break;
					%ItemID = GetWord($YaBiaoHuoDong_Item[5,%i],0);
					%Player.AddItemToMission(%Mid,1,%ItemID,1);
				}
				%Text = $Get_Dialog_GeShi[%GeShi] @ "	�м��ʻ��������Ʒ��</t><b/>" @ GetFixedMissionItemText(%Mid) @ "<b/>";
			}
			return %Money @ %Text;
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}

function Mission20028Dialog(%Npc,%Player,%Mid,%Tid)//�����ħ
{
	%GeShi = 31203;
	switch (%Tid)
	{
		case 10001:	return "<t>Ѱ����ħ������֮��</t><b/>";
		case 10002:	return "<t>��ħ��Ű���ݣ����ƶ񻯣�ʱ�����ң����������ذ��·���������ħͷ���ߣ��ɻ����ĵر�������Ϊ��</t><b/>";
		case 10005:	return "<t>������������ˡ�</t><b/>";
		case 910:
			%Level = %Player.GetLevel();
			if (%Level <= 45) %Exp= 60000;
			else if (%Level <= 60) %Exp= 99200;
			else if (%Level <= 75) %Exp= 154400;
			else if (%Level <= 90) %Exp= 230400;
			else if (%Level <= 100)%Exp= 331200;
			%Exp = $Get_Dialog_GeShi[%GeShi] @ "	���齱����</t>" @ %Exp @ "<b/>";
			%HuoYue = $Get_Dialog_GeShi[%GeShi] @ "	���ɻ�Ծ��</t>" @ 50 @ "<b/>";
			return %Exp @ %HuoYue;
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}

function Mission20029Dialog(%Npc,%Player,%Mid,%Tid){ Mission_20029_20035_Dialog(%Npc,%Player,%Mid,%Tid,1); }//ն����ħ��һ
function Mission20030Dialog(%Npc,%Player,%Mid,%Tid){ Mission_20029_20035_Dialog(%Npc,%Player,%Mid,%Tid,2); }//ն����ħ����
function Mission20031Dialog(%Npc,%Player,%Mid,%Tid){ Mission_20029_20035_Dialog(%Npc,%Player,%Mid,%Tid,3); }//ն����ħ����
function Mission20032Dialog(%Npc,%Player,%Mid,%Tid){ Mission_20029_20035_Dialog(%Npc,%Player,%Mid,%Tid,4); }//ն����ħ����
function Mission20033Dialog(%Npc,%Player,%Mid,%Tid){ Mission_20029_20035_Dialog(%Npc,%Player,%Mid,%Tid,5); }//ն����ħ����
function Mission20034Dialog(%Npc,%Player,%Mid,%Tid){ Mission_20029_20035_Dialog(%Npc,%Player,%Mid,%Tid,6); }//ն����ħ����
function Mission20035Dialog(%Npc,%Player,%Mid,%Tid){ Mission_20029_20035_Dialog(%Npc,%Player,%Mid,%Tid,7); }//ն����ħ����
function Mission_20029_20035_Dialog(%Npc,%Player,%Mid,%Tid,%MapNumber)
{
	%GeShi = 31203;
	switch (%Tid)
	{
		case 10001:	return "<t>ǰ���ع��ڣ�������ħ��</t><b/>";
		case 10002:	return "<t>�ع�֮�ڣ���ӡ�������������ܳ�һֻ��һֻ����ħ�������У�</t><b/>";
		case 10005:	return "<t>������������ˡ�</t><b/>";
		case 910:
			%OneExp = $Monster_Exp[%Player.Getlevel(),1];
			//���齱�� = ��ɱ������ * ����ȼ���Ӧ���ﾭ�� * 10%
			//echo( "%OneExp===" @ %OneExp );
			%FlagA = %Player.GetMissionFlag(%Mid,1200);
			%FlagB = %Player.GetMissionFlag(%Mid,1300);
			if (%FlagA >= %FlagB)
				%Exp = $Get_Dialog_GeShi[%GeShi] @ "	���齱����</t>" @ %OneExp * 10 @ "<t> + ???</t>" @ "<b/>";
			else
				%Exp = $Get_Dialog_GeShi[%GeShi] @ "	���齱����</t>" @ mfloor(%OneExp * %FlagB *  0.1) @ "<b/>";
			return %Exp;
	}

	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}

function Mission20150Dialog(%Npc,%Player,%Mid,%Tid)
{
	%GeShi = 31203;

	%Level = GetPlayer().GetLevel();


	switch (%Tid)
	{
		case 10001:	return "<t>ǰ��ָ���ĵ�ͼ����ָ���Ĺ��</t><b/>";
		case 10002:
			if (%Level <= 44) %Itemname = "<l i='105109321 ' t='itemid'/>";
			else if (%Level <= 59) %Itemname = "<l i='105109322 ' t='itemid'/>";
			else if (%Level <= 74) %Itemname = "<l i='105109323 ' t='itemid'/>";
			else if (%Level <= 89) %Itemname = "<l i='105109324 ' t='itemid'/>";
			else  %Itemname = "<l i='105109325 ' t='itemid'/>";

			return "<t>ֻҪ����10��</t>" @ %Itemname @ "<t>���ҽ�������һ���������ᡣ</t><b/>";
		case 10005:	return "<t>��������</t><b/>";
		case 910:
			%OneExp = $Monster_Exp[%Player.Getlevel(),1];
			//���齱�� = ��ɱ������ * ����ȼ���Ӧ���ﾭ�� * 10%
			%Exp = $Get_Dialog_GeShi[%GeShi] @ "	���齱����</t>" @ %OneExp * 1000 @ "<b/>";
			return %Exp;
	}

	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}

function Mission20146Dialog(%Npc,%Player,%Mid,%Tid)
{
	%GeShi = 31203;
	switch (%Tid)
	{
		case 10001:	return "<t>ǰ��ʦ���̵꣬Ϊ���糤�Ϲ�����</t><b/>";
		case 10002:
			return "<t>���糤�Ͼþ����أ���ҪЩ��ʦ�����ʣ����һص�������Ϊ���ϲɹ�һ����</t><b/>";
		case 10005:	return "<t>������ε�֪�������ģ���������ֻд��Ư��ƿ�����</t><b/>";
		case 910:
			%Level = %Player.GetLevel();
			%OneExp = $Monster_Exp[%Level,1];
			if (%Level < 40) %LevelXiShu = 1;
			else if (%Level < 50) %LevelXiShu = 1.2;
			else if (%Level < 60) %LevelXiShu = 1.6;
			else if (%Level < 70) %LevelXiShu = 2;
			else %LevelXiShu = 2.2;
			%Exp =  mfloor(%OneExp * 80 * %LevelXiShu);

			%Exp = $Get_Dialog_GeShi[%GeShi] @ "	���齱����</t>" @ %Exp @ "<b/>";
			return %Exp;
	}

	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}

function Mission20151Dialog(%Npc, %Player, %Mid, %Tid)//�ռ�����
{
	%GeShi = 31203;
	switch (%Tid)
	{
		case 10001:	return "<t>ն����ħ���ռ���ħ���ǡ�</t><b/><t>����ȼ����ɵ�������ȼ�10����</t><b/>";
		case 10002:	return "<t>��ħ��Ű��������ʿ�����˽�Ҫ�Գ�ħΪ���Σ�</t><b/>";
		case 10005:	return "<t>������������ˡ�</t><b/>";
		case 910:
			%Level = %Player.GetLevel();
			if (%Level <= 45) %Exp= 60000;
			else if (%Level <= 60) %Exp= 99200;
			else if (%Level <= 75) %Exp= 154400;
			else if (%Level <= 90) %Exp= 230400;
			else if (%Level <= 100)%Exp= 331200;
			%Exp = $Get_Dialog_GeShi[%GeShi] @ "	���齱����</t>" @ %Exp @ "<b/>";
			%HuoYue = $Get_Dialog_GeShi[%GeShi] @ "	���ɻ�Ծ��</t>" @ 50 @ "<b/>";
			return %Exp @ %HuoYue;
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}

function Mission20036Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 1); }//Ӣ������һ
function Mission20037Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 3); }//Ӣ��������
function Mission20038Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 5); }//Ӣ��������
function Mission20039Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 7); }//Ӣ��������
function Mission20040Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//Ӣ��������
function Mission20041Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//Ӣ��������
function Mission20042Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//Ӣ��������
function Mission20043Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 1); }//Ӣ������һ
function Mission20044Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 3); }//Ӣ��������
function Mission20045Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 5); }//Ӣ��������
function Mission20046Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 7); }//Ӣ��������
function Mission20047Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//Ӣ��������
function Mission20048Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//Ӣ��������
function Mission20049Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//Ӣ��������
function Mission20050Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 1); }//Ӣ������һ
function Mission20051Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 3); }//Ӣ��������
function Mission20052Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 5); }//Ӣ��������
function Mission20053Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 7); }//Ӣ��������
function Mission20054Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//Ӣ��������
function Mission20055Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//Ӣ��������
function Mission20056Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//Ӣ��������
function Mission20057Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 1); }//Ӣ������һ
function Mission20058Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 3); }//Ӣ��������
function Mission20059Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 5); }//Ӣ��������
function Mission20060Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 7); }//Ӣ��������
function Mission20061Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//Ӣ��������
function Mission20062Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//Ӣ��������
function Mission20063Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//Ӣ��������
function Mission20064Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 1); }//Ӣ������һ
function Mission20065Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 3); }//Ӣ��������
function Mission20066Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 5); }//Ӣ��������
function Mission20067Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 7); }//Ӣ��������
function Mission20068Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//Ӣ��������
function Mission20069Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//Ӣ��������
function Mission20070Dialog(%Npc, %Player, %Mid, %Tid){ MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid, 10); }//Ӣ��������
function MissionShengWangRenWuDialog(%Npc, %Player, %Mid, %Tid,%ExpXiShu)
{
	%GeShi = 31203;
	switch (%Tid)
	{
		case 10001:	return "<t>ն����ħ�������������������������ʿ���������</t><b/>";
		case 10002:	return "<t>��ħ��Ű��������ʿ�����˽�Ҫ�Գ�ħΪ���Σ�</t><b/>";
		case 10005:	return "<t>������������ˡ�</t><b/>";
		case 910:
			%Level = %Player.GetLevel();
			%OneExp = $Monster_Exp[%Level, 1];

			if (%Level < 40) %LevelXiShu = 1;
			else if (%Level < 50) %LevelXiShu = 1.2;
			else if (%Level < 60) %LevelXiShu = 1.6;
			else if (%Level < 70) %LevelXiShu = 2;
			else %LevelXiShu = 2.2;
			%Exp =  %OneExp * 500 * %LevelXiShu * %ExpXiShu;

			%Exp = $Get_Dialog_GeShi[%GeShi] @ "	���齱����</t>" @ %Exp @ "<b/>";
			return %Exp ;
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}

function Mission20146Dialog(%Npc, %Player, %Mid, %Tid)
{
	%GeShi = 31203;
	switch (%Tid)
	{
		case 10001:	return "<t>ǰ��ʦ���̵꣬Ϊ���糤�Ϲ�����</t><b/>";
		case 10002:
			return "<t>���糤�Ͼþ����أ���ҪЩ��ʦ�����ʣ����һص�������Ϊ���ϲɹ�һ����</t><b/>";
		case 10005:	return "<t>������ε�֪�������ģ���������ֻд��Ư��ƿ�����</t><b/>";
		case 910:
			%Level = %Player.GetLevel();
			%OneExp = $Monster_Exp[%Level, 1];
			if (%Level < 40) %LevelXiShu = 1;
			else if (%Level < 50) %LevelXiShu = 1.2;
			else if (%Level < 60) %LevelXiShu = 1.6;
			else if (%Level < 70) %LevelXiShu = 2;
			else %LevelXiShu = 2.2;
			%Exp =  mfloor(%OneExp * 80 * %LevelXiShu);

			%Exp = $Get_Dialog_GeShi[%GeShi] @ "	���齱����</t>" @ %Exp @ "<b/>";
			return %Exp;
	}

	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}