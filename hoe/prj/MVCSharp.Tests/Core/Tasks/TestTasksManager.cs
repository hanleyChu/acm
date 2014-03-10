using System;
using System.Text;
using NUnit.Framework;
using MVCSharp.Core;
using MVCSharp.Core.Tasks;
using MVCSharp.Core.Configuration;
using MVCSharp.Core.Configuration.Views;
using MVCSharp.Core.Configuration.Tasks;
using MVCSharp.Core.Views;

namespace MVCSharp.Tests.Core.Tasks
{
    [TestFixture]
    public class TestTasksManager
    {
        private MVCConfiguration mvcConfig;
        private TaskInfo ti;
        private ViewInfoCollection viewInfos = new ViewInfoCollection();
        private TasksManager tm;

        [SetUp]
        public void SetUp()
        {
            StubTask.StartTimes = 0;
            mvcConfig = new MVCConfiguration();
            mvcConfig.ViewsManagerType = typeof(StubViewsManager);
            mvcConfig.TaskInfos[typeof(StubTask)] = ti = new TaskInfo();
            ti.ViewInfos = viewInfos;
            tm = new TasksManager(mvcConfig);
        }

        [Test]
        public void TestStartTask()
        {
            ITask startedTask = tm.StartTask(typeof(StubTask));
            Navigator n = startedTask.Navigator;
            Assert.AreSame(typeof(Navigator), n.GetType());
            Assert.AreSame(tm, startedTask.TasksManager);
            Assert.AreSame(startedTask, n.Task);
            Assert.AreSame(ti, n.TaskInfo);
            Assert.IsInstanceOfType(typeof(StubViewsManager), n.ViewsManager);
            Assert.AreSame(n, n.ViewsManager.Navigator);
            Assert.AreSame(viewInfos, n.ViewsManager.ViewInfos);
            Assert.AreEqual(1, StubTask.StartTimes);
            Assert.IsNull((startedTask as StubTask).PassedParam);
        }

        [Test]
        public void TestAssignedNavigatorType()
        {
            mvcConfig.NavigatorType = typeof(StubNavigator);
            TasksManager tm = new TasksManager(mvcConfig);
            ITask startedTask = tm.StartTask(typeof(StubTask));
            Assert.IsInstanceOfType(typeof(StubNavigator), startedTask.Navigator);
            
            ti.NavigatorType = typeof(StubNavigatorTwo);
            startedTask = tm.StartTask(typeof(StubTask));
            Assert.IsInstanceOfType(typeof(StubNavigatorTwo), startedTask.Navigator);
        }

        [Test]
        public void TestStartTaskWithParam()
        {
            ITask startedTask = tm.StartTask(typeof(StubTask), 10);
            Assert.AreEqual(10, (startedTask as StubTask).PassedParam);
        }

        [Test]
        public void TestConstructor()
        {
            Assert.AreSame(mvcConfig, tm.Config);
        }

        class StubTask : ITask
        {
            public static int StartTimes = 0;
            public object PassedParam = new int();
            private Navigator navigator;
            private TasksManager tasksManager;
            private string currViewName;

            public void OnStart(object param)
            {
                PassedParam = param;
                StartTimes++;
            }

            public Navigator Navigator
            {
                get { return navigator; }
                set { navigator = value; }
            }

            public TasksManager TasksManager
            {
                get { return tasksManager; }
                set { tasksManager = value; }
            }

            public string CurrViewName
            {
                get { return currViewName; }
                set { currViewName = value; }
            }
        }

        class StubViewsManager : IViewsManager
        {
            private Navigator navigator;
            private ViewInfoCollection viewInfos;

            public void ActivateView(string viewName)
            {
            }

            public Navigator Navigator
            {
                get { return navigator; }
                set { navigator = value; }
            }

            public ViewInfoCollection ViewInfos
            {
                get { return viewInfos; }
                set { viewInfos = value; }
            }

            public IView GetView(string viewName)
            { return null; }
        }

        class StubNavigator : Navigator
        {
            public override IController GetController(string viewName)
            {
                return base.GetController(viewName);
            }
        }

        class StubNavigatorTwo : Navigator
        { }
    }
}
