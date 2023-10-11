using System;
using System.Reactive.Linq;
using ReactiveUI;
using ToDoApp.DataModel;
using ToDoApp.Services;

namespace ToDoApp.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _contentViewModel;
    //this has a dependency on the ToDoListService
    public ToDoListViewModel ToDoList { get; }

    public ViewModelBase ContentViewModel{
        get => _contentViewModel;
        private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
    }

    public MainWindowViewModel(){
        ToDoService service = new();
        ToDoList = new(service.GetItems());
        _contentViewModel = ToDoList;
    }

    public void AddItem() {
        NewItemViewModel newItemViewModel = new();
        Observable.Merge(
            newItemViewModel.OkCommand,
            newItemViewModel.CancelCommand.Select(_ => (ToDoItem?)null))
                .Take(1)
                .Subscribe(newItem =>
                {
                    if (newItem != null)
                    {
                        ToDoList.ListItems.Add(newItem);
                    }
                    ContentViewModel = ToDoList;
                });
        ContentViewModel = newItemViewModel;
    }
}
