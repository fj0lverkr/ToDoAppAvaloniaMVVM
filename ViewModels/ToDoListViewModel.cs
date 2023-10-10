using System.Collections.Generic;
using System.Collections.ObjectModel;
using ToDoApp.DataModel;

namespace ToDoApp.ViewModels {
    public class ToDoListViewModel: ViewModelBase {
        public ObservableCollection<ToDoItem> ListItems { get; }
        public ToDoListViewModel(IEnumerable<ToDoItem> items) {
            ListItems = new(items);
        }
    }
}