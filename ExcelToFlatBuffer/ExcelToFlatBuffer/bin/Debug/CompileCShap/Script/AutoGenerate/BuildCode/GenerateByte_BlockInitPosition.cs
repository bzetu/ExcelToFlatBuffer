using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_BlockInitPosition : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_BlockInitPosition.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRBlockInitPosition>[] offsets = new Offset<DRBlockInitPosition>[8];
   
            offsets[0] = DRBlockInitPosition.CreateDRBlockInitPosition(fbb, 0,fbb.CreateString("IBlock"),DRBlockInitPosition.CreateInitPosVector(fbb, new StringOffset[] { fbb.CreateString("3.5;13.5"),fbb.CreateString("3.5;13.5"),fbb.CreateString("3.5;13.5"),fbb.CreateString("3.5;13.5") }));
            offsets[1] = DRBlockInitPosition.CreateDRBlockInitPosition(fbb, 1,fbb.CreateString("JBlock"),DRBlockInitPosition.CreateInitPosVector(fbb, new StringOffset[] { fbb.CreateString("4;14"),fbb.CreateString("4;14"),fbb.CreateString("4;14"),fbb.CreateString("4;14") }));
            offsets[2] = DRBlockInitPosition.CreateDRBlockInitPosition(fbb, 2,fbb.CreateString("LBlock"),DRBlockInitPosition.CreateInitPosVector(fbb, new StringOffset[] { fbb.CreateString("4;14"),fbb.CreateString("4;14"),fbb.CreateString("4;14"),fbb.CreateString("4;14") }));
            offsets[3] = DRBlockInitPosition.CreateDRBlockInitPosition(fbb, 3,fbb.CreateString("OBlock"),DRBlockInitPosition.CreateInitPosVector(fbb, new StringOffset[] { fbb.CreateString("3.5;14.5"),fbb.CreateString("3.5;14.5"),fbb.CreateString("3.5;14.5"),fbb.CreateString("3.5;14.5") }));
            offsets[4] = DRBlockInitPosition.CreateDRBlockInitPosition(fbb, 4,fbb.CreateString("SBlock"),DRBlockInitPosition.CreateInitPosVector(fbb, new StringOffset[] { fbb.CreateString("4;14"),fbb.CreateString("4;14"),fbb.CreateString("4;14"),fbb.CreateString("4;14") }));
            offsets[5] = DRBlockInitPosition.CreateDRBlockInitPosition(fbb, 5,fbb.CreateString("TBlock"),DRBlockInitPosition.CreateInitPosVector(fbb, new StringOffset[] { fbb.CreateString("4;14"),fbb.CreateString("4;14"),fbb.CreateString("4;14"),fbb.CreateString("4;14") }));
            offsets[6] = DRBlockInitPosition.CreateDRBlockInitPosition(fbb, 6,fbb.CreateString("ZBlock"),DRBlockInitPosition.CreateInitPosVector(fbb, new StringOffset[] { fbb.CreateString("4;14"),fbb.CreateString("4;14"),fbb.CreateString("4;14"),fbb.CreateString("4;14") }));
            offsets[7] = DRBlockInitPosition.CreateDRBlockInitPosition(fbb, 22,fbb.CreateString("PBlock"),DRBlockInitPosition.CreateInitPosVector(fbb, new StringOffset[] { fbb.CreateString("4;15"),fbb.CreateString("4;15"),fbb.CreateString("4;15"),fbb.CreateString("4;15") }));

            VectorOffset dataOff = Table_BlockInitPosition.CreateDataVector(fbb, offsets);
            var configOff = Table_BlockInitPosition.CreateTable_BlockInitPosition(fbb, dataOff);
            Table_BlockInitPosition.FinishTable_BlockInitPositionBuffer(fbb, configOff);
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