using System;

public class Average
{
	public static void Main()
	{
		double zero = 0, number, counter = 0, average;
		string mark;
		Console.Write("Insert a mark: ");
		mark = Console.ReadLine();

		while (mark != "end")
		{
			number = Convert.ToDouble(mark);
			counter++;
			zero += number;
			Console.Write("Insert a mark: ");
			mark = Console.ReadLine();
		}

		if (counter != 0)
		{
			average  = zero / counter;
			Console.WriteLine("The average is {0}.", average);
		}
	}
}
