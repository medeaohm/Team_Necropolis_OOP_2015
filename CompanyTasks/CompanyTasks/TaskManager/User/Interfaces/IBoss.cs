namespace TaskManager.User.Interfaces
{
    using System.Collections.Generic;

    public interface IBoss
    {
        ICollection<IClient> clients { get; }

        void addClient(IClient clientName);

        void removeClient(IClient clientName);

        string listOfClients();
    }
}
