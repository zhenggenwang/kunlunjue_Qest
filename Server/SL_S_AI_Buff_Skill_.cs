//����������������������Ai���ܴ����ű�����������������������������������
//����������������������Buff�����ű�������������������������������������
//�����������������������ܵ������˺������ű�����������������������������
//��������������������������BOSS���AI����������������������������������

//����������������������Ai���ܴ����ű�����������������������������������
function AiSkill_Trigger_Occurrence(%Caster,%SkillId)
{
	putout("%Caster ==" @ %Caster @ "  " @ %Caster.GetObjectname() @ "   %SkillId==" @   %SkillId);
	switch (%SkillId)
	{
		case 200040003://Ѳ����ʿ���չ�
			%Target = %Caster.GetTarget();
			if (isobject(%Target))
				%Target.Addpacket(690816);
		case 259990001:
			//��ȡ��Χ������� @ " " @ ��Χ�����������ö��󣬶���
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,30,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			for (%i = 0; %i < %FanWeiMonsterNum; %i++)
			{
				//��ȡ�������
				%opj = GetWord(%FanWeiMonster,%i);
				%opj.AddBuff(320740001,%Caster,25);
				%opj.addpacket(625009);
			}
		case 260010001://����֮��
			for (%i = 0; %i >= 0; %i++)
			{
				//��ȡ����б��е�ֵ
				%Target = %Caster.getHateListObject(%i);
				//û�г������ͣ
				if (%Target == 0)
					break;

				%Target.SetHate(%Caster,GetRanDom(1,10000));
			}
		case 260010002://������
			for (%i = 0; %i >= 0; %i++)
			{
				//��ȡ����б��е�ֵ
				%Target = %Caster.getHateListObject(%i);
				//û�г������ͣ
				if (%Target == 0)
					break;

				%Target.SetHate(%Caster,1);
				%List = %Target @ " " @ %Target;
			}
			%Count = GetWordCount(%List);
			if (%Count > 0)
			{
				%NumBer = GetRandom(0,%Count -1);
				%Target = GetWord(%List,%NumBer);
				if (%Target.GetDamageState() $= "Enabled")
				{
					%Pos = %Caster.GetPosition();
					%Pos = GetNavPos(GetWord(%Pos,0),GetWord(%Pos,1),1);
					%X = GetWord(%Pos,0);
					%Y = GetWord(%Pos,1);
					%Z = GetWord(%Pos,2);
					if (%X != 0 && %Y != 0 && %Z != 0)
					{
						if (isplayer(%Target))
							%Target.TransportObject(0,0,%X,%Y,%Z);
						else
							%Target.SetPosition(%Pos);
						%Caster.AddHate(%Target,10000);
					}

				}
			}
			%Caster.addpacket(800001);
		case 260010003://���ܻ�
			%Caster.addpacket(800004);
		case 260010004://�ռ�ת��
			for (%i = 0; %i >= 0; %i++)
			{
				//��ȡ����б��е�ֵ
				%Target = %Caster.getHateListObject(%i);
				//û�г������ͣ
				if (%Target == 0)
					break;
				%List = %Target @ " " @ %Target;
			}
			%Count = GetWordCount(%List);
			if (%Count > 0)
			{
				%NumBer = GetRandom(0,%Count -1);
				%Target = GetWord(%List,%NumBer);
				if (%Target.GetDamageState() $= "Enabled")
				{
					%Pos = %Caster.GetPosition();
					//echo( "%Pos ====" @ %Pos );
					%Pos = GetNavPos(GetWord(%Pos,0),GetWord(%Pos,1),300);
					//echo( "%Pos ====" @ %Pos );
					%X = GetWord(%Pos,0);
					%Y = GetWord(%Pos,1);
					%Z = GetWord(%Pos,2);
					if (%X != 0 && %Y != 0 && %Z != 0)
					{
						if (isplayer(%Target))
							%Target.TransportObject(0,0,%X,%Y,%Z);
						else
							%Target.SetPosition(%Pos);
					}

				}
			}
		case 260010005://��־ŭ�� BUFF��32034 1 ��־ŭ��
			//��ȡ��Χ������� @ " " @ ��Χ�����������ö��󣬶���
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,30,0,%Caster);
			//echo(findObjectsInRegion( 263260.GetPosition( ) @ " " @ 20, 12, 0, 263260 ));
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			//echo( "%FanWeiMonster===" @ %FanWeiMonster );
			for (%i = 0; %i < %FanWeiMonsterNum; %i++)
			{
				//��ȡ�������
				%opj = GetWord(%FanWeiMonster,%i);
				%opj.AddBuff(320340001,%Caster,1);
			}
		case 260010006://��������LV1 32035 1 ��������LV1
			%HP = %Caster.GetHP();
			%MaxHP = %Caster.GetMaxHP();
			if (%HP / %MaxHP  < 0.3)
				%Caster.AddBuff(320350001,%Caster,1);
		case 260010007://��������LV2 32036 1 ��������LV2
			%HP = %Caster.GetHP();
			%MaxHP = %Caster.GetMaxHP();
			if (%HP / %MaxHP  < 0.3)
				%Caster.AddBuff(320360001,%Caster,1);
		case 260010008://��������LV3 32037 1 ��������LV3
			%HP = %Caster.GetHP();
			%MaxHP = %Caster.GetMaxHP();
			if (%HP / %MaxHP  < 0.3)
				%Caster.AddBuff(320370001,%Caster,1);
		case 260010009://ħ������LV1 32038 1 ħ������LV1  ȫ���Ա� ѹ��30%   32050 1  ������ʧ������ÿ��1%��
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,30,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			for (%i = 0; %i < %FanWeiMonsterNum; %i++)
			{
				//��ȡ�������
				%opj = GetWord(%FanWeiMonster,%i);
				%opj.AddBuff(320380001,%Caster,1);
				%opj.AddBuff(320500001,%Caster,1);
			}
		case 260010010://ħ������LV2 32039 1 ħ������LV2  ȫ���Ա� ѹ��30%   32051 1  ������ʧ������ÿ��1.5%��
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,30,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			for (%i = 0; %i < %FanWeiMonsterNum; %i++)
			{
				//��ȡ�������
				%opj = GetWord(%FanWeiMonster,%i);
				%opj.AddBuff(320390001,%Caster,1);
				%opj.AddBuff(320510001,%Caster,1);
			}
		case 260010011://ħ������LV3 32040 1 ħ������LV3  ȫ���Ա� ѹ��30%   32052 1  ������ʧ������ÿ��2%��
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,30,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			for (%i = 0; %i < %FanWeiMonsterNum; %i++)
			{
				//��ȡ�������
				%opj = GetWord(%FanWeiMonster,%i);
				%opj.AddBuff(320400001,%Caster,1);
				%opj.AddBuff(320520001,%Caster,1);
			}
		case 260010012://����߱��
			%Target = %Caster.GetTarget();
			%HP = %Target.GetHP();
			%MaxHP = %Target.GetMaxHP();
			%Ran = mfloor((1 - %HP / %MaxHP)*100);
			if (%Ran < 30) %Ran = 30;
			//echo( "%Ran ==" @ %Ran );
			if (GetRanDom(1,100) <= %Ran)
			{
				if (isplayer(%Target))
					%Target.addpacket(760056);
				%Target.addpacket(625009);
				//echo( "%Ran ==" @ %Ran );
				%Target.SetDamageState(Disabled);
			}
		case 260010013://Ⱥħ����
			if (%Caster.OpjAi[1].GetDamageState() $= "Enabled" && %Caster.OpjAi[2].GetDamageState() $= "Enabled")
				return;

			%DataID = %Caster.GetDataid();
			%Pos = %Caster.GetPosition();
			%CopyMapID = %Caster.GetLayerId();
			%SkillPuGong = GetNpcData(%DataID,21);
			%ZGwzb_1 = GetWord(%Pos,0);
			%ZGwzb_2 = GetWord(%Pos,1);
			%Pos = GetNavPos(%ZGwzb_1,%ZGwzb_2,2);
			if (GetWord(%Pos,0) * 1 != 0)
				%Opj = SpNewNpc3(0,410105005,%Pos,%CopyMapID,0,"1 1 1");

			%Opj.SetMaster(%Caster);
			%Opj.SetExclusivePlayerName("");
			MirrorimageNPCServer(%DataID,%Opj);//�滻ģ��
			%Opj.AddEnemyBuffPercent(%Caster,10000); //�̳�����

			//echo( "%Caster.GetObjectName( )===" @ %Caster.GetObjectName( ) );
			%Opj.SetShapeName(%Caster.GetObjectName());
			if (%SkillPuGong > 0)
				%Opj.AddSkill(%SkillPuGong);
			for (%i = 1; %i <= 10; %i++)
			{
				if (%Caster.Ai_Skill[%i] > 0 && %Caster.Ai_Skill[%i]  != 320240001)
					%Opj.AddBuff(%Caster.Ai_Skill[%i],%Opj,1);
				else
					break;
			}
			if (%Caster.OpjAi[1].GetDamageState() $= "Enabled")
				%Caster.OpjAi[2] = %Opj;
			else
				%Caster.OpjAi[1] = %Opj;
		case 260010014:// 
		case 260010015://��ϵ������ʦLV1
			//��ȡ��Χ������� @ " " @ ��Χ�����������ö��󣬶���
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,30,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			for (%i = 0; %i < %FanWeiMonsterNum; %i++)
			{
				%opj = GetWord(%FanWeiMonster,%i);
				%opj.AddBuff(320530001,%Caster,1);
			}
		case 260010016://��ϵ������ʦLV2
			//��ȡ��Χ������� @ " " @ ��Χ�����������ö��󣬶���
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,30,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			for (%i = 0; %i < %FanWeiMonsterNum; %i++)
			{
				%opj = GetWord(%FanWeiMonster,%i);
				%opj.AddBuff(320530002,%Caster,1);
			}
		case 260010017://��ϵ������ʦLV3
			//��ȡ��Χ������� @ " " @ ��Χ�����������ö��󣬶���
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,30,0,%Caster);
			//echo( "%FanWeiMonster===" @ %FanWeiMonster );
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			//echo( "%FanWeiMonsterNum===" @ %FanWeiMonsterNum );
			for (%i = 0; %i < %FanWeiMonsterNum; %i++)
			{
				%opj = GetWord(%FanWeiMonster,%i);
				//echo( "%opj===" @ %opj );
				%opj.AddBuff(320530003,%Caster,1);
			}
		case 260010018://��ϵ������ʦLV1 260030001 ���ǻ���
			%Target = %Caster.GetTarget();
			%Pos = %Target.GetPosition();
			%Caster.AddSkill(260030001);
			//%Caster.AI_CastSpell( %Pos, 260030001 );
			Schedule(100,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Pos @ "\"" @ ",260030001); ");
			%ZGwzb_1 = GetWord(%Pos,0);
			%ZGwzb_2 = GetWord(%Pos,1);
			%Pos = GetNavPos(%ZGwzb_1,%ZGwzb_2,30);
			if (%Pos !$= "0 0 0" && %Pos !$= "" && GetWord(%Pos,0) *1  != 0)
				Schedule(2000,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Pos @ "\"" @ ",260030001); ");
		case 260010019://��ϵ������ʦLV2 260030002 ���ǻ���
			%Target = %Caster.GetTarget();
			%Pos = %Target.GetPosition();
			%Caster.AddSkill(260030002);
			//%Caster.AI_CastSpell( %Pos, 260030002 );
			Schedule(100,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Pos @ "\"" @ ",260030002); ");
			%ZGwzb_1 = GetWord(%Pos,0);
			%ZGwzb_2 = GetWord(%Pos,1);
			%Pos = GetNavPos(%ZGwzb_1,%ZGwzb_2,30);
			if (%Pos !$= "0 0 0" && %Pos !$= "" && GetWord(%Pos,0) * 1 != 0)
				Schedule(2000,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Pos @ "\"" @ ",260030002); ");
		case 260010020://��ϵ������ʦLV3 260030003 ���ǻ���
			%Target = %Caster.GetTarget();
			%Pos = %Target.GetPosition();
			%Caster.AddSkill(260030003);
			//%Caster.AI_CastSpell( %Pos, 260030003 );
			//echo( "%Pos ===" @ %Pos );
			Schedule(100,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Pos @ "\"" @ ",260030003); ");
			%ZGwzb_1 = GetWord(%Pos,0);
			%ZGwzb_2 = GetWord(%Pos,1);
			%Pos = GetNavPos(%ZGwzb_1,%ZGwzb_2,30);
			%Pos2 = GetNavPos(%ZGwzb_1,%ZGwzb_2,30);
			if (%Pos !$= "0 0 0" && %Pos !$= "" && GetWord(%Pos,0) * 1 != 0)
				Schedule(2000,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Pos @ "\"" @ ",260030003); ");
			if (%Pos2 !$= "0 0 0" && %Pos2 !$= "" && GetWord(%Pos2,0) * 1 != 0)
				Schedule(4000,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Pos2 @ "\"" @ ",260030003); ");

		case 260010021://��ϵ������ʦLV1 260040001 ��ѩƮ��
			%Target = %Caster.GetTarget();
			%Pos = %Target.GetPosition();
			%Caster.AddSkill(260040001);
			//%Caster.AI_CastSpell( %Pos, 260040001 );
			Schedule(100,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Pos @ "\"" @ ",260040001); ");
			%ZGwzb_1 = GetWord(%Pos,0);
			%ZGwzb_2 = GetWord(%Pos,1);
			%Pos = GetNavPos(%ZGwzb_1,%ZGwzb_2,30);
			if (%Pos !$= "0 0 0" && %Pos !$= "" && GetWord(%Pos,0) * 1 != 0)
				Schedule(2000,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Pos @ "\"" @ ",260040001); ");
		case 260010022://��ϵ������ʦLV2 260040002 ��ѩƮ��
			%Target = %Caster.GetTarget();
			%Pos = %Target.GetPosition();
			%Caster.AddSkill(260040002);
			//%Caster.AI_CastSpell( %Pos, 260040002 );
			Schedule(100,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Pos @ "\"" @ ",260040002); ");
			%ZGwzb_1 = GetWord(%Pos,0);
			%ZGwzb_2 = GetWord(%Pos,1);
			%Pos = GetNavPos(%ZGwzb_1,%ZGwzb_2,30);
			if (%Pos !$= "0 0 0" && %Pos !$= "" && GetWord(%Pos,0) * 1 != 0)
				Schedule(2000,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Pos @ "\"" @ ",260040002); ");
		case 260010023://��ϵ������ʦLV3 260040003 ��ѩƮ��
			%Target = %Caster.GetTarget();
			%Pos = %Target.GetPosition();
			%Caster.AddSkill(260040003);
			//%Caster.AI_CastSpell( %Pos, 260040003 );
			Schedule(100,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Pos @ "\"" @ ",260040003); ");
			%ZGwzb_1 = GetWord(%Pos,0);
			%ZGwzb_2 = GetWord(%Pos,1);
			%Pos = GetNavPos(%ZGwzb_1,%ZGwzb_2,30);
			%Pos2 = GetNavPos(%ZGwzb_1,%ZGwzb_2,30);
			if (%Pos !$= "0 0 0" && %Pos !$= "" && GetWord(%Pos,0) * 1 != 0)
				Schedule(2000,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Pos @ "\"" @ ",260040003); ");
			if (%Pos2 !$= "0 0 0" && %Pos2 !$= "" && GetWord(%Pos2,0) * 1 != 0)
				Schedule(4000,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Pos2 @ "\"" @ ",260040003); ");
		case 260010024://ľϵ������ʦLV1
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,20,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			if (%FanWeiMonsterNum > 0)
			{
				%Ran = GetRanDom(0,%FanWeiMonsterNum-1);
				%Target = GetWord(%FanWeiMonster,%Ran);
				%Pos = %Target.GetPosition();
				%Caster.AddSkill(260050001);
				//%Caster.AI_CastSpell( %Pos, 260050001 );
				Schedule(100,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Pos @ "\"" @ ",260050001); ");
			}
		case 260010025://ľϵ������ʦLV2
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,20,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			if (%FanWeiMonsterNum > 0)
			{
				%Ran = GetRanDom(0,%FanWeiMonsterNum-1);
				%Target = GetWord(%FanWeiMonster,%Ran);
				%Pos = %Target.GetPosition();
				%Caster.AddSkill(260050002);
				//%Caster.AI_CastSpell( %Pos, 260050002 );
				Schedule(100,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Pos @ "\"" @ ",260050002); ");
			}
		case 260010026://ľϵ������ʦLV3
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,20,0,%Caster);
			//echo( "%FanWeiMonster ==" @ %FanWeiMonster );
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			if (%FanWeiMonsterNum > 0)
			{
				%Ran = GetRanDom(0,%FanWeiMonsterNum-1);
				%Target = GetWord(%FanWeiMonster,%Ran);
				%Pos = %Target.GetPosition();
				//echo( "%Target ==" @ %Target );
				//echo( "%Pos ==" @ %Pos );
				%Caster.AddSkill(260050003);
				//%Caster.AI_CastSpell( %Pos, 260050003 );
				Schedule(100,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Pos @ "\"" @ ",260050003); ");
			}
		case 260010027://��ϵ������ʦLV1
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,20,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			if (%FanWeiMonsterNum > 0)
			{
				%Ran = GetRanDom(0,%FanWeiMonsterNum-1);
				%Target = GetWord(%FanWeiMonster,%Ran);
				%Caster.AddSkill(260060001);
				//%Caster.AI_CastSpell( %Target, 260060001 );
				Schedule(100,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Target @ "\"" @ ",260060001); ");
				%Caster.AddHate(%Target,9999);
			}
		case 260010028://��ϵ������ʦLV2
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,20,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			if (%FanWeiMonsterNum > 0)
			{
				%Ran = GetRanDom(0,%FanWeiMonsterNum-1);
				%Target = GetWord(%FanWeiMonster,%Ran);
				%Caster.AddSkill(260060002);
				//%Caster.AI_CastSpell( %Target, 260060002 );
				Schedule(100,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Target @ "\"" @ ",260060002); ");
				%Caster.AddHate(%Target,9999);
			}
		case 260010029://��ϵ������ʦLV3
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,20,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			if (%FanWeiMonsterNum > 0)
			{
				%Ran = GetRanDom(0,%FanWeiMonsterNum-1);
				%Target = GetWord(%FanWeiMonster,%Ran);
				%Caster.AddSkill(260060003);
				//%Caster.AI_CastSpell( %Target, 260060003 );
				Schedule(100,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Target @ "\"" @ ",260060003); ");
				%Caster.AddHate(%Target,9999);
			}
		case 263000001:AiSkill_Trigger_263000001(%Caster);//Թ���
		case 263000002:AiSkill_Trigger_263000002(%Caster);//Թ��� ��������
		case 263010001:AiSkill_Trigger_263010001(%Caster);//����ͬ��
		case 263010003:AiSkill_Trigger_263010003(%Caster);//����ͬ�� ��ɱ
		case 263030001:AiSkill_Trigger_263030001(%Caster);//ħɲ�ķ�
		case 263030002:AiSkill_Trigger_263030002(%Caster);//ħɲ�ķ� ����Ŀ��
		case 200180001:AiSkill_Trigger_200180001(%Caster);//�س�
		case 200190001:AiSkill_Trigger_200190001(%Caster);//��������
		case 240200001:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200002:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200003:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200004:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200005:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200006:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200007:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200008:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200009:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200010:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200011:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200012:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200013:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200014:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200015:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200016:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200017:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200018:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200019:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200020:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200021:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200022:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200023:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200024:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200025:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200026:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200027:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200028:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200029:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 240200030:FuHuoJiNeng(%Caster,%SkillId);//��ʿ����� 
		case 260130001://���޾���
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 40,30,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);

			if (%FanWeiMonsterNum <= 0)
				return;
			%Target = GetWord(%FanWeiMonster,GetRandom(0,%FanWeiMonsterNum - 1));
			if (%Target.GetDamageState() !$= "Enabled")
				return;
			%TarGet.Addbuff(320730001,%Caster,1);
			%TarGet.Skill26013 = %Caster;
			%Skillname = "<l i='"@%SkillID@"' t='skillid'/>";
			%CopyMapID = %Caster.GetLayerId();

			%text0 = "��" @ %Target.GetObjectName() @ "����[���޾���]���У��뿿����̯�˺���";
			if (isplayer(%TarGet))
				%Text1 = GetPlayerZiTiName(%TarGet,1) @ "<t>��[���޾���]���У��뿿����̯�˺���</t>";
			else
				%Text1 = "<t>" @ %Target.GetObjectName() @ "��[���޾���]���У��뿿����̯�˺���</t>";
			SendAllChatMessageLayer(1,$Get_Dialog_GeShi[31406]  @ %Text1 @ "</t>",%CopyMapID);	//���͸�������Ϣ( ��Ļ���� )
			SendAllScreenMessageLayer(1,%text0,%CopyMapID);	//���͸�������Ϣ( ��Ļ�м� )

		case 260140001://���޽��
			%CopyMapID = %Caster.GetLayerId();
			for (%i = 1;%i <= 6;%i++)
			{
				if (isobject($EventIDRecord[%CopyMapID,%i]))
					$EventIDRecord[%CopyMapID,%i].Safedeleteobject();
				$EventIDRecord[%CopyMapID,%i] = SpNewCj2(0,553000061,$EventPosRecord[1303,%i],%CopyMapID,0,"1 1 1");
				$EventIDRecord[%CopyMapID,%i].addpacket(900151);
			}
			$IsReomoveJieDianRecord[%CopyMapID] = 0;
			%BuffCount = $CopyMapBattleStateReocrd[%CopyMapID,1].GetBuffCount(32075,1);
			if (%BuffCount > 0)
			{
				%TeammateList = SptCopyMap_GetAllPlayer(%CopyMapID);//��ȡ���������Ϣ
				%TeammateNum = SptCopyMap_GetPlayerCount(%CopyMapID);//��ȡ�����������
				for (%i = 0; %i < %TeammateNum; %i++)
				{
					%Player = GetWord(%TeammateList,%i);
					if (%Player.GetDamageState() $= "Enabled")
						%Player.Addbuff(320740001,$CopyMapBattleStateReocrd[%CopyMapID,1],50);
				}
			}
			$CopyMapBattleStateReocrd[%CopyMapID,1].addbuff(320750001,$CopyMapBattleStateReocrd[%CopyMapID,1],1);

			%text0 = "�����޽��������[���޽��]�ӳ֣������޵�״̬���뾡���ƻ����ڵ�";
			SendAllChatMessageLayer(1,$Get_Dialog_GeShi[31406]  @ %text0 @ "</t>",%CopyMapID);	//���͸�������Ϣ( ��Ļ���� )
			SendAllScreenMessageLayer(0,"���ٶ��ƻ����ڵ�",%CopyMapID);	//���͸�������Ϣ( ��Ļ�м� )
		case 260150001://쫷���
			%CopyMapID = %Caster.GetLayerID();
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 40,30,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			if (%FanWeiMonsterNum <= 0)
				return;
			%Target = GetWord(%FanWeiMonster,GetRandom(0,%FanWeiMonsterNum - 1));
			%Pos = %Target.GetPosition();
			%MonSter = SpNewNpc2(0,440000019,%Pos,%CopyMapID,0);
			%MonSter.AddHate(%Target,100);
			%MonSter.Addbuff(320760001,%Monster,1);
			%Caster.SuiCongNumber++;
			%Caster.SuiCong[%Caster.SuiCongNumber] = %MonSter;
			//%MonSter.addpacket(130602);
		case 260170001://BOSS���� ��ǽ��
			%CopyMapID = %Caster.GetLayerID();
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 40,30,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			if (%FanWeiMonsterNum <= 0)
				return;
			%Target = GetWord(%FanWeiMonster,GetRandom(0,%FanWeiMonsterNum - 1));
			%Pos = %Target.GetPosition();
			%Caster.AddSkill(260180001);
			//echo("%Pos===" @%Pos);
			Schedule(100,0,"eval",%Caster @ ".AI_CastSpell(" @ "\"" @ %Pos @ "\"" @ ",260180001); ");
	}
}
function AiSkill_Trigger_200180001(%Player)
{
	if (%Player.Getlevel() < 20)
	{
		SendOneScreenMessage(2,"20����ſ���ʹ�ûسǼ���",%Player);
		SendOneChatMessage($chatMsg_System,"<t>20����ſ���ʹ�ûسǼ���</t>",%Player);
		return;
	}
	%Result = CanTransportobject(%Player,6);
	if (%Result == 0)
		return;

	%Triggerid = %Player.GetTriggerid();
	%MapID = GetTriggerData(%Triggerid,6);
	%Pos = GetTriggerData(%Triggerid,7);

	if (%Player.GetPkValue() >= 6)
	{
		%Triggerid = 811190109;
		%MapID = 1119;
		%Pos = "216.663 203.919 101.452";
	}

	%Player.TransportObject(0,%MapID,getword(%Pos,0),getword(%Pos,1),getword(%Pos,2));
}
function AiSkill_Trigger_200190001(%Player)
{
	if (%Player.Getlevel() < 30)
	{
		SendOneScreenMessage(2,"������Ϊ��ǳ������30���Ժ�������Ѱ����",%Player);
		SendOneChatMessage($chatMsg_System,"<t>������Ϊ��ǳ������30���Ժ�������Ѱ����</t>",%Player);
		return;
	}
	if (GetZoneID() != 1001)
	{
		SendOneScreenMessage(2,"�˴�������������ǰ��������Ѱ",%Player);
		SendOneChatMessage($chatMsg_System,"<t>�˴�������������ǰ��������Ѱ</t>",%Player);
		return;
	}
	%Player.transportobject(0,1001,-150.056,169.957,195.257);
}
function FuHuoJiNeng(%Caster,%SkillId)
{
	%TarGet = %Caster.GetTarget();
	if (%TarGet.GetDamageState() $= "Disabled" && %TarGet.GetClassName() $= "Player")
		%TarGet.SendPlayerString(9,%Caster.GetPlayerName() @ " " @ %Caster.GetPlayerID() @ " " @ %Caster.GetSkillLevel(GetSubStr(%SkillId,0,5)),0);
}
//����������������������Ai���ܴ����ű�����������������������������������

