using TodoREST.Models;
using TodoREST.Services;
using TodoREST.ViewModels;

namespace TodoREST.Views;

public partial class TodoItemPage : ContentPage
{
    public TodoItemPage(TodoItemViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

}
