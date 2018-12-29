using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_Story : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Story.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRStory>[] offsets = new Offset<DRStory>[11];
   
            offsets[0] = DRStory.CreateDRStory(fbb, 1,fbb.CreateString("测试剧情"),fbb.CreateString("DialogueStoryDemo"),fbb.CreateString("0:TRUE|5:TRUE|10:TRUE|15:TRUE|20:TRUE|25:TRUE|30:TRUE|35:TRUE|40:TRUE|45:TRUE"),fbb.CreateString("0:0:0:-1|1:0:2:-1|2:1:(43.36,15.392,75.69):-1|3:0:1:-1|4:0:3:-1|5:0:4:-1|6:0:5:-1|7:3:FALSE:-1|8:4:(1,40007):-1"),fbb.CreateString("0:2:0|1:1:(29.21,15.392,78.15)"),fbb.CreateString("3.5:2|8:3|13:4"));
            offsets[1] = DRStory.CreateDRStory(fbb, 2,fbb.CreateString("任务1驱散黑雾"),fbb.CreateString("story0101"),fbb.CreateString("0:TRUE|13:TRUE|16:TRUE|27:TRUE|34:TRUE|46:TRUE|50:TRUE|53:TRUE|58:TRUE|60:TRUE|65:TRUE"),fbb.CreateString("0:0:1:-1:把WeilanOld.prefab中的XZL_WeiLanOld物体绑定到timeline的Track 1上|1:0:2:-1|2:0:3:-1|3:0:4:-1|4:0:5:-1|5:0:6:-1|6:0:7:-1|7:0:8:-1|8:0:9:-1|9:0:10:-1|10:0:11:-1"),default(StringOffset),default(StringOffset));
            offsets[2] = DRStory.CreateDRStory(fbb, 3,fbb.CreateString("任务2修复围栏"),fbb.CreateString("story0102"),fbb.CreateString("0:TRUE|13:TRUE|16:TRUE|18:TRUE|23:TRUE|27:TRUE|32:TRUE|40:TRUE|45:TRUE|48:TRUE|53:TRUE|60:TRUE|65:TRUE"),fbb.CreateString("0:0:1:-1|1:0:2:-1|2:0:3:0|3:0:4:0|4:0:5:0|5:0:6:-1|6:0:7:-1|7:0:8:-1"),default(StringOffset),default(StringOffset));
            offsets[3] = DRStory.CreateDRStory(fbb, 4,fbb.CreateString("任务3拔除杂草"),fbb.CreateString("story0103"),fbb.CreateString("0:TRUE|10:TRUE|18:TRUE|24:TRUE|26.5:TRUE"),fbb.CreateString("0:0:2:-1|1:3:FALSE:-1"),default(StringOffset),default(StringOffset));
            offsets[4] = DRStory.CreateDRStory(fbb, 5,fbb.CreateString("任务4修复花圃"),fbb.CreateString("story0104"),fbb.CreateString("0:TRUE|13.7:TRUE|16.7:TRUE|18.7:TRUE|26.7:TRUE|29:TRUE|32:TRUE"),fbb.CreateString("0:0:5:-1|1:0:1:-1|2:0:2:0|3:0:3:0|4:0:4:0"),default(StringOffset),default(StringOffset));
            offsets[5] = DRStory.CreateDRStory(fbb, 6,fbb.CreateString("任务5制作长椅"),fbb.CreateString("story0105"),fbb.CreateString("0:TRUE|12:TRUE|22:TRUE|24:TRUE|32:TRUE|38:TRUE|47:TRUE|49:TRUE|55:TRUE|70:TRUE|76:TRUE|60:TRUE|65:TRUE"),fbb.CreateString("0:0:1:-1|1:0:2:-1|2:0:3:0|3:0:4:0|4:0:5:0"),default(StringOffset),default(StringOffset));
            offsets[6] = DRStory.CreateDRStory(fbb, 7,fbb.CreateString("任务6修复路灯"),fbb.CreateString("story0106"),fbb.CreateString("0:TRUE|30:TRUE|33:TRUE|40:TRUE|42:TRUE|47:TRUE|57:TRUE"),fbb.CreateString("0:0:1:-1|2:0:2:0|3:0:3:0|4:0:4:0|5:0:5:0|6:0:6:0|7:0:7:0|8:0:8:-1|9:0:9:-1"),default(StringOffset),default(StringOffset));
            offsets[7] = DRStory.CreateDRStory(fbb, 8,fbb.CreateString("任务7魔法园艺"),fbb.CreateString("story0107"),fbb.CreateString("0:TRUE|9:TRUE|11:TRUE|14:TRUE|22:TRUE|27:TRUE|30:TRUE|39:TRUE|43:TRUE"),fbb.CreateString("0:0:1:-1|1:0:2:-1|2:0:3:0|3:0:4:0|4:0:5:0"),default(StringOffset),default(StringOffset));
            offsets[8] = DRStory.CreateDRStory(fbb, 9,fbb.CreateString("任务8铺平道路"),fbb.CreateString("story0108"),fbb.CreateString("0:TRUE|10:TRUE|14:TRUE|23:TRUE|40.5:TRUE"),fbb.CreateString("0:0:1:-1|1:0:2:-1|2:0:3:-1|3:0:4:-1|4:0:5:-1"),default(StringOffset),default(StringOffset));
            offsets[9] = DRStory.CreateDRStory(fbb, 10,fbb.CreateString("任务9装饰世界树"),fbb.CreateString("story0109"),fbb.CreateString("0:TRUE|10.01:TRUE|17:TRUE|22:TRUE|25:TRUE|30:TRUE|32:TRUE|46:TRUE|47:TRUE"),fbb.CreateString("0:0:2:-1|1:0:3:-1|2:0:4:-1"),default(StringOffset),default(StringOffset));
            offsets[10] = DRStory.CreateDRStory(fbb, 11,fbb.CreateString("任务10架起桥梁"),fbb.CreateString("story0110"),fbb.CreateString("0:TRUE|6:TRUE|7.98:TRUE|13.21:TRUE|18.98:TRUE|20.98:TRUE|27.55:TRUE"),fbb.CreateString("0:0:2:-1|1:0:1:-1"),default(StringOffset),default(StringOffset));

            VectorOffset dataOff = Table_Story.CreateDataVector(fbb, offsets);
            var configOff = Table_Story.CreateTable_Story(fbb, dataOff);
            Table_Story.FinishTable_StoryBuffer(fbb, configOff);
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