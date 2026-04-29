
namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Queue
            //Queue<string> names = new Queue<string>();


            //names.Enqueue("Aliya");
            //names.Enqueue("Sara");

            //Console.WriteLine("1- Add");
            //Console.WriteLine("2- Show First");
            //Console.WriteLine("3- Remove");
            //Console.WriteLine("4- Show All");
            //Console.WriteLine("5- Exit");



            //Console.Write("Choose: ");
            //int choice = int.Parse(Console.ReadLine());

            //if (choice == 1)
            //{
            //    Console.Write("Enter name: ");
            //    string name = Console.ReadLine();
            //    names.Enqueue(name);
            //}
            //else if (choice == 2)
            //{
            //    if (names.Count > 0)
            //        Console.WriteLine(names.Peek());
            //    else
            //        Console.WriteLine("Queue is empty");
            //}
            //else if (choice == 3)
            //{
            //    if (names.Count > 0)
            //        Console.WriteLine(names.Dequeue());
            //    else
            //        Console.WriteLine("Queue is empty");
            //}
            //else if (choice == 4)
            //{
            //    foreach (string n in names)
            //        Console.WriteLine(n);
            //}
            //else if (choice == 5)
            //{
            //    Console.WriteLine("Exit");
            //}

            #endregion

            #region Stack
            //Stack<string> names = new Stack<string>();

            //names.Push("Aliya");
            //names.Push("Sara");

            //int choice = 0;

            //while (choice != 5) // loop until user chooses Exit
            //{
            //    Console.WriteLine("\n1- Add String");
            //    Console.WriteLine("2- Print last String added");
            //    Console.WriteLine("3- Delete Last Element");
            //    Console.WriteLine("4- Show All Element");
            //    Console.WriteLine("5- Exit");

            //    Console.Write("Choose: ");
            //    choice = int.Parse(Console.ReadLine());

            //    if (choice == 1)
            //    {
            //        Console.Write("Enter name: ");
            //        string name = Console.ReadLine();
            //        names.Push(name);
            //    }
            //    else if (choice == 2)
            //    {
            //        if (names.Count > 0)
            //            Console.WriteLine(names.Peek());
            //        else
            //            Console.WriteLine("Stack is empty");
            //    }
            //    else if (choice == 3)
            //    {
            //        if (names.Count > 0)
            //            Console.WriteLine(names.Pop());
            //        else
            //            Console.WriteLine("Stack is empty");
            //    }
            //    else if (choice == 4)
            //    {
            //        foreach (string n in names)
            //            Console.WriteLine(n);
            //    }
            //    else if (choice == 5)
            //    {
            //        Console.WriteLine("Exit");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid choice");
            //    }
            //}

            #endregion

            #region Student Service Center
            Dictionary<int, string> students = new Dictionary<int, string>();
            Queue<int> serviceQueue = new Queue<int>();
            Stack<int> servedStack = new Stack<int>();

            students.Add(22, "Sara");
            students.Add(23, "Ahmed");

            int choice = 0;

            while (choice != 9)
            {
                Console.WriteLine("\n--- Student Service Center ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Update Student");
                Console.WriteLine("3. Remove Student");
                Console.WriteLine("4. Show All Students");
                Console.WriteLine("5. Join Service Queue");
                Console.WriteLine("6. Serve Next Student");
                Console.WriteLine("7. Undo Last Service");
                Console.WriteLine("8. Show Queue");
                Console.WriteLine("9. Search by Id");
                Console.WriteLine("10. Exit");

                try
                {
                    Console.Write("Choose: ");
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Student ID: ");
                            int id = int.Parse(Console.ReadLine());

                            if (students.ContainsKey(id))
                                Console.WriteLine("Student ID already exists.");
                            else
                            {
                                Console.Write("Enter Student Name: ");
                                string name = Console.ReadLine();
                                students.Add(id, name);
                                Console.WriteLine("Student added successfully.");
                            }
                            break;

                        case 2:
                            Console.Write("Enter Student ID to update: ");
                            id = int.Parse(Console.ReadLine());

                            if (students.ContainsKey(id))
                            {
                                Console.Write("Enter new name: ");
                                students[id] = Console.ReadLine();
                                Console.WriteLine("Student updated successfully.");
                            }
                            else
                                Console.WriteLine("Student not found.");
                            break;

                        case 3:
                            Console.Write("Enter Student ID to remove: ");
                            id = int.Parse(Console.ReadLine());

                            if (students.ContainsKey(id))
                            {
                                students.Remove(id);
                                Console.WriteLine("Student removed successfully.");
                            }
                            else
                                Console.WriteLine("Student not found.");
                            break;

                        case 4:
                            Console.WriteLine("\nAll Students:");
                            foreach (var student in students)
                                Console.WriteLine(student.Key + " -> " + student.Value);
                            break;

                        case 5:
                            Console.Write("Enter Student ID to join queue: ");
                            id = int.Parse(Console.ReadLine());

                            if (students.ContainsKey(id))
                            {
                                serviceQueue.Enqueue(id);
                                Console.WriteLine(students[id] + " joined the queue.");
                            }
                            else
                                Console.WriteLine("Student not found. Please register first.");
                            break;

                        case 6:
                            if (serviceQueue.Count > 0)
                            {
                                id = serviceQueue.Dequeue();
                                servedStack.Push(id);
                                Console.WriteLine(students[id] + " is served.");
                            }
                            else
                                Console.WriteLine("Queue is empty.");
                            break;

                        case 7:
                            if (servedStack.Count > 0)
                            {
                                id = servedStack.Pop();
                                serviceQueue.Enqueue(id);
                                Console.WriteLine(students[id] + " returned to the queue.");
                            }
                            else
                                Console.WriteLine("No served student to undo.");
                            break;

                        case 8:
                            Console.WriteLine("\nStudents in Queue:");
                            Console.WriteLine("Number of students in queue: " + serviceQueue.Count);

                            foreach (int studentId in serviceQueue)
                                Console.WriteLine(studentId + " -> " + students[studentId]);
                            break;

                        case 9:
                            Console.Write("Enter Student ID to search: ");
                            id = int.Parse(Console.ReadLine());

                            if (students.ContainsKey(id))
                            {
                                Console.WriteLine("Student Found: " + id + " -> " + students[id]);
                            }
                            else
                            {
                                Console.WriteLine("Student not found.");
                            }
                            break;

                        case 10:
                            Console.WriteLine("Exit program.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter numbers only.");
                }
            }
            #endregion
        }
    }
    }
