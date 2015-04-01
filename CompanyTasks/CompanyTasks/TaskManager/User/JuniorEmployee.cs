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

    }
}
