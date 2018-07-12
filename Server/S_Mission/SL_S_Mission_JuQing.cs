//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//剧情任务
//主线剧情
//生活剧情
//
//==================================================================================
//■■■■■■■■■■■■■■■■【主线剧情】■■■■■■■■■■■■■■■■
function Mission_Special_10001(%Npc,%Player,%State,%Conv,%mid)//新手指引对话杨子石
{
	%PlayerID = %Player.GetPlayerID();
	%AAA = %Player.IsAcceptedMission(10001);//获取任务
	HelpDirectByIndex(%PlayerID,16);
	if (%AAA ==1)
	{
		switch (%state)
		{
			case 0:
				%Conv.SetText(511 @ %Mid);
				%Conv.AddOption(412 @ %Mid,412 @ %Mid);
			case 412 @ %Mid:
				%Conv.SetText(512 @ %Mid);
				%Conv.AddOption(413 @ %Mid,413 @ %Mid);
			case 413 @ %Mid:
				%Conv.SetText(513 @ %Mid);
				%Conv.AddOption(414 @ %Mid,414 @ %Mid);
			case 414 @ %Mid:
				%Conv.SetText(514 @ %Mid);
				%Conv.AddOption(415 @ %Mid,415 @ %Mid);
			case 415 @ %Mid:
				if (%Player.GetSex() == 1)//男
				{
					%Conv.SetText(515 @ %Mid);
					%Player.SetMission(10001,1);//完成任务
					Schedule(6000,0,"AddMissionAccepted",%Player,0,10002);//接下一个任务
					Schedule(3000,0,"OnSptActionEvent_S",%Player,9,%SubType);
				}
				else
				{
					%Conv.SetText(516 @ %Mid);
					%Player.SetMission(10001,1);//完成任务
					Schedule(6000,0,"AddMissionAccepted",%Player,0,10002);//接下一个任务
					Schedule(3000,0,"OnSptActionEvent_S",%Player,9,%SubType);
				}
		}
	}
	else
	{
		switch ( %state )
		{
			case 0:
				%Conv.SetText( 514 @ %Mid );
				%Conv.AddOption( 416 @ %Mid, 416 @ %Mid );
			case 416 @ %Mid:
				if ( %Player.GetSex( ) == 1 )//男
				{
					%Conv.SetText( 515 @ %Mid );
					Schedule( 6000, 0, "AddMissionAccepted", %Player, 0, 10002 );//接下一个任务
					Schedule( 3000, 0, "OnSptActionEvent_S", %Player, 9, %SubType );
				}
				else
				{
					%Conv.SetText( 516 @ %Mid );
					Schedule( 6000, 0, "AddMissionAccepted", %Player, 0, 10002 );//接下一个任务
					Schedule( 3000, 0, "OnSptActionEvent_S", %Player, 9, %SubType );
				}
		}
	}
}

