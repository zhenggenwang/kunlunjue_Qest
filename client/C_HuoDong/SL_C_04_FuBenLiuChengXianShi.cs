//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//各个副本内战斗阶段流程显示界面
//==================================================================================

//■■■■■时空裂痕■■■■■■■■■■■
//■■■■■炼魔渊■■■■■■■■■■■■
//■■■■■血魔封印阵■■■■■■■■■■
//■■■■■幻境争霸■■■■■■■■■■■
//■■■■■鸿蒙试炼■■■■■■■■■
//■■■■■刀剑神域■■■■■■■■■■■


//■■■■■时空裂痕■■■■■■■■■■■

function ShiKongLieHenFuBenTongJiWnd(%Player,%Text)
{
	//echo( "%Player===" @ %Player @ "    %Text===" @ %Text );
	CanCel($ShiKongLieHenFuBenTongJiWnd);
	//if ( %Player.Gettriggerid( ) !$= "813010100" )
	//	return;
	%GuaKa = GetWord(%Text,0);//当前进攻波数
	%NextTime =  GetWord(%Text,1);//下一波怪物倒计时
	//echo( " GuaKa====" @ %GuaKa );
	//echo( " NextTime====" @ %NextTime );
	//echo( " Text====" @ %Text );

	%GuaKaText = "当前进攻波数：第 " @ %GuaKa @ " 波";
	%NextTimeTxt = %NextTime @ " 秒";

	if (%GuaKa == 0)
		%GuaKaText = "未开始";
	if (%GuaKa == -1)
		%GuaKaText = "已结束";

	if (%GuaKa <= 0 || %GuaKa >= 40)
		%NextTimeTxt = "无";

	switch (%GuaKa + 1)
	{
		case 10:%TeShuText = "下一波将有首领怪物进攻";
		case 20:%TeShuText = "下一波将有大量怪物进行偷袭";
		case 25:%TeShuText = "下一波将有首领怪物进攻";
		case 34:%TeShuText = "下一波将有大量怪物进行偷袭";
		case 40:%TeShuText = "下一波将有终极首领怪物进攻";
	}
	FBMessageAppear();	//打开副本信息界面
	%Title = $Get_Dialog_GeShi[11400];	//标题
	%XiaoBiaoTi = $Get_Dialog_GeShi[31201];	//Xiao标题
	FBProgressMessage.clearitem();
	%Node[1] = AddFBProgressNode(0,%Title @ "『副本概况』</t>",1,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "·" @ %GuaKaText @ "</t>",1*100 + 0,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "·下波怪物倒计时：" @ %NextTimeTxt @ "</t>",1*100 + 1,0);
	if (%TeShuText !$= "")
		AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "·" @ %TeShuText @ "</t>",1*100 + 2,0);

	FBProgressMessage.buildVisibleTree(0);

	%NextTime--;
	if (%NextTime >= 0)
		$ShiKongLieHenFuBenTongJiWnd = schedule(1000,0,"ShiKongLieHenFuBenTongJiWnd",%Player,%GuaKa @ " " @  %NextTime);
}
//■■■■■时空裂痕■■■■■■■■■■■


//■■■■■炼魔渊■■■■■■■■■■■■
function LianMoYuanFuBenTongJiWnd(%Player,%Text)
{
	//echo( "%Text===" @ %Text );
	CanCel($LianMoYuanFuBenTongJiWnd);
	if (%Player.Gettriggerid() !$= "813010200")
		return;
	%GuaKia = GetWord(%Text,0);
	if (%GuaKia > 25)
		%GuaKia = "已通关";

	%Time = GetWord(%Text,1);
	//echo( "%Time===" @ %Time );
	if (%Time == 99999)
	{
		%TimeTxt = "未开启挑战";
	}
	else
	{
		if (%Time == 1)
			%TimeTxt = "挑战结束";
		else
		{
			%M = mfloor(%Time/60);
			%S = %Time%60;
			if (%M <= 9)
				%M = "0" @ %M;
			if (%S <= 9)
				%S = "0" @ %S;
			%TimeTxt = %M @ ":" @ %S;
		}
	}

	FBMessageAppear();	//打开副本信息界面
	%Title = $Get_Dialog_GeShi[11400];	//标题
	%XiaoBiaoTi = $Get_Dialog_GeShi[31201];	//Xiao标题
	FBProgressMessage.clearitem();
	%Node[1] = AddFBProgressNode(0,%Title @ "『副本概况』</t>",1,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "·完成关卡：" @ %GuaKia @ "</t>",1*100 + 0,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "·剩余时间：" @ %TimeTxt @ "</t>",1*100 + 1,0);

	FBProgressMessage.buildVisibleTree(0);

	%Time--;
	if (%Time > 0 && %Time < 90000)
		$LianMoYuanFuBenTongJiWnd = schedule(1000,0,"LianMoYuanFuBenTongJiWnd",%Player,%GuaKia @ " " @  %Time);
}
//■■■■■炼魔渊■■■■■■■■■■■■

