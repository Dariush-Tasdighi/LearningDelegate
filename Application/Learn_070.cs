namespace Application.Learn_070
{
	public delegate void NotifyDelegate(string message);

	public class User : object
	{
		public User(string fullName) : base()
		{
			FullName = fullName;
		}

		public string FullName { get; set; }

		public void Notify(string message)
		{
			string result =
				$"I'm { FullName } and I get this message: { message }";

			System.Console.WriteLine(result);
		}
	}

	public static class Program
	{
		static Program()
		{
		}

		public static void Main()
		{
			NotifyDelegate myNotifyDelegate = null;

			// **************************************************
			User user1 =
				new User(fullName: "Sara Ahmadi");

			myNotifyDelegate += user1.Notify;
			// **************************************************

			// **************************************************
			User user2 =
				new User(fullName: "Ali Reza Alavi");

			myNotifyDelegate += user2.Notify;
			// **************************************************

			// **************************************************
			User user3 =
				new User(fullName: "Dariush Tasdighi");

			myNotifyDelegate += user3.Notify;
			// **************************************************

			while(1 == 1)
			{
				System.Console.Write("Write a message to send to all users: ");
				string message = System.Console.ReadLine();
				System.Console.WriteLine();

				if (myNotifyDelegate != null)
				{
					myNotifyDelegate(message);
				}
			}
		}
	}
}
