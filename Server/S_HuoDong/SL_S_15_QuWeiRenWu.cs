//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//Ȥζ����
//
//==================================================================================
//�����������������������������������������������������������������������
//������������������������ȡԪ�����ġ�������������������������������������
//������������������������ȡ���齱����������������������������������������
//��������������������������ʹ�ô�����������������������������������������







//�����������������������������������������������������������������������
function SpecialItem_DaoJing_KillMonster(%Monster,%Player)
{
	%Monster.iskilled = 0;
	if($SpecialItem_DaoJing_bActive*1 < 1)
		return;
	
	if(!IsObject(%Monster) || !IsObject(%Player))
		return;
	
	%map = GetSubStr(GetZoneID(),1,1)*1;
	if(%map == 3)
		return;
	
	%Plv = %Player.GetLevel();
	%Mlv = %Player.GetLevel();
	if(%Mlv < 30 || Mabs(%Plv-%Mlv) > 8)
		return;
	
	if(GetRandom(1,10000) <= 7)
	{
		if(GetRandom(1,2) % 2)
			%itemID = 105109066;
		else
			%itemID = 105109065;
		
		AddItem_BaoGuoNo_Mail(%Player,%ItemID,1,0,0);
	}
}



//������������������������ȡ���齱����������������������������������������
function SpecialItem_DaoJing_GetExpCnt(%Player, %type)
{
	%Plv = %Player.GetLevel();
	%ActiveAA = GetAct(%Player,4300,0)*1 + 1;
	%BaseExp = $Monster_Exp[%Plv,1] * 300;
	
	if(%type == 2)	//СǮ
	{
		%NewExp = %BaseExp;
		if(GetRandom(1,100) > 60)
			%NewExp = %BaseExp * 2;
		if(GetRandom(1,1000) <= %ActiveAA*5)
			%NewExp = %NewExp * 2;
	}
	else if(%type == 3)	//��Ǯ
	{
		%NewExp = %BaseExp * 2;
		if(GetRandom(1,1000) <= %ActiveAA*5)
			%NewExp = %NewExp * 2;
	}
	else	//���
	{
		%NewExp = %BaseExp;
		if(GetRandom(1,100) > 50)
			%NewExp = %BaseExp * 2;
	}
	
	%Player.DaoJingExpTimes = Mfloor(%NewExp/%BaseExp);
		
	return %NewExp;
}




//��������������������������ʹ�ô�����������������������������������������
function Trigger_105109065(%Conv,%Player,%itemID,%State,%TriggerType,%TriggerID,%Param,%XYZ){Trigger_SpecialItem_DaoJing(%Player,105109067);}
function Trigger_105109066(%Conv,%Player,%itemID,%State,%TriggerType,%TriggerID,%Param,%XYZ){Trigger_SpecialItem_DaoJing(%Player,105109067);}
function Trigger_SpecialItem_DaoJing(%Player,%itemID)
{
	if(%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"������������ȷ��������������1���λ��",%Player);
		return;
	}
	
	%Player.PutItem(105109065,-1);
	%Player.PutItem(105109066,-1);
	%Player.PutItem(%itemID,1);
	%Player.AddItem(1,%itemID);
}

