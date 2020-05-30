namespace OrderSystem
{
    partial class ItemEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addItembutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemNumtextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.itembindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.itemPriceInputtextBox = new System.Windows.Forms.TextBox();
            this.itemNameInputtextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itembindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addItembutton
            // 
            this.addItembutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addItembutton.Location = new System.Drawing.Point(170, 3);
            this.addItembutton.Name = "addItembutton";
            this.addItembutton.Size = new System.Drawing.Size(75, 23);
            this.addItembutton.TabIndex = 0;
            this.addItembutton.Text = "确定";
            this.addItembutton.UseVisualStyleBackColor = true;
            this.addItembutton.Click += new System.EventHandler(this.addItembutton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.itemNumtextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.itemNameInputtextBox);
            this.panel1.Controls.Add(this.itemPriceInputtextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 143);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "商品名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "数量";
            // 
            // itemNumtextBox
            // 
            this.itemNumtextBox.Location = new System.Drawing.Point(125, 104);
            this.itemNumtextBox.Name = "itemNumtextBox";
            this.itemNumtextBox.Size = new System.Drawing.Size(188, 21);
            this.itemNumtextBox.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.addItembutton);
            this.panel2.Location = new System.Drawing.Point(12, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 32);
            this.panel2.TabIndex = 2;
            // 
            // itembindingSource
            // 
            this.itembindingSource.DataSource = typeof(OrderManagement.OrderItem);
            // 
            // productbindingSource
            // 
            this.productbindingSource.DataSource = typeof(OrderManagement.Product);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "单价";
            // 
            // itemPriceInputtextBox
            // 
            this.itemPriceInputtextBox.Location = new System.Drawing.Point(125, 65);
            this.itemPriceInputtextBox.Name = "itemPriceInputtextBox";
            this.itemPriceInputtextBox.Size = new System.Drawing.Size(188, 21);
            this.itemPriceInputtextBox.TabIndex = 0;
            // 
            // itemNameInputtextBox
            // 
            this.itemNameInputtextBox.Location = new System.Drawing.Point(125, 26);
            this.itemNameInputtextBox.Name = "itemNameInputtextBox";
            this.itemNameInputtextBox.Size = new System.Drawing.Size(188, 21);
            this.itemNameInputtextBox.TabIndex = 1;
            // 
            // ItemEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 196);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ItemEdit";
            this.Text = "订单明细";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itembindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addItembutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemNumtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource itembindingSource;
        private System.Windows.Forms.BindingSource productbindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemNameInputtextBox;
        private System.Windows.Forms.TextBox itemPriceInputtextBox;
    }
}