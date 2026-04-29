namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Calculator();
        }
            #region Function
            static void Calculator()
            {
            //calculator 
                bool continueCalc = true;
                while(continueCalc) {
                    Console.WriteLine("Enter First Number :");
                    double num1=Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter Second Number :");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Choose Operation (+,-,*,/):");
                    string option=Console.ReadLine();

                    double result = 0;

                    switch (option)
                    {
                        case "+":
                            result = num1+num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            if (num2 !=0)
                                result=num1 / num2;
                            else
                            {
                                Console.WriteLine("Cannot divide by zero ");
                                continue;
                            }
                            break;
                            default:
                            Console.WriteLine("Invalid option ");
                            continue;

                    }

                    Console.WriteLine($"Result = {result}");

                    Console.Write("Another calculation? (yes/no): ");
                    string answer = Console.ReadLine().ToLower();

                    if (answer != "yes")
                        continueCalc = false;
                }

                Console.WriteLine("Program ended.");
            }

        }





            #endregion



    }
    

