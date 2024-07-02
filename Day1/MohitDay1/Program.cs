namespace MohitDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee(10, "Amol", 123465, 1);
            Employee o2 = new Employee(10, "Amol", 123465);
            Employee o3 = new Employee(10, "Amol");
            Employee o4 = new Employee(10);
            Employee o5 = new Employee();


        }
    }
    public class Employee
    {
        public string name;
        public int empNo;
        public decimal basic;
        public short deptNo;


        public Employee()
        {

        }
        public Employee(short deptNo)
        {
            this.deptNo = deptNo;
        }
        public Employee(short deptNo, string name)
        {
            this.deptNo = deptNo;
            this.name = name;
        }
        public Employee(short deptNo, string name, decimal basic)
        {
            this.deptNo = (short)deptNo;
            this.basic = basic;
            this.name = name;
        }
        public Employee(short deptNo, string name, decimal basic, int empNo)
        {
            this.deptNo = deptNo;
            this.name = name;
            this.basic = basic;
            this.empNo = empNo;



        }
        public string Name
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Name Cannot be Empty");
                }
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
                if (value <= 0)
                {
                    Console.WriteLine("Employee Number cannot be 0");
                }
                else
                {
                    empNo = value;
                }
            }

        }
        public decimal Basic
        {
            set
            {
                if (value > 5000 && value < 100000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Basic should be in range between 5000 to 100000");
                }
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
                if (value <= 0)
                {
                    Console.WriteLine("Department Number cannot be 0");
                }
                else
                {
                    deptNo = value;
                }
            }

        }



    }
}
