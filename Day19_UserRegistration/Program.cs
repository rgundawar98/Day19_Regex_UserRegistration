using System;

namespace Day19_UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the regular expression");
            Console.WriteLine("1.First Name\n2.Last Name\n3.Email");
            Console.WriteLine("Choose option from above");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    UserDetails.Check_First_Name();
                    break;
                case 2:
                    UserDetails.Check_Last_Name();
                    break;
                case 3:
                    UserDetails.Check_For_Email();
                    break;
            }
        }
    }
}
