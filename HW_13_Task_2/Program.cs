using System;
using System.Collections.Generic;

namespace HW_13_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // • Очередь, которая принимает только тип DateTime

            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.Today;

            Queue<DateTime> dates = new Queue<DateTime>();

            dates.Enqueue(date1);
            dates.Enqueue(date2);

            try
            {
                DateTime dequeueElementDate = dates.Dequeue();
                Console.WriteLine($"Dequeued element: {dequeueElementDate}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Can't deque the element, the Queue is empty. Details: {ex}");
            }

            try
            {
                DateTime peekElementDate = dates.Peek();
                Console.WriteLine($"Peeked element: {peekElementDate}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Can't peek the element, the Queue is empty. Details: {ex}");
            }


            // • Очередь, которая принимает тип Object

            Queue<object> queueObj = new Queue<object>();

            queueObj.Enqueue(22);
            queueObj.Enqueue(new int[] { 12, 15, 32 });
            queueObj.Enqueue("test string");
            queueObj.Enqueue(new userClass());

            object[] objArray = new object[queueObj.Count];

            while (queueObj.Count != 0)
            {
                Console.WriteLine("Type of the first element in collection: {0}. Collection lenght: {1}.", queueObj.Peek().GetType(), queueObj.Count);
                objArray[queueObj.Count - 1] = queueObj.Dequeue();
            }

            // • Очередь, которая принимает только классы
            CustomQueue<Employee> customQueue = new CustomQueue<Employee>();
            customQueue.Enqueue(new Actor());
            customQueue.Enqueue(new Teacher());
            customQueue.Enqueue(new Employee());

            try
            {
                object dequeueElementDate = customQueue.Dequeue();
                Console.WriteLine($"Dequeued element: {dequeueElementDate}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Can't deque the element. Details: {ex.Message}");
            }

            try
            {
                object peekElementDate = customQueue.Peek();
                Console.WriteLine($"Peeked element: {peekElementDate}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Can't peek the element. Details: {ex.Message}");
            }
        }
        class userClass { }
        class Employee
        {
        }
        class Actor : Employee
        {
        }
        class Teacher : Employee
        {
        }
        class CustomQueue<T> : Queue<T> where T : Employee
        {
        }
    }
}

