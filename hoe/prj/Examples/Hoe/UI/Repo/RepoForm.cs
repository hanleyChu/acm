using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVCSharp.Core.Views;
using MVCSharp.Core;
using MVCSharp.Core.Configuration.Views;
using MVCSharp.Winforms;
using Hoe.Basic.Controller;
using Hoe.Basic.View;
using Hoe.Basic.AppLogic;
using Hoe.Basic.Model;
using System.Collections;


namespace Hoe.UI.Repo
{
    [View(typeof(SaleTask), SaleTask.RepoView)]
    public partial class RepoForm : WinFormView, IRepoView
    {
        public RepoForm()
        {
            InitializeComponent();
        }

        public Product CurrentProduct
        {
            get
            {
                return productsDataGridView.CurrentRow == null ? null :
                       productsDataGridView.CurrentRow.DataBoundItem as Product;
            }
        }

        public int SalesCount
        {
            get
            {
                int salesCount;
                if (!int.TryParse(this.countOfProductTextBox.Text, out salesCount))
                {
                    return -1;
                }
                else
                {
                    return salesCount;
                }
            }
        }

        private void gridview_currentProductChanged(object sender, EventArgs e)
        {
            (Controller as RepoController).SetCurrentRepoProduct(CurrentProduct);
        }

        private void addToBillButton_Click(object sender, EventArgs e)
        {
            (Controller as RepoController).AddCurrentProductToBill(SalesCount);
        }

        private void showBillsButton_Click(object sender, EventArgs e)
        {
            (Controller as RepoController).ShowBills();
        }

        public void ShowProductsList(List<Product> products)
        {   
            this.productsDataGridView.DataSource = new BindingSource(products, null);
            this.productsDataGridView.Refresh();
        }

        public void SelectProductInList(Product product)
        {
            int index = (this.productsDataGridView.DataSource as BindingSource).IndexOf(product);
            int count = this.productsDataGridView.Rows.Count;
            if(index<count && index >=0)
            {
                this.productsDataGridView.Rows[index].Selected = true;
                this.productsDataGridView.Refresh();
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            (Controller as RepoController).ShowProductView();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            (Controller as RepoController).FilterProducts("");
        }

        private void productsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // make right click row selected
                var hit = this.productsDataGridView.HitTest(e.X, e.Y);
                int count = this.productsDataGridView.Rows.Count;
                if (hit.RowIndex < count && hit.RowIndex >= 0)
                {
                    this.productsDataGridView.CurrentCell = this.productsDataGridView.Rows[hit.RowIndex].Cells[hit.ColumnIndex];
                    this.productsDataGridView.Rows[hit.RowIndex].Selected = true;
                    this.productsDataGridView.Focus();

                    // trigger the click event as left click to set the current product
                    this.gridview_currentProductChanged(null, null);
                }

                this.productMenu.Show(this.productsDataGridView, e.X, e.Y);
            }
        }

        private void deleteProductMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要吃糠删掉这个货?", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Product product = CurrentProduct;
                (this.productsDataGridView.DataSource as BindingSource).Remove(CurrentProduct);
                (Controller as RepoController).DeleteProduct(product);
            }

        }

        private void productsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = this.productsDataGridView.Columns[e.ColumnIndex].DataPropertyName;

            // Abort validation if cell is not in the Quantity column. 
            if (columnName.Equals("Quantity"))
            {
                String newValue = e.FormattedValue.ToString();
                int result;
                if (!int.TryParse(newValue as String, out result) || result<0)
                {
                    MessageBox.Show("请输入合法的数字");
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void productsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //only end edit mode, we can get the real updated value
            this.productsDataGridView.EndEdit();

            (Controller as RepoController).UpdateProduct(CurrentProduct);
        }

        private void nameOfProductTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                (Controller as RepoController).FilterProducts(this.nameOfProductTextBox.Text.Trim());
            }
        }

    }
}
