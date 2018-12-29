using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

using NPOI.HSSF.UserModel;
using NPOI.HPSF;
using NPOI.POIFS.FileSystem;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace ExcelToFlatBuffer
{
    public partial class Procedure : IProcedure
    {
        private List<string> content = new List<string>();

        public bool Procedure_ReadExcel()
        {
            string ExcelPath = ProSetting.Instance.GetCurExcelPath();
            if (string.IsNullOrEmpty(ExcelPath))
            {
                Debug.Log("找不到Excel路径");
                MessageBox.Show("Excel路径不能为空!");
                return false;
            }
            string[] SettingPaths = ExcelPath.Split(';');
            int pathCount = SettingPaths.Length;
            for (int i = 0; i < pathCount; i++)
            {
                try
                {
                    string settingPath = SettingPaths[i];
                    string[] excelPaths = System.IO.Directory.GetFiles(settingPath, "*.xlsx", SearchOption.AllDirectories);
                    int length = excelPaths.Length;
                    for (int j = 0; j < length; j++)
                    {
                        string excelPath = excelPaths[j];
                        //Console.WriteLine("excelPath:" + excelPath.ToString());
                        string fileName = Path.GetFileName(excelPath);
                        string extension = Path.GetExtension(excelPath);
                        string tableName = fileName.Replace(extension, "");
                        if (!m_loading.ContainsKey(fileName))
                            m_loading.Add(fileName, false);
                        else
                        {
                            Debug.LogError("发现相同的配表名称:" + fileName);
                        }
                        AddDelayRun(() =>
                        {
                            Read_Single_Excel(excelPath);
                        });
                    }
                }
                catch (Exception error)
                {
                    Debug.LogError(error);
                    return false;
                }
                
            }
            
            return true;
        }


        private bool Read_Single_Excel(string path)
        {
            try
            {
                ExcelData excelData = new ExcelData(path);
                FileInfo fileInfo = new System.IO.FileInfo(path);
                XSSFWorkbook workbook = new XSSFWorkbook(fileInfo);
                ISheet sheet = workbook.GetSheetAt(0);
                int columnCount = 0; //列数
                for (int i = 0; i < 10000; i++)
                {
                    IRow row = sheet.GetRow(i);
                    if (row != null)
                    {
                        List<string> rowList = new List<string>();
                        for (int j = 0; j < 100; j++)
                        {
                            ICell cell = row.GetCell(j);
                            string cellStr = "";
                            if (cell == null)
                            {
                                if (columnCount == 0)
                                {
                                    columnCount = rowList.Count;
                                    break;
                                }
                                else if (j < columnCount)  
                                {
                                    if (i > 2)//策划没有配置，给预一个默认值
                                    {
                                        string cellType = excelData.GetTypeName(j);
                                        if (cellType == "string")
                                            cellStr = "";
                                        else if(cellType == "bool")
                                            cellStr = "FLASE";
                                        else
                                            cellStr = "0";
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }

                            if (string.IsNullOrEmpty(cellStr) && cell != null)
                            {
                                if (cell.CellType != CellType.Formula)  //如果不是公式
                                    cellStr = cell.ToString().Trim();
                                else
                                {
                                    if (cell.CachedFormulaResultType == CellType.Numeric)
                                        cellStr = cell.NumericCellValue.ToString();
                                    else if (cell.CachedFormulaResultType == CellType.String)
                                        cellStr = cell.StringCellValue.Trim();
                                    else if (cell.CachedFormulaResultType == CellType.Boolean)
                                        cellStr = cell.BooleanCellValue.ToString();
                                }
                            }

                            if (i == 0)
                            {
                                cellStr = cellStr[0].ToString().ToUpper() + cellStr.Substring(1);   //字段首字母必须大写,应该flat会解析成首字母大写
                            }
                            if (i > 2 && j == 0 && cellStr.StartsWith("#"))    //如果从第三行开始第一个单元格里的是#,则本行不读
                                break;
                            else
                                rowList.Add(cellStr);

                        }
                        if (rowList.Count > 0)
                        {
                            excelData.AddRowData(rowList);
                        }
                            
                    }
                    else
                    {
                        break;
                    }
                }
                AddDelayRun(() =>
                {
                    //Console.WriteLine(excelData.KeyValueString);
                    if (ProSetting.Instance.GetCurUseType() == UseType.Server)
                        Procedure_OnDealSingleExcel(excelData);
                    else
                        Proceduree_GenerateFbs(excelData);
                });
            }
            catch (Exception error)
            {
                Debug.Log(error);
                return true;
            }
            return true;
        }


    }
}
