using System;
using System.Threading;
class ThreadDemo 
{
	static void Main()
	{
		Thread t = Thread.CurrentThread;	
		t.Name = "Main Thread";
		Console.WriteLine("Current executing thread is:"+Thread.CurrentThread.Name);
	}
}