using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ExcelToFlatBuffer
{
    public partial class Procedure : IProcedure
    {
        public void Produce_OnExit()
        {
            var result = MessageBox.Show("生成成功!", "提示", MessageBoxButtons.OK);

            string outCodePath = ProSetting.Instance.GetCurOutFlatBufferCodePath();
            string outBytesPath = ProSetting.Instance.GetCurOutByteFilePath();

            Tools.DeleteFilesWithoutFolder(outCodePath);
            Tools.DeleteFilesWithoutFolder(outBytesPath);

            Tools.CopyDirectory(Setting.GenerateFlatCodePath, outCodePath);
            Tools.CopyDirectory(Setting.GenerateByteFilePath, outBytesPath);

            if (result == DialogResult.OK)
            {
                Program.Exit();
            }
        }
    }
}