//■■■■■血魔封印阵■■■■■■■■■■
//XueMoFengYinZhenFuBenTongJiWnd( GetPlayer(), "0 0 0" ); XueMoFengYinZhenFuBenTongJiWnd( GetPlayer(), "2 1500 17 410010203.0.410010204.1.410010205.2" );

function XueMoFengYinZhenFuBenTongJiWnd(%Player,%Text)
{
	CanCel($XueMoFengYinZhenFuBenTongJiWnd);
	%MapID = GetZoneID();
	if (%MapID != 130701)
	{

		return;
	}
	//echo( "%Text==============================" @ %Text );
	%LostTime = GetWord(%Text,0);
	%BoShu = GetWord(%Text,1);
	%MonsterNumber = GetWord(%Text,2);
	%BossMsg = GetWord(%Text,3);

	if (%BoShu == 0)
		%GuaKia = "战斗未开启";
	else
		%GuaKia = "当前第：" @ %BoShu @ " 波";

	%M = mfloor(%LostTime/60);
	%S = %LostTime%60;
	if (%M <= 9)
		%M = "0" @ %M;
	if (%S <= 9)
		%S = "0" @ %S;
	%TimeTxt = %M @ "：" @ %S;

	FBMessageAppear();	//打开副本信息界面
	%Title = $Get_Dialog_GeShi[11400];	//标题
	%XiaoBiaoTi = $Get_Dialog_GeShi[31201];	//Xiao标题
	FBProgressMessage.clearitem();
	%Node[1] = AddFBProgressNode(0,%Title @ "『副本概况』</t>",1,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "·副本剩余时间：" @ %TimeTxt @ "</t>",1*100 + 0,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "·" @ %GuaKia @ "</t>",1*100 + 1,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "·存活怪物数量：" @ %MonsterNumber @ "</t>",1*100 + 2,0);

	//echo( "%BossMsg==" @ %BossMsg );
	if (%BossMsg !$= "")
	{
		%Count = GetWordCount(%BossMsg,".");
		if (%Count > 1)
		{
			%j = 3;
			for (%i = 0; %i < %Count; %i++)
			{
				%BossID = GetWord(%BossMsg,%i,".");
				%i++;
				%BossState = GetWord(%BossMsg,%i,".");
				//echo( "%BossState==" @ %BossState );
				switch (%BossState)
				{
					case 0: %StateText = "未参战";
					case 1: %StateText = "战斗中";
					case 2: %StateText = "已击败";
				}
				%StateText = GetNpcData(%BossID,1) @ "：" @  %StateText;
				AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "·" @ %StateText @ "</t>",1*100 + %j,0);
				%j++;
			}
		}
	}
	FBProgressMessage.buildVisibleTree(0);
	%LostTime--;
	%Text = %LostTime @ " " @ %BoShu @ " " @ %MonsterNumber @ " " @ %BossMsg;
	if (%LostTime >= 0)
		$XueMoFengYinZhenFuBenTongJiWnd = schedule(1000,0,"XueMoFengYinZhenFuBenTongJiWnd",%Player,%Text);
}
//■■■■■血魔封印阵■■■■■■■■■■

