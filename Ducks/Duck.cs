using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class Duck : Bird, IComparable<Duck>
    {
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }
        public int CompareTo(Duck other)
        {
            if (this.Size > other.Size)
            {
                return 1;
            }
            else if (this.Size < other.Size)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
