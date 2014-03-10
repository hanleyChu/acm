namespace MVCSharp.Examples.Basics.Presentation
{
    partial class CustomersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu CustomersMainMenu;

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
            this.CustomersMainMenu = new System.Windows.Forms.MainMenu();
            this.ShowOrdersMenuItem = new System.Windows.Forms.MenuItem();
            this.CustomersDataGrid = new System.Windows.Forms.DataGrid();
            this.SuspendLayout();
            // 
            // CustomersMainMenu
            // 
            this.CustomersMainMenu.MenuItems.Add(this.ShowOrdersMenuItem);
            // 
            // ShowOrdersMenuItem
            // 
            this.ShowOrdersMenuItem.Text = "ShowOrders";
            this.ShowOrdersMenuItem.Click += new System.EventHandler(this.ShowOrdersMenuItem_Click);
            // 
            // CustomersDataGrid
            // 
            this.CustomersDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CustomersDataGrid.Location = new System.Drawing.Point(0, 0);
            this.CustomersDataGrid.Name = "CustomersDataGrid";
            this.CustomersDataGrid.Size = new System.Drawing.Size(240, 268);
            this.CustomersDataGrid.TabIndex = 0;
            this.CustomersDataGrid.CurrentCellChanged += new System.EventHandler(this.CustomersDataGrid_CurrentCellChanged);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.CustomersDataGrid);
            this.Menu = this.CustomersMainMenu;
            this.Name = "CustomersForm";
            this.Text = "CustomersForm";
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.DataGrid CustomersDataGrid;
        private System.Windows.Forms.MenuItem ShowOrdersMenuItem;
    }
}