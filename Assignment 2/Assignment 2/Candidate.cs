using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Candidate
    {
        public String Firstname { get; set; }
        public String Surname { get; set; }
        public String party { get; set; }
        public String votes { get; set; }

        public Candidate(String Firstname, String Surname, String votes, String party)
        {
            this.Firstname = Firstname;
            this.Surname = Surname;
            this.votes = votes;
            this.party = party;
        }

        public string getFirst()
        {
            return Firstname;
        }
        public string getSurname()
        {
            return Surname;
        }
        public string getVotes()
        {
            return votes;
        }


        public override string ToString()
        {
            return "Fullname: " + Firstname + " " + Surname + "\n\t Votes: " + votes + "\n\t\n\t - Party Name: " + party;
        }
    }
}
