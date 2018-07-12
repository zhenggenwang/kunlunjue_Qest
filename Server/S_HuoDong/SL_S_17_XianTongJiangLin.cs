//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//仙童降临
//
//
//
//==================================================================================

//■■■■【仙童降临】■■■■【活动开启】■■■■■■
//■■■■【仙童降临】■■■■【刷新宝箱】■■■■■■
//■■■■【仙童降临】■■■■【采集触发】■■■■■■



//■■■■【仙童降临】■■■■【活动开启】■■■■■■
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
//■■■■【仙童降临】■■■■【活动开启】■■■■■■


//■■■■【仙童降临】■■■■【刷新宝箱】■■■■■■

function CreateXianTongJiangLinBaoXiang(%Optype)
{
	CanCel($CreateXianTongJiangLinBaoXiang);
	%MapID = GetZoneid();
	//echo("%Optype=========仙童降临================" @ %Optype);
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
			%HuoDongMingCheng0 = GetHuoDongName("天赐宝藏",1);
			%HuoDongMingCheng1 = GetHuoDongName("天赐宝藏",2);

			%Text0 ="<t>新服狂欢，</t>" @ %NpcName0 @ "<t>一分钟后将在</t>" @ %MapName0 @ "<t>撒下</t>" @ %HuoDongMingCheng0 @ "<t>，无数奇珍异宝静等众修士前来开启。</t>";
			%Text1 ="<t>新服狂欢，</t>" @ %NpcName1 @ "<t>一分钟后将在</t>" @ %MapName1 @ "<t>撒下</t>" @ %HuoDongMingCheng1 @ "<t>，无数奇珍异宝静等众修士前来开启。</t>";
			SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text0 @ "</t>");
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text1 @ "</t>", $chatMsg_Type_Normal2);

			$CreateXianTongJiangLinBaoXiang = Schedule(60 * 1000,0,"CreateXianTongJiangLinBaoXiang",1);

		default:
			if (!isobject($XianTongJiangLinNpc))
				return;
			if (%Optype > 3)
			{

				%Text ="<t>仙童前往昆仑灵脉采集灵物，将在25分钟后再次降临给大家带来祥瑞福礼！</t>";
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
			%HuoDongMingCheng0 = GetHuoDongName("天赐宝藏",1);
			%HuoDongMingCheng1 = GetHuoDongName("天赐宝藏",2);

			%Text0 ="<t>新服狂欢，</t>" @ %NpcName0 @ "<t>在</t>" @ %MapName0 @ "<t>撒下一大片</t>" @ %HuoDongMingCheng0 @ "<t>，无数奇珍异宝静等众修士前来开启。</t>";
			%Text1 ="<t>新服狂欢，</t>" @ %NpcName1 @ "<t>在</t>" @ %MapName1 @ "<t>撒下一大片</t>" @ %HuoDongMingCheng1 @ "<t>，无数奇珍异宝静等众修士前来开启。</t>";
			SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text0 @ "</t>");
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text1 @ "</t>", $chatMsg_Type_Normal2);

			%Optype = %Optype + 1;
			$CreateXianTongJiangLinBaoXiang = Schedule(120 * 1000,0,"CreateXianTongJiangLinBaoXiang",%Optype);
	}
}
//■■■■【仙童降临】■■■■【刷新宝箱】■■■■■■


//■■■■【仙童降临】■■■■【采集触发】■■■■■■
function TriggerEvent_553000062(%Player,%Event,%EventID)
{
	%Player.SetSchbuff(2043);
	return true;
}
//■■■■【仙童降临】■■■■【采集触发】■■■■■■