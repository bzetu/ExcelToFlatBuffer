using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_Effect : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Effect.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DREffect>[] offsets = new Offset<DREffect>[119];
   
            offsets[0] = DREffect.CreateDREffect(fbb, 1,fbb.CreateString("一行消除特效"),40001,fbb.CreateString("Effect"),600,0,300,1500,40021,0,-1);
            offsets[1] = DREffect.CreateDREffect(fbb, 2,fbb.CreateString("竖消特效"),40002,fbb.CreateString("Effect"),2000,0,-1,2100,40016,0,-1);
            offsets[2] = DREffect.CreateDREffect(fbb, 3,fbb.CreateString("横消火箭"),40003,fbb.CreateString("Effect"),500,0,-1,2200,40016,0,-1);
            offsets[3] = DREffect.CreateDREffect(fbb, 4,fbb.CreateString("竖消火箭"),40004,fbb.CreateString("Effect"),500,0,-1,2200,40016,0,-1);
            offsets[4] = DREffect.CreateDREffect(fbb, 5,fbb.CreateString("木箱销毁特效"),40005,fbb.CreateString("Effect"),5000,0,-1,5200,-1,0,-1);
            offsets[5] = DREffect.CreateDREffect(fbb, 6,fbb.CreateString("收集铃铛拖尾"),40006,fbb.CreateString("Effect"),-1,0,-1,-1,70001,0,-1);
            offsets[6] = DREffect.CreateDREffect(fbb, 7,fbb.CreateString("泡泡糖出生特效"),40007,fbb.CreateString("BubbleGumEffect"),1200,1200,1000,1200,40019,0,-1);
            offsets[7] = DREffect.CreateDREffect(fbb, 8,fbb.CreateString("泡泡糖爆炸特效"),40008,fbb.CreateString("Effect"),2000,0,500,6000,-1,0,-1);
            offsets[8] = DREffect.CreateDREffect(fbb, 9,fbb.CreateString("魔法棒拖尾特效"),40009,fbb.CreateString("Effect"),1000,0,-1,1200,-1,0,-1);
            offsets[9] = DREffect.CreateDREffect(fbb, 10,fbb.CreateString("飞机出生特效"),40010,fbb.CreateString("Effect"),2000,0,-1,2200,-1,0,-1);
            offsets[10] = DREffect.CreateDREffect(fbb, 11,fbb.CreateString("飞机拖尾特效_不用"),40011,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[11] = DREffect.CreateDREffect(fbb, 12,fbb.CreateString("飞机爆炸特效"),40012,fbb.CreateString("Effect"),400,0,-1,2000,-1,0,-1);
            offsets[12] = DREffect.CreateDREffect(fbb, 13,fbb.CreateString("一键到底特效"),40013,fbb.CreateString("Effect"),1000,0,-1,1500,-1,0,-1);
            offsets[13] = DREffect.CreateDREffect(fbb, 14,fbb.CreateString("金手指特效"),40014,fbb.CreateString("Effect"),1000,0,-1,1500,40023,0,-1);
            offsets[14] = DREffect.CreateDREffect(fbb, 15,fbb.CreateString("非一键到底特效"),40015,fbb.CreateString("Effect"),1000,0,-1,1501,-1,0,-1);
            offsets[15] = DREffect.CreateDREffect(fbb, 16,fbb.CreateString("通用点击特效"),40016,fbb.CreateString("Effect"),5000,0,0,5100,-1,0,-1);
            offsets[16] = DREffect.CreateDREffect(fbb, 17,fbb.CreateString("两行消除特效"),40017,fbb.CreateString("Effect"),600,0,-1,1503,-1,0,-1);
            offsets[17] = DREffect.CreateDREffect(fbb, 18,fbb.CreateString("三行消除特效"),40018,fbb.CreateString("Effect"),600,0,-1,1504,-1,0,-1);
            offsets[18] = DREffect.CreateDREffect(fbb, 19,fbb.CreateString("四行消除特效"),40019,fbb.CreateString("Effect"),600,0,-1,1505,-1,0,-1);
            offsets[19] = DREffect.CreateDREffect(fbb, 20,fbb.CreateString("两行消除特效产生飞机_使用中"),40020,fbb.CreateString("PlaneEffect"),1200,1200,800,-1,-1,0,-1);
            offsets[20] = DREffect.CreateDREffect(fbb, 21,fbb.CreateString("魔方特效"),40021,fbb.CreateString("MagicCubeEffect"),4000,0,500,4100,40046,0,-1);
            offsets[21] = DREffect.CreateDREffect(fbb, 22,fbb.CreateString("魔方产生道具特效"),40022,fbb.CreateString("Effect"),4000,0,-1,4100,-1,0,-1);
            offsets[22] = DREffect.CreateDREffect(fbb, 23,fbb.CreateString("扭扭蛋出现特效"),40023,fbb.CreateString("Effect"),5001,0,-1,5501,-1,0,-1);
            offsets[23] = DREffect.CreateDREffect(fbb, 24,fbb.CreateString("传送门"),40024,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[24] = DREffect.CreateDREffect(fbb, 25,fbb.CreateString("加步数元素消失特效"),40025,fbb.CreateString("Effect"),1000,0,-1,1100,-1,0,-1);
            offsets[25] = DREffect.CreateDREffect(fbb, 26,fbb.CreateString("加步数元素警告特效"),40026,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[26] = DREffect.CreateDREffect(fbb, 27,fbb.CreateString("方块消除特效"),40027,fbb.CreateString("Effect"),50,0,-1,2000,40021,0,-1);
            offsets[27] = DREffect.CreateDREffect(fbb, 28,fbb.CreateString("方块消除预警特效"),40028,fbb.CreateString("Effect"),200,0,-1,400,-1,0,-1);
            offsets[28] = DREffect.CreateDREffect(fbb, 29,fbb.CreateString("方块下落接触特效"),40029,fbb.CreateString("Effect"),1500,0,-1,1600,-1,0,-1);
            offsets[29] = DREffect.CreateDREffect(fbb, 30,fbb.CreateString("方块下落接触闪光特效"),40030,fbb.CreateString("Effect"),2000,0,-1,2100,60009,0,-1);
            offsets[30] = DREffect.CreateDREffect(fbb, 34,fbb.CreateString("炸弹爆炸"),40034,fbb.CreateString("Effect"),5000,0,500,5000,40020,900,-1);
            offsets[31] = DREffect.CreateDREffect(fbb, 35,fbb.CreateString("清屏道具特效"),40114,fbb.CreateString("Effect"),1000,0,-1,1100,-1,0,-1);
            offsets[32] = DREffect.CreateDREffect(fbb, 36,fbb.CreateString("combo文字特效"),40035,fbb.CreateString("Effect"),2000,0,-1,2100,-1,0,-1);
            offsets[33] = DREffect.CreateDREffect(fbb, 37,fbb.CreateString("good文字特效"),40036,fbb.CreateString("Effect"),2000,0,-1,2100,-1,0,-1);
            offsets[34] = DREffect.CreateDREffect(fbb, 38,fbb.CreateString("nice文字特效"),40037,fbb.CreateString("Effect"),2000,0,-1,2100,-1,0,-1);
            offsets[35] = DREffect.CreateDREffect(fbb, 39,fbb.CreateString("wonderful文字特效"),40038,fbb.CreateString("Effect"),2000,0,-1,2100,-1,0,-1);
            offsets[36] = DREffect.CreateDREffect(fbb, 40,fbb.CreateString("unbelievable文字特效"),40039,fbb.CreateString("Effect"),2000,0,-1,2100,-1,0,-1);
            offsets[37] = DREffect.CreateDREffect(fbb, 43,fbb.CreateString("魔方产生金手指"),40042,fbb.CreateString("Effect"),4000,0,-1,-1,-1,6000,-1);
            offsets[38] = DREffect.CreateDREffect(fbb, 44,fbb.CreateString("魔方产生万能块"),40043,fbb.CreateString("Effect"),4000,0,-1,-1,-1,6000,-1);
            offsets[39] = DREffect.CreateDREffect(fbb, 45,fbb.CreateString("魔方生成道具飞行光效"),40040,fbb.CreateString("Effect"),2000,0,-1,2100,-1,0,-1);
            offsets[40] = DREffect.CreateDREffect(fbb, 46,fbb.CreateString("魔方产生小锤子"),40041,fbb.CreateString("Effect"),4000,0,-1,8000,-1,0,-1);
            offsets[41] = DREffect.CreateDREffect(fbb, 47,fbb.CreateString("锤子特效"),40044,fbb.CreateString("Effect"),2200,0,1600,2300,40018,0,-1);
            offsets[42] = DREffect.CreateDREffect(fbb, 48,fbb.CreateString("消行特效产生的点"),40045,fbb.CreateString("Effect"),100,800,-1,1500,-1,0,-1);
            offsets[43] = DREffect.CreateDREffect(fbb, 49,fbb.CreateString("金手指特效"),40046,fbb.CreateString("Effect"),-1,0,1000,-1,-1,0,-1);
            offsets[44] = DREffect.CreateDREffect(fbb, 50,fbb.CreateString("关卡前进特效"),40047,fbb.CreateString("Effect"),2000,0,-1,2002,-1,0,-1);
            offsets[45] = DREffect.CreateDREffect(fbb, 51,fbb.CreateString("星星点亮特效"),40048,fbb.CreateString("Effect"),2000,0,-1,2003,-1,0,-1);
            offsets[46] = DREffect.CreateDREffect(fbb, 52,fbb.CreateString("当前关卡循环特效"),40049,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[47] = DREffect.CreateDREffect(fbb, 53,fbb.CreateString("增加步数拖尾特效"),40050,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[48] = DREffect.CreateDREffect(fbb, 54,fbb.CreateString("增加步数飞上去的闪光"),40051,fbb.CreateString("Effect"),2000,0,-1,2003,-1,0,-1);
            offsets[49] = DREffect.CreateDREffect(fbb, 55,fbb.CreateString("方块闪一下的预警"),40052,fbb.CreateString("Effect"),600,0,-1,700,-1,0,-1);
            offsets[50] = DREffect.CreateDREffect(fbb, 56,fbb.CreateString("消2行特效产生的点"),40053,fbb.CreateString("EnergyStorageEffect"),100,600,-1,1500,-1,0,-1);
            offsets[51] = DREffect.CreateDREffect(fbb, 57,fbb.CreateString("消3行特效产生的点"),40054,fbb.CreateString("EnergyStorageEffect"),100,700,-1,1500,-1,0,-1);
            offsets[52] = DREffect.CreateDREffect(fbb, 58,fbb.CreateString("消4行特效产生的点"),40055,fbb.CreateString("EnergyStorageEffect"),100,800,-1,1500,-1,0,-1);
            offsets[53] = DREffect.CreateDREffect(fbb, 59,fbb.CreateString("小鹰出生特效"),40056,fbb.CreateString("Effect"),600,0,-1,700,-1,0,-1);
            offsets[54] = DREffect.CreateDREffect(fbb, 60,fbb.CreateString("流星雨方块消除特效"),40027,fbb.CreateString("Effect"),50,0,-1,2000,-1,0,-1);
            offsets[55] = DREffect.CreateDREffect(fbb, 61,fbb.CreateString("方块消除特效"),40027,fbb.CreateString("Effect"),50,0,-1,2000,-1,0,-1);
            offsets[56] = DREffect.CreateDREffect(fbb, 62,fbb.CreateString("小鹰加速的目标拖尾特效"),40057,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[57] = DREffect.CreateDREffect(fbb, 63,fbb.CreateString("小鹰buff特效"),40058,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[58] = DREffect.CreateDREffect(fbb, 64,fbb.CreateString("结算垒方块特效"),40059,fbb.CreateString("Effect"),600,0,-1,700,-1,0,-1);
            offsets[59] = DREffect.CreateDREffect(fbb, 65,fbb.CreateString("双倍飞机特效"),40060,fbb.CreateString("Effect"),2000,0,-1,2100,40054,0,-1);
            offsets[60] = DREffect.CreateDREffect(fbb, 66,fbb.CreateString("双倍泡泡糖特效"),40061,fbb.CreateString("Effect"),2000,0,-1,2100,-1,0,-1);
            offsets[61] = DREffect.CreateDREffect(fbb, 67,fbb.CreateString("魔法门打开特效"),40062,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[62] = DREffect.CreateDREffect(fbb, 68,fbb.CreateString("生成幽灵特效"),40063,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[63] = DREffect.CreateDREffect(fbb, 69,fbb.CreateString("魔法门关闭时的黑烟特效"),40064,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[64] = DREffect.CreateDREffect(fbb, 70,fbb.CreateString("幽魂爆炸特效"),40065,fbb.CreateString("Effect"),3000,0,-1,3100,-1,0,-1);
            offsets[65] = DREffect.CreateDREffect(fbb, 71,fbb.CreateString("爆炸后的全屏鬼魂"),40066,fbb.CreateString("Effect"),4000,0,-1,4100,-1,0,-1);
            offsets[66] = DREffect.CreateDREffect(fbb, 72,fbb.CreateString("幽灵嚼方块特效"),40067,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[67] = DREffect.CreateDREffect(fbb, 73,fbb.CreateString("魔方产生后退一步"),40068,fbb.CreateString("Effect"),4000,0,-1,-1,-1,6000,-1);
            offsets[68] = DREffect.CreateDREffect(fbb, 74,fbb.CreateString("魔方产生随机打乱"),40069,fbb.CreateString("Effect"),4000,0,-1,-1,-1,6000,-1);
            offsets[69] = DREffect.CreateDREffect(fbb, 75,fbb.CreateString("魔方产生加步数"),40070,fbb.CreateString("Effect"),4000,0,-1,-1,-1,6000,-1);
            offsets[70] = DREffect.CreateDREffect(fbb, 76,fbb.CreateString("幽灵移动旋风循环"),40071,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[71] = DREffect.CreateDREffect(fbb, 77,fbb.CreateString("幽灵移动旋风一次"),40072,fbb.CreateString("Effect"),3000,0,-1,3100,-1,0,-1);
            offsets[72] = DREffect.CreateDREffect(fbb, 78,fbb.CreateString("冰块消除特效"),40073,fbb.CreateString("Effect"),2000,0,-1,2100,40064,0,-1);
            offsets[73] = DREffect.CreateDREffect(fbb, 79,fbb.CreateString("冰块收集特效"),40074,fbb.CreateString("CollectIceEffect"),700,1000,-1,3000,40056,0,-1);
            offsets[74] = DREffect.CreateDREffect(fbb, 80,fbb.CreateString("游乐园升级特效"),40075,fbb.CreateString("Effect"),6000,0,-1,6100,-1,0,-1);
            offsets[75] = DREffect.CreateDREffect(fbb, 81,fbb.CreateString("幽灵门旋转特效"),40076,fbb.CreateString("Effect"),3000,0,-1,3100,-1,0,-1);
            offsets[76] = DREffect.CreateDREffect(fbb, 82,fbb.CreateString("幽灵飞到方块时反馈特效"),40077,fbb.CreateString("Effect"),1000,0,-1,1100,-1,0,-1);
            offsets[77] = DREffect.CreateDREffect(fbb, 83,fbb.CreateString("彩虹糖爆炸"),40078,fbb.CreateString("Effect"),600,0,-1,700,40068,0,-1);
            offsets[78] = DREffect.CreateDREffect(fbb, 84,fbb.CreateString("染色瓶爆炸"),40079,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[79] = DREffect.CreateDREffect(fbb, 85,fbb.CreateString("染色瓶喷溅特效"),40080,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[80] = DREffect.CreateDREffect(fbb, 86,fbb.CreateString("彩虹糖喷溅飞行特效"),40081,fbb.CreateString("Effect"),1000,0,-1,1100,40069,0,-1);
            offsets[81] = DREffect.CreateDREffect(fbb, 87,fbb.CreateString("染色瓶颜色特效"),40082,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[82] = DREffect.CreateDREffect(fbb, 88,fbb.CreateString("染色瓶溅射到方块上的反馈特效"),40083,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[83] = DREffect.CreateDREffect(fbb, 89,fbb.CreateString("任务界面开宝箱特效1"),40084,fbb.CreateString("Effect"),5000,0,-1,5400,-1,0,-1);
            offsets[84] = DREffect.CreateDREffect(fbb, 90,fbb.CreateString("任务界面开宝箱特效2"),40085,fbb.CreateString("Effect"),5000,0,-1,5100,-1,0,-1);
            offsets[85] = DREffect.CreateDREffect(fbb, 91,fbb.CreateString("任务界面开宝箱特效3"),40086,fbb.CreateString("Effect"),5000,0,-1,5100,-1,0,-1);
            offsets[86] = DREffect.CreateDREffect(fbb, 92,fbb.CreateString("收集物品闪光特效"),40087,fbb.CreateString("Effect"),1000,0,-1,1100,-1,0,-1);
            offsets[87] = DREffect.CreateDREffect(fbb, 93,fbb.CreateString("土拨鼠出现前的循环特效"),40088,fbb.CreateString("Effect"),-1,0,-1,-1,40062,0,-1);
            offsets[88] = DREffect.CreateDREffect(fbb, 94,fbb.CreateString("土拨鼠出土特效"),40089,fbb.CreateString("Effect"),1000,0,-1,1100,40063,0,-1);
            offsets[89] = DREffect.CreateDREffect(fbb, 95,fbb.CreateString("土拨鼠被打特效"),40090,fbb.CreateString("Effect"),1000,0,-1,1100,40061,0,-1);
            offsets[90] = DREffect.CreateDREffect(fbb, 96,fbb.CreateString("收集颜色块的特效"),40091,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[91] = DREffect.CreateDREffect(fbb, 97,fbb.CreateString("睡美人胜利特效"),40092,fbb.CreateString("Effect"),5000,0,-1,5100,-1,0,-1);
            offsets[92] = DREffect.CreateDREffect(fbb, 98,fbb.CreateString("玫瑰花收集特效"),40093,fbb.CreateString("Effect"),1000,0,-1,1100,40057,0,-1);
            offsets[93] = DREffect.CreateDREffect(fbb, 99,fbb.CreateString("玫瑰花拖尾特效"),40094,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[94] = DREffect.CreateDREffect(fbb, 100,fbb.CreateString("任务飞星星特效"),40095,fbb.CreateString("Effect"),1000,0,-1,1100,-1,0,-1);
            offsets[95] = DREffect.CreateDREffect(fbb, 101,fbb.CreateString("任务飞星星反馈特效"),40096,fbb.CreateString("Effect"),1000,0,-1,1100,-1,0,-1);
            offsets[96] = DREffect.CreateDREffect(fbb, 102,fbb.CreateString("任务经验增加飞行特效"),40097,fbb.CreateString("Effect"),1000,0,-1,1100,-1,0,-1);
            offsets[97] = DREffect.CreateDREffect(fbb, 103,fbb.CreateString("任务经验增加反馈特效"),40098,fbb.CreateString("Effect"),1000,0,-1,1100,-1,0,-1);
            offsets[98] = DREffect.CreateDREffect(fbb, 104,fbb.CreateString("选关卡界面开始前的云"),40099,fbb.CreateString("Effect"),2000,0,-1,2100,-1,0,-1);
            offsets[99] = DREffect.CreateDREffect(fbb, 105,fbb.CreateString("选关场景开礼盒特效"),40100,fbb.CreateString("Effect"),2000,0,-1,2100,-1,0,-1);
            offsets[100] = DREffect.CreateDREffect(fbb, 106,fbb.CreateString("建筑替换箭头特效"),40101,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[101] = DREffect.CreateDREffect(fbb, 107,fbb.CreateString("换路面特效"),40102,fbb.CreateString("Effect"),1500,0,-1,1600,-1,0,-1);
            offsets[102] = DREffect.CreateDREffect(fbb, 108,fbb.CreateString("战前加步数展示特效"),40103,fbb.CreateString("Effect"),2500,0,-1,2600,-1,0,-1);
            offsets[103] = DREffect.CreateDREffect(fbb, 109,fbb.CreateString("战前加步数反馈特效"),40104,fbb.CreateString("Effect"),2500,0,-1,2600,-1,0,-1);
            offsets[104] = DREffect.CreateDREffect(fbb, 110,fbb.CreateString("消行的道具打击感特效"),40105,fbb.CreateString("Effect"),2500,0,-1,2600,-1,0,-1);
            offsets[105] = DREffect.CreateDREffect(fbb, 111,fbb.CreateString("长按特效"),40106,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[106] = DREffect.CreateDREffect(fbb, 112,fbb.CreateString("拖动特效"),40107,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[107] = DREffect.CreateDREffect(fbb, 113,fbb.CreateString("新泡泡糖特效"),40108,fbb.CreateString("Effect"),2500,0,-1,2600,-1,0,-1);
            offsets[108] = DREffect.CreateDREffect(fbb, 114,fbb.CreateString("新泡泡糖碎裂特效"),40109,fbb.CreateString("Effect"),2500,0,-1,2600,-1,0,-1);
            offsets[109] = DREffect.CreateDREffect(fbb, 115,fbb.CreateString("后悔药特效"),40110,fbb.CreateString("Effect"),2500,0,-1,2600,-1,0,-1);
            offsets[110] = DREffect.CreateDREffect(fbb, 116,fbb.CreateString("二行消除特效"),40111,fbb.CreateString("Effect"),600,0,-1,1500,-1,0,-1);
            offsets[111] = DREffect.CreateDREffect(fbb, 117,fbb.CreateString("三行消除特效"),40112,fbb.CreateString("Effect"),600,0,-1,1500,-1,0,-1);
            offsets[112] = DREffect.CreateDREffect(fbb, 118,fbb.CreateString("四行消除特效"),40113,fbb.CreateString("Effect"),600,0,-1,1500,-1,0,-1);
            offsets[113] = DREffect.CreateDREffect(fbb, 119,fbb.CreateString("四行消除特效2"),40114,fbb.CreateString("Effect"),600,0,-1,1500,-1,0,-1);
            offsets[114] = DREffect.CreateDREffect(fbb, 120,fbb.CreateString("闪电选中特效"),40115,fbb.CreateString("Effect"),-1,0,-1,-1,-1,0,-1);
            offsets[115] = DREffect.CreateDREffect(fbb, 121,fbb.CreateString("闪电激活特效"),40116,fbb.CreateString("Effect"),600,0,-1,1500,-1,0,-1);
            offsets[116] = DREffect.CreateDREffect(fbb, 122,fbb.CreateString("幽灵特殊攻击特效"),40117,fbb.CreateString("Effect"),1400,0,-1,1500,-1,0,-1);
            offsets[117] = DREffect.CreateDREffect(fbb, 123,fbb.CreateString("魔法弹破壳特效"),40118,fbb.CreateString("Effect"),1400,0,-1,1500,-1,0,-1);
            offsets[118] = DREffect.CreateDREffect(fbb, 124,fbb.CreateString("幽灵普通攻击特效"),40119,fbb.CreateString("Effect"),1400,0,-1,1500,-1,0,-1);

            VectorOffset dataOff = Table_Effect.CreateDataVector(fbb, offsets);
            var configOff = Table_Effect.CreateTable_Effect(fbb, dataOff);
            Table_Effect.FinishTable_EffectBuffer(fbb, configOff);
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