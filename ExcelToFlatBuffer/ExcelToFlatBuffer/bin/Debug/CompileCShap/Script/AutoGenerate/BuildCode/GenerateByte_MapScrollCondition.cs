using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_MapScrollCondition : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_MapScrollCondition.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRMapScrollCondition>[] offsets = new Offset<DRMapScrollCondition>[19];
   
            offsets[0] = DRMapScrollCondition.CreateDRMapScrollCondition(fbb, 1,fbb.CreateString("收集铃铛1"),1,1,fbb.CreateString("4|0"),-1,0);
            offsets[1] = DRMapScrollCondition.CreateDRMapScrollCondition(fbb, 2,fbb.CreateString("剩余4行"),2,-1,fbb.CreateString("-1"),4,0);
            offsets[2] = DRMapScrollCondition.CreateDRMapScrollCondition(fbb, 3,fbb.CreateString("收集木箱"),1,1,fbb.CreateString("6|0"),-1,0);
            offsets[3] = DRMapScrollCondition.CreateDRMapScrollCondition(fbb, 4,fbb.CreateString("收集铃铛2"),1,1,fbb.CreateString("4|1"),-1,0);
            offsets[4] = DRMapScrollCondition.CreateDRMapScrollCondition(fbb, 5,fbb.CreateString("剩余1行"),2,-1,fbb.CreateString("-1"),1,0);
            offsets[5] = DRMapScrollCondition.CreateDRMapScrollCondition(fbb, 6,fbb.CreateString("抓小鹰"),1,1,fbb.CreateString("22|2"),-1,0);
            offsets[6] = DRMapScrollCondition.CreateDRMapScrollCondition(fbb, 7,fbb.CreateString("收集钥匙1"),1,1,fbb.CreateString("23|0"),-1,0);
            offsets[7] = DRMapScrollCondition.CreateDRMapScrollCondition(fbb, 8,fbb.CreateString("收集放大镜1"),1,1,fbb.CreateString("24|0"),-1,0);
            offsets[8] = DRMapScrollCondition.CreateDRMapScrollCondition(fbb, 9,fbb.CreateString("收集冰块"),1,2,fbb.CreateString("1|0"),-1,0);
            offsets[9] = DRMapScrollCondition.CreateDRMapScrollCondition(fbb, 10,fbb.CreateString("消除幽灵"),1,1,fbb.CreateString("27|0"),-1,0);
            offsets[10] = DRMapScrollCondition.CreateDRMapScrollCondition(fbb, 11,fbb.CreateString("收集颜色块"),1,1,fbb.CreateString("0|0"),-1,1);
            offsets[11] = DRMapScrollCondition.CreateDRMapScrollCondition(fbb, 12,fbb.CreateString("收集颜色块"),1,1,fbb.CreateString("4|0"),-1,1);
            offsets[12] = DRMapScrollCondition.CreateDRMapScrollCondition(fbb, 13,fbb.CreateString("剩余0个彩虹糖"),1,1,fbb.CreateString("31|0"),-1,0);
            offsets[13] = DRMapScrollCondition.CreateDRMapScrollCondition(fbb, 14,fbb.CreateString("剩余0个加步数"),1,1,fbb.CreateString("10|0"),-1,0);
            offsets[14] = DRMapScrollCondition.CreateDRMapScrollCondition(fbb, 15,fbb.CreateString("剩余2行"),2,-1,fbb.CreateString("-1"),2,0);
            offsets[15] = DRMapScrollCondition.CreateDRMapScrollCondition(fbb, 16,fbb.CreateString("剩余0个染色瓶"),1,1,fbb.CreateString("35|0"),-1,0);
            offsets[16] = DRMapScrollCondition.CreateDRMapScrollCondition(fbb, 17,fbb.CreateString("剩余1行"),2,-1,fbb.CreateString("-1"),1,0);
            offsets[17] = DRMapScrollCondition.CreateDRMapScrollCondition(fbb, 18,fbb.CreateString("剩余0个红色块"),1,1,fbb.CreateString("6|0"),-1,1);
            offsets[18] = DRMapScrollCondition.CreateDRMapScrollCondition(fbb, 19,fbb.CreateString("消除啄木鸟"),1,1,fbb.CreateString("42|0"),-1,0);

            VectorOffset dataOff = Table_MapScrollCondition.CreateDataVector(fbb, offsets);
            var configOff = Table_MapScrollCondition.CreateTable_MapScrollCondition(fbb, dataOff);
            Table_MapScrollCondition.FinishTable_MapScrollConditionBuffer(fbb, configOff);
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