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
                string pkg = p.Replace("package:", "");
                if (need)
                {
                    if (pkg.Contains(filterName))
                    {
                        listView.Items.Add(pkg);
                    }
                }
                else
                {
                    listView.Items.Add(pkg);
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
