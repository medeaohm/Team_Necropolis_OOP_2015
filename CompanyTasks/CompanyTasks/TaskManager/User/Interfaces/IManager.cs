namespace TaskManager.User.Interfaces
{
    using System.Collections.Generic;

    public interface IManager 
    {
        Team Team { get; }

        ICollection<string> Task { get; }

        void AddToTeam(IEmployee employeeName);

        void RemoveFromTeam(IEmployee employeeName);
    }
}
