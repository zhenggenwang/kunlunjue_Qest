//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//�ڿͻ��˵�����ֽ���Ĵ���
//==================================================================================
function FinshEveryWndCommand(%Type)
{
	%Player = getPlayer();
	switch (%Type)
	{
		case 1://װ�����

		case 2://��ʯ��Ƕ
		case 3://ժ����ʯ
		case 4://��ʯ�ϳ�
		case 5://��Ƭ�ϳ�
		case 6://��ʯ����
		case 7://��ʯ����
		case 8://װ������ (����ֻ�ǿͻ��˰�ť������һ�£�����˻���һ����ɵĴ�����

			if (%Player.IsAcceptedMission(10781))
			{
				%Type10781 = %Player.GetMissionFlag(10781,1350);
				%Num10781 = %Player.GetMissionFlag(10781,1250);
				if (%Type10781 < %Num10781)
				{
					ClientOnSptAction(29,%Type);//ͨѶ�����

					CloseHelpDirectByIndex(116,%Type);
				}
			}
			putout("------�����󴥷�------");
			closeHelpDirect1_4(9);
		case 9://װ������ (����ֻ�ǿͻ��˰�ť������һ�£�����˻���һ����ɵĴ�����

		case 10://װ������ (����ֻ�ǿͻ��˰�ť������һ�£�����˻���һ����ɵĴ�����

		case 11://װ��ǿ�� (����ֻ�ǿͻ��˰�ť������һ�£�����˻���һ����ɵĴ�����

			if (%Player.IsAcceptedMission(10761))
			{
				%Type10761 = %Player.GetMissionFlag(10761,1350);
				%Num10761 = %Player.GetMissionFlag(10761,1250);
				if (%Type10761 < %Num10761)
				{
					ClientOnSptAction(29,%Type);//ͨѶ�����

					Schedule(3500,0,"CloseHelpDirectByIndex",116,%Type);
				}
			}
			putout("------ǿ������------");
			closeHelpDirect1_4(8);
		case 12://ȫ����ת��
		case 13://װ������
			SetStrategyWndRecord($StrategySubBtnSrc[1,9]);//��ɹ��Լ�¼

		case 14://���뵽����
			SetStrategyWndRecord($StrategySubBtnSrc[0,0]);//��ɹ��Լ�¼
		case 15://��Ӻ���
			SetStrategyWndRecord($StrategySubBtnSrc[0,1]);//��ɹ��Լ�¼
		case 16://��������
			SetStrategyWndRecord($StrategySubBtnSrc[0,2]);//��ɹ��Լ�¼
		case 17://�������
			SetStrategyWndRecord($StrategySubBtnSrc[0,2]);//��ɹ��Լ�¼
		case 18://��̯--��̯
			SetStrategyWndRecord($StrategySubBtnSrc[0,4]);//��ɹ��Լ�¼
			//case 19://ǧ�ﴫ�� 

		case 20://д��
			SetStrategyWndRecord($StrategySubBtnSrc[0,6]);//��ɹ��Լ�¼
		case 21://�Զ�ս��
			SetStrategyWndRecord($StrategySubBtnSrc[1,0]);//��ɹ��Լ�¼
			//case 22://��������

			//case 23://����ѧϰ

		case 24://��ʯ�ϳ�
			SetStrategyWndRecord($StrategySubBtnSrc[1,10]);//��ɹ��Լ�¼
		case 25://����
			SetStrategyWndRecord($StrategySubBtnSrc[1,11]);//��ɹ��Լ�¼
			
	}
}
