//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//本处脚本多为NPC功能性脚本，所有地图均会载入
//脚本接入后，依据NPC编号来分流显示
//==================================================================================


//所有功能最初的传入口
function Npc_Job(%Npc,%Player,%State,%Conv)
{
	//NPC功能分类：
	//6位：
	//首位1：商店编号
	//首位2：功能界面编号

	//4位：地图编号
	//5位：传送地图指令编号

	//开店功能
	NpcOpenShop(%Npc,%Player,%State,%Conv);

	//开启功能性界面
	NpcOpenJob(%Npc,%Player,%State,%Conv);

	//开启功能性对话，无界面
	NpcCanDoJob(%Npc,%Player,%State,%Conv);

	//Npc传送功能
	NpcTransportObject(%Npc,%Player,%State,%Conv);

	//飞行点功能
	NpcFly(%Npc,%Player,%State,%Conv);

	//新手各种帮助
	NewPlayerHelp(%Npc,%Player,%State,%Conv);

	//神仙轶事
	//	ShenXianYiShi(%Npc, %Player, %State , %Conv);

	//离开副本统一触发
	leave_CopyMap_Operate(%Npc,%Player,%State,%Conv);

}

//开店功能
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
				%DQ_HH = GetWord(%Time,3);	//时
				%LocalWeek = GetLocalWeek();
				if (%LocalWeek == 0 && %DQ_HH >= 17 && %DQ_HH < 19)
					%Conv.AddOption(410119,410119);//神秘商店
			case 410100012://蓬逢
				if ( %player.getlevel( ) >= 30 )
					%Conv.AddOption( 410120, 410120 );//渔杆商店
			case 410100058:
				if ( %player.getlevel( ) <= 30 )
					%Conv.AddOption( 410100, 410100 );//武器商店
				//%Conv.AddOption(410101,410101);//铸造商店
				//%Conv.AddOption(410102,410102);//配方商店
			case 410100003:
				if ( %player.getlevel( ) <= 30 )
					%Conv.AddOption( 410103, 410103 );//药品商店
				//%Conv.AddOption(410104,410104);//炼丹商店
				//%Conv.AddOption(410105,410105);//配方商店
			case 410100060:
				if ( %player.getlevel( ) <= 30 )
					%Conv.AddOption( 410106, 410106 );//技能商店
				//%Conv.AddOption(410107,410107);//技能商店
				//%Conv.AddOption(410108,410108);//技能商店
			case 410100004:
				if ( %player.getlevel( ) <= 30 )
					%Conv.AddOption( 410109, 410109 );//装备商店
				//%Conv.AddOption(410110,410110);//裁缝商店
				//%Conv.AddOption(410111,410111);//配方商店
			case 410100059:
				if ( %player.getlevel( ) <= 30 )
					%Conv.AddOption( 410112, 410112 );//饰品商店
				//%Conv.AddOption(410113,410113);//制器商店
				//%Conv.AddOption(410114,410114);//配方商店
			case 410100005:
				if ( %player.getlevel( ) <= 30 )
					%Conv.AddOption( 410115, 410115 );//食物商店
				//%Conv.AddOption(410116,410116);//烹饪商店
				//%Conv.AddOption(410117,410117);//配方商店
			case 410100009:
				if ( %player.getlevel( ) <= 30 )
					%Conv.AddOption( 410118, 410118 );//杂货店
				if ( %player.getlevel( ) >= 20 )
					%Conv.AddOption( 430000, 430000 );

				//--------------1001-------------------
			case 410010116:
				%Conv.AddOption(410000,410000);//武器商店
				%Conv.AddOption(410001,410001);//铸造商店
				%Conv.AddOption(410002,410002);//配方商店
			case 410010115:
				%Conv.AddOption(410003,410003);//药品商店
				%Conv.AddOption(410004,410004);//炼丹商店
				%Conv.AddOption(410005,410005);//配方商店
			case 410010119:
				%Conv.AddOption(410006,410006);//技能商店
				%Conv.AddOption(410007,410007);//技能商店
				%Conv.AddOption(410008,410008);//技能商店
			case 410010117:
				%Conv.AddOption(410009,410009);//装备商店
				%Conv.AddOption(410010,410010);//裁缝商店
				%Conv.AddOption(410011,410011);//配方商店
			case 410010118:
				%Conv.AddOption(410012,410012);//饰品商店
				%Conv.AddOption(410013,410013);//制器商店
				%Conv.AddOption(410014,410014);//配方商店
			case 410010140:
				%Conv.AddOption(410015,410015);//食物商店
				%Conv.AddOption(410016,410016);//烹饪商店
				%Conv.AddOption(410017,410017);//配方商店
			case 410010111:
				%Conv.AddOption(410018,410018);//杂货店
			case 410010215:
				%Conv.AddOption(430001,430001);//海螺商店
			case 410010216:
				%Conv.AddOption( 410019, 410019 );//趣味答题
			case 410010201:
				if ( $SL_ManYueQingDianStore_State_bActive == 1 )
					%Conv.AddOption( 430002, 430002 );//九天玄女
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
				%Conv.AddOption(410200,410200);//武器商店
				%Conv.AddOption(100077,100077);//装备修理
			case 411010014:
				%Conv.AddOption(410203,410203);//药品商店
			
			case 411010017:
				%Conv.AddOption(410209,410209);//装备商店
			case 411010019:
				%Conv.AddOption(410212,410212);//饰品商店
			case 411010018:
				%Conv.AddOption(410215,410215);//食物商店
			case 411010016:
				%Conv.AddOption(410218,410218);//杂货店

				//------------------1102-----------------
			case 411020006:
				%Conv.AddOption(410300,410300);//武器商店
				%Conv.AddOption(100077,100077);//装备修理
			case 411020005:
				%Conv.AddOption(410303,410303);//药品商店
			case 411020008:
				%Conv.AddOption(410309,410309);//装备商店
			case 411020014:
				%Conv.AddOption(410312,410312);//饰品商店
			case 411020009:
				%Conv.AddOption(410315,410315);//食物商店
			case 411020007:
				%Conv.AddOption(410318,410318);//杂货店

				//------------------1103------------------
			case 411030007:
				%Conv.AddOption( 410400, 410400 );//武器商店
				%Conv.AddOption( 100077, 100077 );//装备修理
			case 411030006:
				%Conv.AddOption( 410403, 410403 );//药品商店
			case 411030011:
				%Conv.AddOption( 410409, 410409 );//装备商店
			case 411030003:
				%Conv.AddOption( 410412, 410412 );//饰品商店
			case 411030012:
				%Conv.AddOption( 410415, 410415 );//食物商店
			case 411030010:
				%Conv.AddOption( 410418, 410418 );//杂货店

				//-----------------声望商店--------------
			case 410010134://战门声
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

				
			case 410010135://刺门声
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

			case 410010136://法门声
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
			case 410010137://道门声
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
			//case 410010135://弓门声
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
			case 411010004://望仙镇
				%Conv.AddOption(410206, 410206);//技能商店

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
			case 411020010://白虎寨
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
			case 411030015://泽云度
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
			SendOneScreenMessage(2, "您的声望不足", %Player);
			NpcOnTrigger(%Conv, %Npc, %Player, 0, -1);
		}
		else if (%Player.ShengWangShop2 == -1 && %Player.ShengWangShop1 == %State)
		{
			SendOneScreenMessage(2, "您的声望不足", %Player);
			NpcOnTrigger(%Conv, %Npc, %Player, 0, -1);
		}
		else
		{
			%Conv.SetType(4);
			OpenNpcShop(%Player, %State);
		}
	}
}
//开启功能性界面
function NpcOpenJob(%Npc,%Player,%State,%Conv)
{
	%PlayerID = %Player.GetPlayerID();
	%NpcID = %Npc.GetDataID();
	if (%State  == 0)
	{
		//----------------------筛选这个NPC身上是否有玩家需求的任务选项----------------------------
		%NpcA_Mid = GetStartNpcMission(%NpcID);//可以领取的任务
		%NpcX_Mid = GetMidTalkNpcMission(%NpcID);	//正在进行中任务
		%NpcZ_Mid = GetEndNpcMission(%NpcID);//可以完成的任务
		%NpcA_Mid_MaxNum = GetWordCount(%NpcA_Mid);//可以领取的任务数量
		%NpcZ_Mid_MaxNum = GetWordCount(%NpcZ_Mid);//可以完成的任务数量
		%NpcX_Mid_MaxNum = GetWordCount(%NpcX_Mid);//正在进行中任务数量
		for (%a = 0; %a < %NpcA_Mid_MaxNum; %a++)
		{
			%Mid = GetWord(%NpcA_Mid,%a);//获取任务ID
			if (!Mission_Begin_SeeOption(%Player,%Mid))//是否显示(特殊判断)
				if (CanDoThisMission(%Player,%Mid,1,0,0) $= "")	//是否显示(常规判断)
				{
					%Recrod = 1;
					break;
				}
		}
		if (%Recrod != 1)
		{
			for (%z = 0; %z < %NpcZ_Mid_MaxNum; %z++)
			{
				%Mid = GetWord(%NpcZ_Mid,%z);//获取任务ID
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
				%Mid = GetWord(%NpcX_Mid,%z);//获取任务ID
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
			case 410010108://礼品大史
				if (%Recrod == 1)
					%Conv.AddOption(100016,100016);
				else
					return NpcOpenJob(%Npc,%Player,100016,%Conv);

			case 410010123://宝石界面相关
				if (%Recrod == 1)
					%Conv.AddOption(100022,100022);
				else
					return NpcOpenJob(%Npc,%Player,100022,%Conv);

			case 410010122://装备鉴定界面
				if (%Recrod == 1)
					%Conv.AddOption(100023,100023);
				else
					return NpcOpenJob(%Npc,%Player,100023,%Conv);

			case 410010121://装备强化界面
				if (%Recrod == 1)
					%Conv.AddOption(100024,100024);
				else
					return NpcOpenJob(%Npc,%Player,100024,%Conv);

			case 410010102://打开邮箱
				%Conv.AddOption(100025,100025);

			case 411010009://打开邮箱
				%Conv.AddOption(100025,100025);

			case 411020002://打开邮箱
				%Conv.AddOption(100025,100025);

			case 410100052://打开邮箱
				%Conv.AddOption(100025,100025);
			case 411030009://打开邮箱
				%Conv.AddOption(100025, 100025);
			case 410010124://铸造台
				if (%Recrod == 1)
					%Conv.AddOption(100027,100027);
				else
					return NpcOpenJob(%Npc,%Player,100027,%Conv);

			case 410010125://炼丹炉
				if (%Recrod == 1)
					%Conv.AddOption(100028,100028);
				else
					return NpcOpenJob(%Npc,%Player,100028,%Conv);

			case 410010126://缝纫台
				if (%Recrod == 1)
					%Conv.AddOption(100029,100029);
				else
					return NpcOpenJob(%Npc,%Player,100029,%Conv);

			case 410010127:	//烹饪鼎
				if (%Recrod == 1)
					%Conv.AddOption(100030,100030);
				else
					return NpcOpenJob(%Npc,%Player,100030,%Conv);

			case 410010128://制符案
				if (%Recrod == 1)
					%Conv.AddOption(100031,100031);
				else
					return NpcOpenJob(%Npc,%Player,100031,%Conv);

			case 410010139://制器台
				if (%Recrod == 1)
					%Conv.AddOption(100032,100032);
				else
					return NpcOpenJob(%Npc,%Player,100032,%Conv);
			case 410010120://鉴宝大师
				if (%Recrod == 1)
					%Conv.AddOption(100075,100075);
				else
					return NpcOpenJob(%Npc,%Player,100075,%Conv);
			case 410010142://装备修理
				if (%Recrod == 1)
					%Conv.AddOption(100077,100077);
				else
					return NpcOpenJob(%Npc,%Player,100077,%Conv);
			case 410010143://神石合成
				if (%Recrod == 1)
					%Conv.AddOption(100076,100076);
				else
					return NpcOpenJob(%Npc,%Player,100076,%Conv);
			case 411010010://1101 悬赏缉凶
				%Conv.AddOption(100026,100026);
			case 411020003://1102 悬赏缉凶
				%Conv.AddOption(100026,100026);
			case 411030004://1103 悬赏缉凶
				%Conv.AddOption( 100026, 100026 );

			case 410010106:
				if (%Recrod == 1)
					%Conv.AddOption(100078,100078);
				else
					return NpcOpenJob(%Npc,%Player,100078,%Conv);
			case 410010144://生活技能学习
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
		case 410010107://帮派相关
			FamilyDialog(%Npc,%Player,%State,%Conv);
	}
	switch (%State)
	{
		case 100021:
			%Player.OpenBank(0);
		case 100016://领奖
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,1);	//通讯客户端
		case 100022://宝石
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,2);	//通讯客户端
			HelpDirectByIndex(%PlayerID,28);	//打开背包
		case 100023://鉴定
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,3);	//通讯客户端
			HelpDirectByIndex(%PlayerID,28);
		case 100024://强化
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,4);	//通讯客户端
			HelpDirectByIndex(%PlayerID,28);
		case 100025://邮箱
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,5);	//通讯客户端
		case 100026:
			%Level = %Player.GetLevel();
			%MapId = GetZoneID();
			%Conv.Settype(4);
			if (%Level >= $SL_XuanShangJiXiong_Level[%MapId])
				HelpDirectByIndex(%PlayerID,8);	//通讯客户端
			else
			{
				SendOneScreenMessage(2,$SL_XuanShangJiXiong_Level[%MapId] @ "级以上才可以接取本地图悬赏缉凶任务",%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ $SL_XuanShangJiXiong_Level[%MapId] @ "级以上才可以接取本地图悬赏缉凶任务" @ "</t>",%Player);
			}
		case 100027://打开铸造台
			%Conv.Settype(4);
			ServerOnSptAction(%PlayerID,1,14);
		case 100028://打开炼丹炉
			%Conv.Settype(4);
			ServerOnSptAction(%PlayerID,5,14);
		case 100029://打开缝纫台
			%Conv.Settype(4);
			ServerOnSptAction(%PlayerID,2,14);
		case 100030://打开烹饪鼎
			%Conv.Settype(4);
			ServerOnSptAction(%PlayerID,6,14);
		case 100031://打开制符案
			%Conv.Settype(4);
			ServerOnSptAction(%PlayerID,4,14);
		case 100032://打开制器台
			%Conv.Settype(4);
			ServerOnSptAction(%PlayerID,3,14);
		case 100075://打开鉴宝界面
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,9);	//通讯客户端
			HelpDirectByIndex(%PlayerID,28);
		case 100076://打开神石合成界面
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,10);	//通讯客户端
			HelpDirectByIndex(%PlayerID,28);
		case 100077://打开装备修理界面
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,13);	//通讯客户端
		case 100078://打开元宝交易界面
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,19);	//通讯客户端
		case 100082:
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,24);	//通讯客户端
		case 100085:
			%Conv.Settype(4);
			HelpDirectByIndex(%PlayerID,27);	//通讯客户端
	}
}
//开启功能性对话，无界面
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
		case  410010113://双倍经验
			NpcDiaLog_410010113(%Npc,%Player,%State,%Conv);//每周双倍经验领取
		case 410010114://孟婆	删号处理
			DeletePlayer(%Npc,%Player,%State,%Conv);
		case 411190023://封魔城管理员
			NpcDiaLog_411190023(%Npc, %Player, %State, %Conv);
			//case 410100001:
		case 410010134://使者·战
			%Player.MainType = 1;
			%Player.SubType = 1;
			NpcDiaLog_410010134_410010137(%Npc, %Player, %State, %Conv);
		case 410010136://使者·法
			%Player.MainType = 1;
			%Player.SubType = 2;
			NpcDiaLog_410010134_410010137(%Npc, %Player, %State, %Conv);
		case 410010137://使者·道
			%Player.MainType = 1;
			%Player.SubType = 3;
			NpcDiaLog_410010134_410010137(%Npc, %Player, %State, %Conv);
		case 411010004:	//望仙谷：		梁伯
			%Player.MainType = 2;
			%Player.SubType = 1;
			NpcDiaLog_410010134_410010137(%Npc, %Player, %State, %Conv);
		case 411020010:	//苍山雪海：	万虎
			%Player.MainType = 2;
			%Player.SubType = 2;
			NpcDiaLog_410010134_410010137(%Npc, %Player, %State, %Conv);
		case 411030015:	//云梦泽：		柴进
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
//Npc传送功能
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
			%Text = "传送最低等级限制" @ $CalculationNpcTransport[%NpcID,%TarGetID,2] @ "级";
		else if (%Level > $CalculationNpcTransport[%NpcID,%TarGetID,3])
			%Text = "传送最高等级限制" @ $CalculationNpcTransport[%NpcID,%TarGetID,3] @ "级";
		else if (%Player.getmoney(2) < $CalculationNpcTransport[%NpcID,%TarGetID,1])
			%Text = "金钱不足，需要" @ $CalculationNpcTransport[%NpcID,%TarGetID,1] @ "铜传送费";
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

