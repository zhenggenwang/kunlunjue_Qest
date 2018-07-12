//function MissionxxxxxDialog( %Npc, %Player, %Mid, %Tid )//通用任务基础模板
//{
//	//echo( "%Tid ==" @ %Tid );
//	switch ( %Tid )
//	{
//
//		case 10001:	return "<t>废话</t><b/>"; //任务目标
//		case 10002:	return "<t>废话</t><b/>"; //接任务对白
//		case 10005:	return "<t>废话</t><b/>"; //任务完成时对白
//
//		case 20001:return "<t></t><b/>";//接任务前NPC的废话
//		case 21001:return "<t></t><b/>";//接任务前玩家的废话
//
//		case 30001:return "<t>1</t><b/>";//交任务前NPC的废话
//		case 31001:return "<t>1</t><b/>";//交任务前玩家的废话
//
//		case 30002:return "<t>2</t><b/>";//交任务前NPC的废话
//		case 31002:return "<t>2</t><b/>";//交任务前玩家的废话
//	}
//	if ( %Tid <= 20000 || %Tid >= 40000 )
//		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
//	else
//		return "";
//}
//■■■■■■■■■■■■■■■【冰火试炼】任务对话■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■■■■【支线】任务对话■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■■■■【生活技能】任务对话■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■■■■【悬赏缉凶】任务对话■■■■■■■■■■■■■■■■


//■■■■■■■■■■■■■■■【冰火试炼】任务对话■■■■■■■■■■■■■■■■
function Mission20001Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,1); } //寒冰之魂
function Mission20002Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,2); } //烈火之炎
function Mission20003Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,3); } //铲除冰蜥
function Mission20004Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,4); } //铲除火蜥
function Mission20005Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,5); } //乔装采药
function Mission20006Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,6); } //冰火之珠·一
function Mission20007Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,7); } //冰火之珠·二
function Mission20008Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,8); } //降妖除魔
function Mission20009Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,1); } //寒冰之魂
function Mission20010Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,2); } //烈火之炎
function Mission20011Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,3); } //铲除冰蜥
function Mission20012Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,4); } //铲除火蜥
function Mission20013Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,5); } //乔装采药
function Mission20014Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,6); } //冰火之珠·一
function Mission20015Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,7); } //冰火之珠·二
function Mission20016Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,8); } //降妖除魔
function Mission20017Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,1); } //寒冰之魂
function Mission20018Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,2); } //烈火之炎
function Mission20019Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,3); } //铲除冰蜥
function Mission20020Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,4); } //铲除火蜥
function Mission20021Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,5); } //乔装采药
function Mission20022Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,6); } //冰火之珠·一
function Mission20023Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,7); } //冰火之珠·二
function Mission20024Dialog(%Npc,%Player,%Mid,%Tid){ Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,8); } //降妖除魔
function Mission20001_20024Dialog(%Npc,%Player,%Mid,%Tid,%Optype)
{
	switch (%Tid)
	{
		case 10001:
			switch (%Optype)//任务目标
			{
				case 1:return "<t>前往极寒之地采集寒冰之霜交给冰雲</t><b/>";
				case 2:return "<t>前往极炎之地采集烈火之炎交给炎宵</t><b/>";
				case 3:return "<t>前往极寒之地击败寒霜蜥</t><b/>";
				case 4:return "<t>前往极炎之地击败烈焰蜴</t><b/>";
				case 5:return "<t>采集仙草交给幽千寻</t><b/>";
				case 6:return "<t>收集神石、灵石、奇石任意一种</t><b/>";
				case 7:return "<t>收集神石、灵石、奇石五次</t><b/>";
				case 8:return "<t>击败寒冰之魂、烈焰之魂、守护之魂</t><b/>";
			}
		case 10002:	//接任务对白
			switch (%Optype)
			{
				case 1:return "<t>极寒之地盛产寒冰之霜，能令人修为大增，能够多采集一些来就好了</t><b/>";
				case 2:return "<t>极炎之地盛产烈火之炎，能令人修为大增，能够多采集一些来就好了</t><b/>";
				case 3:return "<t>极寒之地经常出现寒霜蜥，想要盗取寒冰之魄，必须将次怪物铲除</t><b/>";
				case 4:return "<t>极炎之地经常出现烈焰蜴，想要盗取烈火之炎，必须将次怪物铲除</t><b/>";
				case 5:return "<t>这冰火之地炎寒至极，损人修为，要有丹药护体方可进入，现在需要一些护体丹药所需要的仙草</t><b/>";
				case 6:return "<t>护体丹药光有仙草不够，需要注入奇异神石的灵气方可见效</t><b/>";
				case 7:return "<t>奇异神石虽好，但是离开圣地灵气就变得微弱，需要采集更多数量的来才行</t><b/>";
				case 8:return "<t>此地灵气孕育而成的妖魔占山为王，将这些宝物都据为己有，实在是可恶</t><b/>";
			}
		case 10005:	return "<t>不错，辛苦阁下了。</t><b/>";
		case 910:
			%Level = %Player.GetLevel();
			if (%Level < 30) %LevelXiShu = 0.5;
			else if (%Level < 40) %LevelXiShu = 1.2;
			else if (%Level < 50) %LevelXiShu = 1.2;
			else if (%Level < 60) %LevelXiShu = 1.6;
			else if (%Level < 70) %LevelXiShu = 2.0;
			else %LevelXiShu = 2.2;

			if (%Level < 25) %LVExp = 0;
			else if (%Level < 40) %LVExp = 20000;
			else if (%Level < 50) %LVExp = 30000;
			else if (%Level < 60) %LVExp = 50000;
			else if (%Level < 70) %LVExp = 80000;
			else if (%Level < 80) %LVExp = 100000;
			else if (%Level < 90) %LVExp = 120000;
			else  %LVExp = 120000;

			switch (%Optype)//任务目标
			{
				case 1://寒冰之魂
					%LikeMonSterNum = 60;
					%PinZhiXiShu = 1;
				case 2://烈火之炎
					%LikeMonSterNum = 60;
					%PinZhiXiShu = 1;
				case 3://铲除蟾妖
					%LikeMonSterNum = 100;
					%PinZhiXiShu = 1;
				case 4://铲除妖蟒
					%LikeMonSterNum = 100;
					%PinZhiXiShu = 1;
				case 5://乔装采药
					for (%i = 0; %i <= 4; %i++)
					{
						if (GetSrc(%Player,%Src + %i) == 0)
						{
							%NowState = %i + 1;
							break;
						}
					}
					if (%NowState == 5)
					{
						%PinZhiXiShu = 1.1; //80只1.0 80只1.2 平均1.1
						%LikeMonSterNum = 160;
					}
					else
					{
						%LikeMonSterNum = 80;
						switch (%NowState)
						{
							case 1:%PinZhiXiShu = 0.6;
							case 2:%PinZhiXiShu = 0.7;
							case 3:%PinZhiXiShu = 0.8;
							case 4:%PinZhiXiShu = 0.9;
						}
					}

				case 6://冰火之珠·一
					%LikeMonSterNum = 100;
					if (%Player.GetBuffCount(39906,1) >= 1) %PinZhiXiShu = 1;
					else if (%Player.GetBuffCount(39906,2) >= 1) %PinZhiXiShu = 2;
					else if (%Player.GetBuffCount(39906,3) >= 1) %PinZhiXiShu = 4;
					else %PinZhiXiShu = 1;
					%NeedMid = %Mid + 1;
					if (%player.IsAcceptedMission(%NeedMid))
					{
						%NeedFalg = %Player.GetMissionFlag(%NeedMid,10320);
						%Player.SetMissionFlag(%NeedMid,10320,%NeedFalg + %PinZhiXiShu);
						%Player.UpdateMission(%Mid);
					}

				case 7://冰火之珠·二
					%LikeMonSterNum = 100;
					%NeedFalg = %Player.GetMissionFlag(%Mid,10330);
					//echo( getplayer( ).getmissionflag( 20007, 10330 ) );
					//echo( %Mid @ "    %NeedFalg===" @ %NeedFalg );
					%PinZhiXiShu = %NeedFalg * 0.3;
				case 8://降妖除魔
					%LikeMonSterNum = 300;
					%PinZhiXiShu = 1;
			}
			%MonSterExp = $Monster_Exp[%Level,1];
			%Exp = mfloor(%MonSterExp *(%LikeMonSterNum + %Level) * %PinZhiXiShu * %LevelXiShu + %LVExp);

			if (CanDoThisMission(%Player,%Mid,2,0,0) $= "")	//是否已经可交付
				%Exp = $Get_Dialog_GeShi[31403] @ "经验奖励：</t>" @ %Exp @ "<b/>";
			else
				%Exp = $Get_Dialog_GeShi[31403] @ "经验奖励：</t>" @ %Exp @ "<t> + ???</t>" @ "<b/>";

			return $Get_Dialog_GeShi[31401] @ %Exp @ "</t>";

	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}

function Mission20025Dialog(%Npc,%Player,%Mid,%Tid){ Mission20025_20027Dialog(%Npc,%Player,%Mid,%Tid); }
function Mission20026Dialog(%Npc,%Player,%Mid,%Tid){ Mission20025_20027Dialog(%Npc,%Player,%Mid,%Tid); }
function Mission20027Dialog(%Npc,%Player,%Mid,%Tid){ Mission20025_20027Dialog(%Npc,%Player,%Mid,%Tid); }
function Mission20025_20027Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>记住得集齐配套数量的材料回来，必有赏赐</t><b/>";
		case 10002:	return "<t>翼妖虽是妖兽，肉质酸腐，但全身是宝啊！羽可衣，喙可药，爪可器，你可搜集些过来</t><b/>";
		case 10005:	return "<t>不错，辛苦阁下了。</t><b/>";
		case 910:
			%ItemCount[1] = %Player.GetitemCount(108020006);//翼妖之羽
			%ItemCount[2] = %Player.GetitemCount(108020007);//翼妖之喙
			%ItemCount[3] = %Player.GetitemCount(108020008);//翼妖之爪
			if (%ItemCount[1] >= %ItemCount[2])
				%Count = %ItemCount[2];
			else
				%Count = %ItemCount[1];
			if (%ItemCount[3] <  %Count)
				%Count = %ItemCount[3];
			%Count = mfloor(%Count/10)*10;
			if (%Count < 10)
				%Count = 10;

			//%Player.ClearMissionItem( %Mid );	//清除之前的物品显示
			//%Player.AddItemToMission( %Mid, 1, 108020208, 1 );	
			%Level = %Player.GetLevel();
			if (%Level < 30) %LevelXiShu = 0.5;
			else if (%Level < 40) %LevelXiShu = 1.0;
			else if (%Level < 50) %LevelXiShu = 1.2;
			else if (%Level < 60) %LevelXiShu = 1.6;
			else if (%Level < 70) %LevelXiShu = 2.0;
			else %LevelXiShu = 2.2;

			if (%Level < 25) %LVExp = 0;
			else if (%Level < 40) %LVExp = 20000;
			else if (%Level < 50) %LVExp = 30000;
			else if (%Level < 60) %LVExp = 50000;
			else if (%Level < 70) %LVExp = 80000;
			else if (%Level < 80) %LVExp = 100000;
			else if (%Level < 90) %LVExp = 120000;
			else  %LVExp = 120000;

			%LikeMonSterNum = 300 * %Count/10;
			%PinZhiXiShu = 1;

			%MonSterExp = $Monster_Exp[%Level,1];
			%Exp = %MonSterExp *(%LikeMonSterNum + %Level) * %PinZhiXiShu * %LevelXiShu + %LVExp;
			%Exp = mfloor(%Exp);
			%GeShi = 31405;
			%Txt = "<t>当前阶段，每种材料扣除 </t>" @ $Get_Dialog_GeShi[31409] @ %Count / 10 @ "</t><t> 倍数量</t><b/>";
			%Exp = $Get_Dialog_GeShi[31403] @ "经验奖励：</t>" @ %Exp @ "<b/>";
			//echo( "%Exp===" @ %Exp );
			//%Item = $Get_Dialog_GeShi[ 31403 ] @ "有几率获得以下物品：</t><b/>" @ GetFixedMissionItemText( %Mid );
			return $Get_Dialog_GeShi[31401] @ %Txt @ %Exp @ %Item @ "</t>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
//■■■■■■■■■■■■■■■【冰火试炼】任务对话■■■■■■■■■■■■■■■■

//■■■■■■■■■■■■■■■【支线】任务对话■■■■■■■■■■■■■■■■
function Mission20201Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>用白纸将秘籍记录下来</t><b/>";
		case 10002:	return "<t>要传授你秘籍没问题，这秘籍之奥秘之处极为复杂，想要凭空记住也太过于难了，好歹也要给我一张纸用来记录。</t><b/>";
		case 10005:	return "<t>切记！此技能需要施法材料才能释放。我先送你几个，以后可就要你自己想办法获取了。</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}

function Mission20205Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>前往望仙谷寻找云游隐士，并击败他的灵宠</t><b/>";
		case 10002:	return "<t>行踪不定的云游隐士有许多奇珍宝物，最近出现在望仙谷。要是有缘遇见他，并能通过他的考验，就会获得一份赠礼。</t><b/>";
		case 10005:	return "<t>资质真不错，既然有缘，那就选一件喜欢的武器吧。</t><b/>";

		case 411:return $Icon[4] @ $Get_Dialog_GeShi[31495] @"<t>接受考验</t>";

		case 511:return "<t>既然遇见那便是缘分，若你有实力能通过我的考验，那我将送你一份礼物。</t><b/>";
		case 512:return "<t>这只灵狐是我的灵宠，跟随我云游四方，看你是否能够战胜它。</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission20206Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>击败灵狐</t><b/>";
		case 10002:	return "<t>行踪不定的云游隐士有许多奇珍宝物，最近出现在望仙谷。要是有缘遇见他，并能通过他的考验，就会获得一份赠礼。</t><b/>";
		case 10005:	return "<t>资质真不错，既然有缘，那就选一件喜欢的武器吧。</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission20202Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>赶走偷吃桑叶的金蚕</t><b/>";
		case 10002:	return "<t>后面的园子里最近出现好多蚕妖，不仅偷食了桑叶，又在祸害蚕蛹，少侠若能帮除妖，小女感激不尽！</t><b/>";
		case 10005:	return "<t>少侠真是帮了大忙了，小女感激不尽！。</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission20203Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>从鼠窝中找回玲珑珠</t><b/>";
		case 10002:	return "<t>这些鼠妖真是越来越嚣张了，偷吃粮食也就算了，还偷走了我的玲珑珠。你可得帮我教训教训它们，顺便帮我吧玲珑珠找回来。</t><b/>";
		case 10005:	return "<t>谢谢你帮我把玲珑珠找回来。</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission20204Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>击败树妖取得树心</t><b/>";
		case 10002:	return "<t>叶天舒缺少一些树心制作武器呢，你去帮一帮他吧。</t><b/>";
		case 10005:	return "<t>辛苦了，我这里正好有件多余的防具送与你了。</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
function Mission20207Dialog( %Npc, %Player, %Mid, %Tid )
{
	switch ( %Tid )
	{
		case 10001:	return "<t>完成3次师门尽忠</t><b/>";
		case 10002:	return "<t>门派事务繁忙，望诸弟子分担琐碎杂物，为师门尽忠</t><b/>";
		case 10005:	return "<t>必须要完成10次师门尽忠任务可获得黄金密令</t><b/>";
	}
	if ( %Tid <= 20000 || %Tid >= 40000 )
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
//■■■■■■■■■■■■■■■【支线】任务对话■■■■■■■■■■■■■■■■


//■■■■■■■■■■■■■■■【生活技能】任务对话■■■■■■■■■■■■■■■■
function Mission30101Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30111Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30121Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30131Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30201Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30202Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30203Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30301Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30302Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30303Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30401Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30402Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30403Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30501Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30502Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30503Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30601Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30602Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30603Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30701Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30702Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30703Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30102Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30103Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30104Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30105Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30106Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30107Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30108Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30109Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30110Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30112Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30113Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30114Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30115Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30116Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30117Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30118Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30119Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30120Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30122Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30123Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30124Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30125Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30126Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30127Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30128Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30129Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30130Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30132Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30133Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30134Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30135Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30136Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30137Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30138Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30139Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30140Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30204Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30205Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30206Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30207Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30208Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30209Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30210Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30211Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30212Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30304Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30305Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30306Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30307Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30308Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30309Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30310Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30311Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30312Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30404Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30405Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30406Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30407Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30408Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30409Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30410Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30411Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30412Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30504Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30505Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30506Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30507Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30508Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30509Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30510Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30511Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30512Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30604Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30605Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30606Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30607Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30608Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30609Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30610Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30611Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30612Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

function Mission30704Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30705Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30706Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30707Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30708Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30709Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30710Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30711Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }
function Mission30712Dialog(%Npc,%Player,%Mid,%Tid){ MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid); }

$MissionDialog[30101,10001]="找铁狂人学习挖矿";
$MissionDialog[30101,10002]="想要跟我学习挖矿，至少要有一把像样的工具才行吧。先去杂货商店买一把矿锄带上再来找我";
$MissionDialog[30101,10005]="不错，看你如此天资聪慧，我就把挖矿的诀窍传授给你";

$MissionDialog[30102,10001]="学习更高级的生活技能";
$MissionDialog[30102,10002]="你想在这个行当里出类拔萃的话，这就需要付出比别人高出十倍、百倍的辛苦。为了考验你的恒心，你先去挖10个铜矿来";
$MissionDialog[30102,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代矿神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30103,10001]="学习更高级的生活技能";
$MissionDialog[30103,10002]="从现在开始，我就要指导你更高深的挖矿之术，带你入门。在带你入门之前，你必须要交纳10个铁矿，还需要询得一位挖矿大师的心得才行。";
$MissionDialog[30103,10005]="恩，想不到你居然还能得到那老师傅的心得，还真是造化。从现在开始，你就踏入挖矿师的行业，以后我行之兴盛就要靠你了。";

$MissionDialog[30104,10001]="学习更高级的生活技能";
$MissionDialog[30104,10002]="这行当讲的是灵气，没点天分的人还是不要学的好。我现在就好好考考你，看你能否挖出10个银矿，让我看看你是否合适当一名矿师。";
$MissionDialog[30104,10005]="这矿的虽然粗陋，不过从成色上看，倒是有那么一点灵气。好，好，看来你还能当当矿师。";

$MissionDialog[30105,10001]="学习更高级的生活技能";
$MissionDialog[30105,10002]="想不到你的挖矿本领能有所长进。从现在开始，我就要指导你更高深的挖矿之术！但是在这之前，你必须要交纳10个金矿。";
$MissionDialog[30105,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代矿神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30106,10001]="学习更高级的生活技能";
$MissionDialog[30106,10002]="现在你已经熟练掌握了挖矿技术，快要成为了挖矿大师了。按照行里的规矩，想要往更高深处发展的话必须先向老师交纳10块黑铁矿。";
$MissionDialog[30106,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代矿神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30107,10001]="学习更高级的生活技能";
$MissionDialog[30107,10002]="以你现在的挖矿技巧已经可以向点脉大师冲刺了，不过我可要先提醒你，高级矿脉可是很难找到的，如果你能交纳10个秘银矿，我就把高级挖矿之术传授予你。";
$MissionDialog[30107,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代矿神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30108,10001]="学习更高级的生活技能";
$MissionDialog[30108,10002]="现在你离矿神只差一步之遥了，如果你能通过我的考验，挖出10块魔金矿出来，我就把这高深的挖矿之术传授予你，让你能成为矿神。";
$MissionDialog[30108,10005]="现在你的挖矿之术已经达到矿神了，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30109,10001]="学习更高级的生活技能";
$MissionDialog[30109,10002]="现在你的挖矿之术已经达到矿神了，但是你要知道学无止境，以你的天分，定能达到挖矿之顶峰，只要你能拿出10个精金矿，我再助你一臂之力。";
$MissionDialog[30109,10005]="恭喜你挖矿技能更精进一层，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30110,10001]="学习更高级的生活技能";
$MissionDialog[30110,10002]="现在你的挖矿之术已经即将达到顶峰，你再拿出10个紫金矿，我再助你达成挖矿之顶峰。";
$MissionDialog[30110,10005]="恭喜你，已经成为了古今达到挖矿顶峰的第一人，真是前无古人后无来者。";

$MissionDialog[30111,10001]="找祝枝山学习伐木";
$MissionDialog[30111,10002]="想要跟我学习伐木，至少要有一把像样的工具才行吧。先去杂货商店买一把伐斧带上再来找我";
$MissionDialog[30111,10005]="不错，看你如此天资聪慧，我就把伐木的诀窍传授给你";

$MissionDialog[30112,10001]="学习更高级的生活技能";
$MissionDialog[30112,10002]="你想在这个行当里出类拔萃的话，这就需要付出比别人高出十倍、百倍的辛苦。为了考验你的恒心，你先去伐10个柳木来";
$MissionDialog[30112,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代伐木大神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30113,10001]="学习更高级的生活技能";
$MissionDialog[30113,10002]="从现在开始，我就要指导你更高深的伐木之术，带你入门。在带你入门之前，你必须要交纳10个桐木，还需要询得一位伐木大师的心得才行。";
$MissionDialog[30113,10005]="恩，想不到你居然还能得到那老师傅的心得，还真是造化。从现在开始，你就踏入伐木师的行业，以后我行之兴盛就要靠你了。";

$MissionDialog[30114,10001]="学习更高级的生活技能";
$MissionDialog[30114,10002]="这行当讲的是灵气，没点天分的人还是不要学的好。我现在就好好考考你，看你能否伐木出10个樟木，让我看看你是否合适当一名伐木师。";
$MissionDialog[30114,10005]="这木材伐的虽然粗陋，不过从成色上看，倒是有那么一点灵气。好，好，看来你还能当当铸师。";

$MissionDialog[30115,10001]="学习更高级的生活技能";
$MissionDialog[30115,10002]="想不到你的伐木本领能有所长进。从现在开始，我就要指导你更高深的伐木之术！但是在这之前，你必须要交纳10个杉木。";
$MissionDialog[30115,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代伐木大神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30116,10001]="学习更高级的生活技能";
$MissionDialog[30116,10002]="现在你已经熟练掌握了伐木技术，快要成为了伐木大师了。按照行里的规矩，想要往更高深处发展的话必须先向老师交纳10檀木。";
$MissionDialog[30116,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代伐木大神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30117,10001]="学习更高级的生活技能";
$MissionDialog[30117,10002]="以你现在的伐木技巧简直堪比吴刚在世，不过我可要先提醒你，高级木材可是很难找到的，如果你能交纳10个红木，我就把高级伐木之术传授予你。";
$MissionDialog[30117,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代伐木大神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30118,10001]="学习更高级的生活技能";
$MissionDialog[30118,10002]="现在你离伐木大神只差一步之遥了，如果你能通过我的考验，伐得10块铁木出来，我就把这高深的伐木之术传授予你，让你能成为伐木大神。";
$MissionDialog[30118,10005]="现在你的伐木之术已经达到伐木大神了，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30119,10001]="学习更高级的生活技能";
$MissionDialog[30119,10002]="现在你的伐木之术已经达到伐木大神了，但是你要知道学无止境，以你的天分，定能达到伐木之顶峰，只要你能拿出10个玄木，我再助你一臂之力。";
$MissionDialog[30119,10005]="恭喜你伐木技能更精进一层，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30120,10001]="学习更高级的生活技能";
$MissionDialog[30120,10002]="现在你的伐木之术已经即将达到顶峰，你再拿出10个神木，我再助你达成伐木之顶峰。";
$MissionDialog[30120,10005]="恭喜你，已经成为了古今达到伐木顶峰的第一人，真是前无古人后无来者。";

$MissionDialog[30121,10001]="找梁飞飞学习采药";
$MissionDialog[30121,10002]="想要跟我学习采药，至少要有一把像样的工具才行吧。先去杂货商店买一把镰刀带上再来找我";
$MissionDialog[30121,10005]="不错，看你如此天资聪慧，我就把采药的诀窍传授给你";

$MissionDialog[30122,10001]="学习更高级的生活技能";
$MissionDialog[30122,10002]="你想在这个行当里出类拔萃的话，这就需要付出比别人高出十倍、百倍的辛苦。为了考验你的恒心，你先去采集10个紫草来";
$MissionDialog[30122,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代神农祇，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30123,10001]="学习更高级的生活技能";
$MissionDialog[30123,10002]="从现在开始，我就要指导你更高深的采药之术，带你入门。在带你入门之前，你必须要交纳10个金银花，还需要询得一位采药大师的心得才行。";
$MissionDialog[30123,10005]="恩，想不到你居然还能得到那老师傅的心得，还真是造化。从现在开始，你就踏入采药师的行业，以后我行之兴盛就要靠你了。";

$MissionDialog[30124,10001]="学习更高级的生活技能";
$MissionDialog[30124,10002]="这行当讲的是灵气，没点天分的人还是不要学的好。我现在就好好考考你，看你能否采药出10个首乌，让我看看你是否合适当一名采药师。";
$MissionDialog[30124,10005]="这药草虽然夹杂一些杂草，不过从成色上看，倒是有那么一点灵气。好，好，看来你还能当当采药师。";

