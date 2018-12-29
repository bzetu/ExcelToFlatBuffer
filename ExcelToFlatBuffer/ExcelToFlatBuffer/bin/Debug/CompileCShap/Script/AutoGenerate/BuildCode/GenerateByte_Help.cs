using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_Help : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Help.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRHelp>[] offsets = new Offset<DRHelp>[13];
   
            offsets[0] = DRHelp.CreateDRHelp(fbb, 10001,fbb.CreateString("幽灵"),1,fbb.CreateString("幽灵"),12512,31007,fbb.CreateString("#{Help_7}"));
            offsets[1] = DRHelp.CreateDRHelp(fbb, 10002,fbb.CreateString("睡美人"),1,fbb.CreateString("睡美人"),12505,31005,fbb.CreateString("#{Help_5}"));
            offsets[2] = DRHelp.CreateDRHelp(fbb, 10003,fbb.CreateString("地鼠"),1,fbb.CreateString("地鼠"),12503,31011,fbb.CreateString("#{Help_10}"));
            offsets[3] = DRHelp.CreateDRHelp(fbb, 30001,fbb.CreateString("加步数"),3,fbb.CreateString("加步数"),12506,31002,fbb.CreateString("#{Help_2}"));
            offsets[4] = DRHelp.CreateDRHelp(fbb, 30002,fbb.CreateString("冰块"),3,fbb.CreateString("冰块"),12513,31003,fbb.CreateString("#{Help_3}"));
            offsets[5] = DRHelp.CreateDRHelp(fbb, 30003,fbb.CreateString("石块"),3,fbb.CreateString("石块"),12511,31004,fbb.CreateString("#{Help_4}"));
            offsets[6] = DRHelp.CreateDRHelp(fbb, 30004,fbb.CreateString("穿透块"),3,fbb.CreateString("穿透块"),12509,31009,fbb.CreateString("#{Help_8}"));
            offsets[7] = DRHelp.CreateDRHelp(fbb, 30005,fbb.CreateString("染色瓶"),3,fbb.CreateString("染色瓶"),12510,31010,fbb.CreateString("#{Help_9}"));
            offsets[8] = DRHelp.CreateDRHelp(fbb, 30006,fbb.CreateString("小鹰快跑"),3,fbb.CreateString("小鹰快跑"),12514,31012,default(StringOffset));
            offsets[9] = DRHelp.CreateDRHelp(fbb, 30007,fbb.CreateString("收集木箱"),3,fbb.CreateString("木箱"),12515,31001,fbb.CreateString("#{Help_1}"));
            offsets[10] = DRHelp.CreateDRHelp(fbb, 30008,fbb.CreateString("彩虹糖"),3,fbb.CreateString("彩虹糖"),12508,31006,fbb.CreateString("#{Help_6}"));
            offsets[11] = DRHelp.CreateDRHelp(fbb, 40001,fbb.CreateString("火箭"),4,fbb.CreateString("火箭"),12504,31000,fbb.CreateString("#{Guide_21}"));
            offsets[12] = DRHelp.CreateDRHelp(fbb, 40002,fbb.CreateString("炸弹"),4,fbb.CreateString("炸弹"),12507,31008,fbb.CreateString("#{Guide_1}"));

            VectorOffset dataOff = Table_Help.CreateDataVector(fbb, offsets);
            var configOff = Table_Help.CreateTable_Help(fbb, dataOff);
            Table_Help.FinishTable_HelpBuffer(fbb, configOff);
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