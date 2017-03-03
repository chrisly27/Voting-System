using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Constituency
    {
        public String constituencyName { get; set; }
        public Candidate candidateElected;
        public CandidateList candidateList { get; set; }
        public Constituency(String constituencyName)
        {
            this.constituencyName = constituencyName;
        }
        public override string ToString()
        {
            return constituencyName;
        }
    }
}
