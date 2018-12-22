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
                        m_loading.Add(fileName, false);
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
                for (int i = 0; i < 10; i++)
                {
                    IRow row = sheet.GetRow(i);
                    if (row != null)
                    {
                        List<string> rowList = new List<string>();
                        for (int j = 0; j < 10; j++)
                        {
                            ICell cell = row.GetCell(j);
                            if (cell != null)
                            {
                                string cellStr = "";
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
                                rowList.Add(cellStr);
                            }
                        }
                        excelData.AddRowData(rowList);
                    }
                }
                AddDelayRun(() =>
                {
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
