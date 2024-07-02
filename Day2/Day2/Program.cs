namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Class1 o1;
            o1 = new Class1();
            Class1.s_display();
            Class1 o2 = new Class1();
            o1.i = 100;
            o1.display();

            o2.i = 200;
            Class1.s_i = 1234;
            Console.WriteLine(Class1.s_i);
            Class1.s_display();
        }
    }

    public class Class1
    {
        public int i;

        public Class1()
        {
            Console.WriteLine("Constructor called");
        }

        public static int s_i=100;

        public void display()
        {
            Console.WriteLine("display");
            Console.WriteLine(i);
            Console.WriteLine(s_i);
        }

        public static void s_display()
        {
            Console.WriteLine("static display");
            //Console.WriteLine(i);
            Console.WriteLine(s_i);
            Console.WriteLine(s_Prop1);        
        }

        public int prop1;
        public int Prop1
        {
            set
            {
                if (value > 100)
                    throw new Exception("Invalid Value");
                else
                {
                    prop1 = value;
                }
            }

            get
            {
                return prop1;
            }

        }

        private static int s_prop1;
        public static int s_Prop1
        {
            set
            {
                if (value > 100) throw new Exception("Invalid value");
                else
                {
                    s_prop1 = value;

                }
            }

            get { return s_prop1; }

        }

        static Class1()
        {
            Console.WriteLine("static cons called");
            s_i = 1;
            s_Prop1 = 2;

        }
    }
}
