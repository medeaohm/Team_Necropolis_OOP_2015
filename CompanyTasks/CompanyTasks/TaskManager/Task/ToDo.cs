namespace TaskManager.Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;
    using User;
    using Enum;
    using User.Enums;

    public class ToDo : Task, IComment
    {
        private Manager Boss; // a manager is responsible for the task  - it should assigne it to other employees
        private List<Employee> Persons; // a list of junior employee which has to complete the task
        private Status status;
        private Priority priority;
        private Department department; // this is the task type 

    }
}
