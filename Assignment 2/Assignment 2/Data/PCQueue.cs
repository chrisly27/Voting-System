using System;
using System.Collections.Generic;
using System.Threading;

namespace Assignment_2
{
    public class PCQueue
    {
        private Queue<Work> queue = new Queue<Work>(); //embedded queue collection to hold work items
        public int Capacity { get; private set; } //maximum number of work items allowed on the queue,
                                                  //or 0 to have an unbounded queue size
        public bool Active { get; set; } //only allows enqueue and dequeue of work items when active
        public PCQueue()
        {
            //default to an unbounded queue size, so capacity = 0
            Capacity = 0;
            Active = true;
        }
        public PCQueue(int capacity)
        {
            //set a bounded queue size = capacity, or an unbounded queue size if capacity is passed in ac < 1
            this.Capacity = Math.Max(capacity, 0); //ie. cannot be a negative capacity
            Active = true;
        }
        public void enqueueItem(Work item)
        {
            //use this instance of the PCQueue as the locking objec for the concurrency related critical regions
            //and thread synchronisation
            lock(this)
            {
                //while this PCQueue is active and full, wait (remember a capacity = 0 means never full)
                while(Active && (Capacity != 0) && (queue.Count == Capacity))
                {
                    Monitor.Wait(this);
                }
                //if this PCQueue is active it now has space for a work item so enqueue it
                if(Active)
                {
                    queue.Enqueue(item);

                    //use pulse to inform that the queue is now not empty
                    Monitor.Pulse(this);
                }
            }
        }
        public Work dequeueItem()
        {
            Work item = null;

            //use this instance of the PCQueue as the locking object for the concurrency related critical regions
            //and thread synchronisation
            lock(this)
            {
                //while this PCQueue is active and empty, wait
                while(Active && (queue.Count == 0))
                {
                    Monitor.Wait(this);
                }

                //if this PCQueue is active it now has a work item so dequeue a work item and return its reference
                //or return null if the PCQueue is not active
                if(Active)
                {
                    item = queue.Dequeue();

                    //use pulse to inform that the queue is now not full
                    Monitor.Pulse(this);
                }
            }
            return item;
        }
    }
}
