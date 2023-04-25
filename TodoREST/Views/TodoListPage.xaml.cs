using TodoREST.ViewModels;

namespace TodoREST.Views
{
    public partial class TodoListPage : ContentPage
    {
        //private readonly TodoListViewModel _todoListViewModel;
        public TodoListPage(TodoListViewModel todoListViewModel)
        {
            InitializeComponent();
            //_todoListViewModel = todoListViewModel;
            BindingContext = todoListViewModel;
        }

        //protected async override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    await _todoListViewModel.RefreshTodoItems();
        //}

    }
}
