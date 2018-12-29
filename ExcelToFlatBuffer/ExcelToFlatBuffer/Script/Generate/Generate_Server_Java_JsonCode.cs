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
            if (onFinished != null)
                onFinished(excelData, true);
        }

        public override bool DealRow(List<string> rowData)
        {
            return true;
        }
    }
}
