using System;

namespace Assignment_2
{
    public class Work
    {
        public ConfigRecord configRecord { get; private set; } //data used when this work is processed - config record
        private IConstituencyFileReader IOhandler;
        public Constituency constituency { get; private set; } //result of the work, when null indicates that the work has
                                                               //not yet been completed, note this is a read-only property
        public Party party { get; private set; }
        public Work(ConfigRecord data, IConstituencyFileReader IOhandler) //extra param for IConstitcuencyIO
        {
            constituency = null; //result of the work is initially null, this shows that the work has yet been completed
            this.configRecord = data; //data is initialised with the work is instantiated
            this.IOhandler = IOhandler;
        }
        public Constituency ReadConstituencyData()
        {
            //reads the specified file and extracts the constituency data from it to store in a constituency object.
            //note that result remains null until this method is executed
            return IOhandler.ReadConstituencyDataFromFile(configRecord);
        }
        //public Party ReadPartyData()
        //{
        //    return IOhandler.ReadPartyDataFromFile(configRecord);
        //}
        public Candidate ReadCandidateData()
        {
            return IOhandler.ReadCandidateDataFromFile(configRecord);
        }
    }
}
