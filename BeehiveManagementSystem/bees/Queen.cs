using System;
using System.ComponentModel;

namespace BeehiveManagementSystem.bees
{
    class Queen : Bee, INotifyPropertyChanged
    {
        private const float EGGS_PER_SHIFT = 0.45f;
        private const float HONEY_PER_UNASSIGNED_WORKER = 0.5f;

        //private Bee[] _workers = new Bee[0];
        private IWorker[] _workers = new IWorker[0];
        private float _eggs;
        private float _unassignedWorkers = 3;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        protected override float CostPerShift => 2.15f;
        public string StatusReport { get; private set; }

        public Queen() : base("Queen")
        {
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

            foreach (IWorker worker in _workers)
            {
                worker.WorkTheNextShift();
            }

            HoneyVault.ConsumerHoney(HONEY_PER_UNASSIGNED_WORKER * _unassignedWorkers);
            UpdateStatusReport();
        }


        private void AddWorkers(IWorker worker)
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

            result += $"\n\nEgg count: {_eggs:0.0}" +
                      $"\nUnassigned workers: {_unassignedWorkers:0.0}" +
                      $"\n{NectarCollector.Count} Nectar Collector bee" +
                      $"\n{HoneyManufacturer.Count} Honey Manufacturer bee" +
                      $"\n{EggCare.Count} Egg Care bee" +
                      $"\nTOTAL WORKERS: {_workers.Length}";

            StatusReport = result;
            OnPropertyChanged("StatusReport");
        }
    }
}