using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_2;
using ConstituencyTesting.Dependencies;
using ConstituencyTesting.Helper;
using TestedClass = Assignment_2.PartyList;

namespace ConstituencyTesting.Fixtures
{
    [TestClass]
    public class TestFixture_PartyList
    {
        [TestMethod]
        public void Test_AddVotes_Method_Compare_TotalVotes()
        {
            // Arrange
            // Instantiate Constituency object and XmlPartyReader
            var testedClass = new TestedClass();
            var partyReader = new XMLPartyReader();

            // act
            var sunderlandPartyList = partyReader.ReadPartyData(new ConfigRecord("Sunderland.xml"));
            var newcastlePartyList = partyReader.ReadPartyData(new ConfigRecord("Newcastle.xml"));

            // Add the sunderland votes
            foreach (var p in sunderlandPartyList)
            {
                testedClass.CalcVotes(p);
            }

            // Add the Newcastle votes
            foreach (var p in newcastlePartyList)
            {
                testedClass.CalcVotes(p);
            }

            // Assert
            // iterate
            foreach (var party in testedClass.partyList)
            {
                string name = party.partyName;
                switch (name)
                {
                    case "Conservative":
                        Assert.AreEqual(party.votes, 194);
                        break;
                    case "Green":
                        Assert.AreEqual(party.votes, 385);
                        break;
                    case "Freedon":
                        Assert.AreEqual(party.votes, 370);
                        break;

                }
            }
        }
    }
}
