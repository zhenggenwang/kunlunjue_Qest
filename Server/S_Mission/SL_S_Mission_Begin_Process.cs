//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//领取任务过程处理
//==================================================================================
//■■■■■■■■■■■■■■■■■■【新手指引】■■■■■■■■■■■■■■


//case 2: %MidName = "Mission_Begin_Process_"@ %Mid;	//领取任务过程处理
/*例如:
function Mission_Begin_Process_24108(%Npc, %Player, %Conv, %Param, %Mid)
{
//玩家基础信息
if(%Player.IsSchBuff(40001040))
{
SendOneScreenMessage(2,"你刚刚放弃任务，需要过一段时间才能重新接取", %Player);
return;
}
if (GetWord(%Player.GetActivity(3103), 0)>199)
{
SendOneScreenMessage(2,"你已完成本周跑环系列任务", %Player);
return ;
}
%Activity = GetWord(%Player.GetActivity(3103), 0) ;	//总次数
if (%Activity <20) %ran=getrandom(1,12);
else if (%Activity <50) %ran=getrandom(13,29);
else if (%Activity <90) %ran=getrandom(30,48);
else if (%Activity <140 )%ran=getrandom(49,65);
else %ran=getrandom(66,95);
////echo("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" @ %ran);
//确定任务内容
if (%ran <= 65)
Mission_Runloop_Affair(%Npc, %Player, %Conv, %Param, %Mid,%ran);
else Mission_Runloop_Affair_new(%Npc, %Player, %Conv, %Param, %Mid,%ran);
//设置额外旗标，显示采集次数
%Player.SetMissionFlag(%Mid, 9100, 1);
//更新任务
%Player.UpdateMission(%Mid);
}*/

//■■■■■■■■■■■■■■■■■■【新手指引】■■■■■■■■■■■■■■

function Mission_Begin_Process_10051(%Npc,%Player,%Conv,%Param,%Mid)//寻仙访道
{
	%Conv.Settype(4);
	%Classes = %Player.GetClasses(0);
	switch (%Classes)
	{
		case 1:%Skill[1] = 210010001; %Skill[2] = 210020001; //战士
		case 2:%Skill[1] = 220010001; %Skill[2] = 220020001; //刺客
		case 3:%Skill[1] = 230010001; %Skill[2] = 230020001; //法师
		case 4:%Skill[1] = 240010001; %Skill[2] = 240020001; //道士
		case 5:%Skill[1] = 250010001; %Skill[2] = 250020001; //猎人
	}
	//添加职业技能
	%Player.AddSkill(%Skill[1]);	//职业技能1
	%Player.AddSkill(%Skill[2]);	//职业技能2
	%Player.AddObjectToPanel(2,%Skill[1],1);
	%Player.AddObjectToPanel(2,%Skill[2],2);
}
function Mission_Begin_Process_10071( %Npc, %Player, %Conv, %Param, %Mid )//物归原主
{
	%Conv.Settype( 4 );
	%Item = %Player.GetItemCount( 108020162 );//获取包裹道具数量
	if ( %Item != 1 )//如果没有
	{
		AddItem_BaoGuoNo_Mail(%Player, 108020162, 1, 1, "1 " @ %Mid);//给一个遗失之物
	}
}
function Mission_Begin_Process_10121(%Npc,%Player,%Conv,%Param,%Mid)//秘录悟道
{
	%Conv.Settype(4);
	%Classes = %Player.GetClasses(0);
	switch (%Classes)
	{
		case 1:%ItemID = 105220003;//战士
		case 2:%ItemID = 105230003;//刺客
		case 3:%ItemID = 105240003;//法师
		case 4:%ItemID = 105250003;//道士
		case 5:%ItemID = 105260003;//猎人
	}
	AddItem_BaoGuoNo_Mail(%Player, %ItemID, 1, 1, "1 " @ %Mid);//给技能书
}
function Mission_Begin_Process_10151(%Npc,%Player,%Conv,%Param,%Mid)//裁剪衣服
{
	$Mission_Item_10151[1,1] = "102022000;102022050;";
	$Mission_Item_10151[1,3] = "102022200;102022250;";
	$Mission_Item_10151[1,4] = "102022300;102022350;";
	%Conv.Settype(4);
	%Classes = %Player.GetClasses(0);//获取职业
	%Sex = %Player.GetSex();//获取性别
	if (%Sex == 1)//男性
	{
		%ItemID = getword($Mission_Item_10151[1,%Classes],0,";");
		AddItem_BaoGuoNo_Mail(%Player, %ItemID, 1, 0, "1 " @ %Mid);
	}
	else
	{
		%ItemID = getword($Mission_Item_10151[1,%Classes],1,";");
		AddItem_BaoGuoNo_Mail(%Player, %ItemID, 1, 0, "1 " @ %Mid);
	}
}

