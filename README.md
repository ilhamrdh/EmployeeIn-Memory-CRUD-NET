# EmployeeInMemoryCRUD

## Overview
**EmployeeInMemoryCRUD** is a simple console-based Employee Management System that performs basic CRUD (Create, Read, Update, Delete) operations. The application stores employee data in memory and allows users to add, display, and delete employee records. It is designed using clean code practices with proper validation and error handling.

## Features
- **In-memory storage**: No external database, all employee data is stored and managed in memory.
- **CRUD operations**:
  - **Add**: Add new employee data.
  - **Display**: View a formatted list of all employees in a clean, tabular format.
  - **Delete**: Remove an employee record by `EmployeeID`.
- **Validation**: 
  - Prevents adding duplicate `EmployeeID`.
  - Handles null and invalid inputs for employee fields.
  - Date validation ensures correct `BirthDate` entry.
- **Error Handling**: Graceful error messages for invalid operations, like deleting non-existent employees.

## Technology Stack
- **Language**: C#
- **Framework**: .NET
- **Data Storage**: In-memory using `Dictionary`

## Application Structure
The project follows a modular structure to maintain clean code practices and separation of concerns:
- **Models**: Defines the `Employee` model.
- **Interfaces**: Declares the interface `IEmployeeOperations` to define the contract for CRUD operations.
- **Services**: Contains the `EmployeeManager` class which implements CRUD operations.
- **Program.cs**: The entry point of the application that runs and interacts with the `EmployeeManager`.

### Directory Structure
```bash
EmployeeInMemoryCRUD/
├── Models/
│   └── Employee.cs          # Employee model definition
├── Interfaces/
│   └── IEmployeeOperations.cs # Interface for CRUD operations
├── Services/
│   └── EmployeeManager.cs   # CRUD operations implementation
└── Program.cs               # Main application entry point



## How to Run the Application

### Prerequisites
- **.NET SDK**: Make sure you have [.NET SDK](https://dotnet.microsoft.com/download) installed on your system.

### Steps
1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-username/EmployeeInMemoryCRUD.git
2. **Open With Visual Studio Code 2022**
	- Click icon start


### Explanation:
1. **Overview**: A brief description of the project.
2. **Features**: Highlights key functionality.
3. **Technology Stack**: Lists technologies used.
4. **Application Structure**: Explains how the project is organized.
5. **How to Run the Application**: Simple instructions to build and run the project.
6. **Usage**: Describes what happens when the app runs, with sample output.
7. **Future Enhancements**: Ideas for future improvements.
8. **License**: Licensing information (adjust if you have a different license).


