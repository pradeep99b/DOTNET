using System;
class ThreadConstructor
{
	static void Test()
	{
		for(int i=1; i<= 100; i++)
		{
			Console.WriteLine("Test: "+i);
		}
	}

		static void Main(string[] args)
		{
			Test();
			Console.ReadLine();
		}
	
}