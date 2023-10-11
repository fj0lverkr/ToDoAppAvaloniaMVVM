using ReactiveUI;
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
        ContentViewModel = new NewItemViewModel();
    }
}
