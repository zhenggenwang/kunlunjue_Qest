//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//部分只记录 1 和 0值的活动记录   这个编号 必须按顺序 填 不能跳不能跳 填在C_S_activityrecord下面
//
//==================================================================================


//■■■■■■■■■■■【记录函数】■■■■■■■■■■■■■■■■■■■■■■
//%bit:记录编号
//SetSrc( %Player, 1);
function SetSrc(%Player,%bit)//%bit 对应的编号
{
	//echo( "%bit:记录编号%bit====" @ %bit @ "  $Src_ReturnTime_ActivityID==" @ $Src_ReturnTime_ActivityID[ %bit ] );
	%ActivityID = GetWord($Src_ReturnTime_ActivityID[%bit],0);
	%Resut =  GetWord($Src_ReturnTime_ActivityID[%bit],1);
	if (%ActivityID <= 0 || %Resut < 1 || %Resut > 30)
	{
		SendOneScreenMessage(2,"活动数据错误，错误编号" @ $Src_ReturnTime_ActivityID[%bit],%Player);
		//echo("活动数据错误，错误编号" @  $Src_ReturnTime_ActivityID[%bit]);
		return;
	}
	//echo( "============= " @  %ActivityID  @ " ====  " @  %Resut @  "  ==============="  @ "$Src_ReturnTime_ActivityID[ %bit ]===" @ $Src_ReturnTime_ActivityID[ %bit ] );

	%NumbersA = GetAct(%Player,%ActivityID,0);
	%NumbersB = GetAct(%Player,%ActivityID,1);
	//echo( "记录前A ===" @ GetBitNum( %NumbersA ) @ "   === " @ %NumbersA );// 拆开看看的函数
	//echo( "记录前B ===" @ GetBitNum( %NumbersB ) @ "   === " @ %NumbersB );// 拆开看看的函数

	if (%Resut <= 15)
	{
		%NumbersA = SetBit(%NumbersA,%Resut -1);
		%NumbersB = %NumbersB;
	}
	else
	{
		%NumbersA = %NumbersA;
		%NumbersB = SetBit(%NumbersB,%Resut -16);
	}
	//echo( "记录后A ===" @ GetBitNum( %NumbersA ) @ "   === " @ %NumbersA );// 拆开看看的函数
	//echo( "记录后B ===" @ GetBitNum( %NumbersB ) @ "   === " @ %NumbersB );// 拆开看看的函数

	SetAct(%Player,%ActivityID,%NumbersA,%NumbersB);
}
function DelSrc(%Player,%bit)//%bit 对应的编号
{
	%ActivityID = GetWord($Src_ReturnTime_ActivityID[%bit],0);
	%Resut =  GetWord($Src_ReturnTime_ActivityID[%bit],1);
	if (%ActivityID <= 0 || %Resut < 1 || %Resut > 30)
	{
		SendOneScreenMessage(2,"活动数据错误，错误编号" @ $Src_ReturnTime_ActivityID[%bit],%Player);
		//echo("活动数据错误，错误编号" @  $Src_ReturnTime_ActivityID[%bit]);
		return;
	}
	//echo( "============= " @  %ActivityID  @ " ====  " @  %Resut @  "  ===============" );

	%NumbersA = GetAct(%Player,%ActivityID,0);
	%NumbersB = GetAct(%Player,%ActivityID,1);
	//echo( "记录前A ===" @ GetBitNum( %NumbersA ) @ "   === " @ %NumbersA );// 拆开看看的函数
	//echo( "记录前B ===" @ GetBitNum( %NumbersB ) @ "   === " @ %NumbersB );// 拆开看看的函数

	if (%Resut <= 15)
	{
		%NumbersA = ClearBit(%NumbersA,%Resut -1);
		%NumbersB = %NumbersB;
	}
	else
	{
		%NumbersA = %NumbersA;
		%NumbersB = ClearBit(%NumbersB,%Resut -16);
	}
	//echo( "记录后A ===" @ GetBitNum( %NumbersA ) @ "   === " @ %NumbersA );// 拆开看看的函数
	//echo( "记录后B ===" @ GetBitNum( %NumbersB ) @ "   === " @ %NumbersB );// 拆开看看的函数

	SetAct(%Player,%ActivityID,%NumbersA,%NumbersB);
}

//-----------------------------------其他ACT的记录---------------------------
function SetAct(%Player,%ActivityID,%CA_1,%CA_2)
{
	if ($PlayGameReturnTime[%ActivityID] $= "")
	{
		//echo("活动数据错误，未找到编号为" @ %ActivityID @ "的活动数据，暂时设定为永不重置");
		SendOneScreenMessage(2,"活动数据错误，未找到编号为" @ %ActivityID @ "的活动数据",%Player);

		%Player.ChangeActivity(%ActivityID,%CA_1,%CA_2,0);
	}
	else
	{
		if ((%CA_1 >= 65535)||(%CA_2 >= 65535))
		{
			SendOneScreenMessage(2,"活动数据错误，编号" @ %ActivityID @ "的活动数据上限异常",%Player);
			//echo("活动数据错误，编号" @ %ActivityID @ "的活动数据上限异常，传进来的值为"@%CA_1@"+"@%CA_2);
		}

		%Player.ChangeActivity(%ActivityID,%CA_1,%CA_2,$PlayGameReturnTime[%ActivityID]);
	}
}

//■■■■■■■■■■■【记录函数】■■■■■■■■■■■■■■■■■■■■■■

