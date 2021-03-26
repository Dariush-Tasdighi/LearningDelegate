namespace Application.Learn_050
{
	public class SomeClass : object
	{
		static SomeClass()
		{
		}

		public static void StaticMethod()
		{
			System.Console.WriteLine("I'm a static method!");
		}

		public SomeClass() : base()
		{
		}

		public void NonStaticMethod()
		{
			System.Console.WriteLine("I'm not a static method!");
		}
	}

	public delegate void MyDelegate();

	public static class Program
	{
		static Program()
		{
		}

		public static void Main()
		{
			// **************************************************
			MyDelegate myDelegate1 = SomeClass.StaticMethod;
			// **************************************************

			// **************************************************
			SomeClass someClass = new SomeClass();

			MyDelegate myDelegate2 = someClass.NonStaticMethod;
			// **************************************************

			// **************************************************
			MyDelegate myDelegate3 = myDelegate1 + myDelegate2;

			myDelegate3();
			// **************************************************

			System.Console.WriteLine("-----");

			// **************************************************
			MyDelegate myDelegate4 = myDelegate3 - myDelegate1;

			myDelegate4();
			// **************************************************
		}
	}
}
