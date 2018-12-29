using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_MagicBlockPosition : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_MagicBlockPosition.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRMagicBlockPosition>[] offsets = new Offset<DRMagicBlockPosition>[7];
   
            offsets[0] = DRMagicBlockPosition.CreateDRMagicBlockPosition(fbb, 0,fbb.CreateString("中间"),0f,0f);
            offsets[1] = DRMagicBlockPosition.CreateDRMagicBlockPosition(fbb, 1,fbb.CreateString("左1"),-245f,290f);
            offsets[2] = DRMagicBlockPosition.CreateDRMagicBlockPosition(fbb, 2,fbb.CreateString("左2"),-245f,0f);
            offsets[3] = DRMagicBlockPosition.CreateDRMagicBlockPosition(fbb, 3,fbb.CreateString("左3"),-245f,-290f);
            offsets[4] = DRMagicBlockPosition.CreateDRMagicBlockPosition(fbb, 4,fbb.CreateString("右1"),245f,290f);
            offsets[5] = DRMagicBlockPosition.CreateDRMagicBlockPosition(fbb, 5,fbb.CreateString("右2"),245f,0f);
            offsets[6] = DRMagicBlockPosition.CreateDRMagicBlockPosition(fbb, 6,fbb.CreateString("右3"),245f,-290f);

            VectorOffset dataOff = Table_MagicBlockPosition.CreateDataVector(fbb, offsets);
            var configOff = Table_MagicBlockPosition.CreateTable_MagicBlockPosition(fbb, dataOff);
            Table_MagicBlockPosition.FinishTable_MagicBlockPositionBuffer(fbb, configOff);
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