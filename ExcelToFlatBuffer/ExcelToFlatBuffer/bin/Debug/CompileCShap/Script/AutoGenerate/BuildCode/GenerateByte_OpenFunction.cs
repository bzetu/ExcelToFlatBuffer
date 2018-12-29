using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_OpenFunction : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_OpenFunction.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DROpenFunction>[] offsets = new Offset<DROpenFunction>[2];
   
            offsets[0] = DROpenFunction.CreateDROpenFunction(fbb, 1,fbb.CreateString("功能开启"),fbb.CreateString("Icons/Item_Gold_finger"),fbb.CreateString("建筑"),0,1,5f,0);
            offsets[1] = DROpenFunction.CreateDROpenFunction(fbb, 2,fbb.CreateString("功能开启"),fbb.CreateString("Icons/Item_Gold_finger"),fbb.CreateString("打造"),0,2,5f,1);

            VectorOffset dataOff = Table_OpenFunction.CreateDataVector(fbb, offsets);
            var configOff = Table_OpenFunction.CreateTable_OpenFunction(fbb, dataOff);
            Table_OpenFunction.FinishTable_OpenFunctionBuffer(fbb, configOff);
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