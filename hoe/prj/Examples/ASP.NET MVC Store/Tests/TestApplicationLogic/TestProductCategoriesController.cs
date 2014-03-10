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
    public class TestProductCategoriesController
    {
        private ProductCategoriesController controller;

        [SetUp]
        public void TestSetup()
        {
            controller = new ProductCategoriesController();
            controller.Task = new MainTask();
            controller.Task.Navigator = new StubNavigator();
            controller.Task.Navigator.Task = controller.Task;
        }

        [Test]
        public void TestCategorySelected()
        {
            NorthwindDataSet.CategoriesRow cat =
                NorthwindDataSet.Instance.Categories.NewCategoriesRow();
            controller.CategorySelected(cat);

            Assert.AreSame(cat, controller.Task.SelectedCategory);
            Assert.AreEqual(MainTask.Products, controller.Task.CurrViewName);
        }

        [Test]
        public void TestViewInitialization()
        {
            controller.View = new StubProductCategoriesView();

            Assert.AreSame((NorthwindDataSet.Instance.Categories as IListSource)
                            .GetList(), controller.View.CategoriesList); 
        }

        class StubProductCategoriesView : IProductCategoriesView
        {
            private IList catList;

            public IList CategoriesList
            {
                get { return catList; }
                set { catList = value; }
            }
        }
    }
}
