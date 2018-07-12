//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//副本【蓬莱禁地】
//==================================================================================

//■■■■【蓬莱禁地】■■■■【副本创建触发】■■■■■■■
//■■■■【蓬莱禁地】■■■■【进入副本触发】■■■■■■■
//■■■■【蓬莱禁地】■■■■【怪物信息】■■■■■■■■■
//■■■■【蓬莱禁地】■■■■【怪物创建】■■■■■■■■■


//■■■■【蓬莱禁地】■■■■【副本创建触发】■■■■■■■
//function SvrCopymapOpen_1303_Trigger( %CopyMapID, %CopymapDataID )
//{
//	SpNewNpc2( 0, 410100005, "181.789 115.29 102.214", %CopyMapID, 90 );//神农长老
//	SpNewNpc2( 0, 410100057, "187.249 172.621 104.29", %CopyMapID, 180 );//神秘人
//}
//■■■■【蓬莱禁地】■■■■【副本创建触发】■■■■■■■

//■■■■【蓬莱禁地】■■■■【进入副本触发】■■■■■■■
function SptCopymap_OnEnter_1303_Trigger(%CopyMapID,%Player)
{
	%AAA = %Player.IsAcceptedMission(10321);
	%BBB = %Player.IsAcceptedMission(10331);
	%CCC = %Player.IsAcceptedMission(10341);
	//echo("%AAA==============" @ %AAA);
	if (%AAA >= 1 || %BBB >= 1 || %CCC >= 1)
	{
		%Player.NpcRecord1303A = SpNewNpc2(0,413031011,"182.418 154.744 102.214",%CopyMapID,90);//神农长老
		%Player.NpcRecord1303B = SpNewNpc2(0,410100057,"187.249 172.621 104.29",%CopyMapID,180);//神秘人
	}
}
//■■■■【蓬莱禁地】■■■■【进入副本触发】■■■■■■■

//■■■■【蓬莱禁地】■■■■【怪物信息】■■■■■■■■■

//灭魂大阵
$PengLaiJinDi_Monster_Num[1] = 20;
$PengLaiJinDi_Monster_ID[1,1]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,1] = "-176.116 151.551 432.684 ";	$PengLaiJinDi_Monster_Ret[1,1] = "0 0 1 0  ";
$PengLaiJinDi_Monster_ID[1,2]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,2] = "-169.536 155.523 432.684 ";	$PengLaiJinDi_Monster_Ret[1,2] = "0 0 1 315";
$PengLaiJinDi_Monster_ID[1,3]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,3] = "-166.152 162.043 432.684 ";	$PengLaiJinDi_Monster_Ret[1,3] = "0 0 1 270";
$PengLaiJinDi_Monster_ID[1,4]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,4] = "-168.870 169.092 432.684 ";	$PengLaiJinDi_Monster_Ret[1,4] = "0 0 1 225";
$PengLaiJinDi_Monster_ID[1,5]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,5] = "-176.070 172.224 432.684 ";	$PengLaiJinDi_Monster_Ret[1,5] = "0 0 1 180";
$PengLaiJinDi_Monster_ID[1,6]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,6] = "-182.708 169.509 432.684 ";	$PengLaiJinDi_Monster_Ret[1,6] = "0 0 1 135";
$PengLaiJinDi_Monster_ID[1,7]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,7] = "-186.807 162.958 432.684 ";	$PengLaiJinDi_Monster_Ret[1,7] = "0 0 1 90 ";
$PengLaiJinDi_Monster_ID[1,8]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,8] = "-182.853 156.097 432.684 ";	$PengLaiJinDi_Monster_Ret[1,8] = "0 0 1 45 ";
$PengLaiJinDi_Monster_ID[1,9]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,9] = "-172.727 142.223 430.717 ";	$PengLaiJinDi_Monster_Ret[1,9] = "0 0 1 0  ";
$PengLaiJinDi_Monster_ID[1,10]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,10] = "-163.712 146.059 430.717 ";	$PengLaiJinDi_Monster_Ret[1,10] = "0 0 1 330";
$PengLaiJinDi_Monster_ID[1,11]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,11] = "-158.860 152.289 430.717 ";	$PengLaiJinDi_Monster_Ret[1,11] = "0 0 1 300";
$PengLaiJinDi_Monster_ID[1,12]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,12] = "-156.915 162.322 430.717 ";	$PengLaiJinDi_Monster_Ret[1,12] = "0 0 1 270";
$PengLaiJinDi_Monster_ID[1,13]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,13] = "-159.314 172.454 430.717 ";	$PengLaiJinDi_Monster_Ret[1,13] = "0 0 1 240";
$PengLaiJinDi_Monster_ID[1,14]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,14] = "-164.450 178.969 430.717 ";	$PengLaiJinDi_Monster_Ret[1,14] = "0 0 1 210";
$PengLaiJinDi_Monster_ID[1,15]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,15] = "-175.655 181.541 430.717 ";	$PengLaiJinDi_Monster_Ret[1,15] = "0 0 1 180";
$PengLaiJinDi_Monster_ID[1,16]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,16] = "-186.206 179.449 430.717 ";	$PengLaiJinDi_Monster_Ret[1,16] = "0 0 1 150";
$PengLaiJinDi_Monster_ID[1,17]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,17] = "-192.582 174.157 430.717 ";	$PengLaiJinDi_Monster_Ret[1,17] = "0 0 1 120";
$PengLaiJinDi_Monster_ID[1,18]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,18] = "-195.299 162.948 430.717 ";	$PengLaiJinDi_Monster_Ret[1,18] = "0 0 1 90 ";
$PengLaiJinDi_Monster_ID[1,19]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,19] = "-193.553 153.550 430.717 ";	$PengLaiJinDi_Monster_Ret[1,19] = "0 0 1 60 ";
$PengLaiJinDi_Monster_ID[1,20]  = "413031009";	$PengLaiJinDi_Monster_XYZ[1,20] = "-185.698 145.674 430.717 ";	$PengLaiJinDi_Monster_Ret[1,20] = "0 0 1 30 ";

