# IEEE-CS-backend

# Task 3.2 API Documentation

## Overview

This API allows basic CRUD (Create, Read, Update, Delete) operations on a **Users** table stored in an SQLite database. The API is built using **ASP.NET Web API** and Entity Framework.

### Table of Contents
1. [Prerequisites](#prerequisites)
2. [Setup Instructions](#setup-instructions)
3. [Database Schema](#database-schema)
4. [API Endpoints](#api-endpoints)
5. [Error Handling](#error-handling)
6. [Running the Application](#running-the-application)

---

## Prerequisites

Before running this project, ensure you have the following:
- .NET Framework installed
- SQLServer database (pre-configured)
- NuGet packages:
  - EntityFramework
  - System.Data.SQLServer
  - Microsoft.AspNet.WebApi

## Setup Instructions

1. Clone the repository:
   ```bash
   git clone https://github.com/your-repository/task-3.2.git
   ```

2. Navigate to the project directory:
   ```bash
   cd task-3.2
   ```

3. Restore the NuGet packages:
   ```bash
   nuget restore
   ```

4. Ensure the SQServer database is created and located at the specified path in the `Web.config` file.

5. Build and run the project in Visual Studio.

---

## Database Schema

This API interacts with a SQlServer database containing a `users` table with the following schema:

| Column Name | Data Type | Description          |
|-------------|------------|----------------------|
| `id`        | INTEGER    | Primary Key, Auto Increment |
| `name`      | TEXT       | User's name          |
| `email`     | TEXT       | User's email         |

Example of the SQL query to create this table:
```sql
CREATE TABLE users (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT NOT NULL,
    email TEXT NOT NULL
);
```

---

## API Endpoints

### Base URL
The base URL for all endpoints is:
```
/api/users
```

### Endpoints Description

1. **Create a User**
   - **Method**: `POST`
   - **Endpoint**: `/api/users`
   - **Description**: Adds a new user to the database.
   - **Request Body**:
     ```json
     {
       "name": "John Doe",
       "email": "johndoe@example.com"
     }
     ```
   - **Response**: Returns the newly created user.
     ```json
     {
       "id": 1,
       "name": "John Doe",
       "email": "johndoe@example.com"
     }
     ```

2. **Retrieve All Users**
   - **Method**: `GET`
   - **Endpoint**: `/api/users`
   - **Description**: Retrieves a list of all users.
   - **Response**:
     ```json
     [
       {
         "id": 1,
         "name": "John Doe",
         "email": "johndoe@example.com"
       },
       {
         "id": 2,
         "name": "Jane Smith",
         "email": "janesmith@example.com"
       }
     ]
     ```

3. **Retrieve a User by ID**
   - **Method**: `GET`
   - **Endpoint**: `/api/users/{id}`
   - **Description**: Retrieves a single user by their ID.
   - **Response**:
     ```json
     {
       "id": 1,
       "name": "John Doe",
       "email": "johndoe@example.com"
     }
     ```

4. **Update a User**
   - **Method**: `PUT`
   - **Endpoint**: `/api/users/{id}`
   - **Description**: Updates the information of an existing user by ID.
   - **Request Body**:
     ```json
     {
       "name": "John Updated",
       "email": "johnupdated@example.com"
     }
     ```
   - **Response**: Returns the updated user.
     ```json
     {
       "id": 1,
       "name": "John Updated",
       "email": "johnupdated@example.com"
     }
     ```

5. **Delete a User**
   - **Method**: `DELETE`
   - **Endpoint**: `/api/users/{id}`
   - **Description**: Deletes a user from the database by ID.
   - **Response**: Returns a success message:
     ```json
     {
       "message": "User deleted successfully"
     }
     ```

---

## Error Handling
- `400 Bad Request`: If the input data is invalid.
- `404 Not Found`: If the user with the specified ID does not exist.
- `500 Internal Server Error`: If an error occurs on the server.
---

## Running the Application

To run the application:
1. Open the project in **Visual Studio**.
2. Build the solution.
3. Start the application (press `F5` or click on **Run**).
4. Use tools like **Postman** or **cURL** to interact with the API.
---