//����������������������Buff�����ű�������������������������������������

function AiBuff_Trigger_Occurrence(%Caster,%BuffId)
{
	//if ( %Caster.GetClassName( ) $= "Player" )
	//	echo( "%Caster ==" @ %Caster @ "  " @ %Caster.GetObjectname( ) @ "   %BuffId==" @   %BuffId );
	switch (%BuffId)
	{
		case 320090001://�����⻷LV1
			Schedule(1000,0,"eval",%Caster @ ".AddBuff(320090001," @ %Caster @ ",1000000); ");
		case 320090002://�����⻷LV2
			Schedule(1000,0,"eval",%Caster @ ".AddBuff(320090002," @ %Caster @ ",1000000); ");
		case 320090003://�����⻷LV3
			Schedule(1000,0,"eval",%Caster @ ".AddBuff(320090003," @ %Caster @ ",1000000); ");
		case 320250001://������ת �����������
			%Caster.AddBuff(320480001,%Caster,1);
		case 320480001://������ת ������������
			%Caster.AddBuff(320490001,%Caster,1);
		case 320490001://������ת ����״̬
			%Caster.AddBuff(320250001,%Caster,1);
		case 399040001://��10���Ƴ� ����������ҩBUFF
			if (%Caster.GetBuffCount(39904,1) >= 10)
			{
				%Caster.RemoveBuff(399040001);
				%Caster.RemoveBuff(399030001);
				SendOneScreenMessage(2,"��Ĳ�ҩ�Ѿ���ʧ�����»�ȥ�ɼ���",%Caster);
				SendOneChatMessage($chatMsg_System,"<t>��Ĳ�ҩ�Ѿ���ʧ�����»�ȥ�ɼ���</t>",%Caster);

				%Level = %Caster.GetLevel();
				if (%Level <= 44) %Mid = 20005;
				else if (%Level <= 59) %Mid = 20013;
				else if (%Level <= 75) %Mid = 20021;

				%Caster.SetMissionFlag(%Mid,3300,0);
				%Caster.UpdateMission(%Mid);
			}
	}
}

