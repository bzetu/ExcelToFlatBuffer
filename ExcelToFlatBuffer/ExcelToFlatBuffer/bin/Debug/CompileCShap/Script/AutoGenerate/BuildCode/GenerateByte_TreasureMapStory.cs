using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_TreasureMapStory : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_TreasureMapStory.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRTreasureMapStory>[] offsets = new Offset<DRTreasureMapStory>[6];
   
            offsets[0] = DRTreasureMapStory.CreateDRTreasureMapStory(fbb, 1,fbb.CreateString("1"),fbb.CreateString("不愧是童话命运选定的那个人，只有你能这么快就找到它！"));
            offsets[1] = DRTreasureMapStory.CreateDRTreasureMapStory(fbb, 2,fbb.CreateString("1"),fbb.CreateString("你好厉害，在这些虚虚实实的线索中找到了真实的那个，我对你接下来的表现充满信心哦！"));
            offsets[2] = DRTreasureMapStory.CreateDRTreasureMapStory(fbb, 3,fbb.CreateString("1"),fbb.CreateString("自从奇幻乐园不再生产快乐，我就没有开心过，但是好神奇，在你身边的时候，我能感受到快乐！"));
            offsets[3] = DRTreasureMapStory.CreateDRTreasureMapStory(fbb, 4,fbb.CreateString("1"),fbb.CreateString("据说藏宝图记录了一个很大的宝藏，也不知道究竟是什么，好期待你的发现啊！"));
            offsets[4] = DRTreasureMapStory.CreateDRTreasureMapStory(fbb, 5,fbb.CreateString("1"),fbb.CreateString("红心女王好像知道了我们在寻找藏宝图，一定会派人来搞破坏，我们要抓紧时间呀！"));
            offsets[5] = DRTreasureMapStory.CreateDRTreasureMapStory(fbb, 6,fbb.CreateString("1"),fbb.CreateString("碎片都收集齐了，我们马上就能找到奇幻乐园的入口啦，童话世界有救了！"));

            VectorOffset dataOff = Table_TreasureMapStory.CreateDataVector(fbb, offsets);
            var configOff = Table_TreasureMapStory.CreateTable_TreasureMapStory(fbb, dataOff);
            Table_TreasureMapStory.FinishTable_TreasureMapStoryBuffer(fbb, configOff);
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