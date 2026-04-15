using System.ComponentModel.DataAnnotations;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Task1 :
            //Console.WriteLine("Enter a number ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number > 0)
            //{
            //    Console.WriteLine("Positive ");
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine(" Negative ");
            //}
            //else if (number == 0) {

            //    Console.WriteLine(" Zero");
            //}


            //Task 2:
            //Console.WriteLine("Enter a number ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Even Number");
            //}
            //else
            //{
            //    Console.WriteLine("Odd Number");
            //}

            //Task3:
            //Console.WriteLine("Enter Student Score ");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score >= 90 && score <= 100)
            //{
            //    Console.WriteLine("Excellent");
            //}
            //else if (score >=75 && score <=89)
            //{
            //    Console.WriteLine("Very Good");
            //}
            //else if (score >= 60 && score <= 74)
            //{
            //    Console.WriteLine(" Good");
            //}
            //else if (score >=50 && score <=59)
            //{
            //    Console.WriteLine(" Pass");
            //}
            //else if (score <50)
            //{
            //    Console.WriteLine("Fail");
            //}
            //else
            //{
            //    Console.WriteLine("Enter valiad Score");
            //}

            //Task4:
            //string CorrectUserName = "admin";
            //string CorrectPassword = "1234";

            //Console.WriteLine("Enter User Name");
            //string username = Console.ReadLine();

            //Console.WriteLine("Enter User Password");
            //string password = Console.ReadLine();

            //if (username == CorrectUserName || password == CorrectPassword)
            //{
            //    Console.WriteLine("Login Successful");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid username or password");
            //}

            //Task5
            //int balance = 1000;
            //Console.WriteLine("Your balance is" + balance);
            //Console.WriteLine("Enter withdrawal amount");

            //int amount = Convert.ToInt32(Console.ReadLine());
            //if (amount <= 0)

            //{
            //    Console.WriteLine("Invalid amount");
            //}
            //else if (amount > balance)
            //{
            //    Console.WriteLine("Insufficient Balance");

            //}
            //else
            //{
            //    balance -= amount;
            //    Console.WriteLine("Withdrawal Successful");
            //    Console.WriteLine("Remaining Balance: " + balance);
            //}



            //Task 1 – Day Name Printer
            //Console.WriteLine("Enter a number from 1 to 7: ");
            //int dayNumber = Convert.ToInt32(Console.ReadLine());
            //switch (dayNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;

            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;

            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:

            //        Console.WriteLine("Invalid day number");
            //        break;
            //}


            //Task 2 – Multiplication Table
            //Console.WriteLine("Enter a Number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{number} x {i}={number * i}");
            //}


            //Task 3 – Countdown Timer
            //Console.WriteLine("Enter a positive Number: ");
            //int number=Convert.ToInt32(Console.ReadLine());
            //if (number <= 0)
            //{
            //    Console.WriteLine("Please enter a positive number");
            //}
            //else
            //{
            //    while (number >= 1)
            //    {
            //        Console.WriteLine(number);
            //        number--;
            //    }
            //    Console.WriteLine("Go!");
            //}


            //Task 4 – Season Detector with Month Validation
            //Console.WriteLine("Enter Month number: ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //switch (month)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Winter");
            //        break;

            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Spring");
            //        break;

            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("Summer");
            //        break;

            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("Autumn");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid month number");
            //        break;
            //}


            //Task 5 – Sum of Even and Odd Numbers
            Console.WriteLine("Enter a positive integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive integer");
            }
            else
            {
                int evenSum = 0;
                int oddSum = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenSum += i;
                    }
                    else
                    {
                        oddSum += i;
                    }
                }
                Console.WriteLine($"Sum of even number ={evenSum}");
                Console.WriteLine($"Sum of odd number ={oddSum}");
            }

        }
    }
}
