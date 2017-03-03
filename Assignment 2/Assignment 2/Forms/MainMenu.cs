using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Assignment_2
{
    public partial class MainMenu : Form, IUserInterface
    {
        private ConfigData configData;
        private ConstituencyList constituencyList;
        XMLConstituencyFileReader IOhandler = new XMLConstituencyFileReader();
        XMLPartyReader partyHand = new XMLPartyReader();
        PartyList partyList = new PartyList();
        public MainMenu()
        {
            InitializeComponent();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
        }
        private void btnConfigData_Click(object sender, EventArgs e)
        {
            //new instance of a configdata
            configData = new ConfigData();

            //opening a file to add data into system
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "XML Files (.xml)|*.xml";
            //openFile.FilterIndex = 1;
            openFile.Multiselect = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                foreach (var filename in openFile.FileNames)
                {
                    configData.configRecords.Add(new ConfigRecord(filename));
                }
            }


            RunProducerConsumer();
            LoadAllPartyData();
        }

        public void LoadAllPartyData()
        {
            foreach (var configRecord in configData.configRecords)
            {
                var par = partyHand.ReadPartyData(configRecord);
                foreach (var part in par)
                {
                    partyList.CalcVotes(part);
                }
            }
        }
        public void RunProducerConsumer()
        {
            //create constituency list to hold individual constituency objects read from datasets
            constituencyList = new ConstituencyList();

            //create progress manager with number of files to process
            ProgressManager progManager = new ProgressManager(configData.configRecords.Count);

            //create a PCQueue instance, give it a capacity of 4
            var pcQueue = new PCQueue(4);

            //create 2 Producer instances and 2 Consumer instances, these will begin executing on
            //their respective threads as soon as they are instantiated 
            Producer[] producers = { new Producer("P1", pcQueue, configData, IOhandler) ,
                                     new Producer("P2", pcQueue, configData, IOhandler) };

            Consumer[] consumers = { new Consumer("C1", pcQueue, constituencyList, progManager),
                                     new Consumer("C2", pcQueue, constituencyList, progManager) };

            // Keep producing and consuming until all work items are completed
            while (progManager.ItemRemaining > 0) ;

            //deactivate the PCQueue so it does not prevent waiting producer and/or consumer threads
            //from completing
            pcQueue.Active = false;

            //iterate through producers and signal them to finish
            foreach (var p in producers)
            {
                p.Finished = true;
            }

            //iterate through consumers and signal them to finish
            foreach (var c in consumers)
            {
                c.Finished = true;
            }

            //we need to ensure that no thread waiting on Monitor.Wait() is stranded with
            //no Monitor.Pulse() now possible since all producer and consumer threads have
            //been signalled to stop, in the worse case all such threads could be stranded
            //so pulse that many times to ensure enough pulses are made available (or the
            //program can halt erroneously), wasted pulse are simply ignored 
            for (int i = 0; i < (Producer.RunningThreads + Consumer.RunningThreads); i++)
            {
                lock (pcQueue)
                {
                    //pulse the PCQueue to signal any waiting threads
                    Monitor.Pulse(pcQueue);

                    //give a short break to the main thread so the pulses have time to be
                    //detected by any potentially waiting producer and/or consumer threads
                    Thread.Sleep(100);
                }
            }

            //once all producer and consumer threads have finally finished we can gracefully
            //shutdown the main thread, this is achieved by spinning on a while() loop until
            //there are no running threads, in this case we do not mind the main thread
            //spinning as we are about to shutdown the program
            while ((Producer.RunningThreads > 0) || (Consumer.RunningThreads > 0)) ; //wait by spinning
        }

        private void btnLoadConstituencyData_Click(object sender, EventArgs e)
        {
            //display the constituency form 
            DisplayConstituency constForm = new DisplayConstituency(IOhandler, constituencyList);

            //open de form
            while (constForm.ShowDialog() != DialogResult.OK) ;
        }
        private void btnAllParty_Click(object sender, EventArgs e)
        {
            DisplayPartyForm party = new DisplayPartyForm(partyList);
            while (party.ShowDialog() != DialogResult.OK) ;
        }
        private void btnDisplayElectedCandi_Click(object sender, EventArgs e)
        {
            DisplayElectedCandidatesForm elected = new DisplayElectedCandidatesForm(constituencyList);

            while (elected.ShowDialog() != DialogResult.OK) ;

        }
        private void btnWinner_Click(object sender, EventArgs e)
        {
            DisplayWinner win = new DisplayWinner(partyList);
            while (win.ShowDialog() != DialogResult.OK) ;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
