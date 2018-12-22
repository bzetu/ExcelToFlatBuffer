using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace ExcelToFlatBuffer
{
    public partial class Procedure : IProcedure
    {
        public bool Proceduree_GenerateFbs(ExcelData excelData)
        {
            List<string> dataList0 = excelData.GetRowData(0);   //字段
            List<string> dataList1 = excelData.GetRowData(1);   //类型
            List<string> dataList2 = excelData.GetRowData(2);   //说明
            if (dataList0 == null)
            {
                Debug.LogError("获取" + excelData.FileName + "第0行失败!");
                return false;
            }
            if (dataList1 == null)
            {
                Debug.LogError("获取" + excelData.FileName + "第1行失败!");
                return false;
            }
            if (dataList2 == null)
            {
                Debug.LogError("获取" + excelData.FileName + "第2行失败!");
                return false;
            }

            int count = dataList0.Count;
            string generateScript = "";
            for (int i = 0; i < count; i++)
            {
                string cell_world = dataList0[i];
                string cell_type = dataList1[i];
                string cell_des = dataList2[i];
                if (i == 0)
                {
                    if (cell_world.StartsWith("#"))
                        cell_world = cell_world.Replace("#", "");
                    if (cell_type.StartsWith("#"))
                        cell_type = cell_type.Replace("#", "");
                    if (cell_des.StartsWith("#"))
                        cell_des = cell_des.Replace("#", "");
                }
                generateScript = generateScript + string.Format(Template.Template_FbsLine, cell_des, cell_world, cell_type.ToLower());
            }

            string fbs = string.Format(Template.Template_Fbs, excelData.Name, excelData.Name, excelData.Name, generateScript, excelData.Name);

            if (GenerateFile(fbs, excelData.FbsPath))
            {
                Debug.Log("[Generate]=> " + excelData.FbsPath + " Sucess!");

                AddDelayRun(() =>
                {
                    Procedure_GenerateFlatBufferCode(excelData);
                });
            }

            return true;
        }

    }
}
