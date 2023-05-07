//aggiungi progetto alla soluzione > libreria di classi > il namespace è il futuro using > aggiungi riferimento > progetto
namespace ClassLibrary1
{
	public static class Class1
	{
		public static bool Pari(this int num) //this int? // '?' significa che può essere null
		{
			return num%2==0;
		}
	}

	public class Class2
	{
		public bool Odd(int num)
		{
			return num%2==1;
		}
	}
}