function Mission_Begin_Process_10111(%Npc,%Player,%Conv,%Param,%Mid)//海上归来
{
	//echo( "%Player===" @ %Player.getobjectname( ) );
	%Conv.Settype(4);
	%Random = getrandom( 1, 3 );
	switch ( %Random )
	{
		case 1:%Num = 10100301;
		case 2:%Num = 10100302;
		case 3:%Num = 10100303;
	}
	FlyMeToTheMoon( %Player, %Num, 704001801 );
}

function Mission_Begin_Process_10101(%Npc,%Player,%Conv,%Param,%Mid)//出海寻人
{
	//echo( "%Player===" @ %Player.getobjectname( ) );
	%Conv.Settype(4);
	%Random = getrandom( 1, 3 );
	switch ( %Random )
	{
		case 1:%Num = 10100201;
		case 2:%Num = 10100202;
		case 3:%Num = 10100203;
	}
	FlyMeToTheMoon(%Player,%Num,704001801);//飞行路径
}
function Mission_Begin_Process_10201(%Npc,%Player,%Conv,%Param,%Mid)//师兄教诲
{
	%Conv.Settype(4);
	%Classes = %Player.GetClasses(0);
	switch (%Classes)
	{
		case 1:%ItemID = 103022000;//战士
		case 2:%ItemID = 103020101;//刺客
		case 3:%ItemID = 103022200;//法师
		case 4:%ItemID = 103022300;//道士
		case 5:%ItemID = 103020401;//猎人
	}
	AddItem_BaoGuoNo_Mail(%Player, %ItemID, 1, 0, "1 " @ %Mid);//根据职业给项链
}
function Mission_Begin_Process_10231(%Npc,%Player,%Conv,%Param,%Mid)//试炼之途
{
	%Conv.Settype(4);
	%Classes = %Player.GetClasses(0);
	switch (%Classes)
	{
		case 1:%ItemID = 105220004;//战士
		case 2:%ItemID = 105230004;//刺客
		case 3:%ItemID = 105240004;//法师
		case 4:%ItemID = 105250005;//道士
		case 5:%ItemID = 105260004;//猎人
	}
	AddItem_BaoGuoNo_Mail(%Player, %ItemID, 1, 1, "1 " @ %Mid);//给技能书
}

function Mission_Begin_Process_10311(%Npc,%Player,%Conv,%Param,%Mid)//回禀异事
{
	%Conv.Settype(4);
	%Random = getrandom( 1, 3 );
	switch ( %Random )
	{
		case 1:%Num = 10100401;
		case 2:%Num = 10100402;
		case 3:%Num = 10100403;
	}
	FlyMeToTheMoon(%Player,%Num,701002601);
}
function Mission_Begin_Process_10321(%Npc,%Player,%Conv,%Param,%Mid)//蓬莱往事
{
	%Conv.Settype(4);
	%Random = getrandom( 1, 3 );
	switch ( %Random )
	{
		case 1:%Num = 10100501;
		case 2:%Num = 10100502;
		case 3:%Num = 10100503;
	}
	FlyMeToTheMoon(%Player,%Num,701002601);
}

function Mission_Begin_Process_10301(%Npc,%Player,%Conv,%Param,%Mid)//树妖之灵
{
	%Conv.Settype(4);
	%Monster = SpNewNpc(%Player,410101016,"138.038 -55.6684 144.906",0);
	%Monster.SetExclusivePlayerId(%Player.GetPlayerID()); //设置怪物独占玩家
	ChangeLogicFloor(%Monster,0,%Player);
	%Player.Monster_ShuYaoZhiLing = %Monster;
}


