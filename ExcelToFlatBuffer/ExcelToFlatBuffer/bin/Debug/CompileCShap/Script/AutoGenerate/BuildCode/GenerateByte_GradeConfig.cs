using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_GradeConfig : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_GradeConfig.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRGradeConfig>[] offsets = new Offset<DRGradeConfig>[125];
   
            offsets[0] = DRGradeConfig.CreateDRGradeConfig(fbb, 1,fbb.CreateString("1"),240,2040,3060,5040);
            offsets[1] = DRGradeConfig.CreateDRGradeConfig(fbb, 2,fbb.CreateString("1"),480,2160,3180,5280);
            offsets[2] = DRGradeConfig.CreateDRGradeConfig(fbb, 3,fbb.CreateString("1"),1080,4320,6420,10680);
            offsets[3] = DRGradeConfig.CreateDRGradeConfig(fbb, 4,fbb.CreateString("1"),480,6000,8940,14880);
            offsets[4] = DRGradeConfig.CreateDRGradeConfig(fbb, 5,fbb.CreateString("1"),840,4680,7020,11640);
            offsets[5] = DRGradeConfig.CreateDRGradeConfig(fbb, 6,fbb.CreateString("1"),600,4560,6840,11400);
            offsets[6] = DRGradeConfig.CreateDRGradeConfig(fbb, 7,fbb.CreateString("1"),360,3060,4560,7560);
            offsets[7] = DRGradeConfig.CreateDRGradeConfig(fbb, 8,fbb.CreateString("1"),1020,5220,7860,13020);
            offsets[8] = DRGradeConfig.CreateDRGradeConfig(fbb, 9,fbb.CreateString("1"),660,5100,7620,12660);
            offsets[9] = DRGradeConfig.CreateDRGradeConfig(fbb, 10,fbb.CreateString("1"),1000,2000000,5000000,8000000);
            offsets[10] = DRGradeConfig.CreateDRGradeConfig(fbb, 11,fbb.CreateString("1"),1000,2000,5000000,8000000);
            offsets[11] = DRGradeConfig.CreateDRGradeConfig(fbb, 12,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[12] = DRGradeConfig.CreateDRGradeConfig(fbb, 13,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[13] = DRGradeConfig.CreateDRGradeConfig(fbb, 14,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[14] = DRGradeConfig.CreateDRGradeConfig(fbb, 15,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[15] = DRGradeConfig.CreateDRGradeConfig(fbb, 16,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[16] = DRGradeConfig.CreateDRGradeConfig(fbb, 17,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[17] = DRGradeConfig.CreateDRGradeConfig(fbb, 18,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[18] = DRGradeConfig.CreateDRGradeConfig(fbb, 19,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[19] = DRGradeConfig.CreateDRGradeConfig(fbb, 20,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[20] = DRGradeConfig.CreateDRGradeConfig(fbb, 21,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[21] = DRGradeConfig.CreateDRGradeConfig(fbb, 22,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[22] = DRGradeConfig.CreateDRGradeConfig(fbb, 23,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[23] = DRGradeConfig.CreateDRGradeConfig(fbb, 24,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[24] = DRGradeConfig.CreateDRGradeConfig(fbb, 25,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[25] = DRGradeConfig.CreateDRGradeConfig(fbb, 26,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[26] = DRGradeConfig.CreateDRGradeConfig(fbb, 27,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[27] = DRGradeConfig.CreateDRGradeConfig(fbb, 28,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[28] = DRGradeConfig.CreateDRGradeConfig(fbb, 29,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[29] = DRGradeConfig.CreateDRGradeConfig(fbb, 30,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[30] = DRGradeConfig.CreateDRGradeConfig(fbb, 31,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[31] = DRGradeConfig.CreateDRGradeConfig(fbb, 32,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[32] = DRGradeConfig.CreateDRGradeConfig(fbb, 33,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[33] = DRGradeConfig.CreateDRGradeConfig(fbb, 34,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[34] = DRGradeConfig.CreateDRGradeConfig(fbb, 35,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[35] = DRGradeConfig.CreateDRGradeConfig(fbb, 36,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[36] = DRGradeConfig.CreateDRGradeConfig(fbb, 37,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[37] = DRGradeConfig.CreateDRGradeConfig(fbb, 38,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[38] = DRGradeConfig.CreateDRGradeConfig(fbb, 39,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[39] = DRGradeConfig.CreateDRGradeConfig(fbb, 40,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[40] = DRGradeConfig.CreateDRGradeConfig(fbb, 41,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[41] = DRGradeConfig.CreateDRGradeConfig(fbb, 42,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[42] = DRGradeConfig.CreateDRGradeConfig(fbb, 43,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[43] = DRGradeConfig.CreateDRGradeConfig(fbb, 44,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[44] = DRGradeConfig.CreateDRGradeConfig(fbb, 45,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[45] = DRGradeConfig.CreateDRGradeConfig(fbb, 46,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[46] = DRGradeConfig.CreateDRGradeConfig(fbb, 47,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[47] = DRGradeConfig.CreateDRGradeConfig(fbb, 48,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[48] = DRGradeConfig.CreateDRGradeConfig(fbb, 49,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[49] = DRGradeConfig.CreateDRGradeConfig(fbb, 50,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[50] = DRGradeConfig.CreateDRGradeConfig(fbb, 51,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[51] = DRGradeConfig.CreateDRGradeConfig(fbb, 52,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[52] = DRGradeConfig.CreateDRGradeConfig(fbb, 53,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[53] = DRGradeConfig.CreateDRGradeConfig(fbb, 54,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[54] = DRGradeConfig.CreateDRGradeConfig(fbb, 55,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[55] = DRGradeConfig.CreateDRGradeConfig(fbb, 56,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[56] = DRGradeConfig.CreateDRGradeConfig(fbb, 57,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[57] = DRGradeConfig.CreateDRGradeConfig(fbb, 58,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[58] = DRGradeConfig.CreateDRGradeConfig(fbb, 59,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[59] = DRGradeConfig.CreateDRGradeConfig(fbb, 60,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[60] = DRGradeConfig.CreateDRGradeConfig(fbb, 61,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[61] = DRGradeConfig.CreateDRGradeConfig(fbb, 62,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[62] = DRGradeConfig.CreateDRGradeConfig(fbb, 63,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[63] = DRGradeConfig.CreateDRGradeConfig(fbb, 64,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[64] = DRGradeConfig.CreateDRGradeConfig(fbb, 65,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[65] = DRGradeConfig.CreateDRGradeConfig(fbb, 66,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[66] = DRGradeConfig.CreateDRGradeConfig(fbb, 67,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[67] = DRGradeConfig.CreateDRGradeConfig(fbb, 68,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[68] = DRGradeConfig.CreateDRGradeConfig(fbb, 69,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[69] = DRGradeConfig.CreateDRGradeConfig(fbb, 70,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[70] = DRGradeConfig.CreateDRGradeConfig(fbb, 71,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[71] = DRGradeConfig.CreateDRGradeConfig(fbb, 72,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[72] = DRGradeConfig.CreateDRGradeConfig(fbb, 73,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[73] = DRGradeConfig.CreateDRGradeConfig(fbb, 74,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[74] = DRGradeConfig.CreateDRGradeConfig(fbb, 75,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[75] = DRGradeConfig.CreateDRGradeConfig(fbb, 76,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[76] = DRGradeConfig.CreateDRGradeConfig(fbb, 77,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[77] = DRGradeConfig.CreateDRGradeConfig(fbb, 78,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[78] = DRGradeConfig.CreateDRGradeConfig(fbb, 79,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[79] = DRGradeConfig.CreateDRGradeConfig(fbb, 80,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[80] = DRGradeConfig.CreateDRGradeConfig(fbb, 81,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[81] = DRGradeConfig.CreateDRGradeConfig(fbb, 82,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[82] = DRGradeConfig.CreateDRGradeConfig(fbb, 83,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[83] = DRGradeConfig.CreateDRGradeConfig(fbb, 84,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[84] = DRGradeConfig.CreateDRGradeConfig(fbb, 85,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[85] = DRGradeConfig.CreateDRGradeConfig(fbb, 86,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[86] = DRGradeConfig.CreateDRGradeConfig(fbb, 87,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[87] = DRGradeConfig.CreateDRGradeConfig(fbb, 88,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[88] = DRGradeConfig.CreateDRGradeConfig(fbb, 89,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[89] = DRGradeConfig.CreateDRGradeConfig(fbb, 90,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[90] = DRGradeConfig.CreateDRGradeConfig(fbb, 91,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[91] = DRGradeConfig.CreateDRGradeConfig(fbb, 92,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[92] = DRGradeConfig.CreateDRGradeConfig(fbb, 93,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[93] = DRGradeConfig.CreateDRGradeConfig(fbb, 94,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[94] = DRGradeConfig.CreateDRGradeConfig(fbb, 95,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[95] = DRGradeConfig.CreateDRGradeConfig(fbb, 96,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[96] = DRGradeConfig.CreateDRGradeConfig(fbb, 97,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[97] = DRGradeConfig.CreateDRGradeConfig(fbb, 98,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[98] = DRGradeConfig.CreateDRGradeConfig(fbb, 99,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[99] = DRGradeConfig.CreateDRGradeConfig(fbb, 100,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[100] = DRGradeConfig.CreateDRGradeConfig(fbb, 101,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[101] = DRGradeConfig.CreateDRGradeConfig(fbb, 102,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[102] = DRGradeConfig.CreateDRGradeConfig(fbb, 103,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[103] = DRGradeConfig.CreateDRGradeConfig(fbb, 104,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[104] = DRGradeConfig.CreateDRGradeConfig(fbb, 105,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[105] = DRGradeConfig.CreateDRGradeConfig(fbb, 106,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[106] = DRGradeConfig.CreateDRGradeConfig(fbb, 107,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[107] = DRGradeConfig.CreateDRGradeConfig(fbb, 108,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[108] = DRGradeConfig.CreateDRGradeConfig(fbb, 109,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[109] = DRGradeConfig.CreateDRGradeConfig(fbb, 110,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[110] = DRGradeConfig.CreateDRGradeConfig(fbb, 111,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[111] = DRGradeConfig.CreateDRGradeConfig(fbb, 112,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[112] = DRGradeConfig.CreateDRGradeConfig(fbb, 113,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[113] = DRGradeConfig.CreateDRGradeConfig(fbb, 114,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[114] = DRGradeConfig.CreateDRGradeConfig(fbb, 115,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[115] = DRGradeConfig.CreateDRGradeConfig(fbb, 116,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[116] = DRGradeConfig.CreateDRGradeConfig(fbb, 117,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[117] = DRGradeConfig.CreateDRGradeConfig(fbb, 118,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[118] = DRGradeConfig.CreateDRGradeConfig(fbb, 119,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[119] = DRGradeConfig.CreateDRGradeConfig(fbb, 120,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[120] = DRGradeConfig.CreateDRGradeConfig(fbb, 121,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[121] = DRGradeConfig.CreateDRGradeConfig(fbb, 122,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[122] = DRGradeConfig.CreateDRGradeConfig(fbb, 123,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[123] = DRGradeConfig.CreateDRGradeConfig(fbb, 124,fbb.CreateString("1"),1000,2000,5000,8000);
            offsets[124] = DRGradeConfig.CreateDRGradeConfig(fbb, 125,fbb.CreateString("1"),1000,2000,5000,8000);

            VectorOffset dataOff = Table_GradeConfig.CreateDataVector(fbb, offsets);
            var configOff = Table_GradeConfig.CreateTable_GradeConfig(fbb, dataOff);
            Table_GradeConfig.FinishTable_GradeConfigBuffer(fbb, configOff);
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