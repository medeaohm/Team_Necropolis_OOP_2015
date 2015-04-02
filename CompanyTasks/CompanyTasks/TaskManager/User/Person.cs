namespace TaskManager.User
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Person
    {
        private const int GeneralLengthName = 2;
        private const int GeneralAgeValue = 18;

        private string name;
        private string dateBirth;
        private byte age;

        public Gender Sex { get; set; }

        public Person(string name, string dateBirth, Gender sex, byte age)
        {
            this.Name = name;
            this.DateBirth = dateBirth;
            this.Sex = sex;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                if (value.Count() <= GeneralLengthName)
                {
                    throw new ArgumentOutOfRangeException("The name cannot be equal or less than 2 symbols");
                }
                this.name = value;
            }
        }
        public string DateBirth
        {
            get
            {
                return this.dateBirth;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Date birdth cannot be null or empty");
                }
                this.dateBirth = value;
            }
        }
        public byte Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < GeneralAgeValue)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be less than 18");
                }
                this.age = value;
            }
        }
        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format("Name: {0}, Date of Birth: {1}, Sex: {2}, Age: {3}", this.Name, this.DateBirth, this.Sex, this.Age));
            return result.ToString();
        }
    }
}
