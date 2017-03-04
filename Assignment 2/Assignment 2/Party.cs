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

        public string getPartyName()
        {
            return partyName;
        }
        public override String ToString()
        {
            return partyName + " " + votes;
        }
    }
}
