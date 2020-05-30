namespace OrderSystem
{
    partial class OperateOrder
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
            this.itemsModifyButton = new System.Windows.Forms.Button();
            this.itemsAddButton = new System.Windows.Forms.Button();
            this.itemsDeleteButton = new System.Windows.Forms.Button();
            this.orderSaveButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buynumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderIdLabel = new System.Windows.Forms.Label();
            this.clientNameComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            this.editOrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsModifyButton
            // 
            this.itemsModifyButton.Location = new System.Drawing.Point(84, 3);
            this.itemsModifyButton.Name = "itemsModifyButton";
            this.itemsModifyButton.Size = new System.Drawing.Size(75, 23);
            this.itemsModifyButton.TabIndex = 1;
            this.itemsModifyButton.Text = "修改明细";
            this.itemsModifyButton.UseVisualStyleBackColor = true;
            this.itemsModifyButton.Click += new System.EventHandler(this.itemsModifyButton_Click);
            // 
            // itemsAddButton
            // 
            this.itemsAddButton.Location = new System.Drawing.Point(3, 3);
            this.itemsAddButton.Name = "itemsAddButton";
            this.itemsAddButton.Size = new System.Drawing.Size(75, 23);
            this.itemsAddButton.TabIndex = 2;
            this.itemsAddButton.Text = "添加明细";
            this.itemsAddButton.UseVisualStyleBackColor = true;
            this.itemsAddButton.Click += new System.EventHandler(this.itemsAddButton_Click);
            // 
            // itemsDeleteButton
            // 
            this.itemsDeleteButton.Location = new System.Drawing.Point(165, 3);
            this.itemsDeleteButton.Name = "itemsDeleteButton";
            this.itemsDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.itemsDeleteButton.TabIndex = 3;
            this.itemsDeleteButton.Text = "删除明细";
            this.itemsDeleteButton.UseVisualStyleBackColor = true;
            this.itemsDeleteButton.Click += new System.EventHandler(this.itemsDeleteButton_Click);
            // 
            // orderSaveButton
            // 
            this.orderSaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.orderSaveButton.Location = new System.Drawing.Point(246, 3);
            this.orderSaveButton.Name = "orderSaveButton";
            this.orderSaveButton.Size = new System.Drawing.Size(75, 23);
            this.orderSaveButton.TabIndex = 4;
            this.orderSaveButton.Text = "保存订单";
            this.orderSaveButton.UseVisualStyleBackColor = true;
            this.orderSaveButton.Click += new System.EventHandler(this.orderSaveButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.Controls.Add(this.itemsAddButton);
            this.flowLayoutPanel1.Controls.Add(this.itemsModifyButton);
            this.flowLayoutPanel1.Controls.Add(this.itemsDeleteButton);
            this.flowLayoutPanel1.Controls.Add(this.orderSaveButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(138, 295);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(336, 36);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(21, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 181);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.buynumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(435, 175);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "商品ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "货物名";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buynumDataGridViewTextBoxColumn
            // 
            this.buynumDataGridViewTextBoxColumn.DataPropertyName = "Buynum";
            this.buynumDataGridViewTextBoxColumn.HeaderText = "数量";
            this.buynumDataGridViewTextBoxColumn.Name = "buynumDataGridViewTextBoxColumn";
            // 
            // ItemBindingSource
            // 
            this.ItemBindingSource.DataMember = "Items";
            this.ItemBindingSource.DataSource = this.OrderBindingSource;
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataSource = typeof(OrderManagement.Order);
            // 
            // editOrderGroupBox
            // 
            this.editOrderGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.editOrderGroupBox.Controls.Add(this.textBox1);
            this.editOrderGroupBox.Controls.Add(this.clientNameComboBox);
            this.editOrderGroupBox.Controls.Add(this.label1);
            this.editOrderGroupBox.Controls.Add(this.label3);
            this.editOrderGroupBox.Controls.Add(this.label2);
            this.editOrderGroupBox.Controls.Add(this.OrderIdLabel);
            this.editOrderGroupBox.Location = new System.Drawing.Point(21, 12);
            this.editOrderGroupBox.Name = "editOrderGroupBox";
            this.editOrderGroupBox.Size = new System.Drawing.Size(453, 88);
            this.editOrderGroupBox.TabIndex = 7;
            this.editOrderGroupBox.TabStop = false;
            this.editOrderGroupBox.Text = "订单基本信息";
            this.editOrderGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 21);
            this.textBox1.TabIndex = 5;
            // 
            // ClientBindingSource
            // 
            this.ClientBindingSource.DataSource = typeof(OrderManagement.Client);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(159, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 21);
            this.label1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "下单时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "客户名";
            // 
            // OrderIdLabel
            // 
            this.OrderIdLabel.AutoSize = true;
            this.OrderIdLabel.Location = new System.Drawing.Point(98, 17);
            this.OrderIdLabel.Name = "OrderIdLabel";
            this.OrderIdLabel.Size = new System.Drawing.Size(41, 12);
            this.OrderIdLabel.TabIndex = 0;
            this.OrderIdLabel.Text = "订单号";
            this.OrderIdLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // clientNameComboBox
            // 
            this.clientNameComboBox.DataSource = this.ClientBindingSource;
            this.clientNameComboBox.DisplayMember = "Name";
            this.clientNameComboBox.FormattingEnabled = true;
            this.clientNameComboBox.Location = new System.Drawing.Point(161, 37);
            this.clientNameComboBox.Name = "clientNameComboBox";
            this.clientNameComboBox.Size = new System.Drawing.Size(154, 20);
            this.clientNameComboBox.TabIndex = 4;
            // 
            // OperateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 343);
            this.Controls.Add(this.editOrderGroupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "OperateOrder";
            this.Text = "增改订单";
            this.Load += new System.EventHandler(this.OperateOrder_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            this.editOrderGroupBox.ResumeLayout(false);
            this.editOrderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button itemsModifyButton;
        private System.Windows.Forms.Button itemsAddButton;
        private System.Windows.Forms.Button itemsDeleteButton;
        private System.Windows.Forms.Button orderSaveButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox editOrderGroupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OrderIdLabel;
        private System.Windows.Forms.BindingSource ItemBindingSource;
        private System.Windows.Forms.BindingSource OrderBindingSource;
        private System.Windows.Forms.BindingSource ClientBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buynumDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox clientNameComboBox;
    }
}