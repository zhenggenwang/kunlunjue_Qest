//■■■■■■■■■■■怪物死亡触发脚本■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■特殊怪物死亡触发脚本■■■■■■■■■■■■■■■■
//■■■■■■■■■■■怪物死亡所有玩家触发■■■■■■■■■■■■■■■■
//■■■■■■■■■■■怪物被最后一击击败触发■■■■■■■■■■■■■■■


//■■■■■■■■■■■怪物死亡触发脚本■■■■■■■■■■■■■■■■■■
//怪物死亡触发脚本
function NpcObject::Killed(%Monster,%Player,%SharePlayerNum,%MaxConnection)
{
	%MapID = GetZoneID();								//当前地图编号
	%MonsterID = %Monster.GetDataID();	//获取怪物的编号
	//	 echo("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"@%MonsterID);
	//执行特殊怪物死亡触发函数
	//请在后面独立添加函数
	//■■■■■■■■■■■特殊怪物死亡触发脚本■■■■■■■■■■■■■■■■
	%FuncName = "KilledMonster_" @ %MonsterID;
	if (isFunction(%FuncName))
		eval(%FuncName @ "(%Player, %Monster, %SharePlayerNum, %MaxConnection);");

	//判断此怪物是否有归属
	if (%Player == 0)
		return;

	%MonsterLeve = %Monster.GetLevel();	//获取怪物等级
	%PlayerLeve = %Player.GetLevel();		//获取玩家等级
	%PlayerID = %Player.GetPlayerID();	//获取玩家的编号

	%PetID = %Player.GetSpawnedPet();		//获取宠物编号
	%PetLeve = %PetID.GetLevel();				//获取宠物等级

	%CopyMapID = %Player.GetLayerId();	//获取副本层
	%CopymapDataID = SptGetCopymapDataId(%CopyMapID);	//获取副本DataID
	//■■■■■■■■■■■剧情副本排行系统：怪物死亡时触发■■■■■■■■■■■■■■■■
	for (%i=1; %i<=100; %i++)
	{
		if ($JuQingRanking_MapID[%i] == 0)
			break;

		if ((%CopymapDataID == $JuQingRanking_MapID[%i]) && ($JuQingRanking_Passed[%CopyMapID] == 0))
		{
			if (%Monster.MonsterDeath == 0)
			{
				%Monster.MonsterDeath = 1;
				$JuQingRanking_MonsterDeath[%CopyMapID]++;
				break;
			}
		}
	}

	//■■■■■■■■■■■给予师德相关脚本■■■■■■■■■■■■■■■■

	//■■■■■■■■■■■玩家经验计算脚本■■■■■■■■■■■■■■■■
	%Share = $SharePlayerNum[1,%SharePlayerNum] / %SharePlayerNum;//分析系数
	%SendTimeS = 1;
	//获取怪物Data内怪物经验（ 小于100 经验削减、等于100正常经验、大于100翻倍经验、等于0获得1点经验）
	%Exp_Box = GetNpcData(%MonsterID,$Monster_Data_PlayerExp) / 100;
	if (%Exp_Box == 0)
		%Exp = 1;
	else
		%Exp = $Monster_Exp[%MonsterLeve,1] * %Exp_Box; //怪物基础经验模板
	//echo( "%Exp_Box ==" @ %Exp_Box );
	//echo( "%Exp ==" @ %Exp );
	//【基础经验*等级削减*队伍削减*（1+最大关系加成）】
	%Player_Exp = %Exp * %Share * (1 + %MaxConnection);

	//echo( "基础经验%Player_Exp===" @ %Player_Exp );
	//---------累加的倍数计算------------
	%Exp_LeiJiaBeiShu = 0;
	if (%Player.ISschbuff(1997)) %Exp_LeiJiaBeiShu = 1;	  //经验丹的加成
	else if (%Player.ISschbuff(1998)) %Exp_LeiJiaBeiShu = 1.5; //经验丹的加成
	else if (%Player.ISschbuff(1999)) %Exp_LeiJiaBeiShu = 2;	  //经验丹的加成

	if (%CopymapDataID == 1301)
	{
		if (%Player.ISschbuff($XingHunSchbuff[1])) %Exp_LeiJiaBeiShu = %Exp_LeiJiaBeiShu + 0;			 //时空裂痕星魂的加成
		else if (%Player.ISschbuff($XingHunSchbuff[2])) %Exp_LeiJiaBeiShu = %Exp_LeiJiaBeiShu + 0.5;	 //时空裂痕星魂的加成
		else if (%Player.ISschbuff($XingHunSchbuff[3])) %Exp_LeiJiaBeiShu = %Exp_LeiJiaBeiShu + 0.8;	 //时空裂痕星魂的加成
		else if (%Player.ISschbuff($XingHunSchbuff[4])) %Exp_LeiJiaBeiShu = %Exp_LeiJiaBeiShu + 1.5;	 //时空裂痕星魂的加成
		else if (%Player.ISschbuff($XingHunSchbuff[5])) %Exp_LeiJiaBeiShu = %Exp_LeiJiaBeiShu + 3;	 //时空裂痕星魂的加成
	}
	if (%CopymapDataID == 1311)
	{
		if ($SptCopymap_1311_BoShuRecord[%CopyMapID] == 1) %Exp_LeiJiaBeiShu = %Exp_LeiJiaBeiShu;		 //血魔封印阵波数加成
		else if ($SptCopymap_1311_BoShuRecord[%CopyMapID] == 2) %Exp_LeiJiaBeiShu = %Exp_LeiJiaBeiShu + 0.2;	 //血魔封印阵波数加成
		else if ($SptCopymap_1311_BoShuRecord[%CopyMapID] == 3) %Exp_LeiJiaBeiShu = %Exp_LeiJiaBeiShu + 0.4;	 //血魔封印阵波数加成
		else if ($SptCopymap_1311_BoShuRecord[%CopyMapID] == 4) %Exp_LeiJiaBeiShu = %Exp_LeiJiaBeiShu + 0.6;	 //血魔封印阵波数加成
		else if ($SptCopymap_1311_BoShuRecord[%CopyMapID] == 5) %Exp_LeiJiaBeiShu = %Exp_LeiJiaBeiShu + 0.8;	 //血魔封印阵波数加成
		else if ($SptCopymap_1311_BoShuRecord[%CopyMapID] == 6) %Exp_LeiJiaBeiShu = %Exp_LeiJiaBeiShu + 1.0;	 //血魔封印阵波数加成
	}
	//echo( "%Exp_LeiJiaBeiShu===" @ %Exp_LeiJiaBeiShu );
	//---------累乘的倍数计算------------
	%Exp_LeiChenBeiShu = 1;

	if (%CopymapDataID == 1311)//血魔封印阵的怪物解封后经验翻1倍
	{
		if (%Monster.GetBuffCount(39008,1) == 0)
		{
			%Exp_LeiChenBeiShu = %Exp_LeiChenBeiShu * 2;
			%SendTimeS = 2;
		}
	}

	%Exp_LeiChenBeiShu = %Exp_LeiChenBeiShu * GetShiJieLevelJiaChengNum(%Player);//世界等级加成
	//echo( "%Exp_LeiChenBeiShu===" @ %Exp_LeiChenBeiShu );
	//---------玩家经验最终结算----------

	%Player_Exp = %Player_Exp * (1 + %Exp_LeiJiaBeiShu) * %Exp_LeiChenBeiShu;
	//echo( "%Player_Exp 11111111 ===" @ %Player_Exp );
	
	//等级消减
	%Ply_Difference_Mon = Mabs(%PlayerLeve - %MonsterLeve);
	if(%Ply_Difference_Mon > 14)
	{
		%Player_Exp = 1;
	}
	else if(%Ply_Difference_Mon > 8)
	{
		%Player_Exp = Mfloor(%Player_Exp * $MonDifferencePly_Exp[%Ply_Difference_Mon]);
	}
	//echo( "%Player_Exp 2222222 ===" @ %Player_Exp );
	
	if (%Player_Exp > 0)
	{
		//增加经验
		if (%SendTimeS > 1)
		{
			%Player_Exp = Mceil(%Player_Exp/%SendTimeS);
			for (%i = 1; %i <= %SendTimeS; %i++)
			{
				AllAddExp(%Player,%Player_Exp);
				if (%i > 1)
					SendOneChatMessage($chatMsg_Person,"<t>本次击败额外获得经验加成</t>",%Player);
			}
		}
		else AllAddExp(%Player,%Player_Exp);

		//等级不低于玩家10级
		if (%MonsterLeve >= %PlayerLeve - 10)
		{
			//增加家族活跃度
			AddHappyFlyLv(%Player,1);
		}
	}
	//■■■■■■■■■■■神兽经验计算脚本■■■■■■■■■■■■■■■■
	if (GetNpcData(%MonsterID,$Monster_Data_PetExp) != 0)
	{
		//等级差值削减公式
		%LeveXz = (%PetLeve >= %MonsterLeve) ? %PetLeve - %MonsterLeve : %MonsterLeve - %PetLeve;

		//计算削减额度（10级以内无削减、10 - 14削减0.9至0.6、在高削减0.5）
		if (%LeveXz <= 10)%XY_Exp = 1;
		else if (%LeveXz >= 15)%XY_Exp = 0.5;
		else %XY_Exp = (1 - ((%LeveXz - 10) * 10) / 100);

		//获取怪物Data内怪物经验（ 小于100 经验削减、等于100正常经验、大于100翻倍经验、等于0获得1点经验）
		%Exp_Box = GetNpcData(%MonsterID,$Monster_Data_PetExp) / 100;

		if (%Exp_Box == 0)
			%Exp = 1;
		else
			%Exp = $Monster_Exp[%MonsterLeve,2] * %Exp_Box;

		//宠物经验
		if (%Team_Pet_Exp > 0)
			%Player.AddPetExp(%Player.GetSpawnedPetSlot(),%Team_Pet_Exp);
	}

	//■■■■■■■■■■■化神经验计算脚本■■■■■■■■■■■■■■■■
	%AvatarExp = $Monster_AvatarExp[%MonsterLeve];
	if (%AvatarExp > 0)
		%Player.Avatar_AddExp(%AvatarExp);
	//■■■■■■■■■■■活动触发相关脚本■■■■■■■■■■■■■■■■

	if (%Monster.MissionKill[%Player] == 1)
		%Monster.MissionKill[%Player] = 0;
	else
	{
		//开始处理所有的怪物计数
		Schedule(GetRandom(100,500),0,"AllMonster_By_MissionKill",%Monster,%Player,%MonsterID);		//所有怪物统一处理的任务计数
		Schedule(GetRandom(100,500),0,"AllMonster_By_ShengQiKill",%MonsterLeve,%PlayerLeve,%Player);	//其他杀怪计数统一触发
	}
}


