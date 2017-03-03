using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Candidate
    {
        public String Fullname { get; set; }
        public String party { get; set; }
        public int votes { get; set; }
        private String constituencyName;
        public Candidate(String Fullname, int votes, String party, String constituencyName)
        {
            this.Fullname = Fullname;
            this.votes = votes;
            this.party = party;
            this.constituencyName = constituencyName;
        }
        public override string ToString()
        {
            return Fullname;
        }
        public string DisplayCandidatesDetails()
        {
            return String.Format("Constituency:{0,10}\nParty:{1,10}\nVotes:{2,10}", constituencyName, party, votes);
        }
    }
}
