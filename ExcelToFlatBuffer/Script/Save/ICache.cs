using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ExcelToFlatBuffer
{
    public interface ICache
    {
        //如果本地没有缓存第一次会被执行
        void OnInit();
        //如果本地有缓存，将在反序列化后执行
        void OnDeserializeFinish();
    }

    [System.Serializable]
    public class CacheBase<T> where T : class, ICache, new()
    {
        private static T sInstance;
        private static readonly object sysob = new object();

        ~CacheBase()
        {

        }

        public static T Instance
        {
            get
            {
                if (sInstance == null)
                {
                    lock (sysob)
                    {
                        ReadLocalData();
                    }
                }
                return sInstance;
            }
        }

        private static void ReadLocalData()
        {
            string dataPath = Path.Combine(Setting.ExeRootPath, typeof(T).ToString() + ".setting");
            //Debug.LogError(dataPath);
            FileStream file = null;
            try
            {
                if (File.Exists(dataPath))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    file = File.Open(dataPath, FileMode.Open);
                    file.Position = 0;
                    // 反序列化数据;
                    sInstance = (T)bf.Deserialize(file);

                }
            }
            catch (System.Exception e)
            {
                file = null;
                System.Console.WriteLine("[READ LOCALDATA FAIL] :" + e.Message);
            }

            if (file != null)
            {
                file.Close();
                file.Dispose();
                if (sInstance != null)
                    sInstance.OnDeserializeFinish();
            }
            else
            {
                sInstance = new T();
                sInstance.OnInit();
            }

        }

        /// <summary>
        /// 保存到本地缓存
        /// </summary>
        /// <returns></returns>
        public virtual bool Save()
        {
            FileStream file = null;
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                string filePath = Path.Combine(Setting.ExeRootPath, Instance.GetType().ToString() + ".setting");
                file = File.Open(filePath, FileMode.OpenOrCreate);
                if (null != file)
                {
                    // 序列化;
                    file.Position = 0;
                    bf.Serialize(file, sInstance);
                }
            }
            catch (System.Exception e)
            {
                Debug.LogError("[SAVE FAIL] :" + e.Message);
            }
            if (file != null)
            {
                file.Close();
                file.Dispose();
                return true;
            }
            return false;
        }


        /// <summary>
        /// 清空内存中的缓存
        /// </summary>
        public static void Reset()
        {
            sInstance = null;
        }

        /// <summary>
        /// 移除本地缓存文件
        /// </summary>
        /// <returns></returns>
        public static bool RemoveLocalCache()
        {
            string filePath = Path.Combine(Setting.ExeRootPath, Instance.GetType().ToString() + ".bin");
            if(File.Exists(filePath))
            {
                File.Delete(filePath);
                return true;
            }
            return false;
        }
    }
}