function Mission_ChuanDaiZhuangBei_10151(%Player,%Mid)
{
	if (%Player.IsAcceptedMission(10151))
	{
		%Player.SetMissionFlag(%Mid,1350,1);
		SendOneScreenMessage(1,"穿戴装备  1/1",%Player);
		%Player.UpdateMission(%Mid);
	}
}
function Mission_Special_10191(%Npc,%Player,%State,%Conv,%mid)//戒律
{
	if (%Player.IsAcceptedMission(10191))//获取任务
	{
		%Type = %Player.GetMissionFlag(10191,1350);
		%Num = %Player.GetMissionFlag(10191,1250);
		if (%Type < %Num)
		{
			switch (%state)
			{
				case 0:
					%Conv.SetText(531 @ %Mid);
					%Conv.AddOption(431 @ %Mid,431 @ %Mid);
					%Conv.AddOption(432 @ %Mid,432 @ %Mid);
					%Conv.AddOption(433 @ %Mid,433 @ %Mid);
				case 431 @ %Mid:
					%Conv.SetText(532 @ %Mid);
					%Conv.AddOption(4,0);
				case 432 @ %Mid:
					%Conv.SetText(533 @ %Mid);
					%Conv.AddOption(4,0);
				case 433 @ %Mid:
					%Conv.SetText(534 @ %Mid);
					%Conv.AddOption(434 @ %Mid,434 @ %Mid);
				case 434 @ %Mid:
					%Conv.SetText(535 @ %Mid);
					%Conv.AddOption(435 @ %Mid,435 @ %Mid);
					%Conv.AddOption(436 @ %Mid,436 @ %Mid);
				case 435 @ %Mid:
					%Conv.SetText(536 @ %Mid);
					%Conv.AddOption( 438 @ %Mid, 438 @ %Mid );
				case 436 @ %Mid:
					%Conv.SetText(537 @ %Mid);
					%Conv.AddOption(437 @ %Mid,437 @ %Mid);
				case 437 @ %Mid:
					%Conv.SetText(538 @ %Mid);
					%Player.SetMissionFlag(%Mid,1350,1);
					SendOneScreenMessage(1,"考核完成  1/1",%Player);
					%Player.UpdateMission(%Mid);
				case 438 @ %Mid:
					%Conv.SetText( 535 @ %Mid );
					%Conv.AddOption( 435 @ %Mid, 435 @ %Mid );
					%Conv.AddOption( 436 @ %Mid, 436 @ %Mid );
			}
		}
	}
}

function Mission_End_Process_10163(%Npc,%Player,%Conv,%Param,%Mid)//指引使用坐骑
{
	ServerOnSptAction(%Player.GetPlayerID(),119014025,1);
}
function TanKuangQueRen_10241(%Player)//试炼之地  弹框确认
{
	if (%Player.IsAcceptedMission(10241))
	{
		%Player.SetMission(10241,1);//完成
		%Player.AddExp(1000);
		AddMissionAccepted(%Player,0,10251);//接下一个任务
	}
}
function TanKuangQueRen_10291(%Player)//探查源头  弹框确认
{
	if (%Player.IsAcceptedMission(10291))
	{
		ChangeLogicFloor(%Player,0,%Player);//进入镜像层
		%Player.SetMission(10291,1);//完成
		%Player.AddExp(1500);
		AddMissionAccepted(%Player,0,10301);//接下一个任务
	}
}
function Mission_Special_10301(%Player,%mid)//树妖重新树怪
{
	if (!isobject(%Player.Monster_ShuYaoZhiLing))//判断这个怪有没有
	{
		%Monster = SpNewNpc(%Player,410101016,"138.038 -55.6684 144.906",0);
		%Monster.SetExclusivePlayerId(%Player.GetPlayerID()); //设置怪物独占玩家
		ChangeLogicFloor(%Monster,0,%Player);
		%Player.Monster_ShuYaoZhiLing = %Monster;
	}
}


function Mission_Special_10341(%Npc,%Player,%State,%Conv,%mid)//进入密地
{
	%AAA = %Player.IsAcceptedMission(10341);

	if (%AAA >=1)
	{
		switch (%state)
		{
			case 0:
				%Conv.AddOption(418 @ %Mid,418 @ %Mid);
			case 418 @ %Mid:
				%player.TransportObject(0,0,-175.45,141.746,430.737);//传送坐标
		}
	}
}

function XiaoDianYing_ChuFa_001(%Npc,%Player,%State,%Conv,%mid)
{
	//echo( "%Mid ====" @ %Mid @ "     " @ %Player.IsAcceptedMission( 10341 ) );
	if (%Player.IsAcceptedMission(10341))
	{
		//设置玩家镜像
		ChangeLogicFloor(%Player,%Player,0);
		%player.Addbuff(390210001);  //临时神兵护体buff
		SendOneScreenMessage(1,"获得【神兵护体】",%Player);
	}
}

