using System;

namespace HelloWorld
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World! from Linux");

			int overflowTest = 0;

			Console.WriteLine ("value is : " + overflowTest);

			overflowTest = int.MaxValue;

			Console.WriteLine ("Value is : " + overflowTest);

			//set to + 1 to throw exception
			int res = checked(overflowTest + 0);
			Console.WriteLine ("Value is : " + overflowTest);

			//using checked on a whole block of code
			checked 
			{
				int myInt = int.MaxValue;
				int myOtherInt = int.MaxValue;

				int insaneValue = myInt + myOtherInt;
			}
		}
	}
}
