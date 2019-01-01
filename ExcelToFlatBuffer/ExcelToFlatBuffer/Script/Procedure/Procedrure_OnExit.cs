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
            string outCodePath = UserSetting.Instance.GetCurOutFlatBufferCodePath();
            string outBytesPath = UserSetting.Instance.GetCurOutByteFilePath();

            Tools.DeleteFilesWithoutFolder(outCodePath);
            Tools.DeleteFilesWithoutFolder(outBytesPath);

            AddDelayRun(() => {
                SchemeType scheme = Setting.GetCurSchemeType();
                if (scheme == SchemeType.Client_CSharp_To_FlatBuffer)
                {
                    Tools.CopyDirectory(Setting.GenerateFlatCodePath, outCodePath);
                    Tools.CopyDirectory(Setting.GenerateByteFilePath, outBytesPath);
                }
                else if (scheme == SchemeType.Server_Java_To_Json)
                {
                    Tools.CopyDirectory(Setting.GenJavaServerJsonCodePath, outCodePath);
                    Tools.CopyDirectory(Setting.GenServerJavaJsonFilePath, outBytesPath);
                }

                var result = MessageBox.Show("生成成功!", "提示", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Program.Exit();
                }
            });
        }
    }
}
