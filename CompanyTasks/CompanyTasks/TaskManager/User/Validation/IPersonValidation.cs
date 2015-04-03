namespace TaskManager.User.Validation
{
    public interface IPersonValidation
    {
        void ValidateName(string value);

        void ValidateDateOfBirth(System.DateTime value);

        void ValidateSalary(decimal value);

        void ValidateTimeWorked(int value);
    }
}
