using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class PartyList
    {
        public List<Party> partyList { get; set; }

        public PartyList()
        {
            partyList = new List<Party>();
        }

        public List<Party> ListOfPartyNames()
        {
            return partyList;
        }
    }
}
