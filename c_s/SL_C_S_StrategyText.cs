//==================================================================================
//ע�����нű���ͷ������ע�����ű��Ĵ���˵������
//
//
//���Խ����ھ���������ݱ�����Ϣ
//
//==================================================================================
//�������������Խ��桿�����������������Ƚ�����ء���������
//�������������Խ��桿����������ͳ���������Ľ��ȡ���������
//�������������Խ��桿�������������ؼ��ı�����������������
//�������������Խ��桿�����������ӿؼ��ı�����������������




//�������������Խ��桿�����������������Ƚ�����ء���������
$GongLueGiftYueLiItem[1]= 105180221; $GongLueGiftNeedYueLi[1]= 20;
$GongLueGiftYueLiItem[2]= 105180222; $GongLueGiftNeedYueLi[2]= 60;
$GongLueGiftYueLiItem[3]= 105180223; $GongLueGiftNeedYueLi[3]= 120;
$GongLueGiftYueLiItem[4]= 105180224; $GongLueGiftNeedYueLi[4]= 180;
//�������������Խ��桿�����������������Ƚ�����ء���������

//�������������Խ��桿����������ͳ���������Ľ��ȡ���������
function GetStrategyYueLiCount(%Player)//���㵱ǰ��ɵ�����
{
	%YueLi = 0;
	%MainNum = GetStrategyMainBtnNum();
	//echo( "%MainNum===" @ %MainNum );
	for (%i = 0; %i < %MainNum; %i++)
	{
		%SubNum = GetStrategySubBtnNum(%i);
		//echo( "%SubNum===" @ %SubNum );
		for (%j = 0; %j < %SubNum; %j++)
		{
			%Src = $StrategySubBtnSrc[%i,%j];
			//echo( "%i ===" @ %i @ " %j===" @  %j @ "    %Src=== @ " @ %Src );
			if (GetSrc(%Player,%Src) == 1)
			{
				%YueLi = %YueLi + $StrategySubBtnYLi[%i,%j];
				//echo( "%Src ===" @ %Src  @ "     $StrategySubBtnYLi[ " @ %i @ "," @ %j @ "]===" @ $StrategySubBtnYLi[ %i, %j ] );
			}
		}
	}
	//echo( "%YueLi====" @ %YueLi );
	return %YueLi;
}
function GetStrategyYueLiAllCount(%Player)//�����ܵ�����
{
	%AllYueLi = 0;
	%MainNum = GetStrategyMainBtnNum();
	for (%i = 0; %i < %MainNum; %i++)
	{
		%SubNum = GetStrategySubBtnNum(%i);
		for (%j = 0; %j < %SubNum; %j++)
		{
			%AllYueLi = %AllYueLi + $StrategySubBtnYLi[%i,%j];
		}
	}
	return %AllYueLi;
}
//�������������Խ��桿����������ͳ���������Ľ��ȡ���������

//�������������Խ��桿�������������ؼ��ı�����������������
$StrategyMainBtnName[0]= "����罻";
$StrategyMainBtnName[1]= "���ù���";
$StrategyMainBtnName[2]= "�ճ��";
$StrategyMainBtnName[3]= "�����";
$StrategyMainBtnName[4]= "��ͼ����";
$StrategyMainBtnName[5]= "�������";

function GetStrategyMainBtnNum()//��ȡ��Ҫ���ٸ����ؼ���ť
{
	for (%i = 0; %i < 99; %i++)
	{
		if ($StrategyMainBtnName[%i] $= "")
			break;
		%Record = %i;
	}
	return %Record + 1;
}
//�������������Խ��桿�������������ؼ��ı�����������������

