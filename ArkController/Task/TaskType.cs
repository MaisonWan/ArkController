using System;
using System.Collections.Generic;
using System.Text;

namespace ArkController.Task
{
    /// <summary>
    /// 任务类型
    /// </summary>
    public enum TaskType
    {
        /// <summary>
        /// 按键
        /// </summary>
        SendKey,
        /// <summary>
        /// 执行命令
        /// </summary>
        ExecuteCommand,
        /// <summary>
        /// 设备列表
        /// </summary>
        DeviceList,
        /// <summary>
        /// 包名列表
        /// </summary>
        PackageList,
        /// <summary>
        /// 进程列表
        /// </summary>
        ProcessList,
        /// <summary>
        /// 内存镜像
        /// </summary>
        DumpHeap,
        /// <summary>
        /// 当前设备信息
        /// </summary>
        CurrentDeviceInfo,
        /// <summary>
        /// 电池信息
        /// </summary>
        BatteryInfo,
        /// <summary>
        /// 启动Activity
        /// </summary>
        StartAM,
        /// <summary>
        /// 卸载程序
        /// </summary>
        Unintall,
        /// <summary>
        /// 安装程序
        /// </summary>
        Install,
        /// <summary>
        /// 
        /// </summary>
        InputText,
        /// <summary>
        /// 屏幕截图
        /// </summary>
        ScreenShot,
        /// <summary>
        /// 录制屏幕
        /// </summary>
        ScreenRecord,
        /// <summary>
        /// 屏幕尺寸和像素密度
        /// </summary>
        ScreenSizeDensity,
        /// <summary>
        /// 从设备从导出文件
        /// </summary>
        PullFile,
        /// <summary>
        /// 从本地推送到设备端
        /// </summary>
        PushFile
    }
}
