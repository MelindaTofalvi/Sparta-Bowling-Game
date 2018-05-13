using System;
namespace Bowling
{
	public class Frame
	{
		public static string Name { get; set; }

		public void Greeting()
		{
			
			Console.WriteLine("Welcome to the Awesome Bowling Game! Can I have the next champion's name, please?");
			Name = Console.ReadLine();
			Console.WriteLine($"It's nice to meet you {Name}! And now let the game begin!");

		}
	}
}

