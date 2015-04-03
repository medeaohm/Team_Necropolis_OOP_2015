/*
 A junior employee is a subordinate of some manager - it can be promoted and became a manager itself
 */

namespace TaskManager.User
{
    using System;

    using Enums;
    using User.Interfaces;

    public class JuniorEmployee : Employee, IIsPromoted
    {
        private const decimal InitSalary = 900;
        private const PositionType InitPosition = PositionType.Junior;

        public JuniorEmployee(string name, DateTime dateBirth, Gender sex, int timeWorked )
            : base(name, dateBirth, sex, InitPosition, timeWorked, InitSalary)
        {

        }
    }
}
