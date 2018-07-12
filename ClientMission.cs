//■■■■■■■■■■■■客户端的加载内容■■■■■■■■■■■■
//■■■■■■■■■■■■客户端的加载详细■■■■■■■■■■■■
//■■■■■■■■■■■■客户端启动加载项■■■■■■■■■■■■




//■■■■■■■■■■■■客户端的加载内容■■■■■■■■■■■■
function UPCS(%Num)
{
	//加载脚本标识，标明当前为客户端脚本
	$Now_Script=1;
	if ((%Num==1)||(%Num==99)){ Exec("./C_S/SL_C_S_Function.cs"); }	//共享脚本加载
	if ((%Num==2)||(%Num==99)){ Exec("./Client/SL_C_Function.cs"); }
	if ((%Num==3)||(%Num==99)){ Exec("./Client/SL_C_Dialog_Other.cs"); }
	if ((%Num==4)||(%Num==99)){ Exec("./Client/SL_C_Help_Dialog.cs"); }
	if ((%Num==5)||(%Num==99)){ Exec("./Client/SL_C_Npc_Random_Dialog.cs"); }
	if ((%Num==6)||(%Num==99)){ Exec("./Client/SL_C_Tooltips.cs"); }
	if ((%Num==7)||(%Num==99)){ Exec("./Client/SL_C_Dialog_Other_TY.cs"); }
	if ((%Num==8)||(%Num==99)){ Exec("./Client/SL_C_Final_Variables.cs"); }
	if ((%Num==9)||(%Num==99)){ Exec("./Client/SL_C_ZhiYinWnd.cs"); }
	if ((%Num==10)||(%Num==99)){ Exec("./Client/SL_C_UpGradeTips.cs"); }
	if ((%Num==11)||(%Num==99)){ Exec("./Client/SL_C_ChengJiuWnd.cs"); }
	if ((%Num==13)||(%Num==99)){ Exec("./Client/SL_C_OnSptActionEvent_C.cs"); }
	if ((%Num==14)||(%Num==99)){ Exec("./Client/SL_C_StrategyWnd.cs"); }//

	//Mission文件夹加载
	UPCS_Mission(99);
	//HuoDong文件夹加载
	UPCS_HuoDong(99);
}

//■■■■■■■■■■■■客户端的加载详细■■■■■■■■■■■■
function UPCS_Mission(%Num)
{
	//if ( ( %Num == 1 )||( %Num == 99 ) ){ Exec( "./Client/C_Mission/SL_C_Dialog_Mission_XinShou.cs" ); }
	if ((%Num==2)||(%Num==99)){ Exec("./Client/C_Mission/SL_C_Dialog_Mission_HuoDong.cs"); }
	if ((%Num==3)||(%Num==99)){ Exec("./Client/C_Mission/SL_C_Dialog_Mission_QiTa.cs"); }
	if ((%Num==4)||(%Num==99)){ Exec("./Client/C_Mission/SL_C_Dialog_Mission_ZhangHui.cs"); }
	if ((%Num==5)||(%Num==99)){ Exec("./Client/C_Mission/SL_C_Dialog_Mission_ZhiYin.cs"); }
	if ((%Num==6)||(%Num==99)){ Exec("./Client/C_Mission/SL_C_Mission_UI.cs"); }
	if ((%Num==7)||(%Num==99)){ Exec("./Client/C_Mission/SL_C_Dialog_Mission_ZhuXian.cs"); }
	if ((%Num==8)||(%Num==99)){ Exec("./Client/C_Mission/SL_C_Mission_Classe.cs"); }
	if ((%Num==9)||(%Num==99)){ Exec("./Client/C_Mission/SL_C_Dialog_Mission_LittleMovie.cs"); }

}

function UPCS_HuoDong(%Num)
{
	if ((%Num==1)||(%Num==99)){ Exec("./client/C_HuoDong/SL_C_01_JinRiMuBiao.cs"); }
	if ((%Num==2)||(%Num==99)){ Exec("./client/C_HuoDong/SL_C_02_XianZhuanLu.cs"); }
	if ((%Num==3)||(%Num==99)){ Exec("./client/C_HuoDong/SL_C_03_MissionDuiHuaKuang.cs"); }
	if ((%Num==4)||(%Num==99)){ Exec("./client/C_HuoDong/SL_C_04_FuBenLiuChengXianShi.cs"); }
	if ((%Num==5)||(%Num==99)){ Exec("./client/C_HuoDong/SL_C_05_FinshEveryWnd.cs"); }
	if ((%Num==6)||(%Num==99)){ Exec("./client/C_HuoDong/SL_C_06_YunYingHuoDong.cs"); }
	if ((%Num==7)||(%Num==99)){ Exec("./client/C_HuoDong/SL_C_07_OrgActivity.cs"); }
}

//■■■■■■■■■■■■客户端启动加载项■■■■■■■■■■■■
UPCS(99);

function u()
{
	UPCS(99);
	ClientOnSptAction(12, 0);
}
//Exec("E:/SL_MiniClient/Game/gameres/Data/Quest/ClientMission.cs");