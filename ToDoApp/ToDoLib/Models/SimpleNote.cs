    // Summary:
    //     Represents a Simple Note with tags
    //     Provides methods to add and remove tags
    //
    // Type parameters:
    //   string title , string text, List<strings> tags
namespace ToDoLib.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class SimpleNote
    {
        private string title;
        private string noteText;
        private DateTime dateCreated;
        List<string> tags = new List<string>();

        public SimpleNote(string title, string text)
        {
            this.Title = title;
            this.NoteText = text;
            this.dateCreated = DateTime.Now;
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string NoteText
        {
            get { return this.noteText; }
            set { this.noteText = value; }
        }

        public void AddTag(string anyTag)
        {
            if (CheckForExisting(anyTag))
            {
                throw new ArgumentException("Duplicate tag");
            }

            this.tags.Add(anyTag);
        }

        public void RemoveTag(string anyTag)
        {
            if (!this.tags.Remove(anyTag))
            {
                throw new ArgumentException("The tag does not exist");
            }
        }

        public IList GetListOfTags()
        {
            return new List<string>(this.tags); //returns deep copy
        }

        private bool CheckForExisting(string someText)
        {
            bool exist = false;
            foreach (var tag in this.tags)
            {
                if (tag.Equals(someText, StringComparison.OrdinalIgnoreCase))
                {
                    exist = true;
                }
            }

            return exist;
        }
    }
}