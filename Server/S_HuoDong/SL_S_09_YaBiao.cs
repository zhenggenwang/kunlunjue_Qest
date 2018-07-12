//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//押镖
//==================================================================================
//■■■■【押镖】■■■■【全局变量】■■■■■■■■
//■■■■【押镖】■■■■【活动公告】■■■■■■■■
//■■■■【押镖】■■■■【NPC对话 】■■■■■■■■
//■■■■【押镖】■■■■【完成任务触发】■■■■■■
//■■■■【押镖】■■■■【离开当前地图触发】■■■■
//■■■■【押镖】■■■■【玩家被玩家击败】■■■■■
//■■■■【押镖】■■■■【镖车刷新】■■■■■■■■
//■■■■【押镖】■■■■【镖车宝箱】■■■■■■■■


//■■■■【押镖】■■■■【全局变量】■■■■■■■■
//411190001	镖师
//411190002	总镖头
//411190003	白色镖车
//411190004	绿色镖车
//411190005	蓝色镖车
//411190006	紫色镖车
//411190007	橙色镖车
//----镖车刷新信息-----------镖车ID--------刷新坐标---------朝向--大小--CD--------
$BiaoChe_Information[1] = "411190007;126.652 -156.479 119.981;180;1 1 1;720;";//橙色镖车位 
$BiaoChe_Information[2] = "411190006;118.652 -156.479 119.981;180;1 1 1;30;";//紫色镖车位
$BiaoChe_Information[3] = "411190006;114.652 -156.479 119.981;180;1 1 1;30;";//紫色镖车位
$BiaoChe_Information[4] = "411190005;115.884 -189.022 119.981;270;1 1 1;15;";//蓝色镖车位
$BiaoChe_Information[5] = "411190005;115.884 -184.911 119.981;270;1 1 1;15;";//蓝色镖车位
$BiaoChe_Information[6] = "411190005;115.884 -180.911 119.981;270;1 1 1;15;";//蓝色镖车位
$BiaoChe_Information[7] = "411190004;101.842 -188.735 119.981;90;1 1 1;8;";//绿色镖车位
$BiaoChe_Information[8] = "411190004;101.893 -184.625 119.981;90;1 1 1;8;";//绿色镖车位
$BiaoChe_Information[9] = "411190004;101.893 -180.625 119.981;90;1 1 1;8;";//绿色镖车位
$BiaoChe_Information[10] ="411190003;108.652 -156.479 119.981;180;1 1 1;5;";//白色镖车位
$BiaoChe_Information[11] ="411190003;104.652 -156.479 119.981;180;1 1 1;5;";//白色镖车位
$BiaoChe_Information[12] ="411190003;100.652 -156.479 119.981;180;1 1 1;5;";//白色镖车位
$BiaoChe_Information[13] ="411190003;96.6520 -156.479 119.981;180;1 1 1;5;";//白色镖车位

$YaBiaoHuoDong_DiaLogID[411190001,0] ="";//镖师
$YaBiaoHuoDong_DiaLogID[411190002,0] ="";//总镖头
$YaBiaoHuoDong_DiaLogID[411190003,0] ="600000041 600000042 600000043";//白色镖车
$YaBiaoHuoDong_DiaLogID[411190004,0] ="600000044 600000045 600000046";//绿色镖车
$YaBiaoHuoDong_DiaLogID[411190005,0] ="600000047 600000048 600000049";//蓝色镖车
$YaBiaoHuoDong_DiaLogID[411190006,0] ="600000050 600000051 600000052";//紫色镖车
$YaBiaoHuoDong_DiaLogID[411190007,0] ="600000053 600000054 600000055";//橙色镖车

//■■■■【押镖】■■■■【全局变量】■■■■■■■■

