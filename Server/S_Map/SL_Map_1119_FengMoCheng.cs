//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//封魔城攻城战
//
//SptOrg_AttackCitySuccess（%orgID）	//攻城成功
//SptOrg_AttackCityFail（%orgID）	//攻城失败
//==================================================================================

//■■■■■■■【封魔城】■■■■【城战信息刷新】■■■■■■■■
//■■■■■■■【封魔城】■■■■【城战信息刷新】■■■■■■■■
//■■■■■■■【封魔城】■■■■【攻城战开启判断】■■■■■■■
//■■■■■■■【封魔城】■■■■【城战流程过程】■■■■■■■■
//■■■■■■■【封魔城】■■■■【玩家复活触发】■■■■■■■■
//■■■■■■■【封魔城】■■■■【进出区域触发】■■■■■■■■
//■■■■■■■【封魔城】■■■■【攻城怪物被击败】■■■■■■■
//■■■■■■■【封魔城】■■■■【称号清理】■■■■■■■■■■
//■■■■■■■【封魔城】■■■■【城主雕像】■■■■■■■■■■


//■■■■■■■【封魔城】■■■■【城战信息刷新】■■■■■■■■
function Refresh_CitityWar(%YY, %MM, %DD, %H, %M, %S)
{
	if ($SL_CityAttack_bActive != 1)
		return;
	SptOrg_RequestAttackCityOrgIdinfo();//获取攻城信息
	$AttackCityRecordDefend = SptOrg_GetAttackCityOrgIdinfo(1);//获取守城方
	$AttackCityRecorAdttackToday = SptOrg_GetAttackCityOrgIdinfo(2);//获得今天攻城方
	$AttackCityRecorAdttackTomorrow = SptOrg_GetAttackCityOrgIdinfo(3);//获得明天攻城方

	echo("■■【封魔城】■■■■【城战信息刷新】■■");
	Putout("守城方======" @ SptOrg_GetAttackCityOrgIdinfo(1) @ "   " @ SptOrg_GetName(SptOrg_GetAttackCityOrgIdinfo(1)));
	Putout("今天攻城方==" @ SptOrg_GetAttackCityOrgIdinfo(2) @ "   " @ SptOrg_GetName(SptOrg_GetAttackCityOrgIdinfo(2)));
	Putout("明天攻城方==" @ SptOrg_GetAttackCityOrgIdinfo(3) @ "   " @ SptOrg_GetName(SptOrg_GetAttackCityOrgIdinfo(3)));
	//--以下具体内容部分，由1119地图执行
	if (GetZoneID() != 1119)
		return;
	if (%M == 50 && %H == 19)
	{
		%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//获取守城方
		%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//获得今天攻城方
		%OrgIDC = SptOrg_GetAttackCityOrgIdinfo(3);//获得明天攻城方
		if (%OrgIDB > 0)
		{
			%HuoDongMingCheng1 = GetHuoDongName("封魔城攻城战", 1);
			%HuoDongMingCheng2 = GetHuoDongName("封魔城攻城战", 2);
			%OrgName = SptOrg_GetName(%OrgIDB);		//家族名称
			%OrgName1 = $Get_Dialog_GeShi[31421] @ "『" @ %OrgName @ "』</t>";
			%OrgName2 = $Get_Dialog_GeShi[60003] @ "『" @ %OrgName @ "』</t>";
			echo("%OrgIDB ==" @ %OrgIDB);
			echo("%OrgName ==" @ %OrgName);
			echo("%OrgName1 ==" @ %OrgName1);
			%Txt1 = %HuoDongMingCheng1 @ "<t>将于</t>" @ $Get_Dialog_GeShi[31420] @ "10</t>" @ "<t>分钟后开始，战斗一触即发，且看城主宝座花落谁家!</t>";
			%Txt2 = %HuoDongMingCheng2 @ "<t>将于</t>" @ $Get_Dialog_GeShi[31420] @ "10</t>" @ "<t>分钟后开始</t>";
			SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Txt1 @ "</t>");
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Txt2 @ "</t>", $chatMsg_Type_Normal2);
		}
	}
	if (%H == 20 && %M == 0)
	{
		%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//获取守城方
		%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//获得今天攻城方
		%OrgIDC = SptOrg_GetAttackCityOrgIdinfo(3);//获得明天攻城方
		if (%OrgIDB > 0)
		{
			%HuoDongMingCheng1 = GetHuoDongName("封魔城攻城战", 1);
			%HuoDongMingCheng2 = GetHuoDongName("封魔城攻城战", 2);
			%Txt1 = %HuoDongMingCheng1 @ "<t>开始。</t>";
			%Txt2 = %HuoDongMingCheng2 @ "<t>开始。</t>";
			SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Txt1 @ "</t>");
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Txt2 @ "</t>", $chatMsg_Type_Normal2);
			
			AttackCityWarStates(0);//执行攻城开始函数
		}
	}
	if (%M == 35 && %H == 21)
	{
		
		%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//获取守城方
		%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//获得今天攻城方
		%OrgIDC = SptOrg_GetAttackCityOrgIdinfo(3);//获得明天攻城方

		if (%OrgIDA == 0 && %OrgIDC == 0)
		{
			%HuoDongMingCheng1 = GetHuoDongName("封魔城", 1);
			%NpcName1 = GetNpcZiTiName(410010001, 1);
			%Path = "<l i='810010100 -31.6664 23.816 200.047' t='path'/>";
			%Txt1 = %HuoDongMingCheng1 @ "<t>目前无帮派占领，所有2级以上帮派均可前往</t>" @ %Path @ "<t>寻找</t>" @ %NpcName1 @ "<t>提出攻打申请，君临封魔，威震天下，更待何时！</t>";
			SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Txt1 @ "</t>");
		}
		//else if (%OrgIDC > 0)
		//{
		//	%HuoDongMingCheng1 = GetHuoDongName("封魔城", 1);
		//	%OrgName = SptOrg_GetName(%OrgIDC);		//家族名称
		//	%OrgName = $Get_Dialog_GeShi[31421] @ "『" @ %OrgName @ "』</t>";
		//	%Txt1 = "<t>帮派</t>" @ %OrgName @ "<t>获得了</t>" @ %HuoDongMingCheng1 @ "<t>的攻打权，一时间江湖风起云涌，且看明日城主宝座花落谁家。</t>";
		//	SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Txt1 @ "</t>");
		//}
	}
}
//■■■■■■■【封魔城】■■■■【城战信息刷新】■■■■■■■■

