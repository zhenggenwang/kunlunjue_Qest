//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//客户端与服务端共用的脚本函数     掉落规则配置


//■■■■■■■■■■■【怪物死亡掉落包脚本】■■■■■■■■■■■■■■
//■■■■■■■■■■■【玩家死亡掉落道具脚本】■■■■■■■■■■■■■


//■■■■■■■■■■■【怪物死亡掉落包脚本】■■■■■■■■■■■■■■
//==================================================================================
//编号说明
//道具编号：	1开头9位数
//掉物组：	2-9开头6位
//掉物编号：	2-9开头8位
//掉物子包：	2-9开头7位

//------------------根据NPCID填写掉落---填 掉物组，每个以分号间隔，每个分号之间为并列关系----------------
//怪物编号	死亡掉物
//410010001	654321	怪物死亡根据怪物ID进入对应掉物事件编号——掉物组，一个怪物可能对应N个掉物组

//$Item_Falling_NPCID[ 410410410 ]="213456;213457;213458;"


//-----------------填写掉物组属性-------------------------
//掉物组7位
//掉物组	条件判断	开始等级	结束等级	掉物包编号		条件判断填0 标识不判断，直接满足该条件;填1标识需要判断
//254321	1	50	90	20000001		1=角色等级
//254322	2	40	90	20000002		2=怪物等级
//254322	3	10	30	60010011		3=怪物玩家之间等级差（无负数）
//254322	4	1	99	60010012		4=最后一击触发

//----分为4个组，每组之间用“分号”间隔， 
//$Item_Falling_DiaoWu[ 掉物组编号 ] = "条件判断;开始等级;结束等级;掉物包"
//$Item_Falling_DiaoWu[ 213456,1 ] ="1;50;90;21234567;";
//$Item_Falling_DiaoWu[ 213456,2 ] ="2;50;90;21234567;";
//$Item_Falling_DiaoWu[ 213456,3 ] ="3;50;90;21234569";


//-------------------根据掉物组填写掉落道具或者是子类包------
/*实际概率
= 概率 * （1+福缘值*福缘值缩放比/10000）

福缘值
取玩家身上福缘值数值属性

是否为独立掉物
0为无需判断，所有人都执行一次掉物，掉物概率为（概率/受益有效范围类人数）*（1+福缘值*福缘值缩放比/10000）
1为需求判断，该掉物对象只执行1次， 概率 * （1+福缘值*福缘值缩放比/10000）

是否需判断任务
判断角色有该任务才执行本对象掉物

"根据掉物子包进行概率随机，万分制
原则上7位的子包不允许再调用子包，但考虑实际与维护，一旦出现子包调子包，打出警报log"

掉物包编号	道具id	是否为独立掉物	最小掉物数量	最大掉物数量	概率	福缘值缩放比 是否需判断任务
20000001	102034200	1				1				1			5600		10		 填任务编号		*/

//$Item_Falling_DiaoWu[ 掉物包编号, 1 ] ="道具id;是否为独立掉物;最小掉物数量;最大掉物数量;概率;福缘值缩放比;任务编号1;任务编号2;任务编号3";
//$Item_Falling_DiaoWu[ 掉物包编号, 2 ] ="道具id;是否为独立掉物;最小掉物数量;最大掉物数量;概率;福缘值缩放比;任务编号1;任务编号2;任务编号3";
//$Item_Falling_DiaoWu[ 掉物包编号, 3 ] ="道具id;是否为独立掉物;最小掉物数量;最大掉物数量;概率;福缘值缩放比;任务编号1;任务编号2;任务编号3";

//$Item_Falling_DiaoWu[ 20000001, 1 ]="102034200;1;1;5;4500;10;10025;10026;10037";
//$Item_Falling_DiaoWu[ 20000001, 2 ]="102034200;1;1;5;4500;10;10025;10026;10037";
//$Item_Falling_DiaoWu[ 20000001, 3 ]="1234567;1;1;5;4500;10;10025;10026;10037";


//$Item_Falling_DiaoWu[ 1234567, 1 ]="102034200;1;1;5;4500;10;10025;10026;10037";
//$Item_Falling_DiaoWu[ 1234567, 2 ]="102034200;1;1;5;4500;10;10025;10026;10037";
//$Item_Falling_DiaoWu[ 1234567, 3 ]="102034200;1;1;5;4500;10;10025;10026;10037";
function Item_Falling_LastKill(%Npc,%Player)//最后一击
{
	%NpcID = %Npc.GetDataID();
	if ($Item_Falling_NPCID[%NpcID] $= "")
		return;
	%PlayerLevel = %Player.GetLevel();
	for (%i=0; %i< %FallingCount; %i++)
	{
		%DiaoWuZu = GetWord($Item_Falling_NPCID[%NpcID],%i,";");
		for (%j=1; %j<99; %j++)
		{
			if ($Item_Falling_DiaoWu[%DiaoWuZu,%j] $= "")
				break;
			%Tiaojian = GetWord($Item_Falling_DiaoWu[%DiaoWuZu,%j],0,";");
			%Condition_1 = GetWord($Item_Falling_DiaoWu[%DiaoWuZu,%j],1,";");
			%Condition_2 = GetWord($Item_Falling_DiaoWu[%DiaoWuZu,%j],2,";");
			%DiaoLuoBao = GetWord($Item_Falling_DiaoWu[%DiaoWuZu,%j],3,";");
			if (%Tiaojian == 4)
			{
				if (%PlayerLevel >= %Condition_1 && %PlayerLevel <= %Condition_2)
					Item_Falling_DiaoLuoBao(%Npc,%Player,%DiaoLuoBao,%Tiaojian);
			}
		}
	}
}

