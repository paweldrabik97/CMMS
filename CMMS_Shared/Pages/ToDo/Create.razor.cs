using CMMS_Shared.Data.Models;
using CMMS_Shared.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMMS_Shared.Pages.ToDo
{
    public partial class Create
    {
        [Inject]
        protected ITodoService TodoService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public Todo todo { get; set; }

        protected override async Task OnInitializedAsync()
        {
            todo = new Todo();
        }

        private async void SubmitTodo()
        {
            todo.CreateDate = DateTime.Now;
            await TodoService.CreateTodo(todo);
            NavigationManager.NavigateTo("./todo");
        }
    }
}
