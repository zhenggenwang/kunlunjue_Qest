//=============================================================================
// �ĵ�˵��:ͨѶ�ű�
// ����ʱ��:2017-12-01
// ������: Irelia

// �޸���: 
// �޸�ʱ��: 
//=============================================================================

//�����������������������ͻ���ͨѶ�ű���������������������������������������
//������������������������ȷ�϶Ի���󵯳�����������������������������������
//���������������������������ͳ����ַ�������������������������������������

//�����������������������ͻ���ͨѶ�ű���������������������������������������
//ClientOnSptAction( %type, %SubType )
function OnSptActionEvent_S(%Player,%type,%SubType)
{
	//echo( "%type===" @ %type @ "   %SubType===" @ %SubType );
	switch (%type)
	{
		case 1://�¹ⱦ��ˢ�µ���������¼
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
					MoonLightBaoHe_AccecpMis_GetItem(%Player,%Mid);	//�жϽ�����ʱ�Ƿ���Ҫ������Ʒ
				}
		case 6:
			if (GetBuildString() $= "Debug")
				if (GetPetData(%SubType,0) !$= "")
					GeneratePetInfo(%Player.GetPlayerID(),%SubType,1,2,0,1);//�����������
		case 7://������ť����
			//echo("%Subtype ==" @ %Subtype);
			//39902	1	�ظ�	skill/307.png	�ظ�100��HP��MP����ߵ���10000��
			//39902	2	�ظ�	skill/307.png	�ظ�1%HP��MP����ߵ���100��
			//�ƱҸ��������¼
			%Activity = 2209;
			%ActivityA = GetWord(%Player.GetActivity(%Activity),0);
			%ActivityB = GetWord(%Player.GetActivity(%Activity),1);
			//%ActivityA = ( %ActivityA == 9 ) ? %ActivityA : %ActivityA + 1;

			switch (%Subtype)
			{
				case 1://Ԫ������
					%Money =  FuHuoNeedMoney_Expend(%Player,0);
					if (%Player.GetMoney(1) < %Money)
					{
						Message_Caution_Hint(%Player,"����Ԫ�����㣬�޷�ʹ�øø��");
						return;
					}
					//�������
					if (%Player.GetDamageState() $= "Disabled")
					{
						//�۳�Ԫ��
						%Player.ReduceMoney(%Money,1,5,1014);
						//��������
						%Player.SetDamageState(Enabled);
						//��ӻ�Ѫ״̬
						%Player.AddBuff(399020200,%Player,100);
						//�ƱҸ��������¼
						%ActivityB++;
						//�����
						%Player.AddBuff(399010001,%Player,1);
					}
				case 2://��Ҹ���
					if (!HasBit(GetTriggerData(%Player.GetTriggerId(),11),27))
					{
						//��ȡ���Player
						%Money =  FuHuoNeedMoney_Expend(%Player,1);
						if (%Player.GetMoney(2) < %Money)
						{
							Message_Caution_Hint(%Player,"���Ľ�Ҳ��㣬�޷�ʹ�øø��");
							return;
						}
					}
					//�������
					if (%Player.GetDamageState() $= "Disabled")
					{
						//��������
						%Player.SetDamageState(Enabled);
						//��ӻ�Ѫ״̬
						%Player.AddBuff(399020200,%Player,100);
						if (%Money > 0)
							%Player.ReduceMoney(%Money,2,5,1008);
						%ActivityA++;
						%ActivityB++;
						//�����
						%Player.AddBuff(399010001,%Player,1);
					}
				default://��Ҹ���ܸ���
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
							//��������
							%Player.SetDamageState(Enabled);
							//��ӻ�Ѫ״̬
							%Player.AddBuff(399020001,%Player,%HP/100);
							//�����
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
			//echo( "һ������һ������" @ %Player.GetSex( ) );
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
		case 10://�˳���Ӱģʽ
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
			%Player.SendPlayerString(2,$SL_HuoDong,0);//�������л���ÿ���
		case 12://�ͻ���֪ͨ����˸��½ű�
			if (GetBuildString() $= "Debug")
				u();
		case 13:
			YaBiaoHuoDong_QueReng(%Player,%Player.YaBiaoRecord);
		case 14://�۱���
			%Level = %Player.GetLevel();
			%Luck = %Player.getLuck();//��ȡ��Ҹ�Եֵ
			switch (%Subtype)
			{
				case 0://��Ѷһ�
					%Times = GetAct(%Player,3038,0)%1000;//ʣ����Ѵ���
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
				case 1://Ԫ���һ�
					%Times = mfloor(GetAct(%Player,3038,0)/1000);//�Ѿ�Ԫ���һ�����
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
				SendOneChatMessage($chatMsg_Person, "<t>��ϲ�㣬���ξ۱��轱��������</t>", %Player);
			}
				
			//echo( "%Money====" @ %Money );
			//%Player.Addmoney( %Money, 2, 1, 3038 );
			Schedule(3000,0,"eval",%Player @ ".Addmoney(" @ "\"" @ %Money @ "\"" @ ",2, 1, 3038 ); ");
			if (%Money > 0)
				ServerOnSptAction(%Player.GetPlayerID(),%SendMoney,8);//ͨѶ�ͻ���

			%Player.PlayerAchieveCount(0,24,1,0);//��ӳɾͼ�¼
			//echo( %Player.Getactivity( 3038 ) );
		case 15://����7���¼����
			//echo( "��������=====" @ %Subtype );
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
		case 16://��¼ǩ���Ͳ�ǩ
			switch (%SubType)
			{
				case 0://ǩ��
					RecordLonginGame(%Player);
				case 1://��ǩ
					if (%Player.GetMoney(1) >= $QianDaoBuQian)
						QianDaoBuQian(%Player);
					else
					{
						SendOneScreenMessage(1,"Ԫ������",%Player);
						SendOneChatMessage($chatMsg_System,"<t>Ԫ�����㣬��ǩʧ��</t>",%Player);
					}
			}
			ServerOnSptAction(%Player.GetPlayerID(),0,9);//ͨѶ�ͻ���
			SendPlayerStringToClient(%Player, 10);//������Ӫ����ÿ���
		case 17://��ȡ�ȼ����
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
			SendOneScreenMessage(1,"��ȡ�ɹ�",%Player);
			SendOneChatMessage($chatMsg_System,"<t>��ȡ�ɹ�����򿪰����鿴</t>",%Player);
			ServerOnSptAction(%Player.GetPlayerID(),0,10);//ͨѶ�ͻ���
		case 18://��ȡ��Ծ�����
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
				SetStrategyRecord(%Player,$StrategySubBtnSrc[2,0]);//���Դ�����¼
			SendOneScreenMessage(1,"��ȡ�ɹ�",%Player);
			SendOneChatMessage($chatMsg_System,"<t>��ȡ�ɹ�����򿪰����鿴</t>",%Player);
			ServerOnSptAction(%Player.GetPlayerID(),0,11);//ͨѶ�ͻ���
		case 19:
			LingJingWuDao_YuanShenWuDaoStart(%Player);
		case 20:
			//echo( "%SubType===" @ %SubType );
			switch (%SubType)
			{
				case 1://�հ�ʱ�ĵ�һ��ˢ��
					GetTodayXuanShangMission(%Player);
				case 2://ÿ����Ѵ���ˢ��
					%Act0 = GetAct(%Player,4090,0)* 1;
					%Act1 = GetAct(%Player,4090,1)* 1;
					if (GetXuanShangJiXiongFreeTimes(%Player) - %Act0 > 0)
					{
						SetAct(%Player,4090,%Act0++,%Act1);
						GetNewXuanShangMission(%Player,2);
					}
				case 3://�շ�ˢ��
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
						SendOneScreenMessage(1,%Itemname @ "���㣬�޷�ˢ��",%Player);
						SendOneChatMessage($chatMsg_System,"<t>" @ %Itemname @ "���㣬�޷�ˢ��</t>",%Player);
						return;
					}
			}
			ServerOnSptAction(%Player.GetPlayerID(),0,15);//ͨѶ�ͻ���
		case 21://���ͼ��׽�ȡ����
			XuanShangJiXiongGetMissionToPlayer(%Player,%SubType);
		case 22://���ɹ������
			AddOrgLevel(%PLayer,%SubType);
		case 23://��������
			//echo( GetSrc( %Player, 187 ) );
			if (GetSrc(%Player,187) == 0)
				SetSrc(%Player,187);
			//echo( GetSrc( %Player, 187 ) );
			%Player.AI_CastSpell(%PLayer.Getposition(),200190001);
		case 24://��������С��Ӱ
			//echo( %Subtype @ "��������С��Ӱ" );
			switch (%Subtype)
			{
				case 0:
					XiaoDianYing_ChuFa_001(%Npc,%Player,%State,%Conv,%mid);
				case 1:
					XiaoDianYing_ChuFa_002( %Npc, %Player, %State, %Conv, %mid );
				case 2:
					XiaoDianYing_ChuFa_003(%Npc,%Player,%State,%Conv,%mid);
			}
		case 25://��ȡ�׳�����
			%Count = %Player.GetBagEmptyCount();//��ð�����
			if (%Count < 5)
			{
				SendOneScreenMessage(1,"�����ռ䲻��",%Player);
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
						%GiftName0 =$Get_Dialog_GeShi[31420] @  "[�׳�����]</t>";
						%GiftName1 =$Get_Dialog_GeShi[60008] @  "[�׳�����]</t>";

						%ItemName0 = GetItemName(%ItemID,1);
						%ItemName1 = GetItemName(%ItemID,2);

						%Playername0 = GetPlayerZiTiName(%Player,1);
						%Playername1 = GetPlayerZiTiName(%Player,2);

						%Text0 ="<t>�����콵��</t>" @ %Playername0 @ "<t>��ȡ</t>" @ %GiftName0 @ "<t>ʱ�������</t>" @ %ItemName0 @ "<t>��������ɷ���ˣ�</t>";
						%Text1 ="<t>�����콵��</t>" @ %Playername1 @ "<t>��ȡ</t>" @ %GiftName1 @ "<t>ʱ�������</t>" @ %ItemName1;
						SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text0 @ "</t>");
						SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text1 @ "</t>", $chatMsg_Type_Normal2);
					}
				}
				if (%player.Additem(1,4097))
				{
					SetIsCanReceiveFirstRecharge(%Player);
					SendOneScreenMessage(1,"��ȡ�ɹ�����鿴����",%Player);
				}
				ServerOnSptAction(%Player.GetPlayerID(),1,20);//ͨѶ�ͻ���
			}
			else
			{
				SendOneScreenMessage(1,"����������ȡ����",%Player);
				return;
			}
		case 26://��ȡÿ�ճ�ֵ���
			//echo( " %Subtype===" @  %Subtype );
			%Subtype = %Subtype -1;
			if (GetIsCanReceiveRechargeDays(%Player,%Subtype) == 0)
			{
				%ItemID = GetFisrtRechargeForDays(%Subtype);
				%Player.PutItem(%ItemID,1);
				if (%player.Additem(1,4095))
				{
					SetIsCanReceiveRechargeDays(%Player,%Subtype);
					//echo( "��ȡÿ�ճ�ֵ���===="  @ %Player.GetPlayerID( ) );
					SendOneScreenMessage(1,"��ȡ�ɹ�����鿴����",%Player);
				}
				ServerOnSptAction(%Player.GetPlayerID(),4,20);//ͨѶ�ͻ���
			}
			else
			{
				SendOneScreenMessage(1,"����������ȡ����",%Player);
				return;
			}
		case 27://��ȡ��ȡ����
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
					SendOneScreenMessage(1,"��ȡ�ɹ�����鿴����",%Player);
				}
				ServerOnSptAction(%Player.GetPlayerID(),5,20);//ͨѶ�ͻ���
			}
			else
			{
				SendOneScreenMessage(1,"����������ȡ����",%Player);
				return;
			}
		case 28://�سǾ�
			ItemTransBackHome_TransPortObject(%Player,%SubType);
		case 29://���������ͨѶ
			switch (%SubType)
			{
				case 8:JianSingZhiYin_10781(%Player,10781);//����ָ��
				case 11:QiangHuaZhiYin_10761(%Player,10761);//ǿ��ָ��
			}
		case 30://�����ѧϰ
			if (%SubType <= 4)
				%Src = 189;
			else
				%Src = 190;
			if (GetSrc(%Player,%Src) == 1)
			{
				SendOneScreenMessage(2,"ѧϰʧ�ܣ����ѽӹ����������������",%Player);
				return;
			}
			switch (%SubType)
			{

				case 1:%Player.ShowDialogOk(2000000021,21,1);//�ڿ�	����ȷ�Ͽ�
				case 2:%Player.ShowDialogOk(2000000022,22,1);//��ľ
				case 3:%Player.ShowDialogOk(2000000023,23,1);//��ҩ
				case 4:%Player.ShowDialogOk(2000000024,24,1);//����
				case 5:%Player.ShowDialogOk(2000000025,25,1);//����	����ȷ�Ͽ�
				case 6:%Player.ShowDialogOk(2000000026,26,1);//����
				case 7:%Player.ShowDialogOk(2000000027,27,1);//����
				case 8:%Player.ShowDialogOk(2000000028,28,1);//����
				case 9:%Player.ShowDialogOk(2000000029,29,1);//�Ʒ�
				case 10:%Player.ShowDialogOk(2000000030,30,1);//���
			}
		case 31://��ȡ�����Ľ������
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
					SendOneScreenMessage(1,"��ȡ��������ɹ�",%Player);
					HelpDirectByIndex(%Player.GetPlayerID(),11);	//ͨѶ�ͻ���
				}
			}
		case 32://��ȡ������������
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
							SendOneScreenMessage(1,"��ȡ���������ɹ�",%Player);
							HelpDirectByIndex(%Player.GetPlayerID(),11);	//ͨѶ�ͻ���
						}
					}
				}
			}
		case 33://���Խ�����ɼ�¼����ȡ��־
			SetStrategyRecord(%Player,%SubType);
		case 34://�������߽���
			if (%Player.GetBagEmptyCount() < 1)
			{
				SendOneScreenMessage(1,"�����ռ䲻��",%Player);
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
		case 35://Ȥζ����
			%RanKing = %Player.getAnswerRank();//����
			%Sorce = %Player.getAnswerPoint();//��ȡ����
			if (%Sorce <= 0)
			{
				SendOneScreenMessage(2,"������ȡ����������û�д������",%Player);
				SendOneChatMessage($chatMsg_System,"<t>��ȡʧ�ܣ�������ȡ����������û�д������</t>",%Player);
				return;
			}
			SendOneScreenMessage(2,"��ȡ�����ɹ�",%Player);
			SendOneChatMessage($chatMsg_System,"<t>�ɹ���ȡȤζ���⽱����</t>",%Player);
			
			%Player.SetAnswerPoint(0);//���÷���

			AddPrestige(%Player, 4116, %Sorce);//��¼�Ĳ�ֵ
			if (%RanKing > 0)
				AddAchievementWatch(%Player, 1, 174, %RanKing);//��¼�ɾ� ��������
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
			//EXP = �ȼ����� * ���� * �ȼ�ϵ�� + �ȼ��β��侭��
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
					%HuoDongName1 = GetHuoDongName("Ȥζ����",1);
					%HuoDongName2 = GetHuoDongName("Ȥζ����",2);
					switch (%Designation)
					{
						case 301: //            "<t></t>"
							%Name1 =  GetHuoDongName("״Ԫ",1);
							%Name2 =  GetHuoDongName("״Ԫ",2);
							%Text1 = %PlayerName1 @ "<t>��</t>" @ %HuoDongName1 @ "<t>��У�һ�ٶ������óƺ�</t>" @ %Name1 @  "<t>���������죡</t>";
							%Text2 = %PlayerName2 @ "<t>��</t>" @ %HuoDongName2 @ "<t>��У�һ�ٶ������óƺ�</t>" @ %Name2 @  "<t>���������죡</t>";
						case 302:
							%Name1 =  GetHuoDongName("����",1);
							%Name2 =  GetHuoDongName("����",2);
							%Text1 = %PlayerName1 @ "<t>��</t>" @ %HuoDongName1 @ "<t>��У��Դ���������óƺ�</t>" @ %Name1 @  "<t>��һʱ��ɷ����ʿ��</t>";
							%Text2 = %PlayerName2 @ "<t>��</t>" @ %HuoDongName2 @ "<t>��У��Դ���������óƺ�</t>" @ %Name2 @  "<t>��һʱ��ɷ����ʿ��</t>";
						case 303:
							%Name1 =  GetHuoDongName("̽��",1);
							%Name2 =  GetHuoDongName("̽��",2);
							%Text1 = %PlayerName1 @ "<t>��</t>" @ %HuoDongName1 @ "<t>��У�������������óƺ�</t>" @ %Name1 @  "<t>�����������˹�ȥ��</t>";
							%Text2 = %PlayerName2 @ "<t>��</t>" @ %HuoDongName2 @ "<t>��У�������������óƺ�</t>" @ %Name2 @  "<t>�����������˹�ȥ��</t>";
					}
					SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text1 @ "</t>");
					SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
				}
			}
		case 36:
			SendPlayerStringToClient(%Player, 10);//������Ӫ����ÿ���
		case 37://��ֵ����
			%NeedSorce = GetChargeBackGiftSorce(%SubType);
			%HaveSorce = %Player.GetMoney(7);
			//echo("%NeedSorce ==" @ %NeedSorce @ "    %HaveSorce===" @ %HaveSorce @ " %ItemID==" @ %ItemID);
			if (%HaveSorce < %NeedSorce)
				return;
			//echo("%NeedSorce ==" @ %NeedSorce @ "    %HaveSorce===" @ %HaveSorce @ " %ItemID==" @ %ItemID);
			if (%Player.GetBagEmptyCount() < 1)
			{
				SendOneScreenMessage(2,"�һ�ʧ�ܣ������ռ䲻��",%Player);
				return;
			}
			%ItemID = GetChargeBackGiftItemID(%SubType);
			//echo("%NeedSorce ==" @ %NeedSorce @ "    %HaveSorce===" @ %HaveSorce @ " %ItemID==" @ %ItemID);
			if (%ItemID > 0)
			{
				%Player.Reducemoney(%NeedSorce,7,2,37);
				%Player.PutItem(%ItemID,1);
				%Player.Additem(2,37);
				SendOneScreenMessage(1,"�һ��ɹ������ڰ����ڲ鿴",%Player);
			}
		case 38://Ȥζ�����¼
			if (%SubType < 0)
				return;
			%Act0 = GetAct(%Player,4101,0);
			%Act1 = GetAct(%Player,4101,1);
			%Act0++;
			SetAct(%Player,4101,%Act0,%Act1);
		case 39://��ȡ���ɹ���
			switch (%optype)
			{
				case 0:
					GetOrgActivityWages(%Player, %optype);
			}
		case 40:	//��Ȩ����������/����/���Ѳ�����%SubType������*10000 + ����*100 + �ȼ�*10 + ���ͣ�
			%SubType = %SubType @ "";
			%operate = GetSubStr(%SubType,0,1)*1;
			%Days = GetSubStr(%SubType,1,2)*1;
			%Lv = GetSubStr(%SubType,3,1)*1;
			%type = GetSubStr(%SubType,4,1)*1;
			
			%yuanbao = VIP_getTequanCost(%Player, %type, %Lv, %Days, %operate);
			
			if(%type < 1) %activeID = 4123;
			else if(%type == 1) %activeID = 4124;
			else {echo("��Ȩ������BUG��active��ų���");return;}
			
			if(%Player.GetMoney(1) >= %yuanbao)
			{
				%Player.ReduceMoney(%yuanbao,1,1,%activeID);
				%Player.AddVipTimer(%type, %Days * 86400);//����VIPʱ��
				%Player.ChangeActivity(%activeID, %Lv, 0, $PlayGameReturnTime[%activeID]);
			}
			else SendOneScreenMessage(2,"����Ԫ���������㣬���ֵ��",%Player);
		case 41:	//��������
			if(%SubType < 0)	//һ����ȡ
			{
				%idCnt = VIP_getTequanListCnt(%Player, 1);	//��Ŀ����
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
						%ItemNum  = getAcerPrerogativeText(%Player, %tequanLv+2,%SubType);	//��ͬ��Ȩ�ȼ���������ͬ
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
					%ItemNum  = getAcerPrerogativeText(%Player, %tequanLv+2,%SubType);	//��ͬ��Ȩ�ȼ���������ͬ
					for(%i=0;%i<GetWordCount(%itemList);%i++)
					{
						%ItemID  = GetWord(%itemList,%i,"|");
						%ItemID  = getItemTrueIDOrCnt(%Player, %ItemID, 0, 0);
						//%ItemNum = getItemTrueIDOrCnt(%Player, 0, %ItemNum, 0);
						
						if(%ItemID == 105270002 || %ItemID == 105100203)	//Ԫ��|���
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
			
			case 42:	//������ֵ�ͺ���
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
				
				%ActSt0 = GetAct(%Player,4131,0);	//�Ƿ����ȡ
				%ActSt1 = GetAct(%Player,4131,1);	//�Ƿ�����ȡ
				SetAct(%Player, 4131, %ActSt0, SetBit(%ActSt1,%SubType-1));
			
			case 43:	//�ҵ����������������򴥷�
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
		
			case 44:	//������𣺹�����Ȩ
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
						SetAct(%Player, 4136, 1, 0);	//�ѹ���
					}
					else SendOneScreenMessage(1,"����Ԫ���������㣬���ֵ��",%Player);
				}
			
			case 45:	//���������ȡÿ�ս���
				if(getYouXiangJiJinButtenState(%Player, 2) < 1)
				{
					%activeID = 4134;
					%active0 = GetAct(%Player, %activeID, 0)*1;
					%active1 = GetAct(%Player, %activeID, 1)*1;
					
					if(%SubType == 1)	//�̶�����
					{
						%ItemList = getYouXiangJiJinItemList(2);
						for(%i=0;%i<GetWordCount(%ItemList,"|");%i++)
						{
							%ItemID = GetWord(GetWord(%ItemList, %i, "|"),0,";");
							%ItemCt = GetWord(GetWord(%ItemList, %i, "|"),1,";");
							if(%ItemID == 105270002)	//Ԫ��
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
									 
							
							if(%ItemID == 105270002)	//Ԫ��
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
								%Msg1 ="<t>���˳��죬</t>" @ %Playername1 @ "<t>�������ȡ[�������]ʱ������� </t>" @ $Get_Dialog_GeShi[31420] @ %yuanbao @ "</t><t> Ԫ���� </t>" @ $Get_Dialog_GeShi[31420] @ %ItemCt  @ "</t><t> ö</t>" @ %ItemName;
								%Msg2 ="<t>���˳��죬</t>" @ %Playername2 @ "<t>�������ȡ[�������]ʱ������� </t>" @ $Get_Dialog_GeShi[31420] @ %yuanbao @ "</t><t> Ԫ���� </t>" @ $Get_Dialog_GeShi[31420] @ %ItemCt  @ "</t><t> ö</t>" @ %ItemName;
							}
							else if(%yuanbao >= 500)
							{
								%Msg1 ="<t>���˲���</t>" @ %Playername1 @ "<t>�������ȡ[�������]ʱ������� </t>" @ $Get_Dialog_GeShi[31420] @ %yuanbao @ "</t><t> Ԫ��</t>";
								%Msg2 ="<t>���˲���</t>" @ %Playername2 @ "<t>�������ȡ[�������]ʱ������� </t>" @ $Get_Dialog_GeShi[31420] @ %yuanbao @ "</t><t> Ԫ��</t>";
								
							}
							else if(%ItemCt >= 2)
							{
								%Msg1 ="<t>��������</t>" @ %Playername1 @ "<t>�������ȡ[�������]ʱ������� </t>"@ $Get_Dialog_GeShi[31420] @ %ItemCt  @ "</t><t> ö</t>" @ %ItemName;
								%Msg2 ="<t>��������</t>" @ %Playername2 @ "<t>�������ȡ[�������]ʱ������� </t>"@ $Get_Dialog_GeShi[31420] @ %ItemCt  @ "</t><t> ö</t>" @ %ItemName;
								
							}
							SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Msg1 @ "</t>");
							SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg2 @ "</t>", $chatMsg_Type_Normal2);
						}
						SetAct(%Player, %activeID, 1, %active1);
					}
				}
				
				case 46:	//��ʱ������%SubType��%shopID*10000 + %index*100 + %Cnt
					if($SL_XianShiQiangGou_State_bActive*1 < 1)
						return;
					
					%PlayerID = %Player.GetPlayerID();
					%LineID = GetCurrentLineId();//�߳�ID
					%shopID = Mfloor(%SubType/10000);
					%index = Mfloor(%SubType/100) % 100;
					%Cnt = %SubType % 100;
					%itemInfo = $XianShiQiangGou_ItemInfo[%LineID, %shopID, %index];
					
					%activeID = 4200 + %index;	//�����ҿɹ������
					%oldDays = GetAct(%Player,%activeID,0);	//��һ�ι���ʱ�Ļ��ʼʱ��
					%buyCnts = GetAct(%Player,%activeID,1);	//�Ѿ����������
					
					%newDate = GetWord($SL_XianShiQiangGou_EndTime[1],0);
					%newDays = (GetWord(%newDate,0,".")-2018)*365 + GetWord(%newDate,1,".")*30 + GetWord(%newDate,2,".");
					
					%ItemID    = GetWord(%itemInfo,0,"|")*1;
					%AllCnt    = GetWord(%itemInfo,1,"|")*1;	//���
					%selfCnt   = GetWord(%itemInfo,2,"|")*1;	//�޹�
					%Price     = GetWord(%itemInfo,3,"|")*1;	//�۸�
					%moneyType = GetWord(%itemInfo,4,"|")*1;	//��������
					
					if($XianShiQiangGou_ItemKuCun[%LineID, %shopID, %index] < 1)
					{
						SendOneScreenMessage(2,"����Ʒ������������������һ�������ɣ�",%Player);
						return;
					}
					if($XianShiQiangGou_ItemKuCun[%LineID, %shopID, %index] < %Cnt)
					{
						SendOneScreenMessage(2,"����������������˿����������������Ĺ���������",%Player);
						return;
					}
					if(%selfCnt - %buyCnts < 1)
					{
						SendOneScreenMessage(2,"���������Ʒ�Ķ���Ѿ����꣬����������һ�������ɣ�",%Player);
						return;
					}
					if(%selfCnt - %buyCnts < %Cnt)
					{
						SendOneScreenMessage(2,"������������ѳ������ö�ȣ���������Ĺ���������",%Player);
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
								//���ٿ�����͸��˿ɹ�����
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
							//���ٿ�����͸��˿ɹ�����
							$XianShiQiangGou_ItemKuCun[%LineID, %shopID, %index] -= %Cnt;
							SetAct(%Player,%activeID,%newDays,%buyCnts+1);
							%KuCunInfo = %shopID @" "@ %index @" "@ $XianShiQiangGou_ItemKuCun[%LineID, %shopID, %index];
							%Player.SendPlayerString(15,%KuCunInfo,0);
						}
						//���½�����ʾ
						ServerOnSptAction(%Player.GetPlayerID(),Mceil(%index/8),22);
					}
					else SendOneScreenMessage(2,"���İ����������뱣������һ����λ��",%Player); 
					
					
			
			
			
			
	}
}


