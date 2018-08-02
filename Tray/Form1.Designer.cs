namespace Tray
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.notifyIcon_main = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuStrip_mainNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_maximize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_minimize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_recover = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.button_addDate = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_setect = new System.Windows.Forms.Button();
            this.listView_data = new System.Windows.Forms.ListView();
            this.ContextMenuStrip_mainNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon_main
            // 
            this.notifyIcon_main.ContextMenuStrip = this.ContextMenuStrip_mainNotify;
            this.notifyIcon_main.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_main.Icon")));
            this.notifyIcon_main.Text = "托盘";
            this.notifyIcon_main.Visible = true;
            this.notifyIcon_main.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_main_MouseDoubleClick);
            // 
            // ContextMenuStrip_mainNotify
            // 
            this.ContextMenuStrip_mainNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_maximize,
            this.toolStripMenuItem_minimize,
            this.toolStripMenuItem_recover,
            this.toolStripMenuItem_exit});
            this.ContextMenuStrip_mainNotify.Name = "ContextMenuStrip_mainNotify";
            this.ContextMenuStrip_mainNotify.Size = new System.Drawing.Size(113, 92);
            // 
            // toolStripMenuItem_maximize
            // 
            this.toolStripMenuItem_maximize.Name = "toolStripMenuItem_maximize";
            this.toolStripMenuItem_maximize.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem_maximize.Text = "最大化";
            this.toolStripMenuItem_maximize.Click += new System.EventHandler(this.toolStripMenuItem_maximize_Click);
            // 
            // toolStripMenuItem_minimize
            // 
            this.toolStripMenuItem_minimize.Name = "toolStripMenuItem_minimize";
            this.toolStripMenuItem_minimize.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem_minimize.Text = "最小化";
            this.toolStripMenuItem_minimize.Click += new System.EventHandler(this.toolStripMenuItem_minimize_Click);
            // 
            // toolStripMenuItem_recover
            // 
            this.toolStripMenuItem_recover.Name = "toolStripMenuItem_recover";
            this.toolStripMenuItem_recover.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem_recover.Text = "还原";
            this.toolStripMenuItem_recover.Click += new System.EventHandler(this.toolStripMenuItem_recover_Click);
            // 
            // toolStripMenuItem_exit
            // 
            this.toolStripMenuItem_exit.Name = "toolStripMenuItem_exit";
            this.toolStripMenuItem_exit.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem_exit.Text = "退出";
            this.toolStripMenuItem_exit.Click += new System.EventHandler(this.toolStripMenuItem_exit_Click);
            // 
            // button_addDate
            // 
            this.button_addDate.Location = new System.Drawing.Point(86, 354);
            this.button_addDate.Name = "button_addDate";
            this.button_addDate.Size = new System.Drawing.Size(75, 23);
            this.button_addDate.TabIndex = 1;
            this.button_addDate.Text = "增加";
            this.button_addDate.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(189, 354);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "删除";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(290, 354);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "修改";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // button_setect
            // 
            this.button_setect.Location = new System.Drawing.Point(389, 354);
            this.button_setect.Name = "button_setect";
            this.button_setect.Size = new System.Drawing.Size(75, 23);
            this.button_setect.TabIndex = 4;
            this.button_setect.Text = "查询";
            this.button_setect.UseVisualStyleBackColor = true;
            // 
            // listView_data
            // 
            this.listView_data.Location = new System.Drawing.Point(71, 59);
            this.listView_data.Name = "listView_data";
            this.listView_data.Size = new System.Drawing.Size(382, 223);
            this.listView_data.TabIndex = 5;
            this.listView_data.UseCompatibleStateImageBehavior = false;
            this.listView_data.View = System.Windows.Forms.View.List;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 460);
            this.Controls.Add(this.listView_data);
            this.Controls.Add(this.button_setect);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_addDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FormMain";
            this.Text = "托盘";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ContextMenuStrip_mainNotify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon_main;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_mainNotify;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_maximize;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_minimize;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_recover;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_exit;
        private System.Windows.Forms.Button button_addDate;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_setect;
        private System.Windows.Forms.ListView listView_data;
    }
}

