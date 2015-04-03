namespace TaskManager.Task
{
    using Enum;
    using Interfaces;

    using System.Linq;
    using System.Collections.Generic;

    public abstract class ToDo : Subtask, IToDo
    {
        private ICollection<ISubtask> subtasks;
        private ICollection<IComment> comments;

        public ToDo(string initTitle, int initDaysToEnd, string initDescription, PriorityType initPriority)
            : base(initTitle, initDaysToEnd, initDescription, initPriority)
        {
            this.Status = StatusType.Launched;
            this.subtasks = new List<ISubtask>();
            this.comments = new List<IComment>();
        }

        public ICollection<ISubtask> Subtasks
        {
            get { return new List<ISubtask>(this.subtasks); }
        }

        public ICollection<IComment> Comments
        {
            get { return new List<IComment>(this.comments); }
        }

        public StatusType Status { get; set; }

        public void AddSubtask(ISubtask subtask)
        {
            this.Validation.SubtaskNotFound(subtask);

            this.subtasks.Add(subtask);
        }

        public void CompleateSubtask(ISubtask subtask)
        {
            var compleatedSubtask = this.subtasks.First(task => task.Title == subtask.Title);

            this.Validation.SubtaskNotFound(compleatedSubtask);

            compleatedSubtask.IsComleate = true;
        }

        public void RemoveSubtask(ISubtask subtask)
        {
            var deletedSubtask = this.subtasks.First(task => task.Title == subtask.Title);

            this.Validation.SubtaskNotFound(deletedSubtask);

            this.subtasks.Remove(deletedSubtask);
        }

        public void CompleteToDo()
        {
            this.IsComleate = false;
            this.Status = StatusType.Finished;
        }
    }
}
