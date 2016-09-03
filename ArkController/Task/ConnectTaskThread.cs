using System;
using System.Collections.Generic;
using System.Drawing;
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
                case TaskType.ProcessList:
                    handleProcessList(task);
                    break;
                case TaskType.CurrentDeviceInfo:
                    handleCurrentDeviceInfo(task);
                    break;
                case TaskType.BatteryInfo:
                    handleBatteryInfo(task);
                    break;
                case TaskType.StartAM:
                    handleStartAm(task);
                    break;
                case TaskType.Install:
                    handleInstall(task);
                    break;
                case TaskType.Unintall:
                    handleUninstall(task);
                    break;
                case TaskType.InputText:
                    handleInputText(task);
                    break;
                case TaskType.ScreenShot:
                    handleScreenShot(task);
                    break;
                case TaskType.ScreenSizeDensity:
                    handleScreenSizeDensity(task);
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
            if (task.Data != null)
            {
                string result = connect.ExecuteAdb(task.Data.ToString());
                if (task.ResultHandler != null)
                {
                    task.ResultHandler.Invoke(result);
                }
                writeLog(string.Format("执行命令：{0}", task.Data));
            }
            else if (task.DataArray != null)
            {
                foreach (string cmd in task.DataArray)
                {
                    connect.ExecuteAdb(cmd);
                }
            }
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
                task.ResultHandler.Invoke(devices);
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
                task.ResultHandler.Invoke(packages);
            }
            writeLog(string.Format("获取安装包名{0}个", packages.Length));
        }

        /// <summary>
        /// 进程列表
        /// </summary>
        /// <param name="task"></param>
        private void handleProcessList(TaskInfo task)
        {
            List<ProcessData.Data> processList = manager.Process.GetCurrentProcessList();
            if (task.ResultHandler != null)
            {

                task.ResultHandler.Invoke(processList);
            }
            writeLog(string.Format("获取进程列表{0}个", processList.Count));
        }

        /// <summary>
        /// 获取当前设备列表
        /// </summary>
        /// <param name="task"></param>
        private void handleCurrentDeviceInfo(TaskInfo task)
        {
            this.connect.SetDeviceSerial(task.Data.ToString());
            string[] values = manager.DeviceLink.GetCurrentDeviceInfo();
            if (values != null)
            {
                if (task.ResultHandler != null)
                {
                    task.ResultHandler.Invoke(values);
                }
                writeLog(string.Format("获取到设备信息:{0}", string.Join(",", values, 0, values.Length)));
            }
        }

        /// <summary>
        /// 获取电池信息
        /// </summary>
        /// <param name="task"></param>
        private void handleBatteryInfo(TaskInfo task)
        {
            string cmd = "shell dumpsys battery";
            string result = connect.ExecuteAdb(cmd);
            if (!String.IsNullOrEmpty(result))
            {
                manager.BatteryParser = BatteryParser.Parser(result);
                if (task.ResultHandler != null)
                {
                    Image image = manager.BatteryParser.BatteryImage;
                    string info = manager.BatteryParser.BatteryFormatInfo;
                    task.ResultHandler.Invoke(image, info);
                }
                writeLog(string.Format("获取到电池信息"));
            }
        }

        /// <summary>
        /// 启动一个action
        /// </summary>
        /// <param name="task"></param>
        private void handleStartAm(TaskInfo task)
        {
            if (task.Data != null)
            {
                string action = (string)task.Data;
                connect.StartAm(action);
                writeLog(string.Format("启动{0}", action));
            }
            else if (task.DataArray != null)
            {
                string[] actions = (string[])task.DataArray;
                connect.StartAm(actions[0], actions[1]);
                writeLog(string.Format("启动{0}/{1}", actions[0], actions[1]));
            }
        }

        /// <summary>
        /// 安装程序
        /// </summary>
        /// <param name="task"></param>
        private void handleInstall(TaskInfo task)
        {

        }

        /// <summary>
        /// 卸载程序
        /// </summary>
        /// <param name="task"></param>
        private void handleUninstall(TaskInfo task)
        {
            string packageName = (string)task.Data;
            connect.Uninstall(packageName);
        }

        /// <summary>
        /// 输入文本
        /// </summary>
        /// <param name="task"></param>
        private void handleInputText(TaskInfo task)
        {
            string text = (string)task.Data;
            connect.InputText(text);
            writeLog(string.Format("输入文本：{0}", text));
        }

        /// <summary>
        /// 屏幕截图
        /// </summary>
        /// <param name="task"></param>
        private void handleScreenShot(TaskInfo task)
        {
            string path = task.Data.ToString();
            bool result = connect.GetScreenShot(path);
            if (task.ResultHandler != null)
            {
                task.ResultHandler.Invoke(result);
            }
            writeLog(string.Format("获取屏幕截图{0}", result ? "成功" : "失败"));
        }

        /// <summary>
        /// 屏幕尺寸和像素密度
        /// </summary>
        /// <param name="task"></param>
        private void handleScreenSizeDensity(TaskInfo task)
        {
            ScreenData.Action action = (ScreenData.Action)Enum.Parse(typeof(ScreenData.Action), (string)task.DataArray[0]);
            object result = null;
            switch (action)
            {
                case ScreenData.Action.GetDensity:
                    int density = manager.ScreenData.GetScreenDensity();
                    result = density;
                    writeLog(string.Format("获取屏幕像素密度：{0}", density));
                    break;
                case ScreenData.Action.GetSize:
                    // 获取屏幕像素密度和分辨率
                    Size size = manager.ScreenData.GetScreenSize();
                    result = size;
                    writeLog(string.Format("获取屏幕分辨率：{0}", size.ToString()));
                    break;
                case ScreenData.Action.SetDensity:
                    int setdensity = (int)task.DataArray[1];
                    bool r = manager.ScreenData.SetScreenDensity(setdensity);
                    result = r;
                    writeLog(string.Format("设置屏幕像素密度{0}{1}", setdensity, r ? "成功" : "失败"));
                    break;
                case ScreenData.Action.SetSize:
                    int width = (int)task.DataArray[1];
                    int height = (int)task.DataArray[2];
                    bool setSizeResult = manager.ScreenData.SetScreenSize(width, height);
                    result = setSizeResult;
                    writeLog(string.Format("设置屏幕分辨率{0}x{1}{2}", width, height, setSizeResult ? "成功" : "失败"));
                    break;
                case ScreenData.Action.ResetSize:
                    bool resetSizeResult = manager.ScreenData.ResetScreenSize();
                    result = resetSizeResult;
                    writeLog(string.Format("重置屏幕分辨率{0}", resetSizeResult ? "成功" : "失败"));
                    break;
                case ScreenData.Action.ResetDensity:
                    bool resetDensityResult = manager.ScreenData.ResetScreenDensity();
                    result = resetDensityResult;
                    writeLog(string.Format("重置屏幕像素密度{0}", resetDensityResult ? "成功" : "失败"));
                    break;
            }
            if (result != null)
            {
                task.ResultHandler.Invoke(result);
            }
        }
    }
}
