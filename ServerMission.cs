//==================================================================================
//服务端所有的脚本入口，只存脚本加载路径的添加，每添加一个脚本，均需注明脚本的大致内容
//
// 
//本处加载的脚本，所有地图服务器均会载入
//==================================================================================
//■■■■■■■■■■■■服务器的加载内容■■■■■■■■■■■■
//■■■■■■■■■■■■服务器的加载详细■■■■■■■■■■■■
//■■■■■■■■■■■■服务器启动加载项■■■■■■■■■■■■

//■■■■■■■■■■■■服务器的加载内容■■■■■■■■■■■■
function UPCS( %Num )
{
	//加载脚本标识，标明当前为服务端脚本
	$Now_Script = 2;

	//服务器的加载（Server）－－－
	if ( ( %Num == 1 )||( %Num == 99 ) ){ Exec( "./C_S/SL_C_S_Function.cs" ); }
	if ( ( %Num == 2 )||( %Num == 99 ) ){ Exec( "./Server/SL_S_Function.cs" ); }
	if ( ( ( %Num == 3 )||( %Num == 99 ) )&&( GetBuildString( ) $= "Debug" ) ){ Exec( "./Server/SL_S_MoonLightBaoHe.cs" ); }
	if ( ( %Num == 4 )||( %Num == 99 ) ){ Exec( "./Server/SL_S_Npc_Job.cs" ); }
	if ( ( %Num == 5 )||( %Num == 99 ) ){ Exec( "./Server/SL_S_Npc_Killed.cs" ); }
	if ( ( %Num == 6 )||( %Num == 99 ) ){ Exec( "./Server/SL_S_Goods_Trigger.cs" ); }
	if ( ( %Num == 7 )||( %Num == 99 ) ){ Exec( "./Server/SL_S_Sort_Trigger.cs" ); }
	if ( ( %Num == 8 )||( %Num == 99 ) ){ Exec( "./Server/SL_S_Final_Variables.cs" ); }
	if ( ( %Num == 9 )||( %Num == 99 ) ){ Exec( "./Server/SL_S_AI_Buff_Skill_.cs" ); }
	//文件夹下加载
	if ( %Num == 99 )
	{
		UPCS_HuoDong( 99 );	//加载活动脚本
		UPCS_Family(99);	//加载帮派脚本
		UPCS_Mission( 99 );	//加载任务脚本
		UPCS_S_System( %Num );//加载功能脚本
		UPCS_Map( %Num );	//加载地图脚本
		UPCS_CopyMap( %Num );//加载副本文件集
	}
	if ( ( %Num ==12 )||( %Num == 99 ) ){ Exec( "./Server/SL_S_OnSptActionEvent.cs" ); }
	if ( ( %Num ==13 )||( %Num == 99 ) ){ Exec( "./Server/SL_S_ShengHuoCaiJi.cs" ); }
	if ( ( %Num ==14 )||( %Num == 99 ) ){ Exec( "./Server/SL_S_Items_Falling.cs" ); }
	if ( ( %Num ==15 )||( %Num == 99 ) ){ Exec( "./Server/SL_S_Triggerid.cs" ); }

	//-------------最后加载-----------------
	if ( ( %Num ==10 )||( %Num == 99 ) ){ Exec( "./Server/SL_S_Config.cs" ); }
	if ( ( %Num ==11 )||( %Num == 99 ) ){ Exec( "./Server/SL_S_Hotfix.cs" ); }

	//Exec("E:/SL_MiniClient/Server/ZoneServer/gameres/Data/Quest/ServerMission.cs");

}
function UPCS_HuoDong( %Num )
{
	if ( ( %Num ==1 )||( %Num == 99 ) ){ Exec( "./Server/S_HuoDong/SL_S_00_Function.cs" ); }
}
function UPCS_Mission( %Num )
{
	if ( ( %Num == 1 )||( %Num == 99 ) ){ Exec( "./Server/S_Mission/SL_S_Mission_Normal.cs" ); }
	if ( ( %Num == 2 )||( %Num == 99 ) ){ Exec( "./Server/S_Mission/SL_S_Mission_Special.cs" ); }
	if ( ( %Num == 3 )||( %Num == 99 ) ){ Exec( "./Server/S_Mission/SL_S_Mission_Begin_Process.cs" ); }
	if ( ( %Num == 4 )||( %Num == 99 ) ){ Exec( "./Server/S_Mission/SL_S_Mission_End_Process.cs" ); }
	if ( ( %Num == 5 )||( %Num == 99 ) ){ Exec( "./Server/S_Mission/SL_S_Mission_JuQing.cs" ); }
}
function UPCS_CopyMap( %Num )
{
	if ( ( %Num ==1 )||( %Num == 99 ) ){ Exec( "./Server/S_CopyMap/SL_S_CopyMap_00.cs" ); }
}
function UPCS_S_System( %Num )
{
	if ( ( %Num == 1 )||( %Num == 99 ) ){ Exec( "./Server/S_System/S_00_SystemFunction.cs" ); }
	if ( ( %Num == 2 )||( %Num == 99 ) ){ Exec( "./Server/S_System/S_01_NewCheckCode.cs" ); }
}

function UPCS_Map( %Num )
{
	if ( %Num == 99 ){ Exec( "./Server/S_Map/SL_Map_Function.cs" ); }
}

function UPCS_Family(%Num)
{
	if (%Num == 99){ Exec("./Server/S_Family/S_00_Family.cs"); }
}

//■■■■■■■■■■■■服务器的加载详细■■■■■■■■■■■■

//■■■■■■■■■■■■服务器启动加载项■■■■■■■■■■■■

UPCS( 99 ); 


function u( )
{
	UPCS( 99 );
	%SendMapID[1] = 1001;
	%SendMapID[2] = 1010;
	%SendMapID[3] = 1101;
	%SendMapID[4] = 1102;
	%SendMapID[5] = 1103;
	%SendMapID[6] = 1104;
	%SendMapID[7] = 1105;
	%SendMapID[8] = 1106;
	%SendMapID[9] = 1118;
	%SendMapID[10] = 1119;
	%SendMapID[11] = 1120;
	%SendMapID[12] = 1121;
	%SendMapID[13] = 1122;
	%SendMapID[14] = 1129;
	%SendMapID[15] = 1130;
	%SendMapID[16] = 130101;
	%SendMapID[17] = 130201;
	%SendMapID[18] = 130301;
	%SendMapID[19] = 130401;
	%SendMapID[20] = 130501;
	%SendMapID[21] = 130601;
	%SendMapID[22] = 130701;
	%SendMapID[23] = 130801;
	%MapID = getZoneID( );
	for ( %i = 1; %i<= 99; %i++ )
	{
		if ( %SendMapID[ %i ] $= "" )
			break;
		if ( %MapID != %SendMapID[ %i ] )
			SptInterMapExecute( %SendMapID[ %i ], "UPCS(99);" );
	}
}