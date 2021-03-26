namespace Application.Learn_040
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
			//MyDelegate myDelegate = null;

			//myDelegate = SomeClass.StaticMethod;

			//SomeClass someClass = new SomeClass();
			//myDelegate = someClass.NonStaticMethod;

			//myDelegate();
			// **************************************************

			// **************************************************
			//MyDelegate myDelegate = null;

			//myDelegate = SomeClass.StaticMethod;

			//SomeClass someClass = new SomeClass();
			//myDelegate += someClass.NonStaticMethod;

			//myDelegate();
			// **************************************************

			// **************************************************
			//MyDelegate myDelegate = null;
			//SomeClass someClass = new SomeClass();

			//myDelegate = SomeClass.StaticMethod;

			//myDelegate += someClass.NonStaticMethod;
			//myDelegate += someClass.NonStaticMethod;
			//myDelegate += someClass.NonStaticMethod;
			//myDelegate += SomeClass.StaticMethod;
			//myDelegate += SomeClass.StaticMethod;
			//myDelegate += SomeClass.StaticMethod;

			//myDelegate();
			// **************************************************

			// **************************************************
			MyDelegate myDelegate = null;
			SomeClass someClass = new SomeClass();

			myDelegate = SomeClass.StaticMethod;

			myDelegate += someClass.NonStaticMethod;
			myDelegate += someClass.NonStaticMethod;
			myDelegate += someClass.NonStaticMethod;
			myDelegate += SomeClass.StaticMethod;
			myDelegate += SomeClass.StaticMethod;
			myDelegate += SomeClass.StaticMethod;

			// دقت کنید که توابع را از انتها حذف می‌کند
			myDelegate -= someClass.NonStaticMethod;
			myDelegate -= SomeClass.StaticMethod;

			myDelegate();
			// **************************************************
		}
	}
}
