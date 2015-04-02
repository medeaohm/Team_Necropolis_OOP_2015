/*
 A junior employee is a subordinate of some manager - it can be promoted and became a manager itself
 */

namespace TaskManager.User
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using User.Interfaces;

    public class JuniorEmployee : Employee, IIsPromoted
    {
        public JuniorEmployee(string name, DateTime dateBirth, Gender sex, string position, int timeWorked, decimal salary )
            :base(name, dateBirth, sex, position, timeWorked, salary)
        {

        }
    }
}
