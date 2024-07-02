using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class ConstructorProgram
    {
        static void Main()
        {
            ConDemo o1 = new ConDemo();
            Console.WriteLine(o1.i);

            ConDemo o2 = new ConDemo(10, 20, 30, 50);
            Console.WriteLine(o2.i);
        }
    }

    public class ConDemo
    {
        public int i;
        public int j;
        public int k;


        public ConDemo()
        {
            Console.WriteLine("No para, constructor called");
            i = 10;
        }
        public ConDemo(int i, int j, int k)
        {
            Console.WriteLine("int cons Called");
            this.i = i;
            this.j = j;
            this.k = k;

            // this is  a reference to the current object;
        }

        private int p1;
        public int P1
        {
            set
            {
                if (value < 10)
                    p1 = value;
                else
                {
                    throw new Exception("Invalid input");
                }
            }

            get
            {
                return p1;
            }

        }

        public ConDemo(int i = 10, int j = 20, int k = 30, int P1 = 50)
        {
            Console.WriteLine("int cons called");
            //this.p1 = P1;
            this.P1 = P1;

            this.i = i;
            this.j = j;
            this.k = k;


        }

    }

}
