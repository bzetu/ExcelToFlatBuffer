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
            for (int i = 0; i < rowList.Count; i++)
            {
                string typeName = rowList[i];
                singleCode1 += string.Format(Template_Server_Java_Json.Template_SingleTableCodeWord, typeName,typeName);
                singleCode2 += string.Format(Template_Server_Java_Json.Template_SingleTableCodeWordGet, desList[i],typeName, typeName);
            }
            string codeFileContent = string.Format(Template_Server_Java_Json.Template_SingleTableCode, singleCode1, singleCode2);
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
