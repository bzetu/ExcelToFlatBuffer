using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_LevelTarget : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_LevelTarget.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRLevelTarget>[] offsets = new Offset<DRLevelTarget>[144];
   
            offsets[0] = DRLevelTarget.CreateDRLevelTarget(fbb, 1,fbb.CreateString("目标1"),1,21,4,100);
            offsets[1] = DRLevelTarget.CreateDRLevelTarget(fbb, 2,fbb.CreateString("目标2"),0,4,12,100);
            offsets[2] = DRLevelTarget.CreateDRLevelTarget(fbb, 3,fbb.CreateString("目标3"),4,1,2,100);
            offsets[3] = DRLevelTarget.CreateDRLevelTarget(fbb, 4,fbb.CreateString("目标4"),4,2,2,100);
            offsets[4] = DRLevelTarget.CreateDRLevelTarget(fbb, 5,fbb.CreateString("目标5"),4,3,1,100);
            offsets[5] = DRLevelTarget.CreateDRLevelTarget(fbb, 6,fbb.CreateString("4关消除16行"),1,21,16,100);
            offsets[6] = DRLevelTarget.CreateDRLevelTarget(fbb, 7,fbb.CreateString("5关收集17个铃铛"),0,4,17,100);
            offsets[7] = DRLevelTarget.CreateDRLevelTarget(fbb, 8,fbb.CreateString("6关收集17个铃铛"),0,4,17,100);
            offsets[8] = DRLevelTarget.CreateDRLevelTarget(fbb, 9,fbb.CreateString("7关收集20个铃铛"),0,4,20,100);
            offsets[9] = DRLevelTarget.CreateDRLevelTarget(fbb, 10,fbb.CreateString("7关制造4个飞机"),4,1,4,0);
            offsets[10] = DRLevelTarget.CreateDRLevelTarget(fbb, 11,fbb.CreateString("8关收集28个铃铛"),0,4,28,100);
            offsets[11] = DRLevelTarget.CreateDRLevelTarget(fbb, 12,fbb.CreateString("8关制造3个泡泡糖"),4,2,3,0);
            offsets[12] = DRLevelTarget.CreateDRLevelTarget(fbb, 13,fbb.CreateString("9关收集12个铃铛"),0,4,12,100);
            offsets[13] = DRLevelTarget.CreateDRLevelTarget(fbb, 14,fbb.CreateString("10关收集20个铃铛"),0,4,20,100);
            offsets[14] = DRLevelTarget.CreateDRLevelTarget(fbb, 15,fbb.CreateString("11关收集22个铃铛"),0,4,22,100);
            offsets[15] = DRLevelTarget.CreateDRLevelTarget(fbb, 16,fbb.CreateString("12关收集2个啄木鸟"),0,42,2,100);
            offsets[16] = DRLevelTarget.CreateDRLevelTarget(fbb, 17,fbb.CreateString("13关收集4个啄木鸟"),0,42,4,100);
            offsets[17] = DRLevelTarget.CreateDRLevelTarget(fbb, 18,fbb.CreateString("13关收集3个泡泡糖"),4,2,3,0);
            offsets[18] = DRLevelTarget.CreateDRLevelTarget(fbb, 19,fbb.CreateString("14关收集4个啄木鸟"),0,42,4,100);
            offsets[19] = DRLevelTarget.CreateDRLevelTarget(fbb, 20,fbb.CreateString("15关收集4个啄木鸟"),0,42,4,100);
            offsets[20] = DRLevelTarget.CreateDRLevelTarget(fbb, 21,fbb.CreateString("16关收集铃铛"),0,4,17,20);
            offsets[21] = DRLevelTarget.CreateDRLevelTarget(fbb, 22,fbb.CreateString("16关收集幽灵"),0,42,4,80);
            offsets[22] = DRLevelTarget.CreateDRLevelTarget(fbb, 23,fbb.CreateString("17关收集铃铛"),0,4,25,20);
            offsets[23] = DRLevelTarget.CreateDRLevelTarget(fbb, 24,fbb.CreateString("17关收集幽灵"),0,42,4,80);
            offsets[24] = DRLevelTarget.CreateDRLevelTarget(fbb, 25,fbb.CreateString("18关目标1收集幽灵"),0,42,6,100);
            offsets[25] = DRLevelTarget.CreateDRLevelTarget(fbb, 26,fbb.CreateString("19关目标1收集幽灵"),0,42,6,100);
            offsets[26] = DRLevelTarget.CreateDRLevelTarget(fbb, 27,fbb.CreateString("19关目标2收集铃铛"),0,4,12,100);
            offsets[27] = DRLevelTarget.CreateDRLevelTarget(fbb, 28,fbb.CreateString("20关目标1收集幽灵"),0,42,6,100);
            offsets[28] = DRLevelTarget.CreateDRLevelTarget(fbb, 29,fbb.CreateString("20关目标2收集铃铛"),0,4,10,100);
            offsets[29] = DRLevelTarget.CreateDRLevelTarget(fbb, 30,fbb.CreateString("21关目标1收集颜色块"),2,3,24,100);
            offsets[30] = DRLevelTarget.CreateDRLevelTarget(fbb, 31,fbb.CreateString("22关目标1收集颜色块"),2,3,30,100);
            offsets[31] = DRLevelTarget.CreateDRLevelTarget(fbb, 32,fbb.CreateString("22关目标2制造泡泡糖"),4,2,2,100);
            offsets[32] = DRLevelTarget.CreateDRLevelTarget(fbb, 33,fbb.CreateString("23关目标1收集颜色块"),2,3,35,100);
            offsets[33] = DRLevelTarget.CreateDRLevelTarget(fbb, 34,fbb.CreateString("23关目标2收集铃铛"),0,4,10,1000);
            offsets[34] = DRLevelTarget.CreateDRLevelTarget(fbb, 35,fbb.CreateString("24关目标1收集颜色块"),2,3,40,100);
            offsets[35] = DRLevelTarget.CreateDRLevelTarget(fbb, 36,fbb.CreateString("25关目标1收集幽灵"),0,42,6,100);
            offsets[36] = DRLevelTarget.CreateDRLevelTarget(fbb, 37,fbb.CreateString("25关目标2收集颜色块"),2,3,30,100);
            offsets[37] = DRLevelTarget.CreateDRLevelTarget(fbb, 38,fbb.CreateString("26关目标1收集幽灵"),0,42,6,100);
            offsets[38] = DRLevelTarget.CreateDRLevelTarget(fbb, 39,fbb.CreateString("26关目标2收集颜色块"),2,3,30,100);
            offsets[39] = DRLevelTarget.CreateDRLevelTarget(fbb, 40,fbb.CreateString("27关目标1收集幽灵"),0,42,6,100);
            offsets[40] = DRLevelTarget.CreateDRLevelTarget(fbb, 41,fbb.CreateString("27关目标2收集颜色块"),2,3,30,100);
            offsets[41] = DRLevelTarget.CreateDRLevelTarget(fbb, 42,fbb.CreateString("28关收集冰块"),3,1,12,100);
            offsets[42] = DRLevelTarget.CreateDRLevelTarget(fbb, 43,fbb.CreateString("29关收集冰块"),3,1,18,100);
            offsets[43] = DRLevelTarget.CreateDRLevelTarget(fbb, 44,fbb.CreateString("30关收集铃铛"),0,4,8,100);
            offsets[44] = DRLevelTarget.CreateDRLevelTarget(fbb, 45,fbb.CreateString("31关收集铃铛"),0,4,6,100);
            offsets[45] = DRLevelTarget.CreateDRLevelTarget(fbb, 46,fbb.CreateString("32关收集铃铛"),0,4,20,100);
            offsets[46] = DRLevelTarget.CreateDRLevelTarget(fbb, 47,fbb.CreateString("32关收集冰块"),3,1,40,100);
            offsets[47] = DRLevelTarget.CreateDRLevelTarget(fbb, 48,fbb.CreateString("33关收集冰块"),3,1,14,100);
            offsets[48] = DRLevelTarget.CreateDRLevelTarget(fbb, 49,fbb.CreateString("34关收集铃铛"),0,4,8,100);
            offsets[49] = DRLevelTarget.CreateDRLevelTarget(fbb, 50,fbb.CreateString("34关收集冰块"),3,1,24,100);
            offsets[50] = DRLevelTarget.CreateDRLevelTarget(fbb, 51,fbb.CreateString("35关收集绿色块"),2,4,20,100);
            offsets[51] = DRLevelTarget.CreateDRLevelTarget(fbb, 52,fbb.CreateString("35关收集泡泡糖"),4,2,1,100);
            offsets[52] = DRLevelTarget.CreateDRLevelTarget(fbb, 53,fbb.CreateString("36关收集幽灵"),0,27,4,100);
            offsets[53] = DRLevelTarget.CreateDRLevelTarget(fbb, 54,fbb.CreateString("37关收集幽灵"),0,27,4,100);
            offsets[54] = DRLevelTarget.CreateDRLevelTarget(fbb, 55,fbb.CreateString("38关收集橙色块"),2,2,25,100);
            offsets[55] = DRLevelTarget.CreateDRLevelTarget(fbb, 56,fbb.CreateString("39关收集浅蓝色块"),2,0,20,100);
            offsets[56] = DRLevelTarget.CreateDRLevelTarget(fbb, 57,fbb.CreateString("40关收集红色块"),2,6,30,100);
            offsets[57] = DRLevelTarget.CreateDRLevelTarget(fbb, 58,fbb.CreateString("40关收集飞机"),4,1,2,100);
            offsets[58] = DRLevelTarget.CreateDRLevelTarget(fbb, 59,fbb.CreateString("41关拯救睡美人"),0,34,1,100);
            offsets[59] = DRLevelTarget.CreateDRLevelTarget(fbb, 60,fbb.CreateString("47关收集玫瑰花"),0,26,2,100);
            offsets[60] = DRLevelTarget.CreateDRLevelTarget(fbb, 61,fbb.CreateString("48关收集玫瑰花"),0,26,3,100);
            offsets[61] = DRLevelTarget.CreateDRLevelTarget(fbb, 62,fbb.CreateString("51关收集木箱"),0,6,8,100);
            offsets[62] = DRLevelTarget.CreateDRLevelTarget(fbb, 63,fbb.CreateString("52关收集木箱"),0,6,6,100);
            offsets[63] = DRLevelTarget.CreateDRLevelTarget(fbb, 64,fbb.CreateString("53关收集铃铛"),0,4,8,100);
            offsets[64] = DRLevelTarget.CreateDRLevelTarget(fbb, 65,fbb.CreateString("54关收集铃铛"),0,4,8,100);
            offsets[65] = DRLevelTarget.CreateDRLevelTarget(fbb, 66,fbb.CreateString("55关收集冰块"),3,1,18,100);
            offsets[66] = DRLevelTarget.CreateDRLevelTarget(fbb, 67,fbb.CreateString("56关收集木箱"),0,6,8,100);
            offsets[67] = DRLevelTarget.CreateDRLevelTarget(fbb, 68,fbb.CreateString("56关收集冰块"),3,1,20,100);
            offsets[68] = DRLevelTarget.CreateDRLevelTarget(fbb, 69,fbb.CreateString("57关收集木箱"),0,6,17,100);
            offsets[69] = DRLevelTarget.CreateDRLevelTarget(fbb, 70,fbb.CreateString("57关收集冰块"),3,1,17,100);
            offsets[70] = DRLevelTarget.CreateDRLevelTarget(fbb, 71,fbb.CreateString("55关收集木箱"),0,6,4,100);
            offsets[71] = DRLevelTarget.CreateDRLevelTarget(fbb, 72,fbb.CreateString("54关制造泡泡糖"),4,2,3,100);
            offsets[72] = DRLevelTarget.CreateDRLevelTarget(fbb, 75,fbb.CreateString("59关收集颜色块"),2,6,30,100);
            offsets[73] = DRLevelTarget.CreateDRLevelTarget(fbb, 76,fbb.CreateString("60关收集颜色块"),2,5,30,100);
            offsets[74] = DRLevelTarget.CreateDRLevelTarget(fbb, 77,fbb.CreateString("61关收集铃铛"),0,4,14,100);
            offsets[75] = DRLevelTarget.CreateDRLevelTarget(fbb, 78,fbb.CreateString("62关收集铃铛"),0,4,11,100);
            offsets[76] = DRLevelTarget.CreateDRLevelTarget(fbb, 79,fbb.CreateString("63关收集木箱"),0,6,15,100);
            offsets[77] = DRLevelTarget.CreateDRLevelTarget(fbb, 80,fbb.CreateString("64关收集木箱"),0,6,20,100);
            offsets[78] = DRLevelTarget.CreateDRLevelTarget(fbb, 81,fbb.CreateString("65关收集冰块"),3,1,16,100);
            offsets[79] = DRLevelTarget.CreateDRLevelTarget(fbb, 82,fbb.CreateString("66关收集冰块"),3,1,20,100);
            offsets[80] = DRLevelTarget.CreateDRLevelTarget(fbb, 83,fbb.CreateString("66关收集木箱"),0,6,20,100);
            offsets[81] = DRLevelTarget.CreateDRLevelTarget(fbb, 84,fbb.CreateString("67关收集冰块"),3,1,20,100);
            offsets[82] = DRLevelTarget.CreateDRLevelTarget(fbb, 85,fbb.CreateString("67关收集木箱"),0,6,20,100);
            offsets[83] = DRLevelTarget.CreateDRLevelTarget(fbb, 86,fbb.CreateString("68关收集紫色块"),2,5,40,100);
            offsets[84] = DRLevelTarget.CreateDRLevelTarget(fbb, 87,fbb.CreateString("69关收集红色块"),2,6,40,100);
            offsets[85] = DRLevelTarget.CreateDRLevelTarget(fbb, 88,fbb.CreateString("70关收集黄色块"),2,3,40,100);
            offsets[86] = DRLevelTarget.CreateDRLevelTarget(fbb, 89,fbb.CreateString("70关收集飞机"),4,1,2,100);
            offsets[87] = DRLevelTarget.CreateDRLevelTarget(fbb, 90,fbb.CreateString("71关-铃铛"),0,4,10,100);
            offsets[88] = DRLevelTarget.CreateDRLevelTarget(fbb, 91,fbb.CreateString("72关-铃铛"),0,4,7,100);
            offsets[89] = DRLevelTarget.CreateDRLevelTarget(fbb, 92,fbb.CreateString("73关-冰块"),3,1,13,100);
            offsets[90] = DRLevelTarget.CreateDRLevelTarget(fbb, 93,fbb.CreateString("74关-冰块"),3,1,10,100);
            offsets[91] = DRLevelTarget.CreateDRLevelTarget(fbb, 94,fbb.CreateString("75关-色块"),2,3,12,100);
            offsets[92] = DRLevelTarget.CreateDRLevelTarget(fbb, 95,fbb.CreateString("76关-色块"),2,4,20,100);
            offsets[93] = DRLevelTarget.CreateDRLevelTarget(fbb, 96,fbb.CreateString("77关-睡美人"),0,34,1,100);
            offsets[94] = DRLevelTarget.CreateDRLevelTarget(fbb, 97,fbb.CreateString("78关-玫瑰"),0,26,1,100);
            offsets[95] = DRLevelTarget.CreateDRLevelTarget(fbb, 98,fbb.CreateString("79关-木箱"),0,6,10,100);
            offsets[96] = DRLevelTarget.CreateDRLevelTarget(fbb, 99,fbb.CreateString("80关-铃铛"),0,4,5,100);
            offsets[97] = DRLevelTarget.CreateDRLevelTarget(fbb, 100,fbb.CreateString("80关-泡泡糖还没做"),0,6,2,100);
            offsets[98] = DRLevelTarget.CreateDRLevelTarget(fbb, 101,fbb.CreateString("81关-铃铛"),0,4,5,100);
            offsets[99] = DRLevelTarget.CreateDRLevelTarget(fbb, 102,fbb.CreateString("82关-铃铛"),0,4,5,100);
            offsets[100] = DRLevelTarget.CreateDRLevelTarget(fbb, 103,fbb.CreateString("83关-铃铛"),0,4,6,100);
            offsets[101] = DRLevelTarget.CreateDRLevelTarget(fbb, 104,fbb.CreateString("84关-冰块"),3,1,2,100);
            offsets[102] = DRLevelTarget.CreateDRLevelTarget(fbb, 105,fbb.CreateString("85关-冰块"),3,1,3,100);
            offsets[103] = DRLevelTarget.CreateDRLevelTarget(fbb, 106,fbb.CreateString("86关-木箱"),0,6,12,100);
            offsets[104] = DRLevelTarget.CreateDRLevelTarget(fbb, 107,fbb.CreateString("87关-木箱"),0,6,8,100);
            offsets[105] = DRLevelTarget.CreateDRLevelTarget(fbb, 108,fbb.CreateString("88关-色块"),2,6,16,100);
            offsets[106] = DRLevelTarget.CreateDRLevelTarget(fbb, 109,fbb.CreateString("89关-色块"),2,3,5,100);
            offsets[107] = DRLevelTarget.CreateDRLevelTarget(fbb, 110,fbb.CreateString("89关-木箱"),0,6,16,100);
            offsets[108] = DRLevelTarget.CreateDRLevelTarget(fbb, 111,fbb.CreateString("90关-冰块"),3,1,10,100);
            offsets[109] = DRLevelTarget.CreateDRLevelTarget(fbb, 112,fbb.CreateString("91关-幽灵"),0,27,3,100);
            offsets[110] = DRLevelTarget.CreateDRLevelTarget(fbb, 113,fbb.CreateString("91关-飞机"),4,1,1,1);
            offsets[111] = DRLevelTarget.CreateDRLevelTarget(fbb, 114,fbb.CreateString("92关-幽灵"),0,27,4,100);
            offsets[112] = DRLevelTarget.CreateDRLevelTarget(fbb, 115,fbb.CreateString("93关-幽灵"),0,27,6,100);
            offsets[113] = DRLevelTarget.CreateDRLevelTarget(fbb, 116,fbb.CreateString("93关-色块"),2,0,22,10);
            offsets[114] = DRLevelTarget.CreateDRLevelTarget(fbb, 117,fbb.CreateString("94关-幽灵"),0,27,5,100);
            offsets[115] = DRLevelTarget.CreateDRLevelTarget(fbb, 118,fbb.CreateString("94关-铃铛"),0,4,6,10);
            offsets[116] = DRLevelTarget.CreateDRLevelTarget(fbb, 119,fbb.CreateString("95关-色块1"),2,0,15,100);
            offsets[117] = DRLevelTarget.CreateDRLevelTarget(fbb, 120,fbb.CreateString("95关-色块2"),2,3,15,100);
            offsets[118] = DRLevelTarget.CreateDRLevelTarget(fbb, 121,fbb.CreateString("96关-色块"),2,3,30,10);
            offsets[119] = DRLevelTarget.CreateDRLevelTarget(fbb, 122,fbb.CreateString("96关-冰块"),3,1,10,100);
            offsets[120] = DRLevelTarget.CreateDRLevelTarget(fbb, 123,fbb.CreateString("97关-幽灵"),0,27,4,100);
            offsets[121] = DRLevelTarget.CreateDRLevelTarget(fbb, 124,fbb.CreateString("97关-飞机"),4,1,1,1);
            offsets[122] = DRLevelTarget.CreateDRLevelTarget(fbb, 125,fbb.CreateString("98关-幽灵"),0,27,6,100);
            offsets[123] = DRLevelTarget.CreateDRLevelTarget(fbb, 126,fbb.CreateString("98关-色块"),2,0,6,10);
            offsets[124] = DRLevelTarget.CreateDRLevelTarget(fbb, 127,fbb.CreateString("99关-幽灵"),0,27,4,100);
            offsets[125] = DRLevelTarget.CreateDRLevelTarget(fbb, 128,fbb.CreateString("99关-彩虹糖"),0,32,24,10);
            offsets[126] = DRLevelTarget.CreateDRLevelTarget(fbb, 129,fbb.CreateString("100关-幽灵"),0,27,5,100);
            offsets[127] = DRLevelTarget.CreateDRLevelTarget(fbb, 130,fbb.CreateString("100关-色块1"),2,3,6,1);
            offsets[128] = DRLevelTarget.CreateDRLevelTarget(fbb, 131,fbb.CreateString("100关-色块2"),2,1,6,10);
            offsets[129] = DRLevelTarget.CreateDRLevelTarget(fbb, 132,fbb.CreateString("101-105关-小鹰测试"),0,22,2,100);
            offsets[130] = DRLevelTarget.CreateDRLevelTarget(fbb, 133,fbb.CreateString("1关-飞机"),4,1,2,100);
            offsets[131] = DRLevelTarget.CreateDRLevelTarget(fbb, 134,fbb.CreateString("1关-泡泡糖"),4,2,2,100);
            offsets[132] = DRLevelTarget.CreateDRLevelTarget(fbb, 135,fbb.CreateString("1关-魔方"),4,3,2,100);
            offsets[133] = DRLevelTarget.CreateDRLevelTarget(fbb, 136,fbb.CreateString("106关-收集铃铛"),0,4,10,100);
            offsets[134] = DRLevelTarget.CreateDRLevelTarget(fbb, 137,fbb.CreateString("107关-收集铃铛"),0,4,10,100);
            offsets[135] = DRLevelTarget.CreateDRLevelTarget(fbb, 138,fbb.CreateString("108关-收集冰块"),3,1,10,100);
            offsets[136] = DRLevelTarget.CreateDRLevelTarget(fbb, 139,fbb.CreateString("109关-收集冰块"),3,1,10,100);
            offsets[137] = DRLevelTarget.CreateDRLevelTarget(fbb, 140,fbb.CreateString("110关-收集颜色块"),2,1,20,100);
            offsets[138] = DRLevelTarget.CreateDRLevelTarget(fbb, 141,fbb.CreateString("111关-收集冰块"),3,1,10,100);
            offsets[139] = DRLevelTarget.CreateDRLevelTarget(fbb, 142,fbb.CreateString("112关-睡美人"),0,34,1,100);
            offsets[140] = DRLevelTarget.CreateDRLevelTarget(fbb, 143,fbb.CreateString("113关-睡美人"),0,26,1,100);
            offsets[141] = DRLevelTarget.CreateDRLevelTarget(fbb, 144,fbb.CreateString("114关-铃铛"),0,6,17,100);
            offsets[142] = DRLevelTarget.CreateDRLevelTarget(fbb, 145,fbb.CreateString("115关-泡泡糖"),0,4,5,100);
            offsets[143] = DRLevelTarget.CreateDRLevelTarget(fbb, 146,fbb.CreateString("116关-木箱"),4,2,2,100);

            VectorOffset dataOff = Table_LevelTarget.CreateDataVector(fbb, offsets);
            var configOff = Table_LevelTarget.CreateTable_LevelTarget(fbb, dataOff);
            Table_LevelTarget.FinishTable_LevelTargetBuffer(fbb, configOff);
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