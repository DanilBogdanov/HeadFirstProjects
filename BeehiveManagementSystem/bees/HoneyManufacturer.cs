using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem.bees
{
    class HoneyManufacturer : Bee
    {
        internal static int Count { get; private set; }
        protected override float CostPerShift => 1.7f;
        private const float NECTAR_PROCESSED_PER_SHIFT = 33.15f;

        public HoneyManufacturer() : base("Honey Manufacturer")
        {
            Count++;
        }

        protected override void DoJob()
        {
            HoneyVault.ConvertNectarToHoney(NECTAR_PROCESSED_PER_SHIFT);
        }
    }
}
