namespace Hoe.UI.Repo
{
    partial class ProductForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.normLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.remarkLabel = new System.Windows.Forms.Label();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.normTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.NewProductButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.normLabel);
            this.groupBox1.Controls.Add(this.materialLabel);
            this.groupBox1.Controls.Add(this.numberLabel);
            this.groupBox1.Controls.Add(this.numberTextBox);
            this.groupBox1.Controls.Add(this.remarkLabel);
            this.groupBox1.Controls.Add(this.remarkTextBox);
            this.groupBox1.Controls.Add(this.normTextBox);
            this.groupBox1.Controls.Add(this.materialTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.NewProductButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 352);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新货入库";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(16, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 12);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "名称";
            // 
            // normLabel
            // 
            this.normLabel.AutoSize = true;
            this.normLabel.Location = new System.Drawing.Point(16, 112);
            this.normLabel.Name = "normLabel";
            this.normLabel.Size = new System.Drawing.Size(29, 12);
            this.normLabel.TabIndex = 20;
            this.normLabel.Text = "规格";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(16, 68);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(29, 12);
            this.materialLabel.TabIndex = 19;
            this.materialLabel.Text = "材料";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(16, 158);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(29, 12);
            this.numberLabel.TabIndex = 18;
            this.numberLabel.Text = "数量";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(51, 158);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(215, 21);
            this.numberTextBox.TabIndex = 4;
            // 
            // remarkLabel
            // 
            this.remarkLabel.AutoSize = true;
            this.remarkLabel.Location = new System.Drawing.Point(16, 221);
            this.remarkLabel.Name = "remarkLabel";
            this.remarkLabel.Size = new System.Drawing.Size(29, 12);
            this.remarkLabel.TabIndex = 16;
            this.remarkLabel.Text = "备注";
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.Location = new System.Drawing.Point(51, 218);
            this.remarkTextBox.Multiline = true;
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(215, 79);
            this.remarkTextBox.TabIndex = 5;
            // 
            // normTextBox
            // 
            this.normTextBox.Location = new System.Drawing.Point(51, 112);
            this.normTextBox.Name = "normTextBox";
            this.normTextBox.Size = new System.Drawing.Size(215, 21);
            this.normTextBox.TabIndex = 3;
            // 
            // materialTextBox
            // 
            this.materialTextBox.Location = new System.Drawing.Point(51, 68);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(215, 21);
            this.materialTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(51, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(215, 21);
            this.nameTextBox.TabIndex = 1;
            // 
            // NewProductButton
            // 
            this.NewProductButton.Location = new System.Drawing.Point(93, 323);
            this.NewProductButton.Name = "NewProductButton";
            this.NewProductButton.Size = new System.Drawing.Size(75, 23);
            this.NewProductButton.TabIndex = 6;
            this.NewProductButton.Text = "添加";
            this.NewProductButton.UseVisualStyleBackColor = true;
            this.NewProductButton.Click += new System.EventHandler(this.NewProductButton_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 368);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "货物";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label normLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label remarkLabel;
        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.TextBox normTextBox;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button NewProductButton;

    }
}