//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//�ͻ��������˹��õĽű�����     �����������


//��������������������������������������ű�������������������������������
//�������������������������������������߽ű�����������������������������


//��������������������������������������ű�������������������������������
//==================================================================================
//���˵��
//���߱�ţ�	1��ͷ9λ��
//�����飺	2-9��ͷ6λ
//�����ţ�	2-9��ͷ8λ
//�����Ӱ���	2-9��ͷ7λ

//------------------����NPCID��д����---�� �����飬ÿ���Էֺż����ÿ���ֺ�֮��Ϊ���й�ϵ----------------
//������	��������
//410010001	654321	�����������ݹ���ID�����Ӧ�����¼���š��������飬һ��������ܶ�ӦN��������

//$Item_Falling_NPCID[ 410410410 ]="213456;213457;213458;"


//-----------------��д����������-------------------------
//������7λ
//������	�����ж�	��ʼ�ȼ�	�����ȼ�	��������		�����ж���0 ��ʶ���жϣ�ֱ�����������;��1��ʶ��Ҫ�ж�
//254321	1	50	90	20000001		1=��ɫ�ȼ�
//254322	2	40	90	20000002		2=����ȼ�
//254322	3	10	30	60010011		3=�������֮��ȼ���޸�����
//254322	4	1	99	60010012		4=���һ������

//----��Ϊ4���飬ÿ��֮���á��ֺš������ 
//$Item_Falling_DiaoWu[ �������� ] = "�����ж�;��ʼ�ȼ�;�����ȼ�;�����"
//$Item_Falling_DiaoWu[ 213456,1 ] ="1;50;90;21234567;";
//$Item_Falling_DiaoWu[ 213456,2 ] ="2;50;90;21234567;";
//$Item_Falling_DiaoWu[ 213456,3 ] ="3;50;90;21234569";


//-------------------���ݵ�������д������߻����������------
/*ʵ�ʸ���
= ���� * ��1+��Եֵ*��Եֵ���ű�/10000��

��Եֵ
ȡ������ϸ�Եֵ��ֵ����

�Ƿ�Ϊ��������
0Ϊ�����жϣ������˶�ִ��һ�ε���������Ϊ������/������Ч��Χ��������*��1+��Եֵ*��Եֵ���ű�/10000��
1Ϊ�����жϣ��õ������ִֻ��1�Σ� ���� * ��1+��Եֵ*��Եֵ���ű�/10000��

�Ƿ����ж�����
�жϽ�ɫ�и������ִ�б��������

"���ݵ����Ӱ����и�������������
ԭ����7λ���Ӱ��������ٵ����Ӱ���������ʵ����ά����һ�������Ӱ����Ӱ����������log"

��������	����id	�Ƿ�Ϊ��������	��С��������	����������	����	��Եֵ���ű� �Ƿ����ж�����
20000001	102034200	1				1				1			5600		10		 ��������		*/

//$Item_Falling_DiaoWu[ ��������, 1 ] ="����id;�Ƿ�Ϊ��������;��С��������;����������;����;��Եֵ���ű�;������1;������2;������3";
//$Item_Falling_DiaoWu[ ��������, 2 ] ="����id;�Ƿ�Ϊ��������;��С��������;����������;����;��Եֵ���ű�;������1;������2;������3";
//$Item_Falling_DiaoWu[ ��������, 3 ] ="����id;�Ƿ�Ϊ��������;��С��������;����������;����;��Եֵ���ű�;������1;������2;������3";

//$Item_Falling_DiaoWu[ 20000001, 1 ]="102034200;1;1;5;4500;10;10025;10026;10037";
//$Item_Falling_DiaoWu[ 20000001, 2 ]="102034200;1;1;5;4500;10;10025;10026;10037";
//$Item_Falling_DiaoWu[ 20000001, 3 ]="1234567;1;1;5;4500;10;10025;10026;10037";


//$Item_Falling_DiaoWu[ 1234567, 1 ]="102034200;1;1;5;4500;10;10025;10026;10037";
//$Item_Falling_DiaoWu[ 1234567, 2 ]="102034200;1;1;5;4500;10;10025;10026;10037";
//$Item_Falling_DiaoWu[ 1234567, 3 ]="102034200;1;1;5;4500;10;10025;10026;10037";
function Item_Falling_LastKill(%Npc,%Player)//���һ��
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
	%DifferLevel = mabs(%NpcLevel - %PlayerLevel);//�ȼ���

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
				case 1://1=��ɫ�ȼ�
					if (%PlayerLevel >= %Condition_1 && %PlayerLevel <= %Condition_2)
						Item_Falling_DiaoLuoBao(%Npc,%Player,%DiaoLuoBao,%Tiaojian);
				case 2://2=����ȼ�
					if (%NpcLevel >= %Condition_1 && %NpcLevel <= %Condition_2)
						Item_Falling_DiaoLuoBao(%Npc,%Player,%DiaoLuoBao,%Tiaojian);
				case 3://3=�������֮��ȼ���޸�����
					if (%DifferLevel >= %Condition_1 && %DifferLevel <= %Condition_2)
						Item_Falling_DiaoLuoBao(%Npc,%Player,%DiaoLuoBao,%Tiaojian);
				case 4://4=���һ������
			}
		}
	}
}

