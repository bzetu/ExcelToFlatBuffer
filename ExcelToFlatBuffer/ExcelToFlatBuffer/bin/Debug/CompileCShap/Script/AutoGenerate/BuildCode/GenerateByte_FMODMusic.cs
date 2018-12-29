using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_FMODMusic : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_FMODMusic.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRFMODMusic>[] offsets = new Offset<DRFMODMusic>[3];
   
            offsets[0] = DRFMODMusic.CreateDRFMODMusic(fbb, 1,fbb.CreateString("选择关卡场景音乐"),fbb.CreateString("event:/Music/BGM_Maincity(linshi)"));
            offsets[1] = DRFMODMusic.CreateDRFMODMusic(fbb, 2,fbb.CreateString("战斗背景音乐"),fbb.CreateString("event:/Music/BGM_Theme"));
            offsets[2] = DRFMODMusic.CreateDRFMODMusic(fbb, 3,fbb.CreateString("原厂背景音"),fbb.CreateString("event:/Music/BGM_Theme_1"));

            VectorOffset dataOff = Table_FMODMusic.CreateDataVector(fbb, offsets);
            var configOff = Table_FMODMusic.CreateTable_FMODMusic(fbb, dataOff);
            Table_FMODMusic.FinishTable_FMODMusicBuffer(fbb, configOff);
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