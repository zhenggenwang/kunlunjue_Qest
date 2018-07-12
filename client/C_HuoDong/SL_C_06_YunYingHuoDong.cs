//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//运营活动在客户端的处理
//==================================================================================

//■■■■【开关配置】■■■■界面开关配置■■■■■■■■
//■■■■【运营活动】■■■■活动开关更新■■■■■■■■
//■■■■【运营活动】■■■■详细活动内容■■■■■■■■


//■■■■【开关配置】■■■■界面开关配置■■■■■■■■
function GetAllWndNeedOpen(%Text)
{
	//echo("界面开关配置更新   ==" @ %text);
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

	$BirdShopWndBtnLevel = 25;//商城打开等级
	$SL_HuoDongDaQuanLevel = 20;//活动大全打开等级
	$SL_TeHuiShangChengLevel = 25;//特惠商城打开等级
	$SL_PaiHangBangLevel = 30;//排行榜按钮打开等级
	$SL_JuBaoPengLevel = 40;//举报盆按钮打开等级
	$SL_ZhuanShiJiaoLevel = 1;//转视角按钮打开等级
	$SL_ChongZhiLevel = 15;//充值按钮打开等级
	$SL_LingMaiLevel = 40;//灵脉按钮打开等级
	$SL_LingJiangLevel = 10;//领奖按钮打开等级
	$SL_GongLueLevel = 29;//攻略按钮打开等级
	$SL_ChengJiuLevel = 35;//成就按钮打开等级
	$SL_HuoYueLevel = 37;//活跃度按钮打开等级
	$SL_TeQuanLevel = 32;//特权按钮打开等级
	$SL_XinfFuXianGouLevel = 30;//新服限购礼包等级  时尚礼包
	$SL_LianXuChongZhiLevel = 30;//连续充值打开等级
	$SL_JiJinLevel = 30;//基金按钮打开等级
	$SL_XianShiQiangGou = 30;	//限时抢购开放等级
	$SL_XianYuanJieQianLevel = 30;//仙缘解签开放等级
	$SL_QuannMinDuoBaoLevel = 30;//全民夺宝开放等级
	$SL_QiYuanHaoLiLevel = 30;//祈愿豪礼开放等级

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

//■■■■【开关配置】■■■■界面开关配置■■■■■■■■

//■■■■【运营活动】■■■■活动开关更新■■■■■■■■
function SetAllYunYingbActive()
{
	$YunYingbActiveText = $SL_YunYingHuoDong1 @ $SL_YunYingHuoDong2;
	GetAllYunYingbActive($YunYingbActiveText);
	//echo("$YunYingbActiveText ===" @ $YunYingbActiveText);
}
function GetAllYunYingbActive(%text)
{
	%Player = GetPlayer();
	putout("运营活动活动开关更新   " @ %text);
	$CurrentLineId = GetWord(%text,0,";");
	%Level = GetPlayer().GetLevel();
	//-------提取元宝双倍积分反馈---------
	$SL_ChongZhiFanKui_State_bActive = GetWord(GetWord(%text,1,";"),0);
	$SL_ChongZhiFanKui_StartTime = GetWord(GetWord(%text,1,";"),1);
	$SL_ChongZhiFanKui_EndTime = GetWord(GetWord(%text,1,";"),2);
	//echo("$SL_ChongZhiFanKui_State_bActive ==" @ $SL_ChongZhiFanKui_State_bActive);
	//echo("$SL_ChongZhiFanKui_StartTime ==" @ $SL_ChongZhiFanKui_StartTime);
	//echo("$SL_ChongZhiFanKui_EndTime ==" @ $SL_ChongZhiFanKui_EndTime);
	//-------七日冲榜---------
	$SL_BangShangYouMing_State_bActive = GetWord(GetWord(%text,2,";"),0);
	$SL_BangShangYouMing_StartTime = GetWord(GetWord(%text,2,";"),1);
	$SL_BangShangYouMing_EndTime = GetWord(GetWord(%text,2,";"),2);
	//echo("$SL_BangShangYouMing_State_bActive ==" @ $SL_BangShangYouMing_State_bActive);
	//-------行行出状元---------
	$SL_HangHangChuZhuangYuan_State_bActive = GetWord(GetWord(%text,3,";"),0);
	$SL_HangHangChuZhuangYuan_StartTime = GetWord(GetWord(%text,3,";"),1);
	$SL_HangHangChuZhuangYuan_EndTime = GetWord(GetWord(%text,3,";"),2);
	//echo("$SL_HangHangChuZhuangYuan_State_bActive ==" @ $SL_HangHangChuZhuangYuan_State_bActive);
	//-------仙童降临---------
	$SL_XianTongJiangLin_State_bActive = GetWord(GetWord(%text,4,";"),0);
	$SL_XianTongJiangLin_StartTime = GetWord(GetWord(%text,4,";"),1);
	$SL_XianTongJiangLin_EndTime = GetWord(GetWord(%text,4,";"),2);
	//echo("$SL_XianTongJiangLin_State_bActive ==" @ $SL_XianTongJiangLin_State_bActive);
	//-------关注微博---------
	$SL_CareWeiBo_State_bActive = GetWord(GetWord(%text,5,";"),0);
	$SL_CareWeiBo_StartTime = GetWord(GetWord(%text,5,";"),1);
	$SL_CareWeiBo_EndTime = GetWord(GetWord(%text,5,";"),2);
	//echo("$SL_CareWeiBo_State_bActive ==" @ $SL_CareWeiBo_State_bActive);
	//-------满月庆典---------
	$SL_ManYueQingDian_State_bActive = GetWord(GetWord(%text,6,";"),0);
	$SL_ManYueQingDian_StartTime = GetWord(GetWord(%text,6,";"),1);
	$SL_ManYueQingDian_EndTime = GetWord(GetWord(%text,6,";"),2);
	//echo("$SL_ManYueQingDian_State_bActive ==" @ $SL_ManYueQingDian_State_bActive);
	//-------祈愿豪礼---------
	$SL_QiYuanHaoLi_State_bActive = GetWord(GetWord(%text,7,";"),0);
	$SL_QiYuanHaoLi_StartTime = GetWord(GetWord(%text,7,";"),1);
	$SL_QiYuanHaoLi_EndTime = GetWord(GetWord(%text,7,";"),2);
	$SL_QiYuanHaoLi_State_bActive = (%Level >= $SL_QiYuanHaoLiLevel) ? $SL_QiYuanHaoLi_State_bActive * 1 : 0;
	//echo("$SL_QiYuanHaoLi_State_bActive ==" @ $SL_QiYuanHaoLi_State_bActive);
	//---------仙缘解签---------
	$SL_LiShangWangLai_State_bActive = GetWord(GetWord(%text,8,";"),0);
	$SL_LiShangWangLai_StartTime = GetWord(GetWord(%text,8,";"),1);
	$SL_LiShangWangLai_EndTime = GetWord(GetWord(%text,8,";"),2);
	//echo("$SL_LiShangWangLai_State_bActive ==" @ $SL_LiShangWangLai_State_bActive);
	$SL_LiShangWangLai_State_bActive = (%Level >= $SL_XianYuanJieQianLevel) ? $SL_LiShangWangLai_State_bActive * 1 : 0;
	//---------全民夺宝---------
	$SL_QuanMinDuoBao_State_bActive = GetWord(GetWord(%text,9,";"),0);
	$SL_QuanMinDuoBao_StartTime = GetWord(GetWord(%text,9,";"),1);
	$SL_QuanMinDuoBao_EndTime = GetWord(GetWord(%text,9,";"),2);
	$SL_QuanMinDuoBao_State_bActive = (%Level >= $SL_QuannMinDuoBaoLevel) ? $SL_QuanMinDuoBao_State_bActive * 1 : 0;
	//echo("$SL_QuanMinDuoBao_State_bActive ==" @ $SL_QuanMinDuoBao_State_bActive);


	//---------七天好礼-----------
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
	//---------签到---------------
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
	//-------------特权--------------
	$SL_TeQuan_State_bActive = GetWord(%text, 12, ";");
	
	$SL_TeQuan_State_bActive = (%Level >= $SL_TeQuanLevel) ? $SL_TeQuan_State_bActive * 1 : 0;

	//--------连续充值------
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

	//--------限时礼包------
	$SL_XianShiLiBao_State_bActive = GetWord(GetWord(%text, 14, ";"), 0);
	$SL_XianShiLiBao_StartTime = GetWord(GetWord(%text, 14, ";"), 1);
	$SL_XianShiLiBao_EndTime = GetWord(GetWord(%text, 14, ";"), 2);

	$SL_XianShiLiBao_State_bActive = (%Level >= $SL_XinfFuXianGouLevel) ? $SL_XianShiLiBao_State_bActive * 1 : 0;

	//--------优享基金------
	$SL_YouXiangJiJin_State_bActive = GetWord(GetWord(%text, 15, ";"), 0);
	$SL_YouXiangJiJin_StartTime = GetWord(GetWord(%text, 15, ";"), 1);
	$SL_YouXiangJiJin_EndTime = GetWord(GetWord(%text, 15, ";"), 2);

	$SL_YouXiangJiJin_State_bActive = (%Level >= $SL_JiJinLevel) ? $SL_YouXiangJiJin_State_bActive * 1 : 0;
	if (getplayer().isVip(2) > 0)
		$SL_YouXiangJiJin_State_bActive = 1;
	//--------限制抢购------
	$SL_XianShiQiangGou_State_bActive = GetWord(GetWord(%text, 16, ";"), 0);
	$SL_XianShiQiangGou_StartTime = GetWord(GetWord(%text, 16, ";"), 1);
	$SL_XianShiQiangGou_EndTime = GetWord(GetWord(%text, 16, ";"), 2);
	$SL_XianShiQiangGou_FreshTime[1] = GetWord(GetWord(%text, 16, ";"), 3);
	$SL_XianShiQiangGou_FreshItem[1] = GetWord(GetWord(%text, 16, ";"), 4);

	$SL_XianShiQiangGou_State_bActive = (%Level >= $SL_XianShiQiangGou) ? $SL_XianShiQiangGou_State_bActive * 1 : 0;
	
	
	
	//----------------------------------------------------
	KLJActivityMainThumXF_Wnd_0.setvisible($SL_CareWeiBo_State_bActive);  //关注好礼
	KLJActivityMainThumXF_Wnd_1.setvisible($SL_XianTongJiangLin_State_bActive);  //仙童降临
	KLJActivityMainThumXF_Wnd_2.setvisible($SL_BangShangYouMing_State_bActive);  //七日冲榜


	KLJActivityMainThumBtn_2.setvisible($SL_QuanMinDuoBao_State_bActive);  //全民夺宝
	if ($KLJActivityMainThumBtn_2_Effects != 1)
		KLJActivityMainThumBtn_2_Effects.setvisible(1);

	KLJActivityMainThumXF_Wnd_3.setvisible($SL_HangHangChuZhuangYuan_State_bActive);  //行行出状元
	KLJActivityMainThumXF_Wnd_4.setvisible($SL_ManYueQingDian_State_bActive);  //满月庆典
	if ($SL_ChongZhiFanKui_State_bActive != -1)
		KLJActivityMainThumFL_Wnd_0.setvisible(1);  //积分豪礼
	else
		KLJActivityMainThumFL_Wnd_0.setvisible(0);  //积分豪礼
	KLJActivityMainThumBtn_3.setvisible($SL_QiYuanHaoLi_State_bActive);  //祈愿好礼
	if ($KLJActivityMainThumBtn_3_Effects != 1)
		KLJActivityMainThumBtn_3_Effects.setvisible(1);

	KLJActivityMainThumBtn_4.setvisible($SL_LiShangWangLai_State_bActive);  //仙缘解签界面按钮
	if ($KLJActivityMainThumBtn_4_Effects != 1)
		KLJActivityMainThumBtn_4_Effects.setvisible(1);


	KLJActivityMainThumFL_Wnd_1.setvisible($SL_QiTianHaoLi_State_bActive);  //登录7天豪礼
	for (%i = 1; %i <= 7; %i++) //七天好礼
	{
		if (("UpLineQiTianHaoLiButon_" @ %i).isActive())
		{
			KLJActivityMainThumFL_Wnd_1_Effects.setvisible($SL_QiTianHaoLi_State_bActive);
			break;
		}
	}
	

	KLJActivityMainThumFL_Wnd_2.setvisible($SL_QianDao_State_bActive);  //签到
	KLJActivityMainThumFL_Wnd_2_Effects.setvisible($SL_QianDao_State_bActive);

	KLJActivityMainThumFL_Wnd_3.setvisible($SL_YouXiangJiJin_State_bActive);//基金按钮
	if ($KLJActivityMainThumFL_Wnd_3_Effects != 1 && ( getYouXiangJiJinButtenState(%Player, 1) == 0 || getYouXiangJiJinButtenState(%Player, 2) == 0 ))
	{
		$KLJActivityMainThumFL_Wnd_3_Effects = 1;
		KLJActivityMainThumFL_Wnd_3_Effects.setvisible($SL_YouXiangJiJin_State_bActive); //基金按钮特效
	}
	
	KLJActivityMainThumBtn_5.setvisible($SL_TeQuan_State_bActive);  //特权
	//KLJActivityMainThumBtn_5_Effects.setvisible($SL_TeQuan_State_bActive);
	
	if(getRecharge7DaysNowWhichDay() >= 0 && getRecharge7DaysNowWhichDay() <= 6 && $SL_LianXuChongZhi_State_bActive)
		KLJActivityMainThumXF_Wnd_5.setvisible($SL_LianXuChongZhi_State_bActive);  //连续充值
	else KLJActivityMainThumXF_Wnd_5.setvisible(0);  //连续充值
	
	if ($KLJActivityMainThumXF_Wnd_5_Effects != 1 && $SL_LianXuChongZhi_State_bActive > 0)
	{
		KLJActivityMainThumXF_Wnd_5_Effects.setvisible($SL_LianXuChongZhi_State_bActive);
		$KLJActivityMainThumXF_Wnd_5_Effects = 1;
	}
	

	KLJActivityMainThumXF_Wnd_6.setvisible($SL_XianShiLiBao_State_bActive);  //限时礼包
	if ($KLJActivityMainThumXF_Wnd_6_Effects != 1 && $SL_XianShiLiBao_State_bActive > 0)//限时礼包特效
	{
		if (getMyAppearanceButtenState(%Player, 110) == 0 || getMyAppearanceButtenState(%Player, 120) == 0 || getMyAppearanceButtenState(%Player, 210) == 0 || getMyAppearanceButtenState(%Player, 220) == 0)
		{
			KLJActivityMainThumXF_Wnd_6_Effects.setvisible($SL_XianShiLiBao_State_bActive);//
			$KLJActivityMainThumXF_Wnd_6_Effects = 1;
		}
	}

	//---------------------刷新[新服]按钮的特效----------------------
	if (!KLJActivityMainThumBtn_1.isvisible() && (KLJActivityMainThumXF_Wnd_5_Effects.isvisible() || KLJActivityMainThumXF_Wnd_6_Effects.isvisible()))
	{
		KLJActivityMainThumBtn_1_Effects.setvisible(1);
		
	}
	else
		KLJActivityMainThumBtn_1_Effects.setvisible(0);
	//---------------------刷新[福利]按钮的特效----------------------
	if (KLJActivityMainThumBtn_0.isvisible() && (KLJActivityMainThumFL_Wnd_2_Effects.isvisible() || KLJActivityMainThumFL_Wnd_3_Effects.isvisible()))
		KLJActivityMainThumBtn_0_Effects.setvisible(1);
	else
		KLJActivityMainThumBtn_0_Effects.setvisible(0);


	refreshFollowActivityMainThumBtn();

	IshidePointsActivityButton($SL_ChongZhiFanKui_State_bActive);//刷新充值返利活动的界面
	//倒计时时间内不再重复刷新
	$AskForNewYunYingbActive = 1;
	Schedule(60000,0,"DeleteForNewYunYingbActive");
}
function AskForNewYunYingbActive()//主动发起请求更新配置
{
	if ($AskForNewYunYingbActive == 1)
		return false;
	ClientOnSptAction(36,0);//通讯服务端
	$AskForNewYunYingbActive = 1;
	Schedule(60000,0,"DeleteForNewYunYingbActive");
}
function DeleteForNewYunYingbActive()
{
	$AskForNewYunYingbActive = 0;
}
//■■■■【运营活动】■■■■活动开关更新■■■■■■■■


//■■■■【运营活动】■■■■详细活动内容■■■■■■■■
//■■■■【运营活动】■■■■详细活动内容■■■■■■■■
