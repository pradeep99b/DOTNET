using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Assignment1 a = new Assignment1();
                a.Name = "Pradeep Bahukhandi";
                a.EmpNo = 2;
                a.DeptNo = 2;
                a.Basic = 9;

                Console.WriteLine(a.Name);
                Console.WriteLine(a.EmpNo);
                Console.WriteLine(a.DeptNo);
                Console.WriteLine(a.Basic);

            }
            catch (InputException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }

    class InputException : Exception
    {
        public InputException(string message) : base(message) 
        {
        
        }
    }

   

    class Assignment1
    {
        private  string name;
        private int empNo;
        private decimal basic;
        private short deptNo;

        public string Name
        {
            set
            {
                if (value.Contains(' '))
                    throw new InputException("Cannot contain a blankSpace");
                else
                    name = value;
            }
            get
            {
                return name;
            }
        }

        public int EmpNo
        {
            set
            {
                if (value > 0)
                    empNo = value;
                else
                    throw new InputException("Cannot be smaller than 0"); ;
            }
            get
            {
                return empNo;
            }
        }

        public decimal Basic
        {
            set
            {
                if (value > 8 && value < 12)
                    basic = value;
                else
                    throw new InputException("Cannot contain a blankSpace");
            }
            get
            {
                return basic;
            }
        }

        public short DeptNo
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    throw new InputException("Cannot be smaller than 0");
            }
            get
            {
                return deptNo;
            }
        }
    }
}
