using System;
using System.Text;
using System.Reflection;
using NUnit.Framework;
using MVCSharp.Core.Configuration;
using MVCSharp.Core.Configuration.Tasks;
using MVCSharp.Core.Configuration.Views;

namespace MVCSharp.Tests.Core.Configuration.Tasks
{
    [TestFixture]
    public class TestTaskInfoCollection
    {
        private MVCConfiguration mvcConfig = new MVCConfiguration();

        [TestFixtureSetUp]
        public void FixtureSetUp()
        {
            mvcConfig.TaskInfoProvider = new StubTaskInfoProvider();
            mvcConfig.ViewInfosProviderType = typeof(StubViewInfosProvider);
            mvcConfig.ViewsAssembly = Assembly.GetExecutingAssembly();
        }

        [Test]
        public void TestIndexer()
        {
            TaskInfoCollection taskInfColl = new TaskInfoCollection();
            taskInfColl.MVCConfig = mvcConfig;

            TaskInfo ti = taskInfColl[typeof(StubTask)];
            Assert.AreSame(StubTaskInfoProvider.returnedObj, ti);
            Assert.AreSame(StubViewInfosProvider.returnedViewInfoColl, ti.ViewInfos);
        }

        [Test]
        public void TestEnumerateAndCount()
        {
            TaskInfoCollection taskInfColl = new TaskInfoCollection();
            taskInfColl[typeof(int)] = new TaskInfo();
            taskInfColl[typeof(string)] = new TaskInfo();

            Assert.AreEqual(2, taskInfColl.Count);

            bool containsFirst = false, containsSecond = false;
            int count = 0;

            foreach (Type t in taskInfColl)
            {
                if (t == typeof(int))
                    containsFirst = true;
                else if (t == typeof(string))
                    containsSecond = true;
                count++;
            }

            Assert.IsTrue(containsFirst && containsSecond && (count == 2));
        }

        #region Stubs implementations

        class StubTask
        { }

        class StubTaskInfoProvider : ITaskInfoProvider
        {
            public static readonly TaskInfo returnedObj = new TaskInfo();

            public TaskInfo GetTaskInfo(Type taskType)
            {
                return returnedObj;
            }
        }

        class StubViewInfosProvider : IViewInfosProvider
        {
            public static readonly ViewInfoCollection returnedViewInfoColl = new ViewInfoCollection();

            public ViewInfosByTaskCollection GetFromAssembly(Assembly assembly)
            {
                ViewInfosByTaskCollection result = new ViewInfosByTaskCollection();
                result[typeof(StubTask)] = returnedViewInfoColl;
                return result;
            }
        }

        #endregion
    }
}
