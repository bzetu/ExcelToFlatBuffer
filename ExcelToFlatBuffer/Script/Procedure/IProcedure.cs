using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NPOI;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace ExcelToFlatBuffer
{
    public interface IProcedure
    {
        bool Procedure_ReadExcel();
        bool Proceduree_GenerateFbs(ExcelData excelData);
        bool Procedure_GenerateFlatBufferCode(ExcelData excelData);
        bool Procedure_ChangeFlatBufferCode(ExcelData excelData);
        bool Procedure_GenerateBuildFlatBufferCode(ExcelData excelData);
        bool Procedure_CompileCode();
        bool Procedure_GenerateBytes();
    }

    public partial class Procedure : IProcedure
    {
        private static Procedure m_Instance;

        private Queue<System.Action> m_actionQueue = new Queue<Action>();

        private Dictionary<string, bool> m_loading = new Dictionary<string, bool>();

        public static Procedure Instance
        {
            get
            {
                if (m_Instance == null)
                    m_Instance = new Procedure();
                return m_Instance;
            }
        }


        public bool Execute()
        {
            if (m_Instance == null)
                m_Instance = new Procedure();

            Tools.DeleteFilesWithoutFolder(Setting.GenerateByteFilePath);
            Tools.DeleteFilesWithoutFolder(Setting.GenerateFlatCodePath);
            //Tools.DeleteFilesWithoutFolder(Setting.ProgramFlatCodeDirPath);

            return m_Instance.Procedure_ReadExcel();
        }


        public void Update()
        {
            if (m_actionQueue.Count == 0)
                return;
            System.Action action = m_actionQueue.Dequeue();
            if (action != null)
                action.Invoke();
        }

        /// <summary>
        /// 分帧处理
        /// </summary>
        public void AddDelayRun(System.Action action)
        {
            lock (m_actionQueue)
            {
                m_actionQueue.Enqueue(action);
            }
        }


        public void GenerateFile(byte[] buffer,string path)
        {
            try
            {
                System.IO.File.WriteAllBytes(path, buffer);
            }
            catch (Exception error)
            {
                Debug.LogError(error);
            }
            
        }

        public bool GenerateFile(string content, string path)
        {
            try
            {
                System.IO.File.WriteAllText(path, content);
                return true;
            }
            catch (Exception error)
            {
                Debug.LogError(error);
                return false;
            }
            
        }

        public void SetGenerateCodeFinish(string codeName)
        {
            if (m_loading.ContainsKey(codeName))
                m_loading[codeName] = true;
            else
                Debug.LogError("生成代码"+ codeName + "成功,但它并没有注册");
        }

        public bool IsAllCodeGenerateFinish
        {
            get
            {
                foreach (bool value in m_loading.Values)
                {
                    if (!value)
                        return false;
                }
                return true;
            }
        }

    }


    public class ExcelData
    {
        public string Name { private set; get; }

        public string Path { private set; get; }

        public string Extension { private set; get; }

        public string FileName { private set; get; }

        public string FbsPath { private set; get; }

        private List<List<string>> m_DataCache;

        public ExcelData(string excelPath)
        {
            Path = excelPath;
            FileName = System.IO.Path.GetFileName(excelPath);
            Extension = System.IO.Path.GetExtension(excelPath);
            Name = FileName.Replace(Extension, "");
            FbsPath = Path.Replace(Extension, ".fbs");

            m_DataCache = new List<List<string>>();
        }

        public void AddRowData(List<string> rowData)
        {
            m_DataCache.Add(rowData);
        }

        public List<string> GetRowData(int rowIndex)
        {
            List<string> rowDataList = null;
            if (rowIndex < m_DataCache.Count)
            {
                rowDataList = m_DataCache[rowIndex];
            }
            return rowDataList;
        }

        public List<List<string>> GetAllRows()
        {
            return m_DataCache;
        }
    }

}



