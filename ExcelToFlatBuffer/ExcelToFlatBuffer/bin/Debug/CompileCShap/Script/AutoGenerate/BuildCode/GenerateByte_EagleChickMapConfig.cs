using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_EagleChickMapConfig : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_EagleChickMapConfig.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DREagleChickMapConfig>[] offsets = new Offset<DREagleChickMapConfig>[10];
   
            offsets[0] = DREagleChickMapConfig.CreateDREagleChickMapConfig(fbb, 101,default(StringOffset),fbb.CreateString("3|2"),10,1,default(StringOffset));
            offsets[1] = DREagleChickMapConfig.CreateDREagleChickMapConfig(fbb, 102,default(StringOffset),fbb.CreateString("3|2"),10,1,default(StringOffset));
            offsets[2] = DREagleChickMapConfig.CreateDREagleChickMapConfig(fbb, 103,default(StringOffset),fbb.CreateString("3|2"),10,1,default(StringOffset));
            offsets[3] = DREagleChickMapConfig.CreateDREagleChickMapConfig(fbb, 104,default(StringOffset),fbb.CreateString("3|2"),10,2,default(StringOffset));
            offsets[4] = DREagleChickMapConfig.CreateDREagleChickMapConfig(fbb, 105,default(StringOffset),fbb.CreateString("3|2"),10,2,default(StringOffset));
            offsets[5] = DREagleChickMapConfig.CreateDREagleChickMapConfig(fbb, 106,default(StringOffset),fbb.CreateString("3|2"),10,2,default(StringOffset));
            offsets[6] = DREagleChickMapConfig.CreateDREagleChickMapConfig(fbb, 107,default(StringOffset),fbb.CreateString("3|2"),10,3,default(StringOffset));
            offsets[7] = DREagleChickMapConfig.CreateDREagleChickMapConfig(fbb, 108,default(StringOffset),fbb.CreateString("3|2"),10,3,default(StringOffset));
            offsets[8] = DREagleChickMapConfig.CreateDREagleChickMapConfig(fbb, 109,default(StringOffset),fbb.CreateString("3|2"),10,3,default(StringOffset));
            offsets[9] = DREagleChickMapConfig.CreateDREagleChickMapConfig(fbb, 110,default(StringOffset),fbb.CreateString("3|2"),10,1,default(StringOffset));

            VectorOffset dataOff = Table_EagleChickMapConfig.CreateDataVector(fbb, offsets);
            var configOff = Table_EagleChickMapConfig.CreateTable_EagleChickMapConfig(fbb, dataOff);
            Table_EagleChickMapConfig.FinishTable_EagleChickMapConfigBuffer(fbb, configOff);
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