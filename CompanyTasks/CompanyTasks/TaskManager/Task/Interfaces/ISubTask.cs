
namespace TaskManager.Task.Interfaces
{
    using Enum;

    using System;

    public interface ISubtask
    {
        DateTime DateToCreate { get; }

        DateTime DateToEnd { get; }

        bool IsComleate { get; set; }

        int DaysToEnd { get; set; }

        string Description { get; set; }

        PriorityType Priority { get; set; }

        string Title { get; }
    }
}