//■■■■【押镖】■■■■【活动公告】■■■■■■■■
function YaBiaoHuoDong_Information(%YY,%MM,%DD,%H,%M,%S)
{
	if (GetZoneid() != 1119)
		return;
	if ($SL_YaBiao_bActive != 1)
		return;
	%Nowtime = %H * 60 + %M;
	%Starttime = getword($SL_YaBiao_StartTime,0,":") * 60 + getword($SL_YaBiao_StartTime,1,":");
	%Endtime = getword($SL_YaBiao_EndTime,0,":") * 60 + getword($SL_YaBiao_EndTime,1,":");
	//%Path = GetTraceButton( "findpath(410010302);", GetNpcData( 410010302, 1 ) );//NPC寻径
	%Path = "<l i='811190100 108.789 -187.785 120' t='path'/>";

	%HuoDongMingCheng =  GetHuoDongName("押镖活动",1);

	%Text = "";
	%Text2 = "";
	if (%Starttime -  %Nowtime  == 10)
	{
		%Text = %HuoDongMingCheng @ "<t>将在</t>" @ $Get_Dialog_GeShi[31420] @ "10</t><t>分钟后开启，" @ $SL_YaBiao_Level @ "级以上修士可前往</t>" @ %Path @ "<t>查看活动详情。</t>";
		%Text2 = GetHuoDongName("押镖活动",2) @ "<t>将于</t>" @ $Get_Dialog_GeShi[60002]  @ "10</t><t>分钟后开启</t>";
	}
	if (%Starttime -  %Nowtime  == 5)
	{
		%Text = %HuoDongMingCheng @ "<t>将在</t>" @ $Get_Dialog_GeShi[31420] @ "5</t><t>分钟后开启，" @ $SL_YaBiao_Level @ "级以上修士可前往</t>" @ %Path @ "<t>查看活动详情。</t>";
		%Text2 = GetHuoDongName("押镖活动",2) @ "<t>将于</t>" @ $Get_Dialog_GeShi[60002]  @ "5</t><t>分钟后开启</t>";
	}
	if (%Starttime -  %Nowtime  == 0)
	{

		%Text = %HuoDongMingCheng @ "<t>已经开启，" @ $SL_YaBiao_Level @ "级以上修士可前往</t>" @ %Path @ "<t>查看活动详情。</t>";
		%Text2 = GetHuoDongName("押镖活动",2) @ "<t>已经开启</t>";
	}
	if (%Endtime - %Nowtime == 10)
	{
		%Text = %HuoDongMingCheng @ "<t>还有</t>" @ $Get_Dialog_GeShi[31420] @ "10</t><t>分钟结束，修士们抓紧时间哦。</t>";
		%Text2 = GetHuoDongName("押镖活动",2) @ "<t>还有</t>" @ $Get_Dialog_GeShi[60002]  @ "10</t><t>分钟结束</t>";
	}

	if (%Text !$= "")
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");
	if (%Text2 !$= "")
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);

	YaBiaoHuoDong_BiaoCheShuaXin(%YY,%MM,%DD,%H,%M,%S);
}
//■■■■【押镖】■■■■【活动公告】■■■■■■■■


