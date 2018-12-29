using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_BlockScore : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_BlockScore.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRBlockScore>[] offsets = new Offset<DRBlockScore>[13];
   
            offsets[0] = DRBlockScore.CreateDRBlockScore(fbb, 0,fbb.CreateString("IBlock"),10,fbb.CreateString("#a9e1f8"));
            offsets[1] = DRBlockScore.CreateDRBlockScore(fbb, 1,fbb.CreateString("JBlock"),10,fbb.CreateString("#68afff"));
            offsets[2] = DRBlockScore.CreateDRBlockScore(fbb, 2,fbb.CreateString("LBlock"),10,fbb.CreateString("#f6a54e"));
            offsets[3] = DRBlockScore.CreateDRBlockScore(fbb, 3,fbb.CreateString("OBlock"),10,fbb.CreateString("#faec53"));
            offsets[4] = DRBlockScore.CreateDRBlockScore(fbb, 4,fbb.CreateString("SBlock"),10,fbb.CreateString("#3afd92"));
            offsets[5] = DRBlockScore.CreateDRBlockScore(fbb, 5,fbb.CreateString("TBlock"),10,fbb.CreateString("#f8a9f7"));
            offsets[6] = DRBlockScore.CreateDRBlockScore(fbb, 6,fbb.CreateString("ZBlock"),10,fbb.CreateString("#ef8383"));
            offsets[7] = DRBlockScore.CreateDRBlockScore(fbb, 7,fbb.CreateString("橡皮泥"),50,fbb.CreateString("#FFFF00"));
            offsets[8] = DRBlockScore.CreateDRBlockScore(fbb, 8,fbb.CreateString("不可普通消除的"),50,fbb.CreateString("#FFFF00"));
            offsets[9] = DRBlockScore.CreateDRBlockScore(fbb, 9,fbb.CreateString("HighlightBlock"),50,fbb.CreateString("#FFFF00"));
            offsets[10] = DRBlockScore.CreateDRBlockScore(fbb, 10,fbb.CreateString("不可消除，可以移动"),50,fbb.CreateString("#FFFF00"));
            offsets[11] = DRBlockScore.CreateDRBlockScore(fbb, 11,fbb.CreateString("不可消除，可以移动，不再BlockMap中"),50,fbb.CreateString("#FFFF00"));
            offsets[12] = DRBlockScore.CreateDRBlockScore(fbb, 12,fbb.CreateString("方块投影"),50,fbb.CreateString("#FFFF00"));

            VectorOffset dataOff = Table_BlockScore.CreateDataVector(fbb, offsets);
            var configOff = Table_BlockScore.CreateTable_BlockScore(fbb, dataOff);
            Table_BlockScore.FinishTable_BlockScoreBuffer(fbb, configOff);
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