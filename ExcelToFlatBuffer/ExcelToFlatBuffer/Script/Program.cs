using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToFlatBuffer
{
    static class Program
    {
        private static Form1 m_form;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(GetForm()); 
        }


        public static Form1 GetForm()
        {
            if(m_form == null)
                m_form = new Form1();
            return m_form;
        }

        public static void Exit()
        {
            if (m_form != null)
                m_form.Close();
        }

        public static void UpdateUserSettingPath()
        {
            if (m_form != null)
                m_form.UpdateUserSettingPath();
        }


        

    }
}
