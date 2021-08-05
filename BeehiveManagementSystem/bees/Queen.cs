using System;

namespace BeehiveManagementSystem.bees
{
    class Queen : Bee
    {
        protected override float CostPerShift => 2.15f;
        private const float EGGS_PER_SHIFT = 0.45f;
        private const float HONEY_PER_UNASSIGNED_WORKER = 0.5f;
        private Bee[] _workers;
        private float _eggs;
        private float _unassignedWorkers;

        public Queen() : base("Queen")
        {
            _workers = new Bee[0];
            _unassignedWorkers = 3;
        }

        protected override void DoJob()
        {
            _eggs += EGGS_PER_SHIFT;

            foreach (Bee bee in _workers)
            {
                bee.WorkTheNextShift();
            }

            HoneyVault.ConsumerHoney(HONEY_PER_UNASSIGNED_WORKER * _unassignedWorkers);
            UpdateStatusReport();
            
        }

        private void AddWorkers(Bee worker)
        {
            if (_unassignedWorkers >= 1)
            {
                _unassignedWorkers--;
                Array.Resize(ref _workers, _workers.Length + 1);
                _workers[_workers.Length - 1] = worker;
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

        internal void CareForEggs(float eggsToConvert) 
        {
            if (_eggs > eggsToConvert)
            {
                _unassignedWorkers += eggsToConvert;
                _eggs -= eggsToConvert;
            }
            else
            {
                _unassignedWorkers += _eggs;
                _eggs = 0;
            }
        }

        private void UpdateStatusReport()
        {
            string result = HoneyVault.StatusReport;

            
            result += $"\n\nEgg count: {_eggs}" +
                      $"\nUnassigned workers: {_unassignedWorkers}" +
                      $"\n{NectarCollector.Count} Nectar Collector bee" +
                      $"\n{HoneyManufacturer.Count} Honey Manufacturer bee" +
                      $"\n{EggCare.Count} Egg Care bee" +
                      $"\nTOTAL WORKERS: {_workers.Length}";
        }
    }
}