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
        public delegate void EventResultHandler(params object[] result);

        private TaskType what = 0;
        private int args;
        private object data = null;
        private object[] dataArray = null;
        private object tag = null;

        public TaskInfo(TaskType type)
        {
            this.what = type;
        }

        /// <summary>
        /// 工厂方法
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static TaskInfo Create(TaskType type, object data)
        {
            TaskInfo t = new TaskInfo(type);
            t.data = data;
            return t;
        }

        /// <summary>
        /// 工厂方法，创建一个对象
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static TaskInfo Create(TaskType type, object[] dataArray)
        {
            TaskInfo t = new TaskInfo(type);
            t.dataArray = dataArray;
            return t;
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
        /// 数字参数
        /// </summary>
        public int Args
        {
            set { this.args = value; }
            get { return this.args; }
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
        /// 数据数组
        /// </summary>
        public object[] DataArray
        {
            set { this.dataArray = value; }
            get { return this.dataArray; }
        }

        /// <summary>
        /// 任务携带的标记
        /// </summary>
        public object Tag
        {
            set { this.tag = value; }
            get { return this.tag; }

        }

        /// <summary>
        /// 执行完结果的回调
        /// </summary>
        public EventResultHandler ResultHandler;
    }
}
