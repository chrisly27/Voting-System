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
using System.Xml.Linq;

namespace Assignment_2
{
    public partial class FormsBasedUI : Form, IUserInterface
    {

        public IConstituencyFileReader IOhandler { get; set; }
        private ConfigData configData;
        private ConstituencyList constituencyList;
        private PartyList ptList;

        private String selectedReport;

        public FormsBasedUI(IConstituencyFileReader IOhandler)
        {
            InitializeComponent();
            this.IOhandler = IOhandler;
        }

        private void FormsBasedUI_Load(object sender, EventArgs e)
        {
            btnconfig.Enabled = true;
            btnLoadConstituencyData.Enabled = false;
            btnShowAllConstituencyNameOnly.Enabled = false;
            btnShowAllCandidateDetails.Enabled = false;
            btnShowAllPartyNames.Enabled = false;
            btnShowHighestElectedCandidate.Enabled = false;
        }

        public void SetupConfigData()
        {
            //make sure configData is a new empty object
            configData = new ConfigData();

            //generate confguration data (filename and required finalReport for each constituency)
            configData.configRecords.Add(new ConfigRecord("Constituency_01.xml"));
            configData.configRecords.Add(new ConfigRecord("Constituency_02.xml"));
            configData.configRecords.Add(new ConfigRecord("Constituency_03.xml"));
            configData.configRecords.Add(new ConfigRecord("Constituency_04.xml"));
            configData.configRecords.Add(new ConfigRecord("Constituency_05.xml"));


            //OpenFileDialog openFile = new OpenFileDialog();
            //openFile.Filter = "XML Files (.xml)|*.xml";
            //openFile.FilterIndex = 1;
            //openFile.Multiselect = true;

            //if (openFile.ShowDialog() == DialogResult.OK)
            //{
            //    foreach (string filename in openFile.FileName)
            //    {
            //        configData.configRecords.Add(new ConfigRecord(filename));
            //    }
            //}


        }

        public void RunProducerConsumer()
        {
            //create constituency list to hold individual constituency objects read from datasets
            constituencyList = new ConstituencyList();
            ptList = new PartyList();

            //create progress manager with number of files to process
            ProgressManager progManager = new ProgressManager(configData.configRecords.Count);

            //output message to indicate that the program has started
            lblProgress.Text = "Creating and starting all producers and consumers";

            //create a PCQueue instance, give it a capacity of 5
            var pcQueue = new PCQueue(4);

            //create 2 Producer instances and 2 Consumer instances, these will begin executing on
            //their respective threads as soon as they are instantiated 
            Producer[] producers = { new Producer("P1", pcQueue, configData, IOhandler),
                                     new Producer("P2", pcQueue, configData, IOhandler) };

            Consumer[] consumers = { new Consumer("C1", pcQueue, constituencyList, ptList, progManager),
                                     new Consumer("C2", pcQueue, constituencyList, ptList, progManager) };

            // Keep producing and consuming until all work items are completed
            while (progManager.ItemRemaining > 0) ;

            //outout message to indicate that the program is shutting down
            lblProgress.Text = "Shutting down all producers and consumers";

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

            lblProgress.Text = "All producers and consumers shut down";
        }

        private void btnconfig_Click(object sender, EventArgs e)
        {
            //clear any item in the box
            lbxShowConstituencyNames.Items.Clear();

            SetupConfigData();

            //update form object properties
            lblProgress.Text = "Config data loaded. Waiting for user to press load";
            btnLoadConstituencyData.Enabled = true;
            btnShowAllConstituencyNameOnly.Enabled = false;
            btnShowAllCandidateDetails.Enabled = false;
            btnShowAllPartyNames.Enabled = false;
            btnShowHighestElectedCandidate.Enabled = false;
        }

        private void btnRunProducerConsumer_Click(object sender, EventArgs e)
        {
            //clear any item in the box
            lbxShowConstituencyNames.Items.Clear();

            lblProgress.Text = "obtaining Constituency data. Please Wait...";
            lblProgress.Refresh();

            //run producer consumer to load constituency data
            RunProducerConsumer();

            //update form object properties
            lblProgress.Text = "Constituency datat loaded. \nClick in Button Below to see the Constituency.";
            btnconfig.Enabled = false;
            btnLoadConstituencyData.Enabled = false;
            btnShowAllConstituencyNameOnly.Enabled = true;
            btnShowAllCandidateDetails.Enabled = true;
            btnShowAllPartyNames.Enabled = true;
            btnShowHighestElectedCandidate.Enabled = true;
        }

        private void btnFinalResult_Click(object sender, EventArgs e)
        {
            lblProgress.Text = "List of All Constituency in left box below.";
            DisplayConstituency();
        }

        private void lbxDisplayResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxShowAllCandidateDetails.Items.Clear();

            string b = lbxShowConstituencyNames.SelectedItem.ToString();

            foreach (var c in candlist(b))
            {
                lbxShowAllCandidateDetails.Items.Add(c);
            }
            
        }

        public List<Candidate> candlist(string f)
        {
            var n = from v in constituencyList.constituencyList
                    from m in v.candidateList
                    where v.ConstituencyID == f
                    select new Candidate(m.Firstname, m.Surname, m.votes, m.party);
            return n.ToList();
        }


        //display all the constituency name in the xml files
        public void DisplayConstituency()
        {
            //clear any item in the box
            lbxShowConstituencyNames.Items.Clear();

            foreach (var consti in constituencyList.constituencyList)
            {
                lbxShowConstituencyNames.Items.Add(consti);
            }
        }

        public void DisplayTheHighestElectedCandidate()
        {
            lbxShowHighestElectedCandidate.Items.Clear();

            foreach (var list in constituencyList.ListOfConstituencyNames())
            {
                lbxShowHighestElectedCandidate.Items.Add(list);
                var calcMax = constituencyList.CalcVotes(list.ConstituencyID).First();
                lbxShowHighestElectedCandidate.Items.Add(calcMax);
            }
        }

        public void DisplayAllCandidateData()
        {

            lbxShowAllCandidateDetails.Items.Clear();

            foreach (var list in constituencyList.ListOfConstituencyNames())
            {
                lbxShowAllCandidateDetails.Items.Add(list);

                foreach (var ln in list.candidateList)
                {
                    lbxShowAllCandidateDetails.Items.Add(ln);
                }
            }
        }

        private void btnShowAllTheCandidateDetails_Click(object sender, EventArgs e)
        {
            DisplayAllCandidateData();
        }

        private void btnShowHighestElectedCandidate_Click(object sender, EventArgs e)
        {
            DisplayTheHighestElectedCandidate();
        }

        private void btnShowAllPartyNames_Click(object sender, EventArgs e)
        {
            lbxShowPartyNames.Items.Clear();

            foreach (var n in constituencyList.partylist())
            {
                lbxShowPartyNames.Items.Add(n);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
