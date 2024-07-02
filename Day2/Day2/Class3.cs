using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class ClassA
    {
        int i;
      


    }


    internal class ClassB : ClassA
    {   
       
        int j;

        public ClassB() :base()
        {

        }



        static void Main(string[] args)
        {
            // what would be the line that calls the static constructor
            ClassB a = new ClassB();
            Console.WriteLine(a.j);



        }

    }
}
