using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ExcelToFlatBuffer
{
    public partial class Procedure : IProcedure
    {
        public bool Procedure_GenerateBytes()
        {
            string exePath = Path.Combine(Setting.GenerateCodeRootPath, "GenerateBytes_CSharp.exe");
            System.Diagnostics.Process.Start(exePath).WaitForExit();
            Debug.Log("生成flatbuffer序列化文件完毕!");
            var result = MessageBox.Show("生成成功!", "提示", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Program.Exit();
            }
            
            return true;
        }
    }
}
