using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArkController.Data;

namespace ArkController.Task
{
    /// <summary>
    /// 执行命令界面的线程，制作执行命令和返回
    /// </summary>
    public class CommandTaskThread : BaseTaskThread
    {
        private Command cmd = null;
        private Command.Callback callback = null;

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="callback">回调</param>
        public CommandTaskThread(Command.Callback callback)
        {
            this.cmd = new Command();
            this.callback = callback;
        }

        public override void handleTask(TaskInfo task)
        {
            cmd.ExecuteAdb(task.Data.ToString(), this.callback);
        }

        /// <summary>
        /// 发送任务
        /// </summary>
        /// <param name="taskInfo"></param>
        public void SendTask(string command)
        {
            TaskInfo t = TaskInfo.Create(TaskType.ExecuteCommand, command);
            base.SendTask(t);
        }
    }
}
