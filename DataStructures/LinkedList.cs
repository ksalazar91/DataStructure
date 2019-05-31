using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class LinkedList<T>
    {
        public Node head; // head list

        /**
         *  LinkList Node class 
         * 
         */

        public class Node
        {
            public T data;
            public Node next;

            public Node(T data)
            {
                this.data = data;
                next = null;
            }

        }
        //prints all the nodes in the list
        public void PrintList()
        {
            Node node = head;
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }
        }

        // adds node to the head
        public void Push(T data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        // add node after another node 
        public void InsertAfter(Node prevNode, T data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("Previous node cannot be null");
                return;
            }
            else
            {
                Node newNode = new Node(data);
                newNode.next = prevNode.next;
                prevNode.next = newNode;
            }


        }

        //add to the end of the list
        public void append(T data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = new Node(data);

            }

            newNode.next = null;

            // get the last node
            Node last = head;
            while (last.next != null)
            {
                last = last.next;
            }

            last.next = newNode;


        }
        public void deleteNode(T key)
        {
            Node temp = head;
            Node prev = null;

            if(temp != null && temp.data.Equals(key))
            {
                head = temp.next;
                return;
            }

            if (temp == null){
                Console.WriteLine("Element not found");
            }

            while (temp != null && !temp.data.Equals(key)){
                prev = temp;
                temp = temp.next;
            }

            prev.next = temp.next;            
        }

        public void clear()
        {
            head = null;
            Console.WriteLine("list is clear");

        }

        public int length()
        {
            Node temp = head;
            int count = 0;
            while(temp != null)
            {
                count++;
                temp = temp.next;
            }

            return count;
        }

    }
}

