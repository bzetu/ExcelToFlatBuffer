using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_Building : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Building.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRBuilding>[] offsets = new Offset<DRBuilding>[8];
   
            offsets[0] = DRBuilding.CreateDRBuilding(fbb, 1,fbb.CreateString("围栏"),20.9f,36.5f,83.5f,1,DRBuilding.CreateStateStoryProgressVector(fbb, new int[] { 0,2,999,999,999 }),DRBuilding.CreateStateModelVector(fbb, new int[] { 50001,50225,0,0,0 }),DRBuilding.CreateModelVector(fbb, new int[] { 50201,50221,50222 }),500,DRBuilding.CreateIconVector(fbb, new int[] { 12401,12402,12403 }),DRBuilding.CreateNameVector(fbb, new StringOffset[] { fbb.CreateString("#{Building_1}"),fbb.CreateString("#{Building_9}"),fbb.CreateString("#{Building_17}") }),DRBuilding.CreateWorkerPositionVector(fbb, new StringOffset[] { fbb.CreateString("34.6|16.38|73.7"),fbb.CreateString("35.66|16.35|74.676"),fbb.CreateString("35.69|16.36|73.7"),fbb.CreateString("36.934|16.383|73.548"),fbb.CreateString("36.934|16.383|73.548") }));
            offsets[1] = DRBuilding.CreateDRBuilding(fbb, 2,fbb.CreateString("花圃"),20.7f,36.5f,89.6f,1,DRBuilding.CreateStateStoryProgressVector(fbb, new int[] { 0,4,999,999,999 }),DRBuilding.CreateStateModelVector(fbb, new int[] { 50002,50228,0,0,0 }),DRBuilding.CreateModelVector(fbb, new int[] { 50202,50219,50220 }),500,DRBuilding.CreateIconVector(fbb, new int[] { 12404,12405,12406 }),DRBuilding.CreateNameVector(fbb, new StringOffset[] { fbb.CreateString("#{Building_2}"),fbb.CreateString("#{Building_10}"),fbb.CreateString("#{Building_18}") }),DRBuilding.CreateWorkerPositionVector(fbb, new StringOffset[] { fbb.CreateString("34.6|16.38|73.7"),fbb.CreateString("35.66|16.35|74.676"),fbb.CreateString("35.69|16.36|73.7"),fbb.CreateString("36.934|16.383|73.548"),fbb.CreateString("36.934|16.383|73.548") }));
            offsets[2] = DRBuilding.CreateDRBuilding(fbb, 3,fbb.CreateString("长椅"),24.8f,36.5f,91.1f,1,DRBuilding.CreateStateStoryProgressVector(fbb, new int[] { 0,999,999,999,999 }),DRBuilding.CreateStateModelVector(fbb, new int[] { 50003,0,0,0,0 }),DRBuilding.CreateModelVector(fbb, new int[] { 50203,50215,50216 }),500,DRBuilding.CreateIconVector(fbb, new int[] { 12407,12408,12409 }),DRBuilding.CreateNameVector(fbb, new StringOffset[] { fbb.CreateString("#{Building_3}"),fbb.CreateString("#{Building_11}"),fbb.CreateString("#{Building_19}") }),DRBuilding.CreateWorkerPositionVector(fbb, new StringOffset[] { fbb.CreateString("34.6|16.38|73.7"),fbb.CreateString("35.66|16.35|74.676"),fbb.CreateString("35.69|16.36|73.7"),fbb.CreateString("36.934|16.383|73.548"),fbb.CreateString("36.934|16.383|73.548") }));
            offsets[3] = DRBuilding.CreateDRBuilding(fbb, 4,fbb.CreateString("路灯"),25.6f,36.5f,88.1f,1,DRBuilding.CreateStateStoryProgressVector(fbb, new int[] { 0,999,999,999,999 }),DRBuilding.CreateStateModelVector(fbb, new int[] { 50004,0,0,0,0 }),DRBuilding.CreateModelVector(fbb, new int[] { 50204,50211,50212 }),500,DRBuilding.CreateIconVector(fbb, new int[] { 12410,12411,12412 }),DRBuilding.CreateNameVector(fbb, new StringOffset[] { fbb.CreateString("#{Building_4}"),fbb.CreateString("#{Building_12}"),fbb.CreateString("#{Building_20}") }),DRBuilding.CreateWorkerPositionVector(fbb, new StringOffset[] { fbb.CreateString("34.6|16.38|73.7"),fbb.CreateString("35.66|16.35|74.676"),fbb.CreateString("35.69|16.36|73.7"),fbb.CreateString("36.934|16.383|73.548"),fbb.CreateString("36.934|16.383|73.548") }));
            offsets[4] = DRBuilding.CreateDRBuilding(fbb, 5,fbb.CreateString("园艺"),24.8f,36.5f,92.2f,1,DRBuilding.CreateStateStoryProgressVector(fbb, new int[] { 0,999,999,999,999 }),DRBuilding.CreateStateModelVector(fbb, new int[] { 50005,0,0,0,0 }),DRBuilding.CreateModelVector(fbb, new int[] { 50205,50213,50214 }),500,DRBuilding.CreateIconVector(fbb, new int[] { 12413,12414,12415 }),DRBuilding.CreateNameVector(fbb, new StringOffset[] { fbb.CreateString("#{Building_5}"),fbb.CreateString("#{Building_13}"),fbb.CreateString("#{Building_21}") }),DRBuilding.CreateWorkerPositionVector(fbb, new StringOffset[] { fbb.CreateString("34.6|16.38|73.7"),fbb.CreateString("35.66|16.35|74.676"),fbb.CreateString("35.69|16.36|73.7"),fbb.CreateString("36.934|16.383|73.548"),fbb.CreateString("36.934|16.383|73.548") }));
            offsets[5] = DRBuilding.CreateDRBuilding(fbb, 6,fbb.CreateString("道路"),19.2f,36.5f,89.4f,1,DRBuilding.CreateStateStoryProgressVector(fbb, new int[] { 0,999,999,999,999 }),DRBuilding.CreateStateModelVector(fbb, new int[] { 50006,0,0,0,0 }),DRBuilding.CreateModelVector(fbb, new int[] { 50206,50223,50224 }),500,DRBuilding.CreateIconVector(fbb, new int[] { 12416,12417,12418 }),DRBuilding.CreateNameVector(fbb, new StringOffset[] { fbb.CreateString("#{Building_6}"),fbb.CreateString("#{Building_14}"),fbb.CreateString("#{Building_22}") }),DRBuilding.CreateWorkerPositionVector(fbb, new StringOffset[] { fbb.CreateString("34.6|16.38|73.7"),fbb.CreateString("35.66|16.35|74.676"),fbb.CreateString("35.69|16.36|73.7"),fbb.CreateString("36.934|16.383|73.548"),fbb.CreateString("36.934|16.383|73.548") }));
            offsets[6] = DRBuilding.CreateDRBuilding(fbb, 7,fbb.CreateString("世界树3"),19.6f,36.5f,83f,1,DRBuilding.CreateStateStoryProgressVector(fbb, new int[] { 0,3,10,999,999 }),DRBuilding.CreateStateModelVector(fbb, new int[] { 50007,50008,50009,0,0 }),DRBuilding.CreateModelVector(fbb, new int[] { 50210,50217,50218 }),500,DRBuilding.CreateIconVector(fbb, new int[] { 12419,12420,12421 }),DRBuilding.CreateNameVector(fbb, new StringOffset[] { fbb.CreateString("#{Building_7}"),fbb.CreateString("#{Building_15}"),fbb.CreateString("#{Building_23}") }),DRBuilding.CreateWorkerPositionVector(fbb, new StringOffset[] { fbb.CreateString("32.22|16.35|69.98"),fbb.CreateString("38.44|16.35|68.65"),fbb.CreateString("32.64|16.35|68.65"),fbb.CreateString("38.6|16.35|70.98"),fbb.CreateString("32.5|16.35|72.85") }));
            offsets[7] = DRBuilding.CreateDRBuilding(fbb, 8,fbb.CreateString("桥"),0f,0f,0f,1,DRBuilding.CreateStateStoryProgressVector(fbb, new int[] { 0,11,999,999,999 }),DRBuilding.CreateStateModelVector(fbb, new int[] { 50226,50227,0,0,0 }),DRBuilding.CreateModelVector(fbb, new int[] { -1,-1,-1 }),500,DRBuilding.CreateIconVector(fbb, new int[] { -1,-1,-1 }),DRBuilding.CreateNameVector(fbb, new StringOffset[] { fbb.CreateString("#{Building_8}"),fbb.CreateString("#{Building_16}"),fbb.CreateString("#{Building_24}") }),DRBuilding.CreateWorkerPositionVector(fbb, new StringOffset[] { fbb.CreateString("34.6|16.38|73.7"),fbb.CreateString("35.66|16.35|74.676"),fbb.CreateString("35.69|16.36|73.7"),fbb.CreateString("36.934|16.383|73.548"),fbb.CreateString("36.934|16.383|73.548") }));

            VectorOffset dataOff = Table_Building.CreateDataVector(fbb, offsets);
            var configOff = Table_Building.CreateTable_Building(fbb, dataOff);
            Table_Building.FinishTable_BuildingBuffer(fbb, configOff);
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