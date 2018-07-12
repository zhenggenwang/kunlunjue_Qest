//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//一些帮助信息和指引，以及帮助界面之类杂七杂八的东西
//==================================================================================

//■■■■■■■■■■■更新地图生活材料图标■■■■■■■■■■■■■■■■■■■



//■■■■■■■■■■■更新地图生活材料图标■■■■■■■■■■■■■■■■■■■
function RefreshMaterialSign(%MapName)
{
	/*
	if ( $IsCreateMaterialSign != 1 )
	{
	for ( %i = 0; %i < 20; %i++ )
	{
	if ( isobject( ( "BigViewMap_MaterialSign" @ %i ) ) )
	( "BigViewMap_MaterialSign" @ %i ).delete( );
	new GuiBitmapCtrl( "BigViewMap_MaterialSign" @ %i ){ //
	canSaveDynamicFields = "0";
	Enabled = "1";
	isContainer = "0";
	//Profile = "GuiModelessDialogProfile";
	HorizSizing = "center";
	VertSizing = "top";
	position = "238 6";
	Extent = "30 30";
	MinExtent = "8 8";
	canSave = "1";
	Visible = "1";
	mustPrerender = "0";
	hovertime = "1000";
	alpha = "255";
	useFadeout = "1";
	bitmap = "gameres/gui/images/BigViewMap_MaterialSign_caoyao.png";
	wrap = "0";
	};
	BigViewMapCtrl.add( "BigViewMap_MaterialSign" @ %i );
	}
	$IsCreateMaterialSign = 1;
	}
	for ( %i = 0; %i < 20; %i++ )
	{
	( "BigViewMap_MaterialSign" @ %i ).SetVisible( 0 );
	}
	//BigViewMap_MaterialSign_caoyao
	//BigViewMap_MaterialSign_kuangshi
	//BigViewMap_MaterialSign_mucai
	//BigViewMap_MaterialSign_yuqun
	%MapId = GetZoneID( );
	switch$( %MapName )
	{
	case "望仙谷":
	BigViewMap_MaterialSign0.SetVisible( 1 );
	BigViewMap_MaterialSign0.SetBitmap( "gameres/gui/images/BigViewMap_MaterialSign_yuqun.png" );
	BigViewMap_MaterialSign0.Setposition( 440, 320 );
	$BigViewMap_MaterialSign[ 0 ] = $LivingSkillMaterial[ 4, 1 ];

	BigViewMap_MaterialSign1.SetVisible( 1 );
	BigViewMap_MaterialSign1.SetBitmap( "gameres/gui/images/BigViewMap_MaterialSign_yuqun.png" );
	BigViewMap_MaterialSign1.Setposition( 387, 313 );
	$BigViewMap_MaterialSign[ 1 ] = $LivingSkillMaterial[ 4, 2 ];

	BigViewMap_MaterialSign2.SetVisible( 1 );
	BigViewMap_MaterialSign2.SetBitmap( "gameres/gui/images/BigViewMap_MaterialSign_mucai.png" );
	BigViewMap_MaterialSign2.Setposition( 465, 450 );
	$BigViewMap_MaterialSign[ 2 ] = $LivingSkillMaterial[ 2, 2 ];

	BigViewMap_MaterialSign3.SetVisible( 1 );
	BigViewMap_MaterialSign3.SetBitmap( "gameres/gui/images/BigViewMap_MaterialSign_mucai.png" );
	BigViewMap_MaterialSign3.Setposition( 360, 425 );
	$BigViewMap_MaterialSign[ 3 ] = $LivingSkillMaterial[ 2, 2 ];

	BigViewMap_MaterialSign4.SetVisible( 1 );
	BigViewMap_MaterialSign4.SetBitmap( "gameres/gui/images/BigViewMap_MaterialSign_caoyao.png" );
	BigViewMap_MaterialSign4.Setposition( 375, 410 );
	$BigViewMap_MaterialSign[ 4 ] = $LivingSkillMaterial[ 3, 2 ];

	BigViewMap_MaterialSign5.SetVisible( 1 );
	BigViewMap_MaterialSign5.SetBitmap( "gameres/gui/images/BigViewMap_MaterialSign_caoyao.png" );
	BigViewMap_MaterialSign5.Setposition( 415, 400 );
	$BigViewMap_MaterialSign[ 5 ] = $LivingSkillMaterial[ 3, 2 ];

	BigViewMap_MaterialSign6.SetVisible( 1 );
	BigViewMap_MaterialSign6.SetBitmap( "gameres/gui/images/BigViewMap_MaterialSign_mucai.png" );
	BigViewMap_MaterialSign6.Setposition( 560, 515 );
	$BigViewMap_MaterialSign[ 6 ] = $LivingSkillMaterial[ 2, 2 ];

	BigViewMap_MaterialSign7.SetVisible( 1 );
	BigViewMap_MaterialSign7.SetBitmap( "gameres/gui/images/BigViewMap_MaterialSign_mucai.png" );
	BigViewMap_MaterialSign7.Setposition( 280, 370 );
	$BigViewMap_MaterialSign[ 7 ] = $LivingSkillMaterial[ 2, 1 ];

	BigViewMap_MaterialSign8.SetVisible( 1 );
	BigViewMap_MaterialSign8.SetBitmap( "gameres/gui/images/BigViewMap_MaterialSign_caoyao.png" );
	BigViewMap_MaterialSign8.Setposition( 290, 350 );
	$BigViewMap_MaterialSign[ 8 ] = $LivingSkillMaterial[ 3, 2 ];

	BigViewMap_MaterialSign9.SetVisible( 1 );
	BigViewMap_MaterialSign9.SetBitmap( "gameres/gui/images/BigViewMap_MaterialSign_caoyao.png" );
	BigViewMap_MaterialSign9.Setposition( 240, 340 );
	$BigViewMap_MaterialSign[ 9 ] = $LivingSkillMaterial[ 3, 2 ];

	BigViewMap_MaterialSign10.SetVisible( 1 );
	BigViewMap_MaterialSign10.SetBitmap( "gameres/gui/images/BigViewMap_MaterialSign_caoyao.png" );
	BigViewMap_MaterialSign10.Setposition( 170,260 );
	$BigViewMap_MaterialSign[ 10 ] = $LivingSkillMaterial[ 3, 2 ];

	BigViewMap_MaterialSign11.SetVisible( 1 );
	BigViewMap_MaterialSign11.SetBitmap( "gameres/gui/images/BigViewMap_MaterialSign_mucai.png" );
	BigViewMap_MaterialSign11.Setposition( 315, 240 );
	$BigViewMap_MaterialSign[ 11 ] = $LivingSkillMaterial[ 2, 1 ];

	BigViewMap_MaterialSign12.SetVisible( 1 );
	BigViewMap_MaterialSign12.SetBitmap( "gameres/gui/images/BigViewMap_MaterialSign_mucai.png" );
	BigViewMap_MaterialSign12.Setposition( 305, 200 );
	$BigViewMap_MaterialSign[ 12 ] = $LivingSkillMaterial[ 2, 1 ];

	BigViewMap_MaterialSign13.SetVisible( 1 );
	BigViewMap_MaterialSign13.SetBitmap( "gameres/gui/images/BigViewMap_MaterialSign_mucai.png" );
	BigViewMap_MaterialSign13.Setposition( 355, 280 );
	$BigViewMap_MaterialSign[ 13 ] = $LivingSkillMaterial[ 2, 1 ];

	BigViewMap_MaterialSign14.SetVisible( 1 );
	BigViewMap_MaterialSign14.SetBitmap( "gameres/gui/images/BigViewMap_MaterialSign_caoyao.png" );
	BigViewMap_MaterialSign14.Setposition( 490, 225 );
	$BigViewMap_MaterialSign[ 14 ] = $LivingSkillMaterial[ 3, 1 ];

	BigViewMap_MaterialSign15.SetVisible( 1 );
	BigViewMap_MaterialSign15.SetBitmap( "gameres/gui/images/BigViewMap_MaterialSign_mucai.png" );
	BigViewMap_MaterialSign15.Setposition( 460, 215 );
	$BigViewMap_MaterialSign[ 15 ] = $LivingSkillMaterial[ 2, 1 ];

	BigViewMap_MaterialSign16.SetVisible( 1 );
	BigViewMap_MaterialSign16.SetBitmap( "gameres/gui/images/BigViewMap_MaterialSign_caoyao.png" );
	BigViewMap_MaterialSign16.Setposition( 230, 140 );
	$BigViewMap_MaterialSign[ 16 ] = $LivingSkillMaterial[ 2, 1 ];

	BigViewMap_MaterialSign17.SetVisible( 1 );
	BigViewMap_MaterialSign17.SetBitmap( "gameres/gui/images/BigViewMap_MaterialSign_caoyao.png" );
	BigViewMap_MaterialSign17.Setposition( 410, 120 );
	$BigViewMap_MaterialSign[ 17 ] = $LivingSkillMaterial[ 2, 1 ];

	BigViewMap_MaterialSign18.SetVisible( 1 );
	BigViewMap_MaterialSign18.SetBitmap( "gameres/gui/images/BigViewMap_MaterialSign_caoyao.png" );
	BigViewMap_MaterialSign18.Setposition( 410, 120 );
	$BigViewMap_MaterialSign[ 17 ] = $LivingSkillMaterial[ 2, 1 ];
	case 1128:
	default:return;
	}
	*/
}
$LivingSkillMaterial[1,1] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>矿脉 1级</t><b/><t>采掘可获得铜矿、锡石</t></t>";
$LivingSkillMaterial[1,2] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>矿脉 2级</t><b/><t>采掘可获得铁矿、铅石</t></t>";
$LivingSkillMaterial[1,3] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>矿脉 3级</t><b/><t>采掘可获得银矿、锌石</t></t>";
$LivingSkillMaterial[1,4] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>矿脉 4级</t><b/><t>采掘可获得金矿、晶石</t></t>";
$LivingSkillMaterial[1,5] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>矿脉 5级</t><b/><t>采掘可获得黑铁矿、黑钨石</t></t>";
$LivingSkillMaterial[1,6] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>矿脉 6级</t><b/><t>采掘可获得秘银矿、方玉石</t></t>";
$LivingSkillMaterial[1,7] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>矿脉 7级</t><b/><t>采掘可获得魔金矿、霞辉石</t></t>";
$LivingSkillMaterial[1,8] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>矿脉 8级</t><b/><t>采掘可获得精金矿、翡翠石</t></t>";
$LivingSkillMaterial[1,9] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>矿脉 9级</t><b/><t>采掘可获得紫金矿、黑玉石</t></t>";
$LivingSkillMaterial[1,10]= "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>矿脉 10级</t><b/><t>采掘可获得耀金矿、炼天石</t></t>";

