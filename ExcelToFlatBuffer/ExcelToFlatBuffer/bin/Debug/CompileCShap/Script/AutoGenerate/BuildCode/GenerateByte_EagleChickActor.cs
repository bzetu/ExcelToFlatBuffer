using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_EagleChickActor : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_EagleChickActor.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DREagleChickActor>[] offsets = new Offset<DREagleChickActor>[16];
   
            offsets[0] = DREagleChickActor.CreateDREagleChickActor(fbb, 1,fbb.CreateString("第1行"),DREagleChickActor.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[1] = DREagleChickActor.CreateDREagleChickActor(fbb, 2,fbb.CreateString("第2行"),DREagleChickActor.CreateColumnVector(fbb, new int[] { 0,0,1,0,0,0,0,0,0 }));
            offsets[2] = DREagleChickActor.CreateDREagleChickActor(fbb, 3,fbb.CreateString("第3行"),DREagleChickActor.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[3] = DREagleChickActor.CreateDREagleChickActor(fbb, 4,fbb.CreateString("第4行"),DREagleChickActor.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[4] = DREagleChickActor.CreateDREagleChickActor(fbb, 5,fbb.CreateString("第5行"),DREagleChickActor.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[5] = DREagleChickActor.CreateDREagleChickActor(fbb, 6,fbb.CreateString("第6行"),DREagleChickActor.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[6] = DREagleChickActor.CreateDREagleChickActor(fbb, 7,fbb.CreateString("第7行"),DREagleChickActor.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[7] = DREagleChickActor.CreateDREagleChickActor(fbb, 8,fbb.CreateString("第8行"),DREagleChickActor.CreateColumnVector(fbb, new int[] { 0,0,0,0,1,0,0,0,0 }));
            offsets[8] = DREagleChickActor.CreateDREagleChickActor(fbb, 9,fbb.CreateString("第9行"),DREagleChickActor.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[9] = DREagleChickActor.CreateDREagleChickActor(fbb, 10,fbb.CreateString("第10行"),DREagleChickActor.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[10] = DREagleChickActor.CreateDREagleChickActor(fbb, 11,fbb.CreateString("第11行"),DREagleChickActor.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[11] = DREagleChickActor.CreateDREagleChickActor(fbb, 12,fbb.CreateString("第12行"),DREagleChickActor.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[12] = DREagleChickActor.CreateDREagleChickActor(fbb, 13,fbb.CreateString("第13行"),DREagleChickActor.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[13] = DREagleChickActor.CreateDREagleChickActor(fbb, 14,fbb.CreateString("第14行"),DREagleChickActor.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[14] = DREagleChickActor.CreateDREagleChickActor(fbb, 15,fbb.CreateString("第15行"),DREagleChickActor.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[15] = DREagleChickActor.CreateDREagleChickActor(fbb, 16,fbb.CreateString("第16行"),DREagleChickActor.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));

            VectorOffset dataOff = Table_EagleChickActor.CreateDataVector(fbb, offsets);
            var configOff = Table_EagleChickActor.CreateTable_EagleChickActor(fbb, dataOff);
            Table_EagleChickActor.FinishTable_EagleChickActorBuffer(fbb, configOff);
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