namespace TaskManager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using User;

    public class TaskManager
    {
        public static void Main()
        {
            var test = new Employee("pencho", new DateTime (1975,1,1), Gender.Male, "Junior Dev", 8, 2500);
            var test2 = new Employee("Hancho", new DateTime(1964, 1, 1), Gender.Male, "Junior Dev", 8, 2500);
            //Console.WriteLine(test);

            var managerOne = new Manager("Penko Penkow", new DateTime(1977, 1, 1), Gender.Male, "Team Leader", 8, 1500);
            managerOne.AddToTeam(test);
            managerOne.AddToTeam(test2);
            managerOne.CreateNewTaskToTeam("Beer time guys!!! :D");
            managerOne.CreateNewTaskToTeam("Build todo app");
            Console.WriteLine(managerOne);
            var bos = new Boss("tester", new DateTime(1944, 1, 1), Gender.Male);
            Console.WriteLine(bos);
            Client clientOne = new Client("ClientOne", "Company", "TODOProject", new DateTime(1999, 1, 1), Gender.Male);
            bos.addClient(clientOne);
            Console.WriteLine(bos.listOfClients());
            Console.WriteLine(bos.Age);
        }
    }
}
