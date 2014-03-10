namespace Hoe.UI.Repo
{
    public partial class RepoForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.addToBillButton = new System.Windows.Forms.Button();
            this.countOfProductLabel = new System.Windows.Forms.Label();
            this.showBillsButton = new System.Windows.Forms.Button();
            this.countOfProductTextBox = new System.Windows.Forms.TextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.nameOfProductLabel = new System.Windows.Forms.Label();
            this.nameOfProductTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.productMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteProductMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Norm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.productMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.addToBillButton);
            this.splitContainer1.Panel1.Controls.Add(this.countOfProductLabel);
            this.splitContainer1.Panel1.Controls.Add(this.showBillsButton);
            this.splitContainer1.Panel1.Controls.Add(this.countOfProductTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.addProductButton);
            this.splitContainer1.Panel1.Controls.Add(this.showAllButton);
            this.splitContainer1.Panel1.Controls.Add(this.nameOfProductLabel);
            this.splitContainer1.Panel1.Controls.Add(this.nameOfProductTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(955, 478);
            this.splitContainer1.SplitterDistance = 43;
            this.splitContainer1.TabIndex = 0;
            // 
            // addToBillButton
            // 
            this.addToBillButton.Location = new System.Drawing.Point(688, 11);
            this.addToBillButton.Name = "addToBillButton";
            this.addToBillButton.Size = new System.Drawing.Size(75, 23);
            this.addToBillButton.TabIndex = 2;
            this.addToBillButton.Text = "加入到订单";
            this.addToBillButton.UseVisualStyleBackColor = true;
            this.addToBillButton.Click += new System.EventHandler(this.addToBillButton_Click);
            // 
            // countOfProductLabel
            // 
            this.countOfProductLabel.AutoSize = true;
            this.countOfProductLabel.Location = new System.Drawing.Point(588, 15);
            this.countOfProductLabel.Name = "countOfProductLabel";
            this.countOfProductLabel.Size = new System.Drawing.Size(29, 12);
            this.countOfProductLabel.TabIndex = 1;
            this.countOfProductLabel.Text = "数量";
            // 
            // showBillsButton
            // 
            this.showBillsButton.Location = new System.Drawing.Point(868, 11);
            this.showBillsButton.Name = "showBillsButton";
            this.showBillsButton.Size = new System.Drawing.Size(75, 23);
            this.showBillsButton.TabIndex = 7;
            this.showBillsButton.Text = "打开订单";
            this.showBillsButton.UseVisualStyleBackColor = true;
            this.showBillsButton.Click += new System.EventHandler(this.showBillsButton_Click);
            // 
            // countOfProductTextBox
            // 
            this.countOfProductTextBox.Location = new System.Drawing.Point(622, 12);
            this.countOfProductTextBox.Name = "countOfProductTextBox";
            this.countOfProductTextBox.Size = new System.Drawing.Size(59, 21);
            this.countOfProductTextBox.TabIndex = 0;
            this.countOfProductTextBox.Text = "1";
            this.countOfProductTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(783, 11);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(75, 23);
            this.addProductButton.TabIndex = 6;
            this.addProductButton.Text = "新货入库";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(191, 11);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 5;
            this.showAllButton.Text = "显示全部";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // nameOfProductLabel
            // 
            this.nameOfProductLabel.AutoSize = true;
            this.nameOfProductLabel.Location = new System.Drawing.Point(28, 16);
            this.nameOfProductLabel.Name = "nameOfProductLabel";
            this.nameOfProductLabel.Size = new System.Drawing.Size(29, 12);
            this.nameOfProductLabel.TabIndex = 4;
            this.nameOfProductLabel.Text = "名称";
            // 
            // nameOfProductTextBox
            // 
            this.nameOfProductTextBox.Location = new System.Drawing.Point(67, 12);
            this.nameOfProductTextBox.Name = "nameOfProductTextBox";
            this.nameOfProductTextBox.Size = new System.Drawing.Size(112, 21);
            this.nameOfProductTextBox.TabIndex = 3;
            this.nameOfProductTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameOfProductTextBox_KeyPress);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.productsDataGridView);
            this.splitContainer2.Size = new System.Drawing.Size(955, 431);
            this.splitContainer2.SplitterDistance = 388;
            this.splitContainer2.TabIndex = 0;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PName,
            this.Material,
            this.Norm,
            this.QuantityDemand,
            this.Quantity,
            this.Remark,
            this.UnitPrice});
            this.productsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.productsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.productsDataGridView.MultiSelect = false;
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersVisible = false;
            this.productsDataGridView.RowTemplate.Height = 23;
            this.productsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGridView.Size = new System.Drawing.Size(955, 388);
            this.productsDataGridView.TabIndex = 0;
            this.productsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellEndEdit);
            this.productsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.productsDataGridView_CellValidating);
            this.productsDataGridView.SelectionChanged += new System.EventHandler(this.gridview_currentProductChanged);
            this.productsDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.productsDataGridView_MouseClick);
            // 
            // productMenu
            // 
            this.productMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteProductMenuItem});
            this.productMenu.Name = "productMenu";
            this.productMenu.Size = new System.Drawing.Size(101, 26);
            // 
            // deleteProductMenuItem
            // 
            this.deleteProductMenuItem.Name = "deleteProductMenuItem";
            this.deleteProductMenuItem.Size = new System.Drawing.Size(100, 22);
            this.deleteProductMenuItem.Text = "删除";
            this.deleteProductMenuItem.Click += new System.EventHandler(this.deleteProductMenuItem_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "Name";
            this.PName.HeaderText = "名称";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Width = 150;
            // 
            // Material
            // 
            this.Material.DataPropertyName = "Material";
            this.Material.HeaderText = "材料";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            this.Material.Width = 150;
            // 
            // Norm
            // 
            this.Norm.DataPropertyName = "Norm";
            this.Norm.HeaderText = "规格";
            this.Norm.Name = "Norm";
            this.Norm.ReadOnly = true;
            this.Norm.Width = 150;
            // 
            // QuantityDemand
            // 
            this.QuantityDemand.DataPropertyName = "Demand";
            this.QuantityDemand.HeaderText = "总需求";
            this.QuantityDemand.Name = "QuantityDemand";
            this.QuantityDemand.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "数量";
            this.Quantity.Name = "Quantity";
            // 
            // Remark
            // 
            this.Remark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "单价";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Visible = false;
            // 
            // RepoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 478);
            this.Controls.Add(this.splitContainer1);
            this.Name = "RepoForm";
            this.Text = "仓库";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.productMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Label nameOfProductLabel;
        private System.Windows.Forms.TextBox nameOfProductTextBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Button addToBillButton;
        private System.Windows.Forms.Label countOfProductLabel;
        private System.Windows.Forms.TextBox countOfProductTextBox;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button showBillsButton;
        private System.Windows.Forms.ContextMenuStrip productMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteProductMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Norm;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
    }
}