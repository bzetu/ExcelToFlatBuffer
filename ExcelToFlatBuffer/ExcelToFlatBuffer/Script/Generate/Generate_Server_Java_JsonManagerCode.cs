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
            int count = excelList.Count;
            string template_manager_content1 = "";
            string template_manager_content2 = "";
            for (int i = 0; i < count; i++)
            {
                ExcelData excelData = excelList[i];
                string content1 = string.Format(Template_Server_Java_Json.Template_ManagerSingleTableCode,
                    excelData.Name, excelData.Name, excelData.Name, excelData.Name, excelData.Name,
                    excelData.Name, excelData.Name, excelData.Name, excelData.Name, excelData.Name,
                    excelData.Name, excelData.Name, excelData.Name, excelData.Name, excelData.Name,
                    excelData.Name, excelData.Name, excelData.Name, excelData.Name, excelData.Name,
                    excelData.Name, excelData.Name, excelData.Name);

                template_manager_content1 += content1;

                string content2 = string.Format(Template_Server_Java_Json.Template_ManagerSingleTableCodeInit,
                    excelData.Name, excelData.Name);

                template_manager_content2 += content2;
            }
            string fileContent = string.Format(Template_Server_Java_Json.Template_Manager,
                template_manager_content1, template_manager_content2);

            string JsonManagerFilePath = System.IO.Path.Combine(Setting.GenJavaServerJsonCodePath, "TableManager.java");

            if (Tools.GenerateFile(fileContent, JsonManagerFilePath))
            {
                Debug.Log("[Generate Sucess]:" + JsonManagerFilePath);
                if (onFinished != null)
                    onFinished(true);
            }
            else
            {
                if (onFinished != null)
                    onFinished(false);
            }

            Debug.LogError("生成管理器" + excelList.Count);
            if (onFinished != null)
                onFinished(true);
        }



    }
}
