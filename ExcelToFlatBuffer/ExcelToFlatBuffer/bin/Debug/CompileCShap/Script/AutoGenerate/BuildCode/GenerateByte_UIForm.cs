using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{
    public class GenerateByte_UIForm : GenerateBase
    {
        public override void GenerateByte()
        {
            string path = "E:/FantasyPark/src/trunk/Tools_SourceCode/ExcelToFlatBuffer/ExcelToFlatBuffer/ExcelToFlatBuffer/bin/Debug/CompileCShap/Script/AutoGenerate/Bytes/Table_UIForm.bytes";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DRUIForm>[] offsets = new Offset<DRUIForm>[48];
   
            offsets[0] = DRUIForm.CreateDRUIForm(fbb, 1,fbb.CreateString("登录界面"),fbb.CreateString("LoginInForm"),30001,fbb.CreateString("Default"),false,false);
            offsets[1] = DRUIForm.CreateDRUIForm(fbb, 2,fbb.CreateString("主界面"),fbb.CreateString("MenuForm"),30002,fbb.CreateString("Default"),false,false);
            offsets[2] = DRUIForm.CreateDRUIForm(fbb, 3,fbb.CreateString("Loading界面"),fbb.CreateString("LoadingForm"),30003,fbb.CreateString("Loading"),false,false);
            offsets[3] = DRUIForm.CreateDRUIForm(fbb, 4,fbb.CreateString("游戏面板"),fbb.CreateString("GamePanelForm"),30004,fbb.CreateString("Default"),true,false);
            offsets[4] = DRUIForm.CreateDRUIForm(fbb, 5,fbb.CreateString("设置界面"),fbb.CreateString("CommonSetForm"),30005,fbb.CreateString("Loading"),false,false);
            offsets[5] = DRUIForm.CreateDRUIForm(fbb, 6,fbb.CreateString("关卡选择界面"),fbb.CreateString("LevelSelectForm"),30006,fbb.CreateString("Default"),false,false);
            offsets[6] = DRUIForm.CreateDRUIForm(fbb, 7,fbb.CreateString("万能块道具"),fbb.CreateString("MagicBlockForm"),30007,fbb.CreateString("Mask"),true,false);
            offsets[7] = DRUIForm.CreateDRUIForm(fbb, 8,fbb.CreateString("胜利界面"),fbb.CreateString("VictoryForm"),30008,fbb.CreateString("Mask"),false,false);
            offsets[8] = DRUIForm.CreateDRUIForm(fbb, 9,fbb.CreateString("失败界面"),fbb.CreateString("FailureForm"),30009,fbb.CreateString("Mask"),false,false);
            offsets[9] = DRUIForm.CreateDRUIForm(fbb, 10,fbb.CreateString("通用遮罩"),fbb.CreateString("CommonMask"),30010,fbb.CreateString("Mask"),false,false);
            offsets[10] = DRUIForm.CreateDRUIForm(fbb, 11,fbb.CreateString("按键自定义界面"),fbb.CreateString("KeySettingForm"),30011,fbb.CreateString("Mask"),false,false);
            offsets[11] = DRUIForm.CreateDRUIForm(fbb, 12,fbb.CreateString("步数提示"),fbb.CreateString("UIRemainedStepTips"),30012,fbb.CreateString("Mask"),false,false);
            offsets[12] = DRUIForm.CreateDRUIForm(fbb, 13,fbb.CreateString("关卡目标提示"),fbb.CreateString("TargetRemindingForm"),30013,fbb.CreateString("Mask"),false,false);
            offsets[13] = DRUIForm.CreateDRUIForm(fbb, 14,fbb.CreateString("新手引导界面"),fbb.CreateString("GuideForm"),30014,fbb.CreateString("Guide"),false,false);
            offsets[14] = DRUIForm.CreateDRUIForm(fbb, 15,fbb.CreateString("购买步数界面"),fbb.CreateString("BuyStepForm"),30015,fbb.CreateString("Mask"),false,false);
            offsets[15] = DRUIForm.CreateDRUIForm(fbb, 16,fbb.CreateString("胜利展示界面"),fbb.CreateString("VictoryPromptForm"),30016,fbb.CreateString("Mask"),false,false);
            offsets[16] = DRUIForm.CreateDRUIForm(fbb, 17,fbb.CreateString("道具选择界面"),fbb.CreateString("UILevelInfoForm"),30017,fbb.CreateString("Mask"),false,false);
            offsets[17] = DRUIForm.CreateDRUIForm(fbb, 18,fbb.CreateString("跳字"),fbb.CreateString("SpringWord"),30018,fbb.CreateString("Default"),false,false);
            offsets[18] = DRUIForm.CreateDRUIForm(fbb, 19,fbb.CreateString("新手键位界面"),fbb.CreateString("GuideChoiceForm"),30019,fbb.CreateString("Guide"),false,false);
            offsets[19] = DRUIForm.CreateDRUIForm(fbb, 20,fbb.CreateString("新手引导界面"),fbb.CreateString("GuideKeySetting"),30020,fbb.CreateString("Guide"),false,false);
            offsets[20] = DRUIForm.CreateDRUIForm(fbb, 21,fbb.CreateString("买步数"),fbb.CreateString("BuyStepForm"),30021,fbb.CreateString("Mask"),false,false);
            offsets[21] = DRUIForm.CreateDRUIForm(fbb, 22,fbb.CreateString("新手引导按键or手势界面"),fbb.CreateString("GuideChoiceKeyOrGesture"),30022,fbb.CreateString("Guide"),false,false);
            offsets[22] = DRUIForm.CreateDRUIForm(fbb, 23,fbb.CreateString("买道具"),fbb.CreateString("BuyItemForm"),30023,fbb.CreateString("Mask"),false,false);
            offsets[23] = DRUIForm.CreateDRUIForm(fbb, 24,fbb.CreateString("火箭引导界面"),fbb.CreateString("GuideRocket"),30024,fbb.CreateString("Mask"),false,false);
            offsets[24] = DRUIForm.CreateDRUIForm(fbb, 25,fbb.CreateString("炸弹引导界面"),fbb.CreateString("GuideBomb"),30025,fbb.CreateString("Mask"),false,false);
            offsets[25] = DRUIForm.CreateDRUIForm(fbb, 26,fbb.CreateString("藏宝图_起名界面"),fbb.CreateString("CreateNameForm"),30026,fbb.CreateString("Default"),false,false);
            offsets[26] = DRUIForm.CreateDRUIForm(fbb, 27,fbb.CreateString("母鸡捉小鹰引导界面"),fbb.CreateString("GuideHawkRun"),30027,fbb.CreateString("Mask"),false,false);
            offsets[27] = DRUIForm.CreateDRUIForm(fbb, 28,fbb.CreateString("藏宝图界面"),fbb.CreateString("TreasureMapForm"),30028,fbb.CreateString("Mask"),false,false);
            offsets[28] = DRUIForm.CreateDRUIForm(fbb, 29,fbb.CreateString("通用tips"),fbb.CreateString("CommonTips"),30029,fbb.CreateString("Mask"),true,false);
            offsets[29] = DRUIForm.CreateDRUIForm(fbb, 30,fbb.CreateString("新玩法引导界面"),fbb.CreateString("GuideNewPlayForm"),30032,fbb.CreateString("Guide"),false,false);
            offsets[30] = DRUIForm.CreateDRUIForm(fbb, 31,fbb.CreateString("功能开启"),fbb.CreateString("OpenFunctionForm"),30033,fbb.CreateString("Guide"),false,false);
            offsets[31] = DRUIForm.CreateDRUIForm(fbb, 32,fbb.CreateString("玩法帮助界面"),fbb.CreateString("HelpForm"),30034,fbb.CreateString("Mask"),false,false);
            offsets[32] = DRUIForm.CreateDRUIForm(fbb, 33,fbb.CreateString("任务界面"),fbb.CreateString("MainTaskForm"),30035,fbb.CreateString("Mask"),false,false);
            offsets[33] = DRUIForm.CreateDRUIForm(fbb, 34,fbb.CreateString("游乐园升级界面"),fbb.CreateString("LevelupForm"),30036,fbb.CreateString("Mask"),false,false);
            offsets[34] = DRUIForm.CreateDRUIForm(fbb, 35,fbb.CreateString("剧情界面"),fbb.CreateString("StoryTaskForm"),30037,fbb.CreateString("Mask"),false,false);
            offsets[35] = DRUIForm.CreateDRUIForm(fbb, 36,fbb.CreateString("建筑选择界面"),fbb.CreateString("BuildingSelectForm"),30038,fbb.CreateString("Mask"),false,false);
            offsets[36] = DRUIForm.CreateDRUIForm(fbb, 37,fbb.CreateString("主界面"),fbb.CreateString("MainInterfaceForm"),30039,fbb.CreateString("Default"),false,false);
            offsets[37] = DRUIForm.CreateDRUIForm(fbb, 38,fbb.CreateString("章节选择界面"),fbb.CreateString("ChapterForm"),30040,fbb.CreateString("Default"),false,false);
            offsets[38] = DRUIForm.CreateDRUIForm(fbb, 39,fbb.CreateString("新元素引导界面"),fbb.CreateString("GuideAnimationForm"),30041,fbb.CreateString("Mask"),false,false);
            offsets[39] = DRUIForm.CreateDRUIForm(fbb, 40,fbb.CreateString("关卡主界面"),fbb.CreateString("LevelMainForm"),30042,fbb.CreateString("Default"),false,false);
            offsets[40] = DRUIForm.CreateDRUIForm(fbb, 41,fbb.CreateString("奖励物品界面"),fbb.CreateString("RewardForm"),30043,fbb.CreateString("Mask"),false,false);
            offsets[41] = DRUIForm.CreateDRUIForm(fbb, 42,fbb.CreateString("离线收益界面"),fbb.CreateString("OffLineIncomeForm"),30044,fbb.CreateString("Mask"),false,false);
            offsets[42] = DRUIForm.CreateDRUIForm(fbb, 43,fbb.CreateString("获得星星界面"),fbb.CreateString("StarTipsForm"),30045,fbb.CreateString("Mask"),false,false);
            offsets[43] = DRUIForm.CreateDRUIForm(fbb, 44,fbb.CreateString("新手引导单条界面"),fbb.CreateString("GuideSingleForm"),30046,fbb.CreateString("Guide"),false,false);
            offsets[44] = DRUIForm.CreateDRUIForm(fbb, 45,fbb.CreateString("开场漫画界面"),fbb.CreateString("CartoonCGForm"),30047,fbb.CreateString("Default"),false,false);
            offsets[45] = DRUIForm.CreateDRUIForm(fbb, 46,fbb.CreateString("加载城建界面"),fbb.CreateString("LoadConstructionForm"),30048,fbb.CreateString("Loading"),false,false);
            offsets[46] = DRUIForm.CreateDRUIForm(fbb, 47,fbb.CreateString("游戏内设置界面"),fbb.CreateString("SettingFormInGame"),30059,fbb.CreateString("Mask"),false,false);
            offsets[47] = DRUIForm.CreateDRUIForm(fbb, 48,fbb.CreateString("无尽模式战斗界面"),fbb.CreateString("EndlessBattleForm"),30060,fbb.CreateString("Default"),true,false);

            VectorOffset dataOff = Table_UIForm.CreateDataVector(fbb, offsets);
            var configOff = Table_UIForm.CreateTable_UIForm(fbb, dataOff);
            Table_UIForm.FinishTable_UIFormBuffer(fbb, configOff);
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