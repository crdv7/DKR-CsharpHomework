namespace OrderSystem
{
    partial class Form1
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
            this.OrderOpmenuStrip = new System.Windows.Forms.MenuStrip();
            this.添加订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单查询与排序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderOpmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderOpmenuStrip
            // 
            this.OrderOpmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加订单ToolStripMenuItem,
            this.订单查询与排序ToolStripMenuItem});
            this.OrderOpmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderOpmenuStrip.Name = "OrderOpmenuStrip";
            this.OrderOpmenuStrip.Size = new System.Drawing.Size(337, 25);
            this.OrderOpmenuStrip.TabIndex = 0;
            this.OrderOpmenuStrip.Text = "menuStrip1";
            // 
            // 添加订单ToolStripMenuItem
            // 
            this.添加订单ToolStripMenuItem.Name = "添加订单ToolStripMenuItem";
            this.添加订单ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.添加订单ToolStripMenuItem.Text = "订单增改";
            this.添加订单ToolStripMenuItem.Click += new System.EventHandler(this.添加订单ToolStripMenuItem_Click);
            // 
            // 订单查询与排序ToolStripMenuItem
            // 
            this.订单查询与排序ToolStripMenuItem.Name = "订单查询与排序ToolStripMenuItem";
            this.订单查询与排序ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.订单查询与排序ToolStripMenuItem.Text = "订单查询与排序";
            this.订单查询与排序ToolStripMenuItem.Click += new System.EventHandler(this.订单查询与排序ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎使用订单管理系统！";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 149);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderOpmenuStrip);
            this.MainMenuStrip = this.OrderOpmenuStrip;
            this.Name = "Form1";
            this.Text = "OrderSystem";
            this.OrderOpmenuStrip.ResumeLayout(false);
            this.OrderOpmenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderOpmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 添加订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订单查询与排序ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

