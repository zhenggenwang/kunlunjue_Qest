//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//���涯������    ���水ť����
//==================================================================================

//�������������������������涯��������������������������������������������������



//�������������������������涯��������������������������������������������������
function clew_Spirit_BottomControlWndGui()
{
	$clew_Spirit_BottomControlWndGui = 0;
}
function EscapeMovieModeExit()//��ϵ�Ӱ����
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
	ClientOnSptAction(10,%dialogid);	//ͨѶ������
}

//--------------------10001 ��������------------------ 
//$Get_Dialog_GeShi[ 22401 ]��ɫ �����
//95.3344,125.25,108.298
function MovieModeStar_10100005(%index)
{
	%Talk1 = "<t f='����' m='0' n='24' h ='0' c='0xbfff00ff' o='0x010101ff'>" @ $ClientPlayerName @ "��</t>";			//��ɫ��;
	%Talk2 = "<t f='����' m='0' n='24' h ='0' gct='0xffff00ff' gcb='0xd9680dff'>���짣�</t>";
	%Talk3 = "<t f='����' m='0' n='24' h ='0' gct='0xffff00ff' gcb='0xd9680dff'>����ʯ��</t>";
	switch (%index)
	{
		case 0:
			%Time = 2000;
		case 1:
			%Time = 3000;
			%Txt = %Talk2 @ $Get_Dialog_GeShi[22401] @ "�ף������ˣ��һ���ΪҪ���سǵ�ĪϹ�����ں��ԣ�Ҫ���Ұ׵�һ���أ�</t>";
			//echo( %Txt );
		case 2:
			%Time = 3000;
			%Txt = %Talk3 @ $Get_Dialog_GeShi[22401] @  "Сʦ�ã�����Ϲ˵��Īǰ����ͨ���Ī��������ʡ�ġ���</t>";
		case 3:
			%Time = 3000;
			%Txt = %Talk1 @ $Get_Dialog_GeShi[22401] @  "���������ǣ�</t>";
		case 4:
			%Time = 3000;
			%Txt = %Talk2 @ $Get_Dialog_GeShi[22401] @  "������ʦ�֣��㿴���޷����ʣ�ֱ����ʣ��·���ѵĸ������࣬���汻Ϲ����Īǰ��˵�����أ�</t>";
		case 5:
			%Time = 3000;
			%Txt = %Talk3 @ $Get_Dialog_GeShi[22401] @  "����Ӣ�����꣬����Ū����һ���Ǳ���</t>";
		case 6:
			%Time = 3000;
			%Txt = %Talk1 @ $Get_Dialog_GeShi[22401] @  "���Ǻδ���������˭��������˭��</t>";
		case 7:
			%Time = 3000;
			%Txt = %Talk3 @ $Get_Dialog_GeShi[22401] @  "����������ǰ������ϸϸ����</t>";

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
//�������ؾ���Ի�
function MovieModeStar_10100010(%index)
{
	%Talk1 = "<t f='����' m='0' n='24' h ='0' c='0xbfff00ff' o='0x010101ff'>" @ $ClientPlayerName @ "</t>";			//��ɫ��;
	%Talk2 = "<t f='����' m='0' n='24' h ='0' gct='0xffff00ff' gcb='0xd9680dff'>���ʣ�</t>";
	%Talk3 = "<t f='����' m='0' n='24' h ='0' gct='0xffff00ff' gcb='0xd9680dff'>�����ˣ�</t>";
	//echo("%index ==AAAAA==" @%index);
	switch (%index)
	{
		case 0:
			%Time = 2000;
		case 1:
			%Time = 3000;
			%Txt = %Talk3 @ $Get_Dialog_GeShi[22401] @ "������������ζ���������ŵ��ˣ�����������������ʳ��</t>";
			//echo( %Txt );
		case 2:
			%Time = 3000;
			%Txt = %Talk1 @ $Get_Dialog_GeShi[22401] @  "��˭������˭�������������η���ħ��֣�</t>";
		case 3:
			%Time = 3000;
			%Txt = %Talk2 @ $Get_Dialog_GeShi[22401] @  "���������󣬻���֪�ڸģ�</t>";
		case 4:
			%Time = 3000;
			%Txt = %Talk3 @ $Get_Dialog_GeShi[22401] @  "�ǹ����������������ҺΣ����������ң�ֻ�����Ҹ�ǿ�������һ��������ٵ���һ�У�����������</t>";
		case 5:
			%Time = 3000;
			%Txt = %Talk3 @ $Get_Dialog_GeShi[22401] @  "�����ǳ����������Ƶ�С��������������֣�ֻҪ�������������ƣ�</t>";
		case 6:
			%Time = 3000;
			%Txt = %Talk2 @ $Get_Dialog_GeShi[22401] @  "���ã�</t>" @ %Talk1 @ "<t>������������������н��㻤��һ��С�����¡�</t>";
		case 7:
			%Time = 0;
			GameMoviePlayerExit(0);
			GameMoviePlayer_Lyric.setcontent("");
			Schedule(2500,0,"ClientOnSptAction",24,0);//ͨѶ������
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
	%Talk1 = "<t f='����' m='0' n='24' h ='0' c='0xbfff00ff' o='0x010101ff'>" @ $ClientPlayerName @ "</t>";			//��ɫ��;
	%Talk2 = "<t f='����' m='0' n='24' h ='0' gct='0xffff00ff' gcb='0xd9680dff'>���ʣ�</t>";
	%Talk3 = "<t f='����' m='0' n='24' h ='0' gct='0xffff00ff' gcb='0xd9680dff'>�����ˣ�</t>";
	switch (%index)
	{
		case 0:
			%Time = 2000;
			SetCombatAssistant(0);//ֹͣ�һ�
		case 1:
			%Time = 3000;
			%Txt = %Talk3 @ $Get_Dialog_GeShi[22401] @ "�ⲻ���ܣ�Ϊ���ҷ�����ɢ�ˣ����ǵ���˭����Ҫ�����㣡��</t>";
			//echo( %Txt );
		case 2:
			%Time = 2000;
			%Txt = %Talk2 @ $Get_Dialog_GeShi[22401] @  "���󣬻���֪�ڸġ�������</t>";
		case 3:
			%Time = 2000;
			%Txt = %Talk2 @ $Get_Dialog_GeShi[22401] @  "����ԩ������</t>" @ %Talk1 @ "<t>��������</t>";

		case 4:
			%Time = 1000;
			GameMoviePlayerExit(0);
			GameMoviePlayer_Lyric.setcontent("");
			Schedule(1000,0,"ClientOnSptAction",24,2);//ͨѶ������

	}
	if (%Txt !$= "")
		GameMoviePlayer_Lyric.setcontent($Get_Dialog_GeShi[21802]  @ %Txt @ "</t>");
	if (%Time > 0)
	{
		Cancel($MovieRecord);
		$MovieRecord  = Schedule(%Time,0,"MovieModeStar_10351",%index++);
	}

}

//�������������������������涯��������������������������������������������������