//�����������������������ͻ���ͨѶ�ű���������������������������������������


//������������������������ȷ�϶Ի���󵯳�����������������������������������
function ShowAffirmDialog(%Player,%StringId,%MarkId)
{
	%Family = %Player.GetFamily();
	%Lv = %Player.GetLevel();
	switch (%MarkId)
	{
		case 0:
			//ʲô���������ĶԻ���
		case 1://ȷ���Ƿ��뿪����
			TransportPlayerMaptoMap(%Player,2);
		case 2:
			CopyMap_Begin_1301(%Player);
		case 3:
			CopyMap_Begin_1302(%Player);
			//������ȷ�ϴ���
		case 4://��ʾ��Ҫ�ֶ�����
			SetSrc(%player,2);
		case 5://�һ����
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
		case 17: TanKuangQueRen_10241(%Player); //����֮��
		case 18: TanKuangQueRen_10291(%Player); //̽��Դͷ
		case 19: TanKuangQueRen_11232(%Player); //���ħ��
		case 20: MianZhanPaiUse(%Player,105109091,30);//30���ӵ���ս
		case 21: ShengHuoJiNeng_30101(%Player); //����� �ڿ�
		case 22: ShengHuoJiNeng_30111(%Player); //����� ��ľ
		case 23: ShengHuoJiNeng_30121(%Player); //����� ��ҩ
		case 24: ShengHuoJiNeng_30131(%Player); //����� ����
		case 25: ShengHuoJiNeng_30201(%Player); //����� ����
		case 26: ShengHuoJiNeng_30301(%Player); //����� ����
		case 27: ShengHuoJiNeng_30401(%Player); //����� ����
		case 28: ShengHuoJiNeng_30501(%Player); //����� ����
		case 29: ShengHuoJiNeng_30601(%Player); //����� �Ʒ�
		case 30: ShengHuoJiNeng_30701(%Player); //����� ���
		case 31: TanKuangQueRen_10931(%Player); //������
		case 32: TanKuangQueRen_11021(%Player); //���ɿ߶���
		case 33:SptSetRenameRequest(%Player);//������
		case 34:MianZhanPaiUse(%Player,105109092,60);//��ս
		case 35:MianZhanPaiUse(%Player,105109093,120);//��ս
		case 36:MianZhanPaiUse(%Player,105109094,300);//��ս
		case 37:MianZhanPaiUse(%Player,105109095,30);//��ս
		case 38:MianZhanPaiUse(%Player,105109096,60);//��ս
		case 39:MianZhanPaiUse(%Player,105109097,120);//��ս
		case 40:MianZhanPaiUse(%Player,105109098,300);//��ս
		case 41:CreateMonsterForYunLuoJing(%Player);//���޾�����
		case 42:ZhuXianRenWu_ChuanSong( %Player, 10871 );//����������ȷ�Ͽ�
		case 43:ZhuXianRenWu_ChuanSong( %Player, 11031 );//����������ȷ�Ͽ�
		case 44:ZhuXianRenWu_ChuanSong( %Player, 10841 );//����������ȷ�Ͽ�
		case 45:CreateMonsterForFengShenMiJing(%Player);//�����ؾ���������
		case 324:
			SptSetRenameRequest(%Player);
	}
}
//������������������������ȷ�϶Ի���󵯳�����������������������������������


//���������������������������ͳ����ַ�������������������������������������
function SendPlayerStringToClient(%Player, %idx)
{
	switch (%idx)
	{
		case 10:
			%Player.SendPlayerString(10, $SL_YunYingHuoDong1, 0);
			%Player.SendPlayerString(12, $SL_YunYingHuoDong2, 0);
	}
}
//���������������������������ͳ����ַ�������������������������������������