$MissionDialog[30125,10001]="学习更高级的生活技能";
$MissionDialog[30125,10002]="想不到你的采药本领能有所长进。从现在开始，我就要指导你更高深的采药之术！但是在这之前，你必须要交纳10个当归。";
$MissionDialog[30125,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代神农祇，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30126,10001]="学习更高级的生活技能";
$MissionDialog[30126,10002]="现在你已经熟练掌握了采药技术，快要成为了采药大师了。按照行里的规矩，想要往更高深处发展的话必须先向老师交纳10个野山参。";
$MissionDialog[30126,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代神农祇，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30127,10001]="学习更高级的生活技能";
$MissionDialog[30127,10002]="以你现在的采药技巧简直就像是神农附身，不过我可要先提醒你，高级药料可是很难收集的，如果你能交纳10个冬虫夏草，我就把高级采药之术传授予你。";
$MissionDialog[30127,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代神农祇，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30128,10001]="学习更高级的生活技能";
$MissionDialog[30128,10002]="现在你离神农祇只差一步之遥了，如果你能通过我的考验，采集10个九曲灵参出来，我就把这高深的采药之术传授予你，让你能成为神农祇。";
$MissionDialog[30128,10005]="现在你的采药之术已经达到神农祇了，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30129,10001]="学习更高级的生活技能";
$MissionDialog[30129,10002]="现在你的采药之术已经达到神农祇了，但是你要知道学无止境，以你的天分，定能达到采药之顶峰，只要你能拿出10个冬虫夏草，我再助你一臂之力。";
$MissionDialog[30129,10005]="恭喜你采药技能更精进一层，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30130,10001]="学习更高级的生活技能";
$MissionDialog[30130,10002]="现在你的采药之术已经即将达到顶峰，你再拿出10个九曲灵参，我再助你达成采药之顶峰。";
$MissionDialog[30130,10005]="恭喜你，已经成为了古今达到采药顶峰的第一人，真是前无古人后无来者。";

$MissionDialog[30131,10001]="找蓬逢学习钓鱼";
$MissionDialog[30131,10002]="想要跟我学习钓鱼，至少要有一把像样的工具才行吧。先去杂货商店买一把渔杆带上再来找我";
$MissionDialog[30131,10005]="不错，看你如此天资聪慧，我就把钓鱼的诀窍传授给你";

$MissionDialog[30132,10001]="学习更高级的生活技能";
$MissionDialog[30132,10002]="你想在这个行当里出类拔萃的话，这就需要付出比别人高出十倍、百倍的辛苦。为了考验你的恒心，你先去钓10个河虾来";
$MissionDialog[30132,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代渔神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30133,10001]="学习更高级的生活技能";
$MissionDialog[30133,10002]="从现在开始，我就要指导你更高深的钓鱼之术，带你入门。在带你入门之前，你必须要交纳10个河蟹，还需要询得一位钓鱼大师的心得才行。";
$MissionDialog[30133,10005]="恩，想不到你居然还能得到那老师傅的心得，还真是造化。从现在开始，你就踏入钓鱼师的行业，以后我行之兴盛就要靠你了。";

$MissionDialog[30134,10001]="学习更高级的生活技能";
$MissionDialog[30134,10002]="这行当讲的是灵气，没点天分的人还是不要学的好。我现在就好好考考你，看你能否钓鱼出10个鳝鱼，让我看看你是否合适当一名钓鱼师。";
$MissionDialog[30134,10005]="这几条鱼虽然小，不过看上去倒是有那么一点灵气。好，好，看来你还能当当钓鱼师。";

$MissionDialog[30135,10001]="学习更高级的生活技能";
$MissionDialog[30135,10002]="想不到你的钓鱼本领能有所长进。从现在开始，我就要指导你更高深的钓鱼之术！但是在这之前，你必须要交纳10个斗鱼。";
$MissionDialog[30135,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代渔神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30136,10001]="学习更高级的生活技能";
$MissionDialog[30136,10002]="现在你已经熟练掌握了钓鱼技术，快要成为了钓鱼大师了。按照行里的规矩，想要往更高深处发展的话必须先向老师交纳10块甲鱼。";
$MissionDialog[30136,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代渔神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30137,10001]="学习更高级的生活技能";
$MissionDialog[30137,10002]="以你现在的钓鱼技巧已经可以向渔溪子冲刺了，不过我可要先提醒你，高级的鱼可是很难钓的，如果你能交纳10个河鳗，我就把高级钓鱼之术传授予你。";
$MissionDialog[30137,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代渔神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30138,10001]="学习更高级的生活技能";
$MissionDialog[30138,10002]="现在你离渔神只差一步之遥了，如果你能通过我的考验，钓上10个桂鱼出来，我就把这高深的钓鱼之术传授予你，让你能成为渔神。";
$MissionDialog[30138,10005]="现在你的钓鱼之术已经达到渔神了，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30139,10001]="学习更高级的生活技能";
$MissionDialog[30139,10002]="现在你的钓鱼之术已经达到渔神了，但是你要知道学无止境，以你的天分，定能达到钓鱼之顶峰，只要你能拿出10个文昌鱼，我再助你一臂之力。";
$MissionDialog[30139,10005]="恭喜你钓鱼技能更精进一层，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30140,10001]="学习更高级的生活技能";
$MissionDialog[30140,10002]="现在你的钓鱼之术已经即将达到顶峰，你再拿出10个银鱼，我再助你达成钓鱼之顶峰。";
$MissionDialog[30140,10005]="恭喜你，已经成为了古今达到钓鱼顶峰的第一人，真是前无古人后无来者。";

$MissionDialog[30201,10001]="询问铁狂人";
$MissionDialog[30201,10002]="想要学习铸造之术，若是你能炼出铜矿锭才能证明你有这个天赋，先去找铁狂人了解情况吧";
$MissionDialog[30201,10005]="你想要炼制铜矿锭？";

$MissionDialog[30202,10001]="需要先找齐炼制铜矿锭的材料";
$MissionDialog[30202,10002]="铜矿可通过挖矿获得，或者向玩家购买</t><b/><t>助融剂和池水可在昆仑城的西门一剑处购买";
$MissionDialog[30202,10005]="材料加上配方就可以炼制铜矿锭";

$MissionDialog[30203,10001]="拿着炼制好的铜矿锭去交任务吧";
$MissionDialog[30203,10002]="拿着炼制好的铜矿锭去交任务吧";
$MissionDialog[30203,10005]="果然是天资过人，如此一来，我也就放心将此铸造术倾授与你。";

$MissionDialog[30204,10001]="学习更高级的生活技能";
$MissionDialog[30204,10002]="你想在这个行当里出类拔萃的话，这就需要付出比别人高出十倍、百倍的辛苦。为了考验你的恒心，你先去铸造10个铜矿锭来";
$MissionDialog[30204,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代鬼斧神工，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30205,10001]="学习更高级的生活技能";
$MissionDialog[30205,10002]="从现在开始，我就要指导你更高深的铸造之术，带你入门。在带你入门之前，你必须要交纳10个铁矿锭，还需要询得一位铸造大师的心得才行。";
$MissionDialog[30205,10005]="恩，想不到你居然还能得到那老师傅的心得，还真是造化。从现在开始，你就踏入铸造师的行业，以后我行之兴盛就要靠你了。";

$MissionDialog[30206,10001]="学习更高级的生活技能";
$MissionDialog[30206,10002]="这行当讲的是灵气，没点天分的人还是不要学的好。我现在就好好考考你，看你能否铸造出10个银矿锭，让我看看你是否合适当一名铸造师。";
$MissionDialog[30206,10005]="这矿锭铸造的虽然粗陋，不过从成色上看，倒是有那么一点灵气。好，好，看来你还能当当铸师。";

$MissionDialog[30207,10001]="学习更高级的生活技能";
$MissionDialog[30207,10002]="想不到你的铸造本领能有所长进。从现在开始，我就要指导你更高深的铸造之术！但是在这之前，你必须要交纳10个金矿锭。";
$MissionDialog[30207,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代鬼斧神工，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30208,10001]="学习更高级的生活技能";
$MissionDialog[30208,10002]="现在你已经熟练掌握了锻造技术，快要成为了铸剑大师了。按照行里的规矩，想要往更高深处发展的话必须先向老师交纳10块黑铁矿锭。";
$MissionDialog[30208,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代鬼斧神工，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30209,10001]="学习更高级的生活技能";
$MissionDialog[30209,10002]="以你现在的锻造技巧已经可以向能工巧匠冲刺了，不过我可要先提醒你，高级锻造之术的材料可是很难收集的，如果你能交纳10个秘银矿锭，我就把高级锻造之术传授予你。";
$MissionDialog[30209,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代鬼斧神工，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30210,10001]="学习更高级的生活技能";
$MissionDialog[30210,10002]="现在你离鬼斧神工只差一步之遥了，如果你能通过我的考验，熔炼出10块魔金锭出来，我就把这高深的锻造之术传授予你，让你能成为鬼斧神工。";
$MissionDialog[30210,10005]="现在你的铸造之术已经达到鬼斧神工了，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30211,10001]="学习更高级的生活技能";
$MissionDialog[30211,10002]="现在你的铸造之术已经达到鬼斧神工了，但是你要知道学无止境，以你的天分，定能达到铸造之顶峰，只要你能拿出10个精金矿锭，我再助你一臂之力。";
$MissionDialog[30211,10005]="恭喜你铸造技能更精进一层，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30212,10001]="学习更高级的生活技能";
$MissionDialog[30212,10002]="现在你的铸造之术已经即将达到顶峰，你再拿出10个紫金矿锭，我再助你达成铸造之顶峰。";
$MissionDialog[30212,10005]="恭喜你，已经成为了古今达到铸造顶峰的第一人，真是前无古人后无来者。";

$MissionDialog[30301,10001]="询问景霞";
$MissionDialog[30301,10002]="想要学习裁缝之术，若是你能制造出荨麻布才能证明你有这个天赋，先去找景霞了解情况吧";
$MissionDialog[30301,10005]="你想要制造荨麻布？";

$MissionDialog[30302,10001]="需要先找齐制荨麻布的材料";
$MissionDialog[30302,10002]="粗麻可通过打怪掉落，或者向玩家购买</t><b/><t>檀木卷和粗线可在昆仑城的织瑾瑶处购买";
$MissionDialog[30302,10005]="材料加上配方就可以制造荨麻布";

$MissionDialog[30303,10001]="拿着制造好的荨麻布去交任务吧";
$MissionDialog[30303,10002]="拿着制造好的荨麻布去交任务吧";
$MissionDialog[30303,10005]="果然是天资过人，如此一来，我也就放心将此裁缝术倾授与你。";

$MissionDialog[30304,10001]="学习更高级的生活技能";
$MissionDialog[30304,10002]="你想在这个行当里出类拔萃的话，这就需要付出比别人高出十倍、百倍的辛苦。为了考验你的恒心，你先去缝纫10个荨麻布来";
$MissionDialog[30304,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代天衣无缝，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30305,10001]="学习更高级的生活技能";
$MissionDialog[30305,10002]="从现在开始，我就要指导你更高深的裁缝之术，带你入门。在带你入门之前，你必须要交纳10个素纱卷，还需要询得一位裁缝大师的心得才行。";
$MissionDialog[30305,10005]="恩，想不到你居然还能得到那老师傅的心得，还真是造化。从现在开始，你就踏入裁缝师的行业，以后我行之兴盛就要靠你了。";

$MissionDialog[30306,10001]="学习更高级的生活技能";
$MissionDialog[30306,10002]="这行当讲的是灵气，没点天分的人还是不要学的好。我现在就好好考考你，看你能否缝纫出10个素罗纱，让我看看你是否合适当一名裁缝师。";
$MissionDialog[30306,10005]="这布料的虽然粗陋，不过从成色上看，倒是有那么一点灵气。好，好，看来你还能当当铸师。";

$MissionDialog[30307,10001]="学习更高级的生活技能";
$MissionDialog[30307,10002]="想不到你的裁缝本领能有所长进。从现在开始，我就要指导你更高深的裁缝之术！但是在这之前，你必须要交纳10个云锦片。";
$MissionDialog[30307,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代天衣无缝，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30308,10001]="学习更高级的生活技能";
$MissionDialog[30308,10002]="现在你已经熟练掌握了裁缝技术，快要成为了裁缝大师了。按照行里的规矩，想要往更高深处发展的话必须先向老师交纳10个软烟罗卷。";
$MissionDialog[30308,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代天衣无缝，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30309,10001]="学习更高级的生活技能";
$MissionDialog[30309,10002]="以你现在的裁缝技巧已经可以向巧手无双冲刺了，不过我可要先提醒你，高级裁缝之术的材料可是很难收集的，如果你能交纳10个烟影纱片，我就把高级裁缝之术传授予你。";
$MissionDialog[30309,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代天衣无缝，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30310,10001]="学习更高级的生活技能";
$MissionDialog[30310,10002]="现在你离天衣无缝只差一步之遥了，如果你能通过我的考验，缝纫出10个浮光锦片出来，我就把这高深的裁缝之术传授予你，让你能成为天衣无缝。";
$MissionDialog[30310,10005]="现在你的裁缝之术已经达到天衣无缝了，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30311,10001]="学习更高级的生活技能";
$MissionDialog[30311,10002]="现在你的裁缝之术已经达到天衣无缝了，但是你要知道学无止境，以你的天分，定能达到裁缝之顶峰，只要你能拿出10个蝉翼纱缎，我再助你一臂之力。";
$MissionDialog[30311,10005]="恭喜你裁缝技能更精进一层，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30312,10001]="学习更高级的生活技能";
$MissionDialog[30312,10002]="现在你的裁缝之术已经即将达到顶峰，你再拿出10个云雾绡缎，我再助你达成裁缝之顶峰。";
$MissionDialog[30312,10005]="恭喜你，已经成为了古今达到裁缝顶峰的第一人，真是前无古人后无来者。";

$MissionDialog[30401,10001]="询问杨子石";
$MissionDialog[30401,10002]="想要学习制器之术，若是你能炼出柳木木料才能证明你有这个天赋，先去找杨子石了解情况吧";
$MissionDialog[30401,10005]="你想要炼制柳木木料？";

$MissionDialog[30402,10001]="需要先找齐炼制柳木木料的材料";
$MissionDialog[30402,10002]="柳木可通过伐木获得，或者向玩家购买</t><b/><t>砂纸可在昆仑城的巧儿处购买";
$MissionDialog[30402,10005]="材料加上配方就可以炼制柳木木料";

$MissionDialog[30403,10001]="拿着炼制好的柳木木料去交任务吧";
$MissionDialog[30403,10002]="拿着炼制好的柳木木料去交任务吧";
$MissionDialog[30403,10005]="果然是天资过人，如此一来，我也就放心将此制器术倾授与你。";

$MissionDialog[30404,10001]="学习更高级的生活技能";
$MissionDialog[30404,10002]="你想在这个行当里出类拔萃的话，这就需要付出比别人高出十倍、百倍的辛苦。为了考验你的恒心，你先去制作10个柳木木料";
$MissionDialog[30404,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代神匠，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30405,10001]="学习更高级的生活技能";
$MissionDialog[30405,10002]="从现在开始，我就要指导你更高深的制器之术，带你入门。在带你入门之前，你必须要交纳10个桐木木料，还需要询得一位制器大师的心得才行。";
$MissionDialog[30405,10005]="恩，想不到你居然还能得到那老师傅的心得，还真是造化。从现在开始，你就踏入制器师的行业，以后我行之兴盛就要靠你了。";

$MissionDialog[30406,10001]="学习更高级的生活技能";
$MissionDialog[30406,10002]="这行当讲的是灵气，没点天分的人还是不要学的好。我现在就好好考考你，看你能否制作出10个樟木木料，让我看看你是否合适当一名制器师。";
$MissionDialog[30406,10005]="这木料制作的虽然粗陋，不过从成色上看，倒是有那么一点灵气。好，好，看来你还能当当制器师。";

$MissionDialog[30407,10001]="学习更高级的生活技能";
$MissionDialog[30407,10002]="想不到你的制器本领能有所长进。从现在开始，我就要指导你更高深的制器之术！但是在这之前，你必须要交纳10个杉木木料。";
$MissionDialog[30407,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代神匠，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30408,10001]="学习更高级的生活技能";
$MissionDialog[30408,10002]="现在你已经熟练掌握了制器技术，快要成为了制器大师了。按照行里的规矩，想要往更高深处发展的话必须先向老师交纳10檀木木料。";
$MissionDialog[30408,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代神匠，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30409,10001]="学习更高级的生活技能";
$MissionDialog[30409,10002]="以你现在的制器技巧已经接近能塞鲁班了，不过我可要先提醒你，高级制器之术的材料可是很难收集的，如果你能交纳10个红木木料，我就把高级制器之术传授予你。";
$MissionDialog[30409,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代神匠，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30410,10001]="学习更高级的生活技能";
$MissionDialog[30410,10002]="现在你离神匠只差一步之遥了，如果你能通过我的考验，熔炼出10个铁木木料出来，我就把这高深的制器之术传授予你，让你能成为神匠。";
$MissionDialog[30410,10005]="现在你的制器之术已经达到神匠了，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30411,10001]="学习更高级的生活技能";
$MissionDialog[30411,10002]="现在你的制器之术已经达到神匠了，但是你要知道学无止境，以你的天分，定能达到制器之顶峰，只要你能拿出10个玄木木料，我再助你一臂之力。";
$MissionDialog[30411,10005]="恭喜你制器技能更精进一层，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30412,10001]="学习更高级的生活技能";
$MissionDialog[30412,10002]="现在你的制器之术已经即将达到顶峰，你再拿出10个神木木料，我再助你达成制器之顶峰。";
$MissionDialog[30412,10005]="恭喜你，已经成为了古今达到制器顶峰的第一人，真是前无古人后无来者。";

$MissionDialog[30501,10001]="询问茹云";
$MissionDialog[30501,10002]="想要学习炼丹之术，若是你能炼出紫草药粉才能证明你有这个天赋，先去找茹云了解情况吧";
$MissionDialog[30501,10005]="你想要炼制紫草药粉？";

$MissionDialog[30502,10001]="需要先找齐炼制紫草药粉的材料";
$MissionDialog[30502,10002]="紫草可通过采药获得，或者向玩家购买</t><b/><t>药瓶可在昆仑城的柳宗来处购买";
$MissionDialog[30502,10005]="材料加上配方就可以炼制紫草药粉";

$MissionDialog[30503,10001]="拿着炼制好的紫草药粉去交任务吧";
$MissionDialog[30503,10002]="拿着炼制好的紫草药粉去交任务吧";
$MissionDialog[30503,10005]="果然是天资过人，如此一来，我也就放心将此炼丹术倾授与你。";

$MissionDialog[30504,10001]="学习更高级的生活技能";
$MissionDialog[30504,10002]="你想在这个行当里出类拔萃的话，这就需要付出比别人高出十倍、百倍的辛苦。为了考验你的恒心，你先去炼出10份紫草药粉来";
$MissionDialog[30504,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代神医，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30505,10001]="学习更高级的生活技能";
$MissionDialog[30505,10002]="从现在开始，我就要指导你更高深的炼丹之术，带你入门。在带你入门之前，你必须要交纳10份金银花药粉，还需要询得一位炼丹大师的心得才行。";
$MissionDialog[30505,10005]="恩，想不到你居然还能得到那老师傅的心得，还真是造化。从现在开始，你就踏入炼丹师的行业，以后我行之兴盛就要靠你了。";

$MissionDialog[30506,10001]="学习更高级的生活技能";
$MissionDialog[30506,10002]="这行当讲的是灵气，没点天分的人还是不要学的好。我现在就好好考考你，看你能否炼丹出10份首乌药粉，让我看看你是否合适当一名炼丹师。";
$MissionDialog[30506,10005]="这丹药的虽然粗陋，不过从成色上看，倒是有那么一点灵气。好，好，看来你还能当当铸师。";

$MissionDialog[30507,10001]="学习更高级的生活技能";
$MissionDialog[30507,10002]="想不到你的炼丹本领能有所长进。从现在开始，我就要指导你更高深的炼丹之术！但是在这之前，你必须要交纳10份当归药粉。";
$MissionDialog[30507,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代神医，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30508,10001]="学习更高级的生活技能";
$MissionDialog[30508,10002]="现在你已经熟练掌握了炼丹技术，快要成为了炼丹大师了。按照行里的规矩，想要往更高深处发展的话必须先向老师交纳10份野山参药粉。";
$MissionDialog[30508,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代神医，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30509,10001]="学习更高级的生活技能";
$MissionDialog[30509,10002]="以你现在的炼丹技巧已经接近扁鹊在世了，不过我可要先提醒你，高级炼丹之术的材料可是很难收集的，如果你能交纳10份冬虫夏草药粉，我就把高级炼丹之术传授予你。";
$MissionDialog[30509,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代神医，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30510,10001]="学习更高级的生活技能";
$MissionDialog[30510,10002]="现在你离神医只差一步之遥了，如果你能通过我的考验，炼出10份九曲灵参药粉出来，我就把这高深的炼丹之术传授予你，让你能成为神医。";
$MissionDialog[30510,10005]="现在你的炼丹之术已经达到神医了，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30511,10001]="学习更高级的生活技能";
$MissionDialog[30511,10002]="现在你的炼丹之术已经达到神医了，但是你要知道学无止境，以你的天分，定能达到炼丹之顶峰，只要你能拿出10份野灵芝药粉，我再助你一臂之力。";
$MissionDialog[30511,10005]="恭喜你炼丹技能更精进一层，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30512,10001]="学习更高级的生活技能";
$MissionDialog[30512,10002]="现在你的炼丹之术已经即将达到顶峰，你再拿出10份九曲灵芝药粉，我再助你达成炼丹之顶峰。";
$MissionDialog[30512,10005]="恭喜你，已经成为了古今达到炼丹顶峰的第一人，真是前无古人后无来者。";

$MissionDialog[30601,10001]="询问林忆君";
$MissionDialog[30601,10002]="想要学习符咒之术，若是你能制出破损符纸才能证明你有这个天赋，先去找林忆君了解情况吧";
$MissionDialog[30601,10005]="你想要制作破损符纸？";

$MissionDialog[30602,10001]="需要先找齐制作破损符纸的材料";
$MissionDialog[30602,10002]="柳木可通过伐木获得，或者向玩家购买</t><b/><t>砂纸可在昆仑城的巧儿处购买";
$MissionDialog[30602,10005]="材料加上配方就可以制作破损符纸";

$MissionDialog[30603,10001]="拿着制作好的破损符纸去交任务吧";
$MissionDialog[30603,10002]="拿着制作好的破损符纸去交任务吧";
$MissionDialog[30603,10005]="果然是天资过人，如此一来，我也就放心将此符咒术倾授与你。";

$MissionDialog[30604,10001]="学习更高级的生活技能";
$MissionDialog[30604,10002]="你想在这个行当里出类拔萃的话，这就需要付出比别人高出十倍、百倍的辛苦。为了考验你的恒心，你先去制作10个破损符纸来";
$MissionDialog[30604,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代符神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30605,10001]="学习更高级的生活技能";
$MissionDialog[30605,10002]="从现在开始，我就要指导你更高深的符咒之术，带你入门。在带你入门之前，你必须要交纳10个劣质符纸，还需要询得一位符咒大师的心得才行。";
$MissionDialog[30605,10005]="恩，想不到你居然还能得到那老师傅的心得，还真是造化。从现在开始，你就踏入符咒师的行业，以后我行之兴盛就要靠你了。";

$MissionDialog[30606,10001]="学习更高级的生活技能";
$MissionDialog[30606,10002]="这行当讲的是灵气，没点天分的人还是不要学的好。我现在就好好考考你，看你能否制作出10个下品符纸，让我看看你是否合适当一名符咒师。";
$MissionDialog[30606,10005]="这符咒虽然粗陋，不过从成色上看，倒是有那么一点灵气。好，好，看来你还能当当符咒师。";

$MissionDialog[30607,10001]="学习更高级的生活技能";
$MissionDialog[30607,10002]="想不到你的符咒本领能有所长进。从现在开始，我就要指导你更高深的符咒之术！但是在这之前，你必须要交纳10个中品符纸。";
$MissionDialog[30607,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代符神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30608,10001]="学习更高级的生活技能";
$MissionDialog[30608,10002]="现在你已经熟练掌握了符咒技术，快要成为了符咒大师了。按照行里的规矩，想要往更高深处发展的话必须先向老师交纳10块上品符纸。";
$MissionDialog[30608,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代符神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30609,10001]="学习更高级的生活技能";
$MissionDialog[30609,10002]="以你现在的符咒技巧已经接近塞马良了，不过我可要先提醒你，高级符咒之术的材料可是很难收集的，如果你能交纳10个优质符纸，我就把高级符咒之术传授予你。";
$MissionDialog[30609,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代符神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30610,10001]="学习更高级的生活技能";
$MissionDialog[30610,10002]="现在你离符神只差一步之遥了，如果你能通过我的考验，制作出10个完美符纸出来，我就把这高深的符咒之术传授予你，让你能成为符神。";
$MissionDialog[30610,10005]="现在你的符咒之术已经达到符神了，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30611,10001]="学习更高级的生活技能";
$MissionDialog[30611,10002]="现在你的符咒之术已经达到符神了，但是你要知道学无止境，以你的天分，定能达到符咒之顶峰，只要你能拿出10个优质符纸，我再助你一臂之力。";
$MissionDialog[30611,10005]="恭喜你符咒技能更精进一层，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30612,10001]="学习更高级的生活技能";
$MissionDialog[30612,10002]="现在你的符咒之术已经即将达到顶峰，你再拿出10个完美符纸，我再助你达成符咒之顶峰。";
$MissionDialog[30612,10005]="恭喜你，已经成为了古今达到符咒顶峰的第一人，真是前无古人后无来者。";

