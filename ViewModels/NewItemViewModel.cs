using System;
using System.Reactive;
using ReactiveUI;
using ToDoApp.DataModel;

namespace ToDoApp.ViewModels {
    public class NewItemViewModel: ViewModelBase {

        private string _description = String.Empty;

        public ReactiveCommand<Unit, ToDoItem> OkCommand { get; }
        public ReactiveCommand<Unit, Unit> CancelCommand { get; }
        public string Description {
            get => _description;
            set => this.RaiseAndSetIfChanged(ref _description, value);
            }

        public NewItemViewModel() {
            var isValidObservable = this.WhenAnyValue(
                x => x.Description,
                x => !string.IsNullOrWhiteSpace(x) 
            );

            OkCommand = ReactiveCommand.Create(() => new ToDoItem {Description = Description}, isValidObservable);
            CancelCommand = ReactiveCommand.Create(() => {});
        }
    }
}