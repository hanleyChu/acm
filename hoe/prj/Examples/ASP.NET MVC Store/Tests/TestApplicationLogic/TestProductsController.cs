using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ASPNET_MVC_Store.ApplicationLogic;
using ASPNET_MVC_Store.Model;
using MVCSharp.Core;
using MVCSharp.Core.Views;
using MVCSharp.Core.Tasks;

namespace Tests
{
    [TestFixture]
    public class TestProductsController
    {
        private ProductsController controller;

        [SetUp]
        public void TestSetup()
        {
            controller = new ProductsController();
            controller.Task = new MainTask();
            controller.Task.Navigator = new StubNavigator();
            controller.Task.Navigator.Task = controller.Task;
        }

        [Test]
        public void TestEditProduct()
        {
            NorthwindDataSet.ProductsRow prod =
                NorthwindDataSet.Instance.Products.NewProductsRow();
            controller.EditProduct(prod);

            Assert.AreSame(prod, controller.Task.SelectedProduct);
            Assert.AreEqual(MainTask.EditProduct, controller.Task.CurrViewName);
        }

        [Test]
        public void TestViewInitialization()
        {
            controller.View = new StubProductsView(); // Ensure View is not null
                                                      // at the beginning
            controller.Task.SelectedCategory =
                NorthwindDataSet.Instance.Categories.NewCategoriesRow();
            
            controller.View = new StubProductsView();

            Assert.AreEqual(controller.Task.SelectedCategory,
                            controller.View.Category);
        }

        [Test]
        public void TestUpdateViewProductsList()
        {
            controller.View = new StubProductsView();
            
            controller.Task.SelectedCategory =
                NorthwindDataSet.Instance.Categories.NewCategoriesRow();

            Assert.AreEqual(controller.Task.SelectedCategory,
                            controller.View.Category);
        }

        class StubProductsView : IProductsView
        {
            private NorthwindDataSet.CategoriesRow category;

            public NorthwindDataSet.CategoriesRow Category
            {
                get { return category; }
                set { category = value; }
            }
        }
    }
}
