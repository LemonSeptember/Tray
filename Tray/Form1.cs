using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tray
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //  只有Form_Closing事件中 e.Cancel可以用。
        //  你的是Form_Closed事件。 Form_Closed事件时窗口已关了 ，Cancel没用了；
        //  Form_Closing是窗口即将关闭时询问你是不是真的关闭才有Cancel事件

        #region 托盘图标

        /// <summary>
        /// 关闭窗口时缩小到托盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 注意判断关闭事件reason来源于窗体按钮，否则用菜单退出时无法退出!
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //取消“关闭窗口”事件
                e.Cancel = true;//取消关闭窗体

                //使关闭时窗口向右下角缩小的效果
                this.WindowState = FormWindowState.Minimized;
                this.notifyIcon_main.Visible = true;

                this.Hide();
                return;
            }
        }

        /// <summary>
        /// 双击托盘图标打开关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon_main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible)
            {
                this.WindowState = FormWindowState.Minimized;
                this.notifyIcon_main.Visible = true;
                this.Hide();
            }
            else
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

        /// <summary>
        /// 托盘菜单右键实现最大化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.notifyIcon_main.Visible = true;
            this.Show();
        }

        /// <summary>
        /// 托盘菜单右键实现最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.notifyIcon_main.Visible = true;
            this.Hide();
        }

        /// <summary>
        /// 托盘菜单右键实现还原
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_recover_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon_main.Visible = true;
            this.Show();
        }

        /// <summary>
        /// 托盘菜单右键实现退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出？", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.notifyIcon_main.Visible = false;
                this.Close();
                this.Dispose();
                System.Environment.Exit(System.Environment.ExitCode);
            }
        }

        #endregion

    }
}