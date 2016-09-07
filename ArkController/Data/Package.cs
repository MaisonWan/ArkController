using System;
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
        public static void UpdatePackageList(ListView listView, string[] packages, string filterName, bool needFilter)
        {
            listView.BeginUpdate();
            listView.Items.Clear();
            bool need = needFilter & filterName.Length > 0;
            //string filterName = this.textBoxFilter.Text;
            foreach (string p in packages)
            {
                if (string.IsNullOrEmpty(p))
                {
                    continue;
                }
                string pkg = p.Replace("package:", "").Trim();
                string[] items = pkg.Split("=".ToCharArray());
                // 不需要过滤，或者其中包含这个关键词
                if (!need || items[0].Contains(filterName))
                {
                    // 去掉installer
                    ListViewItem item = new ListViewItem(items[1].Replace("  installer", ""));
                    item.SubItems.Add(items[0]);
                    if (items[0].StartsWith("/system"))
                    {
                        item.SubItems.Add("系统应用");
                    }
                    else
                    {
                        item.SubItems.Add("第三方应用");
                    }
                    item.SubItems.Add(items[2] == "null" ? "无" : items[2]);
                    listView.Items.Add(item);
                }
            }
            listView.EndUpdate();
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
    }
}
