using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    abstract class Bee
    {
        public abstract float CostPerShift { get; }
        public string Job { get; }

        public Bee(string job)
        {
            Job = job;
        }

        protected void WorkTheNextShift()
        {
            if (HoneyVault.ConsumerHoney(CostPerShift))
            {
                DoJob();
            }
        }

        protected abstract void DoJob();
    }
}
