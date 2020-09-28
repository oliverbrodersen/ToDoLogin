using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public interface ITodosService
    {
        IList<Models.Todo> GetTodos(); 
        void AddTodo(Models.Todo todo); 
        void RemoveTodo(int todoId);
        void Update(Models.Todo todo);
    }
}
