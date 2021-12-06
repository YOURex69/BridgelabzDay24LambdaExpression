using System;

namespace LambdaExpressionRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------*Registration form*--------");
            Console.WriteLine("Enter choice between 1-8");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("First Name(First letter  capital)");
                    string FistName = Console.ReadLine();
                    if (!isValid.checkFirstName(FistName))
                    {
                        Console.WriteLine("enter valid name");

                    }
                    break;


                case 2:
                    Console.WriteLine("First Name(First letter capital)");
                    string LastName = Console.ReadLine();
                    if (!isValid.checkLastName(LastName))
                    {
                        Console.WriteLine(" invalid last name");

                    }
                    break;

                case 3:
                    Console.WriteLine("Enter the eMail");
                    string MailId = Console.ReadLine();
                    if (!isValid.checkEmail(MailId))
                    {
                        Console.WriteLine(" invalid");

                    }
                    break;
                case 4:
                    Console.WriteLine("Enter the Mobil number");
                    string MobileNumber = Console.ReadLine();
                    if (!isValid.checkMobile(MobileNumber))
                    {
                        Console.WriteLine("Mobile number is invalid");

                    }
                    break;
                case 5:
                    Console.WriteLine("Enter the Password(enter min 8 charector)");
                    string Password = Console.ReadLine();
                    if (!isValid.checkPassword(Password))
                    {
                        Console.WriteLine(" invalid password");

                    }
                    break;
                case 6:
                    Console.WriteLine("Enter the Password");
                    string Password1 = Console.ReadLine();
                    if (!isValid.checkPassword1(Password1))
                    {
                        Console.WriteLine(" invalid password");

                    }
                    break;
                case 7:
                    Console.WriteLine("Enter the Password(");
                    string Password2 = Console.ReadLine();
                    if (!isValid.checkPassword2(Password2))
                    {
                        Console.WriteLine(" invalid password");

                    }
                    break;
                case 8:
                    Console.WriteLine("Enter the Password");
                    string Password3 = Console.ReadLine();
                    if (!isValid.checkPassword3(Password3))
                    {
                        Console.WriteLine(" invalid password");

                    }
                    break;
            }
    }
}