//■■■■【押镖】■■■■【NPC对话 】■■■■■■■■
function YaBiaoHuoDong_DiaLog(%Npc,%Player,%State,%Conv)
{
	if ($SL_YaBiao_bActive != 1)
	{
		%Conv.SetText(600000039);
		return;
	}
	%NpcID = %Npc.GetDataID();
	%Conv.SetText(600000040);
	if ($SL_YaBiao_State_bActive == 1 && $IsAttackCityWar_State_bActive != 1)
	{
		if ($YaBiaoHuoDong_DiaLogID[%NpcID,%State] !$= "")
		{
			%Count = GetWordCount($YaBiaoHuoDong_DiaLogID[%NpcID,%State]);
			for (%i = 0; %i < %Count; %i++)
			{
				%DiaLogID = GetWord($YaBiaoHuoDong_DiaLogID[%NpcID,%State],%i);
				%Conv.AddOption(%DiaLogID,%DiaLogID);
			}
		}
	}
	if ($YaBiaoHuoDong_Gold[%State] !$= "")
	{
		if (%Player.GetLevel() < $SL_YaBiao_Level)
		{
			SendOneScreenMessage(2,$SL_YaBiao_Level @ "级以上才可以接取押镖任务",%Player);
			SendOneChatMessage($chatMsg_System,"<t>" @ $SL_YaBiao_Level @ "级以上才可以接取押镖任务" @ "</t>",%Player);
			return YaBiaoHuoDong_DiaLog(%Npc,%Player,0,%Conv);
		}
		if (%Player.GetLevel() < $SL_YaBiao_Level)
		{
			SendOneScreenMessage(2, $SL_YaBiao_Level @ "级以上才可以接取押镖任务", %Player);
			SendOneChatMessage($chatMsg_System, "<t>" @ $SL_YaBiao_Level @ "级以上才可以接取押镖任务" @ "</t>", %Player);
			return YaBiaoHuoDong_DiaLog(%Npc, %Player, 0, %Conv);
		}
		%Time = GetLocalTime();
		%H = GetWord(%Time, 3);	//时
		%M = GetWord(%Time, 4);	//分
		if (%H == 19 && %M >= 30)
		{
			%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//获得今天攻城方
			if (%OrgIDB > 0)
			{
				SendOneScreenMessage(2, "攻城战准备阶段，无法接镖", %Player);
				SendOneChatMessage($chatMsg_System, "<t>由于今晚有攻城战，当前处于准备阶段，无法接取押镖任务，您可以在攻城战结束后再来押镖。</t>", %Player);
				return YaBiaoHuoDong_DiaLog(%Npc, %Player, 0, %Conv);
			}
		}
		if (%Player.IsAcceptedMission(20147))
		{
			SendOneScreenMessage(2,"你已经接了一趟镖了",%Player);
			SendOneChatMessage($chatMsg_System,"<t>你已经接了一趟镖了</t>",%Player);
			return YaBiaoHuoDong_DiaLog(%Npc,%Player,0,%Conv);
		}
		else
		{
			if (%Act4018A = GetAct(%Player,4018,0) < VIP_getNowTequanLvMaxCnt(%Player, 7))
			{
				if (%Player.getmoney(2) >= GetWord($YaBiaoHuoDong_Gold[%State],2))
				{
					%Player.YaBiaoRecord = %State - 600000000;
					%Player.YaBiaoBiaoChe = %Npc;
					%Player.YaBiaoPosRecord = %player.getposition();
					ServerOnSptAction(%Player.GetPlayerID(),%Player.YaBiaoRecord,7);//通讯客户端 弹出押镖的确认框
					%Conv.Settype(4);
				}
				else
				{
					SendOneScreenMessage(2,"您的金币不足",%Player);
					return YaBiaoHuoDong_DiaLog(%Npc,%Player,0,%Conv);
				}
			}
			else
			{
				SendOneScreenMessage(2,"您的押镖次数已经用完，请明天再来吧",%Player);
				return YaBiaoHuoDong_DiaLog(%Npc,%Player,0,%Conv);
			}
		}
	}

}
function YaBiaoHuoDong_QueReng(%Player,%Optype)
{
	//echo( "押金类型%Optype===" @ %Optype );
	%RecordPos = %Player.YaBiaoPosRecord;
	%NowPos = %player.getposition();
	%Posxa = getword(%RecordPos,0);
	%Posya = getword(%RecordPos,1);
	%Posxb = getword(%NowPos,0);
	%Posyb = getword(%NowPos,1);
	if (msqrt(mpow(%Posxa - %Posxb,2) + mpow(%Posya - %Posyb,2)) >= 10)
	{
		SendOneScreenMessage(2,"镖车不存在或距离太远，接取失败",%Player);
		return;
	}
	%State = "6000000" @ %Optype;
	%Money = GetWord($YaBiaoHuoDong_Gold[%State],2);
	if (%Player.getmoney(2) >= %Money && isobject(%Player.YaBiaoBiaoChe))
	{
		%Player.Reducemoney(%Money,2,1,4018);
		%i = %Player.YaBiaoBiaoChe.NumberRecord;
		$YaBiaoHuoDong_TimeRecord[%i] =  GetWord(GetLocalTime(),3) @ ":" @ GetWord(GetLocalTime(),4);//记录死亡时间

		%Player.YaBiaoBiaoChe.SafeDeleteobject();//删除镖车

		%NpcID = Getword($BiaoChe_Information[%i],0,";") + 5;
		%Pos = Getword($BiaoChe_Information[%i],1,";");
		%Rot = Getword($BiaoChe_Information[%i],2,";");
		%Scale = Getword($BiaoChe_Information[%i],3,";");
		%Obj  = SpNewNpc3(0,%NpcID,%Pos,0,%Rot,%Scale);
		%Obj.SetInteractionEnabled(0);	//设置不可交互
		%Obj.SetMaster(%Player);
		%Player.BiaoCheSuiCong = %Obj;

		AddMissionAccepted(%Player,0,20147);
		%Act4018A = GetAct(%Player,4018,0);
		%Act4018B = GetAct(%Player,4018,1);
		%BiaoChePinZhi = GetWord($YaBiaoHuoDong_Gold[%State],0);
		%BiaoCheDangCi = GetWord($YaBiaoHuoDong_Gold[%State],1);
		%Act4018A++;
		%Act4018B = %BiaoChePinZhi * 100 + %BiaoCheDangCi * 10 + 1;
		SetAct(%Player,4018,%Act4018A,%Act4018B);

		if (%NpcID ==  411190012)//橙色镖车
		{
			%PlayerName = GetPlayerZiTiName(%Player,1);
			%HuoDongMingCheng = GetHuoDongName("橙色镖车",1);

			%Text = %PlayerName @ "<t>带着</t>" @ %HuoDongMingCheng @ "<t>出发了，大家祝他好运吧。</t>";
			SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

			%PlayerName2 = GetPlayerZiTiName(%Player,2);
			%HuoDongMingCheng2 = GetHuoDongName("橙色镖车",2);
			%Text2 = %PlayerName2 @ "<t>带着</t>" @ %HuoDongMingCheng2 @ "<t>出发了，大家祝他好运吧。</t>";
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
		}
		YaBiaoHuoDong_BiaoCheChengSe();//计算橙色镖车是否到了出现的时候了
	}
	else
	{
		SendOneScreenMessage(2,"您选中的镖车已经被押送",%Player);
	}
}

