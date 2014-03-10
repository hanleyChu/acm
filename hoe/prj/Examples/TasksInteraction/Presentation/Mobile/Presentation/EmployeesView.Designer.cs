namespace MVCSharp.Examples.TasksInteraction.Presentation
{
    partial class EmployeesView
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
            this.AwardBonusMenuItem = new System.Windows.Forms.MenuItem();
            this.employeesDataGrid = new System.Windows.Forms.DataGrid();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.AwardBonusMenuItem);
            // 
            // AwardBonusMenuItem
            // 
            this.AwardBonusMenuItem.Text = "Award bonus";
            this.AwardBonusMenuItem.Click += new System.EventHandler(this.AwardBonusMenuItem_Click);
            // 
            // employeesDataGrid
            // 
            this.employeesDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.employeesDataGrid.Location = new System.Drawing.Point(0, 0);
            this.employeesDataGrid.Name = "employeesDataGrid";
            this.employeesDataGrid.Size = new System.Drawing.Size(240, 268);
            this.employeesDataGrid.TabIndex = 0;
            // 
            // EmployeesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.employeesDataGrid);
            this.Menu = this.mainMenu;
            this.Name = "EmployeesView";
            this.Text = "EmployeesView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid employeesDataGrid;
        private System.Windows.Forms.MenuItem AwardBonusMenuItem;
    }
}

