namespace BeehiveManagementSystem.bees
{
    abstract class Bee
    {
        protected abstract float CostPerShift { get; }
        private string Job { get; }

        public Bee(string job)
        {
            Job = job;
        }

        internal void WorkTheNextShift()
        {
            if (HoneyVault.ConsumerHoney(CostPerShift))
            {
                DoJob();
            }
        }

        protected abstract void DoJob();
    }
}
