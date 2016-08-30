using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ArkController.Kit
{
    /// <summary>
    /// 守护类
    /// </summary>
    public class Protect
    {
        /// <summary>
        /// 核实adb文件是否存在，不存在则拷贝一个
        /// </summary>
        public static void CheckAdb()
        {
            string adbPath = "./adb/adb.exe";
            if (!File.Exists(adbPath))
            {
                Directory.CreateDirectory("./adb/");
                //释放资源
                var outStream = File.Open(adbPath, FileMode.OpenOrCreate);
                byte[] data = global::ArkController.Properties.Resources.adb;
                outStream.Write(data, 0, data.Length);
                outStream.Flush();
                outStream.Close();
            }
        }
    }
}
