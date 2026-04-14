using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab4_Bai41
{
    class Stack
    {
        private int top;
        private int Max;
        private int[] stack;
        public Stack(int _max)
        {
            Max = _max;
            top = -1;
            stack = new int[Max];
        }

        public void Push(int data)
        {
            if (top == Max - 1)
            {
                Console.WriteLine("Stack đầy");
                return;
            }
            top++;
            stack[top] = data;
        }

        // Kiểm tra rỗng
        public bool IsEmpty()
        {
            return top == -1;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty");
                return -1;
            }

            int val = stack[top];
            top--;
            return val;
        }

        // In stack
        public virtual void Print()
        {
            Console.WriteLine("Test");
        }
    }
}