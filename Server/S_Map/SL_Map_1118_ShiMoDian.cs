//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//
//镇魔殿
//==================================================================================
//411180001	尸卫
//411180002	尸王 技能书
//411180003	尸王 材料
//411180004	尸王 假的
//411181001	传送门

//■■■■【镇魔殿】■■■■【尸卫死亡】■■■■■■
//■■■■【镇魔殿】■■■■【传送对话】■■■■■■
//■■■■【镇魔殿】■■■■【尸王刷新】■■■■■■
//■■■■【镇魔殿】■■■■【尸王死亡】■■■■■■



//■■■■【镇魔殿】■■■■【尸卫死亡】■■■■■■
function KilledMonster_411180001(%Player,%Monster,%SharePlayerNum,%MaxConnection)
{
	if (%Monster.Record == 1)
		return;
	if ($SL_ShiMoDian_bActive != 1)
		return;
	//echo( "尸卫死亡=====" );
	%Pos = %Monster.GetPosition();

	%HuoDongMingCheng1 = GetHuoDongName("镇魔殿传送门",1);
	%HuoDongMingCheng2 = GetHuoDongName("镇魔殿传送门",2);

	%NpcName1 = GetNpcZiTiName(%Monster.GetDataID(),1);
	%NpcName2 = GetNpcZiTiName(%Monster.GetDataID(),2);
	%MapName1 = GetMapName(%Monster,1);
	%MapName2 = GetMapName(%Monster,2);

	%Text1 = %NpcName1 @ "<t>被击败，</t>" @ %HuoDongMingCheng1 @ "<t>出现在</t>" @ %MapName1 @ "<t>。</t>";
	%Text2 = %NpcName2 @ "<t>被击败，</t>" @ %HuoDongMingCheng2 @ "<t>出现在</t>" @ %MapName2 @ "<t>。</t>";
	SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
	SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);

	SpNewNpc2(0,411181001,%Pos,%Monster.GetLayerID(),0);
	%Functionname = "SptCreateShiMoDianMonSter( );";
	SptInterMapExecute(1118,%Functionname);
	%Monster.Record = 1;
	Schedule(10000,0,"KilledMonster_411180001_A",%Monster);
}
function KilledMonster_411180001_A(%Monster)
{
	%Monster.Record = 0;
}
//■■■■【镇魔殿】■■■■【尸卫死亡】■■■■■■


//■■■■【镇魔殿】■■■■【传送对话】■■■■■■
function GotoShiMoDian_DiaLog(%Npc,%Player,%State,%Conv)
{
	%Conv.Settype(4);
	if (%Player.GetLevel() < $SL_ShiMoDian_Level)
	{
		SendOneScreenMessage(2,"您的角色低于" @ $SL_ShiMoDian_Level @ "级，无法进入镇魔殿",%Player);
		return;
	}
	AddAchievementWatch(%Player,0,38,1);//记录成就
	%Pos = $strMapRanPosRecord[1118,GetRandom(1,$strMapRanPosRecordMax[1118])];
	%Player.TransportObject(0,1118,GetWord(%Pos,0),GetWord(%Pos,1),GetWord(%Pos,2));
}

//■■■■【镇魔殿】■■■■【传送对话】■■■■■■

//■■■■【镇魔殿】■■■■【尸王刷新】■■■■■■
function SptCreateShiMoDianMonSter()
{
	%MapID = GetZoneID();
	if (%MapID != 1118)
		return;
	%PlayerNumber = GetRenShuTongJiFortoday();//获取今天的活跃用户数量
	if (%PlayerNumber <= 200)
		%Number = 1;
	else
		%Number = mfloor(%PlayerNumber  - 200)/100 + 1;
	//echo("%Number==== " @ %Number);
	for (%i = 1; %i <= %Number; %i++)
	{
		//echo("%i==" @ %i);
		%Pos = $strMapRanPosRecord[1118,GetRandom(1,$strMapRanPosRecordMax[1118])];
		%X = GetWord(%Pos,0);
		%Y = GetWord(%Pos,1);
		%Z = GetWord(%Pos,2);
		%X = GetRanDom(%X - 2,%X + 2);
		%Y = GetRanDom(%Y - 2,%Y + 2);
		%Pos = %X @ " " @ %Y @ " " @ %Z;
		if (!isobject($ShiMoDianMonSter[%i]))
			$ShiMoDianMonSter[%i] = SpNewNpc2(0,411180002,%Pos,0,GetRanDom(0,360));
		if (!isobject($ShiMoDianMonSter[%Number + %i]))
			$ShiMoDianMonSter[%Number + %i] = SpNewNpc2(0,411180003,%Pos,0,GetRanDom(0,360));
	}
	for (%i = 1; %i <= 50 - %Number * 2; %i++)
	{
		//echo("%i==" @ %i);
		%Pos = $strMapRanPosRecord[1118,GetRandom(1,$strMapRanPosRecordMax[1118])];
		%X = GetWord(%Pos,0);
		%Y = GetWord(%Pos,1);
		%Z = GetWord(%Pos,2);
		%X = GetRanDom(%X - 2,%X + 2);
		%Y = GetRanDom(%Y - 2,%Y + 2);
		%Pos = %X @ " " @ %Y @ " " @ %Z;

		if (!isobject($ShiMoDianMonSter[%i + %Number * 2]))
			$ShiMoDianMonSter[%i + %Number * 2] = SpNewNpc2(0,411180004,%Pos,0,GetRanDom(0,360));
	}
}
//■■■■【镇魔殿】■■■■【尸王刷新】■■■■■■


//■■■■【镇魔殿】■■■■【尸王死亡】■■■■■■
function NpcObjectonDeathcast_411180002(%Monster,%Killer)//技能
{

}
function NpcObjectonDeathcast_411180003(%Monster,%Killer)//材料
{

}
function NpcObjectonDeathcast_411180004(%Monster,%Killer)//假怪
{

}
//■■■■【镇魔殿】■■■■【尸王死亡】■■■■■■