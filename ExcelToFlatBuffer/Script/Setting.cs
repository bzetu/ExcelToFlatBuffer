using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ExcelToFlatBuffer
{
    public class Setting
    {
        public static string ExeRootPath{get {return System.IO.Directory.GetCurrentDirectory();}}

        public static string GenerateFbsPath {
            get
            {
                return Directory.GetCurrentDirectory();
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

        public static string FlatcPath = "C:/Users/jiangcheng_m/Desktop/flatc/flatc.exe";

    }
}
