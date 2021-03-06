namespace Application.Learn_010
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

	public static class Program
	{
		static Program()
		{
		}

		public static void Main()
		{
			SomeClass.StaticMethod();

			SomeClass someClass = new SomeClass();

			someClass.NonStaticMethod();
		}
	}
}
