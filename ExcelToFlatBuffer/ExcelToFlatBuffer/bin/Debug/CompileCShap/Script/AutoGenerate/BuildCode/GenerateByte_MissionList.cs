using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_MissionList : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_MissionList.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRMissionList>[] offsets = new Offset<DRMissionList>[11];
   
            offsets[0] = DRMissionList.CreateDRMissionList(fbb, 1,fbb.CreateString("1章任务1"),fbb.CreateString("驱散黑雾"),14001,1,DRMissionList.CreatePredecessorsIdVector(fbb, new int[] { 0,0,0,0,0 }),DRMissionList.CreateSuccessorIdVector(fbb, new int[] { 2,0,0,0,0 }),2,3,0,100,2,0,fbb.CreateString("1:50225"));
            offsets[1] = DRMissionList.CreateDRMissionList(fbb, 2,fbb.CreateString("1章任务2"),fbb.CreateString("修复围栏"),14002,1,DRMissionList.CreatePredecessorsIdVector(fbb, new int[] { 1,0,0,0,0 }),DRMissionList.CreateSuccessorIdVector(fbb, new int[] { 3,0,0,0,0 }),3,3,0,100,3,1,fbb.CreateString("7:50008"));
            offsets[2] = DRMissionList.CreateDRMissionList(fbb, 3,fbb.CreateString("1章任务3"),fbb.CreateString("拔除杂草"),14003,1,DRMissionList.CreatePredecessorsIdVector(fbb, new int[] { 2,0,0,0,0 }),DRMissionList.CreateSuccessorIdVector(fbb, new int[] { 4,0,0,0,0 }),2,3,0,100,4,0,fbb.CreateString("2:50228"));
            offsets[3] = DRMissionList.CreateDRMissionList(fbb, 4,fbb.CreateString("1章任务4"),fbb.CreateString("修复花圃"),14004,1,DRMissionList.CreatePredecessorsIdVector(fbb, new int[] { 3,0,0,0,0 }),DRMissionList.CreateSuccessorIdVector(fbb, new int[] { 5,0,0,0,0 }),3,3,0,100,5,2,fbb.CreateString("0"));
            offsets[4] = DRMissionList.CreateDRMissionList(fbb, 5,fbb.CreateString("1章任务5"),fbb.CreateString("修复长椅"),14005,1,DRMissionList.CreatePredecessorsIdVector(fbb, new int[] { 4,0,0,0,0 }),DRMissionList.CreateSuccessorIdVector(fbb, new int[] { 6,0,0,0,0 }),3,3,0,100,6,3,fbb.CreateString("0"));
            offsets[5] = DRMissionList.CreateDRMissionList(fbb, 6,fbb.CreateString("1章任务6"),fbb.CreateString("新的路灯"),14006,1,DRMissionList.CreatePredecessorsIdVector(fbb, new int[] { 5,0,0,0,0 }),DRMissionList.CreateSuccessorIdVector(fbb, new int[] { 7,0,0,0,0 }),3,3,0,100,7,4,fbb.CreateString("0"));
            offsets[6] = DRMissionList.CreateDRMissionList(fbb, 7,fbb.CreateString("1章任务7"),fbb.CreateString("魔法园艺"),14007,1,DRMissionList.CreatePredecessorsIdVector(fbb, new int[] { 6,0,0,0,0 }),DRMissionList.CreateSuccessorIdVector(fbb, new int[] { 8,0,0,0,0 }),3,6,0,100,8,5,fbb.CreateString("0"));
            offsets[7] = DRMissionList.CreateDRMissionList(fbb, 8,fbb.CreateString("1章任务8"),fbb.CreateString("铺平道路"),14008,1,DRMissionList.CreatePredecessorsIdVector(fbb, new int[] { 7,0,0,0,0 }),DRMissionList.CreateSuccessorIdVector(fbb, new int[] { 9,0,0,0,0 }),3,6,0,100,9,6,fbb.CreateString("7:50009"));
            offsets[8] = DRMissionList.CreateDRMissionList(fbb, 9,fbb.CreateString("1章任务9"),fbb.CreateString("装饰世界树"),14009,1,DRMissionList.CreatePredecessorsIdVector(fbb, new int[] { 8,0,0,0,0 }),DRMissionList.CreateSuccessorIdVector(fbb, new int[] { 10,0,0,0,0 }),3,6,0,100,10,7,fbb.CreateString("0"));
            offsets[9] = DRMissionList.CreateDRMissionList(fbb, 10,fbb.CreateString("1章任务10"),fbb.CreateString("架起桥梁"),14010,1,DRMissionList.CreatePredecessorsIdVector(fbb, new int[] { 9,0,0,0,0 }),DRMissionList.CreateSuccessorIdVector(fbb, new int[] { 11,0,0,0,0 }),2,9,0,100,11,0,fbb.CreateString("8:50227"));
            offsets[10] = DRMissionList.CreateDRMissionList(fbb, 11,fbb.CreateString("测试版本节点"),fbb.CreateString("新的旅程"),14010,1,DRMissionList.CreatePredecessorsIdVector(fbb, new int[] { 10,0,0,0,0 }),DRMissionList.CreateSuccessorIdVector(fbb, new int[] { 0,0,0,0,0 }),2,999,0,100,2,0,fbb.CreateString("0"));

            VectorOffset dataOff = Table_MissionList.CreateDataVector(fbb, offsets);
            var configOff = Table_MissionList.CreateTable_MissionList(fbb, dataOff);
            Table_MissionList.FinishTable_MissionListBuffer(fbb, configOff);
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