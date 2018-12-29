using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_ElementScore : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_ElementScore.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRElementScore>[] offsets = new Offset<DRElementScore>[42];
   
            offsets[0] = DRElementScore.CreateDRElementScore(fbb, 1,fbb.CreateString("1"),100);
            offsets[1] = DRElementScore.CreateDRElementScore(fbb, 2,fbb.CreateString("1"),100);
            offsets[2] = DRElementScore.CreateDRElementScore(fbb, 3,fbb.CreateString("1"),100);
            offsets[3] = DRElementScore.CreateDRElementScore(fbb, 4,fbb.CreateString("1"),100);
            offsets[4] = DRElementScore.CreateDRElementScore(fbb, 5,fbb.CreateString("1"),100);
            offsets[5] = DRElementScore.CreateDRElementScore(fbb, 6,fbb.CreateString("1"),100);
            offsets[6] = DRElementScore.CreateDRElementScore(fbb, 7,fbb.CreateString("1"),100);
            offsets[7] = DRElementScore.CreateDRElementScore(fbb, 8,fbb.CreateString("1"),100);
            offsets[8] = DRElementScore.CreateDRElementScore(fbb, 9,fbb.CreateString("1"),100);
            offsets[9] = DRElementScore.CreateDRElementScore(fbb, 10,fbb.CreateString("1"),100);
            offsets[10] = DRElementScore.CreateDRElementScore(fbb, 11,fbb.CreateString("1"),100);
            offsets[11] = DRElementScore.CreateDRElementScore(fbb, 12,fbb.CreateString("1"),100);
            offsets[12] = DRElementScore.CreateDRElementScore(fbb, 13,fbb.CreateString("1"),100);
            offsets[13] = DRElementScore.CreateDRElementScore(fbb, 14,fbb.CreateString("1"),100);
            offsets[14] = DRElementScore.CreateDRElementScore(fbb, 15,fbb.CreateString("1"),100);
            offsets[15] = DRElementScore.CreateDRElementScore(fbb, 16,fbb.CreateString("1"),100);
            offsets[16] = DRElementScore.CreateDRElementScore(fbb, 17,fbb.CreateString("1"),100);
            offsets[17] = DRElementScore.CreateDRElementScore(fbb, 18,fbb.CreateString("1"),100);
            offsets[18] = DRElementScore.CreateDRElementScore(fbb, 19,fbb.CreateString("1"),100);
            offsets[19] = DRElementScore.CreateDRElementScore(fbb, 20,fbb.CreateString("1"),100);
            offsets[20] = DRElementScore.CreateDRElementScore(fbb, 21,fbb.CreateString("1"),100);
            offsets[21] = DRElementScore.CreateDRElementScore(fbb, 22,fbb.CreateString("1"),100);
            offsets[22] = DRElementScore.CreateDRElementScore(fbb, 23,fbb.CreateString("1"),100);
            offsets[23] = DRElementScore.CreateDRElementScore(fbb, 24,fbb.CreateString("1"),100);
            offsets[24] = DRElementScore.CreateDRElementScore(fbb, 25,fbb.CreateString("1"),100);
            offsets[25] = DRElementScore.CreateDRElementScore(fbb, 26,fbb.CreateString("1"),100);
            offsets[26] = DRElementScore.CreateDRElementScore(fbb, 27,fbb.CreateString("1"),100);
            offsets[27] = DRElementScore.CreateDRElementScore(fbb, 28,fbb.CreateString("1"),100);
            offsets[28] = DRElementScore.CreateDRElementScore(fbb, 29,fbb.CreateString("1"),100);
            offsets[29] = DRElementScore.CreateDRElementScore(fbb, 30,fbb.CreateString("1"),100);
            offsets[30] = DRElementScore.CreateDRElementScore(fbb, 31,fbb.CreateString("1"),100);
            offsets[31] = DRElementScore.CreateDRElementScore(fbb, 32,fbb.CreateString("1"),100);
            offsets[32] = DRElementScore.CreateDRElementScore(fbb, 33,fbb.CreateString("1"),100);
            offsets[33] = DRElementScore.CreateDRElementScore(fbb, 34,fbb.CreateString("1"),100);
            offsets[34] = DRElementScore.CreateDRElementScore(fbb, 35,fbb.CreateString("1"),100);
            offsets[35] = DRElementScore.CreateDRElementScore(fbb, 36,fbb.CreateString("1"),100);
            offsets[36] = DRElementScore.CreateDRElementScore(fbb, 37,fbb.CreateString("1"),100);
            offsets[37] = DRElementScore.CreateDRElementScore(fbb, 38,fbb.CreateString("1"),100);
            offsets[38] = DRElementScore.CreateDRElementScore(fbb, 39,fbb.CreateString("1"),100);
            offsets[39] = DRElementScore.CreateDRElementScore(fbb, 40,fbb.CreateString("1"),100);
            offsets[40] = DRElementScore.CreateDRElementScore(fbb, 41,fbb.CreateString("1"),100);
            offsets[41] = DRElementScore.CreateDRElementScore(fbb, 42,fbb.CreateString("1"),100);

            VectorOffset dataOff = Table_ElementScore.CreateDataVector(fbb, offsets);
            var configOff = Table_ElementScore.CreateTable_ElementScore(fbb, dataOff);
            Table_ElementScore.FinishTable_ElementScoreBuffer(fbb, configOff);
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