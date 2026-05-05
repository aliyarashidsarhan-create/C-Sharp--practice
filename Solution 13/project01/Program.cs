using System.Runtime.CompilerServices;

namespace project01
{
    internal class Program
    {
        class Car
        {
            public string color;
            public int model_year {  get; set; }
            private int temp;
            public int Spead
            {
                get
                {
                    return temp;
                }
                set
                {
                    if (value >0)
                        temp = value;
                }
            }
            public void Drive()
            {
                Console.WriteLine("The car is driving...");
            }
        }
        static void Main(string[] args)
        {
            Car drive = new Car();
            drive.Spead = 10;
            Console.WriteLine( drive.Spead);
           
        }
    }
}
