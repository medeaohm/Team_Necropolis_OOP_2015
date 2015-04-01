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
        private List<Employee> Subordinates;
    }

}
