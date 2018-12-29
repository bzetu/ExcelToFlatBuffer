using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatBuffer
{
    public abstract class IDealSingleExcel
    {
        public abstract void Execute(ExcelData excelData,System.Action<ExcelData,bool> onFinished);

        public abstract bool DealRow(List<string> rowData);
    }
}
