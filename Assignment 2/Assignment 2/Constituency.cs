using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Constituency
    {
        public String ConstituencyID { get; set; }
        public String ConstituencyName { get; set; }
        public List<Candidate> candidateList { get; set; }
        public String CandidateName { get; set; }
        public PartyList partylist { get; set; }

        public Constituency(String ConstituencyID)
        {
            this.ConstituencyID = ConstituencyID;
            this.ConstituencyName = ConstituencyName;
            candidateList = new List<Candidate>();
            this.partylist = null;
        }

        public List<Candidate> displayCandidates()
        {
            return candidateList;
        }

        public override string ToString()
        {
            return ConstituencyID;
        }
    }
}
