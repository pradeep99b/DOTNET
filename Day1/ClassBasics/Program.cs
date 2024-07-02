using System;

namespace ClassBasics
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
        }

        static void Main(string[] args)
        {
            Class1 o = new Class1();
            o.Display();
            o.Display("Pradeep");
            o.Add(2, 3);
            o.Add(3, 1, 2);
            o.Add();
            o.Add(a: 1);
            o.Add(1, 2);
            o.Add(3, 1, 2);
            System.Console.WriteLine("Hello, World!");
        }
    }

    public class Class1
    {
        public void Display()
        {
            Console.WriteLine("Hello World");
        }

        public void Display(string s)
        {
            Console.WriteLine(s + "Display");
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

       /* public int Add(int a, int b, int c)
        {
            return a + b + c;
        }*/

        public int Add(int c, int a = 0, int b=0)
        {
            return a + b + c;
        }
        //positional parameters
        //named parameters
        public void DoSomething()
        {
            int i = 100;
            DoSomething();
        }

        void void DoSomethhing2()
        {
            Console.WriteLine(1);
        }

    }
}

