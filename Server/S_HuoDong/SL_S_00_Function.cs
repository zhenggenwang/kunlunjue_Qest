//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//活动用脚本，客户端与服务端区分载入
//==================================================================================
//■■■■■■■■■■■加载活动的文件■■■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■常置活动开关计算■■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■运营活动开关计算■■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■所有活动NPC 对话入口■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■其他内容■■■■■■■■■■■■■■■■■■■■■■■■■■■






//■■■■■■■■■■■加载活动的文件■■■■■■■■■■■■■■■■■■■■■■■■
function UPCS_HuoDongFunction(%Num)
{
	if ((%Num==1)||(%Num==99)){ Exec("./SL_S_01_JiaZuGouHuo.cs"); }
	if ((%Num==2)||(%Num==99)){ Exec("./SL_S_02_IceFireTest.cs"); }
	if ((%Num==3)||(%Num==99)){ Exec("./SL_S_03_WaKuang.cs"); }
	if ((%Num==4)||(%Num==99)){ Exec("./SL_S_04_ShiJieBoss.cs"); }
	if ((%Num==5)||(%Num==99)){ Exec("./SL_S_05_CangBaoTu.cs"); }
	if ((%Num==6)||(%Num==99)){ Exec("./SL_S_06_ShiMenJinZong.cs"); }
	if ((%Num==7)||(%Num==99)){ Exec("./SL_S_07_LiShangWangLai.cs"); }
	if ((%Num==8)||(%Num==99)){ Exec("./SL_S_08_MianZhanPai.cs"); }
	if ((%Num==9)||(%Num==99)){ Exec("./SL_S_09_YaBiao.cs"); }
	if ((%Num==10)||(%Num==99)){ Exec("./SL_S_10_QianDao.cs"); }
	if ((%Num==11)||(%Num==99)){ Exec("./SL_S_11_DiaoYu.cs"); }
	if ((%Num==12)||(%Num==99)){ Exec("./SL_S_12_LingJingWuDao.cs"); }
	if ((%Num==13)||(%Num==99)){ Exec("./SL_S_13_ShouZuoLunJing.cs"); }
	if ((%Num==14)||(%Num==99)){ Exec("./SL_S_14_XuanShangJiXiong.cs"); }
	if ((%Num==15)||(%Num==99)){ Exec("./SL_S_15_QuWeiRenWu.cs"); }
	if ((%Num==16)||(%Num==99)){ Exec("./SL_S_16_ZiXingChuanGong.cs"); }
	if ((%Num==17)||(%Num==99)){ Exec("./SL_S_17_XianTongJiangLin.cs"); }
}
UPCS_HuoDongFunction(99);
//■■■■■■■■■■■加载活动的文件■■■■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■常置活动开关计算■■■■■■■■■■■■■■■■■■■■■■■
function Bactive_PlayGame(%YY,%MM,%DD,%H,%M,%S)
{
	%MapID = GetSubStr(GetZoneid(),0,4);
	%TimeNow = %H*60+%M;
	//-------群英汇聚---------
	if ($SL_JiaZuGouHuo_bActive==1)
	{
		%TimeStart = GetWord($SL_JiaZuGouHuo_StartTime,0,":")*60+GetWord($SL_JiaZuGouHuo_StartTime,1,":");
		%TimeEnd = GetWord($SL_JiaZuGouHuo_EndTime,0,":")*60+GetWord($SL_JiaZuGouHuo_EndTime,1,":");
		if (%TimeStart<=%TimeNow && %TimeNow<=%TimeEnd)
			$SL_JiaZuGouHuo_State_bActive = 1;
		else
			$SL_JiaZuGouHuo_State_bActive = 0;
	}
	else
		$SL_JiaZuGouHuo_State_bActive = 0;
	//--------时空裂痕----------
	if ($SL_XuanWuMen_bActive==1)
	{
		%TimeStart = GetWord($SL_XuanWuMen_StartTime,0,":")*60+GetWord($SL_XuanWuMen_StartTime,1,":");
		%TimeEnd = GetWord($SL_XuanWuMen_EndTime,0,":")*60+GetWord($SL_XuanWuMen_EndTime,1,":");
		if (%TimeStart<=%TimeNow && %TimeNow<=%TimeEnd)
			$SL_XuanWuMen_State_bActive = 1;
		else
			$SL_XuanWuMen_State_bActive = 0;
	}
	else
		$SL_XuanWuMen_State_bActive = 0;

	//--------炼魔渊----------
	if ($SL_LianMoYuan_bActive==1)
	{
		%TimeStart = GetWord($SL_LianMoYuan_StartTime,0,":")*60+GetWord($SL_LianMoYuan_StartTime,1,":");
		%TimeEnd = GetWord($SL_LianMoYuan_EndTime,0,":")*60+GetWord($SL_LianMoYuan_EndTime,1,":");
		if (%TimeStart<=%TimeNow && %TimeNow<=%TimeEnd)
			$SL_LianMoYuan_State_bActive = 1;
		else
			$SL_LianMoYuan_State_bActive = 0;
	}
	else
		$SL_LianMoYuan_State_bActive = 0;
	//--------幻境争霸-----------
	if ($SL_HuanJingZhengBa_bActive==1)
	{
		$SL_HuanJingZhengBa_State_bActive = 0;
		%LocalWeek = GetLocalWeek();
		%Count = GetWordCount($SL_HuanJingZhengBa_Week);

		//echo("$SL_HuanJingZhengBa_Week===" @ $SL_HuanJingZhengBa_Week);
		//echo("%LocalWeek===" @ %LocalWeek);
		for (%i = 0; %i < %Count; %i++)
		{
			%OpenWeek = GetWord($SL_HuanJingZhengBa_Week,%i)*1;
			//echo("%OpenWeek===" @ %OpenWeek);
			if (%OpenWeek==%LocalWeek)
			{
				$SL_HuanJingZhengBa_State_bActive = 1;
				break;
			}
		}

		//echo("$SL_HuanJingZhengBa_State_bActive===" @ $SL_HuanJingZhengBa_State_bActive);
		if ($SL_HuanJingZhengBa_State_bActive==1)
		{
			%TimeStart = GetWord($SL_HuanJingZhengBa_StartTime,0,":")*60+GetWord($SL_HuanJingZhengBa_StartTime,1,":");
			%TimeEnd = GetWord($SL_HuanJingZhengBa_EndTime,0,":")*60+GetWord($SL_HuanJingZhengBa_EndTime,1,":");
			if (%TimeStart<=%TimeNow && %TimeNow<=%TimeEnd)
				$SL_HuanJingZhengBa_State_bActive = 1;
			else
				$SL_HuanJingZhengBa_State_bActive = 0;
		}
	}
	else
		$SL_HuanJingZhengBa_State_bActive = 0;

	//-----------世界BOSS--------------
	if ($SL_ShiJieBoss_bActive==1)
		$SL_ShiJieBoss_State_bActive = 1;
	else
		$SL_ShiJieBoss_State_bActive = 0;
	//--------诛妖-----------
	if ($SL_ZhuYao_bActive==1)
		$SL_ZhuYao_State_bActive = 1;
	else
		$SL_ZhuYao_State_bActive = 0;
	//--------藏宝图---------
	if ($SL_CangBaoTu_bActive==1)
		$SL_CangBaoTu_State_bActive = 1;
	else
		$SL_CangBaoTu_State_bActive = 0;
	//--------师门尽忠---------
	if ($SL_ShiMenJinZong_bActive==1)
		$SL_ShiMenJinZong_State_bActive = 1;
	else
		$SL_ShiMenJinZong_State_bActive = 0;
	//--------诛神问心阵---------
	if ($SL_ZhuShenWenXinZhen_bActive==1)
	{
		%Nowtime = %H*60+%M;
		%Starttime = getword($SL_ZhuShenWenXinZhen_StartTime,0,":")*60+getword($SL_ZhuShenWenXinZhen_StartTime,1,":");
		%Endtime = getword($SL_ZhuShenWenXinZhen_EndTime,0,":")*60+getword($SL_ZhuShenWenXinZhen_EndTime,1,":");
		if (%Nowtime>=%Starttime  && %Nowtime<=%Endtime)
			$SL_ZhuShenWenXinZhen_State_bActive = 1;
		else
			$SL_ZhuShenWenXinZhen_State_bActive = 0;
	}
	else
		$SL_ZhuShenWenXinZhen_State_bActive = 0;
	$SL_ZhuShenWenXinZhen_State_bActive = -1;
	//--------鸿蒙试炼---------
	if ($SL_HuanJingZhengBa_bActive==1)
	{
		$SL_YunXianJie_State_bActive = 0;
		%LocalWeek = GetLocalWeek();
		%Count = GetWordCount($SL_YunXianJie_Week);
		for (%i = 0; %i < %Count; %i++)
		{
			%OpenWeek = GetWord($SL_YunXianJie_Week,%i)*1;
			if (%OpenWeek==%LocalWeek)
			{
				$SL_YunXianJie_State_bActive = 1;
				break;
			}
		}
		//echo("$SL_YunXianJie_State_bActive===" @ $SL_YunXianJie_State_bActive);
		if ($SL_YunXianJie_State_bActive==1)
		{
			%TimeStart = GetWord($SL_YunXianJie_StartTime,0,":")*60+GetWord($SL_YunXianJie_StartTime,1,":");
			%TimeEnd = GetWord($SL_YunXianJie_EndTime,0,":")*60+GetWord($SL_YunXianJie_EndTime,1,":");
			if (%TimeStart<=%TimeNow && %TimeNow<=%TimeEnd)
				$SL_YunXianJie_State_bActive = 1;
			else
				$SL_YunXianJie_State_bActive = 0;
		}
	}
	else
		$SL_YunXianJie_State_bActive = 0;
	//---------押镖-----------
	if ($SL_YaBiao_bActive==1)
	{
		%Nowtime = %H*60+%M;
		%Starttime = getword($SL_YaBiao_StartTime,0,":")*60+getword($SL_YaBiao_StartTime,1,":");
		%Endtime = getword($SL_YaBiao_EndTime,0,":")*60+getword($SL_YaBiao_EndTime,1,":");
		if (%Nowtime>=%Starttime  && %Nowtime<=%Endtime)
			$SL_YaBiao_State_bActive = 1;
		else
			$SL_YaBiao_State_bActive = 0;
	}
	else
		$SL_YaBiao_State_bActive = 0;
	//--------钓鱼----------------
	if ($SL_DiaoYu_bActive==1)
	{
		%Nowtime = %H*60+%M;
		%Starttime = getword($SL_DiaoYu_StartTime,0,":")*60+getword($SL_DiaoYu_StartTime,1,":");
		%Endtime = getword($SL_DiaoYu_EndTime,0,":")*60+getword($SL_DiaoYu_EndTime,1,":");
		if (%Nowtime>=%Starttime  && %Nowtime<=%Endtime)
			$SL_DiaoYu_State_bActive = 1;
		else
			$SL_DiaoYu_State_bActive = 0;
	}
	else
		$SL_DiaoYu_State_bActive = 0;
	//--------聆经悟道-------------
	if ($SL_LingJingWuDao_bActive==1)
	{
		%Nowtime = %H*60+%M;
		%Starttime = getword($SL_LingJingWuDao_StartTime,0,":")*60+getword($SL_LingJingWuDao_StartTime,1,":");
		%Endtime = getword($SL_LingJingWuDao_EndTime,0,":")*60+getword($SL_LingJingWuDao_EndTime,1,":");
		if (%NowTime>=%Endtime  && %NowTime<=%Starttime)
			$SL_LingJingWuDao_State_bActive = 0;
		else
			$SL_LingJingWuDao_State_bActive = 1;
	}
	else
		$SL_LingJingWuDao_State_bActive = 1;
	//-------------首座论经-------------------
	if ($SL_ShouZuoLunJing_bActive==1)
	{
		%Nowtime = %H*60+%M;
		%Starttime = getword($SL_ShouZuoLunJing_StartTime,0,":")*60+getword($SL_ShouZuoLunJing_StartTime,1,":");
		%Endtime = getword($SL_ShouZuoLunJing_EndTime,0,":")*60+getword($SL_ShouZuoLunJing_EndTime,1,":");
		if (%Nowtime>=%Starttime  && %Nowtime<=%Endtime)
			$SL_ShouZuoLunJing_State_bActive = 1;
		else
			$SL_ShouZuoLunJing_State_bActive = 0;
	}
	else
		$SL_ShouZuoLunJing_State_bActive = 0;

	//-------------冰火试炼-------------------
	if ($SL_BingHuoShiLian_bActive==1)
		$SL_BingHuoShiLian_State_bActive = 1;
	else
		$SL_BingHuoShiLian_State_bActive = 0;

	//-------------悬赏缉凶-------------------
	if ($SL_XuanShangJiXiong_bActive==1)
		$SL_XuanShangJiXiong_State_bActive = 1;
	else
		$SL_XuanShangJiXiong_State_bActive = 0;
	//-------------血魔封印阵-----------------
	if ($SL_XueMoFenYinZhen_bActive==1)
		$SL_XueMoFenYinZhen_State_bActive = 1;
	else
		$SL_XueMoFenYinZhen_State_bActive = 0;
	//-------------黄金宝藏-----------------
	if ($SL_HuangJingBaoZang_bActive==1)
		$SL_HuangJingBaoZang_State_bActive = 1;
	else
		$SL_HuangJingBaoZang_State_bActive = 0;
	//-------------刀剑神域-----------------
	if ($SL_DaoJianShenYu_bActive==1)
	{
		%Nowtime = %H*60+%M;
		%Starttime = getword($SL_DaoJianShenYu_StartTime,0,":")*60+getword($SL_DaoJianShenYu_StartTime,1,":");
		%Endtime = getword($SL_DaoJianShenYu_EndTime,0,":")*60+getword($SL_DaoJianShenYu_EndTime,1,":");
		if (%Nowtime>=%Starttime  && %Nowtime<=%Endtime)
			$SL_DaoJianShenYu_State_bActive = 1;
		else
			$SL_DaoJianShenYu_State_bActive = 0;
	}
	else
		$SL_DaoJianShenYu_State_bActive = 0;
	//-------------紫星传功-----------------
	if ($SL_ZiXingChuanGong_bActive==1)
		$SL_ZiXingChuanGong_State_bActive = 1;
	else
		$SL_ZiXingChuanGong_State_bActive = 0;
	//-------------镇魔殿-----------------
	if ($SL_ShiMoDian_bActive==1)
		$SL_ShiMoDian_State_bActive = 1;
	else
		$SL_ShiMoDian_State_bActive = 0;
	//-------------云罗镜------------------
	if ($SL_YunLuoJing_bActive==1)
		$SL_YunLuoJing_State_bActive = 1;
	else
		$SL_YunLuoJing_State_bActive = 0;
	//-------------封神秘境------------------
	if ($SL_FengShenMiJing_bActive == 1)
		$SL_FengShenMiJing_State_bActive = 1;
	else
		$SL_FengShenMiJing_State_bActive = 0;


	//-------------把所有活动拼成一个字符串拼成一个字符串-----如果传下去的是 -1 活动大全界面将不会显示----
	$SL_HuoDong_Old = $SL_HuoDong;
	$SL_HuoDong = $SL_JiaZuGouHuo_State_bActive @ " " @ $SL_XuanWuMen_State_bActive @ " " @ $SL_LianMoYuan_State_bActive @ " " @ $SL_HuanJingZhengBa_State_bActive @ " " @ $SL_ShiJieBoss_State_bActive @ " " @ $SL_ZhuYao_State_bActive @ " "
		@ $SL_CangBaoTu_State_bActive @ " " @ $SL_ShiMenJinZong_State_bActive @ " " @ $SL_ZhuShenWenXinZhen_State_bActive @ " " @ $SL_YunXianJie_State_bActive @ " " @ $SL_YaBiao_State_bActive @ " " @ $SL_DiaoYu_State_bActive @ " "
		@ $SL_LingJingWuDao_State_bActive @ " " @ $SL_ShouZuoLunJing_State_bActive @ " " @ $SL_BingHuoShiLian_State_bActive @ " " @ $SL_XuanShangJiXiong_State_bActive @ " " @ $SL_XueMoFenYinZhen_State_bActive @ " " @ $SL_HuangJingBaoZang_State_bActive @ " "
		@ $SL_DaoJianShenYu_State_bActive @ " " @ $SL_ZiXingChuanGong_State_bActive @ " " @ $SL_ShiMoDian_State_bActive @ " " @ $SL_YunLuoJing_State_bActive @ " " @ $SL_FengShenMiJing_State_bActive;
}
//■■■■■■■■■■■常置活动开关计算■■■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■运营活动开关计算■■■■■■■■■■■■■■■■■■■■■■■
function Bactive_YunYingPlayGame(%YY,%MM,%DD,%H,%M,%S)
{
	%LineID = GetCurrentLineId();//线程ID
	%MapID = GetSubStr(GetZoneid(),0,4);
	//-------提取元宝双倍积分反馈---------
	$SL_ChongZhiFanKui_States = GetTimeStatesBactive("ChongZhiFanKui",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_ChongZhiFanKui_State_bActive = GetWord($SL_ChongZhiFanKui_States,0);
	//-------七日冲榜---------
	$SL_BangShangYouMing_States = GetTimeStatesBactive("BangShangYouMing",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_BangShangYouMing_State_bActive = GetWord($SL_BangShangYouMing_States,0);
	//echo("七日冲榜 $SL_BangShangYouMing_States==" @ $SL_BangShangYouMing_States);
	//-------行行出状元---------
	$SL_HangHangChuZhuangYuan_States = GetTimeStatesBactive("HangHangChuZhuangYuan",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_HangHangChuZhuangYuan_State_bActive = GetWord($SL_HangHangChuZhuangYuan_States,0);
	//-------仙童降临---------
	$SL_XianTongJiangLin_States = GetTimeStatesBactive("XianTongJiangLin",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_XianTongJiangLin_State_bActive = GetWord($SL_XianTongJiangLin_States,0);
	//-------关注微博---------
	$SL_CareWeiBo_States = GetTimeStatesBactive("CareWeiBo",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_CareWeiBo_State_bActive = GetWord($SL_CareWeiBo_States,0);
	//-------满月庆典---------
	$SL_ManYueQingDian_States = GetTimeStatesBactive("ManYueQingDian",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_ManYueQingDian_State_bActive = GetWord($SL_ManYueQingDian_States,0);

	$SL_ManYueQingDianStore_States = GetTimeStatesBactive("ManYueQingDianStore",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_ManYueQingDianStore_State_bActive = GetWord($SL_ManYueQingDianStore_States,0);

	//---------祈愿豪礼---------
	$SL_QiYuanHaoLi_States = GetTimeStatesBactive("QiYuanHaoLi",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_QiYuanHaoLi_State_bActive = GetWord($SL_QiYuanHaoLi_States,0);

	//---------仙缘解签---------
	$SL_LiShangWangLai_States = GetTimeStatesBactive("LiShangWangLai",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_LiShangWangLai_State_bActive = GetWord($SL_LiShangWangLai_States,0);

	//---------全民夺宝---------
	$SL_QuanMinDuoBao_States = GetTimeStatesBactive("QuanMinDuoBao",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_QuanMinDuoBao_State_bActive = GetWord($SL_QuanMinDuoBao_States,0);
	//---------七天好礼---------
	if ($SL_QiTianHaoLi_bActive[%LineID] $= "")
	{
		if ($SL_QiTianHaoLi_bActive[1] != 1)
			$SL_QiTianHaoLi_State_bActive = 0;
		else
			$SL_QiTianHaoLi_State_bActive = 1;
	}
	else
	{
		if ($SL_QiTianHaoLi_bActive[%LineID] != 1)
			$SL_QiTianHaoLi_State_bActive = 0;
		else
			$SL_QiTianHaoLi_State_bActive = 1;
	}
	//---------签到---------
	if ($SL_QianDao_bActive[%LineID] $= "")
	{
		if ($SL_QianDao_bActive[1] != 1)
			$SL_QianDao_State_bActive = 0;
		else
			$SL_QianDao_State_bActive = 1;
	}
	else
	{
		if ($SL_QianDao_bActive[%LineID] != 1)
			$SL_QianDao_State_bActive = 0;
		else
			$SL_QianDao_State_bActive = 1;
	}
	//--------特权----------
	if ($SL_TeQuan_bActive[%LineID] $= "")
	{
		if ($SL_TeQuan_bActive[1] != 1)
			$SL_TeQuan_State_bActive = 0;
		else
			$SL_TeQuan_State_bActive = 1;
	}
	else
	{
		if ($SL_TeQuan_bActive[%LineID] != 1)
			$SL_TeQuan_State_bActive = 0;
		else
			$SL_TeQuan_State_bActive = 1;
	}
	//--------限时抢购----------
	if ($SL_XianShiQiangGou_bActive[%LineID] $= "")
	{
		if ($SL_XianShiQiangGou_bActive[1] != 1)
			$SL_XianShiQiangGou_State_bActive = 0;
		else
			$SL_XianShiQiangGou_State_bActive = 1;
	}
	else
	{
		if ($SL_XianShiQiangGou_bActive[%LineID] != 1)
			$SL_XianShiQiangGou_State_bActive = 0;
		else
			$SL_XianShiQiangGou_State_bActive = 1;
	}
	
	//--------限时抢购--------
	$SL_XianShiQiangGou_States = GetTimeStatesBactive("XianShiQiangGou", %LineID, %YY, %MM, %DD, %H, %M, %S);
	$SL_XianShiQiangGou_State_bActive = GetWord($SL_XianShiQiangGou_States, 0);
	
	
	//--------连续充值------
	$SL_LianXuChongZhi_States = GetTimeStatesBactive("LianXuChongZhi", %LineID, %YY, %MM, %DD, %H, %M, %S);
	$SL_LianXuChongZhi_State_bActive = GetWord($SL_LianXuChongZhi_States, 0);
	$Recharge7Days_Date[1] = GetWord(GetWord($SL_LianXuChongZhi_States, 1), 1, ".") @ "/" @ GetWord(GetWord($SL_LianXuChongZhi_States, 1), 2, ".");
	$Recharge7Days_Date[2] = GetWord(GetWord($SL_LianXuChongZhi_States, 2), 1, ".") @ "/" @ GetWord(GetWord($SL_LianXuChongZhi_States, 2), 2, ".");
	//echo("$SL_LianXuChongZhi_States===" @ $SL_LianXuChongZhi_States);
	//echo("$Recharge7Days_Date[1] ==" @ $Recharge7Days_Date[1]);
	//echo("$Recharge7Days_Date[2] ==" @ $Recharge7Days_Date[2]);
	//--------限时礼包------
	$SL_XianShiLiBao_States = GetTimeStatesBactive("XianShiLiBao", %LineID, %YY, %MM, %DD, %H, %M, %S);
	$SL_XianShiLiBao_State_bActive = GetWord($SL_XianShiLiBao_States, 0);

	//--------优享基金------
	$SL_YouXiangJiJin_States = GetTimeStatesBactive("YouXiangJiJin", %LineID, %YY, %MM, %DD, %H, %M, %S);
	$SL_YouXiangJiJin_State_bActive = GetWord($SL_YouXiangJiJin_States, 0);

	//------------------------------------------------------
	$SL_YunYingHuoDong_Old = $SL_YunYingHuoDong;
	$SL_YunYingHuoDong1 = %LineID @ ";"
		@ $SL_ChongZhiFanKui_States @ ";"
		@ $SL_BangShangYouMing_States @ ";"
		@ $SL_HangHangChuZhuangYuan_States @ ";"
		@ $SL_XianTongJiangLin_States @ ";"
		@ $SL_CareWeiBo_States @ ";"
		@ $SL_ManYueQingDian_States @ ";"
		@ $SL_QiYuanHaoLi_States @ ";"
		@ $SL_LiShangWangLai_States @ ";"
		@ $SL_QuanMinDuoBao_States @ ";"
		@ $SL_QiTianHaoLi_State_bActive @ ";";

	$SL_YunYingHuoDong2 = $SL_QianDao_State_bActive @ ";"
		@ $SL_TeQuan_State_bActive @ ";"
		@ $SL_LianXuChongZhi_States @ ";"
		@ $SL_XianShiLiBao_States @ ";"
		@ $SL_YouXiangJiJin_States @ ";"
		@ $SL_XianShiQiangGou_States @ ";";

	$SL_YunYingHuoDong = $SL_YunYingHuoDong1 @ $SL_YunYingHuoDong2;

	//putout("运营活动开关计算$SL_YunYingHuoDong===" @ $SL_YunYingHuoDong);
	//echo(strlen($SL_YunYingHuoDong));
}


function GetTimeStatesBactive(%StringName,%LineID,%YY,%MM,%DD,%H,%M,%S)//时间对比函数
{
	eval("%bActive = $SL_" @ %StringName @ "_bActive[" @ %LineID @ "];");
	if (%bActive $= "")
		%LineID = 1;
	eval("%bActive = $SL_" @ %StringName @ "_bActive[" @ %LineID @ "];");

	if (%bActive == 0)
		return "0 0 0";
	if (%bActive == -1)
		return "-1 0 0";
	eval("%WeekTime = $SL_" @ %StringName @ "_Week[" @ %LineID @ "];");
	//echo("==============" @ %StringName @ "=====================");
	//echo("%WeekTime ==" @  %WeekTime);

	if (%WeekTime !$= "")
	{
		%IsNeedWeek = 0;
		%LocalWeek = GetLocalWeek();
		%WeekCount = GetWordCount(%WeekTime);
		for (%i = 0; %i < %WeekCount; %i++)
		{
			%OpenWeek = GetWord(%WeekTime, %i);
			if (%OpenWeek == %LocalWeek)
			{
				%IsNeedWeek = 1;
				break;
			}
		}
		if (%IsNeedWeek != 1)
			return "0 0 0";
	}
	eval("%StartTime = $SL_" @ %StringName @ "_StartTime[" @ %LineID @ "];");
	eval("%EndTime = $SL_" @ %StringName @ "_EndTime[" @ %LineID @ "];");

	//echo("%IsNeedWeek ==" @  %IsNeedWeek);

	//echo("%bActive ==" @  %bActive);
	//echo("%StartTime ==" @  %StartTime);
	//echo("%EndTime ==" @  %EndTime);

	%StartYear = GetWord(GetWord(%StartTime,0),0,".");
	%StartMonth = GetWord(GetWord(%StartTime,0),1,".");
	%StartDay  = GetWord(GetWord(%StartTime,0),2,".");
	%StartHour = GetWord(GetWord(%StartTime,1),0,":");
	%StartMint = GetWord(GetWord(%StartTime,1),1,":");

	%EndYear = GetWord(GetWord(%EndTime,0),0,".");
	%EndMonth = GetWord(GetWord(%EndTime,0),1,".");
	%EndDay  = GetWord(GetWord(%EndTime,0),2,".");
	%EndHour = GetWord(GetWord(%EndTime,1),0,":");
	%EndMint = GetWord(GetWord(%EndTime,1),1,":");

	//echo("%StartYear  ==" @  %StartYear);
	//echo("%StartMonth ==" @  %StartMonth);
	//echo("%StartDay   ==" @  %StartDay);
	//echo("%StartHour  ==" @  %StartHour);
	//echo("%StartMint  ==" @  %StartMint);
	//echo("%EndYear  ==" @  %EndYear);
	//echo("%EndMonth ==" @  %EndMonth);
	//echo("%EndDay   ==" @  %EndDay);
	//echo("%EndHour  ==" @  %EndHour);
	//echo("%EndMint  ==" @  %EndMint);

	if (%StartYear==%YY && %StartMonth==%MM && %StartDay==%DD)
	{
		%StartTime = %StartHour*60+%StartMint;
		%NowTime = %H*60+%M;
		%EndTime = %EndHour*60+%EndMint;
		if (%StartTime<=%NowTime && %NowTime<=%EndTime)
			%Result = 1;
		else
			%Result = 0;
	}
	else if (%EndYear==%YY && %EndMonth==%MM && %EndDay==%DD)
	{
		%StartTime = %StartHour*60+%StartMint;
		%NowTime = %H*60+%M;
		%EndTime = %EndHour*60+%EndMint;

		//echo("%StartTime ==" @  %StartTime);
		//echo("%NowTime ==" @  %NowTime);
		//echo("%EndTime ==" @  %EndTime);

		if (%StartTime<=%NowTime && %NowTime<=%EndTime)
			%Result = 1;
		else
			%Result = 0;
	}
	else
	{
		%StartTime = %StartYear*365 + %StartMonth*30 + %StartDay;
		%NowTime = %YY*365 + %MM*30 + %DD;
		%EndTime = %EndYear*365 + %EndMonth*30 + %EndDay;
		if (%StartTime<=%NowTime && %NowTime<=%EndTime)
			%Result = 1;
		else
			%Result = 0;


		//echo("%StartTime ==" @  %StartTime);
		//echo("%NowTime ==" @  %NowTime);
		//echo("%EndTime ==" @  %EndTime);
	}
	eval("%StartTime = $SL_" @ %StringName @ "_StartTime[" @ %LineID @ "];");
	eval("%EndTime = $SL_" @ %StringName @ "_EndTime[" @ %LineID @ "];");

	//echo("%Result ==" @  %Result);
	
	eval("%FreshTime = $SL_" @ %StringName @ "_FreshTime[" @ %LineID @ ",1];");
	eval("%FreshItem = $SL_" @ %StringName @ "_FreshItem[" @ %LineID @ ",1];");

	if (%StringName $= "ChongZhiFanKui")
		%Result = %Result @ " " @ getword(%StartTime,0) @ " " @ getword(%EndTime,0);
	else if(%StringName $= "XianShiQiangGou")
	{
		%Result = %Result @ " " @ getword(%StartTime,0) @ " " @ getword(%EndTime,0) @ " " @ %FreshTime @ " " @ %FreshItem;
	}
	else
	{
		if (%Result > 0)
			%Result = %Result @ " " @ getword(%StartTime,0) @ " " @ getword(%EndTime,0);
		else
			%Result = %Result;
	}
	return %Result;
}
//■■■■■■■■■■■运营活动开关计算■■■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■所有活动NPC 对话入口■■■■■■■■■■■■■■■■■■■■■
function NpcOnTrigger_PlayGame(%Npc,%Player,%State,%Conv,%Param)
{
	switch$(%Npc.GetDataID())
	{
		case "410010220":NpcOnTrigger_Dialog_QunYingHuiJu(%Npc,%Player,%State,%Conv,%Param,1);//群英汇聚
		case "410010221":NpcOnTrigger_Dialog_QunYingHuiJu(%Npc,%Player,%State,%Conv,%Param,2);//群英汇聚
		case "410010222":NpcOnTrigger_Dialog_QunYingHuiJu(%Npc,%Player,%State,%Conv,%Param,3);//群英汇聚
		case "410010223":NpcOnTrigger_Dialog_QunYingHuiJu(%Npc,%Player,%State,%Conv,%Param,4);//群英汇聚
		case "410010224":NpcOnTrigger_Dialog_QunYingHuiJu(%Npc,%Player,%State,%Conv,%Param,5);//群英汇聚

		case "410010209":NpcOnTrigger_Dialog_410010209(%Npc,%Player,%State,%Conv,%Param);//时空裂痕传送员

		case "410010204":NpcOnTrigger_Dialog_410010204(%Npc,%Player,%State,%Conv,%Param);//炼魔渊传送员

		case "410010211":NpcOnTrigger_Dialog_410010211(%Npc,%Player,%State,%Conv,%Param);//前往幻境争霸副本 
		case "410010212":NpcOnTrigger_Dialog_410010212(%Npc,%Player,%State,%Conv,%Param);//前往鸿蒙试炼副本

		case "410100001":ShiMenJinZong_Dialog(%Npc,%Player,%State,%Conv);//师门尽忠接取
		case "413030001":ZhuShenWenXinZhen_Dialong(%Npc,%Player,%State,%Conv);//诛神问心阵
		case "411190001":YaBiaoHuoDong_DiaLog(%Npc,%Player,%State,%Conv);//镖师对话
		case "411190002":YaBiaoHuoDong_DiaLog(%Npc,%Player,%State,%Conv);//总镖头对话
		case "411190003":YaBiaoHuoDong_DiaLog(%Npc,%Player,%State,%Conv);//白色镖车对话
		case "411190004":YaBiaoHuoDong_DiaLog(%Npc,%Player,%State,%Conv);//绿色镖车对话
		case "411190005":YaBiaoHuoDong_DiaLog(%Npc,%Player,%State,%Conv);//蓝色镖车对话
		case "411190006":YaBiaoHuoDong_DiaLog(%Npc,%Player,%State,%Conv);//紫色镖车对话
		case "411190007":YaBiaoHuoDong_DiaLog(%Npc,%Player,%State,%Conv);//橙色镖车对话

		case "410100012":DiaoYuHuoDong_DiaLogA(%Npc,%Player,%State,%Conv);//钓鱼兑换鱼饵
		case "410010202":DiaoYuHuoDong_DiaLogB(%Npc,%Player,%State,%Conv);//钓鱼兑换奖励 皇浦奇
			//case "410010003":DiaoYuHuoDong_DiaLogC( %Npc, %Player, %State, %Conv );//钓鱼兑换奖励 	玲珑

		case "410100023":LingJingWuDao_DiaLogA(%Npc,%Player,%State,%Conv);//上缴悟经牌
		case "410100032":LingJingWuDao_DiaLogB(%Npc,%Player,%State,%Conv);//召唤元神悟道
		case "410100031":ShouZuoLunJing_DiaLog(%Npc,%Player,%State,%Conv);//首座讲经领取奖励
		case "411200001":BingHuoShiLian_DiaLog(%Npc,%Player,%State,%Conv);//冰火试炼 接取任务对白 幽千寻	试炼使者
		case "411200002":BingHuoShiLian_DiaLog(%Npc,%Player,%State,%Conv);//冰火试炼 接取任务对白 冰雲	冰之圣使
		case "411200003":BingHuoShiLian_DiaLog(%Npc,%Player,%State,%Conv);//冰火试炼 接取任务对白 炎霄	焰之圣使
		case "411210001":BingHuoShiLian_DiaLog(%Npc,%Player,%State,%Conv);//冰火试炼 接取任务对白 幽千寻	试炼使者
		case "411210002":BingHuoShiLian_DiaLog(%Npc,%Player,%State,%Conv);//冰火试炼 接取任务对白 冰雲	冰之圣使
		case "411210003":BingHuoShiLian_DiaLog(%Npc,%Player,%State,%Conv);//冰火试炼 接取任务对白 炎霄	焰之圣使
		case "411220001":BingHuoShiLian_DiaLog(%Npc,%Player,%State,%Conv);//冰火试炼 接取任务对白 幽千寻	试炼使者
		case "411220002":BingHuoShiLian_DiaLog(%Npc,%Player,%State,%Conv);//冰火试炼 接取任务对白 冰雲	冰之圣使
		case "411220003":BingHuoShiLian_DiaLog(%Npc,%Player,%State,%Conv);//冰火试炼 接取任务对白 炎霄	焰之圣使
		case "410010203":XueMoFengYinZhenDiaLogA(%Npc,%Player,%State,%Conv);//血魔封印 进入副本传送对话
		case "413070001":XueMoFengYinZhenDiaLogB(%Npc,%Player,%State,%Conv);//血魔封印 战斗开启对话
		case "413070002":XueMoFengYinZhenDiaLogC(%Npc,%Player,%State,%Conv);//血魔封印 解除封印对话
		case "410010206":HuangJinBaoZangDialog(%Npc,%Player,%State,%Conv);//黄金宝藏 进入副本传送对话
		case "410010207":DaoJianShenYuDiaLog(%Npc,%Player,%State,%Conv);//刀剑神域
		case "410010013":QiShiShangDianDialog(%Npc,%Player,%State,%Conv);//奇石商店展示
		case "410010014":ShenShiShangDianDialog(%Npc,%Player,%State,%Conv);//神石商店展示
		case "411181001":GotoShiMoDian_DiaLog(%Npc,%Player,%State,%Conv);//进入镇魔殿传送对话
		case "413032001":YunLuoJing_DiaLog(%Npc,%Player,%State,%Conv);//云罗镜开启
		case "413032002":YunLuoJing_DiaLogB(%Npc,%Player,%State,%Conv);//云罗镜倍率刷新
		case "410010107":YunLuoJing_TransPortObject(%Npc,%Player,%State,%Conv);//云罗镜传送
		case "413180001":FengShenMiJing_DiaLog(%Npc, %Player, %State, %Conv);//封神秘境副本开启
		case "410010301":FengShenMiJing_TransPortObject(%Npc, %Player, %State, %Conv);//封神秘境副本进入
	}
}

//■■■■■■■■■■■所有活动NPC 对话入口■■■■■■■■■■■■■■■■■■■■■
function SendMuBan(%Player)
{
	//-------------------------活动开启的公告模板------------------

	//$Get_Dialog_GeShi[ 31419 ] = "<t f='宋体' m='1' n='12' c='0x2cffeeff'o='0x010101ff'>";			//活动系统公告普通字体颜色
	//$Get_Dialog_GeShi[ 31420 ] = "<t f='宋体' m='1' n='12' c='0xff00ffff' o='0x010101ff'>";			//活动时间 活动等级
	//$Get_Dialog_GeShi[ 31421 ] = "<t f='宋体' m='1' n='12' c='0xff6e00ff' o='0x010101ff'>";			//活动名称
	//$Get_Dialog_GeShi[ 31422 ] = "<t f='宋体' m='1' n='12' c='0xff0080ff' o='0x010101ff'>";				//活动奖励
	//$Get_Dialog_GeShi[ 31423 ] = "<t f='宋体' m='1' n='12' c='0xffff00ff' o='0x010101ff'>";				//活动区域
	//$Get_Dialog_GeShi[ 31424 ] = "<t f='宋体' m='1' n='12' c='0xf28226ff' o='0x010101ff'>";				//玩家名称
	//$Get_Dialog_GeShi[ 31425 ] = "<t f='宋体' m='1' n='12' c='0xbfff00ff' o='0x010101ff'>";				//草绿色
	//$Get_Dialog_GeShi[ 31601 ] = "<t f='宋体' m='1' n='16' c='0xffffffff' o='0x010101ff'>";				//白色-提示追踪指引字体
	//%Path = GetTraceButton( "findpath(410010302);", GetNpcData( 410010302, 1 ) );//NPC寻径
	%Path = "<l i='" @ GetSubStr(%Player.Gettriggerid(),0,7) @ "00 " @ %Player.GetPosition() @ "' t='path'/>";

	%Teshu = "<t c='0xff6e00ff' o='0x010101ff'>『幻境争霸』</t>"; //活动名称 橙色

	%Text = %Teshu @ "<t>将在</t>" @ %begin @ "<t>分钟后开启，修士们可前往</t>" @ %Path @ "<t>,参与挑战。</t>";

	SendOneLineMessage(%Tab @ %Text @ "</t>");


	//--------------------------对话框的文本模板--------------------------
	/*
	$Get_Dialog_GeShi[ 80000 ] = "<t f='隶书' m='0' h='1' n='20' gct='0xffff00ff' gcb='0xd9680dff'>";//渐变黄色－标题格式		大标题
	$Get_Dialog_GeShi[ 80001 ] = "<t f='微软雅黑' b='1' m='0' n='14' c='0x00b0f0ff' o='0x010101ff'>";//蓝色						小标题
	$Get_Dialog_GeShi[ 80002 ] = "<t f='微软雅黑' b='1' m='0' n='14' c='0xffffffff' o='0x010101ff'>";//白色						正文描述文字
	$Get_Dialog_GeShi[ 80003 ] = "<t f='微软雅黑' b='1' m='0' n='14' c='0xff00ffff' o='0x010101ff'>";//紫色						醒目文字
	$Get_Dialog_GeShi[ 80004 ] = "<t f='微软雅黑' b='1' m='0' n='14' c='0x29be5eff' o='0x010101ff'>";//绿色						小提示
	$Player_TY_Dialog[ 600000004 ] = $Get_Dialog_GeShi[ 80002 ] @ //默认为白色格式（最外层嵌套）
	$Get_Dialog_GeShi[ 80000 ] @ "◆时空裂痕◆</t>" @
	$Get_Dialog_GeShi[ 80001 ] @ "◆开放时间：</t><t>每天</t>" @ $Get_Dialog_GeShi[ 80003 ] @ $SL_JiaZuGouHuo_StartTime @ "</t><t>点开始</t><b/>" @
	$Get_Dialog_GeShi[ 80001 ] @ "◆挑战建议：</t><t>三人（战、法、道）以上</t><b/>" @
	$Get_Dialog_GeShi[ 80001 ] @ "◆副本奖励：</t><t>大量经验</t><b/>" @
	$Get_Dialog_GeShi[ 80001 ] @ "◆参与规则：</t><b/>" @
	$Get_Dialog_GeShi[ 80002 ] @ "◇◇每人每天可挑战一次</t><b/>" @
	$Get_Dialog_GeShi[ 80002 ] @ "◇◇副本内寻找自己的本命星刷新星魂等级</t><b/>" @
	$Get_Dialog_GeShi[ 80002 ] @ "◇◇根据不同的星魂等级获得不同的经验倍数</t><b/>" @
	$Get_Dialog_GeShi[ 80002 ] @ "◇◇使用</t>" @ "<l i='105109201 ' t='itemid'/>" @ "<t>进入副本，每天可用3次</t><b/>" @
	$Get_Dialog_GeShi[ 80002 ] @ "◇◇【" @ GetItemData( 105109201, 1 ) @ "】可以在</t>" @ $YuanBaoShangCheng @ "</t><t>购买</t><b/>" @
	$Get_Dialog_GeShi[ 80004 ] @ "注：进入副本后，自动刷新一次星魂等级！</t></t>";
	*/
	//---------------------------大跑马公告模板-----------------------------
}


//■■■■■■■■■■■其他内容■■■■■■■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■其他内容■■■■■■■■■■■■■■■■■■■■■■■■■■■