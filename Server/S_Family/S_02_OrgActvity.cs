//=============================================================================
// �ĵ�˵��:���ɻ
// ������: Irelia
// ����ʱ��:2018-03-19

// �޸���: 
// �޸�ʱ��: 
//=============================================================================


//�������������ɻ���桿�����������ɹ�����ȡ������������������
//�������������ɻ���桿�����������úͻ�ȡ��¼����������������

//�������������ɻ���桿�����������úͻ�ȡ��¼����������������
function SetOrgActivityRecord(%Player, %index)
{
	switch (%index)
	{
		case 0: SetSrc(%Player, 195);//"ÿ�չ���";
		case 1: SetSrc(%Player, 196);//"���ɾ���";
		case 2: SetSrc(%Player, 59);//"�����ħ";
		case 3: SetSrc(%Player, 197);//"�ռ�����";
		case 4: //"�����칬";
			%Act0 = GetAct(%Player, 4102, 0);
			%Act1 = GetAct(%Player, 4102, 1);
			%Act0++;
			SetAct(%Player, 4102, %Act0, %Act1);
		case 5: //"�����ؾ�";
			%Act0 = GetAct(%Player, 4103, 0);
			%Act1 = GetAct(%Player, 4103, 1);
			%Act0++;
			SetAct(%Player, 4103, %Act0, %Act1);
		case 6: SetSrc(%Player, 3);//"ȺӢ���";
		case 7: //"���޾�";  �ڲɼ������ʱ���Ѿ��ӹ���
		case 8: //"���������";  ����д
		case 9: //"��ħ�ǹ���ս";
		case 10://"���ս";
	}
	HelpDirectByIndex(%Player.GetPlayerID(), 31);	//ͨѶ�ͻ���
}
function SetOrgActivitySenvenSky(%Player, %index)//����7����ļ�¼
{
	%Act0 = GetAct(%Player, 4104, 0);
	%Act1 = GetAct(%Player, 4104, 1);
	%Act0 = SetBit(%Act0, %index);
	SetAct(%Player, 4104, %Act0, %Act1);
	HelpDirectByIndex(%Player.GetPlayerID(), 31);	//ͨѶ�ͻ���
}
function GetOrgActivityRecordServer(%Player, %index)
{
	switch (%index)
	{
		case 0: return GetSrc(%Player, 195);//"ÿ�չ���";
		case 1: return GetSrc(%Player, 196);//"���ɾ���";
		case 2: return GetSrc(%Player, 59);//"�����ħ";
		case 3: return GetSrc(%Player, 197);//"�ռ�����";
		case 4: return GetAct(%Player, 4102, 0) * 1;//"�����칬";
		case 5: return GetAct(%Player, 4103, 0) * 1;//"�����ؾ�";
		case 6: return GetSrc(%Player, 3);//"ȺӢ���";
		case 7: return GetSrc(%Player, 191) + GetSrc(%Player, 192) + GetSrc(%Player, 193) + GetSrc(%Player, 194);//"���޾�";
		case 8: //"���������";
			%Act0 = GetAct(%Player, 4104, 0) * 1;
			if (%Act0 == 0)
				return 0;
			for (%i = 1; %i<= 9; %i++)
			{
				if (!CheckBit(%num, %bit))
				{
					%Record = %i - 1;
					break;
				}
			}
			return %Record;
		case 9: //"��ħ�ǹ���ս";
		case 10://"���ս";
	}
}
//�������������ɻ���桿�����������úͻ�ȡ��¼����������������



//�������������ɻ���桿�����������ɻ�������š�����������������
function GetOrgActivityWages(%Player,%index)
{
	%Recrod = GetOrgActivityRecordServer(%Player, %index);
	switch (%index)
	{
		case 0: //"ÿ�չ���";
			if (%Recrod != 0)
				return;
			SetOrgActivityRecord(%Player, %index);
			AllAddExp(%Player, 10000);
			AddFamily_HuoYue(%Player, 10000);//��ʱ����
			%Player.Addmoney(10000, 2, 19, %index);
		case 1: //"���ɾ���";
			if (%Recrod != 0)
				return;
			SetOrgActivityRecord(%Player, %index);
			AllAddExp(%Player, 10000);
			AddFamily_HuoYue(%Player, 30);
		case 2: //"�����ħ";
			SetOrgActivityRecord(%Player, %index);
			%Level = %Player.GetLevel();
			if (%Level <= 45) %Exp= 60000;
			else if (%Level <= 60) %Exp= 99200;
			else if (%Level <= 75) %Exp= 154400;
			else if (%Level <= 90) %Exp= 230400;
			else if (%Level <= 100)%Exp= 331200;
			AllAddExp(%Player, %Exp);
			AddFamily_HuoYue(%Player, 50);
		case 3: //"�ռ�����";
			SetOrgActivityRecord(%Player, %index);
			%Level = %Player.GetLevel();
			if (%Level <= 45) %Exp= 60000;
			else if (%Level <= 60) %Exp= 99200;
			else if (%Level <= 75) %Exp= 154400;
			else if (%Level <= 90) %Exp= 230400;
			else if (%Level <= 100)%Exp= 331200;
			AllAddExp(%Player, %Exp);
			AddFamily_HuoYue(%Player, 50);
		case 4: //"�����칬";
			SetOrgActivityRecord(%Player, %index);
		case 5: //"�����ؾ�";
			SetOrgActivityRecord(%Player, %index);
			AddFamily_HuoYue(%Player, 100);
		case 6: //"ȺӢ���";
			SetOrgActivityRecord(%Player, %index);
			AddFamily_HuoYue(%Player, 30);
		case 7: //"���޾�";
			SetOrgActivityRecord(%Player, %index);
		case 8: //"���������";
			SetOrgActivitySenvenSky(%Player, %index);
		case 9: //"��ħ�ǹ���ս";
		case 10://"���ս";
	}
	
}
//�������������ɻ���桿�����������ɻ�������š�����������������