function Item_Falling_AllKill(%Npc,%Player)
{
	%NpcID = %Npc.GetDataID();
	if ($Item_Falling_NPCID[%NpcID] $= "")
		return;
	%NpcLevel = %Npc.GetLevel();
	%PlayerLevel = %Player.GetLevel();
	%DifferLevel = mabs(%NpcLevel - %PlayerLevel);//等级差

	%FallingCount = GetWordCount($Item_Falling_NPCID[%NpcID],";");
	for (%i=0; %i< %FallingCount; %i++)
	{
		%DiaoWuZu = GetWord($Item_Falling_NPCID[%NpcID],%i,";");
		for (%j=1; %j<99; %j++)
		{
			if ($Item_Falling_DiaoWu[%DiaoWuZu,%j] $= "")
				break;
			%Tiaojian = GetWord($Item_Falling_DiaoWu[%DiaoWuZu,%j],0,";");
			%Condition_1 = GetWord($Item_Falling_DiaoWu[%DiaoWuZu,%j],1,";");
			%Condition_2 = GetWord($Item_Falling_DiaoWu[%DiaoWuZu,%j],2,";");
			%DiaoLuoBao = GetWord($Item_Falling_DiaoWu[%DiaoWuZu,%j],3,";");
			switch (%Tiaojian)
			{
				case 1://1=角色等级
					if (%PlayerLevel >= %Condition_1 && %PlayerLevel <= %Condition_2)
						Item_Falling_DiaoLuoBao(%Npc,%Player,%DiaoLuoBao,%Tiaojian);
				case 2://2=怪物等级
					if (%NpcLevel >= %Condition_1 && %NpcLevel <= %Condition_2)
						Item_Falling_DiaoLuoBao(%Npc,%Player,%DiaoLuoBao,%Tiaojian);
				case 3://3=怪物玩家之间等级差（无负数）
					if (%DifferLevel >= %Condition_1 && %DifferLevel <= %Condition_2)
						Item_Falling_DiaoLuoBao(%Npc,%Player,%DiaoLuoBao,%Tiaojian);
				case 4://4=最后一击触发
			}
		}
	}
}

function Item_Falling_DiaoLuoBao(%Npc,%Player,%DiaoLuoBao,%Optype)
{
	//$Item_Falling_DiaoWu[ 掉物包编号, 3 ] ="道具id;是否为独立掉物;最小掉物数量;最大掉物数量;概率;福缘值缩放比;任务编号1;任务编号2;任务编号3";

	//$Item_Falling_DiaoWu[ 20000001, 1 ]="102034200;1;1;5;4500;10;10025;10026;10037";
	%DiaoLuoBaoLen = strlen(%DiaoLuoBao);//取掉落包编号长度

	for (%i=1; %i<=99; %i++)
	{
		if ($Item_Falling_DiaoWu[%DiaoLuoBao,%i] $="")
			break;
		%ItemID = Getword($Item_Falling_DiaoWu[%DiaoLuoBao,%i],0,";");
		%ItemIDLen = strlen(%ItemID);//取掉落道具编号长度
		%ItemIDOnley = Getword($Item_Falling_DiaoWu[%DiaoLuoBao,%i],1,";") * 1;
		%ItemIDMinNum = Getword($Item_Falling_DiaoWu[%DiaoLuoBao,%i],2,";");
		%ItemIDMAxNum = Getword($Item_Falling_DiaoWu[%DiaoLuoBao,%i],3,";");
		%ItemIDRan = Getword($Item_Falling_DiaoWu[%DiaoLuoBao,%i],4,";");
		%ItemIDFuYuan = Getword($Item_Falling_DiaoWu[%DiaoLuoBao,%i],5,";");

		%Count = GetWordCount($Item_Falling_DiaoWu[%DiaoLuoBao,%i]);
		%Mark = 1;
		if (%Count > 6)//如果有任务需求
		{
			%Mark = 0;
			for (%j=6; %j< %Count; %j++)
			{
				%Mid = Getword($Item_Falling_DiaoWu[%DiaoLuoBao,%i],%j,";");
				if (%Player.IsAcceptedMission(%Mid))
				{
					%Mark = 1;
					break;
				}
			}
		}
		if (%DiaoLuoBaoLen == 7 && %ItemIDLen == 7)
		{
			//echo("子包里又掉了一个子包===" @ $Item_Falling_DiaoWu[%DiaoLuoBao,%i]);
			%Mark = 0;
		}
		if (%ItemIDOnley == 1)//这个怪只掉一次
		{
			if (%Npc.Onley[%DiaoLuoBao,%i] == 1)
			{
				//echo("已经掉过一次了 ");
				%Mark = 0;
			}
		}

		%PlayerFuYuan = 1;//获取玩家福缘
		%ItemIDRan = %ItemIDRan * (1 + %PlayerFuYuan * %ItemIDFuYuan / 10000);
		%RanDom = GetRandom(1,10000);//%ItemIDFuYuan
		if (%RanDom > %ItemIDRan)//没有随机到
		{
			//echo("没有随机到,概率== "  @ %ItemIDRan  @ "  随机值===" @ %RanDom);
			%Mark = 0;
		}
		if (%Mark == 1)
		{
			if (%ItemIDLen != 9)
			{
				//echo("这是个子包==="  @ %ItemID);
				Item_Falling_DiaoLuoBao(%Npc,%Player,%ItemID,5);
			}
			else
			{
				%ImteNum = GetRandom(%ItemIDMinNum,%ItemIDMAxNum);
				SpNew_DiaoLuo(%Npc,%Player,%DiaoLuoBao,%i,%ItemID,%ImteNum,%ItemIDOnley);
			}
		}
	}
}
function SpNew_DiaoLuo(%Npc,%Player,%DiaoLuoBao,%i,%ItemID,%ImteNum,%ItemIDOnley)
{
	if (%ItemIDOnley == 1) //如果是唯一掉落
		%Npc.Onley[%DiaoLuoBao,%i] = 1;
	//--------确定采集物编号--------
	%ItemType = GetItemData(%ItemID,3);
	%CjID = $Lostitem_EventID[%ItemType];
	if (%CjID $= "")
		%CjID = $Lostitem_EventID;

	%Obj_Cj = CreateCollectionObjectEx(%Player.GetPlayerID(),%CjID,%Player.GetPosition(),"0 0 0","0.3 0.3 0.3",60,120,%Player.GetLayerid());
	%Obj_Cj.IsItem = 1;//系统掉落标记
	%ItemName =GetItemData(%ItemID,1);
	%Obj_Cj.SetShapename(%ItemName);//设置采集物名字

	%ItemClor = GetItemData(%ItemID,20);
	switch (%ItemClor)
	{
		//case 1: %Obj_Cj.addpacket( );//灰色
		//case 2: %Obj_Cj.addpacket( );//白色
		case 3: %Obj_Cj.addpacket(700001);//绿色
		case 4: %Obj_Cj.addpacket(700000);//蓝色
		case 5: %Obj_Cj.addpacket(700003);//紫色
		case 6: %Obj_Cj.addpacket(700002); //橙
		case 7: %Obj_Cj.addpacket(700004);//红色
			//default:%Obj_Cj.addpacket( );
	}

	%Obj_Cj.ItemID = %ItemID;
	%Obj_Cj.Master = %Player.GetPlayerID();//掉落者
	%Obj_Cj.MasterName = %Player.GetPlayername();//掉落者的名称
	%Obj_Cj.ItemObj[0] = %ImteNum;		// 物品数量(对于装备，只能为1)		
}
//CreateCollectionObjectEx( %playerId, %dataBlockId, %pos3F, %angle, %scale, %safetime, %existTime, %layerId );
//CreateCollectionObjectEx( 50000021, 551000000, "-4.64464 97.238 133.579", "0 0 0", "1 1 1", 60, 600, 263053.GetLayerid() );
// 263053 50000021 P_55887799 55887799 -4.64464,97.238,133.579 1 team:0-0
//echo( CreateCollectionObjectEx( 50000021, 553000301, "-16.1063 87.4138 132.952", "0 0 0", "1 1 1", 60, 120, 1 ) );
//
//50000026 P_heheha heheha -5.77805,18.504,127.751 1
//SpNewCj( 262947, 551000000, "-5.77805 18.504 127.751", "1 0 0 0", "2 2 2");
//echo( CreateCollectionObjectEx( 50000026, 551000000, "-5.77805 18.504 127.751", "0 0 0", "1 1 1", 60, 120, 1 ) );
//■■■■■■■■■■■【怪物死亡掉落包脚本】■■■■■■■■■■■■■■



