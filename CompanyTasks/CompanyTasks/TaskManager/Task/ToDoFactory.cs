
namespace TaskManager.Task
{
    using Interfaces;

    public class ToDoFactory : IToDoFactory
    {
        public IToDo CreateImportantToDo(string initTitle, string initDescription)
        {
            return new ImportantToDo(initTitle, initDescription);
        }

        public IToDo CreateLowToDo(string initTitle, string initDescription)
        {
            return new LowToDo(initTitle, initDescription);
        }

        public IToDo CreateMediumToDo(string initTitle, string initDescription)
        {
            return new MediumToDo(initTitle, initDescription);
        }
    }
}
