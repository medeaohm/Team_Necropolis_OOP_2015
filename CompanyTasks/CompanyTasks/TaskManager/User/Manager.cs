/*
 A manager is an employee with a list of subordinates employees 
 */

namespace TaskManager.User
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using User.Interfaces;


    public class Manager : Employee, IDirector, IPromote, ICreateNewTask
    {
        private ICollection<Employee> team;
        private ICollection<string> task;

        public Manager(string name, string dateBirth, Gender sex, byte age, string position, int timeWorked, decimal salary)
            :base(name, dateBirth, sex, age, position, timeWorked, salary)
        {
            this.team = new List<Employee>();
            this.task = new List<string>();
        }
        public ICollection<Employee> Team
        {
            get
            {
                return new List<Employee>(team);
            }
        }
        public void AddToTeam(Employee employeeName)
        {
            this.team.Add(employeeName);
        }

        public void RemoveFromTeam(Employee employeeName)
        {
            this.team.Remove(employeeName);
        }
        
        public void CreateNewTaskToTeam(string newTask)
        {
            this.task.Add(newTask);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            var teamName = this.Team
                .Select(x => x.Name);

            result.Append(base.ToString());
            result.AppendLine(string.Format("The {1}'s team - {0}", string.Join(", ", teamName), this.Name));
            result.AppendLine("Task's to Team:");
            result.AppendLine(string.Format("{0}", string.Join(", ", this.task)));
            return result.ToString();
        }

       
    }

}
