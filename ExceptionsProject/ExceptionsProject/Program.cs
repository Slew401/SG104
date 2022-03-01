using System;

namespace ExceptionProject;

public class Program
{
    public static void Main(string[] args)
    {
        //string text;
        //string fileName = "HelloWorld.txt";

        //try
        //{
        //    text = File.ReadAllText(fileName);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Sorry, File Not Found: " + fileName);
        //}
        //finally
        //{
        //    Console.Write("I alwasy run");
        //}
        //Must specificy type of exception. 
        try
        {
            Console.WriteLine(Grade(90));
            Console.WriteLine(Grade(-1));
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Invalid Data");
            Console.WriteLine(ex.Message);
        }
    }

    public static string Grade(int mark)
    {
        if (mark < 0 || mark > 100) throw new ArgumentOutOfRangeException("Mark must be between 0 and 100 inclusive");
        return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
    }
}