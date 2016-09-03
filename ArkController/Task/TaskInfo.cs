using System;
using System.Collections.Generic;
using System.Text;

namespace ArkController.Task
{
    /// <summary>
    /// 任务信息
    /// </summary>
    public class TaskInfo
    {
        /// <summary>
        /// 事件结果执行事件
        /// </summary>
        /// <param name="result">执行返回结果</param>
        public delegate void EventResultHandler(object result);

        private TaskType what = 0;
        private object data = null;

        public TaskInfo(TaskType type)
        {
            this.what = type;
        }

        /// <summary>
        /// 标示需要做什么
        /// </summary>
        public TaskType What
        {
            set { this.what = value; }
            get { return this.what; }
        }

        /// <summary>
        /// 任务的具体数据
        /// </summary>
        public object Data
        {
            set { this.data = value; }
            get { return this.data; }
        }

        /// <summary>
        /// 执行完结果的回调
        /// </summary>
        public EventResultHandler ResultHandler;
    }
}
