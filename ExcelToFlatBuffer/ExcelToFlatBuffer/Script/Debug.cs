using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ExcelToFlatBuffer
{
    public class Debug
    {
        public static ListBox m_lisBox;
        public static StringBuilder m_strLog;
        public static void Init(ListBox lisBox)
        {
            m_strLog = new StringBuilder();
            m_lisBox = lisBox;
        }

        public static void Log(object content)
        {
            string text = content.ToString();
            m_strLog.Append(text);
            m_lisBox.Items.Add(text);
        }

        public static void LogError(object content)
        {
            string text = "[ERROR]=>" + content.ToString();
            m_strLog.Append(text);
            m_lisBox.Items.Add(text);
            Console.WriteLine(text);
        }
    }

}
