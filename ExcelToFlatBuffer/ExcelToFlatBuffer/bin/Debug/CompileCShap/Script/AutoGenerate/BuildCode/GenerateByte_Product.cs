using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_Product : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Product.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRProduct>[] offsets = new Offset<DRProduct>[3];
   
            offsets[0] = DRProduct.CreateDRProduct(fbb, 1,fbb.CreateString("飞机"),13010);
            offsets[1] = DRProduct.CreateDRProduct(fbb, 2,fbb.CreateString("泡泡糖"),13011);
            offsets[2] = DRProduct.CreateDRProduct(fbb, 3,fbb.CreateString("魔方"),13012);

            VectorOffset dataOff = Table_Product.CreateDataVector(fbb, offsets);
            var configOff = Table_Product.CreateTable_Product(fbb, dataOff);
            Table_Product.FinishTable_ProductBuffer(fbb, configOff);
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