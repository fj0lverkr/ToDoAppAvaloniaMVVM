using System;

namespace ToDoApp.ViewModels {
    public class NewItemViewModel: ViewModelBase {
        public string Description { get; set; } = String.Empty;
    }
}