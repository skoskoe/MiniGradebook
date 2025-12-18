# Mini Gradebook – Refactored Version

## Description
This project is a refactored C# console application **“Mini Gradebook”**.  
The original program was functional but contained unclear variable names, duplicated logic, long methods, and magic numbers.  
The goal of the project was to improve **readability, structure, and maintainability** without changing the program’s behavior.

## Functionality
The application allows the user to:
1. Add a grade  
2. Display all grades  
3. Calculate the average grade  
4. Show statistics (count per grade and pass/fail percentages)  
5. Exit the program  

## Improvements Made
- Renamed variables to meaningful names (e.g. `g` → `grades`, `f` → `isRunning`)
- Extracted logic into smaller, clear methods
- Removed duplicated code
- Introduced constants for minimum and maximum grades
- Separated logic into a dedicated `GradeDiary` class

## Technologies
- Language: C#
- Type: Console Application
- Framework: .NET

## Notes
The refactoring was done **incrementally**, and after each change the application was compiled and tested to ensure identical behavior to the original version.
