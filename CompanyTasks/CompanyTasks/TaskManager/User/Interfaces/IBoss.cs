namespace TaskManager.User.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    interface IBoss
    {
        ICollection<Client> clients { get; }
        void addClient(Client clientName);
        void removeClient(Client clientName);
        string listOfClients();
    }
}
