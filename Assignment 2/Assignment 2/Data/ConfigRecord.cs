using System;

namespace Assignment_2
{
    public class ConfigRecord
    {
        public String Filename { get; private set; }
        public ConfigRecord(String Filename)
        {
            this.Filename = Filename;
        }
        public override String ToString()
        {
            return String.Format("{0}", Filename);
        }
    }
}
