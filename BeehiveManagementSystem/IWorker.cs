namespace BeehiveManagementSystem
{
    public interface IWorker
    {
        string Job { get; }

        void WorkTheNextShift();
    }
}