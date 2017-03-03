using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_2;

namespace ConstituencyTesting.Dependencies
{
    class PCQueueNullDequeued : IPCQueue
    {
        public void enqueueItem(Work item)
        {
        }

        public Work dequeueItem()
        {
            return null;
        }
    }
}
