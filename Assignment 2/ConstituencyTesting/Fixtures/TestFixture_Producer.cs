using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using Assignment_2;
using ConstituencyTesting.Dependencies;
using TestedClass = Assignment_2.Producer;

namespace ConstituencyTesting.Fixtures
{
    [TestClass]
    public class TestFixture_Producer
    {
        TestedClass testedClass = null;
        ConfigData configData = null;
        PCQueueCallEnqueueItem pcQueue = null;

        [TestCleanup]
        public void TestsCleanup()
        {
            testedClass = null;
            configData = null;
            pcQueue = null;
        }

        [TestMethod]
        public void Test_One_Thread_Created()
        {
            // Arrange
            pcQueue = new PCQueueCallEnqueueItem();

            configData = new ConfigData();
            //testedClass = new TestedClass("Producer", pcQueue, configData, null);
            var expectedThreadCount = 1;

            // Act
            // WAit a few seconds to allow Producer thread to start up
            Thread.Sleep(5000);

            var actualThreadCount = TestedClass.RunningThreads;

            // Signal Producer thread to finish
            testedClass.Finished = true;

            Thread.Sleep(1000);

            // Assert
            Assert.AreEqual(expectedThreadCount, actualThreadCount);
        }

        [TestMethod]
        public void Test_Run_Method_PCQueue_EnqueueItem_Never_Called()
        {
            Helper_Assert(Helper_Arrange(0), Helper_Act());
        }

        [TestMethod]
        public void Test_Run_Method_PCQueue_EnqueueItem_Called_Once()
        {
            // Use the helper methods to run the test
            Helper_Assert(Helper_Arrange(1), Helper_Act());
        }

        [TestMethod]
        public void Test_Run_Method_PCQueue_EnqueueItem_Called_Ten_Times()
        {
            // Use the helper methods to run the test
            Helper_Assert(Helper_Arrange(10), Helper_Act());
        }

        private int Helper_Arrange(int configRecordsCount)
        {
            // Instantiate a new PCQueue object
            pcQueue = new PCQueueCallEnqueueItem();

            // Instantiate a new ConfigData object
            configData = new ConfigData();

            // Add ConfigRecord instances to ConfigData object's config records list 
            for (int i = 0; i < configRecordsCount; i++)
            {
                configData.configRecords.Add(new ConfigRecord("NeverUsed"));
            }

            //testedClass = new TestedClass("PRODUCER", pcQueue, configData, null);
            return configRecordsCount;
        }

        private int Helper_Act()
        {
            // Wait a few seconds to allow Producer thread to start up and execute its Run() method
            Thread.Sleep(5000);

            testedClass.Finished = true;

            // Allow a short period of time for the Producer to finish
            Thread.Sleep(1000);

            // Return the actual number of calls to the PCQueue's EnqueueItem method
            return pcQueue.EnqueueItemCallCount;
        }
        private void Helper_Assert(int expected, int actual)
        {
            Assert.AreEqual(expected, actual);
        }

    }
}
