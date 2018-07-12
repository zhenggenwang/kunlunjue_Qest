//=============================================================================
// 文档说明:通讯脚本
// 创建时间:2017-12-01
// 创建人: Irelia

// 修改人: 
// 修改时间: 
//=============================================================================

//■■■■■■■■■■■客户端通讯脚本■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■确认对话框后弹出■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■发送超长字符串■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■客户端通讯脚本■■■■■■■■■■■■■■■■■■■
//ClientOnSptAction( %type, %SubType )
function OnSptActionEvent_S(%Player,%type,%SubType)
{
	//echo( "%type===" @ %type @ "   %SubType===" @ %SubType );
	switch (%type)
	{
		case 1://月光宝盒刷新道具数量记录
			if (GetBuildString() $= "Debug")
				%Player.YueGuangBaoHeTiemNum = %SubType;
		case 2:
			if (GetBuildString() $= "Debug")
				if (GetNpcData(%SubType,0) !$= "")
				{
					%CopyMapID = %Player.GetLayerId();
					if (%SubType >= 499100201 && %SubType <= 499999999)
					{
						%StartPosX = GetWord(%Player.GetPosition(),0);
						%StartPosY = GetWord(%Player.GetPosition(),1);
						%StartPosZ = GetWord(%Player.GetPosition(),2);
						for (%i=0; %i< %Player.YueGuangBaoHeTiemNum; %i++)
						{
							%NpcID = %SubType + %i;
							%PosX = %StartPosX + %i *5;
							%Pos = %PosX @ " " @ %StartPosY @ " " @ %StartPosZ;
							SpNewNpc(0,%NpcID,%Pos,0);
						}
					}
					else
					{
						for (%i=0; %i< %Player.YueGuangBaoHeTiemNum; %i++)
							SpNewNpc3(%Player,%SubType,0,%CopyMapID,0,"1 1 1");
					}
					%Player.YueGuangBaoHeTiemNum = 0;
				}

		case 3:
			if (GetBuildString() $= "Debug")
				if (GetItemData(%SubType,0) !$= "")
				{
					%Player.PutItem(%SubType,%Player.YueGuangBaoHeTiemNum);
					%Player.AddItem(1,108020208);

					%Player.YueGuangBaoHeTiemNum = 0;
				}

		case 4:
			if (GetBuildString() $= "Debug")
				if (GetCollectionObjectname(%SubType) !$= "")
				{
					%CopyMapID = %Player.GetLayerId();

					for (%i=0; %i< %Player.YueGuangBaoHeTiemNum; %i++)
						SpNewCj2(%Player,%SubType,0,%CopyMapID,0,"1 1 1");

					%Player.YueGuangBaoHeTiemNum = 0;
				}
		case 5:
			if (GetBuildString() $= "Debug")
				if (GetMissionData(%SubType,$Mission_Data_Mid) !$= "")
				{
					%Mid = %SubType;
					%Player.SetMission(%Mid,0);
					AddMissionAccepted(%Player,%Conv,%Mid);
					MoonLightBaoHe_AccecpMis_GetItem(%Player,%Mid);	//判断接任务时是否需要给予物品
				}
		case 6:
			if (GetBuildString() $= "Debug")
				if (GetPetData(%SubType,0) !$= "")
					GeneratePetInfo(%Player.GetPlayerID(),%SubType,1,2,0,1);//给予玩家灵兽
		case 7://点击复活按钮触发
			//echo("%Subtype ==" @ %Subtype);
			//39902	1	回复	skill/307.png	回复100点HP和MP，最高叠加10000层
			//39902	2	回复	skill/307.png	回复1%HP和MP，最高叠加100层
			//唐币复活次数记录
			%Activity = 2209;
			%ActivityA = GetWord(%Player.GetActivity(%Activity),0);
			%ActivityB = GetWord(%Player.GetActivity(%Activity),1);
			//%ActivityA = ( %ActivityA == 9 ) ? %ActivityA : %ActivityA + 1;

			switch (%Subtype)
			{
				case 1://元宝复活
					%Money =  FuHuoNeedMoney_Expend(%Player,0);
					if (%Player.GetMoney(1) < %Money)
					{
						Message_Caution_Hint(%Player,"您的元宝不足，无法使用该复活。");
						return;
					}
					//复活玩家
					if (%Player.GetDamageState() $= "Disabled")
					{
						//扣除元宝
						%Player.ReduceMoney(%Money,1,5,1014);
						//死亡复活
						%Player.SetDamageState(Enabled);
						//添加回血状态
						%Player.AddBuff(399020200,%Player,100);
						//唐币复活次数记录
						%ActivityB++;
						//复活保护
						%Player.AddBuff(399010001,%Player,1);
					}
				case 2://金币复活
					if (!HasBit(GetTriggerData(%Player.GetTriggerId(),11),27))
					{
						//获取玩家Player
						%Money =  FuHuoNeedMoney_Expend(%Player,1);
						if (%Player.GetMoney(2) < %Money)
						{
							Message_Caution_Hint(%Player,"您的金币不足，无法使用该复活。");
							return;
						}
					}
					//复活玩家
					if (%Player.GetDamageState() $= "Disabled")
					{
						//死亡复活
						%Player.SetDamageState(Enabled);
						//添加回血状态
						%Player.AddBuff(399020200,%Player,100);
						if (%Money > 0)
							%Player.ReduceMoney(%Money,2,5,1008);
						%ActivityA++;
						%ActivityB++;
						//复活保护
						%Player.AddBuff(399010001,%Player,1);
					}
				default://玩家复活技能复活
					if (%Subtype >= 300 && %Subtype <= 399)
					{
						%SkillLevel = %Subtype%100;
						switch (%SkillLevel)
						{
							case 1:%HP = 100;
							case 2:%HP = 500;
							case 3:%HP = 1000;
							case 4:%HP = 2000;
							case 5:%HP = 5000;
							default:%HP = 10000;
						}

						if (%Player.GetDamageState() $= "Disabled")
						{
							//死亡复活
							%Player.SetDamageState(Enabled);
							//添加回血状态
							%Player.AddBuff(399020001,%Player,%HP/100);
							//复活保护
							%Player.AddBuff(399010001,%Player,1);
						}
					}

			}
			SetAct(%Player,%Activity,%ActivityA,%ActivityB);
		case 8:
			if (GetBuildString() $= "Debug")
			{
				if (GetSubStr(%SubType,0,1) $= "2")
					%Player.AddSkill(%SubType);
				else if (GetSubStr(%SubType,0,1) $= "3")
					%Player.AddBuff(%SubType,%Player,%Player.YueGuangBaoHeTiemNum);
				%Player.YueGuangBaoHeTiemNum = 0;
			}
		case 9:
			//%Player.TransportObject( 0, 0, -3.43812 ,112.837 ,144.857 ); FlyMeToTheMoon( sptgetplayer(50000032), 10100001, 701002601 );FlyMeToTheMoon( sptgetplayer(50000021), 11030001, 700010000 );
			//echo( "一二三四一二三四" @ %Player.GetSex( ) );
			%Random = getrandom( 1, 3 );
			switch ( %Random )
			{
				case 1:%Num = 10100101;
				case 2:%Num = 10100102;
				case 3:%Num = 10100103;
			}
			switch (%Player.GetSex())
			{
				case 1:%MoutID = 701005601;
				case 2:%MoutID = 701002801;
			}
			if (%MoutID > 0)
				FlyMeToTheMoon( %Player, %Num, %MoutID );
		case 10://退出电影模式
			ChangeLogicFloor(%Player,%Player,0);

			cancel(%Player.Schedule[10001]);

			Cancel(%Player.MissionScheduleRecord[10008,1]);
			Cancel(%Player.MissionScheduleRecord[10008,2]);
			Cancel(%Player.MissionScheduleRecord[10008,3]);
			Cancel(%Player.MissionScheduleRecord[10008,4]);
			cancel(%Player.MissIonRecord[10008,1]);
			cancel(%Player.MissIonRecord[10008,2]);
			%Player.MissionNpcRecord[10008,1].safedeleteobject();
			%Player.MissionNpcRecord[10008,2].safedeleteobject();
			%Player.MissionNpcRecord[10008,3].safedeleteobject();
		case 11:
			%Player.SendPlayerString(2,$SL_HuoDong,0);//发送所有活动配置开关
		case 12://客户端通知服务端更新脚本
			if (GetBuildString() $= "Debug")
				u();
		case 13:
			YaBiaoHuoDong_QueReng(%Player,%Player.YaBiaoRecord);
		case 14://聚宝盆
			%Level = %Player.GetLevel();
			%Luck = %Player.getLuck();//获取玩家福缘值
			switch (%Subtype)
			{
				case 0://免费兑换
					%Times = GetAct(%Player,3038,0)%1000;//剩余免费次数
					if (%Times <= 0)
						return;
					if (%Player.isschbuff(2007))
						return;
					%Player.SetSchbuff(2007);
					SetAct(%Player,3038,GetAct(%Player,3038,0) - 1,GetAct(%Player,3038,1) + 1);

					%MoneyMin = (%Level + 50) * 3 * 40;
					%MoneyMax = (%Level * 3 + 80) * 4 * 40;
					%MoneyMin = %MoneyMin + (%MoneyMax - %MoneyMin)*((%Luck / 2000) + mfloor(%Luck / 100)/20);
					%Money = GetRandom(%MoneyMin,%MoneyMax);
				case 1://元宝兑换
					%Times = mfloor(GetAct(%Player,3038,0)/1000);//已经元宝兑换次数
					if (%Times >= GetGodNumForMaxCnt(%Player))
						return;
					if (%Player.GetMoney(1) < $SL_JuBaoPeng_NeedGold[%Times + 1])
						return;
					%Player.ReduceMoney($SL_JuBaoPeng_NeedGold[%Times + 1],1,1,3038);
					SetAct(%Player,3038,GetAct(%Player,3038,0) + 1000,GetAct(%Player,3038,1) + 1);

					%MoneyMin = (%Level + 50) * 3 * 40;
					%MoneyMax = (%Level * 3 + 80) * 4 * 40;
					%MoneyMin = %MoneyMin + (%MoneyMax - %MoneyMin)*((%Luck / 2000) + mfloor(%Luck / 100)/20);
					%Money = GetRandom(%MoneyMin,%MoneyMax);
			}
			//echo( "%MoneyMin====" @ %MoneyMin );
			//echo( "%MoneyMax====" @ %MoneyMax );
			//echo( "%Money====" @ %Money );
			%SendMoney = %Money;

			if (%Times == 3 || %Times == 7)
			{
				%Money = %Money * 2;
				SendOneChatMessage($chatMsg_Person, "<t>恭喜你，本次聚宝盆奖励翻倍！</t>", %Player);
			}
				
			//echo( "%Money====" @ %Money );
			//%Player.Addmoney( %Money, 2, 1, 3038 );
			Schedule(3000,0,"eval",%Player @ ".Addmoney(" @ "\"" @ %Money @ "\"" @ ",2, 1, 3038 ); ");
			if (%Money > 0)
				ServerOnSptAction(%Player.GetPlayerID(),%SendMoney,8);//通讯客户端

			%Player.PlayerAchieveCount(0,24,1,0);//添加成就记录
			//echo( %Player.Getactivity( 3038 ) );
		case 15://处理7天登录好礼
			//echo( "奖励发放=====" @ %Subtype );
			%Act0 = GetAct(%Player,4021,0);
			%Act1 = GetAct(%Player,4021,1);
			if (CheckBit(%Act1,%Subtype) == 1)
				return;
			%Time = $NowServerTime2 - %Act0;
			if (%Time > 6)
				return;
			if (%Player.GetBagEmptyCount() < 1)
				return;
			%Act1 = SetBit(%Act1,%Subtype);
			SetAct(%Player,4021,%Act0,%Act1);
			%Player.PutItem($UpLineParty_QiTianHaoLiItem[%Subtype],1);
			%Player.Additem(1,4021);
		case 16://登录签到和补签
			switch (%SubType)
			{
				case 0://签到
					RecordLonginGame(%Player);
				case 1://补签
					if (%Player.GetMoney(1) >= $QianDaoBuQian)
						QianDaoBuQian(%Player);
					else
					{
						SendOneScreenMessage(1,"元宝不足",%Player);
						SendOneChatMessage($chatMsg_System,"<t>元宝不足，补签失败</t>",%Player);
					}
			}
			ServerOnSptAction(%Player.GetPlayerID(),0,9);//通讯客户端
			SendPlayerStringToClient(%Player, 10);//发送运营活动配置开关
		case 17://领取等级礼包
			%ItemID = GetWord($UpLineLevelGift[%SubType],0);
			%Level = GetWord($UpLineLevelGift[%SubType],1);
			%Src = GetWord($UpLineLevelGift[%SubType],2);
			//echo( "%Src====" @ %Src );
			//echo(GetSrc(%Player,%Src));
			if (%Player.Getlevel() <  %Level)
				return;
			if (GetSrc(%Player,%Src) == 1)
				return;
			SetSrc(%Player,%Src);
			%Player.Putitem(%ItemID,1);
			%Player.Additem(1,17);
			SendOneScreenMessage(1,"领取成功",%Player);
			SendOneChatMessage($chatMsg_System,"<t>领取成功，请打开包裹查看</t>",%Player);
			ServerOnSptAction(%Player.GetPlayerID(),0,10);//通讯客户端
		case 18://领取活跃度礼包
			%NeedHuoYue = $MeiRiLiLian_HuoYueDu[%SubType];
			%HuoYue = GetHuoYueDuRecord(%Player);
			if (%NeedHuoYue > %HuoYue)
				return;
			if (GetSrc(%Player,%SubType + 35) == 1)
				return;
			%Player.Putitem(GetMeiRiLiLianItem(%SubType),1);
			%Player.additem(1,18);
			SetSrc(%Player,%SubType + 35);
			if (%SubType == 4)
				SetStrategyRecord(%Player,$StrategySubBtnSrc[2,0]);//攻略触发记录
			SendOneScreenMessage(1,"领取成功",%Player);
			SendOneChatMessage($chatMsg_System,"<t>领取成功，请打开包裹查看</t>",%Player);
			ServerOnSptAction(%Player.GetPlayerID(),0,11);//通讯客户端
		case 19:
			LingJingWuDao_YuanShenWuDaoStart(%Player);
		case 20:
			//echo( "%SubType===" @ %SubType );
			switch (%SubType)
			{
				case 1://空白时的第一次刷新
					GetTodayXuanShangMission(%Player);
				case 2://每日免费次数刷新
					%Act0 = GetAct(%Player,4090,0)* 1;
					%Act1 = GetAct(%Player,4090,1)* 1;
					if (GetXuanShangJiXiongFreeTimes(%Player) - %Act0 > 0)
					{
						SetAct(%Player,4090,%Act0++,%Act1);
						GetNewXuanShangMission(%Player,2);
					}
				case 3://收费刷新
					if (%Player.GetItemCount($XuanShangJiXiong_ShuaXinNeedItem) >= 1)
					{
						%Player.Putitem($XuanShangJiXiong_ShuaXinNeedItem,-1);
						if (%Player.Additem(1,4090))
						{
							%Act0 = GetAct(%Player,4090,0)* 1;
							%Act1 = GetAct(%Player,4090,1)* 1;
							SetAct(%Player,4090,%Act0,%Act1++);
							GetNewXuanShangMission(%Player,3);
						}
					}
					else
					{
						%Itemname = GetItemData($XuanShangJiXiong_ShuaXinNeedItem,1);
						SendOneScreenMessage(1,%Itemname @ "不足，无法刷新",%Player);
						SendOneChatMessage($chatMsg_System,"<t>" @ %Itemname @ "不足，无法刷新</t>",%Player);
						return;
					}
			}
			ServerOnSptAction(%Player.GetPlayerID(),0,15);//通讯客户端
		case 21://悬赏缉凶接取任务
			XuanShangJiXiongGetMissionToPlayer(%Player,%SubType);
		case 22://帮派功能相关
			AddOrgLevel(%PLayer,%SubType);
		case 23://传送灵脉
			//echo( GetSrc( %Player, 187 ) );
			if (GetSrc(%Player,187) == 0)
				SetSrc(%Player,187);
			//echo( GetSrc( %Player, 187 ) );
			%Player.AI_CastSpell(%PLayer.Getposition(),200190001);
		case 24://蓬莱禁地小电影
			//echo( %Subtype @ "蓬莱禁地小电影" );
			switch (%Subtype)
			{
				case 0:
					XiaoDianYing_ChuFa_001(%Npc,%Player,%State,%Conv,%mid);
				case 1:
					XiaoDianYing_ChuFa_002( %Npc, %Player, %State, %Conv, %mid );
				case 2:
					XiaoDianYing_ChuFa_003(%Npc,%Player,%State,%Conv,%mid);
			}
		case 25://领取首充大礼包
			%Count = %Player.GetBagEmptyCount();//获得包裹栏
			if (%Count < 5)
			{
				SendOneScreenMessage(1,"包裹空间不足",%Player);
				return;
			}
			if (GetIsCanReceiveFirstRecharge(%Player) == 0)
			{
				for (%i = 0; %i <= 4; %i++)
				{
					%ItemID =  GetFirstRechargeGitf(%i);
					%Player.PutItem(%ItemID,1);

					if (%i == 0)
					{
						%GiftName0 =$Get_Dialog_GeShi[31420] @  "[首充大礼包]</t>";
						%GiftName1 =$Get_Dialog_GeShi[60008] @  "[首充大礼包]</t>";

						%ItemName0 = GetItemName(%ItemID,1);
						%ItemName1 = GetItemName(%ItemID,2);

						%Playername0 = GetPlayerZiTiName(%Player,1);
						%Playername1 = GetPlayerZiTiName(%Player,2);

						%Text0 ="<t>好运天降，</t>" @ %Playername0 @ "<t>领取</t>" @ %GiftName0 @ "<t>时，获得了</t>" @ %ItemName0 @ "<t>，真是羡煞众人！</t>";
						%Text1 ="<t>好运天降，</t>" @ %Playername1 @ "<t>领取</t>" @ %GiftName1 @ "<t>时，获得了</t>" @ %ItemName1;
						SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text0 @ "</t>");
						SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text1 @ "</t>", $chatMsg_Type_Normal2);
					}
				}
				if (%player.Additem(1,4097))
				{
					SetIsCanReceiveFirstRecharge(%Player);
					SendOneScreenMessage(1,"领取成功，请查看包裹",%Player);
				}
				ServerOnSptAction(%Player.GetPlayerID(),1,20);//通讯客户端
			}
			else
			{
				SendOneScreenMessage(1,"您不满足领取条件",%Player);
				return;
			}
		case 26://领取每日充值礼包
			//echo( " %Subtype===" @  %Subtype );
			%Subtype = %Subtype -1;
			if (GetIsCanReceiveRechargeDays(%Player,%Subtype) == 0)
			{
				%ItemID = GetFisrtRechargeForDays(%Subtype);
				%Player.PutItem(%ItemID,1);
				if (%player.Additem(1,4095))
				{
					SetIsCanReceiveRechargeDays(%Player,%Subtype);
					//echo( "领取每日充值礼包===="  @ %Player.GetPlayerID( ) );
					SendOneScreenMessage(1,"领取成功，请查看包裹",%Player);
				}
				ServerOnSptAction(%Player.GetPlayerID(),4,20);//通讯客户端
			}
			else
			{
				SendOneScreenMessage(1,"您不满足领取条件",%Player);
				return;
			}
		case 27://领取提取好礼
			//echo("%Subtype===" @ %Subtype);
			if (GetIsCanReceiveRechargeHaoLi(%Player,%Subtype) == 0)
			{
				%ItemList = GetRechargeHaoLiItem(%Subtype);
				//echo("%ItemList===" @ %ItemList);
				for (%i = 0; %i < GetWordCount(%ItemList); %i++)
				{
					%ItemID = GetWord(%ItemList,%i);
					%ItemCount = GetWord(%ItemList,%i++);
					//echo("%ItemID===" @ %ItemID @ "      %ItemCount ===" @ %ItemCount  @ "   " @ GetItemData(%ItemID,1));
					if (%ItemID > 0 &&  %ItemCount > 0)
						%Player.PutItem(%ItemID,%ItemCount);
				}
				if (%player.Additem(1, 144))
				{
					SetIsCanReceiveRechargeHaoLi(%Player,%Subtype);
					SendOneScreenMessage(1,"领取成功，请查看包裹",%Player);
				}
				ServerOnSptAction(%Player.GetPlayerID(),5,20);//通讯客户端
			}
			else
			{
				SendOneScreenMessage(1,"您不满足领取条件",%Player);
				return;
			}
		case 28://回城卷
			ItemTransBackHome_TransPortObject(%Player,%SubType);
		case 29://操作界面的通讯
			switch (%SubType)
			{
				case 8:JianSingZhiYin_10781(%Player,10781);//鉴定指引
				case 11:QiangHuaZhiYin_10761(%Player,10761);//强化指引
			}
		case 30://生活技能学习
			if (%SubType <= 4)
				%Src = 189;
			else
				%Src = 190;
			if (GetSrc(%Player,%Src) == 1)
			{
				SendOneScreenMessage(2,"学习失败，您已接过其他的生活技能任务",%Player);
				return;
			}
			switch (%SubType)
			{

				case 1:%Player.ShowDialogOk(2000000021,21,1);//挖矿	弹出确认框
				case 2:%Player.ShowDialogOk(2000000022,22,1);//伐木
				case 3:%Player.ShowDialogOk(2000000023,23,1);//采药
				case 4:%Player.ShowDialogOk(2000000024,24,1);//钓鱼
				case 5:%Player.ShowDialogOk(2000000025,25,1);//铸造	弹出确认框
				case 6:%Player.ShowDialogOk(2000000026,26,1);//缝纫
				case 7:%Player.ShowDialogOk(2000000027,27,1);//制器
				case 8:%Player.ShowDialogOk(2000000028,28,1);//炼丹
				case 9:%Player.ShowDialogOk(2000000029,29,1);//制符
				case 10:%Player.ShowDialogOk(2000000030,30,1);//烹饪
			}
		case 31://领取阅历的进度礼包
			//echo( "%SubType===" @ %SubType );
			switch (%SubType)
			{
				case 0:%Src = 60;
				case 1:%Src = 61;
				case 2:%Src = 62;
				case 3:%Src = 63;
			}
			echo(GetSrc(%Player,%Src));
			if (GetSrc(%Player,%Src) == 1)
				return;
			//echo( GetStrategyYueLiCount( %Player ) );
			//echo( $GongLueGiftNeedYueLi[ %SubType + 1 ] );
			%YueLi = GetStrategyYueLiCount(%Player);
			if (%YueLi < $GongLueGiftNeedYueLi[%SubType + 1])
				return;

			SetSrc(%Player,%Src);
			%ItemId = $GongLueGiftYueLiItem[%SubType + 1];
			if (%ItemId  > 0)
			{
				%Player.PutItem(%ItemId,1);
				if (%Player.Additem(31,%SubType))
				{
					SendOneScreenMessage(1,"领取历练礼包成功",%Player);
					HelpDirectByIndex(%Player.GetPlayerID(),11);	//通讯客户端
				}
			}
		case 32://领取单项的阅历礼包
			//echo("%SubType===" @ %SubType);
			%SorceA = mfloor(%SubType/10000) - 1;
			%SorceB = %SubType%10000;
			%Src = $StrategySubBtnSrc[%SorceA,%SorceB];
			//echo("%SorceA====" @ %SorceA @ "    %SorceB==" @ %SorceB @ "   %Src===" @ %Src);
			if (GetSrc(%Player,%Src) == 1)
			{
				if (GetSrc(%Player,%Src + 1) == 0)
				{
					SetSrc(%Player,%Src + 1);
					%ItemID = GetWord($StrategySubBtnIte[%SorceA,%SorceB],0);
					%ItemNum = GetWord($StrategySubBtnIte[%SorceA,%SorceB],1);
					if (%ItemId  > 0 && %ItemNum > 0)
					{
						%Player.PutItem(%ItemId,%ItemNum);
						if (%Player.Additem(32,%SubType))
						{
							SendOneScreenMessage(1,"领取历练奖励成功",%Player);
							HelpDirectByIndex(%Player.GetPlayerID(),11);	//通讯客户端
						}
					}
				}
			}
		case 33://攻略界面完成记录可领取标志
			SetStrategyRecord(%Player,%SubType);
		case 34://新手在线奖励
			if (%Player.GetBagEmptyCount() < 1)
			{
				SendOneScreenMessage(1,"包裹空间不足",%Player);
				return;
			}
			%Src = 179 + %SubType;
			if (CanGetStateOnlineReward(%Player,%SubType) == 1)
			{
				%ItemID = GetWord(GetStateOnlineReward(%SubType),0);
				%ItemNum = GetWord(GetStateOnlineReward(%SubType),1);
				%Player.PutItem(%ItemID,%ItemNum);
				if (%Player.Additem(1,%Src))
					SetSrc(%Player,%Src);
			}
		case 35://趣味答题
			%RanKing = %Player.getAnswerRank();//排名
			%Sorce = %Player.getAnswerPoint();//获取分数
			if (%Sorce <= 0)
			{
				SendOneScreenMessage(2,"您已领取过奖励或者没有答题积分",%Player);
				SendOneChatMessage($chatMsg_System,"<t>领取失败，您已领取过奖励或者没有答题积分</t>",%Player);
				return;
			}
			SendOneScreenMessage(2,"领取奖励成功",%Player);
			SendOneChatMessage($chatMsg_System,"<t>成功领取趣味答题奖励。</t>",%Player);
			
			%Player.SetAnswerPoint(0);//设置分数

			AddPrestige(%Player, 4116, %Sorce);//记录文采值
			if (%RanKing > 0)
				AddAchievementWatch(%Player, 1, 174, %RanKing);//记录成就 答题排名
			switch (%RanKing)
			{
				case 1: %ItemID[1] = 105090901; %ItemCount[1]= 6; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 301;
				case 2: %ItemID[1] = 105090901; %ItemCount[1]= 5; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 302;
				case 3: %ItemID[1] = 105090901; %ItemCount[1]= 4; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 303;
				case 4: %ItemID[1] = 105090901; %ItemCount[1]= 3; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
				case 5: %ItemID[1] = 105090901; %ItemCount[1]= 3; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
				case 6: %ItemID[1] = 105090901; %ItemCount[1]= 2; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
				case 7: %ItemID[1] = 105090901; %ItemCount[1]= 2; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
				case 8: %ItemID[1] = 105090901; %ItemCount[1]= 2; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
				case 9: %ItemID[1] = 105090901; %ItemCount[1]= 2; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
				case 10:%ItemID[1] = 105090901; %ItemCount[1]= 2; %ItemID[2] = 105090902; %ItemCount[2]= 1;	%Designation = 304;
				default:
			}
			//EXP = 等级经验 * 积分 * 等级系数 + 等级段补充经验
			%Level = %Player.Getlevel();
			%OneExp = $Monster_Exp[%Level,1];

			if (%Level < 30) %Coefficient = 0.5;
			else if (%Level < 40) %Coefficient = 1;
			else if (%Level < 50) %Coefficient = 1.2;
			else if (%Level < 60) %Coefficient = 1.6;
			else if (%Level < 70) %Coefficient = 2.0;
			else %Coefficient = 2.2;

			if (%Level < 25) %LevelExp = 0;
			else if (%Level < 40) %LevelExp = 20000;
			else if (%Level < 50) %LevelExp = 30000;
			else if (%Level < 60) %LevelExp = 50000;
			else if (%Level < 70) %LevelExp = 80000;
			else if (%Level < 80) %LevelExp = 100000;
			else if (%Level < 90) %LevelExp = 120000;
			else if (%Level < 100) %LevelExp = 120000;
			else if (%Level < 110) %LevelExp = 120000;
			else if (%Level < 120) %LevelExp = 120000;
			else if (%Level < 130) %LevelExp = 120000;
			else if (%Level < 140) %LevelExp = 120000;
			else if (%Level < 150) %LevelExp = 120000;

			%Exp = %OneExp * %Sorce * %Coefficient + %LevelExp;
			if (%Exp > 0)
				AllAddExp(%Player,%Exp);
			if (%ItemID[1] > 0 &&  %ItemCount[1] > 0)
			{
				%Player.PutItem(%ItemID[1],%ItemCount[1]);
				%Player.Additem(3,20);
			}
			if (%ItemID[2] > 0 &&  %ItemCount[2] > 0)
			{
				%Player.PutItem(%ItemID[2],%ItemCount[2]);
				%Player.Additem(3,20);
			}
			if (%Designation > 0)
			{
				if (%Player.sptIsDesignationExist(%Designation) == 1)
					%Player.DelDesignation(%Designation);
				%Player.AddDesignation(%Designation);
				%Player.SetCurDesignationIDZone(%Designation);
				if (%Designation >= 301 && %Designation <= 303)
				{
					%PlayerName1 = GetPlayerZiTiName(%Player,1);
					%PlayerName2 = GetPlayerZiTiName(%Player,2);
					%HuoDongName1 = GetHuoDongName("趣味答题",1);
					%HuoDongName2 = GetHuoDongName("趣味答题",2);
					switch (%Designation)
					{
						case 301: //            "<t></t>"
							%Name1 =  GetHuoDongName("状元",1);
							%Name2 =  GetHuoDongName("状元",2);
							%Text1 = %PlayerName1 @ "<t>在</t>" @ %HuoDongName1 @ "<t>活动中，一举夺魁，获得称号</t>" @ %Name1 @  "<t>，名震诸天！</t>";
							%Text2 = %PlayerName2 @ "<t>在</t>" @ %HuoDongName2 @ "<t>活动中，一举夺魁，获得称号</t>" @ %Name2 @  "<t>，名震诸天！</t>";
						case 302:
							%Name1 =  GetHuoDongName("榜眼",1);
							%Name2 =  GetHuoDongName("榜眼",2);
							%Text1 = %PlayerName1 @ "<t>在</t>" @ %HuoDongName1 @ "<t>活动中，对答如流，获得称号</t>" @ %Name1 @  "<t>，一时羡煞众修士！</t>";
							%Text2 = %PlayerName2 @ "<t>在</t>" @ %HuoDongName2 @ "<t>活动中，对答如流，获得称号</t>" @ %Name2 @  "<t>，一时羡煞众修士！</t>";
						case 303:
							%Name1 =  GetHuoDongName("探花",1);
							%Name2 =  GetHuoDongName("探花",2);
							%Text1 = %PlayerName1 @ "<t>在</t>" @ %HuoDongName1 @ "<t>活动中，如有神助，获得称号</t>" @ %Name1 @  "<t>，激动的晕了过去。</t>";
							%Text2 = %PlayerName2 @ "<t>在</t>" @ %HuoDongName2 @ "<t>活动中，如有神助，获得称号</t>" @ %Name2 @  "<t>，激动的晕了过去。</t>";
					}
					SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
					SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
				}
			}
		case 36:
			SendPlayerStringToClient(%Player, 10);//发送运营活动配置开关
		case 37://充值反馈
			%NeedSorce = GetChargeBackGiftSorce(%SubType);
			%HaveSorce = %Player.GetMoney(7);
			//echo("%NeedSorce ==" @ %NeedSorce @ "    %HaveSorce===" @ %HaveSorce @ " %ItemID==" @ %ItemID);
			if (%HaveSorce < %NeedSorce)
				return;
			//echo("%NeedSorce ==" @ %NeedSorce @ "    %HaveSorce===" @ %HaveSorce @ " %ItemID==" @ %ItemID);
			if (%Player.GetBagEmptyCount() < 1)
			{
				SendOneScreenMessage(2,"兑换失败，包裹空间不足",%Player);
				return;
			}
			%ItemID = GetChargeBackGiftItemID(%SubType);
			//echo("%NeedSorce ==" @ %NeedSorce @ "    %HaveSorce===" @ %HaveSorce @ " %ItemID==" @ %ItemID);
			if (%ItemID > 0)
			{
				%Player.Reducemoney(%NeedSorce,7,2,37);
				%Player.PutItem(%ItemID,1);
				%Player.Additem(2,37);
				SendOneScreenMessage(1,"兑换成功，请在包裹内查看",%Player);
			}
		case 38://趣味答题记录
			if (%SubType < 0)
				return;
			%Act0 = GetAct(%Player,4101,0);
			%Act1 = GetAct(%Player,4101,1);
			%Act0++;
			SetAct(%Player,4101,%Act0,%Act1);
		case 39://领取帮派工资
			switch (%optype)
			{
				case 0:
					GetOrgActivityWages(%Player, %optype);
			}
		case 40:	//特权和尊享：购买/升级/续费操作（%SubType：操作*10000 + 天数*100 + 等级*10 + 类型）
			%SubType = %SubType @ "";
			%operate = GetSubStr(%SubType,0,1)*1;
			%Days = GetSubStr(%SubType,1,2)*1;
			%Lv = GetSubStr(%SubType,3,1)*1;
			%type = GetSubStr(%SubType,4,1)*1;
			
			%yuanbao = VIP_getTequanCost(%Player, %type, %Lv, %Days, %operate);
			
			if(%type < 1) %activeID = 4123;
			else if(%type == 1) %activeID = 4124;
			else {echo("特权和尊享BUG：active编号出错");return;}
			
			if(%Player.GetMoney(1) >= %yuanbao)
			{
				%Player.ReduceMoney(%yuanbao,1,1,%activeID);
				%Player.AddVipTimer(%type, %Days * 86400);//设置VIP时间
				%Player.ChangeActivity(%activeID, %Lv, 0, $PlayGameReturnTime[%activeID]);
			}
			else SendOneScreenMessage(2,"您的元宝数量不足，请充值！",%Player);
		case 41:	//尊享礼遇
			if(%SubType < 0)	//一键领取
			{
				%idCnt = VIP_getTequanListCnt(%Player, 1);	//条目总数
				for(%i=1;%i<=%idCnt;%i++)
					OnSptActionEvent_S(%Player,41,%i);
			}
			else
			{
				if(VIP_getZhunxiangReward(%Player, %SubType))
					return 0;
				%tequanLv = VIP_getTequanLv(%Player, 1);
				if(%SubType == 14)
				{
					%activeAA = GetWord(%Player.GetActivity(4128),0);
					if(!HasBit(%activeAA, %SubType-1))
					{
						%itemList = getAcerPrerogativeText(%Player, 1,%SubType);
						%ItemNum  = getAcerPrerogativeText(%Player, %tequanLv+2,%SubType);	//不同特权等级，数量不同
						%ItemID  = GetWord(%itemList,%i,"|");
						%ItemID  = getItemTrueIDOrCnt(%Player, %ItemID, 0, 0);
						AddItem_BaoGuoNo_Mail(%Player,%ItemID,%ItemNum,1,"3 4128");
						%activeAA = SetBit(%activeAA, %SubType-1);
						%Player.ChangeActivity(4128, %activeAA, 0, $PlayGameReturnTime[4128]);
					}
					return 0;
				}
				
				%activeAA = GetWord(%Player.GetActivity(4129),0);
				if(!HasBit(%activeAA, %SubType-1))
				{
					%itemList = getAcerPrerogativeText(%Player, 1,%SubType);
					%ItemNum  = getAcerPrerogativeText(%Player, %tequanLv+2,%SubType);	//不同特权等级，数量不同
					for(%i=0;%i<GetWordCount(%itemList);%i++)
					{
						%ItemID  = GetWord(%itemList,%i,"|");
						%ItemID  = getItemTrueIDOrCnt(%Player, %ItemID, 0, 0);
						//%ItemNum = getItemTrueIDOrCnt(%Player, 0, %ItemNum, 0);
						
						if(%ItemID == 105270002 || %ItemID == 105100203)	//元宝|金币
						{
							%min = GetWord(%ItemNum,0,"-");
							%max = GetWord(%ItemNum,1,"-");
							%randomVal = GetRandom(1,100);
									 if(%randomVal <= 65) %cnt = Mfloor(GetRandom(%min, %max*0.5));
							else if(%randomVal <= 90) %cnt = Mfloor(GetRandom(%min, %max*0.75));
							else %cnt = Mfloor(GetRandom(%min, %max));
							
							if(%ItemID == 105270002)
								%Player.AddMoney(%cnt,1,1,4129);
							else
								%Player.AddMoney(%cnt,2,1,4129);
						}
						else
							AddItem_BaoGuoNo_Mail(%Player,%ItemID,%ItemNum,1,"3 4129");
					}
					
					%activeAA = SetBit(%activeAA, %SubType-1);
					%Player.ChangeActivity(4129, %activeAA, 0, $PlayGameReturnTime[4129]);
				}
				
			}
			
			case 42:	//连续充值送豪礼
				if(getRecharge7DaysRewardState(%Player, %SubType) != 1)
					return 0;
				
				if(%SubType <= 7)
				{
					%ItemList = getRecharge7DaysRewardInfo(%Player, %SubType);
					for(%i=0;%i<GetWordCount(%ItemList,"|");%i++)
					{
						%ItemID  = GetWord( GetWord( %ItemList, %i, "|" ), 0, ";" );
						%ItemNum = GetWord( GetWord( %ItemList, %i, "|" ), 1, ";" );
						AddItem_BaoGuoNo_Mail(%Player, %ItemID, %ItemNum, 0, "3 4131");
					}
				}
				else if(%SubType == 8)
					AddItem_BaoGuoNo_Mail(%Player, 105180232, 1, 0, "3 4131");
				
				%ActSt0 = GetAct(%Player,4131,0);	//是否可领取
				%ActSt1 = GetAct(%Player,4131,1);	//是否已领取
				SetAct(%Player, 4131, %ActSt0, SetBit(%ActSt1,%SubType-1));
			
			case 43:	//我的形象我做主：购买触发
				if(!$SL_XianShiLiBao_State_bActive)
					return;
				%ItemID = getMyAppearanceItemInfo(%Player, %SubType, 0);
				%price  = getMyAppearanceItemInfo(%Player, %SubType, 1);
				%activeID = 4132 + (Mfloor(%SubType/100) - 1);
				%activeValue[0] = GetAct(%Player, %activeID, 0);
				%activeValue[1] = GetAct(%Player, %activeID, 1);
				%activeTy = Mfloor(%SubType/10) % 10 - 1;
				
				if(%activeValue[%activeTy]*1 < 1)
				{
					if(%Player.ReduceMoney(%price,1,1,%activeID))
					{
						AddItem_BaoGuoNo_Mail(%Player, %ItemID, 1, 1, "3 "@%activeID);
						%activeValue[%activeTy] = 1;
						SetAct(%Player, %activeID, %activeValue[0], %activeValue[1]);
					}
				}
		
			case 44:	//悠享基金：购买特权
				if(getYouXiangJiJinButtenState(%Player, 1) < 1)
				{
					if(%Player.ReduceMoney(16800,1,1,%activeID))
					{
						%ItemList = getYouXiangJiJinItemList(1);
						for(%i=0;%i<GetWordCount(%ItemList,"|");%i++)
						{
							%ItemID = GetWord(GetWord(%ItemList, %i, "|"),0,";");
							%ItemCt = GetWord(GetWord(%ItemList, %i, "|"),1,";");
							AddItem_BaoGuoNo_Mail(%Player, %ItemID, %ItemCt, 0, "3 4136");
						}
						%Player.AddVipTimer(2, 30*24*3600);
						SetAct(%Player, 4136, 1, 0);	//已购买
					}
					else SendOneScreenMessage(1,"您的元宝数量不足，请充值！",%Player);
				}
			
			case 45:	//悠享基金：领取每日奖励
				if(getYouXiangJiJinButtenState(%Player, 2) < 1)
				{
					%activeID = 4134;
					%active0 = GetAct(%Player, %activeID, 0)*1;
					%active1 = GetAct(%Player, %activeID, 1)*1;
					
					if(%SubType == 1)	//固定奖励
					{
						%ItemList = getYouXiangJiJinItemList(2);
						for(%i=0;%i<GetWordCount(%ItemList,"|");%i++)
						{
							%ItemID = GetWord(GetWord(%ItemList, %i, "|"),0,";");
							%ItemCt = GetWord(GetWord(%ItemList, %i, "|"),1,";");
							if(%ItemID == 105270002)	//元宝
								%Player.AddMoney(%ItemCt,1,1,%activeID);
							else
								AddItem_BaoGuoNo_Mail(%Player, %ItemID, %ItemCt, 0, "3 4134");
							SetAct(%Player, %activeID, 1, %active1);
						}
					}
					else if(%SubType == 2)
					{
						%yuanbao = 0;
						%ItemCt = 0;
						%ItemList = getYouXiangJiJinItemList(3);
						%randomVal = GetRandom(1,100);
						for(%i=0;%i<GetWordCount(%ItemList,"|");%i++)
						{
							%ItemID = GetWord(GetWord(%ItemList, %i, "|"),0,";");
							//%ItemCt = GetWord(GetWord(%ItemList, %i, "|"),1,";");
									 
							
							if(%ItemID == 105270002)	//元宝
							{
										 if(%randomVal <= 67) %yuanbao = GetRandom(50,150);
								else if(%randomVal <= 87) %yuanbao = GetRandom(50,300);
								else %yuanbao = GetRandom(50,800);
								%Player.AddMoney(%yuanbao,1,1,%activeID);
							}					
							else
							{
										 if(%randomVal <= 67) %ItemCt = 1;
								else if(%randomVal <= 87) %ItemCt = 2;
								else %ItemCt = 3;
								AddItem_BaoGuoNo_Mail(%Player, %ItemID, %ItemCt, 0, "3 4134");
								%ItemName = GetItemName(%ItemID,1);
							}
						}
						if(%yuanbao >= 500 || %ItemCt >= 2)
						{
							%Playername1 = GetPlayerZiTiName(%Player,1);
							%Playername2 = GetPlayerZiTiName(%Player,2);
							if(%yuanbao >= 500 && %ItemCt >= 2)
							{
								%Msg1 ="<t>豪运冲天，</t>" @ %Playername1 @ "<t>在随机领取[优享基金]时，获得了 </t>" @ $Get_Dialog_GeShi[31420] @ %yuanbao @ "</t><t> 元宝和 </t>" @ $Get_Dialog_GeShi[31420] @ %ItemCt  @ "</t><t> 枚</t>" @ %ItemName;
								%Msg2 ="<t>豪运冲天，</t>" @ %Playername2 @ "<t>在随机领取[优享基金]时，获得了 </t>" @ $Get_Dialog_GeShi[31420] @ %yuanbao @ "</t><t> 元宝和 </t>" @ $Get_Dialog_GeShi[31420] @ %ItemCt  @ "</t><t> 枚</t>" @ %ItemName;
							}
							else if(%yuanbao >= 500)
							{
								%Msg1 ="<t>财运不错，</t>" @ %Playername1 @ "<t>在随机领取[优享基金]时，获得了 </t>" @ $Get_Dialog_GeShi[31420] @ %yuanbao @ "</t><t> 元宝</t>";
								%Msg2 ="<t>财运不错，</t>" @ %Playername2 @ "<t>在随机领取[优享基金]时，获得了 </t>" @ $Get_Dialog_GeShi[31420] @ %yuanbao @ "</t><t> 元宝</t>";
								
							}
							else if(%ItemCt >= 2)
							{
								%Msg1 ="<t>手气不错，</t>" @ %Playername1 @ "<t>在随机领取[优享基金]时，获得了 </t>"@ $Get_Dialog_GeShi[31420] @ %ItemCt  @ "</t><t> 枚</t>" @ %ItemName;
								%Msg2 ="<t>手气不错，</t>" @ %Playername2 @ "<t>在随机领取[优享基金]时，获得了 </t>"@ $Get_Dialog_GeShi[31420] @ %ItemCt  @ "</t><t> 枚</t>" @ %ItemName;
								
							}
							SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Msg1 @ "</t>");
							SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg2 @ "</t>", $chatMsg_Type_Normal2);
						}
						SetAct(%Player, %activeID, 1, %active1);
					}
				}
				
				case 46:	//限时抢购，%SubType：%shopID*10000 + %index*100 + %Cnt
					if($SL_XianShiQiangGou_State_bActive*1 < 1)
						return;
					
					%PlayerID = %Player.GetPlayerID();
					%LineID = GetCurrentLineId();//线程ID
					%shopID = Mfloor(%SubType/10000);
					%index = Mfloor(%SubType/100) % 100;
					%Cnt = %SubType % 100;
					%itemInfo = $XianShiQiangGou_ItemInfo[%LineID, %shopID, %index];
					
					%activeID = 4200 + %index;	//标记玩家可购买次数
					%oldDays = GetAct(%Player,%activeID,0);	//上一次购买时的活动开始时间
					%buyCnts = GetAct(%Player,%activeID,1);	//已经购买的数量
					
					%newDate = GetWord($SL_XianShiQiangGou_EndTime[1],0);
					%newDays = (GetWord(%newDate,0,".")-2018)*365 + GetWord(%newDate,1,".")*30 + GetWord(%newDate,2,".");
					
					%ItemID    = GetWord(%itemInfo,0,"|")*1;
					%AllCnt    = GetWord(%itemInfo,1,"|")*1;	//库存
					%selfCnt   = GetWord(%itemInfo,2,"|")*1;	//限购
					%Price     = GetWord(%itemInfo,3,"|")*1;	//价格
					%moneyType = GetWord(%itemInfo,4,"|")*1;	//货币类型
					
					if($XianShiQiangGou_ItemKuCun[%LineID, %shopID, %index] < 1)
					{
						SendOneScreenMessage(2,"该物品已售罄，请您留意下一次抢购吧！",%Player);
						return;
					}
					if($XianShiQiangGou_ItemKuCun[%LineID, %shopID, %index] < %Cnt)
					{
						SendOneScreenMessage(2,"您购买的数量超过了库存总量，请减少您的购买数量！",%Player);
						return;
					}
					if(%selfCnt - %buyCnts < 1)
					{
						SendOneScreenMessage(2,"您购买该物品的额度已经用完，请您留意下一次抢购吧！",%Player);
						return;
					}
					if(%selfCnt - %buyCnts < %Cnt)
					{
						SendOneScreenMessage(2,"您购买的数量已超过可用额度，请减少您的购买数量！",%Player);
						return;
					}
					
					
					if(%Player.GetBagEmptyCount() > 0)
					{
						if(%moneyType < 10)
						{
							if(%Player.ReduceMoney(%Price,%moneyType,1,%ItemID))
							{
								%Player.PutItem(%ItemID,%Cnt);
								%Player.AddItem(1,%ItemID);
								//减少库存量和个人可购买数
								$XianShiQiangGou_ItemKuCun[%LineID, %shopID, %index] -= %Cnt;
								SetAct(%Player,%activeID,%newDays,%buyCnts+1);
								%KuCunInfo = %shopID @" "@ %index @" "@ $XianShiQiangGou_ItemKuCun[%LineID, %shopID, %index];
								%Player.SendPlayerString(15,%KuCunInfo,0);
							}
						}
						else
						{
							%Player.PutItem(%ItemID,%Cnt);
							%Player.PutItem(%moneyType,-%Price);
							%Player.AddItem(1,%ItemID);
							//减少库存量和个人可购买数
							$XianShiQiangGou_ItemKuCun[%LineID, %shopID, %index] -= %Cnt;
							SetAct(%Player,%activeID,%newDays,%buyCnts+1);
							%KuCunInfo = %shopID @" "@ %index @" "@ $XianShiQiangGou_ItemKuCun[%LineID, %shopID, %index];
							%Player.SendPlayerString(15,%KuCunInfo,0);
						}
						//更新界面显示
						ServerOnSptAction(%Player.GetPlayerID(),Mceil(%index/8),22);
					}
					else SendOneScreenMessage(2,"您的包裹已满，请保留至少一个空位！",%Player); 
					
					
			
			
			
			
	}
}


