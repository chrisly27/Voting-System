using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Assignment_2
{
    public class XMLPartyReader : IPartyDataReader
    {
        public List<Party> ReadPartyData(ConfigRecord configRecord)
        {
            if (!File.Exists(configRecord.Filename))
            {
                return null;
            }
            XDocument xmlDoc = XDocument.Load(configRecord.Filename);

            var partyNames = from candi in xmlDoc.Descendants("Candidate")
                             from votes in candi.Descendants("Votes")
                             select new Party(candi.Attribute("party").Value, (int)votes);

            return partyNames.ToList();
        }
    }
}
