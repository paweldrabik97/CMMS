using CMMS_Shared.Data.Models;

namespace CMMS_Shared.Services
{
    public interface ITodoService
    {
        Task<List<Todo>> GetTodos();
        Task<Todo> GetTodoById(int id);
        Task<Todo> CreateTodo(Todo todo);
        Task UpdateTodo(Todo todo);
        Task DeleteTodo(int id);
    }
}