function XiaoDianYing_ChuFa_003(%Npc,%Player,%State,%Conv,%mid)//禁地任务已经完成
{
	if (%Player.IsAcceptedMission(10341))
	{
		%player.TransportObject(0,0,33.4158,115.416,135);//传送坐标
		%Player.Removebuff(390210001);//删除神兵buff
		ChangeLogicFloor(%Player,%Player,0);
		%Player.SetMission(10341,1);//完成
		AddMissionAccepted(%Player,0,10351);//接下一个任务
		%Lv = %Player.getLevel();
		%Exp = %Player.getExp();
		if (%Lv < 29){ %Player.AddLevel(29 - %Lv); }
		if (%Lv <= 29) { %Player.AddExp(26950 - %Exp); }
	}
}
$XinShouRenWu_Monster_ID[1,1]  = "413031011";	$XinShouRenWu_Monster_XYZ[1,1] = "-178.419 140.165 430.717";	$XinShouRenWu_Monster_Ret[1,1] = "0  ";
$XinShouRenWu_Monster_ID[1,2]  = "410100057";	$XinShouRenWu_Monster_XYZ[1,2] = "-175.983 162.488 432.793";	$XinShouRenWu_Monster_Ret[1,2] = "180";
$XinShouRenWu_Monster_ID[1,3]  = "410100024";	$XinShouRenWu_Monster_XYZ[1,3] = "98.303 -206.185 108.364 ";	$XinShouRenWu_Monster_Ret[1,3] = "150";
$XinShouRenWu_Monster_ID[1,4]  = "410100025";	$XinShouRenWu_Monster_XYZ[1,4] = "100.461 -205.963 107.688";	$XinShouRenWu_Monster_Ret[1,4] = "180";
function XinShouRenWu_spnewnpc()//新手任务NPC刷新
{
	//echo( "$XinShouRenWu_NPC =====================" @ $XinShouRenWu_NPC );
	if (getzoneid() < 1010 && getzoneid() > 1012)
		return;
	//if ( $XinShouRenWu_Npc_shuaxinjilu = 1 )//刷新记录
	//	return;
	if ($XinShouRenWu_NPC < 1 && getzoneid() >= 1010 && getzoneid() <= 1012)
	{
		for (%i = 1; %i <= 4; %i++)
		{
			%Monster_ID = $XinShouRenWu_Monster_ID[1,%i];	//获取编号
			%Monster_XYZ = $XinShouRenWu_Monster_XYZ[1,%i];	//获取坐标
			%Monster_Ret = $XinShouRenWu_Monster_Ret[1,%i];	//获取朝向

			$XinShouRenWu_NPC =SpNewNpc2(0,%Monster_ID,%Monster_XYZ,0,%Monster_Ret);//创建NPC
			ChangeLogicFloor($XinShouRenWu_NPC,0,1);

		}
		//$XinShouRenWu_Npc_shuaxinjilu = 1;//刷新记录
	}
}
/*
$XinShouRenWu_Obj_ID[1,1]  = "553000037";	$XinShouRenWu_Obj_XYZ[1,1] = "-139.75 -121.252 106.699";
$XinShouRenWu_Obj_ID[1,2]  = "553000037";	$XinShouRenWu_Obj_XYZ[1,2] = "-143.245 -124.527 106.622";
$XinShouRenWu_Obj_ID[1,3]  = "553000037";	$XinShouRenWu_Obj_XYZ[1,3] = "-140.709 -129.22 106.736";
$XinShouRenWu_Obj_ID[1,4]  = "553000038";	$XinShouRenWu_Obj_XYZ[1,4] = "-143.314 11.727 117";//
$XinShouRenWu_Obj_ID[1,5]  = "553000038";	$XinShouRenWu_Obj_XYZ[1,5] = "-144.822 12.553 117";//
$XinShouRenWu_Obj_ID[1,6]  = "553000038";	$XinShouRenWu_Obj_XYZ[1,6] = "-151.302 13.282 117";//
$XinShouRenWu_Obj_ID[1,7]  = "553000039";	$XinShouRenWu_Obj_XYZ[1,7] = "-108.237 88.7385 125";
$XinShouRenWu_Obj_ID[1,8]  = "553000039";	$XinShouRenWu_Obj_XYZ[1,8] = "-104.215 93.8193 125";
$XinShouRenWu_Obj_ID[1,9]  = "553000039";	$XinShouRenWu_Obj_XYZ[1,9] = "-101.957 101.66 125";
function XinShouRenWu_spnewcj()//新手任务采集物刷新
{

	return;
	if ($XinShouRenWu_CJ < 1 && getzoneid() >= 1010 && getzoneid() <= 1012)
	{
		for (%i = 1; %i <= 9; %i++)
		{
			%Obj_ID = $XinShouRenWu_Obj_ID[1,%i];	//获取编号
			%Obj_XYZ = $XinShouRenWu_Obj_XYZ[1,%i];	//获取坐标
			//Player 采集物ID 坐标  朝向 大小
			$XinShouRenWu_CJ =SpNewCj(0,%Obj_ID,%Obj_XYZ,0,"1 1 1");//创建采集
			//$XinShouRenWu_CJ.AddPacket( 900158 );//添加特效
		}
	}
}*/


