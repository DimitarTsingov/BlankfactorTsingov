using System;
using System.Collections.Generic;
using System.Linq;

class StudentDataManagementSystem
{

    public Dictionary<string, Dictionary<string, List<double>>> students = new();

    public HashSet<string> subjects = new()
    {
        "Math", "Biology", "History", "English", "Sport", "Physics"
    };

    public void AddStudent()
    {
        Console.Write("Enter the name of the student: ");
        string studentName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(studentName))
        {
            Console.WriteLine("The name of the student can't be empty.");
            return;
        }

        if (students.ContainsKey(studentName))
        {
            Console.WriteLine($"Student {studentName} already exists.");
            return;
        }

        students[studentName] = new Dictionary<string, List<double>>();
        Console.WriteLine($"This student is added successfully: {studentName}!");
    }

    public void RemoveStudent()
    {
        Console.Write("Enter the name of the student you want to remove: ");
        string studentName = Console.ReadLine();

        if (students.Remove(studentName))
        {
            Console.WriteLine($"This student is removed successfully {studentName}!");
        }
        else
        {
            Console.WriteLine($"This student does not exist: {studentName}!");
        }
    }

    public void AssignStudentToSubject()
    {
        Console.Write("Enter the student and subject: ");
        string input = Console.ReadLine();

        var parts = input.Split('-');
        if (parts.Length != 2)
        {
            Console.WriteLine("Invalid format. Please use this format {StudentName}-{Subject}.");
            return;
        }

        string studentName = parts[0].Trim();

        string subject = parts[1].Trim();

        if (!students.ContainsKey(studentName))
        {
            Console.WriteLine($"This Student does not exist: {studentName}!");
            return;
        }

        if (!subjects.Contains(subject))
        {
            Console.WriteLine($"The following subject is not valid: {subject}!");
            return;
        }

        if (!students[studentName].ContainsKey(subject))
        {
            students[studentName][subject] = new List<double>();
            Console.WriteLine($"The student {studentName} has been successfully enrolled in this class: {subject}!");
        }
        else
        {
            Console.WriteLine($"The student {studentName} is already enrolled in {subject}!");
        }
    }
    public void UpdateStudentGrades()
    {
        Console.Write("Enter the student name: ");
        string studentName = Console.ReadLine();

        if (!students.ContainsKey(studentName))
        {
            Console.WriteLine($"This student does not exist: {studentName}!");
            return;
        }

        Console.WriteLine($"Enter the grades for {studentName} in the format: {{Subject name}}-{{grade}} (type 'done' to finish):");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done") break;

            var parts = input.Split('-');
            if (parts.Length != 2)
            {
                Console.WriteLine("Invalid format. Please use this formaat: {Subject}-{Grade}.");
                continue;
            }

            string subject = parts[0].Trim();
            if (!subjects.Contains(subject))
            {
                Console.WriteLine($"This subject is not allowed: {subject}!");
                continue;
            }

            if (!double.TryParse(parts[1].Trim(), out double grade) || grade < 2 || grade > 6)
            {
                Console.WriteLine("Invalid grade. It should be a number between 2 and 6.");
                continue;
            }

            if (!students[studentName].ContainsKey(subject))
            {
                Console.WriteLine($"The student {studentName} is not enrolled in {subject}.");
                continue;
            }

            students[studentName][subject].Add(grade);
            Console.WriteLine($"The grade {grade} is added for {subject}.");
        }
    }

    public void DisplayAllStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("There are no students to display.");
            return;
        }

        Console.WriteLine("\nDisplaying all students:");
        foreach (var student in students)
        {
            string name = student.Key;
            var subjects = student.Value;

            var subjectList = string.Join(", ", subjects.Keys);
            double averageGrade = subjects.Values.SelectMany(g => g).DefaultIfEmpty(0).Average();

            Console.WriteLine($"  {name}, Subjects: {subjectList}");
            Console.WriteLine($"  Average Grade: {averageGrade:F2}");
        }
    }

    public void Run()
    {
        Console.WriteLine("Welcome to the Student Data Management System!");

        while (true)
        {
            Console.WriteLine("\n Choose an option:");
            Console.WriteLine("1. Add a new student:");
            Console.WriteLine("2. Remove a student:");
            Console.WriteLine("3. Assign student to subject:");
            Console.WriteLine("4. Update a student's grades:");
            Console.WriteLine("5. Display all students:");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    RemoveStudent();
                    break;
                case "3":
                    AssignStudentToSubject();
                    break;
                case "4":
                    UpdateStudentGrades();
                    break;
                case "5":
                    DisplayAllStudents();
                    break;
                case "6":
                    Console.WriteLine("Exiting the system. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Wrong choice. Try again!");
                    break;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        var system = new StudentDataManagementSystem();
        system.Run();
    }
}


