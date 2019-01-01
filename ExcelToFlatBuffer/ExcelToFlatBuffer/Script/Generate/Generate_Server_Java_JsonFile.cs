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
                int arrayMark = 0;
                List<TableArrayElementInfo> arrayList = new List<TableArrayElementInfo>();
                for (int i = 0; i < rowListCount; i++)
                {
                    string wordName = excelData.GetWordName(i);
                    string wordType = excelData.GetTypeName(i);
                    string cellStr = rowList[i];

                    //string wordArrayName = null;
                    if (wordName.Contains(":"))
                    {
                        wordName = wordName.Split(':')[0];
                        if (arrayMark == 0)
                        {
                            arrayMark = 1;
                            arrayList.Clear();
                        }
                    }

                    if (i + 1 < rowListCount) //预判下一个值(如果不是最后一个)
                    {
                        string nextCellWordName = excelData.GetWordName(i + 1); //字段名称
                        if (nextCellWordName.Contains(":"))
                        {
                            string nextWordArrayName = nextCellWordName.Split(':')[0];
                            if (!nextWordArrayName.Equals(wordName)) //如果下一个单元格和当前单元格不是一个数组里的
                            {
                                if (arrayMark == 1)
                                    arrayMark = 2;
                            }
                        }
                        else
                        {
                            if (arrayMark == 1)
                                arrayMark = 2;
                        }
                    }
                    else
                    {
                        //如果已经是最后一个了
                        if (arrayMark == 1)
                            arrayMark = 2;
                    }

                    if (arrayMark == 0)  //普通单元格
                    {
                        cellStr = GetSingleCellString(wordType, cellStr);
                        string jsonCellStr = string.Format(Template_Server_Java_Json.Template_JsonCell, wordName, cellStr);
                        JsonLine += jsonCellStr;
                        if (i + 1 < rowListCount)
                            JsonLine += ",";
                    }
                    else if (arrayMark == 1) //同一数组添加
                    {
                        arrayList.Add(new TableArrayElementInfo(wordName, wordType, cellStr, excelData.Name));
                    }
                    else if (arrayMark == 2) //整个数组解析成代码
                    {
                        arrayList.Add(new TableArrayElementInfo(wordName, wordType, cellStr, excelData.Name));
                        string cellParam = GetCellArrayString(arrayList);
                        string jsonCellStr = string.Format(Template_Server_Java_Json.Template_JsonCell, wordName, cellParam);

                        JsonLine = JsonLine + jsonCellStr;
                        if (i + 1 < rowListCount)
                            JsonLine += ",";
                        arrayMark = 0;
                    }

                    






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


        public string GetSingleCellString(string cellTypeName,string cellStr)
        {
            if (cellTypeName == "string")
                return cellStr = "\"" + cellStr + "\"";
            else
                return cellStr;
        }

        private string GetCellArrayString(List<TableArrayElementInfo> cells)
        {
            string valueString = "[";
            for (int i = 0; i < cells.Count; i++)
            {
                string cellStr = GetSingleCellString(cells[i].cellType, cells[i].cellContent);
                if (i < cells.Count - 1)
                    valueString += cellStr + ",";
                else
                    valueString += cellStr + "]";
            }
            return valueString;
        }

    }
}
