//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//���л���ݱ�ű�
//
//==================================================================================

//������ת��ڣ�ѡ�к�ʹ��F3���ɣ�����㲻����UE���ǾͰﲻ������

//������������������ʱ�����ֵ�б������������������������������������������
//����������������ȡ0��24Сʱ���ʱ�����������������������������������������
$SetPlayGameReturnTime = 0;
function SetPlayGameReturnTime(%YY,%MM,%DD,%H,%M,%S)
{

	//��ĳһ�����ֵ��Act��ʽ
	//if(%H < 6)
	//	$PlayGameReturnTime[2] = %Year @ %MM @ %DD @ "0701";
	//else
	//	{
	//		if(%DD == %Mon[ %MM ])
	//			{
	//				%DD_A = "01";
	//				%MM_A = %MM + 1;
	//			}
	//			else
	//				{
	//					%DD_A = %DD + 1;
	//					%MM_A = %MM;
	//				}
	//		if(strlen(%MM_A) == 1)%MM_A = "0" @ %MM_A;
	//		if(strlen(%DD_A) == 1)%DD_A = "0" @ %DD_A;

	//		$PlayGameReturnTime[2] = %Year @ %MM_A @ %DD_A @ "0701";
	//	}
	if (%H >= 0 && %H < 4)%H4 = 0;
	else if (%H >= 4 && %H < 8)%H4 = 4;
	else if (%H >= 8 && %H < 12)%H4 = 8;
	else if (%H >= 12 && %H < 16)%H4 = 12;
	else if (%H >= 16 && %H < 20)%H4 = 16;
	else if (%H >= 20 && %H < 24)%H4 = 20;

	$XZL_ClearTime_Hour[1] = GetNeedTime(1,%YY,%MM,%DD,%H);//��һ��Сʱ�������
	$XZL_ClearTime_4Hour[1] = GetNeedTime(4,%YY,%MM,%DD,%H4);//
	$XZL_ClearTime_6Hour[1] = GetNeedTime(6,%YY,%MM,%DD,%H4);

	$XZL_ClearTime_Never[1] = 0;    //�Ӳ�����
	$XZL_ClearTime_Tomorrow[1] = 1;	//ÿ�յ�01�����ã��������Է���Ϊ��λ
	$XZL_ClearTime_week[1] = 2;			//ÿ�ܵ�01�����ã�������������Ϊ��λ
	$XZL_ClearTime_month[1] = 3;		//ÿ�µ�01�����ã����������·�Ϊ��λ


	$PlayGameReturnTime[3015] = $XZL_ClearTime_Hour[1];//��¼ѭ�������CD	Npc��ţ�
	$PlayGameReturnTime[3016] = $XZL_ClearTime_Hour[1];//��¼ѭ�������CD	Npc��ţ�
	$PlayGameReturnTime[3017] = $XZL_ClearTime_Hour[1];//��¼ѭ�������CD	Npc��ţ�
	$PlayGameReturnTime[3018] = $XZL_ClearTime_Hour[1];//��¼ѭ�������CD	Npc��ţ�
	$PlayGameReturnTime[3019] = $XZL_ClearTime_Hour[1];//��¼ѭ�������CD	Npc��ţ�
	$PlayGameReturnTime[3020] = $XZL_ClearTime_Hour[1];//��¼ѭ�������CD	Npc��ţ�

	$PlayGameReturnTime[3032] =$XZL_ClearTime_4Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[3033] =$XZL_ClearTime_4Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[3034] =$XZL_ClearTime_4Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[3035] =$XZL_ClearTime_4Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[3036] =$XZL_ClearTime_4Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[3037] =$XZL_ClearTime_4Hour[1];//����̵�ļ�¼

	$PlayGameReturnTime[3998] = $XZL_ClearTime_Never[1];//���ڼ�¼�ڰ汾���º��Ƿ���Ҫ��������̵�
	$PlayGameReturnTime[3999] = $XZL_ClearTime_Tomorrow[1];//����̵�ļ�¼ 0λ��Ѵ�����¼ 1λ��ʱ����
	$PlayGameReturnTime[4000] =$XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4001] =$XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4002] =$XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4003] =$XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4004] =$XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4005] =$XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4006] =$XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4007] =$XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4008] =$XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4009] =$XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4010] =$XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4011] =$XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	//��������ĸ���ʱ�����ã�ֻ��Ҫִ��1�μ���
	if ($SetPlayGameReturnTime == 0)
		$SetPlayGameReturnTime = 1;
	else
		return;

	for (%i=0; %i<=99; %i++)//�ⲿ��������SetSrc������λ�����¼����
	{
		$PlayGameReturnTime[2600 + %i] = $XZL_ClearTime_Never[1];
		$PlayGameReturnTime[2700 + %i] = $XZL_ClearTime_Tomorrow[1];
		$PlayGameReturnTime[2800 + %i] = $XZL_ClearTime_week[1];
		$PlayGameReturnTime[2900 + %i] = $XZL_ClearTime_month[1];
	}

	//$PlayGameReturnTime[1] = %Day_ReturnTime;			//Ů洲�������ʱ�䣺���յ�23��59��

	$PlayGameReturnTime[2209] = $XZL_ClearTime_Tomorrow[1];//��Ҹ��������¼
	$PlayGameReturnTime[3001] = $XZL_ClearTime_Tomorrow[1];//ȺӢ���

	$PlayGameReturnTime[3002] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020005] =3002;//��¼ѭ�������CD	Npc��ţ�411020005
	$PlayGameReturnTime[3003] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020001] =3003;//��¼ѭ�������CD	Npc��ţ�411020001
	$PlayGameReturnTime[3004] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020002] =3004;//��¼ѭ�������CD	Npc��ţ�411020002
	$PlayGameReturnTime[3005] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020003] =3005;//��¼ѭ�������CD	Npc��ţ�411020003
	$PlayGameReturnTime[3006] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020004] =3006;//��¼ѭ�������CD	Npc��ţ�411020004
	$PlayGameReturnTime[3007] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020101] =3007;//��¼ѭ�������CD	Npc��ţ�411020101
	$PlayGameReturnTime[3008] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020121] =3008;//��¼ѭ�������CD	Npc��ţ�411020121
	$PlayGameReturnTime[3009] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020141] =3009;//��¼ѭ�������CD	Npc��ţ�411020141
	$PlayGameReturnTime[3010] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020161] =3010;//��¼ѭ�������CD	Npc��ţ�411020161
	$PlayGameReturnTime[3011] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020181] =3011;//��¼ѭ�������CD	Npc��ţ�411020181
	$PlayGameReturnTime[3012] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020221] =3012;//��¼ѭ�������CD	Npc��ţ�411020221
	$PlayGameReturnTime[3013] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020241] =3013;//��¼ѭ�������CD	Npc��ţ�411020241
	$PlayGameReturnTime[3014] = $XZL_ClearTime_Hour[1]; $Mission_ActRecord[411020261] =3014;//��¼ѭ�������CD	Npc��ţ�411020261

	$PlayGameReturnTime[3015] = $XZL_ClearTime_Hour[1];//��¼ѭ�������CD	Npc��ţ�
	$PlayGameReturnTime[3016] = $XZL_ClearTime_Hour[1];//��¼ѭ�������CD	Npc��ţ�
	$PlayGameReturnTime[3017] = $XZL_ClearTime_Hour[1];//��¼ѭ�������CD	Npc��ţ�
	$PlayGameReturnTime[3018] = $XZL_ClearTime_Hour[1];//��¼ѭ�������CD	Npc��ţ�
	$PlayGameReturnTime[3019] = $XZL_ClearTime_Hour[1];//��¼ѭ�������CD	Npc��ţ�
	$PlayGameReturnTime[3020] = $XZL_ClearTime_Hour[1];//��¼ѭ�������CD	Npc��ţ�


	$PlayGameReturnTime[3028] = $XZL_ClearTime_Tomorrow[1];//������ȡ״��
	$PlayGameReturnTime[3029] = $XZL_ClearTime_Tomorrow[1];//ʱ���Ѻ�
	$PlayGameReturnTime[3030] = $XZL_ClearTime_Tomorrow[1];//��ħԨ 0λ ��Ѵ����Ƿ�ʹ�� 1λ�շѴ�����¼
	$PlayGameReturnTime[3031] = $XZL_ClearTime_Never[1];//��ɫ�洢��˫��ʱ��

	$PlayGameReturnTime[3032] =$XZL_ClearTime_4Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[3033] =$XZL_ClearTime_4Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[3034] =$XZL_ClearTime_4Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[3035] =$XZL_ClearTime_4Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[3036] =$XZL_ClearTime_4Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[3037] =$XZL_ClearTime_4Hour[1];//����̵�ļ�¼

	$PlayGameReturnTime[3038] = $XZL_ClearTime_Tomorrow[1];//�۱����¼ 0λ ��Ѵ���ʣ�� + �Ѿ�ʹ��Ԫ���һ�������¼, 1λ ���նһ������ܼ�¼

	$PlayGameReturnTime[3998] = $XZL_ClearTime_Never[1];//���ڼ�¼�ڰ汾���º��Ƿ���Ҫ��������̵� 0λ��¼ 1λչʾ����
	$PlayGameReturnTime[3999] = $XZL_ClearTime_Tomorrow[1];//����̵�ļ�¼ 0λ��Ѵ�����¼ 1λ��ʱ����
	$PlayGameReturnTime[4000] = $XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4001] = $XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4002] = $XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4003] = $XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4004] = $XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4005] = $XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4006] = $XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4007] = $XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4008] = $XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4009] = $XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4010] = $XZL_ClearTime_6Hour[1];//����̵�ļ�¼
	$PlayGameReturnTime[4011] = $XZL_ClearTime_6Hour[1];//����̵�ļ�¼

	$PlayGameReturnTime[4012] =$XZL_ClearTime_Tomorrow[1];//�ر�ͼ���¼  0λ ����������� 1λ�ر�ͼ��������
	$PlayGameReturnTime[4013] =$XZL_ClearTime_Never[1];//��������������¼
	$PlayGameReturnTime[4014] =$XZL_ClearTime_Never[1];//�ر�ͼ�ڱ��������¼
	$PlayGameReturnTime[4015] =$XZL_ClearTime_Tomorrow[1];//0λ ��¼ʦ����������˼���  1λ �������񼸴�
	$PlayGameReturnTime[4016] =$XZL_ClearTime_Tomorrow[1];//0λ ����ڼ��βμ�  1λ ��¼���˵ڼ���
	$PlayGameReturnTime[4017] =$XZL_ClearTime_Never[1];//0λ ��¼����ܹ�������Ե��ǩ�������ܴ������������
	$PlayGameReturnTime[4018] =$XZL_ClearTime_Tomorrow[1];// Ѻ�ڻ��¼ 0λ��¼��ǰ���ڼ��� 1λ��¼���ڵ�Ѻ��״̬
	$PlayGameReturnTime[4019] =$XZL_ClearTime_Never[1];//��ҹ����� 0λ ���������ɫʱ����ID 1λ ��ǰ���ڵ���ID
	$PlayGameReturnTime[4020] =$XZL_ClearTime_month[1];//��¼��ҵ�¼ǩ������ 0λ 1�ŵ�15�� 1λ 16�ŵ�31��
	$PlayGameReturnTime[4021] =$XZL_ClearTime_Never[1];//��¼����½���ɫ 7���ͺ��� 0λ��ɫ����ʱ�� 1λ ����bitֵ��¼�Ƿ��Ѿ���ȡ�ý���
	$PlayGameReturnTime[4022] =$XZL_ClearTime_Tomorrow[1];//�����ɵ����¼  0λ �Ƿ��Ѿ��һ������ 1λ ������˼�����
	$PlayGameReturnTime[4023] =$XZL_ClearTime_Tomorrow[1];//���������¼ 0λ ����һ��������Ƽ��� 1λ ��������������ٴ�
	$PlayGameReturnTime[4024] =$XZL_ClearTime_Tomorrow[1];//�����۾� 0λ ����˼��� 1λ ����˼���

	$PlayGameReturnTime[4025] =$XZL_ClearTime_Never[1];//���ͼ��� ���ϵ������¼ 0λ ������ 1λ ������ɫƷ��
	$PlayGameReturnTime[4026] =$XZL_ClearTime_Never[1];//���ͼ��� ���ϵ������¼ 0λ ������ 1λ ������ɫƷ��
	$PlayGameReturnTime[4027] =$XZL_ClearTime_Never[1];//���ͼ��� ���ϵ������¼ 0λ ������ 1λ ������ɫƷ��
	$PlayGameReturnTime[4028] =$XZL_ClearTime_Never[1];//���ͼ��� ���ϵ������¼ 0λ ������ 1λ ������ɫƷ��
	$PlayGameReturnTime[4029] =$XZL_ClearTime_Never[1];//���ͼ��� ���ϵ������¼ 0λ ������ 1λ ������ɫƷ��

	$PlayGameReturnTime[4030] = $XZL_ClearTime_Never[1];//���ͼ��� 1101��ͼ ��0������
	$PlayGameReturnTime[4031] = $XZL_ClearTime_Never[1];//���ͼ��� 1101��ͼ ��1������
	$PlayGameReturnTime[4032] = $XZL_ClearTime_Never[1];//���ͼ��� 1101��ͼ ��2������
	$PlayGameReturnTime[4033] = $XZL_ClearTime_Never[1];//���ͼ��� 1101��ͼ ��3������
	$PlayGameReturnTime[4034] = $XZL_ClearTime_Never[1];//���ͼ��� 1101��ͼ ��4������
	$PlayGameReturnTime[4035] = $XZL_ClearTime_Never[1];//���ͼ��� 1101��ͼ ��5������
	$PlayGameReturnTime[4036] = $XZL_ClearTime_Never[1];//���ͼ��� 1101��ͼ ��6������
	$PlayGameReturnTime[4037] = $XZL_ClearTime_Never[1];//���ͼ��� 1101��ͼ ��7������
	$PlayGameReturnTime[4038] = $XZL_ClearTime_Never[1];//���ͼ��� 1101��ͼ ��8������
	$PlayGameReturnTime[4039] = $XZL_ClearTime_Never[1];//���ͼ��� 1101��ͼ ��9������
	$PlayGameReturnTime[4040] = $XZL_ClearTime_Never[1];//���ͼ��� 1102��ͼ ��0������
	$PlayGameReturnTime[4041] = $XZL_ClearTime_Never[1];//���ͼ��� 1102��ͼ ��1������
	$PlayGameReturnTime[4042] = $XZL_ClearTime_Never[1];//���ͼ��� 1102��ͼ ��2������
	$PlayGameReturnTime[4043] = $XZL_ClearTime_Never[1];//���ͼ��� 1102��ͼ ��3������
	$PlayGameReturnTime[4044] = $XZL_ClearTime_Never[1];//���ͼ��� 1102��ͼ ��4������
	$PlayGameReturnTime[4045] = $XZL_ClearTime_Never[1];//���ͼ��� 1102��ͼ ��5������
	$PlayGameReturnTime[4046] = $XZL_ClearTime_Never[1];//���ͼ��� 1102��ͼ ��6������
	$PlayGameReturnTime[4047] = $XZL_ClearTime_Never[1];//���ͼ��� 1102��ͼ ��7������
	$PlayGameReturnTime[4048] = $XZL_ClearTime_Never[1];//���ͼ��� 1102��ͼ ��8������
	$PlayGameReturnTime[4049] = $XZL_ClearTime_Never[1];//���ͼ��� 1102��ͼ ��9������
	$PlayGameReturnTime[4050] = $XZL_ClearTime_Never[1];//���ͼ��� 1103��ͼ ��0������
	$PlayGameReturnTime[4051] = $XZL_ClearTime_Never[1];//���ͼ��� 1103��ͼ ��1������
	$PlayGameReturnTime[4052] = $XZL_ClearTime_Never[1];//���ͼ��� 1103��ͼ ��2������
	$PlayGameReturnTime[4053] = $XZL_ClearTime_Never[1];//���ͼ��� 1103��ͼ ��3������
	$PlayGameReturnTime[4054] = $XZL_ClearTime_Never[1];//���ͼ��� 1103��ͼ ��4������
	$PlayGameReturnTime[4055] = $XZL_ClearTime_Never[1];//���ͼ��� 1103��ͼ ��5������
	$PlayGameReturnTime[4056] = $XZL_ClearTime_Never[1];//���ͼ��� 1103��ͼ ��6������
	$PlayGameReturnTime[4057] = $XZL_ClearTime_Never[1];//���ͼ��� 1103��ͼ ��7������
	$PlayGameReturnTime[4058] = $XZL_ClearTime_Never[1];//���ͼ��� 1103��ͼ ��8������
	$PlayGameReturnTime[4059] = $XZL_ClearTime_Never[1];//���ͼ��� 1103��ͼ ��9������
	$PlayGameReturnTime[4060] = $XZL_ClearTime_Never[1];//���ͼ��� 1104��ͼ ��0������
	$PlayGameReturnTime[4061] = $XZL_ClearTime_Never[1];//���ͼ��� 1104��ͼ ��1������
	$PlayGameReturnTime[4062] = $XZL_ClearTime_Never[1];//���ͼ��� 1104��ͼ ��2������
	$PlayGameReturnTime[4063] = $XZL_ClearTime_Never[1];//���ͼ��� 1104��ͼ ��3������
	$PlayGameReturnTime[4064] = $XZL_ClearTime_Never[1];//���ͼ��� 1104��ͼ ��4������
	$PlayGameReturnTime[4065] = $XZL_ClearTime_Never[1];//���ͼ��� 1104��ͼ ��5������
	$PlayGameReturnTime[4066] = $XZL_ClearTime_Never[1];//���ͼ��� 1104��ͼ ��6������
	$PlayGameReturnTime[4067] = $XZL_ClearTime_Never[1];//���ͼ��� 1104��ͼ ��7������
	$PlayGameReturnTime[4068] = $XZL_ClearTime_Never[1];//���ͼ��� 1104��ͼ ��8������
	$PlayGameReturnTime[4069] = $XZL_ClearTime_Never[1];//���ͼ��� 1104��ͼ ��9������
	$PlayGameReturnTime[4070] = $XZL_ClearTime_Never[1];//���ͼ��� 1105��ͼ ��0������
	$PlayGameReturnTime[4071] = $XZL_ClearTime_Never[1];//���ͼ��� 1105��ͼ ��1������
	$PlayGameReturnTime[4072] = $XZL_ClearTime_Never[1];//���ͼ��� 1105��ͼ ��2������
	$PlayGameReturnTime[4073] = $XZL_ClearTime_Never[1];//���ͼ��� 1105��ͼ ��3������
	$PlayGameReturnTime[4074] = $XZL_ClearTime_Never[1];//���ͼ��� 1105��ͼ ��4������
	$PlayGameReturnTime[4075] = $XZL_ClearTime_Never[1];//���ͼ��� 1105��ͼ ��5������
	$PlayGameReturnTime[4076] = $XZL_ClearTime_Never[1];//���ͼ��� 1105��ͼ ��6������
	$PlayGameReturnTime[4077] = $XZL_ClearTime_Never[1];//���ͼ��� 1105��ͼ ��7������
	$PlayGameReturnTime[4078] = $XZL_ClearTime_Never[1];//���ͼ��� 1105��ͼ ��8������
	$PlayGameReturnTime[4079] = $XZL_ClearTime_Never[1];//���ͼ��� 1105��ͼ ��9������
	$PlayGameReturnTime[4080] = $XZL_ClearTime_Never[1];//���ͼ��� 1106��ͼ ��0������
	$PlayGameReturnTime[4081] = $XZL_ClearTime_Never[1];//���ͼ��� 1106��ͼ ��1������
	$PlayGameReturnTime[4082] = $XZL_ClearTime_Never[1];//���ͼ��� 1106��ͼ ��2������
	$PlayGameReturnTime[4083] = $XZL_ClearTime_Never[1];//���ͼ��� 1106��ͼ ��3������
	$PlayGameReturnTime[4084] = $XZL_ClearTime_Never[1];//���ͼ��� 1106��ͼ ��4������
	$PlayGameReturnTime[4085] = $XZL_ClearTime_Never[1];//���ͼ��� 1106��ͼ ��5������
	$PlayGameReturnTime[4086] = $XZL_ClearTime_Never[1];//���ͼ��� 1106��ͼ ��6������
	$PlayGameReturnTime[4087] = $XZL_ClearTime_Never[1];//���ͼ��� 1106��ͼ ��7������
	$PlayGameReturnTime[4088] = $XZL_ClearTime_Never[1];//���ͼ��� 1106��ͼ ��8������
	$PlayGameReturnTime[4089] = $XZL_ClearTime_Never[1];//���ͼ��� 1106��ͼ ��9������

	$PlayGameReturnTime[4090] = $XZL_ClearTime_Tomorrow[1];//���ͼ��� 0λ �Ѿ�ʹ�����ˢ�µĴ��� 1λ ʹ�õ���ˢ�µĴ���
	$PlayGameReturnTime[4091] = $XZL_ClearTime_Tomorrow[1];//�ǻ�ˢ�¼�¼ 0λ ��ǰ�ǻ꼶�� 1λ ������ʷ��߼���
	$PlayGameReturnTime[4092] = $XZL_ClearTime_Tomorrow[1];//���ͼ���  0λ ������ɴ��� 1λ ������ɵ����Ʒ������
	$PlayGameReturnTime[4093] = $XZL_ClearTime_Tomorrow[1];//�ƽ𱦲�  0λ ���ս��븱������ 1λ���һ�δ��˵ͼ���
	$PlayGameReturnTime[4094] = $XZL_ClearTime_Never[1];//��������  0λ ��¼�ϴβμ�ս����ʱ�� 1λ ��¼�ϴ�ս��������
	$PlayGameReturnTime[4095] = $XZL_ClearTime_Tomorrow[1];//��¼ÿ�ճ�ֵ 0λ bit������ȡ��Щ��� 1λ �����ֵ����
	$PlayGameReturnTime[4096] = $XZL_ClearTime_Tomorrow[1];//ʱ�к���
	$PlayGameReturnTime[4097] = $XZL_ClearTime_Never[1];//��¼�׳���� 0λ 1��ȡ0û����ȡ 1λ ��ǰ��ֵ���
	$PlayGameReturnTime[4098] = $XZL_ClearTime_Tomorrow[1];//��¼���Ǵ��� 0λ ���ս�ȡ����
	$PlayGameReturnTime[4099] = $XZL_ClearTime_Tomorrow[1];//��¼Ȥζ�����˫������ʹ�ô���
	$PlayGameReturnTime[4100] = $XZL_ClearTime_week[1];//��¼ÿ�����а�ƺŽ���
	$PlayGameReturnTime[4101] = $XZL_ClearTime_Tomorrow[1];//��¼Ȥζ����Ĵ������

	$PlayGameReturnTime[4102] = $XZL_ClearTime_Tomorrow[1];//���ɻ	�����칬��¼
	$PlayGameReturnTime[4103] = $XZL_ClearTime_Tomorrow[1];//���ɻ	�����ؾ���¼
	$PlayGameReturnTime[4104] = $XZL_ClearTime_week[1];//���ɻ	����������¼
		 
	$PlayGameReturnTime[4105] = $XZL_ClearTime_Never[1];//ս��
	$PlayGameReturnTime[4106] = $XZL_ClearTime_Never[1];//����
	$PlayGameReturnTime[4107] = $XZL_ClearTime_Never[1];//����
	$PlayGameReturnTime[4108] = $XZL_ClearTime_Never[1];//����
	$PlayGameReturnTime[4109] = $XZL_ClearTime_Never[1];//����
	$PlayGameReturnTime[4110] = $XZL_ClearTime_Never[1];//������
	$PlayGameReturnTime[4111] = $XZL_ClearTime_Never[1];//�׻�կ
	$PlayGameReturnTime[4112] = $XZL_ClearTime_Never[1];//���ƶ�
	$PlayGameReturnTime[4113] = $XZL_ClearTime_Never[1];//�������
	$PlayGameReturnTime[4114] = $XZL_ClearTime_Never[1];//�㺣����
	$PlayGameReturnTime[4115] = $XZL_ClearTime_Never[1];//���ط���
	$PlayGameReturnTime[4116] = $XZL_ClearTime_Never[1];//�Ĳ�
	$PlayGameReturnTime[4117] = $XZL_ClearTime_Never[1];//����
	$PlayGameReturnTime[4118] = $XZL_ClearTime_Never[1];//ʦͽ
	$PlayGameReturnTime[4119] = $XZL_ClearTime_Never[1];//�ʻ�
	$PlayGameReturnTime[4120] = $XZL_ClearTime_Never[1];//��Ҷ
	$PlayGameReturnTime[4121] = $XZL_ClearTime_Never[1];//����
	$PlayGameReturnTime[4122] = $XZL_ClearTime_Never[1];//��ս����
	
	$PlayGameReturnTime[4123] = $XZL_ClearTime_Never[1];//������Ȩ
	$PlayGameReturnTime[4124] = $XZL_ClearTime_Never[1];//��������
	//4124 ~ 4129 ���ã�xxxx��Ȩ  �����������4130��ʼ
	$PlayGameReturnTime[4128] = $XZL_ClearTime_week[1];		 //������������¼ÿһ�����ȡ״̬14
	$PlayGameReturnTime[4129] = $XZL_ClearTime_Tomorrow[1];//������������¼ÿһ�����ȡ״̬1-13
	
	//����5���ֵ�ͺ���
	$PlayGameReturnTime[4130] = $XZL_ClearTime_Tomorrow[1];	//0ÿ����ȡԪ������
	$PlayGameReturnTime[4131] = $XZL_ClearTime_Never[1];		//0�Ƿ������ȡ��������0-7λ��,1��ʾ�Ƿ�����ȡ��������0-7λ��
	
	//�ҵ�����������
	$PlayGameReturnTime[4132] = $XZL_ClearTime_Tomorrow[1];	//ʱװ��0�����1�ؼ�
	$PlayGameReturnTime[4133] = $XZL_ClearTime_Tomorrow[1];	//���0�����1�ؼ�
	
	//�������
	$PlayGameReturnTime[4134] = $XZL_ClearTime_Tomorrow[1];	//�Ƿ��Ѿ���ȡ����
	
	$PlayGameReturnTime[4135] = $XZL_ClearTime_Never[1];	//���ɹ���
	
	//�������
	$PlayGameReturnTime[4136] = $XZL_ClearTime_Never[1];	//�Ƿ��Ѿ���������������
	
	
	
	//��ʱ����4200~4299
	$PlayGameReturnTime[4200] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4201] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4202] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4203] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4204] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4205] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4206] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4207] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4208] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4209] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4210] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4211] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4212] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4213] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4214] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4215] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4216] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4217] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4218] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4219] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4220] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4221] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4222] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4223] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4224] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4225] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4226] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4227] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4228] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4229] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	$PlayGameReturnTime[4230] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	//4200~4299
	$PlayGameReturnTime[4299] = $XZL_ClearTime_Never[1];	//ÿ����Ʒ���޹�����
	
	$PlayGameReturnTime[4300] = $XZL_ClearTime_Tomorrow[1];	//����ʹ�ô���
	
	
	//-----------10000~19999 ��Ÿ��̳����ˣ���¼�������----------------
}

//������������������ʱ�����ֵ�б������������������������������������������

//����������������ȡ0��24Сʱ���ʱ�����������������������������������������
function GetNeedTime(%NeedTime,%YY,%MM,%DD,%H)//��ȡ����Сʱ���ʱ��,��ȷ��Сʱ
{

	//��ȡ�����Ƿ�Ϊ����
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
	//------------����ʱ��-----------
	%H = %H + %NeedTime;
	if (%H >= 24)
	{
		%H = %H - 24;
		%DD++;
		if (%DD > %Mon[%MM])
		{
			%DD = "01";
			%MM++;
			if (%MM > 12)
			{
				%MM = "01";
				%YY++;
			}
		}
	}
	//��������λ�Ĳ�����λ
	%Year = GetSubStr(%YY,2,2);
	if (strlen(%MM) == 1)%MM = "0" @ %MM;
	if (strlen(%DD) == 1)%DD = "0" @ %DD;
	if (strlen(%H) == 1)%H = "0" @ %H;
	//echo( "Time===" @ %Year @ %MM @ %DD @ %H @ "00" );
	return %Year @ %MM @ %DD @ %H @ "00";
}
//����������������ȡ0��24Сʱ���ʱ�����������������������������������������
