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
        ProcessList
    }
}
