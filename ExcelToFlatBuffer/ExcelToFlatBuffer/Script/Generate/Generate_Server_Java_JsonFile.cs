using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 创建Excel对应的Json文件
/// </summary>

namespace ExcelToFlatBuffer
{
    public class Generate_Server_Java_JsonFile : IDealSingleExcel
    {
        string jsonContentStr = "";
        public override void Execute(ExcelData excelData, System.Action<ExcelData, bool> onFinished)
        {
            string fileContent =  string.Format(Template_Server_Java_Json.Template_Json, jsonContentStr);
            //Console.WriteLine(fileContent);
            string JsonFilePath = System.IO.Path.Combine(Setting.GenServerJavaJsonFilePath, excelData.Name + ".json");
            if (Tools.GenerateFile(fileContent, JsonFilePath))
            {
                Debug.Log("[Generate Sucess]:" + JsonFilePath);
                if (onFinished != null)
                    onFinished(excelData, true);
            }
                
        }

        public override bool DealRow(ExcelData excelData, int rowIndex)
        {
            if (rowIndex > 2)
            {
                string JsonLine = "{";    //一行的json数据
                List<string> rowList = excelData.GetRowData(rowIndex);
                int rowListCount = rowList.Count;
                for (int i = 0; i < rowListCount; i++)
                {
                    string typeName = excelData.GetTypeName(i);
                    string cellStr = rowList[i];
                    switch (typeName)
                    {
                        case "string":
                            cellStr = "\"" + cellStr + "\"";
                            break;
                    }
                  
                    string jsonCellStr = string.Format(Template_Server_Java_Json.Template_JsonCell, typeName, cellStr);
                    
                    JsonLine += jsonCellStr;
                    if (i + 1 < rowListCount)
                        JsonLine += ",";
                }
                

                //Console.WriteLine(excelData.GetAllRowCount().ToString() + "   " + (rowIndex + 1).ToString());
                if (excelData.GetAllRowCount() == rowIndex + 1)
                {
                    JsonLine += "}";
                    jsonContentStr += JsonLine;
                }  
                else
                {
                    JsonLine += "},";
                    jsonContentStr += JsonLine + "\n";
                }
                    
            }
            return true;
        }
    }
}
