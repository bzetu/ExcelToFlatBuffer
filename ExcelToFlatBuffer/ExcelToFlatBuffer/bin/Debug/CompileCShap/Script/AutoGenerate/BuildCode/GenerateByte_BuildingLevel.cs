using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_BuildingLevel : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_BuildingLevel.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRBuildingLevel>[] offsets = new Offset<DRBuildingLevel>[5];
   
            offsets[0] = DRBuildingLevel.CreateDRBuildingLevel(fbb, 1,fbb.CreateString("世界树"),7,1,1000,0.1f,1,fbb.CreateString("#{Building_1}"));
            offsets[1] = DRBuildingLevel.CreateDRBuildingLevel(fbb, 2,fbb.CreateString("世界树"),7,2,2000,0.2f,2,fbb.CreateString("#{Building_1}"));
            offsets[2] = DRBuildingLevel.CreateDRBuildingLevel(fbb, 3,fbb.CreateString("世界树"),7,3,3000,0.3f,3,fbb.CreateString("#{Building_1}"));
            offsets[3] = DRBuildingLevel.CreateDRBuildingLevel(fbb, 4,fbb.CreateString("世界树"),7,4,4000,0.4f,4,fbb.CreateString("#{Building_1}"));
            offsets[4] = DRBuildingLevel.CreateDRBuildingLevel(fbb, 5,fbb.CreateString("世界树"),7,5,5000,0.5f,5,fbb.CreateString("#{Building_1}"));

            VectorOffset dataOff = Table_BuildingLevel.CreateDataVector(fbb, offsets);
            var configOff = Table_BuildingLevel.CreateTable_BuildingLevel(fbb, dataOff);
            Table_BuildingLevel.FinishTable_BuildingLevelBuffer(fbb, configOff);
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