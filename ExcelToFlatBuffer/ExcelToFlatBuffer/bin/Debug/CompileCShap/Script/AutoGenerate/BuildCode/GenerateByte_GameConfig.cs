using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_GameConfig : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_GameConfig.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRGameConfig>[] offsets = new Offset<DRGameConfig>[1];
   
            offsets[0] = DRGameConfig.CreateDRGameConfig(fbb, 1,fbb.CreateString("幽灵配置（0-出生后多少个回合不消失生成下一个,1-死后多少回合可以生成下一个,2-幽灵存在的最大数量,3-开局时多少回合生成幽灵,4-出生倒计时回合数,5-关卡生成的幽灵id）"),10,3,2,3,3,14);

            VectorOffset dataOff = Table_GameConfig.CreateDataVector(fbb, offsets);
            var configOff = Table_GameConfig.CreateTable_GameConfig(fbb, dataOff);
            Table_GameConfig.FinishTable_GameConfigBuffer(fbb, configOff);
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