namespace MVCSharp.Examples.TasksInteraction.Presentation
{
    partial class ABAdvancedOptionsView
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
            this.workerOfTheMonthCB = new System.Windows.Forms.CheckBox();
            this.specialServicesCB = new System.Windows.Forms.CheckBox();
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
            // workerOfTheMonthCB
            // 
            this.workerOfTheMonthCB.Location = new System.Drawing.Point(22, 24);
            this.workerOfTheMonthCB.Name = "workerOfTheMonthCB";
            this.workerOfTheMonthCB.Size = new System.Drawing.Size(207, 26);
            this.workerOfTheMonthCB.TabIndex = 0;
            this.workerOfTheMonthCB.Text = "Worker Of The Month";
            // 
            // specialServicesCB
            // 
            this.specialServicesCB.Location = new System.Drawing.Point(22, 78);
            this.specialServicesCB.Name = "specialServicesCB";
            this.specialServicesCB.Size = new System.Drawing.Size(207, 20);
            this.specialServicesCB.TabIndex = 1;
            this.specialServicesCB.Text = "Special Services";
            // 
            // ABAdvancedOptionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.specialServicesCB);
            this.Controls.Add(this.workerOfTheMonthCB);
            this.Menu = this.mainMenu;
            this.Name = "ABAdvancedOptionsView";
            this.Text = "ABAdvancedOptionsView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox workerOfTheMonthCB;
        private System.Windows.Forms.CheckBox specialServicesCB;
        private System.Windows.Forms.MenuItem OKmenuItem;
    }
}