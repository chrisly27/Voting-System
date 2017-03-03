using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Party
    {
        public String partyName { get; set; }
        public int votes { get; set; }
        public Party(String partyName, int votes)
        {
            this.partyName = partyName;
            this.votes = votes;
        }
        public void CalcVotes(int votes)
        {
            votes += votes;
        }
        public override string ToString()
        {
            return String.Format("{0, -20}{1,25}", partyName, votes + "votes");
        }
    }
}
