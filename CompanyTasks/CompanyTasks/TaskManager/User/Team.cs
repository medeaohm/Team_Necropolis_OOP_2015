namespace TaskManager.User
{
    using Interfaces;
    using System.Collections.Generic;


    public class Team
    {
        private string name;

        public Team(string teamName)
        {

            this.TeamMembers = new List<IEmployee>();
            this.TeamTasks = new List<string>();
        }


        public string TeamName
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }


        }

        public ICollection<IEmployee> TeamMembers { get; private set; }

        public ICollection<string> TeamTasks { get; private set; }

    }
}
