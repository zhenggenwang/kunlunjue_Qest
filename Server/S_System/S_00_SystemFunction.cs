function UPCS_Systemfunction(%Num)
{
	if ((%Num == 0)||(%Num == 99)){ Exec("./S_01_NewCheckCode.cs"); }
	if ((%Num == 1)||(%Num == 99)){ Exec("./S_02_ActivityRecord.cs"); }
	if ((%Num == 2)||(%Num == 99)){ Exec("./S_03_DuoBeiExp.cs"); }
}
UPCS_Systemfunction(99);

//■■■■■■【服务器活跃人数记录】■■■■■■■■
//■■■■■■【获取各大地图一个随机坐标】■■■■■
//■■■■■■【镜像层的进出】■■■■■■■■■■■
//■■■■■■【通知全服人做一些事情】■■■■■■■
//■■■■■■【处理玩家势力的切换】■■■■■■■■

//■■■■■■【服务器活跃人数记录】■■■■■■■■
function DelServerRenShuTongJi(%YY,%MM,%DD,%H,%M,%S)//服务器活跃人数清除
{
	if (!(%H == 23 && %M == 59))
		return;
	%MapID = GetZoneID();
	if (%MapID != 1001)
		return;
	%LineID = GetCurrentLineId();//线程ID
	%LocalWeek = GetLocalWeek();
	%LocalWeek++;
	if (%LocalWeek > 6)
		%LocalWeek = 0;
	%ShiJianID = (%LocalWeek + 1)* 100 + %LineID;
	SetServerSystemEvent(%ShiJianID,0,0);
}
function GetRenShuTongJiForEveryday(%Days)//依次取出最近几天的活跃人数，最后一天是今天 %Days参数代表你要取几天的
{
	if (%Days > 7)
		%Days = 7;
	%LineID = GetCurrentLineId();//线程ID
	%LocalWeek = GetLocalWeek();
	%List = "";
	for (%i = 0; %i <= %Days - 1; %i++)
	{
		%NeedWeek = %LocalWeek - %i;
		if (%NeedWeek < 0)
			%NeedWeek = %NeedWeek + 7;
		%ShiJianID = (%NeedWeek + 1)* 100 + %LineID;
		%Number = GetWord(GetServerSystemEvent(%ShiJianID),0) * 1;
		//echo( "%NeedWeek===" @ %NeedWeek @ "     %ShiJianID===" @ %ShiJianID );
		%List = %Number @ " " @ %List;
	}
}
function GetRenShuTongJiFor7Day(%Days)//%Days == 6 获取前6天的活跃用户数量 %Days == 7 获取最近7天（包括今天）的活跃用户数量
{
	%LineID = GetCurrentLineId();//线程ID
	%AllNum = 0;
	for (%i=0; %i<=6; %i++)
	{
		%ShiJianID = (%i + 1)* 100 + %LineID;
		%Number = GetWord(GetServerSystemEvent(%ShiJianID),0);
		%AllNum = %AllNum + %Number;
	}
	if (%Days == 6)
	{
		%TodayNum = GetRenShuTongJiFortoday();
		%AllNum = %AllNum - %TodayNum;
	}
	return %AllNum;
}
function GetRenShuTongJiFor3Day()//获取前3天的活跃用户数量
{
	%LineID = GetCurrentLineId();//线程ID
	%LocalWeek = GetLocalWeek();
	%AllNum = 0;
	%NeedWeek[1]= %LocalWeek - 1; %NeedWeek[2]= %LocalWeek - 2; %NeedWeek[3]= %LocalWeek - 3;
	for (%i = 1; %i<= 3; %i++)
	{
		%NeedWeek = %NeedWeek[%i];
		if (%NeedWeek < 0)
			%NeedWeek  = %NeedWeek + 7;
		%ShiJianID = (%NeedWeek + 1)*100 + %LineID;
		%Number = GetWord(GetServerSystemEvent(%ShiJianID),0);
		%AllNum = %AllNum + %Number;
	}
	return %AllNum;
}
function GetRenShuTongJiForYesterday()//获取昨天的活跃用户数量
{
	%LineID = GetCurrentLineId();//线程ID
	%LocalWeek = GetLocalWeek();
	%NeedWeek = %LocalWeek - 1;
	if (%LocalWeek < 0)
		%LocalWeek = %LocalWeek + 7;
	%ShiJianID = (%NeedWeek + 1)*100 + %LineID;
	%Number = GetWord(GetServerSystemEvent(%ShiJianID),0);
	return %Number;
}
function GetRenShuTongJiFortoday()//获取今天的活跃用户数量
{
	%LineID = GetCurrentLineId();//线程ID
	%LocalWeek = GetLocalWeek();
	%ShiJianID = (%LocalWeek + 1)*100 + %LineID;
	%Number = GetWord(GetServerSystemEvent(%ShiJianID),0);
	return %Number;
}
function SendRenShuTongJito1001(%Player)//通知1001刷新当前人数
{
	%Functionname = "SetFuWuQiRenShuTongJi( );";
	SptInterMapExecute(1001,%Functionname);
}
function SetFuWuQiRenShuTongJi()//服务器统计人数+1
{
	%LineID = GetCurrentLineId();//线程ID
	%LocalWeek = GetLocalWeek();
	%ShiJianID = (%LocalWeek + 1)*100 + %LineID;
	%Number0 = GetWord(GetServerSystemEvent(%ShiJianID),0);
	%Number1 = GetWord(GetServerSystemEvent(%ShiJianID),1);
	%Number0++;
	SetServerSystemEvent(%ShiJianID,%Number0,%Number1);
}
//■■■■■■【服务器活跃人数记录】■■■■■■■■


