using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_Susliks : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Susliks.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRSusliks>[] offsets = new Offset<DRSusliks>[10];
   
            offsets[0] = DRSusliks.CreateDRSusliks(fbb, 0,fbb.CreateString("81关地鼠"),81,2,DRSusliks.CreateGrounpVector(fbb, new StringOffset[] { fbb.CreateString("1,2,1"),fbb.CreateString("3,2,1"),fbb.CreateString("5,2,1"),fbb.CreateString("7,2,1"),fbb.CreateString("9,2,1"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[1] = DRSusliks.CreateDRSusliks(fbb, 1,fbb.CreateString("82关地鼠"),82,2,DRSusliks.CreateGrounpVector(fbb, new StringOffset[] { fbb.CreateString("2,2,1"),fbb.CreateString("4,2,1"),fbb.CreateString("6,2,1"),fbb.CreateString("8,2,1"),fbb.CreateString("2,2,1|4,2,1|6,2,1|8,2,1"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[2] = DRSusliks.CreateDRSusliks(fbb, 2,fbb.CreateString("83关地鼠"),83,2,DRSusliks.CreateGrounpVector(fbb, new StringOffset[] { fbb.CreateString("5,2,1"),fbb.CreateString("3,2,1|5,2,1|7,2,1"),fbb.CreateString("1,2,1|3,2,1|5,2,1|7,2,1|9,2,1"),fbb.CreateString("1,2,1|3,2,1|5,2,1|7,2,1|9,2,1"),fbb.CreateString("1,2,1|3,2,1|5,2,1|7,2,1|9,2,1"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[3] = DRSusliks.CreateDRSusliks(fbb, 3,fbb.CreateString("84关地鼠"),84,1,DRSusliks.CreateGrounpVector(fbb, new StringOffset[] { fbb.CreateString("5,1,1"),fbb.CreateString("5,1,1"),fbb.CreateString("5,1,1"),fbb.CreateString("5,1,1"),fbb.CreateString("5,1,1"),fbb.CreateString("5,1,1"),fbb.CreateString("5,1,1"),fbb.CreateString("5,1,1"),fbb.CreateString("5,1,1") }));
            offsets[4] = DRSusliks.CreateDRSusliks(fbb, 4,fbb.CreateString("85关地鼠"),85,1,DRSusliks.CreateGrounpVector(fbb, new StringOffset[] { fbb.CreateString("9,1,2"),fbb.CreateString("9,1,2"),fbb.CreateString("9,1,2"),fbb.CreateString("9,1,2"),fbb.CreateString("9,1,2"),fbb.CreateString("9,1,2"),fbb.CreateString("9,1,2"),fbb.CreateString("9,1,2"),fbb.CreateString("9,1,2") }));
            offsets[5] = DRSusliks.CreateDRSusliks(fbb, 5,fbb.CreateString("86关地鼠"),86,1,DRSusliks.CreateGrounpVector(fbb, new StringOffset[] { fbb.CreateString("9,1,1"),fbb.CreateString("9,1,1"),fbb.CreateString("9,1,1"),fbb.CreateString("9,1,1"),fbb.CreateString("9,1,1"),fbb.CreateString("9,1,1"),fbb.CreateString("9,1,1"),fbb.CreateString("9,1,1"),fbb.CreateString("9,1,1") }));
            offsets[6] = DRSusliks.CreateDRSusliks(fbb, 6,fbb.CreateString("87关地鼠"),87,1,DRSusliks.CreateGrounpVector(fbb, new StringOffset[] { fbb.CreateString("1,1,1|9,1,1"),fbb.CreateString("1,1,1|9,1,1"),fbb.CreateString("1,1,1|9,1,1"),fbb.CreateString("1,1,1|9,1,1"),fbb.CreateString("1,1,1|9,1,1"),fbb.CreateString("1,1,1|9,1,1"),fbb.CreateString("1,1,1|9,1,1"),fbb.CreateString("1,1,1|9,1,1"),fbb.CreateString("1,1,1|9,1,1") }));
            offsets[7] = DRSusliks.CreateDRSusliks(fbb, 7,fbb.CreateString("88关地鼠"),88,1,DRSusliks.CreateGrounpVector(fbb, new StringOffset[] { fbb.CreateString("5,1,1"),fbb.CreateString("5,1,1"),fbb.CreateString("5,1,1"),fbb.CreateString("5,1,1"),fbb.CreateString("5,1,1"),fbb.CreateString("5,1,1"),fbb.CreateString("5,1,1"),fbb.CreateString("5,1,1"),fbb.CreateString("5,1,1") }));
            offsets[8] = DRSusliks.CreateDRSusliks(fbb, 8,fbb.CreateString("89关地鼠"),89,1,DRSusliks.CreateGrounpVector(fbb, new StringOffset[] { fbb.CreateString("5,1,3"),fbb.CreateString("5,1,3"),fbb.CreateString("5,1,3"),fbb.CreateString("5,1,3"),fbb.CreateString("5,1,3"),fbb.CreateString("5,1,3"),fbb.CreateString("5,1,3"),fbb.CreateString("5,1,3"),fbb.CreateString("5,1,3") }));
            offsets[9] = DRSusliks.CreateDRSusliks(fbb, 9,fbb.CreateString("90关地鼠"),90,1,DRSusliks.CreateGrounpVector(fbb, new StringOffset[] { fbb.CreateString("2,1,1|3,1,1|4,1,1|5,1,1|6,1,1|7,1,1|8,1,1"),fbb.CreateString("2,1,1|3,1,1|4,1,1|5,1,1|6,1,1|7,1,1|8,1,1"),fbb.CreateString("2,1,1|3,1,1|4,1,1|5,1,1|6,1,1|7,1,1|8,1,1"),fbb.CreateString("2,1,1|3,1,1|4,1,1|5,1,1|6,1,1|7,1,1|8,1,1"),fbb.CreateString("2,1,1|3,1,1|4,1,1|5,1,1|6,1,1|7,1,1|8,1,1"),fbb.CreateString("2,1,1|3,1,1|4,1,1|5,1,1|6,1,1|7,1,1|8,1,1"),fbb.CreateString("2,1,1|3,1,1|4,1,1|5,1,1|6,1,1|7,1,1|8,1,1"),fbb.CreateString("2,1,1|3,1,1|4,1,1|5,1,1|6,1,1|7,1,1|8,1,1"),fbb.CreateString("2,1,1|3,1,1|4,1,1|5,1,1|6,1,1|7,1,1|8,1,1") }));

            VectorOffset dataOff = Table_Susliks.CreateDataVector(fbb, offsets);
            var configOff = Table_Susliks.CreateTable_Susliks(fbb, dataOff);
            Table_Susliks.FinishTable_SusliksBuffer(fbb, configOff);
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