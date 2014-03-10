namespace MVCSharp.Examples.Basics.Presentation.Win
{
    partial class OrdersForm
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
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.cancelOrderBtn = new System.Windows.Forms.Button();
            this.shipOrderBtn = new System.Windows.Forms.Button();
            this.acceptOrderBtn = new System.Windows.Forms.Button();
            this.showCustomersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersGridView
            // 
            this.ordersGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordersGridView.Location = new System.Drawing.Point(0, 0);
            this.ordersGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.RowTemplate.Height = 24;
            this.ordersGridView.Size = new System.Drawing.Size(254, 124);
            this.ordersGridView.TabIndex = 1;
            this.ordersGridView.CurrentCellChanged += new System.EventHandler(this.ordersGridView_CurrentCellChanged);
            // 
            // cancelOrderBtn
            // 
            this.cancelOrderBtn.Location = new System.Drawing.Point(169, 129);
            this.cancelOrderBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelOrderBtn.Name = "cancelOrderBtn";
            this.cancelOrderBtn.Size = new System.Drawing.Size(78, 29);
            this.cancelOrderBtn.TabIndex = 2;
            this.cancelOrderBtn.Text = "Cancel Order";
            this.cancelOrderBtn.UseVisualStyleBackColor = true;
            this.cancelOrderBtn.Click += new System.EventHandler(this.cancelOrderBtn_Click);
            // 
            // shipOrderBtn
            // 
            this.shipOrderBtn.Location = new System.Drawing.Point(88, 129);
            this.shipOrderBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.shipOrderBtn.Name = "shipOrderBtn";
            this.shipOrderBtn.Size = new System.Drawing.Size(76, 29);
            this.shipOrderBtn.TabIndex = 3;
            this.shipOrderBtn.Text = "Ship Order";
            this.shipOrderBtn.UseVisualStyleBackColor = true;
            this.shipOrderBtn.Click += new System.EventHandler(this.shipOrderBtn_Click);
            // 
            // acceptOrderBtn
            // 
            this.acceptOrderBtn.Location = new System.Drawing.Point(5, 130);
            this.acceptOrderBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acceptOrderBtn.Name = "acceptOrderBtn";
            this.acceptOrderBtn.Size = new System.Drawing.Size(78, 28);
            this.acceptOrderBtn.TabIndex = 4;
            this.acceptOrderBtn.Text = "Accept Order";
            this.acceptOrderBtn.UseVisualStyleBackColor = true;
            this.acceptOrderBtn.Click += new System.EventHandler(this.acceptOrderBtn_Click);
            // 
            // showCustomersButton
            // 
            this.showCustomersButton.Location = new System.Drawing.Point(155, 174);
            this.showCustomersButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showCustomersButton.Name = "showCustomersButton";
            this.showCustomersButton.Size = new System.Drawing.Size(92, 22);
            this.showCustomersButton.TabIndex = 5;
            this.showCustomersButton.Text = "Show Customers";
            this.showCustomersButton.UseVisualStyleBackColor = true;
            this.showCustomersButton.Click += new System.EventHandler(this.showCustomersButton_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 217);
            this.Controls.Add(this.showCustomersButton);
            this.Controls.Add(this.acceptOrderBtn);
            this.Controls.Add(this.shipOrderBtn);
            this.Controls.Add(this.cancelOrderBtn);
            this.Controls.Add(this.ordersGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.Button cancelOrderBtn;
        private System.Windows.Forms.Button shipOrderBtn;
        private System.Windows.Forms.Button acceptOrderBtn;
        private System.Windows.Forms.Button showCustomersButton;
    }
}