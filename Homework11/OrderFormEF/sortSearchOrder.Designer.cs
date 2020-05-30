namespace OrderSystem
{
    partial class sortSearchOrder
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
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.sortcomboBox = new System.Windows.Forms.ComboBox();
            this.sortlabel = new System.Windows.Forms.Label();
            this.sortButton = new System.Windows.Forms.Button();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.Inputtext = new System.Windows.Forms.TextBox();
            this.searchInputLabel = new System.Windows.Forms.Label();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.searchlabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.orderInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.orderItemGroupBox = new System.Windows.Forms.GroupBox();
            this.orderItemDataGridView = new System.Windows.Forms.DataGridView();
            this.ItembindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.modifyOrderButton = new System.Windows.Forms.Button();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buynumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordertimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortGroupBox.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.orderInfoGroupBox.SuspendLayout();
            this.orderItemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItembindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sortGroupBox.Controls.Add(this.sortcomboBox);
            this.sortGroupBox.Controls.Add(this.sortlabel);
            this.sortGroupBox.Controls.Add(this.sortButton);
            this.sortGroupBox.Location = new System.Drawing.Point(411, 25);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Size = new System.Drawing.Size(422, 74);
            this.sortGroupBox.TabIndex = 12;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "订单排序";
            // 
            // sortcomboBox
            // 
            this.sortcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortcomboBox.FormattingEnabled = true;
            this.sortcomboBox.Items.AddRange(new object[] {
            "ID",
            "总价",
            "下单时间"});
            this.sortcomboBox.Location = new System.Drawing.Point(118, 29);
            this.sortcomboBox.Name = "sortcomboBox";
            this.sortcomboBox.Size = new System.Drawing.Size(139, 20);
            this.sortcomboBox.TabIndex = 6;
            // 
            // sortlabel
            // 
            this.sortlabel.AutoSize = true;
            this.sortlabel.Location = new System.Drawing.Point(15, 32);
            this.sortlabel.Name = "sortlabel";
            this.sortlabel.Size = new System.Drawing.Size(77, 12);
            this.sortlabel.TabIndex = 5;
            this.sortlabel.Text = "选择排序方式";
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(272, 26);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(93, 23);
            this.sortButton.TabIndex = 7;
            this.sortButton.Text = "排序";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchGroupBox.Controls.Add(this.Inputtext);
            this.SearchGroupBox.Controls.Add(this.searchInputLabel);
            this.SearchGroupBox.Controls.Add(this.searchComboBox);
            this.SearchGroupBox.Controls.Add(this.searchlabel);
            this.SearchGroupBox.Controls.Add(this.searchButton);
            this.SearchGroupBox.Location = new System.Drawing.Point(18, 25);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(438, 74);
            this.SearchGroupBox.TabIndex = 11;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "查询订单";
            // 
            // Inputtext
            // 
            this.Inputtext.Location = new System.Drawing.Point(124, 44);
            this.Inputtext.Name = "Inputtext";
            this.Inputtext.Size = new System.Drawing.Size(121, 21);
            this.Inputtext.TabIndex = 6;
            // 
            // searchInputLabel
            // 
            this.searchInputLabel.AutoSize = true;
            this.searchInputLabel.Location = new System.Drawing.Point(25, 47);
            this.searchInputLabel.Name = "searchInputLabel";
            this.searchInputLabel.Size = new System.Drawing.Size(77, 12);
            this.searchInputLabel.TabIndex = 5;
            this.searchInputLabel.Text = "输入查询内容";
            // 
            // searchComboBox
            // 
            this.searchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "全部订单",
            "订单ID",
            "客户名",
            "价格大于"});
            this.searchComboBox.Location = new System.Drawing.Point(124, 18);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(121, 20);
            this.searchComboBox.TabIndex = 2;
            // 
            // searchlabel
            // 
            this.searchlabel.AutoSize = true;
            this.searchlabel.Location = new System.Drawing.Point(25, 21);
            this.searchlabel.Name = "searchlabel";
            this.searchlabel.Size = new System.Drawing.Size(77, 12);
            this.searchlabel.TabIndex = 3;
            this.searchlabel.Text = "选择查询方式";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(292, 21);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 38);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "查询";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.ordertimeDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.orderDataGridView.DataSource = this.OrderbindingSource;
            this.orderDataGridView.Location = new System.Drawing.Point(6, 20);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowTemplate.Height = 23;
            this.orderDataGridView.Size = new System.Drawing.Size(432, 238);
            this.orderDataGridView.TabIndex = 10;
            this.orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_CellContentClick);
            this.orderDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_CellDoubleClick);
            // 
            // orderInfoGroupBox
            // 
            this.orderInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.orderInfoGroupBox.Controls.Add(this.orderDataGridView);
            this.orderInfoGroupBox.Location = new System.Drawing.Point(18, 117);
            this.orderInfoGroupBox.Name = "orderInfoGroupBox";
            this.orderInfoGroupBox.Size = new System.Drawing.Size(486, 264);
            this.orderInfoGroupBox.TabIndex = 13;
            this.orderInfoGroupBox.TabStop = false;
            this.orderInfoGroupBox.Text = "订单基本信息";
            // 
            // orderItemGroupBox
            // 
            this.orderItemGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.orderItemGroupBox.Controls.Add(this.orderItemDataGridView);
            this.orderItemGroupBox.Location = new System.Drawing.Point(489, 117);
            this.orderItemGroupBox.Name = "orderItemGroupBox";
            this.orderItemGroupBox.Size = new System.Drawing.Size(344, 264);
            this.orderItemGroupBox.TabIndex = 14;
            this.orderItemGroupBox.TabStop = false;
            this.orderItemGroupBox.Text = "订单明细";
            // 
            // orderItemDataGridView
            // 
            this.orderItemDataGridView.AutoGenerateColumns = false;
            this.orderItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.buynumDataGridViewTextBoxColumn});
            this.orderItemDataGridView.DataSource = this.ItembindingSource;
            this.orderItemDataGridView.Location = new System.Drawing.Point(21, 17);
            this.orderItemDataGridView.Name = "orderItemDataGridView";
            this.orderItemDataGridView.RowTemplate.Height = 23;
            this.orderItemDataGridView.Size = new System.Drawing.Size(313, 241);
            this.orderItemDataGridView.TabIndex = 0;
            // 
            // ItembindingSource
            // 
            this.ItembindingSource.DataMember = "Items";
            this.ItembindingSource.DataSource = this.OrderbindingSource;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(332, 6);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 15;
            this.importButton.Text = "导入订单";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(440, 6);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 16;
            this.exportButton.Text = "导出订单";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // addOrderButton
            // 
            this.addOrderButton.Location = new System.Drawing.Point(35, 5);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(75, 23);
            this.addOrderButton.TabIndex = 17;
            this.addOrderButton.Text = "添加订单";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // modifyOrderButton
            // 
            this.modifyOrderButton.Location = new System.Drawing.Point(132, 5);
            this.modifyOrderButton.Name = "modifyOrderButton";
            this.modifyOrderButton.Size = new System.Drawing.Size(75, 23);
            this.modifyOrderButton.TabIndex = 18;
            this.modifyOrderButton.Text = "修改订单";
            this.modifyOrderButton.UseVisualStyleBackColor = true;
            this.modifyOrderButton.Click += new System.EventHandler(this.modifyOrderButton_Click);
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(228, 6);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(75, 23);
            this.deleteOrderButton.TabIndex = 19;
            this.deleteOrderButton.Text = "删除订单";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.addOrderButton);
            this.panel1.Controls.Add(this.exportButton);
            this.panel1.Controls.Add(this.deleteOrderButton);
            this.panel1.Controls.Add(this.importButton);
            this.panel1.Controls.Add(this.modifyOrderButton);
            this.panel1.Location = new System.Drawing.Point(261, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 32);
            this.panel1.TabIndex = 20;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "商品名";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "价格";
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buynumDataGridViewTextBoxColumn
            // 
            this.buynumDataGridViewTextBoxColumn.DataPropertyName = "Buynum";
            this.buynumDataGridViewTextBoxColumn.HeaderText = "数量";
            this.buynumDataGridViewTextBoxColumn.Name = "buynumDataGridViewTextBoxColumn";
            // 
            // OrderbindingSource
            // 
            this.OrderbindingSource.DataSource = typeof(OrderManagement.Order);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "订单Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "客户名";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordertimeDataGridViewTextBoxColumn
            // 
            this.ordertimeDataGridViewTextBoxColumn.DataPropertyName = "Ordertime";
            this.ordertimeDataGridViewTextBoxColumn.HeaderText = "下单时间";
            this.ordertimeDataGridViewTextBoxColumn.Name = "ordertimeDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总价";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // sortSearchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 431);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.orderItemGroupBox);
            this.Controls.Add(this.orderInfoGroupBox);
            this.Controls.Add(this.sortGroupBox);
            this.Controls.Add(this.SearchGroupBox);
            this.Name = "sortSearchOrder";
            this.Text = "查询订单";
            this.Load += new System.EventHandler(this.sortSearchOrder_Load);
            this.sortGroupBox.ResumeLayout(false);
            this.sortGroupBox.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.orderInfoGroupBox.ResumeLayout(false);
            this.orderItemGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItembindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.ComboBox sortcomboBox;
        private System.Windows.Forms.Label sortlabel;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Label searchlabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.TextBox Inputtext;
        private System.Windows.Forms.Label searchInputLabel;
        private System.Windows.Forms.GroupBox orderInfoGroupBox;
        private System.Windows.Forms.GroupBox orderItemGroupBox;
        private System.Windows.Forms.DataGridView orderItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource OrderbindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buynumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ItembindingSource;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Button modifyOrderButton;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}