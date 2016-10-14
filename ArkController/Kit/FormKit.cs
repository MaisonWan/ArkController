using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ArkController.Kit
{
    /// <summary>
    /// 窗口一些共性操作的集合
    /// </summary>
    public class FormKit
    {
        /// <summary>
        /// 显示一个窗口，然后窗口已经创建，则激活，没有则创建一个
        /// </summary>
        /// <param name="from"></param>
        /// <param name="type"></param>
        public static void Show(Form from, Type type)
        {
            if (from == null || from.IsDisposed)
            {
                from = Create<Form>(type);
            }
            if (from.Visible)
            {
                from.Activate();
            }
            else
            {
                from.Show();
            }
        }

        /// <summary>
        /// 显示一个窗口，然后窗口已经创建，则激活，没有则创建一个
        /// </summary>
        /// <param name="from"></param>
        /// <param name="type"></param>
        /// <param name="args"></param>
        public static void Show(Form from, Type type, params object[] args)
        {
            if (from == null || from.IsDisposed)
            {
                from = Create<Form>(type, args);
            }
            if (from.Visible)
            {
                from.Activate();
            }
            else
            {
                from.Show();
            }
        }

        /// <summary>
        /// 显示个对话框
        /// </summary>
        /// <param name="from"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static DialogResult ShowDialog(Form from, Type type)
        {
            if (from == null || from.IsDisposed)
            {
                from = Create<Form>(type);
            }
            return from.ShowDialog();
        }

        public static T Create<T>(Type type)
        {
            //Activator.CreateInstance 反射 根据程序集创建借口或者类
            //Type.GetType() 根据名称获得程序集信息
            //typeof(ConcertProduct).AssemblyQualifiedName
            //_iproduct.GetType().AssemblyQualifiedName
            return (T)Activator.CreateInstance(type);
        }

        public static T Create<T>(Type type, object[] args)
        {
            //Activator.CreateInstance 反射 根据程序集创建借口或者类
            //Type.GetType() 根据名称获得程序集信息
            //typeof(ConcertProduct).AssemblyQualifiedName
            //_iproduct.GetType().AssemblyQualifiedName
            return (T)Activator.CreateInstance(type, args);
        }
    }
}
