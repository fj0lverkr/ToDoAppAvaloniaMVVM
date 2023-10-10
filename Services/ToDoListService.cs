using System.Collections.Generic;
using ToDoApp.DataModel;

namespace ToDoApp.Services {
    public class ToDoService {
        public IEnumerable<ToDoItem> GetItems() => new[] {
            new ToDoItem {Description="Feed the chickens"},
            new ToDoItem {Description="Buy milk"},
            new ToDoItem {Description="Start learning Avalonia", IsChecked=true},
        };
    }
}