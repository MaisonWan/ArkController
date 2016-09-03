using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ArkController.Task
{
    /// <summary>
    /// 任务线程
    /// </summary>
    public abstract class BaseTaskThread
    {
        private Queue<TaskInfo> taskQueue = new Queue<TaskInfo>();
        /// <summary>
        /// 线程锁
        /// </summary>
        private object threadLock = new object();
        /// <summary>
        /// 信号量
        /// </summary>
        private Semaphore taskSemaphore = new Semaphore(0, 256);
        protected Thread thread = null;

        /// <summary>
        /// 启动工作线程
        /// </summary>
        public void Start()
        {
            if (thread != null)
            {
                thread.Abort();
            }
            thread = new Thread(new ParameterizedThreadStart(workTask));
            thread.IsBackground = true;
            thread.Start();
        }

        /// <summary>
        /// 停止任务
        /// </summary>
        public void Stop()
        {
            if (thread != null)
            {
                thread.Abort();
            }
        }

        /// <summary>
        /// 发送任务
        /// </summary>
        /// <param name="taskInfo"></param>
        public void SendTask(TaskInfo taskInfo)
        {
            taskQueue.Enqueue(taskInfo);
            taskSemaphore.Release(1);
        }

        /// <summary>
        /// 发送一个空的任务，指定类型
        /// </summary>
        /// <param name="type"></param>
        public void SendEmptyTask(TaskType type)
        {
            TaskInfo task = new TaskInfo(type);
            SendTask(task);
        }

        /// <summary>
        /// 实际工作业务
        /// </summary>
        /// <param name="data"></param>
        private void workTask(object data)
        {
            while (true)
            {
                // 等待信号量
                taskSemaphore.WaitOne();
                TaskInfo task = taskQueue.Dequeue();
                handleTask(task);
            }
        }

        /// <summary>
        /// 执行具体任务
        /// </summary>
        /// <param name="task"></param>
        public abstract void handleTask(TaskInfo task);
    }
}
