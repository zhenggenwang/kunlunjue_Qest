function UPCS_MapFunction(%Num)
{
	if ((%Num == 1)||(%Num == 99)){ Exec("./SL_Map_1128_YouXianDong.cs"); }//加载陨仙窟地宫1层
	if ((%Num == 2)||(%Num == 99)){ Exec("./SL_Map_1119_FengMoCheng.cs"); }//封魔城
	if ((%Num == 3)||(%Num == 99)){ Exec("./SL_Map_1118_ShiMoDian.cs"); }//封魔城
}
UPCS_MapFunction(99);

//■■■■■■■■■【镜像模式】■■■■【创建怪物总触发】■■■■■■■
//■■■■■■■■■【镜像模式】■■■■【特效怪物总触发】■■■■■■■
//■■■■■■■■■【镜像模式】■■■■【采集怪物总触发】■■■■■■■



function ExecDiGongMap()
{
	Exec("./Server/S_Map/SL_Map_YouXianDong_Lv1.cs");
}
//■■■■■■■■■【镜像模式】■■■■【创建怪物总触发】■■■■■■■
function LogicFloor_NewNpc(%Player,%i,%MonsterID,%Xyz,%CaoXiang,%Scale)
{
	//创建【 怪物 】
	%Monster = SpNewNpc3(0,%MonsterID,%Xyz,0,%CaoXiang,%Scale);
	ChangeLogicFloor(%Monster,0,%Player);

	%MonSter.BelongPlayer = %Player;
	$NewNpc[%MonsterID,%i,%Player] = %Monster;

	return %Monster;
}

function Delete_NewNpc(%Player,%i,%NpcID)
{
	if ($NewNpc[%NpcID,%i,%Player] > 0)
	{
		$NewNpc[%NpcID,%i,%Player].SafeDeleteObject();
		deleteVariables("$NewNpc" @ %NpcID @ "_" @ %i @ "_" @ %Player);
	}
}

//■■■■■■■■■【镜像模式】■■■■【特效怪物总触发】■■■■■■■
function LogicFloor_Packet(%Player,%i,%PacketID,%Xyz,%CaoXiang,%Time)
{
	//创建特效
	%Packet = AddEffectPacket(%PacketID,0,%Xyz,%CaoXiang,0,0,-2,0);
	ChangeLogicFloor(%Player,0,%Player);

	$NewPacket[%PacketID,%i,%Player] = %Packet;

	return %Packet;
}

function Delete_Packet(%Player,%i,%Packet)
{
	if ($NewPacket[%Packet,%i,%Player] > 0)
	{
		RemovePacket($NewPacket[%Packet,%i,%Player]);
		deleteVariables("$NewPacket" @ %Packet @ "_" @ %i @ "_" @ %Player);
	}
}

//■■■■■■■■■【镜像模式】■■■■【采集怪物总触发】■■■■■■■
function LogicFloor_SpNewCj(%Player,%i,%NewCjID,%Xyz,%CaoXiang,%Scale)
{
	//创建【 牢笼 】
	%CaiJi = SpNewCj(%Player,%NewCjID,%Xyz,%CaoXiang,%Scale);
	ChangeLogicFloor(%CaiJi,0,%Player);

	%CaiJi.BelongPlayer = %Player;
	$NewCaiJi[%NewCjID,%i,%Player] = %CaiJi;

	return %CaiJi;
}

function Delete_SpNewCj(%Player,%i,%CaiJi)
{
	if ($NewCaiJi[%CaiJi,%i,%Player] > 0)
	{
		$NewCaiJi[%CaiJi,%i,%Player].SafeDeleteObject();
		deleteVariables("$NewCaiJi" @ %CaiJi @ "_" @ %i @ "_" @ %Player);
	}
}
