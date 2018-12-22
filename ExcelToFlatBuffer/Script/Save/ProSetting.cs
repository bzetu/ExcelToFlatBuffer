using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatBuffer
{
    [Serializable]
    public class ProSetting : CacheBase<ProSetting>, ICache
    {
        private List<Setting_CustomBarCellData> m_CustomBarCellList = new List<Setting_CustomBarCellData>();
        public int curSelectTabIndex = 0;

        private bool m_isDrty;
        public bool IsDrty {
            private set {
                m_isDrty = value;
            }
            get { return m_isDrty;  }
        }


        #region 框架接口
        public void OnInit()
        {
            InitNoSerializedData();
        }

        public void OnDeserializeFinish()
        {
            InitNoSerializedData();
        }
        #endregion
        public void InitNoSerializedData()
        {

        }

        public void AddCustomBarCell(Setting_CustomBarCellData cell)
        {
            m_CustomBarCellList.Add(cell);
            IsDrty = m_CustomBarCellList.Count > 1;
        }

        public void RemoveCustomBarCell(int index)
        {
            if (index < m_CustomBarCellList.Count)
            {
                m_CustomBarCellList.RemoveAt(index);
                IsDrty = true;
            }
        }

        public List<Setting_CustomBarCellData> GetCustomBarCellList()
        {
            return m_CustomBarCellList;
        }

        public bool SavePath(int tabIndex, string path_Excel, string path_OutCode, string path_OutByte)
        {
            if (tabIndex < m_CustomBarCellList.Count)
            {
                Setting_CustomBarCellData cell = m_CustomBarCellList[tabIndex];
                cell.Path_Excel = path_Excel;
                cell.Path_OutCode = path_OutCode;
                cell.Path_OutByte = path_OutByte;
                IsDrty = true;
            }
            return false;
        }

        public Setting_CustomBarCellData GetTabCellData(int tabIndex)
        {
            if (tabIndex < m_CustomBarCellList.Count)
            {
                return m_CustomBarCellList[tabIndex];
            }
            return null;
        }

        public bool SetTableCellData(int tabIndex, Setting_CustomBarCellData cell)
        {
            if (tabIndex < m_CustomBarCellList.Count)
            {
                m_CustomBarCellList[tabIndex] = cell;
                IsDrty = true;
                return true;
            }
            return false;
        }

        public string GetCurExcelPath()
        {
            if (this.curSelectTabIndex < m_CustomBarCellList.Count)
            {
                var data = m_CustomBarCellList[this.curSelectTabIndex];
                return data.Path_Excel;
            }
            return null;
        }

        public override bool Save()
        {
            IsDrty = false;
            return base.Save();
        }
    }
    [Serializable]
    public class Setting_CustomBarCellData
    {
        [NonSerialized]
        public Setting_Point Point_Button;
        [NonSerialized]
        public Setting_Size Size_Button;
        public string Name_Button;
        [NonSerialized]
        public Setting_Point Point_TextBox;
        [NonSerialized]
        public Setting_Size Size_TextBox;

        public string Path_Excel;
        public string Path_OutCode;
        public string Path_OutByte;
    }


    [Serializable]
    public class Setting_Point
    {
        public int X;
        public int Y;
        public Setting_Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    [Serializable]
    public class Setting_Size
    {
        public int Width;
        public int Height;
        public Setting_Size(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
