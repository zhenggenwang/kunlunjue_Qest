//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������

//�ͻ�������Ի�������������
//==================================================================================
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
//==================================================================================

//�����������������������������������ִ��������������������������������
//�������������������������������ɹ������������������������������������
//������������������������������ɽѩ�������������������������������������
//==================================================================================

//�����������������������������������ִ��������������������������������
function Mission10001Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		//if ( %Player.GetSex( ) == 1 )//��
		//{
		//	%Talk = "<t>��������</t>";
		//}
		//else %Talk = "<t>������</t>";
		case 10001:	return "<t>��ǰ������ʯ��̸���˽�ǰ����</t><b/>";
		case 10002:	return "<t>����˭��</t><b/><t>������ʲô��</t><b/><t>Ϊʲô�һ����⣿</t><b/>";
		case 10005:	return "<t>�˵�����������ɽ��ǧ��֮ң�������޵��У��������ˣ������ҵ�ǰ������Ҳ���ҵġ�������</t><b/>"@
			"<t>��������(������)�����㵽ɽ�ţ�����������磬��ͷ���Ǿ���</t><b/>";

		case 412: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "����ͷ�����ͣ�����һƬ�հס�������</t>";
		case 413: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "�⻰���Ӻ�˵��</t>";
		case 414: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "�����㿴����ô��Ҳ�������е��е���</t>";
		case 415: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "�ܸо����ﲻ�ԣ�</t>";
		case 416: return $Icon[ 4 ] @ $Get_Dialog_GeShi[ 31495 ] @ "�뿪С����</t>";

		case 511: return "<t>������Ȼ�����������࣬�����ѵ����ʱ�ˣ���֪���Ƿ񻹼ǵ�����ô��������ģ�</t><b/><b/><b/><b/>";
		case 512: return "<t>����Сʦ�������س�������ż������Īǰ��˵��λӢ�����꽫�������⣬�����޷����ʣ�ͷ����ɣ�ֱ����ʡ�����������Ӧ������֮�ˡ�</t><b/><b/>";
		case 513: return "<t>��˵�����콵̰�ǣ���ƽ���������㿴����ɽ�ӣ���ħ���У��ҵ��޵�֮���������ģ��������ˣ��������ϸ����޵���ʿ�������������ϳˣ������ɷ����Խ�Ȳ�������Īǰ��˵����������֮һ</t><b/>";
		case 514: return "<t>��������Ҫ���ģ����ʱֵ���٣��������ѣ�ֻ��ʱ�ղ���һ�����졭������</t><b/><b/><b/><b/>";
		case 515:
			closeHelpDirect1_4(10);
			return "<t>�˵�����������ɽ��ǧ��֮ң�������޵��У��������ˣ������ҵ�ǰ������Ҳ���ҵġ�������</t><b/>"@
				"<t>������������㵽ɽ�ţ�����������磬��ͷ���Ǿ���</t><b/>";
		case 516:
			closeHelpDirect1_4(10);
			return "<t>�˵�����������ɽ��ǧ��֮ң�������޵��У��������ˣ������ҵ�ǰ������Ҳ���ҵġ�������</t><b/>"@
				"<t>����������㵽ɽ�ţ�����������磬��ͷ���Ǿ���</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10002Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>Ѱ�����</t><b/>";
		case 10002:	return "<t>�ֹ��ｻ�����ҵ���꣡</t><b/>";
		case 10005:	return "<t>��������������Ϻ������ش塣������Ͼ���£�������̫�������ݣ����ĳ����ˣ���ɰ�æ����¡�</t><b/>";

		case 30001: return"<t>�����С�짿��е�����Ӣ�ţ���ô�����е㡭��</t><b/><t>����֮ǰ�ֹ���������</t><b/>";
		case 31001:
			return"<t>���ҵ����ֹ������ҹ���δ���н�������֪......��</t><b/>";
	}
}
function Mission10011Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>����������</t><b/>";
		case 10002:	return "<t>�غ�����������������ݣ���ȥ���һЩ��</t><b/>";
		case 10005:	return "<t>ȭ��������ѹ��ֹ�����������࿴�������ϵ���ɽǱ����������������Ϊ�ڲ�Զ��</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10021Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>�Ѽ�һЩ����</t><b/>";
		case 10002:	return "<t>�غ����ߵ�Ѱ��һЩ����������������ȥ��</t><b/>";
		case 10005:	return "<t>�������²������ף���ѡһ�����ֱ��аɣ�</t><b/>";

		case 20001: return"<t>��֪�ղ�ֻ��ȭ���ⲫ�����Ƿ����������޵�֮�ˣ�����һ���������������������޶ȵķ��������ʵ����</t><b/>";
		case 21001: return"<t>������ܻ����������أ�</t><b/>";

		case 20002: return"<t>���������������޵��У��������Ҳ�޷���Ԧ�����������ۣ�������ȥ�Ҵ�ͷ�������ˣ�����Ϊ��׼��һ�����ֵ�������</t><b/>";
		case 21002: return"<t>�ã������ȥ</t><b/>";

		case 20003: return"<t>Ī��ѽ����ͷ�Ǳ߽�ʯ���кܶຣ����ζ������֮���������˾ͺ���ڣ����ȥŪ�㣬�ܺù������ֿտա���</t><b/>";
		case 21003: return"<t>�˻�����</t><b/>";

		case 30001: return"<t>Ӵ�����������ۣ�����һ����ζ����������Ϻ���������ˮ��Ҫ�������ˣ�������Ҫ֪������ɽ�ϣ��뿪���Ѱ�����</t><b/>";
		case 31001: return"<t>ԭ������Ҳ���޵�֮��</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10031Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>ѡ������</t><b/>";
		case 10002:	return "<t>��ѡһ���Լ�ϲ����������</t><b/><t>����Ϊͨ����������һ��Ϊ��ְҵ����</t><b/>";
		case 10005:	return "<t>�����Ҿ��Ķ�����ɣ��䲻��ʲô�������Ҳ����֮������ѡһ���ɣ�ĪҪ������һƬ��ѪŶ��</t><b/>"@ 
			$Get_Dialog_GeShi[ 31404 ] @"<t>ע�⣺�̵깺���װ���ɳ��ʾ�Ϊ80%��ͨ�������ֻ�õ�װ������ʱ40%-100%�ɳ��ʾ��������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10032Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>װ��������</t><b/>";
		case 10002:	return "<t>�Ͽ����������˸���������ɣ�</t><b/><t>�ɰ�B�򿪱���������ƶ����������Ҽ��������װ������Ŷ��</t><b/>";
		case 10005:	return "<t>�����Ƿ񻹳��֣�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10041Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>Ѱ�ɷõ����þ�</t><b/>";
		case 10002:	return "<t>�ҵ����þ�ѯ���������ˣ�</t><b/>";
		case 10005:	return "<t>��Ҳ��־����һ��������ħ����ʿ����</t><b/>";

		case 20001: return"<t>�Ҹ��ڴ�ͷ������Ĳ�������֪����ȭ���ⲫ������˵��Լ����㲻�����з��ţ��������ɷ����ض���ҡ�������޹⡭��ң����Ͻ�ָħԨ�������ĺ���������˵Զ��</t><b/>";
		case 21001: return"<t>�������ѧ���������ɷ��أ�</t><b/>";

		case 20002: return"<t>������ֻ��ɽ��С�����ѣ������ķ��Ż�����������ɽ������������ͷ ���þ� ��������������ɣ�ʱ����������������˽��˽�</t><b/>";
		case 21002: return"<t>�õģ������ȥ</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10051Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>���þ����ڼ���</t><b/>";
		case 10002:	return "<t>�����þ�ѧϰ���ܣ�����������������</t><b/>";
		case 10005:	return "<t>��ֻ�ǻ�������ʽ��������Ҫ�����ϰ�����������磡</t><b/>";

		case 20001: return"<t>�٣���Ҳ�������Ű����Ҹ���˵������Ŷ���Ҵ��ͱ�ѡ�н���������������Ҳ��Ŭ������ȡ�ܽ������޵�����ʱ��ɨ�ķ�����</t><b/>";
		case 21001: return"<t>�ȿȣ����ֹ�Ȼ��־������֪���ֿ���������֮����</t><b/>";

		case 20002: return"<t>�Ҵ���˵ֻ�н��������Ӳ�ʣ���û��������ܸ���һ�������ɷ���</t><b/>";
		case 21002: return"<t>��һ������δ��������أ�</t><b/>";

		case 20003: return"<t>���������Ҵ��ֽ��ҵĻ�����ʽ����Ҳѧѧ�����಻ѹ��</t><b/>";
		case 21003: return"<t>��л���֣�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10061Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>ʵս�����з��</t><b/>";
		case 10002:	return "<t>ȥ���ɳ̲�ϻ����з�����������ְɣ�˳���ɰ��ջ����ĺ����͸��ִ�ɩŶ��</t><b/>";
		case 10005:	return "<t>����������ϵ�</t><b/>";

		case 20001: return"<t>��ô�����Ҵ��ִ��ڵ�ս�������ɣ���ֻ�ǻ�������ʽ��������Ҫ�����ϰ�����������磡</t><b/>";
		case 21001: return"<t>������ƽ���������ϰ�أ�</t><b/>";

		case 20002: return"<t>������ף�����ʱ�ɼ���ͷϺ��з�飿��ƽ�ն��������ֽţ������ջ�öຣ���أ����ڵ��ִ�ɩ��ϲ����������</t><b/>";
		case 21002: return"<t>��Ҳȥ���ԣ�</t><b/>";

		case 30001: return"<t>�ϣ���ô�����ʵ��з��</t><b/>";
		case 31001: return"<t>�ִ�ɩ�����ں���ץ�з��ʱ������������㿴����ʲô</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10071Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>�黹���</t><b/>";
		case 10002:	return "<t>�峤�Ҿ���ǰ��ķ��ӣ����ǰȥ��һ�ʣ�</t><b/>";
		case 10005:	return "<t>����Ƿ����������������˹黹��</t><b/>";

		case 20001: return"<t>�������Ǵ峤���ӷ�������Я��֮��</t><b/>";
		case 21001: return"<t>�Ƿ��ʴ���ںδ����ҽ����ﻹ����</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10081Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>ȥ�Ҿ�ϼ��취���</t><b/>";
		case 10002:	return "<t>���������������ˡ�����;�ϼ������ˣ�������ȥ�������ʰ�</t><b/>";
		case 10005:	return "<t>�峤�Ķ��ӳ�������δ�飬���ǳ������⣬�ɷ�ȥѰ��</t><b/>";

		case 20001: return"<t>���ǰ���ճ������㣬�Ѿ��кü���û�лؼ��ˣ�����������εõ��ģ�</t><b/>";
		case 21001: return"<t>�������ں���ʰȡ����</t><b/>";

		case 20002: return"<t>����γ�������δ�飬Ҳ����Ѷ��Ī�����ں��ϳ���ʲô����</t><b/>";
		case 21002: return"<t>�ϴ峤�ɾ���ôһ�����ӣ������Ҳ��ܲ���</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10091Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>�ɼ����Ѳ�ι�����޳�</t><b/>";
		case 10002:	return "<t>԰����������Ѳݣ���������ϲ���Եģ�����Բ�ժһЩȥ����</t><b/>";
		case 10005:	return "<t>��������Ѳݰ�</t><b/>";

		case 20001: return"<t>�⼸�պ��Ϸ���˴󣬿ɲ���óȻ����</t><b/>";
		case 21001: return"<t>�ǿ�����Ǻ�</t><b/>";
		case 20002: return"<t>ĪҪ�ż������糤�ϵĽ��������ҵ�԰����ˣ�����ȥ�ֺ����ޣ���������ȥ����Ѱ��</t><b/>";
		case 21002: return"<t>��Ӧ������ֺ�������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10101Dialog( %Npc, %Player, %Mid, %Tid )
{
	if ( %Tid == 20001 || %Tid == 30001 )
		Get_Mission_Dialog_ZhiYinWed( %Player, %Mid );
	switch ( %Tid )
	{
		case 10001:	return "<t>��������ȥѰ��</t><b/>";
		case 10002:	return "<t>�������������</t><b/>";
		case 10005:	return "<t>����Ƿ��ʴ����</t><b/>";

		case 20001: return"<t>лл�������ô��ζ��ʳ��</t><b/>";
		case 21001: return"<t>��ĺ�ͨ���԰������Դ���ȥ����Ѱһ���˻�����</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10111Dialog( %Npc, %Player, %Mid, %Tid )
{
	if ( %Tid == 20001 || %Tid == 30001 )
		Get_Mission_Dialog_ZhiYinWed( %Player, %Mid );
	switch ( %Tid )
	{
		case 10001:	return "<t>�����ʴ�������Ҵ峤</t><b/>";
		case 10002:	return "<t>��̫���ˣ�������ͻ�ȥ�ɡ�</t><b/>";
		case 10005:	return "<t>������̫���ˣ��Ϸ����Ǹм�������</t><b/>";

		case 20001: return"<t>���ǡ�ǰ���ղ��㣬����һֻѲ��ҹ�棬���ҵĴ����ˣ����������ˣ����ڻ���֪����Ǻá�</t><b/>";
		case 21001: return"<t>���õ��ģ��Ҿ����������</t><b/>";

		case 30001: return"<t>�����ɽ����һ�����</t><b/>";
		case 31001: return"<t>�ǵ�</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10121Dialog( %Npc, %Player, %Mid, %Tid )
{
	if ( %Tid == 20001 || %Tid == 30001 )
		Get_Mission_Dialog_ZhiYinWed( %Player, %Mid );
	switch ( %Tid )
	{
		case 10001:	return "<t>��¼���</t><b/>";
		case 10002:	return "<t>������¼�����Ƿ�����������</t><b/>";
		case 10005:	return "<t>�������Բ�����������ָ�տɴ���</t><b/>";

		case 20001: return"<t>�������ϴ��µ��ط�����ض�����Ҳ�����������������ɲ������</t><b/>";
		case 21001: return"<t>�м�������</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10131Dialog( %Npc, %Player, %Mid, %Tid )
{
	if ( %Tid == 20001 || %Tid == 30001 )
		Get_Mission_Dialog_ZhiYinWed( %Player, %Mid );
	switch ( %Tid )
	{
		case 10001:	return "<t>ǰ����л��ϼ</t><b/>";
		case 10002:	return "<t>����Ҳ����˾�ϼ���ɷ����Ϸ�ǰȥ��һ��л</t><b/>";
		case 10005:	return "<t>�峤�Ķ����Ѿ��һ����ˣ���л��ϼ���ָ��</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10141Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>�ɼ���Ӽ</t><b/>";
		case 10002:	return "<t>��л�ɲ��ǹ�����˵˵�ģ�����ȥ԰�вɼ�һЩ��Ӽ����</t><b/>";
		case 10005:	return "<t>�����ֽ����䣬�������Ҳ������!</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10151Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>�ü�����</t><b/>";
		case 10002:	return "<t>���������ڳ¾ɣ����Ҵ������Կ����ɿ����Ƿ����</t><b/>";
		case 10005:	return "<t>���������Ȼ���ĺ���</t><b/>";

		case 20001: return"<t>�̶�ʱ�䣬�ɵ����֮�࣬���Ե��£�Ϊ����Ƽ������</t><b/>";
		case 21001: return"<t>�õ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10161Dialog(%Npc,%Player,%Mid,%Tid)
{
	if (%Tid == 20001 || %Tid == 30001)
		Get_Mission_Dialog_ZhiYinWed(%Player,%Mid);
	switch (%Tid)
	{
		case 10001:	return "<t>���ܿ����</t><b/>";
		case 10002:	return "<t>�������Ǿ�ȥ������</t><b/>";
		case 10005:	return "<t>�����ҵ�һ��С���⣬������������</t><b/>";

		case 20001: return"<t>��Ȼ�𿿽�װ������Ҫ��װ������������ͷ���е��ɷ���ǵ������ˡ�</t><b/>";
		case 21001: return"<t>Ϊ��һ��Ҫ�������·���</t><b/>";

		case 20002: return"<t>��ܿ������������и���ϲҪ�͸��㣬�ɲ�����ô��ͷ����ȥ����ѽ</t><b/>";
		case 21002: return"<t>��л��ϼ�㣬��������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10162Dialog( %Npc, %Player, %Mid, %Tid )
{
	if ( %Tid == 20001 || %Tid == 30001 )
		Get_Mission_Dialog_ZhiYinWed( %Player, %Mid );
	switch ( %Tid )
	{
		case 10001:	return "<t>ǰ��Ѱ�����糤��</t><b/>";
		case 10002:	return "<t>�Ǿ�ȥ��ɽҩ԰�����糤�ϰ�</t><b/>";
		case 10005:	return "<t>��λ�ɹþ������糤�ϰɣ������鼱֮��ð�����������ޣ���������</t><b/>";

		case 20001: return"<t>��л�����������������Ҵ�绯��Ϊ��</t><b/>";
		case 21001: return"<t>��������ⶼ��Ӧ�õ�</t><b/>";

		case 20002: return"<t>��Ϊ��ָ��һ�ˣ��ں�ɽҩ԰�����ޣ���������������ް�</t><b/>";
		case 21002: return"<t>�õģ���֪����</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10163Dialog( %Npc, %Player, %Mid, %Tid )
{
	if ( %Tid == 20001 || %Tid == 30001 )
		Get_Mission_Dialog_ZhiYinWed( %Player, %Mid );
	switch ( %Tid )
	{
		case 10001:	return "<t>��������</t><b/>";
		case 10002:	return "<t>���ԣ�ֻ�轫��Щ�����ϳ�ҩ԰����</t><b/>";
		case 10005:	return "<t>�������ֲ���������������ͦ����ģ�������һƥ��ͨ��������͸�����</t><b/>";

		case 20001: return"<t>�⵹�޷����������޼�ͨ���ԣ��������Ļ����죬��Ҳ�����׽����</t><b/>";
		case 21001: return"<t>ԭ��������</t><b/>";

		case 20001: return"<t>�������ҵ�����֮�ˣ�����ľ�������֮�ġ��ҿ�����ʵ��Ե����֪�Ƿ���Ѱ�����������ķ�����</t><b/>";
		case 21001: return"<t>�������֮����</t><b/>";

		case 20002: return"<t>�⵹�Ǽ򵥣�������Ҫ��һ���㣬���ҩ԰����һЩ������ʳҩ�ݣ��㶮����</t><b/>";
		case 21002: return"<t>�����ˣ��������ȥ�����������ɾ�</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10171Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ǰ��ɽ��</t><b/>";
		case 10002:	return "<t>�����ҵ����ƣ�����ȥ�������ĵ��ӣ����Ի����ס�</t><b/>";
		case 10005:	return "<t>ԭ�������糤�������������ѵð���</t><b/>";

		case 30001: return"<t>վס������������ɽ������ֹ��</t><b/>";
		case 31001: return"<t>�����糤���������ģ�������������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10181Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�����Ź�</t><b/>";
		case 10002:	return "<t>�޹�ز��ɷ�Բ���˽��������ŵ��Ź�!</t><b/>";
		case 10005:	return "<t>���δ��ɽ�Ŵ󿪹�����ͽ֮ʱ�������г�������������������ɽ�Ĺ�ػ����ã�</t><b/>";

		case 20001: return"<t>��˵�����糤�������ģ�������һ���˵���£���Щ���в���Ϊ���ҵ��޵�֮�ˣ���Ӧ���������º��˵�����������������ƽ��Ҫ����������������ħ���ҵ��޵����֡�</t><b/>";
		case 21001: return"<t>������ˣ����¶�������</t><b/>";

		case 20002: return"<t>�������ʱ���������ʹ����������������һ������ƶ�ֵ����ɫ�����ܻ�������ʧ����Ȼ��ƽʱ������Ҳ��������ʧ������һ��Ҫ�ڼ�������</t><b/>";
		case 21002: return"<t>�ǵ�</t><b/>";

		case 20003: return $Get_Dialog_GeShi[31404] @"<t>װ����Դ��</t><b/>"@
			$Get_Dialog_GeShi[31401] @"<t>1�������س�</t>" @ $Get_Dialog_GeShi[31403] @"<t>�÷졢��ʦ</t>"@ $Get_Dialog_GeShi[31401] @"<t>���ɹ�����</t><b/>"@
			"<t>2��ͨ��</t>" @ $Get_Dialog_GeShi[31403] @"<t>��������</t>"@ $Get_Dialog_GeShi[31401] @"<t>���</t><b/>"@
			"<t>3��ͨ������</t>" @ $Get_Dialog_GeShi[31403] @"<t>���졢��Ӣ��ͷĿ</t>"@ $Get_Dialog_GeShi[31401] @"<t>���</t><b/>"@
			$Get_Dialog_GeShi[31404] @"<t>    ������Դ��</t><b/>"@ $Get_Dialog_GeShi[31401] @ "<t>����Ψһ���;��������ս����</t>" @ $Get_Dialog_GeShi[31403] @"<t>����</t>"@ $Get_Dialog_GeShi[31401] @"<t>���</t><b/>";
		case 21003: return"<t>����</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10191Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ͨ������ʹ���ˣ�</t><b/>";
		case 10002:	return "<t>�ڽ���ʹ����ɻ������ˡ�</t><b/>";
		case 10005:	return "<t>���ӿɽ�!</t><b/>";
		case 431: return $Icon[ 4 ] @ $Get_Dialog_GeShi[ 31491 ] @ "1���������</t>";
		case 432: return $Icon[ 4 ] @ $Get_Dialog_GeShi[ 31491 ] @ "2���������</t>";
		case 433: return $Icon[ 4 ] @ $Get_Dialog_GeShi[ 31497 ] @ "3����Ǯ��ʹ��������</t>";
		case 434: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "������</t>";
		case 435: return $Icon[4] @ $Get_Dialog_GeShi[31491] @ "1���������</t>";
		case 436: return $Icon[4] @ $Get_Dialog_GeShi[31497] @ "2���������</t>";
		case 437: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "������</t>";
		case 438: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "����</t>";
		case 531: return "<t>������������һЩ����������֪ʶ�� </t><b/><t>װ����ͨ��ʲô;����ã�</t><b/><t>��������˵��</t>"@ $Get_Dialog_GeShi[31406] @"<t>����</t><b/>";
		case 532: return $Get_Dialog_GeShi[31406] @"<t>�������</t>"@ $Get_Dialog_GeShi[31401] @"<t>���������������֮·�ϱر�һ�����գ���װ�����������Կ���������ã�</t><b/>";
		case 533: return $Get_Dialog_GeShi[31406] @"<t>�������</t>"@ $Get_Dialog_GeShi[31401] @"<t>��Ұ�����ɵ����Ʒ��װ��������Ψһ����������;����</t><b/>";
		case 534: return $Get_Dialog_GeShi[31403] @"<t>������ȷ</t>"@ $Get_Dialog_GeShi[31401] @"<t>��װ������ֻ��ͨ��������ܹ����ã���������ֻ��ͨ�����������ã�</t><b/>";
		case 535: return "<t>ս������</t><b/><t>�κ��˱����ܾ��и��ʻ����װ��</t><b/><t>�������������ɫ�����ܸ����׵�����Ʒ</t><b/>";
		case 536: return $Get_Dialog_GeShi[31406] @"<t>�������</t>"@ $Get_Dialog_GeShi[31401] @"<t>�������ĸ��ʼ��ͣ��ƶ�ֵ���������ӱ�������ʧ�ĳͷ���</t><b/>";
		case 537: return $Get_Dialog_GeShi[31403] @"<t>������ȷ</t>"@ $Get_Dialog_GeShi[31401] @"<t>�������������нϵ͵ĸ��ʻ������Ʒװ�����ƶ�ֵ���������ӱ����ܵ���װ����ʧ�ĸ��ʣ�</t><b/>";
		case 538: return $Get_Dialog_GeShi[31403] @"<t>      </t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10192Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ȥ������ʦ��</t><b/>";
		case 10002:	return "<t>����������ȥ����´�ʦ�ְɣ�������ʦ���кΰ��ţ���ʦ���Ǹ�����͵��ˡ�</t><b/>";
		case 10005:	return "<t>��ʦ�֣����³�����������������գ�</t><b/>";
	}
}


function Mission10201Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>������ʦ�ֽ̻塣</t><b/>";
		case 10002:	return "<t>����ʦ�ֽ�������֮����</t><b/>";
		case 10005:	return "<t>����֮·������ˮ���ۣ��������ˣ��м�³ç���£�</t><b/>";

		case 20001: return"<t>�����������ĪҪ������������û������Щ���׵ġ������糤��˵����㣬˵���Ǹ����ˣ�Ҫ֪�޵�֮�ˣ�һ�еñ��ֺ�ʵ�������ſɷɵĸ�Զ��</t><b/>";
		case 21001: return"<t>��лʦ��ָ�㣬�ؽ��ǡ�</t><b/>";

		case 20002: return"<t>��������ʱ���ڽ���̨��̳����������ʦ�㳣�����İ�ģ����в�����ȥ�����������ʦ�ţ�ʦ��������һ����ɷ���һʱ���������������ˣ�</t><b/>";
		case 21002: return"<t>��лʦ��</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10211Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>Ѱ����ʦ��</t><b/>";
		case 10002:	return "<t>��ʦ������о�̨���������ҹ�ȥ�����ɣ�</t><b/>";
		case 10005:	return "<t>��������������ʦ��������գ�</t><b/>";
	}
}
function Mission10221Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ѯ��ʦ��</t><b/>";
		case 10002:	return "<t>��Ҳ���Բ��������������������Ƿ������ջ�</t><b/>";
		case 10005:	return "<t>��Ҳ���Ը���һ��</t><b/>";

		case 20001: return"<t>Сʦ�ܣ�Ī��������������ͳ���ɣ���ش�ʦ��Ҳ�����㣬��ʵ�������Ǹ���������ѧϰ�������֮�����˸�����</t><b/>";
		case 21001: return"<t>��лʦ��ָ�㡣</t><b/>";

		case 20002: return"<t>�����ϳ����ٴ˽�������ƽ�յÿտ�������������������У�ǰЩ����Դ�ڴ��������ϼ�����죬���ճɾͲ���������</t><b/>";
		case 21002: return"<t>��ʦ�ֺ�������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}

function Mission10231Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>��ʦ��̽����������</t><b/>";
		case 10002:	return "<t>������ʦ�������ȥ������������֪�°ɣ�</t><b/>";
		case 10005:	return "<t>��������ʦ�������</t><b/>";

		case 20001: return"<t>��֪���г����޻����У��������֮���ֲ�̫ƽ���Ҵ���һ�����������ǰȥ��������������ʦ���ȥ�鿴һ����</t><b/>";
		case 21001: return"<t>��лʦ�㣡</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10232Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>���ʹ������</t><b/>";
		case 10002:	return "<t>������ʦ�㺰����̽��İ����ţ�����������ӣ���������������ǰ��һ·����ͷ��Ȼ��Ȼ�͵��ˣ��м�����³ç���������У�</t><b/>";
		case 10005:	return "<t>��л��ʦ�֣�</t><b/>";
	}
}
function Mission10241Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>��������֮��</t><b/>";
		case 10002:	return "<t>��ǰ��һ·����ͷ�͵������������ˣ�</t><b/>";
		case 10005:	return "<t>��������������֮���ˣ��˴������쳣����ѹֲ�ľ�ɾ�����ô�࣬�췺���ˣ��ó�ȥһ�㡣</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10251Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�����鹽С��</t><b/>";
		case 10002:	return "<t>�˴������쳣����ѹֲ�ľ�ɾ�����ô�࣬�췺���ˣ��ó�ȥһ�㡣</t><b/>";
		case 10005:	return "<t>ȥ��Ҷ����ɣ�ȥ����������</t><b/>";
		case 30001: return"<t>�ռ���ʩ�����������������裬����Ǹ����������ðɣ���������ԣ�ֻҪ��ѧ���ã���Ȼ�������������ˡ�</t><b/>";
		case 31001: return"<t>��л�佱��</t><b/>";

		case 30001: return"<t>���鹽�Ը�����ºͣ���ս�Բ��������е�����������㣬Ѱ��Ҷ���棬���ǵ�����Щ��ս��</t><b/>";
		case 31001: return"<t>�õģ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10261Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>Ѱ��Ҷ����</t><b/>";
		case 10002:	return "<t>Ѱ��Ҷ���棬��սһ�����������ħ��</t><b/>";
		case 10005:	return "<t>������ս���߼����</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10271Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>��ȡһ������</t><b/>";
		case 10002:	return "<t>�ɿ�����ǰ������ĪҪС�ƣ�����֦�ɼ��ͣ�Ѱ���������˲������ǣ�����������������������ƣ����п���֮�ã����ţ������ǰһ�ԡ�</t><b/>";
		case 10005:	return "<t>��������Ƿ񻹳��֣�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10281Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>��������</t><b/>";
		case 10002:	return "<t>��������Ƿ񻹳��֣��������У�ĪҪ���������ţ��м�ֻ��ʵս����Ѹ���������������</t><b/>";
		case 10005:	return "<t>ʵսЧ����Σ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10291Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>̽������Դͷ</t><b/>";
		case 10002:	return "<t>�����Щ����Խ��Խ�����ˣ��������ԭ��ģ�����ϸ̽��һ����</t><b/>";
		case 10005:	return "<t></t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10301Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>��������֮��</t><b/>";
		case 10002:	return "<t>����֮������ˣ�Ѹ�ٻ�������</t><b/>";
		case 10005:	return "<t>����������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10311Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>������ʦ��</t><b/>";
		case 10002:	return "<t>��ȥ������ʦ�֣�����������������</t><b/>";
		case 10005:	return "<t>����֮���쳣</t><b/>";
		case 20001: return"<t>����������</t><b/>";
		case 21001: return"<t>Ҷʦ�֣������������֮�飬ʦ�ܾ��ô��±������Σ�������������ʦ�ֶ��ᡣ</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10321Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>̽���ص�</t><b/>";
		case 10002:	return "<t>ȥ̽�����Ƿ���ʲô�쳣��</t><b/>";
		case 10005:	return "<t>��Σ������쳣��</t><b/>";
		case 20001: return"<t>�Ȿ������ˣ���������������һ��ͯ�������ڸ��յ�֮�У�Ϊ����������ɳ�������Ȼ�������죬��������̫ƽ����ϧ�����������������컯</t><b/>";
		case 21001: return"<t>���������������£��Ǻ����أ�</t><b/>";

		case 20002: return"<t>��ͯ�������������������ػ��ӣ���˵һ������ʧ��������������Ҳ��������ɢ�������֮�䣬�����������֮ʱ���临�𣬸����ط�����ͯ��һ˿�����ѹ��ĳ�����������ŵ�֪������̫������������һ����</t><b/>";
		case 21002: return"<t>��ͯ�ÿ���Ŷ��˭��ô�ɶ񰡣�</t><b/>";

		case 20003: return"<t>�������¶���ȥ�ˣ���Ե�ɣ�����ȥ����������ͯ����֮�أ��Ƿ���ʲ�쳣</t><b/>";
		case 21003: return"<t>�õ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10331Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>Ѱ����ũ����</t><b/>";
		case 10002:	return "<t>Ѱ���������ϣ���˵Ҫǰ���ص�һ̽��ȥ����������ˣ�</t><b/>";
		case 10005:	return "<t>�ߣ�һ����ص�һ̽�ɣ�</t><b/>";

		case 20001: return"<t>��Σ������쳣��</t><b/>";
		case 21001: return"<t>δ�����쳣����������Ϊ��񣬸о���Ҫ���ɾ�ʯ�ˣ�</t><b/>";

		case 30001: return"<t>���������ʵ������̫���ˣ�ȷ��Ҫ��ȥ��</t><b/>";
		case 31001: return"<t>����ȥ�ģ�</t><b/>";

		case 30002: return"<t>�ף�����û����˵���٣����������ͷ�ӣ��������ˣ��һ�����ȥ̽���°ɣ�</t><b/>";
		case 31002: return"<t>���ͳ�����</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10341Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�ص��յ�</t><b/>";
		case 10002:	return "<t>�ص�̽�յף�</t><b/>";
		case 10005:	return "<t>���������񰡣��ǣ��������������������꣡</t><b/>";
		case 418: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "�����ܵ�</t>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10351Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>������ʲô����</t><b/>";
		case 10002:	return "<t>��ʵ�����˺öࣿ��</t><b/>";
		case 10005:	return "<t>��������������ߴ����֮һ����������ɽ��ħ����ʱ��Ȼ����Ļ�Ե��˵�����ܵõ�һ�������һ�о��ڻ�Ե</t><b/>";

		case 30001: return"<t>���ʲ����պ󶨳ɴ����������Ϸ������������ص�����һ����������������������迼�顭��</t><b/>";
		case 31001: return"<t>����ʵ�����ղ����������֣���֪��ʱ����һ��</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10361Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�������</t><b/>";
		case 10002:	return "<t>�������Ŵ����ټ��㣬��ȥ�ɣ�</t><b/>";
		case 10005:	return "<t>����������</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10371Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>��������</t><b/>";
		case 10002:	return "<t>�ҵ��޵�֮�ˣ�Ӧ���ٶ������޵�ʱ����̣�����Ϊ�пɣ�����ɽ����һ����</t><b/>";
		case 10005:	return "<t>�������Ϊ�пɣ���Ӧ����������һЩʱ�գ�Ȼɽ����ħ������ӣ�ʱ�����ң�ֻ����ǰ������ɽ��������������Ҳ���кô�����ɽǰȥ���ʦ�ִ������������ĵø�֪�㣡</t><b/>";
		case 30001: return"<t>��ɽ��Щʱ���ˣ������ϳˣ����о������Ѿ��е��ɷ���ǵ���ͷ�ˣ���������ɽ����������Ҳ�����ˡ�</t><b/>";
		case 31001: return"<t>��ô���Ҫ��ɽ����</t><b/>";

		case 30002: return"<t>�ն����ѵ��㻹Ҫ�������һ���ӣ�����������γ۳��ݺᣬ������ħΪ��������Ų�����ѧ��</t><b/>";
		case 31002: return"<t>ȷʵҲ�ǡ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10381Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>��ʦ������</t><b/>";
		case 10002:	return "<t>ȥѰ���ʦ��׼����ɽ���˰ɣ�</t><b/>";
		case 10005:	return "<t>���ˣ����Ѻܾ�δ��ɽ�߶�������ʦ�ܸմ�ɽ�»������������ֽ��£�</t><b/>";

		case 30001: return"<t>��ô���Ҫ��ɽ�ˣ�ԭ�������������ţ�Ҳ�ã���ɽ�����ù���ɽ�ϱ���������ɽ���ն�ʦ����ҪС�ģ�����³ç���£�������������ɽ����ʱ�������磬�������ã�Сʦ�ܴ��ţ�����������������</t><b/>";
		case 31001: return"<t>��л��ʦ�ֹ��գ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10391Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>Ѱ������ͤ</t><b/>";
		case 10002:	return "<t>Ѱ����ʦ�֣��ֽ���ɽ׼������</t><b/>";
		case 10005:	return "<t>��ҩ��ʱ��׼���ţ��������˱����ز�����Ŷ��</t><b/>";

		case 30001: return"<t>Сʦ��ҲҪ��ɽ�����ˣ����Ҹ���˵��ɽ�¿ɺ����ˣ��ر����������ƣ���ζ������ֱû��˵��</t><b/>";
		case 31001: return"<t>ʦ�֣�������ɽ������ô��������</t><b/>";

		case 30002: return"<t>���Բ��ӣ��꣬ĪҪ���⽲����ֻ�Ǹ���������Щ����ģ����ˣ��������������޵�֮�˱��ݣ���Ī�����캦��֮�£����⻹��Щ��ҩ������·��˵�����õ��š�</t><b/>";
		case 31002: return"<t>��лʦ��</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10401Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>Ѱ�ҷ�������</t><b/>";
		case 10002:	return "<t>��ɽ�����ٲ��ø��ر�������ȥ��Ҷ����ӣ������������ɽ���ˣ�</t><b/>";
		case 10005:	return "<t>��Ҫ��ɽ������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10411Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>����ݵ�֮��</t><b/>";
		case 10002:	return "<t>�ҵ�����֮�ˣ�����ݵ�֮������ɽ����֮������������</t><b/>";
		case 10005:	return "<t>��������������ɽ�����������ɹȿ�ʼ����Ҳ���⿪ʼ�ɣ�</t><b/>";

		case 30001: return"<t>�Ǻã��κεط�ֻҪ���ҵ��ң��Ҷ��ܴ���ȥ�κεط���ǰ�����Ҿ���������ʵ��Ӵ����Ȼ�ҿɲ��뿴��װ�������</t><b/>";
		case 31001: return"<t>����ݵ�֮���𣡿�������������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10421Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>��ɽ������ǧ��֮��ʼ�����£��ʹ����ɹȿ�ʼ�ɣ�</t><b/>";
		case 10002:	return "<t>���Ž���ɽ���������ӣ���ǰ��ɽ����������ħ����һ��ƽ��Ҳ��һ�����£�</t><b/>";
		case 10005:	return "<t>���￴����¶��ɫ���Ƿ���ʲô�Ѵ���</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
//�����������������������������������ִ��������������������������������

//�������������������������������ɹ������������������������������������
function Mission10431Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ɽ����Ѱ��3������ݡ�</t><b/>";
		case 10002:	return "<t>�����ϲ�����������������Ŀ�ľ����ȥɽ�������ң������ɷɲɼ�3������ݰɣ�</t><b/>";
		case 10005:	return "<t>��л��������������</t><b/>";

		case 20001: return"<t>���Ǵ�������ɽ���������ˣ�</t><b/>";
		case 21001: return"<t>����Ī�ţ�������ɽ����֮�ˣ������ｹ��̬֮���Ƿ����Ѵ���</t><b/>";
		case 20002: return"<t>�峤�������ճ������ܾɼ������ˣ���Ҫ����ҩ�ݣ�����������ħ���ӣ��������ˡ�</t><b/>";
		case 21002: return"<t>����������ӣ�����Ϳ̿���ҵ���ʿ���������У���֪���������ҩ�ģ��ҿ����Ű���ȡ����</t><b/>";

		case 30001: return"<t>�������֮�죡��Ȼ��������֮���з��ӣ�����Ҳ��֪����ô�ˣ����ɽ�����������ֱ��죬�����ſɵ�С���ˣ�</t><b/>";
		case 31001: return"<t>��ų�ɽ�ţ�������������ħ�������˴��������Σ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10441Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ף֦ɽ�������ϳ�������ܰ���������������������</t><b/>";
		case 10002:	return "<t>�˵�ͻ����䣬�����Է����ڸ�������ϸ���ҡ�</t><b/>";
		case 10005:	return "<t>��ѽ������ɽ�ȴ�䣬�����ɾ��������Ϸ��ˣ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10451Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�����������ã��˵������ɾ����������Է򶼲�������в���ܰ�æһ������¸м�������</t><b/>";
		case 10002:	return "<t>Ͽ���ڿ����ɾ����������������Ī�����в�������Է����һЩ�ɡ�</t><b/>";
		case 10005:	return "<t>���������֣�������������������ȫ���ˣ�����ͻ����䣬�����д���Ҫ�����ˣ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10461Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>��ף֦ɽȡ������������Ŵ���</t><b/>";
		case 10002:	return "<t>�������������ɾ������գ���ף֦ɽȡ��һЩ�͸����߲���������Űɣ�</t><b/>";
		case 10005:	return "<t>��ѽ����л����������������м�������</t><b/>";
		case 20001:	return "<t>�Ҵ˴γ���ԭ��������������ȥ�����������ɾ���׼���ڴ˺������������̷�����������������ɾ������գ���֪�����Ƿ�ɰ�ȡЩ����͸�������ȥ��</t><b/>";
		case 21001:	return "<t>��˵��˵�������ȥ��ȡЩ�����ȥ��</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10471Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>��һ��������ˮ����������ȥ��</t><b/>";
		case 10002:	return "<t>�Ա�һ�������һ����ˮ��˳·�͸���Ϫ�ߴ�����������</t><b/>";
		case 10005:	return "<t>��л����������ˮ��ʣ�������֪����֮ѧ�ʣ�</t><b/>";

		case 20001:	return "<t>���ɽ�ﲻ��ȫ��������Ҫ����������ǰ�����ϴ�̽��̽����˵����������˺ö�������ʿ�������뷨����ħ�أ�</t><b/>";
		case 21001:	return "<t>�����£��ҵ�ȥ������˵���ÿɾ�Щ΢��֮������֪�˴������ϻ��ж�Զ��</t><b/>";
		case 20002:	return "<t>����ͥԺ���Ų�·һֱǰ�о��ܿ����ˡ�����Ҫǰ����˳���������һ����ˮ˳·�Ը�����������Ϫ�ߴ�����</t><b/>";
		case 21002:	return "<t>�����ܼ��������⣡</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10481Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ѧ���̳��Դ�����������һ�ε����ܵ���ʲô��</t><b/>";
		case 10002:	return "<t>װ�������̵���ͣ�����һ�ᣬ��������֮�֡�</t><b/>";
		case 10005:	return "<t>�������Բ���Ҫ֪��ö�ʦ��ʦ�㵱����ǰ���û����һ�����أ�</t><b/>";
		case 20001:	return "<t>�ⴹ�������Ǹ��������Եĺ÷��ӣ��㿴�����ϲ�������ľ�괺����һ���ֻأ���ʿ������ϣ�ϰ����ɽ����֮�������ûػ��컯֮����������ʣ����Ժ쳾����������Ҳ�Ǻ���Ҫ�ģ���ع�������������ɽ����Ҳ�д��⡣</t><b/>";
		case 21001:	return "<t>����˵��������֪�����ܷ��ڴ���֮�أ�</t><b/>";
		case 20002:	return "<t>�����Ҽǣ�̰����ã����ǧ���磬������֮�����кܶ࣬���ָ���ɽ����֮��δ���ʺ��㣬�Ϸ���մ���һС����������������ʱ�Դ�С��������Ȥ�������Ϸ��������ڡ�</t><b/>";
		case 21002:	return "<t>��л���ɣ�</t><b/>";
		case 20003:	return "<t>���Ҵ����Ϸ����ͣ������¶�׼��Ⱥ����������</t><b/>";
		case 21003:	return "<t>������ԣ�</t><b/>";

		case 30001:	return "<t>�ţ�ȷʵ�ǿ���֮�ţ��Ϸ�Ҳ�������㣬�Ϸ����������㣬�����������ﵽ35����������Ȥһֱѧϰ����֮�������˴����Ұɣ�</t><b/>";
		case 31001:	return "<t>��л���ɣ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10491Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ǰ������������С��һ����</t><b/>";
		case 10002:	return "<t>��������������ȥ��յ���Ĵ����㡣������С��ķ��顣</t><b/>";
		case 10005:	return "<t>��������䣬���˲���������ʿ�������ܳ����������Ϸ��������ǧ�˸м�������</t><b/>";

		case 20001:	return "<t>������׼��ȥ���Ϲ�䣿Ҳ�ã���������ǵ��У����˳�����ϴ����������͸����ϵ������������ˣ����ͺ�����۵����㡣</t><b/>";
		case 21001:	return "<t>��л���ɣ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10501Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�������������͵���Ů���������</t><b/>";
		case 10002:	return "<t>������ζ������������̫�鷳���������пգ��ɰ�æ�͵�СŮ�������</t><b/>";
		case 10005:	return "<t>�Ҹ�������Ц�ˣ����ͺ���һ�ڷ��۵����㣬���������˶�֪��������Ҳ��ǰ���������ʿ��</t><b/>";

		case 20001:	return "<t>��ѽ��������˿���������������ζ������һ���������̸�����İɣ��Ҹ����㰡�������̿ɲ��򵥣������������һƬˮ���δ�����޹��ˡ�</t><b/>";
		case 21001:	return "<t>ԭ����ˣ��ѹ������������֮������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10511Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>������벻�����ϵĵ��ơ������ȥ��һ�����Ƶ���</t><b/>";
		case 10002:	return "<t>ȥ�����ӻ��̵����ﴦ��һ�ݵ��ϸ������ȥ��</t><b/>";
		case 10005:	return "<t>���������������Ǹմ���ض����ģ� �����Ҫ�ĵ��ϰ����ɲ���һ���ɫ��Ҳֻ�д�������Ū��</t><b/>";

		case 20001:	return "<t>������֪�����������⿲���ζ�������ɹ�ˮ�峺���ף�������ʻ��ۣ�������ζ���ϣ��Ǽ�ֱ�������ղ��ܣ�</t><b/>";
		case 21001:	return "<t>��������ô���ţ�</t><b/>";
		case 20002:	return "<t>�����ɷ��ܰ�СŮ��ȥ�ӻ��̴���һ�ݵ��ϣ��Ժ�СŮ�����������ζ��</t><b/>";
		case 21002:	return "<t>���ȥ����</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10521Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>��������Ѱ���Ƶ��ϵĲ��ϡ�</t><b/>";
		case 10002:	return "<t>���ӵ��ſ���һ������������������Ҷ�ӣ����ɲ�����Ҳ�У�����ϸ���ң�</t><b/>";
		case 10005:	return "<t>�����ÿ죬���²������ˣ��Ҹ������һ�����ϡ�</t><b/>";

		case 20001:	return "<t>�����Ƶ�������������ɲݣ�������Ҷ�����Ҷ����ط����ƶ��ɣ�������Ҳû��Щ������������������ϣ��ɰ��Ҳɼ���Щ�����Ұ�����ƣ�</t><b/>";
		case 21001:	return "<t>��˵����������⣬���ɲݡ�������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10531Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�����յ��Ƴ�һ�����Ƶ��ϣ��ͻظ�����ɡ�</t><b/>";
		case 10002:	return "<t>������������������Ƶ��ϣ�ȥ������ȥ�ɡ�</t><b/>";
		case 10005:	return "<t>��л����ΪСŮ��ȡ�������Ƶ��ϡ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10541Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�ȴ����������ζ���������֮����</t><b/>";
		case 10002:	return "<t>������֪����⿣�Ҳ��һ���ǳ�ʵ�õ�����ܣ�</t><b/>";
		case 10005:	return "<t>��˵���سǵĳ������ȶ��������һ̳���벻���ԣ���ö���ʿ������������أ�</t><b/>";

		case 30001:	return "<t>��˵����֮�˲ͷ���¶�������������֮ʳ����������֪���֮��Ҳ�ǵ�Ŷ��Ҫ֪����ʳ�����ƶ��ɵ���ζ���ҵȷ�������ʳ�ú���˲������ɾ�������</t><b/>";
		case 31001:	return "<t>�������֮�أ������������Ը���ɽ���������������Ǳ���ġ�</t><b/>";
		case 30002:	return "<t>��������Ͼʱ��ȥ���سǵ�ʳ���ֽ�һ�����ݴ�������ʳ�������Ψһ����Ŷ��</t><b/>";
		case 31002:	return "<t>���ձ�Ҫȥ�ֽ�һ��</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10551Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>������������õ���Ծ�����͸������ϴ���</t><b/>";
		case 10002:	return "<t>�˵���Ծ����ɫ��ζ��ȫ���治��С����С��������հ����������Ƕ���һ��ȥ�ɡ�</t><b/>";
		case 10005:	return "<t>����ֽ���������ζ�˰�����л������</t><b/>";

		case 20001:	return "<t>�����뿴�������Ծ���ţ������ˣ��������пտ������͸����ϴ���һ��</t><b/>";
		case 21001:	return "<t>���ɫ��ζ��ȫ��������ʳָ�󿪰���</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10561Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>³��ʦ�������������һ�Ѻ��֣���������������֮����</t><b/>";
		case 10002:	return "<t>���������֪������֮����С�������ճ����ã��󵽶�����֮�˶�������֮���أ�</t><b/>";
		case 10005:	return "<t>������飬�����Ҫ�Լ���������ʲ����ˣ�������������ˣ�����ʹ�á�</t><b/><t>�����ȥ��������ȥ�������ʳ�ɣ�</t><b/>";

		case 30001:	return "<t>��������֮���Ǵ����سǽ�ʦ����һ������ѧ��һЩƤë���㿴�ⲡ���У��䲻��ʲô���������Ҳ�ù�һ��֮�����������Ҫ�����Լ���������������ʦ�ֽ�һ�����������ã�</t><b/>";
		case 31001:	return "<t>ԭ�����е�������������Լ�����İ���</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10571Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�������������Ծ����������͸����ϴ���</t><b/>";
		case 10002:	return "<t>���͸�ҩʦ�ɣ��պ�˳·��ҩʦ��ǧ������������������֣�˳����������������֮����</t><b/>";
		case 10005:	return "<t>����ֽ���������ζ�˰�����л������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10581Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>̽������֮��</t><b/>";
		case 10002:	return "<t>������������֮������С����������֮�����١���ս���ﶼ�����˻���������֮ʱ����ʱ��ҩ�ɾ����ϴ��ô��ˡ����Ҹ߼��ĵ�ҩ�������Լ���Ǳ�ܡ�</t><b/>";
		case 10005:	return "<t>����֮���������������35����������سǻ��������˴�ѧϰ����֮�����˺�����ҩ�����������ƶ��ɣ��������֮�ð�</t><b/><t>�ҾͲ������������������ȥ��ʳ�ˣ�</t><b/>";

		case 30001:	return "<t>�Ϸ���ǰʱ����������ѧϰ��һ��ʱ�������֮�����ⵤҩ�ǾӼ����б����ر�֮���ʱ�ܴ����������������Ŷ��</t><b/>";
		case 31001:	return "<t>ԭ���������˿�������Ѫ����֮ҩ�⣬������ǿ���������İ���</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10591Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�������������Ծ����������͸����ϴ���</t><b/>";
		case 10002:	return "<t>�͸���ׯ���¹���ɣ����¹�������������еĲ÷���֣���˵���ƶ��ɵ��·������ܷ�������ħ��ֵĹ���</t><b/>";
		case 10005:	return "<t>����ֽ���������ζ�˰�����л������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10601Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>̽�ֲ÷�֮��</t><b/>";
		case 10002:	return "<t>������֪��÷�֮�����������в���֮©�����������ƶ��ɵķ����ܷ���ס������ħ��ֵĹ���Ŷ��</t><b/>";
		case 10005:	return "<t>�÷�֮����������㵽35���������سǻ������ɵ�ѧϰŶ���⼸����������ƽ����Ͼʱ���Ƶģ����㻤��֮�ã�</t><b/><t>�ҾͲ��������������������ζ����</t><b/>";

		case 30001:	return "<t>������������·��С�򣬴����Ҵ���֮�ܣ���÷찡������ϸ���ɣ����Ϻò��Ͽɷ��Ƴ��߼��붥���ķ��ߣ������Ͳ�����ħ����ˣ����Ͽ���ƽʱ������ħ���ʱ�ռ����أ�</t><b/>";
		case 31001:	return "<t>ԭ����ɽ������ħ�ɻ�ø߼�װ���Ĳ���ѽ</t><b/>";
		case 30002:	return "<t>�÷�֮�������������Ƴ������޷�ķ��ߣ��ɱ�������õ���ɽ������Ŷ��</t><b/>";
		case 31002:	return "<t>���տ�ѧϰ��������ܣ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10611Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�������������Ծ����������͸����ϴ���</t><b/>";
		case 10002:	return "<t>�͸����ε�������ɣ��������Ƕ���Ʒ�м��ߵ�����ˮ׼���������ֽ�һ������֮��Ŷ</t><b/>";
		case 10005:	return "<t>����ֽ���������ζ�˰�����л������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10621Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>̽������֮��</t><b/>";
		case 10002:	return "<t>������֪������������������Ʒ���������������Ȥ��С����Ŷ����С����Щ��������С���⣬���д���Ŷ��</t><b/>";
		case 10005:	return "<t>����֮����ͨ�Ž񣬵��㵽35���������سǻ������ɵ�ѧϰŶ���⼸����Ʒ���������ո��Ƴ�����~��������ɣ�</t><b/><t>�ҾͲ��������������������ζ����</t><b/>";

		case 30001:	return "<t>��˵���ս���³��������һ������ص������������Σ��ǵ��������س�����ϼ�Ʋ�ɢ��̫�����ˣ�</t><b/>";
		case 31001:	return "<t>�������������������������Ʒ�������ֻ�ܿ����񽳰���</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10631Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>���������Ծ����������͸������������ɣ�</t><b/>";
		case 10002:	return "<t>���������Ϊ�����ܱ߳�����ħͷ���أ�������û�취��æ��</t><b/>";
		case 10005:	return "<t>�����������ˣ�����ζ������������ֳ����ˣ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10641Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>̽������̶���������˵�������</t><b/>";
		case 10002:	return "<t>ǰ������̶̽��һ������������˵������������������˰�ȫ��</t><b/>";
		case 10005:	return "<t>�������������������ʱ�Ǹ�ͷ���������������������</t><b/>";

		case 20001:	return "<t>������������˵���ɽ����̶�����㷢��һ���ĳ�����·�˹���������Ҫ���˶���ʱ����Ҫ�����ˡ������ɷ���Ϸ�һ̽? ���ܳ�ȥ���˵�������ã�</t><b/>";
		case 21001:	return "<t>�峤Ī�ţ�����ǰ������̶������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10651Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>���������ҽ������֮����</t><b/>";
		case 10002:	return "<t>��˵���س������ͽ������жԴ��а취��ȥ���ʰɣ�</t><b/>";
		case 10005:	return "<t>��˵���Ҷ�֪����������ɹ�ȷʵ��̫̫ƽ����������������ʿ����ά��һ��ƽ����</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10661Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�����봦�������ˣ�ȥ̽���²�������ڤ�������ʵ���ɣ�</t><b/>";
		case 10002:	return "<t>�����봦�����˻��ȣ��Ի�������·�ˣ�ǰ��̽��һ�����������Ƿ��к�����</t><b/>";
		case 10005:	return "<t>���⻨�꣬�����⻨�������Щʱ���ˣ�ֻ��һֱ�������ˣ���֪�ιʽ��ն��ѳ����ˡ������ĺܺã����������ȥ����ɡ�</t><b/>";

		case 20001:	return "<t>���������ӣ������������ҽ�����֮�ˣ�������������������ı�Ҫ������ͨ�����򲻿���ˣ���һ�˵���������Ǻá�</t><b/>";
		case 21001:	return "<t>���˵���£��⽵����ħ֮�»�����������</t><b/>";
		case 20002:	return "<t>��֪����������Σ���˵�����봦���ֻ����Ȼ�������·�ˣ���ػ���Ӧ�ñȽ��ºͣ�����̫���ˣ���ȥ̽���°ɣ�Ҳ�����ҿ������ʵ����</t><b/>";
		case 21002:	return "<t>�����룿�����ȥ̽���£���������Ϊ���</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10671Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 300: return"<t>   </t><b/>";
		case 10001:	return "<t>Ѱ�ҽ�Ӧ֮��</t><b/>";
		case 10002:	return "<t>�����ҵ����ƣ�·�ϻ����˽�Ӧ��ģ��������˵�����</t><b/>";
		case 10005:	return "<t>�˴�ͨ������֮·Ҳ����������÷ǳ�����</t><b/>";

		case 20001:	return "<t>�˵����Ƶ�����������Σ����ҽ�����֮�ˣ�Ϊ�������Ϊ���Σ����ڴ���ס��ǰ�����س��Ҵ�ͳ��˵���˵����ˣ������кΰ��ţ�</t><b/>";
		case 21001:	return "<t>�õ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10681Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ǰ�����س��������ɹ����Ƶ�������顣</t><b/>";
		case 10002:	return "<t>��Ҫȡ����ĺ��ڵ��ø���ͳ�쿴�������Ͼ�֪����</t><b/>";
		case 10005:	return "<t>���д��£��������������Բ��飬�����Ŷ������������ˡ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10691Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>���ͳ��ѯ�������������ƽ�֮����</t><b/>";
		case 10002:	return "<t>�������سǣ��ⷱ�����ɳǣ���Ȼ������ʿ���࣬���������ӵĻ�ȥѯ���°ɣ�˳���˽���Ϊʲô��ָ����ʦ�����Լ���</t><b/>";
		case 10005:	return "<t>ͯ���޼ɣ�СС����Ӻζ������������£�Ϊ�ζ�ȥ��</t><b/>";

		case 20001:	return "<t>��������سǣ����ڴ˴��úù�䣬��ȥ����������������£��������������ӣ��ɴ�Ϊ�������к���ߣ�˵���ù����ջ�����Ҫ����ǰ�����ɹ�����һ��</t><b/>";
		case 21001:	return "<t>�����ӡ����ⲻ��Сʦ�����짵�ʱ����ʱ˵���ģ�����</t><b/>";

		case 30001:	return "<t>����֮·������֮·����֪������֪����ǰ֪��ǧ��������꣡</t><b/>";
		case 31001:	return "<t>������������</t><b/>";

		case 30002:	return "<t>����֮·������֮·����֪������֪����ǰ֪��ǧ��������꣡</t><b/>";
		case 31002:	return "<t>����������ƭ�Ӱ�</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10701Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�������ƺ������˼ɹ��������ʣ�</t><b/>";
		case 10002:	return "<t>����������Īǰ�������˼ɣ�������ʣ��ʲ���������Ȼ�������ȹ��ɣ�</t><b/>";
		case 10005:	return "<t>Ī�ߣ����˿ɾͻز����ˣ�СС�������֮�ţ��˷��˿�ϧѽ��</t><b/>";

		case 20001:	return "<t>����֮·������֮·����֪������֪����ǰ֪��ǧ��������꣡</t><b/>";
		case 21001:	return "<t>��ʦ��֪����˭��</t><b/>";
		case 20002:	return "<t>����֮·������֮·����֪������֪����ǰ֪��ǧ��������꣡</t><b/>";
		case 21002:	return "<t>����������ʦ��֪�ҽ�Ҫȥ�δ���</t><b/>";
		case 20003:	return "<t>�ף���˵�������ǰɣ���Ҳ��������������������˭����֪������֪����ǰ��֪�������ɲ��Ǵ��ģ�</t><b/>";
		case 21003:	return "<t>��Īǰ����֪Ϊ���һ����������ǰ��</t><b/>";
		case 20004:	return "<t>�������������ǵ������������������ʲô�����ǣ�����ô��֪�����ء�</t><b/>";
		case 21004:	return "<t>!!!!!</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10711Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>������ǰ������һ���������õĹ����������ż�ë�������</t><b/>";
		case 10002:	return "<t>���ŷ���ȥ�ҷ����飬���䴫��һ�б���֮���������Ƿ������Ч���ɣ�</t><b/>";
		case 10005:	return "<t>������������ǰ���ıʼ���Ƿ��һ�����飬������Ի����ˣ������úã�������ؼ���</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10721Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�Ʒ�֮�����������������������а���</t><b/>";
		case 10002:	return "<t>�Ʒ�֮��������������������з����Ͽ����ǳ����¿ɺ�����������������Ϊ�Լ���������</t><b/>";
		case 10005:	return "<t>��������Ͼʱ����</t><b/>";
		case 20001:	return "<t>��ǧ�����ֻȡ��һ���Ʒ���Ҫ֪һ�ŷ���ų�����ع��Ŵ󿪣��Ž�Ӣ�����Һ���������ܣ�Ҳ��һ�������</t><b/>";
		case 21001:	return "<t>��ô����������������֮������������</t><b/>";
		case 20002:	return "<t>����Īǰ������ķ���������Ҫѧϰ�Ʒ������������Ұɡ�</t><b/>";
		case 21002:	return "<t>��лǰ����</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10731Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>���س����й�</t><b/>";
		case 10002:	return "<t>�������أ�����й�ᣬ�Ժ���ȥ�Ҵ�ͳ�죬��������������!</t><b/>";
		case 10005:	return "<t>�������ڳ��У�������ã�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10741Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ǰ������ͳ�촦��������ν��������������뿼��</t><b/>";
		case 10002:	return "<t>����ͳ�������سǻ��˹㳡�Ϸ����ɹ�ȥѰ����������ָ�������ȥ��ս������</t><b/>";
		case 10005:	return "<t>ԭ���Ǵ�ͳ���Ƽ��ģ����ֶ�Ȼ������</t><b/>";

		case 20001:	return "<t>�����������飬���ɹ���������С�ӣ���һʱ���ֲ�����������������̡���ʱ��������֮�أ�������ս���������ߣ�����������ǰ�����ɹ�Э��������</t><b/>";
		case 21001:	return "<t>С����ǰ��һ�ԣ�Ϊ�������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10751Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>������������֮�������Ǿ������������������ɣ�</t><b/>";
		case 10002:	return "<t>�ҵ�ǿ��ʦ���α�����������װ��ǿ��һ�£�</t><b/>";
		case 10005:	return "<t>��Ϊȥ����������׼���İ����ţ�����ˣ�</t><b/>";

		case 20001:	return "<t>Ҫ֪�����������ɶ�Ϸ������һ�������������Ƿ����Щ�����ǳ���������������������׼���ģ�������һ���ֽ�������������£��ź�ȥ������</t><b/>";
		case 21001:	return "<t>��ˣ���л��</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10761Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ǿ��һ��װ��</t><b/>";
		case 10002:	return "<t>�����ܵĶ�ǿ����װ���ɣ�����������˵��Ϊ���գ�����С��Ϊ�ϣ�</t><b/>";
		case 10005:	return "<t>��װ��ǿ������ǿ����</t><b/>";

		case 20001:	return "<t>��ǿ��֮�����Ǽ�Ϊ�����������װ��һ��ǿ����ǿ���ȼ�Խ�ߣ�Ч��Խ��</t><b/>";
		case 21001:	return "<t>�����Ȼ���㵱��ɵ��~</t><b/>";

		case 20002:	return "<t>����װ��ǿ����ʧ����װ����Ȼ��ʧ�������¶��и����⣬������ǿ��ʱ�����ϱ���������ʧ�ܲ�����ʧ��ͬ����ǿ��+6����ʱ����ʧ�ܣ�ϵͳ�������㱣��װ������ʧ��</t><b/>";
		case 21002:	return "<t> +6���»ᱣ��ʧ��װ������ʧ����</t><b/>";

		case 20003:	return "<t>������ȼ��������������ֱ�ӽ���ǰ�ȼ���װ��ǿ�����Եȵ�ȫ��ת�����߼�װ���ϣ�ֻ�踶��һ��΢������Ĵ��ۼ��ɣ�</t><b/>";
		case 21003:	return "<t>ԭ����ˣ��������԰�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10771Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>����ǿ����װ����Ǳ�ܻ�δ��ȫ���ӣ�������Ҫ�ټ�����</t><b/>";
		case 10002:	return "<t>�ҵ�����ʦ�����¡����ｫװ�������°ɣ�30����ɫ��װ���Ϳɲ�������ˣ�</t><b/>";
		case 10005:	return "<t>ԭ����Ҫ���������������ʿ����װ�������ɴ������������Ŷ��ֻ��һЩ΢������Ľ�Ҽ��ɡ�</t><b/>";

		case 20001:	return "<t>Ҫ֪�������������ޱȣ��������˻��п��ܵ���װ�����ߵģ��������Ǵ�ͳ���Ƽ��ķ��ϣ������С���ϣ�ȥ��װ�������°ɡ�</t><b/>";
		case 21001:	return "<t>��лͳ�졤����������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10781Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�����ϵ���ɫƷ��װ������һ��</t><b/>";
		case 10002:	return "<t>�����ɴ��������װ���������������������߿ɽ�װ���������������������װ������Ŷ!����������˷��ɴ������װ�������ɹ���Ŷ��</t><b/>";
		case 10005:	return "<t>��������ǰ����ս���������ҵȲŷ��ģ���ɽ�����ֵǮ��ϧ֮���ݴ�ֿ���ȥҲ���٣�</t><b/>";

		case 20001:	return "<t>����������˷��ɴ������װ�������ɹ���Ŷ���������������Խ���ͨ�����������и��ģ�</t><b/>";
		case 21001:	return "<t>ԭ����ˣ��������԰ɡ���</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10791Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 301: return "<t>�κεط���ֻҪ���ҵ��ң��Ҷ����������֮��ҩ���������</t><b/>";
		case 300: return "<t>�κεط���ֻҪ���ҵ��ң��Ҷ��Ὣ���װ�������Ȼһ�£���Ȼ��������һֱ��Ұ�⣬Ҳ��ʹ�ÿ������</t><b/>";
		case 303: return "<t>�κεط�ֻҪ����Ҫ���Ҷ�������ʳ������ָ�����������</t><b/>";
		case 304: return "<t>��ֻ������Ŷ����ɽ�������������⣬��֤��ȫ����һʧŶ��</t><b/>";
		case 302: return "<t>�����������ѧϰ���߼���ս������ʱ����������ɲ���ѧϰ����Ȼ���Ŀ��ܻ�������ս��ʱ�ɻ���˵��ؼ����в���</t><b/>";
		case 10001:	return "<t>���ȥ���ҩƷ��ʳ��������֮�����Ʒ���Լ��������۷�״̬��ȥ�������ʺϲ����ˣ�</t><b/>";
		case 10002:	return "<t>���������Npc���������²�����</t><b/>" @
			"<t>1������ҩƷ����ҽ[������]</t><b/>" @
			"<t>2��װ������[�Ϲ�Ѱ]</t><b/>" @
			"<t>3������ʳ�����[���ȶ�]</t><b/>" @
			"<t>4����Ʒ�洢���ֿ����Ա[������]</t><b/>" @
			"<t>5�������鹺��[������]</t><b/>";
		case 10005:	return "<t>��ȥ�����ɣ�һ��С��Ϊ��Ŷ��</t><b/>";

		case 30001:	return "<t>ÿ����ʱ�����������������Ŷ������Ľ�����Ϊ��񣬼�Ϊ����֮�أ�������ս���ǲ������Ӻ����ġ���Ȼ������ƶ�ֵ���ߣ�������֮�ر����ܻ��������װ���ĸ���Ŷ��</t><b/>";
		case 31001:	return "<t>ԭ�����������ӱ����ܵ���ĸ���ѽ��</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10801Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>���3�����������������</t><b/>";
		case 10002:	return "<t>ÿ����ʱ�����������������Ŷ������Ľ�����Ϊ���,��ս�������Կ��ɡ�</t><b/>";
		case 10005:	return "<t>�ţ����ֵ��治���Ƿ�о��Լ�����Ϊ����������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10811Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�˽⼫��֮��</t><b/>";
		case 10002:	return "<t>��ȥ�ұ��������ڵ�ʹ���˽�һ�°�</t><b/>";
		case 10005:	return "<t>���˱�֮ʥʹ���ƹܺ���Ͽ����������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10812Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>�˽⼫��֮��</t><b/>";
		case 10002:	return "<t>����Դ˺�İ������ȥ�ұ������ʰ�</t><b/>";
		case 10005:	return "<t>������֮ʥʹ���ƹ�����ȵ���������</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10813Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>�˽⼫��֮��</t><b/>";
		case 10002:	return "<t>�������˽���࣬��ȥ�ұ������ʰ�</t><b/>";
		case 10005:	return "<t>��������ʹ�ߣ��ƹܱ������������ʥ��</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10821Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 300:   return "<t>��������֪�����������ȼ��ķ�����</t><b/>";
		case 10001:	return "<t>ǰ������ѯ��</t><b/>";
		case 10002:	return "<t>�����Ҫȥ�Ҹ���������ˣ����������س���</t><b/>";
		case 10005:	return "<t>ÿ�ܶ�������������ȡ5Сʱ˫�����飬����ʱ�����Դ�������</t><b/>";

		case 20001:	return "<t>ʵ��������������֪�кδ����أ�</t><b/>";
		case 21001:	return "<t>����Ҫȥ�Ҵ�ͳ������ǰ�����ɹȳ���</t><b/>";
		case 20002:	return "<t>ԭ����ˣ�ǰ�����ɹȳ�����Ҳ��һ�β����������ץס�λ����������һ���Լ���</t><b/>";
		case 21002:	return "<t>����ʲô���������ķ���</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10831Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�����ƽ𱦲�</t><b/>";
		case 10002:	return "<t>ȥ���Աߵ��纴����ƽ𱦲ص������</t><b/>";
		case 10005:	return "<t>�����ҵ��˶���Ϊ�˴����ƽ𱦲�</t><b/>";

		case 20001:	return "<t>��˵�����ȼ��Ǻã����Ҽ���������ɬ��ֻ���պ��Ǵ粽���а�</t><b/>";
		case 21001:	return "<t>��Ҳ�����ʴ���</t><b/>";
		case 20002:	return "<t>��ֻ��˵�и��лƽ𱦲صĵط�����Ҫ��һ��ʵ������ȥ</t><b/>";
		case 21002:	return "<t>��ô�ƽ𱦲������أ�</t><b/>";

		case 30001:	return "<t>���������ң�һ����������ƽ𱦲ص������</t><b/>";
		case 31001:	return "<t>�һ�û��˵������ô֪��</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10841Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 300:return "<t>��������æ��������ӷֵ��������Ϊʦ�ž���</t><b/>";
		case 10001:	return "<t>�˽�ʦ������</t><b/>";
		case 10002:	return "<t>���10��ʦ�ž��ҾͿ��Ի�ûƽ��������ȥ�˽�һ�°�</t><b/>";
		case 10005:	return "<t>�������ʦ��������Ҫ��10���Ӳ����ٴν�</t><b/>";

		case 20001:	return "<t>�ƽ𱦲��п������������Ļƽ𣬵��Ǳ���Ҫ�ֳֻƽ�������˲��ܽ���</t><b/>";
		case 21001:	return "<t>��β��ܻ�ûƽ�������</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10851Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ѯ�ʲر�ͼ����</t><b/>";
		case 10002:	return "<t>ֻҪ�вر�ͼ�����п����ҵ��䱦�������ȥ������������</t><b/>";
		case 10005:	return "<t>����ĵ���ͦ��</t><b/>";

		case 20001:	return "<t>��ƽ𱦲�����Ȼ�ƽ�������������Щ�����ϸ���ǧ������</t><b/>";
		case 21001:	return "<t>������Ĳ��ϣ�������ô�����ҵ�</t><b/>";

		case 30001:	return "<t>���������㿴����ر�ͼ������߶������ű�����</t><b/>";
		case 31001:	return "<t>�ۣ���ر�ͼҪ������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10861Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>��ȥ�Ҵ�ͳ�츴��</t><b/>";
		case 10002:	return "<t>����Ҫ��ȥ�Ҵ�ͳ������ǰ�����ɹȳ���</t><b/>";
		case 10005:	return "<t>��ͨ����������������</t><b/>";

		case 20001:	return "<t>�Ϲ���ħ���ر����������εĽ��䣬ֻ�л������飬��ȡ���ǵĲر�ͼ�����п����ҵ��ر�</t><b/>";
		case 21001:	return "<t>ԭ��������</t><b/>";

		case 20002:	return "<t>��ô������û����Ȥ����׽���ڱ����ڵ����ر��ǿɾͷ������</t><b/>";
		case 21002:	return "<t>�ڱ�̫��ʱ�䣬�����պ���˵��</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10871Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ǰ�����ɹ�</t><b/>";
		case 10002:	return "<t>���ڱ�������������ʵ��������������Բ���ȥ���ɹ��ҹ˺͹⣬���������һЩ�����</t><b/>";
		case 10005:	return "<t>�Ǵ�ͳ���������ġ�</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10881Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>���������ߵ����Ӳ���</t><b/>";
		case 10002:	return "<t>������������ʱ�򣬸���������������ã������Ƕ���һ�ھͿ���Ⱦ�ϲ��ߣ����˷���ʤ��������취�����ź�</t><b/>";
		case 10005:	return "<t>������ã����ǿ���ר�ĶԸ�������ħ��</t><b/>";

		case 30001:	return "<t>��������ļ�ʱ����Щ���öԸ����������鷳�����ý�ʿ�ǵ�ս��������ۿ�</t><b/>";
		case 31001:	return "<t>������ħ�����ҵ���ʿ�ı���</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10891Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�����ͻ����û�Ƥ��αװ</t><b/>";
		case 10002:	return "<t>�����븽��������ͻ���������Щ��Ƥ��αװ��Ҳ����Ϊ�������</t><b/>";
		case 10005:	return "<t>�ţ����ϻ�ƤӦ�þͲ�������ע����</t><b/>";

		case 20001:	return "<t>ǰ���а���¾�����ħ�ĵ�һ�����ߣ���ħ�������������ɿ���</t><b/>";
		case 21001:	return "<t>����ǰȥ��̽һ��</t><b/>";

		case 20002:	return "<t>����óȻ�ж����������ױ�¶��ǰȥ��̽�Ļ�Ӧ����취αװ����</t><b/>";
		case 21002:	return "<t>�Ǹ���ô����</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10901Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ǰ��а���´�̽</t><b/>";
		case 10002:	return "<t>ǰȥ��̽Ҫǧ��С�ģ�һ��Ҫ�����������������óȻ�ж�</t><b/>";
		case 10005:	return "<t>��ɳ��أ��ѵ�����ɳ�����</t><b/>";

		case 30001:	return "<t>���д�̽��ʲô���</t><b/>";
		case 31001:	return "<t>ǰ�����������������ƿ�ή������ˮԴ������ɳ���</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10911Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ǰ����ɳ�룬�鿴ɳ�����</t><b/>";
		case 10002:	return "<t>���ǰ����ɳ��ȥ���������ﳣ�걻��ɳ��û��ʱ������ɳ��</t><b/>";
		case 10005:	return "<t>���˵����Ҳ������һ�ֿ��ܡ�</t><b/>";

		case 30001:	return "<t>��ô�������¸�ɳ������ʲô��ϵ��</t><b/>";
		case 31001:	return "<t>��Щɳ����û��������ʵ���������Ӳ���ɳ����Ϊ</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10921Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>��������</t><b/>";
		case 10002:	return "<t>ǰ������������һλ��������ڴ˱չ�������������౦�����ʵ����ɲ⣬��֪�Ƿ�����й�</t><b/>";
		case 10005:	return "<t>��������ǰ���������ʵ��̫ǿ</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10931Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>���ܺ��������������붴�ڲ�̽</t><b/>";
		case 10002:	return "<t>����������ڲ�̽ǧ�򲻿ɾ��ŵ������������������³���ܲң�</t><b/>";
		case 10005:	return "<t>�������Ǻ�����Ϊ��</t><b/>";

		case 20001:	return "<t>��������������â����Ѳ�ߣ����뽫����ܲſɽ��붴��</t><b/>";
		case 21001:	return "<t>�õģ�û����</t><b/>";

		case 30001:	return "<t>�ɷ��ֺ�����ʲô�쳣��</t><b/>";
		case 31001:	return "<t>����Ǳ�������������������²�������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10941Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ǰ�����ɿ�</t><b/>";
		case 10002:	return "<t>ǰȥ���ɿ�Ҫ���С�ģ��������ħ���ǻ����������˵�</t><b/>";
		case 10005:	return "<t>�����Ǵ����ɿߵ�������һֱ�ڴ���ס�ع����</t><b/>";

		case 20001:	return "<t>����ֻ�н������ɿ�����һ���ˣ�������Ҫ�鷳����</t><b/>";
		case 21001:	return "<t>������ħ���ҵ��޵����֣������鷳</t><b/>";

		case 20001:	return "<t>վס��</t><b/>";
		case 21001:	return "<t>���Ǻ��ˣ�Ϊ���Ҹղ�����û�з�����</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10951Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�������ɿ���</t><b/>";
		case 10002:	return "<t>�Ǻã�����ع����������Σ�գ���������ڣ����ڴ�������ħ���ҳ���</t><b/>";
		case 10005:	return "<t>ԭ�����</t><b/>";

		case 20001:	return "<t>�����˴���ʲô</t><b/>";
		case 21001:	return "<t>��ħ�Ĵ����ң�����ǰ�����ɿ��ڲ鿴�Ǻ�ԭ��</t><b/>";

		case 20002:	return "<t>ԭ����ˣ����������ħ���������ǿ�󣬶��Ҷ������������ˣ���ȷ��Ҫȥ��</t><b/>";
		case 21002:	return "<t>�����Ҳ������Ӳ���һ��Ҫȥ</t><b/>";

		case 30001:	return "<t>�ع�����֮�أ����������Ϊ�λ�������</t><b/>";
		case 31001:	return "<t>��ħ�Ĵ����ң�����ǰ�����ɿ��ڲ鿴�Ǻ�ԭ��</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10961Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>������ħȮ֤��ʵ��</t><b/>";
		case 10002:	return "<t>���˵�����պ������ħȮ�Ե���Щ���꣬��ȥ��ѵһ�°�</t><b/>";
		case 10005:	return "<t>�ţ������ԡ�����������ħȮҲ�Ը����ˣ�Ҳ�������������ȥ��</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10971Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ȥѰ��Ԫ�����˽�</t><b/>";
		case 10002:	return "<t>���ڴ˴�Ҳ�����߶����������Ҫ���Ѱ��Ԫ�����˽����</t><b/>";
		case 10005:	return "<t>�ѵ������Ԫ���⣬��������ɫ���ף���ʲô�����Ĺ�����</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10981Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ץ��ȡ��</t><b/>";
		case 10002:	return "<t>ǰ���Ѱ������ߣ������ߵ����ɽⶾ</t><b/>";
		case 10005:	return "<t>̫���ˣ��н�ҩ�ˡ�</t><b/>";

		case 20001:	return "<t>��λ�����������ã����ڴ�̽�Ӳ�С���ж��ˣ��ɷ����ȥŪ���ҩ��</t><b/>";
		case 21001:	return "<t>ԭ�����ж��ˣ�����β��ܻ�ý�ҩ��</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission10991Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>���ˮ��</t><b/>";
		case 10002:	return "<t>�����������ˮ�����⣬Ӧ��ǰ��ˮԴ���鿴һ��</t><b/>";
		case 10005:	return "<t>��λ����������</t><b/>";

		case 20001:	return "<t>�����Ķ�����㼰ʱ����</t><b/>";
		case 21001:	return "<t>������ö˶˵���ô���ж���</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11001Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�˽ⶾԴ</t><b/>";
		case 10002:	return "<t>�˴�ˮԴ����Ⱦ��ֻ��һ�ѱ�������Ϯ����ħ��</t><b/>";
		case 10005:	return "<t>С�Ĳ�Ҫ������������</t><b/>";

		case 20001:	return "<t>��ˮ�ж�����������</t><b/>";
		case 21001:	return "<t>��λǰ����Ϊ��֪����ˮ�ж���</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11011Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>��ӡ��ħ��</t><b/>";
		case 10002:	return "<t>��ֻ���Ƚ���ħ����ӡ�������պ�����취</t><b/>";
		case 10005:	return "<t>���������������</t><b/>";

		case 20001:	return "<t>�������и��ĳǹ�����ɢ�������������ܵ���ֻ��ʹ�����ɷ������ֵܵ�Ƭ�̡�</t><b/>";
		case 21001:	return "<t>����Ҫ������������ɷ���</t><b/>";

		case 20002:	return "<t>�ҷ����������ܾ��������ɷ���������Ҳֻ�ֵܵ����޷���ɢ</t><b/>";
		case 21002:	return "<t>��Ҫ��ȥ���سǣ�û����ô��ʱ����</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11021Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ǰ�����ɿ߶���</t><b/>";
		case 10002:	return "<t>ȥ�����ɿ߶��������̩�裬�˽��������Դ</t><b/>";
		case 10005:	return "<t>����Ҫ�˽���������Դ</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11022Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>����а�Ⱥ�</t><b/>";
		case 10002:	return "<t>�˴�������̫�أ������ᱻѹ�ƣ�û�����ɷ����Ǵ�����ȥ��</t><b/>";
		case 10005:	return "<t>��Ȼû�����ɷ���Ҳ�����ˣ����������Ű�</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11031Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�˽��������ȥ�Ҵ�ͳ��</t><b/>";
		case 10002:	return "<t>���ڴ˴�Ҳֻ�ֵܵ�����������ɢ��������黹��Ҫ��ȥ�Ҵ�ͳ��㱨����</t><b/>";
		case 10005:	return "<t>ԭ����ˣ���������</t><b/>";

		case 20001:	return "<t>��ǧ��ǰ���м�λ�����ڴ˹�ͬ���䣬���ʵ���������������ɽ�ߣ��������������������</t><b/>";
		case 21001:	return "<t>����ʲô�취�����</t><b/>";

		case 20002:	return "<t>�˴�������ɢ����ʹ���ܹ�������Ҳ�Ἧ������������</t><b/>";
		case 21002:	return "<t>���ⲻ���޽�����</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
//�������������������������������ɹ������������������������������������

//������������������������������ɽѩ�������������������������������������
function Mission11040Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>���ջ�Ե</t><b/>";
		case 10002:	return "<t>֮ǰ�������һ������������������Ȼ�ȥ������Ϣ�����������Ӻ��������������飬�����ȥ��������</t><b/>";
		case 10005:	return "<t>�Ϸ���ָһ�㣬����һ�ݻ�Ե�ڲ�ɽѩ���������֪����</t><b/>";

		case 30001:	return "<t>С�һ����������ˡ����ɿ�һ�Σ��Ƿ�����Լ�����Ϊ�����������أ�</t><b/>";
		case 31001:	return "<t>ȷʵ�м���������ǰ���кδͽ�...������Ϲ����������Ҹ����</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11041Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ǰ����ɽѩ��</t><b/>";
		case 10002:	return "<t>�����������й¶����֪������Լ�ȥ��ɽѩ�������ɣ�</t><b/>";
		case 10005:	return "<t>·��ͻȻð����ֻѩ�׵Ĺ��������צ���˹���</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11051Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>���ܱ�ѩ����</t><b/>";
		case 10002:	return "<t>·��ͻȻð����ֻѩ�׵Ĺ��������צ���˹���</t><b/>";
		case 10005:	return "<t>�����캮�ض��ģ���λС������ô�������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11061Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�������һ�����</t><b/>";
		case 10002:	return "<t>�ұ�����Ѱ����ʧ���⸽�������Σ�˭֪����ͻȻð�������ܹ֣�������������ز�ȥ�ˣ����ܰ��Ұ������һ�����</t><b/>";
		case 10005:	return "<t>���ﶼ��ôΣ���ˣ��㻹ֻ����������Σ������������ô��Ҫ��</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11071Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�����ƻذ׻�կ</t><b/>";
		case 10002:	return "<t>������ĸ�������ҵģ�����̫лл���ˣ���ô���������һ�ȥ���Ҿ�ס��ǰ���İ׻�կ</t><b/>";
		case 10005:	return "<t>ֻ�������Σ��֮�أ���λС������һ��ǰ����</t><b/>";

		case 30001:	return "<t>����㽫СŮ�ͻ��������Ǹм���������΢���񣬻���Ц�ɡ�</t><b/>";
		case 31001:	return "<t>��ֻ�Ǿ���֮�Ͷ��ѡ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11081Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ѯ���ԭZ</t><b/>";
		case 10002:	return "<t>�����ȥ���ԭZ��ѯ��һ��</t><b/>";
		case 10005:	return "<t>�������ܵ����Զӳ��ɵ��鵽ʲô��</t><b/>";

		case 20001:	return "<t>�����������֪�ˣ�ԭ���˴���û����Щ���ֵܹġ�ֻ�ǲ�֪��Ϊ��ͻȻ��ð�����ˣ������ӳ��ԭZ���ڵ���ԭ��</t><b/>";
		case 21001:	return "<t>���ҵ����뿴�����⵽�����ڸ�ʲô��</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11091Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>���ܲ�ѩ��ʦ</t><b/>";
		case 10002:	return "<t>������Ϊ�׻�կ�Ŀ��ˣ������������գ����ǲ�����</t><b/>";
		case 10005:	return "<t>���գ���Щ��ʦ����������������в������ᱻ�Ի����ǣ����ͻز�����</t><b/>";

		case 20001:	return "<t>������һЩüĿ�ˣ���Щ���ܶ��ǴӲ�ѩӪ�����ģ���������ȥ�飬���ǽ�ȥ���˶�û�л����ˣ����Լ�����Ͼ����</t><b/>";
		case 21001:	return "<t>��Ȼ��ˣ����ҵ���Ҫ��ȥ����</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11101Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>Ѱ��ҩʦ��ҩ</t><b/>";
		case 10002:	return "<t>����Ӧ��û����ô���������Ǹ��˴��Ϻ��������ศ��ɣ��Ż�����˴�����������ǰ��Ѱ��ҩʦ��Ҫ����������Ϻ����Ͳ���η����Щ��ʦ��</t><b/>";
		case 10005:	return "<t>��ҩʦ����ǰ����ѩӪ��Ҫ�����裬�ܷ����Ҽ�����</t><b/>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11111Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�ɼ�������</t><b/>";
		case 10002:	return "<t>�����ˣ���˵�ĵ������ɡ����֪�����Ʊ�������Ҫ���ٺ��������������ܰ��Ҳ������ҾͿ��԰�������</t><b/>";
		case 10005:	return "<t>�õģ����˱����裬���ҾͲ�����Щ��ʦ��</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11121Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>��ȱ�������ʿ</t><b/>";
		case 10002:	return "<t>��˵��Щʧ�ٵ���ʿֻ�����������ˣ��������ĳ���ʱ�䲻������Ҫץ��ʱ�䣬�ȳ���ʿ�ͻ���</t><b/>";
		case 10005:	return "<t>�����ܱ��Ȼ����������������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11131Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>Ѱ���������Ұ������</t><b/>";
		case 10002:	return "<t>�����ǻ�������˵���ڲ�ѩӪ�п���Ұ�˵ĺۼ���Ұ��������ѩ��ƽԭ�Ż���֣������Ѱ���������һ��</t><b/>";
		case 10005:	return "<t>��˵��Ұ�˳����ڲ�ѩӪ�����������һЩ���</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11141Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>���ܲ�ѩҰ��</t><b/>";
		case 10002:	return "<t>˵��Ҳ��֣���Ҳż������Ұ�ˣ���������ܾ������ǵ������÷ǳ����ꡣ�������Լ�ȥ���濴�����</t><b/>";
		case 10005:	return "<t>��ЩҰ�����Ǳ��꣬���ǿ����ǵ���̬��ȱ�ָ��տ�ʼ�����ĺ���������Щ����</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11151Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>Ѱ�ҿ������</t><b/>";
		case 10002:	return "<t>��ô˵������һ���������ƺ�����һЩ���е���ϵ�������ȥ�����Ǳ�ѩ�����Ŀ����������һ�����</t><b/>";
		case 10005:	return "<t>�׻�կ�Ŀ��侹Ȼ��һλ�����ò��Ů�ӣ��������˳Ծ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11161Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ѯ��Ұ��ԭ��</t><b/>";
		case 10002:	return "<t>�����������������������Һ������ܵ�����İɡ��󲿷��Ǿ����Ҷ���˵�ˡ���Ҳ���ǵ�ʶ���ˡ�</t><b/>";
		case 10005:	return "<t>��������ҷ�����Ұ��Ҳ����֮����һЩ��ϵ����������ô��</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11171Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>����ѩ��</t><b/>";
		case 10002:	return "<t>Ŷ��Ұ��������������Ļ����ǿ��ܲ�ֻ��Ұ���ˡ�ѩ��ƽԭ������ѩ����û����ȥ�����˽�һ�°�</t><b/>";
		case 10005:	return "<t>�������ϣ�ѩ��Ҳ�Ǳ�ñȽ��쳣</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11181Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>����ѩ������ȡѩ���ڵ�</t><b/>";
		case 10002:	return "<t>�ţ��Ǿ�û���ˡ���Щ��ʦ�����Ի���û�����ǵ�Ұ�˺�ѩ������Ұ�˵������ѩ�����ڵ��Ƴ��˿��ܣ�����ȥŪ����ѩ���ڵ�����������Ҫϸϸ�о���</t><b/>";
		case 10005:	return "<t>֮ǰ��ô��˵�����ֶ�����һ�ˡ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11191Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>���µ����������</t><b/>";
		case 10002:	return "<t>�Ǻǡ����¼����á����ҽ�����ԭ�ɸ���կ���ɡ�</t><b/>";
		case 10005:	return "<t>��Щ��ʦ�����к���ͼ</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11201Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>Ѱ����־��ѯ�ʷ⽣̨���</t><b/>";
		case 10002:	return "<t>Ī��������Ҫ����ѩ��ħ������Ҫ���ͷ�������һ���ˣ�����ȥ�鿴�⽣̨�Ƿ����쳣�������ҵ�����</t><b/>";
		case 10005:	return "<t>�����˴����⽣̨�Ƿ����쳣����������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11211Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ѯ�ʷ⽣̨ǰ����</t><b/>";
		case 10002:	return "<t>��һֱ�ڴ˴����⽣̨û�м������������ף���ôͻȻ�������ô�ལū��</t><b/>";
		case 10005:	return "<t>��Щ��ū��ʲô������</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11221Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>ѯ�ʷ⽣̨ǰ����</t><b/>";
		case 10002:	return "<t>��⽣̨ԭ���Ƿ�ӡ���Ϲ�ħ����ż���н�ū����Ҳ������������һ���ӳ�����ô�ֻ࣬����Ҫ���Ʒ�ӡ����</t><b/>";
		case 10005:	return "<t>�������ô�죿</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11231Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�������ܽ���</t><b/>";
		case 10002:	return "<t>������ȥ����ū������������ħ�����Ʒ�ӡ</t><b/>";
		case 10005:	return "<t>�������ļ�ʱ����Ȼ��ɲ��ô���</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11232Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>���⽣̨</t><b/>";
		case 10002:	return "<t>������ȥ���һ�·⽣̨�ɡ�</t><b/>";
		case 10005:	return "<t>�Ȳ�����ô����</t><b/>";

		case 30001:	return "<t>������֣���ԭ���о���ħ���Ѿ�����������Ϊ����һ�����ͱ�ð��������ˡ�</t><b/>";
		case 31001:	return "<t>�ղ���Ҳ�о�����������������Ҳ������Ǻ�ԭ��</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11241Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>���⽣̨�������կ��</t><b/>";
		case 10002:	return "<t>�����������ˣ��콫������������կ���ɡ�</t><b/>";
		case 10005:	return "<t>��ħ��ԭ����������������������Ӧ������õ�ħ���������ܳ��ƽ�磬Ϊ���˽硣��ʱ���ֲ���һƬ����Ϳ̿��</t><b/>";

		case 30001:	return "<t>��Ȼ��ˣ������������Щ��ʦ��Ŀ����</t><b/>";
		case 31001:	return "<t>����ħ����ѩ��ħ������ʲô��ϵ��</t><b/>";
		case 30002:	return "<t>���ѩ��ħ����˯�ڱ��������У������Ϲ��������µ������ڴ�����ħ����ʹ�䲻�ҳ�����</t><b/>";
		case 31002:	return "<t>���кξ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11251Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�����ѩ��ʦ</t><b/>";
		case 10002:	return "<t>��������Щ��ʦ�ļ�Ƶóѣ����������˽����ǽ�����������������һ��֮����</t><b/>";
		case 10005:	return "<t>��Щ��ʦ���ǽƻ���û��ô���׼��𡣵����ڲ�ѩӪʱ����Լ�������Ǳ�����ҵĽ���</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11261Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>�ص����ظ�֪Īǰ��</t><b/>";
		case 10002:	return "<t>����������ħ�����Ҫ�����ˣ�����������û��ħ����ֻ������֮������֧��̫�á�����Ҫǰ�����سǣ����������ʿһ�����Ը�ħ��</t><b/>";
		case 10005:	return "<t>�ϣ�����������������Ϊ���������ٰ�</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}

//������������������������������ɽѩ�������������������������������������


//���������������������������������������������������������������������
function Mission11271Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>ħ��֮��</t><b/>";
		case 10002:	return "<t>�������Ļ�Ե�������ϲ������ħ��ӡ֮����ħ�������������ˣ���ħ���Ժ�Ҫ��Զ��˯��</t><b/>";
		case 10005:	return "<t>�ⲻ��ͦ������ħ��֮���к�Ӱ��</t><b/>";

		case 20001:	return "<t>��������Ѿ��������Ҫ������</t><b/>";
		case 21001:	return "<t>��һ���ɻ�Ϊ�ο����Ϲ�ħ�������Ŀ��겻����</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11281Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>��������Υ</t><b/>";
		case 10002:	return "<t>������������Υ��ֻҪ��������������鵤��ҩ�ศ����ɻ���Ϊ�ģ����Ϳ�����컯�ˡ�</t><b/>";
		case 10005:	return "<t>����Ҫ���ȥѰ���鵤��ҩ</t><b/>";

		case 20001:	return "<t>�������ܼ�Ԧ����������������������ң����Ǳ����������Ԧ��������Ϊ��ʧ���������ħ������ٲ�����</t><b/>";
		case 21001:	return "<t>��Ȼ���Σ�գ��������ɲ�Ҫ������</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11291Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>ǰ����ͳ��</t><b/>";
		case 10002:	return "<t>���ʥҩ��Ϊ��ʢ�ģ��Ǿ����������ˡ���ǰ��ͳ�췢���������ȥ�����ɡ�</t><b/>";
		case 10005:	return "<t>��������ʿ��ħ������ģ�������Ҫ����ǰȥ�������ռ���ҩ��</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11301Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>ǰ��������</t><b/>";
		case 10002:	return "<t>��ɸ���������ʿһͬǰ����������������˽�Ӧ���ǡ�</t><b/>";
		case 10005:	return "<t>�����ǰ���ռ���ҩ����</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11311Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>����Ť������</t><b/>";
		case 10002:	return "<t>��λ���������˰����������������ض��Ǳ���ֻ������������Щ�����������鷳��ȥ����Щ�������</t><b/>";
		case 10005:	return "<t>�������ˣ������Ҿͷ����ռ�ҩ����</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11321Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>�ɼ������</t><b/>";
		case 10002:	return "<t>�һ�ȱ��һζ����ݣ��ɷ�ȥ���Ҳ�һ���أ���̨���洦�ɼ�</t><b/>";
		case 10005:	return "<t>�ţ�������һ����ҩ�Ĳ��Ͼ����ˡ�</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11331Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>�ʹ�ҩʦ</t><b/>";
		case 10002:	return "<t>����Щ������ȥ��ҩʦ���ư�</t><b/>";
		case 10005:	return "<t>��ҩʦ�����ǵ�һ�ֵ�ҩ�Ĳ���</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11341Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>ѰҪҩ��</t><b/>";
		case 10002:	return "<t>�ܺã��ǻ���һ����ҩ���ϣ���ȥ��������������</t><b/>";
		case 10005:	return "<t>����������ҩ��ֻ������ϻ�δ��ȫѽ</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11351Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>���ܹ�����è</t><b/>";
		case 10002:	return "<t>��Ҫ�����ֵ�����ֻ���������è�ɲ����ǰ��������ܽ����Ǹ��ܾͺ���</t><b/>";
		case 10005:	return "<t>��è�����ˣ��������</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11361Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>�ɼ�����</t><b/>";
		case 10002:	return "<t>�һ�����������æ���ͷ�����ȥ���Ҳ�������ȥ��ҩʦ��</t><b/>";
		case 10005:	return "<t>�ţ�������������</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11371Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>ץ��ֻ���</t><b/>";
		case 10002:	return "<t>����䶾��ֻҪ�����������ҩ��Ҳ���ǲ����Ե�</t><b/>";
		case 10005:	return "<t>ԭ����ܻ���ҩ��</t><b/>";

		case 20001:	return "<t>���������ܰ���ȥץ��ֻ�̶��������̫����</t><b/>";
		case 21001:	return "<t>����ܲ��Ƕ�����</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11381Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>ץ��ֻ����ħ��</t><b/>";
		case 10002:	return "<t>�����Ҫ�����ศ����������ħ�����պ�ȥ�����Ķ��Ա���ҩ�ԣ�����ȥץһЩ����</t><b/>";
		case 10005:	return "<t>��Щ����ħ��Ҳ̫�׺��˰�,Ϊ�λ����ƶ�</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11391Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>���δ���ε�����ħ��</t><b/>";
		case 10002:	return "<t>ħ�����Σ�������棬�Կ����飬��Щħ�������������֮�죬��ɲ�̫�ã�����Ҫ��������֮ǰ��������</t><b/>";
		case 10005:	return "<t>ԭ����ħ������֮ǰ�ǲ��ṥ���˵�</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11401Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>��ʱ����</t><b/>";
		case 10002:	return "<t>�������ļ�ʱ����������Щħ�����Σ���Ҫ��һ��Σ����</t><b/>";
		case 10005:	return "<t>���Ǹղ��Ҿ�����һƬĢ��ʱ�������������ĸо�</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11411Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>�ɼ�Ģ��</t><b/>";
		case 10002:	return "<t>��ЩĢ�������������˴������ò��ϣ������������Դ�����У��Ǿ���˵����˵��������Ҫ��ζҩ��</t><b/>";
		case 10005:	return "<t>Ģ�����������֮�࣬Ӧ����ô����</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11421Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>Ѱ�ҿɶ�</t><b/>";
		case 10002:	return "<t>������Ģ����Ҫ��������Ȫˮ�ſ����ƣ���ȥ�ҿ�����Ȫ�Ŀɶ���ҪһЩ��</t><b/>";
		case 10005:	return "<t>����ҩ������ҪһЩ��Ȫˮ</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11431Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>����ľ����</t><b/>";
		case 10002:	return "<t>��Ҫ��Ȫû�����⣬�����⸽������Щľ���޳��Ҳ�ע����͵����Ȫˮ������Ұ����Ǹ��ܰ�</t><b/>";
		case 10005:	return "<t>�õģ������鷳����</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11441Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>�������ƿ</t><b/>";
		case 10002:	return "<t>��������Ȫ��Ҫ�����ƿ����װ����������ɢʧ���͸���ͨϪˮû��ʲô�����ˣ����Լ�ǰȥ�����</t><b/>";
		case 10005:	return "<t>������������ƿ����</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11451Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>�ɼ���Ȫ</t><b/>";
		case 10002:	return "<t>���ˣ����Լ�ȥ��һ����Ȫ��</t><b/>";
		case 10005:	return "<t>��Ȫ�Ѿ������ˣ�����ҩʦ��������</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11461Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>����ҩЧ</t><b/>";
		case 10002:	return "<t>��������Թ���һ�ֺ��ݣ����ô�ҩЧ��������ֻ�������Σ�����أ�һ���˿�ȥ���ð�</t><b/>";
		case 10005:	return "<t>�����ڵ�ħ��֮���Ѿ������������ݲ�������ԥ�ˡ��Ҹ����ǰ���</t><b/>";

		case 20001:	return "<t>����ĪҪ�ż�������Ȫ��Ȼ���ˣ��ɻ����ܷ������ҩЧ</t><b/>";
		case 21001:	return "<t>�ǻ����������ܷ������ҩЧ��</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11471Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>Ѱ��ѩܰ</t><b/>";
		case 10002:	return "<t>�����֮��ֻ��ѩ֪ܰ��������������������</t><b/>";
		case 10005:	return "<t>���������Թ�Ѱҩ������ǰ��ָһ����·</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11481Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>���ܱ��캣��</t><b/>";
		case 10002:	return "<t>�����ˣ�������Ѱҩ���˺ܶ࣬����û�м����ǿ��Ի��ų����ġ�ǰ���������֮�أ�������Ҫ����սʤ���캣�������</t><b/>";
		case 10005:	return "<t>СС���࣬����Ϊ�塣</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11491Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>�ɼ���ˮ����</t><b/>";
		case 10002:	return "<t>�ã����Ҿͷ��Ľ�����ôȥ��ˮ����������һ����ʿ��Ҫ�����泤ʱ��ͣ�����ͱ���Ҫ������ˮ���顣�ڽ����������ҵ�</t><b/>";
		case 10005:	return "<t>�ܲ�����˱����ǰ����</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11501Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>�ɼ�����</t><b/>";
		case 10002:	return "<t>����գ��Լ�ȥ�ɼ����ݻ�Ҫ���С��</t><b/>";
		case 10005:	return "<t>���ѽ����ݲɻأ�����ҩʦ�������Ƶ�ҩ</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11511Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>����֮ϲ</t><b/>";
		case 10002:	return "<t>���˹��ˣ����һ���һЩʣ�ֻ࣬����ʣ��Ĳ�����Ҳû�ã����Ҿ��Լ�������</t><b/>";
		case 10005:	return "<t>�⵹���޷�</t><b/>";

		case 20001:	return "<t>��ѽ��û�뵽����õ��ˣ���֪��������һ����</t><b/>";
		case 21001:	return "<t>�⣬�ѵ�������������</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11521Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>��Ϊ����</t><b/>";
		case 10002:	return "<t>��ͳ�������Ҳ����ˣ���Ҫ�Ķ���Ҳ�ҵ��ˡ��ǿ�����س�ȥ��</t><b/>";
		case 10005:	return "<t>Īǰ������ȥ�����Ѱ������˵�ĵ�ҩ�����ڸо��Լ�����Ϊ��������</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}
function Mission11531Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>��ž�</t><b/>";
		case 10002:	return "<t>���������ǵ͵��������ֹ������һ�㣬��ֱ����ͻ���ͽ�����</t><b/>";
		case 10005:	return "<t>û�뵽��˶̵�ʱ����Ѿ���Ϊ�ʹﵽ����ž���������η����</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == ���� Npc ��" @ %Npc @ "��Player��" @ %Player @ "��Mid��" @ %Mid @ "��Tid��" @ %Tid @ "��";
	else
		return "";
}

//���������������������������������������������������������������������