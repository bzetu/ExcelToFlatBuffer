using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_OpenItem : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_OpenItem.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DROpenItem>[] offsets = new Offset<DROpenItem>[13];
   
            offsets[0] = DROpenItem.CreateDROpenItem(fbb, 1,fbb.CreateString("道具开放-金手指"),0,0,true);
            offsets[1] = DROpenItem.CreateDROpenItem(fbb, 2,fbb.CreateString("道具开放-小锤子"),2,0,true);
            offsets[2] = DROpenItem.CreateDROpenItem(fbb, 3,fbb.CreateString("道具开放-万能块"),1,99,true);
            offsets[3] = DROpenItem.CreateDROpenItem(fbb, 4,fbb.CreateString("道具开放-战前加步数"),3,1,true);
            offsets[4] = DROpenItem.CreateDROpenItem(fbb, 5,fbb.CreateString("道具开放-后悔药"),4,1,true);
            offsets[5] = DROpenItem.CreateDROpenItem(fbb, 6,fbb.CreateString("道具开放-连锁闪电"),5,99,true);
            offsets[6] = DROpenItem.CreateDROpenItem(fbb, 7,fbb.CreateString("道具开放-双倍飞机"),6,1,true);
            offsets[7] = DROpenItem.CreateDROpenItem(fbb, 8,fbb.CreateString("道具开放"),7,1,false);
            offsets[8] = DROpenItem.CreateDROpenItem(fbb, 9,fbb.CreateString("道具开放-礼盒"),8,1,true);
            offsets[9] = DROpenItem.CreateDROpenItem(fbb, 10,fbb.CreateString("道具开放"),1,1,true);
            offsets[10] = DROpenItem.CreateDROpenItem(fbb, 11,fbb.CreateString("道具开放"),1,1,true);
            offsets[11] = DROpenItem.CreateDROpenItem(fbb, 12,fbb.CreateString("道具开放"),1,1,true);
            offsets[12] = DROpenItem.CreateDROpenItem(fbb, 13,fbb.CreateString("道具开放"),1,1,true);

            VectorOffset dataOff = Table_OpenItem.CreateDataVector(fbb, offsets);
            var configOff = Table_OpenItem.CreateTable_OpenItem(fbb, dataOff);
            Table_OpenItem.FinishTable_OpenItemBuffer(fbb, configOff);
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