//■■■■【押镖】■■■■【NPC对话 】■■■■■■■■


//■■■■【押镖】■■■■【完成任务触发】■■■■■■
function Mission_Begin_Process_20147(%Npc,%Player,%Conv,%Param,%Mid)
{
	//echo( "%Mid====" @ %Mid );
	%Player.Addbuff(390100001,%Player,1);//押送镖车
	%Player.SetMissionFlag(%Mid,9100,1);
	Schedule(1000,0,"eval",%Player @ ".UpdateMission(" @ %Mid @ "); ");
}
function Mission_End_Process_20147(%Npc,%Player,%Conv,%Param,%Mid)
{
	%Act1 = GetAct(%Player,4018,1) * 1;
	if (%Act1 == 0)
		return;
	if (!isobject(%Player.BiaoCheSuiCong))
		return;

	%PinZhi1 = mfloor(%Act1/100);
	%DangCi1 = mfloor((%Act1 - %PinZhi1 * 100)/10);
	%IsBrok1 = %Act1%10;
	%State1 = $YaBiaoHuoDong_StateRecord[%PinZhi1,%DangCi1];
	//-----金钱计算
	if (%IsBrok1 == 1)
		%PlayerMoney = GetWord($YaBiaoHuoDong_Gold[%State1],3);
	else
		%PlayerMoney = GetWord($YaBiaoHuoDong_Gold[%State1],5);
	%Player.Addmoney(%PlayerMoney,2,1,4018);
	//----------道具计算
	//$YaBiaoHuoDong_Item[ %PinZhi1, 1 ] = "105105301 2 1800";
	for (%i = 1; %i <= 99; %i++)
	{
		if ($YaBiaoHuoDong_Item[%PinZhi1,%i] $= "")
			break;
		%Ran = GetRanDom(1,10000);
		%ItemRan = GetWord($YaBiaoHuoDong_Item[%PinZhi1,%i],2);
		switch (%DangCi1)
		{
			case 1:%ItemRan = %ItemRan * 0.8;
			case 2:%ItemRan = %ItemRan * 0.9;
			case 3:%ItemRan = %ItemRan * 1.0;
		}
		%ItemRan = %ItemRan/%IsBrok1;
		//echo( "%Ran===" @ %Ran @ "%ItemRan===" @ %ItemRan );
		if (%Ran <= %ItemRan)
		{
			%ItemID = GetWord($YaBiaoHuoDong_Item[%PinZhi1,%i],0);
			%ItemMsg = GetWord($YaBiaoHuoDong_Item[%PinZhi1,%i],1);
			%Player.PutItem(%ItemID,1);
			if (%Player.AddItem(1,20147))
			{
				if (%ItemMsg > 0)
				{
					%ItemName1 = GetItemName(%ItemID,1);
					%ItemName2 = GetItemName(%ItemID,2);
					%PlayerName1 = GetPlayerZiTiName(%Player,1);
					%PlayerName2 = GetPlayerZiTiName(%Player,2);
					%HuoDongMingCheng1 = GetHuoDongName("押镖",1);
					%HuoDongMingCheng2 = GetHuoDongName("押镖",2);
					%Text1 = %PlayerName1 @ "<t>在完成</t>" @ %HuoDongMingCheng1 @ "<t>时，额外获得了</t>" @ %ItemName1 @ "<t>，真是羡煞众人</t>";
					%Text2 = %PlayerName2 @ "<t>在完成</t>" @ %HuoDongMingCheng2 @ "<t>时，额外获得了</t>" @ %ItemName2;
					switch (%ItemMsg)
					{
						case 1:
							SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Text1 @ "</t>");
						case 2:
							SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
						case 3:
							SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Text1 @ "</t>");
							SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
					}
				}
			}
		}
	}
	//----------后续记录的处理
	%Player.BiaoCheSuiCong.Safedeleteobject();
	%Act0 = GetAct(%Player,4018,0) * 1;
	SetAct(%Player,4018,%Act0,0);
	if (%Player.GetBuffCount(39010,1) >= 1)
		%Player.Addbuff(390100001,%Player,-1);

	AddAchievementWatch(%Player, 0, 44, 1);//记录成就 押镖次数
	if (%PinZhi1 >= 4)
		AddAchievementWatch(%Player, 0, 49, 1);//记录成就 紫色镖车
}
//■■■■【押镖】■■■■【完成任务触发】■■■■■■