//■■■■■幻境争霸■■■■■■■■■■■
//HuanJingZhengBaFuBenTongJiWnd( GetPlayer(), "150 10 12 15 36 41 55 3" );
function HuanJingZhengBaFuBenTongJiWnd(%Player,%Text)
{
	//echo( "%Text===" @ %Text );
	CanCel($HuanJingZhengBaFuBenTongJiWnd);
	%MapID = GetZoneID();
	if (%MapID != 130201)
	{

		return;
	}
	%Time = GetWord(%Text,0);
	%PeopleNumber[100] = GetWord(%Text,1);
	%PeopleNumber[200] = GetWord(%Text,2);
	%PeopleNumber[300] = GetWord(%Text,3);
	%PeopleNumber[400] = GetWord(%Text,4);
	%PeopleNumber[500] = GetWord(%Text,5);
	%KillNumber = GetWord(%Text,6);
	%NowState = GetWord(%Text,7);
	//echo( "%NowState===" @ %NowState );
	if (%Time >= 1800)
		%TimeTxt = "战斗结束";
	else
	{
		if (%Time < 120)
			%TimeTxt = "战斗未开始";
		else
		{
			%M = mfloor((1800-%Time)/60);
			%S = (1800-%Time)%60;
			if (%M <= 9)
				%M = "0" @ %M;
			if (%S <= 9)
				%S = "0" @ %S;
			%TimeTxt = %M @ "：" @ %S;
		}
	}
	%TriggerID = %Player.GetTriggerID();
	switch (%TriggerID)
	{
		case 813020100:
			%JinSheng = "准备区等待中";
		case 813020500:
			if (%NowState >= 0)
				%JinSheng = "已晋升至最高层";
			else
				%JinSheng = "死亡 " @ 5 + %NowState @ " 次后降级";
		case 813020200:
			if (%NowState >= 0)
				%JinSheng = "击败 " @ 5 - %NowState @ " 人后晋级";
			else
				%JinSheng = "击败 5 人后晋级";
		default:
			if (%NowState >= 0)
				%JinSheng = "击败 " @ 5 - %NowState @ " 人后晋级";
			else
				%JinSheng = "死亡 " @ 5 + %NowState @ " 次后降级";
	}
	FBMessageAppear();	//打开副本信息界面
	%Title = $Get_Dialog_GeShi[11400];	//标题
	%XiaoBiaoTi = $Get_Dialog_GeShi[31201];	//Xiao标题
	FBProgressMessage.clearitem();
	%Node[1] = AddFBProgressNode(0,%Title @ "『本人数据』</t>",1,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "·总杀敌数：" @ %KillNumber @ " 人</t>",1*100 + 0,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "·当前状态：" @ %JinSheng @ "</t>",1*100 + 1,0);

	%Node[2] = AddFBProgressNode(0,%Title @ "『战场数据』：</t>",2,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "·剩余时间：" @ %TimeTxt @ "</t>",2*100 + 0,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "·幻境一层：" @ %PeopleNumber[200] @ " 人</t>",2*100 + 1,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "·幻境二层：" @ %PeopleNumber[300] @ " 人</t>",2*100 + 2,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "·幻境三层：" @ %PeopleNumber[400] @ " 人</t>",2*100 + 3,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "·幻境四层：" @ %PeopleNumber[500] @ " 人</t>",2*100 + 4,0);
	FBProgressMessage.buildVisibleTree(0);


	%Time++;
	%Text = %Time @ " " @ %PeopleNumber[100] @ " " @ %PeopleNumber[200] @ " " @ %PeopleNumber[300] @ " " @ %PeopleNumber[400] @ " " @ %PeopleNumber[500] @ " " @ %KillNumber @ " " @ %NowState;

	if (%Time <= 1800)
		$HuanJingZhengBaFuBenTongJiWnd = schedule(1000,0,"HuanJingZhengBaFuBenTongJiWnd",%Player,%Text);
}
//■■■■■幻境争霸■■■■■■■■■■■

