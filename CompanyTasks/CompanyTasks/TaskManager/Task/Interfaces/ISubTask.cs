
namespace TaskManager.Task.Interfaces
{
    using Enum;

    using System;

    public interface ISubtask
    {
        DateTime DateCreated { get; }

        DateTime DateDue { get; private set; }

        bool IsCompleted { get; set; }

        string Description { get; set; }

        PriorityType Priority { get; set; }

        string Title { get; }
    }
}