//■■■■■■■【封魔城】■■■■【城战流程过程】■■■■■■■■
function AttackCityWarStates(%Step)
{
	CanCel($AttackCityWarStates);
	switch (%Step)
	{
		case 0:
			$IsAttackCityWar_State_bActive = 1;//标记开始
			//删除所有主城常置NPC
			$NpcRecord[1].SafeDeleteObject();
			$NpcRecord[2].SafeDeleteObject();
			$NpcRecord[3].SafeDeleteObject();
			$NpcRecord[4].SafeDeleteObject();
			$NpcRecord[5].SafeDeleteObject();
			$NpcRecord[6].SafeDeleteObject();
			$NpcRecord[7].SafeDeleteObject();
			
			$GuardRecord[1].SafeDeleteObject(); $GuardRecord[1] = SpNewNpc2(0, 411192001, "-74.390 149.824 100", 0, 270); SetNpcInfluence($GuardRecord[1],8);//左门A
			$GuardRecord[2].SafeDeleteObject(); $GuardRecord[2] = SpNewNpc2(0, 411192001, "-74.027 140.621 100", 0, 270); SetNpcInfluence($GuardRecord[2],8);//左门B
			$GuardRecord[3].SafeDeleteObject(); $GuardRecord[3] = SpNewNpc2(0, 411192001, "-6.7458 62.7418 101", 0, 180); SetNpcInfluence($GuardRecord[3],8);//正门A
			$GuardRecord[4].SafeDeleteObject(); $GuardRecord[4] = SpNewNpc2(0, 411192001, "6.87547 62.7418 101", 0, 180); SetNpcInfluence($GuardRecord[4],8);//正门B
			$GuardRecord[5].SafeDeleteObject(); $GuardRecord[5] = SpNewNpc2(0, 411192001, "72.9715 140.391 100", 0, 090); SetNpcInfluence($GuardRecord[5],8);//右门A
			$GuardRecord[6].SafeDeleteObject(); $GuardRecord[6] = SpNewNpc2(0, 411192001, "72.9566 149.813 100", 0, 090); SetNpcInfluence($GuardRecord[6],8);//右门B
			$GuardRecord[7].SafeDeleteObject(); $GuardRecord[7] = SpNewNpc2(0, 411192001, "28.088 152.222 100.176", 0, 180); SetNpcInfluence($GuardRecord[7],8);//右门进来守卫
			$GuardRecord[8].SafeDeleteObject(); $GuardRecord[8] = SpNewNpc2(0, 411192001, "-28.0139 152.241 100.176", 0, 180); SetNpcInfluence($GuardRecord[8], 8);//左门进来守卫
			$GuardRecord[9].SafeDeleteObject(); $GuardRecord[9] = SpNewNpc2(0, 411192001, "-5.58255 153.813 100.176", 0, 90); SetNpcInfluence($GuardRecord[9], 8);//皇宫台阶下守卫1
			$GuardRecord[10].SafeDeleteObject(); $GuardRecord[10] = SpNewNpc2(0, 411192001, "5.53448 153.986 100.176", 0, 270); SetNpcInfluence($GuardRecord[10], 8);//皇宫台阶下守卫2
			$GuardRecord[11].SafeDeleteObject(); $GuardRecord[11] = SpNewNpc2(0, 411192001, "-9.56103 105.187 100.215", 0, 90); SetNpcInfluence($GuardRecord[11], 8);//正门进来守卫1
			$GuardRecord[12].SafeDeleteObject(); $GuardRecord[12] = SpNewNpc2(0, 411192001, "9.60087 105.141 100.215", 0, 270); SetNpcInfluence($GuardRecord[12], 8);//正门进来守卫2
			$GuardRecord[13].SafeDeleteObject(); $GuardRecord[13] = SpNewNpc2(0, 411192001, "-9.0827 125.362 100.215", 0, 90); SetNpcInfluence($GuardRecord[13], 8);//大牌子下面守卫1
			$GuardRecord[14].SafeDeleteObject(); $GuardRecord[14] = SpNewNpc2(0, 411192001, "8.82353 125.362 100.215", 0, 270); SetNpcInfluence($GuardRecord[14], 8);//大牌子下面守卫2

			$GuardRecord[811190111, 2].SafeDeleteObject(); $GuardRecord[811190111, 2] = SpNewNpc2(0, 411190022, "-0.0547 177.037 102.691", 0, 180);//皇宫正门传送门
			$GuardRecord[811190112, 2].SafeDeleteObject(); $GuardRecord[811190112, 2] = SpNewNpc2(0, 411190022, "11.0838 186.349 102.688", 0, 270);//皇宫右门传送门
			$GuardRecord[811190113, 2].SafeDeleteObject(); $GuardRecord[811190113, 2] = SpNewNpc2(0, 411190022, "-11.615 186.444 102.688", 0, 90);//皇宫左门传送门
			$GuardRecord[811190111, 1].SafeDeleteObject(); $GuardRecord[811190111, 1] = SpNewNpc2(0, 411193026, "0.0891171 171.63 102.299", 0, 180); SetNpcInfluence($GuardRecord[811190111, 1], 8);// 皇宫正门的守卫
			$GuardRecord[811190112, 1].SafeDeleteObject(); $GuardRecord[811190112, 1] = SpNewNpc2(0, 411193027, "14.761 186.525 102.299", 0, 090); SetNpcInfluence($GuardRecord[811190112, 1], 8);// 皇宫右门的守卫
			$GuardRecord[811190113, 1].SafeDeleteObject(); $GuardRecord[811190113, 1] = SpNewNpc2(0, 411193028, "-15.1327 186.641 102.299", 0, 270); SetNpcInfluence($GuardRecord[811190113, 1], 8);// 皇宫左门的守卫
				

			%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//获取守城方
			$NowGuardOrgID = %OrgIDA;//设置默认的皇宫占领方
			if (%OrgIDA <= 0)//没有守城方，系统守城
			{
				$MonsterRecord[1119, 0].SafeDeleteObject(); $MonsterRecord[1119, 0] = SpNewNpc2(0, 411193000, "-224.028 -207.323 80.4479", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[0], 8);//皇宫内的怪物
				$MonsterRecord[1119, 1].SafeDeleteObject(); $MonsterRecord[1119, 1] = SpNewNpc2(0, 411193001, "-211.861 -193.892 80.4479", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[1], 8);//皇宫内的怪物
				$MonsterRecord[1119, 2].SafeDeleteObject(); $MonsterRecord[1119, 2] = SpNewNpc2(0, 411193002, "-197.351 -206.463 80.4479", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[2], 8);//皇宫内的怪物
				$MonsterRecord[1119, 3].SafeDeleteObject(); $MonsterRecord[1119, 3] = SpNewNpc2(0, 411193003, "-188.981 -186.868 80.4479", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[3], 8);//皇宫内的怪物
				$MonsterRecord[1119, 4].SafeDeleteObject(); $MonsterRecord[1119, 4] = SpNewNpc2(0, 411193004, "-227.573 -184.843 80.4479", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[4], 8);//皇宫内的怪物
				$MonsterRecord[1119, 5].SafeDeleteObject(); $MonsterRecord[1119, 5] = SpNewNpc2(0, 411193005, "-232.540 -229.140 80.4479", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[5], 8);//皇宫内的怪物
				$MonsterRecord[1119, 6].SafeDeleteObject(); $MonsterRecord[1119, 6] = SpNewNpc2(0, 411193006, "-190.693 -226.349 80.4479", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[6], 8);//皇宫内的怪物
				$MonsterRecord[1119, 7].SafeDeleteObject(); $MonsterRecord[1119, 7] = SpNewNpc2(0, 411193007, "-210.748 -231.197 80.4479", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[7], 8);//皇宫内的怪物
				$MonsterRecord[1119, 8].SafeDeleteObject(); $MonsterRecord[1119, 8] = SpNewNpc2(0, 411193008, "-210.730 -181.239 80.4479", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[8], 8);//皇宫内的怪物
				$MonsterRecord[1119, 9].SafeDeleteObject(); $MonsterRecord[1119, 9] = SpNewNpc2(0, 411193009, "-211.266 -207.838 82.9667", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[9], 8);//皇宫内的怪物
				$MonsterRecord[1119, 10].SafeDeleteObject(); $MonsterRecord[1119, 10] = SpNewNpc2(0, 411193010, "-0.13025 48.3029 98.642", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[10], 8);//皇宫外的怪物 正门大门口
				$MonsterRecord[1119, 11].SafeDeleteObject(); $MonsterRecord[1119, 11] = SpNewNpc2(0, 411193011, "2.40701 98.6541 100.187", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[11], 8);//皇宫外的怪物 正门进去
				$MonsterRecord[1119, 12].SafeDeleteObject(); $MonsterRecord[1119, 12] = SpNewNpc2(0, 411193012, "-32.2409 91.854 100.187", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[12], 8);//皇宫外的怪物
				$MonsterRecord[1119, 13].SafeDeleteObject(); $MonsterRecord[1119, 13] = SpNewNpc2(0, 411193013, "34.4879 90.5260 100.187", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[13], 8);//皇宫外的怪物
				$MonsterRecord[1119, 14].SafeDeleteObject(); $MonsterRecord[1119, 14] = SpNewNpc2(0, 411193014, "46.0869 108.767 100.152", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[14], 8);//皇宫外的怪物
				$MonsterRecord[1119, 15].SafeDeleteObject(); $MonsterRecord[1119, 15] = SpNewNpc2(0, 411193015, "37.3157 181.582 100.209", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[15], 8);//皇宫外的怪物
				$MonsterRecord[1119, 16].SafeDeleteObject(); $MonsterRecord[1119, 16] = SpNewNpc2(0, 411193016, "37.6171 150.025 100.223", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[16], 8);//皇宫外的怪物
				$MonsterRecord[1119, 17].SafeDeleteObject(); $MonsterRecord[1119, 17] = SpNewNpc2(0, 411193017, "0.23341 145.325 100.225", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[17], 8);//皇宫外的怪物  城正中心
				$MonsterRecord[1119, 18].SafeDeleteObject(); $MonsterRecord[1119, 18] = SpNewNpc2(0, 411193018, "-42.125 144.052 100.225", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[18], 8);//皇宫外的怪物
				$MonsterRecord[1119, 19].SafeDeleteObject(); $MonsterRecord[1119, 19] = SpNewNpc2(0, 411193019, "-37.1622 173.473 100.20", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[19], 8);//皇宫外的怪物
				$MonsterRecord[1119, 20].SafeDeleteObject(); $MonsterRecord[1119, 20] = SpNewNpc2(0, 411193020, "-45.080 111.037 100.131", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[20], 8);//皇宫外的怪物
				$MonsterRecord[1119, 21].SafeDeleteObject(); $MonsterRecord[1119, 21] = SpNewNpc2(0, 411193021, "-24.292 114.785 100.042", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[21], 8);//皇宫外的怪物
				$MonsterRecord[1119, 22].SafeDeleteObject(); $MonsterRecord[1119, 22] = SpNewNpc2(0, 411193022, "26.6830 113.038 100.163", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[22], 8);//皇宫外的怪物
				$MonsterRecord[1119, 23].SafeDeleteObject(); $MonsterRecord[1119, 23] = SpNewNpc2(0, 411193023, "-4.5945 120.883 100.215", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[23], 8);//皇宫外的怪物
				$MonsterRecord[1119, 24].SafeDeleteObject(); $MonsterRecord[1119, 24] = SpNewNpc2(0, 411193024, "16.3514 201.885 102.299", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[24], 8);//皇宫外的怪物
				$MonsterRecord[1119, 25].SafeDeleteObject(); $MonsterRecord[1119, 25] = SpNewNpc2(0, 411193025, "-18.643 202.280 102.299", 0, GetRanDom(0,360)); SetNpcInfluence($GuardRecord[25], 8);//皇宫外的怪物
					
				

				%HuoDongMingCheng1 = GetHuoDongName("怪物攻城", 1);
				%Txt1 = "<t>由于没有守城方，本次封魔城攻城战采用</t>" @ %HuoDongMingCheng1 @ "<t>模式。</t>";
				SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Txt1 @ "</t>");
			}

			%PlayerCount = GetPlayerCount();
			for (%i = 0; %i < %PlayerCount; %i++)
			{
				%Player = GetPlayerByIndex(%i);
				if (isobject(%Player))
					InfluenceDispose(%Player);
			}

			%NextStep = 1;
			%Time = 60;
		case 1:

			%PlayerCount = GetPlayerCount();
			%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//获取守城方
			%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//获得今天攻城方
			$NowPalaceManNumber = 0;
			$NowOrgMemberNum[%OrgIDA] = 0;
			$NowOrgMemberNum[%OrgIDB] = 0;
			for (%i = 0; %i < %PlayerCount; %i++)
			{
				%Player = GetPlayerByIndex(%i);
				if (isobject(%Player))
				{
					if (%Player.GetTriggerID() $= "811190200" && %Player.GetDamageState() $= "Enabled")
					{
						%OrgID = SptOrg_GetOrgID(%Player.GetPlayerID());		//家族ID
						if ((%OrgID == %OrgIDA || %OrgID == %OrgIDB) && %OrgID > 0)
							$NowOrgMemberNum[%OrgID]++;
						$NowPalaceManNumber++;
					}
				}
			}


			%IsCanZhanLinh = 0;
			if ($NowPalaceManNumber == $NowOrgMemberNum[%OrgIDB] && $NowGuardOrgID != %OrgIDB && $NowGuardOrgID > 0)
			{
				%IsCanZhanLinh = 1;
				for (%i = 0; %i <= 9; %i++)
				{
					if ($MonsterRecord[1119, %i].GetDamageState() $= "Enabled")
					{
						%IsCanZhanLinh = 0;
						break;
					}
				}
				if (%IsCanZhanLinh == 1)
				{
					$NowGuardOrgID = %OrgIDB;//设置皇宫占领方
					%HuoDongMingCheng1 = GetHuoDongName("封魔城皇宫", 1);
					%HuoDongMingCheng2 = GetHuoDongName("封魔城皇宫", 2);
					%OrgName = SptOrg_GetName(%OrgIDB);		//家族名称
					if (%OrgName !$= "")
					{
						%OrgName1 = $Get_Dialog_GeShi[31421] @ "『" @ %OrgName @ "』</t>";
						%OrgName2 = $Get_Dialog_GeShi[60003] @ "『" @ %OrgName @ "』</t>";
						%Txt1 = "<t>帮派</t>" @ %OrgName1 @ "<t>占领了</t>" @ %HuoDongMingCheng1 @ "<t>，胜利在望！</t>";
						%Txt2 = "<t>帮派</t>" @ %OrgName2 @ "<t>占领了</t>" @ %HuoDongMingCheng2 @ "<t>，胜利在望！</t>";
						SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Txt1 @ "</t>");
						SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Txt2 @ "</t>", $chatMsg_Type_Normal2);
					}
				}
			}
			else if ($NowPalaceManNumber == $NowOrgMemberNum[%OrgIDA] && $NowGuardOrgID != %OrgIDA && $NowGuardOrgID > 0)
			{
				%IsCanZhanLinh = 1;
				for (%i = 0; %i <= 9; %i++)
				{
					if ($MonsterRecord[1119, %i].GetDamageState() $= "Enabled")
					{
						%IsCanZhanLinh = 0;
						break;
					}
				}
				if (%IsCanZhanLinh == 1)
				{
					$NowGuardOrgID = %OrgIDA;//设置皇宫占领方
					%HuoDongMingCheng1 = GetHuoDongName("封魔城皇宫", 1);
					%HuoDongMingCheng2 = GetHuoDongName("封魔城皇宫", 2);
					%OrgName = SptOrg_GetName(%OrgIDA);		//家族名称
					if (%OrgName !$= "")
					{
						%OrgName1 = $Get_Dialog_GeShi[31421] @ "『" @ %OrgName @ "』</t>";
						%OrgName2 = $Get_Dialog_GeShi[60003] @ "『" @ %OrgName @ "』</t>";
						%Txt1 = "<t>帮派</t>" @ %OrgName1 @ "<t>占领了</t>" @ %HuoDongMingCheng1 @ "<t>，胜利在望！</t>";
						%Txt2 = "<t>帮派</t>" @ %OrgName2 @ "<t>占领了</t>" @ %HuoDongMingCheng2 @ "<t>，胜利在望！</t>";
						SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Txt1 @ "</t>");
						SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Txt2 @ "</t>", $chatMsg_Type_Normal2);
					}
				}
				
			}
			
			echo("■■■■■■【封魔城】■■■■【每分钟统计】■■■■");
			echo("$NowPalaceManNumber===" @ $NowPalaceManNumber);
			echo("$NowGuardOrgID===" @ $NowGuardOrgID);
			echo("$NowOrgMemberNum[" @ %OrgIDA @ "]===" @ $NowOrgMemberNum[%OrgIDA]);
			echo("$NowOrgMemberNum[" @ %OrgIDB @ "]===" @ $NowOrgMemberNum[%OrgIDB]);

			%NextStep = 1;
			%Time = 60;

			%H = GetWord(GetLocalTime(), 3);	//小时
			%M = GetWord(GetLocalTime(), 4);	//小时
			if (%H == 21 && %M == 20)
			{
				%HuoDongMingCheng1 = GetHuoDongName("封魔城攻城战", 1);
				%HuoDongMingCheng2 = GetHuoDongName("封魔城攻城战", 2);
				%Text1 = %HuoDongMingCheng1 @ "<t>将于</t>" @ $Get_Dialog_GeShi[31420] @ "10</t><t>分钟后结束。</t>";
				%Text2 = %HuoDongMingCheng2 @ "<t>将于</t>" @ $Get_Dialog_GeShi[60002] @ "10</t><t>分钟后结束。</t>";
				SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
				SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
			}
			if (%H == 21 && %M == 29)
			{
				%HuoDongMingCheng1 = GetHuoDongName("封魔城攻城战", 1);
				%HuoDongMingCheng2 = GetHuoDongName("封魔城攻城战", 2);
				%Text1 = %HuoDongMingCheng1 @ "<t>将于</t>" @ $Get_Dialog_GeShi[31420] @ "1</t><t>分钟后结束。</t>";
				%Text2 = %HuoDongMingCheng2 @ "<t>将于</t>" @ $Get_Dialog_GeShi[60002] @ "1</t><t>分钟后结束。</t>";
				SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
				SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
				%NextStep = 2;
			}
		case 2://结束
			$IsAttackCityWar_State_bActive = 0;//标记结束
			%NextStep = 1;
			%Time = 0;
			//刷新所有NPC
			$NpcRecord[1].SafeDeleteObject(); $NpcRecord[1] = SpNewNpc2(0, 411190002, "26.479 121.168 100.905", 0, 180);//总镖头
			$NpcRecord[2].SafeDeleteObject(); $NpcRecord[2] = SpNewNpc2(0, 411190017, "30.266 109.866 100.163", 0, 270);//华千骨
			$NpcRecord[3].SafeDeleteObject(); $NpcRecord[3] = SpNewNpc2(0, 411190021, "26.009 106.013 100.167", 0, 0);//婉儿
			$NpcRecord[4].SafeDeleteObject(); $NpcRecord[4] = SpNewNpc2(0, 411190019, "-24.58 110.175 100.045", 0, 0);//邢秋
			$NpcRecord[5].SafeDeleteObject(); $NpcRecord[5] = SpNewNpc2(0, 411190018, "-29.65 114.936 100.043", 0, 90);//鲁匠师
			$NpcRecord[6].SafeDeleteObject(); $NpcRecord[6] = SpNewNpc2(0, 411190020, "-24.92 120.603 100.048", 0, 180);//邢月
			$NpcRecord[7].SafeDeleteObject(); $NpcRecord[7] = SpNewNpc2(0, 411190023, "-213.1 -209.62 82.9667", 0, 180);//封魔城管理员
			

			$GuardRecord[1].SafeDeleteObject(); $GuardRecord[1] = SpNewNpc2(0, 411192001, "-74.390 149.824 100", 0, 270); SetNpcInfluence($GuardRecord[1], 6);//左门A
			$GuardRecord[2].SafeDeleteObject(); $GuardRecord[2] = SpNewNpc2(0, 411192001, "-74.027 140.621 100", 0, 270); SetNpcInfluence($GuardRecord[2], 6);//左门B
			$GuardRecord[3].SafeDeleteObject(); $GuardRecord[3] = SpNewNpc2(0, 411192001, "-6.7458 62.7418 101", 0, 180); SetNpcInfluence($GuardRecord[3], 6);//正门A
			$GuardRecord[4].SafeDeleteObject(); $GuardRecord[4] = SpNewNpc2(0, 411192001, "6.87547 62.7418 101", 0, 180); SetNpcInfluence($GuardRecord[4], 6);//正门B
			$GuardRecord[5].SafeDeleteObject(); $GuardRecord[5] = SpNewNpc2(0, 411192001, "72.9715 140.391 100", 0, 090); SetNpcInfluence($GuardRecord[5], 6);//右门A
			$GuardRecord[6].SafeDeleteObject(); $GuardRecord[6] = SpNewNpc2(0, 411192001, "72.9566 149.813 100", 0, 090); SetNpcInfluence($GuardRecord[6], 6);//右门B
			$GuardRecord[7].SafeDeleteObject(); $GuardRecord[7] = SpNewNpc2(0, 411192001, "28.088 152.222 100.176", 0, 180); SetNpcInfluence($GuardRecord[7], 6);//右门进来守卫
			$GuardRecord[8].SafeDeleteObject(); $GuardRecord[8] = SpNewNpc2(0, 411192001, "-28.0139 152.241 100.176", 0, 180); SetNpcInfluence($GuardRecord[8], 6);//左门进来守卫
			$GuardRecord[9].SafeDeleteObject(); $GuardRecord[9] = SpNewNpc2(0, 411192001, "-5.58255 153.813 100.176", 0, 90); SetNpcInfluence($GuardRecord[9], 6);//皇宫台阶下守卫1
			$GuardRecord[10].SafeDeleteObject(); $GuardRecord[10] = SpNewNpc2(0, 411192001, "5.53448 153.986 100.176", 0, 270); SetNpcInfluence($GuardRecord[10], 6);//皇宫台阶下守卫2
			$GuardRecord[11].SafeDeleteObject(); $GuardRecord[11] = SpNewNpc2(0, 411192001, "-9.0827 101.712 100.187", 0, 90); SetNpcInfluence($GuardRecord[11], 6);//正门进来守卫1
			$GuardRecord[12].SafeDeleteObject(); $GuardRecord[12] = SpNewNpc2(0, 411192001, "8.82353 101.712 100.187", 0, 270); SetNpcInfluence($GuardRecord[12], 6);//正门进来守卫2
			$GuardRecord[13].SafeDeleteObject(); $GuardRecord[13] = SpNewNpc2(0, 411192001, "-9.0827 125.362 100.215", 0, 90); SetNpcInfluence($GuardRecord[13], 6);//大牌子下面守卫1
			$GuardRecord[14].SafeDeleteObject(); $GuardRecord[14] = SpNewNpc2(0, 411192001, "8.82353 125.362 100.215", 0, 270); SetNpcInfluence($GuardRecord[14], 6);//大牌子下面守卫2

			$GuardRecord[811190111, 1].SafeDeleteObject(); //皇宫正门的守卫
			$GuardRecord[811190112, 1].SafeDeleteObject(); //皇宫右门的守卫
			$GuardRecord[811190113, 1].SafeDeleteObject(); //皇宫左门的守卫
			$GuardRecord[811190111, 2].SafeDeleteObject(); $GuardRecord[811190111, 2] = SpNewNpc2(0, 411190022, "-0.0547 177.037 102.691", 0, 180);//皇宫正门传送门
			$GuardRecord[811190112, 2].SafeDeleteObject(); $GuardRecord[811190112, 2] = SpNewNpc2(0, 411190022, "11.0838 186.349 102.688", 0, 270);//皇宫右门传送门
			$GuardRecord[811190113, 2].SafeDeleteObject(); $GuardRecord[811190113, 2] = SpNewNpc2(0, 411190022, "-11.615 186.444 102.688", 0, 90);//皇宫左门传送门

			for (%i = 0; %i <=25; %i++)
			{
				if (isobject($MonsterRecord[1119,%i]))
					$MonsterRecord[1119,%i].SafeDeleteObject();
			}
			//战斗结束结算
			%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//获取守城方
			%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//获得今天攻城方
			if ($NowGuardOrgID == %OrgIDA && $NowGuardOrgID > 0)//守城成功
			{
				SptOrg_AttackCityFail(%OrgIDB);//攻城失败
				$AttackCityRecordDefend = %OrgIDA;
				%HuoDongMingCheng1 = GetHuoDongName("封魔城", 1);
				%HuoDongMingCheng2 = GetHuoDongName("封魔城", 2);
				%OrgName = SptOrg_GetName(%OrgIDA);		//家族名称
				%OrgName1 = $Get_Dialog_GeShi[31421] @ "『" @ %OrgName @ "』</t>";
				%OrgName2 = $Get_Dialog_GeShi[60003] @ "『" @ %OrgName @ "』</t>";
				%Txt1 = "<t>帮派</t>" @ %OrgName1 @ "<t>经过浴血奋战，成功守住了</t>" @ %HuoDongMingCheng1 @ "<t>，且问天下还有何人能挑战他们！</t>";
				%Txt2 = "<t>帮派</t>" @ %OrgName2 @ "<t>经过浴血奋战，成功守住了</t>" @ %HuoDongMingCheng2 @ "<t>，且问天下还有何人能挑战他们！</t>";
				SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Txt1 @ "</t>");
				SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Txt2 @ "</t>", $chatMsg_Type_Normal2);
			}
			else if ($NowGuardOrgID == %OrgIDB && $NowGuardOrgID > 0)//攻城成功
			{
				SptOrg_AttackCitySuccess(%OrgIDB);//攻城成功
				$AttackCityRecordDefend = %OrgIDB;
				%HuoDongMingCheng1 = GetHuoDongName("封魔城", 1);
				%HuoDongMingCheng2 = GetHuoDongName("封魔城", 2);
				%OrgName = SptOrg_GetName(%OrgIDB);		//家族名称
				%OrgName1 = $Get_Dialog_GeShi[31421] @ "『" @ %OrgName @ "』</t>";
				%OrgName2 = $Get_Dialog_GeShi[60003] @ "『" @ %OrgName @ "』</t>";
				%Txt1 = "<t>帮派</t>" @ %OrgName1 @ "<t>经过浴血奋战，成功占领了</t>" @ %HuoDongMingCheng1 @ "<t>，名传寰宇，威震天下。</t>";
				%Txt2 = "<t>帮派</t>" @ %OrgName2 @ "<t>经过浴血奋战，成功占领了</t>" @ %HuoDongMingCheng2 @ "<t>，名传寰宇，威震天下。</t>";
				SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Txt1 @ "</t>");
				SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Txt2 @ "</t>", $chatMsg_Type_Normal2);
			}
			else if (%OrgIDA > 0)//默认攻城就是失败的
			{
				SptOrg_AttackCityFail(%OrgIDB);//攻城失败
				$AttackCityRecordDefend = %OrgIDA;
				%HuoDongMingCheng1 = GetHuoDongName("封魔城", 1);
				%HuoDongMingCheng2 = GetHuoDongName("封魔城", 2);
				%OrgName = SptOrg_GetName(%OrgIDA);		//家族名称
				%OrgName1 = $Get_Dialog_GeShi[31421] @ "『" @ %OrgName @ "』</t>";
				%OrgName2 = $Get_Dialog_GeShi[60003] @ "『" @ %OrgName @ "』</t>";
				%Txt1 = "<t>帮派</t>" @ %OrgName1 @ "<t>经过浴血奋战，成功守住了</t>" @ %HuoDongMingCheng1 @ "<t>，谁还能继续挑战他们？</t>";
				%Txt2 = "<t>帮派</t>" @ %OrgName2 @ "<t>经过浴血奋战，成功守住了</t>" @ %HuoDongMingCheng2 @ "<t>，谁还能继续挑战他们？</t>";
				SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Txt1 @ "</t>");
				SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Txt2 @ "</t>", $chatMsg_Type_Normal2);
			}
			%PlayerCount = GetPlayerCount();
			for (%i = 0; %i < %PlayerCount; %i++)
			{
				%Player = GetPlayerByIndex(%i);
				if (isobject(%Player))
					InfluenceDispose(%Player);
			}
	}
	if (%Time > 0)
		$AttackCityWarStates = schedule(%Time * 1000, 0, "AttackCityWarStates", %NextStep);
}
function SetNpcInfluence(%Caster, %Influence)
{
	CanCel(%Caster.SetInfluence);
	%Caster.SetInfluence =	Schedule(3000, 0, "eval", %Caster @ ".SetInfluence(" @ "\"" @ %Influence @ "\"" @ "); ");
}
//■■■■■■■【封魔城】■■■■【城战流程过程】■■■■■■■■


