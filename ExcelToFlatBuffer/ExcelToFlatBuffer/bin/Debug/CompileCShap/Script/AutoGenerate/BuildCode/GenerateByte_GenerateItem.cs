using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_GenerateItem : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_GenerateItem.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRGenerateItem>[] offsets = new Offset<DRGenerateItem>[1];
   
            offsets[0] = DRGenerateItem.CreateDRGenerateItem(fbb, 1,fbb.CreateString("1"),1);

            VectorOffset dataOff = Table_GenerateItem.CreateDataVector(fbb, offsets);
            var configOff = Table_GenerateItem.CreateTable_GenerateItem(fbb, dataOff);
            Table_GenerateItem.FinishTable_GenerateItemBuffer(fbb, configOff);
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