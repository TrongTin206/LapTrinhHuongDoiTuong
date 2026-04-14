using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab4_Bai41
{
    internal class PrimeStack : Stack
    {
        public PrimeStack(int _max) : base(_max)
        {
        }
        public override void Print()
        {
            //base.Print();
            while (!IsEmpty())
            {
                Console.Write(Pop());
                if (!IsEmpty()) Console.Write(" * ");
            }
        }
    }
}