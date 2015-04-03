﻿namespace TaskManager.Task.Interfaces
{
    using System;
    using User.Interfaces;

    public interface IComment
    {
        string Content { get; }

        DateTime DateToCreate { get; }

        IPerson Author { get; }
    }
}
