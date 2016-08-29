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
    public class ScreenData
    {
        private IConnect connect = null;
        public ScreenData(IConnect connect)
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
            string[] lines = log.Split("\n".ToCharArray());
            if (lines.Length > 1)
            {
                log = lines[1].Replace("Override size:", "");
            }
            else
            {
                log = log.Replace("Physical size: ", "");
            }
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

        /// <summary>
        /// 设置屏幕尺寸
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public bool SetScreenSize(int width, int height)
        {
            string cmd = String.Format("shell wm size {0}x{1}", width, height);
            string log = connect.ExecuteAdb(cmd);
            if (log == "")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 重置屏幕尺寸
        /// </summary>
        /// <returns></returns>
        public bool ResetScreenSize()
        {
            string cmd = String.Format("shell wm size reset");
            string log = connect.ExecuteAdb(cmd);
            if (log == "")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 设置屏幕像素密度
        /// </summary>
        /// <param name="density">像素密度</param>
        /// <returns></returns>
        public bool SetScreenDensity(int density)
        {
            string cmd = String.Format("shell wm density {0}", density);
            string log = connect.ExecuteAdb(cmd);
            if (log == "")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 重置屏幕像素密度
        /// </summary>
        /// <returns></returns>
        public bool ResetScreenDensity()
        {
            string cmd = String.Format("shell wm density reset");
            string log = connect.ExecuteAdb(cmd);
            if (log == "")
            {
                return true;
            }
            return false;
        }
    }
}
