namespace Application.Learn_060
{
	public class SomeClass : object
	{
		static SomeClass()
		{
		}

		public static int StaticMethod(string message)
		{
			System.Console.WriteLine($"I'm static method! - Message: { message }");

			if ((message == null) || (message == string.Empty))
			{
				return 0;
			}
			else
			{
				return message.Length;
			}
		}

		public SomeClass() : base()
		{
		}

		public int NonStaticMethod(string message)
		{
			string result =
				$"I'm not static method! - Message: { message }";

			System.Console.WriteLine(result);

			if ((result == null) || (result == string.Empty))
			{
				return 0;
			}
			else
			{
				return result.Length;
			}
		}
	}

	public delegate int MyDelegate(string message);

	public static class Program
	{
		static Program()
		{
		}

		public static void Main()
		{
			// **************************************************
			MyDelegate myDelegate = SomeClass.StaticMethod;

			myDelegate("Hello, World!");
			// **************************************************

			// **************************************************
			//MyDelegate myDelegate = SomeClass.StaticMethod;

			//int length = myDelegate("Hello, World!");

			//System.Console.WriteLine($"Length: { length }");
			// **************************************************

			// **************************************************
			// کنیم Register اگر چند تابع
			// و این توابع خروجی داشته باشند
			// زمان اجرای متغیر از نوع دلیگیت، صرفا خروجی آخرین تابع
			// شده را به ما می‌دهد Register صرفا خروجی آخرین تابع
			// **************************************************
			//MyDelegate myDelegate = SomeClass.StaticMethod;

			//myDelegate += SomeClass.StaticMethod;

			//SomeClass someClass = new SomeClass();

			//myDelegate += someClass.NonStaticMethod;
			//myDelegate += someClass.NonStaticMethod;
			//myDelegate += someClass.NonStaticMethod;

			//int length = myDelegate("Hello, World!");

			//System.Console.WriteLine($"Length: { length }");
			// **************************************************
		}
	}
}
