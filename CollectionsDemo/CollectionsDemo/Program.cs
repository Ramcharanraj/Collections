using System;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Collections");

            doListDemo();
        }

        private static void doListDemo()
        {
            throw new NotImplementedException();
        }

        private static void doQueueDemo()
            {
                Console.WriteLine("/nIn doQueueDemo");

                //creating a queue
                Queue<string> queue = new Queue<string>();
                queue.Enqueue("Amit sharma");
                queue.Enqueue("Vijay Raj");
                queue.Enqueue("Jaishankar");
                queue.Enqueue("Raj");
                Console.WriteLine("Head:" + queue.Peek());
                Console.WriteLine("/nIteration the queue elements:");

                //Iteration Queue elements
                foreach (var element in queue)
                {
                    Console.WriteLine(element);
                }
                string dequeue = queue.Dequeue();
                Console.WriteLine("Dequeue element:" + dequeue);

                Console.WriteLine("/n Iterating the queue elements after dequeue one element:");

                //Iteration Queue elements

            }
        }
    }