function JianSingZhiYin_10781(%Player,%mid)//鉴定指引
{
	//( "%mid =====================" @ %mid );
	%Player.SetMissionFlag(%Mid,1350,1);
	SendOneScreenMessage(1,"鉴定完成  1/1",%Player);
	%Player.UpdateMission(%Mid);
}
function QiangHuaZhiYin_10761(%Player,%mid)//强化指引
{
	//echo( "%mid =====================" @ %mid );
	%Player.SetMissionFlag(%Mid,1350,1);
	SendOneScreenMessage(1,"强化完成  1/1",%Player);
	%Player.UpdateMission(%Mid);
}

function BingHuoShiLian_10801(%Player,%mid)//冰火试炼
{
	if (%Player.IsAcceptedMission(10801))
	{
		%FlagA = %Player.GetMissIonFlag(%Mid,1250);
		%FlagB = %Player.GetMissIonFlag(%Mid,1350);
		if (%FlagB < %FlagA)
			%FlagB++;
		%Player.SetMissionFlag(%Mid,1350,%FlagB);

		SendOneScreenMessage(1,"冰火试炼  " @ %FlagB @ "/" @ %FlagA,%Player);
		%Player.UpdateMission(%Mid);
	}
}
function ShiMenPaoHuan_20207(%Player,%mid)//师门跑环
{
	//echo( "%mid =====================" @ %mid );
	%FlagA = %Player.GetMissIonFlag(%Mid,1250);
	%FlagB = %Player.GetMissIonFlag(%Mid,1350);
	if (%FlagB < %FlagA)
		%FlagB++;
	%Player.SetMissionFlag(%Mid,1350,%FlagB);

	SendOneScreenMessage(1,"师门尽忠  " @ %FlagB @ "/" @ %FlagA,%Player);
	%Player.UpdateMission(%Mid);
}
function TanKuangQueRen_10931(%Player)//狐王洞
{
	if (%Player.IsAcceptedMission(10931))
	{
		%Player.SetMissionFlag(10931,1350,1);
		SendOneScreenMessage(1,"探查狐王洞  1/1",%Player);
		%Player.UpdateMission(10931);
	}
}
function TanKuangQueRen_10951(%Player,%Mid)//陨仙窟
{
	if (%Player.IsAcceptedMission(10951))
	{
		%Player.SetMissionFlag(%Mid,1350,1);
		SendOneScreenMessage(1,"进入陨仙窟  1/1",%Player);
		%Player.UpdateMission(%Mid);
	}
}
function TanKuangQueRen_11021(%Player)//陨仙窟二层
{
	if (%Player.IsAcceptedMission(11021))
	{
		%Player.SetMissionFlag(11021,1350,1);
		SendOneScreenMessage(1,"陨仙窟二层  1/1",%Player);
		%Player.UpdateMission(11021);
	}
}
function ShiMenPaoHuan_11041(%Player,%mid)//苍山雪海
{
	%Player.SetMission(%mid,1);
	%Player.AddExp(26357);
	AddMissionAccepted(%Player,0,11051);
}
function ZhuXianRenWu_ChuanSong( %Player, %Mid )//主线任务传送确认框
{
	if ( %Player.IsAcceptedMission( %Mid ) )
	{
		switch ( %mid )
		{
			case 10871:GoToNextMap(%Player,"811010106","");//传送区域
			case 11031:GoToNextMap(%Player,"810010100","");//传送区域
			case 10841:GoToNextMap( %Player, 1010, "" );//传送地图
		}
	}
}
function TanKuangQueRen_11232( %Player ) //检查魔剑
{
	if ( %Player.IsAcceptedMission( 11232 ) )
	{
		%Player.SetMissionFlag( 11232, 1350, 1 );
		SendOneScreenMessage( 1, "封剑台  1/1", %Player );
		%Player.UpdateMission( 11232 );
	}
}

