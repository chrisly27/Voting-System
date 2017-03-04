using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class ProgressManager
    {
        public int itemsRemaining;
        public int ItemRemaining //property getter/setter methods
        {
            get { return itemsRemaining; }
            set
            {   lock (this)
                {   // MUTEX control for potential multiple thread access to this property
                    itemsRemaining = value;
                }
            }
        }
        public ProgressManager()
        {
            this.ItemRemaining = 0;
        }
        public ProgressManager(int items)
        {
            this.ItemRemaining = items;
        }
    }
}
