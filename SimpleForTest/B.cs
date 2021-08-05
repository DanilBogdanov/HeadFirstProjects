using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleForTest
{
    class B : A
    {
        protected override void MProt()
        {
            
        }
        public void M()
        {
            MProt();
        }

    }
}
