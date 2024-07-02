using System;
using System.Threading;

class ThreadLocking
{
	public void Display(Object obj)
	{	
		lock(this)
		{
		string s = Convert.ToString(obj);
		Console.Write("Hello world "+s);
		Console.WriteLine();
		}
	}

	static void Main()
	{
		ThreadLocking obj = new ThreadLocking();

		Thread t1 = new Thread(new ParameterizedThreadStart(obj.Display));
		Thread t2 = new Thread(new ParameterizedThreadStart(obj.Display));
		Thread t3 = new Thread(new ParameterizedThreadStart(obj.Display));

		t1.Start("Naresh");
		t2.Start("Mohit");
		t3.Start("Pradeep");

	}

}
		
