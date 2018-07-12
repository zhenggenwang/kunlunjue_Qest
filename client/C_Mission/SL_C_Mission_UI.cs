//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//客户端任务相关界面内显示的文本
//==================================================================================
//刷新任务或对话相关UI数据
//■■■■■■■■■■（添加、更新、删除、完成）任务的数据刷新■■■■■■■■■■■
//|+|■■■■■■■■■■创建任务已接界面（主）■■■■■■■■■■■■■■■■■■■
//|+|■■■■■■■■■■创建任务可接界面（主）■■■■■■■■■■■■■■■■■■■
//|+|■■■■■■■■■■创建任务共享界面（主）■■■■■■■■■■■■■■■■■■■
//|+|■■■■■■■■■■创建任务已接界面（辅）■■■■■■■■■■■■■■■■■■■
//|+|■■■■■■■■■■创建任务可接界面（辅）■■■■■■■■■■■■■■■■■■■

//|+|■■■■■■■■■■刷新任务已接界面（主）■■■■■■■■■■■■■■■■■■■
//|+|■■■■■■■■■■刷新任务可接界面（主）■■■■■■■■■■■■■■■■■■■
//|+|■■■■■■■■■■刷新任务共享界面（主）■■■■■■■■■■■■■■■■■■■

//|+|■■■■■■■■■■刷新任务已接界面（辅）■■■■■■■■■■■■■■■■■■■
//|+|■■■■■■■■■■刷新任务可接界面（辅）■■■■■■■■■■■■■■■■■■■

//|+|■■■■■■■■■■点击按XX排列任务触发■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■活动追踪界面操作■■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■添加任务时界面更新操作■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■更新任务时界面更新操作■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■删除任务时界面更新操作■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■获取任务全部内容文本■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■获取任务需求文本■■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■获取任务难度■■■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■获取任务完整名称■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■获取任务旗标、颜色、格式■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■获取任务【物品】类头说明■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■获取任务【使用】类头说明■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■获取任务【采集】类头说明■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■获取任务描述【永久】类头说明■■■■■■■■■■■■■■■■■
//■■■■■■■■■■获取任务描述【暂时】类头说明■■■■■■■■■■■■■■■■■

//■■■■■■■■■■【通用】获取任务归属地图■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■【通用】客户端寻路解析■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■■获取任务奖励信息■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■■清除全部界面ICON■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■■■更新任务触发■■■■■■■■■■■■■■■■■■■


//|+|■■■■■■■■■■（添加、更新、删除、完成）任务的数据刷新■■■■■■■■■■■
// 增加可接任务树节点
function AddCanAcceptTreeNode(%node,%text,%missionId,%click)
{
	return MissionTraceWnd_CanSelectMissionTree.init(%node,%text,%missionId,%click);
}

//－－－删除任务节点－－－
function RefreshMission(%Player,%op,%Mid)
{
	if (isobject(%Player) == 0)
		%Player = GetPlayer();

	//若该任务在任务data中【接交时特殊需求】一列的【接交任务时更新所有UI界面】值被勾选时触发
	%ConvText = GetMissionData(%Mid,$Mission_Data_Conv);
	if ((HasBit(%ConvText,8) > 0) && (%op != 99))
		RefreshMission(%Player,99,%Mid);

	//更新任务特殊事件处理
	RefreshMission_TeShu(%Mid,%op);

	switch (%op)
	{
		case 1: // 添加一个任务
			UIAddOneMission(%Player,%Mid);
			DeleteNodeForShareMission(%Player,%Mid);

			//更新地图与Npc头顶标记
			UpdateMissionEffect(%Player,%Mid,1);
			UpdateUITrackMissionEx();

			//设置章回界面
			MissionChapter(%Mid);

			//领取任务自动组队功能
			MissionSptAutoBuildTeam(%Mid);

			//自动跟随队长
			if (%Mid == 24000)
				AgreeTeamFollow();

		case 2:	// 更新一个任务
			UIUpdateOneMission(%Player,%Mid);
			//更新地图与Npc头顶标记
			UpdateMissionEffect(%Player,%Mid,1);
			UpdateUITrackMissionEx();

			//直接刷新已接界面
			CreateAcceptedMissionNode(%Player,%Mid,isOrderByMap(),true,0);

		case 4: // 删除一个任务
			UIDelOneMission(%Player,%Mid);
			//更新地图与Npc头顶标记
			UpdateMissionEffect(%Player,%Mid,1);
			UpdateUITrackMissionEx();

		case 6:	//完成一个任务
			//删除任务触发
			UIDelOneMission(%Player,%Mid);

			//更新地图与Npc头顶标记
			UpdateMissionEffect(%Player,%Mid,2);
			UpdateUITrackMissionEx();

		case 7: //更新所有任务数据
			echo( "更新所有任务数据===" @ %Player @ "=======" @ GetPlayer( ));
			if (isobject(%Player) == 1)
			{
				//更新地图与Npc头顶标记
				UpdateMissionEffect(%Player,0,0);
				UpdateUITrackMissionEx();

				Schedule(2000,0,"RefreshAcceptedMission",%Player);			//刷新已接界面（主）
				RefreshTraceMission(%Player);															//刷新已接界面（辅）

				Schedule(4000,0,"RefreshCanAcceptMission_L",%Player);	//刷新可接界面（主）
				Schedule(3000,0,"RefreshCanAcceptMission_K",%Player);	//刷新可接界面（辅）

				Schedule(3000,0,"OpenPlayerOperateCueWnd_7");

				$RefreshMission[7] = 2;
			}

		case 8: //切换地图触发
			//更新地图与Npc头顶标记
			UpdateMissionEffect(%Player,0,0);
			UpdateUITrackMissionEx();
			echo("$RefreshMission[7]  =======" @ $RefreshMission[7] @ "    %Player====" @ %Player);

			if ($RefreshMission[7] == 1 && isobject(%Player))
				RefreshMission(%Player,7,0);

		case 13: //更新所有共享任务数据
			RefreshShareMission(%Player);

		case 99: //升级更新任务可接数据
			//更新地图与Npc头顶标记
			UpdateMissionEffect(%Player,0,0);
			UpdateUITrackMissionEx();

			Schedule(2000,0,"RefreshAcceptedMission",%Player);//刷新已接界面（主）
			RefreshTraceMission(%Player);//刷新已接界面（辅）

			Schedule(4000,0,"RefreshCanAcceptMission_L",%Player);//刷新可接界面（主）
			Schedule(3000,0,"RefreshCanAcceptMission_K",%Player);//刷新可接界面（辅）

		default:
	}

	setMissionTraceWnd();
	CloseMisssionHover();//关闭任务热感界面
}

//－－－删除任务节点－－－
function DeleteNodeForShareMission(%Player,%Mid)
{
	%node = SingleWnd1_Tree3.findMissionTreeNode(%Mid);
	if (%node != 0)
		SingleWnd1_Tree3.clearChildItem(%node);
}


//|+|■■■■■■■■■■创建任务已接界面（主）■■■■■■■■■■■■■■■■■■■
function CreateAcceptedMissionNode(%Player,%Mid,%Mission_Map,%updateUI,%LeiXin)
{
	%node = SingleWnd1_Tree1.findMissionTreeNode(%Mid);
	if (%LeiXin == 0)
		SingleWnd1_Tree1.clearChildItem(%node);

	if (%Player.IsAcceptedMission(%Mid))
	{
		%kind       = GetMissionKind(%Mid);
		%Mid_LeiXin = $MissionKind[%kind,1];
		%MapName    = GetMissionMap(%Player,%Mid,1);
		%Mid_Kind   = GetMissionMap(%Player,%Mid,2);

		//设置任务界面（主）任务是否隐藏设置
		%Icon[1] = "<t>   </t>";
		if ((GetWord($DendriformMid[%Mid],2) == 1) || (%LeiXin == 0))
			%Icon[1] = $Icon[41] @ "<t> </t>";

		//设置任务完成图片
		if (CanDoThisMission(%Player,%Mid,2,0,0) $= "")
		{
			%Mid_Over = $Icon[91];

			%Mission_Name = GetMission_Name(%Player,%Mid,1);
			//echo( "strlen( %Mission_Name )==" @ strlen( %Mission_Name ) );
			%Blank = 18 - strlen(%Mission_Name);
			for (%i=0; %i< %Blank; %i++)
				%PaiXu = %PaiXu @ " ";
		}

		%Gesi[1] = "<t f='黑体' b='1' m='0' n='16' c='0xffffffff' o='0x010101ff'>";	//任务标题（白色）
		%Gesi[2] = "<t f='宋体' b='0' m='1' n='14' c='0xf3db69ff' o='0x010101ff'>";	//任务名称（黄色）
		%Gesi[3] = "<t f='宋体' b='0' m='1' n='14' c='0x00ff96ff' o='0x010101ff'>";	//任务名称（绿色）
		%Gesi[4] = "<t f='宋体' b='0' m='1' n='14' c='0x696668ff' o='0x010101ff'>";	//任务名称（灰色）


		%LvJ = GetMissionData(%Mid,$Mission_Data_LvJ);
		%LeveCa = %Player.GetLevel() - %LvJ;
		//若交任务等级小于自身20级则灰色
		//echo( "%LvJ====" @ %LvJ @ "   %LeveCa===" @ %LeveCa );
		if ((%LeveCa > 20) && (%LvJ != 0))
			%Mid_Name = %Gesi[4] @ GetMission_Name(%Player,%Mid,1);
		else if ((%LeveCa > 10) && (%LvJ != 0))
			%Mid_Name = %Gesi[3] @ GetMission_Name(%Player,%Mid,1);
		else
			%Mid_Name = %Gesi[2] @ GetMission_Name(%Player,%Mid,1);
		//echo( "%Mid_Name===" @ %Mid_Name );
		if (%LeiXin == 1)	//设置任务界面（主）单项任务
			SingleWnd1_Tree1.setItemText(%node,%Icon[1] @ %Mid_Name @ %PaiXu @ "</t>" @ %Mid_Over);
		else
		{
			//默认值，所有任务以任务类型创建树
			if (%Mission_Map == 0)
			{
				//创建任务树状1
				%Node[1] = AddTreeNode1(0," " @ %Gesi[1] @ %Mid_LeiXin @ "</t>",%kind,0,1);
				//只在创建时树状1记录
				if (%LeiXin == 0)$DendriformDefining[%Node[1]] = "1 " @ %kind @ " " @ 1;

				if (%Node[1] != 0)
				{
					//创建任务树状2
					%Node[2] = AddTreeNode1(%Node[1],%Icon[1] @ %Mid_Name @ %PaiXu @ "</t>" @ %Mid_Over,%Mid,1,0);
					if (%LeiXin == 0)
					{
						$DendriformDefining[%Node[2]] = 2 @ " " @ %Mid @ " " @ 1;
						$DendriformMid[%Mid] = "2 " @ %kind @ " " @ 1 @ " " @ %Node[2];
					}
				}
			}

			//修改值，所有任务以地图区分创建树
			if (%Mission_Map == 1)
			{
				//创建任务树状1
				%Node[1] = AddTreeNode1(0," " @ %Gesi[1] @ "【" @ %MapName @ "】</t>",%Mid_Kind,0,1);
				//只在创建时树状1记录
				if (%LeiXin == 0)$DendriformDefining[%Node[1]] = "1 " @ %Mid_Kind @ " " @ 1;

				if (%Node[1] != 0)
				{
					//创建任务树状2
					%Node[2] = AddTreeNode1(%Node[1],%Icon[1] @ %Mid_Name @ %PaiXu @ "</t>" @ %Mid_Over,%Mid,1,0);
					if (%LeiXin == 0)
					{
						$DendriformDefining[%Node[2]] = 2 @ " " @ %Mid @ " " @ 1;
						$DendriformMid[%Mid] = "2 " @ %Mid_Kind @ " " @ 1 @ " " @ %Node[2];
					}
				}
			}

			SingleWnd1_Tree1.expandToItem(0,1);

			if (%updateUI)
				SingleWnd1_Tree1.buildVisibleTree(true);
			setMissionTraceWnd();
		}
	}
}

