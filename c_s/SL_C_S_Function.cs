//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//�ͻ��������˹��õĽű�����
//==================================================================================

function UPCS_CS(%Num)
{
	//if( (%Num == 0 )||(%Num == 99) ){Exec("./HuoDong/DT_00_Function.cs");}

	if ((%Num == 1)||(%Num == 99)){ Exec("./SL_C_S_FenJie_HeChen.cs"); }
	if ((%Num == 2)||(%Num == 99)){ Exec("./SL_C_S_Final_Variables.cs"); }
	if ((%Num == 3)||(%Num == 99)){ Exec("./SL_C_S_Mission_Need.cs"); }
	if ((%Num == 4)||(%Num == 99)){ Exec("./SL_C_S_Prescription.cs"); }

	if ((%Num == 6)||(%Num == 99)){ Exec("./SL_C_S_GiftPacks.cs"); }
	if ((%Num == 7)||(%Num == 99)){ Exec("./SL_C_S_Mission_Manage.cs"); }
	if ((%Num == 8)||(%Num == 99)){ Exec("./SL_C_S_configuration.cs"); }
	if ((%Num == 9)||(%Num == 99)){ Exec("./SL_C_S_ActivityRecord.cs"); }
	if ((%Num == 10)||(%Num == 99)){ Exec("./SL_C_S_StrategyText.cs"); }
	if ((%Num == 11)||(%Num == 99)){ Exec("./SL_C_S_Mission_Begin_Front.cs"); }
	if ((%Num == 12)||(%Num == 99)){ Exec("./SL_C_S_Mission_End_Front.cs"); }
}

Schedule(1000,0,"UPCS_CS",99);

//�������������������������¹ⱦ���������ݡ�������������������������������������
//��������������������������װ��̨���������������������������������������������
//������������������������ȡ����������������������������������������������������
//��������������������������ȡҰ�������Ƿ�������������������������������������
//��������������������������ȡ�۱����Ƿ���������������������������������������
//��������������������������ȡ��ǰ���ת���ȼ�����������������������������������
//��������������������������ȡ�Ƿ��ڻʱ���ڡ���������������������������������
//�����������������������������ļ����������������������������������������������
//���������������������������������û�ɽ�۽��������ߡ�������������������������
//���������������������������õ�ͼ������Ӵ�������������������������������������
//��������������������������ȡ����Data���ơ�������������������������������������
//����������������������������й��ܡ�������������������������������������������
//��������������������������ȡ��2000����ĳ�졿��������������������������������
//��������������������������ȡVIP�ȼ�������������������������������������������
//������������������������ϴ�������ġ�������������������������������������������
//�������������������������ж������濪����������������������������������������
//����������������������������������ʱ����������������������������������������
//������������������������ָ����������Ч��������������������������������������
//��������������������������ȡ��������͡���������������������������������������
//��������������������������ȡ���ظ��������������������������������������������
//��������������������������ȡָ��λ��bitֵ������������������������������������
//�������������������������ɼ�����ǰ���жϽű�����������������������������������
//����������������������������������ƽű��������ã�����������������������������
//�������������������������ֿ���չ����жϽű�����������������������������������
//�������������������������ж϶����Ƿ�Ϊ��ҡ�����������������������������������
//��������������������������ȡ������������Ľ�����������������������������������
//��������������������������ȡ����ʱ��֮��ļ����������������������������������
//��������������������������ȡ�¼�������ڡ�������������������������������������
//����������������������������Ԫ��������ؽű�����������������������������������
//���������������������������޳ƺŹ��ܡ�����������������������������������������
//��������������������������ȡǧ���۲�ѯ����������������������������������������
//������������������������λ���㹦�ܡ�������������������������������������������
//�������������������������������޹����������ݡ���������������������������������
//��������������������������ȡ��ҳ���غ���������������������������������������
//����������������������������Ԫ��������ؽű�����������������������������������
//������������������������������ѹ��Ǵ�����������������������������������������
//��������������������������ְϵͳ���ж���ҵ�ǰ���ģ���ٵ���һƷ�ס�����������
//����������������������������������������������������������������������������
//��������������������������ȡ����ҵ�ǰ������ȡ�ľ�����������������������������
//����������������������������仯�����������ȼ��ű�����������������������������
//������������������������������ʾͨ�ýű���������������������������������������

//��������������������������ȡbitֵ��actֵ�ĺ�����������������������������������
//������������������������ǩ��----ȡֵ������������������������������������������
//��������������������������Ծ----��Ծ�ȼ��㡿����������������������������������
//���������������������������͵�ͼǰ���жϡ�������������������������������������
//������������������������������ǰ�ĸ���׼��������������������������������������
//��������������������������Ѱ����ť��������������������������������������������
//��������������������������ɫ����ս�������ű�����������������������������������
//��������������������������С�ȽϺ���������������������������������������������
//����������������������������ս��������ء�������������������������������������

//�������������������������ص�����ʵID������������������������������������������
//������������������������ȡԪ�����ġ�������������������������������������������
//��������������������������ȡ���װ��������������������������������������������







//�������������������������¹ⱦ���������ݡ�������������������������������������
function Get_YGBH_Dialog(%Npc,%Player,%DialogID,%Param)
{
	switch (%DialogID)
	{
		//----------------------��һ�๦��-----������������------------------------------------------
		case 1000000000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���������˹�</t>";
		case 1000000100:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��ȡ�¹ⱦ��</t>";
		case 1000000200:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��ʦ���̵�</t>";
		case 1000000300:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�򿪲����̵�</t>";
		case 1000000400:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�򿪲ֿ�</t>";
		case 1000000500:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>������</t>";

		case 1001000000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>������������</t>";

		case 1001010000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��ɫ�ȼ��޸�</t>";

		case 1001010100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�������ȼ��ϵ����</t>";
		case 1001010200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�������ȼ��ϵ�10��</t>";
		case 1001010300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�������ȼ��ϵ�5��</t>";
		case 1001010400:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�������ȼ��ϵ�1��</t>";
		case 1001010500:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�������ȼ��µ�1��</t>";
		case 1001010600:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�������ȼ��µ�5��</t>";
		case 1001010700:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�������ȼ��µ�10��</t>";
		case 1001010800:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�������ȼ��µ����</t>";

		case 1001020000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӹ��־���</t>";

		case 1001020100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��ɫ����</t>";
			//case 1001020200:%Text[ 3 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>���޾���</t>";

		case 1001030000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӹ��ֽ�Ǯ</t>";

		case 1001030100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>Ԫ��</t>";
		case 1001030200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���</t>";
		case 1001030300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ԫ��</t>";
		case 1001030400:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�ֿ�Ԫ��</t>";
		case 1001030500:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ծ����</t>";
		case 1001030600:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>ս������</t>";
		case 1001030700:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>MDZZ��</t>";

		case 1001040000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>һ�����ܺ�װ��</t>";
			//----------------------�ڶ��๦��-----���������ͼ------------------------------------------
		case 1002000000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���������ͼ</t>";

		case 1002010000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���͡����ء�[����]</t>";

		case 1002020000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���͡�������[����]</t>";

		case 1002030000:%Text[2] = $Get_Dialog_GeShi[31404] @ "<t>------�����ķָ���------</t>";

		case 1002040000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���͡�Ұ�⡻[��ͨ]</t>";

		case 1002040100:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡������롿</t>";
		case 1002040200:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���ɽѩ����</t>";
		case 1002040300:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���������</t>";
		case 1002040400:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡�������ԭ��</t>";
		case 1002040500:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡��㺣���֡�</t>";
		case 1002040600:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡����ط��桿</t>";
		case 1002041800:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���ħ�</t>";
		case 1002041900:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���ħ�ǡ�</t>";
		case 1002049900:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡����Ե�ͼ��</t>";

		case 1002050000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���͡��ع���[��ͨ]</t>";

		case 1002050100:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���������1�㡿	</t>";
		case 1002050200:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���������2�㡿	</t>";
		case 1002050300:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���������3�㡿	</t>";
		case 1002050400:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���¹֮Ұ��	</t>";
		case 1002050500:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡����ɿ�1�㡿	</t>";
		case 1002050600:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡����ɿ�2�㡿	</t>";
		case 1002050700:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���������1�㡿	</t>";
		case 1002050800:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���������2�㡿	</t>";
		case 1002050900:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���������3�㡿	</t>";
		case 1002051000:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���������4�㡿	</t>";
		case 1002051100:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���Թ�1�㡿	</t>";
		case 1002051200:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���Թ�2�㡿	</t>";
		case 1002051300:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���Թ�3�㡿	</t>";
		case 1002051400:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���Թ�4�㡿	</t>";

		case 1002060000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���͡�������[��ͨ]</t>";

		case 1002070000:%Text[2] = $Get_Dialog_GeShi[31404] @ "<t>------�ָ��ߵ���Ϯ------</t>";

		case 1002080000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���͡����[����]</t>";

		case 1002080100:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡�ʱ���Ѻۡ�</t>";
		case 1002080200:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���ħԨ��</t>";
		case 1002080300:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡��������ء�</t>";
		case 1002080400:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���ħ�þ���</t>";
		case 1002080500:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡�����������</t>";
		case 1002080600:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡�Ѫħ��ӡ��</t>";
		case 1002080700:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡��ƽ𱦲ء�</t>";
		case 1002080800:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡����޾���</t>";
		case 1002080900:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡������Թ���</t>";
		case 1002081000:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡������ؾ���</t>";

		case 1002090000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���͡����须[����]</t>";

		case 1002100000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���͡�ս����[����]</t>";

		case 1002100100:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡��þ����ԡ�</t>";
		case 1002100200:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡������������ͼ���</t>";
		case 1002100300:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡������������м���</t>";
		case 1002100400:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡������������߼���</t>";
		case 1002100500:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���ɽ��𢡿</t>";
		case 1002100600:%Text[3] = $Icon[10] @ $Get_Dialog_GeShi[31495] @ "<t>���͡���������</t>";

		case 1002110000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���͡�������[����]</t>";
			//----------------------�����๦��-----��Ӹ���״̬------------------------------------------
		case 1003000000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӹ���״̬</t>";

		case 1003010000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>ս��BUFF��</t>";

		case 1003010100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�޵�״̬</t>";
		case 1003010200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ѫ����</t>";

		case 1003020000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>����BUFF��</t>";

		case 1003030000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�������״̬</t>";

		case 1003030100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���������״̬</t>";
		case 1003030200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�����ȫʱ��</t>";
		case 1003030300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�����������</t>";
		case 1003030400:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>һ�������������</t>";

		case 1003040000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӳ��Լ���</t>";

		case 1003040100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>������֮ŭ</t>";

			//----------------------�����๦��-----��Ŵ�������------------------------------------------
		case 1004000000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ŵ�������</t>";

		case 1004010000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>����ˢ�¹���</t>";
		case 1004020000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>����ˢ�µ���</t>";
		case 1004030000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>����ˢ�²ɼ�</t>";
		case 1004040000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�����������</t>";
		case 1004050000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�����������</t>";
		case 1004060000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӽ���BUFF</t>";
			//----------------------�����๦��-----��������------------------------------------------
		case 1005000000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��������</t>";

		case 1005010000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>ѧϰһ������</t>";
		case 1005020000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>ѧϰ��������</t>";
		case 1005030000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>����������</t>";
			//case 1005040000:%Text[ 1 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>���ռ���ѧϰ</t>";
			//case 1005050000:%Text[ 1 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>�÷켼��ѧϰ</t>";
			//case 1005060000:%Text[ 1 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>���켼��ѧϰ</t>";
			//case 1005070000:%Text[ 1 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>��ҩ����ѧϰ</t>";
			//case 1005080000:%Text[ 1 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>���㼼��ѧϰ</t>";
			//case 1005090000:%Text[ 1 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>��ľ����ѧϰ</t>";
			//case 1005100000:%Text[ 1 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>��⿼���ѧϰ</t>";
			//case 1005010000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>��ȡ���</t>";
			//case 1005020000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>��ȡ�����</t>";
			//case 1005030000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>��ȡ������</t>";
			//case 1005040000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>ˢ�¿���(RMB)</t>";
			//case 1005050000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>ˢ��ͭ������1����</t>";
			//case 1005060000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>ˢ����������2����</t>";
			//case 1005070000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>ˢ����������3����</t>";
			//case 1005080000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>ˢ�½������4����</t>";
			//case 1005090000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>ˢ�º���������5����</t>";
			//case 1005100000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>ˢ������������6����</t>";
			//case 1005110000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>ˢ��ħ�������7����</t>";
			//case 1005120000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>ˢ���Ͻ������8����</t>";
			//case 1005130000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>ˢ��ҫ�������9����</t>";
			//case 1005140000:%Text[ 2 ] = $Icon[ 5 ] @ $Get_Dialog_GeShi[ 31495 ] @ "<t>ˢ���߲�����������10����</t>";
			//----------------------�����๦��-----���ɹ���------------------------------------------
		case 1006000000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���ɹ������</t>";

		case 1006010000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ��ɵȼ�</t>";

		case 1006020000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ����������������ݣ�</t>";
		case 1006020100:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ���������1000��</t>";
		case 1006020200:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ���������5000��</t>";
		case 1006020300:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ���������10000��</t>";

		case 1006030000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ��ɻ�Ծ���������ݣ�</t>";
		case 1006030100:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ��ɻ�Ծ��100��</t>";
		case 1006030200:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ��ɻ�Ծ��1000��</t>";
		case 1006030300:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ��ɻ�Ծ��10000��</t>";

		case 1006040000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ����ʽ𣨰������ݣ�</t>";
		case 1006040100:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ����ʽ�100��</t>";
		case 1006040200:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ����ʽ�1000��</t>";
		case 1006040300:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ����ʽ�10000��</t>";

		case 1006050000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ��ɻ��ң�������ݣ�</t>";
		case 1006050100:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ��ɻ��ң�100��</t>";
		case 1006050200:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ��ɻ��ң�1000��</t>";
		case 1006050300:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ��ɻ��ң�10000��</t>";

		case 1006060000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ��ɹ��ף�������ݣ�</t>";
		case 1006060100:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ��ɹ��ף�100��</t>";
		case 1006060200:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ��ɹ��ף�1000��</t>";
		case 1006060300:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ��ɹ��ף�10000��</t>";
			//----------------------�ڶ�ʮ�๦��-----���ٲ��Թ���------------------------------------------
		case 1020000000:%Text[1] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���ٲ��Թ���</t>";

		case 1020010000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���������ߡ����</t>";
		case 1020020000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>����Ŀ������</t>";
		case 1020030000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�ٻ�ľ׮</t>";
		case 1020040000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���AI����</t>";
		case 1020050000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>ʮ��ľ����</t>";
		case 1020060000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>����ʹ�õ�һ�����</t>";
		case 1020070000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>ˢ��ModNpc</t>";
		case 1020080000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�ƶ�ֵ�޸�</t>";
		case 1020090000:%Text[2] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���������ߡ�չʾ</t>";

		case 1020040100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>ǿ������LV1</t>";
		case 1020040200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>ǿ������LV2</t>";
		case 1020040300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>ǿ������LV3</t>";
		case 1020040400:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>����</t>";
		case 1020040500:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ӱ��</t>";
		case 1020040600:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>ħ����</t>";
		case 1020040700:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��˫</t>";
		case 1020040800:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>����LV1</t>";
		case 1020040900:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>����LV2</t>";
		case 1020041000:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>����LV3</t>";
		case 1020041100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��������LV1</t>";
		case 1020041200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��������LV2</t>";
		case 1020041300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��������LV3</t>";
		case 1020041400:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>ս��֮��</t>";
		case 1020041500:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��������</t>";
		case 1020041600:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�����⻷LV1</t>";
		case 1020041700:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�����⻷LV2</t>";
		case 1020041800:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�����⻷LV3</t>";
		case 1020041900:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��������LV1</t>";
		case 1020042000:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��������LV2</t>";
		case 1020042100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��������LV3</t>";
		case 1020042200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ѫ��LV1</t>";
		case 1020042300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ѫ��LV2</t>";
		case 1020042400:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��Ѫ��LV3</t>";
		case 1020042500:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�����ӰLV1</t>";
		case 1020042600:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�����ӰLV2</t>";
		case 1020042700:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�����ӰLV3</t>";
		case 1020042800:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>����֮��</t>";
		case 1020042900:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>������</t>";
		case 1020043000:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���</t>";
		case 1020043100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>���ܻ�</t>";
		case 1020043200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�ռ�ת��</t>";
		case 1020043300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��־ŭ��</t>";
		case 1020043400:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��������LV1</t>";
		case 1020043500:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��������LV2</t>";
		case 1020043600:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��������LV3</t>";
		case 1020043700:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>ħ������LV1</t>";
		case 1020043800:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>ħ������LV2</t>";
		case 1020043900:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>ħ������LV3</t>";
		case 1020044000:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�㶾��LV1</t>";
		case 1020044100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�㶾��LV2</t>";
		case 1020044200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�㶾��LV3</t>";
		case 1020044300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>����LV1</t>";
		case 1020044400:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>����LV2</t>";
		case 1020044500:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>����LV3</t>";
		case 1020044600:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>����߱��</t>";
		case 1020044700:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>Ⱥħ����</t>";
		case 1020044800:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>������ת</t>";
		case 1020044900:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��ϵ������ʦLV3</t>";
		case 1020045000:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��ϵ������ʦLV3</t>";
		case 1020045100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��ϵ������ʦLV3</t>";
		case 1020045200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>ľϵ������ʦLV3</t>";
		case 1020045300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>��ϵ������ʦLV3</t>";

		case 1020080100:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>�ƶ�ֵ����</t>";
		case 1020080200:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>����1���ƶ�ֵ</t>";
		case 1020080300:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>����10���ƶ�ֵ</t>";
		case 1020080400:%Text[3] = $Icon[5] @ $Get_Dialog_GeShi[31495] @ "<t>����100���ƶ�ֵ</t>";
	}
	for (%i = 1; %i <= 5; %i++)
	{
		if (%Text[%i] !$= "")
			return %Text[%i];
	}
	return "";
}
//�������������������������¹ⱦ���������ݡ�������������������������������������

