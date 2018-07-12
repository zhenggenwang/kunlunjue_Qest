//■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■任务是否在NPC身上显示■■■■■■■■■■■■■



//■■■■■■■■■■■■任务是否在NPC身上显示■■■■■■■■■■■■■
//－－－可接任务－－－
//－－－中途任务－－－
//－－－可交任务－－－


//－－－可接任务－－－
function Mission_Begin_SeeOption(%Player,%Mid)
{
	//特殊处理 接受任务选项前置判断  返回true不可接
	//echo("%Mid==" @ %Mid @ "   " @ GetMissionData(%Mid, $Mission_Data_SeeLvA) @ " " @ GetMissionData(%Mid, $Mission_Data_SeeLvZ));
	
	switch (%Mid)
	{
		case 20028:
			return GetSrc(%Player, 59);
		case 20151:
			return GetSrc(%Player, 197);
		case 20149:
			return GetAct(%player, 4015, 0) > 9 ? 1 : 0;
		case 20036:return MissionShengWang(%Player, %Mid, 0);
		case 20037:return MissionShengWang(%Player, %Mid, 300000);
		case 20038:return MissionShengWang(%Player, %Mid, 1500000);
		case 20039:return MissionShengWang(%Player, %Mid, 3000000);
		case 20040:return MissionShengWang(%Player, %Mid, 7500000);
		case 20041:return MissionShengWang(%Player, %Mid, 99999999);
		case 20042:return MissionShengWang(%Player, %Mid, 99999999);
		case 20043:return MissionShengWang(%Player, %Mid, 0);
		case 20044:return MissionShengWang(%Player, %Mid, 300000);
		case 20045:return MissionShengWang(%Player, %Mid, 1500000);
		case 20046:return MissionShengWang(%Player, %Mid, 3000000);
		case 20047:return MissionShengWang(%Player, %Mid, 7500000);
		case 20048:return MissionShengWang(%Player, %Mid, 99999999);
		case 20049:return MissionShengWang(%Player, %Mid, 99999999);
		case 20050:return MissionShengWang(%Player, %Mid, 0);
		case 20051:return MissionShengWang(%Player, %Mid, 300000);
		case 20052:return MissionShengWang(%Player, %Mid, 1500000);
		case 20053:return MissionShengWang(%Player, %Mid, 3000000);
		case 20054:return MissionShengWang(%Player, %Mid, 7500000);
		case 20055:return MissionShengWang(%Player, %Mid, 99999999);
		case 20056:return MissionShengWang(%Player, %Mid, 99999999);
		case 20057:return MissionShengWang(%Player, %Mid, 0);
		case 20058:return MissionShengWang(%Player, %Mid, 300000);
		case 20059:return MissionShengWang(%Player, %Mid, 1500000);
		case 20060:return MissionShengWang(%Player, %Mid, 3000000);
		case 20061:return MissionShengWang(%Player, %Mid, 7500000);
		case 20062:return MissionShengWang(%Player, %Mid, 99999999);
		case 20063:return MissionShengWang(%Player, %Mid, 99999999);
		case 20064:return MissionShengWang(%Player, %Mid, 0);
		case 20065:return MissionShengWang(%Player, %Mid, 300000);
		case 20066:return MissionShengWang(%Player, %Mid, 1500000);
		case 20067:return MissionShengWang(%Player, %Mid, 3000000);
		case 20068:return MissionShengWang(%Player, %Mid, 7500000);
		case 20069:return MissionShengWang(%Player, %Mid, 99999999);
		case 20070:return MissionShengWang(%Player, %Mid, 99999999);
		default:
			//echo("%Mid==" @ %Mid @ "   " @ GetMissionData(%Mid, $Mission_Data_SeeLvA) @ " " @ GetMissionData(%Mid, $Mission_Data_SeeLvZ));
			return false;
	}
	return false;
}

//－－－中途任务－－－
function Mission_midway_SeeOption(%Player,%Mid)
{
	return false;
}

//－－－可交任务－－－
function Mission_End_SeeOption(%Player,%Mid)
{
	return false;
}



function MissionTanKuang()
{
	%Player = GetPlayer();
	%TxtA = "<t> 武魂可大大提升属性，让你在战斗中所向披靡。</t><b/>";
	Dialog_OnlyOK_COVER.setVisible(true);
	Dialog_OnlyOK_COVER_Content.setContent(%TxtA);
	Dialog_OnlyOK_COVER_OKBTN.command = "Dialog_OnlyOK_COVER.setVisible(0);OpenOrCloseXingXiangWnd();";
}


function MissionShengWang(%Player, %Mid,%ShengWang)
{
	if (GetSrc(%Player, 198) == 1)//今天做过了
		return true;

	%class0 = %player.GetClasses(0);
	switch (%class0)
	{
		case 1:%HvaeShengWang = GetPrestige(%Player, 1, 1);
		case 2:%HvaeShengWang = GetPrestige(%Player, 1, 2);
		case 3:%HvaeShengWang = GetPrestige(%Player, 1, 3);
		case 4:%HvaeShengWang = GetPrestige(%Player, 1, 4);
		case 5:%HvaeShengWang = GetPrestige(%Player, 1, 5);
	}
	if (%HvaeShengWang < %ShengWang)
		return true;

	return false;
}