//■■■■■■■■■■■客户端通讯脚本■■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■■确认对话框后弹出■■■■■■■■■■■■■■■■■
function ShowAffirmDialog(%Player,%StringId,%MarkId)
{
	%Family = %Player.GetFamily();
	%Lv = %Player.GetLevel();
	switch (%MarkId)
	{
		case 0:
			//什么都不触发的对话框
		case 1://确认是否离开副本
			TransportPlayerMaptoMap(%Player,2);
		case 2:
			CopyMap_Begin_1301(%Player);
		case 3:
			CopyMap_Begin_1302(%Player);
			//改名卡确认触发
		case 4://提示需要手动升级
			SetSrc(%player,2);
		case 5://兑换鱼饵
			DiaoYuHuoDong_DiaLogA_A(%Player);
		case 6: DiaoYuChengHaoDuiHuan(%Player,101);
		case 7: DiaoYuChengHaoDuiHuan(%Player,102);
		case 8: DiaoYuChengHaoDuiHuan(%Player,103);
		case 9: DiaoYuChengHaoDuiHuan(%Player,104);
		case 10: DiaoYuChengHaoDuiHuan(%Player,105);
		case 11: DiaoYuChengHaoDuiHuan(%Player,106);
		case 12: DiaoYuChengHaoDuiHuan(%Player,107);
		case 13: DiaoYuChengHaoDuiHuan(%Player,108);
		case 14: DiaoYuChengHaoDuiHuan(%Player,109);
		case 15: DiaoYuChengHaoDuiHuan(%Player,110);
		case 16: XueMoFengYinZhenKaiQi(%Player);
		case 17: TanKuangQueRen_10241(%Player); //试炼之地
		case 18: TanKuangQueRen_10291(%Player); //探查源头
		case 19: TanKuangQueRen_11232(%Player); //检查魔剑
		case 20: MianZhanPaiUse(%Player,105109091,30);//30分钟的免战
		case 21: ShengHuoJiNeng_30101(%Player); //生活技能 挖矿
		case 22: ShengHuoJiNeng_30111(%Player); //生活技能 伐木
		case 23: ShengHuoJiNeng_30121(%Player); //生活技能 采药
		case 24: ShengHuoJiNeng_30131(%Player); //生活技能 钓鱼
		case 25: ShengHuoJiNeng_30201(%Player); //生活技能 铸造
		case 26: ShengHuoJiNeng_30301(%Player); //生活技能 缝纫
		case 27: ShengHuoJiNeng_30401(%Player); //生活技能 制器
		case 28: ShengHuoJiNeng_30501(%Player); //生活技能 炼丹
		case 29: ShengHuoJiNeng_30601(%Player); //生活技能 制符
		case 30: ShengHuoJiNeng_30701(%Player); //生活技能 烹饪
		case 31: TanKuangQueRen_10931(%Player); //狐王洞
		case 32: TanKuangQueRen_11021(%Player); //陨仙窟二层
		case 33:SptSetRenameRequest(%Player);//改名卡
		case 34:MianZhanPaiUse(%Player,105109092,60);//免战
		case 35:MianZhanPaiUse(%Player,105109093,120);//免战
		case 36:MianZhanPaiUse(%Player,105109094,300);//免战
		case 37:MianZhanPaiUse(%Player,105109095,30);//免战
		case 38:MianZhanPaiUse(%Player,105109096,60);//免战
		case 39:MianZhanPaiUse(%Player,105109097,120);//免战
		case 40:MianZhanPaiUse(%Player,105109098,300);//免战
		case 41:CreateMonsterForYunLuoJing(%Player);//云罗镜开启
		case 42:ZhuXianRenWu_ChuanSong( %Player, 10871 );//主线任务传送确认框
		case 43:ZhuXianRenWu_ChuanSong( %Player, 11031 );//主线任务传送确认框
		case 44:ZhuXianRenWu_ChuanSong( %Player, 10841 );//主线任务传送确认框
		case 45:CreateMonsterForFengShenMiJing(%Player);//封神秘境副本开启
		case 324:
			SptSetRenameRequest(%Player);
	}
}
//■■■■■■■■■■■■确认对话框后弹出■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■■发送超长字符串■■■■■■■■■■■■■■■■■
function SendPlayerStringToClient(%Player, %idx)
{
	switch (%idx)
	{
		case 10:
			%Player.SendPlayerString(10, $SL_YunYingHuoDong1, 0);
			%Player.SendPlayerString(12, $SL_YunYingHuoDong2, 0);
	}
}
//■■■■■■■■■■■■发送超长字符串■■■■■■■■■■■■■■■■■