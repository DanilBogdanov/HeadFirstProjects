using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class Queen : Bee
    {
        public override float CostPerShift => 2.15f;
        private Bee[] workers = new Bee[0];
        private int eggs;
        private int unassignedWorkers;

        public Queen() : base("Queen")
        {
        }

        protected override void DoJob()
        {
            throw new NotImplementedException();
        }

        private void AddWorkers(Bee worker)
        {
            if (unassignedWorkers >= 1)
            {
                unassignedWorkers--;
                Array.Resize(ref workers, workers.Length + 1);
                workers[workers.Length - 1] = worker;
            }
        }

        private void AssignBee(string job)
        {
            switch (job)
            {
                case "Egg Care":
                    AddWorkers(new bees.EggCare(this));
                    break;
                case "Nectar Collector":
                    AddWorkers(new bees.NectarCollector());
                    break;
                case "Honey Manufacturer":
                    AddWorkers(new bees.NectarCollector());
                    break;
            }
        }
    }
}
