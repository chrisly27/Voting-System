using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public interface IPartyDataReader
    {
        List<Party> ReadPartyData(ConfigRecord configRecord);
    }
}
