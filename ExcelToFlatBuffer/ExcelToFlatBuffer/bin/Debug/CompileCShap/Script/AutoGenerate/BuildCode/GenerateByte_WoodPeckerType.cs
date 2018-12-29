using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_WoodPeckerType : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_WoodPeckerType.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRWoodPeckerType>[] offsets = new Offset<DRWoodPeckerType>[14];
   
            offsets[0] = DRWoodPeckerType.CreateDRWoodPeckerType(fbb, 100120,fbb.CreateString("12关数量"),0,5,-1,1,1,-1,fbb.CreateString("-1"),fbb.CreateString("(0,0,0,1,0,0,0)"),fbb.CreateString("0|0|0|1|0|4|0"),fbb.CreateString("0|0|0|999|0|3|0"),fbb.CreateString("-1"),fbb.CreateString("-1"),fbb.CreateString("-1"),-1);
            offsets[1] = DRWoodPeckerType.CreateDRWoodPeckerType(fbb, 100131,fbb.CreateString("13关第1屏回合"),1,2,2,-1,-1,1,fbb.CreateString("(4,0,0)"),fbb.CreateString("(0,0,0,1,0,0,0)"),fbb.CreateString("0|0|0|2|0|0|0"),fbb.CreateString("-1"),fbb.CreateString("0|3"),fbb.CreateString("1|1"),fbb.CreateString("(0,0,0,1,0,0,0)|(0,0,0,1,0,0,0)|"),100132);
            offsets[2] = DRWoodPeckerType.CreateDRWoodPeckerType(fbb, 100132,fbb.CreateString("13关第2屏回合"),1,-1,3,-1,-1,1,fbb.CreateString("(4,1,0)"),fbb.CreateString("(0,1,0,0,0,0,0)"),fbb.CreateString("0|1|0|0|2|0|0"),fbb.CreateString("-1"),fbb.CreateString("0|3|6"),fbb.CreateString("1|1|1"),fbb.CreateString("(0,1,0,0,0,0,0)|(0,0,0,0,1,0,0)|(0,0,0,0,1,0,0)|"),-1);
            offsets[3] = DRWoodPeckerType.CreateDRWoodPeckerType(fbb, 100140,fbb.CreateString("14关回合"),1,-1,4,-1,-1,1,fbb.CreateString("(1,1,0)"),fbb.CreateString("(0,0,0,1,0,0,0)"),fbb.CreateString("0|0|0|2|0|4|0"),fbb.CreateString("-1"),fbb.CreateString("0|3|6|9"),fbb.CreateString("1|1|2|2"),fbb.CreateString("(0,0,0,1,0,0,0)|(0,0,0,1,0,0,0)|(0,0,0,1,0,0,0)|(0,0,0,1,0,0,0)|"),-1);
            offsets[4] = DRWoodPeckerType.CreateDRWoodPeckerType(fbb, 100150,fbb.CreateString("15关数量"),0,6,-1,2,1,-1,fbb.CreateString("-1"),fbb.CreateString("(0,0,0,0,1,0,0)"),fbb.CreateString("0|0|0|0|4|0|2"),fbb.CreateString("0|0|0|0|999|0|1"),fbb.CreateString("-1"),fbb.CreateString("-1"),fbb.CreateString("-1"),-1);
            offsets[5] = DRWoodPeckerType.CreateDRWoodPeckerType(fbb, 100161,fbb.CreateString("16关第1屏回合"),1,3,2,-1,-1,-1,fbb.CreateString("-1"),fbb.CreateString("-1"),fbb.CreateString("0|0|1|2|0|0|0"),fbb.CreateString("0|0|999|1|0|0|0"),fbb.CreateString("1|4"),fbb.CreateString("2|1"),fbb.CreateString("-1"),100162);
            offsets[6] = DRWoodPeckerType.CreateDRWoodPeckerType(fbb, 100162,fbb.CreateString("16关第2屏回合"),1,3,2,-1,-1,-1,fbb.CreateString("-1"),fbb.CreateString("-1"),fbb.CreateString("0|0|0|1|0|0|2"),fbb.CreateString("0|0|999|0|0|0|1"),fbb.CreateString("3|6"),fbb.CreateString("1|2"),fbb.CreateString("-1"),-1);
            offsets[7] = DRWoodPeckerType.CreateDRWoodPeckerType(fbb, 100170,fbb.CreateString("17关回合"),1,4,3,-1,-1,-1,fbb.CreateString("-1"),fbb.CreateString("(0,0,0,0,0,0,1)"),fbb.CreateString("0|0|0|2|0|0|2"),fbb.CreateString("0|0|0|0|1|0|1"),fbb.CreateString("1|6|11"),fbb.CreateString("1|1|2"),fbb.CreateString("-1"),-1);
            offsets[8] = DRWoodPeckerType.CreateDRWoodPeckerType(fbb, 100181,fbb.CreateString("18关"),1,6,4,-1,-1,-1,fbb.CreateString("-1"),fbb.CreateString("-1"),fbb.CreateString("0|2|2|2|0|0|0"),fbb.CreateString("0|100|100|100|0|0|0"),fbb.CreateString("1|2|3|5"),fbb.CreateString("2|1|1|2"),fbb.CreateString("(0,2,0,0,0,0,0)|(0,0,1,0,0,0,0)|(0,0,0,1,0,0,0)|(0,0,0,0,2,0,0)|"),-1);
            offsets[9] = DRWoodPeckerType.CreateDRWoodPeckerType(fbb, 100191,fbb.CreateString("19关"),1,6,3,-1,-1,-1,fbb.CreateString("-1"),fbb.CreateString("-1"),fbb.CreateString("4|0|0|2|0|0|0"),fbb.CreateString("100|0|0|100|0|0|0"),fbb.CreateString("3|6|9"),fbb.CreateString("2|2|2"),fbb.CreateString("(2,0,0,0,0,0,0)|(2,0,0,0,0,0,0)|(0,0,0,2,0,0,0)"),-1);
            offsets[10] = DRWoodPeckerType.CreateDRWoodPeckerType(fbb, 100201,fbb.CreateString("20关"),1,6,3,-1,-1,-1,fbb.CreateString("-1"),fbb.CreateString("-1"),fbb.CreateString("4|0|0|2|0|0|0"),fbb.CreateString("100|0|0|100|0|0|0"),fbb.CreateString("3|6|9"),fbb.CreateString("2|2|2"),fbb.CreateString("(2,0,0,0,0,0,0)|(2,0,0,0,0,0,0)|(0,0,0,2,0,0,0)"),-1);
            offsets[11] = DRWoodPeckerType.CreateDRWoodPeckerType(fbb, 100251,fbb.CreateString("25关"),1,6,3,-1,-1,-1,fbb.CreateString("-1"),fbb.CreateString("-1"),fbb.CreateString("6|0|0|0|0|0|0"),fbb.CreateString("100|0|0|0|0|0|0"),fbb.CreateString("3|6|9"),fbb.CreateString("2|2|2"),fbb.CreateString("(2,0,0,0,0,0,0)|(2,0,0,0,0,0,0)|(2,0,0,0,0,0,0)"),-1);
            offsets[12] = DRWoodPeckerType.CreateDRWoodPeckerType(fbb, 100261,fbb.CreateString("26关"),1,6,3,-1,-1,-1,fbb.CreateString("-1"),fbb.CreateString("-1"),fbb.CreateString("6|0|0|0|0|0|0"),fbb.CreateString("100|0|0|0|0|0|0"),fbb.CreateString("3|6|9"),fbb.CreateString("2|2|2"),fbb.CreateString("(2,0,0,0,0,0,0)|(2,0,0,0,0,0,0)|(2,0,0,0,0,0,0)"),-1);
            offsets[13] = DRWoodPeckerType.CreateDRWoodPeckerType(fbb, 100271,fbb.CreateString("27关"),1,6,3,-1,-1,-1,fbb.CreateString("-1"),fbb.CreateString("-1"),fbb.CreateString("6|0|0|0|0|0|0"),fbb.CreateString("100|0|0|0|0|0|0"),fbb.CreateString("3|6|9"),fbb.CreateString("2|2|2"),fbb.CreateString("(2,0,0,0,0,0,0)|(2,0,0,0,0,0,0)|(2,0,0,0,0,0,0)"),-1);

            VectorOffset dataOff = Table_WoodPeckerType.CreateDataVector(fbb, offsets);
            var configOff = Table_WoodPeckerType.CreateTable_WoodPeckerType(fbb, dataOff);
            Table_WoodPeckerType.FinishTable_WoodPeckerTypeBuffer(fbb, configOff);
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