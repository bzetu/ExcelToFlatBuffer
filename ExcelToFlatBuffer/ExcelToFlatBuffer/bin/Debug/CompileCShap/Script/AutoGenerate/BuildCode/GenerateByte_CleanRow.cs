using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_CleanRow : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_CleanRow.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRCleanRow>[] offsets = new Offset<DRCleanRow>[4];
   
            offsets[0] = DRCleanRow.CreateDRCleanRow(fbb, 1,fbb.CreateString("消除1行"),0,1,-1);
            offsets[1] = DRCleanRow.CreateDRCleanRow(fbb, 2,fbb.CreateString("消除2行飞机"),1,20,-1);
            offsets[2] = DRCleanRow.CreateDRCleanRow(fbb, 3,fbb.CreateString("消除3行魔法棒"),2,7,22);
            offsets[3] = DRCleanRow.CreateDRCleanRow(fbb, 4,fbb.CreateString("消除4行扭蛋"),3,21,-1);

            VectorOffset dataOff = Table_CleanRow.CreateDataVector(fbb, offsets);
            var configOff = Table_CleanRow.CreateTable_CleanRow(fbb, dataOff);
            Table_CleanRow.FinishTable_CleanRowBuffer(fbb, configOff);
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