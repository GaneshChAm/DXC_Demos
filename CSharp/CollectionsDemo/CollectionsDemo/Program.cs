using System.Collections;
using System.Collections.Generic;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayLists
            Console.WriteLine("ArrayLists:-");           
            ArrayList l = new ArrayList();
            l.Add(10);
            l.Add(20);
            l.Add("Hello");
            l.Add(2.5f);
            l.Add(true); 
            l.Add(false);
            l.Insert(2,"hi");//adding element at index 2.
            l.Remove(10);//removing element with specific element
            Console.WriteLine("Total elements in the list = " + l.Count);
            Console.WriteLine("Before Clearing");
            foreach (object item in l)//object or var can be used.
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            l.Clear();
            Console.WriteLine("After Clearing");
            foreach (object item in l)//object or var can be used.
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------");

            //Stacks:-First In Last Out
            Console.WriteLine("Stacks:-");
            Stack s = new Stack();
            s.Push(10);
            s.Push(20);
            s.Push("Hello");
            s.Push("hi");
            s.Push(2.3f);
            s.Push("welcome");
            Console.WriteLine($"using peek method : {s.Peek()}");

            Console.WriteLine($"{s.Pop()} is popped");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"{s.Contains(20)}");
            Console.WriteLine("--------------------------------------");

            //QUEUE:-First In First Out
            Console.WriteLine("Queues:-");
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue("Hello");
            q.Enqueue(2.7f);
            q.Enqueue("Welcome");
            Console.WriteLine($"using peek method : {q.Peek()}");
            Console.WriteLine($"{q.Dequeue()} is removed from queue");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"{q.Contains(20)}");
            Console.WriteLine("--------------------------------------");

            //Sorted List:-The List is Sorted order and stores in [keys;values] format.
            Console.WriteLine("Sorted List:-");
            SortedList sl = new SortedList();
            sl.Add(3,4);
            sl.Add(2,0);
            sl.Add(5,1);
            sl.Add(6,"hi");
            sl.Add(1, "welcome");
            //sl.Add("Hi", 1);
            //sl.Add("welcome", 4); 
            //sl.Add("hi", 2);
            Console.WriteLine(sl[6]);//to get value  by using key.
            Console.WriteLine($"Total elements in SortedList  = {sl.Count}");
            foreach (var item in sl.Keys)
            {
                Console.WriteLine($"Key: {item} : Value: {sl[item]}");
            }
            Console.WriteLine($"{sl.Contains(20)}");
            Console.WriteLine("--------------------------------------");

            //Hashtable:- The List is not in particular order and stores in [keys;values] format.
            Console.WriteLine("Hash Tables:-");
            Hashtable ht = new Hashtable();
            ht.Add(3,4);
            ht.Add(2,0);
            ht.Add(5,"hi");
            ht.Add("hello", 1);
            ht.Add("aryan", 3);
            ht.Add("Akhil", 4);
            Console.WriteLine(ht[5]);
            Console.WriteLine($"Total elements in hashtable = {ht.Count}");
            foreach (var item in ht.Keys)
            {
                Console.WriteLine($"Key: {item} : Value: {ht[item]}");
            }
            Console.WriteLine($"{ht.Contains(5)}");
            Console.WriteLine("--------------------------------------");
        }
    }
}