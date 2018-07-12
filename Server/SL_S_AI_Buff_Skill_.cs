//■■■■■■■■■■■Ai技能触发脚本■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■Buff触发脚本■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■受到致死伤害死亡脚本触发■■■■■■■■■■■■
//■■■■■■■■■■■首领BOSS添加AI■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■Ai技能触发脚本■■■■■■■■■■■■■■■■■
function AiSkill_Trigger_Occurrence(%Caster,%SkillId)
{
	putout("%Caster ==" @ %Caster @ "  " @ %Caster.GetObjectname() @ "   %SkillId==" @   %SkillId);
	switch (%SkillId)
	{
		case 200040003://巡逻修士的普攻
			%Target = %Caster.GetTarget();
			if (isobject(%Target))
				%Target.Addpacket(690816);
		case 259990001:
			//获取范围怪物（坐标 @ " " @ 范围，数量，作用对象，对象）
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,30,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			for (%i = 0; %i < %FanWeiMonsterNum; %i++)
			{
				//获取怪物对象
				%opj = GetWord(%FanWeiMonster,%i);
				%opj.AddBuff(320740001,%Caster,25);
				%opj.addpacket(625009);
			}
		case 260010001://混乱之治
			for (%i = 0; %i >= 0; %i++)
			{
				//获取仇恨列表中的值
				%Target = %Caster.getHateListObject(%i);
				//没有仇恨了暂停
				if (%Target == 0)
					break;

				%Target.SetHate(%Caster,GetRanDom(1,10000));
			}
		case 260010002://擒龙手
			for (%i = 0; %i >= 0; %i++)
			{
				//获取仇恨列表中的值
				%Target = %Caster.getHateListObject(%i);
				//没有仇恨了暂停
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
		case 260010003://抗拒火环
			%Caster.addpacket(800004);
		case 260010004://空间转换
			for (%i = 0; %i >= 0; %i++)
			{
				//获取仇恨列表中的值
				%Target = %Caster.getHateListObject(%i);
				//没有仇恨了暂停
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
		case 260010005://挫志怒吼 BUFF：32034 1 挫志怒吼
			//获取范围怪物（坐标 @ " " @ 范围，数量，作用对象，对象）
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,30,0,%Caster);
			//echo(findObjectsInRegion( 263260.GetPosition( ) @ " " @ 20, 12, 0, 263260 ));
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			//echo( "%FanWeiMonster===" @ %FanWeiMonster );
			for (%i = 0; %i < %FanWeiMonsterNum; %i++)
			{
				//获取怪物对象
				%opj = GetWord(%FanWeiMonster,%i);
				%opj.AddBuff(320340001,%Caster,1);
			}
		case 260010006://临死反击LV1 32035 1 临死反击LV1
			%HP = %Caster.GetHP();
			%MaxHP = %Caster.GetMaxHP();
			if (%HP / %MaxHP  < 0.3)
				%Caster.AddBuff(320350001,%Caster,1);
		case 260010007://临死反击LV2 32036 1 临死反击LV2
			%HP = %Caster.GetHP();
			%MaxHP = %Caster.GetMaxHP();
			if (%HP / %MaxHP  < 0.3)
				%Caster.AddBuff(320360001,%Caster,1);
		case 260010008://临死反击LV3 32037 1 临死反击LV3
			%HP = %Caster.GetHP();
			%MaxHP = %Caster.GetMaxHP();
			if (%HP / %MaxHP  < 0.3)
				%Caster.AddBuff(320370001,%Caster,1);
		case 260010009://魔神领域LV1 32038 1 魔神领域LV1  全属性被 压制30%   32050 1  缓慢损失生命（每秒1%）
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,30,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			for (%i = 0; %i < %FanWeiMonsterNum; %i++)
			{
				//获取怪物对象
				%opj = GetWord(%FanWeiMonster,%i);
				%opj.AddBuff(320380001,%Caster,1);
				%opj.AddBuff(320500001,%Caster,1);
			}
		case 260010010://魔神领域LV2 32039 1 魔神领域LV2  全属性被 压制30%   32051 1  缓慢损失生命（每秒1.5%）
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,30,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			for (%i = 0; %i < %FanWeiMonsterNum; %i++)
			{
				//获取怪物对象
				%opj = GetWord(%FanWeiMonster,%i);
				%opj.AddBuff(320390001,%Caster,1);
				%opj.AddBuff(320510001,%Caster,1);
			}
		case 260010011://魔神领域LV3 32040 1 魔神领域LV3  全属性被 压制30%   32052 1  缓慢损失生命（每秒2%）
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,30,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			for (%i = 0; %i < %FanWeiMonsterNum; %i++)
			{
				//获取怪物对象
				%opj = GetWord(%FanWeiMonster,%i);
				%opj.AddBuff(320400001,%Caster,1);
				%opj.AddBuff(320520001,%Caster,1);
			}
		case 260010012://诛仙弑神
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
		case 260010013://群魔乱舞
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
			MirrorimageNPCServer(%DataID,%Opj);//替换模型
			%Opj.AddEnemyBuffPercent(%Caster,10000); //继承属性

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
		case 260010015://金系法术宗师LV1
			//获取范围怪物（坐标 @ " " @ 范围，数量，作用对象，对象）
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,30,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			for (%i = 0; %i < %FanWeiMonsterNum; %i++)
			{
				%opj = GetWord(%FanWeiMonster,%i);
				%opj.AddBuff(320530001,%Caster,1);
			}
		case 260010016://金系法术宗师LV2
			//获取范围怪物（坐标 @ " " @ 范围，数量，作用对象，对象）
			%FanWeiMonster = findObjectsInRegion(%Caster.GetPosition() @ " " @ 30,30,0,%Caster);
			%FanWeiMonsterNum = GetWordCount(%FanWeiMonster);
			for (%i = 0; %i < %FanWeiMonsterNum; %i++)
			{
				%opj = GetWord(%FanWeiMonster,%i);
				%opj.AddBuff(320530002,%Caster,1);
			}
		case 260010017://金系法术宗师LV3
			//获取范围怪物（坐标 @ " " @ 范围，数量，作用对象，对象）
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
		case 260010018://火系法术宗师LV1 260030001 流星火雨
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
		case 260010019://火系法术宗师LV2 260030002 流星火雨
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
		case 260010020://火系法术宗师LV3 260030003 流星火雨
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

		case 260010021://冰系法术宗师LV1 260040001 冰雪飘零
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
		case 260010022://冰系法术宗师LV2 260040002 冰雪飘零
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
		case 260010023://冰系法术宗师LV3 260040003 冰雪飘零
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
		case 260010024://木系法术宗师LV1
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
		case 260010025://木系法术宗师LV2
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
		case 260010026://木系法术宗师LV3
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
		case 260010027://土系法术宗师LV1
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
		case 260010028://土系法术宗师LV2
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
		case 260010029://土系法术宗师LV3
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
		case 263000001:AiSkill_Trigger_263000001(%Caster);//怨灵狂暴
		case 263000002:AiSkill_Trigger_263000002(%Caster);//怨灵狂暴 搜索主人
		case 263010001:AiSkill_Trigger_263010001(%Caster);//死灵同归
		case 263010003:AiSkill_Trigger_263010003(%Caster);//死灵同归 自杀
		case 263030001:AiSkill_Trigger_263030001(%Caster);//魔刹四方
		case 263030002:AiSkill_Trigger_263030002(%Caster);//魔刹四方 搜索目标
		case 200180001:AiSkill_Trigger_200180001(%Caster);//回城
		case 200190001:AiSkill_Trigger_200190001(%Caster);//传送灵脉
		case 240200001:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200002:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200003:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200004:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200005:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200006:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200007:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200008:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200009:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200010:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200011:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200012:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200013:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200014:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200015:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200016:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200017:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200018:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200019:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200020:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200021:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200022:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200023:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200024:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200025:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200026:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200027:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200028:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200029:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 240200030:FuHuoJiNeng(%Caster,%SkillId);//道士复活技能 
		case 260130001://云罗镜灭
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

			%text0 = "【" @ %Target.GetObjectName() @ "】被[云罗镜灭]命中，请靠近分摊伤害。";
			if (isplayer(%TarGet))
				%Text1 = GetPlayerZiTiName(%TarGet,1) @ "<t>被[云罗镜灭]命中，请靠近分摊伤害。</t>";
			else
				%Text1 = "<t>" @ %Target.GetObjectName() @ "被[云罗镜灭]命中，请靠近分摊伤害。</t>";
			SendAllChatMessageLayer(1,$Get_Dialog_GeShi[31406]  @ %Text1 @ "</t>",%CopyMapID);	//发送副本层消息( 屏幕左下 )
			SendAllScreenMessageLayer(1,%text0,%CopyMapID);	//发送副本层消息( 屏幕中间 )

		case 260140001://云罗结界
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
				%TeammateList = SptCopyMap_GetAllPlayer(%CopyMapID);//获取副本玩家信息
				%TeammateNum = SptCopyMap_GetPlayerCount(%CopyMapID);//获取副本玩家数量
				for (%i = 0; %i < %TeammateNum; %i++)
				{
					%Player = GetWord(%TeammateList,%i);
					if (%Player.GetDamageState() $= "Enabled")
						%Player.Addbuff(320740001,$CopyMapBattleStateReocrd[%CopyMapID,1],50);
				}
			}
			$CopyMapBattleStateReocrd[%CopyMapID,1].addbuff(320750001,$CopyMapBattleStateReocrd[%CopyMapID,1],1);

			%text0 = "【云罗教主】获得[云罗结界]加持，进入无敌状态，请尽快破坏结界节点";
			SendAllChatMessageLayer(1,$Get_Dialog_GeShi[31406]  @ %text0 @ "</t>",%CopyMapID);	//发送副本层消息( 屏幕左下 )
			SendAllScreenMessageLayer(0,"请速度破坏结界节点",%CopyMapID);	//发送副本层消息( 屏幕中间 )
		case 260150001://飓风破
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
		case 260170001://BOSS技能 火墙术
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
		SendOneScreenMessage(2,"20级后才可以使用回城技能",%Player);
		SendOneChatMessage($chatMsg_System,"<t>20级后才可以使用回城技能</t>",%Player);
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
		SendOneScreenMessage(2,"阁下修为尚浅，请于30级以后再来搜寻灵脉",%Player);
		SendOneChatMessage($chatMsg_System,"<t>阁下修为尚浅，请于30级以后再来搜寻灵脉</t>",%Player);
		return;
	}
	if (GetZoneID() != 1001)
	{
		SendOneScreenMessage(2,"此处并无灵脉，请前往昆仑搜寻",%Player);
		SendOneChatMessage($chatMsg_System,"<t>此处并无灵脉，请前往昆仑搜寻</t>",%Player);
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
//■■■■■■■■■■■Ai技能触发脚本■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■Buff触发脚本■■■■■■■■■■■■■■■■■■

function AiBuff_Trigger_Occurrence(%Caster,%BuffId)
{
	//if ( %Caster.GetClassName( ) $= "Player" )
	//	echo( "%Caster ==" @ %Caster @ "  " @ %Caster.GetObjectname( ) @ "   %BuffId==" @   %BuffId );
	switch (%BuffId)
	{
		case 320090001://荆棘光环LV1
			Schedule(1000,0,"eval",%Caster @ ".AddBuff(320090001," @ %Caster @ ",1000000); ");
		case 320090002://荆棘光环LV2
			Schedule(1000,0,"eval",%Caster @ ".AddBuff(320090002," @ %Caster @ ",1000000); ");
		case 320090003://荆棘光环LV3
			Schedule(1000,0,"eval",%Caster @ ".AddBuff(320090003," @ %Caster @ ",1000000); ");
		case 320250001://阴阳逆转 物理防御极限
			%Caster.AddBuff(320480001,%Caster,1);
		case 320480001://阴阳逆转 法术防御极限
			%Caster.AddBuff(320490001,%Caster,1);
		case 320490001://阴阳逆转 正常状态
			%Caster.AddBuff(320250001,%Caster,1);
		case 399040001://满10层移除 冰火试炼采药BUFF
			if (%Caster.GetBuffCount(39904,1) >= 10)
			{
				%Caster.RemoveBuff(399040001);
				%Caster.RemoveBuff(399030001);
				SendOneScreenMessage(2,"你的草药已经丢失，重新回去采集吧",%Caster);
				SendOneChatMessage($chatMsg_System,"<t>你的草药已经丢失，重新回去采集吧</t>",%Caster);

				%Level = %Caster.GetLevel();
				if (%Level <= 44) %Mid = 20005;
				else if (%Level <= 59) %Mid = 20013;
				else if (%Level <= 75) %Mid = 20021;

				%Caster.SetMissionFlag(%Mid,3300,0);
				%Caster.UpdateMission(%Mid);
			}
	}
}

function AiBuff_Trigger_Remove(%Caster,%BuffId) //buff移除统一触发函数，需要在buffskilldata中配置
{
	//echo( "buff移除统一触发函数 ====" @  %Caster @ "    " @ %BuffId );
	switch (%BuffId)
	{
		case 390300001://首座论经 发题目
			ShouZuoLunJing_ShouDaoTiMu(%Caster);
		case 390310001://首座论经 揭晓答案
			ShouZuoLunJing_FaDaAn(%Caster);
		case 399080001:
			Schedule(5000,0,"ShiJieLevelJiaCheng",%Caster);//计算和添加当前的加成BUFF等级
		case 320730001://云罗镜灭  320740001 伤害
			//echo("buff移除统一触发函数 ====" @  %Caster @ "    " @ %BuffId);
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
//■■■■■■■■■■■Buff触发脚本■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■AI性格触发脚本■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■AI性格触发脚本■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■受到致死伤害死亡脚本触发■■■■■■■■■■■■
function TriggerScriptWhenDie(%Monster,%SkillId)
{
	%FuncName = "ScriptWhenDie_" @ %SkillId;

	if (isFunction(%FuncName))
		Call(%FuncName,%Monster);
}
//■■■■■■■■■■■受到致死伤害死亡脚本触发■■■■■■■■■■■■



//■■■■■■■■■■■首领BOSS添加AI■■■■■■■■■■■■■■■■■
$TongYongAi_SkillGroup = 30;
$TongYongAi_Skill[1]="320010001 1";  //强韧体魄LV1 100%最大生命加成，模型放大1.2倍
$TongYongAi_Skill[2]="320010002 1";  //强韧体魄LV2 200%最大生命加成，模型放大1.4倍
$TongYongAi_Skill[3]="320010003 1";  //强韧体魄LV3 300%最大生命加成，模型放大1.6倍
$TongYongAi_Skill[4]="320020001 2";  //坚韧 永不被暴击，坚韧率+200%
$TongYongAi_Skill[5]="320030001 3";  //风影盾 75%闪避
$TongYongAi_Skill[6]="320040001 4";  //魔法盾 物品伤害减免75%，魔法伤害减免75%
$TongYongAi_Skill[7]="320050001 5";  //无双 攻击时，无视目标防御，破防属性+99999
$TongYongAi_Skill[8]="320060001 6";  //防御LV1 物理防御30%
$TongYongAi_Skill[9]="320060002 6";  //防御LV2 物理防御50%
$TongYongAi_Skill[10]="320060003 6";  //防御LV3 物理防御70%
$TongYongAi_Skill[11]="320070001 7";  //灵力抗性LV1 魔法防御30%
$TongYongAi_Skill[12]="320070002 7";  //灵力抗性LV2 魔法防御50%
$TongYongAi_Skill[13]="320070003 7";  //灵力抗性LV3 魔法防御70%
$TongYongAi_Skill[14]="320080001 8";  //战神之躯 物理免疫
$TongYongAi_Skill[15]="320080002 8";  //五行仙体 魔法免疫
$TongYongAi_Skill[16]="320090001 9";  //荆棘光环LV1 5%伤害反弹
$TongYongAi_Skill[17]="320090002 9";  //荆棘光环LV2 10%伤害反弹
$TongYongAi_Skill[18]="320090003 9";  //荆棘光环LV3 15%伤害反弹
$TongYongAi_Skill[19]="320100001 10"; //天生神力LV1 攻击力+20%
$TongYongAi_Skill[20]="320100002 10"; //天生神力LV2 攻击力+40%
$TongYongAi_Skill[21]="320100003 10"; //天生神力LV3 攻击力+60%
$TongYongAi_Skill[22]="320110001 11"; //嗜血狂暴LV1 30%暴击率
$TongYongAi_Skill[23]="320110002 11"; //嗜血狂暴LV2 60%暴击率
$TongYongAi_Skill[24]="320110003 11"; //嗜血狂暴LV3 100%暴击率
$TongYongAi_Skill[25]="320120001 12"; //疾风幻影LV1 移动速度20%，攻击速度30%
$TongYongAi_Skill[26]="320120002 12"; //疾风幻影LV2 移动速度40%，攻击速度60%
$TongYongAi_Skill[27]="320120003 12"; //疾风幻影LV3 移动速度60%，攻击速度90%
$TongYongAi_Skill[28]="320130001 13"; //混乱之治 该单位思维混乱，仇恨无法控制
$TongYongAi_Skill[29]="320140001 14"; //擒龙手 受到攻击时30%几率触发，抓取束缚一个单位到身前，该单位立即成为最高仇恨目标
$TongYongAi_Skill[30]="320150001 15"; //麻痹 攻击时15%概率使目标眩晕3秒，眩晕期间受到200%的伤害
$TongYongAi_Skill[31]="320160001 16"; //抗拒火环 受到攻击时，5%概率击飞周围5M内所有单位，并眩晕5S
$TongYongAi_Skill[32]="320170001 17"; //空间转换 受到攻击时，2%概率随机锁定一个目标，将其传送到当前地图的任意一个坐标
$TongYongAi_Skill[33]="320180001 18"; //挫志怒吼 受到攻击时，发出愤怒的咆哮，眩晕周围30M内所有单位，眩晕时间5S
$TongYongAi_Skill[34]="320190001 19"; //临死反击LV1 生命低于30%时，攻击力+30%，攻击速度+30%，移动速度+30%
$TongYongAi_Skill[35]="320190002 19"; //临死反击LV2 生命低于30%时，攻击力+60%，攻击速度+60%，移动速度+60%
$TongYongAi_Skill[36]="320190003 19"; //临死反击LV3 生命低于30%时，攻击力+100%，攻击速度+100%，移动速度+100%
$TongYongAi_Skill[37]="320200001 20"; //魔神领域LV1 任何靠近魔神的单位，都会受到压制，全属性降低10%，并且缓慢损失生命呢（每秒1%）
$TongYongAi_Skill[38]="320200002 20"; //魔神领域LV2 任何靠近魔神的单位，都会受到压制，全属性降低20%，并且缓慢损失生命呢（每秒1.5%）
$TongYongAi_Skill[39]="320200003 20"; //魔神领域LV3 任何靠近魔神的单位，都会受到压制，全属性降低30%，并且缓慢损失生命呢（每秒2%）
$TongYongAi_Skill[40]="320210001 21"; //淬毒术LV1 被攻击目标会中毒，中毒状态持续30S，每秒损失5%+500生命
$TongYongAi_Skill[41]="320210002 21"; //淬毒术LV2 被攻击目标会中毒，中毒状态持续30S，每秒损失5%+1000生命
$TongYongAi_Skill[42]="320210003 21"; //淬毒术LV3 被攻击目标会中毒，中毒状态持续30S，每秒损失5%+1500生命
$TongYongAi_Skill[43]="320220001 22"; //连击LV1 战斗时20%额外攻击1次
$TongYongAi_Skill[44]="320220002 22"; //连击LV2 战斗时20%额外攻击2次
$TongYongAi_Skill[45]="320220003 22"; //连击LV3 战斗时20%额外攻击3次
$TongYongAi_Skill[46]="320230001 23"; //诛仙弑神 攻击时5%触发，使当前目标强制进行致死判定，最低致死概率30%，被致死的目标每损失1%最大血量，致死率提高1%，最高概率100%
$TongYongAi_Skill[47]="320240001 24"; //群魔乱舞 进入战斗后，召唤一个和本尊同属性的分身，分身存在时间10分钟，同一时间，分身最多存在2个。
$TongYongAi_Skill[48]="320250001 25"; //阴阳逆转 前10S物理防御极限，中10S法术防御极限，末10S正常防御属性
$TongYongAi_Skill[49]="320260001 26"; //金系法术宗师LV1 战斗时，30%几率触发，对区域内所有目标施放万剑归宗
$TongYongAi_Skill[50]="320260002 26"; //金系法术宗师LV2 战斗时，30%几率触发，对区域内所有目标施放万剑归宗
$TongYongAi_Skill[51]="320260003 26"; //金系法术宗师LV3 战斗时，30%几率触发，对区域内所有目标施放万剑归宗
$TongYongAi_Skill[52]="320270001 27"; //火系法术宗师LV1 战斗时，30%几率触发，随机区域施放流星火雨
$TongYongAi_Skill[53]="320270002 27"; //火系法术宗师LV2 战斗时，30%几率触发，随机区域施放流星火雨
$TongYongAi_Skill[54]="320270003 27"; //火系法术宗师LV3 战斗时，30%几率触发，随机区域施放流星火雨
$TongYongAi_Skill[55]="320280001 28"; //冰系法术宗师LV1 战斗时，30%几率触发，随机区域施放冰雪法术
$TongYongAi_Skill[56]="320280002 28"; //冰系法术宗师LV2 战斗时，30%几率触发，随机区域施放冰雪法术
$TongYongAi_Skill[57]="320280003 28"; //冰系法术宗师LV3 战斗时，30%几率触发，随机区域施放冰雪法术
$TongYongAi_Skill[58]="320290001 29"; //木系法术宗师LV1 战斗时，30%几率触发，随机区域施放根须缠绕
$TongYongAi_Skill[59]="320290002 29"; //木系法术宗师LV2 战斗时，30%几率触发，随机区域施放根须缠绕
$TongYongAi_Skill[60]="320290003 29"; //木系法术宗师LV3 战斗时，30%几率触发，随机区域施放根须缠绕
$TongYongAi_Skill[61]="320300001 30"; //土系法术宗师LV1 战斗时，30%几率触发，随机目标施放战争冲刺
$TongYongAi_Skill[62]="320300002 30"; //土系法术宗师LV2 战斗时，31%几率触发，随机目标施放战争冲刺
$TongYongAi_Skill[63]="320300003 30"; //土系法术宗师LV3 战斗时，32%几率触发，随机目标施放战争冲刺

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
	%Step = GetNpcData(%NpcID,17);//获取怪物类型
	//echo( "%Step ===" @ %Step );
	//echo( "%NpcID ===" @ %NpcID );
	if (%Step  == 4)
	{
		if (%Npc.Ai_Skill[1] > 0)//进入战斗后检查BUFF
		{
			for (%i = 1; %i <= 10; %i++)
			{
				if (%Npc.Ai_Skill[%i] > 0 && %Npc.GetBuffCount(GetSubStr(%Npc.Ai_Skill[%i],0,5),GetSubStr(%Npc.Ai_Skill[%i],5,4) * 1) < 1)
					%Npc.AddBuff(%Npc.Ai_Skill[%i],%Npc,1);
				else
					break;
			}
		}
		else//刷新时触发
		{
			//----------获取技能数量-----------
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
			//--------筛选技能------------
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
//■■■■■■■■■■■首领BOSS添加AI■■■■■■■■■■■■■■■■■