//■■■■【押镖】■■■■【离开当前地图触发】■■■■
function YaBiaoHuoDongChuLi(%Player)
{
	if (%Player.IsAcceptedMission(20147))
	{
		%Player.Delmission(20147);

		%Act0 = GetAct(%Player,4018,0) * 1;
		%Act1 = GetAct(%Player,4018,1) * 1;
		if (%Act1 > 0)
			SetAct(%Player,4018,%Act0,0);

		SendOneScreenMessage(2,"很遗憾，你的镖车已经丢失",%Player);
		SendOneChatMessage($chatMsg_System,"<t>很遗憾，你的镖车已经丢失</t>",%Player);
	}

}
//■■■■【押镖】■■■■【离开当前地图触发】■■■■


//■■■■【押镖】■■■■【玩家被玩家击败】■■■■■
//------依次为 0镖车品质 1镖的押金档次  2接任务消耗 3交任务获得金 4第一次被劫掉落 5劫镖者交镖奖励金 6再次被劫掉落
//$YaBiaoHuoDong_Gold[ 600000041 ]= "1 1 5000 8000 1750 2800 1750";
function GetMoneyForThisBiaoChe(%Act)
{
	%PinZhi = mfloor(%Act/100);
	%DangCi = mfloor((%Act - %PinZhi * 100)/10);
	%IsBrok = %Act%10;
	%State = $YaBiaoHuoDong_StateRecord[%PinZhi,%DangCi];

	return %Money;
}
function PlayeronDeathCast_1119A(%Player,%Killer)
{
	if (!%Player.IsAcceptedMission(20147))
		return;
	%Player.Delmission(20147);
	%Act0 = GetAct(%Player,4018,0) * 1;
	%Act1 = GetAct(%Player,4018,1) * 1;

	%PinZhi1 = mfloor(%Act1/100);
	%DangCi1 = mfloor((%Act1 - %PinZhi1 * 100)/10);
	%IsBrok1 = %Act1%10;
	%State1 = $YaBiaoHuoDong_StateRecord[%PinZhi1,%DangCi1];
	if (%IsBrok1 == 1)
		%PlayerMoney = GetWord($YaBiaoHuoDong_Gold[%State1],3);
	else
		%PlayerMoney = GetWord($YaBiaoHuoDong_Gold[%State1],5);
	//echo( "%Act0===" @ %Act0 );
	//echo( "%Act1===" @ %Act1 );

	if (%Act1 > 0)
		SetAct(%Player,4018,%Act0,0);
	SendOneScreenMessage(2,"很遗憾，你的镖车已经丢失",%Player);
	SendOneChatMessage($chatMsg_System,"<t>很遗憾，你的镖车已经丢失</t>",%Player);
	%NpcID = %Player.BiaoCheSuiCong.GetDataID();
	%NpcName = %Player.BiaoCheSuiCong.GetObjectName();

	//echo( "%NpcID===" @ %NpcID );
	//echo( "%NpcName===" @ %NpcName );

	%Act4018A = GetAct(%Killer,4018,0) * 1;
	%Act4018B = GetAct(%Killer,4018,1) * 1;
	%PinZhi2 = mfloor(%Act/100);
	%DangCi2 = mfloor((%Act - %PinZhi2 * 100)/10);
	%IsBrok2 = %Act%10;
	%State2 = $YaBiaoHuoDong_StateRecord[%PinZhi2,%DangCi2];
	if (%IsBrok2 == 1)
		%killerMoney = GetWord($YaBiaoHuoDong_Gold[%State2],3);
	else
		%killerMoney = GetWord($YaBiaoHuoDong_Gold[%State2],5);

	if (%IsBrok1 == 1)
		%LsatMoney = GetWord($YaBiaoHuoDong_Gold[%State1],4);
	else
		%LsatMoney = GetWord($YaBiaoHuoDong_Gold[%State1],6);

	if (%killerMoney <  %PlayerMoney && strlen(%NpcName) <= 8)
	{
		%Act4018B = mfloor(%Act1/10) * 10 + 2;
		SetAct(%Killer,4018,%Act4018A,%Act4018B);

		if (isobject(%Killer.BiaoCheSuiCong))
			%Killer.BiaoCheSuiCong.SafeDeleteobject();
		%Killer.BiaoCheSuiCong = SpNewNpc3(0,%NpcID,%Player.GetPosition(),0,0,"1 1 1");
		%Killer.BiaoCheSuiCong.SetMaster(%Killer);
		%Killer.BiaoCheSuiCong.SetShapeName(%Killer.BiaoCheSuiCong.GetObjectname() @ "【破损】");
		%Killer.BiaoCheSuiCong.SetInteractionEnabled(0);	//设置不可交互
		if (!%Killer.IsAcceptedMission(20147))
			AddMissionAccepted(%Killer,0,20147);
	}
	for (%i = 0; %i< 10; %i++)
	{

		if (%i != 9)
		{
			%MoneyCount = GetRandom(1,%LsatMoney * 0.35);
			%LsatMoney = %LsatMoney - %MoneyCount;
		}
		else
			%MoneyCount = %LsatMoney;
		SpNewDropItem(%Player.BiaoCheSuiCong,%Killer,105270001,%MoneyCount,0);
	}
	%Player.BiaoCheSuiCong.Safedeleteobject();
}
//■■■■【押镖】■■■■【玩家被玩家击败】■■■■■


