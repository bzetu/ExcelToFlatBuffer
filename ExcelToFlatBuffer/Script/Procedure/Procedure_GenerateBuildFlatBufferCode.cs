using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatBuffer
{
    public partial class Procedure : IProcedure
    {
        static string GenerateManagerCode = "";
        public bool Procedure_GenerateBuildFlatBufferCode(ExcelData excelData)
        {
            List<List<string>> allRows = excelData.GetAllRows();
            int rowCount = allRows.Count;
            List<string> typeList = allRows[1];
            string scriptline = "";
            for (int i = 3; i < rowCount; i++)
            {
                //offsets[{0}] = DR{1}.CreateDR{2}(fbb, {3});
                List<string> cellList = allRows[i];
                string strParam = "";
                for (int j = 0; j < cellList.Count; j++)
                {
                    string cellParam = GetCellCodeString(typeList[j].ToLower(), cellList[j]);
                    strParam = strParam + cellParam + ",";
                }
                strParam = strParam.Substring(0, strParam.Length - 1);

                string addline = string.Format(Template.Template_GenerateBytesLine, i - 3, excelData.Name, excelData.Name, strParam);

                scriptline = scriptline + addline;
                
            }

            string generateByteFilePath = System.IO.Path.Combine(Setting.GenerateByteFilePath, string.Format("Table_{0}.bytes", excelData.Name));
            generateByteFilePath = generateByteFilePath.Replace(@"\", @"/");
            string script = string.Format(Template.Template_CSharp_GenearteBytes,
                excelData.Name, generateByteFilePath, excelData.Name, excelData.Name, rowCount, scriptline, excelData.Name,
                excelData.Name, excelData.Name, excelData.Name, excelData.Name);
            //Console.WriteLine(script);

            string codePath = System.IO.Path.Combine(Setting.GenerateBuildFlatCodePath, "GenerateByte_" + excelData.Name + ".cs");
            if (GenerateFile(script, codePath))
            {
                Debug.Log("创建生成二进制代码" + codePath + "成功!");
            }

            //添加到管理器的代码
            GenerateManagerCode = GenerateManagerCode + string.Format(Template.Template_AddToGenerateManager, excelData.Name, excelData.Name);

            SetGenerateCodeFinish(excelData.FileName);

            if (IsAllCodeGenerateFinish)
            {
                OnCodeGenerateFinish(excelData);
            }

            //Console.WriteLine(script);
            return true;
        }

        private void OnCodeGenerateFinish(ExcelData excelData)
        {
            string path = System.IO.Path.Combine(Setting.GenerateFlatCodePath, "ITable.cs");
            GenerateFile(Template.Template_CSharp_Interface, path);
            Debug.Log("[Generate]=>" + path + " Sucess!");
            string scriptCode = string.Format(Template.Template_GenerateManager, GenerateManagerCode);
            path = System.IO.Path.Combine(Setting.GenerateBuildFlatCodePath, "GenerateManager.cs");
            GenerateFile(scriptCode, System.IO.Path.Combine(Setting.GenerateBuildFlatCodePath, "GenerateManager.cs"));
            Debug.Log("[Generate]=>" + path + " Sucess!");

            AddDelayRun(() =>
            {
                Debug.Log("所有的代码都生成完毕!");
                //Console.WriteLine(GenerateManagerCode);
                Procedure_CompileCode();
            });
        }


        private string GetCellCodeString(string cellType,string cell)
        {
            switch(cellType)
            {
                case "int":
                    return cell;
                case "float":
                    return string.Format(@"{0}f", cell);
                case "string":
                    return string.Format(@"fbb.CreateString(""{0}"")", cell);
                case "bool":
                    return cell.ToLower();
            }
            return cell;
        }


    }
}
