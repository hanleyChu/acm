namespace MVCSharp.Examples.TasksInteraction.Presentation
{
    partial class ABMainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu;

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
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.OKmenuItem = new System.Windows.Forms.MenuItem();
            this.contractsNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.customersNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.customersLbl = new System.Windows.Forms.Label();
            this.contractsLbl = new System.Windows.Forms.Label();
            this.advancedLinkLbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.OKmenuItem);
            // 
            // OKmenuItem
            // 
            this.OKmenuItem.Text = "OK";
            this.OKmenuItem.Click += new System.EventHandler(this.OKmenuItem_Click);
            // 
            // contractsNumUpDown
            // 
            this.contractsNumUpDown.Location = new System.Drawing.Point(161, 20);
            this.contractsNumUpDown.Name = "contractsNumUpDown";
            this.contractsNumUpDown.Size = new System.Drawing.Size(56, 26);
            this.contractsNumUpDown.TabIndex = 0;
            // 
            // customersNumUpDown
            // 
            this.customersNumUpDown.Location = new System.Drawing.Point(161, 63);
            this.customersNumUpDown.Name = "customersNumUpDown";
            this.customersNumUpDown.Size = new System.Drawing.Size(56, 26);
            this.customersNumUpDown.TabIndex = 1;
            // 
            // customersLbl
            // 
            this.customersLbl.Location = new System.Drawing.Point(19, 50);
            this.customersLbl.Name = "customersLbl";
            this.customersLbl.Size = new System.Drawing.Size(136, 39);
            this.customersLbl.Text = "Customers attracted";
            // 
            // contractsLbl
            // 
            this.contractsLbl.Location = new System.Drawing.Point(19, 22);
            this.contractsLbl.Name = "contractsLbl";
            this.contractsLbl.Size = new System.Drawing.Size(136, 20);
            this.contractsLbl.Text = "Contracts made";
            // 
            // advancedLinkLbl
            // 
            this.advancedLinkLbl.Location = new System.Drawing.Point(19, 134);
            this.advancedLinkLbl.Name = "advancedLinkLbl";
            this.advancedLinkLbl.Size = new System.Drawing.Size(120, 20);
            this.advancedLinkLbl.TabIndex = 4;
            this.advancedLinkLbl.Text = "Advanced options";
            this.advancedLinkLbl.Click += new System.EventHandler(this.advancedLinkLbl_Click);
            // 
            // ABMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.advancedLinkLbl);
            this.Controls.Add(this.contractsLbl);
            this.Controls.Add(this.customersLbl);
            this.Controls.Add(this.customersNumUpDown);
            this.Controls.Add(this.contractsNumUpDown);
            this.Menu = this.mainMenu;
            this.Name = "ABMainView";
            this.Text = "ABMainView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown contractsNumUpDown;
        private System.Windows.Forms.NumericUpDown customersNumUpDown;
        private System.Windows.Forms.Label customersLbl;
        private System.Windows.Forms.Label contractsLbl;
        private System.Windows.Forms.LinkLabel advancedLinkLbl;
        private System.Windows.Forms.MenuItem OKmenuItem;
    }
}