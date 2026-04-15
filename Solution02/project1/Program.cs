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
            int balance = 1000;
            Console.WriteLine("Your balance is" + balance);
            Console.WriteLine("Enter withdrawal amount");

            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount <= 0)

            {
                Console.WriteLine("Invalid amount");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient Balance");

            }
            else
            {
                balance -= amount;
                Console.WriteLine("Withdrawal Successful");
                Console.WriteLine("Remaining Balance: " + balance);
            }

        }
    }
}