//|+|■■■■■■■■■■创建任务可接界面（主）■■■■■■■■■■■■■■■■■■■
function CreateCanAcceptMissionNode_L(%Player,%Mid,%Mission_Map,%updateUI)
{
	//移除计时器变量
	deleteVariables("$MissionKeJie_Zhu_Schedule" @ %Mid);

	%Lv = %Player.GetLevel();
	%node = Singlewnd1_Tree2.findMissionTreeNode(%Mid);
	Singlewnd1_Tree2.clearChildItem(%node);

	%kind       	= GetMissionKind(%Mid);
	%Mid_LeiXin 	= $MissionKind[%kind,1];
	%MapName      = GetMissionMap(%Player,%Mid,1);
	%Mid_Kind     = GetMissionMap(%Player,%Mid,2);

	//主线颜色格式
	%Gesi[1] = "<t f='黑体' b='1' m='0' n='14' c='0xffffffff' o='0x010101ff'>";	//任务标题（白色）
	%Gesi[2] = "<t f='宋体' b='0' m='1' n='14' c='0xf3db69ff' o='0x010101ff'>";	//任务名称（黄色）

	//任务名称
	if (%Lv < GetMissionData(%Mid,$Mission_Data_LvA))
		%Mid_Name = $Get_Dialog_GeShi[31297] @ GetMission_Name(%Player,%Mid,1) @ "</t>";
	else
		%Mid_Name = %Gesi[2] @ GetMission_Name(%Player,%Mid,1) @ "</t>";

	//默认值，所有任务以任务类型创建树
	if (%Mission_Map == 0)
	{
		//echo( "%Mid_LeiXin===" @ %Mid_LeiXin );
		//任务归属的地图名称
		%Map = AddTreeNode2(0,%Gesi[1] @ %Mid_LeiXin @ "</t>",%kind,0,1);
		//任务名称
		AddTreeNode2(%Map,%Gesi[2] @ %Mid_Name @ "</t>" @ %Mid_Over,%Mid,1,0);
	}
	else
	{
		//任务类型名称
		%LeiXin = AddTreeNode2(0,%Gesi[1] @ "【" @ %MapName @ "】</t>",%Mid_Kind,0,1);
		//任务名称
		%LeiXin1 = AddTreeNode2(%LeiXin,%Gesi[2] @ %Mid_Name @ "</t>" @ %Mid_Over,%Mid,1,0);
	}

	Singlewnd1_Tree2.expandToItem(0,1);

	if (%updateUI)
		Singlewnd1_Tree2.buildVisibleTree(true);
}


//|+|■■■■■■■■■■创建任务共享界面（主）■■■■■■■■■■■■■■■■■■■
function CreateShareMissionNode(%Player,%Mid,%Mission_Map)
{
	%node = SingleWnd1_Tree3.findMissionTreeNode(%Mid);
	if (%node == 0)
	{
		%kind       = GetMissionKind(%Mid);
		%Mid_LeiXin = $MissionKind[%kind,1];
		%MapName    = GetMissionMap(%Player,%Mid,1);
		%Mid_Kind   = GetMissionMap(%Player,%Mid,2);

		//主线颜色格式
		%Gesi = $Get_Dialog_GeShi[31292];

		//默认值，所有任务以任务类型创建树
		if (%Mission_Map == 0)
		{
			%rootnode = AddTreeNode3(0,$Get_Dialog_GeShi[31201] @ %Mid_LeiXin @ "</t>",%kind,0,1);
			if (%rootnode != 0)
			{
				if (%kind == 3)
					AddTreeNode3(%rootnode,%Gesi @ GetMission_Name(%Player,%Mid,1) @ "</t>",%Mid,1,0);
				else
				{
					//任务归属的地图名称
					%Map = AddTreeNode3(%rootnode,$Get_Dialog_GeShi[31298] @ "【" @ %MapName @ "】</t>",%kind @ GetMissionData(%Mid,$Mission_Data_Map_Area),0,1);
					//任务名称
					AddTreeNode3(%Map,%Gesi @ GetMission_Name(%Player,%Mid,1) @ "</t>",%Mid,1,0);
				}
			}
		}

		//修改值，所有任务以地图区分创建树
		if (%Mission_Map == 1)
		{
			if (%kind == 3)
			{
				%rootnode = AddTreeNode3(0,$Get_Dialog_GeShi[31201] @ %Mid_LeiXin @ "</t>",%kind,0,1);
				if (%rootnode != 0)
					AddTreeNode3(%rootnode,%Gesi @ GetMission_Name(%Player,%Mid,1) @ "</t>",%Mid,1,0);
			}
			else
			{
				%rootnode = AddTreeNode3(0,$Get_Dialog_GeShi[31298] @ "【" @ %MapName @ "】</t>",GetMissionData(%Mid,$Mission_Data_Map_Area),0,1);
				if (%rootnode != 0)
				{
					//任务类型名称
					%LeiXin = AddTreeNode3(%rootnode,$Get_Dialog_GeShi[31201] @ %Mid_LeiXin @ "</t>",GetMissionData(%Mid,$Mission_Data_Map_Area) @ %kind,0,1);
					//任务名称
					AddTreeNode3(%LeiXin,%Gesi @ GetMission_Name(%Player,%Mid,1) @ "</t>",%Mid,1,0);
				}
			}
		}
	}
}

//|+|■■■■■■■■■■创建任务已接界面（辅）■■■■■■■■■■■■■■■■■■■

function CreateTraceMissionNode(%Player,%Mid,%updateUI)
{
	if (GetWord($DendriformMid[%Mid],2) == 0)
		return;

	%Mission_ZT = CanDoThisMission(%Player,%Mid,2,0,0);
	%kind       = GetMissionKind(%Mid);
	%Mid_LeiXin = $MissionKind[%kind,1];

	%Gesi[1] = "<t f='宋体' b='0' m='1' n='14' c='0xf3db69ff' o='0x010101ff'>";	//任务名称（黄色）
	%Gesi[2] = "<t f='宋体' b='0' m='1' n='14' c='0x00ff64ff' o='0x010101ff'>";	//任务名称（绿色）
	%Gesi[3] = "<t f='宋体' b='0' m='1' n='14' c='0xff6e00ff' o='0x010101ff'>";	//任务名称（橙色）

	//显示任务追踪的名字以及状态
	if (%Mission_ZT $= "")
	{
		%Blank[1] = "  ";
		%Mid_Name = %Gesi[2] @ GetMission_Name(%Player,%Mid,2) @ "</t>";
		%JMission_Npc = GetMission_Flag(%Player,%Mid,"Npc",99,6);
	}
	else
	{
		if (%kind == 10)%Mid_Name = %Gesi[3] @ GetMission_Name(%Player,%Mid,2);
		else %Mid_Name = %Gesi[1] @ GetMission_Name(%Player,%Mid,2);
	}
	//任务名称
	%Txt = "<c cid='ShowMissionInfoButton' cmd='\"MissionTraceHover(" @ %Mid @ ");\",\"" @ %Mid_Name @ "</t>\",\"GuiMissionTraceButtonProfile4\"' cf='createButton' />";

	if (%Mission_ZT $= "")
	{
		%Blank[2] = 85 - strlen(%blank[1] @ %Mid_Name @ GetNpcData(GetMissionData(%Mid,$Mission_Data_NpcZ),1));
		for (%i=0; %i< %Blank[2]; %i++)
			%PaiXu = %PaiXu @ " ";

		%Symbol = "<t>" @ %PaiXu @ "</t>" @ $Icon[91];
	}

	//任务名字
	%node = AddTraceTreeNode(0,%Blank[1] @ %Txt @ %JMission_Npc @ %Symbol,%Mid,0);

	//显示任务追踪的目标
	if (%node != 0)
	{
		//清除所有结点
		MissionTraceWnd_Tree.removeAllChildren(%node);
		%Num = 0;

		//所有9100的旗标都显示出去
		for (%x = 0; %x < 50; %x++)
		{
			%ii = 9100;
			if (%Player.GetMissionFlag(%Mid,%ii + %x) > 0)
			{
				%Num = %Num + 1;
				%NodeId = %Num * 100;
				%GetMissionNeedText = GetMissionNeedText(%Player,%Mid,%ii + %x);
				if (%GetMissionNeedText !$= "")
					AddTraceTreeNode(%node,%GetMissionNeedText,%Mid @ %NodeId,0);
			}
			else
				break;
		}

		//如果有特殊旗标，但完成任务，任务名称对齐处理
		if ((%Num > 0) && (%Mission_ZT $= ""))
			MissionTraceWnd_Tree.setItemText(%node,%Txt @ %JMission_Npc @ %Symbol);

		if (%Mission_ZT !$= "")
		{
			for (%i = 0; %i < 8; %i++)
			{
				switch (%i)
				{
					case 0:%ii = 9000;//文字说明
					case 1:%ii = 2250;//运输道具
					case 2:%ii = 2200;//搜集道具
					case 3:%ii = 1200;//寻找目标
					case 4:%ii = 3200;//杀怪计数
					case 5:%ii = 1250;//寻找特殊目标
					case 6:%ii = 8000;//特殊数值
					case 7:%ii = 2230;//采集编号
				}

				for (%x = 0; %x < 50; %x++)
				{
					if (%Player.GetMissionFlag(%Mid,%ii + %x) > 0)
					{
						%Num = %Num + 1;
						%NodeId = %Num * 100;

						%GetMissionNeedText = GetMissionNeedText(%Player,%Mid,%ii + %x);
						if (%GetMissionNeedText !$= "")
							AddTraceTreeNode(%node,%GetMissionNeedText,%Mid @ %NodeId,0);
					}
					else
						break;
				}
			}
		}

		if (%updateUI)
			MissionTraceWnd_Tree.buildVisibleTree(0);
	}
}

