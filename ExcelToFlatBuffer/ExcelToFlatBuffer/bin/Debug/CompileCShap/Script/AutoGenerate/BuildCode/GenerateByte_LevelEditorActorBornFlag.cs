using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_LevelEditorActorBornFlag : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_LevelEditorActorBornFlag.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRLevelEditorActorBornFlag>[] offsets = new Offset<DRLevelEditorActorBornFlag>[8];
   
            offsets[0] = DRLevelEditorActorBornFlag.CreateDRLevelEditorActorBornFlag(fbb, 0,fbb.CreateString("母鸡出生点标志"),60001,10051,-1);
            offsets[1] = DRLevelEditorActorBornFlag.CreateDRLevelEditorActorBornFlag(fbb, 1,fbb.CreateString("小鹰出生点标志"),60002,10022,-1);
            offsets[2] = DRLevelEditorActorBornFlag.CreateDRLevelEditorActorBornFlag(fbb, 2,fbb.CreateString("睡美人出生点标志"),60053,10042,-1);
            offsets[3] = DRLevelEditorActorBornFlag.CreateDRLevelEditorActorBornFlag(fbb, 3,fbb.CreateString("王子出生点标志"),60052,10041,-1);
            offsets[4] = DRLevelEditorActorBornFlag.CreateDRLevelEditorActorBornFlag(fbb, 4,fbb.CreateString("玫瑰花出生点标志"),60055,10032,-1);
            offsets[5] = DRLevelEditorActorBornFlag.CreateDRLevelEditorActorBornFlag(fbb, 5,fbb.CreateString("鹰巢"),60040,10048,-1);
            offsets[6] = DRLevelEditorActorBornFlag.CreateDRLevelEditorActorBornFlag(fbb, 6,fbb.CreateString("道路"),60038,10049,-1);
            offsets[7] = DRLevelEditorActorBornFlag.CreateDRLevelEditorActorBornFlag(fbb, 7,fbb.CreateString("小鹰出生点"),60043,10050,-1);

            VectorOffset dataOff = Table_LevelEditorActorBornFlag.CreateDataVector(fbb, offsets);
            var configOff = Table_LevelEditorActorBornFlag.CreateTable_LevelEditorActorBornFlag(fbb, dataOff);
            Table_LevelEditorActorBornFlag.FinishTable_LevelEditorActorBornFlagBuffer(fbb, configOff);
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