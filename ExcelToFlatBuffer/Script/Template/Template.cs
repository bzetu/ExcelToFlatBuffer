using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatBuffer
{
    public class Template
    {
        public static string Template_Fbs =
@"namespace GameMain;
table Table_{0} {{
    data : [DR{1}];
}}
table DR{2} {{
{3}
}}
root_type Table_{4};";



        public static string Template_FbsLine =
@"    ///{0}
    {1}:{2};
";

        public static string Template_ChangeCode_CSharp = @"public struct Table_{0} : IFlatbufferObject";

        public static string Template_ChangeTarget_CSharp =
@"public partial struct Table_{0}{{public IFlatbufferObject GetElement(int i) {{ return Data(i); }}}}
public partial struct Table_{1} : IFlatbufferObject , ITable";


        public static string Template_CSharp_Interface =
@"using System.Collections;
using System.Collections.Generic;

namespace GameMain
{
    using global::System;
    using global::FlatBuffers;
    public interface ITable
    {
        IFlatbufferObject GetElement(int i);
    }
}";


        public static string Template_CSharp_GenearteBytes =
@"using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;
using System.IO;
using GameMain;

namespace CompileCShap
{{
    public class GenerateByte_{0} : GenerateBase
    {{
        public override void GenerateByte()
        {{
            string path = ""{1}"";
            FlatBufferBuilder fbb = new FlatBufferBuilder(1);
            Offset<DR{2}>[] offsets = new Offset<DR{3}>[{4}];
   
{5}
            VectorOffset dataOff = Table_{6}.CreateDataVector(fbb, offsets);
            var configOff = Table_{7}.CreateTable_{8}(fbb, dataOff);
            Table_{9}.FinishTable_{10}Buffer(fbb, configOff);
            using (var ms = new MemoryStream(fbb.DataBuffer.ToFullArray(), fbb.DataBuffer.Position, fbb.Offset))
            {{
                try
                {{
                    var data = ms.ToArray();
                    File.WriteAllBytes(path, data);
                    Console.WriteLine(""已生成:"" + path.ToString());
                }}
                catch (Exception error)
                {{
                    Console.WriteLine(error.ToString());
                }}
            }}
        }}
    }}
}}";



        public static string Template_GenerateManager =
@"using System;
using System.Collections.Generic;
using System.Text;

namespace CompileCShap
{{
    public class GenerateManager
    {{
        private static GenerateManager m_Instance;

        private Dictionary<string,GenerateBase> GenerateDic = new Dictionary<string,GenerateBase>();
        public void Register(string scriptName,GenerateBase script)
        {{
            if (GenerateDic.ContainsKey(scriptName))
            {{
                GenerateDic[scriptName] = script;
            }}
            else
            {{
                GenerateDic.Add(scriptName, script);
            }}
        }}

        private GenerateManager()
        {{
            Init();
        }}

        public static GenerateManager Instance
        {{
            get
            {{
                if (m_Instance == null)
                    m_Instance = new GenerateManager();
                return m_Instance;
            }}
        }}

        public void Execute()
        {{
            int count = GenerateDic.Count;
            int index = 0;
            foreach (GenerateBase script in GenerateDic.Values)
            {{
                TaskList.Instance.AddTask((object param) =>
                {{
                    script.GenerateByte();
                    int p_index = (int)param;
                    if (p_index == count - 1)
                    {{
                        Console.WriteLine(""二进制文件全部生成完毕"");
                        TaskList.Instance.AddTask(() =>
                        {{
                            TaskList.Instance.Close();
                            //Console.ReadKey();
                        }});
                    }}
                }}, index);
                
                index++;
            }}
        }}

        public void Init()
        {{
{0}
        }}

    }}
}}
";
        public static string Template_AddToGenerateManager =
@"            Register(""GenerateByte_{0}"", new GenerateByte_{1}());
";

        public static string Template_GenerateBytesLine =
@"            offsets[{0}] = DR{1}.CreateDR{2}(fbb, {3});
";

    }

}
