using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_Block : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Block.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRBlock>[] offsets = new Offset<DRBlock>[40];
   
            offsets[0] = DRBlock.CreateDRBlock(fbb, 0,fbb.CreateString("IBlock"),60001,10025,fbb.CreateString("NormalBlock"),true,true,true,27,true);
            offsets[1] = DRBlock.CreateDRBlock(fbb, 1,fbb.CreateString("JBlock"),60002,10026,fbb.CreateString("NormalBlock"),true,true,true,27,true);
            offsets[2] = DRBlock.CreateDRBlock(fbb, 2,fbb.CreateString("LBlock"),60003,10027,fbb.CreateString("NormalBlock"),true,true,true,27,true);
            offsets[3] = DRBlock.CreateDRBlock(fbb, 3,fbb.CreateString("OBlock"),60004,10028,fbb.CreateString("NormalBlock"),true,true,true,27,true);
            offsets[4] = DRBlock.CreateDRBlock(fbb, 4,fbb.CreateString("SBlock"),60005,10029,fbb.CreateString("NormalBlock"),true,true,true,27,true);
            offsets[5] = DRBlock.CreateDRBlock(fbb, 5,fbb.CreateString("TBlock"),60006,10030,fbb.CreateString("NormalBlock"),true,true,true,27,true);
            offsets[6] = DRBlock.CreateDRBlock(fbb, 6,fbb.CreateString("ZBlock"),60007,10031,fbb.CreateString("NormalBlock"),true,true,true,27,true);
            offsets[7] = DRBlock.CreateDRBlock(fbb, 7,fbb.CreateString("穿透块"),60008,10034,fbb.CreateString("PassBlock"),true,true,true,27,true);
            offsets[8] = DRBlock.CreateDRBlock(fbb, 8,fbb.CreateString("木箱底块"),60019,10047,fbb.CreateString("NormalBlock"),false,false,true,-1,true);
            offsets[9] = DRBlock.CreateDRBlock(fbb, 9,fbb.CreateString("HighlightBlock"),60020,-1,fbb.CreateString("NormalBlock"),false,false,true,-1,false);
            offsets[10] = DRBlock.CreateDRBlock(fbb, 10,fbb.CreateString("不可消除，可以移动"),60019,10046,fbb.CreateString("NormalBlock"),false,true,true,-1,true);
            offsets[11] = DRBlock.CreateDRBlock(fbb, 11,fbb.CreateString("不可消除，可以移动，不再BlockMap中"),60019,-1,fbb.CreateString("NormalBlock"),false,true,false,-1,false);
            offsets[12] = DRBlock.CreateDRBlock(fbb, 12,fbb.CreateString("方块投影"),60029,-1,fbb.CreateString("NormalBlock"),false,false,false,-1,false);
            offsets[13] = DRBlock.CreateDRBlock(fbb, 13,fbb.CreateString("金手指块"),60046,-1,fbb.CreateString("NormalBlock"),true,true,true,-1,false);
            offsets[14] = DRBlock.CreateDRBlock(fbb, 14,fbb.CreateString("果冻方块"),60047,10052,fbb.CreateString("NormalBlock"),true,true,true,-1,true);
            offsets[15] = DRBlock.CreateDRBlock(fbb, 15,fbb.CreateString("流星雨IBlock"),60001,-1,fbb.CreateString("NormalBlock"),true,true,true,61,false);
            offsets[16] = DRBlock.CreateDRBlock(fbb, 16,fbb.CreateString("流星雨JBlock"),60002,-1,fbb.CreateString("NormalBlock"),true,true,true,61,false);
            offsets[17] = DRBlock.CreateDRBlock(fbb, 17,fbb.CreateString("流星雨LBlock"),60003,-1,fbb.CreateString("NormalBlock"),true,true,true,61,false);
            offsets[18] = DRBlock.CreateDRBlock(fbb, 18,fbb.CreateString("流星雨OBlock"),60004,-1,fbb.CreateString("NormalBlock"),true,true,true,61,false);
            offsets[19] = DRBlock.CreateDRBlock(fbb, 19,fbb.CreateString("流星雨SBlock"),60005,-1,fbb.CreateString("NormalBlock"),true,true,true,61,false);
            offsets[20] = DRBlock.CreateDRBlock(fbb, 20,fbb.CreateString("流星雨TBlock"),60006,-1,fbb.CreateString("NormalBlock"),true,true,true,61,false);
            offsets[21] = DRBlock.CreateDRBlock(fbb, 21,fbb.CreateString("流星雨ZBlock"),60007,-1,fbb.CreateString("NormalBlock"),true,true,true,61,false);
            offsets[22] = DRBlock.CreateDRBlock(fbb, 22,fbb.CreateString("橡皮泥"),60017,-1,fbb.CreateString("NormalBlock"),true,true,true,-1,false);
            offsets[23] = DRBlock.CreateDRBlock(fbb, 23,fbb.CreateString("彩虹糖底块"),60062,-1,fbb.CreateString("NormalBlock"),true,true,true,-1,true);
            offsets[24] = DRBlock.CreateDRBlock(fbb, 24,fbb.CreateString("石头底块"),60019,10045,fbb.CreateString("NormalBlock"),true,false,true,-1,true);
            offsets[25] = DRBlock.CreateDRBlock(fbb, 25,fbb.CreateString("地鼠底块"),60062,-1,fbb.CreateString("NormalBlock"),true,true,true,-1,true);
            offsets[26] = DRBlock.CreateDRBlock(fbb, 26,fbb.CreateString("Iblock_提示位置"),60069,13017,fbb.CreateString("NormalBlock"),false,false,true,27,true);
            offsets[27] = DRBlock.CreateDRBlock(fbb, 27,fbb.CreateString("JBlock_提示位置"),60070,13018,fbb.CreateString("NormalBlock"),false,false,true,27,true);
            offsets[28] = DRBlock.CreateDRBlock(fbb, 28,fbb.CreateString("LBlock_提示位置"),60071,13019,fbb.CreateString("NormalBlock"),false,false,true,27,true);
            offsets[29] = DRBlock.CreateDRBlock(fbb, 29,fbb.CreateString("OBlock_提示位置"),60072,13020,fbb.CreateString("NormalBlock"),false,false,true,27,true);
            offsets[30] = DRBlock.CreateDRBlock(fbb, 30,fbb.CreateString("SBlock_提示位置"),60073,13021,fbb.CreateString("NormalBlock"),false,false,true,27,true);
            offsets[31] = DRBlock.CreateDRBlock(fbb, 31,fbb.CreateString("TBlock_提示位置"),60074,13022,fbb.CreateString("NormalBlock"),false,false,true,27,true);
            offsets[32] = DRBlock.CreateDRBlock(fbb, 32,fbb.CreateString("ZBlock_提示位置"),60075,13023,fbb.CreateString("NormalBlock"),false,true,true,27,true);
            offsets[33] = DRBlock.CreateDRBlock(fbb, 33,fbb.CreateString("Iblock_幽灵方块"),60076,13017,fbb.CreateString("NormalBlock"),false,true,true,27,false);
            offsets[34] = DRBlock.CreateDRBlock(fbb, 34,fbb.CreateString("JBlock_幽灵方块"),60077,13018,fbb.CreateString("NormalBlock"),false,true,true,27,false);
            offsets[35] = DRBlock.CreateDRBlock(fbb, 35,fbb.CreateString("LBlock_幽灵方块"),60078,13019,fbb.CreateString("NormalBlock"),false,true,true,27,false);
            offsets[36] = DRBlock.CreateDRBlock(fbb, 36,fbb.CreateString("OBlock_幽灵方块"),60079,13020,fbb.CreateString("NormalBlock"),false,true,true,27,false);
            offsets[37] = DRBlock.CreateDRBlock(fbb, 37,fbb.CreateString("SBlock_幽灵方块"),60080,13021,fbb.CreateString("NormalBlock"),false,true,true,27,false);
            offsets[38] = DRBlock.CreateDRBlock(fbb, 38,fbb.CreateString("TBlock_幽灵方块"),60081,13022,fbb.CreateString("NormalBlock"),false,true,true,27,false);
            offsets[39] = DRBlock.CreateDRBlock(fbb, 39,fbb.CreateString("ZBlock_幽灵方块"),60082,13023,fbb.CreateString("NormalBlock"),false,true,true,27,false);

            VectorOffset dataOff = Table_Block.CreateDataVector(fbb, offsets);
            var configOff = Table_Block.CreateTable_Block(fbb, dataOff);
            Table_Block.FinishTable_BlockBuffer(fbb, configOff);
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