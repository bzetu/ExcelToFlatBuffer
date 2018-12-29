using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_AI : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_AI.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRAI>[] offsets = new Offset<DRAI>[1];
   
            offsets[0] = DRAI.CreateDRAI(fbb, 1,fbb.CreateString("element"),0,1,20);

            VectorOffset dataOff = Table_AI.CreateDataVector(fbb, offsets);
            var configOff = Table_AI.CreateTable_AI(fbb, dataOff);
            Table_AI.FinishTable_AIBuffer(fbb, configOff);
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