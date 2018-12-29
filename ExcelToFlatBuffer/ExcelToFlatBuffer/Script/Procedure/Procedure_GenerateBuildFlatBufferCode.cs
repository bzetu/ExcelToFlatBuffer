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
        static string FlatBufferTableManagerCode_Content1 = "";
        static string FlatBufferTableManagerCode_Content2 = "";

        public bool Procedure_GenerateBuildFlatBufferCode(ExcelData excelData)
        {
            List<List<string>> allRows = excelData.GetAllRows();
            int rowCount = allRows.Count;
            List<string> typeList = allRows[1];
            string scriptline = "";
            int arrayStart = 0; //当遇到数组的时候会变成1; 遇到最后一个数组元素的时候变成 2
            List<TableArrayElementInfo> arrayList = new List<TableArrayElementInfo>(); //记录所有的数组单元格数据(必须是连贯的)
            for (int i = 3; i < rowCount; i++)
            {
                //offsets[{0}] = DR{1}.CreateDR{2}(fbb, {3});
                List<string> cellList = allRows[i];
                string strParam = "";
                for (int j = 0; j < cellList.Count; j++)
                {
                    string cellName = allRows[0][j]; //字段名称
                    string wordType = typeList[j].ToLower();
                    string cellStr = cellList[j];

                    string wordArrayName = null;
                    if (cellName.Contains(":"))
                    {
                        wordArrayName = cellName.Split(':')[0];
                        if (arrayStart == 0)
                        {
                            arrayStart = 1;
                            arrayList.Clear();
                            //arrayList.Add(new TableArrayElementInfo(cellName, wordType, cellStr, excelData.Name));
                        }
                    }

                    if (j + 1 < cellList.Count) //预判下一个值(如果不是最后一个)
                    {
                        string nextCellName = allRows[0][j + 1]; //字段名称
                        if (nextCellName.Contains(":"))
                        {
                            string nextWordArrayName = nextCellName.Split(':')[0];
                            if (!nextWordArrayName.Equals(wordArrayName)) //如果下一个单元格和当前单元格不是一个数组里的
                            {
                                if (arrayStart == 1)
                                    arrayStart = 2;
                            }  
                        }
                        else
                        {
                            if (arrayStart == 1)
                                arrayStart = 2;
                        }
                    }
                    else
                    {
                        //如果已经是最后一个了
                        if (arrayStart == 1)
                            arrayStart = 2;
                    }

                    string cellParam = "";
                    if (arrayStart == 0)  //普通单元格
                    {
                        cellParam = GetCellCodeString(wordType, cellStr); //添加单个元素
                        strParam = strParam + cellParam + ",";
                    }
                    else if (arrayStart == 1) //同一数组添加
                    {
                        arrayList.Add(new TableArrayElementInfo(cellName, wordType,cellStr, excelData.Name));
                    }
                    else if (arrayStart == 2) //整个数组解析成代码
                    {
                        arrayList.Add(new TableArrayElementInfo(cellName, wordType, cellStr, excelData.Name));
                        cellParam = GetCellArrayCodeString(arrayList);
                        strParam = strParam + cellParam + ",";
                        arrayStart = 0;
                    }
                    
                }
                strParam = strParam.Substring(0, strParam.Length - 1);

                string addline = string.Format(Template.Template_GenerateBytesLine, i - 3, excelData.Name, excelData.Name, strParam);

                scriptline = scriptline + addline;

            }

            string generateByteFilePath = System.IO.Path.Combine(Setting.GenerateByteFilePath, string.Format("Table_{0}.bytes", excelData.Name));
            generateByteFilePath = generateByteFilePath.Replace(@"\", @"/");
            string script = string.Format(Template.Template_CSharp_GenearteBytes,
                excelData.Name, generateByteFilePath, excelData.Name, excelData.Name, rowCount-3, scriptline, excelData.Name,
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

            //添加到FlatBufferTableManager(项目中使用)
            GenerateCode_FlatTableManager_Content(excelData);

            if (IsAllCodeGenerateFinish)
            {
                GenerateCode_FlatTableManager(excelData);
                OnCodeGenerateFinish(excelData);
            }
            return true;
        }

        private void OnCodeGenerateFinish(ExcelData excelData)
        {
            //string path = System.IO.Path.Combine(Setting.GenerateFlatCodePath, "ITable.cs");
            //GenerateFile(Template.Template_CSharp_Interface, path);
            //Debug.Log("[Generate]=>" + path + " Sucess!");

            string scriptCode = string.Format(Template.Template_GenerateManager, GenerateManagerCode);
            string path = System.IO.Path.Combine(Setting.GenerateBuildFlatCodePath, "GenerateManager.cs");
            GenerateFile(scriptCode, System.IO.Path.Combine(Setting.GenerateBuildFlatCodePath, "GenerateManager.cs"));
            Debug.Log("[Generate]=>" + path + " Sucess!");

            AddDelayRun(() =>
            {
                Debug.Log("所有的代码都生成完毕!");
                //Console.WriteLine(GenerateManagerCode);
                Procedure_CompileCode();
            });
        }


        private string GetCellCodeString(string cellType, string cell)
        {
            switch (cellType)
            {
                case "int":
                    return cell;
                case "float":
                    return string.Format(@"{0}f", cell);
                case "string":
                    {
                        if (!string.IsNullOrEmpty(cell))
                            return string.Format(@"fbb.CreateString(""{0}"")", cell.Replace("\"", ""));
                        else
                            return "default(StringOffset)";
                    }
                case "bool":
                    return cell.ToLower();
            }
            return cell;
        }

        /// <summary>
        /// worldName:字段名称
        /// </summary>
        private string GetCellArrayCodeString(List<TableArrayElementInfo> cells)
        {
            string cellType = cells[0].cellType;   //数据类型
            string param0 = cells[0].tableName;
            string param1 = cells[0].worldName;
            string param2 = "StringOffset";
            if (cellType != "string") //string的类型是StringOffset
                param2 = cellType;

            string template = @"DR{0}.Create{1}Vector(fbb, new {2}[] {{ {3} }})";
            string param3 = "";
            for (int i = 0; i < cells.Count; i++)
            {
                var cellInfo = cells[i];
                param3 = param3 + GetCellCodeString(cellType, cellInfo.cellContent);
                if (i < cells.Count - 1)
                {
                    param3 = param3 + ",";
                }
            }
            string result = "";
            result = string.Format(template, param0, param1, param2, param3);
            return result;
        }

        private void GenerateCode_FlatTableManager_Content(ExcelData excelData)
        {
            FlatBufferTableManagerCode_Content1 += string.Format(Template.Template_FlatBufferTableManager_Content1, excelData.Name);
            FlatBufferTableManagerCode_Content2 += string.Format(Template.Template_FlatBufferTableManager_Content2, excelData.Name, excelData.Name, excelData.Name);
        }
        private void GenerateCode_FlatTableManager(ExcelData excelData)
        {
            string flatBufferManagerCode = string.Format(Template.Template_FlatBufferTableManager, FlatBufferTableManagerCode_Content1, FlatBufferTableManagerCode_Content2);
            string path = System.IO.Path.Combine(Setting.GenerateFlatCodePath, "FlatBufferTableManager.cs");
            GenerateFile(flatBufferManagerCode, path);
            Debug.Log("[Generate]=>" + path + " Sucess!");
        }
    }


    /// <summary>
    /// 配表数组元素信息
    /// </summary>
    public class TableArrayElementInfo
    {
        //字段名称
        public string worldName;
        //字段类型
        public string cellType;
        //字段内容
        public string cellContent;
        //配表名称
        public string tableName;

        public TableArrayElementInfo(string worldName, string cellType, string cellContent, string tableName)
        {
            this.worldName = worldName.Replace("#","");
            string[] temp = worldName.Split(':');
            if (temp.Length > 0)
                this.worldName = temp[0];
            this.cellType = cellType;
            this.cellContent = cellContent;
            this.tableName = tableName;
        }

    }
}
