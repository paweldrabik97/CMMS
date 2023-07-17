using CMMS_Shared.Data.Models;
using CMMS_Shared.Services;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;



namespace CMMS_Shared.Pages.ToDo
{
    public partial class Index
    {
        [Inject]
        protected ITodoService TodoService { get; set; }

        private List<Todo> Todos { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Todos = await TodoService.GetTodos();
        }

        public async Task DeleteTodo(int todoId)
        {
            var todo = await TodoService.GetTodoById(todoId);

            if (todo != null)
            {
                await TodoService.DeleteTodo(todoId);

                Todos.RemoveAll(x => x.Id == todoId);
            }
        }


        
    }
}
