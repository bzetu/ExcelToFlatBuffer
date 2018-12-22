using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameTable;

namespace CompileCShap
{
    public class GenerateByte_Effect : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Effect.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DREffect>[] offsets = new Offset<DREffect>[10];
   
            offsets[0] = DREffect.CreateDREffect(fbb, 1,fbb.CreateString("一行消除特效"),40001,fbb.CreateString("Effect"),600,0,300,1500,40021,0);
            offsets[1] = DREffect.CreateDREffect(fbb, 2,fbb.CreateString("竖消特效"),40002,fbb.CreateString("Effect"),2000,0,-1,2100,40016,0);
            offsets[2] = DREffect.CreateDREffect(fbb, 3,fbb.CreateString("横消火箭"),40003,fbb.CreateString("Effect"),500,0,-1,2200,40016,0);
            offsets[3] = DREffect.CreateDREffect(fbb, 4,fbb.CreateString("竖消火箭"),40004,fbb.CreateString("Effect"),500,0,-1,2200,40016,0);
            offsets[4] = DREffect.CreateDREffect(fbb, 5,fbb.CreateString("木箱销毁特效"),40005,fbb.CreateString("Effect"),5000,0,-1,5200,-1,0);
            offsets[5] = DREffect.CreateDREffect(fbb, 6,fbb.CreateString("收集铃铛拖尾"),40006,fbb.CreateString("Effect"),-1,0,-1,-1,70001,0);
            offsets[6] = DREffect.CreateDREffect(fbb, 7,fbb.CreateString("泡泡糖出生特效"),40007,fbb.CreateString("BubbleGumEffect"),1200,1200,1000,1200,40019,0);

            VectorOffset dataOff = Table_Effect.CreateDataVector(fbb, offsets);
            var configOff = Table_Effect.CreateTable_Effect(fbb, dataOff);
            Table_Effect.FinishTable_EffectBuffer(fbb, configOff);
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