//■■■■■■■■■■■■■■■■【主线剧情】■■■■■■■■■■■■■■■■

//■■■■■■■■■■■■■■■■【支线任务】■■■■■■■■■■■■■■■■
function WangXianGu_YunYouYinShi_ShuaXin(%YY,%MM,%DD,%H,%M,%S)//云游隐士随机位置刷新
{
	if (getzoneid() != 1101)
		return;

	if (%M == 10 || %M == 30 || %M == 50)
	{
		%Ran = getRandom(1,10);
		switch (%Ran)
		{
			case 1: %XYZ = "142.669 17.4483 73.2201";	%Ret = 300;
			case 2: %XYZ = "134.409 -61.2822 72.5938";	%Ret = 315;
			case 3: %XYZ = "144.838 -140.402 95.1603";	%Ret = 350;
			case 4: %XYZ = "51.2035 -125.976 92.2325";	%Ret = 45;
			case 5: %XYZ = "-54.3288 -126.769 87.3125"; %Ret = 315;
			case 6: %XYZ = "-15.1805 -58.2074 72.7971"; %Ret = 30;
			case 7: %XYZ = "-109.178 -40.0561 82.7171"; %Ret = 345;
			case 8: %XYZ = "10.4918 41.3 72.4716";		%Ret = 330;
			case 9: %XYZ = "116.825 121.002 87.5822";	%Ret = 235;
			case 10: %XYZ = "-69.3262 147.339 87.271";	%Ret = 180;
		}
		SpNewNpc2(0,411010020,%XYZ,0,%Ret);//每20分钟刷一次NPC
	}

}

function WangXianGu_YunYouYinShi_ChuFa(%Npc,%Player,%State,%Conv,%Mid)
{
	if (%Player.IsAcceptedMission(20205))
	{
		%Type = %Player.GetMissionFlag(20205,1350);
		%Num = %Player.GetMissionFlag(20205,1250);
		if (%Type < %Num)
		{
			switch (%state)
			{
				case 0:
					%Conv.SetText(511 @ %Mid);
					%Conv.AddOption(411 @ %Mid,411 @ %Mid);
				case 411 @ %Mid:
					%Conv.SetText(512 @ %Mid);
					%Player.SetMission( 20205, 1 );//完成
					AddMissionAccepted( %Player, 0, 20206 );//接下一个任务
					%Pos = %Player.GetPosition();//玩家坐标
					%Monster = SpNewNpc(%Player,411011015,%Pos,0);//刷新灵宠
					%Monster.SetExclusivePlayerId(%Player.GetPlayerID()); //设置怪物独占玩家
			}
		}
	}
}


//■■■■■■■■■■■■■■■■【支线任务】■■■■■■■■■■■■■■■■

//■■■■■■■■■■■■■■■■【生活剧情】■■■■■■■■■■■■■■■■

