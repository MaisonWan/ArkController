using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

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
        public void UpdatePackageList(ListView listView, string filterName, bool needFilter)
        {
            string[] packages = connect.GetPackageList();
            listView.BeginUpdate();
            listView.Items.Clear();
            bool need = needFilter & filterName.Length > 0;
            //string filterName = this.textBoxFilter.Text;
            foreach (string p in packages)
            {
                string pkg = p.Replace("package:", "").Trim();
                string[] items = pkg.Split("=".ToCharArray());
                // 不需要过滤，或者其中包含这个关键词
                if (!need || items[0].Contains(filterName))
                {
                    ListViewItem item = new ListViewItem(items[1]);
                    item.SubItems.Add(items[0]);
                    listView.Items.Add(item);
                }
            }
            listView.EndUpdate();
        }

        /// <summary>
        /// 打开程序详细信息
        /// </summary>
        public void OpenApplicationDetail(string packageName)
        {
            const string action = "android.settings.APPLICATION_DETAILS_SETTINGS";
            string param = string.Format("-a {0} -d package:{1}", action, packageName);
            connect.StartAm(param);
        }

        /// <summary>
        /// 打开设备信息
        /// </summary>
        public void OpenDeviceInfoSetting()
        {
            const string action = "android.settings.DEVICE_INFO_SETTINGS";
            string param = string.Format("-a {0}", action);
            connect.StartAm(param);
        }

        /// <summary>
        /// 打开开发者选项
        /// </summary>
        public void OpenDevementSetting()
        {
            const string action = "android.settings.APPLICATION_DEVELOPMENT_SETTINGS";
            string param = string.Format("-a {0}", action);
            connect.StartAm(param);
        }

        /// <summary>
        /// 清空应用数据
        /// </summary>
        /// <param name="packageName"></param>
        public void ClearApplicationData(string packageName)
        {
            string cmd = "shell pm clear " + packageName;
            string log = connect.ExecuteAdb(cmd);
            connect.WriteLog(log);
        }
    }
}
