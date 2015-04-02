/*
 * Employees are humans with more charateristics
 */

namespace TaskManager.User
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using User.Interfaces;

    public class Employee : Person, IEmployee
    {

        private const decimal MinSalaty = 900M;
        private const string ErrMessageWhenSalaryIsToLessFrom900 = "Salary cannot be less than 900 BGN";
        private const string GeneralToStringFormat = "Position: {0}, Salary: {1}, Time Worked: {2}";

        private decimal salary;

        public Employee(string name, DateTime dateBirth, Gender sex, string position, int timeWorked, decimal salary)
            :base (name, dateBirth, sex)
        {
            this.Position = position;
            this.TimeWorked = timeWorked;
            this.Salary = salary;
        }

        public int TimeWorked { get; private set; }

        public string Position { get; private set; }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            private set
            {
                if (value < Employee.MinSalaty)
                {
                    throw new ArgumentOutOfRangeException("Salary", Employee.ErrMessageWhenSalaryIsToLessFrom900);
                }
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
