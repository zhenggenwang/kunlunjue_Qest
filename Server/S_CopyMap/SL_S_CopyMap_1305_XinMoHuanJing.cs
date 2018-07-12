//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//心魔幻境
//==================================================================================

//■■■■【心魔幻境】■■■■【玩家进入副本】■■■■■■■
//■■■■【心魔幻境】■■■■【进入区域触发】■■■■■■■
//■■■■【心魔幻境】■■■■【怪物死亡触发】■■■■■■■
$CopyMap1305_EffectNameRecord[1] = 1; $CopyMap1305_EffectName[1] = "玄武"; $CopyMap1305_Effect[1] = 900147;/*玄武*/	$CopyMap1305_EffectPos[813060101] = "3.38564 91.6524 155.8";
$CopyMap1305_EffectNameRecord[2] = 2; $CopyMap1305_EffectName[2] = "青龙"; $CopyMap1305_Effect[2] = 900148;/*青龙*/	$CopyMap1305_EffectPos[813060102] = "14.5777 102.296 155.5";
$CopyMap1305_EffectNameRecord[3] = 3; $CopyMap1305_EffectName[3] = "朱雀"; $CopyMap1305_Effect[3] = 900149;/*朱雀*/	$CopyMap1305_EffectPos[813060103] = "-8.5722 102.291 155.5";
$CopyMap1305_EffectNameRecord[4] = 4; $CopyMap1305_EffectName[4] = "白虎"; $CopyMap1305_Effect[4] = 900150;/*白虎*/	$CopyMap1305_EffectPos[813060104] = "2.93578 113.608 155.9";
//■■■■【心魔幻境】■■■■【玩家进入副本】■■■■■■■
function SptCopymap_OnEnter_1305_Trigger(%CopyMapID,%Player)
{
	Cancel(%Player.Copymap1305);//先清除倒计时
	%Player.Copymap1305 = Schedule(3000,0,"SptCopymap_OnEnter_1305_Trigger_A",%CopyMapID,%Player);
}
function SptCopymap_OnEnter_1305_Trigger_A(%CopyMapID,%Player)
{

	//-------------决定要去的区域是哪个------
	%Player.RightTriggerID = "81306010" @ GetRandom(1,4);
	//------------进行随机的特效刷新---------
	%RanList = GetRandomNum(4,1,4);
	for (%i = 0; %i<=3; %i++)
	{
		%Number = GetWord(%RanList,%i);
		//echo( "%Number========" @ %Number );
		$CopyMap1305_EffectRecord[%CopyMapID,813060100 + %i + 1,1] = $CopyMap1305_EffectNameRecord[%Number];
		$CopyMap1305_EffectRecord[%CopyMapID,813060100 + %i + 1,2] = addEffectPacket($CopyMap1305_Effect[%Number],0,$CopyMap1305_EffectPos[813060100 + %i + 1],"1 0 0 0",0,0,-1,%CopyMapID);
	}
	//------------发送客户端消息-------------
	%Txt = "前往" @ $CopyMap1305_EffectName[$CopyMap1305_EffectNameRecord[$CopyMap1305_EffectRecord[%CopyMapID,%Player.RightTriggerID,1]]] @ "传送门，挑战心魔（踏错传送门，本次副本即失败)";
	SendOneScreenMessage(2,%Txt,%Player);
	SendOneChatMessage($chatMsg_System,%Txt,%Player);
	ServerOnSptAction(%Player.GetPlayerID(),$CopyMap1305_EffectRecord[%CopyMapID,%Player.RightTriggerID,1],18);//通讯客户端
}

//■■■■【心魔幻境】■■■■【玩家进入副本】■■■■■■■



//■■■■【心魔幻境】■■■■【怪物死亡触发】■■■■■■■
function NpcObjectonDeathcast_410101020(%Monster,%Killer)
{
	%CopyMapID = %Monster.GetLayerId();
	%Mid = 20149;
	if (!%Killer.IsAcceptedMission(%Mid))
		return;
	%Missiontarget = %Killer.GetMissionFlag(%Mid,10300);
	if (%Missiontarget  != 410101020)
		return;
	%Killer.SetMissionFlag(%Mid,3300,1);
	%Killer.UpdateMission(%Mid);

	//清除变量和特效等
	for (%i = 1; %i <= 4; %i++)
	{
		RemovePacket($CopyMap1305_EffectRecord[$CopyMap1305_EffectRecord[%CopyMapID,813060100 + %i,2]]);
		deleteVariables("$CopyMap1305_EffectRecord" @ %CopyMapID @ "_" @ 813060100 + %i @ "_" @ 1);
		deleteVariables("$CopyMap1305_EffectRecord" @ %CopyMapID @ "_" @ 813060100 + %i @ "_" @ 2);
	}
	RemoveCopyMapOnLeaveTeam(%CopyMapID,3);
}
//■■■■【心魔幻境】■■■■【怪物死亡触发】■■■■■■■

function PlayerEnterTrigger_813060101(%Player,%TriggerId){ PlayerEnterTrigger_813060101_813060104(%Player,%TriggerId); }
function PlayerEnterTrigger_813060102(%Player,%TriggerId){ PlayerEnterTrigger_813060101_813060104(%Player,%TriggerId); }
function PlayerEnterTrigger_813060103(%Player,%TriggerId){ PlayerEnterTrigger_813060101_813060104(%Player,%TriggerId); }
function PlayerEnterTrigger_813060104(%Player,%TriggerId){ PlayerEnterTrigger_813060101_813060104(%Player,%TriggerId); }
function PlayerEnterTrigger_813060101_813060104(%Player,%TriggerId)
{
	%CopyMapID = %Player.GetLayerId();
	%CopymapDataID = SptGetCopymapDataId(%CopyMapID);
	//echo( "==" @ %CopymapDataID );
	switch (%CopymapDataID)
	{
		case 1305:
			//echo("记录了什么 =-==" @ %Player.RightTriggerID);
			%Player.TransportObject(0,0,GetRanDom(-4,6),GetRanDom(-5,5),140.537);
			if (%Player.RightTriggerID $=  %TriggerId)
			{
				//----------------刷新战斗NPC--------------
				%Opj = SpNewNpc3(0,410101020,"1.03012 -0.3782 140.537",%CopyMapID,0,"1 1 1");
				%Opj.Setshapename("心魔『" @ %player.getobjectname() @ "』");
				//%Opj.AddEnemyBuffPercent( %player, 10000 );//继承属性
				//MirrorimagePlayerServer( %Player, %Opj ); //镜像玩家
				%Opj.SetLevel(%Player.Getlevel());
			}
			else
			{
				%Player.RightTriggerID = 0;
				%Txt = "你进入了一个错误的传送门，被冰封之力击败";
				%Player.SetSchbuff(2021);
				SendOneScreenMessage(2,%Txt,%Player);
				SendOneChatMessage($chatMsg_System,%Txt,%Player);
				Schedule(1000,0,"eval",%Player @ ".SetDamageState( Disabled ); ");
				Schedule(10000,0,"RemoveCopyMapOnLeaveTeam",%CopyMapID,3);
				for (%i = 1; %i <= 50; %i++)
				{
					addEffectPacket(900146,0,GetRanDom(-10,10) @ " " @ GetRanDom(-10,10) @ " 140.537","1 0 0 0",0,0,-1,%CopyMapID);
				}
			}
		case 1312:
			PlayerEnterTrigger_813060101_813060104_A(%Player,%TriggerId);
	}

}//Schedule( 1000, 0, "eval",  263349 @ ".SetDamageState( Disabled ); " );
