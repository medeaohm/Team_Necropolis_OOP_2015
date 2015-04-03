namespace TaskManager.Common
{
    using System;

    public interface IValidation
    {
        void StringLengthMinMax(string value, int maxLength, int minLength, string errorMessage);

        void NotNegativeIntegers<T>(T integer, string param, string errorMessage) where T : struct, IComparable;

        void IntegerRange(int value, int max, int min, string errorMessage);

        void NotNullable(object obj, string param, string errorMessage);

       
    }
}
