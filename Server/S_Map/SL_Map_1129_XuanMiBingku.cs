//■■■■■■■■■■■落日神陵地宫脚本■■■■■■■■■■■■■■■■■


//一层随机循环任务
function Npc_Dialog_411290002(%Npc,%Player,%State,%Conv,%Param)
{
	%PlayerID = %Player.GetPlayerID();
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000015);											//好忙啊，好想偷个懒啊！你能不能帮我做点事儿？
			if (%Player.IsAcceptedMission(20150)!=1)
				%Conv.AddOption(600000016,600000016);							//采集仙药
			if (%Player.IsAcceptedMission(20151)!=1)
				%Conv.AddOption(600000017,600000017);							//挑战精英
			if (%Player.IsAcceptedMission(20152)!=1)
				%Conv.AddOption(600000018,600000018);							//镇压群妖
			if (%Player.IsAcceptedMission(20153)!=1)
				%Conv.AddOption(600000019,600000019);							//救援散修
		case 600000016:
			%Conv.SetText(600000020);											//此次多番你多次帮助，不然恐怕……
			AddMissionAccepted(%Player,%Conv,20150);						//采集仙药
		case 600000017:
			%Conv.SetText(600000020);											//此次多番你多次帮助，不然恐怕……
			AddMissionAccepted(%Player,%Conv,20151);						//挑战精英
		case 600000018:
			%Conv.SetText(600000020);											//此次多番你多次帮助，不然恐怕……
			AddMissionAccepted(%Player,%Conv,20152);						//镇压群妖
		case 600000019:
			%Conv.SetText(600000020);											//此次多番你多次帮助，不然恐怕……
			AddMissionAccepted(%Player,%Conv,20153);						//救援散修
	}
}
//落日神陵一层营救
function Npc_Dialog_411291009_411291013(%Npc,%Player,%State,%Conv,%Param,%NeedHelpNpcID)
{
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000020);
			if (%Player.IsAcceptedMission(20153)==1)
			{

				%ThisNpcId = %Player.GetMissionflag(20153,1100);
				if (%NeedHelpNpcID == %ThisNpcId)
				{
					%Conv.AddOption(600000021,600000021);
				}
			}
		case 600000021:
			%Conv.SetText(600000022);
			%Player.SetMissionFlag(20153,1300,%ThisNpcId++);									//设置任务目标完成进度+1
			%Player.updatemission(20153);
	}
}


//二层随机循环任务
function Npc_Dialog_411290004(%Npc,%Player,%State,%Conv,%Param)
{
	%PlayerID = %Player.GetPlayerID();
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000015);											//好忙啊，好想偷个懒啊！你能不能帮我做点事儿？
			if (%Player.IsAcceptedMission(20150)!=1)
				%Conv.AddOption(600000016,600000016);							//采集仙药
			if (%Player.IsAcceptedMission(20151)!=1)
				%Conv.AddOption(600000017,600000017);							//挑战精英
			if (%Player.IsAcceptedMission(20152)!=1)
				%Conv.AddOption(600000018,600000018);							//镇压群妖
			if (%Player.IsAcceptedMission(20153)!=1)
				%Conv.AddOption(600000019,600000019);							//救援散修
		case 600000016:
			AddMissionAccepted(%Player,%Conv,20154);						//采集仙药
			%Conv.SetText(600000020);											//此次多番你多次帮助，不然恐怕……
		case 600000017:
			AddMissionAccepted(%Player,%Conv,20155);						//挑战精英
			%Conv.SetText(600000020);											//此次多番你多次帮助，不然恐怕……
		case 600000018:
			AddMissionAccepted(%Player,%Conv,20156);						//镇压群妖
			%Conv.SetText(600000020);											//此次多番你多次帮助，不然恐怕……
		case 600000019:
			AddMissionAccepted(%Player,%Conv,20157);						//救援散修
			%Conv.SetText(600000020);											//此次多番你多次帮助，不然恐怕……
	}
}
//落日神陵二层营救
function Npc_Dialog_411291015_411291019(%Npc,%Player,%State,%Conv,%Param,%NeedHelpNpcID)
{
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000020);
			if (%Player.IsAcceptedMission(20157)==1)
			{

				%ThisNpcId = %Player.GetMissionflag(20157,1100);
				if (%NeedHelpNpcID == %ThisNpcId)
				{
					%Conv.AddOption(600000021,600000021);
				}
			}
		case 600000021:
			%Conv.SetText(600000022);
			%Player.SetMissionFlag(20157,1300,%ThisNpcId++);									//设置任务目标完成进度+1
			%Player.updatemission(20157);
	}
}


