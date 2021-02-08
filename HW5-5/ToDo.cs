using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_5
{
    class ToDo
    {
        public bool IsDone { get; set; }
        public string Title { get; set; }
        public ToDo(string title)
        {
            Title = title;
            IsDone = false;
        }
        public ToDo(string Title, bool IsDone)
        {
            this.Title = Title;
            this.IsDone = IsDone;
        }
        public ToDo()
        {

        }
        public void ChangeIsDone() => IsDone=!IsDone;
    }
}
