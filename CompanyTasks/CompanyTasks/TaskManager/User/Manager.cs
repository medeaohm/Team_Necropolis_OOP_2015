/*
 A manager is an employee with a list of subordinates employees 
 */

namespace TaskManager.User
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Enums;
    using User.Interfaces;
    using Task.Interfaces;

    public class Manager : Employee, IManager
    {
        private const decimal InitSalary = 3000M;
        private const PositionType InitPosition = PositionType.Manager;

        public Manager(string name, DateTime dateBirth, Gender sex, int timeWorked, Team initTeam)
            : base(name, dateBirth, sex, InitPosition, timeWorked, InitSalary)
        {
            this.Team = initTeam;
        }

        public Team Team { get; private set; }

        public override string ToString()
        {
            var result = new StringBuilder();

            var teamName = this.Team.TeamName;
                

            result.Append(base.ToString());
            result.AppendLine(string.Format("The {1}'s team - {0}", string.Join(", ", teamName), this.Name));
            result.AppendLine("Task's to Team:");
            result.AppendLine(string.Format("{0}", string.Join(", ", this.PersonalTask)));
            return result.ToString();
        }
    }
}
