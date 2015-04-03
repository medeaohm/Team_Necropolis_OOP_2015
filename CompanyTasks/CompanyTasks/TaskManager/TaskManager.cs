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
            var manager = new Manager("Kir4o", new DateTime(1968, 05, 20), Gender.Male, 10, new Team("Kir4osTeam"));
            var employee = new JuniorEmployee("Petra", new DateTime(1988, 12, 01), Gender.Female, 2);
            var newEmp = new SiniorEmployee("Stamat", new DateTime(1986, 01, 30), Gender.Male, 10);

            manager.Team.AddEmployee(employee);
            manager.Team.AddEmployee(newEmp);
            Console.WriteLine("Initial Team:");
            Console.WriteLine(manager.ToString());
            Console.WriteLine(string.Join("\n", manager.Team.GetAllEmployees));

            //the manager promote perta from junior to senior;
            manager.Promote(employee);
            var employee2 = employee.PromotedToSinior(employee, employee.IsPromoted);

            //this should be implemented into the classes -> there must be a virtual method so that every kind of employee (i.e. junior, seniro or manager) coulbe be promoted
            manager.Team.RemoveEmployee(employee);
            manager.Team.AddEmployee(employee2);

            Console.WriteLine("Petra was promoted to senior");
            Console.WriteLine(manager.ToString());
            Console.WriteLine(string.Join("\n", manager.Team.GetAllEmployees));

            //the manager promote stamat from senior to manager
            manager.Promote(newEmp);
            var men2 = newEmp.PromotedToManager(newEmp, newEmp.IsPromoted);
            manager.Team.RemoveEmployee(newEmp);

            Console.WriteLine("Stamat became a manager:");
            Console.WriteLine(men2.ToString());
            Console.WriteLine(manager.ToString());
            Console.WriteLine(string.Join("\n", manager.Team.GetAllEmployees));

            //manager.Team.AddTasks(employee, new LowToDo("Create web site", new string('s', 30)));

            //var tasks = manager.Team.GetTasks(employee);

            //foreach (var task in tasks)
            //{
            //    Console.WriteLine(task);
            //}

        }
    }
}
