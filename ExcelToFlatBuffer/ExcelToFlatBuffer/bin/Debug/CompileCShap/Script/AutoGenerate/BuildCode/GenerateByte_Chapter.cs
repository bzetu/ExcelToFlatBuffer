using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_Chapter : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Chapter.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRChapter>[] offsets = new Offset<DRChapter>[4];
   
            offsets[0] = DRChapter.CreateDRChapter(fbb, 1,fbb.CreateString("仙踪林"),fbb.CreateString("仙踪林"),20,45f,20f,25f,-30f,65f,35f,10f,0.02f);
            offsets[1] = DRChapter.CreateDRChapter(fbb, 2,fbb.CreateString("晶莹谷"),fbb.CreateString("晶莹谷"),30,45f,20f,25f,-40f,65f,35f,10f,0.02f);
            offsets[2] = DRChapter.CreateDRChapter(fbb, 3,fbb.CreateString("琥珀城堡"),fbb.CreateString("琥珀城堡"),40,45f,20f,25f,-55f,65f,35f,10f,0.02f);
            offsets[3] = DRChapter.CreateDRChapter(fbb, 4,fbb.CreateString("阿格拉巴"),fbb.CreateString("阿格拉巴"),35,45f,20f,25f,-55f,65f,35f,10f,0.02f);

            VectorOffset dataOff = Table_Chapter.CreateDataVector(fbb, offsets);
            var configOff = Table_Chapter.CreateTable_Chapter(fbb, dataOff);
            Table_Chapter.FinishTable_ChapterBuffer(fbb, configOff);
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