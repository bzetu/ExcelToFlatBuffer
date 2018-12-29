using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_MoFangProduceItem : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_MoFangProduceItem.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRMoFangProduceItem>[] offsets = new Offset<DRMoFangProduceItem>[22];
   
            offsets[0] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 1,fbb.CreateString("生成策略1"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[1] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 2,fbb.CreateString("生成策略2"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[2] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 3,fbb.CreateString("生成策略3"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[3] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 4,fbb.CreateString("生成策略4"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[4] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 5,fbb.CreateString("生成策略5"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[5] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 6,fbb.CreateString("生成策略6"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[6] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 7,fbb.CreateString("生成策略7"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[7] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 8,fbb.CreateString("生成策略8"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[8] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 9,fbb.CreateString("生成策略9"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[9] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 10,fbb.CreateString("生成策略10"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[10] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 11,fbb.CreateString("生成策略11"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[11] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 12,fbb.CreateString("生成策略12"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[12] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 13,fbb.CreateString("生成策略13"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[13] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 14,fbb.CreateString("生成策略14"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[14] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 15,fbb.CreateString("生成策略15"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[15] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 16,fbb.CreateString("生成策略16"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("1:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[16] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 17,fbb.CreateString("生成策略17"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[17] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 18,fbb.CreateString("生成策略18"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[18] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 19,fbb.CreateString("生成策略19"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[19] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 20,fbb.CreateString("生成策略20"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[20] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 21,fbb.CreateString("生成策略21"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));
            offsets[21] = DRMoFangProduceItem.CreateDRMoFangProduceItem(fbb, 22,fbb.CreateString("生成策略22"),DRMoFangProduceItem.CreateItemWeightVector(fbb, new StringOffset[] { fbb.CreateString("0:1000"),fbb.CreateString("2:1000"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0"),fbb.CreateString("0") }));

            VectorOffset dataOff = Table_MoFangProduceItem.CreateDataVector(fbb, offsets);
            var configOff = Table_MoFangProduceItem.CreateTable_MoFangProduceItem(fbb, dataOff);
            Table_MoFangProduceItem.FinishTable_MoFangProduceItemBuffer(fbb, configOff);
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