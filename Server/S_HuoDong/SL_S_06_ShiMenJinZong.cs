//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//师门尽忠
//=================================================================================

//■■■■【师门尽忠】■■■■【 NPC对话】■■■■■■■■
//■■■■【师门尽忠】■■■■【任务接取】■■■■■■■■
//■■■■【师门尽忠】■■■■【任务奖励】■■■■■■■■
//■■■■【师门尽忠】■■■■【对话处理】■■■■■■■■



//■■■■【师门尽忠】■■■■【 NPC对话】■■■■■■■■
function ShiMenJinZong_Dialog(%Npc,%Player,%State,%Conv)
{
	//echo( "$SL_ShiMenJinZong_State_bActive==" @ $SL_ShiMenJinZong_State_bActive );
	if ($SL_ShiMenJinZong_State_bActive != 1)
		return;
	if (%player.getlevel() < 20)
		return;

	switch (%state)
	{
		case 0:
			//echo( "========" @ !%Player.IsAcceptedMission( 20149 ) );
			%Act4015[0] = GetAct(%player, 4015, 0);
			if (!%Player.IsAcceptedMission(20149) && %Player.GetLevel() >= $SL_ShiMenJinZong_Level && %Act4015[0] <= 9)
				%Conv.AddOption(600000025,600000025);
		case 600000025:
			%Conv.Settype(4);
			if (%player.isschbuff(2003))
			{
				SendOneScreenMessage(2,"你还是先好好反省下吧！",%Player);
				SendOneChatMessage($chatMsg_System,"<t>你还是先好好反省下吧！</t>",%Player);
				return;
			}
			if (%Player.GetBagEmptyCount() < 1)
			{
				SendOneScreenMessage(2,"请预留一格以上的包裹空格！",%Player);
				SendOneChatMessage($chatMsg_System,"<t>请预留一格以上的包裹空格！</t>",%Player);
				return;
			}
			if (%Player.Isschbuff(2021))
			{
				SendOneScreenMessage(2,"心魔入体，无法接取师门任务！",%Player);
				SendOneChatMessage($chatMsg_System,"<t>心魔入体，无法接取师门任务！</t>",%Player);
				return;
			}
			if (%Player.Getlevel() < $SL_ShiMenJinZong_Level)
			{
				SendOneScreenMessage(2,"等级低于" @ $SL_ShiMenJinZong_Level @ "，无法接取师门任务！",%Player);
				SendOneChatMessage($chatMsg_System,"<t>等级低于" @ $SL_ShiMenJinZong_Level @ "，无法接取师门任务！</t>",%Player);
				return;
			}
			%Act4015[0] = GetAct(%player,4015,0);
			if (%Act4015[0] > 9)
			{
				SendOneScreenMessage(2,"今天已经完成10次任务了，请明天再来吧！",%Player);
				SendOneChatMessage($chatMsg_System,"<t>今天已经完成10次任务了，请明天再来吧！</t>",%Player);
				return;
			}
			AddMissionAccepted(%Player,%Conv,20149);
	}
}
//■■■■【师门尽忠】■■■■【 NPC对话】■■■■■■■■