//所有怪物统一处理的任务计数
function AllMonster_By_MissionKill(%Monster,%Player,%MonsterID)
{
	%MonsterKill_Mid = GetMonsterMission(%MonsterID);
	%MonsterKill_Mid_Num = GetWordCount(%MonsterKill_Mid);
	//echo( "%MonsterKill_Mid ===" @ %MonsterKill_Mid );
	//自动匹配当前编号的怪物，查找相应任务并执行杀怪计数
	for (%a = 0; %a < %MonsterKill_Mid_Num; %a++)
	{
		%Mid = GetWord(%MonsterKill_Mid,%a);

		if (%Player.IsAcceptedMission(%Mid))
		{
			for (%i = 0; %i < 50; %i++)
			{
				%misVal = %Player.GetMissionFlag(%Mid,3100 + %i);

				if (%misVal > 0)
				{
					if (%misVal $= %MonsterID)
					{
						%MaxFlag = %Player.GetMissionFlag(%Mid,3200 + %i);
						%MinFlag = %Player.GetMissionFlag(%Mid,3300 + %i);

						if (%MinFlag < %MaxFlag)
						{
							%Player.SetMissionFlag(%Mid,3300 + %i,%MinFlag + 1); //设置,怪物当前数量
							Cancel($AllMonster_By_MissionKill_UpData[%Player,%Mid]);
							$AllMonster_By_MissionKill_UpData[%Player,%Mid] = Schedule(600,0,"UpData_Mission",%Player,%Mid,%MonsterID,%MinFlag + 1,%MaxFlag);
						}
					}
				}
				else
					break;
			}
		}
	}
}

