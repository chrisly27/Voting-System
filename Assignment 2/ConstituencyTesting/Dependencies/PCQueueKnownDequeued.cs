using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_2;

namespace ConstituencyTesting.Dependencies
{
    public class PCQueueKnownDequeued : IPCQueue
    {
        public void enqueueItem(Work item)
        {
        }

        public Work dequeueItem()
        {
            var work = new Work(new ConfigRecord("Sunderland.xml"), new ConstituencyFileReader());
            return work;
        }
    }
}
