using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace lab6
{
    class Class1
    {
		static public void func1(int a)
		{
			for (int i = 0; i < 100; i++)
			{
                Thread.Sleep(1);
				if (i > a) ;

			}
		}

        static public void func2()
		{
			for (int i = 0; i < 10; i++)
			{
				Thread.Sleep(100);
			}
		}
		static public void func3()
		{
			for (int i = 0; i < 10; i++)
			{
				Thread.Sleep(100);
			}
		}

		static void Main(string[] args)
		{
			func1(10);
			func2();
			func3();
			Console.WriteLine("\n Inside main()\n");
			string typeOfShapes;
			typeOfShapes = Console.ReadLine();

			int i = 0;

			for (; i < 10; i++) ;
			{
				for (int j = 100; j > 0; j--)
				{
					Console.WriteLine("Inside if()");
				}
			}
			Console.ReadKey();
		}
	}
}
