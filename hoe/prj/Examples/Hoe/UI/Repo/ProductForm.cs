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
using MVCSharp.Winforms.Configuration;
using Hoe.Basic.AppLogic;
using Hoe.Basic.Model;
using Hoe.Basic.Controller;

namespace Hoe.UI.Repo
{
    [WinformsView(typeof(ProductTask), ProductTask.ProductView, ShowModal = true)]
    public partial class ProductForm : WinFormView
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void NewProductButton_Click(object sender, EventArgs e)
        {
            String name = this.nameTextBox.Text.Trim();
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("名字不为空");
                return;
            }

            String material = this.materialTextBox.Text.Trim();
            if(String.IsNullOrEmpty(material))
            {
                MessageBox.Show("材料不为空");
                return;
            }

            String norm = this.normTextBox.Text.Trim();
            if (String.IsNullOrEmpty(norm))
            {
                MessageBox.Show("规格不为空");
                return;
            }

            String numberStr = this.numberTextBox.Text.Trim();
            int quantity;

            if (!(int.TryParse(numberStr, out quantity) && quantity>=0))
            {
                MessageBox.Show("请输入大于等于0的整数");
                return;
            }

            String remark = this.remarkTextBox.Text.Trim();

            Product p = new Product() 
            { 
                Name = name,
                Material = material,
                Norm = norm,
                Quantity = quantity,
                Remark = remark,
            };

            (Controller as ProductController).NewProduct(p);

        }
    }
}
