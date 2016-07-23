using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace KibotController
{
    public class Log
    {
        private TextBox textboxLog = null;
        public Log(TextBox tb)
        {
            this.textboxLog = tb;
        }

        /// <summary>
        /// 写入log
        /// </summary>
        /// <param name="log"></param>
        public void Write(string log)
        {
            if (log == "")
            {
                return;
            }
            string c = String.Format("{0} {1}\n", DateTime.Now.ToLongTimeString(), log);
            this.textboxLog.AppendText(c);
        }
    }
}