function Mission_Begin_Process_10481(%Npc,%Player,%Conv,%Param,%Mid)//给鱼竿
{
	%Conv.Settype(4);
	AddItem_BaoGuoNo_Mail(%Player, 107050001, 1, 0, "1 " @ %Mid);

}
function Mission_Begin_Process_10491(%Npc,%Player,%Conv,%Param,%Mid)//给一条大鱼
{
	%Conv.Settype(4);
	AddItem_BaoGuoNo_Mail(%Player, 108020026, 1, 1, "1 " @ %Mid);

}
function Mission_Begin_Process_10761(%Npc,%Player,%Conv,%Param,%Mid)//幸运石
{
	%Conv.Settype(4);
	AddItem_BaoGuoNo_Mail(%Player, 116060051, 1, 0, "1 " @ %Mid);

}

function Mission_Begin_Process_10841(%Npc,%Player,%Conv,%Param,%Mid)//师门跑环
{
	%Conv.Settype(4);
	//GoToNextMap(%Player,1010,"");//传送地图
	%Player.ShowDialogOk( 2000000038, 44, 1 );//确认框
}
function Mission_Begin_Process_10871(%Npc,%Player,%Conv,%Param,%Mid)//传送望仙镇
{
	%Conv.Settype(4);
	//GoToNextMap(%Player,"811010106","");//传送区域
	%Player.ShowDialogOk( 2000000036, 42, 1 );//确认框
}
function Mission_Begin_Process_11031(%Npc,%Player,%Conv,%Param,%Mid)//传送昆仑
{
	%Conv.Settype(4);
	//GoToNextMap(%Player,"810010100","");//传送区域
	%Player.ShowDialogOk(2000000037,43,1);//确认框
}


//■■■■■■■■■■■■■■■■■■【新手指引】■■■■■■■■■■■■■■

