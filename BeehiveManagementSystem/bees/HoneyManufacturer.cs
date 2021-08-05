using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem.bees
{
    class HoneyManufacturer : Bee
    {
        public override float CostPerShift => 1.7f;

        public HoneyManufacturer() : base("Honey Manufacturer")
        {

        }

        protected override void DoJob()
        {
            throw new NotImplementedException();
        }
    }
}
