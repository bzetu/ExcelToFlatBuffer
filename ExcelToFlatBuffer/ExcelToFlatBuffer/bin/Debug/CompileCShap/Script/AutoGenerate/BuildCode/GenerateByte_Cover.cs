using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_Cover : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Cover.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRCover>[] offsets = new Offset<DRCover>[1];
   
            offsets[0] = DRCover.CreateDRCover(fbb, 1,fbb.CreateString("冰块"),60057,DRCover.CreateIconIdVector(fbb, new int[] { 10035,10036,10037 }),DRCover.CreateShadowIconIdVector(fbb, new int[] { 10035,10036,10037 }),DRCover.CreatePreviewIconIdVector(fbb, new int[] { 10035,10036,10037 }),10053,78,79,fbb.CreateString("IceCover"),fbb.CreateString("IceFinder"),false,true,false,false,false,false,false,3);

            VectorOffset dataOff = Table_Cover.CreateDataVector(fbb, offsets);
            var configOff = Table_Cover.CreateTable_Cover(fbb, dataOff);
            Table_Cover.FinishTable_CoverBuffer(fbb, configOff);
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