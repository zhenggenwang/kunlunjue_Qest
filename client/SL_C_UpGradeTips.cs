/*
================================================================================
ע�����нű���ͷ������ע�����ű��Ĵ���˵������


Author: Irelia
Date  : 20170919
================================================================================
*/
//�������������򿪸�����վ�ĺ�����������������������
//�������������������߰����ȱʧ��������������������


//�������������򿪸�����վ�ĺ�����������������������
function OpenGuanFangWeb()
{
	shellExecute("https://klj.wdgame.com.cn/","","");
}
//�������������򿪸�����վ�ĺ�����������������������


//�������������������߰����ȱʧ��������������������

//�ر������Ƽ��������
function CloseBusinessCityBuyHotItemWnd()
{
	return;
	if (BusinessCityBuyHotItemWnd.isVisible())
	{
		BusinessCityBuyHotItemWnd.setVisible(0);
		$MarketHotItemPrice = 0;
		BindOrUnBindSomeHotButton(1);
	}
}
function GetPlayerOnLine()
{

}
//�����������
function ClosePlayerCommand()
{
	ObjectIcon_PlayerCommand.setvisible(0);
	setBackgroundUV(-1);
}
//��ʾ�������
function OpenPlayerCommand()
{
	ObjectIcon_PlayerCommand.setvisible(1);
}

function setBackgroundUV(%intensity)
{
	switch (%intensity)
	{
		case 0:TargetIconGui.BackgroundUVBoundary = "432 0 240 99";
		case 1:TargetIconGui.BackgroundUVBoundary = "432 99 240 99";
		case 2:TargetIconGui.BackgroundUVBoundary = "432 198 240 99";
		case 3:TargetIconGui.BackgroundUVBoundary = "432 297 240 99";
		case 4:TargetIconGui.BackgroundUVBoundary = "432 396 240 99";
		default:TargetIconGui.BackgroundUVBoundary = "0 258 240 99";
	}
}
function OnExitTrigger()//�������򴥷�
{

}
function OpenOrCloseFestivity_use()
{

}
function setGetLingQiDanDailyBtn(%on)
{
	if (%on) //�����
	{
		FightAssistant_GetLingQiDanDailyBtn.setText("<t c=\'0xafafafff\' u=\'0xafafafff\'>�����ȡ10��������(����ȡ)</t>");
		FightAssistant_GetLingQiDanDailyBtn.setActive(0);
	}
	else
	{
		FightAssistant_GetLingQiDanDailyBtn.setText("<t c=\'0x00ff00ff\' u=\'0x00ff00ff\'>�����ȡ10��������(ÿ��)</t>");
		FightAssistant_GetLingQiDanDailyBtn.setActive(1);
	}
}
function JinMaiPointHoleColor(%slot,%count)
{
	//%slot,Ѩλ		%count,ɢѨ����

	if (%slot == 1){ %JiLv = %Count * 10; }
	else if (%slot == 2){ %JiLv = %Count * 10; }
	else if (%slot == 3){ %JiLv = %Count * 10; }
	else if (%slot == 4){ %JiLv = %Count * 10; }
	else if (%slot == 5){ %JiLv = %Count * 10; }

	if (%JiLv > 100)
		return "100%";

	return %JiLv @ "%";
}

function ShowBagInfoButtonEft()//����µ�װ��ʱ
{

}
function CreateChangeMapBtn()
{

}
function AddMiniVIPPrerogativeGiftItem(%i,%j)
{
	return;
}
function OpenPetAttack()
{

}
//�������ر��ؾ�
function ActionMap_ZaiJu_Change(%Change)
{
	//echo("%Change = " @ %Change);
	if (PanleFastShortcut_2.isvisible())
		$SAVELastRow1=1;
	if (PanleFastShortcut_3.isvisible())
		$SAVELastRow2=1;
	if (FloatingSkillShortCutWnd_1.isvisible())
		$SAVELastRow3=1;
	if (FloatingSkillShortCutWnd2_1.isvisible())
		$SAVELastRow4=1;

	$LastSelectModeId = OperateSettingWndPopUpMenu.getSelected();

	if (%Change == 1)
	{
		$CurSelectModeId = 4;
		PanleFastShortcut_Ext1.setVisible(0);
		PanleFastShortcut_2.setVisible(0);
		PanleFastShortcut_3.setVisible(0);
		FloatingSkillShortCutWnd_1.setVisible(0);
		FloatingSkillShortCutWnd2_1.setVisible(0);
		PanleFastShortcut_ZaiJu_Ext1.setVisible(1);
		BottomPointUpper.SetActive(0);
		BottomPointdown.SetActive(0);
		$ModelZaiJu=1;
		//ɾ������Ԫ��
		switch ($LastSelectModeId)
		{
			case 0:ActionMap_Normal.pop();
			case 1:ActionMap_Chat.pop();
			case 2:ActionMap_Battle.pop();
			case 3:ActionMap_Custom.pop();
		}

		//���Ԫ��
		ActionMap_ZaiJu.push();
	}
	else
	{
		$CurSelectModeId = $LastSelectModeId;
		PanleFastShortcut_Ext1.setVisible(1);
		PanleFastShortcut_ZaiJu_Ext1.setVisible(0);
		BottomPointdown.SetActive(1);
		BottomPointUpper.SetActive(1);
		if ($SAVELastRow1==1)
			PanleFastShortcut_2.setvisible(1);
		if ($SAVELastRow2==1)
			PanleFastShortcut_3.setvisible(1);
		if ($SAVELastRow3==1)
			FloatingSkillShortCutWnd_1.setvisible(1);
		if ($SAVELastRow4==1)
			FloatingSkillShortCutWnd2_1.setvisible(1);
		$SAVELastRow1=0;
		$SAVELastRow2=0;
		$SAVELastRow3=0;
		$SAVELastRow4=0;

		$ModelZaiJu=0;
		//ɾ��Ԫ��
		ActionMap_ZaiJu.pop();

		//�������Ԫ��
		switch ($LastSelectModeId)
		{
			case 0:ActionMap_Normal.push();
			case 1:ActionMap_Chat.push();
			case 2:ActionMap_Battle.push();
			case 3:ActionMap_Custom.push();
		}
	}
}
function CloseBigViewMap_bitmapWindow()
{

}
//�ر������б�
function CloseBusinessList()
{
	if (BusinessWnd.isVisible())
	{
		BusinessWnd.setVisible(0);
		closeStallListWnd();
	}

	if (FastnessStallWndGui.isVisible())
	{
		FastnessStallWndGui.setVisible(0);
		clearFixedShortcut();
		closeFixedStallHelpWnd();
	}
}

function CloseExitGameWnd()
{
	
}
function OnClient_CloseEquipStrengthenDlg()
{

}
function EquipEmbedGemWnd_CloseWnd()
{

}
function closeFixedStallWnd()
{

}
function CloseScreenMessage()
{

}

function SetTraceWndPosition(%posx,%posy,%bLock)
{
	return;
	if (%posx==0&&%posy==0)
		return;
	//��ʱ�ӵģ��������������ļ�	
	%posx=570;
	%posy=250;
	%wndExtent = MissionTraceWnd.getextent();
	%extentx = getword(%wndExtent,0);
	%extenty = getword(%wndExtent,1);
	%parentExtent = GameMainWndGui_Layer2.getextent();
	%parentExtentx = getword(%parentExtent,0);
	%parentExtenty = getword(%parentExtent,1);

	if (%posy+%extenty>%parentExtenty)
		%posy = %parentExtenty - %extenty;
	%posx = %posx + %parentExtentx-800;
	if (%posx + %extentx >%parentExtentx)
		%posx  = %parentExtentx - %extentx;

	MissionTraceWndLock(!%bLock);

	$bGUTraceWndLock = %bLock;

	MissionTraceWnd.setposition(%posx,%posy);

}

function setMissionandPartyTraceWnd()
{
	return;
	setMissionTraceWnd();
	setPartyTraceWnd();
	MissionTraceWnd.setVisible($bMissionTrace);
	if ($bPartyTrace>1)
		PartyTraceWnd.setVisible(0);
	else
		PartyTraceWnd.setVisible($bPartyTrace);
}
//�������������������߰����ȱʧ��������������������

//exec("./gameres/client/scripts/MessageWnd.cs");
