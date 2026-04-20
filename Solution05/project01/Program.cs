using System.Globalization;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //aray of 4 number
            //int[] Numbers = new int[4];

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine("Enter any number:");
            //    Numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("***************************");
            //foreach (int num in Numbers)
            //{
            //    Console.WriteLine(num);
            //}


            #region Task1

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region Task2
            //int[] number = { 1, 3, 6, 9, 10 };
            //foreach (int num in number)
            //{
            //    Console.WriteLine(num);
            //}



            #endregion

            #region Task3
            //int[] numbers = new int[5];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Enter number :");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("****");
            //foreach(int i in numbers) 
            //{
            //    Console.WriteLine(i);
            //}




            #endregion

            #region Task4
            //اكتب برنامج يطلب من المستخدم إدخال 5 أرقام ثم يحسب مجموعهم.
           // int sum = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Enter number: ");
            //    int num=Convert.ToInt32(Console.ReadLine());
            //    sum += num; 

            //}
            //Console.WriteLine("sum ="+sum);

            #endregion

            #region Task5
            //اكتب برنامج يطلب من المستخدم إدخال 5 أرقام ثم يطبع أكبر رقم.
            //int[] numbers = new int[5];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Enter Number : ");
            //    numbers[i]=Convert.ToInt32(Console.ReadLine());
            //}
            //int max = numbers[0];
            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if(numbers[i] >max)
            //    {
            //        max = numbers[i];
            //    }
            //}
            //Console.WriteLine("Max ="+max);




            #endregion

            #region Task 6
            //اكتب برنامج يطلب من المستخدم إدخال 5 أرقام ثم يطبع أصغر رقم.
            //int[] numbers = new int[5];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Enter number : ");
            //    numbers[i] =Convert.ToInt32(Console.ReadLine());
            //}
            //int min = numbers[0];
            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if(numbers[i] < min)
            //    {
            //        min= numbers[i];
            //    }
            //}
            //Console.WriteLine("Min= "+min);

            #endregion

            #region Task7
            //اكتب برنامج يطلب من المستخدم إدخال 10 أرقام ثم يطبع الأرقام الزوجية فقط.
            //int [] numbers = new int[10];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Enter Number : ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Even Numbers : ");
            //for  (int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i] %2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            #region Task8
            //اكتب برنامج يطلب من المستخدم إدخال 5 أرقام ثم يحسب متوسطهم
            int sum= 0;
            for(int i=0; i<5;i++)
            {
                Console.WriteLine("Enter Number : ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;

            }
            double average = sum / 5;
            Console.WriteLine("Average =" + average);

            #endregion

        }
    }
}
