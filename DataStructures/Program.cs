using System;
using static DataStructures.LinkedList<string>;
using static DataStructures.CLinkedList<string>;
using Node = DataStructures.CLinkedList<string>.Node;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            string[] myArray = new string[] {"Item1", "Item2" , "Item3" , "Item4" , "Item5",
                                         "Item6", "Item7","Item8","Item9","Item10"};
            Console.WriteLine("Item at index 2 is: " + myArray[2]);
            Console.WriteLine();

            Console.WriteLine("This is the contents of the array. ");
            foreach(string value in myArray)
            {
                Console.WriteLine(value);
            }
            */

            /*
            Queue<int> queue = new Queue<int>(10);

            for(int i=0; i<10; i++)
            {
                queue.enqueue(i + 1);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Peek " + queue.peek());

                Console.WriteLine("dequeed " + queue.dequeue());
                Console.WriteLine("New Peek " + queue.peek());
            }

            queue.enqueue(11);
            queue.enqueue(12);
            queue.enqueue(13);
            queue.enqueue(14);
            queue.enqueue(15);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Peek " + queue.peek());

                Console.WriteLine("dequeed " + queue.dequeue());
                Console.WriteLine("New Peek " + queue.peek());
            }
            */


            //single linklist
            /*
            LinkedList<string> list = new LinkedList<string>();
            list.head = new Node("B");
            Node second = new Node("C");
            Node third = new Node("E");

            list.head.next = second;
            second.next = third;

            list.PrintList();
            Console.WriteLine();
            list.Push("A");

            list.PrintList();
            list.InsertAfter(second, "D");
            Console.WriteLine();
            list.PrintList();

            list.append("K");
            Console.WriteLine();
            list.PrintList();

            list.deleteNode("K");
            Console.WriteLine();
            list.PrintList();

            list.clear();
            Console.WriteLine();
            list.PrintList();
            */

            // circular LinkList
            /*
            CLinkedList<string> list = new CLinkedList<string>();

            list.head = null;

            Node second = list.Push(list.head, "A");
            Node third = list.Push(second, "B");
            Node four = list.Push(third, "C");
            Node five = list.Push(four, "D");
            Node six = list.Push(five, "E");

            list.PrintList(six);
            */

            //int[] a = { 1, 1, 2, 2, 4, 4, 5};
            //Console.WriteLine(FindSingleElement(a));
            //Console.WriteLine(FindStonesNum("aA", "aAAbbbb"));


            //stack
            Stack<int> p = new Stack<int>(5);
            p.Push(1);
            p.Push(2);
            p.Push(3);
            p.Push(4);

            p.printStack();
            Console.WriteLine(p.Peek());
            p.Pop();

            p.printStack();
            Console.WriteLine(p.Peek());
        }

        public static int FindSingleElement(int[] a)
        {
            Dictionary<int, int> dirValue = new Dictionary<int, int>();
            int key;
            for (int i = 0; i < a.Length; i++)
            {
                key = a[i];
                if (dirValue.ContainsKey(key))
                {
                    dirValue[key] += 1;
                }
                else
                {
                    dirValue.Add(key, 1);
                }
               
            }

            foreach(KeyValuePair<int,int> item in dirValue)
            {
                if(item.Value == 1)
                {
                    return item.Key;
                }
            }
            return 0;
        }


        public static int FindStonesNum(string J, string S)
        {
            int count = 0;
            Dictionary<char, int> jStones = new Dictionary<char, int>();
            for(int i = 0; i<J.Length; i++)
            {
                jStones.Add(J[i], 0);
            }

            for (int i = 0; i < S.Length; i++)
            {
                if (jStones.ContainsKey(S[i]))
                {
                    count++;
                }
            }
            
            return count;
        }
    }
}
