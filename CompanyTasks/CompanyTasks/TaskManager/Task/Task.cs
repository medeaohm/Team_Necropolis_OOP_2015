namespace TaskManager.Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Task
    {
        private string ProjectName;
        private DateTime DeadLine; // the deadline of the task
        private double WorkDays; // days needed to complete a task
    }
}
