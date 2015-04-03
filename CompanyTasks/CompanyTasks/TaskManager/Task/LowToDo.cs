namespace TaskManager.Task
{
    using Enum;

    public class LowToDo : ToDo
    {
        private const int InitialDaysToEnd = 90;
        private const PriorityType InitialType = PriorityType.Low;

        public LowToDo(string initTitle, string initDescription)
            : base(initTitle, InitialDaysToEnd, initDescription, InitialType)
        {

        }
    }
}
