namespace TaskManager.Task
{
    using Enum;

    public class ImportantToDo : ToDo
    {
        private const int InitialDaysToEnd = 30;
        private const PriorityType InitialType = PriorityType.Important;

        public ImportantToDo(string initTitle, string initDescription)
            : base(initTitle, InitialDaysToEnd, initDescription, InitialType)
        {

        }
    }
}
