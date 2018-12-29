using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_Combo : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Combo.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRCombo>[] offsets = new Offset<DRCombo>[5];
   
            offsets[0] = DRCombo.CreateDRCombo(fbb, 1,default(StringOffset),default(StringOffset));
            offsets[1] = DRCombo.CreateDRCombo(fbb, 2,default(StringOffset),fbb.CreateString("GamePanelFormAtlas/image_good"));
            offsets[2] = DRCombo.CreateDRCombo(fbb, 3,default(StringOffset),fbb.CreateString("GamePanelFormAtlas/image_nice"));
            offsets[3] = DRCombo.CreateDRCombo(fbb, 4,default(StringOffset),fbb.CreateString("GamePanelFormAtlas/image_wonderful"));
            offsets[4] = DRCombo.CreateDRCombo(fbb, 5,default(StringOffset),fbb.CreateString("GamePanelFormAtlas/image_unbelievablet"));

            VectorOffset dataOff = Table_Combo.CreateDataVector(fbb, offsets);
            var configOff = Table_Combo.CreateTable_Combo(fbb, dataOff);
            Table_Combo.FinishTable_ComboBuffer(fbb, configOff);
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