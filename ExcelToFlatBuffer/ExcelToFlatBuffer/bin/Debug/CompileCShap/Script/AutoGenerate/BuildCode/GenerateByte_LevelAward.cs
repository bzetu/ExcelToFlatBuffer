using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_LevelAward : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_LevelAward.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRLevelAward>[] offsets = new Offset<DRLevelAward>[125];
   
            offsets[0] = DRLevelAward.CreateDRLevelAward(fbb, 1,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { -1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 0,0,0 }),0,1000,50,0,60);
            offsets[1] = DRLevelAward.CreateDRLevelAward(fbb, 2,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { -1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 0,0,0 }),0,1000,50,1,0);
            offsets[2] = DRLevelAward.CreateDRLevelAward(fbb, 3,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,1000,50,0,0);
            offsets[3] = DRLevelAward.CreateDRLevelAward(fbb, 4,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,1000,50,0,0);
            offsets[4] = DRLevelAward.CreateDRLevelAward(fbb, 5,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),1,1000,50,0,0);
            offsets[5] = DRLevelAward.CreateDRLevelAward(fbb, 6,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),2,1000,50,0,0);
            offsets[6] = DRLevelAward.CreateDRLevelAward(fbb, 7,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),3,1000,50,0,0);
            offsets[7] = DRLevelAward.CreateDRLevelAward(fbb, 8,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),4,1000,50,0,0);
            offsets[8] = DRLevelAward.CreateDRLevelAward(fbb, 9,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),5,1000,50,0,0);
            offsets[9] = DRLevelAward.CreateDRLevelAward(fbb, 10,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),6,1000,50,0,0);
            offsets[10] = DRLevelAward.CreateDRLevelAward(fbb, 11,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,2000,100,0,0);
            offsets[11] = DRLevelAward.CreateDRLevelAward(fbb, 12,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,2000,100,0,0);
            offsets[12] = DRLevelAward.CreateDRLevelAward(fbb, 13,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,2000,100,0,0);
            offsets[13] = DRLevelAward.CreateDRLevelAward(fbb, 14,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,2000,100,0,0);
            offsets[14] = DRLevelAward.CreateDRLevelAward(fbb, 15,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,2000,100,0,0);
            offsets[15] = DRLevelAward.CreateDRLevelAward(fbb, 16,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,2000,100,0,0);
            offsets[16] = DRLevelAward.CreateDRLevelAward(fbb, 17,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,2000,100,0,0);
            offsets[17] = DRLevelAward.CreateDRLevelAward(fbb, 18,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,2000,100,0,0);
            offsets[18] = DRLevelAward.CreateDRLevelAward(fbb, 19,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,2000,100,0,0);
            offsets[19] = DRLevelAward.CreateDRLevelAward(fbb, 20,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,2000,100,0,0);
            offsets[20] = DRLevelAward.CreateDRLevelAward(fbb, 21,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,3000,150,0,0);
            offsets[21] = DRLevelAward.CreateDRLevelAward(fbb, 22,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,3000,150,0,0);
            offsets[22] = DRLevelAward.CreateDRLevelAward(fbb, 23,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,3000,150,0,0);
            offsets[23] = DRLevelAward.CreateDRLevelAward(fbb, 24,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,3000,150,0,0);
            offsets[24] = DRLevelAward.CreateDRLevelAward(fbb, 25,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,3000,150,0,0);
            offsets[25] = DRLevelAward.CreateDRLevelAward(fbb, 26,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,3000,150,0,0);
            offsets[26] = DRLevelAward.CreateDRLevelAward(fbb, 27,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,3000,150,0,0);
            offsets[27] = DRLevelAward.CreateDRLevelAward(fbb, 28,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,3000,150,0,0);
            offsets[28] = DRLevelAward.CreateDRLevelAward(fbb, 29,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,3000,150,0,0);
            offsets[29] = DRLevelAward.CreateDRLevelAward(fbb, 30,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,3000,150,0,0);
            offsets[30] = DRLevelAward.CreateDRLevelAward(fbb, 31,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[31] = DRLevelAward.CreateDRLevelAward(fbb, 32,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[32] = DRLevelAward.CreateDRLevelAward(fbb, 33,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[33] = DRLevelAward.CreateDRLevelAward(fbb, 34,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[34] = DRLevelAward.CreateDRLevelAward(fbb, 35,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[35] = DRLevelAward.CreateDRLevelAward(fbb, 36,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[36] = DRLevelAward.CreateDRLevelAward(fbb, 37,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[37] = DRLevelAward.CreateDRLevelAward(fbb, 38,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[38] = DRLevelAward.CreateDRLevelAward(fbb, 39,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[39] = DRLevelAward.CreateDRLevelAward(fbb, 40,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[40] = DRLevelAward.CreateDRLevelAward(fbb, 41,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[41] = DRLevelAward.CreateDRLevelAward(fbb, 42,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[42] = DRLevelAward.CreateDRLevelAward(fbb, 43,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[43] = DRLevelAward.CreateDRLevelAward(fbb, 44,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[44] = DRLevelAward.CreateDRLevelAward(fbb, 45,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[45] = DRLevelAward.CreateDRLevelAward(fbb, 46,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[46] = DRLevelAward.CreateDRLevelAward(fbb, 47,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[47] = DRLevelAward.CreateDRLevelAward(fbb, 48,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[48] = DRLevelAward.CreateDRLevelAward(fbb, 49,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[49] = DRLevelAward.CreateDRLevelAward(fbb, 50,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[50] = DRLevelAward.CreateDRLevelAward(fbb, 51,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[51] = DRLevelAward.CreateDRLevelAward(fbb, 52,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[52] = DRLevelAward.CreateDRLevelAward(fbb, 53,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[53] = DRLevelAward.CreateDRLevelAward(fbb, 54,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[54] = DRLevelAward.CreateDRLevelAward(fbb, 55,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[55] = DRLevelAward.CreateDRLevelAward(fbb, 56,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[56] = DRLevelAward.CreateDRLevelAward(fbb, 57,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[57] = DRLevelAward.CreateDRLevelAward(fbb, 58,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[58] = DRLevelAward.CreateDRLevelAward(fbb, 59,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[59] = DRLevelAward.CreateDRLevelAward(fbb, 60,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[60] = DRLevelAward.CreateDRLevelAward(fbb, 61,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[61] = DRLevelAward.CreateDRLevelAward(fbb, 62,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[62] = DRLevelAward.CreateDRLevelAward(fbb, 63,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[63] = DRLevelAward.CreateDRLevelAward(fbb, 64,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[64] = DRLevelAward.CreateDRLevelAward(fbb, 65,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[65] = DRLevelAward.CreateDRLevelAward(fbb, 66,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[66] = DRLevelAward.CreateDRLevelAward(fbb, 67,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[67] = DRLevelAward.CreateDRLevelAward(fbb, 68,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[68] = DRLevelAward.CreateDRLevelAward(fbb, 69,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[69] = DRLevelAward.CreateDRLevelAward(fbb, 70,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[70] = DRLevelAward.CreateDRLevelAward(fbb, 71,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[71] = DRLevelAward.CreateDRLevelAward(fbb, 72,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[72] = DRLevelAward.CreateDRLevelAward(fbb, 73,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[73] = DRLevelAward.CreateDRLevelAward(fbb, 74,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[74] = DRLevelAward.CreateDRLevelAward(fbb, 75,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[75] = DRLevelAward.CreateDRLevelAward(fbb, 76,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[76] = DRLevelAward.CreateDRLevelAward(fbb, 77,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[77] = DRLevelAward.CreateDRLevelAward(fbb, 78,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[78] = DRLevelAward.CreateDRLevelAward(fbb, 79,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[79] = DRLevelAward.CreateDRLevelAward(fbb, 80,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[80] = DRLevelAward.CreateDRLevelAward(fbb, 81,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[81] = DRLevelAward.CreateDRLevelAward(fbb, 82,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[82] = DRLevelAward.CreateDRLevelAward(fbb, 83,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[83] = DRLevelAward.CreateDRLevelAward(fbb, 84,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[84] = DRLevelAward.CreateDRLevelAward(fbb, 85,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[85] = DRLevelAward.CreateDRLevelAward(fbb, 86,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[86] = DRLevelAward.CreateDRLevelAward(fbb, 87,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[87] = DRLevelAward.CreateDRLevelAward(fbb, 88,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[88] = DRLevelAward.CreateDRLevelAward(fbb, 89,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[89] = DRLevelAward.CreateDRLevelAward(fbb, 90,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[90] = DRLevelAward.CreateDRLevelAward(fbb, 91,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[91] = DRLevelAward.CreateDRLevelAward(fbb, 92,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[92] = DRLevelAward.CreateDRLevelAward(fbb, 93,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[93] = DRLevelAward.CreateDRLevelAward(fbb, 94,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[94] = DRLevelAward.CreateDRLevelAward(fbb, 95,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[95] = DRLevelAward.CreateDRLevelAward(fbb, 96,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[96] = DRLevelAward.CreateDRLevelAward(fbb, 97,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[97] = DRLevelAward.CreateDRLevelAward(fbb, 98,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 2,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[98] = DRLevelAward.CreateDRLevelAward(fbb, 99,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 0,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[99] = DRLevelAward.CreateDRLevelAward(fbb, 100,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[100] = DRLevelAward.CreateDRLevelAward(fbb, 101,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[101] = DRLevelAward.CreateDRLevelAward(fbb, 102,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[102] = DRLevelAward.CreateDRLevelAward(fbb, 103,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[103] = DRLevelAward.CreateDRLevelAward(fbb, 104,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[104] = DRLevelAward.CreateDRLevelAward(fbb, 105,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[105] = DRLevelAward.CreateDRLevelAward(fbb, 106,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[106] = DRLevelAward.CreateDRLevelAward(fbb, 107,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[107] = DRLevelAward.CreateDRLevelAward(fbb, 108,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[108] = DRLevelAward.CreateDRLevelAward(fbb, 109,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[109] = DRLevelAward.CreateDRLevelAward(fbb, 110,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[110] = DRLevelAward.CreateDRLevelAward(fbb, 111,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[111] = DRLevelAward.CreateDRLevelAward(fbb, 112,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[112] = DRLevelAward.CreateDRLevelAward(fbb, 113,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[113] = DRLevelAward.CreateDRLevelAward(fbb, 114,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[114] = DRLevelAward.CreateDRLevelAward(fbb, 115,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[115] = DRLevelAward.CreateDRLevelAward(fbb, 116,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[116] = DRLevelAward.CreateDRLevelAward(fbb, 117,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[117] = DRLevelAward.CreateDRLevelAward(fbb, 118,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[118] = DRLevelAward.CreateDRLevelAward(fbb, 119,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[119] = DRLevelAward.CreateDRLevelAward(fbb, 120,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[120] = DRLevelAward.CreateDRLevelAward(fbb, 121,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[121] = DRLevelAward.CreateDRLevelAward(fbb, 122,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[122] = DRLevelAward.CreateDRLevelAward(fbb, 123,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[123] = DRLevelAward.CreateDRLevelAward(fbb, 124,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);
            offsets[124] = DRLevelAward.CreateDRLevelAward(fbb, 125,fbb.CreateString("1"),DRLevelAward.CreateItemIdVector(fbb, new int[] { 1,0,0 }),DRLevelAward.CreateCountVector(fbb, new int[] { 1,0,0 }),0,4000,200,0,0);

            VectorOffset dataOff = Table_LevelAward.CreateDataVector(fbb, offsets);
            var configOff = Table_LevelAward.CreateTable_LevelAward(fbb, dataOff);
            Table_LevelAward.FinishTable_LevelAwardBuffer(fbb, configOff);
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