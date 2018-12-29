using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_GhostGenerate : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_GhostGenerate.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRGhostGenerate>[] offsets = new Offset<DRGhostGenerate>[8];
   
            offsets[0] = DRGhostGenerate.CreateDRGhostGenerate(fbb, 1,fbb.CreateString("type1"),fbb.CreateString("2|2|2|2|2|2|2"));
            offsets[1] = DRGhostGenerate.CreateDRGhostGenerate(fbb, 2,fbb.CreateString("type4"),fbb.CreateString("0|0|0|0|12|0|0"));
            offsets[2] = DRGhostGenerate.CreateDRGhostGenerate(fbb, 3,fbb.CreateString("type7"),fbb.CreateString("0|0|0|0|0|0|10"));
            offsets[3] = DRGhostGenerate.CreateDRGhostGenerate(fbb, 4,fbb.CreateString("type10"),fbb.CreateString("10|0|0|0|0|0|0"));
            offsets[4] = DRGhostGenerate.CreateDRGhostGenerate(fbb, 5,fbb.CreateString("type13"),fbb.CreateString("0|2|0|0|0|3|0"));
            offsets[5] = DRGhostGenerate.CreateDRGhostGenerate(fbb, 95,fbb.CreateString("95"),fbb.CreateString("1|0|0|1|0|0|0"));
            offsets[6] = DRGhostGenerate.CreateDRGhostGenerate(fbb, 100120,fbb.CreateString("12关，只产生紫色幽灵"),fbb.CreateString("0|0|0|0|0|3|0"));
            offsets[7] = DRGhostGenerate.CreateDRGhostGenerate(fbb, 100150,fbb.CreateString("15关，先产红色，再产绿色"),fbb.CreateString("0|0|0|0|999|0|1"));

            VectorOffset dataOff = Table_GhostGenerate.CreateDataVector(fbb, offsets);
            var configOff = Table_GhostGenerate.CreateTable_GhostGenerate(fbb, dataOff);
            Table_GhostGenerate.FinishTable_GhostGenerateBuffer(fbb, configOff);
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