namespace TaskManager.Task.Validation
{
    using Common;
    using Interfaces;

    using System;

    public interface ITaskValidation 
    {
        void ValidateDaysToEnd(int value);

        void ValidateDescription(string value);

        void ValidateTitle(string value);

        void SubtaskNotFound(ISubtask subtask);
    }
}
