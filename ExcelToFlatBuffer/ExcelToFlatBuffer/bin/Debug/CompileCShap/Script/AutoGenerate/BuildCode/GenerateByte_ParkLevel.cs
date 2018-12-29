using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_ParkLevel : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_ParkLevel.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRParkLevel>[] offsets = new Offset<DRParkLevel>[10];
   
            offsets[0] = DRParkLevel.CreateDRParkLevel(fbb, 1,fbb.CreateString("游乐园等级1"),900,900,DRParkLevel.CreateBoxRequireVector(fbb, new int[] { 300,600,900 }),DRParkLevel.CreateBoxRewardVector(fbb, new int[] { 1001,1002,1003 }),100,50000);
            offsets[1] = DRParkLevel.CreateDRParkLevel(fbb, 2,fbb.CreateString("游乐园等级2"),2400,1600,DRParkLevel.CreateBoxRequireVector(fbb, new int[] { 480,960,1600 }),DRParkLevel.CreateBoxRewardVector(fbb, new int[] { 1001,1002,1003 }),200,100000);
            offsets[2] = DRParkLevel.CreateDRParkLevel(fbb, 3,fbb.CreateString("游乐园等级3"),4800,2400,DRParkLevel.CreateBoxRequireVector(fbb, new int[] { 720,1440,2400 }),DRParkLevel.CreateBoxRewardVector(fbb, new int[] { 1001,1002,1003 }),300,150000);
            offsets[3] = DRParkLevel.CreateDRParkLevel(fbb, 4,fbb.CreateString("游乐园等级4"),8000,3200,DRParkLevel.CreateBoxRequireVector(fbb, new int[] { 960,1920,3200 }),DRParkLevel.CreateBoxRewardVector(fbb, new int[] { 1001,1002,1003 }),400,200000);
            offsets[4] = DRParkLevel.CreateDRParkLevel(fbb, 5,fbb.CreateString("游乐园等级5"),12000,4000,DRParkLevel.CreateBoxRequireVector(fbb, new int[] { 1200,2400,4000 }),DRParkLevel.CreateBoxRewardVector(fbb, new int[] { 1001,1002,1003 }),500,250000);
            offsets[5] = DRParkLevel.CreateDRParkLevel(fbb, 6,fbb.CreateString("游乐园等级6"),16800,4800,DRParkLevel.CreateBoxRequireVector(fbb, new int[] { 1440,2880,4800 }),DRParkLevel.CreateBoxRewardVector(fbb, new int[] { 1001,1002,1003 }),600,300000);
            offsets[6] = DRParkLevel.CreateDRParkLevel(fbb, 7,fbb.CreateString("游乐园等级7"),22400,5600,DRParkLevel.CreateBoxRequireVector(fbb, new int[] { 1680,3360,5600 }),DRParkLevel.CreateBoxRewardVector(fbb, new int[] { 1001,1002,1003 }),700,350000);
            offsets[7] = DRParkLevel.CreateDRParkLevel(fbb, 8,fbb.CreateString("游乐园等级8"),28800,6400,DRParkLevel.CreateBoxRequireVector(fbb, new int[] { 1920,3840,6400 }),DRParkLevel.CreateBoxRewardVector(fbb, new int[] { 1001,1002,1003 }),800,400000);
            offsets[8] = DRParkLevel.CreateDRParkLevel(fbb, 9,fbb.CreateString("游乐园等级9"),36000,7200,DRParkLevel.CreateBoxRequireVector(fbb, new int[] { 2160,4320,7200 }),DRParkLevel.CreateBoxRewardVector(fbb, new int[] { 1001,1002,1003 }),900,450000);
            offsets[9] = DRParkLevel.CreateDRParkLevel(fbb, 10,fbb.CreateString("游乐园等级10"),44000,8000,DRParkLevel.CreateBoxRequireVector(fbb, new int[] { 2400,4800,8000 }),DRParkLevel.CreateBoxRewardVector(fbb, new int[] { 1001,1002,1003 }),1000,500000);

            VectorOffset dataOff = Table_ParkLevel.CreateDataVector(fbb, offsets);
            var configOff = Table_ParkLevel.CreateTable_ParkLevel(fbb, dataOff);
            Table_ParkLevel.FinishTable_ParkLevelBuffer(fbb, configOff);
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