using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_CommonItem : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_CommonItem.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRCommonItem>[] offsets = new Offset<DRCommonItem>[9];
   
            offsets[0] = DRCommonItem.CreateDRCommonItem(fbb, 0,fbb.CreateString("金手指"),13004,fbb.CreateString("Icons/Item_Gold_finger"),43,0);
            offsets[1] = DRCommonItem.CreateDRCommonItem(fbb, 1,fbb.CreateString("万能块"),13005,fbb.CreateString("Icons/Item_WNK"),44,0);
            offsets[2] = DRCommonItem.CreateDRCommonItem(fbb, 2,fbb.CreateString("小锤子"),13006,fbb.CreateString("Icons/Item_Hammer"),46,0);
            offsets[3] = DRCommonItem.CreateDRCommonItem(fbb, 3,fbb.CreateString("加步数"),13007,fbb.CreateString("Icons/Item_StepNumber"),75,1);
            offsets[4] = DRCommonItem.CreateDRCommonItem(fbb, 4,fbb.CreateString("后退一步"),13008,fbb.CreateString("Icons/Item_BackOff"),73,0);
            offsets[5] = DRCommonItem.CreateDRCommonItem(fbb, 5,fbb.CreateString("连锁闪电"),13009,fbb.CreateString("Icons/Item_Lightning"),74,0);
            offsets[6] = DRCommonItem.CreateDRCommonItem(fbb, 6,fbb.CreateString("双倍飞机"),13010,fbb.CreateString("Icons/Item_aircraft"),0,1);
            offsets[7] = DRCommonItem.CreateDRCommonItem(fbb, 7,fbb.CreateString("双倍泡泡糖"),13011,fbb.CreateString("Icons/Item_paopaotang"),0,1);
            offsets[8] = DRCommonItem.CreateDRCommonItem(fbb, 8,fbb.CreateString("礼盒"),13012,fbb.CreateString("Icons/Item_mofang"),0,1);

            VectorOffset dataOff = Table_CommonItem.CreateDataVector(fbb, offsets);
            var configOff = Table_CommonItem.CreateTable_CommonItem(fbb, dataOff);
            Table_CommonItem.FinishTable_CommonItemBuffer(fbb, configOff);
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