

function UPCS_CopyMapFunction(%Num)
{
	if ((%Num == 1) || (%Num == 99)) { Exec("./SL_S_CopyMap_1301_ShiKongLieHeng.cs"); }
	if ((%Num == 2) || (%Num == 99)) { Exec("./SL_S_CopyMap_1302_LianMoYuan.cs"); }
	if ((%Num == 3) || (%Num == 99)) { Exec("./SL_S_CopyMap_1303_PengLaiJingDi.cs"); }
	if ((%Num == 4) || (%Num == 99)) { Exec("./SL_S_CopyMap_1304_HuanJingZhengBa.cs"); }
	if ((%Num == 5) || (%Num == 99)) { Exec("./SL_S_CopyMap_1305_XinMoHuanJing.cs"); }
	if ((%Num == 6) || (%Num == 99)) { Exec("./SL_S_CopyMap_1306_ZhuShenWenXinZhen.cs"); }
	if ((%Num == 7) || (%Num == 99)) { Exec("./SL_S_CopyMap_1307_YunXianJieDaTaoSha.cs"); }
	if ((%Num == 11) || (%Num == 99)) { Exec("./SL_S_CopyMap_1311_XueMoFengYinZhen.cs"); }
	if ((%Num == 12) || (%Num == 99)) { Exec("./SL_S_CopyMap_1312_HuangJingBaoZang.cs"); }
	if ((%Num == 13) || (%Num == 99)) { Exec("./SL_S_CopyMap_1313_DaoJianShenYu.cs"); }
	if ((%Num == 16) || (%Num == 99)) { Exec("./SL_S_CopyMap_1316_YunLuoJing.cs"); }
	if ((%Num == 17) || (%Num == 99)) { Exec("./SL_S_CopyMap_1317_YaoLingTianGong.cs"); }
	if ((%Num == 18)|| (%Num == 99)) { Exec("./SL_S_CopyMap_1318_FengShenMiJing.cs"); }
}
UPCS_CopyMapFunction(99);
//■■■■■■■■■【副本功能】■■■■【副本对话功能】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■【副本功能】■■■■【副本创建触发】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■【副本功能】■■■■【副本关闭触发】■■■■■■■■■■■■■■■■

//■■■■■■■■■【副本功能】■■■■【玩家进入副本触发】■■■■■■■■■■■■■■■■
//■■■■■■■■■【副本功能】■■■■【玩家离开副本触发】■■■■■■■■■■■■■■■■
//■■■■■■■■■【副本功能】■■■■【玩家离开队伍触发】■■■■■■■■■■■■■■■■

//■■■■■■■■■【副本功能】■■■■【副本信息功能】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■【副本功能】■■■■【队长进入副本提示队友功能】■■■■■■■■■■■■
//■■■■■■■■■【副本功能】■■■■【倒计时离开副本功能】■■■■■■■■■■■■■■■

//■■■■■■■■■【随机副本】■■■■【进入副本坐标】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■【随机副本】■■■■【进入副本操作】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■【随机副本】■■■■【投票踢出副本】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■【随机副本】■■■■【副本主动离队】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■【战场功能】■■■■【开启时间触发】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■【战场功能】■■■■【进入条件触发】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■【随机战场】■■■■【进入副本坐标】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■【随机战场】■■■■【进入副本判断】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■【随机战场】■■■■【进入副本操作】■■■■■■■■■■■■■■■■■■



