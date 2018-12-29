using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatBuffer
{
    public abstract class IDealAllExcel
    {
        public abstract void Execute(List<ExcelData> excelData, System.Action<bool> onFinished);
    }
}
