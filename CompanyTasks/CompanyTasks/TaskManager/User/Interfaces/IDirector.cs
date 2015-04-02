namespace TaskManager.User.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IDirector
    {
        ICollection<Employee> Team { get; }
        ICollection<string> Task { get; }
        void AddToTeam(Employee employeeName);
        void RemoveFromTeam(Employee employeeName);
    }
}
