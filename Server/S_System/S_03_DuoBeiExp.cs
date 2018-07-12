//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//多倍经验丹
//
//==================================================================================
//■■■■【经验计算脚本】■■■■■【经验丹道具使用】■■■■■■■
//■■■■【经验计算脚本】■■■■■【福星领取每周双倍】■■■■■■
//■■■■【经验计算脚本】■■■■■【世界等级加成计算】■■■■■■


//■■■■【经验计算脚本】■■■■■【经验丹道具使用】■■■■■■■
function Trigger_105028001(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ) { Trigger_105028001_105028022(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1997,1998,1999); }//双倍经验丹
function Trigger_105028002(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ) { Trigger_105028001_105028022(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1997,1998,1999); }//双倍经验丹（赠品）
function Trigger_105028011(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ) { Trigger_105028001_105028022(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1998,1997,1999); }//2.5倍经验丹
function Trigger_105028012(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ) { Trigger_105028001_105028022(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1998,1997,1999); }//2.5倍经验丹（赠品）
function Trigger_105028021(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ) { Trigger_105028001_105028022(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1999,1998,1997); }//三倍经验丹
function Trigger_105028022(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ) { Trigger_105028001_105028022(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,1999,1998,1997); }//三倍经验丹（赠品）

function Trigger_105028001_105028022(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ,%SchBuffID,%NoSchBuff1,%NoSchBuff2)
{
	if (%Player.IsSchBuff(%NoSchBuff1) == 1 || %Player.IsSchBuff(%NoSchBuff2) == 1)
	{
		%Txt = "您已经有其他经验加成，无法再使用经验丹";
		SendOneScreenMessage(2,%Txt,%Player);
		return;
	}
	if (%Player.GetSchBuff(%SchBuffID) < 68400)
	{
		%Player.PutItem(%Type,-1);
		if (%Player.AddItem(4,%Type))
		{
			if (%Player.IsSchBuff(%SchBuffID) ==1)
				%Player.AddSchBuff(%SchBuffID,-3600);
			else
			{
				%Player.SetSchBuff(%SchBuffID);
				%Player.AddSchBuff(%SchBuffID,82800);
			}
		}
		else
		{
			%Txt = "您没有足够的物品";
			SendOneScreenMessage(2,%Txt,%Player);	//红色消息
			SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
		}
	}
	else
		SendOneScreenMessage(2,"你身上携带的双倍时间已达到上限",%Player);
}

//■■■■【经验计算脚本】■■■■■【经验丹道具使用】■■■■■■■

