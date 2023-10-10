using ToDoApp.Services;

namespace ToDoApp.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    //this has a dependency on the ToDoListService
    public ToDoListViewModel ToDoList { get; }

    public MainWindowViewModel(){
        ToDoService service = new();
        ToDoList = new(service.GetItems());
    }
}