$LivingSkillMaterial[2,1] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>木材 1级</t><b/><t>砍伐可获得柳木</t></t>";
$LivingSkillMaterial[2,2] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>木材 2级</t><b/><t>砍伐可获得桐木</t></t>";
$LivingSkillMaterial[2,3] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>木材 3级</t><b/><t>砍伐可获得樟木</t></t>";
$LivingSkillMaterial[2,4] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>木材 4级</t><b/><t>砍伐可获得杉木</t></t>";
$LivingSkillMaterial[2,5] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>木材 5级</t><b/><t>砍伐可获得檀木</t></t>";
$LivingSkillMaterial[2,6] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>木材 6级</t><b/><t>砍伐可获得红木</t></t>";
$LivingSkillMaterial[2,7] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>木材 7级</t><b/><t>砍伐可获得铁木</t></t>";
$LivingSkillMaterial[2,8] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>木材 8级</t><b/><t>砍伐可获得玄木</t></t>";
$LivingSkillMaterial[2,9] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>木材 9级</t><b/><t>砍伐可获得神木</t></t>";
$LivingSkillMaterial[2,10]= "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>木材 10级</t><b/><t>砍伐可获得千年神木</t></t>";

$LivingSkillMaterial[3,1] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>药材 1级</t><b/><t>采集可获得紫草</t></t>";
$LivingSkillMaterial[3,2] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>药材 2级</t><b/><t>采集可获得金银花</t></t>";
$LivingSkillMaterial[3,3] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>药材 3级</t><b/><t>采集可获得首乌</t></t>";
$LivingSkillMaterial[3,4] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>药材 4级</t><b/><t>采集可获得当归</t></t>";
$LivingSkillMaterial[3,5] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>药材 5级</t><b/><t>采集可获得野山参</t></t>";
$LivingSkillMaterial[3,6] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>药材 6级</t><b/><t>采集可获得冬虫夏草</t></t>";
$LivingSkillMaterial[3,7] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>药材 7级</t><b/><t>采集可获得九曲灵参</t></t>";
$LivingSkillMaterial[3,8] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>药材 8级</t><b/><t>采集可获得8级草药</t></t>";
$LivingSkillMaterial[3,9] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>药材 9级</t><b/><t>采集可获得9级草药</t></t>";
$LivingSkillMaterial[3,10]= "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>药材 10级</t><b/><t>采集可获得10级草药</t></t>";

