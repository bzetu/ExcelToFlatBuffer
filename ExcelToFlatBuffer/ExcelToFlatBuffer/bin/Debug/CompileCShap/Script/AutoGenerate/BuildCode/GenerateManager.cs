using System;
using System.Collections.Generic;
using System.Text;

namespace CompileCShap
{
    public class GenerateManager
    {
        private static GenerateManager m_Instance;

        private Dictionary<string,GenerateBase> GenerateDic = new Dictionary<string,GenerateBase>();
        public void Register(string scriptName,GenerateBase script)
        {
            if (GenerateDic.ContainsKey(scriptName))
            {
                GenerateDic[scriptName] = script;
            }
            else
            {
                GenerateDic.Add(scriptName, script);
            }
        }

        private GenerateManager()
        {
            Init();
        }

        public static GenerateManager Instance
        {
            get
            {
                if (m_Instance == null)
                    m_Instance = new GenerateManager();
                return m_Instance;
            }
        }

        public void Execute()
        {
            int count = GenerateDic.Count;
            int index = 0;
            foreach (GenerateBase script in GenerateDic.Values)
            {
                TaskList.Instance.AddTask((object param) =>
                {
                    script.GenerateByte();
                    int p_index = (int)param;
                    if (p_index == count - 1)
                    {
                        Console.WriteLine("二进制文件全部生成完毕");
                        TaskList.Instance.AddTask(() =>
                        {
                            TaskList.Instance.Close();
                            //Console.ReadKey();
                        });
                    }
                }, index);
                
                index++;
            }
        }

        public void Init()
        {
            Register("GenerateByte_AI", new GenerateByte_AI());
            Register("GenerateByte_Assets", new GenerateByte_Assets());
            Register("GenerateByte_Block", new GenerateByte_Block());
            Register("GenerateByte_BlockInitPosition", new GenerateByte_BlockInitPosition());
            Register("GenerateByte_BlockScore", new GenerateByte_BlockScore());
            Register("GenerateByte_BlockType", new GenerateByte_BlockType());
            Register("GenerateByte_CleanRow", new GenerateByte_CleanRow());
            Register("GenerateByte_Combo", new GenerateByte_Combo());
            Register("GenerateByte_Cover", new GenerateByte_Cover());
            Register("GenerateByte_Effect", new GenerateByte_Effect());
            Register("GenerateByte_Element", new GenerateByte_Element());
            Register("GenerateByte_ElementScore", new GenerateByte_ElementScore());
            Register("GenerateByte_FMODMusic", new GenerateByte_FMODMusic());
            Register("GenerateByte_FMODSound", new GenerateByte_FMODSound());
            Register("GenerateByte_GameConfig", new GenerateByte_GameConfig());
            Register("GenerateByte_GenerateItem", new GenerateByte_GenerateItem());
            Register("GenerateByte_GhostGenerate", new GenerateByte_GhostGenerate());
            Register("GenerateByte_GhostType", new GenerateByte_GhostType());
            Register("GenerateByte_GradeConfig", new GenerateByte_GradeConfig());
            Register("GenerateByte_GuideGroup", new GenerateByte_GuideGroup());
            Register("GenerateByte_GuideModeGroup", new GenerateByte_GuideModeGroup());
            Register("GenerateByte_GuideNewPlayStep", new GenerateByte_GuideNewPlayStep());
            Register("GenerateByte_GuideStep", new GenerateByte_GuideStep());
            Register("GenerateByte_Help", new GenerateByte_Help());
            Register("GenerateByte_IconBase", new GenerateByte_IconBase());
            Register("GenerateByte_LevelEditorActorBornFlag", new GenerateByte_LevelEditorActorBornFlag());
            Register("GenerateByte_LevelScroll", new GenerateByte_LevelScroll());
            Register("GenerateByte_MagicBlockPosition", new GenerateByte_MagicBlockPosition());
            Register("GenerateByte_MapBlockGroup", new GenerateByte_MapBlockGroup());
            Register("GenerateByte_MapBlockGroupWeight", new GenerateByte_MapBlockGroupWeight());
            Register("GenerateByte_MapElementWeight", new GenerateByte_MapElementWeight());
            Register("GenerateByte_MapLevel", new GenerateByte_MapLevel());
            Register("GenerateByte_MapScrollCondition", new GenerateByte_MapScrollCondition());
            Register("GenerateByte_Music", new GenerateByte_Music());
            Register("GenerateByte_OpenFunction", new GenerateByte_OpenFunction());
            Register("GenerateByte_OpenItem", new GenerateByte_OpenItem());
            Register("GenerateByte_Product", new GenerateByte_Product());
            Register("GenerateByte_Resource", new GenerateByte_Resource());
            Register("GenerateByte_ScreenAdaptation", new GenerateByte_ScreenAdaptation());
            Register("GenerateByte_ShapeTypeItem", new GenerateByte_ShapeTypeItem());
            Register("GenerateByte_Story", new GenerateByte_Story());
            Register("GenerateByte_StraightEffectStepTime", new GenerateByte_StraightEffectStepTime());
            Register("GenerateByte_Susliks", new GenerateByte_Susliks());
            Register("GenerateByte_TreasureMapData", new GenerateByte_TreasureMapData());
            Register("GenerateByte_TreasureMapStory", new GenerateByte_TreasureMapStory());
            Register("GenerateByte_UIForm", new GenerateByte_UIForm());
            Register("GenerateByte_WoodPeckerType", new GenerateByte_WoodPeckerType());
            Register("GenerateByte_Actor", new GenerateByte_Actor());
            Register("GenerateByte_Building", new GenerateByte_Building());
            Register("GenerateByte_BuildingLevel", new GenerateByte_BuildingLevel());
            Register("GenerateByte_Chapter", new GenerateByte_Chapter());
            Register("GenerateByte_Charactor", new GenerateByte_Charactor());
            Register("GenerateByte_CommonItem", new GenerateByte_CommonItem());
            Register("GenerateByte_ConstConfig", new GenerateByte_ConstConfig());
            Register("GenerateByte_EagleChickActor", new GenerateByte_EagleChickActor());
            Register("GenerateByte_EagleChickMap", new GenerateByte_EagleChickMap());
            Register("GenerateByte_EagleChickMapConfig", new GenerateByte_EagleChickMapConfig());
            Register("GenerateByte_GameLevels", new GenerateByte_GameLevels());
            Register("GenerateByte_LevelAward", new GenerateByte_LevelAward());
            Register("GenerateByte_LevelTarget", new GenerateByte_LevelTarget());
            Register("GenerateByte_MissionList", new GenerateByte_MissionList());
            Register("GenerateByte_MoFangProduceItem", new GenerateByte_MoFangProduceItem());
            Register("GenerateByte_MultipleDispleScoreRatio", new GenerateByte_MultipleDispleScoreRatio());
            Register("GenerateByte_ParkLevel", new GenerateByte_ParkLevel());
            Register("GenerateByte_Reward", new GenerateByte_Reward());
            Register("GenerateByte_SceneClass", new GenerateByte_SceneClass());
            Register("GenerateByte_StringDictionary", new GenerateByte_StringDictionary());
            Register("GenerateByte_Terrain", new GenerateByte_Terrain());
            Register("GenerateByte_Worker", new GenerateByte_Worker());

        }

    }
}