//■■■■【经验计算脚本】■■■■■【福星领取每周双倍】■■■■■■
function NpcDiaLog_410010113(%Npc,%Player,%State,%Conv)
{
	switch (%State)
	{
		case 0:
			if (GetSrc(%Player,1) == 0)
				%Conv.AddOption(100000,100000);//领取本周免费双倍
			%Conv.AddOption(100001,100001);//存储双倍经验时间
			%Conv.AddOption(100002,100002);//取出双倍经验时间
		case 100000://领取本周免费双倍
			if (GetSrc(%Player,1) == 0)
			{
				if (%Player.GetSchBuff(1997) < 50400)
				{
					SetSrc(%Player,1);
					if (%Player.IsSchBuff(1997) ==1)
						%Player.AddSchBuff(1997,-18000);
					else
					{
						%Player.SetSchBuff(1997);
						%Player.AddSchBuff(1997,50400);
					}
					SendOneScreenMessage(1,"领取成功",%Player);
					SetStrategyRecord(%Player,$StrategySubBtnSrc[1,1]);//攻略触发记录
					%Conv.Settype(4);
				}
				else
					SendOneScreenMessage(2,"无法领取，你身上的双倍时间过多",%Player);
			}
		case 100001://存储双倍经验时间
			%Conv.SetText(100008);
			%Conv.AddOption(100004,100004); //存储一小时<
			%Conv.AddOption(100005,100005); //存储全部</t
			%Conv.AddOption(4,0);
		case 100002://取出双倍经验时间
			%Conv.SetText(100008);
			%Conv.AddOption(100006,100006);	//取出一小时</t>";
			%Conv.AddOption(100007,100007);	//取出全部</t>";
			%Conv.AddOption(4,0);
		case 100004://存储一小时
			%ACT_A = GetAct(%Player,3031,0);
			%ACT_B = GetAct(%Player,3031,1);
			%Time = %ACT_A * 3600 + %ACT_B;
			if (%Time >= 72000)
			{
				SendOneScreenMessage(2,"无法存储，存储的双倍时间不能超过20小时",%Player);
				NpcCanDoJob(%Npc,%Player,0,%Conv);
			}
			else if (%Player.GetSchBuff(1997) < 3600)
			{
				SendOneScreenMessage(2,"无法存储，身上的双倍时间不足",%Player);
				NpcCanDoJob(%Npc,%Player,0,%Conv);
			}
			else
			{
				%ACT_A = %ACT_A + 1;
				%Player.AddSchBuff(1997,3600);
				SetAct(%Player,3031,%ACT_A,%ACT_B);
				SendOneScreenMessage(1,"存储成功",%Player);

				%Conv.SetText(100008);
				%Conv.AddOption(100004,100004); //存储一小时<
				%Conv.AddOption(100005,100005); //存储全部</t
				%Conv.AddOption(4,0);
			}
		case 100005://存储全部
			%ACT_A = GetAct(%Player,3031,0);
			%ACT_B = GetAct(%Player,3031,1);
			%Time = %ACT_A * 3600 + %ACT_B;

			if (%Time + %Player.GetSchBuff(1997) >= 72000)
			{
				SendOneScreenMessage(2,"无法存储，存储的双倍时间不能超过20小时",%Player);
				NpcCanDoJob(%Npc,%Player,0,%Conv);
			}
			else if (%Player.GetSchBuff(1997) < 60)
			{
				SendOneScreenMessage(2,"无法存储，身上的双倍时间不足",%Player);
				NpcCanDoJob(%Npc,%Player,0,%Conv);
			}
			else
			{
				%ACT_B = %ACT_B + %Player.GetSchBuff(1997);
				%ACT_A = %ACT_A + mfloor(%ACT_B  / 3600);
				%ACT_B = Take_remainder(%ACT_B,3600);

				SetAct(%Player,3031,%ACT_A,%ACT_B);
				%Player.RemoveSchBuff(1997);
				SendOneScreenMessage(1,"存储成功",%Player);
				%Conv.SetText(100008);
				%Conv.AddOption(4,0);
			}

		case 100006://取出一小时
			%ACT_A = GetAct(%Player,3031,0);
			%ACT_B = GetAct(%Player,3031,1);
			%Time = %ACT_A * 3600 + %ACT_B;
			if (%Time < 3600)
			{
				SendOneScreenMessage(2,"取出失败，存储的双倍时间不足",%Player);
				%Conv.SetText(100008);
				%Conv.AddOption(4,0);
			}
			else if (%Player.GetSchBuff(1997) + 3600 >= 68400)
			{
				SendOneScreenMessage(2,"取出失败，身上的双倍经验过多",%Player);
				%Conv.SetText(100008);
				%Conv.AddOption(4,0);
			}
			else
			{
				%ACT_A = %ACT_A - 1;
				SetAct(%Player,3031,%ACT_A,%ACT_B);

				if (%Player.IsSchBuff(1997) ==1)
					%Player.AddSchBuff(1997,-3600);
				else
				{
					%Player.SetSchBuff(1997);
					%Player.AddSchBuff(1997,82800);
				}
				SendOneScreenMessage(1,"取出成功",%Player);
				%Conv.SetText(100008);
				%Conv.AddOption(100006,100006);	//取出一小时</t>";
				%Conv.AddOption(100007,100007);	//取出全部</t>";
				%Conv.AddOption(4,0);
			}

		case 100007://取出全部
			%ACT_A = GetAct(%Player,3031,0);
			%ACT_B = GetAct(%Player,3031,1);
			%Time = %ACT_A * 3600 + %ACT_B;
			if (%Time > 0)
			{
				if (%Player.GetSchBuff(1997) + %Time >= 68400)
				{
					SendOneScreenMessage(2,"取出失败，身上的双倍经验过多",%Player);
					%Conv.SetText(100008);
					%Conv.AddOption(4,0);
				}
				else
				{
					SetAct(%Player,3031,0,0);

					if (%Player.IsSchBuff(1997) ==1)
						%Player.AddSchBuff(1997,-%Time);
					else
					{
						%Player.SetSchBuff(1997);
						%Player.AddSchBuff(1997,86400 - %Time);
					}

					SendOneScreenMessage(1,"取出成功",%Player);
					%Conv.SetText(100008);
					%Conv.AddOption(4,0);
				}
			}
			else
			{
				SendOneScreenMessage(2,"取出失败，没有存储的双倍时间",%Player);
				%Conv.SetText(100008);
				%Conv.AddOption(4,0);
			}
	}
}
//■■■■【经验计算脚本】■■■■■【福星领取每周双倍】■■■■■■



