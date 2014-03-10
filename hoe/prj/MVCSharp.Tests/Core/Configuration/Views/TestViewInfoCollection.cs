using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using MVCSharp.Core.Configuration.Views;

namespace MVCSharp.Tests.Core.Configuration.Views
{
    [TestFixture]
    public class TestViewInfoCollection
    {
        ViewInfoCollection viColl;

        [SetUp]
        public void TestSetup()
        {
            viColl = new ViewInfoCollection();
            viColl["A"] = new ViewInfo("A", typeof(int));
            viColl["B"] = new ViewInfo("B", typeof(string));
        }

        [Test]
        public void TestAdd()
        {
            ViewInfo vi = new ViewInfo("C", typeof(bool));
            
            viColl.Add(vi);

            Assert.AreSame(vi, viColl["C"]);
        }

        [Test]
        public void TestIndexerWithTypeParam()
        {
            ViewInfo vi = viColl[typeof(string)];
            Assert.AreSame(viColl["B"], vi);
        }

        [Test]
        public void TestCount()
        {
            Assert.AreEqual(2, viColl.Count);
        }

        [Test]
        public void TestAddColl()
        {
            ViewInfoCollection viColl2 = new ViewInfoCollection();
            viColl2["D"] = new ViewInfo("D", typeof(decimal));
            viColl2["E"] = new ViewInfo("E", typeof(long));

            viColl.Add(viColl2);

            Assert.AreEqual(4, viColl.Count);
            Assert.AreSame(viColl2["D"], viColl["D"]);
            Assert.AreSame(viColl2["E"], viColl["E"]);
        }

        [Test]
        public void TestEnumerate()
        {
            bool containsA = false, containsB = false;
            int count = 0;

            foreach (ViewInfo vi in viColl)
            {
                if (vi == viColl["A"])
                    containsA = true;
                else if (vi == viColl["B"])
                    containsB = true;
                count++;
            }

            Assert.AreEqual(2, count);
            Assert.IsTrue(containsA && containsB);
        }
    }
}
