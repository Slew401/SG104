using System.Collections.Generic;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {
            if (nums.Count == 0) return 0;
            double avg = 0;
            foreach (int num in nums)
            {
                avg += num;
            }
            return avg / nums.Count;
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            string ticketType;
            if (age < 5)
            {
                ticketType = "Free"; 
            }
            else if (age >= 5 && age < 13)
            {
                ticketType = "Child";
            }
            else if (age >= 13 && age < 18)
            {
                ticketType = "Student";
            }
            else if (age >= 18 && age < 60)
            {
                ticketType = "Standard";
            }
            else
            {
                ticketType = "OAP"; 
            }
            
            return ticketType;
        }

        public static string Grade(int mark)
        {
            var grade = "";
            return grade;
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            return 0;
        }
    }
}