function Item_Falling_DiaoLuoBao(%Npc,%Player,%DiaoLuoBao,%Optype)
{
	//$Item_Falling_DiaoWu[ ��������, 3 ] ="����id;�Ƿ�Ϊ��������;��С��������;����������;����;��Եֵ���ű�;������1;������2;������3";

	//$Item_Falling_DiaoWu[ 20000001, 1 ]="102034200;1;1;5;4500;10;10025;10026;10037";
	%DiaoLuoBaoLen = strlen(%DiaoLuoBao);//ȡ�������ų���

	for (%i=1; %i<=99; %i++)
	{
		if ($Item_Falling_DiaoWu[%DiaoLuoBao,%i] $="")
			break;
		%ItemID = Getword($Item_Falling_DiaoWu[%DiaoLuoBao,%i],0,";");
		%ItemIDLen = strlen(%ItemID);//ȡ������߱�ų���
		%ItemIDOnley = Getword($Item_Falling_DiaoWu[%DiaoLuoBao,%i],1,";") * 1;
		%ItemIDMinNum = Getword($Item_Falling_DiaoWu[%DiaoLuoBao,%i],2,";");
		%ItemIDMAxNum = Getword($Item_Falling_DiaoWu[%DiaoLuoBao,%i],3,";");
		%ItemIDRan = Getword($Item_Falling_DiaoWu[%DiaoLuoBao,%i],4,";");
		%ItemIDFuYuan = Getword($Item_Falling_DiaoWu[%DiaoLuoBao,%i],5,";");

		%Count = GetWordCount($Item_Falling_DiaoWu[%DiaoLuoBao,%i]);
		%Mark = 1;
		if (%Count > 6)//�������������
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
			//echo("�Ӱ����ֵ���һ���Ӱ�===" @ $Item_Falling_DiaoWu[%DiaoLuoBao,%i]);
			%Mark = 0;
		}
		if (%ItemIDOnley == 1)//�����ֻ��һ��
		{
			if (%Npc.Onley[%DiaoLuoBao,%i] == 1)
			{
				//echo("�Ѿ�����һ���� ");
				%Mark = 0;
			}
		}

		%PlayerFuYuan = 1;//��ȡ��Ҹ�Ե
		%ItemIDRan = %ItemIDRan * (1 + %PlayerFuYuan * %ItemIDFuYuan / 10000);
		%RanDom = GetRandom(1,10000);//%ItemIDFuYuan
		if (%RanDom > %ItemIDRan)//û�������
		{
			//echo("û�������,����== "  @ %ItemIDRan  @ "  ���ֵ===" @ %RanDom);
			%Mark = 0;
		}
		if (%Mark == 1)
		{
			if (%ItemIDLen != 9)
			{
				//echo("���Ǹ��Ӱ�==="  @ %ItemID);
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
	if (%ItemIDOnley == 1) //�����Ψһ����
		%Npc.Onley[%DiaoLuoBao,%i] = 1;
	//--------ȷ���ɼ�����--------
	%ItemType = GetItemData(%ItemID,3);
	%CjID = $Lostitem_EventID[%ItemType];
	if (%CjID $= "")
		%CjID = $Lostitem_EventID;

	%Obj_Cj = CreateCollectionObjectEx(%Player.GetPlayerID(),%CjID,%Player.GetPosition(),"0 0 0","0.3 0.3 0.3",60,120,%Player.GetLayerid());
	%Obj_Cj.IsItem = 1;//ϵͳ������
	%ItemName =GetItemData(%ItemID,1);
	%Obj_Cj.SetShapename(%ItemName);//���òɼ�������

	%ItemClor = GetItemData(%ItemID,20);
	switch (%ItemClor)
	{
		//case 1: %Obj_Cj.addpacket( );//��ɫ
		//case 2: %Obj_Cj.addpacket( );//��ɫ
		case 3: %Obj_Cj.addpacket(700001);//��ɫ
		case 4: %Obj_Cj.addpacket(700000);//��ɫ
		case 5: %Obj_Cj.addpacket(700003);//��ɫ
		case 6: %Obj_Cj.addpacket(700002); //��
		case 7: %Obj_Cj.addpacket(700004);//��ɫ
			//default:%Obj_Cj.addpacket( );
	}

	%Obj_Cj.ItemID = %ItemID;
	%Obj_Cj.Master = %Player.GetPlayerID();//������
	%Obj_Cj.MasterName = %Player.GetPlayername();//�����ߵ�����
	%Obj_Cj.ItemObj[0] = %ImteNum;		// ��Ʒ����(����װ����ֻ��Ϊ1)		
}
//CreateCollectionObjectEx( %playerId, %dataBlockId, %pos3F, %angle, %scale, %safetime, %existTime, %layerId );
//CreateCollectionObjectEx( 50000021, 551000000, "-4.64464 97.238 133.579", "0 0 0", "1 1 1", 60, 600, 263053.GetLayerid() );
// 263053 50000021 P_55887799 55887799 -4.64464,97.238,133.579 1 team:0-0
//echo( CreateCollectionObjectEx( 50000021, 553000301, "-16.1063 87.4138 132.952", "0 0 0", "1 1 1", 60, 120, 1 ) );
//
//50000026 P_heheha heheha -5.77805,18.504,127.751 1
//SpNewCj( 262947, 551000000, "-5.77805 18.504 127.751", "1 0 0 0", "2 2 2");
//echo( CreateCollectionObjectEx( 50000026, 551000000, "-5.77805 18.504 127.751", "0 0 0", "1 1 1", 60, 120, 1 ) );
//��������������������������������������ű�������������������������������



//�������������������������������������߽ű�����������������������������
//����Ʒ���ݵ��ɽű��������ݣ�%player.AttachItemObject��������:
//%player.AttachItemObject(%obj, %type, %index);
//

//Quantity;		// ��Ʒ����(����װ����ֻ��Ϊ1)								0   //��Ʒ����                     
//BindPlayer;		// ����ID(Ҳ�����ڴ洢������ӿ��������ID)			1   //����ID                     
//BindFriend;		// �󶨺��ѽ�ɫID����ʹ����Ʒ							2   //�󶨺���ID                   
//ActiveFlag;		// ��Ʒ�����־											3   //��Ʒ�����־                 
//LapseTime;		// ʣ������												4   //ʣ������                     
//RemainUseTimes;	// ʣ��ʹ�ô���											5   //ʣ��ʹ�ô���                 
//LockedLeftTime;	// ��Ʒ��ʣ��ʱ�䣨�룩									6   //��Ʒ��ʣ������               
//Quality;		// ��ƷƷ�ʵȼ�												7   //��ƷƷ�ʵȼ�                 
//CurWear;		// ��ǰ�;ö�												8   //��ǰ�;ö�                   
//CurMaxWear;		// ��ǰ����;ö�										9   //��ǰ����;ö�               
//CurAdroit;		// ��ǰ������											10  //��ǰ������                   
//CurAdroitLv;		// ��ǰ�����ȵȼ�										11  //��ǰ�����ȵȼ�               
//ActivatePro;		// ��������Ч�������־									12  //��������Ч�������־         
//RandPropertyID;	// �����������ID										13  //�����������ID               							  
//IDEProValue0;		// �����󸽼�����ֵ0									14  //�����󸽼�����ֵ0            
//IDEProValue1;		// �����󸽼�����ֵ1									15  //�����󸽼�����ֵ1            
//IDEProValue2;		// �����󸽼�����ֵ2									16  //�����󸽼�����ֵ2            
//IDEProValue3;		// �����󸽼�����ֵ3									17  //�����󸽼�����ֵ3            
//IDEProValue4;		// �����󸽼�����ֵ4									18  //�����󸽼�����ֵ4            
//IDEProValue5;		// �����󸽼�����ֵ5									19  //�����󸽼�����ֵ5            
//IDEProValue6;		// �����󸽼�����ֵ6									20  //�����󸽼�����ֵ6            
//IDEProValue7;		// �����󸽼�����ֵ7									21  //�����󸽼�����ֵ7            
//IDEProValue8;		// �����󸽼�����ֵ8									22  //�����󸽼�����ֵ8            
//IDEProValue9;		// �����󸽼�����ֵ9									23  //�����󸽼�����ֵ9            
//IDEProValue10;	// �����󸽼�����ֵ10									24  //�����󸽼�����ֵ10           
//IDEProValue11;	// �����󸽼�����ֵ11									25  //�����󸽼�����ֵ11           
//EquipStrengthens;	// װ��ǿ��������										26  //װ��ǿ������                 
//EquipStrengthenValue00;//װ��ǿ������ȼ�ֵ1							  	27  //װ��ǿ������ȼ�0            
//EquipStrengthenValue01;//װ��ǿ������ȼ�����ֵ1							28  //װ��ǿ������ȼ�0�ĸ�������ֵ
//EquipStrengthenValue10;//װ��ǿ������ȼ�ֵ2							  	29  //װ��ǿ������ȼ�1            
//EquipStrengthenValue11;//װ��ǿ������ȼ�����ֵ2							30  //װ��ǿ������ȼ�1�ĸ�������ֵ
//EquipStrengthenValue20;//װ��ǿ������ȼ�ֵ3							  	31  //װ��ǿ������ȼ�2            
//EquipStrengthenValue21;//װ��ǿ������ȼ�����ֵ3							32  //װ��ǿ������ȼ�2�ĸ�������ֵ  	  
//WuXingID;						// ����ID									  33  //����ID                            
//WuXingPro;						// ����Ч������						  	  34  //����Ч������             
//SkillAForEquip;					// װ���ϻ�ȡ����������ID				 35  //װ���ϻ�ȡ����������ID 
//SkillBForEquip;					// װ���ϻ�ȡ�ı�������ID				  36  //װ���ϻ�ȡ�ı�������ID 
//EmbedSlot0;		// װ����Ƕ�׵ı�ʯID									  37  //��Ƕ��0�ı�ʯID            
//EmbedSlot1;		// װ����Ƕ�׵ı�ʯID									  38  //��Ƕ��1�ı�ʯID            
//EmbedSlot2;		// װ����Ƕ�׵ı�ʯID									  39  //��Ƕ��2�ı�ʯID            
//EmbedSlot3;		// װ����Ƕ�׵ı�ʯID									  40  //��Ƕ��3�ı�ʯID            
//EmbedSlot4;		// װ����Ƕ�׵ı�ʯID									  41  //��Ƕ��4�ı�ʯID            
//EmbedSlot5;		// װ����Ƕ�׵ı�ʯID									  42  //��Ƕ��5�ı�ʯID            
//EmbedSlot6;		// װ����Ƕ�׵ı�ʯID									  43  //��Ƕ��6�ı�ʯID            
//EmbedSlot7;		// װ����Ƕ�׵ı�ʯID									  44  //��Ƕ��7�ı�ʯID  
//EXPOR_RESERV0,								//��չ����0					 45
//EXPOR_RESERV1,								//��չ����1					 46
//EXPOR_RESERV2,								//��չ����2					 47
//EXPOR_RESERV3,								//��չ����3					 48
//EXPOR_RESERV4,								//��չ����4					 49
//EXPRO_EATLIMIT,								//����ÿ������				50 
//EXPRO_EATCOUNT,								//�������ɴ���				51	 
//EXPRO_GATHERSOULLEVEL,						//����ȼ�					52 
//EXPRO_EATPRO0,								//��������0					53 
//EXPRO_EATPRO1,								//��������1					54 
//EXPRO_ITEMID,								//��Ʒģ��ID					55 

//-------------�ѷ���-------------
//ImpressID;						// ����ID(״̬ID)
//BindProID;						// ���󶨸�������(״̬ID)
//EmbedOpened;					// ������Ƕ�ף�ÿbitλ����һ���ף�
//WuXingLinkID;					// ��������ID
//IDEProNum;		// �����󸽼����Ը���	

//new ItemObject( ItemObj )
//{
//};

//%Player.GetEquip( %pos ); ��ȡָ��װ�����ĵ���ID
//%pos = 0; //δ֪���� 
//%pos = 1; //ͷ�� 
//%pos = 2; //���� 
//%pos = 3; //���� 
//%pos = 4; //�粿 
//%pos = 5; //���� 
//%pos = 6; //�ֲ� 
//%pos = 7; //���� 
//%pos = 8; //�Ų� 
//%pos = 9; //��ָ 
//%pos = 10; //����� 
//%pos = 11; //���� 
//%pos = 12; //���������� 
//%pos = 13; //�ɼ����� 
//%pos = 14; //�������(��UI������) 
//%pos = 15; //�������(��UI������) 
//%pos = 16; //ʱװͷ 
//%pos = 17; //ʱװ���� 
//%pos = 18; //ʱװ���� 
//%pos = 19; //��չ����1 
//%pos = 20; //��չ����2 
//%pos = 21; //������չ�� 
//%pos = 22; //��̯��չ��1 
//%pos = 23; //��̯��չ��2 
//%pos = 24; //��̯��ʽ�� 
//%pos = 25; //����ʱװ 
//DelItemFromInventoryByIndex(50000012, 10, 105103149, 5, 16, 113090002);
//echo(263056.FindItem(1,105103149)); == 3
//263056.AttachItemObject(ItemObj, 2, 3); //2��װ���� 3������λ��
//echo(ItemObj.EmbedSlot0);
//echo(ItemObj.EquipStrengthens);
//%Player.AddItemToEquip(102012193, 1);����װ��

//
$DropEquip[1,11]=101010001;/*1��-սʿ-��ɫ��ǹ*/$DropEquip[1,11]=101020001;/*1��-�̿�-��ɫ����*/$DropEquip[1,11]=101030001;/*1��-��ʦ-��ɫ��ǹ*/$DropEquip[1,11]=101040001;/*1��-��ʿ-��ɫ����*/$DropEquip[1,11]=101050001;/*1��-����-��ɫ����*/
$DropEquip[1,1] =102010001;/*1��-սʿ-��ɫͷ��*/$DropEquip[1,1] =102010101;/*1��-�̿�-��ɫͷ��*/$DropEquip[1,1] =102010201;/*1��-��ʦ-��ɫͷ��*/$DropEquip[1,1] =102010301;/*1��-��ʿ-��ɫͷ��*/$DropEquip[1,1] =102010401;/*1��-����-��ɫͷ��*/
$DropEquip[1,5] =102020001;/*1��-սʿ-��ɫ����*/$DropEquip[1,5] =102020101;/*1��-�̿�-��ɫ����*/$DropEquip[1,5] =102020201;/*1��-��ʦ-��ɫ����*/$DropEquip[1,5] =102020301;/*1��-��ʿ-��ɫ����*/$DropEquip[1,5] =102020401;/*1��-����-��ɫ����*/
$DropEquip[1,3] =102030001;/*1��-սʿ-��ɫ����*/$DropEquip[1,3] =102030101;/*1��-�̿�-��ɫ����*/$DropEquip[1,3] =102030201;/*1��-��ʦ-��ɫ����*/$DropEquip[1,3] =102030301;/*1��-��ʿ-��ɫ����*/$DropEquip[1,3] =102030401;/*1��-����-��ɫ����*/
$DropEquip[1,4] =102040001;/*1��-սʿ-��ɫ�粿*/$DropEquip[1,4] =102040101;/*1��-�̿�-��ɫ�粿*/$DropEquip[1,4] =102040201;/*1��-��ʦ-��ɫ�粿*/$DropEquip[1,4] =102040301;/*1��-��ʿ-��ɫ�粿*/$DropEquip[1,4] =102040401;/*1��-����-��ɫ�粿*/
$DropEquip[1,6] =102050001;/*1��-սʿ-��ɫ�ֲ�*/$DropEquip[1,6] =102050101;/*1��-�̿�-��ɫ�ֲ�*/$DropEquip[1,6] =102050201;/*1��-��ʦ-��ɫ�ֲ�*/$DropEquip[1,6] =102050301;/*1��-��ʿ-��ɫ�ֲ�*/$DropEquip[1,6] =102050401;/*1��-����-��ɫ�ֲ�*/
$DropEquip[1,7] =102060001;/*1��-սʿ-��ɫ����*/$DropEquip[1,7] =102060101;/*1��-�̿�-��ɫ����*/$DropEquip[1,7] =102060201;/*1��-��ʦ-��ɫ����*/$DropEquip[1,7] =102060301;/*1��-��ʿ-��ɫ����*/$DropEquip[1,7] =102060401;/*1��-����-��ɫ����*/
$DropEquip[1,8] =102070001;/*1��-սʿ-��ɫ�Ų�*/$DropEquip[1,8] =102070101;/*1��-�̿�-��ɫ�Ų�*/$DropEquip[1,8] =102070201;/*1��-��ʦ-��ɫ�Ų�*/$DropEquip[1,8] =102070301;/*1��-��ʿ-��ɫ�Ų�*/$DropEquip[1,8] =102070401;/*1��-����-��ɫ�Ų�*/
$DropEquip[1,10]=103010001;/*1��-սʿ-��ɫ����*/$DropEquip[1,10]=103010101;/*1��-�̿�-��ɫ����*/$DropEquip[1,10]=103010201;/*1��-��ʦ-��ɫ����*/$DropEquip[1,10]=103010301;/*1��-��ʿ-��ɫ����*/$DropEquip[1,10]=103010401;/*1��-����-��ɫ����*/
$DropEquip[1,2] =103020001;/*1��-սʿ-��ɫ����*/$DropEquip[1,2] =103020101;/*1��-�̿�-��ɫ����*/$DropEquip[1,2] =103020201;/*1��-��ʦ-��ɫ����*/$DropEquip[1,2] =103020301;/*1��-��ʿ-��ɫ����*/$DropEquip[1,2] =103020401;/*1��-����-��ɫ����*/
$DropEquip[1,9] =103030001;/*1��-սʿ-��ɫ��ָ*/$DropEquip[1,9] =103030101;/*1��-�̿�-��ɫ��ָ*/$DropEquip[1,9] =103030201;/*1��-��ʦ-��ɫ��ָ*/$DropEquip[1,9] =103030301;/*1��-��ʿ-��ɫ��ָ*/$DropEquip[1,9] =103030401;/*1��-����-��ɫ��ָ*/


$Lostitem_EventID[201] = 551000001; //ͷ��  ���߷���==201
$Lostitem_EventID[302] = 551000002; //����  ���߷���==302
$Lostitem_EventID[203] = 551000003; //����  ���߷���==203
$Lostitem_EventID[204] = 551000004; //�粿  ���߷���==204
$Lostitem_EventID[202] = 551000005; //����  ���߷���==202
$Lostitem_EventID[205] = 551000006; //�ֲ�  ���߷���==205
$Lostitem_EventID[206] = 551000007; //����  ���߷���==206
$Lostitem_EventID[207] = 551000008; //�Ų�  ���߷���==207
$Lostitem_EventID[303] = 551000009; //��ָ  ���߷���==303
$Lostitem_EventID[301] = 551000010; //����  ���߷���==301
$Lostitem_EventID[104] = 551000011; //����  ���߷���==104
$Lostitem_EventID[1701]= 551000012; //����  ���߷���==1701
$Lostitem_EventID = 551000000;	//ͨ��
$Lostitem_EventID_Money = 551000013;//���

function PlayerDeath_Lostitem(%Player,%Killer)
{
	//-------------------����Ҫ���������Ʒ-------------
	%ShaLu = %Player.GetPkValue(); //��ȡ�ƶ�ֵ
	//%Player.SetPkValue(%SL);�����ƶ�ֵ

	%EqLost = %ShaLu + 1;//�����װ������
	%ItemLost = %ShaLu + 3;//�����ڵ������Ʒ����

	if (%EqLost  == 0 && %ItemLost == 0)//����Ҫ���䶫��
		return;
	//--------------------ȡ�����е�װ��--------------
	%EquipNum = 0;
	for (%pos = 1; %pos<=11; %pos++)
	{
		%EquipID = %Player.GetEquip(%pos);// ��ȡָ��װ�����ĵ���ID
		if (%EquipID != 0)
		{
			%Equip[%EquipNum] = %pos;//�������װ����λ��
			%EquipNum++;
		}

	}
	//--------------------ȡ�����������е���--------------
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
	//-----------------------�����ܵ�����ٵ���-----------
	if (%EquipNum < 1 && %Num  < 1)//����������ʲô��û��
		return;
	if (%EqLost >  %EquipNum)
		%EqLost = %EquipNum;//û����ô���װ���ɵ���
	if (%ItemLost >  %Num)
		%ItemLost =  %Num;//������û����ô��Ķ������Ե�
	//-----------����Ҫ������Щλ��---------------
	%EQLostList = GetRandomNum(%EqLost,0,%EquipNum-1);//Ҫ�����װ����λ��
	%ItemLostList = GetRandomNum(%ItemLost,0,%Num-1);//������Ҫ�����λ��
	//echo( "%EQLostList == " @ %EQLostList );
	//echo( "%ItemLostList == " @ %ItemLostList );
	%Player.LostItemRecord = "";
	//-----------��ʼ����----------------
	for (%i = 0; %i < %EqLost; %i++)
	{
		%Pos = GetWord(%EQLostList,%i);
		%RelPos = %Equip[%Pos];//���λ�õ�װ������
		//echo( "%Pos ==" @ %Pos );
		//echo( "%RelPos ==" @ %RelPos );
		DropEquipOrItem(%Player,2,%RelPos);//ִ�е��亯��
	}
	for (%i = 0; %i < %ItemLost; %i++)
	{
		%Pos = GetWord(%ItemLostList,%i);
		%RelPos = %Item[%Pos];//�������λ�õĵ��ߵ���

		//echo( "%Pos ==" @ %Pos );
		//echo( "%RelPos ==" @ %RelPos );
		DropEquipOrItem(%Player,1,%RelPos);//ִ�е��亯��
	}
	//----���������ʼ�-------------
	%Count = GetWordCount(%Player.LostItemRecord);
	for (%i = 0; %i < %Count; %i++)
	{
		%ItemID = GetWord(%Player.LostItemRecord,%i);
		//%ItemName	  = "<l i='" @ %ItemID @ "' t='itemid'/>" @ " " @ %ItemName;
		%Clor = GetItemData(%ItemID,20);
		switch (%Clor)
		{
			case 1: %Ziti = $Get_Dialog_GeShi[31407];//��ɫ
			case 2: %Ziti = $Get_Dialog_GeShi[31401];//��ɫ
			case 3: %Ziti = $Get_Dialog_GeShi[31403];//��ɫ
			case 4: %Ziti = $Get_Dialog_GeShi[31402];//��ɫ
			case 5: %Ziti = $Get_Dialog_GeShi[31409];//��ɫ
			case 6: %Ziti = "<t f='����' m='1' n='12' c='0xff6e00ff' o='0x010101ff'>";//��
			case 7: %Ziti = $Get_Dialog_GeShi[31406];//��ɫ
			default: %Ziti = $Get_Dialog_GeShi[31401];
		}// �� 2 �� 3 ��  4 �� 5 �� 6
		//echo( "%Clor==" @ %Clor @ "  " @ %ItemName );
		%Name =GetItemData(%ItemID,1);

		%ItemName = %Ziti @  "[" @ %Name @ "]</t>" @ " " @ %ItemName;
	}

	//�����ʼ�����
	%Title = "����֪ͨ";
	%Txt = $Get_Dialog_GeShi[31422] @ "����[ "@ %Killer.GetPlayerName() @" ] ���ܡ�</t><b/>"@
		$Get_Dialog_GeShi[31406] @ "<t>���ҵ��䣺</t><b/><t>" @ %ItemName @ "</t>";
	//echo( %Txt );

	//�����ʼ�
	SptMail_Send(%Player.GetPlayerid(),0,0,0,0,%Title,%Txt);
}
function DropEquipOrItem(%Player,%OPtype,%Pos)//���ϵ���װ�� %pos ���䲿λ
{
	%PlayerID = %Player.GetPlayerID();
	%CopyMapID = %Player.GetLayerID();

	%Player.AttachItemObject(ItemObj,%OPtype,%Pos);//�Ȱѵ������Ʒ��������
	switch (%optype)
	{
		case 2://��������ϵ���װ��
			%ItemID = %Player.GetEquip(%pos);// ��ȡָ��װ�����ĵ���ID

			%Player.AddItemToEquip($DropEquip[%Player.GetClasses(0),%Pos],%Pos); //����װ��
			//--------ȷ���ɼ�����--------
			%ItemType = GetItemData(%ItemID,3);
			%CjID = $Lostitem_EventID[%ItemType];
			if (%CjID $= "")
				%CjID = $Lostitem_EventID;
		case 1://�����ڵ���
			if (ItemObj.Quantity > 0)//������������0
				ItemObj.Quantity = GetRandom(1,ItemObj.Quantity);//����������ɸ�

			%ItemID = GetWord(%Player.Getitemnum(%Pos),0,",");
			//echo( "%Player.Getitemnum( %Pos )==" @ %Player.Getitemnum( %Pos ) @ "    %Pos ==" @ %Pos );
			//echo( "%ItemID ===" @ %ItemID );

			DelItemFromInventoryByIndex(%PlayerID,%Pos,%ItemID,ItemObj.Quantity,20,%ItemID);
			//--------ȷ���ɼ�����--------
			%ItemType = GetItemData(%ItemID,3);
			%CjID = $Lostitem_EventID[%ItemType];
			if (%CjID $= "")
				%CjID = $Lostitem_EventID;
		case 3://��Ǯ��

			//--------ȷ���ɼ�����--------
			%CjID = $Lostitem_EventID_Money;
	}

	//echo( "%ItemID==" @ %ItemID );
	//---------------------------��������------------------
	//%ItemName = $Get_Dialog_GeShi[ 31419 ] @ "[" @ GetItemData( %ItemID, 1 ) @ "]</t>";//��ȡװ������
	%Clor = GetItemData(%ItemID,20);
	%ItemName =GetItemData(%ItemID,1);
	%Png = GetItemData(%ItemID,7);
	if (%Clor >= 5)
	{
		switch (%Clor)
		{
			case 1: %Ziti = $Get_Dialog_GeShi[31407];//��ɫ
			case 2: %Ziti = $Get_Dialog_GeShi[31401];//��ɫ
			case 3: %Ziti = $Get_Dialog_GeShi[31403];//��ɫ
			case 4: %Ziti = $Get_Dialog_GeShi[31402];//��ɫ
			case 5: %Ziti = $Get_Dialog_GeShi[31409];//��ɫ
			case 6: %Ziti = "<t f='����' m='1' n='12' c='0xff6e00ff' o='0x010101ff'>";//��
			case 7: %Ziti = $Get_Dialog_GeShi[31406];//��ɫ
			default: %Ziti = $Get_Dialog_GeShi[31401];
		}// �� 2 �� 3 ��  4 �� 5 �� 6
		//echo( "%Clor==" @ %Clor @ "  " @ %ItemName );
		%Path = "</t><l i='" @ "8" @ GetSubStr(GetZoneid(),0,4) @ "0100 " @ %Player.GetPosition() @ "' t='path'/>";

		%Text =  %Ziti @  "[" @ %ItemName @ "]</t>" @ $Get_Dialog_GeShi[31419] @ "�ӡ�" @ %Player.GetPlayerName()@ "�����ϵ�����" @ %Path @ "</t>";
		SendOneLineMessage(%Text);//�����
	}
	//-----------------��¼����--------------
	%Player.LostItemRecord = %ItemID @ " " @ %Player.LostItemRecord;
	//---------------------------�����������------------------
	%Pos = %Player.GetPosition();
	%Pos = GetNavPos(GetWord(%Pos,0),GetWord(%Pos,1),3);

	%Obj_Cj = CreateCollectionObjectEx(%PlayerID,%CjID,%Pos,"0 0 0","0.3 0.3 0.3",0,120,%CopyMapID);

	%Obj_Cj.IsItem = 2;//��ҵ�������
	//echo( "%Obj_Cj ===  " @ %Obj_Cj );
	//%Obj_Cj.SetExclusivePlayerName( " " );//���óƺ�
	%Obj_Cj.SetShapename(%ItemName);//���òɼ�������

	switch (%Clor)
	{
		case 3: %Obj_Cj.addpacket(700001);//��ɫ
		case 4: %Obj_Cj.addpacket(700000);//��ɫ
		case 5: %Obj_Cj.addpacket(700003);//��ɫ
		case 6: %Obj_Cj.addpacket(700002); //��
		case 7: %Obj_Cj.addpacket(700004);//��ɫ
	}
	//echo( "%Png===="@ %Png );
	//%Obj_Cj.SetShapeImage( %ItemID @ ".png" );

	%Obj_Cj.ItemID = %ItemID;
	%Obj_Cj.Master = %PlayerID;//������
	%Obj_Cj.MasterName = %Player.GetPlayername();//�����ߵ�����
	%Obj_Cj.ItemObj[0] = ItemObj.Quantity;		// ��Ʒ����(����װ����ֻ��Ϊ1)					
	%Obj_Cj.ItemObj[1] = ItemObj.BindPlayer;		// ����ID(Ҳ�����ڴ洢������ӿ��������ID
	%Obj_Cj.ItemObj[2] = ItemObj.BindFriend;		// �󶨺��ѽ�ɫID����ʹ����Ʒ				
	%Obj_Cj.ItemObj[3] = ItemObj.ActiveFlag;		// ��Ʒ�����־								
	%Obj_Cj.ItemObj[4] = ItemObj.LapseTime;		// ʣ������
	%Obj_Cj.ItemObj[5] = ItemObj.RemainUseTimes;	// ʣ��ʹ�ô���								
	%Obj_Cj.ItemObj[6] = ItemObj.LockedLeftTime;	// ��Ʒ��ʣ��ʱ�䣨�룩						
	%Obj_Cj.ItemObj[7] = ItemObj.Quality;		// ��ƷƷ�ʵȼ�									
	%Obj_Cj.ItemObj[8] = ItemObj.CurWear;		// ��ǰ�;ö�									
	%Obj_Cj.ItemObj[9] = ItemObj.CurMaxWear;		// ��ǰ����;ö�							
	%Obj_Cj.ItemObj[10] = ItemObj.CurAdroit;		// ��ǰ������								
	%Obj_Cj.ItemObj[11] = ItemObj.CurAdroitLv;		// ��ǰ�����ȵȼ�							
	%Obj_Cj.ItemObj[12] = ItemObj.ActivatePro;		// ��������Ч�������־						
	%Obj_Cj.ItemObj[13] = ItemObj.RandPropertyID;	// �����������ID							
	%Obj_Cj.ItemObj[14] = ItemObj.IDEProValue0;		// �����󸽼�����ֵ0						
	%Obj_Cj.ItemObj[15] = ItemObj.IDEProValue1;		// �����󸽼�����ֵ1						
	%Obj_Cj.ItemObj[16] = ItemObj.IDEProValue2;		// �����󸽼�����ֵ2						
	%Obj_Cj.ItemObj[17] = ItemObj.IDEProValue3;		// �����󸽼�����ֵ3						
	%Obj_Cj.ItemObj[18] = ItemObj.IDEProValue4;		// �����󸽼�����ֵ4						
	%Obj_Cj.ItemObj[19] = ItemObj.IDEProValue5;		// �����󸽼�����ֵ5						
	%Obj_Cj.ItemObj[20] = ItemObj.IDEProValue6;		// �����󸽼�����ֵ6						
	%Obj_Cj.ItemObj[21] = ItemObj.IDEProValue7;		// �����󸽼�����ֵ7						
	%Obj_Cj.ItemObj[22] = ItemObj.IDEProValue8;		// �����󸽼�����ֵ8						
	%Obj_Cj.ItemObj[23] = ItemObj.IDEProValue9;		// �����󸽼�����ֵ9						
	%Obj_Cj.ItemObj[24] = ItemObj.IDEProValue10;	// �����󸽼�����ֵ10						
	%Obj_Cj.ItemObj[25] = ItemObj.IDEProValue11;	// �����󸽼�����ֵ11						
	%Obj_Cj.ItemObj[26] = ItemObj.EquipStrengthens;	// װ��ǿ��������							
	%Obj_Cj.ItemObj[27] = ItemObj.EquipStrengthenValue00;//װ��ǿ������ȼ�ֵ1					
	%Obj_Cj.ItemObj[28] = ItemObj.EquipStrengthenValue01;//װ��ǿ������ȼ�����ֵ1				
	%Obj_Cj.ItemObj[29] = ItemObj.EquipStrengthenValue10;//װ��ǿ������ȼ�ֵ2					
	%Obj_Cj.ItemObj[30] = ItemObj.EquipStrengthenValue11;//װ��ǿ������ȼ�����ֵ2				
	%Obj_Cj.ItemObj[31] = ItemObj.EquipStrengthenValue20;//װ��ǿ������ȼ�ֵ3					
	%Obj_Cj.ItemObj[32] = ItemObj.EquipStrengthenValue21;//װ��ǿ������ȼ�����ֵ3				
	%Obj_Cj.ItemObj[33] = ItemObj.WuXingID;						// ����ID						
	%Obj_Cj.ItemObj[34] = ItemObj.WuXingPro;						// ����Ч������				
	%Obj_Cj.ItemObj[35] = ItemObj.SkillAForEquip;					// װ���ϻ�ȡ����������ID	
	%Obj_Cj.ItemObj[36] = ItemObj.SkillBForEquip;					// װ���ϻ�ȡ�ı�������ID	
	%Obj_Cj.ItemObj[37] = ItemObj.EmbedSlot0;		// װ����Ƕ�׵ı�ʯID						
	%Obj_Cj.ItemObj[38] = ItemObj.EmbedSlot1;		// װ����Ƕ�׵ı�ʯID						
	%Obj_Cj.ItemObj[39] = ItemObj.EmbedSlot2;		// װ����Ƕ�׵ı�ʯID						
	%Obj_Cj.ItemObj[40] = ItemObj.EmbedSlot3;		// װ����Ƕ�׵ı�ʯID						
	%Obj_Cj.ItemObj[41] = ItemObj.EmbedSlot4;		// װ����Ƕ�׵ı�ʯID						
	%Obj_Cj.ItemObj[42] = ItemObj.EmbedSlot5;		// װ����Ƕ�׵ı�ʯID						
	%Obj_Cj.ItemObj[43] = ItemObj.EmbedSlot6;		// װ����Ƕ�׵ı�ʯID						
	%Obj_Cj.ItemObj[44] = ItemObj.EmbedSlot7;		// װ����Ƕ�׵ı�ʯID						
	%Obj_Cj.ItemObj[45] = ItemObj.EXPOR_RESERV0;								//��չ����0		
	%Obj_Cj.ItemObj[46] = ItemObj.EXPOR_RESERV1;								//��չ����1		
	%Obj_Cj.ItemObj[47] = ItemObj.EXPOR_RESERV2;								//��չ����2		
	%Obj_Cj.ItemObj[48] = ItemObj.EXPOR_RESERV3;								//��չ����3		
	%Obj_Cj.ItemObj[49] = ItemObj.EXPOR_RESERV4;								//��չ����4		
	%Obj_Cj.ItemObj[50] = ItemObj.EXPRO_EATLIMIT;								//����ÿ������	
	%Obj_Cj.ItemObj[51] = ItemObj.EXPRO_EATCOUNT;								//�������ɴ���	
	%Obj_Cj.ItemObj[52] = ItemObj.EXPRO_GATHERSOULLEVEL;						//����ȼ�		
	%Obj_Cj.ItemObj[53] = ItemObj.EXPRO_EATPRO0;								//��������0		
	%Obj_Cj.ItemObj[54] = ItemObj.EXPRO_EATPRO1;								//��������1		
	//%Obj_Cj.ItemObj[ 55 ] = ItemObj.EXPRO_ITEMID;								//��Ʒģ��ID		
	%Obj_Cj.ItemObj[55] = %ItemID;
	//--------------�������-------------
	//echo( "------------------------" );
	//echo( %Obj_Cj.ItemID );
	//echo( %ItemName );
	//echo( %Obj_Cj.ItemObj[ 0 ] );
	//echo( %Obj_Cj.Master );//������
	//echo( %Obj_Cj.MasterName );//�����ߵ�����
	//for ( %i = 0; %i<=55; %i++ )
	//{
	//	echo( "λ��" @ %i @ "���ݣ�" @ %Obj_Cj.ItemObj[ %i ] );
	//}
}
function TsNpcOnTrigger_400000000(%Conv,%Npc,%Player,%State,%Param)
{
	%Conv.Settype(4);
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"���İ����ռ䲻�㣬�������������",%Player);
		SendOneChatMessage($chatMsg_System,"<t>���İ����ռ䲻�㣬�������������</t>",%Player);
		return;
	}
	%PlayerID = %Player.GetPlayerID();
	//echo( " Player===" @ %Player );
	//echo( " npc===" @ %npc );
	//echo( " npcID===" @ %npcID );
	//echo( " PlayerID===" @ %PlayerID );
	%Index = %Player.Putitem(%npc.ItemID,%npc.ItemObj[0]);
	//echo( "%npc.ItemID===" @ %npc.ItemID );
	%player.setPutItemProduceName(%Index,"�ӡ�" @ %npc.MasterName @ "�����ɻ��ս��Ʒ");

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

function GetEquiptest(%Player)//���������ϵ�װ����Ϣ
{
	for (%pos = 0; %pos<=20; %pos++)
	{
		%ItemID = %Player.GetEquip(%pos);// ��ȡָ��װ�����ĵ���ID
		%ItemName = GetItemData(%ItemID,1);//��ȡװ������
		echo("%pos====" @ %pos @ "  %ItemID ==" @ %ItemID  @ " %ItemName==" @ %ItemName  @ "  ���߷���==" @ GetItemData(%ItemID,3));
	}
}
function TriggerEvent_551000000(%Player,%Event,%EventID)
{
	//echo( "%Player ==" @ %Player );
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"���İ����ռ䲻�㣬�������������",%Player);
		SendOneChatMessage($chatMsg_System,"<t>���İ����ռ䲻�㣬�������������</t>",%Player);
		return false;
	}
	%PlayerID = %Player.GetPlayerID();

	if (%Event.IsItem == 1)//ϵͳ�����
	{
		%Index = %Player.Putitem(%Event.ItemID,%Event.ItemObj[0]);
		%Event.IsItem = 9999;
		if (%Player.additem(4,%npcID))
			return true;
	}
	else if (%Event.IsItem == 2)//��������ϵ���
	{
		%Index = %Player.Putitem(%Event.ItemID,%Event.ItemObj[0]);
		%player.setPutItemProduceName(%Index,"�ӡ�" @ %Event.MasterName @ "�����ɻ��ս��Ʒ");
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
//�������������������������������������߽ű�����������������������������
//createCropObject(50000021,300000,SptGetPlayer(50000021).Getposition());
