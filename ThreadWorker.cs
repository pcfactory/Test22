using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace YouTube_DownloaderAPP
{
    class ThreadWorker
    {
        public event EventHandler ThreadDone;

        public void Run()
        {
            // Do a task

            if (ThreadDone != null)
                ThreadDone(this, EventArgs.Empty);
        }
    }
}
 