function AiBuff_Trigger_Remove(%Caster,%BuffId) //buff�Ƴ�ͳһ������������Ҫ��buffskilldata������
{
	//echo( "buff�Ƴ�ͳһ�������� ====" @  %Caster @ "    " @ %BuffId );
	switch (%BuffId)
	{
		case 390300001://�����۾� ����Ŀ
			ShouZuoLunJing_ShouDaoTiMu(%Caster);
		case 390310001://�����۾� ������
			ShouZuoLunJing_FaDaAn(%Caster);
		case 399080001:
			Schedule(5000,0,"ShiJieLevelJiaCheng",%Caster);//�������ӵ�ǰ�ļӳ�BUFF�ȼ�
		case 320730001://���޾���  320740001 �˺�
			//echo("buff�Ƴ�ͳһ�������� ====" @  %Caster @ "    " @ %BuffId);
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 10,30,1,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			//echo("%FanWeiMonster===" @ %FanWeiMonster);
			%Number = 0;
			for (%i = 0;%i < %FanWeiMonsterNum;%i++)
			{
				%Target = GetWord(%FanWeiMonster,%i);
				if (%Target.GetDamageState() $= "Enabled")
					%Number++;
			}
			//echo("%Number===" @ %Number);
			if (%Number <= 0)
				return;
			%Caster.addpacket(110401);
			%BuffCount = mceil(500/%Number);
			//echo("%BuffCount===" @ %BuffCount);
			for (%i = 0;%i < %FanWeiMonsterNum;%i++)
			{
				%Target = GetWord(%FanWeiMonster,%i);
				//echo("%Target===" @ %Target);
				%TarGet.Addbuff(320740001,%Caster.Skill26013,%BuffCount);
			}
	}
}
//����������������������Buff�����ű�������������������������������������


//����������������������AI�Ը񴥷��ű�����������������������������������

//����������������������AI�Ը񴥷��ű�����������������������������������


//�����������������������ܵ������˺������ű�����������������������������
function TriggerScriptWhenDie(%Monster,%SkillId)
{
	%FuncName = "ScriptWhenDie_" @ %SkillId;

	if (isFunction(%FuncName))
		Call(%FuncName,%Monster);
}
//�����������������������ܵ������˺������ű�����������������������������



//��������������������������BOSS���AI����������������������������������
$TongYongAi_SkillGroup = 30;
$TongYongAi_Skill[1]="320010001 1";  //ǿ������LV1 100%��������ӳɣ�ģ�ͷŴ�1.2��
$TongYongAi_Skill[2]="320010002 1";  //ǿ������LV2 200%��������ӳɣ�ģ�ͷŴ�1.4��
$TongYongAi_Skill[3]="320010003 1";  //ǿ������LV3 300%��������ӳɣ�ģ�ͷŴ�1.6��
$TongYongAi_Skill[4]="320020001 2";  //���� ������������������+200%
$TongYongAi_Skill[5]="320030001 3";  //��Ӱ�� 75%����
$TongYongAi_Skill[6]="320040001 4";  //ħ���� ��Ʒ�˺�����75%��ħ���˺�����75%
$TongYongAi_Skill[7]="320050001 5";  //��˫ ����ʱ������Ŀ��������Ʒ�����+99999
$TongYongAi_Skill[8]="320060001 6";  //����LV1 �������30%
$TongYongAi_Skill[9]="320060002 6";  //����LV2 �������50%
$TongYongAi_Skill[10]="320060003 6";  //����LV3 �������70%
$TongYongAi_Skill[11]="320070001 7";  //��������LV1 ħ������30%
$TongYongAi_Skill[12]="320070002 7";  //��������LV2 ħ������50%
$TongYongAi_Skill[13]="320070003 7";  //��������LV3 ħ������70%
$TongYongAi_Skill[14]="320080001 8";  //ս��֮�� ��������
$TongYongAi_Skill[15]="320080002 8";  //�������� ħ������
$TongYongAi_Skill[16]="320090001 9";  //�����⻷LV1 5%�˺�����
$TongYongAi_Skill[17]="320090002 9";  //�����⻷LV2 10%�˺�����
$TongYongAi_Skill[18]="320090003 9";  //�����⻷LV3 15%�˺�����
$TongYongAi_Skill[19]="320100001 10"; //��������LV1 ������+20%
$TongYongAi_Skill[20]="320100002 10"; //��������LV2 ������+40%
$TongYongAi_Skill[21]="320100003 10"; //��������LV3 ������+60%
$TongYongAi_Skill[22]="320110001 11"; //��Ѫ��LV1 30%������
$TongYongAi_Skill[23]="320110002 11"; //��Ѫ��LV2 60%������
$TongYongAi_Skill[24]="320110003 11"; //��Ѫ��LV3 100%������
$TongYongAi_Skill[25]="320120001 12"; //�����ӰLV1 �ƶ��ٶ�20%�������ٶ�30%
$TongYongAi_Skill[26]="320120002 12"; //�����ӰLV2 �ƶ��ٶ�40%�������ٶ�60%
$TongYongAi_Skill[27]="320120003 12"; //�����ӰLV3 �ƶ��ٶ�60%�������ٶ�90%
$TongYongAi_Skill[28]="320130001 13"; //����֮�� �õ�λ˼ά���ң�����޷�����
$TongYongAi_Skill[29]="320140001 14"; //������ �ܵ�����ʱ30%���ʴ�����ץȡ����һ����λ����ǰ���õ�λ������Ϊ��߳��Ŀ��
$TongYongAi_Skill[30]="320150001 15"; //��� ����ʱ15%����ʹĿ��ѣ��3�룬ѣ���ڼ��ܵ�200%���˺�
$TongYongAi_Skill[31]="320160001 16"; //���ܻ� �ܵ�����ʱ��5%���ʻ�����Χ5M�����е�λ����ѣ��5S
$TongYongAi_Skill[32]="320170001 17"; //�ռ�ת�� �ܵ�����ʱ��2%�����������һ��Ŀ�꣬���䴫�͵���ǰ��ͼ������һ������
$TongYongAi_Skill[33]="320180001 18"; //��־ŭ�� �ܵ�����ʱ��������ŭ��������ѣ����Χ30M�����е�λ��ѣ��ʱ��5S
$TongYongAi_Skill[34]="320190001 19"; //��������LV1 ��������30%ʱ��������+30%�������ٶ�+30%���ƶ��ٶ�+30%
$TongYongAi_Skill[35]="320190002 19"; //��������LV2 ��������30%ʱ��������+60%�������ٶ�+60%���ƶ��ٶ�+60%
$TongYongAi_Skill[36]="320190003 19"; //��������LV3 ��������30%ʱ��������+100%�������ٶ�+100%���ƶ��ٶ�+100%
$TongYongAi_Skill[37]="320200001 20"; //ħ������LV1 �κο���ħ��ĵ�λ�������ܵ�ѹ�ƣ�ȫ���Խ���10%�����һ�����ʧ�����أ�ÿ��1%��
$TongYongAi_Skill[38]="320200002 20"; //ħ������LV2 �κο���ħ��ĵ�λ�������ܵ�ѹ�ƣ�ȫ���Խ���20%�����һ�����ʧ�����أ�ÿ��1.5%��
$TongYongAi_Skill[39]="320200003 20"; //ħ������LV3 �κο���ħ��ĵ�λ�������ܵ�ѹ�ƣ�ȫ���Խ���30%�����һ�����ʧ�����أ�ÿ��2%��
$TongYongAi_Skill[40]="320210001 21"; //�㶾��LV1 ������Ŀ����ж����ж�״̬����30S��ÿ����ʧ5%+500����
$TongYongAi_Skill[41]="320210002 21"; //�㶾��LV2 ������Ŀ����ж����ж�״̬����30S��ÿ����ʧ5%+1000����
$TongYongAi_Skill[42]="320210003 21"; //�㶾��LV3 ������Ŀ����ж����ж�״̬����30S��ÿ����ʧ5%+1500����
$TongYongAi_Skill[43]="320220001 22"; //����LV1 ս��ʱ20%���⹥��1��
$TongYongAi_Skill[44]="320220002 22"; //����LV2 ս��ʱ20%���⹥��2��
$TongYongAi_Skill[45]="320220003 22"; //����LV3 ս��ʱ20%���⹥��3��
$TongYongAi_Skill[46]="320230001 23"; //����߱�� ����ʱ5%������ʹ��ǰĿ��ǿ�ƽ��������ж��������������30%����������Ŀ��ÿ��ʧ1%���Ѫ�������������1%����߸���100%
$TongYongAi_Skill[47]="320240001 24"; //Ⱥħ���� ����ս�����ٻ�һ���ͱ���ͬ���Եķ����������ʱ��10���ӣ�ͬһʱ�䣬����������2����
$TongYongAi_Skill[48]="320250001 25"; //������ת ǰ10S����������ޣ���10S�����������ޣ�ĩ10S������������
$TongYongAi_Skill[49]="320260001 26"; //��ϵ������ʦLV1 ս��ʱ��30%���ʴ�����������������Ŀ��ʩ���򽣹���
$TongYongAi_Skill[50]="320260002 26"; //��ϵ������ʦLV2 ս��ʱ��30%���ʴ�����������������Ŀ��ʩ���򽣹���
$TongYongAi_Skill[51]="320260003 26"; //��ϵ������ʦLV3 ս��ʱ��30%���ʴ�����������������Ŀ��ʩ���򽣹���
$TongYongAi_Skill[52]="320270001 27"; //��ϵ������ʦLV1 ս��ʱ��30%���ʴ������������ʩ�����ǻ���
$TongYongAi_Skill[53]="320270002 27"; //��ϵ������ʦLV2 ս��ʱ��30%���ʴ������������ʩ�����ǻ���
$TongYongAi_Skill[54]="320270003 27"; //��ϵ������ʦLV3 ս��ʱ��30%���ʴ������������ʩ�����ǻ���
$TongYongAi_Skill[55]="320280001 28"; //��ϵ������ʦLV1 ս��ʱ��30%���ʴ������������ʩ�ű�ѩ����
$TongYongAi_Skill[56]="320280002 28"; //��ϵ������ʦLV2 ս��ʱ��30%���ʴ������������ʩ�ű�ѩ����
$TongYongAi_Skill[57]="320280003 28"; //��ϵ������ʦLV3 ս��ʱ��30%���ʴ������������ʩ�ű�ѩ����
$TongYongAi_Skill[58]="320290001 29"; //ľϵ������ʦLV1 ս��ʱ��30%���ʴ������������ʩ�Ÿ������
$TongYongAi_Skill[59]="320290002 29"; //ľϵ������ʦLV2 ս��ʱ��30%���ʴ������������ʩ�Ÿ������
$TongYongAi_Skill[60]="320290003 29"; //ľϵ������ʦLV3 ս��ʱ��30%���ʴ������������ʩ�Ÿ������
$TongYongAi_Skill[61]="320300001 30"; //��ϵ������ʦLV1 ս��ʱ��30%���ʴ��������Ŀ��ʩ��ս�����
$TongYongAi_Skill[62]="320300002 30"; //��ϵ������ʦLV2 ս��ʱ��31%���ʴ��������Ŀ��ʩ��ս�����
$TongYongAi_Skill[63]="320300003 30"; //��ϵ������ʦLV3 ս��ʱ��32%���ʴ��������Ŀ��ʩ��ս�����

for (%i = 1; %i <= $TongYongAi_SkillGroup; %i++)
{
	$TongYongAi_SkillGroup[%i]="";
}
for (%i=1; %i<=63; %i++)
{
	if ($TongYongAi_Skill[%i] $= "")
		break;
	%SkillBuffID = GetWord($TongYongAi_Skill[%i],0);
	%GroupID = GetWord($TongYongAi_Skill[%i],1);
	$TongYongAi_SkillGroup[%GroupID] = %SkillBuffID @ " " @ $TongYongAi_SkillGroup[%GroupID];
}
function AddSkill_TongYongAI(%Npc,%NpcID)
{
	%Step = GetNpcData(%NpcID,17);//��ȡ��������
	//echo( "%Step ===" @ %Step );
	//echo( "%NpcID ===" @ %NpcID );
	if (%Step  == 4)
	{
		if (%Npc.Ai_Skill[1] > 0)//����ս������BUFF
		{
			for (%i = 1; %i <= 10; %i++)
			{
				if (%Npc.Ai_Skill[%i] > 0 && %Npc.GetBuffCount(GetSubStr(%Npc.Ai_Skill[%i],0,5),GetSubStr(%Npc.Ai_Skill[%i],5,4) * 1) < 1)
					%Npc.AddBuff(%Npc.Ai_Skill[%i],%Npc,1);
				else
					break;
			}
		}
		else//ˢ��ʱ����
		{
			//----------��ȡ��������-----------
			switch (%Npc.GetDataID())
			{
				case 411180002:%Ran = GetRanDom(1,1);
				case 411180003:%Ran = GetRanDom(1,1);
				case 411180004:%Ran = GetRanDom(1,1);
				case 440000017:%Ran = GetRanDom(1,1);
				case 440000015:%Ran = GetRanDom(1,1);
				case 440000016:%Ran = GetRanDom(1,1);
				case 410101018:%Ran = GetRanDom(1,1);
				case 410101019:%Ran = GetRanDom(1,1);
				case 413033001:%Ran = 0;
				case 413033002:%Ran = 0;
				case 413033003:%Ran = 0;
				case 413033004:%Ran = 0;
				case 413181003:%Ran = 0;
				default:
					%Ran = GetRanDom(3,5);
			}
			if (%Ran <= 0)
				return;
			//--------ɸѡ����------------
			switch (%Npc.GetDataID())
			{
				case 440000010:%GroupList = GetRandomNum2(%Ran, 1, $TongYongAi_SkillGroup, "24 27 30");
				default:
					%GroupList = GetRandomNum2(%Ran, 1, $TongYongAi_SkillGroup, "24");
			}

			//%GroupList = GetRandomNum( %Ran, 1, $TongYongAi_SkillGroup );
			%Count = GetWordCount(%GroupList);
			for (%i = 0; %i < %Count; %i++)
			{
				%RanNum = GetWord(%GroupList,%i);
				%NeedAiBuff = GetWord($TongYongAi_SkillGroup[%RanNum],GetRanDom(0,GetWordCount($TongYongAi_SkillGroup[%RanNum]) -1));
				if (%NeedAiBuff > 0)
				{
					%Npc.Ai_Skill[%i + 1] = %NeedAiBuff;
					%Npc.AddBuff(%NeedAiBuff,%Npc,1);
				}
			}
		}
	}
	//for ( %i = 1; %i <= 10; %i++ )
	//{
	//	if ( %Npc.Ai_Skill[ %i ] > 0 )
	//		echo( %Npc.Ai_Skill[ %i ] );
	//	else
	//		break;
	//}
}
//��������������������������BOSS���AI����������������������������������