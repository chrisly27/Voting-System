using System;
using System.Threading;

namespace Assignment_2
{
    //the producer class runs on its own thread and continues to run until instructed to finish
    public class Producer
    {
        private static int runningThreads = 0; //class wide count of producer threads that are running
        private static object locker = new object(); //used for MUTES control of static properties
        private const int duration = 1000; //simulates the time taken to produce a work item (in milliseconds)
        private string id; //identifier for this producer
        public Thread T { get; private set; } //thread upon which this instance of a producer runss
        private bool finished; //Flag to control if this producer has finished or if it should continue to produce
        private PCQueue pcQueue; //share PCQueue that this producer is producing work items for
        private ConfigData configFile; //configuration data (details of datasets to be processed)
        private IConstituencyFileReader IOhandler; //file handler for reading data

        public static int RunningThreads //property getter/setter methods
        {
            get { return runningThreads; }
            private set
            {
                lock(locker)
                {
                    //MUTEX control for potential multiple thread access to this property
                    runningThreads = value;
                }
            }
        }

        public bool Finished //property getter/setter methods
        {
            get { return finished; }
            set
            {
                lock(this)
                {
                    //MUTEX control for potential multiple thread access to this property
                    finished = value;
                }
            }
        }

        public Producer(string id, PCQueue pcQueue, ConfigData configFile, IConstituencyFileReader IOhandler)
        {
            this.id = id;
            finished = false; //initially not finished
            this.pcQueue = pcQueue;
            //counter = 0; // initial value for the work item counter
            this.configFile = configFile;
            this.IOhandler = IOhandler;
            (T = new Thread(run)).Start(); //create a new thread for this producer and get it started
            RunningThreads++; //increment the number of running producer threads
        }


        //thread code for the producer
        public void run()
        {
            ConfigRecord configRecord = null;

            //while not finished, generate a new work item and enqueue it on the PCQueue, output that
            //this producer has produced a new item (and what it is called)
            while(!Finished)
            {
                //lock configuration file and obtain next filename to process
                //if there are no filenames left then set filename to null so that nothing is produced
                lock(configFile)
                {
                    if(configFile.NextRecord < configFile.configRecords.Count)
                    {
                        configRecord = configFile.configRecords[configFile.NextRecord++];
                    }
                    else
                    {
                        configRecord = null;
                    }
                }

                //only queue item if there is a config record to read
                if(configRecord != null)
                {
                    //enqueue a new work item, increment the counter as this work is produced
                    pcQueue.enqueueItem(new Work(configRecord, IOhandler));
                }

                //simulate producer activity running for duration milliseconds
                Thread.Sleep(duration);
            }

            //decrement the number of running producer threas
            RunningThreads--;
        }
    }
}
