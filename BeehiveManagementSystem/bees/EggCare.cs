using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem.bees
{
    class EggCare : Bee
    {
        private Bee queen;
        public override float CostPerShift => 1.35f;

        public EggCare(Bee queen) : base("Egg Care")
        {
            this.queen = queen;
        }

        protected override void DoJob()
        {
            throw new NotImplementedException();
        }
    }
}
