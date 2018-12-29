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
        public bool Procedure_ChangeFlatBufferCode(ExcelData excelData)
        {
            string codePath = System.IO.Path.Combine(Setting.GenerateFlatCodePath, "Table_" + excelData.Name + ".cs");
            bool result = ChangeCSharpCode(excelData, codePath);

            Debug.Log("[ChangeCode]=>" + codePath + " Surcess!");
            AddDelayRun(() =>
            {
                Procedure_GenerateBuildFlatBufferCode(excelData);
            });

            return result;
        }



        private bool ChangeCSharpCode(ExcelData excelData,string codePath)
        {
            bool executeResult = false;
            try
            {
                string[] lineArry = File.ReadAllLines(codePath);
                int length = lineArry.Length;
                string findStr = string.Format(Template.Template_ChangeCode_CSharp, excelData.Name);
                string findStr2 = string.Format(Template.Template_ChangeCode_CSharp2, excelData.Name);
                for (int i = 0; i < length; i++)
                {
                    string line = lineArry[i].Trim();
                    if (line.Equals(findStr))
                    {
                        lineArry[i] = string.Format(Template.Template_ChangeTarget_CSharp, excelData.Name, excelData.KeyValueString, excelData.Name);
                        lineArry[i + 1] = "{\n  private Dictionary<int, int> IntKeys;";
                        executeResult = true;
                        continue;
                    }

                    if(line.Equals(findStr2))
                    {
                        lineArry[i] = string.Format(Template.Template_ChangeTarget_CSharp2,excelData.Name);
                        break;
                    }
                }
                File.WriteAllLines(codePath, lineArry);
            }
            catch (Exception error)
            {
                executeResult = false;
                Debug.LogError(error.ToString());
            }
            
            return executeResult;
        }


    }
}