//■■■■■■■■■■■【玩家死亡掉落道具脚本】■■■■■■■■■■■■■
//将物品数据导成脚本对象数据（%player.AttachItemObject），例如:
//%player.AttachItemObject(%obj, %type, %index);
//

//Quantity;		// 物品数量(对于装备，只能为1)								0   //物品数量                     
//BindPlayer;		// 绑定者ID(也可用于存储灵魂链接开启后玩家ID)			1   //绑定者ID                     
//BindFriend;		// 绑定好友角色ID共享使用物品							2   //绑定好友ID                   
//ActiveFlag;		// 物品激活标志											3   //物品激活标志                 
//LapseTime;		// 剩余秒数												4   //剩余秒数                     
//RemainUseTimes;	// 剩余使用次数											5   //剩余使用次数                 
//LockedLeftTime;	// 物品锁剩余时间（秒）									6   //物品锁剩余秒数               
//Quality;		// 物品品质等级												7   //物品品质等级                 
//CurWear;		// 当前耐久度												8   //当前耐久度                   
//CurMaxWear;		// 当前最大耐久度										9   //当前最大耐久度               
//CurAdroit;		// 当前熟练度											10  //当前熟练度                   
//CurAdroitLv;		// 当前熟练度等级										11  //当前熟练度等级               
//ActivatePro;		// 附加属性效果激活标志									12  //附加属性效果激活标志         
//RandPropertyID;	// 随机名称属性ID										13  //随机名称属性ID               							  
//IDEProValue0;		// 鉴定后附加属性值0									14  //鉴定后附加属性值0            
//IDEProValue1;		// 鉴定后附加属性值1									15  //鉴定后附加属性值1            
//IDEProValue2;		// 鉴定后附加属性值2									16  //鉴定后附加属性值2            
//IDEProValue3;		// 鉴定后附加属性值3									17  //鉴定后附加属性值3            
//IDEProValue4;		// 鉴定后附加属性值4									18  //鉴定后附加属性值4            
//IDEProValue5;		// 鉴定后附加属性值5									19  //鉴定后附加属性值5            
//IDEProValue6;		// 鉴定后附加属性值6									20  //鉴定后附加属性值6            
//IDEProValue7;		// 鉴定后附加属性值7									21  //鉴定后附加属性值7            
//IDEProValue8;		// 鉴定后附加属性值8									22  //鉴定后附加属性值8            
//IDEProValue9;		// 鉴定后附加属性值9									23  //鉴定后附加属性值9            
//IDEProValue10;	// 鉴定后附加属性值10									24  //鉴定后附加属性值10           
//IDEProValue11;	// 鉴定后附加属性值11									25  //鉴定后附加属性值11           
//EquipStrengthens;	// 装备强化过总数										26  //装备强化次数                 
//EquipStrengthenValue00;//装备强化特殊等级值1							  	27  //装备强化特殊等级0            
//EquipStrengthenValue01;//装备强化特殊等级属性值1							28  //装备强化特殊等级0的附加属性值
//EquipStrengthenValue10;//装备强化特殊等级值2							  	29  //装备强化特殊等级1            
//EquipStrengthenValue11;//装备强化特殊等级属性值2							30  //装备强化特殊等级1的附加属性值
//EquipStrengthenValue20;//装备强化特殊等级值3							  	31  //装备强化特殊等级2            
//EquipStrengthenValue21;//装备强化特殊等级属性值3							32  //装备强化特殊等级2的附加属性值  	  
//WuXingID;						// 五行ID									  33  //五行ID                            
//WuXingPro;						// 五行效果属性						  	  34  //五行效果属性             
//SkillAForEquip;					// 装备上获取的主动技能ID				 35  //装备上获取的主动技能ID 
//SkillBForEquip;					// 装备上获取的被动技能ID				  36  //装备上获取的被动技能ID 
//EmbedSlot0;		// 装备镶嵌孔的宝石ID									  37  //镶嵌孔0的宝石ID            
//EmbedSlot1;		// 装备镶嵌孔的宝石ID									  38  //镶嵌孔1的宝石ID            
//EmbedSlot2;		// 装备镶嵌孔的宝石ID									  39  //镶嵌孔2的宝石ID            
//EmbedSlot3;		// 装备镶嵌孔的宝石ID									  40  //镶嵌孔3的宝石ID            
//EmbedSlot4;		// 装备镶嵌孔的宝石ID									  41  //镶嵌孔4的宝石ID            
//EmbedSlot5;		// 装备镶嵌孔的宝石ID									  42  //镶嵌孔5的宝石ID            
//EmbedSlot6;		// 装备镶嵌孔的宝石ID									  43  //镶嵌孔6的宝石ID            
//EmbedSlot7;		// 装备镶嵌孔的宝石ID									  44  //镶嵌孔7的宝石ID  
//EXPOR_RESERV0,								//拓展属性0					 45
//EXPOR_RESERV1,								//拓展属性1					 46
//EXPOR_RESERV2,								//拓展属性2					 47
//EXPOR_RESERV3,								//拓展属性3					 48
//EXPOR_RESERV4,								//拓展属性4					 49
//EXPRO_EATLIMIT,								//吞噬每日上限				50 
//EXPRO_EATCOUNT,								//当日吞噬次数				51	 
//EXPRO_GATHERSOULLEVEL,						//凝魂等级					52 
//EXPRO_EATPRO0,								//吞噬属性0					53 
//EXPRO_EATPRO1,								//吞噬属性1					54 
//EXPRO_ITEMID,								//物品模板ID					55 

