using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameTable;

namespace CompileCShap
{
    public class GenerateByte_Block : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Block.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRBlock>[] offsets = new Offset<DRBlock>[10];
   
            offsets[0] = DRBlock.CreateDRBlock(fbb, 0,fbb.CreateString("IBlock"),60001,10025,fbb.CreateString("NormalBlock"),true,true,true,27,true);
            offsets[1] = DRBlock.CreateDRBlock(fbb, 1,fbb.CreateString("JBlock"),60002,10026,fbb.CreateString("NormalBlock"),true,true,true,27,true);
            offsets[2] = DRBlock.CreateDRBlock(fbb, 2,fbb.CreateString("LBlock"),60003,10027,fbb.CreateString("NormalBlock"),true,true,true,27,true);
            offsets[3] = DRBlock.CreateDRBlock(fbb, 3,fbb.CreateString("OBlock"),60004,10028,fbb.CreateString("NormalBlock"),true,true,true,27,true);
            offsets[4] = DRBlock.CreateDRBlock(fbb, 4,fbb.CreateString("SBlock"),60005,10029,fbb.CreateString("NormalBlock"),true,true,true,27,true);
            offsets[5] = DRBlock.CreateDRBlock(fbb, 5,fbb.CreateString("TBlock"),60006,10030,fbb.CreateString("NormalBlock"),true,true,true,27,true);
            offsets[6] = DRBlock.CreateDRBlock(fbb, 6,fbb.CreateString("ZBlock"),60007,10031,fbb.CreateString("NormalBlock"),true,true,true,27,true);

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