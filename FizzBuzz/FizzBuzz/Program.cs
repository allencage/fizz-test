﻿using System;

namespace FizzBuzz
{
	class Program
    {
        static void Main(string[] args)
        {
			var count = new FizzBuzzCounting();
			count.Counting();
			Console.ReadKey();
        }
    }

    class FizzBuzzCounting
    {
		public void Counting()
		{
			for (int i = 1; i < 101; i++)
			{
				if ((i % 3 == 0) && (i % 5 == 0))
					Console.WriteLine("FizzBuzz");
				else if (i % 5 == 0)
					Console.WriteLine("Buzz");
				else if (i % 3 == 0)
					Console.WriteLine("Fizz");
				else
					Console.WriteLine(i);
			}
		}
    }
}
