//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//����ֻ��¼ 1 �� 0ֵ�Ļ��¼   ������ ���밴˳�� �� ������������ ����C_S_activityrecord����
//
//==================================================================================


//��������������������������¼��������������������������������������������������
//%bit:��¼���
//SetSrc( %Player, 1);
function SetSrc(%Player,%bit)//%bit ��Ӧ�ı��
{
	//echo( "%bit:��¼���%bit====" @ %bit @ "  $Src_ReturnTime_ActivityID==" @ $Src_ReturnTime_ActivityID[ %bit ] );
	%ActivityID = GetWord($Src_ReturnTime_ActivityID[%bit],0);
	%Resut =  GetWord($Src_ReturnTime_ActivityID[%bit],1);
	if (%ActivityID <= 0 || %Resut < 1 || %Resut > 30)
	{
		SendOneScreenMessage(2,"����ݴ��󣬴�����" @ $Src_ReturnTime_ActivityID[%bit],%Player);
		//echo("����ݴ��󣬴�����" @  $Src_ReturnTime_ActivityID[%bit]);
		return;
	}
	//echo( "============= " @  %ActivityID  @ " ====  " @  %Resut @  "  ==============="  @ "$Src_ReturnTime_ActivityID[ %bit ]===" @ $Src_ReturnTime_ActivityID[ %bit ] );

	%NumbersA = GetAct(%Player,%ActivityID,0);
	%NumbersB = GetAct(%Player,%ActivityID,1);
	//echo( "��¼ǰA ===" @ GetBitNum( %NumbersA ) @ "   === " @ %NumbersA );// �𿪿����ĺ���
	//echo( "��¼ǰB ===" @ GetBitNum( %NumbersB ) @ "   === " @ %NumbersB );// �𿪿����ĺ���

	if (%Resut <= 15)
	{
		%NumbersA = SetBit(%NumbersA,%Resut -1);
		%NumbersB = %NumbersB;
	}
	else
	{
		%NumbersA = %NumbersA;
		%NumbersB = SetBit(%NumbersB,%Resut -16);
	}
	//echo( "��¼��A ===" @ GetBitNum( %NumbersA ) @ "   === " @ %NumbersA );// �𿪿����ĺ���
	//echo( "��¼��B ===" @ GetBitNum( %NumbersB ) @ "   === " @ %NumbersB );// �𿪿����ĺ���

	SetAct(%Player,%ActivityID,%NumbersA,%NumbersB);
}
function DelSrc(%Player,%bit)//%bit ��Ӧ�ı��
{
	%ActivityID = GetWord($Src_ReturnTime_ActivityID[%bit],0);
	%Resut =  GetWord($Src_ReturnTime_ActivityID[%bit],1);
	if (%ActivityID <= 0 || %Resut < 1 || %Resut > 30)
	{
		SendOneScreenMessage(2,"����ݴ��󣬴�����" @ $Src_ReturnTime_ActivityID[%bit],%Player);
		//echo("����ݴ��󣬴�����" @  $Src_ReturnTime_ActivityID[%bit]);
		return;
	}
	//echo( "============= " @  %ActivityID  @ " ====  " @  %Resut @  "  ===============" );

	%NumbersA = GetAct(%Player,%ActivityID,0);
	%NumbersB = GetAct(%Player,%ActivityID,1);
	//echo( "��¼ǰA ===" @ GetBitNum( %NumbersA ) @ "   === " @ %NumbersA );// �𿪿����ĺ���
	//echo( "��¼ǰB ===" @ GetBitNum( %NumbersB ) @ "   === " @ %NumbersB );// �𿪿����ĺ���

	if (%Resut <= 15)
	{
		%NumbersA = ClearBit(%NumbersA,%Resut -1);
		%NumbersB = %NumbersB;
	}
	else
	{
		%NumbersA = %NumbersA;
		%NumbersB = ClearBit(%NumbersB,%Resut -16);
	}
	//echo( "��¼��A ===" @ GetBitNum( %NumbersA ) @ "   === " @ %NumbersA );// �𿪿����ĺ���
	//echo( "��¼��B ===" @ GetBitNum( %NumbersB ) @ "   === " @ %NumbersB );// �𿪿����ĺ���

	SetAct(%Player,%ActivityID,%NumbersA,%NumbersB);
}

//-----------------------------------����ACT�ļ�¼---------------------------
function SetAct(%Player,%ActivityID,%CA_1,%CA_2)
{
	if ($PlayGameReturnTime[%ActivityID] $= "")
	{
		//echo("����ݴ���δ�ҵ����Ϊ" @ %ActivityID @ "�Ļ���ݣ���ʱ�趨Ϊ��������");
		SendOneScreenMessage(2,"����ݴ���δ�ҵ����Ϊ" @ %ActivityID @ "�Ļ����",%Player);

		%Player.ChangeActivity(%ActivityID,%CA_1,%CA_2,0);
	}
	else
	{
		if ((%CA_1 >= 65535)||(%CA_2 >= 65535))
		{
			SendOneScreenMessage(2,"����ݴ��󣬱��" @ %ActivityID @ "�Ļ���������쳣",%Player);
			//echo("����ݴ��󣬱��" @ %ActivityID @ "�Ļ���������쳣����������ֵΪ"@%CA_1@"+"@%CA_2);
		}

		%Player.ChangeActivity(%ActivityID,%CA_1,%CA_2,$PlayGameReturnTime[%ActivityID]);
	}
}

//��������������������������¼��������������������������������������������������

