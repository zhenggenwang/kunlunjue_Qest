//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//��Ӫ��ڿͻ��˵Ĵ���
//==================================================================================

//�����������������á������������濪�����á���������������
//������������Ӫ���������������ظ��¡���������������
//������������Ӫ�������������ϸ����ݡ���������������


//�����������������á������������濪�����á���������������
function GetAllWndNeedOpen(%Text)
{
	//echo("���濪�����ø���   ==" @ %text);
	$WndNeedOpen = %Text;
	$KLJRankVisibleSign = GetWord(%text,0);
	$SL_HuoDongDaQuan_bActive = GetWord(%text,1);
	$SL_TeHuiShangCheng_bActive = GetWord(%text,2);
	$SL_PaiHangBang_bActive = GetWord(%text,3);
	$SL_JuBaoPeng_bActive = GetWord(%text,4);
	$SL_ZhuanShiJiao_bActive = GetWord(%text,5);
	$SL_ChongZhi_bActive = GetWord(%text,6);
	$SL_LingMai_bActive = GetWord(%text,7);
	$SL_LingJiang_bActive = GetWord(%text,8);
	$SL_GongLue_bActive = GetWord(%text,9);
	$SL_ChengJiu_bActive = GetWord(%text,10);
	$SL_HuoYue_bActive = GetWord(%text,11);

	$BirdShopWndBtnLevel = 25;//�̳Ǵ򿪵ȼ�
	$SL_HuoDongDaQuanLevel = 20;//���ȫ�򿪵ȼ�
	$SL_TeHuiShangChengLevel = 25;//�ػ��̳Ǵ򿪵ȼ�
	$SL_PaiHangBangLevel = 30;//���а�ť�򿪵ȼ�
	$SL_JuBaoPengLevel = 40;//�ٱ��谴ť�򿪵ȼ�
	$SL_ZhuanShiJiaoLevel = 1;//ת�ӽǰ�ť�򿪵ȼ�
	$SL_ChongZhiLevel = 15;//��ֵ��ť�򿪵ȼ�
	$SL_LingMaiLevel = 40;//������ť�򿪵ȼ�
	$SL_LingJiangLevel = 10;//�콱��ť�򿪵ȼ�
	$SL_GongLueLevel = 29;//���԰�ť�򿪵ȼ�
	$SL_ChengJiuLevel = 35;//�ɾͰ�ť�򿪵ȼ�
	$SL_HuoYueLevel = 37;//��Ծ�Ȱ�ť�򿪵ȼ�
	$SL_TeQuanLevel = 32;//��Ȩ��ť�򿪵ȼ�
	$SL_XinfFuXianGouLevel = 30;//�·��޹�����ȼ�  ʱ�����
	$SL_LianXuChongZhiLevel = 30;//������ֵ�򿪵ȼ�
	$SL_JiJinLevel = 30;//����ť�򿪵ȼ�
	$SL_XianShiQiangGou = 30;	//��ʱ�������ŵȼ�
	$SL_XianYuanJieQianLevel = 30;//��Ե��ǩ���ŵȼ�
	$SL_QuannMinDuoBaoLevel = 30;//ȫ��ᱦ���ŵȼ�
	$SL_QiYuanHaoLiLevel = 30;//��Ը���񿪷ŵȼ�

	%Level = GetPlayer().GetLevel();
	if (%Level >= $BirdShopWndBtnLevel)
		BirdShopWndBtn.setvisible(1);
	else
		BirdShopWndBtn.setvisible(0);

	$SL_HuoDongDaQuan_bActive = (%Level >= $SL_HuoDongDaQuanLevel) ? $SL_HuoDongDaQuan_bActive * 1 : 0;
	$SL_TeHuiShangCheng_bActive = (%Level >= $SL_TeHuiShangChengLevel) ? $SL_TeHuiShangCheng_bActive * 1 : 0;
	$SL_PaiHangBang_bActive = (%Level >= $SL_PaiHangBangLevel) ? $SL_PaiHangBang_bActive * 1 : 0;
	$SL_JuBaoPeng_bActive = (%Level >= $SL_JuBaoPengLevel) ? $SL_JuBaoPeng_bActive * 1 : 0;
	$SL_ZhuanShiJiao_bActive = (%Level >= $SL_ZhuanShiJiaoLevel) ? $SL_ZhuanShiJiao_bActive * 1 : 0;
	$SL_ChongZhi_bActive = (%Level >= $SL_ChongZhiLevel) ? $SL_ChongZhi_bActive * 1 : 0;
	$SL_LingMai_bActive = (%Level >= $SL_LingMaiLevel) ? $SL_LingMai_bActive * 1 : 0;
	$SL_LingJiang_bActive = (%Level >= $SL_LingJiangLevel) ? $SL_LingJiang_bActive * 1 : 0;
	$SL_GongLue_bActive = (%Level >= $SL_GongLueLevel) ? $SL_GongLue_bActive * 1 : 0;
	$SL_ChengJiu_bActive = (%Level >= $SL_ChengJiuLevel) ? $SL_ChengJiu_bActive * 1 : 0;
	$SL_HuoYue_bActive = (%Level >= $SL_HuoYueLevel) ? $SL_HuoYue_bActive * 1 : 0;

	BirdSuiTangButton1.setvisible($SL_HuoDongDaQuan_bActive);
	BirdPrefButton.setvisible($SL_TeHuiShangCheng_bActive);
	BirdGradeButton.setvisible($SL_PaiHangBang_bActive);
	CornucopiaWndBtn.setvisible($SL_JuBaoPeng_bActive);
	BirdTranferWndBtn.setvisible($SL_ZhuanShiJiao_bActive);
	ChargeWndBtn.setvisible($SL_ChongZhi_bActive);
	LingMaiWndBtn.setvisible($SL_LingMai_bActive);
	LingJiangWndBtn.setvisible($SL_LingJiang_bActive);
	StrategyWndBtn.setvisible($SL_GongLue_bActive);
	ChengJiuWndBtn.setvisible($SL_ChengJiu_bActive);

	Schedule(1000, 0, "SetMainHuoDongBtnPosition");
}

function SetMainHuoDongBtnPosition()
{
	%BtnName[1] = "BirdSuiTangButton1";
	%BtnName[2] = "BirdPrefButton";
	%BtnName[3] = "BirdGradeButton";
	%BtnName[4] = "CornucopiaWndBtn";
	%BtnName[5] = "BirdTranferWndBtn";
	%BtnName[6] = "ChargeWndBtn";
	%BtnName[7] = "LingMaiWndBtn";
	%BtnName[8] = "LingJiangWndBtn";
	%BtnName[9] = "StrategyWndBtn";
	%BtnName[10] = "ChengJiuWndBtn";

	%Pos_X[0] = 27;
	%Pos_X[1] = 75;
	%Pos_X[2] = 122;
	%Pos_X[3] = 172;
	%Pos_X[4] = 220;

	%Pos_Y[0] = 229;
	%Pos_Y[1] = 275;
	%Pos_Y[2] = 321;

	%PosId = 0;
	for (%i = 1;%i <= 99;%i++)
	{
		if (%BtnName[%i] $= "")
			break;
		eval("%bActive = %BtnName[" @ %i @ "].isvisible();");
		if (%bActive == 1)
		{
			%X = %Pos_X[%PosId%5];
			%Y = %Pos_Y[mfloor(%PosId/5)];
			//echo(%bActive @ " " @ %X @ "   " @ %Y);

			eval("%BtnName[" @ %i @ "].Setposition(" @ %X @ "," @ %Y @ ");");
			%PosId++;
		}
	}
}

//�����������������á������������濪�����á���������������

//������������Ӫ���������������ظ��¡���������������
function SetAllYunYingbActive()
{
	$YunYingbActiveText = $SL_YunYingHuoDong1 @ $SL_YunYingHuoDong2;
	GetAllYunYingbActive($YunYingbActiveText);
	//echo("$YunYingbActiveText ===" @ $YunYingbActiveText);
}
function GetAllYunYingbActive(%text)
{
	%Player = GetPlayer();
	putout("��Ӫ�����ظ���   " @ %text);
	$CurrentLineId = GetWord(%text,0,";");
	%Level = GetPlayer().GetLevel();
	//-------��ȡԪ��˫�����ַ���---------
	$SL_ChongZhiFanKui_State_bActive = GetWord(GetWord(%text,1,";"),0);
	$SL_ChongZhiFanKui_StartTime = GetWord(GetWord(%text,1,";"),1);
	$SL_ChongZhiFanKui_EndTime = GetWord(GetWord(%text,1,";"),2);
	//echo("$SL_ChongZhiFanKui_State_bActive ==" @ $SL_ChongZhiFanKui_State_bActive);
	//echo("$SL_ChongZhiFanKui_StartTime ==" @ $SL_ChongZhiFanKui_StartTime);
	//echo("$SL_ChongZhiFanKui_EndTime ==" @ $SL_ChongZhiFanKui_EndTime);
	//-------���ճ��---------
	$SL_BangShangYouMing_State_bActive = GetWord(GetWord(%text,2,";"),0);
	$SL_BangShangYouMing_StartTime = GetWord(GetWord(%text,2,";"),1);
	$SL_BangShangYouMing_EndTime = GetWord(GetWord(%text,2,";"),2);
	//echo("$SL_BangShangYouMing_State_bActive ==" @ $SL_BangShangYouMing_State_bActive);
	//-------���г�״Ԫ---------
	$SL_HangHangChuZhuangYuan_State_bActive = GetWord(GetWord(%text,3,";"),0);
	$SL_HangHangChuZhuangYuan_StartTime = GetWord(GetWord(%text,3,";"),1);
	$SL_HangHangChuZhuangYuan_EndTime = GetWord(GetWord(%text,3,";"),2);
	//echo("$SL_HangHangChuZhuangYuan_State_bActive ==" @ $SL_HangHangChuZhuangYuan_State_bActive);
	//-------��ͯ����---------
	$SL_XianTongJiangLin_State_bActive = GetWord(GetWord(%text,4,";"),0);
	$SL_XianTongJiangLin_StartTime = GetWord(GetWord(%text,4,";"),1);
	$SL_XianTongJiangLin_EndTime = GetWord(GetWord(%text,4,";"),2);
	//echo("$SL_XianTongJiangLin_State_bActive ==" @ $SL_XianTongJiangLin_State_bActive);
	//-------��ע΢��---------
	$SL_CareWeiBo_State_bActive = GetWord(GetWord(%text,5,";"),0);
	$SL_CareWeiBo_StartTime = GetWord(GetWord(%text,5,";"),1);
	$SL_CareWeiBo_EndTime = GetWord(GetWord(%text,5,";"),2);
	//echo("$SL_CareWeiBo_State_bActive ==" @ $SL_CareWeiBo_State_bActive);
	//-------�������---------
	$SL_ManYueQingDian_State_bActive = GetWord(GetWord(%text,6,";"),0);
	$SL_ManYueQingDian_StartTime = GetWord(GetWord(%text,6,";"),1);
	$SL_ManYueQingDian_EndTime = GetWord(GetWord(%text,6,";"),2);
	//echo("$SL_ManYueQingDian_State_bActive ==" @ $SL_ManYueQingDian_State_bActive);
	//-------��Ը����---------
	$SL_QiYuanHaoLi_State_bActive = GetWord(GetWord(%text,7,";"),0);
	$SL_QiYuanHaoLi_StartTime = GetWord(GetWord(%text,7,";"),1);
	$SL_QiYuanHaoLi_EndTime = GetWord(GetWord(%text,7,";"),2);
	$SL_QiYuanHaoLi_State_bActive = (%Level >= $SL_QiYuanHaoLiLevel) ? $SL_QiYuanHaoLi_State_bActive * 1 : 0;
	//echo("$SL_QiYuanHaoLi_State_bActive ==" @ $SL_QiYuanHaoLi_State_bActive);
	//---------��Ե��ǩ---------
	$SL_LiShangWangLai_State_bActive = GetWord(GetWord(%text,8,";"),0);
	$SL_LiShangWangLai_StartTime = GetWord(GetWord(%text,8,";"),1);
	$SL_LiShangWangLai_EndTime = GetWord(GetWord(%text,8,";"),2);
	//echo("$SL_LiShangWangLai_State_bActive ==" @ $SL_LiShangWangLai_State_bActive);
	$SL_LiShangWangLai_State_bActive = (%Level >= $SL_XianYuanJieQianLevel) ? $SL_LiShangWangLai_State_bActive * 1 : 0;
	//---------ȫ��ᱦ---------
	$SL_QuanMinDuoBao_State_bActive = GetWord(GetWord(%text,9,";"),0);
	$SL_QuanMinDuoBao_StartTime = GetWord(GetWord(%text,9,";"),1);
	$SL_QuanMinDuoBao_EndTime = GetWord(GetWord(%text,9,";"),2);
	$SL_QuanMinDuoBao_State_bActive = (%Level >= $SL_QuannMinDuoBaoLevel) ? $SL_QuanMinDuoBao_State_bActive * 1 : 0;
	//echo("$SL_QuanMinDuoBao_State_bActive ==" @ $SL_QuanMinDuoBao_State_bActive);


	//---------�������-----------
	$SL_QiTianHaoLi_State_bActive = GetWord(%text,10,";");
	if ($SL_QiTianHaoLi_State_bActive == 1)
	{
		%Act0 = GetAct(GetPlayer(),4021,0);
		%NowDays =  Get2K_To_Day(GetWord(GetLocalTime(),0) * 10000 +  GetWord(GetLocalTime(),1) * 100 + GetWord(GetLocalTime(),2));
		if (%NowDays - %Act0 > 6)
			$SL_QiTianHaoLi_State_bActive = 0;
		else
			$SL_QiTianHaoLi_State_bActive = 1;
	}
	$SL_QiTianHaoLi_State_bActive = (%Level >= 10) ? $SL_QiTianHaoLi_State_bActive * 1 : 0;
	//---------ǩ��---------------
	$SL_QianDao_State_bActive = GetWord(%text,11,";");
	if ($SL_QianDao_State_bActive == 1)
	{
		%Day = getword(GetLocalTime(),2);
		if (GetQiandaoRecord(GetPlayer(),%Day) == 1)
			$SL_QianDao_State_bActive = 0;
		else
			$SL_QianDao_State_bActive = 1;
	}
	$SL_QianDao_State_bActive = (%Level >= $SL_LingJiangLevel) ? $SL_QianDao_State_bActive * 1 : 0;
	//echo("$SL_QianDao_State_bActive ===" @ $SL_QianDao_State_bActive);
	//-------------��Ȩ--------------
	$SL_TeQuan_State_bActive = GetWord(%text, 12, ";");
	
	$SL_TeQuan_State_bActive = (%Level >= $SL_TeQuanLevel) ? $SL_TeQuan_State_bActive * 1 : 0;

	//--------������ֵ------
	$SL_LianXuChongZhi_State_bActive = GetWord(GetWord(%text, 13, ";"), 0);
	$SL_LianXuChongZhi_StartTime = GetWord(GetWord(%text, 13, ";"), 1);
	$SL_LianXuChongZhi_EndTime = GetWord(GetWord(%text, 13, ";"), 2);

	//echo("$SL_LianXuChongZhi_StartTime ==" @ $SL_LianXuChongZhi_StartTime);
	//echo("$SL_LianXuChongZhi_EndTime ==" @ $SL_LianXuChongZhi_EndTime);
	$Recharge7Days_Date[1] = GetWord($SL_LianXuChongZhi_StartTime, 1, ".") @ "/" @ GetWord($SL_LianXuChongZhi_StartTime, 2, ".");
	$Recharge7Days_Date[2] = GetWord($SL_LianXuChongZhi_EndTime, 1, ".") @ "/" @ GetWord($SL_LianXuChongZhi_EndTime, 2, ".");
	//echo("$Recharge7Days_Date[1] ==" @ $Recharge7Days_Date[1]);
	//echo("$Recharge7Days_Date[2] ==" @ $Recharge7Days_Date[2]);
	$SL_LianXuChongZhi_State_bActive = (%Level >= $SL_LianXuChongZhiLevel) ? $SL_LianXuChongZhi_State_bActive * 1 : 0;

	//--------��ʱ���------
	$SL_XianShiLiBao_State_bActive = GetWord(GetWord(%text, 14, ";"), 0);
	$SL_XianShiLiBao_StartTime = GetWord(GetWord(%text, 14, ";"), 1);
	$SL_XianShiLiBao_EndTime = GetWord(GetWord(%text, 14, ";"), 2);

	$SL_XianShiLiBao_State_bActive = (%Level >= $SL_XinfFuXianGouLevel) ? $SL_XianShiLiBao_State_bActive * 1 : 0;

	//--------�������------
	$SL_YouXiangJiJin_State_bActive = GetWord(GetWord(%text, 15, ";"), 0);
	$SL_YouXiangJiJin_StartTime = GetWord(GetWord(%text, 15, ";"), 1);
	$SL_YouXiangJiJin_EndTime = GetWord(GetWord(%text, 15, ";"), 2);

	$SL_YouXiangJiJin_State_bActive = (%Level >= $SL_JiJinLevel) ? $SL_YouXiangJiJin_State_bActive * 1 : 0;
	if (getplayer().isVip(2) > 0)
		$SL_YouXiangJiJin_State_bActive = 1;
	//--------��������------
	$SL_XianShiQiangGou_State_bActive = GetWord(GetWord(%text, 16, ";"), 0);
	$SL_XianShiQiangGou_StartTime = GetWord(GetWord(%text, 16, ";"), 1);
	$SL_XianShiQiangGou_EndTime = GetWord(GetWord(%text, 16, ";"), 2);
	$SL_XianShiQiangGou_FreshTime[1] = GetWord(GetWord(%text, 16, ";"), 3);
	$SL_XianShiQiangGou_FreshItem[1] = GetWord(GetWord(%text, 16, ";"), 4);

	$SL_XianShiQiangGou_State_bActive = (%Level >= $SL_XianShiQiangGou) ? $SL_XianShiQiangGou_State_bActive * 1 : 0;
	
	
	
	//----------------------------------------------------
	KLJActivityMainThumXF_Wnd_0.setvisible($SL_CareWeiBo_State_bActive);  //��ע����
	KLJActivityMainThumXF_Wnd_1.setvisible($SL_XianTongJiangLin_State_bActive);  //��ͯ����
	KLJActivityMainThumXF_Wnd_2.setvisible($SL_BangShangYouMing_State_bActive);  //���ճ��


	KLJActivityMainThumBtn_2.setvisible($SL_QuanMinDuoBao_State_bActive);  //ȫ��ᱦ
	if ($KLJActivityMainThumBtn_2_Effects != 1)
		KLJActivityMainThumBtn_2_Effects.setvisible(1);

	KLJActivityMainThumXF_Wnd_3.setvisible($SL_HangHangChuZhuangYuan_State_bActive);  //���г�״Ԫ
	KLJActivityMainThumXF_Wnd_4.setvisible($SL_ManYueQingDian_State_bActive);  //�������
	if ($SL_ChongZhiFanKui_State_bActive != -1)
		KLJActivityMainThumFL_Wnd_0.setvisible(1);  //���ֺ���
	else
		KLJActivityMainThumFL_Wnd_0.setvisible(0);  //���ֺ���
	KLJActivityMainThumBtn_3.setvisible($SL_QiYuanHaoLi_State_bActive);  //��Ը����
	if ($KLJActivityMainThumBtn_3_Effects != 1)
		KLJActivityMainThumBtn_3_Effects.setvisible(1);

	KLJActivityMainThumBtn_4.setvisible($SL_LiShangWangLai_State_bActive);  //��Ե��ǩ���水ť
	if ($KLJActivityMainThumBtn_4_Effects != 1)
		KLJActivityMainThumBtn_4_Effects.setvisible(1);


	KLJActivityMainThumFL_Wnd_1.setvisible($SL_QiTianHaoLi_State_bActive);  //��¼7�����
	for (%i = 1; %i <= 7; %i++) //�������
	{
		if (("UpLineQiTianHaoLiButon_" @ %i).isActive())
		{
			KLJActivityMainThumFL_Wnd_1_Effects.setvisible($SL_QiTianHaoLi_State_bActive);
			break;
		}
	}
	

	KLJActivityMainThumFL_Wnd_2.setvisible($SL_QianDao_State_bActive);  //ǩ��
	KLJActivityMainThumFL_Wnd_2_Effects.setvisible($SL_QianDao_State_bActive);

	KLJActivityMainThumFL_Wnd_3.setvisible($SL_YouXiangJiJin_State_bActive);//����ť
	if ($KLJActivityMainThumFL_Wnd_3_Effects != 1 && ( getYouXiangJiJinButtenState(%Player, 1) == 0 || getYouXiangJiJinButtenState(%Player, 2) == 0 ))
	{
		$KLJActivityMainThumFL_Wnd_3_Effects = 1;
		KLJActivityMainThumFL_Wnd_3_Effects.setvisible($SL_YouXiangJiJin_State_bActive); //����ť��Ч
	}
	
	KLJActivityMainThumBtn_5.setvisible($SL_TeQuan_State_bActive);  //��Ȩ
	//KLJActivityMainThumBtn_5_Effects.setvisible($SL_TeQuan_State_bActive);
	
	if(getRecharge7DaysNowWhichDay() >= 0 && getRecharge7DaysNowWhichDay() <= 6 && $SL_LianXuChongZhi_State_bActive)
		KLJActivityMainThumXF_Wnd_5.setvisible($SL_LianXuChongZhi_State_bActive);  //������ֵ
	else KLJActivityMainThumXF_Wnd_5.setvisible(0);  //������ֵ
	
	if ($KLJActivityMainThumXF_Wnd_5_Effects != 1 && $SL_LianXuChongZhi_State_bActive > 0)
	{
		KLJActivityMainThumXF_Wnd_5_Effects.setvisible($SL_LianXuChongZhi_State_bActive);
		$KLJActivityMainThumXF_Wnd_5_Effects = 1;
	}
	

	KLJActivityMainThumXF_Wnd_6.setvisible($SL_XianShiLiBao_State_bActive);  //��ʱ���
	if ($KLJActivityMainThumXF_Wnd_6_Effects != 1 && $SL_XianShiLiBao_State_bActive > 0)//��ʱ�����Ч
	{
		if (getMyAppearanceButtenState(%Player, 110) == 0 || getMyAppearanceButtenState(%Player, 120) == 0 || getMyAppearanceButtenState(%Player, 210) == 0 || getMyAppearanceButtenState(%Player, 220) == 0)
		{
			KLJActivityMainThumXF_Wnd_6_Effects.setvisible($SL_XianShiLiBao_State_bActive);//
			$KLJActivityMainThumXF_Wnd_6_Effects = 1;
		}
	}

	//---------------------ˢ��[�·�]��ť����Ч----------------------
	if (!KLJActivityMainThumBtn_1.isvisible() && (KLJActivityMainThumXF_Wnd_5_Effects.isvisible() || KLJActivityMainThumXF_Wnd_6_Effects.isvisible()))
	{
		KLJActivityMainThumBtn_1_Effects.setvisible(1);
		
	}
	else
		KLJActivityMainThumBtn_1_Effects.setvisible(0);
	//---------------------ˢ��[����]��ť����Ч----------------------
	if (KLJActivityMainThumBtn_0.isvisible() && (KLJActivityMainThumFL_Wnd_2_Effects.isvisible() || KLJActivityMainThumFL_Wnd_3_Effects.isvisible()))
		KLJActivityMainThumBtn_0_Effects.setvisible(1);
	else
		KLJActivityMainThumBtn_0_Effects.setvisible(0);


	refreshFollowActivityMainThumBtn();

	IshidePointsActivityButton($SL_ChongZhiFanKui_State_bActive);//ˢ�³�ֵ������Ľ���
	//����ʱʱ���ڲ����ظ�ˢ��
	$AskForNewYunYingbActive = 1;
	Schedule(60000,0,"DeleteForNewYunYingbActive");
}
function AskForNewYunYingbActive()//�������������������
{
	if ($AskForNewYunYingbActive == 1)
		return false;
	ClientOnSptAction(36,0);//ͨѶ�����
	$AskForNewYunYingbActive = 1;
	Schedule(60000,0,"DeleteForNewYunYingbActive");
}
function DeleteForNewYunYingbActive()
{
	$AskForNewYunYingbActive = 0;
}
//������������Ӫ���������������ظ��¡���������������


//������������Ӫ�������������ϸ����ݡ���������������
//������������Ӫ�������������ϸ����ݡ���������������
