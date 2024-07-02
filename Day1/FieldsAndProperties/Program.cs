using System.Runtime.InteropServices;

namespace FieldsAndProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i; //local variables are unassigned
            Class1 o1 = new Class1();
            o1.i = 100;
            Console.WriteLine(o1.i);
        }
    }

    public class Class1
    {
        //class level variable - field
        public int i; //initilaized to their default vaules

    }
}
