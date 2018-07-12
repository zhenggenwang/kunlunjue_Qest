//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//服务端任务脚本集，包含所有特殊的任务脚本
//
//==================================================================================
//■■■■■■■■■■■队伍设置Missionflag■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■对话类任务专用接口■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■特殊对话框打开所需NPC■■■■■■■■■■■■■■■■■

//参考格式：

function Mission_Special(%Npc,%Player,%State,%Conv,%Param)
{
	%ZoneID = GetSubStr(GetZoneID(),0,4);
	//echo( "Mission_Special" );
	switch (%ZoneID)
	{
		case 1001://昆仑
			switch (%Npc.GetDataID())
			{
				case 400001514: return Mission_Special_21029(%Npc,%Player,%State,%Conv,21506);	//【处事勿贪】任务
					//------------生活技能心得--------------
				case 410010116: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30205);//铸造心得
				case 410010117: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30305);//裁缝心得
				case 410010118: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30405);//制器心得
				case 410010115: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30505);//炼丹心得
				case 410010119: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30605);//符咒心得
				case 410010140: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30705);//烹饪心得
			}
		case 1010://蓬莱
			switch (%Npc.GetDataID())
			{
				case 410100002: return
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//师门尽忠		舒樊
				case 410100003:
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//师门尽忠		玄业

				case 410100004:
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//师门尽忠		玄光

				case 410100005:
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//师门尽忠		玄仁
					Mission_Special_10341(%Npc,%Player,%State,%Conv,10341);	//进入禁地

				case 410100006: return
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//师门尽忠		张平凡
				case 410100007: return
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//师门尽忠		杨子石
				case 410100008: return
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//师门尽忠		张德山
				case 410100009: return
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//师门尽忠		王君
				case 410100010:
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//师门尽忠		玲珑

				case 410100011: return
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//师门尽忠		
				case 410100012:
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//师门尽忠		

				case 410100032: return
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//师门尽忠		芳华
				case 410100031: return
					Mission_Special_20149(%Npc,%Player,%State,%Conv,20149);	//师门尽忠		刹那


			}
		case 1128://陨仙窟
			switch (%Npc.GetDataID())
			{
				case 411280003: return Npc_Dialog_411280003(%Npc,%Player,%State,%Conv,%Param); //陨仙窟一层随机任务发布
				case 411280004: return Npc_Dialog_411280004(%Npc,%Player,%State,%Conv,%Param); //陨仙窟二层随机任务发布

					//陨仙窟一层营救NPC
				case 411280005: return Npc_Dialog_411280005_411280009(%Npc,%Player,%State,%Conv,%Param,411280005); //陨仙窟一层营救NPC
				case 411280006: return Npc_Dialog_411280005_411280009(%Npc,%Player,%State,%Conv,%Param,411280006); //陨仙窟一层营救NPC
				case 411280007: return Npc_Dialog_411280005_411280009(%Npc,%Player,%State,%Conv,%Param,411280007); //陨仙窟一层营救NPC
				case 411280008: return Npc_Dialog_411280005_411280009(%Npc,%Player,%State,%Conv,%Param,411280008); //陨仙窟一层营救NPC
				case 411280009: return Npc_Dialog_411280005_411280009(%Npc,%Player,%State,%Conv,%Param,411280009); //陨仙窟一层营救NPC
					//陨仙窟二层营救NPC																							
				case 411280010: return Npc_Dialog_411280010_411280014(%Npc,%Player,%State,%Conv,%Param,411280010); //陨仙窟二层营救NPC
				case 411280011: return Npc_Dialog_411280010_411280014(%Npc,%Player,%State,%Conv,%Param,411280011); //陨仙窟二层营救NPC
				case 411280012: return Npc_Dialog_411280010_411280014(%Npc,%Player,%State,%Conv,%Param,411280012); //陨仙窟二层营救NPC
				case 411280013: return Npc_Dialog_411280010_411280014(%Npc,%Player,%State,%Conv,%Param,411280013); //陨仙窟二层营救NPC
				case 411280014: return Npc_Dialog_411280010_411280014(%Npc,%Player,%State,%Conv,%Param,411280014); //陨仙窟二层营救NPC
			}
		case 1129://落日神陵
			switch (%Npc.GetDataId())
			{
				case 411290002: return Npc_Dialog_411290002(%Npc,%Player,%State,%Conv,%Param); //落日神陵1层随机任务发布
				case 411290004: return Npc_Dialog_411290004(%Npc,%Player,%State,%Conv,%Param); //落日神陵2层随机任务发布

					//落日神陵1层营救NPC
				case 411291009: return Npc_Dialog_411291009_411291013(%Npc,%Player,%State,%Conv,%Param,411291009); //落日神陵1层营救NPC
				case 411291010: return Npc_Dialog_411291009_411291013(%Npc,%Player,%State,%Conv,%Param,411291010); //落日神陵1层营救NPC
				case 411291011: return Npc_Dialog_411291009_411291013(%Npc,%Player,%State,%Conv,%Param,411291011); //落日神陵1层营救NPC
				case 411291012: return Npc_Dialog_411291009_411291013(%Npc,%Player,%State,%Conv,%Param,411291012); //落日神陵1层营救NPC
				case 411291013: return Npc_Dialog_411291009_411291013(%Npc,%Player,%State,%Conv,%Param,411291013); //落日神陵1层营救NPC

					//落日神陵2层营救NPC
				case 411291015: return Npc_Dialog_411291015_411291019(%Npc,%Player,%State,%Conv,%Param,411291015); //落日神陵2层营救NPC
				case 411291016: return Npc_Dialog_411291015_411291019(%Npc,%Player,%State,%Conv,%Param,411291016); //落日神陵2层营救NPC
				case 411291017: return Npc_Dialog_411291015_411291019(%Npc,%Player,%State,%Conv,%Param,411291017); //落日神陵2层营救NPC
				case 411291018: return Npc_Dialog_411291015_411291019(%Npc,%Player,%State,%Conv,%Param,411291018); //落日神陵2层营救NPC
				case 411291019: return Npc_Dialog_411291015_411291019(%Npc,%Player,%State,%Conv,%Param,411291019); //落日神陵2层营救NPC
			}
	}
	//不分地图
	switch (%Npc.GetDataID())
	{
		case 410100025:return Mission_Special_10001(%Npc,%Player,%State,%Conv,10001);	//新手指引		扬子石 10001
		case 411020012:return Npc_Dialog_411020012(%Npc,%Player,%State,%Conv,%Param);//苍山雪海临时用传送NPC
		case 410100062:return Mission_Special_10191(%Npc,%Player,%State,%Conv,10191);//戒律
		case 410100054:return Mission_Special_10151(%Npc,%Player,%State,%Conv,10151);//药园深处
			//---------生活技能心得---------------
		case 411020020: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30103);//挖矿心得
		case 410100053: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30113);//伐木心得
		case 410100002: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30123);//采药心得
		case 411010003: return Mission_ShengHuoJiNeng_XinDe(%Npc,%Player,%State,%Conv,30133);//钓鱼心得

		case 411010020: return WangXianGu_YunYouYinShi_ChuFa(%Npc,%Player,%State,%Conv,20205);//望仙谷-云游隐士
	}
}