//=============================落日神陵1层任务=======================================
function Mission_Begin_Process_20150(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20150_20153(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_Begin_Process_20151(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20150_20153(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_Begin_Process_20152(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20150_20153(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_Begin_Process_20153(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20150_20153(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_Begin_Process_20150_20153(%Npc,%Player,%Conv,%Param,%Mid)
{
	switch (%Mid)
	{
		case 20150:
			%ItemID = GetRandom(108020108,108020112);								//未修改，临时用陨仙窟的道具
			%Player.SetMissionFlag(20150,1100,%ItemID);								//设置物品ID
			%Player.SetMissionFlag(20150,1200,5);									//设置物品总数量
			%Player.SetMissionFlag(20150,1300,%Player.GetItemCount(%RandomId));	//设置物品当前数量
			%Player.updatemission(20150);
		case 20151:
			%SuperEnmityID = GetRandom(411291001,411291005);
			%Player.SetMissionFlag(20151,3100,%SuperEnmityID);						//设置怪物编号
			%Player.SetMissionFlag(20151,3200,7);									//设置怪物总数量
			%Player.SetMissionFlag(20151,3300,0);									//设置怪物已击败数量
			%Player.updatemission(20151);
		case 20152:
			%EnmityID = GetRandom(411291006,411291010);
			%Player.SetMissionFlag(20152,3100,%EnmityID);							//设置怪物编号
			%Player.SetMissionFlag(20152,3200,30);									//设置怪物总数量
			%Player.SetMissionFlag(20152,3300,0);									//设置怪物已击败数量
			%Player.updatemission(20152);
		case 20153:
			%NeedHelpNpcId = GetRandom(411290009,411290013);							//营救NPCID
			%Player.SetMissionFlag(20153,1100,%NeedHelpNpcId);
			%Player.SetMissionFlag(20153,1200,1);
			%Player.SetMissionFlag(20153,1300,0);
			%Player.UpdateMission(20153);
	}
}


//=============================落日神陵2层任务=======================================

function Mission_Begin_Process_20154(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20154_20157(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_Begin_Process_20155(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20154_20157(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_Begin_Process_20156(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20154_20157(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_Begin_Process_20157(%Npc,%Player,%Conv,%Param,%Mid){ Mission_Begin_Process_20154_20157(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_Begin_Process_20154_20157(%Npc,%Player,%Conv,%Param,%Mid)
{
	switch (%Mid)
	{
		case 20150:
			%ItemID = GetRandom(108020113,108020117);								//未修改，临时用陨仙窟的道具
			%Player.SetMissionFlag(20154,1100,%ItemID);								//设置物品ID
			%Player.SetMissionFlag(20154,1200,5);									//设置物品总数量
			%Player.SetMissionFlag(20154,1300,%Player.GetItemCount(%ItemID));		//设置物品当前数量
			%Player.updatemission(20154);
		case 20151:
			%SuperEnmityID = GetRandom(411291011,411291015);
			%Player.SetMissionFlag(20155,3100,%SuperEnmityID);						//设置怪物编号
			%Player.SetMissionFlag(20155,3200,7);									//设置怪物总数量
			%Player.SetMissionFlag(20155,3300,0);									//设置怪物已击败数量
			%Player.updatemission(20155);
		case 20152:
			%EnmityID = GetRandom(411291016,411291020);
			%Player.SetMissionFlag(20156,3100,%EnmityID);							//设置怪物编号
			%Player.SetMissionFlag(20156,3200,30);									//设置怪物总数量
			%Player.SetMissionFlag(20156,3300,0);									//设置怪物已击败数量
			%Player.updatemission(20156);
		case 20153:
			%NeedHelpNpcId = GetRandom(411290015,411290019);							//二层营救NPC
			%Player.SetMissionFlag(20157,1100,%NeedHelpNpcId);
			%Player.SetMissionFlag(20157,1200,1);
			%Player.SetMissionFlag(20157,1300,0);
			%Player.UpdateMission(20157);
	}
}