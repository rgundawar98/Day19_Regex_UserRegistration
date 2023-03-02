﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_UserRegistration
{
    public class Password
    {
        public static void Check_Password_has_8Character()
        {
            string pattern = "^[A-Za-z0-9$,@,#,&,*].{8,}$";
            string[] Passwords = {"RAHULg@1234","Isaih@123","Siva@1235","hae123"};
            foreach (string Passwd in Passwords)
            {
                if(Regex.IsMatch(Passwd, pattern))
                {
                    Console.WriteLine("{0} is valid ",Passwd);
                }
                else
                {
                    Console.WriteLine("{0} is not valid", Passwd);
                }
            }
        }
    }
}