//��������������������������װ��̨���������������������������������������������
function PutOut(%string)
{
	if (GetBuildString() $= "Debug")
		echo(%string);
}
//��������������������������װ��̨���������������������������������������������
//������������������������ȡ����������������������������������������������������
//%numa Ϊ������ %numbΪ����
function Take_remainder(%numa,%numb)
{
	%Result= mfloor(%numa / %numb);
	%Result = %numa - %Result * %numb;
	return %Result;
}
//������������������������ȡ����������������������������������������������������
//��������������������������ȡҰ�������Ƿ�������������������������������������
function GetDispatchLevel(%Player,%MapID)
{
	//��ȡ��ҵȼ�
	%PlayerLeve = %Player.GetLevel();

	if ((%MapID == 1101) || ((%MapID >= 1200) && (%MapID <= 1209)))
	{
		if (%PlayerLeve <= 37)
			return 1;
	}
	else if ((%MapID == 1102) || ((%MapID >= 1210) && (%MapID <= 1219)))
	{
		if (%PlayerLeve <= 50)
			return 1;
	}
	else if ((%MapID == 1103) || ((%MapID >= 1220) && (%MapID <= 1229)))
	{
		if (%PlayerLeve <= 55)
			return 1;
	}

	return 0;
}

function GetDispatchGoToNextMap(%Player,%MapID)
{
	//��ȡ��ҵȼ�
	%PlayerLeve = %Player.GetLevel();

	if ((%MapID == 1101) && (%PlayerLeve <= 37)) return 1;
	else if ((%MapID == 1102) && (%PlayerLeve <= 50)) return 1;
	else if ((%MapID == 1103) && (%PlayerLeve <= 55)) return 1;

	return 0;
}
//��������������������������ȡҰ�������Ƿ�������������������������������������


//��������������������������ȡ�۱����Ƿ���������������������������������������
function JuBaoPeng_bActive(%Player)
{
	%PLeve = GetMetempsychosisLeve(%Player);

	//���á� �۱��� ����ť
	if ($JuBaoPeng_bActive == 0)
	{
		CornucopiaWndMiniBtn.setvisible(0);
	}
	else
		CornucopiaWndMiniBtn.setvisible((%PLeve >= 60) ? 1 : 0);

	CornucopiaHaveFreeNumShow();
}
//��������������������������ȡ�۱����Ƿ���������������������������������������


//��������������������������ȡ��ǰ���ת���ȼ�����������������������������������
function GetMetempsychosisLeve(%Player)
{
	//��ҵȼ�
	%Level = %Player.GetLevel();

	//��ǰת���ȼ�
	%ZsLeve = %Player.GetMetempsychosis();
	if (%ZsLeve == 0)
		return %Level;

	return %ZsLeve * 80 + (%ZsLeve - 1) * 10 + %Level;
}

//��������������������������ȡ��ǰ���ת���ȼ�����������������������������������


//��������������������������ȡҰ�������Ƿ��ˢ�¡�������������������������������

//����ˢ��ʱ��
$HuoDongDaQuan_ShuaXin[1] = 3 * 60; 	$HuoDongDaQuan_OhasesID[1] = 1300; $HuoDongDaQuan_Map[1] = 810010200;
$HuoDongDaQuan_ShuaXin[2] = 3 * 60;  $HuoDongDaQuan_OhasesID[2] = 1400; $HuoDongDaQuan_Map[2] = 810020200;
$HuoDongDaQuan_ShuaXin[3] = 6 * 60;  $HuoDongDaQuan_OhasesID[3] = 1500; $HuoDongDaQuan_Map[3] = 811010100;
$HuoDongDaQuan_ShuaXin[4] = 6 * 60;  $HuoDongDaQuan_OhasesID[4] = 1600; $HuoDongDaQuan_Map[4] = 811020100;
$HuoDongDaQuan_ShuaXin[5] = 12* 60;  $HuoDongDaQuan_OhasesID[5] = 1700; $HuoDongDaQuan_Map[5] = 811030100;
$HuoDongDaQuan_ShuaXin[6] = 12* 60;  $HuoDongDaQuan_OhasesID[6] = 1800; $HuoDongDaQuan_Map[6] = 811040100;
$HuoDongDaQuan_ShuaXin[7] = 24* 60;  $HuoDongDaQuan_OhasesID[7] = 1900; $HuoDongDaQuan_Map[7] = 811050100;
$HuoDongDaQuan_ShuaXin[8] = 12* 60;  $HuoDongDaQuan_OhasesID[8] = 2000; $HuoDongDaQuan_Map[8] = 811280400;
$HuoDongDaQuan_ShuaXin[9] = 12* 60;  $HuoDongDaQuan_OhasesID[9] = 2100; $HuoDongDaQuan_Map[9] = 811290400;
$HuoDongDaQuan_ShuaXin[10] = 24* 60;  $HuoDongDaQuan_OhasesID[10] = 2200; $HuoDongDaQuan_Map[10] = 811320400;
$HuoDongDaQuan_ShuaXin[11] = 8 * 60;  $HuoDongDaQuan_OhasesID[11] = 2500; $HuoDongDaQuan_Map[11] = 811320200;


$HuoDongDaQuan_Xyz[1] = "59.5871 -221.08 100.245  ";
$HuoDongDaQuan_Xyz[2] = "79.2353 -233.083 99.9999 ";
$HuoDongDaQuan_Xyz[3] = "-72.4593 -37.9539 108.142";
$HuoDongDaQuan_Xyz[4] = "-51.2517 -116.931 106.807";
$HuoDongDaQuan_Xyz[5] = "-84.2028 117.508 103.589 ";
$HuoDongDaQuan_Xyz[6] = "-64.072 -38.9146 101.063 ";
$HuoDongDaQuan_Xyz[7] = "40.938 -84.2256 99.7257  ";
$HuoDongDaQuan_Xyz[8] = "-45.941 -140.796 100		 ";
$HuoDongDaQuan_Xyz[9] = "-171.936 127.21 100			 ";
$HuoDongDaQuan_Xyz[10] = "178.717 164.447 104			 ";
$HuoDongDaQuan_Xyz[11] = "2.55736 46.4992,108			 ";

function HuoDongDaQuan_BOSS_TiemA(%i)
{
	//��ȡ��ǰʱ��
	%Time = GetLocalTime();
	%DQ_DD = GetWord(%Time,2);	//��
	%DQ_HH = GetWord(%Time,3);	//ʱ
	%DQ_MM = GetWord(%Time,4);	//��

	%Time = GetWord(%Time,3) * 60 + GetWord(%Time,4);

	if ($HuoDongDaQuan_BOSS_KaiQ[%i] == 1)
		return -1;

	//��ȡ��¼ʱ��
	%DD = GetWord($HuoDongDaQuan_BOSS_Tiem[%i],0,"/");	//��
	%HH = GetWord($HuoDongDaQuan_BOSS_Tiem[%i],1,"/");	//ʱ
	%MM = GetWord($HuoDongDaQuan_BOSS_Tiem[%i],2,"/");	//��

	//��ȡ�´�ˢ��ʱ��
	%BossTiem = (%HH * 60 + %MM) + $HuoDongDaQuan_ShuaXin[%i];

	//��ȡʣ�����
	%BossTiemA = %BossTiem - (%DQ_HH * 60 + %DQ_MM);

	//�ж�ˢ��ʱ���Ƿ���� && �жϵ�ǰʱ���Ƿ��Ѿ�����
	if ((%BossTiem > (24 * 60)) && (%DQ_DD != %DD))
	{
		//��ȡ����ˢ��ʱ��
		%BossTiemA = %BossTiem - 24 * 60;

		//�ж��Ƿ񳬹�ʱ��
		if ((%DQ_HH * 60 + %DQ_MM) > %BossTiemA)
			return -2;
	}

	//�ж��Ƿ񳬹�ʱ��
	else if (%BossTiemA <= 0)
		return -3;

	return %BossTiemA;
}
//��������������������������ȡҰ�������Ƿ��ˢ�¡�������������������������������

//��������������������������ȡ�Ƿ��ڻʱ���ڡ���������������������������������
function GetStartTime(%Name)
{
	%Time = GetLocalTime();
	%YY = GetWord(%Time,0); //��
	%MM = GetWord(%Time,1); //��
	%DD = GetWord(%Time,2); //��
	%H = GetWord(%Time,3); //ʱ
	%M = GetWord(%Time,4); //��

	//��ȡ��Ƿ���
	eval("%bActive = $" @ %Name @ "_bActive;");

	if (%bActive == 0)
		return 1;

	/* ����ʱ�� */	eval("%StartTime = $" @ %Name @ "_StartTime;");
	/* ����ʱ�� */	eval("%EndTime = $" @ %Name @ "_EndTime;");

	//�Ƿ��ڸ����
	%StartYY = GetWord(%StartTime,0,".");	//�������
	%EndTimeYY = GetWord(%EndTime,0,".");	//�������

	if (!((%StartYY >= %YY) && (%YY <= %EndTimeYY)))
		return 2;

	%NowDD = translateNumToString((%YY * 365 * 24 * 60) + ((%MM * 31 + %DD) * 24 + %H) * 60 + %M);

	%StartH = GetWord(GetWord(%StartTime,3,"."),0,":");
	%EndH = GetWord(GetWord(%EndTime,3,"."),0,":");

	%StartM = GetWord(GetWord(%StartTime,3,"."),1,":");
	%EndM = GetWord(GetWord(%EndTime,3,"."),1,":");

	//��ȡ����ʱ��
	%StartDD = translateNumToString((%StartYY * 365 * 24 * 60) + ((GetWord(%StartTime,1,".") * 31 + GetWord(%StartTime,2,".")) * 24 + %StartH) * 60 + %StartM);		//��������
	%EndTimeDD = translateNumToString((%EndTimeYY * 365 * 24 * 60) + ((GetWord(%EndTime,1,".") * 31 + GetWord(%EndTime,2,".")) * 24 + %EndH) * 60 + %EndM);					//��������

	if ((%NowDD >= %StartDD) && (%NowDD <= %EndTimeDD))
		return 0;

	return 3;
}