//-------------已废弃-------------
//ImpressID;						// 铭刻ID(状态ID)
//BindProID;						// 灵魂绑定附加属性(状态ID)
//EmbedOpened;					// 开启镶嵌孔（每bit位代表一个孔）
//WuXingLinkID;					// 五行链接ID
//IDEProNum;		// 鉴定后附加属性个数	

//new ItemObject( ItemObj )
//{
//};

//%Player.GetEquip( %pos ); 获取指定装备栏的道具ID
//%pos = 0; //未知类型 
//%pos = 1; //头部 
//%pos = 2; //颈部 
//%pos = 3; //背部 
//%pos = 4; //肩部 
//%pos = 5; //身体 
//%pos = 6; //手部 
//%pos = 7; //腰部 
//%pos = 8; //脚部 
//%pos = 9; //戒指 
//%pos = 10; //护身符 
//%pos = 11; //武器 
//%pos = 12; //法宝类武器 
//%pos = 13; //采集道具 
//%pos = 14; //坐骑道具(在UI上隐藏) 
//%pos = 15; //宠物道具(在UI上隐藏) 
//%pos = 16; //时装头 
//%pos = 17; //时装身体 
//%pos = 18; //时装背部 
//%pos = 19; //扩展背包1 
//%pos = 20; //扩展背包2 
//%pos = 21; //银行扩展格 
//%pos = 22; //摆摊扩展格1 
//%pos = 23; //摆摊扩展格2 
//%pos = 24; //摆摊样式格 
//%pos = 25; //门宗时装 
//DelItemFromInventoryByIndex(50000012, 10, 105103149, 5, 16, 113090002);
//echo(263056.FindItem(1,105103149)); == 3
//263056.AttachItemObject(ItemObj, 2, 3); //2是装备栏 3是索引位置
//echo(ItemObj.EmbedSlot0);
//echo(ItemObj.EquipStrengthens);
//%Player.AddItemToEquip(102012193, 1);设置装备

//
$DropEquip[1,11]=101010001;/*1级-战士-白色长枪*/$DropEquip[1,11]=101020001;/*1级-刺客-白色刀剑*/$DropEquip[1,11]=101030001;/*1级-法师-白色长枪*/$DropEquip[1,11]=101040001;/*1级-道士-白色羽扇*/$DropEquip[1,11]=101050001;/*1级-猎人-白色弓箭*/
$DropEquip[1,1] =102010001;/*1级-战士-白色头部*/$DropEquip[1,1] =102010101;/*1级-刺客-白色头部*/$DropEquip[1,1] =102010201;/*1级-法师-白色头部*/$DropEquip[1,1] =102010301;/*1级-道士-白色头部*/$DropEquip[1,1] =102010401;/*1级-猎人-白色头部*/
$DropEquip[1,5] =102020001;/*1级-战士-白色身体*/$DropEquip[1,5] =102020101;/*1级-刺客-白色身体*/$DropEquip[1,5] =102020201;/*1级-法师-白色身体*/$DropEquip[1,5] =102020301;/*1级-道士-白色身体*/$DropEquip[1,5] =102020401;/*1级-猎人-白色身体*/
$DropEquip[1,3] =102030001;/*1级-战士-白色背部*/$DropEquip[1,3] =102030101;/*1级-刺客-白色背部*/$DropEquip[1,3] =102030201;/*1级-法师-白色背部*/$DropEquip[1,3] =102030301;/*1级-道士-白色背部*/$DropEquip[1,3] =102030401;/*1级-猎人-白色背部*/
$DropEquip[1,4] =102040001;/*1级-战士-白色肩部*/$DropEquip[1,4] =102040101;/*1级-刺客-白色肩部*/$DropEquip[1,4] =102040201;/*1级-法师-白色肩部*/$DropEquip[1,4] =102040301;/*1级-道士-白色肩部*/$DropEquip[1,4] =102040401;/*1级-猎人-白色肩部*/
$DropEquip[1,6] =102050001;/*1级-战士-白色手部*/$DropEquip[1,6] =102050101;/*1级-刺客-白色手部*/$DropEquip[1,6] =102050201;/*1级-法师-白色手部*/$DropEquip[1,6] =102050301;/*1级-道士-白色手部*/$DropEquip[1,6] =102050401;/*1级-猎人-白色手部*/
$DropEquip[1,7] =102060001;/*1级-战士-白色腰部*/$DropEquip[1,7] =102060101;/*1级-刺客-白色腰部*/$DropEquip[1,7] =102060201;/*1级-法师-白色腰部*/$DropEquip[1,7] =102060301;/*1级-道士-白色腰部*/$DropEquip[1,7] =102060401;/*1级-猎人-白色腰部*/
$DropEquip[1,8] =102070001;/*1级-战士-白色脚部*/$DropEquip[1,8] =102070101;/*1级-刺客-白色脚部*/$DropEquip[1,8] =102070201;/*1级-法师-白色脚部*/$DropEquip[1,8] =102070301;/*1级-道士-白色脚部*/$DropEquip[1,8] =102070401;/*1级-猎人-白色脚部*/
$DropEquip[1,10]=103010001;/*1级-战士-白色护符*/$DropEquip[1,10]=103010101;/*1级-刺客-白色护符*/$DropEquip[1,10]=103010201;/*1级-法师-白色护符*/$DropEquip[1,10]=103010301;/*1级-道士-白色护符*/$DropEquip[1,10]=103010401;/*1级-猎人-白色护符*/
$DropEquip[1,2] =103020001;/*1级-战士-白色项链*/$DropEquip[1,2] =103020101;/*1级-刺客-白色项链*/$DropEquip[1,2] =103020201;/*1级-法师-白色项链*/$DropEquip[1,2] =103020301;/*1级-道士-白色项链*/$DropEquip[1,2] =103020401;/*1级-猎人-白色项链*/
$DropEquip[1,9] =103030001;/*1级-战士-白色戒指*/$DropEquip[1,9] =103030101;/*1级-刺客-白色戒指*/$DropEquip[1,9] =103030201;/*1级-法师-白色戒指*/$DropEquip[1,9] =103030301;/*1级-道士-白色戒指*/$DropEquip[1,9] =103030401;/*1级-猎人-白色戒指*/


$Lostitem_EventID[201] = 551000001; //头部  道具分类==201
$Lostitem_EventID[302] = 551000002; //项链  道具分类==302
$Lostitem_EventID[203] = 551000003; //背部  道具分类==203
$Lostitem_EventID[204] = 551000004; //肩部  道具分类==204
$Lostitem_EventID[202] = 551000005; //身体  道具分类==202
$Lostitem_EventID[205] = 551000006; //手部  道具分类==205
$Lostitem_EventID[206] = 551000007; //腰部  道具分类==206
$Lostitem_EventID[207] = 551000008; //脚部  道具分类==207
$Lostitem_EventID[303] = 551000009; //戒指  道具分类==303
$Lostitem_EventID[301] = 551000010; //护符  道具分类==301
$Lostitem_EventID[104] = 551000011; //法杖  道具分类==104
$Lostitem_EventID[1701]= 551000012; //法宝  道具分类==1701
$Lostitem_EventID = 551000000;	//通用
$Lostitem_EventID_Money = 551000013;//金币