CreateTraceMissionNode(getplayer(),20148,true);

//|+|■■■■■■■■■■创建任务可接界面（辅）■■■■■■■■■■■■■■■■■■■
//－－－节点创建－－－
function CreateCanAcceptMissionNode_K(%Player,%NoUse)
{
	%Lv = %Player.GetLevel();
	%MapID = GetMapId();

	%MissionID[1] = GetCanSeeMission(%Lv);
	%AcceptCountNum = GetWordCount(%MissionID[1]);

	if (%NoUse == 0)
	{
		//遍历玩家所有已接任务，将【活动任务】添加到树列表
		for (%i = 0; %i < %AcceptCountNum; %i++)
		{
			%Mid = GetWord(%MissionID[1],%i);
			if (GetMissionData(%Mid,$Mission_Data_Map_Area) == %MapID)
			{
				if (CanDoThisMission(%Player,%Mid,1,2,0) $= "")
				{
					//删除倒计时
					if ($MissionKeJie_Fu_Schedule[%Mid] > 0)
						Cancel($MissionKeJie_Fu_Schedule[%Mid]);

					//更新任务
					$MissionKeJie_Fu_Schedule[%Mid] = Schedule(%S++ * 500,0,"AddOneCanAcceptMissionNode",%Player,%Mid,true);
				}
			}
			else
				%MissionID[2] = (%MissionID[2] $= "") ? %Mid : %MissionID[2] @ " " @ %Mid;
		}

		//显示玩家剩余所有已接任务，添加到树列表
		%AcceptCountNum = GetWordCount(%MissionID[2]);
		for (%i = 0; %i < %AcceptCountNum; %i++)
		{
			%Mid = GetWord(%MissionID[2],%i);

			//在任务追踪树上创建一个任务结点
			if (CanDoThisMission(%Player,%Mid,1,2,0) $= "")
			{
				//删除倒计时
				if ($MissionKeJie_Fu_Schedule[%Mid] > 0)
					Cancel($MissionKeJie_Fu_Schedule[%Mid]);

				$MissionKeJie_Fu_Schedule[%Mid] = $MissionKeJie_Fu_Schedule[%Mid] = Schedule(%S++ * 500,0,"AddOneCanAcceptMissionNode",%Player,%Mid,true);
			}
		}

		MissionTraceWnd_CanSelectMissionTree.buildVisibleTree(0);
	}
	else
	{
		%Mid = %NoUse;
		if (CanDoThisMission(%Player,%Mid,1,2,0) $= "")
			AddOneCanAcceptMissionNode(%Player,%Mid,true);
	}
}
// 判断是否按地图排列任务
function isOrderByMap()
{
	return (MissionWndGui_ArrayMissionButton.getText() !$= "按地图排列任务");
}

function setMissionTraceWnd()
{
	//MissionTraceWnd.setWidth( $missionTraceWidth );
	//TraceTreeBackWnd.setWidth( $missionTraceWidth-3 );
	//TraceTreeBackWndExt.setWidth( $missionTraceWidth-3 );
	//SingleWnd2_ScrollCtrl.setWidth( $missionTraceWidth-13 );
	//SingleWnd2_ScrollCtrl_CanSelectMission.setWidth( $missionTraceWidth-13 );

	//MissionTraceWnd.setHeight( $missionTraceHeight+25 );
	//TraceTreeBackWnd.setHeight( $missionTraceHeight );
	//TraceTreeBackWndExt.setHeight( $missionTraceHeight );
	//SingleWnd2_ScrollCtrl.setHeight( $missionTraceHeight );
	//SingleWnd2_ScrollCtrl_CanSelectMission.setHeight( $missionTraceHeight );

	TraceTreeBackWnd.setAlpha(255-$missionTraceAlpha);
}
//－－－节点创建－－－
function AddOneCanAcceptMissionNode(%Player,%Mid,%updateUI)
{
	//移除计时器变量
	deleteVariables("$MissionKeJie_Fu_Schedule" @ %Mid);

	%Lv = %Player.GetLevel();
	%Mission_Map = isOrderByMap();

	%kind       = GetMissionKind(%Mid);
	%Mid_Kind     = GetMissionMap(%Player,%Mid,2);

	if (%Mission_Map == 0)
	{
		%MapName = $MissionKind[%kind,1];
		%rootnode = MissionTraceWnd_CanSelectMissionTree.findMissionTreeNode(%kind);
		if (%rootnode == 0)
			%rootnode = AddCanAcceptTreeNode(0,$Get_Dialog_GeShi[31298] @  %MapName @ "</t>",%kind,0);
	}
	else
	{
		%MapName      = GetMissionMap(%Player,%Mid,1);
		%rootnode = MissionTraceWnd_CanSelectMissionTree.findMissionTreeNode(%Mid_Kind);
		if (%rootnode == 0)
			%rootnode = AddCanAcceptTreeNode(0,$Get_Dialog_GeShi[31298] @ "【" @ %MapName @ "】</t>",%Mid_Kind,0);
	}

	if (%rootnode != 0)
	{
		switch (%Mid)
		{
			case 0:%Map = 0; %NpcA = 0;
			default:
				%NpcA = GetMissionData(%Mid,$Mission_Data_NpcA);
				%Map  = %Mid_Kind;
		}

		%MissionNode = MissionTraceWnd_CanSelectMissionTree.findMissionTreeNode(%Mid);
		if (%MissionNode == 0)
		{
			//任务名称
			if (%Lv < GetMissionData(%Mid,$Mission_Data_LvA))
				%Mid_Name = $Get_Dialog_GeShi[31297] @ GetMission_Name(%Player,%Mid,1) @ "</t>";
			else
			{
				if (GetMissionData(%Mid,$Mission_Data_Type) == 1)
					%Mid_Name = $Get_Dialog_GeShi[31292] @ GetMission_Name(%Player,%Mid,1) @ "</t>";
				else
					%Mid_Name = $Get_Dialog_GeShi[31296] @ GetMission_Name(%Player,%Mid,1) @ "</t>";
			}

			%TxtA = "<c cid='ShowMissionInfoButton' cmd='\"MissionTraceHover("@%Mid@");\",\"" @ %Mid_Name @ "\",\"GuiMissionTraceButtonProfile4\"' cf='createButton' />";
			%TxtB = "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(" @ %NpcA @ ");\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(%NpcA,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />";

			%Mission_Name = AddCanAcceptTreeNode(%rootnode,%TxtA @ %TxtB,%Mid,0);
		}
	}

	if (%updateUI)
		MissionTraceWnd_CanSelectMissionTree.buildVisibleTree(0);
}



//|+|■■■■■■■■■■刷新任务已接界面（主）■■■■■■■■■■■■■■■■■■■
function RefreshAcceptedMission(%Player)
{
	// 先清空树，重置树的列表
	Singlewnd1_Tree1.clearitem();

	// 任务已接数量
	%AcceptCount = %Player.GetAcceptedMission();

	// 刷新UI的已接任务数量
	RefreshMissionNum(%AcceptCount);

	// 刷新UI的任务描述,读取任务信息，执行GetMissionText函数
	RefreshMissionDesc(-1);

	// 如果将任务以地图归类按钮打开
	%Mission_Map = (isOrderByMap()) ? 1 : 0;

	//遍历玩家所有已接任务，将添加到树列表
	%AcceptCountNum = %Player.GetAcceptedMission();

	%MapID = GetSubStr(GetZoneID(),0,4);
	%ListA = "";
	%ListB = "";
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = %Player.GetMission(%i);
		%MissionMap = GetSubStr(GetMissionData(%Mid,$Mission_Data_Map_Area),1,4);
		if (%MissionMap == %MapID)
			%ListA = %Mid @ " " @ %ListA;
		else
			%ListB = %Mid @ " " @ %ListB;
	}
	%List = %ListA @ %ListB;
	//echo( "%List===" @ %List );
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = GetWord(%List,%i);

		//在已接任务树上创建一个任务的树结点
		CreateAcceptedMissionNode(%Player,%Mid,%Mission_Map,true,%LeiXin);
		//echo( "%Player=== " @ %Player @ "  %Mid ===" @ %Mid @ "%Mission_Map====" @ %Mission_Map @ "     %LeiXin ===" @ %LeiXin );
	}

	// 缺省展开已接任务树
	SingleWnd1_Tree1.expandToItem(0,1);
	SingleWnd1_Tree1.buildVisibleTree(false);
	setMissionTraceWnd();

	//刷新任务追踪界面
	RefreshTraceMission(%Player);
}

//|+|■■■■■■■■■■刷新任务可接界面（主）■■■■■■■■■■■■■■■■■■■
function RefreshCanAcceptMission_L(%Player)
{
	//获取玩家等级
	%Leve = %Player.GetLevel();

	//清除所有节点
	Singlewnd1_Tree2.clearitem();

	//对应相应地图排列
	%Mission_Map = (isOrderByMap()) ? 1 : 0;

	%Lv_Mission = GetCanSeeMission(%Leve);
	%AcceptCountNum = GetWordCount(%Lv_Mission);

	//echo( "%List===" @ %List );
	//遍历玩家所有已接任务，添加到树列表
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = GetWord(%Lv_Mission,%i);

		//删除倒计时
		if ($MissionKeJie_Zhu_Schedule[%Mid] > 0)
			Cancel($MissionKeJie_Zhu_Schedule[%Mid]);

		//在可接任务树上创建一个任务的树结点
		if (CanDoThisMission(%Player,%Mid,1,2,0) $= "")
			$MissionKeJie_Zhu_Schedule[%Mid] = Schedule(%S++ * 500,0,"CreateCanAcceptMissionNode_L",%Player,%Mid,%Mission_Map,true);
	}

	// 缺省展开可接任务树
	Singlewnd1_Tree2.expandToItem(0,1);
	Singlewnd1_Tree2.buildVisibleTree(false);
}

//|+|■■■■■■■■■■刷新任务共享界面（主）■■■■■■■■■■■■■■■■■■■
function RefreshShareMission(%Player)
{

}