$PengLaiJinDi_Monster_Num[2] = 20;
$PengLaiJinDi_Monster_ID[2,1]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,1] = "-176.116 151.551 432.684 ";	$PengLaiJinDi_Monster_Ret[2,1] = "0 0 1 0  ";
$PengLaiJinDi_Monster_ID[2,2]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,2] = "-169.536 155.523 432.684 ";	$PengLaiJinDi_Monster_Ret[2,2] = "0 0 1 315";
$PengLaiJinDi_Monster_ID[2,3]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,3] = "-166.152 162.043 432.684 ";	$PengLaiJinDi_Monster_Ret[2,3] = "0 0 1 270";
$PengLaiJinDi_Monster_ID[2,4]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,4] = "-168.870 169.092 432.684 ";	$PengLaiJinDi_Monster_Ret[2,4] = "0 0 1 225";
$PengLaiJinDi_Monster_ID[2,5]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,5] = "-176.070 172.224 432.684 ";	$PengLaiJinDi_Monster_Ret[2,5] = "0 0 1 180";
$PengLaiJinDi_Monster_ID[2,6]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,6] = "-182.708 169.509 432.684 ";	$PengLaiJinDi_Monster_Ret[2,6] = "0 0 1 135";
$PengLaiJinDi_Monster_ID[2,7]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,7] = "-186.807 162.958 432.684 ";	$PengLaiJinDi_Monster_Ret[2,7] = "0 0 1 90 ";
$PengLaiJinDi_Monster_ID[2,8]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,8] = "-182.853 156.097 432.684 ";	$PengLaiJinDi_Monster_Ret[2,8] = "0 0 1 45 ";
$PengLaiJinDi_Monster_ID[2,9]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,9] = "-172.727 142.223 430.717 ";	$PengLaiJinDi_Monster_Ret[2,9] = "0 0 1 0  ";
$PengLaiJinDi_Monster_ID[2,10]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,10] = "-163.712 146.059 430.717 ";	$PengLaiJinDi_Monster_Ret[2,10] ="0 0 1 330";
$PengLaiJinDi_Monster_ID[2,11]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,11] = "-158.860 152.289 430.717 ";	$PengLaiJinDi_Monster_Ret[2,11] ="0 0 1 300";
$PengLaiJinDi_Monster_ID[2,12]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,12] = "-156.915 162.322 430.717 ";	$PengLaiJinDi_Monster_Ret[2,12] ="0 0 1 270";
$PengLaiJinDi_Monster_ID[2,13]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,13] = "-159.314 172.454 430.717 ";	$PengLaiJinDi_Monster_Ret[2,13] ="0 0 1 240";
$PengLaiJinDi_Monster_ID[2,14]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,14] = "-164.450 178.969 430.717 ";	$PengLaiJinDi_Monster_Ret[2,14] ="0 0 1 210";
$PengLaiJinDi_Monster_ID[2,15]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,15] = "-175.655 181.541 430.717 ";	$PengLaiJinDi_Monster_Ret[2,15] ="0 0 1 180";
$PengLaiJinDi_Monster_ID[2,16]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,16] = "-186.206 179.449 430.717 ";	$PengLaiJinDi_Monster_Ret[2,16] ="0 0 1 150";
$PengLaiJinDi_Monster_ID[2,17]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,17] = "-192.582 174.157 430.717 ";	$PengLaiJinDi_Monster_Ret[2,17] ="0 0 1 120";
$PengLaiJinDi_Monster_ID[2,18]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,18] = "-195.299 162.948 430.717 ";	$PengLaiJinDi_Monster_Ret[2,18] ="0 0 1 90 ";
$PengLaiJinDi_Monster_ID[2,19]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,19] = "-193.553 153.550 430.717 ";	$PengLaiJinDi_Monster_Ret[2,19] ="0 0 1 60 ";
$PengLaiJinDi_Monster_ID[2,20]  = "413031010";	$PengLaiJinDi_Monster_XYZ[2,20] = "-185.698 145.674 430.717 ";	$PengLaiJinDi_Monster_Ret[2,20] ="0 0 1 30 ";

