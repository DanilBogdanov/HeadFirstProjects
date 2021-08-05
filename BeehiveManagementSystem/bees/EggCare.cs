using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem.bees
{
    class EggCare : Bee
    {
        internal static int Count { get; private set; }
        private Queen queen;
        protected override float CostPerShift => 1.35f;
        private const float CARE_PROGRESS_PER_SHIFT = 0.15f;

        public EggCare(Queen queen) : base("Egg Care")
        {
            this.queen = queen;
            Count++;
        }

        protected override void DoJob()
        {
            queen.CareForEggs(CARE_PROGRESS_PER_SHIFT);
        }
    }
}
