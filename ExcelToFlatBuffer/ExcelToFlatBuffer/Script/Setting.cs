using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ExcelToFlatBuffer
{
    public enum UseType
    {
        Client,
        Server,
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

        //public static string ProgramBytesDirPath = @"E:\FantasyPark\src\trunk\Client\Assets\GameMain\DataTables";

        //public static string ProgramFlatCodeDirPath = @"E:\FantasyPark\src\trunk\Client\Assets\GameMain\Scripts\DataTable";


        


    }
}
