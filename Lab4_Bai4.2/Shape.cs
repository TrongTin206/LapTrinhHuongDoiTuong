using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Bai4._2
{
    abstract class Shape
    {
        public string Name;

        public Shape(string name)
        {
            Name = name;
        }

        protected Shape()
        {
        }

        public abstract void Nhap();
        public abstract double Area();
    }
}
