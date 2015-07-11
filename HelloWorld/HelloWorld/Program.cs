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

			int res = checked(overflowTest + 1);

			Console.WriteLine ("Value is : " + overflowTest);

		}
	}
}