//■■■■【押镖】■■■■【镖车刷新】■■■■■■■■
function YaBiaoHuoDong_BiaoCheShuaXin(%YY,%MM,%DD,%H,%M,%S)
{
	//echo( "$SL_YaBiao_State_bActive===" @ $SL_YaBiao_State_bActive );
	if ($SL_YaBiao_State_bActive != 1)//不在活动时间内
	{
		//------------镖车初始化刷新----------------
		for (%i = 2; %i<= 13; %i++)
		{
			if (!isobject($BiaoCheRecord[%i]))
			{
				%NpcID = Getword($BiaoChe_Information[%i],0,";");
				%Pos = Getword($BiaoChe_Information[%i],1,";");
				%Rot = Getword($BiaoChe_Information[%i],2,";");
				%Scale = Getword($BiaoChe_Information[%i],3,";");
				$BiaoCheRecord[%i] = SpNewNpc3(0,%NpcID,%Pos,0,%Rot,%Scale);
				$BiaoCheRecord[%i].NumberRecord = %i;//记录这个镖车的编号
				$YaBiaoHuoDong_TimeRecord[%i] = "00:00";//重置刷新CD
			}
		}
		if (isobject($BiaoCheRecord[1]))
			$BiaoCheRecord[1].SafeDeleteobject();//橙色镖车
		$YaBiaoHuoDong_TimeRecord[1] = "00:00";//重置刷新CD
		$AllFaCheMaxNumber = 0;
		return;
	}
	//-----------活动时间内，计算镖车是否需要重新刷新-------
	for (%i = 2; %i <= 13; %i++)
	{
		%CreateCD = GetWord($BiaoChe_Information[%i],4,";");
		%NowTime = %H * 60 + %M;
		%DieTime = GetWord($YaBiaoHuoDong_TimeRecord[%i],0,":") * 60 + GetWord($YaBiaoHuoDong_TimeRecord[%i],1,":");
		//echo( %i @ "  %NowTime=="  @ %NowTime  @ "  %DieTime==" @ %DieTime @ "  CD==" @  %CreateCD @ "   $YaBiaoHuoDong_TimeRecord[ %i ]==" @ $YaBiaoHuoDong_TimeRecord[ %i ] );
		if (%NowTime - %DieTime >= %CreateCD && !isobject($BiaoCheRecord[%i]))
		{
			%NpcID = Getword($BiaoChe_Information[%i],0,";");
			%Pos = Getword($BiaoChe_Information[%i],1,";");
			%Rot = Getword($BiaoChe_Information[%i],2,";");
			%Scale = Getword($BiaoChe_Information[%i],3,";");
			//echo( "%NpcID===" @ %NpcID @   "  " @ GetNpcData( %NpcID, 1 ) );
			$BiaoCheRecord[%i] = SpNewNpc3(0,%NpcID,%Pos,0,%Rot,%Scale);
			$BiaoCheRecord[%i].NumberRecord = %i;//记录这个镖车的编号
		}
	}
}
//-----------橙色镖车单独处理-------------------------------
function YaBiaoHuoDong_BiaoCheChengSe()
{
	//echo("橙色镖车单独处理==");
	$AllFaCheMaxNumber++;
	//echo("$AllFaCheMaxNumber == " @ $AllFaCheMaxNumber);
	if ($YaBiaoHuoDong_TimeRecord[1] !$= "00:00")
		return;
	if ($AllFaCheMaxNumber <= 50)
		return;
	%Ran = GetRandom(1,100);
	if (%Ran <= 5)
	{
		//echo("橙色镖车橙色镖车橙色镖车橙色镖车橙色镖车");
		%Path = "<l i='811190100 108.789 -187.785 120' t='path'/>";
		%HuoDongMingCheng = GetHuoDongName("橙色镖车",1);
		%Text = %HuoDongMingCheng @ "<t>将在</t>" @ $Get_Dialog_GeShi[31420] @ "5</t><t>分钟后出现，修士们还在什么，赶紧前往</t>" @ %Path @ "<t>抢镖吧。</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

		%HuoDongMingCheng2 = GetHuoDongName("橙色镖车",2);
		%Text2 = %HuoDongMingCheng2 @ "<t>将在</t>" @ $Get_Dialog_GeShi[60002] @ "5</t><t>分钟后出现</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);

		$YaBiaoHuoDong_TimeRecord[1] =  GetWord(GetLocalTime(),3) @ ":" @ GetWord(GetLocalTime(),4);
		Cancel($ScheduleOrangeBiaoCar);
		$ScheduleOrangeBiaoCar = Schedule(5 * 60 *1000,0,"CreateChengSeBiaoChe");
	}
}
function CreateChengSeBiaoChe()
{
	Cancel($ScheduleOrangeBiaoCar);
	if (isobject($BiaoCheRecord[1]))
		return;
	%NpcID = Getword($BiaoChe_Information[1],0,";");
	%Pos = Getword($BiaoChe_Information[1],1,";");
	%Rot = Getword($BiaoChe_Information[1],2,";");
	%Scale = Getword($BiaoChe_Information[1],3,";");
	$BiaoCheRecord[1] = SpNewNpc3(0,%NpcID,%Pos,0,%Rot,%Scale);
	$BiaoCheRecord[1].NumberRecord = 1;//记录这个镖车的编号

	%Path = "<l i='811190100 108.789 -187.785 120' t='path'/>";
	%HuoDongMingCheng = GetHuoDongName("橙色镖车",1);
	%Text = %HuoDongMingCheng @ "<t>出现在</t>" @ %Path @ "<t>，修士们赶紧去接镖吧。</t>";
	SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

	%HuoDongMingCheng2 = GetHuoDongName("橙色镖车",2);
	%Text2 = %HuoDongMingCheng2 @ "<t>已经出现</t>";
	SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
}
//■■■■【押镖】■■■■【镖车刷新】■■■■■■■■

//■■■■【押镖】■■■■【镖车宝箱】■■■■■■■■
function TriggerEvent_553000016(%Player,%Event,%EventID)
{
	//echo( "%Event===" @ %Event.GetObjectname( ) @  "   " @ %Event.MoneyRecord );
	if (%Event.MoneyRecord > 0)
		%Player.Addmoney(%Event.MoneyRecord,2,1,553000016);
	%Event.SafeDeleteobject();
	return 1;
}
//■■■■【押镖】■■■■【镖车宝箱】■■■■■■■■
