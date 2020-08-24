using System;

namespace QuickUnion
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter size of array");

			string s = Console.ReadLine ();

			int N = int.Parse (s);

			QuickUnion qu = new QuickUnion (N);
			bool isConected = qu.isConnected (2, 3);
			Console.WriteLine ("2 and 3 " + isConected);

			qu.Union (2, 3);


			isConected = qu.isConnected (2, 3);
			Console.WriteLine ("2 and 3 " + isConected);

			qu.Union (3, 5);

		    isConected = qu.isConnected (3, 5);

			Console.WriteLine ("3 and 5 " + isConected);

			isConected = qu.isConnected (2, 5);

			Console.WriteLine ("2 and 5 " + isConected);


		}
	}
}