$LivingSkillMaterial[4,1] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>鱼群 1级</t><b/><t>垂钓可获得河虾、河蟹、鱼苗、鱼苗、珍珠、蓬莱仙钓参赛券、垂钓心得</t></t>";
$LivingSkillMaterial[4,2] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>鱼群 2级</t><b/><t>垂钓可获得河蟹、鳝鱼、鱼苗、鱼苗、珍珠、蓬莱仙钓参赛券、垂钓心得</t></t>";
$LivingSkillMaterial[4,3] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>鱼群 3级</t><b/><t>垂钓可获得鳝鱼、斗鱼、鱼苗、珍珠、蓬莱仙钓参赛券、垂钓心得</t></t>";
$LivingSkillMaterial[4,4] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>鱼群 4级</t><b/><t>垂钓可获得斗鱼、甲鱼、鱼苗、珍珠、蓬莱仙钓参赛券、垂钓心得</t></t>";
$LivingSkillMaterial[4,5] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>鱼群 5级</t><b/><t>垂钓可获得甲鱼、河鳗、鱼苗、珍珠、蓬莱仙钓参赛券、垂钓心得</t></t>";
$LivingSkillMaterial[4,6] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>鱼群 6级</t><b/><t>垂钓可获得河鳗、桂鱼、鱼苗、珍珠、蓬莱仙钓参赛券、垂钓心得</t></t>";
$LivingSkillMaterial[4,7] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>鱼群 7级</t><b/><t>垂钓可获得桂鱼、文昌鱼、鱼苗、珍珠、蓬莱仙钓参赛券、垂钓心得</t></t>";
$LivingSkillMaterial[4,8] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>鱼群 8级</t><b/><t>垂钓可获得文昌鱼、银鱼、鱼苗、珍珠、蓬莱仙钓参赛券、垂钓心得</t></t>";
$LivingSkillMaterial[4,9] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>鱼群 9级</t><b/><t>垂钓可获得银鱼、三星鱼、鱼苗、珍珠、蓬莱仙钓参赛券、垂钓心得</t></t>";
$LivingSkillMaterial[4,10]= "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>鱼群 10级</t><b/><t>垂钓可获得银鱼、三星鱼、鱼苗、珍珠、蓬莱仙钓参赛券、垂钓心得</t></t>";
//
//$BigViewMap_MaterialSign[ 1 ] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>坐标寻径</t><b/><t>输入X、Y坐标点，点击按钮，角色自动寻径到目标点</t></t>";
//$BigViewMap_MaterialSign[ 1 ] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>坐标寻径</t><b/><t>输入X、Y坐标点，点击按钮，角色自动寻径到目标点</t></t>";
//$BigViewMap_MaterialSign[ 1 ] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>坐标寻径</t><b/><t>输入X、Y坐标点，点击按钮，角色自动寻径到目标点</t></t>";
//$BigViewMap_MaterialSign[ 1 ] = "<t m='1' f='宋体' n='12'><t m='0' f='黑体' n='16' c='0xf3d300ff' o='0x010101ff'>坐标寻径</t><b/><t>输入X、Y坐标点，点击按钮，角色自动寻径到目标点</t></t>";
//■■■■■■■■■■■更新地图生活材料图标■■■■■■■■■■■■■■■■■■■
