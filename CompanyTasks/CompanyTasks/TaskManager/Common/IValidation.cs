namespace TaskManager.Common
{
    public interface IValidation
    {
        void StringLengthMinMax(int maxLength, int minLength, string errorMessage);
    }
}
