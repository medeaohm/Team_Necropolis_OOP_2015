/*
 * A repeated ToDo is a doDo which has to be completed more than once - i.e. for example weekly horoscope or something like that
 */

namespace TaskManager.Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;

    public class RepeadedToDo : ToDo, IRepeat
    {
    }
}
