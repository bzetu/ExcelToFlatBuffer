using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_LevelScroll : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_LevelScroll.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRLevelScroll>[] offsets = new Offset<DRLevelScroll>[33];
   
            offsets[0] = DRLevelScroll.CreateDRLevelScroll(fbb, 1,fbb.CreateString("1——1"),fbb.CreateString("1--1"),fbb.CreateString("1"));
            offsets[1] = DRLevelScroll.CreateDRLevelScroll(fbb, 2,fbb.CreateString("2——1"),fbb.CreateString("2--1"),fbb.CreateString("1"));
            offsets[2] = DRLevelScroll.CreateDRLevelScroll(fbb, 3,fbb.CreateString("2——2"),fbb.CreateString("2--2"),fbb.CreateString("1"));
            offsets[3] = DRLevelScroll.CreateDRLevelScroll(fbb, 4,fbb.CreateString("2——3"),fbb.CreateString("2--3"),fbb.CreateString("1"));
            offsets[4] = DRLevelScroll.CreateDRLevelScroll(fbb, 5,fbb.CreateString("3——1"),fbb.CreateString("3--1"),fbb.CreateString("17"));
            offsets[5] = DRLevelScroll.CreateDRLevelScroll(fbb, 6,fbb.CreateString("3——2"),fbb.CreateString("3--2"),fbb.CreateString("17"));
            offsets[6] = DRLevelScroll.CreateDRLevelScroll(fbb, 8,fbb.CreateString("4——1"),fbb.CreateString("4--1"),fbb.CreateString("5"));
            offsets[7] = DRLevelScroll.CreateDRLevelScroll(fbb, 9,fbb.CreateString("5——1"),fbb.CreateString("5--1"),fbb.CreateString("1"));
            offsets[8] = DRLevelScroll.CreateDRLevelScroll(fbb, 10,fbb.CreateString("7——1"),fbb.CreateString("7--1"),fbb.CreateString("1"));
            offsets[9] = DRLevelScroll.CreateDRLevelScroll(fbb, 11,fbb.CreateString("8——1"),fbb.CreateString("8--1"),fbb.CreateString("1"));
            offsets[10] = DRLevelScroll.CreateDRLevelScroll(fbb, 12,fbb.CreateString("12——1"),fbb.CreateString("12--1"),fbb.CreateString("10"));
            offsets[11] = DRLevelScroll.CreateDRLevelScroll(fbb, 13,fbb.CreateString("13--1"),fbb.CreateString("13--1"),fbb.CreateString("19"));
            offsets[12] = DRLevelScroll.CreateDRLevelScroll(fbb, 16,fbb.CreateString("16--1"),fbb.CreateString("16--1"),fbb.CreateString("19"));
            offsets[13] = DRLevelScroll.CreateDRLevelScroll(fbb, 341,fbb.CreateString("34——1"),fbb.CreateString("34--1"),fbb.CreateString("14"));
            offsets[14] = DRLevelScroll.CreateDRLevelScroll(fbb, 351,fbb.CreateString("35——1"),fbb.CreateString("35--1"),fbb.CreateString("14"));
            offsets[15] = DRLevelScroll.CreateDRLevelScroll(fbb, 511,fbb.CreateString("51——1"),fbb.CreateString("51--1"),fbb.CreateString("3"));
            offsets[16] = DRLevelScroll.CreateDRLevelScroll(fbb, 512,fbb.CreateString("51——2"),fbb.CreateString("51--2"),fbb.CreateString("3"));
            offsets[17] = DRLevelScroll.CreateDRLevelScroll(fbb, 521,fbb.CreateString("52——1"),fbb.CreateString("52--1"),fbb.CreateString("3"));
            offsets[18] = DRLevelScroll.CreateDRLevelScroll(fbb, 531,fbb.CreateString("53——1"),fbb.CreateString("53--1"),fbb.CreateString("1"));
            offsets[19] = DRLevelScroll.CreateDRLevelScroll(fbb, 541,fbb.CreateString("54——1"),fbb.CreateString("54--1"),fbb.CreateString("1"));
            offsets[20] = DRLevelScroll.CreateDRLevelScroll(fbb, 561,fbb.CreateString("56——1"),fbb.CreateString("56--1"),fbb.CreateString("9"));
            offsets[21] = DRLevelScroll.CreateDRLevelScroll(fbb, 571,fbb.CreateString("57——1"),fbb.CreateString("57--1"),fbb.CreateString("3"));
            offsets[22] = DRLevelScroll.CreateDRLevelScroll(fbb, 591,fbb.CreateString("59——1"),fbb.CreateString("59--1"),fbb.CreateString("3"));
            offsets[23] = DRLevelScroll.CreateDRLevelScroll(fbb, 601,fbb.CreateString("60——1"),fbb.CreateString("60--1"),fbb.CreateString("15"));
            offsets[24] = DRLevelScroll.CreateDRLevelScroll(fbb, 611,fbb.CreateString("61——1"),fbb.CreateString("61--1"),fbb.CreateString("1"));
            offsets[25] = DRLevelScroll.CreateDRLevelScroll(fbb, 621,fbb.CreateString("62——1"),fbb.CreateString("62--1"),fbb.CreateString("1"));
            offsets[26] = DRLevelScroll.CreateDRLevelScroll(fbb, 661,fbb.CreateString("66——1"),fbb.CreateString("66--1"),fbb.CreateString("14"));
            offsets[27] = DRLevelScroll.CreateDRLevelScroll(fbb, 671,fbb.CreateString("67——1"),fbb.CreateString("67--1"),fbb.CreateString("3"));
            offsets[28] = DRLevelScroll.CreateDRLevelScroll(fbb, 701,fbb.CreateString("70——1"),fbb.CreateString("70--1"),fbb.CreateString("16"));
            offsets[29] = DRLevelScroll.CreateDRLevelScroll(fbb, 711,fbb.CreateString("71——1"),fbb.CreateString("71--1"),fbb.CreateString("1"));
            offsets[30] = DRLevelScroll.CreateDRLevelScroll(fbb, 1072,fbb.CreateString("107——1"),fbb.CreateString("107--1"),fbb.CreateString("1"));
            offsets[31] = DRLevelScroll.CreateDRLevelScroll(fbb, 1082,fbb.CreateString("108——1"),fbb.CreateString("108--1"),fbb.CreateString("9"));
            offsets[32] = DRLevelScroll.CreateDRLevelScroll(fbb, 401,fbb.CreateString("401——1"),fbb.CreateString("40--1"),fbb.CreateString("16&18"));

            VectorOffset dataOff = Table_LevelScroll.CreateDataVector(fbb, offsets);
            var configOff = Table_LevelScroll.CreateTable_LevelScroll(fbb, dataOff);
            Table_LevelScroll.FinishTable_LevelScrollBuffer(fbb, configOff);
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