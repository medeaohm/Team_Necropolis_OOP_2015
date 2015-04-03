namespace TaskManager.Common
{
    using System;

    public interface IValidation
    {
        void StringLengthMinMax(string value,string param, int maxLength, int minLength);

        void NotNegativeIntegers<T>(T integer, string param) where T : struct, IComparable;

        void IntegerRange(int value, int max, int min, string errorMessage);

        void NotNullable(object obj, string param);
       
    }
}
