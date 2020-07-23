using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProgressiveWebApp
{
    public class TodoItem
    {
        public string Title { get; set; }
        public bool isDone { get; set; }

        public TodoItem(string title, bool done)
        {
            Title = title;
            isDone = done;
        }
    }
}
