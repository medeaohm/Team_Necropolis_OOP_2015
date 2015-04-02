namespace TaskManager.User
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using User.Interfaces;

    public class Client : Person, IClient
    {

        public string MyProjectTodo { get; private set; }
        public string ClientCompany { get; private set; }

        public Client(string name, string clientCompany, string myProjectTodo, DateTime dateBirth, Gender sex)
            :base (name, dateBirth, sex)
        {
            this.ClientCompany = clientCompany;
            this.MyProjectTodo = myProjectTodo;
        }

    }
}
