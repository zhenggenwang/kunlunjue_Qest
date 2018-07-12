
//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//帮派相关功能脚本
//==================================================================================

//快速跳转入口，选中后使用F3即可，如果你不是用UE，那就帮不了你了

function UPCS_FamilyFunction(%Num)
{
	if ((%Num == 1)||(%Num == 99)){ Exec("./S_01_SiegeWarfare.cs"); }
	if ((%Num == 2)||(%Num == 99)){ Exec("./S_02_OrgActvity.cs"); }
}

UPCS_FamilyFunction(99);


function FamilyDialog(%Npc, %Player, %State, %Conv)
{
	%PlayerID = %Player.GetPlayerID();
	%FamilyID = %Player.GetOrgID();
	%Family_Master = SptOrg_GetMaster(%FamilyID);
	%FamilyLv = SptOrg_GetLevel(%FamilyID);
	switch (%state)
	{
		case 0:
			%Conv.AddOption(100033, 100033);//创建帮派
			%Conv.AddOption(100034, 100034);//查询帮派
			%Conv.AddOption(100035, 100035);//帮派升级
			%Conv.AddOption(100036, 100036);//帮派宣战
			%Conv.AddOption(100037, 100037);//帮派捐献
		case 100033://创建帮派
			if (%Player.GetLevel() < 30)
			{
				SendOneScreenMessage(2, "您的等级不足", %Player);
				SendOneChatMessage($chatMsg_System, "<t>" @ "您的等级不足" @ "</t>", %Player);
				return  NpcOnTrigger(%Conv, %Npc, %Player, 0, -1);
			}
			%orgID = SptOrg_GetOrgID(%PlayerID);		//家族ID
			if (%orgID > 0)
			{
				SendOneScreenMessage(2, "您已加入帮派", %Player);
				SendOneChatMessage($chatMsg_System, "<t>" @ "您已加入帮派" @ "</t>", %Player);
				return  NpcOnTrigger(%Conv, %Npc, %Player, 0, -1);
			}
			else
			{
				%Conv.Settype(4);
				ServerOnSptAction(%PlayerID, 1, 19);//通讯客户端
			}
		case 100034://查询帮派
			//echo( "%state =====" @ %state );
			%Conv.Settype(4);
			ServerOnSptAction(%PlayerID, 666, 19);//通讯客户端
		case 100035://帮派升级
			%Conv.Settext(100083);
			%Conv.AddOption(100084, 100084);
		case 100084:
			switch (%FamilyLv)
			{
				case 1:
					%ShengWang = 288000;
					%HuoYue = 10000;
					%ItemID[1] = 105105303;
					%ItemNum[1] = 10;
				case 2:
					%ShengWang = 4320000;
					%HuoYue = 20000;
					%ItemID[1] = 105105304;
					%ItemNum[1] = 10;
				case 3:
					%Text = "您的帮派等级已达到上限";
					%ItemID[1] = 105105304;
					%ItemNum[1] = 50;
					%ItemID[2] = 105105305;
					%ItemNum[2] = 1;
					%ShengWang = 14400000;
					%HuoYue = 30000;
				case 4:
					%Text = "您的帮派等级已达到上限";
					%ItemID[1] = 105105304;
					%ItemNum[1] = 100;
					%ItemID[2] = 105105305;
					%ItemNum[2] = 10;
					%ShengWang = 36000000;
					%HuoYue = 40000;
				default:
					%Text = "您没有帮派或者不是帮主";
			}
			for (%i = 1; %i <= 9; %i++)
			{
				if (%ItemID[%i] > 0)
				{
					if (%Player.GetItemCount(%ItemID[%i]) < %ItemNum[%i])
					{
						%Text = "您没有足够的" @ GetItemData(%ItemID[%i], 1);
						break;
					}
				}
				else
					break;
			}
			if (SptOrg_GetHonor(%FamilyID)  < %ShengWang)
				%Text = "本次升级帮派需要达到" @ %ShengWang @ "声望";
			if (SptOrg_GetActivity(%FamilyID) < %HuoYue)
				%Text = "本次升级帮派需要达到" @ %HuoYue @ "活跃";
			if (%PlayerID !$= %Family_Master)
				%Text = "您不是帮主，请让帮主来升级帮派";
			if (%Text !$= "")
			{
				SendOneScreenMessage(2, %Text, %Player);
				SendOneChatMessage($chatMsg_System, "<t>" @ %Text @ "</t>", %Player);
				return NpcOnTrigger(%Conv, %Npc, %Player, 0, -1);
			}
			else
			{
				%Conv.Settype(4);
				ServerOnSptAction(%PlayerID, %FamilyLv + 1, 19);//通讯客户端
			}
		case 100036://帮派宣战
			if (%PlayerID !$= %Family_Master)
				%Text = "您不是帮主，请让帮主来申请宣战";
			if (%Text !$= "")
			{
				SendOneScreenMessage(2, %Text, %Player);
				SendOneChatMessage($chatMsg_System, "<t>" @ %Text @ "</t>", %Player);
				return NpcOnTrigger(%Conv, %Npc, %Player, 0, -1);
			}
			else
			{
				%Conv.Settype(4);
				ServerOnSptAction(%PlayerID, 666, 19);//通讯客户端
			}
		case 100037://帮派捐献
			%orgID = SptOrg_GetOrgID(%Player.GetPlayerID());		//家族ID
			if (%orgID > 0)
			{
				%Conv.SetText(100074);
				%Conv.AddOption(100038, 100038);//捐献金条</t>";
				%Conv.AddOption(100039, 100039);//捐献金砖</t>";
				%Conv.AddOption(100040, 100040);//捐献一级奇珍</t>";
				%Conv.AddOption(100041, 100041);//捐献二级奇珍</t>";
				%Conv.AddOption(100042, 100042);//捐献三级奇珍</t>";
				%Conv.AddOption(100043, 100043);//捐献四级奇珍</t>";
				%Conv.AddOption(100044, 100044);//捐献五级奇珍</t>";
				%Conv.AddOption(100045, 100045);//捐献六级奇珍</t>";
				%Conv.AddOption(100046, 100046);//捐献七级奇珍</t>";
				%Conv.AddOption(100047, 100047);//捐献八级奇珍</t>";
				//%Conv.AddOption(100048, 100048);//捐献九级奇珍</t>";
				//%Conv.AddOption(100049, 100049);//捐献十级奇珍</t>";
			}
			else
			{
				%Text = "您当前没有帮派，请先加入帮派";
				SendOneScreenMessage(2, %Text, %Player);
				SendOneChatMessage($chatMsg_System, "<t>" @ %Text @ "</t>", %Player);
				return NpcOnTrigger(%Conv, %Npc, %Player, 0, -1);
			}
		case 100038://捐献金条</t>";
			%Conv.SetText(%State + 12);
			%Conv.AddOption(100130, 100130);
			%Conv.AddOption(100131, 100131);
			%Conv.AddOption(4, 100037);
		case 100039://捐献金砖</t>";
			%Conv.SetText(%State + 12);
			%Conv.AddOption(100132, 100132);
			%Conv.AddOption(100133, 100133);
			%Conv.AddOption(4, 100037);
	}
	if (%State >=  100040  && %State <= 100049)
	{
		//echo( " %State===" @  %State );
		//echo( "=================" @ %State + 9 +( %State  - 100040 ) * 2 );
		%Conv.SetText(%State + 12);
		%Conv.AddOption(%State + 24, %State + 24);
		%Conv.AddOption(4, 100037);
	}
	switch (%State)
	{
		case 100130:
			%ItemID[1] = 105105303;
			%ItemCount = %Player.GetItemCount(%ItemID[1]);
			if (%ItemCount > 0)
			{
				%Player.putitem(%ItemID[1], -1);
				if (%Player.Additem(5, 1010))
				{
					AddFamily_SW_GX(%Player, $MenPaiShengWangJuanXian[%ItemID[1]] , $MenPaiShengWangJuanXian[%ItemID[1]] );
					GetOrgActivityWages(%Player, 1);
				}
			}
			return FamilyDialog(%Npc, %Player, 100038, %Conv);
		case 100132:
			%ItemID[1] = 105105304;
			%ItemCount = %Player.GetItemCount(%ItemID[1]);
			if (%ItemCount > 0)
			{
				%Player.putitem(%ItemID[1], -1);
				if (%Player.Additem(5, 1010))
				{
					AddFamily_SW_GX(%Player, $MenPaiShengWangJuanXian[%ItemID[1]] , $MenPaiShengWangJuanXian[%ItemID[1]] );
					GetOrgActivityWages(%Player, 1);
				}
			}
			return FamilyDialog(%Npc, %Player, 100039, %Conv);
		case 100131:%ReturState = 100037; %ItemID[1] = 105105303; %ItemID[2] = 0; %ItemID[3] = 0; %ItemID[4] = 0;
		case 100133:%ReturState = 100037; %ItemID[1] = 105105304; %ItemID[2] = 0; %ItemID[3] = 0; %ItemID[4] = 0;
		case 100064:%ReturState = 100037; %ItemID[1] = 105109401; %ItemID[2] = 105109402; %ItemID[3] = 105109403; %ItemID[4] = 105109404;
		case 100065:%ReturState = 100037; %ItemID[1] = 105109411; %ItemID[2] = 105109412; %ItemID[3] = 105109413; %ItemID[4] = 105109414;
		case 100066:%ReturState = 100037; %ItemID[1] = 105109421; %ItemID[2] = 105109422; %ItemID[3] = 105109423; %ItemID[4] = 105109424;
		case 100067:%ReturState = 100037; %ItemID[1] = 105109431; %ItemID[2] = 105109432; %ItemID[3] = 105109433; %ItemID[4] = 105109434;
		case 100068:%ReturState = 100037; %ItemID[1] = 105109441; %ItemID[2] = 105109442; %ItemID[3] = 105109443; %ItemID[4] = 105109444;
		case 100069:%ReturState = 100037; %ItemID[1] = 105109451; %ItemID[2] = 105109452; %ItemID[3] = 105109453; %ItemID[4] = 105109454;
		case 100070:%ReturState = 100037; %ItemID[1] = 105109461; %ItemID[2] = 105109462; %ItemID[3] = 105109463; %ItemID[4] = 105109464;
		case 100071:%ReturState = 100037; %ItemID[1] = 105109471; %ItemID[2] = 105109472; %ItemID[3] = 105109473; %ItemID[4] = 105109474;
		case 100072:%ReturState = 100037; %ItemID[1] = 105109481; %ItemID[2] = 105109482; %ItemID[3] = 105109483; %ItemID[4] = 105109484;
		case 100073:%ReturState = 100037; %ItemID[1] = 105109491; %ItemID[2] = 105109492; %ItemID[3] = 105109493; %ItemID[4] = 105109494;
	}
	if (%ReturState > 0)
	{
		for (%i = 1; %i <= 4; %i++)
		{
			if (%ItemID[%i] > 0 )
			{
				%ItemCount = %Player.GetItemCount(%ItemID[%i]);
				//echo("%ItemID[" @ %i @ "]===" @ %ItemID[%i] @ "  " @ %Player.GetItemCount(%ItemID[%i]));
				if (%ItemCount > 0)
				{
					%Player.putitem(%ItemID[%i], -%ItemCount);
					if (%Player.Additem(5, 1010))
					{
						AddFamily_SW_GX(%Player, $MenPaiShengWangJuanXian[%ItemID[%i]] * %ItemCount, $MenPaiShengWangJuanXian[%ItemID[%i]] * %ItemCount);
						GetOrgActivityWages(%Player, 1);
					}
				}
				
			}
		}
		return FamilyDialog(%Npc, %Player, %ReturState, %Conv);
	}
}

