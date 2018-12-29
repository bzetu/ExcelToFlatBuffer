using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_MultipleDispleScoreRatio : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_MultipleDispleScoreRatio.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRMultipleDispleScoreRatio>[] offsets = new Offset<DRMultipleDispleScoreRatio>[24];
   
            offsets[0] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 1,fbb.CreateString("1"),1f);
            offsets[1] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 2,fbb.CreateString("1"),1f);
            offsets[2] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 3,fbb.CreateString("1"),1f);
            offsets[3] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 4,fbb.CreateString("1"),1f);
            offsets[4] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 5,fbb.CreateString("1"),1f);
            offsets[5] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 6,fbb.CreateString("1"),1f);
            offsets[6] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 7,fbb.CreateString("1"),1f);
            offsets[7] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 8,fbb.CreateString("1"),1f);
            offsets[8] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 9,fbb.CreateString("1"),1f);
            offsets[9] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 10,fbb.CreateString("1"),1f);
            offsets[10] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 11,fbb.CreateString("1"),1f);
            offsets[11] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 12,fbb.CreateString("1"),1f);
            offsets[12] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 13,fbb.CreateString("1"),1f);
            offsets[13] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 14,fbb.CreateString("1"),1f);
            offsets[14] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 15,fbb.CreateString("1"),1f);
            offsets[15] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 16,fbb.CreateString("1"),1f);
            offsets[16] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 17,fbb.CreateString("1"),1f);
            offsets[17] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 18,fbb.CreateString("1"),1f);
            offsets[18] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 19,fbb.CreateString("1"),1f);
            offsets[19] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 20,fbb.CreateString("1"),1f);
            offsets[20] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 21,fbb.CreateString("1"),1f);
            offsets[21] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 22,fbb.CreateString("1"),1f);
            offsets[22] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 23,fbb.CreateString("1"),1f);
            offsets[23] = DRMultipleDispleScoreRatio.CreateDRMultipleDispleScoreRatio(fbb, 24,fbb.CreateString("1"),1f);

            VectorOffset dataOff = Table_MultipleDispleScoreRatio.CreateDataVector(fbb, offsets);
            var configOff = Table_MultipleDispleScoreRatio.CreateTable_MultipleDispleScoreRatio(fbb, dataOff);
            Table_MultipleDispleScoreRatio.FinishTable_MultipleDispleScoreRatioBuffer(fbb, configOff);
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