$MissionDialog[30701,10001]="询问林大嫂";
$MissionDialog[30701,10002]="想要学习烹饪之术，若是你能烹饪出薄荷水才能证明你有这个天赋，先去找林大嫂了解情况吧";
$MissionDialog[30701,10005]="你想要烹饪薄荷水？";

$MissionDialog[30702,10001]="需要先找齐烹饪薄荷水的材料";
$MissionDialog[30702,10002]="薄荷可通过打怪掉落，或者向玩家购买</t><b/><t>调料可在昆仑城的林魅儿处购买";
$MissionDialog[30702,10005]="材料加上配方就可以烹饪薄荷水";

$MissionDialog[30703,10001]="拿着烹饪好的薄荷水去交任务吧";
$MissionDialog[30703,10002]="拿着烹饪好的薄荷水去交任务吧";
$MissionDialog[30703,10005]="果然是天资过人，如此一来，我也就放心将此烹饪术倾授与你。";

$MissionDialog[30704,10001]="学习更高级的生活技能";
$MissionDialog[30704,10002]="你想在这个行当里出类拔萃的话，这就需要付出比别人高出十倍、百倍的辛苦。为了考验你的恒心，你先去烹饪10个薄荷水来";
$MissionDialog[30704,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代食神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30705,10001]="学习更高级的生活技能";
$MissionDialog[30705,10002]="从现在开始，我就要指导你更高深的烹饪之术，带你入门。在带你入门之前，你必须要交纳10个面粉，还需要询得一位烹饪大师的心得才行。";
$MissionDialog[30705,10005]="恩，想不到你居然还能得到那老师傅的心得，还真是造化。从现在开始，你就踏入烹饪师的行业，以后我行之兴盛就要靠你了。";

$MissionDialog[30706,10001]="学习更高级的生活技能";
$MissionDialog[30706,10002]="这行当讲的是灵气，没点天分的人还是不要学的好。我现在就好好考考你，看你能否烹饪出10个酒曲，让我看看你是否合适当一名烹饪师。";
$MissionDialog[30706,10005]="这些食材虽然粗陋，不过从成色上看，倒是有那么一点灵气。好，好，看来你还能当当烹饪师。";

$MissionDialog[30707,10001]="学习更高级的生活技能";
$MissionDialog[30707,10002]="想不到你的烹饪本领能有所长进。从现在开始，我就要指导你更高深的烹饪之术！但是在这之前，你必须要交纳10个香茶。";
$MissionDialog[30707,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代食神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30708,10001]="学习更高级的生活技能";
$MissionDialog[30708,10002]="现在你已经熟练掌握了烹饪技术，快要成为了烹饪大师了。按照行里的规矩，想要往更高深处发展的话必须先向老师交纳10个米粉。";
$MissionDialog[30708,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代食神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30709,10001]="学习更高级的生活技能";
$MissionDialog[30709,10002]="以你现在的烹饪技巧已经简直堪比当世易牙了，不过我可要先提醒你，高级烹饪之术的材料可是很难收集的，如果你能交纳10个豆腐，我就把高级烹饪之术传授予你。";
$MissionDialog[30709,10005]="很好，就凭你这份恒心，他日必定能在这个行当中成为一代食神，不过以后还要多多努力,有什么不懂的地方，可以来问我。";

$MissionDialog[30710,10001]="学习更高级的生活技能";
$MissionDialog[30710,10002]="现在你离食神只差一步之遥了，如果你能通过我的考验，熔炼出15个面皮出来，我就把这高深的烹饪之术传授予你，让你能成为食神。";
$MissionDialog[30710,10005]="现在你的烹饪之术已经达到食神了，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30711,10001]="学习更高级的生活技能";
$MissionDialog[30711,10002]="现在你的烹饪之术已经达到食神了，但是你要知道学无止境，以你的天分，定能达到烹饪之顶峰，只要你能拿出10个肉馅，我再助你一臂之力。";
$MissionDialog[30711,10005]="恭喜你烹饪技能更精进一层，我已经没有什么可以再教你的，若是以后遇到瓶颈的地方，可以来找我帮忙。";

$MissionDialog[30712,10001]="学习更高级的生活技能";
$MissionDialog[30712,10002]="现在你的烹饪之术已经即将达到顶峰，你再拿出10个面条，我再助你达成烹饪之顶峰。";
$MissionDialog[30712,10005]="恭喜你，已经成为了古今达到烹饪顶峰的第一人，真是前无古人后无来者。";

function MissionShengHuoJiNengDialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001: return "<t>" @ $MissionDialog[%Mid,%Tid] @ "</t><b/>";
		case 10002: return "<t>" @ $MissionDialog[%Mid,%Tid] @ "</t><b/>";
		case 10005: return "<t>" @ $MissionDialog[%Mid,%Tid] @ "</t><b/>";

		case 411: return $Icon[4] @ $Get_Dialog_GeShi[31495] @ "询问心得</t>";

		case 511: return "<t>万事不能强求，这种事情还得讲究天分！</t>";
		case 512: return "<t>我看你求知的欲望如此强烈，也实在不好意思拒绝了！</t>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}

//■■■■■■■■■■■■■■■【生活技能】任务对话■■■■■■■■■■■■■■■■



//■■■■■■■■■■■■■■■【悬赏缉凶】任务对话■■■■■■■■■■■■■■■■
function Mission29101Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29102Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29103Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29104Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29105Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29106Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29107Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29108Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29109Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29110Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29111Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29112Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29113Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29114Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29115Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29116Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29117Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29118Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29119Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29120Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29121Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29122Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29123Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29124Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29125Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29126Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29127Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29128Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29129Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29130Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29131Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29132Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29133Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29134Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29135Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29136Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29137Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29138Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29139Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29140Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29141Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29142Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29143Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29144Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29145Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29146Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29147Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29148Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29149Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29150Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29201Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29202Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29203Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29204Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29205Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29206Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29207Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29208Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29209Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29210Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29211Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29212Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29213Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29214Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29215Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29216Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29217Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29218Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29219Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29220Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29221Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29222Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29223Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29224Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29225Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29226Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29227Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29228Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29229Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29230Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29231Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29232Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29233Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29234Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29235Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29236Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29237Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29238Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29239Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29240Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29241Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29242Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29243Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29244Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29245Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29246Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29247Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29248Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29249Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29250Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29301Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29302Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29303Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29304Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29305Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29306Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29307Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29308Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29309Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29310Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29311Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29312Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29313Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29314Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29315Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29316Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29317Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29318Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29319Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29320Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29321Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29322Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29323Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29324Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29325Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29326Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29327Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29328Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29329Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29330Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29331Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29332Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29333Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29334Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29335Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29336Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29337Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29338Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29339Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29340Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29341Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29342Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29343Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29344Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29345Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29346Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29347Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29348Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29349Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29350Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29401Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29402Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29403Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29404Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29405Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29406Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29407Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29408Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29409Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29410Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29411Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29412Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29413Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29414Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29415Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29416Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29417Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29418Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29419Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29420Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29421Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29422Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29423Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29424Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29425Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29426Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29427Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29428Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29429Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29430Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29431Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29432Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29433Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29434Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29435Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29436Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29437Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29438Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29439Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29440Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29441Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29442Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29443Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29444Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29445Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29446Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29447Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29448Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29449Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29450Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29501Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29502Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29503Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29504Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29505Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29506Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29507Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29508Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29509Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29510Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29511Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29512Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29513Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29514Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29515Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29516Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29517Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29518Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29519Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29520Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29521Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29522Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29523Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29524Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29525Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29526Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29527Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29528Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29529Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29530Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29531Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29532Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29533Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29534Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29535Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29536Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29537Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29538Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29539Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29540Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29541Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29542Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29543Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29544Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29545Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29546Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29547Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29548Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29549Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29550Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29601Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29602Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29603Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29604Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29605Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29606Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29607Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29608Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29609Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29610Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29611Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29612Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29613Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29614Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29615Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29616Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29617Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29618Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29619Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29620Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29621Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29622Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29623Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29624Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29625Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29626Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29627Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29628Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29629Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29630Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29631Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29632Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29633Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29634Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29635Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29636Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29637Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29638Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29639Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29640Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29641Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29642Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29643Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29644Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29645Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29646Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29647Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29648Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29649Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }
function Mission29650Dialog(%Npc,%Player,%Mid,%Tid){ MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid); }

$MissionDialog[29101,10001]="前往路口寻找枯木灵芝给梁飞飞";
$MissionDialog[29101,10002]="给婆婆煎药的枯木灵芝不够了，麻烦你帮我去村口采一些回来";
$MissionDialog[29101,10005]="不错，辛苦阁下了。";

$MissionDialog[29102,10001]="击败猛虎，收集虎骨交给梁飞飞";
$MissionDialog[29102,10002]="最近研究新药还缺少一些虎骨，可山中老虎如此凶猛，我一个小女子可如何是好";
$MissionDialog[29102,10005]="不错，辛苦阁下了。";

$MissionDialog[29103,10001]="击败青丘狐，收集狐血交给梁飞飞";
$MissionDialog[29103,10002]="给婆婆的要一直没什么效果，听说需要青丘狐的血做药引才能治好婆婆的病";
$MissionDialog[29103,10005]="不错，辛苦阁下了。";

$MissionDialog[29104,300]="这把新斧子够锋利了吧";
$MissionDialog[29104,10001]="寻找剑师，鲁匠师打造新斧子";
$MissionDialog[29104,10002]="天天砍柴，我的斧子都快变钝器了，可否替我向鲁匠师做一把新斧子";
$MissionDialog[29104,10005]="不错，辛苦阁下了。";

$MissionDialog[29105,10001]="帮助祝枝山收集柴火";
$MissionDialog[29105,10002]="我砍了好多柴放在村口的，一个人搬不回来，侠士可否帮我去搬一些回来";
$MissionDialog[29105,10005]="不错，辛苦阁下了。";

$MissionDialog[29106,10001]="击败树妖";
$MissionDialog[29106,10002]="听说村口出现了会吃人的树妖，我现在都不敢出门去砍柴了，这可怎么办呢";
$MissionDialog[29106,10005]="不错，辛苦阁下了。";

$MissionDialog[29107,10001]="击败枯树老妖，收集树干交给梁隐";
$MissionDialog[29107,10002]="昨天我钓上来一条大鱼，把我的鱼竿都弄坏了，要在挑一根合适的鱼竿可不容易啊";
$MissionDialog[29107,10005]="不错，辛苦阁下了。";

$MissionDialog[29108,10001]="击败赤芒蚊";
$MissionDialog[29108,10002]="鱼儿鱼儿不上钩，没有鱼饵了，要是能抓几只蚊子来就好了";
$MissionDialog[29108,10005]="不错，辛苦阁下了。";

$MissionDialog[29109,10001]="修复渔网";
$MissionDialog[29109,10002]="三天打渔，两天晒网，我的网都已经坏了，帮我修补一下吧";
$MissionDialog[29109,10005]="不错，辛苦阁下了。";

$MissionDialog[29110,10001]="击败吸血妖蚊";
$MissionDialog[29110,10002]="不知为何，村子外面来了好多蚊子，专吸人血，村民们都不敢出去了";
$MissionDialog[29110,10005]="不错，辛苦阁下了。";

$MissionDialog[29111,10001]="前往村西口点燃火把";
$MissionDialog[29111,10002]="西边有个蚊子巢穴，可在路口点上火把防止蚊子出来";
$MissionDialog[29111,10005]="不错，辛苦阁下了。";

$MissionDialog[29112,10001]="前往黄沙岭寻探宝藏";
$MissionDialog[29112,10002]="传说黄沙岭有远古王国遗落的宝藏，但是一直有沙妖守护，看见过的人都再也没回来了";
$MissionDialog[29112,10005]="不错，辛苦阁下了。";

$MissionDialog[29113,10001]="前往鳄鱼潭祭坛完成祭天";
$MissionDialog[29113,10002]="村子的里传统每月都要去天坛祭天，可是我老了，走不动了";
$MissionDialog[29113,10005]="不错，辛苦阁下了。";

$MissionDialog[29114,10001]="寻找野果交给童子";
$MissionDialog[29114,10002]="村长不让我出去玩，帮我摘果子吃好不好";
$MissionDialog[29114,10005]="不错，辛苦阁下了。";

$MissionDialog[29115,10001]="前往乐民村池塘采摘荷叶交给童子";
$MissionDialog[29115,10002]="下雨咯，下雨咯，摘几片荷叶当帽子玩";
$MissionDialog[29115,10005]="不错，辛苦阁下了。";

$MissionDialog[29116,10001]="前往乐民村池塘打捞珠子交给童子";
$MissionDialog[29116,10002]="我的珠子掉到池塘里了，掉下去的的地方我都做了标记的";
$MissionDialog[29116,10005]="不错，辛苦阁下了。";

$MissionDialog[29117,10001]="击败猛虎，收集虎皮交给梁婆婆";
$MissionDialog[29117,10002]="天气冷了，想给女儿做一件皮袄保暖，要是有些虎皮就好了";
$MissionDialog[29117,10005]="不错，辛苦阁下了。";

$MissionDialog[29118,10001]="捡起针线交给梁婆婆";
$MissionDialog[29118,10002]="年纪大了，眼睛不好使了，这个针线掉在地上我都看不见，找不到了";
$MissionDialog[29118,10005]="不错，辛苦阁下了。";

$MissionDialog[29119,10001]="击败猛虎，收集虎筋交给女猎人";
$MissionDialog[29119,10002]="弓弦有些松弛，力道不够了，要是有些虎筋做弓弦，那可就太好了";
$MissionDialog[29119,10005]="不错，辛苦阁下了。";

$MissionDialog[29120,10001]="击败枯树老妖，收集树枝交给女猎人";
$MissionDialog[29120,10002]="箭支快要用完了，需要找一些树枝来制作";
$MissionDialog[29120,10005]="不错，辛苦阁下了。";

$MissionDialog[29121,10001]="击败摄魂沙妖";
$MissionDialog[29121,10002]="近来总有些沙妖冒犯村庄，可不能让他们得逞";
$MissionDialog[29121,10005]="不错，辛苦阁下了。";

$MissionDialog[29122,10001]="击败青丘白狐，获取白狐皮交给女猎人";
$MissionDialog[29122,10002]="青丘岭上白狐的毛皮可漂亮了，肯定卖一些好价钱";
$MissionDialog[29122,10005]="不错，辛苦阁下了。";

$MissionDialog[29123,300]="这是我独家秘制的金疮药，拿好了";
$MissionDialog[29123,10001]="寻找药师华千骨取外伤药";
$MissionDialog[29123,10002]="打猎哪有不受伤的，这点小伤只要擦点……用完了，看来要找药师去讨药了";
$MissionDialog[29123,10005]="不错，辛苦阁下了。";

$MissionDialog[29124,10001]="前往黄沙岭寻找荷花交给叶璇";
$MissionDialog[29124,10002]="好喜欢荷花，更喜欢有灵气的荷花，有灵气的荷花才能在黄沙中的水池盛开";
$MissionDialog[29124,10005]="不错，辛苦阁下了。";

$MissionDialog[29125,10001]="前往紫晶潭寻找紫晶石交给叶璇";
$MissionDialog[29125,10002]="女人天生就对一些闪闪发光的东西没有抵抗力";
$MissionDialog[29125,10005]="不错，辛苦阁下了。";

$MissionDialog[29126,10001]="击败山大王青丘狐魔";
$MissionDialog[29126,10002]="跟我一起去击败青丘狐魔，赏金我们平分，怎样";
$MissionDialog[29126,10005]="不错，辛苦阁下了。";

$MissionDialog[29127,10001]="击败枯树魔精";
$MissionDialog[29127,10002]="收拾枯树魔精这样的小妖，也用得着我出手么";
$MissionDialog[29127,10005]="不错，辛苦阁下了。";

$MissionDialog[29128,300]="地宫险恶，闲杂人等速速离去！";
$MissionDialog[29128,10001]="寻找地宫守卫打探地宫消息";
$MissionDialog[29128,10002]="听说地宫内的怪物凶猛无比，而且都是会主动攻击的，还是先打探一番";
$MissionDialog[29128,10005]="不错，辛苦阁下了。";

$MissionDialog[29129,10001]="修复笼子";
$MissionDialog[29129,10002]="有人破坏笼子放走了老虎，不能让老虎进村庄，你先帮我把笼子修好，我把老虎抓回来";
$MissionDialog[29129,10005]="不错，辛苦阁下了。";

$MissionDialog[29130,10001]="击败青丘白狐，收集白狐尾交给三师兄";
$MissionDialog[29130,10002]="这白狐的尾巴看起来可真是白亮光鲜，拿去送给叶璇仙子一定会喜欢的";
$MissionDialog[29130,10005]="不错，辛苦阁下了。";

$MissionDialog[29131,10001]="前往炼仙炉查看炼仙炉情况";
$MissionDialog[29131,10002]="师父命我在此照看炼仙炉，维持炉中温度不变，如果你能替我跑这一趟的话……嘿嘿";
$MissionDialog[29131,10005]="不错，辛苦阁下了。";

$MissionDialog[29132,10001]="击败枯树魔精";
$MissionDialog[29132,10002]="我等在此守护村庄，可否助我一臂之力剿除枯树魔精";
$MissionDialog[29132,10005]="不错，辛苦阁下了。";

$MissionDialog[29133,10001]="击败裂魂沙妖";
$MissionDialog[29133,10002]="沙妖所过之地，土地变黄沙，不能让他们侵犯我们地方";
$MissionDialog[29133,10005]="不错，辛苦阁下了。";

$MissionDialog[29134,300]="没问题，你看这些都是上好的兵器！";
$MissionDialog[29134,10001]="寻找剑师鲁匠师打造兵器";
$MissionDialog[29134,10002]="我们的战士多次战斗，兵器都已经磨损了，希望能找剑师打造一匹新的兵器";
$MissionDialog[29134,10005]="不错，辛苦阁下了。";

$MissionDialog[29135,10001]="击败铁鳄，收集鳄鱼尾交给华千骨";
$MissionDialog[29135,10002]="我需要的药材缺少了鳄鱼的尾巴，可是鳄鱼潭不是常人能去的地方";
$MissionDialog[29135,10005]="不错，辛苦阁下了。";

$MissionDialog[29136,10001]="击败枯树魔精，收集狐内丹交给华千骨";
$MissionDialog[29136,10002]="听说枯树魔精已经快修炼成人形了，他们的内丹可是一味好药材啊";
$MissionDialog[29136,10005]="不错，辛苦阁下了。";

$MissionDialog[29137,10001]="前往青丘岭寻找虎牙草交给华千骨";
$MissionDialog[29137,10002]="我需要的药材缺少了虎牙草，我记得在青丘岭一带有很多";
$MissionDialog[29137,10005]="不错，辛苦阁下了。";

$MissionDialog[29138,10001]="前往青丘岭寻找紫萱草交给华千骨";
$MissionDialog[29138,10002]="我需要的药材缺少了紫萱草，我记得在青丘岭一带有很多";
$MissionDialog[29138,10005]="不错，辛苦阁下了。";

$MissionDialog[29139,10001]="击败花魅，收集花根交给华千骨";
$MissionDialog[29139,10002]="我在研究一种新药，正好缺少了花魅妖的根";
$MissionDialog[29139,10005]="不错，辛苦阁下了。";

$MissionDialog[29140,10001]="击败铁鳄，收集铁齿交给鲁匠师";
$MissionDialog[29140,10002]="打造武器的铁不够，听说鳄鱼潭的铁鳄都是铁嘴钢牙，应该有不少铁可用吧";
$MissionDialog[29140,10005]="不错，辛苦阁下了。";

$MissionDialog[29141,10001]="击败变异铁鳄，收集铁内丹交给鲁匠师";
$MissionDialog[29141,10002]="打造一把好武器普通的铁肯定不行，需要铁石心肠的变异铁鳄内丹";
$MissionDialog[29141,10005]="不错，辛苦阁下了。";

$MissionDialog[29142,10001]="前往炼仙炉收集炼仙炉水交给鲁匠师";
$MissionDialog[29142,10002]="这炉火的温度融化不了铁丹，看来需要传说中的炼仙炉之水才能融化";
$MissionDialog[29142,10005]="不错，辛苦阁下了。";

$MissionDialog[29143,10001]="击败变异铁鳄，收集鳄鱼腿交给邢秋";
$MissionDialog[29143,10002]="我杂货商就是什么东西都收，最近缺一些变异铁鳄鱼的腿";
$MissionDialog[29143,10005]="不错，辛苦阁下了。";

$MissionDialog[29144,10001]="击败摄魂沙妖，获取沙石铠甲交给邢秋";
$MissionDialog[29144,10002]="我杂货商就是什么东西都收，最近缺一些沙石铠甲";
$MissionDialog[29144,10005]="不错，辛苦阁下了。";

$MissionDialog[29145,10001]="击败吸血妖蚊，收集蚊子翅膀交给邢秋";
$MissionDialog[29145,10002]="我杂货商就是什么东西都收，最近缺一些吸血妖蚊的翅膀";
$MissionDialog[29145,10005]="不错，辛苦阁下了。";

$MissionDialog[29146,10001]="前往路口搬运布匹交给邢月";
$MissionDialog[29146,10002]="运布匹的马车坏掉，只能停靠在路边，我们的人手又不足，这可怎么办呢";
$MissionDialog[29146,10005]="不错，辛苦阁下了。";

$MissionDialog[29147,300]="都......都准备好了";
$MissionDialog[29147,10001]="寻找砍柴人祝枝山";
$MissionDialog[29147,10002]="柴火用完了，没有柴可怎么做饭呢";
$MissionDialog[29147,10005]="不错，辛苦阁下了。";

$MissionDialog[29148,10001]="前往乐民村池塘采摘莲藕交给婉儿";
$MissionDialog[29148,10002]="晚上吃什么，问题并不难，因为什么都没有了，只能去池塘挖些莲藕";
$MissionDialog[29148,10005]="不错，辛苦阁下了。";

$MissionDialog[29149,10001]="击败花魅，收集花瓣交给婉儿";
$MissionDialog[29149,10002]="听说花魅妖的花瓣是上好的作料，拿来做饭不仅味道好，还能增进修为呢";
$MissionDialog[29149,10005]="不错，辛苦阁下了。";

$MissionDialog[29150,300]="我可都记得呢，特意留了几条大鱼";
$MissionDialog[29150,10001]="寻找渔翁梁隐打招呼";
$MissionDialog[29150,10002]="听说梁叔又是满载而归，帮我跟他说一声，记得给我留几条大鱼";
$MissionDialog[29150,10005]="不错，辛苦阁下了。";

//------------------------------------------------------------------------
$MissionDialog[29201,10001]="击败寒冰傀儡";
$MissionDialog[29201,10002]="前往昆仑的路口总有一些寒冰傀儡袭击路人，得把他们除掉才好。";
$MissionDialog[29201,10005]="不错，辛苦阁下了。";

$MissionDialog[29202,10001]="击败苍雪巫师";
$MissionDialog[29202,10002]="苍雪营的巫师不知道总在密谋写什么，需要将他们剿灭";
$MissionDialog[29202,10005]="不错，辛苦阁下了。";

$MissionDialog[29203,10001]="击败苍山野人";
$MissionDialog[29203,10002]="雪松平原的野人变得非常暴躁，需要前去处理一下";
$MissionDialog[29203,10005]="不错，辛苦阁下了。";

$MissionDialog[29204,10001]="击败雪豹";
$MissionDialog[29204,10002]="雪松平原的雪豹变得非常暴躁，需要前去处理一下";
$MissionDialog[29204,10005]="不错，辛苦阁下了。";

$MissionDialog[29205,10001]="击败剑奴";
$MissionDialog[29205,10002]="剑奴太多的话，魔剑会冲破封印，必须要铲除才行";
$MissionDialog[29205,10005]="不错，辛苦阁下了。";

$MissionDialog[29206,10001]="击败寒冰傀儡,获取傀儡之印";
$MissionDialog[29206,10002]="巫师是怎么炼制傀儡的？得弄一些傀儡之印研究一下";
$MissionDialog[29206,10005]="不错，辛苦阁下了。";

$MissionDialog[29207,10001]="击败寒冰傀儡,获取傀儡之爪";
$MissionDialog[29207,10002]="傀儡之爪也是制作武器的好材料，能多弄一些过来就好";
$MissionDialog[29207,10005]="不错，辛苦阁下了。";

$MissionDialog[29208,10001]="击败寒冰傀儡,获取傀儡之角";
$MissionDialog[29208,10002]="制作新饰品刚好需要一些傀儡之角";
$MissionDialog[29208,10005]="不错，辛苦阁下了。";

$MissionDialog[29209,10001]="击败寒冰傀儡,获取傀儡之牙";
$MissionDialog[29209,10002]="听说傀儡的牙齿可以做成护符，会保佑你的呢";
$MissionDialog[29209,10005]="不错，辛苦阁下了。";

$MissionDialog[29210,10001]="击败寒冰傀儡,获取傀儡之眼";
$MissionDialog[29210,10002]="傀儡的眼睛就像红宝石一样闪闪发光，真的好像要";
$MissionDialog[29210,10005]="不错，辛苦阁下了。";

$MissionDialog[29211,10001]="击败苍雪巫师，获取巫师杖";
$MissionDialog[29211,10002]="巫师的法杖真不简单呢，应该抢过来一些好好研究";
$MissionDialog[29211,10005]="不错，辛苦阁下了。";