//■■■■■鸿蒙试炼■■■■■■■■■
//YunXianJieDaTaoShaFuBenTongJiWnd(getplayer(),"-1 -1 -1 -1 3 12 12");
function YunXianJieDaTaoShaFuBenTongJiWnd(%Player,%Text)
{
	//echo( "%Text===" @ %Text );
	CanCel($YunXianJieDaTaoShaFuBenTongJiWnd);
	%MapID = GetZoneID();
	if (%MapID != 130401)
	{
		BigViewMap_triggeridbmp_1.setvisible(0);
		BigViewMap_triggeridbmp_2.setvisible(0);
		BigViewMap_triggeridbmp_3.setvisible(0);
		BigViewMap_triggeridbmp_4.setvisible(0);
		BigViewMap_triggeridbmp_5.setvisible(0);

		return;
	}
	//echo( "%Text==" @ %Text );
	//0 至 4位-----区域记录  >0 代表人数 -1 表示区域已经损坏 
	//5位 战斗时长计时
	//6位 杀敌数量
	%State1 =  GetWord(%Text,0);
	%State2 =  GetWord(%Text,1);
	%State3 =  GetWord(%Text,2);
	%State4 =  GetWord(%Text,3);
	%State5 =  GetWord(%Text,4);
	%Time = GetWord(%Text,5);
	%KillNumBer = GetWord(%Text,6);

	if (%State1 >= 0) %Title1 = "存活 " @ %State1 @ " 人"; else { %Title1 = "已损毁"; BigViewMap_triggeridbmp_1.setvisible(1); }
	if (%State2 >= 0) %Title2 = "存活 " @ %State2 @ " 人"; else { %Title2 = "已损毁"; BigViewMap_triggeridbmp_2.setvisible(1); }
	if (%State3 >= 0) %Title3 = "存活 " @ %State3 @ " 人"; else { %Title3 = "已损毁"; BigViewMap_triggeridbmp_3.setvisible(1); }
	if (%State4 >= 0) %Title4 = "存活 " @ %State4 @ " 人"; else { %Title4 = "已损毁"; BigViewMap_triggeridbmp_4.setvisible(1); }
	if (%State5 >= 0) %Title5 = "存活 " @ %State5 @ " 人"; else { %Title5 = "已损毁"; BigViewMap_triggeridbmp_5.setvisible(1); }
	if (%Time >= 3600)
	{
		%TimeTxt = "战斗未开始";
		BigViewMap_triggeridbmp_1.setvisible(0);
		BigViewMap_triggeridbmp_2.setvisible(0);
		BigViewMap_triggeridbmp_3.setvisible(0);
		BigViewMap_triggeridbmp_4.setvisible(0);
		BigViewMap_triggeridbmp_5.setvisible(0);
	}
	else
	{
		if (%Time <= 1)
		{
			BigViewMap_triggeridbmp_1.setvisible(0);
			BigViewMap_triggeridbmp_2.setvisible(0);
			BigViewMap_triggeridbmp_3.setvisible(0);
			BigViewMap_triggeridbmp_4.setvisible(0);
			BigViewMap_triggeridbmp_5.setvisible(0);
			%TimeTxt = "战斗已结束";
		}
		else
		{
			%M = mfloor(%Time/60);
			%S = %Time%60;
			if (%M <= 9)
				%M = "0" @ %M;
			if (%S <= 9)
				%S = "0" @ %S;
			%TimeTxt = %M @ "：" @ %S;
		}
	}
	%KillTxt = "当前杀敌：" @ %KillNumBer @ "人";

	FBMessageAppear();	//打开副本信息界面
	%Title = $Get_Dialog_GeShi[11400];	//标题
	%XiaoBiaoTi = $Get_Dialog_GeShi[31201];	//Xiao标题
	FBProgressMessage.clearitem();

	%Node[1] = AddFBProgressNode(0,%Title @ "『个人概况』</t>",1,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "·副本时间：" @ %TimeTxt @ "</t>",1*100 + 0,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "·" @ %KillTxt @ "</t>",1*100 + 1,0);

	%Node[2] = AddFBProgressNode(0,%Title @ "『战场数据』：</t>",2,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "·四象祭台：" @ %Title1 @ "</t>",2*100 + 0,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "·青龙区域：" @ %Title2 @ "</t>",2*100 + 1,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "·白虎区域：" @ %Title3 @ "</t>",2*100 + 2,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "·朱雀区域：" @ %Title4 @ "</t>",2*100 + 3,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "·玄武区域：" @ %Title5 @ "</t>",2*100 + 4,0);
	FBProgressMessage.buildVisibleTree(0);


	%Time--;
	%Text = %State1 @ " " @ %State2 @ " " @ %State3 @ " " @ %State4 @ " " @ %State5 @ " " @ %Time @ " " @ %KillNumBer;
	if (%Time > 0)
		$YunXianJieDaTaoShaFuBenTongJiWnd = schedule(1000,0,"YunXianJieDaTaoShaFuBenTongJiWnd",%Player,%Text);
}


