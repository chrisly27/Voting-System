using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConstituencyTesting.Dependencies;
using ConstituencyTesting.Helper;
using TestedClass = Assignment_2.Work;

namespace ConstituencyTesting.Fixtures
{
    [TestClass]
    public class TestFixture_Work
    {
        [TestMethod]
        public void Test_ReadData_Method_Correct_Constituency_Returned()
        {

            var ioHandler = new ConstituencyFileReader();

            // Instantiate a Work object
            var testedClass = new TestedClass(null, ioHandler);

            // Use the helper class to get known Sunderland constituency instance
            var expectedConstituency = Helper_KnownConstituencyData.GetKnownSunderland();

            var actualConstituency = testedClass.ReadConstituencyData();

            // Assert
            // Check each property of the expected and actual constituency instances to make sure they contain the same data,
            // note here that it would be a good idea to give the candidate list class a way to check its value equality
            // with another candudatelist object via the overriding of its Equals() method

            // First check Constituency Name property
            Assert.AreEqual(expectedConstituency.constituencyName, actualConstituency.constituencyName);

            // Next check the lengths of the candidate list
            Assert.AreEqual(expectedConstituency.candidateList.candidateDetails.Count, actualConstituency.candidateList.candidateDetails.Count);

            // Check the candidate winner of the constituency
            Assert.AreEqual(expectedConstituency.candidateElected.Fullname, actualConstituency.candidateElected.Fullname);
            Assert.AreEqual(expectedConstituency.candidateElected.party, actualConstituency.candidateElected.party);
            Assert.AreEqual(expectedConstituency.candidateElected.votes, actualConstituency.candidateElected.votes);

            // Now iterate through the candidate list and check for data equality
            for (var i = 0; i < expectedConstituency.candidateList.candidateDetails.Count; i++)
            {
                Assert.AreEqual(expectedConstituency.candidateList.candidateDetails[i].Fullname, actualConstituency.candidateList.candidateDetails[i].Fullname);
                Assert.AreEqual(expectedConstituency.candidateList.candidateDetails[i].party, actualConstituency.candidateList.candidateDetails[i].party);
                Assert.AreEqual(expectedConstituency.candidateList.candidateDetails[i].votes, actualConstituency.candidateList.candidateDetails[i].votes);

            }
        }
    }
}
