using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.CodeDom;
using System.CodeDom.Compiler;

namespace ExcelToFlatBuffer
{
    public partial class Form1 : UIFormBase
    {
        private CustomBar m_customBar;
        private int m_lastSelectTabIndex;
        public override void OnAwake()
        {
            Console.WriteLine("OnAwake");
            InitializeComponent();
        }

        public override void OnStart()
        {
            m_lastSelectTabIndex = ProSetting.Instance.curSelectTabIndex;
            Debug.Init(ListBox_Log);

            m_customBar = new CustomBar(OnTabSelect);

            InitDropList();
            this.ListBox_Log.DrawMode = DrawMode.OwnerDrawVariable;
            this.ListBox_Log.DrawItem += new DrawItemEventHandler(ListBoxGroupRange_DrawItem);
            this.ListBox_Log.MeasureItem += new MeasureItemEventHandler(ListBoxGroupRange_MeasureItem);
        }

        public void InitDropList()
        {
            this.UI_DropList_Language.Items.Add("C#");
            this.UI_DropList_Language.Items.Add("JAVA");
            this.UI_DropList_Language.Items.Add("Lua");

            this.UI_DropList_Use.Items.Add("Client");
            this.UI_DropList_Use.Items.Add("Server");

            this.UI_DropList_Language.SelectedIndex = 0;
            this.UI_DropList_Use.SelectedIndex = 0;
        }

        public override void OnUpdate()
        {
            Procedure.Instance.Update();
        }

        public override void OnClose()
        {
            if (ProSetting.Instance.IsDrty)
            {
                DialogResult result = MessageBox.Show("你有修改未保存,需要先保存再退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    ProSetting.Instance.Save();
                }
            }
           
        }




        private void OnBtnClick_Run(object sender, EventArgs e)
        {
            Procedure.Instance.Execute();
        }


        private void OnBtnClick_ExportLog(object sender, EventArgs e)
        {

        }

        private void OnBtnClick_ExcelPath(object sender, EventArgs e)
        {
            string selectPath = ChooseFolderPath();
            if(!string.IsNullOrEmpty(selectPath))
            {
                if (!string.IsNullOrEmpty(TextField_ExcelPaths.Text))
                    TextField_ExcelPaths.Text = TextField_ExcelPaths.Text + ";" + selectPath;
                else
                    TextField_ExcelPaths.Text = selectPath;
            }
            
        }

        private void OnBtnClick_CodePath(object sender, EventArgs e)
        {
            string selectPath = ChooseFolderPath();
            if (!string.IsNullOrEmpty(selectPath))
            {
                TextField_CodePaths.Text = selectPath;
            }
        }

        private void OnBtnClick_BytesPath(object sender, EventArgs e)
        {
            string selectPath = ChooseFolderPath();
            if (!string.IsNullOrEmpty(selectPath))
            {
                TextField_BytesPaths.Text = selectPath;
            }
        }



        /// <summary>
        /// 对话框形式选择文件夹路径
        /// </summary>
        /// <returns>返回所选择的文件夹路径</returns>
        public string ChooseFolderPath()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = Setting.ExeRootPath;
            fbd.RootFolder = System.Environment.SpecialFolder.Desktop;
            fbd.ShowNewFolderButton = true;
            fbd.Description = "请选择目录";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                return fbd.SelectedPath.ToString();
            }
            else
            {
                return "";
            }
        }



        /// <summary>
        /// 重新绘制ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxGroupRange_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
            if (e.Index >= 0)
            {
                StringFormat sStringFormat = new StringFormat();
                sStringFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds, sStringFormat);
            }
            e.DrawFocusRectangle();
        }

        private void ListBoxGroupRange_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            string text = listBox.Items[e.Index].ToString();

            float ItemWidth = listBox.Width;
            float TextWidth = text.Length * listBox.Font.Size;
            int rowCount = (int)Math.Ceiling(TextWidth / ItemWidth);

            int cellSize = (int)(listBox.Font.Size * 2);
            e.ItemHeight = rowCount * cellSize;



        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OnBtnClick_SaveSetting(object sender, EventArgs e)
        {
            UpdateProSettingPath();
            if (ProSetting.Instance.Save())
               MessageBox.Show("保存成功!", "提示");
            else
               MessageBox.Show("保存失败!请检查日志", "提示");

        }

        /// <summary>
        /// 当第N个方案被选中
        /// </summary>
        private void OnTabSelect(int index)
        {
            if (m_lastSelectTabIndex != index)
            {
                UpdateProSettingPath();
                m_lastSelectTabIndex = index;
            }

            Setting_CustomBarCellData data = ProSetting.Instance.GetTabCellData(index);
            TextField_ExcelPaths.Text = data.Path_Excel;
            TextField_CodePaths.Text = data.Path_OutCode;
            TextField_BytesPaths.Text = data.Path_OutByte;

            Console.WriteLine("OnTabSelect:" + index.ToString());
        }


        public void UpdateProSettingPath()
        {
            ProSetting.Instance.SavePath(m_lastSelectTabIndex, TextField_ExcelPaths.Text, TextField_CodePaths.Text, TextField_BytesPaths.Text);
        }
    }
}
