namespace CayleyTree
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
            this.drawbutton = new System.Windows.Forms.Button();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.labeln = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownth2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownth1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownleng = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownper1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownper2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drawpanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownleng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownper2)).BeginInit();
            this.SuspendLayout();
            // 
            // drawbutton
            // 
            this.drawbutton.Location = new System.Drawing.Point(669, 415);
            this.drawbutton.Name = "drawbutton";
            this.drawbutton.Size = new System.Drawing.Size(75, 23);
            this.drawbutton.TabIndex = 0;
            this.drawbutton.Text = "draw";
            this.drawbutton.UseVisualStyleBackColor = true;
            this.drawbutton.Click += new System.EventHandler(this.drawbutton_Click);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(146, 338);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(102, 20);
            this.comboBoxColor.TabIndex = 1;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // labeln
            // 
            this.labeln.AutoSize = true;
            this.labeln.Location = new System.Drawing.Point(67, 52);
            this.labeln.Name = "labeln";
            this.labeln.Size = new System.Drawing.Size(53, 12);
            this.labeln.TabIndex = 2;
            this.labeln.Text = "递归深度";
            this.labeln.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDownth2);
            this.panel1.Controls.Add(this.numericUpDownth1);
            this.panel1.Controls.Add(this.numericUpDownleng);
            this.panel1.Controls.Add(this.numericUpDownN);
            this.panel1.Controls.Add(this.numericUpDownper1);
            this.panel1.Controls.Add(this.numericUpDownper2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labeln);
            this.panel1.Controls.Add(this.comboBoxColor);
            this.panel1.Location = new System.Drawing.Point(511, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 397);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // numericUpDownth2
            // 
            this.numericUpDownth2.Location = new System.Drawing.Point(146, 289);
            this.numericUpDownth2.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownth2.Name = "numericUpDownth2";
            this.numericUpDownth2.Size = new System.Drawing.Size(100, 21);
            this.numericUpDownth2.TabIndex = 24;
            this.numericUpDownth2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownth2.ValueChanged += new System.EventHandler(this.numericUpDownth2_ValueChanged);
            // 
            // numericUpDownth1
            // 
            this.numericUpDownth1.Location = new System.Drawing.Point(146, 243);
            this.numericUpDownth1.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownth1.Name = "numericUpDownth1";
            this.numericUpDownth1.Size = new System.Drawing.Size(100, 21);
            this.numericUpDownth1.TabIndex = 23;
            this.numericUpDownth1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownth1.ValueChanged += new System.EventHandler(this.numericUpDownth1_ValueChanged);
            // 
            // numericUpDownleng
            // 
            this.numericUpDownleng.Location = new System.Drawing.Point(146, 100);
            this.numericUpDownleng.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDownleng.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownleng.Name = "numericUpDownleng";
            this.numericUpDownleng.Size = new System.Drawing.Size(100, 21);
            this.numericUpDownleng.TabIndex = 22;
            this.numericUpDownleng.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownleng.ValueChanged += new System.EventHandler(this.numericUpDownleng_ValueChanged);
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(146, 50);
            this.numericUpDownN.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(100, 21);
            this.numericUpDownN.TabIndex = 21;
            this.numericUpDownN.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownN.ValueChanged += new System.EventHandler(this.numericUpDownN_ValueChanged);
            // 
            // numericUpDownper1
            // 
            this.numericUpDownper1.DecimalPlaces = 1;
            this.numericUpDownper1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownper1.Location = new System.Drawing.Point(146, 154);
            this.numericUpDownper1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownper1.Name = "numericUpDownper1";
            this.numericUpDownper1.Size = new System.Drawing.Size(100, 21);
            this.numericUpDownper1.TabIndex = 20;
            this.numericUpDownper1.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            this.numericUpDownper1.ValueChanged += new System.EventHandler(this.numericUpDownper1_ValueChanged);
            // 
            // numericUpDownper2
            // 
            this.numericUpDownper2.DecimalPlaces = 1;
            this.numericUpDownper2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownper2.Location = new System.Drawing.Point(146, 195);
            this.numericUpDownper2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownper2.Name = "numericUpDownper2";
            this.numericUpDownper2.Size = new System.Drawing.Size(100, 21);
            this.numericUpDownper2.TabIndex = 19;
            this.numericUpDownper2.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            this.numericUpDownper2.ValueChanged += new System.EventHandler(this.numericUpDownper2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "画笔颜色";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "左分支角度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "右分支角度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "左分支长度比";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "右分支长度比";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "主干长度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "请选择绘图的参数";
            // 
            // drawpanel
            // 
            this.drawpanel.Location = new System.Drawing.Point(45, 12);
            this.drawpanel.Name = "drawpanel";
            this.drawpanel.Size = new System.Drawing.Size(431, 397);
            this.drawpanel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drawbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownleng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownper2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drawbutton;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label labeln;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel drawpanel;
        private System.Windows.Forms.NumericUpDown numericUpDownper1;
        private System.Windows.Forms.NumericUpDown numericUpDownper2;
        private System.Windows.Forms.NumericUpDown numericUpDownth2;
        private System.Windows.Forms.NumericUpDown numericUpDownth1;
        private System.Windows.Forms.NumericUpDown numericUpDownleng;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
    }
}

