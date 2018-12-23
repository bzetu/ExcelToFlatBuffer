using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_Effectt : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "D:/ProgramCode/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Effectt.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DREffectt>[] offsets = new Offset<DREffectt>[10];
   
            offsets[0] = DREffectt.CreateDREffectt(fbb, 1,fbb.CreateString("一行消除特效"),40001,fbb.CreateString("Effect"),600,0,300,1500,40021,0);
            offsets[1] = DREffectt.CreateDREffectt(fbb, 2,fbb.CreateString("竖消特效"),40002,fbb.CreateString("Effect"),2000,0,-1,2100,40016,0);
            offsets[2] = DREffectt.CreateDREffectt(fbb, 3,fbb.CreateString("横消火箭"),40003,fbb.CreateString("Effect"),500,0,-1,2200,40016,0);
            offsets[3] = DREffectt.CreateDREffectt(fbb, 4,fbb.CreateString("竖消火箭"),40004,fbb.CreateString("Effect"),500,0,-1,2200,40016,0);
            offsets[4] = DREffectt.CreateDREffectt(fbb, 5,fbb.CreateString("木箱销毁特效"),40005,fbb.CreateString("Effect"),5000,0,-1,5200,-1,0);
            offsets[5] = DREffectt.CreateDREffectt(fbb, 6,fbb.CreateString("收集铃铛拖尾"),40006,fbb.CreateString("Effect"),-1,0,-1,-1,70001,0);
            offsets[6] = DREffectt.CreateDREffectt(fbb, 7,fbb.CreateString("泡泡糖出生特效"),40007,fbb.CreateString("BubbleGumEffect"),1200,1200,1000,1200,40019,0);

            VectorOffset dataOff = Table_Effectt.CreateDataVector(fbb, offsets);
            var configOff = Table_Effectt.CreateTable_Effectt(fbb, dataOff);
            Table_Effectt.FinishTable_EffecttBuffer(fbb, configOff);
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