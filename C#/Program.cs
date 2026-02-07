using System;

//class Program
//{
//	static void Main(string[] args)
//	{
//		int n, count = 0;

//		Console.Write("Enter number: ");
//		n = Convert.ToInt32(Console.ReadLine());

//		for (int i = 1; i <= n; i++)
//		{
//			if (n % i == 0)
//				count++;
//		}

//		if (count == 2)
//			Console.WriteLine("Prime Number");
//		else
//			Console.WriteLine("Not Prime Number");
//	}
//}


//class program
//{
//	static void Main()
//	{
//		int target;

//		Console.Write("Enter number: ");
//		target = Convert.ToInt32(Console.ReadLine());

//		for (int num = 1; num <= target; num++)
//		{
//			int count = 0;

//			for (int i = 1; i <= num; i++)
//			{
//				if (num % i == 0)
//					count++;
//			}
//			if (count == 2)
//				Console.Write(num + " ");


//		}

//	}
//}



//class program
//{
//	static void Main()
//	{
//		int num;

//		Console.Write("Enter number: ");
//		num = Convert.ToInt32(Console.ReadLine());

//		if (num % 2 == 0)
//			Console.WriteLine("Even Number");
//		else
//			Console.WriteLine("Odd Number");
//	}
//}



//class program
//{
//	static void Main()
//	{
//		int i = 10;

//		for (i = 1; i <= 10; i++)
//		{
//			if (i == 5)
//				break;
//			Console.WriteLine(i);
//		}
//		Console.WriteLine("Exited from loop");
//	}
//}

//class program
//{
//	static void Main()
//	{
//		int n, a = 0, b = 1, c;

//		Console.Write("Enter number: ");
//		n = Convert.ToInt32(Console.ReadLine());

//		Console.Write("Fibonacci Series: ");


//		for (int i = 1; i <= n; i++)
//		{
//			Console.Write(a + " ");
//			c = a + b;

//			a = b;

//			b = c;
//		}
//	}
//}




class program
{
	static void Main()
	{
		string str, rev = "";

		Console.WriteLine("enter string: ");
		str = Console.ReadLine();

		for (int i = str.Length - 1; i >= 0; i--)
		{
			rev += str[i];

		}

		if (str == rev)
			Console.WriteLine("Palindrome");
		else
			Console.WriteLine("Not Palindrome"); 
	}
}




	