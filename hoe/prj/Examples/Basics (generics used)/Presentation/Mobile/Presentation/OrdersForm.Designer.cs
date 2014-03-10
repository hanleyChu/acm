namespace MVCSharp.Examples.Basics.Presentation
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu OrdersMainMenu;

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
            this.OrdersMainMenu = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.ShipMenuItem = new System.Windows.Forms.MenuItem();
            this.CancelMenuItem = new System.Windows.Forms.MenuItem();
            this.AcceptMenuItem = new System.Windows.Forms.MenuItem();
            this.ShowMenuItem = new System.Windows.Forms.MenuItem();
            this.OrdersDataGrid = new System.Windows.Forms.DataGrid();
            this.SuspendLayout();
            // 
            // OrdersMainMenu
            // 
            this.OrdersMainMenu.MenuItems.Add(this.menuItem1);
            this.OrdersMainMenu.MenuItems.Add(this.ShowMenuItem);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.ShipMenuItem);
            this.menuItem1.MenuItems.Add(this.CancelMenuItem);
            this.menuItem1.MenuItems.Add(this.AcceptMenuItem);
            this.menuItem1.Text = "Menu";
            // 
            // ShipMenuItem
            // 
            this.ShipMenuItem.Text = "Ship order";
            this.ShipMenuItem.Click += new System.EventHandler(this.ShipMenuItem_Click);
            // 
            // CancelMenuItem
            // 
            this.CancelMenuItem.Text = "Cancel order";
            this.CancelMenuItem.Click += new System.EventHandler(this.CancelMenuItem_Click);
            // 
            // AcceptMenuItem
            // 
            this.AcceptMenuItem.Text = "Accept order";
            this.AcceptMenuItem.Click += new System.EventHandler(this.AcceptMenuItem_Click);
            // 
            // ShowMenuItem
            // 
            this.ShowMenuItem.Text = "Show customers";
            this.ShowMenuItem.Click += new System.EventHandler(this.ShowMenuItem_Click);
            // 
            // OrdersDataGrid
            // 
            this.OrdersDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.OrdersDataGrid.Location = new System.Drawing.Point(0, 0);
            this.OrdersDataGrid.Name = "OrdersDataGrid";
            this.OrdersDataGrid.Size = new System.Drawing.Size(240, 265);
            this.OrdersDataGrid.TabIndex = 0;
            this.OrdersDataGrid.CurrentCellChanged += new System.EventHandler(this.OrdersDataGrid_CurrentCellChanged);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.OrdersDataGrid);
            this.Menu = this.OrdersMainMenu;
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid OrdersDataGrid;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem ShipMenuItem;
        private System.Windows.Forms.MenuItem ShowMenuItem;
        private System.Windows.Forms.MenuItem CancelMenuItem;
        private System.Windows.Forms.MenuItem AcceptMenuItem;
    }
}