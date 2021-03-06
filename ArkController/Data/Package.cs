﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ArkController.Kit;

namespace ArkController.Data
{
    /// <summary>
    /// 安装程序包控制器
    /// </summary>
    public class Package
    {
        private IConnect connect = null;
        public Package(IConnect connect)
        {
            this.connect = connect;
        }

        /// <summary>
        /// 更新程序列表
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="filterName"></param>
        /// <param name="needFilter"></param>
        public static string[] UpdatePackageList(ListView listView, string[] packages, string filterName, bool needFilter)
        {
            listView.BeginUpdate();
            listView.Items.Clear();
            bool need = needFilter & filterName.Length > 0;
            string[] packageNames = new string[packages.Length];
            int index = 0;
            foreach (string p in packages)
            {
                if (string.IsNullOrEmpty(p))
                {
                    continue;
                }
                string pkg = p.Replace("package:", "").Trim();
                string[] items = pkg.Split("=".ToCharArray());
                // 不需要过滤，或者其中包含这个关键词
                if (!need || items[0].Contains(filterName) || items[1].Contains(filterName))
                {
                    // 去掉installer
                    string name = items[1].Replace("  installer", "");
                    ListViewItem item = new ListViewItem(name);
                    item.SubItems.Add(items[0]);
                    if (items[0].StartsWith("/system/app") || items[0].StartsWith("/system/priv-app") ||
                        items[0].StartsWith("/system/plugin") || items[0].StartsWith("/system/framework"))
                    {
                        item.SubItems.Add("系统应用");
                    }
                    else
                    {
                        item.SubItems.Add("第三方应用");
                    }
                    item.SubItems.Add(items[2] == "null" ? "无" : items[2]);
                    listView.Items.Add(item);
                    packageNames[index++] = name;
                }
            }
            listView.EndUpdate();
            return packageNames;
        }

        /// <summary>
        /// 打开程序详细信息
        /// </summary>
        public static string GetOpenApplicationDetail(string packageName)
        {
            const string action = "android.settings.APPLICATION_DETAILS_SETTINGS";
            return string.Format("-a {0} -d package:{1}", action, packageName);
        }

        /// <summary>
        /// 打开设备信息
        /// </summary>
        public static string GetOpenDeviceInfoSetting()
        {
            const string action = "android.settings.DEVICE_INFO_SETTINGS";
            return string.Format("-a {0}", action);
        }

        /// <summary>
        /// 打开wifi设置界面
        /// </summary>
        /// <returns></returns>
        public static string GetOpenWifiSetting()
        {
            const string action = "android.net.wifi.PICK_WIFI_NETWORK";
            return string.Format("-a {0}", action);
        }

        /// <summary>
        /// 打开开发者选项
        /// </summary>
        public static string GetDeveloperSetting()
        {
            const string action = "android.settings.APPLICATION_DEVELOPMENT_SETTINGS";
            return string.Format("-a {0}", action);
        }

        /// <summary>
        /// 清空应用数据
        /// </summary>
        /// <param name="packageName"></param>
        public static string GetClearApplicationData(string packageName)
        {
            return "shell pm clear " + packageName;
        }

        /// <summary>
        /// 隐藏应用
        /// </summary>
        /// <param name="packageName"></param>
        /// <returns></returns>
        public static string GetHideApplicationCommand(string packageName)
        {
            return "shell pm hide " + packageName;
        }

        /// <summary>
        /// 恢复应用
        /// </summary>
        /// <param name="packageName"></param>
        /// <returns></returns>
        public static string GetUnhideApplicationCommand(string packageName)
        {
            return "shell pm unhide " + packageName;
        }

        /// <summary>
        /// 导出安装程序到本地
        /// </summary>
        /// <param name="appLocation">设备上apk位置</param>
        /// <param name="localLocation">导出到本地的位置</param>
        /// <returns>命令</returns>
        public static string GetPullAppInstallApkCommand(string appLocation, string localLocation)
        {
            return string.Format("pull {0} \"{1}\"", appLocation, localLocation);
        }

        /// <summary>
        /// 推送文件到设备
        /// </summary>
        /// <param name="deviceLocation"></param>
        /// <param name="localLocation"></param>
        /// <returns></returns>
        public static string GetPushFileCommand(string deviceLocation, string localLocation)
        {
            return string.Format("push \"{0}\" \"{1}\"", localLocation, deviceLocation);
        }

        /// <summary>
        /// 结束该应用所有进程
        /// </summary>
        /// <param name="packageName">包名</param>
        /// <returns></returns>
        public static string GetKillAllProcessCommand(string packageName)
        {
            return "shell am force-stop " + packageName;
        }
    }
}
