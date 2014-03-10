using System;
using System.Text;
using System.Reflection;
using NUnit.Framework;
using MVCSharp.Core.Configuration.Views;

namespace MVCSharp.Tests.Core.Configuration.Views
{
    [TestFixture]
    public class TestDefaultViewInfosProvider
    {
        [Test]
        public void TestGetFromAssembly()
        {
            IViewInfosProvider viewInfsProvider = new DefaultViewInfosProvider();
            ViewInfosByTaskCollection viewInfsByTask = viewInfsProvider.GetFromAssembly(
                                                         Assembly.GetExecutingAssembly());
            Assert.AreSame(typeof(View1), viewInfsByTask[typeof(int)]["View 1"].ViewType);
            Assert.AreSame(typeof(View2), viewInfsByTask[typeof(int)]["View 2"].ViewType);
            Assert.AreSame(typeof(View3), viewInfsByTask[typeof(string)]["View 1"].ViewType);
        }

        [Test]
        public void TestOverrideNewViewInfo()
        {
            IViewInfosProvider viewInfsProvider = new StubViewInfosProvider();
            ViewInfosByTaskCollection viewInfsByTask = viewInfsProvider.GetFromAssembly(
                                                         Assembly.GetExecutingAssembly());
            Assert.AreSame(typeof(View1), viewInfsByTask[typeof(int)]["View 1"].ViewType);
            Assert.AreSame(StubViewInfosProvider.specialViewInf, viewInfsByTask[typeof(int)]["StubPropVal"]);
        }
    }

    [View(TaskType = typeof(int), ViewName = "View 1")]
    public class View1 { }

    [View(typeof(int), "View 2")]
    public class View2 { }

    [View(TaskType = typeof(string), ViewName = "View 1")]
    public class View3 { }

    public class View4 : View1 { }

    [StubView(TaskType = typeof(int), ViewName = "View 5", StubViewProperty = "StubPropVal")]
    public class View5 { }

    public class StubViewInfosProvider : DefaultViewInfosProvider
    {
        public static ViewInfo specialViewInf;

        protected override ViewInfo newViewInfo(Type viewType, ViewAttribute viewAttr)
        {
            if (viewAttr is StubViewAttribute)
                return specialViewInf = new ViewInfo(
                        (viewAttr as StubViewAttribute).StubViewProperty, typeof(int));
            else return base.newViewInfo(viewType, viewAttr);
        }
    }

    public class StubViewAttribute : ViewAttribute
    {
        private string stubViewProperty;

        public string StubViewProperty
        {
            get { return stubViewProperty; }
            set { stubViewProperty = value; }
        }
    }
}