//|+|■■■■■■■■■■刷新任务已接界面（辅）■■■■■■■■■■■■■■■■■■■
function RefreshTraceMission(%Player)
{
	MissionTraceWnd_Tree.clearitem();
	//echo("========刷新任务已接界面====");
	//遍历玩家所有已接任务，将【完成的主线任务】添加到树列表
	%AcceptCountNum = %Player.GetAcceptedMission();

	%MapID = GetSubStr(GetZoneID(),0,4);
	%ListA = "";
	%ListB = "";
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = %Player.GetMission(%i);
		%MissionMap = GetSubStr(GetMissionData(%Mid,$Mission_Data_Map_Area),1,4);
		if (%MissionMap == %MapID)
			%ListA = %Mid @ " " @ %ListA;
		else
			%ListB = %Mid @ " " @ %ListB;
	}
	%List = %ListA @ %ListB;
	//echo( "%List===" @ %List );

	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = GetWord(%List,%i);
		if ((GetMissionData(%Mid,$Mission_Data_Type) == 1) && (CanDoThisMission(%Player,%Mid,2,0,0) $= ""))
		{
			if ( GetMissionData( %Mid, $Mission_Data_Map_Area ) $= "810100100"|| GetMissionData( %Mid, $Mission_Data_Map_Area ) $= "810010100" )
				GotoFinishMissIonpath(%Mid);
			CreateTraceMissionNode(%Player,%Mid,true);
		}
		else
			%MissionID[1] = (%MissionID[1] $= "") ? %Mid : %MissionID[1] @ " " @ %Mid;
	}
	//遍历玩家所有已接任务，将【主线任务】添加到树列表
	%AcceptCountNum = GetWordCount(%MissionID[1]);
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = GetWord(%MissionID[1],%i);
		if (GetMissionData(%Mid,$Mission_Data_Type) == 1)
			CreateTraceMissionNode(%Player,%Mid,true);
		else
			%MissionID[2] = (%MissionID[2] $= "") ? %Mid : %MissionID[2] @ " " @ %Mid;
	}

	//遍历玩家所有已接任务，将完成的任务先显示
	%AcceptCountNum = GetWordCount(%MissionID[2]);
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = GetWord(%MissionID[2],%i);
		if (CanDoThisMission(%Player,%Mid,2,0,0) $= "")
			CreateTraceMissionNode(%Player,%Mid,true);
		else
			%MissionID[3] = (%MissionID[3] $= "") ? %Mid : %MissionID[3] @ " " @ %Mid;
	}

	//遍历玩家所有已接任务，将【活动任务】添加到树列表
	%AcceptCountNum = GetWordCount(%MissionID[3]);
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = GetWord(%MissionID[3],%i);
		if (GetMissionData(%Mid,$Mission_Data_Type) == 6)
			CreateTraceMissionNode(%Player,%Mid,true);
		else
			%MissionID[4] = (%MissionID[4] $= "") ? %Mid : %MissionID[4] @ " " @ %Mid;
	}

	//显示玩家剩余所有已接任务，添加到树列表
	%AcceptCountNum = GetWordCount(%MissionID[4]);
	for (%i = 0; %i < %AcceptCountNum; %i++)
	{
		%Mid = GetWord(%MissionID[4],%i);
		//在任务追踪树上创建一个任务结点
		CreateTraceMissionNode(%Player,%Mid,true);
	}

	if (%AcceptCount != 0)
	{
		MissionTraceWnd_Tree.expandToItem(0,1);
		MissionTraceWnd_Tree.buildVisibleTree(false);
	}


}

//|+|■■■■■■■■■■刷新任务可接界面（辅）■■■■■■■■■■■■■■■■■■■
function RefreshCanAcceptMission_K(%Player)
{
	// 清除所有节点
	MissionTraceWnd_CanSelectMissionTree.clearitem();
	// 在任务追踪树上创建一个任务结点
	CreateCanAcceptMissionNode_K(%Player,0);
	// 展开节点
	MissionTraceWnd_CanSelectMissionTree.expandToItem(0,1);
	MissionTraceWnd_CanSelectMissionTree.buildVisibleTree(false);
}

//|+|■■■■■■■■■■点击按XX排列任务触发■■■■■■■■■■■■■■■■■■■■
function CheckFilterMission()
{
	%Player = GetPlayer();
	if (isOrderByMap())
		MissionWndGui_ArrayMissionButton.setText("按地图排列任务");
	else
		MissionWndGui_ArrayMissionButton.setText("按类型排列任务");

	RefreshAcceptedMission(%Player);	//刷新已接界面（主）
	RefreshTraceMission(%Player);			//刷新已接界面（辅）

	Schedule(1000,0,"RefreshCanAcceptMission_L",%Player);	//刷新可接界面（主）
	Schedule(1000,0,"RefreshCanAcceptMission_K",%Player);	//刷新可接界面（辅）
}

//■■■■■■■■■■活动追踪界面操作■■■■■■■■■■■■■■■■■■■■■■■
function uiUpdatePartyTraceWndTree(%par,%par1,%par2,%par3,%par4,%par5)
{
}

//■■■■■■■■■■添加任务时界面更新操作■■■■■■■■■■■■■■■■■■■■
function UIAddOneMission(%Player,%Mid)
{

	//putout("添加任务时界面更新操作====");
	// 播放任务音效
	PlayOnceSound(U_021);

	// 刷新UI的已接任务数量
	RefreshMissionNum(%Player.GetAcceptedMission());

	//----------------------------------------------------------------------------//
	//-------------------------任务界面-------------------------------------------//
	//----------------------------------------------------------------------------//

	// 如果将任务以地图归类按钮打开
	if (isOrderByMap())
		%Mission_Map = 1;
	else
		%Mission_Map = 0;

	// 在已接任务树上创建一个任务的树结点
	CreateAcceptedMissionNode(%Player,%Mid,%Mission_Map,true,0);

	// 删除任务界面【可接任务】树上的节点
	%node1 = Singlewnd1_Tree2.findMissionTreeNode(%Mid);
	if (%node1 != 0)
		Singlewnd1_Tree2.clearChildItem(%node1);

	// 删除前置额外任务界面【可接任务】树上的节点
	%Back_A = GetMissionData(%Mid,$Mission_Data_Back_A);
	%Back_A_Num = GetWordCount(%Back_A,";");
	if (%Back_A !$= "0")
		for (%i = 0; %i < %Back_A_Num; %i++)
		{
			%mission = GetWord(%Back_A,%i,";");

			%node2_1 = Singlewnd1_Tree2.findMissionTreeNode(%mission);
			if (%node2_1 != 0)
				Singlewnd1_Tree2.clearChildItem(%node2_1);
		}

	// 缺省展开所有任务树
	SingleWnd1_Tree1.expandToItem(0,1);
	SingleWnd1_Tree2.expandToItem(0,1);

	SingleWnd1_Tree1.buildVisibleTree(false);
	SingleWnd1_Tree2.buildVisibleTree(false);
	// 若“任务信息”界面是可见的，刷新任务描述
	RefreshMissionDesc(%Mid);

	//----------------------------------------------------------------------------//
	//-------------------------任务追踪界面-------------------------------------------//
	//----------------------------------------------------------------------------//
	// 在任务追踪树上创建一个任务结点
	RefreshTraceMission(%Player);

	// 从追踪界面的【可接】树上移除一个任务结点
	%node2 = MissionTraceWnd_CanSelectMissionTree.findMissionTreeNode(%Mid);
	if (%node2 != 0)
		MissionTraceWnd_CanSelectMissionTree.clearChildItem(%node2);

	// 从追踪界面的【可接】树上移除一个前置额外任务结点
	%Back_A = GetMissionData(%Mid,$Mission_Data_Back_A);//Mission_Data_Back_A
	%Back_A_Num = GetWordCount(%Back_A,";");
	if (%Back_A !$= "0")
		for (%i = 0; %i < %Back_A_Num; %i++)
		{
			%mission = GetWord(%Back_A,%i,";");

			%node2_1 = MissionTraceWnd_CanSelectMissionTree.findMissionTreeNode(%mission);
			if (%node2_1 != 0)
				MissionTraceWnd_CanSelectMissionTree.clearChildItem(%node2_1);
		}

	MissionTraceWnd_Tree.buildVisibleTree(false);
	MissionTraceWnd_CanSelectMissionTree.buildVisibleTree(false);
}

//■■■■■■■■■■更新任务时界面更新操作■■■■■■■■■■■■■■■■■■■■
function UIUpdateOneMission(%Player,%Mid)
{
	RefreshMissionDesc(%Mid);

	// 删除任务界面【可接任务】树上的节点
	%node1 = Singlewnd1_Tree2.findMissionTreeNode(%Mid);
	if (%node1 != 0)
	{
		Singlewnd1_Tree2.clearChildItem(%node1);
		Singlewnd1_Tree2.buildVisibleTree(false);
	}

	//在任务追踪树上创建一个任务结点
	RefreshTraceMission(%Player);

	// 从追踪界面的【可接】树上移除一个任务结点
	%node2 = MissionTraceWnd_CanSelectMissionTree.findMissionTreeNode(%Mid);
	if (%node2 != 0)
	{
		MissionTraceWnd_CanSelectMissionTree.clearChildItem(%node2);
		MissionTraceWnd_CanSelectMissionTree.buildVisibleTree(false);
	}
}

//■■■■■■■■■■删除任务时界面更新操作■■■■■■■■■■■■■■■■■■■■
function UIDelOneMission(%Player,%Mid)
{
	if ($CurrentMissionID == %Mid)
		$CurrentMissionID = -1;

	// 刷新UI的已接任务数量
	RefreshMissionNum(%Player.GetAcceptedMission());

	// 从任务界面【已接任务】树上移除一个任务结点
	%node = SingleWnd1_Tree1.findMissionTreeNode(%Mid);
	SingleWnd1_Tree1.clearChildItem(%node);

	//从任务界面【可接任务】树上添加一个任务结点
	if (isOrderByMap())
		%Mission_Map = 1;
	else
		%Mission_Map = 0;

	//添加当前任务
	if (CanDoThisMission(%Player,%Mid,1,2,0) $= "")
		CreateCanAcceptMissionNode_L(%Player,%Mid,%Mission_Map,true);

	// 添加可能的后续任务
	%NextMission = GetNextMission(%Mid);
	if (%NextMission !$= "")
	{
		%MidNum = GetWordCount(%NextMission);

		for (%i = 0; %i < %MidNum; %i++)
		{
			%MidNext = GetWord(%NextMission,%i);
			if (CanDoThisMission(%Player,%Mid,1,2,0) $= "")
				CreateCanAcceptMissionNode_L(%Player,%MidNext,%Mission_Map,true);
		}
	}

	//若“任务信息”界面是可视的
	if (SingleWnd2_ShowMissionInfo.isVisible())
		RefreshMissionDesc(%Mid);

	//从追踪界面【已接】树上移除一个任务结点
	%node = MissionTraceWnd_Tree.findMissionTreeNode(%Mid);
	MissionTraceWnd_Tree.clearChildItem(%node);

	//在追踪界面【可接】树上创建一个任务结点
	CreateCanAcceptMissionNode_K(%Player,0);

	//刷新任务树
	SingleWnd1_Tree1.buildVisibleTree(false);
	SingleWnd1_Tree2.buildVisibleTree(false);

	MissionTraceWnd_Tree.buildVisibleTree(false);
	setMissionTraceWnd();
}

//■■■■■■■■■■获取任务全部内容文本■■■■■■■■■■■■■■■■■■■■■
function GetMissionText(%Player,%Mid)
{
	if ((strlen(%Mid) >= 6)||(strlen(%Mid) <= 1))
		return "";

	if (strlen(%Mid) <= 4)
		%Mid = "8880" @ %Mid;
	else
		%Mid = "888" @ %Mid;

	return GetDialogText(0,%Player,%Mid,0);
}

