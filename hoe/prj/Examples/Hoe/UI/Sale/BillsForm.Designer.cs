namespace Hoe.UI.Sale
{
    public partial class BillsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.billMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sortBillsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBillMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.allBillButton = new System.Windows.Forms.Button();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.billProductSearchButton = new System.Windows.Forms.Button();
            this.phoneSearchButton = new System.Windows.Forms.Button();
            this.billSearchContentTextBox = new System.Windows.Forms.TextBox();
            this.backupRestoreButton = new System.Windows.Forms.Button();
            this.createBillButton = new System.Windows.Forms.Button();
            this.billsGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssemblageOk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.billRemarkTextBox = new System.Windows.Forms.TextBox();
            this.cancelProductButton = new System.Windows.Forms.Button();
            this.billRemarkLabel = new System.Windows.Forms.Label();
            this.showRepoButton = new System.Windows.Forms.Button();
            this.bill_productsGridView = new System.Windows.Forms.DataGridView();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Norm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.depositLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.billMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bill_productsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // billMenu
            // 
            this.billMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortBillsMenuItem,
            this.deleteBillMenuItem});
            this.billMenu.Name = "billMenu";
            this.billMenu.Size = new System.Drawing.Size(101, 48);
            // 
            // sortBillsMenuItem
            // 
            this.sortBillsMenuItem.Name = "sortBillsMenuItem";
            this.sortBillsMenuItem.Size = new System.Drawing.Size(100, 22);
            this.sortBillsMenuItem.Text = "整理";
            this.sortBillsMenuItem.Click += new System.EventHandler(this.sortBillsMenuItem_Click);
            // 
            // deleteBillMenuItem
            // 
            this.deleteBillMenuItem.Name = "deleteBillMenuItem";
            this.deleteBillMenuItem.Size = new System.Drawing.Size(100, 22);
            this.deleteBillMenuItem.Text = "删除";
            this.deleteBillMenuItem.Click += new System.EventHandler(this.deleteBillMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1148, 533);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.searchGroupBox);
            this.splitContainer3.Panel1.Controls.Add(this.backupRestoreButton);
            this.splitContainer3.Panel1.Controls.Add(this.createBillButton);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.billsGridView);
            this.splitContainer3.Panel2MinSize = 100;
            this.splitContainer3.Size = new System.Drawing.Size(300, 533);
            this.splitContainer3.SplitterDistance = 110;
            this.splitContainer3.TabIndex = 0;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.allBillButton);
            this.searchGroupBox.Controls.Add(this.statusComboBox);
            this.searchGroupBox.Controls.Add(this.billProductSearchButton);
            this.searchGroupBox.Controls.Add(this.phoneSearchButton);
            this.searchGroupBox.Controls.Add(this.billSearchContentTextBox);
            this.searchGroupBox.Location = new System.Drawing.Point(12, 41);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(285, 63);
            this.searchGroupBox.TabIndex = 9;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "搜索";
            // 
            // allBillButton
            // 
            this.allBillButton.Location = new System.Drawing.Point(209, 37);
            this.allBillButton.Name = "allBillButton";
            this.allBillButton.Size = new System.Drawing.Size(71, 23);
            this.allBillButton.TabIndex = 12;
            this.allBillButton.Text = "显示全部";
            this.allBillButton.UseVisualStyleBackColor = true;
            this.allBillButton.Click += new System.EventHandler(this.allBillButton_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(210, 14);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(70, 20);
            this.statusComboBox.TabIndex = 11;
            // 
            // billProductSearchButton
            // 
            this.billProductSearchButton.Location = new System.Drawing.Point(79, 37);
            this.billProductSearchButton.Name = "billProductSearchButton";
            this.billProductSearchButton.Size = new System.Drawing.Size(94, 23);
            this.billProductSearchButton.TabIndex = 10;
            this.billProductSearchButton.Text = "订单内容搜索";
            this.billProductSearchButton.UseVisualStyleBackColor = true;
            this.billProductSearchButton.Click += new System.EventHandler(this.billProductSearchButton_Click);
            // 
            // phoneSearchButton
            // 
            this.phoneSearchButton.Location = new System.Drawing.Point(7, 37);
            this.phoneSearchButton.Name = "phoneSearchButton";
            this.phoneSearchButton.Size = new System.Drawing.Size(68, 23);
            this.phoneSearchButton.TabIndex = 9;
            this.phoneSearchButton.Text = "电话搜索";
            this.phoneSearchButton.UseVisualStyleBackColor = true;
            this.phoneSearchButton.Click += new System.EventHandler(this.phoneSearchButton_Click);
            // 
            // billSearchContentTextBox
            // 
            this.billSearchContentTextBox.Location = new System.Drawing.Point(6, 13);
            this.billSearchContentTextBox.Name = "billSearchContentTextBox";
            this.billSearchContentTextBox.Size = new System.Drawing.Size(198, 21);
            this.billSearchContentTextBox.TabIndex = 8;
            // 
            // backupRestoreButton
            // 
            this.backupRestoreButton.Location = new System.Drawing.Point(112, 12);
            this.backupRestoreButton.Name = "backupRestoreButton";
            this.backupRestoreButton.Size = new System.Drawing.Size(75, 23);
            this.backupRestoreButton.TabIndex = 6;
            this.backupRestoreButton.Text = "备份和恢复";
            this.backupRestoreButton.UseVisualStyleBackColor = true;
            this.backupRestoreButton.Click += new System.EventHandler(this.backupRestoreButton_Click);
            // 
            // createBillButton
            // 
            this.createBillButton.Location = new System.Drawing.Point(12, 12);
            this.createBillButton.Name = "createBillButton";
            this.createBillButton.Size = new System.Drawing.Size(75, 23);
            this.createBillButton.TabIndex = 0;
            this.createBillButton.Text = "增加订单";
            this.createBillButton.UseVisualStyleBackColor = true;
            this.createBillButton.Click += new System.EventHandler(this.createBillButton_Click);
            // 
            // billsGridView
            // 
            this.billsGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.billsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Deposit,
            this.Number,
            this.DeliveryDate,
            this.Phone,
            this.AssemblageOk,
            this.Completed,
            this.Remark});
            this.billsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billsGridView.Location = new System.Drawing.Point(0, 0);
            this.billsGridView.MultiSelect = false;
            this.billsGridView.Name = "billsGridView";
            this.billsGridView.RowHeadersVisible = false;
            this.billsGridView.RowTemplate.Height = 23;
            this.billsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billsGridView.Size = new System.Drawing.Size(300, 419);
            this.billsGridView.TabIndex = 0;
            this.billsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billsGridView_CellContentClick);
            this.billsGridView.SelectionChanged += new System.EventHandler(this.girdView_currentBillChanged);
            this.billsGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.billsGridView_MouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Deposit
            // 
            this.Deposit.DataPropertyName = "Deposit";
            this.Deposit.HeaderText = "Deposit";
            this.Deposit.Name = "Deposit";
            this.Deposit.Visible = false;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "编号";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeliveryDate.DataPropertyName = "DeliveryDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "未知";
            this.DeliveryDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.DeliveryDate.HeaderText = "提货";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.ReadOnly = true;
            this.DeliveryDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "电话";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AssemblageOk
            // 
            this.AssemblageOk.DataPropertyName = "AssemblageOk";
            this.AssemblageOk.HeaderText = "配货";
            this.AssemblageOk.Name = "AssemblageOk";
            this.AssemblageOk.ReadOnly = true;
            this.AssemblageOk.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AssemblageOk.Width = 50;
            // 
            // Completed
            // 
            this.Completed.DataPropertyName = "Completed";
            this.Completed.FalseValue = "false";
            this.Completed.HeaderText = "完成";
            this.Completed.Name = "Completed";
            this.Completed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Completed.TrueValue = "true";
            this.Completed.Width = 50;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.Visible = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.depositTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.depositLabel);
            this.splitContainer2.Panel2.Controls.Add(this.totalPriceLabel);
            this.splitContainer2.Size = new System.Drawing.Size(844, 533);
            this.splitContainer2.SplitterDistance = 462;
            this.splitContainer2.TabIndex = 3;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.billRemarkTextBox);
            this.splitContainer4.Panel1.Controls.Add(this.cancelProductButton);
            this.splitContainer4.Panel1.Controls.Add(this.billRemarkLabel);
            this.splitContainer4.Panel1.Controls.Add(this.showRepoButton);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.bill_productsGridView);
            this.splitContainer4.Size = new System.Drawing.Size(844, 462);
            this.splitContainer4.TabIndex = 2;
            // 
            // billRemarkTextBox
            // 
            this.billRemarkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.billRemarkTextBox.Location = new System.Drawing.Point(68, 3);
            this.billRemarkTextBox.Multiline = true;
            this.billRemarkTextBox.Name = "billRemarkTextBox";
            this.billRemarkTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.billRemarkTextBox.Size = new System.Drawing.Size(260, 44);
            this.billRemarkTextBox.TabIndex = 5;
            this.billRemarkTextBox.Leave += new System.EventHandler(this.billRemarkTextBox_Leave);
            // 
            // cancelProductButton
            // 
            this.cancelProductButton.Location = new System.Drawing.Point(669, 12);
            this.cancelProductButton.Name = "cancelProductButton";
            this.cancelProductButton.Size = new System.Drawing.Size(75, 23);
            this.cancelProductButton.TabIndex = 4;
            this.cancelProductButton.Text = "退回仓库";
            this.cancelProductButton.UseVisualStyleBackColor = true;
            this.cancelProductButton.Click += new System.EventHandler(this.cancelProductButton_Click);
            // 
            // billRemarkLabel
            // 
            this.billRemarkLabel.AutoSize = true;
            this.billRemarkLabel.Location = new System.Drawing.Point(13, 20);
            this.billRemarkLabel.Name = "billRemarkLabel";
            this.billRemarkLabel.Size = new System.Drawing.Size(53, 12);
            this.billRemarkLabel.TabIndex = 0;
            this.billRemarkLabel.Text = "订单备注";
            // 
            // showRepoButton
            // 
            this.showRepoButton.Location = new System.Drawing.Point(749, 12);
            this.showRepoButton.Margin = new System.Windows.Forms.Padding(2);
            this.showRepoButton.Name = "showRepoButton";
            this.showRepoButton.Size = new System.Drawing.Size(79, 23);
            this.showRepoButton.TabIndex = 1;
            this.showRepoButton.Text = "打开仓库";
            this.showRepoButton.UseVisualStyleBackColor = true;
            this.showRepoButton.Click += new System.EventHandler(this.showRepoButton_Click);
            // 
            // bill_productsGridView
            // 
            this.bill_productsGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bill_productsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bill_productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bill_productsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PName,
            this.Id,
            this.Material,
            this.Norm,
            this.Demand,
            this.Quantity,
            this.productRemark,
            this.UnitPrice});
            this.bill_productsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bill_productsGridView.Location = new System.Drawing.Point(0, 0);
            this.bill_productsGridView.Margin = new System.Windows.Forms.Padding(2);
            this.bill_productsGridView.MultiSelect = false;
            this.bill_productsGridView.Name = "bill_productsGridView";
            this.bill_productsGridView.RowHeadersVisible = false;
            this.bill_productsGridView.RowTemplate.Height = 24;
            this.bill_productsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bill_productsGridView.Size = new System.Drawing.Size(844, 408);
            this.bill_productsGridView.TabIndex = 2;
            this.bill_productsGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.bill_productsGridView_CellEndEdit);
            this.bill_productsGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.bill_productsDataGridView_CellValidating);
            this.bill_productsGridView.SelectionChanged += new System.EventHandler(this.gridView_currentBillProductChanged);
            // 
            // PName
            // 
            this.PName.DataPropertyName = "Name";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PName.DefaultCellStyle = dataGridViewCellStyle4;
            this.PName.HeaderText = "名称";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Width = 150;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Material
            // 
            this.Material.DataPropertyName = "Material";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Material.DefaultCellStyle = dataGridViewCellStyle5;
            this.Material.HeaderText = "材料";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            this.Material.Width = 150;
            // 
            // Norm
            // 
            this.Norm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Norm.DataPropertyName = "Norm";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Norm.DefaultCellStyle = dataGridViewCellStyle6;
            this.Norm.HeaderText = "规格";
            this.Norm.Name = "Norm";
            this.Norm.ReadOnly = true;
            // 
            // Demand
            // 
            this.Demand.DataPropertyName = "Demand";
            this.Demand.HeaderText = "需求";
            this.Demand.Name = "Demand";
            this.Demand.ReadOnly = true;
            this.Demand.Width = 80;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle7;
            this.Quantity.HeaderText = "数量";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 80;
            // 
            // productRemark
            // 
            this.productRemark.DataPropertyName = "Remark";
            this.productRemark.HeaderText = "备注";
            this.productRemark.Name = "productRemark";
            this.productRemark.Visible = false;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UnitPrice.DefaultCellStyle = dataGridViewCellStyle8;
            this.UnitPrice.HeaderText = "单价(元)";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // depositTextBox
            // 
            this.depositTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.depositTextBox.Location = new System.Drawing.Point(67, 11);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.depositTextBox.Size = new System.Drawing.Size(94, 21);
            this.depositTextBox.TabIndex = 6;
            this.depositTextBox.Leave += new System.EventHandler(this.depositTextBox_Leave);
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Location = new System.Drawing.Point(13, 15);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(53, 12);
            this.depositLabel.TabIndex = 4;
            this.depositLabel.Text = "预付(￥)";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(190, 15);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(53, 12);
            this.totalPriceLabel.TabIndex = 3;
            this.totalPriceLabel.Text = "合计(￥)";
            // 
            // BillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 533);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BillsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "订单";
            this.billMenu.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billsGridView)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bill_productsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showRepoButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView bill_productsGridView;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button createBillButton;
        private System.Windows.Forms.Button cancelProductButton;
        private System.Windows.Forms.Label billRemarkLabel;
        private System.Windows.Forms.DataGridView billsGridView;
        private System.Windows.Forms.TextBox billRemarkTextBox;
        private System.Windows.Forms.ContextMenuStrip billMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteBillMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortBillsMenuItem;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.Button backupRestoreButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button billProductSearchButton;
        private System.Windows.Forms.Button phoneSearchButton;
        private System.Windows.Forms.TextBox billSearchContentTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button allBillButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AssemblageOk;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Norm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
    }
}

