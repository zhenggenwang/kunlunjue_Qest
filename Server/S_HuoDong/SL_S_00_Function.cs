//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//��ýű����ͻ�����������������
//==================================================================================
//�������������������������ػ���ļ�������������������������������������������������
//�������������������������û���ؼ������������������������������������������������
//������������������������Ӫ����ؼ������������������������������������������������
//�������������������������лNPC �Ի���ڡ�����������������������������������������

//�����������������������������ݡ�����������������������������������������������������






//�������������������������ػ���ļ�������������������������������������������������
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
//�������������������������ػ���ļ�������������������������������������������������

//�������������������������û���ؼ������������������������������������������������
function Bactive_PlayGame(%YY,%MM,%DD,%H,%M,%S)
{
	%MapID = GetSubStr(GetZoneid(),0,4);
	%TimeNow = %H*60+%M;
	//-------ȺӢ���---------
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
	//--------ʱ���Ѻ�----------
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

	//--------��ħԨ----------
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
	//--------�þ�����-----------
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

	//-----------����BOSS--------------
	if ($SL_ShiJieBoss_bActive==1)
		$SL_ShiJieBoss_State_bActive = 1;
	else
		$SL_ShiJieBoss_State_bActive = 0;
	//--------����-----------
	if ($SL_ZhuYao_bActive==1)
		$SL_ZhuYao_State_bActive = 1;
	else
		$SL_ZhuYao_State_bActive = 0;
	//--------�ر�ͼ---------
	if ($SL_CangBaoTu_bActive==1)
		$SL_CangBaoTu_State_bActive = 1;
	else
		$SL_CangBaoTu_State_bActive = 0;
	//--------ʦ�ž���---------
	if ($SL_ShiMenJinZong_bActive==1)
		$SL_ShiMenJinZong_State_bActive = 1;
	else
		$SL_ShiMenJinZong_State_bActive = 0;
	//--------����������---------
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
	//--------��������---------
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
	//---------Ѻ��-----------
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
	//--------����----------------
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
	//--------�������-------------
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
	//-------------�����۾�-------------------
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

	//-------------��������-------------------
	if ($SL_BingHuoShiLian_bActive==1)
		$SL_BingHuoShiLian_State_bActive = 1;
	else
		$SL_BingHuoShiLian_State_bActive = 0;

	//-------------���ͼ���-------------------
	if ($SL_XuanShangJiXiong_bActive==1)
		$SL_XuanShangJiXiong_State_bActive = 1;
	else
		$SL_XuanShangJiXiong_State_bActive = 0;
	//-------------Ѫħ��ӡ��-----------------
	if ($SL_XueMoFenYinZhen_bActive==1)
		$SL_XueMoFenYinZhen_State_bActive = 1;
	else
		$SL_XueMoFenYinZhen_State_bActive = 0;
	//-------------�ƽ𱦲�-----------------
	if ($SL_HuangJingBaoZang_bActive==1)
		$SL_HuangJingBaoZang_State_bActive = 1;
	else
		$SL_HuangJingBaoZang_State_bActive = 0;
	//-------------��������-----------------
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
	//-------------���Ǵ���-----------------
	if ($SL_ZiXingChuanGong_bActive==1)
		$SL_ZiXingChuanGong_State_bActive = 1;
	else
		$SL_ZiXingChuanGong_State_bActive = 0;
	//-------------��ħ��-----------------
	if ($SL_ShiMoDian_bActive==1)
		$SL_ShiMoDian_State_bActive = 1;
	else
		$SL_ShiMoDian_State_bActive = 0;
	//-------------���޾�------------------
	if ($SL_YunLuoJing_bActive==1)
		$SL_YunLuoJing_State_bActive = 1;
	else
		$SL_YunLuoJing_State_bActive = 0;
	//-------------�����ؾ�------------------
	if ($SL_FengShenMiJing_bActive == 1)
		$SL_FengShenMiJing_State_bActive = 1;
	else
		$SL_FengShenMiJing_State_bActive = 0;


	//-------------�����лƴ��һ���ַ���ƴ��һ���ַ���-----�������ȥ���� -1 ���ȫ���潫������ʾ----
	$SL_HuoDong_Old = $SL_HuoDong;
	$SL_HuoDong = $SL_JiaZuGouHuo_State_bActive @ " " @ $SL_XuanWuMen_State_bActive @ " " @ $SL_LianMoYuan_State_bActive @ " " @ $SL_HuanJingZhengBa_State_bActive @ " " @ $SL_ShiJieBoss_State_bActive @ " " @ $SL_ZhuYao_State_bActive @ " "
		@ $SL_CangBaoTu_State_bActive @ " " @ $SL_ShiMenJinZong_State_bActive @ " " @ $SL_ZhuShenWenXinZhen_State_bActive @ " " @ $SL_YunXianJie_State_bActive @ " " @ $SL_YaBiao_State_bActive @ " " @ $SL_DiaoYu_State_bActive @ " "
		@ $SL_LingJingWuDao_State_bActive @ " " @ $SL_ShouZuoLunJing_State_bActive @ " " @ $SL_BingHuoShiLian_State_bActive @ " " @ $SL_XuanShangJiXiong_State_bActive @ " " @ $SL_XueMoFenYinZhen_State_bActive @ " " @ $SL_HuangJingBaoZang_State_bActive @ " "
		@ $SL_DaoJianShenYu_State_bActive @ " " @ $SL_ZiXingChuanGong_State_bActive @ " " @ $SL_ShiMoDian_State_bActive @ " " @ $SL_YunLuoJing_State_bActive @ " " @ $SL_FengShenMiJing_State_bActive;
}
//�������������������������û���ؼ������������������������������������������������

//������������������������Ӫ����ؼ������������������������������������������������
function Bactive_YunYingPlayGame(%YY,%MM,%DD,%H,%M,%S)
{
	%LineID = GetCurrentLineId();//�߳�ID
	%MapID = GetSubStr(GetZoneid(),0,4);
	//-------��ȡԪ��˫�����ַ���---------
	$SL_ChongZhiFanKui_States = GetTimeStatesBactive("ChongZhiFanKui",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_ChongZhiFanKui_State_bActive = GetWord($SL_ChongZhiFanKui_States,0);
	//-------���ճ��---------
	$SL_BangShangYouMing_States = GetTimeStatesBactive("BangShangYouMing",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_BangShangYouMing_State_bActive = GetWord($SL_BangShangYouMing_States,0);
	//echo("���ճ�� $SL_BangShangYouMing_States==" @ $SL_BangShangYouMing_States);
	//-------���г�״Ԫ---------
	$SL_HangHangChuZhuangYuan_States = GetTimeStatesBactive("HangHangChuZhuangYuan",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_HangHangChuZhuangYuan_State_bActive = GetWord($SL_HangHangChuZhuangYuan_States,0);
	//-------��ͯ����---------
	$SL_XianTongJiangLin_States = GetTimeStatesBactive("XianTongJiangLin",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_XianTongJiangLin_State_bActive = GetWord($SL_XianTongJiangLin_States,0);
	//-------��ע΢��---------
	$SL_CareWeiBo_States = GetTimeStatesBactive("CareWeiBo",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_CareWeiBo_State_bActive = GetWord($SL_CareWeiBo_States,0);
	//-------�������---------
	$SL_ManYueQingDian_States = GetTimeStatesBactive("ManYueQingDian",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_ManYueQingDian_State_bActive = GetWord($SL_ManYueQingDian_States,0);

	$SL_ManYueQingDianStore_States = GetTimeStatesBactive("ManYueQingDianStore",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_ManYueQingDianStore_State_bActive = GetWord($SL_ManYueQingDianStore_States,0);

	//---------��Ը����---------
	$SL_QiYuanHaoLi_States = GetTimeStatesBactive("QiYuanHaoLi",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_QiYuanHaoLi_State_bActive = GetWord($SL_QiYuanHaoLi_States,0);

	//---------��Ե��ǩ---------
	$SL_LiShangWangLai_States = GetTimeStatesBactive("LiShangWangLai",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_LiShangWangLai_State_bActive = GetWord($SL_LiShangWangLai_States,0);

	//---------ȫ��ᱦ---------
	$SL_QuanMinDuoBao_States = GetTimeStatesBactive("QuanMinDuoBao",%LineID,%YY,%MM,%DD,%H,%M,%S);
	$SL_QuanMinDuoBao_State_bActive = GetWord($SL_QuanMinDuoBao_States,0);
	//---------�������---------
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
	//---------ǩ��---------
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
	//--------��Ȩ----------
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
	//--------��ʱ����----------
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
	
	//--------��ʱ����--------
	$SL_XianShiQiangGou_States = GetTimeStatesBactive("XianShiQiangGou", %LineID, %YY, %MM, %DD, %H, %M, %S);
	$SL_XianShiQiangGou_State_bActive = GetWord($SL_XianShiQiangGou_States, 0);
	
	
	//--------������ֵ------
	$SL_LianXuChongZhi_States = GetTimeStatesBactive("LianXuChongZhi", %LineID, %YY, %MM, %DD, %H, %M, %S);
	$SL_LianXuChongZhi_State_bActive = GetWord($SL_LianXuChongZhi_States, 0);
	$Recharge7Days_Date[1] = GetWord(GetWord($SL_LianXuChongZhi_States, 1), 1, ".") @ "/" @ GetWord(GetWord($SL_LianXuChongZhi_States, 1), 2, ".");
	$Recharge7Days_Date[2] = GetWord(GetWord($SL_LianXuChongZhi_States, 2), 1, ".") @ "/" @ GetWord(GetWord($SL_LianXuChongZhi_States, 2), 2, ".");
	//echo("$SL_LianXuChongZhi_States===" @ $SL_LianXuChongZhi_States);
	//echo("$Recharge7Days_Date[1] ==" @ $Recharge7Days_Date[1]);
	//echo("$Recharge7Days_Date[2] ==" @ $Recharge7Days_Date[2]);
	//--------��ʱ���------
	$SL_XianShiLiBao_States = GetTimeStatesBactive("XianShiLiBao", %LineID, %YY, %MM, %DD, %H, %M, %S);
	$SL_XianShiLiBao_State_bActive = GetWord($SL_XianShiLiBao_States, 0);

	//--------�������------
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

	//putout("��Ӫ����ؼ���$SL_YunYingHuoDong===" @ $SL_YunYingHuoDong);
	//echo(strlen($SL_YunYingHuoDong));
}


function GetTimeStatesBactive(%StringName,%LineID,%YY,%MM,%DD,%H,%M,%S)//ʱ��ԱȺ���
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
//������������������������Ӫ����ؼ������������������������������������������������

//�������������������������лNPC �Ի���ڡ�����������������������������������������
function NpcOnTrigger_PlayGame(%Npc,%Player,%State,%Conv,%Param)
{
	switch$(%Npc.GetDataID())
	{
		case "410010220":NpcOnTrigger_Dialog_QunYingHuiJu(%Npc,%Player,%State,%Conv,%Param,1);//ȺӢ���
		case "410010221":NpcOnTrigger_Dialog_QunYingHuiJu(%Npc,%Player,%State,%Conv,%Param,2);//ȺӢ���
		case "410010222":NpcOnTrigger_Dialog_QunYingHuiJu(%Npc,%Player,%State,%Conv,%Param,3);//ȺӢ���
		case "410010223":NpcOnTrigger_Dialog_QunYingHuiJu(%Npc,%Player,%State,%Conv,%Param,4);//ȺӢ���
		case "410010224":NpcOnTrigger_Dialog_QunYingHuiJu(%Npc,%Player,%State,%Conv,%Param,5);//ȺӢ���

		case "410010209":NpcOnTrigger_Dialog_410010209(%Npc,%Player,%State,%Conv,%Param);//ʱ���Ѻ۴���Ա

		case "410010204":NpcOnTrigger_Dialog_410010204(%Npc,%Player,%State,%Conv,%Param);//��ħԨ����Ա

		case "410010211":NpcOnTrigger_Dialog_410010211(%Npc,%Player,%State,%Conv,%Param);//ǰ���þ����Ը��� 
		case "410010212":NpcOnTrigger_Dialog_410010212(%Npc,%Player,%State,%Conv,%Param);//ǰ��������������

		case "410100001":ShiMenJinZong_Dialog(%Npc,%Player,%State,%Conv);//ʦ�ž��ҽ�ȡ
		case "413030001":ZhuShenWenXinZhen_Dialong(%Npc,%Player,%State,%Conv);//����������
		case "411190001":YaBiaoHuoDong_DiaLog(%Npc,%Player,%State,%Conv);//��ʦ�Ի�
		case "411190002":YaBiaoHuoDong_DiaLog(%Npc,%Player,%State,%Conv);//����ͷ�Ի�
		case "411190003":YaBiaoHuoDong_DiaLog(%Npc,%Player,%State,%Conv);//��ɫ�ڳ��Ի�
		case "411190004":YaBiaoHuoDong_DiaLog(%Npc,%Player,%State,%Conv);//��ɫ�ڳ��Ի�
		case "411190005":YaBiaoHuoDong_DiaLog(%Npc,%Player,%State,%Conv);//��ɫ�ڳ��Ի�
		case "411190006":YaBiaoHuoDong_DiaLog(%Npc,%Player,%State,%Conv);//��ɫ�ڳ��Ի�
		case "411190007":YaBiaoHuoDong_DiaLog(%Npc,%Player,%State,%Conv);//��ɫ�ڳ��Ի�

		case "410100012":DiaoYuHuoDong_DiaLogA(%Npc,%Player,%State,%Conv);//����һ����
		case "410010202":DiaoYuHuoDong_DiaLogB(%Npc,%Player,%State,%Conv);//����һ����� ������
			//case "410010003":DiaoYuHuoDong_DiaLogC( %Npc, %Player, %State, %Conv );//����һ����� 	����

		case "410100023":LingJingWuDao_DiaLogA(%Npc,%Player,%State,%Conv);//�Ͻ�����
		case "410100032":LingJingWuDao_DiaLogB(%Npc,%Player,%State,%Conv);//�ٻ�Ԫ�����
		case "410100031":ShouZuoLunJing_DiaLog(%Npc,%Player,%State,%Conv);//����������ȡ����
		case "411200001":BingHuoShiLian_DiaLog(%Npc,%Player,%State,%Conv);//�������� ��ȡ����԰� ��ǧѰ	����ʹ��
		case "411200002":BingHuoShiLian_DiaLog(%Npc,%Player,%State,%Conv);//�������� ��ȡ����԰� ���	��֮ʥʹ
		case "411200003":BingHuoShiLian_DiaLog(%Npc,%Player,%State,%Conv);//�������� ��ȡ����԰� ����	��֮ʥʹ
		case "411210001":BingHuoShiLian_DiaLog(%Npc,%Player,%State,%Conv);//�������� ��ȡ����԰� ��ǧѰ	����ʹ��
		case "411210002":BingHuoShiLian_DiaLog(%Npc,%Player,%State,%Conv);//�������� ��ȡ����԰� ���	��֮ʥʹ
		case "411210003":BingHuoShiLian_DiaLog(%Npc,%Player,%State,%Conv);//�������� ��ȡ����԰� ����	��֮ʥʹ
		case "411220001":BingHuoShiLian_DiaLog(%Npc,%Player,%State,%Conv);//�������� ��ȡ����԰� ��ǧѰ	����ʹ��
		case "411220002":BingHuoShiLian_DiaLog(%Npc,%Player,%State,%Conv);//�������� ��ȡ����԰� ���	��֮ʥʹ
		case "411220003":BingHuoShiLian_DiaLog(%Npc,%Player,%State,%Conv);//�������� ��ȡ����԰� ����	��֮ʥʹ
		case "410010203":XueMoFengYinZhenDiaLogA(%Npc,%Player,%State,%Conv);//Ѫħ��ӡ ���븱�����ͶԻ�
		case "413070001":XueMoFengYinZhenDiaLogB(%Npc,%Player,%State,%Conv);//Ѫħ��ӡ ս�������Ի�
		case "413070002":XueMoFengYinZhenDiaLogC(%Npc,%Player,%State,%Conv);//Ѫħ��ӡ �����ӡ�Ի�
		case "410010206":HuangJinBaoZangDialog(%Npc,%Player,%State,%Conv);//�ƽ𱦲� ���븱�����ͶԻ�
		case "410010207":DaoJianShenYuDiaLog(%Npc,%Player,%State,%Conv);//��������
		case "410010013":QiShiShangDianDialog(%Npc,%Player,%State,%Conv);//��ʯ�̵�չʾ
		case "410010014":ShenShiShangDianDialog(%Npc,%Player,%State,%Conv);//��ʯ�̵�չʾ
		case "411181001":GotoShiMoDian_DiaLog(%Npc,%Player,%State,%Conv);//������ħ��ͶԻ�
		case "413032001":YunLuoJing_DiaLog(%Npc,%Player,%State,%Conv);//���޾�����
		case "413032002":YunLuoJing_DiaLogB(%Npc,%Player,%State,%Conv);//���޾�����ˢ��
		case "410010107":YunLuoJing_TransPortObject(%Npc,%Player,%State,%Conv);//���޾�����
		case "413180001":FengShenMiJing_DiaLog(%Npc, %Player, %State, %Conv);//�����ؾ���������
		case "410010301":FengShenMiJing_TransPortObject(%Npc, %Player, %State, %Conv);//�����ؾ���������
	}
}

//�������������������������лNPC �Ի���ڡ�����������������������������������������
function SendMuBan(%Player)
{
	//-------------------------������Ĺ���ģ��------------------

	//$Get_Dialog_GeShi[ 31419 ] = "<t f='����' m='1' n='12' c='0x2cffeeff'o='0x010101ff'>";			//�ϵͳ������ͨ������ɫ
	//$Get_Dialog_GeShi[ 31420 ] = "<t f='����' m='1' n='12' c='0xff00ffff' o='0x010101ff'>";			//�ʱ�� ��ȼ�
	//$Get_Dialog_GeShi[ 31421 ] = "<t f='����' m='1' n='12' c='0xff6e00ff' o='0x010101ff'>";			//�����
	//$Get_Dialog_GeShi[ 31422 ] = "<t f='����' m='1' n='12' c='0xff0080ff' o='0x010101ff'>";				//�����
	//$Get_Dialog_GeShi[ 31423 ] = "<t f='����' m='1' n='12' c='0xffff00ff' o='0x010101ff'>";				//�����
	//$Get_Dialog_GeShi[ 31424 ] = "<t f='����' m='1' n='12' c='0xf28226ff' o='0x010101ff'>";				//�������
	//$Get_Dialog_GeShi[ 31425 ] = "<t f='����' m='1' n='12' c='0xbfff00ff' o='0x010101ff'>";				//����ɫ
	//$Get_Dialog_GeShi[ 31601 ] = "<t f='����' m='1' n='16' c='0xffffffff' o='0x010101ff'>";				//��ɫ-��ʾ׷��ָ������
	//%Path = GetTraceButton( "findpath(410010302);", GetNpcData( 410010302, 1 ) );//NPCѰ��
	%Path = "<l i='" @ GetSubStr(%Player.Gettriggerid(),0,7) @ "00 " @ %Player.GetPosition() @ "' t='path'/>";

	%Teshu = "<t c='0xff6e00ff' o='0x010101ff'>���þ����ԡ�</t>"; //����� ��ɫ

	%Text = %Teshu @ "<t>����</t>" @ %begin @ "<t>���Ӻ�������ʿ�ǿ�ǰ��</t>" @ %Path @ "<t>,������ս��</t>";

	SendOneLineMessage(%Tab @ %Text @ "</t>");


	//--------------------------�Ի�����ı�ģ��--------------------------
	/*
	$Get_Dialog_GeShi[ 80000 ] = "<t f='����' m='0' h='1' n='20' gct='0xffff00ff' gcb='0xd9680dff'>";//�����ɫ�������ʽ		�����
	$Get_Dialog_GeShi[ 80001 ] = "<t f='΢���ź�' b='1' m='0' n='14' c='0x00b0f0ff' o='0x010101ff'>";//��ɫ						С����
	$Get_Dialog_GeShi[ 80002 ] = "<t f='΢���ź�' b='1' m='0' n='14' c='0xffffffff' o='0x010101ff'>";//��ɫ						������������
	$Get_Dialog_GeShi[ 80003 ] = "<t f='΢���ź�' b='1' m='0' n='14' c='0xff00ffff' o='0x010101ff'>";//��ɫ						��Ŀ����
	$Get_Dialog_GeShi[ 80004 ] = "<t f='΢���ź�' b='1' m='0' n='14' c='0x29be5eff' o='0x010101ff'>";//��ɫ						С��ʾ
	$Player_TY_Dialog[ 600000004 ] = $Get_Dialog_GeShi[ 80002 ] @ //Ĭ��Ϊ��ɫ��ʽ�������Ƕ�ף�
	$Get_Dialog_GeShi[ 80000 ] @ "��ʱ���Ѻۡ�</t>" @
	$Get_Dialog_GeShi[ 80001 ] @ "������ʱ�䣺</t><t>ÿ��</t>" @ $Get_Dialog_GeShi[ 80003 ] @ $SL_JiaZuGouHuo_StartTime @ "</t><t>�㿪ʼ</t><b/>" @
	$Get_Dialog_GeShi[ 80001 ] @ "����ս���飺</t><t>���ˣ�ս��������������</t><b/>" @
	$Get_Dialog_GeShi[ 80001 ] @ "������������</t><t>��������</t><b/>" @
	$Get_Dialog_GeShi[ 80001 ] @ "���������</t><b/>" @
	$Get_Dialog_GeShi[ 80002 ] @ "���ÿ��ÿ�����սһ��</t><b/>" @
	$Get_Dialog_GeShi[ 80002 ] @ "��󸱱���Ѱ���Լ��ı�����ˢ���ǻ�ȼ�</t><b/>" @
	$Get_Dialog_GeShi[ 80002 ] @ "�����ݲ�ͬ���ǻ�ȼ���ò�ͬ�ľ��鱶��</t><b/>" @
	$Get_Dialog_GeShi[ 80002 ] @ "���ʹ��</t>" @ "<l i='105109201 ' t='itemid'/>" @ "<t>���븱����ÿ�����3��</t><b/>" @
	$Get_Dialog_GeShi[ 80002 ] @ "���" @ GetItemData( 105109201, 1 ) @ "��������</t>" @ $YuanBaoShangCheng @ "</t><t>����</t><b/>" @
	$Get_Dialog_GeShi[ 80004 ] @ "ע�����븱�����Զ�ˢ��һ���ǻ�ȼ���</t></t>";
	*/
	//---------------------------��������ģ��-----------------------------
}


//�����������������������������ݡ�����������������������������������������������������

//�����������������������������ݡ�����������������������������������������������������