//飞行点功能
function NpcFly(%Npc,%Player,%State,%Conv)
{	//
	//飞行路径：11030001
	//	父区域：811030100
	//	镜子区域：811030101
	//飞行点功能
	//switch ( %State )
	//{
	//	case 310001:%Conv.SetType( 4 ); FlyMeToTheMoon( %Player, 11030001, 700010000 );
	//}
}
//新手各种帮助
function NewPlayerHelp(%Npc,%Player,%State,%Conv)
{

}

//离开副本统一触发
function leave_CopyMap_Operate(%Npc,%Player,%State,%Conv)
{

}


//删除角色
function DeletePlayer(%Npc,%Player,%State,%Conv)
{
	switch (%State)
	{
		case 0:
			%Conv.SetText(100010);	//删除角色说明
			%Conv.AddOption(100009,100009);  //删除角色
			if (IfApplyDeletePlayer(%Player.GetPlayerID()))
				%Conv.AddOption(100011,100011);  //取消删除角色

		case 100009:
			if (!IfApplyDeletePlayer(%Player.GetPlayerID()))
			{
				%Conv.SetText(100012);	//确认要删除吗？
				%Conv.AddOption(100009,100010);  //删除角色
			}
			else
				%Conv.SetText(100013);	//您已经申请删除
			%Conv.AddOption(4,0);  //返回
		case 100010:
			%Conv.SetType(4);
			switch (CanDeletePlayer(%Player.GetPlayerID()))
			{
				case 0:
					ConfirmDeletePlayer(%Player.GetPlayerID());	//0成功
					%Txt = "申请成功";
					SendOneScreenMessage(2,%Txt,%Player);
					SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
				default:
					SendWhyNoDeletePlayerMsg(%Player,CanDeletePlayer(%Player.GetPlayerID()));
			}

		case 100011:
			%Conv.SetType(4);
			CancelDeletePlayer(%Player.GetPlayerID());//取消删除角色选项
	}
}

function SendWhyNoDeletePlayerMsg(%Player,%Why)
{
	//echo( "%Why ===" @ %Why );
	switch (%Why)
	{
		//case 1:	%Txt = "当前角色不在线";
		case 2: %Txt = "您的角色申请删除时间未满3天";
		case 3: %Txt = "您当前角色不能处于帮派中";
		case 4: %Txt = "您当前角色不能处于结拜中";
		case 5: %Txt = "您当前角色不能处于姻缘中";
		case 6: %Txt = "您当前角色不能处于师徒关系中";
		case 7: %Txt = "您当前角色不能处于师徒关系中";
		case 8: %Txt = "您当前角色不能拥有商铺";
		case 9: %Txt = "您当前角色有道具正处于锁定状态";
		case 10:%Txt = "您当前角色有神兽正处于锁定状态";
		case 11:%Txt = "您当前角色有骑宠正处于骑乘状态";
		case 12:%Txt = "您当前角色有化身正处于锁定状态";
		default:%Txt = "未知原因，无法删除角色";
	}
	SendOneScreenMessage(2,%Txt,%Player);
	SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
}

//%NpcID = 410010008  %State==0 %NpcName = 南宫诗兰  %Pos == 16.0388 -37.1326 182.003

function NpcDiaLog_410010134_410010137(%Npc, %Player, %State, %Conv)
{
	switch (%State)
	{
		case 0:
			%Conv.AddOption(100087, 100087);
		case 100087:
			%Conv.Settext(100088);
			//%Conv.AddOption(100089, 100089);//捐献1金
			%Conv.AddOption(100090, 100090);//捐献金条
			%Conv.AddOption(100091, 100091);//捐献金砖
			%Conv.AddOption(100100, 100100);//捐献一级奇珍
			%Conv.AddOption(100101, 100101);//捐献二级奇珍
			%Conv.AddOption(100102, 100102);//捐献三级奇珍
			%Conv.AddOption(100103, 100103);//捐献四级奇珍
			%Conv.AddOption(100104, 100104);//捐献五级奇珍
			%Conv.AddOption(100105, 100105);//捐献六级奇珍
			%Conv.AddOption(100106, 100106);//捐献七级奇珍
			%Conv.AddOption(100107, 100107);//捐献八级奇珍
			//%Conv.AddOption(100108, 100108);//捐献九级奇珍
			//%Conv.AddOption(100109, 100109);//捐献十级奇珍

		case 100089://捐献1金
			%Conv.Settext(100092);
			%Conv.AddOption(100093, 100093);
		case 100093:
			%retuenState = 100089;
			if (%Player.GetMoney(2) < 10000)
			{
				SendOneScreenMessage(2, "您的金币不足", %Player);
				SendOneChatMessage($chatMsg_System, "<t>您的金币不足。</t>", %Player);
			}
			else
			{
				%Player.Reducemoney(10000, 2, 5, 4105);
				AddPrestige(%Player, $PrestigeStageActID[%Player.MainType, %Player.SubType], 300);
			}
		case 100090://捐献金条
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

		case 100091://捐献金砖
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
	if (%State == 100099 || %State == 100098 || %State == 100096 || %State == 100095)//捐献金条和金砖
	{
		if (%ItemNum[1] == 999)
			%ItemNum[1] = %Player.GetItemCount(%Itemid[1]);

		if (%Itemid[1] > 0 && %ItemNum[1] > 0)
		{
		
			if (%Player.GetItemCount(%Itemid[1] < %ItemNum[1]))
			{
				SendOneScreenMessage(2, "您的"@ GetItemdata(%Itemid[1]) @"不足", %Player);
				SendOneChatMessage($chatMsg_System, "<t>您的</t>" @ GetItemdata(%Itemid[1]) @ "<t>不足。</t>", %Player);
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