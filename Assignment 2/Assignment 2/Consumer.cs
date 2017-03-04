using System;
using System.Threading;

namespace Assignment_2
{
    class Consumer
    {
        private static int runningThreads = 0; //class wide count of consumer threads that are running
        private static object locker = new object(); //used for MUTEx control of static properties
        private const int duration = 1000; //similates the time taken to consume a work item (in milliseconds)

        private string id; //identifier for this consumer
        public Thread T { get; private set; } //Thread upon which this instance of a consumer runs
        private bool finished; //flag to control if this consumer has finished or if it should continued to consumer
        private PCQueue pcQueue; //share PCQueue that this consumer is consuming work items from

        private ConstituencyList constList; //list of constituency wich will be added to

        private PartyList ptList;

        private ProgressManager progManager;

        public static int RunningThreads //property getter/setter methods
        {
            get { return runningThreads; }
            private set
            {
                lock (locker)
                {
                    // MUTEX control for potential multiple thread access to this property
                    runningThreads = value;
                }
            }
        }

        public bool Finished //property getter/setter methods
        {
            get { return finished; }
            set
            {
                lock (this)
                {
                    // MUTEX control for potential multiple thread access to the finished flag
                    finished = value;
                }
            }
        }

        public Consumer(string id, PCQueue pcQueue, ConstituencyList constList, PartyList ptList, ProgressManager progManager)
        {
            this.id = id;
            finished = false; //initially not finished
            this.pcQueue = pcQueue;
            this.constList = constList;
            this.ptList = ptList;
            this.progManager = progManager;
            (T = new Thread(run)).Start(); //create a new thread for this consumer and get id it started
            RunningThreads++; //increment the number of running consumer threads;
        }

        //thread code for the consumer
        public void run()
        {
            //while not finished, dequeue a work item from the PCQueue and consumer this work item nu invoking
            //its ReadData() method and then outputting to the console a message to show this has happened
            while (!Finished)
            {
                //Dwqueue a work item
                var item = pcQueue.dequeueItem();

                if(!ReferenceEquals(null, item))
                {
                    //invoke the word item's ReadData() method, which returns a constituency
                    Constituency constituency = item.ReadConstituencyData();
                    Candidate candidate = item.ReadCandidateData();

                    //Ensure null reyurns are ignored (will happen if data not in correct format or can't open teh file)
                    if (!ReferenceEquals(null, candidate))
                    {
                        //add this constituency to the constituency list (lock if while modifying)
                        lock (constituency.candidateList)
                        {
                            constituency.candidateList.Add(candidate);
                        }
                    }

                    if (!ReferenceEquals(null, constituency))
                    {
                        //add the constituency to the constituency list (lock it while modifying)
                        lock (constList)
                        {
                            constList.constituencyList.Add(constituency);
                        }
                    }

                    //similated consumer activity running for duration millisecons
                    Thread.Sleep(duration);

                    progManager.itemsRemaining--;
                }
            }

            //decrement the number of runninf consumer threads 
            RunningThreads--;
        }
    }
}
