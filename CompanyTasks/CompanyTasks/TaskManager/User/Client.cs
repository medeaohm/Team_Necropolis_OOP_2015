using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.User
{
    public class Client : Person
    {

        public string MyProjectTodo { get; private set; }
        public string ClientCompany { get; private set; }

        public Client(string name, string clientCompany, string myProjectTodo, string dateBirth, Gender sex, byte age)
            : base(name, dateBirth, sex, age)
        {
            this.ClientCompany = clientCompany;
            this.MyProjectTodo = myProjectTodo;
        }

    }
}