function ShengHuoJiNeng_30101(%Player){ ShengHuoJiNeng_30101_30701(%Player,0); }
function ShengHuoJiNeng_30111(%Player){ ShengHuoJiNeng_30101_30701(%Player,1); }
function ShengHuoJiNeng_30121(%Player){ ShengHuoJiNeng_30101_30701(%Player,2); }
function ShengHuoJiNeng_30131(%Player){ ShengHuoJiNeng_30101_30701(%Player,3); }
function ShengHuoJiNeng_30201(%Player){ ShengHuoJiNeng_30101_30701(%Player,4); }
function ShengHuoJiNeng_30301(%Player){ ShengHuoJiNeng_30101_30701(%Player,5); }
function ShengHuoJiNeng_30401(%Player){ ShengHuoJiNeng_30101_30701(%Player,6); }
function ShengHuoJiNeng_30501(%Player){ ShengHuoJiNeng_30101_30701(%Player,7); }
function ShengHuoJiNeng_30601(%Player){ ShengHuoJiNeng_30101_30701(%Player,8); }
function ShengHuoJiNeng_30701(%Player){ ShengHuoJiNeng_30101_30701(%Player,9); }

function ShengHuoJiNeng_30101_30701(%Player,%Num)//生活技能	弹框确认触发
{
	switch (%Num)
	{
		case 0:
			SetSrc(%Player,189);//技能一学习记录
			AddMissionAccepted(%Player,0,30101);//接挖矿任务
		case 1:
			SetSrc(%Player,189);
			AddMissionAccepted(%Player,0,30111);//接伐木任务
		case 2:
			SetSrc(%Player,189);
			AddMissionAccepted(%Player,0,30121);//接采药任务
		case 3:
			SetSrc(%Player,189);
			AddMissionAccepted(%Player,0,30131);//接钓鱼任务
		case 4:
			SetSrc(%Player,190);//技能二学习记录
			AddMissionAccepted(%Player,0,30201);//接铸造任务
		case 5:
			SetSrc(%Player,190);
			AddMissionAccepted(%Player,0,30301);//接缝纫任务
		case 6:
			SetSrc(%Player,190);
			AddMissionAccepted(%Player,0,30401);//接制器任务
		case 7:
			SetSrc(%Player,190);
			AddMissionAccepted(%Player,0,30501);//接炼丹任务
		case 8:
			SetSrc(%Player,190);
			AddMissionAccepted(%Player,0,30601);//接符咒任务
		case 9:
			SetSrc(%Player,190);
			AddMissionAccepted(%Player,0,30701);//接烹饪任务
	}
}
//------------------生活技能心得--------------
function Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,%Mid)
{
	if (%Player.IsAcceptedMission(%Mid))//获取任务
	{
		switch (%Mid)
		{
			case 30103:%ItemID = 108021006;
			case 30113:%ItemID = 108021007;
			case 30123:%ItemID = 108021008;
			case 30133:%ItemID = 108021009;
			case 30205:%ItemID = 108021010;
			case 30305:%ItemID = 108021011;
			case 30405:%ItemID = 108021012;
			case 30505:%ItemID = 108021013;
			case 30605:%ItemID = 108021014;
			case 30705:%ItemID = 108021015;
		}
		switch (%State)
		{
			case 0:
				%Conv.SetText(511 @ %Mid);
				%Conv.AddOption(411 @ %Mid,411 @ %Mid);
			case 411 @ %Mid:
				%Conv.SetText(512 @ %Mid);
				AddItem_BaoGuoNo_Mail(%Player, %ItemID, 1, 1, "1 " @ %Mid);//给任务道具
		}
	}
}
//---------穿戴生活道具完成旗标---------
function Mission_ChuanDaiShengHuoDaoJu(%Player,%Mid)
{
	if (%Player.IsAcceptedMission(%Mid))
	{
		%Player.SetMissionFlag(%Mid,1350,1);
		SendOneScreenMessage(1,"戴上生活道具  1/1",%Player);
		%Player.UpdateMission(%Mid);
	}
}

//■■■■■■■■■■■■■■■■【生活剧情】■■■■■■■■■■■■■■■■
