namespace TaskManager.Task
{
    using Enum;

    public class MediumToDo : ToDo
    {
        private const int InitialDaysToEnd = 30;
        private const PriorityType InitialType = PriorityType.Important;

        public MediumToDo(string initTitle, string initDescription)
            : base(initTitle, InitialDaysToEnd, initDescription, InitialType)
        {

        }
    }
}
