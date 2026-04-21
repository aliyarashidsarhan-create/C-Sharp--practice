namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region array 
            //Console.Write("Enter number of rows: ");
            //int rows=Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter number of colums: ");
            //int cols=Convert.ToInt32(Console.ReadLine());

            //int [,] numbers = new int[rows, cols];

            //for (int i = 0; i < rows; i++)
            //{
            //    for(int j = 0;j< cols;j++)
            //    {
            //        Console.Write($"Enter value for [{i},{j}]: ");
            //        numbers[i,j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"The  value of [{i},{j}]:is {numbers[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}




            #endregion

            //task
            #region Task

            // Part 1 - One Dimensional Array for student names
            string[] StudentName = new string[5];
            Console.WriteLine(" part1 : student Name ");
            for (int i = 0; i < StudentName.Length; i++)
            {
                Console.WriteLine($"Enter Student Name {i+1}");
                StudentName[i] = Console.ReadLine();
            }
            Console.WriteLine("Student Name ");
            for (int i = 0; i < StudentName.Length; i++)
            {
                Console.WriteLine($"{StudentName[i]}");
            }

            // Part 2 - 2D Array for grades
            string[] subjects = { "Math", "Scince", "English" };
            int[,] grade = new int[5, 3];
            Console.WriteLine(" part2 : student Grade ");

            for (int i = 0; i < StudentName.Length; i++)
            {
                Console.WriteLine($"Enter Grade for {StudentName[i]}:");
                for (int j = 0; j < subjects.Length; j++)
                {
                    Console.WriteLine($"Enter {subjects[j]} grade :");
                    grade[i,j]=Convert.ToInt32(Console.ReadLine());
                }

            }
            // Part 3 - Display student grades in table format
            Console.WriteLine("part3: Display Student Grade ");
            Console.WriteLine("Name\tMath\tScience\tEnglish");

            for (int i = 0; i < StudentName.Length; i++)
            {
                Console.WriteLine($"{StudentName[i]}");
                for(int j = 0;j<subjects.Length; j++)
                {
                    Console.WriteLine(grade[i,j]);
                }
                Console.WriteLine();
            }
            // Part 4 - Calculate average for each student
            Console.WriteLine("part4: Calculate Student Average ");
            double[] average = new double[5];
            for (int i = 0; i < StudentName.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < subjects.Length; j++)
                {
                    sum += grade[i, j];
                }
                average[i] = (double)sum / subjects.Length;
                Console.WriteLine($"{StudentName[i]} average={average[i]}");
            }

            // Part 5 - Jagged Array
            Console.WriteLine("part5: Jagged Array ");
            int[][] jaggedGrade = new int[5][];
            for(int i = 0;i < jaggedGrade.Length;i++)
            {
                Console.WriteLine($"number of student subject {StudentName[i]} ");
                int subjectCount = Convert.ToInt32(Console.ReadLine());

                jaggedGrade[i]=new int[subjectCount];

                for( int j = 0;j<subjectCount;j++)
                {
                    Console.WriteLine($"Enter grade {j+1}:");
                    jaggedGrade[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("array result: ");
            for(int i = 0;i<jaggedGrade.Length ;i++)
            {
                Console.WriteLine($"{StudentName[i]} has {jaggedGrade[i].Length} subject: ");
                for(int j = 0;j<jaggedGrade[i].Length ;j++)
                {
                    Console.WriteLine(jaggedGrade [i][j] );
                }
            }
            //Part 6 - Search for student
            Console.WriteLine("part6: Search for student");
            Console.Write("Enter student name to search: ");
            string serchName = Console.ReadLine();

            bool found=false;
            for (int i = 0; i < StudentName.Length; i++)
            {
                if(StudentName [i].ToLower()== serchName.ToLower())
                {
                    Console.WriteLine($"Student found at {i}");
                    found = true;
                    break;
                }
            }
            if (found) {
                Console.WriteLine("Student was not found ");
            }
            //Part 7 – Find Highest Grade
            Console.WriteLine("part7: Search for student");
            int highGrade = grade[0,0];

            for (int i = 0; i < StudentName.Length; i++)
            {
                for (int j = 0; j < subjects.Length; j++)
                {
                    if (grade[i,j]>highGrade)
                    {
                        highGrade = grade[i,j];
                    }
                }

            }
            Console.WriteLine($"Highest grade in the system ={highGrade}");

            //Sort students alphabetically
            Console.WriteLine("Sort students alphabetically :");

            //Find student with highest average
            Console.WriteLine("Find student with highest average:");
            double highestAverage = average[0];
            string topStudent = StudentName[0];

            for (int i = 1; i < average.Length; i++)
            {
                if (average[i] > highestAverage)
                {
                    highestAverage = average[i];
                    topStudent =StudentName[i];
                }
            }

            Console.WriteLine($"{topStudent} has the highest average = {highestAverage}");

            #endregion










        }
    }
}
