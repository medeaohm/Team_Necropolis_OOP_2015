namespace TaskManager.User.Interfaces
{
    public interface IDirector
    {
        void AddToTeam(Employee employeeName);
        void RemoveFromTeam(Employee employeeName);
    }
}
