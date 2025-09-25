using System;

class StudentDailyReport
{
    static void Main()
    {
        // Print the header of the report
        Console.WriteLine("Academy of Learning Career College");
        Console.WriteLine("Student Daily Report.");

        // Ask for the student's name and store it in a string variable
        Console.Write("What is your name? ");
        string studentName = Console.ReadLine();

        // Ask for the course name and store it in a string variable
        Console.Write("What course are you on? ");
        string courseName = Console.ReadLine();

        // Ask for the current page number and store it in an integer variable
        Console.Write("What page number? ");
        int pageNumber = Convert.ToInt32(Console.ReadLine());

        // Ask if the student needs help and store the response in a boolean variable
        Console.Write("Do you need help with anything? Please answer \"true\" or \"false\": ");
        bool needsHelp = Convert.ToBoolean(Console.ReadLine());

        // Ask for any positive experiences and store it in a string variable
        Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
        string positiveExperience = Console.ReadLine();

        // Ask for any other feedback and store it in a string variable
        Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
        string otherFeedback = Console.ReadLine();

        // Ask for the number of hours studied and store it in a float variable
        Console.Write("How many hours did you study today? ");
        float hoursStudied = float.Parse(Console.ReadLine());

        // Print the closing message
        Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
    }
}
