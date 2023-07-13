using CMMS_Shared.Data;
using CMMS_Shared.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CMMS_Shared.Services
{
    public class TodoService : ITodoService
    {

        private readonly SystemDbContext _context;

        public TodoService(SystemDbContext context)
        {
            _context = context;
        }






        public async Task<Todo> CreateTodo(Todo todo)
        {
            _context.Todos.Add(todo);
            await _context.SaveChangesAsync();
            return todo;
        }

        public async Task DeleteTodo(int id)
        {
            Todo? todo = _context.Todos.FirstOrDefault(x => x.Id == id);

            if (todo != null)
            {
                _context.Todos.Remove(todo);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public async Task<Todo> GetTodoById(int id)
        {
            return await _context.Todos.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<List<Todo>> GetTodos()
        {
            return await _context.Todos.ToListAsync();
        }

        public async Task UpdateTodo(Todo todo)
        {
            _context.Todos.Update(todo);
            await _context.SaveChangesAsync();
        }


















        //private IDbContextFactory<SystemDbContext> _dbContextFactory;


        //public TodoService(IDbContextFactory<SystemDbContext> dbContextFactory)
        //{
        //    _dbContextFactory = dbContextFactory;
        //}

        //public void AddTodo(Todo todo)
        //{
        //    using (var context = _dbContextFactory.CreateDbContext())
        //    {
        //        context.Todos.Add(todo);
        //        context.SaveChanges();
        //    }
        //}

        //public async Task<Todo?> GetTodoById(int todoId)
        //{
        //    using (var context = _dbContextFactory.CreateDbContext())
        //    {
        //        var dbTodo = await context.Todos.SingleOrDefault(x => x.Id == todoId);
        //        return dbTodo;
        //    }
        //}

    }
}