function AddOrgLevel(%PLayer, %SubType)
{
	//%orgID = SptOrg_GetOrgID( %PlayerID );		//家族ID
	%FamilyID = %Player.GetOrgID();
	%Family_Master = SptOrg_GetMaster(%FamilyID);
	%FamilyLv = SptOrg_GetLevel(%FamilyID);
	%PlayerID = %Player.GetPlayerID();
	//echo( "%FamilyID===" @ %FamilyID );
	//echo( "%Family_Master===" @ %Family_Master );
	//echo( "%FamilyLv===" @ %FamilyLv );
	switch (%FamilyLv + 1)
	{
		case 2:
			%ShengWang = 288000;
			%HuoYue = 10000;
		case 3:
			%ShengWang = 4320000;
			%HuoYue = 20000;
		case 4:
			%ShengWang = 14400000;
			%HuoYue = 30000;
		case 5:
			%ShengWang = 36000000;
			%HuoYue = 40000;
		default:
			return;
	}

	//echo( "SptOrg_GetHonor( %FamilyID ) ===" @ SptOrg_GetHonor( %FamilyID ) );
	if (SptOrg_GetHonor(%FamilyID)  < %ShengWang)
		return;
	if (SptOrg_GetActivity(%FamilyID) < %HuoYue)
		return;
	if (%PlayerID !$= %Family_Master)
		return;
	switch (%SubType)
	{
		case 2:
			%Player.PutItem(105105303, -10);
			if (%Player.Additem(5, 1010))
				SptOrg_AddLevel(%FamilyID);
		case 3:
			%Player.PutItem(105105304, -10);
			if (%Player.Additem(5, 1010))
				SptOrg_AddLevel(%FamilyID);
		case 4:
			%Player.PutItem(105105304, -50);
			%Player.PutItem(105105305, -1);
			if (%Player.Additem(5, 1010))
				SptOrg_AddLevel(%FamilyID);
		case 5:
			%Player.PutItem(105105304, -100);
			%Player.PutItem(105105305, -10);
			if (%Player.Additem(5, 1010))
				SptOrg_AddLevel(%FamilyID);
	}
}

