using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_ShapeTypeItem : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_ShapeTypeItem.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRShapeTypeItem>[] offsets = new Offset<DRShapeTypeItem>[7];
   
            offsets[0] = DRShapeTypeItem.CreateDRShapeTypeItem(fbb, 0,fbb.CreateString("I"),fbb.CreateString("MagicBlockItem_I"));
            offsets[1] = DRShapeTypeItem.CreateDRShapeTypeItem(fbb, 1,fbb.CreateString("J"),fbb.CreateString("MagicBlockItem_J"));
            offsets[2] = DRShapeTypeItem.CreateDRShapeTypeItem(fbb, 2,fbb.CreateString("L"),fbb.CreateString("MagicBlockItem_L"));
            offsets[3] = DRShapeTypeItem.CreateDRShapeTypeItem(fbb, 3,fbb.CreateString("O"),fbb.CreateString("MagicBlockItem_O"));
            offsets[4] = DRShapeTypeItem.CreateDRShapeTypeItem(fbb, 4,fbb.CreateString("S"),fbb.CreateString("MagicBlockItem_S"));
            offsets[5] = DRShapeTypeItem.CreateDRShapeTypeItem(fbb, 5,fbb.CreateString("T"),fbb.CreateString("MagicBlockItem_T"));
            offsets[6] = DRShapeTypeItem.CreateDRShapeTypeItem(fbb, 6,fbb.CreateString("Z"),fbb.CreateString("MagicBlockItem_Z"));

            VectorOffset dataOff = Table_ShapeTypeItem.CreateDataVector(fbb, offsets);
            var configOff = Table_ShapeTypeItem.CreateTable_ShapeTypeItem(fbb, dataOff);
            Table_ShapeTypeItem.FinishTable_ShapeTypeItemBuffer(fbb, configOff);
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