//■■■■■■■■■■获取任务需求文本■■■■■■■■■■■■■■■■■■■■■■■
function GetMissionNeedText(%Player,%Mid,%Type)
{
	if (%Type < 9999)
	{
		if ((%Type >= 1200)&&(%Type < 1250)&&(%Player.GetMissionFlag(%Mid,%Type) > 0))
			return GetMission_Flag(%Player,%Mid,"Target",%Type - 1200,5);

		if ((%Type >= 1250)&&(%Type < 1300)&&(%Player.GetMissionFlag(%Mid,%Type) > 0))
			return GetMission_Flag(%Player,%Mid,"Npc",%Type - 1250,5);

		if ((%Type >= 2200)&&(%Type < 2230)&&(%Player.GetMissionFlag(%Mid,%Type) > 0))
			return GetMission_Flag(%Player,%Mid,"ItemGet",%Type - 2200,5);

		if ((%Type >= 2230)&&(%Type < 2250)&&(%Player.GetMissionFlag(%Mid,%Type) > 0))
			return GetMission_Flag(%Player,%Mid,"Collect",%Type - 2230,5);

		if ((%Type >= 2250)&&(%Type < 2300)&&(%Player.GetMissionFlag(%Mid,%Type) > 0))
			return GetMission_Flag(%Player,%Mid,"ItemAdd",%Type - 2250,5);

		if ((%Type >= 3200)&&(%Type < 3300)&&(%Player.GetMissionFlag(%Mid,%Type) > 0))
			return GetMission_Flag(%Player,%Mid,"MonsterKill",%Type - 3200,5);

		if ((%Type >= 8000)&&(%Type < 9000)&&(%Player.GetMissionFlag(%Mid,%Type) > 0))
			return GetMission_Flag(%Player,%Mid,"Step",%Type - 8000,5);

		if ((%Type >= 9000)&&(%Type < 9100)&&(%Player.GetMissionFlag(%Mid,%Type) > 0))
			return GetMission_Flag(%Player,%Mid,"Test",%Type - 9000,5);

		if ((%Type >= 9100)&&(%Type < 9200)&&(%Player.GetMissionFlag(%Mid,%Type) > 0))
			return GetMission_Flag(%Player,%Mid,"forever",%Type - 9100,5);
	}

	if (%Type == 9999)
	{
		%TxtA = "";
		for (%i = 0; %i < 9; %i++)
		{
			switch (%i)
			{
				case 0:%ii = 9100;//文字描述
				case 1:%ii = 9000;//文字描述
				case 2:%ii = 2250;//运输道具
				case 3:%ii = 2200;//搜集道具
				case 4:%ii = 1200;//寻找目标
				case 5:%ii = 3200;//杀怪计数
				case 6:%ii = 1250;//寻找特殊目标
				case 7:%ii = 8000;//特殊数值
				case 8:%ii = 2230;//采集编号
			}

			for (%x = 0; %x < 50; %x++)
			{
				if (%Player.GetMissionFlag(%Mid,%ii + %x) > 0)
				{
					%GetMissionNeedText = GetMissionNeedText(%Player,%Mid,%ii + %x);
					if (%GetMissionNeedText !$= "")
						%TxtA = %TxtA @ GetMissionNeedText(%Player,%Mid,%ii + %x) @ "<b/>";
				}
				else
					break;
			}
		}

		%TxtZ = GetMission_Flag(%Player,%Mid,"Npc",99,4) @ "<b/>";
		return %TxtA @ %TxtZ;
	}

	return "GetMissionNeedText = 错误 Player【"@%Player@"】Mid【"@%Mid@"】Type【"@%Type@"】";
}

//■■■■■■■■■■获取任务难度■■■■■■■■■■■■■■■■■■■■■■■■
function GetMission_NanDu(%Mid)
{
	%Png1 = isFile("gameres/gui/images/GUIWindow26_1_010.png");
	%Png2 = isFile("gameres/gui/images/GUIWindow26_1_011.png");

	if ((%Mid == 20002)||(%Mid == 20003))
	{
		%Player = GetPlayer();

		if (%Player.GetLevel() >= 10){ %NanDu1 = 1; }
		if (%Player.GetLevel() >= 20){ %NanDu1 = 1; }
		if (%Player.GetLevel() >= 30){ %NanDu1 = 2; }
		if (%Player.GetLevel() >= 40){ %NanDu1 = 2; }
	}
	else
		%NanDu1 = GetMissionData(%Mid,$Mission_Data_NanDu);

	%NanDu2 = 9 - %NanDu1;

	%R1 = "";
	%R2 = "";

	if ((%Png1 == 1)&&(%Png2 == 1))
	{
		for (%i = 0; %i < %NanDu1; %i++)
			%R1 = %R1 @ "<i s='gameres/gui/images/GUIWindow26_1_010.png' w='16' h='16'/>";

		for (%i = 0; %i < %NanDu2; %i++)
			%R2 = %R2 @ "<i s='gameres/gui/images/GUIWindow26_1_011.png' w='16' h='16'/>";

		return %R1 @ %R2;
	}
	else
	{
		for (%i = 0; %i < %NanDu1; %i++)
			%R1 = %R1 @ "★";

		for (%i = 0; %i < %NanDu2; %i++)
			%R2 = %R2 @ "☆";

		return $Get_Dialog_GeShi[31206] @ %R1 @ "</t> <t>" @ %R2 @ "</t>";
	}

	return "【图片数据错误】<b/>";
}

//■■■■■■■■■■获取任务完整名称■■■■■■■■■■■■■■■■■■■■■■
function GetMission_Name(%Player,%Mid,%Type)
{
	if (%Player == 0)
		%Player = GetPlayer();

	%Lv = GetMissionData(%Mid,$Mission_Data_LvJ);
	%Lv_P = %Player.GetLevel();
	%kind	= GetMissionKind(%Mid);

	if (%Lv == 0)
		%Lv = %Lv_P;

	%Mission_Name = "[" @ %Lv @ "] " @ GetMissionData(%Mid,$Mission_Data_Name);

	if (%Type == 0)
		return $Get_Dialog_GeShi[31800] @ %Mission_Name @ "</t>";

	else if (%Type == 1)
		return %Mission_Name;

	else if (%Type == 3)
		return %Mission_Name;

	//任务已接界面（辅助）
	else if (%Type == 2)
	{
		$Mission_Name = GetMissionData(%Mid,$Mission_Data_Name);
		%Mun = 9 - strlen($Mission_Name);

		for (%i = 0; %i <= %Mun; %i++)
			%KongGe = %KongGe @ " ";

		return "[" @ $MissionKind[%kind,2] @ "]" @ $Mission_Name;
	}
}

