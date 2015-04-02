using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.User.Interfaces
{
    interface IPerson
    {
        string Name { get; }
        int Age { get; }
        Gender Sex { get; }
        DateTime DateBirth { get; }
    }
}
