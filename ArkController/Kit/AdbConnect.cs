using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using ArkController.Data;

namespace ArkController.Kit
{
    public class AdbConnect : IConnect
    {
        private Log log = null;
        private Command command = null;
        private string serial = null;

        public AdbConnect()
        {
            command = new Command();
        }

        /// <summary>
        /// 显示log
        /// </summary>
        public Log Log
        {
            set { this.log = value; }
            get { return this.log; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyCode"></param>
        /// <returns></returns>
        public bool InputKey(int keyCode)
        {
            string cmd = "shell input keyevent " + keyCode;
            string result = ExecuteAdb(cmd);
            log.Write(result);
            return true;
        }

        /// <summary>
        /// 输入文本
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool InputText(string text)
        {
            if (text == "")
            {
                return false;
            }
            string cmd = String.Format("shell input text \"{0}\"", text);
            string result = ExecuteAdb(cmd);
            log.Write("发送\"" + text + "\"成功");
            return true;
        }

        /// <summary>
        /// 执行命令
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public bool InputCommand(string cmd)
        {
            string result = ExecuteAdb(cmd);
            log.Write(result);
            return true;
        }

        /// <summary>
        /// 获取截图并且回传到本地
        /// </summary>
        /// <param name="localPath"></param>
        /// <returns></returns>
        public Image GetScreenShot(string localPath)
        {
            string cmdshot = "shell screencap -p";// /sdcard/screenshot.png";
            //string pullFile = "pull /sdcard/screenshot.png \"" + localPath + "\"";
            //File.Delete(localPath);
            //string r = ExecuteAdb(cmdshot);
            StreamReader reader = ExecuteAdbStream(cmdshot, true);
            List<byte> list = new List<byte>();
            int one;
            while ((one = reader.BaseStream.ReadByte()) > -1)
            {
                if (one != '\r')
                {
                    list.Add((byte)one);
                }
            }
            byte[] bytes = list.ToArray();
            MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);
            Image image = Image.FromStream(ms);
            //ExecuteAdb(pullFile);
            //if (File.Exists(localPath))
            //{
            //    return true;
            //}
            //return false;
            return image;
        }

        /// <summary>
        /// 安装本地apk
        /// </summary>
        /// <param name="apkPath">apk路径</param>
        /// <returns></returns>
        public bool Install(string apkPath)
        {
            string cmd = String.Format("install -r \"{0}\"", apkPath);
            string result = ExecuteAdb(cmd);
            log.Write(result);
            if (result.Contains("Success"))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 卸载程序包名
        /// </summary>
        /// <param name="packageName"></param>
        /// <returns></returns>
        public bool Uninstall(string packageName)
        {
            string cmd = "uninstall " + packageName;
            string result = ExecuteAdb(cmd);
            log.Write(result);
            return false;
        }

        /// <summary>
        /// 启动一个程序
        /// </summary>
        /// <param name="package"></param>
        /// <param name="activity"></param>
        /// <returns></returns>
        public bool StartAm(string package, string activity)
        {
            string cmd = String.Format("shell am start -n {0}/{1}", package, activity);
            string result = ExecuteAdb(cmd);
            log.Write(result);
            return true;
        }

        /// <summary>
        /// 启动一个程序
        /// </summary>
        /// <param name="param">自定义组合参数</param>
        /// <returns></returns>
        public bool StartAm(string param)
        {
            string cmd = String.Format("shell am start {0}", param);
            string result = ExecuteAdb(cmd);
            log.Write(result);
            return true;
        }

        /// <summary>
        /// 得到程序列表
        /// </summary>
        /// <returns></returns>
        public string[] GetPackageList(string args)
        {
            // -f带安装位置
            string cmd = "shell pm list package -f -i";
            if (args != null)
            {
                cmd += " " + args;
            }
            string result = ExecuteAdb(cmd).Trim();
            return result.Split("\n".ToCharArray());
        }

        public string ExecuteAdb(string cmd)
        {
            return ExecuteAdb(cmd, true);
        }

        public string ExecuteAdb(string cmd, bool sure)
        {
            if (sure && serial != null)
            {
                cmd = "-s " + serial + " " + cmd;
            }
            return command.ExecuteAdb(cmd);
        }

        public StreamReader ExecuteAdbStream(string cmd, bool sure)
        {
            if (sure && serial != null)
            {
                cmd = "-s " + serial + " " + cmd;
            }
            return command.ExecuteAdbStream(cmd);
        }

        /// <summary>
        /// 设置当前设备序列号
        /// </summary>
        /// <param name="serial"></param>
        public void SetDeviceSerial(string value)
        {
            this.serial = value;
        }

        /// <summary>
        /// 获取当前设备序列号
        /// </summary>
        /// <returns></returns>
        public string GetDeviceSerial()
        {
            return this.serial;
        }

        /// <summary>
        /// 写log
        /// </summary>
        /// <param name="log"></param>
        public void WriteLog(string log)
        {
            this.log.Write(log);
        }
    }
}
