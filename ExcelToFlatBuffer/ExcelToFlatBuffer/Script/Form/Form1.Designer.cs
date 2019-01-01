namespace ExcelToFlatBuffer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBox_Log = new System.Windows.Forms.ListBox();
            this.Btn_Run = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_ExportLog = new System.Windows.Forms.Button();
            this.TextField_ExcelPaths = new System.Windows.Forms.TextBox();
            this.Btn_ExcelPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_CodePath = new System.Windows.Forms.Button();
            this.TextField_CodePaths = new System.Windows.Forms.TextBox();
            this.UI_DropList_Language = new System.Windows.Forms.ComboBox();
            this.UI_DropList_Use = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_BytesPath = new System.Windows.Forms.Button();
            this.TextField_BytesPaths = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存当前配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UI_DropList_Analysis = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBox_Log
            // 
            this.ListBox_Log.FormattingEnabled = true;
            this.ListBox_Log.ItemHeight = 15;
            this.ListBox_Log.Location = new System.Drawing.Point(19, 218);
            this.ListBox_Log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBox_Log.Name = "ListBox_Log";
            this.ListBox_Log.Size = new System.Drawing.Size(605, 349);
            this.ListBox_Log.TabIndex = 0;
            // 
            // Btn_Run
            // 
            this.Btn_Run.Location = new System.Drawing.Point(653, 416);
            this.Btn_Run.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Run.Name = "Btn_Run";
            this.Btn_Run.Size = new System.Drawing.Size(157, 80);
            this.Btn_Run.TabIndex = 1;
            this.Btn_Run.Text = "生成代码与资源";
            this.Btn_Run.UseVisualStyleBackColor = true;
            this.Btn_Run.Click += new System.EventHandler(this.OnBtnClick_Run);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "日志:";
            // 
            // Btn_ExportLog
            // 
            this.Btn_ExportLog.Location = new System.Drawing.Point(653, 260);
            this.Btn_ExportLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ExportLog.Name = "Btn_ExportLog";
            this.Btn_ExportLog.Size = new System.Drawing.Size(157, 80);
            this.Btn_ExportLog.TabIndex = 4;
            this.Btn_ExportLog.Text = "导出日志";
            this.Btn_ExportLog.UseVisualStyleBackColor = true;
            this.Btn_ExportLog.Click += new System.EventHandler(this.OnBtnClick_ExportLog);
            // 
            // TextField_ExcelPaths
            // 
            this.TextField_ExcelPaths.Location = new System.Drawing.Point(128, 16);
            this.TextField_ExcelPaths.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextField_ExcelPaths.Name = "TextField_ExcelPaths";
            this.TextField_ExcelPaths.Size = new System.Drawing.Size(297, 25);
            this.TextField_ExcelPaths.TabIndex = 8;
            // 
            // Btn_ExcelPath
            // 
            this.Btn_ExcelPath.Location = new System.Drawing.Point(432, 18);
            this.Btn_ExcelPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ExcelPath.Name = "Btn_ExcelPath";
            this.Btn_ExcelPath.Size = new System.Drawing.Size(75, 25);
            this.Btn_ExcelPath.TabIndex = 7;
            this.Btn_ExcelPath.Text = "浏览";
            this.Btn_ExcelPath.UseVisualStyleBackColor = true;
            this.Btn_ExcelPath.Click += new System.EventHandler(this.OnBtnClick_ExcelPath);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Excel路径:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(531, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "注:多个路径用;隔开";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(531, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "语言";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(7, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "代码生成路径:";
            // 
            // Btn_CodePath
            // 
            this.Btn_CodePath.Location = new System.Drawing.Point(432, 50);
            this.Btn_CodePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_CodePath.Name = "Btn_CodePath";
            this.Btn_CodePath.Size = new System.Drawing.Size(75, 25);
            this.Btn_CodePath.TabIndex = 11;
            this.Btn_CodePath.Text = "浏览";
            this.Btn_CodePath.UseVisualStyleBackColor = true;
            this.Btn_CodePath.Click += new System.EventHandler(this.OnBtnClick_CodePath);
            // 
            // TextField_CodePaths
            // 
            this.TextField_CodePaths.Location = new System.Drawing.Point(167, 49);
            this.TextField_CodePaths.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextField_CodePaths.Name = "TextField_CodePaths";
            this.TextField_CodePaths.Size = new System.Drawing.Size(259, 25);
            this.TextField_CodePaths.TabIndex = 12;
            // 
            // UI_DropList_Language
            // 
            this.UI_DropList_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UI_DropList_Language.FormattingEnabled = true;
            this.UI_DropList_Language.Location = new System.Drawing.Point(573, 50);
            this.UI_DropList_Language.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_DropList_Language.Name = "UI_DropList_Language";
            this.UI_DropList_Language.Size = new System.Drawing.Size(79, 23);
            this.UI_DropList_Language.TabIndex = 15;
            this.UI_DropList_Language.SelectedIndexChanged += new System.EventHandler(this.UI_DropList_Language_SelectedIndexChanged);
            // 
            // UI_DropList_Use
            // 
            this.UI_DropList_Use.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UI_DropList_Use.FormattingEnabled = true;
            this.UI_DropList_Use.Location = new System.Drawing.Point(717, 50);
            this.UI_DropList_Use.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_DropList_Use.Name = "UI_DropList_Use";
            this.UI_DropList_Use.Size = new System.Drawing.Size(79, 23);
            this.UI_DropList_Use.TabIndex = 17;
            this.UI_DropList_Use.SelectedIndexChanged += new System.EventHandler(this.UI_DropList_Use_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(675, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "用途";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(7, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "资源生成路径:";
            // 
            // Btn_BytesPath
            // 
            this.Btn_BytesPath.Location = new System.Drawing.Point(432, 84);
            this.Btn_BytesPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_BytesPath.Name = "Btn_BytesPath";
            this.Btn_BytesPath.Size = new System.Drawing.Size(75, 25);
            this.Btn_BytesPath.TabIndex = 18;
            this.Btn_BytesPath.Text = "浏览";
            this.Btn_BytesPath.UseVisualStyleBackColor = true;
            this.Btn_BytesPath.Click += new System.EventHandler(this.OnBtnClick_BytesPath);
            // 
            // TextField_BytesPaths
            // 
            this.TextField_BytesPaths.Location = new System.Drawing.Point(167, 82);
            this.TextField_BytesPaths.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextField_BytesPaths.Name = "TextField_BytesPaths";
            this.TextField_BytesPaths.Size = new System.Drawing.Size(259, 25);
            this.TextField_BytesPaths.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(869, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存当前配置ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 保存当前配置ToolStripMenuItem
            // 
            this.保存当前配置ToolStripMenuItem.Name = "保存当前配置ToolStripMenuItem";
            this.保存当前配置ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.保存当前配置ToolStripMenuItem.Text = "保存当前配置";
            this.保存当前配置ToolStripMenuItem.Click += new System.EventHandler(this.OnBtnClick_SaveSetting);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem1});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.关于ToolStripMenuItem.Text = "帮助";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem1
            // 
            this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
            this.关于ToolStripMenuItem1.Size = new System.Drawing.Size(114, 26);
            this.关于ToolStripMenuItem1.Text = "关于";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UI_DropList_Analysis);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TextField_ExcelPaths);
            this.groupBox1.Controls.Add(this.Btn_BytesPath);
            this.groupBox1.Controls.Add(this.Btn_ExcelPath);
            this.groupBox1.Controls.Add(this.TextField_BytesPaths);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UI_DropList_Use);
            this.groupBox1.Controls.Add(this.TextField_CodePaths);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Btn_CodePath);
            this.groupBox1.Controls.Add(this.UI_DropList_Language);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(19, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(835, 116);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(531, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "解析";
            // 
            // UI_DropList_Analysis
            // 
            this.UI_DropList_Analysis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UI_DropList_Analysis.FormattingEnabled = true;
            this.UI_DropList_Analysis.Location = new System.Drawing.Point(573, 82);
            this.UI_DropList_Analysis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_DropList_Analysis.Name = "UI_DropList_Analysis";
            this.UI_DropList_Analysis.Size = new System.Drawing.Size(79, 23);
            this.UI_DropList_Analysis.TabIndex = 23;
            this.UI_DropList_Analysis.SelectedIndexChanged += new System.EventHandler(this.UI_DropList_Analysis_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 581);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_ExportLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Run);
            this.Controls.Add(this.ListBox_Log);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExcelToFlatBuffer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_Log;
        private System.Windows.Forms.Button Btn_Run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_ExportLog;
        private System.Windows.Forms.TextBox TextField_ExcelPaths;
        private System.Windows.Forms.Button Btn_ExcelPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_CodePath;
        private System.Windows.Forms.TextBox TextField_CodePaths;
        private System.Windows.Forms.ComboBox UI_DropList_Language;
        private System.Windows.Forms.ComboBox UI_DropList_Use;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_BytesPath;
        private System.Windows.Forms.TextBox TextField_BytesPaths;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存当前配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox UI_DropList_Analysis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

