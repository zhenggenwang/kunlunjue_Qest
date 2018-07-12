//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//界面动画触发    界面按钮触发
//==================================================================================

//■■■■■■■■■■■界面动画触发■■■■■■■■■■■■■■■■■■■■■■



//■■■■■■■■■■■界面动画触发■■■■■■■■■■■■■■■■■■■■■■
function clew_Spirit_BottomControlWndGui()
{
	$clew_Spirit_BottomControlWndGui = 0;
}
function EscapeMovieModeExit()//打断电影触发
{
	Schedule(1000,0,"DianYingJieShu_ChuFa");
}
function DianYingJieShu_ChuFa()
{
	if (GetPlayer().IsAcceptedMission(10341))
	{
		MovieModeStar_10100010(7);
	}
}

function Spt_MovieModeStar(%dialogid)
{
	GameMoviePlayer_Lyric.setcontent("");
	%Player = GetPlayer();
	if (%Player > 0)
		$ClientPlayerName = %Player.GetObjectname();

	//echo("%dialogid =====================" @ %dialogid);
	%FuncName = "MovieModeStar_" @ %dialogid;
	if (isFunction(%FuncName))
		return Call(%FuncName,0);
}
function Spt_MovieModeExit(%dialogid)
{
	//echg( "%dialogid =====================" @ %dialogid );
	//if ( getplayer().gettriggerid() $= "810100101")
	//	ClientOnSptAction( 9, 0 );
	Cancel(GetPlayer().MovieRecord);
	ClientOnSptAction(10,%dialogid);	//通讯服务器
}

//--------------------10001 死里逃生------------------ 
//$Get_Dialog_GeShi[ 22401 ]白色 左对齐
//95.3344,125.25,108.298
function MovieModeStar_10100005(%index)
{
	%Talk1 = "<t f='隶书' m='0' n='24' h ='0' c='0xbfff00ff' o='0x010101ff'>" @ $ClientPlayerName @ "：</t>";			//角色名;
	%Talk2 = "<t f='隶书' m='0' n='24' h ='0' gct='0xffff00ff' gcb='0xd9680dff'>林旒歆：</t>";
	%Talk3 = "<t f='隶书' m='0' n='24' h ='0' gct='0xffff00ff' gcb='0xd9680dff'>杨子石：</t>";
	switch (%index)
	{
		case 0:
			%Time = 2000;
		case 1:
			%Time = 3000;
			%Txt = %Talk2 @ $Get_Dialog_GeShi[22401] @ "咦，真来了，我还以为要昆仑城的莫瞎子满口胡言，要害我白等一场呢！</t>";
			//echo( %Txt );
		case 2:
			%Time = 3000;
			%Txt = %Talk3 @ $Get_Dialog_GeShi[22401] @  "小师妹，不得瞎说，莫前辈神通广大，莫被听见，省的……</t>";
		case 3:
			%Time = 3000;
			%Txt = %Talk1 @ $Get_Dialog_GeShi[22401] @  "呃……这是？</t>";
		case 4:
			%Time = 3000;
			%Txt = %Talk2 @ $Get_Dialog_GeShi[22401] @  "啧啧，师兄，你看着鬓发高耸，直插天际，衣服奇佳的根骨面相，还真被瞎……莫前辈说中了呢！</t>";
		case 5:
			%Time = 3000;
			%Txt = %Talk3 @ $Get_Dialog_GeShi[22401] @  "……英雄少年，你怎弄的这一身狼狈？</t>";
		case 6:
			%Time = 3000;
			%Txt = %Talk1 @ $Get_Dialog_GeShi[22401] @  "这是何处？你们是谁？我又是谁？</t>";
		case 7:
			%Time = 3000;
			%Txt = %Talk3 @ $Get_Dialog_GeShi[22401] @  "来，少侠上前，容我细细道来</t>";

		case 8:
			%Time = 0;
			GameMoviePlayerExit(0);
			GameMoviePlayer_Lyric.setcontent("");
			SvrEventTransporClient(GetPlayer(),1);
			//OpenDouFuGan( 10001 );
	}
	if (%Txt !$= "")
		GameMoviePlayer_Lyric.setcontent($Get_Dialog_GeShi[21802]  @ %Txt @ "</t>");
	if (%Time > 0)
	{
		Cancel($MovieRecord);
		$MovieRecord  = Schedule(%Time,0,"MovieModeStar_10100005",%index++);
	}

}
//蓬莱禁地剧情对话
function MovieModeStar_10100010(%index)
{
	%Talk1 = "<t f='隶书' m='0' n='24' h ='0' c='0xbfff00ff' o='0x010101ff'>" @ $ClientPlayerName @ "</t>";			//角色名;
	%Talk2 = "<t f='隶书' m='0' n='24' h ='0' gct='0xffff00ff' gcb='0xd9680dff'>玄仁：</t>";
	%Talk3 = "<t f='隶书' m='0' n='24' h ='0' gct='0xffff00ff' gcb='0xd9680dff'>神秘人：</t>";
	//echo("%index ==AAAAA==" @%index);
	switch (%index)
	{
		case 0:
			%Time = 2000;
		case 1:
			%Time = 3000;
			%Txt = %Talk3 @ $Get_Dialog_GeShi[22401] @ "啊，如此美妙的味道，我又闻到了，这是送上门来的美食吗？</t>";
			//echo( %Txt );
		case 2:
			%Time = 3000;
			%Txt = %Talk1 @ $Get_Dialog_GeShi[22401] @  "：谁？你是谁？是人是妖？何方妖魔鬼怪！</t>";
		case 3:
			%Time = 3000;
			%Txt = %Talk2 @ $Get_Dialog_GeShi[22401] @  "放肆，孽畜，还不知悔改！</t>";
		case 4:
			%Time = 3000;
			%Txt = %Talk3 @ $Get_Dialog_GeShi[22401] @  "呵哈哈哈，你们能耐我何？你们灭不了我！只会让我更强大！早晚我会脱困，毁掉这一切，哈哈哈哈！</t>";
		case 5:
			%Time = 3000;
			%Txt = %Talk3 @ $Get_Dialog_GeShi[22401] @  "给你们尝尝我新炼制的小玩意儿，灭魂大阵，现！只要我身不死，大阵不破！</t>";
		case 6:
			%Time = 3000;
			%Txt = %Talk2 @ $Get_Dialog_GeShi[22401] @  "不好！</t>" @ %Talk1 @ "<t>，此乃蓬莱神兵，先行借你护身，一切小心行事。</t>";
		case 7:
			%Time = 0;
			GameMoviePlayerExit(0);
			GameMoviePlayer_Lyric.setcontent("");
			Schedule(2500,0,"ClientOnSptAction",24,0);//通讯服务器
	}
	if (%Txt !$= "")
		GameMoviePlayer_Lyric.setcontent($Get_Dialog_GeShi[21802]  @ %Txt @ "</t>");
	if (%Time > 0)
	{
		Cancel($MovieRecord);
		$MovieRecord  = Schedule(%Time,0,"MovieModeStar_10100010",%index++);
	}

}

function MovieModeStar_10351(%index)
{
	%Talk1 = "<t f='隶书' m='0' n='24' h ='0' c='0xbfff00ff' o='0x010101ff'>" @ $ClientPlayerName @ "</t>";			//角色名;
	%Talk2 = "<t f='隶书' m='0' n='24' h ='0' gct='0xffff00ff' gcb='0xd9680dff'>玄仁：</t>";
	%Talk3 = "<t f='隶书' m='0' n='24' h ='0' gct='0xffff00ff' gcb='0xd9680dff'>神秘人：</t>";
	switch (%index)
	{
		case 0:
			%Time = 2000;
			SetCombatAssistant(0);//停止挂机
		case 1:
			%Time = 3000;
			%Txt = %Talk3 @ $Get_Dialog_GeShi[22401] @ "这不可能！为何我法力消散了，你是到底谁？我要吞了你！！</t>";
			//echo( %Txt );
		case 2:
			%Time = 2000;
			%Txt = %Talk2 @ $Get_Dialog_GeShi[22401] @  "孽畜，还不知悔改…………</t>";
		case 3:
			%Time = 2000;
			%Txt = %Talk2 @ $Get_Dialog_GeShi[22401] @  "哎，冤孽啊！</t>" @ %Talk1 @ "<t>，我们走</t>";

		case 4:
			%Time = 1000;
			GameMoviePlayerExit(0);
			GameMoviePlayer_Lyric.setcontent("");
			Schedule(1000,0,"ClientOnSptAction",24,2);//通讯服务器

	}
	if (%Txt !$= "")
		GameMoviePlayer_Lyric.setcontent($Get_Dialog_GeShi[21802]  @ %Txt @ "</t>");
	if (%Time > 0)
	{
		Cancel($MovieRecord);
		$MovieRecord  = Schedule(%Time,0,"MovieModeStar_10351",%index++);
	}

}

//■■■■■■■■■■■界面动画触发■■■■■■■■■■■■■■■■■■■■■■