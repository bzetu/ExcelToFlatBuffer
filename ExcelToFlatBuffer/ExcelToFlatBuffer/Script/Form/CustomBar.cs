/*
 自定义的分类按钮组,可以添加、删除、修改分页
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ExcelToFlatBuffer
{
    public class CustomBar
    {
        #region 成员变量
        private static Setting_CustomBarCellData m_fristCellInfo;
        private List<CustomBarCell> m_cellList = new List<CustomBarCell>();
        private Button m_btnEdit;
        private Button m_btnAdd;
        private Button m_btnRemove;
        private Button m_btnChange;
        private Button m_btnEditFinish;

        public delegate void OnSelectEvent(int index);
        private OnSelectEvent m_onSelectEvent;
        #endregion
        private Button Button_Edit
        {
            get
            {
                if (m_btnEdit == null)
                {
                    m_btnEdit = new Button();
                    Program.GetForm().Controls.Add(m_btnEdit);
                    m_btnEdit.Size = new Size(50,28);
                    m_btnEdit.Location = new Point(Program.GetForm().Width - m_btnEdit.Size.Width - 28, FristCellInfo.Point_Button.Y);
                    m_btnEdit.Text = "编辑";
                    m_btnEdit.Click += new EventHandler(OnBtnClick_Edit);
                }
                return m_btnEdit;

            }
        }

        private Button Button_Add
        {
            get
            {
                if (m_btnAdd == null)
                {
                    m_btnAdd = new Button();
                    Program.GetForm().Controls.Add(m_btnAdd);
                    m_btnAdd.Size = Button_Edit.Size;
                    m_btnAdd.Location = new Point(Button_Edit.Location.X - Button_Edit.Size.Width * 3, Button_Edit.Location.Y); 
                    m_btnAdd.Text = "添加";
                    m_btnAdd.Click += new EventHandler(OnBtnClick_Add);
                }
                return m_btnAdd;
            }
        }

        private Button Button_Remove
        {
            get
            {
                if (m_btnRemove == null)
                {
                    m_btnRemove = new Button();
                    Program.GetForm().Controls.Add(m_btnRemove);
                    m_btnRemove.Size = Button_Edit.Size;
                    m_btnRemove.Location = new Point(Button_Edit.Location.X - Button_Edit.Size.Width * 2, Button_Edit.Location.Y);
                    m_btnRemove.Text = "删除";
                    m_btnRemove.Click += new EventHandler(OnBtnClick_Remove);
                }
                return m_btnRemove;

            }
        }

        private Button Button_Change
        {
            get
            {
                if (m_btnChange == null)
                {
                    m_btnChange = new Button();
                    Program.GetForm().Controls.Add(m_btnChange);
                    m_btnChange.Size = Button_Edit.Size;
                    m_btnChange.Location = new Point(Button_Edit.Location.X - Button_Edit.Size.Width, Button_Edit.Location.Y);
                    m_btnChange.Text = "修改";
                    m_btnChange.Click += new EventHandler(OnBtnClick_Change);
                }
                return m_btnChange;

            }
        }

        private Button Button_EditFinish
        {
            get
            {
                if (m_btnEditFinish == null)
                {
                    m_btnEditFinish = new Button();
                    Program.GetForm().Controls.Add(m_btnEditFinish);
                    m_btnEditFinish.Size = Button_Edit.Size;
                    m_btnEditFinish.Location = Button_Edit.Location;
                    m_btnEditFinish.Text = "完成";
                    m_btnEditFinish.Click += new EventHandler(OnBtnClick_EditFinish);
                }
                return m_btnEditFinish;
            }
        }


        public static Setting_CustomBarCellData FristCellInfo
        {
            get
            {
                if (m_fristCellInfo == null)
                {
                    m_fristCellInfo = new Setting_CustomBarCellData();
                    m_fristCellInfo.Point_Button = new Setting_Point(12, 28);
                    m_fristCellInfo.Size_Button = new Setting_Size(78, 25);
                    m_fristCellInfo.Point_TextBox = new Setting_Point(15, 30);
                    m_fristCellInfo.Size_TextBox = new Setting_Size(72, 21);
                }
                return m_fristCellInfo;
            }
        }
        

        public void AddElement()
        {
            CustomBarCell cell = new CustomBarCell(m_cellList.Count);
            cell.m_OnBtnClickEvent += OnBtnClick_Tab;
            m_cellList.Add(cell);
            ProSetting.Instance.AddCustomBarCell(cell.m_cellInfo);
        }

        public void AddElement(Setting_CustomBarCellData data)
        {
            CustomBarCell cell = new CustomBarCell(data, m_cellList.Count);
            cell.m_OnBtnClickEvent += OnBtnClick_Tab;
            m_cellList.Add(cell);
        }

        /// <summary>
        /// 入口(构造函数)
        /// </summary>
        public CustomBar(OnSelectEvent onSelect = null)
        {
            this.m_onSelectEvent = onSelect;
            List<Setting_CustomBarCellData> settingList = ProSetting.Instance.GetCustomBarCellList();
            int count = settingList.Count;
            if (count > 0)
            {
                //恢复上次保存的状态
                for (int i = 0; i < count; i++)
                {
                    AddElement(settingList[i]);
                }
            }
            else
            {
                //默认创建一个页签
                AddElement();
            }
            ShowEditButton(true);

            int curSelectIndex = ProSetting.Instance.curSelectTabIndex < m_cellList.Count ? ProSetting.Instance.curSelectTabIndex : 0;
            m_cellList[curSelectIndex].UI_Button.Select();
            if (m_onSelectEvent != null)
                m_onSelectEvent.Invoke(curSelectIndex);
            ProSetting.Instance.curSelectTabIndex = curSelectIndex;
            
        }


        public void ShowEditButton(bool visable)
        {
            Button_Edit.Visible = visable;
            Button_Add.Visible = !visable;
            Button_Remove.Visible = !visable;
            Button_Change.Visible = !visable;
            Button_EditFinish.Visible = !visable;
        }

        /****************************************************************************************************/

        private void OnBtnClick_Edit(object sender, EventArgs e)
        {
            ShowEditButton(false);
        }
        private void OnBtnClick_EditFinish(object sender, EventArgs e)
        {
            int tabIndex = ProSetting.Instance.curSelectTabIndex;
            if (tabIndex < m_cellList.Count)
            {
                Setting_CustomBarCellData newData = m_cellList[tabIndex].EditComplete();
                ProSetting.Instance.SetTableCellData(tabIndex, newData);
            }
            ShowEditButton(true);
        }
        private void OnBtnClick_Add(object sender, EventArgs e)
        {
            if (m_cellList.Count >= 5)
            {
                MessageBox.Show("最多添加5个方案", "提示");
                return;
            }
            AddElement();
        }
        private void OnBtnClick_Remove(object sender, EventArgs e)
        {
            if (m_cellList.Count <= 1)
            {
                MessageBox.Show("至少保留一个方案", "提示");
                return;
            }
            int tabIndex = ProSetting.Instance.curSelectTabIndex;
            if (tabIndex < m_cellList.Count)
            {
                m_cellList[tabIndex].RemoveUI();
                m_cellList.RemoveAt(tabIndex);
                ProSetting.Instance.RemoveCustomBarCell(tabIndex);
            }
            for (int i = 0; i < m_cellList.Count; i++)
            {
                m_cellList[i].Update(i);
            }
        }

        private void OnBtnClick_Tab(int btnIndex)
        {
            ProSetting.Instance.curSelectTabIndex = btnIndex;
            if (m_onSelectEvent != null)
                m_onSelectEvent.Invoke(btnIndex);
        }

        public void OnBtnClick_Change(object sender, EventArgs e)
        {
            int tabIndex = ProSetting.Instance.curSelectTabIndex;
            if (tabIndex < m_cellList.Count)
            {
                m_cellList[tabIndex].Edit();
            }
        }

    }


    public class CustomBarCell
    {
        private Button m_button;
        public event System.Action<int> m_OnBtnClickEvent;
        private int BtnIndex;

        public Button UI_Button
        {
            get
            {
                if (m_button == null)
                {
                    m_button = new Button();
                    Program.GetForm().Controls.Add(m_button);
                    m_button.Click += new EventHandler(OnBtnClick);
                }
                return m_button;
            }
        }
        private TextBox m_textBox;
        public TextBox UI_TextBox
        {
            get
            {
                if (m_textBox == null)
                {
                    m_textBox = new TextBox();
                    Program.GetForm().Controls.Add(m_textBox);
                    m_textBox.BringToFront();
                }
                return m_textBox;
            }
        }

        public Setting_CustomBarCellData m_cellInfo { private set; get; }

        public CustomBarCell(int index)
        {
            Update(index);
            this.m_cellInfo.Name_Button = "方案" + index.ToString();
            this.UI_Button.Text = this.m_cellInfo.Name_Button;
        }

        public CustomBarCell(Setting_CustomBarCellData data,int index)
        {
            m_cellInfo = data;
            Update(index);
            this.UI_Button.Text = data.Name_Button;
        }



        public void Update(int index)
        {
            Update_Info(index);
            Update_UI(index);
        }

        private void Update_Info(int index)
        {
            if (index == 0)
                this.m_cellInfo = CustomBar.FristCellInfo;
            else
            {
                if(this.m_cellInfo == null)
                   this.m_cellInfo = new Setting_CustomBarCellData();
                Setting_Point fristButtonPoint = CustomBar.FristCellInfo.Point_Button;
                Setting_Size fristButtonSize = CustomBar.FristCellInfo.Size_Button;
                this.m_cellInfo.Point_Button = new Setting_Point(fristButtonPoint.X + fristButtonSize.Width * index, fristButtonPoint.Y);
                this.m_cellInfo.Size_Button = fristButtonSize;
                Setting_Point fristTextPoint = CustomBar.FristCellInfo.Point_TextBox;
                Setting_Size fristTextSize = CustomBar.FristCellInfo.Size_TextBox;
                this.m_cellInfo.Point_TextBox = new Setting_Point(this.m_cellInfo.Point_Button.X + 3, fristTextPoint.Y);
                this.m_cellInfo.Size_TextBox = fristTextSize;
            }
        }

        private void Update_UI(int index)
        {
            BtnIndex = index;
            this.UI_Button.Location = new Point(m_cellInfo.Point_Button.X, m_cellInfo.Point_Button.Y);
            this.UI_Button.Size = new Size(m_cellInfo.Size_Button.Width, m_cellInfo.Size_Button.Height);
            this.UI_Button.Tag = "CustomBar_Button_" + index.ToString();

            this.UI_TextBox.Location = new Point(m_cellInfo.Point_TextBox.X, m_cellInfo.Point_TextBox.Y);
            this.UI_TextBox.Size = new Size(m_cellInfo.Size_TextBox.Width, m_cellInfo.Size_TextBox.Height);
            this.UI_TextBox.Tag = "CustomBar_TextBox_" + index.ToString();
            this.UI_TextBox.Visible = false;


        }
        private void OnBtnClick(object sender, EventArgs e)
        {
            if (m_OnBtnClickEvent != null)
                m_OnBtnClickEvent.Invoke(this.BtnIndex);
        }

        public void RemoveUI()
        {
            Form1 form = Program.GetForm();
            foreach (Control c in form.Controls)
            {
                if (c is Button)
                {
                    Button btn = (Button)c;
                    if (btn.Tag != null && btn.Tag.Equals("CustomBar_Button_" + this.BtnIndex.ToString()))
                    {
                        form.Controls.Remove(c);
                        c.Dispose();
                    }
                }
                if (c is TextBox)
                {
                    TextBox text = (TextBox)c;
                    if (text.Tag != null && text.Tag.Equals("CustomBar_TextBox_" + this.BtnIndex.ToString()))
                    {
                        form.Controls.Remove(c);
                        c.Dispose();
                    }
                }
            }
        }


        public void Edit()
        {
            UI_TextBox.Text = UI_Button.Text;
            UI_TextBox.Visible = true;
            UI_Button.Visible = false;
        }

        public Setting_CustomBarCellData EditComplete()
        {
            if(UI_TextBox.Visible)
               UI_Button.Text = UI_TextBox.Text;
            UI_TextBox.Visible = false;
            UI_Button.Visible = true;

            m_cellInfo.Name_Button = UI_Button.Text;
            return m_cellInfo;
        }
    }

}
