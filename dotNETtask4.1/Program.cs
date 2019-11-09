using System;

namespace dotNETtask4._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue queue = new Queue();
            Random random = new Random();

            while (!Console.KeyAvailable)
            {
                queue.Enqueue(new Complex(random.Next(-5,5),random.Next(-5,5)));
                System.Threading.Thread.Sleep(1000);
                PrintEnqueue(queue);
            }

            Console.ReadLine();


            while (!Console.KeyAvailable && queue.Count>0) 
            {
                queue.Dequeue();
                System.Threading.Thread.Sleep(1000);
                PrintDequeue(queue);
            }

            if (queue.Count == 0)
                Console.WriteLine("В очереди закончились элементы");

            Console.ReadLine();

        }

        static void PrintEnqueue(Queue q)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Добавляем элементы в очередь \n(нажмите ENTER для прекращения добавления):");
            Console.BackgroundColor = ConsoleColor.Black;
            q.Print();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Всего элементов {q.Count}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void PrintDequeue(Queue q)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Удаляем элементы из очереди \n(нажмите ENTER для прекращения удаления):");
            Console.BackgroundColor = ConsoleColor.Black;
            q.Print();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Всего элементов {q.Count}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
