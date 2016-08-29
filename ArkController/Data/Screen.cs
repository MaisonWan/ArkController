using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using ArkController.Kit;

namespace ArkController.Data
{
    /// <summary>
    /// 屏幕管理
    /// </summary>
    public class Screen
    {
        private IConnect connect = null;
        public Screen(IConnect connect)
        {
            this.connect = connect;
        }

        /// <summary>
        /// 屏幕分辨率
        /// </summary>
        /// <returns></returns>
        public Size GetScreenSize()
        {
            string cmd = "shell wm size";
            string log = connect.ExecuteAdb(cmd).Trim();
            log = log.Replace("Physical size: ", "");
            string[] s = log.Split("x".ToCharArray());
            if (s.Length < 2)
            {
                return Size.Empty;
            }
            int width = Convert.ToInt32(s[0]);
            int height = Convert.ToInt32(s[1]);
            return new Size(width, height);
        }

        /// <summary>
        /// 得到屏幕的像素密度
        /// </summary>
        /// <returns></returns>
        public int GetScreenDensity()
        {
            string cmd = "shell wm density";
            string log = connect.ExecuteAdb(cmd).Trim();
            log = log.Replace("Physical density: ", "");
            return Convert.ToInt32(log);
        }
    }
}
