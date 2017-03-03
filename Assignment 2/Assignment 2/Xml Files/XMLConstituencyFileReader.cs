using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Assignment_2
{
    public class XMLConstituencyFileReader : IConstituencyFileReader
    {
        //Constituency constituency;
        public Constituency ReadConstituencyDataFromFile(ConfigRecord configRecord)
        {
            //open the file to read from on the local file system.
            //if this file is missing then return immediately from this method
            if(!File.Exists(configRecord.Filename))
            {
                //cannot open the file as it does not exist for whatever reason, so return immediately
                return null;
            }
            //open file and load into memory as XML
            XDocument xmlDoc = XDocument.Load(configRecord.Filename);
            try
            {
                var constituencyName = (from c in xmlDoc.Descendants("Constituency")
                                        select c.Attribute("name").Value).First();
                Constituency constituency = new Constituency(constituencyName);
                constituency.candidateList = new CandidateList();
                constituency.candidateList.candidateDetails = SelecCandidates(xmlDoc, constituencyName);
                constituency.candidateElected = ElectedCandidateOverall(xmlDoc, constituencyName);

                return constituency;
            }
            catch
            {
                return null;
            }
        }

        private List<Candidate> SelecCandidates(XDocument xmlDoc, String constituencyName)
        {
            var candName = from candidate in xmlDoc.Descendants("Candidate")
                           from firstname in candidate.Descendants("Firstname")
                           from surname in candidate.Descendants("Surname")
                           from votes in candidate.Descendants("Votes")
                           select new Candidate(firstname.Value + " " + surname.Value,
                                                (int)votes, candidate.Attribute("party").Value,
                                                constituencyName);
            return candName.ToList();
        }

        private Candidate ElectedCandidateOverall(XDocument xmlDoc, String constituencyName)
        {
            var candName = (from candidate in xmlDoc.Descendants("Candidate")
                            from firtsname in candidate.Descendants("Firstname")
                            from surname in candidate.Descendants("Surname")
                            from votes in candidate.Descendants("Votes")
                            orderby int.Parse(votes.Value) descending
                            select new Candidate(firtsname.Value + " " + surname.Value,
                                                 (int)votes, candidate.Attribute("party").Value,
                                                 constituencyName)).First();

            return (Candidate)candName;
        }
    }
}
