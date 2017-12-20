using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Stack
    {
       public static readonly int MAX = 1000;
       public string[] a = new string[MAX];
       public int top;

        public Stack()
        {
            top = -1;
        }

      
        public void push(string x)
        {
            if (top < MAX)
                a[++top] = x;
        }

       public  void pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Empty");
            }             
            else
            {
                string x = a[top--];
                Console.Write(x + ' ');
            }
              

        }
    }
}
