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
                Assembly a = Assembly.GetExecutingAssembly();
                //注意格式 程序集名称.文件名
                //AccessEmbedded是我的项目的程序集名称
                var i = a.GetManifestResourceStream("AccessEmbedded.adb.exe");
                //释放资源
                var o = File.Open(adbPath, FileMode.Create);
                CopyStream(i, o);
            }
        }

        /// <summary>
        /// 拷贝文件流
        /// </summary>
        /// <param name="i"></param>
        /// <param name="o"></param>
        public static void CopyStream(Stream i, Stream o)
        {
            byte[] b = new byte[32768];
            while (true)
            {
                int r = i.Read(b, 0, b.Length);
                if (r <= 0)
                {
                    return;
                }
                o.Write(b, 0, r);
            }
        }
    }
}
