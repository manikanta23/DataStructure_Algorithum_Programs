using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Queue
    {
        public int capacity, size, front, rear;
        public int[] array;

        public Queue(int Capacity)
        {
            this.capacity = Capacity;
            this.array = new int[Capacity];
            this.front = 0;
            this.rear = Capacity - 1;
            this.size = 0;
        }

        bool IsFull(Queue queue)
        {
            return (queue.size == queue.capacity);
        }

        bool IsEmpty(Queue queue)
        {
            return (queue.size == 0);
        }

        public void EnQueue(int i)
        {
            if (IsFull(this))
                return;

            this.rear = (this.rear + 1) % this.capacity;
            this.array[this.rear] = i;
            this.size++;
            
        }

        public void DeQueue()
        {
            if (IsEmpty(this))
            {
                Console.WriteLine("Empty");
                return;
            }
               
            
            Console.WriteLine(this.array[this.front]);
            this.front = (this.front + 1) % this.capacity;
            this.size--;

        }
    }
}