//■■■■■■■■■【副本功能】■■■■【副本对话功能】■■■■■■■■■■■■■■■■■■
function NpcOnTrigger_CopyMap(%Npc,%Player,%State,%Conv,%Param)
{
	//如果不在副本，则停止
	if (GetSubStr(GetZoneID(),1,1) != 3)
		return;
	%Npc =  %Npc;
	%Player =  %Player;
	%State =  %State;
	%Conv =  %Conv;
	%Param =  %Param;

	%CopyMapID = %Player.GetLayerId();
	%CopymapDataID = SptGetCopymapDataId(%CopyMapID);
	//获取Npc编号
	%NpcID = %Npc.GetDataID();
	//echo( "%State====" @ %State );
	//对话内容
	%FuncName = "NpcOnTrigger_CopyMap_"@ %CopymapDataID @ "_" @ %NpcID;

	//echo( " %State ===" @  %State @ "   开关==" @ $SL_LianMoYuan_Boss_State[ %CopyMapID ] @ "  %Conv==" @ %Conv @ "  %Player==" @ %Player );
	//发送isFunction
	//if ( isFunction( %FuncName ) )
	//	eval( %FuncName @ "(%Npc, %Player, %State, %Conv, %Param);" );
	//发送isFunction
	if (isFunction(%FuncName))
		eval(%FuncName @ "("@%Npc@", "@%Player@", "@%State@", "@%Conv@", "@%Param@");");
}
//■■■■■■■■■【副本功能】■■■■【副本对话功能】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■【副本功能】■■■■【副本创建触发】■■■■■■■■■■■■■■■■■■
function SvrCopymapOpen(%CopyMapID,%MapID)
{
	//获取副本DataID
	%CopymapDataID = SptGetCopymapDataId(%CopyMapID);

	//创建副本怪物与NPC
	%FuncName = "SvrCopymapOpen_" @ %CopymapDataID @ "_Trigger";

	if (isFunction(%FuncName))
		eval(%FuncName @ "(%CopyMapID, %CopymapDataID);");
	//统一格式为,如：
	//SvrCopymapOpen_1301_Trigger(%CopyMapID, %MapID);


	//记录副本开启时间
	for (%i=1; %i<100; %i++)
	{
		if ($JuQingRanking_MapID[%i] $= "")
			break;

		if (%CopymapDataID == $JuQingRanking_MapID[%i])
		{
			%Time = GetLocalTime();
			%H = GetWord(%Time, 3);	//小时
			%M = GetWord(%Time, 4);	//分钟
			%S = GetWord(%Time, 5);	//秒

			$JuQingRanking_Times[%CopyMapID] = %H * 3600 + %M * 60 + %S;
			break;
		}
	}
}
//■■■■■■■■■【副本功能】■■■■【副本创建触发】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■【副本功能】■■■■【副本关闭触发】■■■■■■■■■■■■■■■■
function CloseCopyMap(%CopyMapID)
{
	%CopymapDataID = SptGetCopymapDataId(%CopyMapID);
	switch (%CopymapDataID)
	{
		case 1301:
			CanCel($SptCopymap_1301_Combat[%CopyMapID]);
		case 1302:
			CanCel($SL_LianMoYuan_Schedule[%CopyMapID]);
	}
	SvrClearLayer(%CopyMapID);
}
//■■■■■■■■■【副本功能】■■■■【副本关闭触发】■■■■■■■■■■■■■■■■

//■■■■■■■■■【副本功能】■■■■【玩家进入副本触发】■■■■■■■■■■■■■■■■
function SptCopymap_OnEnter(%Player)
{
	//若玩家存在
	if (!isobject(%Player))
		return;

	//基础信息：
	%PlayerID = %Player.GetPlayerID();
	%CopyMapID = %Player.GetLayerId();

	//获取副本DataID
	%CopymapDataID = SptGetCopymapDataId(%CopyMapID);

	//记录初始队伍ID
	if ($SptCopymap_BelongTeamID[%CopyMapID] $= "")
		$SptCopymap_BelongTeamID[%CopyMapID] = %Player.GetTeamId();

	//进入特定副本时打开BOSS信息界面
	ChengJiuSys_OpenWnd(%Player,%CopyMapID);

	//创建副本怪物与NPC
	%FuncName = "SptCopymap_OnEnter_"@ %CopymapDataID @ "_Trigger";

	if (isFunction(%FuncName))
		eval(%FuncName @ "(%CopyMapID, %Player);");

	//统一格式为,如：
	//SptCopymap_OnEnter_1301_Trigger(%CopyMapID, %Player);
}
//■■■■■■■■■【副本功能】■■■■【玩家进入副本触发】■■■■■■■■■■■■■■■■

//■■■■■■■■■【副本功能】■■■■【副本信息功能】■■■■■■■■■■■■■■■■■■
function ChengJiuSys_OpenWnd(%Player,%CopyMapID)
{
	//功能开关
	if ($ChengJiuSys_Client_bActive < 1)
		return;

	%PlayerID = %Player.GetPlayerID();
	%CopymapDataID = SptGetCopymapDataId(%CopyMapID);
}
//■■■■■■■■■【副本功能】■■■■【副本信息功能】■■■■■■■■■■■■■■■■■■


