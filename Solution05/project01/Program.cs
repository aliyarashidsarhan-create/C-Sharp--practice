using System.Globalization;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //aray of 4 number
            int[] Numbers = new int[4];

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine("Enter any number:");
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("***************************");
            foreach (int num in Numbers)
            {
                Console.WriteLine(num);
            }


















        }
    }
}