function Mission_Begin_Process_20029(%Npc,%Player,%Conv,%Param,%Mid) { Mission_Begin_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }	//斩妖除魔·一
function Mission_Begin_Process_20030(%Npc,%Player,%Conv,%Param,%Mid) { Mission_Begin_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }	//斩妖除魔·二
function Mission_Begin_Process_20031(%Npc,%Player,%Conv,%Param,%Mid) { Mission_Begin_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }	//斩妖除魔·三
function Mission_Begin_Process_20032(%Npc,%Player,%Conv,%Param,%Mid) { Mission_Begin_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }	//斩妖除魔·四
function Mission_Begin_Process_20033(%Npc,%Player,%Conv,%Param,%Mid) { Mission_Begin_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }	//斩妖除魔·五
function Mission_Begin_Process_20034(%Npc,%Player,%Conv,%Param,%Mid) { Mission_Begin_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }	//斩妖除魔·六
function Mission_Begin_Process_20035(%Npc,%Player,%Conv,%Param,%Mid) { Mission_Begin_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }	//斩妖除魔·七
function Mission_Begin_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid)
{
	switch (%Mid)
	{
		case 20029:%MissionTarget = 108030002;//108030002	陨仙窟怪物
		case 20030:%MissionTarget = 108030003;//108030003	玄冥冰窟怪物
		case 20031:%MissionTarget = 108030004;//108030004	深海迷宫怪物
		case 20032:%MissionTarget = 108030005;//108030005	地宫4怪物
		case 20033:%MissionTarget = 108030006;//108030006	地宫5怪物
		case 20034:%MissionTarget = 108030007;//108030007	地宫6怪物
		case 20035:%MissionTarget = 108030008;//108030008	地宫7怪物
		default:return 0;
	}
	//echo( "%Mid ===" @ %Mid @ "     ====" @ %MissionTarget );
	if (%MissionTarget > 0)
	{
		//echo("=================" @  %Player.IsAcceptedMission( %Mid ) );
		%Player.SetMissionFlag(%Mid,1100,%MissionTarget);
		%Player.SetMissionFlag(%Mid,1200,100);
		%Player.SetMissionFlag(%Mid,1300,0);
		%Player.UpdateMission(%Mid);
	}
}
//263197.SetMissionFlag( 20029, 1101, 108030002 );	263197.SetMissionFlag( 20029, 1201, 100 ); 263197.SetMissionFlag( 20029, 1301, 0 ); 263197.UpdateMission( 20029 );
function Mission_Begin_Process_20146(%Npc,%Player,%Conv,%Param,%Mid)
{
	%MissionTarget = GetRandom(108020994,108021000);
	%Player.SetMissionFlag(%Mid,2100,%MissionTarget);
	%Player.SetMissionFlag(%Mid,2200,2);
	%Player.SetMissionFlag(%Mid,2300,0);
	%Player.UpdateMission(%Mid);
}
function Mission_Begin_Process_30101(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_30101_30131(%Npc,%Player,%Conv,%Param,%Mid,107020001); }
function Mission_Begin_Process_30111(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_30101_30131(%Npc,%Player,%Conv,%Param,%Mid,107040001); }
function Mission_Begin_Process_30121(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_30101_30131(%Npc,%Player,%Conv,%Param,%Mid,107010001); }
function Mission_Begin_Process_30131(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_30101_30131(%Npc,%Player,%Conv,%Param,%Mid,107050001); }
//如果穿上了生活道具，接任务时直接完成旗标
function Mission_Begin_Process_30101_30131(%Npc,%Player,%Conv,%Param,%Mid,%Num)
{
	%ItemID = %Player.GetEquip(13);// 获取生活道具ID
	for (%i = 1; %i <= 3; %i++)
	{
		if (%ItemID == %Num)
		{
			%Player.SetMissionFlag(%Mid,1350,1);
			SendOneScreenMessage(1,"完成  1/1",%Player);
			%Player.UpdateMission(%Mid);
		}
		%Num++;
	}
}
/*
function Mission_Begin_Process_20036(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·一
function Mission_Begin_Process_20037(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·二
function Mission_Begin_Process_20038(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·三
function Mission_Begin_Process_20039(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·四
function Mission_Begin_Process_20040(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·五
function Mission_Begin_Process_20041(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·六
function Mission_Begin_Process_20042(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·七
function Mission_Begin_Process_20043(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·一
function Mission_Begin_Process_20044(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·二
function Mission_Begin_Process_20045(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·三
function Mission_Begin_Process_20046(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·四
function Mission_Begin_Process_20047(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·五
function Mission_Begin_Process_20048(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·六
function Mission_Begin_Process_20049(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·七
function Mission_Begin_Process_20050(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·一
function Mission_Begin_Process_20051(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·二
function Mission_Begin_Process_20052(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·三
function Mission_Begin_Process_20053(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·四
function Mission_Begin_Process_20054(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·五
function Mission_Begin_Process_20055(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·六
function Mission_Begin_Process_20056(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·七
function Mission_Begin_Process_20057(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·一
function Mission_Begin_Process_20058(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·二
function Mission_Begin_Process_20059(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·三
function Mission_Begin_Process_20060(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·四
function Mission_Begin_Process_20061(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·五
function Mission_Begin_Process_20062(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·六
function Mission_Begin_Process_20063(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·七
function Mission_Begin_Process_20064(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·一
function Mission_Begin_Process_20065(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·二
function Mission_Begin_Process_20066(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·三
function Mission_Begin_Process_20067(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·四
function Mission_Begin_Process_20068(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·五
function Mission_Begin_Process_20069(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·六
function Mission_Begin_Process_20070(%Npc, %Player, %Conv, %Param, %Mid){ Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid); }//英雄贴·七
function Mission_Begin_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid)//
{
	%Level = %Player.GetLevel();
	if (%Level <= 59) { %NpcID = 411291103; %Num = 40; }
	else if (%Level <= 69) { %NpcID = 411301103; %Num = 40; }
	else if (%Level <= 79) { %NpcID = 411301103; %Num = 400; }
	else if (%Level <= 89) { %NpcID = 411301103; %Num = 400; }
	else if (%Level <= 99) { %NpcID = 411301103; %Num = 400; }
	else if (%Level <= 109) { %NpcID = 411301103; %Num = 400; }
	else if (%Level <= 119) { %NpcID = 411301103; %Num = 400; }

	%Player.SetMissionFlag(%Mid, 3100, %NpcID);
	%Player.SetMissionFlag(%Mid, 3200, %Num);
	%Player.SetMissionFlag(%Mid, 3300, 0);
	%Player.UpdateMission(%Mid);
}
*/