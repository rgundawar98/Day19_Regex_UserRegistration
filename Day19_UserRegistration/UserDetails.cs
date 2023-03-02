﻿using System;
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
    }
}
