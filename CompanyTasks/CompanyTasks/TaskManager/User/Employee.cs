/*
 * Employees are humans with more charateristics
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

    public class Employee : Person, IEmployee
    {

        private const decimal MinSalaty = 900M;
        private const string GeneralToStringFormat = "Position: {0}, Salary: {1}, Time Worked: {2}";

        private decimal salary;
        private int timeWorked;
        private ICollection<IToDo> personalTasks;

        public Employee(string name, DateTime dateBirth, Gender sex, PositionType position, int timeWorked, decimal salary)
            : base(name, dateBirth, sex)
        {
            this.Position = position;
            this.TimeWorked = timeWorked;
            this.Salary = salary;

            this.personalTasks = new List<IToDo>();
        }

        public ICollection<IToDo> PersonalTask
        {
            get
            {
                return new List<IToDo>(this.personalTasks);
            }
        }

        public int TimeWorked
        {
            get
            {
                return this.timeWorked;
            }

            private set
            {
                this.Validation.ValidateTimeWorked(value);

                this.timeWorked = value;
            }
        }

        public PositionType Position { get; set; }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            private set
            {
                this.Validation.ValidateSalary(value);

                this.salary = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString());
            result.AppendLine(string.Format(Employee.GeneralToStringFormat, this.Position, this.Salary, this.TimeWorked));
            return result.ToString();
        }
    }
}
