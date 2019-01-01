using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 创建单个Excel的解析代码
/// </summary>

namespace ExcelToFlatBuffer
{
    public partial class Procedure : IProcedure
    {
        private List<ExcelData> m_ExcelDataList = new List<ExcelData>();
        private int PreDealExcelIndex = 0;
        private int DealExcelIndex = 0;
        
        public void Procedure_OnDealSingleExcel(ExcelData excelData)
        {
            PreDealExcelIndex++;

            IDealSingleExcel generateCode = new Generate_Server_Java_JsonCode();
            IDealSingleExcel generateRes = new Generate_Server_Java_JsonFile();
            

            List<List<string>> allRows = excelData.GetAllRows();
            int rowCount = allRows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                generateRes.DealRow(excelData, i);
            }

            generateCode.Execute(excelData, (ExcelData d1, bool r1) =>
            {
                if (r1)
                {
                    AddDelayRun(() =>
                    {
                        generateRes.Execute(excelData, (ExcelData d2, bool r2) =>
                        {
                            if (r2)
                            {
                                m_ExcelDataList.Add(excelData);
                                DealExcelIndex++;
                                if (PreDealExcelIndex == DealExcelIndex) //如果所有的Excel都处理完了,切到下一个流程(整体处理)
                                {
                                    Console.WriteLine("PreDealExcelIndex:" + PreDealExcelIndex.ToString());
                                    AddDelayRun(() =>
                                    {
                                        Procedure_OnAllExcelDealFinish(m_ExcelDataList);
                                    });
                                        
                                }
                            }
                        });
                    });
                }
            });

        }
    }
}
