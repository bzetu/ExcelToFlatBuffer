using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_Reward : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Reward.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRReward>[] offsets = new Offset<DRReward>[5];
   
            offsets[0] = DRReward.CreateDRReward(fbb, 1001,fbb.CreateString("关卡掉落1"),fbb.CreateString("关卡掉落1"),10,0,0,DRReward.CreateItemIdVector(fbb, new int[] { 1,2,3,0,0,0,0,0 }),DRReward.CreateCountVector(fbb, new int[] { 1,2,3,0,0,0,0,0 }));
            offsets[1] = DRReward.CreateDRReward(fbb, 1002,fbb.CreateString("关卡掉落2"),fbb.CreateString("关卡掉落2"),0,10,0,DRReward.CreateItemIdVector(fbb, new int[] { 0,2,3,4,0,0,0,0 }),DRReward.CreateCountVector(fbb, new int[] { 0,2,3,4,0,0,0,0 }));
            offsets[2] = DRReward.CreateDRReward(fbb, 1003,fbb.CreateString("关卡掉落3"),fbb.CreateString("关卡掉落3"),0,0,5,DRReward.CreateItemIdVector(fbb, new int[] { 0,0,3,4,5,0,0,0 }),DRReward.CreateCountVector(fbb, new int[] { 0,0,3,4,5,0,0,0 }));
            offsets[3] = DRReward.CreateDRReward(fbb, 3000,fbb.CreateString("怪物掉落1"),fbb.CreateString("怪物掉落1"),0,0,0,DRReward.CreateItemIdVector(fbb, new int[] { 1,2,3,0,0,0,0,0 }),DRReward.CreateCountVector(fbb, new int[] { 1,2,3,0,0,0,0,0 }));
            offsets[4] = DRReward.CreateDRReward(fbb, 5000,fbb.CreateString("怪物掉落2"),fbb.CreateString("怪物掉落2"),0,0,0,DRReward.CreateItemIdVector(fbb, new int[] { 1,2,3,0,0,0,0,0 }),DRReward.CreateCountVector(fbb, new int[] { 1,2,3,0,0,0,0,0 }));

            VectorOffset dataOff = Table_Reward.CreateDataVector(fbb, offsets);
            var configOff = Table_Reward.CreateTable_Reward(fbb, dataOff);
            Table_Reward.FinishTable_RewardBuffer(fbb, configOff);
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