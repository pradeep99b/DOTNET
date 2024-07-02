using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public static class Sclass
    {
        private static int i;

        static Sclass()
        {
            Console.WriteLine("Static Constructor Called");
            i = 99;
        }

        public static int I
        {

            get { return i; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sclass.i);
        }

    }

   
}
