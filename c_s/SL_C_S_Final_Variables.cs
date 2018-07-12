//==================================================================================
//注：所有脚本开头，均需注明本脚本的大致说明文字
//
//
//管理客户端与服务端的所有全局变量：任务数据变量不在本脚本内
//==================================================================================


//===============================服务端与客户端共用的===============================
//■■■■■■■■■■■制定各字体的格式■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■NPC传送功能添加■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■全局的特效编号■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■各大地图的随机坐标■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■各个怪物等级给于的基本经验■■■■■■■■■■■■■■■
//■■■■■■■■■■■怪物和人物等级差的经验消减■■■■■■■■■■■■■■■
//■■■■■■■■■■■人物神兽化身升级所需的经验■■■■■■■■■■■■■■■

//■■■■■■■■■■■特殊配方给于的道具■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■各个Data相关位置■■■■■■■■■■■■■■■■■■■■
//■■■■■首座论经题库■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
//■■■■■任务答题库■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■官职系统【领取俸禄】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【剧情副本排名相关全局变量】■■■■■■■■■■■■■
//■■■■■■■■■■■【金币复活所需消耗】■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【聚宝盆全局变量】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【十日嘉年华奖励】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【仙缘解签秀图标】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【各职业各种全局变量】■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【任务道具奖励】■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【押镖活动押金】■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【领取奖品界面】■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【悬赏吉凶界面】■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【宝石重铸概率表】■■■■■■■■■■■■■■■
//■■■■■■■■■■■【悬赏缉凶道具奖励表】■■■■■■■■■■■■■
//■■■■■■■■■■■【七日冲榜奖励】■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【排行榜奖励展示】■■■■■■■■■■■■
//■■■■■■■■■■■制定各字体的格式■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【排行榜奖励展示】■■■■■■■■■■■■■■■
//■■■■■■■■■■■【限时抢购】■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■【门派声望捐献】■■■■■■■■■■■■■■■■
//只能使用以下四种字体:
//宋体,黑体,楷体_GB2312,隶书
//字号从10,12,14,16,18,20共6种。
//只有宋体12和宋体14是点阵字体
//其它字体均使用抗锯齿处理

//f = 字体
//m = 是否点阵字显示，1点阵字，0优化抗锯齿显示
//n = 字号
//c = 文字颜色
//o = 文字描边的颜色
//u = 下划线的颜色
//h = 是否左右居中，0或不填默认为左对齐，1左右居中，2右对齐
//v = 是否垂直居中，0默认下对齐，1垂直居中，2向上对齐，文本内文字默认为0,按钮内文字默认为1


//黑体


$Get_Dialog_GeShi[11200] = "<t f='黑体' m='0' n='12' c='0xf3d300ff' o='0x010101ff'>";				//黄色
$Get_Dialog_GeShi[11201] = "<t f='黑体' m='0' b='1' n='12' gct='0xffff00ff' gcb='0xd9680dff'>";		//渐变黄色－标题格式

$Get_Dialog_GeShi[11400] = "<t f='黑体' m='0' b='1' n='14' gct='0xffff00ff' gcb='0xd9680dff'>";		//渐变黄色－标题格式
$Get_Dialog_GeShi[11401] = "<t f='黑体' m='0' n='14' c='0xf3d300ff' o='0x291b00ff'>";				//黄色
$Get_Dialog_GeShi[11402] = "<t f='黑体' m='0' n='14' c='0xffffffff' o='0x010101ff'>";				//白色 主要文本显示
$Get_Dialog_GeShi[11403] = "<t f='黑体' b='1'm='0' n='14' c='0xffffffff' o='0x291b00ff'>";				//白色 
$Get_Dialog_GeShi[11404] = "<t f='黑体' b='1' m='0' n='14' u='0xffffffff' c='0xfd8eecff' o='0x010101ff'>";//粉色+白色下划线
$Get_Dialog_GeShi[11405] = "<t f='黑体' b='1' m='0' n='14' c='0x50ed36ff' o='0x010101ff'>";//绿色
$Get_Dialog_GeShi[11406] = "<t f='黑体' b='1' m='0' n='14' c='0xff65feff' o='0x2c2c2cff'>";//紫色
$Get_Dialog_GeShi[11407] = "<t f='黑体' m='0' n='14' c='0xff4b52ff' o='0x2c2c2cff'>";	//红色

$Get_Dialog_GeShi[11600] = "<t f='黑体' m='0' n='16' c='0xf3d300ff' o='0x291b00ff'>";				//黄色
$Get_Dialog_GeShi[11601] = "<t f='黑体' m='0' n='16' c='0x00ff00ff' o='0x291b00ff'>";				//白色
$Get_Dialog_GeShi[12000] = "<t f='黑体' m='1' n='20' c='0xff4b52ff' o='0x2c2c2cff'>";				//红色
$Get_Dialog_GeShi[12201] = "<t f='黑体' m='0' n='20' c='0x000000ff' o='0xffffffff'>";				//黑色

$Get_Dialog_GeShi[12400] = "<t f='黑体' m='0' n='24' h='1' gct='0x36ffffff'>";				//黑色
//隶书
$Get_Dialog_GeShi[21400] = "<t f='隶书' m='1' n='14' c='0xff4b52ff' o='0x2c2c2cff'>";				//红色
$Get_Dialog_GeShi[21800] = "<t f='隶书' m='0' n='18' c='0xf3d300ff' o='0x291b00ff'>";				//黄色
$Get_Dialog_GeShi[21801] = "<t f='隶书' m='1' n='18' c='0xff4b52ff' o='0x2c2c2cff'>";				//红色
$Get_Dialog_GeShi[21802] = "<t f='隶书' m='0' n='24' h ='0' c='0xffffffff' o='0x010101ff'>";	//白色

$Get_Dialog_GeShi[22401] = "<t f='隶书' m='0' n='24' h ='0' c='0xffffffff' o='0x010101ff'>";
$Get_Dialog_GeShi[22402] = "<t f='隶书' m='0' n='24' h ='2' c='0xffffffff' o='0x010101ff'>";

//宋体
$Get_Dialog_GeShi[31200] = "<t f='宋体' m='1' n='12' c='0x000000ff' o='0xffffffff'>";				//黑色
$Get_Dialog_GeShi[31201] = "<t f='宋体' m='1' n='12' h='0'c='0xffffffff' o='0x010101ff'>";				//白色
$Get_Dialog_GeShi[31202] = "<t f='宋体' m='1' n='12' c='0x00b0f0ff' o='0x010101ff'>";				//蓝色
$Get_Dialog_GeShi[31203] = "<t f='宋体' m='1' n='12' c='0x00ff4eff' o='0x010101ff'>";				//绿色
$Get_Dialog_GeShi[31204] = "<t f='宋体' m='1' n='12' c='0xf3d300ff' o='0x010101ff'>";				//黄色
$Get_Dialog_GeShi[31205] = "<t f='宋体' m='1' n='12' c='0xff8585ff' o='0x010101ff'>";				//粉色
$Get_Dialog_GeShi[31206] = "<t f='宋体' m='1' n='12' c='0xff0000ff' o='0x010101ff'>";				//红色
$Get_Dialog_GeShi[31207] = "<t f='宋体' m='1' n='12' c='0x696668ff' o='0x010101ff'>";				//灰色
$Get_Dialog_GeShi[31208] = "<t f='宋体' m='1' n='12' c='0x4400ffff' o='0x010101ff'>";				//蓝色
$Get_Dialog_GeShi[31209] = "<t f='宋体' m='1' n='12' c='0xff65feff' o='0x2c2c2cff'>";				//紫色
$Get_Dialog_GeShi[31210] = "<t f='宋体' m='1' n='12' c='0xffffffff'>";												//白色无描边
$Get_Dialog_GeShi[31211] = "<t f='宋体' m='1' n='12' c='0x7F0000ff' o='0x614018ff'>";				//褐色

$Get_Dialog_GeShi[31212] = "<t f='宋体' m='1' n='12' v='0' c='0x00ff64ff' o='0x010101ff'>";				//绿色，任务奖励文字

$Get_Dialog_GeShi[31213] = "<t f='宋体' m='1' n='12' c='0xf3d300ff' o='0x010101ff'>";				//黄色
$Get_Dialog_GeShi[31214] = "<t f='宋体' m='1' n='12' v='0' b='0' u='0xbfff00ff' c='0xbfff00ff' o='0x010101ff'>";				//草绿色+白色下划线
$Get_Dialog_GeShi[31215] = "<t f='宋体' m='1' n='12' c='0xff0000ff' o='0x010101ff'>";				//红色－客户端防盗信息
$Get_Dialog_GeShi[31216] = "<t f='宋体' m='1' n='12' h='0' c='0x46ff15ff' o='0x010101ff'>";				//绿色－活动说明特殊表示
$Get_Dialog_GeShi[31217] = "<t f='宋体' m='1' n='12' c='0x29be5eff' o='0x010101ff'>";				//绿色－对白 小提示
$Get_Dialog_GeShi[31218] = "<t f='宋体' m='1' n='12' c='0x18f3ebff' o='0x010101ff'>";				//水蓝色 活动追踪中即将开始的颜色

//系统公告颜色定义
$Get_Dialog_GeShi[31219] = "<t f='宋体' m='1' n='12' c='0x2cffeeff'o='0x010101ff'>";			//活动系统公告普通字体颜色
$Get_Dialog_GeShi[31220] = "<t f='宋体' m='1' n='12' c='0xff65feff' o='0x2c2c2cff'>";			//活动时间 活动等级
$Get_Dialog_GeShi[31221] = "<t f='宋体' m='1' n='12' c='0xff6e00ff' o='0x010101ff'>";			//活动名称
$Get_Dialog_GeShi[31222] = "<t f='宋体' m='1' n='12' c='0xff0080ff' o='0x010101ff'>";			//活动奖励
$Get_Dialog_GeShi[31223] = "<t f='宋体' m='1' n='12' c='0xffff00ff' o='0x010101ff'>";			//活动区域
$Get_Dialog_GeShi[31224] = "<t f='宋体' m='1' n='12' c='0xf28226ff' o='0x010101ff'>";			//玩家名称
$Get_Dialog_GeShi[31225] = "<t f='宋体' m='1' n='12' c='0xbfff00ff' o='0x010101ff'>";			//草绿色

//活动大全界面显示用字体
$Get_Dialog_GeShi[31226] = "<t f='宋体' m='1' b='0' n='12' c='0xffd906ff' o='0x010101ff'>";//黄色 小标题
$Get_Dialog_GeShi[31227] = "<t f='宋体' m='1' b='0' n='12' c='0x30b955ff' o='0x010101ff'>";//深绿色
$Get_Dialog_GeShi[31228] = "<t f='宋体' m='1' b='0' n='12' c='0x00fefeff' o='0x010101ff'>";//草绿色 主要文本

$Get_Dialog_GeShi[31230] = "<t f='宋体' m='1' b='0' n='12' c='0xffc000ff' o='0x010101ff'>";//淡黄色 

$Get_Dialog_GeShi[31225,1] = "<t f='宋体' m='1' n='12' c='0xE40D0Dff' o='0x000000ff'>";				//战场1 - 黑底红边
$Get_Dialog_GeShi[31225,2] = "<t f='宋体' m='1' n='12' c='0x00b0f0ff' o='0x000000ff'>";				//战场2 - 黑底蓝边

//所有选项套用的格式，默认为白色31491
$Get_Dialog_GeShi[31291] = "<t f='宋体' m='1' n='12' c='0xffffffff' o='0x010101ff'>";				//白色-----------普通选项格式
$Get_Dialog_GeShi[31292] = "<t f='宋体' m='1' n='12' c='0xf3d300ff' o='0x010101ff'>";				//黄色-----------接任务选项格式-------主线任务
$Get_Dialog_GeShi[31293] = "<t f='宋体' m='1' n='12' c='0x00ff4eff' o='0x010101ff'>";				//绿色-----------交任务选项格式
$Get_Dialog_GeShi[31294] = "<t f='宋体' m='1' n='12' c='0x696668ff' o='0x010101ff'>";				//灰色-----------条件不满足选项格式
$Get_Dialog_GeShi[31295] = "<t f='宋体' m='1' n='12' c='0xff6e00ff' o='0x010101ff'>";				//橙色-----------特殊醒目选项格式
$Get_Dialog_GeShi[31296] = "<t f='宋体' m='1' n='12' c='0xe8a455ff' o='0x010101ff'>";				//金色-----------接任务选项格式------支线任务名称格式
$Get_Dialog_GeShi[31297] = "<t f='宋体' m='1' n='12' c='0xff0000ff' o='0x000000ff'>";				//红色-----------特殊醒目选项格式------任务追踪树，可接条件不满足的格式
$Get_Dialog_GeShi[31298] = "<t f='宋体' m='1' n='12' c='0x00b0f0ff' o='0x010101ff'>";				//蓝色-----------特殊醒目选项格式------活动相关选项
$Get_Dialog_GeShi[31299] = "<t f='宋体' m='1' n='12' c='0xff0000ff' o='0x000000ff'>";				//红色-----------特殊醒目选项格式------活动说明


$Get_Dialog_GeShi[31399] = "<t f='宋体' m='0' b='1' n='16' gct='0xffff00ff' gcb='0xd9680dff'>";		//渐变黄色－标题格式
$Get_Dialog_GeShi[31400] = "<t f='宋体' m='1' n='14' c='0x000000ff' o='0xffffffff'>";				//黑色
$Get_Dialog_GeShi[31401] = "<t f='宋体' m='1' n='14' c='0xffffffff' o='0x010101ff'>";				//白色
$Get_Dialog_GeShi[31402] = "<t f='宋体' m='1' n='14' c='0x00b0f0ff' o='0x010101ff'>";				//蓝色
$Get_Dialog_GeShi[31403] = "<t f='宋体' m='1' n='14' c='0x00ff4eff' o='0x010101ff'>";				//绿色
$Get_Dialog_GeShi[31404] = "<t f='宋体' m='1' n='14' c='0xf3d300ff' o='0x010101ff'>";				//黄色
$Get_Dialog_GeShi[31405] = "<t f='宋体' m='1' n='14' c='0xff8585ff' o='0x010101ff'>";				//粉色
$Get_Dialog_GeShi[31406] = "<t f='宋体' m='1' n='14' c='0xff0000ff' o='0x000000ff'>";				//红色
$Get_Dialog_GeShi[31407] = "<t f='宋体' m='1' n='14' c='0x696668ff' o='0x010101ff'>";				//灰色
$Get_Dialog_GeShi[31408] = "<t f='宋体' m='1' n='14' c='0x4400ffff' o='0x010101ff'>";				//蓝色
$Get_Dialog_GeShi[31409] = "<t f='宋体' m='1' n='14' c='0xff65feff' o='0x2c2c2cff'>";				//紫色
$Get_Dialog_GeShi[31410] = "<t f='宋体' m='1' n='14' c='0xffffffff'>";												//白色无描边
$Get_Dialog_GeShi[31411] = "<t f='宋体' m='1' n='14' c='0x7F0000ff' o='0x614018ff'>";				//褐色
$Get_Dialog_GeShi[31412] = "<t f='宋体' m='1' n='14' c='0x00ff4eff' o='0x010101ff'>";				//绿色，任务奖励文字
$Get_Dialog_GeShi[31413] = "<t f='宋体' m='1' n='14' c='0xf3d300ff' o='0x010101ff'>";				//黄色
$Get_Dialog_GeShi[31414] = "<t f='宋体' m='1' n='13' v='0' b='0' u='0xbfff00ff' c='0xbfff00ff' o='0x010101ff'>";				//草绿色+白色下划线
$Get_Dialog_GeShi[31415] = "<t f='宋体' m='1' n='14' c='0xff0000ff' o='0x000000ff'>";				//红色－客户端防盗信息
$Get_Dialog_GeShi[31416] = "<t f='宋体' m='1' n='14' c='0x46ff15ff' o='0x010101ff'>";				//绿色－活动说明特殊表示
$Get_Dialog_GeShi[31417] = "<t f='宋体' m='1' n='14' c='0x29be5eff' o='0x010101ff'>";				//绿色－对白 小提示
$Get_Dialog_GeShi[31418] = "<t f='宋体' m='1' n='14' c='0x18f3ebff' o='0x010101ff'>";				//水蓝色 活动追踪中即将开始的颜色

//系统公告颜色定义
$Get_Dialog_GeShi[31419] = "<t f='宋体' m='1' n='14' c='0x2cffeeff' o='0x010101ff'>";			//活动系统公告普通字体颜色
$Get_Dialog_GeShi[31420] = "<t f='宋体' m='1' n='14' c='0xff65feff' o='0x010101ff'>";			//活动时间 活动等级 紫色
$Get_Dialog_GeShi[31421] = "<t f='宋体' m='1' n='14' c='0xffa616ff' o='0x010101ff'>";			//活动名称 橙色
$Get_Dialog_GeShi[31422] = "<t f='宋体' m='1' n='14' c='0xff65feff' o='0x010101ff'>";			//活动奖励
$Get_Dialog_GeShi[31423] = "<t f='宋体' m='1' n='14' c='0xffa616ff' o='0x010101ff'>";			//活动区域
$Get_Dialog_GeShi[31424] = "<t f='宋体' m='1' n='14' c='0x60ff00ff' o='0x010101ff'>";			//玩家名称
$Get_Dialog_GeShi[31425] = "<t f='宋体' m='1' n='14' c='0xbfff00ff' o='0x010101ff'>";			//草绿色

//function ssssssssadasd( )
//{
//	%Text0 = "<t>介绍文本</t>";
//	%Text1 = $Get_Dialog_GeShi[ 31420 ] @ "活动时间</t>";
//	%Text2 = $Get_Dialog_GeShi[ 31421 ] @ "活动名称</t>";
//	%Text3 = $Get_Dialog_GeShi[ 31422 ] @ "活动奖励</t>";
//	%Text4 = $Get_Dialog_GeShi[ 31423 ] @ "活动区域</t>";
//	%Text5 = $Get_Dialog_GeShi[ 31424 ] @ "玩家名称</t>";
//	%Text = %Text2 @ %Text0 @ %Text1 @ %Text0 @ %Text0 @ %Text0 @ %Text5 @ %Text0 @ %Text4 @ %Text0 @ %Text3 @ %Text0 @ %Text0;
//	SendOneLineMessage( $Get_Dialog_GeShi[ 31419 ] @ %Text @ "</t>" );
//}
$Get_Dialog_GeShi[31425,1] = "<t f='宋体' m='1' n='14' c='0xE40D0Dff' o='0x000000ff'>";				//战场1 - 黑底红边
$Get_Dialog_GeShi[31425,2] = "<t f='宋体' m='1' n='14' c='0x00b0f0ff' o='0x000000ff'>";				//战场2 - 黑底蓝边

//活动大全界面显示用字体
$Get_Dialog_GeShi[31426] = "<t f='宋体' m='1' b='0' n='14' c='0xffd906ff' o='0x010101ff'>";//黄色 小标题
$Get_Dialog_GeShi[31427] = "<t f='宋体' m='1' b='0' n='14' c='0x30b955ff' o='0x010101ff'>";//深绿色
$Get_Dialog_GeShi[31428] = "<t f='宋体' m='1' b='0' n='14' c='0x00fefeff' o='0x010101ff'>";//草绿色 主要文本


$Get_Dialog_GeShi[31429] = "<t f='宋体' m='1' b='0' n='14' c='0xfff775ff' o='0x010101ff'>";//米黄色 
$Get_Dialog_GeShi[31430] = "<t f='宋体' m='1' b='0' n='14' c='0xffc000ff' o='0x010101ff'>";//淡黄色 

//所有选项套用的格式，默认为白色31491
$Get_Dialog_GeShi[31491] = "<t f='宋体' m='1' n='14' c='0xffffffff' o='0x010101ff'>";	//白色-----------普通选项格式
$Get_Dialog_GeShi[31492] = "<t f='宋体' m='1' n='14' c='0xf3d300ff' o='0x010101ff'>";	//黄色-----------接任务选项格式-------主线任务
$Get_Dialog_GeShi[31493] = "<t f='宋体' m='1' n='14' c='0x00ff4eff' o='0x010101ff'>";	//绿色-----------交任务选项格式
$Get_Dialog_GeShi[31494] = "<t f='宋体' m='1' n='14' c='0x696668ff' o='0x010101ff'>";	//灰色-----------条件不满足选项格式
$Get_Dialog_GeShi[31495] = "<t f='宋体' m='1' n='14' c='0xff6e00ff' o='0x010101ff'>";	//橙色-----------特殊醒目选项格式
$Get_Dialog_GeShi[31496] = "<t f='宋体' m='1' n='14' c='0xe8a455ff' o='0x010101ff'>";	//金色-----------接任务选项格式------支线任务名称格式
$Get_Dialog_GeShi[31497] = "<t f='宋体' m='1' n='14' c='0xff4b52ff' o='0x2c2c2cff'>";	//红色-----------特殊醒目选项格式------任务追踪树，可接条件不满足的格式
$Get_Dialog_GeShi[31498] = "<t f='宋体' m='1' n='14' c='0x00b0f0ff' o='0x010101ff'>";	//蓝色-----------特殊醒目选项格式------活动相关选项
$Get_Dialog_GeShi[31499] = "<t f='宋体' m='1' n='14' c='0xff4b52ff' o='0x2c2c2cff'>";	//红色-----------特殊醒目选项格式------活动说明


$Get_Dialog_GeShi[31601] = "<t f='宋体' m='1' n='16' c='0xffffffff' o='0x010101ff'>";			//白色-提示追踪指引字体

$Get_Dialog_GeShi[31630] = "<t f='宋体' m='1' n='16' c='0xfb9d18ff' o='0x010101ff'>";			//主文本 黄色
$Get_Dialog_GeShi[31631] = "<t f='宋体' m='1' n='16' c='0xed0994ff' o='0x010101ff'>";			//地图名字 紫色
$Get_Dialog_GeShi[31632] = "<t f='宋体' m='1' n='16' c='0xff4b52ff' o='0x2c2c2cff'>";			//地图名字 红色
$Get_Dialog_GeShi[31633] = "<t f='宋体' m='1' n='16' c='0x29f310ff' o='0x010101ff'>";			//区域名字 绿色


//楷体
$Get_Dialog_GeShi[41200] = "<t f='楷体_GB2312' m='0' n='12' c='0xf3d300ff' o='0x291b00ff'>";				//黄色
$Get_Dialog_GeShi[41400] = "<t f='楷体_GB2312' m='0' n='14' c='0xf3d300ff' o='0x291b00ff'>";				//黄色
$Get_Dialog_GeShi[41401] = "<t f='楷体_GB2312' m='0' n='14' c='0x4f2200ff' o='0xac854eff'>";				//棕色
$Get_Dialog_GeShi[41402] = "<t f='楷体_GB2312' m='0' n='14' c='0x0048ffff' o='0x4fa8b3ff'>";				//蓝色
$Get_Dialog_GeShi[41403] = "<t f='楷体_GB2312' m='0' n='14' c='0xffffffff' o='0x010101ff'>";				//白色
$Get_Dialog_GeShi[41404] = "<t f='楷体_GB2312' m='0' n='14' c='0x00ff4eff' o='0x291b00ff'>";				//绿色
$Get_Dialog_GeShi[41405] = "<t f='楷体_GB2312' m='0' n='14' c='0x000000ff' o='0xffffffff'>";				//黑色字体，白色描边
$Get_Dialog_GeShi[41601] = "<t f='楷体_GB2312' m='0' n='16' c='0x4f2200ff' o='0xac854eff'>";				//棕色
$Get_Dialog_GeShi[41602] = "<t f='楷体_GB2312' m='0' n='16' c='0xffffb5ff' o='0x2d2d2dff'>";				//淡黄色
$Get_Dialog_GeShi[41603] = "<t f='楷体_GB2312' m='0' n='14' c='0x000000ff'>";				//黑色
$Get_Dialog_GeShi[41604] = "<t f='楷体_GB2312' m='0' n='16' c='0x00ff4eff' o='0x010101ff'>";				//绿
$Get_Dialog_GeShi[41605] = "<t f='楷体_GB2312' m='0' n='16' c='0x000000ff' o='0xffffffff'>";				//黑色字体，白色描边
$Get_Dialog_GeShi[42001] = "<t f='楷体_GB2312' m='0' n='20' c='0xff6e00ff' o='0x010101ff'>";				//橙色
$Get_Dialog_GeShi[42201] = "<t f='楷体_GB2312' m='0' n='22' c='0xffffb5ff' o='0x2d2d2dff'>";				//淡黄色
$Get_Dialog_GeShi[42202] = "<t f='楷体_GB2312' m='0' n='22' c='0x4f2200ff' o='0xac854eff'>";				//棕色

//特殊格式
$Get_Dialog_GeShi[50000] = "<t u='0xffffffff' o='0x010101ff'>";				//下划线－白色
$Get_Dialog_GeShi[50001] = "<t c='0xf3d300ff' o='0x291b00ff'>";				//描边
$Get_Dialog_GeShi[50002] = "<t v='0' u='0xffffffff' o='0x010101ff'>";	//下划线－白色
$Get_Dialog_GeShi[50003] = "<t c='0x00ff4eff' o='0x010101FF'>";				//描边

//活动奖励颜色
$Get_Dialog_GeShi[50004] = "<t c='0x00ff4eff' o='0x010101FF'>";	//草绿

//特殊对话框
$Get_Dialog_GeShi[50010] = "<t f='楷体_GB2312' m='0' n='18' c='0xffffffff'>";		//白色对白文字

$Get_Dialog_GeShi[50011] = "<t f='楷体_GB2312' m='0' n='16' c='0xf3d300ff'>";		//领取任务选项
$Get_Dialog_GeShi[50012] = "<t f='楷体_GB2312' m='0' n='16' c='0x00ff4eff'>";		//完成任务选项
$Get_Dialog_GeShi[50013] = "<t f='楷体_GB2312' m='0' n='18' c='0xffffffff'>";		//完成任务描述
$Get_Dialog_GeShi[50014] = "<t f='楷体_GB2312' m='0' n='16' c='0x00ff4eff'>";		//任务奖励文字

$Get_Dialog_GeShi[50015] = "<t f='楷体_GB2312' m='0' n='16' c='0xff6e00ff'>";							//功能选项文字
$Get_Dialog_GeShi[50016] = "<t f='楷体_GB2312' m='0' n='16' c='0xffffffff'>";							//白色对白文字
$Get_Dialog_GeShi[50017] = "<t f='楷体_GB2312' m='0' n='16' c='0x00ff4eff'>";							//绿色提示文字
$Get_Dialog_GeShi[50018] = "<t f='楷体_GB2312' m='0' n='20' b='1' gct='0xffff00ff' gcb='0xd9680dff'>";	//标题彩色文字
$Get_Dialog_GeShi[50019] = "<t f='楷体_GB2312' m='0' n='16' c='0xff4b52ff'>";							//红色对白文字
$Get_Dialog_GeShi[50020] = "<t f='楷体_GB2312' m='0' n='16' c='0x00ff4eff'>";							//绿色对白文字

$Get_Dialog_GeShi[50021] = "<t f='楷体_GB2312' m='0' n='16' c='0xff6e00ff'>";		//领取任务选项(橙色)
$Get_Dialog_GeShi[50022] = "<t f='楷体_GB2312' m='0' n='16' c='0xbfff00ff' u='0xbfff00ff' >";		//草绿色寻路文字

//任务相关
$Get_Dialog_GeShi[50100] = "<t f='宋体' m='1' n='12' c='0x00b0f0ff' o='0x010101ff'>"; //任务标题（蓝色）
$Get_Dialog_GeShi[50101] = "<t f='宋体' m='1' n='12' c='0xe6b450ff' o='0x010101ff'>";	//任务名称（黄色）
$Get_Dialog_GeShi[50102] = "<t f='宋体' m='1' n='12' c='0x00ac19ff' o='0x010101ff'>";	//任务名称（绿色）
$Get_Dialog_GeShi[50103] = "<t f='宋体' m='1' n='12' c='0x8e8c86ff' o='0x010101ff'>";	//任务名称（灰色）

$Get_Dialog_GeShi[50110] = "<t f='宋体' b='1' m='1' n='12' c='0xffff00ff' gcb='0xd9a20dff'>";	//金
$Get_Dialog_GeShi[50111] = "<t f='宋体' b='1' m='1' n='12' c='0xffffffff' gcb='0x717171ff'>";	//银
$Get_Dialog_GeShi[50112] = "<t f='宋体' b='1' m='1' n='12' c='0xffaa66ff' gcb='0x88430bff'>";	//铜

//系统跑马公告文字
$Get_Dialog_GeShi[60000] = "<t f='宋体' v='1' m='1' n='16' c='0xffba00ff' o='0x2c2c2cff'>";	//金色
$Get_Dialog_GeShi[60001] = "<t f='宋体' v='1' m='1' n='16' c='0xffff00ff' o='0x2c2c2cff'>";	//黄色  主文本
$Get_Dialog_GeShi[60002] = "<t f='宋体' v='1' m='1' n='16' c='0xff65feff' o='0x2c2c2cff'>";	//紫色
$Get_Dialog_GeShi[60003] = "<t f='宋体' v='1' m='1' n='16' c='0xffa616ff' o='0x2c2c2cff'>";	//橙色
$Get_Dialog_GeShi[60004] = "<t f='宋体' v='1' m='1' n='16' c='0xffffffff' o='0x2c2c2cff'>";	//白色
$Get_Dialog_GeShi[60005] = "<t f='宋体' v='1' m='1' n='16' c='0x00fffcff' o='0x2c2c2cff'>";	//蓝色
$Get_Dialog_GeShi[60006] = "<t f='宋体' v='1' m='1' n='16' c='0x60ff00ff' o='0x2c2c2cff'>";	//绿色 
$Get_Dialog_GeShi[60007] = "<t f='宋体' v='1' m='1' n='16' c='0xff4b52ff' o='0x2c2c2cff'>";	//红色
$Get_Dialog_GeShi[60008] = "<t f='宋体' v='1' m='1' n='16' c='0xff65feff' o='0x2c2c2cff'>";	//活动等级 活动时间

//微软雅黑

$Get_Dialog_GeShi[71200] = "<t f='微软雅黑' m='0' n='12' c='0x000000ff' o='0xffffffff'>";				//黑色
$Get_Dialog_GeShi[71201] = "<t f='微软雅黑' m='0' n='12' c='0xffffffff' o='0x010101ff'>";				//白色
$Get_Dialog_GeShi[71202] = "<t f='微软雅黑' m='0' n='12' c='0x00b0f0ff' o='0x010101ff'>";				//蓝色
$Get_Dialog_GeShi[71203] = "<t f='微软雅黑' m='0' n='12' c='0x00ff4eff' o='0x010101ff'>";				//绿色
$Get_Dialog_GeShi[71204] = "<t f='微软雅黑' m='0' n='12' c='0xf3d300ff' o='0x000000ff'>";				//黄色
$Get_Dialog_GeShi[71205] = "<t f='微软雅黑' m='0' n='12' c='0xff8585ff' o='0x010101ff'>";				//粉色
$Get_Dialog_GeShi[71206] = "<t f='微软雅黑' m='0' n='12' c='0xff4b52ff' o='0x2c2c2cff'>";				//红色
$Get_Dialog_GeShi[71207] = "<t f='微软雅黑' m='0' n='12' c='0x696668ff' o='0x010101ff'>";				//灰色
$Get_Dialog_GeShi[71208] = "<t f='微软雅黑' m='0' n='12' c='0x4400ffff' o='0x010101ff'>";				//蓝色
$Get_Dialog_GeShi[71209] = "<t f='微软雅黑' m='0' n='12' c='0xff65feff' o='0x2c2c2cff'>";				//紫色
$Get_Dialog_GeShi[71210] = "<t f='微软雅黑' m='0' n='12' c='0x29be5eff' o='0x010101ff'>";                //绿色－对白 小提示

$Get_Dialog_GeShi[71299] = "<t f='微软雅黑' m='0' n='12' u='0xbfff00ff' c='0xbfff00ff' o='0x010101ff'>";//绿色，带下划线

$Get_Dialog_GeShi[71300] = "<t f='微软雅黑' m='0' n='13' c='0x000000ff' o='0xffffffff'>";				//黑色
$Get_Dialog_GeShi[71301] = "<t f='微软雅黑' m='0' n='13' c='0xffffffff' o='0x010101ff'>";				//白色
$Get_Dialog_GeShi[71302] = "<t f='微软雅黑' m='0' n='13' c='0x00b0f0ff' o='0x010101ff'>";				//蓝色
$Get_Dialog_GeShi[71303] = "<t f='微软雅黑' m='0' n='13' c='0x00ff4eff' o='0x010101ff'>";				//绿色
$Get_Dialog_GeShi[71304] = "<t f='微软雅黑' m='0' n='13' c='0xf3d300ff' o='0x000000ff'>";				//黄色
$Get_Dialog_GeShi[71305] = "<t f='微软雅黑' m='0' n='13' c='0xff8585ff' o='0x010101ff'>";				//粉色
$Get_Dialog_GeShi[71306] = "<t f='微软雅黑' m='0' n='13' c='0xff4b52ff' o='0x2c2c2cff'>";				//红色
$Get_Dialog_GeShi[71307] = "<t f='微软雅黑' m='0' n='13' c='0x696668ff' o='0x010101ff'>";				//灰色
$Get_Dialog_GeShi[71308] = "<t f='微软雅黑' m='0' n='13' c='0x4400ffff' o='0x010101ff'>";				//蓝色
$Get_Dialog_GeShi[71309] = "<t f='微软雅黑' m='0' n='13' c='0xff65feff' o='0x2c2c2cff'>";				//紫色
$Get_Dialog_GeShi[71310] = "<t f='微软雅黑' m='0' n='15' c='0x2cffeeff' o='0x010101ff'>";				//青色


$Get_Dialog_GeShi[71401] = "<t f='微软雅黑' m='0' h='1' n='14' c='0xffffffff'>";//白色，居中，用在确认框，如【确认要出售】
$Get_Dialog_GeShi[71402] = "<t f='微软雅黑' m='0' h='0' n='14' c='0xffffffff' o='0x010101ff'>";				//白色 左对齐
$Get_Dialog_GeShi[71403] = "<t f='微软雅黑' m='0' h='2' n='14' c='0xffffffff' o='0x010101ff'>";				//白色 右对齐

$Get_Dialog_GeShi[71404] = "<t f='微软雅黑' m='0' n='14' c='0xffffffff' o='0x010101ff'>";				//白色
$Get_Dialog_GeShi[71405] = "<t f='微软雅黑' m='0' n='14' c='0x00b0f0ff' o='0x010101ff'>";				//蓝色
$Get_Dialog_GeShi[71406] = "<t f='微软雅黑' m='0' n='14' gct='0xffff00ff' gcb='0xd9680dff'>";  //渐变黄色－标题格式
$Get_Dialog_GeShi[71407] = "<t f='微软雅黑' m='0' h='0' n='14' c='0xe8a455ff' o='0x010101ff'>";//金色 左对齐


$Get_Dialog_GeShi[71500] = "<t f='微软雅黑' m='0' n='15' c='0x000000ff' o='0xffffffff'>";				//黑色
$Get_Dialog_GeShi[71501] = "<t f='微软雅黑' m='0' n='15' c='0xffffffff' o='0x010101ff'>";				//白色
$Get_Dialog_GeShi[71502] = "<t f='微软雅黑' m='0' n='15' c='0x00b0f0ff' o='0x010101ff'>";				//蓝色
$Get_Dialog_GeShi[71503] = "<t f='微软雅黑' m='0' n='15' c='0x00ff4eff' o='0x010101ff'>";				//绿色
$Get_Dialog_GeShi[71504] = "<t f='微软雅黑' m='0' n='15' c='0xf3d300ff' o='0x000000ff'>";				//黄色
$Get_Dialog_GeShi[71505] = "<t f='微软雅黑' m='0' n='15' c='0xff8585ff' o='0x010101ff'>";				//粉色
$Get_Dialog_GeShi[71506] = "<t f='微软雅黑' m='0' n='15' c='0xff4b52ff' o='0x2c2c2cff'>";				//红色
$Get_Dialog_GeShi[71507] = "<t f='微软雅黑' m='0' n='15' c='0x696668ff' o='0x010101ff'>";				//灰色
$Get_Dialog_GeShi[71508] = "<t f='微软雅黑' m='0' n='15' c='0x4400ffff' o='0x010101ff'>";				//蓝色
$Get_Dialog_GeShi[71509] = "<t f='微软雅黑' m='0' n='15' c='0xff65feff' o='0x2c2c2cff'>";				//紫色

$Get_Dialog_GeShi[72001] = "<t f='微软雅黑' m='0' h='1' n='20' o='0x000000ff' c='0xff6e00ff'>";//橙色，居中，用在确认框，如【第2页】
$Get_Dialog_GeShi[72002] = "<t f='微软雅黑' m='0' h='1' n='14' c='0xff4b52ff' o='0x2c2c2cff'>";//红色，居中，用在确认框，如【删除物品】

$Get_Dialog_GeShi[71600] = "<t f='微软雅黑' m='0' n='16' c='0x000000ff' o='0xffffffff'>";				//黑色
$Get_Dialog_GeShi[71601] = "<t f='微软雅黑' m='0' n='16' c='0xffffffff' o='0x010101ff'>";				//白色
$Get_Dialog_GeShi[71602] = "<t f='微软雅黑' m='0' n='16' c='0x00b0f0ff' o='0x010101ff'>";				//蓝色
$Get_Dialog_GeShi[71603] = "<t f='微软雅黑' m='0' n='16' c='0x00ff4eff' o='0x010101ff'>";				//绿色
$Get_Dialog_GeShi[71604] = "<t f='微软雅黑' m='0' n='16' c='0xf3d300ff' o='0x010101ff'>";				//黄色
$Get_Dialog_GeShi[71605] = "<t f='微软雅黑' m='0' n='16' c='0xff8585ff' o='0x010101ff'>";				//粉色
$Get_Dialog_GeShi[71606] = "<t f='微软雅黑' m='0' n='16' c='0xff4b52ff' o='0x2c2c2cff'>";				//红色
$Get_Dialog_GeShi[71607] = "<t f='微软雅黑' m='0' n='16' c='0x696668ff' o='0x010101ff'>";				//灰色
$Get_Dialog_GeShi[71608] = "<t f='微软雅黑' m='0' n='16' c='0x4400ffff' o='0x010101ff'>";				//蓝色
$Get_Dialog_GeShi[71609] = "<t f='微软雅黑' m='0' n='16' c='0xff65feff' o='0x2c2c2cff'>";				//紫色

$Get_Dialog_GeShi[71610] = "<t f='微软雅黑' m='0' h='0 n='16' c='0xffffffff' o='0x010101ff'>";				//白色

//特殊定制字体  活动描述的文本
$Get_Dialog_GeShi[80000] = "<t f='黑体' m='0' h='1' b='1' n='20' c='0xff6e00ff' o='0x000000ff'>";//			大标题
$Get_Dialog_GeShi[80001] = "<t f='宋体' m='1' n='14' c='0x00b0f0ff' o='0x010101ff'>";//蓝色						小标题
$Get_Dialog_GeShi[80002] = "<t f='宋体' m='1' n='14' c='0xffffffff' o='0x010101ff'>";//白色						正文描述文字
$Get_Dialog_GeShi[80003] = "<t f='宋体' m='1' n='14' c='0xffff00ff' o='0x2c2c2cff'>";//黄色						醒目文字
$Get_Dialog_GeShi[80004] = "<t f='宋体' m='1' n='12' c='0x29be5eff' o='0x010101ff'>";//绿色						小提示
$Get_Dialog_GeShi[80005] = "<t f='宋体' m='1' n='14' u='0xbfff00ff' c='0xbfff00ff' o='0x010101ff'>"; //草绿色+白色下划线  超链接专用
$Get_Dialog_GeShi[80006] = "<t f='宋体' m='1' n='14' c='0xff4b52ff' o='0x2c2c2cff'>";//红色			

//微软雅黑粗体
$Get_Dialog_GeShi[81001] = "<t f='微软雅黑粗体' m='0' n='15' gct='0xffff00ff' gcb='0xd9680dff'>";  //渐变黄色－标题格式
$Get_Dialog_GeShi[81002] = "<t f='微软雅黑粗体' m='0' n='15' c='0x00b0f0ff' o='0x010101ff'>";				//势力蓝色
$Get_Dialog_GeShi[81003] = "<t f='微软雅黑粗体' m='0' n='15' c='0xff6e00ff' o='0x010101ff'>";				//势力橙色
$Get_Dialog_GeShi[81004] = "<t f='微软雅黑粗体' m='0' n='15' c='0xff65feff' o='0x2c2c2cff'>";				//势力紫色
$Get_Dialog_GeShi[81005] = "<t f='微软雅黑粗体' m='0' n='15' c='0xf3d300ff' o='0x010101ff'>";				//势力黄色
$Get_Dialog_GeShi[81006] = "<t f='微软雅黑粗体' m='0' n='15' c='0xff99ccff' o='0x010101ff'>";				//势力棕色
$Get_Dialog_GeShi[81007] = "<t f='微软雅黑粗体' m='0' n='15' c='0xff0000ff' o='0x010101ff'>";				//势力分数黑色
$Get_Dialog_GeShi[81008] = "<t f='微软雅黑粗体' m='0' n='15' c='0xff4b52ff' o='0x2c2c2cff'>";				//红色
$Get_Dialog_GeShi[81009] = "<t f='微软雅黑粗体' m='0' n='15' c='0x00ff4eff' o='0x010101ff'>";				//绿色
$Get_Dialog_GeShi[81010] = "<t f='微软雅黑粗体' m='0' n='15' c='0xffffffff' o='0x010101ff'>";				//白色

$Get_Dialog_GeShi[81201] = "<t f='微软雅黑粗体' m='0' n='15' gct='0xffff00ff' gcb='0xd9680dff'>";  //渐变黄色－标题格式
$Get_Dialog_GeShi[81202] = "<t f='微软雅黑粗体' m='0' n='15' c='0x00b0f0ff' o='0x010101ff'>";				//势力蓝色
$Get_Dialog_GeShi[81203] = "<t f='微软雅黑粗体' m='0' n='15' c='0xff6e00ff' o='0x010101ff'>";				//势力橙色
$Get_Dialog_GeShi[81204] = "<t f='微软雅黑粗体' m='0' n='15' c='0xff65feff' o='0x2c2c2cff'>";				//势力紫色
$Get_Dialog_GeShi[81205] = "<t f='微软雅黑粗体' m='0' n='15' c='0xf3d300ff' o='0x010101ff'>";				//势力黄色
$Get_Dialog_GeShi[81206] = "<t f='微软雅黑粗体' m='0' n='15' c='0xff99ccff' o='0x010101ff'>";				//势力棕色
$Get_Dialog_GeShi[81207] = "<t f='微软雅黑粗体' m='0' n='15' c='0xff0000ff' o='0x010101ff'>";				//势力分数黑色
$Get_Dialog_GeShi[81208] = "<t f='微软雅黑粗体' m='0' n='15' c='0xff4b52ff' o='0x2c2c2cff'>";				//红色
$Get_Dialog_GeShi[81209] = "<t f='微软雅黑粗体' m='0' n='15' c='0x00ff4eff' o='0x010101ff'>";				//绿色
$Get_Dialog_GeShi[81210] = "<t f='微软雅黑粗体' m='0' n='15' c='0xffffffff' o='0x010101ff'>";				//白色

$Get_Dialog_GeShi[81501] = "<t f='微软雅黑粗体' m='0' n='15' gct='0xffff00ff' gcb='0xd9680dff'>";  //渐变黄色－标题格式
$Get_Dialog_GeShi[81502] = "<t f='微软雅黑粗体' m='0' n='15' c='0x00b0f0ff' o='0x010101ff'>";				//势力蓝色
$Get_Dialog_GeShi[81503] = "<t f='微软雅黑粗体' m='0' n='15' c='0xff6e00ff' o='0x010101ff'>";				//势力橙色
$Get_Dialog_GeShi[81504] = "<t f='微软雅黑粗体' m='0' n='15' c='0xff65feff' o='0x2c2c2cff'>";				//势力紫色
$Get_Dialog_GeShi[81505] = "<t f='微软雅黑粗体' m='0' n='15' c='0xf3d300ff' o='0x010101ff'>";				//势力黄色
$Get_Dialog_GeShi[81506] = "<t f='微软雅黑粗体' m='0' n='15' c='0xff99ccff' o='0x010101ff'>";				//势力棕色
$Get_Dialog_GeShi[81507] = "<t f='微软雅黑粗体' m='0' n='15' c='0xff0000ff' o='0x010101ff'>";				//势力分数黑色
$Get_Dialog_GeShi[81508] = "<t f='微软雅黑粗体' m='0' n='15' c='0xff4b52ff' o='0x2c2c2cff'>";				//红色
$Get_Dialog_GeShi[81509] = "<t f='微软雅黑粗体' m='0' n='15' c='0x00ff4eff' o='0x010101ff'>";				//绿色
$Get_Dialog_GeShi[81510] = "<t f='微软雅黑粗体' m='0' n='15' c='0xffffffff' o='0x010101ff'>";				//白色

//----------和装备的各项颜色配合-------------------
$Get_Dialog_GeShi[81521] = "<t f='微软雅黑粗体' m='0' n='15' c='0xffffffff' o='0x010101ff'>";				//白
$Get_Dialog_GeShi[81522] = "<t f='微软雅黑粗体' m='0' n='15' c='0x00ff4eff' o='0x010101ff'>";				//绿
$Get_Dialog_GeShi[81523] = "<t f='微软雅黑粗体' m='0' n='15' c='0x00b0f0ff' o='0x010101ff'>";				//蓝
$Get_Dialog_GeShi[81524] = "<t f='微软雅黑粗体' m='0' n='15' c='0xff65feff' o='0x2c2c2cff'>";				//紫
$Get_Dialog_GeShi[81525] = "<t f='微软雅黑粗体' m='0' n='15' c='0xff6e00ff' o='0x010101ff'>";				//橙
$Get_Dialog_GeShi[81526] = "<t f='微软雅黑粗体' m='0' n='15' c='0xff0000ff' o='0x010101ff'>";				//红
$Get_Dialog_GeShi[81527] = "<t f='微软雅黑粗体' m='0' n='15' c='0x000000ff' o='0xffffffff'>";				//黑
$Get_Dialog_GeShi[81528] = "<t f='微软雅黑粗体' m='0' n='15' c='0xf3d300ff' o='0x010101ff'>";				//黄色
$Get_Dialog_GeShi[81529] = "<t f='微软雅黑粗体' m='0' n='15' c='0x696668ff' o='0x010101ff'>";				//灰色


$Get_Dialog_GeShi[81600] = "<t f='微软雅黑粗体' m='0' n='16'>";				//无颜色，仅有字体和字号
$Get_Dialog_GeShi[81601] = "<t f='微软雅黑粗体' m='0' n='16' c='0xffffffff' o='0x010101ff'>";				//白色 左对齐
$Get_Dialog_GeShi[81602] = "<t f='微软雅黑粗体' m='0' n='16' c='0x000000ff' o='0xffffffff'>";				//黑色
$Get_Dialog_GeShi[81603] = "<t f='微软雅黑粗体' m='0' n='16' c='0xff6e00ff' o='0x010101ff'>";				//橙色
$Get_Dialog_GeShi[81604] = "<t f='微软雅黑粗体' m='0' n='16' c='0xff65feff' o='0x2c2c2cff'>";				//紫色
$Get_Dialog_GeShi[81605] = "<t f='微软雅黑粗体' m='0' n='16' c='0x18f3ebff' o='0x010101ff'>";				//水蓝色 活动追踪中即将开始的颜色
$Get_Dialog_GeShi[81606] = "<t f='微软雅黑粗体' m='0' n='16' gct='0xffff00ff' gcb='0xd9680dff'>";  //渐变黄色－标题格式
$Get_Dialog_GeShi[81607] = "<t f='微软雅黑粗体' m='0' n='16' c='0xff99ccff' o='0x010101ff'>";				//活动系统公告普通字体颜色
$Get_Dialog_GeShi[81608] = "<t f='微软雅黑粗体' m='0' n='16' c='0x00b0f0ff' o='0x010101ff'>";				//势力蓝色
$Get_Dialog_GeShi[81609] = "<t f='微软雅黑粗体' m='0' n='16' c='0xff6e00ff' o='0x010101ff'>";				//势力橙色
$Get_Dialog_GeShi[81610] = "<t f='微软雅黑粗体' m='0' n='16' c='0xff65feff' o='0x2c2c2cff'>";				//势力紫色
$Get_Dialog_GeShi[81611] = "<t f='微软雅黑粗体' m='0' n='16' c='0xf3d300ff' o='0x010101ff'>";				//势力黄色
$Get_Dialog_GeShi[81612] = "<t f='微软雅黑粗体' m='0' n='16' c='0xff4b52ff' o='0x2c2c2cff'>";				//红色
$Get_Dialog_GeShi[81613] = "<t f='微软雅黑粗体' m='0' n='16' c='0x2cffeeff' o='0x010101ff'>";				//青色
$Get_Dialog_GeShi[81614] = "<t f='微软雅黑粗体' m='0' n='16' c='0x00ff4eff' o='0x010101ff'>";				//绿色
$Get_Dialog_GeShi[81615] = "<t f='微软雅黑粗体' m='0' n='16' c='0xf3d300ff' o='0x010101ff'>";				//黄色
$Get_Dialog_GeShi[81616] = "<t f='微软雅黑粗体' m='0' n='16' c='0xff99ccff' o='0x010101ff'>";				//活动系统公告普通字体颜色
$Get_Dialog_GeShi[81617] = "<t f='微软雅黑粗体' m='0' n='16' c='0x00ff4eff' o='0x010101ff'>";				//用于千里传音公告,绿色

$Get_Dialog_GeShi[81801] = "<t f='微软雅黑粗体' m='0' n='18' c='0xff4b52ff' o='0x2c2c2cff'>";				//红色
$Get_Dialog_GeShi[81802] = "<t f='微软雅黑粗体' m='0' n='18' c='0x00ff4eff' o='0x010101ff'>";				//绿色
$Get_Dialog_GeShi[81803] = "<t f='微软雅黑粗体' m='0' n='18' c='0xff65feff' o='0x2c2c2cff'>";				//紫色
$Get_Dialog_GeShi[81804] = "<t f='微软雅黑粗体' m='0' n='18' c='0xf3d300ff' o='0x010101ff'>";				//黄色

$Get_Dialog_GeShi[81805] = "<t f='微软雅黑粗体' m='0' n='18' gct='0xffff00ff' gcb='0xd9680dff'>";  //渐变黄色－标题格式
$Get_Dialog_GeShi[81806] = "<t f='微软雅黑粗体' m='0' n='18' c='0x00b0f0ff' o='0x010101ff'>";				//势力蓝色
$Get_Dialog_GeShi[81807] = "<t f='微软雅黑粗体' m='0' n='18' c='0xff6e00ff' o='0x010101ff'>";				//势力橙色
$Get_Dialog_GeShi[81808] = "<t f='微软雅黑粗体' m='0' n='18' c='0xff65feff' o='0x2c2c2cff'>";				//势力紫色
$Get_Dialog_GeShi[81809] = "<t f='微软雅黑粗体' m='0' n='18' c='0xf3d300ff' o='0x010101ff'>";				//势力黄色
$Get_Dialog_GeShi[81810] = "<t f='微软雅黑粗体' m='0' n='18' c='0xff99ccff' o='0x010101ff'>";				//势力棕色
$Get_Dialog_GeShi[81811] = "<t f='微软雅黑粗体' m='0' n='18' c='0xff0000ff' o='0x010101ff'>";				//势力分数黑色
$Get_Dialog_GeShi[81812] = "<t f='微软雅黑粗体' m='0' n='18' c='0x696668ff' o='0x010101ff'>";				//灰色
$Get_Dialog_GeShi[81813] = "<t f='微软雅黑粗体' m='0' n='18' u='0xbfff00ff' c='0x00b0f0ff' o='0x010101ff'>";//绿色，带下划线

$Get_Dialog_GeShi[82001] = "<t f='微软雅黑粗体' m='0' h='1' n='20' c='0xffffffff'>";//白色，居中，用在确认框，如【确认要出售】
$Get_Dialog_GeShi[82002] = "<t f='微软雅黑粗体' m='0' h='0' n='20' c='0xffffffff' o='0x010101ff'>";				//白色 左对齐
$Get_Dialog_GeShi[82003] = "<t f='微软雅黑粗体' m='0' h='2' n='20' c='0xffffffff' o='0x010101ff'>";				//白色 右对齐

$Get_Dialog_GeShi[82004] = "<t f='微软雅黑粗体' m='0' h='1' n='20' c='0xffffffff' o='0x010101ff'>";				//白色
$Get_Dialog_GeShi[82005] = "<t f='微软雅黑粗体' m='0' n='20' c='0x00b0f0ff' o='0x010101ff'>";				//蓝色
$Get_Dialog_GeShi[82006] = "<t f='微软雅黑粗体' m='0' n='20' gct='0xffff00ff' gcb='0xd9680dff'>";  //渐变黄色－标题格式
$Get_Dialog_GeShi[82007] = "<t f='微软雅黑粗体' m='0' h='0' n='20' c='0xe8a455ff' o='0x010101ff'>";//金色 左对齐

$Get_Dialog_GeShi[82401] = "<t f='微软雅黑粗体' m='0' h='1' n='24' c='0xffffffff' o='0x010101ff'>";				//白色

//■■■■■■■■■■■制定各字体的格式■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■NPC传送功能添加■■■■■■■■■■■■■■■■■■■■■
//---目标地图（地图ID或者区域ID） 传送费用（没有填0） 最低等级限制（最低填0） 最大等级限制（没有填999）  ------ 如果有多个传送选项，用 ; 分号分割
$Transport_Npc[410010103] = "810100100 0 30 150;811010106 65 30 150;1102 65 40 150;1103 105 50 150;1119 0 50 150;";//
$Transport_Npc[411190103] = "810010100 0 30 150;811010100 105 30 150;811020100 105 40 150;811030100 138 50 150;";
$Transport_Npc[411010008] = "810010100 65 30 150;811020100 105 40 150;1119 105 50 150;811030100 65 50 150;";
$Transport_Npc[411020001] = "810010100 65 30 150;811010100 105 30 150;1119 105 50 150;811030100 138 50 150;";
$Transport_Npc[411030008] = "810010100 105 30 150;811010100 65 30 150;811020100 138 40 150;1119 138 50 150;";

$Transport_Npc[410100051] = "810010100 0 30 999;";

$Transport_Npc[410010141] = "1120 0 30 44;1121 0 45 59;1122 0 60 75;";
$Transport_Npc[411190023] = "811190101 0 30 150;811190107 0 30 150";//封魔城管理员

$Transport_Npc[411200005] = "810010115 0 20 999;";
$Transport_Npc[411210005] = "810010115 0 45 999;";
$Transport_Npc[411220005] = "810010115 0 50 999;";


//■■■■■■■■■■■NPC传送功能添加■■■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■全局的特效编号■■■■■■■■■■■■■■■■■■■■■
$SP_Effect[1] = 260021;	//玩家接受任务特效
$SP_Effect[2] = 260022;	//玩家交付任务特效
$SP_Effect[3] = 660005;	//NPC有可接受任务特效
$SP_Effect[4] = 660004;	//NPC有可交付任务特效
$SP_Effect[5] = 610015;	//玩家升级特效
$SP_Effect[6] = 103013;	//玩家传送特效
$SP_Effect[7] = 140707;	//玩家传送特效
//■■■■■■■■■■■全局的特效编号■■■■■■■■■■■■■■■■■■■■■
//■■■■■■■■■■■各大地图的随机坐标■■■■■■■■■■■■■■■■■■■
$strMapRanPosRecordMax[1001] = 219;
$strMapRanPosRecord[1001,1] = "-85.7506 -61.7498 187.344";
$strMapRanPosRecord[1001,2] = "-93.9494 -67.4769 187.41";
$strMapRanPosRecord[1001,3] = "-76.3535 -78.2344 185.147";
$strMapRanPosRecord[1001,4] = "-68.1696 -65.9159 184.036";
$strMapRanPosRecord[1001,5] = "-68.1692 -61.2284 184.036";
$strMapRanPosRecord[1001,6] = "-69.6953 -76.4878 185.284";
$strMapRanPosRecord[1001,7] = "-70.4714 -85.7287 185.383";
$strMapRanPosRecord[1001,8] = "-53.9427 -84.0991 185.907";
$strMapRanPosRecord[1001,9] = "-36.9205 -87.0087 185.255";
$strMapRanPosRecord[1001,10]= "-43.1682 -78.4167 185.43";
$strMapRanPosRecord[1001,11]= "-31.7165 -73.7592 184.824";
$strMapRanPosRecord[1001,12]= "-20.5131 -60.4466 184.039";
$strMapRanPosRecord[1001,13]= "-12.7491 -65.8812 184.039";
$strMapRanPosRecord[1001,14]= "-2.54618 -71.3831 184.184";
$strMapRanPosRecord[1001,15]= "-2.54422 -59.6656 184.184";
$strMapRanPosRecord[1001,16]= "-11.4712 -52.412 187.196";
$strMapRanPosRecord[1001,17]= "-30.6691 -41.6966 188.606";
$strMapRanPosRecord[1001,18]= "-26.846 -27.1682 190.667";
$strMapRanPosRecord[1001,19]= "-13.4821 -27.6339 191.679";
$strMapRanPosRecord[1001,20]= "-5.67019 -22.9471 191.679";
$strMapRanPosRecord[1001,21]= "-0.99108 -19.0481 191.837";
$strMapRanPosRecord[1001,22]= "1.34425 -7.41018 191.854";
$strMapRanPosRecord[1001,23]= "12.2781 2.57603 191.677";
$strMapRanPosRecord[1001,24]= "1.45359 22.1283 194.407";
$strMapRanPosRecord[1001,25]= "-10.3564 13.7725 196.542";
$strMapRanPosRecord[1001,26]= "-18.1683 4.39844 196.542";
$strMapRanPosRecord[1001,27]= "-24.7693 6.04787 196.542";
$strMapRanPosRecord[1001,28]= "-20.8865 14.6113 198.907";
$strMapRanPosRecord[1001,29]= "-27.5442 23.9278 200.046";
$strMapRanPosRecord[1001,30]= "-16.6078 46.5835 199.967";
$strMapRanPosRecord[1001,31]= "-55.5866 8.36016 199.914";
$strMapRanPosRecord[1001,32]= "-9.66297 0.213541 194.489";
$strMapRanPosRecord[1001,33]= "8.19136 -6.47812 191.854";
$strMapRanPosRecord[1001,34]= "13.1642 5.42846 191.677";
$strMapRanPosRecord[1001,35]= "20.8927 12.2095 191.677";
$strMapRanPosRecord[1001,36]= "25.1349 23.8746 188.634";
$strMapRanPosRecord[1001,37]= "14.887 28.7845 188.634";
$strMapRanPosRecord[1001,38]= "28.1449 29.6199 188.634";
$strMapRanPosRecord[1001,39]= "48.2184 25.499 188.634";
$strMapRanPosRecord[1001,40]= "38.0825 25.491 188.634";
$strMapRanPosRecord[1001,41]= "13.0891 43.4417 191.046";
$strMapRanPosRecord[1001,42]= "8.80932 52.951 195.253";
$strMapRanPosRecord[1001,43]= "0.59887 66.0927 201.915";
$strMapRanPosRecord[1001,44]= "0.580955 72.2946 204.531";
$strMapRanPosRecord[1001,45]= "1.56388 94.3687 217.959";
$strMapRanPosRecord[1001,46]= "17.7383 89.3867 220.568";
$strMapRanPosRecord[1001,47]= "-7.49551 91.2225 216.297";
$strMapRanPosRecord[1001,48]= "-10.3558 101.268 217.729";
$strMapRanPosRecord[1001,49]= "-13.9033 102.104 218.075";
$strMapRanPosRecord[1001,50]= "-11.9207 -47.1638 188.606";
$strMapRanPosRecord[1001,51]= "-3.31354 -57.7953 184.184";
$strMapRanPosRecord[1001,52]= "20.113 -36.229 182.163";
$strMapRanPosRecord[1001,53]= "18.55 -27.6366 182.135";
$strMapRanPosRecord[1001,54]= "33.6163 -25.9603 182.279";
$strMapRanPosRecord[1001,55]= "37.0938 -34.9776 182.163";
$strMapRanPosRecord[1001,56]= "42.0662 -48.3618 182.143";
$strMapRanPosRecord[1001,57]= "33.4265 -54.1838 182.143";
$strMapRanPosRecord[1001,58]= "47.8785 -40.9265 182.279";
$strMapRanPosRecord[1001,59]= "43.4664 -23.3151 182.105";
$strMapRanPosRecord[1001,60]= "47.8457 -10.4497 184.095";
$strMapRanPosRecord[1001,61]= "48.2371 1.2717 184.049";
$strMapRanPosRecord[1001,62]= "60.0887 1.2722 184.113";
$strMapRanPosRecord[1001,63]= "62.2991 -6.54008 184.095";
$strMapRanPosRecord[1001,64]= "58.9378 -17.1858 184.049";
$strMapRanPosRecord[1001,65]= "49.7979 -65.8373 180.13";
$strMapRanPosRecord[1001,66]= "60.7361 -65.9153 180.13";
$strMapRanPosRecord[1001,67]= "70.1116 -57.3219 180.743";
$strMapRanPosRecord[1001,68]= "84.1738 -53.4151 180.068";
$strMapRanPosRecord[1001,69]= "74.7996 -36.228 180.023";
$strMapRanPosRecord[1001,70]= "59.6133 -55.2789 180.13";
$strMapRanPosRecord[1001,71]= "63.3795 -73.0632 180.13";
$strMapRanPosRecord[1001,72]= "54.4883 -85.4457 180.054";
$strMapRanPosRecord[1001,73]= "41.7376 -89.0717 182.054";
$strMapRanPosRecord[1001,74]= "34.9566 -81.5415 182.054";
$strMapRanPosRecord[1001,75]= "44.3301 -77.6343 182.054";
$strMapRanPosRecord[1001,76]= "83.3677 -90.132 180.443";
$strMapRanPosRecord[1001,77]= "91.1651 -98.6831 179.382";
$strMapRanPosRecord[1001,78]= "103.924 -113.035 177.845";
$strMapRanPosRecord[1001,79]= "106.835 -128.404 177.609";
$strMapRanPosRecord[1001,80]= "52.7984 71.6483 191.148";
$strMapRanPosRecord[1001,81]= "45.1127 60.6483 191.256";
$strMapRanPosRecord[1001,82]= "47.431 49.8248 191.163";
$strMapRanPosRecord[1001,83]= "42.9879 79.5944 192.817";
$strMapRanPosRecord[1001,84]= "39.6429 96.5842 195.556";
$strMapRanPosRecord[1001,85]= "104.491 -126.068 177.46";
$strMapRanPosRecord[1001,86]= "105.131 -139.577 178.131";
$strMapRanPosRecord[1001,87]= "113.861 -147.946 178.271";
$strMapRanPosRecord[1001,88]= "114.915 -160.58 178.111";
$strMapRanPosRecord[1001,89]= "111.595 -168.994 178.31";
$strMapRanPosRecord[1001,90]= "106.659 -176.953 177.82";
$strMapRanPosRecord[1001,91]= "110.711 -184.639 176.18";
$strMapRanPosRecord[1001,92]= "122.223 -180.355 177.886";
$strMapRanPosRecord[1001,93]= "98.2462 -190.911 175.224";
$strMapRanPosRecord[1001,94]= "82.8614 -196.451 167.574";
$strMapRanPosRecord[1001,95]= "74.3604 -189.243 164.044";
$strMapRanPosRecord[1001,96]= "64.7383 -192.419 161.219";
$strMapRanPosRecord[1001,97]= "66.2053 -203.412 162.316";
$strMapRanPosRecord[1001,98]= "56.8322 -213.57 163.661";
$strMapRanPosRecord[1001,99]= "66.9815 -211.229 164.059";
$strMapRanPosRecord[1001,100]= "47.108 -192.878 154.717";
$strMapRanPosRecord[1001,101]= "35.6436 -192.48 151.307";
$strMapRanPosRecord[1001,102]= "28.937 -181.68 147.67";
$strMapRanPosRecord[1001,103]= "35.5566 -177.024 147.719";
$strMapRanPosRecord[1001,104]= "48.0369 -173.939 149.445";
$strMapRanPosRecord[1001,105]= "43.5022 -166.168 147.19";
$strMapRanPosRecord[1001,106]= "32.9502 -164.389 145.598";
$strMapRanPosRecord[1001,107]= "3.71013 -174.504 143.684";
$strMapRanPosRecord[1001,108]= "-7.90996 -173.927 144.051";
$strMapRanPosRecord[1001,109]= "4.63914 -166.585 142.908";
$strMapRanPosRecord[1001,110]= "-5.66838 -154.978 141.375";
$strMapRanPosRecord[1001,111]= "2.75485 -148.426 142.089";
$strMapRanPosRecord[1001,112]= "5.85649 -136.486 143.422";
$strMapRanPosRecord[1001,113]= "0.58203 -131.54 143.577";
$strMapRanPosRecord[1001,114]= "-12.5919 -128.311 143.91";
$strMapRanPosRecord[1001,115]= "-19.9117 -128.426 143.007";
$strMapRanPosRecord[1001,116]= "-27.5442 -135.424 141.914";
$strMapRanPosRecord[1001,117]= "-29.162 -144.608 141.573";
$strMapRanPosRecord[1001,118]= "-39.2617 -149.509 142.082";
$strMapRanPosRecord[1001,119]= "-55.0469 -146.984 143.779";
$strMapRanPosRecord[1001,120]= "-53.2224 -157.577 142.985";
$strMapRanPosRecord[1001,121]= "138.847 -179.995 181.834";
$strMapRanPosRecord[1001,122]= "131.842 -165.946 178.222";
$strMapRanPosRecord[1001,123]= "145.013 -166.612 180.77";
$strMapRanPosRecord[1001,124]= "161.163 -166.697 183.767";
$strMapRanPosRecord[1001,125]= "164.785 -169.934 186.325";
$strMapRanPosRecord[1001,126]= "171.585 -183.818 192.239";
$strMapRanPosRecord[1001,127]= "163.952 -192.433 193.693";
$strMapRanPosRecord[1001,128]= "176.85 -184.595 193.483";
$strMapRanPosRecord[1001,129]= "190.395 -168.549 192.322";
$strMapRanPosRecord[1001,130]= "202.94 -158.938 195.214";
$strMapRanPosRecord[1001,131]= "206.815 -140.152 195.554";
$strMapRanPosRecord[1001,132]= "207.429 -128.708 194.619";
$strMapRanPosRecord[1001,133]= "183.759 -145.045 183.764";
$strMapRanPosRecord[1001,134]= "168.182 -149.335 181.562";
$strMapRanPosRecord[1001,135]= "155.27 -159.665 180.177";
$strMapRanPosRecord[1001,136]= "144.519 -156.68 179.124";
$strMapRanPosRecord[1001,137]= "147.936 -145.973 177.212";
$strMapRanPosRecord[1001,138]= "166.831 -137.176 177.501";
$strMapRanPosRecord[1001,139]= "178.691 -122.193 175.181";
$strMapRanPosRecord[1001,140]= "167.068 -124.493 174.676";
$strMapRanPosRecord[1001,141]= "151.585 -132.548 176.605";
$strMapRanPosRecord[1001,142]= "137.345 -135.285 177.656";
$strMapRanPosRecord[1001,143]= "137.299 -151.07 177.122";
$strMapRanPosRecord[1001,144]= "160.743 -103.444 171.963";
$strMapRanPosRecord[1001,145]= "172.452 -108.101 172.388";
$strMapRanPosRecord[1001,146]= "181.048 -101.073 172.302";
$strMapRanPosRecord[1001,147]= "188.861 -96.3848 172.814";
$strMapRanPosRecord[1001,148]= "173.811 -87.4901 169.403";
$strMapRanPosRecord[1001,149]= "170.893 -76.8547 168.97";
$strMapRanPosRecord[1001,150]= "181.465 -76.0976 168.675";
$strMapRanPosRecord[1001,151]= "191.361 -78.3137 170.04";
$strMapRanPosRecord[1001,152]= "191.369 -64.9777 168.604";
$strMapRanPosRecord[1001,153]= "182.621 -60.4504 166.487";
$strMapRanPosRecord[1001,154]= "189.311 -55.1868 166.738";
$strMapRanPosRecord[1001,155]= "180.112 -44.4662 163.882";
$strMapRanPosRecord[1001,156]= "187.983 -40.9379 164.894";
$strMapRanPosRecord[1001,157]= "178.184 -37.1393 161.676";
$strMapRanPosRecord[1001,158]= "179.46 -35.4416 161.786";
$strMapRanPosRecord[1001,159]= "186.518 -26.0735 164.244";
$strMapRanPosRecord[1001,160]= "179.175 -21.7528 161.585";
$strMapRanPosRecord[1001,161]= "183.712 -14.2697 163.714";
$strMapRanPosRecord[1001,162]= "181.859 -7.33877 163.437";
$strMapRanPosRecord[1001,163]= "184.869 4.07013 166.402";
$strMapRanPosRecord[1001,164]= "175.84 5.53428 164.502";
$strMapRanPosRecord[1001,165]= "165.427 9.86456 164.975";
$strMapRanPosRecord[1001,166]= "172.728 15.0821 165.928";
$strMapRanPosRecord[1001,167]= "181.984 25.4094 168.637";
$strMapRanPosRecord[1001,168]= "164.528 26.8925 167.969";
$strMapRanPosRecord[1001,169]= "141.204 14.5557 173.69";
$strMapRanPosRecord[1001,170]= "132.613 23.9275 175.052";
$strMapRanPosRecord[1001,171]= "138.712 30.0282 173.314";
$strMapRanPosRecord[1001,172]= "134.353 41.4519 173.319";
$strMapRanPosRecord[1001,173]= "144.496 41.8971 172.418";
$strMapRanPosRecord[1001,174]= "158.517 41.347 170.414";
$strMapRanPosRecord[1001,175]= "176.358 48.1406 171.068";
$strMapRanPosRecord[1001,176]= "195.879 51.27 175.326";
$strMapRanPosRecord[1001,177]= "180.519 53.4671 172.739";
$strMapRanPosRecord[1001,178]= "157.638 52.8733 171.079";
$strMapRanPosRecord[1001,179]= "151.362 58.3032 172.087";
$strMapRanPosRecord[1001,180]= "159.95 67.6728 173.205";
$strMapRanPosRecord[1001,181]= "174.768 70.0173 173.171";
$strMapRanPosRecord[1001,182]= "178.552 81.9227 174.357";
$strMapRanPosRecord[1001,183]= "170.044 85.4547 175.86";
$strMapRanPosRecord[1001,184]= "180.885 88.2531 174.927";
$strMapRanPosRecord[1001,185]= "186.641 97.5861 175.201";
$strMapRanPosRecord[1001,186]= "198.304 100.565 175.137";
$strMapRanPosRecord[1001,187]= "194.743 106.928 175.213";
$strMapRanPosRecord[1001,188]= "198.236 115.334 175.626";
$strMapRanPosRecord[1001,189]= "194.837 126.102 178.161";
$strMapRanPosRecord[1001,190]= "200.948 140.928 181.516";
$strMapRanPosRecord[1001,191]= "190.426 145.803 181.515";
$strMapRanPosRecord[1001,192]= "188.081 141.898 181.516";
$strMapRanPosRecord[1001,193]= "202.528 154.824 181.516";
$strMapRanPosRecord[1001,194]= "210.735 158.303 181.986";
$strMapRanPosRecord[1001,195]= "213.677 167.122 182.755";
$strMapRanPosRecord[1001,196]= "223.254 163.804 185.26";
$strMapRanPosRecord[1001,197]= "233.284 156.067 189.934";
$strMapRanPosRecord[1001,198]= "238.043 146.668 195.267";
$strMapRanPosRecord[1001,199]= "170.894 149.71 180.829";
$strMapRanPosRecord[1001,200]= "161.519 145.804 180.829";
$strMapRanPosRecord[1001,201]= "165.333 156.484 180.829";
$strMapRanPosRecord[1001,202]= "168.492 159.808 180.829";
$strMapRanPosRecord[1001,203]= "159.903 169.223 180.833";
$strMapRanPosRecord[1001,204]= "170.893 170.022 180.833";
$strMapRanPosRecord[1001,205]= "159.43 180.811 180.833";
$strMapRanPosRecord[1001,206]= "151.363 182.522 180.833";
$strMapRanPosRecord[1001,207]= "153.706 191.897 180.833";
$strMapRanPosRecord[1001,208]= "161.518 191.116 180.833";
$strMapRanPosRecord[1001,209]= "169.883 184.544 180.833";
$strMapRanPosRecord[1001,210]= "170.893 194.241 180.833";
$strMapRanPosRecord[1001,211]= "174.969 203.55 183.175";
$strMapRanPosRecord[1001,212]= "184.219 202.85 183.175";
$strMapRanPosRecord[1001,213]= "203.769 207.254 183.175";
$strMapRanPosRecord[1001,214]= "211.259 216.84 183.175";
$strMapRanPosRecord[1001,215]= "203.856 225.359 183.175";
$strMapRanPosRecord[1001,216]= "187.775 228.667 183.175";
$strMapRanPosRecord[1001,217]= "173.663 223.41 183.175";
$strMapRanPosRecord[1001,218]= "186.338 219.23 184.837";
$strMapRanPosRecord[1001,219]= "195.885 214.566 184.837";

$strMapRanPosRecordMax[1010] = 203;
$strMapRanPosRecord[1010,1]="-16.7978 138.449 147.891";
$strMapRanPosRecord[1010,2]="-25.2574 133.535 144.575";
$strMapRanPosRecord[1010,3]="-21.0712 119.583 144.575";
$strMapRanPosRecord[1010,4]="-7.6841 116.674 144.837";
$strMapRanPosRecord[1010,5]="-4.87036 130.736 146.4";
$strMapRanPosRecord[1010,6]="9.89447 137.064 147.891";
$strMapRanPosRecord[1010,7]="12.7071 112.456 144.575";
$strMapRanPosRecord[1010,8]="18.3559 121.698 144.574";
$strMapRanPosRecord[1010,9]="-5.5701 96.2924 141.33";
$strMapRanPosRecord[1010,10]="-24.5582 101.205 138.321";
$strMapRanPosRecord[1010,11]="-26.6836 89.6407 135.799";
$strMapRanPosRecord[1010,12]="-33.6976 92.0641 136.3";
$strMapRanPosRecord[1010,13]="-36.7907 84.6425 136.263";
$strMapRanPosRecord[1010,14]="-44.9158 81.8794 135.085";
$strMapRanPosRecord[1010,15]="-47.7609 75.19 135.085";
$strMapRanPosRecord[1010,16]="-39.3238 68.1585 135.085";
$strMapRanPosRecord[1010,17]="-32.2923 57.6115 135.085";
$strMapRanPosRecord[1010,18]="-20.0783 54.2185 135.085";
$strMapRanPosRecord[1010,19]="-6.97976 58.3143 135.177";
$strMapRanPosRecord[1010,20]="-11.1983 67.4548 135.085";
$strMapRanPosRecord[1010,21]="-25.2604 69.5638 133.713";
$strMapRanPosRecord[1010,22]="-29.4791 82.2199 135.085";
$strMapRanPosRecord[1010,23]="-9.08901 79.4081 135.085";
$strMapRanPosRecord[1010,24]="-6.2767 68.159 135.177";
$strMapRanPosRecord[1010,25]="5.6761 62.5333 135.177";
$strMapRanPosRecord[1010,26]="13.7139 74.3803 135.177";
$strMapRanPosRecord[1010,27]="23.9574 63.9396 135.177";
$strMapRanPosRecord[1010,28]="36.5986 51.2987 137.561";
$strMapRanPosRecord[1010,29]="50.6765 56.2052 137.561";
$strMapRanPosRecord[1010,30]="21.8482 92.0639 135.003";
$strMapRanPosRecord[1010,31]="35.8148 93.461 136.289";
$strMapRanPosRecord[1010,32]="35.2135 101.83 135.877";
$strMapRanPosRecord[1010,33]="23.9785 111.738 136.91";
$strMapRanPosRecord[1010,34]="36.6134 113.861 135";
$strMapRanPosRecord[1010,35]="46.4086 107.565 135";
$strMapRanPosRecord[1010,36]="59.3818 102.772 135.208";
$strMapRanPosRecord[1010,37]="76.3811 98.7899 136.304";
$strMapRanPosRecord[1010,38]="89.3325 90.706 133.938";
$strMapRanPosRecord[1010,39]="93.5673 78.7051 133.831";
$strMapRanPosRecord[1010,40]="82.3382 65.3661 137.432";
$strMapRanPosRecord[1010,41]="83.9998 56.3962 140.295";
$strMapRanPosRecord[1010,42]="91.4711 44.7573 145.04";
$strMapRanPosRecord[1010,43]="110.402 55.4636 151.418";
$strMapRanPosRecord[1010,44]="120.988 62.5322 151.992";
$strMapRanPosRecord[1010,45]="120.989 53.3936 151.602";
$strMapRanPosRecord[1010,46]="128.295 42.381 152.337";
$strMapRanPosRecord[1010,47]="133.642 28.0858 151.847";
$strMapRanPosRecord[1010,48]="137.762 15.7304 152.987";
$strMapRanPosRecord[1010,49]="135.052 2.06503 152.795";
$strMapRanPosRecord[1010,50]="128.741 -0.0390656 153.023";
$strMapRanPosRecord[1010,51]="107.729 0.370889 147.294";
$strMapRanPosRecord[1010,52]="105.518 19.6287 148.063";
$strMapRanPosRecord[1010,53]="101.302 26.6726 147.122";
$strMapRanPosRecord[1010,54]="116.766 -9.73193 148.938";
$strMapRanPosRecord[1010,55]="128.254 -9.02511 149.665";
$strMapRanPosRecord[1010,56]="140.672 -20.4287 149.754";
$strMapRanPosRecord[1010,57]="146.97 -28.8272 147.738";
$strMapRanPosRecord[1010,58]="158.562 -32.1675 149.131";
$strMapRanPosRecord[1010,59]="160.364 -44.3393 147.195";
$strMapRanPosRecord[1010,60]="148.112 -46.2762 145.423";
$strMapRanPosRecord[1010,61]="150.52 -52.0757 145.122";
$strMapRanPosRecord[1010,62]="142.844 -55.5658 144.951";
$strMapRanPosRecord[1010,63]="-6.27064 44.9648 132.595";
$strMapRanPosRecord[1010,64]="-2.05647 33.0639 126.499";
$strMapRanPosRecord[1010,65]="2.85123 25.2879 126.125";
$strMapRanPosRecord[1010,66]="-9.79142 25.2673 126.125";
$strMapRanPosRecord[1010,67]="-15.4168 17.5337 126.125";
$strMapRanPosRecord[1010,68]="-19.6353 12.6119 126.125";
$strMapRanPosRecord[1010,69]="-11.9019 4.8773 126.125";
$strMapRanPosRecord[1010,70]="-1.34857 1.15222 126.125";
$strMapRanPosRecord[1010,71]="6.29579 5.51471 126.125";
$strMapRanPosRecord[1010,72]="13.3379 9.71697 126.125";
$strMapRanPosRecord[1010,73]="12.7191 17.4594 126.125";
$strMapRanPosRecord[1010,74]="7.73065 6.26237 126.125";
$strMapRanPosRecord[1010,75]="13.5011 -12.0721 126.125";
$strMapRanPosRecord[1010,76]="16.2235 -27.4664 126.125";
$strMapRanPosRecord[1010,77]="22.5424 -31.6634 124.722";
$strMapRanPosRecord[1010,78]="15.8561 -37.3384 119.678";
$strMapRanPosRecord[1010,79]="17.7847 -47.6905 119.561";
$strMapRanPosRecord[1010,80]="4.18118 -56.9143 109.012";
$strMapRanPosRecord[1010,81]="-7.6661 -51.3809 110.623";
$strMapRanPosRecord[1010,82]="-14.7057 -57.6938 108.657";
$strMapRanPosRecord[1010,83]="-8.43976 -63.2782 106.609";
$strMapRanPosRecord[1010,84]="-4.70958 -49.8155 111.048";
$strMapRanPosRecord[1010,85]="-2.76997 -40.8716 115.227";
$strMapRanPosRecord[1010,86]="-11.1783 -38.0164 118.381";
$strMapRanPosRecord[1010,87]="-16.8232 -45.7477 119.57";
$strMapRanPosRecord[1010,88]="-22.3762 -47.1364 119.57";
$strMapRanPosRecord[1010,89]="-28.7764 -44.3419 119.57";
$strMapRanPosRecord[1010,90]="-26.6354 -35.2343 121.847";
$strMapRanPosRecord[1010,91]="-27.3702 -26.7637 126.117";
$strMapRanPosRecord[1010,92]="-25.9641 -20.4361 126.117";
$strMapRanPosRecord[1010,93]="-20.3395 -18.3264 126.117";
$strMapRanPosRecord[1010,94]="-18.9328 -5.6706 126.125";
$strMapRanPosRecord[1010,95]="-14.0001 9.99915 126.125";
$strMapRanPosRecord[1010,96]="-29.9947 17.4719 124.323";
$strMapRanPosRecord[1010,97]="-38.8753 12.3561 122.854";
$strMapRanPosRecord[1010,98]="-45.6081 14.7055 119.989";
$strMapRanPosRecord[1010,99]="-54.792 16.83 119.809";
$strMapRanPosRecord[1010,100]="-55.4974 24.5605 118.263";
$strMapRanPosRecord[1010,101]="-66.6723 20.373 118.646";
$strMapRanPosRecord[1010,102]="-67.4483 26.6732 118.789";
$strMapRanPosRecord[1010,103]="-63.3041 32.1994 118.483";
$strMapRanPosRecord[1010,104]="-58.6773 41.9836 119.943";
$strMapRanPosRecord[1010,105]="-64.622 42.8436 118.965";
$strMapRanPosRecord[1010,106]="-65.338 50.5694 119.779";
$strMapRanPosRecord[1010,107]="-71.6669 49.1744 119.404";
$strMapRanPosRecord[1010,108]="-70.9641 54.095 119.536";
$strMapRanPosRecord[1010,109]="-80.7182 54.8468 120.138";
$strMapRanPosRecord[1010,110]="-78.6995 62.5289 120.525";
$strMapRanPosRecord[1010,111]="-85.026 56.2055 120.244";
$strMapRanPosRecord[1010,112]="-83.6204 44.253 123.234";
$strMapRanPosRecord[1010,113]="-92.7605 54.0952 120.547";
$strMapRanPosRecord[1010,114]="-84.9312 58.0105 120.185";
$strMapRanPosRecord[1010,115]="-84.3232 69.563 120.68";
$strMapRanPosRecord[1010,116]="-83.6268 76.53 120.924";
$strMapRanPosRecord[1010,117]="-80.8078 84.3298 120.964";
$strMapRanPosRecord[1010,118]="-83.596 91.9978 120.157";
$strMapRanPosRecord[1010,119]="-73.0771 107.532 121.209";
$strMapRanPosRecord[1010,120]="-75.1533 104.76 120.858";
$strMapRanPosRecord[1010,121]="-85.6931 99.8158 120.079";
$strMapRanPosRecord[1010,122]="-92.162 89.5034 120.093";
$strMapRanPosRecord[1010,123]="-93.3062 75.7724 120";
$strMapRanPosRecord[1010,124]="-94.3909 67.9728 120.199";
$strMapRanPosRecord[1010,125]="-104.008 66.0484 120";
$strMapRanPosRecord[1010,126]="-113.151 62.5335 120.442";
$strMapRanPosRecord[1010,127]="-105.483 81.7644 120.879";
$strMapRanPosRecord[1010,128]="-111.041 79.4092 120.695";
$strMapRanPosRecord[1010,129]="-114.557 73.0818 120.637";
$strMapRanPosRecord[1010,130]="-117.775 60.2111 120.519";
$strMapRanPosRecord[1010,131]="-129.382 61.41 120.03";
$strMapRanPosRecord[1010,132]="-140.812 65.2405 120.297";
$strMapRanPosRecord[1010,133]="-156.315 74.7768 121.9";
$strMapRanPosRecord[1010,134]="-160.489 87.0853 126.358";
$strMapRanPosRecord[1010,135]="-151.842 89.2576 130.22";
$strMapRanPosRecord[1010,136]="-146.904 97.6847 130.507";
$strMapRanPosRecord[1010,137]="-138.464 90.6584 130";
$strMapRanPosRecord[1010,138]="-141.276 81.5182 130.367";
$strMapRanPosRecord[1010,139]="-130.887 88.6264 130.181";
$strMapRanPosRecord[1010,140]="-128.451 99.1992 130";
$strMapRanPosRecord[1010,141]="-121.59 107.532 130.035";
$strMapRanPosRecord[1010,142]="-115.262 113.157 130.408";
$strMapRanPosRecord[1010,143]="-116.705 104.494 130.397";
$strMapRanPosRecord[1010,144]="-123.059 89.9998 130.469";
$strMapRanPosRecord[1010,145]="-162.369 30.8858 122.017";
$strMapRanPosRecord[1010,146]="-171.51 27.3771 122.422";
$strMapRanPosRecord[1010,147]="-170.105 19.6425 122";
$strMapRanPosRecord[1010,148]="-176.432 12.6118 122.027";
$strMapRanPosRecord[1010,149]="-161.667 16.1269 121.934";
$strMapRanPosRecord[1010,150]="-151.379 17.9425 121.897";
$strMapRanPosRecord[1010,151]="-139.216 19.6361 121.432";
$strMapRanPosRecord[1010,152]="-135.713 24.4792 121.62";
$strMapRanPosRecord[1010,153]="-127.918 14.7211 121.623";
$strMapRanPosRecord[1010,154]="-131.377 9.87629 121.91";
$strMapRanPosRecord[1010,155]="-140.026 11.7872 121.47";
$strMapRanPosRecord[1010,156]="-143.386 21.0481 121.604";
$strMapRanPosRecord[1010,157]="-118.777 8.39261 122.25";
$strMapRanPosRecord[1010,158]="-112.428 8.84603 122.576";
$strMapRanPosRecord[1010,159]="-139.86 5.59181 120.005";
$strMapRanPosRecord[1010,160]="-144.792 -2.13845 117.185";
$strMapRanPosRecord[1010,161]="-151.272 -7.96009 115.131";
$strMapRanPosRecord[1010,162]="-146.492 -13.2159 115.219";
$strMapRanPosRecord[1010,163]="-138.097 -7.32571 115.196";
$strMapRanPosRecord[1010,164]="-129.323 -2.85753 115.374";
$strMapRanPosRecord[1010,165]="-126.513 -9.1801 114.906";
$strMapRanPosRecord[1010,166]="-118.083 -11.6631 114.906";
$strMapRanPosRecord[1010,167]="-104.441 -15.5919 114.906";
$strMapRanPosRecord[1010,168]="-106.676 -21.3456 115.032";
$strMapRanPosRecord[1010,169]="-115.941 -31.6548 114.85";
$strMapRanPosRecord[1010,170]="-122.994 -41.5278 115.021";
$strMapRanPosRecord[1010,171]="-133.082 -35.2849 114.701";
$strMapRanPosRecord[1010,172]="-145.307 -20.7268 114.87";
$strMapRanPosRecord[1010,173]="-143.392 -30.9526 114.833";
$strMapRanPosRecord[1010,174]="-147.604 -44.3414 115";
$strMapRanPosRecord[1010,175]="-158.374 -39.5554 115";
$strMapRanPosRecord[1010,176]="-160.258 -52.0921 115";
$strMapRanPosRecord[1010,177]="-154.293 -57.2747 115";
$strMapRanPosRecord[1010,178]="-146.472 -63.5415 115";
$strMapRanPosRecord[1010,179]="-137.927 -62.2269 114.952";
$strMapRanPosRecord[1010,180]="-139.293 -74.9001 114.745";
$strMapRanPosRecord[1010,181]="-130.73 -69.6547 114.156";
$strMapRanPosRecord[1010,182]="-118.008 -66.0076 115.31";
$strMapRanPosRecord[1010,183]="-120.183 -54.1859 114.71";
$strMapRanPosRecord[1010,184]="-116.669 -74.5333 113.403";
$strMapRanPosRecord[1010,185]="-120.181 -76.6846 113.322";
$strMapRanPosRecord[1010,186]="-131.459 -88.5928 113.414";
$strMapRanPosRecord[1010,187]="-120.235 -94.2357 111.851";
$strMapRanPosRecord[1010,188]="-106.358 -96.2752 110.428";
$strMapRanPosRecord[1010,189]="-97.8728 -84.7531 111.054";
$strMapRanPosRecord[1010,190]="-79.2174 -85.495 109.493";
$strMapRanPosRecord[1010,191]="-64.8028 -95.8643 107.815";
$strMapRanPosRecord[1010,192]="-64.6144 -116.015 107.351";
$strMapRanPosRecord[1010,193]="-66.2301 -127.663 107.177";
$strMapRanPosRecord[1010,194]="-69.9553 -140.419 107.442";
$strMapRanPosRecord[1010,195]="-77.9462 -142.007 107.966";
$strMapRanPosRecord[1010,196]="-96.5692 -144.755 107.212";
$strMapRanPosRecord[1010,197]="-114.557 -145.592 107.617";
$strMapRanPosRecord[1010,198]="-122.476 -136.542 107.5";
$strMapRanPosRecord[1010,199]="-108.67 -128.896 107.847";
$strMapRanPosRecord[1010,200]="-97.6947 -140.05 107.646";
$strMapRanPosRecord[1010,201]="-91.7505 -130.007 108.433";
$strMapRanPosRecord[1010,202]="-79.5146 -113.466 108.735";
$strMapRanPosRecord[1010,203]="-99.088 -104.811 109.377";

$strMapRanPosRecordMax[1101] = 121;
$strMapRanPosRecord[1101,1]="159.885 52.9595 71.896";
$strMapRanPosRecord[1101,2]="141.138 31.0273 72.1626";
$strMapRanPosRecord[1101,3]="152.557 33.0399 72.6071";
$strMapRanPosRecord[1101,4]="127.027 51.1805 71.6608";
$strMapRanPosRecord[1101,5]="112.246 39.0877 72.1995";
$strMapRanPosRecord[1101,6]="114.932 17.5897 72.0345";
$strMapRanPosRecord[1101,7]="91.4177 22.9615 72.1239";
$strMapRanPosRecord[1101,8]="97.4637 10.8688 72.0999";
$strMapRanPosRecord[1101,9]="95.4485 -4.58412 72.5878";
$strMapRanPosRecord[1101,10]="102.167 -23.3972 73.2432";
$strMapRanPosRecord[1101,11]="116.948 -39.5217 72.7003";
$strMapRanPosRecord[1101,12]="114.263 -63.7053 73.799";
$strMapRanPosRecord[1101,13]="131.238 -60.4449 72.627";
$strMapRanPosRecord[1101,14]="129.714 -50.9447 72.3128";
$strMapRanPosRecord[1101,15]="91.2889 -21.2443 73.9049";
$strMapRanPosRecord[1101,16]="74.0343 -37.4228 82.8648";
$strMapRanPosRecord[1101,17]="80.6669 -52.9593 84.1178";
$strMapRanPosRecord[1101,18]="69.2464 -68.4115 82.682";
$strMapRanPosRecord[1101,19]="77.9788 -77.8183 82.3928";
$strMapRanPosRecord[1101,20]="66.5601 -96.6278 84.3004";
$strMapRanPosRecord[1101,21]="76.5983 -122.982 86.8813";
$strMapRanPosRecord[1101,22]="41.7006 -114.102 93.9837";
$strMapRanPosRecord[1101,23]="67.2296 -138.959 89.2445";
$strMapRanPosRecord[1101,24]="108.27 -124.232 91.3636";
$strMapRanPosRecord[1101,25]="126.354 -120.148 94.8525";
$strMapRanPosRecord[1101,26]="133.073 -147.022 95.2096";
$strMapRanPosRecord[1101,27]="158.602 -157.771 96.2409";
$strMapRanPosRecord[1101,28]="156.137 -120.134 96.3154";
$strMapRanPosRecord[1101,29]="170.698 -138.96 95.2723";
$strMapRanPosRecord[1101,30]="188.165 -122.165 98.3855";
$strMapRanPosRecord[1101,31]="206.979 -104.023 100";
$strMapRanPosRecord[1101,32]="217.729 -87.2262 100";
$strMapRanPosRecord[1101,33]="221.089 -70.4289 100";
$strMapRanPosRecord[1101,34]="217.068 -52.3352 100.683";
$strMapRanPosRecord[1101,35]="206.12 -59.3675 100.04";
$strMapRanPosRecord[1101,36]="194.215 -72.444 100";
$strMapRanPosRecord[1101,37]="179.434 -70.4287 100.007";
$strMapRanPosRecord[1101,38]="187.479 -48.3057 96.75";
$strMapRanPosRecord[1101,39]="176.163 -39.5912 98.0007";
$strMapRanPosRecord[1101,40]="179.433 -21.3829 97.8252";
$strMapRanPosRecord[1101,41]="170.708 -5.27361 96.1878";
$strMapRanPosRecord[1101,42]="178.089 19.6017 100.099";
$strMapRanPosRecord[1101,43]="200.26 49.1642 100.014";
$strMapRanPosRecord[1101,44]="198.246 35.0557 102.73";
$strMapRanPosRecord[1101,45]="38.2291 -49.5433 83.8753";
$strMapRanPosRecord[1101,46]="21.5634 -53.6236 80.7885";
$strMapRanPosRecord[1101,47]="35.7104 -31.5906 83.9138";
$strMapRanPosRecord[1101,48]="10.8032 -36.8325 80.6387";
$strMapRanPosRecord[1101,49]="15.4951 -55.6457 77.9776";
$strMapRanPosRecord[1101,50]="0.071785 -44.9247 76.7957";
$strMapRanPosRecord[1101,51]="-14.0662 -54.303 72.9981";
$strMapRanPosRecord[1101,52]="-6.67977 -64.3775 74.0678";
$strMapRanPosRecord[1101,53]="-25.4527 -73.7698 76.0853";
$strMapRanPosRecord[1101,54]="-45.7585 -70.5829 77.01";
$strMapRanPosRecord[1101,55]="-46.3338 -83.8166 76.5469";
$strMapRanPosRecord[1101,56]="-63.751 -93.2534 78.3451";
$strMapRanPosRecord[1101,57]="-69.8328 -125.519 85.0288";
$strMapRanPosRecord[1101,58]="-53.0369 -129.553 87.4677";
$strMapRanPosRecord[1101,59]="-46.347 -109.487 91.4166";
$strMapRanPosRecord[1101,60]="52.485 -28.8631 83.9309";
$strMapRanPosRecord[1101,61]="66.3624 -50.2775 83.0908";
$strMapRanPosRecord[1101,62]="79.9933 -36.8366 83.0425";
$strMapRanPosRecord[1101,63]="60.5994 -16.7702 76.8532";
$strMapRanPosRecord[1101,64]="52.4867 0.163562 72.9444";
$strMapRanPosRecord[1101,65]="59.8073 15.5421 72.8116";
$strMapRanPosRecord[1101,66]="77.3062 26.3202 72.3688";
$strMapRanPosRecord[1101,67]="44.386 22.2901 72.6371";
$strMapRanPosRecord[1101,68]="18.8548 14.2286 72.6308";
$strMapRanPosRecord[1101,69]="2.73027 27.6642 72.3928";
$strMapRanPosRecord[1101,70]="13.4063 45.747 72.0079";
$strMapRanPosRecord[1101,71]="40.9542 51.8534 71.9421";
$strMapRanPosRecord[1101,72]="65.8782 54.5393 72.6995";
$strMapRanPosRecord[1101,73]="34.9803 64.6177 71.9779";
$strMapRanPosRecord[1101,74]="60.4204 80.7608 72.299";
$strMapRanPosRecord[1101,75]="79.2972 74.7048 72.6336";
$strMapRanPosRecord[1101,76]="89.4008 66.6345 72.2039";
$strMapRanPosRecord[1101,77]="91.4171 84.1019 72.7785";
$strMapRanPosRecord[1101,78]="73.2773 92.1648 72.1875";
$strMapRanPosRecord[1101,79]="56.4799 100.228 72.0938";
$strMapRanPosRecord[1101,80]="44.3866 116.352 74.4401";
$strMapRanPosRecord[1101,81]="29.6047 96.1965 72.022";
$strMapRanPosRecord[1101,82]="23.5597 95.5247 72.2002";
$strMapRanPosRecord[1101,83]="42.3695 104.93 72.4156";
$strMapRanPosRecord[1101,84]="57.1025 108.949 72.363";
$strMapRanPosRecord[1101,85]="45.058 119.04 75.0224";
$strMapRanPosRecord[1101,86]="17.4765 95.3992 72.8253";
$strMapRanPosRecord[1101,87]="-1.30065 102.243 75.0041";
$strMapRanPosRecord[1101,88]="28.2592 121.726 74.2297";
$strMapRanPosRecord[1101,89]="18.855 137.18 75.4602";
$strMapRanPosRecord[1101,90]="41.2044 136.527 75.615";
$strMapRanPosRecord[1101,91]="65.6884 135.837 81.5944";
$strMapRanPosRecord[1101,92]="82.1061 117.19 85.6738";
$strMapRanPosRecord[1101,93]="96.114 127.768 87.7777";
$strMapRanPosRecord[1101,94]="107.911 110.085 87.5056";
$strMapRanPosRecord[1101,95]="117.62 84.7766 88.5009";
$strMapRanPosRecord[1101,96]="128.778 79.2796 89.0145";
$strMapRanPosRecord[1101,97]="13.8605 129.182 74.9438";
$strMapRanPosRecord[1101,98]="2.7534 105.009 74.2766";
$strMapRanPosRecord[1101,99]="-3.29059 127.675 78.9629";
$strMapRanPosRecord[1101,100]="-21.454 119.714 80.5858";
$strMapRanPosRecord[1101,101]="-19.4428 147.256 83.0686";
$strMapRanPosRecord[1101,102]="-37.1938 136.608 84.1247";
$strMapRanPosRecord[1101,103]="-52.3637 120.384 86.4055";
$strMapRanPosRecord[1101,104]="-71.1765 133.82 86.3058";
$strMapRanPosRecord[1101,105]="-89.9334 117.652 85.3789";
$strMapRanPosRecord[1101,106]="-80.5372 104.651 84.2924";
$strMapRanPosRecord[1101,107]="-94.692 97.5402 82.2443";
$strMapRanPosRecord[1101,108]="-89.3694 83.4986 78.9477";
$strMapRanPosRecord[1101,109]="-97.3765 66.6406 74.8102";
$strMapRanPosRecord[1101,110]="-89.9895 47.8224 72.7062";
$strMapRanPosRecord[1101,111]="-51.0365 59.1811 71.1261";
$strMapRanPosRecord[1101,112]="-42.3444 75.2602 72.3054";
$strMapRanPosRecord[1101,113]="-48.3321 94.1783 71.6558";
$strMapRanPosRecord[1101,114]="-71.1766 -7.94397 75.1453";
$strMapRanPosRecord[1101,115]="-84.3748 -19.4928 79.3181";
$strMapRanPosRecord[1101,116]="-122.901 -26.7576 84.4212";
$strMapRanPosRecord[1101,117]="-130.973 2.13345 89.0138";
$strMapRanPosRecord[1101,118]="-137.02 28.3365 89.4118";
$strMapRanPosRecord[1101,119]="-125.6 38.4141 89.3011";
$strMapRanPosRecord[1101,120]="-106.116 36.3994 88.6721";
$strMapRanPosRecord[1101,121]="-98.0494 24.3047 88.9672";

$strMapRanPosRecordMax[1102] = 75;
$strMapRanPosRecord[1102,1]="45.8911 -35.9497 132.848";
$strMapRanPosRecord[1102,2]="45.3452 -27.2 132.848";
$strMapRanPosRecord[1102,3]="36.0779 -49.005 132.848";
$strMapRanPosRecord[1102,4]="15.3629 -33.8327 132.848";
$strMapRanPosRecord[1102,5]="1.0486 -40.8716 130.988";
$strMapRanPosRecord[1102,6]="-16.8295 -44.066 131.56";
$strMapRanPosRecord[1102,7]="-15.9101 -57.2051 134.259";
$strMapRanPosRecord[1102,8]="-30.1224 -67.1209 134.26";
$strMapRanPosRecord[1102,9]="-38.3271 -53.9963 134.26";
$strMapRanPosRecord[1102,10]="-5.64456 -71.2291 137.291";
$strMapRanPosRecord[1102,11]="-21.3655 -86.2546 137.608";
$strMapRanPosRecord[1102,12]="-9.35189 -99.3696 140.187";
$strMapRanPosRecord[1102,13]="9.15418 -106.472 142.11";
$strMapRanPosRecord[1102,14]="20.735 -102.669 140.626";
$strMapRanPosRecord[1102,15]="30.3937 -84.4194 141.626";
$strMapRanPosRecord[1102,16]="41.6703 -84.1476 141.91";
$strMapRanPosRecord[1102,17]="59.2746 -91.6646 140.751";
$strMapRanPosRecord[1102,18]="76.792 -83.9553 139.297";
$strMapRanPosRecord[1102,19]="90.0171 -68.807 138.397";
$strMapRanPosRecord[1102,20]="82.7668 -60.4861 136.102";
$strMapRanPosRecord[1102,21]="80.6494 -49.7999 134.025";
$strMapRanPosRecord[1102,22]="68.8802 -49.6373 132.641";
$strMapRanPosRecord[1102,23]="66.7319 -37.0505 130.644";
$strMapRanPosRecord[1102,24]="110.671 -84.4309 140.274";
$strMapRanPosRecord[1102,25]="142.245 -84.8432 144.186";
$strMapRanPosRecord[1102,26]="126.878 -90.7521 144.069";
$strMapRanPosRecord[1102,27]="127.146 -103.018 145.617";
$strMapRanPosRecord[1102,28]="116.581 -111.028 147.336";
$strMapRanPosRecord[1102,29]="88.1125 -50.3652 135.85";
$strMapRanPosRecord[1102,30]="34.4078 32.9555 130.521";
$strMapRanPosRecord[1102,31]="25.684 30.2303 130.521";
$strMapRanPosRecord[1102,32]="54.7564 30.0536 127.676";
$strMapRanPosRecord[1102,33]="73.9877 18.9785 127.954";
$strMapRanPosRecord[1102,34]="92.6254 20.4949 127.719";
$strMapRanPosRecord[1102,35]="103.748 30.4741 127.504";
$strMapRanPosRecord[1102,36]="99.332 41.0154 127.631";
$strMapRanPosRecord[1102,37]="83.2364 51.4664 127.51";
$strMapRanPosRecord[1102,38]="71.8393 48.799 127.98";
$strMapRanPosRecord[1102,39]="108.56 52.3752 127.686";
$strMapRanPosRecord[1102,40]="98.9719 62.0951 127.727";
$strMapRanPosRecord[1102,41]="84.3306 59.7317 127.294";
$strMapRanPosRecord[1102,42]="67.5933 50.8757 127.667";
$strMapRanPosRecord[1102,43]="54.7127 38.6712 127.5";
$strMapRanPosRecord[1102,44]="78.6142 78.4525 123";
$strMapRanPosRecord[1102,45]="65.3506 73.5206 123";
$strMapRanPosRecord[1102,46]="47.6197 67.7184 123";
$strMapRanPosRecord[1102,47]="31.6737 84.3619 123.156";
$strMapRanPosRecord[1102,48]="35.0874 98.8164 122.884";
$strMapRanPosRecord[1102,49]="33.9185 108.064 123.092";
$strMapRanPosRecord[1102,50]="43.7308 114.85 123";
$strMapRanPosRecord[1102,51]="52.9778 120.564 123";
$strMapRanPosRecord[1102,52]="25.6581 106.238 123.162";
$strMapRanPosRecord[1102,53]="9.3159 103.938 123";
$strMapRanPosRecord[1102,54]="-6.02606 93.5798 122.568";
$strMapRanPosRecord[1102,55]="-3.67261 79.5932 122.845";
$strMapRanPosRecord[1102,56]="-2.05104 66.6607 123";
$strMapRanPosRecord[1102,57]="-20.2538 56.9857 119.015";
$strMapRanPosRecord[1102,58]="-32.0941 59.0426 119.099";
$strMapRanPosRecord[1102,59]="-25.2018 45.5346 119.019";
$strMapRanPosRecord[1102,60]="-41.8134 34.5584 118.734";
$strMapRanPosRecord[1102,61]="-53.6188 16.7448 118.924";
$strMapRanPosRecord[1102,62]="-62.2104 8.19816 119.004";
$strMapRanPosRecord[1102,63]="-77.1535 -4.2369 120.259";
$strMapRanPosRecord[1102,64]="-81.7698 6.22025 120.259";
$strMapRanPosRecord[1102,65]="-73.4744 12.093 120.259";
$strMapRanPosRecord[1102,66]="-69.4471 19.3796 118.889";
$strMapRanPosRecord[1102,67]="-63.2484 25.1311 119.186";
$strMapRanPosRecord[1102,68]="-70.2144 30.2346 118.998";
$strMapRanPosRecord[1102,69]="-80.4987 36.6504 118.636";
$strMapRanPosRecord[1102,70]="-66.2231 53.7362 118.767";
$strMapRanPosRecord[1102,71]="-52.3942 53.1954 118.588";
$strMapRanPosRecord[1102,72]="-32.3112 44.9878 118.985";
$strMapRanPosRecord[1102,73]="-35.7752 95.1017 123.208";
$strMapRanPosRecord[1102,74]="-21.0355 99.3091 122.875";
$strMapRanPosRecord[1102,75]="-1.91687 98.4883 122.898";

$strMapRanPosRecordMax[1128] = 177;
$strMapRanPosRecord[1128,1]="7.13978 75.2352 100";
$strMapRanPosRecord[1128,2]="15.0269 74.6502 100";
$strMapRanPosRecord[1128,3]="27.3269 78.2505 100";
$strMapRanPosRecord[1128,4]="37.7386 77.4853 100";
$strMapRanPosRecord[1128,5]="48.0825 71.6074 100";
$strMapRanPosRecord[1128,6]="58.3123 73.2811 100";
$strMapRanPosRecord[1128,7]="55.2291 65.5724 100";
$strMapRanPosRecord[1128,8]="54.0154 51.7983 100";
$strMapRanPosRecord[1128,9]="46.9854 45.9384 100";
$strMapRanPosRecord[1128,10]="41.8076 41.6608 100";
$strMapRanPosRecord[1128,11]="30.9688 38.125 100";
$strMapRanPosRecord[1128,12]="23.2449 37.3526 100";
$strMapRanPosRecord[1128,13]="12.7632 40.3148 100.155";
$strMapRanPosRecord[1128,14]="13.0417 48.6253 100";
$strMapRanPosRecord[1128,15]="28.4599 58.1869 101.92";
$strMapRanPosRecord[1128,16]="61.0778 55.8419 100";
$strMapRanPosRecord[1128,17]="84.0931 54.5311 100";
$strMapRanPosRecord[1128,18]="94.1844 54.5313 100";
$strMapRanPosRecord[1128,19]="104.256 51.06 100";
$strMapRanPosRecord[1128,20]="108.703 37.7344 100";
$strMapRanPosRecord[1128,21]="104.406 28.3599 100";
$strMapRanPosRecord[1128,22]="98.1458 21.1831 100";
$strMapRanPosRecord[1128,23]="84.0864 19.5229 100";
$strMapRanPosRecord[1128,24]="74.7224 14.6921 100";
$strMapRanPosRecord[1128,25]="71.9596 6.91049 100";
$strMapRanPosRecord[1128,26]="80.0455 2.9099 100.245";
$strMapRanPosRecord[1128,27]="78.9984 -7.57947 100.328";
$strMapRanPosRecord[1128,28]="74.7199 -23.7672 100.005";
$strMapRanPosRecord[1128,29]="75.7097 -41.9339 101.262";
$strMapRanPosRecord[1128,30]="93.2973 -42.7961 100.303";
$strMapRanPosRecord[1128,31]="105.359 -48.0093 100.179";
$strMapRanPosRecord[1128,32]="117.298 -48.4925 100.037";
$strMapRanPosRecord[1128,33]="132.74 -43.0105 100.012";
$strMapRanPosRecord[1128,34]="139.016 -32.5992 100";
$strMapRanPosRecord[1128,35]="141.536 -21.1762 100";
$strMapRanPosRecord[1128,36]="142.107 -7.08296 100";
$strMapRanPosRecord[1128,37]="132.171 -2.10856 100.328";
$strMapRanPosRecord[1128,38]="139.241 5.71309 100";
$strMapRanPosRecord[1128,39]="128.702 13.7467 100";
$strMapRanPosRecord[1128,40]="117.392 5.09044 100.412";
$strMapRanPosRecord[1128,41]="123.137 -7.9838 100.488";
$strMapRanPosRecord[1128,42]="114.563 -25.5466 101.729";
$strMapRanPosRecord[1128,43]="106.754 -26.5494 102.363";
$strMapRanPosRecord[1128,44]="96.7992 -15.197 102.921";
$strMapRanPosRecord[1128,45]="95.1181 -7.4831 101.729";
$strMapRanPosRecord[1128,46]="106.359 -9.52546 103.412";
$strMapRanPosRecord[1128,47]="108.489 -14.6538 103.599";
$strMapRanPosRecord[1128,48]="107.487 -71.102 100";
$strMapRanPosRecord[1128,49]="107.813 -83.6391 100";
$strMapRanPosRecord[1128,50]="97.1747 -84.2803 100";
$strMapRanPosRecord[1128,51]="79.2536 -84.217 100";
$strMapRanPosRecord[1128,52]="64.9486 -84.8651 100";
$strMapRanPosRecord[1128,53]="55.5914 -78.7933 100";
$strMapRanPosRecord[1128,54]="47.8603 -68.343 100";
$strMapRanPosRecord[1128,55]="40.3444 -69.687 100";
$strMapRanPosRecord[1128,56]="29.813 -68.8617 100";
$strMapRanPosRecord[1128,57]="13.2597 -66.2225 100";
$strMapRanPosRecord[1128,58]="4.67724 -71.0459 100";
$strMapRanPosRecord[1128,59]="4.88142 -77.0533 100";
$strMapRanPosRecord[1128,60]="3.12486 -86.4068 100";
$strMapRanPosRecord[1128,61]="0.693334 -92.4796 100";
$strMapRanPosRecord[1128,62]="9.78047 -94.6039 100";
$strMapRanPosRecord[1128,63]="15.3441 -97.3962 100";
$strMapRanPosRecord[1128,64]="22.8988 -101.402 100";
$strMapRanPosRecord[1128,65]="27.4584 -93.9144 101.202";
$strMapRanPosRecord[1128,66]="34.483 -90.3913 101.202";
$strMapRanPosRecord[1128,67]="24.7835 -91.1981 101.202";
$strMapRanPosRecord[1128,68]="20.7873 -79.6534 101.202";
$strMapRanPosRecord[1128,69]="25.1891 -66.0045 100";
$strMapRanPosRecord[1128,70]="27.0757 -57.2435 100";
$strMapRanPosRecord[1128,71]="26.9394 -45.9236 100.033";
$strMapRanPosRecord[1128,72]="27.6834 -33.7367 100";
$strMapRanPosRecord[1128,73]="28.8762 -27.1469 100";
$strMapRanPosRecord[1128,74]="37.3028 -18.6324 100";
$strMapRanPosRecord[1128,75]="48.9469 -16.8374 100";
$strMapRanPosRecord[1128,76]="40.6219 -12.34 100";
$strMapRanPosRecord[1128,77]="29.7537 -3.45361 99.9623";
$strMapRanPosRecord[1128,78]="26.2814 19.3738 99.9785";
$strMapRanPosRecord[1128,79]="-78.0507 -64.4482 108.485";
$strMapRanPosRecord[1128,80]="-73.6297 -55.3243 108.485";
$strMapRanPosRecord[1128,81]="-83.218 -50.7816 108.485";
$strMapRanPosRecord[1128,82]="-76.3445 -44.9381 108.485";
$strMapRanPosRecord[1128,83]="-70.8437 -37.0313 108.482";
$strMapRanPosRecord[1128,84]="-76.6448 -27.4765 108.482";
$strMapRanPosRecord[1128,85]="-81.1418 -16.099 108.89";
$strMapRanPosRecord[1128,86]="-85.9683 -19.8434 108.483";
$strMapRanPosRecord[1128,87]="-74.9698 -17.7815 108.483";
$strMapRanPosRecord[1128,88]="-85.2811 -11.9375 108.483";
$strMapRanPosRecord[1128,89]="-77.3757 -9.18772 108.481";
$strMapRanPosRecord[1128,90]="-74.2817 -3.68822 108.481";
$strMapRanPosRecord[1128,91]="-71.5422 1.10579 108.481";
$strMapRanPosRecord[1128,92]="-63.6265 6.62399 108.274";
$strMapRanPosRecord[1128,93]="-56.4071 7.99986 108.013";
$strMapRanPosRecord[1128,94]="-52.9688 15.906 108";
$strMapRanPosRecord[1128,95]="-47.8127 21.4061 108";
$strMapRanPosRecord[1128,96]="-44.749 28.214 108";
$strMapRanPosRecord[1128,97]="-43.6877 37.5623 108";
$strMapRanPosRecord[1128,98]="-44.6524 46.5693 108";
$strMapRanPosRecord[1128,99]="-51.9369 49.5936 108";
$strMapRanPosRecord[1128,100]="-54.3328 43.7767 108";
$strMapRanPosRecord[1128,101]="-58.2818 53.5976 108";
$strMapRanPosRecord[1128,102]="-56.0649 58.4759 108.881";
$strMapRanPosRecord[1128,103]="-60.5196 63.6739 110.056";
$strMapRanPosRecord[1128,104]="-58.1635 80.8686 110.038";
$strMapRanPosRecord[1128,105]="-68.4005 47.2564 108";
$strMapRanPosRecord[1128,106]="-78.4049 52.3427 107.336";
$strMapRanPosRecord[1128,107]="-81.8377 57.1478 106.024";
$strMapRanPosRecord[1128,108]="-90.397 65.3674 104.119";
$strMapRanPosRecord[1128,109]="-89.0647 58.8858 104.887";
$strMapRanPosRecord[1128,110]="-84.9479 72.9333 104.257";
$strMapRanPosRecord[1128,111]="-84.1951 33.3256 108.179";
$strMapRanPosRecord[1128,112]="-85.9484 19.4576 108";
$strMapRanPosRecord[1128,113]="-91.4596 21.0596 108.379";
$strMapRanPosRecord[1128,114]="-74.2816 17.6251 108.06";
$strMapRanPosRecord[1128,115]="-64.8775 9.13143 108.256";
$strMapRanPosRecord[1128,116]="-56.751 8.6874 108.005";
$strMapRanPosRecord[1128,117]="-94.8849 -16.3982 109.009";
$strMapRanPosRecord[1128,118]="-106.192 -15.1851 112.261";
$strMapRanPosRecord[1128,119]="-108.653 -9.2083 112.261";
$strMapRanPosRecord[1128,120]="-116.906 -19.5 112.261";
$strMapRanPosRecord[1128,121]="-121.72 -7.82953 112.261";
$strMapRanPosRecord[1128,122]="-126.481 -15.9769 112.261";
$strMapRanPosRecord[1128,123]="-136.118 -15.7198 112.837";
$strMapRanPosRecord[1128,124]="-146.469 -17.4375 115.843";
$strMapRanPosRecord[1128,125]="-147.549 -32.0129 115.843";
$strMapRanPosRecord[1128,126]="-145.781 -44.5931 115.843";
$strMapRanPosRecord[1128,127]="-154.031 -44.25 115.843";
$strMapRanPosRecord[1128,128]="-164 -48.3749 115.843";
$strMapRanPosRecord[1128,129]="-174.268 -48.0328 115.843";
$strMapRanPosRecord[1128,130]="-184.568 -45.9801 115.843";
$strMapRanPosRecord[1128,131]="-180.907 -42.2524 115.843";
$strMapRanPosRecord[1128,132]="-169.157 -42.5312 115.843";
$strMapRanPosRecord[1128,133]="-168.125 -30.1559 119.446";
$strMapRanPosRecord[1128,134]="-172.907 -24.0074 119.446";
$strMapRanPosRecord[1128,135]="-177.406 -34.9679 119.446";
$strMapRanPosRecord[1128,136]="-186 -29.4687 119.446";
$strMapRanPosRecord[1128,137]="-187.718 -22.937 123.078";
$strMapRanPosRecord[1128,138]="-188.056 -17.8723 123.079";
$strMapRanPosRecord[1128,139]="-191.156 -9.87548 123.079";
$strMapRanPosRecord[1128,140]="-182.22 -11.5936 123.079";
$strMapRanPosRecord[1128,141]="-176.052 -16.3904 122.772";
$strMapRanPosRecord[1128,142]="-166.75 -16.0625 119.446";
$strMapRanPosRecord[1128,143]="-170.531 -8.50037 119.446";
$strMapRanPosRecord[1128,144]="-165.032 -6.09422 119.446";
$strMapRanPosRecord[1128,145]="-166.75 -1.62503 119.446";
$strMapRanPosRecord[1128,146]="-170.875 -2.65618 119.446";
$strMapRanPosRecord[1128,147]="-177.406 2.49903 119.446";
$strMapRanPosRecord[1128,148]="-179.793 -2.61433 119.446";
$strMapRanPosRecord[1128,149]="-184.969 0.781197 119.446";
$strMapRanPosRecord[1128,150]="-157.496 -17.4266 117.088";
$strMapRanPosRecord[1128,151]="-147.157 -14.6878 115.843";
$strMapRanPosRecord[1128,152]="-150.937 -7.46935 115.843";
$strMapRanPosRecord[1128,153]="-146.813 -3.68797 115.843";
$strMapRanPosRecord[1128,154]="-155.062 1.81216 115.843";
$strMapRanPosRecord[1128,155]="-150.297 7.94008 115.843";
$strMapRanPosRecord[1128,156]="-151.957 13.4603 115.843";
$strMapRanPosRecord[1128,157]="-157.469 12.1256 115.843";
$strMapRanPosRecord[1128,158]="-163.312 16.2499 115.843";
$strMapRanPosRecord[1128,159]="-165.031 11.4383 115.843";
$strMapRanPosRecord[1128,160]="-173.625 16.5935 115.843";
$strMapRanPosRecord[1128,161]="-180.119 12.492 115.843";
$strMapRanPosRecord[1128,162]="-187.375 17.281 115.843";
$strMapRanPosRecord[1128,163]="-185.656 11.4381 115.843";
$strMapRanPosRecord[1128,164]="-171.126 24.6938 113.042";
$strMapRanPosRecord[1128,165]="-171.223 37.1487 112.341";
$strMapRanPosRecord[1128,166]="-168.813 44.4372 112.341";
$strMapRanPosRecord[1128,167]="-163.313 43.7501 112.342";
$strMapRanPosRecord[1128,168]="-156.822 43.0011 112.342";
$strMapRanPosRecord[1128,169]="-146.695 44.5915 112.015";
$strMapRanPosRecord[1128,170]="-136.844 38.5944 112";
$strMapRanPosRecord[1128,171]="-131.311 35.4459 112.955";
$strMapRanPosRecord[1128,172]="-140.968 34.4688 112";
$strMapRanPosRecord[1128,173]="-154.375 34.125 112.101";
$strMapRanPosRecord[1128,174]="-165.719 36.1883 112";
$strMapRanPosRecord[1128,175]="-154.721 26.9106 112.42";
$strMapRanPosRecord[1128,176]="-144.407 25.1876 112.013";
$strMapRanPosRecord[1128,177]="-135.813 15.563 112.049";



$strMapRanPosRecordMax[1129] = 166;
$strMapRanPosRecord[1129,1]="115.68 -204.44 106.533";
$strMapRanPosRecord[1129,2]="118.079 -195.919 106.533";
$strMapRanPosRecord[1129,3]="115.386 -191.224 105.499";
$strMapRanPosRecord[1129,4]="115.78 -181.482 103.378";
$strMapRanPosRecord[1129,5]="113.831 -171.31 104.665";
$strMapRanPosRecord[1129,6]="117.727 -168.178 105.625";
$strMapRanPosRecord[1129,7]="119.297 -159.97 105.564";
$strMapRanPosRecord[1129,8]="111.95 -161.129 105.564";
$strMapRanPosRecord[1129,9]="105.235 -152.157 105.564";
$strMapRanPosRecord[1129,10]="100.157 -152.547 105.564";
$strMapRanPosRecord[1129,11]="99.3751 -148.641 105.564";
$strMapRanPosRecord[1129,12]="95.4693 -148.641 105.564";
$strMapRanPosRecord[1129,13]="91.1725 -153.718 105.564";
$strMapRanPosRecord[1129,14]="85.3238 -150.21 104.432";
$strMapRanPosRecord[1129,15]="83.3597 -152.937 104";
$strMapRanPosRecord[1129,16]="78.672 -151.766 104";
$strMapRanPosRecord[1129,17]="74.0216 -154.866 104";
$strMapRanPosRecord[1129,18]="75.1562 -149.031 104";
$strMapRanPosRecord[1129,19]="72.0318 -149.422 104";
$strMapRanPosRecord[1129,20]="68.1252 -141.219 104";
$strMapRanPosRecord[1129,21]="59.1407 -136.141 104";
$strMapRanPosRecord[1129,22]="64.9887 -125.614 104";
$strMapRanPosRecord[1129,23]="57.579 -120.516 104";
$strMapRanPosRecord[1129,24]="47.7695 -116.366 104";
$strMapRanPosRecord[1129,25]="36.1409 -118.963 104";
$strMapRanPosRecord[1129,26]="45.387 -129.02 104";
$strMapRanPosRecord[1129,27]="75.937 -116.219 104";
$strMapRanPosRecord[1129,28]="86.4537 -111.155 102.176";
$strMapRanPosRecord[1129,29]="97.681 -105.391 104.003";
$strMapRanPosRecord[1129,30]="98.0884 -94.5389 104.003";
$strMapRanPosRecord[1129,31]="108.658 -80.8143 104.003";
$strMapRanPosRecord[1129,32]="124.781 -83.45 104.003";
$strMapRanPosRecord[1129,33]="127.891 -95.5154 104.003";
$strMapRanPosRecord[1129,34]="125.535 -110.322 104.003";
$strMapRanPosRecord[1129,35]="118.845 -121.939 104.003";
$strMapRanPosRecord[1129,36]="115.063 -137.452 105.587";
$strMapRanPosRecord[1129,37]="115.871 -146.666 105.564";
$strMapRanPosRecord[1129,38]="126.328 -150.984 105.564";
$strMapRanPosRecord[1129,39]="139.158 -151.745 105.564";
$strMapRanPosRecord[1129,40]="152.5 -151.375 104";
$strMapRanPosRecord[1129,41]="158.727 -144.354 104";
$strMapRanPosRecord[1129,42]="169.885 -140.644 104";
$strMapRanPosRecord[1129,43]="182.002 -132.915 104";
$strMapRanPosRecord[1129,44]="183.757 -121.153 104";
$strMapRanPosRecord[1129,45]="170.558 -110.032 104";
$strMapRanPosRecord[1129,46]="165.782 -119.733 104";
$strMapRanPosRecord[1129,47]="160.199 -128.294 104";
$strMapRanPosRecord[1129,48]="117.737 -61.1461 103.993";
$strMapRanPosRecord[1129,49]="110.704 -57.6253 103.993";
$strMapRanPosRecord[1129,50]="111.483 -50.6086 105.553";
$strMapRanPosRecord[1129,51]="119.485 -41.8985 106";
$strMapRanPosRecord[1129,52]="113.944 -39.8244 106";
$strMapRanPosRecord[1129,53]="118.515 -29.8911 106";
$strMapRanPosRecord[1129,54]="109.923 -25.2038 106";
$strMapRanPosRecord[1129,55]="160.979 125.502 111.022";
$strMapRanPosRecord[1129,56]="148.207 133.591 110.708";
$strMapRanPosRecord[1129,57]="145.86 126.173 110.122";
$strMapRanPosRecord[1129,58]="153.281 121.484 111.022";
$strMapRanPosRecord[1129,59]="143.53 120.704 109.286";
$strMapRanPosRecord[1129,60]="138.831 130.072 107.857";
$strMapRanPosRecord[1129,61]="132.391 125.867 106.072";
$strMapRanPosRecord[1129,62]="126.328 130.468 105.937";
$strMapRanPosRecord[1129,63]="115.424 137.089 105.937";
$strMapRanPosRecord[1129,64]="119.294 147.259 107.011";
$strMapRanPosRecord[1129,65]="118.907 155.852 109.624";
$strMapRanPosRecord[1129,66]="115.002 174.208 111.022";
$strMapRanPosRecord[1129,67]="109.297 159.501 110.734";
$strMapRanPosRecord[1129,68]="99.7966 142.576 105.937";
$strMapRanPosRecord[1129,69]="94.7473 149.082 105.946";
$strMapRanPosRecord[1129,70]="91.5626 160.937 106.043";
$strMapRanPosRecord[1129,71]="84.5419 165.618 104.681";
$strMapRanPosRecord[1129,72]="75.9381 157.813 104.219";
$strMapRanPosRecord[1129,73]="81.0154 152.344 106.043";
$strMapRanPosRecord[1129,74]="68.1254 169.921 101";
$strMapRanPosRecord[1129,75]="70.5798 182.468 101";
$strMapRanPosRecord[1129,76]="62.416 195.798 101";
$strMapRanPosRecord[1129,77]="50.3031 197.447 101";
$strMapRanPosRecord[1129,78]="37.6568 182.423 101";
$strMapRanPosRecord[1129,79]="43.7126 173.497 101";
$strMapRanPosRecord[1129,80]="55.8152 169.644 101";
$strMapRanPosRecord[1129,81]="50.547 187.109 101";
$strMapRanPosRecord[1129,82]="90.0902 130.137 107.918";
$strMapRanPosRecord[1129,83]="77.55 129.349 111.022";
$strMapRanPosRecord[1129,84]="76.7187 121.094 111.022";
$strMapRanPosRecord[1129,85]="110.696 100.407 108.133";
$strMapRanPosRecord[1129,86]="120.076 97.6569 108.969";
$strMapRanPosRecord[1129,87]="115.782 78.517 111.037";
$strMapRanPosRecord[1129,88]="109.939 89.1697 111.037";
$strMapRanPosRecord[1129,89]="128.104 105.642 105.937";
$strMapRanPosRecord[1129,90]="137.656 110.156 105.937";
$strMapRanPosRecord[1129,91]="138.828 96.4845 106.043";
$strMapRanPosRecord[1129,92]="150.982 98.2717 106.043";
$strMapRanPosRecord[1129,93]="149.376 89.8473 104.138";
$strMapRanPosRecord[1129,94]="158.774 83.4528 101";
$strMapRanPosRecord[1129,95]="158.1 75.048 101";
$strMapRanPosRecord[1129,96]="162.759 57.2395 101";
$strMapRanPosRecord[1129,97]="177.844 46.9131 101";
$strMapRanPosRecord[1129,98]="187.53 53.7686 101";
$strMapRanPosRecord[1129,99]="195.468 63.2808 101";
$strMapRanPosRecord[1129,100]="189.307 69.8285 101";
$strMapRanPosRecord[1129,101]="180.817 79.8516 101";
$strMapRanPosRecord[1129,102]="173.483 75.1916 101";
$strMapRanPosRecord[1129,103]="179.037 64.7908 101";
$strMapRanPosRecord[1129,104]="-118.717 160.69 118";
$strMapRanPosRecord[1129,105]="-114.594 155.875 118";
$strMapRanPosRecord[1129,106]="-119.733 148.68 118";
$strMapRanPosRecord[1129,107]="-113.563 141.781 118";
$strMapRanPosRecord[1129,108]="-118.945 137.424 118";
$strMapRanPosRecord[1129,109]="-116.659 128.381 118.169";
$strMapRanPosRecord[1129,110]="-124.358 118.107 118.169";
$strMapRanPosRecord[1129,111]="-115.568 116.013 118.169";
$strMapRanPosRecord[1129,112]="-105.32 106.395 118.169";
$strMapRanPosRecord[1129,113]="-100.5 96.7499 118.169";
$strMapRanPosRecord[1129,114]="-115.065 96.088 118.169";
$strMapRanPosRecord[1129,115]="-117.344 85.4065 118.169";
$strMapRanPosRecord[1129,116]="-122.843 95.718 118.169";
$strMapRanPosRecord[1129,117]="-134.489 97.7739 118.169";
$strMapRanPosRecord[1129,118]="-117.344 104.312 118.169";
$strMapRanPosRecord[1129,119]="-117 130.78 118";
$strMapRanPosRecord[1129,120]="-118.437 145.154 118";
$strMapRanPosRecord[1129,121]="-138.388 123.917 120.122";
$strMapRanPosRecord[1129,122]="-145.872 121.158 121.827";
$strMapRanPosRecord[1129,123]="-148.853 133.401 123.372";
$strMapRanPosRecord[1129,124]="-156.187 126.657 123.372";
$strMapRanPosRecord[1129,125]="-160.799 137.32 122.554";
$strMapRanPosRecord[1129,126]="-170.323 137.027 122";
$strMapRanPosRecord[1129,127]="-188.154 139.718 122";
$strMapRanPosRecord[1129,128]="-191.937 149.687 122";
$strMapRanPosRecord[1129,129]="-185.612 157.419 122";
$strMapRanPosRecord[1129,130]="-173.031 161.719 122";
$strMapRanPosRecord[1129,131]="-162.987 157.534 122";
$strMapRanPosRecord[1129,132]="-162.031 148.314 122";
$strMapRanPosRecord[1129,133]="-177.842 150.375 122";
$strMapRanPosRecord[1129,134]="-94.0467 119.045 120.015";
$strMapRanPosRecord[1129,135]="-94.6553 125.615 121.297";
$strMapRanPosRecord[1129,136]="-89.98 132.305 123.365";
$strMapRanPosRecord[1129,137]="-82.9696 123.564 123.365";
$strMapRanPosRecord[1129,138]="-74.3878 135.582 122.745";
$strMapRanPosRecord[1129,139]="-72.3125 146.937 122";
$strMapRanPosRecord[1129,140]="-74.0311 155.875 122";
$strMapRanPosRecord[1129,141]="-61.4793 159.607 122";
$strMapRanPosRecord[1129,142]="-48.594 157.25 122";
$strMapRanPosRecord[1129,143]="-41.0811 148.03 122";
$strMapRanPosRecord[1129,144]="-42.0625 139.031 122";
$strMapRanPosRecord[1129,145]="-50.9996 134.219 122";
$strMapRanPosRecord[1129,146]="-57.9532 147.218 122";
$strMapRanPosRecord[1129,147]="-119.406 73.7199 116.203";
$strMapRanPosRecord[1129,148]="-114.944 65.1377 112.989";
$strMapRanPosRecord[1129,149]="-118.684 55.928 112";
$strMapRanPosRecord[1129,150]="-111.22 49.0275 112";
$strMapRanPosRecord[1129,151]="-122.484 41.76 112";
$strMapRanPosRecord[1129,152]="-122 -56.6877 110";
$strMapRanPosRecord[1129,153]="-113.067 -63.1565 110";
$strMapRanPosRecord[1129,154]="-120.439 -73.2493 110.051";
$strMapRanPosRecord[1129,155]="-117 -87.6247 108.073";
$strMapRanPosRecord[1129,156]="-123.511 -98.6742 108.083";
$strMapRanPosRecord[1129,157]="-133.824 -114.997 108.083";
$strMapRanPosRecord[1129,158]="-131.688 -131.687 108.083";
$strMapRanPosRecord[1129,159]="-121.96 -137.463 108.083";
$strMapRanPosRecord[1129,160]="-109.873 -136.148 108.083";
$strMapRanPosRecord[1129,161]="-101.063 -127.625 108.083";
$strMapRanPosRecord[1129,162]="-101.062 -115.813 108.083";
$strMapRanPosRecord[1129,163]="-106.497 -105.702 108.083";
$strMapRanPosRecord[1129,164]="-119.682 -110.801 108.083";
$strMapRanPosRecord[1129,165]="-112.313 -118.875 108.083";
$strMapRanPosRecord[1129,166]="-121.375 -126.687 108.083";


$strMapRanPosRecordMax[1118] = 80;
$strMapRanPosRecord[1118,1] = "-53.5937 -22.5781 75";
$strMapRanPosRecord[1118,2] = "-43.516 -21.4063 75";
$strMapRanPosRecord[1118,3] = "-34.8447 -22.578 75";
$strMapRanPosRecord[1118,4] = "-24.8794 -21.2194 75";
$strMapRanPosRecord[1118,5] = "-14.9223 -21.4062 75";
$strMapRanPosRecord[1118,6] = "-4.70277 -21.4063 75";
$strMapRanPosRecord[1118,7] = "5.46818 -19.297 75";
$strMapRanPosRecord[1118,8] = "15.077 -21.6403 75";
$strMapRanPosRecord[1118,9] = "25.859 -21.875 75";
$strMapRanPosRecord[1118,10] = "37.5781 -23.2812 75";
$strMapRanPosRecord[1118,11] = "37.5782 -15.5187 75";
$strMapRanPosRecord[1118,12] = "28.306 -11.3512 75";
$strMapRanPosRecord[1118,13] = "20.1038 -11.3281 75";
$strMapRanPosRecord[1118,14] = "9.6881 -10.3907 75";
$strMapRanPosRecord[1118,15] = "-0.386676 -11.3979 75.0121";
$strMapRanPosRecord[1118,16] = "-9.53046 -11.0938 75";
$strMapRanPosRecord[1118,17] = "-23.1444 -9.79735 75";
$strMapRanPosRecord[1118,18] = "-32.8405 -9.51309 75";
$strMapRanPosRecord[1118,19] = "-42.5407 -8.38597 75";
$strMapRanPosRecord[1118,20] = "-50.5466 -13.6716 75";
$strMapRanPosRecord[1118,21] = "-54.5303 -6.87659 75";
$strMapRanPosRecord[1118,22] = "-53.1251 4.14043 75";
$strMapRanPosRecord[1118,23] = "-43.646 5.46772 75";
$strMapRanPosRecord[1118,24] = "-34.226 5.6317 75";
$strMapRanPosRecord[1118,25] = "-20.4563 4.25365 75";
$strMapRanPosRecord[1118,26] = "-6.6902 4.0294 75";
$strMapRanPosRecord[1118,27] = "3.63862 4.52575 75";
$strMapRanPosRecord[1118,28] = "22.3434 5.07814 75";
$strMapRanPosRecord[1118,29] = "33.8267 6.95284 75";
$strMapRanPosRecord[1118,30] = "38.5151 14.6865 75";
$strMapRanPosRecord[1118,31] = "24.8953 21.4978 75";
$strMapRanPosRecord[1118,32] = "14.265 19.2037 75";
$strMapRanPosRecord[1118,33] = "0.49336 13.478 75";
$strMapRanPosRecord[1118,34] = "-9.49063 14.3212 75";
$strMapRanPosRecord[1118,35] = "-16.5014 16.0234 75";
$strMapRanPosRecord[1118,36] = "-25.4688 24.0625 75";
$strMapRanPosRecord[1118,37] = "-34.14 23.3594 75";
$strMapRanPosRecord[1118,38] = "-40.8527 21.6016 75";
$strMapRanPosRecord[1118,39] = "-50.8017 21.9173 75";
$strMapRanPosRecord[1118,40] = "-56.8652 33.3731 75";
$strMapRanPosRecord[1118,41] = "-45.3317 32.3037 75";
$strMapRanPosRecord[1118,42] = "-35.1399 29.9366 75";
$strMapRanPosRecord[1118,43] = "-25.7858 32.4775 75";
$strMapRanPosRecord[1118,44] = "-16.5448 35.4912 75";
$strMapRanPosRecord[1118,45] = "-6.95317 35.8804 75";
$strMapRanPosRecord[1118,46] = "8.9841 31.0939 75";
$strMapRanPosRecord[1118,47] = "17.2354 37.9359 75";
$strMapRanPosRecord[1118,48] = "25.9241 36.7231 75";
$strMapRanPosRecord[1118,49] = "37.8115 38.359 75";
$strMapRanPosRecord[1118,50] = "38.2777 46.4997 75";
$strMapRanPosRecord[1118,51] = "36.6409 54.5303 75";
$strMapRanPosRecord[1118,52] = "39.588 64.005 75";
$strMapRanPosRecord[1118,53] = "32.8916 73.5145 75";
$strMapRanPosRecord[1118,54] = "26.3287 67.6568 75";
$strMapRanPosRecord[1118,55] = "23.7937 60.3913 75";
$strMapRanPosRecord[1118,56] = "20.0003 48.4387 75";
$strMapRanPosRecord[1118,57] = "11.3842 43.1725 75";
$strMapRanPosRecord[1118,58] = "7.34372 48.5198 75";
$strMapRanPosRecord[1118,59] = "3.61503 61.4956 75";
$strMapRanPosRecord[1118,60] = "7.81213 69.5306 75";
$strMapRanPosRecord[1118,61] = "-1.79616 72.1092 75";
$strMapRanPosRecord[1118,62] = "-7.42159 63.9068 75";
$strMapRanPosRecord[1118,63] = "-6.95316 57.3439 75";
$strMapRanPosRecord[1118,64] = "-6.71873 47.5002 75";
$strMapRanPosRecord[1118,65] = "-14.6871 40.4691 75";
$strMapRanPosRecord[1118,66] = "-18.1755 49.3822 75";
$strMapRanPosRecord[1118,67] = "-17.875 57.879 75";
$strMapRanPosRecord[1118,68] = "-17.5 69.7648 75";
$strMapRanPosRecord[1118,69] = "-27.4097 72.6241 75";
$strMapRanPosRecord[1118,70] = "-34.8434 62.9695 75";
$strMapRanPosRecord[1118,71] = "-31.0944 56.6416 75";
$strMapRanPosRecord[1118,72] = "-28.047 48.6724 75";
$strMapRanPosRecord[1118,73] = "-32.6675 41.3557 75";
$strMapRanPosRecord[1118,74] = "-43.9837 44.9215 75";
$strMapRanPosRecord[1118,75] = "-54.2634 45.3098 75";
$strMapRanPosRecord[1118,76] = "-56.4063 54.2952 75";
$strMapRanPosRecord[1118,77] = "-47.027 56.0636 75";
$strMapRanPosRecord[1118,78] = "-50.7272 62.1531 75";
$strMapRanPosRecord[1118,79] = "-52.7363 72.0978 75";
$strMapRanPosRecord[1118,80] = "-41.9911 71.0569 75";


$strMapRanPosRecordMax[1119] = 215;
$strMapRanPosRecord[1119,1]="-47.7095 -174.75 114.531";
$strMapRanPosRecord[1119,2]="-32.0032 -165.602 115.3";
$strMapRanPosRecord[1119,3]="-22.7374 -162.706 116.293";
$strMapRanPosRecord[1119,4]="-34.48 -149.716 115.899";
$strMapRanPosRecord[1119,5]="-32.0004 -139.2 115.669";
$strMapRanPosRecord[1119,6]="-40 -159.198 115.356";
$strMapRanPosRecord[1119,7]="16.7881 -164.799 120";
$strMapRanPosRecord[1119,8]="16.8 -152.001 119.95";
$strMapRanPosRecord[1119,9]="29.544 -163.977 120";
$strMapRanPosRecord[1119,10]="43.1999 -167.2 120";
$strMapRanPosRecord[1119,11]="42.4001 -157.601 120";
$strMapRanPosRecord[1119,12]="51.1999 -172 120";
$strMapRanPosRecord[1119,13]="56.7991 -166.401 120";
$strMapRanPosRecord[1119,14]="65.5992 -164.8 120";
$strMapRanPosRecord[1119,15]="79.9992 -165.6 120";
$strMapRanPosRecord[1119,16]="87.1998 -176 120";
$strMapRanPosRecord[1119,17]="99.1986 -176.8 120";
$strMapRanPosRecord[1119,18]="115.858 -176.8 120";
$strMapRanPosRecord[1119,19]="124.8 -165.601 120";
$strMapRanPosRecord[1119,20]="113.6 -156.8 120";
$strMapRanPosRecord[1119,21]="100.001 -156 120";
$strMapRanPosRecord[1119,22]="134.399 -168 120";
$strMapRanPosRecord[1119,23]="147.176 -175.985 120";
$strMapRanPosRecord[1119,24]="153.601 -176.799 120";
$strMapRanPosRecord[1119,25]="166.32 -187.135 122.967";
$strMapRanPosRecord[1119,26]="160 -172 120";
$strMapRanPosRecord[1119,27]="169.6 -168 119.919";
$strMapRanPosRecord[1119,28]="164 -159.201 120.025";
$strMapRanPosRecord[1119,29]="157.6 -164 120";
$strMapRanPosRecord[1119,30]="153.616 -154.325 120";
$strMapRanPosRecord[1119,31]="159.999 -149.6 119.987";
$strMapRanPosRecord[1119,32]="160 -139.2 119.163";
$strMapRanPosRecord[1119,33]="166.667 -135.2 119.317";
$strMapRanPosRecord[1119,34]="161.601 -125.602 118.063";
$strMapRanPosRecord[1119,35]="169.628 -114.896 116.482";
$strMapRanPosRecord[1119,36]="164.801 -106.401 115.759";
$strMapRanPosRecord[1119,37]="171.143 -95.2991 114.969";
$strMapRanPosRecord[1119,38]="164.8 -82.4004 114.623";
$strMapRanPosRecord[1119,39]="172 -77.6001 114.673";
$strMapRanPosRecord[1119,40]="170.147 -65.2482 114.275";
$strMapRanPosRecord[1119,41]="180.262 -55.9137 119.363";
$strMapRanPosRecord[1119,42]="172.051 -47.2534 115.849";
$strMapRanPosRecord[1119,43]="180.187 -34.9383 117.175";
$strMapRanPosRecord[1119,44]="175.946 -26.3889 115.205";
$strMapRanPosRecord[1119,45]="182.607 -15.8968 114.951";
$strMapRanPosRecord[1119,46]="180.801 -2.4072 110.915";
$strMapRanPosRecord[1119,47]="186.578 9.15447 106.621";
$strMapRanPosRecord[1119,48]="193.744 16.2133 104.714";
$strMapRanPosRecord[1119,49]="186.685 25.2865 102.499";
$strMapRanPosRecord[1119,50]="194.396 30.3978 101.197";
$strMapRanPosRecord[1119,51]="192.922 37.4673 100.258";
$strMapRanPosRecord[1119,52]="182.611 46.2207 99.875";
$strMapRanPosRecord[1119,53]="187.199 55.9993 99.8937";
$strMapRanPosRecord[1119,54]="177.958 56.9242 99.8757";
$strMapRanPosRecord[1119,55]="177.711 67.633 99.6937";
$strMapRanPosRecord[1119,56]="170.4 75.1997 99.5625";
$strMapRanPosRecord[1119,57]="169.026 81.9593 99.3802";
$strMapRanPosRecord[1119,58]="168.929 87.9991 99.4777";
$strMapRanPosRecord[1119,59]="155.427 93.6373 98.1875";
$strMapRanPosRecord[1119,60]="154.4 104 98.225";
$strMapRanPosRecord[1119,61]="142.193 101.966 98.0625";
$strMapRanPosRecord[1119,62]="147.179 109.577 98.1364";
$strMapRanPosRecord[1119,63]="144.086 123.61 98.3438";
$strMapRanPosRecord[1119,64]="141.452 134.702 98.4461";
$strMapRanPosRecord[1119,65]="147.952 139.209 98.7256";
$strMapRanPosRecord[1119,66]="132.383 142.564 98.8253";
$strMapRanPosRecord[1119,67]="114.4 148.8 98.975";
$strMapRanPosRecord[1119,68]="102.4 146.4 99.2437";
$strMapRanPosRecord[1119,69]="91.2133 151.194 100.427";
$strMapRanPosRecord[1119,70]="84.1246 152.771 101.15";
$strMapRanPosRecord[1119,71]="82.0467 142.175 99.565";
$strMapRanPosRecord[1119,72]="79.0914 126.05 99.7579";
$strMapRanPosRecord[1119,73]="85.9207 112.914 102.745";
$strMapRanPosRecord[1119,74]="135.999 109.6 98.0625";
$strMapRanPosRecord[1119,75]="75.2006 102.402 100.387";
$strMapRanPosRecord[1119,76]="74.7297 86.8868 101.472";
$strMapRanPosRecord[1119,77]="65.5175 69.2267 101.618";
$strMapRanPosRecord[1119,78]="49.2835 56.3629 100.345";
$strMapRanPosRecord[1119,79]="49.8288 39.9922 98.6472";
$strMapRanPosRecord[1119,80]="50.4003 20.0181 99.4574";
$strMapRanPosRecord[1119,81]="41.2581 21.3788 99.8695";
$strMapRanPosRecord[1119,82]="24.0976 11.3052 99.8831";
$strMapRanPosRecord[1119,83]="13.0495 10.654 98.6421";
$strMapRanPosRecord[1119,84]="8.59501 -17.4447 102.412";
$strMapRanPosRecord[1119,85]="-1.61801 -14.2628 101.537";
$strMapRanPosRecord[1119,86]="-1.93619 -24.1127 103.573";
$strMapRanPosRecord[1119,87]="-5.66623 -37.4193 102.707";
$strMapRanPosRecord[1119,88]="10.4935 -56.6257 99.0483";
$strMapRanPosRecord[1119,89]="23.1092 -67.9104 101.95";
$strMapRanPosRecord[1119,90]="6.40025 -88.7996 105";
$strMapRanPosRecord[1119,91]="27.3135 -89.2618 108.543";
$strMapRanPosRecord[1119,92]="51.9996 -107.2 111.006";
$strMapRanPosRecord[1119,93]="-30.3839 -102.384 111.857";
$strMapRanPosRecord[1119,94]="-16.801 -105.6 106.925";
$strMapRanPosRecord[1119,95]="-15.7666 -95.2642 104.594";
$strMapRanPosRecord[1119,96]="-23.9995 -62.4015 102.556";
$strMapRanPosRecord[1119,97]="-14.3796 -59.8688 100.624";
$strMapRanPosRecord[1119,98]="-13.5791 1.5486 99.7361";
$strMapRanPosRecord[1119,99]="-29.5977 15.9991 100.881";
$strMapRanPosRecord[1119,100]="-34.3998 27.9995 102.313";
$strMapRanPosRecord[1119,101]="-50.399 32.7997 99.9313";
$strMapRanPosRecord[1119,102]="-60.4918 20.0171 97.3519";
$strMapRanPosRecord[1119,103]="-54.3526 46.1246 100.281";
$strMapRanPosRecord[1119,104]="-52.8001 57.5989 100";
$strMapRanPosRecord[1119,105]="-38.4004 61.5996 100";
$strMapRanPosRecord[1119,106]="-30.474 55.2593 99.9169";
$strMapRanPosRecord[1119,107]="-30.4125 36.0145 99.1594";
$strMapRanPosRecord[1119,108]="-16.077 41.5487 98.6087";
$strMapRanPosRecord[1119,109]="-6.6161 29.314 98.652";
$strMapRanPosRecord[1119,110]="8.27707 37.0201 98.652";
$strMapRanPosRecord[1119,111]="25.5996 33.6001 98.6669";
$strMapRanPosRecord[1119,112]="39.1982 36.7995 98.6669";
$strMapRanPosRecord[1119,113]="31.2009 43.2 98.6669";
$strMapRanPosRecord[1119,114]="18.5228 48.1938 99.6931";
$strMapRanPosRecord[1119,115]="4.62519 65.0941 100.187";
$strMapRanPosRecord[1119,116]="25.0846 89.1511 100.187";
$strMapRanPosRecord[1119,117]="43.9995 86.4001 100.151";
$strMapRanPosRecord[1119,118]="48.0001 107.2 100.152";
$strMapRanPosRecord[1119,119]="47.3992 121.024 100.152";
$strMapRanPosRecord[1119,120]="48.7119 137.695 100.144";
$strMapRanPosRecord[1119,121]="38.4011 151.999 100.2";
$strMapRanPosRecord[1119,122]="44.7875 167.681 100.2";
$strMapRanPosRecord[1119,123]="43.0196 178.482 100.2";
$strMapRanPosRecord[1119,124]="47.369 193.789 100.019";
$strMapRanPosRecord[1119,125]="31.7153 193.225 100.2";
$strMapRanPosRecord[1119,126]="19.5102 179.437 102.299";
$strMapRanPosRecord[1119,127]="7.03546 168.466 102.299";
$strMapRanPosRecord[1119,128]="-4.79898 153.601 100.176";
$strMapRanPosRecord[1119,129]="-15.1992 171.199 102.299";
$strMapRanPosRecord[1119,130]="-17.8326 185.416 102.299";
$strMapRanPosRecord[1119,131]="-8.80021 200.8 102.299";
$strMapRanPosRecord[1119,132]="6.20615 202.757 102.299";
$strMapRanPosRecord[1119,133]="-41.5987 190.4 100.209";
$strMapRanPosRecord[1119,134]="-38.4004 180.001 100.2";
$strMapRanPosRecord[1119,135]="-40 168.8 100.2";
$strMapRanPosRecord[1119,136]="-31.2004 160.001 100.2";
$strMapRanPosRecord[1119,137]="-44.7943 154.402 100.2";
$strMapRanPosRecord[1119,138]="-41.734 140.604 100.225";
$strMapRanPosRecord[1119,139]="-51.9027 128.051 100.058";
$strMapRanPosRecord[1119,140]="-44.0002 116 100.131";
$strMapRanPosRecord[1119,141]="-47.1999 105.6 100.131";
$strMapRanPosRecord[1119,142]="-43.9998 89.6008 100.131";
$strMapRanPosRecord[1119,143]="-33.6007 93.5997 100.187";
$strMapRanPosRecord[1119,144]="-32.0001 85.6006 100.187";
$strMapRanPosRecord[1119,145]="-16.8 96 100.187";
$strMapRanPosRecord[1119,146]="-4.80036 93.6 100.187";
$strMapRanPosRecord[1119,147]="10.4666 92.146 100.187";
$strMapRanPosRecord[1119,148]="14.62 103.167 100.187";
$strMapRanPosRecord[1119,149]="0.000143811 107.2 100.215";
$strMapRanPosRecord[1119,150]="-13.5992 112.8 100.048";
$strMapRanPosRecord[1119,151]="-27.1204 116.777 100.042";
$strMapRanPosRecord[1119,152]="24.1725 116.798 100.163";
$strMapRanPosRecord[1119,153]="3.20039 124 100.215";
$strMapRanPosRecord[1119,154]="-7.19938 141.599 100.225";
$strMapRanPosRecord[1119,155]="-56.7999 142.689 100.223";
$strMapRanPosRecord[1119,156]="-72.8001 140 100";
$strMapRanPosRecord[1119,157]="-68.4516 118.933 100";
$strMapRanPosRecord[1119,158]="-65.066 103.461 100.033";
$strMapRanPosRecord[1119,159]="-70.2339 83.5504 100.058";
$strMapRanPosRecord[1119,160]="-83.9999 156 100";
$strMapRanPosRecord[1119,161]="-103.199 158.4 100";
$strMapRanPosRecord[1119,162]="-113.6 172 100";
$strMapRanPosRecord[1119,163]="-124.774 188.761 103.606";
$strMapRanPosRecord[1119,164]="-136.773 180.042 102.811";
$strMapRanPosRecord[1119,165]="-151.199 181.6 100.525";
$strMapRanPosRecord[1119,166]="-134.304 164.704 101.971";
$strMapRanPosRecord[1119,167]="-120.8 145.6 100";
$strMapRanPosRecord[1119,168]="-105.601 143.2 100";
$strMapRanPosRecord[1119,169]="-104.794 134.415 101.618";
$strMapRanPosRecord[1119,170]="-89.12 124.424 101.17";
$strMapRanPosRecord[1119,171]="-104.713 112.788 106.678";
$strMapRanPosRecord[1119,172]="-99.1723 99.4579 109.493";
$strMapRanPosRecord[1119,173]="-101.659 80.0407 113.142";
$strMapRanPosRecord[1119,174]="-116.737 86.3636 111.509";
$strMapRanPosRecord[1119,175]="-120.502 67.8694 111.486";
$strMapRanPosRecord[1119,176]="-127.113 63.2603 111.209";
$strMapRanPosRecord[1119,177]="-144.799 58.4003 110.956";
$strMapRanPosRecord[1119,178]="-153.591 64.7934 112.4";
$strMapRanPosRecord[1119,179]="-164.74 66.3915 112.15";
$strMapRanPosRecord[1119,180]="-171.997 75.9965 112.063";
$strMapRanPosRecord[1119,181]="-183.199 75.2001 112.114";
$strMapRanPosRecord[1119,182]="-182.4 83.9998 112.063";
$strMapRanPosRecord[1119,183]="-191.2 88 112.144";
$strMapRanPosRecord[1119,184]="-188 93.5998 112.125";
$strMapRanPosRecord[1119,185]="-199.199 91.2003 112.41";
$strMapRanPosRecord[1119,186]="-196 99.1999 112.144";
$strMapRanPosRecord[1119,187]="-188.801 104.8 112.104";
$strMapRanPosRecord[1119,188]="-189.6 113.6 111.933";
$strMapRanPosRecord[1119,189]="-180.805 115.199 109.995";
$strMapRanPosRecord[1119,190]="-179.2 124.799 108.354";
$strMapRanPosRecord[1119,191]="-165.597 127.823 104.268";
$strMapRanPosRecord[1119,192]="-158.887 135.004 102.232";
$strMapRanPosRecord[1119,193]="-145.378 137.22 100.46";
$strMapRanPosRecord[1119,194]="-141.6 150.296 101.648";
$strMapRanPosRecord[1119,195]="-132.8 141.6 100";
$strMapRanPosRecord[1119,196]="-140 19.2014 109.629";
$strMapRanPosRecord[1119,197]="-132.007 10.4081 109.368";
$strMapRanPosRecord[1119,198]="-141.6 -4.79939 109.887";
$strMapRanPosRecord[1119,199]="-132.174 -14.9512 110.714";
$strMapRanPosRecord[1119,200]="-133.221 -29.4035 112.232";
$strMapRanPosRecord[1119,201]="-138.4 -49.5991 113.365";
$strMapRanPosRecord[1119,202]="-140 -72.7944 110.901";
$strMapRanPosRecord[1119,203]="-129.658 -72.8 110.257";
$strMapRanPosRecord[1119,204]="-135.199 -87.1965 110.809";
$strMapRanPosRecord[1119,205]="-120 -89.6002 108.362";
$strMapRanPosRecord[1119,206]="-129.251 -101.572 108.123";
$strMapRanPosRecord[1119,207]="-124.001 -108.8 107.875";
$strMapRanPosRecord[1119,208]="-127.999 -117.599 108.25";
$strMapRanPosRecord[1119,209]="-116.801 -126.4 108.037";
$strMapRanPosRecord[1119,210]="-128.97 -128.962 108.53";
$strMapRanPosRecord[1119,211]="-118.529 -139.863 108.346";
$strMapRanPosRecord[1119,212]="-99.93 -134.069 110.45";
$strMapRanPosRecord[1119,213]="-110.868 -122.655 108.194";
$strMapRanPosRecord[1119,214]="-88.2956 -140.132 114.874";
$strMapRanPosRecord[1119,215]="-68.9272 -150.516 117.999";


$strMapRanPosRecordMax[1305] = 38;
$strMapRanPosRecord[1305,1]="-11.2488 54.8432 109.832";
$strMapRanPosRecord[1305,2]="-1.40625 70.3125 110";
$strMapRanPosRecord[1305,3]="2.10932 87.8903 110";
$strMapRanPosRecord[1305,4]="-33.6656 82.2789 107.207";
$strMapRanPosRecord[1305,5]="-53.4367 68.9069 101.938";
$strMapRanPosRecord[1305,6]="54.8204 66.8333 101.256";
$strMapRanPosRecord[1305,7]="57.8035 41.9104 99.875";
$strMapRanPosRecord[1305,8]="57.0948 8.82402 99.2922";
$strMapRanPosRecord[1305,9]="58.3529 -18.2288 99.8629";
$strMapRanPosRecord[1305,10]="63.0099 -42.8621 99.826";
$strMapRanPosRecord[1305,11]="56.9535 -69.6076 101.671";
$strMapRanPosRecord[1305,12]="50.6262 -89.2931 105.164";
$strMapRanPosRecord[1305,13]="30.9411 -78.7519 106.372";
$strMapRanPosRecord[1305,14]="9.1997 -73.1402 109.981";
$strMapRanPosRecord[1305,15]="-9.14029 -78.0468 109.934";
$strMapRanPosRecord[1305,16]="-32.7196 -80.1432 104.904";
$strMapRanPosRecord[1305,17]="-10.5787 -55.4615 109.702";
$strMapRanPosRecord[1305,18]="13.0341 -56.1015 109.736";
$strMapRanPosRecord[1305,19]="-46.872 -68.6691 100.622";
$strMapRanPosRecord[1305,20]="-59.0203 -35.4028 100";
$strMapRanPosRecord[1305,21]="-58.3594 -11.9542 99.4071";
$strMapRanPosRecord[1305,22]="-59.0473 10.0607 99.3376";
$strMapRanPosRecord[1305,23]="-61.1718 29.531 100.271";
$strMapRanPosRecord[1305,24]="-60.4688 45.7024 100";
$strMapRanPosRecord[1305,25]="-47.1097 54.1404 100.868";
$strMapRanPosRecord[1305,26]="-55.5459 73.1229 102.645";
$strMapRanPosRecord[1305,27]="-47.8135 87.1825 105.307";
$strMapRanPosRecord[1305,28]="-36.5701 105.456 110.751";
$strMapRanPosRecord[1305,29]="-6.32832 37.9693 108.722";
$strMapRanPosRecord[1305,30]="10.5459 37.9686 108.666";
$strMapRanPosRecord[1305,31]="-4.13973 26.9536 108.08";
$strMapRanPosRecord[1305,32]="9.84366 23.9063 108";
$strMapRanPosRecord[1305,33]="2.10964 10.5473 107.625";
$strMapRanPosRecord[1305,34]="-5.56493 -1.31344 107.75";
$strMapRanPosRecord[1305,35]="11.1733 -15.4042 107.673";
$strMapRanPosRecord[1305,36]="-4.13891 -31.5564 108.445";
$strMapRanPosRecord[1305,37]="10.489 -34.8288 108.713";
$strMapRanPosRecord[1305,38]="2.45918 3.42361 107.618";


$strMapRanPosRecordMax[1318] = 160;
$strMapRanPosRecord[1318, 1] ="75.2384 1.19711 107.421";
$strMapRanPosRecord[1318, 2] ="-72.9323 6.04902 107.421";
$strMapRanPosRecord[1318, 3] ="-70.1189 9.60714 107.421";
$strMapRanPosRecord[1318, 4] ="-66.5495 11.9186 107.421";
$strMapRanPosRecord[1318, 5] ="-66.285 15.9059 107.421 ";
$strMapRanPosRecord[1318, 6] ="-62.7608 17.7497 107.421";
$strMapRanPosRecord[1318, 7] ="-62.3567 22.3219 107.421";
$strMapRanPosRecord[1318, 8] ="-61.3381 27.9355 107.421";
$strMapRanPosRecord[1318, 9] ="-58.7823 31.6374 107.421";
$strMapRanPosRecord[1318, 10] ="-64.5585 32.9945 107.421";
$strMapRanPosRecord[1318, 11] ="-67.9093 37.3277 107.421";
$strMapRanPosRecord[1318, 12] ="-65.9918 39.9226 107.421";
$strMapRanPosRecord[1318, 13] ="-68.8202 42.7553 107.421";
$strMapRanPosRecord[1318, 14] ="-75.2751 41.8168 107.421";
$strMapRanPosRecord[1318, 15] ="-80.8731 41.8767 107.421";
$strMapRanPosRecord[1318, 16] ="-81.0123 44.9921 107.421";
$strMapRanPosRecord[1318, 17] ="-80.2097 36.9844 107.421";
$strMapRanPosRecord[1318, 18] ="-83.0265 35.9218 107.421";
$strMapRanPosRecord[1318, 19] ="-77.3161 32.5594 107.421";
$strMapRanPosRecord[1318, 20] ="-74.4323 26.4116 107.421";
$strMapRanPosRecord[1318, 21] ="-74.4496 20.0397 107.421";
$strMapRanPosRecord[1318, 22] ="-76.4121 15.5084 107.421";
$strMapRanPosRecord[1318, 23] ="-75.8878 8.81109 107.421";
$strMapRanPosRecord[1318, 24] ="-81.3834 8.36101 107.421";
$strMapRanPosRecord[1318, 25] ="-87.0062 6.86441 107.421";
$strMapRanPosRecord[1318, 26] ="-90.084 9.07253 107.421";
$strMapRanPosRecord[1318, 27] ="-94.3018 6.97283 107.421";
$strMapRanPosRecord[1318, 28] ="-93.5454 14.3905 107.421";
$strMapRanPosRecord[1318, 29] ="-91.9065 18.0491 107.421";
$strMapRanPosRecord[1318, 30] ="-90.1447 21.2862 107.421";
$strMapRanPosRecord[1318, 31] ="-86.4566 21.768 107.421";
$strMapRanPosRecord[1318, 32] ="-83.9573 26.2054 107.421";
$strMapRanPosRecord[1318, 33] ="-84.3413 33.1337 107.421";
$strMapRanPosRecord[1318, 34] ="-85.0868 39.0261 107.421";
$strMapRanPosRecord[1318, 35] ="-83.9036 43.6882 107.421";
$strMapRanPosRecord[1318, 36] ="-81.3719 45.3513 107.421";
$strMapRanPosRecord[1318, 37] ="-86.8942 46.2601 107.421";
$strMapRanPosRecord[1318, 38] ="-90.7227 43.9296 107.421";
$strMapRanPosRecord[1318, 39] ="-91.9176 37.4506 107.421";
$strMapRanPosRecord[1318, 40] ="-93.4937 33.7242 107.421";
$strMapRanPosRecord[1318, 41] ="-94.126 27.7229 107.421";
$strMapRanPosRecord[1318, 42] ="-97.0962 24.3664 107.421";
$strMapRanPosRecord[1318, 43] ="-98.3408 19.2647 107.421";
$strMapRanPosRecord[1318, 44] ="-98.4222 13.8113 107.421";
$strMapRanPosRecord[1318, 45] ="-102.39 11.5776 107.421";
$strMapRanPosRecord[1318, 46] ="-106.2 10.6075 107.421";
$strMapRanPosRecord[1318, 47] ="-109.263 11.3086 107.421";
$strMapRanPosRecord[1318, 48] ="-113.833 11.9086 107.421";
$strMapRanPosRecord[1318, 49] ="-112.185 14.5908 107.421";
$strMapRanPosRecord[1318, 50] ="-107.99 17.8285 107.421";
$strMapRanPosRecord[1318, 51] ="-104.24 18.6127 107.421";
$strMapRanPosRecord[1318, 52] ="-106.584 25.9135 107.421";
$strMapRanPosRecord[1318, 53] ="-104.615 28.1551 107.421";
$strMapRanPosRecord[1318, 54] ="-104.693 33.3273 107.421";
$strMapRanPosRecord[1318, 55] ="-102.073 35.9727 107.421";
$strMapRanPosRecord[1318, 56] ="-103.407 41.0518 107.421";
$strMapRanPosRecord[1318, 57] ="-102.292 44.2575 107.421";
$strMapRanPosRecord[1318, 58] ="-100.517 48.5344 107.421";
$strMapRanPosRecord[1318, 59] ="-108.026 43.5935 107.421";
$strMapRanPosRecord[1318, 60] ="-111.391 41.669 107.421";
$strMapRanPosRecord[1318, 61] ="-114.139 34.7932 107.421";
$strMapRanPosRecord[1318, 62] ="-114.906 29.4802 107.421";
$strMapRanPosRecord[1318, 63] ="16.9782 28.2287 107.526";
$strMapRanPosRecord[1318, 64] ="22.6743 31.7421 107.526";
$strMapRanPosRecord[1318, 65] ="28.6209 31.0688 107.526";
$strMapRanPosRecord[1318, 66] ="30.7999 35.7841 107.806";
$strMapRanPosRecord[1318, 67] ="37.3165 33.4049 107.526";
$strMapRanPosRecord[1318, 68] ="43.3729 30.7109 107.526";
$strMapRanPosRecord[1318, 69] ="49.3478 31.1896 107.526";
$strMapRanPosRecord[1318, 70] ="51.914 27.384 107.526";
$strMapRanPosRecord[1318, 71] ="56.387 25.4154 107.526";
$strMapRanPosRecord[1318, 72] ="63.0883 27.396 107.526";
$strMapRanPosRecord[1318, 73] ="68.5684 28.6792 107.526";
$strMapRanPosRecord[1318, 74] ="72.6294 29.1968 107.526";
$strMapRanPosRecord[1318, 75] ="75.4721 27.6423 107.526";
$strMapRanPosRecord[1318, 76] ="73.6383 22.8946 107.526";
$strMapRanPosRecord[1318, 77] ="66.8383 19.7875 107.526";
$strMapRanPosRecord[1318, 78] ="63.2403 20.2072 107.526";
$strMapRanPosRecord[1318, 79] ="58.627 21.2816 107.526";
$strMapRanPosRecord[1318, 80] ="55.2945 22.7913 107.526";
$strMapRanPosRecord[1318, 81] ="52.434 24.1317 107.526";
$strMapRanPosRecord[1318, 82] ="48.7547 25.664 107.526";
$strMapRanPosRecord[1318, 83] ="45.3831 22.7632 107.526";
$strMapRanPosRecord[1318, 84] ="41.6434 22.6364 107.526";
$strMapRanPosRecord[1318, 85] ="38.0904 22.0294 107.526";
$strMapRanPosRecord[1318, 86] ="35.3419 23.5362 107.526";
$strMapRanPosRecord[1318, 87] ="31.37 22.678 107.526";
$strMapRanPosRecord[1318, 88] ="28.2308 24.71 107.526";
$strMapRanPosRecord[1318, 89] ="22.5267 25.2305 107.526";
$strMapRanPosRecord[1318, 90] ="17.6061 22.6289 107.526";
$strMapRanPosRecord[1318, 91] ="20.6652 20.4056 107.526";
$strMapRanPosRecord[1318, 92] ="25.8042 18.4613 107.526";
$strMapRanPosRecord[1318, 93] ="31.5725 18.1259 107.526";
$strMapRanPosRecord[1318, 94] ="36.5079 16.0424 107.526";
$strMapRanPosRecord[1318, 95] ="40.2087 15.29 107.526";
$strMapRanPosRecord[1318, 96] ="47.7647 14.9971 106.155";
$strMapRanPosRecord[1318, 97] ="52.268 15.231 106.264";
$strMapRanPosRecord[1318, 98] ="60.8978 15.2432 106.27";
$strMapRanPosRecord[1318, 99] ="65.8667 14.1814 107.296";
$strMapRanPosRecord[1318, 100] ="71.9052 14.4794 107.526";
$strMapRanPosRecord[1318, 101] ="75.3482 12.7321 107.526";
$strMapRanPosRecord[1318, 102] ="71.9434 7.36202 107.526";
$strMapRanPosRecord[1318, 103] ="67.5771 6.7911 107.526";
$strMapRanPosRecord[1318, 104] ="66.5705 3.84388 107.526";
$strMapRanPosRecord[1318, 105] ="72.6297 -0.699714 107.526";
$strMapRanPosRecord[1318, 106] ="68.2357 -2.56528 107.526";
$strMapRanPosRecord[1318, 107] ="63.4215 -4.43388 107.513";
$strMapRanPosRecord[1318, 108] ="58.1228 -5.72434 107.526";
$strMapRanPosRecord[1318, 109] ="52.291 -5.99301 107.526";
$strMapRanPosRecord[1318, 110] ="47.8597 -4.90472 107.526";
$strMapRanPosRecord[1318, 111] ="42.2474 -3.33444 107.526";
$strMapRanPosRecord[1318, 112] ="36.5805 -1.84646 107.526";
$strMapRanPosRecord[1318, 113] ="31.2448 -2.00222 107.526";
$strMapRanPosRecord[1318, 114] ="26.3589 -2.49499 107.526";
$strMapRanPosRecord[1318, 115] ="24.2997 -0.392346 107.526";
$strMapRanPosRecord[1318, 116] ="18.8087 -1.91035 107.526";
$strMapRanPosRecord[1318, 117] ="18.8109 -3.80034 107.526";
$strMapRanPosRecord[1318, 118] ="12.8728 -6.25189 107.526";
$strMapRanPosRecord[1318, 119] ="12.8893 -11.0055 107.526";
$strMapRanPosRecord[1318, 120] ="17.9384 -11.0594 107.526";
$strMapRanPosRecord[1318, 121] ="24.9313 -11.0847 107.526";
$strMapRanPosRecord[1318, 122] ="29.5511 -11.3994 107.526";
$strMapRanPosRecord[1318, 123] ="32.1234 -14.0551 107.526";
$strMapRanPosRecord[1318, 124] ="35.3476 -14.1768 107.526";
$strMapRanPosRecord[1318, 125] ="41.7248 -14.8495 107.526";
$strMapRanPosRecord[1318, 126] ="44.328 -13.6287 107.526";
$strMapRanPosRecord[1318, 127] ="49.481 -13.8315 107.526";
$strMapRanPosRecord[1318, 128] ="51.1507 -16.7722 107.526";
$strMapRanPosRecord[1318, 129] ="54.4417 -18.4009 107.526";
$strMapRanPosRecord[1318, 130] ="58.1544 -17.3412 107.526";
$strMapRanPosRecord[1318, 131] ="60.48 -12.5876 107.526";
$strMapRanPosRecord[1318, 132] ="63.8259 -11.6592 107.526";
$strMapRanPosRecord[1318, 133] ="67.1247 -12.5443 107.526";
$strMapRanPosRecord[1318, 134] ="69.1568 -13.5778 107.526";
$strMapRanPosRecord[1318, 135] ="72.9118 -12.2309 107.526";
$strMapRanPosRecord[1318, 136] ="76.252 -11.109 107.526";
$strMapRanPosRecord[1318, 137] ="77.8004 -13.2243 107.806";
$strMapRanPosRecord[1318, 138] ="69.0031 -18.9024 107.526";
$strMapRanPosRecord[1318, 139] ="71.2112 -18.3284 107.526";
$strMapRanPosRecord[1318, 140] ="68.0921 -18.9115 107.526";
$strMapRanPosRecord[1318, 141] ="65.3065 -18.4193 107.526";
$strMapRanPosRecord[1318, 142] ="59.6873 -15.9424 107.526";
$strMapRanPosRecord[1318, 143] ="55.0929 -15.4059 107.526";
$strMapRanPosRecord[1318, 144] ="55.0929 -15.4059 107.526";
$strMapRanPosRecord[1318, 145] ="48.5863 -14.931 107.526";
$strMapRanPosRecord[1318, 146] ="46.3009 -12.822 107.526";
$strMapRanPosRecord[1318, 147] ="42.8711 -20.7411 107.526";
$strMapRanPosRecord[1318, 148] ="47.3882 -22.0031 107.526";
$strMapRanPosRecord[1318, 149] ="50.5689 -26.9945 107.526";
$strMapRanPosRecord[1318, 150] ="52.1622 -25.2685 107.526";
$strMapRanPosRecord[1318, 151] ="47.8567 -28.8953 107.526";
$strMapRanPosRecord[1318, 152] ="43.2501 -31.2498 107.806";
$strMapRanPosRecord[1318, 153] ="41.6705 -29.0596 107.526";
$strMapRanPosRecord[1318, 154] ="36.4071 -27.5315 107.526";
$strMapRanPosRecord[1318, 155] ="28.8473 -28.3169 107.526";
$strMapRanPosRecord[1318, 156] ="24.003 -26.4431 107.526";
$strMapRanPosRecord[1318, 157] ="20.225 -27.457 107.526";
$strMapRanPosRecord[1318, 158] ="58.1394 -26.5654 107.072";
$strMapRanPosRecord[1318, 159] ="61.9371 -26.2393 105.391";
$strMapRanPosRecord[1318, 160] ="71.4647 -26.4607 105.391";

//■■■■■■■■■■■各大地图的随机坐标■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■各个怪物等级给于的基本经验■■■■■■■■■■■■■■■
//人物经验										 //宠物经验									 																												//化神经验
$Monster_Exp[1,1] =	5;  $Monster_Exp[1,2] =	27; $Monster_Exp[1,3] = 3; $Monster_Exp[1,4] = 50;	$Monster_AvatarExp[1] = 0;
$Monster_Exp[2,1] =	6;  $Monster_Exp[2,2] =	32; $Monster_Exp[2,3] = 3; $Monster_Exp[2,4] = 50;	$Monster_AvatarExp[2] = 0;
$Monster_Exp[3,1] =	7;  $Monster_Exp[3,2] =	37; $Monster_Exp[3,3] = 3; $Monster_Exp[3,4] = 50;	$Monster_AvatarExp[3] = 0;
$Monster_Exp[4,1] =	8;  $Monster_Exp[4,2] =	43; $Monster_Exp[4,3] = 3; $Monster_Exp[4,4] = 50;	$Monster_AvatarExp[4] = 0;
$Monster_Exp[5,1] =	9;  $Monster_Exp[5,2] =	48; $Monster_Exp[5,3] = 4; $Monster_Exp[5,4] = 50;	$Monster_AvatarExp[5] = 0;
$Monster_Exp[6,1] =	10;  $Monster_Exp[6,2] =	54; $Monster_Exp[6,3] = 4; $Monster_Exp[6,4] = 50;	$Monster_AvatarExp[6] = 0;
$Monster_Exp[7,1] =	11;  $Monster_Exp[7,2] =	59; $Monster_Exp[7,3] = 5; $Monster_Exp[7,4] = 50;	$Monster_AvatarExp[7] = 0;
$Monster_Exp[8,1] =	13;  $Monster_Exp[8,2] =	64; $Monster_Exp[8,3] = 5; $Monster_Exp[8,4] = 50;	$Monster_AvatarExp[8] = 0;
$Monster_Exp[9,1] =	16;  $Monster_Exp[9,2] =	70; $Monster_Exp[9,3] = 5; $Monster_Exp[9,4] = 50;	$Monster_AvatarExp[9] = 0;
$Monster_Exp[10,1] =	20;  $Monster_Exp[10,2] =	90; $Monster_Exp[10,3] = 6; $Monster_Exp[10,4] = 70;   $Monster_AvatarExp[10] = 0;
$Monster_Exp[11,1] =	24;  $Monster_Exp[11,2] =	97; $Monster_Exp[11,3] = 7; $Monster_Exp[11,4] = 70;   $Monster_AvatarExp[11] = 0;
$Monster_Exp[12,1] =	28;  $Monster_Exp[12,2] =	103; $Monster_Exp[12,3] = 7; $Monster_Exp[12,4] = 70;   $Monster_AvatarExp[12] = 0;
$Monster_Exp[13,1] =	32;  $Monster_Exp[13,2] =	109; $Monster_Exp[13,3] = 8; $Monster_Exp[13,4] = 70;   $Monster_AvatarExp[13] = 0;
$Monster_Exp[14,1] =	36;  $Monster_Exp[14,2] =	116; $Monster_Exp[14,3] = 9; $Monster_Exp[14,4] = 70;   $Monster_AvatarExp[14] = 0;
$Monster_Exp[15,1] =	40;  $Monster_Exp[15,2] =	122; $Monster_Exp[15,3] = 9; $Monster_Exp[15,4] = 70;   $Monster_AvatarExp[15] = 0;
$Monster_Exp[16,1] =	44;  $Monster_Exp[16,2] =	129; $Monster_Exp[16,3] = 10; $Monster_Exp[16,4] = 70;   $Monster_AvatarExp[16] = 0;
$Monster_Exp[17,1] =	48;  $Monster_Exp[17,2] =	135; $Monster_Exp[17,3] = 11; $Monster_Exp[17,4] = 70;   $Monster_AvatarExp[17] = 0;
$Monster_Exp[18,1] =	52;  $Monster_Exp[18,2] =	142; $Monster_Exp[18,3] = 13; $Monster_Exp[18,4] = 70;   $Monster_AvatarExp[18] = 0;
$Monster_Exp[19,1] =	56;  $Monster_Exp[19,2] =	148; $Monster_Exp[19,3] = 14; $Monster_Exp[19,4] = 70;   $Monster_AvatarExp[19] = 0;
$Monster_Exp[20,1] =	60;  $Monster_Exp[20,2] =	180; $Monster_Exp[20,3] = 15; $Monster_Exp[20,4] = 90;   $Monster_AvatarExp[20] = 0;
$Monster_Exp[21,1] =	64;  $Monster_Exp[21,2] =	189; $Monster_Exp[21,3] = 16; $Monster_Exp[21,4] = 90;   $Monster_AvatarExp[21] = 0;
$Monster_Exp[22,1] =	68;  $Monster_Exp[22,2] =	196; $Monster_Exp[22,3] = 16; $Monster_Exp[22,4] = 90;   $Monster_AvatarExp[22] = 0;
$Monster_Exp[23,1] =	72;  $Monster_Exp[23,2] =	203; $Monster_Exp[23,3] = 17; $Monster_Exp[23,4] = 90;   $Monster_AvatarExp[23] = 0;
$Monster_Exp[24,1] =	76;  $Monster_Exp[24,2] =	211; $Monster_Exp[24,3] = 17; $Monster_Exp[24,4] = 90;   $Monster_AvatarExp[24] = 0;
$Monster_Exp[25,1] =	80;  $Monster_Exp[25,2] =	218; $Monster_Exp[25,3] = 18; $Monster_Exp[25,4] = 90;   $Monster_AvatarExp[25] = 0;
$Monster_Exp[26,1] =	84;  $Monster_Exp[26,2] =	226; $Monster_Exp[26,3] = 19; $Monster_Exp[26,4] = 90;   $Monster_AvatarExp[26] = 0;
$Monster_Exp[27,1] =	88;  $Monster_Exp[27,2] =	234; $Monster_Exp[27,3] = 19; $Monster_Exp[27,4] = 90;   $Monster_AvatarExp[27] = 0;
$Monster_Exp[28,1] =	92;  $Monster_Exp[28,2] =	241; $Monster_Exp[28,3] = 20; $Monster_Exp[28,4] = 90;   $Monster_AvatarExp[28] = 0;
$Monster_Exp[29,1] =	96;  $Monster_Exp[29,2] =	249; $Monster_Exp[29,3] = 21; $Monster_Exp[29,4] = 90;   $Monster_AvatarExp[29] = 0;
$Monster_Exp[30,1] =	102;  $Monster_Exp[30,2] =	293; $Monster_Exp[30,3] = 21; $Monster_Exp[30,4] = 110;   $Monster_AvatarExp[30] = 0;
$Monster_Exp[31,1] =	108;  $Monster_Exp[31,2] =	302; $Monster_Exp[31,3] = 22; $Monster_Exp[31,4] = 110;   $Monster_AvatarExp[31] = 0;
$Monster_Exp[32,1] =	114;  $Monster_Exp[32,2] =	310; $Monster_Exp[32,3] = 23; $Monster_Exp[32,4] = 110;   $Monster_AvatarExp[32] = 0;
$Monster_Exp[33,1] =	120;  $Monster_Exp[33,2] =	319; $Monster_Exp[33,3] = 24; $Monster_Exp[33,4] = 110;   $Monster_AvatarExp[33] = 0;
$Monster_Exp[34,1] =	126;  $Monster_Exp[34,2] =	327; $Monster_Exp[34,3] = 24; $Monster_Exp[34,4] = 110;   $Monster_AvatarExp[34] = 0;
$Monster_Exp[35,1] =	132;  $Monster_Exp[35,2] =	336; $Monster_Exp[35,3] = 25; $Monster_Exp[35,4] = 110;   $Monster_AvatarExp[35] = 0;
$Monster_Exp[36,1] =	138;  $Monster_Exp[36,2] =	345; $Monster_Exp[36,3] = 26; $Monster_Exp[36,4] = 110;   $Monster_AvatarExp[36] = 0;
$Monster_Exp[37,1] =	144;  $Monster_Exp[37,2] =	353; $Monster_Exp[37,3] = 27; $Monster_Exp[37,4] = 110;   $Monster_AvatarExp[37] = 0;
$Monster_Exp[38,1] =	150;  $Monster_Exp[38,2] =	362; $Monster_Exp[38,3] = 28; $Monster_Exp[38,4] = 110;   $Monster_AvatarExp[38] = 0;
$Monster_Exp[39,1] =	156;  $Monster_Exp[39,2] =	370; $Monster_Exp[39,3] = 29; $Monster_Exp[39,4] = 130;   $Monster_AvatarExp[39] = 0;
$Monster_Exp[40,1] =	162;  $Monster_Exp[40,2] =	427; $Monster_Exp[40,3] = 30; $Monster_Exp[40,4] = 130;   $Monster_AvatarExp[40] = 0;
$Monster_Exp[41,1] =	168;  $Monster_Exp[41,2] =	437; $Monster_Exp[41,3] = 31; $Monster_Exp[41,4] = 130;   $Monster_AvatarExp[41] = 0;
$Monster_Exp[42,1] =	174;  $Monster_Exp[42,2] =	446; $Monster_Exp[42,3] = 31; $Monster_Exp[42,4] = 130;   $Monster_AvatarExp[42] = 0;
$Monster_Exp[43,1] =	180;  $Monster_Exp[43,2] =	456; $Monster_Exp[43,3] = 32; $Monster_Exp[43,4] = 130;   $Monster_AvatarExp[43] = 0;
$Monster_Exp[44,1] =	186;  $Monster_Exp[44,2] =	466; $Monster_Exp[44,3] = 33; $Monster_Exp[44,4] = 130;   $Monster_AvatarExp[44] = 0;
$Monster_Exp[45,1] =	192;  $Monster_Exp[45,2] =	476; $Monster_Exp[45,3] = 33; $Monster_Exp[45,4] = 130;   $Monster_AvatarExp[45] = 0;
$Monster_Exp[46,1] =	198;  $Monster_Exp[46,2] =	486; $Monster_Exp[46,3] = 34; $Monster_Exp[46,4] = 130;   $Monster_AvatarExp[46] = 0;
$Monster_Exp[47,1] =	204;  $Monster_Exp[47,2] =	495; $Monster_Exp[47,3] = 35; $Monster_Exp[47,4] = 130;   $Monster_AvatarExp[47] = 0;
$Monster_Exp[48,1] =	210;  $Monster_Exp[48,2] =	504; $Monster_Exp[48,3] = 35; $Monster_Exp[48,4] = 130;   $Monster_AvatarExp[48] = 0;
$Monster_Exp[49,1] =	216;  $Monster_Exp[49,2] =	514; $Monster_Exp[49,3] = 36; $Monster_Exp[49,4] = 130;   $Monster_AvatarExp[49] = 0;
$Monster_Exp[50,1] =	224;  $Monster_Exp[50,2] =	583; $Monster_Exp[50,3] = 37; $Monster_Exp[50,4] = 130;   $Monster_AvatarExp[50] = 0;
$Monster_Exp[51,1] =	232;  $Monster_Exp[51,2] =	594; $Monster_Exp[51,3] = 38; $Monster_Exp[51,4] = 130;   $Monster_AvatarExp[51] = 0;
$Monster_Exp[52,1] =	240;  $Monster_Exp[52,2] =	604; $Monster_Exp[52,3] = 38; $Monster_Exp[52,4] = 130;   $Monster_AvatarExp[52] = 0;
$Monster_Exp[53,1] =	248;  $Monster_Exp[53,2] =	615; $Monster_Exp[53,3] = 39; $Monster_Exp[53,4] = 220;   $Monster_AvatarExp[53] = 0;
$Monster_Exp[54,1] =	256;  $Monster_Exp[54,2] =	626; $Monster_Exp[54,3] = 40; $Monster_Exp[54,4] = 220;   $Monster_AvatarExp[54] = 0;
$Monster_Exp[55,1] =	264;  $Monster_Exp[55,2] =	637; $Monster_Exp[55,3] = 41; $Monster_Exp[55,4] = 220;   $Monster_AvatarExp[55] = 0;
$Monster_Exp[56,1] =	272;  $Monster_Exp[56,2] =	648; $Monster_Exp[56,3] = 42; $Monster_Exp[56,4] = 220;   $Monster_AvatarExp[56] = 0;
$Monster_Exp[57,1] =	280;  $Monster_Exp[57,2] =	658; $Monster_Exp[57,3] = 42; $Monster_Exp[57,4] = 220;   $Monster_AvatarExp[57] = 0;
$Monster_Exp[58,1] =	288;  $Monster_Exp[58,2] =	669; $Monster_Exp[58,3] = 43; $Monster_Exp[58,4] = 220;   $Monster_AvatarExp[58] = 0;
$Monster_Exp[59,1] =	296;  $Monster_Exp[59,2] =	680; $Monster_Exp[59,3] = 44; $Monster_Exp[59,4] = 220;   $Monster_AvatarExp[59] = 0;
$Monster_Exp[60,1] =	306;  $Monster_Exp[60,2] =	759; $Monster_Exp[60,3] = 45; $Monster_Exp[60,4] = 330;   $Monster_AvatarExp[60] = 0;
$Monster_Exp[61,1] =	316;  $Monster_Exp[61,2] =	772; $Monster_Exp[61,3] = 45; $Monster_Exp[61,4] = 330;   $Monster_AvatarExp[61] = 0;
$Monster_Exp[62,1] =	326;  $Monster_Exp[62,2] =	783; $Monster_Exp[62,3] = 45; $Monster_Exp[62,4] = 330;   $Monster_AvatarExp[62] = 0;
$Monster_Exp[63,1] =	336;  $Monster_Exp[63,2] =	795; $Monster_Exp[63,3] = 45; $Monster_Exp[63,4] = 330;   $Monster_AvatarExp[63] = 0;
$Monster_Exp[64,1] =	346;  $Monster_Exp[64,2] =	807; $Monster_Exp[64,3] = 45; $Monster_Exp[64,4] = 330;   $Monster_AvatarExp[64] = 0;
$Monster_Exp[65,1] =	356;  $Monster_Exp[65,2] =	819; $Monster_Exp[65,3] = 45; $Monster_Exp[65,4] = 330;   $Monster_AvatarExp[65] = 0;
$Monster_Exp[66,1] =	366;  $Monster_Exp[66,2] =	831; $Monster_Exp[66,3] = 45; $Monster_Exp[66,4] = 330;   $Monster_AvatarExp[66] = 0;
$Monster_Exp[67,1] =	376;  $Monster_Exp[67,2] =	843; $Monster_Exp[67,3] = 45; $Monster_Exp[67,4] = 330;   $Monster_AvatarExp[67] = 0;
$Monster_Exp[68,1] =	386;  $Monster_Exp[68,2] =	855; $Monster_Exp[68,3] = 45; $Monster_Exp[68,4] = 330;   $Monster_AvatarExp[68] = 0;
$Monster_Exp[69,1] =	396;  $Monster_Exp[69,2] =	866; $Monster_Exp[69,3] = 45; $Monster_Exp[69,4] = 330;   $Monster_AvatarExp[69] = 0;
$Monster_Exp[70,1] =	408;  $Monster_Exp[70,2] =	958; $Monster_Exp[70,3] = 45; $Monster_Exp[70,4] = 330;   $Monster_AvatarExp[70] = 0;
$Monster_Exp[71,1] =	420;  $Monster_Exp[71,2] =	972; $Monster_Exp[71,3] = 45; $Monster_Exp[71,4] = 330;   $Monster_AvatarExp[71] = 0;
$Monster_Exp[72,1] =	432;  $Monster_Exp[72,2] =	984; $Monster_Exp[72,3] = 45; $Monster_Exp[72,4] = 410;   $Monster_AvatarExp[72] = 0;
$Monster_Exp[73,1] =	444;  $Monster_Exp[73,2] =	997; $Monster_Exp[73,3] = 45; $Monster_Exp[73,4] = 410;   $Monster_AvatarExp[73] = 0;
$Monster_Exp[74,1] =	456;  $Monster_Exp[74,2] =	1010; $Monster_Exp[74,3] = 45; $Monster_Exp[74,4] = 410;   $Monster_AvatarExp[74] = 0;
$Monster_Exp[75,1] =	468;  $Monster_Exp[75,2] =	1023; $Monster_Exp[75,3] = 45; $Monster_Exp[75,4] = 410;   $Monster_AvatarExp[75] = 0;
$Monster_Exp[76,1] =	480;  $Monster_Exp[76,2] =	1036; $Monster_Exp[76,3] = 45; $Monster_Exp[76,4] = 410;   $Monster_AvatarExp[76] = 0;
$Monster_Exp[77,1] =	492;  $Monster_Exp[77,2] =	1049; $Monster_Exp[77,3] = 45; $Monster_Exp[77,4] = 410;   $Monster_AvatarExp[77] = 0;
$Monster_Exp[78,1] =	504;  $Monster_Exp[78,2] =	1062; $Monster_Exp[78,3] = 45; $Monster_Exp[78,4] = 410;   $Monster_AvatarExp[78] = 0;
$Monster_Exp[79,1] =	516;  $Monster_Exp[79,2] =	1075; $Monster_Exp[79,3] = 45; $Monster_Exp[79,4] = 710;   $Monster_AvatarExp[79] = 0;
$Monster_Exp[80,1] =	531;  $Monster_Exp[80,2] =	1179; $Monster_Exp[80,3] = 45; $Monster_Exp[80,4] = 710;   $Monster_AvatarExp[80] = 0;
$Monster_Exp[81,1] =	546;  $Monster_Exp[81,2] =	1193; $Monster_Exp[81,3] = 45; $Monster_Exp[81,4] = 710;   $Monster_AvatarExp[81] = 0;
$Monster_Exp[82,1] =	561;  $Monster_Exp[82,2] =	1206; $Monster_Exp[82,3] = 45; $Monster_Exp[82,4] = 710;   $Monster_AvatarExp[82] = 0;
$Monster_Exp[83,1] =	576;  $Monster_Exp[83,2] =	1221; $Monster_Exp[83,3] = 45; $Monster_Exp[83,4] = 710;   $Monster_AvatarExp[83] = 0;
$Monster_Exp[84,1] =	591;  $Monster_Exp[84,2] =	1234; $Monster_Exp[84,3] = 45; $Monster_Exp[84,4] = 710;   $Monster_AvatarExp[84] = 0;
$Monster_Exp[85,1] =	606;  $Monster_Exp[85,2] =	1249; $Monster_Exp[85,3] = 45; $Monster_Exp[85,4] = 710;   $Monster_AvatarExp[85] = 0;
$Monster_Exp[86,1] =	621;  $Monster_Exp[86,2] =	1263; $Monster_Exp[86,3] = 45; $Monster_Exp[86,4] = 710;   $Monster_AvatarExp[86] = 0;
$Monster_Exp[87,1] =	636;  $Monster_Exp[87,2] =	1277; $Monster_Exp[87,3] = 45; $Monster_Exp[87,4] = 710;   $Monster_AvatarExp[87] = 0;
$Monster_Exp[88,1] =	651;  $Monster_Exp[88,2] =	1291; $Monster_Exp[88,3] = 45; $Monster_Exp[88,4] = 710;   $Monster_AvatarExp[88] = 0;
$Monster_Exp[89,1] =	666;  $Monster_Exp[89,2] =	1305; $Monster_Exp[89,3] = 45; $Monster_Exp[89,4] = 710;   $Monster_AvatarExp[89] = 0;
$Monster_Exp[90,1] =	684;  $Monster_Exp[90,2] =	1350; $Monster_Exp[90,3] = 45; $Monster_Exp[90,4] = 710;   $Monster_AvatarExp[90] = 0;
$Monster_Exp[91,1] =	702;  $Monster_Exp[91,2] =	1364; $Monster_Exp[91,3] = 45; $Monster_Exp[91,4] = 800;   $Monster_AvatarExp[91] = 0;
$Monster_Exp[92,1] =	720;  $Monster_Exp[92,2] =	1378; $Monster_Exp[92,3] = 45; $Monster_Exp[92,4] = 800;   $Monster_AvatarExp[92] = 0;
$Monster_Exp[93,1] =	738;  $Monster_Exp[93,2] =	1393; $Monster_Exp[93,3] = 45; $Monster_Exp[93,4] = 800;   $Monster_AvatarExp[93] = 0;
$Monster_Exp[94,1] =	756;  $Monster_Exp[94,2] =	1407; $Monster_Exp[94,3] = 45; $Monster_Exp[94,4] = 800;   $Monster_AvatarExp[94] = 0;
$Monster_Exp[95,1] =	774;  $Monster_Exp[95,2] =	1422; $Monster_Exp[95,3] = 45; $Monster_Exp[95,4] = 800;   $Monster_AvatarExp[95] = 0;
$Monster_Exp[96,1] =	792;  $Monster_Exp[96,2] =	1436; $Monster_Exp[96,3] = 45; $Monster_Exp[96,4] = 800;   $Monster_AvatarExp[96] = 0;
$Monster_Exp[97,1] =	810;  $Monster_Exp[97,2] =	1449; $Monster_Exp[97,3] = 45; $Monster_Exp[97,4] = 800;   $Monster_AvatarExp[97] = 0;
$Monster_Exp[98,1] =	828;  $Monster_Exp[98,2] =	1464; $Monster_Exp[98,3] = 45; $Monster_Exp[98,4] = 800;   $Monster_AvatarExp[98] = 0;
$Monster_Exp[99,1] =	846;  $Monster_Exp[99,2] =	1478; $Monster_Exp[99,3] = 45; $Monster_Exp[99,4] = 800;   $Monster_AvatarExp[99] = 0;
$Monster_Exp[100,1] =	868;  $Monster_Exp[100,2] =	1515; $Monster_Exp[100,3] = 45; $Monster_Exp[100,4] = 900;   $Monster_AvatarExp[100] = 0;
$Monster_Exp[101,1] =	890;  $Monster_Exp[101,2] =	1530; $Monster_Exp[101,3] = 45; $Monster_Exp[101,4] = 900;
$Monster_Exp[102,1] =	912;  $Monster_Exp[102,2] =	1545; $Monster_Exp[102,3] = 45; $Monster_Exp[102,4] = 900;
$Monster_Exp[103,1] =	934;  $Monster_Exp[103,2] =	1559; $Monster_Exp[103,3] = 45; $Monster_Exp[103,4] = 900;
$Monster_Exp[104,1] =	956;  $Monster_Exp[104,2] =	1574; $Monster_Exp[104,3] = 45; $Monster_Exp[104,4] = 900;
$Monster_Exp[105,1] =	978;  $Monster_Exp[105,2] =	1588; $Monster_Exp[105,3] = 45; $Monster_Exp[105,4] = 900;
$Monster_Exp[106,1] =	1000;  $Monster_Exp[106,2] =	1602; $Monster_Exp[106,3] = 45; $Monster_Exp[106,4] = 900;
$Monster_Exp[107,1] =	1022;  $Monster_Exp[107,2] =	1617; $Monster_Exp[107,3] = 45; $Monster_Exp[107,4] = 900;
$Monster_Exp[108,1] =	1044;  $Monster_Exp[108,2] =	1631; $Monster_Exp[108,3] = 45; $Monster_Exp[108,4] = 900;
$Monster_Exp[109,1] =	1066;  $Monster_Exp[109,2] =	1646; $Monster_Exp[109,3] = 45; $Monster_Exp[109,4] = 900;
$Monster_Exp[110,1] =	1091;  $Monster_Exp[110,2] =	1685; $Monster_Exp[110,3] = 45; $Monster_Exp[110,4] = 990;
$Monster_Exp[111,1] =	1116;  $Monster_Exp[111,2] =	1698; $Monster_Exp[111,3] = 45; $Monster_Exp[111,4] = 990;
$Monster_Exp[112,1] =	1141;  $Monster_Exp[112,2] =	1710; $Monster_Exp[112,3] = 45; $Monster_Exp[112,4] = 990;
$Monster_Exp[113,1] =	1166;  $Monster_Exp[113,2] =	1723; $Monster_Exp[113,3] = 45; $Monster_Exp[113,4] = 990;
$Monster_Exp[114,1] =	1191;  $Monster_Exp[114,2] =	1736; $Monster_Exp[114,3] = 45; $Monster_Exp[114,4] = 990;
$Monster_Exp[115,1] =	1216;  $Monster_Exp[115,2] =	1748; $Monster_Exp[115,3] = 45; $Monster_Exp[115,4] = 990;
$Monster_Exp[116,1] =	1241;  $Monster_Exp[116,2] =	1761; $Monster_Exp[116,3] = 45; $Monster_Exp[116,4] = 990;
$Monster_Exp[117,1] =	1266;  $Monster_Exp[117,2] =	1773; $Monster_Exp[117,3] = 45; $Monster_Exp[117,4] = 990;
$Monster_Exp[118,1] =	1291;  $Monster_Exp[118,2] =	1786; $Monster_Exp[118,3] = 45; $Monster_Exp[118,4] = 990;
$Monster_Exp[119,1] =	1316;  $Monster_Exp[119,2] =	1799; $Monster_Exp[119,3] = 45; $Monster_Exp[119,4] = 990;
$Monster_Exp[120,1] =	1346;  $Monster_Exp[120,2] =	1925; $Monster_Exp[120,3] = 45; $Monster_Exp[120,4] = 990;
$Monster_Exp[121,1] =	1376;  $Monster_Exp[121,2] =	1937; $Monster_Exp[121,3] = 45;
$Monster_Exp[122,1] =	1406;  $Monster_Exp[122,2] =	1950; $Monster_Exp[122,3] = 45;
$Monster_Exp[123,1] =	1436;  $Monster_Exp[123,2] =	1962; $Monster_Exp[123,3] = 45;
$Monster_Exp[124,1] =	1466;  $Monster_Exp[124,2] =	1975; $Monster_Exp[124,3] = 45;
$Monster_Exp[125,1] =	1496;  $Monster_Exp[125,2] =	1988; $Monster_Exp[125,3] = 45;
$Monster_Exp[126,1] =	1526;  $Monster_Exp[126,2] =	2000; $Monster_Exp[126,3] = 45;
$Monster_Exp[127,1] =	1556;  $Monster_Exp[127,2] =	2013; $Monster_Exp[127,3] = 45;
$Monster_Exp[128,1] =	1586;  $Monster_Exp[128,2] =	2025; $Monster_Exp[128,3] = 45;
$Monster_Exp[129,1] =	1616;  $Monster_Exp[129,2] =	2038; $Monster_Exp[129,3] = 45;
$Monster_Exp[130,1] =	1646;  $Monster_Exp[130,2] =	2174; $Monster_Exp[130,3] = 45;
$Monster_Exp[131,1] =	1676;  $Monster_Exp[131,2] =	2187; $Monster_Exp[131,3] = 45;
$Monster_Exp[132,1] =	1706;  $Monster_Exp[132,2] =	2199; $Monster_Exp[132,3] = 45;
$Monster_Exp[133,1] =	1736;  $Monster_Exp[133,2] =	2212; $Monster_Exp[133,3] = 45;
$Monster_Exp[134,1] =	1766;  $Monster_Exp[134,2] =	2224; $Monster_Exp[134,3] = 45;
$Monster_Exp[135,1] =	1796;  $Monster_Exp[135,2] =	2237; $Monster_Exp[135,3] = 45;
$Monster_Exp[136,1] =	1826;  $Monster_Exp[136,2] =	2250; $Monster_Exp[136,3] = 45;
$Monster_Exp[137,1] =	1856;  $Monster_Exp[137,2] =	2262; $Monster_Exp[137,3] = 45;
$Monster_Exp[138,1] =	1886;  $Monster_Exp[138,2] =	2275; $Monster_Exp[138,3] = 45;
$Monster_Exp[139,1] =	1916;  $Monster_Exp[139,2] =	2287; $Monster_Exp[139,3] = 45;
$Monster_Exp[140,1] =	1946;  $Monster_Exp[140,2] =	2441; $Monster_Exp[140,3] = 45;
$Monster_Exp[141,1] =	1976;  $Monster_Exp[141,2] =	2453; $Monster_Exp[141,3] = 45;
$Monster_Exp[142,1] =	2006;  $Monster_Exp[142,2] =	2465; $Monster_Exp[142,3] = 45;
$Monster_Exp[143,1] =	2036;  $Monster_Exp[143,2] =	2476; $Monster_Exp[143,3] = 45;
$Monster_Exp[144,1] =	2066;  $Monster_Exp[144,2] =	2488; $Monster_Exp[144,3] = 45;
$Monster_Exp[145,1] =	2096;  $Monster_Exp[145,2] =	2500; $Monster_Exp[145,3] = 45;
$Monster_Exp[146,1] =	2126;  $Monster_Exp[146,2] =	2511; $Monster_Exp[146,3] = 45;
$Monster_Exp[147,1] =	2156;  $Monster_Exp[147,2] =	2523; $Monster_Exp[147,3] = 45;
$Monster_Exp[148,1] =	2186;  $Monster_Exp[148,2] =	2535; $Monster_Exp[148,3] = 45;
$Monster_Exp[149,1] =	2216;  $Monster_Exp[149,2] =	2547; $Monster_Exp[149,3] = 45;
$Monster_Exp[150,1] =	2246;  $Monster_Exp[150,2] =	2718; $Monster_Exp[150,3] = 45;
$Monster_Exp[151,1] =	2731;  $Monster_Exp[151,2] =	2731; $Monster_Exp[151,3] = 45;
$Monster_Exp[152,1] =	2744;  $Monster_Exp[152,2] =	2744; $Monster_Exp[152,3] = 45;
$Monster_Exp[153,1] =	2756;  $Monster_Exp[153,2] =	2756; $Monster_Exp[153,3] = 45;
$Monster_Exp[154,1] =	2769;  $Monster_Exp[154,2] =	2769; $Monster_Exp[154,3] = 45;
$Monster_Exp[155,1] =	2781;  $Monster_Exp[155,2] =	2781; $Monster_Exp[155,3] = 45;
$Monster_Exp[156,1] =	2794;  $Monster_Exp[156,2] =	2794; $Monster_Exp[156,3] = 45;
$Monster_Exp[157,1] =	2807;  $Monster_Exp[157,2] =	2807; $Monster_Exp[157,3] = 45;
$Monster_Exp[158,1] =	2819;  $Monster_Exp[158,2] =	2819; $Monster_Exp[158,3] = 45;
$Monster_Exp[159,1] =	2832;  $Monster_Exp[159,2] =	2832; $Monster_Exp[159,3] = 45;
$Monster_Exp[160,1] =	3023;  $Monster_Exp[160,2] =	3023; $Monster_Exp[160,3] = 45;
$Monster_Exp[161,1] =	3035;  $Monster_Exp[161,2] =	3035; $Monster_Exp[161,3] = 45;
$Monster_Exp[162,1] =	3048;  $Monster_Exp[162,2] =	3048;
$Monster_Exp[163,1] =	3060;  $Monster_Exp[163,2] =	3060;
$Monster_Exp[164,1] =	3073;  $Monster_Exp[164,2] =	3073;
$Monster_Exp[165,1] =	3086;  $Monster_Exp[165,2] =	3086;
$Monster_Exp[166,1] =	3098;  $Monster_Exp[166,2] =	3098;
$Monster_Exp[167,1] =	3111;  $Monster_Exp[167,2] =	3111;
$Monster_Exp[168,1] =	3123;  $Monster_Exp[168,2] =	3123;
$Monster_Exp[169,1] =	3136;  $Monster_Exp[169,2] =	3136;
$Monster_Exp[170,1] =	3345;  $Monster_Exp[170,2] =	3345;
$Monster_Exp[171,1] =	3357;  $Monster_Exp[171,2] =	3357;
$Monster_Exp[172,1] =	3370;  $Monster_Exp[172,2] =	3370;
$Monster_Exp[173,1] =	3383;  $Monster_Exp[173,2] =	3383;
$Monster_Exp[174,1] =	3395;  $Monster_Exp[174,2] =	3395;
$Monster_Exp[175,1] =	3408;  $Monster_Exp[175,2] =	3408;
$Monster_Exp[176,1] =	3420;  $Monster_Exp[176,2] =	3420;
$Monster_Exp[177,1] =	3433;  $Monster_Exp[177,2] =	3433;
$Monster_Exp[178,1] =	3446;  $Monster_Exp[178,2] =	3446;
$Monster_Exp[179,1] =	3458;  $Monster_Exp[179,2] =	3458;
$Monster_Exp[180,1] =	3694;  $Monster_Exp[180,2] =	3694;
$Monster_Exp[181,1] =	3707;  $Monster_Exp[181,2] =	3707;
$Monster_Exp[182,1] =	3719;  $Monster_Exp[182,2] =	3719;
$Monster_Exp[183,1] =	3732;  $Monster_Exp[183,2] =	3732;
$Monster_Exp[184,1] =	3744;  $Monster_Exp[184,2] =	3744;
$Monster_Exp[185,1] =	3757;  $Monster_Exp[185,2] =	3757;
$Monster_Exp[186,1] =	3770;  $Monster_Exp[186,2] =	3770;
$Monster_Exp[187,1] =	3782;  $Monster_Exp[187,2] =	3782;
$Monster_Exp[188,1] =	3795;  $Monster_Exp[188,2] =	3795;
$Monster_Exp[189,1] =	3807;  $Monster_Exp[189,2] =	3807;
$Monster_Exp[190,1] =	4060;  $Monster_Exp[190,2] =	4060;
$Monster_Exp[191,1] =	4073;  $Monster_Exp[191,2] =	4073;
$Monster_Exp[192,1] =	4086;  $Monster_Exp[192,2] =	4086;
$Monster_Exp[193,1] =	4098;  $Monster_Exp[193,2] =	4098;
$Monster_Exp[194,1] =	4111;  $Monster_Exp[194,2] =	4111;
$Monster_Exp[195,1] =	4123;  $Monster_Exp[195,2] =	4123;
$Monster_Exp[196,1] =	4136;  $Monster_Exp[196,2] =	4136;
$Monster_Exp[197,1] =	4149;  $Monster_Exp[197,2] =	4149;
$Monster_Exp[198,1] =	4161;  $Monster_Exp[198,2] =	4161;
$Monster_Exp[199,1] =	4174;  $Monster_Exp[199,2] =	4174;
$Monster_Exp[200,1] =	4186;  $Monster_Exp[200,2] =	4186;


//■■■■■■■■■■■各个怪物等级给于的基本经验■■■■■■■■■■■■■■■


//■■■■■■■■■■■怪物和人物等级差的经验消减■■■■■■■■■■■■■■■
$MonDifferencePly_Exp[ 9] = 0.85;
$MonDifferencePly_Exp[10] = 0.70;
$MonDifferencePly_Exp[11] = 0.55;
$MonDifferencePly_Exp[12] = 0.40;
$MonDifferencePly_Exp[13] = 0.25;
$MonDifferencePly_Exp[14] = 0.10;


//■■■■■■■■■■■人物神兽化身升级所需的经验■■■■■■■■■■■■■■■
// $LevelExp[i]表示从i升级到i+1所需的经验，改值不能等于0
// 神兽经验，$PetLevelExp[i]表示从i升级到i+1所需的经验
// 化身经验，特别注意：$SpiritLevelExp[i]表示从i升级到i+1所需的经验
//活跃度奖励					//玩家经验													//侍卫经验																//神兽经验												//化身经验													//星宿升级经验
$LeveTxt[1] = "1级";  $HappyLv[1] = 130;	 $LevelExp[1] = 100;		$MercenaryLevelExp[1] = 380;	$PetLevelExp[0] = 97;		$SpiritLevelExp[0] = 130; $TrumpLevelUp_Exp[1] = 0;
$LeveTxt[2] = "2级";  $HappyLv[2] = 132;	 $LevelExp[2] = 110;		$MercenaryLevelExp[2] = 750;	$PetLevelExp[1] = 194;	$SpiritLevelExp[1] = 302;	$TrumpLevelUp_Exp[2] = 280;
$LeveTxt[3] = "3级";  $HappyLv[3] = 134;	 $LevelExp[3] = 120;		$MercenaryLevelExp[3] = 1375;	$PetLevelExp[2] = 346;	$SpiritLevelExp[2] = 475;	$TrumpLevelUp_Exp[3] = 450;
$LeveTxt[4] = "4级";  $HappyLv[4] = 136;	 $LevelExp[4] = 130;		$MercenaryLevelExp[4] = 2150;	$PetLevelExp[3] = 533;	$SpiritLevelExp[3] = 648;	$TrumpLevelUp_Exp[4] = 710;
$LeveTxt[5] = "5级";  $HappyLv[5] = 138;	 $LevelExp[5] = 140;		$MercenaryLevelExp[5] = 3101;	$PetLevelExp[4] = 774;	$SpiritLevelExp[4] = 1154;	$TrumpLevelUp_Exp[5] = 1130;
$LeveTxt[6] = "6级";  $HappyLv[6] = 140;	 $LevelExp[6] = 150;		$MercenaryLevelExp[6] = 4134;	$PetLevelExp[5] = 1037;	$SpiritLevelExp[5] = 1461;	$TrumpLevelUp_Exp[6] = 1800;
$LeveTxt[7] = "7级";  $HappyLv[7] = 142;	 $LevelExp[7] = 170;		$MercenaryLevelExp[7] = 5435;	$PetLevelExp[6] = 1361;	$SpiritLevelExp[6] = 2144;	$TrumpLevelUp_Exp[7] = 2370;
$LeveTxt[8] = "8级";  $HappyLv[8] = 144;	 $LevelExp[8] = 220;		$MercenaryLevelExp[8] = 6788;	$PetLevelExp[7] = 1699;	$SpiritLevelExp[7] = 2462;	$TrumpLevelUp_Exp[8] = 3130;
$LeveTxt[9] = "9级";  $HappyLv[9] = 146;	 $LevelExp[9] = 290;		$MercenaryLevelExp[9] = 8302;	$PetLevelExp[8] = 2074;	$SpiritLevelExp[8] = 2779;	$TrumpLevelUp_Exp[9] = 4130;
$LeveTxt[10] = "10级"; $HappyLv[10] = 148;	 $LevelExp[10] = 380;		$MercenaryLevelExp[10] = 11110;	$PetLevelExp[9] = 2779;	$SpiritLevelExp[9] = 4104;	$TrumpLevelUp_Exp[10] = 5450;
$LeveTxt[11] = "11级"; $HappyLv[11] = 150;	 $LevelExp[11] = 480;		$MercenaryLevelExp[11] = 15730;	$PetLevelExp[10] = 3931;	$SpiritLevelExp[10] = 5754;	$TrumpLevelUp_Exp[11] = 7200;
$LeveTxt[12] = "12级"; $HappyLv[12] = 152;	 $LevelExp[12] = 590;		$MercenaryLevelExp[12] = 18501;	$PetLevelExp[11] = 4622;	$SpiritLevelExp[11] = 6289;	$TrumpLevelUp_Exp[12] = 9370;
$LeveTxt[13] = "13级"; $HappyLv[13] = 154;	 $LevelExp[13] = 700;		$MercenaryLevelExp[13] = 21217;	$PetLevelExp[12] = 5317;	$SpiritLevelExp[12] = 7799;	$TrumpLevelUp_Exp[13] = 12210;
$LeveTxt[14] = "14级"; $HappyLv[14] = 156;	 $LevelExp[14] = 830;		$MercenaryLevelExp[14] = 24188;	$PetLevelExp[13] = 6059;	$SpiritLevelExp[13] = 9462;	$TrumpLevelUp_Exp[14] = 15910;
$LeveTxt[15] = "15级"; $HappyLv[15] = 158;	 $LevelExp[15] = 1000;		$MercenaryLevelExp[15] = 27645;	$PetLevelExp[14] = 6909;	$SpiritLevelExp[14] = 12371;	$TrumpLevelUp_Exp[15] = 20720;
$LeveTxt[16] = "16级"; $HappyLv[16] = 160;	 $LevelExp[16] = 1230;		$MercenaryLevelExp[16] = 31103;	$PetLevelExp[15] = 7751;	$SpiritLevelExp[15] = 17225;	$TrumpLevelUp_Exp[16] = 27000;
$LeveTxt[17] = "17级"; $HappyLv[17] = 162;	 $LevelExp[17] = 1560;		$MercenaryLevelExp[17] = 34699;	$PetLevelExp[16] = 8708;	$SpiritLevelExp[16] = 20151;	$TrumpLevelUp_Exp[17] = 31490;
$LeveTxt[18] = "18级"; $HappyLv[18] = 164;	 $LevelExp[18] = 2040;		$MercenaryLevelExp[18] = 38555;	$PetLevelExp[17] = 9649;	$SpiritLevelExp[17] = 25236;	$TrumpLevelUp_Exp[18] = 36740;
$LeveTxt[19] = "19级"; $HappyLv[19] = 166;	 $LevelExp[19] = 2750;		$MercenaryLevelExp[19] = 42900;	$PetLevelExp[18] = 10713;	$SpiritLevelExp[18] = 28709;	$TrumpLevelUp_Exp[19] = 42850;
$LeveTxt[20] = "20级"; $HappyLv[20] = 168;	 $LevelExp[20] = 3850;		$MercenaryLevelExp[20] = 56577;	$PetLevelExp[19] = 14145;	$SpiritLevelExp[19] = 56878;	$TrumpLevelUp_Exp[20] = 49990;
$LeveTxt[21] = "21级"; $HappyLv[21] = 170;	 $LevelExp[21] = 5210;		$MercenaryLevelExp[21] = 72547;	$PetLevelExp[20] = 18064;	$SpiritLevelExp[20] = 90488;	$TrumpLevelUp_Exp[21] = 58320;
$LeveTxt[22] = "22级"; $HappyLv[22] = 172;	 $LevelExp[22] = 6880;		$MercenaryLevelExp[22] = 79001;	$PetLevelExp[21] = 19870;	$SpiritLevelExp[21] = 94849;	$TrumpLevelUp_Exp[22] = 68030;
$LeveTxt[23] = "23级"; $HappyLv[23] = 174;	 $LevelExp[23] = 8920;		$MercenaryLevelExp[23] = 86121;	$PetLevelExp[22] = 21543;	$SpiritLevelExp[22] = 105411;	$TrumpLevelUp_Exp[23] = 79360;
$LeveTxt[24] = "24级"; $HappyLv[24] = 176;	 $LevelExp[24] = 11410;		$MercenaryLevelExp[24] = 93567;	$PetLevelExp[23] = 23282;	$SpiritLevelExp[23] = 110044;	$TrumpLevelUp_Exp[24] = 92580;
$LeveTxt[25] = "25级"; $HappyLv[25] = 178;	 $LevelExp[25] = 14410;		$MercenaryLevelExp[25] = 100888;	$PetLevelExp[24] = 25208;	$SpiritLevelExp[24] = 121423;	$TrumpLevelUp_Exp[25] = 108000;
$LeveTxt[26] = "26级"; $HappyLv[26] = 180;	 $LevelExp[26] = 17920;		$MercenaryLevelExp[26] = 108646;	$PetLevelExp[25] = 27086;	$SpiritLevelExp[25] = 133348;
$LeveTxt[27] = "27级"; $HappyLv[27] = 182;	 $LevelExp[27] = 22010;		$MercenaryLevelExp[27] = 116754;	$PetLevelExp[26] = 29160;	$SpiritLevelExp[26] = 138526;
$LeveTxt[28] = "28级"; $HappyLv[28] = 184;	 $LevelExp[28] = 26760;		$MercenaryLevelExp[28] = 125887;	$PetLevelExp[27] = 31310;	$SpiritLevelExp[27] = 151268;
$LeveTxt[29] = "29级"; $HappyLv[29] = 186;	 $LevelExp[29] = 32260;		$MercenaryLevelExp[29] = 133584;	$PetLevelExp[28] = 33399;	$SpiritLevelExp[28] = 164555;
$LeveTxt[30] = "30级"; $HappyLv[30] = 188;	 $LevelExp[30] = 138600;		$MercenaryLevelExp[30] = 224571;	$PetLevelExp[29] = 51061;	$SpiritLevelExp[29] = 270199;
$LeveTxt[31] = "31级"; $HappyLv[31] = 190;	 $LevelExp[31] = 155400;		$MercenaryLevelExp[31] = 273898;	$PetLevelExp[30] = 62086;	$SpiritLevelExp[30] = 398973;
$LeveTxt[32] = "32级"; $HappyLv[32] = 192;	 $LevelExp[32] = 173380;		$MercenaryLevelExp[32] = 290001;	$PetLevelExp[31] = 66058;	$SpiritLevelExp[31] = 430673;
$LeveTxt[33] = "33级"; $HappyLv[33] = 194;	 $LevelExp[33] = 192590;		$MercenaryLevelExp[33] = 307105;	$PetLevelExp[32] = 69927;	$SpiritLevelExp[32] = 463552;
$LeveTxt[34] = "34级"; $HappyLv[34] = 196;	 $LevelExp[34] = 213060;		$MercenaryLevelExp[34] = 326121;	$PetLevelExp[33] = 74137;	$SpiritLevelExp[33] = 477706;
$LeveTxt[35] = "35级"; $HappyLv[35] = 198;	 $LevelExp[35] = 234860;		$MercenaryLevelExp[35] = 359654;	$PetLevelExp[34] = 78232;	$SpiritLevelExp[34] = 1293510;
$LeveTxt[36] = "36级"; $HappyLv[36] = 200;	 $LevelExp[36] = 258010;		$MercenaryLevelExp[36] = 380015;	$PetLevelExp[35] = 82682;	$SpiritLevelExp[35] = 2207802;
$LeveTxt[37] = "37级"; $HappyLv[37] = 202;	 $LevelExp[37] = 282580;		$MercenaryLevelExp[37] = 401215;	$PetLevelExp[36] = 87254;	$SpiritLevelExp[36] = 2356849;
$LeveTxt[38] = "38级"; $HappyLv[38] = 204;	 $LevelExp[38] = 308600;		$MercenaryLevelExp[38] = 421632;	$PetLevelExp[37] = 91691;	$SpiritLevelExp[37] = 4111084;
$LeveTxt[39] = "39级"; $HappyLv[39] = 206;	 $LevelExp[39] = 336140;		$MercenaryLevelExp[39] = 443584;	$PetLevelExp[38] = 96503;	$SpiritLevelExp[38] = 4370701;
$LeveTxt[40] = "40级"; $HappyLv[40] = 208;	 $LevelExp[40] = 605230;		$MercenaryLevelExp[40] = 568014;	$PetLevelExp[39] = 137114;	$SpiritLevelExp[39] = 5436789;
$LeveTxt[41] = "41级"; $HappyLv[41] = 210;	 $LevelExp[41] = 694330;		$MercenaryLevelExp[41] = 647154;	$PetLevelExp[40] = 155727;	$SpiritLevelExp[40] = 6594852;
$LeveTxt[42] = "42级"; $HappyLv[42] = 212;	 $LevelExp[42] = 801700;		$MercenaryLevelExp[42] = 788513;	$PetLevelExp[41] = 185155;	$SpiritLevelExp[41] = 6756689;
$LeveTxt[43] = "43级"; $HappyLv[43] = 214;	 $LevelExp[43] = 931480;		$MercenaryLevelExp[43] = 964754;	$PetLevelExp[42] = 246692;	$SpiritLevelExp[42] = 9428677;
$LeveTxt[44] = "44级"; $HappyLv[44] = 216;	 $LevelExp[44] = 1088730;		$MercenaryLevelExp[44] = 1204514;	$PetLevelExp[43] = 291784;	$SpiritLevelExp[43] = 9950769;
$LeveTxt[45] = "45级"; $HappyLv[45] = 218;	 $LevelExp[45] = 1279640;		$MercenaryLevelExp[45] = 1615420;	$PetLevelExp[44] = 342218;	$SpiritLevelExp[44] = 12150251;
$LeveTxt[46] = "46级"; $HappyLv[46] = 220;	 $LevelExp[46] = 1511750;		$MercenaryLevelExp[46] = 1955240;	$PetLevelExp[45] = 372581;	$SpiritLevelExp[45] = 14852300;
$LeveTxt[47] = "47级"; $HappyLv[47] = 222;	 $LevelExp[47] = 1794290;		$MercenaryLevelExp[47] = 2125441;	$PetLevelExp[46] = 405638;	$SpiritLevelExp[46] = 15623321;
$LeveTxt[48] = "48级"; $HappyLv[48] = 224;	 $LevelExp[48] = 2138500;		$MercenaryLevelExp[48] = 2305465;	$PetLevelExp[47] = 441628;	$SpiritLevelExp[47] = 20311458;
$LeveTxt[49] = "49级"; $HappyLv[49] = 226;	 $LevelExp[49] = 2558100;		$MercenaryLevelExp[49] = 2625599;	$PetLevelExp[48] = 480811;	$SpiritLevelExp[48] = 21329309;
$LeveTxt[50] = "50级"; $HappyLv[50] = 228;	 $LevelExp[50] = 3763730;		$MercenaryLevelExp[50] = 2920412;	$PetLevelExp[49] = 523470;	$SpiritLevelExp[49] = 22796678;
$LeveTxt[51] = "51级"; $HappyLv[51] = 230;	 $LevelExp[51] = 4520800;		$MercenaryLevelExp[51] = 3063124;	$PetLevelExp[50] = 569915;
$LeveTxt[52] = "52级"; $HappyLv[52] = 232;	 $LevelExp[52] = 5546790;		$MercenaryLevelExp[52] = 3221548;	$PetLevelExp[51] = 620480;
$LeveTxt[53] = "53级"; $HappyLv[53] = 234;	 $LevelExp[53] = 6946330;		$MercenaryLevelExp[53] = 3515419;	$PetLevelExp[52] = 675531;
$LeveTxt[54] = "54级"; $HappyLv[54] = 236;	 $LevelExp[54] = 8864360;		$MercenaryLevelExp[54] = 3826548;	$PetLevelExp[53] = 735467;
$LeveTxt[55] = "55级"; $HappyLv[55] = 238;	 $LevelExp[55] = 11501550;		$MercenaryLevelExp[55] = 4325654;	$PetLevelExp[54] = 800721;
$LeveTxt[56] = "56级"; $HappyLv[56] = 240;	 $LevelExp[56] = 14544130;		$MercenaryLevelExp[56] = 4706983;	$PetLevelExp[55] = 871764;
$LeveTxt[57] = "57级"; $HappyLv[57] = 242;	 $LevelExp[57] = 18044280;		$MercenaryLevelExp[57] = 5120120;	$PetLevelExp[56] = 949111;
$LeveTxt[58] = "58级"; $HappyLv[58] = 244;	 $LevelExp[58] = 22060710;		$MercenaryLevelExp[58] = 5574125;	$PetLevelExp[57] = 1033320;
$LeveTxt[59] = "59级"; $HappyLv[59] = 246;	 $LevelExp[59] = 26659500;		$MercenaryLevelExp[59] = 6074129;	$PetLevelExp[58] = 1125000;
$LeveTxt[60] = "60级"; $HappyLv[60] = 248;	 $LevelExp[60] = 35774290;		$MercenaryLevelExp[60] = 8425248;	$PetLevelExp[59] = 1203113;
$LeveTxt[61] = "61级"; $HappyLv[61] = 250;	 $LevelExp[61] = 41940020;		$MercenaryLevelExp[61] = 9550210;	$PetLevelExp[60] = 1364681;
$LeveTxt[62] = "62级"; $HappyLv[62] = 252;	 $LevelExp[62] = 48728390;		$MercenaryLevelExp[62] = 10834541;	$PetLevelExp[61] = 1547947;
$LeveTxt[63] = "63级"; $HappyLv[63] = 254;	 $LevelExp[63] = 56186240;		$MercenaryLevelExp[63] = 12290745;	$PetLevelExp[62] = 1755824;
$LeveTxt[64] = "64级"; $HappyLv[64] = 256;	 $LevelExp[64] = 64363790;		$MercenaryLevelExp[64] = 13945518;	$PetLevelExp[63] = 1991618;
$LeveTxt[65] = "65级"; $HappyLv[65] = 258;	 $LevelExp[65] = 73314830;		$MercenaryLevelExp[65] = 16375042;	$PetLevelExp[64] = 2259077;
$LeveTxt[66] = "66级"; $HappyLv[66] = 260;	 $LevelExp[66] = 82998120;		$MercenaryLevelExp[66] = 18574152;	$PetLevelExp[65] = 2562453;
$LeveTxt[67] = "67级"; $HappyLv[67] = 262;	 $LevelExp[67] = 93456640;		$MercenaryLevelExp[67] = 21075111;	$PetLevelExp[66] = 2906570;
$LeveTxt[68] = "68级"; $HappyLv[68] = 264;	 $LevelExp[68] = 104735740;		$MercenaryLevelExp[68] = 23901225;	$PetLevelExp[67] = 3296900;
$LeveTxt[69] = "69级"; $HappyLv[69] = 266;	 $LevelExp[69] = 116883300;		$MercenaryLevelExp[69] = 27116245;	$PetLevelExp[68] = 3739648;
$LeveTxt[70] = "70级"; $HappyLv[70] = 268;	 $LevelExp[70] = 146833200;		$MercenaryLevelExp[70] = 40668671;	$PetLevelExp[69] = 7199406;
$LeveTxt[71] = "71级"; $HappyLv[71] = 270;	 $LevelExp[71] = 162011180;		$MercenaryLevelExp[71] = 48802405;	$PetLevelExp[70] = 8078014;
$LeveTxt[72] = "72级"; $HappyLv[72] = 272;	 $LevelExp[72] = 178225500;		$MercenaryLevelExp[72] = 58562886;	$PetLevelExp[71] = 8311502;
$LeveTxt[73] = "73级"; $HappyLv[73] = 274;	 $LevelExp[73] = 195526620;		$MercenaryLevelExp[73] = 70275463;	$PetLevelExp[72] = 8530976;
$LeveTxt[74] = "74级"; $HappyLv[74] = 276;	 $LevelExp[74] = 213967340;		$MercenaryLevelExp[74] = 84330555;	$PetLevelExp[73] = 8762088;
$LeveTxt[75] = "75级"; $HappyLv[75] = 278;	 $LevelExp[75] = 233602860;		$MercenaryLevelExp[75] = 101196666;	$PetLevelExp[74] = 14731061;
$LeveTxt[76] = "76级"; $HappyLv[76] = 280;	 $LevelExp[76] = 249639570;		$MercenaryLevelExp[76] = 121435999;	$PetLevelExp[75] = 15119611;
$LeveTxt[77] = "77级"; $HappyLv[77] = 282;	 $LevelExp[77] = 263085550;		$MercenaryLevelExp[77] = 145723199;	$PetLevelExp[76] = 15513217;
$LeveTxt[78] = "78级"; $HappyLv[78] = 284;	 $LevelExp[78] = 274668120;		$MercenaryLevelExp[78] = 174867839;	$PetLevelExp[77] = 15911880;
$LeveTxt[79] = "79级"; $HappyLv[79] = 286;	 $LevelExp[79] = 284911480;		$MercenaryLevelExp[79] = 209841407;	$PetLevelExp[78] = 16315598;
$LeveTxt[80] = "80级"; $HappyLv[80] = 288;	 $LevelExp[80] = 338191020;		$MercenaryLevelExp[80] = 314762110;	$PetLevelExp[79] = 22448338;
$LeveTxt[81] = "81级"; $HappyLv[81] = 290;	 $LevelExp[81] = 352251560;		$MercenaryLevelExp[81] = 409190744;	$PetLevelExp[80] = 24927836;
$LeveTxt[82] = "82级"; $HappyLv[82] = 292;	 $LevelExp[82] = 369516250;		$MercenaryLevelExp[82] = 531947967;	$PetLevelExp[81] = 25535246;
$LeveTxt[83] = "83级"; $HappyLv[83] = 294;	 $LevelExp[83] = 392178200;		$MercenaryLevelExp[83] = 691532357;	$PetLevelExp[82] = 26128300;
$LeveTxt[84] = "84级"; $HappyLv[84] = 296;	 $LevelExp[84] = 423926360;		$MercenaryLevelExp[84] = 898992064;	$PetLevelExp[83] = 26771993;
$LeveTxt[85] = "85级"; $HappyLv[85] = 298;	 $LevelExp[85] = 470962450;		$MercenaryLevelExp[85] = 1168689683;	$PetLevelExp[84] = 36146708;
$LeveTxt[86] = "86级"; $HappyLv[86] = 300;	 $LevelExp[86] = 521998110;		$MercenaryLevelExp[86] = 1519296588;	$PetLevelExp[85] = 37016517;
$LeveTxt[87] = "87级"; $HappyLv[87] = 302;	 $LevelExp[87] = 577326670;		$MercenaryLevelExp[87] = 1975085564;	$PetLevelExp[86] = 37866683;
$LeveTxt[88] = "88级"; $HappyLv[88] = 304;	 $LevelExp[88] = 637262180;		$MercenaryLevelExp[88] = 2567611233;	$PetLevelExp[87] = 38726498;
$LeveTxt[89] = "89级"; $HappyLv[89] = 306;	 $LevelExp[89] = 702140820;		$MercenaryLevelExp[89] = 3337894603;	$PetLevelExp[88] = 39595963;
$LeveTxt[90] = "90级"; $HappyLv[90] = 308;	 $LevelExp[90] = 1253134750;		$MercenaryLevelExp[90] = 4339262984;	$PetLevelExp[89] = 56072086;
$LeveTxt[91] = "91级"; $HappyLv[91] = 310;	 $LevelExp[91] = 1346939110;		$MercenaryLevelExp[91] = 4773189283;	$PetLevelExp[90] = 58650113;
$LeveTxt[92] = "92级"; $HappyLv[92] = 312;	 $LevelExp[92] = 1449128670;		$MercenaryLevelExp[92] = 5250508211;	$PetLevelExp[91] = 59909527;
$LeveTxt[93] = "93级"; $HappyLv[93] = 314;	 $LevelExp[93] = 1560554790;		$MercenaryLevelExp[93] = 5775559032;	$PetLevelExp[92] = 61182309;
$LeveTxt[94] = "94级"; $HappyLv[94] = 316;	 $LevelExp[94] = 1682152860;		$MercenaryLevelExp[94] = 6353114935;	$PetLevelExp[93] = 62513334;
$LeveTxt[95] = "95级"; $HappyLv[95] = 318;	 $LevelExp[95] = 1814950350;		$MercenaryLevelExp[95] = 6988426429;	$PetLevelExp[94] = 81224563;
$LeveTxt[96] = "96级"; $HappyLv[96] = 320;	 $LevelExp[96] = 1956394480;		$MercenaryLevelExp[96] = 7687269072;	$PetLevelExp[95] = 82954607;
$LeveTxt[97] = "97级"; $HappyLv[97] = 322;	 $LevelExp[97] = 2106982940;		$MercenaryLevelExp[97] = 8455995979;	$PetLevelExp[96] = 84643937;
$LeveTxt[98] = "98级"; $HappyLv[98] = 324;	 $LevelExp[98] = 2267240870;		$MercenaryLevelExp[98] = 9301595577;	$PetLevelExp[97] = 86290729;
$LeveTxt[99] = "99级"; $HappyLv[99] = 326;	 $LevelExp[99] = 2437722290;		$MercenaryLevelExp[99] = 10231755134;	$PetLevelExp[98] = 88073641;
$LeveTxt[100] = "100级"; $HappyLv[100] = 328;  $LevelExp[100] = 2717764810;	$MercenaryLevelExp[100] = 11254930648;	$PetLevelExp[99] = 93211095;
$LeveTxt[101] = "101级"; $HappyLv[101] = 330;  $LevelExp[101] = 2717764810;	$MercenaryLevelExp[101] = 12278106162;
$LeveTxt[102] = "102级"; $HappyLv[102] = 332;  $LevelExp[102] = 2717764810;	$MercenaryLevelExp[102] = 13301281676;
$LeveTxt[103] = "103级"; $HappyLv[103] = 334;  $LevelExp[103] = 2717764810;	$MercenaryLevelExp[103] = 14324457190;
$LeveTxt[104] = "104级"; $HappyLv[104] = 336;  $LevelExp[104] = 2717764810;	$MercenaryLevelExp[104] = 15347632704;
$LeveTxt[105] = "105级"; $HappyLv[105] = 338;  $LevelExp[105] = 2717764810;	$MercenaryLevelExp[105] = 16370808218;
$LeveTxt[106] = "106级"; $HappyLv[106] = 340;  $LevelExp[106] = 2717764810;	$MercenaryLevelExp[106] = 17393983732;
$LeveTxt[107] = "107级"; $HappyLv[107] = 342;  $LevelExp[107] = 2717764810;	$MercenaryLevelExp[107] = 18417159246;
$LeveTxt[108] = "108级"; $HappyLv[108] = 344;  $LevelExp[108] = 2717764810;	$MercenaryLevelExp[108] = 19440334760;
$LeveTxt[109] = "109级"; $HappyLv[109] = 346;  $LevelExp[109] = 2717764810;	$MercenaryLevelExp[109] = 20463510274;
$LeveTxt[110] = "110级"; $HappyLv[110] = 348;  $LevelExp[110] = 2717764810;	$MercenaryLevelExp[110] = 21486685788;
$LeveTxt[111] = "111级"; $HappyLv[111] = 350;  $LevelExp[111] = 2717764810;
$LeveTxt[112] = "112级"; $HappyLv[112] = 352;  $LevelExp[112] = 2717764810;
$LeveTxt[113] = "113级"; $HappyLv[113] = 354;  $LevelExp[113] = 2717764810;
$LeveTxt[114] = "114级"; $HappyLv[114] = 356;  $LevelExp[114] = 2717764810;
$LeveTxt[115] = "115级"; $HappyLv[115] = 358;  $LevelExp[115] = 2717764810;
$LeveTxt[116] = "116级"; $HappyLv[116] = 360;  $LevelExp[116] = 2717764810;
$LeveTxt[117] = "117级"; $HappyLv[117] = 362;  $LevelExp[117] = 2717764810;
$LeveTxt[118] = "118级"; $HappyLv[118] = 364;  $LevelExp[118] = 2717764810;
$LeveTxt[119] = "119级"; $HappyLv[119] = 366;  $LevelExp[119] = 2717764810;
$LeveTxt[120] = "120级"; $HappyLv[120] = 368;  $LevelExp[120] = 2717764810;

SetExpScriptVariable();
//■■■■■■■■■■■人物神兽化身升级所需的经验■■■■■■■■■■■■■■■


//■■■■■■■■■■■特殊配方给于的道具■■■■■■■■■■■■■■■■■■■
$Pres_To_AddItem[632001001] = 18;
$Pres_To_AddItem[632001001,1] = 110010001;
$Pres_To_AddItem[632001001,2] = 110010011;
$Pres_To_AddItem[632001001,3] = 110010021;
$Pres_To_AddItem[632001001,4] = 110010031;
$Pres_To_AddItem[632001001,5] = 110010041;
$Pres_To_AddItem[632001001,6] = 110010051;
$Pres_To_AddItem[632001001,7] = 110010061;
$Pres_To_AddItem[632001001,8] = 110010071;
$Pres_To_AddItem[632001001,9] = 110010081;
$Pres_To_AddItem[632001001,10] = 110010091;
$Pres_To_AddItem[632001001,11] = 110010101;
$Pres_To_AddItem[632001001,12] = 110010111;
$Pres_To_AddItem[632001001,13] = 110010121;
$Pres_To_AddItem[632001001,14] = 110010131;
$Pres_To_AddItem[632001001,15] = 110010141;
$Pres_To_AddItem[632001001,16] = 110010151;
$Pres_To_AddItem[632001001,17] = 110010161;
$Pres_To_AddItem[632001001,18] = 110010171;

$Pres_To_AddItem[632001002] = 7;
$Pres_To_AddItem[632001002,1] = 110020001;
$Pres_To_AddItem[632001002,2] = 110020011;
$Pres_To_AddItem[632001002,3] = 110020021;
$Pres_To_AddItem[632001002,4] = 110020031;
$Pres_To_AddItem[632001002,5] = 110020041;
$Pres_To_AddItem[632001002,6] = 110020051;
$Pres_To_AddItem[632001002,7] = 110020061;

$Pres_To_AddItem[632001003] = 6;
$Pres_To_AddItem[632001003,1] = 110030001;
$Pres_To_AddItem[632001003,2] = 110030011;
$Pres_To_AddItem[632001003,3] = 110030021;
$Pres_To_AddItem[632001003,4] = 110030031;
$Pres_To_AddItem[632001003,5] = 110030041;
$Pres_To_AddItem[632001003,6] = 110030051;
//■■■■■■■■■■■特殊配方给于的道具■■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■各个Data相关位置■■■■■■■■■■■■■■■■■■■■
//怪物
//名称
$Monster_Data_Name = 1;
//属性标志
$Monster_Data_Type = 10;
//人物经验
$Monster_Data_PlayerExp = 22;
//神兽经验
$Monster_Data_PetExp = 23;
//化身经验
$Monster_Data_YuanShenExp = 24;
//受益范围
$Monster_Data_ExpArea = 33;


//道具
//道具名称
$Item_Data_Name = 1;
//道具大类
$Item_Data_Big_Index = 2;
//备用字段，配方编号
$Item_Data_PresID = 17;
//颜色等级
$Item_Data_Color = 20;
//属性标志
$Item_Data_Type = 23;
//装备或使用的等级限制
$Item_Data_Lv = 25;

//任务
//编号
$Mission_Data_Mid = 0;
//类型
$Mission_Data_Type = 1;
//前置任务
$Mission_Data_PreMid = 2;
//名称
$Mission_Data_Name = 3;
//归属地图
$Mission_Data_Map_Area = 4;
//接Lv
$Mission_Data_LvA = 5;
//交Lv
$Mission_Data_LvZ = 6;
//建Lv
$Mission_Data_LvJ = 7;
//区A
$Mission_Data_SeeLvA = 8;
//区Z
$Mission_Data_SeeLvZ = 9;
//起始NPC
$Mission_Data_NpcA = 10;
//中途对话NPC
$Mission_Data_NpcX = 11;
//结束NPC
$Mission_Data_NpcZ = 12;
//接任务给予道具
$Mission_Data_ItemAdd = 13;
//任务道具扣除
$Mission_Data_ItemDelete = 14;
//杀怪
$Mission_Data_KillMonster = 15;
//取物
$Mission_Data_ItemGet = 16;
//采集物
$Mission_Data_Cj = 17;
//特殊触发
$Mission_Data_EspeciallyTrigger = 18;
//特殊旗标
$Mission_Data_ItemUseTarget = 19;
//添加状态
$Mission_Data_X_Man = 20;
//难度指数
$Mission_Data_NanDu = 21;
//积分
$Mission_Data_JiFen = 22;
//经验
$Mission_Data_Exp = 23;
//元宝
$Mission_Data_Money = 24;
//金币
$Mission_Data_Yuan = 25;
//帮派奖励
$Mission_Data_ShengWang = 26;
//选择性道具奖励
$Mission_Data_ItemChose = 27;
//必给道具
$Mission_Data_ItemSet = 28;
//根据职业给予道具
$Mission_Data_ItemClasses = 29;
//根据职业技能奖励
$Mission_Data_Skill = 30;
//状态奖励
$Mission_Data_Buff = 31;
//接交时特殊需求
$Mission_Data_Conv = 32;
//门阀条件
$Mission_Data_Family = 33;
//职业条件
$Mission_Data_Classes = 34;
//出生圣地条件
$Mission_Data_Homeplace = 35;
//后续任务
$Mission_Data_PostMid = 36;
//预留1
$Mission_Data_OtherRecordA = 37;
//预留2
$Mission_Data_OtherRecordB = 38;

//配方Data
//配方编号
$PrescriptionData_ID = 0;
//配方类别
$PrescriptionData_Type_A = 1;
//配方子类别
$PrescriptionData_Type_B = 2;
//配方等级
$PrescriptionData_Lv = 3;
//所需活力
$PrescriptionData_HuoLi = 4;
//悟性要求
$PrescriptionData_WuXin = 5;
//生活技能编号
$PrescriptionData_LiveSkill = 6;
//所需金钱
$PrescriptionData_Money = 7;
//消耗道具子类别
$PrescriptionData_Item_Type = 8;
//描述
$PrescriptionData_Help = 9;
//材料编号1
$PrescriptionData_ItemID_A = 10;
//材料数量1
$PrescriptionData_Num_A = 11;
//材料编号2
$PrescriptionData_ItemID_B = 12;
//材料数量2
$PrescriptionData_Num_B = 13;
//材料编号3
$PrescriptionData_ItemID_C = 14;
//材料数量3
$PrescriptionData_Num_C = 15;
//材料编号4
$PrescriptionData_ItemID_D = 16;
//材料数量4
$PrescriptionData_Num_D = 17;
//材料编号5
$PrescriptionData_ItemID_E = 18;
//材料数量5
$PrescriptionData_Num_E = 19;
//材料编号6
$PrescriptionData_ItemID_F = 20;
//材料数量6
$PrescriptionData_Num_F = 21;
//基础产出物品编号
$PrescriptionData_OutItem = 22;
//前置脚本判断
$PrescriptionData_CanDo = 23;
//一次产出个数
$PrescriptionData_OutNum = 24;
//配方名称
$PrescriptionData_PresIDName = 25;
//吟唱提示文本
$PrescriptionData_Say = 26;
//学习配方所需技能熟练度
$PrescriptionData_Exp = 27;
//奖励熟练度
$PrescriptionData_JiangLiExp = 28;


//■■■■■■■■■■■各个Data相关位置■■■■■■■■■■■■■■■■■■■■



//■■■■■首座论经题库■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
$HuoDong_BJCCC_MaxQuestionNum = 640;
$HuoDong_BJCCC_A[1] = false;	$HuoDong_BJCCC_Q[1] = "血液温度低的动物就是冷血动物";
$HuoDong_BJCCC_A[2] = false;	$HuoDong_BJCCC_Q[2] = "最早的血压计用于测量牛的血压";
$HuoDong_BJCCC_A[3] = true;	$HuoDong_BJCCC_Q[3] = "美国历史上第一所高等学府是哈佛大学";
$HuoDong_BJCCC_A[4] = true;	$HuoDong_BJCCC_Q[4] = "西印度群岛位于大西洋西部";
$HuoDong_BJCCC_A[5] = false;	$HuoDong_BJCCC_Q[5] = "根据空气密度与高度的关系把大气分为3层";
$HuoDong_BJCCC_A[6] = false;	$HuoDong_BJCCC_Q[6] = "企鹅一般在12月份产卵";
$HuoDong_BJCCC_A[7] = false;	$HuoDong_BJCCC_Q[7] = "1831年爱迪生发现了电磁感应原理，奠定了发电机的理论基础";
$HuoDong_BJCCC_A[8] = false;	$HuoDong_BJCCC_Q[8] = "人体需要的营养素中，在各种营养素中排行第七的营养素是维生素";
$HuoDong_BJCCC_A[9] = false;	$HuoDong_BJCCC_Q[9] = "动漫起源于日本";
$HuoDong_BJCCC_A[10] = true;	$HuoDong_BJCCC_Q[10] = "一般认为，北宋风俗画，《清明上河图》描绘的是春天的景象";
$HuoDong_BJCCC_A[11] = false;	$HuoDong_BJCCC_Q[11] = "荧光显微镜可以获得三维图象";
$HuoDong_BJCCC_A[12] = false;	$HuoDong_BJCCC_Q[12] = "太阳光光中含有不可见光";
$HuoDong_BJCCC_A[13] = true;	$HuoDong_BJCCC_Q[13] = "绿叶和红叶都可以进行光合作用";
$HuoDong_BJCCC_A[14] = true;	$HuoDong_BJCCC_Q[14] = "心理学可以帮助人们科学地描述、解释、预测一定情境下人的所感、所思、所为。";
$HuoDong_BJCCC_A[15] = false;	$HuoDong_BJCCC_Q[15] = "葡萄糖是白色晶体";
$HuoDong_BJCCC_A[16] = true;	$HuoDong_BJCCC_Q[16] = "全球环境恶化的主要表现首先是水质变坏";
$HuoDong_BJCCC_A[17] = false;	$HuoDong_BJCCC_Q[17] = "发展“三色农业”首先要发展绿色农业";
$HuoDong_BJCCC_A[18] = true;	$HuoDong_BJCCC_Q[18] = "生物技术被认为是21世纪最具前景的核心技术";
$HuoDong_BJCCC_A[19] = false;	$HuoDong_BJCCC_Q[19] = "古筝比古琴的弦更多";
$HuoDong_BJCCC_A[20] = false;	$HuoDong_BJCCC_Q[20] = "电能是用途最广泛的能源之一，它属于可再生能源";
$HuoDong_BJCCC_A[21] = true;	$HuoDong_BJCCC_Q[21] = "阿尔卑斯山脉的最高峰是勃朗峰";
$HuoDong_BJCCC_A[22] = true;	$HuoDong_BJCCC_Q[22] = "“塔”属于佛教建筑。";
$HuoDong_BJCCC_A[23] = true;	$HuoDong_BJCCC_Q[23] = "光学玻璃的“光学”是指专门为制造光学仪器而制";
$HuoDong_BJCCC_A[24] = true;	$HuoDong_BJCCC_Q[24] = "水上芭蕾又称花样游泳";
$HuoDong_BJCCC_A[25] = false;	$HuoDong_BJCCC_Q[25] = "最早能制造工具的人类被称为智人";
$HuoDong_BJCCC_A[26] = true;	$HuoDong_BJCCC_Q[26] = "20世纪四项重大发明是原子能、半导体、计算机和激光器";
$HuoDong_BJCCC_A[27] = true;	$HuoDong_BJCCC_Q[27] = "广义相对论认为太阳周围的时间和空间会发生弯曲";
$HuoDong_BJCCC_A[28] = true;	$HuoDong_BJCCC_Q[28] = "中国象棋的双方各有7种棋子";
$HuoDong_BJCCC_A[29] = true;	$HuoDong_BJCCC_Q[29] = "就目前观察，宇宙空间含量最多的元素是氢元素";
$HuoDong_BJCCC_A[30] = true;	$HuoDong_BJCCC_Q[30] = "盎司既是重量单位又是容量单位";
$HuoDong_BJCCC_A[31] = true;	$HuoDong_BJCCC_Q[31] = "可持续发展的基本内容主要包括强调发展、强调协调和强调公平";
$HuoDong_BJCCC_A[32] = true;	$HuoDong_BJCCC_Q[32] = "按照相对论，物体长度是变化的";
$HuoDong_BJCCC_A[33] = true;	$HuoDong_BJCCC_Q[33] = "五角星的每个角度数是36度";
$HuoDong_BJCCC_A[34] = true;	$HuoDong_BJCCC_Q[34] = "世界最重要的IT高科技产业基地硅谷位于美国的加利弗尼亚州";
$HuoDong_BJCCC_A[35] = false;	$HuoDong_BJCCC_Q[35] = "白炽灯用久了会发黑是因为长时间高温灼烧";
$HuoDong_BJCCC_A[36] = false;	$HuoDong_BJCCC_Q[36] = "玻璃钢是通过玻璃和钢结合而成的";
$HuoDong_BJCCC_A[37] = false;	$HuoDong_BJCCC_Q[37] = "我国南方的梅雨属于对流雨";
$HuoDong_BJCCC_A[38] = false;	$HuoDong_BJCCC_Q[38] = "诺贝尔奖的创立人是瑞士人";
$HuoDong_BJCCC_A[39] = false;	$HuoDong_BJCCC_Q[39] = "防止电磁辐射的方法是屏蔽防护和隔离防护";
$HuoDong_BJCCC_A[40] = true;	$HuoDong_BJCCC_Q[40] = "变频空调节电效果突出，所谓“变频”一般是指直流变频";
$HuoDong_BJCCC_A[41] = true;	$HuoDong_BJCCC_Q[41] = "我国自主研发的3G技术标准是TD-SCDMA";
$HuoDong_BJCCC_A[42] = true;	$HuoDong_BJCCC_Q[42] = "吃太多手摇爆米花机爆出的米花会导致铅中毒";
$HuoDong_BJCCC_A[43] = true;	$HuoDong_BJCCC_Q[43] = "邓小平理论形成的社会实践基础是改革开放和社会主义现代化";
$HuoDong_BJCCC_A[44] = true;	$HuoDong_BJCCC_Q[44] = "大学生未完成教学计划规定的全部课程，中途自愿退学者被称为肆业生";
$HuoDong_BJCCC_A[45] = true;	$HuoDong_BJCCC_Q[45] = "电波是物质";
$HuoDong_BJCCC_A[46] = true;	$HuoDong_BJCCC_Q[46] = "地球上的氧气与太阳有关";
$HuoDong_BJCCC_A[47] = false;	$HuoDong_BJCCC_Q[47] = "“高山流水”来源于俞伯牙与钟子期的故事，钟子期擅长弹奏琴弦成为另一方的知音";
$HuoDong_BJCCC_A[48] = false;	$HuoDong_BJCCC_Q[48] = "国际象棋起源于英国";
$HuoDong_BJCCC_A[49] = false;	$HuoDong_BJCCC_Q[49] = "金属钾平时应保存在水中";
$HuoDong_BJCCC_A[50] = true;	$HuoDong_BJCCC_Q[50] = "居里夫人是著名的科学家，她获得过诺贝尔物理奖和诺贝尔化学奖";
$HuoDong_BJCCC_A[51] = true;	$HuoDong_BJCCC_Q[51] = "目前一些城市的公交车和出租车使用LPG清洁燃料，LPG是液化石油气";
$HuoDong_BJCCC_A[52] = true;	$HuoDong_BJCCC_Q[52] = "黄昏时面向太阳，你的左手方是南方";
$HuoDong_BJCCC_A[53] = false;	$HuoDong_BJCCC_Q[53] = "电子计算机发明于1964年";
$HuoDong_BJCCC_A[54] = true;	$HuoDong_BJCCC_Q[54] = "煤油温度计比水银温度计适合在较寒冷的地区使用";
$HuoDong_BJCCC_A[55] = false;	$HuoDong_BJCCC_Q[55] = "英国伦敦“大本钟”的名字是来自地名";
$HuoDong_BJCCC_A[56] = true;	$HuoDong_BJCCC_Q[56] = "计算机病毒有潜伏性，它可能会长时间潜伏，遇到一定条件才开始进行破坏活动";
$HuoDong_BJCCC_A[57] = false;	$HuoDong_BJCCC_Q[57] = "“科学技术是第一生产力”的真谛是把经济搞上去";
$HuoDong_BJCCC_A[58] = false;	$HuoDong_BJCCC_Q[58] = "根据我国宪法的规定，下列机关中全国人大有权制定行政法规";
$HuoDong_BJCCC_A[59] = false;	$HuoDong_BJCCC_Q[59] = "科学发展观的本质特征是可持续性";
$HuoDong_BJCCC_A[60] = true;	$HuoDong_BJCCC_Q[60] = "三字经的派别是儒家";
$HuoDong_BJCCC_A[61] = false;	$HuoDong_BJCCC_Q[61] = "有“钢琴诗人”之称的是贝多芬";
$HuoDong_BJCCC_A[62] = true;	$HuoDong_BJCCC_Q[62] = "人们睡觉的时候选择南北方向比选择东西方向更有益于健康";
$HuoDong_BJCCC_A[63] = false;	$HuoDong_BJCCC_Q[63] = "在我们居住的北半球上，冬天冷夏天热这一自然现象的主要原因是海洋暖流";
$HuoDong_BJCCC_A[64] = false; $HuoDong_BJCCC_Q[64] = "太阳表面温度大约为100万摄氏度";
$HuoDong_BJCCC_A[65] = true;	$HuoDong_BJCCC_Q[65] = "接天莲叶无穷碧，映日荷花别样红——《晓出净慈寺送林子方》  杨万里";
$HuoDong_BJCCC_A[66] = true;	$HuoDong_BJCCC_Q[66] = "在经济衰退时期，有利于扩大内需的政策措施是降低税率";
$HuoDong_BJCCC_A[67] = false;	$HuoDong_BJCCC_Q[67] = "我们感冒时，常会感到呼吸不畅，主要原因是鼻粘膜分泌液过多";
$HuoDong_BJCCC_A[68] = true;	$HuoDong_BJCCC_Q[68] = "目前核电站对核能的利用方式分为核聚变和核裂变两种 ";
$HuoDong_BJCCC_A[69] = true;	$HuoDong_BJCCC_Q[69] = "《小狗圆舞曲》又名《一分钟圆舞曲》,是波兰伟大的音乐家肖邦所作";
$HuoDong_BJCCC_A[70] = false;	$HuoDong_BJCCC_Q[70] = "可燃冰是一种稀缺的能源资源";
$HuoDong_BJCCC_A[71] = false;	$HuoDong_BJCCC_Q[71] = "新录用公务员的试用期6个月";
$HuoDong_BJCCC_A[72] = false;	$HuoDong_BJCCC_Q[72] = "法国作家中，和雨果齐名的另一位伟大作家是莫泊桑";
$HuoDong_BJCCC_A[73] = false;	$HuoDong_BJCCC_Q[73] = "针灸中的“灸”是指用针扎刺人体穴位";
$HuoDong_BJCCC_A[74] = false;	$HuoDong_BJCCC_Q[74] = "关于宇宙的起源，最具代表性、影响最大的理论是黑洞理论";
$HuoDong_BJCCC_A[75] = false;	$HuoDong_BJCCC_Q[75] = "鸡蛋带壳在微波炉中加热比较好，这样受热更快更均匀";
$HuoDong_BJCCC_A[76] = true;	$HuoDong_BJCCC_Q[76] = "细胞工程是在细胞水平上的生物工程，细胞工程所使用的技术主要是细胞养殖和细胞融合";
$HuoDong_BJCCC_A[77] = true;	$HuoDong_BJCCC_Q[77] = "法国的国鸟是公鸡";
$HuoDong_BJCCC_A[78] = true;	$HuoDong_BJCCC_Q[78] = "打嗝时，喝醋能立即使之停止";
$HuoDong_BJCCC_A[79] = true;	$HuoDong_BJCCC_Q[79] = "麻雀属于地球上最高等的生物";
$HuoDong_BJCCC_A[80] = false;	$HuoDong_BJCCC_Q[80] = "提出需要层次理论的是斯金纳";
$HuoDong_BJCCC_A[81] = false;	$HuoDong_BJCCC_Q[81] = "新中国第一颗人造地球卫星发射成功在1971年";
$HuoDong_BJCCC_A[82] = false;	$HuoDong_BJCCC_Q[82] = "“四书五经”中的“四书”指的是《尚书》、《礼记》、《周易》、《春秋》";
$HuoDong_BJCCC_A[83] = false;	$HuoDong_BJCCC_Q[83] = "世界各国的研发占GDP的比例最高的三国家为：美国、德国、法国";
$HuoDong_BJCCC_A[84] = false;	$HuoDong_BJCCC_Q[84] = "尼罗河、阿姆河、印度河都是古代文明的摇篮";
$HuoDong_BJCCC_A[85] = false;	$HuoDong_BJCCC_Q[85] = "围棋中黑白棋子各有180枚";
$HuoDong_BJCCC_A[86] = true;	$HuoDong_BJCCC_Q[86] = "避雷针的作用是美国科学家富兰克林发现的";
$HuoDong_BJCCC_A[87] = true;	$HuoDong_BJCCC_Q[87] = "钓鱼岛从明朝开始就明确为我国的领土";
$HuoDong_BJCCC_A[88] = true;	$HuoDong_BJCCC_Q[88] = "歌曲《小白菜》是河北民歌";
$HuoDong_BJCCC_A[89] = true;	$HuoDong_BJCCC_Q[89] = "轮胎是黑色可以增加轮胎耐磨性";
$HuoDong_BJCCC_A[90] = true;	$HuoDong_BJCCC_Q[90] = "《安娜.卡列尼娜》是托尔斯泰的作品";
$HuoDong_BJCCC_A[91] = true;	$HuoDong_BJCCC_Q[91] = "大气可分为对流层 平流层 中层 热层 逃逸层 电离层 磁层";
$HuoDong_BJCCC_A[92] = false;	$HuoDong_BJCCC_Q[92] = "水壶中积有大量水垢，长期饮用此壶中水的人易得心血管疾病";
$HuoDong_BJCCC_A[93] = false;	$HuoDong_BJCCC_Q[93] = "奥斯林洛夫斯基《钢铁是怎样炼成的》，奥斯林洛夫斯基是俄罗斯人";
$HuoDong_BJCCC_A[94] = false;	$HuoDong_BJCCC_Q[94] = "人体的“百会穴”在脑前部";
$HuoDong_BJCCC_A[95] = false;	$HuoDong_BJCCC_Q[95] = "跳竹杆是我国苗族的传统体育运动";
$HuoDong_BJCCC_A[96] = false;	$HuoDong_BJCCC_Q[96] = "非洲国家边界按河流、山脉等自然地貌的最多";
$HuoDong_BJCCC_A[97] = false;	$HuoDong_BJCCC_Q[97] = "电影艺术诞生于1859年";
$HuoDong_BJCCC_A[98] = true;	$HuoDong_BJCCC_Q[98] = "高速铁路的列车行驶速度要求每小时达到200公里以上的";
$HuoDong_BJCCC_A[99] = false;	$HuoDong_BJCCC_Q[99] = "天文学家把全天空的星星按区域划分成176个星座";
$HuoDong_BJCCC_A[100] = false; 	$HuoDong_BJCCC_Q[100] = "我国最东边的城市是黑龙江的漠河市";
$HuoDong_BJCCC_A[101] = false; 	$HuoDong_BJCCC_Q[101] = "人们常用六音概称我国传统的民族器乐";
$HuoDong_BJCCC_A[102] = false;     $HuoDong_BJCCC_Q[102] = "中国银行是我国金融机构的领导力量，是我国政府的组成部分";
$HuoDong_BJCCC_A[103] = true;	    $HuoDong_BJCCC_Q[103] = "西伯利亚的房屋一般都是歪歪斜斜的，这是因为大风吹的结果";
$HuoDong_BJCCC_A[104] = false; 	$HuoDong_BJCCC_Q[104] = "水能资源最丰富的地区是中南地区";
$HuoDong_BJCCC_A[105] = true;	    $HuoDong_BJCCC_Q[105] = "下半旗是把旗子下降到距离杆顶的三分之一处";
$HuoDong_BJCCC_A[106] = true;	    $HuoDong_BJCCC_Q[106] = "1950年，35岁的美国曼哈顿信贷专家麦克纳马拉发明了信用卡";
$HuoDong_BJCCC_A[107] = false; 	$HuoDong_BJCCC_Q[107] = "《中国少年先锋队队歌》是电影《红孩子》的主题曲";
$HuoDong_BJCCC_A[108] = false; 	$HuoDong_BJCCC_Q[108] = "《边城》是长篇小说代表作";
$HuoDong_BJCCC_A[109] = true;	    $HuoDong_BJCCC_Q[109] = "世界上最大的洋是太平洋，最大的海是：珊瑚海";
$HuoDong_BJCCC_A[110] = true;	    $HuoDong_BJCCC_Q[110] = "人体中最先衰老的器官是胸腺";
$HuoDong_BJCCC_A[111] = false; 	$HuoDong_BJCCC_Q[111] = "绿茶属于发酵茶";
$HuoDong_BJCCC_A[112] = true;	    $HuoDong_BJCCC_Q[112] = "血液占成人体重的7-8%";
$HuoDong_BJCCC_A[113] = true;	    $HuoDong_BJCCC_Q[113] = "歌曲《滚滚长江东逝水》,是电视连续剧《三国演义》片头歌。";
$HuoDong_BJCCC_A[114] = false; 	$HuoDong_BJCCC_Q[114] = "用齿轮传动不能改变运动的方向";
$HuoDong_BJCCC_A[115] = true;	    $HuoDong_BJCCC_Q[115] = "国际货币基金组织是联合国的专门机构";
$HuoDong_BJCCC_A[116] = false; 	$HuoDong_BJCCC_Q[116] = "中国在南极设立的第一个考察站叫中山站";
$HuoDong_BJCCC_A[117] = true;	    $HuoDong_BJCCC_Q[117] = "神话产生在文字发明以前。神话中充满了丰富的想象，是中国浪漫主义文学的源头";
$HuoDong_BJCCC_A[118] = true;	    $HuoDong_BJCCC_Q[118] = "香槟酒是葡萄酒";
$HuoDong_BJCCC_A[119] = false; 	$HuoDong_BJCCC_Q[119] = "蒙古国是上海合作组织的成员国之一";
$HuoDong_BJCCC_A[120] = true;	    $HuoDong_BJCCC_Q[120] = "我国大陆轮廓基本形成的地质时代是岩浆活动";
$HuoDong_BJCCC_A[121] = true;	    $HuoDong_BJCCC_Q[121] = "第一次探索月球的阿波罗号在飞离地球4天后到达月球";
$HuoDong_BJCCC_A[122] = true;	    $HuoDong_BJCCC_Q[122] = "世界上国家中，加纳有黄金海岸之称";
$HuoDong_BJCCC_A[123] = false; 	$HuoDong_BJCCC_Q[123] = "夏威夷在地理位置上属于北美洲";
$HuoDong_BJCCC_A[124] = true;	    $HuoDong_BJCCC_Q[124] = "据考古资料显示，我国的钻孔技术开始于山顶洞人时代";
$HuoDong_BJCCC_A[125] = false; 	$HuoDong_BJCCC_Q[125] = "月蚀发生时月球在地球和太阳之间";
$HuoDong_BJCCC_A[126] = false; 	$HuoDong_BJCCC_Q[126] = "人体最大的解毒器官是肾脏";
$HuoDong_BJCCC_A[127] = false; 	$HuoDong_BJCCC_Q[127] = "根据我国宪法的规定，下列机关中全国人大有权制定行政法规";
$HuoDong_BJCCC_A[128] = true;	    $HuoDong_BJCCC_Q[128] = "在经济衰退时期，有利于扩大内需的政策措施是降低税率";
$HuoDong_BJCCC_A[129] = false; 	$HuoDong_BJCCC_Q[129] = "蒙古国是上海合作组织的成员国之一";
$HuoDong_BJCCC_A[130] = true;	    $HuoDong_BJCCC_Q[130] = "国际货币基金组织是联合国的专门机构";
$HuoDong_BJCCC_A[131] = true;	    $HuoDong_BJCCC_Q[131] = "法国的国鸟是公鸡";
$HuoDong_BJCCC_A[132] = true;	    $HuoDong_BJCCC_Q[132] = "钓鱼岛从明朝开始就明确为我国的领土";
$HuoDong_BJCCC_A[133] = false; 	$HuoDong_BJCCC_Q[133] = "跳竹杆是我国苗族的传统体育运动";
$HuoDong_BJCCC_A[134] = false; 	$HuoDong_BJCCC_Q[134] = "新录用公务员的试用期6个月";
$HuoDong_BJCCC_A[135] = false; 	$HuoDong_BJCCC_Q[135] = "中国银行是我国金融机构的领导力量，是我国政府的组成部分";
$HuoDong_BJCCC_A[136] = true; 	$HuoDong_BJCCC_Q[136] = "三字经的派别是儒家";
$HuoDong_BJCCC_A[137] = false; 	$HuoDong_BJCCC_Q[137] = "“厄尔尼诺”一股很强的暖洋流，科学分析会导致全球气候的升高";
$HuoDong_BJCCC_A[138] = true;	    $HuoDong_BJCCC_Q[138] = "世界上冰最多的地区是南极大陆";
$HuoDong_BJCCC_A[139] = true;	    $HuoDong_BJCCC_Q[139] = "鸟晚上是睡在树林里的";
$HuoDong_BJCCC_A[140] = false; 	$HuoDong_BJCCC_Q[140] = "人不惑之年是指50岁";
$HuoDong_BJCCC_A[141] = false; 	$HuoDong_BJCCC_Q[141] = "中秋节是我们中华民族所独有的佳节";
$HuoDong_BJCCC_A[142] = false; 	$HuoDong_BJCCC_Q[142] = "我国儒学的创始人是孟子";
$HuoDong_BJCCC_A[143] = true;	    $HuoDong_BJCCC_Q[143] = "最早的宗教是佛教";
$HuoDong_BJCCC_A[144] = true;	    $HuoDong_BJCCC_Q[144] = "黄山四绝是指奇松、怪石、云海、温泉";
$HuoDong_BJCCC_A[145] = false; 	$HuoDong_BJCCC_Q[145] = "刑警指刑事警察、主要任务是处置突发性的刑事、治安案件";
$HuoDong_BJCCC_A[146] = false; 	$HuoDong_BJCCC_Q[146] = "在我国被誉为跳水皇后是高敏";
$HuoDong_BJCCC_A[147] = true;	    $HuoDong_BJCCC_Q[147] = "绿色食品是指营养无公害的食品产品";
$HuoDong_BJCCC_A[148] = false; 	$HuoDong_BJCCC_Q[148] = "世界上最硬的物质是碳";
$HuoDong_BJCCC_A[149] = true;	    $HuoDong_BJCCC_Q[149] = "跑得最快的鸟是鸵鸟";
$HuoDong_BJCCC_A[150] = true;	    $HuoDong_BJCCC_Q[150] = "最大的动物是蓝鲸";
$HuoDong_BJCCC_A[151] = true;	    $HuoDong_BJCCC_Q[151] = "啄木鸟是有名的森林“外科医生”";
$HuoDong_BJCCC_A[152] = false; 	$HuoDong_BJCCC_Q[152] = "飞得最高的鸟是海鸥";
$HuoDong_BJCCC_A[153] = true;	    $HuoDong_BJCCC_Q[153] = "嗅觉最灵敏的动物是狗，其嗅觉细胞达22亿个";
$HuoDong_BJCCC_A[154] = false; 	$HuoDong_BJCCC_Q[154] = "跑得最快的动物是东北虎";
$HuoDong_BJCCC_A[155] = true;	    $HuoDong_BJCCC_Q[155] = "大象是寿命最长的哺乳动物";
$HuoDong_BJCCC_A[156] = true;	    $HuoDong_BJCCC_Q[156] = "口技专家是对“乌鸦”的美称";
$HuoDong_BJCCC_A[157] = false; 	$HuoDong_BJCCC_Q[157] = "世界上第一次发生鸟撞飞机是1902年";
$HuoDong_BJCCC_A[158] = true;	    $HuoDong_BJCCC_Q[158] = "含油最多的树是油棕，被称为“世界油王”";
$HuoDong_BJCCC_A[159] = false; 	$HuoDong_BJCCC_Q[159] = "花生的原产地是美国";
$HuoDong_BJCCC_A[160] = true;	    $HuoDong_BJCCC_Q[160] = "历史最长的树是有海化石之称的银杏";
$HuoDong_BJCCC_A[161] = true;	    $HuoDong_BJCCC_Q[161] = "森林的别称有“工厂”“屏障”等";
$HuoDong_BJCCC_A[162] = false; 	$HuoDong_BJCCC_Q[162] = "中国历史上最早称皇帝的夏禹";
$HuoDong_BJCCC_A[163] = true;	    $HuoDong_BJCCC_Q[163] = "中国历史上最后一个皇帝是清朝的宣统皇帝";
$HuoDong_BJCCC_A[164] = true;	    $HuoDong_BJCCC_Q[164] = "指南针是利用磁铁的南北极性而制成的一种指示方向的仪器";
$HuoDong_BJCCC_A[165] = true;	    $HuoDong_BJCCC_Q[165] = "北京故宫旧称“紫禁城”";
$HuoDong_BJCCC_A[166] = true; 	$HuoDong_BJCCC_Q[166] = "徐志摩的名诗《再别康桥》中的“康桥”是指今天的剑桥大学";
$HuoDong_BJCCC_A[167] = false; 	$HuoDong_BJCCC_Q[167] = "月球是地球唯一的行星";
$HuoDong_BJCCC_A[168] = true;	    $HuoDong_BJCCC_Q[168] = "世界上冰最多的地区是南极大陆";
$HuoDong_BJCCC_A[169] = false; 	$HuoDong_BJCCC_Q[169] = "地球的平均半径为63710千米";
$HuoDong_BJCCC_A[170] = false; 	$HuoDong_BJCCC_Q[170] = "世界上最长的国歌是科威特的国歌";
$HuoDong_BJCCC_A[171] = false; 	$HuoDong_BJCCC_Q[171] = "我国现代的第一篇白话小说是鲁迅作的《呐喊》";
$HuoDong_BJCCC_A[172] = true;	    $HuoDong_BJCCC_Q[172] = "十二生肖中的子时是指23点——1点";
$HuoDong_BJCCC_A[173] = true;	    $HuoDong_BJCCC_Q[173] = "意大利米兰凯旋门是1807年为纪念拿破仑征服意大利而建的";
$HuoDong_BJCCC_A[174] = true;	    $HuoDong_BJCCC_Q[174] = "黄山四绝是指奇松、怪石、云海、温泉";
$HuoDong_BJCCC_A[175] = true; 	$HuoDong_BJCCC_Q[175] = "我国的植树节是公历3月12日";
$HuoDong_BJCCC_A[176] = true;	    $HuoDong_BJCCC_Q[176] = "早上人的身高比晚上要矮";
$HuoDong_BJCCC_A[177] = true;	    $HuoDong_BJCCC_Q[177] = "卫生球所含的萘是致癌物质";
$HuoDong_BJCCC_A[178] = true;	    $HuoDong_BJCCC_Q[178] = "空气中发现的第一个惰性气体是氖";
$HuoDong_BJCCC_A[179] = false; 	$HuoDong_BJCCC_Q[179] = "月球是地球唯一的行星";
$HuoDong_BJCCC_A[180] = true;	    $HuoDong_BJCCC_Q[180] = "空气中发现的第一个惰性气体是氖";
$HuoDong_BJCCC_A[181] = false; 	$HuoDong_BJCCC_Q[181] = "“厄尔尼诺”一股很强的暖洋流，科学分析会导致全球气候的升高";
$HuoDong_BJCCC_A[182] = true;	    $HuoDong_BJCCC_Q[182] = "世界上冰最多的地区是南极大陆";
$HuoDong_BJCCC_A[183] = true;	    $HuoDong_BJCCC_Q[183] = "鸟晚上是睡在树林里的";
$HuoDong_BJCCC_A[184] = false; 	$HuoDong_BJCCC_Q[184] = "人不惑之年是指50岁";
$HuoDong_BJCCC_A[185] = false; 	$HuoDong_BJCCC_Q[185] = "中秋节是我们中华民族所独有的佳节";
$HuoDong_BJCCC_A[186] = false; 	$HuoDong_BJCCC_Q[186] = "我国儒学的创始人是孟子";
$HuoDong_BJCCC_A[187] = true;	    $HuoDong_BJCCC_Q[187] = "最早的宗教是佛教";
$HuoDong_BJCCC_A[188] = true;	    $HuoDong_BJCCC_Q[188] = "交响曲是大型管弦乐曲、通常有四个乐章";
$HuoDong_BJCCC_A[189] = false; 	$HuoDong_BJCCC_Q[189] = "刑警指刑事警察、主要任务是处置突发性的刑事、治安案件";
$HuoDong_BJCCC_A[190] = false; 	$HuoDong_BJCCC_Q[190] = "在我国被誉为跳水皇后是高敏";
$HuoDong_BJCCC_A[191] = true; 	$HuoDong_BJCCC_Q[191] = "绿色食品是指营养无公害的食品产品";
$HuoDong_BJCCC_A[192] = false; 	$HuoDong_BJCCC_Q[192] = "世界上最硬的物质是碳";
$HuoDong_BJCCC_A[193] = true;	    $HuoDong_BJCCC_Q[193] = "跑得最快的鸟是鸵鸟";
$HuoDong_BJCCC_A[194] = true;	    $HuoDong_BJCCC_Q[194] = "最大的动物是蓝鲸";
$HuoDong_BJCCC_A[195] = true;	    $HuoDong_BJCCC_Q[195] = "啄木鸟是有名的森林“外科医生”";
$HuoDong_BJCCC_A[196] = false; 	$HuoDong_BJCCC_Q[196] = "飞得最高的鸟是海鸥";
$HuoDong_BJCCC_A[197] = true;	    $HuoDong_BJCCC_Q[197] = "嗅觉最灵敏的动物是狗，其嗅觉细胞达22亿个";
$HuoDong_BJCCC_A[198] = false; 	$HuoDong_BJCCC_Q[198] = "跑得最快的动物是东北虎";
$HuoDong_BJCCC_A[199] = true;	    $HuoDong_BJCCC_Q[199] = "大象是寿命最长的哺乳动物";
$HuoDong_BJCCC_A[200] = true;	    $HuoDong_BJCCC_Q[200] = "口技专家是对“乌鸦”的美称";
$HuoDong_BJCCC_A[201] = false; 	$HuoDong_BJCCC_Q[201] = "世界上第一次发生鸟撞飞机是1902年";
$HuoDong_BJCCC_A[202] = true;	    $HuoDong_BJCCC_Q[202] = "含油最多的树是油棕，被称为“世界油王”";
$HuoDong_BJCCC_A[203] = false; 	$HuoDong_BJCCC_Q[203] = "花生的原产地是美国";
$HuoDong_BJCCC_A[204] = true;	    $HuoDong_BJCCC_Q[204] = "历史最长的树是有海化石之称的银杏";
$HuoDong_BJCCC_A[205] = true;	    $HuoDong_BJCCC_Q[205] = "森林的别称有“工厂”“屏障”等";
$HuoDong_BJCCC_A[206] = false; 	$HuoDong_BJCCC_Q[206] = "中国历史上最早称皇帝的夏禹";
$HuoDong_BJCCC_A[207] = true;	    $HuoDong_BJCCC_Q[207] = "中国历史上最后一个皇帝是清朝的宣统皇帝";
$HuoDong_BJCCC_A[208] = true;	    $HuoDong_BJCCC_Q[208] = "指南针是利用磁铁的南北极性而制成的一种指示方向的仪器";
$HuoDong_BJCCC_A[209] = true;	    $HuoDong_BJCCC_Q[209] = "北京故宫旧称“紫禁城”";
$HuoDong_BJCCC_A[210] = true;	    $HuoDong_BJCCC_Q[210] = "光年是计量宇宙间天体之间距离的单位";
$HuoDong_BJCCC_A[211] = true;	    $HuoDong_BJCCC_Q[211] = "世界上冰最多的地区是南极大陆";
$HuoDong_BJCCC_A[212] = false; 	$HuoDong_BJCCC_Q[212] = "地球的平均半径为63710千米";
$HuoDong_BJCCC_A[213] = false; 	$HuoDong_BJCCC_Q[213] = "世界上最长的国歌是科威特的国歌";
$HuoDong_BJCCC_A[214] = true;	    $HuoDong_BJCCC_Q[214] = "金庸先生曾用两句诗概括他的武侠作品，上句是“飞雪连天射白鹿”，下句是“笑书神侠倚碧鸳”";
$HuoDong_BJCCC_A[215] = false; 	$HuoDong_BJCCC_Q[215] = "有这样一句话“京口瓜州一水间”，京口就是现在的苏州";
$HuoDong_BJCCC_A[216] = false; 	$HuoDong_BJCCC_Q[216] = "中国古代科举制度考试，殿试一甲第一名成为状元，一甲第二名、第三名分别称榜眼、探花";
$HuoDong_BJCCC_A[217] = true;	    $HuoDong_BJCCC_Q[217] = "古诗文常提到“花中四君子”，分别是梅、兰、竹、桂";
$HuoDong_BJCCC_A[218] = false; 	$HuoDong_BJCCC_Q[218] = "社会人物复杂多样称“三教九流”，“三教九流”中的“三教”原指儒家、道家、释家";
$HuoDong_BJCCC_A[219] = false; 	$HuoDong_BJCCC_Q[219] = "明朝时期，科举制度完备，考试分为四级，院试、乡试、会试、殿试";
$HuoDong_BJCCC_A[220] = false; 	$HuoDong_BJCCC_Q[220] = "我国古代四大爱情传说是牛郎织女传说、孟姜女传说、梁祝传说、白蛇传说";
$HuoDong_BJCCC_A[221] = false; 	$HuoDong_BJCCC_Q[221] = "出堂四届是指王勃、杨炯、卢照邻、骆宾王";
$HuoDong_BJCCC_A[222] = true;	    $HuoDong_BJCCC_Q[222] = "莎士比亚的四大悲剧是【《李尔王》、《哈姆雷特》、《奥塞罗》、《罗密欧与茱丽叶》";
$HuoDong_BJCCC_A[223] = true;	    $HuoDong_BJCCC_Q[223] = "“黑夜给了我黑色的眼睛，我却用它寻找光明”的作者是汪国真";
$HuoDong_BJCCC_A[224] = true;	    $HuoDong_BJCCC_Q[224] = "第一次世界大战以同盟国集团的失败而告终";
$HuoDong_BJCCC_A[225] = true;	    $HuoDong_BJCCC_Q[225] = "日本在二战中，制造了震惊中外的“南京大屠杀”";
$HuoDong_BJCCC_A[226] = false; 	$HuoDong_BJCCC_Q[226] = "植物生长所需要的营养都是从土壤中得来的";
$HuoDong_BJCCC_A[227] = true;	    $HuoDong_BJCCC_Q[227] = "文学史上被称为“诗鬼”的是唐代诗人李贺";
$HuoDong_BJCCC_A[228] = true;	    $HuoDong_BJCCC_Q[228] = "称赞王维“诗中有画，画中有诗”的是苏轼";
$HuoDong_BJCCC_A[229] = false; 	$HuoDong_BJCCC_Q[229] = "《搜神记》是一部志怪小说集，作者是东晋的干宝";
$HuoDong_BJCCC_A[230] = false; 	$HuoDong_BJCCC_Q[230] = "“春花秋月何时了，往事知多少？”语出我国女词人李清照的《虞美人》";
$HuoDong_BJCCC_A[231] = false; 	$HuoDong_BJCCC_Q[231] = "文学史上的“苏辛”是婉约词派苏轼、辛弃疾的合称";
$HuoDong_BJCCC_A[232] = false; 	$HuoDong_BJCCC_Q[232] = "提出文章“合为时而著，歌诗合为事而作”文学主张的是杜甫";
$HuoDong_BJCCC_A[233] = false; 	$HuoDong_BJCCC_Q[233] = "张君瑞和崔莺莺是元曲戏曲《西厢记》中的主要人物";
$HuoDong_BJCCC_A[234] = true;	    $HuoDong_BJCCC_Q[234] = "古人用于天干、地支纪年，天干有12个，地支有10个";
$HuoDong_BJCCC_A[235] = true;	    $HuoDong_BJCCC_Q[235] = "《圣经》分为《新约》和《旧约》两部分";
$HuoDong_BJCCC_A[236] = true;	    $HuoDong_BJCCC_Q[236] = "《三国演义》中刘禅的亲身母亲是吴国孙权的妹妹孙尚香";
$HuoDong_BJCCC_A[237] = false; 	$HuoDong_BJCCC_Q[237] = "奥地利作者茨威格写有小说《一个女人一生中的二十四小时》";
$HuoDong_BJCCC_A[238] = false; 	$HuoDong_BJCCC_Q[238] = "美国作家海明威写的《老人与海》表现了“硬汉性格”";
$HuoDong_BJCCC_A[239] = true;	    $HuoDong_BJCCC_Q[239] = "法国作家小仲马的小说《三个火枪手》是以17世纪路易十三当国王时为背景";
$HuoDong_BJCCC_A[240] = true; 	$HuoDong_BJCCC_Q[240] = "我国古代研究茶道的最早理论著作是陆羽的《茶经》";
$HuoDong_BJCCC_A[241] = true;	    $HuoDong_BJCCC_Q[241] = "长篇小说《叶甫盖尼·奥捏金》的作者是俄国作家屠格涅夫";
$HuoDong_BJCCC_A[242] = true; 	$HuoDong_BJCCC_Q[242] = "巴尔扎克的小说总集《人间喜剧》中收到《高老头》《欧也妮葛朗台》等";
$HuoDong_BJCCC_A[243] = false; 	$HuoDong_BJCCC_Q[243] = "古希腊有个喜剧家曾被称为“戏剧艺术的荷马”他就是索福克勒斯，他写有《俄狄浦斯王》";
$HuoDong_BJCCC_A[244] = true;	    $HuoDong_BJCCC_Q[244] = "当代李时珍写的《本草纲目》是我国古代医书";
$HuoDong_BJCCC_A[245] = false; 	$HuoDong_BJCCC_Q[245] = "意大利作家薄迦丘写的《十日谈》中共讲了一百个故事";
$HuoDong_BJCCC_A[246] = true;	    $HuoDong_BJCCC_Q[246] = "战国时期，所谓合纵连横的代表人物是苏秦、张仪，主张合纵的是张仪，主张连横的是苏秦";
$HuoDong_BJCCC_A[247] = false; 	$HuoDong_BJCCC_Q[247] = "“关关雎鸠，在河之洲，窈窕淑女，君子好逑”是出自《诗经》的第一篇";
$HuoDong_BJCCC_A[248] = false; 	$HuoDong_BJCCC_Q[248] = "《稼轩长短句》是南宋诗人辛弃疾的诗集";
$HuoDong_BJCCC_A[249] = true; 	$HuoDong_BJCCC_Q[249] = "《史记》的作者司马迁曾遭受宫刑";
$HuoDong_BJCCC_A[250] = true;	    $HuoDong_BJCCC_Q[250] = "膑刑是古代一种剔去膝盖骨的一种酷刑。战国是的孙膑曾受此刑";
$HuoDong_BJCCC_A[251] = true;	    $HuoDong_BJCCC_Q[251] = "中国历史上有关官职变动有很多说法。其中左迁表示升官";
$HuoDong_BJCCC_A[252] = false; 	$HuoDong_BJCCC_Q[252] = "车裂是中国古代一种残酷的刑罚。又叫“五马分尸”，历史上商鞅曾受此刑";
$HuoDong_BJCCC_A[253] = false; 	$HuoDong_BJCCC_Q[253] = "“晓看红湿处，花重锦官城”中“锦官城”是指现在的成都";
$HuoDong_BJCCC_A[254] = true;	    $HuoDong_BJCCC_Q[254] = "南宋诗人林升有首诗叫《题临安邸》，“临安”就是现在的南京";
$HuoDong_BJCCC_A[255] = false; 	$HuoDong_BJCCC_Q[255] = "李白有一首诗，题为《送孟浩然之广陵》，“广陵”就是现在的扬州";
$HuoDong_BJCCC_A[256] = false; 	$HuoDong_BJCCC_Q[256] = "有这样一句话“姑苏城外寒山寺”，姑苏就是现在的常州";
$HuoDong_BJCCC_A[257] = false; 	$HuoDong_BJCCC_Q[257] = "现在许多资本主义国家都与我们友好往来，世界已经和平了";
$HuoDong_BJCCC_A[258] = true;	    $HuoDong_BJCCC_Q[258] = "拉丁美洲的居民以混血人种为主";
$HuoDong_BJCCC_A[259] = false; 	$HuoDong_BJCCC_Q[259] = "中华人民共和国国歌的词曲作者分别是田汉和冼星海";
$HuoDong_BJCCC_A[260] = true;	    $HuoDong_BJCCC_Q[260] = "“热岛”是指气候炎热的岛屿";
$HuoDong_BJCCC_A[261] = true;	    $HuoDong_BJCCC_Q[261] = "雨过天晴，天空悬浮着很多小水珠，它们将白色的阳光分散成七种颜色，形成彩虹";
$HuoDong_BJCCC_A[262] = true;	    $HuoDong_BJCCC_Q[262] = "西湖著名景点之一有三潭映月";
$HuoDong_BJCCC_A[263] = true;	    $HuoDong_BJCCC_Q[263] = "苏州、杭州的丝绸，苏州的刺绣在国内外都很出名";
$HuoDong_BJCCC_A[264] = false; 	$HuoDong_BJCCC_Q[264] = "美国的自由女神像是美国人自己制作的";
$HuoDong_BJCCC_A[265] = false; 	$HuoDong_BJCCC_Q[265] = "美国的星条旗上有14颗星星";
$HuoDong_BJCCC_A[266] = true;	    $HuoDong_BJCCC_Q[266] = "笛卡尔是法国数学家";
$HuoDong_BJCCC_A[267] = false; 	$HuoDong_BJCCC_Q[267] = "“三皇五帝”就是指封建社会的“皇帝“";
$HuoDong_BJCCC_A[268] = false; 	$HuoDong_BJCCC_Q[268] = "竹楼是黄土高原上一种传统的居民形式";
$HuoDong_BJCCC_A[269] = false; 	$HuoDong_BJCCC_Q[269] = "“厄尔尼诺”一股很强的暖洋流，科学分析会导致全球气候的升高";
$HuoDong_BJCCC_A[270] = true;	    $HuoDong_BJCCC_Q[270] = "世界上冰最多的地区是南极大陆";
$HuoDong_BJCCC_A[271] = true;	    $HuoDong_BJCCC_Q[271] = "鸟晚上是睡在树林里的";
$HuoDong_BJCCC_A[272] = true;	    $HuoDong_BJCCC_Q[272] = "跑得最快的鸟是鸵鸟";
$HuoDong_BJCCC_A[273] = true;	    $HuoDong_BJCCC_Q[273] = "最大的动物是蓝鲸";
$HuoDong_BJCCC_A[274] = true;	    $HuoDong_BJCCC_Q[274] = "啄木鸟是有名的森林“外科医生”";
$HuoDong_BJCCC_A[275] = false; 	$HuoDong_BJCCC_Q[275] = "飞得最高的鸟是海鸥";
$HuoDong_BJCCC_A[276] = true;	    $HuoDong_BJCCC_Q[276] = "嗅觉最灵敏的动物是狗，其嗅觉细胞达22亿个";
$HuoDong_BJCCC_A[277] = false; 	$HuoDong_BJCCC_Q[277] = "跑得最快的动物是东北虎";
$HuoDong_BJCCC_A[278] = true;	    $HuoDong_BJCCC_Q[278] = "大象是寿命最长的哺乳动物";
$HuoDong_BJCCC_A[279] = true;	    $HuoDong_BJCCC_Q[279] = "口技专家是对“乌鸦”的美称";
$HuoDong_BJCCC_A[280] = false; 	$HuoDong_BJCCC_Q[280] = "世界上第一次发生鸟撞飞机是1902年";
$HuoDong_BJCCC_A[281] = true;	    $HuoDong_BJCCC_Q[281] = "含油最多的树是油棕，被称为“世界油王”";
$HuoDong_BJCCC_A[282] = false; 	$HuoDong_BJCCC_Q[282] = "花生的原产地是美国";
$HuoDong_BJCCC_A[283] = true;	    $HuoDong_BJCCC_Q[283] = "历史最长的树是有海化石之称的银杏";
$HuoDong_BJCCC_A[284] = true;	    $HuoDong_BJCCC_Q[284] = "森林的别称有“工厂”“屏障”等";
$HuoDong_BJCCC_A[285] = true;	    $HuoDong_BJCCC_Q[285] = "乌拉尔山是跨大洲的山脉吗？";
$HuoDong_BJCCC_A[286] = true;	    $HuoDong_BJCCC_Q[286] = "汇入大西洋最长的河流是亚马逊河吗";
$HuoDong_BJCCC_A[287] = true;	    $HuoDong_BJCCC_Q[287] = "许多人都喜欢到低于海平面410公尺的死海去做日光浴是因为紫外线最弱";
$HuoDong_BJCCC_A[288] = true;	    $HuoDong_BJCCC_Q[288] = "“泾渭分明”指的是泾水清，渭水浊吗";
$HuoDong_BJCCC_A[289] = true;	    $HuoDong_BJCCC_Q[289] = "北极星处于天空中的小熊星座 ";
$HuoDong_BJCCC_A[290] = false; 	$HuoDong_BJCCC_Q[290] = "蛇毒作为药用具有麻醉功效";
$HuoDong_BJCCC_A[291] = false; 	$HuoDong_BJCCC_Q[291] = "海南岛是我国的第一大岛  ";
$HuoDong_BJCCC_A[292] = true;	    $HuoDong_BJCCC_Q[292] = "园艺上常根据顶端优势原理进行果树整枝修建";
$HuoDong_BJCCC_A[293] = true;	    $HuoDong_BJCCC_Q[293] = "世界天气的推动力是太阳";
$HuoDong_BJCCC_A[294] = false; 	$HuoDong_BJCCC_Q[294] = "地球自转是指地球围绕地心的运动";
$HuoDong_BJCCC_A[295] = true; 	$HuoDong_BJCCC_Q[295] = "煤炭中发热量最大的是无烟煤";
$HuoDong_BJCCC_A[296] = true; 	$HuoDong_BJCCC_Q[296] = "我国最大的佛像是——四川乐山大佛";
$HuoDong_BJCCC_A[297] = false; 	$HuoDong_BJCCC_Q[297] = "世界上最硬的物质是碳";
$HuoDong_BJCCC_A[298] = true;	    $HuoDong_BJCCC_Q[298] = "北京故宫旧称“紫禁城”";
$HuoDong_BJCCC_A[299] = true;	    $HuoDong_BJCCC_Q[299] = "徐志摩的名诗《再别康桥》中的“康桥”是指今天的剑桥大学";
$HuoDong_BJCCC_A[300] = false; 	$HuoDong_BJCCC_Q[300] = "地球的平均半径为63710千米";
$HuoDong_BJCCC_A[301] = false; 	$HuoDong_BJCCC_Q[301] = "世界上最长的国歌是科威特的国歌";
$HuoDong_BJCCC_A[302] = true;	    $HuoDong_BJCCC_Q[302] = "世界上生产玉米最多的国家是：美国";
$HuoDong_BJCCC_A[303] = true;	    $HuoDong_BJCCC_Q[303] = "一次性筷子的发明者：日本人";
$HuoDong_BJCCC_A[304] = false; 	$HuoDong_BJCCC_Q[304] = "送水节不是柬埔寨最隆重的节日";
$HuoDong_BJCCC_A[305] = false; 	$HuoDong_BJCCC_Q[305] = "中秋节是我们中华民族所独有的佳节";
$HuoDong_BJCCC_A[306] = false; 	$HuoDong_BJCCC_Q[306] = "我国儒学的创始人是孟子";
$HuoDong_BJCCC_A[307] = true;	    $HuoDong_BJCCC_Q[307] = "最早的宗教是佛教";
$HuoDong_BJCCC_A[308] = false; 	$HuoDong_BJCCC_Q[308] = "人不惑之年是指50岁";
$HuoDong_BJCCC_A[309] = true;	    $HuoDong_BJCCC_Q[309] = "交响曲是大型管弦乐曲、通常有四个乐章";
$HuoDong_BJCCC_A[310] = false; 	$HuoDong_BJCCC_Q[310] = "我国现代的第一篇白话小说是鲁迅作的《呐喊》";
$HuoDong_BJCCC_A[311] = true;	    $HuoDong_BJCCC_Q[311] = "十二生肖中的子时是指23点——1点";
$HuoDong_BJCCC_A[312] = false; 	$HuoDong_BJCCC_Q[312] = "火把节不是我国南方多个少数民族的共同节日";
$HuoDong_BJCCC_A[313] = true;	    $HuoDong_BJCCC_Q[313] = "博士后不是学位。";
$HuoDong_BJCCC_A[314] = true;	    $HuoDong_BJCCC_Q[314] = "“风筝”最早出现在清明上河图中";
$HuoDong_BJCCC_A[315] = true;	    $HuoDong_BJCCC_Q[315] = "墨绣起源于唐朝的刺绣工艺,墨绣所用的材料是头发";
$HuoDong_BJCCC_A[316] = true;	    $HuoDong_BJCCC_Q[316] = "道教创始于西汉时代。 (×) ﹒哲学一词最早来源于希腊";
$HuoDong_BJCCC_A[317] = true;	    $HuoDong_BJCCC_Q[317] = "中国历史上最早称皇帝的夏禹。（×）  ﹒中国历史上最后一个皇帝是清朝的宣统皇帝";
$HuoDong_BJCCC_A[318] = true;	    $HuoDong_BJCCC_Q[318] = "康熙皇帝的庙号是圣祖";
$HuoDong_BJCCC_A[319] = true;	    $HuoDong_BJCCC_Q[319] = "蒙文有出现在人民币上";
$HuoDong_BJCCC_A[320] = true;	    $HuoDong_BJCCC_Q[320] = "“席梦思”三个字源于人名 ";
$HuoDong_BJCCC_A[321] = false; 	$HuoDong_BJCCC_Q[321] = "在申请电子信箱时，如果想申请成功，也可以不同意网站要求用户承诺的协议书";
$HuoDong_BJCCC_A[322] = false; 	$HuoDong_BJCCC_Q[322] = "网民自己在家里录制的电视剧等电视节目，可以放到互联网上供其他人下载观看";
$HuoDong_BJCCC_A[323] = false; 	$HuoDong_BJCCC_Q[323] = "侵入任意的计算机信息系统，只要不修改或删除数据就不违法";
$HuoDong_BJCCC_A[324] = false; 	$HuoDong_BJCCC_Q[324] = "在网络投票中，利用刷票机或者购买刷票服务为自己喜欢的选手投票";
$HuoDong_BJCCC_A[325] = true;	    $HuoDong_BJCCC_Q[325] = "高射炮,主要是作 防 空 武 器";
$HuoDong_BJCCC_A[326] = false; 	$HuoDong_BJCCC_Q[326] = "飞航式导弹,飞行高度较高，隐蔽性强";
$HuoDong_BJCCC_A[327] = true;	    $HuoDong_BJCCC_Q[327] = "护卫舰是舰 艇装备最广泛的主力战 舰";
$HuoDong_BJCCC_A[328] = true;	    $HuoDong_BJCCC_Q[328] = "美国第一艘核动力航母是企业号";
$HuoDong_BJCCC_A[329] = true;	    $HuoDong_BJCCC_Q[329] = "两极格局解体对中国产生的机遇是中国对国际战略平衡作用增强";
$HuoDong_BJCCC_A[330] = false; 	$HuoDong_BJCCC_Q[330] = "两极格局的瓦解同前两次国际格局的变动相比,最大的不同点是由战胜国主宰国确立";
$HuoDong_BJCCC_A[331] = true;	    $HuoDong_BJCCC_Q[331] = "朝鲜半岛矛盾趋向缓和  ";
$HuoDong_BJCCC_A[332] = true;	    $HuoDong_BJCCC_Q[332] = "经济全球化的本质是资本在全球范围内的新一轮扩张";
$HuoDong_BJCCC_A[333] = false; 	$HuoDong_BJCCC_Q[333] = "知识经济既促进又阻碍经济全球化进程";
$HuoDong_BJCCC_A[334] = false; 	$HuoDong_BJCCC_Q[334] = "中国第一所大学是清华大学";
$HuoDong_BJCCC_A[335] = false; 	$HuoDong_BJCCC_Q[335] = "瑞士不是联合国成员国";
$HuoDong_BJCCC_A[336] = false; 	$HuoDong_BJCCC_Q[336] = "虫眼越多的菜说明没有施用农药，说明它更安全";
$HuoDong_BJCCC_A[337] = true;	    $HuoDong_BJCCC_Q[337] = "金庸的籍贯是浙江海宁";
$HuoDong_BJCCC_A[338] = true;	    $HuoDong_BJCCC_Q[338] = "“名不正则言不顺”是儒家的思想";
$HuoDong_BJCCC_A[339] = true;	    $HuoDong_BJCCC_Q[339] = "生铁又硬又脆是因为它含碳多对";
$HuoDong_BJCCC_A[340] = true;	    $HuoDong_BJCCC_Q[340] = "9.27重大铁路事故是发生在上海";
$HuoDong_BJCCC_A[341] = true;	    $HuoDong_BJCCC_Q[341] = "我国已经成为世界上烟草的第一消费大国和第二大烟草种植国";
$HuoDong_BJCCC_A[342] = true;	    $HuoDong_BJCCC_Q[342] = "日内瓦被称为“国际会议之都”";
$HuoDong_BJCCC_A[343] = false; 	$HuoDong_BJCCC_Q[343] = "美国迄今在任时间最长的总统是华盛顿";
$HuoDong_BJCCC_A[344] = false; 	$HuoDong_BJCCC_Q[344] = "地球上便于取用的淡水仅为总水量的 0.02％左右";
$HuoDong_BJCCC_A[345] = true;	    $HuoDong_BJCCC_Q[345] = "我国的森林覆盖率仅为13.9%";
$HuoDong_BJCCC_A[346] = false; 	$HuoDong_BJCCC_Q[346] = "信天游主要流行于我国山西地区";
$HuoDong_BJCCC_A[347] = false; 	$HuoDong_BJCCC_Q[347] = "泼水节是回族的节日";
$HuoDong_BJCCC_A[348] = false; 	$HuoDong_BJCCC_Q[348] = "五月六日是世界环境日";
$HuoDong_BJCCC_A[349] = true;	    $HuoDong_BJCCC_Q[349] = "沟通太平洋和印度洋的水道是马六甲海峡";
$HuoDong_BJCCC_A[350] = false; 	$HuoDong_BJCCC_Q[350] = "成都是大熊猫的产地";
$HuoDong_BJCCC_A[351] = false; 	$HuoDong_BJCCC_Q[351] = "中国的传统宗教是佛教吗";
$HuoDong_BJCCC_A[352] = false; 	$HuoDong_BJCCC_Q[352] = "我国有 56 个少数民族";
$HuoDong_BJCCC_A[353] = true;	    $HuoDong_BJCCC_Q[353] = "最早的宗教是佛教";
$HuoDong_BJCCC_A[354] = true;	    $HuoDong_BJCCC_Q[354] = "印度 印尼 孟加拉一般不准女性在生人面前露面";
$HuoDong_BJCCC_A[355] = false; 	$HuoDong_BJCCC_Q[355] = "英国伦敦“大本钟”的名字是来自地名";
$HuoDong_BJCCC_A[356] = false; 	$HuoDong_BJCCC_Q[356] = "在北京主办的 2008 年奥运是第 31 届";
$HuoDong_BJCCC_A[357] = true;	    $HuoDong_BJCCC_Q[357] = "第一个踏上月球的人是阿姆斯特朗";
$HuoDong_BJCCC_A[358] = false; 	$HuoDong_BJCCC_Q[358] = "成人高校与普通高校的毕业证书和学位证书一样";
$HuoDong_BJCCC_A[359] = true;	    $HuoDong_BJCCC_Q[359] = "专升本毕业生能否获得学士学位";
$HuoDong_BJCCC_A[360] = false; 	$HuoDong_BJCCC_Q[360] = "FOF 是基金的一种类型，其投资范围和普通基金相同";
$HuoDong_BJCCC_A[361] = true;	    $HuoDong_BJCCC_Q[361] = "我国国债回购以资金年收益率为报价单位";
$HuoDong_BJCCC_A[362] = false; 	$HuoDong_BJCCC_Q[362] = "安胜帐户所获收益的 15%为业绩报酬";
$HuoDong_BJCCC_A[363] = false; 	$HuoDong_BJCCC_Q[363] = "安胜帐户托管行为兴业和招商银行";
$HuoDong_BJCCC_A[364] = false; 	$HuoDong_BJCCC_Q[364] = "安胜帐户的起始资金为 100 万元，现金及股票市值均可";
$HuoDong_BJCCC_A[365] = true;	    $HuoDong_BJCCC_Q[365] = "安胜帐户可受理个人和机构投资者的申请";
$HuoDong_BJCCC_A[366] = true;	    $HuoDong_BJCCC_Q[366] = "佛教的四大菩萨之一观音的道场普陀山";
$HuoDong_BJCCC_A[367] = false; 	$HuoDong_BJCCC_Q[367] = "佛教教义中有五道四生之说";
$HuoDong_BJCCC_A[368] = true;	    $HuoDong_BJCCC_Q[368] = "用干毛巾轻轻按湿头发是护理头发的方法";
$HuoDong_BJCCC_A[369] = true;	    $HuoDong_BJCCC_Q[369] = "人们通常所说的“职业病”指的是由职业危害因素引起的疾病";
$HuoDong_BJCCC_A[370] = false; 	$HuoDong_BJCCC_Q[370] = "远视眼患者应该少吃低脂肪食品";
$HuoDong_BJCCC_A[371] = false; 	$HuoDong_BJCCC_Q[371] = "胃出血会引起呼吸停止或衰竭";
$HuoDong_BJCCC_A[372] = true;	    $HuoDong_BJCCC_Q[372] = "沿房檐柱砌筑的砖墙叫做檐墙";
$HuoDong_BJCCC_A[373] = true;	    $HuoDong_BJCCC_Q[373] = "食醋可以治疗牙周炎";
$HuoDong_BJCCC_A[374] = true;	    $HuoDong_BJCCC_Q[374] = "混合花纹轮胎防滑效果最好";
$HuoDong_BJCCC_A[375] = true;	    $HuoDong_BJCCC_Q[375] = "饮啤酒时不宜多吃海鲜";
$HuoDong_BJCCC_A[376] = false;    $HuoDong_BJCCC_Q[376] = "皮肤出现红色斑点是煤气中毒的症状";
$HuoDong_BJCCC_A[377] = true;	    $HuoDong_BJCCC_Q[377] = "藿香正气丸可解黄瓜与花生混吃后产生的腹泻";
$HuoDong_BJCCC_A[378] = true;	    $HuoDong_BJCCC_Q[378] = "青霉素与四环素类同服会降低药效";
$HuoDong_BJCCC_A[379] = true;	    $HuoDong_BJCCC_Q[379] = "红烧菜肴放白糖是为了呈色、提香";
$HuoDong_BJCCC_A[380] = true;	    $HuoDong_BJCCC_Q[380] = "豆浆可以帮助降低血脂 ";
$HuoDong_BJCCC_A[381] = false; 	$HuoDong_BJCCC_Q[381] = "洋金花不是麻醉药";
$HuoDong_BJCCC_A[382] = true; 	$HuoDong_BJCCC_Q[382] = "使用家用电器时可以移动电冰箱而不切断电源";
$HuoDong_BJCCC_A[383] = true; 	$HuoDong_BJCCC_Q[383] = "常挖鼻孔会损失鼻毛、鼻粘膜，削弱了鼻腔的防御机能而易患感冒";
$HuoDong_BJCCC_A[384] = true;	    $HuoDong_BJCCC_Q[384] = "进口商品的价格高的原因是国家征收进口关税引起";
$HuoDong_BJCCC_A[385] = false; 	$HuoDong_BJCCC_Q[385] = "蚊叮虫咬涂用黄酒有用";
$HuoDong_BJCCC_A[386] = false; 	$HuoDong_BJCCC_Q[386] = "太阳逼射，水面光线很强 宜钓鱼";
$HuoDong_BJCCC_A[387] = true;	    $HuoDong_BJCCC_Q[387] = "香蕉可以滑肠";
$HuoDong_BJCCC_A[388] = true;	    $HuoDong_BJCCC_Q[388] = "腐乳不属于肿瘤病人的忌食范围？";
$HuoDong_BJCCC_A[389] = true;	    $HuoDong_BJCCC_Q[389] = "一般家居意外中，烧伤灼伤后用大量冷水不停冲大约十分钟左右";
$HuoDong_BJCCC_A[390] = true;	    $HuoDong_BJCCC_Q[390] = "婴儿吮手指可能造成口腔上腭拱起同时也可引起细菌入侵机体";
$HuoDong_BJCCC_A[391] = false; 	$HuoDong_BJCCC_Q[391] = "按摩四百穴能减轻晕车的痛苦？";
$HuoDong_BJCCC_A[392] = false; 	$HuoDong_BJCCC_Q[392] = "为了牙齿的健康，刷牙应采用横刷法";
$HuoDong_BJCCC_A[393] = true;	    $HuoDong_BJCCC_Q[393] = "海中如遇鲨鱼，是用刀刺其嘴无效";
$HuoDong_BJCCC_A[394] = true;	    $HuoDong_BJCCC_Q[394] = "在我国糖的“祖先”是麦芽糖 ";
$HuoDong_BJCCC_A[395] = true;	    $HuoDong_BJCCC_Q[395] = "压路机的后轮比前轮半径大许多，这样的设计主要是考虑便于克服滚动摩擦 ";
$HuoDong_BJCCC_A[396] = false; 	$HuoDong_BJCCC_Q[396] = "异物入眼以后可以用手揉去除眼内异物 ";
$HuoDong_BJCCC_A[397] = false; 	$HuoDong_BJCCC_Q[397] = "空气传播属于乙型肝炎的传播途径";
$HuoDong_BJCCC_A[398] = true;	    $HuoDong_BJCCC_Q[398] = "咸蛋属于再制蛋";
$HuoDong_BJCCC_A[399] = true;	    $HuoDong_BJCCC_Q[399] = "花茶的种类是根据加入的鲜花命名的";
$HuoDong_BJCCC_A[400] = false; 	$HuoDong_BJCCC_Q[400] = "发生地震时，如果正在室内可以站在窗户边";
$HuoDong_BJCCC_A[401] = true;	    $HuoDong_BJCCC_Q[401] = "在野外如果吃了有毒的蘑菇应该立即喝大量喝水";
$HuoDong_BJCCC_A[402] = true;	    $HuoDong_BJCCC_Q[402] = "增加食欲唾液不具备的效果 ";
$HuoDong_BJCCC_A[403] = true;	    $HuoDong_BJCCC_Q[403] = "鱼肉不属于藏族人绝对禁吃的肉类 ";
$HuoDong_BJCCC_A[404] = true; 	$HuoDong_BJCCC_Q[404] = "钢铁工人在炼钢时，穿了一种不怕烧，不怕钢水，火星的衣服，它是用石棉作成的 ";
$HuoDong_BJCCC_A[405] = true;	    $HuoDong_BJCCC_Q[405] = "铁锅炊具对人体健康最有益 ";
$HuoDong_BJCCC_A[406] = true;	    $HuoDong_BJCCC_Q[406] = "饮酒是不宜多吃凉粉是因为为凉粉中含有白矾 ";
$HuoDong_BJCCC_A[407] = false; 	$HuoDong_BJCCC_Q[407] = "月亮是绿色食品标志的组成部分";
$HuoDong_BJCCC_A[408] = true;	    $HuoDong_BJCCC_Q[408] = "杀灭老鼠的最好选择是慢性药";
$HuoDong_BJCCC_A[409] = true;	    $HuoDong_BJCCC_Q[409] = "软饮料中香料等配制溶剂的酒精含量是0.5%以下";
$HuoDong_BJCCC_A[410] = true; 	$HuoDong_BJCCC_Q[410] = "冰箱里放入少许的木碳东西可吸去冰箱里的怪味";
$HuoDong_BJCCC_A[411] = true; 	$HuoDong_BJCCC_Q[411] = "长期服用四环素不会引起再生障碍性贫血";
$HuoDong_BJCCC_A[412] = true; 	$HuoDong_BJCCC_Q[412] = "柿子不宜与萝卜同吃";
$HuoDong_BJCCC_A[413] = false; 	$HuoDong_BJCCC_Q[413] = "咸味不可以调节细胞和血液之间的渗透压平衡及正常的水盐代谢";
$HuoDong_BJCCC_A[414] = true; 	$HuoDong_BJCCC_Q[414] = "喝醉酒的人可用浓茶来解酒";
$HuoDong_BJCCC_A[415] = false; 	$HuoDong_BJCCC_Q[415] = "柿子属于便秘患者的忌食范围";
$HuoDong_BJCCC_A[416] = true;	    $HuoDong_BJCCC_Q[416] = "熟啤酒是储存期较长的啤酒";
$HuoDong_BJCCC_A[417] = false; 	$HuoDong_BJCCC_Q[417] = "存放地瓜的最佳温度为20摄氏度以上，温度低了，就会僵心而不能食用";
$HuoDong_BJCCC_A[418] = true;	    $HuoDong_BJCCC_Q[418] = "出水痘时应该多喝鸡汤多休息";
$HuoDong_BJCCC_A[419] = true;	    $HuoDong_BJCCC_Q[419] = "汽车在翻车过程中最好的自救方法是抓紧车内的固定物体";
$HuoDong_BJCCC_A[420] = false; 	$HuoDong_BJCCC_Q[420] = "脑中风是风吹进了脑袋 ";
$HuoDong_BJCCC_A[421] = false; 	$HuoDong_BJCCC_Q[421] = "胃溃疡患者适宜服用阿司匹林？";
$HuoDong_BJCCC_A[422] = true;	    $HuoDong_BJCCC_Q[422] = "锰不是废电池所含的重金属";
$HuoDong_BJCCC_A[423] = true;	    $HuoDong_BJCCC_Q[423] = "情人节送蝴蝶兰表示初恋";
$HuoDong_BJCCC_A[424] = false; 	$HuoDong_BJCCC_Q[424] = "骑摩托车做飞跃障碍物的表演时为了减少向前翻车的危险，应该前轮先着地";
$HuoDong_BJCCC_A[425] = false; 	$HuoDong_BJCCC_Q[425] = "哮喘病患者可以食味精?";
$HuoDong_BJCCC_A[426] = true;	    $HuoDong_BJCCC_Q[426] = "适用于尿毒症病人的饮食低蛋白饮食";
$HuoDong_BJCCC_A[427] = true;	    $HuoDong_BJCCC_Q[427] = "鱼有心脏";
$HuoDong_BJCCC_A[428] = false; 	$HuoDong_BJCCC_Q[428] = "中国历史上最早称皇帝的夏禹";
$HuoDong_BJCCC_A[429] = true;	    $HuoDong_BJCCC_Q[429] = "中国历史上最后一个皇帝是清朝的宣统皇帝";
$HuoDong_BJCCC_A[430] = true;	    $HuoDong_BJCCC_Q[430] = "北京故宫旧称“紫禁城”";
$HuoDong_BJCCC_A[431] = true;	    $HuoDong_BJCCC_Q[431] = "世界上冰最多的地区是南极大陆";
$HuoDong_BJCCC_A[432] = false; 	$HuoDong_BJCCC_Q[432] = "世界上最长的国歌是科威特的国歌";
$HuoDong_BJCCC_A[433] = false; 	$HuoDong_BJCCC_Q[433] = "我国现代的第一篇白话小说是鲁迅作的《呐喊》";
$HuoDong_BJCCC_A[434] = true; 	$HuoDong_BJCCC_Q[434] = "太平天国中的西王是萧朝贵";
$HuoDong_BJCCC_A[435] = true;	    $HuoDong_BJCCC_Q[435] = "长江三峡不包括虎跳峡";
$HuoDong_BJCCC_A[436] = true;	    $HuoDong_BJCCC_Q[436] = "挂表比手表先问世";
$HuoDong_BJCCC_A[437] = false; 	$HuoDong_BJCCC_Q[437] = "隋朝所取代的周，属于南朝";
$HuoDong_BJCCC_A[438] = true;	    $HuoDong_BJCCC_Q[438] = "盎司既是重量单位又是容量单位";
$HuoDong_BJCCC_A[439] = true;	    $HuoDong_BJCCC_Q[439] = "古代欧洲文明发源于爱琴文明";
$HuoDong_BJCCC_A[440] = true;	    $HuoDong_BJCCC_Q[440] = "蒙古族最具代表性的乐器是马头琴";
$HuoDong_BJCCC_A[441] = false; 	$HuoDong_BJCCC_Q[441] = "法国不是联合国安理会常任理事国之一";
$HuoDong_BJCCC_A[442] = true;	    $HuoDong_BJCCC_Q[442] = "秦汉时代，人们说的关中指函谷关以西";
$HuoDong_BJCCC_A[443] = true;	    $HuoDong_BJCCC_Q[443] = "著名的哈雷彗星命名源于人名";
$HuoDong_BJCCC_A[444] = true;	    $HuoDong_BJCCC_Q[444] = "漫画《三毛流浪记》的作者是张乐平";
$HuoDong_BJCCC_A[445] = true;	    $HuoDong_BJCCC_Q[445] = "发表著名的铁幕演说的是邱吉尔";
$HuoDong_BJCCC_A[446] = false; 	$HuoDong_BJCCC_Q[446] = "英国伦敦大本钟的名字不是来自人名";
$HuoDong_BJCCC_A[447] = false; 	$HuoDong_BJCCC_Q[447] = "建立县制是商鞅变法的内容";
$HuoDong_BJCCC_A[448] = true;	    $HuoDong_BJCCC_Q[448] = "“大夫”在我国古代是指官职";
$HuoDong_BJCCC_A[449] = true; 	$HuoDong_BJCCC_Q[449] = "在《诗经》的主要表现手法中，兴是指联想";
$HuoDong_BJCCC_A[450] = true; 	$HuoDong_BJCCC_Q[450] = "我国最早的博物馆是南通博物馆";
$HuoDong_BJCCC_A[451] = false; 	$HuoDong_BJCCC_Q[451] = "“飞天奖”是电影奖";
$HuoDong_BJCCC_A[452] = true;	    $HuoDong_BJCCC_Q[452] = "我国第一台亿次巨型电子计算机被命名为 “银河”";
$HuoDong_BJCCC_A[453] = true; 	$HuoDong_BJCCC_Q[453] = "飞机总是 迎风起飞的 ";
$HuoDong_BJCCC_A[454] = false; 	$HuoDong_BJCCC_Q[454] = "UFO的具体含义是: 联合国安理会";
$HuoDong_BJCCC_A[455] = false; 	$HuoDong_BJCCC_Q[455] = "用齿轮传动不能改变运动的方向";
$HuoDong_BJCCC_A[456] = false; 	$HuoDong_BJCCC_Q[456] = "我国家用电器使用的是直流电";
$HuoDong_BJCCC_A[457] = true;	    $HuoDong_BJCCC_Q[457] = "将断丝的白炽灯泡重新搭上后,灯光与灯丝未断前相比要亮些";
$HuoDong_BJCCC_A[458] = true;	    $HuoDong_BJCCC_Q[458] = "保险丝越粗则：熔断电流越大";
$HuoDong_BJCCC_A[459] = false; 	$HuoDong_BJCCC_Q[459] = "金属钾平时应保存在煤油中";
$HuoDong_BJCCC_A[460] = true; 	$HuoDong_BJCCC_Q[460] = "固态二氧化碳俗称干冰，它人工降雨作用";
$HuoDong_BJCCC_A[461] = false; 	$HuoDong_BJCCC_Q[461] = "猪油在消化道里的完全消化的最终产物没有 甘油";
$HuoDong_BJCCC_A[462] = false; 	$HuoDong_BJCCC_Q[462] = "蜗牛会对青菜生长产生危害";
$HuoDong_BJCCC_A[463] = true;	    $HuoDong_BJCCC_Q[463] = "世界最重要的IT高科技产业基地硅谷位于美国的阿拉斯加州";
$HuoDong_BJCCC_A[464] = true; 	$HuoDong_BJCCC_Q[464] = "圆周率是祖冲之发明的";
$HuoDong_BJCCC_A[465] = false; 	$HuoDong_BJCCC_Q[465] = "我国1989年3月10日研制成功首胎“试管绵羊”，在我国北京大学诞生";
$HuoDong_BJCCC_A[466] = true; 	$HuoDong_BJCCC_Q[466] = "1991年12月18日，我国自己设计建造的第一座核电站,叫秦山核电站";
$HuoDong_BJCCC_A[467] = true;	    $HuoDong_BJCCC_Q[467] = "研制世界上第一架测定地震的仪器——候风地动仪的人是 张衡";
$HuoDong_BJCCC_A[468] = true;	    $HuoDong_BJCCC_Q[468] = "屠呦呦因为发现了青蒿素而获得了2015年的诺贝尔生理学或医学奖";
$HuoDong_BJCCC_A[469] = false; 	$HuoDong_BJCCC_Q[469] = "1964年1月 中国第一颗原子弹爆炸成功";
$HuoDong_BJCCC_A[470] = true;	    $HuoDong_BJCCC_Q[470] = "明朝大医学家、药学家李时珍的不朽著作是《本草纲目》";
$HuoDong_BJCCC_A[471] = false; 	$HuoDong_BJCCC_Q[471] = "电子计算机的发展已经经历了四代，现在已进入了第五代的研制时期，晶体管时代是第一代";
$HuoDong_BJCCC_A[472] = true;	    $HuoDong_BJCCC_Q[472] = "“绿色革命”是科学种田，使粮食、蔬菜、水果产量大幅度提高，被人们称为“绿色革命”";
$HuoDong_BJCCC_A[473] = false; 	$HuoDong_BJCCC_Q[473] = "《农政全书》的作者是宋朝科学家徐光启";
$HuoDong_BJCCC_A[474] = false; 	$HuoDong_BJCCC_Q[474] = "诺贝尔是瑞典国家的物理科学家？他发明了蒸汽机而闻名世界";
$HuoDong_BJCCC_A[475] = true;	    $HuoDong_BJCCC_Q[475] = "诺贝尔奖奖品包括金质奖章、证书和奖金支票";
$HuoDong_BJCCC_A[476] = false; 	$HuoDong_BJCCC_Q[476] = "指南针的方向不一定会指向南方的";
$HuoDong_BJCCC_A[477] = true;	    $HuoDong_BJCCC_Q[477] = "四大文明古国是指古埃及、古巴比伦、古印度、古中国";
$HuoDong_BJCCC_A[478] = false; 	$HuoDong_BJCCC_Q[478] = "我国现存最早的一部大型农学著作，是南北朝时期北魏的贾思勰著作的《皇帝内经》";
$HuoDong_BJCCC_A[479] = true;	    $HuoDong_BJCCC_Q[479] = "几何原本的作者是欧几里德";
$HuoDong_BJCCC_A[480] = true;	    $HuoDong_BJCCC_Q[480] = "贷款人在贷款将受或已受损失时，可以按合同规定采取使贷款免受损失的措施";
$HuoDong_BJCCC_A[481] = true;	    $HuoDong_BJCCC_Q[481] = "借款人经营状况严重恶化时，贷款人享有不安抗辩权";
$HuoDong_BJCCC_A[482] = true;	    $HuoDong_BJCCC_Q[482] = "现钞和现汇的管理界限虽然取消，但是在日常操作中仍执行两种不同的汇率";
$HuoDong_BJCCC_A[483] = false; 	$HuoDong_BJCCC_Q[483] = "在衡量通货膨胀时，常用的指标是生产者物价指数";
$HuoDong_BJCCC_A[484] = true;	    $HuoDong_BJCCC_Q[484] = "我国的进口与出口的数量和结构对国内总供求有重大影响";
$HuoDong_BJCCC_A[485] = false; 	$HuoDong_BJCCC_Q[485] = "定期存款存期内遇有利率调整，则按调整后的相应定期存款利率计息";
$HuoDong_BJCCC_A[486] = true;	    $HuoDong_BJCCC_Q[486] = "受要约人对要约作出实质性变更，相当于作出新的要约";
$HuoDong_BJCCC_A[487] = false; 	$HuoDong_BJCCC_Q[487] = "以公司的国籍为标准，可以将公司分为中资公司和外资公司";
$HuoDong_BJCCC_A[488] = true;	    $HuoDong_BJCCC_Q[488] = "破产财产不足以清偿同一顺序的清偿要求的，按照比例分配";
$HuoDong_BJCCC_A[489] = true;	    $HuoDong_BJCCC_Q[489] = "客户隐私保护是商业银行必须履行的一项重要义务";
$HuoDong_BJCCC_A[490] = false; 	$HuoDong_BJCCC_Q[490] = "国际收支记录的是居民的交易行为，居民是指在国内居住两年以上的自然人和法人";
$HuoDong_BJCCC_A[491] = false; 	$HuoDong_BJCCC_Q[491] = "作为监管措施的“机构准入”是指作为法人机构的金融构的建立";
$HuoDong_BJCCC_A[492] = true;	    $HuoDong_BJCCC_Q[492] = "汽车金融公司可以为贷款购车提供担保";
$HuoDong_BJCCC_A[493] = true;	    $HuoDong_BJCCC_Q[493] = "与一般金融机构所从事的证券买卖不同，中国人民银行买卖证券的目的不是为了盈利";
$HuoDong_BJCCC_A[494] = false; 	$HuoDong_BJCCC_Q[494] = "通货紧缩对经济增长有着有利的影响";
$HuoDong_BJCCC_A[495] = false; 	$HuoDong_BJCCC_Q[495] = "公司经理是公司的法定代理人";
$HuoDong_BJCCC_A[496] = true;	    $HuoDong_BJCCC_Q[496] = "仅具备设立公司的条件而不履行公司设立登记程序，公司不能成立，也不能取得法人资格";
$HuoDong_BJCCC_A[497] = false; 	$HuoDong_BJCCC_Q[497] = "外资银行不包含在中华人民共和国境内设立的外国银行代表处 ";
$HuoDong_BJCCC_A[498] = true;	    $HuoDong_BJCCC_Q[498] = "新成立的中国邮政储蓄银行将按照公司治理架构和银行管理的要求实行市场化经营管理";
$HuoDong_BJCCC_A[499] = false; 	$HuoDong_BJCCC_Q[499] = "1999年我国成立的四家资产管理公司的经营目标将是市场化的，是为了实现资产的收益最大化";
$HuoDong_BJCCC_A[500] = false; 	$HuoDong_BJCCC_Q[500] = "失业率是指劳动入口中失业人数与未失业人数的比例";
$HuoDong_BJCCC_A[501] = true;	    $HuoDong_BJCCC_Q[501] = "个人通知存款的起存金额一般为 5万元";
$HuoDong_BJCCC_A[502] = true; 	$Huodong_BJCCC_Q[502] = "贷款人在贷款将受或已受损失时，可以根据合同规定采取贷款免受损失的措施";
$HuoDong_BJCCC_A[503] = true; 	$Huodong_BJCCC_Q[503] = "禁止对关系人提供信用贷款有利于创造公平、公升的贷款环境";
$HuoDong_BJCCC_A[504] = true;	    $Huodong_BJCCC_Q[504] = "破产程序主要包括破产申请和受理、破产宣告、破产清算三大程序";
$HuoDong_BJCCC_A[505] = true; 	$Huodong_BJCCC_Q[505] = "金融机构收缴的假币，应当于每季末解缴中国人民银行当地分支行";
$HuoDong_BJCCC_A[506] = false; 	$Huodong_BJCCC_Q[506] = "办理货币存取款业务的金融机构，是指我国目前所有的金融机构";
$HuoDong_BJCCC_A[507] = false; 	$Huodong_BJCCC_Q[507] = "办理货币存取款和外币兑换业务的金融机构均可办理货币真伪鉴定";
$HuoDong_BJCCC_A[508] = false; 	$Huodong_BJCCC_Q[508] = "国务院反洗钱行政主管部门是中国人民银行";
$HuoDong_BJCCC_A[509] = false; 	$Huodong_BJCCC_Q[509] = "中国共产党第一任总书记是瞿秋白";
$HuoDong_BJCCC_A[510] = true;	    $Huodong_BJCCC_Q[510] = "中国共产主义青年团第一任书记是俞秀松";
$HuoDong_BJCCC_A[511] = false; 	$Huodong_BJCCC_Q[511] = "现任国际奥委会主席的是维凯拉斯";
$HuoDong_BJCCC_A[512] = false; 	$Huodong_BJCCC_Q[512] = "名言“生命在于运动”是车尔尼夫斯基说的";
$HuoDong_BJCCC_A[513] = false; 	$Huodong_BJCCC_Q[513] = "我国运动员邹振华是第一次获得田径比赛冠军的中国运动员";
$HuoDong_BJCCC_A[514] = true;	    $Huodong_BJCCC_Q[514] = "体操比赛中有四个动作以我国运动员的名字命名，其中鞍马是童非";
$HuoDong_BJCCC_A[515] = true; 	$Huodong_BJCCC_Q[515] = "我国最早打破举重世界纪录的是陈镜开";
$HuoDong_BJCCC_A[516] = false; 	$Huodong_BJCCC_Q[516] = "董海川是迷踪拳的创始人";
$HuoDong_BJCCC_A[517] = true;	    $Huodong_BJCCC_Q[517] = "“发展体育运动，增强人民体质”是毛泽东的题词";
$HuoDong_BJCCC_A[518] = false; 	$Huodong_BJCCC_Q[518] = "郭沫若的诗集有《死水》";
$HuoDong_BJCCC_A[519] = false; 	$Huodong_BJCCC_Q[519] = "馒头是李冰发明的";
$HuoDong_BJCCC_A[520] = false; 	$Huodong_BJCCC_Q[520] = "太平天国中的东王是韦昌辉";
$HuoDong_BJCCC_A[521] = false; 	$Huodong_BJCCC_Q[521] = "寒食节是为了纪念重耳";
$HuoDong_BJCCC_A[522] = true;	    $Huodong_BJCCC_Q[522] = "中国效力于NBA的球员姚明当选为14届‘中国十大杰出青年";
$HuoDong_BJCCC_A[523] = true;	    $Huodong_BJCCC_Q[523] = "《儒林外史》的作者是吴敬梓";
$HuoDong_BJCCC_A[524] = false; 	$Huodong_BJCCC_Q[524] = "哈雷慧星的最早记录是波斯人";
$HuoDong_BJCCC_A[525] = false; 	$Huodong_BJCCC_Q[525] = "金庸的籍贯是台湾的台北";
$HuoDong_BJCCC_A[526] = false; 	$Huodong_BJCCC_Q[526] = "蒋介石遗孀宋美龄女士于美东时间23日深夜11时17分在纽约去世.享年100岁";
$HuoDong_BJCCC_A[527] = true; 	$Huodong_BJCCC_Q[527] = "李白笔下的“飞流直下三千尺，疑是银河落九天”指的是庐山风景区";
$HuoDong_BJCCC_A[528] = true; 	$Huodong_BJCCC_Q[528] = "鲁班姓公输";
$HuoDong_BJCCC_A[529] = true; 	$Huodong_BJCCC_Q[529] = "赵州桥是中国古代工匠李春建造的";
$HuoDong_BJCCC_A[530] = true; 	$Huodong_BJCCC_Q[530] = "天安门的设计者是明朝的一位工匠，名叫 蒯祥";
$HuoDong_BJCCC_A[531] = true; 	$Huodong_BJCCC_Q[531] = "印度的圣雄·甘地纪念馆的设计师是查尔斯·柯里亚";
$HuoDong_BJCCC_A[532] = true; 	$Huodong_BJCCC_Q[532] = "西藏著名佛教建筑是由松赞干布始建的";
$HuoDong_BJCCC_A[533] = true; 	$Huodong_BJCCC_Q[533] = "贝聿铭出生于1917年";
$HuoDong_BJCCC_A[534] = false; 	$Huodong_BJCCC_Q[534] = "艾菲尔铁塔的设计者不是艾菲尔";
$HuoDong_BJCCC_A[535] = true;	    $Huodong_BJCCC_Q[535] = "香港汇丰银行的设计者是贝律铭";
$HuoDong_BJCCC_A[536] = true;	    $Huodong_BJCCC_Q[536] = "悉尼歌剧院由丹麦的建筑师设计的";
$HuoDong_BJCCC_A[537] = true;	    $Huodong_BJCCC_Q[537] = "《中国建筑史》的作者是梁思成";
$HuoDong_BJCCC_A[538] = true;	    $Huodong_BJCCC_Q[538] = "1970年，霍金博士意识到并且成功证明了黑洞边界定理";
$HuoDong_BJCCC_A[539] = true;	    $Huodong_BJCCC_Q[539] = "名著《呼啸山庄》是采用了一种插叙叙述方法";
$HuoDong_BJCCC_A[540] = false; 	$Huodong_BJCCC_Q[540] = "“如果冬天来了，春天还会远吗？”这句名言出自于英国的拜伦";
$HuoDong_BJCCC_A[541] = true;	    $Huodong_BJCCC_Q[541] = "拜论是英国的伟大的浪漫主义诗人";
$HuoDong_BJCCC_A[542] = false; 	$Huodong_BJCCC_Q[542] = "鲁迅对泰戈尔拜赞成态度";
$HuoDong_BJCCC_A[543] = false; 	$Huodong_BJCCC_Q[543] = "在“精卫填海”的故事里，“精卫”是一条龙";
$HuoDong_BJCCC_A[544] = false; 	$Huodong_BJCCC_Q[544] = "“变脸”是京剧剧种的绝活";
$HuoDong_BJCCC_A[545] = true;	    $Huodong_BJCCC_Q[545] = "人体含水量百分比最高的器官是眼球";
$HuoDong_BJCCC_A[546] = true;	    $Huodong_BJCCC_Q[546] = "反映波兰作曲家肖邦生平的美国影片是《一曲难忘》";
$HuoDong_BJCCC_A[547] = false; 	$Huodong_BJCCC_Q[547] = "《史记》是编年体通史";
$HuoDong_BJCCC_A[548] = true;	    $Huodong_BJCCC_Q[548] = "据考古资料显示，我国的钻孔技术开始于山顶洞人时代";
$HuoDong_BJCCC_A[549] = false; 	$Huodong_BJCCC_Q[549] = "李白笔下的“飞流直下三千尺，疑是银河落九天”指的是华山的风景";
$HuoDong_BJCCC_A[550] = true;	    $Huodong_BJCCC_Q[550] = "《黄河大合唱》的作曲者是冼星海";
$HuoDong_BJCCC_A[551] = false; 	$Huodong_BJCCC_Q[551] = "中国端午节有用雄黄酒灭五毒的习惯，那么雄黄酒可以饮用";
$HuoDong_BJCCC_A[552] = true;	    $Huodong_BJCCC_Q[552] = "巴西的首都是巴西利亚";
$HuoDong_BJCCC_A[553] = false; 	$Huodong_BJCCC_Q[553] = "“皇帝”作为国家元首的正式称号，始于汉武帝";
$HuoDong_BJCCC_A[554] = false; 	$Huodong_BJCCC_Q[554] = "春秋时的齐国和鲁国，在现在的河南省";
$HuoDong_BJCCC_A[555] = true;	    $Huodong_BJCCC_Q[555] = "明月松间照，清泉石上流";
$HuoDong_BJCCC_A[556] = true;	    $Huodong_BJCCC_Q[556] = "被称为我国“瓷都”的是指景德镇";
$HuoDong_BJCCC_A[557] = true;	    $Huodong_BJCCC_Q[557] = "胶粘剂属于合成高分子材料";
$HuoDong_BJCCC_A[558] = false; 	$Huodong_BJCCC_Q[558] = "飞机的轮胎不能导电";
$HuoDong_BJCCC_A[559] = true; 	$Huodong_BJCCC_Q[559] = "固态二氧化碳俗称干冰，它人工降雨作用";
$HuoDong_BJCCC_A[560] = false; 	$Huodong_BJCCC_Q[560] = "蜗牛会对青菜生长产生危害";
$HuoDong_BJCCC_A[561] = true;	    $Huodong_BJCCC_Q[561] = "二合一洗发水是指洗发、护发二合一";
$HuoDong_BJCCC_A[562] = true;	    $Huodong_BJCCC_Q[562] = "诺贝尔奖奖品包括金质奖章、证书和奖金支票";
$HuoDong_BJCCC_A[563] = false; 	$Huodong_BJCCC_Q[563] = "维生素B有抗氧化防衰老作用";
$HuoDong_BJCCC_A[564] = true;	    $Huodong_BJCCC_Q[564] = "煤炭中发热量最大的是无烟煤";
$HuoDong_BJCCC_A[565] = true;	    $Huodong_BJCCC_Q[565] = "产于绍兴的月饼是干菜月饼";
$HuoDong_BJCCC_A[566] = true;	    $Huodong_BJCCC_Q[566] = "月光宝盒的咒语是波若波罗蜜";
$HuoDong_BJCCC_A[567] = true;	    $Huodong_BJCCC_Q[567] = "汉字中笔画最少的是一、乙";
$HuoDong_BJCCC_A[568] = true;	    $Huodong_BJCCC_Q[568] = "“六书”指的是造字方法";
$HuoDong_BJCCC_A[569] = false; 	$Huodong_BJCCC_Q[569] = "指南针的方向不一定会指向南方的";
$HuoDong_BJCCC_A[570] = false; 	$Huodong_BJCCC_Q[570] = "《农政全书》的作者是宋朝科学家徐光启";
$HuoDong_BJCCC_A[571] = false; 	$Huodong_BJCCC_Q[571] = "地球上的淡水只占总水量百分比是2 5%";
$HuoDong_BJCCC_A[572] = false; 	$Huodong_BJCCC_Q[572] = "金属钾平时应保存在煤油中";
$HuoDong_BJCCC_A[573] = false; 	$Huodong_BJCCC_Q[573] = "猪油在消化道里的完全消化的最终产物没有 甘油";
$HuoDong_BJCCC_A[574] = true;	    $Huodong_BJCCC_Q[574] = "圆周率是祖冲之发明的";
$HuoDong_BJCCC_A[575] = false; 	$Huodong_BJCCC_Q[575] = "滇式月饼产于江西";
$HuoDong_BJCCC_A[576] = false; 	$Huodong_BJCCC_Q[576] = "“风筝”名称的来源与乐器古筝无关";
$HuoDong_BJCCC_A[577] = true;	    $Huodong_BJCCC_Q[577] = "粉刺就是痤疮";
$HuoDong_BJCCC_A[578] = true;	    $Huodong_BJCCC_Q[578] = "保险丝越粗则：熔断电流越大";
$HuoDong_BJCCC_A[579] = false; 	$Huodong_BJCCC_Q[579] = "小黄鱼长大后就是大黄鱼";
$HuoDong_BJCCC_A[580] = true;	    $Huodong_BJCCC_Q[580] = "小熊猫和大熊猫是不是同一个科目";
$HuoDong_BJCCC_A[581] = false; 	$Huodong_BJCCC_Q[581] = "鱼没有耳朵";
$HuoDong_BJCCC_A[582] = true;	    $Huodong_BJCCC_Q[582] = "“山药蛋派”的代表作家是赵树理";
$HuoDong_BJCCC_A[583] = true;	    $Huodong_BJCCC_Q[583] = "中央台的文艺频道是第三套节目";
$HuoDong_BJCCC_A[584] = true;	    $Huodong_BJCCC_Q[584] = "郭沫若的诗集有《女神》";
$HuoDong_BJCCC_A[585] = true;	    $Huodong_BJCCC_Q[585] = "中国无声影片的最高峰《神女》是阮玲玉的代表作";
$HuoDong_BJCCC_A[586] = true;	    $Huodong_BJCCC_Q[586] = "《钢铁是怎样炼成的》作者是奥斯特洛夫斯基";
$HuoDong_BJCCC_A[587] = true;	    $Huodong_BJCCC_Q[587] = "中国举办2008年奥运会";
$HuoDong_BJCCC_A[588] = true;	    $Huodong_BJCCC_Q[588] = "体育是一种特殊的社会现象，是社会文化的一部分";
$HuoDong_BJCCC_A[589] = false; 	$Huodong_BJCCC_Q[589] = "法国画家大卫的《马拉之死》是一幅风景画";
$HuoDong_BJCCC_A[590] = true; 	$Huodong_BJCCC_Q[590] = "跑和走的主要区别在于跑有腾空阶段";
$HuoDong_BJCCC_A[591] = true;	    $Huodong_BJCCC_Q[591] = "世界名画《和平鸽》的创作者是毕加索";
$HuoDong_BJCCC_A[592] = true; 	$Huodong_BJCCC_Q[592] = "南北朝时，北方民歌艺术的最高成就是敕勒歌";
$HuoDong_BJCCC_A[593] = false; 	$Huodong_BJCCC_Q[593] = "校园歌曲《童年》的词曲作者是蒋开儒";
$HuoDong_BJCCC_A[594] = true;	    $Huodong_BJCCC_Q[594] = "“人生自古谁无死，留取丹心照汗青”的作者是文天祥";
$HuoDong_BJCCC_A[595] = false; 	$Huodong_BJCCC_Q[595] = "仙人掌原产印度";
$HuoDong_BJCCC_A[596] = true;	    $Huodong_BJCCC_Q[596] = "著名影片《魂断蓝桥》的桥是滑铁卢桥";
$HuoDong_BJCCC_A[597] = true;	    $Huodong_BJCCC_Q[597] = "《乔厂长上任记》的作者是蒋子龙";
$HuoDong_BJCCC_A[598] = false; 	$Huodong_BJCCC_Q[598] = "“半部论语治天下”之说由孔子而来";
$HuoDong_BJCCC_A[599] = true;	    $Huodong_BJCCC_Q[599] = "彩票在我国发行历史悠久，那么最早的彩票是猜科举张榜";
$HuoDong_BJCCC_A[600] = true;	    $Huodong_BJCCC_Q[600] = "宋代的“学象生”同现代的口技";
$HuoDong_BJCCC_A[601] = true;	    $Huodong_BJCCC_Q[601] = "芹菜 是能降血压的蔬菜";
$HuoDong_BJCCC_A[602] = true;	    $Huodong_BJCCC_Q[602] = "唐代人可以称“父亲”为哥哥";
$HuoDong_BJCCC_A[603] = true;	    $Huodong_BJCCC_Q[603] = "全世界最大的石佛像在四川乐山";
$HuoDong_BJCCC_A[604] = true;	    $Huodong_BJCCC_Q[604] = "饭前食用吃水果比较好";
$HuoDong_BJCCC_A[605] = true;	    $Huodong_BJCCC_Q[605] = "人体如果失水20%就会危及生命";
$HuoDong_BJCCC_A[606] = true;	    $Huodong_BJCCC_Q[606] = "鸡蛋里蛋黄的脂肪含量最高";
$HuoDong_BJCCC_A[607] = true;	    $Huodong_BJCCC_Q[607] = "“破釜沉舟”这个成语出于巨鹿之战";
$HuoDong_BJCCC_A[608] = true;	    $Huodong_BJCCC_Q[608] = "长枪比手枪射出去的子弹打得远";
$HuoDong_BJCCC_A[609] = true;	    $Huodong_BJCCC_Q[609] = "“伯乐一顾”中的伯乐看的是马";
$HuoDong_BJCCC_A[610] = false;    $Huodong_BJCCC_Q[610] = "被称为“液体面包”的是水银";
$HuoDong_BJCCC_A[611] = false; 	$Huodong_BJCCC_Q[611] = "《清明上河图》是一幅现实写实画";
$HuoDong_BJCCC_A[612] = true;	    $Huodong_BJCCC_Q[612] = "唐人有诗云：“城头击鼓传花枝，席上搏拳握松子”中“搏拳”的含义是划拳";
$HuoDong_BJCCC_A[613] = false; 	$Huodong_BJCCC_Q[613] = "有板有眼的“板”是我国传统音乐节奏中的木板";
$HuoDong_BJCCC_A[614] = true;	    $Huodong_BJCCC_Q[614] = "水和汽油都洗不掉的污迹是墨迹";
$HuoDong_BJCCC_A[615] = false; 	$Huodong_BJCCC_Q[615] = "“三过家门而不人”是周公的故事";
$HuoDong_BJCCC_A[616] = true;	    $Huodong_BJCCC_Q[616] = "蝎子的毒刺长在腹部尖端";
$HuoDong_BJCCC_A[617] = true;	    $Huodong_BJCCC_Q[617] = "“博士”作为官名最早出现在秦朝";
$HuoDong_BJCCC_A[618] = true;	    $Huodong_BJCCC_Q[618] = "人体含水量百分比最高的器官是眼球";
$HuoDong_BJCCC_A[619] = true;	    $Huodong_BJCCC_Q[619] = "中国面积最大的省份是新疆";
$HuoDong_BJCCC_A[620] = true;	    $Huodong_BJCCC_Q[620] = "我国历史上第一部编年体史书是《春秋》";
$HuoDong_BJCCC_A[621] = true;	    $Huodong_BJCCC_Q[621] = "鲸鱼不是鱼";
$HuoDong_BJCCC_A[622] = true;	    $Huodong_BJCCC_Q[622] = "人类最早使用的工具，是石头做的";
$HuoDong_BJCCC_A[623] = true;	    $Huodong_BJCCC_Q[623] = "“知天命”代指五十岁左右的年纪";
$HuoDong_BJCCC_A[624] = true;	    $Huodong_BJCCC_Q[624] = "天坛南方北圆，象征天圆地方";
$HuoDong_BJCCC_A[625] = false; 	$Huodong_BJCCC_Q[625] = "“似曾相识燕归来”的上一句是“有缘千里来相会”";
$HuoDong_BJCCC_A[626] = true;	    $Huodong_BJCCC_Q[626] = "我国古代的“芙蓉城”是指成都";
$HuoDong_BJCCC_A[627] = true;	    $Huodong_BJCCC_Q[627] = "发明了麻醉术的是华佗";
$HuoDong_BJCCC_A[628] = false; 	$Huodong_BJCCC_Q[628] = "是人最早驯养的动物狗";
$HuoDong_BJCCC_A[629] = true;	    $Huodong_BJCCC_Q[629] = "最高的哺乳动物是长颈鹿";
$HuoDong_BJCCC_A[630] = true;	    $Huodong_BJCCC_Q[630] = "泰国的国花是睡莲";
$HuoDong_BJCCC_A[631] = false; 	$Huodong_BJCCC_Q[631] = "不给仙人掌浇水，最多能活10年 ";
$HuoDong_BJCCC_A[632] = false; 	$Huodong_BJCCC_Q[632] = "全球的四大害是老鼠、蚊子、螳螂、麻雀";
$HuoDong_BJCCC_A[633] = true;	    $Huodong_BJCCC_Q[633] = "汉民族的共同语是普通话";
$HuoDong_BJCCC_A[634] = false; 	$Huodong_BJCCC_Q[634] = "最古老的文学体是诗经";
$HuoDong_BJCCC_A[635] = true;	    $Huodong_BJCCC_Q[635] = "世界是最小的有花植物是微萍";
$HuoDong_BJCCC_A[636] = false; 	$Huodong_BJCCC_Q[636] = "活的最长寿命的是椰子树";
$HuoDong_BJCCC_A[637] = false; 	$Huodong_BJCCC_Q[637] = "香樟树是最古老的树";
$HuoDong_BJCCC_A[638] = false; 	$Huodong_BJCCC_Q[638] = "榕树树能防火";
$HuoDong_BJCCC_A[639] = false; 	$Huodong_BJCCC_Q[639] = "沙漠人参是仙人掌";
$HuoDong_BJCCC_A[640] = false; 	$Huodong_BJCCC_Q[640] = "被称为天然监测仪的是苔藓三叶草";

//■■■■■任务答题库■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
$AddMissionQuiz[20009,1,1] = "技能如何升级？";					      $AddMissionQuiz[20009,2,1] = "1";
$AddMissionQuiz[20009,1,2] = "如何打开骑乘界面？";			      $AddMissionQuiz[20009,2,2] = "3";
$AddMissionQuiz[20009,1,3] = "如何开启3D视角功能？";		      $AddMissionQuiz[20009,2,3] = "2";
$AddMissionQuiz[20009,1,4] = "如何使用自动寻径？";			      $AddMissionQuiz[20009,2,4] = "2";

$AddMissionQuiz[20009,3,1] = "打开人物技能界面直接升级技能。";	$AddMissionQuiz[20009,4,1] = "默默坐在地上参悟";												$AddMissionQuiz[20009,5,1] = "击败怪物累计经验技能自动升级。";
$AddMissionQuiz[20009,3,2] = "按E键";											    $AddMissionQuiz[20009,4,2] = "按B键";																	  $AddMissionQuiz[20009,5,2] = "按X键再点击左上角骑乘按钮切换";
$AddMissionQuiz[20009,3,3] = "自动开启";									    $AddMissionQuiz[20009,4,3] = "点击右上角小地图下的2.5D按钮开启";				$AddMissionQuiz[20009,5,3] = "鼠标右键连续点三下";
$AddMissionQuiz[20009,3,4] = "聊天框输入/寻径+地点";			    $AddMissionQuiz[20009,4,4] = "按M打开地图，左键点击要去的地方";		     	$AddMissionQuiz[20009,5,4] = "找NPC开启此功能";


$AddMissionQuiz[20209,1,1] = "技能如何升级？";					      $AddMissionQuiz[20209,2,1] = "1";
$AddMissionQuiz[20209,1,2] = "如何打开骑乘界面？";			      $AddMissionQuiz[20209,2,2] = "3";
$AddMissionQuiz[20209,1,3] = "如何开启3D视角功能？";		      $AddMissionQuiz[20209,2,3] = "2";
$AddMissionQuiz[20209,1,4] = "如何使用自动寻径？";			      $AddMissionQuiz[20209,2,4] = "2";

$AddMissionQuiz[20209,3,1] = "打开人物技能界面直接升级技能。";	$AddMissionQuiz[20209,4,1] = "默默坐在地上参悟";												$AddMissionQuiz[20209,5,1] = "击败怪物累计经验技能自动升级。";
$AddMissionQuiz[20209,3,2] = "按E键";											    $AddMissionQuiz[20209,4,2] = "按B键";																	  $AddMissionQuiz[20209,5,2] = "按X键再点击左上角骑乘按钮切换";
$AddMissionQuiz[20209,3,3] = "自动开启";									    $AddMissionQuiz[20209,4,3] = "点击右上角小地图下的2.5D按钮开启";				$AddMissionQuiz[20209,5,3] = "鼠标右键连续点三下";
$AddMissionQuiz[20209,3,4] = "聊天框输入/寻径+地点";			    $AddMissionQuiz[20209,4,4] = "按M打开地图，左键点击要去的地方";		    	$AddMissionQuiz[20209,5,4] = "找NPC开启此功能";

$AddMissionQuiz[20409,1,1] = "技能如何升级？";					      $AddMissionQuiz[20409,2,1] = "1";
$AddMissionQuiz[20409,1,2] = "如何打开骑乘界面？";			      $AddMissionQuiz[20409,2,2] = "3";
$AddMissionQuiz[20409,1,3] = "如何开启3D视角功能？";		      $AddMissionQuiz[20409,2,3] = "2";
$AddMissionQuiz[20409,1,4] = "如何使用自动寻径？";			      $AddMissionQuiz[20409,2,4] = "2";

$AddMissionQuiz[20409,3,1] = "打开人物技能界面直接升级技能。";	$AddMissionQuiz[20409,4,1] = "默默坐在地上参悟";												$AddMissionQuiz[20409,5,1] = "击败怪物累计经验技能自动升级。";
$AddMissionQuiz[20409,3,2] = "按E键";											    $AddMissionQuiz[20409,4,2] = "按B键";																	  $AddMissionQuiz[20409,5,2] = "按X键再点击左上角骑乘按钮切换";
$AddMissionQuiz[20409,3,3] = "自动开启";									    $AddMissionQuiz[20409,4,3] = "点击右上角小地图下的2.5D按钮开启";				$AddMissionQuiz[20409,5,3] = "鼠标右键连续点三下";
$AddMissionQuiz[20409,3,4] = "聊天框输入/寻径+地点";			    $AddMissionQuiz[20409,4,4] = "按M打开地图，左键点击要去的地方";		    	$AddMissionQuiz[20409,5,4] = "找NPC开启此功能";


$AddMissionQuiz[20609,1,1] = "技能如何升级？";					      $AddMissionQuiz[20609,2,1] = "1";
$AddMissionQuiz[20609,1,2] = "如何打开骑乘界面？";			      $AddMissionQuiz[20609,2,2] = "3";
$AddMissionQuiz[20609,1,3] = "如何开启3D视角功能？";		      $AddMissionQuiz[20609,2,3] = "2";
$AddMissionQuiz[20609,1,4] = "如何使用自动寻径？";			      $AddMissionQuiz[20609,2,4] = "2";

$AddMissionQuiz[20609,3,1] = "打开人物技能界面直接升级技能。";	$AddMissionQuiz[20609,4,1] = "默默坐在地上参悟";												$AddMissionQuiz[20609,5,1] = "击败怪物累计经验技能自动升级。";
$AddMissionQuiz[20609,3,2] = "按E键";											    $AddMissionQuiz[20609,4,2] = "按B键";																	  $AddMissionQuiz[20609,5,2] = "按X键再点击左上角骑乘按钮切换";
$AddMissionQuiz[20609,3,3] = "自动开启";									    $AddMissionQuiz[20609,4,3] = "点击右上角小地图下的2.5D按钮开启";				$AddMissionQuiz[20609,5,3] = "鼠标右键连续点三下";
$AddMissionQuiz[20609,3,4] = "聊天框输入/寻径+地点";			    $AddMissionQuiz[20609,4,4] = "按M打开地图，左键点击要去的地方";		    	$AddMissionQuiz[20609,5,4] = "找NPC开启此功能";


$AddMissionQuiz[20809,1,1] = "技能如何升级？";					      $AddMissionQuiz[20809,2,1] = "1";
$AddMissionQuiz[20809,1,2] = "如何打开骑乘界面？";			      $AddMissionQuiz[20809,2,2] = "3";
$AddMissionQuiz[20809,1,3] = "如何开启3D视角功能？";		      $AddMissionQuiz[20809,2,3] = "2";
$AddMissionQuiz[20809,1,4] = "如何使用自动寻径？";			      $AddMissionQuiz[20809,2,4] = "2";

$AddMissionQuiz[20809,3,1] = "打开人物技能界面直接升级技能。";	$AddMissionQuiz[20809,4,1] = "默默坐在地上参悟";												$AddMissionQuiz[20809,5,1] = "击败怪物累计经验技能自动升级。";
$AddMissionQuiz[20809,3,2] = "按E键";											    $AddMissionQuiz[20809,4,2] = "按B键";																	  $AddMissionQuiz[20809,5,2] = "按X键再点击左上角骑乘按钮切换";
$AddMissionQuiz[20809,3,3] = "自动开启";									    $AddMissionQuiz[20809,4,3] = "点击右上角小地图下的2.5D按钮开启";				$AddMissionQuiz[20809,5,3] = "鼠标右键连续点三下";
$AddMissionQuiz[20809,3,4] = "聊天框输入/寻径+地点";			    $AddMissionQuiz[20809,4,4] = "按M打开地图，左键点击要去的地方";		    	$AddMissionQuiz[20809,5,4] = "找NPC开启此功能";

$AddMissionQuiz[21030,1,1] = "在《昆仑决双龙传》里被称为多情公子的人是？"; $AddMissionQuiz[21030,2,1] = "2";
$AddMissionQuiz[21030,1,2] = "单雄忠是被谁一箭射下马？";					       $AddMissionQuiz[21030,2,2] = "3";
$AddMissionQuiz[21030,1,3] = "贴在门上的门神分别是：";				           $AddMissionQuiz[21030,2,3] = "1";
$AddMissionQuiz[21030,1,4] = "《昆仑决双龙传》里的双龙指的是谁：";         $AddMissionQuiz[21030,2,4] = "3";

$AddMissionQuiz[21030,3,1] = "跋锋寒";	                                 $AddMissionQuiz[21030,4,1] = "侯希白";							$AddMissionQuiz[21030,5,1] = "雷九指";
$AddMissionQuiz[21030,3,2] = "李密";											               $AddMissionQuiz[21030,4,2] = "宇文化及";						$AddMissionQuiz[21030,5,2] = "李渊";
$AddMissionQuiz[21030,3,3] = "尉迟恭、秦叔宝";										       $AddMissionQuiz[21030,4,3] = "程咬金、罗成";				$AddMissionQuiz[21030,5,3] = "王伯当、雄阔海";
$AddMissionQuiz[21030,3,4] = "毕玄、颉利";				                       $AddMissionQuiz[21030,4,4] = "杨虚彦、宋师道";			$AddMissionQuiz[21030,5,4] = "徐子陵、寇仲";

$AddMissionQuiz[21507,1,1] = "在《昆仑决双龙传》里被称为多情公子的人是？"; $AddMissionQuiz[21507,2,1] = "2";
$AddMissionQuiz[21507,1,2] = "单雄忠是被谁一箭射下马？";					       $AddMissionQuiz[21507,2,2] = "3";
$AddMissionQuiz[21507,1,3] = "贴在门上的门神分别是：";				           $AddMissionQuiz[21507,2,3] = "1";
$AddMissionQuiz[21507,1,4] = "《昆仑决双龙传》里的双龙指的是谁：";         $AddMissionQuiz[21507,2,4] = "3";

$AddMissionQuiz[21507,3,1] = "跋锋寒";	                                 $AddMissionQuiz[21507,4,1] = "侯希白";							$AddMissionQuiz[21507,5,1] = "雷九指";
$AddMissionQuiz[21507,3,2] = "李密";											               $AddMissionQuiz[21507,4,2] = "宇文化及";						$AddMissionQuiz[21507,5,2] = "李渊";
$AddMissionQuiz[21507,3,3] = "尉迟恭、秦叔宝";										       $AddMissionQuiz[21507,4,3] = "程咬金、罗成";				$AddMissionQuiz[21507,5,3] = "王伯当、雄阔海";
$AddMissionQuiz[21507,3,4] = "毕玄、颉利";				                       $AddMissionQuiz[21507,4,4] = "杨虚彦、宋师道";			$AddMissionQuiz[21507,5,4] = "徐子陵、寇仲";

$AddMissionQuiz[21607,1,1] = "在《昆仑决双龙传》里被称为多情公子的人是？"; $AddMissionQuiz[21607,2,1] = "2";
$AddMissionQuiz[21607,1,2] = "单雄忠是被谁一箭射下马？";					       $AddMissionQuiz[21607,2,2] = "3";
$AddMissionQuiz[21607,1,3] = "贴在门上的门神分别是：";				           $AddMissionQuiz[21607,2,3] = "1";
$AddMissionQuiz[21607,1,4] = "《昆仑决双龙传》里的双龙指的是谁：";         $AddMissionQuiz[21607,2,4] = "3";

$AddMissionQuiz[21607,3,1] = "跋锋寒";	                                 $AddMissionQuiz[21607,4,1] = "侯希白";							$AddMissionQuiz[21607,5,1] = "雷九指";
$AddMissionQuiz[21607,3,2] = "李密";											               $AddMissionQuiz[21607,4,2] = "宇文化及";						$AddMissionQuiz[21607,5,2] = "李渊";
$AddMissionQuiz[21607,3,3] = "尉迟恭、秦叔宝";										       $AddMissionQuiz[21607,4,3] = "程咬金、罗成";				$AddMissionQuiz[21607,5,3] = "王伯当、雄阔海";
$AddMissionQuiz[21607,3,4] = "毕玄、颉利";				                       $AddMissionQuiz[21607,4,4] = "杨虚彦、宋师道";			$AddMissionQuiz[21607,5,4] = "徐子陵、寇仲";


$AddMissionQuiz[21130,1,1] = "在《昆仑决双龙传》里被称为多情公子的人是？"; $AddMissionQuiz[21130,2,1] = "2";
$AddMissionQuiz[21130,1,2] = "单雄忠是被谁一箭射下马？";					       $AddMissionQuiz[21130,2,2] = "3";
$AddMissionQuiz[21130,1,3] = "贴在门上的门神分别是：";				           $AddMissionQuiz[21130,2,3] = "1";
$AddMissionQuiz[21130,1,4] = "《昆仑决双龙传》里的双龙指的是谁：";         $AddMissionQuiz[21130,2,4] = "3";

$AddMissionQuiz[21130,3,1] = "跋锋寒";	                                 $AddMissionQuiz[21130,4,1] = "侯希白";							$AddMissionQuiz[21130,5,1] = "雷九指";
$AddMissionQuiz[21130,3,2] = "李密";											               $AddMissionQuiz[21130,4,2] = "宇文化及";						$AddMissionQuiz[21130,5,2] = "李渊";
$AddMissionQuiz[21130,3,3] = "尉迟恭、秦叔宝";										       $AddMissionQuiz[21130,4,3] = "程咬金、罗成";				$AddMissionQuiz[21130,5,3] = "王伯当、雄阔海";
$AddMissionQuiz[21130,3,4] = "毕玄、颉利";				                       $AddMissionQuiz[21130,4,4] = "杨虚彦、宋师道";			$AddMissionQuiz[21130,5,4] = "徐子陵、寇仲";

$AddMissionQuiz[21407,1,1] = "下列不是《井中八法》的招式是哪个选项？";				    $AddMissionQuiz[21407,2,1] = "3";
$AddMissionQuiz[21407,1,2] = "下列哪个是“不攻”的心得要诀？";					      		$AddMissionQuiz[21407,2,2] = "1";
$AddMissionQuiz[21407,1,3] = "寇仲除了《井中八法》还自己领悟了什么刀法？";				$AddMissionQuiz[21407,2,3] = "2";

$AddMissionQuiz[21407,3,1] = "不攻，击奇，用谋，兵诈。";	                        $AddMissionQuiz[21407,4,1] = "棋奕，战定、速战、方圆。";		$AddMissionQuiz[21407,5,1] = "不守，猛攻，诈败，奔袭。";
$AddMissionQuiz[21407,3,2] = "故用兵之法，恃吾有以待也。";				                $AddMissionQuiz[21407,4,2] = "非必取不出众，非全胜不交兵。"; $AddMissionQuiz[21407,5,2] = "善出奇者，无穷如天地，并而击之。";
$AddMissionQuiz[21407,3,3] = "血战十式";										     									$AddMissionQuiz[21407,4,3] = "长征刀法";										$AddMissionQuiz[21407,5,3] = "天问九刀";

$AddMissionQuiz[21457,1,1] = "下列不是《井中八法》的招式是哪个选项？";				    $AddMissionQuiz[21457,2,1] = "3";
$AddMissionQuiz[21457,1,2] = "下列哪个是“不攻”的心得要诀？";					      		$AddMissionQuiz[21457,2,2] = "1";
$AddMissionQuiz[21457,1,3] = "寇仲除了《井中八法》还自己领悟了什么刀法？";				$AddMissionQuiz[21457,2,3] = "2";

$AddMissionQuiz[21457,3,1] = "不攻，击奇，用谋，兵诈。";	                        $AddMissionQuiz[21457,4,1] = "棋奕，战定、速战、方圆。";    $AddMissionQuiz[21457,5,1] = "不守，猛攻，诈败，奔袭。";
$AddMissionQuiz[21457,3,2] = "故用兵之法，恃吾有以待也。";				                $AddMissionQuiz[21457,4,2] = "非必取不出众，非全胜不交兵。"; $AddMissionQuiz[21457,5,2] = "善出奇者，无穷如天地，并而击之。";
$AddMissionQuiz[21457,3,3] = "血战十式";										     									$AddMissionQuiz[21457,4,3] = "长征刀法";										$AddMissionQuiz[21457,5,3] = "天问九刀";


//特殊的答题任务：10020
$AddMissionQuizOneTopic[10020,1,1] = "<t>很简单只要你能对得出诗句的下一句就算你过关。</t><b/><b/><t>朝辞白帝彩云间，千里江陵一日还。</t><b/><t>下一句是什么？</t>";
$AddMissionQuizOneTopic[10020,2,1] = "<t>想过我这关没这么容易！</t><b/><b/><t>水光潋滟晴方好，山色空蒙雨亦奇。</t><b/><t>下一句是什么？</t>";
$AddMissionQuizOneTopic[10020,3,1] = "<t>想和我对诗？我想你还不是我的对手！</t><b/><b/><t>渭城朝雨浥轻尘，客舍青青柳色新。</t><b/><t>下一句是什么？</t>";

$AddMissionQuizOneTopic[10020,1,2] = "2";
$AddMissionQuizOneTopic[10020,2,2] = "1";
$AddMissionQuizOneTopic[10020,3,2] = "3";

$AddMissionQuizOneTopic[10020,1,3] = "孤帆远影碧空尽，唯见长江天际流。"; $AddMissionQuizOneTopic[10020,1,4] = "两岸猿声啼不住，轻舟已过万重山。"; $AddMissionQuizOneTopic[10020,1,5] = "羌笛何须怨杨柳，春风不度玉门关。";
$AddMissionQuizOneTopic[10020,2,3] = "欲把西湖比西子，淡妆浓抹总相宜。"; $AddMissionQuizOneTopic[10020,2,4] = "停车坐爱枫林晚，霜叶红于二月花。"; $AddMissionQuizOneTopic[10020,2,5] = "乱花渐欲迷人眼，浅草才能没马蹄。";
$AddMissionQuizOneTopic[10020,3,3] = "莫愁前路无知己，天下谁人不识君。"; $AddMissionQuizOneTopic[10020,3,4] = "桃花潭水深千尺，不及汪伦送我情。"; $AddMissionQuizOneTopic[10020,3,5] = "劝君更尽一杯酒，西出阳关无故人。";


//■■■■■■■■■■■官职系统【领取俸禄】■■■■■■■■■■■■■■■■■■■
//武官官职的俸禄
$GuanZhiFengLu_Mili[500,1] = 50000; $GuanZhiFengLu_Mili[500,2] = 5000; $GuanZhiFengLu_Mili[500,3] = 5;
$GuanZhiFengLu_Mili[501,1] = 100000; $GuanZhiFengLu_Mili[501,2] = 10000; $GuanZhiFengLu_Mili[501,3] = 10;
$GuanZhiFengLu_Mili[502,1] = 200000; $GuanZhiFengLu_Mili[502,2] = 20000; $GuanZhiFengLu_Mili[502,3] = 20;
$GuanZhiFengLu_Mili[503,1] = 400000; $GuanZhiFengLu_Mili[503,2] = 30000; $GuanZhiFengLu_Mili[503,3] = 30;
$GuanZhiFengLu_Mili[504,1] = 600000; $GuanZhiFengLu_Mili[504,2] = 40000; $GuanZhiFengLu_Mili[504,3] = 40;
$GuanZhiFengLu_Mili[505,1] = 800000; $GuanZhiFengLu_Mili[505,2] = 50000; $GuanZhiFengLu_Mili[505,3] = 50;
$GuanZhiFengLu_Mili[506,1] = 1000000; $GuanZhiFengLu_Mili[506,2] = 60000; $GuanZhiFengLu_Mili[506,3] = 60;
$GuanZhiFengLu_Mili[507,1] = 2000000; $GuanZhiFengLu_Mili[507,2] = 70000; $GuanZhiFengLu_Mili[507,3] = 70;
$GuanZhiFengLu_Mili[508,1] = 2500000; $GuanZhiFengLu_Mili[508,2] = 80000; $GuanZhiFengLu_Mili[508,3] = 80;
$GuanZhiFengLu_Mili[509,1] = 3000000; $GuanZhiFengLu_Mili[509,2] = 90000; $GuanZhiFengLu_Mili[509,3] = 90;
$GuanZhiFengLu_Mili[510,1] = 3500000; $GuanZhiFengLu_Mili[510,2] = 100000; $GuanZhiFengLu_Mili[510,3] = 100;
$GuanZhiFengLu_Mili[511,1] = 4000000; $GuanZhiFengLu_Mili[511,2] = 120000; $GuanZhiFengLu_Mili[511,3] = 120;
$GuanZhiFengLu_Mili[512,1] = 5000000; $GuanZhiFengLu_Mili[512,2] = 130000; $GuanZhiFengLu_Mili[512,3] = 130;
$GuanZhiFengLu_Mili[513,1] = 6000000; $GuanZhiFengLu_Mili[513,2] = 140000; $GuanZhiFengLu_Mili[513,3] = 140;
$GuanZhiFengLu_Mili[514,1] = 7000000; $GuanZhiFengLu_Mili[514,2] = 150000; $GuanZhiFengLu_Mili[514,3] = 150;
$GuanZhiFengLu_Mili[515,1] = 8000000; $GuanZhiFengLu_Mili[515,2] = 160000; $GuanZhiFengLu_Mili[515,3] = 160;
$GuanZhiFengLu_Mili[516,1] = 9000000; $GuanZhiFengLu_Mili[516,2] = 180000; $GuanZhiFengLu_Mili[516,3] = 180;
$GuanZhiFengLu_Mili[517,1] = 10000000; $GuanZhiFengLu_Mili[517,2] = 200000; $GuanZhiFengLu_Mili[517,3] = 200;
//文官官职的俸禄
$GuanZhiFengLu_Civi[550,1] = 50000; $GuanZhiFengLu_Civi[550,2] = 5000; $GuanZhiFengLu_Civi[550,3] = 5;
$GuanZhiFengLu_Civi[551,1] = 100000; $GuanZhiFengLu_Civi[551,2] = 10000; $GuanZhiFengLu_Civi[551,3] = 10;
$GuanZhiFengLu_Civi[552,1] = 200000; $GuanZhiFengLu_Civi[552,2] = 20000; $GuanZhiFengLu_Civi[552,3] = 20;
$GuanZhiFengLu_Civi[553,1] = 400000; $GuanZhiFengLu_Civi[553,2] = 30000; $GuanZhiFengLu_Civi[553,3] = 30;
$GuanZhiFengLu_Civi[554,1] = 600000; $GuanZhiFengLu_Civi[554,2] = 40000; $GuanZhiFengLu_Civi[554,3] = 40;
$GuanZhiFengLu_Civi[555,1] = 800000; $GuanZhiFengLu_Civi[555,2] = 50000; $GuanZhiFengLu_Civi[555,3] = 50;
$GuanZhiFengLu_Civi[556,1] = 1000000; $GuanZhiFengLu_Civi[556,2] = 60000; $GuanZhiFengLu_Civi[556,3] = 60;
$GuanZhiFengLu_Civi[557,1] = 2000000; $GuanZhiFengLu_Civi[557,2] = 70000; $GuanZhiFengLu_Civi[557,3] = 70;
$GuanZhiFengLu_Civi[558,1] = 2500000; $GuanZhiFengLu_Civi[558,2] = 80000; $GuanZhiFengLu_Civi[558,3] = 80;
$GuanZhiFengLu_Civi[559,1] = 3000000; $GuanZhiFengLu_Civi[559,2] = 90000; $GuanZhiFengLu_Civi[559,3] = 90;
$GuanZhiFengLu_Civi[560,1] = 3500000; $GuanZhiFengLu_Civi[560,2] = 100000; $GuanZhiFengLu_Civi[560,3] = 100;
$GuanZhiFengLu_Civi[561,1] = 4000000; $GuanZhiFengLu_Civi[561,2] = 120000; $GuanZhiFengLu_Civi[561,3] = 120;
$GuanZhiFengLu_Civi[562,1] = 5000000; $GuanZhiFengLu_Civi[562,2] = 130000; $GuanZhiFengLu_Civi[562,3] = 130;
$GuanZhiFengLu_Civi[563,1] = 6000000; $GuanZhiFengLu_Civi[563,2] = 140000; $GuanZhiFengLu_Civi[563,3] = 140;
$GuanZhiFengLu_Civi[564,1] = 7000000; $GuanZhiFengLu_Civi[564,2] = 150000; $GuanZhiFengLu_Civi[564,3] = 150;
$GuanZhiFengLu_Civi[565,1] = 8000000; $GuanZhiFengLu_Civi[565,2] = 160000; $GuanZhiFengLu_Civi[565,3] = 160;
$GuanZhiFengLu_Civi[566,1] = 9000000; $GuanZhiFengLu_Civi[566,2] = 180000; $GuanZhiFengLu_Civi[566,3] = 180;
$GuanZhiFengLu_Civi[567,1] = 10000000; $GuanZhiFengLu_Civi[567,2] = 200000; $GuanZhiFengLu_Civi[567,3] = 200;
//■■■■■■■■■■■官职系统【领取俸禄】■■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【帮派成员】■■■■■■■【全局变量显示】■■■■■■■■■
$OrgMemberLevel[0] = "新进帮众";
$OrgMemberLevel[1] = "普通成员";
$OrgMemberLevel[2] = "高级成员";
$OrgMemberLevel[3] = "精英成员";
$OrgMemberLevel[4] = "元老成员";
$OrgMemberLevel[5] = "副帮主";
$OrgMemberLevel[6] = "帮主";


//■■■■■■■■■■■【剧情副本排名相关全局变量】■■■■■■■■■■■■■
$JuQingRanking_MapID[1] = 1311; $JuQingRanking_MapID[1311] = 100; $JuQingRanking_MapName[1311] = "三打瓦岗寨";
$JuQingRanking_MapID[2] = 1312; $JuQingRanking_MapID[1312] = 101; $JuQingRanking_MapName[1312] = "虎牢关之战";
$JuQingRanking_MapID[3] = 1313; $JuQingRanking_MapID[1313] = 102; $JuQingRanking_MapName[1313] = "中日第一站";
$JuQingRanking_MapID[4] = 1314; $JuQingRanking_MapID[1314] = 103; $JuQingRanking_MapName[1314] = "问鼎天下";
$JuQingRanking_MapID[5] = 1349; $JuQingRanking_MapID[1349] = 104; $JuQingRanking_MapName[1349] = "挑战名将";


//■■■■■■■■■■■【金币复活所需消耗】■■■■■■■■■■■■■■■■■
$PlayerEnabledMoney[0] = 500;
$PlayerEnabledMoney[1] = 2000;
$PlayerEnabledMoney[2] = 5000;
$PlayerEnabledMoney[3] = 10000;
$PlayerEnabledMoney[4] = 20000;
$PlayerEnabledMoney[5] = 50000;
$PlayerEnabledMoney[6] = 100000;
$PlayerEnabledMoney[7] = 150000;
$PlayerEnabledMoney[8] = 200000;
$PlayerEnabledMoney[9] = 250000;
$PlayerEnabledMoney[10]= 300000;
$PlayerEnabledMoney[11]= 350000;
$PlayerEnabledMoney[12]= 400000;
$PlayerEnabledMoney[13]= 400000;
$PlayerEnabledMoney[14]= 400000;
$PlayerEnabledMoney[15]= 400000;
$PlayerEnabledMoney[16]= 400000;
$PlayerEnabledMoney[17]= 400000;
$PlayerEnabledMoney[18]= 400000;
$PlayerEnabledMoney[19]= 400000;
$PlayerEnabledMoney[20]= 400000;

//■■■■■■■■■■■【聚宝盆全局变量】■■■■■■■■■■■■■■■■■■
$SL_JuBaoPeng_ShenMiJLTimes = 10;//兑换多少次可获得一次神秘奖励
//$SL_JuBaoPeng_DayTimes = 10;//每天可使用元宝兑换次数
$SL_JuBaoPeng_NeedGold[1] = 100;	   //使用元宝兑换需要的元宝数量
$SL_JuBaoPeng_NeedGold[2] = 200;	   //使用元宝兑换需要的元宝数量
$SL_JuBaoPeng_NeedGold[3] = 300;	   //使用元宝兑换需要的元宝数量
$SL_JuBaoPeng_NeedGold[4] = 400;	   //使用元宝兑换需要的元宝数量
$SL_JuBaoPeng_NeedGold[5] = 500;	   //使用元宝兑换需要的元宝数量
$SL_JuBaoPeng_NeedGold[6] = 600;	   //使用元宝兑换需要的元宝数量
$SL_JuBaoPeng_NeedGold[7] = 700;	   //使用元宝兑换需要的元宝数量
$SL_JuBaoPeng_NeedGold[8] = 800;	   //使用元宝兑换需要的元宝数量
$SL_JuBaoPeng_NeedGold[9] = 900;	   //使用元宝兑换需要的元宝数量
$SL_JuBaoPeng_NeedGold[10] = 1000;   //使用元宝兑换需要的元宝数量
//■■■■■■■■■■■【聚宝盆全局变量】■■■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【十日嘉年华奖励】■■■■■■■■■■■■■■■■■■
$KaiFuShiRi_Item[1] = "105100034";
$KaiFuShiRi_Item[2] = "105100035";
$KaiFuShiRi_Item[3] = "105100036";
$KaiFuShiRi_Item[4] = "105100037";
$KaiFuShiRi_Item[5] = "105100038";
$KaiFuShiRi_Item[6] = "105100039";
$KaiFuShiRi_Item[7] = "105100040";
$KaiFuShiRi_Item[8] = "105100041";
$KaiFuShiRi_Item[9] = "105100042";
$KaiFuShiRi_Item[10] = "105100043";

$KaiFuShiRiShenQi_Item[1] = "102013056";
$KaiFuShiRiShenQi_Item[2] = "102043056";
$KaiFuShiRiShenQi_Item[3] = "102023056";
$KaiFuShiRiShenQi_Item[4] = "102063056";
$KaiFuShiRiShenQi_Item[5] = "102053056";
$KaiFuShiRiShenQi_Item[6] = "102033056";
$KaiFuShiRiShenQi_Item[7] = "102073056";
$KaiFuShiRiShenQi_Item[8] = "103023010";
$KaiFuShiRiShenQi_Item[9] = "103033010";
$KaiFuShiRiShenQi_Item[10] = "103013010";

$KaiFuShiRiDiErMing_Item[1] = "116120074";
$KaiFuShiRiDiErMing_Item[2] = "116120072";
$KaiFuShiRiDiErMing_Item[3] = "116120072";
$KaiFuShiRiDiErMing_Item[4] = "116120072";
$KaiFuShiRiDiErMing_Item[5] = "116120072";
$KaiFuShiRiDiErMing_Item[6] = "116120072";
$KaiFuShiRiDiErMing_Item[7] = "116120072";
$KaiFuShiRiDiErMing_Item[8] = "116120072";
$KaiFuShiRiDiErMing_Item[9] = "116120075";
$KaiFuShiRiDiErMing_Item[10] = "116120072";

$KaiFuShiRiDiSanMing_Item[1] = "116120076";
$KaiFuShiRiDiSanMing_Item[2] = "116120073";
$KaiFuShiRiDiSanMing_Item[3] = "116120073";
$KaiFuShiRiDiSanMing_Item[4] = "116120073";
$KaiFuShiRiDiSanMing_Item[5] = "116120073";
$KaiFuShiRiDiSanMing_Item[6] = "116120073";
$KaiFuShiRiDiSanMing_Item[7] = "116120073";
$KaiFuShiRiDiSanMing_Item[8] = "116120073";
$KaiFuShiRiDiSanMing_Item[9] = "116120077";
$KaiFuShiRiDiSanMing_Item[10] = "116120073";



//■■■■■■■■■■■【十日嘉年华奖励】■■■■■■■■■■■■■■■■■■





//■■■■■■■■■■■【仙缘解签秀图标】■■■■■■■■■■■■■■■■■■
function getLiShangWangLaiShowItemID(%index)
{
		switch (%index)
	{
		case 1:  %ItemID =105099901;//50%元宝     105099901          
		case 2:  %ItemID =105099902;//100-500元宝           
		case 3:  %ItemID =105099903;//10000—100000元宝     
		case 4:  
			%ItemID =102101018;//男时装      105099904  
			%Sex = getplayer().getsex();
			if(%Sex==2) %ItemID =102101518;//女时装      105099904  
		case 5:  %ItemID =105099905;//1%—9%元宝            
		case 6:  %ItemID =105099906;//500-10000元宝         
		case 7:  %ItemID =105099907;//宝石                  
		case 8:  %ItemID =105099908;//10-50元宝             
		case 9:  %ItemID =105099909;//25%元宝               
		case 10: %ItemID =119013016;//坐骑                  
		case 11: %ItemID =105099911;//10%元宝               
		case 12: %ItemID =105099912;//50-100元宝            
		default: %ItemID =105099904;//时装	
	}
	return %ItemID;
}

//■■■■■■■■■■■【仙缘解签秀图标】■■■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【各职业各种全局变量】■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【各职业各种全局变量】■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【任务道具奖励】■■■■■■■■■■■■■■■■
//$MissionData_ItemChose[ %Mid ] = "102020001;1;102010001;1;"; //可选奖励设置
//$MissionData_ItemSet[ %Mid ] = "102020001;1;102010001;1;"; //必给奖励设置
//$Mission_Data_ItemClasses[ %Mid ] = "102020001;1;102010001;1;102040001;1;";//根据职业奖励设置

$MissionData_ItemChose[10031] ="101021000;1;101011000;1;101031000;1;101041000;1";//趁手武器
$MissionData_ItemChose[10271] ="101023000;1;101013000;1;101033000;1;101043000;1";//20紫色武器
$MissionData_ItemChose[10561] ="101023043;1;101013043;1;101033043;1;101043043;1";//30级紫武器
$MissionData_ItemChose[20206] ="101023044;1;101013044;1;101033044;1;101043044;1";//38级紫武器

$Mission_Data_ItemClasses[10115] ="102022000;1;102022050;1;102022200;1;102022250;1;102022300;1;102022350;1"; //青衫焕发		暂时不需要
$Mission_Data_ItemClasses[10161] ="103011000;1;103011200;1;103011300;1";//玲珑赠礼
$Mission_Data_ItemClasses[10191] ="103032000;1;103032200;1;103032300;1";//15戒指
$Mission_Data_ItemClasses[10232] ="102042000;1;102042050;1;102042200;1;102042250;1;102042300;1;102042350;1";//护肩
$Mission_Data_ItemClasses[10381] ="102033000;1;102033050;1;102033200;1;102033250;1;102033300;1;102033350;1";//披风
$Mission_Data_ItemClasses[20202] ="102011000;1;102011050;1;102011200;1;102011250;1;102011300;1;102011350;1";//头
$Mission_Data_ItemClasses[20203] ="102071000;1;102071050;1;102071200;1;102071250;1;102071300;1;102071350;1";//鞋子
$Mission_Data_ItemClasses[20204] ="102052002;1;102052052;1;102052202;1;102052252;1;102052302;1;102052352;1";//15蓝色护手

$Mission_Data_ItemClasses[10511] ="102043043;1;102043093;1;102043243;1;102043293;1;102043343;1;102043393;1";//30护肩
$Mission_Data_ItemClasses[10601] ="102023043;1;102023093;1;102023243;1;102023293;1;102023343;1;102023393;1";//30衣
$Mission_Data_ItemClasses[10621] ="103013043;1;103013243;1;103013343;1;103023043;1;103023243;1;103023343;1";//30饰品
$Mission_Data_ItemClasses[ 10641 ] ="103033043;1;103033243;1;103033343;1";//30护符
$Mission_Data_ItemClasses[ 10651 ] ="102073043;1;102073093;1;102073243;1;102073293;1;102073343;1;102073393;1";//30鞋
$Mission_Data_ItemClasses[10661] ="102053043;1;102053093;1;102053243;1;102053293;1;102053343;1;102053393;1";//30护手
$Mission_Data_ItemClasses[10771] ="102063043;1;102063093;1;102063243;1;102063293;1;102063343;1;102063393;1";//30腰带
$Mission_Data_ItemClasses[10751] ="102013083;1;102013093;1;102013243;1;102013293;1;102013343;1;102013393;1";//30头

//sptgetplayer(50000051).setmission(10001,0);AddMissionAccepted( sptgetplayer(50000051), 0, 10001 );
//■■■■■■■■■■■【任务道具奖励】■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【押镖活动押金】■■■■■■■■■■■■■■■■
//------依次为 镖车品质 劫镖的押金档次  接任务消耗 交任务获得金 第一次被劫掉落 劫镖者交镖奖励金 再次被劫掉落
$YaBiaoHuoDong_Gold[600000041]= "1 1 5000 8000 1750 2800 1750";
$YaBiaoHuoDong_Gold[600000042]= "1 2 8000 14400 2800 5040 2800";
$YaBiaoHuoDong_Gold[600000043]= "1 3 10000 20000 3500 7000 3500";

$YaBiaoHuoDong_Gold[600000044]= "2 1 10000 16000 3500 5600 3500";
$YaBiaoHuoDong_Gold[600000045]= "2 2 20000 36000 7000 12600 7000";
$YaBiaoHuoDong_Gold[600000046]= "2 3 30000 60000 10500 21000 10500";

$YaBiaoHuoDong_Gold[600000047]= "3 1 30000 48000 10500 16800 10500";
$YaBiaoHuoDong_Gold[600000048]= "3 2 60000 108000 21000 37800 21000";
$YaBiaoHuoDong_Gold[600000049]= "3 3 80000 160000 28000 56000 28000";

$YaBiaoHuoDong_Gold[600000050]= "4 1 100000 160000 35000 56000 35000";
$YaBiaoHuoDong_Gold[600000051]= "4 2 150000 270000 52500 94500 52500";
$YaBiaoHuoDong_Gold[600000052]= "4 3 200000 400000 70000 140000 70000";

$YaBiaoHuoDong_Gold[600000053]= "5 1 500000 800000 175000 280000 175000";
$YaBiaoHuoDong_Gold[600000054]= "5 2 1000000 1800000 350000 630000 350000";
$YaBiaoHuoDong_Gold[600000055]= "5 3 2000000 4000000 700000 1400000 700000";

$YaBiaoHuoDong_StateRecord[1,1] = 600000041;
$YaBiaoHuoDong_StateRecord[1,2] = 600000042;
$YaBiaoHuoDong_StateRecord[1,3] = 600000043;
$YaBiaoHuoDong_StateRecord[2,1] = 600000044;
$YaBiaoHuoDong_StateRecord[2,2] = 600000045;
$YaBiaoHuoDong_StateRecord[2,3] = 600000046;
$YaBiaoHuoDong_StateRecord[3,1] = 600000047;
$YaBiaoHuoDong_StateRecord[3,2] = 600000048;
$YaBiaoHuoDong_StateRecord[3,3] = 600000049;
$YaBiaoHuoDong_StateRecord[4,1] = 600000050;
$YaBiaoHuoDong_StateRecord[4,2] = 600000051;
$YaBiaoHuoDong_StateRecord[4,3] = 600000052;
$YaBiaoHuoDong_StateRecord[5,1] = 600000053;
$YaBiaoHuoDong_StateRecord[5,2] = 600000054;
$YaBiaoHuoDong_StateRecord[5,3] = 600000055;

$YaBiaoHuoDong_Item[1,1] = "105105301 2 1800";	   //金叶子
$YaBiaoHuoDong_Item[1,2] = "105105302 3 200";	   //金锭
$YaBiaoHuoDong_Item[1,3] = "105180150 2 0";	   //宝石随机礼包( 1级 )
$YaBiaoHuoDong_Item[2,1] = "105105301 2 2000";	//金叶子	
$YaBiaoHuoDong_Item[2,2] = "105105302 3 220";	//金锭	
$YaBiaoHuoDong_Item[2,3] = "105180150 2 50";	//宝石随机礼包( 1级 )	
$YaBiaoHuoDong_Item[3,1] = "105105301 2 2000";	  //金叶子
$YaBiaoHuoDong_Item[3,2] = "105105302 3 250";	  //金锭
$YaBiaoHuoDong_Item[3,3] = "105105303 3 20";	  //金条
$YaBiaoHuoDong_Item[3,4] = "105180150 2 50";	  //宝石随机礼包( 1级 )
$YaBiaoHuoDong_Item[4,1] = "105105301 2 2000"; //金叶子
$YaBiaoHuoDong_Item[4,2] = "105105302 3 1000"; //金锭
$YaBiaoHuoDong_Item[4,3] = "105105303 3 500"; //金条
$YaBiaoHuoDong_Item[4,4] = "105180150 2 100"; //宝石随机礼包( 1级 )
$YaBiaoHuoDong_Item[4,5] = "105180151 3 20"; //宝石随机礼包( 2级 )
$YaBiaoHuoDong_Item[5,1] = "105105301 2 5000"; //金叶子
$YaBiaoHuoDong_Item[5,2] = "105105302 3 10000"; //金锭
$YaBiaoHuoDong_Item[5,3] = "105105303 3 2000"; //金条
$YaBiaoHuoDong_Item[5,4] = "105105304 3 1000"; //金砖
$YaBiaoHuoDong_Item[5,5] = "105180150 2 1000"; //宝石随机礼包( 1级 )
$YaBiaoHuoDong_Item[5,6] = "105180151 3 500"; //宝石随机礼包( 2级 )
$YaBiaoHuoDong_Item[5,7] = "105180152 3 200"; //宝石随机礼包( 3级 )

//■■■■■■■■■■■【押镖活动押金】■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【领取奖品界面】■■■■■■■■■■■■■■■■
//新手登录
$UpLineParty_QiTianHaoLiItem[1]= 105180211;//	新手豪华礼包（第一天）时装锦盒
$UpLineParty_QiTianHaoLiItem[2]= 105109301;//	新手豪华礼包（第二天）蓬莱仙钓参赛券
$UpLineParty_QiTianHaoLiItem[3]= 112010056;//	新手豪华礼包（第三天）6格乾坤袋( 赠品 )
$UpLineParty_QiTianHaoLiItem[4]= 105090911;//	新手豪华礼包（第四天）昆仑通宝( 赠品 )
$UpLineParty_QiTianHaoLiItem[5]= 105028022;//	新手豪华礼包（第五天）三倍经验丹( 赠品 )
$UpLineParty_QiTianHaoLiItem[6]= 105104919;//	新手豪华礼包（第六天）100万经验卷
$UpLineParty_QiTianHaoLiItem[7]= 105104923;//	新手豪华礼包（第七天）500万经验卷

//每日活跃奖励
$MeiRiLiLian_HuoYueDu[1] = 1;
$MeiRiLiLian_HuoYueDu[2] = 35;
$MeiRiLiLian_HuoYueDu[3] = 75;
$MeiRiLiLian_HuoYueDu[4] = 90;

function GetMeiRiLiLianItem(%optype)
{
	switch ($SL_ManYueQingDian_State_bActive)
	{
		case 1://新服满月庆典
			switch (%optype)
			{
				case 1:return 105180006;//日活跃礼包( 初级 )
				case 2:return 105180007;//日活跃礼包( 中级 )
				case 3:return 105180008;//日活跃礼包( 高级 )
				case 4:return 105180009;//日活跃礼包( 豪华 )
			}
		default:
			switch (%optype)
			{
				case 1:return 105180001;//日活跃礼包( 初级 )
				case 2:return 105180002;//日活跃礼包( 中级 )
				case 3:return 105180003;//日活跃礼包( 高级 )
				case 4:return 105180004;//日活跃礼包( 豪华 )
			}
	}
}
//每日签到奖励
$QianDaoBuQian = 200;//补签需要的元宝
function GetMeiRiQianDaoLingJiangItem()
{
	switch ($SL_ManYueQingDian_State_bActive)
	{
		case 1:
			return 105180025;//每日签到礼包
		default:
			return 105180020; //每日签到礼包
	}
}
$MeiYueLeiJiQianDao[1] = 3;
$MeiYueLeiJiQianDao[2] = 7;
$MeiYueLeiJiQianDao[3] = 15;
$MeiYueLeiJiQianDao[4] = 25;

function GetMeiYueLeiJiQianDaoItem(%optype)
{
	switch ($SL_ManYueQingDian_State_bActive)
	{
		case 1://新服满月庆典
			switch (%optype)
			{
				case 1:return 105180035;//月登录礼包（3天）
				case 2:return 105180036;//月登录礼包（7天）
				case 3:return 105180037;//月登录礼包（15天）
				case 4:return 105180038;//月登录礼包（25天）
			}
		default:
			switch (%optype)
			{
				case 1:return 105180030;//月登录礼包（3天）
				case 2:return 105180031;//月登录礼包（7天）
				case 3:return 105180032;//月登录礼包（15天）
				case 4:return 105180033;//月登录礼包（25天）
			}
	}
}
//等级礼包 ID 领取等级 记录的SRCID
$UpLineLevelGiftMaxNum = 14;//礼包数量+1
$UpLineLevelGift[1] = "105180040 10 16";
$UpLineLevelGift[2] = "105180041 20 17";
$UpLineLevelGift[3] = "105180042 30 18";
$UpLineLevelGift[4] = "105180043 35 19";
$UpLineLevelGift[5] = "105180044 40 20";
$UpLineLevelGift[6] = "105180045 45 21";
$UpLineLevelGift[7] = "105180046 50 22";
$UpLineLevelGift[8] = "105180047 55 23";
$UpLineLevelGift[9] = "105180048 60 24";
$UpLineLevelGift[10]= "105180049 65 25";
$UpLineLevelGift[11]= "105180050 70 26";
$UpLineLevelGift[12]= "105180051 75 27";
$UpLineLevelGift[13]= "105180052 80 28";
$UpLineLevelGift[14]= "105180053 85 29";

//$UpLineLevelGift[15]= "105180054 90 30";
//$UpLineLevelGift[16]= "105180055 95 31";
//$UpLineLevelGift[17]= "105180056 100 32";

//----文本 记录方式 记录编号 计数数量 活跃度
$HuoYueDuRecord[1,1] = "★在线15分钟 Src 12 1 1";
$HuoYueDuRecord[1,2] = "★在线30分钟 Src 13 1 3";
$HuoYueDuRecord[1,3] = "★在线1小时 Src 14 1 5";
$HuoYueDuRecord[1,4] = "★在线2小时 Src 15 1 10";

$HuoYueDuRecord[2,1] = "★师门尽忠 Act0 4015 10 5";
$HuoYueDuRecord[2,2] = "★时空裂痕 Act0 3029 1 6";
$HuoYueDuRecord[2,3] = "★炼魔渊 Act0 3030 1 6";
$HuoYueDuRecord[2,4] = "★血魔封印阵 src 57 1 6";
$HuoYueDuRecord[2,5] = "★冰火试炼 Spcl 1 7 8";
$HuoYueDuRecord[2,6] = "★幻境争霸 Src 4 1 8";
$HuoYueDuRecord[2,7] = "★鸿蒙试炼 Src 5 1 8";
$HuoYueDuRecord[2,8] = "★刀剑神域 Spcl 4 1 8";

$HuoYueDuRecord[3,1] = "★押镖 Spcl 2 1 2";
$HuoYueDuRecord[3,2] = "★悬赏缉凶 Spcl 3 1 8";
$HuoYueDuRecord[3,3] = "★黄金宝藏 Act0 4093 1 3";
$HuoYueDuRecord[3,4] = "★诛妖 Act0 4012 3 2";
$HuoYueDuRecord[3,5] = "★藏宝图 Act1 4012 3 3";
$HuoYueDuRecord[3,6] = "★群英汇聚 Src 3 1 4";
$HuoYueDuRecord[3,7] = "★趣味答题 Act0 4101 5 4";//暂时没有记录
$HuoYueDuRecord[3,8] = "★蓬莱仙钓 Act1 4022 3 4";
$HuoYueDuRecord[3,9] = "★聆经悟道 Act1 4023 3 2";
$HuoYueDuRecord[3,10] = "★首座论经 Act0 4024 3 6";

//---------------------简单描述1-------------
if ($Now_Script == 1)
{
	$HuoYueDuText1[1,1] = "<b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "★保持在线15分钟</t>";
	$HuoYueDuText1[1,2] = "<b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "★保持在线30分钟</t>";
	$HuoYueDuText1[1,3] = "<b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "★保持在线1小时</t>";
	$HuoYueDuText1[1,4] = "<b/><b/>" @
		$Get_Dialog_GeShi[31428] @ "★保持在线2小时</t>";

	$HuoYueDuText1[2,1] = $Get_Dialog_GeShi[31428] @
		"<t>★大量经验奖励</t><b/><b/>" @
		"<t>★完成10次并且无放弃记录，奖励</t>" @ "<l i='" @ 105109341 @ "' t='itemid'/>" @ "<b/><b/>" @
		"<t>★前往 蓬莱</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100001);\",\"" @ $Get_Dialog_GeShi[31414] @ GetNpcData(410100001,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>参加</t></t>";

	$HuoYueDuText1[2,2] = $Get_Dialog_GeShi[31428] @
		"<t>★活动时间 19：00 - 22:00</t><b/><b/>" @
		"<t>★大量经验奖励</t><b/><b/>" @
		"<t>★前往 昆仑</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010209);\",\"" @ $Get_Dialog_GeShi[31414] @ GetNpcData(410010209,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>参加</t></t>";

	$HuoYueDuText1[2,3] = $Get_Dialog_GeShi[31428] @ "<b/>" @
		"<t>★珍惜道具奖励</t><b/><b/>" @
		"<t>★前往 昆仑</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010204);\",\"" @ $Get_Dialog_GeShi[31414] @ GetNpcData(410010204,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>参加</t></t>";

	$HuoYueDuText1[2,4] = $Get_Dialog_GeShi[31428] @ "<b/>" @
		"<t>★大量经验奖励</t><b/><b/>" @
		"<t>★前往 昆仑</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010203);\",\"" @ $Get_Dialog_GeShi[31414] @ GetNpcData(410010203,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>参加</t></t>";

	$HuoYueDuText1[2,5] = $Get_Dialog_GeShi[31428] @
		"<t>★完成7组不同的试炼任务</t><b/><b/>" @
		"<t>★大量经验奖励</t><b/><b/>" @
		"<t>★前往 昆仑</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010141);\",\"" @ $Get_Dialog_GeShi[31414] @ GetNpcData(410010141,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>参加</t><b/><b/>" @
		$Get_Dialog_GeShi[31499] @ "★该地图为高危险危区域</t></t>";

	$HuoYueDuText1[2,6] = $Get_Dialog_GeShi[31428] @
		"<t>★活动时间 周一、三、五 20:00 - 20:05</t><b/><b/>" @
		"<t>★大量经验奖励，珍惜道具</t><b/><b/>" @
		"<t>★前往 昆仑</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath( 410010211);\",\"" @ $Get_Dialog_GeShi[31414] @ GetNpcData(410010211,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>参加</t></t>";

	$HuoYueDuText1[2,7] = $Get_Dialog_GeShi[31428] @
		"<t>★活动时间 周二、四、六 20:00 - 20:05</t><b/><b/>" @
		"<t>★大量经验奖励，珍惜道具</t><b/><b/>" @
		"<t>★前往 昆仑</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath( 410010212);\",\"" @ $Get_Dialog_GeShi[31414] @ GetNpcData(410010212,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>参加</t></t>";

	$HuoYueDuText1[2,8] = $Get_Dialog_GeShi[31428] @
		"<t>★活动时间  21:10 - 21:40</t><b/><b/>" @
		"<t>★大量经验奖励，珍惜道具</t><b/><b/>" @
		"<t>★前往 昆仑</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath( 410010212);\",\"" @ $Get_Dialog_GeShi[31414] @ GetNpcData(410010212,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>参加</t></t>";


	$HuoYueDuText1[3,1] = $Get_Dialog_GeShi[31428] @
		"<t>★活动时间 12:00 - 23:00</t><b/><b/>" @
		"<t>★大量金币奖励，押镖一次获得2点活跃度，满10点</t><b/><b/>" @
		"<t>★前往 封魔城</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(411190001);\",\"" @ $Get_Dialog_GeShi[31414] @ GetNpcData(411190001,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>参加</t><b/><b/>" @
		$Get_Dialog_GeShi[31499] @ "★该地图为高危险危区域</t></t>";
	
	if ($Now_Script == 1)
	{
		if (GetPlayer().GetLevel() < 45)
			$HuoYueDuText1[3, 2] = $Get_Dialog_GeShi[31428] @ "<t>★悬赏缉凶任务分为白、绿、蓝、紫、橙不同品级</t><b/><b/>" @
			"<t>★不同品级的任务奖励不同，获得活跃度也不同（2至8点）</t><b/><b/>" @
			"<t>★前往 望仙谷</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(411010010);\",\"" @ $Get_Dialog_GeShi[31414] @ GetNpcData(411010010, 1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>参加</t></t>";
		else
			$HuoYueDuText1[3, 2] = $Get_Dialog_GeShi[31428] @ "<t>★悬赏缉凶任务分为白、绿、蓝、紫、橙不同品级</t><b/><b/>" @
			"<t>★不同品级的任务奖励不同，获得活跃度也不同（2至8点）</t><b/><b/>" @
			"<t>★前往 苍山雪海</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(411020003);\",\"" @ $Get_Dialog_GeShi[31414] @ GetNpcData(411020003, 1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>参加</t></t>";
	}
	
	$HuoYueDuText1[3,3] = $Get_Dialog_GeShi[31428] @ "<b/><b/>" @
		"<t>★大量金币奖励</t><b/><b/>" @
		"<t>★前往 昆仑</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010206);\",\"" @ $Get_Dialog_GeShi[31414] @ GetNpcData(410010206,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>参加</t></t>";

	$HuoYueDuText1[3,4] = $Get_Dialog_GeShi[31428] @ "<b/><b/>" @
		"<t>★金币奖励，有机会获得</t>" @  "<l i='" @ 113090002 @ "' t='itemid'/>"  @ "<b/><b/>" @
		"<t>★前往 昆仑</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010205);\",\"" @ $Get_Dialog_GeShi[31414] @ GetNpcData(410010205,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>参加</t></t>";


	$HuoYueDuText1[3,5] = $Get_Dialog_GeShi[31428] @ "<b/><b/>" @
		"<t>★珍惜道具奖励</t><b/><b/>" @
		"<t>★前往 昆仑</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010205);\",\"" @ $Get_Dialog_GeShi[31414] @ GetNpcData(410010205,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>了解</t></t>";

	$HuoYueDuText1[3,6] = $Get_Dialog_GeShi[31428] @
		"<t>★活动时间 19:00 - 20:00</t><b/><b/>" @
		"<t>★经验奖励</t><b/><b/>" @
		"<t>★前往 </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010107); \",\"" @ $Get_Dialog_GeShi[31414] @"昆仑</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>了解</t></t>";

	$HuoYueDuText1[3,7] = $Get_Dialog_GeShi[31428] @
		"<t>★活动时间 19:00 - 20:00</t><b/><b/>" @
		"<t>★经验奖励</t><b/><b/>" @
		"<t>★前往 </t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410010107); \",\"" @ $Get_Dialog_GeShi[31414] @"昆仑</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>了解</t></t>";

	$HuoYueDuText1[3,8] = $Get_Dialog_GeShi[31428] @
		"<t>★活动时间 18:30 - 19:00</t><b/><b/>" @
		"<t>★珍惜道具、稀有称号</t><b/><b/>" @
		"<t>★前往 蓬莱</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100012);\",\"" @ $Get_Dialog_GeShi[31414] @ GetNpcData(410100012,1) @ "</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>参加</t></t>";

	$HuoYueDuText1[3,9] = $Get_Dialog_GeShi[31428] @ "<b/>" @
		"<t>★经验奖励、</t>" @  "<l i='" @ 105109314 @ "' t='itemid'/>"  @ "<b/><b/>" @
		"<t>★前往 蓬莱</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(552000002);\",\"" @ $Get_Dialog_GeShi[31414] @ "聆经台</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>悟道</t></t>";

	$HuoYueDuText1[3,10] = $Get_Dialog_GeShi[31428] @
		"<t>★活动时间 20:30 - 21:00</t><b/><b/>" @
		"<t>★大量经验奖励</t><b/><b/>" @
		"<t>★前往 蓬莱</t>" @ "<c cid='" @ Get_TraceButton() @ "' cmd='\"findpath(410100031);\",\"" @ $Get_Dialog_GeShi[31414] @ "聆经台</t>\",\"GuiMissionTraceButtonProfile6\"' cf='createButton' />" @ "<t>参加</t></t>";

}

// 
//■■■■■■■■■■■【领取奖品界面】■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【悬赏吉凶界面】■■■■■■■■■■■■■■■■
$XuanShangJiXiong[1101,0] = "4030";
$XuanShangJiXiong[1101,1] = "4031";
$XuanShangJiXiong[1101,2] = "4032";
$XuanShangJiXiong[1101,3] = "4033";
$XuanShangJiXiong[1101,4] = "4034";
$XuanShangJiXiong[1101,5] = "4035";
$XuanShangJiXiong[1101,6] = "4036";
$XuanShangJiXiong[1101,7] = "4037";
$XuanShangJiXiong[1101,8] = "4038";
$XuanShangJiXiong[1101,9] = "4039";
$XuanShangJiXiong[1102,0] = "4040";
$XuanShangJiXiong[1102,1] = "4041";
$XuanShangJiXiong[1102,2] = "4042";
$XuanShangJiXiong[1102,3] = "4043";
$XuanShangJiXiong[1102,4] = "4044";
$XuanShangJiXiong[1102,5] = "4045";
$XuanShangJiXiong[1102,6] = "4046";
$XuanShangJiXiong[1102,7] = "4047";
$XuanShangJiXiong[1102,8] = "4048";
$XuanShangJiXiong[1102,9] = "4049";
$XuanShangJiXiong[1103,0] = "4050";
$XuanShangJiXiong[1103,1] = "4051";
$XuanShangJiXiong[1103,2] = "4052";
$XuanShangJiXiong[1103,3] = "4053";
$XuanShangJiXiong[1103,4] = "4054";
$XuanShangJiXiong[1103,5] = "4055";
$XuanShangJiXiong[1103,6] = "4056";
$XuanShangJiXiong[1103,7] = "4057";
$XuanShangJiXiong[1103,8] = "4058";
$XuanShangJiXiong[1103,9] = "4059";
$XuanShangJiXiong[1104,0] = "4060";
$XuanShangJiXiong[1104,1] = "4061";
$XuanShangJiXiong[1104,2] = "4062";
$XuanShangJiXiong[1104,3] = "4063";
$XuanShangJiXiong[1104,4] = "4064";
$XuanShangJiXiong[1104,5] = "4065";
$XuanShangJiXiong[1104,6] = "4066";
$XuanShangJiXiong[1104,7] = "4067";
$XuanShangJiXiong[1104,8] = "4068";
$XuanShangJiXiong[1104,9] = "4069";
$XuanShangJiXiong[1105,0] = "4070";
$XuanShangJiXiong[1105,1] = "4071";
$XuanShangJiXiong[1105,2] = "4072";
$XuanShangJiXiong[1105,3] = "4073";
$XuanShangJiXiong[1105,4] = "4074";
$XuanShangJiXiong[1105,5] = "4075";
$XuanShangJiXiong[1105,6] = "4076";
$XuanShangJiXiong[1105,7] = "4077";
$XuanShangJiXiong[1105,8] = "4078";
$XuanShangJiXiong[1105,9] = "4079";
$XuanShangJiXiong[1106,0] = "4080";
$XuanShangJiXiong[1106,1] = "4081";
$XuanShangJiXiong[1106,2] = "4082";
$XuanShangJiXiong[1106,3] = "4083";
$XuanShangJiXiong[1106,4] = "4084";
$XuanShangJiXiong[1106,5] = "4085";
$XuanShangJiXiong[1106,6] = "4086";
$XuanShangJiXiong[1106,7] = "4087";
$XuanShangJiXiong[1106,8] = "4088";
$XuanShangJiXiong[1106,9] = "4089";

function GetXuanShangJiXiongFreeTimes(%Player)//悬赏缉凶刷新任务的每天免费次数
{
	return VIP_getNowTequanLvMaxCnt(%Player, 6);
}
$XuanShangJiXiong_ShuaXinNeedItem = 105109331;//悬赏缉凶刷新任务所需道具
function XuanShangJiXiongMissionIfonRecord()
{
	for (%i = 1; %i<= 6; %i++)
	{
		%MapID = 1100 + %i;
		$XuanShangJiXiongMissionMaxNumber[%MapID] = 0;
		for (%j = 1; %j <= 99; %j++)
		{
			%Missionid = 29000 + %i * 100 + %j;
			if (GetMissionData(%Missionid,0) > 0)
				$XuanShangJiXiongMissionMaxNumber[%MapID]++;
			else
				break;
		}
	}
}
XuanShangJiXiongMissionIfonRecord();
//■■■■■■■■■■■【悬赏吉凶界面】■■■■■■■■■■■■■■■■

//■■■■■■■■■■■【宝石重铸概率表】■■■■■■■■■■■■■■■■
//蓝宝石 4 绿宝石 3 红宝石  2 玄兵宝石 1   公告类型 1 屏幕中央 3屏幕中央+左下	  
//序列 宝石系列 1级宝石id 概率 公告类型
$GemRecastStoneChongZhu[1] ="2 110010001 280 1";//力量宝石
$GemRecastStoneChongZhu[2] ="2 110010011 280 1";//智力宝石
$GemRecastStoneChongZhu[3] ="2 110010021 333 1";//物攻宝石
$GemRecastStoneChongZhu[4] ="2 110010031 735 0";//最小物理攻击
$GemRecastStoneChongZhu[5] ="2 110010041 333 1";//最大物理攻击
$GemRecastStoneChongZhu[6] ="2 110010051 333 1";//法术攻击
$GemRecastStoneChongZhu[7] ="2 110010061 770 0";//最小法术攻击
$GemRecastStoneChongZhu[8] ="2 110010071 333 1";//最大法术攻击
$GemRecastStoneChongZhu[9] ="2 110010081 53 3";//物攻伤害加深
$GemRecastStoneChongZhu[10] ="2 110010091 53 3";//法攻伤害加深
$GemRecastStoneChongZhu[11] ="1 110010501 120 1";//玄兵力量宝石
$GemRecastStoneChongZhu[12] ="1 110010511 120 1";//玄兵智力宝石
$GemRecastStoneChongZhu[13] ="1 110010521 128 1";//玄兵物攻宝石
$GemRecastStoneChongZhu[14] ="1 110010531 300 1";//玄兵最小物攻宝石
$GemRecastStoneChongZhu[15] ="1 110010541 135 1";//玄兵最大物攻宝石
$GemRecastStoneChongZhu[16] ="1 110010551 128 1";//玄兵法攻宝石
$GemRecastStoneChongZhu[17] ="1 110010561 300 1";//玄兵最小法攻宝石
$GemRecastStoneChongZhu[18] ="1 110010571 135 1";//玄兵最大法攻宝石
$GemRecastStoneChongZhu[19] ="1 110010611 135 1";//玄兵治疗宝石（蓝宝石）
$GemRecastStoneChongZhu[20] ="3 110020001 180 1";//体力宝石
$GemRecastStoneChongZhu[21] ="3 110020011 360 0";//精神宝石
$GemRecastStoneChongZhu[22] ="3 110020021 255 0";//生命宝石
$GemRecastStoneChongZhu[23] ="3 110020031 465 0";//法力宝石
$GemRecastStoneChongZhu[24] ="3 110020041 492 0";//物理防御
$GemRecastStoneChongZhu[25] ="3 110020051 492 0";//法术防御
$GemRecastStoneChongZhu[26] ="3 110020061 150 1";//无视物理防御
$GemRecastStoneChongZhu[27] ="3 110020071 150 1";//无视法术防御
$GemRecastStoneChongZhu[28] ="3 110020081 60 3";//福缘宝石
$GemRecastStoneChongZhu[29] ="3 110020091 60 3";//物攻受击减免
$GemRecastStoneChongZhu[30] ="3 110020101 291 0";//法攻受击减免
$GemRecastStoneChongZhu[31] ="3 110020111 45 3";//幸运宝石
$GemRecastStoneChongZhu[32] ="4 110030001 160 0";//物理命中宝石
$GemRecastStoneChongZhu[33] ="4 110030011 160 0";//法术命中宝石
$GemRecastStoneChongZhu[34] ="4 110030021 120 0";//物理闪避宝石
$GemRecastStoneChongZhu[35] ="4 110030031 120 0";//法术闪避宝石
$GemRecastStoneChongZhu[36] ="4 110030041 110 3";//暴击宝石
$GemRecastStoneChongZhu[37] ="4 110030051 110 3";//暴击伤害宝石
$GemRecastStoneChongZhu[38] ="4 110030061 100 3";//暴击减免宝石
$GemRecastStoneChongZhu[39] ="4 110030071 100 3";//暴击伤害减免宝石
$GemRecastStoneChongZhu[40] ="4 110030081 300 0";//治疗宝石
$GemRecastStoneChongZhu[41] ="4 110030091 240 0";//复苏宝石
$GemRecastStoneChongZhu[42] ="4 110030101 240 0";//修气宝石
$GemRecastStoneChongZhu[43] ="4 110030111 60 3";//会心一击
$GemRecastStoneChongZhu[44] ="4 110030121 60 3";//会心一击防御
$GemRecastStoneChongZhu[45] ="4 110030131 60 3";//会心一击伤害
$GemRecastStoneChongZhu[46] ="4 110030141 60 3";//会心伤害减免


function RecordGemRecastStoneChongZhu()
{
	for (%i = 1; %i <= 4; %i++)
	{
		$RecordGemRecastStoneTypeAllNumber[%i] = 0;
	}
	for (%i = 1; %i <=99; %i++)
	{
		if ($GemRecastStoneChongZhu[%i] $= "")
			break;
		%BaoShiType = GetWord($GemRecastStoneChongZhu[%i],0);
		%BaoShiRan = GetWord($GemRecastStoneChongZhu[%i],2);
		$RecordGemRecastStoneTypeAllNumber[%BaoShiType] = $RecordGemRecastStoneTypeAllNumber[%BaoShiType] + %BaoShiRan;
	}
}
RecordGemRecastStoneChongZhu();
//■■■■■■■■■■■【宝石重铸概率表】■■■■■■■■■■■■■■■■


//■■■■■■■■■■■【悬赏缉凶道具奖励表】■■■■■■■■■■■■■
$XuanShangJiXiongItem[1101,2,1] = "109051001 2000 1";	$XuanShangJiXiongItem[1101,3,1] = "109051031 500 1";	$XuanShangJiXiongItem[1101,4,1] = "105109321 858 1"; $XuanShangJiXiongItem[1101,5,1] = "105090502 1333 1";	$XuanShangJiXiongItem[1101,6,1] = "105090412 497 1";
$XuanShangJiXiongItem[1101,2,2] = "109051011 2000 1";	$XuanShangJiXiongItem[1101,3,2] = "109051041 500 1";	$XuanShangJiXiongItem[1101,4,2] = "109061101 857 1"; $XuanShangJiXiongItem[1101,5,2] = "105090602 1333 1";	$XuanShangJiXiongItem[1101,6,2] = "105109321 815 1";
$XuanShangJiXiongItem[1101,2,3] = "105109301 1000 1";	$XuanShangJiXiongItem[1101,3,3] = "109051051 500 1";	$XuanShangJiXiongItem[1101,4,3] = "109061201 857 1"; $XuanShangJiXiongItem[1101,5,3] = "105090411 1334 1";	$XuanShangJiXiongItem[1101,6,3] = "109061101 815 1";
$XuanShangJiXiongItem[1101,2,4] = "109042001 2000 1";	$XuanShangJiXiongItem[1101,3,4] = "109051061 500 1";	$XuanShangJiXiongItem[1101,4,4] = "109042003 857 1"; $XuanShangJiXiongItem[1101,5,4] = "105109321 858 1";	$XuanShangJiXiongItem[1101,6,4] = "109061201 815 1";
$XuanShangJiXiongItem[1101,2,5] = "109042011 3000 1";	$XuanShangJiXiongItem[1101,3,5] = "109051071 500 1";	$XuanShangJiXiongItem[1101,4,5] = "109042013 857 1"; $XuanShangJiXiongItem[1101,5,5] = "109061101 857 1";	$XuanShangJiXiongItem[1101,6,5] = "109042003 815 1";
$XuanShangJiXiongItem[1101,3,6] = "109051081 500 1";	$XuanShangJiXiongItem[1101,4,6] = "105090501 857 1"; $XuanShangJiXiongItem[1101,5,6] = "109061201 857 1";	$XuanShangJiXiongItem[1101,6,6] = "109042013 815 1";
$XuanShangJiXiongItem[1101,3,7] = "109061001 500 1";	$XuanShangJiXiongItem[1101,4,7] = "105090601 857 1"; $XuanShangJiXiongItem[1101,5,7] = "109042003 857 1";	$XuanShangJiXiongItem[1101,6,7] = "105090501 815 1";
$XuanShangJiXiongItem[1101,3,8] = "109042002 1250 1";	$XuanShangJiXiongItem[1101,4,8] = "109051031 333 1"; $XuanShangJiXiongItem[1101,5,8] = "109042013 857 1";	$XuanShangJiXiongItem[1101,6,8] = "105090601 815 1";
$XuanShangJiXiongItem[1101,3,9] = "109042012 1250 1";	$XuanShangJiXiongItem[1101,4,9] = "109051041 333 1"; $XuanShangJiXiongItem[1101,5,9] = "105090501 857 1";	$XuanShangJiXiongItem[1101,6,9] = "105090502 1266 1";
$XuanShangJiXiongItem[1101,3,10]= "109051001 800 1";	$XuanShangJiXiongItem[1101,4,10]= "109051051 333 1"; $XuanShangJiXiongItem[1101,5,10]= "105090601 857 1";	$XuanShangJiXiongItem[1101,6,10]= "105090601 1266 1";
$XuanShangJiXiongItem[1101,3,11]= "109051011 800 1";	$XuanShangJiXiongItem[1101,4,11]= "109051061 333 1";															$XuanShangJiXiongItem[1101,6,11]= "105090411 1266 1";
$XuanShangJiXiongItem[1101,3,12]= "105109301 400 1";	$XuanShangJiXiongItem[1101,4,12]= "109051071 333 1";
$XuanShangJiXiongItem[1101,3,13]= "109042001 800 1";	$XuanShangJiXiongItem[1101,4,13]= "109051081 333 1";
$XuanShangJiXiongItem[1101,3,14]= "109042011 1200 1";	$XuanShangJiXiongItem[1101,4,14]= "109061001 333 1";
$XuanShangJiXiongItem[1101,4,15]= "109042002 835 1";
$XuanShangJiXiongItem[1101,4,16]= "109042012 834 1";

$XuanShangJiXiongItem[1102,2,1] = "109051002 2000 1";	$XuanShangJiXiongItem[1102,3,1] = "109051031 350 1"; $XuanShangJiXiongItem[1102,4,1] = "105109322 858 1"; $XuanShangJiXiongItem[1102,5,1] = "105090512 1333 1"; $XuanShangJiXiongItem[1102,6,1] = "105090412 497 1";
$XuanShangJiXiongItem[1102,2,2] = "109051012 2000 1";	$XuanShangJiXiongItem[1102,3,2] = "109051041 350 1"; $XuanShangJiXiongItem[1102,4,2] = "109061102 857 1"; $XuanShangJiXiongItem[1102,5,2] = "105090612 1333 1"; $XuanShangJiXiongItem[1102,6,2] = "105109322 815 1";
$XuanShangJiXiongItem[1102,2,3] = "105109301 1000 1";	$XuanShangJiXiongItem[1102,3,3] = "109051051 350 1"; $XuanShangJiXiongItem[1102,4,3] = "109061202 857 1"; $XuanShangJiXiongItem[1102,5,3] = "105090411 1334 1"; $XuanShangJiXiongItem[1102,6,3] = "109061102 815 1";
$XuanShangJiXiongItem[1102,2,4] = "109042021 3000 1";	$XuanShangJiXiongItem[1102,3,4] = "109051061 350 1"; $XuanShangJiXiongItem[1102,4,4] = "109042021 857 1"; $XuanShangJiXiongItem[1102,5,4] = "105109322 858 1";	$XuanShangJiXiongItem[1102,6,4] = "109061202 815 1";
$XuanShangJiXiongItem[1102,2,5] = "109042022 2000 1";	$XuanShangJiXiongItem[1102,3,5] = "109051071 350 1"; $XuanShangJiXiongItem[1102,4,5] = "109042022 857 1"; $XuanShangJiXiongItem[1102,5,5] = "109061102 857 1";	$XuanShangJiXiongItem[1102,6,5] = "109042021 815 1";
$XuanShangJiXiongItem[1102,3,6] = "109051081 350 1"; $XuanShangJiXiongItem[1102,4,6] = "105090511 857 1"; $XuanShangJiXiongItem[1102,5,6] = "109061202 857 1";	$XuanShangJiXiongItem[1102,6,6] = "109042022 815 1";
$XuanShangJiXiongItem[1102,3,7] = "109061001 350 1"; $XuanShangJiXiongItem[1102,4,7] = "105090611 857 1"; $XuanShangJiXiongItem[1102,5,7] = "109042021 857 1";	$XuanShangJiXiongItem[1102,6,7] = "105090511 815 1";
$XuanShangJiXiongItem[1102,3,8] = "109042022 625 1"; $XuanShangJiXiongItem[1102,4,8] = "109051032 333 1"; $XuanShangJiXiongItem[1102,5,8] = "109042022 857 1";	$XuanShangJiXiongItem[1102,6,8] = "105090611 815 1";
$XuanShangJiXiongItem[1102,3,9] = "109051032 350 1"; $XuanShangJiXiongItem[1102,4,9] = "109051042 333 1"; $XuanShangJiXiongItem[1102,5,9] = "105090511 857 1";	$XuanShangJiXiongItem[1102,6,9] = "105090512 1266 1";
$XuanShangJiXiongItem[1102,3,10]= "109051042 350 1"; $XuanShangJiXiongItem[1102,4,10]= "109051052 333 1"; $XuanShangJiXiongItem[1102,5,10]= "105090611 857 1";	$XuanShangJiXiongItem[1102,6,10]= "105090612 1266 1";
$XuanShangJiXiongItem[1102,3,11]= "109051052 350 1"; $XuanShangJiXiongItem[1102,4,11]= "109051062 333 1";															$XuanShangJiXiongItem[1102,6,11]= "105090411 1266 1";
$XuanShangJiXiongItem[1102,3,12]= "109051062 350 1"; $XuanShangJiXiongItem[1102,4,12]= "109051072 333 1";
$XuanShangJiXiongItem[1102,3,13]= "109051072 300 1"; $XuanShangJiXiongItem[1102,4,13]= "109051082 333 1";
$XuanShangJiXiongItem[1102,3,14]= "109051082 300 1"; $XuanShangJiXiongItem[1102,4,14]= "109061002 333 1";
$XuanShangJiXiongItem[1102,3,15]= "109061002 300 1"; $XuanShangJiXiongItem[1102,4,15]= "109042023 835 1";
$XuanShangJiXiongItem[1102,3,16]= "109042023 625 1"; $XuanShangJiXiongItem[1102,4,16]= "109042022 834 1";
$XuanShangJiXiongItem[1102,3,17]= "109051002 800 1";
$XuanShangJiXiongItem[1102,3,18]= "109051012 800 1";
$XuanShangJiXiongItem[1102,3,19]= "105109301 400 1";
$XuanShangJiXiongItem[1102,3,20]= "109042021 1200 1";
$XuanShangJiXiongItem[1102,3,21]= "109042022 800 1";

$XuanShangJiXiongItem[1103,2,1] = "109051003 2000 1";	$XuanShangJiXiongItem[1103,3,1] = "109051031 200 1"; $XuanShangJiXiongItem[1103,4,1] = "105109323 858 1"; $XuanShangJiXiongItem[1103,5,1] = "105090522 1333 1"; $XuanShangJiXiongItem[1103,6,1] = "105090412 497 1";
$XuanShangJiXiongItem[1103,2,2] = "109051013 2000 1";	$XuanShangJiXiongItem[1103,3,2] = "109051041 200 1"; $XuanShangJiXiongItem[1103,4,2] = "109061103 857 1"; $XuanShangJiXiongItem[1103,5,2] = "105090622 1333 1"; $XuanShangJiXiongItem[1103,6,2] = "105109323 815 1";
$XuanShangJiXiongItem[1103,2,3] = "105109301 1000 1";	$XuanShangJiXiongItem[1103,3,3] = "109051051 200 1"; $XuanShangJiXiongItem[1103,4,3] = "109061203 857 1"; $XuanShangJiXiongItem[1103,5,3] = "105090411 1334 1"; $XuanShangJiXiongItem[1103,6,3] = "109061103 815 1";
$XuanShangJiXiongItem[1103,2,4] = "109042031 3000 1";	$XuanShangJiXiongItem[1103,3,4] = "109051061 200 1"; $XuanShangJiXiongItem[1103,4,4] = "109042031 857 1"; $XuanShangJiXiongItem[1103,5,4] = "105109323 858 1";	$XuanShangJiXiongItem[1103,6,4] = "109061203 815 1";
$XuanShangJiXiongItem[1103,2,5] = "109042032 2000 1";	$XuanShangJiXiongItem[1103,3,5] = "109051071 200 1"; $XuanShangJiXiongItem[1103,4,5] = "109042032 857 1"; $XuanShangJiXiongItem[1103,5,5] = "109061103 857 1";	$XuanShangJiXiongItem[1103,6,5] = "109042031 815 1";
$XuanShangJiXiongItem[1103,3,6] = "109051081 200 1"; $XuanShangJiXiongItem[1103,4,6] = "105090521 857 1"; $XuanShangJiXiongItem[1103,5,6] = "109061203 857 1";	$XuanShangJiXiongItem[1103,6,6] = "109042032 815 1";
$XuanShangJiXiongItem[1103,3,7] = "109061001 200 1"; $XuanShangJiXiongItem[1103,4,7] = "105090621 857 1"; $XuanShangJiXiongItem[1103,5,7] = "109042031 857 1";	$XuanShangJiXiongItem[1103,6,7] = "105090521 815 1";
$XuanShangJiXiongItem[1103,3,8] = "109042032 500 1"; $XuanShangJiXiongItem[1103,4,8] = "109051033 333 1"; $XuanShangJiXiongItem[1103,5,8] = "109042032 857 1";	$XuanShangJiXiongItem[1103,6,8] = "105090621 815 1";
$XuanShangJiXiongItem[1103,3,9] = "109051032 200 1"; $XuanShangJiXiongItem[1103,4,9] = "109051043 333 1"; $XuanShangJiXiongItem[1103,5,9] = "105090521 857 1";	$XuanShangJiXiongItem[1103,6,9] = "105090522 1266 1";
$XuanShangJiXiongItem[1103,3,10]= "109051042 200 1"; $XuanShangJiXiongItem[1103,4,10]= "109051053 333 1"; $XuanShangJiXiongItem[1103,5,10]= "105090621 857 1";	$XuanShangJiXiongItem[1103,6,10]= "105090622 1266 1";
$XuanShangJiXiongItem[1103,3,11]= "109051052 200 1"; $XuanShangJiXiongItem[1103,4,11]= "109051063 333 1";															$XuanShangJiXiongItem[1103,6,11]= "105090411 1266 1";
$XuanShangJiXiongItem[1103,3,12]= "109051062 200 1"; $XuanShangJiXiongItem[1103,4,12]= "109051073 333 1";
$XuanShangJiXiongItem[1103,3,13]= "109051072 200 1"; $XuanShangJiXiongItem[1103,4,13]= "109051083 333 1";
$XuanShangJiXiongItem[1103,3,14]= "109051082 200 1"; $XuanShangJiXiongItem[1103,4,14]= "109061003 333 1";
$XuanShangJiXiongItem[1103,3,15]= "109061002 200 1"; $XuanShangJiXiongItem[1103,4,15]= "109042033 835 1";
$XuanShangJiXiongItem[1103,3,16]= "109042032 500 1"; $XuanShangJiXiongItem[1103,4,16]= "109042032 834 1";
$XuanShangJiXiongItem[1103,3,17]= "109051033 250 1";
$XuanShangJiXiongItem[1103,3,18]= "109051043 250 1";
$XuanShangJiXiongItem[1103,3,19]= "109051053 250 1";
$XuanShangJiXiongItem[1103,3,20]= "109051063 250 1";
$XuanShangJiXiongItem[1103,3,21]= "109051073 250 1";
$XuanShangJiXiongItem[1103,3,22]= "109051083 250 1";
$XuanShangJiXiongItem[1103,3,23]= "109061003 200 1";
$XuanShangJiXiongItem[1103,3,24]= "109042033 500 1";
$XuanShangJiXiongItem[1103,3,25]= "109051003 800 1";
$XuanShangJiXiongItem[1103,3,26]= "109051013 800 1";
$XuanShangJiXiongItem[1103,3,27]= "105109301 400 1";
$XuanShangJiXiongItem[1103,3,28]= "109042031 1200 1";
$XuanShangJiXiongItem[1103,3,29]= "109042032 800 1";

//■■■■■■■■■■■【悬赏缉凶道具奖励表】■■■■■■■■■■■■■

$LivingSkillIdDesignation[501011001] = 501;
$LivingSkillIdDesignation[501011002] = 502;
$LivingSkillIdDesignation[501011003] = 503;
$LivingSkillIdDesignation[501011004] = 504;
$LivingSkillIdDesignation[501011005] = 505;
$LivingSkillIdDesignation[501011006] = 506;
$LivingSkillIdDesignation[501011007] = 507;
$LivingSkillIdDesignation[501011008] = 508;
$LivingSkillIdDesignation[501011009] = 509;
$LivingSkillIdDesignation[501011010] = 510;
$LivingSkillIdDesignation[501021001] = 511;
$LivingSkillIdDesignation[501021002] = 512;
$LivingSkillIdDesignation[501021003] = 513;
$LivingSkillIdDesignation[501021004] = 514;
$LivingSkillIdDesignation[501021005] = 515;
$LivingSkillIdDesignation[501021006] = 516;
$LivingSkillIdDesignation[501021007] = 517;
$LivingSkillIdDesignation[501021008] = 518;
$LivingSkillIdDesignation[501021009] = 519;
$LivingSkillIdDesignation[501021010] = 520;
$LivingSkillIdDesignation[501031001] = 521;
$LivingSkillIdDesignation[501031002] = 522;
$LivingSkillIdDesignation[501031003] = 523;
$LivingSkillIdDesignation[501031004] = 524;
$LivingSkillIdDesignation[501031005] = 525;
$LivingSkillIdDesignation[501031006] = 526;
$LivingSkillIdDesignation[501031007] = 527;
$LivingSkillIdDesignation[501031008] = 528;
$LivingSkillIdDesignation[501031009] = 529;
$LivingSkillIdDesignation[501031010] = 530;
$LivingSkillIdDesignation[501051001] = 531;
$LivingSkillIdDesignation[501051002] = 532;
$LivingSkillIdDesignation[501051003] = 533;
$LivingSkillIdDesignation[501051004] = 534;
$LivingSkillIdDesignation[501051005] = 535;
$LivingSkillIdDesignation[501051006] = 536;
$LivingSkillIdDesignation[501051007] = 537;
$LivingSkillIdDesignation[501051008] = 538;
$LivingSkillIdDesignation[501051009] = 539;
$LivingSkillIdDesignation[501051010] = 540;
$LivingSkillIdDesignation[502011001] = 541;
$LivingSkillIdDesignation[502011002] = 542;
$LivingSkillIdDesignation[502011003] = 543;
$LivingSkillIdDesignation[502011004] = 544;
$LivingSkillIdDesignation[502011005] = 545;
$LivingSkillIdDesignation[502011006] = 546;
$LivingSkillIdDesignation[502011007] = 547;
$LivingSkillIdDesignation[502011008] = 548;
$LivingSkillIdDesignation[502011009] = 549;
$LivingSkillIdDesignation[502011010] = 550;
$LivingSkillIdDesignation[503011001] = 551;
$LivingSkillIdDesignation[503011002] = 552;
$LivingSkillIdDesignation[503011003] = 553;
$LivingSkillIdDesignation[503011004] = 554;
$LivingSkillIdDesignation[503011005] = 555;
$LivingSkillIdDesignation[503011006] = 556;
$LivingSkillIdDesignation[503011007] = 557;
$LivingSkillIdDesignation[503011008] = 558;
$LivingSkillIdDesignation[503011009] = 559;
$LivingSkillIdDesignation[503011010] = 560;
$LivingSkillIdDesignation[504011001] = 561;
$LivingSkillIdDesignation[504011002] = 562;
$LivingSkillIdDesignation[504011003] = 563;
$LivingSkillIdDesignation[504011004] = 564;
$LivingSkillIdDesignation[504011005] = 565;
$LivingSkillIdDesignation[504011006] = 566;
$LivingSkillIdDesignation[504011007] = 567;
$LivingSkillIdDesignation[504011008] = 568;
$LivingSkillIdDesignation[504011009] = 569;
$LivingSkillIdDesignation[504011010] = 570;
$LivingSkillIdDesignation[505011001] = 571;
$LivingSkillIdDesignation[505011002] = 572;
$LivingSkillIdDesignation[505011003] = 573;
$LivingSkillIdDesignation[505011004] = 574;
$LivingSkillIdDesignation[505011005] = 575;
$LivingSkillIdDesignation[505011006] = 576;
$LivingSkillIdDesignation[505011007] = 577;
$LivingSkillIdDesignation[505011008] = 578;
$LivingSkillIdDesignation[505011009] = 579;
$LivingSkillIdDesignation[505011010] = 580;
$LivingSkillIdDesignation[506011001] = 581;
$LivingSkillIdDesignation[506011002] = 582;
$LivingSkillIdDesignation[506011003] = 583;
$LivingSkillIdDesignation[506011004] = 584;
$LivingSkillIdDesignation[506011005] = 585;
$LivingSkillIdDesignation[506011006] = 586;
$LivingSkillIdDesignation[506011007] = 587;
$LivingSkillIdDesignation[506011008] = 588;
$LivingSkillIdDesignation[506011009] = 589;
$LivingSkillIdDesignation[506011010] = 590;
$LivingSkillIdDesignation[507011001] = 591;
$LivingSkillIdDesignation[507011002] = 592;
$LivingSkillIdDesignation[507011003] = 593;
$LivingSkillIdDesignation[507011004] = 594;
$LivingSkillIdDesignation[507011005] = 595;
$LivingSkillIdDesignation[507011006] = 596;
$LivingSkillIdDesignation[507011007] = 597;
$LivingSkillIdDesignation[507011008] = 598;
$LivingSkillIdDesignation[507011009] = 599;
$LivingSkillIdDesignation[507011010] = 560;


$LivingSkillIdAchRecord[501011002]=89;
$LivingSkillIdAchRecord[501011003]=90;
$LivingSkillIdAchRecord[501011004]=91;
$LivingSkillIdAchRecord[501011005]=92;
$LivingSkillIdAchRecord[501011006]=93;
$LivingSkillIdAchRecord[501011007]=94;
$LivingSkillIdAchRecord[501011008]=95;
$LivingSkillIdAchRecord[501011009]=96;
$LivingSkillIdAchRecord[501011010]=97;
$LivingSkillIdAchRecord[502011002]=98;
$LivingSkillIdAchRecord[502011003]=99;
$LivingSkillIdAchRecord[502011004]=100;
$LivingSkillIdAchRecord[502011005]=101;
$LivingSkillIdAchRecord[502011006]=102;
$LivingSkillIdAchRecord[502011007]=103;
$LivingSkillIdAchRecord[502011008]=104;
$LivingSkillIdAchRecord[502011009]=105;
$LivingSkillIdAchRecord[502011010]=106;
$LivingSkillIdAchRecord[501021002]=137;
$LivingSkillIdAchRecord[501021003]=138;
$LivingSkillIdAchRecord[501021004]=139;
$LivingSkillIdAchRecord[501021005]=140;
$LivingSkillIdAchRecord[501021006]=141;
$LivingSkillIdAchRecord[501021007]=142;
$LivingSkillIdAchRecord[501021008]=143;
$LivingSkillIdAchRecord[501021009]=144;
$LivingSkillIdAchRecord[501021010]=145;
$LivingSkillIdAchRecord[501031002]=146;
$LivingSkillIdAchRecord[501031003]=147;
$LivingSkillIdAchRecord[501031004]=148;
$LivingSkillIdAchRecord[501031005]=149;
$LivingSkillIdAchRecord[501031006]=150;
$LivingSkillIdAchRecord[501031007]=151;
$LivingSkillIdAchRecord[501031008]=152;
$LivingSkillIdAchRecord[501031009]=153;
$LivingSkillIdAchRecord[501031010]=154;
$LivingSkillIdAchRecord[501051002]=155;
$LivingSkillIdAchRecord[501051003]=156;
$LivingSkillIdAchRecord[501051004]=157;
$LivingSkillIdAchRecord[501051005]=158;
$LivingSkillIdAchRecord[501051006]=159;
$LivingSkillIdAchRecord[501051007]=160;
$LivingSkillIdAchRecord[501051008]=161;
$LivingSkillIdAchRecord[501051009]=162;
$LivingSkillIdAchRecord[501051010]=163;
$LivingSkillIdAchRecord[503011002]=164;
$LivingSkillIdAchRecord[503011003]=165;
$LivingSkillIdAchRecord[503011004]=166;
$LivingSkillIdAchRecord[503011005]=167;
$LivingSkillIdAchRecord[503011006]=168;
$LivingSkillIdAchRecord[503011007]=169;
$LivingSkillIdAchRecord[503011008]=170;
$LivingSkillIdAchRecord[503011009]=171;
$LivingSkillIdAchRecord[503011010]=172;
$LivingSkillIdAchRecord[504011002]=173;
$LivingSkillIdAchRecord[504011003]=174;
$LivingSkillIdAchRecord[504011004]=175;
$LivingSkillIdAchRecord[504011005]=176;
$LivingSkillIdAchRecord[504011006]=177;
$LivingSkillIdAchRecord[504011007]=178;
$LivingSkillIdAchRecord[504011008]=179;
$LivingSkillIdAchRecord[504011009]=180;
$LivingSkillIdAchRecord[504011010]=181;
$LivingSkillIdAchRecord[505011002]=182;
$LivingSkillIdAchRecord[505011003]=183;
$LivingSkillIdAchRecord[505011004]=184;
$LivingSkillIdAchRecord[505011005]=185;
$LivingSkillIdAchRecord[505011006]=186;
$LivingSkillIdAchRecord[505011007]=187;
$LivingSkillIdAchRecord[505011008]=188;
$LivingSkillIdAchRecord[505011009]=189;
$LivingSkillIdAchRecord[505011010]=190;
$LivingSkillIdAchRecord[506011002]=191;
$LivingSkillIdAchRecord[506011003]=192;
$LivingSkillIdAchRecord[506011004]=193;
$LivingSkillIdAchRecord[506011005]=194;
$LivingSkillIdAchRecord[506011006]=195;
$LivingSkillIdAchRecord[506011007]=196;
$LivingSkillIdAchRecord[506011008]=197;
$LivingSkillIdAchRecord[506011009]=198;
$LivingSkillIdAchRecord[506011010]=199;
$LivingSkillIdAchRecord[507011002]=200;
$LivingSkillIdAchRecord[507011003]=201;
$LivingSkillIdAchRecord[507011004]=202;
$LivingSkillIdAchRecord[507011005]=203;
$LivingSkillIdAchRecord[507011006]=204;
$LivingSkillIdAchRecord[507011007]=205;
$LivingSkillIdAchRecord[507011008]=206;
$LivingSkillIdAchRecord[507011009]=207;
$LivingSkillIdAchRecord[507011010]=208;

//■■■■■■■■■■■【七日冲榜奖励】■■■■■■■■■■■■■
//等级         
$ServiceRankItem[0,0] = "105106001 100;116080008 1;119012045 1";
$ServiceRankItem[0,1] = "105106001 80;116080007 1;";
$ServiceRankItem[0,2] = "105106001 60;116080007 1;";
$ServiceRankItem[0,3] = "105106001 50;116080007 1;";
$ServiceRankItem[0,4] = "105106001 45;116080006 1;";
$ServiceRankItem[0,5] = "105106001 40;116080006 1;";
$ServiceRankItem[0,6] = "105106001 35;116080006 1;";
$ServiceRankItem[0,7] = "105106001 30;116080006 1;";
$ServiceRankItem[0,8] = "105106001 25;116080006 1;";
$ServiceRankItem[0,9] = "105106001 20;116080006 1;";

//战斗力
$ServiceRankItem[5,0] = "105106001 100;110030115 1;119012068 1;";
$ServiceRankItem[5,1] = "105106001 80;110030114 1;";
$ServiceRankItem[5,2] = "105106001 60;110030113 1;";
$ServiceRankItem[5,3] = "105106001 50;110030112 1;";
$ServiceRankItem[5,4] = "105106001 45;110030112 1;";
$ServiceRankItem[5,5] = "105106001 40;110030111 1;";
$ServiceRankItem[5,6] = "105106001 35;110030111 1;";
$ServiceRankItem[5,7] = "105106001 30;110030111 1;";
$ServiceRankItem[5,8] = "105106001 25;110030111 1;";
$ServiceRankItem[5,9] = "105106001 20;110030111 1;";


//战士等级31
$ServiceRankItem[31,0] = "105106001 80;110030045 1;";
$ServiceRankItem[31,1] = "105106001 60;110030044 1;";
$ServiceRankItem[31,2] = "105106001 50;110030043 1;";
$ServiceRankItem[31,3] = "105106001 40;110030042 1;";
$ServiceRankItem[31,4] = "105106001 35;110030042 1;";
$ServiceRankItem[31,5] = "105106001 30;110030041 1;";
$ServiceRankItem[31,6] = "105106001 25;110030041 1;";
$ServiceRankItem[31,7] = "105106001 20;110030041 1;";
$ServiceRankItem[31,8] = "105106001 15;110030041 1;";
$ServiceRankItem[31,9] = "105106001 10;110030041 1;";
//法师等级33
$ServiceRankItem[33,0] = "105106001 80;110030045 1;";
$ServiceRankItem[33,1] = "105106001 60;110030044 1;";
$ServiceRankItem[33,2] = "105106001 50;110030043 1;";
$ServiceRankItem[33,3] = "105106001 40;110030042 1;";
$ServiceRankItem[33,4] = "105106001 35;110030042 1;";
$ServiceRankItem[33,5] = "105106001 30;110030041 1;";
$ServiceRankItem[33,6] = "105106001 25;110030041 1;";
$ServiceRankItem[33,7] = "105106001 20;110030041 1;";
$ServiceRankItem[33,8] = "105106001 15;110030041 1;";
$ServiceRankItem[33,9] = "105106001 10;110030041 1;";
//道士等级34
$ServiceRankItem[34,0] = "105106001 80;110030045 1;";
$ServiceRankItem[34,1] = "105106001 60;110030044 1;";
$ServiceRankItem[34,2] = "105106001 50;110030043 1;";
$ServiceRankItem[34,3] = "105106001 40;110030042 1;";
$ServiceRankItem[34,4] = "105106001 35;110030042 1;";
$ServiceRankItem[34,5] = "105106001 30;110030041 1;";
$ServiceRankItem[34,6] = "105106001 25;110030041 1;";
$ServiceRankItem[34,7] = "105106001 20;110030041 1;";
$ServiceRankItem[34,8] = "105106001 15;110030041 1;";
$ServiceRankItem[34,9] = "105106001 10;110030041 1;";
//帮派等级46
$ServiceRankItem[46,0] = "105106001 80;110020025 1;";
$ServiceRankItem[46,1] = "105106001 60;110020024 1;";
$ServiceRankItem[46,2] = "105106001 50;110020023 1;";
$ServiceRankItem[46,3] = "105106001 40;110020022 1;";
$ServiceRankItem[46,4] = "105106001 35;110020022 1;";
$ServiceRankItem[46,5] = "105106001 30;110020021 1;";
$ServiceRankItem[46,6] = "105106001 25;110020021 1;";
$ServiceRankItem[46,7] = "105106001 20;110020021 1;";
$ServiceRankItem[46,8] = "105106001 15;110020021 1;";
$ServiceRankItem[46,9] = "105106001 10;110020021 1;";

//帮派声望48
$ServiceRankItem[48,0] = "105106001 80;110020045 1;";
$ServiceRankItem[48,1] = "105106001 60;110020044 1;";
$ServiceRankItem[48,2] = "105106001 50;110020043 1;";
$ServiceRankItem[48,3] = "105106001 40;110020042 1;";
$ServiceRankItem[48,4] = "105106001 35;110020042 1;";
$ServiceRankItem[48,5] = "105106001 30;110020041 1;";
$ServiceRankItem[48,6] = "105106001 25;110020041 1;";
$ServiceRankItem[48,7] = "105106001 20;110020041 1;";
$ServiceRankItem[48,8] = "105106001 15;110020041 1;";
$ServiceRankItem[48,9] = "105106001 10;110020041 1;";

//帮派活跃49
$ServiceRankItem[49,0] = "105106001 80;110020055 1;";
$ServiceRankItem[49,1] = "105106001 60;110020054 1;";
$ServiceRankItem[49,2] = "105106001 50;110020053 1;";
$ServiceRankItem[49,3] = "105106001 40;110020052 1;";
$ServiceRankItem[49,4] = "105106001 35;110020052 1;";
$ServiceRankItem[49,5] = "105106001 30;110020051 1;";
$ServiceRankItem[49,6] = "105106001 25;110020051 1;";
$ServiceRankItem[49,7] = "105106001 20;110020051 1;";
$ServiceRankItem[49,8] = "105106001 15;110020051 1;";
$ServiceRankItem[49,9] = "105106001 10;110020051 1;";

//击败boss8 
$ServiceRankItem[8,0] = "105106001 100;110030055 1;119012021 1;";
$ServiceRankItem[8,1] = "105106001 80;110030054 1;";
$ServiceRankItem[8,2] = "105106001 60;110030053 1;";
$ServiceRankItem[8,3] = "105106001 50;110030052 1;";
$ServiceRankItem[8,4] = "105106001 45;110030052 1;";
$ServiceRankItem[8,5] = "105106001 40;110030051 1;";
$ServiceRankItem[8,6] = "105106001 35;110030051 1;";
$ServiceRankItem[8,7] = "105106001 30;110030051 1;";
$ServiceRankItem[8,8] = "105106001 25;110030051 1;";
$ServiceRankItem[8,9] = "105106001 20;110030051 1;";

//文采值3
$ServiceRankItem[3,0] = "105106001 100;110030135 1;119012067 1;";
$ServiceRankItem[3,1] = "105106001 80;110030134 1;";
$ServiceRankItem[3,2] = "105106001 60;110030133 1;";
$ServiceRankItem[3,3] = "105106001 50;110030132 1;";
$ServiceRankItem[3,4] = "105106001 45;110030132 1;";
$ServiceRankItem[3,5] = "105106001 40;110030131 1;";
$ServiceRankItem[3,6] = "105106001 35;110030131 1;";
$ServiceRankItem[3,7] = "105106001 30;110030131 1;";
$ServiceRankItem[3,8] = "105106001 25;110030131 1;";
$ServiceRankItem[3,9] = "105106001 20;110030131 1;";




//■■■■■■■■■■■【七日冲榜奖励】■■■■■■■■■■■■■

//■■■■■■■■■■■【排行榜奖励展示】■■■■■■■■■■■■■■■
//排行榜类型，排名
function getRankRewardItemID(%type,%index)
{
	if (%index >10) return 0;
	if (%index <=3) %index =%index;
	else if (%index>=4 & %index<=5) %index =4;
	else if (%index>=6 & %index<=10) %index =6;

	%itemid = $TopRankItemID[%type,%index];
	if (%itemid > 100000000)
		return %itemid;
	else
		return 0;
}
$TopRankItemID[0,1] = "105280001";
$TopRankItemID[0,2] = "105280002";
$TopRankItemID[0,3] = "105280003";
$TopRankItemID[0,4] = "105280004";
$TopRankItemID[0,6] = "105280005";
$TopRankItemID[2,1] = "105280006";
$TopRankItemID[2,2] = "105280007";
$TopRankItemID[2,3] = "105280008";
$TopRankItemID[2,4] = "105280009";
$TopRankItemID[2,6] = "105280010";
$TopRankItemID[3,1] = "105280011";
$TopRankItemID[3,2] = "105280012";
$TopRankItemID[3,3] = "105280013";
$TopRankItemID[3,4] = "105280014";
$TopRankItemID[3,6] = "105280015";
$TopRankItemID[5,1] = "105280016";
$TopRankItemID[5,2] = "105280017";
$TopRankItemID[5,3] = "105280018";
$TopRankItemID[5,4] = "105280019";
$TopRankItemID[5,6] = "105280020";
$TopRankItemID[8,1] = "105280021";
$TopRankItemID[8,2] = "105280022";
$TopRankItemID[8,3] = "105280023";
$TopRankItemID[8,4] = "105280024";
$TopRankItemID[8,6] = "105280025";
$TopRankItemID[31,1] = "105280026";
$TopRankItemID[31,2] = "105280027";
$TopRankItemID[31,3] = "105280028";
$TopRankItemID[31,4] = "105280029";
$TopRankItemID[31,6] = "105280030";
$TopRankItemID[33,1] = "105280031";
$TopRankItemID[33,2] = "105280032";
$TopRankItemID[33,3] = "105280033";
$TopRankItemID[33,4] = "105280034";
$TopRankItemID[33,6] = "105280035";
$TopRankItemID[34,1] = "105280036";
$TopRankItemID[34,2] = "105280037";
$TopRankItemID[34,3] = "105280038";
$TopRankItemID[34,4] = "105280039";
$TopRankItemID[34,6] = "105280040";
$TopRankItemID[36,1] = "105280041";
$TopRankItemID[36,2] = "105280042";
$TopRankItemID[36,3] = "105280043";
$TopRankItemID[36,4] = "105280044";
$TopRankItemID[36,6] = "105280045";
$TopRankItemID[38,1] = "105280046";
$TopRankItemID[38,2] = "105280047";
$TopRankItemID[38,3] = "105280048";
$TopRankItemID[38,4] = "105280049";
$TopRankItemID[38,6] = "105280050";
$TopRankItemID[39,1] = "105280051";
$TopRankItemID[39,2] = "105280052";
$TopRankItemID[39,3] = "105280053";
$TopRankItemID[39,4] = "105280054";
$TopRankItemID[39,6] = "105280055";
$TopRankItemID[47,1] = "105280056";
$TopRankItemID[48,1] = "105280057";
$TopRankItemID[49,1] = "105280058";
$TopRankItemID[50,1] = "105280059";
$TopRankItemID[15,1] = "105280061";
$TopRankItemID[15,2] = "105280062";
$TopRankItemID[15,3] = "105280063";
$TopRankItemID[15,4] = "105280064";
$TopRankItemID[15,6] = "105280065";
$TopRankItemID[16,1] = "105280066";
$TopRankItemID[16,2] = "105280067";
$TopRankItemID[16,3] = "105280068";
$TopRankItemID[16,4] = "105280069";
$TopRankItemID[16,6] = "105280070";
$TopRankItemID[17,1] = "105280071";
$TopRankItemID[17,2] = "105280072";
$TopRankItemID[17,3] = "105280073";
$TopRankItemID[17,4] = "105280074";
$TopRankItemID[17,6] = "105280075";
$TopRankItemID[14,1] = "105280076";
$TopRankItemID[14,2] = "105280077";
$TopRankItemID[14,3] = "105280078";
$TopRankItemID[14,4] = "105280079";
$TopRankItemID[14,6] = "105280080";
//■■■■■■■■■■■【排行榜奖励展示】■■■■■■■■■■■■■■■



//■■■■■■■■■■■【限时抢购】■■■■■■■■■■■■■■■■■■

$XianShiQiangGou_ItemNum[5,1] = 10;	//商品总数：线路ID，商店ID
//编号|库存|限购|价格|货币(1元宝、2金币、代币编号)
$XianShiQiangGou_ItemInfo[5, 1, 1] = "105105713|762|11|50000|2";
$XianShiQiangGou_ItemInfo[5, 1, 2] = "105090511|249|4 |3    |105090901";
$XianShiQiangGou_ItemInfo[5, 1, 3] = "105090611|670|8 |294  |1";
$XianShiQiangGou_ItemInfo[5, 1, 4] = "113050023|109|1 |426  |1";
$XianShiQiangGou_ItemInfo[5, 1, 5] = "116030002|653|14|198  |1";
$XianShiQiangGou_ItemInfo[5, 1, 6] = "105090711|208|2 |1    |105090901";
$XianShiQiangGou_ItemInfo[5, 1, 7] = "105109323|539|9 |20000|2";
$XianShiQiangGou_ItemInfo[5, 1, 8] = "105021051|707|18|673  |1";
$XianShiQiangGou_ItemInfo[5, 1, 9] = "105021061|279|9 |421  |1";
$XianShiQiangGou_ItemInfo[5, 1,10] = "119015001|488|20|2    |105090901";




//■■■■■■■■■■■【门派声望捐献】■■■■■■■■■■■■■■■■
$MenPaiShengWangJuanXian[105105303] = 3000;
$MenPaiShengWangJuanXian[105105304] = 30000;
$MenPaiShengWangJuanXian[105109401] = 1; //精钢
$MenPaiShengWangJuanXian[105109402] = 1; //星辰蓝
$MenPaiShengWangJuanXian[105109403] = 1; //独山玉
$MenPaiShengWangJuanXian[105109404] = 1; //万年石乳
$MenPaiShengWangJuanXian[105109411] = 2; //陨铁
$MenPaiShengWangJuanXian[105109412] = 2; //寒冰箭草
$MenPaiShengWangJuanXian[105109413] = 2; //和田玉
$MenPaiShengWangJuanXian[105109414] = 2; //九幽之水
$MenPaiShengWangJuanXian[105109421] = 3; //白银
$MenPaiShengWangJuanXian[105109422] = 3; //腐骨灵花
$MenPaiShengWangJuanXian[105109423] = 3; //绿松石
$MenPaiShengWangJuanXian[105109424] = 3; //冥河神水
$MenPaiShengWangJuanXian[105109431] = 5; //血银
$MenPaiShengWangJuanXian[105109432] = 5; //蚀心菇
$MenPaiShengWangJuanXian[105109433] = 5; //东陵石
$MenPaiShengWangJuanXian[105109434] = 5; //葵水元精
$MenPaiShengWangJuanXian[105109441] = 7; //星银
$MenPaiShengWangJuanXian[105109442] = 7; //芝雪草
$MenPaiShengWangJuanXian[105109443] = 7; //京白玉
$MenPaiShengWangJuanXian[105109444] = 7; //太乙金液
$MenPaiShengWangJuanXian[105109451] = 9; //白金
$MenPaiShengWangJuanXian[105109452] = 9; //云霖花
$MenPaiShengWangJuanXian[105109453] = 9; //孔雀石
$MenPaiShengWangJuanXian[105109454] = 9; //生命之泉
$MenPaiShengWangJuanXian[105109461] = 11; //黑铁
$MenPaiShengWangJuanXian[105109462] = 11; //千金藤
$MenPaiShengWangJuanXian[105109463] = 11; //文石玉
$MenPaiShengWangJuanXian[105109464] = 11; //碧水琼浆
$MenPaiShengWangJuanXian[105109471] = 14; //白铁
$MenPaiShengWangJuanXian[105109472] = 14; //幻心草
$MenPaiShengWangJuanXian[105109473] = 14; //蓝田玉
$MenPaiShengWangJuanXian[105109474] = 14; //飞虹圣冰
$MenPaiShengWangJuanXian[105109481] = 16; //
$MenPaiShengWangJuanXian[105109482] = 16; //
$MenPaiShengWangJuanXian[105109483] = 16; //
$MenPaiShengWangJuanXian[105109484] = 16; //
$MenPaiShengWangJuanXian[105109491] = 18; //
$MenPaiShengWangJuanXian[105109492] = 18; //
$MenPaiShengWangJuanXian[105109493] = 18; //
$MenPaiShengWangJuanXian[105109494] = 18; //
//■■■■■■■■■■■【门派声望捐献】■■■■■■■■■■■■■■■■