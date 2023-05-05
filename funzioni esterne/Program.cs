using System;
using ClassLibrary1;

namespace funzioni_esterne
{
	internal class Program
	{
		static void Main()
		{
			Console.WriteLine(int.Parse(Console.ReadLine()).Pari());
			//Console.WriteLine(int.Parse(Console.ReadLine())  .Class1.Pari()); //non funziona perché pari ha un   this int
			Console.WriteLine(Class1.Pari(int.Parse(Console.ReadLine())));
			//Console.WriteLine(  Pari  (int.Parse(Console.ReadLine()))); //non funziona perché pari ha bisogno di un   this int

			Class2 class2 = new Class2();
			//Class1 class1 = new Class1(); //non funziona perché statico

			Console.WriteLine(class2.Odd(int.Parse(Console.ReadLine())));
			//Console.WriteLine(  Class2.Odd  (int.Parse(Console.ReadLine()))); //non è statico
		}
	}
}