//■■■■■■■■■■获取任务旗标、颜色、格式■■■■■■■■■■■■■■■■■■
//－－－获取NpcA－－－
//－－－获取NpcZ－－－
function GetMission_Flag(%Player,%Mid,%Type,%Num,%GetBack)
{
	%MissionData	= "MissionData_" @ %Mid;
	//分类
	switch$(%Type)
	{
		case "Npc":
			switch (%Num)
			{
				case 100:%Id_Type = GetNpcA(%Mid);
				case 99:%Id_Type = GetNpcZ(%Mid);
				default:%Id_Type = %Player.GetMissionFlag(%Mid,1150 + %Num);
			}
		case "MonsterKill"://杀怪数量
			%Id_Type = %Player.GetMissionFlag(%Mid,3100 + %Num);
			%Id_Num  = %Player.GetMissionFlag(%Mid,3200 + %Num);

		case "ItemAdd":			//送物品
			%Id_Type = %Player.GetMissionFlag(%Mid,2150 + %Num);
			%Id_Num	 = %Player.GetMissionFlag(%Mid,2250 + %Num);

		case "ItemGet":			//取物品
			%Id_Type = %Player.GetMissionFlag(%Mid,2100 + %Num);
			%Id_Num  = %Player.GetMissionFlag(%Mid,2200 + %Num);

		case "Collect":			//采集类
			%Id_Type = %Player.GetMissionFlag(%Mid,2130 + %Num);
			%Id_Num  = %Player.GetMissionFlag(%Mid,2230 + %Num);

		case "Target":			//触发类型
			%Id_Type = %Player.GetMissionFlag(%Mid,1100 + %Num);
			%Id_Num  = %Player.GetMissionFlag(%Mid,1200 + %Num);
	}

	//------------------------------------组合部件----------------------------------------↓----
	switch (%GetBack)
	{
		case 99:			//名字
			switch (strlen(%Id_Type))
			{
				case 5:return "";	//5位的编号
				case 9:						//9位的编号
					switch$(%Id_Type)
					{
				case "0":
					}
					switch (GetSubStr(%Id_Type,0,1))
					{
						case 1:return GetItemData(%Id_Type,1);//道具
						case 4:return GetNpcData(%Id_Type,1);	//NPC类
						case 5:return GetCollectionObjectname(%Id_Type);//采集
						case 8:return GetTriggerData(%Id_Type,3);	//区域
						case 9:	//特殊追踪 避免和其他编号冲突
							switch$(%Id_Type)
							{
						case "0":return "怪物神魂";
							}
					}
				default: return "";
			}

		case 98:	//地图
			return $Get_Dialog_GeShi[31212] @ $Mission_Map[GetMissionData(%Mid,$Mission_Data_Map_Area),2] @ "</t>";

		case 97:	//坐标，有白色下划线与寻径按钮
			%XYZ      = GetRoute_Position(%Id_Type);
			%Map      = GetSubStr(GetRoute_MapID(%Id_Type),1,4);
			%Map_XYZ1 = Pos3DTo2D(GetMissionData(%Mid,$Mission_Data_Map_Area),GetWord(%XYZ,0),GetWord(%XYZ,1));
			%Map_XYZ2 = GetWord(%Map_XYZ1,0) @ "," @ GetWord(%Map_XYZ1,1);

			return "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath("@%Id_Type@");\",\"" @ $Get_Dialog_GeShi[31214] @ "(" @ %Map_XYZ2 @ ")</t>\",\"GuiMissionTraceButtonProfile3\"' cf='createButton' />";

		case 96:			//数量，白色字体
			switch$(%Type)
			{
		case "Npc":         %NumId = 1050;	//NPC
		case "MonsterKill": %NumId = 3000;	//怪物
		case "ItemGet":     %NumId = 2000;	//道具
		case "ItemAdd":     %NumId = 2050;	//道具
		case "Target":      %NumId = 1000;	//触发数
		case "Collect":     %NumId = 2030;	//采集物
			}

			%KillNumMin = %Player.GetMissionFlag(%Mid,%NumId + %Num + 300);//当前数量
			%KillNumMax = %Player.GetMissionFlag(%Mid,%NumId + %Num + 200);//最大数量

			return " " @ %KillNumMin @ "/" @ %KillNumMax @ "</t>";

		case 95://目标执行动作
			//echo( "=====================" @ GetMission_LeiTou_Text( %Mid, %type ) );
			return GetMission_LeiTou_Text(%Mid,%type,%Num);
			//------------------------------------组合部件----------------------------------------↑----
			//此处开始组合
		case 1:			//返回：有颜色的名字
			switch$(%Type)
			{
		case "Npc":         %Color = 31212;	//NPC
		case "MonsterKill": %Color = 31206;	//怪物
		case "ItemGet":     %Color = 31212;	//道具
		case "ItemAdd":     %Color = 31212;	//道具
		case "Target":      %Color = 31212;	//目标
		case "Collect":     %Color = 31212;	//采集物
			}

			return $Get_Dialog_GeShi[%Color] @ GetMission_Flag(%Player,%Mid,%Type,%Num,99) @ "</t>";

		case 2:			//返回：位于+地名+的+有颜色的NPC名+寻径坐标
			return "<t>位于</t>" @ GetMission_Flag(%Player,%Mid,%Type,%Num,98) @ "<t>的</t>" @ GetMission_Flag(%Player,%Mid,%Type,%Num,1) @ GetMission_Flag(%Player,%Mid,%Type,%Num,97);

		case 3:			//返回：接任务NPC
			//echo( "%Id_Type==" @ %Id_Type );
			%Over = $Get_Dialog_GeShi[31201] @ " ·</t>";
			%SeeLv = $Get_Dialog_GeShi[31201] @ "接任务：</t>";
			%Button = "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath("@%Id_Type@");\",\"" @ $Get_Dialog_GeShi[31214] @ GetMission_Flag(%Player,%Mid,%Type,%Num,99) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' /><b/>";


			if (%Player.GetLevel() < GetMissionData(%Mid,$Mission_Data_LvA))
				%EndTxt = "<b/>" @ $Get_Dialog_GeShi[31206] @ "您需要再提升等级才可以接受此任务</t>";
			else
				%EndTxt = "";
			//echo( %Over @ "   " @ %SeeLv @ "   " @ %Button @ "   " @ %EndTxt );
			//echo( "%Button==" @ %Button );
			return %Over @ %SeeLv @ %Button @ %EndTxt;
		case 4:	//返回：交任务NPC
			if (%Id_Type > 0)
			{
				if (CanDoThisMission(%Player,%Mid,2,0,0) $= "")
					%Over = $Get_Dialog_GeShi[31212] @ " √</t>";
				else
					%Over = $Get_Dialog_GeShi[31201] @ " ·</t>";

				if (GetNpcZ(%Mid) == -1)  //当结束NPC编号为-1时，在任务UI中不显示交任务NPC
					return;

				%NpcZ = GetMission_Flag(%Player,%Mid,%Type,%Num,99);
				%NpcZ = (%NpcZ $= "") ? "NpcZ" : %NpcZ;
				%FindpathID = Getfindpath(%Id_Type,%Mid,%NpcZ,31214);

				return %Over @ $Get_Dialog_GeShi[31201] @ "交任务：</t>" @ %FindpathID @ "<b/>";
			}
			else
				return "";
		case 5:	//返回：已击败/已拾取/已对话+白色的NPC名+数量+寻径格式

			//计算此条件是否满足，因为要变色
			switch$(%Type)
			{
		case "Npc":         %NumId = 1050;	//NPC
		case "MonsterKill": %NumId = 3000;	//怪物
		case "ItemGet":     %NumId = 2000;	//道具
		case "ItemAdd":     %NumId = 2050;	//道具
		case "Target":      %NumId = 1000;	//触发数
		case "Collect":     %NumId = 2030;	//采集物
			}

			//计数问题
			if (%NumId > 0)
			{
				%KillNumMin = %Player.GetMissionFlag(%Mid,%NumId + %Num + 300);//当前数量
				%KillNumMax = %Player.GetMissionFlag(%Mid,%NumId + %Num + 200);//最大数量

				if (%KillNumMin < %KillNumMax)
				{
					%ColorA = 31201;	//白色
					%ColorB = 31214;	//草绿色+下划线
					%OK = " ·";
				}
				else
				{
					%ColorA = 31212;	//绿色无下划线
					%ColorB = 31212;	//绿色无下划线
					%OK = " √";
				}

				%KillNumTxt = $Get_Dialog_GeShi[%ColorA] @ %KillNumMin @ "/" @ %KillNumMax @ "</t>";
			}
			else
			{
				%ColorA = 31201;	//白色
				%OK = " ·";
			}

			//获取寻路ID
			%FindpathID = Getfindpath(%Id_Type,%Mid,0,%ColorB);
			%GetMission_Flag = GetMission_Flag(%Player,%Mid,%Type,%Num,95);
			if (%GetMission_Flag $= "")
				return "";

			return $Get_Dialog_GeShi[%ColorA] @ %OK @ %GetMission_Flag @"</t>"@ %FindpathID @ %KillNumTxt;

		case 6:	//返回：追踪界面交任务NPC
			%NpcZ = GetMission_Flag(%Player,%Mid,%Type,%Num,99);
			%NpcZ = (%NpcZ $= "") ? "NpcZ" : %NpcZ;
			%FindpathID = Getfindpath(%Id_Type,%Mid,%NpcZ,31214);
			return %FindpathID;
	}

	return "【1="@%Player@"】【2="@%Mid@"】【3="@%Type@"】【4="@%Num@"】【5="@%GetBack@"】";
}

//■■■■■■■■■■【通用】客户端寻路解析■■■■■■■■■■■■■■■■■■■
function Getfindpath(%FindpathID,%Mid,%Txt,%ColorB)
{
	%Player = GetPlayer();

	//交任务特殊选项
	if (%Txt $= "NpcZ")
	{

	}

	if (%Txt $= "0")
		switch (GetSubStr(%FindpathID,0,1))
	{
			case 1:%Txt = GetItemData(%FindpathID,1);					//道具
			case 4:%Txt = GetNpcData(%FindpathID,1);						//NPC类
			case 5:%Txt = GetCollectionObjectname(%FindpathID);		//采集
			case 8:%Txt = GetTriggerData(%FindpathID,3);				//区域
	}

	//如果编号该变量有编号，则修改寻路目标
	if ($Item_Monster[%FindpathID] > 0)
	{
		%Mon_Num_Max = GetWordCount($Item_Monster[%FindpathID]);
		%Mon_Nun     = GetRandom(1,%Mon_Num_Max);
		%FindpathID = GetWord($Item_Monster[%FindpathID],%Mon_Nun - 1);
	}

	//怪物绑定任务编号，特殊处理
	if ($Monster_Monster[%FindpathID,%Mid] > 0)
		%FindpathID = $Monster_Monster[%FindpathID,%Mid];

	//根据编号特殊处理
	switch (%FindpathID)
	{
		case 418001003: %FindpathID = $HuoDong_YGBK_ID[%Player.GetMissionFlag(%Mid,10001)];
	}

	//寻路解析
	%TraceButton = "findpath("@%FindpathID@");";

	//如果绑定文字
	if ($Item_Text[%FindpathID] !$= "")
		%TraceButton = "SetScreenMessage($Item_Text["@%FindpathID@"], $Color[5]);";

	//如果绑定按钮
	if ($Item_Button[%FindpathID] !$= "")
		%TraceButton = $Item_Button[%FindpathID];

	if ((%Txt $= "") || (%Txt $= "0"))
		return "";

	return "<c cid='" @ Get_TraceButton() @ "' cmd='\""@%TraceButton@"\",\"" @
		$Get_Dialog_GeShi[%ColorB] @ %Txt @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />";
}

