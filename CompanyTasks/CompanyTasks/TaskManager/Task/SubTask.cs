namespace TaskManager.Task
{
    using Enum;
    using Interfaces;

    using System;
    using Common;
    using Validation;

    public class Subtask : ISubtask
    {
        private readonly ITaskValidation validation = new TaskValidation();

        private string title;
        private string description;
        private int daysToEnd;

        public Subtask(string initTitle, int initDaysToEnd, string initDescription, PriorityType initPriority)
        {
            this.Title = initTitle;
            this.Priority = initPriority;
            this.DateToCreate = DateTime.Now;
            this.Description = initDescription;
        }

        public PriorityType Priority { get; set; }

        public bool IsComleate { get; set; }

        public DateTime DateToCreate { get; private set; }

        public DateTime DateToEnd
        {
            get
            {
                return this.DateToCreate.AddDays(this.daysToEnd);
            }
        }

        public int DaysToEnd
        {
            get
            {
                return this.daysToEnd;
            }

            set
            {
                this.validation.ValidateDaysToEnd(value, "Days to end");

                this.daysToEnd = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            private set
            {
                this.validation.ValidateTitle(value, "Title");

                this.title = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.validation.ValidateDescription(value, "Descriptyon");

                this.description = value;
            }
        }

        protected ITaskValidation Validation
        {
            get { return this.validation; }
        }

        public override string ToString()
        {
            return string.Format("ToDo {0} - Title {1} , Description {2}", this.GetType().Name, this.title, this.description);
        }
    }
}
