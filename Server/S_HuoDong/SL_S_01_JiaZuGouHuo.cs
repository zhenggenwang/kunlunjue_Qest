//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//ȺӢ��ۻ
//==================================================================================
function QunYingHuiJu_StytemMsg(%YY,%MM,%DD,%H,%M,%S)
{
	if (GetZoneid() != 1001)
		return;
	if ($SL_JiaZuGouHuo_bActive != 1)
		return;
	%TimebActive = GetWord($SL_JiaZuGouHuo_StartTime,0,":") * 60  + GetWord($SL_JiaZuGouHuo_StartTime,1,":");
	%TimeNow = %H * 60 + %M;
	%Time = %TimebActive - %TimeNow;
	if (%Time == 10)
	{
		%HuoDongMingCheng = GetHuoDongName("ȺӢ���",1);
		%Path = "<l i='810010100 -7.75371 -21.687 191.679' t='path'/>";
		%Text = %HuoDongMingCheng @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ %Time @ "</t><t>���Ӻ�ʼ����������</t>" @ %Path @ "<t>�ٻ�����ͼ���ټ�����ǰ������ͼ��ף����</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

		%Text2 = GetHuoDongName("ȺӢ���",2) @ "<t>����</t>" @ $Get_Dialog_GeShi[60002] @ %Time @ "</t><t>���Ӻ���</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
	if (%Time == 5)
	{
		%HuoDongMingCheng = GetHuoDongName("ȺӢ���",1);
		%Path = "<l i='810010100 -7.75371 -21.687 191.679' t='path'/>";
		%Text = %HuoDongMingCheng @ "<t>����</t>" @ $Get_Dialog_GeShi[31420] @ %Time @ "</t><t>���Ӻ�ʼ����������</t>" @ %Path @ "<t>�ٻ�����ͼ���ټ�����ǰ������ͼ��ף����</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

		%Text2 = GetHuoDongName("ȺӢ���",2) @ "<t>����</t>" @ $Get_Dialog_GeShi[60002] @ %Time @ "</t><t>���Ӻ���</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
	if (%Time == 0)
	{
		%HuoDongMingCheng = GetHuoDongName("ȺӢ���",1);
		%Path = "<l i='810010100 -7.75371 -21.687 191.679' t='path'/>";
		%Text = %HuoDongMingCheng @ "<t>��Ѿ���ʼ����������</t>" @ %Path @ "<t>�ٻ�����ͼ���ټ�����ǰ������ͼ��ף����</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

		%Text2 = GetHuoDongName("ȺӢ���",2) @ "<t>��Ѿ���ʼ</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
	if (%Time < 0  && %Time >= -55 && %Time%10 == 0)
	{
		%HuoDongMingCheng = GetHuoDongName("ȺӢ���",1);
		%Path = "<l i='810010100 -7.75371 -21.687 191.679' t='path'/>";
		%Text = %HuoDongMingCheng @ "<t>���ڽ����У���ʿ�ǿ�ǰ��</t>" @ %Path @ "<t>Ѱ�Ұ���ͼ�ڻ�ȡͼ��ף����</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @ %Text @ "</t>");

		%Text2 = GetHuoDongName("ȺӢ���",2) @ "<t>���ڽ�����</t>";
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);
	}
}
//105109061	��Ӣ��
function Trigger_105109061(%Conv,%Player,%Type,%State,%TriggerType,%TriggerID,%Param,%XYZ)
{
	if (GetZoneID() != 1001)
	{
		%text = "�õ���ֻ����������ʹ��!";
		SendOneScreenMessage(2,%text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
		return;
	}
	if (%Player.gettriggerid() != 810010107)
	{
		%text = "�õ���ֻ�����ڡ����˹㳡��ʹ��!";
		SendOneScreenMessage(2,%text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
		return;
	}
	if ($SL_JiaZuGouHuo_State_bActive != 1)
	{
		%text = "�����" @ $SL_JiaZuGouHuo_StartTime @ "��ʼ!";
		SendOneScreenMessage(2,%text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
		return;
	}
	%PlayerID = %Player.GetPlayerid();
	%orgID = SptOrg_GetOrgID(%PlayerID);		//����ID
	%orgID_Name = SptOrg_GetName(%orgID);		//��������
	%orgID_Level = SptOrg_GetLevel(%orgID);	//���ɵȼ�
	//�Ƿ����峤
	if (%Player.GetOrgMemberLevel(1) < 6)//�Ƿ��ǰ���
	{
		%text = "ֻ�а��������ٻ������ͼ��!";
		SendOneScreenMessage(2,%text,%Player);
		SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
		return;
	}
	switch (%orgID_Level)
	{
		case 1:%NpcID = 410010220;
		case 2:%NpcID = 410010221;
		case 3:%NpcID = 410010222;
		case 4:%NpcID = 410010223;
		case 5:%NpcID = 410010224;
		default:return;
	}
	%Player.PutItem(%Type,-1);
	if (%Player.Additem(16,%type))
	{
		%Monster = SpNewNpc2(0,%NpcID,%Player.GetPosition(),%Player.GetLayerid(),0);
		//%MonsterName = GetNpcData( %NpcID, 1 );
		//%Monster.SetShapename( %MonsterName @ "��" @  %orgID_Name @ "��" );
		%Monster.SetExclusivePlayerName(%orgID_Name);
		%Monster.BindPlayerID = %PlayerID;
		%Monster.BindOrgID = %orgID;
		%Monster.BindName  = %orgID_Name;
		%Monster.BindOrgLevel = %orgID_Level;


		%OrgName = $Get_Dialog_GeShi[31421] @ "��" @ %orgID_Name @ "��</t>";
		%PlayerName = GetPlayerZiTiName(%Player,1);
		%NpcName = GetNpcZiTiName(%Monster,1);

		%Path = "<l i='810010100 " @  %Player.GetPosition() @ "' t='path'/>";
		%Text =  %OrgName @ "<t>�İ���</t>" @ %PlayerName @ "<t>��</t>" @ %Path @ "<t>�ٻ���</t>" @ %NpcName @ "<t>�����ھ�Ӣ�׷׾ۼ�ǰ����ԡͼ�ڹ�ԡ�</t>";
		SendOneLineMessage($Get_Dialog_GeShi[31419] @  %Text @ "</t>");

		%PlayerName2 = GetPlayerZiTiName(%Player,2);
		%Text2 = %PlayerName2 @ "<t>�ٻ���</t>" @ %NpcName;
		SendOneLineMessage($Get_Dialog_GeShi[60001] @ %Text2 @ "</t>", $chatMsg_Type_Normal2);

		%Time = GetLocalTime();
		%H = GetWord(%Time,3);//Сʱ
		%M = GetWord(%Time,4);//����
		%TimeA = %H * 60 + %M;
		%TimeB = GetWord($SL_JiaZuGouHuo_EndTime,0,":") * 60 + GetWord($SL_JiaZuGouHuo_EndTime,1,":");
		%LostTime = %TimeB - %TimeA;
		Schedule(%LostTime * 60 * 1000,0,"eval",%Monster @ ".Safedeleteobject(); ");
	}
}

//
function NpcOnTrigger_Dialog_QunYingHuiJu(%Npc,%Player,%State,%Conv,%Param,%Level)
{
	if ($SL_JiaZuGouHuo_State_bActive != 1)
		return;
	switch (%State)
	{
		case 0:
			%Conv.SetText(600000000);
			%Conv.AddOption(600000001,600000001);
		case 600000001:
			%PlayerID = %Player.GetPlayerid();
			%orgID = SptOrg_GetOrgID(%PlayerID);		//����ID
			if (%Player.Getlevel() < $SL_JiaZuGouHuo_Level)
			{
				SendOneScreenMessage(2,"���ĵȼ�����" @ $SL_JiaZuGouHuo_Level @ "�����޷���ȡͼ��֮��",%Player);
				return NpcOnTrigger_Dialog_QunYingHuiJu(%Npc,%Player,0,%Conv,%Param,%Level);
			}
			else
			{
				if (%orgID ==  %Npc.BindOrgID)//�Լ�����Ķ���
				{
					%Conv.SetType(4);
					%Player.Addbuff(39909 * 10000 + %Level,%Player,1);
					%Player.GouHuoBuff = %Level;
					%Player.SetSchbuff(2000);
					SetOrgActivityRecord(%Player, 6);//���ɻ ȺӢ��� ��¼���
					AddAchievementWatch(%Player,0,40,1);//��¼�ɾ�
				}
				else
				{
					%Conv.SetText(600000002);
					%Conv.AddOption(600000003,600000003);
				}
			}
		case 600000003:
			%Conv.Settype(4);
			%Money = %Player.GetMoney(1);
			if (%Money < 200)
			{
				%text = "���Ԫ������!";
				SendOneScreenMessage(2,%text,%Player);
				SendOneChatMessage($chatMsg_System,"<t>" @ %text @ "</t>",%Player);
				return;
			}
			%Player.ReduceMoney(200,1,16,105109061);//�۳�Ԫ��
			%Player.SetSchbuff(2000);
			%Player.Addbuff(39909 * 10000 + %Level,%Player,1);
			%Player.GouHuoBuff = %Level;
			SetOrgActivityRecord(%Player, 6);//���ɻ ȺӢ��� ��¼���
			AddAchievementWatch(%Player,0,40,1);//��¼�ɾ�

			%OrgMasterID = %Npc.BindPlayerID;
			if (%OrgMasterID > 0)
				SptMail_Send(%OrgMasterID,0,0,100,0,"ͼ���ջ�","<t>�зǱ��������ȡ�˱����ͼ��֮��������һ�������棬�뼰ʱ��ȡ��</t>");
	}
}//SptMail_Send( 50000304, 105109061, 2, 123, 12345, "ͼ���ջ�", "<t>�зǱ���������зǱ���������зǱ���������зǱ���������зǱ���������зǱ���������зǱ���������зǱ���������зǱ��������</t>" );
function ScheduleBuff_2000(%Player,%BuffID,%IsAuto)
{
	if ($SL_JiaZuGouHuo_State_bActive == 1)
	{
		if (%Player.gettriggerid() == 810010107)
		{
			//--���ɵȼ�ϵ��
			%ExpBangPaiLevel = 0;
			if (%Player.getbuffcount(39909,1)>= 1) %ExpBangPaiLevel = 0;
			else if (%Player.getbuffcount(39909,2)>= 1) %ExpBangPaiLevel = 0.2;
			else if (%Player.getbuffcount(39909,3)>= 1) %ExpBangPaiLevel = 0.5;
			else if (%Player.getbuffcount(39909,4)>= 1) %ExpBangPaiLevel = 1;
			else if (%Player.getbuffcount(39909,5)>= 1) %ExpBangPaiLevel = 1.5;

			//---˫������
			%Exp_LeiJiaBeiShu = 0;
			if (%Player.ISschbuff(1997)) %Exp_LeiJiaBeiShu = 1;	  //���鵤�ļӳ�
			if (%Player.ISschbuff(1998)) %Exp_LeiJiaBeiShu = 1.5; //���鵤�ļӳ�
			if (%Player.ISschbuff(1999)) %Exp_LeiJiaBeiShu = 2;	  //���鵤�ļӳ�

			//���ɹ��׿�����
			%GongXianKa = 0;
			//��ɫ�ȼ�΢��ϵ��
			%Level = %Player.GetLevel();
			if (%Level < 30) %LevelXiShu = 0.3;
			else if (%Level < 40) %LevelXiShu = 1;
			else if (%Level < 50) %LevelXiShu = 1.2;
			else if (%Level < 60) %LevelXiShu = 1.6;
			else if (%Level < 70) %LevelXiShu = 2.0;
			else  %LevelXiShu = 2.2;
			//EXP = �ȼ����� * ��˫������ + ���ɵȼ�ϵ�� + ���ɹ��׿���* ��ɫ�ȼ�΢��ϵ��
			//echo( "$Monster_Exp[ %Level, 1 ]==" @ $Monster_Exp[ %Level, 1 ] );
			//echo( "%Exp_LeiJiaBeiShu==" @ %Exp_LeiJiaBeiShu );
			//echo( "%ExpBangPaiLevel==" @ %ExpBangPaiLevel );
			//echo( "%GongXianKa==" @ %GongXianKa );
			//echo( "%LevelXiShu==" @ %LevelXiShu );
			%Exp = $Monster_Exp[%Level,1] *(%Exp_LeiJiaBeiShu + %ExpBangPaiLevel + %GongXianKa + 1) * %LevelXiShu;
			if (%Exp > 0)
				AllAddExp(%Player,%Exp);
		}
		%Player.SetSchbuff(2000);
		return 0;
	}
	else
	{
		if (%Player.getbuffcount(39909,1)>= 1) %Player.RemoveBuff(399090001);
		if (%Player.getbuffcount(39909,2)>= 1) %Player.RemoveBuff(399090002);
		if (%Player.getbuffcount(39909,3)>= 1) %Player.RemoveBuff(399090003);
		if (%Player.getbuffcount(39909,4)>= 1) %Player.RemoveBuff(399090004);
		if (%Player.getbuffcount(39909,5)>= 1) %Player.RemoveBuff(399090005);
	}
	return 1;
	//���ط�0����ʾ%buffid��Ҫ��������Ƴ���
}
/*
SptOrg_AddLevel( SptOrg_GetOrgID(  50000182 ));		//����ID );//���ɵȼ� + 1
*/