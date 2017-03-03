using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_2;
using ConstituencyTesting.Helper;
using ConstituencyTesting.Dependencies;
using TestedClass = Assignment_2.ConstituencyList;

namespace ConstituencyTesting
{
    [TestClass]
    public class TestFixture_ConstituencyList
    {
        [TestMethod]
        public void Test_ConstituencyList_Class_Conts0_ConstituencyList()
        {
            var testedClass = new TestedClass();

            var actualConstituencyList = testedClass.constituencyList.Count;

            Assert.AreEqual(0, actualConstituencyList);
        }
    }
}