//神兵任务杀怪计数统一触发
function AllMonster_By_ShengQiKill(%MonsterLeve,%PlayLv,%Player)
{
	%MapID = GetZoneid();

	if (%Player.IsAcceptedMission(20029) && %MapID == 1128) %Mid = 20029;
	if (%Player.IsAcceptedMission(20030) && %MapID == 1129) %Mid = 20030;
	if (%Player.IsAcceptedMission(20031) && %MapID == 1130) %Mid = 20031;
	if (%Player.IsAcceptedMission(20032) && %MapID == 1131) %Mid = 20032;
	if (%Player.IsAcceptedMission(20033) && %MapID == 1132) %Mid = 20033;
	if (%Player.IsAcceptedMission(20034) && %MapID == 1133) %Mid = 20034;
	if (%Player.IsAcceptedMission(20035) && %MapID == 1134) %Mid = 20035;
	if (%Player.IsAcceptedMission(%Mid))
	{
		%Mission1201 = %Player.GetMissionFlag(%Mid,1200);	//总共数量
		%Mission1301 = %Player.GetMissionFlag(%Mid,1300);	//当前数量
		if (%Mission1301 < 9999)
		{
			//修改旗标
			%Player.SetMissionFlag(%Mid,1300,%Mission1301 + 1);

			Cancel($AllMonster_By_ShengQiKill[%Player,%Mid]);
			$AllMonster_By_ShengQiKill[%Player,%Mid] = Schedule(600,0,"UpData_Mission",%Player,%Mid,1,%Mission1301 + 1,%Mission1201);
		}
	}

	%Mid = 32540;
	if (%Player.IsAcceptedMission(%Mid))
	{
		%Mission1201 = %Player.GetMissionFlag(%Mid, 1201);	//总共数量
		%Mission1301 = %Player.GetMissionFlag(%Mid, 1301);	//当前数量
		if (%Mission1301 < %Mission1201)
		{
			//修改旗标
			%Player.SetMissionFlag(%Mid, 1301, %Mission1301 + 1);

			Cancel($AllMonster_By_ShengQiKill[%Player, %Mid]);
			$AllMonster_By_ShengQiKill[%Player, %Mid] = Schedule(600, 0, "UpData_Mission", %Player, %Mid, 1, %Mission1301 + 1, %Mission1201);
		}
	}

	%Mid = 20151;
	if (%Player.IsAcceptedMission(%Mid))
	{
		if (%MonsterLeve - %PlayLv >= -10)
		{
			%Mission1201 = %Player.GetMissionFlag(%Mid, 1200);	//总共数量
			%Mission1301 = %Player.GetMissionFlag(%Mid, 1300);	//当前数量
			if (%Mission1301 < 9999)
			{
				//修改旗标
				%Player.SetMissionFlag(%Mid, 1300, %Mission1301 + 1);

				Cancel($AllMonster_By_ShengQiKill[%Player, %Mid]);
				$AllMonster_By_ShengQiKill[%Player, %Mid] = Schedule(600, 0, "UpData_Mission", %Player, %Mid, 1, %Mission1301 + 1, %Mission1201);
			}
		}
	}
	
	
	
	
	
	//内网使用杀怪计数
	if (%Player.IsAcceptedMission(29999))
	{
		%Mid = 29999;
		%Mission1201 = %Player.GetMissionFlag(%Mid, 1200);	//总共数量
		%Mission1301 = %Player.GetMissionFlag(%Mid, 1300);	//当前数量
		%Player.SetMissionFlag(%Mid, 1300, %Mission1301 + 1);
		Cancel($AllMonster_By_ShengQiKill[%Player, %Mid]);
		$AllMonster_By_ShengQiKill[%Player, %Mid] = Schedule(600, 0, "UpData_Mission", %Player, %Mid, 1, %Mission1301 + 1, %Mission1201);
	}
}
//更新任务日志
function UpData_Mission(%Player,%MissionID,%MonsterID,%Min,%Max)
{
	switch (%MonsterID)
	{
		case 1:%MonsterName = "怪物";
		case 2:%MonsterName = "任意怪物";
		case 3:%MonsterName = "十八路反王怪物";
		case 4:
			%MisFlagVal  = %Player.GetMissionFlag(%MissionID,1100);	//目标编号
			%MonsterName = GetNpcData(%MisFlagVal,1);
		case 5:%MonsterName = "大雁塔任意怪物";

		default:%MonsterName = GetNpcData(%MonsterID,1);
	}

	SendOneScreenMessage(1,"击败【" @ %MonsterName @ "】 "@ %Min @ "/" @ %Max,%Player);
	%Player.UpdateMission(%MissionID);
}
//■■■■■■■■■■■怪物死亡触发脚本■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■怪物死亡所有玩家触发■■■■■■■■■■■■■■■■
function onNpcDisabled(%Monster)
{
	%MonsterID = %Monster.GetDataID();	//获取怪物的编号
	%MonsterLeve = %Monster.GetLevel();	//获取怪物等级

	for (%i = 0; %i >= 0; %i++)
	{
		//获取仇恨列表中的值
		%Player = %Monster.getHateListObject(%i);

		//没有仇恨了暂停
		if (%Player == 0)
			break;

		if (%Player.getclassname() $= "Player")
		{
			%PlayerLeve = %Player.GetLevel();		//获取玩家等级

			//记录已经触发过了
			%Monster.MissionKill[%Player] = 1;

			//开始处理所有的怪物计数
			Schedule(GetRandom(100,500),0,"AllMonster_By_MissionKill",%Monster,%Player,%MonsterID);	//所有怪物统一处理的任务计数
			Schedule(GetRandom(100,500),0,"AllMonster_By_ShengQiKill",%MonsterLeve,%PlayerLeve,%Player);			//其他杀怪计数统一触发
		}

		%FuncName = "NpcDisabled_" @ %MonsterID;
		if (isFunction(%FuncName))
			eval(%FuncName @ "(%Monster, %Player);");
	}

	%FuncName = "All_NpcDisabled_" @ %MonsterID;
	if (isFunction(%FuncName))
		eval(%FuncName @ "(%Monster);");
}
//■■■■■■■■■■■怪物死亡触发脚本■■■■■■■■■■■■■■■■■■



