using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_Actor : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Actor.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRActor>[] offsets = new Offset<DRActor>[10];
   
            offsets[0] = DRActor.CreateDRActor(fbb, 1,fbb.CreateString("母鸡"),60036);
            offsets[1] = DRActor.CreateDRActor(fbb, 2,fbb.CreateString("小鹰"),60037);
            offsets[2] = DRActor.CreateDRActor(fbb, 3,fbb.CreateString("王子"),60052);
            offsets[3] = DRActor.CreateDRActor(fbb, 4,fbb.CreateString("睡美人"),60053);
            offsets[4] = DRActor.CreateDRActor(fbb, 5,fbb.CreateString("睡美人胜利"),60054);
            offsets[5] = DRActor.CreateDRActor(fbb, 6,fbb.CreateString("幽灵"),60056);
            offsets[6] = DRActor.CreateDRActor(fbb, 7,fbb.CreateString("玫瑰花出生点标志"),60055);
            offsets[7] = DRActor.CreateDRActor(fbb, 8,fbb.CreateString("鹰巢"),60040);
            offsets[8] = DRActor.CreateDRActor(fbb, 9,fbb.CreateString("道路"),60038);
            offsets[9] = DRActor.CreateDRActor(fbb, 10,fbb.CreateString("小鹰出生点"),60043);

            VectorOffset dataOff = Table_Actor.CreateDataVector(fbb, offsets);
            var configOff = Table_Actor.CreateTable_Actor(fbb, dataOff);
            Table_Actor.FinishTable_ActorBuffer(fbb, configOff);
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