using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem.bees
{
    class NectarCollector : Bee
    {
        internal static int Count { get; private set; }
        protected override float CostPerShift => 1.95f;
        private const float NECTAR_COLLECTED_PER_SHIFT = 33.25f;

        public NectarCollector() : base("Nectar Collector")
        {
            Count++;
        }

        protected override void DoJob()
        {
            HoneyVault.CollectNectar(NECTAR_COLLECTED_PER_SHIFT);
        }
    }
}
