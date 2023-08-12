using System;
namespace JogoDaForca
{
	internal class World
	{
		public int Lines;

		public int Columns;

		public char[,] Map;

		public World(int lines, int columns)
		{
			Lines = lines;

			Columns = columns;

			Map = new char[Lines, Columns];
		}

		public void Fill()
		{
			for (int l = 0; l < Lines; l++)
			{
				for (int c = 0; c < Columns; c++)
				{
					Map[l, c] = 'X';
				}
			}
		}
	}
}