using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_2;
using System.Collections.Generic;

namespace ConstituencyTesting.Helper
{
    [TestClass]
    public class Helper_KnownConstituencyData
    {
        public static Constituency GetKnownSunderland()
        {
            var constituency = new Constituency("Sunderland");

            constituency.candidateList = new CandidateList();
            constituency.candidateList.candidateDetails = new List<Candidate>();

            constituency.candidateList.candidateDetails.Add(new Candidate("Fred Bloggs", 109,"Convervative", "Sunderland"));
            constituency.candidateList.candidateDetails.Add(new Candidate("Tina Muanza", 200, "Green", "Sunderland"));
            constituency.candidateList.candidateDetails.Add(new Candidate("Keith Robson", 345, "Freedom", "Sunderland"));

            constituency.candidateElected = new Candidate("Keith Robson", 345, "Freedom", "Sunderland");

            return constituency;
        }

        public static Constituency GetKnownNewcastle()
        {
            var constituency = new Constituency("Newcastle");

            constituency.candidateList = new CandidateList();
            constituency.candidateList.candidateDetails = new List<Candidate>();

            constituency.candidateList.candidateDetails.Add(new Candidate("George Tomson", 85, "Convervative", "Newcastle"));
            constituency.candidateList.candidateDetails.Add(new Candidate("Ben Todd", 185, "Green", "Newcastle"));
            constituency.candidateList.candidateDetails.Add(new Candidate("Samuel Scott", 345, "Freedom", "Newcastle"));

            constituency.candidateElected = new Candidate("Ben Todd", 185, "Green", "Newcastle");

            return constituency;
        }

        public static List<Party>GetSunderlandParty()
        {
            var lis = new List<Party>();

            lis.Add(new Party("Conservative", 109));
            lis.Add(new Party("Green", 200));
            lis.Add(new Party("Freedom", 345));

            return lis;
        }

        public static List<Party> GetNewcastleParty()
        {
            var lis = new List<Party>();

            lis.Add(new Party("Conservative", 85));
            lis.Add(new Party("Green", 185));
            lis.Add(new Party("Freedom", 345));

            return lis;
        }
    }
}