//■■■■■■■■■■■■■获取任务奖励信息■■■■■■■■■■■■■■■■■■■
function GetMissionHortation(%Mid,%State,%WndType)
{
	//echo( "%Mid ==" @ %Mid  @ "   %State==" @  %State @ " %WndType===" @ %WndType );
	if (%Mid == -1)
		return "";

	%Player = GetPlayer();

	switch (%State)
	{
		case 1:%PaiXuNum = 86;	%PaiXuNameA = 3; %GeShi = 31212; %newline = "";
		case 3:%PaiXuNum = 80;	%PaiXuNameA = 2; %GeShi = 31212; %newline = "";
		case 4:%PaiXuNum = 80;	%PaiXuNameA = 2; %GeShi = 31212; %newline = "";
		default:
			%PaiXuNum = 86;	%PaiXuNameA = 3; %GeShi = 31212; %newline = "";
	}

	//清除全部界面ICON
	for (%i=%WndType; %i<=(%WndType+9); %i++)
		%Player.ClearMissionItem(%i);

	//人物经验奖励
	%MissionData_Exp = GetMissionData(%Mid,$Mission_Data_Exp);
	if (%MissionData_Exp != 0)
		%Exp = $Get_Dialog_GeShi[%GeShi] @ " 人物经验：</t><t>[ "@ %MissionData_Exp @" ]</t>";

	//元宝奖励
	%MissionData_Money = GetMissionData(%Mid,$Mission_Data_Money);
	if (%MissionData_Money != 0)
		%Money = $Get_Dialog_GeShi[%GeShi] @ "  元  宝 ：</t><t>[ "@ %MissionData_Money @ " </t>" @ $Icon[89] @ "<t> ]</t>";

	//金币奖励
	%MissionData_Yuan = GetMissionData(%Mid,$Mission_Data_Yuan);
	//%MissionData_Yuan = 1234567;
	if (%MissionData_Yuan != 0)
		%Yuan = $Get_Dialog_GeShi[%GeShi] @ "  金  钱 ：</t><t>[ </t>" @ ChangeMoneyText(%MissionData_Yuan) @ "<t> ]</t>";

	//活跃积分奖励
	%MissionData_JiFen = GetMissionData(%Mid,$Mission_Data_JiFen);
	if (%MissionData_JiFen != 0)
		%JiFen = $Get_Dialog_GeShi[%GeShi] @ " 活跃积分：</t>[ " @ %MissionData_JiFen @ " ]";

	//战场积分
	if (GetMissionData(%Mid,1) == 9)
		%ZcJF = $Get_Dialog_GeShi[%GeShi] @ " 战场积分：</t>[ 5 ]";

	//状态
	%MissionData_Buff = GetMissionData(%Mid,$Mission_Data_Buff);
	if (%MissionData_Buff !$= "0")
	{
	}

	//根据职业给予技能
	%MissionData_Skill = GetMissionData(%Mid,$Mission_Data_Skill);
	%MissionData_Skill_Num = GetWordCount(%MissionData_Skill,";");
	if (%MissionData_Skill !$= "0")
	{
		for (%i = 0; %i < %MissionData_Skill_Num; %i++)
		{
			%Skill = GetWord(%MissionData_Skill,%i,";");

			if (%Skill $= "")
				break;
			else
			{
				%ClassesID = GetItemData(%Skill,113);
				if (HasBit(%ClassesID,%Player.GetClasses(0) - 1) > 0)
				{
					%SkillBookID = GetItemData(%Skill,17);
					if (%Player.GetSkillLevel(%SkillBookID) == 0)
					{
						%SkillTxt = 1;
						%Player.AddItemToMission(%WndType+2,1,%Skill,1);
					}
				}
			}
		}

		if (%SkillTxt > 0)
			%Skill = $Get_Dialog_GeShi[%GeShi] @ " 技能奖励：</t>" @ %newline @ GetFixedMissionItemText(%WndType+2);
	}

	if ((%State == 1) || (%State == 3))
	{
		//领取任务给予道具
		%MissionData_ItemAdd = GetMissionData(%Mid,$Mission_Data_ItemAdd);
		%MissionData_ItemDelete = GetMissionData(%Mid,$Mission_Data_ItemDelete);
		if ((%MissionData_ItemAdd !$= "0") && (%MissionData_ItemDelete == 0))
		{
			//根据职业给予道具
			%Classes = %Player.GetClasses(0);
			for (%i = 0; %i < 50; %i++)
			{
				%ItemAdd = GetWord(%MissionData_ItemAdd,%i * 2,";");
				%ItemNum  = GetWord(%MissionData_ItemAdd,%i * 2 + 1,";");

				if ((%ItemAdd $= "")&&(%ItemNum $= ""))
					break;
				else
				{
					if (HasBit(GetItemData(%ItemAdd,113),%Classes - 1) > 0)
						%Player.AddItemToMission(%WndType+3,1,%ItemAdd,%ItemNum);
				}
			}

			%ItemAdd = $Get_Dialog_GeShi[%GeShi] @ " 领取奖励：</t>" @ %newline @ GetFixedMissionItemText(%WndType+3);
		}
	}

	%Sex = %Player.GetSex();
	%Classes = %Player.GetClasses(0);
	//选择性道具
	if ($MissionData_ItemChose[%Mid] !$= "")
	{
		//echo( "===================" @ %Mid @ "     ===" @ $MissionData_ItemChose[ %Mid ] );
		for (%i = 0; %i <= 99; %i++)
		{
			%Item = GetWord($MissionData_ItemChose[%Mid],%i * 2,";");
			%Num  = GetWord($MissionData_ItemChose[%Mid],%i * 2 + 1,";");
			//echo( "%Item=AA==" @ %Item @ "    %Num===" @ %Num );
			if ((%Item $= "")&&(%Num $= ""))
				break;
			//echo( "%Item=VV==" @ %Item @ "    %Num===" @ %Num );
			%ItemJob =  GetItemData(%Item,113);
			%ItemSex = GetItemData(%Item,24);
			//echo( " CheckBit( " @ %ItemJob @ ", " @ %Classes - 1 @ " ) ======" @  CheckBit( %ItemJob, %Classes ) );
			if (CheckBit(%ItemJob,%Classes - 1) == 1)
			{
				if (%ItemSex == 0 || %ItemSex == %Sex)
					%MissionData_ItemChose = %MissionData_ItemChose @ %Item @ ";" @ %Num @ ";";
			}
		}
		//echo( "%MissionData_ItemChose===" @ %MissionData_ItemChose );
	}
	else
		%MissionData_ItemChose = GetMissionData(%Mid,$Mission_Data_ItemChose);

	if (%MissionData_ItemChose !$= "0" && %MissionData_ItemChose !$= "")
	{
		if (%mid != 24108)
		{
			for (%i = 0; %i < 200; %i++)
			{
				%Item = GetWord(%MissionData_ItemChose,%i * 2,";");
				%Num  = GetWord(%MissionData_ItemChose,%i * 2 + 1,";");

				if ((%Item $= "")&&(%Num $= ""))
					break;
				else
					%Player.AddItemToMission(%WndType+1,0,%Item,%Num);
			}
			%ItemChose = $Get_Dialog_GeShi[%GeShi] @ " 可选道具：</t>" @ %newline @ GetOptionalMissionItemText(%WndType+1);
		}
	}

	//必给道具 || 根据职业给予道具
	if ($MissionData_ItemSet[%Mid] !$= "")
		%MissionData_ItemChose = $MissionData_ItemSet[%Mid];
	else
		%MissionData_ItemSet = GetMissionData(%Mid,$Mission_Data_ItemSet);

	if ($Mission_Data_ItemClasses[%Mid] !$= "")
		%MissionData_ItemClasses = $Mission_Data_ItemClasses[%Mid];
	else
		%MissionData_ItemClasses = GetMissionData(%Mid,$Mission_Data_ItemClasses);

	if ((%MissionData_ItemSet !$= "0") || (%MissionData_ItemClasses !$= "0"))
	{
		for (%i = 0; %i < 50; %i++)
		{
			%Item = GetWord(%MissionData_ItemSet,%i * 2,";");
			%Num  = GetWord(%MissionData_ItemSet,%i * 2 + 1,";");

			if ((%Item $= "")&&(%Num $= ""))
				break;
			else
				%Player.AddItemToMission(%WndType,1,%Item,%Num);
		}

		//根据职业给予道具
		%Classes = %Player.GetClasses(0);
		for (%i = 0; %i < 50; %i++)
		{
			%ItemClasses = GetWord(%MissionData_ItemClasses,%i * 2,";");
			%SetNum  = GetWord(%MissionData_ItemClasses,%i * 2 + 1,";");

			if ((%ItemClasses $= "")&&(%SetNum $= ""))
				break;
			else
			{
				if (HasBit(GetItemData(%ItemClasses,113),%Classes - 1) > 0)
				{
					if (GetItemData(%ItemClasses,24) == 0 || GetItemData(%ItemClasses,24) == %sex)
						%Player.AddItemToMission(%WndType,1,%ItemClasses,%SetNum);
				}
			}
		}
		%ItemSet = $Get_Dialog_GeShi[%GeShi] @ " 奖励道具：</t>" @ %newline @ GetFixedMissionItemText(%WndType);
	}

	if (%Exp   !$= "") { %Amount++; %Name[0] = %Exp; }
	if (%Money !$= "") { %Amount++; %Name[1] = %Money; }
	if (%Yuan  !$= "") { %Amount++; %Name[2] = %Yuan; }
	if (%JiFen !$= "") { %Amount++; %Name[3] = %JiFen; }
	if (%ZcJF  !$= "") { %Amount++; %Name[4] = %ZcJF; }

	//将已有内容赋值%PaiXu
	%PaiXuName = 0;
	for (%i=0; %i<7; %i++)
	{
		if (%Name[%i] !$= "")
		{
			%PaiXu[%PaiXuName] = %Name[%i];
			%PaiXuName++;
		}
	}

	if (%PaiXuName > %PaiXuNameA)
	{
		%RewardNum = mCeil(%PaiXuName / 2);
		for (%i=0; %i< %RewardNum; %i++)
		{
			%Blank = %PaiXuNum - strlen(%PaiXu[%i]);
			for (%ii=0; %ii< %Blank; %ii++)
				%PaiXu[%i] = %PaiXu[%i] @ " ";

			//第1位
			%Reward = %Reward @ %PaiXu[%i];
			//第2位
			%Reward = %Reward @ %PaiXu[%i + %RewardNum] @ "<b/>";
		}
	}
	else for (%i=0; %i< %PaiXuName; %i++)
		%Reward = %Reward @ %PaiXu[%i] @ "<b/>";

	//特殊处理道具奖励界面
	if (%Skill 		!$= "")%ItemText[%ItemText++] = %Skill;
	if (%ItemAdd 	!$= "")%ItemText[%ItemText++] = %ItemAdd;
	if (%ItemChose !$= "")%ItemText[%ItemText++] = %ItemChose;
	if (%ItemSet 	!$= "")%ItemText[%ItemText++] = %ItemSet;
	for (%i=1; %i<=%ItemText; %i++)
	{
		%BBB = (%i != %ItemText) ? "<b/>" : "";
		%ItemTextNum = %ItemTextNum @ %ItemText[%i] @ %BBB;
	}

	%Reward = %Reward @ %Buff @ %ItemTextNum @ %ShengWang;
	if (%Reward !$= "")
	{
		%Txt = %Reward;
		//echo( "%Txt ===" @ %Txt );
		if ((%Mid >= $JRMB_Mission[0]) && (%Mid <= $JRMB_Mission[15]))
			%Txt = %Txt @ SurprisePartyWnd_ListBox_Choose_ultimate(%Mid);
	}

	%Txt = %Txt  @ eval("Mission" @ %Mid @ "Dialog" @ "(%Npc, %Player, %Mid, 910);");

	return $Get_Dialog_GeShi[31201] @ %Txt @ "</t>";
}

//■■■■■■■■■■■■■清除全部界面ICON■■■■■■■■■■■■■■■■■■■
function AllClearMissionItem(%Player)
{
	for (%i=10000; %i<=10009; %i++)
		%Player.ClearMissionItem(%i);

	for (%i=10010; %i<=10019; %i++)
		%Player.ClearMissionItem(%i);

	for (%i=10050; %i<=10059; %i++)
		%Player.ClearMissionItem(%i);
}

function MissionSptAutoBuildTeam(%Mid)
{
	//完成任务后强制关闭对话框
	%ConvText = GetMissionData(%Mid,$Mission_Data_Conv);
	if (HasBit(%ConvText,9) > 0)
		sptAutoBuildTeam();
	//AgreeTeamFollow(); 自动跟随
}

function MissionChapter(%Mid_CS)
{
	%Player = GetPlayer();
	%Mid[1] = "20001 20201 20401 20601 20801";
	%Mid[2] = "21005 21006 21105 21106";
	%Mid[3] = "10000";
	%Mid[4] = "10100";
	%Mid[5] = "10200";
	%Mid[6] = "10300";
	%Mid[7] = "10400";
	%Mid[8] = "10500";

	for (%i = 8; %i > 0; %i--)
	{
		%MidNum = GetWordCount(%Mid[%i]);
		for (%ii = 0; %ii < %MidNum; %ii++)
		{
			%Mid = GetWord(%Mid[%i],%ii);

			//			//设置屏幕中间章回图片
			//			if(%Mid_CS == %Mid)
			//				Setspecial_mission_chaptersbitmap("Taskgui_ZJ_" @ %i @ ".png", 2000);

			//设置任务追踪章回图片
			if (%ZhangHuiOK == 0)
				if ((%Player.IsAcceptedMission(%Mid)) || (%Player.IsFinishedMission(%Mid)))
				{
					//显示篇章图片
					ShowOrHideTraceChapterBmp(1);
					//显示章节
					SetMissionTraceChapterBmp(%i);
					//结束循环
					%ZhangHuiOK++;
				}
		}
	}
	//显示篇章图片
	//if ( %ZhangHuiOK == 0 )
	//	ShowOrHideTraceChapterBmp( 0 );
}

