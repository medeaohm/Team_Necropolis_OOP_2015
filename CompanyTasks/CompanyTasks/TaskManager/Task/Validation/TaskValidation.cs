namespace TaskManager.Task.Validation
{
    using Common;
    using Validation;
    using Interfaces;

    using System;

    public class TaskValidation : CommonValidation, ITaskValidation
    {
        private const int TitleMinLenght = 3;
        private const int TitleMaxLenght = 30;
        private const int DescMinLenght = 20;
        private const int DescMaxLenght = 1000;

        private const string ErrMessNotNullable = "Subtask can not be found!";
        private const string ErrMessWhenDaysToEndIsNegativeInteger = "Days to end must be positive integer!";

        private readonly string ErrMessWhenTitleIsNevalid =
            string.Format("Title must be to less from {0} and to bigger from {1}", TitleMaxLenght, TitleMinLenght);

        private readonly string ErrMessWhenDescriptionIsNevalid =
            string.Format("Description must be to less from {0} and to bigger from {1}", DescMaxLenght, DescMinLenght);

        public void ValidateTitle(string value)
        {
            base.StringLengthMinMax(value, TitleMaxLenght, TitleMinLenght, ErrMessWhenTitleIsNevalid);
        }

        public void ValidateDescription(string value)
        {
            base.StringLengthMinMax(value, DescMaxLenght, DescMinLenght, ErrMessWhenDescriptionIsNevalid);
        }

        public void ValidateDaysToEnd(int value)
        {
            this.NotNegativeIntegers(value, "Days to end", ErrMessWhenDaysToEndIsNegativeInteger);
        }

        public void SubtaskNotFound(ISubtask subtask)
        {
            this.NotNullable(subtask,"Subtask", ErrMessNotNullable);
        }
    }
}
