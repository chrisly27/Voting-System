using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
   public class CandidateList
    {
        public List<Candidate> candidates { get; set; }

        public CandidateList()
        {
            candidates = new List<Candidate>();
        }
    }
}
