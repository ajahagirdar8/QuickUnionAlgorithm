using System;

namespace QuickUnion
{
	public class QuickUnion
	{
		int[] ID;

		public QuickUnion (int N)
		{
			ID = new int[N];

			for (int i = 0; i < N; i++) {

				ID [i] = i;
			}
		}

		public int getRoot(int p)
		{
			while (ID [p] != p)
				p = ID [p];

			return p;
		}

		public bool isConnected(int p, int q)
		{
			return getRoot (p) == getRoot (q);
		}

		public void Union(int p, int q)
		{
			int rootP = getRoot (p);
			int rootQ = getRoot (q);

			ID [rootP] = rootQ;
		}

	}
}

