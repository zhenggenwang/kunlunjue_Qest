//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//群英汇聚活动
//==================================================================================
function QunYingHuiJu_StytemMsg(%YY,%MM,%DD,%H,%M,%S)
{
	if (GetZoneid() != 1001)
		return;
	if ($SL_JiaZuGouHuo_bActive != 1)
		return;
	%TimebActive = GetWord($SL_JiaZuGouHuo_StartTime,0,":") * 60  + GetWord($SL_JiaZuGouHuo_StartTime,1,":");
	%TimeNow = %H * 60 + %M;
	%Time = %TimebActive - %TimeNow;
	if (%Time == 10)
	{
		%HuoDongMingCheng = GetHuoDongName("群英汇聚",1);
		%Path = "<l i='810010100 -7.75371 -21.687 191.679' t='path'/>";
		%Text = %HuoDongMingCheng @ "<t>将在</t>" @ $Get_Dialog_GeShi[31420] @ %Time @ "</t><t>分钟后开始，帮主可在</t>" @ %Path @ "<t>召唤帮派图腾召集帮众前来接受图腾祝福。</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

		%Text2 = GetHuoDongName("群英汇聚",2) @ "<t>将于</t>" @ $Get_Dialog_GeShi[60002] @ %Time @ "</t><t>分钟后开启</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
	if (%Time == 5)
	{
		%HuoDongMingCheng = GetHuoDongName("群英汇聚",1);
		%Path = "<l i='810010100 -7.75371 -21.687 191.679' t='path'/>";
		%Text = %HuoDongMingCheng @ "<t>将在</t>" @ $Get_Dialog_GeShi[31420] @ %Time @ "</t><t>分钟后开始，帮主可在</t>" @ %Path @ "<t>召唤帮派图腾召集帮众前来接受图腾祝福。</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

		%Text2 = GetHuoDongName("群英汇聚",2) @ "<t>将于</t>" @ $Get_Dialog_GeShi[60002] @ %Time @ "</t><t>分钟后开启</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
	if (%Time == 0)
	{
		%HuoDongMingCheng = GetHuoDongName("群英汇聚",1);
		%Path = "<l i='810010100 -7.75371 -21.687 191.679' t='path'/>";
		%Text = %HuoDongMingCheng @ "<t>活动已经开始，帮主可在</t>" @ %Path @ "<t>召唤帮派图腾召集帮众前来接受图腾祝福。</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

		%Text2 = GetHuoDongName("群英汇聚",2) @ "<t>活动已经开始</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
	if (%Time < 0  && %Time >= -55 && %Time%10 == 0)
	{
		%HuoDongMingCheng = GetHuoDongName("群英汇聚",1);
		%Path = "<l i='810010100 -7.75371 -21.687 191.679' t='path'/>";
		%Text = %HuoDongMingCheng @ "<t>正在进行中，修士们可前往</t>" @ %Path @ "<t>寻找帮派图腾获取图腾祝福。</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

		%Text2 = GetHuoDongName("群英汇聚",2) @ "<t>正在进行中</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
}
//105109061	聚英令
function Trigger_105109061(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	if (GetZoneID() != 1001)
	{
		%text = "该道具只允许在主城使用!";
		SendOneScreenMessage(2,%text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
		return;
	}
	if (%Player.gettriggerid() != 810010107)
	{
		%text = "该道具只允许在【会盟广场】使用!";
		SendOneScreenMessage(2,%text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
		return;
	}
	if ($SL_JiaZuGouHuo_State_bActive != 1)
	{
		%text = "活动将在" @ $SL_JiaZuGouHuo_StartTime @ "开始!";
		SendOneScreenMessage(2,%text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
		return;
	}
	%PlayerID = %Player.GetPlayerid();
	%orgID = SptOrg_GetOrgID(%PlayerID);		//家族ID
	%orgID_Name = SptOrg_GetName(%orgID);		//家族名称
	%orgID_Level = SptOrg_GetLevel(%orgID);	//帮派等级
	//是否是族长
	if (%Player.GetOrgMemberLevel(1) < 6)//是否是帮主
	{
		%text = "只有帮主才能召唤神奇的图腾!";
		SendOneScreenMessage(2,%text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
		return;
	}
	switch (%orgID_Level)
	{
		case 1:%NpcID = 410010220;
		case 2:%NpcID = 410010221;
		case 3:%NpcID = 410010222;
		case 4:%NpcID = 410010223;
		case 5:%NpcID = 410010224;
		default:return;
	}
	%Player.PutItem(%Type,-1);
	if (%Player.Additem(16,%type))
	{
		%Monster = SpNewNpc2(0,%NpcID,%Player.GetPosition(),%Player.GetLayerid(),0);
		//%MonsterName = GetNpcData( %NpcID, 1 );
		//%Monster.SetShapename( %MonsterName @ "『" @  %orgID_Name @ "』" );
		%Monster.SetExclusivePlayerName(%orgID_Name);
		%Monster.BindPlayerID = %PlayerID;
		%Monster.BindOrgID = %orgID;
		%Monster.BindName  = %orgID_Name;
		%Monster.BindOrgLevel = %orgID_Level;


		%OrgName = $Get_Dialog_GeShi[31421] @ "『" @ %orgID_Name @ "』</t>";
		%PlayerName = GetPlayerZiTiName(%Player,1);
		%NpcName = GetNpcZiTiName(%Monster,1);

		%Path = "<l i='810010100 " @  %Player.GetPosition() @ "' t='path'/>";
		%Text =  %OrgName @ "<t>的帮主</t>" @ %PlayerName @ "<t>在</t>" @ %Path @ "<t>召唤出</t>" @ %NpcName @ "<t>，帮内精英纷纷聚集前来沐浴图腾光辉。</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Text @ "</t>");

		%PlayerName2 = GetPlayerZiTiName(%Player,2);
		%Text2 = %PlayerName2 @ "<t>召唤了</t>" @ %NpcName;
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);

		%Time = GetLocalTime();
		%H = GetWord(%Time,3);//小时
		%M = GetWord(%Time,4);//分钟
		%TimeA = %H * 60 + %M;
		%TimeB = GetWord($SL_JiaZuGouHuo_EndTime,0,":") * 60 + GetWord($SL_JiaZuGouHuo_EndTime,1,":");
		%LostTime = %TimeB - %TimeA;
		Schedule(%LostTime * 60 * 1000,0,"eval",%Monster @ ".Safedeleteobject(); ");
	}
}

//
function NpcOnTrigger_Dialog_QunYingHuiJu(%Npc,%Player,%State,%Conv,%Param,%Level)
{
	if ($SL_JiaZuGouHuo_State_bActive != 1)
		return;
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000000);
			%Conv.AddOption(600000001,600000001);
		case 600000001:
			%PlayerID = %Player.GetPlayerid();
			%orgID = SptOrg_GetOrgID(%PlayerID);		//家族ID
			if (%Player.Getlevel() < $SL_JiaZuGouHuo_Level)
			{
				SendOneScreenMessage(2,"您的等级低于" @ $SL_JiaZuGouHuo_Level @ "级，无法领取图腾之力",%Player);
				return NpcOnTrigger_Dialog_QunYingHuiJu(%Npc,%Player,0,%Conv,%Param,%Level);
			}
			else
			{
				if (%orgID ==  %Npc.BindOrgID)//自己家族的东西
				{
					%Conv.SetType(4);
					%Player.Addbuff(39909 * 10000 + %Level,%Player,1);
					%Player.GouHuoBuff = %Level;
					%Player.SetSchbuff(2000);
					SetOrgActivityRecord(%Player, 6);//帮派活动 群英汇聚 记录完成
					AddAchievementWatch(%Player,0,40,1);//记录成就
				}
				else
				{
					%Conv.SetText(600000002);
					%Conv.AddOption(600000003,600000003);
				}
			}
		case 600000003:
			%Conv.Settype(4);
			%Money = %Player.GetMoney(1);
			if (%Money < 200)
			{
				%text = "你的元宝不足!";
				SendOneScreenMessage(2,%text,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
				return;
			}
			%Player.ReduceMoney(200,1,16,105109061);//扣除元宝
			%Player.SetSchbuff(2000);
			%Player.Addbuff(39909 * 10000 + %Level,%Player,1);
			%Player.GouHuoBuff = %Level;
			SetOrgActivityRecord(%Player, 6);//帮派活动 群英汇聚 记录完成
			AddAchievementWatch(%Player,0,40,1);//记录成就

			%OrgMasterID = %Npc.BindPlayerID;
			if (%OrgMasterID > 0)
				SptMail_Send(%OrgMasterID,0,0,100,0,"图腾收获","<t>有非本帮玩家领取了本帮的图腾之力，你获得一部分收益，请及时收取！</t>");
	}
}//SptMail_Send( 50000304, 105109061, 2, 123, 12345, "图腾收获", "<t>有非本帮玩家领有非本帮玩家领有非本帮玩家领有非本帮玩家领有非本帮玩家领有非本帮玩家领有非本帮玩家领有非本帮玩家领有非本帮玩家领</t>" );
function ScheduleBuff_2000(%Player,%BuffID,%IsAuto)
{
	if ($SL_JiaZuGouHuo_State_bActive == 1)
	{
		if (%Player.gettriggerid() == 810010107)
		{
			//--帮派等级系数
			%ExpBangPaiLevel = 0;
			if (%Player.getbuffcount(39909,1)>= 1) %ExpBangPaiLevel = 0;
			else if (%Player.getbuffcount(39909,2)>= 1) %ExpBangPaiLevel = 0.2;
			else if (%Player.getbuffcount(39909,3)>= 1) %ExpBangPaiLevel = 0.5;
			else if (%Player.getbuffcount(39909,4)>= 1) %ExpBangPaiLevel = 1;
			else if (%Player.getbuffcount(39909,5)>= 1) %ExpBangPaiLevel = 1.5;

			//---双倍经验
			%Exp_LeiJiaBeiShu = 0;
			if (%Player.ISschbuff(1997)) %Exp_LeiJiaBeiShu = 1;	  //经验丹的加成
			if (%Player.ISschbuff(1998)) %Exp_LeiJiaBeiShu = 1.5; //经验丹的加成
			if (%Player.ISschbuff(1999)) %Exp_LeiJiaBeiShu = 2;	  //经验丹的加成

			//帮派贡献卡暂无
			%GongXianKa = 0;
			//角色等级微调系数
			%Level = %Player.GetLevel();
			if (%Level < 30) %LevelXiShu = 0.3;
			else if (%Level < 40) %LevelXiShu = 1;
			else if (%Level < 50) %LevelXiShu = 1.2;
			else if (%Level < 60) %LevelXiShu = 1.6;
			else if (%Level < 70) %LevelXiShu = 2.0;
			else  %LevelXiShu = 2.2;
			//EXP = 等级经验 * （双倍经验 + 帮派等级系数 + 帮派贡献卡）* 角色等级微调系数
			//echo( "$Monster_Exp[ %Level, 1 ]==" @ $Monster_Exp[ %Level, 1 ] );
			//echo( "%Exp_LeiJiaBeiShu==" @ %Exp_LeiJiaBeiShu );
			//echo( "%ExpBangPaiLevel==" @ %ExpBangPaiLevel );
			//echo( "%GongXianKa==" @ %GongXianKa );
			//echo( "%LevelXiShu==" @ %LevelXiShu );
			%Exp = $Monster_Exp[%Level,1] *(%Exp_LeiJiaBeiShu + %ExpBangPaiLevel + %GongXianKa + 1) * %LevelXiShu;
			if (%Exp > 0)
				AllAddExp(%Player,%Exp);
		}
		%Player.SetSchbuff(2000);
		return 0;
	}
	else
	{
		if (%Player.getbuffcount(39909,1)>= 1) %Player.RemoveBuff(399090001);
		if (%Player.getbuffcount(39909,2)>= 1) %Player.RemoveBuff(399090002);
		if (%Player.getbuffcount(39909,3)>= 1) %Player.RemoveBuff(399090003);
		if (%Player.getbuffcount(39909,4)>= 1) %Player.RemoveBuff(399090004);
		if (%Player.getbuffcount(39909,5)>= 1) %Player.RemoveBuff(399090005);
	}
	return 1;
	//返回非0，表示%buffid需要处理完后移除掉
}
/*
SptOrg_AddLevel( SptOrg_GetOrgID(  50000182 ));		//家族ID );//帮派等级 + 1
*/