namespace TaskManager.User
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using User.Interfaces;

    public abstract class Person : IPerson
    {
        private const int GeneralLengthName = 2;
        private const int GeneralAgeValue = 18;
        private const string GeneralNullOrEmptyNameException = "Name cannot be null or empty";
        private const string GeneralNameLenghtMinValueException = "The name cannot be equal or less than 2 symbols";
        private const string GeneralPlaceHolderShablonToString = "Name: {0}, Date of Birth: {1}, Sex: {2}, Age: {3}";

        private string name;
        private DateTime dateBirth;

        public Gender Sex { get; private set; }

        public Person(string name, DateTime dateBirth, Gender sex)
        {
            this.Name = name;
            this.dateBirth = dateBirth;
            this.Sex = sex;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(GeneralNullOrEmptyNameException);
                }
                if (value.Count() <= GeneralLengthName)
                {
                    throw new ArgumentOutOfRangeException(GeneralNameLenghtMinValueException);
                }
                this.name = value;
            }
        }
        public DateTime DateBirth
        {
            get
            {
                return this.dateBirth;
            }
          
        }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - this.dateBirth.Year;
            }
            
        }
        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format(GeneralPlaceHolderShablonToString, this.Name, this.DateBirth.ToShortDateString(), this.Sex, this.Age));
            return result.ToString();
        }
    }
}
