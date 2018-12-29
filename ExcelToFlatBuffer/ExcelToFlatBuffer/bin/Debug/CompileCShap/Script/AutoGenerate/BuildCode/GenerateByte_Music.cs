using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_Music : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Music.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRMusic>[] offsets = new Offset<DRMusic>[3];
   
            offsets[0] = DRMusic.CreateDRMusic(fbb, 1,fbb.CreateString("登录背景音乐"),fbb.CreateString("Music_LoginIn"));
            offsets[1] = DRMusic.CreateDRMusic(fbb, 2,fbb.CreateString("选关背景音乐"),fbb.CreateString("Music_Menu"));
            offsets[2] = DRMusic.CreateDRMusic(fbb, 3,fbb.CreateString("游戏背景音乐"),fbb.CreateString("Music_Game"));

            VectorOffset dataOff = Table_Music.CreateDataVector(fbb, offsets);
            var configOff = Table_Music.CreateTable_Music(fbb, dataOff);
            Table_Music.FinishTable_MusicBuffer(fbb, configOff);
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