//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//��ͯ����
//
//
//
//==================================================================================

//������������ͯ���١������������������������������
//������������ͯ���١�����������ˢ�±��䡿������������
//������������ͯ���١������������ɼ�������������������



//������������ͯ���١������������������������������
function XianTongJiangLin(%YY,%MM,%DD,%H,%M,%S)
{
	if ($SL_XianTongJiangLin_State_bActive != 1)
		return;
	if (%H < 14)
		return;
	if (%H > 21)
		return;
	if (GetZoneID() != 1001)
		return;
	if (%M == 01 || %M == 31)
	{
		%Ran = GetRandom(1100,1103);
		if (%Ran == 1100)
			%Ran = 1001;
		SptInterMapExecute(%Ran,"CreateXianTongJiangLinBaoXiang(0);");
	}
}
//������������ͯ���١������������������������������


//������������ͯ���١�����������ˢ�±��䡿������������

function CreateXianTongJiangLinBaoXiang(%Optype)
{
	CanCel($CreateXianTongJiangLinBaoXiang);
	%MapID = GetZoneid();
	//echo("%Optype=========��ͯ����================" @ %Optype);
	switch (%Optype)
	{
		case 0:
			if (isobject($XianTongJiangLinNpc))
				return;
			//$XianTongJiangLinNpc.safedeleteobject();
			%Pos = GetRandomPosForMap(1);
			$XianTongJiangLinNpc = SpNewNpc2(0,440000020,%Pos,0,0);

			%NpcName0 = GetNpcZiTiName($XianTongJiangLinNpc,1);
			%NpcName1 = GetNpcZiTiName($XianTongJiangLinNpc,2);

			%MapName0 = "<l i=' 8" @ %MapID @ "0100 " @ %Pos @ "' t='path'/>";
			%MapName1 = $Get_Dialog_GeShi[60003] @ GetTriggerData("8" @ %MapID @ "0100",3) @ "</t>";

			//echo("MapName0=====" @ %MapName0);
			%HuoDongMingCheng0 = GetHuoDongName("��ͱ���",1);
			%HuoDongMingCheng1 = GetHuoDongName("��ͱ���",2);

			%Text0 ="<t>�·��񻶣�</t>" @ %NpcName0 @ "<t>һ���Ӻ���</t>" @ %MapName0 @ "<t>����</t>" @ %HuoDongMingCheng0 @ "<t>�����������챦��������ʿǰ��������</t>";
			%Text1 ="<t>�·��񻶣�</t>" @ %NpcName1 @ "<t>һ���Ӻ���</t>" @ %MapName1 @ "<t>����</t>" @ %HuoDongMingCheng1 @ "<t>�����������챦��������ʿǰ��������</t>";
			SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text0 @ "</t>");
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text1 @ "</t>", $chatMsg_Type_Normal2);

			$CreateXianTongJiangLinBaoXiang = Schedule(60 * 1000,0,"CreateXianTongJiangLinBaoXiang",1);

		default:
			if (!isobject($XianTongJiangLinNpc))
				return;
			if (%Optype > 3)
			{

				%Text ="<t>��ͯǰ�����������ɼ��������25���Ӻ��ٴν��ٸ���Ҵ���������</t>";
				SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");
				SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text @ "</t>", $chatMsg_Type_Normal2);
				$XianTongJiangLinNpc.Safedeleteobject();
				return;
			}

			%PosX = GetWord($XianTongJiangLinNpc.GetPoSition(),0);
			%PosY = GetWord($XianTongJiangLinNpc.GetPoSition(),1);
			for (%i = 1;%i <= 15;%i++)
			{
				%Pos = GetNavPos(%PosX,%PosY,30);
				if (%Pos $= "0 0 0" || %Pos$= "")
					%Pos = $XianTongJiangLinNpc.GetPoSition();
				SpNewCj(0,553000062,%Pos,"1 0 0 0","1 1 1");
			}
			%NpcName0 = GetNpcZiTiName($XianTongJiangLinNpc,1);
			%NpcName1 = GetNpcZiTiName($XianTongJiangLinNpc,2);

			%MapName0 = "<l i=' 8" @ %MapID @ "0100 " @ %Pos @ "' t='path'/>";
			%MapName1 = $Get_Dialog_GeShi[60003] @ GetTriggerData("8" @ %MapID @ "0100",3) @ "</t>";

			//echo("MapName0=====" @ %MapName0);
			%HuoDongMingCheng0 = GetHuoDongName("��ͱ���",1);
			%HuoDongMingCheng1 = GetHuoDongName("��ͱ���",2);

			%Text0 ="<t>�·��񻶣�</t>" @ %NpcName0 @ "<t>��</t>" @ %MapName0 @ "<t>����һ��Ƭ</t>" @ %HuoDongMingCheng0 @ "<t>�����������챦��������ʿǰ��������</t>";
			%Text1 ="<t>�·��񻶣�</t>" @ %NpcName1 @ "<t>��</t>" @ %MapName1 @ "<t>����һ��Ƭ</t>" @ %HuoDongMingCheng1 @ "<t>�����������챦��������ʿǰ��������</t>";
			SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text0 @ "</t>");
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text1 @ "</t>", $chatMsg_Type_Normal2);

			%Optype = %Optype + 1;
			$CreateXianTongJiangLinBaoXiang = Schedule(120 * 1000,0,"CreateXianTongJiangLinBaoXiang",%Optype);
	}
}
//������������ͯ���١�����������ˢ�±��䡿������������


//������������ͯ���١������������ɼ�������������������
function TriggerEvent_553000062(%Player,%Event,%EventID)
{
	%Player.SetSchbuff(2043);
	return true;
}
//������������ͯ���١������������ɼ�������������������