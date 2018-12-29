using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_TreasureMapData : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_TreasureMapData.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRTreasureMapData>[] offsets = new Offset<DRTreasureMapData>[6];
   
            offsets[0] = DRTreasureMapData.CreateDRTreasureMapData(fbb, 1,default(StringOffset),fbb.CreateString("TreasureMap1"),1,-206,576,0,0,0,0,0,DRTreasureMapData.CreateStoryIdVector(fbb, new int[] { 1,0,0,0,0 }));
            offsets[1] = DRTreasureMapData.CreateDRTreasureMapData(fbb, 2,default(StringOffset),fbb.CreateString("TreasureMap2"),2,163,448,0,0,0,0,0,DRTreasureMapData.CreateStoryIdVector(fbb, new int[] { 2,0,0,0,0 }));
            offsets[2] = DRTreasureMapData.CreateDRTreasureMapData(fbb, 3,default(StringOffset),fbb.CreateString("TreasureMap3"),3,-112,39,0,0,0,0,0,DRTreasureMapData.CreateStoryIdVector(fbb, new int[] { 3,0,0,0,0 }));
            offsets[3] = DRTreasureMapData.CreateDRTreasureMapData(fbb, 4,default(StringOffset),fbb.CreateString("TreasureMap4"),4,280,-130,0,0,0,0,0,DRTreasureMapData.CreateStoryIdVector(fbb, new int[] { 4,0,0,0,0 }));
            offsets[4] = DRTreasureMapData.CreateDRTreasureMapData(fbb, 5,default(StringOffset),fbb.CreateString("TreasureMap5"),5,-228,-514,0,0,0,0,0,DRTreasureMapData.CreateStoryIdVector(fbb, new int[] { 5,0,0,0,0 }));
            offsets[5] = DRTreasureMapData.CreateDRTreasureMapData(fbb, 6,default(StringOffset),fbb.CreateString("TreasureMap6"),6,172,-560,0,0,0,0,0,DRTreasureMapData.CreateStoryIdVector(fbb, new int[] { 6,0,0,0,0 }));

            VectorOffset dataOff = Table_TreasureMapData.CreateDataVector(fbb, offsets);
            var configOff = Table_TreasureMapData.CreateTable_TreasureMapData(fbb, dataOff);
            Table_TreasureMapData.FinishTable_TreasureMapDataBuffer(fbb, configOff);
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