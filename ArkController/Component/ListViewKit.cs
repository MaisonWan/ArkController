using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ArkController.Component
{
    /// <summary>
    /// Listview中常用集合
    /// </summary>
    public class ListViewKit
    {
        /// <summary>
        /// 单机列名排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void OnColumnClickSort(object sender, ColumnClickEventArgs e)
        {
            ListView listView = sender as ListView;
            // 检查点击的列是不是现在的排序列.
            if (e.Column == (listView.ListViewItemSorter as ListViewColumnSorter).SortColumn)
            {
                // 重新设置此列的排序方法.
                if ((listView.ListViewItemSorter as ListViewColumnSorter).Order == System.Windows.Forms.SortOrder.Ascending)
                {
                    (listView.ListViewItemSorter as ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Descending;
                }
                else
                {
                    (listView.ListViewItemSorter as ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Ascending;
                }
            }
            else
            {
                // 设置排序列，默认为正向排序
                (listView.ListViewItemSorter as ListViewColumnSorter).SortColumn = e.Column;
                (listView.ListViewItemSorter as ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Ascending;
            }
            listView.Sort();
        }

        /// <summary>
        /// 是否有选择的项目
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static bool hasSelectedItem(object sender)
        {
            ListView listview = (ListView)sender;
            return listview.SelectedItems.Count > 0;
        }
    }
}
