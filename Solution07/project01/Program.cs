namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region Create file

            // File.Create("file1.txt");

           // string[] lines1 = { "Sara", "Ali", "huda", "Salim" };

          //  File.AppendAllLines("file1.txt", lines1);

            string myfile = File.ReadAllText("file1.txt");
            Console.WriteLine(myfile);  


            #endregion
        }
    }
}
