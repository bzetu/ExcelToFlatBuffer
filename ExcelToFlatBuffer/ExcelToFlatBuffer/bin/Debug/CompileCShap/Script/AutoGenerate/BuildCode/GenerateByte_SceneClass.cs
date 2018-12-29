using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_SceneClass : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_SceneClass.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRSceneClass>[] offsets = new Offset<DRSceneClass>[6];
   
            offsets[0] = DRSceneClass.CreateDRSceneClass(fbb, 1,fbb.CreateString("登陆"),fbb.CreateString("LoginIn"),-1,-1,-1,default(StringOffset),0,0,0,fbb.CreateString("NULL"),fbb.CreateString("NULL"),3,1,-1f,-1f,-1f,-1f,default(StringOffset));
            offsets[1] = DRSceneClass.CreateDRSceneClass(fbb, 2,fbb.CreateString("Loading"),fbb.CreateString("Loading"),-1,-1,-1,default(StringOffset),0,0,0,fbb.CreateString("NULL"),fbb.CreateString("NULL"),3,1,-1f,-1f,-1f,-1f,default(StringOffset));
            offsets[2] = DRSceneClass.CreateDRSceneClass(fbb, 3,fbb.CreateString("Menu"),fbb.CreateString("Menu"),0,0,1000,default(StringOffset),100,0,0,fbb.CreateString("NULL"),fbb.CreateString("NULL"),3,21,-1f,-1f,-1f,-1f,default(StringOffset));
            offsets[3] = DRSceneClass.CreateDRSceneClass(fbb, 4,fbb.CreateString("BaseGame"),fbb.CreateString("wanglongNewTetris"),1,1,1001,fbb.CreateString("./Config/SceneNvMesh/Scene_Test_1.nav"),6,106,2,fbb.CreateString("MiniMap"),fbb.CreateString("BigMiniMap"),1,20,14.6f,93.6f,0f,24.5f,fbb.CreateString("1:2:3:4:5:6:7:8:9:10:11:12:13:14:15:16:17:18:19:20:21:22:23:24:25:26:27:28:29:30:31:32:33:34:36:37:38"));
            offsets[4] = DRSceneClass.CreateDRSceneClass(fbb, 5,fbb.CreateString("关卡选择"),fbb.CreateString("Chapter{0}"),1,1,1001,fbb.CreateString("./Config/SceneNvMesh/Scene_Test_1.nav"),6,106,1,fbb.CreateString("MiniMap"),fbb.CreateString("BigMiniMap"),1,20,14.6f,93.6f,0f,24.5f,fbb.CreateString("33:35:36"));
            offsets[5] = DRSceneClass.CreateDRSceneClass(fbb, 6,fbb.CreateString("城市建设"),fbb.CreateString("Construction"),1,1,1001,fbb.CreateString("./Config/SceneNvMesh/Scene_Test_1.nav"),6,106,1,fbb.CreateString("MiniMap"),fbb.CreateString("BigMiniMap"),1,20,14.6f,93.6f,0f,24.5f,default(StringOffset));

            VectorOffset dataOff = Table_SceneClass.CreateDataVector(fbb, offsets);
            var configOff = Table_SceneClass.CreateTable_SceneClass(fbb, dataOff);
            Table_SceneClass.FinishTable_SceneClassBuffer(fbb, configOff);
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