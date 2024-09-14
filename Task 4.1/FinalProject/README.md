# Todo List MVC Application

This project is a simple MVC-based Todo List application built using ASP.NET Core MVC. It allows users to add, edit, and delete tasks (todos). Users can also mark tasks as completed or set deadlines for them.

## Features

- Add new tasks.
- Edit existing tasks.
- Mark tasks as completed or incomplete.
- Set deadlines for tasks.
- Delete tasks.
- View time left until a task's deadline.

## Technologies Used

- **ASP.NET Core MVC**: The framework for building the web application.
- **Entity Framework Core**: For database interaction.
- **SQL Server**: The database used to store todo tasks.
- **Bootstrap**: For UI styling and modal popups.

## Endpoints Documentation

### **GET** `/Todos/ShowAllTodoList`
- **Description**: Retrieves a list of all tasks (todos) from the database.
- **Returns**: A view displaying all the todo items.
- **View**: `Views/Todos/ShowAllTodos.cshtml`.

### **POST** `/Todos/SaveAddedTodo`
- **Description**: Adds a new task (todo) to the database.
- **Request Body**:
  - `Description`: The task description (string, required, min length of 5).
  - `IsCompleted`: Whether the task is completed or not (boolean).
  - `CreatedTime`: The task creation time (datetime).
  - `DueTime`: The deadline for the task (optional datetime).
- **Returns**: Redirects to `ShowAllTodoList` after saving the new todo.
- **View**: Used for adding new tasks via modal in `ShowAllTodos`.

### **POST** `/Todos/DeleteTodo`
- **Description**: Deletes a task by its `Id`.
- **Request Body**:
  - `Id`: The ID of the task to delete (integer).
- **Returns**: Redirects to `ShowAllTodoList` after deletion.

### **GET** `/Todos/OpenEditForm/{id}`
- **Description**: Opens the edit form for a specific task by its `Id`.
- **Returns**: A view with the current task information populated for editing.
- **View**: `Views/Todos/EditForm.cshtml`.

### **POST** `/Todos/SaveEditTodo/{Id}`
- **Description**: Saves changes made to an existing task.
- **Request Body**:
  - `Id`: The ID of the task to update (integer).
  - `Description`: The updated task description.
  - `IsCompleted`: The updated task completion status.
  - `CreatedTime`: The task creation time.
  - `DueTime`: The task due time (optional).
- **Returns**: Redirects to `ShowAllTodoList` after the changes are saved.

### **POST** `/Todos/UpdateTaskState`
- **Description**: Updates the completion state of a task (e.g., completed or not).
- **Request Body**:
  - `Id`: The ID of the task to update (integer).
  - `State`: The new state of the task (boolean, `true` or `false`).
- **Returns**: Redirects to `ShowAllTodoList` after updating the task state.

## Prerequisites

Before running the project, ensure you have the following installed:

1. **.NET SDK (8.0 or later)**: Download and install the [.NET SDK](https://dotnet.microsoft.com/download/dotnet) to build and run the project.
2. **Entity Framework Core**: Ensure you have Entity Framework Core installed for database migrations and interactions.
3. **SQL Server**: Make sure you have SQL Server installed for managing the database.
4. **NuGet Packages**: The project requires specific NuGet packages that should be installed.

## Required NuGet Packages

Make sure the following NuGet packages are installed in the project:

1. **Microsoft.EntityFrameworkCore.SqlServer**  
   This package allows Entity Framework Core to interact with a SQL Server database.
   ```bash
   dotnet add package Microsoft.EntityFrameworkCore.SqlServer

2. **Microsoft.EntityFrameworkCore.tools**  
   This package allows Entity Framework Core to interact with a SQL Server database.
   ```bash
   dotnet add package Microsoft.EntityFrameworkCore.tools

3. **Microsoft.EntityFrameworkCore**  
   This package allows Entity Framework Core to interact with a SQL Server database.
   ```bash
   dotnet add package Microsoft.EntityFrameworkCore
   
## Setup Instructions

### 1. Clone the Repository

```bash
git clone https://github.com/yourusername/todo-list-mvc.git
cd todo-list-mvc
