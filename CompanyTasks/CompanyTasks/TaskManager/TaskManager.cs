namespace TaskManager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Task;
    using User;
    using User.Enums;


    public class TaskManager
    {
        public static void Main()
        {
            var manager = new Manager(null, DateTime.Now, Gender.Male, 10, new Team("PeshoTeam"));

            var employee = new JuniorEmployee(null, DateTime.Now, Gender.Female, 2);
            var newEmp = new SiniorEmployee("Stamat", DateTime.Now, Gender.Male, 10);

            manager.Team.AddEmployee(employee);
            manager.Team.AddEmployee(newEmp);

            manager.Team.AddTasks(employee, new LowToDo("Create web site", new string('s', 30)));

            var tasks = manager.Team.GetTasks(employee);

            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }

            Console.WriteLine(string.Join(", " , manager.Team.GetAllEmployees));

        }
    }
}
