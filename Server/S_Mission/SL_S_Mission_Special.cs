//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//���������ű����������������������ű�
//
//==================================================================================
//������������������������������Missionflag����������������������������������
//�����������������������Ի�������ר�ýӿڡ���������������������������������

//��������������������������Ի��������NPC����������������������������������

//�ο���ʽ��

function Mission_Special(%Npc,%Player,%State,%Conv,%Param)
{
	%ZoneID = GetSubStr(GetZoneID(),0,4);
	//echo( "Mission_Special" );
	switch (%ZoneID)
	{
		case 1001://����
			switch (%Npc.GetDataID())
			{
				case 400001514: return Mission_Special_21029(%Npc,%Player,%State,%Conv,21506);	//��������̰������
					//------------������ĵ�--------------
				case 410010116: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30205);//�����ĵ�
				case 410010117: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30305);//�÷��ĵ�
				case 410010118: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30405);//�����ĵ�
				case 410010115: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30505);//�����ĵ�
				case 410010119: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30605);//�����ĵ�
				case 410010140: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30705);//����ĵ�
			}
		case 1010://����
			switch (%Npc.GetDataID())
			{
				case 410100002: return
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//ʦ�ž���		�淮
				case 410100003:
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//ʦ�ž���		��ҵ

				case 410100004:
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//ʦ�ž���		����

				case 410100005:
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//ʦ�ž���		����
					Mission_Special_10341(%Npc,%Player,%State,%Conv,10341);	//�������

				case 410100006: return
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//ʦ�ž���		��ƽ��
				case 410100007: return
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//ʦ�ž���		����ʯ
				case 410100008: return
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//ʦ�ž���		�ŵ�ɽ
				case 410100009: return
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//ʦ�ž���		����
				case 410100010:
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//ʦ�ž���		����

				case 410100011: return
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//ʦ�ž���		
				case 410100012:
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//ʦ�ž���		

				case 410100032: return
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//ʦ�ž���		����
				case 410100031: return
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//ʦ�ž���		ɲ��


			}
		case 1128://���ɿ�
			switch (%Npc.GetDataID())
			{
				case 411280003: return Npc_Dialog_411280003(%Npc,%Player,%State,%Conv,%Param); //���ɿ�һ��������񷢲�
				case 411280004: return Npc_Dialog_411280004(%Npc,%Player,%State,%Conv,%Param); //���ɿ߶���������񷢲�

					//���ɿ�һ��Ӫ��NPC
				case 411280005: return Npc_Dialog_411280005_411280009(%Npc,%Player,%State,%Conv,%Param,411280005); //���ɿ�һ��Ӫ��NPC
				case 411280006: return Npc_Dialog_411280005_411280009(%Npc,%Player,%State,%Conv,%Param,411280006); //���ɿ�һ��Ӫ��NPC
				case 411280007: return Npc_Dialog_411280005_411280009(%Npc,%Player,%State,%Conv,%Param,411280007); //���ɿ�һ��Ӫ��NPC
				case 411280008: return Npc_Dialog_411280005_411280009(%Npc,%Player,%State,%Conv,%Param,411280008); //���ɿ�һ��Ӫ��NPC
				case 411280009: return Npc_Dialog_411280005_411280009(%Npc,%Player,%State,%Conv,%Param,411280009); //���ɿ�һ��Ӫ��NPC
					//���ɿ߶���Ӫ��NPC																							
				case 411280010: return Npc_Dialog_411280010_411280014(%Npc,%Player,%State,%Conv,%Param,411280010); //���ɿ߶���Ӫ��NPC
				case 411280011: return Npc_Dialog_411280010_411280014(%Npc,%Player,%State,%Conv,%Param,411280011); //���ɿ߶���Ӫ��NPC
				case 411280012: return Npc_Dialog_411280010_411280014(%Npc,%Player,%State,%Conv,%Param,411280012); //���ɿ߶���Ӫ��NPC
				case 411280013: return Npc_Dialog_411280010_411280014(%Npc,%Player,%State,%Conv,%Param,411280013); //���ɿ߶���Ӫ��NPC
				case 411280014: return Npc_Dialog_411280010_411280014(%Npc,%Player,%State,%Conv,%Param,411280014); //���ɿ߶���Ӫ��NPC
			}
		case 1129://��������
			switch (%Npc.GetDataId())
			{
				case 411290002: return Npc_Dialog_411290002(%Npc,%Player,%State,%Conv,%Param); //��������1��������񷢲�
				case 411290004: return Npc_Dialog_411290004(%Npc,%Player,%State,%Conv,%Param); //��������2��������񷢲�

					//��������1��Ӫ��NPC
				case 411291009: return Npc_Dialog_411291009_411291013(%Npc,%Player,%State,%Conv,%Param,411291009); //��������1��Ӫ��NPC
				case 411291010: return Npc_Dialog_411291009_411291013(%Npc,%Player,%State,%Conv,%Param,411291010); //��������1��Ӫ��NPC
				case 411291011: return Npc_Dialog_411291009_411291013(%Npc,%Player,%State,%Conv,%Param,411291011); //��������1��Ӫ��NPC
				case 411291012: return Npc_Dialog_411291009_411291013(%Npc,%Player,%State,%Conv,%Param,411291012); //��������1��Ӫ��NPC
				case 411291013: return Npc_Dialog_411291009_411291013(%Npc,%Player,%State,%Conv,%Param,411291013); //��������1��Ӫ��NPC

					//��������2��Ӫ��NPC
				case 411291015: return Npc_Dialog_411291015_411291019(%Npc,%Player,%State,%Conv,%Param,411291015); //��������2��Ӫ��NPC
				case 411291016: return Npc_Dialog_411291015_411291019(%Npc,%Player,%State,%Conv,%Param,411291016); //��������2��Ӫ��NPC
				case 411291017: return Npc_Dialog_411291015_411291019(%Npc,%Player,%State,%Conv,%Param,411291017); //��������2��Ӫ��NPC
				case 411291018: return Npc_Dialog_411291015_411291019(%Npc,%Player,%State,%Conv,%Param,411291018); //��������2��Ӫ��NPC
				case 411291019: return Npc_Dialog_411291015_411291019(%Npc,%Player,%State,%Conv,%Param,411291019); //��������2��Ӫ��NPC
			}
	}
	//���ֵ�ͼ
	switch (%Npc.GetDataID())
	{
		case 410100025:return Mission_Special_10001(%Npc,%Player,%State,%Conv,10001);	//����ָ��		����ʯ 10001
		case 411020012:return Npc_Dialog_411020012(%Npc,%Player,%State,%Conv,%Param);//��ɽѩ����ʱ�ô���NPC
		case 410100062:return Mission_Special_10191(%Npc,%Player,%State,%Conv,10191);//����
		case 410100054:return Mission_Special_10151(%Npc,%Player,%State,%Conv,10151);//ҩ԰�
			//---------������ĵ�---------------
		case 411020020: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30103);//�ڿ��ĵ�
		case 410100053: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30113);//��ľ�ĵ�
		case 410100002: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30123);//��ҩ�ĵ�
		case 411010003: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30133);//�����ĵ�

		case 411010020: return WangXianGu_YunYouYinShi_ChuFa(%Npc,%Player,%State,%Conv,20205);//���ɹ�-������ʿ
	}
}
