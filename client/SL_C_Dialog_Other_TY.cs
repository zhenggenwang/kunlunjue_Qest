//������������������������ȡ��Ի�����������������������������������

$YuanBaoShangCheng = "<c cid='" @ Get_TraceButton() @ "' cmd='\"" @ "OpenBusinessCity();setSuperMarketType(4);setBusinessCityItemType(2);" @ "\",\"" @ $Get_Dialog_GeShi[80005]  @ "Ԫ���̳�" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />";
function Get_TY_Dialog_TY(%Npc,%Player,%DialogID,%Param)
{
	switch (%DialogID)
	{
		case 600000000: return $Get_Dialog_GeShi[80002] @ /*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
			$Get_Dialog_GeShi[80000] @ "��ȺӢ��ۣ�</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "������ʱ�䣺</t><t>ÿ��</t>" @ $Get_Dialog_GeShi[80003] @ " 19:00 " @ "</t><t>��ʼ</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "���������</t><t>��������</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "���������</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "1�������ٻ�����ͼ��</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "2����������ͼ����ȡͼ��֮��״̬</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "3����ԡͼ��֮�����ɳ�����þ���</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "4����Ҳ���Ի���һ����Ԫ����ȡ�������ɵ�ͼ��</t><b/>" @
			$Get_Dialog_GeShi[80004] @ "С��ʾ�������ȡ�Ĳ��Ǳ����ͼ�ڣ���Ҫ����200Ԫ���ſ�����ȡͼ��״̬������100Ԫ�������ٻ���ͼ�ڵİ�����ã���</t>";

		case 600000001: return $Icon[5] @ "<t>��ȡͼ��֮��</t>";

		case 600000002: return $Get_Dialog_GeShi[31492] @ "�㲻�Ǳ����Ա����Ҫ����200Ԫ��������ȡ������100Ԫ�������ٻ���ͼ�ڵİ�����ã����Ƿ�ȷ����ȡ?</t>";

		case 600000003: return $Icon[5] @ "<t>ȷ����ȡ������۳�200Ԫ��)</t>";

		case 600000004: return $Get_Dialog_GeShi[80002] @ /*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
			$Get_Dialog_GeShi[80000] @ "��ʱ���Ѻۡ�</t>" @
			$Get_Dialog_GeShi[80001] @ "������ʱ�䣺</t><t>ÿ��</t>" @ $Get_Dialog_GeShi[80003] @ " 19:00--22:00 " @ "</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "����ս���飺</t><t>���ˣ�ս��������������</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "������������</t><t>��������</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "���������</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "1��ÿ��ÿ�����սһ��</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "2��������Ѱ���Լ��ı�����ˢ���ǻ�ȼ�</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "3�����ݲ�ͬ���ǻ�ȼ���ò�ͬ�ľ��鱶��</t><b/>" @
			$Get_Dialog_GeShi[80004] @ "С��ʾ�����븱�������ˢ��һ���ǻ�ȼ���</t></t>";

		case 600000005: return $Icon[10] @ "<t>���븱��</t>";

		case 600000006: return $Get_Dialog_GeShi[80002] @ /*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
			$Get_Dialog_GeShi[80000] @ "��ʱ���Ѻۡ�</t>" @
			$Get_Dialog_GeShi[80001] @ "������ʱ�䣺</t><t>ÿ��</t>" @ $Get_Dialog_GeShi[80003] @ " 19:00--22:00 " @ "</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "����ս���飺</t><t>���ˣ�ս��������������</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "������������</t><t>��������</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "���������</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "1��ÿ��ÿ�����սһ��</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "2��������Ѱ���Լ��ı�����ˢ���ǻ�ȼ�</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "3�����ݲ�ͬ���ǻ�ȼ���ò�ͬ�ľ��鱶��</t><b/>" @
			$Get_Dialog_GeShi[80004] @ "С��ʾ�����븱�������ˢ��һ���ǻ�ȼ���</t></t>";
		case 600000007: return $Icon[5] @ "<t>������ս</t>";

		case 600000008:  return $Get_Dialog_GeShi[80002] @ /*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
			$Get_Dialog_GeShi[80000] @ "����ħԨ��</t>" @
			$Get_Dialog_GeShi[80001] @ "������ʱ�䣺</t><t>ȫ�쿪��</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "����ս���飺</t><t>6��</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "������������</t><t>������</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "���������</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "1��ÿ��ÿ��������ս</t>" @ $Get_Dialog_GeShi[80003] @ " 1 </t>" @ "<t>��</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "2��ʹ��</t>" @ "<l i='105109201 ' t='itemid'/>" @ "<t>��ս��ÿ�����</t>" @ $Get_Dialog_GeShi[80003] @ " 2 </t><t>��</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "3�����ܵع������м��ʵ���</t>" @ GetItemName(105109201,1) @ "<b/>" @
			$Get_Dialog_GeShi[80002] @ "4��ÿ����һ�����죬���ɻ��һ�ݽ�����ͬʱ������һ��</t><b/>" @
			$Get_Dialog_GeShi[80004] @ "С��ʾ��������սʱ��Ϊ10�֣���ս�������޷���;��ͣ��</t></t>";

		case 600000009: return $Icon[10] @ "<t>���븱��</t>";

		case 600000010: return $Get_Dialog_GeShi[80002] @ /*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
			$Get_Dialog_GeShi[80001] @ "����ս����</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "1���ɶӳ�������ս</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "2����һ��������������Կ�����һ����ս����</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "3���ܹ���սʱ��Ϊ10�֣���;����Ϣʱ�䣬�޷���ͣ</t><b/>"@
			$Get_Dialog_GeShi[80004] @ "С��ʾ��������ս���޷���;ֹͣ!</t><b/>";

		case 600000011: return $Icon[5] @ "<t>������ս</t>";

		case 600000012: return $Icon[5] @ "<t>��ս��һ������</t>";

		case 600000013:  return $Get_Dialog_GeShi[80002] @ /*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
			$Get_Dialog_GeShi[80000] @ "���þ����ԡ�</t>" @
			$Get_Dialog_GeShi[80001] @ "������ʱ�䣺</t><t>��һ��������" @ " </t>" @ $Get_Dialog_GeShi[80003] @ "20:00-20:05" @ " </t><b/>" @
			$Get_Dialog_GeShi[80001] @ "����ս�ȼ���</t><t>40��</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "����ս������</t><t>���˽���</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "������������</t><t>�����ߡ���������</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "���������</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "1��ֻ�����˽���</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "2���þ�������4�㣬Խ�߲㽱��Խ��</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "3������һ�˻��һ��״̬������һ�μ���һ��</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "4�����ۻ�</t>" @ $Get_Dialog_GeShi[80003] @ " 5 </t>" @ "<t>��״̬��������һ��</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "5����״̬����Ϊ</t>" @ $Get_Dialog_GeShi[80003] @ " 0 </t>" @ "<t>ʱ������䵽��һ��</t><b/>" @
			$Get_Dialog_GeShi[80004] @ "С��ʾ���ڻþ������ڣ����е��˶�����ĵ��ˣ�</t></t>";

		case 600000014: return $Icon[10] @ "<t>���븱��</t>";

		case 600000015:  return $Get_Dialog_GeShi[80002] @ /*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
			$Get_Dialog_GeShi[80000] @ "�����ɿ�һ���</t>" @
			$Get_Dialog_GeShi[80001] @ "������ʱ�䣺</t>"  @ $Get_Dialog_GeShi[80003] @ " </t><t>����</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "����ս�ȼ���</t><t>20-30��</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "1��ֻ�����˽���</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "2�����ɿ�����ܶ��¹ʷ��������Ը�����һ���������ɿߣ�</t><b/>" @
			$Get_Dialog_GeShi[80004] @ "С��ʾ�������ɿ��ڣ����е��˶�����ĵ��ˣ�</t></t>";

		case 600000016: return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "<t>�ɼ���ҩ</t>";/*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/

		case 600000017: return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "<t>��ս��Ӣ����</t>";/*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/

		case 600000018: return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "<t>��ѹȺ��</t>";/*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/

		case 600000019: return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "<t>Ѱ��ʧ��ɢ��</t>";/*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
		case 600000020: return "<t>�˴ζ�����ΰ�������Ȼ���¡���</t>";/*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/

		case 600000021: return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "<t>����Ѱ�����ˣ����Ȱ��㴦�����˿ڡ�</t>";/*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/

		case 600000022: return $Get_Dialog_GeShi[80002] @ "<t>�����޴󰭣������Լ���ȥ�ˣ���л���ѣ�</t>";/*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/

		case 600000023: return $Get_Dialog_GeShi[80002] @ "<t>���������</t>" @ "<l i='" @ "8" @ getact(getplayer(),4013,0) @ "0100 " @ $strMapRanPosRecord[getact(getplayer(),4013,0),getact(getplayer(),4013,1)] @ "' t='path'/>" @ $Get_Dialog_GeShi[80002] @ "���Ͽ�ǰȥ�ɣ�</t>";

		case 600000024: return $Get_Dialog_GeShi[80002] @ "<t>�ر�ͼָ��ķ�λ��</t>" @ "<l i='" @ "8" @ getact(getplayer(),4014,0) @ "0100 " @ $strMapRanPosRecord[getact(getplayer(),4014,0),getact(getplayer(),4014,1)] @ "' t='path'/>" @ $Get_Dialog_GeShi[80002] @ "��������ҪϹ��㣡</t>";

		case 600000025:
			%Level = getplayer().getlevel();
			if (%Level < 35)
				%Level = 35;
			return $Icon[19] @ $Get_Dialog_GeShi[31496] @ "ѭ��-[" @ %Level @ "] ʦ�ž��ң����ܣ�</t>";
		case 600000026: return $Get_Dialog_GeShi[80002] @ /*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
			$Get_Dialog_GeShi[80000] @ "�������������</t>" @
			$Get_Dialog_GeShi[80001] @ "������ʱ�䣺</t><t>18:00-24:00 </t><b/>" @
			$Get_Dialog_GeShi[80001] @ "����ս�ȼ���</t><t>40��</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "����ս������</t><t>����</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "������������</t><t>������</t><b/>" @
			$Get_Dialog_GeShi[80001] @ "���������</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "1��ֻ�����˽���</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "2������������ÿ�������ս3��</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "3������������һ����10��</t><b/>" @
			$Get_Dialog_GeShi[80002] @ "4���ɹ���սһ���ؿ�����һ�����䣬ͬһ���ؿ��ı���һ��ֻ�ܿ���һ��</t><b/>" @
			$Get_Dialog_GeShi[80004] @ "С��ʾ���������������ڣ���������սʧ��</t></t>";

		case 600000027: return $Icon[10] @ $Get_Dialog_GeShi[80002] @ "��ս������������</t>";
		case 600000028:
			%Act = getact(%player,4016,1) * 1;
			if (%Act <= 10)
				return $Icon[5] @ "<t>������ս����ǰ��" @ %act @ "�أ�</t>";
			else
				return $Icon[5] @ "<t>�Ѿ�ͨ��</t>";

		case 600000029:
			return $Get_Dialog_GeShi[80002] @ /*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
				$Get_Dialog_GeShi[80000] @ "������������</t>" @
				$Get_Dialog_GeShi[80001] @ "������ʱ�䣺</t><t>�ܶ����ġ���" @ " </t>" @ $Get_Dialog_GeShi[80003] @ "20:00-20:05" @ " </t><b/>" @
				$Get_Dialog_GeShi[80001] @ "����ս�ȼ���</t><t>40��</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "����ս������</t><t>����</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "������������</t><t>�������飬������</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "���������</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "1��ֻ�����˽���</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "2���ø���Ϊ�ƶ��ͼ�������ƶ��޳ͷ�</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "3����ս���ڼ�ֵ�Խ�ã�����Խ�ḻ</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "4��ս���������죬ֻ������սһ��</t><b/>" @
				$Get_Dialog_GeShi[80004] @ "С��ʾ���������޷���������</t></t>";
		case 600000030: return $Icon[10] @ $Get_Dialog_GeShi[80002] @ "���롺����������</t>";
		case 600000031: return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "��ȡ����</t>";
		case 600000032: return $Icon[38] @ $Get_Dialog_GeShi[80006] @ "<t>̫���ˣ��㻹�Ƕ��ٻ�Щ����ɣ�</t>";
		case 600000033: return $Get_Dialog_GeShi[80002] @ "<t>������������һ��������Щα���ӻᱻ����ɱ�⣡</t>";

		case 600000034: return $Get_Dialog_GeShi[80002] @ "<t>ǰ����ɽѩ�� ���壺���Ͻ�</t>";
		case 600000035: return $Get_Dialog_GeShi[80002] @ "<t>ǰ����ɽѩ�� ���壺���½�</t>";
		case 600000036: return $Get_Dialog_GeShi[80002] @ "<t>ǰ����ɽѩ�� ���壺���Ͻ�</t>";

		case 600000037: return $Icon[38] @ $Get_Dialog_GeShi[80006] @ "<t>����ĳ��������ɣ�</t>";
		case 600000038: return $Get_Dialog_GeShi[80002] @ "<t>�����������࣡��</t>";
			//-------------------Ѻ�ڻ----------------
		case 600000039: return "<t>Ѻ�ڻ��δ��ʼ���������ˡ�</t>";
		case 600000040:	 //Ѻ�ڻ����
			return $Get_Dialog_GeShi[80002] @ /*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
				$Get_Dialog_GeShi[80000] @ "��Ѻ�ڡ�</t>" @
				$Get_Dialog_GeShi[80001] @ "������ʱ�䣺</t><t>12:00-22:00 </t><b/>" @
				$Get_Dialog_GeShi[80001] @ "����Ҫ�ȼ���</t><t>50��</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "���������</t><t>������Ǯ</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "���������</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "1��Ѻ����ɫƷ��Խ�ߵ��ڳ�������Խ���</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "2��Ѻ����ɺ󣬸�������Ѻ���ý���</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "3������;�����ܡ��뿪��ħ�ǣ�ʧȥ�ڳ�</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "4�����������ߣ������ң������߻��������ڳ�</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "5��������ڳ����Լ���Ѻ�ͻ�ý���</t>";
		case 600000041:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "Ѻ���ڳ���Ѻ��</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "��</t>";
		case 600000042:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "Ѻ���ڳ���Ѻ��</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "��</t>";
		case 600000043:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "Ѻ���ڳ���Ѻ��</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "��</t>";

		case 600000044:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "Ѻ���ڳ���Ѻ��</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "��</t>";
		case 600000045:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "Ѻ���ڳ���Ѻ��</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "��</t>";
		case 600000046:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "Ѻ���ڳ���Ѻ��</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "��</t>";

		case 600000047:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "Ѻ���ڳ���Ѻ��</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "��</t>";
		case 600000048:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "Ѻ���ڳ���Ѻ��</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "��</t>";
		case 600000049:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "Ѻ���ڳ���Ѻ��</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "��</t>";

		case 600000050:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "Ѻ���ڳ���Ѻ��</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "��</t>";
		case 600000051:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "Ѻ���ڳ���Ѻ��</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "��</t>";
		case 600000052:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "Ѻ���ڳ���Ѻ��</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "��</t>";

		case 600000053:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "Ѻ���ڳ���Ѻ��</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "��</t>";
		case 600000054:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "Ѻ���ڳ���Ѻ��</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "��</t>";
		case 600000055:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "Ѻ���ڳ���Ѻ��</t>" @ ChangeMoneyText(GetWord($YaBiaoHuoDong_Gold[%DialogID],2)) @ $Get_Dialog_GeShi[80002] @ "��</t>";
			//-------------------Ѻ�ڻ----------------
			//------------------����-------------
		case 600000056:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "�һ��ƺ�[�桤��Ϫ��ͯ]</t>";
		case 600000057:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "�һ��ƺ�[�桤��Ϫ����]</t>";
		case 600000058:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "�һ��ƺ�[�桤�������]</t>";
		case 600000059:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "�һ��ƺ�[�桤�߽�����]</t>";
		case 600000060:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "�һ��ƺ�[�桤��������]</t>";
		case 600000061:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "�һ��ƺ�[�桤�ٽ�����]</t>";
		case 600000062:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "�һ��ƺ�[�桤�ٽ���]</t>";
		case 600000063:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "�һ��ƺ�[�桤������]</t>";
		case 600000064:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "�һ��ƺ�[�桤��ʿ]</t>";
		case 600000065:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "�һ��ƺ�[�桤����]</t>";

		case 600000066:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "�Ͻ�[��ǹ��]</t>";
		case 600000067:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "�Ͻ�[����]</t>";
		case 600000068:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "�Ͻ�[����]</t>";
		case 600000069:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "�Ͻ�[������]</t>";
		case 600000070:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "�Ͻ�[��������]</t>";

		case 600000071:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "�һ����</t>";
			//---------------------�������--------------------------------
		case 600000072:return $Get_Dialog_GeShi[80002] @ "<t>��ʹ�ô˵���ǰ��</t>" @ "<l i='" @ "810100100 32.0509 57.8391 137.561' t='path'/>" @ $Get_Dialog_GeShi[80002] @ "������Ѱ�Ҵ������϶һ������ɾ���ʱ��</t>";
		case 600000073:	 //Ѻ�ڻ����
			return $Get_Dialog_GeShi[80002] @ /*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
				$Get_Dialog_GeShi[80000] @ "�����������</t>" @
				$Get_Dialog_GeShi[80001] @ "������ʱ�䣺</t>" @ $Get_Dialog_GeShi[80003] @ "00:00-21:00 21:30-23:59 </t><b/>" @
				$Get_Dialog_GeShi[80001] @ "����Ҫ�ȼ���</t><t>30��</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "���������</t><t>��������</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "���������</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "1�������������������������״̬��ÿ��10����һ�ξ���</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "2�����������ɾ������������״̬��ÿ��5����һ�ξ���</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "3�����������ɾ��������Ͻɡ����ơ�</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "4��ÿ�顾���ơ��ɶһ�һСʱ�����ɾ���ʱ�䣬ÿ��ÿ���޶һ�3��</t><b/>" @
				$Get_Dialog_GeShi[80004] @ "С��ʾ���������ɾ����ܹ�ֻ��8������������ͯ�Ӵ���ʹ��Ԫ�����Ԫ����������ƣ�</t>";
		case 600000074:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "�һ������ɾ�ʱ��</t>";
		case 600000075:return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "����Ԫ�����</t>";
		case 600000076:	 //Ѻ�ڻ����
			return $Get_Dialog_GeShi[80002] @ /*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
				$Get_Dialog_GeShi[80000] @ "��Ԫ�������</t>" @
				$Get_Dialog_GeShi[80001] @ "���������</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "1��ʹ�á����ơ��һ�ʱ��󣬿��ڴ˴�����Ԫ�����</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "2��Ԫ����������ܲ����ɾ���8������</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "3��Ԫ�����������ǰ�������ͼ�����������ǲ�������</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "4������Ԫ�������Ҫ�۳�һ��������Ԫ�������ݵ�ǰ�����ʱ�����</t>";
			//-----------------------------�����۾�--------------
		case 600000077:
			return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "��ȡ���۾�������</t>";
		case 600000078:
			%Act0 = GetAct(GetPlayer(),4024,0) * 1;
			%Act1 = GetAct(GetPlayer(),4024,1) * 1;
			if (%Act0  + %Act1 > 0)
				return
				$Get_Dialog_GeShi[31401] @ "�����ܹ���������</t>" @ $Get_Dialog_GeShi[31403] @  %Act0 + %Act1 @ "</t><b/>" @
				$Get_Dialog_GeShi[31401] @ "���д�Ե�������</t>" @ $Get_Dialog_GeShi[31403] @  %Act0 @ "</t>";
			else
				return "<t>������ȡ����������δ�μӻ��</t>";
		case 600000079:
			return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "��ȡ����</t>";
			//------------------------�����۾�-----------------
			//------------------------��������-----------------
		case 600000080://�������
			if (GetSrc(GetPlayer(),40) == 0) %Text[1] = "<t>����֮�꣺��ǰ 0/1 ��</t><b/>"; else %Text[1] = "<t>����֮�꣺</t>" @ $Get_Dialog_GeShi[31403] @ "�����</t><b/>";
			if (GetSrc(GetPlayer(),41) == 0) %Text[2] = "<t>�һ�֮�ף���ǰ 0/1 ��</t><b/>"; else %Text[2] = "<t>�һ�֮�ף�</t>" @ $Get_Dialog_GeShi[31403] @ "�����</t><b/>";
			if (GetSrc(GetPlayer(),42) == 0) %Text[3] = "<t>�����������ǰ 0/1 ��</t><b/>"; else %Text[3] = "<t>���������</t>" @ $Get_Dialog_GeShi[31403] @ "�����</t><b/>";
			if (GetSrc(GetPlayer(),43) == 0) %Text[4] = "<t>������������ǰ 0/1 ��</t><b/>"; else %Text[4] = "<t>����������</t>" @ $Get_Dialog_GeShi[31403] @ "�����</t><b/>";
			%Num = 0;
			for (%s = 44; %s <=48; %s++)
			{
				if (GetSrc(GetPlayer(),%s) == 1)
					%Num++;
			}
			if (%Num < 5)
				%Text[5] = "<t>��װ��ҩ����ǰ </t>" @ %Num @ "<t>/5 ��</t><b/>";
			else
				%Text[5] = "<t>��װ��ҩ��</t>" @ $Get_Dialog_GeShi[31403] @ "�����</t><b/>";

			%Num = 0;
			for (%s = 50; %s <=54; %s++)
			{
				if (GetSrc(GetPlayer(),%s) == 1)
					%Num++;
			}
			if (%Num < 5)
				%Text[6] = "<t>����֮�飺��ǰ </t>" @ %Num @ "<t>/5 ��</t><b/>";
			else
				%Text[6] = "<t>����֮�飺</t>" @ $Get_Dialog_GeShi[31403] @ "�����</t><b/>";
			if (GetSrc(GetPlayer(),56) == 0) %Text[7] = "<t>������ħ����ǰ 0/1 ��</t>"; else %Text[7] = "<t>������ħ��</t>" @ $Get_Dialog_GeShi[31403] @ "�����</t>";
			%Txt = $Get_Dialog_GeShi[31426] @ "��������������ɶ�</t><b/>";
			for (%i = 1; %i <= 7; %i++)
			{
				%Txt = %Txt @ "<t> �� </t>" @ %Text[%i];
			}
			return %Txt;
		case 600000081:return $Icon[19] @ $Get_Dialog_GeShi[31496] @ "ÿ��-[" @ getplayer().getlevel() @ "] ����֮�꣨���ܣ�</t>";
		case 600000082:return $Icon[19] @ $Get_Dialog_GeShi[31496] @ "ÿ��-[" @ getplayer().getlevel() @ "] �һ�֮�ף����ܣ�</t>";
		case 600000083:return $Icon[19] @ $Get_Dialog_GeShi[31496] @ "ÿ��-[" @ getplayer().getlevel() @ "] ������������ܣ�</t>";
		case 600000084:return $Icon[19] @ $Get_Dialog_GeShi[31496] @ "ÿ��-[" @ getplayer().getlevel() @ "] �������������ܣ�</t>";
		case 600000085:return $Icon[19] @ $Get_Dialog_GeShi[31496] @ "ÿ��-[" @ getplayer().getlevel() @ "] ��װ��ҩ�����ܣ�</t>";
		case 600000086:return $Icon[19] @ $Get_Dialog_GeShi[31496] @ "ÿ��-[" @ getplayer().getlevel() @ "] ����֮�飨���ܣ�</t>";
		case 600000087:return $Icon[19] @ $Get_Dialog_GeShi[31496] @ "ÿ��-[" @ getplayer().getlevel() @ "] ������ħ�����ܣ�</t>";
			//------------------------��������-----------------
			//-----------------------�ǻ�Ի�------------------
		case 600000088:
			%Act0 = GetAct(GetPlayer(),4091,0) * 1;
			%Act1 = GetAct(GetPlayer(),4091,1) * 1;
			switch (%Act0)
			{
				case 0:	%BenMing = $Get_Dialog_GeShi[31401] @ "��ɫ������</t>";
				case 1:	%BenMing = $Get_Dialog_GeShi[31401] @ "��ɫ������</t>";
				case 2:	%BenMing = $Get_Dialog_GeShi[31403] @ "��ɫ������</t>";
				case 3:	%BenMing = $Get_Dialog_GeShi[31402] @ "��ɫ������</t>";
				case 4:	%BenMing = $Get_Dialog_GeShi[31409] @ "��ɫ������</t>";
				case 5:	%BenMing = $Get_Dialog_GeShi[31421] @ "��ɫ������</t>";
			}
			return
				$Get_Dialog_GeShi[31401] @ "��ǰ�����ǣ�</t>" @ $Get_Dialog_GeShi[31403] @  %BenMing @ "</t><b/>" @
				$Get_Dialog_GeShi[31401] @ "��������ʱ���Ѻ��н���ø߶��ӳ�</t><b/>" @
				$Get_Dialog_GeShi[31401] @ "ÿ�����ʱ���Ѻ�ʱ���ˢ��һ���Ǽ�</t><b/>" @
				$Get_Dialog_GeShi[31401] @ "��ɫ</t>" @ "<t>�Ǽ���1������ӳ�</t><b/>" @
				$Get_Dialog_GeShi[31403] @ "��ɫ</t>" @ "<t>�Ǽ���2������ӳ�</t><b/>" @
				$Get_Dialog_GeShi[31402] @ "��ɫ</t>" @ "<t>�Ǽ���3������ӳ�</t><b/>" @
				$Get_Dialog_GeShi[31409] @ "��ɫ</t>" @ "<t>�Ǽ���4������ӳ�</t><b/>" @
				$Get_Dialog_GeShi[31421] @ "��ɫ</t>" @ "<t>�Ǽ���5������ӳ�</t>";
		case 600000089:
			return $Icon[5] @ "<t>���������ǻ�</t>";
		case 600000090:
			%Act1 = GetAct(%Player,4091,1);
			switch (%Act1)
			{
				case 0:	%BenMing = $Get_Dialog_GeShi[31401] @ "��ɫ������</t>";
				case 1:	%BenMing = $Get_Dialog_GeShi[31401] @ "��ɫ������</t>";
				case 2:	%BenMing = $Get_Dialog_GeShi[31403] @ "��ɫ������</t>";
				case 3:	%BenMing = $Get_Dialog_GeShi[31402] @ "��ɫ������</t>";
				case 4:	%BenMing = $Get_Dialog_GeShi[31409] @ "��ɫ������</t>";
				case 5:	%BenMing = $Get_Dialog_GeShi[31421] @ "��ɫ������</t>";
			}
			return $Icon[5] @ "<t>���óɽ�����߱���</t>" @ %BenMing;
			//-------------------------------------------------
			//-------------------------Ѫħ��ӡ��--------------
		case 600000091:
			return $Get_Dialog_GeShi[80002] @ /*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
				$Get_Dialog_GeShi[80000] @ "��Ѫħ��ӡ���</t>" @
				$Get_Dialog_GeShi[80001] @ "������ʱ�䣺</t><t>ȫ�� </t><b/>" @
				$Get_Dialog_GeShi[80001] @ "����Ҫ�ȼ���</t><t>30��</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "������������</t><t>6 ��</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "���������</t><t>��������</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "���������</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "1��ÿ��ÿ��ɲ���һ��</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "2������һ����6����ǰ�岨Ϊ20ֻ��Ӣ�ּ�1ֻ��Ӣͳ��,������Ϊ����ؿ�</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "3�����������󣬹��ﴦ�ڷ�ӡ״̬,ÿ���15�룬������һֻ��������ӡ</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "4�������ӡ״̬�Ĺ�����ܺ������100%���齱��</t><b/>" @
				$Get_Dialog_GeShi[80004] @ "С��ʾ������ѡ����ǰ�����ӡ����Լʱ��Ŷ��</t>";
		case 600000092:
			return $Icon[10] @ $Get_Dialog_GeShi[80002] @ "���븱��</t>";
		case 600000093:
			return $Icon[5] @ $Get_Dialog_GeShi[80002] @ "��������</t>";
		case 600000094:
			return "<t>�Ƿ��ܹ��˵ȴ��Ĺ��̣�����ѡ�����Ұ�����ǰ�⿪��������ķ�ӡ�������ӡ��Ĺ�����ܵľ��齱��������ÿ�ν����Ҫ</t>" @ $Get_Dialog_GeShi[31403] @ "200</t>" @ "<t>Ԫ��</t>";
		case 600000095:
			return $Icon[5] @ "<t>�����ӡ</t>";
		case 600000096:
			return "<t>���ν����Ҫ</t>" @ $Get_Dialog_GeShi[31403] @ "200</t>" @ "<t>Ԫ�����Ƿ�ȷ�����</t>";
		case 600000097:
			return $Icon[5] @ "<t>ȷ��</t>";
			//-------------------------------------------------
			//-----------------------------�ƽ𱦲�-------------------
		case 600000098:
			return $Get_Dialog_GeShi[80002] @ /*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
				$Get_Dialog_GeShi[80000] @ "���ƽ𱦲ء�</t>" @
				$Get_Dialog_GeShi[80001] @ "������ʱ�䣺</t><t>ȫ�� </t><b/>" @
				$Get_Dialog_GeShi[80001] @ "����Ҫ�ȼ���</t><t>35��</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "������������</t><t>����</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "���������</t><t>�������</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "���������</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "1��ÿ�ν��뱦����Ҫһö</t>" @ "<l i='105109341 ' t='itemid'/>" @ "<b/>" @
				$Get_Dialog_GeShi[80002] @ "2������ϵͳ��ʾ�����Ӧ�Ĵ�����</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "3��������һ��4����ս��ÿ��ˢ��20��</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "4��ÿ�����ﶼ�����������</t><b/>" @
				$Get_Dialog_GeShi[80004] @ "С��ʾ1�����̤�����ţ���������ɱ�����θ�����ʧ�ܣ�</t><b/>" @
				$Get_Dialog_GeShi[80004] @ "С��ʾ2���ƽ𱦲صĹ��Ｋ��ǿ�󣬽�����һ���ܣ�</t>";
		case 600000099:
			return $Icon[10] @ "<t>���븱��</t>";

			//-------------------------------------------------
			//-----------------------------��������-------------------
		case 600000100:
			return $Get_Dialog_GeShi[80002] @ /*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
				$Get_Dialog_GeShi[80000] @ "�����������</t>" @
				$Get_Dialog_GeShi[80001] @ "������ʱ�䣺</t>" @ $Get_Dialog_GeShi[80003] @ "21:00 </t><b/>" @
				$Get_Dialog_GeShi[80001] @ "����Ҫ�ȼ���</t><t>50��</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "������������</t><t>����</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "���������</t><t>��������</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "���������</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "1�����������ڣ���������Ӫ����������</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "2�����븱��������������һ����Ӫ</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "3�����10���������񣬿ɻ�þ��齱��</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "4�����ܵж���Ӫ����þ��齱��</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "5��ս������ʱ��������ÿ���˵�ս��ʱ���ͻ���ս�����轱��</t><b/>" @
				$Get_Dialog_GeShi[80004] @ "С��ʾ����ǰ�˳�ս�����޷�������Ľ���</t>";
		case 600000101:
			return $Icon[10] @ "<t>���븱��</t>";
			//-------------------------------------------------
			//-----------------------------�����̵�-------------------
		case 600000102:
			%Text = "<t>�ھ�</t>" @ $Get_Dialog_GeShi[31421] @ " ��ʯ����</t>" @ "<t>��ÿ�οɻ��</t>" @ GetItemName(GetOne_HeZuiChu_ZaKuang(getplayer(),1),1) @ "<t>һ��������60%���ʶ�����</t>" @ GetItemName(105109001,1) @ "<t>����ϧ���ߣ�����</t>" @ GetItemName(105109001,1) @ "<t>�л�����������ϧ��Ʒ��</t><b/>";
			%Player.ClearMissionItem(10050);
			%Player.AddItemToMission(10050,1,113050002,1);
			%Player.AddItemToMission(10050,1,105090503,1);
			%Player.AddItemToMission(10050,1,105090603,1);
			%Player.AddItemToMission(10050,1,105109031,1);
			%Player.AddItemToMission(10050,1,105109061,1);
			%Player.AddItemToMission(10050,1,116060105,1);
			%Player.AddItemToMission(10050,1,116060106,1);
			%Player.AddItemToMission(10050,1,116060107,1);
			%Player.AddItemToMission(10050,1,116060108,1);
			%Player.AddItemToMission(10050,1,116080005,1);
			%Player.AddItemToMission(10050,1,116080006,1);
			%Player.AddItemToMission(10050,1,116080007,1);
			%Player.AddItemToMission(10050,1,116080008,1);
			%Player.AddItemToMission(10050,1,116060002,1);
			%Player.AddItemToMission(10050,1,105028011,1);
			return $Get_Dialog_GeShi[80002] @ %Text @ "</t>" @ GetFixedMissionItemText(10050);
		case 600000103:
			%Text = "<t>�ھ�</t>" @ $Get_Dialog_GeShi[31421] @ " ��ʯ����</t>" @ "<t>��ÿ�οɻ��</t>" @ GetItemName(GetOne_HeZuiChu_KuangDing(getplayer(),1),1) @ "<t>һ��������60%���ʶ�����</t>" @ GetItemName(105109021,1) @ "<t>����ϧ���ߣ�����</t>" @ GetItemName(105109021,1) @ "<t>�л�����������ϧ��Ʒ��</t><b/>";
			%Player.ClearMissionItem(10050);
			%Player.AddItemToMission(10050,1,116060107,1);
			%Player.AddItemToMission(10050,1,116060108,1);
			%Player.AddItemToMission(10050,1,116060109,1);
			%Player.AddItemToMission(10050,1,116060110,1);
			%Player.AddItemToMission(10050,1,116080007,1);
			%Player.AddItemToMission(10050,1,116080008,1);
			%Player.AddItemToMission(10050,1,116080009,1);
			%Player.AddItemToMission(10050,1,116080010,1);
			%Player.AddItemToMission(10050,1,116060003,1);
			%Player.AddItemToMission(10050,1,116070002,1);
			%Player.AddItemToMission(10050,1,105105514,1);
			%Player.AddItemToMission(10050,1,105105524,1);
			%Player.AddItemToMission(10050,1,105290025,1);
			%Player.AddItemToMission(10050,1,105290035,1);
			%Player.AddItemToMission(10050,1,105180072,1);
			%Player.AddItemToMission(10050,1,105180092,1);
			%Player.AddItemToMission(10050,1,105180152,1);
			%Player.AddItemToMission(10050,1,105180073,1);
			%Player.AddItemToMission(10050,1,105180093,1);
			%Player.AddItemToMission(10050,1,105180153,1);
			%Player.AddItemToMission(10050,1,105180074,1);
			%Player.AddItemToMission(10050,1,105180094,1);
			%Player.AddItemToMission(10050,1,105180154,1);
			%Player.AddItemToMission(10050,1,105105304,1);
			%Player.AddItemToMission(10050,1,105105305,1);
			%Player.AddItemToMission(10050,1,105028021,1);

			return $Get_Dialog_GeShi[80002] @ %Text @ "</t>" @ GetFixedMissionItemText(10050);
			//-----------------------------�����̵�-------------------
			//-----------------------------���޾�-------------------
		case 600000104:
			if (getplayer().GetOrgID() > 0)
				return $Icon[10] @  "<t>�������޾������ɸ�����</t>";
			else
				return $Icon[10] @ $Get_Dialog_GeShi[31407] @ "<t>�������޾������ɸ�����</t>";
		case 600000105:
			return $Get_Dialog_GeShi[80002] @ /*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
				$Get_Dialog_GeShi[80000] @ "�����޾���</t>" @
				$Get_Dialog_GeShi[80001] @ "������������</t><t>���ɼ������</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "���������</t><t>�������顢��ϧ����</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "���������</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "1���ɰ��������ٻ�</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "2��ͬһ������ֻ��ÿ��ÿ��ֻ�ܻ�ȡһ��</t><b/>" @
				$Get_Dialog_GeShi[80004] @ "С��ʾ���Ƽ����Ȼ������һ��������ϣ��ɽ������޽�������ս�Ѷȡ�</t>";
		case 600000106:
			if (getplayer().GetOrgMemberLevel(1) < 6)
				return $Icon[5] @ $Get_Dialog_GeShi[31407] @ "<t>�ٻ������޽�����</t>";
			else
				return $Icon[5]  @ "<t>�ٻ������޽�����</t>";
		case 600000107:
			return $Get_Dialog_GeShi[80002] @ /*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
				$Get_Dialog_GeShi[80000] @ "����˵����</t>";
		case 600000108:
			return $Icon[5]  @ "<t>�ٻ���ˢ�±�����</t>";
			//-----------------------------���޾�-------------------
		
		//����
		case 600000110:
			%NeedYB2 = SpecialItem_DaoJing_GetYuanBaoExpend(%Player, 2);
			%NeedYB3 = SpecialItem_DaoJing_GetYuanBaoExpend(%Player, 3);
			return $Get_Dialog_GeShi[80002] @ /*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
				$Get_Dialog_GeShi[80000] @ "��������</t>" @
				$Get_Dialog_GeShi[80001] @ "�����ʹ�õ���:</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "<t>ÿ</t>"@ $Get_Dialog_GeShi[80006] @"6Сʱ</t><t>ʹ��һ�Σ��л��ʻ��</t>"@ $Get_Dialog_GeShi[80006] @"˫��</t><t>���顣</t><b/>"@
				$Get_Dialog_GeShi[80001] @ "����������Ԫ��ʹ�õ���:</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "<t>ÿ��</t>"@ $Get_Dialog_GeShi[80006] @"��һ��</t><t>ʹ������</t>"@ $Get_Dialog_GeShi[80006] @%NeedYB2@ "</t><t>Ԫ�����л��ʻ��</t>"@ $Get_Dialog_GeShi[80006] @"˫��</t><t>���飬ʹ�ô���Խ�����ĵ�Ԫ��Խ�࣬ÿ��</t>"@ $Get_Dialog_GeShi[80006] @"0��</t><t>���ô�����</t><b/>"@
				$Get_Dialog_GeShi[80001] @ "�����Ѵ���Ԫ��ʹ�õ���:</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "<t>ÿ��</t>"@ $Get_Dialog_GeShi[80006] @"��һ��</t><t>ʹ������</t>"@ $Get_Dialog_GeShi[80006] @%NeedYB3@ "</t><t>Ԫ������Ȼ���</t>"@ $Get_Dialog_GeShi[80006] @"˫��</t><t>���飬ʹ�ô���Խ�����ĵ�Ԫ��Խ�࣬ÿ��</t>"@ $Get_Dialog_GeShi[80006] @"0��</t><t>���ô�����</t><b/>"@
				$Get_Dialog_GeShi[80001] @ "�������Ѹ���ʹ��: </t>" @
				$Get_Dialog_GeShi[80002] @ GetAct(%Player,4300,0)*1 @"��</t>";
				
		
		case 600000111: return $Icon[5]  @ "<t>���ʹ��</t>"@ $Get_Dialog_GeShi[80006] @"(ÿ6Сʱһ��)</t>";
		case 600000112: return $Icon[5]  @ "<t>����"@ SpecialItem_DaoJing_GetYuanBaoExpend(%Player, 2) @"Ԫ��ʹ��</t>"@ $Get_Dialog_GeShi[80006] @"(���ʷ���)</t>";
		case 600000113: return $Icon[5]  @ "<t>����"@ SpecialItem_DaoJing_GetYuanBaoExpend(%Player, 3) @"Ԫ��ʹ��</t>"@ $Get_Dialog_GeShi[80006] @"(��Ȼ����)</t>";
		case 600000114:return "<t>�������������ѹرգ�����ʱ�����ע��Ϸ���¹��档</t>";
		case 600000115:return "<t>��������ÿ6Сʱֻ�����ʹ��һ�Ρ�</t>";
		case 600000116:return "<t>���Ԫ�����㣬�޷�����ʹ�á�������</t>";
		case 600000117:return "<t>����ʹ�á���������ÿ�����ʹ��20�Σ�������������ðɣ�</t>";

			//-----------------------------�����ؾ�-------------------
		case 600000118:
			return $Get_Dialog_GeShi[80002] @ /*Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�*/
				$Get_Dialog_GeShi[80000] @ "�������ؾ���</t>" @
				$Get_Dialog_GeShi[80001] @ "������ʱ�䣺</t><t>ȫ�� </t><b/>" @
				$Get_Dialog_GeShi[80001] @ "����Ҫ�ȼ���</t><t>35��</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "������������</t><t>3������</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "���������</t><t>��ɫװ��</t><b/>" @
				$Get_Dialog_GeShi[80001] @ "���������</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "1��ÿ��ÿ��ɽ���һ��</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "2���������������м��ʵ�����ɫװ��</t><b/>" @
				$Get_Dialog_GeShi[80002] @ "3����Ӣ������伸�ʷ������������ض�������ɫװ��</t><b/>" @
				$Get_Dialog_GeShi[80004] @ "С��ʾ1������װ���ĵȼ���Ӧ�������ƽ���ȼ���</t><b/>" @
				$Get_Dialog_GeShi[80004] @ "С��ʾ2�����ɳ�Ա��һ�������������100����ɻ�Ծ��</t>";
		case 600000119:
			return $Icon[5]  @ "<t>������ս</t>";
		case 600000120:
			return $Icon[5]  @ "<t>��ս�ؾ�</t>";
			//--------------------------------------------------------
		
	}
}
function showGodStoneInvariantInfo()
{
	%color= "<t m='1' f='����' n='14' c='0xffffffff' b='0'>";
	%str  = %color @ "�컯��ʯ�ϳ�˵����</t><b/>";
	%str  = %str @ %color @"1.ͬ�ȼ����컯��ʯ�ɺϳɸ���һ������ʯ��</t><b/>";
	%str  = %str @ %color @"2.��ԵֵԽ�ߣ��ϳɵĳɹ��ʾ�Խ�ߡ�</t><b/>";
	%str  = %str @ %color @"3.ʹ������컯��ʯ�ϳɣ��ɹ���100%��</t><b/>";
	%str  = %str @ %color @"4.����5�����컯��ʯ�޷����ںϳɡ�</t>";
	KLJGodStoneGui_TipsInfo.setcontent(%str);
}

