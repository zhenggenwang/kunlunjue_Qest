//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//һЩ������Ϣ��ָ�����Լ���������֮�������Ӱ˵Ķ���
//==================================================================================

//�������������������������µ�ͼ�������ͼ���������������������������������������



//�������������������������µ�ͼ�������ͼ���������������������������������������
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
	case "���ɹ�":
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
$LivingSkillMaterial[1,1] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���� 1��</t><b/><t>�ɾ�ɻ��ͭ����ʯ</t></t>";
$LivingSkillMaterial[1,2] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���� 2��</t><b/><t>�ɾ�ɻ������Ǧʯ</t></t>";
$LivingSkillMaterial[1,3] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���� 3��</t><b/><t>�ɾ�ɻ������пʯ</t></t>";
$LivingSkillMaterial[1,4] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���� 4��</t><b/><t>�ɾ�ɻ�ý�󡢾�ʯ</t></t>";
$LivingSkillMaterial[1,5] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���� 5��</t><b/><t>�ɾ�ɻ�ú����󡢺���ʯ</t></t>";
$LivingSkillMaterial[1,6] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���� 6��</t><b/><t>�ɾ�ɻ�������󡢷���ʯ</t></t>";
$LivingSkillMaterial[1,7] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���� 7��</t><b/><t>�ɾ�ɻ��ħ���ϼ��ʯ</t></t>";
$LivingSkillMaterial[1,8] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���� 8��</t><b/><t>�ɾ�ɻ�þ�������ʯ</t></t>";
$LivingSkillMaterial[1,9] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���� 9��</t><b/><t>�ɾ�ɻ���Ͻ�󡢺���ʯ</t></t>";
$LivingSkillMaterial[1,10]= "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>���� 10��</t><b/><t>�ɾ�ɻ��ҫ�������ʯ</t></t>";

$LivingSkillMaterial[2,1] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ľ�� 1��</t><b/><t>�����ɻ����ľ</t></t>";
$LivingSkillMaterial[2,2] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ľ�� 2��</t><b/><t>�����ɻ��ͩľ</t></t>";
$LivingSkillMaterial[2,3] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ľ�� 3��</t><b/><t>�����ɻ����ľ</t></t>";
$LivingSkillMaterial[2,4] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ľ�� 4��</t><b/><t>�����ɻ��ɼľ</t></t>";
$LivingSkillMaterial[2,5] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ľ�� 5��</t><b/><t>�����ɻ��̴ľ</t></t>";
$LivingSkillMaterial[2,6] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ľ�� 6��</t><b/><t>�����ɻ�ú�ľ</t></t>";
$LivingSkillMaterial[2,7] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ľ�� 7��</t><b/><t>�����ɻ����ľ</t></t>";
$LivingSkillMaterial[2,8] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ľ�� 8��</t><b/><t>�����ɻ����ľ</t></t>";
$LivingSkillMaterial[2,9] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ľ�� 9��</t><b/><t>�����ɻ����ľ</t></t>";
$LivingSkillMaterial[2,10]= "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ľ�� 10��</t><b/><t>�����ɻ��ǧ����ľ</t></t>";

$LivingSkillMaterial[3,1] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ҩ�� 1��</t><b/><t>�ɼ��ɻ���ϲ�</t></t>";
$LivingSkillMaterial[3,2] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ҩ�� 2��</t><b/><t>�ɼ��ɻ�ý�����</t></t>";
$LivingSkillMaterial[3,3] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ҩ�� 3��</t><b/><t>�ɼ��ɻ������</t></t>";
$LivingSkillMaterial[3,4] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ҩ�� 4��</t><b/><t>�ɼ��ɻ�õ���</t></t>";
$LivingSkillMaterial[3,5] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ҩ�� 5��</t><b/><t>�ɼ��ɻ��Ұɽ��</t></t>";
$LivingSkillMaterial[3,6] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ҩ�� 6��</t><b/><t>�ɼ��ɻ�ö����Ĳ�</t></t>";
$LivingSkillMaterial[3,7] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ҩ�� 7��</t><b/><t>�ɼ��ɻ�þ������</t></t>";
$LivingSkillMaterial[3,8] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ҩ�� 8��</t><b/><t>�ɼ��ɻ��8����ҩ</t></t>";
$LivingSkillMaterial[3,9] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ҩ�� 9��</t><b/><t>�ɼ��ɻ��9����ҩ</t></t>";
$LivingSkillMaterial[3,10]= "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>ҩ�� 10��</t><b/><t>�ɼ��ɻ��10����ҩ</t></t>";

$LivingSkillMaterial[4,1] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ⱥ 1��</t><b/><t>�����ɻ�ú�Ϻ����з�����硢���硢���顢�����ɵ�����ȯ�������ĵ�</t></t>";
$LivingSkillMaterial[4,2] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ⱥ 2��</t><b/><t>�����ɻ�ú�з�����㡢���硢���硢���顢�����ɵ�����ȯ�������ĵ�</t></t>";
$LivingSkillMaterial[4,3] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ⱥ 3��</t><b/><t>�����ɻ�����㡢���㡢���硢���顢�����ɵ�����ȯ�������ĵ�</t></t>";
$LivingSkillMaterial[4,4] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ⱥ 4��</t><b/><t>�����ɻ�ö��㡢���㡢���硢���顢�����ɵ�����ȯ�������ĵ�</t></t>";
$LivingSkillMaterial[4,5] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ⱥ 5��</t><b/><t>�����ɻ�ü��㡢���������硢���顢�����ɵ�����ȯ�������ĵ�</t></t>";
$LivingSkillMaterial[4,6] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ⱥ 6��</t><b/><t>�����ɻ�ú��������㡢���硢���顢�����ɵ�����ȯ�������ĵ�</t></t>";
$LivingSkillMaterial[4,7] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ⱥ 7��</t><b/><t>�����ɻ�ù��㡢�Ĳ��㡢���硢���顢�����ɵ�����ȯ�������ĵ�</t></t>";
$LivingSkillMaterial[4,8] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ⱥ 8��</t><b/><t>�����ɻ���Ĳ��㡢���㡢���硢���顢�����ɵ�����ȯ�������ĵ�</t></t>";
$LivingSkillMaterial[4,9] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ⱥ 9��</t><b/><t>�����ɻ�����㡢�����㡢���硢���顢�����ɵ�����ȯ�������ĵ�</t></t>";
$LivingSkillMaterial[4,10]= "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>��Ⱥ 10��</t><b/><t>�����ɻ�����㡢�����㡢���硢���顢�����ɵ�����ȯ�������ĵ�</t></t>";
//
//$BigViewMap_MaterialSign[ 1 ] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ѱ��</t><b/><t>����X��Y����㣬�����ť����ɫ�Զ�Ѱ����Ŀ���</t></t>";
//$BigViewMap_MaterialSign[ 1 ] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ѱ��</t><b/><t>����X��Y����㣬�����ť����ɫ�Զ�Ѱ����Ŀ���</t></t>";
//$BigViewMap_MaterialSign[ 1 ] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ѱ��</t><b/><t>����X��Y����㣬�����ť����ɫ�Զ�Ѱ����Ŀ���</t></t>";
//$BigViewMap_MaterialSign[ 1 ] = "<t m='1' f='����' n='12'><t m='0' f='����' n='16' c='0xf3d300ff' o='0x010101ff'>����Ѱ��</t><b/><t>����X��Y����㣬�����ť����ɫ�Զ�Ѱ����Ŀ���</t></t>";
//�������������������������µ�ͼ�������ͼ���������������������������������������
