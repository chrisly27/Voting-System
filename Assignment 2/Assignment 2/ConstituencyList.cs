using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class ConstituencyList
    {
        public List<Constituency> constituencyList { get; set; }

        public ConstituencyList()
        {
            constituencyList = new List<Constituency>();
        }

        public List<Constituency> ListOfConstituencyNames()
        {
            return constituencyList;
        }

        public List<Candidate> CalcVotes(string name)
        {
            var calc = from v in constituencyList
                      from mv in v.candidateList
                      orderby mv.votes descending
                      where v.ConstituencyID == name
                      select mv;

            return calc.ToList();
        }

        public List<Party> partylist()
        {
            var list = from m in constituencyList
                       from a in m.partylist.partyList
                       group a by a.partyName into p
                       let v = (from m in p select m.votes).Sum()
                       select new Party(p.Key, v);
            return list.ToList();
        }
    }
}
