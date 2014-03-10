namespace Hoe.UI.Sale
{
    partial class BillForm
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
            this.newBillButton = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deliveryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.remarkLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newBillButton
            // 
            this.newBillButton.Location = new System.Drawing.Point(91, 278);
            this.newBillButton.Name = "newBillButton";
            this.newBillButton.Size = new System.Drawing.Size(75, 23);
            this.newBillButton.TabIndex = 0;
            this.newBillButton.Text = "新建";
            this.newBillButton.UseVisualStyleBackColor = true;
            this.newBillButton.Click += new System.EventHandler(this.newBillButton_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberTextBox.Location = new System.Drawing.Point(91, 31);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(190, 21);
            this.numberTextBox.TabIndex = 1;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTextBox.Location = new System.Drawing.Point(91, 80);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(190, 21);
            this.phoneTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "电话";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "提货日期";
            // 
            // deliveryDateTimePicker
            // 
            this.deliveryDateTimePicker.Location = new System.Drawing.Point(92, 134);
            this.deliveryDateTimePicker.Name = "deliveryDateTimePicker";
            this.deliveryDateTimePicker.Size = new System.Drawing.Size(189, 21);
            this.deliveryDateTimePicker.TabIndex = 7;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remarkTextBox.Location = new System.Drawing.Point(91, 181);
            this.remarkTextBox.Multiline = true;
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(322, 80);
            this.remarkTextBox.TabIndex = 8;
            // 
            // remarkLabel
            // 
            this.remarkLabel.AutoSize = true;
            this.remarkLabel.Location = new System.Drawing.Point(44, 184);
            this.remarkLabel.Name = "remarkLabel";
            this.remarkLabel.Size = new System.Drawing.Size(29, 12);
            this.remarkLabel.TabIndex = 9;
            this.remarkLabel.Text = "备注";
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 325);
            this.Controls.Add(this.remarkLabel);
            this.Controls.Add(this.remarkTextBox);
            this.Controls.Add(this.deliveryDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.newBillButton);
            this.Name = "BillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "订单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newBillButton;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker deliveryDateTimePicker;
        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.Label remarkLabel;
    }
}