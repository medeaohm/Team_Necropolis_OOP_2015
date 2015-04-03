
namespace TaskManager.User
{
    using System;

    using Enums;

    public class SiniorEmployee : Employee
    {
         private const decimal InitSalary = 2000M;
        private const PositionType InitPosition = PositionType.Sinior;

        public SiniorEmployee(string name, DateTime dateBirth, Gender sex, int timeWorked)
            : base(name, dateBirth, sex, InitPosition, timeWorked, InitSalary)
        {

        }
    }
}
