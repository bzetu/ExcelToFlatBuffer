using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System;
using System.Collections.Generic;
namespace ExcelToFlatBuffer
{
    public class CompileHelper
    {
        public static bool CompileCSharpCode()
        {
            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            string[] codePaths = GetAllCSharpCodes();
            string outPath = Path.Combine(Setting.GenerateCodeRootPath, "GenerateBytes_CSharp.exe");
            CompilerResults cr = CompileCode(provider, codePaths, outPath);
            if (!cr.Errors.HasErrors)
            {
                Debug.Log("编译CSharp代码 " + cr.PathToAssembly + " 成功!");
            }
            else
            {
                int errorCount = cr.Errors.Count;
                for (int i = 0; i < errorCount; i++)
                {
                    var error = cr.Errors[i];
                    Debug.LogError("编译失败:" + error.FileName + "  line:" + error.Line + ":" + error.ErrorText);
                }

                cr.Errors.ToString();
                return false;
            }
            return true;
        }


        public static string[] GetAllCSharpCodes()
        {
            string compileCodePath = Path.Combine(Setting.GenerateCodeRootPath, "Script");
            string[] files = Directory.GetFiles(compileCodePath, "*.cs", SearchOption.AllDirectories);
            return files;
        }


        /// <summary>
        /// 把代码文件编译可执行文件（*.exe）
        /// </summary>
        /// <param name="provider">CodeDomProvider对象</param>
        /// <param name="sourceFile">源文件名称</param>
        /// <param name="exeFile">生成的可执行文件的名称</param>
        /// <returns></returns>
        private static CompilerResults CompileCode(CodeDomProvider provider, string[] sourceFile, string exeFile)
        {
            string flatBufferDLL = Path.Combine(Setting.GenerateCodeRootPath, "FlatBuffers.dll");

            // 配置一个 CompilerParameters 对象，它依赖 System.dll
            // 并生成指定的可执行的文件
            string[] referenceAssemblies = { "System.dll", flatBufferDLL };
            CompilerParameters cp = new CompilerParameters(referenceAssemblies, exeFile, false);

            // 生成一个可执行文件，而不是一个 DLL 文件
            cp.GenerateExecutable = true;

            // 调用编译器
            CompilerResults cr = provider.CompileAssemblyFromFile(cp, sourceFile);

            // 返回编译结果
            return cr;
        }
    }
}
