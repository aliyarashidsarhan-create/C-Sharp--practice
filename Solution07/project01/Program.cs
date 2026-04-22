using System.Diagnostics;

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

            //string myfile = File.ReadAllText("file1.txt");
            //Console.WriteLine(myfile);  


            #endregion

            #region Task 1:

            try
            {
                File.Create("exam1.txt");
                File.Create("exam2.txt");
                File.Create("exam3.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Choose file to open (1-3): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Process.Start("NotePad.exe", "exam1.txt");

                    break;

                case 2:
                    Process.Start("NotePad.exe","exam2.txt");
                    break;

                case 3:
                    Process.Start("NotePad.exe", "exam3.txt");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }


            #endregion










            }


            }
    }

