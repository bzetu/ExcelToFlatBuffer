using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatBuffer
{
    public class Generate_Server_Java_JsonCode : IDealSingleExcel
    {
        public override void Execute(ExcelData excelData, System.Action<ExcelData,bool> onFinished)
        {
            string singleCode1 = "";
            string singleCode2 = "";
            List<string> rowList = excelData.GetRowData(0);
            List<string> desList = excelData.GetRowData(2);
            string lastWordName = "";
            for (int i = 0; i < rowList.Count; i++)
            {
                string typeName = excelData.GetTypeName(i);
                string wordName = excelData.GetWordName(i);
                string desStr = desList[i];
                if (string.IsNullOrEmpty(desStr))
                    desStr = "该字段未添加注释";

                bool isArray = false;
                if (wordName.Contains(":"))
                {
                    wordName = wordName.Split(':')[0];
                    isArray = true;
                }
                if (!lastWordName.Equals(wordName))
                {
                    if (typeName == "string")
                        typeName = "String";
                    if (typeName == "bool")
                        typeName = "boolean";
                    if (isArray)
                    {
                        if (typeName == "int")
                            typeName = "List<Integer>";
                        else
                            typeName = string.Format(@"List<{0}>", typeName);
                    }
                    singleCode1 += string.Format(Template_Server_Java_Json.Template_SingleTableCodeWord, wordName, typeName, wordName);
                    singleCode2 += string.Format(Template_Server_Java_Json.Template_SingleTableCodeWordGet, desStr, typeName, wordName, wordName);
                    lastWordName = wordName;
                }
                
            }
            string codeFileContent = string.Format(Template_Server_Java_Json.Template_SingleTableCode,excelData.Name, singleCode1, singleCode2);
            string JsonFilePath = System.IO.Path.Combine(Setting.GenJavaServerJsonCodePath, "Table" + excelData.Name + ".java");
            if (Tools.GenerateFile(codeFileContent, JsonFilePath))
            {
                Debug.Log("[Generate Sucess]:" + JsonFilePath);
                if (onFinished != null)
                    onFinished(excelData, true);
            }

            if (onFinished != null)
                onFinished(excelData, true);
        }

        public override bool DealRow(ExcelData excelData, int rowIndex)
        {

            return true;
        }
    }
}
