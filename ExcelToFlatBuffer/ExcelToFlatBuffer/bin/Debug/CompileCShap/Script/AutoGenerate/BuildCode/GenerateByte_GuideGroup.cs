using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_GuideGroup : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_GuideGroup.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRGuideGroup>[] offsets = new Offset<DRGuideGroup>[2];
   
            offsets[0] = DRGuideGroup.CreateDRGuideGroup(fbb, 1,fbb.CreateString("第1组"),-1,2,-1,-1,-1,fbb.CreateString("1:2:3:4:5:6:7:8:9:101:102:103:10:60001:60003:60004:105"),0,fbb.CreateString("11:13"),1,fbb.CreateString("14"),-1,fbb.CreateString("null"),fbb.CreateString("null"),-1,-1,-1,1,0,0);
            offsets[1] = DRGuideGroup.CreateDRGuideGroup(fbb, 2,fbb.CreateString("第2组"),-1,3,-1,-1,-1,fbb.CreateString("213:214:215:216:219:220:331:222:333:334:338:339:340:342"),0,fbb.CreateString("108"),1,fbb.CreateString("107"),0,fbb.CreateString("3|4"),fbb.CreateString("10001|10002:10003:10004"),-1,-1,-1,2,1,0);

            VectorOffset dataOff = Table_GuideGroup.CreateDataVector(fbb, offsets);
            var configOff = Table_GuideGroup.CreateTable_GuideGroup(fbb, dataOff);
            Table_GuideGroup.FinishTable_GuideGroupBuffer(fbb, configOff);
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