//■■■■【师门尽忠】■■■■【任务接取】■■■■■■■■
$shimenjinzong_missflag[1] ="410100003;1"; //对话NPC 	玄业
$shimenjinzong_missflag[2] ="410100004;1"; //对话NPC 	玄光
$shimenjinzong_missflag[3] ="410100005;1"; //对话NPC 	玄仁
$shimenjinzong_missflag[4] ="410100006;1"; //对话NPC 	张平凡
$shimenjinzong_missflag[5] ="410100007;1"; //对话NPC 	杨子石
$shimenjinzong_missflag[6] ="410100008;1"; //对话NPC 	张德山
$shimenjinzong_missflag[7] ="410100009;1"; //对话NPC 	王君
$shimenjinzong_missflag[8]="410100011;1"; //对话NPC 	王知章
$shimenjinzong_missflag[9]="410100032;1"; //对话NPC 	芳华
$shimenjinzong_missflag[10]="410100031;1"; //对话NPC 	刹那
$shimenjinzong_missflag[11]="108020994;1"; //获得物品	百丈蚕丝
$shimenjinzong_missflag[12]="108020995;1"; //获得物品	灵兽卵
$shimenjinzong_missflag[13]="108020996;1"; //获得物品	补兽笼
$shimenjinzong_missflag[14]="108020997;1"; //获得物品	千年温玉
$shimenjinzong_missflag[15]="108020998;1"; //获得物品	铁木
$shimenjinzong_missflag[16]="108020999;1"; //获得物品	玄星石
$shimenjinzong_missflag[17]="108021000;1"; //获得物品	玄海冰魄
$shimenjinzong_missflag[18]="108021002;1"; //获得物品	泠泷泉 108021001	空瓶子
$shimenjinzong_missflag[19]="552000010;4"; //采集	  	伏灵草
$shimenjinzong_missflag[20]="552000011;1"; //采集	  	灵枫木
$shimenjinzong_missflag[21]="552000012;4"; //采集	  	紫兰花
$shimenjinzong_missflag[22]="552000013;1"; //采集	  	卷宗
$shimenjinzong_missflag[23]="552000014;1"; //采集	  	玄天露
$shimenjinzong_missflag[24]="553000050;1"; //采集	  	蓬莱道经
$shimenjinzong_missflag[25]="410101002 ;10"; //青灵螺
$shimenjinzong_missflag[26]="410101004 ;10"; //螃蟹精
$shimenjinzong_missflag[27]="410101014 ;10"; //灵菇小妖
$shimenjinzong_missflag[28]="410101015 ;10"; //树妖
$shimenjinzong_missflag[29]="410101020;1"; //挑战心魔	心魔


//	npcf04_003  伏灵草
//	npcf02_006	灵枫木
//	npcf04_010  紫兰花
//	npce01_008	卷宗
//	npcf05_003	玄天露


function Mission_Begin_Process_20149(%Npc,%Player,%Conv,%Param,%Mid)
{

	%Act4015[0] = GetAct(%player,4015,0);
	%Act4015[1] = GetAct(%player,4015,1);

	if (%Act4015[0] < 5)
		%ran = getrandom(1,24);
	else if (%Act4015[0] < 9)
		%ran = getrandom(1,28);
	else if (%Act4015[0] == 9)
		%ran = getrandom(25,29);
	else
		%ran = getrandom(1,29);
	//echo("师门任务第" @ %ran @ "个");
	if (%ran >= 29)
		%ran = 29;

	if (%Act4015[0] > 2 && %Act4015[0]  <= 8)
	{
		%Src = GetSrc(%Player,58);
		switch (%Src)
		{
			case 0:%Re = 3;
			case 1:%Re = 1;
		}
		%Rn = GetRandom(1,10);
		if (%Rn <= %Re)
		{
			%ran = 29;
			if (%Src  == 0)
				SetSrc(%Player,58);
		}

	}
	%missionflag = $shimenjinzong_missflag[%ran];
	%missiontar = getword(%missionflag,0,";");
	%missionnum = getword(%missionflag,1,";");
	switch$(getsubstr(%missiontar,0,1))
	{
		case "1"://获取道具
			%midtarflag = 2100;
		case "5"://采集
			%midtarflag = 2130;
		case "4"://NPC
			if (getnpcdata(%missiontar,16) == 14)//中立NPC 对话
			{
				%midtarflag = 1150;
			}
			else//击败
			{
				%midtarflag = 3100;
			}
	}
	if (%midtarflag > 0)
	{
		%Act4015[0]++;
		Setact(%player,4015,%Act4015[0],%Act4015[1]);
		%Player.SetMissionFlag(%Mid,%midtarflag,%missiontar);
		%Player.SetMissionFlag(%Mid,%midtarflag + 100,%missionnum);

		if (%midtarflag == 2130)//采集需要特殊处理一下
		{
			%Player.SetMissionFlag(%Mid,1400,%missiontar);
			%Player.SetMissionFlag(%Mid,1500,%midtarflag + 100);
		}
		if (%midtarflag == 2100)
		{
			%iNowHasCount = %Player.GetItemCount(%missiontar);
			if (%iNowHasCount >= %missionnum)
				%iNowHasCount = %missionnum;
			%Player.SetMissionFlag(%Mid,%midtarflag + 200,%iNowHasCount);
		}
		if (%missiontar ==  108021002)
		{
			%Player.Putitem(108021001,1);
			%Player.Additem(1, %Mid);
		}
		%Player.SetMissionFlag(%Mid,9100,1);
		%Player.SetMissionFlag(%Mid,9101,1);

		%Player.SetMissionFlag(%Mid,10300,%missiontar);         //设置任务类型旗标

		Schedule(500,0,"eval",%Player @ ".updatemission(" @ %Mid @ "); ");
	}
}
//■■■■【师门尽忠】■■■■【任务接取】■■■■■■■■