//■■■■■■【获取各大地图一个随机坐标】■■■■■
function GetRandomPosForMap(%MapID)
{
	switch (%MapID)
	{
		case 0://藏宝图专用
			%MapList = "1101 1001 1102";
			%Count = GetWordCount(%MapList);
			%Ran = GetRanDom(0,%Count -1);
			%MapID = GetWord(%MapList,%Ran);
			return  GetRandomPosForMap(%MapID);
		case 1://随机卷轴专用
			%MapID = GetZoneID();
			%PosID = getrandom(1,$strMapRanPosRecordMax[%MapID]);
			%RealPos = $strMapRanPosRecord[%MapID,%PosID];
			return %RealPos;
		default:
			%PosID = getrandom(1,$strMapRanPosRecordMax[%MapID]);
			%RealPos = $strMapRanPosRecord[%MapID,%PosID];
			return %MapID @ " " @ %PosID @ " " @ %RealPos;
	}
}
//■■■■■■【获取各大地图一个随机坐标】■■■■■


//■■■■■■【镜像层的进出】■■■■■■■■■■■
function ChangeLogicFloor(%Player,%Now,%Next)//对象 从%now层 到%next层
{
	%Player.AddLogicFloor(%Next);//设置到镜像
	%Player.delLogicFloor(%Now);
	%Player.LogicFloorRecord = %Next;
}
//■■■■■■【镜像层的进出】■■■■■■■■■■■

//■■■■■■【通知全服人做一些事情】■■■■■■■
function TeHuiTeXiaoShuaXin(%YY,%MM,%DD,%H,%M,%S)//0 6 12 18点时刷新特惠按钮的特效
{
	//echo( "%H ==" @ %H  @ "    %M===" @ %M );
	if (%H == 0 || %H == 6 || %H == 12 || %H == 18)
	{
		if (%M == 1)
		{
			%PlayerCount = GetPlayerCount();
			//echo( "%PlayerCount==="  @ %PlayerCount );
			for (%i = 0; %i < %PlayerCount; %i++)
			{
				%Player = GetPlayerByIndex(%i);
				//echo( "%Player==="  @ %Player );
				if (isobject(%Player))
				{
					%Act0 = GetAct(%Player,4000,0);
					if (%Act0 $= "" || %Act0 == 0)
						HelpDirectByIndex(%Player.GetPlayerID(),21);	//通讯客户端
				}
			}
		}
	}
}
//■■■■■■【通知全服人做一些事情】■■■■■■■


//■■■■■■【处理玩家势力的切换】■■■■■■■■
function InfluenceDispose(%Player)
{
	//%obj.setInfluence(%influence);//设置势力
	//%Obj.GetInfluence();//	获取势力
	%MapID = GetZoneID();
	%PkValue = %Player.GetPkValue();

	%PlayerID = %Player.GetPlayerID();
	%OrgIDA = SptOrg_GetAttackCityOrgIdinfo(1);//获取守城方
	%orgID = SptOrg_GetOrgID(%PlayerID);
	if (%OrgIDA == %orgID)
		%IsFengMoCheng = 1;//是否是封魔城占领公会成员
	else
		%IsFengMoCheng = 0;//是否是封魔城占领公会成员

	if (%MapID >= 1300)
		%Influence = 0;
	else if (%MapID == 1119 && $IsAttackCityWar_State_bActive == 1)//攻城战
	{
		if (%IsFengMoCheng == 1)
			%Influence = 8;//守城势力
		else
		{
			%OrgIDB = SptOrg_GetAttackCityOrgIdinfo(2);//获得今天攻城方
			if (%OrgIDB == %orgID)
				%Influence = 7;//攻城势力
			else
				%Influence = 0;//其他势力
		}
	}
	else
	{
		switch (%IsFengMoCheng)
		{
			case 1:	%Influence = 2;//封魔城
			default:%Influence = 0;//默认势力
		}
	}

	if (%PkValue >= 1) //红名玩家
	{
		switch (%IsFengMoCheng)
		{
			case 1:	%Influence = 4;//封魔城
			default:%Influence = 3;//默认势力
		}
	}

	%Player.SetInfluence(%influence);//设置势力
}
/*
暂时没用	0
玩家默认势力	1
封魔城	2
红名玩家	3
封魔城红名玩家	4
守卫	5
封魔城守卫	6
攻城势力	7
守城势力	8
备用1	9
备用2	10
备用3	11
备用4	12
备用5	13
NPC	14
人	15
恶人	16
动物	17
怪物	18
野兽	19
凶兽	20
长安	21
洛阳	22
神邸	23
神罚者	24
战场1	25
战场2	26
*/



$LaJi[0]="暂时没用";
$LaJi[1]="玩家默认势力";
$LaJi[2]="封魔城";
$LaJi[3]="红名玩家";
$LaJi[4]="封魔城红名玩家";
$LaJi[5]="守卫";
$LaJi[6]="封魔城守卫";
$LaJi[7]="攻城势力";
$LaJi[8]="守城势力";
$LaJi[9]="备用1";
$LaJi[10]="备用2";
$LaJi[11]="备用3";
$LaJi[12]="备用4";
$LaJi[13]="备用5";
$LaJi[14]="NPC";
$LaJi[15]="人";
$LaJi[16]="恶人";
$LaJi[17]="动物";
$LaJi[18]="怪物";
$LaJi[19]="野兽";
$LaJi[20]="凶兽";
$LaJi[21]="长安";
$LaJi[22]="洛阳";
$LaJi[23]="神邸";
$LaJi[24]="神罚者";
$LaJi[25]="战场1";
$LaJi[26]="战场2";


function asdsadd()
{
	for (%i = 0;%i <= 26;%i++)
	{
		for (%j = 0;%j<=26;%j++)
		{
			echo($LaJi[%i] @ "  " @ $LaJi[%j]);
		}
	}
}

//■■■■■■【处理玩家势力的切换】■■■■■■■■