function PlayerDeath_Lostitem(%Player,%Killer)
{
	//-------------------计算要掉落多少物品-------------
	%ShaLu = %Player.GetPkValue(); //获取善恶值
	//%Player.SetPkValue(%SL);设置善恶值

	%EqLost = %ShaLu + 1;//掉落的装备件数
	%ItemLost = %ShaLu + 3;//包裹内掉落的物品数量

	if (%EqLost  == 0 && %ItemLost == 0)//不需要掉落东西
		return;
	//--------------------取出所有的装备--------------
	%EquipNum = 0;
	for (%pos = 1; %pos<=11; %pos++)
	{
		%EquipID = %Player.GetEquip(%pos);// 获取指定装备栏的道具ID
		if (%EquipID != 0)
		{
			%Equip[%EquipNum] = %pos;//存下这个装备的位置
			%EquipNum++;
		}

	}
	//--------------------取出包裹内所有道具--------------
	%Num = 0;
	for (%i = 0; %i<120; %i++)
	{
		%ItemList = %Player.Getitemnum(%i);
		//echo( "%ItemList ==" @ %ItemList );
		if (%ItemList !$= "0,0")
		{
			%Item[%Num] = %i;
			%Num++;
		}
	}
	//-----------------------计算能掉落多少道具-----------
	if (%EquipNum < 1 && %Num  < 1)//这个穷逼身上什么都没啊
		return;
	if (%EqLost >  %EquipNum)
		%EqLost = %EquipNum;//没有这么多的装备可掉了
	if (%ItemLost >  %Num)
		%ItemLost =  %Num;//包裹内没有这么多的东西可以掉
	//-----------计算要掉落那些位置---------------
	%EQLostList = GetRandomNum(%EqLost,0,%EquipNum-1);//要掉落的装备的位置
	%ItemLostList = GetRandomNum(%ItemLost,0,%Num-1);//包裹内要掉落的位置
	//echo( "%EQLostList == " @ %EQLostList );
	//echo( "%ItemLostList == " @ %ItemLostList );
	%Player.LostItemRecord = "";
	//-----------开始掉落----------------
	for (%i = 0; %i < %EqLost; %i++)
	{
		%Pos = GetWord(%EQLostList,%i);
		%RelPos = %Equip[%Pos];//这个位置的装备掉拉
		//echo( "%Pos ==" @ %Pos );
		//echo( "%RelPos ==" @ %RelPos );
		DropEquipOrItem(%Player,2,%RelPos);//执行掉落函数
	}
	for (%i = 0; %i < %ItemLost; %i++)
	{
		%Pos = GetWord(%ItemLostList,%i);
		%RelPos = %Item[%Pos];//这个包裹位置的道具掉拉

		//echo( "%Pos ==" @ %Pos );
		//echo( "%RelPos ==" @ %RelPos );
		DropEquipOrItem(%Player,1,%RelPos);//执行掉落函数
	}
	//----发送提醒邮件-------------
	%Count = GetWordCount(%Player.LostItemRecord);
	for (%i = 0; %i < %Count; %i++)
	{
		%ItemID = GetWord(%Player.LostItemRecord,%i);
		//%ItemName	  = "<l i='" @ %ItemID @ "' t='itemid'/>" @ " " @ %ItemName;
		%Clor = GetItemData(%ItemID,20);
		switch (%Clor)
		{
			case 1: %Ziti = $Get_Dialog_GeShi[31407];//灰色
			case 2: %Ziti = $Get_Dialog_GeShi[31401];//白色
			case 3: %Ziti = $Get_Dialog_GeShi[31403];//绿色
			case 4: %Ziti = $Get_Dialog_GeShi[31402];//蓝色
			case 5: %Ziti = $Get_Dialog_GeShi[31409];//紫色
			case 6: %Ziti = "<t f='宋体' m='1' n='12' c='0xff6e00ff' o='0x010101ff'>";//橙
			case 7: %Ziti = $Get_Dialog_GeShi[31406];//红色
			default: %Ziti = $Get_Dialog_GeShi[31401];
		}// 白 2 绿 3 蓝  4 紫 5 橙 6
		//echo( "%Clor==" @ %Clor @ "  " @ %ItemName );
		%Name =GetItemData(%ItemID,1);

		%ItemName = %Ziti @  "[" @ %Name @ "]</t>" @ " " @ %ItemName;
	}

	//解析邮件内容
	%Title = "掉落通知";
	%Txt = $Get_Dialog_GeShi[31422] @ "您被[ "@ %Killer.GetPlayerName() @" ] 击败。</t><b/>"@
		$Get_Dialog_GeShi[31406] @ "<t>不幸掉落：</t><b/><t>" @ %ItemName @ "</t>";
	//echo( %Txt );

	//发送邮件
	SptMail_Send(%Player.GetPlayerid(),0,0,0,0,%Title,%Txt);
}
function DropEquipOrItem(%Player,%OPtype,%Pos)//身上掉落装备 %pos 掉落部位
{
	%PlayerID = %Player.GetPlayerID();
	%CopyMapID = %Player.GetLayerID();

	%Player.AttachItemObject(ItemObj,%OPtype,%Pos);//先把掉落的物品导出对象
	switch (%optype)
	{
		case 2://如果是身上掉的装备
			%ItemID = %Player.GetEquip(%pos);// 获取指定装备栏的道具ID

			%Player.AddItemToEquip($DropEquip[%Player.GetClasses(0),%Pos],%Pos); //设置装备
			//--------确定采集物编号--------
			%ItemType = GetItemData(%ItemID,3);
			%CjID = $Lostitem_EventID[%ItemType];
			if (%CjID $= "")
				%CjID = $Lostitem_EventID;
		case 1://包裹内掉落
			if (ItemObj.Quantity > 0)//道具数量大于0
				ItemObj.Quantity = GetRandom(1,ItemObj.Quantity);//随机掉落若干个

			%ItemID = GetWord(%Player.Getitemnum(%Pos),0,",");
			//echo( "%Player.Getitemnum( %Pos )==" @ %Player.Getitemnum( %Pos ) @ "    %Pos ==" @ %Pos );
			//echo( "%ItemID ===" @ %ItemID );

			DelItemFromInventoryByIndex(%PlayerID,%Pos,%ItemID,ItemObj.Quantity,20,%ItemID);
			//--------确定采集物编号--------
			%ItemType = GetItemData(%ItemID,3);
			%CjID = $Lostitem_EventID[%ItemType];
			if (%CjID $= "")
				%CjID = $Lostitem_EventID;
		case 3://掉钱了

			//--------确定采集物编号--------
			%CjID = $Lostitem_EventID_Money;
	}

	//echo( "%ItemID==" @ %ItemID );
	//---------------------------来发公告------------------
	//%ItemName = $Get_Dialog_GeShi[ 31419 ] @ "[" @ GetItemData( %ItemID, 1 ) @ "]</t>";//获取装备名字
	%Clor = GetItemData(%ItemID,20);
	%ItemName =GetItemData(%ItemID,1);
	%Png = GetItemData(%ItemID,7);
	if (%Clor >= 5)
	{
		switch (%Clor)
		{
			case 1: %Ziti = $Get_Dialog_GeShi[31407];//灰色
			case 2: %Ziti = $Get_Dialog_GeShi[31401];//白色
			case 3: %Ziti = $Get_Dialog_GeShi[31403];//绿色
			case 4: %Ziti = $Get_Dialog_GeShi[31402];//蓝色
			case 5: %Ziti = $Get_Dialog_GeShi[31409];//紫色
			case 6: %Ziti = "<t f='宋体' m='1' n='12' c='0xff6e00ff' o='0x010101ff'>";//橙
			case 7: %Ziti = $Get_Dialog_GeShi[31406];//红色
			default: %Ziti = $Get_Dialog_GeShi[31401];
		}// 白 2 绿 3 蓝  4 紫 5 橙 6
		//echo( "%Clor==" @ %Clor @ "  " @ %ItemName );
		%Path = "</t><l i='" @ "8" @ GetSubStr(GetZoneid(),0,4) @ "0100 " @ %Player.GetPosition() @ "' t='path'/>";

		%Text =  %Ziti @  "[" @ %ItemName @ "]</t>" @ $Get_Dialog_GeShi[31419] @ "从『" @ %Player.GetPlayerName()@ "』身上掉落在" @ %Path @ "</t>";
		SendOneLineMessage(%Text);//活动公告
	}
	//-----------------记录道具--------------
	%Player.LostItemRecord = %ItemID @ " " @ %Player.LostItemRecord;
	//---------------------------创建掉落对象------------------
	%Pos = %Player.GetPosition();
	%Pos = GetNavPos(GetWord(%Pos,0),GetWord(%Pos,1),3);

	%Obj_Cj = CreateCollectionObjectEx(%PlayerID,%CjID,%Pos,"0 0 0","0.3 0.3 0.3",0,120,%CopyMapID);

	%Obj_Cj.IsItem = 2;//玩家掉落物标记
	//echo( "%Obj_Cj ===  " @ %Obj_Cj );
	//%Obj_Cj.SetExclusivePlayerName( " " );//设置称号
	%Obj_Cj.SetShapename(%ItemName);//设置采集物名字

	switch (%Clor)
	{
		case 3: %Obj_Cj.addpacket(700001);//绿色
		case 4: %Obj_Cj.addpacket(700000);//蓝色
		case 5: %Obj_Cj.addpacket(700003);//紫色
		case 6: %Obj_Cj.addpacket(700002); //橙
		case 7: %Obj_Cj.addpacket(700004);//红色
	}
	//echo( "%Png===="@ %Png );
	//%Obj_Cj.SetShapeImage( %ItemID @ ".png" );

	%Obj_Cj.ItemID = %ItemID;
	%Obj_Cj.Master = %PlayerID;//掉落者
	%Obj_Cj.MasterName = %Player.GetPlayername();//掉落者的名称
	%Obj_Cj.ItemObj[0] = ItemObj.Quantity;		// 物品数量(对于装备，只能为1)					
	%Obj_Cj.ItemObj[1] = ItemObj.BindPlayer;		// 绑定者ID(也可用于存储灵魂链接开启后玩家ID
	%Obj_Cj.ItemObj[2] = ItemObj.BindFriend;		// 绑定好友角色ID共享使用物品				
	%Obj_Cj.ItemObj[3] = ItemObj.ActiveFlag;		// 物品激活标志								
	%Obj_Cj.ItemObj[4] = ItemObj.LapseTime;		// 剩余秒数
	%Obj_Cj.ItemObj[5] = ItemObj.RemainUseTimes;	// 剩余使用次数								
	%Obj_Cj.ItemObj[6] = ItemObj.LockedLeftTime;	// 物品锁剩余时间（秒）						
	%Obj_Cj.ItemObj[7] = ItemObj.Quality;		// 物品品质等级									
	%Obj_Cj.ItemObj[8] = ItemObj.CurWear;		// 当前耐久度									
	%Obj_Cj.ItemObj[9] = ItemObj.CurMaxWear;		// 当前最大耐久度							
	%Obj_Cj.ItemObj[10] = ItemObj.CurAdroit;		// 当前熟练度								
	%Obj_Cj.ItemObj[11] = ItemObj.CurAdroitLv;		// 当前熟练度等级							
	%Obj_Cj.ItemObj[12] = ItemObj.ActivatePro;		// 附加属性效果激活标志						
	%Obj_Cj.ItemObj[13] = ItemObj.RandPropertyID;	// 随机名称属性ID							
	%Obj_Cj.ItemObj[14] = ItemObj.IDEProValue0;		// 鉴定后附加属性值0						
	%Obj_Cj.ItemObj[15] = ItemObj.IDEProValue1;		// 鉴定后附加属性值1						
	%Obj_Cj.ItemObj[16] = ItemObj.IDEProValue2;		// 鉴定后附加属性值2						
	%Obj_Cj.ItemObj[17] = ItemObj.IDEProValue3;		// 鉴定后附加属性值3						
	%Obj_Cj.ItemObj[18] = ItemObj.IDEProValue4;		// 鉴定后附加属性值4						
	%Obj_Cj.ItemObj[19] = ItemObj.IDEProValue5;		// 鉴定后附加属性值5						
	%Obj_Cj.ItemObj[20] = ItemObj.IDEProValue6;		// 鉴定后附加属性值6						
	%Obj_Cj.ItemObj[21] = ItemObj.IDEProValue7;		// 鉴定后附加属性值7						
	%Obj_Cj.ItemObj[22] = ItemObj.IDEProValue8;		// 鉴定后附加属性值8						
	%Obj_Cj.ItemObj[23] = ItemObj.IDEProValue9;		// 鉴定后附加属性值9						
	%Obj_Cj.ItemObj[24] = ItemObj.IDEProValue10;	// 鉴定后附加属性值10						
	%Obj_Cj.ItemObj[25] = ItemObj.IDEProValue11;	// 鉴定后附加属性值11						
	%Obj_Cj.ItemObj[26] = ItemObj.EquipStrengthens;	// 装备强化过总数							
	%Obj_Cj.ItemObj[27] = ItemObj.EquipStrengthenValue00;//装备强化特殊等级值1					
	%Obj_Cj.ItemObj[28] = ItemObj.EquipStrengthenValue01;//装备强化特殊等级属性值1				
	%Obj_Cj.ItemObj[29] = ItemObj.EquipStrengthenValue10;//装备强化特殊等级值2					
	%Obj_Cj.ItemObj[30] = ItemObj.EquipStrengthenValue11;//装备强化特殊等级属性值2				
	%Obj_Cj.ItemObj[31] = ItemObj.EquipStrengthenValue20;//装备强化特殊等级值3					
	%Obj_Cj.ItemObj[32] = ItemObj.EquipStrengthenValue21;//装备强化特殊等级属性值3				
	%Obj_Cj.ItemObj[33] = ItemObj.WuXingID;						// 五行ID						
	%Obj_Cj.ItemObj[34] = ItemObj.WuXingPro;						// 五行效果属性				
	%Obj_Cj.ItemObj[35] = ItemObj.SkillAForEquip;					// 装备上获取的主动技能ID	
	%Obj_Cj.ItemObj[36] = ItemObj.SkillBForEquip;					// 装备上获取的被动技能ID	
	%Obj_Cj.ItemObj[37] = ItemObj.EmbedSlot0;		// 装备镶嵌孔的宝石ID						
	%Obj_Cj.ItemObj[38] = ItemObj.EmbedSlot1;		// 装备镶嵌孔的宝石ID						
	%Obj_Cj.ItemObj[39] = ItemObj.EmbedSlot2;		// 装备镶嵌孔的宝石ID						
	%Obj_Cj.ItemObj[40] = ItemObj.EmbedSlot3;		// 装备镶嵌孔的宝石ID						
	%Obj_Cj.ItemObj[41] = ItemObj.EmbedSlot4;		// 装备镶嵌孔的宝石ID						
	%Obj_Cj.ItemObj[42] = ItemObj.EmbedSlot5;		// 装备镶嵌孔的宝石ID						
	%Obj_Cj.ItemObj[43] = ItemObj.EmbedSlot6;		// 装备镶嵌孔的宝石ID						
	%Obj_Cj.ItemObj[44] = ItemObj.EmbedSlot7;		// 装备镶嵌孔的宝石ID						
	%Obj_Cj.ItemObj[45] = ItemObj.EXPOR_RESERV0;								//拓展属性0		
	%Obj_Cj.ItemObj[46] = ItemObj.EXPOR_RESERV1;								//拓展属性1		
	%Obj_Cj.ItemObj[47] = ItemObj.EXPOR_RESERV2;								//拓展属性2		
	%Obj_Cj.ItemObj[48] = ItemObj.EXPOR_RESERV3;								//拓展属性3		
	%Obj_Cj.ItemObj[49] = ItemObj.EXPOR_RESERV4;								//拓展属性4		
	%Obj_Cj.ItemObj[50] = ItemObj.EXPRO_EATLIMIT;								//吞噬每日上限	
	%Obj_Cj.ItemObj[51] = ItemObj.EXPRO_EATCOUNT;								//当日吞噬次数	
	%Obj_Cj.ItemObj[52] = ItemObj.EXPRO_GATHERSOULLEVEL;						//凝魂等级		
	%Obj_Cj.ItemObj[53] = ItemObj.EXPRO_EATPRO0;								//吞噬属性0		
	%Obj_Cj.ItemObj[54] = ItemObj.EXPRO_EATPRO1;								//吞噬属性1		
	//%Obj_Cj.ItemObj[ 55 ] = ItemObj.EXPRO_ITEMID;								//物品模板ID		
	%Obj_Cj.ItemObj[55] = %ItemID;
	//--------------输出调试-------------
	//echo( "------------------------" );
	//echo( %Obj_Cj.ItemID );
	//echo( %ItemName );
	//echo( %Obj_Cj.ItemObj[ 0 ] );
	//echo( %Obj_Cj.Master );//掉落者
	//echo( %Obj_Cj.MasterName );//掉落者的名称
	//for ( %i = 0; %i<=55; %i++ )
	//{
	//	echo( "位置" @ %i @ "数据：" @ %Obj_Cj.ItemObj[ %i ] );
	//}
}
function TsNpcOnTrigger_400000000(%Conv,%Npc,%Player,%State,%Param)
{
	%Conv.Settype(4);
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"您的包裹空间不足，请先清理包裹。",%Player);
		SendOneChatMessage($chatMsg_System,"<t>您的包裹空间不足，请先清理包裹。</t>",%Player);
		return;
	}
	%PlayerID = %Player.GetPlayerID();
	//echo( " Player===" @ %Player );
	//echo( " npc===" @ %npc );
	//echo( " npcID===" @ %npcID );
	//echo( " PlayerID===" @ %PlayerID );
	%Index = %Player.Putitem(%npc.ItemID,%npc.ItemObj[0]);
	//echo( "%npc.ItemID===" @ %npc.ItemID );
	%player.setPutItemProduceName(%Index,"从『" @ %npc.MasterName @ "』处缴获的战利品");

	for (%i=0; %i<=55; %i++)
	{
		//echo( "%npc.ItemObj[ " @ %i @ "]===" @ %npc.ItemObj[ %i ] );
		%Player.SetPutItemProperty(%Index,%i,%npc.ItemObj[%i]);
	}

	if (%Player.additem(4,%npcID))
	{
		%Npc.Safedeleteobject();
	}
}