//■■■■【师门尽忠】■■■■【任务奖励】■■■■■■■■

function Mission_End_Process_20149(%Npc,%Player,%Conv,%Param,%Mid)
{
	%PlayerID = %Player.getPlayerID();
	%Act4015[0] = GetAct(%player,4015,0);
	%Act4015[1] = GetAct(%player,4015,1);
	%exp = 62;
	%Level = %Player.getlevel();
	if (%Level < 30) %levelxishu = 0.3;
	else if (%Level < 40) %levelxishu = 1;
	else if (%Level < 50) %levelxishu = 1.2;
	else if (%Level < 60) %levelxishu = 1.6;
	else if (%Level < 70) %levelxishu = 2;
	else %levelxishu = 2.2;
	//给予经验	EXP = （62+环数*8）*玩家等级对应经验 * 等级微调系数
	%exp = (%exp +  %Act4015[0] * 8) * $Monster_Exp[%Level,1] * %levelxishu;
	if (%exp > 0)
		AllAddExp(%Player,%exp);

	if (%Act4015[0] == 10 &&  %Act4015[1] == 0)
	{
		%player.putitem(105109341,1);
		if (%player.additem(1, %Mid))
		{
			%ItemName2 = GetItemName(105109341,2);

			%PlayerName2 = GetPlayerZiTiName(%Player,2);
			%HuoDongMingCheng2 =  GetHuoDongName("师门尽忠",2);
			%Text2 = %PlayerName2 @ "<t>完成</t>" @ %HuoDongMingCheng2 @ "<t>，获得了</t>" @ %ItemName2;
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
		}
	}
	
	//----------设置主线师门跑环任务完成-------
	if (%Player.IsAcceptedMission(20207))
		ShiMenPaoHuan_20207(%Player,20207);

	AddAchievementWatch(%Player,0,34,1);//记录成就
}

//■■■■【师门尽忠】■■■■【任务奖励】■■■■■■■■


//■■■■【师门尽忠】■■■■【对话处理】■■■■■■■■
function Mission_Special_20149(%Npc,%Player,%State,%Conv,%mid)
{
	if (!%Player.IsAcceptedMission(%Mid))
		return;
	%Missiontarget = %Player.GetMissionFlag(%Mid,10300);
	//echo( "%Missiontarget==" @ %Missiontarget );
	if (%Missiontarget  != %Npc.getdataid())
		return;
	if (%Player.GetMissionFlag(%Mid,1350) >= 1)
		return;
	switch (%state)
	{
		case 0:
			%Conv.AddOption(400 @ %Mid,400 @ %Mid);
		case 400 @ %Mid:
			%Player.SetMissionFlag(%Mid,1350,1);
			SendOneScreenMessage(1,"对话【" @ %Npc.getobjectname() @ "】  1/1",%Player);
			%Conv.settext(500 @ %Mid);
			%Player.UpdateMission(%Mid);
	}
}
//■■■■【师门尽忠】■■■■【对话处理】■■■■■■■■



function Trigger_108021001(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	%Posx = GetWord(%Player.GetPosition(),0);
	%Posy = GetWord(%Player.GetPosition(),1);
	%X = -26.2497;
	%Y = 65.519;
	if (msqrt(mpow(%Posx - %X,2) + mpow(%Posy - %Y,2)) < 10)
	{
		%Player.Putitem(%type,-1);
		%Player.Putitem(108021002,1);
		%Player.Additem(1,20149);
	}
}