namespace VowelCounter;

public class Vowels
{
    public static void Main(string[] args)
    {
        Console.WriteLine(countVowels("Hello, World!"));
        Console.WriteLine(countVowels("Boopadadjdpqeqcikaksdasldasd"));
    }

    public static int countVowels(string str)
    {
        int res = 0;
        char[] arr = str.ToLower().ToCharArray();
        foreach (char c in arr)
        {
            if (c.Equals('a') || c.Equals('e') || c.Equals('i') || c.Equals('o') || c.Equals('u'))
            {
                res++;
            }
        }
        return res;
    }
}