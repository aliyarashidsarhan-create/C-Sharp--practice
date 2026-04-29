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
            Stack<string> names = new Stack<string>();

            names.Push("Aliya");
            names.Push("Sara");

            Console.WriteLine("1- Add String");
            Console.WriteLine("2- Print last String added");
            Console.WriteLine("3- Delete Last Element");
            Console.WriteLine("4- Show All Element");
            Console.WriteLine("5- Exit");

            Console.Write("Choose: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                names.Push(name);
            }
            else if (choice == 2)
            {
                if (names.Count > 0)
                    Console.WriteLine(names.Peek()); // آخر عنصر
                else
                    Console.WriteLine("Stack is empty");
            }
            else if (choice == 3)
            {
                if (names.Count > 0)
                    Console.WriteLine(names.Pop()); // يحذف آخر عنصر
                else
                    Console.WriteLine("Stack is empty");
            }
            else if (choice == 4)
            {
                foreach (string n in names)
                    Console.WriteLine(n);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Exit");
            }

            #endregion
        }
    }
}
 