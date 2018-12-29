using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_Terrain : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Terrain.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRTerrain>[] offsets = new Offset<DRTerrain>[7];
   
            offsets[0] = DRTerrain.CreateDRTerrain(fbb, 0,fbb.CreateString("不可行走路线"),60043);
            offsets[1] = DRTerrain.CreateDRTerrain(fbb, 1,fbb.CreateString("地图路线"),60038);
            offsets[2] = DRTerrain.CreateDRTerrain(fbb, 2,fbb.CreateString("地图出生点"),60038);
            offsets[3] = DRTerrain.CreateDRTerrain(fbb, 3,fbb.CreateString("地图鹰巢"),60040);
            offsets[4] = DRTerrain.CreateDRTerrain(fbb, 4,fbb.CreateString("地图草地"),60039);
            offsets[5] = DRTerrain.CreateDRTerrain(fbb, 5,fbb.CreateString("母鸡"),60041);
            offsets[6] = DRTerrain.CreateDRTerrain(fbb, 6,fbb.CreateString("小鹰"),60042);

            VectorOffset dataOff = Table_Terrain.CreateDataVector(fbb, offsets);
            var configOff = Table_Terrain.CreateTable_Terrain(fbb, dataOff);
            Table_Terrain.FinishTable_TerrainBuffer(fbb, configOff);
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