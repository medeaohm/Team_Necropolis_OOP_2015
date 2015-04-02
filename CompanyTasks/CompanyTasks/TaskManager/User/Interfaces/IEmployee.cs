using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.User.Interfaces
{
    interface IEmployee
    {
        decimal Salary { get; }
        int TimeWorked { get; }
        string Position { get; }
    }
}
