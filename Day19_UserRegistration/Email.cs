using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_UserRegistration
{
    public class Email
    {
        public static void Check_email()
        {
            string pattern = "^[a-z0-9]{3,}?([-,.,+][a-z0-9]{1,})*@[a-z0-9]{1,}.(com|com.au|net|co.in|com.com)$";
            string[] Email = {"abc@yahoo.com", "abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com",
                "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com","abc+100@gmail.com",
                "abc","abc@.com.my","abc123@gmail.a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com",
                "abc@%*.com","abc..2002@gmail.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a","abc@gmail.com.aa.au"};
            foreach (var emails in Email)
            {
                if(Regex.IsMatch(emails,pattern))
                {
                    Console.WriteLine("{0} is valid",emails);
                }
                else
                {
                    Console.WriteLine("{0} is not valid", emails);
                }
            }
        }
    }
}
