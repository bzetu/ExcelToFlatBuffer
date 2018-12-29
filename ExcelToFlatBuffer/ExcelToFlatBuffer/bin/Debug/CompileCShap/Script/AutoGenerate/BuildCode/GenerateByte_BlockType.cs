using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_BlockType : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_BlockType.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRBlockType>[] offsets = new Offset<DRBlockType>[22];
   
            offsets[0] = DRBlockType.CreateDRBlockType(fbb, 1,fbb.CreateString("火箭横"),fbb.CreateString("Icons/Item_Rocket_H"));
            offsets[1] = DRBlockType.CreateDRBlockType(fbb, 2,fbb.CreateString("火箭竖"),fbb.CreateString("Icons/Item_Rocket"));
            offsets[2] = DRBlockType.CreateDRBlockType(fbb, 3,fbb.CreateString("木箱3"),fbb.CreateString("Icons/Item_WoodenBox3"));
            offsets[3] = DRBlockType.CreateDRBlockType(fbb, 4,fbb.CreateString("铃铛"),fbb.CreateString("Icons/Item_Bell"));
            offsets[4] = DRBlockType.CreateDRBlockType(fbb, 5,fbb.CreateString("木箱2"),fbb.CreateString("Icons/Item_WoodenBox2"));
            offsets[5] = DRBlockType.CreateDRBlockType(fbb, 6,fbb.CreateString("木箱1"),fbb.CreateString("Icons/Item_WoodenBox1"));
            offsets[6] = DRBlockType.CreateDRBlockType(fbb, 7,fbb.CreateString("果子"),fbb.CreateString("Icons/Item_Apple"));
            offsets[7] = DRBlockType.CreateDRBlockType(fbb, 8,fbb.CreateString("小人"),fbb.CreateString("Icons/Item_man"));
            offsets[8] = DRBlockType.CreateDRBlockType(fbb, 9,fbb.CreateString("摘果子_藤"),fbb.CreateString("Icons/Item_rattan1"));
            offsets[9] = DRBlockType.CreateDRBlockType(fbb, 10,fbb.CreateString("加步数"),fbb.CreateString("Icons/Item_AddSteps"));
            offsets[10] = DRBlockType.CreateDRBlockType(fbb, 13,fbb.CreateString("清屏"),fbb.CreateString("Icons/Item_ClearScreen"));
            offsets[11] = DRBlockType.CreateDRBlockType(fbb, 23,fbb.CreateString("钥匙"),fbb.CreateString("Icons/Item_Key"));
            offsets[12] = DRBlockType.CreateDRBlockType(fbb, 24,fbb.CreateString("放大镜"),fbb.CreateString("Icons/Item_Magnifier"));
            offsets[13] = DRBlockType.CreateDRBlockType(fbb, 28,fbb.CreateString("冰块1"),fbb.CreateString("Icons/Item_IceBlock1"));
            offsets[14] = DRBlockType.CreateDRBlockType(fbb, 29,fbb.CreateString("冰块2"),fbb.CreateString("Icons/Item_IceBlock2"));
            offsets[15] = DRBlockType.CreateDRBlockType(fbb, 30,fbb.CreateString("冰块3"),fbb.CreateString("Icons/Item_IceBlock3"));
            offsets[16] = DRBlockType.CreateDRBlockType(fbb, 31,fbb.CreateString("糖纸"),fbb.CreateString("Icons/Element_CandyPaper"));
            offsets[17] = DRBlockType.CreateDRBlockType(fbb, 33,fbb.CreateString("石块"),fbb.CreateString("Icons/Element_Stone"));
            offsets[18] = DRBlockType.CreateDRBlockType(fbb, 25,fbb.CreateString("王子"),fbb.CreateString("Icons/Icon_wangzi"));
            offsets[19] = DRBlockType.CreateDRBlockType(fbb, 34,fbb.CreateString("睡美人"),fbb.CreateString("Icons/Icon_shuimeiren"));
            offsets[20] = DRBlockType.CreateDRBlockType(fbb, 26,fbb.CreateString("玫瑰花"),fbb.CreateString("Icons/Element_Rose"));
            offsets[21] = DRBlockType.CreateDRBlockType(fbb, 35,fbb.CreateString("染色瓶"),fbb.CreateString("Icons/Icon_DyedBottle"));

            VectorOffset dataOff = Table_BlockType.CreateDataVector(fbb, offsets);
            var configOff = Table_BlockType.CreateTable_BlockType(fbb, dataOff);
            Table_BlockType.FinishTable_BlockTypeBuffer(fbb, configOff);
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