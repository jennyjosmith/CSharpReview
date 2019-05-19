using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// source: Agile Software Development Book II by Lynn Smith
namespace Example3dot1
{
	class Program
	{
		static void Main(string[] args)
		{
			// declare and initialize a list
			List<int> Scores = new List<int>
			{ 78,86,95,100,45,89,83,77,86,83};
			Display(Scores);
			Scores.Add(99);
			Display(Scores);
			//Insert a number 100 right before the last number
			Scores.Insert(Scores.Count - 1, 100);
			Display(Scores);
			//Remove the first 86
			Scores.Remove(86);
			Display(Scores);
			//remove the 6th number which is at position 5
			Scores.RemoveAt(5);
			Display(Scores);

			//Find the position of the number 100 and display the position vaue
			if (Scores.Contains(100))
				Console.WriteLine($"A 100 at: {Scores.BinarySearch(100)}");

			//Sort the numbers
			Scores.Sort();
			Display(Scores);
			Console.ReadKey();

			//The Display method used above
			void Display(List<int> s)
			{
				foreach(int a in s)
				{ Console.Write(a + " ");
				}
				Console.WriteLine();
			}

		}
	}
}
