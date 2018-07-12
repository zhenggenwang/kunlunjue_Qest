//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//完成任务过程处理
//==================================================================================
//■■■■■■■■■■■■■■主线升级任务■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■■■生活技能任务■■■■■■■■■■■■■■■■
//■■■■■■■■■■■■■■悬赏循环任务■■■■■■■■■■■■■■■■

//case 3: %MidName = "Mission_End_Process_"@ %Mid;		//完成任务过程处理
/*例如:
function Mission_End_Process_21632(%Npc, %Player, %Conv, %Param, %Mid)
{
%sex=%Player.GetSex();
//邮件内容
%MailText = "您的结婚祝福礼物，希望您在武媚娘传奇HD的世界天天开心。";
//发送邮件
SptMail_SendBindPlayer(%Player.GetPlayerID(),113010071 , 2, 0, 0, "结婚祝福", %MailText, 0, 1);
SptMail_SendBindPlayer(%Player.GetPlayerID(),105103043 , 2, 0, 0, "结婚祝福", %MailText, 0, 1);
if (%sex == 1 )
SptMail_SendBindPlayer(%Player.GetPlayerID(),119013151 , 1, 0, 0, "结婚祝福", %MailText, 0, 1);
else  SptMail_SendBindPlayer(%Player.GetPlayerID(),119013517 , 1, 0, 0, "结婚祝福", %MailText, 0, 1);
}
*/
//■■■■■■■■■■■■■■主线升级任务■■■■■■■■■■■■■■■■

function Mission_End_Process_10021(%Npc,%Player,%Conv,%Param,%Mid)//美味海鲜
{
	%Conv.Settype(4);
	AddMissionAccepted(%Player,0,10031);//接下一个任务
}

function Mission_End_Process_10031(%Npc,%Player,%Conv,%Param,%Mid)//趁手兵器
{
	%Conv.Settype(4);
	AddMissionAccepted(%Player,0,10032);//接下一个任务
}

function Mission_End_Process_10331(%Npc,%Player,%Conv,%Param,%Mid)//秘地
{
	%Conv.Settype(4);
	AddMissionAccepted(%Player,0,10341);//接下一个任务
	ChangeLogicFloor(%Player,0,%Player);
	%player.TransportObject(0,0,-175.45,141.746,430.737);//传送坐标
}
function Mission_End_Process_10551( %Npc, %Player, %Conv, %Param, %Mid )//送餐
{
	%Conv.Settype( 4 );
	AddItem_BaoGuoNo_Mail( %Player, 108020013, -1, 1, "1 " @ %Mid );//扣除一个任务道具
}
function Mission_End_Process_10571( %Npc, %Player, %Conv, %Param, %Mid )//送餐
{
	%Conv.Settype( 4 );
	AddItem_BaoGuoNo_Mail( %Player, 108020013, -1, 1, "1 " @ %Mid );//扣除一个任务道具
}
function Mission_End_Process_10591( %Npc, %Player, %Conv, %Param, %Mid )//送餐
{
	%Conv.Settype( 4 );
	AddItem_BaoGuoNo_Mail( %Player, 108020013, -1, 1, "1 " @ %Mid );//扣除一个任务道具
}
function Mission_End_Process_10611( %Npc, %Player, %Conv, %Param, %Mid )//送餐
{
	%Conv.Settype( 4 );
	AddItem_BaoGuoNo_Mail( %Player, 108020013, -1, 1, "1 " @ %Mid );//扣除一个任务道具
}
function Mission_End_Process_10631( %Npc, %Player, %Conv, %Param, %Mid )//送餐
{
	%Conv.Settype( 4 );
	AddItem_BaoGuoNo_Mail( %Player, 108020013, -1, 1, "1 " @ %Mid );//扣除一个任务道具
}
//■■■■■■■■■■■■■■主线升级任务■■■■■■■■■■■■■■■■

