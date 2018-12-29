using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_StraightEffectStepTime : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_StraightEffectStepTime.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRStraightEffectStepTime>[] offsets = new Offset<DRStraightEffectStepTime>[25];
   
            offsets[0] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 0,fbb.CreateString("距离为0的方块"),100,330);
            offsets[1] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 1,fbb.CreateString("距离为1的方块"),290,350);
            offsets[2] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 2,fbb.CreateString("距离为2的方块"),370,370);
            offsets[3] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 3,fbb.CreateString("距离为3的方块"),430,380);
            offsets[4] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 4,fbb.CreateString("距离为4的方块"),430,400);
            offsets[5] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 5,fbb.CreateString("距离为5的方块"),430,450);
            offsets[6] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 6,fbb.CreateString("距离为6的方块"),430,510);
            offsets[7] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 7,fbb.CreateString("距离为7的方块"),430,520);
            offsets[8] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 8,fbb.CreateString("距离为8的方块"),433,530);
            offsets[9] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 9,fbb.CreateString("距离为9的方块"),440,550);
            offsets[10] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 10,fbb.CreateString("距离为10的方块"),450,570);
            offsets[11] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 11,fbb.CreateString("距离为11的方块"),460,600);
            offsets[12] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 12,fbb.CreateString("距离为12的方块"),470,700);
            offsets[13] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 13,fbb.CreateString("距离为13的方块"),480,800);
            offsets[14] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 14,fbb.CreateString("距离为14的方块"),490,1000);
            offsets[15] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 15,fbb.CreateString("距离为15的方块"),500,1000);
            offsets[16] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 16,fbb.CreateString("距离为16的方块"),510,1000);
            offsets[17] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 17,fbb.CreateString("距离为17的方块"),520,1000);
            offsets[18] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 18,fbb.CreateString("距离为18的方块"),550,1000);
            offsets[19] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 19,fbb.CreateString("距离为19的方块"),570,1000);
            offsets[20] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 20,fbb.CreateString("距离为20的方块"),580,1000);
            offsets[21] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 21,fbb.CreateString("距离为21的方块"),600,1000);
            offsets[22] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 22,fbb.CreateString("距离为22的方块"),620,1000);
            offsets[23] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 23,fbb.CreateString("距离为23的方块"),640,1000);
            offsets[24] = DRStraightEffectStepTime.CreateDRStraightEffectStepTime(fbb, 24,fbb.CreateString("距离为24的方块"),680,1000);

            VectorOffset dataOff = Table_StraightEffectStepTime.CreateDataVector(fbb, offsets);
            var configOff = Table_StraightEffectStepTime.CreateTable_StraightEffectStepTime(fbb, dataOff);
            Table_StraightEffectStepTime.FinishTable_StraightEffectStepTimeBuffer(fbb, configOff);
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