using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class CLinkedList<T>
        
    {
        public Node head =  new Node();

        public class Node
        {
            public T data;
            public Node next;
        }

        public Node Push(Node headRef, T data)
        {
            Node ptr1 = new Node();
            Node temp = headRef;
            ptr1.data = data;
            ptr1.next = headRef;

            if(headRef != null)
            {
                while(temp.next != headRef)
                {
                    temp = temp.next;
                }
                temp.next = ptr1;

            }
            else
            {
                ptr1.next = ptr1;
               
            }
            headRef = ptr1;
            return headRef;
        }

        public void PrintList(Node head)
        {
            Node node = head;
            if(head != null)
            {
                do
                {
                    Console.Write(node.data + " ");
                    node = node.next;
                } while (node != head);

            }
           
        }
    }
}