//------------秘咒除魔------------

function Mission_Begin_Process_20028(%Npc, %Player, %Conv, %Param, %Mid)
{
	%Level = %Player.GetLevel();
	if (%Level <= 45) %NpcID = 411011014;
	else if (%Level <= 60) %NpcID = 411021014;
	else if (%Level <= 75) %NpcID = 411031014;
	else if (%Level <= 90) %NpcID = 411041014;
	else %NpcID = 411051014;

	%Player.SetMissionFlag(%Mid, 3100, %NpcID);	//设置,怪物编号
	%Player.SetMissionFlag(%Mid, 3200, 1);	//设置,怪物总数
	%Player.SetMissionFlag(%Mid, 3300, 0); 				//设置,怪物当前数量
	%Player.UpdateMission(%Mid);//更新任务信息
}

function Mission_End_Process_20028(%Npc, %Player, %Conv, %Param, %Mid)
{
	GetOrgActivityWages(%Player, 2);
}



//------------收集灵魄------------

function Mission_Begin_Process_20151(%Npc, %Player, %Conv, %Param, %Mid)
{
	%Player.SetMissionFlag(%Mid, 1100, 108030009);	//设置,怪物编号
	%Player.SetMissionFlag(%Mid, 1200, 300);	//设置,怪物总数
	%Player.SetMissionFlag(%Mid, 1300, 0); 				//设置,怪物当前数量
	%Player.UpdateMission(%Mid);//更新任务信息
}

function Mission_End_Process_20151(%Npc, %Player, %Conv, %Param, %Mid)
{
	GetOrgActivityWages(%Player, 3);
}
