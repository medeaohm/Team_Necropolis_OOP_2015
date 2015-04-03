
namespace TaskManager.User
{
    using System;

    using Enums;
    using Interfaces;

    public class SiniorEmployee : Employee, IIsPromotedToManager
    {
        private const decimal InitSalary = 2000M;
        private const PositionType InitPosition = PositionType.Sinior;

        public SiniorEmployee(string name, DateTime dateBirth, Gender sex, int timeWorked)
            : base(name, dateBirth, sex, InitPosition, timeWorked, InitSalary)
        {

        }

        public Manager PromotedToManager(Employee employee, bool isPromoted)
        {
            if (employee.IsPromoted)
            {
                return new Manager(employee.Name, employee.DateBirth, employee.Sex, 0, new Team(string.Format("{0}'s Team", employee.Name)));
            }
            else return null;
        }
    }
}