//■■■■■■■【封魔城】■■■■【玩家复活触发】■■■■■■■■

function PlayerSetEnabled_1119(%Player)
{
	//echo("■■【封魔城】■■■■【玩家复活触发】■■");
	//复活玩家
	if (%Player.GetDamageState() $= "Disabled")
	{
		//传送到复活点
		%Posx = GetRandom(-5, 5);
		%Posy = GetRandom(140, 150);
		%Player.TransportObject(0, 0, %Posx, %Posy, 100.225);
		//死亡复活
		%Player.SetDamageState(Enabled);
		//添加回血状态
		%Player.AddBuff(399020200, %Player, 50);

	}
}
//■■■■■■■【封魔城】■■■■【玩家复活触发】■■■■■■■■


//■■■■■■■【封魔城】■■■■【进出区域触发】■■■■■■■■
function PlayerEnterTrigger_811190200(%Player, %TriggerId)//进入皇宫
{
	%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//获取守城方
	%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//获得今天攻城方
	%OrgID = SptOrg_GetOrgID(%Player.GetPlayerID());		//家族ID
	if ((%OrgID == %OrgIDA || %OrgID == %OrgIDB) && %OrgID > 0)
		$NowOrgMemberNum[%OrgID]++;
	$NowPalaceManNumber++;
	echo("■■■■■■【封魔城】■■■■【进入皇宫触发】■■■■");
	echo("$NowPalaceManNumber===" @ $NowPalaceManNumber);
	echo("$NowOrgMemberNum[" @ %OrgID @ "]===" @ $NowOrgMemberNum[%OrgID]);
	if ($IsAttackCityWar_State_bActive == 1)
	{
		if (($NowPalaceManNumber == $NowOrgMemberNum[%OrgIDA] && $NowGuardOrgID != %OrgIDA) || ($NowPalaceManNumber == $NowOrgMemberNum[%OrgIDB] && $NowGuardOrgID != %OrgIDB))
		{
			for (%i = 0; %i <= 9; %i++)
			{
				if ($MonsterRecord[1119, %i].GetDamageState() $= "Enabled")
					return;
			}
			$AttackCityWarStates = schedule(1000, 0, "AttackCityWarStates", 1);
		}
	}
}
function PlayerOnExitTrigger_811190200(%Player)
{
	%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//获取守城方
	%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//获得今天攻城方
	%OrgID = SptOrg_GetOrgID(%Player.GetPlayerID());		//家族ID
	if ($NowOrgMemberNum[%OrgID] > 0)
		$NowOrgMemberNum[%OrgID]--;
	$NowPalaceManNumber--;

	echo("■■■■■■【封魔城】■■■■【离开皇宫触发】■■■■");
	echo("$NowPalaceManNumber===" @ $NowPalaceManNumber);
	echo("$NowOrgMemberNum[" @ %OrgID @ "]===" @ $NowOrgMemberNum[%OrgID]);

	if ($IsAttackCityWar_State_bActive == 1)
	{
		if (($NowPalaceManNumber == $NowOrgMemberNum[%OrgIDA] && $NowGuardOrgID != %OrgIDA) || ($NowPalaceManNumber == $NowOrgMemberNum[%OrgIDB] && $NowGuardOrgID != %OrgIDB))
		{
			for (%i = 0; %i <= 9; %i++)
			{
				if ($MonsterRecord[1119, %i].GetDamageState() $= "Enabled")
					return;
			}
			$AttackCityWarStates = schedule(1000, 0, "AttackCityWarStates", 1);
		}
	}
}
function PlayerEnterTrigger_811190111(%Player, %TriggerId){ PlayerEnterTrigger_811190111_811190113(%Player, %TriggerId); }//正门 -0.0547 177.037 102.691
function PlayerEnterTrigger_811190112(%Player, %TriggerId){ PlayerEnterTrigger_811190111_811190113(%Player, %TriggerId); }//右门 11.0838 186.349 102.688
function PlayerEnterTrigger_811190113(%Player, %TriggerId){ PlayerEnterTrigger_811190111_811190113(%Player, %TriggerId); }//左门 -11.615 186.444 102.688
function PlayerEnterTrigger_811190111_811190113(%Player, %TriggerId)
{
	if ($IsAttackCityWar_State_bActive == 1)//攻城期间
	{
		if ($GuardRecord[%TriggerId, 1].GetDamageState() !$= "Enabled")//没有守卫，进皇宫
			TransObjectToPalace(%Player, %TriggerId);
		else
		{
			if (%Player.GetInfluence() == 2 || %Player.GetInfluence() == 4 || %Player.GetInfluence() == 6 || %Player.GetInfluence() == 8)
				TransObjectToPalace(%Player, %TriggerId);
			else
			{
				SendOneScreenMessage(2, "需要先击败传送门守卫", %Player);
				SendOneChatMessage($chatMsg_System, "<t>需要先击败传送门守卫，才进入皇宫。</t>", %Player);
				return;
			}
		}
			
	}
	else//非攻城时间
	{
		if (%Player.GetInfluence() == 2 || %Player.GetInfluence() == 4 || %Player.GetInfluence() == 6 || %Player.GetInfluence() == 8)
			TransObjectToPalace(%Player,0);
		else
		{
			SendOneScreenMessage(2, "您不是封魔城帮派成员，无法进入皇宫", %Player);
			SendOneChatMessage($chatMsg_System, "<t>您不是封魔城帮派成员，无法进入皇宫。</t>", %Player);
			return;
		}
	}
}
function TransObjectToPalace(%Player,%Step)//传送进入皇宫
{
	switch (%Step)
	{
		case 0:%Player.TransportObject(0, 0, -210.912, -219.086, 80.4479);
		case 811190111:%Player.TransportObject(0, 0, -210.734, -232.243, 80.4479);
		case 811190112:%Player.TransportObject(0, 0, -186.717, -206.633, 80.4479);
		case 811190113:%Player.TransportObject(0, 0, -234.048, -206.425, 80.4479);
	}
}
//■■■■■■■【封魔城】■■■■【进出区域触发】■■■■■■■■



