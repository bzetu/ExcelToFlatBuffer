using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_GuideNewPlayStep : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_GuideNewPlayStep.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRGuideNewPlayStep>[] offsets = new Offset<DRGuideNewPlayStep>[22];
   
            offsets[0] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 1,fbb.CreateString("目标指引"),3,0,0,1,2,0,fbb.CreateString("0"),fbb.CreateString("0|0"),fbb.CreateString("0"),0,fbb.CreateString("#{NewPlayGuide_Tartget}"),default(StringOffset),1,true,true);
            offsets[1] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 2,fbb.CreateString("元素指引"),4,0,0,2,0,0,fbb.CreateString("1|4"),fbb.CreateString("0|0"),fbb.CreateString("0"),0,fbb.CreateString("#{NewPlayGuide_Element}"),default(StringOffset),1,true,true);
            offsets[2] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 3,fbb.CreateString("道具指引"),2,200,0,2,0,0,fbb.CreateString("0"),fbb.CreateString("0|0"),fbb.CreateString("0"),0,fbb.CreateString("#{NewPlayGuide_Prop}"),default(StringOffset),1,true,true);
            offsets[3] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 4,fbb.CreateString("携带元素指引"),4,0,0,12,0,0,fbb.CreateString("0"),fbb.CreateString("0|0"),fbb.CreateString("0"),0,fbb.CreateString("#{NewPlayGuide_Element}"),default(StringOffset),1,true,true);
            offsets[4] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 5,fbb.CreateString("元素指引"),1,0,5000,31001,0,0,fbb.CreateString("1|4"),fbb.CreateString("0"),fbb.CreateString("0"),0,fbb.CreateString("0"),fbb.CreateString("0"),1,true,true);
            offsets[5] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 6,fbb.CreateString("目标指引"),3,0,0,1,0,0,fbb.CreateString("0"),fbb.CreateString("0|0"),fbb.CreateString("0"),0,fbb.CreateString("#{NewPlayGuide_Tartget}"),default(StringOffset),1,true,true);
            offsets[6] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 7,fbb.CreateString("元素指引_火箭"),1,0,2000,31000,0,0,fbb.CreateString("1|4"),fbb.CreateString("0"),fbb.CreateString("0"),0,fbb.CreateString("#{Guide_21}"),fbb.CreateString("#{Element_1}"),1,true,true);
            offsets[7] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 8,fbb.CreateString("元素指引_收集木箱"),1,0,2000,31001,0,0,fbb.CreateString("1|4"),fbb.CreateString("0"),fbb.CreateString("0"),0,fbb.CreateString("#{Help_1}"),fbb.CreateString("#{Element_2}"),1,true,true);
            offsets[8] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 9,fbb.CreateString("元素指引_加步数"),1,0,2000,31002,0,0,fbb.CreateString("1|4"),fbb.CreateString("0"),fbb.CreateString("0"),0,fbb.CreateString("#{Help_2}"),fbb.CreateString("#{Element_3}"),1,true,true);
            offsets[9] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 10,fbb.CreateString("元素指引_冰块"),1,0,2000,31003,0,0,fbb.CreateString("1|4"),fbb.CreateString("0"),fbb.CreateString("0"),0,fbb.CreateString("#{Help_3}"),fbb.CreateString("#{Element_4}"),1,true,true);
            offsets[10] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 11,fbb.CreateString("元素指引_石块"),1,0,2000,31004,0,0,fbb.CreateString("1|4"),fbb.CreateString("0"),fbb.CreateString("0"),0,fbb.CreateString("#{Help_4}"),fbb.CreateString("#{Element_5}"),1,true,true);
            offsets[11] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 12,fbb.CreateString("元素指引_睡美人"),1,0,2000,31005,0,0,fbb.CreateString("1|4"),fbb.CreateString("0"),fbb.CreateString("0"),0,fbb.CreateString("#{Help_5}"),fbb.CreateString("#{Element_6}"),1,true,true);
            offsets[12] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 13,fbb.CreateString("元素指引_彩虹糖"),1,0,2000,31006,0,0,fbb.CreateString("1|4"),fbb.CreateString("0"),fbb.CreateString("0"),0,fbb.CreateString("#{Help_6}"),fbb.CreateString("#{Element_7}"),1,true,true);
            offsets[13] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 14,fbb.CreateString("元素指引_幽灵"),1,0,2000,31007,0,0,fbb.CreateString("1|4"),fbb.CreateString("0"),fbb.CreateString("0"),0,fbb.CreateString("#{Help_7}"),fbb.CreateString("#{Element_8}"),1,true,true);
            offsets[14] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 15,fbb.CreateString("元素指引_炸弹"),1,0,2000,31008,0,0,fbb.CreateString("1|4"),fbb.CreateString("0"),fbb.CreateString("0"),0,fbb.CreateString("#{Guide_1}"),fbb.CreateString("#{Element_9}"),1,true,true);
            offsets[15] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 16,fbb.CreateString("元素指引_穿透块"),1,0,2000,31009,0,0,fbb.CreateString("1|4"),fbb.CreateString("0"),fbb.CreateString("0"),0,fbb.CreateString("#{Help_8}"),fbb.CreateString("#{Element_10}"),1,true,true);
            offsets[16] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 17,fbb.CreateString("元素指引_染色瓶"),1,0,2000,31010,0,0,fbb.CreateString("1|4"),fbb.CreateString("0"),fbb.CreateString("0"),0,fbb.CreateString("#{Help_9}"),fbb.CreateString("#{Element_11}"),1,true,true);
            offsets[17] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 18,fbb.CreateString("元素指引_地鼠"),1,0,2000,31011,0,0,fbb.CreateString("1|4"),fbb.CreateString("0"),fbb.CreateString("0"),0,fbb.CreateString("#{Help_10}"),fbb.CreateString("#{Element_12}"),1,true,true);
            offsets[18] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 19,fbb.CreateString("元素指引_小鹰快跑"),1,0,2000,31012,0,0,fbb.CreateString("1|4"),fbb.CreateString("0"),fbb.CreateString("0"),0,default(StringOffset),fbb.CreateString("#{Element_13}"),1,true,true);
            offsets[19] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 20,fbb.CreateString("道具指引_万能块"),2,200,0,1,0,1,fbb.CreateString("0"),fbb.CreateString("102|-371"),fbb.CreateString("435|-376"),0,fbb.CreateString("#{NewPlayGuide_Prop_1}"),default(StringOffset),3,true,true);
            offsets[20] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 21,fbb.CreateString("浮空块引导"),5,0,0,0,0,0,fbb.CreateString("0"),fbb.CreateString("0|400"),fbb.CreateString("0"),0,fbb.CreateString("#{Guide_Float_Block_1}"),fbb.CreateString("0"),1,false,false);
            offsets[21] = DRGuideNewPlayStep.CreateDRGuideNewPlayStep(fbb, 22,fbb.CreateString("自由落体引导"),5,0,0,0,0,0,fbb.CreateString("0"),fbb.CreateString("0|400"),fbb.CreateString("0"),0,fbb.CreateString("#{Guide_Float_Block_2}"),fbb.CreateString("0"),1,false,true);

            VectorOffset dataOff = Table_GuideNewPlayStep.CreateDataVector(fbb, offsets);
            var configOff = Table_GuideNewPlayStep.CreateTable_GuideNewPlayStep(fbb, dataOff);
            Table_GuideNewPlayStep.FinishTable_GuideNewPlayStepBuffer(fbb, configOff);
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