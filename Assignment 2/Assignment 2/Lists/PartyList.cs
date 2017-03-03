using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class PartyList
    {
        public List<Party> partyList;
        public PartyList()
        {
            partyList = new List<Party>();
        }
        public override string ToString()
        {
            String str = "Parties: " + Environment.NewLine;
            foreach (Party party in partyList)
            {
                str += party.ToString() + Environment.NewLine;
            }
            return str;
        }
        public void CalcVotes(Party party)
        {
            bool calc = false;
            for (int i = 0; i < partyList.Count; i++)
            {
                if (partyList[i].partyName == party.partyName)
                {
                    partyList[i].CalcVotes(party.votes);
                    calc = true;
                }
            }
            if (calc == false)
            {
                partyList.Add(party);
            }
            partyList = partyList.OrderByDescending(o => o.votes).ToList();
        }
    }
}