//■■■■■■■【封魔城】■■■■【攻城怪物被击败】■■■■■■■
function NpcObjectonDeathcast_411193000(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193001(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193002(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193003(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193004(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193005(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193006(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193007(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193008(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193009(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193010(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193011(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193012(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193013(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193014(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193015(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193016(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193017(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193018(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193019(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193020(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193021(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193022(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193023(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193024(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193025(%Monster, %Killer){ NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer); }
function NpcObjectonDeathcast_411193000_411193025(%Monster, %Killer)
{
	for (%i = 0; %i <= 9; %i++)
	{
		if ($MonsterRecord[1119,%i].GetDamageState() $= "Enabled")
			return;
	}
	if ($IsAttackCityWar_State_bActive != 1)
		return;
	%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//获得今天攻城方
	$NowGuardOrgID = %OrgIDB;
	AttackCityWarStates(2);
	
}

function NpcObjectonDeathcast_411193026(%Monster, %Killer)//皇宫正门的守卫
{
	$GuardRecord[811190111, 1].SafeDeleteObject();
	//$GuardRecord[811190111, 2].SafeDeleteObject(); $GuardRecord[811190111, 2] = SpNewNpc2(0, 411190022, "-0.0547 177.037 102.691", 0, 0);//皇宫正门传送门
}
function NpcObjectonDeathcast_411193027(%Monster, %Killer)//皇宫右门的守卫
{
	$GuardRecord[811190112, 2].SafeDeleteObject();
	//$GuardRecord[811190112, 2].SafeDeleteObject(); $GuardRecord[811190112, 2] = SpNewNpc2(0, 411190022, "11.0838 186.349 102.688", 0, 0);//皇宫右门传送门
}
function NpcObjectonDeathcast_411193028(%Monster, %Killer)//皇宫左门的守卫
{
	$GuardRecord[811190113, 2].SafeDeleteObject();
	//$GuardRecord[811190113, 2].SafeDeleteObject(); $GuardRecord[811190113, 2] = SpNewNpc2(0, 411190022, "-11.615 186.444 102.688", 0, 0);//皇宫左门传送门
}
//■■■■■■■【封魔城】■■■■【攻城怪物被击败】■■■■■■■

//■■■■■■■【封魔城】■■■■【管理员NPC对话 】■■■■■■■
function NpcDiaLog_411190023(%Npc, %Player, %State, %Conv)
{
	switch (%State)
	{
		case 0:
			%Conv.AddOption(100086, 100086);//称号领取
		case 100086:
			%Conv.Settype(4);
			%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//获取守城方
			%OrgID = SptOrg_GetOrgID(%Player.GetPlayerID());		//家族ID
			if (%OrgIDA != %OrgID && %OrgID > 0)
				return;
			%MemberLevel = %Player.GetOrgMemberLevel(1);
			switch (%MemberLevel)
			{
				//1664	封魔仙兵 1665	封魔仙卫 1666	封魔仙将 1667	封魔城主
				case 0:%Des = 1664;//新进帮众
				case 1:%Des = 1664;//普通成员
				case 2:%Des = 1665;//高级成员
				case 3:%Des = 1665;//精英成员
				case 4:%Des = 1666;//元老成员
				case 5:%Des = 1666;//副帮主
				case 6:%Des = 1667;//帮主
			}
			if (!%Player.sptIsDesignationExist(%Des))
			{
				%Player.AddDesignation(%Des);//添加称号
				%Player.SetCurDesignationIDZone(%Des);//设置此称号为当前正在使用的称号
				SendOneScreenMessage(1, "领取成功", %Player);
			}
	}
}
//■■■■■■■【封魔城】■■■■【管理员NPC对话 】■■■■■■■


//■■■■■■■【封魔城】■■■■【称号清理】■■■■■■■■■■
function Refresh_FengMoCityDesignation(%Player)
{


	%OrgID = SptOrg_GetOrgID(%Player.GetPlayerID());		//家族ID
	for (%des = 1664; %des <= 1667; %des++)
	{
		if (%Player.sptIsDesignationExist(%Des) && %OrgID != $AttackCityRecordDefend)
			%Player.DelDesignation(%Des);
	}
}
//■■■■■■■【封魔城】■■■■【称号清理】■■■■■■■■■■

//■■■■■■■【封魔城】■■■■【城主雕像】■■■■■■■■■■
function Refresh_CityOwner()
{
	%MapID = GetZoneID();
	if (%MapID != 1001)
		return;
	if (!isobject($CityOwner) && $AttackCityRecordDefend > 0)
	{

		%MasterID = SptOrg_GetMaster($AttackCityRecordDefend);//族长ID

		%OrgName = SptOrg_GetName($AttackCityRecordDefend);
		%PlayerName = "";
		%PlayerSex = 1;
		switch (%PlayerSex)
		{
			case 1:%Npcid = 410010226;
			case 2:%Npcid = 410010227;
			default:%Npcid = 410010225;
		}

		$CityOwner = SpNewNpc2(0, %Npcid, "-8.88375 1.40263 194.489", 0, 90);
		$CityOwner.SetShapeName(%PlayerName);//设置名称为：占领方帮主名称
		$CityOwner.SetExclusivePlayerName(%OrgName);//设置称号为：占领方帮派名称（暂用）
	}
}
