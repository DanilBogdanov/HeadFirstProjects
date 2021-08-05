using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem.bees
{
    class NectarCollector : Bee
    {
        public override float CostPerShift => 1.95f;

        public NectarCollector() : base("Nectar Collector")
        {

        }

        protected override void DoJob()
        {
            throw new NotImplementedException();
        }
    }
}