function GetStartTime(%Name)
{
	%Time = GetLocalTime();
	%YY = GetWord(%Time,0); //��
	%MM = GetWord(%Time,1); //��
	%DD = GetWord(%Time,2); //��
	%H = GetWord(%Time,3); //ʱ
	%M = GetWord(%Time,4); //��

	//��ȡ��Ƿ���
	eval("%bActive = $" @ %Name @ "_bActive;");

	if (%bActive == 0)
		return 1;

	/* ����ʱ�� */	eval("%StartTime = $" @ %Name @ "_StartTime;");
	/* ����ʱ�� */	eval("%EndTime = $" @ %Name @ "_EndTime;");

	//�Ƿ��ڸ����
	%StartYY = GetWord(%StartTime,0,".");	//�������
	%EndTimeYY = GetWord(%EndTime,0,".");	//�������

	if (!((%StartYY >= %YY) && (%YY <= %EndTimeYY)))
		return 2;

	%NowDD = ((%MM * 31 + %DD) * 24 + %H) * 60 + %M;

	%StartH = GetWord(GetWord(%StartTime,3,"."),0,":");
	%EndH = GetWord(GetWord(%EndTime,3,"."),0,":");

	%StartM = GetWord(GetWord(%StartTime,3,"."),1,":");
	%EndM = GetWord(GetWord(%EndTime,3,"."),1,":");

	//��ȡ����ʱ��
	%StartDD = ((GetWord(%StartTime,1,".") * 31 + GetWord(%StartTime,2,".")) * 24 + %StartH) * 60 + %StartM;		//��������
	%EndTimeDD = ((GetWord(%EndTime,1,".") * 31 + GetWord(%EndTime,2,".")) * 24 + %EndH) * 60 + %EndM;					//��������

	if ((%NowDD >= %StartDD) && (%NowDD <= %EndTimeDD))
		return 0;

	return 3;
}
//��������������������������ȡ�Ƿ��ڻʱ���ڡ���������������������������������

//�����������������������������ļ������������������������������������������
function FuHuoNeedMoney_Expend(%Player,%optype) //0 Ԫ�� 1 ���
{
	//��ȡ��ҵȼ�
	%Level = %Player.GetLevel();
	%ZsLevel = %Player.GetMetempsychosis();
	%Activity = 2209;
	%ActivityA = GetWord(%Player.GetActivity(%Activity),0) * 1;
	%ActivityB = GetWord(%Player.GetActivity(%Activity),1) * 1;
	switch (%optype)
	{
		case 0:
			//echo( "%ActivityB==" @ %ActivityB );
			%Money = 100 * mceil(%ActivityB /30);
			//echo( "%MoneyB==" @ %Money );
			%Money = (%Money < 100) ? 100 : %Money;
			//echo( "%MoneyC==" @ %Money );
			%Money = (%Money > 300) ? 300 : %Money;
			//echo( "%MoneyD==" @ %Money );
		case 1:
			%MianFeiCiShu =GetMianFeiFuHuoNumber(%Player);
			//echo( "%MianFeiCiShu==" @ %MianFeiCiShu );
			//echo( "%ActivityA==" @ %ActivityA );
			if (%ActivityA < %MianFeiCiShu)
				%Money = 0;
			else
			{
				if ($PlayerEnabledMoney[%ActivityA - %MianFeiCiShu] !$= "")
					%Money = $PlayerEnabledMoney[%ActivityA - %MianFeiCiShu];
				else
					%Money = 1000000;
			}
			//echo( "%Money==" @ %Money );
	}
	return %Money;
}
function GetMianFeiFuHuoNumber(%Player)//��ȡ�����Ѹ������
{
	return 3;
}
//�����������������������������ļ������������������������������������������

//���������������������������������û�ɽ�۽��������ߡ�������������������������
function SetChallengeVipInc(%Player)
{
}
//���������������������������������û�ɽ�۽��������ߡ�������������������������

//�������������������������ж��Ƿ�ɹһ�����������������������������������������
function canEnabledCombatAssistant(%Player)
{
	if (GetWord(%Player.GetActivity(2145),0) > 0)
		return 0;

	//���Թһ�
	return 1;
}
//�������������������������ж��Ƿ�ɹһ�����������������������������������������

//��������������������������ȡ����Data���ơ�������������������������������������
function GetanyDataName(%DataID)
{
	if (GetSubStr(%DataID,0,1) == 1)%DataName = GetItemData(%DataID,1);						//����
	else if (GetSubStr(%DataID,0,1) == 4)%DataName = GetNpcData(%DataID,1);						//NPC
	else if (GetSubStr(%DataID,0,1) == 5)%DataName = GetCollectionObjectname(%DataID);	//�ɼ�
	else if (GetSubStr(%DataID,0,1) == 8)%DataName = GetTriggerData(%DataID,3);				//����
	return %DataName;
}

//����������������������������й��ܡ�������������������������������������������

//�ж��ܷ�洢λ��
function Transmission_canSavePos(%Player,%MapID)
{
	//if ( GetSubStr( %MapID, 1, 1 ) $= "3" )
	//	%Txt = "��ǰ��ͼ�޷�ʹ�øô��͡�";

	//else if ( %Player.GetTriggerId( ) $= "811190108" || %Player.GetTriggerId( ) $= "811190109" )
	//	%Txt = "�������޷�ʹ�øô��͡�";

	//else if ( ( %MapID == 1128 ) || ( %MapID == 1129 ) || ( %MapID == 1130 ) || ( %MapID == 1132 ) )
	//	%Txt = "��ǰ��ͼ�޷�ʹ�øô��͡�";

	%MapID = GetZoneID();
	switch (%MapID)
	{
		case 1001:return 1;
		case 1010:return 1;
		case 1101:return 1;
		case 1102:return 1;
		case 1103:return 1;
		case 1104:return 1;
		case 1105:return 1;
		case 1106:return 1;
		case 1107:return 1;
		default:
			%Txt = "��ǰ��ͼ�޷�ʹ�øù��ܡ�";
			SetScreenMessage(%Txt,$Color[5]);
			return 0;
	}
}

//��������(Player, ��ǰ��ͼID, Ŀ���ͼID)
function Transmission_canFlyPos(%Player,%MapID,%TomapID)
{
	if (%Player.GetInteractionState() > 0)
		%Txt = "����״̬�޷�ʹ�øù��ܡ�";

	else if ((%Player.GetMetempsychosis() == 0) && (%Player.GetLevel() < 15))
		%Txt = "15�������޷�ʹ�øù��ܡ�";

	else if (%Player.GetFamilarityTarget() != 0)
		%Txt = "����/ӵ��״̬���޷��ù��ܡ�";

	else if (%Player.IsDisabled())
		%Txt = "����״̬�޷�ʹ�øù��ܡ�";

	else if (%Player.IsInCombat())
		%Txt = "ս�����޷�ʹ�øù��ܡ�";

	else if (%Player.isInMultiMount())
		%Txt = "����������޷�ʹ�øù��ܡ�";


	if (%Txt !$= "")
	{
		if ($Now_Script == 1)
			SetScreenMessage(%Txt,$Color[2]);
		else
			SendOneScreenMessage(2,%Txt,%Player);

		return 0;
	}

	return 1;
}

//���ش������Ļ���
function getFlyTransmissionPosMoney()
{
	return 0;
}
//���ش������ĵ���
function getFlyTransmissionPosItem(%Player)
{
	//echo("���ش������ĵ���%Player===" @ %Player);
	//105109524   �ǽ�ʯ	105109525   �ǽ�ʯ(��Ʒ)
	if (%Player.GetItemCount(105109525) >= 1)
		return 105109525;
	else
		return 105109524;
}
//������Ѵ��ʹ���
function getFreeFlyTransmissionPosCount()
{
	return 0;
}

//���ؿɼ�¼����  ��ֵ���ܴ���20
function getFlyTransmissionPosCount(%Player)
{
	return VIP_getNowTequanLvMaxCnt(%Player, 1);
}

//�ǽ紫�ͣ����ŵ�ͼ�ɼ�¼��������
function getFlyTransmissionOneMapPosMax(%Player)
{
	return VIP_getNowTequanLvMaxCnt(%Player, 2);
}

//������������������������ȡ��2000����ĳ�����������������������������������
//����ת����20010101 =��367��
function Get2K_To_Day(%X_Day)
{
	//echo( "%X_Day====" @ %X_Day );
	%YY = GetSubStr(%X_Day,0,4) * 1;
	%MM = GetSubStr(%X_Day,4,2) * 1;
	%DD = GetSubStr(%X_Day,6,2) * 1;

	//��ȡ������������Ƿ�Ϊ����
	if (%YY == mfloor(%YY / 4) * 4)
		%Mon[02] = 29;
	else
		%Mon[02] = 28;

	%Mon[01] = 31;
	%Mon[03] = 31;
	%Mon[04] = 30;
	%Mon[05] = 31;
	%Mon[06] = 30;
	%Mon[07] = 31;
	%Mon[08] = 31;
	%Mon[09] = 30;
	%Mon[10] = 31;
	%Mon[11] = 30;
	%Mon[12] = 31;

	//��ʼ����//��
	for (%YY_Next = 2000; %YY_Next < %YY; %YY_Next++)
	{
		if (%YY_Next == mfloor(%YY_Next / 4) * 4)
			%All_Y_Day = %All_Y_Day + 366;
		else
			%All_Y_Day = %All_Y_Day + 365;
	}
	//��ʼ����//��
	for (%MM_Next = 1; %MM_Next < %MM; %MM_Next++)
		%All_Y_Day = %All_Y_Day + %Mon[%MM_Next];

	//��ʼ����//��
	%All_Y_Day = %All_Y_Day + %DD;
	//echo( "%All_Y_Day====" @ %All_Y_Day );
	return %All_Y_Day;
}
//����ת����367�� =��20010101
function GetDay_To_2K(%X_Day)
{
	%Mon[01] = 31;
	%Mon[03] = 31;
	%Mon[04] = 30;
	%Mon[05] = 31;
	%Mon[06] = 30;
	%Mon[07] = 31;
	%Mon[08] = 31;
	%Mon[09] = 30;
	%Mon[10] = 31;
	%Mon[11] = 30;
	%Mon[12] = 31;

	//��ʼ����//��
	for (%YY_Next = 2000; %YY_Next < 3000; %YY_Next++)
	{
		if (%YY_Next == mfloor(%YY_Next / 4) * 4)
		{
			%Mon[02] = 29;
			%YY_Day = 366;
		}
		else
		{
			%Mon[02] = 28;
			%YY_Day = 365;
		}

		if (%X_Day > %YY_Day)
			%X_Day = %X_Day - %YY_Day;
		else
			break;
	}
	//��ʼ����//��
	for (%MM_Next = 1; %MM_Next < 13; %MM_Next++)
	{
		if (%X_Day > %Mon[%MM_Next])
			%X_Day = %X_Day - %Mon[%MM_Next];
		else
			break;
	}

	return %YY_Next * 10000 + %MM_Next * 100 + %X_Day;
}

function CaculateWeekDay(%Year,%Month,%Day)//�������� ת��Ϊ���ڼ�
{
	if (%Month == 1 || %Month == 2)
	{
		%Month += 12;
		%Year--;
	}
	%iWeek = (%Day + 2 * %Month + 3 * (%Month + 1) / 5 + %Year + %Year / 4 - %Year / 100 + %Year / 400) % 7;
	switch (%iWeek)
	{
		case 0: %iWeek = 1; //echo( "����һ" );
		case 1: %iWeek = 2; //echo( "���ڶ�" );
		case 2: %iWeek = 3; //echo( "������" );
		case 3: %iWeek = 4; //echo( "������" );
		case 4: %iWeek = 5; //echo( "������" );
		case 5: %iWeek = 6; //echo( "������" );
		case 6: %iWeek = 0; //echo( "������" );
	}
	return %iWeek;
}
//������������������������ȡ��2000����ĳ���������������������������������������



//��������������������������ȡvip�ȼ�������������������������������������������
function GetYuanBaovip(%Player)
{
	%YunaBao = %Player.getTotalDrawGold();
	if (%YunaBao >= 100 * 100000)return 10;
	else if (%YunaBao >= 100 * 50000)return 9;
	else if (%YunaBao >= 100 * 30000)return 8;
	else if (%YunaBao >= 100 * 20000)return 7;
	else if (%YunaBao >= 100 * 10000)return 6;
	else if (%YunaBao >= 100 * 5000)return 5;
	else if (%YunaBao >= 100 * 2000)return 4;
	else if (%YunaBao >= 100 * 500)return 3;
	else if (%YunaBao >= 100 * 100)return 2;
	else if (%YunaBao >= 100 * 10)return 1;
	else return 0;
}
//��������������������������ȡvip�ȼ�������������������������������������������

//������������������������ϴ�������ġ�������������������������������������������
function sptGetPetHuanTongItemCount(%PetLevel,%PetDataID,%YuBao)
{
	//������������������100��
	%PetDataID[1] = GetSubStr(%PetDataID,7,2);
	if ((%PetDataID[1] >= 51) && (%PetDataID[1] <= 68))
		return 100;

	if ((%PetLevel >= 1) && (%PetLevel <= 39))return 10;
	else if ((%PetLevel >= 40) && (%PetLevel <= 49))return 20;
	else if ((%PetLevel >= 50) && (%PetLevel <= 59))return 30;
	else if ((%PetLevel >= 60) && (%PetLevel <= 69))return 50;
	else if ((%PetLevel >= 70) && (%PetLevel <= 79))return 100;
	else if ((%PetLevel >= 80) && (%PetLevel <= 89))return 100;
	else if ((%PetLevel >= 90) && (%PetLevel <= 99))return 300;
}
//������������������������ϴ�������ġ�������������������������������������������


//�������������������������ж������濪����������������������������������������
function UpdateMetempsychosis(%Player)
{
	%Player = GetPlayer();

	//��ҵȼ�
	if (GetMetempsychosisLeve(%Player) >= 65)
	{
		//������갴ť
		//ShowWuHunBtn(1);
		//�������������갴ť
		DTPlayerInfowGui_WuHunCtrl.setVisible(1);
	}
	else
	{
		//�ر���갴ť
		//ShowWuHunBtn(0);
		//�ر����������갴ť
		DTPlayerInfowGui_WuHunCtrl.setVisible(0);
	}

	//���¡���꡿��˸��ʾ
	ShowFreeSouHunNUMOutLine();

	ShowAvatarCoverPicture(%ZSNum);
}
//�������������������������ж������濪����������������������������������������

//����������������������������������ʱ����������������������������������������
function avatarJingJieUp(%Player,%slot,%JingJie,%ADDJingJie)
{
	//���ݻ��������������ı��
	switch (%JingJie)
	{
		case 0:%ItemID = 105103038;
		case 1:%ItemID = 105103039;
		case 2:%ItemID = 105103040;
		case 3:%ItemID = 105103041;
		case 4:%ItemID = 105103042;
	}

	//���ݻ����׼�������������
	if (%slot < 5){ %ItemNum = 1; }
	else if (%slot < 10){ %ItemNum = 3; }
	else if (%slot < 15){ %ItemNum = 6; }
	else if (%slot < 20){ %ItemNum = 10; }
	else if (%slot < 25){ %ItemNum = 30; }
	else if (%slot < 30){ %ItemNum = 60; }
	else %ItemNum = 60;

	if ($Now_Script == 1)
		return %ItemID @ " " @ %ItemNum;
	else
	{
		%Player.PutItem(%ItemID,-%ItemNum);
		return (%Player.AddItem(13,18)) ? 1 : 0;
	}
}
//����������������������������������ʱ����������������������������������������

//������������������������ָ����������Ч��������������������������������������
function AddEffect(%Type,%Obj,%EffectID)
{
	switch (%Type)
	{
		case 1:
			//���
			%Obj.AddPacket(%EffectID);	//���ͽ���������Ч

		case 2:
			//�����NPC
			%Obj.AddPacket(%EffectID);	//���ͽ���������Ч
	}
}
//������������������������ָ����������Ч��������������������������������������

//��������������������������ȡ��������͡���������������������������������������
function GetMissionKind(%Mid)
{
	return GetMissionData(%Mid,$Mission_Data_Type);
}
//��������������������������ȡ��������͡���������������������������������������

//��������������������������ȡ���ظ��������������������������������������������
function GetRandomNum(%Num,%Begin,%End)
{
	//�������Χ������
	%ArrayCount = %End-%Begin+1;
	if (%ArrayCount<=0)
		return;

	//��ʼ������
	%Index = 0;
	for (%i = %Begin; %i <= %End; %i++)
	{
		%Array[%Index] = %i;
		%Index++;
	}

	//��ѭ��
	for (%i = 0; %i < %ArrayCount; %i++)
	{
		if (%i >= %Num)//��������
			break;

		%Roll = GetRandom(%i,%ArrayCount-1);//��δ����λ�����

		if (%i == 0)
			%Temp = %Array[%Roll];
		else
			%Temp = %Temp @ " " @ %Array[%Roll];

		%Array[%Roll] = %Array[%i];//��λ	��֤������Ķ����ж���δ���������
	}

	return %Temp;
}

function GetRandomNum2(%Num,%Begin,%End,%NoIn)//��ȡ���ظ��������,�����ų���%Noin�������
{
	%ArrayCount = %End-%Begin+1;
	if (%ArrayCount <= 0)
		return;

	%PaiChuCount = GetWordCount(%NoIn);
	//��ʼ������
	%Index = 0;
	for (%i = %Begin; %i <= %End; %i++)
	{
		%Record = 0;
		for (%j = 0; %j < %PaiChuCount; %j++)
		{
			%PaiChuShuZi = GetWord(%NoIn,%j);
			if (%PaiChuShuZi == %i)
			{
				%Record = 1;
				break;
			}
		}
		if (%Record  == 0)
		{
			%Array[%Index] = %i;
			%Index++;
		}
	}
	if (%Array[0] $= "")
		return;
	if (%Index < %Num)
		%Num = %Index;
	//��ѭ��
	for (%i = 0; %i < %Index; %i++)
	{
		if (%i >= %Num)//��������
			break;

		%Roll = GetRandom(%i,%Index-1);//��δ����λ�����

		if (%i == 0)
			%Temp = %Array[%Roll];
		else
			%Temp = %Temp @ " " @ %Array[%Roll];

		%Array[%Roll] = %Array[%i];//��λ	��֤������Ķ����ж���δ���������
	}
	//echo( "%Temp===" @ %Temp );
	return %Temp;
}
//GetRandomNum2( 10, 1, 20, "1 5 3 8 9 4 6 10 12 20 13 15" );
//��������������������������ȡ���ظ��������������������������������������������



//�������������������������ɼ�����ǰ���жϽű�����������������������������������
function EventTriggerCondition(%Player,%nEventTriggerId,%Event)
{
	//echo("�ɼ�����¼�ID ==" @  %nEventTriggerId);
	//%nEventTriggerId = �ɼ�����¼�ID

	%PlayerID = %Player.GetPlayerID();
	%CopyMapID = %Player.GetLayerId();
	%Ys = %Player.GetActivity(2083);
	%YHs = GetWord(%Ys,0);//��ȡ����
	%YFs = GetWord(%Ys,1);//��ȡ����

	%Bs = %Player.GetActivity(2084);
	%BHs = GetWord(%Bs,0);//��ȡ����

	if ($Now_Script == 1)
		%BaoG = GetBagEmptyNum();//��ð�����
	else
		%BaoG = %Player.GetBagEmptyCount();//��ð�����

	switch$(%nEventTriggerId)
	{
		case "553000017":
			if ($Now_Script == 1)
			{
				if (%BaoG < 1)
					return 5035;
				if (%Player.Getlevel() < 30)
					return 4758;
			}
			return 0;
		case "551030101":
			if ($Now_Script == 1)
			{
				if (%BaoG < 1)
					return 5035;
				if (%Player.Getlevel() < 30)
					return 20161;
			}
			return 0;
		case "552000003":
			if (%Player.GetSchbuff(2013) > 0)
				return 30803;
			if (%Player.GetSchbuff(2012) <= 0)
				return 30804;
			if ($Now_Script == 2)
			{
				if (%Player.Getlevel() < $SL_LingJingWuDao_Level)
					return 20161;
			}
		case "552000002":
			%AAA = %Player.IsAcceptedMission(10221);
			if (%AAA != 1)
			{
				if ($Now_Script == 2)
				{
					if (%Player.Getlevel() < $SL_LingJingWuDao_Level)
						return 20161;
				}
				if (%Player.GetSchbuff(2013) > 0)
					return 30803;
				if (%Player.GetSchbuff(2014) >= 43200)
					return 30805;
			}
		case "551010101":
			if (%BaoG > 0)
				return 0;
			else
				return 5035;
		case "551011001":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011001;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011002":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011002;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				//echo("%Mark ====" @ %Mark);
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011003":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011003;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011004":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011004;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011005":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011005;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011006":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011006;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011007":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011007;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011008":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011008;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011009":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011009;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011010":
			if (%BaoG < 1)
				return 5035;
			if ($Now_Script == 1)
			{
				%Skill = 501011010;
				for (%i = 501011010; %i >= %Skill; %i--)
				{
					if (isLearnLivingSkill(%Player.GetPlayerID(),%i)  == 1)
					{
						%Mark = %i;
						break;
					}
				}
				if (%Mark  <= 0)
					return 3165;
			}
			return 0;
		case "551011501":
			%ItemID = %Player.GetEquip(13);
			if (%ItemID != 107020101)
				return 4834;
			if (%BaoG < 1)
				return 5035;
			return 0;
		case "551011502":
			%ItemID = %Player.GetEquip(13);
			if (%ItemID != 107020101)
				return 4834;
			if (%BaoG < 1)
				return 5035;
			return 0;
		case "551011511":
			%ItemID = %Player.GetEquip(13);
			if (%ItemID != 107020201)
				return 4835;
			if (%BaoG < 1)
				return 5035;
			return 0;
		case "551011512":
			%ItemID = %Player.GetEquip(13);
			if (%ItemID != 107020201)
				return 4835;
			if (%BaoG < 1)
				return 5035;
			return 0;
		case 552000006:
			//echo( "������===" @  %Player.GetBuffCount( 39903, 1 ) );
			if (%Player.GetBuffCount(39903,1) >= 1)
				return 35601;
			for (%i = 3; %i >= 1; %i--)
			{
				//echo( "ooo===" @  %Player.GetBuffCount( 39906, %i ) );
				if (%Player.GetBuffCount(39906,%i) >= 1)
					return 35601;
			}
			return 0;
		case "552000004":if (%player.IsAcceptedMission(20001) || %player.IsAcceptedMission(20001 + 8) ||%player.IsAcceptedMission(20001 + 16)) return 0; else return 5038;
		case "552000005":if (%player.IsAcceptedMission(20002) || %player.IsAcceptedMission(20002 + 8) ||%player.IsAcceptedMission(20002 + 16)) return 0; else return 5038;
		case "552000006":if (%player.IsAcceptedMission(20005) || %player.IsAcceptedMission(20005 + 8) ||%player.IsAcceptedMission(20005 + 16)) return 0; else return 5038;
		case "552000007":
			if (%player.IsAcceptedMission(20006) || %player.IsAcceptedMission(20006 + 8) ||%player.IsAcceptedMission(20006 + 16)) return 0; else return 5038;
			if (%Player.GetBuffCount(39903,1) >= 1)
				return 35601;
			if (%Player.GetBuffCount(39906,3) >= 1)
				return 35602;
			if (%Player.GetBuffCount(39906,2) >= 1)
				return 35602;
			if (%Player.GetBuffCount(39906,1) >= 1)
				return 35602;
			return 0;
		case "552000008":
			if (%player.IsAcceptedMission(20006) || %player.IsAcceptedMission(20006 + 8) ||%player.IsAcceptedMission(20006 + 16)) return 0; else return 5038;
			if (%Player.GetBuffCount(39903,1) >= 1)
				return 35601;
			if (%Player.GetBuffCount(39906,3) >= 1)
				return 35602;
			if (%Player.GetBuffCount(39906,2) >= 1)
				return 35602;
			return 0;
		case "552000009":
			if (%player.IsAcceptedMission(20006) || %player.IsAcceptedMission(20006 + 8) ||%player.IsAcceptedMission(20006 + 16)) return 0; else return 5038;
			if (%Player.GetBuffCount(39903,1) >= 1)
				return 35601;
			if (%Player.GetBuffCount(39906,3) >= 1)
				return 35602;
			return 0;
		case "552000015":
			if ($PlayerMissionRecord[%CopyMapID,%PlayerID] >= 5)
				return 35603;
			return 0;
		case "552000016":
			if ($PlayerMissionRecord[%CopyMapID,%PlayerID] >= 5)
				return 35603;
			return 0;
		case "553000002":
			if (%BaoG < 1)
				return 5035;
		case "553000003":
			if (%BaoG < 10)
				return 5035;
		case "553000004":
			if (%BaoG < 10)
				return 5035;
		case "553000005":
			if (%BaoG < 10)
				return 5035;
		case "553000006":
			if (%BaoG < 10)
				return 5035;
		case "553000007":
			if (%BaoG < 10)
				return 5035;
		case "553000008":
			if (%BaoG < 10)
				return 5035;
		case "553000009":
			if (%BaoG < 10)
				return 5035;
		case "553000010":
			if (%BaoG < 10)
				return 5035;
		case "553000011":
			if (%BaoG < 10)
				return 5035;
		case "553000012":
			if (%BaoG < 10)
				return 5035;
		case "553000057":if (GetSrc(%Player,191) == 1)return 30507; else return 0;
		case "553000058":if (GetSrc(%Player,192) == 1)return 30507; else return 0;
		case "553000059":if (GetSrc(%Player,193) == 1)return 30507; else return 0;
		case "553000060":if (GetSrc(%Player,194) == 1)return 30507; else return 0;
		case "553000062":if (%Player.IsSchbuff(2043))return 30508;else return 0;
	}
	return 0;
}
//�������������������������ɼ�����ǰ���жϽű�����������������������������������

//��������������������������ȡ������Ϣ����������������������������������
new ItemObject(ItemObj)
{
};
//��������������������������ȡ������Ϣ����������������������������������

//����������������������������������ƽű��������ã�����������������������������
function GetMissionName(%Mid)
{
	return GetMissionData(%Mid,$Mission_Data_Name);
}
//����������������������������������ƽű��������ã�����������������������������

//�������������������������ֿ���չ����жϽű�����������������������������������
//�ֿ���չ��ť�Ƿ�ɵ��
function Cs_Bank_CanBuySpace(%Player,%Num)
{
	if ((%Player.GetLevel() < 10) || (%Num == 120))
		return 0;//���ɵ��
	else
		return 1;//�ɵ��
}
//��չ��Ӧ������Ҫ���ĵ�Ԫ��
function Cs_Bank_NeedMoney(%Num)
{
	switch (%Num)
	{
		case 32:return 500;
		case 40:return 500;
		case 48:return 500;
		case 56:return 500;
		case 64:return 1000;
		case 72:return 1000;
		case 80:return 1500;
		case 88:return 1500;
		case 96:return 2000;
	}

	return 0;
}
//��չ��Ӧ������Ҫ���ĵĵ���
function Cs_Bank_NeedItemType(%Num)
{

	return 0;
}
//�������������������������ֿ���չ����жϽű�����������������������������������

//�������������������������ж϶����Ƿ�Ϊ��ҡ�����������������������������������
//����1000Ϊ����� 1500ΪŮ��� 0Ϊ�������
function IsPlayer(%Obj)
{
	if (!isobject(%Obj))
		return 0;

	%DataID = %Obj.GetDataID();

	//if ( %DataID == 1000 || %DataID == 1500 )
	//	return %DataID;
	//else
	//	return 0;
	if (%DataID < 30000)
		return %DataID;
	else
		return 0;
}
//�������������������������ж϶����Ƿ�Ϊ��ҡ�����������������������������������


//��������������������������ȡ������������Ľ�����������������������������������

function Mission_Special_23015_Award(%Player)
{
	//��ҵȼ�
	%Level = %Player.GetLevel();
	%Cz = 1212;

	//����ɴ���
	%AAA = GetWord(%Player.GetActivity(%Cz),0) * 1 + 1;
	//������̴���
	%BBB = GetWord(%Player.GetActivity(%Cz),1) * 1;
	%CCC = GetSubStr(%BBB,1,2) * 1;

	//����ֵ
	if (%Level <=  49){ %JXZ = 1100; }
	else if (%Level <=  59){ %JXZ = 2200; }
	else if (%Level <=  69){ %JXZ = 3450; }
	else if (%Level <=  79){ %JXZ = 4500; }
	else if (%Level <=  89){ %JXZ = 5800; }
	else if (%Level <=  99){ %JXZ = 6900; }
	else if (%Level <= 109){ %JXZ = 7700; }
	else if (%Level <= 119){ %JXZ = 8400; }
	else if (%Level <= 129){ %JXZ = 9600; }

	//����
	return %JXZ + %AAA * 100 + %CCC / 5 * 2500;
}
//��������������������������ȡ������������Ľ�����������������������������������


//��������������������������ȡ����ʱ��֮��ļ����������������������������������
function Get_Day_Day(%DayA,%DayB)
{
	%Mon[01] = 31;
	%Mon[03] = 31;
	%Mon[04] = 30;
	%Mon[05] = 31;
	%Mon[06] = 30;
	%Mon[07] = 31;
	%Mon[08] = 31;
	%Mon[09] = 30;
	%Mon[10] = 31;
	%Mon[11] = 30;
	%Mon[12] = 31;

	%Day_A_Y = GetSubStr(%DayA,0,4) * 1;
	%Day_A_M = GetSubStr(%DayA,4,2) * 1;
	%Day_A_D = GetSubStr(%DayA,6,2) * 1;

	%Day_B_Y = GetSubStr(%DayB,0,4) * 1;
	%Day_B_M = GetSubStr(%DayB,4,2) * 1;
	%Day_B_D = GetSubStr(%DayB,6,2) * 1;

	%Back_A_D = %Day_A_D;
	for (%a = 2011; %a <= %Day_A_Y; %a++)
	{
		//��ȡ�Ƿ�Ϊ����
		if ((%Day_A_Y == 2012)||(%Day_A_Y == 2016)||(%Day_A_Y == 2020)||(%Day_A_Y == 2024)||(%Day_A_Y == 2028)||(%Day_A_Y == 2032))
			%Mon[02] = 29;
		else
			%Mon[02] = 28;

		for (%i = 1; %i < %Day_A_M; %i++)
		{
			%Back_A_D = %Back_A_D + %Mon[%i];
		}
	}

	%Back_B_D = %Day_B_D;
	for (%a = 2011; %a <= %Day_B_Y; %a++)
	{
		//��ȡ�Ƿ�Ϊ����
		if ((%Day_B_Y == 2012)||(%Day_B_Y == 2016)||(%Day_B_Y == 2020)||(%Day_B_Y == 2024)||(%Day_B_Y == 2028)||(%Day_B_Y == 2032))
			%Mon[02] = 29;
		else
			%Mon[02] = 28;

		for (%i = 1; %i < %Day_B_M; %i++)
		{
			%Back_B_D = %Back_B_D + %Mon[%i];
		}
	}
	return %Back_B_D - %Back_A_D;
}
//��������������������������ȡ����ʱ��֮��ļ����������������������������������

//��������������������������ȡ�¼�������ڡ�������������������������������������
function GetNextDay(%X_Day,%NextDay)
{
	%YY = GetSubStr(%X_Day,0,4) * 1;
	%MM = GetSubStr(%X_Day,4,2) * 1;
	%DD = GetSubStr(%X_Day,6,2) * 1;

	//��ȡ������������Ƿ�Ϊ����
	if ((%YY == 2012)||(%YY == 2016)||(%YY == 2020)||(%YY == 2024)||(%YY == 2028)||(%YY == 2032))
		%Mon[02] = 29;
	else
		%Mon[02] = 28;

	%Mon[01] = 31;
	%Mon[03] = 31;
	%Mon[04] = 30;
	%Mon[05] = 31;
	%Mon[06] = 30;
	%Mon[07] = 31;
	%Mon[08] = 31;
	%Mon[09] = 30;
	%Mon[10] = 31;
	%Mon[11] = 30;
	%Mon[12] = 31;

	//�����һ�쳬���ı��������������������λ
	if ((%DD + %NextDay) > %Mon[%MM])
	{
		%DD_Next = %DD + %NextDay - %Mon[%MM];

		//���������λ����12������������λ
		if ((%MM + 1) > 12)
		{
			%YY_Next = %YY + 1;
			%MM_Next = %MM;
		}
		else
		{
			%YY_Next = %YY;
			%MM_Next = %MM + 1;
		}
	}
	else
	{
		%YY_Next = %YY;
		%MM_Next = %MM;
		%DD_Next = %DD + %NextDay;
	}

	//��������λ�Ĳ�����λ
	if (strlen(%MM_Next) == 1)%MM_Next = "0" @ %MM_Next;
	if (strlen(%DD_Next) == 1)%DD_Next = "0" @ %DD_Next;

	return %YY_Next @ " " @ %MM_Next @ " " @ %DD_Next;
}

//��������������������������ȡ�¼�������ڡ�������������������������������������

//����������������������������Ԫ��������ؽű�����������������������������������
//��ȡ��ǰ���׵ȼ���Ҫ���ĵĵ���
function GetPetStrengthenItem(%lv)
{
	switch (%lv)
	{
		case 0: return "116010101";//����Ԫ������ʯ;
		case 1: return "116010102";//����Ԫ������ʯ;
		case 2: return "116010103";//����Ԫ������ʯ;
		case 3: return "116010104";//����Ԫ������ʯ;
		case 4: return "116010105";//����Ԫ������ʯ;
		default:return "116010106";//����Ԫ������ʯ;
	}
}
//��ȡ��ǰ���׵ȼ���Ҫ���ĵ�Ǯ
function GetPetStrengthenMoney(%lv)
{
	return 30000 * (%lv + 1) - 10000;
}
//��ȡ��ǰ���׵ȼ����յĳɹ�����
function PetStrengthen(%lv)
{
	switch (%lv)
	{
		case 0:
			%X = GetRandom(1,10000);
			if (%X <= 2800)return 1;
			else if (%X <= 7600)return 2;
			else return 3;

		case 1:
			%X = GetRandom(1,10000);
			if (%X <= 3000)return 1;
			else if (%X <= 8200)return 2;
			else return 3;

		case 2:
			%X = GetRandom(1,10000);
			if (%X <= 1000)return 1;
			else if (%X <= 4000)return 2;
			else if (%X <= 8800)return 3;
			else return 4;

		case 3:
			%X = GetRandom(1,10000);
			if (%X <= 1000)return 1;
			else if (%X <= 3000)return 2;
			else if (%X <= 6000)return 3;
			else if (%X <= 9000)return 4;
			else return 5;

		case 4:
			%X = GetRandom(1,10000);
			if (%X <= 1000)return 1;
			else if (%X <= 2000)return 2;
			else if (%X <= 3000)return 3;
			else if (%X <= 6000)return 4;
			else if (%X <= 9050)return 5;
			else return 6;

		default:
			%X = GetRandom(1,10000);
			if (%X <= 1000)return 1;
			else if (%X <= 2000)return 2;
			else if (%X <= 3000)return 3;
			else if (%X <= 4000)return 4;
			else if (%X <= 6100)return 5;
			else if (%X <= 9150)return 6;
			else return 7;
	}
}
//��ȡ�������ױ���
function GetPetStrengthenRang(%lv)
{
	switch (%lv)
	{
		case 0: return "0";
		case 1: return "1-3";
		case 2: return "1-4";
		case 3: return "1-5";
		case 4: return "1-6";
		case 5: return "1-7";
		default:return "0";
	}
}
//��ȡ�ܺͽ��ױ���
function GetPetStrengthenAmountRang(%lv)
{
	switch (%lv)
	{
		case 0: return "1-3";
		case 1: return "2-6";
		case 2: return "3-10";
		case 3: return "4-15";
		case 4: return "5-21";
		case 5: return "6-28";
		default:return "0";
	}
}
//�жϴ˵ȼ��Ƿ�Ϊ��������
function isPerfectStrengthen(%lv,%Num)
{
	switch (%lv)
	{
		case 0: %P = 3;
		case 1: %P = 5;
		case 2: %P = 7;
		case 3: %P = 9;
		case 4: %P = 11;
		case 5: %P = 13;
		default:%P = 0;
	}

	if (%Num >= %P)
		return 1;
	else
		return 0;
}
//����������������������������Ԫ��������ؽű�����������������������������������

//���������������������������޳ƺŹ��ܡ�����������������������������������������
function GetPetDesignationName(%NameID)
{
	//������ʾ�ƺ�=Ǳ���ƺ�+���ġ�+Ԫ���ƺ�+���ʳƺ�
	if (%NameID < 111)
		return "";
	//Ǳ���ƺ�
	%Name_A = GetSubStr(%NameID,0,1);
	switch (%Name_A)
	{
		case 1:%Name_A_Txt = "";
		case 2:%Name_A_Txt = "������";
		case 3:%Name_A_Txt = "��˵��";
		case 4:%Name_A_Txt = "�����";
		default:%Name_A_Txt = "";
	}
	//Ԫ���ƺ�
	%Name_B = GetSubStr(%NameID,1,1);
	switch (%Name_B)
	{
		case 1:%Name_B_Txt = "";
		case 2:%Name_B_Txt = "�ػ�";
		case 3:%Name_B_Txt = "����";
		case 4:%Name_B_Txt = "����";
		default:%Name_B_Txt = "";
	}
	//���ʳƺ�
	%Name_C = GetSubStr(%NameID,2,1);
	switch (%Name_C)
	{
		case 1:
			if ((%Name_B > 1)||(%Name_A > 1))
				%Name_C_Txt = "����";
			else
				%Name_C_Txt = "";
		case 2:%Name_C_Txt = "����";
		case 3:%Name_C_Txt = "����";
		case 4:%Name_C_Txt = "����";
		default:%Name_C_Txt = "";
	}

	return %Name_A_Txt @ %Name_B_Txt @ %Name_C_Txt;
}
//���������������������������޳ƺŹ��ܡ�����������������������������������������

//��������������������������ȡǧ���۲�ѯ����������������������������������������
function GetQianLiYanNum()
{
	%Player = GetPlayer();

	%XS = %Player.GetActivity(2047);
	%XS_B = 1 - GetWord(%XS,0) * 1;				//��¼ǧ���۵�ֵ2

	if (%XS_B < 0)
		%XS_B = 0;

	if (%XS_B > 1)
		%XS_B = 1;

	return %XS_B;
}
//��������������������������ȡǧ���۲�ѯ����������������������������������������

//������������������������λ���㹦�ܡ�������������������������������������������

function CheckBit(%num,%bit)
{
	return (%num & (1 << %bit)) != 0;
}

//�жϱ�־λ�Ƿ����
function HasBit(%src,%bit)
{
	return %src & (1<< %bit);
}

//���ñ�־λ
function SetBit(%src,%bit)
{
	return %src | (1<< %bit);
}

//�����־λ
function ClearBit(%src,%bit)
{
	return %src & ~(1<< %bit);
}

//��һ��16λ����ת���� 16��2��������
function GetBitNum(%src)
{
	%value = (%src & 0x00000001) @ "," @ ((%src >> 1) & 0x00000001) @ "," @ ((%src >> 2) & 0x00000001) @ "," @ ((%src >> 3) & 0x00000001) @ "," @ ((%src >> 4) & 0x00000001) @ "," @ ((%src >> 5) & 0x00000001) @ "," @ ((%src >> 6) & 0x00000001) @ "," @ ((%src >> 7) & 0x00000001) @ "," @ ((%src >> 8) & 0x00000001) @ "," @ ((%src >> 9) & 0x00000001) @ "," @ ((%src >> 10) & 0x00000001) @ "," @ ((%src >> 11) & 0x00000001) @ "," @ ((%src >> 12) & 0x00000001) @ "," @ ((%src >> 13) & 0x00000001) @ "," @ ((%src >> 14) & 0x00000001) @ "," @ ((%src >> 15) & 0x00000001);
	//echo( %value );
}
//����16��1λ����0~1���ϲ�Ϊ1��32λ��ֵ
//SetBitNum(1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1);
function SetBitNum(%src1,%src2,%src3,%src4,%src5,%src6,%src7,%src8,%src9,%src10,%src11,%src12,%src13,%src14,%src15,%src16)
{
	return (%src1 & 0x00000001) | ((%src2 & 0x00000001) * (1 << 1)) | ((%src3 & 0x00000001) * (1 << 2)) | ((%src4 & 0x00000001) * (1 << 3)) | ((%src5 & 0x00000001) * (1 << 4)) | ((%src6 & 0x00000001) * (1 << 5)) | ((%src7 & 0x00000001) * (1 << 6)) | ((%src8 & 0x00000001) * (1 << 7)) | ((%src9 & 0x00000001) * (1 << 8)) | ((%src10 & 0x00000001) * (1 << 9)) | ((%src11 & 0x00000001) * (1 << 10)) | ((%src12 & 0x00000001) * (1 << 11)) | ((%src13 & 0x00000001) * (1 << 12)) | ((%src14 & 0x00000001) * (1 << 13)) | ((%src15 & 0x00000001) * (1 << 14)) | ((%src16 & 0x00000001) * (1 << 15));
}
//������������������������λ���㹦�ܡ�������������������������������������������


//�������������������������������޹����������ݡ���������������������������������
// ��������������Ҫ��Ԫ������
// %LevelLimit Ҫ���Ƶ����޵ĵȼ�
// %StarLevel  Ҫ���Ƶ����޵��Ǽ�
function GetStrengthenTrumpNeedMoney(%LevelLimit,%StarLevel)
{
	%DesStarLevel = %StarLevel + 1;
	switch (%DesStarLevel)
	{
		case 1:%Lv[1] = 5; %Lv[18] = 5; %Lv[60] = 35; %Lv[80] = 90;
		case 2:%Lv[1] = 5; %Lv[18] = 5; %Lv[60] = 35; %Lv[80] = 90;
		case 3:%Lv[1] = 5; %Lv[18] = 5; %Lv[60] = 35; %Lv[80] = 90;
		case 4:%Lv[1] = 10; %Lv[18] = 10; %Lv[60] = 45; %Lv[80] = 105;
		case 5:%Lv[1] = 10; %Lv[18] = 10; %Lv[60] = 45; %Lv[80] = 105;
		case 6:%Lv[1] = 10; %Lv[18] = 10; %Lv[60] = 45; %Lv[80] = 105;
		case 7:%Lv[1] = 15; %Lv[18] = 15; %Lv[60] = 55; %Lv[80] = 120;
		case 8:%Lv[1] = 15; %Lv[18] = 15; %Lv[60] = 55; %Lv[80] = 120;
		case 9:%Lv[1] = 15; %Lv[18] = 15; %Lv[60] = 55; %Lv[80] = 120;
		case 10:%Lv[1] = 20; %Lv[18] = 20; %Lv[60] = 65; %Lv[80] = 135;
		case 11:%Lv[1] = 20; %Lv[18] = 20; %Lv[60] = 65; %Lv[80] = 135;
		case 12:%Lv[1] = 20; %Lv[18] = 20; %Lv[60] = 65; %Lv[80] = 135;
		case 13:%Lv[1] = 25; %Lv[18] = 25; %Lv[60] = 75; %Lv[80] = 150;
		case 14:%Lv[1] = 25; %Lv[18] = 25; %Lv[60] = 75; %Lv[80] = 150;
		case 15:%Lv[1] = 25; %Lv[18] = 25; %Lv[60] = 75; %Lv[80] = 150;
	}
	return %Lv[%LevelLimit];
}
// ��������������Ҫ����Ƭ����
// %LevelLimit Ҫ���Ƶ����޵ĵȼ�
// %StarLevel  Ҫ���Ƶ����޵��Ǽ�
function GetStrengthenTrumpNeedPieceNum(%LevelLimit,%StarLevel)
{
	%DesStarLevel = %StarLevel + 1;
	switch (%DesStarLevel)
	{
		case 1:%Lv[1] = 3; %Lv[18] = 3; %Lv[60] = 3; %Lv[80] = 3;
		case 2:%Lv[1] = 3; %Lv[18] = 3; %Lv[60] = 3; %Lv[80] = 3;
		case 3:%Lv[1] = 3; %Lv[18] = 3; %Lv[60] = 3; %Lv[80] = 3;
		case 4:%Lv[1] = 6; %Lv[18] = 6; %Lv[60] = 6; %Lv[80] = 6;
		case 5:%Lv[1] = 6; %Lv[18] = 6; %Lv[60] = 6; %Lv[80] = 6;
		case 6:%Lv[1] = 6; %Lv[18] = 6; %Lv[60] = 6; %Lv[80] = 6;
		case 7:%Lv[1] = 9; %Lv[18] = 9; %Lv[60] = 9; %Lv[80] = 9;
		case 8:%Lv[1] = 9; %Lv[18] = 9; %Lv[60] = 9; %Lv[80] = 9;
		case 9:%Lv[1] = 9; %Lv[18] = 9; %Lv[60] = 9; %Lv[80] = 9;
		case 10:%Lv[1] = 12; %Lv[18] = 12; %Lv[60] = 12; %Lv[80] = 12;
		case 11:%Lv[1] = 12; %Lv[18] = 12; %Lv[60] = 12; %Lv[80] = 12;
		case 12:%Lv[1] = 12; %Lv[18] = 12; %Lv[60] = 12; %Lv[80] = 12;
		case 13:%Lv[1] = 15; %Lv[18] = 15; %Lv[60] = 15; %Lv[80] = 15;
		case 14:%Lv[1] = 15; %Lv[18] = 15; %Lv[60] = 15; %Lv[80] = 15;
		case 15:%Lv[1] = 15; %Lv[18] = 15; %Lv[60] = 15; %Lv[80] = 15;
	}
	return %Lv[%LevelLimit];
}
// ��������������Ҫ��Ԫ������
// %LevelLimit Ҫ���������޵ĵȼ�
// %StarLevel  Ҫ���������޵��Ǽ�
function GetUpgradeTrumpNeedMoney(%LevelLimit,%StarLevel)
{
	switch (%LevelLimit)
	{
		case 18:return 150;
		case 60:return 200;
	}
	return 150;
}
// ��������������Ҫ����Ƭ����
// %LevelLimit Ҫ���������޵ĵȼ�
// %StarLevel  Ҫ���������޵��Ǽ�
function GetUpgradeTrumpNeedPieceNum(%LevelLimit,%StarLevel)
{
	return 10;
}
// �����������޺���ܵõ������޵ĵ���ID�б�
// %LevelLimit Ҫ���������޵ĵȼ�
// �����ʽΪ"ItemID01 ItemID02 ... "�Կո�ָ�
function GetTrumpUpgradeResultList(%LevelLimit)
{
	switch (%LevelLimit)
	{
		case 18:return "117020012 117030012 117040012";
		case 60:return "117020023 117030023 117040023";
	}

	return "117020012 117030012 117040012";
}
//�������������������������������޹����������ݡ���������������������������������

//��������������������������ȡ��ҳ���غ���������������������������������������
function GetHomeplace(%Player)
{
	%ActivityA = GetWord(%Player.GetActivity(2068),0);
	return 5;
}
//��������������������������ȡ��ҳ���غ���������������������������������������

//����������������������������Ԫ��������ؽű�����������������������������������
//��ȡ��ǰ���׵ȼ���Ҫ���ĵĵ���
function GetPetStrengthenItem(%lv)
{
	//	switch(%lv)
	//	{
	//		case 0: return "116010101";//����Ԫ������ʯ;
	//		case 1: return "116010102";//����Ԫ������ʯ;
	//		case 2: return "116010103";//����Ԫ������ʯ;
	//		case 3: return "116010104";//����Ԫ������ʯ;
	//		case 4: return "116010105";//����Ԫ������ʯ;
	//		default:return "116010106";//����Ԫ������ʯ;
	//	}

	return "116010101";
}
//��ȡ��ǰ���׵ȼ���Ҫ���ĵ�Ǯ
function GetPetStrengthenMoney(%lv)
{
	return 30000 * (%lv + 1) - 10000;
}
//��ȡ��ǰ���׵ȼ����յĳɹ�����
function PetStrengthen(%lv)
{
	switch (%lv)
	{
		case 0:
			%X = GetRandom(1,10000);
			if (%X <= 4000)return 1;
			else if (%X <= 8000)return 2;
			else return 6;

		case 1:
			%X = GetRandom(1,10000);
			if (%X <= 4000)return 1;
			else if (%X <= 8500)return 2;
			else return 6;

		case 2:
			%X = GetRandom(1,10000);
			if (%X <= 3000)return 1;
			else if (%X <= 6000)return 2;
			else if (%X <= 9000)return 3;
			else return 8;

		case 3:
			%X = GetRandom(1,10000);
			if (%X <= 2375)return 1;
			else if (%X <= 4750)return 2;
			else if (%X <= 7125)return 3;
			else if (%X <= 9500)return 4;
			else return 10;

		case 4:
			%X = GetRandom(1,10000);
			if (%X <= 1960)return 1;
			else if (%X <= 3920)return 2;
			else if (%X <= 5880)return 3;
			else if (%X <= 7840)return 4;
			else if (%X <= 9750)return 5;
			else return 12;

		default:
			%X = GetRandom(1,10000);
			if (%X <= 1640)return 1;
			else if (%X <= 3280)return 2;
			else if (%X <= 4920)return 3;
			else if (%X <= 6560)return 4;
			else if (%X <= 8205)return 5;
			else if (%X <= 9820)return 6;
			else return 14;
	}
}
//��ȡ�������ױ���
function GetPetStrengthenRang(%lv)
{
	switch (%lv)
	{
		case 1: return 3;
		case 2: return 3;
		case 3: return 4;
		case 4: return 5;
		case 5: return 6;
		case 6: return 7;
		default:return 0;
	}
}
//��ȡ�ܺͽ��ױ���
function GetPetStrengthenAmountRang(%lv)
{
	switch (%lv)
	{
		case 1: return 6;
		case 2: return 12;
		case 3: return 20;
		case 4: return 30;
		case 5: return 42;
		case 6: return 56;
		default:return 0;
	}
}
//�жϴ˵ȼ��Ƿ�Ϊ��������
function isPerfectStrengthen(%lv,%Num)
{
	switch (%lv)
	{
		case 1: %P = 6;
		case 2: %P = 6;
		case 3: %P = 8;
		case 4: %P = 10;
		case 5: %P = 12;
		case 6: %P = 14;
		default:%P = 0;
	}

	if (%Num >= %P)
		return 1;
	else
		return 0;
}
function GetPetStrengthenItemCount(%Lv)
{
	return %Lv + 1;
}
//����������������������������Ԫ��������ؽű�����������������������������������



//������������������������������ѹ��Ǵ�����������������������������������������
function FreeGuanXing(%Player,%newCount)
{
}
//������������������������������ѹ��Ǵ�����������������������������������������


//��������������������������ְϵͳ���ж���ҵ�ǰ���ģ���ٵ���һƷ�ס�����������
function GetGuanZhiLevel(%Player,%type)
{
	%FirstGuanZhiID = GetDesignationFirstIDByType(%type);  //��ȡ��/��ٵĵ�һ����λ��ID

	for (%i=%FirstGuanZhiID+17; %i>=%FirstGuanZhiID; %i--)
	{
		if (%Player.sptIsDesignationExist(%i))
			return %i;
	}
	return -1;
}
//��������������������������ְϵͳ - �ж���ҵ�ǰ����/��ٵ���һƷ�ס�����������

//����������������������������������������������������������������������������
function HasBit_City_Force(%Player)
{
	//%Family = %Player.GetFamily();
	//switch (%Family)
	//{
	//	case 1:return 1;	//�
	//	case 2:return 1;	//����
	//	case 3:return 2;	//�ܷ�
	//	case 4:return 2;	//�η�

	//	default: return 0;
	//}
	return 0;
}

//��������������������������ȡ����ҵ�ǰ������ȡ�ľ�����������������������������
function GetJingJiChangAward_CS(%Player,%Olddrank,%Combat)
{
	%JJC_Award[1,1] = 1500; %JJC_Award[1,2] = 1500; %JJC_Award[1,3] = 350;
	%JJC_Award[2,1] = 1450; %JJC_Award[2,2] = 1450; %JJC_Award[2,3] = 330;
	%JJC_Award[3,1] = 1400; %JJC_Award[3,2] = 1400; %JJC_Award[3,3] = 300;
	%JJC_Award[4,1] = 1300; %JJC_Award[4,2] = 1300; %JJC_Award[4,3] = 250;
	%JJC_Award[5,1] = 1250; %JJC_Award[5,2] = 1250; %JJC_Award[5,3] = 240;
	%JJC_Award[6,1] = 1200; %JJC_Award[6,2] = 1200; %JJC_Award[6,3] = 230;
	%JJC_Award[7,1] = 1150; %JJC_Award[7,2] = 1150; %JJC_Award[7,3] = 220;
	%JJC_Award[8,1] = 1100; %JJC_Award[8,2] = 1100; %JJC_Award[8,3] = 210;
	%JJC_Award[9,1] = 1050; %JJC_Award[9,2] = 1050; %JJC_Award[9,3] = 200;
	%JJC_Award[10,1] = 1000; %JJC_Award[10,2] = 1000; %JJC_Award[10,3] = 190;
	%JJC_Award[11,1] = 800; %JJC_Award[11,2] = 800; %JJC_Award[11,3] = 150;
	%JJC_Award[12,1] = 600; %JJC_Award[12,2] = 600; %JJC_Award[12,3] = 130;
	%JJC_Award[13,1] = 500; %JJC_Award[13,2] = 400; %JJC_Award[13,3] = 120;
	%JJC_Award[14,1] = 400; %JJC_Award[14,2] = 300; %JJC_Award[14,3] = 100;
	%JJC_Award[15,1] = 300; %JJC_Award[15,2] = 200; %JJC_Award[15,3] = 60;
	%JJC_Award[16,1] = 200; %JJC_Award[16,2] = 150; %JJC_Award[16,3] = 50;
	%JJC_Award[17,1] = 100; %JJC_Award[17,2] = 100; %JJC_Award[17,3] = 20;
	%JJC_Award[18,1] = 350; %JJC_Award[18,2] = 350; %JJC_Award[18,3] = 55;
	%JJC_Award[19,1] = 350; %JJC_Award[19,2] = 350; %JJC_Award[19,3] = 55;
	%JJC_Award[20,1] = 350; %JJC_Award[20,2] = 350; %JJC_Award[20,3] = 55;
	%JJC_Award[21,1] = 300; %JJC_Award[21,2] = 300; %JJC_Award[21,3] = 50;
	%JJC_Award[51,1] = 200; %JJC_Award[51,2] = 200; %JJC_Award[51,3] = 40;
	%JJC_Award[101,1] = 150; %JJC_Award[101,2] = 150; %JJC_Award[101,3] = 30;
	%JJC_Award[201,1] = 100; %JJC_Award[201,2] = 100; %JJC_Award[201,3] = 20;
	%JJC_Award[301,1] = 50; %JJC_Award[301,2] = 80; %JJC_Award[301,3] = 10;
	%JJC_Award[501,1] = 20; %JJC_Award[501,2] = 50; %JJC_Award[501,3] = 5;

	if (%Olddrank >= 501) %MingCi = 501;
	else if (%Olddrank >= 301) %MingCi = 301;
	else if (%Olddrank >= 201) %MingCi = 201;
	else if (%Olddrank >= 101) %MingCi = 101;
	else if (%Olddrank >= 51) %MingCi = 51;
	else if (%Olddrank >= 21) %MingCi = 21;
	else %MingCi = %Olddrank;

	%XiShu = %Combat/20 + 0.05;
	if (%XiShu > 3) %XiShu = 3;

	%JiFen = %JJC_Award[%MingCi,1] * %XiShu;
	%Exp   = %JJC_Award[%MingCi,2] * %XiShu * 10000;
	%Money = %JJC_Award[%MingCi,3] * %XiShu * 10000;

	return %JiFen @ " " @ %Exp @ " " @ %Money;
}

