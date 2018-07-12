//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//完成任务前置判断
//==================================================================================


//===============================服务端与客户端共用的===============================
//case 1: %MidName = "Mission_End_Front_"@ %Mid;			//完成任务前置判断
/*例如:
function Mission_End_Front_32544(%Npc, %Player, %Conv, %Param, %Mid)
{
//判断神器品阶是否到达10阶
%ItemGet[1] = %Player.GetMissionFlag(%Mid, 2101);
if(%Player.GetDeityWeaponPJ(%ItemGet[1]) < 9)
return 60 @ 1000360;

if(%Player.SptIsHasGem(%ItemGet[1]) == 1)
return 60 @ 1000361;

return "";
}
*/
function Mission_End_Front_10032(%Npc,%Player,%Conv,%Param,%Mid)//装备武器
{
	%ItemID = %Player.GetEquip(11);// 获取武器道具ID
	if (%ItemID < 1)
	{
		SendOneScreenMessage(2,"你还没有装备上武器",%Player);
		SendOneChatMessage($chatMsg_System,"<t>你还没有装备上武器</t>",%Player);
		return -1;
	}
	return "";
}

//--------生活技能一完成条件--------------
function Mission_End_Front_30101(%Npc,%Player,%Conv,%Param,%Mid)//挖矿
{
	%ItemID = %Player.GetEquip(13);// 获取生活道具ID
	if (%ItemID != 107020001 && %ItemID != 107020002 && %ItemID != 107020003)
	{
		SendOneScreenMessage(2,"装备矿锄才可以完成任务",%Player);
		SendOneChatMessage($chatMsg_System,"<t>装备矿锄才可以完成任务</t>",%Player);
		return -1;
	}
	return "";
}
function Mission_End_Front_30111(%Npc,%Player,%Conv,%Param,%Mid)//伐木
{
	%ItemID = %Player.GetEquip(13);
	if (%ItemID != 107040001 && %ItemID != 107040002 && %ItemID != 107040003)
	{
		SendOneScreenMessage(2,"装备伐斧才可以完成任务",%Player);
		SendOneChatMessage($chatMsg_System,"<t>装备伐斧才可以完成任务</t>",%Player);
		return -1;
	}
	return "";
}
function Mission_End_Front_30121(%Npc,%Player,%Conv,%Param,%Mid)//采药
{
	%ItemID = %Player.GetEquip(13);
	if (%ItemID != 107010001 && %ItemID != 107010002 && %ItemID != 107010003)
	{
		SendOneScreenMessage(2,"装备镰刀才可以完成任务",%Player);
		SendOneChatMessage($chatMsg_System,"<t>装备镰刀才可以完成任务</t>",%Player);
		return -1;
	}
	return "";
}
function Mission_End_Front_30131(%Npc,%Player,%Conv,%Param,%Mid)//钓鱼
{
	%ItemID = %Player.GetEquip(13);
	if (%ItemID != 107050001 && %ItemID != 107050002 && %ItemID != 107050003)
	{
		SendOneScreenMessage(2,"装备鱼竿才可以完成任务",%Player);
		SendOneChatMessage($chatMsg_System,"<t>装备鱼竿才可以完成任务</t>",%Player);
		return -1;
	}
	return "";
}



//■■■■【冰火试练】■■■■【任务完成前置判断】■■■■■■
function Mission_End_Front_20002(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//烈火之炎
function Mission_End_Front_20003(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//铲除蟾妖
function Mission_End_Front_20001(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//寒冰之魂
function Mission_End_Front_20004(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//铲除妖蟒
function Mission_End_Front_20005(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,"399030001 399040001"); }//乔装采药
function Mission_End_Front_20006(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,"399060001 399060002 399060003"); }//冰火之珠·一
function Mission_End_Front_20007(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//冰火之珠·二
function Mission_End_Front_20008(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//降妖除魔
function Mission_End_Front_20009(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//寒冰之魂
function Mission_End_Front_20010(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//烈火之炎
function Mission_End_Front_20011(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//铲除蟾妖
function Mission_End_Front_20012(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//铲除妖蟒
function Mission_End_Front_20013(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,"399030001 399040001"); }//乔装采药
function Mission_End_Front_20014(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,"399060001 399060002 399060003"); }//冰火之珠·一
function Mission_End_Front_20015(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//冰火之珠·二
function Mission_End_Front_20016(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//降妖除魔
function Mission_End_Front_20017(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//寒冰之魂
function Mission_End_Front_20018(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//烈火之炎
function Mission_End_Front_20019(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//铲除蟾妖
function Mission_End_Front_20020(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//铲除妖蟒
function Mission_End_Front_20021(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,"399030001 399040001"); }//乔装采药
function Mission_End_Front_20022(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,"399060001 399060002 399060003"); }//冰火之珠·一
function Mission_End_Front_20023(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//冰火之珠·二
function Mission_End_Front_20024(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//降妖除魔
function  Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,%NeedBuff)
{
	//echo( "%NeedBuff====" @ %NeedBuff );
	%Record = 1;
	if (%NeedBuff != 0)
	{
		%Record = 0;
		for (%i = 0; %i <= 2; %i++)
		{
			%Buff = getword(%NeedBuff,%i);
			if (%Buff $= "" || %Buff == 0)
				break;
			if (%Player.GetBuffCount(GetSubStr(%Buff,0,5),GetSubStr(%Buff,5,4)) >= 1)
			{
				%Record = 1;
				break;
			}
		}
	}
	if (%Record != 1)
	{
		SendOneScreenMessage(2,"你的任务状态已经消失，请重新采集",%Player);
		return -1;
	}
	return "";
}

//■■■■【冰火试练】■■■■【任务完成前置判断】■■■■■■

function Mission_End_Front_20149(%Npc,%Player,%Conv,%Param,%Mid)
{
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"请预留一格以上的包裹空格！",%Player);
		SendOneChatMessage($chatMsg_System,"<t>请预留一格以上的包裹空格！</t>",%Player);
		return -1;
	}
	if (%Player.Isschbuff(2021))
	{
		SendOneScreenMessage(2,"心魔入体，无法交付师门任务！",%Player);
		SendOneChatMessage($chatMsg_System,"<t>心魔入体，无法交付师门任务！</t>",%Player);
		return -1;
	}
	return "";
}