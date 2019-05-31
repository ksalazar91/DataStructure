using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Stack<T>
    {
        private T[] stackArray;
        private int top;
        private int max;
        public Stack(int size)
        {
            stackArray = new T[size];
            top = -1;
            max = size;
        }

        public void Push(T item)
        {
            if(top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                stackArray[++top] = item;
            }
        }
        public T Pop()
        {
            if(top== -1)
            {
                Console.WriteLine("Stack is Empty");
                return default;
            }
            else
            {
                Console.WriteLine("{0} Pop from stack ", stackArray[top]);
                return stackArray[top--];
            }
        }
        public T Peek()
        {
            return stackArray[top];
        }

        public void printStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("{0} pushed into stack", stackArray[i]);
                }
            }
        }
    }
}
