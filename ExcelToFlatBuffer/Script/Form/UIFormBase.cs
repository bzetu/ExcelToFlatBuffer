using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ExcelToFlatBuffer
{
    public class UIFormBase : Form
    {
        private delegate void CallBackToUIThread();
        private bool IsFormRunning = false;
        private Thread thread;
        private static bool IsInit;

        private CallBackToUIThread Delegate_OnUpdate;
        private CallBackToUIThread Delegate_OnStart;
        public UIFormBase()
        {
            Delegate_OnUpdate = new CallBackToUIThread(OnUpdate);
            Delegate_OnStart = new CallBackToUIThread(OnStart);

            IsFormRunning = true;
            thread = new Thread(new ThreadStart(UIThread));
            thread.IsBackground = true;
            thread.Start();
            OnAwake();
        }


        public void UIThread()
        {
            while (IsFormRunning)
            {
                Thread.Sleep(20);
                if (this.InvokeRequired)
                {
                    if (IsFormRunning)
                        this.Invoke(Delegate_OnUpdate);
                    if (!IsInit)
                    {
                        this.Invoke(Delegate_OnStart);
                        IsInit = true;
                    }
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            IsFormRunning = false;
            thread.Abort();
            OnClose();
        }


        public virtual void OnUpdate()
        {

        }

        public virtual void OnAwake()
        {

        }

        public virtual void OnStart()
        {

        }

        public virtual void OnClose()
        {

        }

    }
}
