namespace TaskManager.User.Interfaces
{
    interface IBoss
    {
        void addClient(Client clientName);
        void removeClient(Client clientName);
        string listOfClients();
    }
}
