using System;
using System.Text;
using System.Reflection;
using NUnit.Framework;
using MVCSharp.Core.Configuration;
using MVCSharp.Core.Configuration.Tasks;
using MVCSharp.Core.Configuration.Views;

namespace MVCSharp.Tests.Core.Configuration
{
    [TestFixture]
    public class TestMVCConfiguration
    {
        private MVCConfiguration mvcConfig;
        
        [SetUp]
        public void TestSetUp()
        {
            mvcConfig = new MVCConfiguration();
        }

        [Test]
        public void TestViewInfosByTask()
        {
            mvcConfig.ViewInfosProviderType = typeof(StubViewInfosProvider);
            mvcConfig.ViewsAssembly = StubViewInfosProvider.inputAssembly1;
            Assert.AreEqual(1, mvcConfig.ViewInfosByTask[typeof(int)].Count);
            Assert.AreSame(StubViewInfosProvider.vi1, mvcConfig.ViewInfosByTask[typeof(int)]["vi1"]);
        }

        [Test]
        public void TestViewInfosByTask_Advanced()
        {
            mvcConfig.ViewInfosProviderType = typeof(StubViewInfosProvider);
            mvcConfig.ViewsAssembly = StubViewInfosProvider.inputAssembly1;
            mvcConfig.ViewsAssemblies.Add(StubViewInfosProvider.inputAssembly2);
            mvcConfig.ViewsAssemblies.Add(StubViewInfosProvider.inputAssembly3);
            Assert.AreEqual(3, mvcConfig.ViewInfosByTask[typeof(int)].Count);
            Assert.AreSame(StubViewInfosProvider.vi1, mvcConfig.ViewInfosByTask[typeof(int)]["vi1"]);
            Assert.AreSame(StubViewInfosProvider.vi2, mvcConfig.ViewInfosByTask[typeof(int)]["vi2"]);
            Assert.AreSame(StubViewInfosProvider.vi3, mvcConfig.ViewInfosByTask[typeof(int)]["vi3"]);

            mvcConfig = new MVCConfiguration();
            mvcConfig.ViewInfosProviderType = typeof(StubViewInfosProvider);
            mvcConfig.ViewsAssemblies.Add(StubViewInfosProvider.inputAssembly2);
            Assert.AreEqual(1, mvcConfig.ViewInfosByTask[typeof(int)].Count);
            Assert.AreSame(StubViewInfosProvider.vi2, mvcConfig.ViewInfosByTask[typeof(int)]["vi2"]);
        }

        [Test]
        public void TestTaskInfoProvider()
        {
            mvcConfig.TaskInfoProviderType = typeof(StubTaskInfoProvider1);
            Assert.IsInstanceOfType(typeof(StubTaskInfoProvider1), mvcConfig.TaskInfoProvider);

            StubTaskInfoProvider taskInfP = new StubTaskInfoProvider();
            mvcConfig.TaskInfoProvider = taskInfP;
            Assert.AreSame(taskInfP, mvcConfig.TaskInfoProvider);

            mvcConfig.TaskInfoProvider = null;
            Assert.IsInstanceOfType(typeof(StubTaskInfoProvider1), mvcConfig.TaskInfoProvider);
        }

        [Test]
        public void TestTaskInfos()
        {
            TaskInfoCollection taskInfos = mvcConfig.TaskInfos;
            Assert.IsNotNull(taskInfos);
            Assert.AreSame(taskInfos.MVCConfig, mvcConfig);
        }

        [Test]
        public void TestGetDefault()
        {
            MVCConfiguration defaultConf = MVCConfiguration.GetDefault();
            Assert.AreEqual(typeof(DefaultTaskInfoProvider), defaultConf.TaskInfoProviderType);
            Assert.AreEqual(typeof(DefaultViewInfosProvider), defaultConf.ViewInfosProviderType);
            Assert.AreEqual(Assembly.GetExecutingAssembly(), defaultConf.ViewsAssembly);
            Assert.AreNotSame(defaultConf, MVCConfiguration.GetDefault());
        }

        #region Stubs implementations

        public class StubViewInfosProvider : IViewInfosProvider
        {
            public static readonly Assembly inputAssembly1 = Assembly.Load("System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
            public static readonly Assembly inputAssembly2 = Assembly.Load("System.Data, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
            public static readonly Assembly inputAssembly3 = Assembly.Load("System.Xml, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");

            public static readonly ViewInfo vi1 = new ViewInfo("vi1", null);
            public static readonly ViewInfo vi2 = new ViewInfo("vi2", null);
            public static readonly ViewInfo vi3 = new ViewInfo("vi3", null);

            public ViewInfosByTaskCollection GetFromAssembly(Assembly assembly)
            {
                ViewInfosByTaskCollection result = new ViewInfosByTaskCollection();
                result[typeof(int)] = new ViewInfoCollection();
                if (assembly == inputAssembly1)
                    result[typeof(int)].Add(vi1);
                else if (assembly == inputAssembly2)
                    result[typeof(int)].Add(vi2);
                else if (assembly == inputAssembly3)
                    result[typeof(int)].Add(vi3);
                return result;
            }
        }

        class StubTaskInfoProvider1 : StubTaskInfoProvider
        {}

        class StubTaskInfoProvider : ITaskInfoProvider
        {
            public static readonly TaskInfo returnedObj = new TaskInfo();

            public TaskInfo GetTaskInfo(Type taskType)
            {
                return returnedObj;
            }
        }

        #endregion
    }
}
