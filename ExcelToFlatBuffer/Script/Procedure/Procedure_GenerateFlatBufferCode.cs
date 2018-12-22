using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace ExcelToFlatBuffer
{
    public partial class Procedure : IProcedure
    {
        public bool Procedure_GenerateFlatBufferCode(ExcelData excelData)
        {
            string arguments = string.Format("{0} --csharp -o {1} {2} --gen-onefile", Setting.FlatcPath, Setting.GenerateFlatCodePath, excelData.FbsPath);
            Console.WriteLine(arguments);
            ProcCmd(false, arguments);
            string codePath = System.IO.Path.Combine(Setting.GenerateFlatCodePath, excelData.Name + ".cs");
            Debug.Log("[Generate]=>" + codePath + " Sucess!");
            AddDelayRun(() => {
                Procedure_ChangeFlatBufferCode(excelData);
            });
            return true;
        }



        private string ProcCmd(bool showWindows,params string[] cmd)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = !showWindows;
            p.Start();
            p.StandardInput.AutoFlush = true;
            for (int i = 0; i < cmd.Length; i++)
            {
                p.StandardInput.WriteLine(cmd[i].ToString());
            }
            p.StandardInput.WriteLine("exit");
            string strRst = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            p.Close();
            return strRst;
        }



    }
}
