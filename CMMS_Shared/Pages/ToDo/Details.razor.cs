using CMMS_Shared.Data.Models;
using CMMS_Shared.Services;
using Microsoft.AspNetCore.Components;


namespace CMMS_Shared.Pages.ToDo
{
    public partial class Details
    {
        [Inject]
        protected ITodoService TodoService { get; set; }

        [Parameter]
        public int Id { get; set; }

        public Todo Todo { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Todo = await TodoService.GetTodoById(Id);
        }
    }
}
