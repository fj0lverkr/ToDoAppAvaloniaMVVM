using System;

namespace ToDoApp.DataModel
{
    public class ToDoItem
    {
        public string Description { get; set; } = string.Empty;
        public bool IsChecked { get; set; }
    }
}