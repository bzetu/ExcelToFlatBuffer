using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System;
using System.Threading;
using System.Collections.Generic;

namespace CompileCShap
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateManager.Instance.Execute();
            //Console.ReadKey();
        }
    }

    public class TaskList
    {
        private Thread thread;
        private static TaskList m_Instance;
        private bool IsFormRunning;
        private Queue<TaskInfo> m_actionQueue = new Queue<TaskInfo>();


        public static TaskList Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = new TaskList();
                }
                return m_Instance;
            }
        }
        private TaskList()
        {
            IsFormRunning = true;
            thread = new Thread(new ThreadStart(UIThread));
            thread.Start();
            
        }

        public void UIThread()
        {
            while (IsFormRunning)
            {
                Thread.Sleep(20);
                Update();
            }
        }

        private void Update()
        {
            if (m_actionQueue.Count == 0)
                return;
            TaskInfo taskInfo = m_actionQueue.Dequeue();
            if (taskInfo != null)
            {
                if(taskInfo.CallBack != null)
                   taskInfo.CallBack.Invoke(taskInfo.Param);
                if (taskInfo.CallBack_NoParam != null)
                    taskInfo.CallBack_NoParam.Invoke();
            }
        }

        public void AddTask(Action<object> action,object param = null)
        {
            lock (m_actionQueue)
            {
                m_actionQueue.Enqueue(new TaskInfo(action, param));
            }
        }
        public void AddTask(Action action)
        {
            lock (m_actionQueue)
            {
                m_actionQueue.Enqueue(new TaskInfo(action));
            }
        }

        public void Close()
        {
            IsFormRunning = false;
        }

    }

    public class TaskInfo
    {
        public System.Action CallBack_NoParam { private set; get; }

        public System.Action<object> CallBack { private set; get; }
        public object Param { private set; get; }

        public TaskInfo(System.Action<object> callBack,object param)
        {
            CallBack = callBack;
            Param = param;
        }

        public TaskInfo(System.Action callBack)
        {
            CallBack_NoParam = callBack;
        }
    }
}


