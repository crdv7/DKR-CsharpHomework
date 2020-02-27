namespace CalculatorUI
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
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.button_operator = new System.Windows.Forms.Button();
            this.OperatorBox = new System.Windows.Forms.ComboBox();
            this.Result = new System.Windows.Forms.Label();
            this.Warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(82, 86);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(100, 21);
            this.Num1.TabIndex = 1;
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(340, 86);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(100, 21);
            this.Num2.TabIndex = 2;
            // 
            // button_operator
            // 
            this.button_operator.Location = new System.Drawing.Point(464, 86);
            this.button_operator.Name = "button_operator";
            this.button_operator.Size = new System.Drawing.Size(75, 23);
            this.button_operator.TabIndex = 3;
            this.button_operator.Text = "=";
            this.button_operator.UseVisualStyleBackColor = true;
            this.button_operator.Click += new System.EventHandler(this.button_operator_Click);
            // 
            // OperatorBox
            // 
            this.OperatorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperatorBox.FormattingEnabled = true;
            this.OperatorBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.OperatorBox.Location = new System.Drawing.Point(199, 87);
            this.OperatorBox.Name = "OperatorBox";
            this.OperatorBox.Size = new System.Drawing.Size(121, 20);
            this.OperatorBox.TabIndex = 5;
            this.OperatorBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(572, 87);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(92, 20);
            this.Result.TabIndex = 6;
            this.Result.Click += new System.EventHandler(this.label1_Click);
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Location = new System.Drawing.Point(208, 134);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(0, 12);
            this.Warning.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.OperatorBox);
            this.Controls.Add(this.button_operator);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.Button button_operator;
        private System.Windows.Forms.ComboBox OperatorBox;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label Warning;
    }
}

