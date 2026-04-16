namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1-use for to take num from user
            //for (int i = 1; i < 5; i++)
            //{

            //    Console.WriteLine("Enter Number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("number  "+ num);
            //}


            // 2-print num like this (1,1) until (5,5)
            //for (int x = 1; x <= 5; x++)
            //{
            //    for (int i = 1; i <= 5; i++)
            //    {
            //        Console.WriteLine($"({ x},{ i})");
            //    }

            //}


            //3-take num from user check if it prime or not 
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            for (int i = 2; i < num ; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break; 
                }
            }

            
            if (isPrime )
                Console.WriteLine("Prime Num");
            else
                Console.WriteLine("Not Prime Num");










        }
    }
}
