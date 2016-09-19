using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ArkController.Data;

namespace ArkController.Pages
{
    public partial class FormCommand : Form, Command.Callback
    {
        private Thread thread = null;
        private Command cmd = null;
        private List<string> commandList = new List<string>();
        /// <summary>
        /// 当前刚输入的命令id
        /// </summary>
        private int pointer = 0;

        public FormCommand()
        {
            InitializeComponent();
        }

        private void FormCommand_Load(object sender, EventArgs e)
        {
            cmd = new Command();
        }

        private void textBoxCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonExecute_Click(sender, null);
            }
            else if (e.KeyCode == Keys.Up)
            {
                this.pointer--;
                pointer = Math.Max(pointer, 0);
                selectHistory(pointer);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                this.pointer++;
                pointer = Math.Min(pointer, this.commandList.Count - 1);
                selectHistory(pointer);
                e.Handled = true;
            }
        }

        /// <summary>
        /// 选择历史记录，并且移动光标到最后
        /// </summary>
        /// <param name="index"></param>
        private void selectHistory(int index)
        {
            this.textBoxCommand.Text = this.commandList[index];
            this.textBoxCommand.Select(this.textBoxCommand.Text.Length, 0);
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string command = this.textBoxCommand.Text;
            this.cmd.ExecuteAdb(command, this);
            this.commandList.Add(command);
            this.pointer = this.commandList.Count;
            this.textBoxCommand.Clear();
        }

        void Command.Callback.onReceive(string line)
        {
            this.textBoxContent.AppendText(line + "\n");
        }
    }
}
