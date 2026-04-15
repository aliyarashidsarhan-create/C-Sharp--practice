namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("Please Enter First Number!");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Second Number!");
            int num2 = Convert.ToInt32(Console.ReadLine());
            //sum
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

            //min
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");

            //mul
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");

            //div
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");

        }
    }
}