//■■■■【蓬莱禁地】■■■■【怪物信息】■■■■■■■■■


//■■■■【蓬莱禁地】■■■■【怪物创建】■■■■■■■■■
function PengLaiJinDi_ZhenLingKuiLei_SpNPC(%Player)//阵灵傀儡
{
	//获取怪物信息，并刷怪
	for (%i=1; %i <= $PengLaiJinDi_Monster_Num[1]; %i++)
	{
		%Monster_ID  = $PengLaiJinDi_Monster_ID[1,%i];	//怪物编号
		%Monster_XYZ = $PengLaiJinDi_Monster_XYZ[1,%i];	//怪物坐标
		//%Monster_Ret = $PengLaiJinDi_Monster_Ret[ 1, %i ];	//怪物朝向

		//获取正常朝向
		//if ( GetWord( %Monster_Ret, 2 ) > 0 )
		//	%Monster_Ret = GetWord( %Monster_Ret, 3 );
		//else
		//	%Monster_Ret = 360 - GetWord( %Monster_Ret, 3 );


		%Monster = SpNewNpc(%Player,%Monster_ID,%Monster_XYZ,0);
		%Monster.SetLevel(20);
		%Monster.SetExclusivePlayerId(%Player.GetPlayerID()); //设置怪物独占玩家
		%Monster.addLogicFloor(%Player);//设置怪物镜像
		%Monster.delLogicFloor(0);
		%Player.MissIonRecordZhenLing[1,%i] = %Monster;
	}
	//提示公告
	//%Msg = "传来阵阵诡异寒风，直扑面门，一大群不知名的怪物突然出现，小心！";
	//SendAllScreenMessageLayer( 1, %Txt, %CopyMapID );
	//SendAllChatMessageLayer( $chatMsg_System, $Get_Dialog_GeShi[ 31204 ] @ %Msg @"</t>", %CopyMapID );
}

function PengLaiJinDi_MieHunZhenLing_SpNPC(%Player)//灭魂阵灵
{
	//获取怪物信息，并刷怪
	for (%i=1; %i <= $PengLaiJinDi_Monster_Num[2]; %i++)
	{
		%Monster_ID  = $PengLaiJinDi_Monster_ID[2,%i];	//怪物编号
		%Monster_XYZ = $PengLaiJinDi_Monster_XYZ[2,%i];	//怪物坐标
		//%Monster_Ret = $PengLaiJinDi_Monster_Ret[ 2, %i ];	//怪物朝向

		//获取正常朝向
		//if ( GetWord( %Monster_Ret, 2 ) > 0 )
		//	%Monster_Ret = GetWord( %Monster_Ret, 3 );
		//else
		//	%Monster_Ret = 360 - GetWord( %Monster_Ret, 3 );


		%Monster = SpNewNpc(%Player,%Monster_ID,%Monster_XYZ,0);
		%Monster.SetLevel(20);
		%Monster.SetExclusivePlayerId(%Player.GetPlayerID()); //设置怪物独占玩家
		%Monster.addLogicFloor(%Player);//设置怪物镜像
		%Monster.delLogicFloor(0);
		%Player.MissIonRecordZhenLing[2,%i] = %Monster;
	}
	//提示公告
	//%Msg = "一大群更强的怪物突然出现，装备上临时神兵，小心应对！";
	//SendAllScreenMessageLayer( 1, %Txt, %CopyMapID );
	//SendAllChatMessageLayer( $chatMsg_System, $Get_Dialog_GeShi[ 31204 ] @ %Msg @"</t>", %CopyMapID );
}
//■■■■【蓬莱禁地】■■■■【怪物创建】■■■■■■■■■