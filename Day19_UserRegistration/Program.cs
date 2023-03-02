using System;

namespace Day19_UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the regular expression");
            Console.WriteLine("1.First Name\n2.Last Name\n3.Email\n4.Mobile Number\n5.Password\n6.Password Have One UpperCase" +
                "\n7.Password Have One Numeric Number\n8.Password Must Have One Special Character\n9.Check Email");
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
                case 4:
                    UserDetails.Check_For_MobileNumber();
                    break;
                case 5:
                    Password.Check_Password_has_8Character();
                    break;
                case 6:
                    Password.Password_Must_Have_One_Upper_Case();
                    break;
                case 7:
                    Password.Password_Have_One_Numeric_Number();
                    break;
                case 8:
                    Password.Password_Must_Have_One_Special_Character();
                    break;
                case 9:
                    Email.Check_email();
                    break;
            }
        }
    }
}