//■■■■【经验计算脚本】■■■■■【世界等级加成计算】■■■■■■
function ShiJieLevelJiaCheng(%Player)//计算和添加当前的加成BUFF等级
{
	%Level = %Player.GetLevel();
	%Cha = $MaxLevelRecord - %Level;
	//echo( " %Level===" @  %Level );
	//echo( " %$MaxLevelRecord===" @  $MaxLevelRecord );
	//echo( " %Cha===" @  %Cha );
	if (%Cha <= 3)
	{
		%Player.ShiJieLevelJiaCheng = 0;
		return;
	}
	%BuffID = 39908 * 10000 + %Cha;
	//echo( " %BuffID===" @  %BuffID );
	%Player.Addbuff(%BuffID,%Player,1);
	%Player.ShiJieLevelJiaCheng = (%Cha-3)*0.03;
}
function SetShiJieZuiGaoLevel(%Playerid,%Level)//存储全服最高等级
{
	//echo( "存储全服最高等级=====" @ %Playerid );
	%MapID = GetZoneid();
	if (%MapID != 1001)
		return;
	%LineID = GetCurrentLineId();//线程ID
	%MaxLevel = GetWord(GetServerSystemEvent(%LineID),1);
	if (%MaxLevel < %Level)
	{
		SetServerSystemEvent(%LineID,%Playerid,%Level);
		$MaxLevelRecord = %Level;
	}
}
function SendShiJieLevelto1001(%PlayerID,%Level)//通知1001刷新最高等级
{
	if (%Level > $MaxLevelRecord)
	{
		%List = %PlayerID @ "," @ %Level;
		%Functionname = "SetShiJieZuiGaoLevel(" @ %PlayerID @ "," @ %Level @ ");";
		//echo( "%Functionname===" @ %Functionname );
		SptInterMapExecute(1001,%Functionname);
	}
}
function GetShiJieZuiGaoLevel()//获取全服最高等级
{
	%LineID = GetCurrentLineId();//线程ID
	%MaxLevel = GetWord(GetServerSystemEvent(%LineID),1);
	if (%MaxLevel > $MaxLevelRecord)
		$MaxLevelRecord = %MaxLevel;
	if ($MaxLevelRecord > 120)
		$MaxLevelRecord = 120;
}
function GetShiJieLevelJiaChengNum(%Player)//获取世界最高等级经验加成最终值
{
	%Source = 1 + %Player.ShiJieLevelJiaCheng;
	return %Source;
}
//■■■■【经验计算脚本】■■■■■【世界等级加成计算】■■■■■■
