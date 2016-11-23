using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ArkController.Data
{
    /// <summary>
    /// 执行命令
    /// </summary>
    public class Command
    {
        private Process p = null;
        private bool loopLogcat = true;

        public Command()
        {
            p = new Process();
        }

        /// <summary>
        /// 执行adb命令，然后返回结果
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public string ExecuteAdb(string cmd)
        {
            updateProcessInfo(cmd);
            p.Start();
            StreamReader reader = new StreamReader(p.StandardOutput.BaseStream, Encoding.UTF8);
            string outStr = reader.ReadToEnd();
            p.Close();
            return outStr;
        }

        /// <summary>
        /// 返回流
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public StreamReader ExecuteAdbStream(string cmd)
        {
            updateProcessInfo(cmd);
            p.Start();
            return p.StandardOutput;
        }

        /// <summary>
        /// 异步执行，逐行回调
        /// </summary>
        /// <param name="cmd">执行的命令</param>
        /// <param name="callback">回调</param>
        public void ExecuteAdb(string cmd, Callback callback)
        {
            if (callback == null)
            {
                return;
            }
            loopLogcat = true;
            updateProcessInfo(cmd);
            p.Start();
            StreamReader reader = new StreamReader(p.StandardOutput.BaseStream, Encoding.UTF8);
            string line = reader.ReadLine();//每次读取一行
            while (loopLogcat && !reader.EndOfStream)
            {
                callback.onReceive(line);
                line = reader.ReadLine();
            }
            p.WaitForExit();//等待程序执行完退出进程
            p.Close();//关闭进程
            reader.Close();//关闭流
        }

        private void updateProcessInfo(string cmd)
        {
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "./adb/adb.exe";
            p.StartInfo.Arguments = cmd;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            //p.StartInfo.EnvironmentVariables["ANDROID_ADB_SERVER_PORT"] = "8603";
        }

        /// <summary>
        /// 退出循环执行的adb读取
        /// </summary>
        public void ExitExecuteAdb()
        {
            loopLogcat = false;
        }

        /// <summary>
        /// 执行回调
        /// </summary>
        public interface Callback
        {
            /// <summary>
            /// 接到一条消息之后执行
            /// </summary>
            /// <param name="line"></param>
            void onReceive(string line);
        }

    }
}
