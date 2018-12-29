using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 当所有的Excel都处理完毕之后
/// </summary>

namespace ExcelToFlatBuffer
{
    public partial class Procedure : IProcedure
    {
        public void Procedure_OnAllExcelDealFinish(List<ExcelData> excelList)
        {
            IDealAllExcel deal = new Generate_Server_Java_JsonManagerCode();
            deal.Execute(excelList, (bool result) => {
                Produce_OnExit();
            });
            
        }

    }

    
}
