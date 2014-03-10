using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using MVCSharp.Core.Configuration.Views;

namespace MVCSharp.Tests.Core.Configuration.Views
{
    [TestFixture]
    public class TestViewInfosByTaskCollection
    {
        ViewInfosByTaskCollection vibtColl;
        ViewInfosByTaskCollection vibtColl2 = new ViewInfosByTaskCollection();
        ViewInfosByTaskCollection vibtColl3 = new ViewInfosByTaskCollection();
        ViewInfo vi1 = new ViewInfo("vi1", null);
        ViewInfo vi2 = new ViewInfo("vi2", null);

        [SetUp]
        public void TestSetup()
        {
            vibtColl = new ViewInfosByTaskCollection();
            vibtColl[typeof(int)] = new ViewInfoCollection();
            vibtColl[typeof(string)] = new ViewInfoCollection();
        }

        [Test]
        public void TestCount()
        {
            Assert.AreEqual(2, vibtColl.Count);
        }

        [Test]
        public void TestAddColl()
        {
            vibtColl2[typeof(decimal)] = new ViewInfoCollection();
            vibtColl2[typeof(long)] = new ViewInfoCollection();
            vibtColl2[typeof(long)].Add(vi1);
            vibtColl.Add(vibtColl2);

            Assert.AreEqual(4, vibtColl.Count);
            Assert.AreSame(vibtColl2[typeof(decimal)], vibtColl[typeof(decimal)]);
            Assert.AreSame(vibtColl2[typeof(long)], vibtColl[typeof(long)]);

            vibtColl3[typeof(long)] = new ViewInfoCollection();
            vibtColl3[typeof(long)].Add(vi2);
            vibtColl.Add(vibtColl3);

            Assert.AreEqual(4, vibtColl.Count);
            Assert.AreEqual(2, vibtColl[typeof(long)].Count);
            Assert.AreSame(vi1, vibtColl2[typeof(long)]["vi1"]);
            Assert.AreSame(vi2, vibtColl2[typeof(long)]["vi2"]);
        }

        [Test]
        public void TestEnumerate()
        {
            bool containsFirst = false, containsSecond = false;
            int count = 0;

            foreach (Type t in vibtColl)
            {
                if (t == typeof(int))
                    containsFirst = true;
                else if (t == typeof(string))
                    containsSecond = true;
                count++;
            }

            Assert.AreEqual(2, count);
            Assert.IsTrue(containsFirst && containsSecond);
        }
    }
}