//■■■■■■■■■■■■■■生活技能任务■■■■■■■■■■■■■■■■
//-----------------------------挖矿------------------------------------
function Mission_End_Process_30101(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501011001); }
function Mission_End_Process_30102(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501011002); }
function Mission_End_Process_30103(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501011003); }
function Mission_End_Process_30104(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501011004); }
function Mission_End_Process_30105(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501011005); }
function Mission_End_Process_30106(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501011006); }
function Mission_End_Process_30107(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501011007); }
function Mission_End_Process_30108(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501011008); }
function Mission_End_Process_30109(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501011009); }
function Mission_End_Process_30110(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501011010); }
//-----------------------------伐木------------------------------------
function Mission_End_Process_30111(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501021001); }
function Mission_End_Process_30112(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501021002); }
function Mission_End_Process_30113(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501021003); }
function Mission_End_Process_30114(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501021004); }
function Mission_End_Process_30115(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501021005); }
function Mission_End_Process_30116(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501021006); }
function Mission_End_Process_30117(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501021007); }
function Mission_End_Process_30118(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501021008); }
function Mission_End_Process_30119(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501021009); }
function Mission_End_Process_30120(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501021010); }
//-----------------------------采药------------------------------------
function Mission_End_Process_30121(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501051001); }
function Mission_End_Process_30122(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501051002); }
function Mission_End_Process_30123(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501051003); }
function Mission_End_Process_30124(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501051004); }
function Mission_End_Process_30125(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501051005); }
function Mission_End_Process_30126(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501051006); }
function Mission_End_Process_30127(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501051007); }
function Mission_End_Process_30128(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501051008); }
function Mission_End_Process_30129(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501051009); }
function Mission_End_Process_30130(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501051010); }
//-----------------------------钓鱼------------------------------------
function Mission_End_Process_30131(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501031001); }
function Mission_End_Process_30132(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501031002); }
function Mission_End_Process_30133(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501031003); }
function Mission_End_Process_30134(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501031004); }
function Mission_End_Process_30135(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501031005); }
function Mission_End_Process_30136(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501031006); }
function Mission_End_Process_30137(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501031007); }
function Mission_End_Process_30138(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501031008); }
function Mission_End_Process_30139(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501031009); }
function Mission_End_Process_30140(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,501031010); }
//-----------------------------铸造------------------------------------
function Mission_End_Process_30203(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,502011001); }
function Mission_End_Process_30204(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,502011002); }
function Mission_End_Process_30205(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,502011003); }
function Mission_End_Process_30206(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,502011004); }
function Mission_End_Process_30207(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,502011005); }
function Mission_End_Process_30208(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,502011006); }
function Mission_End_Process_30209(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,502011007); }
function Mission_End_Process_30210(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,502011008); }
function Mission_End_Process_30211(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,502011009); }
function Mission_End_Process_30212(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,502011010); }
//-----------------------------裁缝------------------------------------
function Mission_End_Process_30303(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,503011001); }
function Mission_End_Process_30304(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,503011002); }
function Mission_End_Process_30305(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,503011003); }
function Mission_End_Process_30306(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,503011004); }
function Mission_End_Process_30307(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,503011005); }
function Mission_End_Process_30308(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,503011006); }
function Mission_End_Process_30309(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,503011007); }
function Mission_End_Process_30310(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,503011008); }
function Mission_End_Process_30311(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,503011009); }
function Mission_End_Process_30312(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,503011010); }
//-----------------------------制器------------------------------------
function Mission_End_Process_30403(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,504011001); }
function Mission_End_Process_30404(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,504011002); }
function Mission_End_Process_30405(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,504011003); }
function Mission_End_Process_30406(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,504011004); }
function Mission_End_Process_30407(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,504011005); }
function Mission_End_Process_30408(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,504011006); }
function Mission_End_Process_30409(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,504011007); }
function Mission_End_Process_30410(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,504011008); }
function Mission_End_Process_30411(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,504011009); }
function Mission_End_Process_30412(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,504011010); }
//-----------------------------炼丹------------------------------------
function Mission_End_Process_30503(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,506011001); }
function Mission_End_Process_30504(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,506011002); }
function Mission_End_Process_30505(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,506011003); }
function Mission_End_Process_30506(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,506011004); }
function Mission_End_Process_30507(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,506011005); }
function Mission_End_Process_30508(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,506011006); }
function Mission_End_Process_30509(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,506011007); }
function Mission_End_Process_30510(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,506011008); }
function Mission_End_Process_30511(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,506011009); }
function Mission_End_Process_30512(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,506011010); }
//-----------------------------符咒------------------------------------
function Mission_End_Process_30603(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,505011001); }
function Mission_End_Process_30604(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,505011002); }
function Mission_End_Process_30605(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,505011003); }
function Mission_End_Process_30606(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,505011004); }
function Mission_End_Process_30607(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,505011005); }
function Mission_End_Process_30608(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,505011006); }
function Mission_End_Process_30609(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,505011007); }
function Mission_End_Process_30610(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,505011008); }
function Mission_End_Process_30611(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,505011009); }
function Mission_End_Process_30612(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,505011010); }
//-----------------------------烹饪------------------------------------
function Mission_End_Process_30703(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,507011001); }
function Mission_End_Process_30704(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,507011002); }
function Mission_End_Process_30705(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,507011003); }
function Mission_End_Process_30706(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,507011004); }
function Mission_End_Process_30707(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,507011005); }
function Mission_End_Process_30708(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,507011006); }
function Mission_End_Process_30709(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,507011007); }
function Mission_End_Process_30710(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,507011008); }
function Mission_End_Process_30711(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,507011009); }
function Mission_End_Process_30712(%Npc,%Player,%Conv,%Param,%Mid){ Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,507011010); }

function Mission_ShengHuoJiNeng_TianJia(%Npc,%Player,%Conv,%Param,%Mid,%Skillid)
{
	%Conv.Settype(4);
	//echo( "%Skillid==========" @ %Skillid );
	LearnLivingSkill(%Player,%Skillid);//获得技能
}

//■■■■■■■■■■■■■■生活技能任务■■■■■■■■■■■■■■■■

//■■■■■■■■■■■■■■悬赏循环任务■■■■■■■■■■■■■■■■
function Mission_End_Process_29101(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29102(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29103(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29104(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29105(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29106(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29107(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29108(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29109(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29110(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29111(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29112(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29113(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29114(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29115(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29116(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29117(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29118(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29119(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29120(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29121(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29122(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29123(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29124(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29125(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29126(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29127(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29128(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29129(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29130(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29131(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29132(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29133(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29134(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29135(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29136(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29137(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29138(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29139(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29140(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29141(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29142(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29143(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29144(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29145(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29146(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29147(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29148(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29149(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29150(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29201(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29202(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29203(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29204(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29205(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29206(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29207(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29208(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29209(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29210(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29211(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29212(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29213(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29214(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29215(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29216(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29217(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29218(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29219(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29220(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29221(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29222(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29223(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29224(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29225(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29226(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29227(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29228(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29229(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29230(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29231(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29232(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29233(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29234(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29235(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29236(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29237(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29238(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29239(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29240(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29241(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29242(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29243(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29244(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29245(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29246(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29247(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29248(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29249(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29250(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29301(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29302(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29303(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29304(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29305(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29306(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29307(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29308(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29309(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29310(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29311(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29312(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29313(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29314(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29315(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29316(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29317(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29318(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29319(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29320(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29321(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29322(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29323(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29324(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29325(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29326(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29327(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29328(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29329(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29330(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29331(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29332(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29333(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29334(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29335(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29336(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29337(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29338(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29339(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29340(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29341(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29342(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29343(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29344(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29345(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29346(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29347(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29348(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29349(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29350(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29401(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29402(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29403(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29404(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29405(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29406(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29407(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29408(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29409(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29410(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29411(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29412(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29413(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29414(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29415(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29416(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29417(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29418(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29419(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29420(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29421(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29422(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29423(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29424(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29425(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29426(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29427(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29428(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29429(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29430(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29431(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29432(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29433(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29434(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29435(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29436(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29437(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29438(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29439(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29440(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29441(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29442(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29443(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29444(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29445(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29446(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29447(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29448(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29449(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29450(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29501(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29502(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29503(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29504(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29505(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29506(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29507(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29508(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29509(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29510(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29511(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29512(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29513(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29514(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29515(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29516(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29517(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29518(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29519(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29520(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29521(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29522(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29523(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29524(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29525(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29526(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29527(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29528(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29529(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29530(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29531(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29532(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29533(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29534(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29535(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29536(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29537(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29538(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29539(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29540(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29541(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29542(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29543(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29544(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29545(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29546(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29547(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29548(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29549(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29550(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29601(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29602(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29603(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29604(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29605(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29606(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29607(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29608(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29609(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29610(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29611(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29612(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29613(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29614(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29615(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29616(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29617(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29618(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29619(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29620(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29621(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29622(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29623(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29624(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29625(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29626(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29627(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29628(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29629(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29630(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29631(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29632(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29633(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29634(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29635(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29636(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29637(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29638(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29639(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29640(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29641(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29642(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29643(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29644(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29645(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29646(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29647(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29648(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29649(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }
function Mission_End_Process_29650(%Npc,%Player,%Conv,%Param,%Mid){ MissionXuanShangJiXiongEndProcess(%Npc,%Player,%Conv,%Param,%Mid); }


function Mission_End_Process_20029(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }//斩妖除魔·一
function Mission_End_Process_20030(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }//斩妖除魔·二
function Mission_End_Process_20031(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }//斩妖除魔·三
function Mission_End_Process_20032(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }//斩妖除魔·四
function Mission_End_Process_20033(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }//斩妖除魔·五
function Mission_End_Process_20034(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }//斩妖除魔·六
function Mission_End_Process_20035(%Npc,%Player,%Conv,%Param,%Mid){ Mission_End_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid); }//斩妖除魔·七
function Mission_End_Process_20029_20035(%Npc,%Player,%Conv,%Param,%Mid)
{
	%OneExp = $Monster_Exp[%Player.Getlevel(),1];
	//经验奖励 = 总杀怪数量 * 任务等级对应怪物经验 * 10%
	%FlagB = %Player.GetMissionFlag(%Mid,1300);
	%Exp = %FlagB * %OneExp * 0.1;
	AllAddExp(%Player,%Exp);
}
//■■■■■■■■■■■■■■悬赏循环任务■■■■■■■■■■■■■■■■

function Mission_End_Process_20146(%Npc,%Player,%Conv,%Param,%Mid)
{
	%Level = %Player.GetLevel();
	%OneExp = $Monster_Exp[%Level,1];
	if (%Level < 40) %LevelXiShu = 1;
	else if (%Level < 50) %LevelXiShu = 1.2;
	else if (%Level < 60) %LevelXiShu = 1.6;
	else if (%Level < 70) %LevelXiShu = 2;
	else %LevelXiShu = 2.2;
	%Exp =  %OneExp * 80 * %LevelXiShu;
	AllAddExp(%Player,%Exp);
}


function Mission_End_Process_20036(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 1); }//英雄贴·一
function Mission_End_Process_20037(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 3); }//英雄贴·二
function Mission_End_Process_20038(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 5); }//英雄贴·三
function Mission_End_Process_20039(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 7); }//英雄贴·四
function Mission_End_Process_20040(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 10); }//英雄贴·五
function Mission_End_Process_20041(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 10); }//英雄贴·六
function Mission_End_Process_20042(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 10); }//英雄贴·七
function Mission_End_Process_20043(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 1); }//英雄贴·一
function Mission_End_Process_20044(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 3); }//英雄贴·二
function Mission_End_Process_20045(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 5); }//英雄贴·三
function Mission_End_Process_20046(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 7); }//英雄贴·四
function Mission_End_Process_20047(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 10); }//英雄贴·五
function Mission_End_Process_20048(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 10); }//英雄贴·六
function Mission_End_Process_20049(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 10); }//英雄贴·七
function Mission_End_Process_20050(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 1); }//英雄贴·一
function Mission_End_Process_20051(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 3); }//英雄贴·二
function Mission_End_Process_20052(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 5); }//英雄贴·三
function Mission_End_Process_20053(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 7); }//英雄贴·四
function Mission_End_Process_20054(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 10); }//英雄贴·五
function Mission_End_Process_20055(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 10); }//英雄贴·六
function Mission_End_Process_20056(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 10); }//英雄贴·七
function Mission_End_Process_20057(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 1); }//英雄贴·一
function Mission_End_Process_20058(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 3); }//英雄贴·二
function Mission_End_Process_20059(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 5); }//英雄贴·三
function Mission_End_Process_20060(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 7); }//英雄贴·四
function Mission_End_Process_20061(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 10); }//英雄贴·五
function Mission_End_Process_20062(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 10); }//英雄贴·六
function Mission_End_Process_20063(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 10); }//英雄贴·七
function Mission_End_Process_20064(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 1); }//英雄贴·一
function Mission_End_Process_20065(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 3); }//英雄贴·二
function Mission_End_Process_20066(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 5); }//英雄贴·三
function Mission_End_Process_20067(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 7); }//英雄贴·四
function Mission_End_Process_20068(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 10); }//英雄贴·五
function Mission_End_Process_20069(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 10); }//英雄贴·六
function Mission_End_Process_20070(%Npc, %Player, %Conv, %Param, %Mid){ Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, 10); }//英雄贴·七
function Mission_End_Process_20036_20070(%Npc, %Player, %Conv, %Param, %Mid, %ExpXiShu)
{
	%Level = %Player.GetLevel();
	%OneExp = $Monster_Exp[%Level, 1];

	if (%Level < 40) %LevelXiShu = 1;
	else if (%Level < 50) %LevelXiShu = 1.2;
	else if (%Level < 60) %LevelXiShu = 1.6;
	else if (%Level < 70) %LevelXiShu = 2;
	else %LevelXiShu = 2.2;
	%Exp =  %OneExp * 500 * %LevelXiShu * %ExpXiShu;
	AllAddExp(%Player, %Exp);
	SetSrc(%Player, 198);
}