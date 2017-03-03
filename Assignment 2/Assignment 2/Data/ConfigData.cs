using System.Collections.Generic;

namespace Assignment_2
{
    public class ConfigData
    {
        public List<ConfigRecord> configRecords { get; set; }
        public int NextRecord { get; set; }
        public ConfigData()
        {
            this.NextRecord = 0;
            configRecords = new List<ConfigRecord>();
        }
    }
}
