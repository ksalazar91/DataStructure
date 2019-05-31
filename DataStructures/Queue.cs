using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Queue<T>
    {
        /*
         *  Implementaton of queue with the 3 main fectures 
         *      
         *      Enqueue() - add an Item
         *      Dequeue() - remove Item
         *      peek()    - look at the item but dont remove
         */
        private T[]elements;
        private int front;
        private int rear;
        private int max;

        // Constructures
        public Queue(int size)
        {
            elements = new T[size];
            front = -1;
            rear = -1;
            max = size;
        }

        /// <summary>
        /// Add items to the queue and it change rear and size
        ///  If rear equals length -1 and front equals 0 than the queue is full
        ///  Make front and rear 0 and add element
        ///  If rear equals length -1 and front doesnt equal zero than rear = 0 and we add element to queue
        ///  Increments rear first then add element to queue.
        /// </summary>
        /// <param name="item">Generic value that is going to be add to the queue</param>

        public void enqueue(T item)
        {
            if(rear == max - 1 && front == 0) // 
            {
                Console.WriteLine("Queue is full");
              
            }else if(front == -1) //  
            {
                front = 0;
                rear = 0;
                elements[rear] = item;
            }else if(rear == max -1 && front != 0) //
            {
                rear = 0;
                elements[rear] = item;
            }
            else
            {

                elements[++rear] = item; // 
            }
        }
        /// <summary>
        /// Function to remove item from queue it changes front and size.
        /// Same value front and rear we set them back to -1
        /// Front equals length -1 we put front to 0
        /// Regresa element depending on front value
        /// </summary>
        /// <returns>Returns front element on the queue</returns>

        public T dequeue()
        {
            if(front == -1) // empty
            {
                Console.WriteLine("Queue is Empty");
                return default;
            }

            if(front == rear) // 
            {
                front = -1;
                rear = -1;
            }else if (front == max-1) // 
            {
                front = 0;
                
            }
            else // add one to front
            {
                front++;
            }


            return elements[front]; // 
        }

        /// <summary>
        /// Peeks first element on queue without removing it 
        /// </summary>
        /// <returns>Returns front element</returns>
        public T peek()
        {
            return elements[front];
        }

       
        

    }
}
