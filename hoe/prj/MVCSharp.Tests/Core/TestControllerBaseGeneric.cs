using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using MVCSharp.Core;
using MVCSharp.Core.Tasks;
using MVCSharp.Core.Views;

namespace MVCSharp.Tests.Core
{
    [TestFixture]
    public class TestControllerBaseGeneric
    {
        private TestController c;

        private StubTask stubTask1 = new StubTask();
        private StubTask stubTask2 = new StubTask();

        private StubView stubView1 = new StubView();
        private StubView stubView2 = new StubView();

        [SetUp]
        public void TestSetup()
        {
            c = new TestController();
        }

        [Test]
        public void TestTask()
        {
            (c as IController).Task = stubTask1;
            Assert.AreSame(stubTask1, c.Task);
            Assert.AreEqual(1, c.SetTaskCount);

            c.Task = stubTask2;
            Assert.AreSame(stubTask2, (c as IController).Task);
            Assert.AreEqual(2, c.SetTaskCount);
        }

        [Test]
        public void TestView()
        {
            (c as IController).View = stubView1;
            Assert.AreSame(stubView1, c.View);
            Assert.AreEqual(1, c.SetViewCount);

            c.View = stubView2;
            Assert.AreSame(stubView2, (c as IController).View);
            Assert.AreEqual(2, c.SetViewCount);
        }

        class TestController : ControllerBase<StubTask, IStubView>
        {
            public int SetTaskCount = 0;
            public int SetViewCount = 0;

            public override StubTask Task
            {
                get { return base.Task; }
                set { base.Task = value; SetTaskCount++; }
            }

            public override IStubView View
            {
                get { return base.View; }
                set { base.View = value; SetViewCount++; }
            }
        }

        class StubTask : TaskBase {}

        class StubView : IView, IStubView
        {
            public IController  Controller
            {
                get { throw new NotImplementedException(); }
                set { throw new NotImplementedException(); }
            }

            public string  ViewName
            {
                get { throw new NotImplementedException(); }
                set { throw new NotImplementedException(); }
            }

            public void DoSomething()
            {
                throw new NotImplementedException();
            }
        }

        interface IStubView
        {
            void DoSomething();
        }
    }
}
