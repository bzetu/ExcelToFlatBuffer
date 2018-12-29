using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_Worker : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Worker.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRWorker>[] offsets = new Offset<DRWorker>[5];
   
            offsets[0] = DRWorker.CreateDRWorker(fbb, 1,fbb.CreateString("工人1"),1,1000,5000,1,5,fbb.CreateString("搬运工"),59005);
            offsets[1] = DRWorker.CreateDRWorker(fbb, 2,fbb.CreateString("工人2"),2,2000,10000,2,5,fbb.CreateString("清洁工"),59006);
            offsets[2] = DRWorker.CreateDRWorker(fbb, 3,fbb.CreateString("工人3"),3,3000,15000,3,5,fbb.CreateString("维修工"),59007);
            offsets[3] = DRWorker.CreateDRWorker(fbb, 4,fbb.CreateString("工人4"),4,4000,20000,4,5,fbb.CreateString("研究员"),59008);
            offsets[4] = DRWorker.CreateDRWorker(fbb, 5,fbb.CreateString("工人5"),5,5000,25000,5,5,fbb.CreateString("产品经理"),59009);

            VectorOffset dataOff = Table_Worker.CreateDataVector(fbb, offsets);
            var configOff = Table_Worker.CreateTable_Worker(fbb, dataOff);
            Table_Worker.FinishTable_WorkerBuffer(fbb, configOff);
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