//�������������Խ��桿�����������ӿؼ��ı�����������������
function SetStrategyBtnText()
{
	//�������� �������� ���߽��� Src��¼ֵ
	//echo("���������Խ��桿�����������ӿؼ��ı�������������");
	//------------------����罻--------------------
	$StrategySubBtnTit[0,0]="���";
	$StrategySubBtnYLi[0,0]="2";
	$StrategySubBtnIte[0,0]="113020002 5";
	$StrategySubBtnSrc[0,0]="64";
	if ($Now_Script == 1) $StrategySubBtnMsg[0,0]=$Get_Dialog_GeShi[31401] @
		"<t>���һ�����飬Я�ֶ���һ���֣���Ȥ���</t><b/>" @
		"<t>��ʹ�ÿ�ݼ� </t>" @ $Get_Dialog_GeShi[31409] @ "Alt + T </t>" @ "<t>�򿪶�����棬���д������顢������顢�ټ����ѵȲ���</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ������һ�����飬���ɻ������������</t></t>";

	$StrategySubBtnTit[0,1]="��Ӻ���";
	$StrategySubBtnYLi[0,1]="2";
	$StrategySubBtnIte[0,1]="113020002 5";
	$StrategySubBtnSrc[0,1]="66";
	if ($Now_Script == 1) $StrategySubBtnMsg[0,1]=$Get_Dialog_GeShi[31401] @
		"<t>Ѱ������ѣ������������硣</t><b/>" @
		"<t>ѡ��һ����� </t>" @ $Get_Dialog_GeShi[31409] @ "�Ҽ���� </t>" @ "<t>���ͷ�񣬿ɽ���������Ӻ��Ѳ���</t><b/><b/>" @
		"<t>��ʹ�ÿ�ݼ� </t>" @ $Get_Dialog_GeShi[31409] @ "Alt + F </t>" @ "<t>�򿪺��ѽ��棬���к��ѹ������</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ���ɹ����һ�����ѣ����ɻ������������</t></t>";

	$StrategySubBtnTit[0,2]="����";
	$StrategySubBtnYLi[0,2]="5";
	$StrategySubBtnIte[0,2]="113020012 2";
	$StrategySubBtnSrc[0,2]="68";
	if ($Now_Script == 1) $StrategySubBtnMsg[0,2]=$Get_Dialog_GeShi[31401] @
		"<t>������ </t>" @ "<t>���� </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010107);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010107,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>��ѯ���а��ɲ���</t><b/>" @
		"<t>��ʹ�ÿ�ݼ� </t>" @ $Get_Dialog_GeShi[31409] @ "Alt + G </t>" @ "<t>�򿪰��ɽ��棬�鿴������ص���Ϣ</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ������һ�����ɣ����ɻ������������</t></t>";

	$StrategySubBtnTit[0,3]="������";
	$StrategySubBtnYLi[0,3]="3";
	$StrategySubBtnIte[0,3]="113010102 5";
	$StrategySubBtnSrc[0,3]="70";
	if ($Now_Script == 1) $StrategySubBtnMsg[0,3]=$Get_Dialog_GeShi[31401] @
		"<t>��δ���š�</t><b/>";

	$StrategySubBtnTit[0,4]="��̯";
	$StrategySubBtnYLi[0,4]="3";
	$StrategySubBtnIte[0,4]="113010102 5";
	$StrategySubBtnSrc[0,4]="72";
	if ($Now_Script == 1) $StrategySubBtnMsg[0,4]=$Get_Dialog_GeShi[31401] @
		"<t>����ͨ����̯�����۸�����Ʒ��Ҳ������������ҵ�̯λ�Ϲ�����Ҫ����Ʒ��</t><b/>" @
		"<t>������ </t>" @ "<t>���� </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(810010108);\",\"" @ $Get_Dialog_GeShi[31214] @ "����" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>��̯��</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ����һ�ΰ�̯�����ɻ������������</t></t>";

	$StrategySubBtnTit[0,5]="ǧ�ﴫ��";
	$StrategySubBtnYLi[0,5]="5";
	$StrategySubBtnIte[0,5]="113010151 5";
	$StrategySubBtnSrc[0,5]="74";
	if ($Now_Script == 1) $StrategySubBtnMsg[0,5]=$Get_Dialog_GeShi[31401] @
		"<t>������������Ϸ������Ȱ�ť���ɺ���ȫ���������档</t><b/>" @
		"<t>ÿ�κ�����Ҫ����һ��<t>" @ GetItemName(105109041,1) @"<t>��</t>" @ GetItemName(105109042,1) @ "<t>��ר����е�����Ƶ���������ױ�</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ��ʹ��һ��ȫ�����������ɻ������������</t></t>";

	$StrategySubBtnTit[0,6]="д��";
	$StrategySubBtnYLi[0,6]="3";
	$StrategySubBtnIte[0,6]="113010152 10";
	$StrategySubBtnSrc[0,6]="76";
	if ($Now_Script == 1) $StrategySubBtnMsg[0,6]=$Get_Dialog_GeShi[31401] @
		"<t>����ͨ��д�ţ����Լ��ĺ������ԣ����Ҽ�����Ʒ��</t><b/>" @
		"<t>������ </t>" @ "<t>����</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010102);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010102,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>�鿴����ȡ�������ʼ�</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ��ѡ��һ�����ѣ���taдһ���ţ����ɻ������������</t></t>";

	$StrategySubBtnTit[0,7]="����";
	$StrategySubBtnYLi[0,7]="";
	$StrategySubBtnIte[0,7]="";
	$StrategySubBtnSrc[0,7]="";
	if ($Now_Script == 1) $StrategySubBtnMsg[0,7]=$Get_Dialog_GeShi[31401] @
		$Get_Dialog_GeShi[31409] @ "����ģʽ��飺</t><b/>" @
		"<t>ͨ�����Ͻǡ�����ͷ�����򸽽��л�����ģʽ</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "�ƶ�ֵ��</t><b/>" @
		"<t>���ܰ�����ң��������ƶ�ֵ</t><b/>" @
		"<t>�ƶ�ֵ��Ӱ�������ͷ�</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "�������䣺</t><b/>" @
		"<t>�����е�Ұ�⡢�ع������ǵȣ��Ǹ�������ͼ����������м��ʵ�������ڵ���Ʒ�����ϵ�װ�����Լ�����Я���Ľ��</t><b/>" @
		"<t>�ƶ�ֵԽ�ߣ������������Խ��</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "����������</t><b/>" @
		"<t>����ͨ������װ����������װ������������䣬��������װ���м��ʱ���٣���Ҫ�޸���ſ�ʹ��</t><b/>" @
		"<t>�ڰ����ڴ��</t>" @ GetItemName(105109051,1) @ "<t>��ÿ������������һö</t>" @ GetItemName(105109051,1) @ "<t>��ͬʱ����������ʧ</t></t>";

	//------------------���ù���--------------------
	$StrategySubBtnTit[1,0]="�Զ�ս��";
	$StrategySubBtnYLi[1,0]="2";
	$StrategySubBtnIte[1,0]="105020303 50";
	$StrategySubBtnSrc[1,0]="78";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,0]=$Get_Dialog_GeShi[31401] @
		"<t>�ֶ����̫�ۣ�����ѡ��ʹ���Զ�ս������Ŷ��</t><b/><b/>" @
		"<t>��ʹ�ÿ�ݼ� </t>" @ $Get_Dialog_GeShi[31409] @ "Alt + Z </t>" @ "<t>���Զ�ս�����ý��棬���к�ҩ����������ʩ�š�ʰȡɸѡ�Ȳ���</t><b/><b/>" @
		"<t>��ʹ�ÿ�ݼ� </t>" @ $Get_Dialog_GeShi[31409] @ " = </t>" @ "<t>ֱ�ӿ����Զ�ս��</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ��ʹ��һ���Զ�ս�����ܣ����ɻ������������</t></t>";

	$StrategySubBtnTit[1,1]="˫������";
	$StrategySubBtnYLi[1,1]="5";
	$StrategySubBtnIte[1,1]="105028012 1";
	$StrategySubBtnSrc[1,1]="80";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,1]=$Get_Dialog_GeShi[31401] @
		"<t>˫������״̬�£����ܹ����Լ����ֻ���ʱ����õľ��齱������˫��</t><b/>" @
		"<t>ϵͳÿ���������10Сʱ��˫��ʱ��</t><b/>" @
		"<t>����</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010113);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010113,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>����ȡÿ�����˫��ʱ�䣬�Լ���ȡ˫��ʱ��</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ����ȡһ��ÿ�����˫��ʱ�䣬���ɻ������������</t></t>";


	$StrategySubBtnTit[1,2]="ѧϰ����";
	$StrategySubBtnYLi[1,2]="2";
	$StrategySubBtnIte[1,2]="105020353 50";
	$StrategySubBtnSrc[1,2]="82";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,2]=$Get_Dialog_GeShi[31401] @
		"<t>���ܽ����ݼ���</t>" @ $Get_Dialog_GeShi[31409] @ "Alt + K </t>" @ "<b/>" @
		"<t>���м��ܵ�ѧϰ����Ҫ��Ӧ�ļ�����</t><b/>" @
		"<t>����</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010119);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010119,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>����������ļ�����</t><b/>" @
		"<t>�ߵȼ����飬��</t>" @ $Get_Dialog_GeShi[31409] @ "��ħ�� </t>" @ "<t>����ʬ���м��ʵ���</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ��ѧϰһ������ȼ�40�����ϵ�ְҵ���ܣ����ɻ������������</t></t>";

	$StrategySubBtnTit[1,3]="��������";
	$StrategySubBtnYLi[1,3]="3";
	$StrategySubBtnIte[1,3]="105020353 50";
	$StrategySubBtnSrc[1,3]="84";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,3]=$Get_Dialog_GeShi[31401] @
		"<t>���ܽ����ݼ���</t>" @ $Get_Dialog_GeShi[31409] @ "Alt + K </t>" @ "<b/>" @
		"<t>���������󣬼���Ч������ĸ���ǿ��</t><b/>" @
		"<t>�������ͼ���Ϸ��� ��ͷ ��������</t><b/>" @
		"<t>����������Ҫ����һ���ĵȼ�����</t><b/>" @
		"<t>����������Ҫ����һ���Ľ�Ǯ�Լ�����</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ������һ��ְҵ���ܣ����ɻ������������</t></t>";

	$StrategySubBtnTit[1,4]="�ֽ�װ��";
	$StrategySubBtnYLi[1,4]="5";
	$StrategySubBtnIte[1,4]="116010001 10";
	$StrategySubBtnSrc[1,4]="86";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,4]=$Get_Dialog_GeShi[31401] @
		"<t>�����װ�������Էֽ⣬�ֽ�װ�����м��ʻ��</t>" @  GetItemName(116010002,1) @ "<t>��</t>" @ GetItemName(116010003,1) @ "<b/>" @
		"<t>�򿪰�����</t>" @ $Get_Dialog_GeShi[31409] @ "��ݼ� Alt + B </t>" @ "<t>���󣬵��������λ�·���</t>" @ $Get_Dialog_GeShi[31409] @ "�ֽ�</t><t>��ť�����ɷֽ�װ��</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ���ɹ��ֽ�һ��װ�������ɻ������������</t></t>";

	$StrategySubBtnTit[1,5]="ǿ��װ��";
	$StrategySubBtnYLi[1,5]="8";
	$StrategySubBtnIte[1,5]="116010002 5";
	$StrategySubBtnSrc[1,5]="88";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,5]=$Get_Dialog_GeShi[31401] @
		"<t>װ��ǿ���󣬸���װ���Ļ������Ժ�ǿ���ȼ�����������װ��������</t><b/>" @
		"<t>ǿ��ʦ������</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010121);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010121,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ��װ��ǿ�����������ɻ������������</t></t>";

	$StrategySubBtnTit[1,6]="����װ��";
	$StrategySubBtnYLi[1,6]="8";
	$StrategySubBtnIte[1,6]="113050004 2";
	$StrategySubBtnSrc[1,6]="90";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,6]=$Get_Dialog_GeShi[31401] @
		"<t>װ�������ɹ���װ��������µļ�������</t><b/>" @
		"<t>����ʦ������</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010122);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010122,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ��װ���������������ɻ������������</t></t>";

	$StrategySubBtnTit[1,7]="װ������";
	$StrategySubBtnYLi[1,7]="8";
	$StrategySubBtnIte[1,7]="116010001 10";
	$StrategySubBtnSrc[1,7]="92";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,7]=$Get_Dialog_GeShi[31401] @
		"<t>װ������������ϴȥ���õļ������Զ����ȫ�����ԡ�</t><b/>" @
		"<t>����ʦ������</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010122);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010122,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ��װ���������������ɻ������������</t></t>";

	$StrategySubBtnTit[1,8]="װ������";
	$StrategySubBtnYLi[1,8]="8";
	$StrategySubBtnIte[1,8]="116010001 10";
	$StrategySubBtnSrc[1,8]="94";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,8]=$Get_Dialog_GeShi[31401] @
		"<t>װ�����������Խ�����������������ޡ�</t><b/>" @
		"<t>����ʦ������</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010122);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010122,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ��װ���������������ɻ������������</t></t>";

	$StrategySubBtnTit[1,9]="װ������";
	$StrategySubBtnYLi[1,9]="8";
	$StrategySubBtnIte[1,9]="116010002 10";
	$StrategySubBtnSrc[1,9]="96";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,9]=$Get_Dialog_GeShi[31401] @
		"<t>װ�����������������������һ��װ���ĳɳ���</t><b/>" @
		"<t>װ���ɳ���Խ�ߣ��䱻ǿ����õ����Ӿ�Խ��</t><b/>" @
		"<t>����ʦ������</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010121);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010121,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ��װ���������������ɻ������������</t></t>";

	$StrategySubBtnTit[1,10]="��ʯ�ϳ�";
	$StrategySubBtnYLi[1,10]="8";
	$StrategySubBtnIte[1,10]="116010003 10";
	$StrategySubBtnSrc[1,10]="98";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,10]=$Get_Dialog_GeShi[31401] @
		"<t>�컯��ʯ�ϳɣ��컯��ʯ��ʹװ��ǿ��ʧ��ʱ��������ʧ���������ǿ���ɹ�����</t><b/>" @
		"<t>��ʯ�ϳ�ʦ������</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010143);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010143,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ����ʯ�ϳɣ����ɻ������������</t></t>";


	$StrategySubBtnTit[1,11]="����";
	$StrategySubBtnYLi[1,11]="8";
	$StrategySubBtnIte[1,11]="105310001 1";
	$StrategySubBtnSrc[1,11]="100";
	if ($Now_Script == 1) $StrategySubBtnMsg[1,11]=$Get_Dialog_GeShi[31401] @
		"<t>�ڻ��</t>" @ GetItemName(105300016,1) @ "<t>����Ѱ�Ҽ���ʦ���м������м��ʻ�ø�����ϧ����</t><b/>" @
		"<t>����ʦ������</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010120);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010120,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ�μ��������ɻ������������</t></t>";
	//------------------�ճ��--------------------
	$StrategySubBtnTit[2,0]="ÿ�ջ�Ծ";
	$StrategySubBtnYLi[2,0]="3";
	$StrategySubBtnIte[2,0]="105020303 50";
	$StrategySubBtnSrc[2,0]="102";
	if ($Now_Script == 1) $StrategySubBtnMsg[2,0]=$Get_Dialog_GeShi[31401] @
		"<t>ÿ��ﵽ��Ӧ�Ļ�Ծ�ȣ�������ȡ��Ծ�����</t><b/>" @
		"<t>�����</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"closestrategywndgui();OpenOrCloseUpLinePartyWndGui();SetUpLineParty(2);\",\"" @ $Get_Dialog_GeShi[31214] @ "�콱����" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>�鿴���ջ�Ծ</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ���ﵽһ�λ�Ծ99����ȡ�ջ�Ծ����������������ɻ������������</t></t>";

	$StrategySubBtnTit[2,1]="ǩ����";
	$StrategySubBtnYLi[2,1]="3";
	$StrategySubBtnIte[2,1]="105028012 1";
	$StrategySubBtnSrc[2,1]="104";
	if ($Now_Script == 1) $StrategySubBtnMsg[2,1]=$Get_Dialog_GeShi[31401] @
		"<t>ÿ��ǩ������ȡǩ�������ÿ���ۼ���Ӧ��ǩ����������ȡÿ�»�Ծ���</t><b/>" @
		"<t>�����</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"closestrategywndgui();OpenOrCloseUpLinePartyWndGui();SetUpLineParty(3);\",\"" @ $Get_Dialog_GeShi[31214] @ "�콱����" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>����ǩ��</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ��ǩ�������ɻ������������</t></t>";

	$StrategySubBtnTit[2,2]="������";
	$StrategySubBtnYLi[2,2]="12";
	$StrategySubBtnIte[2,2]="105104919 1";
	$StrategySubBtnSrc[2,2]="106";
	if ($Now_Script == 1) $StrategySubBtnMsg[2,2]=$Get_Dialog_GeShi[31401] @
		"<t>��������Ҫͨ�����ܹ���ճ����������</t><b/>" @
		"<t>�������ճ������Ƽ���</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "�������� </t>" @ "<t>������</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "ʱ���Ѻ� </t>" @ "<t>������</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "Ѫħ��ӡ </t>" @ "<t>������</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "ʦ�ž��� </t>" @ "<t>�����</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "���Ǵ��� </t>" @ "<t>�����</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "�� ħ Ԩ </t>" @ "<t>�����</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "���ͼ��� </t>" @ "<t>�����</t><b/>" @
		"<t>�����</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"closestrategywndgui();OpenOrCloseActivityWnd();\",\"" @ $Get_Dialog_GeShi[31214] @ "���ȫ����" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>�ɲ鿴�����ճ��</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ����ɫ�ȼ��ﵽ50�������ɻ������������</t></t>";

	$StrategySubBtnTit[2,3]="���߻��";
	$StrategySubBtnYLi[2,3]="8";
	$StrategySubBtnIte[2,3]="112010056 1";
	$StrategySubBtnSrc[2,3]="108";
	if ($Now_Script == 1) $StrategySubBtnMsg[2,3]=$Get_Dialog_GeShi[31401] @
		"<t>װ���������Ҫ�ɻ��ܹ��������������������ܣ����졢�������÷죩���</t><b/>" @
		"<t>����������Ҫ������ճ�����������������ܡ����ܹ���ȶ��ֶ����ķ�ʽ���</t><b/>" @
		"<t>�ص��Ƽ���</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "�� ħ Ԩ </t>" @ "<t>������</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "�� �� ͼ </t>" @ "<t>������</t><b/>" @
		"<t>�����</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"closestrategywndgui();OpenOrCloseActivityWnd();\",\"" @ $Get_Dialog_GeShi[31214] @ "���ȫ����" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>�ɲ鿴�����ճ��</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ����ȡ10�Ųر�ͼ�����ɻ������������</t></t>";

	$StrategySubBtnTit[2,4]="��Ǯ���";
	$StrategySubBtnYLi[2,4]="8";
	$StrategySubBtnIte[2,4]="105021061 1";
	$StrategySubBtnSrc[2,4]="110";
	if ($Now_Script == 1) $StrategySubBtnMsg[2,4]=$Get_Dialog_GeShi[31401] @
		"<t>��������ؾ�����ͨ���ң��������������������Լ��������ܶ���Ҫ���Ľ��</t><b/>" @
		"<t>��һ�÷�ʽ��</t><b/>" @
		"<t>1��ͨ�����̵����װ�������ϡ�������</t><b/>" @
		"<t>2���μӸ������</t><b/>" @
		"<t>�ص��Ƽ���</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "Ѻ    �� </t>" @ "<t>������</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "�ƽ𱦲� </t>" @ "<t>������</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "�� �� ͼ </t>" @ "<t>�����</t><b/>" @
		"<t>�����</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"closestrategywndgui();OpenOrCloseActivityWnd();\",\"" @ $Get_Dialog_GeShi[31214] @ "���ȫ����" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>�ɲ鿴�����ճ��</t><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ�λƽ𱦲ظ��������ɻ������������</t></t>";


	$StrategySubBtnTit[2,5]="�����";
	$StrategySubBtnYLi[2,5]="10";
	$StrategySubBtnIte[2,5]="105021051 1";
	$StrategySubBtnSrc[2,5]="112";
	if ($Now_Script == 1) $StrategySubBtnMsg[2,5]=$Get_Dialog_GeShi[31401] @
		"<t>���������ҿ��Ժ��������̨ͬ������ƽ̨</t><b/>" @
		"<t>�ص��Ƽ���</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "�� �� ս </t>" @ "<t>������</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "�������� </t>" @ "<t>�����</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "�������� </t>" @ "<t>�����</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "�������� </t>" @ "<t>����</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "�þ����� </t>" @ "<t>����</t><b/>" @
		"<t>�����</t> " @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"closestrategywndgui();OpenOrCloseActivityWnd();\",\"" @ $Get_Dialog_GeShi[31214] @ "���ȫ����" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>�ɲ鿴�����ճ��</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ���μ�һ�ε������򣬲����ս�������������ɻ������������</t></t>";
	//------------------�����--------------------
	$StrategySubBtnTit[3,0]="�ɿ�";
	$StrategySubBtnYLi[3,0]="5";
	$StrategySubBtnIte[3,0]="105021505 1";
	$StrategySubBtnSrc[3,0]="114";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,0]= $Get_Dialog_GeShi[31401] @
		"<t>�ɿ��õĿ�ʯ�������ڡ����졿���ܶ���������Ҳ�������̵��ý�ҡ��ɿ��м��ʻ��</t>" @ GetItemName(105300001,1) @ "<t>��</t><b/>" @
		"<t>����</t>" @ $Get_Dialog_GeShi[31409] @ "���ɿ�" @ "</t><t>��</t>" @ $Get_Dialog_GeShi[31409] @ "��������" @ "</t><t>��</t>" @ $Get_Dialog_GeShi[31409] @ "��Թ�" @ "</t><t>�ȸ���Ұ�⡢�ع���ͼѰ�ҵ�������</t><b/><b/>" @
		"<t>����ѧϰ�� </t>" @ "<t>����</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100016);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100016,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ�βɿ󣬼��ɻ������������</t></t>";

	$StrategySubBtnTit[3,1]="��ľ";
	$StrategySubBtnYLi[3,1]="5";
	$StrategySubBtnIte[3,1]="105021505 1";
	$StrategySubBtnSrc[3,1]="116";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,1]=$Get_Dialog_GeShi[31401] @
		"<t>��ľ��õ�ľ�ģ������ڡ����������ܡ������䡿���ܣ�Ҳ�������̵��ý�ҡ�</t><b/>" @
		"<t>����</t>" @ $Get_Dialog_GeShi[31409] @ "���ɹ�" @ "</t><t>��</t>" @ $Get_Dialog_GeShi[31409] @ "��ɽѩ��" @ "</t><t>��</t>" @  $Get_Dialog_GeShi[31409] @ "������" @ "</t><t>�ȸ���Ұ���ͼѰ�ҵ�ľ�ġ�</t><b/><b/>" @
		"<t>����ѧϰ�� </t>" @ "<t>����</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(411010002);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(411010002,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ�η�ľ�����ɻ������������</t></t>";

	$StrategySubBtnTit[3,2]="����";
	$StrategySubBtnYLi[3,2]="5";
	$StrategySubBtnIte[3,2]="105021505 1";
	$StrategySubBtnSrc[3,2]="118";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,2]=$Get_Dialog_GeShi[31401] @
		"<t>�����õĺ��ʡ����ʣ������ڡ���⿡����ܣ�Ҳ�������̵��ý�ҡ�</t><b/>" @
		"<t>����</t>" @ $Get_Dialog_GeShi[ 31409 ] @ "���ɹ�" @ "</t><t>��</t>" @ $Get_Dialog_GeShi[ 31409 ] @ "��ɽѩ��" @ "</t><t>��</t>" @  $Get_Dialog_GeShi[ 31409 ] @ "������" @ "</t><t>�ȸ���Ұ���ͼѰ�ҵ���Ⱥ��</t><b/><b/>" @
		"<t>����ѧϰ�� </t>" @ "<t>����</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100012);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100012,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ�ε��㣬���ɻ������������</t></t>";

	$StrategySubBtnTit[3,3]="��ҩ";
	$StrategySubBtnYLi[3,3]="5";
	$StrategySubBtnIte[3,3]="105021505 1";
	$StrategySubBtnSrc[3,3]="120";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,3]=$Get_Dialog_GeShi[31401] @
		"<t>��ҩ��õ�ҩ�ģ������ڡ����������ܣ�Ҳ�������̵��ý�ҡ�</t><b/>" @
		"<t>����</t>" @ $Get_Dialog_GeShi[ 31409 ] @ "���ɹ�" @ "</t><t>��</t>" @ $Get_Dialog_GeShi[ 31409 ] @ "��ɽѩ��" @ "</t><t>��</t>" @  $Get_Dialog_GeShi[ 31409 ] @ "������" @ "</t><t>�ȸ���Ұ���ͼѰ�ҵ���ҩ��</t><b/><b/>" @
		"<t>����ѧϰ�� </t>" @ "<t>����</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100010);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100010,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ�β�ҩ�����ɻ������������</t></t>";

	$StrategySubBtnTit[3,4]="����";
	$StrategySubBtnYLi[3,4]="10";
	$StrategySubBtnIte[3,4]="105021510 1";
	$StrategySubBtnSrc[3,4]="122";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,4]=$Get_Dialog_GeShi[31401] @
		"<t>�����졿���ܣ����Զ������ɫ����ɫ�������Լ��������𶧡���ש��</t><b/>" @
		"<t>����������䷽�Ͳ��ϣ��ɹ�������������䣬��������Ŀ���ɡ��ɿ����á�</t><b/><b/>" @
		"<t>����ѧϰ�� </t>" @ "<t>����</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100058);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100058,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ�����죬���ɻ������������</t></t>";

	$StrategySubBtnTit[3,5]="�÷�";
	$StrategySubBtnYLi[3,5]="10";
	$StrategySubBtnIte[3,5]="105021510 1";
	$StrategySubBtnSrc[3,5]="124";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,5]=$Get_Dialog_GeShi[31401] @
		"<t>���÷졿���ܣ����Զ������ɫ����ɫ���ߣ��Լ�Ǭ������</t><b/>" @
		"<t>�÷�������䷽�Ͳ��ϣ��ɹ�������������䡣</t><b/><b/>" @
		"<t>����ѧϰ�� </t>" @ "<t>����</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100005);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100005,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ�β÷죬���ɻ������������</t></t>";

	$StrategySubBtnTit[3,6]="����";
	$StrategySubBtnYLi[3,6]="10";
	$StrategySubBtnIte[3,6]="105021510 1";
	$StrategySubBtnSrc[3,6]="126";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,6]=$Get_Dialog_GeShi[31401] @
		"<t>�����������ܣ����Զ������ɫ����ɫ���Σ��Լ��ֿ���չ����</t><b/>" @
		"<t>����������䷽�Ͳ��ϣ��ɹ�������������䣬���ֲ����ɡ���ľ�����á�</t><b/><b/>" @
		"<t>����ѧϰ�� </t>" @ "<t>����</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100060);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100060,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ�����������ɻ������������</t></t>";

	$StrategySubBtnTit[3,7]="����";
	$StrategySubBtnYLi[3,7]="10";
	$StrategySubBtnIte[3,7]="105021510 1";
	$StrategySubBtnSrc[3,7]="128";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,7]=$Get_Dialog_GeShi[31401] @
		"<t>�����䡿���ܣ��������������䣬����������������������ʿʩ�����ϡ��Լ���������ս���ķ��䡣</t><b/>" @
		"<t>����������䷽�Ͳ��ϣ��ɹ�������������䣬���ֲ����ɡ���ľ�����á�</t><b/><b/>" @
		"<t>����ѧϰ�� </t>" @ "<t>����</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100003);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100003,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ���Ʒ������ɻ������������</t></t>";

	$StrategySubBtnTit[3,8]="����";
	$StrategySubBtnYLi[3,8]="10";
	$StrategySubBtnIte[3,8]="105021510 1";
	$StrategySubBtnSrc[3,8]="130";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,8]=$Get_Dialog_GeShi[31401] @
		"<t>�����������ܣ�����������൤ҩ�������ظ��൤ҩ��״̬���浤ҩ����ʦʩ�����ϡ��Լ�������;�ĵ�ҩ��</t><b/>" @
		"<t>����������䷽�Ͳ��ϣ��ɹ�������������䣬���ֲ����ɡ���ҩ�����á�</t><b/><b/>" @
		"<t>����ѧϰ�� </t>" @ "<t>����</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100004);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100004,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ�����������ɻ������������</t></t>";

	$StrategySubBtnTit[3,9]="���";
	$StrategySubBtnYLi[3,9]="10";
	$StrategySubBtnIte[3,9]="105021510 1";
	$StrategySubBtnSrc[3,9]="132";
	if ($Now_Script == 1) $StrategySubBtnMsg[3,9]=$Get_Dialog_GeShi[31401] @
		"<t>����⿡����ܣ�����������൤ҩ�������ظ�����ʳ��״̬������ʳ��սʿʩ�����ϡ��Լ�������;��ҩ�š�</t><b/>" @
		"<t>���������䷽�Ͳ��ϣ��ɹ�������������䣬���ֲ����ɡ����㡿���á�</t><b/><b/>" @
		"<t>����ѧϰ�� </t>" @ "<t>����</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100059);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100059,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ����⿣����ɻ������������</t></t>";
	//------------------��ͼ����--------------------
	$StrategySubBtnTit[4,0]="����";
	$StrategySubBtnYLi[4,0]="";
	$StrategySubBtnIte[4,0]="";
	$StrategySubBtnSrc[4,0]="";
	if ($Now_Script == 1) $StrategySubBtnMsg[4,0]=$Get_Dialog_GeShi[31401] @
		"<t>������������ҵĳ����أ��ڴ�̤���������翪������֮;��</t><b/><b/>" @
		"<t>�����ɲμӵĻ�У�</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "ʦ�ž���</t><t> ��Ѱ��</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100001);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100001,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>�μ�</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "�������</t><t> ��Ѱ��</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100001);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100001,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>�μ�</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "�����۾�</t><t> ��Ѱ��</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100001);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410100001,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>�μ�</t>";

	$StrategySubBtnTit[4,1]="����";
	$StrategySubBtnYLi[4,1]="";
	$StrategySubBtnIte[4,1]="";
	$StrategySubBtnSrc[4,1]="";
	if ($Now_Script == 1) $StrategySubBtnMsg[4,1]=$Get_Dialog_GeShi[31401] @
		"<t>���أ����ؽ�����ǣ����֮���ڡ�</t><b/>" @
		"<t>���س����ṩ���ַ���</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "�ʼ�ʹ��  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010102);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010102,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "����ʹ��  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010103);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010103,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "��    ��  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010101);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010101,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "�� �� ��  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010111);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010111,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "ҩ    ��  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010115);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010115,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "�� �� ��  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010119);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010119,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "�������  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010107);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010107,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "˫������  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010113);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010113,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "��    ̯  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(810010108);\",\"" @ $Get_Dialog_GeShi[31214] @ "����" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "װ�����  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010123);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010123,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010122);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010122,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010121);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010121,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "��ʯ���  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010123);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010123,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "��ʯ�ϳ�  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010143);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010143,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "��    ��  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010120);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010120,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "�� �� ̨  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010139);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010139,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "�� �� ̨  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010124);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010124,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "�� � ��  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010127);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010127,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "�� �� ̨  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010126);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010126,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "�� �� ¯  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010125);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010125,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "�� �� ��  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010128);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(410010128,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "</t>";

	$StrategySubBtnTit[4,2]="��ħ��";
	$StrategySubBtnYLi[4,2]="";
	$StrategySubBtnIte[4,2]="";
	$StrategySubBtnSrc[4,2]="";
	if ($Now_Script == 1) $StrategySubBtnMsg[4,2]=$Get_Dialog_GeShi[31401] @
		"<t>��ħ�ǣ����ǡ�</t><b/>" @
		"<t>��ħ���������ռ�죬ռ����ɵİ����Զ���Ϊ��ħ������</t><b/>" @
		"<t>�ʺϵȼ���50������</t><b/>" @
		"<t>�ص��Ƽ���</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "Ѻ�� </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(411190001);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(411190001,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ����ħ������</t>" @ $Get_Dialog_GeShi[31499] @ "ǿ�ƿ���ȫ�幥��ģʽ</t>" @ $Get_Dialog_GeShi[31421] @ "�ĸ�Σ��ͼ���������п���</t>" @ $Get_Dialog_GeShi[31499] @ "<t>����װ��</t></t>";

	$StrategySubBtnTit[4,3]="��������";
	$StrategySubBtnYLi[4,3]="";
	$StrategySubBtnIte[4,3]="";
	$StrategySubBtnSrc[4,3]="";
	if ($Now_Script == 1) $StrategySubBtnMsg[4,3]=$Get_Dialog_GeShi[31401] @
		"<t>����������������ͼ�������������ɻ�ô������顣</t><b/>" @
		"<t>�ʺϵȼ���30 - 70</t><b/>" @
		"<t>������� ����  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010141);\",\"" @ $Get_Dialog_GeShi[31214] @  GetNpcData(410010141,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/><b/>" @
		"<t>�ص��Ƽ���</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "��������  ������ħ</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "��������  ����֮��</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "��������  �һ�֮��</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "��������  ��������</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "��������  ��������</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "��������  ��װ��ҩ</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "��������  ����֮��</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "��������  ��������</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ��������������</t>" @ $Get_Dialog_GeShi[31499] @ "ǿ�ƿ���ȫ�幥��ģʽ</t>" @ $Get_Dialog_GeShi[31421] @ "�ĸ�Σ��ͼ���������п���</t>" @ $Get_Dialog_GeShi[31499] @ "<t>����װ��</t></t>";

	$StrategySubBtnTit[4,4]="���ɹ�";
	$StrategySubBtnYLi[4,4]="";
	$StrategySubBtnIte[4,4]="";
	$StrategySubBtnSrc[4,4]="";
	if ($Now_Script == 1) $StrategySubBtnMsg[4,4]=$Get_Dialog_GeShi[31401] @
		"<t>���ɹȣ�Ұ���ͼ</t><b/>" @
		"<t>�ʺϵȼ���30 - 45</t><b/>" @
		"<t>�ص��Ƽ���</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "���� ���ͼ���  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(411010010);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(411010010,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "���� ն����ħ  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(411010010);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(411010010,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "���� �� �� ��  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(811010105);\",\"" @ $Get_Dialog_GeShi[31214] @ "���ɿ����" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "���� �������  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(811010103);\",\"" @ $Get_Dialog_GeShi[31214] @ "����������" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "</t>";

	$StrategySubBtnTit[4,5]="���ɿ�";
	$StrategySubBtnYLi[4,5]="";
	$StrategySubBtnIte[4,5]="";
	$StrategySubBtnSrc[4,5]="";
	if ($Now_Script == 1) $StrategySubBtnMsg[4,5]=$Get_Dialog_GeShi[31401] @
		"<t>���ɿߣ��ع���ͼ</t><b/>" @
		"<t>�ʺϵȼ���35 - 50</t><b/>" @
		"<t>�ص��Ƽ���</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "���� �ĳǹ���  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(811280200);\",\"" @ $Get_Dialog_GeShi[31214] @ "�����������" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		"<t>�ع����䣺</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "��ɫװ����30-40����</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "������䷽�����ϣ�1��2���� </t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����ɿ߶����������������أ�����󽫱�ѹ�����ԣ���ʹ�á�</t>" @ GetItemName(114070001,1) @ $Get_Dialog_GeShi[31421] @ "��ʱ�Խ��ѹ�ơ�</t></t>";

	$StrategySubBtnTit[4,6]="��ɽѩ��";
	$StrategySubBtnYLi[4,6]="";
	$StrategySubBtnIte[4,6]="";
	$StrategySubBtnSrc[4,6]="";
	if ($Now_Script == 1) $StrategySubBtnMsg[4,6]=$Get_Dialog_GeShi[31401] @
		"<t>��ɽѩ����Ұ���ͼ</t><b/>" @
		"<t>�ʺϵȼ���45 - 60</t><b/>" @
		"<t>�ص��Ƽ���</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "���� ���ͼ���  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(411010010);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(411010010,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "���� ն����ħ  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(411010010);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(411010010,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "���� ��������  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(811010105);\",\"" @ $Get_Dialog_GeShi[31214] @ "�����������" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "���� ѩ��ħ��  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(811010103);\",\"" @ $Get_Dialog_GeShi[31214] @ "����������" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "</t>";

	$StrategySubBtnTit[4,7]="��������";
	$StrategySubBtnYLi[4,7]="";
	$StrategySubBtnIte[4,7]="";
	$StrategySubBtnSrc[4,7]="";
	if ($Now_Script == 1) $StrategySubBtnMsg[4,7]=$Get_Dialog_GeShi[31401] @
		"<t>�������꣬�ع���ͼ</t><b/>" @
		"<t>�ʺϵȼ���50 - 65</t><b/>" @
		"<t>�ص��Ƽ���</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "���� ����ħ��  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(811280300);\",\"" @ $Get_Dialog_GeShi[31214] @ "������������" @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		$Get_Dialog_GeShi[31409] @ "���� �� ħ ��  </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(411180001);\",\"" @ $Get_Dialog_GeShi[31214] @ GetNpcData(411180001,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<b/>" @
		"<t>�ع����䣺</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "��ɫװ����50-60����</t><b/>" @
		$Get_Dialog_GeShi[31409] @ "������䷽�����ϣ�3��4���� </t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ���������������������������أ�����󽫱�ѹ�����ԣ���ʹ�á�</t>" @ GetItemName(114070002,1) @ $Get_Dialog_GeShi[31421] @ "��ʱ�Խ��ѹ�ơ�</t></t>";
	//------------------�������--------------------
	$StrategySubBtnTit[5,0]="��ҫʹ��";
	$StrategySubBtnYLi[5,0]="10";
	$StrategySubBtnIte[5,0]="105105352 1";
	$StrategySubBtnSrc[5,0]="134";
	if ($Now_Script == 1) $StrategySubBtnMsg[5,0]=$Get_Dialog_GeShi[31401] @
		"<t>��ҫʹ�ߣ�Ψһ������ɴ�����</t>" @ GetItemName(105109052,1) @ "<t>���������</t><b/>" @
		"<t>ˢ��λ��  </t>" @ $Get_Dialog_GeShi[31409] @ "���� ����С��</t>" @ "<b/>" @
		"<t>ˢ��ʱ��  </t>" @ $Get_Dialog_GeShi[31409] @ "6</t>" @ "<t>Сʱ</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ�λ��ܣ����ɻ������������</t></t>";

	$StrategySubBtnTit[5,1]="����ʹ��";
	$StrategySubBtnYLi[5,1]="10";
	$StrategySubBtnIte[5,1]="105105352 1";
	$StrategySubBtnSrc[5,1]="136";
	if ($Now_Script == 1) $StrategySubBtnMsg[5,1]=$Get_Dialog_GeShi[31401] @
		"<t>��ҫʹ�ߣ�Ψһ�����ȡ����Ȩ��</t>" @ GetItemName(105109053,1) @ "<t>���������</t><b/>" @
		"<t>ˢ��λ��  </t>" @ $Get_Dialog_GeShi[31409] @ "��ħ�� ������</t>" @ "<b/>" @
		"<t>ˢ��ʱ��  </t>" @ $Get_Dialog_GeShi[31409] @ "6</t>" @ "<t>Сʱ</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ�λ��ܣ����ɻ������������</t></t>";

	$StrategySubBtnTit[5,2]="�������";
	$StrategySubBtnYLi[5,2]="10";
	$StrategySubBtnIte[5,2]="105105301 1";
	$StrategySubBtnSrc[5,2]="138";
	if ($Now_Script == 1) $StrategySubBtnMsg[5,2]=$Get_Dialog_GeShi[31401] @
		"<t>���������Ұ���������</t><b/>" @
		"<t>�������  </t>" @ $Get_Dialog_GeShi[31409] @ "50����ɫװ�����������</t><b/>" @
		"<t>ˢ��λ��  </t>" @ $Get_Dialog_GeShi[31409] @ "���ɹ� �������</t>" @ "<b/>" @
		"<t>ˢ��ʱ��  </t>" @ $Get_Dialog_GeShi[31409] @ "6</t>" @ "<t>Сʱ</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ�λ��ܣ����ɻ������������</t></t>";

	$StrategySubBtnTit[5,3]="�ĳǹ���";
	$StrategySubBtnYLi[5,3]="10";
	$StrategySubBtnIte[5,3]="105105301 1";
	$StrategySubBtnSrc[5,3]="140";
	if ($Now_Script == 1) $StrategySubBtnMsg[5,3]=$Get_Dialog_GeShi[31401] @
		"<t>�ĳǹ������ع��������</t><b/>" @
		"<t>�������  </t>" @ $Get_Dialog_GeShi[31409] @ "50����ɫװ��������</t><b/>" @
		"<t>ˢ��λ��  </t>" @ $Get_Dialog_GeShi[31409] @ "���ɿ߶���</t>" @ "<b/>" @
		"<t>ˢ��ʱ��  </t>" @ $Get_Dialog_GeShi[31409] @ "8</t>" @ "<t>Сʱ</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����ɿ߶����������������أ�����󽫱�ѹ�����ԣ���ʹ�á�</t>" @ GetItemName(114070001,1) @ $Get_Dialog_GeShi[31421] @ "��ʱ�Խ��ѹ�ơ�</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ�λ��ܣ����ɻ������������</t></t>";

	$StrategySubBtnTit[5,4]="ѩ��ħ��";
	$StrategySubBtnYLi[5,4]="10";
	$StrategySubBtnIte[5,4]="105105302 1";
	$StrategySubBtnSrc[5,4]="142";
	if ($Now_Script == 1) $StrategySubBtnMsg[5,4]=$Get_Dialog_GeShi[31401] @
		"<t>ѩ��ħ����Ұ���������</t><b/>" @
		"<t>�������  </t>" @ $Get_Dialog_GeShi[31409] @ "60����ɫװ�����������</t><b/>" @
		"<t>ˢ��λ��  </t>" @ $Get_Dialog_GeShi[31409] @ "��ɽѩ�� ��������</t>" @ "<b/>" @
		"<t>ˢ��ʱ��  </t>" @ $Get_Dialog_GeShi[31409] @ "6</t>" @ "<t>Сʱ</t><b/><b/>" @
		$Get_Dialog_GeShi[31421] @ "��ʾ�����һ�λ��ܣ����ɻ������������</t></t>";
}
function GetStrategySubBtnNum(%Type)//�������ؼ�������Ҫ���ٸ��ӿؼ�
{
	//if ( %StrategySubBtnNum[ %Type ] $= "" )
	//{
	%StrategySubBtnNum[%Type] = 0;
	for (%i = 0; %i <=99; %i++)
	{
		//echo( "$StrategySubBtnTit[ " @ %Type @ "," @  %i @ "]==" @ $StrategySubBtnTit[ %Type, %i ] );
		if ($StrategySubBtnTit[%Type,%i] $= "")
			break;
		%StrategySubBtnNum[%Type]++;
	}
	//}
	return %StrategySubBtnNum[%Type];
}
Schedule(30000,0,"SetStrategyBtnText");
//�������������Խ��桿�����������ӿؼ��ı�����������������
