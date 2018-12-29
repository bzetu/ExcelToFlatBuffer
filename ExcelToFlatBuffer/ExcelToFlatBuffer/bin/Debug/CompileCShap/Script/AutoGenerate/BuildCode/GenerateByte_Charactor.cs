using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_Charactor : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Charactor.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRCharactor>[] offsets = new Offset<DRCharactor>[4];
   
            offsets[0] = DRCharactor.CreateDRCharactor(fbb, 1,fbb.CreateString("白雪公主"),59001,34.6f,16.38f,73.7f);
            offsets[1] = DRCharactor.CreateDRCharactor(fbb, 2,fbb.CreateString("女主"),59002,35.66f,16.35f,74.676f);
            offsets[2] = DRCharactor.CreateDRCharactor(fbb, 3,fbb.CreateString("小红帽"),59003,35.69f,16.36f,73.7f);
            offsets[3] = DRCharactor.CreateDRCharactor(fbb, 4,fbb.CreateString("小矮人"),59004,36.934f,16.383f,73.548f);

            VectorOffset dataOff = Table_Charactor.CreateDataVector(fbb, offsets);
            var configOff = Table_Charactor.CreateTable_Charactor(fbb, dataOff);
            Table_Charactor.FinishTable_CharactorBuffer(fbb, configOff);
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