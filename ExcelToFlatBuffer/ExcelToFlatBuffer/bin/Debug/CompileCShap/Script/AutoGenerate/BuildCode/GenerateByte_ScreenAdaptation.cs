using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_ScreenAdaptation : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_ScreenAdaptation.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRScreenAdaptation>[] offsets = new Offset<DRScreenAdaptation>[4];
   
            offsets[0] = DRScreenAdaptation.CreateDRScreenAdaptation(fbb, 1,fbb.CreateString("苹果X"),fbb.CreateString("iPhone10"),fbb.CreateString("6"),true);
            offsets[1] = DRScreenAdaptation.CreateDRScreenAdaptation(fbb, 2,fbb.CreateString("苹果X"),fbb.CreateString("iPhone10"),fbb.CreateString("3"),true);
            offsets[2] = DRScreenAdaptation.CreateDRScreenAdaptation(fbb, 3,fbb.CreateString("华为P20"),fbb.CreateString("CLT_AL00"),fbb.CreateString("0"),true);
            offsets[3] = DRScreenAdaptation.CreateDRScreenAdaptation(fbb, 4,fbb.CreateString("华为P20"),fbb.CreateString("CLT"),fbb.CreateString("AL00"),true);

            VectorOffset dataOff = Table_ScreenAdaptation.CreateDataVector(fbb, offsets);
            var configOff = Table_ScreenAdaptation.CreateTable_ScreenAdaptation(fbb, dataOff);
            Table_ScreenAdaptation.FinishTable_ScreenAdaptationBuffer(fbb, configOff);
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