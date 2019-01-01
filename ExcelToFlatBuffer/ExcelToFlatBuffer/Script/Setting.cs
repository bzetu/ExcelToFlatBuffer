using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ExcelToFlatBuffer
{
    /// <summary>
    /// 配置方案
    /// </summary>
    public enum SchemeType
    {
        Client_CSharp_To_FlatBuffer,
        Server_Java_To_Json,
        UnKown,
    }


    public class Setting
    {
        public static string ExeRootPath { get { return System.IO.Directory.GetCurrentDirectory(); } }

        public static string GenerateFbsPath {
            get
            {
                return Path.Combine(ExeRootPath, "Fbs");
            }
        }


        public static string GenerateFlatCodePath
        {
            get
            {
                return Path.Combine(ExeRootPath, "CompileCShap/Script/AutoGenerate/FlatCode");
            }
        }


        public static string GenerateBuildFlatCodePath
        {
            get
            {
                return Path.Combine(ExeRootPath, "CompileCShap/Script/AutoGenerate/BuildCode");
            }
        }

        public static string GenerateByteFilePath
        {
            get
            {
                return Path.Combine(ExeRootPath, "CompileCShap/Script/AutoGenerate/Bytes");
            }
        }


        public static string GenerateCodeRootPath
        {
            get
            {
                return Path.Combine(ExeRootPath, "CompileCShap");
            }
        }

        public static string FlatcPath
        {
            get
            {
                return Path.Combine(ExeRootPath, "flatc.exe");
            } 
        }


        /// <summary>
        /// 生成路径->Java服务器需要的Json解析代码(Java的)
        /// </summary>
        public static string GenJavaServerJsonCodePath
        {
            get
            {
                return Path.Combine(ExeRootPath, "JavaJson/JsonCode");
            }
        }

        /// <summary>
        /// 生成路径->Java服务器需要的Json文件(资源)
        /// </summary>
        public static string GenServerJavaJsonFilePath
        {
            get
            {
                return Path.Combine(ExeRootPath, "JavaJson/JsonFile");
            }
        }

        /// <summary>
        /// 获取当前的配置方案
        /// </summary>
        /// <returns></returns>
        public static SchemeType GetCurSchemeType()
        {
            UseType use = UserSetting.Instance.GetCurUseType();
            LanguageType language = UserSetting.Instance.GetCurLanguageType();
            AnalysisType analysis = UserSetting.Instance.GetCurAnalysisType();
            if (use == UseType.Client && language == LanguageType.CSharp && analysis == AnalysisType.FlatBuffer)
            {
                return SchemeType.Client_CSharp_To_FlatBuffer;
            }
            else if (use == UseType.Server && language == LanguageType.Java && analysis == AnalysisType.Json)
            {
                return SchemeType.Server_Java_To_Json;
            }
            else
            {
                return SchemeType.UnKown;
            }
        }

    }
}