//■■■■■■■■■【副本功能】■■■■【玩家离开副本触发】■■■■■■■■■■■■■■■■
function SptCopymap_onLeave(%PlayerID)
{
	%Player = SptGetPlayer(%PlayerID);
	%CopyMapID = %Player.GetLayerId();

	//获取副本DataID
	%CopymapDataID = SptGetCopymapDataId(%CopyMapID);

	//服务端处理：
	BFCorps_DelPlayer(%PlayerID);	//设置离开战场团队

	//离开副本地图触发
	//switch(%CopymapDataID)
	//{
	//	case 1363: %Player.RemoveSchBuff(9001040);	//杨公宝库
	//}
}
//■■■■■■■■■【副本功能】■■■■【玩家离开副本触发】■■■■■■■■■■■■■■■■


//■■■■■■■■■【副本功能】■■■■【玩家离开队伍触发】■■■■■■■■■■■■■■■■
function SptCopymap_OnLeaveTeam(%Player)
{
	if (!isobject(%Player))
		return;

	//获取副本层
	%CopyMapID = %Player.GetLayerId();

	//如果是多人副本
	if (SptCopymap_GetPlayerCount(%CopyMapID) > 1)
	{
		//获取副本DataID
		%CopymapDataID = SptGetCopymapDataId(%CopyMapID);

		//不需要被传出的副本
		//switch(%CopymapDataID)
		//{
		//	case 1381:return; //科举
		//}

		%Msg = "您不在一个队伍中，即将被传送出副本";
		SendOneChatMessage($chatMsg_System,"<t>"@ %Msg @"</t>",%Player);
		Schedule(2000,0,"RemovePlayerOnLeaveTeam",%Player,%PlayerID,%CopyMapID,0);
	}
}

function RemovePlayerOnLeaveTeam(%Player,%PlayerID,%CopyMapID,%Step)
{
	%PlayerID = %Player.GetPlayerID();

	//如果在副本
	if (GetSubStr(GetZoneID(),1,1) != 3)
		return;

	//副本人数
	if (SptCopymap_GetPlayerCount(%CopyMapID) <= 1)
		return;

	//队伍ID是否为初始ID
	if ($SptCopymap_BelongTeamID[%CopyMapID] == %Player.GetTeamId())
		return;

	switch (%Step)
	{
		case 0:%text = "即将在60秒后离开副本！"; %Time = 30;
		case 1:%text = "即将在30秒后离开副本！"; %Time = 20;
		case 2:%text = "即将在10秒后离开副本！"; %Time = 5;
		case 3:%text = "即将在5秒后离开副本！"; %Time = 1;
		case 4:%text = "即将在4秒后离开副本！"; %Time = 1;
		case 5:%text = "即将在3秒后离开副本！"; %Time = 1;
		case 6:%text = "即将在2秒后离开副本！"; %Time = 1;
		case 7:%text = "即将在1秒后离开副本！"; %Time = 1;

		default:
			SptCopymap_RemovePlayer(%PlayerID);
	}

	if (%text !$= "")
	{
		%Step++;
		SendOneChatMessage($chatMsg_System,%text,%Player);
	}

	if (%Time > 0)
		Schedule(%Time * 1000,0,"RemovePlayerOnLeaveTeam",%Player,%PlayerID,%CopyMapID,%Step);
}
//■■■■■■■■■【副本功能】■■■■【玩家离开队伍触发】■■■■■■■■■■■■■■■■

