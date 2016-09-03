using System;
using System.Collections.Generic;
using System.Text;
using ArkController.Data;
using ArkController.Kit;

namespace ArkController.Task
{
    /// <summary>
    /// 通信任务线程
    /// </summary>
    public class ConnectTaskThread : BaseTaskThread
    {
        private static ConnectTaskThread instance = null;

        private Log log = null;
        private AdbConnect connect = null;
        private DeviceManager manager = null;

        /// <summary>
        /// 单例模式
        /// </summary>
        /// <returns></returns>
        public static ConnectTaskThread GetInstance()
        {
            if (instance == null)
            {
                instance = new ConnectTaskThread();
            }
            return instance;
        }

        private ConnectTaskThread()
        {
            connect = new AdbConnect();
            manager = new DeviceManager(connect);
        }

        /// <summary>
        /// 显示的log
        /// </summary>
        public Log Log
        {
            set
            {
                this.log = value;
                this.connect.Log = value;
            }
        }

        /// <summary>
        /// 具体实现任务队列
        /// </summary>
        /// <param name="task"></param>
        public override void handleTask(TaskInfo task)
        {
            switch (task.What)
            {
                case TaskType.ExecuteCommand:
                    handleExecuteCommand(task);
                    break;
                case TaskType.SendKey:
                    handleInputKey((int)task.Data);
                    break;
                case TaskType.DeviceList:
                    handleDeviceList(task);
                    break;
                case TaskType.PackageList:
                    handlePackageList(task);
                    break;
            }
        }

        /// <summary>
        /// 写入log
        /// </summary>
        /// <param name="log"></param>
        private void writeLog(string content)
        {
            if (log != null)
            {
                log.Write(content);
            }
        }

        /// <summary>
        /// 执行命令，返回结果
        /// </summary>
        /// <param name="task"></param>
        private void handleExecuteCommand(TaskInfo task)
        {
            string result = connect.ExecuteAdb(task.Data.ToString());
            if (task.ResultHandler != null)
            {
                task.ResultHandler(result);
            }
            writeLog("获取电池信息");
        }

        /// <summary>
        /// 发送按键
        /// </summary>
        /// <param name="keyCode"></param>
        private void handleInputKey(int keyCode)
        {
            bool result = connect.InputKey(keyCode);
            writeLog(string.Format("发送按键{0}{1}", keyCode, result ? "成功" : "失败"));
        }

        /// <summary>
        /// 设备列表
        /// </summary>
        private void handleDeviceList(TaskInfo task)
        {
            string[] devices = manager.DeviceLink.DeviceList();
            if (task.ResultHandler != null)
            {
                task.ResultHandler(devices);
            }
            writeLog(string.Format("设备列表：{0}", string.Join(",", devices, 0, devices.Length)));
        }

        /// <summary>
        /// 包名列表
        /// </summary>
        /// <param name="task"></param>
        private void handlePackageList(TaskInfo task)
        {
            string[] packages = connect.GetPackageList(task.Data.ToString());
            if (task.ResultHandler != null)
            {
                task.ResultHandler(packages);
            }
            writeLog(string.Format("获取安装包名{0}个", packages.Length));
        }
    }
}
