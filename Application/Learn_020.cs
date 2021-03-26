namespace Application.Learn_020
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
			MyDelegate myDelegate1 =
				new MyDelegate(SomeClass.StaticMethod);

			myDelegate1();
			// **************************************************

			// **************************************************
			SomeClass someClass = new SomeClass();

			MyDelegate myDelegate2 =
				new MyDelegate(someClass.NonStaticMethod);

			myDelegate2();
			// **************************************************

			// **************************************************
			// در صورتی که در داخل یک متغیر از نوع
			// دلیگیت، تابعی ثبت نکرده باشیم، مقدار آن نال می‌باشد
			//MyDelegate myDelegate3;

			//if (myDelegate3 != null)
			//{
			//	myDelegate3();
			//}
			// **************************************************
		}
	}
}
