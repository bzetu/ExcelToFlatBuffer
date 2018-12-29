using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_FMODSound : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_FMODSound.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRFMODSound>[] offsets = new Offset<DRFMODSound>[143];
   
            offsets[0] = DRFMODSound.CreateDRFMODSound(fbb, 60009,fbb.CreateString("方块落下底部"),80001,0,false,1f,0f,100f);
            offsets[1] = DRFMODSound.CreateDRFMODSound(fbb, 70001,fbb.CreateString("铃铛收集成功音效"),80002,0,false,1f,0f,100f);
            offsets[2] = DRFMODSound.CreateDRFMODSound(fbb, 70002,fbb.CreateString("黑洞"),80003,0,false,1f,0f,100f);
            offsets[3] = DRFMODSound.CreateDRFMODSound(fbb, 70004,fbb.CreateString("加步数倒计时音效"),80004,0,false,1f,0f,100f);
            offsets[4] = DRFMODSound.CreateDRFMODSound(fbb, 70005,fbb.CreateString("流星"),80005,0,false,1f,0f,100f);
            offsets[5] = DRFMODSound.CreateDRFMODSound(fbb, 70006,fbb.CreateString("连击1"),80006,0,false,1f,0f,100f);
            offsets[6] = DRFMODSound.CreateDRFMODSound(fbb, 70007,fbb.CreateString("连击2"),80007,0,false,1f,0f,100f);
            offsets[7] = DRFMODSound.CreateDRFMODSound(fbb, 70008,fbb.CreateString("连击3"),80008,0,false,1f,0f,100f);
            offsets[8] = DRFMODSound.CreateDRFMODSound(fbb, 70009,fbb.CreateString("Nice"),80009,0,false,1f,0f,100f);
            offsets[9] = DRFMODSound.CreateDRFMODSound(fbb, 70010,fbb.CreateString("Good"),80010,0,false,1f,0f,100f);
            offsets[10] = DRFMODSound.CreateDRFMODSound(fbb, 70011,fbb.CreateString("Unbelievable"),80011,0,false,1f,0f,100f);
            offsets[11] = DRFMODSound.CreateDRFMODSound(fbb, 70012,fbb.CreateString("Wonderful"),80012,0,false,1f,0f,100f);
            offsets[12] = DRFMODSound.CreateDRFMODSound(fbb, 70013,fbb.CreateString("单个方块破碎"),80013,0,false,1f,0f,100f);
            offsets[13] = DRFMODSound.CreateDRFMODSound(fbb, 30003,fbb.CreateString("方块变形"),80014,0,false,1f,0f,100f);
            offsets[14] = DRFMODSound.CreateDRFMODSound(fbb, 30004,fbb.CreateString("方块一键到底音效"),80015,0,false,1f,0f,100f);
            offsets[15] = DRFMODSound.CreateDRFMODSound(fbb, 30005,fbb.CreateString("方块快速下落"),80016,0,false,1f,0f,100f);
            offsets[16] = DRFMODSound.CreateDRFMODSound(fbb, 30006,fbb.CreateString("方块移动（左右下）"),80017,0,false,1f,0f,100f);
            offsets[17] = DRFMODSound.CreateDRFMODSound(fbb, 30007,fbb.CreateString("点击按钮音效"),80018,0,false,1f,0f,100f);
            offsets[18] = DRFMODSound.CreateDRFMODSound(fbb, 30008,fbb.CreateString("结算胜利"),80019,0,false,1f,0f,100f);
            offsets[19] = DRFMODSound.CreateDRFMODSound(fbb, 30009,fbb.CreateString("结算失败"),80020,0,false,1f,0f,100f);
            offsets[20] = DRFMODSound.CreateDRFMODSound(fbb, 40010,fbb.CreateString("关闭按钮点击音效"),80021,0,false,1f,0f,100f);
            offsets[21] = DRFMODSound.CreateDRFMODSound(fbb, 40011,fbb.CreateString("界面上下闭合音效"),80022,0,false,1f,0f,100f);
            offsets[22] = DRFMODSound.CreateDRFMODSound(fbb, 40012,fbb.CreateString("齿轮转动音效"),80023,0,false,1f,0f,100f);
            offsets[23] = DRFMODSound.CreateDRFMODSound(fbb, 40013,fbb.CreateString("底板翻动音效"),80024,0,false,1f,0f,100f);
            offsets[24] = DRFMODSound.CreateDRFMODSound(fbb, 40014,fbb.CreateString("目标界面弹出"),80025,0,false,1f,0f,100f);
            offsets[25] = DRFMODSound.CreateDRFMODSound(fbb, 40015,fbb.CreateString("纸飞机爆炸"),80026,0,false,1f,0f,100f);
            offsets[26] = DRFMODSound.CreateDRFMODSound(fbb, 40016,fbb.CreateString("火箭特出触发音效"),80027,0,false,1f,0f,100f);
            offsets[27] = DRFMODSound.CreateDRFMODSound(fbb, 40017,fbb.CreateString("泡泡糖爆炸"),80028,0,false,1f,0f,100f);
            offsets[28] = DRFMODSound.CreateDRFMODSound(fbb, 40018,fbb.CreateString("锤子砸击"),80029,0,false,1f,0f,100f);
            offsets[29] = DRFMODSound.CreateDRFMODSound(fbb, 40019,fbb.CreateString("泡泡糖生成方块"),80030,0,false,1f,0f,100f);
            offsets[30] = DRFMODSound.CreateDRFMODSound(fbb, 40020,fbb.CreateString("炸弹爆炸音效"),80031,0,false,1f,0f,100f);
            offsets[31] = DRFMODSound.CreateDRFMODSound(fbb, 40021,fbb.CreateString("消除"),80032,0,false,1f,0f,100f);
            offsets[32] = DRFMODSound.CreateDRFMODSound(fbb, 40022,fbb.CreateString("剩余步数小丑盒子弹出"),80033,0,false,1f,0f,100f);
            offsets[33] = DRFMODSound.CreateDRFMODSound(fbb, 40023,fbb.CreateString("金手指方块填充"),80034,0,false,1f,0f,100f);
            offsets[34] = DRFMODSound.CreateDRFMODSound(fbb, 40024,fbb.CreateString("万能块变换方块"),80035,0,false,1f,0f,100f);
            offsets[35] = DRFMODSound.CreateDRFMODSound(fbb, 40025,fbb.CreateString("纸飞机飞行"),80036,0,false,1f,0f,100f);
            offsets[36] = DRFMODSound.CreateDRFMODSound(fbb, 40026,fbb.CreateString("母鸡落地"),80037,0,false,1f,0f,100f);
            offsets[37] = DRFMODSound.CreateDRFMODSound(fbb, 40027,fbb.CreateString("母鸡成功捉住小鹰"),80038,0,false,1f,0f,100f);
            offsets[38] = DRFMODSound.CreateDRFMODSound(fbb, 40028,fbb.CreateString("母鸡跳跃"),80039,0,false,1f,0f,100f);
            offsets[39] = DRFMODSound.CreateDRFMODSound(fbb, 40029,fbb.CreateString("小鹰扑腾翅膀"),80040,0,false,1f,0f,100f);
            offsets[40] = DRFMODSound.CreateDRFMODSound(fbb, 40030,fbb.CreateString("小鹰到达鹰巢"),80041,0,false,1f,0f,100f);
            offsets[41] = DRFMODSound.CreateDRFMODSound(fbb, 40031,fbb.CreateString("小鹰惊恐"),80042,0,false,1f,0f,100f);
            offsets[42] = DRFMODSound.CreateDRFMODSound(fbb, 40032,fbb.CreateString("猫头鹰飞入屏幕"),80043,0,false,1f,0f,100f);
            offsets[43] = DRFMODSound.CreateDRFMODSound(fbb, 40033,fbb.CreateString("猫头鹰发出叽叽喳喳"),80044,0,false,1f,0f,100f);
            offsets[44] = DRFMODSound.CreateDRFMODSound(fbb, 40034,fbb.CreateString("猫头鹰飞出屏幕"),80045,0,false,1f,0f,100f);
            offsets[45] = DRFMODSound.CreateDRFMODSound(fbb, 40035,fbb.CreateString("信纸摩擦"),80046,0,false,1f,0f,100f);
            offsets[46] = DRFMODSound.CreateDRFMODSound(fbb, 40036,fbb.CreateString("敲门"),80047,0,false,1f,0f,100f);
            offsets[47] = DRFMODSound.CreateDRFMODSound(fbb, 40037,fbb.CreateString("碎片镶嵌"),80048,0,false,1f,0f,100f);
            offsets[48] = DRFMODSound.CreateDRFMODSound(fbb, 40038,fbb.CreateString("方块到达目标位置-正确"),80049,0,false,1f,0f,100f);
            offsets[49] = DRFMODSound.CreateDRFMODSound(fbb, 40039,fbb.CreateString("错误操作提示"),80050,0,false,1f,0f,100f);
            offsets[50] = DRFMODSound.CreateDRFMODSound(fbb, 40040,fbb.CreateString("小红帽鼓掌"),80051,0,false,1f,0f,100f);
            offsets[51] = DRFMODSound.CreateDRFMODSound(fbb, 40041,fbb.CreateString("小红帽抽泣"),80052,0,false,1f,0f,100f);
            offsets[52] = DRFMODSound.CreateDRFMODSound(fbb, 40042,fbb.CreateString("铃铛上移"),80053,0,false,1f,0f,100f);
            offsets[53] = DRFMODSound.CreateDRFMODSound(fbb, 40043,fbb.CreateString("通关星星1"),80054,0,false,1f,0f,100f);
            offsets[54] = DRFMODSound.CreateDRFMODSound(fbb, 40044,fbb.CreateString("通关星星2"),80055,0,false,1f,0f,100f);
            offsets[55] = DRFMODSound.CreateDRFMODSound(fbb, 40045,fbb.CreateString("通关星星3"),80056,0,false,1f,0f,100f);
            offsets[56] = DRFMODSound.CreateDRFMODSound(fbb, 40046,fbb.CreateString("魔方"),80057,0,false,1f,0f,100f);
            offsets[57] = DRFMODSound.CreateDRFMODSound(fbb, 40047,fbb.CreateString("方块破坏"),80058,0,false,1f,0f,100f);
            offsets[58] = DRFMODSound.CreateDRFMODSound(fbb, 40048,fbb.CreateString("流星雨飞入"),80059,0,false,1f,0f,100f);
            offsets[59] = DRFMODSound.CreateDRFMODSound(fbb, 40049,fbb.CreateString("获得道具"),80060,0,false,1f,0f,100f);
            offsets[60] = DRFMODSound.CreateDRFMODSound(fbb, 40050,fbb.CreateString("剩余步数小丑盒子收回"),80061,0,false,1f,0f,100f);
            offsets[61] = DRFMODSound.CreateDRFMODSound(fbb, 40051,fbb.CreateString("BonusTime"),80062,0,false,1f,0f,100f);
            offsets[62] = DRFMODSound.CreateDRFMODSound(fbb, 40052,fbb.CreateString("体力桃心划过"),80122,0,false,1f,0f,100f);
            offsets[63] = DRFMODSound.CreateDRFMODSound(fbb, 40053,fbb.CreateString("体力桃心消耗"),80123,0,false,1f,0f,100f);
            offsets[64] = DRFMODSound.CreateDRFMODSound(fbb, 40054,fbb.CreateString("双倍飞机"),80124,0,false,1f,0f,100f);
            offsets[65] = DRFMODSound.CreateDRFMODSound(fbb, 40055,fbb.CreateString("获得礼盒"),80125,0,false,1f,0f,100f);
            offsets[66] = DRFMODSound.CreateDRFMODSound(fbb, 40056,fbb.CreateString("冰块收集"),80126,0,false,1f,0f,100f);
            offsets[67] = DRFMODSound.CreateDRFMODSound(fbb, 40057,fbb.CreateString("玫瑰花收集"),80127,0,false,1f,0f,100f);
            offsets[68] = DRFMODSound.CreateDRFMODSound(fbb, 40058,fbb.CreateString("关卡获得星星1"),80128,0,false,1f,0f,100f);
            offsets[69] = DRFMODSound.CreateDRFMODSound(fbb, 40059,fbb.CreateString("关卡获得星星2"),80129,0,false,1f,0f,100f);
            offsets[70] = DRFMODSound.CreateDRFMODSound(fbb, 40060,fbb.CreateString("关卡获得星星3"),80130,0,false,1f,0f,100f);
            offsets[71] = DRFMODSound.CreateDRFMODSound(fbb, 40061,fbb.CreateString("地鼠消除"),80131,0,false,1f,0f,100f);
            offsets[72] = DRFMODSound.CreateDRFMODSound(fbb, 40062,fbb.CreateString("地鼠出土预告"),80132,0,false,1f,0f,100f);
            offsets[73] = DRFMODSound.CreateDRFMODSound(fbb, 40063,fbb.CreateString("地鼠出现"),80133,0,false,1f,0f,100f);
            offsets[74] = DRFMODSound.CreateDRFMODSound(fbb, 40064,fbb.CreateString("冰块消除1"),80134,0,false,1f,0f,100f);
            offsets[75] = DRFMODSound.CreateDRFMODSound(fbb, 40065,fbb.CreateString("冰块消除2"),80135,0,false,1f,0f,100f);
            offsets[76] = DRFMODSound.CreateDRFMODSound(fbb, 40066,fbb.CreateString("开礼盒"),80136,0,false,1f,0f,100f);
            offsets[77] = DRFMODSound.CreateDRFMODSound(fbb, 40067,fbb.CreateString("飞经验"),80137,0,false,1f,0f,100f);
            offsets[78] = DRFMODSound.CreateDRFMODSound(fbb, 40068,fbb.CreateString("彩虹糖纸碎裂"),80138,0,false,1f,0f,100f);
            offsets[79] = DRFMODSound.CreateDRFMODSound(fbb, 40069,fbb.CreateString("彩虹糖生成"),80139,0,false,1f,0f,100f);
            offsets[80] = DRFMODSound.CreateDRFMODSound(fbb, 40070,fbb.CreateString("角色出现"),80140,0,false,1f,0f,100f);
            offsets[81] = DRFMODSound.CreateDRFMODSound(fbb, 40071,fbb.CreateString("飞星星"),80141,0,false,1f,0f,100f);
            offsets[82] = DRFMODSound.CreateDRFMODSound(fbb, 40072,fbb.CreateString("开锁"),80142,0,false,1f,0f,100f);
            offsets[83] = DRFMODSound.CreateDRFMODSound(fbb, 50000,fbb.CreateString("欢迎来到奇幻游乐园，我们为您准备了两种游玩方式"),80063,0,false,1f,0f,100f);
            offsets[84] = DRFMODSound.CreateDRFMODSound(fbb, 50001,fbb.CreateString("手势操作开启"),80064,0,false,1f,0f,100f);
            offsets[85] = DRFMODSound.CreateDRFMODSound(fbb, 50002,fbb.CreateString("这里是本关的通关目标哟——“完成4行消除”"),80065,0,false,1f,0f,100f);
            offsets[86] = DRFMODSound.CreateDRFMODSound(fbb, 50003,fbb.CreateString("向左滑动，将方块左移至目标位置"),80066,0,false,1f,0f,100f);
            offsets[87] = DRFMODSound.CreateDRFMODSound(fbb, 50004,fbb.CreateString("就是这样！现在快速向下滑动，使方块一降到底"),80067,0,false,1f,0f,100f);
            offsets[88] = DRFMODSound.CreateDRFMODSound(fbb, 50005,fbb.CreateString("哇，成功消除一行，通关目标进度从4行降到3行了！"),80068,0,false,1f,0f,100f);
            offsets[89] = DRFMODSound.CreateDRFMODSound(fbb, 50006,fbb.CreateString("接下来试试向右滑动，将方块右移至目标位置"),80069,0,false,1f,0f,100f);
            offsets[90] = DRFMODSound.CreateDRFMODSound(fbb, 50007,fbb.CreateString("真棒！再试试快速下滑吧"),80070,0,false,1f,0f,100f);
            offsets[91] = DRFMODSound.CreateDRFMODSound(fbb, 50008,fbb.CreateString("现在我们来旋转方块，试试点击一次"),80071,0,false,1f,0f,100f);
            offsets[92] = DRFMODSound.CreateDRFMODSound(fbb, 50009,fbb.CreateString("完美，请再旋转一次"),80072,0,false,1f,0f,100f);
            offsets[93] = DRFMODSound.CreateDRFMODSound(fbb, 50010,fbb.CreateString("方块已经转动到合适的方向！现在长按屏幕使方块下落吧"),80073,0,false,1f,0f,100f);
            offsets[94] = DRFMODSound.CreateDRFMODSound(fbb, 50011,fbb.CreateString("干得漂亮！再消除一行即可完成关卡目标，加油"),80074,0,false,1f,0f,100f);
            offsets[95] = DRFMODSound.CreateDRFMODSound(fbb, 50012,fbb.CreateString("通关星级可带来额外惊喜哟！"),80075,0,false,1f,0f,100f);
            offsets[96] = DRFMODSound.CreateDRFMODSound(fbb, 50013,fbb.CreateString("那...你愿意和我一起继续闯关吗？"),80076,0,false,1f,0f,100f);
            offsets[97] = DRFMODSound.CreateDRFMODSound(fbb, 50014,fbb.CreateString("再试一次吧"),80077,0,false,1f,0f,100f);
            offsets[98] = DRFMODSound.CreateDRFMODSound(fbb, 50015,fbb.CreateString("新的通关目标出现了"),80078,0,false,1f,0f,100f);
            offsets[99] = DRFMODSound.CreateDRFMODSound(fbb, 50016,fbb.CreateString("同时消除两行，可制造特殊道具飞机，快试试吧！"),80079,0,false,1f,0f,100f);
            offsets[100] = DRFMODSound.CreateDRFMODSound(fbb, 50017,fbb.CreateString("哇，你成功制造了一架飞机！飞机会帮你解决通关目标哟"),80080,0,false,1f,0f,100f);
            offsets[101] = DRFMODSound.CreateDRFMODSound(fbb, 50018,fbb.CreateString("让我们再制造一架飞机吧"),80081,0,false,1f,0f,100f);
            offsets[102] = DRFMODSound.CreateDRFMODSound(fbb, 50019,fbb.CreateString("仔细观察，如何放置此方块才能制造一架新的飞机呢？"),80082,0,false,1f,0f,100f);
            offsets[103] = DRFMODSound.CreateDRFMODSound(fbb, 50020,fbb.CreateString("太精彩了，继续完成关卡吧！"),80083,0,false,1f,0f,100f);
            offsets[104] = DRFMODSound.CreateDRFMODSound(fbb, 50021,fbb.CreateString("只差一点点，下次记得把方块放置在图示位置制造飞机哟"),80084,0,false,1f,0f,100f);
            offsets[105] = DRFMODSound.CreateDRFMODSound(fbb, 50022,fbb.CreateString("这关需要收集的铃铛比较多，看来要想想新的办法啦"),80085,0,false,1f,0f,100f);
            offsets[106] = DRFMODSound.CreateDRFMODSound(fbb, 50023,fbb.CreateString("这样不对哟，试试左滑吧"),80086,0,false,1f,0f,100f);
            offsets[107] = DRFMODSound.CreateDRFMODSound(fbb, 50024,fbb.CreateString("这样不对哟，试试长按吧"),80087,0,false,1f,0f,100f);
            offsets[108] = DRFMODSound.CreateDRFMODSound(fbb, 50025,fbb.CreateString("这样不对哟，试试下滑吧"),80088,0,false,1f,0f,100f);
            offsets[109] = DRFMODSound.CreateDRFMODSound(fbb, 50026,fbb.CreateString("同时消除三行会产生泡泡糖，泡泡糖会自动填补到一个空格上哟"),80089,0,false,1f,0f,100f);
            offsets[110] = DRFMODSound.CreateDRFMODSound(fbb, 50027,fbb.CreateString("让我们再制造一枚泡泡糖吧"),80090,0,false,1f,0f,100f);
            offsets[111] = DRFMODSound.CreateDRFMODSound(fbb, 50028,fbb.CreateString("这样不对哟，试试点击旋转吧"),80091,0,false,1f,0f,100f);
            offsets[112] = DRFMODSound.CreateDRFMODSound(fbb, 50029,fbb.CreateString("哇，I型块出现了！快试试同时消除四行会产生什么神奇的魔法吧！"),80092,0,false,1f,0f,100f);
            offsets[113] = DRFMODSound.CreateDRFMODSound(fbb, 50030,fbb.CreateString("这样不对哟，试试右滑吧"),80093,0,false,1f,0f,100f);
            offsets[114] = DRFMODSound.CreateDRFMODSound(fbb, 50031,fbb.CreateString("同时消除四行会产生魔方，魔方旋转会随机制造一个道具，使用道具可极大地帮助通关哟！"),80094,0,false,1f,0f,100f);
            offsets[115] = DRFMODSound.CreateDRFMODSound(fbb, 50032,fbb.CreateString("魔方随机制造了一个小方块！快试试效果吧"),80095,0,false,1f,0f,100f);
            offsets[116] = DRFMODSound.CreateDRFMODSound(fbb, 50033,fbb.CreateString("使用小方块可以在任意高亮位置填补一格，快点击最合适的那一格吧！"),80096,0,false,1f,0f,100f);
            offsets[117] = DRFMODSound.CreateDRFMODSound(fbb, 50034,fbb.CreateString("真幸运，下一个方块是I型块！"),80097,0,false,1f,0f,100f);
            offsets[118] = DRFMODSound.CreateDRFMODSound(fbb, 50035,fbb.CreateString("让我想想如何摆放才能再制造一个魔方呢..."),80098,0,false,1f,0f,100f);
            offsets[119] = DRFMODSound.CreateDRFMODSound(fbb, 50036,fbb.CreateString("啊！我想到了！请试试我的建议吧！"),80099,0,false,1f,0f,100f);
            offsets[120] = DRFMODSound.CreateDRFMODSound(fbb, 50037,fbb.CreateString("加油，马上就要完成了"),80100,0,false,1f,0f,100f);
            offsets[121] = DRFMODSound.CreateDRFMODSound(fbb, 50038,fbb.CreateString("太精彩了，魔方随机出了一个小锤子！快感受一下它的威力吧"),80101,0,false,1f,0f,100f);
            offsets[122] = DRFMODSound.CreateDRFMODSound(fbb, 50039,fbb.CreateString("小锤子能帮你收集方块上的元素哟！选择一个方块练练手吧！"),80102,0,false,1f,0f,100f);
            offsets[123] = DRFMODSound.CreateDRFMODSound(fbb, 50040,fbb.CreateString("技巧拿捏的刚刚好！继续完成关卡吧！"),80103,0,false,1f,0f,100f);
            offsets[124] = DRFMODSound.CreateDRFMODSound(fbb, 50041,fbb.CreateString("按键操作开启"),80104,0,false,1f,0f,100f);
            offsets[125] = DRFMODSound.CreateDRFMODSound(fbb, 50042,fbb.CreateString("按键功能了解一下"),80105,0,false,1f,0f,100f);
            offsets[126] = DRFMODSound.CreateDRFMODSound(fbb, 50043,fbb.CreateString("让我们来试试这些按钮的手感吧！"),80106,0,false,1f,0f,100f);
            offsets[127] = DRFMODSound.CreateDRFMODSound(fbb, 50044,fbb.CreateString("这是直降按钮，可以让方块一降到底！"),80107,0,false,1f,0f,100f);
            offsets[128] = DRFMODSound.CreateDRFMODSound(fbb, 50045,fbb.CreateString("这是下落按钮，可以试试单击和长按，使方块下落！"),80108,0,false,1f,0f,100f);
            offsets[129] = DRFMODSound.CreateDRFMODSound(fbb, 50046,fbb.CreateString("其他按钮很形象对吧，你这么聪明我就不啰嗦啦"),80109,0,false,1f,0f,100f);
            offsets[130] = DRFMODSound.CreateDRFMODSound(fbb, 50047,fbb.CreateString("哎呀，差一点忘拉，这里展示的数字是本关剩余步数，记得在步数变成零之前达成通关条件哟！"),80110,0,false,1f,0f,100f);
            offsets[131] = DRFMODSound.CreateDRFMODSound(fbb, 50048,fbb.CreateString("自定义键位功能开启"),80111,0,false,1f,0f,100f);
            offsets[132] = DRFMODSound.CreateDRFMODSound(fbb, 50049,fbb.CreateString("点击设置里的自定义键位按钮，新世界的大门为你打开…"),80112,0,false,1f,0f,100f);
            offsets[133] = DRFMODSound.CreateDRFMODSound(fbb, 50050,fbb.CreateString("按钮可拖动至任意键位哟"),80113,0,false,1f,0f,100f);
            offsets[134] = DRFMODSound.CreateDRFMODSound(fbb, 50051,fbb.CreateString("还剩10步！"),80114,0,false,1f,0f,100f);
            offsets[135] = DRFMODSound.CreateDRFMODSound(fbb, 50052,fbb.CreateString("点击这里可购买步数，帮助通关哟！"),80115,0,false,1f,0f,100f);
            offsets[136] = DRFMODSound.CreateDRFMODSound(fbb, 50053,fbb.CreateString("祝您在奇幻游乐园度过愉快的一天！"),80116,0,false,1f,0f,100f);
            offsets[137] = DRFMODSound.CreateDRFMODSound(fbb, 50054,fbb.CreateString("嘿，你好，我就是你的引路人小红帽，对对对，就是众所周知的那个小红帽。"),80117,0,false,1f,0f,100f);
            offsets[138] = DRFMODSound.CreateDRFMODSound(fbb, 50055,fbb.CreateString("长话短说，奇幻乐园被红心女王施了黑魔法，我们找不到它的入口了！但是古老的传说中有一张藏宝图，记录了一个大宝藏，以及奇幻乐园的位置。"),80118,0,false,1f,0f,100f);
            offsets[139] = DRFMODSound.CreateDRFMODSound(fbb, 50056,fbb.CreateString("可惜藏宝图被分成了6块碎片散落在童话世界里，我从外婆那里得到一块碎片，剩余的5块我们要去童话世界冒险来寻找…"),80119,0,false,1f,0f,100f);
            offsets[140] = DRFMODSound.CreateDRFMODSound(fbb, 50057,fbb.CreateString("在开始冒险之前，我会先带你熟悉一下童话世界冒险的游戏规则，你可要好好掌握哦！"),80120,0,false,1f,0f,100f);
            offsets[141] = DRFMODSound.CreateDRFMODSound(fbb, 50058,fbb.CreateString("接下来我们要开始正式的冒险啦，加油哦！"),80121,0,false,1f,0f,100f);
            offsets[142] = DRFMODSound.CreateDRFMODSound(fbb, 50059,fbb.CreateString("开场漫画背景音乐"),89004,0,false,1f,0f,100f);

            VectorOffset dataOff = Table_FMODSound.CreateDataVector(fbb, offsets);
            var configOff = Table_FMODSound.CreateTable_FMODSound(fbb, dataOff);
            Table_FMODSound.FinishTable_FMODSoundBuffer(fbb, configOff);
            using (var ms = new MemoryStream(fbb.DataBuffer.ToFullArray(), fbb.DataBuffer.Position, fbb.Offset))
            {
                try
                {
                    var data = ms.ToArray();
                    File.WriteAllBytes(path, data);
                    Console.WriteLine("已生成:" + path.ToString());
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.ToString());
                }
            }
        }
    }
}