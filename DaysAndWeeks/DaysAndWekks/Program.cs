using System.Text;
namespace WeeksExercise; 
public class WeeksAndDays
{   
    public static void Main(string[] args)
    {
        Console.WriteLine(DaysAndWeeks(13)); 
    }
    public static string DaysAndWeeks(int days)
    {
        int weeks = days / 7;
        int remainder = days % 7;
        return new StringBuilder().Append(weeks).Append(" week/s and ").Append(remainder).Append(" day/s").ToString();
    }
}