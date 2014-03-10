using System;
using System.Text;
using NUnit.Framework;
using MVCSharp.Core.Configuration.Tasks;
using MVCSharp.Core;

namespace MVCSharp.Tests.Core.Configuration.Tasks
{
    [TestFixture]
    public class TestDefaultTaskInfoProvider
    {
        private DefaultTaskInfoProvider tskInfPrvdr = new DefaultTaskInfoProvider();

        [Test]
        public void TestGetTaskInfo()
        {
            TaskInfo ti = tskInfPrvdr.GetTaskInfo(typeof(StubTask1));
            Assert.IsNull(ti.NavigatorType);
            Assert.IsNotNull(ti.InteractionPoints["StubTask1 View"]);

            ti = tskInfPrvdr.GetTaskInfo(typeof(StubTask2));
            Assert.IsNotNull(ti.InteractionPoints["StubTask2 View"]);

            ti = tskInfPrvdr.GetTaskInfo(typeof(StubTask3));
            Assert.IsNotNull(ti.InteractionPoints["StubTask3 View"]);
            Assert.AreSame(typeof(StubNavigator), ti.NavigatorType);
        }

        class StubTask1
        {
            [InteractionPoint(typeof(StubController1))]
            public const string iPoint1 = "StubTask1 View";
        }

        [Task(@"
            <interactionPoints>
                <interactionPoint view = ""StubTask2 View"" controllerType = ""MVCSharp.Tests.Core.Configuration.Tasks.StubController1""/>
            </interactionPoints>
        ")]
        class StubTask2
        {
        }

        [Task(typeof(StubNavigator))]
        class StubTask3
        {
            [InteractionPoint(typeof(StubController1))]
            public const string iPoint1 = "StubTask3 View";
        }

        class StubNavigator : Navigator
        {}
    }
}
