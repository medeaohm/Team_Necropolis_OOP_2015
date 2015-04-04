namespace TaskManager.User.Interfaces
{
    using System.Collections.Generic;

    public interface IClient : IPerson
    {
        List<string>MyProjectsTodo { get; }
        void AddProject();
        void RemoveProject();
        void EmptyProjects();
        string ClientCompany { get; }
    }
}
