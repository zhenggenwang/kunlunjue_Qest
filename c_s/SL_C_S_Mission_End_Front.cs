//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//�������ǰ���ж�
//==================================================================================


//===============================�������ͻ��˹��õ�===============================
//case 1: %MidName = "Mission_End_Front_"@ %Mid;			//�������ǰ���ж�
/*����:
function Mission_End_Front_32544(%Npc, %Player, %Conv, %Param, %Mid)
{
//�ж�����Ʒ���Ƿ񵽴�10��
%ItemGet[1] = %Player.GetMissionFlag(%Mid, 2101);
if(%Player.GetDeityWeaponPJ(%ItemGet[1]) < 9)
return 60 @ 1000360;

if(%Player.SptIsHasGem(%ItemGet[1]) == 1)
return 60 @ 1000361;

return "";
}
*/
function Mission_End_Front_10032(%Npc,%Player,%Conv,%Param,%Mid)//װ������
{
	%ItemID = %Player.GetEquip(11);// ��ȡ��������ID
	if (%ItemID < 1)
	{
		SendOneScreenMessage(2,"�㻹û��װ��������",%Player);
		SendOneChatMessage($chatMsg_System,"<t>�㻹û��װ��������</t>",%Player);
		return -1;
	}
	return "";
}

//--------�����һ�������--------------
function Mission_End_Front_30101(%Npc,%Player,%Conv,%Param,%Mid)//�ڿ�
{
	%ItemID = %Player.GetEquip(13);// ��ȡ�������ID
	if (%ItemID != 107020001 && %ItemID != 107020002 && %ItemID != 107020003)
	{
		SendOneScreenMessage(2,"װ������ſ����������",%Player);
		SendOneChatMessage($chatMsg_System,"<t>װ������ſ����������</t>",%Player);
		return -1;
	}
	return "";
}
function Mission_End_Front_30111(%Npc,%Player,%Conv,%Param,%Mid)//��ľ
{
	%ItemID = %Player.GetEquip(13);
	if (%ItemID != 107040001 && %ItemID != 107040002 && %ItemID != 107040003)
	{
		SendOneScreenMessage(2,"װ�������ſ����������",%Player);
		SendOneChatMessage($chatMsg_System,"<t>װ�������ſ����������</t>",%Player);
		return -1;
	}
	return "";
}
function Mission_End_Front_30121(%Npc,%Player,%Conv,%Param,%Mid)//��ҩ
{
	%ItemID = %Player.GetEquip(13);
	if (%ItemID != 107010001 && %ItemID != 107010002 && %ItemID != 107010003)
	{
		SendOneScreenMessage(2,"װ�������ſ����������",%Player);
		SendOneChatMessage($chatMsg_System,"<t>װ�������ſ����������</t>",%Player);
		return -1;
	}
	return "";
}
function Mission_End_Front_30131(%Npc,%Player,%Conv,%Param,%Mid)//����
{
	%ItemID = %Player.GetEquip(13);
	if (%ItemID != 107050001 && %ItemID != 107050002 && %ItemID != 107050003)
	{
		SendOneScreenMessage(2,"װ����Ͳſ����������",%Player);
		SendOneChatMessage($chatMsg_System,"<t>װ����Ͳſ����������</t>",%Player);
		return -1;
	}
	return "";
}



//�������������������������������������ǰ���жϡ�������������
function Mission_End_Front_20002(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//�һ�֮��
function Mission_End_Front_20003(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//�������
function Mission_End_Front_20001(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//����֮��
function Mission_End_Front_20004(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//��������
function Mission_End_Front_20005(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,"399030001 399040001"); }//��װ��ҩ
function Mission_End_Front_20006(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,"399060001 399060002 399060003"); }//����֮�顤һ
function Mission_End_Front_20007(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//����֮�顤��
function Mission_End_Front_20008(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//������ħ
function Mission_End_Front_20009(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//����֮��
function Mission_End_Front_20010(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//�һ�֮��
function Mission_End_Front_20011(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//�������
function Mission_End_Front_20012(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//��������
function Mission_End_Front_20013(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,"399030001 399040001"); }//��װ��ҩ
function Mission_End_Front_20014(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,"399060001 399060002 399060003"); }//����֮�顤һ
function Mission_End_Front_20015(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//����֮�顤��
function Mission_End_Front_20016(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//������ħ
function Mission_End_Front_20017(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//����֮��
function Mission_End_Front_20018(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//�һ�֮��
function Mission_End_Front_20019(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//�������
function Mission_End_Front_20020(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//��������
function Mission_End_Front_20021(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,"399030001 399040001"); }//��װ��ҩ
function Mission_End_Front_20022(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,"399060001 399060002 399060003"); }//����֮�顤һ
function Mission_End_Front_20023(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//����֮�顤��
function Mission_End_Front_20024(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Front_20001_20024(%Npc,%Player,%Conv,%Param,%Mid,0); }//������ħ
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
		SendOneScreenMessage(2,"�������״̬�Ѿ���ʧ�������²ɼ�",%Player);
		return -1;
	}
	return "";
}

//�������������������������������������ǰ���жϡ�������������

function Mission_End_Front_20149(%Npc,%Player,%Conv,%Param,%Mid)
{
	if (%Player.GetBagEmptyCount() < 1)
	{
		SendOneScreenMessage(2,"��Ԥ��һ�����ϵİ����ո�",%Player);
		SendOneChatMessage($chatMsg_System,"<t>��Ԥ��һ�����ϵİ����ո�</t>",%Player);
		return -1;
	}
	if (%Player.Isschbuff(2021))
	{
		SendOneScreenMessage(2,"��ħ���壬�޷�����ʦ������",%Player);
		SendOneChatMessage($chatMsg_System,"<t>��ħ���壬�޷�����ʦ������</t>",%Player);
		return -1;
	}
	return "";
}