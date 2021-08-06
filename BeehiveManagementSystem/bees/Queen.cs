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
        private float _unassignedWorkers = 3;
        public string StatusReport { get; private set; }

        public Queen() : base("Queen")
        {
            _workers = new Bee[0];
            AssignBee(BeeType.EggCare);
            AssignBee(BeeType.HoneyManufacturer);
            AssignBee(BeeType.NectarCollector);

            UpdateStatusReport();
        }

        internal void AssignBee(BeeType type)
        {
            if (_unassignedWorkers >= 1)
            {
                switch (type)
                {
                    case BeeType.EggCare:
                        AddWorkers(new EggCare(this));
                        break;
                    case BeeType.NectarCollector:
                        AddWorkers(new NectarCollector());
                        break;
                    case BeeType.HoneyManufacturer:
                        AddWorkers(new HoneyManufacturer());
                        break;
                }
            }
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
            _unassignedWorkers--;
            Array.Resize(ref _workers, _workers.Length + 1);
            _workers[_workers.Length - 1] = worker;
            UpdateStatusReport();
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

            StatusReport = result;
        }
    }
}