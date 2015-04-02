/*
 A manager is an employee with a list of subordinates employees 
 */

namespace TaskManager.User
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using User.Interfaces;

    public class Manager : Employee, IPromote, ICreateNewTask
    {
        private ICollection<string> task;

        public Manager(string name, DateTime dateBirth, Gender sex, string position, int timeWorked, decimal salary)
            :base(name, dateBirth, sex, position, timeWorked, salary)
        {
            this.Team = new Team("Baba Meca");
            this.task = new List<string>();
        }

        public Team Team { get; private set; }

        public void AddToTeam(IEmployee employeeName)
        {
            Team.TeamMembers.Add(employeeName);
        }

        public void RemoveFromTeam(IEmployee employeeName)
        {
            this.Team.TeamMembers.Remove(employeeName);
        }
        
        public void CreateNewTaskToTeam(string newTask)
        {
            this.Team.TeamTasks.Add(newTask);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            var teamName = this.Team.TeamName;
                

            result.Append(base.ToString());
            result.AppendLine(string.Format("The {1}'s team - {0}", string.Join(", ", teamName), this.Name));
            result.AppendLine("Task's to Team:");
            result.AppendLine(string.Format("{0}", string.Join(", ", this.task)));
            return result.ToString();
        }
    }
}