//■■■■■■■■■■■怪物被最后一击击败触发■■■■■■■■■■■■■■■
function NpcObject::onDeathCast(%Monster,%Killer)
{
	if (%Monster.iskilled != 1)
		%Monster.iskilled = 1;
	else
		return;
	//%Monster = 被击败;
	//%Killer  = 击败者;
	//echo( "%Monster==" @ %Monster  @ "   %Killer==" @ %Killer );
	%MonsterID = %Monster.GetDataID();	//获取怪物的编号

	if (%Killer.GetMaster() > 0)
		%Killer = %Killer.GetMaster();
	//if ( %Killer.GetClassName( ) $= "PetObject" )%Killer = %Killer.GetMaster( );
	//else if ( %Killer.GetClassName( ) $= "Player" )%KillerMaster = %Killer;
	//else return;
	
	//道经
	SpecialItem_DaoJing_KillMonster(%Monster,%Killer);

	%FuncName = "NpcObjectonDeathcast_" @ %MonsterID;

	if (isFunction(%FuncName))
		eval(%FuncName @ "(%Monster, %Killer);");
}
//■■■■■■■■■■■怪物被最后一击击败触发■■■■■■■■■■■■■■■
/*
%MonsterLeve = %Monster.GetLevel( );	//获取怪物等级
%PlayerLeve = %Player.GetLevel( );		//获取玩家等级
%PlayerID = %Player.GetPlayerID( );	//获取玩家的编号

%PetID = %Player.GetSpawnedPet( );		//获取宠物编号
%PetLeve = %PetID.GetLevel( );				//获取宠物等级

%CopyMapID = %Player.GetLayerId( );	//获取副本层
%CopymapDataID = SptGetCopymapDataId( %CopyMapID );	//获取副本DataID
*/