//■■■■■■■■■【副本功能】■■■■【队长进入副本提示队友功能】■■■■■■■■■■■■
function CaptainEnter_CopyMap_Suggestive(%Player,%PlayerID,%CopyMapID)
{
	%MapDataID = SptGetCopymapDataId(%CopyMapID);
	if (SvrIsMyselfCaption(%PlayerID) > 0)
	{
		//switch(%MapDataID)
		//{
		//	case 1301:AllLineMessage_PlayerID_A(%PlayerID, %MapDataID, 2000000054, 80);	//大雁塔
		//	case 813140100:AllLineMessage_PlayerID_A(%PlayerID, 2000000054, %MapID);	//北斗
		//	case 813190100:AllLineMessage_PlayerID_A(%PlayerID, 2000000055, %MapID);	//大闹
		//	case 813140200:AllLineMessage_PlayerID_A(%PlayerID, 2000000056, %MapID);	//哪吒
		//	case 813140300:AllLineMessage_PlayerID_A(%PlayerID, 2000000057, %MapID);	//龙王
		//	case 813060100:AllLineMessage_PlayerID_A(%PlayerID, 2000000058, %MapID);	//九宫
		//	case 813070100:AllLineMessage_PlayerID_A(%PlayerID, 2000000059, %MapID);	//宝莲灯
		//	case 813090100:AllLineMessage_PlayerID_A(%PlayerID, 2000000060, %MapID);	//嫦娥
		//	case 813110100:AllLineMessage_PlayerID_A(%PlayerID, 2000000061, %MapID);	//大禹
		//	case 813120100:AllLineMessage_PlayerID_A(%PlayerID, 2000000062, %MapID);	//夸父
		//	case 813300100:AllLineMessage_PlayerID_A(%PlayerID, 2000000063, %MapID);	//昊天塔
		//}
	}
}
//■■■■■■■■■【副本功能】■■■■【队长进入副本提示队友功能】■■■■■■■■■■■■


//■■■■■■■■■【副本功能】■■■■【倒计时离开副本功能】■■■■■■■■■■■■■■■
function RemoveCopyMapOnLeaveTeam(%CopyMapID,%Step)
{
	//如果在副本
	if (GetSubStr(GetZoneID(),1,1) != 3)
		return;

	//若副本人数为空时，暂停倒计时
	%TeammateNum = SptCopyMap_GetPlayerCount(%CopyMapID);
	if (%TeammateNum == 0)
		return;

	switch (%Step)
	{
		case 0:%Text = "副本将在30分钟后关闭！";	%Time = 600;
		case 1:%Text = "副本将在20分钟后关闭！";	%Time = 600;
		case 2:%Text = "副本将在10分钟后关闭！";	%Time = 300;
		case 3:%Text = "副本将在5分钟后关闭！";	%Time = 60;
		case 4:%Text = "副本将在4分钟后关闭！";	%Time = 60;
		case 5:%Text = "副本将在3分钟后关闭！";	%Time = 60;
		case 6:%Text = "副本将在2分钟后关闭！";	%Time = 60;
		case 7:%Text = "副本将在60秒后关闭！";		%Time = 30;
		case 8:%Text = "副本将在30秒后关闭！";		%Time = 10;
		case 9:%Text = "副本将在20秒后关闭！";		%Time = 10;
		case 10:%Text = "副本将在10秒后关闭！";		%Time = 5;
		case 11:%Text = "副本将在5秒后关闭！";		%Time = 1;
		case 12:%Text = "副本将在4秒后关闭！";		%Time = 1;
		case 13:%Text = "副本将在3秒后关闭！";		%Time = 1;
		case 14:%Text = "副本将在2秒后关闭！";		%Time = 1;
		case 15:%Text = "副本将在1秒后关闭！";		%Time = 1;
		default:
			%Time = 0;
	}

	if (%Time == 0)
	{
		%TeammateList = SptCopyMap_GetAllPlayer(%CopyMapID);
		%TeammateNum = SptCopyMap_GetPlayerCount(%CopyMapID);

		for (%i=0; %i< %TeammateNum; %i++)
		{
			//获取Player
			%Player = GetWord(%TeammateList,%i);
			//获取副本PlayerID
			%PlayerID = %Player.GetPlayerID();
			//传送离开副本
			SptCopymap_RemovePlayer(%PlayerID);
		}
		return;
	}

	if (%Time > 0)
	{
		SendAllChatMessageLayer($chatMsg_System,$Get_Dialog_GeShi[31419] @ %Text @"</t>",%CopyMapID);
		SendAllScreenMessageLayer(1,%Text,%CopyMapID);

		Schedule(%Time * 1000,0,"RemoveCopyMapOnLeaveTeam",%CopyMapID,%Step++);
	}
}
//■■■■■■■■■【副本功能】■■■■【倒计时离开副本功能】■■■■■■■■■■■■■■■

