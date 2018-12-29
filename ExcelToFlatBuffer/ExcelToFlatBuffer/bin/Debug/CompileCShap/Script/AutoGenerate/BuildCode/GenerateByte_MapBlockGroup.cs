using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_MapBlockGroup : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_MapBlockGroup.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRMapBlockGroup>[] offsets = new Offset<DRMapBlockGroup>[12];
   
            offsets[0] = DRMapBlockGroup.CreateDRMapBlockGroup(fbb, 1,fbb.CreateString("下落集合1"),fbb.CreateString("0"));
            offsets[1] = DRMapBlockGroup.CreateDRMapBlockGroup(fbb, 2,fbb.CreateString("下落集合2"),fbb.CreateString("1"));
            offsets[2] = DRMapBlockGroup.CreateDRMapBlockGroup(fbb, 3,fbb.CreateString("下落集合3"),fbb.CreateString("2"));
            offsets[3] = DRMapBlockGroup.CreateDRMapBlockGroup(fbb, 4,fbb.CreateString("下落集合4"),fbb.CreateString("3"));
            offsets[4] = DRMapBlockGroup.CreateDRMapBlockGroup(fbb, 5,fbb.CreateString("下落集合5"),fbb.CreateString("4"));
            offsets[5] = DRMapBlockGroup.CreateDRMapBlockGroup(fbb, 6,fbb.CreateString("下落集合6"),fbb.CreateString("5"));
            offsets[6] = DRMapBlockGroup.CreateDRMapBlockGroup(fbb, 7,fbb.CreateString("下落集合7"),fbb.CreateString("6"));
            offsets[7] = DRMapBlockGroup.CreateDRMapBlockGroup(fbb, 8,fbb.CreateString("下落集合8"),fbb.CreateString("7"));
            offsets[8] = DRMapBlockGroup.CreateDRMapBlockGroup(fbb, 9,fbb.CreateString("下落集合9"),fbb.CreateString("4|6"));
            offsets[9] = DRMapBlockGroup.CreateDRMapBlockGroup(fbb, 10,fbb.CreateString("下落集合10"),fbb.CreateString("1|2"));
            offsets[10] = DRMapBlockGroup.CreateDRMapBlockGroup(fbb, 11,fbb.CreateString("下落集合11"),fbb.CreateString("0|5"));
            offsets[11] = DRMapBlockGroup.CreateDRMapBlockGroup(fbb, 12,fbb.CreateString("下落集合12"),fbb.CreateString("0|0"));

            VectorOffset dataOff = Table_MapBlockGroup.CreateDataVector(fbb, offsets);
            var configOff = Table_MapBlockGroup.CreateTable_MapBlockGroup(fbb, dataOff);
            Table_MapBlockGroup.FinishTable_MapBlockGroupBuffer(fbb, configOff);
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