using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatBuffer
{
    public class Generate_Server_Java_JsonManagerCode : IDealAllExcel
    {
        public override void Execute(List<ExcelData> excelList, System.Action<bool> onFinished)
        {
            Debug.LogError("生成管理器" + excelList.Count);
            if (onFinished != null)
                onFinished(true);
        }



    }
}