//陨仙窟一层普通怪
function NpcObjectonDeathcast_411281005(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20142"); }
function NpcObjectonDeathcast_411281006(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20142"); }
function NpcObjectonDeathcast_411281007(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20142"); }
function NpcObjectonDeathcast_411281008(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20142"); }
function NpcObjectonDeathcast_411281009(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20142"); }
//陨仙窟一层精英怪																					
function NpcObjectonDeathcast_411281010(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20141"); }
function NpcObjectonDeathcast_411281011(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20141"); }
function NpcObjectonDeathcast_411281012(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20141"); }
function NpcObjectonDeathcast_411281013(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20141"); }
function NpcObjectonDeathcast_411281014(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20141"); }
//陨仙窟二层普通怪																			
function NpcObjectonDeathcast_411281015(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20142"); }
function NpcObjectonDeathcast_411281016(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20142"); }
function NpcObjectonDeathcast_411281017(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20142"); }
function NpcObjectonDeathcast_411281018(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20142"); }
function NpcObjectonDeathcast_411281019(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20142"); }
//陨仙窟二层精英怪																			
function NpcObjectonDeathcast_411281020(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20141"); }
function NpcObjectonDeathcast_411281021(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20141"); }
function NpcObjectonDeathcast_411281022(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20141"); }
function NpcObjectonDeathcast_411281023(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20141"); }
function NpcObjectonDeathcast_411281024(%Monster,%Killer){ NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,"20141"); }
function NpcObjectonDeathcast_411281005_411281024(%Monster,%Killer,%Mid)			//echo( 263212.GetMissionFlag( 20142, 3200 ) );
{
	%EnmityID = %Killer.GetMissionFlag(%Mid,3100);
	%MonsterID = %Monster.GetDataId();
	%NowFlag = %Killer.GetMissionFlag(%Mid,3300);
	%MaxFlag = %Killer.GetMissionFlag(%Mid,3200);
	//echo( "%EnmityID===" @ %EnmityID @ "=====%MonsterID====" @ %MonsterID );
	if (%MonsterID == %EnmityID)
	{
		//echo( "%NowFlag===="@ %NowFlag @ "====%MaxFlag====" @ %MaxFlag @ "====%Mid===" @ %Mid );
		if (%Killer.IsAcceptedMission(%Mid))//是否已接任务
		{
			if (%NowFlag < %MaxFlag)
			{
				%Killer.SetMissionFlag(%Mid,3300,%NowFlag + 1); //设置,怪物当前数量
				%Killer.UpdateMission(%Mid);
			}
		}
	}
}

function KilledMonster_410101001(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_410101001_410101017(%Player,%Monster,%SharePlayerNum,%MaxConnection,0); }
function KilledMonster_410101002(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_410101001_410101017(%Player,%Monster,%SharePlayerNum,%MaxConnection,0); }
function KilledMonster_410101003(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_410101001_410101017(%Player,%Monster,%SharePlayerNum,%MaxConnection,0); }
function KilledMonster_410101004(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_410101001_410101017(%Player,%Monster,%SharePlayerNum,%MaxConnection,0); }
function KilledMonster_410101013(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_410101001_410101017(%Player,%Monster,%SharePlayerNum,%MaxConnection,0); }
function KilledMonster_410101014(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_410101001_410101017(%Player,%Monster,%SharePlayerNum,%MaxConnection,0); }
function KilledMonster_410101015(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_410101001_410101017(%Player,%Monster,%SharePlayerNum,%MaxConnection,410101015); }
function KilledMonster_410101017(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_410101001_410101017(%Player,%Monster,%SharePlayerNum,%MaxConnection,0); }

function KilledMonster_410101001_410101017(%Player,%Monster,%SharePlayerNum,%MaxConnection,%Num)
{
	//echo( "==========================" @ %Player.IsAcceptedMission( 20149 ) );
	if (%Player.IsAcceptedMission(20149))
	{
		%Missiontarget = %player.getmissionflag(20149,10300);
		if (%Missiontarget  == %Monster.getdataid())
		{
			%flag3200 = %player.getmissionflag(20149,3200);
			%flag3300 = %player.getmissionflag(20149,3300);
			if (%flag3300 < %flag3200)
			{
				%flag3300++;
				SendOneScreenMessage(1,"击败【" @ %Monster.getobjectname() @ "】 "@ %flag3300 @ "/" @ 10,%Player);
				%Player.SetMissionFlag(20149,3300,%flag3300);
				%Player.UpdateMission(20149);
			}
		}
	}
	if (%Num == 410101015)
	{
		if (%Player.IsAcceptedMission(20204))
		{
			%PlayerID = %Player.GetPlayerID();
			%Type = %Player.GetMissionFlag(20204,2300);
			%Num = %Player.GetMissionFlag(20204,2200);
			if (%Type < %Num)
			{
				SpNewDropItem(%Monster,%Player,108021018,1,0);//掉落任务道具  树心
			}
		}
	}
}
//--------------望仙谷悬赏任务杀怪掉落-----------
function KilledMonster_411011001(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411011001_411011012(%Player,%Monster,%SharePlayerNum,%MaxConnection,"29107 108020105 20;29120 108020113 20;10461 108020022 80;"); }
function KilledMonster_411011002(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411011001_411011012(%Player,%Monster,%SharePlayerNum,%MaxConnection,"29131 108020122 20;29149 108020131 20;"); }
function KilledMonster_411011003(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411011001_411011012(%Player,%Monster,%SharePlayerNum,%MaxConnection,"29117 108020110 20;29102 108020102 20;29119 108020112 20;10891 108020028 80;"); }
function KilledMonster_411011004(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411011001_411011012(%Player,%Monster,%SharePlayerNum,%MaxConnection,"29103 108020103 20;10921 108020029 80;10681 108021020 80;"); }
function KilledMonster_411011005(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411011001_411011012(%Player,%Monster,%SharePlayerNum,%MaxConnection,"29122 108020114 20;29130 108020117 20;10921 108020029 80;10681 108021020 80;"); }
function KilledMonster_411011006(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411011001_411011012(%Player,%Monster,%SharePlayerNum,%MaxConnection,"29145 108020128 20;"); }
function KilledMonster_411011007(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411011001_411011012(%Player,%Monster,%SharePlayerNum,%MaxConnection,""); }
function KilledMonster_411011008(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411011001_411011012(%Player,%Monster,%SharePlayerNum,%MaxConnection,"29140 108020123 25;29135 108020118 25;"); }
function KilledMonster_411011009(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411011001_411011012(%Player,%Monster,%SharePlayerNum,%MaxConnection,"29141 108020124 25;29143 108020126 25;"); }
function KilledMonster_411011010(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411011001_411011012(%Player,%Monster,%SharePlayerNum,%MaxConnection,"29144 108020127 25;"); }
function KilledMonster_411011011(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411011001_411011012(%Player,%Monster,%SharePlayerNum,%MaxConnection,""); }
function KilledMonster_411011012(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411011001_411011012(%Player,%Monster,%SharePlayerNum,%MaxConnection,"29136 108020119 30;"); }
function KilledMonster_411011001_411011012(%Player,%Monster,%SharePlayerNum,%MaxConnection,%MissionList)
{
	%Count = GetWordCount(%MissionList,";");
	for (%i = 0; %i < %Count; %i++)
	{
		%OneList = GetWord(%MissionList,%i,";");
		%Mid = GetWord(%OneList,0);
		%IsItem = GetWord(%OneList,1);
		%IsRan = GetWord(%OneList,2);
		if (%Player.IsAcceptedMission(%Mid))
		{
			if (CanDoThisMission(%Player,%Mid,2,0,0) !$= "")//任务旗标未完成
			{
				%Ran = GetRanDom(1,100);
				if (%Ran <= %IsRan)
					//%Monster.SpNewDropItem( %Player.GetLayerID( ), %IsItem, 1 );
					SpNewDropItem(%Monster,%Player,%IsItem,1,0);
			}
		}

	}
	if (%Player.IsAcceptedMission(20150))
	{
		%Flag3100 = %Player.getmissionflag(20150,3100);
		if (%Flag3100 ==  %Monster.GetDataID())
		{
			%Flag3200 = %Player.getmissionflag(20150,3200);
			%Flag3300 = %Player.getmissionflag(20150,3300);
			if (%Flag3200 > %Flag3300)
			{
				%Flag3300++;
				%Player.SetMissionFlag(20150,3300,%Flag3300);
				%Player.UpdateMission(20150);
				SendOneScreenMessage(1,"击败【" @ %Monster.GetObjectname() @ "】 " @ %Flag3300 @ "/" @ %Flag3200,%Player);
			}
		}

	}
}
function KilledMonster_411011014(%Player, %Monster, %SharePlayerNum, %MaxConnection){ KilledMonster_411011014_411051014(%Player, %Monster, %SharePlayerNum, %MaxConnection); }
function KilledMonster_411021014(%Player, %Monster, %SharePlayerNum, %MaxConnection){ KilledMonster_411011014_411051014(%Player, %Monster, %SharePlayerNum, %MaxConnection); }
function KilledMonster_411031014(%Player, %Monster, %SharePlayerNum, %MaxConnection){ KilledMonster_411011014_411051014(%Player, %Monster, %SharePlayerNum, %MaxConnection); }
function KilledMonster_411041014(%Player, %Monster, %SharePlayerNum, %MaxConnection){ KilledMonster_411011014_411051014(%Player, %Monster, %SharePlayerNum, %MaxConnection); }
function KilledMonster_411051014(%Player, %Monster, %SharePlayerNum, %MaxConnection){ KilledMonster_411011014_411051014(%Player, %Monster, %SharePlayerNum, %MaxConnection); }

function KilledMonster_411011014_411051014(%Player, %Monster, %SharePlayerNum, %MaxConnection)
{
	%Mid = 20028;
	if (%Player.IsAcceptedMission(%Mid))
	{
		if (CanDoThisMission(%Player,%Mid,2,0,0) !$= "")//任务旗标未完成
		{
			%Player.SetMissionFlag(%Mid,3300,1);
			%Player.UpdateMission(%Mid);
			SendOneScreenMessage(1,"击败【" @ %Monster.GetObjectname() @ "】 1/1",%Player);
		}
	}
}

//--------------苍山雪海悬赏任务杀怪掉落-----------

function KilledMonster_411021001(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411021001_411021005(%Player,%Monster,%SharePlayerNum,%MaxConnection,"29206 108020132 25;29207 108020133 25;29208 108020134 25;29209 108020135 25;29210 108020136 25;"); }
function KilledMonster_411021002(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411021001_411021005(%Player,%Monster,%SharePlayerNum,%MaxConnection,"29211 108020137 25;29212 108020138 25;29213 108020139 25;29214 108020140 25;"); }
function KilledMonster_411021003(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411021001_411021005(%Player,%Monster,%SharePlayerNum,%MaxConnection,"29215 108020141 25;29216 108020142 25;"); }
function KilledMonster_411021004(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411021001_411021005(%Player,%Monster,%SharePlayerNum,%MaxConnection,"29217 108020034 25;29218 108020143 25;29219 108020144 25;29220 108020145 25;29221 108020146 25;29222 108020147 25;29223 108020148 25;11181 108020034 80;"); }
function KilledMonster_411021005(%Player,%Monster,%SharePlayerNum,%MaxConnection){ KilledMonster_411021001_411021005(%Player,%Monster,%SharePlayerNum,%MaxConnection,"29224 108020149 25;29225 108020150 25;29226 108020151 25;"); }

function KilledMonster_411021001_411021005(%Player,%Monster,%SharePlayerNum,%MaxConnection,%MissionList)
{
	%Count = GetWordCount(%MissionList,";");
	for (%i = 0; %i < %Count; %i++)
	{
		%OneList = GetWord(%MissionList,%i,";");
		%Mid = GetWord(%OneList,0);
		%IsItem = GetWord(%OneList,1);
		%IsRan = GetWord(%OneList,2);
		if (%Player.IsAcceptedMission(%Mid))
		{
			if (CanDoThisMission(%Player,%Mid,2,0,0) !$= "")//任务旗标未完成
			{
				%Ran = GetRanDom(1,100);
				if (%Ran <= %IsRan)
					//%Monster.SpNewDropItem( %Player.GetLayerID( ), %IsItem, 1 );
					SpNewDropItem(%Monster,%Player,%IsItem,1,0);
			}
		}

	}
}

//--------------云梦泽悬赏任务杀怪掉落-----------

function KilledMonster_411031003( %Player, %Monster, %SharePlayerNum, %MaxConnection ){ KilledMonster_411031001_411031006( %Player, %Monster, %SharePlayerNum, %MaxConnection, "29308 108020177 25;29309 108020178 25;" ); }
function KilledMonster_411031001( %Player, %Monster, %SharePlayerNum, %MaxConnection ){ KilledMonster_411031001_411031006( %Player, %Monster, %SharePlayerNum, %MaxConnection, "29310 108020179 25;29311 108020180 25;29312 108020181 25;" ); }
function KilledMonster_411031004( %Player, %Monster, %SharePlayerNum, %MaxConnection ){ KilledMonster_411031001_411031006( %Player, %Monster, %SharePlayerNum, %MaxConnection, "29313 108020182 25;29314 108020183 25;29315 108020184 25;" ); }
function KilledMonster_411031006( %Player, %Monster, %SharePlayerNum, %MaxConnection ){ KilledMonster_411031001_411031006( %Player, %Monster, %SharePlayerNum, %MaxConnection, "29316 108020185 25;29317 108020186 25;29318 108020187 25;29319 108020188 25;" ); }
function KilledMonster_411031002( %Player, %Monster, %SharePlayerNum, %MaxConnection ){ KilledMonster_411031001_411031006( %Player, %Monster, %SharePlayerNum, %MaxConnection, "29320 108020189 25;29321 108020190 25;29322 108020191 25;" ); }
function KilledMonster_411031005( %Player, %Monster, %SharePlayerNum, %MaxConnection ){ KilledMonster_411031001_411031006( %Player, %Monster, %SharePlayerNum, %MaxConnection, "29323 108020192 25;29324 108020193 25;29325 108020194 25;" ); }

function KilledMonster_411031001_411031006( %Player, %Monster, %SharePlayerNum, %MaxConnection, %MissionList )
{
	%Count = GetWordCount( %MissionList, ";" );
	for ( %i = 0; %i < %Count; %i++ )
	{
		%OneList = GetWord( %MissionList, %i, ";" );
		%Mid = GetWord( %OneList, 0 );
		%IsItem = GetWord( %OneList, 1 );
		%IsRan = GetWord( %OneList, 2 );
		if ( %Player.IsAcceptedMission( %Mid ) )
		{
			if ( CanDoThisMission( %Player, %Mid, 2, 0, 0 ) !$= "" )//任务旗标未完成
			{
				%Ran = GetRanDom( 1, 100 );
				if ( %Ran <= %IsRan )
					//%Monster.SpNewDropItem( %Player.GetLayerID( ), %IsItem, 1 );
					SpNewDropItem( %Monster, %Player, %IsItem, 1, 0 );
			}
		}

	}
}


//新手任务击败触发
function NpcDisabled_410101004(%Monster,%Player)//螃蟹精
{
	if (%Player.IsAcceptedMission(10061))//海鲜
	{
		%PlayerID = %Player.GetPlayerID();
		%Type10061 = %Player.GetMissionFlag(10061,2300);
		%Num10061 = %Player.GetMissionFlag(10061,2200);
		%Type = %Player.GetMissionFlag( 10061, 2301 );
		%Num = %Player.GetMissionFlag( 10061, 2201 );
		if (%Type10061 < %Num10061)
		{
			SpNewDropItem(%Monster,%Player,108020020,1,0);//掉落任务道具
		}
		if ( %Type < %Num)
		{
			SpNewDropItem( %Monster, %Player, 108020162, 1, 0 );//掉落任务道具
		}
		if (%Type10061 <= 1 && %Player.Shuqutishi != 1)
		{
			HelpDirectByIndex(%PlayerID,12);//通讯客户端
			%Player.Shuqutishi = 1;
			
		}
	}
}
function NpcDisabled_413031009(%Monster,%Player)//阵灵傀儡
{
	if (%Player.IsAcceptedMission(10341))
	{
		%PlayerID = %Player.GetPlayerID();
		%Type = %Player.GetMissionFlag(10341,3300);
		%Num = %Player.GetMissionFlag(10341,3200);
		%Type1 = %Player.GetMissionFlag(10341,3301);
		%Num1 = %Player.GetMissionFlag(10341,3201);
		if ( %Player.miission != 1 )
		{
			HelpDirectByIndex(%PlayerID,18);//通讯客户端
			%Player.miission = 1;
		}
		if ( %Type1 == 20 && %Type >= 19 && %Player.miission10341 != 1 )
		{
			//进入镜像层
			ChangeLogicFloor(%Player,0,%Player);
			HelpDirectByIndex( %PlayerID, 30 );
			%Player.SetMovieMode(1,10351);//开始小电影
			%Player.miission10341 = 1;
		}
		if (%Type < %Num)
			%Player.AddExp(3100);
	}
}
function NpcDisabled_413031010(%Monster,%Player)//灭魂阵灵
{
	if (%Player.IsAcceptedMission(10341))
	{
		%PlayerID = %Player.GetPlayerID();
		%Type = %Player.GetMissionFlag(10341,3300);
		%Num = %Player.GetMissionFlag(10341,3200);
		%Type1 = %Player.GetMissionFlag(10341,3301);
		%Num1 = %Player.GetMissionFlag(10341,3201);
		if ( %Player.miission != 1 )
		{
			HelpDirectByIndex(%PlayerID,18);//通讯客户端
			%Player.miission = 1;
		}
		if (%Type == 20 && %Type1 >= 19 && %Player.miission10341 != 1)
		{
			ChangeLogicFloor(%Player,0,%Player);
			HelpDirectByIndex( %PlayerID, 30 );
			%Player.SetMovieMode( 1, 10351 );//开始小电影
			%Player.miission10341 = 1;
		}
		if (%Type1 < %Num1)
			%Player.AddExp(3100);
	}
}
function KilledMonster_410101016(%Player,%Monster,%SharePlayerNum,%MaxConnection)//树妖之灵
{
	$Mission_Item_10301[1,1] = "102062002;102062052;";
	$Mission_Item_10301[1,3] = "102062202;102062252;";
	$Mission_Item_10301[1,4] = "102062302;102062352;";
	%Classes = %Player.GetClasses(0);//获取职业
	if (%Player.GetSex()== 1)
	{
		%ItemID = getword($Mission_Item_10301[1,%Classes],0,";");
	}
	else if (%Player.GetSex()== 2)
		%ItemID = getword($Mission_Item_10301[1,%Classes],1,";");
	if (%Player.IsAcceptedMission(10301))
	{
		ChangeLogicFloor(%Player,%Player,0);
		SpNewDropItem(%Monster,%Player,%ItemID,1,0);
	}
}
function KilledMonster_411281004(%Player,%Monster,%SharePlayerNum,%MaxConnection)//青冥蛇
{
	if (%Player.IsAcceptedMission(10981))
	{
		%PlayerID = %Player.GetPlayerID();
		%Type10981 = %Player.GetMissionFlag(10981,2300);
		%Num10981 = %Player.GetMissionFlag(10981,2200);
		if (%Type10981 < %Num10981)
		{
			SpNewDropItem(%Monster,%Player,108020030,1,0);//掉落任务道具  蛇胆
		}
	}
}

function KilledMonster_440000018(%Player,%Monster,%SharePlayerNum,%MaxConnection)
{
	if (!%Player.IsAcceptedMission(20148))
		return;
	if (%Monster.BelongPlayer != %Player.GetPlayerID())
		return;
	%Player.SetMissionFlag(20148,3300,1);
	%Player.UpdateMission(20148);
}

