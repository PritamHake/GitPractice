using System;

class Program
{
	static void Main()
	{
		Console.Write("Enter a string: ");
		string name = Console.ReadLine();

		char[] arr = name.ToCharArray();
		Array.Reverse(arr);

		string reverse = new string(arr);

		Console.WriteLine("Reverse string: " + reverse);
	}
}



