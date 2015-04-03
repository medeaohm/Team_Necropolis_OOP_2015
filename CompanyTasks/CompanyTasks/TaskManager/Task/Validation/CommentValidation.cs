
namespace TaskManager.Task.Validation
{
    using Common;

    public class CommentValidation : CommonValidation, ICommentValidation
    {
        private const int MaxContentLength = 600;
        private const int MinContentLenght = 10;
        private readonly string ErrMessWhenContentIsNevalid = 
            string.Format("Content must be to less from {0} or to bigger from {1}", MaxContentLength, MinContentLenght);


        public void ValidateContent(string value)
        {
            this.StringLengthMinMax(value,MaxContentLength,MinContentLenght,ErrMessWhenContentIsNevalid);
        }
    }
}
