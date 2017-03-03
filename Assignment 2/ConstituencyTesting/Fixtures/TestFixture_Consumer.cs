using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using Assignment_2;
using ConstituencyTesting.Dependencies;
using TestedClass = Assignment_2.Consumer;

namespace ConstituencyTesting.Fixtures
{
    [TestClass]
    public class TestFixture_Consumer
    {
        TestedClass testedClass = null;
        ProgressManager progressManager = null;
        ConstituencyList constituencyList = null;
        PCQueue pcQueue = null;

        [TestCleanup]
        public void TestsCleanup()
        {
            testedClass = null;
            progressManager = null;
            constituencyList = null;
            pcQueue = null;
        }

        [TestMethod]
        public void Test_One_Thread_Created()
        {
            // Arrange
            progressManager = new ProgressManager();
            constituencyList = new ConstituencyList();
            testedClass = new TestedClass("Consumer", pcQueue, constituencyList, progressManager);
            var expectedThreadCount = 1;

            Thread.Sleep(5000);

            var actualThreadCount = TestedClass.RunningThreads;

            testedClass.Finished = true;

            Thread.Sleep(1000);

            // Assert
            Assert.AreEqual(expectedThreadCount, actualThreadCount);

        }

        [TestMethod]
        public void Test_Run_Method_Constituencies_Created_Equals_Progress_Manager_Accesses()
        {
            // Arrange
            progressManager = new ProgressManager();
            constituencyList = new ConstituencyList();
            testedClass = new TestedClass("Consumer", pcQueue, constituencyList, progressManager);

            Thread.Sleep(5000);

            testedClass.Finished = true;

            Thread.Sleep(1000);

            Assert.AreEqual(Math.Abs(progressManager.ItemRemaining), constituencyList.constituencyList.Count);
        }

        [TestMethod]
        public void Test_Run_Method_Null_Dequeued_Expect_No_ProgressManager_Accesses()
        {
            // Arrange
            progressManager = new ProgressManager();
            constituencyList = new ConstituencyList();
            testedClass = new TestedClass("Consumer", pcQueue, constituencyList, progressManager);

            Thread.Sleep(5000);

            // Signal Consumer thread to finish
            testedClass.Finished = true;

            Thread.Sleep(1000);

            // Assert 
            // There should be no access of the ProgressManager
            Assert.AreEqual(0, Math.Abs(progressManager.ItemRemaining));
        }

        [TestMethod]
        public void Test_Run_Method_Null_Dequeued_Expect_No_Constituencies()
        {
            // Arrange
            progressManager = new ProgressManager();
            constituencyList = new ConstituencyList();
            testedClass = new TestedClass("Consumer", pcQueue, constituencyList, progressManager);

            Thread.Sleep(5000);

            // Signal Consumer thread to finish
            testedClass.Finished = true;

            // Allow a short period of time for the Consumer to finish
            Thread.Sleep(1000);

            // Assert
            // There should be no constituencies added to the constituency list
            Assert.AreEqual(0, constituencyList.constituencyList.Count);
        }
    }
}