function Trigger_105109067(%Conv,%Player,%itemID,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{	
	%Conv.Reset();
	%Conv.SetTriggerType(1);
	%Conv.SetTriggerMission(%ItemID);
	%Conv.SetType(1);
	
	%BaseExp = $Monster_Exp[%Player.GetLevel(),1] * 300;
	switch(%State)
	{
		case 0:
			if($SpecialItem_DaoJing_bActive*1 < 1)
			{
				%Conv.SetText(600000114);
				%Conv.AddOption(4,0);
			}
			else
			{
				%Conv.SetText(600000110);
				%Conv.AddOption(600000111, 600000111);
				%Conv.AddOption(600000112, 600000112);
				%Conv.AddOption(600000113, 600000113);
			}
			
		case 600000111:
			if(%Player.GetSchBuff(2044) > 0)
			{
				%Conv.SetText(600000115);
				%Conv.AddOption(4,0);
			}
			else
			{
				%Player.PutItem(%itemID,-1);
				if(%Player.AddItem(4,%itemID))
				{
					%Exp = SpecialItem_DaoJing_GetExpCnt(%Player, 1);
					AllAddExp(%Player, %Exp);
					if(%Exp > %BaseExp)
					{
						%EnoughYB = 1;
						SendOneChatMessage($chatMsg_Person,"<t>��ϲ�����˫�����齱����</t>",%Player);
					}
					%Player.SetSchBuff(2044);
				}
				Trigger_105109067(%Conv,%Player,%itemID,0,%TriggerType,%TriggerID,%Param,%XYZ);
			}
	}
	
	if(%State == 600000112 || %State == 600000113)
	{
		%type = %State - 600000110;
		%NeedYB = SpecialItem_DaoJing_GetYuanBaoExpend(%Player, %type);
		%Exp = SpecialItem_DaoJing_GetExpCnt(%Player, %type);
		%ActiveAA = GetAct(%Player,4300,0)*1 + 1;

		if(%ActiveAA > 20)
		{
			%Conv.SetText(600000117);
			%Conv.AddOption(4,0);
		}
		else if(%Player.GetMoney(1) < %NeedYB)
		{
			%Conv.SetText(600000116);
			%Conv.AddOption(4,0);
		}
		else
		{
			%EnoughYB = 1;
			%Player.PutItem(%itemID,-1);
			if(%Player.AddItem(4,%itemID))
			{
				%Player.ReduceMoney(%NeedYB,1,4,%itemID);
				
				if(Mfloor(%Exp / %BaseExp) == 2)
				{
					AllAddExp(%Player, %Exp);
					SendOneChatMessage($chatMsg_Person,"<t>��ϲ�����˫�����飡</t>",%Player);
				}
				else if(Mfloor(%Exp / %BaseExp) == 4)
				{
					AllAddExp(%Player, Mfloor(%Exp/2));
					SendOneChatMessage($chatMsg_Person,"<t>��ϲ�����˫�����飡</t>",%Player);
					AllAddExp(%Player, Mfloor(%Exp/2));
					SendOneChatMessage($chatMsg_Person,"<t>��ϲ�������ֻ����һ�α����������飡</t>",%Player);
				}
				else AllAddExp(%Player, %Exp);
				SetAct(%Player, 4300, %ActiveAA, 0);
			}
			Trigger_105109067(%Conv,%Player,%itemID,0,%TriggerType,%TriggerID,%Param,%XYZ);
		}
	}
	
	if(%EnoughYB *1 > 0)
	{
		%ItemName = GetItemName(%ItemID,1);
		%Playername = GetPlayerZiTiName(%Player,1);
		if(%Player.DaoJingExpTimes == 2)
		{
			%Msg ="<t>��������</t>" @ %Playername @ "<t>��ʹ��</t>"@ %ItemName @"<t>ʱ�������</t>"@ $Get_Dialog_GeShi[31420] @"˫��</t><t>�ľ��齱����</t>";
		}
		else if(%Player.DaoJingExpTimes == 4)
		{
			%Msg ="<t>ز������</t>" @ %Playername @ "<t>��ʹ��</t>"@ %ItemName @"<t>ʱ�������</t>"@ $Get_Dialog_GeShi[31420] @"˫��</t><t>���飬�Ҷ����ֻ����һ��</t>"@ $Get_Dialog_GeShi[31420] @"��������</t><t>���飡</t>";
		}
		if(%Msg !$= "")
		{
			SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Msg @ "</t>");
			SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Msg @ "</t>", $chatMsg_Type_Normal2);
		}
		%Player.DaoJingExpTimes  = 0;
	}
	
	%Conv.Send(%Player);
}