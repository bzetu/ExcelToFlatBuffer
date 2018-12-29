using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_GuideModeGroup : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_GuideModeGroup.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRGuideModeGroup>[] offsets = new Offset<DRGuideModeGroup>[5];
   
            offsets[0] = DRGuideModeGroup.CreateDRGuideModeGroup(fbb, 1,fbb.CreateString("第1组"),0,1,1,1);
            offsets[1] = DRGuideModeGroup.CreateDRGuideModeGroup(fbb, 2,fbb.CreateString("第2组"),0,2,1,2);
            offsets[2] = DRGuideModeGroup.CreateDRGuideModeGroup(fbb, 3,fbb.CreateString("第3组"),0,3,1,3);
            offsets[3] = DRGuideModeGroup.CreateDRGuideModeGroup(fbb, 4,fbb.CreateString("第4组"),0,4,1,4);
            offsets[4] = DRGuideModeGroup.CreateDRGuideModeGroup(fbb, 5,fbb.CreateString("第5组"),0,8,1,8);

            VectorOffset dataOff = Table_GuideModeGroup.CreateDataVector(fbb, offsets);
            var configOff = Table_GuideModeGroup.CreateTable_GuideModeGroup(fbb, dataOff);
            Table_GuideModeGroup.FinishTable_GuideModeGroupBuffer(fbb, configOff);
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