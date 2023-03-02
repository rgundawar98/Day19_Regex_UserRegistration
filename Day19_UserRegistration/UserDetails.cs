using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_UserRegistration
{
    public class UserDetails
    {
        public static void Check_First_Name()
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            string[] names = { "Ram", "Suraj", "Shweta", "Manish", "Rahul", "Siva","vaibhav" };
            foreach(string Name in names)
            {
                if(Regex.IsMatch(Name , pattern))
                {
                    Console.WriteLine("{0} is valid",Name);
                }
                else
                {
                    Console.WriteLine("{0} is not valid", Name);
                }
            }
        }
        public static void Check_Last_Name()
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            string[] LastName = { "Goyenka", "Gill", "Sehwag", "peter", "Hussy" };
            foreach(string LName in LastName)
            {
                if(Regex.IsMatch(LName, pattern))
                {
                    Console.WriteLine("{0} is valid",LName);
                }
                else 
                {
                    Console.WriteLine("{0} is not valid",LName); 
                }
            }
        }
        public static void Check_For_Email()
        {
            string pattern = "^[a-z]{3}?([.][a-z0-9]{3})@[a-z]{2,}[.][a-z]{2,}?([.][a-z]{2})?$";
            string[] ForEmail = {"abc.xyz@bl.co.in", "rahul.abc@yahoo.com", "Siva.xyz@mail.com","xyz@bb.co.in" };
            foreach(string Email in ForEmail)
            {
                if(Regex.IsMatch(Email,pattern))
                {
                    Console.WriteLine("{0} is valid", Email);
                }
                else
                {
                    Console.WriteLine("{0} is not valid", Email);
                }
            }
        }
        public static void Check_For_MobileNumber()
        {
            string pattern = "^[0-9]{2}[ ][0-9]{10}$";
            string[] MobileNumbers = { "91 8087905735", "91 8421719373", "64 1234667890", "91 9970009212","91 528852879"};
            foreach(string Number in MobileNumbers)
            {
                if(Regex.IsMatch(Number,pattern))
                {
                    Console.WriteLine("{0} is valid",Number);
                }
                else
                {
                    Console.WriteLine("{0} is not valid", Number);
                }
            }
        }
    }
}
