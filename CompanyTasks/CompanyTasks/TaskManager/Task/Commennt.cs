namespace TaskManager.Task
{
    using System;

    using Interfaces;
    using Validation;
    using User.Interfaces;

    public class Commennt : IComment
    {
        private readonly ICommentValidation validation;

        private string content;

        public Commennt(string initContent, IPerson person)
        {
            this.Content = initContent;
            this.DateToCreate = DateTime.Now;
            this.Author = person;

            this.validation = new CommentValidation();
        }

        public string Content
        {
            get
            {
                return this.content;
            }

            private set
            {
                this.validation.ValidateContent(value);

                this.content = value;
            }
        }

        public DateTime DateToCreate { get; private set; }

        public IPerson Author { get; private set; }
    }
}
