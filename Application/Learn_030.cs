namespace Application.Learn_030
{
	public class SomeClass : object
	{
		static SomeClass()
		{
		}

		public static void StaticMethod()
		{
			System.Console.WriteLine("I'm static method!");
		}

		public SomeClass() : base()
		{
		}

		public void NonStaticMethod()
		{
			System.Console.WriteLine("I'm not static method!");
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
			//MyDelegate myDelegate1 = new MyDelegate(SomeClass.StaticMethod);

			myDelegate1();
			// **************************************************

			// **************************************************
			SomeClass someClass = new SomeClass();

			MyDelegate myDelegate2 = someClass.NonStaticMethod;
			//MyDelegate myDelegate2 = new MyDelegate(someClass.NonStaticMethod);

			myDelegate2();
			// **************************************************
		}
	}
}
