//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//在客户端点击各种界面的触发
//==================================================================================
function FinshEveryWndCommand(%Type)
{
	%Player = getPlayer();
	switch (%Type)
	{
		case 1://装备打孔

		case 2://宝石镶嵌
		case 3://摘除宝石
		case 4://宝石合成
		case 5://碎片合成
		case 6://宝石重铸
		case 7://宝石升级
		case 8://装备鉴定 (这里只是客户端按钮触发了一下，服务端还有一个完成的触发）

			if (%Player.IsAcceptedMission(10781))
			{
				%Type10781 = %Player.GetMissionFlag(10781,1350);
				%Num10781 = %Player.GetMissionFlag(10781,1250);
				if (%Type10781 < %Num10781)
				{
					ClientOnSptAction(29,%Type);//通讯服务端

					CloseHelpDirectByIndex(116,%Type);
				}
			}
			putout("------鉴定后触发------");
			closeHelpDirect1_4(9);
		case 9://装备重铸 (这里只是客户端按钮触发了一下，服务端还有一个完成的触发）

		case 10://装备精炼 (这里只是客户端按钮触发了一下，服务端还有一个完成的触发）

		case 11://装备强化 (这里只是客户端按钮触发了一下，服务端还有一个完成的触发）

			if (%Player.IsAcceptedMission(10761))
			{
				%Type10761 = %Player.GetMissionFlag(10761,1350);
				%Num10761 = %Player.GetMissionFlag(10761,1250);
				if (%Type10761 < %Num10761)
				{
					ClientOnSptAction(29,%Type);//通讯服务端

					Schedule(3500,0,"CloseHelpDirectByIndex",116,%Type);
				}
			}
			putout("------强化触发------");
			closeHelpDirect1_4(8);
		case 12://全属性转移
		case 13://装备涅槃
			SetStrategyWndRecord($StrategySubBtnSrc[1,9]);//完成攻略记录

		case 14://加入到队伍
			SetStrategyWndRecord($StrategySubBtnSrc[0,0]);//完成攻略记录
		case 15://添加好友
			SetStrategyWndRecord($StrategySubBtnSrc[0,1]);//完成攻略记录
		case 16://创建帮派
			SetStrategyWndRecord($StrategySubBtnSrc[0,2]);//完成攻略记录
		case 17://加入帮派
			SetStrategyWndRecord($StrategySubBtnSrc[0,2]);//完成攻略记录
		case 18://摆摊--出摊
			SetStrategyWndRecord($StrategySubBtnSrc[0,4]);//完成攻略记录
			//case 19://千里传音 

		case 20://写信
			SetStrategyWndRecord($StrategySubBtnSrc[0,6]);//完成攻略记录
		case 21://自动战斗
			SetStrategyWndRecord($StrategySubBtnSrc[1,0]);//完成攻略记录
			//case 22://技能升级

			//case 23://技能学习

		case 24://神石合成
			SetStrategyWndRecord($StrategySubBtnSrc[1,10]);//完成攻略记录
		case 25://鉴宝
			SetStrategyWndRecord($StrategySubBtnSrc[1,11]);//完成攻略记录
			
	}
}
