namespace Movies;

public class MovieClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine(AvailableClassifications(11)); 
    }
    public static string AvailableClassifications(int ageOfViewer)
    {
        string result;
        if (ageOfViewer < 12)
        {
            result = "U, PG & 12 films are available.";
        }
        else if (ageOfViewer < 15)
        {
            result = "U, PG, 12 & 15 films are available.";
        }
        else
        {
            result = "All films are available.";
        }
        return result;
    }
}