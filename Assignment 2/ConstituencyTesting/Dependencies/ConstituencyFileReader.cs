using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_2;
using ConstituencyTesting.Helper;

namespace ConstituencyTesting.Dependencies
{
    public class ConstituencyFileReader : IConstituencyFileReader
    {
        public Constituency ReadConstituencyDataFromFile(ConfigRecord configRecord)
        {
            return Helper_KnownConstituencyData.GetKnownSunderland();
        }
    }
}