function GetEquiptest(%Player)//检查玩家身上的装备信息
{
	for (%pos = 0; %pos<=20; %pos++)
	{
		%ItemID = %Player.GetEquip(%pos);// 获取指定装备栏的道具ID
		%ItemName = GetItemData(%ItemID,1);//获取装备名字
		echo("%pos====" @ %pos @ "  %ItemID ==" @ %ItemID  @ " %ItemName==" @ %ItemName  @ "  道具分类==" @ GetItemData(%ItemID,3));
	}
}
function TriggerEvent_551000000(%Player,%Event,%EventID)
{
	//echo( "%Player ==" @ %Player );
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"您的包裹空间不足，请先清理包裹。",%Player);
		SendOneChatMessage($chatMsg_System,"<t>您的包裹空间不足，请先清理包裹。</t>",%Player);
		return false;
	}
	%PlayerID = %Player.GetPlayerID();

	if (%Event.IsItem == 1)//系统掉落包
	{
		%Index = %Player.Putitem(%Event.ItemID,%Event.ItemObj[0]);
		%Event.IsItem = 9999;
		if (%Player.additem(4,%npcID))
			return true;
	}
	else if (%Event.IsItem == 2)//从玩家身上掉落
	{
		%Index = %Player.Putitem(%Event.ItemID,%Event.ItemObj[0]);
		%player.setPutItemProduceName(%Index,"从『" @ %Event.MasterName @ "』处缴获的战利品");
		%Event.IsItem = 9999;
		for (%i=0; %i<=55; %i++)
		{
			//echo( "%Event.ItemObj[ " @ %i @ "]===" @ %Event.ItemObj[ %i ] );
			%Player.SetPutItemProperty(%Index,%i,%Event.ItemObj[%i]);
		}
		if (%Player.additem(4,%npcID))
			return true;
	}
}
//■■■■■■■■■■■【玩家死亡掉落道具脚本】■■■■■■■■■■■■■
//createCropObject(50000021,300000,SptGetPlayer(50000021).Getposition());
