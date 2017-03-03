using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_2;
using ConstituencyTesting.Helper;
using TestedClass = Assignment_2.XMLConstituencyFileReader;

namespace ConstituencyTesting.Fixtures
{
    [TestClass]
    public class TestFixture_XmlConstituencyFileReader
    {
        TestedClass testedClass = null;
        [TestCleanup]
        public void TestsCleanup()
        {
            testedClass = null;
        }

        [TestMethod]
        public void Test_ReadConstituencyDataFromFile_Method_File_Not_Exist()
        {
            // Arrange
            // A file with this name does not exist
            var filename = "Does_Not_Exist";

            // Instantiate an XMLConstituencyFileReader object
            testedClass = new TestedClass();

            // Act
            var actualConstituency = testedClass.ReadConstituencyDataFromFile(new ConfigRecord(filename));

            // Assert
            Assert.IsNull(actualConstituency);
        }

        [TestMethod]
        public void Test_ReadConstituencyDataFromFile_Method_File_Sunderland_Exists_Is_Valid()
        {
            Helper_Test_ReadConstituencyDataFromFile_Method_File_Exists_Is_Valid("Sunderland.xml", Helper_KnownConstituencyData.GetKnownSunderland());
        }

        [TestMethod]
        public void Test_ReadConstituencyDataFromFile_Method_File_Newcastle_Exists_Is_Valid()
        {
            Helper_Test_ReadConstituencyDataFromFile_Method_File_Exists_Is_Valid("Newcastle.xml", Helper_KnownConstituencyData.GetKnownNewcastle());
        }

        [TestMethod]
        [ExpectedException(typeof(System.Xml.XmlException))]
        public void Test_ReadConstituencyDataFromFile_Method_File_Exists_Is_Invalid()
        {

            var fileName = "InvalidConstituency.xml";

            // Intantiate an XMLConstituencyFileReader object
            testedClass = new TestedClass();

            var actualConstituency = testedClass.ReadConstituencyDataFromFile(new ConfigRecord(fileName));

            // Assert
            // Should not reach here due to exception being raised, if reached then force the test to fail
            Assert.Fail("ERROR: should have thrown System.Xml.XmlException before reaching here!");
        }

        private void Helper_Test_ReadConstituencyDataFromFile_Method_File_Exists_Is_Valid(string filename, Constituency expectedConstituency)
        {
            // Arrange
            // Instantiate an XmlConstituencyFileReader object
            testedClass = new TestedClass();

            // Act
            // Call the ReadConstituencyDataFromFile() method to load and process the known constituency from the XML format
            var actualConstituency = testedClass.ReadConstituencyDataFromFile(new ConfigRecord(filename));


            // First check Constituency name property
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
