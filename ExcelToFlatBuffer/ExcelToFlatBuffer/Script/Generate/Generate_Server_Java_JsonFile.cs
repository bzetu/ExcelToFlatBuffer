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
        public override void Execute(ExcelData excelData, System.Action<ExcelData, bool> onFinished)
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