//■■■■■■■■■【战场功能】■■■■【开启时间触发】■■■■■■■■■■■■■■■■■■
function sptOnCombatStarted(%DataID)
{
	//副本开启提示
	%FuncName = "CopyMap_TimeBegin_"@ %DataID;

	//发送isFunction
	if (isFunction(%FuncName))
		eval(%FuncName @ "("@%DataID@");");
}
//■■■■■■■■■【战场功能】■■■■【开启时间触发】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■【战场功能】■■■■【进入条件触发】■■■■■■■■■■■■■■■■■■
function SptCheckCombatQueue(%MapID,%Player)
{
	//副本开启提示
	%FuncName = "CopyMap_CheckCombatQueue_"@ %MapID;

	//发送isFunction
	if (isFunction(%FuncName))
		eval("return " @ %FuncName @ "("@%MapID@", "@%Player@");");
}
//■■■■■■■■■【战场功能】■■■■【进入条件触发】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■【随机副本】■■■■【进入副本坐标】■■■■■■■■■■■■■■■■■■
$CopyMap_In[1311] = "B11";//【三打瓦岗寨】
$CopyMap_In[1312] = "B12";//【虎牢关之战】
$CopyMap_In[1313] = "B19";//【中日第一站】
$CopyMap_In[1328] = "B36";//【问鼎天下】
//■■■■■■■■■【随机副本】■■■■【进入副本坐标】■■■■■■■■■■■■■■■■■■


//■■■■■■■■■【随机副本】■■■■【进入副本操作】■■■■■■■■■■■■■■■■■■
function TransportRandTeamPlayer(%Player,%MapID,%MapLevel)
{
	//获取副本坐标
	%Map_GoTo = $CopyMap_In[%MapID];

	if (%Map_GoTo $= "")
	{
		%Txt = "未找到随机副本坐标！错误代码-" @ %MapID @ ":" @ %MapLevel;

		SendOneScreenMessage(2,%Txt,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		return;
	}

	%Player.AddBuff(391080003,%Player);			//增加随机副本buff
	%Player.RecordActivity(%MapID,5,0,0);	//服务器日志记录
	//GoToNextMap(%Player, %Map_GoTo, 0, 0, 0);	//传送
}
//■■■■■■■■■【随机副本】■■■■【进入副本操作】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■【随机副本】■■■■【投票踢出副本】■■■■■■■■■■■■■■■■■■
function RandTeamPlayerKick(%Player)
{
	//传送离开副本
	SptCopymap_RemovePlayer(%Player.GetPlayerID());
}
//■■■■■■■■■【随机副本】■■■■【投票踢出副本】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■【随机副本】■■■■【副本主动离队】■■■■■■■■■■■■■■■■■■
function RandPlayerLeaveTeam(%Player)
{
	//传送离开副本
	SptCopymap_RemovePlayer(%Player.GetPlayerID());
}
//■■■■■■■■■【随机副本】■■■■【副本主动离队】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■【随机战场】■■■■【进入副本坐标】■■■■■■■■■■■■■■■■■■
$CopyMap_In[1338,1] = "B32";//【决战中原】长安势力24v24
$CopyMap_In[1338,2] = "B33";//【决战中原】洛阳势力24v24

$CopyMap_In[1339,1] = "B30";//【决战中原】长安势力6v6
$CopyMap_In[1339,2] = "B31";//【决战中原】洛阳势力6v6

$CopyMap_In[1379,1] = "B49";//【竞技场1v1】势力1
$CopyMap_In[1379,2] = "B50";//【竞技场1v1】势力2

$CopyMap_In[1369,1] = "B52";//【生死擂台】势力1
$CopyMap_In[1369,2] = "B53";//【生死擂台】势力2
//■■■■■■■■■【随机战场】■■■■【进入副本坐标】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■【随机战场】■■■■【进入副本判断】■■■■■■■■■■■■■■■■■■
function TransporPlayerToArena_On(%Player)
{
	if ((%Player.IsSchBuff(20023016))||(%Player.IsSchBuff(20023017)))
	{
		SendOneScreenMessage(2,"您正在服刑无法进行传送",%Player);
		return 0;
	}
	if (%Player.isInMultiMount())
	{
		SendOneScreenMessage(2,"多人骑乘下无法前往此地图",%Player);
		return 0;
	}

	return 1;
}
//■■■■■■■■■【随机战场】■■■■【进入副本判断】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■【随机战场】■■■■【进入副本操作】■■■■■■■■■■■■■■■■■■
function TransporPlayerToArena(%Player,%CopyMapLv,%Lv,%MapID)
{
}
//■■■■■■■■■【随机战场】■■■■【进入副本操作】■■■■■■■■■■■■■■■■■■
