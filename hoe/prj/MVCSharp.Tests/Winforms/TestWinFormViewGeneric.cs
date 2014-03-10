using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using MVCSharp.Core;
using MVCSharp.Core.Tasks;
using MVCSharp.Core.Views;
using MVCSharp.Winforms;

namespace MVCSharp.Tests.Winforms
{
    [TestFixture]
    public class TestWinFormViewGeneric
    {
        private TestWinFormView v;

        private StubController stubController1 = new StubController();
        private StubController stubController2 = new StubController();

        [SetUp]
        public void TestSetup()
        {
            v = new TestWinFormView();
        }

        [Test]
        public void TestController()
        {
            (v as IView).Controller = stubController1;
            Assert.AreSame(stubController1, v.Controller);

            v.Controller = stubController2;
            Assert.AreSame(stubController2, (v as IView).Controller);
        }

        class TestWinFormView : WinFormView<StubController> { }

        class StubController : ControllerBase { }
    }
}