//����������������������������仯�����������ȼ��ű�����������������������������
// ��Ϊ���ȼ�������
function onTopPriority(%Player,%triggerId)
{
	//echo( "%triggerId =AA=" @ %triggerId );
}
// ԭ�����ȼ���ߵ����� ���ȼ�����ʱ
function onLowPriority(%Player,%triggerId)
{
	//echo( "%triggerId =BB=" @ %triggerId );
}
//����������������������������仯�����������ȼ��ű�����������������������������


//������������������������������ʾͨ�ýű���������������������������������������
function ChangeMoneyText(%money)
{
	if (%money $= ""  || %money == 0)
		return "";
	%Jin = mfloor(%money /10000);
	%Yin = mfloor((%money - %Jin * 10000)/100);
	%Ton = %money - %Jin * 10000 - %Yin * 100;

	if (%Jin > 0) %Text1 = "<t>" @ %Jin @ "</t>" @ $Icon[85];
	if (%Yin > 0) %Text2 = "<t>" @ %Yin @ "</t>" @ $Icon[86];
	if (%Ton > 0) %Text3 = "<t>" @ %Ton @ "</t>" @ $Icon[87];

	//SetChatMessage( %Text1 @ %Text2 @ %Text3, $Color[ 5 ], $chatMsg_System );
	//echo( %Text1 @ %Text2 @ %Text3 );
	return %Text1 @ %Text2 @ %Text3;
}

//������������������������������ʾͨ�ýű���������������������������������������

function HuanLeDaZhuanPan_Item(%DataID)
{
	return "";
}
function Family_City_DiaoXiang_Restart()
{
	return;
}
// ˢ�µ�ǰ��������
function RefreshMissionDesc(%MissionID)
{
	if ($CurrentMissionID != %MissionID || %MissionID == -1)
	{
		SingleWnd2_ShowMissionInfo.setcontent("");
		SingleWnd2_ShowMissionInfo1.setcontent("");
	}
	else
	{
		SingleWnd2_ShowMissionInfo.setcontent(GetMissionText(GetPlayer(),%MissionID));
		SingleWnd2_ShowMissionInfo1.setcontent($Icon[97] @ "<b/>" @ GetMissionHortation(%MissionID,0,10000));
	}
}


//��������������������������ȡbitֵ��actֵ�ĺ�����������������������������������
function GetSrc(%Player,%bit)
{
	%ActivityID = GetWord($Src_ReturnTime_ActivityID[%bit],0);
	%Resut =  GetWord($Src_ReturnTime_ActivityID[%bit],1);

	//echo( "%ActivityID  ===" @ %ActivityID   @ "   %Resut===" @ %Resut );
	if (%Resut <= 15)
	{
		%Numbers = GetAct(%Player,%ActivityID,0);
		return CheckBit(%Numbers,%Resut -1);
	}
	else
	{
		%Numbers = GetAct(%Player,%ActivityID,1);
		return CheckBit(%Numbers,%Resut -16);
	}
}
//��ȡAct��ֵ %bit 0λ����1λ
function GetAct(%Player,%ActivityID,%bit)
{
	return GetWord(%Player.GetActivity(%ActivityID),%bit) * 1;
}
//��������������������������ȡbitֵ��actֵ�ĺ�����������������������������������

//������������������������ǩ��----ȡֵ������������������������������������������
function GetQiandaoRecord(%Player,%Days)//��ȡĳһ���ǩ����¼
{
	if (%Days > 15)
		return CheckBit(GetAct(%Player,4020,1),%Days - 16);
	else
		return CheckBit(GetAct(%Player,4020,0),%Days);
}
function GetALLQianDaoRecord(%Player)//��ȡ����ǩ�������¼
{
	%Title = GetQiandaoRecord(%Player,1);
	for (%i = 2; %i<=31; %i++)
	{
		%Title = %Title @ " " @ GetQiandaoRecord(%Player,%i);
	}
	//echo( "%Title===" @ %Title );
	return %Title;
}
function GetALLQianDaoRecordDays(%Player)//��ȡ����ǩ������
{
	%Num = 0;
	for (%i = 1; %i<=31; %i++)
	{
		%Num = %Num + GetQiandaoRecord(%Player,%i);
	}
	//echo( "%Num===" @ %Num );
	return %Num;
}
//������������������������ǩ��----ȡֵ������������������������������������������

//��������������������������Ծ----��Ծ�ȼ��㡿����������������������������������
function GetHuoYueDuRecord(%Player)
{
	for (%i = 1; %i<= 3; %i++)
	{
		for (%j= 1; %j <= 99; %j++)
		{
			if ($HuoYueDuRecord[%i,%j] $= "")
				break;
			%Optype = GetWord($HuoYueDuRecord[%i,%j],1);
			%RecordID = GetWord($HuoYueDuRecord[%i,%j],2);
			%NeedCount = GetWord($HuoYueDuRecord[%i,%j],3);
			%GiveHuoYue = GetWord($HuoYueDuRecord[%i,%j],4);
			switch$(%Optype)
			{
		case "Src":
			%HaveCount = GetSrc(%Player,%RecordID);
		case "Act0":
			%HaveCount = GetAct(%Player,%RecordID,0)*1;
		case "Act1":
			%HaveCount = GetAct(%Player,%RecordID,1)*1;
		case "Spcl":
			%HaveCount = GetSpclHuoYueDu(%Player,%RecordID);
			%GiveHuoYue = GetSpclHuoYueDuAddNumBer(%Player,%RecordID,%GiveHuoYue);
			}
			if (%HaveCount >= %NeedCount)
				%HuoYue = %HuoYue + %GiveHuoYue;
		}
	}
	//echo( "%HuoYue====" @ %HuoYue );
	return %HuoYue * 1;
}
function GetSpclHuoYueDu(%Player,%RecordID)//���⴦��Ļ�Ծ����ɽ��ȼ���
{
	switch (%RecordID)
	{
		case 1://�������������⴦��
			%HaveCount = GetSrc(%Player,40) +  GetSrc(%Player,41) +  GetSrc(%Player,42) +  GetSrc(%Player,43) +  GetSrc(%Player,49) +  GetSrc(%Player,55) +  GetSrc(%Player,56);
			//echo( "%HaveCount===" @ %HaveCount );
		case 2://Ѻ�ڵ����⴦�� ÿ��+2�� һ��10��
			%HaveCount = GetAct(%Player,4018,0) * 1;
		case 3:
			%HaveCount = GetAct(%Player,4092,0) * 1;
		case 4:
			%Act = GetAct(%Player,4094,0);
			%Time = GetLocalTime();
			%Month = GetWord(%Time,1);
			%Day = GetWord(%Time,2);
			if (%Day < 10)
				%Day = "0" @ %Day;
			if (%Act * 1 ==  (%Month @ %Day) * 1)
				%HaveCount = 1;
			else
				%HaveCount = 0;
	}
	return %HaveCount;
}
function GetSpclHuoYueDuAddNumBer(%Player,%RecordType,%GiveHuoYue)//���⴦��Ļ�Ծ����ɸ�����ֵ����
{
	//echo( "%GiveHuoYue===" @ %GiveHuoYue );
	switch (%RecordType)
	{
		case 1://�������������⴦��
			%GiveHuoYue = %GiveHuoYue;
		case 2://Ѻ�ڵ����⴦�� ÿ��+2�� һ��10��
			%HaveCount = GetAct(%Player,4018,0) * 1;
			%GiveHuoYue = %HaveCount * 2;
			if (%GiveHuoYue <= 0)
				%GiveHuoYue = 10;
		case 3:
			%Color = GetAct(%Player,4092,1) * 1;
			switch (%Color)
			{
				case 1:%GiveHuoYue = 1;
				case 2:%GiveHuoYue = 2;
				case 3:%GiveHuoYue = 3;
				case 4:%GiveHuoYue = 5;
				case 5:%GiveHuoYue = 8;
				case 6:%GiveHuoYue = 10;
				default:%GiveHuoYue = %GiveHuoYue;
			}
	}
	return %GiveHuoYue;
}

//��������������������������Ծ----��Ծ�ȼ��㡿����������������������������������

//���������������������������͵�ͼǰ���жϡ�����������������������������������
function CanTransportobject(%Player,%optype)//ͨ�ô���ǰ��
{
	//����Ƿ�����
	if (%Player.IsDisabled())
	{
		return 0;
	}
	switch (%optype)
	{
		case 1://��ͨ��NPC����
			if (%Player.isInMultiMount())
			{
				%Txt = "����������޷�ǰ���˵�ͼ";
				SendOneScreenMessage(2,%Txt,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %Txt @ "</t>",%Player);
				return 0;
			}
		case 2://��ͼ��ť���� �ͻ��˴���
			//echo( "%Player.IsAcceptedMission( 20147 )===" @ %Player.IsAcceptedMission( 20147 ) );
			if (%Player.IsAcceptedMission(20147))
			{
				SendOneScreenMessage(2,"Ѻ��ʱ�޷�����",%Player);
				return 0;
			}
			if (%Player.GetTriggerId() $= "811190108" || %Player.GetTriggerId() $= "811190109")
			{
				SendOneScreenMessage(2, "�������޷�ʹ�ñ�����", %Player);
				return 0;
			}
			if (%Player.GetLevel() < 30)
			{
				SendOneScreenMessage(2, "���Ľ�ɫ����30�����޷����д���", %Player);
				SendOneChatMessage($chatMsg_System, "<t>���Ľ�ɫ����40�����޷����д���</t>", %Player);
				return 0;
			}
			if (%Player.GetFamilarityTarget() != 0)
			{
				SendOneScreenMessage(2, "����/ӵ��״̬���޷�ʹ�ñ�����", %Player);
				return 0;
			}
			if (%Player.isInMultiMount())
			{
				%Txt = "����������޷�ǰ���˵�ͼ";
				SendOneScreenMessage(2, %Txt, %Player);
				SendOneChatMessage($chatMsg_System, "<t>" @ %Txt @ "</t>", %Player);
				return 0;
			}
		case 3://ǧ����
			if (%Player.GetLevel() < 40)
			{
				SendOneScreenMessage(2,"���Ľ�ɫ����40�����޷����д���",%Player);
				SendOneChatMessage($chatMsg_System,"<t>���Ľ�ɫ����40�����޷����д���</t>",%Player);
				return 0;
			}
			//��ҵ�ǰ��æ���н���״̬�����ܴ���
			if ((%Player.GetInteractionState() == 1)||(%Player.GetInteractionState() == 2)||(%Player.GetInteractionState() > 3))
			{
				SendWhyMsg(%Player,"H",0,1);
				return 0;
			}
			if (GetSubStr(%Together,2,1) $= "3")
			{
				SendOneScreenMessage(2,"Ŀ��������ڸ����ڣ��޷�ֱ��ǰ��",%Player);
				SendOneChatMessage($chatMsg_System,"<t>Ŀ��������ڸ����ڣ��޷�ֱ��ǰ��</t>",%Player);
				return 0;
			}
			if (GetSubStr(GetZoneID(),1,1) $= "3")
			{
				SendOneScreenMessage(2,"�����ڸ����ڣ��޷�ֱ��ǰ��",%Player);
				SendOneChatMessage($chatMsg_System,"<t>�����ڸ����ڣ��޷�ֱ��ǰ��</t>",%Player);
				return 0;
			}
			if (%Player.GetTriggerId() $= "811190108" || %Player.GetTriggerId() $= "811190109")
			{
				SendOneScreenMessage(2,"�������޷�ʹ�ñ�����",%Player);
				return 0;
			}
			if (%Player.GetTriggerId() $= "811190108" || %Player.GetTriggerId() $= "811190109")
			{
				SendOneScreenMessage(2,"�����޷�ʹ�ñ�����",%Player);
				return 0;
			}
			if (%Player.GetFamilarityTarget() != 0)
			{
				SendOneScreenMessage(2,"����/ӵ��״̬���޷�ʹ�ñ�����",%Player);
				return 0;
			}
			if (%Player.IsDisabled())
			{
				SendWhyMsg(%Player,"AA",0,1);//����״̬�޷�ʹ�ûسǷ�
				return 0;
			}
			if (%Player.IsInCombat())
			{
				SendWhyMsg(%Player,"AB",0,1);//����Ƿ�ս����
				return 0;
			}
			if (%Player.isInMultiMount())
			{
				SendOneScreenMessage(2,"����������޷�ʹ�ñ�����",%Player);
				SendOneChatMessage($chatMsg_System,"<t>����������޷�ʹ�ñ�����</t>",%Player);
				return 0;
			}
			if (%Player.IsAcceptedMission(20147))
			{
				SendOneScreenMessage(2,"Ѻ��ʱ�޷�����",%Player);
				return 0;
			}
		case 4://��ӳ�����
			%PlayerID = %Player.GetPlayerID();
			if (SvrIsMyselfHasTeam(%PlayerID) == 0)
			{
				SendWhyMsg(%Player,"BF",0,1);//��û�ж��飬�޷�ʹ��
				return 0;
			}
			if (SvrIsMyselfCaption(%PlayerID))
			{
				SendWhyMsg(%Player,"BG",0,1);//�ù���ֻ���Ƕ�Ա�ſ�ִ��
				return 0;
			}
			if (%Player.IsAcceptedMission(20147))
			{
				SendOneScreenMessage(2,"Ѻ��ʱ�޷�����",%Player);
				return 0;
			}
			
		case 5://ʹ�ü��Ϸ�
			if (%Player.IsAcceptedMission(20147))
			{
				SendOneScreenMessage(2,"Ѻ��ʱ�޷�����",%Player);
				return 0;
			}
			if (%Player.Getlevel() < 30)
			{
				SendOneScreenMessage(2, "�ȼ����㣬30�����ϲſ��Ա��ٻ�", %Player);
				return 0;
			}
		case 6://�سǾ�
			if (%Player.IsDisabled())
			{
				SendWhyMsg(%Player,"AA",0,1);//����״̬�޷�ʹ�ûسǷ�
				return 0;
			}
			if (%Player.GetBuffCount(39903,1) >= 1 || %Player.GetBuffCount(39904,1) >= 1)
			{
				SendOneScreenMessage(2,"Я���в�ҩ���޷�����",%Player);
				return 0;
			}
			if (%Player.GetBuffCount(39906,1) >= 1 || %Player.GetBuffCount(39906,2) >= 1 || %Player.GetBuffCount(39906,3) >= 1)
			{
				SendOneScreenMessage(2,"Я������ʯ���޷�����",%Player);
				return 0;
			}
			if (%Player.IsAcceptedMission(20147))
			{
				SendOneScreenMessage(2,"������Ѻ�ڣ��޷�����",%Player);
				return 0;
			}
		case 7://�����
			if (%Player.IsDisabled())
			{
				SendWhyMsg(%Player,"AA",0,1);//����״̬�޷�ʹ�ûسǷ�
				return 0;
			}
			if (%Player.GetBuffCount(39903,1) >= 1 || %Player.GetBuffCount(39904,1) >= 1)
			{
				SendOneScreenMessage(2,"Я���в�ҩ���޷�����",%Player);
				return 0;
			}
			if (%Player.GetBuffCount(39906,1) >= 1 || %Player.GetBuffCount(39906,2) >= 1 || %Player.GetBuffCount(39906,3) >= 1)
			{
				SendOneScreenMessage(2,"Я������ʯ���޷�����",%Player);
				return 0;
			}
			if (%Player.IsAcceptedMission(20147))
			{
				SendOneScreenMessage(2,"������Ѻ�ڣ��޷�����",%Player);
				return 0;
			}
	}
	return 1;
}
//���������������������������͵�ͼǰ���жϡ�����������������������������������


//������������������������������ǰ�ĸ���׼��������������������������������������
function GetPlayerZiTiName(%Player,%optype)
{
	switch (%optype)
	{
		case 1: %PlayerName = "<l i='"@ %Player.GetPlayerName() @ " "@ %Player.GetPlayerID() @ "' t='name' />";
		case 2: %PlayerName = $Get_Dialog_GeShi[60006] @ "��" @ %Player.GetPlayerName() @ "��</t>";
	}
	return %PlayerName;
}
function GetNpcZiTiName(%Npc,%optype)
{
	if (isobject(%Npc))
		%NpcID = %Npc.GetDataID();
	else
		%NpcID = %Npc;
	switch (%optype)
	{
		case 1: %NpcName = $Get_Dialog_GeShi[31421] @ "��" @ GetNpcData(%NpcID,1) @ "��</t>";
		case 2: %NpcName = $Get_Dialog_GeShi[60003] @ "��" @ GetNpcData(%NpcID,1) @ "��</t>";
	}
	return %NpcName;
}
function GetHuoDongName(%HuoDong,%optype)
{
	switch (%optype)
	{
		case 1: %HuoDongName = $Get_Dialog_GeShi[31421] @ "��" @ %HuoDong @ "��</t>";
		case 2: %HuoDongName = $Get_Dialog_GeShi[60003] @ "��" @ %HuoDong @ "��</t>";
	}
	return %HuoDongName;
}
function GetMapName(%Caster,%optype)
{
	//echo(" %Caster===" @  %Caster @ "     " @ isobject(%Caster));
	if (isobject(%Caster))
	{
		%TriggerID = %Caster.GetTriggerId();
		%Pos = %Caster.GetPosition();
	}
	else
	{
		%TriggerID = %Caster;
		%Pos = %optype;
	}
	//echo("%TriggerID==" @ %TriggerID @ "   %Pos===" @ %Pos);
	switch (%optype)
	{
		case 1: %Path = "<l i='" @ GetSubStr(%TriggerID,0,7) @ "00 " @ %Pos @ "' t='path'/>";
		case 2:
			%MapID = GetZoneID();

			%MapName = GetTriggerData(GetSubStr(%TriggerID,0,7) @ "00",3);
			%TriggerName = GetTriggerData(%TriggerID,3);

			if (%MapName $= %TriggerName)
				%Path = $Get_Dialog_GeShi[60003] @ %MapName @ "</t>";
			else
				%Path = $Get_Dialog_GeShi[60003] @ %MapName @ "</t>" @ $Get_Dialog_GeShi[60002] @ %TriggerName @ "</t>";
		default: %Path = "<l i='" @ %TriggerID @ %Pos @ "' t='path'/>";
	}
	return %Path;
}
function GetItemName(%ItemID,%optype)
{
	switch (%optype)
	{
		case 1: %ItemName = "<l v='1' h='1' i='" @ %ItemID @ " ' t='itemid'/>";
		case 2:
			%ItemName = GetItemData(%ItemID,1);
			%Clor = GetItemData(%ItemID,20);
			switch (%Clor)
			{
				case 2: %Ziti = $Get_Dialog_GeShi[60004];//��ɫ
				case 3: %Ziti = $Get_Dialog_GeShi[60006];//��ɫ
				case 4: %Ziti = $Get_Dialog_GeShi[60005];//��ɫ
				case 5: %Ziti = $Get_Dialog_GeShi[60002];//��ɫ
				case 6: %Ziti = $Get_Dialog_GeShi[60003];//��
				case 7: %Ziti = $Get_Dialog_GeShi[60007];//��ɫ
				default: %Ziti = $Get_Dialog_GeShi[60004];
			}
			%ItemName = %Ziti @  "[" @ %ItemName @ "]</t>";
	}
	return %ItemName;
}
//������������������������������ǰ�ĸ���׼��������������������������������������


//��������������������������Ѱ����ť��������������������������������������������
function Get_TraceButton()
{
	$TraceButton = $TraceButton + 1;
	%Back = "TraceButton" @ $TraceButton;
	return %Back;
}

function Get_ChatButton()
{
	$ChatButton = $ChatButton + 1;
	%Back = "ChatButton" @ $ChatButton;
	return %Back;
}
//��������������������������Ѱ����ť��������������������������������������������

//��������������������������ɫ����ս�������ű�����������������������������������
function onPlayerCombatBegin(%Player)//�ͻ��˷����ͬʱ��������ӹ��ܵ�ʱ��Ҫ���ֿͻ��˺ͷ����
{
	//echo( "��ɫ����ս�������ű�%Player===" @ %Player );
	//%MapID = GetZoneID( );
}
//��������������������������ɫ����ս�������ű�����������������������������������

//��������������������������С�ȽϺ���������������������������������������������
function getMin(%a,%b)
{
	if (%a > %b)
		return %b;
	else
		return %a;
}
function getMax(%a,%b)
{
	if (%a < %b)
		return %b;
	else
		return %a;
}
//��������������������������С�ȽϺ���������������������������������������������

//����������������������������ս��������ء�������������������������������������
//������Ӧս����ֵ

//������Ӧս����ֵ
function GetNpcBattleGiftValue(%Monster)
{
	//��ȡ������
	%CopyMapID = %Monster.GetLayerId();

	//��ȡ����DataID
	%CopymapDataID = SptGetCopymapDataId(%CopyMapID);

	switch (%CopymapDataID)
	{
		//�� ʱ���Ѻ�֮�� �������
		case 1314: return $XuanWuMen_NpcBattleGiftValue[%CopyMapID];
	}

	return 0;
}
//����������������������������ս��������ء�������������������������������������


//��������������������������ݹ��� -- ������ƷID���ۼۡ���������������������
$QuickPurchase_Itemid[0] = 105106004; $QuickPurchase_Price[0] = 100; //�ᱦ��
$QuickPurchase_Itemid[1] = 105109524; $QuickPurchase_Price[1] = 100; //�ǽ�ʯ
//OpenBuyItemInterfaceWndGui($QuickPurchase_Itemid[0], $QuickPurchase_Price[0]);




//�������������������������ص�����ʵID������������������������������������������
function getItemTrueIDOrCnt(%Player, %oldItemID, %cntInfo, %Spare)
{
	%Plv = %Player.Getlevel();
	if(%Plv < 10) %Plv = 10;
	else if(%Plv >= 15 && %Plv < 20) %Plv = 20;
	
	%sex = %Player.GetSex();
	%liyuVipLv = VIP_getTequanLv(%Player, 1);
	
	if(%oldItemID*1 > 0)
	{
		//ʱװ
		%ItemSubtype = GetItemData(%oldItemID,3);
		if (%ItemSubtype == 210)//����ʱװ
		{
			if(%sex == 2)
				return %oldItemID + 500;
			else return %oldItemID;
		}

		switch(%oldItemID)
		{
			case 105020303:	//3����Ѫ��(��Ʒ)
				return 105020300 + Mfloor(%Plv/10);
			
			case 105020353:	//3������ɢ(��Ʒ)
				return 105020350 + Mfloor(%Plv/10);
			
			case 105020103:	//3����Ѫ��
				return 105020100 + Mfloor(%Plv/10);
			
			case 105020153:	//3������ɢ
				return 105020150 + Mfloor(%Plv/10);
			
			case 105100201:	//��Լ�桾�������꡿����Ʒ��
				if(%Spare*1 > 0)
					return %oldItemID;
					
						 if(%liyuVipLv == 1) return 105021601;
				else if(%liyuVipLv == 2) return 105021603;
				else if(%liyuVipLv == 3) return 105021605;
			
			case 105100202:	//��Լ�桾�������꡿����Ʒ��
				if(%Spare*1 > 0)
					return %oldItemID;
					
						 if(%liyuVipLv == 1) return 105021602;
				else if(%liyuVipLv == 2) return 105021604;
				else if(%liyuVipLv == 3) return 105021606;
			
			case 102103029:	//ר��ʱװ1��
				if(%sex == 2) return 102103529;
				else return %oldItemID;
			
			case 105021201:	//������(��Ʒ)
				if(%Spare == 1)	//��ʾ��
				{
							 if(%Plv < 70)  return 105021201;
					else if(%Plv < 90)  return 105021202;
					else if(%Plv < 100) return 105021203;
					else								return 105021204;
				}
				else	//ʵ�ʸ���
				{
					if(%liyuVipLv == 2)
					{
								 if(%Plv < 70)  return 105021221;	//�ƽ�
						else if(%Plv < 90)  return 105021222;
						else if(%Plv < 100) return 105021223;
						else								return 105021224;
					}
					else if(%liyuVipLv == 3)
					{
								 if(%Plv < 70)  return 105021241;	//�׽�
						else if(%Plv < 90)  return 105021242;
						else if(%Plv < 100) return 105021243;
						else								return 105021244;
					}
				}
			
			case 105021211:	//��Ԫɢ(��Ʒ)
				if(%Spare == 1)	//��ʾ��
				{
							 if(%Plv < 70)  return 105021211;
					else if(%Plv < 90)  return 105021212;
					else if(%Plv < 100) return 105021213;
					else								return 105021214;
				}
				else	//ʵ�ʸ���
				{
					if(%liyuVipLv == 2)
					{
								 if(%Plv < 70)  return 105021231;	//�ƽ�
						else if(%Plv < 90)  return 105021232;
						else if(%Plv < 100) return 105021233;
						else								return 105021234;
					}
					else if(%liyuVipLv == 3)
					{
								 if(%Plv < 70)  return 105021251;	//�׽�
						else if(%Plv < 90)  return 105021252;
						else if(%Plv < 100) return 105021253;
						else								return 105021254;
					}
				}
		}
		return %oldItemID;
	}
	
	if(%cntInfo !$= "")
	{
		%min = GetWord(%cntInfo,0,"-");
		%max = GetWord(%cntInfo,1,"-");
		%cnt = GetRandom(%min,%max);
		return %cnt;
	}
	
	return 0;
}


//������������������������ȡԪ�����ġ�������������������������������������
function SpecialItem_DaoJing_GetYuanBaoExpend(%Player, %type)
{
	%YB[1] = %YB[2] = %YB[3] = 200;
	%YB[4] = %YB[5] = %YB[6] = 400;
	%YB[7] = %YB[8] = %YB[9] = 500;
	%YB[10] = 600;
	
	%ActiveAA = GetAct(%Player,4300,0)*1 + 1;
	if(%ActiveAA <= 10)
		%NeedYB = %YB[%ActiveAA];
	else
		%NeedYB = %YB[10] + (%ActiveAA-10)*100;
	
	if(%type == 2)
		return %NeedYB;
	else
		return %NeedYB*2+100;
}
//������������������������ȡԪ�����ġ�������������������������������������������


//������������������������ȡԪ�����ġ�������������������������������������������

//��������������������������ȡ���װ��������������������������������������������
function GetRanDomPurpleEquipment(%Level)
{
	%classes = getrandom(1, 3);
	switch (%classes)
	{
	case 1:%classes = 1;
	case 2:%classes = 4;
	case 3:%classes = 8;
	}
	%number = getrandom(1, 18);
	if (%number == 1)
	{
		%ran = getrandom(1, 100);//�滻Ϊ����������
		if (%ran <= 20)
		{
			%classes = 31;
			%number = 1;
		}
	}
	%itemid = $PurpleEquipment_LevelForty[%classes, %number];
	%itemid = %itemid - 4 + mfloor(%Level / 10);
	return %itemid;
}
//��������������������������ȡ���װ��������������������������������������������