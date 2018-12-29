using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_Assets : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_Assets.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRAssets>[] offsets = new Offset<DRAssets>[39];
   
            offsets[0] = DRAssets.CreateDRAssets(fbb, 0,fbb.CreateString("保留行"),-1,false,0,-1,fbb.CreateString("保留行"));
            offsets[1] = DRAssets.CreateDRAssets(fbb, 1,fbb.CreateString("游戏界面UI"),1,false,0,-1,fbb.CreateString("Assets/GameMain/UI/UIForms/GamePanelForm.prefab"));
            offsets[2] = DRAssets.CreateDRAssets(fbb, 2,fbb.CreateString("I_block"),1,false,0,-1,fbb.CreateString("Assets/GameMain/Entities/IBlock.prefab"));
            offsets[3] = DRAssets.CreateDRAssets(fbb, 3,fbb.CreateString("J_block"),1,false,0,-1,fbb.CreateString("Assets/GameMain/Entities/JBlock.prefab"));
            offsets[4] = DRAssets.CreateDRAssets(fbb, 4,fbb.CreateString("L_block"),1,false,0,-1,fbb.CreateString("Assets/GameMain/Entities/LBlock.prefab"));
            offsets[5] = DRAssets.CreateDRAssets(fbb, 5,fbb.CreateString("O_block"),1,false,0,-1,fbb.CreateString("Assets/GameMain/Entities/OBlock.prefab"));
            offsets[6] = DRAssets.CreateDRAssets(fbb, 6,fbb.CreateString("S_block"),1,false,0,-1,fbb.CreateString("Assets/GameMain/Entities/SBlock.prefab"));
            offsets[7] = DRAssets.CreateDRAssets(fbb, 7,fbb.CreateString("T_block"),1,false,0,-1,fbb.CreateString("Assets/GameMain/Entities/TBlock.prefab"));
            offsets[8] = DRAssets.CreateDRAssets(fbb, 8,fbb.CreateString("Z_block"),1,false,0,-1,fbb.CreateString("Assets/GameMain/Entities/ZBlock.prefab"));
            offsets[9] = DRAssets.CreateDRAssets(fbb, 9,fbb.CreateString("魔法棒"),1,false,0,-1,fbb.CreateString("Assets/GameMain/Entities/MagicWand.prefab"));
            offsets[10] = DRAssets.CreateDRAssets(fbb, 10,fbb.CreateString("泡泡糖出现特效"),1,false,2,40007,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_BubbleGum.prefab"));
            offsets[11] = DRAssets.CreateDRAssets(fbb, 11,fbb.CreateString("魔法棒拖尾特效"),1,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_Plasticine_Trail.prefab"));
            offsets[12] = DRAssets.CreateDRAssets(fbb, 12,fbb.CreateString("泡泡糖爆炸特效"),1,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_BubbleGum_Explode.prefab"));
            offsets[13] = DRAssets.CreateDRAssets(fbb, 13,fbb.CreateString("橡皮泥"),1,false,0,-1,fbb.CreateString("Assets/GameMain/Entities/Plasticene.prefab"));
            offsets[14] = DRAssets.CreateDRAssets(fbb, 14,fbb.CreateString("消除一行特效"),1,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_OneRow.prefab"));
            offsets[15] = DRAssets.CreateDRAssets(fbb, 15,fbb.CreateString("收集特效"),1,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_Bell_Trail.prefab"));
            offsets[16] = DRAssets.CreateDRAssets(fbb, 16,fbb.CreateString("飞机出生特效"),2,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_Plane_BlowLight.prefab"));
            offsets[17] = DRAssets.CreateDRAssets(fbb, 17,fbb.CreateString("飞机拖尾特效"),2,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_Plane_Trail.prefab"));
            offsets[18] = DRAssets.CreateDRAssets(fbb, 18,fbb.CreateString("飞机爆炸特效"),2,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_Plane_Explode.prefab"));
            offsets[19] = DRAssets.CreateDRAssets(fbb, 19,fbb.CreateString("一键到底特效"),2,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_Falling.prefab"));
            offsets[20] = DRAssets.CreateDRAssets(fbb, 20,fbb.CreateString("点击特效"),2,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_Hand.prefab"));
            offsets[21] = DRAssets.CreateDRAssets(fbb, 21,fbb.CreateString("通用点击特效"),2,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_CommonClick.prefab"));
            offsets[22] = DRAssets.CreateDRAssets(fbb, 22,fbb.CreateString("一键到底特效"),2,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_Falling_Slow.prefab"));
            offsets[23] = DRAssets.CreateDRAssets(fbb, 23,fbb.CreateString("消除两行特效"),2,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_OneRow2.prefab"));
            offsets[24] = DRAssets.CreateDRAssets(fbb, 24,fbb.CreateString("消除三行特效"),2,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_OneRow3.prefab"));
            offsets[25] = DRAssets.CreateDRAssets(fbb, 25,fbb.CreateString("消除四行特效"),2,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_Plane.prefab"));
            offsets[26] = DRAssets.CreateDRAssets(fbb, 26,fbb.CreateString("飞机特效"),2,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_Plane.prefab"));
            offsets[27] = DRAssets.CreateDRAssets(fbb, 27,fbb.CreateString("木箱销毁特效"),2,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_WoodBox_Break.prefab"));
            offsets[28] = DRAssets.CreateDRAssets(fbb, 28,fbb.CreateString("扭扭蛋出生特效"),2,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_Egg.prefab"));
            offsets[29] = DRAssets.CreateDRAssets(fbb, 29,fbb.CreateString("扭扭蛋出生特效"),2,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_Egg_ComeUp.prefab"));
            offsets[30] = DRAssets.CreateDRAssets(fbb, 30,fbb.CreateString("扭扭蛋爆炸特效"),3,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_Par_Egg_Explode.prefab"));
            offsets[31] = DRAssets.CreateDRAssets(fbb, 31,fbb.CreateString("传送门"),3,false,0,-1,fbb.CreateString("Assets/GameMain/Effects/Particle/Fx_TransmissionGate.prefab"));
            offsets[32] = DRAssets.CreateDRAssets(fbb, 32,fbb.CreateString("幽灵传送门倒计时"),3,false,0,-1,fbb.CreateString("Assets/GameMain/Entities/GhostCountDown.prefab"));
            offsets[33] = DRAssets.CreateDRAssets(fbb, 33,fbb.CreateString("幽灵"),3,false,0,-1,fbb.CreateString("Assets/GameMain/Entities/Ghost.prefab"));
            offsets[34] = DRAssets.CreateDRAssets(fbb, 34,fbb.CreateString("新手引导"),1,false,0,-1,fbb.CreateString("Assets/GameMain/UI/UIForms/GuideForm.prefab"));
            offsets[35] = DRAssets.CreateDRAssets(fbb, 35,fbb.CreateString("选道具界面"),1,false,0,-1,fbb.CreateString("Assets/GameMain/UI/UIForms/UILevelInfoForm.prefab"));
            offsets[36] = DRAssets.CreateDRAssets(fbb, 36,fbb.CreateString("新手引导对话框"),1,false,0,-1,fbb.CreateString("Assets/GameMain/UI/UIWightItem/GuideDialogItem.prefab"));
            offsets[37] = DRAssets.CreateDRAssets(fbb, 37,fbb.CreateString("方块投影"),1,false,0,-1,fbb.CreateString("Assets/GameMain/Entities/ShapeProjection.prefab"));
            offsets[38] = DRAssets.CreateDRAssets(fbb, 38,fbb.CreateString("新手引导扣图界面"),1,false,0,-1,fbb.CreateString("Assets/GameMain/UI/UIWightItem/GuideCutItem.prefab"));

            VectorOffset dataOff = Table_Assets.CreateDataVector(fbb, offsets);
            var configOff = Table_Assets.CreateTable_Assets(fbb, dataOff);
            Table_Assets.FinishTable_AssetsBuffer(fbb, configOff);
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