//■■■■■鸿蒙试炼■■■■■■■■■

//■■■■■刀剑神域■■■■■■■■■■■
//副本剩余时间 阵营1数据 阵营2数据 个人排名 个人击败数据 完成任务次数  DaoJianShenYuFuBenTongJiWnd( getplayer(),"1900 15 35 2 9 3" );
function DaoJianShenYuFuBenTongJiWnd(%Player,%Text)
{
	CanCel($DaoJianShenYuFuBenTongJiWnd);
	%MapID = GetZoneID();

	if (%MapID != 130501)
	{

		return;
	}
	%Force = %Player.GetForce();
	switch (%Force)
	{
		case 1:%ForceName = "天刀";
		case 2:%ForceName = "神剑";
		case 0:%ForceName = "暂无";
	}
	$CopyMap1305State0 =  GetWord(%Text,0) * 1;//副本剩余时间
	$CopyMap1305State1 =  GetWord(%Text,1) * 1;//阵营1数据
	$CopyMap1305State2 =  GetWord(%Text,2) * 1;//阵营2数据
	$CopyMap1305State3 =  GetWord(%Text,3) * 1;//个人排名
	$CopyMap1305State4 =  GetWord(%Text,4) * 1;//个人击败数据
	$CopyMap1305State5 =  GetWord(%Text,5) * 1;//完成任务次数

	if ($CopyMap1305State0 <= 0)
		%Text0 = "战斗已结束";
	else
	{
		%M = mfloor($CopyMap1305State0/60);
		%S = $CopyMap1305State0%60;
		if (%M <= 9)
			%M = "0" @ %M;
		if (%S <= 9)
			%S = "0" @ %S;
		%Text0 = %M @ "：" @ %S;
	}

	FBMessageAppear();	//打开副本信息界面
	%Title = $Get_Dialog_GeShi[11400];	//标题
	%XiaoBiaoTi = $Get_Dialog_GeShi[31201];	//Xiao标题
	FBProgressMessage.clearitem();

	%Node[1] = AddFBProgressNode(0,%Title @ "『战场概况』</t>",1,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "·剩余时间：" @ %Text0 @ "</t>",1*100 + 0,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "·天刀阵营：" @ $CopyMap1305State1 @ " 分</t>",1*100 + 1,0);
	AddFBProgressNode(%Node[1],%XiaoBiaoTi @ "·神剑阵营：" @ $CopyMap1305State2 @ " 分</t>",1*100 + 2,0);

	%Node[2] = AddFBProgressNode(0,%Title @ "『个人数据』</t>",2,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "·所属阵营：" @ %ForceName @ "</t>",2*100 + 0,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "·战场排名：" @ $CopyMap1305State3 @ "</t>",2*100 + 1,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "·击败敌军：" @ $CopyMap1305State4 @ "</t>",2*100 + 2,0);
	AddFBProgressNode(%Node[2],%XiaoBiaoTi @ "·采集物资：" @ $CopyMap1305State5 * 1 @ "/5" @ "</t>",2*100 + 3,0);
	FBProgressMessage.buildVisibleTree(0);

	$CopyMap1305State0--;
	%Text = $CopyMap1305State0 @ " " @ $CopyMap1305State1 @ " " @ $CopyMap1305State2 @ " " @ $CopyMap1305State3 @ " " @ $CopyMap1305State4 @ " " @ $CopyMap1305State5;
	if ($CopyMap1305State0 > 0)
		$DaoJianShenYuFuBenTongJiWnd = schedule(1000,0,"DaoJianShenYuFuBenTongJiWnd",%Player,%Text);
}
//■■■■■刀剑神域■■■■■■■■■■■
