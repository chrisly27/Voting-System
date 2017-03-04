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
        Constituency constituency;
        Party party;
        public Constituency ReadConstituencyDataFromFile(ConfigRecord configRecord)
        {
            //open the file to read from on the local file system.
            //if this file is missing then return immediately from this method

            if(!File.Exists(configRecord.Filename))
            {
                //cannot open the file as it does not exist for whatever reason, so return immediately
                return null;
            }

            //opem file and load into memory as XML
            XDocument xmlDoc = XDocument.Load(configRecord.Filename);

            //create constituency (should onlu be one in file but retrieve first to be sure)
            var constituencyName = xmlDoc.Root.Element("Constituency").Attribute("name").Value;

            constituency = new Constituency(constituencyName);


            constituency.partylist = new PartyList();

            var list = from p in xmlDoc.Descendants("Candidate")
                       from v in xmlDoc.Descendants("Votes")
                       select new Party(p.Attribute("party").Value , Convert.ToInt32(v.Value));
            constituency.partylist.partyList = list.ToList();

            constituency.partylist.partyList = list.ToList();

            return constituency;
        }


        public Candidate ReadCandidateDataFromFile(ConfigRecord configRecord)
        {
            if (!File.Exists(configRecord.Filename))
            {
                return null;
            }

            //open file and load into memory as xml
            XDocument xmlDoc = XDocument.Load(configRecord.Filename);

            var candidateName = from candName in xmlDoc.Descendants("Candidate")
                                select new
                                {
                                    Party = (string)candName.Attribute("party").Value,
                                    Firstname = (string)candName.Element("Firstname"),
                                    Surname = (string)candName.Element("Surname"),
                                    Votes = (string)candName.Element("Votes")
                                };

            Candidate candidate = null;

            foreach (var details in candidateName)
            {
                candidate = new Candidate(details.Firstname, details.Surname, details.Votes, details.Party);
                constituency.candidateList.Add(candidate);
            }

            return candidate;
        }
    }
}