function RightClickSingleWnd1_Tree1(%col)
{
	%Player = GetPlayer();
	//获取树状的类型
	%DendriformType = GetWord($DendriformDefining[%col],0);
	//获取树状的编号
	%DendriformID = GetWord($DendriformDefining[%col],1);
	//获取树状的显示
	%DendriformShow = GetWord($DendriformDefining[%col],2);

	//隐藏一级树状内的所有任务
	if (%DendriformType == 1)
	{
		//检索所有树状
		for (%i = 1; %i <= 100; %i++)
		{
			//检索树的类型
			%DendriformDefining[0] = GetWord($DendriformDefining[%i],0);
			//检索树的编号
			%DendriformDefining[1] = GetWord($DendriformDefining[%i],1);
			if (%DendriformDefining[0] != 2)
				continue;

			//设置任务追踪状态
			%Show = (%DendriformShow == 0) ? 1 : 0;
			$DendriformDefining[%col] = %DendriformType @ " " @ %DendriformID @ " " @ %Show;

			//设置任务追踪界面
			RightClickSingleWnd1_Tree2(%Player,%DendriformShow,%DendriformType,%DendriformID,%DendriformDefining[1]);
		}
	}
	//单个隐藏任务功能
	else if (%DendriformType == 2)
		RightClickSingleWnd1_Tree2(%Player,%DendriformShow,%DendriformType,0,%DendriformID);

	//刷新任务追踪界面
	RefreshTraceMission(%Player);
}

function RightClickSingleWnd1_Tree2(%Player,%DendriformShow,%DendriformType,%DendriformID,%Mid)
{
	%kind1 = GetWord($DendriformMid[%Mid],1);	//任务1级树状
	%Hide = GetWord($DendriformMid[%Mid],2);		//任务显示的状态
	%kind3 = GetWord($DendriformMid[%Mid],3);	//任务显示的状态

	switch (%DendriformType)
	{
		case 1:%Compare[1] = %kind1; %Compare[2] = %DendriformID; %Hide = %DendriformShow;
		case 2:%Compare[1] = 0; %Compare[2] = 0;
	}

	//隐藏任务追踪任务
	if (%Compare[1] == %Compare[2])
	{
		//隐藏任务追踪任务
		if (%Hide == 1)
		{
			%node = MissionTraceWnd_Tree.findMissionTreeNode(%Mid);
			MissionTraceWnd_Tree.clearChildItem(%node);

			MissionTraceWnd_Tree.buildVisibleTree(false);
			setMissionTraceWnd();

			$DendriformDefining[%kind3] = 2 @ " " @ %Mid @ " " @ 0;
			$DendriformMid[%Mid] = "2 " @ %kind1 @ " " @ 0;
		}
		else //显示任务追踪任务
		{
			$DendriformDefining[%kind3] = 2 @ " " @ %Mid @ " " @ 1;
			$DendriformMid[%Mid] = "2 " @ %kind1 @ " " @ 1;
		}

		//刷新可接界面任务
		CreateAcceptedMissionNode(%Player,%Mid,isOrderByMap(),true,1);
	}
}

function SortMission(%Player,%ZhuangTai)
{
	//获取玩家等级
	%Leve = %Player.GetLevel();
	//已经接任务
	if (%ZhuangTai == 0)
	{
		//遍历玩家所有已接任务，将【完成的主线任务】添加到树列表
		%AcceptCountNum = %Player.GetAcceptedMission();
		for (%i = 0; %i < %AcceptCountNum; %i++)
			%Mid[%i] = %Player.GetMission(%i);
	}
	else //未接任务
	{
		//获取玩家当前段的任务
		%Lv_Mission = GetCanSeeMission(%Leve);
		%AcceptCountNum = GetWordCount(%Lv_Mission);
		%n = 0;

		for (%i = 0; %i < %AcceptCountNum; %i++)
		{
			%Mid_N = GetWord(%Lv_Mission,%i);
			if (CanDoThisMission(%Player,%Mid_N,1,2,0) $= "")
			{
				%Mid[%n] = %Mid_N;
				%n++;
			}
		}
		//任务数量重新赋值
		%AcceptCountNum = %n;
	}

	for (%i = 0; %i < %AcceptCountNum - 1; %i++)
	{
		//获取任务等级
		//获取以存储数量
		%leveNum = GetWordCount(%Prepareleve);

		for (%ii = 0; %ii < (%AcceptCountNum - 1 - %i); %ii++)
		{
			//获取任务编号
			%Midleve[%ii] = GetMissionData(%Mid[%ii],$Mission_Data_LvJ);
			%Midleve[%ii + 1] = GetMissionData(%Mid[%ii + 1],$Mission_Data_LvJ);

			if (%Midleve[%ii] == 0)
				%Midleve[%ii] = %Leve;

			if (%Midleve[%ii] > %Midleve[%ii + 1])
			{
				%MidReserve = %Mid[%ii];
				%Mid[%ii] = %Mid[%ii + 1];
				%Mid[%ii + 1] = %MidReserve;
			}
		}

		//将数组组合
		%iiiNum = %AcceptCountNum - %i - 1;
		%Mid = (%Mid $= "") ? %Mid[%iiiNum] : %Mid @ " " @ %Mid[%iiiNum];
	}

	return %Mid;
}

function RefreshMission_TeShu(%Mid,%op)
{
	%Player = GetPlayer();

	closeHelpDirect1_4(10019);

	//领取任务
	if (%op == 1)
	{
		if (%Mid == 20801)findpath(GetMissionData(%Mid,$Mission_Data_NpcZ));	//
		if (%Mid == 20803)findpath(GetMissionData(%Mid,$Mission_Data_NpcZ));	//
		if (%Mid == 20805)findpath(411005013);

		if (%Mid == 20808)
		{
			$Packet[610001] = AddEffectPacket(610001,0,"13.3454 65.6114 101.5","1 0 0 0",0,0,-2,0);
			SetScreenMessage("通过『赤炎』召唤的传送门将快速前往『圣地掌令使』。",$Color[5]);
			Schedule(1500,0,"findpath",810050102);
		}
		if (%Mid == 20810)findpath(GetMissionData(%Mid,$Mission_Data_NpcZ));	//支援弟子
		if (%Mid == 20811)findpath(411005001);	//妖孽休猖狂
		if (%Mid == 20812)findpath(411005002);	//异变花朵
		if (%Mid == 20813)findpath(411005004);	//缚灵草
		if (%Mid == 20815)findpath(411005008);	//兵痞逞凶
		if (%Mid == 20816)findpath(GetMissionData(%Mid,$Mission_Data_NpcZ));	//新的线索
		if (%Mid == 20817)findpath(411005005);	//蒙面刺客
		if (%Mid == 20818)findpath(411005006);	//蒙面刺客
		if ((%Mid == 21505) || (%Mid == 21605))
		{
			if ($showOrHidePanel < 1)
				showExPanel();

			// OpenDouFuGan(10026);	//无漏寺真经
		}

		//装备鉴定
		if ((%Mid == 21500) || (%Mid == 21600))
		{
			//打开包裹
			OpenAllBag();

			//道具豆腐干指引
			OpenDouFuGan_AllBagWndGui(113050001,0);

			//记录使用113050025道具后指引
			$DoufuGan_Item[113050001,1] = GetMission_Data_ItemClasses(%Mid);
		}

		//装备升级
		if ((%Mid == 21503) || (%Mid == 21603))
		{
			//打开包裹
			OpenAllBag();

			//道具豆腐干指引
			OpenDouFuGan_AllBagWndGui(116010001,0);

			$SendCurUsingItemId[116010001,1] = GetMission_Data_ItemClasses(%Mid);
		}

		//【 无漏寺真经 】 切换到可接界面
		if ((%Mid == 21505) || (%Mid == 21605))
			OpenCurrentlyMission();

		//【 一鸣惊人 】 提示文字
		if ((%Mid == 21510) || (%Mid == 21510))
			SetScreenMessage("开启『十八路反王』，与程咬金大干一场吧！",$Color[5]);
	}

	//任务中途
	if (%op == 2)
	{
		//小试身手
		if ((%Mid == 20805) && (CanDoThisMission(%Player,20805,2,0,0) $= ""))
		{
			SetCombatAssistant(false);
			Schedule(500,0,"findpath",GetMissionData(%Mid,$Mission_Data_NpcZ));
		}

		//妖孽休猖狂
		if ((%Mid == 20811) && (CanDoThisMission(%Player,20811,2,0,0) $= ""))
		{
			SetCombatAssistant(false);
			Schedule(500,0,"findpath",GetMissionData(%Mid,$Mission_Data_NpcZ));
		}

		//异变花朵
		if ((%Mid == 20812) && (CanDoThisMission(%Player,20812,2,0,0) $= ""))
		{
			SetCombatAssistant(false);
			Schedule(500,0,"findpath",GetMissionData(%Mid,$Mission_Data_NpcZ));
		}

		//兵痞逞凶
		if ((%Mid == 20815) && (CanDoThisMission(%Player,20815,2,0,0) $= ""))
		{
			SetCombatAssistant(false);
			Schedule(500,0,"findpath",GetMissionData(%Mid,$Mission_Data_NpcZ));
		}

		//蒙面刺客
		if ((%Mid == 20817) && (CanDoThisMission(%Player,20817,2,0,0) $= ""))
		{
			SetCombatAssistant(false);
			Schedule(500,0,"findpath",GetMissionData(%Mid,$Mission_Data_NpcZ));
		}

		//如痴如狂 - 长安
		if ((%Mid == 21508) && (CanDoThisMission(%Player,21508,2,0,0) $= ""))
			ClientOnSptAction(131,1);

		//如痴如狂 - 洛阳
		if ((%Mid == 21608) && (CanDoThisMission(%Player,21608,2,0,0) $= ""))
			ClientOnSptAction(131,2);
	}

	//任务完成
	if (%op == 6)
	{
		//【 万兽谷弟子 】 切换到可接界面
		if ((%Mid == 21504) || (%Mid == 21604))
			OpenCanSelectMission();
	}
}

function GetMission_Data_ItemClasses(%Mid)
{
	%Player = GetPlayer();

	//必给道具 || 根据职业给予道具
	%MissionData_ItemClasses = GetMissionData(%Mid,$Mission_Data_ItemAdd);

	if (%MissionData_ItemClasses !$= "0")
	{
		//根据职业给予道具
		%Classes = %Player.GetClasses(0);
		for (%i = 0; %i < 9; %i++)
		{
			%ItemClasses = GetWord(%MissionData_ItemClasses,%i * 2,";");
			%SetNum  = GetWord(%MissionData_ItemClasses,%i * 2 + 1,";");

			if ((%ItemClasses $= "") && (%SetNum $= ""))
				break;
			else
			{
				if (HasBit(GetItemData(%ItemClasses,113),%Classes - 1) > 0)
					return %ItemClasses;
			}
		}
	}
}


function CheckDialogState(%state)
{
	%MidState = GetSubStr(%State,0,3);
	%Mid      = GetSubStr(%State,3,5);
	%checkok  = "";

	if (%MidState == 110)
		%checkok = CanDoThisMission(GetPlayer(),%Mid,1,1,1);

	if (%MidState == 910)
		%checkok = CanDoThisMission(GetPlayer(),%Mid,2,1,1);

	////echo("%checkok = "@%checkok);
	return %checkok;
}

