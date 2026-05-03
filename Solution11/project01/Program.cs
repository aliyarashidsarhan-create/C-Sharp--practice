namespace project01
{
    internal class Program
    {
        // 2 numbers → SUM
        int Calculate(int a, int b)
        {
            return a + b;
        }
        // 3 numbers → MULTIPLY
        double Calculate(double a, double b)
        {
            return a * b ;
        }
        // 4 numbers → SUM
        int Calculate(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
        static void Main(string[] args)
        {


            #region Task 1


            Program obj = new Program(); 

            Console.WriteLine(obj.Calculate(2, 3));
            Console.WriteLine(obj.Calculate(2, 3));
            Console.WriteLine(obj.Calculate(2, 3, 4, 5));




            #endregion



        }
    }
}
