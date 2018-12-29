using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_IconBase : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_IconBase.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRIconBase>[] offsets = new Offset<DRIconBase>[13];
   
            offsets[0] = DRIconBase.CreateDRIconBase(fbb, 0,fbb.CreateString("金手指"),13004,2,fbb.CreateString("Icons/Item_Gold_finger"));
            offsets[1] = DRIconBase.CreateDRIconBase(fbb, 1,fbb.CreateString("万能块"),13005,2,fbb.CreateString("Icons/Item_WNK"));
            offsets[2] = DRIconBase.CreateDRIconBase(fbb, 2,fbb.CreateString("小锤子"),13006,2,fbb.CreateString("Icons/Item_Hammer"));
            offsets[3] = DRIconBase.CreateDRIconBase(fbb, 3,fbb.CreateString("加步数"),13007,2,fbb.CreateString("Icons/Item_StepNumber"));
            offsets[4] = DRIconBase.CreateDRIconBase(fbb, 4,fbb.CreateString("后退一步"),13008,2,fbb.CreateString("Icons/Item_BackOff"));
            offsets[5] = DRIconBase.CreateDRIconBase(fbb, 5,fbb.CreateString("闪电"),13009,2,fbb.CreateString("Icons/Item_Lightning"));
            offsets[6] = DRIconBase.CreateDRIconBase(fbb, 6,fbb.CreateString("双倍飞机"),13010,2,fbb.CreateString("Icons/Item_aircraft"));
            offsets[7] = DRIconBase.CreateDRIconBase(fbb, 7,fbb.CreateString("双倍泡泡糖"),13011,2,fbb.CreateString("Icons/Item_paopaotang"));
            offsets[8] = DRIconBase.CreateDRIconBase(fbb, 8,fbb.CreateString("礼盒"),13012,2,fbb.CreateString("Icons/Item_mofang"));
            offsets[9] = DRIconBase.CreateDRIconBase(fbb, 100,fbb.CreateString("无限体力"),13013,3,fbb.CreateString("Common/Icon_InfiniteLife"));
            offsets[10] = DRIconBase.CreateDRIconBase(fbb, 101,fbb.CreateString("钻石"),13014,1,fbb.CreateString("Common/com_money_diamond"));
            offsets[11] = DRIconBase.CreateDRIconBase(fbb, 102,fbb.CreateString("金币"),13015,1,fbb.CreateString("Common/com_money_gold"));
            offsets[12] = DRIconBase.CreateDRIconBase(fbb, 103,fbb.CreateString("体力"),13016,2,fbb.CreateString("Common/com_money_life"));

            VectorOffset dataOff = Table_IconBase.CreateDataVector(fbb, offsets);
            var configOff = Table_IconBase.CreateTable_IconBase(fbb, dataOff);
            Table_IconBase.FinishTable_IconBaseBuffer(fbb, configOff);
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