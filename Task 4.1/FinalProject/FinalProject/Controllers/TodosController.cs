using FinalProject.Models;
using FinalProject.Models.MyContext;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class TodosController : Controller
    {
        public TodoContext ToDoContext = new TodoContext();

        // GET : All TODOS 
        // Deafult Index 
        public IActionResult ShowAllTodoList()
        {
            var List = ToDoContext.Todos.ToList();
            
            return View("ShowAllTodos",List);
        }

        public IActionResult SaveAddedTodo(Todo NewTodo)
        {
            if (ModelState.IsValid)
            {
                ToDoContext.Add(NewTodo);
                ToDoContext.SaveChanges();
            }
            return RedirectToAction("ShowAllTodoList");


            //return View();

            //TODO : MAKE THE Add OPERATION
        }

        public IActionResult DeleteTodo(int Id)
        {
            var TodoToRemove = ToDoContext.Todos.FirstOrDefault(t => t.Id == Id);
            if (TodoToRemove != null)
            {
                ToDoContext.Remove(TodoToRemove);
                ToDoContext.SaveChanges();
            }
            return RedirectToAction("ShowAllTodoList");
            //TODO : MAKE THE Delete OPERATION
        }


        public IActionResult OpenEditForm(int id)
        {
            
            var TodoItem = ToDoContext.Todos.FirstOrDefault(x => x.Id == id);
            return View("EditForm",TodoItem);
        }
        public IActionResult SaveEditTodo(int Id,Todo NewTodo)
        {
            var OldTodo = ToDoContext.Todos.FirstOrDefault(t=>t.Id == Id);//if the todo in table match the given [modify]
            OldTodo.Description = NewTodo.Description;
            OldTodo.DueTime = NewTodo.DueTime;
            OldTodo.CreatedTime = NewTodo.CreatedTime;
            OldTodo.IsCompleted = NewTodo.IsCompleted;

            ToDoContext.SaveChanges();

            return RedirectToAction("ShowAllTodoList");
            //TODO : MAKE THE EDIT OPERATION
        }
       

        public IActionResult UpdateTaskState(int Id , string State)
        {
            var TaskToUpdateState = ToDoContext.Todos.FirstOrDefault(t=>t.Id==Id);
            if (TaskToUpdateState != null)
            {
                TaskToUpdateState.IsCompleted = bool.Parse(State.ToLower());
            }

            ToDoContext.SaveChanges();

            return RedirectToAction("ShowAllTodoList");
        }



    }
}
