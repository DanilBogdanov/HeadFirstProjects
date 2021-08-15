namespace BeehiveManagementSystem.bees
{
    abstract class Bee : IWorker

    {
    protected abstract float CostPerShift { get; }
    public string Job { get; }

    public Bee(string job)
    {
        Job = job;
    }

    public void WorkTheNextShift()
    {
        if (HoneyVault.ConsumerHoney(CostPerShift))
        {
            DoJob();
        }
    }

    protected abstract void DoJob();
    }
}
