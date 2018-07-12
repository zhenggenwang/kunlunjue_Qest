//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//紫星传功
//
//
//
//==================================================================================

//■■■■【紫星传功】■■■■【领取前置】■■■■■■
//■■■■【紫星传功】■■■■【领取过程】■■■■■■
//■■■■【紫星传功】■■■■【完成处理】■■■■■■





//■■■■【紫星传功】■■■■【领取过程】■■■■■■
function Mission_Begin_Process_20150(%Npc,%Player,%Conv,%Param,%Mid)
{
	%Level = %Player.GetLevel();
	if (%Level <= 44) %ItemID = 105109321;
	else if (%Level <= 59) %ItemID = 105109322;
	else if (%Level <= 74) %ItemID = 105109323;
	else if (%Level <= 89) %ItemID = 105109324;
	else  %ItemID = 105109325;
	%Player.PutItem(%ItemID,-10);
	if (%Player.Additem(1,%Mid))
	{
		if (%Level <= 44)
			%NpcID = GetRandom(411011001,411011012);
		else
			%NpcID = GetRandom(411011001,411011012);
		%Player.SetMissionFlag(%Mid,3100,%NpcID);
		%Player.SetMissionFlag(%Mid,3200,40);
		%Player.SetMissionFlag(%Mid,3300,0);
		%Player.SetMissionFlag(%Mid,9100,1);
		%Act0 =  GetAct(%Player,4098,0);
		%Act1 =  GetAct(%Player,4098,1);
		%Act0++;
		SetAct(%Player,4098,%Act0,%Act1);
		Schedule(500,0,"eval",%Player @ ".updatemission(" @ %Mid @ "); ");
	}
}
//■■■■【紫星传功】■■■■【领取过程】■■■■■■


//■■■■【紫星传功】■■■■【完成处理】■■■■■■
function Mission_End_Process_20150(%Npc,%Player,%Conv,%Param,%Mid)
{
	%OneExp = $Monster_Exp[%Player.Getlevel(),1];
	%Exp = %OneExp * 1000;
	AllAddExp(%Player,%Exp);

	AddAchievementWatch(%Player,0,33,1);//记录成就
}
//■■■■【紫星传功】■■■■【完成处理】■■■■■■