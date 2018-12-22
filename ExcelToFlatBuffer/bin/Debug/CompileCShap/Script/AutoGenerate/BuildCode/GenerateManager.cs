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
            Register("GenerateByte_Block", new GenerateByte_Block());
            Register("GenerateByte_Effect", new GenerateByte_Effect());

        }

    }
}
