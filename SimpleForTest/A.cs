using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleForTest
{
    abstract class A
    {
        public static int count = 0;
        public virtual void MPub()
        {

        }

        protected virtual void MProt()
        {

        }

        private  void MPriv()
        {

        }
    }
}
