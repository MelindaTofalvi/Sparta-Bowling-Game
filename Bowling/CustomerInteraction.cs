using System;

namespace Bowling
{
	public class CustomerInteraction 
	{
		public static string Name { get; set; }

		public void Greeting()
        {
            Console.WriteLine("Welcome to the Awesome Bowling Game! Can I have your name, please?");
            Name = Console.ReadLine();
            Console.WriteLine($"It's nice to meet you {Name}! And now let the game begin!");
        }

        public void End_Of_Game_Message()
		{
			
			if(Game.Result >= 250)
			{
				Console.WriteLine($"Congratulations {Name}, you rock!");
				NewGame();
			}
			else if(Game.Result >= 150)
			{
				Console.WriteLine($"Not too bad, {Name}. You did better than the average.");
				NewGame();
			}
			else
			{
				Console.WriteLine($"Maybe you should practice a bit more, {Name}");
				NewGame();
			}

		}

        public void NewGame()
		{
			Console.WriteLine("Do you want to start a new game? Y/N");
			string AnotherGame = Console.ReadLine().ToLower();


			if (AnotherGame == "y")
            {
			    MainClass.Main();
            }
			else if(AnotherGame == "n")
			{
				Console.WriteLine($"Goodbye {Name}! I hope to see you soon.");
			}
			else
			{
				Console.WriteLine("Invalid Input. Let's try again.");
				NewGame();
			}

		}

		public void AskForInput()
		{
			Console.WriteLine($"{Name}, please press enter to throw the ball");
			string AnyKey = Console.ReadLine();
		}
    }
}