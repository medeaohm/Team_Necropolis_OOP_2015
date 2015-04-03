namespace TaskManager.User.Interfaces
{
    using Enums;

    public interface IEmployee : IPerson
    {
        decimal Salary { get; }

        int TimeWorked { get; }

        PositionType Position { get; set; }
    }
}
