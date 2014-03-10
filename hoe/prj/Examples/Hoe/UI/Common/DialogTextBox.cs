using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hoe.UI.Common
{
    public partial class DialogTextBox : Form
    {
        private static DialogTextBox instance = new DialogTextBox();

        public static DialogResult result;

        public static String textValue;

        public DialogTextBox()
        {
            InitializeComponent();
        }

        public static DialogResult Show(String label)
        {
            instance.textLabel.Text = label;
            instance.ShowDialog();
            return DialogTextBox.result;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogTextBox.textValue = instance.textBox.Text.Trim();
            DialogTextBox.result = DialogResult.OK;
            this.Close();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                okButton_Click(this, e);
                DialogTextBox.result = DialogResult.OK;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogTextBox.result = DialogResult.Cancel;
            this.Close();
        }
    }
}
