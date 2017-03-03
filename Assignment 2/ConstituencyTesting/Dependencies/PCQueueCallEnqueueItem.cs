using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_2;

namespace ConstituencyTesting.Dependencies
{
    [TestClass]
    public class PCQueueCallEnqueueItem : IPCQueue
    {
        public int EnqueueItemCallCount { get; private set; }
        public PCQueueCallEnqueueItem()
        {
            EnqueueItemCallCount = 0;
        }

        public void enqueueItem(Work item)
        {
            EnqueueItemCallCount++;
        }

        public Work dequeueItem()
        {
            return null;
        }
    }
}
