namespace TaskManager.User.Interfaces
{
    public interface IEmployee : IPerson
    {
        decimal Salary { get; }

        int TimeWorked { get; }

        string Position { get; }
    }
}
