using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_EagleChickMap : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_EagleChickMap.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DREagleChickMap>[] offsets = new Offset<DREagleChickMap>[48];
   
            offsets[0] = DREagleChickMap.CreateDREagleChickMap(fbb, 5001,fbb.CreateString("第1行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,3 }));
            offsets[1] = DREagleChickMap.CreateDREagleChickMap(fbb, 5002,fbb.CreateString("第2行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,1,1 }));
            offsets[2] = DREagleChickMap.CreateDREagleChickMap(fbb, 5003,fbb.CreateString("第3行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,1,0 }));
            offsets[3] = DREagleChickMap.CreateDREagleChickMap(fbb, 5004,fbb.CreateString("第4行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,3,0,0,0,0,0,1,0 }));
            offsets[4] = DREagleChickMap.CreateDREagleChickMap(fbb, 5005,fbb.CreateString("第5行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,1,0,0,0,0,0,1,0 }));
            offsets[5] = DREagleChickMap.CreateDREagleChickMap(fbb, 5006,fbb.CreateString("第6行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,1,1,0,0,0,0,1,0 }));
            offsets[6] = DREagleChickMap.CreateDREagleChickMap(fbb, 5007,fbb.CreateString("第7行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,1,0,1,1,1,1,0 }));
            offsets[7] = DREagleChickMap.CreateDREagleChickMap(fbb, 5008,fbb.CreateString("第8行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,1,0,1,0,0,0,0 }));
            offsets[8] = DREagleChickMap.CreateDREagleChickMap(fbb, 5009,fbb.CreateString("第9行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,1,0,1,0,0,0,0 }));
            offsets[9] = DREagleChickMap.CreateDREagleChickMap(fbb, 5010,fbb.CreateString("第10行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,1,1,1,1,1,0,0 }));
            offsets[10] = DREagleChickMap.CreateDREagleChickMap(fbb, 5011,fbb.CreateString("第11行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,1,0,1,0,0 }));
            offsets[11] = DREagleChickMap.CreateDREagleChickMap(fbb, 5012,fbb.CreateString("第12行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,1,1,1,1,0,1,0,0 }));
            offsets[12] = DREagleChickMap.CreateDREagleChickMap(fbb, 5013,fbb.CreateString("第13行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,1,0,0,0,0,1,1,2 }));
            offsets[13] = DREagleChickMap.CreateDREagleChickMap(fbb, 5014,fbb.CreateString("第14行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,1,0,0,0,0,0,0,0 }));
            offsets[14] = DREagleChickMap.CreateDREagleChickMap(fbb, 5015,fbb.CreateString("第15行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,1,0,0,0,0,0,0,0 }));
            offsets[15] = DREagleChickMap.CreateDREagleChickMap(fbb, 5016,fbb.CreateString("第16行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 2,1,0,0,0,0,0,0,0 }));
            offsets[16] = DREagleChickMap.CreateDREagleChickMap(fbb, 10001,fbb.CreateString("第1行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[17] = DREagleChickMap.CreateDREagleChickMap(fbb, 10002,fbb.CreateString("第2行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[18] = DREagleChickMap.CreateDREagleChickMap(fbb, 10003,fbb.CreateString("第3行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[19] = DREagleChickMap.CreateDREagleChickMap(fbb, 10004,fbb.CreateString("第4行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[20] = DREagleChickMap.CreateDREagleChickMap(fbb, 10005,fbb.CreateString("第5行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[21] = DREagleChickMap.CreateDREagleChickMap(fbb, 10006,fbb.CreateString("第6行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[22] = DREagleChickMap.CreateDREagleChickMap(fbb, 10007,fbb.CreateString("第7行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[23] = DREagleChickMap.CreateDREagleChickMap(fbb, 10008,fbb.CreateString("第8行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,3,0,0,0,0 }));
            offsets[24] = DREagleChickMap.CreateDREagleChickMap(fbb, 10009,fbb.CreateString("第9行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,1,0,0,0,0 }));
            offsets[25] = DREagleChickMap.CreateDREagleChickMap(fbb, 10010,fbb.CreateString("第10行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,1,0,0,0,0 }));
            offsets[26] = DREagleChickMap.CreateDREagleChickMap(fbb, 10011,fbb.CreateString("第11行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,1,1,2,1,0,0,0 }));
            offsets[27] = DREagleChickMap.CreateDREagleChickMap(fbb, 10012,fbb.CreateString("第12行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,1,0,0,1,1,2,0 }));
            offsets[28] = DREagleChickMap.CreateDREagleChickMap(fbb, 10013,fbb.CreateString("第13行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,2,0,0,0,0,0,0 }));
            offsets[29] = DREagleChickMap.CreateDREagleChickMap(fbb, 10014,fbb.CreateString("第14行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[30] = DREagleChickMap.CreateDREagleChickMap(fbb, 10015,fbb.CreateString("第15行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[31] = DREagleChickMap.CreateDREagleChickMap(fbb, 10016,fbb.CreateString("第16行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[32] = DREagleChickMap.CreateDREagleChickMap(fbb, 11001,fbb.CreateString("第1行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[33] = DREagleChickMap.CreateDREagleChickMap(fbb, 11002,fbb.CreateString("第2行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[34] = DREagleChickMap.CreateDREagleChickMap(fbb, 11003,fbb.CreateString("第3行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[35] = DREagleChickMap.CreateDREagleChickMap(fbb, 11004,fbb.CreateString("第4行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[36] = DREagleChickMap.CreateDREagleChickMap(fbb, 11005,fbb.CreateString("第5行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[37] = DREagleChickMap.CreateDREagleChickMap(fbb, 11006,fbb.CreateString("第6行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[38] = DREagleChickMap.CreateDREagleChickMap(fbb, 11007,fbb.CreateString("第7行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,0,0 }));
            offsets[39] = DREagleChickMap.CreateDREagleChickMap(fbb, 11008,fbb.CreateString("第8行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,3,0 }));
            offsets[40] = DREagleChickMap.CreateDREagleChickMap(fbb, 11009,fbb.CreateString("第9行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,1,0 }));
            offsets[41] = DREagleChickMap.CreateDREagleChickMap(fbb, 11010,fbb.CreateString("第10行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,0,0,1,0 }));
            offsets[42] = DREagleChickMap.CreateDREagleChickMap(fbb, 11011,fbb.CreateString("第11行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,2,1,1,1,2,0 }));
            offsets[43] = DREagleChickMap.CreateDREagleChickMap(fbb, 11012,fbb.CreateString("第12行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,1,1,0,0,1,0,0 }));
            offsets[44] = DREagleChickMap.CreateDREagleChickMap(fbb, 11013,fbb.CreateString("第13行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,2,0,0,2,1,0,0 }));
            offsets[45] = DREagleChickMap.CreateDREagleChickMap(fbb, 11014,fbb.CreateString("第14行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,0,1,0,0,0 }));
            offsets[46] = DREagleChickMap.CreateDREagleChickMap(fbb, 11015,fbb.CreateString("第15行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,1,1,0,0,0 }));
            offsets[47] = DREagleChickMap.CreateDREagleChickMap(fbb, 11016,fbb.CreateString("第16行"),DREagleChickMap.CreateColumnVector(fbb, new int[] { 0,0,0,0,2,0,0,0,0 }));

            VectorOffset dataOff = Table_EagleChickMap.CreateDataVector(fbb, offsets);
            var configOff = Table_EagleChickMap.CreateTable_EagleChickMap(fbb, dataOff);
            Table_EagleChickMap.FinishTable_EagleChickMapBuffer(fbb, configOff);
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