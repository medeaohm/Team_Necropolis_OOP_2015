namespace TaskManager.User.Interfaces
{
    public interface IClient : IPerson
    {
        string MyProjectTodo { get; }

        string ClientCompany { get; }
    }
}
