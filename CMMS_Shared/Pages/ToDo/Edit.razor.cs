using CMMS_Shared.Data.Models;
using CMMS_Shared.Services;
using Microsoft.AspNetCore.Components;

namespace CMMS_Shared.Pages.ToDo
{
    public partial class Edit
    {
        [Inject]
        protected ITodoService TodoService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int Id { get; set; }

        public Todo todo { get; set; }

        protected override async Task OnInitializedAsync()
        {
            todo = await TodoService.GetTodoById(Id);
        }

        private async void SubmitTodo()
        {
            await TodoService.UpdateTodo(todo);

            NavigationManager.NavigateTo("/todo");
        }
    }
}
