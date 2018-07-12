//=============================================================================
// 文档说明:帮派活动
// 创建人: Irelia
// 创建时间:2018-03-19

// 修改人: 
// 修改时间: 
//=============================================================================


//■■■■【帮派活动界面】■■■■帮派工资领取■■■■■■■■■
//■■■■【帮派活动界面】■■■■设置和获取记录■■■■■■■■

//■■■■【帮派活动界面】■■■■设置和获取记录■■■■■■■■
function SetOrgActivityRecord(%Player, %index)
{
	switch (%index)
	{
		case 0: SetSrc(%Player, 195);//"每日工资";
		case 1: SetSrc(%Player, 196);//"帮派捐献";
		case 2: SetSrc(%Player, 59);//"秘咒除魔";
		case 3: SetSrc(%Player, 197);//"收集灵魄";
		case 4: //"妖灵天宫";
			%Act0 = GetAct(%Player, 4102, 0);
			%Act1 = GetAct(%Player, 4102, 1);
			%Act0++;
			SetAct(%Player, 4102, %Act0, %Act1);
		case 5: //"封神秘境";
			%Act0 = GetAct(%Player, 4103, 0);
			%Act1 = GetAct(%Player, 4103, 1);
			%Act0++;
			SetAct(%Player, 4103, %Act0, %Act1);
		case 6: SetSrc(%Player, 3);//"群英汇聚";
		case 7: //"云罗镜";  在采集宝箱的时候已经加过了
		case 8: //"帮会七重天";  单独写
		case 9: //"封魔城攻城战";
		case 10://"领地战";
	}
	HelpDirectByIndex(%Player.GetPlayerID(), 31);	//通讯客户端
}
function SetOrgActivitySenvenSky(%Player, %index)//帮派7重天的记录
{
	%Act0 = GetAct(%Player, 4104, 0);
	%Act1 = GetAct(%Player, 4104, 1);
	%Act0 = SetBit(%Act0, %index);
	SetAct(%Player, 4104, %Act0, %Act1);
	HelpDirectByIndex(%Player.GetPlayerID(), 31);	//通讯客户端
}
function GetOrgActivityRecordServer(%Player, %index)
{
	switch (%index)
	{
		case 0: return GetSrc(%Player, 195);//"每日工资";
		case 1: return GetSrc(%Player, 196);//"帮派捐献";
		case 2: return GetSrc(%Player, 59);//"秘咒除魔";
		case 3: return GetSrc(%Player, 197);//"收集灵魄";
		case 4: return GetAct(%Player, 4102, 0) * 1;//"妖灵天宫";
		case 5: return GetAct(%Player, 4103, 0) * 1;//"封神秘境";
		case 6: return GetSrc(%Player, 3);//"群英汇聚";
		case 7: return GetSrc(%Player, 191) + GetSrc(%Player, 192) + GetSrc(%Player, 193) + GetSrc(%Player, 194);//"云罗镜";
		case 8: //"帮会七重天";
			%Act0 = GetAct(%Player, 4104, 0) * 1;
			if (%Act0 == 0)
				return 0;
			for (%i = 1; %i<= 9; %i++)
			{
				if (!CheckBit(%num, %bit))
				{
					%Record = %i - 1;
					break;
				}
			}
			return %Record;
		case 9: //"封魔城攻城战";
		case 10://"领地战";
	}
}
//■■■■【帮派活动界面】■■■■设置和获取记录■■■■■■■■



//■■■■【帮派活动界面】■■■■帮派活动奖励发放■■■■■■■■■
function GetOrgActivityWages(%Player,%index)
{
	%Recrod = GetOrgActivityRecordServer(%Player, %index);
	switch (%index)
	{
		case 0: //"每日工资";
			if (%Recrod != 0)
				return;
			SetOrgActivityRecord(%Player, %index);
			AllAddExp(%Player, 10000);
			AddFamily_HuoYue(%Player, 10000);//临时测试
			%Player.Addmoney(10000, 2, 19, %index);
		case 1: //"帮派捐献";
			if (%Recrod != 0)
				return;
			SetOrgActivityRecord(%Player, %index);
			AllAddExp(%Player, 10000);
			AddFamily_HuoYue(%Player, 30);
		case 2: //"秘咒除魔";
			SetOrgActivityRecord(%Player, %index);
			%Level = %Player.GetLevel();
			if (%Level <= 45) %Exp= 60000;
			else if (%Level <= 60) %Exp= 99200;
			else if (%Level <= 75) %Exp= 154400;
			else if (%Level <= 90) %Exp= 230400;
			else if (%Level <= 100)%Exp= 331200;
			AllAddExp(%Player, %Exp);
			AddFamily_HuoYue(%Player, 50);
		case 3: //"收集灵魄";
			SetOrgActivityRecord(%Player, %index);
			%Level = %Player.GetLevel();
			if (%Level <= 45) %Exp= 60000;
			else if (%Level <= 60) %Exp= 99200;
			else if (%Level <= 75) %Exp= 154400;
			else if (%Level <= 90) %Exp= 230400;
			else if (%Level <= 100)%Exp= 331200;
			AllAddExp(%Player, %Exp);
			AddFamily_HuoYue(%Player, 50);
		case 4: //"妖灵天宫";
			SetOrgActivityRecord(%Player, %index);
		case 5: //"封神秘境";
			SetOrgActivityRecord(%Player, %index);
			AddFamily_HuoYue(%Player, 100);
		case 6: //"群英汇聚";
			SetOrgActivityRecord(%Player, %index);
			AddFamily_HuoYue(%Player, 30);
		case 7: //"云罗镜";
			SetOrgActivityRecord(%Player, %index);
		case 8: //"帮会七重天";
			SetOrgActivitySenvenSky(%Player, %index);
		case 9: //"封魔城攻城战";
		case 10://"领地战";
	}
	
}
//■■■■【帮派活动界面】■■■■帮派活动奖励发放■■■■■■■■■