$MissionDialog[29212,10001]="击败苍雪巫师，获取巫师精魄";
$MissionDialog[29212,10002]="把巫师精魄加入到武器中，能增加很大的威力呢";
$MissionDialog[29212,10005]="不错，辛苦阁下了。";

$MissionDialog[29213,10001]="击败苍雪巫师，获取乾坤囊";
$MissionDialog[29213,10002]="听说巫师的乾坤囊里面有好的小物件，可以用来做饰品呢";
$MissionDialog[29213,10005]="不错，辛苦阁下了。";

$MissionDialog[29214,10001]="击败苍雪巫师，获取巫师印";
$MissionDialog[29214,10002]="不真的巫师印是否跟傀儡印一样呢，得仔细瞧一瞧";
$MissionDialog[29214,10005]="不错，辛苦阁下了。";

$MissionDialog[29215,10001]="击败苍山野人，获取野人头蛮";
$MissionDialog[29215,10002]="野人的头蛮刚好对我很有用";
$MissionDialog[29215,10005]="不错，辛苦阁下了。";

$MissionDialog[29216,10001]="击败苍山野人，获取野人毛发";
$MissionDialog[29216,10002]="野人不穿衣服也不怕冷，毛发应该很保暖吧";
$MissionDialog[29216,10005]="不错，辛苦阁下了。";

$MissionDialog[29217,10001]="击败雪豹，获取雪豹内丹";
$MissionDialog[29217,10002]="雪豹的内丹可是一味很好的药材";
$MissionDialog[29217,10005]="不错，辛苦阁下了。";

$MissionDialog[29218,10001]="击败雪豹，获取雪豹之尾";
$MissionDialog[29218,10002]="雪豹的尾巴毛色很不错呢，可以做好看的衣服穿";
$MissionDialog[29218,10005]="不错，辛苦阁下了。";

$MissionDialog[29219,10001]="击败雪豹，获取雪豹獠牙";
$MissionDialog[29219,10002]="锋利的雪豹獠牙，用来做武器最好不过了";
$MissionDialog[29219,10005]="不错，辛苦阁下了。";

$MissionDialog[29220,10001]="击败雪豹，获取雪豹之角";
$MissionDialog[29220,10002]="雪豹坚硬的角，也是很有杀伤力的，可以制作长枪";
$MissionDialog[29220,10005]="不错，辛苦阁下了。";

$MissionDialog[29221,10001]="击败雪豹，获取雪豹毛皮";
$MissionDialog[29221,10002]="要是用雪豹的毛皮做衣服应该跟保暖吧";
$MissionDialog[29221,10005]="不错，辛苦阁下了。";

$MissionDialog[29222,10001]="击败雪豹，获取雪豹之爪";
$MissionDialog[29222,10002]="爪子虽然锋利，可是用来泡制药酒，功效也是很不错的";
$MissionDialog[29222,10005]="不错，辛苦阁下了。";

$MissionDialog[29223,10001]="击败雪豹，获取雪豹肉块";
$MissionDialog[29223,10002]="这么天寒地冻的地方，想吃肉的话只有雪豹的肉块了";
$MissionDialog[29223,10005]="不错，辛苦阁下了。";

$MissionDialog[29224,10001]="击败剑奴，获取剑奴精魂";
$MissionDialog[29224,10002]="武器中加入剑奴精魄，能使威力增长几倍";
$MissionDialog[29224,10005]="不错，辛苦阁下了。";

$MissionDialog[29225,10001]="击败剑奴，获取灵之剑气";
$MissionDialog[29225,10002]="剑奴都是剑气所化，收集一些灵之剑气也是大有好处";
$MissionDialog[29225,10005]="不错，辛苦阁下了。";

$MissionDialog[29226,10001]="击败剑奴，获取剑奴魂晶";
$MissionDialog[29226,10002]="剑奴的精魂凝结成了晶体，不方便直接使用，不过正好我喜欢研究研究";
$MissionDialog[29226,10005]="不错，辛苦阁下了。";

$MissionDialog[29227,10001]="采集寒冰草";
$MissionDialog[29227,10002]="制作冰心丸的草药不够了，早去帮我采摘一些来";
$MissionDialog[29227,10005]="不错，辛苦阁下了。";

$MissionDialog[29228,10001]="搬运木箱";
$MissionDialog[29228,10002]="还有许多食物储存在外面的木箱里，能帮我搬回来吗";
$MissionDialog[29228,10005]="不错，辛苦阁下了。";

$MissionDialog[29229,10001]="收集桥上的刺骨寒霜";
$MissionDialog[29229,10002]="去桥上把刺骨寒霜收集起来，说不定有很大的用处呢";
$MissionDialog[29229,10005]="不错，辛苦阁下了。";

$MissionDialog[29230,10001]="采摘岩松叶";
$MissionDialog[29230,10002]="长在悬崖边上的岩松叶子有奇特的功效，能摘一些来就好";
$MissionDialog[29230,10005]="不错，辛苦阁下了。";

$MissionDialog[29231,10001]="采摘雪松果";
$MissionDialog[29231,10002]="雪松果也是很好的食材，去帮我摘一下来";
$MissionDialog[29231,10005]="不错，辛苦阁下了。";

$MissionDialog[29232,10001]="开采灵晶";
$MissionDialog[29232,10002]="灵晶看起来晶莹剔透的，用来做首饰一定好看";
$MissionDialog[29232,10005]="不错，辛苦阁下了。";

$MissionDialog[29233,10001]="采集冰莲花";
$MissionDialog[29233,10002]="冰晶开出来的莲花，镶嵌在饰品上有很好的效果呦";
$MissionDialog[29233,10005]="不错，辛苦阁下了。";

$MissionDialog[29234,10001]="收集清冷液";
$MissionDialog[29234,10002]="使用清冷液的话制作武器效果更好，想办法去弄一些来";
$MissionDialog[29234,10005]="不错，辛苦阁下了。";

$MissionDialog[29235,10001]="搬运柴火";
$MissionDialog[29235,10002]="帮我搬一些柴火吧，独自守在这里也怪冷的";
$MissionDialog[29235,10005]="不错，辛苦阁下了。";

$MissionDialog[29236,10001]="解救被困的修士";
$MissionDialog[29236,10002]="又有修士被巫师抓走了，你能把他们救回来吗";
$MissionDialog[29236,10005]="不错，辛苦阁下了。";

$MissionDialog[29237,10001]="检查封剑台";
$MissionDialog[29237,10002]="去帮我检查一下封剑台有什么异样";
$MissionDialog[29237,10005]="不错，辛苦阁下了。";

$MissionDialog[29238,10001]="破坏苍雪营的笼子";
$MissionDialog[29238,10002]="需要前去把苍雪营的笼子破坏掉";
$MissionDialog[29238,10005]="不错，辛苦阁下了。";

$MissionDialog[29239,10001]="采集雪绒草";
$MissionDialog[29239,10002]="雪绒草看起来没什么特别，但是有很好的驱寒作用";
$MissionDialog[29239,10005]="不错，辛苦阁下了。";

$MissionDialog[29240,10001]="查看封剑印记";
$MissionDialog[29240,10002]="封剑印记要是被破坏了，魔剑就要冲破封印，赶紧去查看一下";
$MissionDialog[29240,10005]="不错，辛苦阁下了。";

$MissionDialog[29241,10001]="采集寒葵草";
$MissionDialog[29241,10002]="制作冰心丸也是需要寒葵草，快去帮我采一些回来吧";
$MissionDialog[29241,10005]="不错，辛苦阁下了。";

$MissionDialog[29242,10001]="找回遗失的护符";
$MissionDialog[29242,10002]="慕容姑娘送我的护符丢了，你能帮我找回来吗";
$MissionDialog[29242,10005]="不错，辛苦阁下了。";

$MissionDialog[29243,10001]="查看白虎台";
$MissionDialog[29243,10002]="白虎台被人推到了，去查看一下是何人所为";
$MissionDialog[29243,10005]="不错，辛苦阁下了。";

$MissionDialog[29244,10001]="收集原石";
$MissionDialog[29244,10002]="听说慕容姑娘喜欢研究奇怪的石头，去找一些来给她吧";
$MissionDialog[29244,10005]="不错，辛苦阁下了。";

$MissionDialog[29245,300]="多谢了，真是雪中送炭呀";
$MissionDialog[29245,10001]="寻找金翔飞";
$MissionDialog[29245,10002]="天寒地冻的金飞翔一个人在外，给他送点取暖的碳火吧";
$MissionDialog[29245,10005]="不错，辛苦阁下了。";

$MissionDialog[29246,300]="我又迷路了，谢谢你来带我回家";
$MissionDialog[29246,10001]="寻找万佩云";
$MissionDialog[29246,10002]="佩云姑娘又走丢了，你能去把她找回来吗？";
$MissionDialog[29246,10005]="不错，辛苦阁下了。";

$MissionDialog[29247,300]="苍雪营的巫师可不好对付呀";
$MissionDialog[29247,10001]="寻找赵璟";
$MissionDialog[29247,10002]="找赵璟询问一下苍雪营最近的情况如何";
$MissionDialog[29247,10005]="不错，辛苦阁下了。";

$MissionDialog[29248,300]="雪松平原可是一点都不平静啊";
$MissionDialog[29248,10001]="寻找万宏光";
$MissionDialog[29248,10002]="找万宏光询问雪松平原最近情况如何";
$MissionDialog[29248,10005]="不错，辛苦阁下了。";

$MissionDialog[29249,300]="我早就看出来了，只是假装不知道，你要帮我保密哟";
$MissionDialog[29249,10001]="寻找慕容雅清";
$MissionDialog[29249,10002]="万宏光喜欢慕容姑娘很久了，希望你能把他传达爱意";
$MissionDialog[29249,10005]="不错，辛苦阁下了。";

$MissionDialog[29250,300]="有我在这里守着，绝对不会出什么问题";
$MissionDialog[29250,10001]="寻找万志新";
$MissionDialog[29250,10002]="找万志新询问封剑台最近情况如何";
$MissionDialog[29250,10005]="不错，辛苦阁下了。";

//------------------------------------------------------------------------
$MissionDialog[ 29301, 10001 ]="击败扭曲树精";
$MissionDialog[ 29301, 10002 ]="这树精在必经之路上拦住去路，让人通行很不方便";
$MissionDialog[ 29301, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29302, 10001 ]="击败功夫熊猫";
$MissionDialog[ 29302, 10002 ]="熊猫族人在此霸占翠竹林，蛮狠不讲理，需要去教训一下才行";
$MissionDialog[ 29302, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29303, 10001 ]="击败碧毒蟾蜍";
$MissionDialog[ 29303, 10002 ]="这些铲除含有剧毒，再不除去一些，经常会有人中毒";
$MissionDialog[ 29303, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29304, 10001 ]="击败噬灵魔花";
$MissionDialog[ 29304, 10002 ]="再不除掉这些噬灵魔花，附近的灵气都要被吞噬完了";
$MissionDialog[ 29304, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29305, 10001 ]="击败木灵兽";
$MissionDialog[ 29305, 10002 ]="木灵兽又来偷喝灵泉，得把他们赶跑才行";
$MissionDialog[ 29305, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29306, 10001 ]="击败变异海鬣";
$MissionDialog[ 29306, 10002 ]="这些海鬣变异了，经常来到海滩上，得把他们赶回去";
$MissionDialog[ 29306, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29307, 10001 ]="击败未成形的噬灵魔花";
$MissionDialog[ 29307, 10002 ]="要赶在魔花成形之前就铲除干净最好";
$MissionDialog[ 29307, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29308, 10001 ]="击败扭曲树精,树精藤条";
$MissionDialog[ 29308, 10002 ]="听说树精的藤条可以伸缩，那这个的用途可就非常大了";
$MissionDialog[ 29308, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29309, 10001 ]="击败扭曲树精,树精灵果";
$MissionDialog[ 29309, 10002 ]="树精的力量来源与手上的灵果，要是能摘一些来就能做成增进功力的食物了";
$MissionDialog[ 29309, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29310, 10001 ]="击败功夫熊猫，获取熊猫族刀";
$MissionDialog[ 29310, 10002 ]="听说熊猫族人左手持刀右手持斧，甚是凶狠，要是能抢夺一些刀来就好了";
$MissionDialog[ 29310, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29311, 10001 ]="击败功夫熊猫，获取熊猫族铠甲";
$MissionDialog[ 29311, 10002 ]="熊猫族人的铠甲看似简单，防御力却惊人，很想夺一些来研究研究";
$MissionDialog[ 29311, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29312, 10001 ]="击败功夫熊猫，获取熊猫族斧";
$MissionDialog[ 29312, 10002 ]="听说熊猫族人左手持刀右手持斧，甚是凶狠，要是能抢夺一些斧来就好了";
$MissionDialog[ 29312, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29313, 10001 ]="击败碧毒蟾蜍，获取蟾蜍皮";
$MissionDialog[ 29313, 10002 ]="蟾蜍的毒在于皮，药用也在于皮，药师能弄些蟾蜍皮来就好了";
$MissionDialog[ 29313, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29314, 10001 ]="击败碧毒蟾蜍，获取蟾蜍腿";
$MissionDialog[ 29314, 10002 ]="蟾蜍剥皮之后的肉也是可以食用的，特别是腿上的肉更为鲜嫩";
$MissionDialog[ 29314, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29315, 10001 ]="击败碧毒蟾蜍，获取蟾蜍气囊";
$MissionDialog[ 29315, 10002 ]="蟾蜍鼓起来的气囊也是大有乾坤，收集起来有大用处呢";
$MissionDialog[ 29315, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29316, 10001 ]="击败噬灵魔花，获取噬灵花根";
$MissionDialog[ 29316, 10002 ]="噬灵魔花以灵为食，全身皆可为药，去收集一些噬灵花根吧";
$MissionDialog[ 29316, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29317, 10001 ]="击败噬灵魔花，获取噬灵花瓣";
$MissionDialog[ 29317, 10002 ]="噬灵魔花以灵为食，全身皆可为药，去收集一些噬灵花瓣吧";
$MissionDialog[ 29317, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29318, 10001 ]="击败噬灵魔花，获取噬灵花蕊";
$MissionDialog[ 29318, 10002 ]="噬灵魔花以灵为食，全身皆可为药，去收集一些噬灵花蕊吧";
$MissionDialog[ 29318, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29319, 10001 ]="击败噬灵魔花，获取噬灵花叶";
$MissionDialog[ 29319, 10002 ]="噬灵魔花以灵为食，全身皆可为药，去收集一些噬灵花叶吧";
$MissionDialog[ 29319, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29320, 10001 ]="击败木灵兽，木灵兽尾巴";
$MissionDialog[ 29320, 10002 ]="木灵兽为木兽结合体，尾巴缺如此灵活，真是做饰品的好材料";
$MissionDialog[ 29320, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29321, 10001 ]="击败木灵兽，木灵兽之爪";
$MissionDialog[ 29321, 10002 ]="木灵兽为木兽结合体，爪子还是那么锋利，真是做武器的好材料";
$MissionDialog[ 29321, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29322, 10001 ]="击败木灵兽，木灵兽之牙";
$MissionDialog[ 29322, 10002 ]="木灵兽为木兽结合体，牙齿还是那么坚硬，真是做武器的好材料";
$MissionDialog[ 29322, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29323, 10001 ]="击败变异海鬣，获取海鬣之壳";
$MissionDialog[ 29323, 10002 ]="变异海鬣坚硬的外壳，用来做防具最好不过了";
$MissionDialog[ 29323, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29324, 10001 ]="击败变异海鬣，海鬣之爪";
$MissionDialog[ 29324, 10002 ]="海鬣锋利的爪子，用来捕鱼最方便了";
$MissionDialog[ 29324, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29325, 10001 ]="击败变异海鬣，海鬣之鳍";
$MissionDialog[ 29325, 10002 ]="要是能有海鬣之鳍的话，在海底移动会很快哦";
$MissionDialog[ 29325, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29326, 10001 ]="采集灵竹";
$MissionDialog[ 29326, 10002 ]="这里的灵竹不止用做药，还有其他很大的用处，再去帮忙采集一些来吧";
$MissionDialog[ 29326, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29327, 10001 ]="采集竹笋";
$MissionDialog[ 29327, 10002 ]="新鲜的竹笋可是非常不错的食材";
$MissionDialog[ 29327, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29328, 10001 ]="采集荷花";
$MissionDialog[ 29328, 10002 ]="长在竹林池中的荷花灵气非常茂盛呢";
$MissionDialog[ 29328, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29329, 10001 ]="收集露水";
$MissionDialog[ 29329, 10002 ]="花丛中的露水可是一味很好的药引";
$MissionDialog[ 29329, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29330, 10001 ]="荷花池水";
$MissionDialog[ 29330, 10002 ]="若是没有灵泉，这荷花池中的水也比普通的溪水要好";
$MissionDialog[ 29330, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29331, 10001 ]="采集竹叶";
$MissionDialog[ 29331, 10002 ]="竹叶看似没有什么作用，其实也可以用来做饰品的哦";
$MissionDialog[ 29331, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29332, 10001 ]="收集灵泉";
$MissionDialog[ 29332, 10002 ]="食物中加入一些灵泉，就会变得美味无比了";
$MissionDialog[ 29332, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29333, 10001 ]="采集蘑菇";
$MissionDialog[ 29333, 10002 ]="蘑菇虽然可以为药，但是也可以作为烹饪食材的";
$MissionDialog[ 29333, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29334, 10001 ]="采集仙人掌";
$MissionDialog[ 29334, 10002 ]="收集一些长在沙滩上仙人掌来，对我还是有很大的用处";
$MissionDialog[ 29334, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29335, 10001 ]="采集满天星";
$MissionDialog[ 29335, 10002 ]="采集一些满天星，可以做成漂亮的花束";
$MissionDialog[ 29335, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29336, 10001 ]="采集枯草";
$MissionDialog[ 29336, 10002 ]="收集一些枯草来，对我还是有很大的用处的";
$MissionDialog[ 29336, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29337, 10001 ]="修理水轮车";
$MissionDialog[ 29337, 10002 ]="用来浇灌的水轮车坏了，能帮我去修理一下吗";
$MissionDialog[ 29337, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29338, 10001 ]="研究彩虹桥";
$MissionDialog[ 29338, 10002 ]="这里的彩虹居然可以才踩上去，是何原因，可否去研究研究";
$MissionDialog[ 29338, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29339, 10001 ]="采集椰子";
$MissionDialog[ 29339, 10002 ]="沙滩上的椰子可是非常美味的";
$MissionDialog[ 29339, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29340, 10001 ]="采集多肉植物";
$MissionDialog[ 29340, 10002 ]="收集一些长在沙滩上的多肉植物，我可是有很大的用处";
$MissionDialog[ 29340, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29341, 10001 ]="收集溪水";
$MissionDialog[ 29341, 10002 ]="铸造武器还需要一些溪水来淬火";
$MissionDialog[ 29341, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29342, 10001 ]="固定竹筏";
$MissionDialog[ 29342, 10002 ]="停靠在边上的竹筏快被冲走了，帮我去把它绑紧";
$MissionDialog[ 29342, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29343, 10001 ]="检查炼丹炉";
$MissionDialog[ 29343, 10002 ]="我的炼丹炉里的火不知道熄灭了没有，替我去检查一下吧";
$MissionDialog[ 29343, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29344, 10001 ]="采集香芋";
$MissionDialog[ 29344, 10002 ]="香芋可是种在地里面的哦，想要吃的话需要从土里翻出来";
$MissionDialog[ 29344, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29345, 10001 ]="铲除杂草";
$MissionDialog[ 29345, 10002 ]="种植香芋的地里出现了许多杂草，麻烦帮我除去一些杂草吧";
$MissionDialog[ 29345, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29346, 300 ]="最近我这里可闲了，什么事情都没有";
$MissionDialog[ 29346, 10001 ]="对话小玲珑";
$MissionDialog[ 29346, 10002 ]="前往询问小玲珑有什么需要帮忙的";
$MissionDialog[ 29346, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29347, 300 ]="深海太过危险，没有实力的人我不会告诉他的";
$MissionDialog[ 29347, 10001 ]="对话雪馨";
$MissionDialog[ 29347, 10002 ]="前往询问雪馨进入深海迷宫的入口";
$MissionDialog[ 29347, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29348, 300 ]="需要的药材我都收集好了，马上就送过去";
$MissionDialog[ 29348, 10001 ]="对话张平凡";
$MissionDialog[ 29348, 10002 ]="前往询问张平凡药材是否收集完成";
$MissionDialog[ 29348, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29349, 300 ]="有我在这里看守，不会让灵泉出问题的";
$MissionDialog[ 29349, 10001 ]="对话可儿";
$MissionDialog[ 29349, 10002 ]="前往询问可儿灵泉是否有异样";
$MissionDialog[ 29349, 10005 ]="不错，辛苦阁下了。";

$MissionDialog[ 29350, 300 ]="这里的野兽吸收过多的草木精华，才会变成这样木兽结合体";
$MissionDialog[ 29350, 10001 ]="对话可儿";
$MissionDialog[ 29350, 10002 ]="前往询问可儿木灵兽原因";
$MissionDialog[ 29250, 10005 ]="不错，辛苦阁下了。";

//------------------------------------------------------

function MissionXuanShangJiXiongDialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 300:	return "<t>" @ $MissionDialog[%Mid,%Tid] @ "</t><b/>";
		case 10001:	return "<t>" @ $MissionDialog[%Mid,%Tid] @ "</t><b/>";
		case 10002:	return "<t>" @ $MissionDialog[%Mid,%Tid] @ "</t><b/>";
		case 10005:	return "<t>" @ $MissionDialog[%Mid,%Tid] @ "</t><b/>";
		case 910:
			if (%Player.IsAcceptedMission(%Mid))
			{
				%Begin = 4025;
				%End = 4029;
			}
			else
			{
				%Mapid = GetZoneID();
				%Begin = $XuanShangJiXiong[%MapID,0];
				%End = $XuanShangJiXiong[%MapID,9];
			}
			for (%i = %Begin; %i <= %End; %i++)
			{
				%MidID = GetAct(%Player,%i,0) + 29000;
				if (%MidID == %Mid)
				{
					%CoLor =  GetAct(%Player,%i,1);
					break;
				}
			}
			%MissionData_Exp = GetMissionData(%Mid,$Mission_Data_OtherRecordA);
			switch (%CoLor)
			{
				case 1:%ExpBeiShu = 1;
				case 2:%ExpBeiShu = 1.3;
				case 3:%ExpBeiShu = 1.8;
				case 4:%ExpBeiShu = 2.8;
				case 5:%ExpBeiShu = 4;
				case 6:%ExpBeiShu = 5;
			}
			%Exp = %MissionData_Exp * %ExpBeiShu;
			%Exp = mfloor(%Exp);
			%ShowNumber = %Mid%1000;
			if (%CoLor >= 2)
			{
				%MapID = GetZoneID();
				%Player.ClearMissionItem(%ShowNumber);	//清除之前的物品显示
				for (%i = 1; %i <=99; %i++)
				{
					//echo( "$XuanShangJiXiongItem[ " @ %MapID @ "," @ %CoLor @ "," @  %i @ " ]====" @ $XuanShangJiXiongItem[ %MapID, %CoLor, %i ] );
					if ($XuanShangJiXiongItem[%MapID,%CoLor,%i] $= "")
						break;
					%ItemID = GetWord($XuanShangJiXiongItem[%MapID,%CoLor,%i],0);
					%ItemNum = GetWord($XuanShangJiXiongItem[%MapID,%CoLor,%i],2);
					%Player.AddItemToMission(%ShowNumber,1,%ItemID,%ItemNum);
				}
			}


			%Txt = "<t>本任务奖励倍数： </t>" @ $Get_Dialog_GeShi[31409] @ %ExpBeiShu @ "</t><b/>";
			%Exp = $Get_Dialog_GeShi[31403] @ "经验奖励：</t>" @ %Exp @ "<b/>";
			if (%CoLor >= 2)
				%Item = $Get_Dialog_GeShi[31403] @ "有几率获得以下物品中的一种：</t><b/>" @ GetFixedMissionItemText(%ShowNumber);
			//echo( "%Item ===" @ %Item );
			return $Get_Dialog_GeShi[31401] @ %Txt @ %Exp @ %Item @ "</t>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}

function Mission29999Dialog(%Npc,%Player,%Mid,%Tid)
{
	switch (%Tid)
	{
		case 10001:	return "<t>杀怪</t><b/>";
		case 10002:	return "<t>杀怪</t><b/>";
		case 10005:	return "<t>杀怪</t><b/>";
	}
	if (%Tid <= 20000 || %Tid >= 40000)
		return "Mission" @ %Mid @ "Dialog == 错误 Npc 【" @ %Npc @ "】Player【" @ %Player @ "】Mid【" @ %Mid @ "】Tid【" @ %Tid @ "】";
	else
		return "";
}
//■■■■■■■■■■■■■■■【悬赏缉凶】任务对话■■■■■■■■■■■■■■■■