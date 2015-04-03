namespace TaskManager.Common
{
    using System;
    using System.Collections.Generic;

    using Exception;

    public abstract class CommonValidation : IValidation
    {
        public void StringLengthMinMax(string value, int maxLength, int minLength, string errorMessage)
        {
            var currentLength = value.Length;

            TryRangeMinMax(maxLength, minLength, errorMessage, currentLength);
        }

        public void NotNegativeIntegers<T>(T integer,string param, string errorMessage)  where T : struct, IComparable
        {
            if (integer.CompareTo(0) < 0)
            {
                throw new ArgumentOutOfRangeException(param, errorMessage);
            }
        }

        public void IntegerRange(int value, int max, int min, string errorMessage)
        {
            TryRangeMinMax(max, min, errorMessage, value);
        }

        public void NotNullable(object obj,string param, string errorMessage)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(param, errorMessage);
            }
        }

        private static void TryRangeMinMax(int maxLength, int minLength, string errorMessage, int currentLength)
        {
            if (currentLength > maxLength || currentLength < minLength)
            {
                throw new InvalidRangeException<int>(maxLength, minLength, errorMessage);
            }
        }
    }
}
