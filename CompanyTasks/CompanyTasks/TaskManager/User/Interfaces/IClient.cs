using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.User.Interfaces
{
    interface IClient
    {
        string MyProjectTodo { get; }
        string ClientCompany { get; }
    }
}
